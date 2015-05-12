using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class pregunta {
	
	string question;
	string respuesta1;
	string respuesta2;
	string respuesta3;
	string respuesta4;
	string respuesta5;
	int correcta; // el índice de la pregunta correcta
	int id; /// id de la pregunta
	//List<string>opciones;
	//List<preguntas> Trivial = new List<preguntas>();

	public pregunta(string pregunta, string respuesta1, string respuesta2, string respuesta3, string respuesta4, string respuesta5, int correcta, int id){
		this.question = pregunta;
		this.respuesta1 = respuesta1;
		this.respuesta2 = respuesta2;
		this.respuesta3 = respuesta3;
		this.respuesta4 = respuesta4;
		this.id = id;
		this.correcta = correcta;
	}

	
	/*
	public pregunta(string pregunta, int correcta, int id){
		this.question = pregunta;
		this.id = id;
		this.correcta = correcta;
	}
*/
	
	public string getQuestion()
	{
		return question;
	}
	

	public string getResp1()
	{
		return respuesta1;
	}

	public string getResp2()
	{
		return respuesta2;
	}

	public string getResp3()
	{
		return respuesta3;
	}

	public string getResp4()
	{
		return respuesta4;
	}

	public string getResp5()
	{
		return respuesta5;
	}

	/*
	public void setListaOpciones(List<string>options)
	{
		this.opciones = options;
	}
	
	public List<string> getOpciones()
	{
		return opciones;
	}
*/

	
	
	/*	
 * 
	void Start(){
		questions ();
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
		
		preguntas p1 = new preguntas(preg, resp1, resp2, resp3, resp4, resp5, respv, id);
		Trivial.Add (p1);
		
		//Pregunta 2
		preg = "De las siguientes opciones,"+"\n"+ "señale la definicion que corresponda al termino Hapteno.";
		resp1 = "Molécula glicoproteína que tiene la capacidad"+"\n"+ "de reconocer un antígeno especifico.";
		resp2 = "Molécula de la superficie celular de los LT"+"\n"+ "que facilita el proceso de activación"+"\n"+ "de los linfocitos B.";
		resp3 = "Antígeno incompleto, que para ser reconocido"+"\n"+ "por el sistema inmune requiere de la"+"\n"+ "colaboración de un adyuvante.";
		resp4 = "Molécula presente en algunos virus( VIH),"+"\n"+ "Bacterias(Streptococos, Stafilococos) y "+"\n"+ "Parasitos(Plasmodium) que producen una activación"+"\n"+ " policlonal masiva equivalente al 20% "+"\n"+ "de las células del sistema inmune";
		
		respv = 3;
		id = 2;
		
		preguntas p2 = new preguntas(preg, resp1, resp2, resp3, resp4, resp5, respv, id);
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
		
		preguntas p3 = new preguntas(preg, resp1, resp2, resp3, resp4, resp5, respv, id);
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
		
		preguntas p4 = new preguntas(preg, resp1, resp2, resp3, resp4, resp5, respv, id);
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
		
		preguntas p5 = new preguntas(preg, resp1, resp2, resp3, resp4, resp5, respv, id);
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
		
		preguntas p6 = new preguntas(preg, resp1, resp2, resp3, resp4, resp5, respv, id);
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
		
		preguntas p7 = new preguntas(preg, resp1, resp2, resp3, resp4, resp5, respv, id);
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
		
		preguntas p8 = new preguntas(preg, resp1, resp2, resp3, resp4, resp5, respv, id);
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
		
		preguntas p9 = new preguntas(preg, resp1, resp2, resp3, resp4, resp5, respv, id);
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
		
		preguntas p10 = new preguntas(preg, resp1, resp2, resp3, resp4, resp5, respv, id);
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
		
		preguntas p11 = new preguntas(preg, resp1, resp2, resp3, resp4, resp5, respv, id);
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
		
		preguntas p12 = new preguntas(preg, resp1, resp2, resp3, resp4, resp5, respv, id);
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
		
		preguntas p13 = new preguntas(preg, resp1, resp2, resp3, resp4, resp5, respv, id);
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
		
		preguntas p14 = new preguntas(preg, resp1, resp2, resp3, resp4, resp5, respv, id);
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
		
		preguntas p15 = new preguntas(preg, resp1, resp2, resp3, resp4, resp5, respv, id);
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
		
		preguntas p16 = new preguntas(preg, resp1, resp2, resp3, resp4, resp5, respv, id);
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
		
		preguntas p17 = new preguntas(preg, resp1, resp2, resp3, resp4, resp5, respv, id);
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
		
		preguntas p18 = new preguntas(preg, resp1, resp2, resp3, resp4, resp5, respv, id);
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
		
		preguntas p19 = new preguntas(preg, resp1, resp2, resp3, resp4, resp5, respv, id);
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
		
		preguntas p20 = new preguntas(preg, resp1, resp2, resp3, resp4, resp5, respv, id);
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
		
		preguntas p21 = new preguntas(preg, resp1, resp2, resp3, resp4, resp5, respv, id);
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
		
		preguntas p22 = new preguntas(preg, resp1, resp2, resp3, resp4, resp5, respv, id);
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
		
		preguntas p23 = new preguntas(preg, resp1, resp2, resp3, resp4, resp5, respv, id);
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
		
		preguntas p24 = new preguntas(preg, resp1, resp2, resp3, resp4, resp5, respv, id);
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
		
		preguntas p25 = new preguntas(preg, resp1, resp2, resp3, resp4, resp5, respv, id);
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
		
		preguntas p26 = new preguntas(preg, resp1, resp2, resp3, resp4, resp5, respv, id);
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
		
		preguntas p27 = new preguntas(preg, resp1, resp2, resp3, resp4, resp5, respv, id);
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
		
		preguntas p28 = new preguntas(preg, resp1, resp2, resp3, resp4, resp5, respv, id);
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
		
		preguntas p29 = new preguntas(preg, resp1, resp2, resp3, resp4, resp5, respv, id);
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
		
		preguntas p30 = new preguntas(preg, resp1, resp2, resp3, resp4, resp5, respv, id);
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
		
		preguntas p31 = new preguntas(preg, resp1, resp2, resp3, resp4, resp5, respv, id);
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
		
		preguntas p32 = new preguntas(preg, resp1, resp2, resp3, resp4, resp5, respv, id);
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
		
		preguntas p33 = new preguntas(preg, resp1, resp2, resp3, resp4, resp5, respv, id);
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
		
		preguntas p34 = new preguntas(preg, resp1, resp2, resp3, resp4, resp5, respv, id);
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
		
		preguntas p35 = new preguntas(preg, resp1, resp2, resp3, resp4, resp5, respv, id);
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
		
		preguntas p36 = new preguntas(preg, resp1, resp2, resp3, resp4, resp5, respv, id);
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
		
		preguntas p37 = new preguntas(preg, resp1, resp2, resp3, resp4, resp5, respv, id);
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
		
		preguntas p38 = new preguntas(preg, resp1, resp2, resp3, resp4, resp5, respv, id);
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
		
		preguntas p39 = new preguntas(preg, resp1, resp2, resp3, resp4, resp5, respv, id);
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
		
		preguntas p40 = new preguntas(preg, resp1, resp2, resp3, resp4, resp5, respv, id);
		Trivial.Add (p40);

		string p = Trivial [i].getPregunta();
		formato (p);
	}
	
	
	*/
}
