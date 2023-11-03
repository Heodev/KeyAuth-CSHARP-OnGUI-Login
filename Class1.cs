using KeyAuth;
using UnityEngine;

public class Gui : MonoBehaviour
{
    public static api KeyAuthApp = new api(
        name: "Loader",
        ownerid: "IkzxOOaDDu",
        secret: "5e9a93e37583947ec9e1919435115b01af12b4196580b918e7cfc883f0853214",
        version: "1.0"
    );

    private string usernameField = "";
    private string passwordField = "";
    private bool loginSuccess = false;

    private void Start()
    {
        KeyAuthApp.init();
    }

    private void OnGUI()
    {
        if (!loginSuccess)
        {
            GUILayout.BeginVertical();
            GUILayout.Label("This is a KeyAuth Unity Example Login.");
            usernameField = GUILayout.TextField(usernameField, 25);
            passwordField = GUILayout.PasswordField(passwordField, '*', 25);
            if (GUILayout.Button("Login"))
            {
                KeyAuthApp.login(usernameField, passwordField);
                if (KeyAuthApp.response.success)
                {
                    loginSuccess = true;
                    Debug.Log("Login successfull");
                }
                else
                {
                    Debug.Log("Login failed");
                }
            }
            GUILayout.EndVertical();
        }
        else
        {
            GUILayout.BeginVertical();
            GUILayout.Label("Logged in as: " + KeyAuthApp.user_data.username);
            if (GUILayout.Button("Button 1"))
            {
                Debug.Log("Button 1 was pressed");
            }
            if (GUILayout.Button("Button 2"))
            {
                Debug.Log("Button 2 was pressed");
            }
            if (GUILayout.Button("Button 3"))
            {
                Debug.Log("Button 3 was pressed");
            }
            if (GUILayout.Button("Button 4"))
            {
                Debug.Log("Button 4 was pressed");
            }
            if (GUILayout.Button("Button 5"))
            {
                Debug.Log("Button 5 was pressed");
            }
            GUILayout.EndVertical();
        }
    }
}
