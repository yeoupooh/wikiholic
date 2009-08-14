import java.io.File;
import java.io.FileInputStream;
import java.io.FileNotFoundException;
import java.io.IOException;
import java.net.URL;
import java.util.Properties;
import java.util.Vector;

import junit.framework.TestCase;

import org.apache.xmlrpc.client.XmlRpcClient;
import org.apache.xmlrpc.client.XmlRpcClientConfigImpl;
import org.lustin.trac.xmlprc.TrackerDynamicProxy;
import org.lustin.trac.xmlprc.Wiki;

// http://blog.zgraggen.name/archives/111
public class TracTest extends TestCase {
	public void test1() throws FileNotFoundException, IOException {

		Properties props = new Properties();
		props.load(new FileInputStream(new File("login.properties")));

		XmlRpcClientConfigImpl conf = new XmlRpcClientConfigImpl();
		conf.setBasicUserName(props.getProperty("username"));
		conf.setBasicPassword(props.getProperty("password"));
		conf.setServerURL(new URL(props.getProperty("url")));

		XmlRpcClient client = new XmlRpcClient();
		client.setConfig(conf);

		TrackerDynamicProxy tdp = new TrackerDynamicProxy(client);
		Wiki wiki = (Wiki) tdp.newInstance(Wiki.class);

		Vector pages = wiki.getAllPages();
		System.out.println(pages);

		assertNotNull(wiki.getPage("WikiStart"));
	}
}
