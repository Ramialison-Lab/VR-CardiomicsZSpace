using UnityEngine;
using UnityEngine.UI;

// Needed to access onscreen elements

/*****
 * 
 * 'Explodes' the heart by slices to allow the user to view each slice individually.
 * Displaces each slice an equal distance away from each other by using the transform function.
 * 
 *****/


public class Explode : MonoBehaviour
{

    public Button expandBtn;
    public Button resetBtn;

    private float toggle = 0;

    Vector3[] startPositions = new Vector3[5];

    // Position of slices at load

    public Text explodeBtnTxt;
    // 'Expand' or 'Collapse' button

    // So we can iterate over each slice
    private static string[] slices = new string[5] { "Slice_A", "Slice_B", "Slice_C", "Slice_D", "Slice_E" };

    // Whether we are currently 'exploded' (Not bool so I can use in calculations, C# is cooky about this it seems)
    int exploded = 1;

    // Record the start position for each of the slices
    void Start()
    {

        for (int i = 0; i < 5; i++)
        {
            startPositions[i] = GameObject.Find(slices[i]).transform.position;

        }
    }

    // Resets all slices back to their start positions
    public void Reset()
    {
        explodeBtnTxt.text = "Expand";
        exploded = 1;

    }

    // If the slices are exploded pull them in, or vice versa
    public void Splode()
    {

        expandBtn.interactable = false;
        resetBtn.interactable = false;


        for (int i = 0; i < 5; i++)
        {

            Vector3 next;
            Vector3 current;

            if (slices[i] == "Slice_A") toggle = 1.6f;
            else if (slices[i] == "Slice_B") toggle = 0.8f;
            else if (slices[i] == "Slice_C") toggle = 0f;
            else if (slices[i] == "Slice_D") toggle = -0.8f;
            else if (slices[i] == "Slice_E") toggle = -1.6f;

            if (exploded == 1)
            {
                next = new Vector3(startPositions[i].x + (0.0F + (toggle)), startPositions[i].y + 0.0F, startPositions[i].z + 0.0F);
            }
            else
            {
                next = startPositions[i];
            }
            current = GameObject.Find(slices[i]).transform.position;
            System.Collections.IEnumerator sp = slide(i, next, current);
            StartCoroutine(sp);

        }

        if (exploded == 1)
        {
            explodeBtnTxt.text = "Collapse";
        }
        else
        {
            explodeBtnTxt.text = "Expand";
        }

        exploded = exploded * -1;
    }

    // Smooth glide to the finish line
    System.Collections.IEnumerator slide(int i, Vector3 next, Vector3 current)
    {

        float duration = 0.4f;

        float t = 0f;
        while (t < 1)
        {
            t += Time.deltaTime / duration;
            GameObject.Find(slices[i]).transform.position = Vector3.Lerp(current, next, t);
            yield return null;
        }

        expandBtn.interactable = true;
        resetBtn.interactable = true;
    }

}
