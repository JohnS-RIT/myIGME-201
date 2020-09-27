using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PetApp
{
    //Class: Pets
    //Purpose: Give blueprints on creation of Pet and called methods
    public class Pets
    {
        public List<Pet> petList = new List<Pet>();

        public Pet this[int nPetEl]
        {
            get
            {
                Pet returnVal;
                try
                {
                    returnVal = (Pet)petList[nPetEl];
                }
                catch
                {
                    returnVal = null;
                }

                return (returnVal);
            }

            set
            {
                // if the index is less than the number of list elements
                if (nPetEl < petList.Count)
                {
                    // update the existing value at that index
                    petList[nPetEl] = value;
                }
                else
                {
                    // add the value to the list
                    petList.Add(value);
                }
            }
        }

        //Method: Count
        //Purpose: Returns petList length
        public int Count
        {
            get
            {
                return petList.Count;
            }
        }

        //Method: Add
        //Purpose: Add pet to petList
        public void Add(Pet pet)
        {
            petList.Add(pet);
        }

        //Method: Remove
        //Purpose: Remove pet from petList
        public void Remove(Pet pet)
        {
            petList.Remove(pet);
        }

        //Method: RemoveAt
        //Purpose: Remove pet from petList based on index
        public void RemoveAt(int petEI)
        {
            petList.RemoveAt(petEI);
        }
    }
}
