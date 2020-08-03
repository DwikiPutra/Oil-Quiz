using UnityEngine;
using System.Collections;

public class SceneManagement : MonoBehaviour
{
    public void MainMenu () {
		Application.LoadLevel ("MainMenu");
	}
	public void About () {
		Application.LoadLevel ("About");
	}
	
	public void PanduanMateri () {
		Application.LoadLevel ("PanduanMateri");
	}

	public void PanduanProses () {
		Application.LoadLevel ("PanduanProses");
	}
	
	public void Play () {
		Application.LoadLevel ("Play");
	}	
	
	public void Close () {
		Application.Quit ();
	}
	
	public void Materi1 () {
		Application.LoadLevel ("Materi1");
	}
	
	public void Materi2 () {
		Application.LoadLevel ("Materi2");
	}
	
	public void Hasil () {
		Application.LoadLevel ("Hasil");
	}
}
