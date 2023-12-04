using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections;

namespace scoop
{


public class Hashtable2D
    {
        /// <summary>
        /// This is a hashtable of hashtables
        /// The X dim is the root key, and the y is the internal hashes key
        /// </summary>
        /// 
        private Hashtable root = new Hashtable();
        public bool overwriteDuplicates = false;
        public bool alertOnDuplicates = true;
        private Action_Record error_ar;

        public Hashtable2D()
        {
            error_ar=new Action_Record();
            error_ar.action=Action.error;
        }
        public void AddRow(object key_x)
        {
            Hashtable tempHT = new Hashtable();            
            root.Add(key_x, tempHT);
            
        }

        public void Add(object key_x, object key_y, Action_Record toStore)
        {
            if(root[key_x]!=null)//If key_x has already been entered 
            {
                Hashtable tempHT = (Hashtable)root[key_x];//IF the hash table does not exist then focus will skip to the catch statement
                if (tempHT[key_y] == null)  tempHT.Add(key_y, toStore);
                else handleDuplicate(tempHT, key_x, key_y, toStore);
            }else{//Making a new hashtable 
                Hashtable tempHT = new Hashtable();
                tempHT.Add(key_y, toStore);
                root.Add(key_x, tempHT);
            }

        }

        public void Remove(object key_x, object key_y)
        {
            try{
                ((Hashtable)root[key_x]).Remove(key_y);
            }catch(Exception e){
                Console.WriteLine("That item does not exist");
            }

        }

        public void handleDuplicate(Hashtable tempHT, object key_x, object key_y, Action_Record toStore)
        {
            if (alertOnDuplicates) Console.WriteLine("This Item" + key_x + " " + key_y + " already Exists in the collection");

            if (overwriteDuplicates)
            {
                tempHT.Remove(key_y);
                tempHT.Add(key_y,toStore);
            }
        }

        public Action_Record getItem(object key_x, object key_y)
        {
            try
            {
                Hashtable tempHT = (Hashtable)root[key_x];
                return (Action_Record)tempHT[key_y];
            }
            catch (NullReferenceException e)
            {
                return error_ar;
            }
            
            
            
        }

        

    }
}