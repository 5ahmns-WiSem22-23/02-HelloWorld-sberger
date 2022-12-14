using UnityEngine;

public class HelloMethoden : MonoBehaviour
{

    private int startValue = 0;

    private int startValue3 = 0;

    private int startValue4 = 10;

    private int startValue5 = 20;


    void Start() {
        Debug.Log("Hallo Methoden!");

        Debug.Log("before startValue: " + startValue);
        IncrementByone();
        Debug.Log("after startValue: " + startValue);

        Debug.Log("before startValue: " + startValue3);
        IncrementByX(Random.Range(1, 10));
        Debug.Log("after start Value: " + startValue3);

        Debug.Log("before startValue: " + startValue4);
        DecrementByOne(startValue4);
        Debug.Log("after start Value: " + startValue4);

        Debug.Log("before startValue:" + startValue5);
        startValue5 = DecrementByX(startValue5, 2);
        Debug.Log("after start Value: " + startValue5);
    }

    private int DecrementByX(int start, int valToSub) {
        return start - valToSub;
    }

    private void DecrementByOne(int val) {
        val--;
        Debug.Log("val: " + val);
    }
    private void IncrementByX(int valToAdd) {
        startValue3 += valToAdd;
    }

    private void IncrementByone() {
        startValue++;
    }
}