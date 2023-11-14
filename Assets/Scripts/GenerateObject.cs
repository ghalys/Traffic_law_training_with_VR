using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// Generates the objects in the specific positions after starting the program.
/// </summary>
public class GenerateObject : MonoBehaviour
{
    // Number of vehicles
    private int _vehiclesNum;

    // Awake is called when the script instance is being loaded
    private void Awake()
    {
        Init();
    }

    // Initializate parameters
    private void Init()
    {
        // Get human points
        GameObject[] humanPoints = GameObject.FindGameObjectsWithTag("HumanPoint");
        // Temporary list for people
        List<HumanBehavior> peopleList = new List<HumanBehavior>();
        // Search human points
        foreach (GameObject humanPoint in humanPoints)
        {
            // Get some gender
            string gender = DrawGender();
            // Load prefab
            GameObject humanPrefab = Resources.Load<GameObject>("People/Man/Man");

            // Generate person
            GameObject human = GameObject.Instantiate<GameObject>(humanPrefab,
                humanPoint.transform.position, Quaternion.identity, humanPoint.transform.parent);
            // Add script to list
            peopleList.Add(human.GetComponent<HumanBehavior>());
        }
        // Convert list to array
        HumanBehavior[] humanBehaviors = peopleList.ToArray();
        // Search people
        foreach (HumanBehavior humanBehavior in humanBehaviors)
            // Prepare people
            humanBehavior.PreparePeople();
    }

    /// <summary>
    /// Draws the gender of the person (male or female).
    /// </summary>
    /// <returns>
    /// The label that represents the gender.
    /// </returns>
    private string DrawGender()
    {
        return "Man";
        // // Draw number
        // int number = Random.Range(0, 2);
        // // It is a man
        // if (number.Equals(0))
        //     return "Man";
        // // It is a woman
        // return "Woman";
    }


}