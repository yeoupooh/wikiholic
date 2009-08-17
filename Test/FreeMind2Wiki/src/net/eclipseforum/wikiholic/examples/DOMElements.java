package net.eclipseforum.wikiholic.examples;

import java.io.BufferedReader;
import java.io.File;
import java.io.InputStreamReader;

import javax.xml.parsers.DocumentBuilder;
import javax.xml.parsers.DocumentBuilderFactory;

import org.w3c.dom.Document;
import org.w3c.dom.Element;
import org.w3c.dom.NodeList;

// http://www.roseindia.net/xml/dom/DOMElements.shtml
public class DOMElements {
	static public void main(String[] arg) {
		try {
			BufferedReader bf = new BufferedReader(new InputStreamReader(
					System.in));
			System.out.print("Enter XML File name: ");
			String xmlFile = bf.readLine();
			File file = new File(xmlFile);
			if (file.exists()) {
				// Create a factory
				DocumentBuilderFactory factory = DocumentBuilderFactory
						.newInstance();
				// Use the factory to create a builder
				DocumentBuilder builder = factory.newDocumentBuilder();
				Document doc = builder.parse(xmlFile);
				// Get a list of all elements in the document
				NodeList list = doc.getElementsByTagName("*");
				System.out.println("XML Elements: ");
				for (int i = 0; i < list.getLength(); i++) {
					// Get element
					Element element = (Element) list.item(i);
					System.out.println(element.getNodeName());
				}
			} else {
				System.out.print("File not found!");
			}
		} catch (Exception e) {
			System.exit(1);
		}
	}
}