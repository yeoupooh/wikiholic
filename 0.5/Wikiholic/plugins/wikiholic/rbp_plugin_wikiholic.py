from common.pluginhost import *
from common.singleton import *
from common.command import *

import clr

clr.AddReference('WeifenLuo.WinFormsUI.Docking')
clr.AddReference('WikiholicGUI')
clr.AddReference('Wikiholic.Confluence')

from WeifenLuo.WinFormsUI.Docking import *
from WikiholicGUI import *
from Wikiholic.Confluence.com.atlassian.confluence import *

from rbp.plugin_base import *

class WikiholicPlugin(BasePlugin):
	def activate(self, args):
		BasePlugin.activate(self, args)
		
		form = args
		self.add_button('Wikiholic', 'Wikiholic', WikiholicCmd(form))
		
		print "activated"
		
	def deactivate(self, args):
		print "deactivated"
		
class WikiholicCmd(BaseCommand):
	form = None
	
	def __init__(self, form):
		self.form = form
		
	def execute(self, sender, event):
		print "Wikiholic:"
		cls = DockContentWikiholic
		if has_singleton(cls) == False:
			dc = get_singleton(cls)
			dc.TabText = "Wikiholic"
			dc.HideOnClose = True
			dc.Show(self.form.dp, DockState.DockLeft)
			
			self.set_button(dc.btAddServer, WikiholicAddServerCmd()) 

			"""
			c = dc.btAddServer
			c.Text = "Add Server"
			"""
			
			c = dc.btEditServer
			c.Text = "Edit Server"

			c = dc.btRemoveServer
			c.Text = "Remove Server"

			c = dc.btAddWiki
			c.Text = "Add Wiki"

			c = dc.btEditWiki
			c.Text = "Edit Wiki"

			c = dc.btRemoveWiki
			c.Text = "Remove Wiki"
		else:
			dc = get_singleton(cls)
			dc.Show()

class ServerInfoDialog(FormServerInformation):

	def __init__(self):
		dlg = self
		dlg.StartPosition = FormStartPosition.CenterParent
		dlg.AcceptButton = dlg.btOK
		dlg.CancelButton = dlg.btCancel

		c = dlg.cbType
		c.Items.Add('Confluence')
		c.Items.Add('Wiki RPC Interface 2')
		c.Items.Add('SpringNote')
		c.SelectedIndex = 0
		
		c = dlg.btOK
		c.Click += self.__btOK_Click

		c = dlg.btCancel
		c.Click += self.__btCancel_Click

	def __btOK_Click(self, sender, event):
		form = sender.Parent
		form.DialogResult = DialogResult.OK
		form.Close()

	def __btCancel_Click(self, sender, event):
		form = sender.Parent
		form.DialogResult = DialogResult.Cancel
		form.Close()

class WikiholicAddServerCmd(ICommand):
	key = 'WikiholicAddServer'
	text = 'Add Server'
	
	def execute(self, sender, event):
		dc = sender.Parent.Parent
		#dc.tv.Nodes.Add('test')

		svc = ConfluenceSoapServiceService()
		
		dlg = ServerInfoDialog()
		if dlg.ShowDialog() == DialogResult.OK:
			svc.Url = dlg.cbUrl.Text + '/rpc/soap-axis/confluenceservice-v1'
			token = svc.login(dlg.tbUsername.Text, dlg.tbPassword.Text)
			if token != None:
				MessageBox.Show(token)
				rn = dc.tv.Nodes.Add(dlg.tbUsername.Text + '@' + dlg.cbUrl.Text)
				for rss in svc.getSpaces(token):
					rn.Nodes.Add(rss.name)
		
if __name__ == '__main__':
	pass
else:
	# add to pluginhost
	get_singleton(PluginHost).add('Wikiholic', WikiholicPlugin())
	