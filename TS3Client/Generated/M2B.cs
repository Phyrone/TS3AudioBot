// TS3Client - A free TeamSpeak3 client implementation
// Copyright (C) 2017  TS3Client contributors
//
// This program is free software: you can redistribute it and/or modify
// it under the terms of the Open Software License v. 3.0
//
// You should have received a copy of the Open Software License along with this
// program. If not, see <https://opensource.org/licenses/OSL-3.0>.




















namespace TS3Client.Full.Book
{
	using Messages;
	using System.Linq;

	#pragma warning disable CS8019 // Ignore unused imports
	using i8  = System.SByte;
	using u8  = System.Byte;
	using i16 = System.Int16;
	using u16 = System.UInt16;
	using i32 = System.Int32;
	using u32 = System.UInt32;
	using i64 = System.Int64;
	using u64 = System.UInt64;
	using f32 = System.Single;
	using d64 = System.Double;
	using str = System.String;

	using Duration = System.TimeSpan;
	using DurationSeconds = System.TimeSpan;
	using DurationMilliseconds = System.TimeSpan;
	using SocketAddr = System.Net.IPAddress;

	using Uid = System.String;
	using ClientDbId = System.UInt64;
	using ClientId = System.UInt16;
	using ChannelId = System.UInt64;
	using ServerGroupId = System.UInt64;
	using ChannelGroupId = System.UInt64;
	using IconHash = System.Int32;
	using ConnectionId = System.UInt32;
#pragma warning restore CS8019

	public partial class Connection
	{
#pragma warning disable IDE0017 // Ignore "Object initialization can be simplified"
	
		public void UpdateInitServer(InitServer msg)
		{
			var obj = new Server();
			obj.Platform = msg.ServerPlatform;
			obj.Version = msg.ServerVersion;
			obj.Created = msg.ServerCreated;
			{ var tmp = msg.ServerIp; if (tmp != null) obj.Ip.AddRange(tmp); }
			SetClientDataFun(msg);
			obj.WelcomeMessage = msg.WelcomeMessage;
			obj.MaxClients = msg.MaxClients;
			obj.Hostmessage = msg.Hostmessage;
			obj.HostmessageMode = msg.HostmessageMode;
			obj.VirtualServerId = msg.VirtualServerId;
			obj.AskForPrivilegekey = msg.AskForPrivilegekey;
			obj.ProtocolVersion = msg.ProtocolVersion;
			obj.Name = msg.Name;
			obj.CodecEncryptionMode = msg.CodecEncryptionMode;
			obj.DefaultServerGroup = msg.DefaultServerGroup;
			obj.DefaultChannelGroup = msg.DefaultChannelGroup;
			obj.HostbannerUrl = msg.HostbannerUrl;
			obj.HostbannerGfxUrl = msg.HostbannerGfxUrl;
			obj.HostbannerGfxInterval = msg.HostbannerGfxInterval;
			obj.PrioritySpeakerDimmModificator = msg.PrioritySpeakerDimmModificator;
			obj.HostbuttonTooltip = msg.HostbuttonTooltip;
			obj.HostbuttonUrl = msg.HostbuttonUrl;
			obj.HostbuttonGfxUrl = msg.HostbuttonGfxUrl;
			obj.PhoneticName = msg.PhoneticName;
			obj.IconId = msg.IconId;
			obj.HostbannerMode = msg.HostbannerMode;
			obj.TempChannelDefaultDeleteDelay = msg.TempChannelDefaultDeleteDelay;
			SetServer(obj);
			
		}

	
		public void UpdateChannelCreated(ChannelCreated msg)
		{
			var obj = new Channel();
			obj.Parent = msg.ChannelParentId;
			{
			var tmp = MaxClientsCcFun(msg);
			obj.MaxClients = tmp.Item1;
			obj.MaxFamilyClients = tmp.Item2;
			}
			obj.ChannelType = ChannelTypeCcFun(msg);
			obj.ForcedSilence = ReturnFalse(msg);
			obj.IsPrivate = ReturnFalse(msg);
			obj.OptionalData = null;
			obj.Order = msg.Order;
			obj.Name = msg.Name;
			obj.Topic = msg.Topic;
			obj.IsDefault = msg.IsDefault;
			obj.HasPassword = msg.HasPassword;
			obj.Codec = msg.Codec;
			obj.CodecQuality = msg.CodecQuality;
			obj.NeededTalkPower = msg.NeededTalkPower;
			obj.IconId = msg.IconId;
			obj.CodecLatencyFactor = msg.CodecLatencyFactor;
			obj.IsUnencrypted = msg.IsUnencrypted;
			obj.DeleteDelay = msg.DeleteDelay;
			obj.PhoneticName = msg.PhoneticName;
			SetChannel(obj, msg.ChannelId);
			
		}

	
		public void UpdateChannelDeleted(ChannelDeleted msg)
		{
			
			RemoveChannel(msg.ChannelId);
		}

	
		public void UpdateChannelEdited(ChannelEdited msg)
		{
			var obj = GetChannel(msg.ChannelId);
			{
			var tmp = MaxClientsCeFun(msg);
			obj.MaxClients = tmp.Item1;
			obj.MaxFamilyClients = tmp.Item2;
			}
			obj.ChannelType = ChannelTypeCeFun(msg);
			obj.Order = msg.Order;
			obj.Name = msg.Name;
			obj.Topic = msg.Topic;
			obj.IsDefault = msg.IsDefault;
			obj.HasPassword = msg.HasPassword;
			obj.Codec = msg.Codec;
			obj.CodecQuality = msg.CodecQuality;
			obj.NeededTalkPower = msg.NeededTalkPower;
			obj.IconId = msg.IconId;
			obj.CodecLatencyFactor = msg.CodecLatencyFactor;
			obj.IsUnencrypted = msg.IsUnencrypted;
			obj.DeleteDelay = msg.DeleteDelay;
			obj.PhoneticName = msg.PhoneticName;
			
		}

	
		public void UpdateChannelList(ChannelList msg)
		{
			var obj = new Channel();
			obj.Parent = msg.ChannelParentId;
			{
			var tmp = MaxClientsClFun(msg);
			obj.MaxClients = tmp.Item1;
			obj.MaxFamilyClients = tmp.Item2;
			}
			obj.ChannelType = ChannelTypeClFun(msg);
			obj.OptionalData = null;
			obj.Name = msg.Name;
			obj.Topic = msg.Topic;
			obj.Codec = msg.Codec;
			obj.CodecQuality = msg.CodecQuality;
			obj.Order = msg.Order;
			obj.IsDefault = msg.IsDefault;
			obj.HasPassword = msg.HasPassword;
			obj.CodecLatencyFactor = msg.CodecLatencyFactor;
			obj.IsUnencrypted = msg.IsUnencrypted;
			obj.DeleteDelay = msg.DeleteDelay;
			obj.NeededTalkPower = msg.NeededTalkPower;
			obj.ForcedSilence = msg.ForcedSilence;
			obj.PhoneticName = msg.PhoneticName;
			obj.IconId = msg.IconId;
			obj.IsPrivate = msg.IsPrivate;
			SetChannel(obj, msg.ChannelId);
			
		}

	
		public void UpdateChannelMoved(ChannelMoved msg)
		{
			var obj = GetChannel(msg.ChannelId);
			obj.Parent = msg.ChannelParentId;
			obj.Order = msg.Order;
			
		}

	
		public void UpdateClientChannelGroupChanged(ClientChannelGroupChanged msg)
		{
			var obj = GetClient(msg.ClientId);
			obj.ChannelGroup = msg.ChannelGroup;
			
		}

	
		public void UpdateClientEnterView(ClientEnterView msg)
		{
			var obj = new Client();
			obj.Channel = msg.TargetChannelId;
			obj.AwayMessage = AwayFun(msg);
			obj.TalkPowerRequest = TalkPowerFun(msg);
			obj.OptionalData = null;
			obj.ConnectionData = null;
			{ var tmp = BadgesFun(msg); if (tmp != null) obj.Badges.AddRange(tmp); }
			obj.DatabaseId = msg.DatabaseId;
			obj.Name = msg.Name;
			obj.ClientType = msg.ClientType;
			obj.Uid = msg.Uid;
			obj.AvatarHash = msg.AvatarHash;
			obj.Description = msg.Description;
			obj.IconId = msg.IconId;
			obj.InputMuted = msg.InputMuted;
			obj.OutputMuted = msg.OutputMuted;
			obj.OutputOnlyMuted = msg.OutputOnlyMuted;
			obj.InputHardwareEnabled = msg.InputHardwareEnabled;
			obj.OutputHardwareEnabled = msg.OutputHardwareEnabled;
			obj.Metadata = msg.Metadata;
			obj.IsRecording = msg.IsRecording;
			obj.ChannelGroup = msg.ChannelGroup;
			obj.InheritedChannelGroupFromChannel = msg.InheritedChannelGroupFromChannel;
			{ var tmp = msg.ServerGroups; if (tmp != null) obj.ServerGroups.AddRange(tmp); }
			obj.TalkPower = msg.TalkPower;
			obj.TalkPowerGranted = msg.TalkPowerGranted;
			obj.IsPrioritySpeaker = msg.IsPrioritySpeaker;
			obj.UnreadMessages = msg.UnreadMessages;
			obj.PhoneticName = msg.PhoneticName;
			obj.NeededServerqueryViewPower = msg.NeededServerqueryViewPower;
			obj.IsChannelCommander = msg.IsChannelCommander;
			obj.CountryCode = msg.CountryCode;
			SetClient(obj, msg.ClientId);
			
		}

	
		public void UpdateClientLeftView(ClientLeftView msg)
		{
			
			RemoveClient(msg.ClientId);
		}

	
		public void UpdateClientMoved(ClientMoved msg)
		{
			var obj = GetClient(msg.ClientId);
			obj.Channel = msg.TargetChannelId;
			
		}

	
		public void UpdateConnectionInfo(ConnectionInfo msg)
		{
			var obj = new ConnectionClientData();
			obj.ClientAddress = AddressFun(msg);
			obj.Ping = msg.Ping;
			obj.PingDeviation = msg.PingDeviation;
			obj.ConnectedTime = msg.ConnectedTime;
			obj.PacketsSentSpeech = msg.PacketsSentSpeech;
			obj.PacketsSentKeepalive = msg.PacketsSentKeepalive;
			obj.PacketsSentControl = msg.PacketsSentControl;
			obj.BytesSentSpeech = msg.BytesSentSpeech;
			obj.BytesSentKeepalive = msg.BytesSentKeepalive;
			obj.BytesSentControl = msg.BytesSentControl;
			obj.PacketsReceivedSpeech = msg.PacketsReceivedSpeech;
			obj.PacketsReceivedKeepalive = msg.PacketsReceivedKeepalive;
			obj.PacketsReceivedControl = msg.PacketsReceivedControl;
			obj.BytesReceivedSpeech = msg.BytesReceivedSpeech;
			obj.BytesReceivedKeepalive = msg.BytesReceivedKeepalive;
			obj.BytesReceivedControl = msg.BytesReceivedControl;
			obj.ServerToClientPacketlossSpeech = msg.ServerToClientPacketlossSpeech;
			obj.ServerToClientPacketlossKeepalive = msg.ServerToClientPacketlossKeepalive;
			obj.ServerToClientPacketlossControl = msg.ServerToClientPacketlossControl;
			obj.ServerToClientPacketlossTotal = msg.ServerToClientPacketlossTotal;
			obj.ClientToServerPacketlossSpeech = msg.ClientToServerPacketlossSpeech;
			obj.ClientToServerPacketlossKeepalive = msg.ClientToServerPacketlossKeepalive;
			obj.ClientToServerPacketlossControl = msg.ClientToServerPacketlossControl;
			obj.ClientToServerPacketlossTotal = msg.ClientToServerPacketlossTotal;
			obj.BandwidthSentLastSecondSpeech = msg.BandwidthSentLastSecondSpeech;
			obj.BandwidthSentLastSecondKeepalive = msg.BandwidthSentLastSecondKeepalive;
			obj.BandwidthSentLastSecondControl = msg.BandwidthSentLastSecondControl;
			obj.BandwidthSentLastMinuteSpeech = msg.BandwidthSentLastMinuteSpeech;
			obj.BandwidthSentLastMinuteKeepalive = msg.BandwidthSentLastMinuteKeepalive;
			obj.BandwidthSentLastMinuteControl = msg.BandwidthSentLastMinuteControl;
			obj.BandwidthReceivedLastSecondSpeech = msg.BandwidthReceivedLastSecondSpeech;
			obj.BandwidthReceivedLastSecondKeepalive = msg.BandwidthReceivedLastSecondKeepalive;
			obj.BandwidthReceivedLastSecondControl = msg.BandwidthReceivedLastSecondControl;
			obj.BandwidthReceivedLastMinuteSpeech = msg.BandwidthReceivedLastMinuteSpeech;
			obj.BandwidthReceivedLastMinuteKeepalive = msg.BandwidthReceivedLastMinuteKeepalive;
			obj.BandwidthReceivedLastMinuteControl = msg.BandwidthReceivedLastMinuteControl;
			obj.FiletransferBandwidthSent = msg.FiletransferBandwidthSent;
			obj.FiletransferBandwidthReceived = msg.FiletransferBandwidthReceived;
			obj.IdleTime = msg.IdleTime;
			SetConnectionClientData(obj, msg.ClientId);
			
		}

	
		public void UpdateClientServerGroupAdded(ClientServerGroupAdded msg)
		{
			var obj = GetClient(msg.ClientId);
			obj.ServerGroups.Add(msg.ServerGroupId);
			
		}

	
		public void UpdateServerGroupList(ServerGroupList msg)
		{
			var obj = new ServerGroup();
			obj.Name = msg.Name;
			obj.GroupType = msg.GroupType;
			obj.IconId = msg.IconId;
			obj.IsPermanent = msg.IsPermanent;
			obj.SortId = msg.SortId;
			obj.NamingMode = msg.NamingMode;
			obj.NeededModifyPower = msg.NeededModifyPower;
			obj.NeededMemberAddPower = msg.NeededMemberAddPower;
			obj.NeededMemberRemovePower = msg.NeededMemberRemovePower;
			SetServerGroup(obj, msg.ServerGroupId);
			
		}

	
		public void UpdateServerEdited(ServerEdited msg)
		{
			var obj = GetServer();
			obj.Name = msg.Name;
			obj.CodecEncryptionMode = msg.CodecEncryptionMode;
			obj.DefaultServerGroup = msg.DefaultServerGroup;
			obj.DefaultChannelGroup = msg.DefaultChannelGroup;
			obj.HostbannerUrl = msg.HostbannerUrl;
			obj.HostbannerGfxUrl = msg.HostbannerGfxUrl;
			obj.HostbannerGfxInterval = msg.HostbannerGfxInterval;
			obj.PrioritySpeakerDimmModificator = msg.PrioritySpeakerDimmModificator;
			obj.HostbuttonTooltip = msg.HostbuttonTooltip;
			obj.HostbuttonUrl = msg.HostbuttonUrl;
			obj.HostbuttonGfxUrl = msg.HostbuttonGfxUrl;
			obj.PhoneticName = msg.PhoneticName;
			obj.IconId = msg.IconId;
			obj.HostbannerMode = msg.HostbannerMode;
			obj.TempChannelDefaultDeleteDelay = msg.TempChannelDefaultDeleteDelay;
			
		}

	
#pragma warning restore IDE0017
	}
}