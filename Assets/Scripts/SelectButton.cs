sing System.Collections;
using UnityEngine.UI;
using System.Collections.Generic;
using UnityEngine;

public class SelectButton : MonoBehaviour
	{
		
		public Canvas Select;
		public Button SButton;

		void Update()
		{
			Button btn = SButton.GetComponent<Button>();
			btn.onClick.AddListener(SelectClick);
		}

		void SelectClick()
		{
			Debug.Log("You have clicked the button!");
		}
	}
