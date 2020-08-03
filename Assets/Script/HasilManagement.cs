using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HasilManagement : MonoBehaviour
{
    public void MainMenu () {
		Application.LoadLevel ("MainMenu");
	}
	
	public void Pertama () {
		Application.LoadLevel ("20");
	}
	
	public void Kedua () {
		Application.LoadLevel ("70");
	}
	
	public void Ketiga () {
		Application.LoadLevel ("120");
	}
	
	public void Keempat () {
		Application.LoadLevel ("170");
	}
	
	public void Kelima () {
		Application.LoadLevel ("270");
	}
	
	public void Keenam () {
		Application.LoadLevel ("270-600");
	}
	
	public void Ketujuh () {
		Application.LoadLevel ("600");
	}
	
	public void Kedelapan () {
		Application.LoadLevel ("Lebih");
	}
	
	public void Hasil () {
		Application.LoadLevel ("Hasil");
	}
}
