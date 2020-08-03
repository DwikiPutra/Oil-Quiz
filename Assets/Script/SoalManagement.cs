using UnityEngine;
using System.Collections;

public class SoalManagement : MonoBehaviour
{
    public void MainMenu () {
		Application.LoadLevel ("MainMenu");
	}
	
	public void Benar1 () {
		Application.LoadLevel ("Soal2");
	}
	
	public void Benar2 () {
		Application.LoadLevel ("Soal3");
	}
	
	public void Benar3 () {
		Application.LoadLevel ("Soal4");
	}
	
	public void Benar4 () {
		Application.LoadLevel ("Soal5");
	}
	
	public void Benar5 () {
		Application.LoadLevel ("Win");
	}
	
	public void Salah () {
		Application.LoadLevel ("Lose");
	}
}
