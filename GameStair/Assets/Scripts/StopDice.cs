using UnityEngine;
using UnityEditor;
using System.Collections;
using System.Collections.Generic;

public class StopDice : MonoBehaviour {

	// Declare variables
	private bool isHeld;
	private int clicks;
	public Animator anim;
	public SpriteRenderer animacion;
	public int valor;


	List<pregunta> Trivial = new List<pregunta>();
	private Rect windowRect;// = new Rect(10, 20, 850, 400);

	void Start ()
	{
		anim = GetComponent<Animator>();
		animacion = GetComponent<SpriteRenderer>();
		valor = 0;


	}



	// Update is called once per frame
	void Update ()
	{
	

		if (Input.GetMouseButtonDown(0) || Input.GetKeyDown(KeyCode.Space))
		{
			startDice();

		}
	}



	public int obtenerValor()
	{
		if (anim.speed == 0) {

			if (animacion.sprite.name.Equals ("dado sf_0")) {
				return 1;
			}
			if (animacion.sprite.name.Equals ("dado sf_1")) {
				return 2;

			}
			if (animacion.sprite.name.Equals ("dado sf_2")) {
				return 3;

			}
			if (animacion.sprite.name.Equals ("dado sf_3")) {
				return 4;
	
			}
			if (animacion.sprite.name.Equals ("dado sf_4")) {
				return 5;

			}
			if (animacion.sprite.name.Equals ("dado sf_5")) {
				return 6;
	
			}
			return 0;
		} else {
			return 0;
		}
	}

	public void startDice(){



		if (anim.speed == 1) {
		
			anim.speed = 0;
			/*questions();
			OnGUI();*/

		} else {

			anim.speed = 1;
		}
	}

	/*
	int i=1;
	int resp =0;
	int a=10;
	int b=50;
	int c=390;
	int d=100;
	int e=430;
	int f=170;
	int g=290;
	
	
	int saltos(string cad)
	{
		if (cad != null) {
			string[] aux = cad.Split ('\n');
			return aux.Length - 1;
		} else {
			return 0;
		}
		
		//Debug.Log (cad);
		//Debug.Log(aux.Length-1);
		
	}


	void formato(string cad)
	{
		Debug.Log("entra1");
		//int z = saltos (cad);
		//Debug.Log("z="+z);
		if (saltos (cad) == 0) {
			//Debug.Log("entra2");
			
			if (saltos (Trivial [i].getResp1 ()) == 0 && saltos (Trivial [i].getResp2 ()) == 0 && saltos (Trivial [i].getResp3 ()) == 0 && saltos (Trivial [i].getResp4 ()) == 0 && saltos (Trivial [i].getResp5 ()) == 0) {
				windowRect = new Rect (10, 20, 600, 300);
				
				a = 50;
				b = 50;
				c = 150;
				d = 50;
				e = 330; 
				f = 150;
				g = 250;
				
			} else {
				
				if (saltos (Trivial [i].getResp1 ()) > 2 || saltos (Trivial [i].getResp2 ()) > 2 || saltos (Trivial [i].getResp3 ()) > 2 || saltos (Trivial [i].getResp4 ()) > 2 || saltos (Trivial [i].getResp5 ()) > 2) {
					windowRect = new Rect (10, 20, 850, 400);
					a = 10;
					b = 50;
					c = 390;
					d = 100;
					e = 430;
					f = 170;
					g = 290;
				}
			}
			
		} 
		else {
			if (saltos (cad)>= 1 && saltos (cad)<3){
				
				if (saltos (Trivial [i].getResp1 ()) == 0 && saltos (Trivial [i].getResp2 ()) == 0 && saltos (Trivial [i].getResp3 ()) == 0 && saltos (Trivial [i].getResp4 ()) == 0 && saltos (Trivial [i].getResp5 ()) == 0) {
					windowRect = new Rect(10, 20, 800, 400);
					
					a = 50;
					b = 50;
					c = 150;
					d = 50;
					e = 330; 
					f = 150;
					g = 250;
					
				}
				else
				{
					if (saltos (Trivial [i].getResp1 ()) > 2 || saltos (Trivial [i].getResp2 ()) > 2 || saltos (Trivial [i].getResp3 ()) > 2 || saltos (Trivial [i].getResp4 ()) > 2 || saltos (Trivial [i].getResp5 ()) > 2) {
						windowRect = new Rect(10, 20, 850, 400);
						
						a = 10;
						b = 50;
						c = 390;
						d = 100;
						e = 430;
						f =170;
						g = 290;				
					}
				}
				
			}
			
		}
	}
	
	
	
	
	
	void OnGUI() {
		string p = Trivial [i].getQuestion();
		windowRect = GUI.Window(0, windowRect, DoMyWindow, p);
		
		
	}
	
	
	void DoMyWindow(int windowID) {
		
		//Random r = new Random();
		//print(r);
		
		string q1 = Trivial [i].getResp1();
		string q2 = Trivial [i].getResp2();
		string q3 = Trivial [i].getResp3();
		string q4 = Trivial [i].getResp4();
		string q5 = Trivial [i].getResp5();
		
		//string[] options = new string[] {q1, q2, q3, q4};
		
		//if (GUI.Button(new Rect(10, 20, 100, 20), q1)) 
		if (q1 != null) 
			if(GUI.Button (new Rect (a, b, c, d), q1))
				resp = 1;
		Debug.Log (resp);
		
		if(q2!=null)
			if(GUI.Button (new Rect (e, b, c, d), q2))
				resp = 2;
		Debug.Log (resp);
		
		if(q3!=null)
			if(GUI.Button (new Rect (a, f, c, d), q3))
				resp = 3;
		Debug.Log (resp);
		
		if(q4!=null)
			if(GUI.Button (new Rect (e, f, c, d), q4))
				resp = 4;
		Debug.Log (resp);
		
		if(q5!=null)
			if(GUI.Button (new Rect (g, e, c, d), q5))
				resp = 5;
		Debug.Log (resp);
		
	}
	
	public void questions ()
	{	
		
		//Pregunta 1
		string preg = "La inmunidad innata se caracteriza por ser inespecifica y actuar inmediatamente," +"\n" + "señale los elementos Humorales y Celulares propios de esta:";
		string resp1 = "Linfocitos T - Anticuerpos";
		string resp2 = "Macrofagos - Lisozima";
		string resp3 = "Complemento";
		string resp4 = null;
		string resp5 = null;
		int respv = 1;
		int id = 1;
		
		pregunta p1 = new pregunta(preg, resp1, resp2, resp3, resp4, resp5, respv, id);
		Trivial.Add (p1);
		
		//Pregunta 2
		preg = "De las siguientes opciones,"+"\n"+ "señale la definicion que corresponda al termino Hapteno.";
		resp1 = "Molécula glicoproteína que tiene la capacidad"+"\n"+ "de reconocer un antígeno especifico.";
		resp2 = "Molécula de la superficie celular de los LT"+"\n"+ "que facilita el proceso de activación"+"\n"+ "de los linfocitos B.";
		resp3 = "Antígeno incompleto, que para ser reconocido"+"\n"+ "por el sistema inmune requiere de la"+"\n"+ "colaboración de un adyuvante.";
		resp4 = "Molécula presente en algunos virus( VIH),"+"\n"+ "Bacterias(Streptococos, Stafilococos) y "+"\n"+ "Parasitos(Plasmodium) que producen una activación"+"\n"+ " policlonal masiva equivalente al 20% "+"\n"+ "de las células del sistema inmune";
		
		respv = 3;
		id = 2;
		
		pregunta p2 = new pregunta(preg, resp1, resp2, resp3, resp4, resp5, respv, id);
		Trivial.Add (p2);
		
		//Pregunta 3
		preg = "Señale en cual de los siguientes organos linfoides "+"\n"+ "ocurre la seleccion positiva y negativa de los LT (Linfositos T).";
		resp1 = "Medula osea fetal.";
		resp2 = "Bazo.";
		resp3 = "Higado Fetal.";
		resp4 = "Timo";
		resp5 = "Placas de Peyer";
		
		respv = 4;
		id = 3;
		
		pregunta p3 = new pregunta(preg, resp1, resp2, resp3, resp4, resp5, respv, id);
		Trivial.Add (p3);
		
		//Pregunta 4
		preg = "El Complejo de ataque a membrana (mac)"+"\n"+ "es el mecansismo final efector del complemento mediante el cual"+"\n"+ "se generan poros en la membrana de la celula blanco y "+"\n"+ "posteriormente se da la lisis osmotica, "+"\n"+ "señale las moleculas del complemento "+"\n"+ "que constituyen este complejo.";
		resp1 = "C5bC6C7C8C9n.";
		resp2 = "C3b-Fb.";
		resp3 = "Properdin C3b-Fb";
		resp4 = "ProperdinBbC3bC5C6";
		resp5 = "C5bC6C7C8";
		
		respv = 1;
		id = 4;
		
		pregunta p4 = new pregunta(preg, resp1, resp2, resp3, resp4, resp5, respv, id);
		Trivial.Add (p4);
		
		//Pregunta 5
		preg = "Seleccione de las siguientes proteinas del "+"\n"+ "complemento cuales hacen parte  de las anafilotoxinas:";
		resp1 = "C9.";
		resp2 = "C1q.";
		resp3 = "C3a";
		resp4 = "C8";
		resp5 = "C5a";
		
		respv = 1;
		id = 5;
		
		pregunta p5 = new pregunta(preg, resp1, resp2, resp3, resp4, resp5, respv, id);
		Trivial.Add (p5);
		
		//Pregunta 6
		preg = "Los anticuerpos son glicoproteínas de gran peso molecular "+"\n"+ "secretadas por los linfocitos b activados(células plasmáticas) "+"\n"+ "por los lt helper como resultado de la respuesta inmune especifica,"+"\n"+ "señale cual es el anticuerpo predominante"+"\n"+ " en la respuesta inmune secundaria:";
		resp1 = "IgD.";
		resp2 = "IgG.";
		resp3 = "IgA";
		resp4 = "IgM.";
		resp5 = "IgE";
		
		respv = 1;
		id = 6;
		
		pregunta p6 = new pregunta(preg, resp1, resp2, resp3, resp4, resp5, respv, id);
		Trivial.Add (p6);
		
		//Pregunta 7
		preg = "Las inmunoglobulinas  de acuerdo a  su estructura y peso molecular "+"\n"+ "pueden o no atravesar la barrera placentaria, señale cual de las siguientes "+"\n"+ "inmunoglobulinas no atraviesa la barrera placentaria:";
		resp1 = "IgD.";
		resp2 = "IgG.";
		resp3 = "IgM";
		resp4 = "IgA.";
		resp5 = "IgE";
		
		respv = 3;
		id = 7;
		
		pregunta p7 = new pregunta(preg, resp1, resp2, resp3, resp4, resp5, respv, id);
		Trivial.Add (p7);
		
		//Pregunta 8
		preg = "Cuales de las siguientes inmunoglobulinas activan el complemento  por la via clasica:";
		resp1 = "IgD.";
		resp2 = "IgG.";
		resp3 = "IgA";
		resp4 = "IgM.";
		resp5 = "IgE";
		
		respv = 3;
		id = 8;
		
		pregunta p8 = new pregunta(preg, resp1, resp2, resp3, resp4, resp5, respv, id);
		Trivial.Add (p8);
		
		//Pregunta 9
		preg = "Señale las características de la respuesta inmune inespecífica:";
		resp1 = "Depende principalmente de los Linfocitos B y T.";
		resp2 = "Es específica y de memoria.";
		resp3 = "Facilita los mecanismos efectores al  "+"\n"+ "integrarse con la inmunidad específica";
		resp4 = "Es rápida y no se intensifica con los contactos ulteriores.";
		resp5 = "En ella prima la IgM ";
		
		respv = 3;
		id = 9;
		
		pregunta p9 = new pregunta(preg, resp1, resp2, resp3, resp4, resp5, respv, id);
		Trivial.Add (p9);
		
		//Pregunta 10
		preg = "Señale cual de los elementos  NO es un componente de la inmunidad innata:";
		resp1 = "Flora bacteriana.";
		resp2 = "Factores constitutivos "+"\n"+ "(Genéticos-Hormonales-Metabólicos).";
		resp3 = "Proteína C reactiva";
		resp4 = "Células plasmáticas.";
		resp5 = "Fagocitosis.";
		
		respv = 4;
		id = 10;
		
		pregunta p10 = new pregunta(preg, resp1, resp2, resp3, resp4, resp5, respv, id);
		Trivial.Add (p10);
		
		//Pregunta 11
		preg = "Señale cuales de las siguientes células  NO  participan en el proceso de inflamación:";
		resp1 = "Macrófagos.";
		resp2 = "Eosinofilos.";
		resp3 = "Plaquetas";
		resp4 = "Fibroblastos.";
		resp5 = "Linfocito T.";
		
		respv = 5;
		id = 11;
		
		pregunta p11 = new pregunta(preg, resp1, resp2, resp3, resp4, resp5, respv, id);
		Trivial.Add (p11);
		
		//Pregunta 12
		preg = "Durante el desarrollo embrionario los linfocitos T "+"\n"+ "deben recibir una serie de receptores de membrana que "+"\n"+ "permiten su selección clonal y ulterior  desarrollo Y,"+"\n"+ "señale en el órgano que ocurre este proceso:";
		resp1 = "Bazo.";
		resp2 = "Páncreas.";
		resp3 = "Hígado";
		resp4 = "Timo.";
		resp5 = "Médula osea.";
		
		respv = 4;
		id = 12;
		
		pregunta p12 = new pregunta(preg, resp1, resp2, resp3, resp4, resp5, respv, id);
		Trivial.Add (p12);
		
		//Pregunta 13
		preg = "En la siguiente lista señale los órganos linfoides primarios:";
		resp1 = "Médula Osea - Timo.";
		resp2 = "Bazo - Sistema inmune de la piel.";
		resp3 = "Ganglios Linfáticos - GALT.";
		resp4 = "Timo - Bazo.";
		resp5 = "Médula osea - Ganglios Linfáticos.";
		
		respv = 1;
		id = 13;
		
		pregunta p13 = new pregunta(preg, resp1, resp2, resp3, resp4, resp5, respv, id);
		Trivial.Add (p13);
		
		//Pregunta 14
		preg = "En la siguiente lista señale los órganos linfoides primarios:";
		resp1 = "Médula Osea - Timo.";
		resp2 = "Bazo - Sistema inmune de la piel.";
		resp3 = "Ganglios Linfáticos - GALT.";
		resp4 = "Timo - Bazo.";
		resp5 = "Médula osea - Ganglios Linfáticos.";
		
		respv = 1;
		id = 14;
		
		pregunta p14 = new pregunta(preg, resp1, resp2, resp3, resp4, resp5, respv, id);
		Trivial.Add (p14);
		
		//Pregunta 15
		preg = "Son funciones del complemento excepto:";
		resp1 = "Activación de PMN - Activación de Linfocitos T.";
		resp2 = "Lisis bacteriana mediante CAM"+"\n"+ "Potencializa la producción de anticuerpos"+"\n"+ "Opzonización.";
		resp3 = null;
		resp4 = null;
		resp5 = null;
		
		respv = 2;
		id = 15;
		
		pregunta p15 = new pregunta(preg, resp1, resp2, resp3, resp4, resp5, respv, id);
		Trivial.Add (p15);
		
		//Pregunta 16
		preg = "Cuales son los componentes del complejo de ataque a la membrana";
		resp1 = "C1qIgM.";
		resp2 = "C4b,2al.";
		resp3 = "C5b,6,7,8(C9)n.";
		resp4 = "C4b,2b,3b.";
		resp5 = "C1qC5,7,9.";
		
		respv = 3;
		id = 16;
		
		pregunta p16 = new pregunta(preg, resp1, resp2, resp3, resp4, resp5, respv, id);
		Trivial.Add (p16);
		
		//Pregunta 17
		preg = "Señale las fracciones del complemento con actividad de anafilotoxinas";
		resp1 = "C7.";
		resp2 = "C1q.";
		resp3 = "C3a.";
		resp4 = "C4b2a.";
		resp5 = "C5a.";
		
		respv = 5;
		id = 17;
		
		pregunta p17 = new pregunta(preg, resp1, resp2, resp3, resp4, resp5, respv, id);
		Trivial.Add (p17);
		
		//Pregunta 18
		preg = "Señale cuales de las siguientes proteínas son reguladoras de la actividad del complemento:";
		resp1 = "Proteína C reactiva - Factor X.";
		resp2 = "Proteína S - Factor H - Receptor del complemento  tipo 1(CR1).";
		resp3 = null;
		resp4 = null;
		resp5 = null;
		
		respv = 2;
		id = 18;
		
		pregunta p18 = new pregunta(preg, resp1, resp2, resp3, resp4, resp5, respv, id);
		Trivial.Add (p18);
		
		//Pregunta 19
		preg = "Señale la fracción de los anticuerpos en la que reside las "+"\n"+ "funciones efectoras de los anticuerpos tales como fijación de complemento:";
		resp1 = "FAB.";
		resp2 = "Paratope.";
		resp3 = "Puentes disulfuro.";
		resp4 = "Región hipervariable.";
		resp5 = "FC.";
		
		respv = 5;
		id = 19;
		
		pregunta p19 = new pregunta(preg, resp1, resp2, resp3, resp4, resp5, respv, id);
		Trivial.Add (p19);
		
		//Pregunta 20
		preg = "Señale la célula responsable de la producción de los anticuerpos:";
		resp1 = "Células dendríticas.";
		resp2 = "Macrófagos.";
		resp3 = "LT h1.";
		resp4 = "LB.";
		resp5 = "LT h2.";
		
		respv = 4;
		id = 20;
		
		pregunta p20 = new pregunta(preg, resp1, resp2, resp3, resp4, resp5, respv, id);
		Trivial.Add (p20);
		
		//Pregunta 21
		preg = "Señale cual es la inmunoglobulina más abundante en el plasma:";
		resp1 = "IgM.";
		resp2 = "IgA.";
		resp3 = "IgG.";
		resp4 = "IgD.";
		resp5 = "IgE.";
		
		respv = 3;
		id = 21;
		
		pregunta p21 = new pregunta(preg, resp1, resp2, resp3, resp4, resp5, respv, id);
		Trivial.Add (p21);
		
		//Pregunta 22
		preg = "Señale cual es la inmunoglobulina más abundante en el plasma:";
		resp1 = "HLAII.";
		resp2 = "HLAI.";
		resp3 = "CD45.";
		resp4 = "CD1.";
		resp5 = null;
		
		respv = 1;
		id = 22;
		
		pregunta p22 = new pregunta(preg, resp1, resp2, resp3, resp4, resp5, respv, id);
		Trivial.Add (p22);
		
		//Pregunta 23
		preg = "Señale cual es la inmunoglobulina más abundante en el plasma:";
		resp1 = "HLAII.";
		resp2 = "HLAI.";
		resp3 = "CD45.";
		resp4 = "CD1.";
		resp5 = null;
		
		respv = 1;
		id = 23;
		
		pregunta p23 = new pregunta(preg, resp1, resp2, resp3, resp4, resp5, respv, id);
		Trivial.Add (p23);
		
		//Pregunta 24
		preg = "Señale cuales de las siguientes son células"+"\n"+ "presentadoras profesionales de antígenos:";
		resp1 = "Linfocitos T citotoxicos "+"\n"+ "Mastocitos.";
		resp2 = "Macrófagos"+"\n"+ "Células dendrítica.";
		resp3 = "Mastocitos"+"\n"+ "Macrófagos.";
		resp4 = "Células dendríticas"+"\n"+ "Linfocitos B.";
		resp5 = "Linfocitos B"+"\n"+ "Linfocitos T citotoxicos.";
		
		respv = 4;
		id = 24;
		
		pregunta p24 = new pregunta(preg, resp1, resp2, resp3, resp4, resp5, respv, id);
		Trivial.Add (p24);
		
		
		//Pregunta 25
		preg = "Señales cuales de las siguientes moléculas están involucradas"+"\n"+ " en la actividad efectora citotoxica de los LT:";
		resp1 = "Granzima"+"\n"+ "Perforina.";
		resp2 = "Complemento"+"\n"+ "IgM.";
		resp3 = "Lisozima"+"\n"+ "Granzima.";
		resp4 = "Complemento"+"\n"+ "IgM.";
		resp5 = "IgM"+"\n"+ "Perforina.";
		
		respv = 1;
		id = 25;
		
		pregunta p25 = new pregunta(preg, resp1, resp2, resp3, resp4, resp5, respv, id);
		Trivial.Add (p25);
		
		//Pregunta 26
		preg = "Señale cuales de las siguientes  molecular es indispensables para que una proteínas sea procesada vía proteosoma:";
		resp1 = "Proteinasa K.";
		resp2 = "Ubiquitina.";
		resp3 = "Citocromo C450.";
		resp4 = "Proteina P50.";
		resp5 = "Hemoglobina.";
		
		respv = 2;
		id = 26;
		
		pregunta p26 = new pregunta(preg, resp1, resp2, resp3, resp4, resp5, respv, id);
		Trivial.Add (p26);
		
		//Pregunta 27
		preg = "Los linfocitos T citotoxicos ejercen su acción mediante los siguiente mecanismos efectores,"+"\n"+ "señales las opciones  correctas:";
		resp1 = "Activación de complemento por la vida clásica.";
		resp2 = "Secreción de gránulos citotoxicos que contienen perforinas"+"\n"+ "Activación de la citocromo c "+"\n"+ "caspasas por las  granzimas.";
		resp3 = "Inhibición de la actividad de las proteínas "+"\n"+ "transportadoras de antígeno(TAP1,TAP2).";
		resp4 = "Proteina P50.";
		resp5 = "Hemoglobina.";
		
		respv = 2;
		id = 27;
		
		pregunta p27 = new pregunta(preg, resp1, resp2, resp3, resp4, resp5, respv, id);
		Trivial.Add (p27);
		
		//Pregunta 28
		preg = "Cual de las siguientes citoquinas es sintetizada por los linfocitos th1:";
		resp1 = "IL2 - INF γ.";
		resp2 = "TNF - INF γ.";
		resp3 = "IL5 - TNF.";
		resp4 = null;
		resp5 = null;
		
		respv = 2;
		id = 28;
		
		pregunta p28 = new pregunta(preg, resp1, resp2, resp3, resp4, resp5, respv, id);
		Trivial.Add (p28);
		
		//Pregunta 29
		preg = "Cual citoquina recibe la denominación de pirogeno endogeno:";
		resp1 = "IL14.";
		resp2 = "IL17.";
		resp3 = "ERITROPOYETINA.";
		resp4 = "IL1.";
		resp5 = "IL 8.";
		
		respv = 4;
		id = 29;
		
		pregunta p29 = new pregunta(preg, resp1, resp2, resp3, resp4, resp5, respv, id);
		Trivial.Add (p29);
		
		//Pregunta 30
		preg = "Cual citoquina recibe la denominación de pirogeno endogeno:";
		resp1 = "IL14.";
		resp2 = "IL17.";
		resp3 = "ERITROPOYETINA.";
		resp4 = "IL1.";
		resp5 = "IL 8.";
		
		respv = 4;
		id = 30;
		
		pregunta p30 = new pregunta(preg, resp1, resp2, resp3, resp4, resp5, respv, id);
		Trivial.Add (p30);
		
		//Pregunta 31
		preg = "Señale cual de las siguientes citoquinas tiene actividad antiviral directa:";
		resp1 = "IL12.";
		resp2 = "INF-γ.";
		resp3 = "TNF- α.";
		resp4 = "IL1ra.";
		resp5 = null;
		
		respv = 2;
		id = 31;
		
		pregunta p31 = new pregunta(preg, resp1, resp2, resp3, resp4, resp5, respv, id);
		Trivial.Add (p31);
		
		//Pregunta 32
		preg = "Señale cual es el papel de la inmunidad humoral contra los virus:";
		resp1 = "Tienen actividad antiviral directa.";
		resp2 = "Bloquea la unión del virus a la célula hospedera, "+"\n"+ "con lo cual se  previene la infección o la reinfección (IgAs)."+"\n"+ "Mejora la fagocitosis de las partículas virales(Opsonización)."+"\n"+ "Aglutinación de las partículas virales IgG, IgM e IgA."+"\n"+ "Media la opzonización por C3b."+"\n"+ "Lisa las partículas virales envueltas por el CAM";
		resp3 = "Media la opzonización por C3b."+"\n"+ "Lisa las partículas virales envueltas por el CAM."+"\n"+ "Tienen actividad antiviral directa";
		resp4 = null;
		resp5 = null;
		
		respv = 2;
		id = 32;
		
		pregunta p32 = new pregunta(preg, resp1, resp2, resp3, resp4, resp5, respv, id);
		Trivial.Add (p32);
		
		//Pregunta 33
		preg = "Señale cual de los siguientes mecanismos corresponde a una "+"\n"+ "estrategia de evasión de la respuesta inmune por parte de los protozoos:";
		resp1 = "Síntesis de moléculas inmunopotenciadoras."+"\n"+ "Mutación de los genes del complemento.";
		resp2 = "Mutación de los genes del complemento."+"\n"+ "Síntesis de proteínas inmunosupresoras.";
		resp3 = "Síntesis de moléculas inmunopotenciadoras."+"\n"+ "Expresión de superantigenos.";
		resp4 = "Expresión de superantigenos."+"\n"+ "Mimetismo molecular."+"\n"+ "Síntesis de proteínas inmunosupresoras";
		resp5 = null;
		
		respv = 4;
		id = 33;
		
		pregunta p33 = new pregunta(preg, resp1, resp2, resp3, resp4, resp5, respv, id);
		Trivial.Add (p33);
		
		//Pregunta 34
		preg = "Cual de las siguientes inmunoglobulinas permiten la opsoniza de los parásitos"+"\n"+ " y la unión  de los  eosinófilos a través de sus receptores para fc épsilon:";
		resp1 = "IgA secretoria.";
		resp2 = "IgE.";
		resp3 = "IgM.";
		resp4 = "IgD.";
		resp5 = "IgG.";
		
		respv = 2;
		id = 34;
		
		pregunta p34 = new pregunta(preg, resp1, resp2, resp3, resp4, resp5, respv, id);
		Trivial.Add (p34);
		
		//Pregunta 35
		preg = "Señale cual es el tipo de respuesta inmune mas efectiva contra los virus:";
		resp1 = "LT-CD4+.";
		resp2 = "IgM.";
		resp3 = "IgA.";
		resp4 = "Complemento.";
		resp5 = "LT-CD8+.";
		
		respv = 5;
		id = 35;
		
		pregunta p35 = new pregunta(preg, resp1, resp2, resp3, resp4, resp5, respv, id);
		Trivial.Add (p35);
		
		//Pregunta 36
		preg = "Seleccione de las siguientes bacterias aquellas que utilizan"+"\n"+ " como estrategia de evasión del sistema inmune la variación antigenica:";
		resp1 = "Treponema Palidum.";
		resp2 = "E. coli.";
		resp3 = "Staphilococus aureus.";
		resp4 = "Neiseira gonorrhoea.";
		resp5 = "Listeria monocitogenes.";
		
		respv = 4;
		id = 36;
		
		pregunta p36 = new pregunta(preg, resp1, resp2, resp3, resp4, resp5, respv, id);
		Trivial.Add (p36);
		
		//Pregunta 37
		preg = "Señale cual de los siguientes virus utiliza como estrategia de evasión"+"\n"+ "la inhibición del procesamiento antigénico al bloquear"+"\n"+ "el transporte de antígenos por parte del tap:";
		resp1 = "Rinovirus.";
		resp2 = "Enterovirus.";
		resp3 = "VIH.";
		resp4 = "Herpes virus(HSV,CMV).";
		resp5 = "Poxvirus.";
		
		respv = 4;
		id = 37;
		
		pregunta p37 = new pregunta(preg, resp1, resp2, resp3, resp4, resp5, respv, id);
		Trivial.Add (p37);
		
		//Pregunta 38
		preg = "Señale que tipo de respuesta inmune permite el control de la infección por plasmodium:";
		resp1 = "Complemento.";
		resp2 = "IgA secretoria.";
		resp3 = "PH gástrico.";
		resp4 = "Anticuerpos y LT CD8+.";
		resp5 = "IL 18.";
		
		respv = 4;
		id = 38;
		
		pregunta p38 = new pregunta(preg, resp1, resp2, resp3, resp4, resp5, respv, id);
		Trivial.Add (p38);
		
		//Pregunta 39
		preg = "Señale una caracteristica del grupo de linfositos Th2:";
		resp1 = "Defensa contra patógenos extracelulares.";
		resp2 = "Defensa contra patógenos intracelulares.";
		resp3 = "Estimula Citotoxicidado.";
		resp4 = "Produce INFγ.";
		resp5 = null;
		
		respv = 1;
		id = 39;
		
		pregunta p39 = new pregunta(preg, resp1, resp2, resp3, resp4, resp5, respv, id);
		Trivial.Add (p39);
		
		//Pregunta 40
		preg = "La respuesta inmune se divide en innata y adquirida"+"\n"+ "seleccione el tipo de mecanismo químico o celular"+"\n"+ " que corresponda a la respuesta adquirida:";
		resp1 = "Lisozimas.";
		resp2 = "Complemento.";
		resp3 = "Células dendríticas.";
		resp4 = "Células NK.";
		resp5 = "Anticuerpos";
		
		respv = 5;
		id = 40;
		
		pregunta p40 = new pregunta(preg, resp1, resp2, resp3, resp4, resp5, respv, id);
		Trivial.Add (p40);
		
		string p = Trivial [i].getQuestion();
		formato (p);
	}*/
	
}

