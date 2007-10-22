from rbp.common.pluginhost import *
from rbp.common.singleton import *
from rbp.common.command import *

import clr

clr.AddReference('WeifenLuo.WinFormsUI.Docking')
clr.AddReference('WikiholicGUI')

from WeifenLuo.WinFormsUI.Docking import *
from WikiholicGUI import *

from rbp.plugin_base import *

class WikiholicPlugin(BasePlugin):
	def activate(self, args):
		BasePlugin.activate(self, args)
		
		form = args
		self.add_button('Wikiholic', 'Wikiholic', WikiholicCmd(form))
		
		print "activated"
		
	def deactivate(self, args):
		print "deactivated"
		
class WikiholicCmd(ICommand):
	form = None
	
	def __init__(self, form):
		self.form = form
		
	def execute(self, sender, event):
		print "Wikiholic:"
		dc = DockContentWikiholic()
		dc.TabText = "Wikiholic"
		dc.Show(self.form.dp, DockState.DockLeft)
		
		c = dc.btAddServer
		c.Text = "Add Server"

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

if __name__ == '__main__':
	pass
else:
	# add to pluginhost
	get_singleton(PluginHost).add('Wikiholic', WikiholicPlugin())
	