using UnityEngine;
using System.Collections.Generic;
using System.Text;
using System.Xml;
using System.IO;

public class readxml : MonoBehaviour {
{
	public TextAsset GameAsset;
	
	public string Question = "";
	public string Cylinder_Character = "";
	
	List<Dictionary<string,string>> levels = new List<Dictionary<string,string>>();
	Dictionary<string,string> obj;
	
	void Start()
	{ //Timeline of the Level creator
		GetQuestion();
	}
	

	public void GetQuestion()
	{
		XmlDocument xmlDoc = new XmlDocument(); // xmlDoc is the new xml document.
		xmlDoc.LoadXml(GameAsset.text); // load the file.
		XmlNodeList questionsList = xmlDoc.GetElementsByTagName("level"); // array of the level nodes.
		
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
				
				if(levelsItens.Name == "tutorial")
				{
					obj.Add("tutorial",levelsItens.InnerText); // put this in the dictionary.
				}
				
				if(levelsItens.Name == "object")
				{
					switch(levelsItens.Attributes["name"].Value)
					{
					case "Cube": obj.Add("Cube",levelsItens.InnerText);break; // put this in the dictionary.
					case "Cylinder":obj.Add("Cylinder",levelsItens.InnerText); break; // put this in the dictionary.
					case "Capsule":obj.Add("Capsule",levelsItens.InnerText); break; // put this in the dictionary.
					case "Sphere": obj.Add("Sphere",levelsItens.InnerText);break; // put this in the dictionary.
					}
				}
				
				if(levelsItens.Name == "finaltext")
				{
					obj.Add("finaltext",levelsItens.InnerText); // put this in the dictionary.
				}
			}
			levels.Add(obj); // add whole obj dictionary in the levels[].
		}
	}
}