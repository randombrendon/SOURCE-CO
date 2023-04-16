﻿// World Conquer Online Project 2.5517 - Phoenix Project Based
// This project has been created by Felipe Vieira Vendramini
// Source Infrastructure based on Phoenix Source, written by Gareth Jensen
// This source is targeted to Conquer Online, client version 5517
// 
// Computer User: Felipe Vieira
// File Created by:  Felipe Vieira Vendramini 
// zfserver v2.5517 - MsgServer - Server Strings.cs
// Last Edit: 2016/11/23 10:22
// Created: 2016/11/23 10:22

using Org.BouncyCastle.Bcpg;

namespace MsgServer
{
    public class ServerString
    {
        public const string STR_SYNDICATE_DISCHARGE = "{0} {1} has discharged {2} from {3}.";
        public const string STR_SYNDICATE_PROMOTE = "{0} {1} has promoted {2} to {3}.";
        public const string DRAGON_BALL_DROP = "A dragon ball drop from the monster killed by {0}.";
        public const string EXPLOST_PAYBY_SYNFUND = "{0} exp lost reduce by syndicate fund.";
        public const string MALE_MATE_LOGIN = "Your husband is online.";
        public const string FEMALE_MATE_LOGIN = "Your wife is online.";
        public const string TARGET_ALREADY_MARRIED = "The target is already married.";
        public const string YOURE_ALREADY_MARRIED = "You're already married.";
        public const string NOT_ALLOWED_SAME_GENDER_MARRIAGE = "You cannot marry with someone of the same gender.";
        public const string MARRIAGE_NOT_APPLY = "You have not applied for marriage.";
        public const string NOMATE_NAME = "None";
        public const string TITILE_NONE = "None";
        public const string SYNNAME_NONE = "None";
        public const string ACTIONSTR_NONE = "None";
        public const string STR_NOT_ALIVE = "You are not alive.";
        public const string STR_DESTROY_SYNDICATE_SOON = "Your guild's fund has been used up. Please replenish the guild fund or your will be terminated forcedly.";
        public const string STR_TARGET_OFFLINE = "The target is not online.";
        public const string STR_SYNDICATE_COMBINESUB = "Guild %s is merged by %s.";
        public const string STR_SUPERMAN_BROADCAST = "{0} has killed {1} monsters and is now rank {2} on KO board.";
        public const string STR_NEXTEQP_OVERLEV = "Level requirement of the new equipment is higher than your level!";
        public const string STR_DISPATCHXP = "{0} roared, and the teammates' XP boosts immediately!";
        public const string STR_BOOTH_BUY = "%s spent %d silvers to buy your %s.";
        public const string STR_DISABLE_LAY_SYNTRANS = "This kind of NPC is not allowed to place here!";
        public const string STR_ITEM_LEV_TOO_HIGH = "Level reqirement of the equipment is much too high!";
        public const string STR_TEAM_HUNT = "Notorious %s was finally hunted down by the detective team headed by %s!";
        public const string STR_FOND_WANTED = "The wanted target [%s] is found! ";
        public const string STR_FOND_POLICEWANTED = "The governmental wanted target [%s] is found! ";
        public const string STR_CANT_STORAGE = "This item cannot be deposited!";
        public const string STR_SYN_FULL = "Error: the amount of guild members is full!";
        public const string STR_JOIN_SYN_FAILED = "Error: failed to join!";
        public const string STR_INVALID_PET_NAME = "Error: forbidden name!";
        public const string STR_KICKOUT_MEMBER_s = "%s did not abide by the rules of the guild and was driven out of the guild.";
        public const string STR_KICKOUT_ME_s = "You have been dispelled from the guild by %s.";
        public const string STR_NO_ENOUGH_POWER = "You do not have enough mana to broadcast!";
        public const string STR_NO_ENOUGH_LEVEL = "Your level is not high enough to broadcast!";
        public const string STR_NO_BONUS = "Sorry. No prize available or the prize has not been confirmed in the prize claiming web page.";
        public const string STR_WARNING_CRASH = "Warning: the command is for local test only, or the server may collape!";
        public const string STR_CAN_STAND = "You cant stand there!";
        public const string STR_SET_MAX_PLAYERS_u = "Max logged in users allowed changed to: %u";
        public const string STR_SHOW_PLAYERS_uu = "Current online players: %u, max online players: %u";
        public const string STR_CAN_NOT_TALK = "You have been stricken the vital point and cannot talk temporarily!";
        public const string STR_ARRESTMENT_PK_MODE = "Restrictive PK mode. You can only attack monsters, black-name and red-name players.";
        public const string STR_TEAM_PK_MODE = "Team PK mode. You can attack monsters and players except for your teammates.";
        public const string STR_SAFE_PK_MODE = "Peace mode. You can only attack monsters and won't hurt other players.";
        public const string STR_FREE_PK_MODE = "Free PK mode. You can attack anyone.";
        public const string STR_NEED_PICK = "You must use a pecker to mine.";
        public const string STR_SYNDICATE_DESTROY = "Guild {0} has been terminated.";
        public const string STR_SYNDICATE_CREATE = "Congratulations! {0} has set up {1} successfully.";
        public const string STR_SYN_LEADER_LOSE = "Guild {0}'s guild leader {1} disappeared and {2} took the place.";
        public const string STR_SYN_DONATE = "The {0} {1} has donated {2} silvers to the Guild Fund.";
        public const string STR_SYN_DONATE_EMONEY = "The {0} {1} has donated {2} CPs to the Guild Fund.";
        public const string STR_SYN_WAR_END = "Guild war ended!";
        public const string STR_SYN_WAR_START = "Guild war started!";
        public const string STR_SYN_GOT_WIN = "{0} has won!";
        public const string STR_ERROR_DUPLICATE_NAME = "Error: the character has been existed!";
        public const string STR_ERROR_ILLEGAL_NAME = "Error: the name of character is invalid!";
        public const string STR_ERROR_ILLEGAL_PASSWORD = "Error: invalid password!";
        public const string STR_ERROR_ILLEGAL_ACCOUNT = "Error: invalid account ID!";
        public const string STR_ERROR_SERVER_FULL = "Error: the server is full. Please re-log in later!";
        public const string STR_ERROR_LOWER_VERSION = "Error: invalid version number. Please update your client!";
        public const string STR_ERROR_VERSION = "Error: invalid version number!";
        public const string STR_SHUTDOWN_NOTIFY_MINUTES = "Server maintenance in {0} minutes. Please log off immediately to avoid data loss.";
        public const string STR_SHUTDOWN_NOTIFY_MIN_AND_SECS = "Server maintenance in {0} minutes and {1} seconds. Please log off immediately to avoid data loss.";
        public const string STR_SHUTDOWN_NOTIFY_MINUTE = "Server maintenance in {0} minute. Please log off immediately to avoid data loss.";
        public const string STR_SHUTDOWN_NOTIFY_SECONDS = "Server maintenance in {0} seconds. Please log off immediately to avoid data loss.";
        public const string STR_NONSUCH_TRADE = "[Trade] Trading superior item. Player [%s] gave player [%s] [%s][%u]";
        public const string STR_NOT_SO_MUCH_MONEY = "You do not have enough money.";
        public const string STR_NOT_ENOUGH_MONEY = "You don't have {0} silvers!";
        public const string STR_NOT_ENOUGH_STUDY = "You don't have {0} study points!";
        public const string STR_DIE_FORGIVE = "He that dies pays all debts. Can't you forgive him?";
        public const string STR_DIE_STOP_ATTACK = "The target is dead.";
        public const string STR_ATTACK_POLICE = "You are attempting to attack the police. Please behave yourself.";
        public const string STR_KILLING_EXPERIENCE = "{0} extra experience points gained for killing.";
        public const string STR_KILLING_EXPEX = "{0} extra experience points gained for killing.";
        public const string STR_BAG_FULL = "Your bag is full!";
        public const string STR_TRADE_SUCCEED = "Trading succeeded.";
        public const string STR_TRADE_FAIL = "Trading failed!";
        public const string STR_USE_ITEM = "You have used an item.";
        public const string STR_INVALID_GUILD_NAME = "Invalid guild name!";
        public const string STR_GUILD_FUND_NOT_ENOUGH = "Not enough funds!";
        public const string STR_NOT_AUTHORIZED = "You have not been authorized!";
        public const string STR_ALLY_FULL = "Allies list is full!";
        public const string STR_ENEMY_FULL = "Enemies list is full!";
        public const string STR_SYN_PLACE_FULL = "All the posts have been occupied!";
        public const string STR_WANTED_ORDER = "%u silvers earnest money is deducted.  You have got No.%d Pursuing Order. Target: %s; Reward: %u silvers.";
        public const string STR_WANTED_INFO = "It is said that the wanted target appears around [%s].";
        public const string STR_INVALID_WANTED = "Invalid Pursuing Number£¡";
        public const string STR_MAX_BONUTY = "You should offer a reward of %d silvers at most!";
        public const string STR_MIN_BONUTY = "You should offer a reward of %d silvers at least!";
        public const string STR_SUPERADD_BONUTY = "The reward for No.%d Pursuing Order is increased to %u silvers!";
        public const string STR_LOWEST_SUPERADD_BONUTY = "You must increase %u silvers at lease!";
        public const string STR_CANCEL_WANTED = "Pursuing Order for %u has been canceled.";
        public const string STR_NO_DISBAND = "The guild is too big to be disbanded. Please transfer your guild power.";
        public const string STR_NO_DISBAND_LEADER = "You're not the leader of the guild.";
        public const string STR_PROTECTED_CODE = "Please enter the protection code first.";
        public const string STR_HIS_ALLY_FULL = "The target's allies list is full!";
        public const string STR_NOT_HERE = "The player is not in the vicinity!";
        public const string STR_NOT_ENOUGH_LEV = "You have not reached level %d!";
        public const string STR_LEVEL_NOT_ENOUGH = "The target's level is insufficient!";
        public const string STR_INVALID_NAME = "Invalid name.";
        public const string STR_INVALID_MSG = "Invalid message!";
        public const string STR_MAGIC_FAILED = "Magic failed!";
        public const string STR_CANNOT_DEPOSIT = "Error: The item is not suitable for deposit!";
        public const string STR_FORBIDDEN_GUILD_NAME = "You are forbidden to use this guild name.";
        public const string STR_GUILD_INEXIST = "The guild does not exist.";
        public const string STR_GUILD_FAILED_CREATE_MEMBER = "Failed to create guild member.";
        public const string STR_TEAM_EXPERIENCE = "{0} team experience points gained.";
        public const string STR_TEAM_EXPEX = "You gained  {0} team experience points with additional rewarding experience points due to low level teammates.";
        public const string STR_LOST_EXPERIENCE = "You lost {0} experience points!";
        public const string STR_KILLING_TO_MUCH = "You have done too much killing. You will pay for what you have done.";
        public const string STR_NOT_PK_MODE = "You can't attack the target in the current mode!";
        public const string STR_NOT_PK_EXP = "You cannot PK when your experience point is under 0.";
        public const string STR_PK_FORBIDDEN = "PK is forbidden here.";
        public const string STR_MSG_SENT = "Message sent successfully. The target will receive it as soon as he/she logs into the game.";
        public const string STR_MSG_FAILED = "Failed to leave message. Please leave message to a friend every %d minutes.";
        public const string STR_INVALID_COORDINATE = "Invalid coordinates.";
        public const string STR_GONE = "Gone";
        public const string STR_JUMPED = "Jumped";
        public const string STR_CONNECTION_OFF = "Bad Connection. Log off automatically.";
        public const string STR_WEAPON_SKILL_UP = "Congratulations! Your weapon proficiency has been improved.";
        public const string STR_TEAMMATE_CANNOT_CREATE = "[Team]You are already in a team and cannot create a new one.";
        public const string STR_CREATE_TEAM_FAILED = "[Team]Failed to create a team.";
        public const string STR_FULLBAG_NO_MORE = "You bag is full and can't hold more items.";
        public const string STR_WAREHOUSE_MONEY_NO_MORE = "You cant store more than 999,999,999 silver.";
        public const string STR_WAREHOUSE_NO_MORE = "You warehouse is full and can't hold more items.";
        public const string STR_HEAVEY_BAG = "Your bag is so too heavy to hold any more items.";
        public const string STR_ITEM_NOT_FOUND = "The item is not found!";
        public const string STR_ITEM_INEXIST = "The item does not exist!";
        public const string STR_MONEYBAG_FULL = "Your moneybag is full!";
        public const string STR_MAKE_ITEM_FAILED = "Failed to generate map item [%u].";
        public const string STR_MAKE_MONEY_FAILED = "Failed to generate map money [%d].";
        public const string STR_DAMAGED_REPAIR = "{0} has been severely damaged. Please repair it soon, otherwise, it will be gone.";
        public const string STR_DURABILITY_REPAIR = "Durability of {0} is too low. Please repair it soon to prevent further damaging.";
        public const string STR_FAR_CANNOT_PICK = "The item is too far away for you to pick up.";
        public const string STR_FULL_CANNOT_PICK = "Your bag is full and you can not pick up any more items.";
        public const string STR_PICK_MONEY = "You have picked up {0} silvers.";
        public const string STR_FAILED_GENERATE_ITEM = "Failed to generate the item.";
        public const string STR_OTHERS_ITEM = "You have to wait a little bit before you can pick up any items that were dropped from the monsters being killed by other players.";
        public const string STR_GOT_ITEM = "You have got a(an) {0}.";
        public const string STR_DRAGONBALL = "A [Dragon Ball] is required to improve equipment.";
        public const string STR_REPAIR_THEN_IMPROVE = "Please repair the equipment before improving it.";
        public const string STR_SUPERIOR_ALREADY = "The equipment is already in superior grade.";
        public const string STR_CONNOT_IMPROVE = "The equipment cannot been improved.";
        public const string STR_METEOR = "A [Meteor] is required to upgrade equipment.";
        public const string STR_REPAIR_THEN_UPGRADE = "Please repair the equipment before upgrading it.";
        public const string STR_UPGRADE_NOMORE = "The equipment cannot be upgraded any more!";
        public const string STR_MINE_WITH_PECKER = "You must use a pecker to mine.";
        public const string STR_NO_MINE = "No mine here.";
        public const string STR_GOLD_ORE = "You gained a gold ore!";
        public const string STR_EUXENITE_ORE = "You gained an euxenite ore!";
        public const string STR_IRON_ORE = "You gained an iron ore!";
        public const string STR_COPPER_ORE = "You gained copper ore!";
        public const string STR_SILVER_ORE = "You gained a silver ore!";
        public const string STR_GAIN_GEM = "Congratulations! You gained a gem!";
        public const string STR_METEOR_GEM = "You gained a meteor!";
        public const string STR_DRAGON_BALL = "You gained a Dragon Ball!";
        public const string STR_UNQUALIFIED = "Error: Failed to meet condition.";
        public const string STR_DIE = "You are already dead.";
        public const string STR_DONOT_GIVE_UP = "You are taking on important responsibilities. How can you abandon yourself?";
        public const string STR_CANNOT_JUMP = "You cannot jump!";
        public const string STR_CHEAT = "[Cheat]The points you are allotting are more than the limit.";
        public const string STR_FRIEND_YOUR_LIST_FULL = "You can't have more friends.";
        public const string STR_FRIEND_LIST_FULL = "The target's friend list is full.";
        public const string STR_YOUR_FRIEND_ALREADY = "The target is your friend already.";
        public const string STR_MAKE_FRIEND_SENT = "Request of making friends has been sent out.";
        public const string STR_NOT_YOUR_FRIEND = "{0} is not your friend.";
        public const string STR_NO_PK_VILLAGE = "PK is forbidden in Birth Village.";
        public const string STR_NEVER_PROPOSED = "{0} never proposed to you.";
        public const string STR_SINGLE = "You are still single.";
        public const string STR_NOT_YOUR_SPOUSE = "%s is not your spouse.";
        public const string STR_NOT_ENOUGH_MANA = "You don't have enough mana.";
        public const string STR_UNABLE_USE_ITEM = "Unable to use item!";
        public const string STR_YOUR_BAG_FULL = "Your bag is full!";
        public const string STR_INVALID_AMOUNT = "Invalid amount!";
        public const string STR_REPAIR_FAILED = "Repair failed!";
        public const string STR_INVALID_TITLE = "Error: Invalid title!";
        public const string STR_NOT_FROM_YOUR_GUILD = "The target does not belong to your guild.";
        public const string STR_ITEM_DAMAGED = "The item has been damaged!";
        public const string STR_VITAL_POINT_STRICKEN = "Your vital point has been stricken and you are unable to talk!";
        public const string STR_CHANGE_NAME = "{0} has changed his name to {1}. The change will take full effect after the next server maintenance.";
        public const string STR_INCREASE_MONEY = "You received {0} silver.";
        public const string STR_INCREASE_ITEM = "You received a/an {1}.";
        public const string STR_KICKOUTALL = "Start kickoutall. All players are logging off and logging in is forbidden.";
        public const string STR_ACTION_SEEN = "ACTION can be seen.";
        public const string STR_ACTION_NOTSEEN = "ACTION cannot been seen.";
        public const string STR_NO_STOP = "You cannot stop in the destination!";
        public const string STR_LOCAL_TEST = "Caution: The command is for local test only. Otherwise the server may collapse!";
        public const string STR_ACTION_UPDATED = "[ACTION has {0} been updated.]";
        public const string STR_KICK_OUT_GUILD = "{0} {1} has kicked {2} out of the guild!";
        public const string STR_NO_PRIZE = "Sorry, no prize for you or the prize has not been verified in the prize claiming webpage.";
        public const string STR_NO_LV_BROADCAST = "You need to be at least level 50 to send a broadcast!";
        public const string STR_NO_MANA_BROADCAST = "Your mana is not high enough and you cannot broadcast!";
        public const string STR_INVALID_CHARACTER = "Invalid character is found in the message!";
        public const string STR_LOW_LEVEL = "Your level is too low!";
        public const string STR_GM_NO_TEAM = "[GM] cannot use the team command.";
        public const string STR_NO_GM_ONLINE = "No GMs online.";
        public const string STR_INTEAM_NOJOIN = "[Team]You are already in a team and cannot join another team.";
        public const string STR_NO_APPLICANT = "[Team]The applicant is not found.";
        public const string STR_NO_TEAM = "[Team]The target has not created a team.";
        public const string STR_FORBIDDEN_JOIN = "[Team]The team is forbidden access.";
        public const string STR_TEAM_FULL = "[Team]The team is full.";
        public const string STR_NO_CAPTAIN_CLOSE = "[Team]Please click on the captain.";
        public const string STR_JOIN_REQUEST_SENT = "[Team]Request to join team has been sent out.";
        public const string STR_INVI_SENT = "[Team]Invitation to join team has been sent out out. Please wait for response.";
        public const string STR_NO_TEAM_TO_INVITE = "[Team]You haven't created a team. How can you accept other player to a team?";
        public const string STR_NOT_CAPTAIN_INVITE = "[Team]You are not the captain. How can you accept other player to the team?";
        public const string STR_YOUR_TEAM_FULL = "[Team]Your team is full.";
        public const string STR_APPLICANT_NOT_FOUND = "[Team]The applicant is not found.";
        public const string STR_HAVE_JOIN_TEAM = "[Team]You are already in a team and cannot join another team.";
        public const string STR_NOT_TO_JOIN = "[Team]The target has not requested to join the team.";
        public const string STR_NOTEAM_TO_INVITE = "[Team]You haven't created a team and cannot invite others to join.";
        public const string STR_TEAM_CLOSED = "[Team]Team is closed. Please open it first.";
        public const string STR_NOT_CAPTAIN_ACCEPT = "[Team]You are not the captain. How can you invite other players to the team?";
        public const string STR_INVITED_NOT_FOUND = "[Team]The invited target is not found.";
        public const string STR_HAS_IN_TEAM = "[Team]The target is in another team. Invitation failed.";
        public const string STR_INVITE_SENT = "[Team]Invitation has been sent.";
        public const string STR_NOT_LEADER_KICK = "[Team]You are not the leader and cannot kick other members.";
        public const string STR_SENT_WAIT = "[Team]Request has been sent out. Please wait.";
        public const string STR_INTEAM_NOACCEPT = "[Team]You have been in a team and cannot agree to join another team.";
        public const string STR_INVITER_NOT_FOUND = "[Team]The inviter is not found.";
        public const string STR_NOT_CREATE_TEAM = "[Team]The target has not created a team.";
        public const string STR_HIS_TEAM_FULL = "[Team]The target's team is full.";
        public const string STR_NOT_BE_INVIITED = "[Team]The target did not invite you to the team.";
        public const string STR_NO_TEAM_TO_LEAVE = "[Team]You are not in a team and cannot leave.";
        public const string STR_NO_TEAM_TO_DISMISS = "[Team]You haven't created a team yet and cannot dismiss.";
        public const string STR_NO_TEAM_JOINED = "You have not joined a team.";
        public const string STR_NOT_CAPTAIN_DISMISS = "[Team]You are not the captain and cannot dismiss the team.";
        public const string STR_NO_TRADE_IN_BATTLE = "Error: You cannot use trade command while in battle!";
        public const string STR_NO_TRADE_IN_TEAM = "Error: You cannot use trade command while you are in a team!";
        public const string STR_NO_IN_TEAM = "[Team]You do not have a team yet.";
        public const string STR_NO_TRADE_TARGET = "[Trade]The trading target is not found.";
        public const string STR_TARGET_TRADING = "[Trade]The target is trading with someone else. Please try later.";
        public const string STR_TRADING_REQEST_SENT = "[Trade]Request for trading has been sent out.";
        public const string STR_NOT_FOR_TRADE = "Error: the item cannot be traded!";
        public const string STR_FREE_PK = "Free PK mode. You can attack anyone.";
        public const string STR_PEACE = "Peace mode. You can only attack monsters and won't hurt other players.";
        public const string STR_TEAM_PK = "Team PK mode. You can attack monsters and players except for your teammates.";
        public const string STR_JOIN_A_GUILD = "{0} {1} has accepted {2} on the guild.";
        public const string STR_INVITE_GUILD = "{0} {1} has invited {2} to the guild.";
        public const string STR_BONUS = "Congratulations! You have got {0} prizes.  Please go to trade market to claim prize!";
        public const string STR_TO_MAKE_FRIEND = "{0} wishes to make friends with you!";
        public const string STR_MAKE_FRIEND = "{0} and {1} are friends from now on!";
        public const string STR_BREAK_FRIEND = "{0} broke up friendship with {1}.";
        public const string STR_FRIEND_ONLINE = "Your friend {0} is online.";
        public const string STR_ENEMY_ONLINE = "You enemy {0} has logged in.";
        public const string STR_MARRY = "{0} and {1} are pronounced the husband and wife. They promise to love and care for each other for better or worse.";
        public const string STR_DIVORCE = "{0} and {1} got divorced because the love is not there anymore!";
        public const string STR_SYN_CONQUER = "{0} has won!";
        public const string STR_POLICE_WANTED_ORDER = "Confirm£ºTarget %s£¬this person was saw at %s recently.";
        public const string STR_GOTO_JAIL_S = "{0} has killed {1} and sent him/her to the jail.";
        public const string STR_GOTO_JAIL = "{0} has killed too much and been put into the jail at last.";
        public const string STR_INVENTORY_FULL = "Your inventory is full.";
        public const string STR_MOVE_UNABLE = "You can't stand there.";
        public const string STR_INVALID_JUMP = "Invalid jump.";
        public const string STR_NOT_ENOUGH_EMONEY = "Not enough CPs.";
        public const string STR_NOT_ENOUGH_EMONEY2 = "Not enough CPs(B).";
        public const string STR_QUIZ_SHOW_START = "Quiz show will start in 60 seconds.";
        public const string STR_QUIZ_SHOW_ENDED = "Quiz show has ended.";
        public const string STR_NOT_ENOUGH_SPACE_DBSCROLL = "Not enough space to open the DbScroll, please leave {0} empty spaces.";
        public const string STR_NOT_ENOUGH_SPACE_METSCROLL = "Not enough space to open the MeteorScroll, please leave {0} empty spaces.";
        public const string STR_SILENCED_FOR_A_WHILE = "You have been silenced! You need to wait +{0} seconds to speak again.";
        public const string STR_VIP_REPAIR_FAILED = "Your item could not be repaired. You need to be VIP 2 at least.";
        public const string STR_IMPROVE_UPGRADE_SOCKET = "You successfully openned a socket in your item while upgrading.";
        public const string STR_TRADE_TARGET_BAG_FULL = "Your target inventory is full.";
        public const string STR_TRADE_YOUR_BAG_IS_FULL = "Your inventory is full. Trade target can't insert more items.";
        public const string STR_CANT_PICKUP_OTHER_ITEMS = "You can`t pickup others items.";
        public const string STR_TEAM_MONEY = "Team Money Pickup: {0}";
        public const string STR_TEAM_ITEM = "Team Items Pickup: {0}";
        public const string STR_TEAM_GEM = "Team Others Pickup: {0}";
        public const string STR_BOOTH_BOUGHT = "{0} purchased successfully for {1} {2}.";
        public const string STR_BOOTH_USER_BOUTH = "{0} purchased your {1} for {2} {3}.";
        public const string STR_GUILD_FAILED_JOIN = "Failed to insert member into guild list.";
        public const string STR_SYN_ABDICATE = "Guild Leader {0} has abdicated the guild to {1}.";
        public const string STR_SYN_SET_DEPUTY = "Guild Leader {0} has set {1} as Deputy Leader.";
        public const string STR_SYN_UNSET_DEPUTY = "Guild Leader {0} has demoted {1}.";
        public const string STR_SYN_CREATE_LEVEL_NOT_ENOUGH = "You need to be at least level {0} to create a guild.";
        public const string STR_SYN_CREATE_MONEY_NOT_ENOUGH = "You don't have {0} silvers to set up a guild.";
        public const string STR_NO_SYN_DISBAND = "You don`t have a guild to disband.";
        public const string STR_SYN_ADD_ERROR = "An error occurred when trying to add your guild to the server library. Please relog or wait until next maintenance.";
        public const string STR_SYN_LEADER_CANNOT_QUIT = "You´re the guild leader and cannot leave your members.";
        public const string STR_SYN_QUIT_NO_DONATION = "Your donation should be over 20,000 silvers to quit.";
        public const string STR_GUILD_ALLY_TEAM_COUNT = "You should be alone with the target guild leader.";
        public const string STR_EQUIP_LOCK_ALREADY_LOCKED = "This item is already locked.";
        public const string STR_EQUIP_LOCK_CANT_LOCK = "This equipment can't be locked.";
        public const string STR_EQUIP_LOCK_NOT_LOCKED = "This item is not locked.";
        public const string STR_EQUIP_LOCK_ALREADY_UNLOCKING = "This item is already being unlocked.";
        public const string STR_COMPOSITION_OVERPOWER_MALE = "Congratulations! {0} has upgraded his {1} to +{2}!";
        public const string STR_COMPOSITION_OVERPOWER_FEMALE = "Congratulations! {0} has upgraded her {1} to +{2}!";
        public const string STR_COMPOSITION_NOT_MATCH = "You cannot compose items of different sorts.";
        public const string STR_COMPOSITION_NOT_MINOR_ITEM = "This item cannot be used as minor item.";
        public const string STR_COMPOSITION_MAX = "This item is already on the maximum composition.";
        public const string STR_TARGET_ALREADY_SHACKED = "Target is already shackled.";
        public const string STR_STIGMA_ACTIVE_P = "Stigma for {0} seconds, your attack will be increased by {1} percent.";
        public const string STR_ACCURACY_ACTIVE_P = "Accuracy for {0} seconds, your hit rate will be increased by {1} percent.";
        public const string STR_SHIELD_ACTIVE_P = "Shield for {0} seconds, your defense will be increased by {1} percent.";
        public const string STR_DODGE_ACTIVE_P = "Dodge for {0} seconds, your dodge will be increased by {1} percent.";
        public const string STR_STIGMA_ACTIVE_T = "Stigma for {0} seconds, your attack will be increased by {1} times.";
        public const string STR_ACCURACY_ACTIVE_T = "Accuracy for {0} seconds, your hit rate will be increased by {1} times.";
        public const string STR_SHIELD_ACTIVE_T = "Shield for {0} seconds, your defense will be increased by {1} times.";
        public const string STR_DODGE_ACTIVE_T = "Dodge for {0} seconds, your dodge will be increased by {1} times.";
        public const string STR_SCAPEGOAT_ONLY_PURE_NINJA = "Only pure ninjas can use this skill.";
        public const string STR_YOUR_LIFE_FULL = "Your life is full.";
        public const string STR_YOUR_MANA_FULL = "Your mana is full.";
        public const string STR_CANT_HEAL_POISON_STAR = "Can't heal while on poison star effect.";
        public const string STR_ITEM_CANNOT_DISCARD = "This item can`t be discarded.";
        public const string STR_ITEM_FAILD_TO_CREATE = "Failed to create drop item.";
        public const string STR_TARGET_NOT_IN_RANGE = "Target is not in range.";

        // Pigeon
        public const string STR_PIGEON_SEND_ERR_NOEMONEY = "Not enough CPs.";
        public const string STR_PIGEON_SEND_ERR_EMPTYSTRING = "You can't send an empty message.";
        public const string STR_PIGEON_SEND_ERR_STRING_TOOLONG = "Your message exceed the maximum size.";
        public const string STR_PIGEON_SEND_PIGEON_PRODUCE_PROMPT = "Your broadcast has been sent.";
        public const string STR_PIGEON_URGENT_ERR_NOEMONEY = "Not enough CPs.";
        public const string STR_PIGEON_URGENT_SENT_ALREADY = "You have already sent an urgent message.";
        public const string STR_PIGEON_SEND_OVER_5_PIECES = "You can't send more than 5 messages.";
        public const string STR_PIGEON_ADDITION_UNEXIST = "Your message has not been found.";

        // Peerage
        public const string STR_PEERAGE_DONATE_ABOVE_AMOUNT = "Your donation exceeds the maximum permited.";
        public const string STR_PEERAGE_DONATE_ERR_BELOW_LEVEL = "You should be at least level 70 before donating to notibility.";
        public const string STR_PEERAGE_DONATE_ERR_BELOW_UNDERLINE = "You need to donate at least 3 million!";
        public const string STR_PEERAGE_DONATE_ERR_NO_ENOUGH_MONEY = "You don't have enough money!";
        public const string STR_PEERAGE_PROMPT_KING = "Hear ye, Hear ye! {0} is now King!";
        public const string STR_PEERAGE_PROMPT_QUEEN = "Hear ye, Hear ye! {0} is now Queen!";
        public const string STR_PEERAGE_PROMPT_DUKE = "Congratulations! {0} is now Prince!";
        public const string STR_PEERAGE_PROMPT_DUCHESS = "Congratulations! {0} is now Princess!";
        public const string STR_PEERAGE_PROMPT_MARQUIS = "Congratulations! {0} is now Duke!";
        public const string STR_PEERAGE_PROMPT_MARQUISE = "Congratulations! {0} is now Duchess!";
        public const string STR_PEERAGE_PROMPT_EARL = "{0} is now Earl.";
        public const string STR_PEERAGE_PROMPT_COUNTESS = "{0} is now Countess.";
        public const string STR_PEERAGE_PROMPT_VISCOUNT = "{0} is now Baron.";
        public const string STR_PEERAGE_PROMPT_VISCOUNTESS = "{0} is now Baroness.";
        public const string STR_PEERAGE_PROMPT_BARON = "{0} is now Knight.";
        public const string STR_PEERAGE_PROMPT_BARONESS = "{0} is now Lady.";

        // Guide
        public const string STR_GUIDE_CONTRIBUTE_NOGODTIME = "You don't have heaven blessing to claim.";
        public const string STR_GUIDE_CONTRIBUTE_NOADDLEVEL = "You don't have experience to claim.";
        public const string STR_GUIDE_CONTRIBUTE_BAGFULL = "Your inventory is full!";
        public const string STR_GUIDE_BETRAY = "Your mentor betrayed you!";
        public const string STR_GUIDE_BETRAY_TUTOR = "Your student left you!";
        public const string STR_GUIDE_TUTOR_SUCCESS = "{0} has accepted you as his mentor!";
        public const string STR_GUIDE_RETUTOR_SUCCESS = "{0} want to be your mentor again!";
        public const string STR_GUIDE_TUTOR_LOGIN = "Your mentor {0} has logged in!";
        public const string STR_GUIDE_STUDENT_LOGIN = "Your student {0} has logged in!";
        public const string STR_GUIDE_TUTOR_LOW_LEVEL = "{0} is too low level.";
        public const string STR_GUIDE_STUDENT_HIGH_LEVEL = "He/She is too strong to be your apprentice.";
        public const string STR_GUIDE_TOO_MANY_STUDENTS = "You have achieved the max number of apprentices.";
        public const string STR_GUIDE_SENDSTUDENT = "You dismissed {0}.";
        public const string STR_GUIDE_TUTOR_LOW_LEVEL1 = "You need to be at least 20 levels lower than the target.";
        public const string STR_GUIDE_STUDENT_HIGH_LEVEL1 = "You need to be at least 20 levels higher than the target.";
        public const string STR_GUIDE_TOO_MANY_STUDENTS1 = "The target has reached the max number of students.";
        public const string STR_GUIDE_SENDTUTOR = "You asked {0} to be your apprentice!";
        public const string STR_GUIDE_EXPEL_TUTOR = "{0} has paid to leave his/her mentor!";
        public const string STR_GUIDE_EXPEL_STUDENT = "{0} decided to expel {1}!";
        public const string STR_GUIDE_RETUTOR_FAIL = "The target refused your request!";
        public const string STR_GUIDE_STUDENT_FAIL = "The target refused to be your apprentice.";
        public const string STR_GUIDE_TUTOR_FAIL = "The target refused to be your mentor.";
        public const string STR_GUIDE_ALREADY_HAVE_TUTOR = "You already have a mentor.";
        public const string STR_GUIDE_TUTOR_OFFLINE = "Your mentor has logged off.";
        public const string STR_GUIDE_STUDENT_OFFLINE = "Your apprentice {0} has logged off.";

        // Flower
        public const string STR_FLOWER_SENDOR_NOT_MALE = "Only male characters may send flowers!";
        public const string STR_FLOWER_RECEIVER_NOT_FEMALE = "Only female characters may receive flowers!";
        public const string STR_FLOWER_HAVE_SENT_TODAY = "You have already sent a flower today.";
        public const string STR_FLOWER_LEVEL_TOO_LOW = "Your level is too low.";
        public const string STR_FLOWER_SENDER_NOT_ALIVE = "You are dead.";
        public const string STR_FLOWER_RECEIVER_PROMPT = "{0} just gave you a flower!";
        public const string STR_FLOWER_NAME_RED = "Red Roses";
        public const string STR_FLOWER_NAME_WHITE = "Lilly";
        public const string STR_FLOWER_NAME_LILY = "Orchid";
        public const string STR_FLOWER_NAME_TULIP = "Tulip";
        public const string STR_FLOWER_GM_PROMPT_RED_3 = "{0} Has Just Received 3 Red Flowers From {1}!";
        public const string STR_FLOWER_GM_PROMPT_RED_9 = "{0} Has Just Received 9 Red Flowers From {1}!";
        public const string STR_FLOWER_GM_PROMPT_RED_99 = "{0} Has Got 99 Red Flowers From a Her Boo {1}!";
        public const string STR_FLOWER_GM_PROMPT_RED_999 = "{0} Just Received 999 Red Flowers From {1}. That What I Call Real Love!";
        public const string STR_FLOWER_GM_PROMPT_WHITE_3 = "{0} Has Just Received 3 White Flowers From {1}!";
        public const string STR_FLOWER_GM_PROMPT_WHITE_9 = "{0} Has Just Received 9 White Flowers From {1}!";
        public const string STR_FLOWER_GM_PROMPT_WHITE_99 = "{0} Has Got 99 White Flowers From a Her Boo {1}!";
        public const string STR_FLOWER_GM_PROMPT_WHITE_999 = "{0} Just Received 999 White Flowers From {1}. That What I Call Real Love!";
        public const string STR_FLOWER_GM_PROMPT_LILY_3 = "{0} Has Just Received 3 Lilys From {1}!";
        public const string STR_FLOWER_GM_PROMPT_LILY_9 = "{0} Has Just Received 9 Lilys From {1}";
        public const string STR_FLOWER_GM_PROMPT_LILY_99 = "{0} Has Got 99 Lilys From a Her Boo {1}";
        public const string STR_FLOWER_GM_PROMPT_LILY_999 = "{0} Just Received 999 Lilys From {1}. That What I Call Real Love!";
        public const string STR_FLOWER_GM_PROMPT_TULIP_3 = "{0} Has Just Received 3 Tulips From {1}";
        public const string STR_FLOWER_GM_PROMPT_TULIP_9 = "{0} Has Just Received 9 Tulips From {1}";
        public const string STR_FLOWER_GM_PROMPT_TULIP_99 = "{0} Has Got 99 Tulips From a Her Boo {1}";
        public const string STR_FLOWER_GM_PROMPT_TULIP_999 = "{0} Just Received 999 Tulips From {1}. That What I Call Real Love!";
        public const string STR_FLOWER_GM_PROMPT_ALL = "{0} Has Just Sent {1} 999 Flowers. This Is Unique Love!";

        // trade buddy
        public const string STR_TRADE_BUDDY_NOT_FOUND = "Your partner has not been found.";
        public const string STR_TRADE_BUDDY_ALREADY_ADDED = "You're already partners.";
        public const string STR_TRADE_BUDDY_SOMETHING_WRONG = "Something went wrong when processing your request.";
        public const string STR_TRADE_BUDDY_BROKE_PARTNERSHIP0 = "{0} broke the trade partnership with you.";
        public const string STR_TRADE_BUDDY_BROKE_PARTNERSHIP1 = "You broke the trade partnership with {1}.";

        // capture the flag
        public const string STR_CTF_AWARDED_PRIZE = "You awarded {0} points during the Capture the Flag and received {1} silvers and {2} CPs.";
        public const string STR_CTF_HIGHEST_REWARD = "{0} has taken the most points in the Capture the Flag and awarded the highest prize of {1} silvers and {2} CPs.";

        // syndicate score pk
        public const string STR_SSPK_AWARDED_PRIZE = "You awarded {0} points during the Guild Score PK War and received {1} silvers and {2} CPs.";

        // special mete
        public const string STR_METE_SPECIAL_METEMPSYCHOSIS = "Only second rebirth players may reincarnate.";
        public const string STR_METE_SPECIAL_LEVEL = "Only second rebirth level 110 players may reincarnate.";
        public const string STR_METE_SPECIAL_WRONG_GENDER = "You cannot change your sex while reincarnating.";
        public const string STR_METE_SPECIAL_NO_OBLIVION = "I cannot help you without the Oblivion Dew.";
        public const string STR_METE_SPECIAL_SUCCESS = "{0} has reincarnated.";

        // qualifier
        public const string STR_ARENIC_ALREADY_JOINED = "You are already waiting for a match in the arena qualifier.";
        public const string STR_ARENIC_LOW_LEVEL = "You need to reach level 70 before joining arena.";
        public const string STR_ARENIC_NOT_ENOUGH_POINTS = "You need at least 1500 points to play in the arena qualifier.";
        public const string STR_ARENIC_BANNED = "You have been banned from the Arena Qualifer.";
        public const string STR_ARENIC_CLOSED = "Arena Qualifier is locked.";
        public const string STR_ARENIC_ERROR = "Error trying to insert you into the matches list. Try joining again.";
        public const string STR_ARENIC_NOT_LOADED = "Arena qualifier has not been loaded.";
        public const string STR_ARENIC_MATCH_END0 = "{0} has defeated {1} in the Qualifier and is currently ranked No. {2}.";
        public const string STR_ARENIC_MATCH_END1 = "({0}){1} has defeated {2} in the Qualifier and is currently ranked No. {3}.";
        public const string STR_ARENIC_MATCH_END2 = "{0} has defeated ({1}){2} in the Qualifier and is currently ranked No. {3}.";
        public const string STR_ARENIC_MATCH_END3 = "({0}){1} has defeated ({2}){3} in the Qualifier and is currently ranked No. {4}.";
        public const string STR_ARENIC_NOT_JOINED = "You are not relationed to any match.";

        // subpro
        public const string STR_SUBPRO_LOW_LEVEL = "You should be over level 70 to have a sub-class.";
        public const string STR_SUBPRO_ALREADY_LEARNED = "You already learned this sub-class.";
        public const string STR_SUBPRO_NOT_LEARNED = "You do not know this sub-class.";

        // family
        public const string STR_FAMILY_NOT_LEADER = "You are not the Clan Leader.";
        public const string STR_FAMILY_ALREADY_JOINED = "You already have a Clan.";
        public const string STR_FAMILY_SPOUSE_CANTDO = "The target spouse is already a core member of another clan.";
        public const string STR_FAMILY_CREATE_LOW_LEVEL = "You need to be over level 50 in order to create a Clan.";
        public const string STR_FAMILY_INVALID_NAME = "Invalid Clan name.";
        public const string STR_FAMILY_NAME_USED = "This Clan name has already been taken.";
        public const string STR_FAMILY_TOO_BIG = "This Clan is too big to disband.";
        public const string STR_FAMILY_JOIN_LOW_LEVEL = "The target is below level 50.";
        public const string STR_FAMILY_FULL = "The clan is full.";
        public const string STR_FAMILY_TARGET_ALREADY_HAVE_FAMILY = "The target is already member of a clan.";
        public const string STR_FAMILY_ALLY_DENY = "Your ally request has been denied.";

        // syndicate
        public const string STR_SYN_ALLY0 = "{0} Guild Leader of {1} has added our guild to the allies list.";
        public const string STR_SYN_ALLY1 = "Our Guild Leader {0} has added {1} to the allies list.";
        public const string STR_SYN_ALLY_DENY = "Your ally request has been denied.";
        public const string STR_SYN_ENEMY0 = "{0} Guild Leader of {1} has added our guild to the enemies list.";
        public const string STR_SYN_ENEMY1 = "Our Guild Leader {0} has added {1} to the enemies list.";
        public const string STR_SYN_NO_EXIST = "The target guild doesn't exist.";
        public const string STR_SYN_LEADER_NOT_ONLINE = "The leader of the target guild is not online.";

        // syn reward
        public const string STR_SYNREWARD_NOT_ENOUGH_MONEY = "Your guild doesn't have enough funds.";
        public const string STR_SYNREWARD_NOT_ENOUGH_EMONEY = "Your guild doesn't have enough funds.";
        public const string STR_SYNREWARD_SET = "{0} Guild Leader of {1} has set up a reward of {2} silvers and {3} for the {4} event.";

        // vip teleport
        public const string STR_VIPTELE_CITY_REMAIN = "You need to wait {0} seconds to use the City Teleport again.";
        public const string STR_VIPTELE_PORTAL_REMAIN = "You need to wait {0} seconds to use the Portal Teleport again.";

        // syndicate recruitment
        public const string STR_SYNRECRUIT_ALREADY_SIGNED = "Your guild is already inscribed at the recruitment table.";
        public const string STR_SYNRECRUIT_NOT_ENOUGH_MONEY = "Your guild doesn't have enough funds.";
        public const string STR_SYNRECRUIT_NOT_ENOUGH_DONATION = "You need to set at least 500,000 silvers as fee.";
        public const string STR_SYNRECRUIT_UNEXISTENT_SYN = "The guild you choose didn't exist.";
        public const string STR_SYNRECRUIT_NOT_MEET_REQUIREMENTS = "You didn't meet the requirements.";
        public const string STR_SYNRECRUIT_JOINED = "{0} has joined the guild.";
    }
}