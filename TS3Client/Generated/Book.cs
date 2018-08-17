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
	using System;
	using System.Collections.Generic;

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

	public sealed partial class ServerGroup
	{
		public ServerGroup()
		{
			
		}

	
		public ServerGroupId Id { get; internal set; }
		public str Name { get; set; }
		public GroupType GroupType { get; set; }
		public IconHash IconId { get; set; }
		public bool IsPermanent { get; set; }
		public i32 SortId { get; set; }
		public GroupNamingMode NamingMode { get; set; }
		public i32 NeededModifyPower { get; set; }
		public i32 NeededMemberAddPower { get; set; }
		public i32 NeededMemberRemovePower { get; set; }
	}

	public sealed partial class File
	{
		public File()
		{
			
		}

	
		public str Path { get; set; }
		public str Name { get; set; }
		public i64 Size { get; set; }
		public DateTime LastChanged { get; set; }
		public bool IsFile { get; set; }
	}

	public sealed partial class OptionalChannelData
	{
		public OptionalChannelData()
		{
			
		}

	
		public str Description { get; set; }
	}

	public sealed partial class Channel
	{
		public Channel()
		{
			
		}

	
		public ChannelId Id { get; internal set; }
		public ChannelId Parent { get; set; }
		public str Name { get; set; }
		public str Topic { get; set; }
		public Codec Codec { get; set; }
		public u8 CodecQuality { get; set; }
		public u16 MaxClients { get; set; }
		public MaxFamilyClients MaxFamilyClients { get; set; }
		public i32 Order { get; set; }
		public ChannelType ChannelType { get; set; }
		public bool IsDefault { get; set; }
		public bool HasPassword { get; set; }
		public i32 CodecLatencyFactor { get; set; }
		public bool IsUnencrypted { get; set; }
		public Duration DeleteDelay { get; set; }
		public i32 NeededTalkPower { get; set; }
		public bool ForcedSilence { get; internal set; }
		public str PhoneticName { get; set; }
		public IconHash IconId { get; set; }
		public bool IsPrivate { get; set; }
		public OptionalChannelData OptionalData { get; internal set; }
	}

	public sealed partial class OptionalClientData
	{
		public OptionalClientData()
		{
			
		}

	
		public str Version { get; set; }
		public str Platform { get; set; }
		public str LoginName { get; internal set; }
		public DateTime Created { get; internal set; }
		public DateTime LastConnected { get; internal set; }
		public u32 TotalConnection { get; internal set; }
		public u64 MonthBytesUploaded { get; internal set; }
		public u64 MonthBytesDownloaded { get; internal set; }
		public u64 TotalBytesUploaded { get; internal set; }
		public u64 TotalBytesDownloaded { get; internal set; }
	}

	public sealed partial class ConnectionClientData
	{
		public ConnectionClientData()
		{
			
		}

	
		public Duration Ping { get; internal set; }
		public Duration PingDeviation { get; internal set; }
		public Duration ConnectedTime { get; internal set; }
		public SocketAddr ClientAddress { get; internal set; }
		public u64 PacketsSentSpeech { get; internal set; }
		public u64 PacketsSentKeepalive { get; internal set; }
		public u64 PacketsSentControl { get; internal set; }
		public u64 BytesSentSpeech { get; internal set; }
		public u64 BytesSentKeepalive { get; internal set; }
		public u64 BytesSentControl { get; internal set; }
		public u64 PacketsReceivedSpeech { get; internal set; }
		public u64 PacketsReceivedKeepalive { get; internal set; }
		public u64 PacketsReceivedControl { get; internal set; }
		public u64 BytesReceivedSpeech { get; internal set; }
		public u64 BytesReceivedKeepalive { get; internal set; }
		public u64 BytesReceivedControl { get; internal set; }
		public f32 ServerToClientPacketlossSpeech { get; internal set; }
		public f32 ServerToClientPacketlossKeepalive { get; internal set; }
		public f32 ServerToClientPacketlossControl { get; internal set; }
		public f32 ServerToClientPacketlossTotal { get; internal set; }
		public f32 ClientToServerPacketlossSpeech { get; internal set; }
		public f32 ClientToServerPacketlossKeepalive { get; internal set; }
		public f32 ClientToServerPacketlossControl { get; internal set; }
		public f32 ClientToServerPacketlossTotal { get; internal set; }
		public u64 BandwidthSentLastSecondSpeech { get; internal set; }
		public u64 BandwidthSentLastSecondKeepalive { get; internal set; }
		public u64 BandwidthSentLastSecondControl { get; internal set; }
		public u64 BandwidthSentLastMinuteSpeech { get; internal set; }
		public u64 BandwidthSentLastMinuteKeepalive { get; internal set; }
		public u64 BandwidthSentLastMinuteControl { get; internal set; }
		public u64 BandwidthReceivedLastSecondSpeech { get; internal set; }
		public u64 BandwidthReceivedLastSecondKeepalive { get; internal set; }
		public u64 BandwidthReceivedLastSecondControl { get; internal set; }
		public u64 BandwidthReceivedLastMinuteSpeech { get; internal set; }
		public u64 BandwidthReceivedLastMinuteKeepalive { get; internal set; }
		public u64 BandwidthReceivedLastMinuteControl { get; internal set; }
		public u64 FiletransferBandwidthSent { get; internal set; }
		public u64 FiletransferBandwidthReceived { get; internal set; }
		public Duration IdleTime { get; internal set; }
	}

	public sealed partial class Client
	{
		public Client()
		{
			ServerGroups = new List<ServerGroupId>();
			Badges = new List<str>();
			
		}

	
		public ClientId Id { get; internal set; }
		public ChannelId Channel { get; set; }
		public Uid Uid { get; internal set; }
		public str Name { get; set; }
		public bool InputMuted { get; set; }
		public bool OutputMuted { get; set; }
		public bool OutputOnlyMuted { get; set; }
		public bool InputHardwareEnabled { get; set; }
		public bool OutputHardwareEnabled { get; set; }
		public bool TalkPowerGranted { get; set; }
		public str Metadata { get; set; }
		public bool IsRecording { get; set; }
		public ClientDbId DatabaseId { get; internal set; }
		public ChannelGroupId ChannelGroup { get; set; }
		public List<ServerGroupId> ServerGroups { get; set; }
		public str AwayMessage { get; set; }
		public ClientType ClientType { get; internal set; }
		public str AvatarHash { get; internal set; }
		public i32 TalkPower { get; internal set; }
		public TalkPowerRequest TalkPowerRequest { get; internal set; }
		public str Description { get; set; }
		public bool IsPrioritySpeaker { get; set; }
		public u32 UnreadMessages { get; internal set; }
		public str PhoneticName { get; set; }
		public i32 NeededServerqueryViewPower { get; internal set; }
		public IconHash IconId { get; internal set; }
		public bool IsChannelCommander { get; set; }
		public str CountryCode { get; internal set; }
		public ChannelId InheritedChannelGroupFromChannel { get; internal set; }
		public List<str> Badges { get; set; }
		public OptionalClientData OptionalData { get; internal set; }
		public ConnectionClientData ConnectionData { get; internal set; }
	}

	public sealed partial class OptionalServerData
	{
		public OptionalServerData()
		{
			
		}

	
		public u32 ConnectionCount { get; internal set; }
		public u64 ChannelCount { get; internal set; }
		public Duration Uptime { get; internal set; }
		public bool HasPassword { get; internal set; }
		public ChannelGroupId DefaultChannelAdminGroup { get; set; }
		public u64 MaxDownloadTotalBandwith { get; set; }
		public u64 MaxUploadTotalBandwith { get; set; }
		public u32 ComplainAutobanCount { get; set; }
		public Duration ComplainAutobanTime { get; set; }
		public Duration ComplainRemoveTime { get; set; }
		public u16 MinClientsForceSilence { get; set; }
		public u32 AntifloodPointsTickReduce { get; set; }
		public u32 AntifloodPointsNeededCommandBlock { get; set; }
		public u16 ClientCount { get; internal set; }
		public u32 QueryCount { get; internal set; }
		public u32 QueryOnlineCount { get; internal set; }
		public u64 DownloadQuota { get; set; }
		public u64 UploadQuota { get; set; }
		public u64 MonthBytesDownloaded { get; internal set; }
		public u64 MonthBytesUploaded { get; internal set; }
		public u64 TotalBytesDownloaded { get; internal set; }
		public u64 TotalBytesUploaded { get; internal set; }
		public u16 Port { get; internal set; }
		public bool Autostart { get; set; }
		public str MachineId { get; internal set; }
		public u8 NeededIdentitySecurityLevel { get; set; }
		public bool LogClient { get; set; }
		public bool LogQuery { get; set; }
		public bool LogChannel { get; set; }
		public bool LogPermissions { get; set; }
		public bool LogServer { get; set; }
		public bool LogFileTransfer { get; set; }
		public DateTime MinClientVersion { get; internal set; }
		public u16 ReservedSlots { get; set; }
		public f32 TotalPacketlossSpeech { get; internal set; }
		public f32 TotalPacketlossKeepalive { get; internal set; }
		public f32 TotalPacketlossControl { get; internal set; }
		public f32 TotalPacketlossTotal { get; internal set; }
		public Duration TotalPing { get; internal set; }
		public bool WeblistEnabled { get; set; }
		public DateTime MinAndroidVersion { get; internal set; }
		public DateTime MinIosVersion { get; internal set; }
	}

	public sealed partial class ConnectionServerData
	{
		public ConnectionServerData()
		{
			
		}

	
		public u64 FileTransferBandwidthSent { get; internal set; }
		public u64 FileTransferBandwidthReceived { get; internal set; }
		public u64 FileTransferBytesSentTotal { get; internal set; }
		public u64 FileTransferBytesReceivedTotal { get; internal set; }
		public u64 PacketsSentTotal { get; internal set; }
		public u64 BytesSentTotal { get; internal set; }
		public u64 PacketsReceivedTotal { get; internal set; }
		public u64 BytesReceivedTotal { get; internal set; }
		public u64 BandwidthSentLastSecondTotal { get; internal set; }
		public u64 BandwidthSentLastMinuteTotal { get; internal set; }
		public u64 BandwidthReceivedLastSecondTotal { get; internal set; }
		public u64 BandwidthReceivedLastMinuteTotal { get; internal set; }
		public Duration ConnectedTime { get; internal set; }
		public f32 PacketlossTotal { get; internal set; }
		public Duration Ping { get; internal set; }
	}

	public sealed partial class Server
	{
		public Server()
		{
			Ip = new List<str>();
			Clients = new Dictionary<ClientId,Client>();
			Channels = new Dictionary<ChannelId,Channel>();
			Groups = new Dictionary<ServerGroupId,ServerGroup>();
			
		}

	
		public Uid Uid { get; internal set; }
		public u64 VirtualServerId { get; internal set; }
		public str Name { get; internal set; }
		public str WelcomeMessage { get; internal set; }
		public str Platform { get; internal set; }
		public str Version { get; internal set; }
		public u16 MaxClients { get; internal set; }
		public DateTime Created { get; internal set; }
		public CodecEncryptionMode CodecEncryptionMode { get; set; }
		public str Hostmessage { get; set; }
		public HostMessageMode HostmessageMode { get; set; }
		public ServerGroupId DefaultServerGroup { get; set; }
		public ChannelGroupId DefaultChannelGroup { get; set; }
		public str HostbannerUrl { get; set; }
		public str HostbannerGfxUrl { get; set; }
		public Duration HostbannerGfxInterval { get; set; }
		public f32 PrioritySpeakerDimmModificator { get; set; }
		public str HostbuttonTooltip { get; set; }
		public str HostbuttonUrl { get; set; }
		public str HostbuttonGfxUrl { get; set; }
		public str PhoneticName { get; set; }
		public IconHash IconId { get; internal set; }
		public List<str> Ip { get; internal set; }
		public bool AskForPrivilegekey { get; internal set; }
		public HostBannerMode HostbannerMode { get; set; }
		public Duration TempChannelDefaultDeleteDelay { get; set; }
		public u16 ProtocolVersion { get; internal set; }
		public LicenseType License { get; internal set; }
		public OptionalServerData OptionalData { get; internal set; }
		public ConnectionServerData ConnectionData { get; internal set; }
		public Dictionary<ClientId,Client> Clients { get; internal set; }
		public Dictionary<ChannelId,Channel> Channels { get; internal set; }
		public Dictionary<ServerGroupId,ServerGroup> Groups { get; internal set; }
	}

	public sealed partial class Connection
	{
		public Connection()
		{
			
		}

	
		public ConnectionId Id { get; internal set; }
		public ClientId OwnClient { get; internal set; }
		public Server Server { get; internal set; }
	}

	public sealed partial class ChatEntry
	{
		public ChatEntry()
		{
			
		}

	
		public ClientId SenderClient { get; internal set; }
		public str Text { get; internal set; }
		public DateTime Date { get; internal set; }
		public TextMessageTargetMode Mode { get; internal set; }
	}

}