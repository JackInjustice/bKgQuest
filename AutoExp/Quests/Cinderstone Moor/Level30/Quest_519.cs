using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
namespace AutoExp.Quests
{
internal class Quest_519 : Quest
{
public Quest_519(int minLvl, int maxLvl, QuestRace race, uint[] reqQuests)
: base(519, minLvl, maxLvl, race, reqQuests)
{ }
public override bool RunQuest(Host host)
{
if (!base.RunQuest(host))
return false;
if (getQuest() == null)
{
if (!host.movementModule.GpsMove("Humanoid_Deserter_Deckard"))
return false;
host.StartQuest(id);
Thread.Sleep(1000);
}
ArcheBuddy.Bot.Classes.Quest quest = getQuest();
if (quest != null && quest.status == ArcheBuddy.Bot.Classes.QuestStatus.Performed)
{
if (!host.movementModule.GpsMove("Humanoid_Deputy_Commander_Sinclair"))
return false;
host.CompleteQuest(id);
Thread.Sleep(1000);
}
return true;
}
}
}