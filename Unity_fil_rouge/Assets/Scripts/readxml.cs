using UnityEngine;
using System.Collections.Generic;
using System.Text;
using System.Xml;
using System.IO;

public class readxml : MonoBehaviour {

/*  public TextAsset GameAsset;
	
	List<Dictionary<string,string>> levels = new List<Dictionary<string,string>>();
	Dictionary<string,string> obj;
	
	void Start()
	{
		GetQuestion();
	}
	

	public void GetQuestion()
	{
		XmlDocument xmlDoc = new XmlDocument(); // xmlDoc is the new xml document.
		xmlDoc.LoadXml(GameAsset.text); // load the file.
		XmlNodeList questionsList = xmlDoc.GetElementsByTagName("question"); // array of the level nodes.
		
		
		foreach (XmlNode question in questionsList)
		{
			XmlNodeList questioncontent = question.ChildNodes;
			obj = new Dictionary<string,string>(); 
			
			foreach (XmlNode questionItens in questioncontent) // levels itens nodes.
			{
				if(levelsItens.Name == "name")
				{
					obj.Add("name",levelsItens.InnerText); // put this in the dictionary.
				}
				
			}
			levels.Add(obj); // add whole obj dictionary in the levels[].
		}
	}*/
}