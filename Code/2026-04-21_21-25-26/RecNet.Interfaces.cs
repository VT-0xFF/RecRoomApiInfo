using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Net.Http;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Runtime.Serialization;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading;
using System.Threading.Tasks;
using Cpp2IlInjected;
using Microsoft.CodeAnalysis;
using RecNet.AI;
using RecNet.Common;
using RecNet.Interfaces.IDs;
using RecNet.Interfaces.TimeLimitedEvents;
using RecNet.Store;
using RecNet.Tags;
using RecRoom;
using RecRoom.AssetIds;
using RecRoom.Async;
using RecRoom.Avatars.Serialization;
using RecRoom.DataLayer;
using RecRoom.DataLayer.Audio;
using RecRoom.NoEngine.Common;
using RecRoom.NoEngine.DataStructures;

[assembly: AssemblyVersion("0.0.0.0")]
namespace Microsoft.CodeAnalysis
{
	[Cpp2IlInjected.Token(Token = "0x2000002")]
	[CompilerGenerated]
	[Microsoft.CodeAnalysis.Embedded]
	internal sealed class EmbeddedAttribute : Attribute
	{
		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(RVA = "0xD39E50", Offset = "0xD38850", VA = "0x180D39E50")]
		public EmbeddedAttribute()
		{
		}
	}
}
namespace System.Runtime.CompilerServices
{
	[Cpp2IlInjected.Token(Token = "0x2000003")]
	[CompilerGenerated]
	[Microsoft.CodeAnalysis.Embedded]
	[AttributeUsage(AttributeTargets.Class | AttributeTargets.Property | AttributeTargets.Field | AttributeTargets.Event | AttributeTargets.Parameter | AttributeTargets.ReturnValue | AttributeTargets.GenericParameter, AllowMultiple = false, Inherited = false)]
	internal sealed class NullableAttribute : Attribute
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000001")]
		public readonly byte[] NullableFlags;

		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0x8DC3500", Offset = "0x8DC1F00", VA = "0x188DC3500")]
		public NullableAttribute(byte P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0xD3A120", Offset = "0xD38B20", VA = "0x180D3A120")]
		public NullableAttribute(byte[] P_0)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000004")]
	[CompilerGenerated]
	[Microsoft.CodeAnalysis.Embedded]
	[AttributeUsage(AttributeTargets.Class | AttributeTargets.Struct | AttributeTargets.Method | AttributeTargets.Interface | AttributeTargets.Delegate, AllowMultiple = false, Inherited = false)]
	internal sealed class NullableContextAttribute : Attribute
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000002")]
		public readonly byte Flag;

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0xD3A160", Offset = "0xD38B60", VA = "0x180D3A160")]
		public NullableContextAttribute(byte P_0)
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public class FUCDGVARUTZ
{
	[Cpp2IlInjected.Token(Token = "0x2000006")]
	public enum ResultStates
	{
		[Cpp2IlInjected.Token(Token = "0x4000007")]
		Error,
		[Cpp2IlInjected.Token(Token = "0x4000008")]
		Cancelled,
		[Cpp2IlInjected.Token(Token = "0x4000009")]
		Success
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	public string KNTNPMEBSPH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000005")]
	public string HFEILVWJFGS;

	[Cpp2IlInjected.Token(Token = "0x17000001")]
	public ResultStates QWGVRSETZIR
	{
		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0xD0F110", Offset = "0xD0DB10", VA = "0x180D0F110")]
		[CompilerGenerated]
		get
		{
			return default(ResultStates);
		}
		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0xD12F30", Offset = "0xD11930", VA = "0x180D12F30")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	public bool ASUBSUZHIYG
	{
		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x2248210", Offset = "0x2246C10", VA = "0x182248210")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	public bool DAFMWQYQIJY
	{
		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x1AC8C90", Offset = "0x1AC7690", VA = "0x181AC8C90")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x8DBF510", Offset = "0x8DBDF10", VA = "0x188DBF510")]
	[Obsolete("Use RecNet.Store.SkuPurchaseResult instead")]
	public static FUCDGVARUTZ Success()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x8DBF480", Offset = "0x8DBDE80", VA = "0x188DBF480")]
	[Obsolete("Use RecNet.Store.SkuPurchaseResult instead")]
	public static FUCDGVARUTZ Cancelled([Optional] string userFriendlyError, [Optional] string internalError)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0xD16C40", Offset = "0xD15640", VA = "0x180D16C40")]
	public FUCDGVARUTZ()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
[CompilerGenerated]
[EditorBrowsable(EditorBrowsableState.Never)]
[GeneratedCode("Unity.MonoScriptGenerator.MonoScriptInfoGenerator", null)]
internal class IXBFVIJSSFJ
{
	[Cpp2IlInjected.Token(Token = "0x2000008")]
	private struct MonoScriptData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000A")]
		public byte[] FilePathsData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400000B")]
		public byte[] TypesData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400000C")]
		public int TotalTypes;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x400000D")]
		public int TotalFiles;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400000E")]
		public bool IsEditorOnly;
	}

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0x8DC0F60", Offset = "0x8DBF960", VA = "0x188DC0F60")]
	private static MonoScriptData Get()
	{
		return default(MonoScriptData);
	}

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0xD16C40", Offset = "0xD15640", VA = "0x180D16C40")]
	public IXBFVIJSSFJ()
	{
	}
}
namespace RecNet
{
	[Cpp2IlInjected.Token(Token = "0x2000009")]
	public interface CEQBEDCXYWE
	{
		[Cpp2IlInjected.Token(Token = "0x17000004")]
		string SessionId
		{
			[Cpp2IlInjected.Token(Token = "0x600000E")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000005")]
		string ClientSecret
		{
			[Cpp2IlInjected.Token(Token = "0x600000F")]
			[Cpp2IlInjected.Address(Slot = "1")]
			get;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000A")]
	public interface NYAETDDKAEG
	{
		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(Slot = "0")]
		Task<CEQBEDCXYWE> EPOSCFJBIPG(string a, string b, string c, VoiceOption d, string? transcriptionModel, float e, [Optional] CancellationToken f);
	}
	[Cpp2IlInjected.Token(Token = "0x200000B")]
	public interface RNNWLDFGVFF : NYAETDDKAEG
	{
		[Cpp2IlInjected.Token(Token = "0x17000006")]
		GenerateCircuitsResponseDTO? KIUBVMYUHHF
		{
			[Cpp2IlInjected.Token(Token = "0x6000011")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000007")]
		ASNKAFBFVVA<MakerAITimeBalanceStatusUpdatePushNotification> LMOIUCSJIIL
		{
			[Cpp2IlInjected.Token(Token = "0x6000013")]
			[Cpp2IlInjected.Address(Slot = "2")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000008")]
		ASNKAFBFVVA<MakerAIUsageBalanceStatusUpdatePushNotification> QTWPPCZHWWT
		{
			[Cpp2IlInjected.Token(Token = "0x6000014")]
			[Cpp2IlInjected.Address(Slot = "3")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000009")]
		ASNKAFBFVVA<GenerateMeshResponseDTO> AZBVRBZGTMC
		{
			[Cpp2IlInjected.Token(Token = "0x6000015")]
			[Cpp2IlInjected.Address(Slot = "4")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x1700000A")]
		DYNHRMPGIXT XBPEEHDDBNJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000016")]
			[Cpp2IlInjected.Address(Slot = "5")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(Slot = "1")]
		void OBIEGUWIDOT();

		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(Slot = "6")]
		Task<DisposableMemorySequence<byte>> YMEPIJHNECI(string a, [Optional] CancellationToken b);

		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(Slot = "7")]
		Task<DVTGJVMMMGU> KUFAIHCGDUC(bool a, [Optional] CancellationToken b);

		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(Slot = "8")]
		Task<JXNUQHQTKTV<RoomieEnergyDTO>> KKJJOSQSVNV(bool a = false, [Optional] CancellationToken b);

		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(Slot = "9")]
		Task<DVTGJVMMMGU> HOFDCSAXMMQ(long a, [Optional] CancellationToken b);

		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(Slot = "10")]
		Task<RecNetResultObject<GameAIRoomSpendSummaryDTO>> JMUQLRWCEKQ(long a, bool b = false, [Optional] CancellationToken c);

		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(Slot = "11")]
		Task<GameAIPromoBalanceDTO> PZOVGNGZXDQ([Optional] CancellationToken a);

		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(Slot = "12")]
		Task<GameAIPromoBalanceDTO> HBZJPLMXLUX(long a, [Optional] CancellationToken b);

		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(Slot = "13")]
		Task<MakerAIBalancesDTO> SIKSOPVIPJI(bool a = false, [Optional] CancellationToken b);

		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(Slot = "14")]
		Task<MakerAIFreeTrialConfigDTO> RWMNFSACVGV([Optional] CancellationToken a);

		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(Slot = "15")]
		Task<DVTGJVMMMGU> AWOFBLXHWDO(bool a = false, [Optional] CancellationToken b);

		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(Slot = "16")]
		Task<DVTGJVMMMGU> WBQRSEAJSBK([Optional] CancellationToken a);

		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(Slot = "17")]
		Task<DVTGJVMMMGU> FSCPFNWKVSH(string a, Guid b, long c, long d, decimal e, [Optional] CancellationToken f);

		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(Slot = "18")]
		Task<JXNUQHQTKTV<RoomieEnergyDTO>> FHNRNOUGHGD(Guid a, long b, long c, decimal d, byte e, [Optional] CancellationToken f);

		[Cpp2IlInjected.Token(Token = "0x6000024")]
		[Cpp2IlInjected.Address(Slot = "19")]
		Task CFGLSBENTRW(string a, string b, [Optional] CancellationToken c);

		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(Slot = "20")]
		Task<GenerateImageResponseDTO> MRYDXREQXGC(string a, string b, bool c, [Optional] CancellationToken d);

		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(Slot = "21")]
		Task<GenerateMeshResponseDTO> FZUNDAPBYWJ(long a, string b, string c, string d, string e, [Optional] CancellationToken f);

		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(Slot = "22")]
		Task<GenerateMeshResponseDTO> DYLCHLCBMKJ(long a, [Optional] CancellationToken b);

		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(Slot = "23")]
		Task<DescribeImageResponseDTO> XUUCZSXIEQJ(string? model, string a, string b, [Optional] CancellationToken c);

		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(Slot = "24")]
		Task<DescribeImageResponseDTO> XUUCZSXIEQJ(string? model, string a, byte[] b, [Optional] CancellationToken c);

		[Cpp2IlInjected.Token(Token = "0x600002A")]
		[Cpp2IlInjected.Address(Slot = "25")]
		Task<DescribeImageResponseDTO> NVVATMJMJWW(long a, string? model, string b, string c, float? d, string e, [Optional] CancellationToken f);

		[Cpp2IlInjected.Token(Token = "0x600002B")]
		[Cpp2IlInjected.Address(Slot = "26")]
		Task<DescribeImageResponseDTO> NVVATMJMJWW(long a, string? model, string b, byte[] c, float? d, string e, [Optional] CancellationToken f);

		[Cpp2IlInjected.Token(Token = "0x600002C")]
		[Cpp2IlInjected.Address(Slot = "27")]
		Task<GenerateImageResponseDTO> RAXVPHHIWWT(long a, EditImageRequestDTO b, byte[] c, string d, [Optional] CancellationToken e);

		[Cpp2IlInjected.Token(Token = "0x600002D")]
		[Cpp2IlInjected.Address(Slot = "28")]
		Task<GenerateImageResponseDTO> BIQRZFCDUGC(EditImageRequestDTO a, string b, string c, [Optional] CancellationToken d);

		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(Slot = "29")]
		Task<GenerateImageResponseDTO> POIAANKEXQY(long a, string? model, string b, bool c, string d, [Optional] CancellationToken e);

		[Cpp2IlInjected.Token(Token = "0x600002F")]
		[Cpp2IlInjected.Address(Slot = "30")]
		Task<GenerateAudioOrSongResponseDTO> MNTUIZQURQW(string a, int b, string c, string d, [Optional] CancellationToken e);

		[Cpp2IlInjected.Token(Token = "0x6000030")]
		[Cpp2IlInjected.Address(Slot = "31")]
		Task<GenerateAudioOrSongResponseDTO> TXPBJFKJGDQ(string a, int b, string c, [Optional] CancellationToken d);

		[Cpp2IlInjected.Token(Token = "0x6000031")]
		[Cpp2IlInjected.Address(Slot = "32")]
		Task<ChatResponseDTO> Chat(string? model, string prompt, [Optional] CancellationToken cancellationToken);

		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(Slot = "33")]
		Task<GenerateCircuitsResponseDTO> GenerateCircuits(string prompt, CircuitObjectDefinition? objectDefinition, IReadOnlyList<CircuitObjectDefinition>? sceneObjectDefinitions, IReadOnlyList<string> sceneTags, CircuitGenConfigDTO config, [Optional] string? overrideInstructions, [Optional] string? overrideLibraryCode, [Optional] string? overrideModel, [Optional] CancellationToken cancellationToken);

		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(Slot = "34")]
		Task<GenerateCircuitsResponseDTO> PHLNBLHBLVB(string a, CircuitObjectDefinition? objectDefinition, IReadOnlyList<string> b, CircuitGenConfigDTO c, [Optional] string? overrideLibraryCode, [Optional] CancellationToken d);

		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(Slot = "35")]
		Task<List<string>> SearchRooms(string prompt, [Optional] CancellationToken cancellationToken);

		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(Slot = "36")]
		Task<string> NQQGXPYHTXP(CircuitGenConfigDTO a, [Optional] CancellationToken b);

		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(Slot = "37")]
		Task IVJCSTZVSXW(string a, VoiceOption b, string? instructions, Action<string> c, string d, [Optional] CancellationToken e);

		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(Slot = "38")]
		Task<string> QJKVCQKHFJW(ReadOnlyMemory<byte> pcmData, int a, int b, string c, [Optional] CancellationToken d);

		[Cpp2IlInjected.Token(Token = "0x6000038")]
		[Cpp2IlInjected.Address(Slot = "39")]
		Task<RoomieUserFactsDTO> WGFEYGQIVNZ(List<ConversationMessageDTO> a, [Optional] CancellationToken b);

		[Cpp2IlInjected.Token(Token = "0x6000039")]
		[Cpp2IlInjected.Address(Slot = "40")]
		Task<RoomieUserFactsDTO> ZFWJEVYVSRV([Optional] CancellationToken a);

		[Cpp2IlInjected.Token(Token = "0x600003A")]
		[Cpp2IlInjected.Address(Slot = "41")]
		Task<bool> RGDRMNSXYYT(string a, [Optional] CancellationToken b);

		[Cpp2IlInjected.Token(Token = "0x600003B")]
		[Cpp2IlInjected.Address(Slot = "42")]
		Task VRWINRXVAVM(string a, ConversationMessageRole b, string c, [Optional] CancellationToken d);

		[Cpp2IlInjected.Token(Token = "0x600003C")]
		[Cpp2IlInjected.Address(Slot = "43")]
		Task QMKYXIXENQU(string a, string b, string c, [Optional] CancellationToken d);

		[Cpp2IlInjected.Token(Token = "0x600003D")]
		[Cpp2IlInjected.Address(Slot = "44")]
		Task<GenerateConversationResponseResponseDTO> GYTAUEEFDHJ(string a, string b, [Optional] string? model, [Optional] float? c, [Optional] NamedSchemaDTO? responseFormat, [Optional] IReadOnlyCollection<NamedSchemaDTO>? tools, ToolChoice d = ToolChoice.Auto, [Optional] string? forceToolName, [Optional] CancellationToken e);
	}
	[Cpp2IlInjected.Token(Token = "0x200000C")]
	public class SVLZDUPCXXS
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400000F")]
		private string BWWZTCOEUPI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000010")]
		private string KRSJRUVSFVV;

		[Cpp2IlInjected.Token(Token = "0x1700000B")]
		public string OTPYQEZYIOQ
		{
			[Cpp2IlInjected.Token(Token = "0x600003E")]
			[Cpp2IlInjected.Address(RVA = "0xD12BC0", Offset = "0xD115C0", VA = "0x180D12BC0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600003F")]
			[Cpp2IlInjected.Address(RVA = "0xD11520", Offset = "0xD0FF20", VA = "0x180D11520")]
			[CompilerGenerated]
			internal set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000C")]
		public string ZFCXVVFBFMS
		{
			[Cpp2IlInjected.Token(Token = "0x6000040")]
			[Cpp2IlInjected.Address(RVA = "0xD11B00", Offset = "0xD10500", VA = "0x180D11B00")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000041")]
			[Cpp2IlInjected.Address(RVA = "0xD11530", Offset = "0xD0FF30", VA = "0x180D11530")]
			[CompilerGenerated]
			internal set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000D")]
		public string KRWMLMLSMGG
		{
			[Cpp2IlInjected.Token(Token = "0x6000042")]
			[Cpp2IlInjected.Address(RVA = "0xD11A20", Offset = "0xD10420", VA = "0x180D11A20")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000043")]
			[Cpp2IlInjected.Address(RVA = "0xD17350", Offset = "0xD15D50", VA = "0x180D17350")]
			[CompilerGenerated]
			internal set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000E")]
		public string ORRJXKRKLBC
		{
			[Cpp2IlInjected.Token(Token = "0x6000044")]
			[Cpp2IlInjected.Address(RVA = "0xD12280", Offset = "0xD10C80", VA = "0x180D12280")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000F")]
		public int? BMBMSSBDNNP
		{
			[Cpp2IlInjected.Token(Token = "0x6000045")]
			[Cpp2IlInjected.Address(RVA = "0xD11A30", Offset = "0xD10430", VA = "0x180D11A30")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000010")]
		public int? ULTXIPLRYKF
		{
			[Cpp2IlInjected.Token(Token = "0x6000046")]
			[Cpp2IlInjected.Address(RVA = "0xD122E0", Offset = "0xD10CE0", VA = "0x180D122E0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000047")]
		[Cpp2IlInjected.Address(RVA = "0x8DC5230", Offset = "0x8DC3C30", VA = "0x188DC5230")]
		public SVLZDUPCXXS(string a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000048")]
		[Cpp2IlInjected.Address(RVA = "0x8DC5100", Offset = "0x8DC3B00", VA = "0x188DC5100")]
		public void PJZJTWJRYFG(string a = "")
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000049")]
		[Cpp2IlInjected.Address(RVA = "0x8DC5130", Offset = "0x8DC3B30", VA = "0x188DC5130")]
		private void WDRDUAVLLXV()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000E")]
	public interface RJGTSQKWXGT
	{
		[Cpp2IlInjected.Token(Token = "0x17000011")]
		GBKKNLYTGEE JRIEGFWASMG
		{
			[Cpp2IlInjected.Token(Token = "0x600004E")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x14000001")]
		event Action<SubscriptionStatus> HMDFRVNFZXA;

		[Cpp2IlInjected.Token(Token = "0x14000002")]
		event Action<SubscriptionSnapshot> CGWYSHFOQTV;

		[Cpp2IlInjected.Token(Token = "0x6000053")]
		[Cpp2IlInjected.Address(Slot = "5")]
		Task<SubscriptionSnapshot> RWPWCPPUWFD(bool a = false, [Optional] CancellationToken b);

		[Cpp2IlInjected.Token(Token = "0x6000054")]
		[Cpp2IlInjected.Address(Slot = "6")]
		bool NELESOBBIKP([Out] SubscriptionSnapshot a);
	}
	[Cpp2IlInjected.Token(Token = "0x200000F")]
	public static class MWWWMFATYIF
	{
		[Cpp2IlInjected.Token(Token = "0x6000055")]
		[Cpp2IlInjected.Address(RVA = "0x8DC3170", Offset = "0x8DC1B70", VA = "0x188DC3170")]
		public static bool ZXZSKTZNFDD(this RJGTSQKWXGT a, [Out] SubscriptionStatus b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000056")]
		[Cpp2IlInjected.Address(RVA = "0x8DC3080", Offset = "0x8DC1A80", VA = "0x188DC3080")]
		public static bool JBGXBVERMVH(this RJGTSQKWXGT a)
		{
			return default(bool);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000010")]
	public interface AGZSDVDWTJY
	{
		[Cpp2IlInjected.Token(Token = "0x6000057")]
		[Cpp2IlInjected.Address(Slot = "0")]
		Task QUFCXUXVHJD(CancellationToken a);

		[Cpp2IlInjected.Token(Token = "0x6000058")]
		[Cpp2IlInjected.Address(Slot = "1")]
		bool DPFBFQOXQII(int a, [Out] PNOPGZMUIUD? b);
	}
	[Cpp2IlInjected.Token(Token = "0x2000011")]
	public interface PNOPGZMUIUD
	{
		[Cpp2IlInjected.Token(Token = "0x17000012")]
		int EEUCZEEVOOH
		{
			[Cpp2IlInjected.Token(Token = "0x6000059")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000013")]
		string? CTZDLOJAEUK
		{
			[Cpp2IlInjected.Token(Token = "0x600005A")]
			[Cpp2IlInjected.Address(Slot = "1")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000014")]
		string? UZNYKMCUYRT
		{
			[Cpp2IlInjected.Token(Token = "0x600005B")]
			[Cpp2IlInjected.Address(Slot = "2")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000015")]
		bool? MMFEQYBKVNL
		{
			[Cpp2IlInjected.Token(Token = "0x600005C")]
			[Cpp2IlInjected.Address(Slot = "3")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000016")]
		string? UCFHNGKOZXZ
		{
			[Cpp2IlInjected.Token(Token = "0x600005D")]
			[Cpp2IlInjected.Address(Slot = "4")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000017")]
		string? MMOGFUVGOKZ
		{
			[Cpp2IlInjected.Token(Token = "0x600005E")]
			[Cpp2IlInjected.Address(Slot = "5")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000018")]
		TIUPSAAKOTS? NHPNKFLPSBU
		{
			[Cpp2IlInjected.Token(Token = "0x600005F")]
			[Cpp2IlInjected.Address(Slot = "6")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x6000060")]
		[Cpp2IlInjected.Address(Slot = "7")]
		bool RAIRGTYSDXB(string a, [Out] BCULPTOVUST? config);
	}
	[Cpp2IlInjected.Token(Token = "0x2000012")]
	public interface BCULPTOVUST
	{
		[Cpp2IlInjected.Token(Token = "0x17000019")]
		string? BWVUNFZSXMB
		{
			[Cpp2IlInjected.Token(Token = "0x6000061")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x1700001A")]
		string? FMHFUENFPMO
		{
			[Cpp2IlInjected.Token(Token = "0x6000062")]
			[Cpp2IlInjected.Address(Slot = "1")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x1700001B")]
		string? HVPXZBMLEZR
		{
			[Cpp2IlInjected.Token(Token = "0x6000063")]
			[Cpp2IlInjected.Address(Slot = "2")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x1700001C")]
		IReadOnlyList<PJOWHUQDHNZ>? QUSEZVXMZMO
		{
			[Cpp2IlInjected.Token(Token = "0x6000064")]
			[Cpp2IlInjected.Address(Slot = "3")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x1700001D")]
		TIUPSAAKOTS? NHPNKFLPSBU
		{
			[Cpp2IlInjected.Token(Token = "0x6000065")]
			[Cpp2IlInjected.Address(Slot = "4")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x1700001E")]
		long? MUEDHFKVGIE
		{
			[Cpp2IlInjected.Token(Token = "0x6000066")]
			[Cpp2IlInjected.Address(Slot = "5")]
			get;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000013")]
	public interface PJOWHUQDHNZ
	{
		[Cpp2IlInjected.Token(Token = "0x1700001F")]
		string FMHFUENFPMO
		{
			[Cpp2IlInjected.Token(Token = "0x6000067")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000020")]
		string YFKMMNNXMAZ
		{
			[Cpp2IlInjected.Token(Token = "0x6000068")]
			[Cpp2IlInjected.Address(Slot = "1")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000021")]
		SKUButtonAction RWUVWKPWEQM
		{
			[Cpp2IlInjected.Token(Token = "0x6000069")]
			[Cpp2IlInjected.Address(Slot = "2")]
			get;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000014")]
	public interface TIUPSAAKOTS
	{
		[Cpp2IlInjected.Token(Token = "0x17000022")]
		string FMHFUENFPMO
		{
			[Cpp2IlInjected.Token(Token = "0x600006A")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000023")]
		string? KPVDDMDHDLV
		{
			[Cpp2IlInjected.Token(Token = "0x600006B")]
			[Cpp2IlInjected.Address(Slot = "1")]
			get;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000015")]
	[Utf8JsonSerializable]
	public class InitiatePurchaseRequest
	{
		[Cpp2IlInjected.Token(Token = "0x17000024")]
		public string AccessToken
		{
			[Cpp2IlInjected.Token(Token = "0x600006C")]
			[Cpp2IlInjected.Address(RVA = "0xD117B0", Offset = "0xD101B0", VA = "0x180D117B0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600006D")]
			[Cpp2IlInjected.Address(RVA = "0xD117C0", Offset = "0xD101C0", VA = "0x180D117C0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000025")]
		public int SkuId
		{
			[Cpp2IlInjected.Token(Token = "0x600006E")]
			[Cpp2IlInjected.Address(RVA = "0xD17340", Offset = "0xD15D40", VA = "0x180D17340")]
			[CompilerGenerated]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x600006F")]
			[Cpp2IlInjected.Address(RVA = "0xD17360", Offset = "0xD15D60", VA = "0x180D17360")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000026")]
		public int? PurchaseReminderId
		{
			[Cpp2IlInjected.Token(Token = "0x6000070")]
			[Cpp2IlInjected.Address(RVA = "0x141BB50", Offset = "0x141A550", VA = "0x18141BB50")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000071")]
			[Cpp2IlInjected.Address(RVA = "0x141BB80", Offset = "0x141A580", VA = "0x18141BB80")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000027")]
		public int? RRPlusSignUpBonusId
		{
			[Cpp2IlInjected.Token(Token = "0x6000072")]
			[Cpp2IlInjected.Address(RVA = "0x141BB60", Offset = "0x141A560", VA = "0x18141BB60")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000073")]
			[Cpp2IlInjected.Address(RVA = "0x10CE4D0", Offset = "0x10CCED0", VA = "0x1810CE4D0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000028")]
		public List<ItemPurchaseMethodId> BonusItemIds
		{
			[Cpp2IlInjected.Token(Token = "0x6000074")]
			[Cpp2IlInjected.Address(RVA = "0xD11A20", Offset = "0xD10420", VA = "0x180D11A20")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000075")]
			[Cpp2IlInjected.Address(RVA = "0xD17350", Offset = "0xD15D50", VA = "0x180D17350")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000029")]
		public List<GrantableId> BonusSelectableGrantableIds
		{
			[Cpp2IlInjected.Token(Token = "0x6000076")]
			[Cpp2IlInjected.Address(RVA = "0xD12280", Offset = "0xD10C80", VA = "0x180D12280")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000077")]
			[Cpp2IlInjected.Address(RVA = "0xD11B50", Offset = "0xD10550", VA = "0x180D11B50")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002A")]
		public int? GiftRecipientAccountId
		{
			[Cpp2IlInjected.Token(Token = "0x6000078")]
			[Cpp2IlInjected.Address(RVA = "0xD11A30", Offset = "0xD10430", VA = "0x180D11A30")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000079")]
			[Cpp2IlInjected.Address(RVA = "0xFFBC20", Offset = "0xFFA620", VA = "0x180FFBC20")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002B")]
		public string GiftRecipientMessage
		{
			[Cpp2IlInjected.Token(Token = "0x600007A")]
			[Cpp2IlInjected.Address(RVA = "0xD122E0", Offset = "0xD10CE0", VA = "0x180D122E0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600007B")]
			[Cpp2IlInjected.Address(RVA = "0xD12290", Offset = "0xD10C90", VA = "0x180D12290")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600007C")]
		[Cpp2IlInjected.Address(RVA = "0xD16C40", Offset = "0xD15640", VA = "0x180D16C40")]
		public InitiatePurchaseRequest()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000016")]
	[Utf8JsonSerializable]
	public class InitiatePurchaseResponse
	{
		[Cpp2IlInjected.Token(Token = "0x1700002C")]
		public long TransactionId
		{
			[Cpp2IlInjected.Token(Token = "0x600007D")]
			[Cpp2IlInjected.Address(RVA = "0xD117B0", Offset = "0xD101B0", VA = "0x180D117B0")]
			[CompilerGenerated]
			get
			{
				return default(long);
			}
			[Cpp2IlInjected.Token(Token = "0x600007E")]
			[Cpp2IlInjected.Address(RVA = "0xED90B0", Offset = "0xED7AB0", VA = "0x180ED90B0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600007F")]
		[Cpp2IlInjected.Address(RVA = "0xD16C40", Offset = "0xD15640", VA = "0x180D16C40")]
		public InitiatePurchaseResponse()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000017")]
	[Utf8JsonSerializable]
	public class ProcessPurchaseRequest
	{
		[Cpp2IlInjected.Token(Token = "0x1700002D")]
		public string AccessToken
		{
			[Cpp2IlInjected.Token(Token = "0x6000080")]
			[Cpp2IlInjected.Address(RVA = "0xD117B0", Offset = "0xD101B0", VA = "0x180D117B0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000081")]
			[Cpp2IlInjected.Address(RVA = "0xD117C0", Offset = "0xD101C0", VA = "0x180D117C0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002E")]
		public string PurchaseDetails
		{
			[Cpp2IlInjected.Token(Token = "0x6000082")]
			[Cpp2IlInjected.Address(RVA = "0xD11B30", Offset = "0xD10530", VA = "0x180D11B30")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000083")]
			[Cpp2IlInjected.Address(RVA = "0xD12270", Offset = "0xD10C70", VA = "0x180D12270")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002F")]
		public int? PurchaseReminderId
		{
			[Cpp2IlInjected.Token(Token = "0x6000084")]
			[Cpp2IlInjected.Address(RVA = "0xD12BC0", Offset = "0xD115C0", VA = "0x180D12BC0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000085")]
			[Cpp2IlInjected.Address(RVA = "0xE3F130", Offset = "0xE3DB30", VA = "0x180E3F130")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000030")]
		public int? RRPlusSignUpBonusId
		{
			[Cpp2IlInjected.Token(Token = "0x6000086")]
			[Cpp2IlInjected.Address(RVA = "0xD11B00", Offset = "0xD10500", VA = "0x180D11B00")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000087")]
			[Cpp2IlInjected.Address(RVA = "0xD11960", Offset = "0xD10360", VA = "0x180D11960")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000031")]
		public List<ItemPurchaseMethodId> BonusItemIds
		{
			[Cpp2IlInjected.Token(Token = "0x6000088")]
			[Cpp2IlInjected.Address(RVA = "0xD11A20", Offset = "0xD10420", VA = "0x180D11A20")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000089")]
			[Cpp2IlInjected.Address(RVA = "0xD17350", Offset = "0xD15D50", VA = "0x180D17350")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000032")]
		public List<GrantableId> BonusSelectableGrantableIds
		{
			[Cpp2IlInjected.Token(Token = "0x600008A")]
			[Cpp2IlInjected.Address(RVA = "0xD12280", Offset = "0xD10C80", VA = "0x180D12280")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600008B")]
			[Cpp2IlInjected.Address(RVA = "0xD11B50", Offset = "0xD10550", VA = "0x180D11B50")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000033")]
		public int? GiftRecipientAccountId
		{
			[Cpp2IlInjected.Token(Token = "0x600008C")]
			[Cpp2IlInjected.Address(RVA = "0xD11A30", Offset = "0xD10430", VA = "0x180D11A30")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600008D")]
			[Cpp2IlInjected.Address(RVA = "0xFFBC20", Offset = "0xFFA620", VA = "0x180FFBC20")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000034")]
		public string GiftRecipientMessage
		{
			[Cpp2IlInjected.Token(Token = "0x600008E")]
			[Cpp2IlInjected.Address(RVA = "0xD122E0", Offset = "0xD10CE0", VA = "0x180D122E0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600008F")]
			[Cpp2IlInjected.Address(RVA = "0xD12290", Offset = "0xD10C90", VA = "0x180D12290")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000090")]
		[Cpp2IlInjected.Address(RVA = "0xD16C40", Offset = "0xD15640", VA = "0x180D16C40")]
		public ProcessPurchaseRequest()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000018")]
	[Utf8JsonSerializable]
	public class SKUConfigCollectionDTO
	{
		[Cpp2IlInjected.Token(Token = "0x17000035")]
		public int Version
		{
			[Cpp2IlInjected.Token(Token = "0x6000091")]
			[Cpp2IlInjected.Address(RVA = "0xD0F110", Offset = "0xD0DB10", VA = "0x180D0F110")]
			[CompilerGenerated]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x6000092")]
			[Cpp2IlInjected.Address(RVA = "0xD12F30", Offset = "0xD11930", VA = "0x180D12F30")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000036")]
		public List<SKUConfigDTO> SkuConfigs
		{
			[Cpp2IlInjected.Token(Token = "0x6000093")]
			[Cpp2IlInjected.Address(RVA = "0xD11B30", Offset = "0xD10530", VA = "0x180D11B30")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000094")]
			[Cpp2IlInjected.Address(RVA = "0xD12270", Offset = "0xD10C70", VA = "0x180D12270")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000037")]
		public Dictionary<string, string> StringReplacements
		{
			[Cpp2IlInjected.Token(Token = "0x6000095")]
			[Cpp2IlInjected.Address(RVA = "0xD12BC0", Offset = "0xD115C0", VA = "0x180D12BC0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000096")]
			[Cpp2IlInjected.Address(RVA = "0xD11520", Offset = "0xD0FF20", VA = "0x180D11520")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000097")]
		[Cpp2IlInjected.Address(RVA = "0x8DC4F80", Offset = "0x8DC3980", VA = "0x188DC4F80")]
		public SKUConfigCollectionDTO()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000019")]
	[Utf8JsonSerializable]
	public class SKUConfigDTO
	{
		[Cpp2IlInjected.Token(Token = "0x17000038")]
		public int SkuId
		{
			[Cpp2IlInjected.Token(Token = "0x6000098")]
			[Cpp2IlInjected.Address(RVA = "0xD0F110", Offset = "0xD0DB10", VA = "0x180D0F110")]
			[CompilerGenerated]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x6000099")]
			[Cpp2IlInjected.Address(RVA = "0xD12F30", Offset = "0xD11930", VA = "0x180D12F30")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000039")]
		public string Name
		{
			[Cpp2IlInjected.Token(Token = "0x600009A")]
			[Cpp2IlInjected.Address(RVA = "0xD11B30", Offset = "0xD10530", VA = "0x180D11B30")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600009B")]
			[Cpp2IlInjected.Address(RVA = "0xD12270", Offset = "0xD10C70", VA = "0x180D12270")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700003A")]
		public string Description
		{
			[Cpp2IlInjected.Token(Token = "0x600009C")]
			[Cpp2IlInjected.Address(RVA = "0xD12BC0", Offset = "0xD115C0", VA = "0x180D12BC0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600009D")]
			[Cpp2IlInjected.Address(RVA = "0xD11520", Offset = "0xD0FF20", VA = "0x180D11520")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700003B")]
		public string ThumbnailImageName
		{
			[Cpp2IlInjected.Token(Token = "0x600009E")]
			[Cpp2IlInjected.Address(RVA = "0xD11B00", Offset = "0xD10500", VA = "0x180D11B00")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600009F")]
			[Cpp2IlInjected.Address(RVA = "0xD11530", Offset = "0xD0FF30", VA = "0x180D11530")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700003C")]
		public string DetailsImageName
		{
			[Cpp2IlInjected.Token(Token = "0x60000A0")]
			[Cpp2IlInjected.Address(RVA = "0xD11A20", Offset = "0xD10420", VA = "0x180D11A20")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60000A1")]
			[Cpp2IlInjected.Address(RVA = "0xD17350", Offset = "0xD15D50", VA = "0x180D17350")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700003D")]
		public bool? ShowSkuDetails
		{
			[Cpp2IlInjected.Token(Token = "0x60000A2")]
			[Cpp2IlInjected.Address(RVA = "0x2581C70", Offset = "0x2580670", VA = "0x182581C70")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60000A3")]
			[Cpp2IlInjected.Address(RVA = "0x2581CD0", Offset = "0x25806D0", VA = "0x182581CD0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700003E")]
		public SKUFooterConfigDTO Footer
		{
			[Cpp2IlInjected.Token(Token = "0x60000A4")]
			[Cpp2IlInjected.Address(RVA = "0xD11A30", Offset = "0xD10430", VA = "0x180D11A30")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60000A5")]
			[Cpp2IlInjected.Address(RVA = "0xD12260", Offset = "0xD10C60", VA = "0x180D12260")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700003F")]
		public Dictionary<string, SKUDialogConfigDTO> DialogConfigs
		{
			[Cpp2IlInjected.Token(Token = "0x60000A6")]
			[Cpp2IlInjected.Address(RVA = "0xD122E0", Offset = "0xD10CE0", VA = "0x180D122E0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60000A7")]
			[Cpp2IlInjected.Address(RVA = "0xD12290", Offset = "0xD10C90", VA = "0x180D12290")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000A8")]
		[Cpp2IlInjected.Address(RVA = "0x8DC5000", Offset = "0x8DC3A00", VA = "0x188DC5000")]
		public SKUConfigDTO()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200001A")]
	[Utf8JsonSerializable]
	public class SKUFooterConfigDTO
	{
		[Cpp2IlInjected.Token(Token = "0x17000040")]
		public string Text
		{
			[Cpp2IlInjected.Token(Token = "0x60000A9")]
			[Cpp2IlInjected.Address(RVA = "0xD117B0", Offset = "0xD101B0", VA = "0x180D117B0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60000AA")]
			[Cpp2IlInjected.Address(RVA = "0xD117C0", Offset = "0xD101C0", VA = "0x180D117C0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000041")]
		public string ExternalUrl
		{
			[Cpp2IlInjected.Token(Token = "0x60000AB")]
			[Cpp2IlInjected.Address(RVA = "0xD11B30", Offset = "0xD10530", VA = "0x180D11B30")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60000AC")]
			[Cpp2IlInjected.Address(RVA = "0xD12270", Offset = "0xD10C70", VA = "0x180D12270")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000AD")]
		[Cpp2IlInjected.Address(RVA = "0xD16C40", Offset = "0xD15640", VA = "0x180D16C40")]
		public SKUFooterConfigDTO()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200001B")]
	[Utf8JsonSerializable]
	public class SKUDialogConfigDTO
	{
		[Cpp2IlInjected.Token(Token = "0x17000042")]
		public string Title
		{
			[Cpp2IlInjected.Token(Token = "0x60000AE")]
			[Cpp2IlInjected.Address(RVA = "0xD117B0", Offset = "0xD101B0", VA = "0x180D117B0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60000AF")]
			[Cpp2IlInjected.Address(RVA = "0xD117C0", Offset = "0xD101C0", VA = "0x180D117C0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000043")]
		public string Text
		{
			[Cpp2IlInjected.Token(Token = "0x60000B0")]
			[Cpp2IlInjected.Address(RVA = "0xD11B30", Offset = "0xD10530", VA = "0x180D11B30")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60000B1")]
			[Cpp2IlInjected.Address(RVA = "0xD12270", Offset = "0xD10C70", VA = "0x180D12270")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000044")]
		public string SpriteName
		{
			[Cpp2IlInjected.Token(Token = "0x60000B2")]
			[Cpp2IlInjected.Address(RVA = "0xD12BC0", Offset = "0xD115C0", VA = "0x180D12BC0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60000B3")]
			[Cpp2IlInjected.Address(RVA = "0xD11520", Offset = "0xD0FF20", VA = "0x180D11520")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000045")]
		public List<SKUButtonConfigDTO> Buttons
		{
			[Cpp2IlInjected.Token(Token = "0x60000B4")]
			[Cpp2IlInjected.Address(RVA = "0xD11B00", Offset = "0xD10500", VA = "0x180D11B00")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60000B5")]
			[Cpp2IlInjected.Address(RVA = "0xD11530", Offset = "0xD0FF30", VA = "0x180D11530")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000046")]
		public SKUFooterConfigDTO Footer
		{
			[Cpp2IlInjected.Token(Token = "0x60000B6")]
			[Cpp2IlInjected.Address(RVA = "0xD11A20", Offset = "0xD10420", VA = "0x180D11A20")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60000B7")]
			[Cpp2IlInjected.Address(RVA = "0xD17350", Offset = "0xD15D50", VA = "0x180D17350")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000047")]
		public long Cooldown
		{
			[Cpp2IlInjected.Token(Token = "0x60000B8")]
			[Cpp2IlInjected.Address(RVA = "0xD12280", Offset = "0xD10C80", VA = "0x180D12280")]
			[CompilerGenerated]
			get
			{
				return default(long);
			}
			[Cpp2IlInjected.Token(Token = "0x60000B9")]
			[Cpp2IlInjected.Address(RVA = "0xD1B6D0", Offset = "0xD1A0D0", VA = "0x180D1B6D0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000BA")]
		[Cpp2IlInjected.Address(RVA = "0x8DC5080", Offset = "0x8DC3A80", VA = "0x188DC5080")]
		public SKUDialogConfigDTO()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200001C")]
	public enum SKUButtonAction
	{
		[Cpp2IlInjected.Token(Token = "0x400003F")]
		DismissDialog,
		[Cpp2IlInjected.Token(Token = "0x4000040")]
		CloseWatch,
		[Cpp2IlInjected.Token(Token = "0x4000041")]
		GoToStore,
		[Cpp2IlInjected.Token(Token = "0x4000042")]
		GoToCreate,
		[Cpp2IlInjected.Token(Token = "0x4000043")]
		GoToDayPass,
		[Cpp2IlInjected.Token(Token = "0x4000044")]
		PositiveEvent,
		[Cpp2IlInjected.Token(Token = "0x4000045")]
		NegativeEvent,
		[Cpp2IlInjected.Token(Token = "0x4000046")]
		CancelEvent
	}
	[Cpp2IlInjected.Token(Token = "0x200001D")]
	[Utf8JsonSerializable]
	public class SKUButtonConfigDTO
	{
		[Cpp2IlInjected.Token(Token = "0x17000048")]
		public string Text
		{
			[Cpp2IlInjected.Token(Token = "0x60000BB")]
			[Cpp2IlInjected.Address(RVA = "0xD117B0", Offset = "0xD101B0", VA = "0x180D117B0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60000BC")]
			[Cpp2IlInjected.Address(RVA = "0xD117C0", Offset = "0xD101C0", VA = "0x180D117C0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000049")]
		public string Type
		{
			[Cpp2IlInjected.Token(Token = "0x60000BD")]
			[Cpp2IlInjected.Address(RVA = "0xD11B30", Offset = "0xD10530", VA = "0x180D11B30")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60000BE")]
			[Cpp2IlInjected.Address(RVA = "0xD12270", Offset = "0xD10C70", VA = "0x180D12270")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700004A")]
		public SKUButtonAction OnClick
		{
			[Cpp2IlInjected.Token(Token = "0x60000BF")]
			[Cpp2IlInjected.Address(RVA = "0xD215F0", Offset = "0xD1FFF0", VA = "0x180D215F0")]
			[CompilerGenerated]
			get
			{
				return default(SKUButtonAction);
			}
			[Cpp2IlInjected.Token(Token = "0x60000C0")]
			[Cpp2IlInjected.Address(RVA = "0xD682F0", Offset = "0xD66CF0", VA = "0x180D682F0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000C1")]
		[Cpp2IlInjected.Address(RVA = "0xD16C40", Offset = "0xD15640", VA = "0x180D16C40")]
		public SKUButtonConfigDTO()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200001E")]
	public readonly struct SubscriptionDetails : IEquatable<SubscriptionDetails>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004A")]
		private readonly bool isValid;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400004B")]
		public readonly DateTime ExpirationDateUtc;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400004C")]
		public readonly bool IsAutoRenewing;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x400004D")]
		public readonly PlatformType? PlatformType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400004E")]
		public readonly string PlatformId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400004F")]
		public readonly int? PlatformAccountSubscribedPlayerId;

		[Cpp2IlInjected.Token(Token = "0x1700004B")]
		public static SubscriptionDetails BCJQFYWWDXN
		{
			[Cpp2IlInjected.Token(Token = "0x60000C2")]
			[Cpp2IlInjected.Address(RVA = "0x2B41130", Offset = "0x2B3FB30", VA = "0x182B41130")]
			get
			{
				return default(SubscriptionDetails);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000C3")]
		[Cpp2IlInjected.Address(RVA = "0x8DC66C0", Offset = "0x8DC50C0", VA = "0x188DC66C0")]
		public SubscriptionDetails(DateTime expirationDateUtc, bool isAutoRenewing, PlatformType? platformType, string platformId, int? platformAccountSubscribedPlayerId)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C4")]
		[Cpp2IlInjected.Address(RVA = "0x8DC6230", Offset = "0x8DC4C30", VA = "0x188DC6230")]
		public SubscriptionStatus EIBPRWWCYZF(GBKKNLYTGEE a)
		{
			return default(SubscriptionStatus);
		}

		[Cpp2IlInjected.Token(Token = "0x60000C5")]
		[Cpp2IlInjected.Address(RVA = "0x8DC65A0", Offset = "0x8DC4FA0", VA = "0x188DC65A0")]
		private static SubscriptionStatus OMZZBVMBGQE(GBKKNLYTGEE a, DateTime b)
		{
			return default(SubscriptionStatus);
		}

		[Cpp2IlInjected.Token(Token = "0x60000C6")]
		[Cpp2IlInjected.Address(RVA = "0x8DC6360", Offset = "0x8DC4D60", VA = "0x188DC6360", Slot = "4")]
		public bool Equals(SubscriptionDetails other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000C7")]
		[Cpp2IlInjected.Address(RVA = "0x8DC62B0", Offset = "0x8DC4CB0", VA = "0x188DC62B0", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000C8")]
		[Cpp2IlInjected.Address(RVA = "0x8DC64C0", Offset = "0x8DC4EC0", VA = "0x188DC64C0", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[SpecialName]
		[Cpp2IlInjected.Token(Token = "0x60000C9")]
		[Cpp2IlInjected.Address(RVA = "0x8DC6570", Offset = "0x8DC4F70", VA = "0x188DC6570")]
		public static bool ITVTPRNZGNV(SubscriptionDetails a, SubscriptionDetails b)
		{
			return default(bool);
		}

		[SpecialName]
		[Cpp2IlInjected.Token(Token = "0x60000CA")]
		[Cpp2IlInjected.Address(RVA = "0x8DC61F0", Offset = "0x8DC4BF0", VA = "0x188DC61F0")]
		public static bool CYAUITUETAA(SubscriptionDetails a, SubscriptionDetails b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000CB")]
		[Cpp2IlInjected.Address(RVA = "0x8DC6610", Offset = "0x8DC5010", VA = "0x188DC6610", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200001F")]
	public readonly struct SubscriptionSnapshot : IEquatable<SubscriptionSnapshot>
	{
		[Cpp2IlInjected.Token(Token = "0x4000050")]
		public static readonly SubscriptionSnapshot None;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000051")]
		public readonly bool IsValid;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1")]
		[Cpp2IlInjected.Token(Token = "0x4000052")]
		public readonly SubscriptionStatus SubscriptionStatus;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000053")]
		public readonly SubscriptionDetails SubscriptionDetails;

		[Cpp2IlInjected.Token(Token = "0x60000CC")]
		[Cpp2IlInjected.Address(RVA = "0x8DC6CB0", Offset = "0x8DC56B0", VA = "0x188DC6CB0")]
		public SubscriptionSnapshot(SubscriptionStatus subscriptionStatus, SubscriptionDetails subscriptionDetails)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000CD")]
		[Cpp2IlInjected.Address(RVA = "0x8DC6820", Offset = "0x8DC5220", VA = "0x188DC6820", Slot = "4")]
		public bool Equals(SubscriptionSnapshot other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000CE")]
		[Cpp2IlInjected.Address(RVA = "0x8DC68D0", Offset = "0x8DC52D0", VA = "0x188DC68D0", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000CF")]
		[Cpp2IlInjected.Address(RVA = "0x8DC6A00", Offset = "0x8DC5400", VA = "0x188DC6A00", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[SpecialName]
		[Cpp2IlInjected.Token(Token = "0x60000D0")]
		[Cpp2IlInjected.Address(RVA = "0x8DC6AC0", Offset = "0x8DC54C0", VA = "0x188DC6AC0")]
		public static bool ITVTPRNZGNV(SubscriptionSnapshot a, SubscriptionSnapshot b)
		{
			return default(bool);
		}

		[SpecialName]
		[Cpp2IlInjected.Token(Token = "0x60000D1")]
		[Cpp2IlInjected.Address(RVA = "0x8DC6700", Offset = "0x8DC5100", VA = "0x188DC6700")]
		public static bool CYAUITUETAA(SubscriptionSnapshot a, SubscriptionSnapshot b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000D2")]
		[Cpp2IlInjected.Address(RVA = "0x8DC6BD0", Offset = "0x8DC55D0", VA = "0x188DC6BD0", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000020")]
	public enum SubscriptionStatus : byte
	{
		[Cpp2IlInjected.Token(Token = "0x4000055")]
		None,
		[Cpp2IlInjected.Token(Token = "0x4000056")]
		Expired,
		[Cpp2IlInjected.Token(Token = "0x4000057")]
		Active
	}
	[Cpp2IlInjected.Token(Token = "0x2000021")]
	public class YIEEVVVPNCC : GBKKNLYTGEE
	{
		[Cpp2IlInjected.Token(Token = "0x4000058")]
		public const string SUYJKEXIXNG = "ServerTime";

		[Cpp2IlInjected.Token(Token = "0x4000059")]
		private static readonly Stopwatch KNNBRGNNJYL;

		[Cpp2IlInjected.Token(Token = "0x400005A")]
		private static DateTimeOffset? NGRYFXWQTOT;

		[Cpp2IlInjected.Token(Token = "0x400005B")]
		private static readonly YIEEVVVPNCC OUAYFCUQLSG;

		[Cpp2IlInjected.Token(Token = "0x1700004C")]
		public static GBKKNLYTGEE GFQGJWBHKJM
		{
			[Cpp2IlInjected.Token(Token = "0x60000D4")]
			[Cpp2IlInjected.Address(RVA = "0x8DCAE80", Offset = "0x8DC9880", VA = "0x188DCAE80")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700004D")]
		internal static YIEEVVVPNCC KGGPXQXEIHB
		{
			[Cpp2IlInjected.Token(Token = "0x60000D5")]
			[Cpp2IlInjected.Address(RVA = "0x8DCB230", Offset = "0x8DC9C30", VA = "0x188DCB230")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700004E")]
		public static DateTimeOffset XJKRJDIMWBJ
		{
			[Cpp2IlInjected.Token(Token = "0x60000D6")]
			[Cpp2IlInjected.Address(RVA = "0x8DCAD20", Offset = "0x8DC9720", VA = "0x188DCAD20")]
			get
			{
				return default(DateTimeOffset);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700004F")]
		public static DateTime QCDHUDJATKI
		{
			[Cpp2IlInjected.Token(Token = "0x60000D7")]
			[Cpp2IlInjected.Address(RVA = "0x8DCB0E0", Offset = "0x8DC9AE0", VA = "0x188DCB0E0")]
			get
			{
				return default(DateTime);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000050")]
		public DateTime DQHEYASAGGX
		{
			[Cpp2IlInjected.Token(Token = "0x60000D8")]
			[Cpp2IlInjected.Address(RVA = "0x8DCB170", Offset = "0x8DC9B70", VA = "0x188DCB170", Slot = "4")]
			get
			{
				return default(DateTime);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000051")]
		public DateTimeOffset WSYGOKUSFFC
		{
			[Cpp2IlInjected.Token(Token = "0x60000D9")]
			[Cpp2IlInjected.Address(RVA = "0x8DCB280", Offset = "0x8DC9C80", VA = "0x188DCB280", Slot = "5")]
			get
			{
				return default(DateTimeOffset);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000DA")]
		[Cpp2IlInjected.Address(RVA = "0xD16C40", Offset = "0xD15640", VA = "0x180D16C40")]
		private YIEEVVVPNCC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000DB")]
		[Cpp2IlInjected.Address(RVA = "0x8DCAED0", Offset = "0x8DC98D0", VA = "0x188DCAED0")]
		internal static void SUTNTBXBEIY(DateTime? a)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000022")]
	public enum CustomAvatarItemPreviewOrientation
	{
		[Cpp2IlInjected.Token(Token = "0x400005D")]
		Front,
		[Cpp2IlInjected.Token(Token = "0x400005E")]
		Back
	}
	[Cpp2IlInjected.Token(Token = "0x2000023")]
	public enum CustomAvatarItemSource
	{
		[Cpp2IlInjected.Token(Token = "0x4000060")]
		AnimatedPuppet,
		[Cpp2IlInjected.Token(Token = "0x4000061")]
		Imposter
	}
	[Cpp2IlInjected.Token(Token = "0x2000024")]
	[Utf8JsonSerializable]
	public class CustomAvatarItem : CKAQAAOLPYF, MGOMCQBUHGC, QPSFFVWODNU, KSLCTVRDJTL
	{
		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x2000025")]
		[CompilerGenerated]
		private struct <OnDeserializedAsync>d__90 : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000078")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x4000079")]
			public AsyncTaskMethodBuilder <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400007A")]
			public CustomAvatarItem <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x400007B")]
			private ConfiguredTaskAwaitable<string>.ConfiguredTaskAwaiter <>u__1;

			[Cpp2IlInjected.Token(Token = "0x6000116")]
			[Cpp2IlInjected.Address(RVA = "0x8DC8760", Offset = "0x8DC7160", VA = "0x188DC8760", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000117")]
			[Cpp2IlInjected.Address(RVA = "0x8DC8B10", Offset = "0x8DC7510", VA = "0x188DC8B10", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000077")]
		[IgnoreDataMember]
		public static AEYGYTPBEBO RecNetPlatformAccess;

		[Cpp2IlInjected.Token(Token = "0x17000052")]
		public Guid CustomAvatarItemId
		{
			[Cpp2IlInjected.Token(Token = "0x60000DD")]
			[Cpp2IlInjected.Address(RVA = "0xF357F0", Offset = "0xF341F0", VA = "0x180F357F0", Slot = "37")]
			[CompilerGenerated]
			get
			{
				return default(Guid);
			}
			[Cpp2IlInjected.Token(Token = "0x60000DE")]
			[Cpp2IlInjected.Address(RVA = "0xF35810", Offset = "0xF34210", VA = "0x180F35810")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000053")]
		public int CreatorAccountId
		{
			[Cpp2IlInjected.Token(Token = "0x60000DF")]
			[Cpp2IlInjected.Address(RVA = "0xD215F0", Offset = "0xD1FFF0", VA = "0x180D215F0", Slot = "38")]
			[CompilerGenerated]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x60000E0")]
			[Cpp2IlInjected.Address(RVA = "0xD682F0", Offset = "0xD66CF0", VA = "0x180D682F0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000054")]
		public string Name
		{
			[Cpp2IlInjected.Token(Token = "0x60000E1")]
			[Cpp2IlInjected.Address(RVA = "0xD11B00", Offset = "0xD10500", VA = "0x180D11B00", Slot = "39")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60000E2")]
			[Cpp2IlInjected.Address(RVA = "0xD11530", Offset = "0xD0FF30", VA = "0x180D11530")]
			[CompilerGenerated]
			internal set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000055")]
		public string Description
		{
			[Cpp2IlInjected.Token(Token = "0x60000E3")]
			[Cpp2IlInjected.Address(RVA = "0xD11A20", Offset = "0xD10420", VA = "0x180D11A20", Slot = "40")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60000E4")]
			[Cpp2IlInjected.Address(RVA = "0xD17350", Offset = "0xD15D50", VA = "0x180D17350")]
			[CompilerGenerated]
			internal set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000056")]
		public int Price
		{
			[Cpp2IlInjected.Token(Token = "0x60000E5")]
			[Cpp2IlInjected.Address(RVA = "0xD40260", Offset = "0xD3EC60", VA = "0x180D40260", Slot = "8")]
			[CompilerGenerated]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x60000E6")]
			[Cpp2IlInjected.Address(RVA = "0xE27B10", Offset = "0xE26510", VA = "0x180E27B10")]
			[CompilerGenerated]
			internal set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000057")]
		public UgcAccessibility Accessibility
		{
			[Cpp2IlInjected.Token(Token = "0x60000E7")]
			[Cpp2IlInjected.Address(RVA = "0xD50990", Offset = "0xD4F390", VA = "0x180D50990", Slot = "44")]
			[CompilerGenerated]
			get
			{
				return default(UgcAccessibility);
			}
			[Cpp2IlInjected.Token(Token = "0x60000E8")]
			[Cpp2IlInjected.Address(RVA = "0xD506C0", Offset = "0xD4F0C0", VA = "0x180D506C0")]
			[CompilerGenerated]
			internal set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000058")]
		public bool ForceCannotPublish
		{
			[Cpp2IlInjected.Token(Token = "0x60000E9")]
			[Cpp2IlInjected.Address(RVA = "0xF85FC0", Offset = "0xF849C0", VA = "0x180F85FC0", Slot = "10")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x60000EA")]
			[Cpp2IlInjected.Address(RVA = "0xF85920", Offset = "0xF84320", VA = "0x180F85920")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000059")]
		public bool IsFeatured
		{
			[Cpp2IlInjected.Token(Token = "0x60000EB")]
			[Cpp2IlInjected.Address(RVA = "0x15DB190", Offset = "0x15D9B90", VA = "0x1815DB190", Slot = "28")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x60000EC")]
			[Cpp2IlInjected.Address(RVA = "0x15DAAC0", Offset = "0x15D94C0", VA = "0x1815DAAC0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700005A")]
		public bool IsRecRoomApproved
		{
			[Cpp2IlInjected.Token(Token = "0x60000ED")]
			[Cpp2IlInjected.Address(RVA = "0x8DBF270", Offset = "0x8DBDC70", VA = "0x188DBF270", Slot = "41")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x60000EE")]
			[Cpp2IlInjected.Address(RVA = "0x2167030", Offset = "0x2165A30", VA = "0x182167030")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700005B")]
		public int? BaseAvatarItemId
		{
			[Cpp2IlInjected.Token(Token = "0x60000EF")]
			[Cpp2IlInjected.Address(RVA = "0x5C9F5F0", Offset = "0x5C9DFF0", VA = "0x185C9F5F0", Slot = "43")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60000F0")]
			[Cpp2IlInjected.Address(RVA = "0x8DBF280", Offset = "0x8DBDC80", VA = "0x188DBF280", Slot = "14")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700005C")]
		public string BaseAvatarItemColor
		{
			[Cpp2IlInjected.Token(Token = "0x60000F1")]
			[Cpp2IlInjected.Address(RVA = "0xD11B20", Offset = "0xD10520", VA = "0x180D11B20", Slot = "15")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60000F2")]
			[Cpp2IlInjected.Address(RVA = "0xD11900", Offset = "0xD10300", VA = "0x180D11900")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700005D")]
		public string DesignFilename
		{
			[Cpp2IlInjected.Token(Token = "0x60000F3")]
			[Cpp2IlInjected.Address(RVA = "0xD11940", Offset = "0xD10340", VA = "0x180D11940", Slot = "16")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60000F4")]
			[Cpp2IlInjected.Address(RVA = "0xD122A0", Offset = "0xD10CA0", VA = "0x180D122A0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700005E")]
		public string ThumbnailImageFilename
		{
			[Cpp2IlInjected.Token(Token = "0x60000F5")]
			[Cpp2IlInjected.Address(RVA = "0xD15610", Offset = "0xD14010", VA = "0x180D15610", Slot = "27")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60000F6")]
			[Cpp2IlInjected.Address(RVA = "0xD15600", Offset = "0xD14000", VA = "0x180D15600")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700005F")]
		public DateTime CreatedAt
		{
			[Cpp2IlInjected.Token(Token = "0x60000F7")]
			[Cpp2IlInjected.Address(RVA = "0xD11B40", Offset = "0xD10540", VA = "0x180D11B40", Slot = "18")]
			[CompilerGenerated]
			get
			{
				return default(DateTime);
			}
			[Cpp2IlInjected.Token(Token = "0x60000F8")]
			[Cpp2IlInjected.Address(RVA = "0x1016E40", Offset = "0x1015840", VA = "0x181016E40")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000060")]
		public DateTime ModifiedAt
		{
			[Cpp2IlInjected.Token(Token = "0x60000F9")]
			[Cpp2IlInjected.Address(RVA = "0xD11B60", Offset = "0xD10560", VA = "0x180D11B60", Slot = "19")]
			[CompilerGenerated]
			get
			{
				return default(DateTime);
			}
			[Cpp2IlInjected.Token(Token = "0x60000FA")]
			[Cpp2IlInjected.Address(RVA = "0x1016DA0", Offset = "0x10157A0", VA = "0x181016DA0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000061")]
		public CustomAvatarItemPreviewOrientation PreviewOrientation
		{
			[Cpp2IlInjected.Token(Token = "0x60000FB")]
			[Cpp2IlInjected.Address(RVA = "0xD37350", Offset = "0xD35D50", VA = "0x180D37350", Slot = "20")]
			[CompilerGenerated]
			get
			{
				return default(CustomAvatarItemPreviewOrientation);
			}
			[Cpp2IlInjected.Token(Token = "0x60000FC")]
			[Cpp2IlInjected.Address(RVA = "0x164B040", Offset = "0x1649A40", VA = "0x18164B040")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000062")]
		public string RankingContext
		{
			[Cpp2IlInjected.Token(Token = "0x60000FD")]
			[Cpp2IlInjected.Address(RVA = "0xD1E850", Offset = "0xD1D250", VA = "0x180D1E850", Slot = "21")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60000FE")]
			[Cpp2IlInjected.Address(RVA = "0xD1E840", Offset = "0xD1D240", VA = "0x180D1E840")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000063")]
		public int OutfitType
		{
			[Cpp2IlInjected.Token(Token = "0x60000FF")]
			[Cpp2IlInjected.Address(RVA = "0xDAA0E0", Offset = "0xDA8AE0", VA = "0x180DAA0E0", Slot = "42")]
			[CompilerGenerated]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x6000100")]
			[Cpp2IlInjected.Address(RVA = "0x166CE80", Offset = "0x166B880", VA = "0x18166CE80")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000064")]
		public IReadOnlyList<CustomAvatarItemTagDTO> Tags
		{
			[Cpp2IlInjected.Token(Token = "0x6000101")]
			[Cpp2IlInjected.Address(RVA = "0xD3FEF0", Offset = "0xD3E8F0", VA = "0x180D3FEF0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000102")]
			[Cpp2IlInjected.Address(RVA = "0xFCC250", Offset = "0xFCAC50", VA = "0x180FCC250")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000065")]
		public IReadOnlyList<CustomAvatarItemSaveDTO> CurrentSaves
		{
			[Cpp2IlInjected.Token(Token = "0x6000103")]
			[Cpp2IlInjected.Address(RVA = "0xD1E7D0", Offset = "0xD1D1D0", VA = "0x180D1E7D0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000104")]
			[Cpp2IlInjected.Address(RVA = "0xD1E860", Offset = "0xD1D260", VA = "0x180D1E860")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000066")]
		public IReadOnlyList<FAEJBLUXTOM> Saves
		{
			[Cpp2IlInjected.Token(Token = "0x6000105")]
			[Cpp2IlInjected.Address(RVA = "0xD1E7D0", Offset = "0xD1D1D0", VA = "0x180D1E7D0", Slot = "36")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000067")]
		public ItemPurchaseInfoDTO PurchaseInfo
		{
			[Cpp2IlInjected.Token(Token = "0x6000106")]
			[Cpp2IlInjected.Address(RVA = "0xDE3320", Offset = "0xDE1D20", VA = "0x180DE3320")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000107")]
			[Cpp2IlInjected.Address(RVA = "0xEA1370", Offset = "0xE9FD70", VA = "0x180EA1370")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000068")]
		public string RankedEntityId
		{
			[Cpp2IlInjected.Token(Token = "0x6000108")]
			[Cpp2IlInjected.Address(RVA = "0x8DBF250", Offset = "0x8DBDC50", VA = "0x188DBF250", Slot = "23")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000069")]
		public UnifiedItemType ItemType
		{
			[Cpp2IlInjected.Token(Token = "0x600010D")]
			[Cpp2IlInjected.Address(RVA = "0xD7C720", Offset = "0xD7B120", VA = "0x180D7C720", Slot = "24")]
			get
			{
				return default(UnifiedItemType);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700006A")]
		public string Id
		{
			[Cpp2IlInjected.Token(Token = "0x600010E")]
			[Cpp2IlInjected.Address(RVA = "0x8DBF250", Offset = "0x8DBDC50", VA = "0x188DBF250", Slot = "25")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700006B")]
		public string FriendlyName
		{
			[Cpp2IlInjected.Token(Token = "0x600010F")]
			[Cpp2IlInjected.Address(RVA = "0xD11B00", Offset = "0xD10500", VA = "0x180D11B00", Slot = "26")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700006C")]
		public bool SubscribersOnly
		{
			[Cpp2IlInjected.Token(Token = "0x6000110")]
			[Cpp2IlInjected.Address(RVA = "0xD5AE10", Offset = "0xD59810", VA = "0x180D5AE10", Slot = "29")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700006D")]
		public GiftRarity Rarity
		{
			[Cpp2IlInjected.Token(Token = "0x6000111")]
			[Cpp2IlInjected.Address(RVA = "0xD60D10", Offset = "0xD5F710", VA = "0x180D60D10", Slot = "30")]
			get
			{
				return default(GiftRarity);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700006E")]
		public string ConsumableItemDesc
		{
			[Cpp2IlInjected.Token(Token = "0x6000112")]
			[Cpp2IlInjected.Address(RVA = "0xD10160", Offset = "0xD0EB60", VA = "0x180D10160", Slot = "31")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700006F")]
		public AvatarItemType? AvatarItemType
		{
			[Cpp2IlInjected.Token(Token = "0x6000113")]
			[Cpp2IlInjected.Address(RVA = "0x8DBF200", Offset = "0x8DBDC00", VA = "0x188DBF200", Slot = "32")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000070")]
		public GiftBoxContents GiftBoxContent
		{
			[Cpp2IlInjected.Token(Token = "0x6000114")]
			[Cpp2IlInjected.Address(RVA = "0xD7C720", Offset = "0xD7B120", VA = "0x180D7C720", Slot = "33")]
			get
			{
				return default(GiftBoxContents);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000071")]
		public bool IsQueryGiftDrop
		{
			[Cpp2IlInjected.Token(Token = "0x6000115")]
			[Cpp2IlInjected.Address(RVA = "0xD5AE10", Offset = "0xD59810", VA = "0x180D5AE10", Slot = "34")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000109")]
		[Cpp2IlInjected.Address(RVA = "0xD16C40", Offset = "0xD15640", VA = "0x180D16C40")]
		public CustomAvatarItem()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600010A")]
		[Cpp2IlInjected.Address(RVA = "0x8DBF0B0", Offset = "0x8DBDAB0", VA = "0x188DBF0B0")]
		public static CustomAvatarItem ISTGWTPRAQO(Guid a, [Optional] string b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600010B")]
		[Cpp2IlInjected.Address(RVA = "0x8DBF130", Offset = "0x8DBDB30", VA = "0x188DBF130", Slot = "35")]
		[AsyncStateMachine(typeof(<OnDeserializedAsync>d__90))]
		public Task NLARVXFWNGH()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600010C")]
		[Cpp2IlInjected.Address(RVA = "0x8DBF040", Offset = "0x8DBDA40", VA = "0x188DBF040")]
		public CustomAvatarItem Copy()
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000026")]
	[Utf8JsonSerializable]
	public class CustomAvatarItemCreateRequest
	{
		[Cpp2IlInjected.Token(Token = "0x17000072")]
		public string Name
		{
			[Cpp2IlInjected.Token(Token = "0x6000118")]
			[Cpp2IlInjected.Address(RVA = "0xD117B0", Offset = "0xD101B0", VA = "0x180D117B0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000119")]
			[Cpp2IlInjected.Address(RVA = "0xD117C0", Offset = "0xD101C0", VA = "0x180D117C0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000073")]
		public string Description
		{
			[Cpp2IlInjected.Token(Token = "0x600011A")]
			[Cpp2IlInjected.Address(RVA = "0xD11B30", Offset = "0xD10530", VA = "0x180D11B30")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600011B")]
			[Cpp2IlInjected.Address(RVA = "0xD12270", Offset = "0xD10C70", VA = "0x180D12270")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000074")]
		public int Price
		{
			[Cpp2IlInjected.Token(Token = "0x600011C")]
			[Cpp2IlInjected.Address(RVA = "0xD215F0", Offset = "0xD1FFF0", VA = "0x180D215F0")]
			[CompilerGenerated]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x600011D")]
			[Cpp2IlInjected.Address(RVA = "0xD682F0", Offset = "0xD66CF0", VA = "0x180D682F0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000075")]
		public int? BaseAvatarItemId
		{
			[Cpp2IlInjected.Token(Token = "0x600011E")]
			[Cpp2IlInjected.Address(RVA = "0x141BB60", Offset = "0x141A560", VA = "0x18141BB60")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600011F")]
			[Cpp2IlInjected.Address(RVA = "0x10CE4D0", Offset = "0x10CCED0", VA = "0x1810CE4D0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000076")]
		public string BaseAvatarItemColor
		{
			[Cpp2IlInjected.Token(Token = "0x6000120")]
			[Cpp2IlInjected.Address(RVA = "0xD11A20", Offset = "0xD10420", VA = "0x180D11A20")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000121")]
			[Cpp2IlInjected.Address(RVA = "0xD17350", Offset = "0xD15D50", VA = "0x180D17350")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000077")]
		public UgcAccessibility Accessibility
		{
			[Cpp2IlInjected.Token(Token = "0x6000122")]
			[Cpp2IlInjected.Address(RVA = "0xD40260", Offset = "0xD3EC60", VA = "0x180D40260")]
			[CompilerGenerated]
			get
			{
				return default(UgcAccessibility);
			}
			[Cpp2IlInjected.Token(Token = "0x6000123")]
			[Cpp2IlInjected.Address(RVA = "0xE27B10", Offset = "0xE26510", VA = "0x180E27B10")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000078")]
		public CustomAvatarItemPreviewOrientation? PreviewOrientation
		{
			[Cpp2IlInjected.Token(Token = "0x6000124")]
			[Cpp2IlInjected.Address(RVA = "0xD5EB70", Offset = "0xD5D570", VA = "0x180D5EB70")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000125")]
			[Cpp2IlInjected.Address(RVA = "0xD5EB80", Offset = "0xD5D580", VA = "0x180D5EB80")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000126")]
		[Cpp2IlInjected.Address(RVA = "0xD16C40", Offset = "0xD15640", VA = "0x180D16C40")]
		public CustomAvatarItemCreateRequest()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000027")]
	[Utf8JsonSerializable]
	public class CustomAvatarItemDesign
	{
		[Cpp2IlInjected.Token(Token = "0x17000079")]
		public int CreatorAccountId
		{
			[Cpp2IlInjected.Token(Token = "0x6000127")]
			[Cpp2IlInjected.Address(RVA = "0xD0F110", Offset = "0xD0DB10", VA = "0x180D0F110")]
			[CompilerGenerated]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x6000128")]
			[Cpp2IlInjected.Address(RVA = "0xD12F30", Offset = "0xD11930", VA = "0x180D12F30")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700007A")]
		public int? BaseAvatarItemId
		{
			[Cpp2IlInjected.Token(Token = "0x6000129")]
			[Cpp2IlInjected.Address(RVA = "0x141BB20", Offset = "0x141A520", VA = "0x18141BB20")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600012A")]
			[Cpp2IlInjected.Address(RVA = "0x141E140", Offset = "0x141CB40", VA = "0x18141E140")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700007B")]
		public string DesignFilename
		{
			[Cpp2IlInjected.Token(Token = "0x600012B")]
			[Cpp2IlInjected.Address(RVA = "0xD12BC0", Offset = "0xD115C0", VA = "0x180D12BC0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600012C")]
			[Cpp2IlInjected.Address(RVA = "0xD11520", Offset = "0xD0FF20", VA = "0x180D11520")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700007C")]
		public string BaseAvatarItemColor
		{
			[Cpp2IlInjected.Token(Token = "0x600012D")]
			[Cpp2IlInjected.Address(RVA = "0xD11B00", Offset = "0xD10500", VA = "0x180D11B00")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600012E")]
			[Cpp2IlInjected.Address(RVA = "0xD11530", Offset = "0xD0FF30", VA = "0x180D11530")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600012F")]
		[Cpp2IlInjected.Address(RVA = "0xD16C40", Offset = "0xD15640", VA = "0x180D16C40")]
		public CustomAvatarItemDesign()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000028")]
	[Utf8JsonSerializable]
	public class CustomAvatarItemDesignRequest
	{
		[Cpp2IlInjected.Token(Token = "0x1700007D")]
		public int? BaseAvatarItemId
		{
			[Cpp2IlInjected.Token(Token = "0x6000130")]
			[Cpp2IlInjected.Address(RVA = "0xD117B0", Offset = "0xD101B0", VA = "0x180D117B0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000131")]
			[Cpp2IlInjected.Address(RVA = "0xED90B0", Offset = "0xED7AB0", VA = "0x180ED90B0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700007E")]
		public string BaseAvatarItemColor
		{
			[Cpp2IlInjected.Token(Token = "0x6000132")]
			[Cpp2IlInjected.Address(RVA = "0xD11B30", Offset = "0xD10530", VA = "0x180D11B30")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000133")]
			[Cpp2IlInjected.Address(RVA = "0xD12270", Offset = "0xD10C70", VA = "0x180D12270")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000134")]
		[Cpp2IlInjected.Address(RVA = "0xD16C40", Offset = "0xD15640", VA = "0x180D16C40")]
		public CustomAvatarItemDesignRequest()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000029")]
	public struct CustomAvatarItemPricingConfig
	{
		[Cpp2IlInjected.Token(Token = "0x4000089")]
		public static int DEFAULT_MIN_TOKEN_PRICE;

		[Cpp2IlInjected.Token(Token = "0x400008A")]
		public static int DEFAULT_MAX_TOKEN_PRICE;

		[Cpp2IlInjected.Token(Token = "0x1700007F")]
		public int MinimumPrice
		{
			[Cpp2IlInjected.Token(Token = "0x6000135")]
			[Cpp2IlInjected.Address(RVA = "0xF86CD0", Offset = "0xF856D0", VA = "0x180F86CD0")]
			[CompilerGenerated]
			readonly get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x6000136")]
			[Cpp2IlInjected.Address(RVA = "0x15E9000", Offset = "0x15E7A00", VA = "0x1815E9000")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000080")]
		public int MaximumPrice
		{
			[Cpp2IlInjected.Token(Token = "0x6000137")]
			[Cpp2IlInjected.Address(RVA = "0x30F6F50", Offset = "0x30F5950", VA = "0x1830F6F50")]
			[CompilerGenerated]
			readonly get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x6000138")]
			[Cpp2IlInjected.Address(RVA = "0x30F6F60", Offset = "0x30F5960", VA = "0x1830F6F60")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000081")]
		public static CustomAvatarItemPricingConfig DOFDCVCRMAS
		{
			[Cpp2IlInjected.Token(Token = "0x600013A")]
			[Cpp2IlInjected.Address(RVA = "0x8DBED40", Offset = "0x8DBD740", VA = "0x188DBED40")]
			get
			{
				return default(CustomAvatarItemPricingConfig);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000139")]
		[Cpp2IlInjected.Address(RVA = "0x8DBEDF0", Offset = "0x8DBD7F0", VA = "0x188DBEDF0")]
		public CustomAvatarItemPricingConfig(int minimumTokenPrice, int maximumTokenPrice)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200002A")]
	[Utf8JsonSerializable]
	public class CustomAvatarItemPricingConfigDTO
	{
		[Cpp2IlInjected.Token(Token = "0x17000082")]
		public int MinimumPriceInTokens
		{
			[Cpp2IlInjected.Token(Token = "0x600013C")]
			[Cpp2IlInjected.Address(RVA = "0xD0F110", Offset = "0xD0DB10", VA = "0x180D0F110")]
			[CompilerGenerated]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x600013D")]
			[Cpp2IlInjected.Address(RVA = "0xD12F30", Offset = "0xD11930", VA = "0x180D12F30")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000083")]
		public int MaximumPriceInTokens
		{
			[Cpp2IlInjected.Token(Token = "0x600013E")]
			[Cpp2IlInjected.Address(RVA = "0xE073A0", Offset = "0xE05DA0", VA = "0x180E073A0")]
			[CompilerGenerated]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x600013F")]
			[Cpp2IlInjected.Address(RVA = "0xE073B0", Offset = "0xE05DB0", VA = "0x180E073B0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000140")]
		[Cpp2IlInjected.Address(RVA = "0xD16C40", Offset = "0xD15640", VA = "0x180D16C40")]
		public CustomAvatarItemPricingConfigDTO()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200002B")]
	[Utf8JsonSerializable]
	public class CustomAvatarItemPurchaseRequest
	{
		[Cpp2IlInjected.Token(Token = "0x17000084")]
		public int RequestedPrice
		{
			[Cpp2IlInjected.Token(Token = "0x6000141")]
			[Cpp2IlInjected.Address(RVA = "0xD0F110", Offset = "0xD0DB10", VA = "0x180D0F110")]
			[CompilerGenerated]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x6000142")]
			[Cpp2IlInjected.Address(RVA = "0xD12F30", Offset = "0xD11930", VA = "0x180D12F30")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000085")]
		public int? RecipientAccountId
		{
			[Cpp2IlInjected.Token(Token = "0x6000143")]
			[Cpp2IlInjected.Address(RVA = "0x141BB20", Offset = "0x141A520", VA = "0x18141BB20")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000144")]
			[Cpp2IlInjected.Address(RVA = "0x141E140", Offset = "0x141CB40", VA = "0x18141E140")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000086")]
		public string? Message
		{
			[Cpp2IlInjected.Token(Token = "0x6000145")]
			[Cpp2IlInjected.Address(RVA = "0xD12BC0", Offset = "0xD115C0", VA = "0x180D12BC0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000146")]
			[Cpp2IlInjected.Address(RVA = "0xD11520", Offset = "0xD0FF20", VA = "0x180D11520")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000147")]
		[Cpp2IlInjected.Address(RVA = "0x8DBEE50", Offset = "0x8DBD850", VA = "0x188DBEE50")]
		public CustomAvatarItemPurchaseRequest(int requestedPrice, int? recipientAccountId, string? message)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000148")]
		[Cpp2IlInjected.Address(RVA = "0xD16C40", Offset = "0xD15640", VA = "0x180D16C40")]
		public CustomAvatarItemPurchaseRequest()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200002C")]
	[Utf8JsonSerializable]
	public class CustomAvatarItemReportRequest
	{
		[Cpp2IlInjected.Token(Token = "0x17000087")]
		public QKVOMOTJVBD.UgcReportCategory ReportCategory
		{
			[Cpp2IlInjected.Token(Token = "0x6000149")]
			[Cpp2IlInjected.Address(RVA = "0xD0F110", Offset = "0xD0DB10", VA = "0x180D0F110")]
			[CompilerGenerated]
			get
			{
				return default(QKVOMOTJVBD.UgcReportCategory);
			}
			[Cpp2IlInjected.Token(Token = "0x600014A")]
			[Cpp2IlInjected.Address(RVA = "0xD12F30", Offset = "0xD11930", VA = "0x180D12F30")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000088")]
		public string Details
		{
			[Cpp2IlInjected.Token(Token = "0x600014B")]
			[Cpp2IlInjected.Address(RVA = "0xD11B30", Offset = "0xD10530", VA = "0x180D11B30")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600014C")]
			[Cpp2IlInjected.Address(RVA = "0xD12270", Offset = "0xD10C70", VA = "0x180D12270")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000089")]
		public int? ReportedPlayerId
		{
			[Cpp2IlInjected.Token(Token = "0x600014D")]
			[Cpp2IlInjected.Address(RVA = "0xD12BC0", Offset = "0xD115C0", VA = "0x180D12BC0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600014E")]
			[Cpp2IlInjected.Address(RVA = "0xE3F130", Offset = "0xE3DB30", VA = "0x180E3F130")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600014F")]
		[Cpp2IlInjected.Address(RVA = "0xD16C40", Offset = "0xD15640", VA = "0x180D16C40")]
		public CustomAvatarItemReportRequest()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200002D")]
	public interface FAEJBLUXTOM
	{
		[Cpp2IlInjected.Token(Token = "0x1700008A")]
		long CustomAvatarItemSaveId
		{
			[Cpp2IlInjected.Token(Token = "0x6000151")]
			[Cpp2IlInjected.Address(Slot = "1")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x1700008B")]
		Guid CustomAvatarItemId
		{
			[Cpp2IlInjected.Token(Token = "0x6000152")]
			[Cpp2IlInjected.Address(Slot = "2")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x1700008C")]
		Guid UnityAssetId
		{
			[Cpp2IlInjected.Token(Token = "0x6000153")]
			[Cpp2IlInjected.Address(Slot = "3")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x1700008D")]
		string ThumbnailFileName
		{
			[Cpp2IlInjected.Token(Token = "0x6000154")]
			[Cpp2IlInjected.Address(Slot = "4")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x1700008E")]
		string AdditionalConfiguration
		{
			[Cpp2IlInjected.Token(Token = "0x6000155")]
			[Cpp2IlInjected.Address(Slot = "5")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x1700008F")]
		int BodyType
		{
			[Cpp2IlInjected.Token(Token = "0x6000156")]
			[Cpp2IlInjected.Address(Slot = "6")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000090")]
		string UnityAsset
		{
			[Cpp2IlInjected.Token(Token = "0x6000157")]
			[Cpp2IlInjected.Address(Slot = "7")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000091")]
		string UnityAssetHash
		{
			[Cpp2IlInjected.Token(Token = "0x6000158")]
			[Cpp2IlInjected.Address(Slot = "8")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000092")]
		string UnityAsset2
		{
			[Cpp2IlInjected.Token(Token = "0x6000159")]
			[Cpp2IlInjected.Address(Slot = "9")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000093")]
		string UnityAsset2Hash
		{
			[Cpp2IlInjected.Token(Token = "0x600015A")]
			[Cpp2IlInjected.Address(Slot = "10")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000094")]
		int OutfitType
		{
			[Cpp2IlInjected.Token(Token = "0x600015B")]
			[Cpp2IlInjected.Address(Slot = "11")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x6000150")]
		[Cpp2IlInjected.Address(Slot = "0")]
		FAEJBLUXTOM Clone([Optional] int? bodyTypeOverride);
	}
	[Cpp2IlInjected.Token(Token = "0x200002E")]
	[Utf8JsonSerializable]
	public class CustomAvatarItemSaveDTO : FAEJBLUXTOM
	{
		[Cpp2IlInjected.Token(Token = "0x17000095")]
		public long CustomAvatarItemSaveId
		{
			[Cpp2IlInjected.Token(Token = "0x600015C")]
			[Cpp2IlInjected.Address(RVA = "0xD117B0", Offset = "0xD101B0", VA = "0x180D117B0", Slot = "5")]
			[CompilerGenerated]
			get
			{
				return default(long);
			}
			[Cpp2IlInjected.Token(Token = "0x600015D")]
			[Cpp2IlInjected.Address(RVA = "0xED90B0", Offset = "0xED7AB0", VA = "0x180ED90B0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000096")]
		public Guid CustomAvatarItemId
		{
			[Cpp2IlInjected.Token(Token = "0x600015E")]
			[Cpp2IlInjected.Address(RVA = "0xDA5E80", Offset = "0xDA4880", VA = "0x180DA5E80", Slot = "6")]
			[CompilerGenerated]
			get
			{
				return default(Guid);
			}
			[Cpp2IlInjected.Token(Token = "0x600015F")]
			[Cpp2IlInjected.Address(RVA = "0xF82330", Offset = "0xF80D30", VA = "0x180F82330")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000097")]
		public Guid UnityAssetId
		{
			[Cpp2IlInjected.Token(Token = "0x6000160")]
			[Cpp2IlInjected.Address(RVA = "0x104E620", Offset = "0x104D020", VA = "0x18104E620", Slot = "7")]
			[CompilerGenerated]
			get
			{
				return default(Guid);
			}
			[Cpp2IlInjected.Token(Token = "0x6000161")]
			[Cpp2IlInjected.Address(RVA = "0x104DCA0", Offset = "0x104C6A0", VA = "0x18104DCA0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000098")]
		public DateTime CreatedAt
		{
			[Cpp2IlInjected.Token(Token = "0x6000162")]
			[Cpp2IlInjected.Address(RVA = "0xD12280", Offset = "0xD10C80", VA = "0x180D12280")]
			[CompilerGenerated]
			get
			{
				return default(DateTime);
			}
			[Cpp2IlInjected.Token(Token = "0x6000163")]
			[Cpp2IlInjected.Address(RVA = "0xD1B6D0", Offset = "0xD1A0D0", VA = "0x180D1B6D0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000099")]
		public string ThumbnailFileName
		{
			[Cpp2IlInjected.Token(Token = "0x6000164")]
			[Cpp2IlInjected.Address(RVA = "0xD11A30", Offset = "0xD10430", VA = "0x180D11A30", Slot = "8")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000165")]
			[Cpp2IlInjected.Address(RVA = "0xD12260", Offset = "0xD10C60", VA = "0x180D12260")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700009A")]
		public string AdditionalConfiguration
		{
			[Cpp2IlInjected.Token(Token = "0x6000166")]
			[Cpp2IlInjected.Address(RVA = "0xD122E0", Offset = "0xD10CE0", VA = "0x180D122E0", Slot = "9")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000167")]
			[Cpp2IlInjected.Address(RVA = "0xD12290", Offset = "0xD10C90", VA = "0x180D12290")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700009B")]
		public int BodyType
		{
			[Cpp2IlInjected.Token(Token = "0x6000168")]
			[Cpp2IlInjected.Address(RVA = "0xF01E60", Offset = "0xF00860", VA = "0x180F01E60", Slot = "10")]
			[CompilerGenerated]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x6000169")]
			[Cpp2IlInjected.Address(RVA = "0x1ADB800", Offset = "0x1ADA200", VA = "0x181ADB800")]
			[CompilerGenerated]
			internal set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700009C")]
		public string UnityAsset
		{
			[Cpp2IlInjected.Token(Token = "0x600016A")]
			[Cpp2IlInjected.Address(RVA = "0xD11940", Offset = "0xD10340", VA = "0x180D11940", Slot = "11")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600016B")]
			[Cpp2IlInjected.Address(RVA = "0xD122A0", Offset = "0xD10CA0", VA = "0x180D122A0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700009D")]
		public string UnityAssetHash
		{
			[Cpp2IlInjected.Token(Token = "0x600016C")]
			[Cpp2IlInjected.Address(RVA = "0xD15610", Offset = "0xD14010", VA = "0x180D15610", Slot = "12")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600016D")]
			[Cpp2IlInjected.Address(RVA = "0xD15600", Offset = "0xD14000", VA = "0x180D15600")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700009E")]
		public string UnityAsset2
		{
			[Cpp2IlInjected.Token(Token = "0x600016E")]
			[Cpp2IlInjected.Address(RVA = "0xD11B40", Offset = "0xD10540", VA = "0x180D11B40", Slot = "13")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600016F")]
			[Cpp2IlInjected.Address(RVA = "0xD11910", Offset = "0xD10310", VA = "0x180D11910")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700009F")]
		public string UnityAsset2Hash
		{
			[Cpp2IlInjected.Token(Token = "0x6000170")]
			[Cpp2IlInjected.Address(RVA = "0xD11B60", Offset = "0xD10560", VA = "0x180D11B60", Slot = "14")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000171")]
			[Cpp2IlInjected.Address(RVA = "0xD11AE0", Offset = "0xD104E0", VA = "0x180D11AE0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000A0")]
		public int OutfitType
		{
			[Cpp2IlInjected.Token(Token = "0x6000172")]
			[Cpp2IlInjected.Address(RVA = "0xD37350", Offset = "0xD35D50", VA = "0x180D37350", Slot = "15")]
			[CompilerGenerated]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x6000173")]
			[Cpp2IlInjected.Address(RVA = "0x164B040", Offset = "0x1649A40", VA = "0x18164B040")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000174")]
		[Cpp2IlInjected.Address(RVA = "0x8DBEEB0", Offset = "0x8DBD8B0", VA = "0x188DBEEB0", Slot = "4")]
		public FAEJBLUXTOM Clone([Optional] int? bodyTypeOverride)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000175")]
		[Cpp2IlInjected.Address(RVA = "0xD16C40", Offset = "0xD15640", VA = "0x180D16C40")]
		public CustomAvatarItemSaveDTO()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200002F")]
	[Flags]
	public enum CustomAvatarItemTypeFlags
	{
		[Cpp2IlInjected.Token(Token = "0x40000A2")]
		None = 0,
		[Cpp2IlInjected.Token(Token = "0x40000A3")]
		Shirt = 1,
		[Cpp2IlInjected.Token(Token = "0x40000A4")]
		All = -1
	}
	[Cpp2IlInjected.Token(Token = "0x2000030")]
	public enum CustomAvatarItemSearchOrdering
	{
		[Cpp2IlInjected.Token(Token = "0x40000A6")]
		SearchScoreDescending,
		[Cpp2IlInjected.Token(Token = "0x40000A7")]
		HotScoreDescending,
		[Cpp2IlInjected.Token(Token = "0x40000A8")]
		Newest,
		[Cpp2IlInjected.Token(Token = "0x40000A9")]
		Oldest,
		[Cpp2IlInjected.Token(Token = "0x40000AA")]
		PriceAscending,
		[Cpp2IlInjected.Token(Token = "0x40000AB")]
		PriceDescending,
		[Cpp2IlInjected.Token(Token = "0x40000AC")]
		FeaturedFirst
	}
	[Cpp2IlInjected.Token(Token = "0x2000031")]
	public static class LKGNWNFXYCA
	{
		[Cpp2IlInjected.Token(Token = "0x6000176")]
		[Cpp2IlInjected.Address(RVA = "0x8DC2970", Offset = "0x8DC1370", VA = "0x188DC2970")]
		public static int? RJLOVMDNWXO(CustomAvatarItemTypeFlags? a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000177")]
		[Cpp2IlInjected.Address(RVA = "0x8DC28E0", Offset = "0x8DC12E0", VA = "0x188DC28E0")]
		public static int? GRUQLJPVAZJ(CustomAvatarItemSearchOrdering? a)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000032")]
	[Utf8JsonSerializable]
	public class CustomAvatarItemSet : QPSFFVWODNU
	{
		[Cpp2IlInjected.Token(Token = "0x170000A1")]
		public string Name
		{
			[Cpp2IlInjected.Token(Token = "0x6000178")]
			[Cpp2IlInjected.Address(RVA = "0xD117B0", Offset = "0xD101B0", VA = "0x180D117B0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000179")]
			[Cpp2IlInjected.Address(RVA = "0xD117C0", Offset = "0xD101C0", VA = "0x180D117C0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000A2")]
		public long CreatorAccountId
		{
			[Cpp2IlInjected.Token(Token = "0x600017A")]
			[Cpp2IlInjected.Address(RVA = "0xD11B30", Offset = "0xD10530", VA = "0x180D11B30")]
			[CompilerGenerated]
			get
			{
				return default(long);
			}
			[Cpp2IlInjected.Token(Token = "0x600017B")]
			[Cpp2IlInjected.Address(RVA = "0xE07390", Offset = "0xE05D90", VA = "0x180E07390")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000A3")]
		public List<CustomAvatarItem> CustomAvatarItems
		{
			[Cpp2IlInjected.Token(Token = "0x600017C")]
			[Cpp2IlInjected.Address(RVA = "0xD12BC0", Offset = "0xD115C0", VA = "0x180D12BC0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600017D")]
			[Cpp2IlInjected.Address(RVA = "0xD11520", Offset = "0xD0FF20", VA = "0x180D11520")]
			[CompilerGenerated]
			internal set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600017E")]
		[Cpp2IlInjected.Address(RVA = "0x8DBEF70", Offset = "0x8DBD970", VA = "0x188DBEF70", Slot = "4")]
		public Task NLARVXFWNGH()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600017F")]
		[Cpp2IlInjected.Address(RVA = "0xD16C40", Offset = "0xD15640", VA = "0x180D16C40")]
		public CustomAvatarItemSet()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000033")]
	[Utf8JsonSerializable]
	public class CustomAvatarItemTagDTO
	{
		[Cpp2IlInjected.Token(Token = "0x170000A4")]
		public string Value
		{
			[Cpp2IlInjected.Token(Token = "0x6000180")]
			[Cpp2IlInjected.Address(RVA = "0xD117B0", Offset = "0xD101B0", VA = "0x180D117B0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000181")]
			[Cpp2IlInjected.Address(RVA = "0xD117C0", Offset = "0xD101C0", VA = "0x180D117C0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000A5")]
		public TagType TagType
		{
			[Cpp2IlInjected.Token(Token = "0x6000182")]
			[Cpp2IlInjected.Address(RVA = "0xD17340", Offset = "0xD15D40", VA = "0x180D17340")]
			[CompilerGenerated]
			get
			{
				return default(TagType);
			}
			[Cpp2IlInjected.Token(Token = "0x6000183")]
			[Cpp2IlInjected.Address(RVA = "0xD17360", Offset = "0xD15D60", VA = "0x180D17360")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000184")]
		[Cpp2IlInjected.Address(RVA = "0xD16C40", Offset = "0xD15640", VA = "0x180D16C40")]
		public CustomAvatarItemTagDTO()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000034")]
	[Utf8JsonSerializable]
	public class CustomAvatarItemUpdateRequest
	{
		[Cpp2IlInjected.Token(Token = "0x170000A6")]
		public string Name
		{
			[Cpp2IlInjected.Token(Token = "0x6000185")]
			[Cpp2IlInjected.Address(RVA = "0xD117B0", Offset = "0xD101B0", VA = "0x180D117B0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000186")]
			[Cpp2IlInjected.Address(RVA = "0xD117C0", Offset = "0xD101C0", VA = "0x180D117C0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000A7")]
		public string Description
		{
			[Cpp2IlInjected.Token(Token = "0x6000187")]
			[Cpp2IlInjected.Address(RVA = "0xD11B30", Offset = "0xD10530", VA = "0x180D11B30")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000188")]
			[Cpp2IlInjected.Address(RVA = "0xD12270", Offset = "0xD10C70", VA = "0x180D12270")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000A8")]
		public int? Price
		{
			[Cpp2IlInjected.Token(Token = "0x6000189")]
			[Cpp2IlInjected.Address(RVA = "0xD12BC0", Offset = "0xD115C0", VA = "0x180D12BC0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600018A")]
			[Cpp2IlInjected.Address(RVA = "0xE3F130", Offset = "0xE3DB30", VA = "0x180E3F130")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000A9")]
		public UgcAccessibility? Accessibility
		{
			[Cpp2IlInjected.Token(Token = "0x600018B")]
			[Cpp2IlInjected.Address(RVA = "0xD11B00", Offset = "0xD10500", VA = "0x180D11B00")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600018C")]
			[Cpp2IlInjected.Address(RVA = "0xD11960", Offset = "0xD10360", VA = "0x180D11960")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600018D")]
		[Cpp2IlInjected.Address(RVA = "0xD16C40", Offset = "0xD15640", VA = "0x180D16C40")]
		public CustomAvatarItemUpdateRequest()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000035")]
	[Utf8JsonSerializable]
	public class CustomAvatarItemVisualData
	{
		[Cpp2IlInjected.Token(Token = "0x170000AA")]
		public Guid CustomAvatarItemId
		{
			[Cpp2IlInjected.Token(Token = "0x600018E")]
			[Cpp2IlInjected.Address(RVA = "0xF357F0", Offset = "0xF341F0", VA = "0x180F357F0")]
			[CompilerGenerated]
			get
			{
				return default(Guid);
			}
			[Cpp2IlInjected.Token(Token = "0x600018F")]
			[Cpp2IlInjected.Address(RVA = "0xF35810", Offset = "0xF34210", VA = "0x180F35810")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000AB")]
		public byte BodyPart
		{
			[Cpp2IlInjected.Token(Token = "0x6000190")]
			[Cpp2IlInjected.Address(RVA = "0xD11950", Offset = "0xD10350", VA = "0x180D11950")]
			[CompilerGenerated]
			get
			{
				return default(byte);
			}
			[Cpp2IlInjected.Token(Token = "0x6000191")]
			[Cpp2IlInjected.Address(RVA = "0xD12250", Offset = "0xD10C50", VA = "0x180D12250")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000192")]
		[Cpp2IlInjected.Address(RVA = "0xD16C40", Offset = "0xD15640", VA = "0x180D16C40")]
		public CustomAvatarItemVisualData()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000036")]
	public static class XDNWQETVRZE
	{
		[Cpp2IlInjected.Token(Token = "0x6000193")]
		[Cpp2IlInjected.Address(RVA = "0x8DCAC40", Offset = "0x8DC9640", VA = "0x188DCAC40")]
		public static OutfitSelectionDTO WZUNZIDUWDB(this CustomAvatarItemVisualData a)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000037")]
	public interface CKAQAAOLPYF
	{
		[Cpp2IlInjected.Token(Token = "0x170000AC")]
		Guid CustomAvatarItemId
		{
			[Cpp2IlInjected.Token(Token = "0x6000194")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x170000AD")]
		int CreatorAccountId
		{
			[Cpp2IlInjected.Token(Token = "0x6000195")]
			[Cpp2IlInjected.Address(Slot = "1")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x170000AE")]
		string Name
		{
			[Cpp2IlInjected.Token(Token = "0x6000196")]
			[Cpp2IlInjected.Address(Slot = "2")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x170000AF")]
		string Description
		{
			[Cpp2IlInjected.Token(Token = "0x6000197")]
			[Cpp2IlInjected.Address(Slot = "3")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x170000B0")]
		int Price
		{
			[Cpp2IlInjected.Token(Token = "0x6000198")]
			[Cpp2IlInjected.Address(Slot = "4")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x170000B1")]
		UgcAccessibility Accessibility
		{
			[Cpp2IlInjected.Token(Token = "0x6000199")]
			[Cpp2IlInjected.Address(Slot = "5")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x170000B2")]
		bool ForceCannotPublish
		{
			[Cpp2IlInjected.Token(Token = "0x600019A")]
			[Cpp2IlInjected.Address(Slot = "6")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x170000B3")]
		bool IsFeatured
		{
			[Cpp2IlInjected.Token(Token = "0x600019B")]
			[Cpp2IlInjected.Address(Slot = "7")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x170000B4")]
		bool IsRecRoomApproved
		{
			[Cpp2IlInjected.Token(Token = "0x600019C")]
			[Cpp2IlInjected.Address(Slot = "8")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x170000B5")]
		int? BaseAvatarItemId
		{
			[Cpp2IlInjected.Token(Token = "0x600019D")]
			[Cpp2IlInjected.Address(Slot = "9")]
			get;
			[Cpp2IlInjected.Token(Token = "0x600019E")]
			[Cpp2IlInjected.Address(Slot = "10")]
			set;
		}

		[Cpp2IlInjected.Token(Token = "0x170000B6")]
		string BaseAvatarItemColor
		{
			[Cpp2IlInjected.Token(Token = "0x600019F")]
			[Cpp2IlInjected.Address(Slot = "11")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x170000B7")]
		string DesignFilename
		{
			[Cpp2IlInjected.Token(Token = "0x60001A0")]
			[Cpp2IlInjected.Address(Slot = "12")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x170000B8")]
		string ThumbnailImageFilename
		{
			[Cpp2IlInjected.Token(Token = "0x60001A1")]
			[Cpp2IlInjected.Address(Slot = "13")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x170000B9")]
		DateTime CreatedAt
		{
			[Cpp2IlInjected.Token(Token = "0x60001A2")]
			[Cpp2IlInjected.Address(Slot = "14")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x170000BA")]
		DateTime ModifiedAt
		{
			[Cpp2IlInjected.Token(Token = "0x60001A3")]
			[Cpp2IlInjected.Address(Slot = "15")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x170000BB")]
		CustomAvatarItemPreviewOrientation PreviewOrientation
		{
			[Cpp2IlInjected.Token(Token = "0x60001A4")]
			[Cpp2IlInjected.Address(Slot = "16")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x170000BC")]
		string RankingContext
		{
			[Cpp2IlInjected.Token(Token = "0x60001A5")]
			[Cpp2IlInjected.Address(Slot = "17")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x170000BD")]
		int OutfitType
		{
			[Cpp2IlInjected.Token(Token = "0x60001A6")]
			[Cpp2IlInjected.Address(Slot = "18")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x170000BE")]
		string RankedEntityId
		{
			[Cpp2IlInjected.Token(Token = "0x60001A7")]
			[Cpp2IlInjected.Address(RVA = "0x8DBE9D0", Offset = "0x8DBD3D0", VA = "0x188DBE9D0", Slot = "19")]
			get
			{
				return null;
			}
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000038")]
	public interface KSLCTVRDJTL
	{
		[Cpp2IlInjected.Token(Token = "0x170000BF")]
		IReadOnlyList<FAEJBLUXTOM> Saves
		{
			[Cpp2IlInjected.Token(Token = "0x60001A8")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x170000C0")]
		Guid CustomAvatarItemId
		{
			[Cpp2IlInjected.Token(Token = "0x60001A9")]
			[Cpp2IlInjected.Address(Slot = "1")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x170000C1")]
		int CreatorAccountId
		{
			[Cpp2IlInjected.Token(Token = "0x60001AA")]
			[Cpp2IlInjected.Address(Slot = "2")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x170000C2")]
		string Name
		{
			[Cpp2IlInjected.Token(Token = "0x60001AB")]
			[Cpp2IlInjected.Address(Slot = "3")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x170000C3")]
		string Description
		{
			[Cpp2IlInjected.Token(Token = "0x60001AC")]
			[Cpp2IlInjected.Address(Slot = "4")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x170000C4")]
		bool IsRecRoomApproved
		{
			[Cpp2IlInjected.Token(Token = "0x60001AD")]
			[Cpp2IlInjected.Address(Slot = "5")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x170000C5")]
		int OutfitType
		{
			[Cpp2IlInjected.Token(Token = "0x60001AE")]
			[Cpp2IlInjected.Address(Slot = "6")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x170000C6")]
		int? BaseAvatarItemId
		{
			[Cpp2IlInjected.Token(Token = "0x60001AF")]
			[Cpp2IlInjected.Address(Slot = "7")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x170000C7")]
		UgcAccessibility Accessibility
		{
			[Cpp2IlInjected.Token(Token = "0x60001B0")]
			[Cpp2IlInjected.Address(Slot = "8")]
			get;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000039")]
	public static class VKPIQKOEMYZ
	{
		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x200003B")]
		[CompilerGenerated]
		private struct <OnDeserializedAsync>d__1 : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000BA")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x40000BB")]
			public AsyncTaskMethodBuilder <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x40000BC")]
			public IEnumerable<QPSFFVWODNU> list;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x40000BD")]
			private ConfiguredTaskAwaitable.ConfiguredTaskAwaiter <>u__1;

			[Cpp2IlInjected.Token(Token = "0x60001B6")]
			[Cpp2IlInjected.Address(RVA = "0x8DC8460", Offset = "0x8DC6E60", VA = "0x188DC8460", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001B7")]
			[Cpp2IlInjected.Address(RVA = "0x8DC8700", Offset = "0x8DC7100", VA = "0x188DC8700", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60001B1")]
		[Cpp2IlInjected.Address(RVA = "0x8DCA450", Offset = "0x8DC8E50", VA = "0x188DCA450")]
		public static bool HHUGNWFYOZL(this IEnumerable<OIRXPKYYAWC> a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001B2")]
		[Cpp2IlInjected.Address(RVA = "0x8DCA690", Offset = "0x8DC9090", VA = "0x188DCA690")]
		[AsyncStateMachine(typeof(<OnDeserializedAsync>d__1))]
		public static Task NLARVXFWNGH(this IEnumerable<QPSFFVWODNU> a)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200003C")]
	public struct FilenameWithHash
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000BE")]
		public readonly string Filename;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40000BF")]
		public readonly string Hash;

		[Cpp2IlInjected.Token(Token = "0x40000C0")]
		public static readonly FilenameWithHash Null;

		[Cpp2IlInjected.Token(Token = "0x60001B8")]
		[Cpp2IlInjected.Address(RVA = "0x111A3F0", Offset = "0x1118DF0", VA = "0x18111A3F0")]
		public FilenameWithHash(string filename, string hash)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001B9")]
		[Cpp2IlInjected.Address(RVA = "0x1452120", Offset = "0x1450B20", VA = "0x181452120")]
		public bool Equals(FilenameWithHash other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001BA")]
		[Cpp2IlInjected.Address(RVA = "0x8DBF5F0", Offset = "0x8DBDFF0", VA = "0x188DBF5F0", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001BB")]
		[Cpp2IlInjected.Address(RVA = "0x8DBF6D0", Offset = "0x8DBE0D0", VA = "0x188DBF6D0", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[SpecialName]
		[Cpp2IlInjected.Token(Token = "0x60001BC")]
		[Cpp2IlInjected.Address(RVA = "0x8DBF740", Offset = "0x8DBE140", VA = "0x188DBF740")]
		public static bool ITVTPRNZGNV(FilenameWithHash a, FilenameWithHash b)
		{
			return default(bool);
		}

		[SpecialName]
		[Cpp2IlInjected.Token(Token = "0x60001BD")]
		[Cpp2IlInjected.Address(RVA = "0x8DBF570", Offset = "0x8DBDF70", VA = "0x188DBF570")]
		public static bool CYAUITUETAA(FilenameWithHash a, FilenameWithHash b)
		{
			return default(bool);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200003D")]
	public interface QNXXFRWOHHS
	{
		[Cpp2IlInjected.Token(Token = "0x170000C8")]
		SVLZDUPCXXS YOEKAAIYPRN
		{
			[Cpp2IlInjected.Token(Token = "0x60001BF")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x170000C9")]
		string ACNYJATKBFM
		{
			[Cpp2IlInjected.Token(Token = "0x60001C0")]
			[Cpp2IlInjected.Address(Slot = "1")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x170000CA")]
		string OPEMWTYNWOS
		{
			[Cpp2IlInjected.Token(Token = "0x60001C1")]
			[Cpp2IlInjected.Address(Slot = "2")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x170000CB")]
		long GOMCIGPEXNX
		{
			[Cpp2IlInjected.Token(Token = "0x60001C2")]
			[Cpp2IlInjected.Address(Slot = "3")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x170000CC")]
		string YMRTUSGJYFH
		{
			[Cpp2IlInjected.Token(Token = "0x60001C3")]
			[Cpp2IlInjected.Address(Slot = "4")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x170000CD")]
		string JHUFDFJRNVC
		{
			[Cpp2IlInjected.Token(Token = "0x60001C4")]
			[Cpp2IlInjected.Address(Slot = "5")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x170000CE")]
		string QJEHHZZVPAG
		{
			[Cpp2IlInjected.Token(Token = "0x60001C5")]
			[Cpp2IlInjected.Address(Slot = "6")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x170000CF")]
		string YZHCQKKPZIE
		{
			[Cpp2IlInjected.Token(Token = "0x60001C6")]
			[Cpp2IlInjected.Address(Slot = "7")]
			get;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200003E")]
	[Utf8JsonSerializable]
	public class ContentBlock : WQRFGGFYBAG
	{
		[Cpp2IlInjected.Token(Token = "0x170000D0")]
		public string TrackingCategory
		{
			[Cpp2IlInjected.Token(Token = "0x60001C7")]
			[Cpp2IlInjected.Address(RVA = "0xD11B30", Offset = "0xD10530", VA = "0x180D11B30")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60001C8")]
			[Cpp2IlInjected.Address(RVA = "0xD12270", Offset = "0xD10C70", VA = "0x180D12270")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000D1")]
		public ContentBlockLayout Layout
		{
			[Cpp2IlInjected.Token(Token = "0x60001C9")]
			[Cpp2IlInjected.Address(RVA = "0xD215F0", Offset = "0xD1FFF0", VA = "0x180D215F0")]
			[CompilerGenerated]
			get
			{
				return default(ContentBlockLayout);
			}
			[Cpp2IlInjected.Token(Token = "0x60001CA")]
			[Cpp2IlInjected.Address(RVA = "0xD682F0", Offset = "0xD66CF0", VA = "0x180D682F0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000D2")]
		public ContentBlockTextSize TextSize
		{
			[Cpp2IlInjected.Token(Token = "0x60001CB")]
			[Cpp2IlInjected.Address(RVA = "0xD38090", Offset = "0xD36A90", VA = "0x180D38090")]
			[CompilerGenerated]
			get
			{
				return default(ContentBlockTextSize);
			}
			[Cpp2IlInjected.Token(Token = "0x60001CC")]
			[Cpp2IlInjected.Address(RVA = "0xF21A50", Offset = "0xF20450", VA = "0x180F21A50")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000D3")]
		public ContentBlockTitlePlacement TitleTextPlacement
		{
			[Cpp2IlInjected.Token(Token = "0x60001CD")]
			[Cpp2IlInjected.Address(RVA = "0xD12BE0", Offset = "0xD115E0", VA = "0x180D12BE0")]
			[CompilerGenerated]
			get
			{
				return default(ContentBlockTitlePlacement);
			}
			[Cpp2IlInjected.Token(Token = "0x60001CE")]
			[Cpp2IlInjected.Address(RVA = "0xD12C40", Offset = "0xD11640", VA = "0x180D12C40")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000D4")]
		[DataMember(Name = "Header")]
		public string? HeaderOverride
		{
			[Cpp2IlInjected.Token(Token = "0x60001CF")]
			[Cpp2IlInjected.Address(RVA = "0xD11A20", Offset = "0xD10420", VA = "0x180D11A20")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60001D0")]
			[Cpp2IlInjected.Address(RVA = "0xD17350", Offset = "0xD15D50", VA = "0x180D17350")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000D5")]
		public string? Title
		{
			[Cpp2IlInjected.Token(Token = "0x60001D1")]
			[Cpp2IlInjected.Address(RVA = "0xD12280", Offset = "0xD10C80", VA = "0x180D12280")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60001D2")]
			[Cpp2IlInjected.Address(RVA = "0xD11B50", Offset = "0xD10550", VA = "0x180D11B50")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000D6")]
		public string? Body
		{
			[Cpp2IlInjected.Token(Token = "0x60001D3")]
			[Cpp2IlInjected.Address(RVA = "0xD11A30", Offset = "0xD10430", VA = "0x180D11A30")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60001D4")]
			[Cpp2IlInjected.Address(RVA = "0xD12260", Offset = "0xD10C60", VA = "0x180D12260")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000D7")]
		public List<string> ImageNames
		{
			[Cpp2IlInjected.Token(Token = "0x60001D5")]
			[Cpp2IlInjected.Address(RVA = "0xD122E0", Offset = "0xD10CE0", VA = "0x180D122E0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60001D6")]
			[Cpp2IlInjected.Address(RVA = "0xD12290", Offset = "0xD10C90", VA = "0x180D12290")]
			[CompilerGenerated]
			internal set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000D8")]
		public List<ContentBlockButton> Buttons
		{
			[Cpp2IlInjected.Token(Token = "0x60001D7")]
			[Cpp2IlInjected.Address(RVA = "0xD11B20", Offset = "0xD10520", VA = "0x180D11B20")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60001D8")]
			[Cpp2IlInjected.Address(RVA = "0xD11900", Offset = "0xD10300", VA = "0x180D11900")]
			[CompilerGenerated]
			internal set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60001D9")]
		[Cpp2IlInjected.Address(RVA = "0x8DBEB90", Offset = "0x8DBD590", VA = "0x188DBEB90")]
		public ContentBlock()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200003F")]
	public enum ContentBlockLinkType
	{
		[Cpp2IlInjected.Token(Token = "0x40000CB")]
		Url,
		[Cpp2IlInjected.Token(Token = "0x40000CC")]
		AccountId,
		[Cpp2IlInjected.Token(Token = "0x40000CD")]
		EventId,
		[Cpp2IlInjected.Token(Token = "0x40000CE")]
		RoomName,
		[Cpp2IlInjected.Token(Token = "0x40000CF")]
		Storefront,
		[Cpp2IlInjected.Token(Token = "0x40000D0")]
		[Obsolete("6/4/21: This was only ever used for an announcement for Shawn's referral event, which is not happening again. Removing as part of a StackUI cleanup")]
		ActionCode,
		[Cpp2IlInjected.Token(Token = "0x40000D1")]
		Item,
		[Cpp2IlInjected.Token(Token = "0x40000D2")]
		CustomAvatarItem,
		[Cpp2IlInjected.Token(Token = "0x40000D3")]
		AuthorizedRecNetUrl,
		[Cpp2IlInjected.Token(Token = "0x40000D4")]
		Close
	}
	[Cpp2IlInjected.Token(Token = "0x2000040")]
	public enum ContentBlockLayout
	{
		[Cpp2IlInjected.Token(Token = "0x40000D6")]
		Default,
		[Cpp2IlInjected.Token(Token = "0x40000D7")]
		Vertical,
		[Cpp2IlInjected.Token(Token = "0x40000D8")]
		Horizontal
	}
	[Cpp2IlInjected.Token(Token = "0x2000041")]
	public enum ContentBlockTextSize
	{
		[Cpp2IlInjected.Token(Token = "0x40000DA")]
		Small,
		[Cpp2IlInjected.Token(Token = "0x40000DB")]
		Medium,
		[Cpp2IlInjected.Token(Token = "0x40000DC")]
		Large
	}
	[Cpp2IlInjected.Token(Token = "0x2000042")]
	public enum ContentBlockTitlePlacement
	{
		[Cpp2IlInjected.Token(Token = "0x40000DE")]
		Before,
		[Cpp2IlInjected.Token(Token = "0x40000DF")]
		Overlay,
		[Cpp2IlInjected.Token(Token = "0x40000E0")]
		After
	}
	[Cpp2IlInjected.Token(Token = "0x2000043")]
	[Utf8JsonSerializable]
	public class ContentBlockButton
	{
		[Cpp2IlInjected.Token(Token = "0x170000D9")]
		public ContentBlockLinkType LinkType
		{
			[Cpp2IlInjected.Token(Token = "0x60001DA")]
			[Cpp2IlInjected.Address(RVA = "0xD0F110", Offset = "0xD0DB10", VA = "0x180D0F110")]
			[CompilerGenerated]
			get
			{
				return default(ContentBlockLinkType);
			}
			[Cpp2IlInjected.Token(Token = "0x60001DB")]
			[Cpp2IlInjected.Address(RVA = "0xD12F30", Offset = "0xD11930", VA = "0x180D12F30")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000DA")]
		public string? LinkName
		{
			[Cpp2IlInjected.Token(Token = "0x60001DC")]
			[Cpp2IlInjected.Address(RVA = "0xD11B30", Offset = "0xD10530", VA = "0x180D11B30")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60001DD")]
			[Cpp2IlInjected.Address(RVA = "0xD12270", Offset = "0xD10C70", VA = "0x180D12270")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000DB")]
		[DataMember(Name = "LinkParameter")]
		public string? LinkUriOrParameter
		{
			[Cpp2IlInjected.Token(Token = "0x60001DE")]
			[Cpp2IlInjected.Address(RVA = "0xD12BC0", Offset = "0xD115C0", VA = "0x180D12BC0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60001DF")]
			[Cpp2IlInjected.Address(RVA = "0xD11520", Offset = "0xD0FF20", VA = "0x180D11520")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000DC")]
		public string? LinkButtonLabel
		{
			[Cpp2IlInjected.Token(Token = "0x60001E0")]
			[Cpp2IlInjected.Address(RVA = "0xD11B00", Offset = "0xD10500", VA = "0x180D11B00")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60001E1")]
			[Cpp2IlInjected.Address(RVA = "0xD11530", Offset = "0xD0FF30", VA = "0x180D11530")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60001E2")]
		[Cpp2IlInjected.Address(RVA = "0xD16C40", Offset = "0xD15640", VA = "0x180D16C40")]
		public ContentBlockButton()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000044")]
	public abstract class WQRFGGFYBAG
	{
		[Cpp2IlInjected.Token(Token = "0x170000DD")]
		[IgnoreDataMember]
		public string? TUMRDFIDQOZ
		{
			[Cpp2IlInjected.Token(Token = "0x60001E3")]
			[Cpp2IlInjected.Address(RVA = "0xD117B0", Offset = "0xD101B0", VA = "0x180D117B0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60001E4")]
			[Cpp2IlInjected.Address(RVA = "0xD117C0", Offset = "0xD101C0", VA = "0x180D117C0")]
			[CompilerGenerated]
			internal set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60001E5")]
		[Cpp2IlInjected.Address(RVA = "0x14F8CA0", Offset = "0x14F76A0", VA = "0x1814F8CA0")]
		protected WQRFGGFYBAG()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000045")]
	[Utf8JsonSerializable]
	public class InAppMessageIdDTO
	{
		[Cpp2IlInjected.Token(Token = "0x170000DE")]
		public string? MessageId
		{
			[Cpp2IlInjected.Token(Token = "0x60001E6")]
			[Cpp2IlInjected.Address(RVA = "0xD117B0", Offset = "0xD101B0", VA = "0x180D117B0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60001E7")]
			[Cpp2IlInjected.Address(RVA = "0xD117C0", Offset = "0xD101C0", VA = "0x180D117C0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60001E8")]
		[Cpp2IlInjected.Address(RVA = "0xD16C40", Offset = "0xD15640", VA = "0x180D16C40")]
		public InAppMessageIdDTO()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000046")]
	[Utf8JsonSerializable]
	public class InAppMessageDTO : OIRXPKYYAWC
	{
		[Cpp2IlInjected.Token(Token = "0x40000E7")]
		internal static Func<string, ContentBlock>? UPVXGLODEXK;

		[Cpp2IlInjected.Token(Token = "0x40000E8")]
		internal static Func<string, JustInTimeTutorialTrigger>? UKAYLXSGILA;

		[Cpp2IlInjected.Token(Token = "0x170000DF")]
		public string? MessageId
		{
			[Cpp2IlInjected.Token(Token = "0x60001E9")]
			[Cpp2IlInjected.Address(RVA = "0xD117B0", Offset = "0xD101B0", VA = "0x180D117B0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60001EA")]
			[Cpp2IlInjected.Address(RVA = "0xD117C0", Offset = "0xD101C0", VA = "0x180D117C0")]
			[CompilerGenerated]
			internal set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000E0")]
		public string? SenderMessageId
		{
			[Cpp2IlInjected.Token(Token = "0x60001EB")]
			[Cpp2IlInjected.Address(RVA = "0xD11B30", Offset = "0xD10530", VA = "0x180D11B30")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60001EC")]
			[Cpp2IlInjected.Address(RVA = "0xD12270", Offset = "0xD10C70", VA = "0x180D12270")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000E1")]
		public bool IsBroadcast
		{
			[Cpp2IlInjected.Token(Token = "0x60001ED")]
			[Cpp2IlInjected.Address(RVA = "0xD11950", Offset = "0xD10350", VA = "0x180D11950")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x60001EE")]
			[Cpp2IlInjected.Address(RVA = "0xD12250", Offset = "0xD10C50", VA = "0x180D12250")]
			[CompilerGenerated]
			internal set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000E2")]
		public PlatformType Platform
		{
			[Cpp2IlInjected.Token(Token = "0x60001EF")]
			[Cpp2IlInjected.Address(RVA = "0xD38090", Offset = "0xD36A90", VA = "0x180D38090")]
			[CompilerGenerated]
			get
			{
				return default(PlatformType);
			}
			[Cpp2IlInjected.Token(Token = "0x60001F0")]
			[Cpp2IlInjected.Address(RVA = "0xF21A50", Offset = "0xF20450", VA = "0x180F21A50")]
			[CompilerGenerated]
			internal set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000E3")]
		public PlatformMask PlatformTypeMask
		{
			[Cpp2IlInjected.Token(Token = "0x60001F1")]
			[Cpp2IlInjected.Address(RVA = "0xD12BE0", Offset = "0xD115E0", VA = "0x180D12BE0")]
			[CompilerGenerated]
			get
			{
				return default(PlatformMask);
			}
			[Cpp2IlInjected.Token(Token = "0x60001F2")]
			[Cpp2IlInjected.Address(RVA = "0xD12C40", Offset = "0xD11640", VA = "0x180D12C40")]
			[CompilerGenerated]
			internal set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000E4")]
		public int Priority
		{
			[Cpp2IlInjected.Token(Token = "0x60001F3")]
			[Cpp2IlInjected.Address(RVA = "0xE24360", Offset = "0xE22D60", VA = "0x180E24360")]
			[CompilerGenerated]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x60001F4")]
			[Cpp2IlInjected.Address(RVA = "0x1E2BFE0", Offset = "0x1E2A9E0", VA = "0x181E2BFE0")]
			[CompilerGenerated]
			internal set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000E5")]
		public DateTime SentAt
		{
			[Cpp2IlInjected.Token(Token = "0x60001F5")]
			[Cpp2IlInjected.Address(RVA = "0xD11A20", Offset = "0xD10420", VA = "0x180D11A20")]
			[CompilerGenerated]
			get
			{
				return default(DateTime);
			}
			[Cpp2IlInjected.Token(Token = "0x60001F6")]
			[Cpp2IlInjected.Address(RVA = "0xD118E0", Offset = "0xD102E0", VA = "0x180D118E0")]
			[CompilerGenerated]
			internal set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000E6")]
		[DataMember(Name = "IsRead")]
		internal bool GGESNLVUASS
		{
			[Cpp2IlInjected.Token(Token = "0x60001F7")]
			[Cpp2IlInjected.Address(RVA = "0xD3D030", Offset = "0xD3BA30", VA = "0x180D3D030")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x60001F8")]
			[Cpp2IlInjected.Address(RVA = "0xD3D040", Offset = "0xD3BA40", VA = "0x180D3D040")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000E7")]
		[IgnoreDataMember]
		public bool IsClientRead
		{
			[Cpp2IlInjected.Token(Token = "0x60001F9")]
			[Cpp2IlInjected.Address(RVA = "0x1B9BC60", Offset = "0x1B9A660", VA = "0x181B9BC60")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x60001FA")]
			[Cpp2IlInjected.Address(RVA = "0x10511F0", Offset = "0x104FBF0", VA = "0x1810511F0")]
			[CompilerGenerated]
			internal set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000E8")]
		public InAppMessageChannel Channel
		{
			[Cpp2IlInjected.Token(Token = "0x60001FB")]
			[Cpp2IlInjected.Address(RVA = "0xD50990", Offset = "0xD4F390", VA = "0x180D50990")]
			[CompilerGenerated]
			get
			{
				return default(InAppMessageChannel);
			}
			[Cpp2IlInjected.Token(Token = "0x60001FC")]
			[Cpp2IlInjected.Address(RVA = "0xD506C0", Offset = "0xD4F0C0", VA = "0x180D506C0")]
			[CompilerGenerated]
			internal set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000E9")]
		public InAppMessageContentType ContentType
		{
			[Cpp2IlInjected.Token(Token = "0x60001FD")]
			[Cpp2IlInjected.Address(RVA = "0xD2DD40", Offset = "0xD2C740", VA = "0x180D2DD40")]
			[CompilerGenerated]
			get
			{
				return default(InAppMessageContentType);
			}
			[Cpp2IlInjected.Token(Token = "0x60001FE")]
			[Cpp2IlInjected.Address(RVA = "0xD89720", Offset = "0xD88120", VA = "0x180D89720")]
			[CompilerGenerated]
			internal set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000EA")]
		internal string? XTJQDCTYXEK
		{
			[Cpp2IlInjected.Token(Token = "0x60001FF")]
			[Cpp2IlInjected.Address(RVA = "0xD122E0", Offset = "0xD10CE0", VA = "0x180D122E0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000200")]
			[Cpp2IlInjected.Address(RVA = "0xD12290", Offset = "0xD10C90", VA = "0x180D12290")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000EB")]
		[IgnoreDataMember]
		public ContentBlock? ContentBlock
		{
			[Cpp2IlInjected.Token(Token = "0x6000201")]
			[Cpp2IlInjected.Address(RVA = "0x8DC1300", Offset = "0x8DBFD00", VA = "0x188DC1300")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000EC")]
		[IgnoreDataMember]
		public JustInTimeTutorialTrigger? JustInTimeTutorialTrigger
		{
			[Cpp2IlInjected.Token(Token = "0x6000202")]
			[Cpp2IlInjected.Address(RVA = "0x8DC1380", Offset = "0x8DBFD80", VA = "0x188DC1380")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000ED")]
		[IgnoreDataMember]
		public WQRFGGFYBAG? ContentObject
		{
			[Cpp2IlInjected.Token(Token = "0x6000203")]
			[Cpp2IlInjected.Address(RVA = "0xD11B20", Offset = "0xD10520", VA = "0x180D11B20")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000204")]
			[Cpp2IlInjected.Address(RVA = "0xD11900", Offset = "0xD10300", VA = "0x180D11900")]
			[CompilerGenerated]
			internal set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000205")]
		[Cpp2IlInjected.Address(RVA = "0x8DC1040", Offset = "0x8DBFA40", VA = "0x188DC1040", Slot = "4")]
		public void HHUGNWFYOZL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000206")]
		[Cpp2IlInjected.Address(RVA = "0xD3D910", Offset = "0xD3C310", VA = "0x180D3D910")]
		public InAppMessageDTO()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000047")]
	[Utf8JsonSerializable]
	public class JustInTimeTutorialCondition
	{
		[Cpp2IlInjected.Token(Token = "0x170000EE")]
		public JustInTimeTutorialTrackable Trackable
		{
			[Cpp2IlInjected.Token(Token = "0x6000207")]
			[Cpp2IlInjected.Address(RVA = "0xD0F110", Offset = "0xD0DB10", VA = "0x180D0F110")]
			[CompilerGenerated]
			get
			{
				return default(JustInTimeTutorialTrackable);
			}
			[Cpp2IlInjected.Token(Token = "0x6000208")]
			[Cpp2IlInjected.Address(RVA = "0xD12F30", Offset = "0xD11930", VA = "0x180D12F30")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000EF")]
		public string Room
		{
			[Cpp2IlInjected.Token(Token = "0x6000209")]
			[Cpp2IlInjected.Address(RVA = "0xD11B30", Offset = "0xD10530", VA = "0x180D11B30")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600020A")]
			[Cpp2IlInjected.Address(RVA = "0xD12270", Offset = "0xD10C70", VA = "0x180D12270")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000F0")]
		public int Threshold
		{
			[Cpp2IlInjected.Token(Token = "0x600020B")]
			[Cpp2IlInjected.Address(RVA = "0xD215F0", Offset = "0xD1FFF0", VA = "0x180D215F0")]
			[CompilerGenerated]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x600020C")]
			[Cpp2IlInjected.Address(RVA = "0xD682F0", Offset = "0xD66CF0", VA = "0x180D682F0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600020D")]
		[Cpp2IlInjected.Address(RVA = "0x8DC25E0", Offset = "0x8DC0FE0", VA = "0x188DC25E0")]
		public JustInTimeTutorialCondition()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000048")]
	[Utf8JsonSerializable]
	public class JustInTimeTutorialTrigger : WQRFGGFYBAG
	{
		[Cpp2IlInjected.Token(Token = "0x170000F1")]
		public string Identifier
		{
			[Cpp2IlInjected.Token(Token = "0x600020E")]
			[Cpp2IlInjected.Address(RVA = "0xD11B30", Offset = "0xD10530", VA = "0x180D11B30")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600020F")]
			[Cpp2IlInjected.Address(RVA = "0xD12270", Offset = "0xD10C70", VA = "0x180D12270")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000F2")]
		public string? Name
		{
			[Cpp2IlInjected.Token(Token = "0x6000210")]
			[Cpp2IlInjected.Address(RVA = "0xD12BC0", Offset = "0xD115C0", VA = "0x180D12BC0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000211")]
			[Cpp2IlInjected.Address(RVA = "0xD11520", Offset = "0xD0FF20", VA = "0x180D11520")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000F3")]
		public JustInTimeTutorialAction Action
		{
			[Cpp2IlInjected.Token(Token = "0x6000212")]
			[Cpp2IlInjected.Address(RVA = "0xD12BE0", Offset = "0xD115E0", VA = "0x180D12BE0")]
			[CompilerGenerated]
			get
			{
				return default(JustInTimeTutorialAction);
			}
			[Cpp2IlInjected.Token(Token = "0x6000213")]
			[Cpp2IlInjected.Address(RVA = "0xD12C40", Offset = "0xD11640", VA = "0x180D12C40")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000F4")]
		[DataMember(Name = "all_conditions_required")]
		public bool AllConditionsRequired
		{
			[Cpp2IlInjected.Token(Token = "0x6000214")]
			[Cpp2IlInjected.Address(RVA = "0x1B417C0", Offset = "0x1B401C0", VA = "0x181B417C0")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000215")]
			[Cpp2IlInjected.Address(RVA = "0x10E0890", Offset = "0x10DF290", VA = "0x1810E0890")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000F5")]
		public List<JustInTimeTutorialCondition> Conditions
		{
			[Cpp2IlInjected.Token(Token = "0x6000216")]
			[Cpp2IlInjected.Address(RVA = "0xD11A20", Offset = "0xD10420", VA = "0x180D11A20")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000217")]
			[Cpp2IlInjected.Address(RVA = "0xD17350", Offset = "0xD15D50", VA = "0x180D17350")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000218")]
		[Cpp2IlInjected.Address(RVA = "0x8DC2630", Offset = "0x8DC1030", VA = "0x188DC2630")]
		public JustInTimeTutorialTrigger()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000049")]
	public enum InAppMessageContentType
	{
		[Cpp2IlInjected.Token(Token = "0x40000FF")]
		Unknown,
		[Cpp2IlInjected.Token(Token = "0x4000100")]
		ContentBlock,
		[Cpp2IlInjected.Token(Token = "0x4000101")]
		JustInTimeTutorialTrigger
	}
	[Cpp2IlInjected.Token(Token = "0x200004A")]
	public enum InAppMessageChannel
	{
		[Cpp2IlInjected.Token(Token = "0x4000103")]
		None,
		[Cpp2IlInjected.Token(Token = "0x4000104")]
		Announcements,
		[Cpp2IlInjected.Token(Token = "0x4000105")]
		JustInTimeTutorials
	}
	[Cpp2IlInjected.Token(Token = "0x200004B")]
	public enum JustInTimeTutorialAction
	{
		[Cpp2IlInjected.Token(Token = "0x4000107")]
		Unknown = 0,
		[Cpp2IlInjected.Token(Token = "0x4000108")]
		MakerPenButtonHighlight = 1,
		[Cpp2IlInjected.Token(Token = "0x4000109")]
		PlaceControlTutorial = 3
	}
	[Cpp2IlInjected.Token(Token = "0x200004C")]
	public enum JustInTimeTutorialTrackable
	{
		[Cpp2IlInjected.Token(Token = "0x400010B")]
		EnteredRoom = 0,
		[Cpp2IlInjected.Token(Token = "0x400010C")]
		TimeInRoom = 1,
		[Cpp2IlInjected.Token(Token = "0x400010D")]
		ObjectInteractionRoom = 2,
		[Cpp2IlInjected.Token(Token = "0x400010E")]
		ObjectPlaceStartedRoom = 4
	}
	[Cpp2IlInjected.Token(Token = "0x200004D")]
	public interface AAJVOXJHQPT
	{
		[Cpp2IlInjected.Token(Token = "0x170000F6")]
		bool FOLKOMLFOTT
		{
			[Cpp2IlInjected.Token(Token = "0x600021D")]
			[Cpp2IlInjected.Address(Slot = "4")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x170000F7")]
		ASNKAFBFVVA<InAppMessageDTO> ZJXTGVYQNID
		{
			[Cpp2IlInjected.Token(Token = "0x6000220")]
			[Cpp2IlInjected.Address(Slot = "7")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x170000F8")]
		ASNKAFBFVVA<string> VTGEPYIQLDS
		{
			[Cpp2IlInjected.Token(Token = "0x6000221")]
			[Cpp2IlInjected.Address(Slot = "8")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x170000F9")]
		ASNKAFBFVVA<InAppMessageDTO> NKOIEPJWCPE
		{
			[Cpp2IlInjected.Token(Token = "0x6000222")]
			[Cpp2IlInjected.Address(Slot = "9")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x170000FA")]
		ASNKAFBFVVA<InAppMessageDTO> LKHXMHWEBPN
		{
			[Cpp2IlInjected.Token(Token = "0x6000223")]
			[Cpp2IlInjected.Address(Slot = "10")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x6000219")]
		[Cpp2IlInjected.Address(Slot = "0")]
		IReadOnlyList<InAppMessageDTO> HXAQPWEGSPS(InAppMessageChannel a);

		[Cpp2IlInjected.Token(Token = "0x600021A")]
		[Cpp2IlInjected.Address(Slot = "1")]
		IReadOnlyList<InAppMessageDTO> MBHUCYZUQAL(InAppMessageChannel a);

		[Cpp2IlInjected.Token(Token = "0x600021B")]
		[Cpp2IlInjected.Address(Slot = "2")]
		InAppMessageDTO XIZDNYJSFFM(InAppMessageChannel a, string b);

		[Cpp2IlInjected.Token(Token = "0x600021C")]
		[Cpp2IlInjected.Address(Slot = "3")]
		InAppMessageDTO MLJUUEDIZPN(InAppMessageChannel a);

		[Cpp2IlInjected.Token(Token = "0x600021E")]
		[Cpp2IlInjected.Address(Slot = "5")]
		bool IBQPHRBNOHE(InAppMessageChannel a);

		[Cpp2IlInjected.Token(Token = "0x600021F")]
		[Cpp2IlInjected.Address(Slot = "6")]
		int RDDCGJZMSOO(InAppMessageChannel a);

		[Cpp2IlInjected.Token(Token = "0x6000224")]
		[Cpp2IlInjected.Address(Slot = "11")]
		Task Refresh();

		[Cpp2IlInjected.Token(Token = "0x6000225")]
		[Cpp2IlInjected.Address(Slot = "12")]
		Task WTIZDFRCADS(InAppMessageDTO a);
	}
	[Cpp2IlInjected.Token(Token = "0x200004E")]
	public interface LYQXNHLUQFH
	{
		[Cpp2IlInjected.Token(Token = "0x170000FB")]
		AYYMXEZIWGB NOPFHRMYRBF
		{
			[Cpp2IlInjected.Token(Token = "0x600022A")]
			[Cpp2IlInjected.Address(Slot = "4")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x170000FC")]
		int VQIZJVRVWHI
		{
			[Cpp2IlInjected.Token(Token = "0x600022B")]
			[Cpp2IlInjected.Address(Slot = "5")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x170000FD")]
		bool JNBRJQHDIKG
		{
			[Cpp2IlInjected.Token(Token = "0x600022C")]
			[Cpp2IlInjected.Address(Slot = "6")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x170000FE")]
		bool IQQILSSWAWK
		{
			[Cpp2IlInjected.Token(Token = "0x600022D")]
			[Cpp2IlInjected.Address(Slot = "7")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x170000FF")]
		bool BCFUOBPASJS
		{
			[Cpp2IlInjected.Token(Token = "0x600022E")]
			[Cpp2IlInjected.Address(Slot = "8")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000100")]
		bool IHQXUMCMIVK
		{
			[Cpp2IlInjected.Token(Token = "0x600022F")]
			[Cpp2IlInjected.Address(Slot = "9")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000101")]
		bool BPMNKAMGEJD
		{
			[Cpp2IlInjected.Token(Token = "0x6000230")]
			[Cpp2IlInjected.Address(Slot = "10")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000102")]
		bool WLRUJXNVDOO
		{
			[Cpp2IlInjected.Token(Token = "0x6000231")]
			[Cpp2IlInjected.Address(Slot = "11")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000103")]
		bool IBGPLEBFKZH
		{
			[Cpp2IlInjected.Token(Token = "0x6000232")]
			[Cpp2IlInjected.Address(Slot = "12")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000104")]
		bool ZBBFYOJGCBH
		{
			[Cpp2IlInjected.Token(Token = "0x6000233")]
			[Cpp2IlInjected.Address(Slot = "13")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000105")]
		bool IHENTAJXVSO
		{
			[Cpp2IlInjected.Token(Token = "0x6000234")]
			[Cpp2IlInjected.Address(Slot = "14")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000106")]
		bool WAIMQKRKCSL
		{
			[Cpp2IlInjected.Token(Token = "0x6000235")]
			[Cpp2IlInjected.Address(Slot = "15")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x14000003")]
		event Action JXCZMTBRMAN;

		[Cpp2IlInjected.Token(Token = "0x14000004")]
		event Action DIIQDVQXABD;

		[Cpp2IlInjected.Token(Token = "0x6000236")]
		[Cpp2IlInjected.Address(Slot = "16")]
		CCAFLELIKTY<QZBSYAZDSCL> IERIHHMWUMS(int a);

		[Cpp2IlInjected.Token(Token = "0x6000237")]
		[Cpp2IlInjected.Address(Slot = "17")]
		NFPDGBDVXFD GEULZBSLHGO(DateTime a);

		[Cpp2IlInjected.Token(Token = "0x6000238")]
		[Cpp2IlInjected.Address(Slot = "18")]
		NFPDGBDVXFD YPNCENVBJKF(string a);

		[Cpp2IlInjected.Token(Token = "0x6000239")]
		[Cpp2IlInjected.Address(Slot = "19")]
		Task MUZFBNOHXEC([Optional] CancellationToken a);
	}
	[Cpp2IlInjected.Token(Token = "0x200004F")]
	public enum TestAccountAuthRole
	{
		[Cpp2IlInjected.Token(Token = "0x4000110")]
		Memory,
		[Cpp2IlInjected.Token(Token = "0x4000111")]
		Multiplayer
	}
	[Cpp2IlInjected.Token(Token = "0x2000050")]
	public static class MEDXKGJZSSR
	{
		[Cpp2IlInjected.Token(Token = "0x600023A")]
		[Cpp2IlInjected.Address(RVA = "0x8DC2BD0", Offset = "0x8DC15D0", VA = "0x188DC2BD0")]
		public static string MYYKFIMTIGA(this TestAccountAuthRole a)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000051")]
	public interface VLZKLPTLNYH
	{
		[Cpp2IlInjected.Token(Token = "0x600023B")]
		[Cpp2IlInjected.Address(Slot = "0")]
		Task<List<InAppMessageDTO>> QZMIGHKIWFJ(InAppMessageChannel a);

		[Cpp2IlInjected.Token(Token = "0x600023C")]
		[Cpp2IlInjected.Address(Slot = "1")]
		Task WTIZDFRCADS(string a);
	}
	[Cpp2IlInjected.Token(Token = "0x2000052")]
	public interface MHGADGJYGBU
	{
		[Cpp2IlInjected.Token(Token = "0x600023D")]
		[Cpp2IlInjected.Address(Slot = "0")]
		Task<CrmAssignmentDTO> DEUVBAZCGUL();
	}
	[Cpp2IlInjected.Token(Token = "0x2000053")]
	public interface NYEILGQJESJ
	{
		[Cpp2IlInjected.Token(Token = "0x17000107")]
		Guid? INGMTKQCXZE
		{
			[Cpp2IlInjected.Token(Token = "0x600023E")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000054")]
	public interface ICOWNTNTDPG
	{
		[Cpp2IlInjected.Token(Token = "0x600023F")]
		[Cpp2IlInjected.Address(Slot = "0")]
		CCAFLELIKTY<List<OKPWATORVQQ>> ENDETJQJNAT();

		[Cpp2IlInjected.Token(Token = "0x6000240")]
		[Cpp2IlInjected.Address(Slot = "1")]
		CCAFLELIKTY<List<OKPWATORVQQ>> QPBAVWIKYYW();

		[Cpp2IlInjected.Token(Token = "0x6000241")]
		[Cpp2IlInjected.Address(Slot = "2")]
		Task<List<OKPWATORVQQ>> AFZAMKBFVVA([Optional] CancellationToken a);

		[Cpp2IlInjected.Token(Token = "0x6000242")]
		[Cpp2IlInjected.Address(Slot = "3")]
		CCAFLELIKTY<List<OKPWATORVQQ>> JZZJIBRFFYN(List<AvatarItemDesc> a);

		[Cpp2IlInjected.Token(Token = "0x6000243")]
		[Cpp2IlInjected.Address(Slot = "4")]
		CCAFLELIKTY<List<OKPWATORVQQ>> YPQHAXJWGNH(List<AvatarItemDesc> a);
	}
	[Cpp2IlInjected.Token(Token = "0x2000055")]
	public interface GXQDDUADVVS
	{
		[Cpp2IlInjected.Token(Token = "0x17000108")]
		List<GiftPackage> KDIPCXUBLUS
		{
			[Cpp2IlInjected.Token(Token = "0x6000248")]
			[Cpp2IlInjected.Address(Slot = "4")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x14000005")]
		event Action<GiftPackageReceivedArgs> WUKHAWGHNRY;

		[Cpp2IlInjected.Token(Token = "0x14000006")]
		event Action<GiftPackage> NQTYHJWOTQX;

		[Cpp2IlInjected.Token(Token = "0x6000249")]
		[Cpp2IlInjected.Address(Slot = "5")]
		NFPDGBDVXFD BKGIWPODMCM(GiftPackage a);

		[Cpp2IlInjected.Token(Token = "0x600024A")]
		[Cpp2IlInjected.Address(Slot = "6")]
		Task ALDVQOSHWSY(GiftPackage a);

		[Cpp2IlInjected.Token(Token = "0x600024B")]
		[Cpp2IlInjected.Address(Slot = "7")]
		[Obsolete("Alternate gift contexts are being phased out. Use LocalRequestGiftPackage(GiftContext context, string message) instead")]
		CCAFLELIKTY<GiftPackage> IBBJHFLFEZD(GiftContext a, GiftContext? b, bool c, string d);

		[Cpp2IlInjected.Token(Token = "0x600024C")]
		[Cpp2IlInjected.Address(Slot = "8")]
		CCAFLELIKTY<GiftPackage> IBBJHFLFEZD(GiftContext a, string b);

		[Cpp2IlInjected.Token(Token = "0x600024D")]
		[Cpp2IlInjected.Address(Slot = "9")]
		void KHLTYKJXICI(GiftPackage a, bool b = false, bool c = false, bool d = true);

		[Cpp2IlInjected.Token(Token = "0x600024E")]
		[Cpp2IlInjected.Address(Slot = "10")]
		CCAFLELIKTY<List<GiftPackage>> SQEJOQYLNTI();
	}
	[Cpp2IlInjected.Token(Token = "0x2000056")]
	public interface YCDXYXCCHES
	{
		[Cpp2IlInjected.Token(Token = "0x17000109")]
		string BOIVWGFETRG
		{
			[Cpp2IlInjected.Token(Token = "0x6000253")]
			[Cpp2IlInjected.Address(Slot = "4")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x1700010A")]
		bool NRNZZRQLGDN
		{
			[Cpp2IlInjected.Token(Token = "0x6000254")]
			[Cpp2IlInjected.Address(Slot = "5")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x600024F")]
		[Cpp2IlInjected.Address(Slot = "0")]
		NFPDGBDVXFD KIMILLSTKSR();

		[Cpp2IlInjected.Token(Token = "0x6000250")]
		[Cpp2IlInjected.Address(Slot = "1")]
		NFPDGBDVXFD YRYQGVUVVEA(string a, string b);

		[Cpp2IlInjected.Token(Token = "0x6000251")]
		[Cpp2IlInjected.Address(Slot = "2")]
		NFPDGBDVXFD SOQHSZOIESQ(string a);

		[Cpp2IlInjected.Token(Token = "0x6000252")]
		[Cpp2IlInjected.Address(Slot = "3")]
		void JTEHHXCXVYI();

		[Cpp2IlInjected.Token(Token = "0x6000255")]
		[Cpp2IlInjected.Address(Slot = "6")]
		Task<LoginResult> YHETRIBGPOS(string a, string b, bool c, string d, string e, [Optional] CancellationToken f);

		[Cpp2IlInjected.Token(Token = "0x6000256")]
		[Cpp2IlInjected.Address(Slot = "7")]
		Task BWDRTJLAZXP(int a, string b, [Optional] CancellationToken c);

		[Cpp2IlInjected.Token(Token = "0x6000257")]
		[Cpp2IlInjected.Address(Slot = "8")]
		Task QJYBULWSCDG(int a, [Optional] CancellationToken b);

		[Cpp2IlInjected.Token(Token = "0x6000258")]
		[Cpp2IlInjected.Address(Slot = "9")]
		Task WAXKFCZJJJG([Optional] TestAccountAuthRole? a, [Optional] CancellationToken b);

		[Cpp2IlInjected.Token(Token = "0x6000259")]
		[Cpp2IlInjected.Address(Slot = "10")]
		Task<IReadOnlyList<FFKTLYRIXRZ>> QWMWXFZEREF([Optional] CancellationToken a);

		[Cpp2IlInjected.Token(Token = "0x600025A")]
		[Cpp2IlInjected.Address(Slot = "11")]
		Task FNUPJNAZZKG([Optional] CancellationToken a);
	}
	[Cpp2IlInjected.Token(Token = "0x2000057")]
	public interface URLEUFHNTQH
	{
		[Cpp2IlInjected.Token(Token = "0x600025B")]
		[Cpp2IlInjected.Address(Slot = "0")]
		Task GYCXNZBBOZN([Optional] CancellationToken a);

		[Cpp2IlInjected.Token(Token = "0x600025C")]
		[Cpp2IlInjected.Address(Slot = "1")]
		void Disconnect();
	}
	[Cpp2IlInjected.Token(Token = "0x2000058")]
	public interface DSJAHZDUFHB
	{
		[Cpp2IlInjected.Token(Token = "0x14000007")]
		event OutfitEvent? PEJDGTTCMTV;

		[Cpp2IlInjected.Token(Token = "0x14000008")]
		event OutfitEvent? EDMAQREDGFP;

		[Cpp2IlInjected.Token(Token = "0x14000009")]
		event OutfitEvent? BDQURRWJWZT;

		[Cpp2IlInjected.Token(Token = "0x6000263")]
		[Cpp2IlInjected.Address(Slot = "6")]
		Task<OutfitDTO> USQTUTPGTGJ();

		[Cpp2IlInjected.Token(Token = "0x6000264")]
		[Cpp2IlInjected.Address(Slot = "7")]
		Task<OutfitDTO?>? ENPKDVYWJQQ(int a);

		[Cpp2IlInjected.Token(Token = "0x6000265")]
		[Cpp2IlInjected.Address(Slot = "8")]
		bool UREAWDWTLSP(int a);

		[Cpp2IlInjected.Token(Token = "0x6000266")]
		[Cpp2IlInjected.Address(Slot = "9")]
		Task<List<RMXOMVSLPVV>> MFSCEGBJVYQ(List<int> a);

		[Cpp2IlInjected.Token(Token = "0x6000267")]
		[Cpp2IlInjected.Address(Slot = "10")]
		Task<IReadOnlyDictionary<int, OutfitDTO>> KOGPSPDCWWE();

		[Cpp2IlInjected.Token(Token = "0x6000268")]
		[Cpp2IlInjected.Address(Slot = "11")]
		Task<List<OutfitDTO?>?>? UOBPNZBFRBN(int a);

		[Cpp2IlInjected.Token(Token = "0x6000269")]
		[Cpp2IlInjected.Address(Slot = "12")]
		Task KTFOBRXBJAI(int a);

		[Cpp2IlInjected.Token(Token = "0x600026A")]
		[Cpp2IlInjected.Address(Slot = "13")]
		Task<RecNetResult> LVHNCRRVWUX(OutfitDTO a);
	}
	[Cpp2IlInjected.Token(Token = "0x2000059")]
	public delegate void OutfitEvent(int accountId, int slot, OutfitDTO? outfit);
	[Cpp2IlInjected.Token(Token = "0x200005A")]
	public interface AEYGYTPBEBO : BLCQZUNHWKD, GOUYYJUDEMP
	{
		[Cpp2IlInjected.Token(Token = "0x200005B")]
		[Flags]
		public enum SanitizeMode
		{
			[Cpp2IlInjected.Token(Token = "0x4000113")]
			FilterProfanity = 1,
			[Cpp2IlInjected.Token(Token = "0x4000114")]
			FilterURL = 2
		}

		[Cpp2IlInjected.Token(Token = "0x1700010B")]
		string UHNOCEGTSOO
		{
			[Cpp2IlInjected.Token(Token = "0x600026F")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x1700010C")]
		DeviceClass YQFQZDQZRKJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000270")]
			[Cpp2IlInjected.Address(Slot = "1")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x1700010D")]
		PlatformType AIMOXFWYTTU
		{
			[Cpp2IlInjected.Token(Token = "0x6000271")]
			[Cpp2IlInjected.Address(Slot = "2")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x1700010E")]
		string LAQRTKCMDXR
		{
			[Cpp2IlInjected.Token(Token = "0x6000272")]
			[Cpp2IlInjected.Address(Slot = "3")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x1700010F")]
		byte NUBPLTZNLTJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000275")]
			[Cpp2IlInjected.Address(Slot = "6")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000110")]
		int RWLWWFNJHQS
		{
			[Cpp2IlInjected.Token(Token = "0x6000276")]
			[Cpp2IlInjected.Address(Slot = "7")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000111")]
		int QQYAWXGYSSM
		{
			[Cpp2IlInjected.Token(Token = "0x6000277")]
			[Cpp2IlInjected.Address(Slot = "8")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000112")]
		bool NKPOTTFCIXJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000278")]
			[Cpp2IlInjected.Address(Slot = "9")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000113")]
		bool PWHLIOGGHAN
		{
			[Cpp2IlInjected.Token(Token = "0x6000279")]
			[Cpp2IlInjected.Address(Slot = "10")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000114")]
		bool CBWNHSGMFZY
		{
			[Cpp2IlInjected.Token(Token = "0x600027A")]
			[Cpp2IlInjected.Address(Slot = "11")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000115")]
		bool PKJBCFIRGNU
		{
			[Cpp2IlInjected.Token(Token = "0x600027B")]
			[Cpp2IlInjected.Address(Slot = "12")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000116")]
		bool HXQWXDZQVRC
		{
			[Cpp2IlInjected.Token(Token = "0x600027C")]
			[Cpp2IlInjected.Address(Slot = "13")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000117")]
		bool DHVWCORPWMS
		{
			[Cpp2IlInjected.Token(Token = "0x600027D")]
			[Cpp2IlInjected.Address(Slot = "14")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000118")]
		bool CDPPYQOZXTB
		{
			[Cpp2IlInjected.Token(Token = "0x6000285")]
			[Cpp2IlInjected.Address(Slot = "22")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x6000273")]
		[Cpp2IlInjected.Address(Slot = "4")]
		CCAFLELIKTY<string> RPABYLJFSPH();

		[Cpp2IlInjected.Token(Token = "0x6000274")]
		[Cpp2IlInjected.Address(Slot = "5")]
		Task<string> EZEQHTECDFP();

		[Cpp2IlInjected.Token(Token = "0x600027E")]
		[Cpp2IlInjected.Address(Slot = "15")]
		CCAFLELIKTY<bool> UAZWZFFJZDH(int a);

		[Cpp2IlInjected.Token(Token = "0x600027F")]
		[Cpp2IlInjected.Address(Slot = "16")]
		string CDYOEHCMXPM(string a, bool b = true);

		[Cpp2IlInjected.Token(Token = "0x6000280")]
		[Cpp2IlInjected.Address(Slot = "17")]
		Task<string> EWUYQEAKQRI(string a, bool b = true);

		[Cpp2IlInjected.Token(Token = "0x6000281")]
		[Cpp2IlInjected.Address(Slot = "18")]
		CCAFLELIKTY<string> MakeRoomNameAdhereToPlatformRequirements(long roomId, string name);

		[Cpp2IlInjected.Token(Token = "0x6000282")]
		[Cpp2IlInjected.Address(Slot = "19")]
		bool SanitizeDisplayText(string displayText, SanitizeMode sanitizeMode = SanitizeMode.FilterProfanity | SanitizeMode.FilterURL);

		[Cpp2IlInjected.Token(Token = "0x6000283")]
		[Cpp2IlInjected.Address(Slot = "20")]
		Task<string> SanitizeDisplayTextAsync(string displayText, SanitizeMode sanitizeMode = SanitizeMode.FilterProfanity | SanitizeMode.FilterURL, bool isChat = false);

		[Cpp2IlInjected.Token(Token = "0x6000284")]
		[Cpp2IlInjected.Address(Slot = "21")]
		bool CheckNameForProfanity(string name, SanitizeMode sanitizeMode = SanitizeMode.FilterProfanity | SanitizeMode.FilterURL);

		[Cpp2IlInjected.Token(Token = "0x6000286")]
		[Cpp2IlInjected.Address(Slot = "23")]
		CCAFLELIKTY<string> GetCommerceSubscriptionAccessToken();
	}
	[Cpp2IlInjected.Token(Token = "0x200005C")]
	public interface MGDBTSNGMCT
	{
		[Cpp2IlInjected.Token(Token = "0x17000119")]
		ASNKAFBFVVA<PurchasableXpBoostActivationDTO> MMLQUSFFVNR
		{
			[Cpp2IlInjected.Token(Token = "0x6000287")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x6000288")]
		[Cpp2IlInjected.Address(Slot = "1")]
		void OBIEGUWIDOT();

		[Cpp2IlInjected.Token(Token = "0x6000289")]
		[Cpp2IlInjected.Address(Slot = "2")]
		Task<VCCRUZAMKGW<PurchasableXpBoostActivationDTO>> KPJIAQWCJZS(CancellationToken a);

		[Cpp2IlInjected.Token(Token = "0x600028A")]
		[Cpp2IlInjected.Address(Slot = "3")]
		void ICETNIWAGJL();
	}
	[Cpp2IlInjected.Token(Token = "0x200005D")]
	public interface ZDVCTILXEKL
	{
		[Cpp2IlInjected.Token(Token = "0x600028B")]
		[Cpp2IlInjected.Address(Slot = "0")]
		Task<PurchasePromotionDTO> NTSQTRGEHWQ(PurchaseItemRequestDTO a, CurrencyType b, [Optional] CancellationToken c);
	}
	[Cpp2IlInjected.Token(Token = "0x200005E")]
	[Utf8JsonSerializable]
	public class PurchasePromotionDTO
	{
		[Cpp2IlInjected.Token(Token = "0x1700011A")]
		public PurchasePromotionType Type
		{
			[Cpp2IlInjected.Token(Token = "0x600028C")]
			[Cpp2IlInjected.Address(RVA = "0xD0F110", Offset = "0xD0DB10", VA = "0x180D0F110")]
			[CompilerGenerated]
			get
			{
				return default(PurchasePromotionType);
			}
			[Cpp2IlInjected.Token(Token = "0x600028D")]
			[Cpp2IlInjected.Address(RVA = "0xD12F30", Offset = "0xD11930", VA = "0x180D12F30")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700011B")]
		public StarterPackPromotionDTO? StarterPackPromotion
		{
			[Cpp2IlInjected.Token(Token = "0x600028E")]
			[Cpp2IlInjected.Address(RVA = "0xD11B30", Offset = "0xD10530", VA = "0x180D11B30")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600028F")]
			[Cpp2IlInjected.Address(RVA = "0xD12270", Offset = "0xD10C70", VA = "0x180D12270")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700011C")]
		public FreeItemsWithRRPlusPromotionDTO? FreeItemsWithRRPlusPromotion
		{
			[Cpp2IlInjected.Token(Token = "0x6000290")]
			[Cpp2IlInjected.Address(RVA = "0xD12BC0", Offset = "0xD115C0", VA = "0x180D12BC0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000291")]
			[Cpp2IlInjected.Address(RVA = "0xD11520", Offset = "0xD0FF20", VA = "0x180D11520")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700011D")]
		public LimitedTimeDiscountPromotionDTO? LimitedTimeDiscountPromotion
		{
			[Cpp2IlInjected.Token(Token = "0x6000292")]
			[Cpp2IlInjected.Address(RVA = "0xD11B00", Offset = "0xD10500", VA = "0x180D11B00")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000293")]
			[Cpp2IlInjected.Address(RVA = "0xD11530", Offset = "0xD0FF30", VA = "0x180D11530")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700011E")]
		public PurchaseCampaignPromotionDTO? PurchaseCampaignPromotion
		{
			[Cpp2IlInjected.Token(Token = "0x6000294")]
			[Cpp2IlInjected.Address(RVA = "0xD11A20", Offset = "0xD10420", VA = "0x180D11A20")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000295")]
			[Cpp2IlInjected.Address(RVA = "0xD17350", Offset = "0xD15D50", VA = "0x180D17350")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000296")]
		[Cpp2IlInjected.Address(RVA = "0xD16C40", Offset = "0xD15640", VA = "0x180D16C40")]
		public PurchasePromotionDTO()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200005F")]
	public enum PurchasePromotionType
	{
		[Cpp2IlInjected.Token(Token = "0x400011B")]
		StarterPack,
		[Cpp2IlInjected.Token(Token = "0x400011C")]
		FreeItemsWithRRPlus,
		[Cpp2IlInjected.Token(Token = "0x400011D")]
		LimitedTimeDiscount,
		[Cpp2IlInjected.Token(Token = "0x400011E")]
		PurchaseCampaign
	}
	[Cpp2IlInjected.Token(Token = "0x2000060")]
	[Utf8JsonSerializable]
	public class StarterPackPromotionDTO
	{
		[Cpp2IlInjected.Token(Token = "0x1700011F")]
		public int PurchaseReminderId
		{
			[Cpp2IlInjected.Token(Token = "0x6000297")]
			[Cpp2IlInjected.Address(RVA = "0xD0F110", Offset = "0xD0DB10", VA = "0x180D0F110")]
			[CompilerGenerated]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x6000298")]
			[Cpp2IlInjected.Address(RVA = "0xD12F30", Offset = "0xD11930", VA = "0x180D12F30")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000120")]
		public List<ItemPurchaseMethodId> BonusItemIds
		{
			[Cpp2IlInjected.Token(Token = "0x6000299")]
			[Cpp2IlInjected.Address(RVA = "0xD11B30", Offset = "0xD10530", VA = "0x180D11B30")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600029A")]
			[Cpp2IlInjected.Address(RVA = "0xD12270", Offset = "0xD10C70", VA = "0x180D12270")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600029B")]
		[Cpp2IlInjected.Address(RVA = "0xD16C40", Offset = "0xD15640", VA = "0x180D16C40")]
		public StarterPackPromotionDTO()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000061")]
	[Utf8JsonSerializable]
	public class FreeItemsWithRRPlusPromotionDTO
	{
		[Cpp2IlInjected.Token(Token = "0x17000121")]
		public int RRPlusSignUpBonusId
		{
			[Cpp2IlInjected.Token(Token = "0x600029C")]
			[Cpp2IlInjected.Address(RVA = "0xD0F110", Offset = "0xD0DB10", VA = "0x180D0F110")]
			[CompilerGenerated]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x600029D")]
			[Cpp2IlInjected.Address(RVA = "0xD12F30", Offset = "0xD11930", VA = "0x180D12F30")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000122")]
		public List<ItemPurchaseMethodId> BonusItemIds
		{
			[Cpp2IlInjected.Token(Token = "0x600029E")]
			[Cpp2IlInjected.Address(RVA = "0xD11B30", Offset = "0xD10530", VA = "0x180D11B30")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600029F")]
			[Cpp2IlInjected.Address(RVA = "0xD12270", Offset = "0xD10C70", VA = "0x180D12270")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60002A0")]
		[Cpp2IlInjected.Address(RVA = "0xD16C40", Offset = "0xD15640", VA = "0x180D16C40")]
		public FreeItemsWithRRPlusPromotionDTO()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000062")]
	public enum LimitedTimeDiscountPromotionType
	{
		[Cpp2IlInjected.Token(Token = "0x4000124")]
		PercentOff,
		[Cpp2IlInjected.Token(Token = "0x4000125")]
		SetPrice
	}
	[Cpp2IlInjected.Token(Token = "0x2000063")]
	[Utf8JsonSerializable]
	public class LimitedTimeDiscountPromotionDTO
	{
		[Cpp2IlInjected.Token(Token = "0x17000123")]
		public LimitedTimeDiscountPromotionType Type
		{
			[Cpp2IlInjected.Token(Token = "0x60002A1")]
			[Cpp2IlInjected.Address(RVA = "0xD0F110", Offset = "0xD0DB10", VA = "0x180D0F110")]
			[CompilerGenerated]
			get
			{
				return default(LimitedTimeDiscountPromotionType);
			}
			[Cpp2IlInjected.Token(Token = "0x60002A2")]
			[Cpp2IlInjected.Address(RVA = "0xD12F30", Offset = "0xD11930", VA = "0x180D12F30")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000124")]
		public decimal? PercentOff
		{
			[Cpp2IlInjected.Token(Token = "0x60002A3")]
			[Cpp2IlInjected.Address(RVA = "0x12EAD00", Offset = "0x12E9700", VA = "0x1812EAD00")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60002A4")]
			[Cpp2IlInjected.Address(RVA = "0x7B62210", Offset = "0x7B60C10", VA = "0x187B62210")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000125")]
		public int? SetPrice
		{
			[Cpp2IlInjected.Token(Token = "0x60002A5")]
			[Cpp2IlInjected.Address(RVA = "0xD11A20", Offset = "0xD10420", VA = "0x180D11A20")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60002A6")]
			[Cpp2IlInjected.Address(RVA = "0xD118E0", Offset = "0xD102E0", VA = "0x180D118E0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000126")]
		public int DurationInMinutes
		{
			[Cpp2IlInjected.Token(Token = "0x60002A7")]
			[Cpp2IlInjected.Address(RVA = "0xD40260", Offset = "0xD3EC60", VA = "0x180D40260")]
			[CompilerGenerated]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x60002A8")]
			[Cpp2IlInjected.Address(RVA = "0xE27B10", Offset = "0xE26510", VA = "0x180E27B10")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000127")]
		public DateTime? EndsAt
		{
			[Cpp2IlInjected.Token(Token = "0x60002A9")]
			[Cpp2IlInjected.Address(RVA = "0x10ABB70", Offset = "0x10AA570", VA = "0x1810ABB70")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60002AA")]
			[Cpp2IlInjected.Address(RVA = "0x10ABCC0", Offset = "0x10AA6C0", VA = "0x1810ABCC0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000128")]
		public TimeSpan Duration
		{
			[Cpp2IlInjected.Token(Token = "0x60002AB")]
			[Cpp2IlInjected.Address(RVA = "0x8DC2B70", Offset = "0x8DC1570", VA = "0x188DC2B70")]
			get
			{
				return default(TimeSpan);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60002AC")]
		[Cpp2IlInjected.Address(RVA = "0xD16C40", Offset = "0xD15640", VA = "0x180D16C40")]
		public LimitedTimeDiscountPromotionDTO()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000064")]
	[Utf8JsonSerializable]
	public class PurchaseCampaignPromotionDTO
	{
		[Cpp2IlInjected.Token(Token = "0x17000129")]
		public int PurchaseCampaignId
		{
			[Cpp2IlInjected.Token(Token = "0x60002AD")]
			[Cpp2IlInjected.Address(RVA = "0xD0F110", Offset = "0xD0DB10", VA = "0x180D0F110")]
			[CompilerGenerated]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x60002AE")]
			[Cpp2IlInjected.Address(RVA = "0xD12F30", Offset = "0xD11930", VA = "0x180D12F30")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700012A")]
		public List<GrantableId?> BonusSelectableGrantableIds
		{
			[Cpp2IlInjected.Token(Token = "0x60002AF")]
			[Cpp2IlInjected.Address(RVA = "0xD11B30", Offset = "0xD10530", VA = "0x180D11B30")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60002B0")]
			[Cpp2IlInjected.Address(RVA = "0xD12270", Offset = "0xD10C70", VA = "0x180D12270")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60002B1")]
		[Cpp2IlInjected.Address(RVA = "0xD16C40", Offset = "0xD15640", VA = "0x180D16C40")]
		public PurchaseCampaignPromotionDTO()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000065")]
	public interface MANRYZMAIGP
	{
		[Cpp2IlInjected.Token(Token = "0x60002B2")]
		[Cpp2IlInjected.Address(Slot = "0")]
		Task<List<RefereeFileReferenceDTO>> TBHUAZYODXB([Optional] CancellationToken a);
	}
	[Cpp2IlInjected.Token(Token = "0x2000066")]
	public interface IZLQVEIXCOT
	{
		[Cpp2IlInjected.Token(Token = "0x60002B3")]
		[Cpp2IlInjected.Address(Slot = "0")]
		bool ZQPEYSVESYC(byte[] a, byte[] b);
	}
	[Cpp2IlInjected.Token(Token = "0x2000067")]
	public interface XOZEDQHXKBU
	{
		[Cpp2IlInjected.Token(Token = "0x60002B4")]
		[Cpp2IlInjected.Address(Slot = "0")]
		Task ANWDHUEFWQJ(string a);
	}
	[Cpp2IlInjected.Token(Token = "0x2000068")]
	public interface ASRIEYXXDEQ
	{
		[Cpp2IlInjected.Token(Token = "0x60002B5")]
		[Cpp2IlInjected.Address(Slot = "0")]
		Task<List<RecNetResultObject<FilteredTextDTO>>> FPIIYJRRMFQ(uint a, IEnumerable<string> b);
	}
	[Cpp2IlInjected.Token(Token = "0x2000069")]
	public interface ADNFNFFDZZK
	{
		[Cpp2IlInjected.Token(Token = "0x60002B6")]
		[Cpp2IlInjected.Address(Slot = "0")]
		bool OXCLDGWJMVY([Out] bool a);

		[Cpp2IlInjected.Token(Token = "0x60002B7")]
		[Cpp2IlInjected.Address(Slot = "1")]
		bool OBTLWRAUTAN([Out] bool a);

		[Cpp2IlInjected.Token(Token = "0x60002B8")]
		[Cpp2IlInjected.Address(Slot = "2")]
		bool SPMBGPQIVED([Out] int a);

		[Cpp2IlInjected.Token(Token = "0x60002B9")]
		[Cpp2IlInjected.Address(Slot = "3")]
		bool LGNCAXFNCRS([Out] bool a);
	}
	[Cpp2IlInjected.Token(Token = "0x200006A")]
	public enum JuniorState
	{
		[Cpp2IlInjected.Token(Token = "0x400012E")]
		BasedOnBirthday,
		[Cpp2IlInjected.Token(Token = "0x400012F")]
		ModerationOverride,
		[Cpp2IlInjected.Token(Token = "0x4000130")]
		PendingOverride
	}
	[Cpp2IlInjected.Token(Token = "0x200006B")]
	public enum PlatformDetailType
	{
		[Cpp2IlInjected.Token(Token = "0x4000132")]
		Id,
		[Cpp2IlInjected.Token(Token = "0x4000133")]
		Email,
		[Cpp2IlInjected.Token(Token = "0x4000134")]
		Phone
	}
	[Cpp2IlInjected.Token(Token = "0x200006C")]
	[Flags]
	public enum PersonalPronouns
	{
		[Cpp2IlInjected.Token(Token = "0x4000136")]
		None = 0,
		[Cpp2IlInjected.Token(Token = "0x4000137")]
		SheHer = 1,
		[Cpp2IlInjected.Token(Token = "0x4000138")]
		HeHim = 2,
		[Cpp2IlInjected.Token(Token = "0x4000139")]
		TheyThem = 4,
		[Cpp2IlInjected.Token(Token = "0x400013A")]
		ZeHir = 8,
		[Cpp2IlInjected.Token(Token = "0x400013B")]
		ZeZir = 0x10,
		[Cpp2IlInjected.Token(Token = "0x400013C")]
		XeXem = 0x20
	}
	[Cpp2IlInjected.Token(Token = "0x200006D")]
	[Flags]
	public enum IdentityFlags
	{
		[Cpp2IlInjected.Token(Token = "0x400013E")]
		None = 0,
		[Cpp2IlInjected.Token(Token = "0x400013F")]
		LGBTQIA = 1,
		[Cpp2IlInjected.Token(Token = "0x4000140")]
		Transgender = 2,
		[Cpp2IlInjected.Token(Token = "0x4000141")]
		Bisexual = 4,
		[Cpp2IlInjected.Token(Token = "0x4000142")]
		Lesbian = 8,
		[Cpp2IlInjected.Token(Token = "0x4000143")]
		Pansexual = 0x10,
		[Cpp2IlInjected.Token(Token = "0x4000144")]
		Asexual = 0x20,
		[Cpp2IlInjected.Token(Token = "0x4000145")]
		Intersex = 0x40,
		[Cpp2IlInjected.Token(Token = "0x4000146")]
		Genderqueer = 0x80,
		[Cpp2IlInjected.Token(Token = "0x4000147")]
		Nonbinary = 0x100,
		[Cpp2IlInjected.Token(Token = "0x4000148")]
		Aromantic = 0x200
	}
	[Cpp2IlInjected.Token(Token = "0x200006E")]
	public enum EmailFrequencyPreference
	{
		[Cpp2IlInjected.Token(Token = "0x400014A")]
		Daily = 10,
		[Cpp2IlInjected.Token(Token = "0x400014B")]
		Weekly = 20,
		[Cpp2IlInjected.Token(Token = "0x400014C")]
		Monthly = 30,
		[Cpp2IlInjected.Token(Token = "0x400014D")]
		Never = 40,
		[Cpp2IlInjected.Token(Token = "0x400014E")]
		Yes = 50
	}
	[Cpp2IlInjected.Token(Token = "0x200006F")]
	public enum AccountAgeBucket
	{
		[Cpp2IlInjected.Token(Token = "0x4000150")]
		BELOW_TEN = 0,
		[Cpp2IlInjected.Token(Token = "0x4000151")]
		BETWEEN_TEN_AND_TWELVE = 10,
		[Cpp2IlInjected.Token(Token = "0x4000152")]
		TEEN = 13,
		[Cpp2IlInjected.Token(Token = "0x4000153")]
		ADULT = 18,
		[Cpp2IlInjected.Token(Token = "0x4000154")]
		UNKNOWN = 999
	}
	[Cpp2IlInjected.Token(Token = "0x2000070")]
	public interface QZBSYAZDSCL
	{
		[Cpp2IlInjected.Token(Token = "0x1700012B")]
		int AccountId
		{
			[Cpp2IlInjected.Token(Token = "0x60002BA")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x1700012C")]
		string RawUsername
		{
			[Cpp2IlInjected.Token(Token = "0x60002BB")]
			[Cpp2IlInjected.Address(Slot = "1")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x1700012D")]
		string Username
		{
			[Cpp2IlInjected.Token(Token = "0x60002BC")]
			[Cpp2IlInjected.Address(Slot = "2")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x1700012E")]
		string DisplayName
		{
			[Cpp2IlInjected.Token(Token = "0x60002BD")]
			[Cpp2IlInjected.Address(Slot = "3")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x1700012F")]
		string DisplayEmoji
		{
			[Cpp2IlInjected.Token(Token = "0x60002BE")]
			[Cpp2IlInjected.Address(Slot = "4")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000130")]
		string ProfileImage
		{
			[Cpp2IlInjected.Token(Token = "0x60002BF")]
			[Cpp2IlInjected.Address(Slot = "5")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000131")]
		string BannerImage
		{
			[Cpp2IlInjected.Token(Token = "0x60002C0")]
			[Cpp2IlInjected.Address(Slot = "6")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000132")]
		bool TreatAsJunior
		{
			[Cpp2IlInjected.Token(Token = "0x60002C1")]
			[Cpp2IlInjected.Address(Slot = "7")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000133")]
		bool HasBirthday
		{
			[Cpp2IlInjected.Token(Token = "0x60002C2")]
			[Cpp2IlInjected.Address(Slot = "8")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000134")]
		PersonalPronouns PersonalPronouns
		{
			[Cpp2IlInjected.Token(Token = "0x60002C3")]
			[Cpp2IlInjected.Address(Slot = "9")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000135")]
		IdentityFlags IdentityFlags
		{
			[Cpp2IlInjected.Token(Token = "0x60002C4")]
			[Cpp2IlInjected.Address(Slot = "10")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000136")]
		DateTime CreatedAt
		{
			[Cpp2IlInjected.Token(Token = "0x60002C5")]
			[Cpp2IlInjected.Address(Slot = "11")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000137")]
		bool? IsJunior
		{
			[Cpp2IlInjected.Token(Token = "0x60002C6")]
			[Cpp2IlInjected.Address(Slot = "12")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x60002C7")]
		[Cpp2IlInjected.Address(Slot = "13")]
		void NAKWTIHTGPA(bool a);

		[Cpp2IlInjected.Token(Token = "0x60002C8")]
		[Cpp2IlInjected.Address(Slot = "14")]
		void SCMNDSACKAR(bool a);
	}
	[Cpp2IlInjected.Token(Token = "0x2000071")]
	public interface AYYMXEZIWGB : QZBSYAZDSCL
	{
		[Cpp2IlInjected.Token(Token = "0x17000138")]
		string Email
		{
			[Cpp2IlInjected.Token(Token = "0x60002C9")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000139")]
		string Phone
		{
			[Cpp2IlInjected.Token(Token = "0x60002CA")]
			[Cpp2IlInjected.Address(Slot = "1")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x1700013A")]
		DateTime? Birthday
		{
			[Cpp2IlInjected.Token(Token = "0x60002CB")]
			[Cpp2IlInjected.Address(Slot = "2")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x1700013B")]
		JuniorState JuniorState
		{
			[Cpp2IlInjected.Token(Token = "0x60002CC")]
			[Cpp2IlInjected.Address(Slot = "3")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x1700013C")]
		int? ParentAccountId
		{
			[Cpp2IlInjected.Token(Token = "0x60002CD")]
			[Cpp2IlInjected.Address(Slot = "4")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x1700013D")]
		int AvailableUsernameChanges
		{
			[Cpp2IlInjected.Token(Token = "0x60002CE")]
			[Cpp2IlInjected.Address(Slot = "5")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x1700013E")]
		bool CanChangeUsername
		{
			[Cpp2IlInjected.Token(Token = "0x60002CF")]
			[Cpp2IlInjected.Address(Slot = "6")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x1700013F")]
		bool IsConfirmed
		{
			[Cpp2IlInjected.Token(Token = "0x60002D0")]
			[Cpp2IlInjected.Address(Slot = "7")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000140")]
		bool? IsFakeJuniorBirthday
		{
			[Cpp2IlInjected.Token(Token = "0x60002D1")]
			[Cpp2IlInjected.Address(Slot = "8")]
			get;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000072")]
	public class KKPGMZCEPWC
	{
		[Cpp2IlInjected.Token(Token = "0x17000141")]
		public QZBSYAZDSCL MEXTXUFOEDK
		{
			[Cpp2IlInjected.Token(Token = "0x60002D2")]
			[Cpp2IlInjected.Address(RVA = "0xD117B0", Offset = "0xD101B0", VA = "0x180D117B0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000142")]
		public PlatformDetailType MFLIUBWKEEP
		{
			[Cpp2IlInjected.Token(Token = "0x60002D3")]
			[Cpp2IlInjected.Address(RVA = "0xD17340", Offset = "0xD15D40", VA = "0x180D17340")]
			[CompilerGenerated]
			get
			{
				return default(PlatformDetailType);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000143")]
		public string RKBYSPTFOHJ
		{
			[Cpp2IlInjected.Token(Token = "0x60002D4")]
			[Cpp2IlInjected.Address(RVA = "0xD12BC0", Offset = "0xD115C0", VA = "0x180D12BC0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60002D5")]
		[Cpp2IlInjected.Address(RVA = "0x8BCDB70", Offset = "0x8BCC570", VA = "0x188BCDB70")]
		public KKPGMZCEPWC(QZBSYAZDSCL a, PlatformDetailType b, string c)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000073")]
	public interface FZYGFTWCFOW
	{
		[Cpp2IlInjected.Token(Token = "0x17000144")]
		int AccountId
		{
			[Cpp2IlInjected.Token(Token = "0x60002D6")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000145")]
		bool DisallowInAppPurchases
		{
			[Cpp2IlInjected.Token(Token = "0x60002D7")]
			[Cpp2IlInjected.Address(Slot = "1")]
			get;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000074")]
	public interface VITMOCIBFCU
	{
		[Cpp2IlInjected.Token(Token = "0x17000146")]
		int AccountId
		{
			[Cpp2IlInjected.Token(Token = "0x60002D8")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000147")]
		bool IsRecentHistoryVisible
		{
			[Cpp2IlInjected.Token(Token = "0x60002D9")]
			[Cpp2IlInjected.Address(Slot = "1")]
			get;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000075")]
	public interface PUGSTEVDQDF
	{
		[Cpp2IlInjected.Token(Token = "0x17000148")]
		int AccountId
		{
			[Cpp2IlInjected.Token(Token = "0x60002DA")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000149")]
		string Bio
		{
			[Cpp2IlInjected.Token(Token = "0x60002DB")]
			[Cpp2IlInjected.Address(Slot = "1")]
			get;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000076")]
	public enum AvatarItemType
	{
		[Cpp2IlInjected.Token(Token = "0x4000159")]
		Outfit,
		[Cpp2IlInjected.Token(Token = "0x400015A")]
		HairDye,
		[Cpp2IlInjected.Token(Token = "0x400015B")]
		CustomOutfit
	}
	[Cpp2IlInjected.Token(Token = "0x2000077")]
	public class OKPWATORVQQ
	{
		[Cpp2IlInjected.Token(Token = "0x1700014A")]
		public AvatarItemType RIBZZNJIBFZ
		{
			[Cpp2IlInjected.Token(Token = "0x60002DC")]
			[Cpp2IlInjected.Address(RVA = "0xD0F110", Offset = "0xD0DB10", VA = "0x180D0F110")]
			[CompilerGenerated]
			get
			{
				return default(AvatarItemType);
			}
			[Cpp2IlInjected.Token(Token = "0x60002DD")]
			[Cpp2IlInjected.Address(RVA = "0xD12F30", Offset = "0xD11930", VA = "0x180D12F30")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700014B")]
		public string VXUBJNZPMVX
		{
			[Cpp2IlInjected.Token(Token = "0x60002DE")]
			[Cpp2IlInjected.Address(RVA = "0xD11B30", Offset = "0xD10530", VA = "0x180D11B30")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60002DF")]
			[Cpp2IlInjected.Address(RVA = "0xD12270", Offset = "0xD10C70", VA = "0x180D12270")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700014C")]
		public string QIAJPKTZCAU
		{
			[Cpp2IlInjected.Token(Token = "0x60002E0")]
			[Cpp2IlInjected.Address(RVA = "0xD12BC0", Offset = "0xD115C0", VA = "0x180D12BC0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60002E1")]
			[Cpp2IlInjected.Address(RVA = "0xD11520", Offset = "0xD0FF20", VA = "0x180D11520")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700014D")]
		public GiftRarity FHTIGYVOWRE
		{
			[Cpp2IlInjected.Token(Token = "0x60002E2")]
			[Cpp2IlInjected.Address(RVA = "0xD12BE0", Offset = "0xD115E0", VA = "0x180D12BE0")]
			[CompilerGenerated]
			get
			{
				return default(GiftRarity);
			}
			[Cpp2IlInjected.Token(Token = "0x60002E3")]
			[Cpp2IlInjected.Address(RVA = "0xD12C40", Offset = "0xD11640", VA = "0x180D12C40")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700014E")]
		public string SKBLTQVEJZJ
		{
			[Cpp2IlInjected.Token(Token = "0x60002E4")]
			[Cpp2IlInjected.Address(RVA = "0xD11A20", Offset = "0xD10420", VA = "0x180D11A20")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60002E5")]
			[Cpp2IlInjected.Address(RVA = "0xD17350", Offset = "0xD15D50", VA = "0x180D17350")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700014F")]
		public int KPFMPXRPEZY
		{
			[Cpp2IlInjected.Token(Token = "0x60002E6")]
			[Cpp2IlInjected.Address(RVA = "0xD40260", Offset = "0xD3EC60", VA = "0x180D40260")]
			[CompilerGenerated]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x60002E7")]
			[Cpp2IlInjected.Address(RVA = "0xE27B10", Offset = "0xE26510", VA = "0x180E27B10")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000150")]
		public bool OMZPOFUYLZY
		{
			[Cpp2IlInjected.Token(Token = "0x60002E8")]
			[Cpp2IlInjected.Address(RVA = "0xF30200", Offset = "0xF2EC00", VA = "0x180F30200")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x60002E9")]
			[Cpp2IlInjected.Address(RVA = "0xFFBC30", Offset = "0xFFA630", VA = "0x180FFBC30")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000151")]
		public AvatarItemDesc KKEIWAJBSDU
		{
			[Cpp2IlInjected.Token(Token = "0x60002EA")]
			[Cpp2IlInjected.Address(RVA = "0x8DC35A0", Offset = "0x8DC1FA0", VA = "0x188DC35A0")]
			[CompilerGenerated]
			get
			{
				return default(AvatarItemDesc);
			}
			[Cpp2IlInjected.Token(Token = "0x60002EB")]
			[Cpp2IlInjected.Address(RVA = "0x8DC3580", Offset = "0x8DC1F80", VA = "0x188DC3580")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000152")]
		public ColorId ONNYPMGQZXC
		{
			[Cpp2IlInjected.Token(Token = "0x60002EC")]
			[Cpp2IlInjected.Address(RVA = "0x6510250", Offset = "0x650EC50", VA = "0x186510250")]
			[CompilerGenerated]
			get
			{
				return default(ColorId);
			}
			[Cpp2IlInjected.Token(Token = "0x60002ED")]
			[Cpp2IlInjected.Address(RVA = "0x650FA10", Offset = "0x650E410", VA = "0x18650FA10")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000153")]
		public string PNSZHQPDWAW
		{
			[Cpp2IlInjected.Token(Token = "0x60002EE")]
			[Cpp2IlInjected.Address(RVA = "0xD1E850", Offset = "0xD1D250", VA = "0x180D1E850")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60002EF")]
			[Cpp2IlInjected.Address(RVA = "0xD1E840", Offset = "0xD1D240", VA = "0x180D1E840")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000154")]
		public DateTime GHZNQOXDNSS
		{
			[Cpp2IlInjected.Token(Token = "0x60002F0")]
			[Cpp2IlInjected.Address(RVA = "0xD1E900", Offset = "0xD1D300", VA = "0x180D1E900")]
			[CompilerGenerated]
			get
			{
				return default(DateTime);
			}
			[Cpp2IlInjected.Token(Token = "0x60002F1")]
			[Cpp2IlInjected.Address(RVA = "0x777FC00", Offset = "0x777E600", VA = "0x18777FC00")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60002F2")]
		[Cpp2IlInjected.Address(RVA = "0x8DC3700", Offset = "0x8DC2100", VA = "0x188DC3700")]
		internal OKPWATORVQQ(AvatarItemDetails a, BMHIDMYYBYT b, BRWVJCZRHBS c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002F3")]
		[Cpp2IlInjected.Address(RVA = "0x8DC35C0", Offset = "0x8DC1FC0", VA = "0x188DC35C0")]
		public OKPWATORVQQ(AvatarItemType a = AvatarItemType.Outfit, [Optional] AvatarItemDesc b, [Optional] string c, [Optional] string d, GiftRarity e = GiftRarity.Common, [Optional] string f, int g = 0, bool h = false, [Optional] string i, [Optional] DateTime? j)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000078")]
	[Utf8JsonSerializable]
	public class AvatarItemDetails
	{
		[Cpp2IlInjected.Token(Token = "0x17000155")]
		public AvatarItemType AvatarItemType
		{
			[Cpp2IlInjected.Token(Token = "0x60002F4")]
			[Cpp2IlInjected.Address(RVA = "0xD0F110", Offset = "0xD0DB10", VA = "0x180D0F110")]
			[CompilerGenerated]
			get
			{
				return default(AvatarItemType);
			}
			[Cpp2IlInjected.Token(Token = "0x60002F5")]
			[Cpp2IlInjected.Address(RVA = "0xD12F30", Offset = "0xD11930", VA = "0x180D12F30")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000156")]
		[DataMember(Name = "AvatarItemDesc")]
		public string AvatarItemDescString
		{
			[Cpp2IlInjected.Token(Token = "0x60002F6")]
			[Cpp2IlInjected.Address(RVA = "0xD11B30", Offset = "0xD10530", VA = "0x180D11B30")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60002F7")]
			[Cpp2IlInjected.Address(RVA = "0xD12270", Offset = "0xD10C70", VA = "0x180D12270")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000157")]
		public string FriendlyName
		{
			[Cpp2IlInjected.Token(Token = "0x60002F8")]
			[Cpp2IlInjected.Address(RVA = "0xD12BC0", Offset = "0xD115C0", VA = "0x180D12BC0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60002F9")]
			[Cpp2IlInjected.Address(RVA = "0xD11520", Offset = "0xD0FF20", VA = "0x180D11520")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000158")]
		public string Tooltip
		{
			[Cpp2IlInjected.Token(Token = "0x60002FA")]
			[Cpp2IlInjected.Address(RVA = "0xD11B00", Offset = "0xD10500", VA = "0x180D11B00")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60002FB")]
			[Cpp2IlInjected.Address(RVA = "0xD11530", Offset = "0xD0FF30", VA = "0x180D11530")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000159")]
		public GiftRarity Rarity
		{
			[Cpp2IlInjected.Token(Token = "0x60002FC")]
			[Cpp2IlInjected.Address(RVA = "0xD1B6C0", Offset = "0xD1A0C0", VA = "0x180D1B6C0")]
			[CompilerGenerated]
			get
			{
				return default(GiftRarity);
			}
			[Cpp2IlInjected.Token(Token = "0x60002FD")]
			[Cpp2IlInjected.Address(RVA = "0xD1B020", Offset = "0xD19A20", VA = "0x180D1B020")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700015A")]
		public string TagList
		{
			[Cpp2IlInjected.Token(Token = "0x60002FE")]
			[Cpp2IlInjected.Address(RVA = "0xD12280", Offset = "0xD10C80", VA = "0x180D12280")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60002FF")]
			[Cpp2IlInjected.Address(RVA = "0xD11B50", Offset = "0xD10550", VA = "0x180D11B50")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700015B")]
		public int AvatarItemId
		{
			[Cpp2IlInjected.Token(Token = "0x6000300")]
			[Cpp2IlInjected.Address(RVA = "0xD2DD40", Offset = "0xD2C740", VA = "0x180D2DD40")]
			[CompilerGenerated]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x6000301")]
			[Cpp2IlInjected.Address(RVA = "0xD89720", Offset = "0xD88120", VA = "0x180D89720")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700015C")]
		public bool IsBaseAvatarItem
		{
			[Cpp2IlInjected.Token(Token = "0x6000302")]
			[Cpp2IlInjected.Address(RVA = "0x19FA020", Offset = "0x19F8A20", VA = "0x1819FA020")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000303")]
			[Cpp2IlInjected.Address(RVA = "0x19F9DF0", Offset = "0x19F87F0", VA = "0x1819F9DF0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700015D")]
		public string ThumbnailImage
		{
			[Cpp2IlInjected.Token(Token = "0x6000304")]
			[Cpp2IlInjected.Address(RVA = "0xD122E0", Offset = "0xD10CE0", VA = "0x180D122E0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000305")]
			[Cpp2IlInjected.Address(RVA = "0xD12290", Offset = "0xD10C90", VA = "0x180D12290")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700015E")]
		public DateTime CreatedAt
		{
			[Cpp2IlInjected.Token(Token = "0x6000306")]
			[Cpp2IlInjected.Address(RVA = "0xD11B20", Offset = "0xD10520", VA = "0x180D11B20")]
			[CompilerGenerated]
			get
			{
				return default(DateTime);
			}
			[Cpp2IlInjected.Token(Token = "0x6000307")]
			[Cpp2IlInjected.Address(RVA = "0xFFBF90", Offset = "0xFFA990", VA = "0x180FFBF90")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000308")]
		[Cpp2IlInjected.Address(RVA = "0xD16C40", Offset = "0xD15640", VA = "0x180D16C40")]
		public AvatarItemDetails()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000079")]
	[Utf8JsonSerializable]
	public sealed class GetLockedAvatarItemDetailsBulkAsPostRequest
	{
		[Cpp2IlInjected.Token(Token = "0x1700015F")]
		public List<string> AvatarItemDescriptions
		{
			[Cpp2IlInjected.Token(Token = "0x600030B")]
			[Cpp2IlInjected.Address(RVA = "0xD117B0", Offset = "0xD101B0", VA = "0x180D117B0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600030C")]
			[Cpp2IlInjected.Address(RVA = "0xD117C0", Offset = "0xD101C0", VA = "0x180D117C0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000309")]
		[Cpp2IlInjected.Address(RVA = "0x8DC0530", Offset = "0x8DBEF30", VA = "0x188DC0530")]
		public GetLockedAvatarItemDetailsBulkAsPostRequest()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600030A")]
		[Cpp2IlInjected.Address(RVA = "0xD118A0", Offset = "0xD102A0", VA = "0x180D118A0")]
		public GetLockedAvatarItemDetailsBulkAsPostRequest(List<string> avatarItemDescriptions)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200007A")]
	[Utf8JsonSerializable]
	public class CrmAssignmentDTO
	{
		[Cpp2IlInjected.Token(Token = "0x17000160")]
		public CrmUserDTO UserConfig
		{
			[Cpp2IlInjected.Token(Token = "0x600030D")]
			[Cpp2IlInjected.Address(RVA = "0xD117B0", Offset = "0xD101B0", VA = "0x180D117B0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600030E")]
			[Cpp2IlInjected.Address(RVA = "0xD117C0", Offset = "0xD101C0", VA = "0x180D117C0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000161")]
		public BrazeConfigDTO BrazeConfig
		{
			[Cpp2IlInjected.Token(Token = "0x600030F")]
			[Cpp2IlInjected.Address(RVA = "0xD11B30", Offset = "0xD10530", VA = "0x180D11B30")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000310")]
			[Cpp2IlInjected.Address(RVA = "0xD12270", Offset = "0xD10C70", VA = "0x180D12270")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000311")]
		[Cpp2IlInjected.Address(RVA = "0xD16C40", Offset = "0xD15640", VA = "0x180D16C40")]
		public CrmAssignmentDTO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000312")]
		[Cpp2IlInjected.Address(RVA = "0xD13C40", Offset = "0xD12640", VA = "0x180D13C40")]
		public CrmAssignmentDTO(CrmUserDTO userConfig, BrazeConfigDTO brazeConfig)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200007B")]
	public enum CrmType
	{
		[Cpp2IlInjected.Token(Token = "0x4000175")]
		None,
		[Cpp2IlInjected.Token(Token = "0x4000176")]
		Braze,
		[Cpp2IlInjected.Token(Token = "0x4000177")]
		Rengage
	}
	[Cpp2IlInjected.Token(Token = "0x200007C")]
	public enum PushNotificationServices : byte
	{
		[Cpp2IlInjected.Token(Token = "0x4000179")]
		APNS,
		[Cpp2IlInjected.Token(Token = "0x400017A")]
		Firebase,
		[Cpp2IlInjected.Token(Token = "0x400017B")]
		Mock,
		[Cpp2IlInjected.Token(Token = "0x400017C")]
		Braze,
		[Cpp2IlInjected.Token(Token = "0x400017D")]
		Rengage
	}
	[Cpp2IlInjected.Token(Token = "0x200007D")]
	[Utf8JsonSerializable]
	public class CrmUserDTO
	{
		[Cpp2IlInjected.Token(Token = "0x17000162")]
		public CrmType AssignedCrmType
		{
			[Cpp2IlInjected.Token(Token = "0x6000313")]
			[Cpp2IlInjected.Address(RVA = "0xD0F110", Offset = "0xD0DB10", VA = "0x180D0F110")]
			[CompilerGenerated]
			get
			{
				return default(CrmType);
			}
			[Cpp2IlInjected.Token(Token = "0x6000314")]
			[Cpp2IlInjected.Address(RVA = "0xD12F30", Offset = "0xD11930", VA = "0x180D12F30")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000163")]
		public PushNotificationServices? AssignedPushNotificationService
		{
			[Cpp2IlInjected.Token(Token = "0x6000315")]
			[Cpp2IlInjected.Address(RVA = "0x32DF820", Offset = "0x32DE220", VA = "0x1832DF820")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000316")]
			[Cpp2IlInjected.Address(RVA = "0x8D0F640", Offset = "0x8D0E040", VA = "0x188D0F640")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000164")]
		public bool AllowPush
		{
			[Cpp2IlInjected.Token(Token = "0x6000317")]
			[Cpp2IlInjected.Address(RVA = "0x113A7C0", Offset = "0x11391C0", VA = "0x18113A7C0")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000318")]
			[Cpp2IlInjected.Address(RVA = "0x113A950", Offset = "0x1139350", VA = "0x18113A950")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000319")]
		[Cpp2IlInjected.Address(RVA = "0x8DBED30", Offset = "0x8DBD730", VA = "0x188DBED30")]
		public CrmUserDTO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600031A")]
		[Cpp2IlInjected.Address(RVA = "0x8DBECA0", Offset = "0x8DBD6A0", VA = "0x188DBECA0")]
		public CrmUserDTO(CrmType assignedCrmType, PushNotificationServices assignedPushNotificationService, bool allowPush)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200007E")]
	[Utf8JsonSerializable]
	public class BrazeConfigDTO
	{
		[Cpp2IlInjected.Token(Token = "0x17000165")]
		public string AppId
		{
			[Cpp2IlInjected.Token(Token = "0x600031B")]
			[Cpp2IlInjected.Address(RVA = "0xD117B0", Offset = "0xD101B0", VA = "0x180D117B0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600031C")]
			[Cpp2IlInjected.Address(RVA = "0xD117C0", Offset = "0xD101C0", VA = "0x180D117C0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000166")]
		public string SdkEndpoint
		{
			[Cpp2IlInjected.Token(Token = "0x600031D")]
			[Cpp2IlInjected.Address(RVA = "0xD11B30", Offset = "0xD10530", VA = "0x180D11B30")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600031E")]
			[Cpp2IlInjected.Address(RVA = "0xD12270", Offset = "0xD10C70", VA = "0x180D12270")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600031F")]
		[Cpp2IlInjected.Address(RVA = "0xD16C40", Offset = "0xD15640", VA = "0x180D16C40")]
		public BrazeConfigDTO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000320")]
		[Cpp2IlInjected.Address(RVA = "0xD13C40", Offset = "0xD12640", VA = "0x180D13C40")]
		public BrazeConfigDTO(string appId, string sdkEndpoint)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200007F")]
	public enum DeviceClass
	{
		[Cpp2IlInjected.Token(Token = "0x4000184")]
		Unknown,
		[Cpp2IlInjected.Token(Token = "0x4000185")]
		VR,
		[Cpp2IlInjected.Token(Token = "0x4000186")]
		Screen,
		[Cpp2IlInjected.Token(Token = "0x4000187")]
		Mobile,
		[Cpp2IlInjected.Token(Token = "0x4000188")]
		VRLow,
		[Cpp2IlInjected.Token(Token = "0x4000189")]
		Quest2
	}
	[Cpp2IlInjected.Token(Token = "0x2000080")]
	public struct GiftPackageReceivedArgs
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400018A")]
		public GiftPackage GiftPackage;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400018B")]
		public bool ShowImmediately;

		[Cpp2IlInjected.FieldOffset(Offset = "0x9")]
		[Cpp2IlInjected.Token(Token = "0x400018C")]
		public bool DismissExisting;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA")]
		[Cpp2IlInjected.Token(Token = "0x400018D")]
		public bool ShowNotification;
	}
	[Cpp2IlInjected.Token(Token = "0x2000081")]
	[Utf8JsonSerializable]
	public class GiftPackage : OIRXPKYYAWC, QPSFFVWODNU
	{
		[Cpp2IlInjected.Token(Token = "0x400018E")]
		internal static Action<GiftPackage> NHRYEKMJTSC;

		[Cpp2IlInjected.Token(Token = "0x400018F")]
		internal static Func<GiftPackage, Task> HGIJTZZBLHW;

		[Cpp2IlInjected.FieldOffset(Offset = "0x101")]
		[Cpp2IlInjected.Token(Token = "0x40001AE")]
		[IgnoreDataMember]
		public bool IsGifted;

		[Cpp2IlInjected.Token(Token = "0x17000167")]
		public long? Id
		{
			[Cpp2IlInjected.Token(Token = "0x6000321")]
			[Cpp2IlInjected.Address(RVA = "0xF357F0", Offset = "0xF341F0", VA = "0x180F357F0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000322")]
			[Cpp2IlInjected.Address(RVA = "0xF35810", Offset = "0xF34210", VA = "0x180F35810")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000168")]
		public int PlayerId
		{
			[Cpp2IlInjected.Token(Token = "0x6000323")]
			[Cpp2IlInjected.Address(RVA = "0xD215F0", Offset = "0xD1FFF0", VA = "0x180D215F0")]
			[CompilerGenerated]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x6000324")]
			[Cpp2IlInjected.Address(RVA = "0xD682F0", Offset = "0xD66CF0", VA = "0x180D682F0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000169")]
		public int? FromPlayerId
		{
			[Cpp2IlInjected.Token(Token = "0x6000325")]
			[Cpp2IlInjected.Address(RVA = "0x141BB60", Offset = "0x141A560", VA = "0x18141BB60")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000326")]
			[Cpp2IlInjected.Address(RVA = "0x10CE4D0", Offset = "0x10CCED0", VA = "0x1810CE4D0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700016A")]
		public string ConsumableItemDesc
		{
			[Cpp2IlInjected.Token(Token = "0x6000327")]
			[Cpp2IlInjected.Address(RVA = "0xD11A20", Offset = "0xD10420", VA = "0x180D11A20")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000328")]
			[Cpp2IlInjected.Address(RVA = "0xD17350", Offset = "0xD15D50", VA = "0x180D17350")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700016B")]
		public AvatarItemType? AvatarItemType
		{
			[Cpp2IlInjected.Token(Token = "0x6000329")]
			[Cpp2IlInjected.Address(RVA = "0xD12280", Offset = "0xD10C80", VA = "0x180D12280")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600032A")]
			[Cpp2IlInjected.Address(RVA = "0xD1B6D0", Offset = "0xD1A0D0", VA = "0x180D1B6D0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700016C")]
		[DataMember(Name = "AvatarItemDesc")]
		public string AvatarItemDescOrHairDyeDesc
		{
			[Cpp2IlInjected.Token(Token = "0x600032B")]
			[Cpp2IlInjected.Address(RVA = "0xD11A30", Offset = "0xD10430", VA = "0x180D11A30")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600032C")]
			[Cpp2IlInjected.Address(RVA = "0xD12260", Offset = "0xD10C60", VA = "0x180D12260")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700016D")]
		public Guid? CustomAvatarItemId
		{
			[Cpp2IlInjected.Token(Token = "0x600032D")]
			[Cpp2IlInjected.Address(RVA = "0xE46520", Offset = "0xE44F20", VA = "0x180E46520")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600032E")]
			[Cpp2IlInjected.Address(RVA = "0xE45C30", Offset = "0xE44630", VA = "0x180E45C30")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700016E")]
		public string EquipmentPrefabName
		{
			[Cpp2IlInjected.Token(Token = "0x600032F")]
			[Cpp2IlInjected.Address(RVA = "0xD15610", Offset = "0xD14010", VA = "0x180D15610")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000330")]
			[Cpp2IlInjected.Address(RVA = "0xD15600", Offset = "0xD14000", VA = "0x180D15600")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700016F")]
		public string EquipmentModificationGuid
		{
			[Cpp2IlInjected.Token(Token = "0x6000331")]
			[Cpp2IlInjected.Address(RVA = "0xD11B40", Offset = "0xD10540", VA = "0x180D11B40")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000332")]
			[Cpp2IlInjected.Address(RVA = "0xD11910", Offset = "0xD10310", VA = "0x180D11910")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000170")]
		public Guid? PurchasableXpBoostId
		{
			[Cpp2IlInjected.Token(Token = "0x6000333")]
			[Cpp2IlInjected.Address(RVA = "0x8DC0800", Offset = "0x8DBF200", VA = "0x188DC0800")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000334")]
			[Cpp2IlInjected.Address(RVA = "0x8DC0850", Offset = "0x8DBF250", VA = "0x188DC0850")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000171")]
		public float? XpBoostMultiplier
		{
			[Cpp2IlInjected.Token(Token = "0x6000335")]
			[Cpp2IlInjected.Address(RVA = "0x8DC0840", Offset = "0x8DBF240", VA = "0x188DC0840")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000336")]
			[Cpp2IlInjected.Address(RVA = "0x2AC4790", Offset = "0x2AC3190", VA = "0x182AC4790")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000172")]
		public int? XpBoostDurationMinutes
		{
			[Cpp2IlInjected.Token(Token = "0x6000337")]
			[Cpp2IlInjected.Address(RVA = "0x8DC0830", Offset = "0x8DBF230", VA = "0x188DC0830")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000338")]
			[Cpp2IlInjected.Address(RVA = "0x8DC0880", Offset = "0x8DBF280", VA = "0x188DC0880")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000173")]
		public CurrencyType CurrencyType
		{
			[Cpp2IlInjected.Token(Token = "0x6000339")]
			[Cpp2IlInjected.Address(RVA = "0x18D8880", Offset = "0x18D7280", VA = "0x1818D8880")]
			[CompilerGenerated]
			get
			{
				return default(CurrencyType);
			}
			[Cpp2IlInjected.Token(Token = "0x600033A")]
			[Cpp2IlInjected.Address(RVA = "0x18D7520", Offset = "0x18D5F20", VA = "0x1818D7520")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000174")]
		public int Currency
		{
			[Cpp2IlInjected.Token(Token = "0x600033B")]
			[Cpp2IlInjected.Address(RVA = "0x153E5F0", Offset = "0x153CFF0", VA = "0x18153E5F0")]
			[CompilerGenerated]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x600033C")]
			[Cpp2IlInjected.Address(RVA = "0x1EF28C0", Offset = "0x1EF12C0", VA = "0x181EF28C0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000175")]
		public int Xp
		{
			[Cpp2IlInjected.Token(Token = "0x600033D")]
			[Cpp2IlInjected.Address(RVA = "0x2E67830", Offset = "0x2E66230", VA = "0x182E67830")]
			[CompilerGenerated]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x600033E")]
			[Cpp2IlInjected.Address(RVA = "0x8CA7C10", Offset = "0x8CA6610", VA = "0x188CA7C10")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000176")]
		public GiftContext GiftContext
		{
			[Cpp2IlInjected.Token(Token = "0x600033F")]
			[Cpp2IlInjected.Address(RVA = "0xD1E950", Offset = "0xD1D350", VA = "0x180D1E950")]
			[CompilerGenerated]
			get
			{
				return default(GiftContext);
			}
			[Cpp2IlInjected.Token(Token = "0x6000340")]
			[Cpp2IlInjected.Address(RVA = "0xD1E8D0", Offset = "0xD1D2D0", VA = "0x180D1E8D0")]
			[CompilerGenerated]
			internal set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000177")]
		public GiftRarity GiftRarity
		{
			[Cpp2IlInjected.Token(Token = "0x6000341")]
			[Cpp2IlInjected.Address(RVA = "0xD6A470", Offset = "0xD68E70", VA = "0x180D6A470")]
			[CompilerGenerated]
			get
			{
				return default(GiftRarity);
			}
			[Cpp2IlInjected.Token(Token = "0x6000342")]
			[Cpp2IlInjected.Address(RVA = "0xF65C30", Offset = "0xF64630", VA = "0x180F65C30")]
			[CompilerGenerated]
			internal set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000178")]
		[DataMember(Name = "Message")]
		public string RawMessage
		{
			[Cpp2IlInjected.Token(Token = "0x6000343")]
			[Cpp2IlInjected.Address(RVA = "0xD13E60", Offset = "0xD12860", VA = "0x180D13E60")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000344")]
			[Cpp2IlInjected.Address(RVA = "0xD13E70", Offset = "0xD12870", VA = "0x180D13E70")]
			[CompilerGenerated]
			internal set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000179")]
		public string Signature
		{
			[Cpp2IlInjected.Token(Token = "0x6000345")]
			[Cpp2IlInjected.Address(RVA = "0xEC39C0", Offset = "0xEC23C0", VA = "0x180EC39C0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000346")]
			[Cpp2IlInjected.Address(RVA = "0x102EA40", Offset = "0x102D440", VA = "0x18102EA40")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700017A")]
		public bool IsSignatureValid
		{
			[Cpp2IlInjected.Token(Token = "0x6000347")]
			[Cpp2IlInjected.Address(RVA = "0xEC36A0", Offset = "0xEC20A0", VA = "0x180EC36A0")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000348")]
			[Cpp2IlInjected.Address(RVA = "0xEC2060", Offset = "0xEC0A60", VA = "0x180EC2060")]
			[CompilerGenerated]
			internal set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700017B")]
		public PlatformType Platform
		{
			[Cpp2IlInjected.Token(Token = "0x6000349")]
			[Cpp2IlInjected.Address(RVA = "0x10FA660", Offset = "0x10F9060", VA = "0x1810FA660")]
			[CompilerGenerated]
			get
			{
				return default(PlatformType);
			}
			[Cpp2IlInjected.Token(Token = "0x600034A")]
			[Cpp2IlInjected.Address(RVA = "0x10F95D0", Offset = "0x10F7FD0", VA = "0x1810F95D0")]
			[CompilerGenerated]
			internal set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700017C")]
		public PlatformMask PlatformsToSpawnOn
		{
			[Cpp2IlInjected.Token(Token = "0x600034B")]
			[Cpp2IlInjected.Address(RVA = "0xF27C50", Offset = "0xF26650", VA = "0x180F27C50")]
			[CompilerGenerated]
			get
			{
				return default(PlatformMask);
			}
			[Cpp2IlInjected.Token(Token = "0x600034C")]
			[Cpp2IlInjected.Address(RVA = "0x230B360", Offset = "0x2309D60", VA = "0x18230B360")]
			[CompilerGenerated]
			internal set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700017D")]
		public StorefrontBalanceType? BalanceType
		{
			[Cpp2IlInjected.Token(Token = "0x600034D")]
			[Cpp2IlInjected.Address(RVA = "0x8C13170", Offset = "0x8C11B70", VA = "0x188C13170")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600034E")]
			[Cpp2IlInjected.Address(RVA = "0x8C13280", Offset = "0x8C11C80", VA = "0x188C13280")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700017E")]
		public long? RoomId
		{
			[Cpp2IlInjected.Token(Token = "0x600034F")]
			[Cpp2IlInjected.Address(RVA = "0x8DC0820", Offset = "0x8DBF220", VA = "0x188DC0820")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000350")]
			[Cpp2IlInjected.Address(RVA = "0x8DC0870", Offset = "0x8DBF270", VA = "0x188DC0870")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700017F")]
		public string GiftDescription
		{
			[Cpp2IlInjected.Token(Token = "0x6000351")]
			[Cpp2IlInjected.Address(RVA = "0xDD6700", Offset = "0xDD5100", VA = "0x180DD6700")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000352")]
			[Cpp2IlInjected.Address(RVA = "0x1128AC0", Offset = "0x11274C0", VA = "0x181128AC0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000180")]
		public bool HasAvatarItemOrHairDye
		{
			[Cpp2IlInjected.Token(Token = "0x6000353")]
			[Cpp2IlInjected.Address(RVA = "0x8DC06D0", Offset = "0x8DBF0D0", VA = "0x188DC06D0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000181")]
		public bool HasEquipment
		{
			[Cpp2IlInjected.Token(Token = "0x6000354")]
			[Cpp2IlInjected.Address(RVA = "0x8DC0760", Offset = "0x8DBF160", VA = "0x188DC0760")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000182")]
		public bool HasConsumable
		{
			[Cpp2IlInjected.Token(Token = "0x6000355")]
			[Cpp2IlInjected.Address(RVA = "0x8DC0740", Offset = "0x8DBF140", VA = "0x188DC0740")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000183")]
		public bool HasPurchasableXpBoost
		{
			[Cpp2IlInjected.Token(Token = "0x6000356")]
			[Cpp2IlInjected.Address(RVA = "0x8DC0780", Offset = "0x8DBF180", VA = "0x188DC0780")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000184")]
		public bool HasUGCGift
		{
			[Cpp2IlInjected.Token(Token = "0x6000357")]
			[Cpp2IlInjected.Address(RVA = "0x8DC07B0", Offset = "0x8DBF1B0", VA = "0x188DC07B0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000185")]
		[IgnoreDataMember]
		public bool Consumed
		{
			[Cpp2IlInjected.Token(Token = "0x6000358")]
			[Cpp2IlInjected.Address(RVA = "0xD8ABA0", Offset = "0xD895A0", VA = "0x180D8ABA0")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000359")]
			[Cpp2IlInjected.Address(RVA = "0xD89F50", Offset = "0xD88950", VA = "0x180D89F50")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000186")]
		[IgnoreDataMember]
		public bool IsValid
		{
			[Cpp2IlInjected.Token(Token = "0x600035A")]
			[Cpp2IlInjected.Address(RVA = "0x10F9D90", Offset = "0x10F8790", VA = "0x1810F9D90")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x600035B")]
			[Cpp2IlInjected.Address(RVA = "0x10FA210", Offset = "0x10F8C10", VA = "0x1810FA210")]
			[CompilerGenerated]
			internal set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000187")]
		[IgnoreDataMember]
		public string CustomMessage
		{
			[Cpp2IlInjected.Token(Token = "0x600035C")]
			[Cpp2IlInjected.Address(RVA = "0xF82210", Offset = "0xF80C10", VA = "0x180F82210")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600035D")]
			[Cpp2IlInjected.Address(RVA = "0x1751A20", Offset = "0x1750420", VA = "0x181751A20")]
			[CompilerGenerated]
			internal set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000188")]
		[IgnoreDataMember]
		public string ErrorMessage
		{
			[Cpp2IlInjected.Token(Token = "0x600035E")]
			[Cpp2IlInjected.Address(RVA = "0xE8FB30", Offset = "0xE8E530", VA = "0x180E8FB30")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600035F")]
			[Cpp2IlInjected.Address(RVA = "0x174E370", Offset = "0x174CD70", VA = "0x18174E370")]
			[CompilerGenerated]
			internal set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000189")]
		[IgnoreDataMember]
		public bool CanSpawnOnCurrentPlatform
		{
			[Cpp2IlInjected.Token(Token = "0x6000360")]
			[Cpp2IlInjected.Address(RVA = "0x12ECD30", Offset = "0x12EB730", VA = "0x1812ECD30")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000361")]
			[Cpp2IlInjected.Address(RVA = "0x14B6930", Offset = "0x14B5330", VA = "0x1814B6930")]
			[CompilerGenerated]
			internal set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000362")]
		[Cpp2IlInjected.Address(RVA = "0x8DC05B0", Offset = "0x8DBEFB0", VA = "0x188DC05B0", Slot = "4")]
		public void HHUGNWFYOZL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000363")]
		[Cpp2IlInjected.Address(RVA = "0x8DC0610", Offset = "0x8DBF010", VA = "0x188DC0610", Slot = "5")]
		public Task NLARVXFWNGH()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000364")]
		[Cpp2IlInjected.Address(RVA = "0xD1E8D0", Offset = "0xD1D2D0", VA = "0x180D1E8D0")]
		public void XTPFBVFWYPS(GiftContext a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000365")]
		[Cpp2IlInjected.Address(RVA = "0xD16C40", Offset = "0xD15640", VA = "0x180D16C40")]
		public GiftPackage()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000082")]
	public interface NPUSNPAGITA
	{
		[Cpp2IlInjected.Token(Token = "0x1700018A")]
		long InventionId
		{
			[Cpp2IlInjected.Token(Token = "0x6000368")]
			[Cpp2IlInjected.Address(Slot = "2")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x1700018B")]
		string ReplicationId
		{
			[Cpp2IlInjected.Token(Token = "0x6000369")]
			[Cpp2IlInjected.Address(Slot = "3")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x1700018C")]
		int CreatorPlayerId
		{
			[Cpp2IlInjected.Token(Token = "0x600036A")]
			[Cpp2IlInjected.Address(Slot = "4")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x1700018D")]
		string Name
		{
			[Cpp2IlInjected.Token(Token = "0x600036B")]
			[Cpp2IlInjected.Address(Slot = "5")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x1700018E")]
		string Description
		{
			[Cpp2IlInjected.Token(Token = "0x600036C")]
			[Cpp2IlInjected.Address(Slot = "6")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x1700018F")]
		string LongDescription
		{
			[Cpp2IlInjected.Token(Token = "0x600036D")]
			[Cpp2IlInjected.Address(Slot = "7")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000190")]
		string ImageName
		{
			[Cpp2IlInjected.Token(Token = "0x600036E")]
			[Cpp2IlInjected.Address(Slot = "8")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000191")]
		byte UgcVersion
		{
			[Cpp2IlInjected.Token(Token = "0x600036F")]
			[Cpp2IlInjected.Address(Slot = "9")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000192")]
		int CurrentVersionNumber
		{
			[Cpp2IlInjected.Token(Token = "0x6000370")]
			[Cpp2IlInjected.Address(Slot = "10")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000193")]
		int LatestVersionNumber
		{
			[Cpp2IlInjected.Token(Token = "0x6000371")]
			[Cpp2IlInjected.Address(Slot = "11")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000194")]
		UgcAccessibility Accessibility
		{
			[Cpp2IlInjected.Token(Token = "0x6000372")]
			[Cpp2IlInjected.Address(Slot = "12")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000195")]
		bool ForceCannotPublish
		{
			[Cpp2IlInjected.Token(Token = "0x6000373")]
			[Cpp2IlInjected.Address(Slot = "13")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000196")]
		DateTime ModifiedAt
		{
			[Cpp2IlInjected.Token(Token = "0x6000374")]
			[Cpp2IlInjected.Address(Slot = "14")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000197")]
		DateTime CreatedAt
		{
			[Cpp2IlInjected.Token(Token = "0x6000375")]
			[Cpp2IlInjected.Address(Slot = "15")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000198")]
		DateTime? FirstPublishedAt
		{
			[Cpp2IlInjected.Token(Token = "0x6000376")]
			[Cpp2IlInjected.Address(Slot = "16")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000199")]
		long? CreationRoomId
		{
			[Cpp2IlInjected.Token(Token = "0x6000377")]
			[Cpp2IlInjected.Address(Slot = "17")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x1700019A")]
		int NumPlayersHaveUsedInRoom
		{
			[Cpp2IlInjected.Token(Token = "0x6000378")]
			[Cpp2IlInjected.Address(Slot = "18")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x1700019B")]
		int NumDownloads
		{
			[Cpp2IlInjected.Token(Token = "0x6000379")]
			[Cpp2IlInjected.Address(Slot = "19")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x1700019C")]
		int CheerCount
		{
			[Cpp2IlInjected.Token(Token = "0x600037A")]
			[Cpp2IlInjected.Address(Slot = "20")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x1700019D")]
		InventionPermission CreatorPermission
		{
			[Cpp2IlInjected.Token(Token = "0x600037B")]
			[Cpp2IlInjected.Address(Slot = "21")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x1700019E")]
		InventionPermission GeneralPermission
		{
			[Cpp2IlInjected.Token(Token = "0x600037C")]
			[Cpp2IlInjected.Address(Slot = "22")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x1700019F")]
		bool IsAgInvention
		{
			[Cpp2IlInjected.Token(Token = "0x600037D")]
			[Cpp2IlInjected.Address(Slot = "23")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x170001A0")]
		bool IsCertifiedInvention
		{
			[Cpp2IlInjected.Token(Token = "0x600037E")]
			[Cpp2IlInjected.Address(Slot = "24")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x170001A1")]
		bool IsRecRoomApproved
		{
			[Cpp2IlInjected.Token(Token = "0x600037F")]
			[Cpp2IlInjected.Address(Slot = "25")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x170001A2")]
		bool AllowTrial
		{
			[Cpp2IlInjected.Token(Token = "0x6000380")]
			[Cpp2IlInjected.Address(Slot = "26")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x170001A3")]
		int? Price
		{
			[Cpp2IlInjected.Token(Token = "0x6000381")]
			[Cpp2IlInjected.Address(Slot = "27")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x170001A4")]
		bool HideFromPlayer
		{
			[Cpp2IlInjected.Token(Token = "0x6000382")]
			[Cpp2IlInjected.Address(Slot = "28")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x170001A5")]
		string DisplayMetadataJson
		{
			[Cpp2IlInjected.Token(Token = "0x6000383")]
			[Cpp2IlInjected.Address(Slot = "29")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x6000366")]
		[Cpp2IlInjected.Address(Slot = "0")]
		bool QBULQHWTSWZ();

		[Cpp2IlInjected.Token(Token = "0x6000367")]
		[Cpp2IlInjected.Address(Slot = "1")]
		bool SARRCRFWFCT();
	}
	[Cpp2IlInjected.Token(Token = "0x2000083")]
	[Utf8JsonSerializable]
	public class InventionDetails
	{
		[Cpp2IlInjected.Token(Token = "0x170001A6")]
		public List<TagDTO> Tags
		{
			[Cpp2IlInjected.Token(Token = "0x6000384")]
			[Cpp2IlInjected.Address(RVA = "0xD117B0", Offset = "0xD101B0", VA = "0x180D117B0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000385")]
			[Cpp2IlInjected.Address(RVA = "0xD117C0", Offset = "0xD101C0", VA = "0x180D117C0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000386")]
		[Cpp2IlInjected.Address(RVA = "0x8DC1470", Offset = "0x8DBFE70", VA = "0x188DC1470")]
		public List<string> LTBGWMSTWBN(params TagType[] tagTypes)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000387")]
		[Cpp2IlInjected.Address(RVA = "0x8DC1400", Offset = "0x8DBFE00", VA = "0x188DC1400")]
		public List<string> FAYFBUBOJAF()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000388")]
		[Cpp2IlInjected.Address(RVA = "0x8DC1680", Offset = "0x8DC0080", VA = "0x188DC1680")]
		public List<string> ZMKUUPVYCPE()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000389")]
		[Cpp2IlInjected.Address(RVA = "0x8DC1630", Offset = "0x8DC0030", VA = "0x188DC1630")]
		public List<string> QQUKLJKUUXL()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600038A")]
		[Cpp2IlInjected.Address(RVA = "0xD16C40", Offset = "0xD15640", VA = "0x180D16C40")]
		public InventionDetails()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000084")]
	[Utf8JsonSerializable]
	public class InventionCreatorIdDTO
	{
		[Cpp2IlInjected.Token(Token = "0x170001A7")]
		public int CreatorPlayerId
		{
			[Cpp2IlInjected.Token(Token = "0x600038B")]
			[Cpp2IlInjected.Address(RVA = "0xD0F110", Offset = "0xD0DB10", VA = "0x180D0F110")]
			[CompilerGenerated]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x600038C")]
			[Cpp2IlInjected.Address(RVA = "0xD12F30", Offset = "0xD11930", VA = "0x180D12F30")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600038D")]
		[Cpp2IlInjected.Address(RVA = "0xD16C40", Offset = "0xD15640", VA = "0x180D16C40")]
		public InventionCreatorIdDTO()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000085")]
	[Utf8JsonSerializable]
	public class InventionVersion
	{
		[Cpp2IlInjected.Token(Token = "0x170001A8")]
		public long InventionId
		{
			[Cpp2IlInjected.Token(Token = "0x600038E")]
			[Cpp2IlInjected.Address(RVA = "0xD117B0", Offset = "0xD101B0", VA = "0x180D117B0")]
			[CompilerGenerated]
			get
			{
				return default(long);
			}
			[Cpp2IlInjected.Token(Token = "0x600038F")]
			[Cpp2IlInjected.Address(RVA = "0xED90B0", Offset = "0xED7AB0", VA = "0x180ED90B0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001A9")]
		public string ReplicationId
		{
			[Cpp2IlInjected.Token(Token = "0x6000390")]
			[Cpp2IlInjected.Address(RVA = "0xD11B30", Offset = "0xD10530", VA = "0x180D11B30")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000391")]
			[Cpp2IlInjected.Address(RVA = "0xD12270", Offset = "0xD10C70", VA = "0x180D12270")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001AA")]
		public int VersionNumber
		{
			[Cpp2IlInjected.Token(Token = "0x6000392")]
			[Cpp2IlInjected.Address(RVA = "0xD215F0", Offset = "0xD1FFF0", VA = "0x180D215F0")]
			[CompilerGenerated]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x6000393")]
			[Cpp2IlInjected.Address(RVA = "0xD682F0", Offset = "0xD66CF0", VA = "0x180D682F0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001AB")]
		public bool HasBetaContent
		{
			[Cpp2IlInjected.Token(Token = "0x6000394")]
			[Cpp2IlInjected.Address(RVA = "0xED9EB0", Offset = "0xED88B0", VA = "0x180ED9EB0")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000395")]
			[Cpp2IlInjected.Address(RVA = "0xED9FA0", Offset = "0xED89A0", VA = "0x180ED9FA0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001AC")]
		public int InstantiationCost
		{
			[Cpp2IlInjected.Token(Token = "0x6000396")]
			[Cpp2IlInjected.Address(RVA = "0xD12BE0", Offset = "0xD115E0", VA = "0x180D12BE0")]
			[CompilerGenerated]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x6000397")]
			[Cpp2IlInjected.Address(RVA = "0xD12C40", Offset = "0xD11640", VA = "0x180D12C40")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001AD")]
		public int LightsCost
		{
			[Cpp2IlInjected.Token(Token = "0x6000398")]
			[Cpp2IlInjected.Address(RVA = "0xE24360", Offset = "0xE22D60", VA = "0x180E24360")]
			[CompilerGenerated]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x6000399")]
			[Cpp2IlInjected.Address(RVA = "0x1E2BFE0", Offset = "0x1E2A9E0", VA = "0x181E2BFE0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001AE")]
		public int ChipsCost
		{
			[Cpp2IlInjected.Token(Token = "0x600039A")]
			[Cpp2IlInjected.Address(RVA = "0xD1B6C0", Offset = "0xD1A0C0", VA = "0x180D1B6C0")]
			[CompilerGenerated]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x600039B")]
			[Cpp2IlInjected.Address(RVA = "0xD1B020", Offset = "0xD19A20", VA = "0x180D1B020")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001AF")]
		public int CloudVariablesCost
		{
			[Cpp2IlInjected.Token(Token = "0x600039C")]
			[Cpp2IlInjected.Address(RVA = "0xD60890", Offset = "0xD5F290", VA = "0x180D60890")]
			[CompilerGenerated]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x600039D")]
			[Cpp2IlInjected.Address(RVA = "0x1708EF0", Offset = "0x17078F0", VA = "0x181708EF0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001B0")]
		public string BlobName
		{
			[Cpp2IlInjected.Token(Token = "0x600039E")]
			[Cpp2IlInjected.Address(RVA = "0xD12280", Offset = "0xD10C80", VA = "0x180D12280")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600039F")]
			[Cpp2IlInjected.Address(RVA = "0xD11B50", Offset = "0xD10550", VA = "0x180D11B50")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001B1")]
		public string BlobHash
		{
			[Cpp2IlInjected.Token(Token = "0x60003A0")]
			[Cpp2IlInjected.Address(RVA = "0xD11A30", Offset = "0xD10430", VA = "0x180D11A30")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60003A1")]
			[Cpp2IlInjected.Address(RVA = "0xD12260", Offset = "0xD10C60", VA = "0x180D12260")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001B2")]
		public DateTime CreatedAt
		{
			[Cpp2IlInjected.Token(Token = "0x60003A2")]
			[Cpp2IlInjected.Address(RVA = "0xD122E0", Offset = "0xD10CE0", VA = "0x180D122E0")]
			[CompilerGenerated]
			get
			{
				return default(DateTime);
			}
			[Cpp2IlInjected.Token(Token = "0x60003A3")]
			[Cpp2IlInjected.Address(RVA = "0x1440140", Offset = "0x143EB40", VA = "0x181440140")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001B3")]
		public UgcAccessibility? UgcAccessibility
		{
			[Cpp2IlInjected.Token(Token = "0x60003A4")]
			[Cpp2IlInjected.Address(RVA = "0xD11B20", Offset = "0xD10520", VA = "0x180D11B20")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60003A5")]
			[Cpp2IlInjected.Address(RVA = "0xFFBF90", Offset = "0xFFA990", VA = "0x180FFBF90")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001B4")]
		public IReadOnlyList<Guid> ReferencedUnityAssetIds
		{
			[Cpp2IlInjected.Token(Token = "0x60003A6")]
			[Cpp2IlInjected.Address(RVA = "0xD11940", Offset = "0xD10340", VA = "0x180D11940")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60003A7")]
			[Cpp2IlInjected.Address(RVA = "0xD122A0", Offset = "0xD10CA0", VA = "0x180D122A0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001B5")]
		public FilenameWithHash BlobNameWithHash
		{
			[Cpp2IlInjected.Token(Token = "0x60003AD")]
			[Cpp2IlInjected.Address(RVA = "0x8DC1A10", Offset = "0x8DC0410", VA = "0x188DC1A10")]
			get
			{
				return default(FilenameWithHash);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60003A8")]
		[Cpp2IlInjected.Address(RVA = "0x8DC1710", Offset = "0x8DC0110", VA = "0x188DC1710", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60003A9")]
		[Cpp2IlInjected.Address(RVA = "0x8DC1700", Offset = "0x8DC0100", VA = "0x188DC1700")]
		public bool Equals(InventionVersion v2)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60003AA")]
		[Cpp2IlInjected.Address(RVA = "0x8DC1830", Offset = "0x8DC0230", VA = "0x188DC1830")]
		private bool MCHIOJCVUUF(InventionVersion a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60003AB")]
		[Cpp2IlInjected.Address(RVA = "0x8DC1790", Offset = "0x8DC0190", VA = "0x188DC1790")]
		private static bool KFWGGTUSUGV(IReadOnlyList<Guid> a, IReadOnlyList<Guid> b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60003AC")]
		[Cpp2IlInjected.Address(RVA = "0x2BAAA40", Offset = "0x2BA9440", VA = "0x182BAAA40", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60003AE")]
		[Cpp2IlInjected.Address(RVA = "0xD16C40", Offset = "0xD15640", VA = "0x180D16C40")]
		public InventionVersion()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000086")]
	[Utf8JsonSerializable]
	public class InventionTrialDurationResponse
	{
		[Cpp2IlInjected.Token(Token = "0x170001B6")]
		public int Duration
		{
			[Cpp2IlInjected.Token(Token = "0x60003AF")]
			[Cpp2IlInjected.Address(RVA = "0xD0F110", Offset = "0xD0DB10", VA = "0x180D0F110")]
			[CompilerGenerated]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x60003B0")]
			[Cpp2IlInjected.Address(RVA = "0xD12F30", Offset = "0xD11930", VA = "0x180D12F30")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60003B1")]
		[Cpp2IlInjected.Address(RVA = "0xD16C40", Offset = "0xD15640", VA = "0x180D16C40")]
		public InventionTrialDurationResponse()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000087")]
	[Utf8JsonSerializable]
	public class PersonalInventionDetails
	{
		[Cpp2IlInjected.Token(Token = "0x170001B7")]
		public bool IsCheering
		{
			[Cpp2IlInjected.Token(Token = "0x60003B2")]
			[Cpp2IlInjected.Address(RVA = "0xD66E30", Offset = "0xD65830", VA = "0x180D66E30")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x60003B3")]
			[Cpp2IlInjected.Address(RVA = "0xE376D0", Offset = "0xE360D0", VA = "0x180E376D0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60003B4")]
		[Cpp2IlInjected.Address(RVA = "0xD16C40", Offset = "0xD15640", VA = "0x180D16C40")]
		public PersonalInventionDetails()
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000088")]
	[Utf8JsonSerializable]
	public class NewInventionRequestDTO
	{
		[Cpp2IlInjected.Token(Token = "0x170001B8")]
		public string name
		{
			[Cpp2IlInjected.Token(Token = "0x60003B5")]
			[Cpp2IlInjected.Address(RVA = "0xD117B0", Offset = "0xD101B0", VA = "0x180D117B0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60003B6")]
			[Cpp2IlInjected.Address(RVA = "0xD117C0", Offset = "0xD101C0", VA = "0x180D117C0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001B9")]
		public string description
		{
			[Cpp2IlInjected.Token(Token = "0x60003B7")]
			[Cpp2IlInjected.Address(RVA = "0xD11B30", Offset = "0xD10530", VA = "0x180D11B30")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60003B8")]
			[Cpp2IlInjected.Address(RVA = "0xD12270", Offset = "0xD10C70", VA = "0x180D12270")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001BA")]
		public string imageName
		{
			[Cpp2IlInjected.Token(Token = "0x60003B9")]
			[Cpp2IlInjected.Address(RVA = "0xD12BC0", Offset = "0xD115C0", VA = "0x180D12BC0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60003BA")]
			[Cpp2IlInjected.Address(RVA = "0xD11520", Offset = "0xD0FF20", VA = "0x180D11520")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001BB")]
		public bool hasBetaContent
		{
			[Cpp2IlInjected.Token(Token = "0x60003BB")]
			[Cpp2IlInjected.Address(RVA = "0xDA36E0", Offset = "0xDA20E0", VA = "0x180DA36E0")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x60003BC")]
			[Cpp2IlInjected.Address(RVA = "0xDA36F0", Offset = "0xDA20F0", VA = "0x180DA36F0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001BC")]
		public int instantiationCost
		{
			[Cpp2IlInjected.Token(Token = "0x60003BD")]
			[Cpp2IlInjected.Address(RVA = "0xE24360", Offset = "0xE22D60", VA = "0x180E24360")]
			[CompilerGenerated]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x60003BE")]
			[Cpp2IlInjected.Address(RVA = "0x1E2BFE0", Offset = "0x1E2A9E0", VA = "0x181E2BFE0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001BD")]
		public int lightsCost
		{
			[Cpp2IlInjected.Token(Token = "0x60003BF")]
			[Cpp2IlInjected.Address(RVA = "0xD1B6C0", Offset = "0xD1A0C0", VA = "0x180D1B6C0")]
			[CompilerGenerated]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x60003C0")]
			[Cpp2IlInjected.Address(RVA = "0xD1B020", Offset = "0xD19A20", VA = "0x180D1B020")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001BE")]
		public int chipsCost
		{
			[Cpp2IlInjected.Token(Token = "0x60003C1")]
			[Cpp2IlInjected.Address(RVA = "0xD60890", Offset = "0xD5F290", VA = "0x180D60890")]
			[CompilerGenerated]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x60003C2")]
			[Cpp2IlInjected.Address(RVA = "0x1708EF0", Offset = "0x17078F0", VA = "0x181708EF0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001BF")]
		public int cloudVariablesCost
		{
			[Cpp2IlInjected.Token(Token = "0x60003C3")]
			[Cpp2IlInjected.Address(RVA = "0xD40260", Offset = "0xD3EC60", VA = "0x180D40260")]
			[CompilerGenerated]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x60003C4")]
			[Cpp2IlInjected.Address(RVA = "0xE27B10", Offset = "0xE26510", VA = "0x180E27B10")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001C0")]
		public int aiCost
		{
			[Cpp2IlInjected.Token(Token = "0x60003C5")]
			[Cpp2IlInjected.Address(RVA = "0xD50990", Offset = "0xD4F390", VA = "0x180D50990")]
			[CompilerGenerated]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x60003C6")]
			[Cpp2IlInjected.Address(RVA = "0xD506C0", Offset = "0xD4F0C0", VA = "0x180D506C0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001C1")]
		public byte ugcVersion
		{
			[Cpp2IlInjected.Token(Token = "0x60003C7")]
			[Cpp2IlInjected.Address(RVA = "0xF85FC0", Offset = "0xF849C0", VA = "0x180F85FC0")]
			[CompilerGenerated]
			get
			{
				return default(byte);
			}
			[Cpp2IlInjected.Token(Token = "0x60003C8")]
			[Cpp2IlInjected.Address(RVA = "0xF85920", Offset = "0xF84320", VA = "0x180F85920")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001C2")]
		public long creationRoomId
		{
			[Cpp2IlInjected.Token(Token = "0x60003C9")]
			[Cpp2IlInjected.Address(RVA = "0xD122E0", Offset = "0xD10CE0", VA = "0x180D122E0")]
			[CompilerGenerated]
			get
			{
				return default(long);
			}
			[Cpp2IlInjected.Token(Token = "0x60003CA")]
			[Cpp2IlInjected.Address(RVA = "0x1440140", Offset = "0x143EB40", VA = "0x181440140")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001C3")]
		public string inventionDataFilename
		{
			[Cpp2IlInjected.Token(Token = "0x60003CB")]
			[Cpp2IlInjected.Address(RVA = "0xD11B20", Offset = "0xD10520", VA = "0x180D11B20")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60003CC")]
			[Cpp2IlInjected.Address(RVA = "0xD11900", Offset = "0xD10300", VA = "0x180D11900")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001C4")]
		public List<long> referencedInventions
		{
			[Cpp2IlInjected.Token(Token = "0x60003CD")]
			[Cpp2IlInjected.Address(RVA = "0xD11940", Offset = "0xD10340", VA = "0x180D11940")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60003CE")]
			[Cpp2IlInjected.Address(RVA = "0xD122A0", Offset = "0xD10CA0", VA = "0x180D122A0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001C5")]
		public IReadOnlyList<Guid> referencedUnityAssetIds
		{
			[Cpp2IlInjected.Token(Token = "0x60003CF")]
			[Cpp2IlInjected.Address(RVA = "0xD15610", Offset = "0xD14010", VA = "0x180D15610")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60003D0")]
			[Cpp2IlInjected.Address(RVA = "0xD15600", Offset = "0xD14000", VA = "0x180D15600")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001C6")]
		public AccountRoleType creatorAccountRole
		{
			[Cpp2IlInjected.Token(Token = "0x60003D1")]
			[Cpp2IlInjected.Address(RVA = "0xD21E10", Offset = "0xD20810", VA = "0x180D21E10")]
			[CompilerGenerated]
			get
			{
				return default(AccountRoleType);
			}
			[Cpp2IlInjected.Token(Token = "0x60003D2")]
			[Cpp2IlInjected.Address(RVA = "0xD21D60", Offset = "0xD20760", VA = "0x180D21D60")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001C7")]
		public long? convertedFromInventionId
		{
			[Cpp2IlInjected.Token(Token = "0x60003D3")]
			[Cpp2IlInjected.Address(RVA = "0x6510250", Offset = "0x650EC50", VA = "0x186510250")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60003D4")]
			[Cpp2IlInjected.Address(RVA = "0x650FA10", Offset = "0x650E410", VA = "0x18650FA10")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001C8")]
		public string displayMetadataJson
		{
			[Cpp2IlInjected.Token(Token = "0x60003D5")]
			[Cpp2IlInjected.Address(RVA = "0xD1E850", Offset = "0xD1D250", VA = "0x180D1E850")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60003D6")]
			[Cpp2IlInjected.Address(RVA = "0xD1E840", Offset = "0xD1D240", VA = "0x180D1E840")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001C9")]
		public string longDescription
		{
			[Cpp2IlInjected.Token(Token = "0x60003D7")]
			[Cpp2IlInjected.Address(RVA = "0xD1E900", Offset = "0xD1D300", VA = "0x180D1E900")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60003D8")]
			[Cpp2IlInjected.Address(RVA = "0xD1E880", Offset = "0xD1D280", VA = "0x180D1E880")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001CA")]
		public ModifyTagsRequest tagsRequest
		{
			[Cpp2IlInjected.Token(Token = "0x60003D9")]
			[Cpp2IlInjected.Address(RVA = "0xD3FEF0", Offset = "0xD3E8F0", VA = "0x180D3FEF0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60003DA")]
			[Cpp2IlInjected.Address(RVA = "0xFCC250", Offset = "0xFCAC50", VA = "0x180FCC250")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60003DB")]
		[Cpp2IlInjected.Address(RVA = "0x8DC34F0", Offset = "0x8DC1EF0", VA = "0x188DC34F0")]
		public NewInventionRequestDTO()
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000089")]
	[Utf8JsonSerializable]
	public class AddVersionInventionRequestDTO
	{
		[Cpp2IlInjected.Token(Token = "0x170001CB")]
		public long inventionId
		{
			[Cpp2IlInjected.Token(Token = "0x60003DC")]
			[Cpp2IlInjected.Address(RVA = "0xD117B0", Offset = "0xD101B0", VA = "0x180D117B0")]
			[CompilerGenerated]
			get
			{
				return default(long);
			}
			[Cpp2IlInjected.Token(Token = "0x60003DD")]
			[Cpp2IlInjected.Address(RVA = "0xED90B0", Offset = "0xED7AB0", VA = "0x180ED90B0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001CC")]
		public bool hasBetaContent
		{
			[Cpp2IlInjected.Token(Token = "0x60003DE")]
			[Cpp2IlInjected.Address(RVA = "0xEB2260", Offset = "0xEB0C60", VA = "0x180EB2260")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x60003DF")]
			[Cpp2IlInjected.Address(RVA = "0xD19FA0", Offset = "0xD189A0", VA = "0x180D19FA0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001CD")]
		public int instantiationCost
		{
			[Cpp2IlInjected.Token(Token = "0x60003E0")]
			[Cpp2IlInjected.Address(RVA = "0x1664600", Offset = "0x1663000", VA = "0x181664600")]
			[CompilerGenerated]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x60003E1")]
			[Cpp2IlInjected.Address(RVA = "0x1664610", Offset = "0x1663010", VA = "0x181664610")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001CE")]
		public int lightsCost
		{
			[Cpp2IlInjected.Token(Token = "0x60003E2")]
			[Cpp2IlInjected.Address(RVA = "0xD215F0", Offset = "0xD1FFF0", VA = "0x180D215F0")]
			[CompilerGenerated]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x60003E3")]
			[Cpp2IlInjected.Address(RVA = "0xD682F0", Offset = "0xD66CF0", VA = "0x180D682F0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001CF")]
		public int chipsCost
		{
			[Cpp2IlInjected.Token(Token = "0x60003E4")]
			[Cpp2IlInjected.Address(RVA = "0xD38090", Offset = "0xD36A90", VA = "0x180D38090")]
			[CompilerGenerated]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x60003E5")]
			[Cpp2IlInjected.Address(RVA = "0xF21A50", Offset = "0xF20450", VA = "0x180F21A50")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001D0")]
		public int cloudVariablesCost
		{
			[Cpp2IlInjected.Token(Token = "0x60003E6")]
			[Cpp2IlInjected.Address(RVA = "0xD12BE0", Offset = "0xD115E0", VA = "0x180D12BE0")]
			[CompilerGenerated]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x60003E7")]
			[Cpp2IlInjected.Address(RVA = "0xD12C40", Offset = "0xD11640", VA = "0x180D12C40")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001D1")]
		public int aiCost
		{
			[Cpp2IlInjected.Token(Token = "0x60003E8")]
			[Cpp2IlInjected.Address(RVA = "0xE24360", Offset = "0xE22D60", VA = "0x180E24360")]
			[CompilerGenerated]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x60003E9")]
			[Cpp2IlInjected.Address(RVA = "0x1E2BFE0", Offset = "0x1E2A9E0", VA = "0x181E2BFE0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001D2")]
		public byte ugcVersion
		{
			[Cpp2IlInjected.Token(Token = "0x60003EA")]
			[Cpp2IlInjected.Address(RVA = "0xD6E8A0", Offset = "0xD6D2A0", VA = "0x180D6E8A0")]
			[CompilerGenerated]
			get
			{
				return default(byte);
			}
			[Cpp2IlInjected.Token(Token = "0x60003EB")]
			[Cpp2IlInjected.Address(RVA = "0xD6EFC0", Offset = "0xD6D9C0", VA = "0x180D6EFC0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001D3")]
		public long creationRoomId
		{
			[Cpp2IlInjected.Token(Token = "0x60003EC")]
			[Cpp2IlInjected.Address(RVA = "0xD12280", Offset = "0xD10C80", VA = "0x180D12280")]
			[CompilerGenerated]
			get
			{
				return default(long);
			}
			[Cpp2IlInjected.Token(Token = "0x60003ED")]
			[Cpp2IlInjected.Address(RVA = "0xD1B6D0", Offset = "0xD1A0D0", VA = "0x180D1B6D0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001D4")]
		public string inventionDataFilename
		{
			[Cpp2IlInjected.Token(Token = "0x60003EE")]
			[Cpp2IlInjected.Address(RVA = "0xD11A30", Offset = "0xD10430", VA = "0x180D11A30")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60003EF")]
			[Cpp2IlInjected.Address(RVA = "0xD12260", Offset = "0xD10C60", VA = "0x180D12260")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001D5")]
		public List<long> referencedInventions
		{
			[Cpp2IlInjected.Token(Token = "0x60003F0")]
			[Cpp2IlInjected.Address(RVA = "0xD122E0", Offset = "0xD10CE0", VA = "0x180D122E0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60003F1")]
			[Cpp2IlInjected.Address(RVA = "0xD12290", Offset = "0xD10C90", VA = "0x180D12290")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001D6")]
		public IReadOnlyList<Guid> referencedUnityAssetIds
		{
			[Cpp2IlInjected.Token(Token = "0x60003F2")]
			[Cpp2IlInjected.Address(RVA = "0xD11B20", Offset = "0xD10520", VA = "0x180D11B20")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60003F3")]
			[Cpp2IlInjected.Address(RVA = "0xD11900", Offset = "0xD10300", VA = "0x180D11900")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001D7")]
		public ModifyTagsRequest tagsRequest
		{
			[Cpp2IlInjected.Token(Token = "0x60003F4")]
			[Cpp2IlInjected.Address(RVA = "0xD11940", Offset = "0xD10340", VA = "0x180D11940")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60003F5")]
			[Cpp2IlInjected.Address(RVA = "0xD122A0", Offset = "0xD10CA0", VA = "0x180D122A0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60003F6")]
		[Cpp2IlInjected.Address(RVA = "0x8DBE0A0", Offset = "0x8DBCAA0", VA = "0x188DBE0A0")]
		public AddVersionInventionRequestDTO()
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x200008A")]
	[Utf8JsonSerializable]
	public class ModifyTagsRequest
	{
		[Cpp2IlInjected.Token(Token = "0x170001D8")]
		public List<string> AutoTags
		{
			[Cpp2IlInjected.Token(Token = "0x60003F7")]
			[Cpp2IlInjected.Address(RVA = "0xD117B0", Offset = "0xD101B0", VA = "0x180D117B0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60003F8")]
			[Cpp2IlInjected.Address(RVA = "0xD117C0", Offset = "0xD101C0", VA = "0x180D117C0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001D9")]
		public List<string> CustomTags
		{
			[Cpp2IlInjected.Token(Token = "0x60003F9")]
			[Cpp2IlInjected.Address(RVA = "0xD11B30", Offset = "0xD10530", VA = "0x180D11B30")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60003FA")]
			[Cpp2IlInjected.Address(RVA = "0xD12270", Offset = "0xD10C70", VA = "0x180D12270")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60003FB")]
		[Cpp2IlInjected.Address(RVA = "0xD16C40", Offset = "0xD15640", VA = "0x180D16C40")]
		public ModifyTagsRequest()
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x200008B")]
	[Utf8JsonSerializable]
	public class InventionModifyTagsRequest : ModifyTagsRequest
	{
		[Cpp2IlInjected.Token(Token = "0x170001DA")]
		public long InventionId
		{
			[Cpp2IlInjected.Token(Token = "0x60003FC")]
			[Cpp2IlInjected.Address(RVA = "0xD12BC0", Offset = "0xD115C0", VA = "0x180D12BC0")]
			[CompilerGenerated]
			get
			{
				return default(long);
			}
			[Cpp2IlInjected.Token(Token = "0x60003FD")]
			[Cpp2IlInjected.Address(RVA = "0xE3F130", Offset = "0xE3DB30", VA = "0x180E3F130")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60003FE")]
		[Cpp2IlInjected.Address(RVA = "0xD16C40", Offset = "0xD15640", VA = "0x180D16C40")]
		public InventionModifyTagsRequest()
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x200008C")]
	[Utf8JsonSerializable]
	public class ReportRequest
	{
		[Cpp2IlInjected.Token(Token = "0x170001DB")]
		public long InventionId
		{
			[Cpp2IlInjected.Token(Token = "0x60003FF")]
			[Cpp2IlInjected.Address(RVA = "0xD117B0", Offset = "0xD101B0", VA = "0x180D117B0")]
			[CompilerGenerated]
			get
			{
				return default(long);
			}
			[Cpp2IlInjected.Token(Token = "0x6000400")]
			[Cpp2IlInjected.Address(RVA = "0xED90B0", Offset = "0xED7AB0", VA = "0x180ED90B0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001DC")]
		public string Details
		{
			[Cpp2IlInjected.Token(Token = "0x6000401")]
			[Cpp2IlInjected.Address(RVA = "0xD11B30", Offset = "0xD10530", VA = "0x180D11B30")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000402")]
			[Cpp2IlInjected.Address(RVA = "0xD12270", Offset = "0xD10C70", VA = "0x180D12270")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001DD")]
		public InventionReportCategory ReportCategory
		{
			[Cpp2IlInjected.Token(Token = "0x6000403")]
			[Cpp2IlInjected.Address(RVA = "0xD215F0", Offset = "0xD1FFF0", VA = "0x180D215F0")]
			[CompilerGenerated]
			get
			{
				return default(InventionReportCategory);
			}
			[Cpp2IlInjected.Token(Token = "0x6000404")]
			[Cpp2IlInjected.Address(RVA = "0xD682F0", Offset = "0xD66CF0", VA = "0x180D682F0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000405")]
		[Cpp2IlInjected.Address(RVA = "0xD16C40", Offset = "0xD15640", VA = "0x180D16C40")]
		public ReportRequest()
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x200008D")]
	[Utf8JsonSerializable]
	public class CheerRequest
	{
		[Cpp2IlInjected.Token(Token = "0x170001DE")]
		public long InventionId
		{
			[Cpp2IlInjected.Token(Token = "0x6000406")]
			[Cpp2IlInjected.Address(RVA = "0xD117B0", Offset = "0xD101B0", VA = "0x180D117B0")]
			[CompilerGenerated]
			get
			{
				return default(long);
			}
			[Cpp2IlInjected.Token(Token = "0x6000407")]
			[Cpp2IlInjected.Address(RVA = "0xED90B0", Offset = "0xED7AB0", VA = "0x180ED90B0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001DF")]
		public bool Cheer
		{
			[Cpp2IlInjected.Token(Token = "0x6000408")]
			[Cpp2IlInjected.Address(RVA = "0xEB2260", Offset = "0xEB0C60", VA = "0x180EB2260")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000409")]
			[Cpp2IlInjected.Address(RVA = "0xD19FA0", Offset = "0xD189A0", VA = "0x180D19FA0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600040A")]
		[Cpp2IlInjected.Address(RVA = "0xD16C40", Offset = "0xD15640", VA = "0x180D16C40")]
		public CheerRequest()
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x200008E")]
	[Utf8JsonSerializable]
	public class UpdatePriceRequest
	{
		[Cpp2IlInjected.Token(Token = "0x170001E0")]
		public long InventionId
		{
			[Cpp2IlInjected.Token(Token = "0x600040B")]
			[Cpp2IlInjected.Address(RVA = "0xD117B0", Offset = "0xD101B0", VA = "0x180D117B0")]
			[CompilerGenerated]
			get
			{
				return default(long);
			}
			[Cpp2IlInjected.Token(Token = "0x600040C")]
			[Cpp2IlInjected.Address(RVA = "0xED90B0", Offset = "0xED7AB0", VA = "0x180ED90B0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001E1")]
		public int Price
		{
			[Cpp2IlInjected.Token(Token = "0x600040D")]
			[Cpp2IlInjected.Address(RVA = "0xD17340", Offset = "0xD15D40", VA = "0x180D17340")]
			[CompilerGenerated]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x600040E")]
			[Cpp2IlInjected.Address(RVA = "0xD17360", Offset = "0xD15D60", VA = "0x180D17360")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600040F")]
		[Cpp2IlInjected.Address(RVA = "0xD16C40", Offset = "0xD15640", VA = "0x180D16C40")]
		public UpdatePriceRequest()
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x200008F")]
	[Utf8JsonSerializable]
	public class UpdateInventionMetadataRequest
	{
		[Cpp2IlInjected.Token(Token = "0x170001E2")]
		public long InventionId
		{
			[Cpp2IlInjected.Token(Token = "0x6000410")]
			[Cpp2IlInjected.Address(RVA = "0xD117B0", Offset = "0xD101B0", VA = "0x180D117B0")]
			[CompilerGenerated]
			get
			{
				return default(long);
			}
			[Cpp2IlInjected.Token(Token = "0x6000411")]
			[Cpp2IlInjected.Address(RVA = "0xED90B0", Offset = "0xED7AB0", VA = "0x180ED90B0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001E3")]
		public string Name
		{
			[Cpp2IlInjected.Token(Token = "0x6000412")]
			[Cpp2IlInjected.Address(RVA = "0xD11B30", Offset = "0xD10530", VA = "0x180D11B30")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000413")]
			[Cpp2IlInjected.Address(RVA = "0xD12270", Offset = "0xD10C70", VA = "0x180D12270")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001E4")]
		public string Description
		{
			[Cpp2IlInjected.Token(Token = "0x6000414")]
			[Cpp2IlInjected.Address(RVA = "0xD12BC0", Offset = "0xD115C0", VA = "0x180D12BC0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000415")]
			[Cpp2IlInjected.Address(RVA = "0xD11520", Offset = "0xD0FF20", VA = "0x180D11520")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001E5")]
		public string LongDescription
		{
			[Cpp2IlInjected.Token(Token = "0x6000416")]
			[Cpp2IlInjected.Address(RVA = "0xD11B00", Offset = "0xD10500", VA = "0x180D11B00")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000417")]
			[Cpp2IlInjected.Address(RVA = "0xD11530", Offset = "0xD0FF30", VA = "0x180D11530")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001E6")]
		public string ImageName
		{
			[Cpp2IlInjected.Token(Token = "0x6000418")]
			[Cpp2IlInjected.Address(RVA = "0xD11A20", Offset = "0xD10420", VA = "0x180D11A20")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000419")]
			[Cpp2IlInjected.Address(RVA = "0xD17350", Offset = "0xD15D50", VA = "0x180D17350")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001E7")]
		public ModifyTagsRequest TagsRequest
		{
			[Cpp2IlInjected.Token(Token = "0x600041A")]
			[Cpp2IlInjected.Address(RVA = "0xD12280", Offset = "0xD10C80", VA = "0x180D12280")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600041B")]
			[Cpp2IlInjected.Address(RVA = "0xD11B50", Offset = "0xD10550", VA = "0x180D11B50")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600041C")]
		[Cpp2IlInjected.Address(RVA = "0xD16C40", Offset = "0xD15640", VA = "0x180D16C40")]
		public UpdateInventionMetadataRequest()
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000090")]
	[Utf8JsonSerializable]
	public class UpdateInventionGeneralPermissionRequest
	{
		[Cpp2IlInjected.Token(Token = "0x170001E8")]
		public long InventionId
		{
			[Cpp2IlInjected.Token(Token = "0x600041D")]
			[Cpp2IlInjected.Address(RVA = "0xD117B0", Offset = "0xD101B0", VA = "0x180D117B0")]
			[CompilerGenerated]
			get
			{
				return default(long);
			}
			[Cpp2IlInjected.Token(Token = "0x600041E")]
			[Cpp2IlInjected.Address(RVA = "0xED90B0", Offset = "0xED7AB0", VA = "0x180ED90B0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001E9")]
		public InventionPermission Permission
		{
			[Cpp2IlInjected.Token(Token = "0x600041F")]
			[Cpp2IlInjected.Address(RVA = "0xD17340", Offset = "0xD15D40", VA = "0x180D17340")]
			[CompilerGenerated]
			get
			{
				return default(InventionPermission);
			}
			[Cpp2IlInjected.Token(Token = "0x6000420")]
			[Cpp2IlInjected.Address(RVA = "0xD17360", Offset = "0xD15D60", VA = "0x180D17360")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000421")]
		[Cpp2IlInjected.Address(RVA = "0xD16C40", Offset = "0xD15640", VA = "0x180D16C40")]
		public UpdateInventionGeneralPermissionRequest()
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000091")]
	[Utf8JsonSerializable]
	public class PublishInventionRequest
	{
		[Cpp2IlInjected.Token(Token = "0x170001EA")]
		public long InventionId
		{
			[Cpp2IlInjected.Token(Token = "0x6000422")]
			[Cpp2IlInjected.Address(RVA = "0xD117B0", Offset = "0xD101B0", VA = "0x180D117B0")]
			[CompilerGenerated]
			get
			{
				return default(long);
			}
			[Cpp2IlInjected.Token(Token = "0x6000423")]
			[Cpp2IlInjected.Address(RVA = "0xED90B0", Offset = "0xED7AB0", VA = "0x180ED90B0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001EB")]
		public InventionPermission Permission
		{
			[Cpp2IlInjected.Token(Token = "0x6000424")]
			[Cpp2IlInjected.Address(RVA = "0xD17340", Offset = "0xD15D40", VA = "0x180D17340")]
			[CompilerGenerated]
			get
			{
				return default(InventionPermission);
			}
			[Cpp2IlInjected.Token(Token = "0x6000425")]
			[Cpp2IlInjected.Address(RVA = "0xD17360", Offset = "0xD15D60", VA = "0x180D17360")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001EC")]
		public UgcAccessibility Accessibility
		{
			[Cpp2IlInjected.Token(Token = "0x6000426")]
			[Cpp2IlInjected.Address(RVA = "0x1664600", Offset = "0x1663000", VA = "0x181664600")]
			[CompilerGenerated]
			get
			{
				return default(UgcAccessibility);
			}
			[Cpp2IlInjected.Token(Token = "0x6000427")]
			[Cpp2IlInjected.Address(RVA = "0x1664610", Offset = "0x1663010", VA = "0x181664610")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001ED")]
		public int? Price
		{
			[Cpp2IlInjected.Token(Token = "0x6000428")]
			[Cpp2IlInjected.Address(RVA = "0xD12BC0", Offset = "0xD115C0", VA = "0x180D12BC0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000429")]
			[Cpp2IlInjected.Address(RVA = "0xE3F130", Offset = "0xE3DB30", VA = "0x180E3F130")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600042A")]
		[Cpp2IlInjected.Address(RVA = "0xD16C40", Offset = "0xD15640", VA = "0x180D16C40")]
		public PublishInventionRequest()
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000092")]
	[Utf8JsonSerializable]
	public class UnpublishInventionRequest
	{
		[Cpp2IlInjected.Token(Token = "0x170001EE")]
		public long InventionId
		{
			[Cpp2IlInjected.Token(Token = "0x600042B")]
			[Cpp2IlInjected.Address(RVA = "0xD117B0", Offset = "0xD101B0", VA = "0x180D117B0")]
			[CompilerGenerated]
			get
			{
				return default(long);
			}
			[Cpp2IlInjected.Token(Token = "0x600042C")]
			[Cpp2IlInjected.Address(RVA = "0xED90B0", Offset = "0xED7AB0", VA = "0x180ED90B0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600042D")]
		[Cpp2IlInjected.Address(RVA = "0xD16C40", Offset = "0xD15640", VA = "0x180D16C40")]
		public UnpublishInventionRequest()
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000093")]
	[Utf8JsonSerializable]
	public class DeleteInventionRequest
	{
		[Cpp2IlInjected.Token(Token = "0x170001EF")]
		public long InventionId
		{
			[Cpp2IlInjected.Token(Token = "0x600042E")]
			[Cpp2IlInjected.Address(RVA = "0xD117B0", Offset = "0xD101B0", VA = "0x180D117B0")]
			[CompilerGenerated]
			get
			{
				return default(long);
			}
			[Cpp2IlInjected.Token(Token = "0x600042F")]
			[Cpp2IlInjected.Address(RVA = "0xED90B0", Offset = "0xED7AB0", VA = "0x180ED90B0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000430")]
		[Cpp2IlInjected.Address(RVA = "0xD16C40", Offset = "0xD15640", VA = "0x180D16C40")]
		public DeleteInventionRequest()
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000094")]
	[Utf8JsonSerializable]
	public class SetInventionVersionAccessibilityRequest
	{
		[Cpp2IlInjected.Token(Token = "0x170001F0")]
		public long InventionId
		{
			[Cpp2IlInjected.Token(Token = "0x6000431")]
			[Cpp2IlInjected.Address(RVA = "0xD117B0", Offset = "0xD101B0", VA = "0x180D117B0")]
			[CompilerGenerated]
			get
			{
				return default(long);
			}
			[Cpp2IlInjected.Token(Token = "0x6000432")]
			[Cpp2IlInjected.Address(RVA = "0xED90B0", Offset = "0xED7AB0", VA = "0x180ED90B0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001F1")]
		public int VersionNumber
		{
			[Cpp2IlInjected.Token(Token = "0x6000433")]
			[Cpp2IlInjected.Address(RVA = "0xD17340", Offset = "0xD15D40", VA = "0x180D17340")]
			[CompilerGenerated]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x6000434")]
			[Cpp2IlInjected.Address(RVA = "0xD17360", Offset = "0xD15D60", VA = "0x180D17360")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001F2")]
		public UgcAccessibility NewAccessibility
		{
			[Cpp2IlInjected.Token(Token = "0x6000435")]
			[Cpp2IlInjected.Address(RVA = "0x1664600", Offset = "0x1663000", VA = "0x181664600")]
			[CompilerGenerated]
			get
			{
				return default(UgcAccessibility);
			}
			[Cpp2IlInjected.Token(Token = "0x6000436")]
			[Cpp2IlInjected.Address(RVA = "0x1664610", Offset = "0x1663010", VA = "0x181664610")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000437")]
		[Cpp2IlInjected.Address(RVA = "0xD16C40", Offset = "0xD15640", VA = "0x180D16C40")]
		public SetInventionVersionAccessibilityRequest()
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000095")]
	[Utf8JsonSerializable]
	public class SpecialTags
	{
		[Cpp2IlInjected.Token(Token = "0x170001F3")]
		public List<string> AutoTags
		{
			[Cpp2IlInjected.Token(Token = "0x6000438")]
			[Cpp2IlInjected.Address(RVA = "0xD117B0", Offset = "0xD101B0", VA = "0x180D117B0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000439")]
			[Cpp2IlInjected.Address(RVA = "0xD117C0", Offset = "0xD101C0", VA = "0x180D117C0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001F4")]
		public List<string> AGOnlyTags
		{
			[Cpp2IlInjected.Token(Token = "0x600043A")]
			[Cpp2IlInjected.Address(RVA = "0xD11B30", Offset = "0xD10530", VA = "0x180D11B30")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600043B")]
			[Cpp2IlInjected.Address(RVA = "0xD12270", Offset = "0xD10C70", VA = "0x180D12270")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600043C")]
		[Cpp2IlInjected.Address(RVA = "0xD16C40", Offset = "0xD15640", VA = "0x180D16C40")]
		public SpecialTags()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000096")]
	public enum InventionResult
	{
		[Cpp2IlInjected.Token(Token = "0x40001FE")]
		Success,
		[Cpp2IlInjected.Token(Token = "0x40001FF")]
		InvalidParameters,
		[Cpp2IlInjected.Token(Token = "0x4000200")]
		PlayerCannotUpload,
		[Cpp2IlInjected.Token(Token = "0x4000201")]
		DuplicateName,
		[Cpp2IlInjected.Token(Token = "0x4000202")]
		NameTooShort,
		[Cpp2IlInjected.Token(Token = "0x4000203")]
		NameTooLong,
		[Cpp2IlInjected.Token(Token = "0x4000204")]
		NotCreator,
		[Cpp2IlInjected.Token(Token = "0x4000205")]
		DoesNotExist,
		[Cpp2IlInjected.Token(Token = "0x4000206")]
		ImageDoesNotExist,
		[Cpp2IlInjected.Token(Token = "0x4000207")]
		InventionLimitReached,
		[Cpp2IlInjected.Token(Token = "0x4000208")]
		DescriptionTooLong,
		[Cpp2IlInjected.Token(Token = "0x4000209")]
		InnapropriateName,
		[Cpp2IlInjected.Token(Token = "0x400020A")]
		InappropriateDescription,
		[Cpp2IlInjected.Token(Token = "0x400020B")]
		CannotBeModified,
		[Cpp2IlInjected.Token(Token = "0x400020C")]
		PlayerCannotPublish,
		[Cpp2IlInjected.Token(Token = "0x400020D")]
		AlreadyPublished,
		[Cpp2IlInjected.Token(Token = "0x400020E")]
		AlreadyUnpublished,
		[Cpp2IlInjected.Token(Token = "0x400020F")]
		InventionUnderModerationReview,
		[Cpp2IlInjected.Token(Token = "0x4000210")]
		PlayerCannotDownload,
		[Cpp2IlInjected.Token(Token = "0x4000211")]
		PlayerAlreadyOwns,
		[Cpp2IlInjected.Token(Token = "0x4000212")]
		DescriptionTooShort,
		[Cpp2IlInjected.Token(Token = "0x4000213")]
		DoesNotHavePermission,
		[Cpp2IlInjected.Token(Token = "0x4000214")]
		PermissionLevelCannotBeChanged,
		[Cpp2IlInjected.Token(Token = "0x4000215")]
		AlreadyCheered,
		[Cpp2IlInjected.Token(Token = "0x4000216")]
		AlreadyRemovedCheer,
		[Cpp2IlInjected.Token(Token = "0x4000217")]
		ModeratorRestrictedPublishing,
		[Cpp2IlInjected.Token(Token = "0x4000218")]
		PlayerCannotSell,
		[Cpp2IlInjected.Token(Token = "0x4000219")]
		InvalidPrice,
		[Cpp2IlInjected.Token(Token = "0x400021A")]
		PriceCannotBeChanged,
		[Cpp2IlInjected.Token(Token = "0x400021B")]
		InvalidPermissionForPaidInvention,
		[Cpp2IlInjected.Token(Token = "0x400021C")]
		PurchaseFailed,
		[Cpp2IlInjected.Token(Token = "0x400021D")]
		CannotDownloadPaidInvention,
		[Cpp2IlInjected.Token(Token = "0x400021E")]
		CannotSellUnownedLineage,
		[Cpp2IlInjected.Token(Token = "0x400021F")]
		DoesNotAllowTrial,
		[Cpp2IlInjected.Token(Token = "0x4000220")]
		StillOnTrialCooldown,
		[Cpp2IlInjected.Token(Token = "0x4000221")]
		PlayerCannotTrial,
		[Cpp2IlInjected.Token(Token = "0x4000222")]
		PaidInventionPublishingDisabled,
		[Cpp2IlInjected.Token(Token = "0x4000223")]
		PaidInventionPurchasingDisabled,
		[Cpp2IlInjected.Token(Token = "0x4000224")]
		OperationIsDisabled,
		[Cpp2IlInjected.Token(Token = "0x4000225")]
		PlayerRestrictedFromP2PSelling,
		[Cpp2IlInjected.Token(Token = "0x4000226")]
		PlayerNotRecRoomPlusMember,
		[Cpp2IlInjected.Token(Token = "0x4000227")]
		InvalidInstantiationCost,
		[Cpp2IlInjected.Token(Token = "0x4000228")]
		FeaturedInventionNotPublished,
		[Cpp2IlInjected.Token(Token = "0x4000229")]
		FeaturedInventionNotActive,
		[Cpp2IlInjected.Token(Token = "0x400022A")]
		InventionContainsBlockedFiles,
		[Cpp2IlInjected.Token(Token = "0x400022B")]
		PlayerRestrictedFromP2PBuying,
		[Cpp2IlInjected.Token(Token = "0x400022C")]
		ReservedWordRuleViolationInName,
		[Cpp2IlInjected.Token(Token = "0x400022D")]
		ReservedWordRuleViolationInDescription,
		[Cpp2IlInjected.Token(Token = "0x400022E")]
		InventionContainsBetaContent,
		[Cpp2IlInjected.Token(Token = "0x400022F")]
		PlatformDoesntSupportPublishing,
		[Cpp2IlInjected.Token(Token = "0x4000230")]
		MismatchedUgcVersions,
		[Cpp2IlInjected.Token(Token = "0x4000231")]
		ConvertedFromSameUgcVersion,
		[Cpp2IlInjected.Token(Token = "0x4000232")]
		ConvertedFromInventionDoesNotExist,
		[Cpp2IlInjected.Token(Token = "0x4000233")]
		ConvertedFromInventionHigherVersion,
		[Cpp2IlInjected.Token(Token = "0x4000234")]
		PlatformDoesntSupportInvention
	}
	[Cpp2IlInjected.Token(Token = "0x2000097")]
	public enum InventionReportCategory
	{
		[Cpp2IlInjected.Token(Token = "0x4000236")]
		Unknown = -1,
		[Cpp2IlInjected.Token(Token = "0x4000237")]
		CoC_Discriminatory,
		[Cpp2IlInjected.Token(Token = "0x4000238")]
		CoC_Sexual,
		[Cpp2IlInjected.Token(Token = "0x4000239")]
		CoC_Trolling,
		[Cpp2IlInjected.Token(Token = "0x400023A")]
		Misleading,
		[Cpp2IlInjected.Token(Token = "0x400023B")]
		Other
	}
	[Cpp2IlInjected.Token(Token = "0x2000098")]
	public enum RoomPermissionValue
	{
		[Cpp2IlInjected.Token(Token = "0x400023D")]
		False,
		[Cpp2IlInjected.Token(Token = "0x400023E")]
		True,
		[Cpp2IlInjected.Token(Token = "0x400023F")]
		Invited
	}
	[Cpp2IlInjected.Token(Token = "0x2000099")]
	public interface FFKTLYRIXRZ
	{
		[Cpp2IlInjected.Token(Token = "0x170001F5")]
		PlatformType Platform
		{
			[Cpp2IlInjected.Token(Token = "0x600043D")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x170001F6")]
		string PlatformId
		{
			[Cpp2IlInjected.Token(Token = "0x600043E")]
			[Cpp2IlInjected.Address(Slot = "1")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x170001F7")]
		int AccountId
		{
			[Cpp2IlInjected.Token(Token = "0x600043F")]
			[Cpp2IlInjected.Address(Slot = "2")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x170001F8")]
		DateTime LastLoginTime
		{
			[Cpp2IlInjected.Token(Token = "0x6000440")]
			[Cpp2IlInjected.Address(Slot = "3")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x170001F9")]
		bool RequirePassword
		{
			[Cpp2IlInjected.Token(Token = "0x6000441")]
			[Cpp2IlInjected.Address(Slot = "4")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x170001FA")]
		string RefreshToken
		{
			[Cpp2IlInjected.Token(Token = "0x6000442")]
			[Cpp2IlInjected.Address(Slot = "5")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x170001FB")]
		QZBSYAZDSCL Account
		{
			[Cpp2IlInjected.Token(Token = "0x6000443")]
			[Cpp2IlInjected.Address(Slot = "6")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x6000444")]
		[Cpp2IlInjected.Address(Slot = "7")]
		void RCMEVXVPWDM(QZBSYAZDSCL a);
	}
	[Cpp2IlInjected.Token(Token = "0x200009A")]
	public interface ROOLLGEASOG
	{
		[Cpp2IlInjected.Token(Token = "0x170001FC")]
		string Text
		{
			[Cpp2IlInjected.Token(Token = "0x6000445")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x170001FD")]
		int Length
		{
			[Cpp2IlInjected.Token(Token = "0x6000446")]
			[Cpp2IlInjected.Address(Slot = "1")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x170001FE")]
		bool AllowAlpha
		{
			[Cpp2IlInjected.Token(Token = "0x6000447")]
			[Cpp2IlInjected.Address(Slot = "2")]
			get;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200009B")]
	public struct LoginResult
	{
		[Cpp2IlInjected.Token(Token = "0x170001FF")]
		public LoginStatus Status
		{
			[Cpp2IlInjected.Token(Token = "0x6000449")]
			[Cpp2IlInjected.Address(RVA = "0xF86CD0", Offset = "0xF856D0", VA = "0x180F86CD0")]
			[CompilerGenerated]
			readonly get
			{
				return default(LoginStatus);
			}
			[Cpp2IlInjected.Token(Token = "0x600044A")]
			[Cpp2IlInjected.Address(RVA = "0x15E9000", Offset = "0x15E7A00", VA = "0x1815E9000")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000200")]
		public ROOLLGEASOG SecurityCodeHint
		{
			[Cpp2IlInjected.Token(Token = "0x600044B")]
			[Cpp2IlInjected.Address(RVA = "0xF5DD60", Offset = "0xF5C760", VA = "0x180F5DD60")]
			[CompilerGenerated]
			readonly get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600044C")]
			[Cpp2IlInjected.Address(RVA = "0xF5DD70", Offset = "0xF5C770", VA = "0x180F5DD70")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000201")]
		public string LoginContext
		{
			[Cpp2IlInjected.Token(Token = "0x600044D")]
			[Cpp2IlInjected.Address(RVA = "0xD117B0", Offset = "0xD101B0", VA = "0x180D117B0")]
			[CompilerGenerated]
			readonly get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600044E")]
			[Cpp2IlInjected.Address(RVA = "0xD117C0", Offset = "0xD101C0", VA = "0x180D117C0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000448")]
		[Cpp2IlInjected.Address(RVA = "0x82FB9D0", Offset = "0x82FA3D0", VA = "0x1882FB9D0")]
		public LoginResult(LoginStatus status, [Optional] ROOLLGEASOG securityCodeHint, [Optional] string loginContext)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200009C")]
	public enum LoginStatus
	{
		[Cpp2IlInjected.Token(Token = "0x4000244")]
		Unknown,
		[Cpp2IlInjected.Token(Token = "0x4000245")]
		Success,
		[Cpp2IlInjected.Token(Token = "0x4000246")]
		ContinueSecurityCode,
		[Cpp2IlInjected.Token(Token = "0x4000247")]
		TryAgainSecurityCode,
		[Cpp2IlInjected.Token(Token = "0x4000248")]
		RemoteAuthPending
	}
	[Cpp2IlInjected.Token(Token = "0x200009D")]
	public interface OIRXPKYYAWC
	{
		[Cpp2IlInjected.Token(Token = "0x600044F")]
		[Cpp2IlInjected.Address(Slot = "0")]
		void HHUGNWFYOZL();
	}
	[Cpp2IlInjected.Token(Token = "0x200009E")]
	public interface QPSFFVWODNU
	{
		[Cpp2IlInjected.Token(Token = "0x6000450")]
		[Cpp2IlInjected.Address(Slot = "0")]
		Task NLARVXFWNGH();
	}
	[Cpp2IlInjected.Token(Token = "0x200009F")]
	[Utf8JsonSerializable]
	public class OutfitSelectionDTO
	{
		[Cpp2IlInjected.Token(Token = "0x17000202")]
		public Guid CustomAvatarItemId
		{
			[Cpp2IlInjected.Token(Token = "0x6000453")]
			[Cpp2IlInjected.Address(RVA = "0xF357F0", Offset = "0xF341F0", VA = "0x180F357F0")]
			[CompilerGenerated]
			get
			{
				return default(Guid);
			}
			[Cpp2IlInjected.Token(Token = "0x6000454")]
			[Cpp2IlInjected.Address(RVA = "0xF35810", Offset = "0xF34210", VA = "0x180F35810")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000203")]
		public int BodyPart
		{
			[Cpp2IlInjected.Token(Token = "0x6000455")]
			[Cpp2IlInjected.Address(RVA = "0xD215F0", Offset = "0xD1FFF0", VA = "0x180D215F0")]
			[CompilerGenerated]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x6000456")]
			[Cpp2IlInjected.Address(RVA = "0xD682F0", Offset = "0xD66CF0", VA = "0x180D682F0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000204")]
		public string BakedUnityAssetFileName
		{
			[Cpp2IlInjected.Token(Token = "0x6000457")]
			[Cpp2IlInjected.Address(RVA = "0xD11B00", Offset = "0xD10500", VA = "0x180D11B00")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000458")]
			[Cpp2IlInjected.Address(RVA = "0xD11530", Offset = "0xD0FF30", VA = "0x180D11530")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000205")]
		public string AdditionalConfiguration
		{
			[Cpp2IlInjected.Token(Token = "0x6000459")]
			[Cpp2IlInjected.Address(RVA = "0xD11A20", Offset = "0xD10420", VA = "0x180D11A20")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600045A")]
			[Cpp2IlInjected.Address(RVA = "0xD17350", Offset = "0xD15D50", VA = "0x180D17350")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000451")]
		[Cpp2IlInjected.Address(RVA = "0xD16C40", Offset = "0xD15640", VA = "0x180D16C40")]
		public OutfitSelectionDTO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000452")]
		[Cpp2IlInjected.Address(RVA = "0x8DC3C30", Offset = "0x8DC2630", VA = "0x188DC3C30")]
		public OutfitSelectionDTO([Optional] Guid customAvatarItemId, int bodyPart = 0, [Optional] string bakedUnityAssetFileName, [Optional] string additionalConfiguration)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000A0")]
	[Utf8JsonSerializable]
	public class OutfitDTO
	{
		[Cpp2IlInjected.Token(Token = "0x400024D")]
		public const int CurrentOutfitSlot = 0;

		[Cpp2IlInjected.Token(Token = "0x17000206")]
		public long DataVersion
		{
			[Cpp2IlInjected.Token(Token = "0x600045D")]
			[Cpp2IlInjected.Address(RVA = "0xD117B0", Offset = "0xD101B0", VA = "0x180D117B0")]
			[CompilerGenerated]
			get
			{
				return default(long);
			}
			[Cpp2IlInjected.Token(Token = "0x600045E")]
			[Cpp2IlInjected.Address(RVA = "0xED90B0", Offset = "0xED7AB0", VA = "0x180ED90B0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000207")]
		public LegacyOutfitDataDTO LegacyData
		{
			[Cpp2IlInjected.Token(Token = "0x600045F")]
			[Cpp2IlInjected.Address(RVA = "0xD11B30", Offset = "0xD10530", VA = "0x180D11B30")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000460")]
			[Cpp2IlInjected.Address(RVA = "0xD12270", Offset = "0xD10C70", VA = "0x180D12270")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000208")]
		public string CustomizationSettings
		{
			[Cpp2IlInjected.Token(Token = "0x6000461")]
			[Cpp2IlInjected.Address(RVA = "0xD12BC0", Offset = "0xD115C0", VA = "0x180D12BC0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000462")]
			[Cpp2IlInjected.Address(RVA = "0xD11520", Offset = "0xD0FF20", VA = "0x180D11520")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000209")]
		public List<OutfitSelectionDTO> Selections
		{
			[Cpp2IlInjected.Token(Token = "0x6000463")]
			[Cpp2IlInjected.Address(RVA = "0xD11B00", Offset = "0xD10500", VA = "0x180D11B00")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000464")]
			[Cpp2IlInjected.Address(RVA = "0xD11530", Offset = "0xD0FF30", VA = "0x180D11530")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700020A")]
		public int Slot
		{
			[Cpp2IlInjected.Token(Token = "0x6000465")]
			[Cpp2IlInjected.Address(RVA = "0xD1B6C0", Offset = "0xD1A0C0", VA = "0x180D1B6C0")]
			[CompilerGenerated]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x6000466")]
			[Cpp2IlInjected.Address(RVA = "0xD1B020", Offset = "0xD19A20", VA = "0x180D1B020")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700020B")]
		public string Name
		{
			[Cpp2IlInjected.Token(Token = "0x6000467")]
			[Cpp2IlInjected.Address(RVA = "0xD12280", Offset = "0xD10C80", VA = "0x180D12280")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000468")]
			[Cpp2IlInjected.Address(RVA = "0xD11B50", Offset = "0xD10550", VA = "0x180D11B50")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700020C")]
		public UgcAccessibility Accessibility
		{
			[Cpp2IlInjected.Token(Token = "0x6000469")]
			[Cpp2IlInjected.Address(RVA = "0xD2DD40", Offset = "0xD2C740", VA = "0x180D2DD40")]
			[CompilerGenerated]
			get
			{
				return default(UgcAccessibility);
			}
			[Cpp2IlInjected.Token(Token = "0x600046A")]
			[Cpp2IlInjected.Address(RVA = "0xD89720", Offset = "0xD88120", VA = "0x180D89720")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700020D")]
		public string ThumbnailFileName
		{
			[Cpp2IlInjected.Token(Token = "0x600046B")]
			[Cpp2IlInjected.Address(RVA = "0xD122E0", Offset = "0xD10CE0", VA = "0x180D122E0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600046C")]
			[Cpp2IlInjected.Address(RVA = "0xD12290", Offset = "0xD10C90", VA = "0x180D12290")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700020E")]
		public bool IsCurrentlyEquipped
		{
			[Cpp2IlInjected.Token(Token = "0x600046D")]
			[Cpp2IlInjected.Address(RVA = "0x239AC00", Offset = "0x2399600", VA = "0x18239AC00")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600045B")]
		[Cpp2IlInjected.Address(RVA = "0x8DC3A80", Offset = "0x8DC2480", VA = "0x188DC3A80")]
		public OutfitDTO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600045C")]
		[Cpp2IlInjected.Address(RVA = "0x8DC3960", Offset = "0x8DC2360", VA = "0x188DC3960")]
		public OutfitDTO(long dataVersion = 0L, [Optional] LegacyOutfitDataDTO legacyData, [Optional] string customizationSettings, [Optional] List<OutfitSelectionDTO> selections, int slot = 0, [Optional] string name, UgcAccessibility accessibility = UgcAccessibility.Private, [Optional] string thumbnailFileName)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000A1")]
	public class RMXOMVSLPVV
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000256")]
		public readonly int JZYBMMFYCPX;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000257")]
		public readonly OutfitDTO NFOMILEMEXM;

		[Cpp2IlInjected.Token(Token = "0x600046E")]
		[Cpp2IlInjected.Address(RVA = "0x10B08A0", Offset = "0x10AF2A0", VA = "0x1810B08A0")]
		public RMXOMVSLPVV(int a, OutfitDTO b)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000A2")]
	[Utf8JsonSerializable]
	public class LegacyOutfitDataDTO
	{
		[Cpp2IlInjected.Token(Token = "0x1700020F")]
		public string SelectionsV1
		{
			[Cpp2IlInjected.Token(Token = "0x6000471")]
			[Cpp2IlInjected.Address(RVA = "0xD117B0", Offset = "0xD101B0", VA = "0x180D117B0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000472")]
			[Cpp2IlInjected.Address(RVA = "0xD117C0", Offset = "0xD101C0", VA = "0x180D117C0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000210")]
		public string SelectionsV2
		{
			[Cpp2IlInjected.Token(Token = "0x6000473")]
			[Cpp2IlInjected.Address(RVA = "0xD11B30", Offset = "0xD10530", VA = "0x180D11B30")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000474")]
			[Cpp2IlInjected.Address(RVA = "0xD12270", Offset = "0xD10C70", VA = "0x180D12270")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000211")]
		public string FaceFeatures
		{
			[Cpp2IlInjected.Token(Token = "0x6000475")]
			[Cpp2IlInjected.Address(RVA = "0xD12BC0", Offset = "0xD115C0", VA = "0x180D12BC0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000476")]
			[Cpp2IlInjected.Address(RVA = "0xD11520", Offset = "0xD0FF20", VA = "0x180D11520")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000212")]
		public string SkinColor
		{
			[Cpp2IlInjected.Token(Token = "0x6000477")]
			[Cpp2IlInjected.Address(RVA = "0xD11B00", Offset = "0xD10500", VA = "0x180D11B00")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000478")]
			[Cpp2IlInjected.Address(RVA = "0xD11530", Offset = "0xD0FF30", VA = "0x180D11530")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000213")]
		public string HairColor
		{
			[Cpp2IlInjected.Token(Token = "0x6000479")]
			[Cpp2IlInjected.Address(RVA = "0xD11A20", Offset = "0xD10420", VA = "0x180D11A20")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600047A")]
			[Cpp2IlInjected.Address(RVA = "0xD17350", Offset = "0xD15D50", VA = "0x180D17350")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000214")]
		public string Selections
		{
			[Cpp2IlInjected.Token(Token = "0x600047B")]
			[Cpp2IlInjected.Address(RVA = "0x8DC2B40", Offset = "0x8DC1540", VA = "0x188DC2B40")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600046F")]
		[Cpp2IlInjected.Address(RVA = "0xD16C40", Offset = "0xD15640", VA = "0x180D16C40")]
		public LegacyOutfitDataDTO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000470")]
		[Cpp2IlInjected.Address(RVA = "0x8B802A0", Offset = "0x8B7ECA0", VA = "0x188B802A0")]
		public LegacyOutfitDataDTO([Optional] string selectionsV1, [Optional] string selectionsV2, [Optional] string faceFeatures, [Optional] string skinColor, [Optional] string hairColor)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000A3")]
	[Utf8JsonSerializable]
	public class GetPlayersOutfitsResponseDTO
	{
		[Cpp2IlInjected.Token(Token = "0x17000215")]
		public Dictionary<int, OutfitDTO> OutfitsByAccountId
		{
			[Cpp2IlInjected.Token(Token = "0x600047C")]
			[Cpp2IlInjected.Address(RVA = "0xD117B0", Offset = "0xD101B0", VA = "0x180D117B0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600047D")]
			[Cpp2IlInjected.Address(RVA = "0xD117C0", Offset = "0xD101C0", VA = "0x180D117C0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600047E")]
		[Cpp2IlInjected.Address(RVA = "0xD16C40", Offset = "0xD15640", VA = "0x180D16C40")]
		public GetPlayersOutfitsResponseDTO()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000A4")]
	[Utf8JsonSerializable]
	public class GetPlayersOutfitsRequestDTO
	{
		[Cpp2IlInjected.Token(Token = "0x17000216")]
		public List<int> AccountIds
		{
			[Cpp2IlInjected.Token(Token = "0x600047F")]
			[Cpp2IlInjected.Address(RVA = "0xD117B0", Offset = "0xD101B0", VA = "0x180D117B0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000480")]
			[Cpp2IlInjected.Address(RVA = "0xD117C0", Offset = "0xD101C0", VA = "0x180D117C0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000217")]
		public byte? UnityAssetTarget
		{
			[Cpp2IlInjected.Token(Token = "0x6000481")]
			[Cpp2IlInjected.Address(RVA = "0x32E1100", Offset = "0x32DFB00", VA = "0x1832E1100")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000482")]
			[Cpp2IlInjected.Address(RVA = "0x32E10F0", Offset = "0x32DFAF0", VA = "0x1832E10F0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000218")]
		public int? UnityAssetVersion
		{
			[Cpp2IlInjected.Token(Token = "0x6000483")]
			[Cpp2IlInjected.Address(RVA = "0x141BB50", Offset = "0x141A550", VA = "0x18141BB50")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000484")]
			[Cpp2IlInjected.Address(RVA = "0x141BB80", Offset = "0x141A580", VA = "0x18141BB80")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000485")]
		[Cpp2IlInjected.Address(RVA = "0xD16C40", Offset = "0xD15640", VA = "0x180D16C40")]
		public GetPlayersOutfitsRequestDTO()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000A5")]
	public static class XLUNVHZATTZ
	{
		[Cpp2IlInjected.Token(Token = "0x6000486")]
		[Cpp2IlInjected.Address(RVA = "0x8DCACB0", Offset = "0x8DC96B0", VA = "0x188DCACB0")]
		public static CustomAvatarItemVisualData MLMEXSVPWHH(this OutfitSelectionDTO a)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000A6")]
	[Flags]
	public enum PlatformMask
	{
		[Cpp2IlInjected.Token(Token = "0x4000262")]
		None = 0,
		[Cpp2IlInjected.Token(Token = "0x4000263")]
		Steam = 1,
		[Cpp2IlInjected.Token(Token = "0x4000264")]
		Oculus = 2,
		[Cpp2IlInjected.Token(Token = "0x4000265")]
		PlayStation = 4,
		[Cpp2IlInjected.Token(Token = "0x4000266")]
		Xbox = 8,
		[Cpp2IlInjected.Token(Token = "0x4000267")]
		RecNet = 0x10,
		[Cpp2IlInjected.Token(Token = "0x4000268")]
		IOS = 0x20,
		[Cpp2IlInjected.Token(Token = "0x4000269")]
		GooglePlay = 0x40,
		[Cpp2IlInjected.Token(Token = "0x400026A")]
		Standalone = 0x80,
		[Cpp2IlInjected.Token(Token = "0x400026B")]
		Pico = 0x100,
		[Cpp2IlInjected.Token(Token = "0x400026C")]
		Switch = 0x200,
		[Cpp2IlInjected.Token(Token = "0x400026D")]
		All = -1
	}
	[Cpp2IlInjected.Token(Token = "0x20000A7")]
	public enum PlatformType
	{
		[Cpp2IlInjected.Token(Token = "0x400026F")]
		All = -1,
		[Cpp2IlInjected.Token(Token = "0x4000270")]
		Steam,
		[Cpp2IlInjected.Token(Token = "0x4000271")]
		Oculus,
		[Cpp2IlInjected.Token(Token = "0x4000272")]
		PlayStation,
		[Cpp2IlInjected.Token(Token = "0x4000273")]
		Xbox,
		[Cpp2IlInjected.Token(Token = "0x4000274")]
		RecNet,
		[Cpp2IlInjected.Token(Token = "0x4000275")]
		IOS,
		[Cpp2IlInjected.Token(Token = "0x4000276")]
		GooglePlay,
		[Cpp2IlInjected.Token(Token = "0x4000277")]
		Standalone,
		[Cpp2IlInjected.Token(Token = "0x4000278")]
		Pico,
		[Cpp2IlInjected.Token(Token = "0x4000279")]
		Switch
	}
	[Cpp2IlInjected.Token(Token = "0x20000A8")]
	[Utf8JsonSerializable]
	public class Progression
	{
		[Cpp2IlInjected.Token(Token = "0x17000219")]
		[DataMember(Name = "PlayerId")]
		public int AccountId
		{
			[Cpp2IlInjected.Token(Token = "0x6000487")]
			[Cpp2IlInjected.Address(RVA = "0xD0F110", Offset = "0xD0DB10", VA = "0x180D0F110")]
			[CompilerGenerated]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x6000488")]
			[Cpp2IlInjected.Address(RVA = "0xD12F30", Offset = "0xD11930", VA = "0x180D12F30")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700021A")]
		public int Level
		{
			[Cpp2IlInjected.Token(Token = "0x6000489")]
			[Cpp2IlInjected.Address(RVA = "0xE073A0", Offset = "0xE05DA0", VA = "0x180E073A0")]
			[CompilerGenerated]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x600048A")]
			[Cpp2IlInjected.Address(RVA = "0xE073B0", Offset = "0xE05DB0", VA = "0x180E073B0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700021B")]
		public int XP
		{
			[Cpp2IlInjected.Token(Token = "0x600048B")]
			[Cpp2IlInjected.Address(RVA = "0xD17340", Offset = "0xD15D40", VA = "0x180D17340")]
			[CompilerGenerated]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x600048C")]
			[Cpp2IlInjected.Address(RVA = "0xD17360", Offset = "0xD15D60", VA = "0x180D17360")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600048D")]
		[Cpp2IlInjected.Address(RVA = "0xD16C40", Offset = "0xD15640", VA = "0x180D16C40")]
		public Progression()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000A9")]
	public enum ObjectiveType
	{
		[Cpp2IlInjected.Token(Token = "0x400027E")]
		Default = -1,
		[Cpp2IlInjected.Token(Token = "0x400027F")]
		[Obsolete("This objective no longer gives a reward. - bilal - 10/22/2020")]
		FirstSessionOfDay = 1,
		[Cpp2IlInjected.Token(Token = "0x4000280")]
		AddAFriend = 2,
		[Cpp2IlInjected.Token(Token = "0x4000281")]
		PartyUp = 3,
		[Cpp2IlInjected.Token(Token = "0x4000282")]
		AllOtherChallenges = 4,
		[Cpp2IlInjected.Token(Token = "0x4000283")]
		[Obsolete("This is moved to server and won't be triggered in client - bilal - 8/3/2020")]
		LevelUp = 5,
		[Cpp2IlInjected.Token(Token = "0x4000284")]
		CheerAPlayer = 6,
		[Cpp2IlInjected.Token(Token = "0x4000285")]
		PointedAtPlayer = 7,
		[Cpp2IlInjected.Token(Token = "0x4000286")]
		CheerARoom = 8,
		[Cpp2IlInjected.Token(Token = "0x4000287")]
		SubscribeToPlayer = 9,
		[Cpp2IlInjected.Token(Token = "0x4000288")]
		DailyObjective1 = 10,
		[Cpp2IlInjected.Token(Token = "0x4000289")]
		DailyObjective2 = 11,
		[Cpp2IlInjected.Token(Token = "0x400028A")]
		DailyObjective3 = 12,
		[Cpp2IlInjected.Token(Token = "0x400028B")]
		AllDailyObjectives = 13,
		[Cpp2IlInjected.Token(Token = "0x400028C")]
		CompleteAnyDaily = 14,
		[Cpp2IlInjected.Token(Token = "0x400028D")]
		CompleteAnyWeekly = 15,
		[Cpp2IlInjected.Token(Token = "0x400028E")]
		[Obsolete("This is old out of box experience flags, we are using the term nux now - bilal - 3/10/2022")]
		OOBE_GoToLockerRoom = 20,
		[Cpp2IlInjected.Token(Token = "0x400028F")]
		[Obsolete("This is old out of box experience flags, we are using the term nux now - bilal - 3/10/2022")]
		OOBE_GoToActivity = 21,
		[Cpp2IlInjected.Token(Token = "0x4000290")]
		[Obsolete("This is old out of box experience flags, we are using the term nux now - bilal - 3/10/2022")]
		OOBE_FinishActivity = 22,
		[Cpp2IlInjected.Token(Token = "0x4000291")]
		NUX_PunchcardObjective = 25,
		[Cpp2IlInjected.Token(Token = "0x4000292")]
		NUX_AllPunchcardObjectives = 26,
		[Cpp2IlInjected.Token(Token = "0x4000293")]
		GoToRecCenter = 30,
		[Cpp2IlInjected.Token(Token = "0x4000294")]
		FinishActivity = 31,
		[Cpp2IlInjected.Token(Token = "0x4000295")]
		VisitACustomRoom = 32,
		[Cpp2IlInjected.Token(Token = "0x4000296")]
		CreateACustomRoom = 33,
		[Cpp2IlInjected.Token(Token = "0x4000297")]
		ScoreBasketInRecCenter = 35,
		[Cpp2IlInjected.Token(Token = "0x4000298")]
		UploadPhotoToRecNet = 36,
		[Cpp2IlInjected.Token(Token = "0x4000299")]
		UpdatePlayerBio = 37,
		[Cpp2IlInjected.Token(Token = "0x400029A")]
		SaveOutfitSlot = 38,
		[Cpp2IlInjected.Token(Token = "0x400029B")]
		PurchaseClothingItem = 39,
		[Cpp2IlInjected.Token(Token = "0x400029C")]
		PurchaseNonClothingItem = 40,
		[Cpp2IlInjected.Token(Token = "0x400029D")]
		TookPhotoWithPlayers = 41,
		[Cpp2IlInjected.Token(Token = "0x400029E")]
		ChangeOutfitInDorm = 42,
		[Cpp2IlInjected.Token(Token = "0x400029F")]
		VisitRooms = 43,
		[Cpp2IlInjected.Token(Token = "0x40002A0")]
		VisitRoomWith20Players = 44,
		[Cpp2IlInjected.Token(Token = "0x40002A1")]
		RoomieCatch = 45,
		[Cpp2IlInjected.Token(Token = "0x40002A2")]
		HighFivePlayer = 46,
		[Cpp2IlInjected.Token(Token = "0x40002A3")]
		CharadesGames = 100,
		[Cpp2IlInjected.Token(Token = "0x40002A4")]
		CharadesWinsPerformer = 101,
		[Cpp2IlInjected.Token(Token = "0x40002A5")]
		CharadesWinsGuesser = 102,
		[Cpp2IlInjected.Token(Token = "0x40002A6")]
		CharadesGameWithFriends = 103,
		[Cpp2IlInjected.Token(Token = "0x40002A7")]
		DiscGolfWins = 200,
		[Cpp2IlInjected.Token(Token = "0x40002A8")]
		DiscGolfGames = 201,
		[Cpp2IlInjected.Token(Token = "0x40002A9")]
		DiscGolfHolesUnderPar = 202,
		[Cpp2IlInjected.Token(Token = "0x40002AA")]
		DiscGolfGameWithFriends = 203,
		[Cpp2IlInjected.Token(Token = "0x40002AB")]
		DodgeballWins = 300,
		[Cpp2IlInjected.Token(Token = "0x40002AC")]
		DodgeballGames = 301,
		[Cpp2IlInjected.Token(Token = "0x40002AD")]
		DodgeballHits = 302,
		[Cpp2IlInjected.Token(Token = "0x40002AE")]
		DodgeballGameWithFriends = 303,
		[Cpp2IlInjected.Token(Token = "0x40002AF")]
		PaddleballGames = 400,
		[Cpp2IlInjected.Token(Token = "0x40002B0")]
		PaddleballWins = 401,
		[Cpp2IlInjected.Token(Token = "0x40002B1")]
		PaddleballScores = 402,
		[Cpp2IlInjected.Token(Token = "0x40002B2")]
		PaddleballGameWithFriends = 403,
		[Cpp2IlInjected.Token(Token = "0x40002B3")]
		PaintballAnyModeGames = 500,
		[Cpp2IlInjected.Token(Token = "0x40002B4")]
		PaintballAnyModeWins = 501,
		[Cpp2IlInjected.Token(Token = "0x40002B5")]
		PaintballAnyModeHits = 502,
		[Cpp2IlInjected.Token(Token = "0x40002B6")]
		PaintballGameWithMods = 503,
		[Cpp2IlInjected.Token(Token = "0x40002B7")]
		PaintballAnyModeGameWithFriends = 504,
		[Cpp2IlInjected.Token(Token = "0x40002B8")]
		PaintballCTFWins = 600,
		[Cpp2IlInjected.Token(Token = "0x40002B9")]
		PaintballCTFGames = 601,
		[Cpp2IlInjected.Token(Token = "0x40002BA")]
		PaintballCTFHits = 602,
		[Cpp2IlInjected.Token(Token = "0x40002BB")]
		PaintballFlagCaptures = 603,
		[Cpp2IlInjected.Token(Token = "0x40002BC")]
		PaintballTeamBattleWins = 700,
		[Cpp2IlInjected.Token(Token = "0x40002BD")]
		PaintballTeamBattleGames = 701,
		[Cpp2IlInjected.Token(Token = "0x40002BE")]
		PaintballTeamBattleHits = 702,
		[Cpp2IlInjected.Token(Token = "0x40002BF")]
		PaintballFreeForAllWins = 710,
		[Cpp2IlInjected.Token(Token = "0x40002C0")]
		PaintballFreeForAllGames = 711,
		[Cpp2IlInjected.Token(Token = "0x40002C1")]
		PaintballFreeForAllHits = 712,
		[Cpp2IlInjected.Token(Token = "0x40002C2")]
		SoccerWins = 800,
		[Cpp2IlInjected.Token(Token = "0x40002C3")]
		SoccerGames = 801,
		[Cpp2IlInjected.Token(Token = "0x40002C4")]
		SoccerGoals = 802,
		[Cpp2IlInjected.Token(Token = "0x40002C5")]
		SoccerGameWithFriends = 803,
		[Cpp2IlInjected.Token(Token = "0x40002C6")]
		BowlingGames = 900,
		[Cpp2IlInjected.Token(Token = "0x40002C7")]
		BowlingWins = 901,
		[Cpp2IlInjected.Token(Token = "0x40002C8")]
		BowlingStrike = 902,
		[Cpp2IlInjected.Token(Token = "0x40002C9")]
		BowlingGameWithFriends = 903,
		[Cpp2IlInjected.Token(Token = "0x40002CA")]
		QuestGames = 1000,
		[Cpp2IlInjected.Token(Token = "0x40002CB")]
		QuestWins = 1001,
		[Cpp2IlInjected.Token(Token = "0x40002CC")]
		QuestPlayerRevives = 1002,
		[Cpp2IlInjected.Token(Token = "0x40002CD")]
		QuestEnemyKills = 1003,
		[Cpp2IlInjected.Token(Token = "0x40002CE")]
		QuestGames_Goblin1 = 1010,
		[Cpp2IlInjected.Token(Token = "0x40002CF")]
		QuestWins_Goblin1 = 1011,
		[Cpp2IlInjected.Token(Token = "0x40002D0")]
		QuestPlayerRevives_Goblin1 = 1012,
		[Cpp2IlInjected.Token(Token = "0x40002D1")]
		QuestEnemyKills_Goblin1 = 1013,
		[Cpp2IlInjected.Token(Token = "0x40002D2")]
		QuestGameWithFriends_Goblin1 = 1014,
		[Cpp2IlInjected.Token(Token = "0x40002D3")]
		QuestGames_Goblin2 = 1020,
		[Cpp2IlInjected.Token(Token = "0x40002D4")]
		QuestWins_Goblin2 = 1021,
		[Cpp2IlInjected.Token(Token = "0x40002D5")]
		QuestPlayerRevives_Goblin2 = 1022,
		[Cpp2IlInjected.Token(Token = "0x40002D6")]
		QuestEnemyKills_Goblin2 = 1023,
		[Cpp2IlInjected.Token(Token = "0x40002D7")]
		QuestGameWithFriends_Goblin2 = 1024,
		[Cpp2IlInjected.Token(Token = "0x40002D8")]
		QuestGames_Scifi1 = 1030,
		[Cpp2IlInjected.Token(Token = "0x40002D9")]
		QuestWins_Scifi1 = 1031,
		[Cpp2IlInjected.Token(Token = "0x40002DA")]
		QuestPlayerRevives_Scifi1 = 1032,
		[Cpp2IlInjected.Token(Token = "0x40002DB")]
		QuestEnemyKills_Scifi1 = 1033,
		[Cpp2IlInjected.Token(Token = "0x40002DC")]
		QuestGameWithFriends_Scifi1 = 1034,
		[Cpp2IlInjected.Token(Token = "0x40002DD")]
		QuestGames_Pirate1 = 1040,
		[Cpp2IlInjected.Token(Token = "0x40002DE")]
		QuestWins_Pirate1 = 1041,
		[Cpp2IlInjected.Token(Token = "0x40002DF")]
		QuestPlayerRevives_Pirate1 = 1042,
		[Cpp2IlInjected.Token(Token = "0x40002E0")]
		QuestEnemyKills_Pirate1 = 1043,
		[Cpp2IlInjected.Token(Token = "0x40002E1")]
		QuestGameWithFriends_Pirate1 = 1044,
		[Cpp2IlInjected.Token(Token = "0x40002E2")]
		QuestGames_Dracula1 = 1050,
		[Cpp2IlInjected.Token(Token = "0x40002E3")]
		QuestWins_Dracula1 = 1051,
		[Cpp2IlInjected.Token(Token = "0x40002E4")]
		QuestPlayerRevives_Dracula1 = 1052,
		[Cpp2IlInjected.Token(Token = "0x40002E5")]
		QuestEnemyKills_Dracula1 = 1053,
		[Cpp2IlInjected.Token(Token = "0x40002E6")]
		QuestGameWithFriends_Dracula1 = 1054,
		[Cpp2IlInjected.Token(Token = "0x40002E7")]
		ArenaGames = 2000,
		[Cpp2IlInjected.Token(Token = "0x40002E8")]
		ArenaWins = 2001,
		[Cpp2IlInjected.Token(Token = "0x40002E9")]
		ArenaPlayerRevives = 2002,
		[Cpp2IlInjected.Token(Token = "0x40002EA")]
		ArenaHeroTags = 2003,
		[Cpp2IlInjected.Token(Token = "0x40002EB")]
		ArenaBotTags = 2004,
		[Cpp2IlInjected.Token(Token = "0x40002EC")]
		RecRoyaleGames = 3000,
		[Cpp2IlInjected.Token(Token = "0x40002ED")]
		RecRoyaleWins = 3001,
		[Cpp2IlInjected.Token(Token = "0x40002EE")]
		RecRoyaleTags = 3002,
		[Cpp2IlInjected.Token(Token = "0x40002EF")]
		RecRoyaleGameWithFriends = 3003,
		[Cpp2IlInjected.Token(Token = "0x40002F0")]
		StuntRunnerGames = 4000,
		[Cpp2IlInjected.Token(Token = "0x40002F1")]
		StuntRunnerWins = 4001,
		[Cpp2IlInjected.Token(Token = "0x40002F2")]
		StuntRunnerGameWithFriends = 4002,
		[Cpp2IlInjected.Token(Token = "0x40002F3")]
		RecRallyGames = 5000,
		[Cpp2IlInjected.Token(Token = "0x40002F4")]
		RecRallyWins = 5001,
		[Cpp2IlInjected.Token(Token = "0x40002F5")]
		RecRallyGameWithFriends = 5002,
		[Cpp2IlInjected.Token(Token = "0x40002F6")]
		BackpackGames = 6000,
		[Cpp2IlInjected.Token(Token = "0x40002F7")]
		BackpackGameWins = 6001,
		[Cpp2IlInjected.Token(Token = "0x40002F8")]
		PlayMinutesInHorror = 10000,
		[Cpp2IlInjected.Token(Token = "0x40002F9")]
		PlayMinutesInObby = 10001,
		[Cpp2IlInjected.Token(Token = "0x40002FA")]
		PlayMinutesInPVP = 10002,
		[Cpp2IlInjected.Token(Token = "0x40002FB")]
		PlayMinutesInGame = 10003,
		[Cpp2IlInjected.Token(Token = "0x40002FC")]
		LocomoteMetersInHorror = 10004,
		[Cpp2IlInjected.Token(Token = "0x40002FD")]
		LocomoteMetersInObby = 10005,
		[Cpp2IlInjected.Token(Token = "0x40002FE")]
		LocomoteMetersInPVP = 10006,
		[Cpp2IlInjected.Token(Token = "0x40002FF")]
		LocomoteMetersInGame = 10007
	}
	[Cpp2IlInjected.Token(Token = "0x20000AA")]
	[Utf8JsonSerializable]
	public class Objective
	{
		[Cpp2IlInjected.Token(Token = "0x1700021C")]
		[DataMember(Name = "Type")]
		public ObjectiveType ObjectiveType
		{
			[Cpp2IlInjected.Token(Token = "0x600048E")]
			[Cpp2IlInjected.Address(RVA = "0xD0F110", Offset = "0xD0DB10", VA = "0x180D0F110")]
			[CompilerGenerated]
			get
			{
				return default(ObjectiveType);
			}
			[Cpp2IlInjected.Token(Token = "0x600048F")]
			[Cpp2IlInjected.Address(RVA = "0xD12F30", Offset = "0xD11930", VA = "0x180D12F30")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700021D")]
		[DataMember(Name = "Score")]
		public int RequiredScore
		{
			[Cpp2IlInjected.Token(Token = "0x6000490")]
			[Cpp2IlInjected.Address(RVA = "0xE073A0", Offset = "0xE05DA0", VA = "0x180E073A0")]
			[CompilerGenerated]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x6000491")]
			[Cpp2IlInjected.Address(RVA = "0xE073B0", Offset = "0xE05DB0", VA = "0x180E073B0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700021E")]
		[DataMember(Name = "DescriptionOverride")]
		public string DescriptionOverride
		{
			[Cpp2IlInjected.Token(Token = "0x6000492")]
			[Cpp2IlInjected.Address(RVA = "0xD11B30", Offset = "0xD10530", VA = "0x180D11B30")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000493")]
			[Cpp2IlInjected.Address(RVA = "0xD12270", Offset = "0xD10C70", VA = "0x180D12270")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700021F")]
		[DataMember(Name = "TooltipOverride")]
		public string TooltipOverride
		{
			[Cpp2IlInjected.Token(Token = "0x6000494")]
			[Cpp2IlInjected.Address(RVA = "0xD12BC0", Offset = "0xD115C0", VA = "0x180D12BC0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000495")]
			[Cpp2IlInjected.Address(RVA = "0xD11520", Offset = "0xD0FF20", VA = "0x180D11520")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000496")]
		[Cpp2IlInjected.Address(RVA = "0x16A61D0", Offset = "0x16A4BD0", VA = "0x1816A61D0")]
		public Objective()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000AB")]
	[Utf8JsonSerializable]
	public class ProgressionEventRecordDTO
	{
		[Cpp2IlInjected.Token(Token = "0x17000220")]
		public int AccountId
		{
			[Cpp2IlInjected.Token(Token = "0x6000499")]
			[Cpp2IlInjected.Address(RVA = "0xD0F110", Offset = "0xD0DB10", VA = "0x180D0F110")]
			[CompilerGenerated]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x600049A")]
			[Cpp2IlInjected.Address(RVA = "0xD12F30", Offset = "0xD11930", VA = "0x180D12F30")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000221")]
		public long ProgressionEventId
		{
			[Cpp2IlInjected.Token(Token = "0x600049B")]
			[Cpp2IlInjected.Address(RVA = "0xD11B30", Offset = "0xD10530", VA = "0x180D11B30")]
			[CompilerGenerated]
			get
			{
				return default(long);
			}
			[Cpp2IlInjected.Token(Token = "0x600049C")]
			[Cpp2IlInjected.Address(RVA = "0xE07390", Offset = "0xE05D90", VA = "0x180E07390")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000222")]
		public int Xp
		{
			[Cpp2IlInjected.Token(Token = "0x600049D")]
			[Cpp2IlInjected.Address(RVA = "0xD215F0", Offset = "0xD1FFF0", VA = "0x180D215F0")]
			[CompilerGenerated]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x600049E")]
			[Cpp2IlInjected.Address(RVA = "0xD682F0", Offset = "0xD66CF0", VA = "0x180D682F0")]
			[CompilerGenerated]
			internal set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000223")]
		public int GameMinutesToday
		{
			[Cpp2IlInjected.Token(Token = "0x600049F")]
			[Cpp2IlInjected.Address(RVA = "0xD38090", Offset = "0xD36A90", VA = "0x180D38090")]
			[CompilerGenerated]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x60004A0")]
			[Cpp2IlInjected.Address(RVA = "0xF21A50", Offset = "0xF20450", VA = "0x180F21A50")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000224")]
		public int RewardsCollected
		{
			[Cpp2IlInjected.Token(Token = "0x60004A1")]
			[Cpp2IlInjected.Address(RVA = "0xD12BE0", Offset = "0xD115E0", VA = "0x180D12BE0")]
			[CompilerGenerated]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x60004A2")]
			[Cpp2IlInjected.Address(RVA = "0xD12C40", Offset = "0xD11640", VA = "0x180D12C40")]
			[CompilerGenerated]
			internal set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000225")]
		public int BonusRewardsCollected
		{
			[Cpp2IlInjected.Token(Token = "0x60004A3")]
			[Cpp2IlInjected.Address(RVA = "0xE24360", Offset = "0xE22D60", VA = "0x180E24360")]
			[CompilerGenerated]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x60004A4")]
			[Cpp2IlInjected.Address(RVA = "0x1E2BFE0", Offset = "0x1E2A9E0", VA = "0x181E2BFE0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000226")]
		public DateTime? XpBoostLastPurchasedAt
		{
			[Cpp2IlInjected.Token(Token = "0x60004A5")]
			[Cpp2IlInjected.Address(RVA = "0xF92C90", Offset = "0xF91690", VA = "0x180F92C90")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60004A6")]
			[Cpp2IlInjected.Address(RVA = "0xF931D0", Offset = "0xF91BD0", VA = "0x180F931D0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000227")]
		public int PremiumRewardsCollected
		{
			[Cpp2IlInjected.Token(Token = "0x60004A7")]
			[Cpp2IlInjected.Address(RVA = "0xD2DD40", Offset = "0xD2C740", VA = "0x180D2DD40")]
			[CompilerGenerated]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x60004A8")]
			[Cpp2IlInjected.Address(RVA = "0xD89720", Offset = "0xD88120", VA = "0x180D89720")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000228")]
		public ProgressionEventLimitedRewardCollectionState LimitedRewardCollectionState
		{
			[Cpp2IlInjected.Token(Token = "0x60004A9")]
			[Cpp2IlInjected.Address(RVA = "0xD2DD50", Offset = "0xD2C750", VA = "0x180D2DD50")]
			[CompilerGenerated]
			get
			{
				return default(ProgressionEventLimitedRewardCollectionState);
			}
			[Cpp2IlInjected.Token(Token = "0x60004AA")]
			[Cpp2IlInjected.Address(RVA = "0xD89730", Offset = "0xD88130", VA = "0x180D89730")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000497")]
		[Cpp2IlInjected.Address(RVA = "0xD16C40", Offset = "0xD15640", VA = "0x180D16C40")]
		public ProgressionEventRecordDTO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000498")]
		[Cpp2IlInjected.Address(RVA = "0x8DC3EA0", Offset = "0x8DC28A0", VA = "0x188DC3EA0")]
		public ProgressionEventRecordDTO(int accountId = 0, long progressionEventId = 0L, int xp = 0, int gameMinutesToday = 0, int rewardsCollected = 0)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000AC")]
	[Utf8JsonSerializable]
	public class ProgressionEventDTO
	{
		[Cpp2IlInjected.Token(Token = "0x17000229")]
		public long ProgressionEventId
		{
			[Cpp2IlInjected.Token(Token = "0x60004AD")]
			[Cpp2IlInjected.Address(RVA = "0xD117B0", Offset = "0xD101B0", VA = "0x180D117B0")]
			[CompilerGenerated]
			get
			{
				return default(long);
			}
			[Cpp2IlInjected.Token(Token = "0x60004AE")]
			[Cpp2IlInjected.Address(RVA = "0xED90B0", Offset = "0xED7AB0", VA = "0x180ED90B0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700022A")]
		public string Name
		{
			[Cpp2IlInjected.Token(Token = "0x60004AF")]
			[Cpp2IlInjected.Address(RVA = "0xD11B30", Offset = "0xD10530", VA = "0x180D11B30")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60004B0")]
			[Cpp2IlInjected.Address(RVA = "0xD12270", Offset = "0xD10C70", VA = "0x180D12270")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700022B")]
		public List<ProgressionEventRewardDTO> Rewards
		{
			[Cpp2IlInjected.Token(Token = "0x60004B1")]
			[Cpp2IlInjected.Address(RVA = "0xD12BC0", Offset = "0xD115C0", VA = "0x180D12BC0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60004B2")]
			[Cpp2IlInjected.Address(RVA = "0xD11520", Offset = "0xD0FF20", VA = "0x180D11520")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700022C")]
		public List<KeepsakeRoomListDTO> KeepsakeRoomLists
		{
			[Cpp2IlInjected.Token(Token = "0x60004B3")]
			[Cpp2IlInjected.Address(RVA = "0xD11B00", Offset = "0xD10500", VA = "0x180D11B00")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60004B4")]
			[Cpp2IlInjected.Address(RVA = "0xD11530", Offset = "0xD0FF30", VA = "0x180D11530")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700022D")]
		public DateTime StartTime
		{
			[Cpp2IlInjected.Token(Token = "0x60004B5")]
			[Cpp2IlInjected.Address(RVA = "0xD11A20", Offset = "0xD10420", VA = "0x180D11A20")]
			[CompilerGenerated]
			get
			{
				return default(DateTime);
			}
			[Cpp2IlInjected.Token(Token = "0x60004B6")]
			[Cpp2IlInjected.Address(RVA = "0xD118E0", Offset = "0xD102E0", VA = "0x180D118E0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700022E")]
		public DateTime EndTime
		{
			[Cpp2IlInjected.Token(Token = "0x60004B7")]
			[Cpp2IlInjected.Address(RVA = "0xD12280", Offset = "0xD10C80", VA = "0x180D12280")]
			[CompilerGenerated]
			get
			{
				return default(DateTime);
			}
			[Cpp2IlInjected.Token(Token = "0x60004B8")]
			[Cpp2IlInjected.Address(RVA = "0xD1B6D0", Offset = "0xD1A0D0", VA = "0x180D1B6D0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700022F")]
		public DateTime CollectionEndTime
		{
			[Cpp2IlInjected.Token(Token = "0x60004B9")]
			[Cpp2IlInjected.Address(RVA = "0xD11A30", Offset = "0xD10430", VA = "0x180D11A30")]
			[CompilerGenerated]
			get
			{
				return default(DateTime);
			}
			[Cpp2IlInjected.Token(Token = "0x60004BA")]
			[Cpp2IlInjected.Address(RVA = "0xFFBC20", Offset = "0xFFA620", VA = "0x180FFBC20")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000230")]
		public bool UsesBoost
		{
			[Cpp2IlInjected.Token(Token = "0x60004BB")]
			[Cpp2IlInjected.Address(RVA = "0xDB1A50", Offset = "0xDB0450", VA = "0x180DB1A50")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x60004BC")]
			[Cpp2IlInjected.Address(RVA = "0xEAA1E0", Offset = "0xEA8BE0", VA = "0x180EAA1E0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000231")]
		public int BoostDailyGameplayMinutesLimit
		{
			[Cpp2IlInjected.Token(Token = "0x60004BD")]
			[Cpp2IlInjected.Address(RVA = "0x16A6F60", Offset = "0x16A5960", VA = "0x1816A6F60")]
			[CompilerGenerated]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x60004BE")]
			[Cpp2IlInjected.Address(RVA = "0x1CA3C80", Offset = "0x1CA2680", VA = "0x181CA3C80")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000232")]
		public float BoostXpMultiplier
		{
			[Cpp2IlInjected.Token(Token = "0x60004BF")]
			[Cpp2IlInjected.Address(RVA = "0xD60FC0", Offset = "0xD5F9C0", VA = "0x180D60FC0")]
			[CompilerGenerated]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x60004C0")]
			[Cpp2IlInjected.Address(RVA = "0x10A9B50", Offset = "0x10A8550", VA = "0x1810A9B50")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000233")]
		public Guid? PurchasableXpBoostId
		{
			[Cpp2IlInjected.Token(Token = "0x60004C1")]
			[Cpp2IlInjected.Address(RVA = "0x8DC3E60", Offset = "0x8DC2860", VA = "0x188DC3E60")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60004C2")]
			[Cpp2IlInjected.Address(RVA = "0x8DC3E80", Offset = "0x8DC2880", VA = "0x188DC3E80")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000234")]
		public string ActiveExperiment
		{
			[Cpp2IlInjected.Token(Token = "0x60004C3")]
			[Cpp2IlInjected.Address(RVA = "0xD11B40", Offset = "0xD10540", VA = "0x180D11B40")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60004C4")]
			[Cpp2IlInjected.Address(RVA = "0xD11910", Offset = "0xD10310", VA = "0x180D11910")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000235")]
		public string ChallengesIconImageName
		{
			[Cpp2IlInjected.Token(Token = "0x60004C5")]
			[Cpp2IlInjected.Address(RVA = "0xD11B60", Offset = "0xD10560", VA = "0x180D11B60")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60004C6")]
			[Cpp2IlInjected.Address(RVA = "0xD11AE0", Offset = "0xD104E0", VA = "0x180D11AE0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000236")]
		public string RewardsPipImageName
		{
			[Cpp2IlInjected.Token(Token = "0x60004C7")]
			[Cpp2IlInjected.Address(RVA = "0xD1E8A0", Offset = "0xD1D2A0", VA = "0x180D1E8A0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60004C8")]
			[Cpp2IlInjected.Address(RVA = "0xD1E820", Offset = "0xD1D220", VA = "0x180D1E820")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000237")]
		public string EventInfoImageName
		{
			[Cpp2IlInjected.Token(Token = "0x60004C9")]
			[Cpp2IlInjected.Address(RVA = "0xD1E850", Offset = "0xD1D250", VA = "0x180D1E850")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60004CA")]
			[Cpp2IlInjected.Address(RVA = "0xD1E840", Offset = "0xD1D240", VA = "0x180D1E840")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000238")]
		public long? EventLeaderboardId
		{
			[Cpp2IlInjected.Token(Token = "0x60004CB")]
			[Cpp2IlInjected.Address(RVA = "0x21EC400", Offset = "0x21EAE00", VA = "0x1821EC400")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60004CC")]
			[Cpp2IlInjected.Address(RVA = "0x651E2E0", Offset = "0x651CCE0", VA = "0x18651E2E0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60004AB")]
		[Cpp2IlInjected.Address(RVA = "0xD16C40", Offset = "0xD15640", VA = "0x180D16C40")]
		public ProgressionEventDTO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004AC")]
		[Cpp2IlInjected.Address(RVA = "0x8DC3DA0", Offset = "0x8DC27A0", VA = "0x188DC3DA0")]
		public ProgressionEventDTO(long progressionEventId = 0L, [Optional] string name, [Optional] List<ProgressionEventRewardDTO> rewards, [Optional] List<KeepsakeRoomListDTO> keepsakeRoomLists, [Optional] DateTime startTime, [Optional] DateTime endTime, [Optional] DateTime collectionEndTime, bool usesBoost = false, int boostDailyGameplayMinutesLimit = 0, float boostXpMultiplier = 0f, [Optional] long? eventLeaderboardId)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000AD")]
	[Utf8JsonSerializable]
	public class KeepsakeRoomListDTO
	{
		[Cpp2IlInjected.Token(Token = "0x17000239")]
		public long KeepsakeRoomListId
		{
			[Cpp2IlInjected.Token(Token = "0x60004CF")]
			[Cpp2IlInjected.Address(RVA = "0xD117B0", Offset = "0xD101B0", VA = "0x180D117B0")]
			[CompilerGenerated]
			get
			{
				return default(long);
			}
			[Cpp2IlInjected.Token(Token = "0x60004D0")]
			[Cpp2IlInjected.Address(RVA = "0xED90B0", Offset = "0xED7AB0", VA = "0x180ED90B0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700023A")]
		public long ProgressionEventId
		{
			[Cpp2IlInjected.Token(Token = "0x60004D1")]
			[Cpp2IlInjected.Address(RVA = "0xD11B30", Offset = "0xD10530", VA = "0x180D11B30")]
			[CompilerGenerated]
			get
			{
				return default(long);
			}
			[Cpp2IlInjected.Token(Token = "0x60004D2")]
			[Cpp2IlInjected.Address(RVA = "0xE07390", Offset = "0xE05D90", VA = "0x180E07390")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700023B")]
		public int? UnlockItemAvatarItemId
		{
			[Cpp2IlInjected.Token(Token = "0x60004D3")]
			[Cpp2IlInjected.Address(RVA = "0xD12BC0", Offset = "0xD115C0", VA = "0x180D12BC0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60004D4")]
			[Cpp2IlInjected.Address(RVA = "0xE3F130", Offset = "0xE3DB30", VA = "0x180E3F130")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700023C")]
		public int? UnlockItemGiftDropId
		{
			[Cpp2IlInjected.Token(Token = "0x60004D5")]
			[Cpp2IlInjected.Address(RVA = "0xD11B00", Offset = "0xD10500", VA = "0x180D11B00")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60004D6")]
			[Cpp2IlInjected.Address(RVA = "0xD11960", Offset = "0xD10360", VA = "0x180D11960")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700023D")]
		public long? UnlockItemLockDurationTicks
		{
			[Cpp2IlInjected.Token(Token = "0x60004D7")]
			[Cpp2IlInjected.Address(RVA = "0xF92C90", Offset = "0xF91690", VA = "0x180F92C90")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60004D8")]
			[Cpp2IlInjected.Address(RVA = "0xF931D0", Offset = "0xF91BD0", VA = "0x180F931D0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700023E")]
		public long RoomUnlockStartOffsetTicks
		{
			[Cpp2IlInjected.Token(Token = "0x60004D9")]
			[Cpp2IlInjected.Address(RVA = "0xD11A30", Offset = "0xD10430", VA = "0x180D11A30")]
			[CompilerGenerated]
			get
			{
				return default(long);
			}
			[Cpp2IlInjected.Token(Token = "0x60004DA")]
			[Cpp2IlInjected.Address(RVA = "0xFFBC20", Offset = "0xFFA620", VA = "0x180FFBC20")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700023F")]
		public TimeSpan RoomUnlockStartOffset
		{
			[Cpp2IlInjected.Token(Token = "0x60004DB")]
			[Cpp2IlInjected.Address(RVA = "0x8DC2890", Offset = "0x8DC1290", VA = "0x188DC2890")]
			get
			{
				return default(TimeSpan);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000240")]
		public long RoomUnlockIntervalTicks
		{
			[Cpp2IlInjected.Token(Token = "0x60004DC")]
			[Cpp2IlInjected.Address(RVA = "0xD122E0", Offset = "0xD10CE0", VA = "0x180D122E0")]
			[CompilerGenerated]
			get
			{
				return default(long);
			}
			[Cpp2IlInjected.Token(Token = "0x60004DD")]
			[Cpp2IlInjected.Address(RVA = "0x1440140", Offset = "0x143EB40", VA = "0x181440140")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000241")]
		public TimeSpan RoomUnlockInterval
		{
			[Cpp2IlInjected.Token(Token = "0x60004DE")]
			[Cpp2IlInjected.Address(RVA = "0x8DC2840", Offset = "0x8DC1240", VA = "0x188DC2840")]
			get
			{
				return default(TimeSpan);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000242")]
		public int RoomUnlockBatchSize
		{
			[Cpp2IlInjected.Token(Token = "0x60004DF")]
			[Cpp2IlInjected.Address(RVA = "0xF01E60", Offset = "0xF00860", VA = "0x180F01E60")]
			[CompilerGenerated]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x60004E0")]
			[Cpp2IlInjected.Address(RVA = "0x1ADB800", Offset = "0x1ADA200", VA = "0x181ADB800")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000243")]
		public KeepsakeRoomType RoomType
		{
			[Cpp2IlInjected.Token(Token = "0x60004E1")]
			[Cpp2IlInjected.Address(RVA = "0x137DA00", Offset = "0x137C400", VA = "0x18137DA00")]
			[CompilerGenerated]
			get
			{
				return default(KeepsakeRoomType);
			}
			[Cpp2IlInjected.Token(Token = "0x60004E2")]
			[Cpp2IlInjected.Address(RVA = "0x21D5B90", Offset = "0x21D4590", VA = "0x1821D5B90")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000244")]
		public List<KeepsakeRoomDTO> KeepsakeRooms
		{
			[Cpp2IlInjected.Token(Token = "0x60004E3")]
			[Cpp2IlInjected.Address(RVA = "0xD11940", Offset = "0xD10340", VA = "0x180D11940")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60004E4")]
			[Cpp2IlInjected.Address(RVA = "0xD122A0", Offset = "0xD10CA0", VA = "0x180D122A0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60004CD")]
		[Cpp2IlInjected.Address(RVA = "0xD16C40", Offset = "0xD15640", VA = "0x180D16C40")]
		public KeepsakeRoomListDTO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004CE")]
		[Cpp2IlInjected.Address(RVA = "0x8DC2750", Offset = "0x8DC1150", VA = "0x188DC2750")]
		public KeepsakeRoomListDTO(long keepsakeRoomListId = 0L, long progressionEventId = 0L, [Optional] int? unlockItemAvatarItemId, [Optional] int? unlockItemGiftDropId, [Optional] long? unlockItemLockDurationTicks, long roomUnlockStartOffsetTicks = 0L, long roomUnlockIntervalTicks = 0L, int roomUnlockBatchSize = 0, KeepsakeRoomType roomType = KeepsakeRoomType.Standard, [Optional] List<KeepsakeRoomDTO> keepsakeRooms)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000AE")]
	[Utf8JsonSerializable]
	public class KeepsakeRoomDTO
	{
		[Cpp2IlInjected.Token(Token = "0x17000245")]
		public long KeepsakeRoomId
		{
			[Cpp2IlInjected.Token(Token = "0x60004E7")]
			[Cpp2IlInjected.Address(RVA = "0xD117B0", Offset = "0xD101B0", VA = "0x180D117B0")]
			[CompilerGenerated]
			get
			{
				return default(long);
			}
			[Cpp2IlInjected.Token(Token = "0x60004E8")]
			[Cpp2IlInjected.Address(RVA = "0xED90B0", Offset = "0xED7AB0", VA = "0x180ED90B0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000246")]
		public long RoomId
		{
			[Cpp2IlInjected.Token(Token = "0x60004E9")]
			[Cpp2IlInjected.Address(RVA = "0xD11B30", Offset = "0xD10530", VA = "0x180D11B30")]
			[CompilerGenerated]
			get
			{
				return default(long);
			}
			[Cpp2IlInjected.Token(Token = "0x60004EA")]
			[Cpp2IlInjected.Address(RVA = "0xE07390", Offset = "0xE05D90", VA = "0x180E07390")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000247")]
		public long KeepsakeRoomListId
		{
			[Cpp2IlInjected.Token(Token = "0x60004EB")]
			[Cpp2IlInjected.Address(RVA = "0xD12BC0", Offset = "0xD115C0", VA = "0x180D12BC0")]
			[CompilerGenerated]
			get
			{
				return default(long);
			}
			[Cpp2IlInjected.Token(Token = "0x60004EC")]
			[Cpp2IlInjected.Address(RVA = "0xE3F130", Offset = "0xE3DB30", VA = "0x180E3F130")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000248")]
		public KeepsakeRoomType Type
		{
			[Cpp2IlInjected.Token(Token = "0x60004ED")]
			[Cpp2IlInjected.Address(RVA = "0xD12BE0", Offset = "0xD115E0", VA = "0x180D12BE0")]
			[CompilerGenerated]
			get
			{
				return default(KeepsakeRoomType);
			}
			[Cpp2IlInjected.Token(Token = "0x60004EE")]
			[Cpp2IlInjected.Address(RVA = "0xD12C40", Offset = "0xD11640", VA = "0x180D12C40")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000249")]
		public int Order
		{
			[Cpp2IlInjected.Token(Token = "0x60004EF")]
			[Cpp2IlInjected.Address(RVA = "0xE24360", Offset = "0xE22D60", VA = "0x180E24360")]
			[CompilerGenerated]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x60004F0")]
			[Cpp2IlInjected.Address(RVA = "0x1E2BFE0", Offset = "0x1E2A9E0", VA = "0x181E2BFE0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60004E5")]
		[Cpp2IlInjected.Address(RVA = "0xD16C40", Offset = "0xD15640", VA = "0x180D16C40")]
		public KeepsakeRoomDTO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004E6")]
		[Cpp2IlInjected.Address(RVA = "0x8DC26F0", Offset = "0x8DC10F0", VA = "0x188DC26F0")]
		public KeepsakeRoomDTO(long keepsakeRoomId = 0L, long roomId = 0L, long keepsakeRoomListId = 0L, KeepsakeRoomType type = KeepsakeRoomType.Standard, int order = 0)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000AF")]
	[Utf8JsonSerializable]
	public class ProgressionEventRewardDTO
	{
		[Cpp2IlInjected.Token(Token = "0x1700024A")]
		public long ProgressionEventRewardId
		{
			[Cpp2IlInjected.Token(Token = "0x60004F1")]
			[Cpp2IlInjected.Address(RVA = "0xD117B0", Offset = "0xD101B0", VA = "0x180D117B0")]
			[CompilerGenerated]
			get
			{
				return default(long);
			}
			[Cpp2IlInjected.Token(Token = "0x60004F2")]
			[Cpp2IlInjected.Address(RVA = "0xED90B0", Offset = "0xED7AB0", VA = "0x180ED90B0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700024B")]
		public string ImageName
		{
			[Cpp2IlInjected.Token(Token = "0x60004F3")]
			[Cpp2IlInjected.Address(RVA = "0xD11B30", Offset = "0xD10530", VA = "0x180D11B30")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60004F4")]
			[Cpp2IlInjected.Address(RVA = "0xD12270", Offset = "0xD10C70", VA = "0x180D12270")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700024C")]
		public int Xp
		{
			[Cpp2IlInjected.Token(Token = "0x60004F5")]
			[Cpp2IlInjected.Address(RVA = "0xD215F0", Offset = "0xD1FFF0", VA = "0x180D215F0")]
			[CompilerGenerated]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x60004F6")]
			[Cpp2IlInjected.Address(RVA = "0xD682F0", Offset = "0xD66CF0", VA = "0x180D682F0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700024D")]
		public int RewardIndex
		{
			[Cpp2IlInjected.Token(Token = "0x60004F7")]
			[Cpp2IlInjected.Address(RVA = "0xD38090", Offset = "0xD36A90", VA = "0x180D38090")]
			[CompilerGenerated]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x60004F8")]
			[Cpp2IlInjected.Address(RVA = "0xF21A50", Offset = "0xF20450", VA = "0x180F21A50")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700024E")]
		public bool IsBonus
		{
			[Cpp2IlInjected.Token(Token = "0x60004F9")]
			[Cpp2IlInjected.Address(RVA = "0xDA36E0", Offset = "0xDA20E0", VA = "0x180DA36E0")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x60004FA")]
			[Cpp2IlInjected.Address(RVA = "0xDA36F0", Offset = "0xDA20F0", VA = "0x180DA36F0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700024F")]
		public bool IsRRPlusExclusive
		{
			[Cpp2IlInjected.Token(Token = "0x60004FB")]
			[Cpp2IlInjected.Address(RVA = "0xF82510", Offset = "0xF80F10", VA = "0x180F82510")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x60004FC")]
			[Cpp2IlInjected.Address(RVA = "0xF82520", Offset = "0xF80F20", VA = "0x180F82520")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000250")]
		public int? MaxGlobalCollections
		{
			[Cpp2IlInjected.Token(Token = "0x60004FD")]
			[Cpp2IlInjected.Address(RVA = "0x141BB40", Offset = "0x141A540", VA = "0x18141BB40")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60004FE")]
			[Cpp2IlInjected.Address(RVA = "0x141BB70", Offset = "0x141A570", VA = "0x18141BB70")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60004FF")]
		[Cpp2IlInjected.Address(RVA = "0xD16C40", Offset = "0xD15640", VA = "0x180D16C40")]
		public ProgressionEventRewardDTO()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000B0")]
	[Utf8JsonSerializable]
	public class ProgressionEventPurchasableXpBoostDTO
	{
		[Cpp2IlInjected.Token(Token = "0x17000251")]
		public Guid ProgressionEventPurchasableXpBoostId
		{
			[Cpp2IlInjected.Token(Token = "0x6000500")]
			[Cpp2IlInjected.Address(RVA = "0xF357F0", Offset = "0xF341F0", VA = "0x180F357F0")]
			[CompilerGenerated]
			get
			{
				return default(Guid);
			}
			[Cpp2IlInjected.Token(Token = "0x6000501")]
			[Cpp2IlInjected.Address(RVA = "0xF35810", Offset = "0xF34210", VA = "0x180F35810")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000252")]
		public int Cost
		{
			[Cpp2IlInjected.Token(Token = "0x6000502")]
			[Cpp2IlInjected.Address(RVA = "0xD215F0", Offset = "0xD1FFF0", VA = "0x180D215F0")]
			[CompilerGenerated]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x6000503")]
			[Cpp2IlInjected.Address(RVA = "0xD682F0", Offset = "0xD66CF0", VA = "0x180D682F0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000253")]
		public int XpMultiplier
		{
			[Cpp2IlInjected.Token(Token = "0x6000504")]
			[Cpp2IlInjected.Address(RVA = "0xD38090", Offset = "0xD36A90", VA = "0x180D38090")]
			[CompilerGenerated]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x6000505")]
			[Cpp2IlInjected.Address(RVA = "0xF21A50", Offset = "0xF20450", VA = "0x180F21A50")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000254")]
		public int XpCap
		{
			[Cpp2IlInjected.Token(Token = "0x6000506")]
			[Cpp2IlInjected.Address(RVA = "0xD12BE0", Offset = "0xD115E0", VA = "0x180D12BE0")]
			[CompilerGenerated]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x6000507")]
			[Cpp2IlInjected.Address(RVA = "0xD12C40", Offset = "0xD11640", VA = "0x180D12C40")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000255")]
		public long LookbackDurationTicks
		{
			[Cpp2IlInjected.Token(Token = "0x6000508")]
			[Cpp2IlInjected.Address(RVA = "0xD11A20", Offset = "0xD10420", VA = "0x180D11A20")]
			[CompilerGenerated]
			get
			{
				return default(long);
			}
			[Cpp2IlInjected.Token(Token = "0x6000509")]
			[Cpp2IlInjected.Address(RVA = "0xD118E0", Offset = "0xD102E0", VA = "0x180D118E0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000256")]
		public long CooldownDurationTicks
		{
			[Cpp2IlInjected.Token(Token = "0x600050A")]
			[Cpp2IlInjected.Address(RVA = "0xD12280", Offset = "0xD10C80", VA = "0x180D12280")]
			[CompilerGenerated]
			get
			{
				return default(long);
			}
			[Cpp2IlInjected.Token(Token = "0x600050B")]
			[Cpp2IlInjected.Address(RVA = "0xD1B6D0", Offset = "0xD1A0D0", VA = "0x180D1B6D0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000257")]
		public CurrencyType CurrencyType
		{
			[Cpp2IlInjected.Token(Token = "0x600050C")]
			[Cpp2IlInjected.Address(RVA = "0xD2DD40", Offset = "0xD2C740", VA = "0x180D2DD40")]
			[CompilerGenerated]
			get
			{
				return default(CurrencyType);
			}
			[Cpp2IlInjected.Token(Token = "0x600050D")]
			[Cpp2IlInjected.Address(RVA = "0xD89720", Offset = "0xD88120", VA = "0x180D89720")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600050E")]
		[Cpp2IlInjected.Address(RVA = "0x8DC3E90", Offset = "0x8DC2890", VA = "0x188DC3E90")]
		public ProgressionEventPurchasableXpBoostDTO()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000B1")]
	public enum KeepsakeRoomType
	{
		[Cpp2IlInjected.Token(Token = "0x400033B")]
		Standard,
		[Cpp2IlInjected.Token(Token = "0x400033C")]
		Premium
	}
	[Cpp2IlInjected.Token(Token = "0x20000B2")]
	public enum KeepsakeCategory
	{
		[Cpp2IlInjected.Token(Token = "0x400033E")]
		Explore = 0,
		[Cpp2IlInjected.Token(Token = "0x400033F")]
		GreenPowerCore = 1,
		[Cpp2IlInjected.Token(Token = "0x4000340")]
		Present = 2,
		[Cpp2IlInjected.Token(Token = "0x4000341")]
		PurplePowerCore = 3,
		[Cpp2IlInjected.Token(Token = "0x4000342")]
		UnnamedKeepsakeNumber1 = 4,
		[Cpp2IlInjected.Token(Token = "0x4000343")]
		UnnamedKeepsakeNumber2 = 5,
		[Cpp2IlInjected.Token(Token = "0x4000344")]
		UnnamedKeepsakeNumber3 = 6,
		[Cpp2IlInjected.Token(Token = "0x4000345")]
		UnnamedKeepsakeNumber4 = 7,
		[Cpp2IlInjected.Token(Token = "0x4000346")]
		UnnamedKeepsakeNumber5 = 8,
		[Cpp2IlInjected.Token(Token = "0x4000347")]
		_Test = 1000
	}
	[Cpp2IlInjected.Token(Token = "0x20000B3")]
	public enum ProgressionEventLimitedRewardCollectionState
	{
		[Cpp2IlInjected.Token(Token = "0x4000349")]
		NotEarned,
		[Cpp2IlInjected.Token(Token = "0x400034A")]
		Earned,
		[Cpp2IlInjected.Token(Token = "0x400034B")]
		Collected,
		[Cpp2IlInjected.Token(Token = "0x400034C")]
		CannotEarn
	}
	[Cpp2IlInjected.Token(Token = "0x20000B4")]
	[Utf8JsonSerializable]
	public class PurchasableXpBoostActivationDTO
	{
		[Cpp2IlInjected.Token(Token = "0x17000258")]
		public long PurchasableXpBoostLedgerEntryId
		{
			[Cpp2IlInjected.Token(Token = "0x600050F")]
			[Cpp2IlInjected.Address(RVA = "0xD117B0", Offset = "0xD101B0", VA = "0x180D117B0")]
			[CompilerGenerated]
			get
			{
				return default(long);
			}
			[Cpp2IlInjected.Token(Token = "0x6000510")]
			[Cpp2IlInjected.Address(RVA = "0xED90B0", Offset = "0xED7AB0", VA = "0x180ED90B0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000259")]
		public Guid PurchasableXpBoostId
		{
			[Cpp2IlInjected.Token(Token = "0x6000511")]
			[Cpp2IlInjected.Address(RVA = "0xDA5E80", Offset = "0xDA4880", VA = "0x180DA5E80")]
			[CompilerGenerated]
			get
			{
				return default(Guid);
			}
			[Cpp2IlInjected.Token(Token = "0x6000512")]
			[Cpp2IlInjected.Address(RVA = "0xF82330", Offset = "0xF80D30", VA = "0x180F82330")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700025A")]
		public float XpMultiplier
		{
			[Cpp2IlInjected.Token(Token = "0x6000513")]
			[Cpp2IlInjected.Address(RVA = "0x10DD6F0", Offset = "0x10DC0F0", VA = "0x1810DD6F0")]
			[CompilerGenerated]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x6000514")]
			[Cpp2IlInjected.Address(RVA = "0x1368DF0", Offset = "0x13677F0", VA = "0x181368DF0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700025B")]
		public DateTime StartTime
		{
			[Cpp2IlInjected.Token(Token = "0x6000515")]
			[Cpp2IlInjected.Address(RVA = "0xD11A20", Offset = "0xD10420", VA = "0x180D11A20")]
			[CompilerGenerated]
			get
			{
				return default(DateTime);
			}
			[Cpp2IlInjected.Token(Token = "0x6000516")]
			[Cpp2IlInjected.Address(RVA = "0xD118E0", Offset = "0xD102E0", VA = "0x180D118E0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700025C")]
		public DateTime EndTime
		{
			[Cpp2IlInjected.Token(Token = "0x6000517")]
			[Cpp2IlInjected.Address(RVA = "0xD12280", Offset = "0xD10C80", VA = "0x180D12280")]
			[CompilerGenerated]
			get
			{
				return default(DateTime);
			}
			[Cpp2IlInjected.Token(Token = "0x6000518")]
			[Cpp2IlInjected.Address(RVA = "0xD1B6D0", Offset = "0xD1A0D0", VA = "0x180D1B6D0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000519")]
		[Cpp2IlInjected.Address(RVA = "0xD16C40", Offset = "0xD15640", VA = "0x180D16C40")]
		public PurchasableXpBoostActivationDTO()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000B5")]
	[Utf8JsonSerializableGenericSpecialization]
	public class CPORYPZSJCN : VCCRUZAMKGW<PurchasableXpBoostActivationDTO>
	{
		[Cpp2IlInjected.Token(Token = "0x600051A")]
		[Cpp2IlInjected.Address(RVA = "0x8DBEA90", Offset = "0x8DBD490", VA = "0x188DBEA90")]
		public CPORYPZSJCN()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000B6")]
	[Utf8JsonSerializable]
	public class RefereeFileReferenceDTO
	{
		[Cpp2IlInjected.Token(Token = "0x1700025D")]
		public string Filename
		{
			[Cpp2IlInjected.Token(Token = "0x600051B")]
			[Cpp2IlInjected.Address(RVA = "0xD117B0", Offset = "0xD101B0", VA = "0x180D117B0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600051C")]
			[Cpp2IlInjected.Address(RVA = "0xD117C0", Offset = "0xD101C0", VA = "0x180D117C0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700025E")]
		public string? Hash
		{
			[Cpp2IlInjected.Token(Token = "0x600051D")]
			[Cpp2IlInjected.Address(RVA = "0xD11B30", Offset = "0xD10530", VA = "0x180D11B30")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600051E")]
			[Cpp2IlInjected.Address(RVA = "0xD12270", Offset = "0xD10C70", VA = "0x180D12270")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600051F")]
		[Cpp2IlInjected.Address(RVA = "0xD16C40", Offset = "0xD15640", VA = "0x180D16C40")]
		public RefereeFileReferenceDTO()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000B7")]
	public interface DVTGJVMMMGU
	{
		[Cpp2IlInjected.Token(Token = "0x1700025F")]
		bool Success
		{
			[Cpp2IlInjected.Token(Token = "0x6000520")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000260")]
		string? Error
		{
			[Cpp2IlInjected.Token(Token = "0x6000521")]
			[Cpp2IlInjected.Address(Slot = "1")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000261")]
		string? ErrorId
		{
			[Cpp2IlInjected.Token(Token = "0x6000522")]
			[Cpp2IlInjected.Address(Slot = "2")]
			get;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000B8")]
	public interface JXNUQHQTKTV<a> : DVTGJVMMMGU
	{
		[Cpp2IlInjected.Token(Token = "0x17000262")]
		a Value
		{
			[Cpp2IlInjected.Token(Token = "0x6000523")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000B9")]
	public static class CYYOLWHLRHN
	{
		[Cpp2IlInjected.Token(Token = "0x6000524")]
		[Cpp2IlInjected.Address(RVA = "0x3879960", Offset = "0x3878360", VA = "0x183879960")]
		public static JXNUQHQTKTV<T> Transform<T, U>(this JXNUQHQTKTV<U> result, Func<U, T> transformFunc)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000BA")]
	public struct RecNetResultUnserialized<T> : JXNUQHQTKTV<T>, DVTGJVMMMGU
	{
		[Cpp2IlInjected.Token(Token = "0x17000263")]
		public bool Success
		{
			[Cpp2IlInjected.Token(Token = "0x6000525")]
			[Cpp2IlInjected.Address(RVA = "0x10E40F0", Offset = "0x10E2AF0", VA = "0x1810E40F0", Slot = "5")]
			[CompilerGenerated]
			readonly get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000526")]
			[Cpp2IlInjected.Address(RVA = "0x2756B60", Offset = "0x2755560", VA = "0x182756B60")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000264")]
		public string? Error
		{
			[Cpp2IlInjected.Token(Token = "0x6000527")]
			[Cpp2IlInjected.Address(RVA = "0xF5DD60", Offset = "0xF5C760", VA = "0x180F5DD60", Slot = "6")]
			[CompilerGenerated]
			readonly get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000528")]
			[Cpp2IlInjected.Address(RVA = "0xF5DD70", Offset = "0xF5C770", VA = "0x180F5DD70")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000265")]
		public string? ErrorId
		{
			[Cpp2IlInjected.Token(Token = "0x6000529")]
			[Cpp2IlInjected.Address(RVA = "0xD117B0", Offset = "0xD101B0", VA = "0x180D117B0", Slot = "7")]
			[CompilerGenerated]
			readonly get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600052A")]
			[Cpp2IlInjected.Address(RVA = "0xD117C0", Offset = "0xD101C0", VA = "0x180D117C0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000266")]
		public T Value
		{
			[Cpp2IlInjected.Token(Token = "0x600052B")]
			[Cpp2IlInjected.Address(RVA = "0xD11B30", Offset = "0xD10530", VA = "0x180D11B30", Slot = "4")]
			[CompilerGenerated]
			readonly get
			{
				return (T)null;
			}
			[Cpp2IlInjected.Token(Token = "0x600052C")]
			[Cpp2IlInjected.Address(RVA = "0xD12270", Offset = "0xD10C70", VA = "0x180D12270")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600052D")]
		[Cpp2IlInjected.Address(RVA = "0x7961120", Offset = "0x795FB20", VA = "0x187961120")]
		public static RecNetResultUnserialized<T> Ok(T value)
		{
			return default(RecNetResultUnserialized<T>);
		}

		[Cpp2IlInjected.Token(Token = "0x600052E")]
		[Cpp2IlInjected.Address(RVA = "0x7960AF0", Offset = "0x795F4F0", VA = "0x187960AF0")]
		public static RecNetResultUnserialized<T> Fail(string error, string errorId = "")
		{
			return default(RecNetResultUnserialized<T>);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000BB")]
	[Utf8JsonSerializable]
	public class RecNetResult : DVTGJVMMMGU
	{
		[Cpp2IlInjected.Token(Token = "0x17000267")]
		public bool Success
		{
			[Cpp2IlInjected.Token(Token = "0x600052F")]
			[Cpp2IlInjected.Address(RVA = "0xD66E30", Offset = "0xD65830", VA = "0x180D66E30", Slot = "4")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000530")]
			[Cpp2IlInjected.Address(RVA = "0xE376D0", Offset = "0xE360D0", VA = "0x180E376D0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000268")]
		public string? Error
		{
			[Cpp2IlInjected.Token(Token = "0x6000531")]
			[Cpp2IlInjected.Address(RVA = "0xD11B30", Offset = "0xD10530", VA = "0x180D11B30", Slot = "5")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000532")]
			[Cpp2IlInjected.Address(RVA = "0xD12270", Offset = "0xD10C70", VA = "0x180D12270")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000269")]
		[DataMember(Name = "error_id")]
		public string? ErrorId
		{
			[Cpp2IlInjected.Token(Token = "0x6000533")]
			[Cpp2IlInjected.Address(RVA = "0xD12BC0", Offset = "0xD115C0", VA = "0x180D12BC0", Slot = "6")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000534")]
			[Cpp2IlInjected.Address(RVA = "0xD11520", Offset = "0xD0FF20", VA = "0x180D11520")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000535")]
		[Cpp2IlInjected.Address(RVA = "0x8DC4090", Offset = "0x8DC2A90", VA = "0x188DC4090")]
		public static RecNetResult Ok()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000536")]
		[Cpp2IlInjected.Address(RVA = "0x8DC4000", Offset = "0x8DC2A00", VA = "0x188DC4000")]
		public static RecNetResult Fail(string error, string errorId = "")
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000537")]
		[Cpp2IlInjected.Address(RVA = "0xD16C40", Offset = "0xD15640", VA = "0x180D16C40")]
		public RecNetResult()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000BC")]
	[Utf8JsonSerializableGeneric]
	public abstract class RecNetResult<T> : RecNetResult, JXNUQHQTKTV<T>, DVTGJVMMMGU
	{
		[Cpp2IlInjected.Token(Token = "0x1700026A")]
		public T Value
		{
			[Cpp2IlInjected.Token(Token = "0x6000538")]
			[Cpp2IlInjected.Address(RVA = "0xDA36E0", Offset = "0xDA20E0", VA = "0x180DA36E0", Slot = "7")]
			[CompilerGenerated]
			get
			{
				return (T)null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000539")]
			[Cpp2IlInjected.Address(RVA = "0xDA36F0", Offset = "0xDA20F0", VA = "0x180DA36F0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600053A")]
		[Cpp2IlInjected.Address(RVA = "0xD39E50", Offset = "0xD38850", VA = "0x180D39E50")]
		protected RecNetResult()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000BD")]
	[Utf8JsonSerializableGeneric]
	public class RecNetResultPrimitive<T> : RecNetResult<T>
	{
		[Cpp2IlInjected.Token(Token = "0x600053B")]
		[Cpp2IlInjected.Address(RVA = "0x7960A70", Offset = "0x795F470", VA = "0x187960A70")]
		private static void XMUTPUBNYFW()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600053C")]
		[Cpp2IlInjected.Address(RVA = "0xD39E50", Offset = "0xD38850", VA = "0x180D39E50")]
		public RecNetResultPrimitive()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000BE")]
	[Utf8JsonSerializableGeneric]
	public class RecNetResultObject<T> : RecNetResult<T>, QPSFFVWODNU where T : class
	{
		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x20000BF")]
		[CompilerGenerated]
		private struct <OnDeserializedAsync>d__0 : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400035C")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400035D")]
			public AsyncTaskMethodBuilder <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400035E")]
			public RecNetResultObject<T> <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400035F")]
			private OIRXPKYYAWC <obj1>5__2;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000360")]
			private object <>u__1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000361")]
			private ConfiguredTaskAwaitable.ConfiguredTaskAwaiter <>u__2;

			[Cpp2IlInjected.Token(Token = "0x6000541")]
			[Cpp2IlInjected.Address(RVA = "0x6ACA1D0", Offset = "0x6AC8BD0", VA = "0x186ACA1D0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000542")]
			[Cpp2IlInjected.Address(RVA = "0x6ACA5E0", Offset = "0x6AC8FE0", VA = "0x186ACA5E0", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600053D")]
		[Cpp2IlInjected.Address(RVA = "0x79608A0", Offset = "0x795F2A0", VA = "0x1879608A0", Slot = "8")]
		[AsyncStateMachine(typeof(RecNetResultObject<>.<OnDeserializedAsync>d__0))]
		public Task NLARVXFWNGH()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600053E")]
		[Cpp2IlInjected.Address(RVA = "0x7960990", Offset = "0x795F390", VA = "0x187960990")]
		public static RecNetResultObject<T> Ok(T value)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600053F")]
		[Cpp2IlInjected.Address(RVA = "0x79607B0", Offset = "0x795F1B0", VA = "0x1879607B0")]
		public new static RecNetResultObject<T> Fail(string error, string errorId = "")
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000540")]
		[Cpp2IlInjected.Address(RVA = "0xD39E50", Offset = "0xD38850", VA = "0x180D39E50")]
		public RecNetResultObject()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000C0")]
	[Utf8JsonSerializableGeneric]
	public class RecNetResultListPrimitive<T> : RecNetResult<List<T>>
	{
		[Cpp2IlInjected.Token(Token = "0x6000543")]
		[Cpp2IlInjected.Address(RVA = "0x4F26B00", Offset = "0x4F25500", VA = "0x184F26B00")]
		public RecNetResultListPrimitive()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000C1")]
	[Utf8JsonSerializableGeneric]
	public class RecNetResultListObject<T> : RecNetResult<List<T>>, QPSFFVWODNU where T : class
	{
		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x20000C2")]
		[CompilerGenerated]
		private struct <OnDeserializedAsync>d__2 : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000362")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000363")]
			public AsyncTaskMethodBuilder <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000364")]
			public RecNetResultListObject<T> <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000365")]
			private IEnumerable<OIRXPKYYAWC> <list1>5__2;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000366")]
			private object <>u__1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000367")]
			private ConfiguredTaskAwaitable.ConfiguredTaskAwaiter <>u__2;

			[Cpp2IlInjected.Token(Token = "0x6000548")]
			[Cpp2IlInjected.Address(RVA = "0x6ACA640", Offset = "0x6AC9040", VA = "0x186ACA640", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000549")]
			[Cpp2IlInjected.Address(RVA = "0x6ACAA30", Offset = "0x6AC9430", VA = "0x186ACAA30", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000544")]
		[Cpp2IlInjected.Address(RVA = "0x79606E0", Offset = "0x795F0E0", VA = "0x1879606E0")]
		public static RecNetResultListObject<T> Ok(List<T> value)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000545")]
		[Cpp2IlInjected.Address(RVA = "0x7960510", Offset = "0x795EF10", VA = "0x187960510")]
		public new static RecNetResultListObject<T> Fail(string error, string errorId = "")
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000546")]
		[Cpp2IlInjected.Address(RVA = "0x79605F0", Offset = "0x795EFF0", VA = "0x1879605F0", Slot = "8")]
		[AsyncStateMachine(typeof(RecNetResultListObject<>.<OnDeserializedAsync>d__2))]
		public Task NLARVXFWNGH()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000547")]
		[Cpp2IlInjected.Address(RVA = "0xD39E50", Offset = "0xD38850", VA = "0x180D39E50")]
		public RecNetResultListObject()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000C3")]
	public enum Service
	{
		[Cpp2IlInjected.Token(Token = "0x4000369")]
		AI,
		[Cpp2IlInjected.Token(Token = "0x400036A")]
		Auth,
		[Cpp2IlInjected.Token(Token = "0x400036B")]
		API,
		[Cpp2IlInjected.Token(Token = "0x400036C")]
		Commerce,
		[Cpp2IlInjected.Token(Token = "0x400036D")]
		Matchmaking,
		[Cpp2IlInjected.Token(Token = "0x400036E")]
		Notifications,
		[Cpp2IlInjected.Token(Token = "0x400036F")]
		Images,
		[Cpp2IlInjected.Token(Token = "0x4000370")]
		CDN,
		[Cpp2IlInjected.Token(Token = "0x4000371")]
		Storage,
		[Cpp2IlInjected.Token(Token = "0x4000372")]
		Chat,
		[Cpp2IlInjected.Token(Token = "0x4000373")]
		Leaderboard,
		[Cpp2IlInjected.Token(Token = "0x4000374")]
		Accounts,
		[Cpp2IlInjected.Token(Token = "0x4000375")]
		Link,
		[Cpp2IlInjected.Token(Token = "0x4000376")]
		Lists,
		[Cpp2IlInjected.Token(Token = "0x4000377")]
		RoomComments,
		[Cpp2IlInjected.Token(Token = "0x4000378")]
		Clubs,
		[Cpp2IlInjected.Token(Token = "0x4000379")]
		Rooms,
		[Cpp2IlInjected.Token(Token = "0x400037A")]
		PlatformNotifications,
		[Cpp2IlInjected.Token(Token = "0x400037B")]
		Moderation,
		[Cpp2IlInjected.Token(Token = "0x400037C")]
		DataCollection,
		[Cpp2IlInjected.Token(Token = "0x400037D")]
		BugReporting,
		[Cpp2IlInjected.Token(Token = "0x400037E")]
		Discovery,
		[Cpp2IlInjected.Token(Token = "0x400037F")]
		PlayerSettings,
		[Cpp2IlInjected.Token(Token = "0x4000380")]
		Studio,
		[Cpp2IlInjected.Token(Token = "0x4000381")]
		GameLogs,
		[Cpp2IlInjected.Token(Token = "0x4000382")]
		Strings,
		[Cpp2IlInjected.Token(Token = "0x4000383")]
		StringsCDN,
		[Cpp2IlInjected.Token(Token = "0x4000384")]
		WWW,
		[Cpp2IlInjected.Token(Token = "0x4000385")]
		Econ,
		[Cpp2IlInjected.Token(Token = "0x4000386")]
		Data,
		[Cpp2IlInjected.Token(Token = "0x4000387")]
		Cards
	}
	[Cpp2IlInjected.Token(Token = "0x20000C4")]
	public static class KHHRJSIUXPQ
	{
		[Cpp2IlInjected.Token(Token = "0x600054A")]
		[Cpp2IlInjected.Address(RVA = "0x8DC26D0", Offset = "0x8DC10D0", VA = "0x188DC26D0")]
		public static bool FHZQZVFVDCU(this Service a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600054B")]
		[Cpp2IlInjected.Address(RVA = "0x8DC26D0", Offset = "0x8DC10D0", VA = "0x188DC26D0")]
		public static bool TPKMFACTJXO(this Service a)
		{
			return default(bool);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000C5")]
	public enum CurrencyType
	{
		[Cpp2IlInjected.Token(Token = "0x4000389")]
		Invalid = 0,
		[Cpp2IlInjected.Token(Token = "0x400038A")]
		LaserTagTickets = 1,
		[Cpp2IlInjected.Token(Token = "0x400038B")]
		RecCenterTokens = 2,
		[Cpp2IlInjected.Token(Token = "0x400038C")]
		LostSkullsGold = 100,
		[Cpp2IlInjected.Token(Token = "0x400038D")]
		DraculaSilver = 101,
		[Cpp2IlInjected.Token(Token = "0x400038E")]
		RecRoyale_Season1 = 200,
		[Cpp2IlInjected.Token(Token = "0x400038F")]
		RoomCurrency = 300,
		[Cpp2IlInjected.Token(Token = "0x4000390")]
		RoomInventoryItem = 301,
		[Cpp2IlInjected.Token(Token = "0x4000391")]
		ProgressionEvent = 400,
		[Cpp2IlInjected.Token(Token = "0x4000392")]
		RoomieCredits = 500,
		[Cpp2IlInjected.Token(Token = "0x4000393")]
		PaintballPaint = 600
	}
	[Cpp2IlInjected.Token(Token = "0x20000C6")]
	public enum StorefrontBalanceType
	{
		[Cpp2IlInjected.Token(Token = "0x4000395")]
		NonPurchasedNotUsableInP2P = -2,
		[Cpp2IlInjected.Token(Token = "0x4000396")]
		NonPurchasedDefault = -1,
		[Cpp2IlInjected.Token(Token = "0x4000397")]
		SteamPurchased = 0,
		[Cpp2IlInjected.Token(Token = "0x4000398")]
		OculusPurchased = 1,
		[Cpp2IlInjected.Token(Token = "0x4000399")]
		PlayStationPurchased = 2,
		[Cpp2IlInjected.Token(Token = "0x400039A")]
		MicrosoftPurchased = 3,
		[Cpp2IlInjected.Token(Token = "0x400039B")]
		RecNetPurchased = 4,
		[Cpp2IlInjected.Token(Token = "0x400039C")]
		IOSPurchased = 5,
		[Cpp2IlInjected.Token(Token = "0x400039D")]
		GooglePlayPurchased = 6,
		[Cpp2IlInjected.Token(Token = "0x400039E")]
		PicoPurchased = 8,
		[Cpp2IlInjected.Token(Token = "0x400039F")]
		SwitchPurchased = 9,
		[Cpp2IlInjected.Token(Token = "0x40003A0")]
		[Obsolete("Subscription benefits for PS4 players were awarded with this balance type. It is not transferrable to other platforms. Usable in P2P economy. We are using PlayStationPurchased instead now. -- bilal - 11/11/2020")]
		PlayStationNonPurchasedP2P = 100,
		[Cpp2IlInjected.Token(Token = "0x40003A1")]
		[Obsolete("Subscription benefits for NON PS4 players were awarded with this balance type. We are using <PlatformType>Purchased instead now. -- bilal - 11/11/2020")]
		NonPlayStationNonPurchasedP2P = 101,
		[Cpp2IlInjected.Token(Token = "0x40003A2")]
		NonPurchasedEarnedByP2P = 1000,
		[Cpp2IlInjected.Token(Token = "0x40003A3")]
		NonPurchasedEarnedByP2Pv2 = 1001,
		[Cpp2IlInjected.Token(Token = "0x40003A4")]
		UndistributedRoomEarnings = 1002,
		[Cpp2IlInjected.Token(Token = "0x40003A5")]
		RoomieResetEveryRRPlusMonth = 1100,
		[Cpp2IlInjected.Token(Token = "0x40003A6")]
		RoomieEnergyPack = 1101,
		[Cpp2IlInjected.Token(Token = "0x40003A7")]
		RoomieVideoContest = 1102,
		[Cpp2IlInjected.Token(Token = "0x40003A8")]
		GameAIOverspend = 1200,
		[Cpp2IlInjected.Token(Token = "0x40003A9")]
		GameAIDeveloperSpend = 1201,
		[Cpp2IlInjected.Token(Token = "0x40003AA")]
		GameAIPromo = 1202,
		[Cpp2IlInjected.Token(Token = "0x40003AB")]
		GameAIPromoPrivateRoom = 1203
	}
	[Cpp2IlInjected.Token(Token = "0x20000C7")]
	public enum GiftContext
	{
		[Cpp2IlInjected.Token(Token = "0x40003AD")]
		None = -1,
		[Cpp2IlInjected.Token(Token = "0x40003AE")]
		Default = 0,
		[Cpp2IlInjected.Token(Token = "0x40003AF")]
		First_Activity = 1,
		[Cpp2IlInjected.Token(Token = "0x40003B0")]
		Game_Drop = 2,
		[Cpp2IlInjected.Token(Token = "0x40003B1")]
		All_Daily_Challenges_Complete = 3,
		[Cpp2IlInjected.Token(Token = "0x40003B2")]
		All_Weekly_Challenge_Complete = 4,
		[Cpp2IlInjected.Token(Token = "0x40003B3")]
		Daily_Challenge_Complete = 5,
		[Cpp2IlInjected.Token(Token = "0x40003B4")]
		Weekly_Challenge_Complete = 6,
		[Cpp2IlInjected.Token(Token = "0x40003B5")]
		Unassigned_Equipment = 10,
		[Cpp2IlInjected.Token(Token = "0x40003B6")]
		Unassigned_Avatar = 11,
		[Cpp2IlInjected.Token(Token = "0x40003B7")]
		Unassigned_Consumable = 12,
		[Cpp2IlInjected.Token(Token = "0x40003B8")]
		FB_Unassigned_Avatar = 13,
		[Cpp2IlInjected.Token(Token = "0x40003B9")]
		Reacquisition = 20,
		[Cpp2IlInjected.Token(Token = "0x40003BA")]
		Membership = 21,
		[Cpp2IlInjected.Token(Token = "0x40003BB")]
		Day2Reengagement = 22,
		[Cpp2IlInjected.Token(Token = "0x40003BC")]
		NUX_TokensAndDressUp = 30,
		[Cpp2IlInjected.Token(Token = "0x40003BD")]
		NUX_Experiment1 = 31,
		[Cpp2IlInjected.Token(Token = "0x40003BE")]
		NUX_Experiment2 = 32,
		[Cpp2IlInjected.Token(Token = "0x40003BF")]
		NUX_Experiment3 = 33,
		[Cpp2IlInjected.Token(Token = "0x40003C0")]
		NUX_Experiment4 = 34,
		[Cpp2IlInjected.Token(Token = "0x40003C1")]
		NUX_Experiment5 = 35,
		[Cpp2IlInjected.Token(Token = "0x40003C2")]
		GameRewards = 50,
		[Cpp2IlInjected.Token(Token = "0x40003C3")]
		GameRewards_Tokens = 51,
		[Cpp2IlInjected.Token(Token = "0x40003C4")]
		GameRewards_Tokens_Experiment_Override = 52,
		[Cpp2IlInjected.Token(Token = "0x40003C5")]
		GameRewards_A = 53,
		[Cpp2IlInjected.Token(Token = "0x40003C6")]
		GameRewards_B = 54,
		[Cpp2IlInjected.Token(Token = "0x40003C7")]
		LevelUp = 100,
		[Cpp2IlInjected.Token(Token = "0x40003C8")]
		Purchased_Gift_A = 500,
		[Cpp2IlInjected.Token(Token = "0x40003C9")]
		Purchased_Gift_B = 501,
		[Cpp2IlInjected.Token(Token = "0x40003CA")]
		Purchased_Gift_C = 502,
		[Cpp2IlInjected.Token(Token = "0x40003CB")]
		Purchased_Gift_D = 503,
		[Cpp2IlInjected.Token(Token = "0x40003CC")]
		Rectober = 600,
		[Cpp2IlInjected.Token(Token = "0x40003CD")]
		Rectober_Trick = 601,
		[Cpp2IlInjected.Token(Token = "0x40003CE")]
		Rectober_Treat = 602,
		[Cpp2IlInjected.Token(Token = "0x40003CF")]
		Rectober_Treat_Consumable = 603,
		[Cpp2IlInjected.Token(Token = "0x40003D0")]
		Rectober_Treat_Token = 604,
		[Cpp2IlInjected.Token(Token = "0x40003D1")]
		Rectober_Gift = 605,
		[Cpp2IlInjected.Token(Token = "0x40003D2")]
		Store_Limited_Time_Seasonal = 1000,
		[Cpp2IlInjected.Token(Token = "0x40003D3")]
		Store_Limited_Time_Contest = 1001,
		[Cpp2IlInjected.Token(Token = "0x40003D4")]
		Store_Limited_Time_Promotion = 1002,
		[Cpp2IlInjected.Token(Token = "0x40003D5")]
		Store_Limited_Time_Recurring = 1003,
		[Cpp2IlInjected.Token(Token = "0x40003D6")]
		Store_Limited_Time_Event = 1004,
		[Cpp2IlInjected.Token(Token = "0x40003D7")]
		Store_Limited_Time_Contract = 1005,
		[Cpp2IlInjected.Token(Token = "0x40003D8")]
		Store_Limited_Time_Free = 1006,
		[Cpp2IlInjected.Token(Token = "0x40003D9")]
		Store_Members_Only = 1010,
		[Cpp2IlInjected.Token(Token = "0x40003DA")]
		Store_Free = 1011,
		[Cpp2IlInjected.Token(Token = "0x40003DB")]
		Store_Indefinitely_Locked = 1090,
		[Cpp2IlInjected.Token(Token = "0x40003DC")]
		Deprecated = 1100,
		[Cpp2IlInjected.Token(Token = "0x40003DD")]
		RecRoyale = 1200,
		[Cpp2IlInjected.Token(Token = "0x40003DE")]
		Friendotron_Gift = 1300,
		[Cpp2IlInjected.Token(Token = "0x40003DF")]
		BackpackGame = 1400,
		[Cpp2IlInjected.Token(Token = "0x40003E0")]
		BackpackGame_HideAndSeek = 1401,
		[Cpp2IlInjected.Token(Token = "0x40003E1")]
		BackpackGame_FloorIsLava = 1402,
		[Cpp2IlInjected.Token(Token = "0x40003E2")]
		DEPRECATED_Paintball_ClearCut = 2000,
		[Cpp2IlInjected.Token(Token = "0x40003E3")]
		DEPRECATED_Paintball_Homestead = 2001,
		[Cpp2IlInjected.Token(Token = "0x40003E4")]
		DEPRECATED_Paintball_Quarry = 2002,
		[Cpp2IlInjected.Token(Token = "0x40003E5")]
		DEPRECATED_Paintball_River = 2003,
		[Cpp2IlInjected.Token(Token = "0x40003E6")]
		DEPRECATED_Paintball_Dam = 2004,
		[Cpp2IlInjected.Token(Token = "0x40003E7")]
		DEPRECATED_Paintball_DriveIn = 2005,
		[Cpp2IlInjected.Token(Token = "0x40003E8")]
		Paintball_ClearCut = 2010,
		[Cpp2IlInjected.Token(Token = "0x40003E9")]
		Paintball_Homestead = 2011,
		[Cpp2IlInjected.Token(Token = "0x40003EA")]
		Paintball_Quarry = 2012,
		[Cpp2IlInjected.Token(Token = "0x40003EB")]
		Paintball_River = 2013,
		[Cpp2IlInjected.Token(Token = "0x40003EC")]
		Paintball_Dam = 2014,
		[Cpp2IlInjected.Token(Token = "0x40003ED")]
		Paintball_DriveIn = 2015,
		[Cpp2IlInjected.Token(Token = "0x40003EE")]
		Paintball_MerryMidway = 2016,
		[Cpp2IlInjected.Token(Token = "0x40003EF")]
		DEPRECATED_Discgolf_Propulsion = 3000,
		[Cpp2IlInjected.Token(Token = "0x40003F0")]
		DEPRECATED_Discgolf_Lake = 3001,
		[Cpp2IlInjected.Token(Token = "0x40003F1")]
		Discgolf_Propulsion = 3010,
		[Cpp2IlInjected.Token(Token = "0x40003F2")]
		Discgolf_Lake = 3011,
		[Cpp2IlInjected.Token(Token = "0x40003F3")]
		Discgolf_Mode_CoopCatch = 3500,
		[Cpp2IlInjected.Token(Token = "0x40003F4")]
		Quest_Goblin_A = 4000,
		[Cpp2IlInjected.Token(Token = "0x40003F5")]
		Quest_Goblin_B = 4001,
		[Cpp2IlInjected.Token(Token = "0x40003F6")]
		Quest_Goblin_C = 4002,
		[Cpp2IlInjected.Token(Token = "0x40003F7")]
		Quest_Goblin_S = 4003,
		[Cpp2IlInjected.Token(Token = "0x40003F8")]
		Quest_Goblin_Consumable = 4004,
		[Cpp2IlInjected.Token(Token = "0x40003F9")]
		Quest_Cauldron_A = 4010,
		[Cpp2IlInjected.Token(Token = "0x40003FA")]
		Quest_Cauldron_B = 4011,
		[Cpp2IlInjected.Token(Token = "0x40003FB")]
		Quest_Cauldron_C = 4012,
		[Cpp2IlInjected.Token(Token = "0x40003FC")]
		Quest_Cauldron_S = 4013,
		[Cpp2IlInjected.Token(Token = "0x40003FD")]
		Quest_Cauldron_Consumable = 4014,
		[Cpp2IlInjected.Token(Token = "0x40003FE")]
		Quest_Pirate1_A = 4100,
		[Cpp2IlInjected.Token(Token = "0x40003FF")]
		Quest_Pirate1_B = 4101,
		[Cpp2IlInjected.Token(Token = "0x4000400")]
		Quest_Pirate1_C = 4102,
		[Cpp2IlInjected.Token(Token = "0x4000401")]
		Quest_Pirate1_S = 4103,
		[Cpp2IlInjected.Token(Token = "0x4000402")]
		Quest_Pirate1_X = 4104,
		[Cpp2IlInjected.Token(Token = "0x4000403")]
		Quest_Pirate1_Consumable = 4105,
		[Cpp2IlInjected.Token(Token = "0x4000404")]
		Quest_Dracula1_A = 4200,
		[Cpp2IlInjected.Token(Token = "0x4000405")]
		Quest_Dracula1_B = 4201,
		[Cpp2IlInjected.Token(Token = "0x4000406")]
		Quest_Dracula1_C = 4202,
		[Cpp2IlInjected.Token(Token = "0x4000407")]
		Quest_Dracula1_S = 4203,
		[Cpp2IlInjected.Token(Token = "0x4000408")]
		Quest_Dracula1_X = 4204,
		[Cpp2IlInjected.Token(Token = "0x4000409")]
		Quest_Dracula1_Consumable = 4205,
		[Cpp2IlInjected.Token(Token = "0x400040A")]
		Quest_Dracula1_SS = 4206,
		[Cpp2IlInjected.Token(Token = "0x400040B")]
		Quest_SciFi_A = 4500,
		[Cpp2IlInjected.Token(Token = "0x400040C")]
		Quest_SciFi_B = 4501,
		[Cpp2IlInjected.Token(Token = "0x400040D")]
		Quest_SciFi_C = 4502,
		[Cpp2IlInjected.Token(Token = "0x400040E")]
		Quest_SciFi_S = 4503,
		[Cpp2IlInjected.Token(Token = "0x400040F")]
		Quest_Scifi_Consumable = 4504,
		[Cpp2IlInjected.Token(Token = "0x4000410")]
		DEPRECATED_Charades = 5000,
		[Cpp2IlInjected.Token(Token = "0x4000411")]
		Charades = 5001,
		[Cpp2IlInjected.Token(Token = "0x4000412")]
		DEPRECATED_Soccer = 6000,
		[Cpp2IlInjected.Token(Token = "0x4000413")]
		Soccer = 6001,
		[Cpp2IlInjected.Token(Token = "0x4000414")]
		DEPRECATED_Paddleball = 7000,
		[Cpp2IlInjected.Token(Token = "0x4000415")]
		Paddleball = 7001,
		[Cpp2IlInjected.Token(Token = "0x4000416")]
		DEPRECATED_Dodgeball = 8000,
		[Cpp2IlInjected.Token(Token = "0x4000417")]
		Dodgeball = 8001,
		[Cpp2IlInjected.Token(Token = "0x4000418")]
		DEPRECATED_Lasertag = 9000,
		[Cpp2IlInjected.Token(Token = "0x4000419")]
		Lasertag = 9001,
		[Cpp2IlInjected.Token(Token = "0x400041A")]
		DEPRECATED_Bowling = 10000,
		[Cpp2IlInjected.Token(Token = "0x400041B")]
		Bowling = 10001,
		[Cpp2IlInjected.Token(Token = "0x400041C")]
		StuntRunner_TheMainEvent_A = 11000,
		[Cpp2IlInjected.Token(Token = "0x400041D")]
		StuntRunner_TheMainEvent_B = 11001,
		[Cpp2IlInjected.Token(Token = "0x400041E")]
		StuntRunner_TheMainEvent_C = 11002,
		[Cpp2IlInjected.Token(Token = "0x400041F")]
		StuntRunner_TheMainEvent_D = 11003,
		[Cpp2IlInjected.Token(Token = "0x4000420")]
		StuntRunner_TheMainEvent_S = 11004,
		[Cpp2IlInjected.Token(Token = "0x4000421")]
		StuntRunner_TheMainEvent_X = 11005,
		[Cpp2IlInjected.Token(Token = "0x4000422")]
		StuntRunner_TheMainEvent_Consumable = 11006,
		[Cpp2IlInjected.Token(Token = "0x4000423")]
		StuntRunner_TheMainEvent_SS = 11007,
		[Cpp2IlInjected.Token(Token = "0x4000424")]
		RecRally = 12000,
		[Cpp2IlInjected.Token(Token = "0x4000425")]
		Showdown_A = 12100,
		[Cpp2IlInjected.Token(Token = "0x4000426")]
		Showdown_B = 12101,
		[Cpp2IlInjected.Token(Token = "0x4000427")]
		Showdown_C = 12102,
		[Cpp2IlInjected.Token(Token = "0x4000428")]
		MyLittleMonsters = 12200,
		[Cpp2IlInjected.Token(Token = "0x4000429")]
		RunTheBlock = 12300,
		[Cpp2IlInjected.Token(Token = "0x400042A")]
		RROStorefront_ToBeNamed_2 = 12400,
		[Cpp2IlInjected.Token(Token = "0x400042B")]
		ProgressionEvent = 13000,
		[Cpp2IlInjected.Token(Token = "0x400042C")]
		TimedRewardTrack = 13100,
		[Cpp2IlInjected.Token(Token = "0x400042D")]
		PaintballBattlePass = 13200,
		[Cpp2IlInjected.Token(Token = "0x400042E")]
		PaintballBattlePass_Sprays_Common = 13201,
		[Cpp2IlInjected.Token(Token = "0x400042F")]
		PaintballBattlePass_Sprays_Uncommon = 13202,
		[Cpp2IlInjected.Token(Token = "0x4000430")]
		PaintballBattlePass_Sprays_Rare = 13203,
		[Cpp2IlInjected.Token(Token = "0x4000431")]
		PaintballBattlePass_Sprays_Epic = 13204,
		[Cpp2IlInjected.Token(Token = "0x4000432")]
		PaintballBattlePass_Sprays_Legendary = 13205,
		[Cpp2IlInjected.Token(Token = "0x4000433")]
		Store_LaserTag = 100000,
		[Cpp2IlInjected.Token(Token = "0x4000434")]
		Store_RecCenter = 100010,
		[Cpp2IlInjected.Token(Token = "0x4000435")]
		Consumable = 110000,
		[Cpp2IlInjected.Token(Token = "0x4000436")]
		Token = 110100,
		[Cpp2IlInjected.Token(Token = "0x4000437")]
		Punchcard_Challenge_Complete = 110200,
		[Cpp2IlInjected.Token(Token = "0x4000438")]
		All_Punchcard_Challenges_Complete = 110201,
		[Cpp2IlInjected.Token(Token = "0x4000439")]
		New_Player_Checklist_Item_Complete = 110300,
		[Cpp2IlInjected.Token(Token = "0x400043A")]
		ShoppingBagPromotions = 110400,
		[Cpp2IlInjected.Token(Token = "0x400043B")]
		Commerce_Purchase = 200000,
		[Cpp2IlInjected.Token(Token = "0x400043C")]
		Gift_Card_Redemption = 210000
	}
	[Cpp2IlInjected.Token(Token = "0x20000C8")]
	public enum GiftRarity
	{
		[Cpp2IlInjected.Token(Token = "0x400043E")]
		None = -1,
		[Cpp2IlInjected.Token(Token = "0x400043F")]
		Common = 0,
		[Cpp2IlInjected.Token(Token = "0x4000440")]
		Uncommon = 10,
		[Cpp2IlInjected.Token(Token = "0x4000441")]
		Rare = 20,
		[Cpp2IlInjected.Token(Token = "0x4000442")]
		Epic = 30,
		[Cpp2IlInjected.Token(Token = "0x4000443")]
		Legendary = 50
	}
	[Cpp2IlInjected.Token(Token = "0x20000C9")]
	public enum UpdateResponseTypes
	{
		[Cpp2IlInjected.Token(Token = "0x4000445")]
		OK,
		[Cpp2IlInjected.Token(Token = "0x4000446")]
		TooManyRequests,
		[Cpp2IlInjected.Token(Token = "0x4000447")]
		NotEnoughCredit,
		[Cpp2IlInjected.Token(Token = "0x4000448")]
		AlreadyOwned,
		[Cpp2IlInjected.Token(Token = "0x4000449")]
		NoItemAvailable,
		[Cpp2IlInjected.Token(Token = "0x400044A")]
		CouponNotApplicable,
		[Cpp2IlInjected.Token(Token = "0x400044B")]
		RequestedPriceDoesNotMatch,
		[Cpp2IlInjected.Token(Token = "0x400044C")]
		RequestedAmountNotAllowed,
		[Cpp2IlInjected.Token(Token = "0x400044D")]
		PlayerNotEligible,
		[Cpp2IlInjected.Token(Token = "0x400044E")]
		RequestCannotBeRefunded,
		[Cpp2IlInjected.Token(Token = "0x400044F")]
		PlayerNotApproved
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x20000CA")]
	[Utf8JsonSerializable]
	public class BalanceResponseDTO
	{
		[Cpp2IlInjected.Token(Token = "0x1700026B")]
		public long Balance
		{
			[Cpp2IlInjected.Token(Token = "0x600054C")]
			[Cpp2IlInjected.Address(RVA = "0xD117B0", Offset = "0xD101B0", VA = "0x180D117B0")]
			[CompilerGenerated]
			get
			{
				return default(long);
			}
			[Cpp2IlInjected.Token(Token = "0x600054D")]
			[Cpp2IlInjected.Address(RVA = "0xED90B0", Offset = "0xED7AB0", VA = "0x180ED90B0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700026C")]
		public CurrencyType CurrencyType
		{
			[Cpp2IlInjected.Token(Token = "0x600054E")]
			[Cpp2IlInjected.Address(RVA = "0xD17340", Offset = "0xD15D40", VA = "0x180D17340")]
			[CompilerGenerated]
			get
			{
				return default(CurrencyType);
			}
			[Cpp2IlInjected.Token(Token = "0x600054F")]
			[Cpp2IlInjected.Address(RVA = "0xD17360", Offset = "0xD15D60", VA = "0x180D17360")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700026D")]
		[DataMember(Name = "Platform")]
		public StorefrontBalanceType BalanceType
		{
			[Cpp2IlInjected.Token(Token = "0x6000550")]
			[Cpp2IlInjected.Address(RVA = "0x1664600", Offset = "0x1663000", VA = "0x181664600")]
			[CompilerGenerated]
			get
			{
				return default(StorefrontBalanceType);
			}
			[Cpp2IlInjected.Token(Token = "0x6000551")]
			[Cpp2IlInjected.Address(RVA = "0x1664610", Offset = "0x1663010", VA = "0x181664610")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000552")]
		[Cpp2IlInjected.Address(RVA = "0xD16C40", Offset = "0xD15640", VA = "0x180D16C40")]
		public BalanceResponseDTO()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000CB")]
	[Utf8JsonSerializable]
	public class FilteredTextDTO
	{
		[Cpp2IlInjected.Token(Token = "0x1700026E")]
		public string Text
		{
			[Cpp2IlInjected.Token(Token = "0x6000553")]
			[Cpp2IlInjected.Address(RVA = "0xD117B0", Offset = "0xD101B0", VA = "0x180D117B0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000554")]
			[Cpp2IlInjected.Address(RVA = "0xD117C0", Offset = "0xD101C0", VA = "0x180D117C0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700026F")]
		public int NumBadWords
		{
			[Cpp2IlInjected.Token(Token = "0x6000555")]
			[Cpp2IlInjected.Address(RVA = "0xD17340", Offset = "0xD15D40", VA = "0x180D17340")]
			[CompilerGenerated]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x6000556")]
			[Cpp2IlInjected.Address(RVA = "0xD17360", Offset = "0xD15D60", VA = "0x180D17360")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000557")]
		[Cpp2IlInjected.Address(RVA = "0xD16C40", Offset = "0xD15640", VA = "0x180D16C40")]
		public FilteredTextDTO()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000CC")]
	public static class QKVOMOTJVBD
	{
		[Cpp2IlInjected.Token(Token = "0x20000CD")]
		public enum UgcReportCategory
		{
			[Cpp2IlInjected.Token(Token = "0x4000456")]
			CoC_Discriminatory,
			[Cpp2IlInjected.Token(Token = "0x4000457")]
			CoC_Sexual,
			[Cpp2IlInjected.Token(Token = "0x4000458")]
			CoC_Trolling,
			[Cpp2IlInjected.Token(Token = "0x4000459")]
			Misleading,
			[Cpp2IlInjected.Token(Token = "0x400045A")]
			Other,
			[Cpp2IlInjected.Token(Token = "0x400045B")]
			InappropriateClothing
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000CE")]
	[Utf8JsonSerializable]
	public class AddOrRemovePlayerRoomInventoryRequestDTO
	{
		[Cpp2IlInjected.Token(Token = "0x17000270")]
		public long RoomId
		{
			[Cpp2IlInjected.Token(Token = "0x600055A")]
			[Cpp2IlInjected.Address(RVA = "0xD117B0", Offset = "0xD101B0", VA = "0x180D117B0")]
			[CompilerGenerated]
			get
			{
				return default(long);
			}
			[Cpp2IlInjected.Token(Token = "0x600055B")]
			[Cpp2IlInjected.Address(RVA = "0xED90B0", Offset = "0xED7AB0", VA = "0x180ED90B0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000271")]
		public Guid RoomInventoryItemOriginId
		{
			[Cpp2IlInjected.Token(Token = "0x600055C")]
			[Cpp2IlInjected.Address(RVA = "0xDA5E80", Offset = "0xDA4880", VA = "0x180DA5E80")]
			[CompilerGenerated]
			get
			{
				return default(Guid);
			}
			[Cpp2IlInjected.Token(Token = "0x600055D")]
			[Cpp2IlInjected.Address(RVA = "0xF82330", Offset = "0xF80D30", VA = "0x180F82330")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000272")]
		public long Quantity
		{
			[Cpp2IlInjected.Token(Token = "0x600055E")]
			[Cpp2IlInjected.Address(RVA = "0xD11B00", Offset = "0xD10500", VA = "0x180D11B00")]
			[CompilerGenerated]
			get
			{
				return default(long);
			}
			[Cpp2IlInjected.Token(Token = "0x600055F")]
			[Cpp2IlInjected.Address(RVA = "0xD11960", Offset = "0xD10360", VA = "0x180D11960")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000273")]
		public ConcurrencyCodePairDTO ConcurrencyCodes
		{
			[Cpp2IlInjected.Token(Token = "0x6000560")]
			[Cpp2IlInjected.Address(RVA = "0xD11A20", Offset = "0xD10420", VA = "0x180D11A20")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000561")]
			[Cpp2IlInjected.Address(RVA = "0xD17350", Offset = "0xD15D50", VA = "0x180D17350")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000558")]
		[Cpp2IlInjected.Address(RVA = "0xD16C40", Offset = "0xD15640", VA = "0x180D16C40")]
		public AddOrRemovePlayerRoomInventoryRequestDTO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000559")]
		[Cpp2IlInjected.Address(RVA = "0x8DBE040", Offset = "0x8DBCA40", VA = "0x188DBE040")]
		public AddOrRemovePlayerRoomInventoryRequestDTO(long roomId, Guid roomInventoryItemOriginId, long quantity, ConcurrencyCodePairDTO concurrencyCodes)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000CF")]
	[Utf8JsonSerializable]
	public class AddOrRemovePlayerRoomInventoryItemCountResponseDTO
	{
		[Cpp2IlInjected.Token(Token = "0x17000274")]
		public PlayerRoomInventoryOperationResult Result
		{
			[Cpp2IlInjected.Token(Token = "0x6000562")]
			[Cpp2IlInjected.Address(RVA = "0xD0F110", Offset = "0xD0DB10", VA = "0x180D0F110")]
			[CompilerGenerated]
			get
			{
				return default(PlayerRoomInventoryOperationResult);
			}
			[Cpp2IlInjected.Token(Token = "0x6000563")]
			[Cpp2IlInjected.Address(RVA = "0xD12F30", Offset = "0xD11930", VA = "0x180D12F30")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000275")]
		public PlayerRoomInventoryItemDTO PlayerRoomInventoryItem
		{
			[Cpp2IlInjected.Token(Token = "0x6000564")]
			[Cpp2IlInjected.Address(RVA = "0xD11B30", Offset = "0xD10530", VA = "0x180D11B30")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000565")]
			[Cpp2IlInjected.Address(RVA = "0xD12270", Offset = "0xD10C70", VA = "0x180D12270")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000566")]
		[Cpp2IlInjected.Address(RVA = "0xD16C40", Offset = "0xD15640", VA = "0x180D16C40")]
		public AddOrRemovePlayerRoomInventoryItemCountResponseDTO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000567")]
		[Cpp2IlInjected.Address(RVA = "0x10B08A0", Offset = "0x10AF2A0", VA = "0x1810B08A0")]
		public AddOrRemovePlayerRoomInventoryItemCountResponseDTO(PlayerRoomInventoryOperationResult result, PlayerRoomInventoryItemDTO playerRoomInventoryItem)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000D0")]
	[Utf8JsonSerializable]
	public class ConcurrencyCodePairDTO
	{
		[Cpp2IlInjected.Token(Token = "0x17000276")]
		public Guid? CurrentConcurrencyCode
		{
			[Cpp2IlInjected.Token(Token = "0x600056A")]
			[Cpp2IlInjected.Address(RVA = "0x32AC290", Offset = "0x32AAC90", VA = "0x1832AC290")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600056B")]
			[Cpp2IlInjected.Address(RVA = "0x8DBEB80", Offset = "0x8DBD580", VA = "0x188DBEB80")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000277")]
		public Guid NewConcurrencyCode
		{
			[Cpp2IlInjected.Token(Token = "0x600056C")]
			[Cpp2IlInjected.Address(RVA = "0xE93820", Offset = "0xE92220", VA = "0x180E93820")]
			[CompilerGenerated]
			get
			{
				return default(Guid);
			}
			[Cpp2IlInjected.Token(Token = "0x600056D")]
			[Cpp2IlInjected.Address(RVA = "0xE936A0", Offset = "0xE920A0", VA = "0x180E936A0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000568")]
		[Cpp2IlInjected.Address(RVA = "0xD16C40", Offset = "0xD15640", VA = "0x180D16C40")]
		public ConcurrencyCodePairDTO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000569")]
		[Cpp2IlInjected.Address(RVA = "0x8DBEB30", Offset = "0x8DBD530", VA = "0x188DBEB30")]
		public ConcurrencyCodePairDTO(Guid? currentConcurrencyCode, Guid newConcurrencyCodeValue)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000D1")]
	[Utf8JsonSerializable]
	public class PlayerRoomInventoryItemDTO
	{
		[Cpp2IlInjected.Token(Token = "0x17000278")]
		public long RoomId
		{
			[Cpp2IlInjected.Token(Token = "0x600056E")]
			[Cpp2IlInjected.Address(RVA = "0xD117B0", Offset = "0xD101B0", VA = "0x180D117B0")]
			[CompilerGenerated]
			get
			{
				return default(long);
			}
			[Cpp2IlInjected.Token(Token = "0x600056F")]
			[Cpp2IlInjected.Address(RVA = "0xED90B0", Offset = "0xED7AB0", VA = "0x180ED90B0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000279")]
		public Guid RoomInventoryItemOriginId
		{
			[Cpp2IlInjected.Token(Token = "0x6000570")]
			[Cpp2IlInjected.Address(RVA = "0xDA5E80", Offset = "0xDA4880", VA = "0x180DA5E80")]
			[CompilerGenerated]
			get
			{
				return default(Guid);
			}
			[Cpp2IlInjected.Token(Token = "0x6000571")]
			[Cpp2IlInjected.Address(RVA = "0xF82330", Offset = "0xF80D30", VA = "0x180F82330")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700027A")]
		public long Count
		{
			[Cpp2IlInjected.Token(Token = "0x6000572")]
			[Cpp2IlInjected.Address(RVA = "0xD11B00", Offset = "0xD10500", VA = "0x180D11B00")]
			[CompilerGenerated]
			get
			{
				return default(long);
			}
			[Cpp2IlInjected.Token(Token = "0x6000573")]
			[Cpp2IlInjected.Address(RVA = "0xD11960", Offset = "0xD10360", VA = "0x180D11960")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700027B")]
		public Guid ConcurrencyCode
		{
			[Cpp2IlInjected.Token(Token = "0x6000574")]
			[Cpp2IlInjected.Address(RVA = "0xF92C90", Offset = "0xF91690", VA = "0x180F92C90")]
			[CompilerGenerated]
			get
			{
				return default(Guid);
			}
			[Cpp2IlInjected.Token(Token = "0x6000575")]
			[Cpp2IlInjected.Address(RVA = "0xF931D0", Offset = "0xF91BD0", VA = "0x180F931D0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700027C")]
		public DateTime CreatedAt
		{
			[Cpp2IlInjected.Token(Token = "0x6000576")]
			[Cpp2IlInjected.Address(RVA = "0xD11A30", Offset = "0xD10430", VA = "0x180D11A30")]
			[CompilerGenerated]
			get
			{
				return default(DateTime);
			}
			[Cpp2IlInjected.Token(Token = "0x6000577")]
			[Cpp2IlInjected.Address(RVA = "0xFFBC20", Offset = "0xFFA620", VA = "0x180FFBC20")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700027D")]
		public DateTime ModifiedAt
		{
			[Cpp2IlInjected.Token(Token = "0x6000578")]
			[Cpp2IlInjected.Address(RVA = "0xD122E0", Offset = "0xD10CE0", VA = "0x180D122E0")]
			[CompilerGenerated]
			get
			{
				return default(DateTime);
			}
			[Cpp2IlInjected.Token(Token = "0x6000579")]
			[Cpp2IlInjected.Address(RVA = "0x1440140", Offset = "0x143EB40", VA = "0x181440140")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600057A")]
		[Cpp2IlInjected.Address(RVA = "0xD16C40", Offset = "0xD15640", VA = "0x180D16C40")]
		public PlayerRoomInventoryItemDTO()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000D2")]
	[Utf8JsonSerializable]
	public class RoomInventoryCreateOrUpdateRequestDTO
	{
		[Cpp2IlInjected.Token(Token = "0x1700027E")]
		public string Name
		{
			[Cpp2IlInjected.Token(Token = "0x600057B")]
			[Cpp2IlInjected.Address(RVA = "0xD117B0", Offset = "0xD101B0", VA = "0x180D117B0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600057C")]
			[Cpp2IlInjected.Address(RVA = "0xD117C0", Offset = "0xD101C0", VA = "0x180D117C0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700027F")]
		public string Description
		{
			[Cpp2IlInjected.Token(Token = "0x600057D")]
			[Cpp2IlInjected.Address(RVA = "0xD11B30", Offset = "0xD10530", VA = "0x180D11B30")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600057E")]
			[Cpp2IlInjected.Address(RVA = "0xD12270", Offset = "0xD10C70", VA = "0x180D12270")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000280")]
		public string ImageName
		{
			[Cpp2IlInjected.Token(Token = "0x600057F")]
			[Cpp2IlInjected.Address(RVA = "0xD12BC0", Offset = "0xD115C0", VA = "0x180D12BC0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000580")]
			[Cpp2IlInjected.Address(RVA = "0xD11520", Offset = "0xD0FF20", VA = "0x180D11520")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000281")]
		public List<long> TagIds
		{
			[Cpp2IlInjected.Token(Token = "0x6000581")]
			[Cpp2IlInjected.Address(RVA = "0xD11B00", Offset = "0xD10500", VA = "0x180D11B00")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000582")]
			[Cpp2IlInjected.Address(RVA = "0xD11530", Offset = "0xD0FF30", VA = "0x180D11530")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000282")]
		public List<RoomInventoryItemTagCreateDTO> NewTags
		{
			[Cpp2IlInjected.Token(Token = "0x6000583")]
			[Cpp2IlInjected.Address(RVA = "0xD11A20", Offset = "0xD10420", VA = "0x180D11A20")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000584")]
			[Cpp2IlInjected.Address(RVA = "0xD17350", Offset = "0xD15D50", VA = "0x180D17350")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000283")]
		public string Properties
		{
			[Cpp2IlInjected.Token(Token = "0x6000585")]
			[Cpp2IlInjected.Address(RVA = "0xD12280", Offset = "0xD10C80", VA = "0x180D12280")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000586")]
			[Cpp2IlInjected.Address(RVA = "0xD11B50", Offset = "0xD10550", VA = "0x180D11B50")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000284")]
		public byte? IconShape
		{
			[Cpp2IlInjected.Token(Token = "0x6000587")]
			[Cpp2IlInjected.Address(RVA = "0xEE6910", Offset = "0xEE5310", VA = "0x180EE6910")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000588")]
			[Cpp2IlInjected.Address(RVA = "0xEE6920", Offset = "0xEE5320", VA = "0x180EE6920")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000285")]
		public int? IconColor
		{
			[Cpp2IlInjected.Token(Token = "0x6000589")]
			[Cpp2IlInjected.Address(RVA = "0x5C9F5F0", Offset = "0x5C9DFF0", VA = "0x185C9F5F0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600058A")]
			[Cpp2IlInjected.Address(RVA = "0x8DBF280", Offset = "0x8DBDC80", VA = "0x188DBF280")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000286")]
		public Guid? OriginId
		{
			[Cpp2IlInjected.Token(Token = "0x600058B")]
			[Cpp2IlInjected.Address(RVA = "0x8735510", Offset = "0x8733F10", VA = "0x188735510")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600058C")]
			[Cpp2IlInjected.Address(RVA = "0x8DC4540", Offset = "0x8DC2F40", VA = "0x188DC4540")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000287")]
		public bool AllowRename
		{
			[Cpp2IlInjected.Token(Token = "0x600058D")]
			[Cpp2IlInjected.Address(RVA = "0xD11920", Offset = "0xD10320", VA = "0x180D11920")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x600058E")]
			[Cpp2IlInjected.Address(RVA = "0xD122C0", Offset = "0xD10CC0", VA = "0x180D122C0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600058F")]
		[Cpp2IlInjected.Address(RVA = "0xD16C40", Offset = "0xD15640", VA = "0x180D16C40")]
		public RoomInventoryCreateOrUpdateRequestDTO()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000D3")]
	[Utf8JsonSerializable]
	public class RoomInventoryItemDTO
	{
		[Cpp2IlInjected.Token(Token = "0x17000288")]
		public Guid OriginId
		{
			[Cpp2IlInjected.Token(Token = "0x6000590")]
			[Cpp2IlInjected.Address(RVA = "0xF357F0", Offset = "0xF341F0", VA = "0x180F357F0")]
			[CompilerGenerated]
			get
			{
				return default(Guid);
			}
			[Cpp2IlInjected.Token(Token = "0x6000591")]
			[Cpp2IlInjected.Address(RVA = "0xF35810", Offset = "0xF34210", VA = "0x180F35810")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000289")]
		public long RoomId
		{
			[Cpp2IlInjected.Token(Token = "0x6000592")]
			[Cpp2IlInjected.Address(RVA = "0xD12BC0", Offset = "0xD115C0", VA = "0x180D12BC0")]
			[CompilerGenerated]
			get
			{
				return default(long);
			}
			[Cpp2IlInjected.Token(Token = "0x6000593")]
			[Cpp2IlInjected.Address(RVA = "0xE3F130", Offset = "0xE3DB30", VA = "0x180E3F130")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700028A")]
		public string Name
		{
			[Cpp2IlInjected.Token(Token = "0x6000594")]
			[Cpp2IlInjected.Address(RVA = "0xD11B00", Offset = "0xD10500", VA = "0x180D11B00")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000595")]
			[Cpp2IlInjected.Address(RVA = "0xD11530", Offset = "0xD0FF30", VA = "0x180D11530")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700028B")]
		public string Description
		{
			[Cpp2IlInjected.Token(Token = "0x6000596")]
			[Cpp2IlInjected.Address(RVA = "0xD11A20", Offset = "0xD10420", VA = "0x180D11A20")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000597")]
			[Cpp2IlInjected.Address(RVA = "0xD17350", Offset = "0xD15D50", VA = "0x180D17350")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700028C")]
		public string ImageName
		{
			[Cpp2IlInjected.Token(Token = "0x6000598")]
			[Cpp2IlInjected.Address(RVA = "0xD12280", Offset = "0xD10C80", VA = "0x180D12280")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000599")]
			[Cpp2IlInjected.Address(RVA = "0xD11B50", Offset = "0xD10550", VA = "0x180D11B50")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700028D")]
		public DateTime CreatedAt
		{
			[Cpp2IlInjected.Token(Token = "0x600059A")]
			[Cpp2IlInjected.Address(RVA = "0xD11A30", Offset = "0xD10430", VA = "0x180D11A30")]
			[CompilerGenerated]
			get
			{
				return default(DateTime);
			}
			[Cpp2IlInjected.Token(Token = "0x600059B")]
			[Cpp2IlInjected.Address(RVA = "0xFFBC20", Offset = "0xFFA620", VA = "0x180FFBC20")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700028E")]
		public DateTime ModifiedAt
		{
			[Cpp2IlInjected.Token(Token = "0x600059C")]
			[Cpp2IlInjected.Address(RVA = "0xD122E0", Offset = "0xD10CE0", VA = "0x180D122E0")]
			[CompilerGenerated]
			get
			{
				return default(DateTime);
			}
			[Cpp2IlInjected.Token(Token = "0x600059D")]
			[Cpp2IlInjected.Address(RVA = "0x1440140", Offset = "0x143EB40", VA = "0x181440140")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700028F")]
		public string Properties
		{
			[Cpp2IlInjected.Token(Token = "0x600059E")]
			[Cpp2IlInjected.Address(RVA = "0xD11B20", Offset = "0xD10520", VA = "0x180D11B20")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600059F")]
			[Cpp2IlInjected.Address(RVA = "0xD11900", Offset = "0xD10300", VA = "0x180D11900")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000290")]
		public List<long> TagIds
		{
			[Cpp2IlInjected.Token(Token = "0x60005A0")]
			[Cpp2IlInjected.Address(RVA = "0xD11940", Offset = "0xD10340", VA = "0x180D11940")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60005A1")]
			[Cpp2IlInjected.Address(RVA = "0xD122A0", Offset = "0xD10CA0", VA = "0x180D122A0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000291")]
		public List<RoomInventoryItemTagDTO> NewTags
		{
			[Cpp2IlInjected.Token(Token = "0x60005A2")]
			[Cpp2IlInjected.Address(RVA = "0xD15610", Offset = "0xD14010", VA = "0x180D15610")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60005A3")]
			[Cpp2IlInjected.Address(RVA = "0xD15600", Offset = "0xD14000", VA = "0x180D15600")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000292")]
		public byte IconShape
		{
			[Cpp2IlInjected.Token(Token = "0x60005A4")]
			[Cpp2IlInjected.Address(RVA = "0xD21E10", Offset = "0xD20810", VA = "0x180D21E10")]
			[CompilerGenerated]
			get
			{
				return default(byte);
			}
			[Cpp2IlInjected.Token(Token = "0x60005A5")]
			[Cpp2IlInjected.Address(RVA = "0xD21D60", Offset = "0xD20760", VA = "0x180D21D60")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000293")]
		public int IconColor
		{
			[Cpp2IlInjected.Token(Token = "0x60005A6")]
			[Cpp2IlInjected.Address(RVA = "0xEF2E30", Offset = "0xEF1830", VA = "0x180EF2E30")]
			[CompilerGenerated]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x60005A7")]
			[Cpp2IlInjected.Address(RVA = "0x2AE5000", Offset = "0x2AE3A00", VA = "0x182AE5000")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60005A8")]
		[Cpp2IlInjected.Address(RVA = "0xD16C40", Offset = "0xD15640", VA = "0x180D16C40")]
		public RoomInventoryItemDTO()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000D4")]
	[Utf8JsonSerializable]
	public class RoomInventoryItemReplicationDTO : RoomInventoryItemDTO
	{
		[Cpp2IlInjected.Token(Token = "0x17000294")]
		public Guid RoomInventoryItemId
		{
			[Cpp2IlInjected.Token(Token = "0x60005A9")]
			[Cpp2IlInjected.Address(RVA = "0x6510250", Offset = "0x650EC50", VA = "0x186510250")]
			[CompilerGenerated]
			get
			{
				return default(Guid);
			}
			[Cpp2IlInjected.Token(Token = "0x60005AA")]
			[Cpp2IlInjected.Address(RVA = "0x650FA10", Offset = "0x650E410", VA = "0x18650FA10")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60005AB")]
		[Cpp2IlInjected.Address(RVA = "0xD16C40", Offset = "0xD15640", VA = "0x180D16C40")]
		public RoomInventoryItemReplicationDTO()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000D5")]
	public enum PlayerRoomInventoryOperationResult
	{
		[Cpp2IlInjected.Token(Token = "0x4000482")]
		Unknown = -1,
		[Cpp2IlInjected.Token(Token = "0x4000483")]
		Success,
		[Cpp2IlInjected.Token(Token = "0x4000484")]
		RoomInventoryItemDoesNotExist,
		[Cpp2IlInjected.Token(Token = "0x4000485")]
		PlayerDoesNotExist,
		[Cpp2IlInjected.Token(Token = "0x4000486")]
		RoomDoesNotExist,
		[Cpp2IlInjected.Token(Token = "0x4000487")]
		RequestQuantityTooLarge,
		[Cpp2IlInjected.Token(Token = "0x4000488")]
		PlayerHasReachedTheMinimumOwnedAmount,
		[Cpp2IlInjected.Token(Token = "0x4000489")]
		ConcurrencyCodeMismatch,
		[Cpp2IlInjected.Token(Token = "0x400048A")]
		InvalidConcurrencyCode
	}
	[Cpp2IlInjected.Token(Token = "0x20000D6")]
	public interface WQWIBMWFFSK
	{
		[Cpp2IlInjected.Token(Token = "0x60005AC")]
		[Cpp2IlInjected.Address(Slot = "0")]
		Task<RecNetResult<RoomInventoryItemDTO>> VGCGGEZZJKZ(Guid? a, long b, string c, string d, string e, string f, byte g, int h, [Optional] List<long> i, [Optional] List<RoomInventoryItemTagDTO> j, bool k = false, [Optional] CancellationToken l);

		[Cpp2IlInjected.Token(Token = "0x60005AD")]
		[Cpp2IlInjected.Address(Slot = "1")]
		Task<RecNetResult<RoomInventoryItemDTO>> JBRFQJYHRVI(Guid a, long b, [Optional] string c, [Optional] string d, [Optional] string e, [Optional] List<long> f, [Optional] Dictionary<string, string> g, [Optional] string h, [Optional] byte? i, [Optional] int? j, [Optional] CancellationToken k);

		[Cpp2IlInjected.Token(Token = "0x60005AE")]
		[Cpp2IlInjected.Address(Slot = "2")]
		Task<RecNetResult> PKIDKGHYBJK(Guid a, long b, [Optional] CancellationToken c);

		[Cpp2IlInjected.Token(Token = "0x60005AF")]
		[Cpp2IlInjected.Address(Slot = "3")]
		Task<List<RoomInventoryItemDTO>> ANIPUPXYYCQ(long a, [Optional] CancellationToken b);

		[Cpp2IlInjected.Token(Token = "0x60005B0")]
		[Cpp2IlInjected.Address(Slot = "4")]
		Task<List<PlayerRoomInventoryItemDTO>> ODWENIYZCGZ(long a, [Optional] CancellationToken b);

		[Cpp2IlInjected.Token(Token = "0x60005B1")]
		[Cpp2IlInjected.Address(Slot = "5")]
		Task<List<AddOrRemovePlayerRoomInventoryItemCountResponseDTO>> KDVMGAVWWZF(long a, List<AddOrRemovePlayerRoomInventoryRequestDTO> b, [Optional] CancellationToken c);
	}
	[Cpp2IlInjected.Token(Token = "0x20000D7")]
	[Utf8JsonSerializable]
	public class RoomInventoryItemTagCreateDTO
	{
		[Cpp2IlInjected.Token(Token = "0x17000295")]
		public string Name
		{
			[Cpp2IlInjected.Token(Token = "0x60005B2")]
			[Cpp2IlInjected.Address(RVA = "0xD117B0", Offset = "0xD101B0", VA = "0x180D117B0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60005B3")]
			[Cpp2IlInjected.Address(RVA = "0xD117C0", Offset = "0xD101C0", VA = "0x180D117C0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000296")]
		public string Properties
		{
			[Cpp2IlInjected.Token(Token = "0x60005B4")]
			[Cpp2IlInjected.Address(RVA = "0xD11B30", Offset = "0xD10530", VA = "0x180D11B30")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60005B5")]
			[Cpp2IlInjected.Address(RVA = "0xD12270", Offset = "0xD10C70", VA = "0x180D12270")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60005B6")]
		[Cpp2IlInjected.Address(RVA = "0xD16C40", Offset = "0xD15640", VA = "0x180D16C40")]
		public RoomInventoryItemTagCreateDTO()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000D8")]
	[Utf8JsonSerializable]
	public class RoomInventoryItemTagDTO
	{
		[Cpp2IlInjected.Token(Token = "0x17000297")]
		public long TagId
		{
			[Cpp2IlInjected.Token(Token = "0x60005B7")]
			[Cpp2IlInjected.Address(RVA = "0xD117B0", Offset = "0xD101B0", VA = "0x180D117B0")]
			[CompilerGenerated]
			get
			{
				return default(long);
			}
			[Cpp2IlInjected.Token(Token = "0x60005B8")]
			[Cpp2IlInjected.Address(RVA = "0xED90B0", Offset = "0xED7AB0", VA = "0x180ED90B0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000298")]
		public string Name
		{
			[Cpp2IlInjected.Token(Token = "0x60005B9")]
			[Cpp2IlInjected.Address(RVA = "0xD11B30", Offset = "0xD10530", VA = "0x180D11B30")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60005BA")]
			[Cpp2IlInjected.Address(RVA = "0xD12270", Offset = "0xD10C70", VA = "0x180D12270")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000299")]
		public string Properties
		{
			[Cpp2IlInjected.Token(Token = "0x60005BB")]
			[Cpp2IlInjected.Address(RVA = "0xD12BC0", Offset = "0xD115C0", VA = "0x180D12BC0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60005BC")]
			[Cpp2IlInjected.Address(RVA = "0xD11520", Offset = "0xD0FF20", VA = "0x180D11520")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60005BD")]
		[Cpp2IlInjected.Address(RVA = "0xD16C40", Offset = "0xD15640", VA = "0x180D16C40")]
		public RoomInventoryItemTagDTO()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000D9")]
	[Utf8JsonSerializable]
	public class RoomInventoryItemTagUpdateDTO
	{
		[Cpp2IlInjected.Token(Token = "0x1700029A")]
		public long TagId
		{
			[Cpp2IlInjected.Token(Token = "0x60005BF")]
			[Cpp2IlInjected.Address(RVA = "0xD117B0", Offset = "0xD101B0", VA = "0x180D117B0")]
			[CompilerGenerated]
			get
			{
				return default(long);
			}
			[Cpp2IlInjected.Token(Token = "0x60005C0")]
			[Cpp2IlInjected.Address(RVA = "0xED90B0", Offset = "0xED7AB0", VA = "0x180ED90B0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700029B")]
		public string Properties
		{
			[Cpp2IlInjected.Token(Token = "0x60005C1")]
			[Cpp2IlInjected.Address(RVA = "0xD11B30", Offset = "0xD10530", VA = "0x180D11B30")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60005C2")]
			[Cpp2IlInjected.Address(RVA = "0xD12270", Offset = "0xD10C70", VA = "0x180D12270")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60005BE")]
		[Cpp2IlInjected.Address(RVA = "0x6495A50", Offset = "0x6494450", VA = "0x186495A50")]
		public RoomInventoryItemTagUpdateDTO(long tagId, string properties)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000DA")]
	public interface LSCQWUNXGLF
	{
		[Cpp2IlInjected.Token(Token = "0x60005C3")]
		[Cpp2IlInjected.Address(Slot = "0")]
		Task<RecNetResult<List<RoomInventoryItemTagDTO>>> EKMBDOMTXED(long a, List<RoomInventoryItemTagUpdateDTO> b, [Optional] CancellationToken c);

		[Cpp2IlInjected.Token(Token = "0x60005C4")]
		[Cpp2IlInjected.Address(Slot = "1")]
		Task<RecNetResult> XLHWADZZADS(long a, [Optional] CancellationToken b);

		[Cpp2IlInjected.Token(Token = "0x60005C5")]
		[Cpp2IlInjected.Address(Slot = "2")]
		Task<List<RoomInventoryItemTagDTO>> GWMGKAVIWZU(long a, [Optional] CancellationToken b);
	}
	[Cpp2IlInjected.Token(Token = "0x20000DB")]
	[Utf8JsonSerializable]
	public class RoomOfferIdentifier : UGCPurchasableIdentifier, IEquatable<RoomOfferIdentifier>
	{
		[Cpp2IlInjected.Token(Token = "0x60005C6")]
		[Cpp2IlInjected.Address(RVA = "0x8DC45F0", Offset = "0x8DC2FF0", VA = "0x188DC45F0", Slot = "6")]
		public bool Equals(RoomOfferIdentifier other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60005C7")]
		[Cpp2IlInjected.Address(RVA = "0x8DC4580", Offset = "0x8DC2F80", VA = "0x188DC4580", Slot = "5")]
		public override UGCPurchasableIdentifier Clone()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60005C8")]
		[Cpp2IlInjected.Address(RVA = "0xD16C40", Offset = "0xD15640", VA = "0x180D16C40")]
		public RoomOfferIdentifier()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000DC")]
	public static class DRXVCRJLGPT
	{
		[Cpp2IlInjected.Token(Token = "0x60005C9")]
		[Cpp2IlInjected.Address(RVA = "0x8DBF3A0", Offset = "0x8DBDDA0", VA = "0x188DBF3A0")]
		public static RoomOfferIdentifier VQRUGTSIEYC(this RoomOffer a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60005CA")]
		[Cpp2IlInjected.Address(RVA = "0x8DBF290", Offset = "0x8DBDC90", VA = "0x188DBF290")]
		public static RoomOfferIdentifier TUZBEOPRIPO(string a)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000DD")]
	[Utf8JsonSerializable]
	public class RoomOffer
	{
		[Cpp2IlInjected.Token(Token = "0x4000492")]
		public const int MIN_NAME_LENGTH = 3;

		[Cpp2IlInjected.Token(Token = "0x4000493")]
		public const int MAX_NAME_LENGTH = 40;

		[Cpp2IlInjected.Token(Token = "0x4000494")]
		public const int MAX_DESCRIPTION_LENGTH = 180;

		[Cpp2IlInjected.Token(Token = "0x4000495")]
		public const int MAX_OFFERS_COUNT_PER_ROOM = 1000;

		[Cpp2IlInjected.Token(Token = "0x4000496")]
		public const int MAX_OFFER_INVENTORY_ITEM_COUNT = 99999;

		[Cpp2IlInjected.Token(Token = "0x4000497")]
		public const int MAX_OFFER_UNIQUE_INVENTORY_ITEM_COUNT = 8;

		[Cpp2IlInjected.Token(Token = "0x4000498")]
		public const int MIN_PRICE = 1;

		[Cpp2IlInjected.Token(Token = "0x4000499")]
		public const int MAX_PRICE = 1000000000;

		[Cpp2IlInjected.Token(Token = "0x400049A")]
		public const int MAX_CHECKOUT_QUANTITY = 9999;

		[Cpp2IlInjected.Token(Token = "0x400049B")]
		public const int DEFAULT_MINIMUM_DYNAMIC_PRICE = 1;

		[Cpp2IlInjected.Token(Token = "0x400049C")]
		public const int DEFAULT_MAXIMUM_DYNAMIC_PRICE = 1000000000;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
		[Cpp2IlInjected.Token(Token = "0x40004AF")]
		[IgnoreDataMember]
		private IReadOnlyDictionary<Guid, int>? OAYKGQHGWLV;

		[Cpp2IlInjected.Token(Token = "0x1700029C")]
		public Guid OriginId
		{
			[Cpp2IlInjected.Token(Token = "0x60005CB")]
			[Cpp2IlInjected.Address(RVA = "0xF357F0", Offset = "0xF341F0", VA = "0x180F357F0")]
			[CompilerGenerated]
			get
			{
				return default(Guid);
			}
			[Cpp2IlInjected.Token(Token = "0x60005CC")]
			[Cpp2IlInjected.Address(RVA = "0xF35810", Offset = "0xF34210", VA = "0x180F35810")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700029D")]
		public long RoomId
		{
			[Cpp2IlInjected.Token(Token = "0x60005CD")]
			[Cpp2IlInjected.Address(RVA = "0xD12BC0", Offset = "0xD115C0", VA = "0x180D12BC0")]
			[CompilerGenerated]
			get
			{
				return default(long);
			}
			[Cpp2IlInjected.Token(Token = "0x60005CE")]
			[Cpp2IlInjected.Address(RVA = "0xE3F130", Offset = "0xE3DB30", VA = "0x180E3F130")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700029E")]
		public string Name
		{
			[Cpp2IlInjected.Token(Token = "0x60005CF")]
			[Cpp2IlInjected.Address(RVA = "0xD11B00", Offset = "0xD10500", VA = "0x180D11B00")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60005D0")]
			[Cpp2IlInjected.Address(RVA = "0xD11530", Offset = "0xD0FF30", VA = "0x180D11530")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700029F")]
		public string? Description
		{
			[Cpp2IlInjected.Token(Token = "0x60005D1")]
			[Cpp2IlInjected.Address(RVA = "0xD11A20", Offset = "0xD10420", VA = "0x180D11A20")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60005D2")]
			[Cpp2IlInjected.Address(RVA = "0xD17350", Offset = "0xD15D50", VA = "0x180D17350")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170002A0")]
		public string? ImageName
		{
			[Cpp2IlInjected.Token(Token = "0x60005D3")]
			[Cpp2IlInjected.Address(RVA = "0xD12280", Offset = "0xD10C80", VA = "0x180D12280")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60005D4")]
			[Cpp2IlInjected.Address(RVA = "0xD11B50", Offset = "0xD10550", VA = "0x180D11B50")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170002A1")]
		public int Price
		{
			[Cpp2IlInjected.Token(Token = "0x60005D5")]
			[Cpp2IlInjected.Address(RVA = "0xD2DD40", Offset = "0xD2C740", VA = "0x180D2DD40")]
			[CompilerGenerated]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x60005D6")]
			[Cpp2IlInjected.Address(RVA = "0xD89720", Offset = "0xD88120", VA = "0x180D89720")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170002A2")]
		public bool IsGiftable
		{
			[Cpp2IlInjected.Token(Token = "0x60005D7")]
			[Cpp2IlInjected.Address(RVA = "0x19FA020", Offset = "0x19F8A20", VA = "0x1819FA020")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x60005D8")]
			[Cpp2IlInjected.Address(RVA = "0x19F9DF0", Offset = "0x19F87F0", VA = "0x1819F9DF0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170002A3")]
		public UgcPurchasableItemVisibility Visibility
		{
			[Cpp2IlInjected.Token(Token = "0x60005D9")]
			[Cpp2IlInjected.Address(RVA = "0xD88420", Offset = "0xD86E20", VA = "0x180D88420")]
			[CompilerGenerated]
			get
			{
				return default(UgcPurchasableItemVisibility);
			}
			[Cpp2IlInjected.Token(Token = "0x60005DA")]
			[Cpp2IlInjected.Address(RVA = "0xD89710", Offset = "0xD88110", VA = "0x180D89710")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170002A4")]
		public bool HasDynamicPrice
		{
			[Cpp2IlInjected.Token(Token = "0x60005DB")]
			[Cpp2IlInjected.Address(RVA = "0x10FD790", Offset = "0x10FC190", VA = "0x1810FD790")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x60005DC")]
			[Cpp2IlInjected.Address(RVA = "0x1836F90", Offset = "0x1835990", VA = "0x181836F90")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170002A5")]
		internal int? UMJQGHQXLNX
		{
			[Cpp2IlInjected.Token(Token = "0x60005DD")]
			[Cpp2IlInjected.Address(RVA = "0xD11B20", Offset = "0xD10520", VA = "0x180D11B20")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60005DE")]
			[Cpp2IlInjected.Address(RVA = "0xFFBF90", Offset = "0xFFA990", VA = "0x180FFBF90")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170002A6")]
		[IgnoreDataMember]
		public int MinDynamicPrice
		{
			[Cpp2IlInjected.Token(Token = "0x60005DF")]
			[Cpp2IlInjected.Address(RVA = "0x8DC4E10", Offset = "0x8DC3810", VA = "0x188DC4E10")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170002A7")]
		internal int? DTKKQAZXAQP
		{
			[Cpp2IlInjected.Token(Token = "0x60005E0")]
			[Cpp2IlInjected.Address(RVA = "0xD11940", Offset = "0xD10340", VA = "0x180D11940")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60005E1")]
			[Cpp2IlInjected.Address(RVA = "0x1016AA0", Offset = "0x10154A0", VA = "0x181016AA0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170002A8")]
		[IgnoreDataMember]
		public int MaxDynamicPrice
		{
			[Cpp2IlInjected.Token(Token = "0x60005E2")]
			[Cpp2IlInjected.Address(RVA = "0x8DC4DC0", Offset = "0x8DC37C0", VA = "0x188DC4DC0")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170002A9")]
		public Guid? PriceUnitOriginId
		{
			[Cpp2IlInjected.Token(Token = "0x60005E3")]
			[Cpp2IlInjected.Address(RVA = "0x8DC4E60", Offset = "0x8DC3860", VA = "0x188DC4E60")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60005E4")]
			[Cpp2IlInjected.Address(RVA = "0x8DC4F70", Offset = "0x8DC3970", VA = "0x188DC4F70")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170002AA")]
		public int Version
		{
			[Cpp2IlInjected.Token(Token = "0x60005E5")]
			[Cpp2IlInjected.Address(RVA = "0xD47130", Offset = "0xD45B30", VA = "0x180D47130")]
			[CompilerGenerated]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x60005E6")]
			[Cpp2IlInjected.Address(RVA = "0xD920D0", Offset = "0xD90AD0", VA = "0x180D920D0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170002AB")]
		public int? MaxNumPurchasesPerPlayer
		{
			[Cpp2IlInjected.Token(Token = "0x60005E7")]
			[Cpp2IlInjected.Address(RVA = "0xD1E8A0", Offset = "0xD1D2A0", VA = "0x180D1E8A0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60005E8")]
			[Cpp2IlInjected.Address(RVA = "0x1016940", Offset = "0x1015340", VA = "0x181016940")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170002AC")]
		public int? MaxCountPerPurchase
		{
			[Cpp2IlInjected.Token(Token = "0x60005E9")]
			[Cpp2IlInjected.Address(RVA = "0xD1E850", Offset = "0xD1D250", VA = "0x180D1E850")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60005EA")]
			[Cpp2IlInjected.Address(RVA = "0x1016730", Offset = "0x1015130", VA = "0x181016730")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170002AD")]
		public IReadOnlyList<RoomOfferItemMappingDTO> ItemMappings
		{
			[Cpp2IlInjected.Token(Token = "0x60005EB")]
			[Cpp2IlInjected.Address(RVA = "0xD1E900", Offset = "0xD1D300", VA = "0x180D1E900")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60005EC")]
			[Cpp2IlInjected.Address(RVA = "0xD1E880", Offset = "0xD1D280", VA = "0x180D1E880")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170002AE")]
		public DateTime CreatedAt
		{
			[Cpp2IlInjected.Token(Token = "0x60005ED")]
			[Cpp2IlInjected.Address(RVA = "0xD3FEF0", Offset = "0xD3E8F0", VA = "0x180D3FEF0")]
			[CompilerGenerated]
			get
			{
				return default(DateTime);
			}
			[Cpp2IlInjected.Token(Token = "0x60005EE")]
			[Cpp2IlInjected.Address(RVA = "0x2AFD6E0", Offset = "0x2AFC0E0", VA = "0x182AFD6E0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170002AF")]
		public DateTime ModifiedAt
		{
			[Cpp2IlInjected.Token(Token = "0x60005EF")]
			[Cpp2IlInjected.Address(RVA = "0xD1E7D0", Offset = "0xD1D1D0", VA = "0x180D1E7D0")]
			[CompilerGenerated]
			get
			{
				return default(DateTime);
			}
			[Cpp2IlInjected.Token(Token = "0x60005F0")]
			[Cpp2IlInjected.Address(RVA = "0x8C14110", Offset = "0x8C12B10", VA = "0x188C14110")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170002B0")]
		[IgnoreDataMember]
		public RoomOfferType RoomOfferType
		{
			[Cpp2IlInjected.Token(Token = "0x60005F1")]
			[Cpp2IlInjected.Address(RVA = "0x8DC4F00", Offset = "0x8DC3900", VA = "0x188DC4F00")]
			get
			{
				return default(RoomOfferType);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170002B1")]
		[IgnoreDataMember]
		public IReadOnlyDictionary<Guid, int> InventoryItemMappings
		{
			[Cpp2IlInjected.Token(Token = "0x60005F2")]
			[Cpp2IlInjected.Address(RVA = "0x8DC4D60", Offset = "0x8DC3760", VA = "0x188DC4D60")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60005F3")]
			[Cpp2IlInjected.Address(RVA = "0xEA1370", Offset = "0xE9FD70", VA = "0x180EA1370")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170002B2")]
		[IgnoreDataMember]
		public string? LocalOverrideImageName
		{
			[Cpp2IlInjected.Token(Token = "0x60005F4")]
			[Cpp2IlInjected.Address(RVA = "0xD13E60", Offset = "0xD12860", VA = "0x180D13E60")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60005F5")]
			[Cpp2IlInjected.Address(RVA = "0xD13E70", Offset = "0xD12870", VA = "0x180D13E70")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170002B3")]
		[IgnoreDataMember]
		public bool HasLocalOverrideImage
		{
			[Cpp2IlInjected.Token(Token = "0x60005F6")]
			[Cpp2IlInjected.Address(RVA = "0x8DC4CE0", Offset = "0x8DC36E0", VA = "0x188DC4CE0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170002B4")]
		[IgnoreDataMember]
		public string? LocalOverrideDescription
		{
			[Cpp2IlInjected.Token(Token = "0x60005F7")]
			[Cpp2IlInjected.Address(RVA = "0xEC39C0", Offset = "0xEC23C0", VA = "0x180EC39C0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60005F8")]
			[Cpp2IlInjected.Address(RVA = "0x102EA40", Offset = "0x102D440", VA = "0x18102EA40")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170002B5")]
		[IgnoreDataMember]
		public bool HasLocalOverrideDescription
		{
			[Cpp2IlInjected.Token(Token = "0x60005F9")]
			[Cpp2IlInjected.Address(RVA = "0x8DC4CC0", Offset = "0x8DC36C0", VA = "0x188DC4CC0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170002B6")]
		[IgnoreDataMember]
		public int? LocalOverridePrice
		{
			[Cpp2IlInjected.Token(Token = "0x60005FA")]
			[Cpp2IlInjected.Address(RVA = "0xF1FCA0", Offset = "0xF1E6A0", VA = "0x180F1FCA0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60005FB")]
			[Cpp2IlInjected.Address(RVA = "0x1D6CE50", Offset = "0x1D6B850", VA = "0x181D6CE50")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170002B7")]
		[IgnoreDataMember]
		public bool HasLocalOverridePrice
		{
			[Cpp2IlInjected.Token(Token = "0x60005FC")]
			[Cpp2IlInjected.Address(RVA = "0x8DC4D20", Offset = "0x8DC3720", VA = "0x188DC4D20")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170002B8")]
		[IgnoreDataMember]
		public int PurchasablePrice
		{
			[Cpp2IlInjected.Token(Token = "0x60005FD")]
			[Cpp2IlInjected.Address(RVA = "0x8DC4E80", Offset = "0x8DC3880", VA = "0x188DC4E80")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170002B9")]
		[IgnoreDataMember]
		public string? LocalOverrideName
		{
			[Cpp2IlInjected.Token(Token = "0x60005FE")]
			[Cpp2IlInjected.Address(RVA = "0xF04020", Offset = "0xF02A20", VA = "0x180F04020")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60005FF")]
			[Cpp2IlInjected.Address(RVA = "0xF04030", Offset = "0xF02A30", VA = "0x180F04030")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170002BA")]
		[IgnoreDataMember]
		public bool HasLocalOverrideName
		{
			[Cpp2IlInjected.Token(Token = "0x6000600")]
			[Cpp2IlInjected.Address(RVA = "0x8DC4D00", Offset = "0x8DC3700", VA = "0x188DC4D00")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000601")]
		[Cpp2IlInjected.Address(RVA = "0xD16C40", Offset = "0xD15640", VA = "0x180D16C40")]
		public RoomOffer()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000602")]
		[Cpp2IlInjected.Address(RVA = "0x8DC4BA0", Offset = "0x8DC35A0", VA = "0x188DC4BA0")]
		public RoomOffer(Guid originId, long roomId, string name, string description, string imageName, int price, bool isGiftable, UgcPurchasableItemVisibility visibility, bool hasDynamicPrice, int? minimumDynamicPrice, int? maximumDynamicPrice, int? maxNumPurchasesPerPlayer, int? maxCountPerPurchase, List<RoomOfferItemMappingDTO> itemMappings, [Optional] DateTime createdAt, [Optional] DateTime modifiedAt, [Optional] Guid? priceUnitOriginId)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000603")]
		[Cpp2IlInjected.Address(RVA = "0x8DC4830", Offset = "0x8DC3230", VA = "0x188DC4830")]
		private RoomOfferType GVPEHQSGHHY()
		{
			return default(RoomOfferType);
		}

		[Cpp2IlInjected.Token(Token = "0x6000604")]
		[Cpp2IlInjected.Address(RVA = "0x8DC48B0", Offset = "0x8DC32B0", VA = "0x188DC48B0")]
		private Dictionary<Guid, int> QIKQXMIGDMV(IReadOnlyList<RoomOfferItemMappingDTO> a)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000DE")]
	[Utf8JsonSerializable]
	public class RoomOfferIdDTO
	{
		[Cpp2IlInjected.Token(Token = "0x170002BB")]
		public Guid OriginId
		{
			[Cpp2IlInjected.Token(Token = "0x6000605")]
			[Cpp2IlInjected.Address(RVA = "0xF357F0", Offset = "0xF341F0", VA = "0x180F357F0")]
			[CompilerGenerated]
			get
			{
				return default(Guid);
			}
			[Cpp2IlInjected.Token(Token = "0x6000606")]
			[Cpp2IlInjected.Address(RVA = "0xF35810", Offset = "0xF34210", VA = "0x180F35810")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170002BC")]
		public long RoomId
		{
			[Cpp2IlInjected.Token(Token = "0x6000607")]
			[Cpp2IlInjected.Address(RVA = "0xD12BC0", Offset = "0xD115C0", VA = "0x180D12BC0")]
			[CompilerGenerated]
			get
			{
				return default(long);
			}
			[Cpp2IlInjected.Token(Token = "0x6000608")]
			[Cpp2IlInjected.Address(RVA = "0xE3F130", Offset = "0xE3DB30", VA = "0x180E3F130")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000609")]
		[Cpp2IlInjected.Address(RVA = "0xD16C40", Offset = "0xD15640", VA = "0x180D16C40")]
		public RoomOfferIdDTO()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000DF")]
	[Utf8JsonSerializable]
	public class RoomOfferReplicationDTO : RoomOffer
	{
		[Cpp2IlInjected.Token(Token = "0x170002BD")]
		public Guid RoomOfferId
		{
			[Cpp2IlInjected.Token(Token = "0x600060A")]
			[Cpp2IlInjected.Address(RVA = "0x17AF6F0", Offset = "0x17AE0F0", VA = "0x1817AF6F0")]
			[CompilerGenerated]
			get
			{
				return default(Guid);
			}
			[Cpp2IlInjected.Token(Token = "0x600060B")]
			[Cpp2IlInjected.Address(RVA = "0x17AE140", Offset = "0x17ACB40", VA = "0x1817AE140")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170002BE")]
		public Guid? PriceUnitId
		{
			[Cpp2IlInjected.Token(Token = "0x600060C")]
			[Cpp2IlInjected.Address(RVA = "0x8DC47F0", Offset = "0x8DC31F0", VA = "0x188DC47F0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600060D")]
			[Cpp2IlInjected.Address(RVA = "0x8DC4810", Offset = "0x8DC3210", VA = "0x188DC4810")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600060E")]
		[Cpp2IlInjected.Address(RVA = "0xD16C40", Offset = "0xD15640", VA = "0x180D16C40")]
		public RoomOfferReplicationDTO()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000E0")]
	[Utf8JsonSerializable]
	public class RoomOfferCreateOrUpdateRequestDTO
	{
		[Cpp2IlInjected.Token(Token = "0x170002BF")]
		public string Name
		{
			[Cpp2IlInjected.Token(Token = "0x600060F")]
			[Cpp2IlInjected.Address(RVA = "0xD117B0", Offset = "0xD101B0", VA = "0x180D117B0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000610")]
			[Cpp2IlInjected.Address(RVA = "0xD117C0", Offset = "0xD101C0", VA = "0x180D117C0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170002C0")]
		public string? Description
		{
			[Cpp2IlInjected.Token(Token = "0x6000611")]
			[Cpp2IlInjected.Address(RVA = "0xD11B30", Offset = "0xD10530", VA = "0x180D11B30")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000612")]
			[Cpp2IlInjected.Address(RVA = "0xD12270", Offset = "0xD10C70", VA = "0x180D12270")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170002C1")]
		public string? ImageName
		{
			[Cpp2IlInjected.Token(Token = "0x6000613")]
			[Cpp2IlInjected.Address(RVA = "0xD12BC0", Offset = "0xD115C0", VA = "0x180D12BC0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000614")]
			[Cpp2IlInjected.Address(RVA = "0xD11520", Offset = "0xD0FF20", VA = "0x180D11520")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170002C2")]
		public int Price
		{
			[Cpp2IlInjected.Token(Token = "0x6000615")]
			[Cpp2IlInjected.Address(RVA = "0xD12BE0", Offset = "0xD115E0", VA = "0x180D12BE0")]
			[CompilerGenerated]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x6000616")]
			[Cpp2IlInjected.Address(RVA = "0xD12C40", Offset = "0xD11640", VA = "0x180D12C40")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170002C3")]
		public bool HasDynamicPrice
		{
			[Cpp2IlInjected.Token(Token = "0x6000617")]
			[Cpp2IlInjected.Address(RVA = "0x1B417C0", Offset = "0x1B401C0", VA = "0x181B417C0")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000618")]
			[Cpp2IlInjected.Address(RVA = "0x10E0890", Offset = "0x10DF290", VA = "0x1810E0890")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170002C4")]
		public int? MinimumDynamicPrice
		{
			[Cpp2IlInjected.Token(Token = "0x6000619")]
			[Cpp2IlInjected.Address(RVA = "0xD11A20", Offset = "0xD10420", VA = "0x180D11A20")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600061A")]
			[Cpp2IlInjected.Address(RVA = "0xD118E0", Offset = "0xD102E0", VA = "0x180D118E0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170002C5")]
		public int? MaximumDynamicPrice
		{
			[Cpp2IlInjected.Token(Token = "0x600061B")]
			[Cpp2IlInjected.Address(RVA = "0xD12280", Offset = "0xD10C80", VA = "0x180D12280")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600061C")]
			[Cpp2IlInjected.Address(RVA = "0xD1B6D0", Offset = "0xD1A0D0", VA = "0x180D1B6D0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170002C6")]
		public int? MaxNumPurchasesPerPlayer
		{
			[Cpp2IlInjected.Token(Token = "0x600061D")]
			[Cpp2IlInjected.Address(RVA = "0xD11A30", Offset = "0xD10430", VA = "0x180D11A30")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600061E")]
			[Cpp2IlInjected.Address(RVA = "0xFFBC20", Offset = "0xFFA620", VA = "0x180FFBC20")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170002C7")]
		public int? MaxCountPerPurchase
		{
			[Cpp2IlInjected.Token(Token = "0x600061F")]
			[Cpp2IlInjected.Address(RVA = "0xD122E0", Offset = "0xD10CE0", VA = "0x180D122E0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000620")]
			[Cpp2IlInjected.Address(RVA = "0x1440140", Offset = "0x143EB40", VA = "0x181440140")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170002C8")]
		public List<RoomOfferItemMappingDTO> ItemMappings
		{
			[Cpp2IlInjected.Token(Token = "0x6000621")]
			[Cpp2IlInjected.Address(RVA = "0xD11B20", Offset = "0xD10520", VA = "0x180D11B20")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000622")]
			[Cpp2IlInjected.Address(RVA = "0xD11900", Offset = "0xD10300", VA = "0x180D11900")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170002C9")]
		public Guid? PriceUnitId
		{
			[Cpp2IlInjected.Token(Token = "0x6000623")]
			[Cpp2IlInjected.Address(RVA = "0x8DC4550", Offset = "0x8DC2F50", VA = "0x188DC4550")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000624")]
			[Cpp2IlInjected.Address(RVA = "0x8DC4570", Offset = "0x8DC2F70", VA = "0x188DC4570")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170002CA")]
		public Guid? OriginId
		{
			[Cpp2IlInjected.Token(Token = "0x6000625")]
			[Cpp2IlInjected.Address(RVA = "0x6506BD0", Offset = "0x65055D0", VA = "0x186506BD0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000626")]
			[Cpp2IlInjected.Address(RVA = "0x6505990", Offset = "0x6504390", VA = "0x186505990")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170002CB")]
		public bool AllowRename
		{
			[Cpp2IlInjected.Token(Token = "0x6000627")]
			[Cpp2IlInjected.Address(RVA = "0xD7C6F0", Offset = "0xD7B0F0", VA = "0x180D7C6F0")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000628")]
			[Cpp2IlInjected.Address(RVA = "0xDDC020", Offset = "0xDDAA20", VA = "0x180DDC020")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170002CC")]
		public UgcPurchasableItemVisibility Visibility
		{
			[Cpp2IlInjected.Token(Token = "0x6000629")]
			[Cpp2IlInjected.Address(RVA = "0x18BB4A0", Offset = "0x18B9EA0", VA = "0x1818BB4A0")]
			[CompilerGenerated]
			get
			{
				return default(UgcPurchasableItemVisibility);
			}
			[Cpp2IlInjected.Token(Token = "0x600062A")]
			[Cpp2IlInjected.Address(RVA = "0x169FAD0", Offset = "0x169E4D0", VA = "0x18169FAD0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170002CD")]
		public bool IsGiftable
		{
			[Cpp2IlInjected.Token(Token = "0x600062B")]
			[Cpp2IlInjected.Address(RVA = "0xFCC790", Offset = "0xFCB190", VA = "0x180FCC790")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x600062C")]
			[Cpp2IlInjected.Address(RVA = "0xFC95F0", Offset = "0xFC7FF0", VA = "0x180FC95F0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600062D")]
		[Cpp2IlInjected.Address(RVA = "0xD16C40", Offset = "0xD15640", VA = "0x180D16C40")]
		public RoomOfferCreateOrUpdateRequestDTO()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000E1")]
	[Utf8JsonSerializable]
	public class RoomOfferItemMappingDTO
	{
		[Cpp2IlInjected.Token(Token = "0x170002CE")]
		public RoomOfferItemType ItemType
		{
			[Cpp2IlInjected.Token(Token = "0x600062E")]
			[Cpp2IlInjected.Address(RVA = "0xD66E30", Offset = "0xD65830", VA = "0x180D66E30")]
			[CompilerGenerated]
			get
			{
				return default(RoomOfferItemType);
			}
			[Cpp2IlInjected.Token(Token = "0x600062F")]
			[Cpp2IlInjected.Address(RVA = "0xE376D0", Offset = "0xE360D0", VA = "0x180E376D0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170002CF")]
		public Guid ItemOriginId
		{
			[Cpp2IlInjected.Token(Token = "0x6000630")]
			[Cpp2IlInjected.Address(RVA = "0x1C7CC20", Offset = "0x1C7B620", VA = "0x181C7CC20")]
			[CompilerGenerated]
			get
			{
				return default(Guid);
			}
			[Cpp2IlInjected.Token(Token = "0x6000631")]
			[Cpp2IlInjected.Address(RVA = "0x7A23450", Offset = "0x7A21E50", VA = "0x187A23450")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170002D0")]
		public int Count
		{
			[Cpp2IlInjected.Token(Token = "0x6000632")]
			[Cpp2IlInjected.Address(RVA = "0xD38090", Offset = "0xD36A90", VA = "0x180D38090")]
			[CompilerGenerated]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x6000633")]
			[Cpp2IlInjected.Address(RVA = "0xF21A50", Offset = "0xF20450", VA = "0x180F21A50")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000634")]
		[Cpp2IlInjected.Address(RVA = "0xD16C40", Offset = "0xD15640", VA = "0x180D16C40")]
		public RoomOfferItemMappingDTO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000635")]
		[Cpp2IlInjected.Address(RVA = "0x8DC4640", Offset = "0x8DC3040", VA = "0x188DC4640")]
		public RoomOfferItemMappingDTO(Guid itemOriginId, RoomOfferItemType type, int count)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000E2")]
	[Utf8JsonSerializable]
	public class RoomOfferLastPurchaseDTO
	{
		[Cpp2IlInjected.Token(Token = "0x170002D1")]
		public Guid RoomOfferOriginId
		{
			[Cpp2IlInjected.Token(Token = "0x6000636")]
			[Cpp2IlInjected.Address(RVA = "0xF357F0", Offset = "0xF341F0", VA = "0x180F357F0")]
			[CompilerGenerated]
			get
			{
				return default(Guid);
			}
			[Cpp2IlInjected.Token(Token = "0x6000637")]
			[Cpp2IlInjected.Address(RVA = "0xF35810", Offset = "0xF34210", VA = "0x180F35810")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170002D2")]
		public string Name
		{
			[Cpp2IlInjected.Token(Token = "0x6000638")]
			[Cpp2IlInjected.Address(RVA = "0xD12BC0", Offset = "0xD115C0", VA = "0x180D12BC0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000639")]
			[Cpp2IlInjected.Address(RVA = "0xD11520", Offset = "0xD0FF20", VA = "0x180D11520")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170002D3")]
		public int PurchasePrice
		{
			[Cpp2IlInjected.Token(Token = "0x600063A")]
			[Cpp2IlInjected.Address(RVA = "0xD12BE0", Offset = "0xD115E0", VA = "0x180D12BE0")]
			[CompilerGenerated]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x600063B")]
			[Cpp2IlInjected.Address(RVA = "0xD12C40", Offset = "0xD11640", VA = "0x180D12C40")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170002D4")]
		public DateTime PurchaseDate
		{
			[Cpp2IlInjected.Token(Token = "0x600063C")]
			[Cpp2IlInjected.Address(RVA = "0xD11A20", Offset = "0xD10420", VA = "0x180D11A20")]
			[CompilerGenerated]
			get
			{
				return default(DateTime);
			}
			[Cpp2IlInjected.Token(Token = "0x600063D")]
			[Cpp2IlInjected.Address(RVA = "0xD118E0", Offset = "0xD102E0", VA = "0x180D118E0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170002D5")]
		public int Version
		{
			[Cpp2IlInjected.Token(Token = "0x600063E")]
			[Cpp2IlInjected.Address(RVA = "0xD40260", Offset = "0xD3EC60", VA = "0x180D40260")]
			[CompilerGenerated]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x600063F")]
			[Cpp2IlInjected.Address(RVA = "0xE27B10", Offset = "0xE26510", VA = "0x180E27B10")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000640")]
		[Cpp2IlInjected.Address(RVA = "0x8DC4690", Offset = "0x8DC3090", VA = "0x188DC4690")]
		public RoomOfferLastPurchaseDTO(Guid roomOfferOriginId, string name, int purchasePrice, DateTime purchaseDate, int version)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000641")]
		[Cpp2IlInjected.Address(RVA = "0xD16C40", Offset = "0xD15640", VA = "0x180D16C40")]
		public RoomOfferLastPurchaseDTO()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000E3")]
	[Utf8JsonSerializable]
	public class RoomOfferPurchaseCountDTO
	{
		[Cpp2IlInjected.Token(Token = "0x170002D6")]
		public Guid RoomOfferOriginId
		{
			[Cpp2IlInjected.Token(Token = "0x6000642")]
			[Cpp2IlInjected.Address(RVA = "0xF357F0", Offset = "0xF341F0", VA = "0x180F357F0")]
			[CompilerGenerated]
			get
			{
				return default(Guid);
			}
			[Cpp2IlInjected.Token(Token = "0x6000643")]
			[Cpp2IlInjected.Address(RVA = "0xF35810", Offset = "0xF34210", VA = "0x180F35810")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170002D7")]
		public int NumOffersPurchased
		{
			[Cpp2IlInjected.Token(Token = "0x6000644")]
			[Cpp2IlInjected.Address(RVA = "0xD215F0", Offset = "0xD1FFF0", VA = "0x180D215F0")]
			[CompilerGenerated]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x6000645")]
			[Cpp2IlInjected.Address(RVA = "0xD682F0", Offset = "0xD66CF0", VA = "0x180D682F0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000646")]
		[Cpp2IlInjected.Address(RVA = "0xD16C40", Offset = "0xD15640", VA = "0x180D16C40")]
		public RoomOfferPurchaseCountDTO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000647")]
		[Cpp2IlInjected.Address(RVA = "0x6FDCBD0", Offset = "0x6FDB5D0", VA = "0x186FDCBD0")]
		public RoomOfferPurchaseCountDTO(Guid roomOfferOriginId, int numOffersPurchased)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000E4")]
	[Utf8JsonSerializable]
	public class RoomOfferPurchaseRequestDTO
	{
		[Cpp2IlInjected.Token(Token = "0x170002D8")]
		public int NumOffersPurchased
		{
			[Cpp2IlInjected.Token(Token = "0x600064A")]
			[Cpp2IlInjected.Address(RVA = "0xD0F110", Offset = "0xD0DB10", VA = "0x180D0F110")]
			[CompilerGenerated]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x600064B")]
			[Cpp2IlInjected.Address(RVA = "0xD12F30", Offset = "0xD11930", VA = "0x180D12F30")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170002D9")]
		public Guid TransactionId
		{
			[Cpp2IlInjected.Token(Token = "0x600064C")]
			[Cpp2IlInjected.Address(RVA = "0x1C7CC20", Offset = "0x1C7B620", VA = "0x181C7CC20")]
			[CompilerGenerated]
			get
			{
				return default(Guid);
			}
			[Cpp2IlInjected.Token(Token = "0x600064D")]
			[Cpp2IlInjected.Address(RVA = "0x7A23450", Offset = "0x7A21E50", VA = "0x187A23450")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170002DA")]
		public int ExpectedTotalPrice
		{
			[Cpp2IlInjected.Token(Token = "0x600064E")]
			[Cpp2IlInjected.Address(RVA = "0xD38090", Offset = "0xD36A90", VA = "0x180D38090")]
			[CompilerGenerated]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x600064F")]
			[Cpp2IlInjected.Address(RVA = "0xF21A50", Offset = "0xF20450", VA = "0x180F21A50")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170002DB")]
		public Guid? ExpectedPriceUnitOriginId
		{
			[Cpp2IlInjected.Token(Token = "0x6000650")]
			[Cpp2IlInjected.Address(RVA = "0x1017410", Offset = "0x1015E10", VA = "0x181017410")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000651")]
			[Cpp2IlInjected.Address(RVA = "0x23E53B0", Offset = "0x23E3DB0", VA = "0x1823E53B0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170002DC")]
		public int ExpectedRoomOfferVersion
		{
			[Cpp2IlInjected.Token(Token = "0x6000652")]
			[Cpp2IlInjected.Address(RVA = "0xD50990", Offset = "0xD4F390", VA = "0x180D50990")]
			[CompilerGenerated]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x6000653")]
			[Cpp2IlInjected.Address(RVA = "0xD506C0", Offset = "0xD4F0C0", VA = "0x180D506C0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170002DD")]
		public Dictionary<Guid, Guid?> ConcurrencyCodeByItemOriginIdMap
		{
			[Cpp2IlInjected.Token(Token = "0x6000654")]
			[Cpp2IlInjected.Address(RVA = "0xD11A30", Offset = "0xD10430", VA = "0x180D11A30")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000655")]
			[Cpp2IlInjected.Address(RVA = "0xD12260", Offset = "0xD10C60", VA = "0x180D12260")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170002DE")]
		public int? GiftRecipientAccountId
		{
			[Cpp2IlInjected.Token(Token = "0x6000656")]
			[Cpp2IlInjected.Address(RVA = "0xD122E0", Offset = "0xD10CE0", VA = "0x180D122E0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000657")]
			[Cpp2IlInjected.Address(RVA = "0x1440140", Offset = "0x143EB40", VA = "0x181440140")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000648")]
		[Cpp2IlInjected.Address(RVA = "0xD16C40", Offset = "0xD15640", VA = "0x180D16C40")]
		public RoomOfferPurchaseRequestDTO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000649")]
		[Cpp2IlInjected.Address(RVA = "0x8DC4700", Offset = "0x8DC3100", VA = "0x188DC4700")]
		public RoomOfferPurchaseRequestDTO(int numOffersPurchased, Guid transactionId, int expectedTotalPrice, Guid? expectedPriceUnitOriginId, int expectedRoomOfferVersion, Dictionary<Guid, Guid?> concurrencyCodeByItemOriginIdMap, int? giftRecipientAccountId)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000E5")]
	[Utf8JsonSerializable]
	public class RoomOfferPurchaseResponseDTO
	{
		[Cpp2IlInjected.Token(Token = "0x170002DF")]
		public RoomOfferPurchaseOperationResult OperationResult
		{
			[Cpp2IlInjected.Token(Token = "0x600065A")]
			[Cpp2IlInjected.Address(RVA = "0xD66E30", Offset = "0xD65830", VA = "0x180D66E30")]
			[CompilerGenerated]
			get
			{
				return default(RoomOfferPurchaseOperationResult);
			}
			[Cpp2IlInjected.Token(Token = "0x600065B")]
			[Cpp2IlInjected.Address(RVA = "0xE376D0", Offset = "0xE360D0", VA = "0x180E376D0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170002E0")]
		public UpdateResponseTypes? BalanceUpdateResult
		{
			[Cpp2IlInjected.Token(Token = "0x600065C")]
			[Cpp2IlInjected.Address(RVA = "0x141BB20", Offset = "0x141A520", VA = "0x18141BB20")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600065D")]
			[Cpp2IlInjected.Address(RVA = "0x141E140", Offset = "0x141CB40", VA = "0x18141E140")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170002E1")]
		public BalanceResponseDTO TokenBalanceResponse
		{
			[Cpp2IlInjected.Token(Token = "0x600065E")]
			[Cpp2IlInjected.Address(RVA = "0xD12BC0", Offset = "0xD115C0", VA = "0x180D12BC0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600065F")]
			[Cpp2IlInjected.Address(RVA = "0xD11520", Offset = "0xD0FF20", VA = "0x180D11520")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170002E2")]
		public List<PlayerRoomInventoryItemDTO> PlayerRoomInventoryItems
		{
			[Cpp2IlInjected.Token(Token = "0x6000660")]
			[Cpp2IlInjected.Address(RVA = "0xD11B00", Offset = "0xD10500", VA = "0x180D11B00")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000661")]
			[Cpp2IlInjected.Address(RVA = "0xD11530", Offset = "0xD0FF30", VA = "0x180D11530")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000658")]
		[Cpp2IlInjected.Address(RVA = "0xD16C40", Offset = "0xD15640", VA = "0x180D16C40")]
		public RoomOfferPurchaseResponseDTO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000659")]
		[Cpp2IlInjected.Address(RVA = "0x8DC4780", Offset = "0x8DC3180", VA = "0x188DC4780")]
		public RoomOfferPurchaseResponseDTO(RoomOfferPurchaseOperationResult operationResult, UpdateResponseTypes? balanceUpdateResult, BalanceResponseDTO tokenBalanceResponse, List<PlayerRoomInventoryItemDTO> playerRoomInventoryItems)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000E6")]
	public enum RoomOfferItemType : byte
	{
		[Cpp2IlInjected.Token(Token = "0x40004DD")]
		Unset,
		[Cpp2IlInjected.Token(Token = "0x40004DE")]
		RoomInventoryItem
	}
	[Cpp2IlInjected.Token(Token = "0x20000E7")]
	public enum RoomOfferPurchaseOperationResult : byte
	{
		[Cpp2IlInjected.Token(Token = "0x40004E0")]
		Success = 0,
		[Cpp2IlInjected.Token(Token = "0x40004E1")]
		ConcurrencyCodeMismatch = 1,
		[Cpp2IlInjected.Token(Token = "0x40004E2")]
		RoomOfferDoesNotExist = 2,
		[Cpp2IlInjected.Token(Token = "0x40004E3")]
		InvalidRequest = 3,
		[Cpp2IlInjected.Token(Token = "0x40004E4")]
		AccountIdIsInvalid = 4,
		[Cpp2IlInjected.Token(Token = "0x40004E5")]
		PlayerIsP2PBuyingRestricted = 5,
		[Cpp2IlInjected.Token(Token = "0x40004E6")]
		ExpectedOfferTotalPriceMismatch = 6,
		[Cpp2IlInjected.Token(Token = "0x40004E7")]
		ExpectedOfferVersionMismatch = 7,
		[Cpp2IlInjected.Token(Token = "0x40004E8")]
		InsufficientBalance = 8,
		[Cpp2IlInjected.Token(Token = "0x40004E9")]
		OfferUnderModeration = 9,
		[Cpp2IlInjected.Token(Token = "0x40004EA")]
		InvalidExpectedTotalPrice = 10,
		[Cpp2IlInjected.Token(Token = "0x40004EB")]
		InvalidExpectedOfferVersion = 11,
		[Cpp2IlInjected.Token(Token = "0x40004EC")]
		CannotPurchaseMoreThanPerPlayerLimit = 12,
		[Cpp2IlInjected.Token(Token = "0x40004ED")]
		InvalidExpectedPriceUnit = 13,
		[Cpp2IlInjected.Token(Token = "0x40004EE")]
		InsufficientInventoryItems = 14,
		[Cpp2IlInjected.Token(Token = "0x40004EF")]
		InvalidDynamicPriceSettings = 15,
		[Cpp2IlInjected.Token(Token = "0x40004F0")]
		InvalidDynamicPrice = 16,
		[Cpp2IlInjected.Token(Token = "0x40004F1")]
		InvalidRelationship = 17,
		[Cpp2IlInjected.Token(Token = "0x40004F2")]
		PlayerIsUgcGiftingRestricted = 18,
		[Cpp2IlInjected.Token(Token = "0x40004F3")]
		PlayerIsUgcGiftReceivingRestricted = 19,
		[Cpp2IlInjected.Token(Token = "0x40004F4")]
		CannotGiftFreeRoomOffer = 20,
		[Cpp2IlInjected.Token(Token = "0x40004F5")]
		RoomOfferNotGiftable = 21,
		[Cpp2IlInjected.Token(Token = "0x40004F6")]
		GiftingRateLimited = 22,
		[Cpp2IlInjected.Token(Token = "0x40004F7")]
		NoConcurrencyCodesForInventoryItem = 100,
		[Cpp2IlInjected.Token(Token = "0x40004F8")]
		UnexpectedOfferItemType = 101,
		[Cpp2IlInjected.Token(Token = "0x40004F9")]
		FeatureDisabled = 254,
		[Cpp2IlInjected.Token(Token = "0x40004FA")]
		UnknownError = 255
	}
	[Cpp2IlInjected.Token(Token = "0x20000E8")]
	public enum RoomOfferType : byte
	{
		[Cpp2IlInjected.Token(Token = "0x40004FC")]
		Default,
		[Cpp2IlInjected.Token(Token = "0x40004FD")]
		OneTimePurchase,
		[Cpp2IlInjected.Token(Token = "0x40004FE")]
		BulkPurchase
	}
	[Cpp2IlInjected.Token(Token = "0x20000E9")]
	public interface LKRCFUBIKVO
	{
		[Cpp2IlInjected.Token(Token = "0x40004FF")]
		static ASNKAFBFVVA<RoomOffer> DODDVFBMCFG;

		[Cpp2IlInjected.Token(Token = "0x4000500")]
		static ASNKAFBFVVA<RoomOffer> BOPTBDJTTWP;

		[Cpp2IlInjected.Token(Token = "0x4000501")]
		static ASNKAFBFVVA<Guid> XMGOZLHAGLH;

		[Cpp2IlInjected.Token(Token = "0x6000662")]
		[Cpp2IlInjected.Address(Slot = "0")]
		Task<RecNetResult<RoomOffer?>?>? FCVTISXZUVG(Guid? a, long b, string name, string? c, string? d, int e, bool f, int g, int h, RoomOfferType i, bool j, UgcPurchasableItemVisibility k, [Optional] Dictionary<Guid, int>? l, [Optional] Guid? m, bool n = false, [Optional] CancellationToken o);

		[Cpp2IlInjected.Token(Token = "0x6000663")]
		[Cpp2IlInjected.Address(Slot = "1")]
		Task<RecNetResult<RoomOffer?>?>? IFWBDSIJIEP(Guid a, long b, string name, string? c, string? d, int e, bool f, int g, int h, RoomOfferType i, bool j, UgcPurchasableItemVisibility k, [Optional] Dictionary<Guid, int>? l, [Optional] Guid? m, [Optional] CancellationToken n);

		[Cpp2IlInjected.Token(Token = "0x6000664")]
		[Cpp2IlInjected.Address(Slot = "2")]
		Task<RecNetResult> SAKAOSXGWLX(Guid a, long b, [Optional] CancellationToken c);

		[Cpp2IlInjected.Token(Token = "0x6000665")]
		[Cpp2IlInjected.Address(Slot = "3")]
		Task<List<RoomOffer>> GVTTABSHDRH(long a, [Optional] CancellationToken b);

		[Cpp2IlInjected.Token(Token = "0x6000666")]
		[Cpp2IlInjected.Address(Slot = "4")]
		Task<RecNetResult<List<RoomOfferPurchaseCountDTO>>> AYLBIQUCAOD(long a, [Optional] CancellationToken b);

		[Cpp2IlInjected.Token(Token = "0x6000667")]
		[Cpp2IlInjected.Address(Slot = "5")]
		Task<RecNetResult<List<RoomOfferLastPurchaseDTO>>> ZSOALETMDBR(long a, [Optional] CancellationToken b);

		[Cpp2IlInjected.Token(Token = "0x6000668")]
		[Cpp2IlInjected.Address(Slot = "6")]
		Task<Dictionary<Guid, Guid?>> WBLRAYSQVZK(IReadOnlyList<Guid> a, int b, [Optional] CancellationToken c);

		[Cpp2IlInjected.Token(Token = "0x6000669")]
		[Cpp2IlInjected.Address(Slot = "7")]
		Task<RoomOfferPurchaseResponseDTO> NHDTYSJYFGV(Guid a, long b, int c, int d, Guid? e, int f, Dictionary<Guid, Guid?> g, int? h, [Optional] CancellationToken i);

		[Cpp2IlInjected.Token(Token = "0x600066A")]
		[Cpp2IlInjected.Address(RVA = "0x8DC2A00", Offset = "0x8DC1400", VA = "0x188DC2A00")]
		static LKRCFUBIKVO()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000EA")]
	[Utf8JsonSerializable]
	public class RoomEconConfigDTO
	{
		[Cpp2IlInjected.Token(Token = "0x170002E3")]
		public long RoomId
		{
			[Cpp2IlInjected.Token(Token = "0x600066B")]
			[Cpp2IlInjected.Address(RVA = "0xD117B0", Offset = "0xD101B0", VA = "0x180D117B0")]
			[CompilerGenerated]
			get
			{
				return default(long);
			}
			[Cpp2IlInjected.Token(Token = "0x600066C")]
			[Cpp2IlInjected.Address(RVA = "0xED90B0", Offset = "0xED7AB0", VA = "0x180ED90B0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170002E4")]
		public bool EnableSortingTabs
		{
			[Cpp2IlInjected.Token(Token = "0x600066D")]
			[Cpp2IlInjected.Address(RVA = "0xEB2260", Offset = "0xEB0C60", VA = "0x180EB2260")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x600066E")]
			[Cpp2IlInjected.Address(RVA = "0xD19FA0", Offset = "0xD189A0", VA = "0x180D19FA0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600066F")]
		[Cpp2IlInjected.Address(RVA = "0xD16C40", Offset = "0xD15640", VA = "0x180D16C40")]
		public RoomEconConfigDTO()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000EB")]
	public interface LEWOARAGHTQ
	{
		[Cpp2IlInjected.Token(Token = "0x6000670")]
		[Cpp2IlInjected.Address(Slot = "0")]
		Task<RoomEconConfigDTO> HIZNQYKBJYE(long a, [Optional] CancellationToken b);

		[Cpp2IlInjected.Token(Token = "0x6000671")]
		[Cpp2IlInjected.Address(Slot = "1")]
		Task<RecNetResult> QEMMTJKRXXC(long a, bool b, [Optional] CancellationToken c);
	}
	[Cpp2IlInjected.Token(Token = "0x20000EC")]
	[Utf8JsonSerializableGeneric]
	public class KDDCIWMSJRY<a>
	{
		[Cpp2IlInjected.Token(Token = "0x170002E5")]
		public long KFIRLNJJGXZ
		{
			[Cpp2IlInjected.Token(Token = "0x6000672")]
			[Cpp2IlInjected.Address(RVA = "0xD117B0", Offset = "0xD101B0", VA = "0x180D117B0")]
			[CompilerGenerated]
			get
			{
				return default(long);
			}
			[Cpp2IlInjected.Token(Token = "0x6000673")]
			[Cpp2IlInjected.Address(RVA = "0xED90B0", Offset = "0xED7AB0", VA = "0x180ED90B0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170002E6")]
		public CurrencyType VLHYTWDQGDM
		{
			[Cpp2IlInjected.Token(Token = "0x6000674")]
			[Cpp2IlInjected.Address(RVA = "0xD17340", Offset = "0xD15D40", VA = "0x180D17340")]
			[CompilerGenerated]
			get
			{
				return default(CurrencyType);
			}
			[Cpp2IlInjected.Token(Token = "0x6000675")]
			[Cpp2IlInjected.Address(RVA = "0xD17360", Offset = "0xD15D60", VA = "0x180D17360")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170002E7")]
		public StorefrontBalanceType UJKTVSKRJYL
		{
			[Cpp2IlInjected.Token(Token = "0x6000676")]
			[Cpp2IlInjected.Address(RVA = "0x1664600", Offset = "0x1663000", VA = "0x181664600")]
			[CompilerGenerated]
			get
			{
				return default(StorefrontBalanceType);
			}
			[Cpp2IlInjected.Token(Token = "0x6000677")]
			[Cpp2IlInjected.Address(RVA = "0x1664610", Offset = "0x1663010", VA = "0x181664610")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170002E8")]
		public a PXUWVBIVPWJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000678")]
			[Cpp2IlInjected.Address(RVA = "0xD12BC0", Offset = "0xD115C0", VA = "0x180D12BC0")]
			[CompilerGenerated]
			get
			{
				return (a)null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000679")]
			[Cpp2IlInjected.Address(RVA = "0xD11520", Offset = "0xD0FF20", VA = "0x180D11520")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600067A")]
		[Cpp2IlInjected.Address(RVA = "0xD16C40", Offset = "0xD15640", VA = "0x180D16C40")]
		public KDDCIWMSJRY()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000ED")]
	[Utf8JsonSerializableGeneric]
	public class GDLCVTXFKWS<a>
	{
		[Cpp2IlInjected.Token(Token = "0x170002E9")]
		public long KFIRLNJJGXZ
		{
			[Cpp2IlInjected.Token(Token = "0x600067B")]
			[Cpp2IlInjected.Address(RVA = "0xD117B0", Offset = "0xD101B0", VA = "0x180D117B0")]
			[CompilerGenerated]
			get
			{
				return default(long);
			}
			[Cpp2IlInjected.Token(Token = "0x600067C")]
			[Cpp2IlInjected.Address(RVA = "0xED90B0", Offset = "0xED7AB0", VA = "0x180ED90B0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170002EA")]
		public CurrencyType VLHYTWDQGDM
		{
			[Cpp2IlInjected.Token(Token = "0x600067D")]
			[Cpp2IlInjected.Address(RVA = "0xD17340", Offset = "0xD15D40", VA = "0x180D17340")]
			[CompilerGenerated]
			get
			{
				return default(CurrencyType);
			}
			[Cpp2IlInjected.Token(Token = "0x600067E")]
			[Cpp2IlInjected.Address(RVA = "0xD17360", Offset = "0xD15D60", VA = "0x180D17360")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170002EB")]
		public StorefrontBalanceType UJKTVSKRJYL
		{
			[Cpp2IlInjected.Token(Token = "0x600067F")]
			[Cpp2IlInjected.Address(RVA = "0x1664600", Offset = "0x1663000", VA = "0x181664600")]
			[CompilerGenerated]
			get
			{
				return default(StorefrontBalanceType);
			}
			[Cpp2IlInjected.Token(Token = "0x6000680")]
			[Cpp2IlInjected.Address(RVA = "0x1664610", Offset = "0x1663010", VA = "0x181664610")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170002EC")]
		public List<a> PXUWVBIVPWJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000681")]
			[Cpp2IlInjected.Address(RVA = "0xD12BC0", Offset = "0xD115C0", VA = "0x180D12BC0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000682")]
			[Cpp2IlInjected.Address(RVA = "0xD11520", Offset = "0xD0FF20", VA = "0x180D11520")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000683")]
		[Cpp2IlInjected.Address(RVA = "0xD16C40", Offset = "0xD15640", VA = "0x180D16C40")]
		public GDLCVTXFKWS()
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x20000EE")]
	[Utf8JsonSerializableGeneric]
	public class BalanceUpdateResponseDTO<DataTypeDTO> : BalanceResponseDTO, QPSFFVWODNU where DataTypeDTO : new()
	{
		[Cpp2IlInjected.Token(Token = "0x20000EF")]
		[Utf8JsonSerializableGeneric]
		public class PZFTNNZSWSX : QPSFFVWODNU
		{
			[StructLayout((LayoutKind)3)]
			[Cpp2IlInjected.Token(Token = "0x20000F0")]
			[CompilerGenerated]
			private struct <OnDeserializedAsync>d__8 : IAsyncStateMachine
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x400050F")]
				public int <>1__state;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x4000510")]
				public AsyncTaskMethodBuilder <>t__builder;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x4000511")]
				public PZFTNNZSWSX <>4__this;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x4000512")]
				private OIRXPKYYAWC <obj1>5__2;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x4000513")]
				private object <>u__1;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x4000514")]
				private ConfiguredTaskAwaitable.ConfiguredTaskAwaiter <>u__2;

				[Cpp2IlInjected.Token(Token = "0x600068E")]
				[Cpp2IlInjected.Address(RVA = "0x6ACCD70", Offset = "0x6ACB770", VA = "0x186ACCD70", Slot = "4")]
				private void MoveNext()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x600068F")]
				[Cpp2IlInjected.Address(RVA = "0x6ACD2B0", Offset = "0x6ACBCB0", VA = "0x186ACD2B0", Slot = "5")]
				[DebuggerHidden]
				private void SetStateMachine(IAsyncStateMachine stateMachine)
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x170002EE")]
			public UpdateResponseTypes AYTHLVRJKLZ
			{
				[Cpp2IlInjected.Token(Token = "0x6000688")]
				[Cpp2IlInjected.Address(RVA = "0xD0F110", Offset = "0xD0DB10", VA = "0x180D0F110")]
				[CompilerGenerated]
				get
				{
					return default(UpdateResponseTypes);
				}
				[Cpp2IlInjected.Token(Token = "0x6000689")]
				[Cpp2IlInjected.Address(RVA = "0xD12F30", Offset = "0xD11930", VA = "0x180D12F30")]
				[CompilerGenerated]
				set
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x170002EF")]
			public DataTypeDTO PXUWVBIVPWJ
			{
				[Cpp2IlInjected.Token(Token = "0x600068A")]
				[Cpp2IlInjected.Address(RVA = "0xD11B30", Offset = "0xD10530", VA = "0x180D11B30")]
				[CompilerGenerated]
				get
				{
					return (DataTypeDTO)null;
				}
				[Cpp2IlInjected.Token(Token = "0x600068B")]
				[Cpp2IlInjected.Address(RVA = "0xD12270", Offset = "0xD10C70", VA = "0x180D12270")]
				[CompilerGenerated]
				set
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x600068C")]
			[Cpp2IlInjected.Address(RVA = "0x74E3C80", Offset = "0x74E2680", VA = "0x1874E3C80", Slot = "4")]
			[AsyncStateMachine(typeof(BalanceUpdateResponseDTO<>.PZFTNNZSWSX.<OnDeserializedAsync>d__8))]
			public Task NLARVXFWNGH()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x600068D")]
			[Cpp2IlInjected.Address(RVA = "0xD16C40", Offset = "0xD15640", VA = "0x180D16C40")]
			public PZFTNNZSWSX()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170002ED")]
		public List<PZFTNNZSWSX> BalanceUpdates
		{
			[Cpp2IlInjected.Token(Token = "0x6000684")]
			[Cpp2IlInjected.Address(RVA = "0xD12BC0", Offset = "0xD115C0", VA = "0x180D12BC0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000685")]
			[Cpp2IlInjected.Address(RVA = "0xD11520", Offset = "0xD0FF20", VA = "0x180D11520")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000686")]
		[Cpp2IlInjected.Address(RVA = "0x4F29B50", Offset = "0x4F28550", VA = "0x184F29B50", Slot = "4")]
		public Task NLARVXFWNGH()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000687")]
		[Cpp2IlInjected.Address(RVA = "0xD39E50", Offset = "0xD38850", VA = "0x180D39E50")]
		public BalanceUpdateResponseDTO()
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x20000F1")]
	[Utf8JsonSerializableGeneric]
	public class PurchaseBalanceUpdateResponseDTO<DataTypeDTO> : BalanceResponseDTO, QPSFFVWODNU where DataTypeDTO : new()
	{
		[Cpp2IlInjected.Token(Token = "0x20000F2")]
		[Utf8JsonSerializableGeneric]
		public class PZFTNNZSWSX : QPSFFVWODNU
		{
			[StructLayout((LayoutKind)3)]
			[Cpp2IlInjected.Token(Token = "0x20000F3")]
			[CompilerGenerated]
			private struct <OnDeserializedAsync>d__8 : IAsyncStateMachine
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x4000518")]
				public int <>1__state;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x4000519")]
				public AsyncTaskMethodBuilder <>t__builder;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x400051A")]
				public PZFTNNZSWSX <>4__this;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x400051B")]
				private IEnumerable<OIRXPKYYAWC> <list1>5__2;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x400051C")]
				private object <>u__1;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x400051D")]
				private ConfiguredTaskAwaitable.ConfiguredTaskAwaiter <>u__2;

				[Cpp2IlInjected.Token(Token = "0x600069A")]
				[Cpp2IlInjected.Address(RVA = "0x6ACBFD0", Offset = "0x6ACA9D0", VA = "0x186ACBFD0", Slot = "4")]
				private void MoveNext()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x600069B")]
				[Cpp2IlInjected.Address(RVA = "0x6ACD190", Offset = "0x6ACBB90", VA = "0x186ACD190", Slot = "5")]
				[DebuggerHidden]
				private void SetStateMachine(IAsyncStateMachine stateMachine)
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x170002F1")]
			public UpdateResponseTypes AYTHLVRJKLZ
			{
				[Cpp2IlInjected.Token(Token = "0x6000694")]
				[Cpp2IlInjected.Address(RVA = "0xD0F110", Offset = "0xD0DB10", VA = "0x180D0F110")]
				[CompilerGenerated]
				get
				{
					return default(UpdateResponseTypes);
				}
				[Cpp2IlInjected.Token(Token = "0x6000695")]
				[Cpp2IlInjected.Address(RVA = "0xD12F30", Offset = "0xD11930", VA = "0x180D12F30")]
				[CompilerGenerated]
				set
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x170002F2")]
			public List<DataTypeDTO> PXUWVBIVPWJ
			{
				[Cpp2IlInjected.Token(Token = "0x6000696")]
				[Cpp2IlInjected.Address(RVA = "0xD11B30", Offset = "0xD10530", VA = "0x180D11B30")]
				[CompilerGenerated]
				get
				{
					return null;
				}
				[Cpp2IlInjected.Token(Token = "0x6000697")]
				[Cpp2IlInjected.Address(RVA = "0xD12270", Offset = "0xD10C70", VA = "0x180D12270")]
				[CompilerGenerated]
				set
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000698")]
			[Cpp2IlInjected.Address(RVA = "0x74E39B0", Offset = "0x74E23B0", VA = "0x1874E39B0", Slot = "4")]
			[AsyncStateMachine(typeof(PurchaseBalanceUpdateResponseDTO<>.PZFTNNZSWSX.<OnDeserializedAsync>d__8))]
			public Task NLARVXFWNGH()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000699")]
			[Cpp2IlInjected.Address(RVA = "0xD16C40", Offset = "0xD15640", VA = "0x180D16C40")]
			public PZFTNNZSWSX()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170002F0")]
		public List<PZFTNNZSWSX> BalanceUpdates
		{
			[Cpp2IlInjected.Token(Token = "0x6000690")]
			[Cpp2IlInjected.Address(RVA = "0xD12BC0", Offset = "0xD115C0", VA = "0x180D12BC0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000691")]
			[Cpp2IlInjected.Address(RVA = "0xD11520", Offset = "0xD0FF20", VA = "0x180D11520")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000692")]
		[Cpp2IlInjected.Address(RVA = "0x4F29B50", Offset = "0x4F28550", VA = "0x184F29B50", Slot = "4")]
		public Task NLARVXFWNGH()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000693")]
		[Cpp2IlInjected.Address(RVA = "0xD39E50", Offset = "0xD38850", VA = "0x180D39E50")]
		public PurchaseBalanceUpdateResponseDTO()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000F4")]
	[Utf8JsonSerializableGenericSpecialization]
	public class PurchaseBalanceUpdateResponseDTO_GiftPackage : PurchaseBalanceUpdateResponseDTO<GiftPackage>
	{
		[Cpp2IlInjected.Token(Token = "0x600069C")]
		[Cpp2IlInjected.Address(RVA = "0x8DC3F40", Offset = "0x8DC2940", VA = "0x188DC3F40")]
		public PurchaseBalanceUpdateResponseDTO_GiftPackage()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000F5")]
	[Utf8JsonSerializableGenericSpecialization]
	public class IFRJTOBGMUR : PurchaseBalanceUpdateResponseDTO<GiftPackage>.PZFTNNZSWSX
	{
		[Cpp2IlInjected.Token(Token = "0x600069D")]
		[Cpp2IlInjected.Address(RVA = "0x8DC0F20", Offset = "0x8DBF920", VA = "0x188DC0F20")]
		public IFRJTOBGMUR()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000F6")]
	[Utf8JsonSerializable]
	public class PurchaseItemRequestDTO
	{
		[Cpp2IlInjected.Token(Token = "0x170002F3")]
		public ItemPurchaseMethodId ItemPurchaseMethodId
		{
			[Cpp2IlInjected.Token(Token = "0x600069E")]
			[Cpp2IlInjected.Address(RVA = "0xD117B0", Offset = "0xD101B0", VA = "0x180D117B0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600069F")]
			[Cpp2IlInjected.Address(RVA = "0xD117C0", Offset = "0xD101C0", VA = "0x180D117C0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170002F4")]
		public long RequestedPrice
		{
			[Cpp2IlInjected.Token(Token = "0x60006A0")]
			[Cpp2IlInjected.Address(RVA = "0xD11B30", Offset = "0xD10530", VA = "0x180D11B30")]
			[CompilerGenerated]
			get
			{
				return default(long);
			}
			[Cpp2IlInjected.Token(Token = "0x60006A1")]
			[Cpp2IlInjected.Address(RVA = "0xE07390", Offset = "0xE05D90", VA = "0x180E07390")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170002F5")]
		public GiftItemDTO? Gift
		{
			[Cpp2IlInjected.Token(Token = "0x60006A2")]
			[Cpp2IlInjected.Address(RVA = "0xD12BC0", Offset = "0xD115C0", VA = "0x180D12BC0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60006A3")]
			[Cpp2IlInjected.Address(RVA = "0xD11520", Offset = "0xD0FF20", VA = "0x180D11520")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170002F6")]
		public long? CouponConsumablePlayerMappingId
		{
			[Cpp2IlInjected.Token(Token = "0x60006A4")]
			[Cpp2IlInjected.Address(RVA = "0x104E620", Offset = "0x104D020", VA = "0x18104E620")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60006A5")]
			[Cpp2IlInjected.Address(RVA = "0x104DCA0", Offset = "0x104C6A0", VA = "0x18104DCA0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170002F7")]
		public int DuplicateItemCount
		{
			[Cpp2IlInjected.Token(Token = "0x60006A6")]
			[Cpp2IlInjected.Address(RVA = "0xD40260", Offset = "0xD3EC60", VA = "0x180D40260")]
			[CompilerGenerated]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x60006A7")]
			[Cpp2IlInjected.Address(RVA = "0xE27B10", Offset = "0xE26510", VA = "0x180E27B10")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60006A8")]
		[Cpp2IlInjected.Address(RVA = "0x8DC3F80", Offset = "0x8DC2980", VA = "0x188DC3F80")]
		public PurchaseItemRequestDTO(ItemPurchaseMethodId itemPurchaseMethodId, long requestedPrice, GiftItemDTO? gift, int duplicateItemCount = 1, [Optional] long? couponConsumablePlayerMappingId)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000F7")]
	[Utf8JsonSerializable]
	public class BulkPurchaseItemRequestDTO
	{
		[Cpp2IlInjected.Token(Token = "0x170002F8")]
		public List<PurchaseItemRequestDTO> PurchaseItemRequests
		{
			[Cpp2IlInjected.Token(Token = "0x60006A9")]
			[Cpp2IlInjected.Address(RVA = "0xD117B0", Offset = "0xD101B0", VA = "0x180D117B0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60006AA")]
			[Cpp2IlInjected.Address(RVA = "0xD117C0", Offset = "0xD101C0", VA = "0x180D117C0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170002F9")]
		public StorefrontTypes? StorefrontType
		{
			[Cpp2IlInjected.Token(Token = "0x60006AB")]
			[Cpp2IlInjected.Address(RVA = "0xD11B30", Offset = "0xD10530", VA = "0x180D11B30")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60006AC")]
			[Cpp2IlInjected.Address(RVA = "0xE07390", Offset = "0xE05D90", VA = "0x180E07390")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170002FA")]
		public CurrencyType CurrencyType
		{
			[Cpp2IlInjected.Token(Token = "0x60006AD")]
			[Cpp2IlInjected.Address(RVA = "0xD215F0", Offset = "0xD1FFF0", VA = "0x180D215F0")]
			[CompilerGenerated]
			get
			{
				return default(CurrencyType);
			}
			[Cpp2IlInjected.Token(Token = "0x60006AE")]
			[Cpp2IlInjected.Address(RVA = "0xD682F0", Offset = "0xD66CF0", VA = "0x180D682F0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170002FB")]
		public bool BypassGiftPackages
		{
			[Cpp2IlInjected.Token(Token = "0x60006AF")]
			[Cpp2IlInjected.Address(RVA = "0xED9EB0", Offset = "0xED88B0", VA = "0x180ED9EB0")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x60006B0")]
			[Cpp2IlInjected.Address(RVA = "0xED9FA0", Offset = "0xED89A0", VA = "0x180ED9FA0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170002FC")]
		public bool AllowPartialSuccess
		{
			[Cpp2IlInjected.Token(Token = "0x60006B1")]
			[Cpp2IlInjected.Address(RVA = "0x16B0270", Offset = "0x16AEC70", VA = "0x1816B0270")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x60006B2")]
			[Cpp2IlInjected.Address(RVA = "0x8DBE8F0", Offset = "0x8DBD2F0", VA = "0x188DBE8F0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170002FD")]
		public Guid? ShoppingBagId
		{
			[Cpp2IlInjected.Token(Token = "0x60006B3")]
			[Cpp2IlInjected.Address(RVA = "0x1017410", Offset = "0x1015E10", VA = "0x181017410")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60006B4")]
			[Cpp2IlInjected.Address(RVA = "0x23E53B0", Offset = "0x23E3DB0", VA = "0x1823E53B0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60006B5")]
		[Cpp2IlInjected.Address(RVA = "0x8DBE870", Offset = "0x8DBD270", VA = "0x188DBE870")]
		public BulkPurchaseItemRequestDTO(List<PurchaseItemRequestDTO> purchaseItemRequests, StorefrontTypes? storefrontType, CurrencyType currencyType, bool allowPartialSuccess, bool bypassGiftPackages = false, [Optional] Guid? shoppingBagId)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000F8")]
	[Utf8JsonSerializable]
	public class BulkPurchaseItemsBalanceUpdateResponseDataDTO : QPSFFVWODNU
	{
		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x20000F9")]
		[CompilerGenerated]
		private struct <OnDeserializedAsync>d__14 : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400052E")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x400052F")]
			public AsyncTaskMethodBuilder <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000530")]
			public BulkPurchaseItemsBalanceUpdateResponseDataDTO <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000531")]
			private object <>u__1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000532")]
			private ConfiguredTaskAwaitable.ConfiguredTaskAwaiter <>u__2;

			[Cpp2IlInjected.Token(Token = "0x60006BE")]
			[Cpp2IlInjected.Address(RVA = "0x8DC7CC0", Offset = "0x8DC66C0", VA = "0x188DC7CC0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60006BF")]
			[Cpp2IlInjected.Address(RVA = "0x8DC8400", Offset = "0x8DC6E00", VA = "0x188DC8400", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000529")]
		internal static Action<GiftPackage>? AYLJVZECRGK;

		[Cpp2IlInjected.Token(Token = "0x400052A")]
		internal static Func<GiftPackage, Task>? VKOHEREKAEI;

		[Cpp2IlInjected.Token(Token = "0x170002FE")]
		public GiftPackage GiftPackage
		{
			[Cpp2IlInjected.Token(Token = "0x60006B6")]
			[Cpp2IlInjected.Address(RVA = "0xD117B0", Offset = "0xD101B0", VA = "0x180D117B0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60006B7")]
			[Cpp2IlInjected.Address(RVA = "0xD117C0", Offset = "0xD101C0", VA = "0x180D117C0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170002FF")]
		public int? PurchasableItemId
		{
			[Cpp2IlInjected.Token(Token = "0x60006B8")]
			[Cpp2IlInjected.Address(RVA = "0xD11B30", Offset = "0xD10530", VA = "0x180D11B30")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60006B9")]
			[Cpp2IlInjected.Address(RVA = "0xE07390", Offset = "0xE05D90", VA = "0x180E07390")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000300")]
		public CustomAvatarItem? CustomAvatarItem
		{
			[Cpp2IlInjected.Token(Token = "0x60006BA")]
			[Cpp2IlInjected.Address(RVA = "0xD12BC0", Offset = "0xD115C0", VA = "0x180D12BC0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60006BB")]
			[Cpp2IlInjected.Address(RVA = "0xD11520", Offset = "0xD0FF20", VA = "0x180D11520")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60006BC")]
		[Cpp2IlInjected.Address(RVA = "0x8DBE900", Offset = "0x8DBD300", VA = "0x188DBE900", Slot = "4")]
		[AsyncStateMachine(typeof(<OnDeserializedAsync>d__14))]
		public Task NLARVXFWNGH()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60006BD")]
		[Cpp2IlInjected.Address(RVA = "0xD16C40", Offset = "0xD15640", VA = "0x180D16C40")]
		public BulkPurchaseItemsBalanceUpdateResponseDataDTO()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000FA")]
	[Utf8JsonSerializableGenericSpecialization]
	public class BalanceUpdateResponseDTO_BulkPurchaseItemsBalanceUpdateResponseDataDTO : BalanceUpdateResponseDTO<BulkPurchaseItemsBalanceUpdateResponseDataDTO>
	{
		[Cpp2IlInjected.Token(Token = "0x60006C0")]
		[Cpp2IlInjected.Address(RVA = "0x8DBE830", Offset = "0x8DBD230", VA = "0x188DBE830")]
		public BalanceUpdateResponseDTO_BulkPurchaseItemsBalanceUpdateResponseDataDTO()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000FB")]
	[Utf8JsonSerializableGenericSpecialization]
	public class UELONZXKKSY : BalanceUpdateResponseDTO<BulkPurchaseItemsBalanceUpdateResponseDataDTO>.PZFTNNZSWSX
	{
		[Cpp2IlInjected.Token(Token = "0x60006C1")]
		[Cpp2IlInjected.Address(RVA = "0x8DC8DA0", Offset = "0x8DC77A0", VA = "0x188DC8DA0")]
		public UELONZXKKSY()
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x20000FC")]
	[Utf8JsonSerializable]
	public class GiftItemDTO
	{
		[Cpp2IlInjected.Token(Token = "0x17000301")]
		public int ToPlayerId
		{
			[Cpp2IlInjected.Token(Token = "0x60006C2")]
			[Cpp2IlInjected.Address(RVA = "0xD0F110", Offset = "0xD0DB10", VA = "0x180D0F110")]
			[CompilerGenerated]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x60006C3")]
			[Cpp2IlInjected.Address(RVA = "0xD12F30", Offset = "0xD11930", VA = "0x180D12F30")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000302")]
		public string? Message
		{
			[Cpp2IlInjected.Token(Token = "0x60006C4")]
			[Cpp2IlInjected.Address(RVA = "0xD11B30", Offset = "0xD10530", VA = "0x180D11B30")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60006C5")]
			[Cpp2IlInjected.Address(RVA = "0xD12270", Offset = "0xD10C70", VA = "0x180D12270")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000303")]
		public bool Anonymous
		{
			[Cpp2IlInjected.Token(Token = "0x60006C6")]
			[Cpp2IlInjected.Address(RVA = "0xD11950", Offset = "0xD10350", VA = "0x180D11950")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x60006C7")]
			[Cpp2IlInjected.Address(RVA = "0xD12250", Offset = "0xD10C50", VA = "0x180D12250")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000304")]
		public GiftContext GiftContext
		{
			[Cpp2IlInjected.Token(Token = "0x60006C8")]
			[Cpp2IlInjected.Address(RVA = "0xD38090", Offset = "0xD36A90", VA = "0x180D38090")]
			[CompilerGenerated]
			get
			{
				return default(GiftContext);
			}
			[Cpp2IlInjected.Token(Token = "0x60006C9")]
			[Cpp2IlInjected.Address(RVA = "0xF21A50", Offset = "0xF20450", VA = "0x180F21A50")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60006CA")]
		[Cpp2IlInjected.Address(RVA = "0xD16C40", Offset = "0xD15640", VA = "0x180D16C40")]
		public GiftItemDTO()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000FD")]
	[Utf8JsonSerializable]
	public class ItemPurchaseInfoDTO : AXIUZBXADAA
	{
		[Cpp2IlInjected.Token(Token = "0x17000305")]
		public UGCPurchasableItemIdentifier? ItemId
		{
			[Cpp2IlInjected.Token(Token = "0x60006CB")]
			[Cpp2IlInjected.Address(RVA = "0xD117B0", Offset = "0xD101B0", VA = "0x180D117B0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60006CC")]
			[Cpp2IlInjected.Address(RVA = "0xD117C0", Offset = "0xD101C0", VA = "0x180D117C0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000306")]
		[IgnoreDataMember]
		public Guid CustomAvatarItemId
		{
			[Cpp2IlInjected.Token(Token = "0x60006CD")]
			[Cpp2IlInjected.Address(RVA = "0x8DC1CF0", Offset = "0x8DC06F0", VA = "0x188DC1CF0", Slot = "4")]
			get
			{
				return default(Guid);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000307")]
		public ItemPurchaseMethodId? PurchaseMethodId
		{
			[Cpp2IlInjected.Token(Token = "0x60006CF")]
			[Cpp2IlInjected.Address(RVA = "0xD11B30", Offset = "0xD10530", VA = "0x180D11B30", Slot = "5")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60006D0")]
			[Cpp2IlInjected.Address(RVA = "0xD12270", Offset = "0xD10C70", VA = "0x180D12270")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000308")]
		public List<PurchasablePrice>? Prices
		{
			[Cpp2IlInjected.Token(Token = "0x60006D1")]
			[Cpp2IlInjected.Address(RVA = "0xD12BC0", Offset = "0xD115C0", VA = "0x180D12BC0", Slot = "6")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60006D2")]
			[Cpp2IlInjected.Address(RVA = "0xD11520", Offset = "0xD0FF20", VA = "0x180D11520")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000309")]
		public DateTime? NewUntil
		{
			[Cpp2IlInjected.Token(Token = "0x60006D3")]
			[Cpp2IlInjected.Address(RVA = "0x104E620", Offset = "0x104D020", VA = "0x18104E620", Slot = "7")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60006D4")]
			[Cpp2IlInjected.Address(RVA = "0x104DCA0", Offset = "0x104C6A0", VA = "0x18104DCA0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700030A")]
		public DateTime? AvailableAt
		{
			[Cpp2IlInjected.Token(Token = "0x60006D5")]
			[Cpp2IlInjected.Address(RVA = "0x169DD60", Offset = "0x169C760", VA = "0x18169DD60", Slot = "8")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60006D6")]
			[Cpp2IlInjected.Address(RVA = "0x169E860", Offset = "0x169D260", VA = "0x18169E860")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700030B")]
		public DateTime? AvailableUntil
		{
			[Cpp2IlInjected.Token(Token = "0x60006D7")]
			[Cpp2IlInjected.Address(RVA = "0xEF2E40", Offset = "0xEF1840", VA = "0x180EF2E40", Slot = "9")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60006D8")]
			[Cpp2IlInjected.Address(RVA = "0x1767F90", Offset = "0x1766990", VA = "0x181767F90")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700030C")]
		public bool CanBeGifted
		{
			[Cpp2IlInjected.Token(Token = "0x60006D9")]
			[Cpp2IlInjected.Address(RVA = "0xE21310", Offset = "0xE1FD10", VA = "0x180E21310", Slot = "10")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x60006DA")]
			[Cpp2IlInjected.Address(RVA = "0xE23F80", Offset = "0xE22980", VA = "0x180E23F80")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700030D")]
		public bool CanApplySubscriberDiscount
		{
			[Cpp2IlInjected.Token(Token = "0x60006DB")]
			[Cpp2IlInjected.Address(RVA = "0xD63120", Offset = "0xD61B20", VA = "0x180D63120")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x60006DC")]
			[Cpp2IlInjected.Address(RVA = "0xD63130", Offset = "0xD61B30", VA = "0x180D63130")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700030E")]
		public bool SubscribersOnly
		{
			[Cpp2IlInjected.Token(Token = "0x60006DD")]
			[Cpp2IlInjected.Address(RVA = "0x1107E30", Offset = "0x1106830", VA = "0x181107E30", Slot = "11")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x60006DE")]
			[Cpp2IlInjected.Address(RVA = "0x12EF120", Offset = "0x12EDB20", VA = "0x1812EF120")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700030F")]
		public bool IsFeatured
		{
			[Cpp2IlInjected.Token(Token = "0x60006DF")]
			[Cpp2IlInjected.Address(RVA = "0x32B8570", Offset = "0x32B6F70", VA = "0x1832B8570", Slot = "12")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x60006E0")]
			[Cpp2IlInjected.Address(RVA = "0x650F9E0", Offset = "0x650E3E0", VA = "0x18650F9E0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60006CE")]
		[Cpp2IlInjected.Address(RVA = "0x8DC1A60", Offset = "0x8DC0460", VA = "0x188DC1A60")]
		public static ItemPurchaseInfoDTO AEKLTUJDLQH(Guid a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60006E1")]
		[Cpp2IlInjected.Address(RVA = "0xD16C40", Offset = "0xD15640", VA = "0x180D16C40")]
		public ItemPurchaseInfoDTO()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000FE")]
	[Utf8JsonSerializable]
	public class RRPlusSignupConfigDTO
	{
		[Cpp2IlInjected.Token(Token = "0x17000310")]
		public int Version
		{
			[Cpp2IlInjected.Token(Token = "0x60006E2")]
			[Cpp2IlInjected.Address(RVA = "0xD0F110", Offset = "0xD0DB10", VA = "0x180D0F110")]
			[CompilerGenerated]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x60006E3")]
			[Cpp2IlInjected.Address(RVA = "0xD12F30", Offset = "0xD11930", VA = "0x180D12F30")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000311")]
		public string HighlightText
		{
			[Cpp2IlInjected.Token(Token = "0x60006E4")]
			[Cpp2IlInjected.Address(RVA = "0xD11B30", Offset = "0xD10530", VA = "0x180D11B30")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60006E5")]
			[Cpp2IlInjected.Address(RVA = "0xD12270", Offset = "0xD10C70", VA = "0x180D12270")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000312")]
		public string MoreDetailsText
		{
			[Cpp2IlInjected.Token(Token = "0x60006E6")]
			[Cpp2IlInjected.Address(RVA = "0xD12BC0", Offset = "0xD115C0", VA = "0x180D12BC0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60006E7")]
			[Cpp2IlInjected.Address(RVA = "0xD11520", Offset = "0xD0FF20", VA = "0x180D11520")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000313")]
		public Dictionary<int, RRPlusBenefitDescriptionDto> BenefitLookup
		{
			[Cpp2IlInjected.Token(Token = "0x60006E8")]
			[Cpp2IlInjected.Address(RVA = "0xD11B00", Offset = "0xD10500", VA = "0x180D11B00")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60006E9")]
			[Cpp2IlInjected.Address(RVA = "0xD11530", Offset = "0xD0FF30", VA = "0x180D11530")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000314")]
		public Dictionary<string, int> NumberReplacements
		{
			[Cpp2IlInjected.Token(Token = "0x60006EA")]
			[Cpp2IlInjected.Address(RVA = "0xD11A20", Offset = "0xD10420", VA = "0x180D11A20")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60006EB")]
			[Cpp2IlInjected.Address(RVA = "0xD17350", Offset = "0xD15D50", VA = "0x180D17350")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000315")]
		public Dictionary<BenefitListType, List<int>> BenefitLists
		{
			[Cpp2IlInjected.Token(Token = "0x60006EC")]
			[Cpp2IlInjected.Address(RVA = "0xD12280", Offset = "0xD10C80", VA = "0x180D12280")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60006ED")]
			[Cpp2IlInjected.Address(RVA = "0xD11B50", Offset = "0xD10550", VA = "0x180D11B50")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000316")]
		public Dictionary<string, string> StringConfigs
		{
			[Cpp2IlInjected.Token(Token = "0x60006EE")]
			[Cpp2IlInjected.Address(RVA = "0xD11A30", Offset = "0xD10430", VA = "0x180D11A30")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60006EF")]
			[Cpp2IlInjected.Address(RVA = "0xD12260", Offset = "0xD10C60", VA = "0x180D12260")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60006F0")]
		[Cpp2IlInjected.Address(RVA = "0xD16C40", Offset = "0xD15640", VA = "0x180D16C40")]
		public RRPlusSignupConfigDTO()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000FF")]
	public enum BenefitListType
	{
		[Cpp2IlInjected.Token(Token = "0x4000549")]
		DetailsScreen,
		[Cpp2IlInjected.Token(Token = "0x400054A")]
		SignUpScreen,
		[Cpp2IlInjected.Token(Token = "0x400054B")]
		ManageMembershipScreen,
		[Cpp2IlInjected.Token(Token = "0x400054C")]
		ItemDetailsScreen,
		[Cpp2IlInjected.Token(Token = "0x400054D")]
		ActivityRewardsScreen,
		[Cpp2IlInjected.Token(Token = "0x400054E")]
		RoomPublishUpsell
	}
	[Cpp2IlInjected.Token(Token = "0x2000100")]
	[Utf8JsonSerializable]
	public class RRPlusBenefitDescriptionDto : MOCDGFTFWRF
	{
		[Cpp2IlInjected.Token(Token = "0x17000317")]
		public PlatformMask EnabledForPlatforms
		{
			[Cpp2IlInjected.Token(Token = "0x60006F1")]
			[Cpp2IlInjected.Address(RVA = "0xD0F110", Offset = "0xD0DB10", VA = "0x180D0F110")]
			[CompilerGenerated]
			get
			{
				return default(PlatformMask);
			}
			[Cpp2IlInjected.Token(Token = "0x60006F2")]
			[Cpp2IlInjected.Address(RVA = "0xD12F30", Offset = "0xD11930", VA = "0x180D12F30")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000318")]
		public bool RequiresMonetizationEnabled
		{
			[Cpp2IlInjected.Token(Token = "0x60006F3")]
			[Cpp2IlInjected.Address(RVA = "0x137E3F0", Offset = "0x137CDF0", VA = "0x18137E3F0")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x60006F4")]
			[Cpp2IlInjected.Address(RVA = "0x16A6180", Offset = "0x16A4B80", VA = "0x1816A6180")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000319")]
		public bool RequiresPublishingEnabled
		{
			[Cpp2IlInjected.Token(Token = "0x60006F5")]
			[Cpp2IlInjected.Address(RVA = "0x113A7F0", Offset = "0x11391F0", VA = "0x18113A7F0")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x60006F6")]
			[Cpp2IlInjected.Address(RVA = "0x113A7D0", Offset = "0x11391D0", VA = "0x18113A7D0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700031A")]
		public string ShortText
		{
			[Cpp2IlInjected.Token(Token = "0x60006F7")]
			[Cpp2IlInjected.Address(RVA = "0xD11B30", Offset = "0xD10530", VA = "0x180D11B30", Slot = "5")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60006F8")]
			[Cpp2IlInjected.Address(RVA = "0xD12270", Offset = "0xD10C70", VA = "0x180D12270")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700031B")]
		public string TitleText
		{
			[Cpp2IlInjected.Token(Token = "0x60006F9")]
			[Cpp2IlInjected.Address(RVA = "0xD12BC0", Offset = "0xD115C0", VA = "0x180D12BC0", Slot = "4")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60006FA")]
			[Cpp2IlInjected.Address(RVA = "0xD11520", Offset = "0xD0FF20", VA = "0x180D11520")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700031C")]
		public string DetailedText
		{
			[Cpp2IlInjected.Token(Token = "0x60006FB")]
			[Cpp2IlInjected.Address(RVA = "0xD11B00", Offset = "0xD10500", VA = "0x180D11B00", Slot = "6")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60006FC")]
			[Cpp2IlInjected.Address(RVA = "0xD11530", Offset = "0xD0FF30", VA = "0x180D11530")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700031D")]
		public string CustomSpriteName
		{
			[Cpp2IlInjected.Token(Token = "0x60006FD")]
			[Cpp2IlInjected.Address(RVA = "0xD11A20", Offset = "0xD10420", VA = "0x180D11A20", Slot = "7")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60006FE")]
			[Cpp2IlInjected.Address(RVA = "0xD17350", Offset = "0xD15D50", VA = "0x180D17350")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700031E")]
		public Dictionary<PlatformType, string> PlatformSpecificDetailedTexts
		{
			[Cpp2IlInjected.Token(Token = "0x60006FF")]
			[Cpp2IlInjected.Address(RVA = "0xD12280", Offset = "0xD10C80", VA = "0x180D12280")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000700")]
			[Cpp2IlInjected.Address(RVA = "0xD11B50", Offset = "0xD10550", VA = "0x180D11B50")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000701")]
		[Cpp2IlInjected.Address(RVA = "0x16A61D0", Offset = "0x16A4BD0", VA = "0x1816A61D0")]
		public RRPlusBenefitDescriptionDto()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000101")]
	[Utf8JsonSerializable]
	public class GetItemPurchaseInfosRequestDTO
	{
		[Cpp2IlInjected.Token(Token = "0x1700031F")]
		public IReadOnlyList<UGCPurchasableItemIdentifier>? Ids
		{
			[Cpp2IlInjected.Token(Token = "0x6000702")]
			[Cpp2IlInjected.Address(RVA = "0xD117B0", Offset = "0xD101B0", VA = "0x180D117B0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000703")]
			[Cpp2IlInjected.Address(RVA = "0xD117C0", Offset = "0xD101C0", VA = "0x180D117C0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000704")]
		[Cpp2IlInjected.Address(RVA = "0xD16C40", Offset = "0xD15640", VA = "0x180D16C40")]
		public GetItemPurchaseInfosRequestDTO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000705")]
		[Cpp2IlInjected.Address(RVA = "0xD118A0", Offset = "0xD102A0", VA = "0x180D118A0")]
		public GetItemPurchaseInfosRequestDTO(IReadOnlyList<UGCPurchasableItemIdentifier>? ids)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000102")]
	public enum GiftBoxContents
	{
		[Cpp2IlInjected.Token(Token = "0x4000559")]
		Unspecified = -1,
		[Cpp2IlInjected.Token(Token = "0x400055A")]
		XP,
		[Cpp2IlInjected.Token(Token = "0x400055B")]
		OutfitItem,
		[Cpp2IlInjected.Token(Token = "0x400055C")]
		Equipment,
		[Cpp2IlInjected.Token(Token = "0x400055D")]
		Currency,
		[Cpp2IlInjected.Token(Token = "0x400055E")]
		Consumable,
		[Cpp2IlInjected.Token(Token = "0x400055F")]
		Query,
		[Cpp2IlInjected.Token(Token = "0x4000560")]
		HairDye,
		[Cpp2IlInjected.Token(Token = "0x4000561")]
		Rectober_Trick,
		[Cpp2IlInjected.Token(Token = "0x4000562")]
		PurchasableXpBoost
	}
	[Cpp2IlInjected.Token(Token = "0x2000103")]
	public enum GrantableType
	{
		[Cpp2IlInjected.Token(Token = "0x4000564")]
		GiftDrop,
		[Cpp2IlInjected.Token(Token = "0x4000565")]
		CustomAvatarItem
	}
	[Cpp2IlInjected.Token(Token = "0x2000104")]
	[Utf8JsonSerializable]
	public class GrantableId : IEquatable<GrantableId>
	{
		[Cpp2IlInjected.Token(Token = "0x17000320")]
		public GrantableType Type
		{
			[Cpp2IlInjected.Token(Token = "0x6000706")]
			[Cpp2IlInjected.Address(RVA = "0xD0F110", Offset = "0xD0DB10", VA = "0x180D0F110")]
			[CompilerGenerated]
			get
			{
				return default(GrantableType);
			}
			[Cpp2IlInjected.Token(Token = "0x6000707")]
			[Cpp2IlInjected.Address(RVA = "0xD12F30", Offset = "0xD11930", VA = "0x180D12F30")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000321")]
		public int? NumberId
		{
			[Cpp2IlInjected.Token(Token = "0x6000708")]
			[Cpp2IlInjected.Address(RVA = "0x141BB20", Offset = "0x141A520", VA = "0x18141BB20")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000709")]
			[Cpp2IlInjected.Address(RVA = "0x141E140", Offset = "0x141CB40", VA = "0x18141E140")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000322")]
		public Guid? Guid
		{
			[Cpp2IlInjected.Token(Token = "0x600070A")]
			[Cpp2IlInjected.Address(RVA = "0xD1E8E0", Offset = "0xD1D2E0", VA = "0x180D1E8E0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600070B")]
			[Cpp2IlInjected.Address(RVA = "0xD1E800", Offset = "0xD1D200", VA = "0x180D1E800")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600070C")]
		[Cpp2IlInjected.Address(RVA = "0x8DC0E80", Offset = "0x8DBF880", VA = "0x188DC0E80")]
		public static GrantableId PWMWZNBFEVA(int a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600070D")]
		[Cpp2IlInjected.Address(RVA = "0x8DC0DC0", Offset = "0x8DBF7C0", VA = "0x188DC0DC0")]
		public static GrantableId NWTXKAQOQRS(Guid a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600070E")]
		[Cpp2IlInjected.Address(RVA = "0x8DC0C30", Offset = "0x8DBF630", VA = "0x188DC0C30", Slot = "4")]
		public bool Equals(GrantableId? other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600070F")]
		[Cpp2IlInjected.Address(RVA = "0x8DC0A80", Offset = "0x8DBF480", VA = "0x188DC0A80", Slot = "0")]
		public override bool Equals(object? obj)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000710")]
		[Cpp2IlInjected.Address(RVA = "0x8DC0D20", Offset = "0x8DBF720", VA = "0x188DC0D20", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[SpecialName]
		[Cpp2IlInjected.Token(Token = "0x6000711")]
		[Cpp2IlInjected.Address(RVA = "0x15B3480", Offset = "0x15B1E80", VA = "0x1815B3480")]
		public static bool ITVTPRNZGNV(GrantableId? a, GrantableId? b)
		{
			return default(bool);
		}

		[SpecialName]
		[Cpp2IlInjected.Token(Token = "0x6000712")]
		[Cpp2IlInjected.Address(RVA = "0x15B2EF0", Offset = "0x15B18F0", VA = "0x1815B2EF0")]
		public static bool CYAUITUETAA(GrantableId? a, GrantableId? b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000713")]
		[Cpp2IlInjected.Address(RVA = "0xD16C40", Offset = "0xD15640", VA = "0x180D16C40")]
		public GrantableId()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000105")]
	public interface AXIUZBXADAA
	{
		[Cpp2IlInjected.Token(Token = "0x17000323")]
		Guid CustomAvatarItemId
		{
			[Cpp2IlInjected.Token(Token = "0x6000714")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000324")]
		ItemPurchaseMethodId? PurchaseMethodId
		{
			[Cpp2IlInjected.Token(Token = "0x6000715")]
			[Cpp2IlInjected.Address(Slot = "1")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000325")]
		List<PurchasablePrice>? Prices
		{
			[Cpp2IlInjected.Token(Token = "0x6000716")]
			[Cpp2IlInjected.Address(Slot = "2")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000326")]
		DateTime? NewUntil
		{
			[Cpp2IlInjected.Token(Token = "0x6000717")]
			[Cpp2IlInjected.Address(Slot = "3")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000327")]
		DateTime? AvailableAt
		{
			[Cpp2IlInjected.Token(Token = "0x6000718")]
			[Cpp2IlInjected.Address(Slot = "4")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000328")]
		DateTime? AvailableUntil
		{
			[Cpp2IlInjected.Token(Token = "0x6000719")]
			[Cpp2IlInjected.Address(Slot = "5")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000329")]
		bool CanBeGifted
		{
			[Cpp2IlInjected.Token(Token = "0x600071A")]
			[Cpp2IlInjected.Address(Slot = "6")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x1700032A")]
		bool SubscribersOnly
		{
			[Cpp2IlInjected.Token(Token = "0x600071B")]
			[Cpp2IlInjected.Address(Slot = "7")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x1700032B")]
		bool IsFeatured
		{
			[Cpp2IlInjected.Token(Token = "0x600071C")]
			[Cpp2IlInjected.Address(Slot = "8")]
			get;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000106")]
	public interface BDTMNDSILEG
	{
		[Cpp2IlInjected.Token(Token = "0x1400000A")]
		event Action VXIZVHVNRFY;

		[Cpp2IlInjected.Token(Token = "0x600071F")]
		[Cpp2IlInjected.Address(Slot = "2")]
		Task QUFCXUXVHJD(CancellationToken a);

		[Cpp2IlInjected.Token(Token = "0x6000720")]
		[Cpp2IlInjected.Address(Slot = "3")]
		Task NSAVOGCXPYX(CancellationToken a);

		[Cpp2IlInjected.Token(Token = "0x6000721")]
		[Cpp2IlInjected.Address(Slot = "4")]
		bool DFQMCNQKEVO([Out] IYTLISDVNEG a);
	}
	[Cpp2IlInjected.Token(Token = "0x2000107")]
	public interface IYTLISDVNEG
	{
		[Cpp2IlInjected.Token(Token = "0x1700032C")]
		string BXYXBSARFYI
		{
			[Cpp2IlInjected.Token(Token = "0x6000722")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x1700032D")]
		string WUGHUDZFHEF
		{
			[Cpp2IlInjected.Token(Token = "0x6000723")]
			[Cpp2IlInjected.Address(Slot = "1")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x1700032E")]
		IReadOnlyDictionary<BenefitListType, IReadOnlyList<MOCDGFTFWRF>> FJFGNXXVWHJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000724")]
			[Cpp2IlInjected.Address(Slot = "2")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x1700032F")]
		IReadOnlyDictionary<string, string> OIYZKQXIOHV
		{
			[Cpp2IlInjected.Token(Token = "0x6000725")]
			[Cpp2IlInjected.Address(Slot = "3")]
			get;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000108")]
	public interface MOCDGFTFWRF
	{
		[Cpp2IlInjected.Token(Token = "0x17000330")]
		string TitleText
		{
			[Cpp2IlInjected.Token(Token = "0x6000726")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000331")]
		string ShortText
		{
			[Cpp2IlInjected.Token(Token = "0x6000727")]
			[Cpp2IlInjected.Address(Slot = "1")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000332")]
		string DetailedText
		{
			[Cpp2IlInjected.Token(Token = "0x6000728")]
			[Cpp2IlInjected.Address(Slot = "2")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000333")]
		string CustomSpriteName
		{
			[Cpp2IlInjected.Token(Token = "0x6000729")]
			[Cpp2IlInjected.Address(Slot = "3")]
			get;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000109")]
	public interface MGOMCQBUHGC
	{
		[Cpp2IlInjected.Token(Token = "0x17000334")]
		UnifiedItemType ItemType
		{
			[Cpp2IlInjected.Token(Token = "0x600072A")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000335")]
		string Id
		{
			[Cpp2IlInjected.Token(Token = "0x600072B")]
			[Cpp2IlInjected.Address(Slot = "1")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000336")]
		string FriendlyName
		{
			[Cpp2IlInjected.Token(Token = "0x600072C")]
			[Cpp2IlInjected.Address(Slot = "2")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000337")]
		string ThumbnailImageFilename
		{
			[Cpp2IlInjected.Token(Token = "0x600072D")]
			[Cpp2IlInjected.Address(Slot = "3")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000338")]
		bool IsFeatured
		{
			[Cpp2IlInjected.Token(Token = "0x600072E")]
			[Cpp2IlInjected.Address(Slot = "4")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000339")]
		bool SubscribersOnly
		{
			[Cpp2IlInjected.Token(Token = "0x600072F")]
			[Cpp2IlInjected.Address(Slot = "5")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x1700033A")]
		GiftRarity Rarity
		{
			[Cpp2IlInjected.Token(Token = "0x6000730")]
			[Cpp2IlInjected.Address(Slot = "6")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x1700033B")]
		string ConsumableItemDesc
		{
			[Cpp2IlInjected.Token(Token = "0x6000731")]
			[Cpp2IlInjected.Address(Slot = "7")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x1700033C")]
		AvatarItemType? AvatarItemType
		{
			[Cpp2IlInjected.Token(Token = "0x6000732")]
			[Cpp2IlInjected.Address(Slot = "8")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x1700033D")]
		GiftBoxContents GiftBoxContent
		{
			[Cpp2IlInjected.Token(Token = "0x6000733")]
			[Cpp2IlInjected.Address(Slot = "9")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x1700033E")]
		bool IsQueryGiftDrop
		{
			[Cpp2IlInjected.Token(Token = "0x6000734")]
			[Cpp2IlInjected.Address(Slot = "10")]
			get;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200010A")]
	[Utf8JsonSerializable]
	public class ItemPurchaseMethodId : IEquatable<ItemPurchaseMethodId>
	{
		[Cpp2IlInjected.Token(Token = "0x1700033F")]
		public UnifiedItemType Type
		{
			[Cpp2IlInjected.Token(Token = "0x6000735")]
			[Cpp2IlInjected.Address(RVA = "0xD0F110", Offset = "0xD0DB10", VA = "0x180D0F110")]
			[CompilerGenerated]
			get
			{
				return default(UnifiedItemType);
			}
			[Cpp2IlInjected.Token(Token = "0x6000736")]
			[Cpp2IlInjected.Address(RVA = "0xD12F30", Offset = "0xD11930", VA = "0x180D12F30")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000340")]
		public int? NumberId
		{
			[Cpp2IlInjected.Token(Token = "0x6000737")]
			[Cpp2IlInjected.Address(RVA = "0x141BB20", Offset = "0x141A520", VA = "0x18141BB20")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000738")]
			[Cpp2IlInjected.Address(RVA = "0x141E140", Offset = "0x141CB40", VA = "0x18141E140")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000341")]
		public Guid? Guid
		{
			[Cpp2IlInjected.Token(Token = "0x6000739")]
			[Cpp2IlInjected.Address(RVA = "0xD1E8E0", Offset = "0xD1D2E0", VA = "0x180D1E8E0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600073A")]
			[Cpp2IlInjected.Address(RVA = "0xD1E800", Offset = "0xD1D200", VA = "0x180D1E800")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600073B")]
		[Cpp2IlInjected.Address(RVA = "0x8DC1F70", Offset = "0x8DC0970", VA = "0x188DC1F70")]
		public static ItemPurchaseMethodId DWBZFLPLGHG(int a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600073C")]
		[Cpp2IlInjected.Address(RVA = "0x8DC2350", Offset = "0x8DC0D50", VA = "0x188DC2350")]
		public static ItemPurchaseMethodId NWTXKAQOQRS(Guid a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600073D")]
		[Cpp2IlInjected.Address(RVA = "0x8DC1D70", Offset = "0x8DC0770", VA = "0x188DC1D70")]
		public static ItemPurchaseMethodId BGTSUWKLICT(UnifiedItemId a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600073E")]
		[Cpp2IlInjected.Address(RVA = "0x8DC21C0", Offset = "0x8DC0BC0", VA = "0x188DC21C0", Slot = "4")]
		public bool Equals(ItemPurchaseMethodId? other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600073F")]
		[Cpp2IlInjected.Address(RVA = "0x8DC2010", Offset = "0x8DC0A10", VA = "0x188DC2010", Slot = "0")]
		public override bool Equals(object? obj)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000740")]
		[Cpp2IlInjected.Address(RVA = "0x8DC22B0", Offset = "0x8DC0CB0", VA = "0x188DC22B0", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[SpecialName]
		[Cpp2IlInjected.Token(Token = "0x6000741")]
		[Cpp2IlInjected.Address(RVA = "0x15B3480", Offset = "0x15B1E80", VA = "0x1815B3480")]
		public static bool ITVTPRNZGNV(ItemPurchaseMethodId? a, ItemPurchaseMethodId? b)
		{
			return default(bool);
		}

		[SpecialName]
		[Cpp2IlInjected.Token(Token = "0x6000742")]
		[Cpp2IlInjected.Address(RVA = "0x15B2EF0", Offset = "0x15B18F0", VA = "0x1815B2EF0")]
		public static bool CYAUITUETAA(ItemPurchaseMethodId? a, ItemPurchaseMethodId? b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000743")]
		[Cpp2IlInjected.Address(RVA = "0xD16C40", Offset = "0xD15640", VA = "0x180D16C40")]
		public ItemPurchaseMethodId()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200010B")]
	public enum UnifiedItemType
	{
		[Cpp2IlInjected.Token(Token = "0x400056D")]
		PurchasableItem,
		[Cpp2IlInjected.Token(Token = "0x400056E")]
		CustomAvatarItem
	}
	[Cpp2IlInjected.Token(Token = "0x200010C")]
	[Utf8JsonSerializable]
	public class PurchasablePrice
	{
		[Cpp2IlInjected.Token(Token = "0x17000342")]
		public CurrencyType CurrencyType
		{
			[Cpp2IlInjected.Token(Token = "0x6000744")]
			[Cpp2IlInjected.Address(RVA = "0xD0F110", Offset = "0xD0DB10", VA = "0x180D0F110")]
			[CompilerGenerated]
			get
			{
				return default(CurrencyType);
			}
			[Cpp2IlInjected.Token(Token = "0x6000745")]
			[Cpp2IlInjected.Address(RVA = "0xD12F30", Offset = "0xD11930", VA = "0x180D12F30")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000343")]
		public int Price
		{
			[Cpp2IlInjected.Token(Token = "0x6000746")]
			[Cpp2IlInjected.Address(RVA = "0xE073A0", Offset = "0xE05DA0", VA = "0x180E073A0")]
			[CompilerGenerated]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x6000747")]
			[Cpp2IlInjected.Address(RVA = "0xE073B0", Offset = "0xE05DB0", VA = "0x180E073B0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000344")]
		public StorefrontSaleData StorefrontSaleData
		{
			[Cpp2IlInjected.Token(Token = "0x6000748")]
			[Cpp2IlInjected.Address(RVA = "0xD11B30", Offset = "0xD10530", VA = "0x180D11B30")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000749")]
			[Cpp2IlInjected.Address(RVA = "0xD12270", Offset = "0xD10C70", VA = "0x180D12270")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600074A")]
		[Cpp2IlInjected.Address(RVA = "0x8DC3EF0", Offset = "0x8DC28F0", VA = "0x188DC3EF0")]
		public int RDBXUSHAVHG(DateTime a)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600074B")]
		[Cpp2IlInjected.Address(RVA = "0xD16C40", Offset = "0xD15640", VA = "0x180D16C40")]
		public PurchasablePrice()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200010D")]
	[Utf8JsonSerializable]
	public class StorefrontSaleData
	{
		[Cpp2IlInjected.Token(Token = "0x17000345")]
		public int SalePercent
		{
			[Cpp2IlInjected.Token(Token = "0x600074C")]
			[Cpp2IlInjected.Address(RVA = "0xD0F110", Offset = "0xD0DB10", VA = "0x180D0F110")]
			[CompilerGenerated]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x600074D")]
			[Cpp2IlInjected.Address(RVA = "0xD12F30", Offset = "0xD11930", VA = "0x180D12F30")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000346")]
		public DateTime? SaleStartDate
		{
			[Cpp2IlInjected.Token(Token = "0x600074E")]
			[Cpp2IlInjected.Address(RVA = "0xDA5E80", Offset = "0xDA4880", VA = "0x180DA5E80")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600074F")]
			[Cpp2IlInjected.Address(RVA = "0xF82330", Offset = "0xF80D30", VA = "0x180F82330")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000347")]
		public DateTime? SaleEndDate
		{
			[Cpp2IlInjected.Token(Token = "0x6000750")]
			[Cpp2IlInjected.Address(RVA = "0x104E620", Offset = "0x104D020", VA = "0x18104E620")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000751")]
			[Cpp2IlInjected.Address(RVA = "0x104DCA0", Offset = "0x104C6A0", VA = "0x18104DCA0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000752")]
		[Cpp2IlInjected.Address(RVA = "0x8DC5FE0", Offset = "0x8DC49E0", VA = "0x188DC5FE0")]
		public bool BBEWKKVNJEX(DateTime a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000753")]
		[Cpp2IlInjected.Address(RVA = "0x8DC61C0", Offset = "0x8DC4BC0", VA = "0x188DC61C0")]
		public int YBPZPDXJKLJ(DateTime a)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000754")]
		[Cpp2IlInjected.Address(RVA = "0x8DC60D0", Offset = "0x8DC4AD0", VA = "0x188DC60D0")]
		public TimeSpan? ODOTIXYVXXJ(DateTime a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000755")]
		[Cpp2IlInjected.Address(RVA = "0xD16C40", Offset = "0xD15640", VA = "0x180D16C40")]
		public StorefrontSaleData()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200010E")]
	public enum StorefrontTypes
	{
		[Cpp2IlInjected.Token(Token = "0x4000576")]
		None = 0,
		[Cpp2IlInjected.Token(Token = "0x4000577")]
		LaserTag = 1,
		[Cpp2IlInjected.Token(Token = "0x4000578")]
		RecCenter = 2,
		[Cpp2IlInjected.Token(Token = "0x4000579")]
		Watch = 3,
		[Cpp2IlInjected.Token(Token = "0x400057A")]
		Quest_LostSkulls = 100,
		[Cpp2IlInjected.Token(Token = "0x400057B")]
		Quest_Dracula = 101,
		[Cpp2IlInjected.Token(Token = "0x400057C")]
		Quest_GoldenTrophy = 102,
		[Cpp2IlInjected.Token(Token = "0x400057D")]
		Quest_CrimsonCauldron = 103,
		[Cpp2IlInjected.Token(Token = "0x400057E")]
		RecRoyale = 200,
		[Cpp2IlInjected.Token(Token = "0x400057F")]
		Cafe = 300,
		[Cpp2IlInjected.Token(Token = "0x4000580")]
		Paintball = 400,
		[Cpp2IlInjected.Token(Token = "0x4000581")]
		Paintball_River = 401,
		[Cpp2IlInjected.Token(Token = "0x4000582")]
		Paintball_Homestead = 402,
		[Cpp2IlInjected.Token(Token = "0x4000583")]
		Paintball_Quarry = 403,
		[Cpp2IlInjected.Token(Token = "0x4000584")]
		Paintball_ClearCut = 404,
		[Cpp2IlInjected.Token(Token = "0x4000585")]
		Paintball_Spillway = 405,
		[Cpp2IlInjected.Token(Token = "0x4000586")]
		Paintball_SunsetDriveIn = 406,
		[Cpp2IlInjected.Token(Token = "0x4000587")]
		Paintball_MerryMidway = 407,
		[Cpp2IlInjected.Token(Token = "0x4000588")]
		Paintball_Lobby_1 = 450,
		[Cpp2IlInjected.Token(Token = "0x4000589")]
		Paintball_Lobby_2 = 451,
		[Cpp2IlInjected.Token(Token = "0x400058A")]
		Paintball_Lobby_3 = 452,
		[Cpp2IlInjected.Token(Token = "0x400058B")]
		Paintball_Lobby_4 = 453,
		[Cpp2IlInjected.Token(Token = "0x400058C")]
		Paintball_Lobby_5 = 454,
		[Cpp2IlInjected.Token(Token = "0x400058D")]
		Paintball_Lobby_6 = 455,
		[Cpp2IlInjected.Token(Token = "0x400058E")]
		Paintball_Lobby_7 = 456,
		[Cpp2IlInjected.Token(Token = "0x400058F")]
		Paintball_Lobby_8 = 457,
		[Cpp2IlInjected.Token(Token = "0x4000590")]
		Paintball_Lobby_9 = 458,
		[Cpp2IlInjected.Token(Token = "0x4000591")]
		Paintball_Lobby_10 = 459,
		[Cpp2IlInjected.Token(Token = "0x4000592")]
		Paintball_Lobby_11 = 460,
		[Cpp2IlInjected.Token(Token = "0x4000593")]
		Paintball_Lobby_12 = 461,
		[Cpp2IlInjected.Token(Token = "0x4000594")]
		Paintball_Lobby_13 = 462,
		[Cpp2IlInjected.Token(Token = "0x4000595")]
		Paintball_Lobby_14 = 463,
		[Cpp2IlInjected.Token(Token = "0x4000596")]
		Paintball_Lobby_15 = 464,
		[Cpp2IlInjected.Token(Token = "0x4000597")]
		Bowling = 500,
		[Cpp2IlInjected.Token(Token = "0x4000598")]
		StuntRunner = 600,
		[Cpp2IlInjected.Token(Token = "0x4000599")]
		DormMirror = 700,
		[Cpp2IlInjected.Token(Token = "0x400059A")]
		InventionStore = 800,
		[Cpp2IlInjected.Token(Token = "0x400059B")]
		RoomKeys = 900,
		[Cpp2IlInjected.Token(Token = "0x400059C")]
		Player_Profile = 1000,
		[Cpp2IlInjected.Token(Token = "0x400059D")]
		Room_Save = 1100,
		[Cpp2IlInjected.Token(Token = "0x400059E")]
		RoomCurrencies = 1200,
		[Cpp2IlInjected.Token(Token = "0x400059F")]
		Wishlist = 1300,
		[Cpp2IlInjected.Token(Token = "0x40005A0")]
		Friendotron = 1400,
		[Cpp2IlInjected.Token(Token = "0x40005A1")]
		RoomConsumables = 1500,
		[Cpp2IlInjected.Token(Token = "0x40005A2")]
		RecRally = 1600,
		[Cpp2IlInjected.Token(Token = "0x40005A3")]
		PopUpShop_1 = 1700,
		[Cpp2IlInjected.Token(Token = "0x40005A4")]
		PopUpShop_2 = 1701,
		[Cpp2IlInjected.Token(Token = "0x40005A5")]
		PopUpShop_3 = 1702,
		[Cpp2IlInjected.Token(Token = "0x40005A6")]
		PopUpShop_4 = 1703,
		[Cpp2IlInjected.Token(Token = "0x40005A7")]
		PopUpShop_5 = 1704,
		[Cpp2IlInjected.Token(Token = "0x40005A8")]
		PopUpShop_6 = 1705,
		[Cpp2IlInjected.Token(Token = "0x40005A9")]
		PopUpShop_7 = 1706,
		[Cpp2IlInjected.Token(Token = "0x40005AA")]
		PopUpShop_8 = 1707,
		[Cpp2IlInjected.Token(Token = "0x40005AB")]
		PopUpShop_9 = 1708,
		[Cpp2IlInjected.Token(Token = "0x40005AC")]
		PopUpShop_10 = 1709,
		[Cpp2IlInjected.Token(Token = "0x40005AD")]
		PopUpShop_11 = 1710,
		[Cpp2IlInjected.Token(Token = "0x40005AE")]
		PopUpShop_12 = 1711,
		[Cpp2IlInjected.Token(Token = "0x40005AF")]
		PopUpShop_13 = 1712,
		[Cpp2IlInjected.Token(Token = "0x40005B0")]
		PopUpShop_14 = 1713,
		[Cpp2IlInjected.Token(Token = "0x40005B1")]
		PopUpShop_15 = 1714,
		[Cpp2IlInjected.Token(Token = "0x40005B2")]
		PopUpShop_16 = 1715,
		[Cpp2IlInjected.Token(Token = "0x40005B3")]
		PopUpShop_17 = 1716,
		[Cpp2IlInjected.Token(Token = "0x40005B4")]
		PopUpShop_18 = 1717,
		[Cpp2IlInjected.Token(Token = "0x40005B5")]
		PopUpShop_19 = 1718,
		[Cpp2IlInjected.Token(Token = "0x40005B6")]
		PopUpShop_20 = 1719,
		[Cpp2IlInjected.Token(Token = "0x40005B7")]
		CustomAvatarItems = 1800,
		[Cpp2IlInjected.Token(Token = "0x40005B8")]
		ProgressionEventPurchasableXpBoosts = 1900,
		[Cpp2IlInjected.Token(Token = "0x40005B9")]
		PopUpShop_ProgressionEvent_1 = 2000,
		[Cpp2IlInjected.Token(Token = "0x40005BA")]
		PopUpShop_ProgressionEvent_2 = 2001,
		[Cpp2IlInjected.Token(Token = "0x40005BB")]
		PopUpShop_ProgressionEvent_3 = 2002,
		[Cpp2IlInjected.Token(Token = "0x40005BC")]
		PopUpShop_ProgressionEvent_4 = 2003,
		[Cpp2IlInjected.Token(Token = "0x40005BD")]
		PopUpShop_ProgressionEvent_5 = 2004,
		[Cpp2IlInjected.Token(Token = "0x40005BE")]
		RoomOffers = 2100,
		[Cpp2IlInjected.Token(Token = "0x40005BF")]
		MyLittleMonsters = 2200,
		[Cpp2IlInjected.Token(Token = "0x40005C0")]
		Destiny = 2201,
		[Cpp2IlInjected.Token(Token = "0x40005C1")]
		RunTheBlock = 2202,
		[Cpp2IlInjected.Token(Token = "0x40005C2")]
		RROStorefront_ToBeNamed_2 = 2203,
		[Cpp2IlInjected.Token(Token = "0x40005C3")]
		Park = 2204,
		[Cpp2IlInjected.Token(Token = "0x40005C4")]
		Dodgeball = 2205,
		[Cpp2IlInjected.Token(Token = "0x40005C5")]
		DevStorefront_DoNotAddToWatch_1 = 2300,
		[Cpp2IlInjected.Token(Token = "0x40005C6")]
		DevStorefront_DoNotAddToWatch_2 = 2301,
		[Cpp2IlInjected.Token(Token = "0x40005C7")]
		DevStorefront_DoNotAddToWatch_3 = 2302,
		[Cpp2IlInjected.Token(Token = "0x40005C8")]
		DevStorefront_DoNotAddToWatch_4 = 2303,
		[Cpp2IlInjected.Token(Token = "0x40005C9")]
		DevStorefront_DoNotAddToWatch_5 = 2304,
		[Cpp2IlInjected.Token(Token = "0x40005CA")]
		Roomie = 2400,
		[Cpp2IlInjected.Token(Token = "0x40005CB")]
		PurchasePromotions = 2500
	}
	[Cpp2IlInjected.Token(Token = "0x200010F")]
	public enum PurchasableItemType
	{
		[Cpp2IlInjected.Token(Token = "0x40005CD")]
		GiftDrop,
		[Cpp2IlInjected.Token(Token = "0x40005CE")]
		SeasonTier,
		[Cpp2IlInjected.Token(Token = "0x40005CF")]
		SeasonEliteUpgrade
	}
	[Cpp2IlInjected.Token(Token = "0x2000110")]
	public enum StorefrontBalanceAddTypes
	{
		[Cpp2IlInjected.Token(Token = "0x40005D1")]
		Invalid = 0,
		[Cpp2IlInjected.Token(Token = "0x40005D2")]
		DirectBalanceWithMultiplier = 1,
		[Cpp2IlInjected.Token(Token = "0x40005D3")]
		FromGiftBox = 2,
		[Cpp2IlInjected.Token(Token = "0x40005D4")]
		NUXChallenge = 10,
		[Cpp2IlInjected.Token(Token = "0x40005D5")]
		AllNUXChallenges = 11,
		[Cpp2IlInjected.Token(Token = "0x40005D6")]
		DailyChallenge = 100,
		[Cpp2IlInjected.Token(Token = "0x40005D7")]
		AllDailyChallenges = 101,
		[Cpp2IlInjected.Token(Token = "0x40005D8")]
		FinishActivity = 200,
		[Cpp2IlInjected.Token(Token = "0x40005D9")]
		RecRoyaleMatchFinished = 250,
		[Cpp2IlInjected.Token(Token = "0x40005DA")]
		ChecklistCredit = 303,
		[Cpp2IlInjected.Token(Token = "0x40005DB")]
		WonGame = 1000,
		[Cpp2IlInjected.Token(Token = "0x40005DC")]
		LostGame = 1001,
		[Cpp2IlInjected.Token(Token = "0x40005DD")]
		WonGameRateLimited = 1002,
		[Cpp2IlInjected.Token(Token = "0x40005DE")]
		WonGamePartial = 1003,
		[Cpp2IlInjected.Token(Token = "0x40005DF")]
		LevelUp = 1100,
		[Cpp2IlInjected.Token(Token = "0x40005E0")]
		Registered = 1200,
		[Cpp2IlInjected.Token(Token = "0x40005E1")]
		CreatorReward = 1300,
		[Cpp2IlInjected.Token(Token = "0x40005E2")]
		CommercePurchase = 1400,
		[Cpp2IlInjected.Token(Token = "0x40005E3")]
		CommercePurchaseRevoked = 1401,
		[Cpp2IlInjected.Token(Token = "0x40005E4")]
		Manual_Refund = 2000,
		[Cpp2IlInjected.Token(Token = "0x40005E5")]
		Manual_Thanks = 2010,
		[Cpp2IlInjected.Token(Token = "0x40005E6")]
		Manual_Apology = 2020,
		[Cpp2IlInjected.Token(Token = "0x40005E7")]
		TestOnly = 8000
	}
	[Cpp2IlInjected.Token(Token = "0x2000111")]
	public enum RateLimitTypes
	{
		[Cpp2IlInjected.Token(Token = "0x40005E9")]
		Interval,
		[Cpp2IlInjected.Token(Token = "0x40005EA")]
		PerDay
	}
	[Cpp2IlInjected.Token(Token = "0x2000112")]
	public enum Discount
	{
		[Cpp2IlInjected.Token(Token = "0x40005EC")]
		PERCENTAGE = 1,
		[Cpp2IlInjected.Token(Token = "0x40005ED")]
		EXACT_AMOUNT
	}
	[Cpp2IlInjected.Token(Token = "0x2000113")]
	[Utf8JsonSerializable]
	public class SkuPurchaseMetadata : IEquatable<SkuPurchaseMetadata>
	{
		[Cpp2IlInjected.Token(Token = "0x17000348")]
		public int? PurchaseReminderId
		{
			[Cpp2IlInjected.Token(Token = "0x6000756")]
			[Cpp2IlInjected.Address(RVA = "0xD117B0", Offset = "0xD101B0", VA = "0x180D117B0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000757")]
			[Cpp2IlInjected.Address(RVA = "0xED90B0", Offset = "0xED7AB0", VA = "0x180ED90B0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000349")]
		public int? PurchaseCampaignId
		{
			[Cpp2IlInjected.Token(Token = "0x6000758")]
			[Cpp2IlInjected.Address(RVA = "0xD11B30", Offset = "0xD10530", VA = "0x180D11B30")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000759")]
			[Cpp2IlInjected.Address(RVA = "0xE07390", Offset = "0xE05D90", VA = "0x180E07390")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700034A")]
		public int? RRPlusSignUpBonusId
		{
			[Cpp2IlInjected.Token(Token = "0x600075A")]
			[Cpp2IlInjected.Address(RVA = "0xD12BC0", Offset = "0xD115C0", VA = "0x180D12BC0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600075B")]
			[Cpp2IlInjected.Address(RVA = "0xE3F130", Offset = "0xE3DB30", VA = "0x180E3F130")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700034B")]
		public List<ItemPurchaseMethodId>? BonusPurchasableItemIds
		{
			[Cpp2IlInjected.Token(Token = "0x600075C")]
			[Cpp2IlInjected.Address(RVA = "0xD11B00", Offset = "0xD10500", VA = "0x180D11B00")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600075D")]
			[Cpp2IlInjected.Address(RVA = "0xD11530", Offset = "0xD0FF30", VA = "0x180D11530")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700034C")]
		public List<GrantableId>? BonusSelectableGrantableIds
		{
			[Cpp2IlInjected.Token(Token = "0x600075E")]
			[Cpp2IlInjected.Address(RVA = "0xD11A20", Offset = "0xD10420", VA = "0x180D11A20")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600075F")]
			[Cpp2IlInjected.Address(RVA = "0xD17350", Offset = "0xD15D50", VA = "0x180D17350")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700034D")]
		public int? GiftRecipientAccountId
		{
			[Cpp2IlInjected.Token(Token = "0x6000760")]
			[Cpp2IlInjected.Address(RVA = "0xD12280", Offset = "0xD10C80", VA = "0x180D12280")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000761")]
			[Cpp2IlInjected.Address(RVA = "0xD1B6D0", Offset = "0xD1A0D0", VA = "0x180D1B6D0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700034E")]
		public string? GiftRecipientMessage
		{
			[Cpp2IlInjected.Token(Token = "0x6000762")]
			[Cpp2IlInjected.Address(RVA = "0xD11A30", Offset = "0xD10430", VA = "0x180D11A30")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000763")]
			[Cpp2IlInjected.Address(RVA = "0xD12260", Offset = "0xD10C60", VA = "0x180D12260")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000764")]
		[Cpp2IlInjected.Address(RVA = "0x8DC5D60", Offset = "0x8DC4760", VA = "0x188DC5D60", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000765")]
		[Cpp2IlInjected.Address(RVA = "0x8DC5700", Offset = "0x8DC4100", VA = "0x188DC5700")]
		public static SkuPurchaseMetadata BGVSOTAFYFI(int? a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000766")]
		[Cpp2IlInjected.Address(RVA = "0x8DC5760", Offset = "0x8DC4160", VA = "0x188DC5760", Slot = "4")]
		public bool Equals(SkuPurchaseMetadata? other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000767")]
		[Cpp2IlInjected.Address(RVA = "0x8DC5CC0", Offset = "0x8DC46C0", VA = "0x188DC5CC0")]
		private static bool LPKCLLHXZNU(List<ItemPurchaseMethodId>? a, List<ItemPurchaseMethodId>? b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000768")]
		[Cpp2IlInjected.Address(RVA = "0x8DC5920", Offset = "0x8DC4320", VA = "0x188DC5920", Slot = "0")]
		public override bool Equals(object? obj)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000769")]
		[Cpp2IlInjected.Address(RVA = "0x8DC5A20", Offset = "0x8DC4420", VA = "0x188DC5A20", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600076A")]
		[Cpp2IlInjected.Address(RVA = "0xD16C40", Offset = "0xD15640", VA = "0x180D16C40")]
		public SkuPurchaseMetadata()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000114")]
	public struct UnifiedItemId : IEquatable<UnifiedItemId>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40005F5")]
		public readonly UnifiedItemType ItemType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x40005F6")]
		private readonly int NumberId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40005F7")]
		private readonly Guid Guid;

		[Cpp2IlInjected.Token(Token = "0x1700034F")]
		public Guid WYGDWNQONQF
		{
			[Cpp2IlInjected.Token(Token = "0x600076B")]
			[Cpp2IlInjected.Address(RVA = "0x8DC9B00", Offset = "0x8DC8500", VA = "0x188DC9B00")]
			get
			{
				return default(Guid);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000350")]
		public int NNRKOEYSTIN
		{
			[Cpp2IlInjected.Token(Token = "0x600076C")]
			[Cpp2IlInjected.Address(RVA = "0x8DC98F0", Offset = "0x8DC82F0", VA = "0x188DC98F0")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000351")]
		public string KESJCXDQYIP
		{
			[Cpp2IlInjected.Token(Token = "0x600076D")]
			[Cpp2IlInjected.Address(RVA = "0x8DC9B70", Offset = "0x8DC8570", VA = "0x188DC9B70")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600076E")]
		[Cpp2IlInjected.Address(RVA = "0x8DC9CA0", Offset = "0x8DC86A0", VA = "0x188DC9CA0")]
		public static bool PPXSQRKLNWN(string a, [Out] UnifiedItemId b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600076F")]
		[Cpp2IlInjected.Address(RVA = "0x8DC9630", Offset = "0x8DC8030", VA = "0x188DC9630")]
		public static bool DFPJZOUFQTC(string a, [Out] UnifiedItemId b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000770")]
		[Cpp2IlInjected.Address(RVA = "0x8DC9500", Offset = "0x8DC7F00", VA = "0x188DC9500")]
		public static UnifiedItemId AQWCBOBMEHL(int a)
		{
			return default(UnifiedItemId);
		}

		[Cpp2IlInjected.Token(Token = "0x6000771")]
		[Cpp2IlInjected.Address(RVA = "0x8DC93D0", Offset = "0x8DC7DD0", VA = "0x188DC93D0")]
		public static UnifiedItemId AQWCBOBMEHL(PurchasableItemId a)
		{
			return default(UnifiedItemId);
		}

		[Cpp2IlInjected.Token(Token = "0x6000772")]
		[Cpp2IlInjected.Address(RVA = "0x8DCA0A0", Offset = "0x8DC8AA0", VA = "0x188DCA0A0")]
		public static UnifiedItemId TVZIJWQVFZL(Guid a)
		{
			return default(UnifiedItemId);
		}

		[Cpp2IlInjected.Token(Token = "0x6000773")]
		[Cpp2IlInjected.Address(RVA = "0x8DC9BB0", Offset = "0x8DC85B0", VA = "0x188DC9BB0")]
		private static bool JNLDHKPLWYW(string a, [Out] UnifiedItemType b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000774")]
		[Cpp2IlInjected.Address(RVA = "0x8DCA270", Offset = "0x8DC8C70", VA = "0x188DCA270")]
		private UnifiedItemId(UnifiedItemType itemType, int? purchasableGiftDropId, Guid? customAvatarItemId)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000775")]
		[Cpp2IlInjected.Address(RVA = "0x8DC9900", Offset = "0x8DC8300", VA = "0x188DC9900", Slot = "4")]
		public bool Equals(UnifiedItemId other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000776")]
		[Cpp2IlInjected.Address(RVA = "0x8DC9970", Offset = "0x8DC8370", VA = "0x188DC9970", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000777")]
		[Cpp2IlInjected.Address(RVA = "0x8DC9A70", Offset = "0x8DC8470", VA = "0x188DC9A70", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000778")]
		[Cpp2IlInjected.Address(RVA = "0x8DCA1E0", Offset = "0x8DC8BE0", VA = "0x188DCA1E0", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000115")]
	public interface MRRSWVQROBM
	{
		[Cpp2IlInjected.Token(Token = "0x6000779")]
		[Cpp2IlInjected.Address(Slot = "0")]
		Task EKLQINTPVAK(float a, [Optional] CancellationToken b);
	}
	[Cpp2IlInjected.Token(Token = "0x2000116")]
	public interface BRJDRJIFRYO
	{
		[Cpp2IlInjected.Token(Token = "0x600077A")]
		[Cpp2IlInjected.Address(Slot = "0")]
		Task LNMSQRVPEAK(int a, string b, [Optional] CancellationToken c);
	}
	[Cpp2IlInjected.Token(Token = "0x2000117")]
	public interface YKVTWSKYEKU
	{
		[Cpp2IlInjected.Token(Token = "0x600077B")]
		[Cpp2IlInjected.Address(Slot = "0")]
		Task<RecNetResult<RecipesEventRewardsDTO>> DOVOZKYUESK(Guid a, [Optional] CancellationToken b);

		[Cpp2IlInjected.Token(Token = "0x600077C")]
		[Cpp2IlInjected.Address(Slot = "1")]
		Task<RecipesEventRecordDTO> GLKHBYTWRWY(Guid a, [Optional] CancellationToken b);

		[Cpp2IlInjected.Token(Token = "0x600077D")]
		[Cpp2IlInjected.Address(Slot = "2")]
		Task<RecNetResult<CookRecipeResultDTO>> BuyRecipeHint(Guid eventId, [Optional] CancellationToken cancellationToken);

		[Cpp2IlInjected.Token(Token = "0x600077E")]
		[Cpp2IlInjected.Address(Slot = "3")]
		Task<RecNetResult<CookRecipeResultDTO>> CookRecipeFromIngredients(Guid eventId, Dictionary<int, int> ingredientCounts, [Optional] CancellationToken cancellationToken);

		[Cpp2IlInjected.Token(Token = "0x600077F")]
		[Cpp2IlInjected.Address(Slot = "4")]
		Task<RecNetResult<IncrementalCookRecordDTO>> VBPHBHVMHNW(Guid a, int b, Dictionary<int, int> c, [Optional] string? clientState, [Optional] CancellationToken d);

		[Cpp2IlInjected.Token(Token = "0x6000780")]
		[Cpp2IlInjected.Address(Slot = "5")]
		Task<RecNetResult<CookRecipeResultDTO>> JUMCIZRTRAK(Guid a, int b, [Optional] CancellationToken c);

		[Cpp2IlInjected.Token(Token = "0x6000781")]
		[Cpp2IlInjected.Address(Slot = "6")]
		Task<RecNetResult<RecipesEventRewardsDTO>> RZPXYWJPSOW(Guid a, string b, int c, bool d, [Optional] CancellationToken e);

		[Cpp2IlInjected.Token(Token = "0x6000782")]
		[Cpp2IlInjected.Address(Slot = "7")]
		Task<RecNetResult<SuperStageResultDTO>> FEFOQFKNKAT(Guid a, int b, int c, [Optional] CancellationToken d);

		[Cpp2IlInjected.Token(Token = "0x6000783")]
		[Cpp2IlInjected.Address(Slot = "8")]
		Task<RecNetResult<SuperStageResultDTO>> RDGJDBXDKJD(Guid a, int b, int c, [Optional] CancellationToken d);
	}
	[Cpp2IlInjected.Token(Token = "0x2000118")]
	public interface XFYEIFIYZFO
	{
		[Cpp2IlInjected.Token(Token = "0x6000784")]
		[Cpp2IlInjected.Address(Slot = "0")]
		void OBIEGUWIDOT();

		[Cpp2IlInjected.Token(Token = "0x6000785")]
		[Cpp2IlInjected.Address(Slot = "1")]
		Task<TimedCurrencyGrantDTO> MVMJDVRLQSF(long a, [Optional] CancellationToken b);

		[Cpp2IlInjected.Token(Token = "0x6000786")]
		[Cpp2IlInjected.Address(Slot = "2")]
		Task MOZGLYYCGFN([Optional] CancellationToken a);
	}
	[Cpp2IlInjected.Token(Token = "0x2000119")]
	public interface PGOSSLDHJKD
	{
		[Cpp2IlInjected.Token(Token = "0x17000352")]
		ASNKAFBFVVA<TimedRewardTrackRecordDTO> DZKUMAZHARC
		{
			[Cpp2IlInjected.Token(Token = "0x6000787")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000353")]
		ASNKAFBFVVA<TimedRewardTrackXpEarnedDTO> LNDFDVKYNPA
		{
			[Cpp2IlInjected.Token(Token = "0x6000788")]
			[Cpp2IlInjected.Address(Slot = "1")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x6000789")]
		[Cpp2IlInjected.Address(Slot = "2")]
		void OBIEGUWIDOT();

		[Cpp2IlInjected.Token(Token = "0x600078A")]
		[Cpp2IlInjected.Address(Slot = "3")]
		Task<TimedRewardTrackDTO> YJJCPLZYZNO(Guid a, [Optional] CancellationToken b);

		[Cpp2IlInjected.Token(Token = "0x600078B")]
		[Cpp2IlInjected.Address(Slot = "4")]
		Task<TimedRewardTrackRecordDTO> QWVGMUKKMOD(long a, [Optional] CancellationToken b);
	}
	[Cpp2IlInjected.Token(Token = "0x200011A")]
	public interface MGQFWHIERRR
	{
		[Cpp2IlInjected.Token(Token = "0x17000354")]
		ASNKAFBFVVA<TimedRewardTreeNodeCollectedDTO> ZOTGZOLTWML
		{
			[Cpp2IlInjected.Token(Token = "0x600078C")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000355")]
		ASNKAFBFVVA<TimedRewardTreeXpEarnedDTO> LWNOEUARGMX
		{
			[Cpp2IlInjected.Token(Token = "0x600078D")]
			[Cpp2IlInjected.Address(Slot = "1")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x600078E")]
		[Cpp2IlInjected.Address(Slot = "2")]
		void OBIEGUWIDOT();

		[Cpp2IlInjected.Token(Token = "0x600078F")]
		[Cpp2IlInjected.Address(Slot = "3")]
		Task<TimedRewardTreeDTO> HNMFMFEJRBE(long a, [Optional] CancellationToken b);

		[Cpp2IlInjected.Token(Token = "0x6000790")]
		[Cpp2IlInjected.Address(Slot = "4")]
		Task<TimedRewardTreeDTO> HNMFMFEJRBE(Guid a, [Optional] CancellationToken b);

		[Cpp2IlInjected.Token(Token = "0x6000791")]
		[Cpp2IlInjected.Address(Slot = "5")]
		Task<TimedRewardTreeRecordDTO> NFWRQQLMQLU(long a, [Optional] CancellationToken b);

		[Cpp2IlInjected.Token(Token = "0x6000792")]
		[Cpp2IlInjected.Address(Slot = "6")]
		Task<RecNetResult> FDCTIJVAGXP(long a, long b, [Optional] CancellationToken c);
	}
	[Cpp2IlInjected.Token(Token = "0x200011B")]
	public interface VKHMZVZXWFW
	{
		[Cpp2IlInjected.Token(Token = "0x6000793")]
		[Cpp2IlInjected.Address(Slot = "0")]
		Task<RecNetResult<RecipesEventChallengesDTO>> RLVIWEFGXGN(Guid a, [Optional] CancellationToken b);

		[Cpp2IlInjected.Token(Token = "0x6000794")]
		[Cpp2IlInjected.Address(Slot = "1")]
		Task<RecNetResult<CompleteChallengeResponseDTO>> CompleteChallenge(Guid eventId, int laneId, bool payToDoubleRewards, [Optional] CancellationToken cancellationToken);

		[Cpp2IlInjected.Token(Token = "0x6000795")]
		[Cpp2IlInjected.Address(Slot = "2")]
		Task<RecNetResult<RecipesEventChallengesDTO>> SwapChallenge(Guid eventId, int laneId, [Optional] CancellationToken cancellationToken);

		[Cpp2IlInjected.Token(Token = "0x6000796")]
		[Cpp2IlInjected.Address(Slot = "3")]
		Task<RecNetResult<RecipesEventChallengesDTO>> SwapChallengeReward(Guid eventId, int laneId, [Optional] CancellationToken cancellationToken);
	}
	[Cpp2IlInjected.Token(Token = "0x200011C")]
	public interface ESXSHZKHJRJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000797")]
		[Cpp2IlInjected.Address(Slot = "0")]
		void OBIEGUWIDOT();

		[Cpp2IlInjected.Token(Token = "0x6000798")]
		[Cpp2IlInjected.Address(Slot = "1")]
		Task<List<TimeLimitedEventDTO>> WOSOXYKQDCT([Optional] CancellationToken a);

		[Cpp2IlInjected.Token(Token = "0x6000799")]
		[Cpp2IlInjected.Address(Slot = "2")]
		Task<TimeLimitedEventDTO> UIETZTUYSUA(long a, [Optional] CancellationToken b);

		[Cpp2IlInjected.Token(Token = "0x600079A")]
		[Cpp2IlInjected.Address(Slot = "3")]
		Task<TimeLimitedEventDTO> UIETZTUYSUA(Guid a, [Optional] CancellationToken b);

		[Cpp2IlInjected.Token(Token = "0x600079B")]
		[Cpp2IlInjected.Address(Slot = "4")]
		Task<TimeLimitedEventTeamConfigDTO> UBEXMBTEXFN(long a, [Optional] CancellationToken b);

		[Cpp2IlInjected.Token(Token = "0x600079C")]
		[Cpp2IlInjected.Address(Slot = "5")]
		Task<List<int>> WMRTIDXCXLT(Guid a, [Optional] CancellationToken b);

		[Cpp2IlInjected.Token(Token = "0x600079D")]
		[Cpp2IlInjected.Address(Slot = "6")]
		Task<RecNetResult> IYEIDMTNAAL(Guid a, int b, [Optional] CancellationToken c);

		[Cpp2IlInjected.Token(Token = "0x600079E")]
		[Cpp2IlInjected.Address(Slot = "7")]
		Task<RecNetResult> CZAMCORCASZ(Guid a, int b, [Optional] CancellationToken c);

		[Cpp2IlInjected.Token(Token = "0x600079F")]
		[Cpp2IlInjected.Address(Slot = "8")]
		Task<RecNetResult> SCPBJHASVMR(Guid a, int b, [Optional] CancellationToken c);
	}
	[Cpp2IlInjected.Token(Token = "0x200011D")]
	[Utf8JsonSerializable]
	public class TimedCurrencyGrantDTO
	{
		[Cpp2IlInjected.Token(Token = "0x17000356")]
		public long TimedCurrencyGrantId
		{
			[Cpp2IlInjected.Token(Token = "0x60007A0")]
			[Cpp2IlInjected.Address(RVA = "0xD117B0", Offset = "0xD101B0", VA = "0x180D117B0")]
			[CompilerGenerated]
			get
			{
				return default(long);
			}
			[Cpp2IlInjected.Token(Token = "0x60007A1")]
			[Cpp2IlInjected.Address(RVA = "0xED90B0", Offset = "0xED7AB0", VA = "0x180ED90B0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000357")]
		public string Name
		{
			[Cpp2IlInjected.Token(Token = "0x60007A2")]
			[Cpp2IlInjected.Address(RVA = "0xD11B30", Offset = "0xD10530", VA = "0x180D11B30")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60007A3")]
			[Cpp2IlInjected.Address(RVA = "0xD12270", Offset = "0xD10C70", VA = "0x180D12270")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000358")]
		public DateTime StartTime
		{
			[Cpp2IlInjected.Token(Token = "0x60007A4")]
			[Cpp2IlInjected.Address(RVA = "0xD12BC0", Offset = "0xD115C0", VA = "0x180D12BC0")]
			[CompilerGenerated]
			get
			{
				return default(DateTime);
			}
			[Cpp2IlInjected.Token(Token = "0x60007A5")]
			[Cpp2IlInjected.Address(RVA = "0xE3F130", Offset = "0xE3DB30", VA = "0x180E3F130")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000359")]
		public DateTime EndTime
		{
			[Cpp2IlInjected.Token(Token = "0x60007A6")]
			[Cpp2IlInjected.Address(RVA = "0xD11B00", Offset = "0xD10500", VA = "0x180D11B00")]
			[CompilerGenerated]
			get
			{
				return default(DateTime);
			}
			[Cpp2IlInjected.Token(Token = "0x60007A7")]
			[Cpp2IlInjected.Address(RVA = "0xD11960", Offset = "0xD10360", VA = "0x180D11960")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700035A")]
		public CurrencyType CurrencyType
		{
			[Cpp2IlInjected.Token(Token = "0x60007A8")]
			[Cpp2IlInjected.Address(RVA = "0xD1B6C0", Offset = "0xD1A0C0", VA = "0x180D1B6C0")]
			[CompilerGenerated]
			get
			{
				return default(CurrencyType);
			}
			[Cpp2IlInjected.Token(Token = "0x60007A9")]
			[Cpp2IlInjected.Address(RVA = "0xD1B020", Offset = "0xD19A20", VA = "0x180D1B020")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700035B")]
		public float OfflineRatePerHour
		{
			[Cpp2IlInjected.Token(Token = "0x60007AA")]
			[Cpp2IlInjected.Address(RVA = "0xDE3D10", Offset = "0xDE2710", VA = "0x180DE3D10")]
			[CompilerGenerated]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x60007AB")]
			[Cpp2IlInjected.Address(RVA = "0xDE3D20", Offset = "0xDE2720", VA = "0x180DE3D20")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700035C")]
		public float OnlineRatePerHour
		{
			[Cpp2IlInjected.Token(Token = "0x60007AC")]
			[Cpp2IlInjected.Address(RVA = "0xDA2840", Offset = "0xDA1240", VA = "0x180DA2840")]
			[CompilerGenerated]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x60007AD")]
			[Cpp2IlInjected.Address(RVA = "0x113A6F0", Offset = "0x11390F0", VA = "0x18113A6F0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700035D")]
		public string ActiveExperiment
		{
			[Cpp2IlInjected.Token(Token = "0x60007AE")]
			[Cpp2IlInjected.Address(RVA = "0xD11A30", Offset = "0xD10430", VA = "0x180D11A30")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60007AF")]
			[Cpp2IlInjected.Address(RVA = "0xD12260", Offset = "0xD10C60", VA = "0x180D12260")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60007B0")]
		[Cpp2IlInjected.Address(RVA = "0xD16C40", Offset = "0xD15640", VA = "0x180D16C40")]
		public TimedCurrencyGrantDTO()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200011E")]
	[Utf8JsonSerializable]
	public class TimedRewardTrackDTO
	{
		[Cpp2IlInjected.Token(Token = "0x1700035E")]
		public long TrackId
		{
			[Cpp2IlInjected.Token(Token = "0x60007B1")]
			[Cpp2IlInjected.Address(RVA = "0xD117B0", Offset = "0xD101B0", VA = "0x180D117B0")]
			[CompilerGenerated]
			get
			{
				return default(long);
			}
			[Cpp2IlInjected.Token(Token = "0x60007B2")]
			[Cpp2IlInjected.Address(RVA = "0xED90B0", Offset = "0xED7AB0", VA = "0x180ED90B0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700035F")]
		public string Name
		{
			[Cpp2IlInjected.Token(Token = "0x60007B3")]
			[Cpp2IlInjected.Address(RVA = "0xD11B30", Offset = "0xD10530", VA = "0x180D11B30")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60007B4")]
			[Cpp2IlInjected.Address(RVA = "0xD12270", Offset = "0xD10C70", VA = "0x180D12270")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000360")]
		public DateTime StartTime
		{
			[Cpp2IlInjected.Token(Token = "0x60007B5")]
			[Cpp2IlInjected.Address(RVA = "0xD12BC0", Offset = "0xD115C0", VA = "0x180D12BC0")]
			[CompilerGenerated]
			get
			{
				return default(DateTime);
			}
			[Cpp2IlInjected.Token(Token = "0x60007B6")]
			[Cpp2IlInjected.Address(RVA = "0xE3F130", Offset = "0xE3DB30", VA = "0x180E3F130")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000361")]
		public DateTime EndTime
		{
			[Cpp2IlInjected.Token(Token = "0x60007B7")]
			[Cpp2IlInjected.Address(RVA = "0xD11B00", Offset = "0xD10500", VA = "0x180D11B00")]
			[CompilerGenerated]
			get
			{
				return default(DateTime);
			}
			[Cpp2IlInjected.Token(Token = "0x60007B8")]
			[Cpp2IlInjected.Address(RVA = "0xD11960", Offset = "0xD10360", VA = "0x180D11960")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000362")]
		public int RequiredXp
		{
			[Cpp2IlInjected.Token(Token = "0x60007B9")]
			[Cpp2IlInjected.Address(RVA = "0xD1B6C0", Offset = "0xD1A0C0", VA = "0x180D1B6C0")]
			[CompilerGenerated]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x60007BA")]
			[Cpp2IlInjected.Address(RVA = "0xD1B020", Offset = "0xD19A20", VA = "0x180D1B020")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000363")]
		public List<TimedRewardTrackLevelDTO> Levels
		{
			[Cpp2IlInjected.Token(Token = "0x60007BB")]
			[Cpp2IlInjected.Address(RVA = "0xD12280", Offset = "0xD10C80", VA = "0x180D12280")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60007BC")]
			[Cpp2IlInjected.Address(RVA = "0xD11B50", Offset = "0xD10550", VA = "0x180D11B50")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60007BD")]
		[Cpp2IlInjected.Address(RVA = "0xD16C40", Offset = "0xD15640", VA = "0x180D16C40")]
		public TimedRewardTrackDTO()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200011F")]
	[Utf8JsonSerializable]
	public class TimedRewardTrackLevelDTO
	{
		[Cpp2IlInjected.Token(Token = "0x17000364")]
		public long TimedRewardTrackLevelId
		{
			[Cpp2IlInjected.Token(Token = "0x60007BE")]
			[Cpp2IlInjected.Address(RVA = "0xD117B0", Offset = "0xD101B0", VA = "0x180D117B0")]
			[CompilerGenerated]
			get
			{
				return default(long);
			}
			[Cpp2IlInjected.Token(Token = "0x60007BF")]
			[Cpp2IlInjected.Address(RVA = "0xED90B0", Offset = "0xED7AB0", VA = "0x180ED90B0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000365")]
		public int XpRequired
		{
			[Cpp2IlInjected.Token(Token = "0x60007C0")]
			[Cpp2IlInjected.Address(RVA = "0xD17340", Offset = "0xD15D40", VA = "0x180D17340")]
			[CompilerGenerated]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x60007C1")]
			[Cpp2IlInjected.Address(RVA = "0xD17360", Offset = "0xD15D60", VA = "0x180D17360")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000366")]
		public List<int> RewardGiftDropIds
		{
			[Cpp2IlInjected.Token(Token = "0x60007C2")]
			[Cpp2IlInjected.Address(RVA = "0xD12BC0", Offset = "0xD115C0", VA = "0x180D12BC0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60007C3")]
			[Cpp2IlInjected.Address(RVA = "0xD11520", Offset = "0xD0FF20", VA = "0x180D11520")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60007C4")]
		[Cpp2IlInjected.Address(RVA = "0xD16C40", Offset = "0xD15640", VA = "0x180D16C40")]
		public TimedRewardTrackLevelDTO()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000120")]
	[Utf8JsonSerializable]
	public class TimedRewardTrackRecordDTO
	{
		[Cpp2IlInjected.Token(Token = "0x17000367")]
		public long TrackId
		{
			[Cpp2IlInjected.Token(Token = "0x60007C5")]
			[Cpp2IlInjected.Address(RVA = "0xD117B0", Offset = "0xD101B0", VA = "0x180D117B0")]
			[CompilerGenerated]
			get
			{
				return default(long);
			}
			[Cpp2IlInjected.Token(Token = "0x60007C6")]
			[Cpp2IlInjected.Address(RVA = "0xED90B0", Offset = "0xED7AB0", VA = "0x180ED90B0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000368")]
		public int AccountId
		{
			[Cpp2IlInjected.Token(Token = "0x60007C7")]
			[Cpp2IlInjected.Address(RVA = "0xD17340", Offset = "0xD15D40", VA = "0x180D17340")]
			[CompilerGenerated]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x60007C8")]
			[Cpp2IlInjected.Address(RVA = "0xD17360", Offset = "0xD15D60", VA = "0x180D17360")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000369")]
		public int Xp
		{
			[Cpp2IlInjected.Token(Token = "0x60007C9")]
			[Cpp2IlInjected.Address(RVA = "0x1664600", Offset = "0x1663000", VA = "0x181664600")]
			[CompilerGenerated]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x60007CA")]
			[Cpp2IlInjected.Address(RVA = "0x1664610", Offset = "0x1663010", VA = "0x181664610")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60007CB")]
		[Cpp2IlInjected.Address(RVA = "0xD16C40", Offset = "0xD15640", VA = "0x180D16C40")]
		public TimedRewardTrackRecordDTO()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000121")]
	[Utf8JsonSerializable]
	public class TimedRewardTrackXpEarnedDTO : IEquatable<TimedRewardTrackXpEarnedDTO>
	{
		[Cpp2IlInjected.Token(Token = "0x1700036A")]
		[CompilerGenerated]
		protected virtual Type VZLUXMAJKRJ
		{
			[Cpp2IlInjected.Token(Token = "0x60007CD")]
			[Cpp2IlInjected.Address(RVA = "0x8DC7660", Offset = "0x8DC6060", VA = "0x188DC7660", Slot = "5")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700036B")]
		public long TrackId
		{
			[Cpp2IlInjected.Token(Token = "0x60007CE")]
			[Cpp2IlInjected.Address(RVA = "0xD117B0", Offset = "0xD101B0", VA = "0x180D117B0")]
			[CompilerGenerated]
			get
			{
				return default(long);
			}
			[Cpp2IlInjected.Token(Token = "0x60007CF")]
			[Cpp2IlInjected.Address(RVA = "0xED90B0", Offset = "0xED7AB0", VA = "0x180ED90B0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700036C")]
		public int AccountId
		{
			[Cpp2IlInjected.Token(Token = "0x60007D0")]
			[Cpp2IlInjected.Address(RVA = "0xD17340", Offset = "0xD15D40", VA = "0x180D17340")]
			[CompilerGenerated]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x60007D1")]
			[Cpp2IlInjected.Address(RVA = "0xD17360", Offset = "0xD15D60", VA = "0x180D17360")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700036D")]
		public int TotalXp
		{
			[Cpp2IlInjected.Token(Token = "0x60007D2")]
			[Cpp2IlInjected.Address(RVA = "0x1664600", Offset = "0x1663000", VA = "0x181664600")]
			[CompilerGenerated]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x60007D3")]
			[Cpp2IlInjected.Address(RVA = "0x1664610", Offset = "0x1663010", VA = "0x181664610")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700036E")]
		public int DeltaXp
		{
			[Cpp2IlInjected.Token(Token = "0x60007D4")]
			[Cpp2IlInjected.Address(RVA = "0xD215F0", Offset = "0xD1FFF0", VA = "0x180D215F0")]
			[CompilerGenerated]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x60007D5")]
			[Cpp2IlInjected.Address(RVA = "0xD682F0", Offset = "0xD66CF0", VA = "0x180D682F0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700036F")]
		public float DeltaXpMultiplier
		{
			[Cpp2IlInjected.Token(Token = "0x60007D6")]
			[Cpp2IlInjected.Address(RVA = "0xD67450", Offset = "0xD65E50", VA = "0x180D67450")]
			[CompilerGenerated]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x60007D7")]
			[Cpp2IlInjected.Address(RVA = "0xD67440", Offset = "0xD65E40", VA = "0x180D67440")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60007CC")]
		[Cpp2IlInjected.Address(RVA = "0x8DC79B0", Offset = "0x8DC63B0", VA = "0x188DC79B0")]
		public TimedRewardTrackXpEarnedDTO(long TrackId, int AccountId, int TotalXp, int DeltaXp, float DeltaXpMultiplier)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60007D8")]
		[Cpp2IlInjected.Address(RVA = "0x8DC76E0", Offset = "0x8DC60E0", VA = "0x188DC76E0", Slot = "3")]
		[CompilerGenerated]
		public override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60007D9")]
		[Cpp2IlInjected.Address(RVA = "0x8DC77D0", Offset = "0x8DC61D0", VA = "0x188DC77D0", Slot = "6")]
		[CompilerGenerated]
		protected virtual bool WJJAKQGJTCH(StringBuilder a)
		{
			return default(bool);
		}

		[SpecialName]
		[Cpp2IlInjected.Token(Token = "0x60007DA")]
		[Cpp2IlInjected.Address(RVA = "0x12EAD60", Offset = "0x12E9760", VA = "0x1812EAD60")]
		[CompilerGenerated]
		public static bool CYAUITUETAA(TimedRewardTrackXpEarnedDTO? a, TimedRewardTrackXpEarnedDTO? b)
		{
			return default(bool);
		}

		[SpecialName]
		[Cpp2IlInjected.Token(Token = "0x60007DB")]
		[Cpp2IlInjected.Address(RVA = "0x12EB0B0", Offset = "0x12E9AB0", VA = "0x1812EB0B0")]
		[CompilerGenerated]
		public static bool ITVTPRNZGNV(TimedRewardTrackXpEarnedDTO? a, TimedRewardTrackXpEarnedDTO? b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60007DC")]
		[Cpp2IlInjected.Address(RVA = "0x8DC7470", Offset = "0x8DC5E70", VA = "0x188DC7470", Slot = "2")]
		[CompilerGenerated]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60007DD")]
		[Cpp2IlInjected.Address(RVA = "0x8DC71D0", Offset = "0x8DC5BD0", VA = "0x188DC71D0", Slot = "0")]
		[CompilerGenerated]
		public override bool Equals(object? obj)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60007DE")]
		[Cpp2IlInjected.Address(RVA = "0x8DC7260", Offset = "0x8DC5C60", VA = "0x188DC7260", Slot = "7")]
		[CompilerGenerated]
		public virtual bool Equals(TimedRewardTrackXpEarnedDTO? other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60007DF")]
		[Cpp2IlInjected.Address(RVA = "0x8DC7150", Offset = "0x8DC5B50", VA = "0x188DC7150", Slot = "8")]
		[CompilerGenerated]
		public virtual TimedRewardTrackXpEarnedDTO CXDOYZBTDGW()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60007E0")]
		[Cpp2IlInjected.Address(RVA = "0x8DC7960", Offset = "0x8DC6360", VA = "0x188DC7960")]
		[CompilerGenerated]
		protected TimedRewardTrackXpEarnedDTO(TimedRewardTrackXpEarnedDTO original)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60007E1")]
		[Cpp2IlInjected.Address(RVA = "0x8DC76B0", Offset = "0x8DC60B0", VA = "0x188DC76B0")]
		[CompilerGenerated]
		public void OGNPAZKLJRJ([Out] long a, [Out] int b, [Out] int c, [Out] int d, [Out] float e)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000122")]
	[Utf8JsonSerializable]
	public abstract class UGCPurchasableIdentifier : IEquatable<UGCPurchasableIdentifier>
	{
		[Cpp2IlInjected.Token(Token = "0x17000370")]
		public Guid itemId
		{
			[Cpp2IlInjected.Token(Token = "0x60007E2")]
			[Cpp2IlInjected.Address(RVA = "0xF357F0", Offset = "0xF341F0", VA = "0x180F357F0")]
			[CompilerGenerated]
			get
			{
				return default(Guid);
			}
			[Cpp2IlInjected.Token(Token = "0x60007E3")]
			[Cpp2IlInjected.Address(RVA = "0xF35810", Offset = "0xF34210", VA = "0x180F35810")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60007E4")]
		[Cpp2IlInjected.Address(RVA = "0x8DC8F70", Offset = "0x8DC7970", VA = "0x188DC8F70", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60007E5")]
		[Cpp2IlInjected.Address(RVA = "0x8DC8EF0", Offset = "0x8DC78F0", VA = "0x188DC8EF0", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60007E6")]
		[Cpp2IlInjected.Address(RVA = "0x8DC45F0", Offset = "0x8DC2FF0", VA = "0x188DC45F0", Slot = "4")]
		public bool Equals(UGCPurchasableIdentifier other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60007E7")]
		[Cpp2IlInjected.Address(RVA = "0x8DC8DE0", Offset = "0x8DC77E0", VA = "0x188DC8DE0", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60007E8")]
		[Cpp2IlInjected.Address(Slot = "5")]
		public abstract UGCPurchasableIdentifier Clone();

		[Cpp2IlInjected.Token(Token = "0x60007E9")]
		[Cpp2IlInjected.Address(RVA = "0xD16C40", Offset = "0xD15640", VA = "0x180D16C40")]
		protected UGCPurchasableIdentifier()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000123")]
	public enum UGCPurchasableItemType
	{
		[Cpp2IlInjected.Token(Token = "0x4000613")]
		RoomKey,
		[Cpp2IlInjected.Token(Token = "0x4000614")]
		RoomConsumable,
		[Cpp2IlInjected.Token(Token = "0x4000615")]
		RoomCurrencyPurchaseOffer,
		[Cpp2IlInjected.Token(Token = "0x4000616")]
		CustomAvatarItem,
		[Cpp2IlInjected.Token(Token = "0x4000617")]
		StoreUGCAvatarItem,
		[Cpp2IlInjected.Token(Token = "0x4000618")]
		RoomOffer,
		[Cpp2IlInjected.Token(Token = "0x4000619")]
		UNDEFINED
	}
	[Cpp2IlInjected.Token(Token = "0x2000124")]
	[Utf8JsonSerializable]
	public class UGCPurchasableItemIdentifier : UGCPurchasableIdentifier, IEquatable<UGCPurchasableItemIdentifier>
	{
		[Cpp2IlInjected.Token(Token = "0x17000371")]
		public UGCPurchasableItemType itemType
		{
			[Cpp2IlInjected.Token(Token = "0x60007EA")]
			[Cpp2IlInjected.Address(RVA = "0xD215F0", Offset = "0xD1FFF0", VA = "0x180D215F0")]
			[CompilerGenerated]
			get
			{
				return default(UGCPurchasableItemType);
			}
			[Cpp2IlInjected.Token(Token = "0x60007EB")]
			[Cpp2IlInjected.Address(RVA = "0xD682F0", Offset = "0xD66CF0", VA = "0x180D682F0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60007EC")]
		[Cpp2IlInjected.Address(RVA = "0x8DC9190", Offset = "0x8DC7B90", VA = "0x188DC9190", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60007ED")]
		[Cpp2IlInjected.Address(RVA = "0x8DC90B0", Offset = "0x8DC7AB0", VA = "0x188DC90B0", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60007EE")]
		[Cpp2IlInjected.Address(RVA = "0xD16C40", Offset = "0xD15640", VA = "0x180D16C40")]
		public UGCPurchasableItemIdentifier()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60007EF")]
		[Cpp2IlInjected.Address(RVA = "0x8DC9220", Offset = "0x8DC7C20", VA = "0x188DC9220")]
		public UGCPurchasableItemIdentifier(UGCPurchasableItemType itemType, Guid itemId)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60007F0")]
		[Cpp2IlInjected.Address(RVA = "0x8DC9130", Offset = "0x8DC7B30", VA = "0x188DC9130")]
		public static UGCPurchasableItemIdentifier TVZIJWQVFZL(Guid a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60007F1")]
		[Cpp2IlInjected.Address(RVA = "0x8DC9050", Offset = "0x8DC7A50", VA = "0x188DC9050", Slot = "6")]
		public bool Equals(UGCPurchasableItemIdentifier other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60007F2")]
		[Cpp2IlInjected.Address(RVA = "0x8DC8FE0", Offset = "0x8DC79E0", VA = "0x188DC8FE0", Slot = "5")]
		public override UGCPurchasableIdentifier Clone()
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000125")]
	public static class JCWWIJDRPPA
	{
		[Cpp2IlInjected.Token(Token = "0x60007F3")]
		[Cpp2IlInjected.Address(RVA = "0x8DC2570", Offset = "0x8DC0F70", VA = "0x188DC2570")]
		public static UGCPurchasableItemIdentifier VQRUGTSIEYC(this UGCPurchasableItem a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60007F4")]
		[Cpp2IlInjected.Address(RVA = "0x8DC2480", Offset = "0x8DC0E80", VA = "0x188DC2480")]
		public static UGCPurchasableItemIdentifier TUZBEOPRIPO(string a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60007F5")]
		[Cpp2IlInjected.Address(RVA = "0x8DC2410", Offset = "0x8DC0E10", VA = "0x188DC2410")]
		public static UGCPurchasableItemIdentifier DRIPTWBCGWR(Guid a)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000126")]
	[Utf8JsonSerializable]
	public class UGCPurchasableItem
	{
		[Cpp2IlInjected.Token(Token = "0x17000372")]
		public UGCPurchasableItemType ItemType
		{
			[Cpp2IlInjected.Token(Token = "0x60007F6")]
			[Cpp2IlInjected.Address(RVA = "0xD0F110", Offset = "0xD0DB10", VA = "0x180D0F110")]
			[CompilerGenerated]
			get
			{
				return default(UGCPurchasableItemType);
			}
			[Cpp2IlInjected.Token(Token = "0x60007F7")]
			[Cpp2IlInjected.Address(RVA = "0xD12F30", Offset = "0xD11930", VA = "0x180D12F30")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000373")]
		public Guid ItemId
		{
			[Cpp2IlInjected.Token(Token = "0x60007F8")]
			[Cpp2IlInjected.Address(RVA = "0x1C7CC20", Offset = "0x1C7B620", VA = "0x181C7CC20")]
			[CompilerGenerated]
			get
			{
				return default(Guid);
			}
			[Cpp2IlInjected.Token(Token = "0x60007F9")]
			[Cpp2IlInjected.Address(RVA = "0x7A23450", Offset = "0x7A21E50", VA = "0x187A23450")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000374")]
		public string Name
		{
			[Cpp2IlInjected.Token(Token = "0x60007FA")]
			[Cpp2IlInjected.Address(RVA = "0xD11B00", Offset = "0xD10500", VA = "0x180D11B00")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60007FB")]
			[Cpp2IlInjected.Address(RVA = "0xD11530", Offset = "0xD0FF30", VA = "0x180D11530")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000375")]
		public string Description
		{
			[Cpp2IlInjected.Token(Token = "0x60007FC")]
			[Cpp2IlInjected.Address(RVA = "0xD11A20", Offset = "0xD10420", VA = "0x180D11A20")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60007FD")]
			[Cpp2IlInjected.Address(RVA = "0xD17350", Offset = "0xD15D50", VA = "0x180D17350")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000376")]
		public string ImageName
		{
			[Cpp2IlInjected.Token(Token = "0x60007FE")]
			[Cpp2IlInjected.Address(RVA = "0xD12280", Offset = "0xD10C80", VA = "0x180D12280")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60007FF")]
			[Cpp2IlInjected.Address(RVA = "0xD11B50", Offset = "0xD10550", VA = "0x180D11B50")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000377")]
		public long? RoomId
		{
			[Cpp2IlInjected.Token(Token = "0x6000800")]
			[Cpp2IlInjected.Address(RVA = "0x10ABB70", Offset = "0x10AA570", VA = "0x1810ABB70")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000801")]
			[Cpp2IlInjected.Address(RVA = "0x10ABCC0", Offset = "0x10AA6C0", VA = "0x1810ABCC0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000378")]
		public long Price
		{
			[Cpp2IlInjected.Token(Token = "0x6000802")]
			[Cpp2IlInjected.Address(RVA = "0xD11B20", Offset = "0xD10520", VA = "0x180D11B20")]
			[CompilerGenerated]
			get
			{
				return default(long);
			}
			[Cpp2IlInjected.Token(Token = "0x6000803")]
			[Cpp2IlInjected.Address(RVA = "0xFFBF90", Offset = "0xFFA990", VA = "0x180FFBF90")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000379")]
		public Guid? PurchaseCurrencyId
		{
			[Cpp2IlInjected.Token(Token = "0x6000804")]
			[Cpp2IlInjected.Address(RVA = "0x8DC4550", Offset = "0x8DC2F50", VA = "0x188DC4550")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000805")]
			[Cpp2IlInjected.Address(RVA = "0x8DC4570", Offset = "0x8DC2F70", VA = "0x188DC4570")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700037A")]
		public DateTime CreatedAt
		{
			[Cpp2IlInjected.Token(Token = "0x6000806")]
			[Cpp2IlInjected.Address(RVA = "0xD11B60", Offset = "0xD10560", VA = "0x180D11B60")]
			[CompilerGenerated]
			get
			{
				return default(DateTime);
			}
			[Cpp2IlInjected.Token(Token = "0x6000807")]
			[Cpp2IlInjected.Address(RVA = "0x1016DA0", Offset = "0x10157A0", VA = "0x181016DA0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700037B")]
		public DateTime ModifiedAt
		{
			[Cpp2IlInjected.Token(Token = "0x6000808")]
			[Cpp2IlInjected.Address(RVA = "0xD1E8A0", Offset = "0xD1D2A0", VA = "0x180D1E8A0")]
			[CompilerGenerated]
			get
			{
				return default(DateTime);
			}
			[Cpp2IlInjected.Token(Token = "0x6000809")]
			[Cpp2IlInjected.Address(RVA = "0x1016940", Offset = "0x1015340", VA = "0x181016940")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600080A")]
		[Cpp2IlInjected.Address(RVA = "0xD16C40", Offset = "0xD15640", VA = "0x180D16C40")]
		public UGCPurchasableItem()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600080B")]
		[Cpp2IlInjected.Address(RVA = "0x8DC9310", Offset = "0x8DC7D10", VA = "0x188DC9310")]
		public UGCPurchasableItem(UGCPurchasableItemType itemType, Guid itemId, [Optional] string name, [Optional] string description, [Optional] string imageName, [Optional] long? roomId, long price = 0L, [Optional] Guid? purchaseCurrencyId, [Optional] DateTime createdAt, [Optional] DateTime modifiedAt)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600080C")]
		[Cpp2IlInjected.Address(RVA = "0x8DC9260", Offset = "0x8DC7C60", VA = "0x188DC9260", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}
}
namespace RecNet.ConsumableEffects.AvatarItemEffects
{
	[Cpp2IlInjected.Token(Token = "0x2000127")]
	public interface MVLXEBCKYBS
	{
		[Cpp2IlInjected.Token(Token = "0x1700037C")]
		string Name
		{
			[Cpp2IlInjected.Token(Token = "0x600080D")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000128")]
	public interface NSHERHNIAKL<out a> : MVLXEBCKYBS where a : struct
	{
		[Cpp2IlInjected.Token(Token = "0x1700037D")]
		a Id
		{
			[Cpp2IlInjected.Token(Token = "0x600080E")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000129")]
	[Utf8JsonSerializable]
	public class AvatarEffectConfigDTO : OIRXPKYYAWC
	{
		[Cpp2IlInjected.Token(Token = "0x1700037E")]
		public List<AvatarEffectKeyDTO> AvailableEffects
		{
			[Cpp2IlInjected.Token(Token = "0x600080F")]
			[Cpp2IlInjected.Address(RVA = "0xD117B0", Offset = "0xD101B0", VA = "0x180D117B0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000810")]
			[Cpp2IlInjected.Address(RVA = "0xD117C0", Offset = "0xD101C0", VA = "0x180D117C0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700037F")]
		public List<PotionBottleConfigDTO> PotionBottleOverrides
		{
			[Cpp2IlInjected.Token(Token = "0x6000811")]
			[Cpp2IlInjected.Address(RVA = "0xD11B30", Offset = "0xD10530", VA = "0x180D11B30")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000812")]
			[Cpp2IlInjected.Address(RVA = "0xD12270", Offset = "0xD10C70", VA = "0x180D12270")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000380")]
		public List<DriverTypeBottleConfigDTO> DriverTypeConfigs
		{
			[Cpp2IlInjected.Token(Token = "0x6000813")]
			[Cpp2IlInjected.Address(RVA = "0xD12BC0", Offset = "0xD115C0", VA = "0x180D12BC0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000814")]
			[Cpp2IlInjected.Address(RVA = "0xD11520", Offset = "0xD0FF20", VA = "0x180D11520")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000381")]
		public List<AuraConfigDTO> AuraConfigs
		{
			[Cpp2IlInjected.Token(Token = "0x6000815")]
			[Cpp2IlInjected.Address(RVA = "0xD11B00", Offset = "0xD10500", VA = "0x180D11B00")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000816")]
			[Cpp2IlInjected.Address(RVA = "0xD11530", Offset = "0xD0FF30", VA = "0x180D11530")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000382")]
		public List<GradientConfigDTO> GradientConfigs
		{
			[Cpp2IlInjected.Token(Token = "0x6000817")]
			[Cpp2IlInjected.Address(RVA = "0xD11A20", Offset = "0xD10420", VA = "0x180D11A20")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000818")]
			[Cpp2IlInjected.Address(RVA = "0xD17350", Offset = "0xD15D50", VA = "0x180D17350")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000383")]
		public List<AnimationCurveConfigDTO> AnimationCurveConfigs
		{
			[Cpp2IlInjected.Token(Token = "0x6000819")]
			[Cpp2IlInjected.Address(RVA = "0xD12280", Offset = "0xD10C80", VA = "0x180D12280")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600081A")]
			[Cpp2IlInjected.Address(RVA = "0xD11B50", Offset = "0xD10550", VA = "0x180D11B50")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000384")]
		public List<TextureEffectDTO> TextureEffectConfigs
		{
			[Cpp2IlInjected.Token(Token = "0x600081B")]
			[Cpp2IlInjected.Address(RVA = "0xD11A30", Offset = "0xD10430", VA = "0x180D11A30")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600081C")]
			[Cpp2IlInjected.Address(RVA = "0xD12260", Offset = "0xD10C60", VA = "0x180D12260")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000385")]
		public List<PlayerScaleEffectDTO> PlayerScaleEffectConfigs
		{
			[Cpp2IlInjected.Token(Token = "0x600081D")]
			[Cpp2IlInjected.Address(RVA = "0xD122E0", Offset = "0xD10CE0", VA = "0x180D122E0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600081E")]
			[Cpp2IlInjected.Address(RVA = "0xD12290", Offset = "0xD10C90", VA = "0x180D12290")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000386")]
		public List<PlayerTransformationEffectDTO> PlayerTransformationEffectConfigs
		{
			[Cpp2IlInjected.Token(Token = "0x600081F")]
			[Cpp2IlInjected.Address(RVA = "0xD11B20", Offset = "0xD10520", VA = "0x180D11B20")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000820")]
			[Cpp2IlInjected.Address(RVA = "0xD11900", Offset = "0xD10300", VA = "0x180D11900")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000387")]
		public List<PlayerMovementSpeedEffectDTO> PlayerMovementSpeedEffectConfigs
		{
			[Cpp2IlInjected.Token(Token = "0x6000821")]
			[Cpp2IlInjected.Address(RVA = "0xD11940", Offset = "0xD10340", VA = "0x180D11940")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000822")]
			[Cpp2IlInjected.Address(RVA = "0xD122A0", Offset = "0xD10CA0", VA = "0x180D122A0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000388")]
		public DriverConfigDTO PlayerVelocityDriverConfig
		{
			[Cpp2IlInjected.Token(Token = "0x6000823")]
			[Cpp2IlInjected.Address(RVA = "0xD15610", Offset = "0xD14010", VA = "0x180D15610")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000824")]
			[Cpp2IlInjected.Address(RVA = "0xD15600", Offset = "0xD14000", VA = "0x180D15600")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000389")]
		public DriverConfigDTO PlayerVoiceVolumeDriverConfig
		{
			[Cpp2IlInjected.Token(Token = "0x6000825")]
			[Cpp2IlInjected.Address(RVA = "0xD11B40", Offset = "0xD10540", VA = "0x180D11B40")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000826")]
			[Cpp2IlInjected.Address(RVA = "0xD11910", Offset = "0xD10310", VA = "0x180D11910")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700038A")]
		public DriverConfigDTO PlayerHighFivesDriverConfig
		{
			[Cpp2IlInjected.Token(Token = "0x6000827")]
			[Cpp2IlInjected.Address(RVA = "0xD11B60", Offset = "0xD10560", VA = "0x180D11B60")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000828")]
			[Cpp2IlInjected.Address(RVA = "0xD11AE0", Offset = "0xD104E0", VA = "0x180D11AE0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000829")]
		[Cpp2IlInjected.Address(RVA = "0x8DBE270", Offset = "0x8DBCC70", VA = "0x188DBE270", Slot = "4")]
		public void HHUGNWFYOZL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600082A")]
		[Cpp2IlInjected.Address(RVA = "0x8DBE280", Offset = "0x8DBCC80", VA = "0x188DBE280")]
		public AvatarEffectConfigDTO()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200012A")]
	[Utf8JsonSerializable]
	public class AvatarEffectKeyDTO : IEquatable<AvatarEffectKeyDTO>
	{
		[Cpp2IlInjected.Token(Token = "0x1700038B")]
		public AvatarItemEffectChannel EffectChannel
		{
			[Cpp2IlInjected.Token(Token = "0x600082B")]
			[Cpp2IlInjected.Address(RVA = "0xD66E30", Offset = "0xD65830", VA = "0x180D66E30")]
			[CompilerGenerated]
			get
			{
				return default(AvatarItemEffectChannel);
			}
			[Cpp2IlInjected.Token(Token = "0x600082C")]
			[Cpp2IlInjected.Address(RVA = "0xE376D0", Offset = "0xE360D0", VA = "0x180E376D0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700038C")]
		public DriverType DriverType
		{
			[Cpp2IlInjected.Token(Token = "0x600082D")]
			[Cpp2IlInjected.Address(RVA = "0xE38330", Offset = "0xE36D30", VA = "0x180E38330")]
			[CompilerGenerated]
			get
			{
				return default(DriverType);
			}
			[Cpp2IlInjected.Token(Token = "0x600082E")]
			[Cpp2IlInjected.Address(RVA = "0xE376E0", Offset = "0xE360E0", VA = "0x180E376E0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700038D")]
		public Guid DriverConfigKey
		{
			[Cpp2IlInjected.Token(Token = "0x600082F")]
			[Cpp2IlInjected.Address(RVA = "0x1C7CC20", Offset = "0x1C7B620", VA = "0x181C7CC20")]
			[CompilerGenerated]
			get
			{
				return default(Guid);
			}
			[Cpp2IlInjected.Token(Token = "0x6000830")]
			[Cpp2IlInjected.Address(RVA = "0x7A23450", Offset = "0x7A21E50", VA = "0x187A23450")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700038E")]
		public Guid ApplierConfigKey
		{
			[Cpp2IlInjected.Token(Token = "0x6000831")]
			[Cpp2IlInjected.Address(RVA = "0xE93820", Offset = "0xE92220", VA = "0x180E93820")]
			[CompilerGenerated]
			get
			{
				return default(Guid);
			}
			[Cpp2IlInjected.Token(Token = "0x6000832")]
			[Cpp2IlInjected.Address(RVA = "0xE936A0", Offset = "0xE920A0", VA = "0x180E936A0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000833")]
		[Cpp2IlInjected.Address(RVA = "0x8DBE580", Offset = "0x8DBCF80", VA = "0x188DBE580", Slot = "4")]
		public bool Equals(AvatarEffectKeyDTO other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000834")]
		[Cpp2IlInjected.Address(RVA = "0x8DBE620", Offset = "0x8DBD020", VA = "0x188DBE620", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000835")]
		[Cpp2IlInjected.Address(RVA = "0x8DBE780", Offset = "0x8DBD180", VA = "0x188DBE780", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[SpecialName]
		[Cpp2IlInjected.Token(Token = "0x6000836")]
		[Cpp2IlInjected.Address(RVA = "0x15B3480", Offset = "0x15B1E80", VA = "0x1815B3480")]
		public static bool ITVTPRNZGNV(AvatarEffectKeyDTO a, AvatarEffectKeyDTO b)
		{
			return default(bool);
		}

		[SpecialName]
		[Cpp2IlInjected.Token(Token = "0x6000837")]
		[Cpp2IlInjected.Address(RVA = "0x15B2EF0", Offset = "0x15B18F0", VA = "0x1815B2EF0")]
		public static bool CYAUITUETAA(AvatarEffectKeyDTO a, AvatarEffectKeyDTO b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000838")]
		[Cpp2IlInjected.Address(RVA = "0xD16C40", Offset = "0xD15640", VA = "0x180D16C40")]
		public AvatarEffectKeyDTO()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200012B")]
	[Utf8JsonSerializable]
	public class DriverConfigDTO : NSHERHNIAKL<DriverType>, MVLXEBCKYBS
	{
		[Cpp2IlInjected.Token(Token = "0x1700038F")]
		public DriverType Id
		{
			[Cpp2IlInjected.Token(Token = "0x6000839")]
			[Cpp2IlInjected.Address(RVA = "0xD66E30", Offset = "0xD65830", VA = "0x180D66E30", Slot = "4")]
			[CompilerGenerated]
			get
			{
				return default(DriverType);
			}
			[Cpp2IlInjected.Token(Token = "0x600083A")]
			[Cpp2IlInjected.Address(RVA = "0xE376D0", Offset = "0xE360D0", VA = "0x180E376D0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000390")]
		public string Name
		{
			[Cpp2IlInjected.Token(Token = "0x600083B")]
			[Cpp2IlInjected.Address(RVA = "0xD11B30", Offset = "0xD10530", VA = "0x180D11B30", Slot = "5")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600083C")]
			[Cpp2IlInjected.Address(RVA = "0xD12270", Offset = "0xD10C70", VA = "0x180D12270")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000391")]
		public AnimationCurveDTO AnimationCurve
		{
			[Cpp2IlInjected.Token(Token = "0x600083D")]
			[Cpp2IlInjected.Address(RVA = "0xD12BC0", Offset = "0xD115C0", VA = "0x180D12BC0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600083E")]
			[Cpp2IlInjected.Address(RVA = "0xD11520", Offset = "0xD0FF20", VA = "0x180D11520")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000392")]
		public float ValueAttackRate
		{
			[Cpp2IlInjected.Token(Token = "0x600083F")]
			[Cpp2IlInjected.Address(RVA = "0x10DD6F0", Offset = "0x10DC0F0", VA = "0x1810DD6F0")]
			[CompilerGenerated]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x6000840")]
			[Cpp2IlInjected.Address(RVA = "0x1368DF0", Offset = "0x13677F0", VA = "0x181368DF0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000393")]
		public float ValueDecayRate
		{
			[Cpp2IlInjected.Token(Token = "0x6000841")]
			[Cpp2IlInjected.Address(RVA = "0xE9AEF0", Offset = "0xE998F0", VA = "0x180E9AEF0")]
			[CompilerGenerated]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x6000842")]
			[Cpp2IlInjected.Address(RVA = "0xF35800", Offset = "0xF34200", VA = "0x180F35800")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000394")]
		public float EffectOverdrive
		{
			[Cpp2IlInjected.Token(Token = "0x6000843")]
			[Cpp2IlInjected.Address(RVA = "0xE9AEE0", Offset = "0xE998E0", VA = "0x180E9AEE0")]
			[CompilerGenerated]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x6000844")]
			[Cpp2IlInjected.Address(RVA = "0x10E0B20", Offset = "0x10DF520", VA = "0x1810E0B20")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000845")]
		[Cpp2IlInjected.Address(RVA = "0x8DBF410", Offset = "0x8DBDE10", VA = "0x188DBF410")]
		public DriverConfigDTO()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200012C")]
	[Utf8JsonSerializable]
	public class PotionBottleConfigDTO
	{
		[Cpp2IlInjected.Token(Token = "0x17000395")]
		public AvatarEffectKeyDTO Key
		{
			[Cpp2IlInjected.Token(Token = "0x6000846")]
			[Cpp2IlInjected.Address(RVA = "0xD117B0", Offset = "0xD101B0", VA = "0x180D117B0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000847")]
			[Cpp2IlInjected.Address(RVA = "0xD117C0", Offset = "0xD101C0", VA = "0x180D117C0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000396")]
		public string BottleTextureName
		{
			[Cpp2IlInjected.Token(Token = "0x6000848")]
			[Cpp2IlInjected.Address(RVA = "0xD11B30", Offset = "0xD10530", VA = "0x180D11B30")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000849")]
			[Cpp2IlInjected.Address(RVA = "0xD12270", Offset = "0xD10C70", VA = "0x180D12270")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000397")]
		public ColorConfig LiquidColor
		{
			[Cpp2IlInjected.Token(Token = "0x600084A")]
			[Cpp2IlInjected.Address(RVA = "0xD12BC0", Offset = "0xD115C0", VA = "0x180D12BC0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600084B")]
			[Cpp2IlInjected.Address(RVA = "0xD11520", Offset = "0xD0FF20", VA = "0x180D11520")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600084C")]
		[Cpp2IlInjected.Address(RVA = "0x8DC3D30", Offset = "0x8DC2730", VA = "0x188DC3D30")]
		public PotionBottleConfigDTO()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200012D")]
	[Utf8JsonSerializable]
	public class DriverTypeBottleConfigDTO
	{
		[Cpp2IlInjected.Token(Token = "0x17000398")]
		public DriverType DriverType
		{
			[Cpp2IlInjected.Token(Token = "0x600084D")]
			[Cpp2IlInjected.Address(RVA = "0xD66E30", Offset = "0xD65830", VA = "0x180D66E30")]
			[CompilerGenerated]
			get
			{
				return default(DriverType);
			}
			[Cpp2IlInjected.Token(Token = "0x600084E")]
			[Cpp2IlInjected.Address(RVA = "0xE376D0", Offset = "0xE360D0", VA = "0x180E376D0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000399")]
		public string TextureName
		{
			[Cpp2IlInjected.Token(Token = "0x600084F")]
			[Cpp2IlInjected.Address(RVA = "0xD11B30", Offset = "0xD10530", VA = "0x180D11B30")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000850")]
			[Cpp2IlInjected.Address(RVA = "0xD12270", Offset = "0xD10C70", VA = "0x180D12270")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000851")]
		[Cpp2IlInjected.Address(RVA = "0xD16C40", Offset = "0xD15640", VA = "0x180D16C40")]
		public DriverTypeBottleConfigDTO()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200012E")]
	[Utf8JsonSerializable]
	public class RemapConfigDTO : NSHERHNIAKL<Guid>, MVLXEBCKYBS
	{
		[Cpp2IlInjected.Token(Token = "0x1700039A")]
		public string Name
		{
			[Cpp2IlInjected.Token(Token = "0x6000852")]
			[Cpp2IlInjected.Address(RVA = "0xD117B0", Offset = "0xD101B0", VA = "0x180D117B0", Slot = "5")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000853")]
			[Cpp2IlInjected.Address(RVA = "0xD117C0", Offset = "0xD101C0", VA = "0x180D117C0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700039B")]
		public Guid Id
		{
			[Cpp2IlInjected.Token(Token = "0x6000854")]
			[Cpp2IlInjected.Address(RVA = "0xDA5E80", Offset = "0xDA4880", VA = "0x180DA5E80", Slot = "4")]
			[CompilerGenerated]
			get
			{
				return default(Guid);
			}
			[Cpp2IlInjected.Token(Token = "0x6000855")]
			[Cpp2IlInjected.Address(RVA = "0xF82330", Offset = "0xF80D30", VA = "0x180F82330")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700039C")]
		public float MinRemappedValue
		{
			[Cpp2IlInjected.Token(Token = "0x6000856")]
			[Cpp2IlInjected.Address(RVA = "0x10DD6F0", Offset = "0x10DC0F0", VA = "0x1810DD6F0")]
			[CompilerGenerated]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x6000857")]
			[Cpp2IlInjected.Address(RVA = "0x1368DF0", Offset = "0x13677F0", VA = "0x181368DF0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700039D")]
		public float MinRemappedNormalValue
		{
			[Cpp2IlInjected.Token(Token = "0x6000858")]
			[Cpp2IlInjected.Address(RVA = "0xE9AEF0", Offset = "0xE998F0", VA = "0x180E9AEF0")]
			[CompilerGenerated]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x6000859")]
			[Cpp2IlInjected.Address(RVA = "0xF35800", Offset = "0xF34200", VA = "0x180F35800")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700039E")]
		public float MaxRemappedNormalValue
		{
			[Cpp2IlInjected.Token(Token = "0x600085A")]
			[Cpp2IlInjected.Address(RVA = "0xE9AEE0", Offset = "0xE998E0", VA = "0x180E9AEE0")]
			[CompilerGenerated]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x600085B")]
			[Cpp2IlInjected.Address(RVA = "0x10E0B20", Offset = "0x10DF520", VA = "0x1810E0B20")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700039F")]
		public float MaxRemappedValue
		{
			[Cpp2IlInjected.Token(Token = "0x600085C")]
			[Cpp2IlInjected.Address(RVA = "0xDE3D10", Offset = "0xDE2710", VA = "0x180DE3D10")]
			[CompilerGenerated]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x600085D")]
			[Cpp2IlInjected.Address(RVA = "0xDE3D20", Offset = "0xDE2720", VA = "0x180DE3D20")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600085E")]
		[Cpp2IlInjected.Address(RVA = "0xD16C40", Offset = "0xD15640", VA = "0x180D16C40")]
		public RemapConfigDTO()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200012F")]
	[Utf8JsonSerializable]
	public class AuraConfigDTO : NSHERHNIAKL<Guid>, MVLXEBCKYBS
	{
		[Cpp2IlInjected.Token(Token = "0x170003A0")]
		public string Name
		{
			[Cpp2IlInjected.Token(Token = "0x600085F")]
			[Cpp2IlInjected.Address(RVA = "0x8DBE210", Offset = "0x8DBCC10", VA = "0x188DBE210", Slot = "5")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170003A1")]
		public Guid Id
		{
			[Cpp2IlInjected.Token(Token = "0x6000860")]
			[Cpp2IlInjected.Address(RVA = "0xF357F0", Offset = "0xF341F0", VA = "0x180F357F0", Slot = "4")]
			[CompilerGenerated]
			get
			{
				return default(Guid);
			}
			[Cpp2IlInjected.Token(Token = "0x6000861")]
			[Cpp2IlInjected.Address(RVA = "0xF35810", Offset = "0xF34210", VA = "0x180F35810")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170003A2")]
		public int AuraId
		{
			[Cpp2IlInjected.Token(Token = "0x6000862")]
			[Cpp2IlInjected.Address(RVA = "0xD215F0", Offset = "0xD1FFF0", VA = "0x180D215F0")]
			[CompilerGenerated]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x6000863")]
			[Cpp2IlInjected.Address(RVA = "0xD682F0", Offset = "0xD66CF0", VA = "0x180D682F0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170003A3")]
		public string TextureName
		{
			[Cpp2IlInjected.Token(Token = "0x6000864")]
			[Cpp2IlInjected.Address(RVA = "0xD11B00", Offset = "0xD10500", VA = "0x180D11B00")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000865")]
			[Cpp2IlInjected.Address(RVA = "0xD11530", Offset = "0xD0FF30", VA = "0x180D11530")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170003A4")]
		public ColorConfig Color
		{
			[Cpp2IlInjected.Token(Token = "0x6000866")]
			[Cpp2IlInjected.Address(RVA = "0xD11A20", Offset = "0xD10420", VA = "0x180D11A20")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000867")]
			[Cpp2IlInjected.Address(RVA = "0xD17350", Offset = "0xD15D50", VA = "0x180D17350")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000868")]
		[Cpp2IlInjected.Address(RVA = "0x8DBE1A0", Offset = "0x8DBCBA0", VA = "0x188DBE1A0")]
		public AuraConfigDTO()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000130")]
	[Utf8JsonSerializable]
	public class GradientConfigDTO : OIRXPKYYAWC, NSHERHNIAKL<Guid>, MVLXEBCKYBS
	{
		[Cpp2IlInjected.Token(Token = "0x170003A5")]
		public string Name
		{
			[Cpp2IlInjected.Token(Token = "0x6000869")]
			[Cpp2IlInjected.Address(RVA = "0xD117B0", Offset = "0xD101B0", VA = "0x180D117B0", Slot = "6")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600086A")]
			[Cpp2IlInjected.Address(RVA = "0xD117C0", Offset = "0xD101C0", VA = "0x180D117C0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170003A6")]
		public Guid Id
		{
			[Cpp2IlInjected.Token(Token = "0x600086B")]
			[Cpp2IlInjected.Address(RVA = "0xDA5E80", Offset = "0xDA4880", VA = "0x180DA5E80", Slot = "5")]
			[CompilerGenerated]
			get
			{
				return default(Guid);
			}
			[Cpp2IlInjected.Token(Token = "0x600086C")]
			[Cpp2IlInjected.Address(RVA = "0xF82330", Offset = "0xF80D30", VA = "0x180F82330")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170003A7")]
		public float GradientTime
		{
			[Cpp2IlInjected.Token(Token = "0x600086D")]
			[Cpp2IlInjected.Address(RVA = "0x10DD6F0", Offset = "0x10DC0F0", VA = "0x1810DD6F0")]
			[CompilerGenerated]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x600086E")]
			[Cpp2IlInjected.Address(RVA = "0x1368DF0", Offset = "0x13677F0", VA = "0x181368DF0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170003A8")]
		public GradientType GradientType
		{
			[Cpp2IlInjected.Token(Token = "0x600086F")]
			[Cpp2IlInjected.Address(RVA = "0x1B417C0", Offset = "0x1B401C0", VA = "0x181B417C0")]
			[CompilerGenerated]
			get
			{
				return default(GradientType);
			}
			[Cpp2IlInjected.Token(Token = "0x6000870")]
			[Cpp2IlInjected.Address(RVA = "0x10E0890", Offset = "0x10DF290", VA = "0x1810E0890")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170003A9")]
		public List<GradientKeyDTO> ColorKeys
		{
			[Cpp2IlInjected.Token(Token = "0x6000871")]
			[Cpp2IlInjected.Address(RVA = "0xD11A20", Offset = "0xD10420", VA = "0x180D11A20")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000872")]
			[Cpp2IlInjected.Address(RVA = "0xD17350", Offset = "0xD15D50", VA = "0x180D17350")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000873")]
		[Cpp2IlInjected.Address(RVA = "0x8DC0910", Offset = "0x8DBF310", VA = "0x188DC0910", Slot = "4")]
		public void HHUGNWFYOZL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000874")]
		[Cpp2IlInjected.Address(RVA = "0x8DC0980", Offset = "0x8DBF380", VA = "0x188DC0980")]
		public GradientConfigDTO()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000131")]
	[Utf8JsonSerializable]
	public class AnimationCurveConfigDTO : NSHERHNIAKL<Guid>, MVLXEBCKYBS
	{
		[Cpp2IlInjected.Token(Token = "0x170003AA")]
		public string Name
		{
			[Cpp2IlInjected.Token(Token = "0x6000875")]
			[Cpp2IlInjected.Address(RVA = "0xD117B0", Offset = "0xD101B0", VA = "0x180D117B0", Slot = "5")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000876")]
			[Cpp2IlInjected.Address(RVA = "0xD117C0", Offset = "0xD101C0", VA = "0x180D117C0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170003AB")]
		public Guid Id
		{
			[Cpp2IlInjected.Token(Token = "0x6000877")]
			[Cpp2IlInjected.Address(RVA = "0xDA5E80", Offset = "0xDA4880", VA = "0x180DA5E80", Slot = "4")]
			[CompilerGenerated]
			get
			{
				return default(Guid);
			}
			[Cpp2IlInjected.Token(Token = "0x6000878")]
			[Cpp2IlInjected.Address(RVA = "0xF82330", Offset = "0xF80D30", VA = "0x180F82330")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170003AC")]
		public AnimationCurveDTO AnimationCurve
		{
			[Cpp2IlInjected.Token(Token = "0x6000879")]
			[Cpp2IlInjected.Address(RVA = "0xD11B00", Offset = "0xD10500", VA = "0x180D11B00")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600087A")]
			[Cpp2IlInjected.Address(RVA = "0xD11530", Offset = "0xD0FF30", VA = "0x180D11530")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600087B")]
		[Cpp2IlInjected.Address(RVA = "0x8DBE0B0", Offset = "0x8DBCAB0", VA = "0x188DBE0B0")]
		public AnimationCurveConfigDTO()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000132")]
	[Utf8JsonSerializable]
	public class AnimationCurveDTO
	{
		[Cpp2IlInjected.Token(Token = "0x170003AD")]
		public List<AnimationCurveKeyDTO> CurveKeys
		{
			[Cpp2IlInjected.Token(Token = "0x600087C")]
			[Cpp2IlInjected.Address(RVA = "0xD117B0", Offset = "0xD101B0", VA = "0x180D117B0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600087D")]
			[Cpp2IlInjected.Address(RVA = "0xD117C0", Offset = "0xD101C0", VA = "0x180D117C0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600087E")]
		[Cpp2IlInjected.Address(RVA = "0x8DBE120", Offset = "0x8DBCB20", VA = "0x188DBE120")]
		public AnimationCurveDTO()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000133")]
	[Utf8JsonSerializable]
	public class AnimationCurveKeyDTO
	{
		[Cpp2IlInjected.Token(Token = "0x170003AE")]
		public float Time
		{
			[Cpp2IlInjected.Token(Token = "0x600087F")]
			[Cpp2IlInjected.Address(RVA = "0xDBC130", Offset = "0xDBAB30", VA = "0x180DBC130")]
			[CompilerGenerated]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x6000880")]
			[Cpp2IlInjected.Address(RVA = "0xDFEAF0", Offset = "0xDFD4F0", VA = "0x180DFEAF0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170003AF")]
		public float Value
		{
			[Cpp2IlInjected.Token(Token = "0x6000881")]
			[Cpp2IlInjected.Address(RVA = "0xED9DB0", Offset = "0xED87B0", VA = "0x180ED9DB0")]
			[CompilerGenerated]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x6000882")]
			[Cpp2IlInjected.Address(RVA = "0xED94D0", Offset = "0xED7ED0", VA = "0x180ED94D0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170003B0")]
		public float InSlope
		{
			[Cpp2IlInjected.Token(Token = "0x6000883")]
			[Cpp2IlInjected.Address(RVA = "0xD77800", Offset = "0xD76200", VA = "0x180D77800")]
			[CompilerGenerated]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x6000884")]
			[Cpp2IlInjected.Address(RVA = "0x14214C0", Offset = "0x141FEC0", VA = "0x1814214C0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170003B1")]
		public float OutSlope
		{
			[Cpp2IlInjected.Token(Token = "0x6000885")]
			[Cpp2IlInjected.Address(RVA = "0xD77880", Offset = "0xD76280", VA = "0x180D77880")]
			[CompilerGenerated]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x6000886")]
			[Cpp2IlInjected.Address(RVA = "0x14214D0", Offset = "0x141FED0", VA = "0x1814214D0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170003B2")]
		public float InWeight
		{
			[Cpp2IlInjected.Token(Token = "0x6000887")]
			[Cpp2IlInjected.Address(RVA = "0xD777F0", Offset = "0xD761F0", VA = "0x180D777F0")]
			[CompilerGenerated]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x6000888")]
			[Cpp2IlInjected.Address(RVA = "0x10CE180", Offset = "0x10CCB80", VA = "0x1810CE180")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170003B3")]
		public float OutWeight
		{
			[Cpp2IlInjected.Token(Token = "0x6000889")]
			[Cpp2IlInjected.Address(RVA = "0xD67450", Offset = "0xD65E50", VA = "0x180D67450")]
			[CompilerGenerated]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x600088A")]
			[Cpp2IlInjected.Address(RVA = "0xD67440", Offset = "0xD65E40", VA = "0x180D67440")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170003B4")]
		public int TangentMode
		{
			[Cpp2IlInjected.Token(Token = "0x600088B")]
			[Cpp2IlInjected.Address(RVA = "0xD12BE0", Offset = "0xD115E0", VA = "0x180D12BE0")]
			[CompilerGenerated]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x600088C")]
			[Cpp2IlInjected.Address(RVA = "0xD12C40", Offset = "0xD11640", VA = "0x180D12C40")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170003B5")]
		public int WeightedMode
		{
			[Cpp2IlInjected.Token(Token = "0x600088D")]
			[Cpp2IlInjected.Address(RVA = "0xE24360", Offset = "0xE22D60", VA = "0x180E24360")]
			[CompilerGenerated]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x600088E")]
			[Cpp2IlInjected.Address(RVA = "0x1E2BFE0", Offset = "0x1E2A9E0", VA = "0x181E2BFE0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600088F")]
		[Cpp2IlInjected.Address(RVA = "0xD16C40", Offset = "0xD15640", VA = "0x180D16C40")]
		public AnimationCurveKeyDTO()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000134")]
	[Utf8JsonSerializable]
	public class GradientKeyDTO
	{
		[Cpp2IlInjected.Token(Token = "0x170003B6")]
		public float Time
		{
			[Cpp2IlInjected.Token(Token = "0x6000890")]
			[Cpp2IlInjected.Address(RVA = "0xDBC130", Offset = "0xDBAB30", VA = "0x180DBC130")]
			[CompilerGenerated]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x6000891")]
			[Cpp2IlInjected.Address(RVA = "0xDFEAF0", Offset = "0xDFD4F0", VA = "0x180DFEAF0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170003B7")]
		public ColorConfig Color
		{
			[Cpp2IlInjected.Token(Token = "0x6000892")]
			[Cpp2IlInjected.Address(RVA = "0xD11B30", Offset = "0xD10530", VA = "0x180D11B30")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000893")]
			[Cpp2IlInjected.Address(RVA = "0xD12270", Offset = "0xD10C70", VA = "0x180D12270")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000894")]
		[Cpp2IlInjected.Address(RVA = "0x8DC0A10", Offset = "0x8DBF410", VA = "0x188DC0A10")]
		public GradientKeyDTO()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000135")]
	[Utf8JsonSerializable]
	public class ColorConfig
	{
		[Cpp2IlInjected.Token(Token = "0x170003B8")]
		public float R
		{
			[Cpp2IlInjected.Token(Token = "0x6000895")]
			[Cpp2IlInjected.Address(RVA = "0xDBC130", Offset = "0xDBAB30", VA = "0x180DBC130")]
			[CompilerGenerated]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x6000896")]
			[Cpp2IlInjected.Address(RVA = "0xDFEAF0", Offset = "0xDFD4F0", VA = "0x180DFEAF0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170003B9")]
		public float G
		{
			[Cpp2IlInjected.Token(Token = "0x6000897")]
			[Cpp2IlInjected.Address(RVA = "0xED9DB0", Offset = "0xED87B0", VA = "0x180ED9DB0")]
			[CompilerGenerated]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x6000898")]
			[Cpp2IlInjected.Address(RVA = "0xED94D0", Offset = "0xED7ED0", VA = "0x180ED94D0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170003BA")]
		public float B
		{
			[Cpp2IlInjected.Token(Token = "0x6000899")]
			[Cpp2IlInjected.Address(RVA = "0xD77800", Offset = "0xD76200", VA = "0x180D77800")]
			[CompilerGenerated]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x600089A")]
			[Cpp2IlInjected.Address(RVA = "0x14214C0", Offset = "0x141FEC0", VA = "0x1814214C0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170003BB")]
		public float A
		{
			[Cpp2IlInjected.Token(Token = "0x600089B")]
			[Cpp2IlInjected.Address(RVA = "0xD77880", Offset = "0xD76280", VA = "0x180D77880")]
			[CompilerGenerated]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x600089C")]
			[Cpp2IlInjected.Address(RVA = "0x14214D0", Offset = "0x141FED0", VA = "0x1814214D0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600089D")]
		[Cpp2IlInjected.Address(RVA = "0xD16C40", Offset = "0xD15640", VA = "0x180D16C40")]
		public ColorConfig()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600089E")]
		[Cpp2IlInjected.Address(RVA = "0x8DBEAD0", Offset = "0x8DBD4D0", VA = "0x188DBEAD0")]
		public ColorConfig(float r, float g, float b, float a = 1f)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000136")]
	[Utf8JsonSerializable]
	public class PlayerScaleEffectDTO : NSHERHNIAKL<Guid>, MVLXEBCKYBS
	{
		[Cpp2IlInjected.Token(Token = "0x170003BC")]
		public string Name
		{
			[Cpp2IlInjected.Token(Token = "0x600089F")]
			[Cpp2IlInjected.Address(RVA = "0xD117B0", Offset = "0xD101B0", VA = "0x180D117B0", Slot = "5")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60008A0")]
			[Cpp2IlInjected.Address(RVA = "0xD117C0", Offset = "0xD101C0", VA = "0x180D117C0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170003BD")]
		public Guid Id
		{
			[Cpp2IlInjected.Token(Token = "0x60008A1")]
			[Cpp2IlInjected.Address(RVA = "0xDA5E80", Offset = "0xDA4880", VA = "0x180DA5E80", Slot = "4")]
			[CompilerGenerated]
			get
			{
				return default(Guid);
			}
			[Cpp2IlInjected.Token(Token = "0x60008A2")]
			[Cpp2IlInjected.Address(RVA = "0xF82330", Offset = "0xF80D30", VA = "0x180F82330")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170003BE")]
		public AnimationCurveDTO RemapCurve
		{
			[Cpp2IlInjected.Token(Token = "0x60008A3")]
			[Cpp2IlInjected.Address(RVA = "0xD11B00", Offset = "0xD10500", VA = "0x180D11B00")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60008A4")]
			[Cpp2IlInjected.Address(RVA = "0xD11530", Offset = "0xD0FF30", VA = "0x180D11530")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60008A5")]
		[Cpp2IlInjected.Address(RVA = "0x8DC3CC0", Offset = "0x8DC26C0", VA = "0x188DC3CC0")]
		public PlayerScaleEffectDTO()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000137")]
	[Utf8JsonSerializable]
	public class PlayerTransformationEffectDTO : NSHERHNIAKL<Guid>, MVLXEBCKYBS
	{
		[Cpp2IlInjected.Token(Token = "0x170003BF")]
		public string Name
		{
			[Cpp2IlInjected.Token(Token = "0x60008A6")]
			[Cpp2IlInjected.Address(RVA = "0xD117B0", Offset = "0xD101B0", VA = "0x180D117B0", Slot = "5")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60008A7")]
			[Cpp2IlInjected.Address(RVA = "0xD117C0", Offset = "0xD101C0", VA = "0x180D117C0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170003C0")]
		public Guid Id
		{
			[Cpp2IlInjected.Token(Token = "0x60008A8")]
			[Cpp2IlInjected.Address(RVA = "0xDA5E80", Offset = "0xDA4880", VA = "0x180DA5E80", Slot = "4")]
			[CompilerGenerated]
			get
			{
				return default(Guid);
			}
			[Cpp2IlInjected.Token(Token = "0x60008A9")]
			[Cpp2IlInjected.Address(RVA = "0xF82330", Offset = "0xF80D30", VA = "0x180F82330")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170003C1")]
		public string Key
		{
			[Cpp2IlInjected.Token(Token = "0x60008AA")]
			[Cpp2IlInjected.Address(RVA = "0xD11B00", Offset = "0xD10500", VA = "0x180D11B00")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60008AB")]
			[Cpp2IlInjected.Address(RVA = "0xD11530", Offset = "0xD0FF30", VA = "0x180D11530")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170003C2")]
		public bool CanCrouch
		{
			[Cpp2IlInjected.Token(Token = "0x60008AC")]
			[Cpp2IlInjected.Address(RVA = "0xD6E8A0", Offset = "0xD6D2A0", VA = "0x180D6E8A0")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x60008AD")]
			[Cpp2IlInjected.Address(RVA = "0xD6EFC0", Offset = "0xD6D9C0", VA = "0x180D6EFC0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170003C3")]
		public float MaxWalkSpeedMultiplier
		{
			[Cpp2IlInjected.Token(Token = "0x60008AE")]
			[Cpp2IlInjected.Address(RVA = "0xDE3D10", Offset = "0xDE2710", VA = "0x180DE3D10")]
			[CompilerGenerated]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x60008AF")]
			[Cpp2IlInjected.Address(RVA = "0xDE3D20", Offset = "0xDE2720", VA = "0x180DE3D20")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170003C4")]
		public PlayerTransformationFirstPersonEffect FirstPersonEffect
		{
			[Cpp2IlInjected.Token(Token = "0x60008B0")]
			[Cpp2IlInjected.Address(RVA = "0xD3D030", Offset = "0xD3BA30", VA = "0x180D3D030")]
			[CompilerGenerated]
			get
			{
				return default(PlayerTransformationFirstPersonEffect);
			}
			[Cpp2IlInjected.Token(Token = "0x60008B1")]
			[Cpp2IlInjected.Address(RVA = "0xD3D040", Offset = "0xD3BA40", VA = "0x180D3D040")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170003C5")]
		public PlayerTransformationKeyType KeyType
		{
			[Cpp2IlInjected.Token(Token = "0x60008B2")]
			[Cpp2IlInjected.Address(RVA = "0x1B9BC60", Offset = "0x1B9A660", VA = "0x181B9BC60")]
			[CompilerGenerated]
			get
			{
				return default(PlayerTransformationKeyType);
			}
			[Cpp2IlInjected.Token(Token = "0x60008B3")]
			[Cpp2IlInjected.Address(RVA = "0x10511F0", Offset = "0x104FBF0", VA = "0x1810511F0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60008B4")]
		[Cpp2IlInjected.Address(RVA = "0xD16C40", Offset = "0xD15640", VA = "0x180D16C40")]
		public PlayerTransformationEffectDTO()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000138")]
	[Utf8JsonSerializable]
	public class PlayerMovementSpeedEffectDTO : NSHERHNIAKL<Guid>, MVLXEBCKYBS
	{
		[Cpp2IlInjected.Token(Token = "0x170003C6")]
		public string Name
		{
			[Cpp2IlInjected.Token(Token = "0x60008B5")]
			[Cpp2IlInjected.Address(RVA = "0xD117B0", Offset = "0xD101B0", VA = "0x180D117B0", Slot = "5")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60008B6")]
			[Cpp2IlInjected.Address(RVA = "0xD117C0", Offset = "0xD101C0", VA = "0x180D117C0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170003C7")]
		public Guid Id
		{
			[Cpp2IlInjected.Token(Token = "0x60008B7")]
			[Cpp2IlInjected.Address(RVA = "0xDA5E80", Offset = "0xDA4880", VA = "0x180DA5E80", Slot = "4")]
			[CompilerGenerated]
			get
			{
				return default(Guid);
			}
			[Cpp2IlInjected.Token(Token = "0x60008B8")]
			[Cpp2IlInjected.Address(RVA = "0xF82330", Offset = "0xF80D30", VA = "0x180F82330")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170003C8")]
		public float WalkSpeedMultiplier
		{
			[Cpp2IlInjected.Token(Token = "0x60008B9")]
			[Cpp2IlInjected.Address(RVA = "0x10DD6F0", Offset = "0x10DC0F0", VA = "0x1810DD6F0")]
			[CompilerGenerated]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x60008BA")]
			[Cpp2IlInjected.Address(RVA = "0x1368DF0", Offset = "0x13677F0", VA = "0x181368DF0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170003C9")]
		public float? CrouchSpeedMultiplier
		{
			[Cpp2IlInjected.Token(Token = "0x60008BB")]
			[Cpp2IlInjected.Address(RVA = "0x141BB40", Offset = "0x141A540", VA = "0x18141BB40")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60008BC")]
			[Cpp2IlInjected.Address(RVA = "0x141BB70", Offset = "0x141A570", VA = "0x18141BB70")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170003CA")]
		public float? ProneSpeedMultiplier
		{
			[Cpp2IlInjected.Token(Token = "0x60008BD")]
			[Cpp2IlInjected.Address(RVA = "0xE3F100", Offset = "0xE3DB00", VA = "0x180E3F100")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60008BE")]
			[Cpp2IlInjected.Address(RVA = "0xE3F140", Offset = "0xE3DB40", VA = "0x180E3F140")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170003CB")]
		public float TeleportCooldownTimerMultiplier
		{
			[Cpp2IlInjected.Token(Token = "0x60008BF")]
			[Cpp2IlInjected.Address(RVA = "0xD40250", Offset = "0xD3EC50", VA = "0x180D40250")]
			[CompilerGenerated]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x60008C0")]
			[Cpp2IlInjected.Address(RVA = "0xD3FF80", Offset = "0xD3E980", VA = "0x180D3FF80")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170003CC")]
		public float? TeleportCrouchCooldownTimerMultiplier
		{
			[Cpp2IlInjected.Token(Token = "0x60008C1")]
			[Cpp2IlInjected.Address(RVA = "0xD11A30", Offset = "0xD10430", VA = "0x180D11A30")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60008C2")]
			[Cpp2IlInjected.Address(RVA = "0xFFBC20", Offset = "0xFFA620", VA = "0x180FFBC20")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170003CD")]
		public float? TeleportProneCooldownTimerMultiplier
		{
			[Cpp2IlInjected.Token(Token = "0x60008C3")]
			[Cpp2IlInjected.Address(RVA = "0xD122E0", Offset = "0xD10CE0", VA = "0x180D122E0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60008C4")]
			[Cpp2IlInjected.Address(RVA = "0x1440140", Offset = "0x143EB40", VA = "0x181440140")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60008C5")]
		[Cpp2IlInjected.Address(RVA = "0x8DC3CA0", Offset = "0x8DC26A0", VA = "0x188DC3CA0")]
		public PlayerMovementSpeedEffectDTO()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000139")]
	[Utf8JsonSerializable]
	public class TextureEffectDTO : NSHERHNIAKL<Guid>, MVLXEBCKYBS
	{
		[Cpp2IlInjected.Token(Token = "0x170003CE")]
		public string Name
		{
			[Cpp2IlInjected.Token(Token = "0x60008C6")]
			[Cpp2IlInjected.Address(RVA = "0xD117B0", Offset = "0xD101B0", VA = "0x180D117B0", Slot = "5")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60008C7")]
			[Cpp2IlInjected.Address(RVA = "0xD117C0", Offset = "0xD101C0", VA = "0x180D117C0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170003CF")]
		public Guid Id
		{
			[Cpp2IlInjected.Token(Token = "0x60008C8")]
			[Cpp2IlInjected.Address(RVA = "0xDA5E80", Offset = "0xDA4880", VA = "0x180DA5E80", Slot = "4")]
			[CompilerGenerated]
			get
			{
				return default(Guid);
			}
			[Cpp2IlInjected.Token(Token = "0x60008C9")]
			[Cpp2IlInjected.Address(RVA = "0xF82330", Offset = "0xF80D30", VA = "0x180F82330")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170003D0")]
		public string MaskTextureName
		{
			[Cpp2IlInjected.Token(Token = "0x60008CA")]
			[Cpp2IlInjected.Address(RVA = "0xD11B00", Offset = "0xD10500", VA = "0x180D11B00")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60008CB")]
			[Cpp2IlInjected.Address(RVA = "0xD11530", Offset = "0xD0FF30", VA = "0x180D11530")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170003D1")]
		public string LUTTextureName
		{
			[Cpp2IlInjected.Token(Token = "0x60008CC")]
			[Cpp2IlInjected.Address(RVA = "0xD11A20", Offset = "0xD10420", VA = "0x180D11A20")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60008CD")]
			[Cpp2IlInjected.Address(RVA = "0xD17350", Offset = "0xD15D50", VA = "0x180D17350")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170003D2")]
		public bool UseNormalFade
		{
			[Cpp2IlInjected.Token(Token = "0x60008CE")]
			[Cpp2IlInjected.Address(RVA = "0xD3D030", Offset = "0xD3BA30", VA = "0x180D3D030")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x60008CF")]
			[Cpp2IlInjected.Address(RVA = "0xD3D040", Offset = "0xD3BA40", VA = "0x180D3D040")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170003D3")]
		public float GlobalIntensity
		{
			[Cpp2IlInjected.Token(Token = "0x60008D0")]
			[Cpp2IlInjected.Address(RVA = "0xD40250", Offset = "0xD3EC50", VA = "0x180D40250")]
			[CompilerGenerated]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x60008D1")]
			[Cpp2IlInjected.Address(RVA = "0xD3FF80", Offset = "0xD3E980", VA = "0x180D3FF80")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170003D4")]
		public TextureChannelDTO Vfx1
		{
			[Cpp2IlInjected.Token(Token = "0x60008D2")]
			[Cpp2IlInjected.Address(RVA = "0xD11A30", Offset = "0xD10430", VA = "0x180D11A30")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60008D3")]
			[Cpp2IlInjected.Address(RVA = "0xD12260", Offset = "0xD10C60", VA = "0x180D12260")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170003D5")]
		public TextureChannelDTO Vfx2
		{
			[Cpp2IlInjected.Token(Token = "0x60008D4")]
			[Cpp2IlInjected.Address(RVA = "0xD122E0", Offset = "0xD10CE0", VA = "0x180D122E0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60008D5")]
			[Cpp2IlInjected.Address(RVA = "0xD12290", Offset = "0xD10C90", VA = "0x180D12290")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170003D6")]
		public TextureChannelDTO Vfx3
		{
			[Cpp2IlInjected.Token(Token = "0x60008D6")]
			[Cpp2IlInjected.Address(RVA = "0xD11B20", Offset = "0xD10520", VA = "0x180D11B20")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60008D7")]
			[Cpp2IlInjected.Address(RVA = "0xD11900", Offset = "0xD10300", VA = "0x180D11900")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170003D7")]
		public TextureChannelDTO Vfx4
		{
			[Cpp2IlInjected.Token(Token = "0x60008D8")]
			[Cpp2IlInjected.Address(RVA = "0xD11940", Offset = "0xD10340", VA = "0x180D11940")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60008D9")]
			[Cpp2IlInjected.Address(RVA = "0xD122A0", Offset = "0xD10CA0", VA = "0x180D122A0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170003D8")]
		public Vector4Dto LUT_ST
		{
			[Cpp2IlInjected.Token(Token = "0x60008DA")]
			[Cpp2IlInjected.Address(RVA = "0xD15610", Offset = "0xD14010", VA = "0x180D15610")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60008DB")]
			[Cpp2IlInjected.Address(RVA = "0xD15600", Offset = "0xD14000", VA = "0x180D15600")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60008DC")]
		[Cpp2IlInjected.Address(RVA = "0x8DC6D50", Offset = "0x8DC5750", VA = "0x188DC6D50")]
		public TextureEffectDTO()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200013A")]
	[Utf8JsonSerializable]
	public class TextureChannelDTO
	{
		[Cpp2IlInjected.Token(Token = "0x170003D9")]
		public Vector2Dto Scroll
		{
			[Cpp2IlInjected.Token(Token = "0x60008DD")]
			[Cpp2IlInjected.Address(RVA = "0xD117B0", Offset = "0xD101B0", VA = "0x180D117B0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60008DE")]
			[Cpp2IlInjected.Address(RVA = "0xD117C0", Offset = "0xD101C0", VA = "0x180D117C0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170003DA")]
		public float ColorIntensity
		{
			[Cpp2IlInjected.Token(Token = "0x60008DF")]
			[Cpp2IlInjected.Address(RVA = "0xD77800", Offset = "0xD76200", VA = "0x180D77800")]
			[CompilerGenerated]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x60008E0")]
			[Cpp2IlInjected.Address(RVA = "0x14214C0", Offset = "0x141FEC0", VA = "0x1814214C0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170003DB")]
		public float AlphaIntensity
		{
			[Cpp2IlInjected.Token(Token = "0x60008E1")]
			[Cpp2IlInjected.Address(RVA = "0xD77880", Offset = "0xD76280", VA = "0x180D77880")]
			[CompilerGenerated]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x60008E2")]
			[Cpp2IlInjected.Address(RVA = "0x14214D0", Offset = "0x141FED0", VA = "0x1814214D0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170003DC")]
		public Vector4Dto ST
		{
			[Cpp2IlInjected.Token(Token = "0x60008E3")]
			[Cpp2IlInjected.Address(RVA = "0xD12BC0", Offset = "0xD115C0", VA = "0x180D12BC0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60008E4")]
			[Cpp2IlInjected.Address(RVA = "0xD11520", Offset = "0xD0FF20", VA = "0x180D11520")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60008E5")]
		[Cpp2IlInjected.Address(RVA = "0x8DC6CE0", Offset = "0x8DC56E0", VA = "0x188DC6CE0")]
		public TextureChannelDTO()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200013B")]
	[Utf8JsonSerializable]
	public class Vector2Dto
	{
		[Cpp2IlInjected.Token(Token = "0x170003DD")]
		public float X
		{
			[Cpp2IlInjected.Token(Token = "0x60008E6")]
			[Cpp2IlInjected.Address(RVA = "0xDBC130", Offset = "0xDBAB30", VA = "0x180DBC130")]
			[CompilerGenerated]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x60008E7")]
			[Cpp2IlInjected.Address(RVA = "0xDFEAF0", Offset = "0xDFD4F0", VA = "0x180DFEAF0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170003DE")]
		public float Y
		{
			[Cpp2IlInjected.Token(Token = "0x60008E8")]
			[Cpp2IlInjected.Address(RVA = "0xED9DB0", Offset = "0xED87B0", VA = "0x180ED9DB0")]
			[CompilerGenerated]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x60008E9")]
			[Cpp2IlInjected.Address(RVA = "0xED94D0", Offset = "0xED7ED0", VA = "0x180ED94D0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60008EA")]
		[Cpp2IlInjected.Address(RVA = "0xD16C40", Offset = "0xD15640", VA = "0x180D16C40")]
		public Vector2Dto()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60008EB")]
		[Cpp2IlInjected.Address(RVA = "0x640C5A0", Offset = "0x640AFA0", VA = "0x18640C5A0")]
		public Vector2Dto(float x, float y)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200013C")]
	[Utf8JsonSerializable]
	public class Vector4Dto : Vector2Dto
	{
		[Cpp2IlInjected.Token(Token = "0x170003DF")]
		public float Z
		{
			[Cpp2IlInjected.Token(Token = "0x60008EC")]
			[Cpp2IlInjected.Address(RVA = "0xD77800", Offset = "0xD76200", VA = "0x180D77800")]
			[CompilerGenerated]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x60008ED")]
			[Cpp2IlInjected.Address(RVA = "0x14214C0", Offset = "0x141FEC0", VA = "0x1814214C0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170003E0")]
		public float W
		{
			[Cpp2IlInjected.Token(Token = "0x60008EE")]
			[Cpp2IlInjected.Address(RVA = "0xD77880", Offset = "0xD76280", VA = "0x180D77880")]
			[CompilerGenerated]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x60008EF")]
			[Cpp2IlInjected.Address(RVA = "0x14214D0", Offset = "0x141FED0", VA = "0x1814214D0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60008F0")]
		[Cpp2IlInjected.Address(RVA = "0xD16C40", Offset = "0xD15640", VA = "0x180D16C40")]
		public Vector4Dto()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60008F1")]
		[Cpp2IlInjected.Address(RVA = "0x8DBEAD0", Offset = "0x8DBD4D0", VA = "0x188DBEAD0")]
		public Vector4Dto(float x, float y, float z, float w)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200013D")]
	public enum AvatarItemEffectChannel : byte
	{
		[Cpp2IlInjected.Token(Token = "0x4000688")]
		Invalid,
		[Cpp2IlInjected.Token(Token = "0x4000689")]
		Emission,
		[Cpp2IlInjected.Token(Token = "0x400068A")]
		HairColor,
		[Cpp2IlInjected.Token(Token = "0x400068B")]
		PlayerHeadScale,
		[Cpp2IlInjected.Token(Token = "0x400068C")]
		Aura,
		[Cpp2IlInjected.Token(Token = "0x400068D")]
		Texture,
		[Cpp2IlInjected.Token(Token = "0x400068E")]
		PlayerAvatarScale,
		[Cpp2IlInjected.Token(Token = "0x400068F")]
		PlayerMovementSpeed,
		[Cpp2IlInjected.Token(Token = "0x4000690")]
		PlayerTransformation
	}
	[Cpp2IlInjected.Token(Token = "0x200013E")]
	public enum DriverType : byte
	{
		[Cpp2IlInjected.Token(Token = "0x4000692")]
		Invalid,
		[Cpp2IlInjected.Token(Token = "0x4000693")]
		PlayerVoiceInput,
		[Cpp2IlInjected.Token(Token = "0x4000694")]
		PlayerVelocity,
		[Cpp2IlInjected.Token(Token = "0x4000695")]
		AnimationCurve,
		[Cpp2IlInjected.Token(Token = "0x4000696")]
		HighFiveCount,
		[Cpp2IlInjected.Token(Token = "0x4000697")]
		AlwaysOn
	}
	[Cpp2IlInjected.Token(Token = "0x200013F")]
	public enum GradientType : byte
	{
		[Cpp2IlInjected.Token(Token = "0x4000699")]
		Invalid,
		[Cpp2IlInjected.Token(Token = "0x400069A")]
		Time,
		[Cpp2IlInjected.Token(Token = "0x400069B")]
		ValueRamp
	}
	[Cpp2IlInjected.Token(Token = "0x2000140")]
	public enum PlayerTransformationKeyType : byte
	{
		[Cpp2IlInjected.Token(Token = "0x400069D")]
		LocalAddress,
		[Cpp2IlInjected.Token(Token = "0x400069E")]
		LocalGuid
	}
	[Cpp2IlInjected.Token(Token = "0x2000141")]
	public enum PlayerTransformationFirstPersonEffect : byte
	{
		[Cpp2IlInjected.Token(Token = "0x40006A0")]
		None,
		[Cpp2IlInjected.Token(Token = "0x40006A1")]
		Hidden
	}
	[Cpp2IlInjected.Token(Token = "0x2000142")]
	public static class MJHSQUBEEEP
	{
		[Cpp2IlInjected.Token(Token = "0x40006A2")]
		public static readonly AvatarItemEffectChannel[] IFEMOURDRJD;

		[Cpp2IlInjected.Token(Token = "0x40006A3")]
		public static readonly AvatarItemEffectChannel[] DPLACGMQPRJ;

		[Cpp2IlInjected.Token(Token = "0x40006A4")]
		public static readonly DriverType[] IETHZSBUGPK;

		[Cpp2IlInjected.Token(Token = "0x40006A5")]
		public static readonly DriverType[] PXDJBCAWNLK;

		[Cpp2IlInjected.Token(Token = "0x60008F2")]
		[Cpp2IlInjected.Address(RVA = "0x8DC2CB0", Offset = "0x8DC16B0", VA = "0x188DC2CB0")]
		public static bool SVOWKCZWSXP(this AvatarItemEffectChannel a)
		{
			return default(bool);
		}
	}
}
namespace RecNet.RoomBoosts
{
	[Cpp2IlInjected.Token(Token = "0x2000144")]
	public interface AWOXKDSWRPT
	{
		[Cpp2IlInjected.Token(Token = "0x1400000B")]
		event Action<long, int> TQJHSCYAGUZ;

		[Cpp2IlInjected.Token(Token = "0x1400000C")]
		event Action<long> LWRNYLSZERB;

		[Cpp2IlInjected.Token(Token = "0x60008FC")]
		[Cpp2IlInjected.Address(Slot = "4")]
		Task<int> FNCXIWLZOOU(long a, bool b = false, [Optional] CancellationToken c);

		[Cpp2IlInjected.Token(Token = "0x60008FD")]
		[Cpp2IlInjected.Address(Slot = "5")]
		Task<int> BAVETRZTWUZ(long a, int b, bool c = false, [Optional] CancellationToken d);

		[Cpp2IlInjected.Token(Token = "0x60008FE")]
		[Cpp2IlInjected.Address(Slot = "6")]
		Task<Dictionary<int, int>> HHTBDEMWDRP(long a, IEnumerable<int> b, bool c = false, [Optional] CancellationToken d);
	}
	[Cpp2IlInjected.Token(Token = "0x2000145")]
	public interface IRVPZJWCZQP
	{
		[Cpp2IlInjected.Token(Token = "0x170003E1")]
		RoomBoostEnabledConfig RTDIMNPOJOH
		{
			[Cpp2IlInjected.Token(Token = "0x6000900")]
			[Cpp2IlInjected.Address(Slot = "1")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x1400000D")]
		event Action<RoomBoostEnabledConfig> XLUWFBJINMQ;

		[Cpp2IlInjected.Token(Token = "0x60008FF")]
		[Cpp2IlInjected.Address(Slot = "0")]
		RoomBoostEnabledState DNPLNSKAPIL([Optional] long? a);
	}
	[Cpp2IlInjected.Token(Token = "0x2000146")]
	public enum RoomBoostEnabledState
	{
		[Cpp2IlInjected.Token(Token = "0x40006A8")]
		Invalid,
		[Cpp2IlInjected.Token(Token = "0x40006A9")]
		Ok,
		[Cpp2IlInjected.Token(Token = "0x40006AA")]
		DisabledGlobally,
		[Cpp2IlInjected.Token(Token = "0x40006AB")]
		DisabledForRoom
	}
	[Cpp2IlInjected.Token(Token = "0x2000147")]
	public static class RLRWZXMWXNQ
	{
		[Cpp2IlInjected.Token(Token = "0x6000903")]
		[Cpp2IlInjected.Address(RVA = "0x1567400", Offset = "0x1565E00", VA = "0x181567400")]
		public static bool VZNLOAQTCEZ(this RoomBoostEnabledState a)
		{
			return default(bool);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000148")]
	public struct RoomBoostEnabledConfig
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40006AC")]
		private readonly bool isValid;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1")]
		[Cpp2IlInjected.Token(Token = "0x40006AD")]
		private readonly bool roomBoostsEnabledGlobally;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2")]
		[Cpp2IlInjected.Token(Token = "0x40006AE")]
		private readonly bool checkRoomIds;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40006AF")]
		private readonly Func<long, bool> isRoomValidFunc;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40006B0")]
		private readonly HashSet<long> roomBoostsEnabledForRooms;

		[Cpp2IlInjected.Token(Token = "0x6000904")]
		[Cpp2IlInjected.Address(RVA = "0x8DC4490", Offset = "0x8DC2E90", VA = "0x188DC4490")]
		public RoomBoostEnabledConfig(bool roomBoostsEnabledGlobally, bool checkRoomIds, HashSet<long> roomBoostsEnabledForRooms, Func<long, bool> isRoomValidFunc)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000905")]
		[Cpp2IlInjected.Address(RVA = "0x8DC4120", Offset = "0x8DC2B20", VA = "0x188DC4120")]
		public RoomBoostEnabledState DNPLNSKAPIL(long? a)
		{
			return default(RoomBoostEnabledState);
		}

		[Cpp2IlInjected.Token(Token = "0x6000906")]
		[Cpp2IlInjected.Address(RVA = "0x8DC4390", Offset = "0x8DC2D90", VA = "0x188DC4390")]
		public bool VULSEZHLAXS(RoomBoostEnabledConfig a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000907")]
		[Cpp2IlInjected.Address(RVA = "0x8DC4240", Offset = "0x8DC2C40", VA = "0x188DC4240", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}
}
namespace RecNet.Tags
{
	[Cpp2IlInjected.Token(Token = "0x2000149")]
	public enum TagType
	{
		[Cpp2IlInjected.Token(Token = "0x40006B2")]
		General,
		[Cpp2IlInjected.Token(Token = "0x40006B3")]
		Auto,
		[Cpp2IlInjected.Token(Token = "0x40006B4")]
		AGOnly,
		[Cpp2IlInjected.Token(Token = "0x40006B5")]
		Banned
	}
	[Cpp2IlInjected.Token(Token = "0x200014A")]
	public enum TagStatus
	{
		[Cpp2IlInjected.Token(Token = "0x40006B7")]
		Success,
		[Cpp2IlInjected.Token(Token = "0x40006B8")]
		TooManyTags,
		[Cpp2IlInjected.Token(Token = "0x40006B9")]
		TagUseRestricted,
		[Cpp2IlInjected.Token(Token = "0x40006BA")]
		InvalidTag,
		[Cpp2IlInjected.Token(Token = "0x40006BB")]
		InappropriateTag,
		[Cpp2IlInjected.Token(Token = "0x40006BC")]
		TagTooLong,
		[Cpp2IlInjected.Token(Token = "0x40006BD")]
		TagNotFound,
		[Cpp2IlInjected.Token(Token = "0x40006BE")]
		TagAlreadyExists,
		[Cpp2IlInjected.Token(Token = "0x40006BF")]
		NoChange,
		[Cpp2IlInjected.Token(Token = "0x40006C0")]
		TagRepeated,
		[Cpp2IlInjected.Token(Token = "0x40006C1")]
		LacksPermission,
		[Cpp2IlInjected.Token(Token = "0x40006C2")]
		RoomDoesNotExist,
		[Cpp2IlInjected.Token(Token = "0x40006C3")]
		InventionDoesNotExist,
		[Cpp2IlInjected.Token(Token = "0x40006C4")]
		ReservedWordViolation
	}
	[Cpp2IlInjected.Token(Token = "0x200014B")]
	[Utf8JsonSerializable]
	public class ModifyTagsResponse
	{
		[Cpp2IlInjected.Token(Token = "0x170003E2")]
		public TagStatus Result
		{
			[Cpp2IlInjected.Token(Token = "0x6000908")]
			[Cpp2IlInjected.Address(RVA = "0xD0F110", Offset = "0xD0DB10", VA = "0x180D0F110")]
			[CompilerGenerated]
			get
			{
				return default(TagStatus);
			}
			[Cpp2IlInjected.Token(Token = "0x6000909")]
			[Cpp2IlInjected.Address(RVA = "0xD12F30", Offset = "0xD11930", VA = "0x180D12F30")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170003E3")]
		public List<string> Tags
		{
			[Cpp2IlInjected.Token(Token = "0x600090A")]
			[Cpp2IlInjected.Address(RVA = "0xD11B30", Offset = "0xD10530", VA = "0x180D11B30")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600090B")]
			[Cpp2IlInjected.Address(RVA = "0xD12270", Offset = "0xD10C70", VA = "0x180D12270")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600090C")]
		[Cpp2IlInjected.Address(RVA = "0x8DC3250", Offset = "0x8DC1C50", VA = "0x188DC3250")]
		public string GBXIEMANWLI(int a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600090D")]
		[Cpp2IlInjected.Address(RVA = "0xD16C40", Offset = "0xD15640", VA = "0x180D16C40")]
		public ModifyTagsResponse()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200014C")]
	[Utf8JsonSerializable]
	public class TagDTO
	{
		[Cpp2IlInjected.Token(Token = "0x170003E4")]
		public string Tag
		{
			[Cpp2IlInjected.Token(Token = "0x600090E")]
			[Cpp2IlInjected.Address(RVA = "0xD117B0", Offset = "0xD101B0", VA = "0x180D117B0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600090F")]
			[Cpp2IlInjected.Address(RVA = "0xD117C0", Offset = "0xD101C0", VA = "0x180D117C0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170003E5")]
		public TagType Type
		{
			[Cpp2IlInjected.Token(Token = "0x6000910")]
			[Cpp2IlInjected.Address(RVA = "0xD17340", Offset = "0xD15D40", VA = "0x180D17340")]
			[CompilerGenerated]
			get
			{
				return default(TagType);
			}
			[Cpp2IlInjected.Token(Token = "0x6000911")]
			[Cpp2IlInjected.Address(RVA = "0xD17360", Offset = "0xD15D60", VA = "0x180D17360")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000912")]
		[Cpp2IlInjected.Address(RVA = "0xD16C40", Offset = "0xD15640", VA = "0x180D16C40")]
		public TagDTO()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200014D")]
	public static class VWCFAYQHEJZ
	{
		[Cpp2IlInjected.Token(Token = "0x40006C9")]
		public const string XKTGKNPAIKB = "costume";

		[Cpp2IlInjected.Token(Token = "0x40006CA")]
		public const string BHGFSVPETYN = "gadget";

		[Cpp2IlInjected.Token(Token = "0x40006CB")]
		public const string BAVWEEZEEUE = "holotar";

		[Cpp2IlInjected.Token(Token = "0x40006CC")]
		public const string VYJKNFBCCWA = "large";

		[Cpp2IlInjected.Token(Token = "0x40006CD")]
		public const string EKCOPMNJIPI = "medium";

		[Cpp2IlInjected.Token(Token = "0x40006CE")]
		public const string PQWGCFLVGHW = "small";

		[Cpp2IlInjected.Token(Token = "0x40006CF")]
		public const string DQTTDRRPWOU = "sound";

		[Cpp2IlInjected.Token(Token = "0x40006D0")]
		public const string KCOBTVABMJB = "dormanchor";

		[Cpp2IlInjected.Token(Token = "0x40006D1")]
		public const string OQAADVQRLQE = "reccenteranchor";

		[Cpp2IlInjected.Token(Token = "0x40006D2")]
		public const string PGGOWEZJGXA = "r2";

		[Cpp2IlInjected.Token(Token = "0x170003E6")]
		public static List<string> QPGITVVLVHK
		{
			[Cpp2IlInjected.Token(Token = "0x6000913")]
			[Cpp2IlInjected.Address(RVA = "0x8DCA760", Offset = "0x8DC9160", VA = "0x188DCA760")]
			get
			{
				return null;
			}
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200014E")]
	public static class RKUQIVJRTUY
	{
		[Cpp2IlInjected.Token(Token = "0x40006D3")]
		public const string GUFKLNJGIIZ = "beta";

		[Cpp2IlInjected.Token(Token = "0x40006D4")]
		public const string GCGJAJLPNNU = "limitsv2";
	}
	[Cpp2IlInjected.Token(Token = "0x200014F")]
	[Utf8JsonSerializable]
	public class GetFiltersResponse
	{
		[Cpp2IlInjected.Token(Token = "0x170003E7")]
		public List<string> PinnedFilters
		{
			[Cpp2IlInjected.Token(Token = "0x6000914")]
			[Cpp2IlInjected.Address(RVA = "0xD117B0", Offset = "0xD101B0", VA = "0x180D117B0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000915")]
			[Cpp2IlInjected.Address(RVA = "0xD117C0", Offset = "0xD101C0", VA = "0x180D117C0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170003E8")]
		public List<string> PopularFilters
		{
			[Cpp2IlInjected.Token(Token = "0x6000916")]
			[Cpp2IlInjected.Address(RVA = "0xD11B30", Offset = "0xD10530", VA = "0x180D11B30")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000917")]
			[Cpp2IlInjected.Address(RVA = "0xD12270", Offset = "0xD10C70", VA = "0x180D12270")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170003E9")]
		public List<string> TrendingFilters
		{
			[Cpp2IlInjected.Token(Token = "0x6000918")]
			[Cpp2IlInjected.Address(RVA = "0xD12BC0", Offset = "0xD115C0", VA = "0x180D12BC0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000919")]
			[Cpp2IlInjected.Address(RVA = "0xD11520", Offset = "0xD0FF20", VA = "0x180D11520")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600091A")]
		[Cpp2IlInjected.Address(RVA = "0xD16C40", Offset = "0xD15640", VA = "0x180D16C40")]
		public GetFiltersResponse()
		{
		}
	}
}
namespace RecNet.NetworkSimulator
{
	[Cpp2IlInjected.Token(Token = "0x2000150")]
	public class FilterKey : IEquatable<FilterKey>
	{
		[Cpp2IlInjected.Token(Token = "0x170003EA")]
		[CompilerGenerated]
		protected virtual Type VZLUXMAJKRJ
		{
			[Cpp2IlInjected.Token(Token = "0x600091C")]
			[Cpp2IlInjected.Address(RVA = "0x8DC0210", Offset = "0x8DBEC10", VA = "0x188DC0210", Slot = "5")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170003EB")]
		public Service? JJHUBYNXFWQ
		{
			[Cpp2IlInjected.Token(Token = "0x600091D")]
			[Cpp2IlInjected.Address(RVA = "0xD117B0", Offset = "0xD101B0", VA = "0x180D117B0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600091E")]
			[Cpp2IlInjected.Address(RVA = "0xED90B0", Offset = "0xED7AB0", VA = "0x180ED90B0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170003EC")]
		public HttpMethod? NPDLHITIOSQ
		{
			[Cpp2IlInjected.Token(Token = "0x600091F")]
			[Cpp2IlInjected.Address(RVA = "0xD11B30", Offset = "0xD10530", VA = "0x180D11B30")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000920")]
			[Cpp2IlInjected.Address(RVA = "0xD12270", Offset = "0xD10C70", VA = "0x180D12270")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170003ED")]
		public string? FZRYBYYQIMU
		{
			[Cpp2IlInjected.Token(Token = "0x6000921")]
			[Cpp2IlInjected.Address(RVA = "0xD12BC0", Offset = "0xD115C0", VA = "0x180D12BC0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000922")]
			[Cpp2IlInjected.Address(RVA = "0xD11520", Offset = "0xD0FF20", VA = "0x180D11520")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600091B")]
		[Cpp2IlInjected.Address(RVA = "0x8DC04E0", Offset = "0x8DBEEE0", VA = "0x188DC04E0")]
		public FilterKey(Service? Service, HttpMethod? Method, string? RequestUriPrefix)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000923")]
		[Cpp2IlInjected.Address(RVA = "0x8DC02A0", Offset = "0x8DBECA0", VA = "0x188DC02A0", Slot = "3")]
		[CompilerGenerated]
		public override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000924")]
		[Cpp2IlInjected.Address(RVA = "0x8DC0390", Offset = "0x8DBED90", VA = "0x188DC0390", Slot = "6")]
		[CompilerGenerated]
		protected virtual bool WJJAKQGJTCH(StringBuilder a)
		{
			return default(bool);
		}

		[SpecialName]
		[Cpp2IlInjected.Token(Token = "0x6000925")]
		[Cpp2IlInjected.Address(RVA = "0x12EAD60", Offset = "0x12E9760", VA = "0x1812EAD60")]
		[CompilerGenerated]
		public static bool CYAUITUETAA(FilterKey? a, FilterKey? b)
		{
			return default(bool);
		}

		[SpecialName]
		[Cpp2IlInjected.Token(Token = "0x6000926")]
		[Cpp2IlInjected.Address(RVA = "0x12EB0B0", Offset = "0x12E9AB0", VA = "0x1812EB0B0")]
		[CompilerGenerated]
		public static bool ITVTPRNZGNV(FilterKey? a, FilterKey? b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000927")]
		[Cpp2IlInjected.Address(RVA = "0x8DC00A0", Offset = "0x8DBEAA0", VA = "0x188DC00A0", Slot = "2")]
		[CompilerGenerated]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000928")]
		[Cpp2IlInjected.Address(RVA = "0x8DBFE80", Offset = "0x8DBE880", VA = "0x188DBFE80", Slot = "0")]
		[CompilerGenerated]
		public override bool Equals(object? obj)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000929")]
		[Cpp2IlInjected.Address(RVA = "0x8DBFF10", Offset = "0x8DBE910", VA = "0x188DBFF10", Slot = "7")]
		[CompilerGenerated]
		public virtual bool Equals(FilterKey? other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600092A")]
		[Cpp2IlInjected.Address(RVA = "0x8DBFDF0", Offset = "0x8DBE7F0", VA = "0x188DBFDF0", Slot = "8")]
		[CompilerGenerated]
		public virtual FilterKey CXDOYZBTDGW()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600092B")]
		[Cpp2IlInjected.Address(RVA = "0x8DC0480", Offset = "0x8DBEE80", VA = "0x188DC0480")]
		[CompilerGenerated]
		protected FilterKey(FilterKey original)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600092C")]
		[Cpp2IlInjected.Address(RVA = "0x8DC0260", Offset = "0x8DBEC60", VA = "0x188DC0260")]
		[CompilerGenerated]
		public void OGNPAZKLJRJ([Out] Service? a, [Out] HttpMethod? b, [Out] string? c)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000151")]
	public class FilterAction : IEquatable<FilterAction>
	{
		[Cpp2IlInjected.Token(Token = "0x170003EE")]
		[CompilerGenerated]
		protected virtual Type VZLUXMAJKRJ
		{
			[Cpp2IlInjected.Token(Token = "0x600092E")]
			[Cpp2IlInjected.Address(RVA = "0x8DBFBA0", Offset = "0x8DBE5A0", VA = "0x188DBFBA0", Slot = "5")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170003EF")]
		public int KBLLFCXRSJH
		{
			[Cpp2IlInjected.Token(Token = "0x600092F")]
			[Cpp2IlInjected.Address(RVA = "0xD0F110", Offset = "0xD0DB10", VA = "0x180D0F110")]
			[CompilerGenerated]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x6000930")]
			[Cpp2IlInjected.Address(RVA = "0xD12F30", Offset = "0xD11930", VA = "0x180D12F30")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170003F0")]
		public FailureModes JSZQFCEBEOG
		{
			[Cpp2IlInjected.Token(Token = "0x6000931")]
			[Cpp2IlInjected.Address(RVA = "0xE073A0", Offset = "0xE05DA0", VA = "0x180E073A0")]
			[CompilerGenerated]
			get
			{
				return default(FailureModes);
			}
			[Cpp2IlInjected.Token(Token = "0x6000932")]
			[Cpp2IlInjected.Address(RVA = "0xE073B0", Offset = "0xE05DB0", VA = "0x180E073B0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600092D")]
		[Cpp2IlInjected.Address(RVA = "0x8DBFDE0", Offset = "0x8DBE7E0", VA = "0x188DBFDE0")]
		public FilterAction(int MillisecondDelay, FailureModes FailureMode)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000933")]
		[Cpp2IlInjected.Address(RVA = "0x8DBFC00", Offset = "0x8DBE600", VA = "0x188DBFC00", Slot = "3")]
		[CompilerGenerated]
		public override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000934")]
		[Cpp2IlInjected.Address(RVA = "0x8DBFCF0", Offset = "0x8DBE6F0", VA = "0x188DBFCF0", Slot = "6")]
		[CompilerGenerated]
		protected virtual bool WJJAKQGJTCH(StringBuilder a)
		{
			return default(bool);
		}

		[SpecialName]
		[Cpp2IlInjected.Token(Token = "0x6000935")]
		[Cpp2IlInjected.Address(RVA = "0x12EAD60", Offset = "0x12E9760", VA = "0x1812EAD60")]
		[CompilerGenerated]
		public static bool CYAUITUETAA(FilterAction? a, FilterAction? b)
		{
			return default(bool);
		}

		[SpecialName]
		[Cpp2IlInjected.Token(Token = "0x6000936")]
		[Cpp2IlInjected.Address(RVA = "0x12EB0B0", Offset = "0x12E9AB0", VA = "0x1812EB0B0")]
		[CompilerGenerated]
		public static bool ITVTPRNZGNV(FilterAction? a, FilterAction? b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000937")]
		[Cpp2IlInjected.Address(RVA = "0x8DBFA90", Offset = "0x8DBE490", VA = "0x188DBFA90", Slot = "2")]
		[CompilerGenerated]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000938")]
		[Cpp2IlInjected.Address(RVA = "0x8DBFA00", Offset = "0x8DBE400", VA = "0x188DBFA00", Slot = "0")]
		[CompilerGenerated]
		public override bool Equals(object? obj)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000939")]
		[Cpp2IlInjected.Address(RVA = "0x8DBF8C0", Offset = "0x8DBE2C0", VA = "0x188DBF8C0", Slot = "7")]
		[CompilerGenerated]
		public virtual bool Equals(FilterAction? other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600093A")]
		[Cpp2IlInjected.Address(RVA = "0x8DBF850", Offset = "0x8DBE250", VA = "0x188DBF850", Slot = "8")]
		[CompilerGenerated]
		public virtual FilterAction CXDOYZBTDGW()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600093B")]
		[Cpp2IlInjected.Address(RVA = "0x29D6350", Offset = "0x29D4D50", VA = "0x1829D6350")]
		[CompilerGenerated]
		protected FilterAction(FilterAction original)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600093C")]
		[Cpp2IlInjected.Address(RVA = "0x8DBFBF0", Offset = "0x8DBE5F0", VA = "0x188DBFBF0")]
		[CompilerGenerated]
		public void OGNPAZKLJRJ([Out] int a, [Out] FailureModes b)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000152")]
	public enum FailureModes
	{
		[Cpp2IlInjected.Token(Token = "0x40006DE")]
		None,
		[Cpp2IlInjected.Token(Token = "0x40006DF")]
		ConnectionTimeout,
		[Cpp2IlInjected.Token(Token = "0x40006E0")]
		InternalServerError
	}
	[Cpp2IlInjected.Token(Token = "0x2000153")]
	public interface FFVCKNUTOAJ
	{
		[Cpp2IlInjected.Token(Token = "0x600093D")]
		[Cpp2IlInjected.Address(Slot = "0")]
		IReadOnlyDictionary<FilterKey, FilterAction> YUSZYHFPEEC();

		[Cpp2IlInjected.Token(Token = "0x600093E")]
		[Cpp2IlInjected.Address(Slot = "1")]
		void FTJKNEYVIRH(FilterKey a, FilterAction b);

		[Cpp2IlInjected.Token(Token = "0x600093F")]
		[Cpp2IlInjected.Address(Slot = "2")]
		void KYVBHHWZDST(FilterKey a);

		[Cpp2IlInjected.Token(Token = "0x6000940")]
		[Cpp2IlInjected.Address(Slot = "3")]
		void FEKFYOAMJHJ();

		[Cpp2IlInjected.Token(Token = "0x6000941")]
		[Cpp2IlInjected.Address(Slot = "4")]
		Task NQHUBIVNYHA(Service a, HttpMethod b, string c, CancellationToken d);
	}
}
namespace RecNet.Interfaces
{
	[Cpp2IlInjected.Token(Token = "0x2000154")]
	public interface UQJYHWYKTGT
	{
		[Cpp2IlInjected.Token(Token = "0x6000942")]
		[Cpp2IlInjected.Address(Slot = "0")]
		Task SHJQBHDNXLA(bool a, int b = 1, [Optional] CancellationToken c);

		[Cpp2IlInjected.Token(Token = "0x6000943")]
		[Cpp2IlInjected.Address(Slot = "1")]
		Task<int> MHLZWQHBYTV([Optional] CancellationToken a);
	}
}
namespace RecNet.Interfaces.TimeLimitedEvents
{
	[Cpp2IlInjected.Token(Token = "0x2000155")]
	[Utf8JsonSerializable]
	public class TimedRewardTreeDTO : OIRXPKYYAWC
	{
		[Cpp2IlInjected.Token(Token = "0x170003F1")]
		public long TimedRewardTreeId
		{
			[Cpp2IlInjected.Token(Token = "0x6000944")]
			[Cpp2IlInjected.Address(RVA = "0xD117B0", Offset = "0xD101B0", VA = "0x180D117B0")]
			[CompilerGenerated]
			get
			{
				return default(long);
			}
			[Cpp2IlInjected.Token(Token = "0x6000945")]
			[Cpp2IlInjected.Address(RVA = "0xED90B0", Offset = "0xED7AB0", VA = "0x180ED90B0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170003F2")]
		public Guid? ReplicationId
		{
			[Cpp2IlInjected.Token(Token = "0x6000946")]
			[Cpp2IlInjected.Address(RVA = "0x1081CC0", Offset = "0x10806C0", VA = "0x181081CC0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000947")]
			[Cpp2IlInjected.Address(RVA = "0x8DC7AC0", Offset = "0x8DC64C0", VA = "0x188DC7AC0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170003F3")]
		public string Name
		{
			[Cpp2IlInjected.Token(Token = "0x6000948")]
			[Cpp2IlInjected.Address(RVA = "0xD11A20", Offset = "0xD10420", VA = "0x180D11A20")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000949")]
			[Cpp2IlInjected.Address(RVA = "0xD17350", Offset = "0xD15D50", VA = "0x180D17350")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170003F4")]
		public DateTime StartTime
		{
			[Cpp2IlInjected.Token(Token = "0x600094A")]
			[Cpp2IlInjected.Address(RVA = "0xD12280", Offset = "0xD10C80", VA = "0x180D12280")]
			[CompilerGenerated]
			get
			{
				return default(DateTime);
			}
			[Cpp2IlInjected.Token(Token = "0x600094B")]
			[Cpp2IlInjected.Address(RVA = "0xD1B6D0", Offset = "0xD1A0D0", VA = "0x180D1B6D0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170003F5")]
		public DateTime EndTime
		{
			[Cpp2IlInjected.Token(Token = "0x600094C")]
			[Cpp2IlInjected.Address(RVA = "0xD11A30", Offset = "0xD10430", VA = "0x180D11A30")]
			[CompilerGenerated]
			get
			{
				return default(DateTime);
			}
			[Cpp2IlInjected.Token(Token = "0x600094D")]
			[Cpp2IlInjected.Address(RVA = "0xFFBC20", Offset = "0xFFA620", VA = "0x180FFBC20")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170003F6")]
		public string? ActiveExperiment
		{
			[Cpp2IlInjected.Token(Token = "0x600094E")]
			[Cpp2IlInjected.Address(RVA = "0xD122E0", Offset = "0xD10CE0", VA = "0x180D122E0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600094F")]
			[Cpp2IlInjected.Address(RVA = "0xD12290", Offset = "0xD10C90", VA = "0x180D12290")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170003F7")]
		public List<TimedRewardTreeNodeDTO> Nodes
		{
			[Cpp2IlInjected.Token(Token = "0x6000950")]
			[Cpp2IlInjected.Address(RVA = "0xD11B20", Offset = "0xD10520", VA = "0x180D11B20")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000951")]
			[Cpp2IlInjected.Address(RVA = "0xD11900", Offset = "0xD10300", VA = "0x180D11900")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000952")]
		[Cpp2IlInjected.Address(RVA = "0x8DC79F0", Offset = "0x8DC63F0", VA = "0x188DC79F0", Slot = "4")]
		public void HHUGNWFYOZL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000953")]
		[Cpp2IlInjected.Address(RVA = "0x8DC7A40", Offset = "0x8DC6440", VA = "0x188DC7A40")]
		public TimedRewardTreeDTO()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000156")]
	[Utf8JsonSerializable]
	public class TimedRewardTreeNodeDTO : IComparable<TimedRewardTreeNodeDTO>
	{
		[Cpp2IlInjected.Token(Token = "0x170003F8")]
		public Guid ReplicationId
		{
			[Cpp2IlInjected.Token(Token = "0x6000954")]
			[Cpp2IlInjected.Address(RVA = "0xF357F0", Offset = "0xF341F0", VA = "0x180F357F0")]
			[CompilerGenerated]
			get
			{
				return default(Guid);
			}
			[Cpp2IlInjected.Token(Token = "0x6000955")]
			[Cpp2IlInjected.Address(RVA = "0xF35810", Offset = "0xF34210", VA = "0x180F35810")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170003F9")]
		public long TimedRewardTreeNodeId
		{
			[Cpp2IlInjected.Token(Token = "0x6000956")]
			[Cpp2IlInjected.Address(RVA = "0xD12BC0", Offset = "0xD115C0", VA = "0x180D12BC0")]
			[CompilerGenerated]
			get
			{
				return default(long);
			}
			[Cpp2IlInjected.Token(Token = "0x6000957")]
			[Cpp2IlInjected.Address(RVA = "0xE3F130", Offset = "0xE3DB30", VA = "0x180E3F130")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170003FA")]
		public long? ParentTimedRewardTreeNodeId
		{
			[Cpp2IlInjected.Token(Token = "0x6000958")]
			[Cpp2IlInjected.Address(RVA = "0x104E620", Offset = "0x104D020", VA = "0x18104E620")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000959")]
			[Cpp2IlInjected.Address(RVA = "0x104DCA0", Offset = "0x104C6A0", VA = "0x18104DCA0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170003FB")]
		public int? ParentIndex
		{
			[Cpp2IlInjected.Token(Token = "0x600095A")]
			[Cpp2IlInjected.Address(RVA = "0xD12280", Offset = "0xD10C80", VA = "0x180D12280")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600095B")]
			[Cpp2IlInjected.Address(RVA = "0xD1B6D0", Offset = "0xD1A0D0", VA = "0x180D1B6D0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170003FC")]
		public int RequiredXp
		{
			[Cpp2IlInjected.Token(Token = "0x600095C")]
			[Cpp2IlInjected.Address(RVA = "0xD2DD40", Offset = "0xD2C740", VA = "0x180D2DD40")]
			[CompilerGenerated]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x600095D")]
			[Cpp2IlInjected.Address(RVA = "0xD89720", Offset = "0xD88120", VA = "0x180D89720")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170003FD")]
		public List<int> RewardGiftDropIds
		{
			[Cpp2IlInjected.Token(Token = "0x600095E")]
			[Cpp2IlInjected.Address(RVA = "0xD122E0", Offset = "0xD10CE0", VA = "0x180D122E0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600095F")]
			[Cpp2IlInjected.Address(RVA = "0xD12290", Offset = "0xD10C90", VA = "0x180D12290")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000960")]
		[Cpp2IlInjected.Address(RVA = "0x8DC7AD0", Offset = "0x8DC64D0", VA = "0x188DC7AD0", Slot = "4")]
		public int CompareTo(TimedRewardTreeNodeDTO other)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000961")]
		[Cpp2IlInjected.Address(RVA = "0x8DC7BC0", Offset = "0x8DC65C0", VA = "0x188DC7BC0")]
		public TimedRewardTreeNodeDTO()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000157")]
	[Utf8JsonSerializable]
	public class TimedRewardTreeRecordDTO
	{
		[Cpp2IlInjected.Token(Token = "0x170003FE")]
		public long TimedRewardTreeId
		{
			[Cpp2IlInjected.Token(Token = "0x6000962")]
			[Cpp2IlInjected.Address(RVA = "0xD117B0", Offset = "0xD101B0", VA = "0x180D117B0")]
			[CompilerGenerated]
			get
			{
				return default(long);
			}
			[Cpp2IlInjected.Token(Token = "0x6000963")]
			[Cpp2IlInjected.Address(RVA = "0xED90B0", Offset = "0xED7AB0", VA = "0x180ED90B0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170003FF")]
		public int AccountId
		{
			[Cpp2IlInjected.Token(Token = "0x6000964")]
			[Cpp2IlInjected.Address(RVA = "0xD17340", Offset = "0xD15D40", VA = "0x180D17340")]
			[CompilerGenerated]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x6000965")]
			[Cpp2IlInjected.Address(RVA = "0xD17360", Offset = "0xD15D60", VA = "0x180D17360")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000400")]
		public int CurrentXp
		{
			[Cpp2IlInjected.Token(Token = "0x6000966")]
			[Cpp2IlInjected.Address(RVA = "0x1664600", Offset = "0x1663000", VA = "0x181664600")]
			[CompilerGenerated]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x6000967")]
			[Cpp2IlInjected.Address(RVA = "0x1664610", Offset = "0x1663010", VA = "0x181664610")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000401")]
		public int TotalXp
		{
			[Cpp2IlInjected.Token(Token = "0x6000968")]
			[Cpp2IlInjected.Address(RVA = "0xD215F0", Offset = "0xD1FFF0", VA = "0x180D215F0")]
			[CompilerGenerated]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x6000969")]
			[Cpp2IlInjected.Address(RVA = "0xD682F0", Offset = "0xD66CF0", VA = "0x180D682F0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000402")]
		public List<long> CollectedNodeIds
		{
			[Cpp2IlInjected.Token(Token = "0x600096A")]
			[Cpp2IlInjected.Address(RVA = "0xD11B00", Offset = "0xD10500", VA = "0x180D11B00")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600096B")]
			[Cpp2IlInjected.Address(RVA = "0xD11530", Offset = "0xD0FF30", VA = "0x180D11530")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600096C")]
		[Cpp2IlInjected.Address(RVA = "0x8DC7C40", Offset = "0x8DC6640", VA = "0x188DC7C40")]
		public TimedRewardTreeRecordDTO()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000158")]
	[Utf8JsonSerializable]
	public class TimedRewardTreeNodeCollectedDTO
	{
		[Cpp2IlInjected.Token(Token = "0x17000403")]
		public long TimedRewardTreeId
		{
			[Cpp2IlInjected.Token(Token = "0x600096D")]
			[Cpp2IlInjected.Address(RVA = "0xD117B0", Offset = "0xD101B0", VA = "0x180D117B0")]
			[CompilerGenerated]
			get
			{
				return default(long);
			}
			[Cpp2IlInjected.Token(Token = "0x600096E")]
			[Cpp2IlInjected.Address(RVA = "0xED90B0", Offset = "0xED7AB0", VA = "0x180ED90B0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000404")]
		public int AccountId
		{
			[Cpp2IlInjected.Token(Token = "0x600096F")]
			[Cpp2IlInjected.Address(RVA = "0xD17340", Offset = "0xD15D40", VA = "0x180D17340")]
			[CompilerGenerated]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x6000970")]
			[Cpp2IlInjected.Address(RVA = "0xD17360", Offset = "0xD15D60", VA = "0x180D17360")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000405")]
		public long TimedRewardTreeNodeId
		{
			[Cpp2IlInjected.Token(Token = "0x6000971")]
			[Cpp2IlInjected.Address(RVA = "0xD12BC0", Offset = "0xD115C0", VA = "0x180D12BC0")]
			[CompilerGenerated]
			get
			{
				return default(long);
			}
			[Cpp2IlInjected.Token(Token = "0x6000972")]
			[Cpp2IlInjected.Address(RVA = "0xE3F130", Offset = "0xE3DB30", VA = "0x180E3F130")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000406")]
		public DateTime CollectedAt
		{
			[Cpp2IlInjected.Token(Token = "0x6000973")]
			[Cpp2IlInjected.Address(RVA = "0xD11B00", Offset = "0xD10500", VA = "0x180D11B00")]
			[CompilerGenerated]
			get
			{
				return default(DateTime);
			}
			[Cpp2IlInjected.Token(Token = "0x6000974")]
			[Cpp2IlInjected.Address(RVA = "0xD11960", Offset = "0xD10360", VA = "0x180D11960")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000407")]
		public int ConsumedXp
		{
			[Cpp2IlInjected.Token(Token = "0x6000975")]
			[Cpp2IlInjected.Address(RVA = "0xD1B6C0", Offset = "0xD1A0C0", VA = "0x180D1B6C0")]
			[CompilerGenerated]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x6000976")]
			[Cpp2IlInjected.Address(RVA = "0xD1B020", Offset = "0xD19A20", VA = "0x180D1B020")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000408")]
		public int CurrentXp
		{
			[Cpp2IlInjected.Token(Token = "0x6000977")]
			[Cpp2IlInjected.Address(RVA = "0xD60890", Offset = "0xD5F290", VA = "0x180D60890")]
			[CompilerGenerated]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x6000978")]
			[Cpp2IlInjected.Address(RVA = "0x1708EF0", Offset = "0x17078F0", VA = "0x181708EF0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000409")]
		public int TotalXp
		{
			[Cpp2IlInjected.Token(Token = "0x6000979")]
			[Cpp2IlInjected.Address(RVA = "0xD40260", Offset = "0xD3EC60", VA = "0x180D40260")]
			[CompilerGenerated]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x600097A")]
			[Cpp2IlInjected.Address(RVA = "0xE27B10", Offset = "0xE26510", VA = "0x180E27B10")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700040A")]
		public List<int> GiftDropIds
		{
			[Cpp2IlInjected.Token(Token = "0x600097B")]
			[Cpp2IlInjected.Address(RVA = "0xD11A30", Offset = "0xD10430", VA = "0x180D11A30")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600097C")]
			[Cpp2IlInjected.Address(RVA = "0xD12260", Offset = "0xD10C60", VA = "0x180D12260")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600097D")]
		[Cpp2IlInjected.Address(RVA = "0xD16C40", Offset = "0xD15640", VA = "0x180D16C40")]
		public TimedRewardTreeNodeCollectedDTO()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000159")]
	[Utf8JsonSerializable]
	public class TimedRewardTreeXpEarnedDTO
	{
		[Cpp2IlInjected.Token(Token = "0x1700040B")]
		public long TimedRewardTreeId
		{
			[Cpp2IlInjected.Token(Token = "0x600097E")]
			[Cpp2IlInjected.Address(RVA = "0xD117B0", Offset = "0xD101B0", VA = "0x180D117B0")]
			[CompilerGenerated]
			get
			{
				return default(long);
			}
			[Cpp2IlInjected.Token(Token = "0x600097F")]
			[Cpp2IlInjected.Address(RVA = "0xED90B0", Offset = "0xED7AB0", VA = "0x180ED90B0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700040C")]
		public int AccountId
		{
			[Cpp2IlInjected.Token(Token = "0x6000980")]
			[Cpp2IlInjected.Address(RVA = "0xD17340", Offset = "0xD15D40", VA = "0x180D17340")]
			[CompilerGenerated]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x6000981")]
			[Cpp2IlInjected.Address(RVA = "0xD17360", Offset = "0xD15D60", VA = "0x180D17360")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700040D")]
		public int CurrentXp
		{
			[Cpp2IlInjected.Token(Token = "0x6000982")]
			[Cpp2IlInjected.Address(RVA = "0x1664600", Offset = "0x1663000", VA = "0x181664600")]
			[CompilerGenerated]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x6000983")]
			[Cpp2IlInjected.Address(RVA = "0x1664610", Offset = "0x1663010", VA = "0x181664610")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700040E")]
		public int TotalXp
		{
			[Cpp2IlInjected.Token(Token = "0x6000984")]
			[Cpp2IlInjected.Address(RVA = "0xD215F0", Offset = "0xD1FFF0", VA = "0x180D215F0")]
			[CompilerGenerated]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x6000985")]
			[Cpp2IlInjected.Address(RVA = "0xD682F0", Offset = "0xD66CF0", VA = "0x180D682F0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700040F")]
		public int DeltaXp
		{
			[Cpp2IlInjected.Token(Token = "0x6000986")]
			[Cpp2IlInjected.Address(RVA = "0xD38090", Offset = "0xD36A90", VA = "0x180D38090")]
			[CompilerGenerated]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x6000987")]
			[Cpp2IlInjected.Address(RVA = "0xF21A50", Offset = "0xF20450", VA = "0x180F21A50")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000410")]
		public float DeltaXpMultiplier
		{
			[Cpp2IlInjected.Token(Token = "0x6000988")]
			[Cpp2IlInjected.Address(RVA = "0x10DD6F0", Offset = "0x10DC0F0", VA = "0x1810DD6F0")]
			[CompilerGenerated]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x6000989")]
			[Cpp2IlInjected.Address(RVA = "0x1368DF0", Offset = "0x13677F0", VA = "0x181368DF0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600098A")]
		[Cpp2IlInjected.Address(RVA = "0xD16C40", Offset = "0xD15640", VA = "0x180D16C40")]
		public TimedRewardTreeXpEarnedDTO()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200015A")]
	[Utf8JsonSerializable]
	public class TimeLimitedEventDTO : OIRXPKYYAWC
	{
		[Cpp2IlInjected.Token(Token = "0x17000411")]
		public long TimeLimitedEventId
		{
			[Cpp2IlInjected.Token(Token = "0x600098B")]
			[Cpp2IlInjected.Address(RVA = "0xD117B0", Offset = "0xD101B0", VA = "0x180D117B0")]
			[CompilerGenerated]
			get
			{
				return default(long);
			}
			[Cpp2IlInjected.Token(Token = "0x600098C")]
			[Cpp2IlInjected.Address(RVA = "0xED90B0", Offset = "0xED7AB0", VA = "0x180ED90B0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000412")]
		public Guid ReplicationId
		{
			[Cpp2IlInjected.Token(Token = "0x600098D")]
			[Cpp2IlInjected.Address(RVA = "0xDA5E80", Offset = "0xDA4880", VA = "0x180DA5E80")]
			[CompilerGenerated]
			get
			{
				return default(Guid);
			}
			[Cpp2IlInjected.Token(Token = "0x600098E")]
			[Cpp2IlInjected.Address(RVA = "0xF82330", Offset = "0xF80D30", VA = "0x180F82330")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000413")]
		public string Name
		{
			[Cpp2IlInjected.Token(Token = "0x600098F")]
			[Cpp2IlInjected.Address(RVA = "0xD11B00", Offset = "0xD10500", VA = "0x180D11B00")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000990")]
			[Cpp2IlInjected.Address(RVA = "0xD11530", Offset = "0xD0FF30", VA = "0x180D11530")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000414")]
		public DateTime StartTime
		{
			[Cpp2IlInjected.Token(Token = "0x6000991")]
			[Cpp2IlInjected.Address(RVA = "0xD11A20", Offset = "0xD10420", VA = "0x180D11A20")]
			[CompilerGenerated]
			get
			{
				return default(DateTime);
			}
			[Cpp2IlInjected.Token(Token = "0x6000992")]
			[Cpp2IlInjected.Address(RVA = "0xD118E0", Offset = "0xD102E0", VA = "0x180D118E0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000415")]
		public DateTime EndTime
		{
			[Cpp2IlInjected.Token(Token = "0x6000993")]
			[Cpp2IlInjected.Address(RVA = "0xD12280", Offset = "0xD10C80", VA = "0x180D12280")]
			[CompilerGenerated]
			get
			{
				return default(DateTime);
			}
			[Cpp2IlInjected.Token(Token = "0x6000994")]
			[Cpp2IlInjected.Address(RVA = "0xD1B6D0", Offset = "0xD1A0D0", VA = "0x180D1B6D0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000416")]
		internal string? IXLUFOKDARX
		{
			[Cpp2IlInjected.Token(Token = "0x6000995")]
			[Cpp2IlInjected.Address(RVA = "0xD11A30", Offset = "0xD10430", VA = "0x180D11A30")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000996")]
			[Cpp2IlInjected.Address(RVA = "0xD12260", Offset = "0xD10C60", VA = "0x180D12260")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000417")]
		public string? Metadata
		{
			[Cpp2IlInjected.Token(Token = "0x6000997")]
			[Cpp2IlInjected.Address(RVA = "0xD122E0", Offset = "0xD10CE0", VA = "0x180D122E0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000998")]
			[Cpp2IlInjected.Address(RVA = "0xD12290", Offset = "0xD10C90", VA = "0x180D12290")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000418")]
		[IgnoreDataMember]
		public TimeLimitedEventConfigDTO? Config
		{
			[Cpp2IlInjected.Token(Token = "0x6000999")]
			[Cpp2IlInjected.Address(RVA = "0xD11B20", Offset = "0xD10520", VA = "0x180D11B20")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600099A")]
			[Cpp2IlInjected.Address(RVA = "0xD11900", Offset = "0xD10300", VA = "0x180D11900")]
			[CompilerGenerated]
			internal set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600099B")]
		[Cpp2IlInjected.Address(RVA = "0x8DC6FD0", Offset = "0x8DC59D0", VA = "0x188DC6FD0", Slot = "4")]
		public void HHUGNWFYOZL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600099C")]
		[Cpp2IlInjected.Address(RVA = "0xD16C40", Offset = "0xD15640", VA = "0x180D16C40")]
		public TimeLimitedEventDTO()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200015B")]
	[Utf8JsonSerializable]
	public class TimeLimitedEventConfigDTO
	{
		[Cpp2IlInjected.Token(Token = "0x17000419")]
		public TimedEventCurrencyGrantDTO? CurrencyGrant
		{
			[Cpp2IlInjected.Token(Token = "0x600099D")]
			[Cpp2IlInjected.Address(RVA = "0xD117B0", Offset = "0xD101B0", VA = "0x180D117B0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600099E")]
			[Cpp2IlInjected.Address(RVA = "0xD117C0", Offset = "0xD101C0", VA = "0x180D117C0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700041A")]
		public List<TimedEventXpSinkDTO> XpSinks
		{
			[Cpp2IlInjected.Token(Token = "0x600099F")]
			[Cpp2IlInjected.Address(RVA = "0xD11B30", Offset = "0xD10530", VA = "0x180D11B30")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60009A0")]
			[Cpp2IlInjected.Address(RVA = "0xD12270", Offset = "0xD10C70", VA = "0x180D12270")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700041B")]
		public TimeLimitedEventTeamConfigStorageDTO? TeamConfig
		{
			[Cpp2IlInjected.Token(Token = "0x60009A1")]
			[Cpp2IlInjected.Address(RVA = "0xD12BC0", Offset = "0xD115C0", VA = "0x180D12BC0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60009A2")]
			[Cpp2IlInjected.Address(RVA = "0xD11520", Offset = "0xD0FF20", VA = "0x180D11520")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60009A3")]
		[Cpp2IlInjected.Address(RVA = "0x8DC6F50", Offset = "0x8DC5950", VA = "0x188DC6F50")]
		public TimeLimitedEventConfigDTO()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200015C")]
	[Utf8JsonSerializable]
	public class TimeLimitedEventTeamConfigStorageDTO
	{
		[Cpp2IlInjected.Token(Token = "0x1700041C")]
		public long? TimeLimitedEventTeamConfigId
		{
			[Cpp2IlInjected.Token(Token = "0x60009A4")]
			[Cpp2IlInjected.Address(RVA = "0xF357F0", Offset = "0xF341F0", VA = "0x180F357F0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60009A5")]
			[Cpp2IlInjected.Address(RVA = "0xF35810", Offset = "0xF34210", VA = "0x180F35810")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700041D")]
		public TimeLimitedEventTeamConfigDTO? TimeLimitedEventTeamConfig
		{
			[Cpp2IlInjected.Token(Token = "0x60009A6")]
			[Cpp2IlInjected.Address(RVA = "0xD12BC0", Offset = "0xD115C0", VA = "0x180D12BC0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60009A7")]
			[Cpp2IlInjected.Address(RVA = "0xD11520", Offset = "0xD0FF20", VA = "0x180D11520")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60009A8")]
		[Cpp2IlInjected.Address(RVA = "0xD16C40", Offset = "0xD15640", VA = "0x180D16C40")]
		public TimeLimitedEventTeamConfigStorageDTO()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200015D")]
	[Utf8JsonSerializable]
	public class TimeLimitedEventTeamConfigDTO
	{
		[Cpp2IlInjected.Token(Token = "0x1700041E")]
		public long TimeLimitedEventTeamConfigId
		{
			[Cpp2IlInjected.Token(Token = "0x60009A9")]
			[Cpp2IlInjected.Address(RVA = "0xD117B0", Offset = "0xD101B0", VA = "0x180D117B0")]
			[CompilerGenerated]
			get
			{
				return default(long);
			}
			[Cpp2IlInjected.Token(Token = "0x60009AA")]
			[Cpp2IlInjected.Address(RVA = "0xED90B0", Offset = "0xED7AB0", VA = "0x180ED90B0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700041F")]
		public Guid ReplicationId
		{
			[Cpp2IlInjected.Token(Token = "0x60009AB")]
			[Cpp2IlInjected.Address(RVA = "0xDA5E80", Offset = "0xDA4880", VA = "0x180DA5E80")]
			[CompilerGenerated]
			get
			{
				return default(Guid);
			}
			[Cpp2IlInjected.Token(Token = "0x60009AC")]
			[Cpp2IlInjected.Address(RVA = "0xF82330", Offset = "0xF80D30", VA = "0x180F82330")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000420")]
		public int MaxPlayersPerTeam
		{
			[Cpp2IlInjected.Token(Token = "0x60009AD")]
			[Cpp2IlInjected.Address(RVA = "0xD12BE0", Offset = "0xD115E0", VA = "0x180D12BE0")]
			[CompilerGenerated]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x60009AE")]
			[Cpp2IlInjected.Address(RVA = "0xD12C40", Offset = "0xD11640", VA = "0x180D12C40")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000421")]
		public DateTime TeamRegistrationStartTime
		{
			[Cpp2IlInjected.Token(Token = "0x60009AF")]
			[Cpp2IlInjected.Address(RVA = "0xD11A20", Offset = "0xD10420", VA = "0x180D11A20")]
			[CompilerGenerated]
			get
			{
				return default(DateTime);
			}
			[Cpp2IlInjected.Token(Token = "0x60009B0")]
			[Cpp2IlInjected.Address(RVA = "0xD118E0", Offset = "0xD102E0", VA = "0x180D118E0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000422")]
		public DateTime TeamRegistrationEndTime
		{
			[Cpp2IlInjected.Token(Token = "0x60009B1")]
			[Cpp2IlInjected.Address(RVA = "0xD12280", Offset = "0xD10C80", VA = "0x180D12280")]
			[CompilerGenerated]
			get
			{
				return default(DateTime);
			}
			[Cpp2IlInjected.Token(Token = "0x60009B2")]
			[Cpp2IlInjected.Address(RVA = "0xD1B6D0", Offset = "0xD1A0D0", VA = "0x180D1B6D0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000423")]
		public string? ActiveExperiment
		{
			[Cpp2IlInjected.Token(Token = "0x60009B3")]
			[Cpp2IlInjected.Address(RVA = "0xD11A30", Offset = "0xD10430", VA = "0x180D11A30")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60009B4")]
			[Cpp2IlInjected.Address(RVA = "0xD12260", Offset = "0xD10C60", VA = "0x180D12260")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60009B5")]
		[Cpp2IlInjected.Address(RVA = "0xD16C40", Offset = "0xD15640", VA = "0x180D16C40")]
		public TimeLimitedEventTeamConfigDTO()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200015E")]
	[Utf8JsonSerializable]
	public class TimedEventCurrencyGrantDTO
	{
		[Cpp2IlInjected.Token(Token = "0x17000424")]
		public long? TimedCurrencyGrantId
		{
			[Cpp2IlInjected.Token(Token = "0x60009B6")]
			[Cpp2IlInjected.Address(RVA = "0xF357F0", Offset = "0xF341F0", VA = "0x180F357F0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60009B7")]
			[Cpp2IlInjected.Address(RVA = "0xF35810", Offset = "0xF34210", VA = "0x180F35810")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60009B8")]
		[Cpp2IlInjected.Address(RVA = "0xD16C40", Offset = "0xD15640", VA = "0x180D16C40")]
		public TimedEventCurrencyGrantDTO()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200015F")]
	[JsonPolymorphic(TypeDiscriminatorPropertyName = "$type")]
	[JsonDerivedType(typeof(TimedRewardTrackXpSinkDTO), "RewardTrack")]
	[JsonDerivedType(typeof(TimedRewardTreeXpSinkDTO), "RewardTree")]
	[Utf8JsonSerializable]
	public class TimedEventXpSinkDTO
	{
		[Cpp2IlInjected.Token(Token = "0x17000425")]
		public List<TimedEventXpSourceDTO> XpSources
		{
			[Cpp2IlInjected.Token(Token = "0x60009B9")]
			[Cpp2IlInjected.Address(RVA = "0xD117B0", Offset = "0xD101B0", VA = "0x180D117B0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60009BA")]
			[Cpp2IlInjected.Address(RVA = "0xD117C0", Offset = "0xD101C0", VA = "0x180D117C0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000426")]
		public List<TimedEventXpMultiplierDTO> XpMultipliers
		{
			[Cpp2IlInjected.Token(Token = "0x60009BB")]
			[Cpp2IlInjected.Address(RVA = "0xD11B30", Offset = "0xD10530", VA = "0x180D11B30")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60009BC")]
			[Cpp2IlInjected.Address(RVA = "0xD12270", Offset = "0xD10C70", VA = "0x180D12270")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000427")]
		public string? GiftMessage
		{
			[Cpp2IlInjected.Token(Token = "0x60009BD")]
			[Cpp2IlInjected.Address(RVA = "0xD12BC0", Offset = "0xD115C0", VA = "0x180D12BC0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60009BE")]
			[Cpp2IlInjected.Address(RVA = "0xD11520", Offset = "0xD0FF20", VA = "0x180D11520")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60009BF")]
		[Cpp2IlInjected.Address(RVA = "0x8DC7090", Offset = "0x8DC5A90", VA = "0x188DC7090")]
		public TimedEventXpSinkDTO()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000160")]
	[Utf8JsonSerializable]
	public class TimedRewardTrackXpSinkDTO : TimedEventXpSinkDTO
	{
		[Cpp2IlInjected.Token(Token = "0x17000428")]
		public long TimedRewardTrackId
		{
			[Cpp2IlInjected.Token(Token = "0x60009C0")]
			[Cpp2IlInjected.Address(RVA = "0xD11B00", Offset = "0xD10500", VA = "0x180D11B00")]
			[CompilerGenerated]
			get
			{
				return default(long);
			}
			[Cpp2IlInjected.Token(Token = "0x60009C1")]
			[Cpp2IlInjected.Address(RVA = "0xD11960", Offset = "0xD10360", VA = "0x180D11960")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60009C2")]
		[Cpp2IlInjected.Address(RVA = "0x8DC79E0", Offset = "0x8DC63E0", VA = "0x188DC79E0")]
		public TimedRewardTrackXpSinkDTO()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000161")]
	[Utf8JsonSerializable]
	public class TimedRewardTreeXpSinkDTO : TimedEventXpSinkDTO
	{
		[Cpp2IlInjected.Token(Token = "0x17000429")]
		public long TimedRewardTreeId
		{
			[Cpp2IlInjected.Token(Token = "0x60009C3")]
			[Cpp2IlInjected.Address(RVA = "0xD11B00", Offset = "0xD10500", VA = "0x180D11B00")]
			[CompilerGenerated]
			get
			{
				return default(long);
			}
			[Cpp2IlInjected.Token(Token = "0x60009C4")]
			[Cpp2IlInjected.Address(RVA = "0xD11960", Offset = "0xD10360", VA = "0x180D11960")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60009C5")]
		[Cpp2IlInjected.Address(RVA = "0x8DC79E0", Offset = "0x8DC63E0", VA = "0x188DC79E0")]
		public TimedRewardTreeXpSinkDTO()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000162")]
	[JsonPolymorphic(TypeDiscriminatorPropertyName = "$type")]
	[JsonDerivedType(typeof(DistanceMovedXpSourceDTO), "DistanceMoved")]
	[JsonDerivedType(typeof(GiftingXpSourceDTO), "Gifting")]
	[JsonDerivedType(typeof(RecipesEventXpSourceDTO), "RecipesEvent")]
	[Utf8JsonSerializable]
	public class TimedEventXpSourceDTO
	{
		[Cpp2IlInjected.Token(Token = "0x60009C6")]
		[Cpp2IlInjected.Address(RVA = "0xD16C40", Offset = "0xD15640", VA = "0x180D16C40")]
		public TimedEventXpSourceDTO()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000163")]
	[Utf8JsonSerializable]
	public class DistanceMovedXpSourceDTO : TimedEventXpSourceDTO
	{
		[Cpp2IlInjected.Token(Token = "0x1700042A")]
		public float XpPerMeter
		{
			[Cpp2IlInjected.Token(Token = "0x60009C7")]
			[Cpp2IlInjected.Address(RVA = "0xDBC130", Offset = "0xDBAB30", VA = "0x180DBC130")]
			[CompilerGenerated]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x60009C8")]
			[Cpp2IlInjected.Address(RVA = "0xDFEAF0", Offset = "0xDFD4F0", VA = "0x180DFEAF0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60009C9")]
		[Cpp2IlInjected.Address(RVA = "0xD16C40", Offset = "0xD15640", VA = "0x180D16C40")]
		public DistanceMovedXpSourceDTO()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000164")]
	[Utf8JsonSerializable]
	public class GiftingXpSourceDTO : TimedEventXpSourceDTO
	{
		[Cpp2IlInjected.Token(Token = "0x1700042B")]
		public List<GiftingXpReward> XpRewards
		{
			[Cpp2IlInjected.Token(Token = "0x60009CA")]
			[Cpp2IlInjected.Address(RVA = "0xD117B0", Offset = "0xD101B0", VA = "0x180D117B0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60009CB")]
			[Cpp2IlInjected.Address(RVA = "0xD117C0", Offset = "0xD101C0", VA = "0x180D117C0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60009CC")]
		[Cpp2IlInjected.Address(RVA = "0x8DC0890", Offset = "0x8DBF290", VA = "0x188DC0890")]
		public GiftingXpSourceDTO()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000165")]
	[Utf8JsonSerializable]
	public class GiftingXpReward
	{
		[Cpp2IlInjected.Token(Token = "0x1700042C")]
		public int? AvatarItemId
		{
			[Cpp2IlInjected.Token(Token = "0x60009CD")]
			[Cpp2IlInjected.Address(RVA = "0xD117B0", Offset = "0xD101B0", VA = "0x180D117B0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60009CE")]
			[Cpp2IlInjected.Address(RVA = "0xED90B0", Offset = "0xED7AB0", VA = "0x180ED90B0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700042D")]
		public int? EquipmentItemId
		{
			[Cpp2IlInjected.Token(Token = "0x60009CF")]
			[Cpp2IlInjected.Address(RVA = "0xD11B30", Offset = "0xD10530", VA = "0x180D11B30")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60009D0")]
			[Cpp2IlInjected.Address(RVA = "0xE07390", Offset = "0xE05D90", VA = "0x180E07390")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700042E")]
		public int? ConsumableItemId
		{
			[Cpp2IlInjected.Token(Token = "0x60009D1")]
			[Cpp2IlInjected.Address(RVA = "0xD12BC0", Offset = "0xD115C0", VA = "0x180D12BC0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60009D2")]
			[Cpp2IlInjected.Address(RVA = "0xE3F130", Offset = "0xE3DB30", VA = "0x180E3F130")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700042F")]
		public Guid? CustomAvatarItemId
		{
			[Cpp2IlInjected.Token(Token = "0x60009D3")]
			[Cpp2IlInjected.Address(RVA = "0x1017410", Offset = "0x1015E10", VA = "0x181017410")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60009D4")]
			[Cpp2IlInjected.Address(RVA = "0x23E53B0", Offset = "0x23E3DB0", VA = "0x1823E53B0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000430")]
		public Guid? PurchasableXpBoostId
		{
			[Cpp2IlInjected.Token(Token = "0x60009D5")]
			[Cpp2IlInjected.Address(RVA = "0x1053380", Offset = "0x1051D80", VA = "0x181053380")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60009D6")]
			[Cpp2IlInjected.Address(RVA = "0x23E53A0", Offset = "0x23E3DA0", VA = "0x1823E53A0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000431")]
		public int XpPerItem
		{
			[Cpp2IlInjected.Token(Token = "0x60009D7")]
			[Cpp2IlInjected.Address(RVA = "0xF01E60", Offset = "0xF00860", VA = "0x180F01E60")]
			[CompilerGenerated]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x60009D8")]
			[Cpp2IlInjected.Address(RVA = "0x1ADB800", Offset = "0x1ADA200", VA = "0x181ADB800")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60009D9")]
		[Cpp2IlInjected.Address(RVA = "0xD16C40", Offset = "0xD15640", VA = "0x180D16C40")]
		public GiftingXpReward()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000166")]
	[Utf8JsonSerializable]
	public class RecipesEventXpSourceDTO : TimedEventXpSourceDTO
	{
		[Cpp2IlInjected.Token(Token = "0x17000432")]
		public Guid RecipesEventId
		{
			[Cpp2IlInjected.Token(Token = "0x60009DA")]
			[Cpp2IlInjected.Address(RVA = "0xF357F0", Offset = "0xF341F0", VA = "0x180F357F0")]
			[CompilerGenerated]
			get
			{
				return default(Guid);
			}
			[Cpp2IlInjected.Token(Token = "0x60009DB")]
			[Cpp2IlInjected.Address(RVA = "0xF35810", Offset = "0xF34210", VA = "0x180F35810")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000433")]
		public List<IngredientDTO> Ingredients
		{
			[Cpp2IlInjected.Token(Token = "0x60009DC")]
			[Cpp2IlInjected.Address(RVA = "0xD12BC0", Offset = "0xD115C0", VA = "0x180D12BC0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60009DD")]
			[Cpp2IlInjected.Address(RVA = "0xD11520", Offset = "0xD0FF20", VA = "0x180D11520")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000434")]
		public List<RecipeDTO> Recipes
		{
			[Cpp2IlInjected.Token(Token = "0x60009DE")]
			[Cpp2IlInjected.Address(RVA = "0xD11B00", Offset = "0xD10500", VA = "0x180D11B00")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60009DF")]
			[Cpp2IlInjected.Address(RVA = "0xD11530", Offset = "0xD0FF30", VA = "0x180D11530")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000435")]
		public List<RecipesEventChallengeLaneConfigDTO> ChallengeLanes
		{
			[Cpp2IlInjected.Token(Token = "0x60009E0")]
			[Cpp2IlInjected.Address(RVA = "0xD11A20", Offset = "0xD10420", VA = "0x180D11A20")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60009E1")]
			[Cpp2IlInjected.Address(RVA = "0xD17350", Offset = "0xD15D50", VA = "0x180D17350")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000436")]
		public List<RecipeChallengeTypeDTO> Challenges
		{
			[Cpp2IlInjected.Token(Token = "0x60009E2")]
			[Cpp2IlInjected.Address(RVA = "0xD12280", Offset = "0xD10C80", VA = "0x180D12280")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60009E3")]
			[Cpp2IlInjected.Address(RVA = "0xD11B50", Offset = "0xD10550", VA = "0x180D11B50")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000437")]
		public CurrencyType CurrencyType
		{
			[Cpp2IlInjected.Token(Token = "0x60009E4")]
			[Cpp2IlInjected.Address(RVA = "0xD2DD40", Offset = "0xD2C740", VA = "0x180D2DD40")]
			[CompilerGenerated]
			get
			{
				return default(CurrencyType);
			}
			[Cpp2IlInjected.Token(Token = "0x60009E5")]
			[Cpp2IlInjected.Address(RVA = "0xD89720", Offset = "0xD88120", VA = "0x180D89720")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000438")]
		public int ChallengeSwapCost
		{
			[Cpp2IlInjected.Token(Token = "0x60009E6")]
			[Cpp2IlInjected.Address(RVA = "0xD2DD50", Offset = "0xD2C750", VA = "0x180D2DD50")]
			[CompilerGenerated]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x60009E7")]
			[Cpp2IlInjected.Address(RVA = "0xD89730", Offset = "0xD88130", VA = "0x180D89730")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000439")]
		public int ChallengeRewardSwapCost
		{
			[Cpp2IlInjected.Token(Token = "0x60009E8")]
			[Cpp2IlInjected.Address(RVA = "0xD88420", Offset = "0xD86E20", VA = "0x180D88420")]
			[CompilerGenerated]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x60009E9")]
			[Cpp2IlInjected.Address(RVA = "0xD89710", Offset = "0xD88110", VA = "0x180D89710")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700043A")]
		public int DoubleAndCompleteChallengeCost
		{
			[Cpp2IlInjected.Token(Token = "0x60009EA")]
			[Cpp2IlInjected.Address(RVA = "0x16A6F60", Offset = "0x16A5960", VA = "0x1816A6F60")]
			[CompilerGenerated]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x60009EB")]
			[Cpp2IlInjected.Address(RVA = "0x1CA3C80", Offset = "0x1CA2680", VA = "0x181CA3C80")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700043B")]
		public int RecipeHintPurchaseCost
		{
			[Cpp2IlInjected.Token(Token = "0x60009EC")]
			[Cpp2IlInjected.Address(RVA = "0xF01E60", Offset = "0xF00860", VA = "0x180F01E60")]
			[CompilerGenerated]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x60009ED")]
			[Cpp2IlInjected.Address(RVA = "0x1ADB800", Offset = "0x1ADA200", VA = "0x181ADB800")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700043C")]
		public int CookRecipeCost
		{
			[Cpp2IlInjected.Token(Token = "0x60009EE")]
			[Cpp2IlInjected.Address(RVA = "0x137DA00", Offset = "0x137C400", VA = "0x18137DA00")]
			[CompilerGenerated]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x60009EF")]
			[Cpp2IlInjected.Address(RVA = "0x21D5B90", Offset = "0x21D4590", VA = "0x1821D5B90")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700043D")]
		public int RecipeUnlockXp
		{
			[Cpp2IlInjected.Token(Token = "0x60009F0")]
			[Cpp2IlInjected.Address(RVA = "0xF372E0", Offset = "0xF35CE0", VA = "0x180F372E0")]
			[CompilerGenerated]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x60009F1")]
			[Cpp2IlInjected.Address(RVA = "0xF372D0", Offset = "0xF35CD0", VA = "0x180F372D0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700043E")]
		public ClientAuthoritativeCounterRateLimiterConfigDTO IngredientCollectionRateLimiting
		{
			[Cpp2IlInjected.Token(Token = "0x60009F2")]
			[Cpp2IlInjected.Address(RVA = "0xD15610", Offset = "0xD14010", VA = "0x180D15610")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60009F3")]
			[Cpp2IlInjected.Address(RVA = "0xD15600", Offset = "0xD14000", VA = "0x180D15600")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700043F")]
		public ClientAuthoritativeCounterRateLimiterConfigDTO ChallengeCompletionRateLimiting
		{
			[Cpp2IlInjected.Token(Token = "0x60009F4")]
			[Cpp2IlInjected.Address(RVA = "0xD11B40", Offset = "0xD10540", VA = "0x180D11B40")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60009F5")]
			[Cpp2IlInjected.Address(RVA = "0xD11910", Offset = "0xD10310", VA = "0x180D11910")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000440")]
		public List<int>? AllRecipesUnlockedGiftDropIds
		{
			[Cpp2IlInjected.Token(Token = "0x60009F6")]
			[Cpp2IlInjected.Address(RVA = "0xD11B60", Offset = "0xD10560", VA = "0x180D11B60")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60009F7")]
			[Cpp2IlInjected.Address(RVA = "0xD11AE0", Offset = "0xD104E0", VA = "0x180D11AE0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000441")]
		public int MinIngredientsForCooking
		{
			[Cpp2IlInjected.Token(Token = "0x60009F8")]
			[Cpp2IlInjected.Address(RVA = "0xD37350", Offset = "0xD35D50", VA = "0x180D37350")]
			[CompilerGenerated]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x60009F9")]
			[Cpp2IlInjected.Address(RVA = "0x164B040", Offset = "0x1649A40", VA = "0x18164B040")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000442")]
		public int MaxIngredientsForCooking
		{
			[Cpp2IlInjected.Token(Token = "0x60009FA")]
			[Cpp2IlInjected.Address(RVA = "0xD373B0", Offset = "0xD35DB0", VA = "0x180D373B0")]
			[CompilerGenerated]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x60009FB")]
			[Cpp2IlInjected.Address(RVA = "0x164B010", Offset = "0x1649A10", VA = "0x18164B010")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60009FC")]
		[Cpp2IlInjected.Address(RVA = "0x8DC4100", Offset = "0x8DC2B00", VA = "0x188DC4100")]
		public RecipesEventXpSourceDTO()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000167")]
	[Utf8JsonSerializable]
	public class IngredientDTO
	{
		[Cpp2IlInjected.Token(Token = "0x17000443")]
		public int Id
		{
			[Cpp2IlInjected.Token(Token = "0x60009FD")]
			[Cpp2IlInjected.Address(RVA = "0xD0F110", Offset = "0xD0DB10", VA = "0x180D0F110")]
			[CompilerGenerated]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x60009FE")]
			[Cpp2IlInjected.Address(RVA = "0xD12F30", Offset = "0xD11930", VA = "0x180D12F30")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000444")]
		public string Name
		{
			[Cpp2IlInjected.Token(Token = "0x60009FF")]
			[Cpp2IlInjected.Address(RVA = "0xD11B30", Offset = "0xD10530", VA = "0x180D11B30")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000A00")]
			[Cpp2IlInjected.Address(RVA = "0xD12270", Offset = "0xD10C70", VA = "0x180D12270")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000445")]
		public string ImagePath
		{
			[Cpp2IlInjected.Token(Token = "0x6000A01")]
			[Cpp2IlInjected.Address(RVA = "0xD12BC0", Offset = "0xD115C0", VA = "0x180D12BC0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000A02")]
			[Cpp2IlInjected.Address(RVA = "0xD11520", Offset = "0xD0FF20", VA = "0x180D11520")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000446")]
		public float Weight
		{
			[Cpp2IlInjected.Token(Token = "0x6000A03")]
			[Cpp2IlInjected.Address(RVA = "0x10DD6F0", Offset = "0x10DC0F0", VA = "0x1810DD6F0")]
			[CompilerGenerated]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x6000A04")]
			[Cpp2IlInjected.Address(RVA = "0x1368DF0", Offset = "0x13677F0", VA = "0x181368DF0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000447")]
		public RecipeIngredientCollectionMethod CollectionMethod
		{
			[Cpp2IlInjected.Token(Token = "0x6000A05")]
			[Cpp2IlInjected.Address(RVA = "0xE24360", Offset = "0xE22D60", VA = "0x180E24360")]
			[CompilerGenerated]
			get
			{
				return default(RecipeIngredientCollectionMethod);
			}
			[Cpp2IlInjected.Token(Token = "0x6000A06")]
			[Cpp2IlInjected.Address(RVA = "0x1E2BFE0", Offset = "0x1E2A9E0", VA = "0x181E2BFE0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000448")]
		public RecipesRarity Rarity
		{
			[Cpp2IlInjected.Token(Token = "0x6000A07")]
			[Cpp2IlInjected.Address(RVA = "0xD1B6C0", Offset = "0xD1A0C0", VA = "0x180D1B6C0")]
			[CompilerGenerated]
			get
			{
				return default(RecipesRarity);
			}
			[Cpp2IlInjected.Token(Token = "0x6000A08")]
			[Cpp2IlInjected.Address(RVA = "0xD1B020", Offset = "0xD19A20", VA = "0x180D1B020")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000A09")]
		[Cpp2IlInjected.Address(RVA = "0xD16C40", Offset = "0xD15640", VA = "0x180D16C40")]
		public IngredientDTO()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000168")]
	[Utf8JsonSerializable]
	public class RecipeIngredientDTO
	{
		[Cpp2IlInjected.Token(Token = "0x17000449")]
		public int IngredientId
		{
			[Cpp2IlInjected.Token(Token = "0x6000A0A")]
			[Cpp2IlInjected.Address(RVA = "0xD0F110", Offset = "0xD0DB10", VA = "0x180D0F110")]
			[CompilerGenerated]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x6000A0B")]
			[Cpp2IlInjected.Address(RVA = "0xD12F30", Offset = "0xD11930", VA = "0x180D12F30")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700044A")]
		public int IngredientCount
		{
			[Cpp2IlInjected.Token(Token = "0x6000A0C")]
			[Cpp2IlInjected.Address(RVA = "0xE073A0", Offset = "0xE05DA0", VA = "0x180E073A0")]
			[CompilerGenerated]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x6000A0D")]
			[Cpp2IlInjected.Address(RVA = "0xE073B0", Offset = "0xE05DB0", VA = "0x180E073B0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000A0E")]
		[Cpp2IlInjected.Address(RVA = "0xD16C40", Offset = "0xD15640", VA = "0x180D16C40")]
		public RecipeIngredientDTO()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000169")]
	[Flags]
	public enum RecipeIngredientCollectionMethod
	{
		[Cpp2IlInjected.Token(Token = "0x400073C")]
		InWorld = 1,
		[Cpp2IlInjected.Token(Token = "0x400073D")]
		Challenges = 2,
		[Cpp2IlInjected.Token(Token = "0x400073E")]
		Any = 3
	}
	[Cpp2IlInjected.Token(Token = "0x200016A")]
	[Flags]
	public enum IngredientCollectionFlags
	{
		[Cpp2IlInjected.Token(Token = "0x4000740")]
		InWorld = 0,
		[Cpp2IlInjected.Token(Token = "0x4000741")]
		GamePlay = 1,
		[Cpp2IlInjected.Token(Token = "0x4000742")]
		GameWin = 2,
		[Cpp2IlInjected.Token(Token = "0x4000743")]
		GameOwner = 4
	}
	[Cpp2IlInjected.Token(Token = "0x200016B")]
	[Utf8JsonSerializable]
	public class RecipeDTO
	{
		[Cpp2IlInjected.Token(Token = "0x1700044B")]
		public int Id
		{
			[Cpp2IlInjected.Token(Token = "0x6000A0F")]
			[Cpp2IlInjected.Address(RVA = "0xD0F110", Offset = "0xD0DB10", VA = "0x180D0F110")]
			[CompilerGenerated]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x6000A10")]
			[Cpp2IlInjected.Address(RVA = "0xD12F30", Offset = "0xD11930", VA = "0x180D12F30")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700044C")]
		public string Name
		{
			[Cpp2IlInjected.Token(Token = "0x6000A11")]
			[Cpp2IlInjected.Address(RVA = "0xD11B30", Offset = "0xD10530", VA = "0x180D11B30")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000A12")]
			[Cpp2IlInjected.Address(RVA = "0xD12270", Offset = "0xD10C70", VA = "0x180D12270")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700044D")]
		public string ImagePath
		{
			[Cpp2IlInjected.Token(Token = "0x6000A13")]
			[Cpp2IlInjected.Address(RVA = "0xD12BC0", Offset = "0xD115C0", VA = "0x180D12BC0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000A14")]
			[Cpp2IlInjected.Address(RVA = "0xD11520", Offset = "0xD0FF20", VA = "0x180D11520")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700044E")]
		public List<RecipeIngredientDTO> Ingredients
		{
			[Cpp2IlInjected.Token(Token = "0x6000A15")]
			[Cpp2IlInjected.Address(RVA = "0xD11B00", Offset = "0xD10500", VA = "0x180D11B00")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000A16")]
			[Cpp2IlInjected.Address(RVA = "0xD11530", Offset = "0xD0FF30", VA = "0x180D11530")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700044F")]
		public bool IsFallback
		{
			[Cpp2IlInjected.Token(Token = "0x6000A17")]
			[Cpp2IlInjected.Address(RVA = "0xD6E8A0", Offset = "0xD6D2A0", VA = "0x180D6E8A0")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000A18")]
			[Cpp2IlInjected.Address(RVA = "0xD6EFC0", Offset = "0xD6D9C0", VA = "0x180D6EFC0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000450")]
		public int XpAmount
		{
			[Cpp2IlInjected.Token(Token = "0x6000A19")]
			[Cpp2IlInjected.Address(RVA = "0xD60890", Offset = "0xD5F290", VA = "0x180D60890")]
			[CompilerGenerated]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x6000A1A")]
			[Cpp2IlInjected.Address(RVA = "0x1708EF0", Offset = "0x17078F0", VA = "0x181708EF0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000451")]
		public List<int>? GiftDropIds
		{
			[Cpp2IlInjected.Token(Token = "0x6000A1B")]
			[Cpp2IlInjected.Address(RVA = "0xD12280", Offset = "0xD10C80", VA = "0x180D12280")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000A1C")]
			[Cpp2IlInjected.Address(RVA = "0xD11B50", Offset = "0xD10550", VA = "0x180D11B50")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000452")]
		public RecipeUnlockState DefaultUnlockState
		{
			[Cpp2IlInjected.Token(Token = "0x6000A1D")]
			[Cpp2IlInjected.Address(RVA = "0xD2DD40", Offset = "0xD2C740", VA = "0x180D2DD40")]
			[CompilerGenerated]
			get
			{
				return default(RecipeUnlockState);
			}
			[Cpp2IlInjected.Token(Token = "0x6000A1E")]
			[Cpp2IlInjected.Address(RVA = "0xD89720", Offset = "0xD88120", VA = "0x180D89720")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000A1F")]
		[Cpp2IlInjected.Address(RVA = "0xD16C40", Offset = "0xD15640", VA = "0x180D16C40")]
		public RecipeDTO()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200016C")]
	[Utf8JsonSerializable]
	public class CookRecipeResultDTO
	{
		[Cpp2IlInjected.Token(Token = "0x17000453")]
		public int RecipeId
		{
			[Cpp2IlInjected.Token(Token = "0x6000A20")]
			[Cpp2IlInjected.Address(RVA = "0xD0F110", Offset = "0xD0DB10", VA = "0x180D0F110")]
			[CompilerGenerated]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x6000A21")]
			[Cpp2IlInjected.Address(RVA = "0xD12F30", Offset = "0xD11930", VA = "0x180D12F30")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000454")]
		public int XpGranted
		{
			[Cpp2IlInjected.Token(Token = "0x6000A22")]
			[Cpp2IlInjected.Address(RVA = "0xE073A0", Offset = "0xE05DA0", VA = "0x180E073A0")]
			[CompilerGenerated]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x6000A23")]
			[Cpp2IlInjected.Address(RVA = "0xE073B0", Offset = "0xE05DB0", VA = "0x180E073B0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000455")]
		public List<GiftPackage> GiftPackages
		{
			[Cpp2IlInjected.Token(Token = "0x6000A24")]
			[Cpp2IlInjected.Address(RVA = "0xD11B30", Offset = "0xD10530", VA = "0x180D11B30")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000A25")]
			[Cpp2IlInjected.Address(RVA = "0xD12270", Offset = "0xD10C70", VA = "0x180D12270")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000456")]
		public List<int> GiftDropIds
		{
			[Cpp2IlInjected.Token(Token = "0x6000A26")]
			[Cpp2IlInjected.Address(RVA = "0xD12BC0", Offset = "0xD115C0", VA = "0x180D12BC0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000A27")]
			[Cpp2IlInjected.Address(RVA = "0xD11520", Offset = "0xD0FF20", VA = "0x180D11520")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000457")]
		public bool DidUnlockRecipe
		{
			[Cpp2IlInjected.Token(Token = "0x6000A28")]
			[Cpp2IlInjected.Address(RVA = "0xDA36E0", Offset = "0xDA20E0", VA = "0x180DA36E0")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000A29")]
			[Cpp2IlInjected.Address(RVA = "0xDA36F0", Offset = "0xDA20F0", VA = "0x180DA36F0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000458")]
		public bool DidUnlockFinalRecipe
		{
			[Cpp2IlInjected.Token(Token = "0x6000A2A")]
			[Cpp2IlInjected.Address(RVA = "0xF82510", Offset = "0xF80F10", VA = "0x180F82510")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000A2B")]
			[Cpp2IlInjected.Address(RVA = "0xF82520", Offset = "0xF80F20", VA = "0x180F82520")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000A2C")]
		[Cpp2IlInjected.Address(RVA = "0x8DCF130", Offset = "0x8DCDB30", VA = "0x188DCF130")]
		public CookRecipeResultDTO()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200016D")]
	[Utf8JsonSerializable]
	public class RecipesEventChallengeLaneConfigDTO
	{
		[Cpp2IlInjected.Token(Token = "0x17000459")]
		public int ChallengeLaneId
		{
			[Cpp2IlInjected.Token(Token = "0x6000A2D")]
			[Cpp2IlInjected.Address(RVA = "0xD0F110", Offset = "0xD0DB10", VA = "0x180D0F110")]
			[CompilerGenerated]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x6000A2E")]
			[Cpp2IlInjected.Address(RVA = "0xD12F30", Offset = "0xD11930", VA = "0x180D12F30")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700045A")]
		public RecipesRarity Rarity
		{
			[Cpp2IlInjected.Token(Token = "0x6000A2F")]
			[Cpp2IlInjected.Address(RVA = "0xE073A0", Offset = "0xE05DA0", VA = "0x180E073A0")]
			[CompilerGenerated]
			get
			{
				return default(RecipesRarity);
			}
			[Cpp2IlInjected.Token(Token = "0x6000A30")]
			[Cpp2IlInjected.Address(RVA = "0xE073B0", Offset = "0xE05DB0", VA = "0x180E073B0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000A31")]
		[Cpp2IlInjected.Address(RVA = "0xD16C40", Offset = "0xD15640", VA = "0x180D16C40")]
		public RecipesEventChallengeLaneConfigDTO()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200016E")]
	[Utf8JsonSerializable]
	public class RecipesEventChallengeLaneDTO
	{
		[Cpp2IlInjected.Token(Token = "0x1700045B")]
		public int ChallengeLaneId
		{
			[Cpp2IlInjected.Token(Token = "0x6000A32")]
			[Cpp2IlInjected.Address(RVA = "0xD0F110", Offset = "0xD0DB10", VA = "0x180D0F110")]
			[CompilerGenerated]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x6000A33")]
			[Cpp2IlInjected.Address(RVA = "0xD12F30", Offset = "0xD11930", VA = "0x180D12F30")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700045C")]
		public int ChallengeTypeId
		{
			[Cpp2IlInjected.Token(Token = "0x6000A34")]
			[Cpp2IlInjected.Address(RVA = "0xE073A0", Offset = "0xE05DA0", VA = "0x180E073A0")]
			[CompilerGenerated]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x6000A35")]
			[Cpp2IlInjected.Address(RVA = "0xE073B0", Offset = "0xE05DB0", VA = "0x180E073B0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700045D")]
		public int IngredientId
		{
			[Cpp2IlInjected.Token(Token = "0x6000A36")]
			[Cpp2IlInjected.Address(RVA = "0xD17340", Offset = "0xD15D40", VA = "0x180D17340")]
			[CompilerGenerated]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x6000A37")]
			[Cpp2IlInjected.Address(RVA = "0xD17360", Offset = "0xD15D60", VA = "0x180D17360")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700045E")]
		public int IngredientCount
		{
			[Cpp2IlInjected.Token(Token = "0x6000A38")]
			[Cpp2IlInjected.Address(RVA = "0x1664600", Offset = "0x1663000", VA = "0x181664600")]
			[CompilerGenerated]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x6000A39")]
			[Cpp2IlInjected.Address(RVA = "0x1664610", Offset = "0x1663010", VA = "0x181664610")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000A3A")]
		[Cpp2IlInjected.Address(RVA = "0x8DD06E0", Offset = "0x8DCF0E0", VA = "0x188DD06E0")]
		public RecipesEventChallengeLaneDTO()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200016F")]
	[Utf8JsonSerializable]
	public class RecipesEventChallengesDTO
	{
		[Cpp2IlInjected.Token(Token = "0x1700045F")]
		public List<RecipesEventChallengeLaneDTO> ChallengeLanes
		{
			[Cpp2IlInjected.Token(Token = "0x6000A3B")]
			[Cpp2IlInjected.Address(RVA = "0xD117B0", Offset = "0xD101B0", VA = "0x180D117B0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000A3C")]
			[Cpp2IlInjected.Address(RVA = "0xD117C0", Offset = "0xD101C0", VA = "0x180D117C0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000A3D")]
		[Cpp2IlInjected.Address(RVA = "0xD16C40", Offset = "0xD15640", VA = "0x180D16C40")]
		public RecipesEventChallengesDTO()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000170")]
	[Utf8JsonSerializable]
	public class CompleteChallengeResponseDTO
	{
		[Cpp2IlInjected.Token(Token = "0x17000460")]
		public RecipesEventRewardsDTO Rewards
		{
			[Cpp2IlInjected.Token(Token = "0x6000A3E")]
			[Cpp2IlInjected.Address(RVA = "0xD117B0", Offset = "0xD101B0", VA = "0x180D117B0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000A3F")]
			[Cpp2IlInjected.Address(RVA = "0xD117C0", Offset = "0xD101C0", VA = "0x180D117C0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000461")]
		public RecipesEventChallengesDTO ChallengeLanes
		{
			[Cpp2IlInjected.Token(Token = "0x6000A40")]
			[Cpp2IlInjected.Address(RVA = "0xD11B30", Offset = "0xD10530", VA = "0x180D11B30")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000A41")]
			[Cpp2IlInjected.Address(RVA = "0xD12270", Offset = "0xD10C70", VA = "0x180D12270")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000A42")]
		[Cpp2IlInjected.Address(RVA = "0xD16C40", Offset = "0xD15640", VA = "0x180D16C40")]
		public CompleteChallengeResponseDTO()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000171")]
	[Utf8JsonSerializable]
	public class RecipesEventRewardsDTO
	{
		[Cpp2IlInjected.Token(Token = "0x17000462")]
		public List<IngredientRewardDTO> Ingredients
		{
			[Cpp2IlInjected.Token(Token = "0x6000A43")]
			[Cpp2IlInjected.Address(RVA = "0xD117B0", Offset = "0xD101B0", VA = "0x180D117B0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000A44")]
			[Cpp2IlInjected.Address(RVA = "0xD117C0", Offset = "0xD101C0", VA = "0x180D117C0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000463")]
		public int CurrencyAmount
		{
			[Cpp2IlInjected.Token(Token = "0x6000A45")]
			[Cpp2IlInjected.Address(RVA = "0xD17340", Offset = "0xD15D40", VA = "0x180D17340")]
			[CompilerGenerated]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x6000A46")]
			[Cpp2IlInjected.Address(RVA = "0xD17360", Offset = "0xD15D60", VA = "0x180D17360")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000A47")]
		[Cpp2IlInjected.Address(RVA = "0xD16C40", Offset = "0xD15640", VA = "0x180D16C40")]
		public RecipesEventRewardsDTO()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000172")]
	[Utf8JsonSerializable]
	public class IngredientRewardDTO
	{
		[Cpp2IlInjected.Token(Token = "0x17000464")]
		public int IngredientId
		{
			[Cpp2IlInjected.Token(Token = "0x6000A48")]
			[Cpp2IlInjected.Address(RVA = "0xD0F110", Offset = "0xD0DB10", VA = "0x180D0F110")]
			[CompilerGenerated]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x6000A49")]
			[Cpp2IlInjected.Address(RVA = "0xD12F30", Offset = "0xD11930", VA = "0x180D12F30")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000465")]
		public int Count
		{
			[Cpp2IlInjected.Token(Token = "0x6000A4A")]
			[Cpp2IlInjected.Address(RVA = "0xE073A0", Offset = "0xE05DA0", VA = "0x180E073A0")]
			[CompilerGenerated]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x6000A4B")]
			[Cpp2IlInjected.Address(RVA = "0xE073B0", Offset = "0xE05DB0", VA = "0x180E073B0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000A4C")]
		[Cpp2IlInjected.Address(RVA = "0xD16C40", Offset = "0xD15640", VA = "0x180D16C40")]
		public IngredientRewardDTO()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000173")]
	public enum RecipeUnlockState
	{
		[Cpp2IlInjected.Token(Token = "0x4000760")]
		Unknown,
		[Cpp2IlInjected.Token(Token = "0x4000761")]
		Hinted,
		[Cpp2IlInjected.Token(Token = "0x4000762")]
		Unlocked,
		[Cpp2IlInjected.Token(Token = "0x4000763")]
		Hidden
	}
	[Cpp2IlInjected.Token(Token = "0x2000174")]
	[Utf8JsonSerializable]
	public class IngredientRecordDTO
	{
		[Cpp2IlInjected.Token(Token = "0x17000466")]
		public int IngredientId
		{
			[Cpp2IlInjected.Token(Token = "0x6000A4D")]
			[Cpp2IlInjected.Address(RVA = "0xD0F110", Offset = "0xD0DB10", VA = "0x180D0F110")]
			[CompilerGenerated]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x6000A4E")]
			[Cpp2IlInjected.Address(RVA = "0xD12F30", Offset = "0xD11930", VA = "0x180D12F30")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000467")]
		public int Count
		{
			[Cpp2IlInjected.Token(Token = "0x6000A4F")]
			[Cpp2IlInjected.Address(RVA = "0xE073A0", Offset = "0xE05DA0", VA = "0x180E073A0")]
			[CompilerGenerated]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x6000A50")]
			[Cpp2IlInjected.Address(RVA = "0xE073B0", Offset = "0xE05DB0", VA = "0x180E073B0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000A51")]
		[Cpp2IlInjected.Address(RVA = "0xD16C40", Offset = "0xD15640", VA = "0x180D16C40")]
		public IngredientRecordDTO()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000175")]
	[Utf8JsonSerializable]
	public class RecipeRecordDTO
	{
		[Cpp2IlInjected.Token(Token = "0x17000468")]
		public int RecipeId
		{
			[Cpp2IlInjected.Token(Token = "0x6000A52")]
			[Cpp2IlInjected.Address(RVA = "0xD0F110", Offset = "0xD0DB10", VA = "0x180D0F110")]
			[CompilerGenerated]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x6000A53")]
			[Cpp2IlInjected.Address(RVA = "0xD12F30", Offset = "0xD11930", VA = "0x180D12F30")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000469")]
		public RecipeUnlockState UnlockState
		{
			[Cpp2IlInjected.Token(Token = "0x6000A54")]
			[Cpp2IlInjected.Address(RVA = "0xE073A0", Offset = "0xE05DA0", VA = "0x180E073A0")]
			[CompilerGenerated]
			get
			{
				return default(RecipeUnlockState);
			}
			[Cpp2IlInjected.Token(Token = "0x6000A55")]
			[Cpp2IlInjected.Address(RVA = "0xE073B0", Offset = "0xE05DB0", VA = "0x180E073B0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700046A")]
		public IncrementalCookRecordDTO? IncrementalCook
		{
			[Cpp2IlInjected.Token(Token = "0x6000A56")]
			[Cpp2IlInjected.Address(RVA = "0xD11B30", Offset = "0xD10530", VA = "0x180D11B30")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000A57")]
			[Cpp2IlInjected.Address(RVA = "0xD12270", Offset = "0xD10C70", VA = "0x180D12270")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000A58")]
		[Cpp2IlInjected.Address(RVA = "0xD16C40", Offset = "0xD15640", VA = "0x180D16C40")]
		public RecipeRecordDTO()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000176")]
	[Utf8JsonSerializable]
	public class RecipesEventRecordDTO
	{
		[Cpp2IlInjected.Token(Token = "0x1700046B")]
		public int AccountId
		{
			[Cpp2IlInjected.Token(Token = "0x6000A59")]
			[Cpp2IlInjected.Address(RVA = "0xD0F110", Offset = "0xD0DB10", VA = "0x180D0F110")]
			[CompilerGenerated]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x6000A5A")]
			[Cpp2IlInjected.Address(RVA = "0xD12F30", Offset = "0xD11930", VA = "0x180D12F30")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700046C")]
		public Guid RecipesEventId
		{
			[Cpp2IlInjected.Token(Token = "0x6000A5B")]
			[Cpp2IlInjected.Address(RVA = "0x1C7CC20", Offset = "0x1C7B620", VA = "0x181C7CC20")]
			[CompilerGenerated]
			get
			{
				return default(Guid);
			}
			[Cpp2IlInjected.Token(Token = "0x6000A5C")]
			[Cpp2IlInjected.Address(RVA = "0x7A23450", Offset = "0x7A21E50", VA = "0x187A23450")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700046D")]
		public List<IngredientRecordDTO> Ingredients
		{
			[Cpp2IlInjected.Token(Token = "0x6000A5D")]
			[Cpp2IlInjected.Address(RVA = "0xD11B00", Offset = "0xD10500", VA = "0x180D11B00")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000A5E")]
			[Cpp2IlInjected.Address(RVA = "0xD11530", Offset = "0xD0FF30", VA = "0x180D11530")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700046E")]
		public List<RecipeRecordDTO> Recipes
		{
			[Cpp2IlInjected.Token(Token = "0x6000A5F")]
			[Cpp2IlInjected.Address(RVA = "0xD11A20", Offset = "0xD10420", VA = "0x180D11A20")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000A60")]
			[Cpp2IlInjected.Address(RVA = "0xD17350", Offset = "0xD15D50", VA = "0x180D17350")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000A61")]
		[Cpp2IlInjected.Address(RVA = "0xD16C40", Offset = "0xD15640", VA = "0x180D16C40")]
		public RecipesEventRecordDTO()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000177")]
	public class MPNSALGBXFX
	{
		[Cpp2IlInjected.Token(Token = "0x1700046F")]
		public Dictionary<int, int> FQASVXTVYTA
		{
			[Cpp2IlInjected.Token(Token = "0x6000A62")]
			[Cpp2IlInjected.Address(RVA = "0xD117B0", Offset = "0xD101B0", VA = "0x180D117B0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000A63")]
			[Cpp2IlInjected.Address(RVA = "0xD117C0", Offset = "0xD101C0", VA = "0x180D117C0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000470")]
		public string? ALWQMHAEPDN
		{
			[Cpp2IlInjected.Token(Token = "0x6000A64")]
			[Cpp2IlInjected.Address(RVA = "0xD11B30", Offset = "0xD10530", VA = "0x180D11B30")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000A65")]
			[Cpp2IlInjected.Address(RVA = "0xD12270", Offset = "0xD10C70", VA = "0x180D12270")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000A66")]
		[Cpp2IlInjected.Address(RVA = "0x8DCF6C0", Offset = "0x8DCE0C0", VA = "0x188DCF6C0")]
		public MPNSALGBXFX()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000178")]
	[Utf8JsonSerializable]
	public class StageIngredientsRequestDTO : MPNSALGBXFX
	{
		[Cpp2IlInjected.Token(Token = "0x6000A67")]
		[Cpp2IlInjected.Address(RVA = "0x8DCF6B0", Offset = "0x8DCE0B0", VA = "0x188DCF6B0")]
		public StageIngredientsRequestDTO()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000179")]
	[Utf8JsonSerializable]
	public class IncrementalCookRecordDTO : MPNSALGBXFX
	{
		[Cpp2IlInjected.Token(Token = "0x6000A68")]
		[Cpp2IlInjected.Address(RVA = "0x8DCF6B0", Offset = "0x8DCE0B0", VA = "0x188DCF6B0")]
		public IncrementalCookRecordDTO()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200017A")]
	[Utf8JsonSerializable]
	public class CookRecipeFromIngredientsRequestDTO
	{
		[Cpp2IlInjected.Token(Token = "0x17000471")]
		public Dictionary<int, int>? IngredientCounts
		{
			[Cpp2IlInjected.Token(Token = "0x6000A69")]
			[Cpp2IlInjected.Address(RVA = "0xD117B0", Offset = "0xD101B0", VA = "0x180D117B0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000A6A")]
			[Cpp2IlInjected.Address(RVA = "0xD117C0", Offset = "0xD101C0", VA = "0x180D117C0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000A6B")]
		[Cpp2IlInjected.Address(RVA = "0xD16C40", Offset = "0xD15640", VA = "0x180D16C40")]
		public CookRecipeFromIngredientsRequestDTO()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200017B")]
	[Utf8JsonSerializable]
	public class RecipeChallengeTypeDTO
	{
		[Cpp2IlInjected.Token(Token = "0x17000472")]
		public int Id
		{
			[Cpp2IlInjected.Token(Token = "0x6000A6C")]
			[Cpp2IlInjected.Address(RVA = "0xD0F110", Offset = "0xD0DB10", VA = "0x180D0F110")]
			[CompilerGenerated]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x6000A6D")]
			[Cpp2IlInjected.Address(RVA = "0xD12F30", Offset = "0xD11930", VA = "0x180D12F30")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000473")]
		public string Name
		{
			[Cpp2IlInjected.Token(Token = "0x6000A6E")]
			[Cpp2IlInjected.Address(RVA = "0xD11B30", Offset = "0xD10530", VA = "0x180D11B30")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000A6F")]
			[Cpp2IlInjected.Address(RVA = "0xD12270", Offset = "0xD10C70", VA = "0x180D12270")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000474")]
		public string ImagePath
		{
			[Cpp2IlInjected.Token(Token = "0x6000A70")]
			[Cpp2IlInjected.Address(RVA = "0xD12BC0", Offset = "0xD115C0", VA = "0x180D12BC0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000A71")]
			[Cpp2IlInjected.Address(RVA = "0xD11520", Offset = "0xD0FF20", VA = "0x180D11520")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000475")]
		public string ConfigJson
		{
			[Cpp2IlInjected.Token(Token = "0x6000A72")]
			[Cpp2IlInjected.Address(RVA = "0xD11B00", Offset = "0xD10500", VA = "0x180D11B00")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000A73")]
			[Cpp2IlInjected.Address(RVA = "0xD11530", Offset = "0xD0FF30", VA = "0x180D11530")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000476")]
		public float Weight
		{
			[Cpp2IlInjected.Token(Token = "0x6000A74")]
			[Cpp2IlInjected.Address(RVA = "0xE9AEE0", Offset = "0xE998E0", VA = "0x180E9AEE0")]
			[CompilerGenerated]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x6000A75")]
			[Cpp2IlInjected.Address(RVA = "0x10E0B20", Offset = "0x10DF520", VA = "0x1810E0B20")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000477")]
		public RecipesRarity Rarity
		{
			[Cpp2IlInjected.Token(Token = "0x6000A76")]
			[Cpp2IlInjected.Address(RVA = "0xD60890", Offset = "0xD5F290", VA = "0x180D60890")]
			[CompilerGenerated]
			get
			{
				return default(RecipesRarity);
			}
			[Cpp2IlInjected.Token(Token = "0x6000A77")]
			[Cpp2IlInjected.Address(RVA = "0x1708EF0", Offset = "0x17078F0", VA = "0x181708EF0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000A78")]
		[Cpp2IlInjected.Address(RVA = "0xD16C40", Offset = "0xD15640", VA = "0x180D16C40")]
		public RecipeChallengeTypeDTO()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200017C")]
	[Utf8JsonSerializable]
	public class SuperStageResultDTO
	{
		[Cpp2IlInjected.Token(Token = "0x17000478")]
		public CurrencyType CurrencyType
		{
			[Cpp2IlInjected.Token(Token = "0x6000A79")]
			[Cpp2IlInjected.Address(RVA = "0xD0F110", Offset = "0xD0DB10", VA = "0x180D0F110")]
			[CompilerGenerated]
			get
			{
				return default(CurrencyType);
			}
			[Cpp2IlInjected.Token(Token = "0x6000A7A")]
			[Cpp2IlInjected.Address(RVA = "0xD12F30", Offset = "0xD11930", VA = "0x180D12F30")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000479")]
		public int CurrencyCount
		{
			[Cpp2IlInjected.Token(Token = "0x6000A7B")]
			[Cpp2IlInjected.Address(RVA = "0xE073A0", Offset = "0xE05DA0", VA = "0x180E073A0")]
			[CompilerGenerated]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x6000A7C")]
			[Cpp2IlInjected.Address(RVA = "0xE073B0", Offset = "0xE05DB0", VA = "0x180E073B0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700047A")]
		public int IngredientId
		{
			[Cpp2IlInjected.Token(Token = "0x6000A7D")]
			[Cpp2IlInjected.Address(RVA = "0xD17340", Offset = "0xD15D40", VA = "0x180D17340")]
			[CompilerGenerated]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x6000A7E")]
			[Cpp2IlInjected.Address(RVA = "0xD17360", Offset = "0xD15D60", VA = "0x180D17360")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700047B")]
		public int IngredientQuantity
		{
			[Cpp2IlInjected.Token(Token = "0x6000A7F")]
			[Cpp2IlInjected.Address(RVA = "0x1664600", Offset = "0x1663000", VA = "0x181664600")]
			[CompilerGenerated]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x6000A80")]
			[Cpp2IlInjected.Address(RVA = "0x1664610", Offset = "0x1663010", VA = "0x181664610")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700047C")]
		public IncrementalCookRecordDTO? IncrementalCook
		{
			[Cpp2IlInjected.Token(Token = "0x6000A81")]
			[Cpp2IlInjected.Address(RVA = "0xD12BC0", Offset = "0xD115C0", VA = "0x180D12BC0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000A82")]
			[Cpp2IlInjected.Address(RVA = "0xD11520", Offset = "0xD0FF20", VA = "0x180D11520")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000A83")]
		[Cpp2IlInjected.Address(RVA = "0xD16C40", Offset = "0xD15640", VA = "0x180D16C40")]
		public SuperStageResultDTO()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200017D")]
	public enum RecipesRarity
	{
		[Cpp2IlInjected.Token(Token = "0x400077C")]
		Common,
		[Cpp2IlInjected.Token(Token = "0x400077D")]
		Uncommon,
		[Cpp2IlInjected.Token(Token = "0x400077E")]
		Rare,
		[Cpp2IlInjected.Token(Token = "0x400077F")]
		Legendary
	}
	[Cpp2IlInjected.Token(Token = "0x200017E")]
	[JsonPolymorphic(TypeDiscriminatorPropertyName = "$type")]
	[JsonDerivedType(typeof(InRoomWithTagXpMultiplierDTO), "InRoomWithTag")]
	[JsonDerivedType(typeof(ActiveRoomBoostCountXpMultiplierDTO), "ActiveRoomBoostCount")]
	[JsonDerivedType(typeof(OwnsAvatarItemXpMultiplierDTO), "OwnsAvatarItem")]
	[JsonDerivedType(typeof(OwnsCustomAvatarItemXpMultiplierDTO), "OwnsCustomAvatarItem")]
	[JsonDerivedType(typeof(ActiveConsumableXpMultiplierDTO), "ActiveConsumable")]
	[Utf8JsonSerializable]
	public class TimedEventXpMultiplierDTO
	{
		[Cpp2IlInjected.Token(Token = "0x1700047D")]
		public float XpMultiplier
		{
			[Cpp2IlInjected.Token(Token = "0x6000A84")]
			[Cpp2IlInjected.Address(RVA = "0xDBC130", Offset = "0xDBAB30", VA = "0x180DBC130")]
			[CompilerGenerated]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x6000A85")]
			[Cpp2IlInjected.Address(RVA = "0xDFEAF0", Offset = "0xDFD4F0", VA = "0x180DFEAF0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000A86")]
		[Cpp2IlInjected.Address(RVA = "0xD16C40", Offset = "0xD15640", VA = "0x180D16C40")]
		public TimedEventXpMultiplierDTO()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200017F")]
	[Utf8JsonSerializable]
	public class InRoomWithTagXpMultiplierDTO : TimedEventXpMultiplierDTO
	{
		[Cpp2IlInjected.Token(Token = "0x1700047E")]
		public List<string> Tags
		{
			[Cpp2IlInjected.Token(Token = "0x6000A87")]
			[Cpp2IlInjected.Address(RVA = "0xD11B30", Offset = "0xD10530", VA = "0x180D11B30")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000A88")]
			[Cpp2IlInjected.Address(RVA = "0xD12270", Offset = "0xD10C70", VA = "0x180D12270")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000A89")]
		[Cpp2IlInjected.Address(RVA = "0x8DCF630", Offset = "0x8DCE030", VA = "0x188DCF630")]
		public InRoomWithTagXpMultiplierDTO()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000180")]
	[Utf8JsonSerializable]
	public class ActiveRoomBoostCountXpMultiplierDTO : TimedEventXpMultiplierDTO
	{
		[Cpp2IlInjected.Token(Token = "0x1700047F")]
		public List<long> RoomIds
		{
			[Cpp2IlInjected.Token(Token = "0x6000A8A")]
			[Cpp2IlInjected.Address(RVA = "0xD11B30", Offset = "0xD10530", VA = "0x180D11B30")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000A8B")]
			[Cpp2IlInjected.Address(RVA = "0xD12270", Offset = "0xD10C70", VA = "0x180D12270")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000480")]
		public int MinRoomBoostCount
		{
			[Cpp2IlInjected.Token(Token = "0x6000A8C")]
			[Cpp2IlInjected.Address(RVA = "0xD215F0", Offset = "0xD1FFF0", VA = "0x180D215F0")]
			[CompilerGenerated]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x6000A8D")]
			[Cpp2IlInjected.Address(RVA = "0xD682F0", Offset = "0xD66CF0", VA = "0x180D682F0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000481")]
		public int? MaxRoomBoostCount
		{
			[Cpp2IlInjected.Token(Token = "0x6000A8E")]
			[Cpp2IlInjected.Address(RVA = "0x141BB60", Offset = "0x141A560", VA = "0x18141BB60")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000A8F")]
			[Cpp2IlInjected.Address(RVA = "0x10CE4D0", Offset = "0x10CCED0", VA = "0x1810CE4D0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000A90")]
		[Cpp2IlInjected.Address(RVA = "0x8DCB440", Offset = "0x8DC9E40", VA = "0x188DCB440")]
		public ActiveRoomBoostCountXpMultiplierDTO()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000181")]
	[Utf8JsonSerializable]
	public class OwnsAvatarItemXpMultiplierDTO : TimedEventXpMultiplierDTO
	{
		[Cpp2IlInjected.Token(Token = "0x17000482")]
		public List<int> AvatarItemIds
		{
			[Cpp2IlInjected.Token(Token = "0x6000A91")]
			[Cpp2IlInjected.Address(RVA = "0xD11B30", Offset = "0xD10530", VA = "0x180D11B30")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000A92")]
			[Cpp2IlInjected.Address(RVA = "0xD12270", Offset = "0xD10C70", VA = "0x180D12270")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000A93")]
		[Cpp2IlInjected.Address(RVA = "0x8DCF740", Offset = "0x8DCE140", VA = "0x188DCF740")]
		public OwnsAvatarItemXpMultiplierDTO()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000182")]
	[Utf8JsonSerializable]
	public class OwnsCustomAvatarItemXpMultiplierDTO : TimedEventXpMultiplierDTO
	{
		[Cpp2IlInjected.Token(Token = "0x17000483")]
		public List<Guid> CustomAvatarItemIds
		{
			[Cpp2IlInjected.Token(Token = "0x6000A94")]
			[Cpp2IlInjected.Address(RVA = "0xD11B30", Offset = "0xD10530", VA = "0x180D11B30")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000A95")]
			[Cpp2IlInjected.Address(RVA = "0xD12270", Offset = "0xD10C70", VA = "0x180D12270")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000A96")]
		[Cpp2IlInjected.Address(RVA = "0x8DCF7C0", Offset = "0x8DCE1C0", VA = "0x188DCF7C0")]
		public OwnsCustomAvatarItemXpMultiplierDTO()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000183")]
	[Utf8JsonSerializable]
	public class ActiveConsumableXpMultiplierDTO : TimedEventXpMultiplierDTO
	{
		[Cpp2IlInjected.Token(Token = "0x17000484")]
		public List<int> ConsumableItemIds
		{
			[Cpp2IlInjected.Token(Token = "0x6000A97")]
			[Cpp2IlInjected.Address(RVA = "0xD11B30", Offset = "0xD10530", VA = "0x180D11B30")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000A98")]
			[Cpp2IlInjected.Address(RVA = "0xD12270", Offset = "0xD10C70", VA = "0x180D12270")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000A99")]
		[Cpp2IlInjected.Address(RVA = "0x8DCB3C0", Offset = "0x8DC9DC0", VA = "0x188DCB3C0")]
		public ActiveConsumableXpMultiplierDTO()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000184")]
	[Utf8JsonSerializable]
	public class ClientAuthoritativeCounterRateLimiterConfigDTO
	{
		[Cpp2IlInjected.Token(Token = "0x17000485")]
		public float MaxValuePerRequest
		{
			[Cpp2IlInjected.Token(Token = "0x6000A9A")]
			[Cpp2IlInjected.Address(RVA = "0xDBC130", Offset = "0xDBAB30", VA = "0x180DBC130")]
			[CompilerGenerated]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x6000A9B")]
			[Cpp2IlInjected.Address(RVA = "0xDFEAF0", Offset = "0xDFD4F0", VA = "0x180DFEAF0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000486")]
		public int RateLimitWindowMinutes
		{
			[Cpp2IlInjected.Token(Token = "0x6000A9C")]
			[Cpp2IlInjected.Address(RVA = "0xE073A0", Offset = "0xE05DA0", VA = "0x180E073A0")]
			[CompilerGenerated]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x6000A9D")]
			[Cpp2IlInjected.Address(RVA = "0xE073B0", Offset = "0xE05DB0", VA = "0x180E073B0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000487")]
		public float MaxValuePerWindow
		{
			[Cpp2IlInjected.Token(Token = "0x6000A9E")]
			[Cpp2IlInjected.Address(RVA = "0xD77800", Offset = "0xD76200", VA = "0x180D77800")]
			[CompilerGenerated]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x6000A9F")]
			[Cpp2IlInjected.Address(RVA = "0x14214C0", Offset = "0x141FEC0", VA = "0x1814214C0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000AA0")]
		[Cpp2IlInjected.Address(RVA = "0xD16C40", Offset = "0xD15640", VA = "0x180D16C40")]
		public ClientAuthoritativeCounterRateLimiterConfigDTO()
		{
		}
	}
}
namespace RecNet.Interfaces.IDs
{
	[Cpp2IlInjected.Token(Token = "0x2000185")]
	public readonly struct GiftDropId : IEquatable<GiftDropId>, IComparable<GiftDropId>, IComparable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400078B")]
		public readonly int Id;

		[Cpp2IlInjected.Token(Token = "0x17000488")]
		public static GiftDropId RJBIAJLIIHG
		{
			[Cpp2IlInjected.Token(Token = "0x6000AA1")]
			[Cpp2IlInjected.Address(RVA = "0xD10160", Offset = "0xD0EB60", VA = "0x180D10160")]
			get
			{
				return default(GiftDropId);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000AA2")]
		[Cpp2IlInjected.Address(RVA = "0x15E9000", Offset = "0x15E7A00", VA = "0x1815E9000")]
		public GiftDropId(int id)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000AA3")]
		[Cpp2IlInjected.Address(RVA = "0x8DCF5D0", Offset = "0x8DCDFD0", VA = "0x188DCF5D0", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[SpecialName]
		[Cpp2IlInjected.Token(Token = "0x6000AA4")]
		[Cpp2IlInjected.Address(RVA = "0x1D0EB00", Offset = "0x1D0D500", VA = "0x181D0EB00")]
		public static GiftDropId XMLODUCXLQP(int a)
		{
			return default(GiftDropId);
		}

		[SpecialName]
		[Cpp2IlInjected.Token(Token = "0x6000AA5")]
		[Cpp2IlInjected.Address(RVA = "0x1D0EB00", Offset = "0x1D0D500", VA = "0x181D0EB00")]
		public static int XMLODUCXLQP(GiftDropId a)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000AA6")]
		[Cpp2IlInjected.Address(RVA = "0x23BC780", Offset = "0x23BB180", VA = "0x1823BC780", Slot = "4")]
		public bool Equals(GiftDropId other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000AA7")]
		[Cpp2IlInjected.Address(RVA = "0x8DCF540", Offset = "0x8DCDF40", VA = "0x188DCF540", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000AA8")]
		[Cpp2IlInjected.Address(RVA = "0xF86CD0", Offset = "0xF856D0", VA = "0x180F86CD0", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[SpecialName]
		[Cpp2IlInjected.Token(Token = "0x6000AA9")]
		[Cpp2IlInjected.Address(RVA = "0x23BC7A0", Offset = "0x23BB1A0", VA = "0x1823BC7A0")]
		public static bool ITVTPRNZGNV(GiftDropId a, GiftDropId b)
		{
			return default(bool);
		}

		[SpecialName]
		[Cpp2IlInjected.Token(Token = "0x6000AAA")]
		[Cpp2IlInjected.Address(RVA = "0x8DCF450", Offset = "0x8DCDE50", VA = "0x188DCF450")]
		public static bool CYAUITUETAA(GiftDropId a, GiftDropId b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000AAB")]
		[Cpp2IlInjected.Address(RVA = "0x23C63E0", Offset = "0x23C4DE0", VA = "0x1823C63E0", Slot = "5")]
		public int CompareTo(GiftDropId other)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000AAC")]
		[Cpp2IlInjected.Address(RVA = "0x8DCF460", Offset = "0x8DCDE60", VA = "0x188DCF460", Slot = "6")]
		public int CompareTo(object obj)
		{
			return default(int);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000186")]
	public readonly struct PurchasableItemId : IEquatable<PurchasableItemId>, IComparable<PurchasableItemId>, IComparable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400078C")]
		public readonly int Id;

		[Cpp2IlInjected.Token(Token = "0x17000489")]
		public static PurchasableItemId RJBIAJLIIHG
		{
			[Cpp2IlInjected.Token(Token = "0x6000AAD")]
			[Cpp2IlInjected.Address(RVA = "0xD10160", Offset = "0xD0EB60", VA = "0x180D10160")]
			get
			{
				return default(PurchasableItemId);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000AAE")]
		[Cpp2IlInjected.Address(RVA = "0x15E9000", Offset = "0x15E7A00", VA = "0x1815E9000")]
		public PurchasableItemId(int id)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000AAF")]
		[Cpp2IlInjected.Address(RVA = "0x8DCF9B0", Offset = "0x8DCE3B0", VA = "0x188DCF9B0", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[SpecialName]
		[Cpp2IlInjected.Token(Token = "0x6000AB0")]
		[Cpp2IlInjected.Address(RVA = "0x1D0EB00", Offset = "0x1D0D500", VA = "0x181D0EB00")]
		public static PurchasableItemId XMLODUCXLQP(int a)
		{
			return default(PurchasableItemId);
		}

		[SpecialName]
		[Cpp2IlInjected.Token(Token = "0x6000AB1")]
		[Cpp2IlInjected.Address(RVA = "0x1D0EB00", Offset = "0x1D0D500", VA = "0x181D0EB00")]
		public static int XMLODUCXLQP(PurchasableItemId a)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000AB2")]
		[Cpp2IlInjected.Address(RVA = "0x23BC780", Offset = "0x23BB180", VA = "0x1823BC780", Slot = "4")]
		public bool Equals(PurchasableItemId other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000AB3")]
		[Cpp2IlInjected.Address(RVA = "0x8DCF920", Offset = "0x8DCE320", VA = "0x188DCF920", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000AB4")]
		[Cpp2IlInjected.Address(RVA = "0xF86CD0", Offset = "0xF856D0", VA = "0x180F86CD0", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[SpecialName]
		[Cpp2IlInjected.Token(Token = "0x6000AB5")]
		[Cpp2IlInjected.Address(RVA = "0x23BC7A0", Offset = "0x23BB1A0", VA = "0x1823BC7A0")]
		public static bool ITVTPRNZGNV(PurchasableItemId a, PurchasableItemId b)
		{
			return default(bool);
		}

		[SpecialName]
		[Cpp2IlInjected.Token(Token = "0x6000AB6")]
		[Cpp2IlInjected.Address(RVA = "0x8DCF450", Offset = "0x8DCDE50", VA = "0x188DCF450")]
		public static bool CYAUITUETAA(PurchasableItemId a, PurchasableItemId b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000AB7")]
		[Cpp2IlInjected.Address(RVA = "0x23C63E0", Offset = "0x23C4DE0", VA = "0x1823C63E0", Slot = "5")]
		public int CompareTo(PurchasableItemId other)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000AB8")]
		[Cpp2IlInjected.Address(RVA = "0x8DCF840", Offset = "0x8DCE240", VA = "0x188DCF840", Slot = "6")]
		public int CompareTo(object obj)
		{
			return default(int);
		}
	}
}
namespace RecNet.Common
{
	[Cpp2IlInjected.Token(Token = "0x2000187")]
	[Utf8JsonSerializableGeneric]
	public class VCCRUZAMKGW<a> : QPSFFVWODNU where a : new()
	{
		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x2000188")]
		[CompilerGenerated]
		private struct <OnDeserializedAsync>d__8 : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400078F")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000790")]
			public AsyncTaskMethodBuilder <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000791")]
			public VCCRUZAMKGW<a> <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000792")]
			private IEnumerable<OIRXPKYYAWC> <list1>5__2;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000793")]
			private object <>u__1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000794")]
			private ConfiguredTaskAwaitable.ConfiguredTaskAwaiter <>u__2;

			[Cpp2IlInjected.Token(Token = "0x6000ABF")]
			[Cpp2IlInjected.Address(RVA = "0x6ACBBE0", Offset = "0x6ACA5E0", VA = "0x186ACBBE0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000AC0")]
			[Cpp2IlInjected.Address(RVA = "0x6ACD310", Offset = "0x6ACBD10", VA = "0x186ACD310", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700048A")]
		public IReadOnlyList<a> AKGZQOAYZZD
		{
			[Cpp2IlInjected.Token(Token = "0x6000AB9")]
			[Cpp2IlInjected.Address(RVA = "0xD117B0", Offset = "0xD101B0", VA = "0x180D117B0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000ABA")]
			[Cpp2IlInjected.Address(RVA = "0xD117C0", Offset = "0xD101C0", VA = "0x180D117C0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700048B")]
		public long FOHJTXWWWGN
		{
			[Cpp2IlInjected.Token(Token = "0x6000ABB")]
			[Cpp2IlInjected.Address(RVA = "0xD11B30", Offset = "0xD10530", VA = "0x180D11B30")]
			[CompilerGenerated]
			get
			{
				return default(long);
			}
			[Cpp2IlInjected.Token(Token = "0x6000ABC")]
			[Cpp2IlInjected.Address(RVA = "0xE07390", Offset = "0xE05D90", VA = "0x180E07390")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000ABD")]
		[Cpp2IlInjected.Address(RVA = "0x7FDECC0", Offset = "0x7FDD6C0", VA = "0x187FDECC0", Slot = "4")]
		[AsyncStateMachine(typeof(VCCRUZAMKGW<>.<OnDeserializedAsync>d__8))]
		public Task NLARVXFWNGH()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000ABE")]
		[Cpp2IlInjected.Address(RVA = "0xD16C40", Offset = "0xD15640", VA = "0x180D16C40")]
		public VCCRUZAMKGW()
		{
		}
	}
}
namespace RecNet.Common.PlatformPartners
{
	[Cpp2IlInjected.Token(Token = "0x2000189")]
	public enum PlayStationEnvironment
	{
		[Cpp2IlInjected.Token(Token = "0x4000796")]
		Development = 1,
		[Cpp2IlInjected.Token(Token = "0x4000797")]
		QA = 8,
		[Cpp2IlInjected.Token(Token = "0x4000798")]
		Production = 0x100
	}
}
namespace RecNet.Store
{
	[Cpp2IlInjected.Token(Token = "0x200018A")]
	public interface BLCQZUNHWKD : GOUYYJUDEMP
	{
		[Cpp2IlInjected.Token(Token = "0x1700048C")]
		bool XAOEOHKQUIE
		{
			[Cpp2IlInjected.Token(Token = "0x6000AC1")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x6000AC2")]
		[Cpp2IlInjected.Address(Slot = "1")]
		Task AuthorizePurchaseAsync(long transactionId, SKU sku);

		[Cpp2IlInjected.Token(Token = "0x6000AC3")]
		[Cpp2IlInjected.Address(Slot = "2")]
		Task<FUCDGVARUTZ> PurchaseAsync(SKU sku, SkuPurchaseMetadata purchaseMetadata);

		[Cpp2IlInjected.Token(Token = "0x6000AC4")]
		[Cpp2IlInjected.Address(Slot = "3")]
		Task ValidatePurchasingSupported(TGOHQQCRVXV skuTransaction, CancellationToken cancellationToken);
	}
	[Cpp2IlInjected.Token(Token = "0x200018B")]
	public interface GOUYYJUDEMP
	{
		[Cpp2IlInjected.Token(Token = "0x1700048D")]
		bool FTXUUGKYBLP
		{
			[Cpp2IlInjected.Token(Token = "0x6000AC5")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x6000AC6")]
		[Cpp2IlInjected.Address(Slot = "1")]
		Task<string> FetchCommerceAccessToken([Optional] CancellationToken cancellationToken);
	}
	[Cpp2IlInjected.Token(Token = "0x200018C")]
	public interface VEPISPTSEVV
	{
		[Cpp2IlInjected.Token(Token = "0x1700048E")]
		int BUODVVCYPFW
		{
			[Cpp2IlInjected.Token(Token = "0x6000ACB")]
			[Cpp2IlInjected.Address(Slot = "4")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x6000AC7")]
		[Cpp2IlInjected.Address(Slot = "0")]
		Task<IReadOnlyList<SKU>> DCFHOGWCDWE(bool a = false, [Optional] CancellationToken b);

		[Cpp2IlInjected.Token(Token = "0x6000AC8")]
		[Cpp2IlInjected.Address(Slot = "1")]
		bool YRKTJLBEDDW([Out] SKU? a);

		[Cpp2IlInjected.Token(Token = "0x6000AC9")]
		[Cpp2IlInjected.Address(Slot = "2")]
		Task<SKU> YKVEAWTZXYI(bool a = false, [Optional] CancellationToken b);

		[Cpp2IlInjected.Token(Token = "0x6000ACA")]
		[Cpp2IlInjected.Address(Slot = "3")]
		void NPMVRPNCIWQ(string a = "");
	}
	[Cpp2IlInjected.Token(Token = "0x200018D")]
	public interface WGLTISHEXOX
	{
		[Cpp2IlInjected.Token(Token = "0x6000ACC")]
		[Cpp2IlInjected.Address(Slot = "0")]
		Task YLQFQDMRMYX(TGOHQQCRVXV a, CancellationToken b);

		[Cpp2IlInjected.Token(Token = "0x6000ACD")]
		[Cpp2IlInjected.Address(Slot = "1")]
		Task CUMAQBMMWJF(TGOHQQCRVXV a, CancellationToken b, [Optional] SQKJXPCSBBG? purchaseProgress);
	}
	[Cpp2IlInjected.Token(Token = "0x200018E")]
	public interface SQKJXPCSBBG
	{
		[Cpp2IlInjected.Token(Token = "0x6000ACE")]
		[Cpp2IlInjected.Address(Slot = "0")]
		void UpdateProgress(string text);
	}
	[Cpp2IlInjected.Token(Token = "0x200018F")]
	public interface ICTLNLUYJDU
	{
		[Cpp2IlInjected.Token(Token = "0x6000ACF")]
		[Cpp2IlInjected.Address(Slot = "0")]
		Task OGRNDQBYOZL(TGOHQQCRVXV a, CancellationToken b);
	}
	[Cpp2IlInjected.Token(Token = "0x2000190")]
	public interface JKWMCUDHEPA
	{
		[Cpp2IlInjected.Token(Token = "0x1700048F")]
		bool XZHMTEEGLOW
		{
			[Cpp2IlInjected.Token(Token = "0x6000AD0")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000191")]
	public interface KPZPYXUIZLL
	{
		[Cpp2IlInjected.Token(Token = "0x6000AD1")]
		[Cpp2IlInjected.Address(Slot = "0")]
		TGOHQQCRVXV INCGLYOAMPB(SKU a, SkuPurchaseMetadata b, string c, [Optional] WGLTISHEXOX? purchaseProcessorBehaviorOverride);
	}
	[Cpp2IlInjected.Token(Token = "0x2000192")]
	public interface TQCCAKNMNJS
	{
		[Cpp2IlInjected.Token(Token = "0x6000AD2")]
		[Cpp2IlInjected.Address(Slot = "0")]
		bool SOGIZMPFQUW(ICTLNLUYJDU a);

		[Cpp2IlInjected.Token(Token = "0x6000AD3")]
		[Cpp2IlInjected.Address(Slot = "1")]
		bool LPVAYPCBJSX(ICTLNLUYJDU a);

		[Cpp2IlInjected.Token(Token = "0x6000AD4")]
		[Cpp2IlInjected.Address(Slot = "2")]
		Task YWWRNAIAFUJ(TGOHQQCRVXV a, CancellationToken b);
	}
	[Cpp2IlInjected.Token(Token = "0x2000193")]
	public interface TGOHQQCRVXV : IDisposable
	{
		[Cpp2IlInjected.Token(Token = "0x17000490")]
		TransactionState AEDGIEXZRLO
		{
			[Cpp2IlInjected.Token(Token = "0x6000AD5")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000491")]
		SKU HBUYDVWOQLA
		{
			[Cpp2IlInjected.Token(Token = "0x6000AD6")]
			[Cpp2IlInjected.Address(Slot = "1")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000492")]
		SkuPurchaseMetadata PBKXRCULGVB
		{
			[Cpp2IlInjected.Token(Token = "0x6000AD7")]
			[Cpp2IlInjected.Address(Slot = "2")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000493")]
		string TFMPPUHLTSE
		{
			[Cpp2IlInjected.Token(Token = "0x6000AD8")]
			[Cpp2IlInjected.Address(Slot = "3")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000494")]
		string CMIEBNHDOLZ
		{
			[Cpp2IlInjected.Token(Token = "0x6000AD9")]
			[Cpp2IlInjected.Address(Slot = "4")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x6000ADA")]
		[Cpp2IlInjected.Address(Slot = "5")]
		Task<SkuPurchaseResult> Purchase(CancellationToken externalToken, [Optional] SQKJXPCSBBG? purchaseProgress);

		[Cpp2IlInjected.Token(Token = "0x6000ADB")]
		[Cpp2IlInjected.Address(Slot = "6")]
		void DEKHZJXVRAL(string a);

		[Cpp2IlInjected.Token(Token = "0x6000ADC")]
		[Cpp2IlInjected.Address(Slot = "7")]
		void DEKHZJXVRAL<a>(Func<a, string> a, [In] a msgArgs);
	}
	[Cpp2IlInjected.Token(Token = "0x2000194")]
	public abstract class GAVEUDGKXDJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000ADD")]
		[Cpp2IlInjected.Address(RVA = "0xD16C40", Offset = "0xD15640", VA = "0x180D16C40")]
		protected GAVEUDGKXDJ()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000195")]
	public enum PurchaseFailureError
	{
		[Cpp2IlInjected.Token(Token = "0x400079A")]
		Unknown,
		[Cpp2IlInjected.Token(Token = "0x400079B")]
		InAppPurchaseNotAllowedOnAccount,
		[Cpp2IlInjected.Token(Token = "0x400079C")]
		PlatformPurchaseException,
		[Cpp2IlInjected.Token(Token = "0x400079D")]
		PlatformPurchaseFailure,
		[Cpp2IlInjected.Token(Token = "0x400079E")]
		CommerceInitiatePurchaseFailure,
		[Cpp2IlInjected.Token(Token = "0x400079F")]
		FailedToGetPlatformAccessToken,
		[Cpp2IlInjected.Token(Token = "0x40007A0")]
		PlatformAuthorizePurchaseFailure,
		[Cpp2IlInjected.Token(Token = "0x40007A1")]
		CommerceCompletePurchaseFailure,
		[Cpp2IlInjected.Token(Token = "0x40007A2")]
		PlatformSubscriptionNotSupported,
		[Cpp2IlInjected.Token(Token = "0x40007A3")]
		PlatformPurchasesNotSupported,
		[Cpp2IlInjected.Token(Token = "0x40007A4")]
		OculusDesktopPlayersMustBeInVR,
		[Cpp2IlInjected.Token(Token = "0x40007A5")]
		FailedToRetrieveParentalControls,
		[Cpp2IlInjected.Token(Token = "0x40007A6")]
		UserCanceled,
		[Cpp2IlInjected.Token(Token = "0x40007A7")]
		DebugError
	}
	[Cpp2IlInjected.Token(Token = "0x2000196")]
	public enum PurchaseFailureType : byte
	{
		[Cpp2IlInjected.Token(Token = "0x40007A9")]
		Unknown,
		[Cpp2IlInjected.Token(Token = "0x40007AA")]
		AccountError,
		[Cpp2IlInjected.Token(Token = "0x40007AB")]
		PlatformError,
		[Cpp2IlInjected.Token(Token = "0x40007AC")]
		CommerceError,
		[Cpp2IlInjected.Token(Token = "0x40007AD")]
		UserAction
	}
	[Cpp2IlInjected.Token(Token = "0x2000197")]
	[Utf8JsonSerializable]
	public class SKU : OIRXPKYYAWC
	{
		[Cpp2IlInjected.Token(Token = "0x17000495")]
		public int SkuId
		{
			[Cpp2IlInjected.Token(Token = "0x6000ADE")]
			[Cpp2IlInjected.Address(RVA = "0xD0F110", Offset = "0xD0DB10", VA = "0x180D0F110")]
			[CompilerGenerated]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x6000ADF")]
			[Cpp2IlInjected.Address(RVA = "0xD12F30", Offset = "0xD11930", VA = "0x180D12F30")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000496")]
		public string Name
		{
			[Cpp2IlInjected.Token(Token = "0x6000AE0")]
			[Cpp2IlInjected.Address(RVA = "0xD11B30", Offset = "0xD10530", VA = "0x180D11B30")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000AE1")]
			[Cpp2IlInjected.Address(RVA = "0xD12270", Offset = "0xD10C70", VA = "0x180D12270")]
			[CompilerGenerated]
			internal set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000497")]
		public string Description
		{
			[Cpp2IlInjected.Token(Token = "0x6000AE2")]
			[Cpp2IlInjected.Address(RVA = "0xD12BC0", Offset = "0xD115C0", VA = "0x180D12BC0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000AE3")]
			[Cpp2IlInjected.Address(RVA = "0xD11520", Offset = "0xD0FF20", VA = "0x180D11520")]
			[CompilerGenerated]
			internal set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000498")]
		public string ImageName
		{
			[Cpp2IlInjected.Token(Token = "0x6000AE4")]
			[Cpp2IlInjected.Address(RVA = "0xD11B00", Offset = "0xD10500", VA = "0x180D11B00")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000AE5")]
			[Cpp2IlInjected.Address(RVA = "0xD11530", Offset = "0xD0FF30", VA = "0x180D11530")]
			[CompilerGenerated]
			internal set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000499")]
		public int Price
		{
			[Cpp2IlInjected.Token(Token = "0x6000AE6")]
			[Cpp2IlInjected.Address(RVA = "0xD1B6C0", Offset = "0xD1A0C0", VA = "0x180D1B6C0")]
			[CompilerGenerated]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x6000AE7")]
			[Cpp2IlInjected.Address(RVA = "0xD1B020", Offset = "0xD19A20", VA = "0x180D1B020")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700049A")]
		public string OculusSkuId
		{
			[Cpp2IlInjected.Token(Token = "0x6000AE8")]
			[Cpp2IlInjected.Address(RVA = "0xD12280", Offset = "0xD10C80", VA = "0x180D12280")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000AE9")]
			[Cpp2IlInjected.Address(RVA = "0xD11B50", Offset = "0xD10550", VA = "0x180D11B50")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700049B")]
		public string AppleProductId
		{
			[Cpp2IlInjected.Token(Token = "0x6000AEA")]
			[Cpp2IlInjected.Address(RVA = "0xD11A30", Offset = "0xD10430", VA = "0x180D11A30")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000AEB")]
			[Cpp2IlInjected.Address(RVA = "0xD12260", Offset = "0xD10C60", VA = "0x180D12260")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700049C")]
		[DataMember(Name = "PsnProductLabel")]
		public string PSNProductLabel
		{
			[Cpp2IlInjected.Token(Token = "0x6000AEC")]
			[Cpp2IlInjected.Address(RVA = "0xD122E0", Offset = "0xD10CE0", VA = "0x180D122E0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000AED")]
			[Cpp2IlInjected.Address(RVA = "0xD12290", Offset = "0xD10C90", VA = "0x180D12290")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700049D")]
		public string XboxProductId
		{
			[Cpp2IlInjected.Token(Token = "0x6000AEE")]
			[Cpp2IlInjected.Address(RVA = "0xD11B20", Offset = "0xD10520", VA = "0x180D11B20")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000AEF")]
			[Cpp2IlInjected.Address(RVA = "0xD11900", Offset = "0xD10300", VA = "0x180D11900")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700049E")]
		public string XboxStoreId
		{
			[Cpp2IlInjected.Token(Token = "0x6000AF0")]
			[Cpp2IlInjected.Address(RVA = "0xD11940", Offset = "0xD10340", VA = "0x180D11940")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000AF1")]
			[Cpp2IlInjected.Address(RVA = "0xD122A0", Offset = "0xD10CA0", VA = "0x180D122A0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700049F")]
		public string GooglePlaySkuId
		{
			[Cpp2IlInjected.Token(Token = "0x6000AF2")]
			[Cpp2IlInjected.Address(RVA = "0xD15610", Offset = "0xD14010", VA = "0x180D15610")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000AF3")]
			[Cpp2IlInjected.Address(RVA = "0xD15600", Offset = "0xD14000", VA = "0x180D15600")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170004A0")]
		public string PicoSkuId
		{
			[Cpp2IlInjected.Token(Token = "0x6000AF4")]
			[Cpp2IlInjected.Address(RVA = "0xD11B40", Offset = "0xD10540", VA = "0x180D11B40")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000AF5")]
			[Cpp2IlInjected.Address(RVA = "0xD11910", Offset = "0xD10310", VA = "0x180D11910")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170004A1")]
		public string NintendoSkuId
		{
			[Cpp2IlInjected.Token(Token = "0x6000AF6")]
			[Cpp2IlInjected.Address(RVA = "0xD11B60", Offset = "0xD10560", VA = "0x180D11B60")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000AF7")]
			[Cpp2IlInjected.Address(RVA = "0xD11AE0", Offset = "0xD104E0", VA = "0x180D11AE0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170004A2")]
		public bool IsSingleUse
		{
			[Cpp2IlInjected.Token(Token = "0x6000AF8")]
			[Cpp2IlInjected.Address(RVA = "0xFCDF20", Offset = "0xFCC920", VA = "0x180FCDF20")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000AF9")]
			[Cpp2IlInjected.Address(RVA = "0xFCD190", Offset = "0xFCBB90", VA = "0x180FCD190")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170004A3")]
		public bool ShouldAppearInTokenStore
		{
			[Cpp2IlInjected.Token(Token = "0x6000AFA")]
			[Cpp2IlInjected.Address(RVA = "0x1768080", Offset = "0x1766A80", VA = "0x181768080")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000AFB")]
			[Cpp2IlInjected.Address(RVA = "0x1767F70", Offset = "0x1766970", VA = "0x181767F70")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170004A4")]
		public SKUData Data
		{
			[Cpp2IlInjected.Token(Token = "0x6000AFC")]
			[Cpp2IlInjected.Address(RVA = "0xD1E850", Offset = "0xD1D250", VA = "0x180D1E850")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000AFD")]
			[Cpp2IlInjected.Address(RVA = "0xD1E840", Offset = "0xD1D240", VA = "0x180D1E840")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170004A5")]
		[IgnoreDataMember]
		public string DisplayPrice
		{
			[Cpp2IlInjected.Token(Token = "0x6000AFE")]
			[Cpp2IlInjected.Address(RVA = "0xD1E900", Offset = "0xD1D300", VA = "0x180D1E900")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000AFF")]
			[Cpp2IlInjected.Address(RVA = "0xD1E880", Offset = "0xD1D280", VA = "0x180D1E880")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170004A6")]
		[IgnoreDataMember]
		public string LongDescription
		{
			[Cpp2IlInjected.Token(Token = "0x6000B00")]
			[Cpp2IlInjected.Address(RVA = "0xD3FEF0", Offset = "0xD3E8F0", VA = "0x180D3FEF0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000B01")]
			[Cpp2IlInjected.Address(RVA = "0xFCC250", Offset = "0xFCAC50", VA = "0x180FCC250")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170004A7")]
		[IgnoreDataMember]
		public string ConfirmationMessage
		{
			[Cpp2IlInjected.Token(Token = "0x6000B02")]
			[Cpp2IlInjected.Address(RVA = "0xD1E7D0", Offset = "0xD1D1D0", VA = "0x180D1E7D0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000B03")]
			[Cpp2IlInjected.Address(RVA = "0xD1E860", Offset = "0xD1D260", VA = "0x180D1E860")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170004A8")]
		[IgnoreDataMember]
		public GAVEUDGKXDJ PlatformSku
		{
			[Cpp2IlInjected.Token(Token = "0x6000B04")]
			[Cpp2IlInjected.Address(RVA = "0xDE3320", Offset = "0xDE1D20", VA = "0x180DE3320")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000B05")]
			[Cpp2IlInjected.Address(RVA = "0xEA1370", Offset = "0xE9FD70", VA = "0x180EA1370")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170004A9")]
		[IgnoreDataMember]
		public bool IsSubscription
		{
			[Cpp2IlInjected.Token(Token = "0x6000B06")]
			[Cpp2IlInjected.Address(RVA = "0x8DD1AE0", Offset = "0x8DD04E0", VA = "0x188DD1AE0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170004AA")]
		[IgnoreDataMember]
		public string ThumbnailImageName
		{
			[Cpp2IlInjected.Token(Token = "0x6000B07")]
			[Cpp2IlInjected.Address(RVA = "0xD13E60", Offset = "0xD12860", VA = "0x180D13E60")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000B08")]
			[Cpp2IlInjected.Address(RVA = "0xD13E70", Offset = "0xD12870", VA = "0x180D13E70")]
			[CompilerGenerated]
			internal set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000B09")]
		[Cpp2IlInjected.Address(RVA = "0x8DD18F0", Offset = "0x8DD02F0", VA = "0x188DD18F0", Slot = "4")]
		public void HHUGNWFYOZL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000B0A")]
		[Cpp2IlInjected.Address(RVA = "0x8DD1A40", Offset = "0x8DD0440", VA = "0x188DD1A40")]
		public static SKU WULOYFPXQLK(int a, string b, string c)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000B0B")]
		[Cpp2IlInjected.Address(RVA = "0x8DD19E0", Offset = "0x8DD03E0", VA = "0x188DD19E0", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000B0C")]
		[Cpp2IlInjected.Address(RVA = "0xD16C40", Offset = "0xD15640", VA = "0x180D16C40")]
		public SKU()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000198")]
	[Utf8JsonSerializable]
	public class SKUData
	{
		[Cpp2IlInjected.Token(Token = "0x170004AB")]
		public List<int> GiftDropIds
		{
			[Cpp2IlInjected.Token(Token = "0x6000B0D")]
			[Cpp2IlInjected.Address(RVA = "0xD117B0", Offset = "0xD101B0", VA = "0x180D117B0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000B0E")]
			[Cpp2IlInjected.Address(RVA = "0xD117C0", Offset = "0xD101C0", VA = "0x180D117C0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170004AC")]
		public string Message
		{
			[Cpp2IlInjected.Token(Token = "0x6000B0F")]
			[Cpp2IlInjected.Address(RVA = "0xD11B30", Offset = "0xD10530", VA = "0x180D11B30")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000B10")]
			[Cpp2IlInjected.Address(RVA = "0xD12270", Offset = "0xD10C70", VA = "0x180D12270")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170004AD")]
		public SubscriptionPurchase SubscriptionPurchase
		{
			[Cpp2IlInjected.Token(Token = "0x6000B11")]
			[Cpp2IlInjected.Address(RVA = "0xD12BC0", Offset = "0xD115C0", VA = "0x180D12BC0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000B12")]
			[Cpp2IlInjected.Address(RVA = "0xD11520", Offset = "0xD0FF20", VA = "0x180D11520")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000B13")]
		[Cpp2IlInjected.Address(RVA = "0xD16C40", Offset = "0xD15640", VA = "0x180D16C40")]
		public SKUData()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000199")]
	public readonly struct SkuPurchaseResult
	{
		[Cpp2IlInjected.Token(Token = "0x200019A")]
		public enum States : byte
		{
			[Cpp2IlInjected.Token(Token = "0x40007CA")]
			Error,
			[Cpp2IlInjected.Token(Token = "0x40007CB")]
			CancelledByUser,
			[Cpp2IlInjected.Token(Token = "0x40007CC")]
			Success
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40007C6")]
		public readonly States State;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1")]
		[Cpp2IlInjected.Token(Token = "0x40007C7")]
		public readonly PurchaseFailureType PurchaseFailureType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x40007C8")]
		public readonly PurchaseFailureError PurchaseFailureError;

		[Cpp2IlInjected.Token(Token = "0x6000B14")]
		[Cpp2IlInjected.Address(RVA = "0x8DD1B60", Offset = "0x8DD0560", VA = "0x188DD1B60")]
		private SkuPurchaseResult(States state, PurchaseFailureType purchaseFailureType = PurchaseFailureType.Unknown, PurchaseFailureError purchaseFailureError = PurchaseFailureError.Unknown)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000B15")]
		[Cpp2IlInjected.Address(RVA = "0x8DD1B40", Offset = "0x8DD0540", VA = "0x188DD1B40")]
		public static SkuPurchaseResult Success()
		{
			return default(SkuPurchaseResult);
		}

		[Cpp2IlInjected.Token(Token = "0x6000B16")]
		[Cpp2IlInjected.Address(RVA = "0x8DD1B00", Offset = "0x8DD0500", VA = "0x188DD1B00")]
		public static SkuPurchaseResult Cancelled()
		{
			return default(SkuPurchaseResult);
		}

		[Cpp2IlInjected.Token(Token = "0x6000B17")]
		[Cpp2IlInjected.Address(RVA = "0x8DD1B20", Offset = "0x8DD0520", VA = "0x188DD1B20")]
		public static SkuPurchaseResult Error(PurchaseFailureType purchaseFailureType, PurchaseFailureError purchaseFailureError)
		{
			return default(SkuPurchaseResult);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200019B")]
	public enum SubscriptionLevel
	{
		[Cpp2IlInjected.Token(Token = "0x40007CE")]
		Gold,
		[Cpp2IlInjected.Token(Token = "0x40007CF")]
		Platinum
	}
	[Cpp2IlInjected.Token(Token = "0x200019C")]
	public enum SubscriptionPeriod
	{
		[Cpp2IlInjected.Token(Token = "0x40007D1")]
		Month,
		[Cpp2IlInjected.Token(Token = "0x40007D2")]
		Year,
		[Cpp2IlInjected.Token(Token = "0x40007D3")]
		ThreeMonth,
		[Cpp2IlInjected.Token(Token = "0x40007D4")]
		SixMonth
	}
	[Cpp2IlInjected.Token(Token = "0x200019D")]
	[Utf8JsonSerializable]
	public class SubscriptionPurchase
	{
		[Cpp2IlInjected.Token(Token = "0x170004AE")]
		public SubscriptionLevel Level
		{
			[Cpp2IlInjected.Token(Token = "0x6000B18")]
			[Cpp2IlInjected.Address(RVA = "0xD0F110", Offset = "0xD0DB10", VA = "0x180D0F110")]
			[CompilerGenerated]
			get
			{
				return default(SubscriptionLevel);
			}
			[Cpp2IlInjected.Token(Token = "0x6000B19")]
			[Cpp2IlInjected.Address(RVA = "0xD12F30", Offset = "0xD11930", VA = "0x180D12F30")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170004AF")]
		public SubscriptionPeriod Period
		{
			[Cpp2IlInjected.Token(Token = "0x6000B1A")]
			[Cpp2IlInjected.Address(RVA = "0xE073A0", Offset = "0xE05DA0", VA = "0x180E073A0")]
			[CompilerGenerated]
			get
			{
				return default(SubscriptionPeriod);
			}
			[Cpp2IlInjected.Token(Token = "0x6000B1B")]
			[Cpp2IlInjected.Address(RVA = "0xE073B0", Offset = "0xE05DB0", VA = "0x180E073B0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170004B0")]
		public bool IsAutoRenewing
		{
			[Cpp2IlInjected.Token(Token = "0x6000B1C")]
			[Cpp2IlInjected.Address(RVA = "0xEB2260", Offset = "0xEB0C60", VA = "0x180EB2260")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000B1D")]
			[Cpp2IlInjected.Address(RVA = "0xD19FA0", Offset = "0xD189A0", VA = "0x180D19FA0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000B1E")]
		[Cpp2IlInjected.Address(RVA = "0xD16C40", Offset = "0xD15640", VA = "0x180D16C40")]
		public SubscriptionPurchase()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200019E")]
	public enum TransactionState
	{
		[Cpp2IlInjected.Token(Token = "0x40007D9")]
		Error = -2,
		[Cpp2IlInjected.Token(Token = "0x40007DA")]
		Cancelled,
		[Cpp2IlInjected.Token(Token = "0x40007DB")]
		Uninitialized,
		[Cpp2IlInjected.Token(Token = "0x40007DC")]
		AttemptStarted,
		[Cpp2IlInjected.Token(Token = "0x40007DD")]
		PurchaseComplete
	}
}
namespace RecNet.Econ.BattlePass
{
	[Cpp2IlInjected.Token(Token = "0x200019F")]
	[Utf8JsonSerializable]
	public class BattlePassAccountProgressDTO : IEquatable<BattlePassAccountProgressDTO>
	{
		[Cpp2IlInjected.Token(Token = "0x170004B1")]
		[CompilerGenerated]
		protected virtual Type VZLUXMAJKRJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000B20")]
			[Cpp2IlInjected.Address(RVA = "0x8DCBBE0", Offset = "0x8DCA5E0", VA = "0x188DCBBE0", Slot = "5")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170004B2")]
		public long BattlePassId
		{
			[Cpp2IlInjected.Token(Token = "0x6000B21")]
			[Cpp2IlInjected.Address(RVA = "0xD117B0", Offset = "0xD101B0", VA = "0x180D117B0")]
			[CompilerGenerated]
			get
			{
				return default(long);
			}
			[Cpp2IlInjected.Token(Token = "0x6000B22")]
			[Cpp2IlInjected.Address(RVA = "0xED90B0", Offset = "0xED7AB0", VA = "0x180ED90B0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170004B3")]
		public int AccountId
		{
			[Cpp2IlInjected.Token(Token = "0x6000B23")]
			[Cpp2IlInjected.Address(RVA = "0xD17340", Offset = "0xD15D40", VA = "0x180D17340")]
			[CompilerGenerated]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x6000B24")]
			[Cpp2IlInjected.Address(RVA = "0xD17360", Offset = "0xD15D60", VA = "0x180D17360")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170004B4")]
		public int Xp
		{
			[Cpp2IlInjected.Token(Token = "0x6000B25")]
			[Cpp2IlInjected.Address(RVA = "0x1664600", Offset = "0x1663000", VA = "0x181664600")]
			[CompilerGenerated]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x6000B26")]
			[Cpp2IlInjected.Address(RVA = "0x1664610", Offset = "0x1663010", VA = "0x181664610")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170004B5")]
		public bool IsPurchased
		{
			[Cpp2IlInjected.Token(Token = "0x6000B27")]
			[Cpp2IlInjected.Address(RVA = "0xD11950", Offset = "0xD10350", VA = "0x180D11950")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000B28")]
			[Cpp2IlInjected.Address(RVA = "0xD12250", Offset = "0xD10C50", VA = "0x180D12250")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170004B6")]
		public int DailyParticipationBonusCount
		{
			[Cpp2IlInjected.Token(Token = "0x6000B29")]
			[Cpp2IlInjected.Address(RVA = "0xD38090", Offset = "0xD36A90", VA = "0x180D38090")]
			[CompilerGenerated]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x6000B2A")]
			[Cpp2IlInjected.Address(RVA = "0xF21A50", Offset = "0xF20450", VA = "0x180F21A50")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170004B7")]
		public DateTime DailyParticipationBonusResetTime
		{
			[Cpp2IlInjected.Token(Token = "0x6000B2B")]
			[Cpp2IlInjected.Address(RVA = "0xD11B00", Offset = "0xD10500", VA = "0x180D11B00")]
			[CompilerGenerated]
			get
			{
				return default(DateTime);
			}
			[Cpp2IlInjected.Token(Token = "0x6000B2C")]
			[Cpp2IlInjected.Address(RVA = "0xD11960", Offset = "0xD10360", VA = "0x180D11960")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170004B8")]
		public DateTime? BoostedUntil
		{
			[Cpp2IlInjected.Token(Token = "0x6000B2D")]
			[Cpp2IlInjected.Address(RVA = "0xF92C90", Offset = "0xF91690", VA = "0x180F92C90")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000B2E")]
			[Cpp2IlInjected.Address(RVA = "0xF931D0", Offset = "0xF91BD0", VA = "0x180F931D0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170004B9")]
		public DateTime? CompletionDate
		{
			[Cpp2IlInjected.Token(Token = "0x6000B2F")]
			[Cpp2IlInjected.Address(RVA = "0x10ABB70", Offset = "0x10AA570", VA = "0x1810ABB70")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000B30")]
			[Cpp2IlInjected.Address(RVA = "0x10ABCC0", Offset = "0x10AA6C0", VA = "0x1810ABCC0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000B1F")]
		[Cpp2IlInjected.Address(RVA = "0x8DCC010", Offset = "0x8DCAA10", VA = "0x188DCC010")]
		public BattlePassAccountProgressDTO(long BattlePassId, int AccountId, int Xp, bool IsPurchased, int DailyParticipationBonusCount, DateTime DailyParticipationBonusResetTime, DateTime? BoostedUntil, DateTime? CompletionDate)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000B31")]
		[Cpp2IlInjected.Address(RVA = "0x8DCBC80", Offset = "0x8DCA680", VA = "0x188DCBC80", Slot = "3")]
		[CompilerGenerated]
		public override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000B32")]
		[Cpp2IlInjected.Address(RVA = "0x8DCBD70", Offset = "0x8DCA770", VA = "0x188DCBD70", Slot = "6")]
		[CompilerGenerated]
		protected virtual bool WJJAKQGJTCH(StringBuilder a)
		{
			return default(bool);
		}

		[SpecialName]
		[Cpp2IlInjected.Token(Token = "0x6000B33")]
		[Cpp2IlInjected.Address(RVA = "0x12EAD60", Offset = "0x12E9760", VA = "0x1812EAD60")]
		[CompilerGenerated]
		public static bool CYAUITUETAA(BattlePassAccountProgressDTO? a, BattlePassAccountProgressDTO? b)
		{
			return default(bool);
		}

		[SpecialName]
		[Cpp2IlInjected.Token(Token = "0x6000B34")]
		[Cpp2IlInjected.Address(RVA = "0x12EB0B0", Offset = "0x12E9AB0", VA = "0x1812EB0B0")]
		[CompilerGenerated]
		public static bool ITVTPRNZGNV(BattlePassAccountProgressDTO? a, BattlePassAccountProgressDTO? b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000B35")]
		[Cpp2IlInjected.Address(RVA = "0x8DCB8F0", Offset = "0x8DCA2F0", VA = "0x188DCB8F0", Slot = "2")]
		[CompilerGenerated]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000B36")]
		[Cpp2IlInjected.Address(RVA = "0x8DCB860", Offset = "0x8DCA260", VA = "0x188DCB860", Slot = "0")]
		[CompilerGenerated]
		public override bool Equals(object? obj)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000B37")]
		[Cpp2IlInjected.Address(RVA = "0x8DCB560", Offset = "0x8DC9F60", VA = "0x188DCB560", Slot = "7")]
		[CompilerGenerated]
		public virtual bool Equals(BattlePassAccountProgressDTO? other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000B38")]
		[Cpp2IlInjected.Address(RVA = "0x8DCB4C0", Offset = "0x8DC9EC0", VA = "0x188DCB4C0", Slot = "8")]
		[CompilerGenerated]
		public virtual BattlePassAccountProgressDTO CXDOYZBTDGW()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000B39")]
		[Cpp2IlInjected.Address(RVA = "0x8DCC060", Offset = "0x8DCAA60", VA = "0x188DCC060")]
		[CompilerGenerated]
		protected BattlePassAccountProgressDTO(BattlePassAccountProgressDTO original)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000B3A")]
		[Cpp2IlInjected.Address(RVA = "0x8DCBC30", Offset = "0x8DCA630", VA = "0x188DCBC30")]
		[CompilerGenerated]
		public void OGNPAZKLJRJ([Out] long a, [Out] int b, [Out] int c, [Out] bool d, [Out] int e, [Out] DateTime f, [Out] DateTime? g, [Out] DateTime? h)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20001A0")]
	[Utf8JsonSerializable]
	public class BattlePassBoostConfigDTO : IEquatable<BattlePassBoostConfigDTO>
	{
		[Cpp2IlInjected.Token(Token = "0x170004BA")]
		[CompilerGenerated]
		protected virtual Type VZLUXMAJKRJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000B3C")]
			[Cpp2IlInjected.Address(RVA = "0x8DCC5A0", Offset = "0x8DCAFA0", VA = "0x188DCC5A0", Slot = "5")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170004BB")]
		public int TemporaryBoostDurationInMinutes
		{
			[Cpp2IlInjected.Token(Token = "0x6000B3D")]
			[Cpp2IlInjected.Address(RVA = "0xD0F110", Offset = "0xD0DB10", VA = "0x180D0F110")]
			[CompilerGenerated]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x6000B3E")]
			[Cpp2IlInjected.Address(RVA = "0xD12F30", Offset = "0xD11930", VA = "0x180D12F30")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170004BC")]
		public int TemporaryBoostXpMultiplierPercentage
		{
			[Cpp2IlInjected.Token(Token = "0x6000B3F")]
			[Cpp2IlInjected.Address(RVA = "0xE073A0", Offset = "0xE05DA0", VA = "0x180E073A0")]
			[CompilerGenerated]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x6000B40")]
			[Cpp2IlInjected.Address(RVA = "0xE073B0", Offset = "0xE05DB0", VA = "0x180E073B0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170004BD")]
		public int PermanentBoostXpMultiplierPercentage
		{
			[Cpp2IlInjected.Token(Token = "0x6000B41")]
			[Cpp2IlInjected.Address(RVA = "0xD17340", Offset = "0xD15D40", VA = "0x180D17340")]
			[CompilerGenerated]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x6000B42")]
			[Cpp2IlInjected.Address(RVA = "0xD17360", Offset = "0xD15D60", VA = "0x180D17360")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170004BE")]
		public int SocialBoostXpMultiplierPercentage
		{
			[Cpp2IlInjected.Token(Token = "0x6000B43")]
			[Cpp2IlInjected.Address(RVA = "0x1664600", Offset = "0x1663000", VA = "0x181664600")]
			[CompilerGenerated]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x6000B44")]
			[Cpp2IlInjected.Address(RVA = "0x1664610", Offset = "0x1663010", VA = "0x181664610")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170004BF")]
		public int MaxBoostXpMultiplierPercentage
		{
			[Cpp2IlInjected.Token(Token = "0x6000B45")]
			[Cpp2IlInjected.Address(RVA = "0xD215F0", Offset = "0xD1FFF0", VA = "0x180D215F0")]
			[CompilerGenerated]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x6000B46")]
			[Cpp2IlInjected.Address(RVA = "0xD682F0", Offset = "0xD66CF0", VA = "0x180D682F0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000B3B")]
		[Cpp2IlInjected.Address(RVA = "0x8DCC890", Offset = "0x8DCB290", VA = "0x188DCC890")]
		public BattlePassBoostConfigDTO(int TemporaryBoostDurationInMinutes, int TemporaryBoostXpMultiplierPercentage, int PermanentBoostXpMultiplierPercentage, int SocialBoostXpMultiplierPercentage, int MaxBoostXpMultiplierPercentage)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000B47")]
		[Cpp2IlInjected.Address(RVA = "0x8DCC620", Offset = "0x8DCB020", VA = "0x188DCC620", Slot = "3")]
		[CompilerGenerated]
		public override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000B48")]
		[Cpp2IlInjected.Address(RVA = "0x8DCC710", Offset = "0x8DCB110", VA = "0x188DCC710", Slot = "6")]
		[CompilerGenerated]
		protected virtual bool WJJAKQGJTCH(StringBuilder a)
		{
			return default(bool);
		}

		[SpecialName]
		[Cpp2IlInjected.Token(Token = "0x6000B49")]
		[Cpp2IlInjected.Address(RVA = "0x12EAD60", Offset = "0x12E9760", VA = "0x1812EAD60")]
		[CompilerGenerated]
		public static bool CYAUITUETAA(BattlePassBoostConfigDTO? a, BattlePassBoostConfigDTO? b)
		{
			return default(bool);
		}

		[SpecialName]
		[Cpp2IlInjected.Token(Token = "0x6000B4A")]
		[Cpp2IlInjected.Address(RVA = "0x12EB0B0", Offset = "0x12E9AB0", VA = "0x1812EB0B0")]
		[CompilerGenerated]
		public static bool ITVTPRNZGNV(BattlePassBoostConfigDTO? a, BattlePassBoostConfigDTO? b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000B4B")]
		[Cpp2IlInjected.Address(RVA = "0x8DCC3D0", Offset = "0x8DCADD0", VA = "0x188DCC3D0", Slot = "2")]
		[CompilerGenerated]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000B4C")]
		[Cpp2IlInjected.Address(RVA = "0x8DCC150", Offset = "0x8DCAB50", VA = "0x188DCC150", Slot = "0")]
		[CompilerGenerated]
		public override bool Equals(object? obj)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000B4D")]
		[Cpp2IlInjected.Address(RVA = "0x8DCC1E0", Offset = "0x8DCABE0", VA = "0x188DCC1E0", Slot = "7")]
		[CompilerGenerated]
		public virtual bool Equals(BattlePassBoostConfigDTO? other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000B4E")]
		[Cpp2IlInjected.Address(RVA = "0x8DCC0D0", Offset = "0x8DCAAD0", VA = "0x188DCC0D0", Slot = "8")]
		[CompilerGenerated]
		public virtual BattlePassBoostConfigDTO CXDOYZBTDGW()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000B4F")]
		[Cpp2IlInjected.Address(RVA = "0x8DCC8B0", Offset = "0x8DCB2B0", VA = "0x188DCC8B0")]
		[CompilerGenerated]
		protected BattlePassBoostConfigDTO(BattlePassBoostConfigDTO original)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000B50")]
		[Cpp2IlInjected.Address(RVA = "0x8DCC5F0", Offset = "0x8DCAFF0", VA = "0x188DCC5F0")]
		[CompilerGenerated]
		public void OGNPAZKLJRJ([Out] int a, [Out] int b, [Out] int c, [Out] int d, [Out] int e)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20001A1")]
	[Utf8JsonSerializable]
	public class BattlePassDTO : IEquatable<BattlePassDTO>
	{
		[Cpp2IlInjected.Token(Token = "0x170004C0")]
		[CompilerGenerated]
		protected virtual Type VZLUXMAJKRJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000B52")]
			[Cpp2IlInjected.Address(RVA = "0x8DCD330", Offset = "0x8DCBD30", VA = "0x188DCD330", Slot = "5")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170004C1")]
		public long BattlePassId
		{
			[Cpp2IlInjected.Token(Token = "0x6000B53")]
			[Cpp2IlInjected.Address(RVA = "0xD117B0", Offset = "0xD101B0", VA = "0x180D117B0")]
			[CompilerGenerated]
			get
			{
				return default(long);
			}
			[Cpp2IlInjected.Token(Token = "0x6000B54")]
			[Cpp2IlInjected.Address(RVA = "0xED90B0", Offset = "0xED7AB0", VA = "0x180ED90B0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170004C2")]
		public string Name
		{
			[Cpp2IlInjected.Token(Token = "0x6000B55")]
			[Cpp2IlInjected.Address(RVA = "0xD11B30", Offset = "0xD10530", VA = "0x180D11B30")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000B56")]
			[Cpp2IlInjected.Address(RVA = "0xD12270", Offset = "0xD10C70", VA = "0x180D12270")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170004C3")]
		public IReadOnlyList<long> ValidRoomIds
		{
			[Cpp2IlInjected.Token(Token = "0x6000B57")]
			[Cpp2IlInjected.Address(RVA = "0xD12BC0", Offset = "0xD115C0", VA = "0x180D12BC0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000B58")]
			[Cpp2IlInjected.Address(RVA = "0xD11520", Offset = "0xD0FF20", VA = "0x180D11520")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170004C4")]
		public DateTime StartTime
		{
			[Cpp2IlInjected.Token(Token = "0x6000B59")]
			[Cpp2IlInjected.Address(RVA = "0xD11B00", Offset = "0xD10500", VA = "0x180D11B00")]
			[CompilerGenerated]
			get
			{
				return default(DateTime);
			}
			[Cpp2IlInjected.Token(Token = "0x6000B5A")]
			[Cpp2IlInjected.Address(RVA = "0xD11960", Offset = "0xD10360", VA = "0x180D11960")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170004C5")]
		public DateTime EndTime
		{
			[Cpp2IlInjected.Token(Token = "0x6000B5B")]
			[Cpp2IlInjected.Address(RVA = "0xD11A20", Offset = "0xD10420", VA = "0x180D11A20")]
			[CompilerGenerated]
			get
			{
				return default(DateTime);
			}
			[Cpp2IlInjected.Token(Token = "0x6000B5C")]
			[Cpp2IlInjected.Address(RVA = "0xD118E0", Offset = "0xD102E0", VA = "0x180D118E0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170004C6")]
		public IReadOnlyList<BattlePassLevelDTO> Levels
		{
			[Cpp2IlInjected.Token(Token = "0x6000B5D")]
			[Cpp2IlInjected.Address(RVA = "0xD12280", Offset = "0xD10C80", VA = "0x180D12280")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000B5E")]
			[Cpp2IlInjected.Address(RVA = "0xD11B50", Offset = "0xD10550", VA = "0x180D11B50")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170004C7")]
		public IReadOnlyDictionary<BattlePassEvent, int> EventXP
		{
			[Cpp2IlInjected.Token(Token = "0x6000B5F")]
			[Cpp2IlInjected.Address(RVA = "0xD11A30", Offset = "0xD10430", VA = "0x180D11A30")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000B60")]
			[Cpp2IlInjected.Address(RVA = "0xD12260", Offset = "0xD10C60", VA = "0x180D12260")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170004C8")]
		public BattlePassBoostConfigDTO BoostConfig
		{
			[Cpp2IlInjected.Token(Token = "0x6000B61")]
			[Cpp2IlInjected.Address(RVA = "0xD122E0", Offset = "0xD10CE0", VA = "0x180D122E0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000B62")]
			[Cpp2IlInjected.Address(RVA = "0xD12290", Offset = "0xD10C90", VA = "0x180D12290")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170004C9")]
		public int DailyParticipationBonusLimit
		{
			[Cpp2IlInjected.Token(Token = "0x6000B63")]
			[Cpp2IlInjected.Address(RVA = "0xF01E60", Offset = "0xF00860", VA = "0x180F01E60")]
			[CompilerGenerated]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x6000B64")]
			[Cpp2IlInjected.Address(RVA = "0x1ADB800", Offset = "0x1ADA200", VA = "0x181ADB800")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170004CA")]
		public int MinimumParticipationTimeInSeconds
		{
			[Cpp2IlInjected.Token(Token = "0x6000B65")]
			[Cpp2IlInjected.Address(RVA = "0x137DA00", Offset = "0x137C400", VA = "0x18137DA00")]
			[CompilerGenerated]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x6000B66")]
			[Cpp2IlInjected.Address(RVA = "0x21D5B90", Offset = "0x21D4590", VA = "0x1821D5B90")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170004CB")]
		public IReadOnlyList<BattlePassSkuDTO> PurchasableSkus
		{
			[Cpp2IlInjected.Token(Token = "0x6000B67")]
			[Cpp2IlInjected.Address(RVA = "0xD11940", Offset = "0xD10340", VA = "0x180D11940")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000B68")]
			[Cpp2IlInjected.Address(RVA = "0xD122A0", Offset = "0xD10CA0", VA = "0x180D122A0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170004CC")]
		public int PermanentBoostTokenPrice
		{
			[Cpp2IlInjected.Token(Token = "0x6000B69")]
			[Cpp2IlInjected.Address(RVA = "0x103DE40", Offset = "0x103C840", VA = "0x18103DE40")]
			[CompilerGenerated]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x6000B6A")]
			[Cpp2IlInjected.Address(RVA = "0x1483D20", Offset = "0x1482720", VA = "0x181483D20")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170004CD")]
		public BattlePassLimitedTimeRewardDTO? LimitedTimeReward
		{
			[Cpp2IlInjected.Token(Token = "0x6000B6B")]
			[Cpp2IlInjected.Address(RVA = "0xD11B40", Offset = "0xD10540", VA = "0x180D11B40")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000B6C")]
			[Cpp2IlInjected.Address(RVA = "0xD11910", Offset = "0xD10310", VA = "0x180D11910")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000B51")]
		[Cpp2IlInjected.Address(RVA = "0x8DCD960", Offset = "0x8DCC360", VA = "0x188DCD960")]
		public BattlePassDTO(long BattlePassId, string Name, IReadOnlyList<long> ValidRoomIds, DateTime StartTime, DateTime EndTime, IReadOnlyList<BattlePassLevelDTO> Levels, IReadOnlyDictionary<BattlePassEvent, int> EventXP, BattlePassBoostConfigDTO BoostConfig, int DailyParticipationBonusLimit, int MinimumParticipationTimeInSeconds, IReadOnlyList<BattlePassSkuDTO> PurchasableSkus, int PermanentBoostTokenPrice, BattlePassLimitedTimeRewardDTO? LimitedTimeReward)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000B6D")]
		[Cpp2IlInjected.Address(RVA = "0x8DCD460", Offset = "0x8DCBE60", VA = "0x188DCD460", Slot = "3")]
		[CompilerGenerated]
		public override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000B6E")]
		[Cpp2IlInjected.Address(RVA = "0x8DCD550", Offset = "0x8DCBF50", VA = "0x188DCD550", Slot = "6")]
		[CompilerGenerated]
		protected virtual bool WJJAKQGJTCH(StringBuilder a)
		{
			return default(bool);
		}

		[SpecialName]
		[Cpp2IlInjected.Token(Token = "0x6000B6F")]
		[Cpp2IlInjected.Address(RVA = "0x12EAD60", Offset = "0x12E9760", VA = "0x1812EAD60")]
		[CompilerGenerated]
		public static bool CYAUITUETAA(BattlePassDTO? a, BattlePassDTO? b)
		{
			return default(bool);
		}

		[SpecialName]
		[Cpp2IlInjected.Token(Token = "0x6000B70")]
		[Cpp2IlInjected.Address(RVA = "0x12EB0B0", Offset = "0x12E9AB0", VA = "0x1812EB0B0")]
		[CompilerGenerated]
		public static bool ITVTPRNZGNV(BattlePassDTO? a, BattlePassDTO? b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000B71")]
		[Cpp2IlInjected.Address(RVA = "0x8DCCED0", Offset = "0x8DCB8D0", VA = "0x188DCCED0", Slot = "2")]
		[CompilerGenerated]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000B72")]
		[Cpp2IlInjected.Address(RVA = "0x8DCCA00", Offset = "0x8DCB400", VA = "0x188DCCA00", Slot = "0")]
		[CompilerGenerated]
		public override bool Equals(object? obj)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000B73")]
		[Cpp2IlInjected.Address(RVA = "0x8DCCA90", Offset = "0x8DCB490", VA = "0x188DCCA90", Slot = "7")]
		[CompilerGenerated]
		public virtual bool Equals(BattlePassDTO? other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000B74")]
		[Cpp2IlInjected.Address(RVA = "0x8DCC900", Offset = "0x8DCB300", VA = "0x188DCC900", Slot = "8")]
		[CompilerGenerated]
		public virtual BattlePassDTO CXDOYZBTDGW()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000B75")]
		[Cpp2IlInjected.Address(RVA = "0x8DCD880", Offset = "0x8DCC280", VA = "0x188DCD880")]
		[CompilerGenerated]
		protected BattlePassDTO(BattlePassDTO original)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000B76")]
		[Cpp2IlInjected.Address(RVA = "0x8DCD380", Offset = "0x8DCBD80", VA = "0x188DCD380")]
		[CompilerGenerated]
		public void OGNPAZKLJRJ([Out] long a, [Out] string b, [Out] IReadOnlyList<long> c, [Out] DateTime d, [Out] DateTime e, [Out] IReadOnlyList<BattlePassLevelDTO> f, [Out] IReadOnlyDictionary<BattlePassEvent, int> g, [Out] BattlePassBoostConfigDTO h, [Out] int i, [Out] int j, [Out] IReadOnlyList<BattlePassSkuDTO> k, [Out] int l, [Out] BattlePassLimitedTimeRewardDTO? LimitedTimeReward)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20001A2")]
	public enum BattlePassEvent
	{
		[Cpp2IlInjected.Token(Token = "0x40007F9")]
		Unknown,
		[Cpp2IlInjected.Token(Token = "0x40007FA")]
		Paintball_KO,
		[Cpp2IlInjected.Token(Token = "0x40007FB")]
		Paintball_FlagCapture,
		[Cpp2IlInjected.Token(Token = "0x40007FC")]
		Paintball_FinishGame,
		[Cpp2IlInjected.Token(Token = "0x40007FD")]
		Paintball_WinGame
	}
	[Cpp2IlInjected.Token(Token = "0x20001A3")]
	[Utf8JsonSerializable]
	public class BattlePassLevelDTO : IEquatable<BattlePassLevelDTO>
	{
		[Cpp2IlInjected.Token(Token = "0x170004CE")]
		[CompilerGenerated]
		protected virtual Type VZLUXMAJKRJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000B78")]
			[Cpp2IlInjected.Address(RVA = "0x8DCDDB0", Offset = "0x8DCC7B0", VA = "0x188DCDDB0", Slot = "5")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170004CF")]
		public int XpRequired
		{
			[Cpp2IlInjected.Token(Token = "0x6000B79")]
			[Cpp2IlInjected.Address(RVA = "0xD0F110", Offset = "0xD0DB10", VA = "0x180D0F110")]
			[CompilerGenerated]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x6000B7A")]
			[Cpp2IlInjected.Address(RVA = "0xD12F30", Offset = "0xD11930", VA = "0x180D12F30")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170004D0")]
		public IReadOnlyList<int> RewardGiftDropIds
		{
			[Cpp2IlInjected.Token(Token = "0x6000B7B")]
			[Cpp2IlInjected.Address(RVA = "0xD11B30", Offset = "0xD10530", VA = "0x180D11B30")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000B7C")]
			[Cpp2IlInjected.Address(RVA = "0xD12270", Offset = "0xD10C70", VA = "0x180D12270")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000B77")]
		[Cpp2IlInjected.Address(RVA = "0x1451CA0", Offset = "0x14506A0", VA = "0x181451CA0")]
		public BattlePassLevelDTO(int XpRequired, IReadOnlyList<int> RewardGiftDropIds)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000B7D")]
		[Cpp2IlInjected.Address(RVA = "0x8DCDE20", Offset = "0x8DCC820", VA = "0x188DCDE20", Slot = "3")]
		[CompilerGenerated]
		public override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000B7E")]
		[Cpp2IlInjected.Address(RVA = "0x8DCDF10", Offset = "0x8DCC910", VA = "0x188DCDF10", Slot = "6")]
		[CompilerGenerated]
		protected virtual bool WJJAKQGJTCH(StringBuilder a)
		{
			return default(bool);
		}

		[SpecialName]
		[Cpp2IlInjected.Token(Token = "0x6000B7F")]
		[Cpp2IlInjected.Address(RVA = "0x12EAD60", Offset = "0x12E9760", VA = "0x1812EAD60")]
		[CompilerGenerated]
		public static bool CYAUITUETAA(BattlePassLevelDTO? a, BattlePassLevelDTO? b)
		{
			return default(bool);
		}

		[SpecialName]
		[Cpp2IlInjected.Token(Token = "0x6000B80")]
		[Cpp2IlInjected.Address(RVA = "0x12EB0B0", Offset = "0x12E9AB0", VA = "0x1812EB0B0")]
		[CompilerGenerated]
		public static bool ITVTPRNZGNV(BattlePassLevelDTO? a, BattlePassLevelDTO? b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000B81")]
		[Cpp2IlInjected.Address(RVA = "0x8DCDCA0", Offset = "0x8DCC6A0", VA = "0x188DCDCA0", Slot = "2")]
		[CompilerGenerated]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000B82")]
		[Cpp2IlInjected.Address(RVA = "0x8DCDC10", Offset = "0x8DCC610", VA = "0x188DCDC10", Slot = "0")]
		[CompilerGenerated]
		public override bool Equals(object? obj)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000B83")]
		[Cpp2IlInjected.Address(RVA = "0x8DCDAC0", Offset = "0x8DCC4C0", VA = "0x188DCDAC0", Slot = "7")]
		[CompilerGenerated]
		public virtual bool Equals(BattlePassLevelDTO? other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000B84")]
		[Cpp2IlInjected.Address(RVA = "0x8DCDA40", Offset = "0x8DCC440", VA = "0x188DCDA40", Slot = "8")]
		[CompilerGenerated]
		public virtual BattlePassLevelDTO CXDOYZBTDGW()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000B85")]
		[Cpp2IlInjected.Address(RVA = "0x8DCDFC0", Offset = "0x8DCC9C0", VA = "0x188DCDFC0")]
		[CompilerGenerated]
		protected BattlePassLevelDTO(BattlePassLevelDTO original)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000B86")]
		[Cpp2IlInjected.Address(RVA = "0x8DCDE00", Offset = "0x8DCC800", VA = "0x188DCDE00")]
		[CompilerGenerated]
		public void OGNPAZKLJRJ([Out] int a, [Out] IReadOnlyList<int> b)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20001A4")]
	[Utf8JsonSerializable]
	public class BattlePassLimitedTimeRewardDTO : IEquatable<BattlePassLimitedTimeRewardDTO>
	{
		[Cpp2IlInjected.Token(Token = "0x170004D1")]
		[CompilerGenerated]
		protected virtual Type VZLUXMAJKRJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000B88")]
			[Cpp2IlInjected.Address(RVA = "0x8DCE390", Offset = "0x8DCCD90", VA = "0x188DCE390", Slot = "5")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170004D2")]
		public DateTime CompletionDeadline
		{
			[Cpp2IlInjected.Token(Token = "0x6000B89")]
			[Cpp2IlInjected.Address(RVA = "0xD117B0", Offset = "0xD101B0", VA = "0x180D117B0")]
			[CompilerGenerated]
			get
			{
				return default(DateTime);
			}
			[Cpp2IlInjected.Token(Token = "0x6000B8A")]
			[Cpp2IlInjected.Address(RVA = "0xED90B0", Offset = "0xED7AB0", VA = "0x180ED90B0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170004D3")]
		public IReadOnlyList<int> GiftDropIds
		{
			[Cpp2IlInjected.Token(Token = "0x6000B8B")]
			[Cpp2IlInjected.Address(RVA = "0xD11B30", Offset = "0xD10530", VA = "0x180D11B30")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000B8C")]
			[Cpp2IlInjected.Address(RVA = "0xD12270", Offset = "0xD10C70", VA = "0x180D12270")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000B87")]
		[Cpp2IlInjected.Address(RVA = "0x8DCE610", Offset = "0x8DCD010", VA = "0x188DCE610")]
		public BattlePassLimitedTimeRewardDTO(DateTime CompletionDeadline, IReadOnlyList<int> GiftDropIds)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000B8D")]
		[Cpp2IlInjected.Address(RVA = "0x8DCE400", Offset = "0x8DCCE00", VA = "0x188DCE400", Slot = "3")]
		[CompilerGenerated]
		public override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000B8E")]
		[Cpp2IlInjected.Address(RVA = "0x8DCE4F0", Offset = "0x8DCCEF0", VA = "0x188DCE4F0", Slot = "6")]
		[CompilerGenerated]
		protected virtual bool WJJAKQGJTCH(StringBuilder a)
		{
			return default(bool);
		}

		[SpecialName]
		[Cpp2IlInjected.Token(Token = "0x6000B8F")]
		[Cpp2IlInjected.Address(RVA = "0x12EAD60", Offset = "0x12E9760", VA = "0x1812EAD60")]
		[CompilerGenerated]
		public static bool CYAUITUETAA(BattlePassLimitedTimeRewardDTO? a, BattlePassLimitedTimeRewardDTO? b)
		{
			return default(bool);
		}

		[SpecialName]
		[Cpp2IlInjected.Token(Token = "0x6000B90")]
		[Cpp2IlInjected.Address(RVA = "0x12EB0B0", Offset = "0x12E9AB0", VA = "0x1812EB0B0")]
		[CompilerGenerated]
		public static bool ITVTPRNZGNV(BattlePassLimitedTimeRewardDTO? a, BattlePassLimitedTimeRewardDTO? b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000B91")]
		[Cpp2IlInjected.Address(RVA = "0x8DCE270", Offset = "0x8DCCC70", VA = "0x188DCE270", Slot = "2")]
		[CompilerGenerated]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000B92")]
		[Cpp2IlInjected.Address(RVA = "0x8DCE090", Offset = "0x8DCCA90", VA = "0x188DCE090", Slot = "0")]
		[CompilerGenerated]
		public override bool Equals(object? obj)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000B93")]
		[Cpp2IlInjected.Address(RVA = "0x8DCE120", Offset = "0x8DCCB20", VA = "0x188DCE120", Slot = "7")]
		[CompilerGenerated]
		public virtual bool Equals(BattlePassLimitedTimeRewardDTO? other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000B94")]
		[Cpp2IlInjected.Address(RVA = "0x8DCE010", Offset = "0x8DCCA10", VA = "0x188DCE010", Slot = "8")]
		[CompilerGenerated]
		public virtual BattlePassLimitedTimeRewardDTO CXDOYZBTDGW()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000B95")]
		[Cpp2IlInjected.Address(RVA = "0x8DCE5C0", Offset = "0x8DCCFC0", VA = "0x188DCE5C0")]
		[CompilerGenerated]
		protected BattlePassLimitedTimeRewardDTO(BattlePassLimitedTimeRewardDTO original)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000B96")]
		[Cpp2IlInjected.Address(RVA = "0x8DCE3E0", Offset = "0x8DCCDE0", VA = "0x188DCE3E0")]
		[CompilerGenerated]
		public void OGNPAZKLJRJ([Out] DateTime a, [Out] IReadOnlyList<int> b)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20001A5")]
	[Utf8JsonSerializable]
	public class BattlePassSkuDTO : IEquatable<BattlePassSkuDTO>
	{
		[Cpp2IlInjected.Token(Token = "0x170004D4")]
		[CompilerGenerated]
		protected virtual Type VZLUXMAJKRJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000B98")]
			[Cpp2IlInjected.Address(RVA = "0x8DCEAD0", Offset = "0x8DCD4D0", VA = "0x188DCEAD0", Slot = "5")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170004D5")]
		public BattlePassSkuType Type
		{
			[Cpp2IlInjected.Token(Token = "0x6000B99")]
			[Cpp2IlInjected.Address(RVA = "0xD66E30", Offset = "0xD65830", VA = "0x180D66E30")]
			[CompilerGenerated]
			get
			{
				return default(BattlePassSkuType);
			}
			[Cpp2IlInjected.Token(Token = "0x6000B9A")]
			[Cpp2IlInjected.Address(RVA = "0xE376D0", Offset = "0xE360D0", VA = "0x180E376D0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170004D6")]
		public int TokenPrice
		{
			[Cpp2IlInjected.Token(Token = "0x6000B9B")]
			[Cpp2IlInjected.Address(RVA = "0xE073A0", Offset = "0xE05DA0", VA = "0x180E073A0")]
			[CompilerGenerated]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x6000B9C")]
			[Cpp2IlInjected.Address(RVA = "0xE073B0", Offset = "0xE05DB0", VA = "0x180E073B0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170004D7")]
		public int BonusLevels
		{
			[Cpp2IlInjected.Token(Token = "0x6000B9D")]
			[Cpp2IlInjected.Address(RVA = "0xD17340", Offset = "0xD15D40", VA = "0x180D17340")]
			[CompilerGenerated]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x6000B9E")]
			[Cpp2IlInjected.Address(RVA = "0xD17360", Offset = "0xD15D60", VA = "0x180D17360")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170004D8")]
		public bool PermanentBoost
		{
			[Cpp2IlInjected.Token(Token = "0x6000B9F")]
			[Cpp2IlInjected.Address(RVA = "0xEAE2D0", Offset = "0xEACCD0", VA = "0x180EAE2D0")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000BA0")]
			[Cpp2IlInjected.Address(RVA = "0xED9400", Offset = "0xED7E00", VA = "0x180ED9400")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000B97")]
		[Cpp2IlInjected.Address(RVA = "0x8DCEE00", Offset = "0x8DCD800", VA = "0x188DCEE00")]
		public BattlePassSkuDTO(BattlePassSkuType Type, int TokenPrice, int BonusLevels = 0, bool PermanentBoost = false)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000BA1")]
		[Cpp2IlInjected.Address(RVA = "0x8DCEB40", Offset = "0x8DCD540", VA = "0x188DCEB40", Slot = "3")]
		[CompilerGenerated]
		public override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000BA2")]
		[Cpp2IlInjected.Address(RVA = "0x8DCEC30", Offset = "0x8DCD630", VA = "0x188DCEC30", Slot = "6")]
		[CompilerGenerated]
		protected virtual bool WJJAKQGJTCH(StringBuilder a)
		{
			return default(bool);
		}

		[SpecialName]
		[Cpp2IlInjected.Token(Token = "0x6000BA3")]
		[Cpp2IlInjected.Address(RVA = "0x12EAD60", Offset = "0x12E9760", VA = "0x1812EAD60")]
		[CompilerGenerated]
		public static bool CYAUITUETAA(BattlePassSkuDTO? a, BattlePassSkuDTO? b)
		{
			return default(bool);
		}

		[SpecialName]
		[Cpp2IlInjected.Token(Token = "0x6000BA4")]
		[Cpp2IlInjected.Address(RVA = "0x12EB0B0", Offset = "0x12E9AB0", VA = "0x1812EB0B0")]
		[CompilerGenerated]
		public static bool ITVTPRNZGNV(BattlePassSkuDTO? a, BattlePassSkuDTO? b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000BA5")]
		[Cpp2IlInjected.Address(RVA = "0x8DCE920", Offset = "0x8DCD320", VA = "0x188DCE920", Slot = "2")]
		[CompilerGenerated]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000BA6")]
		[Cpp2IlInjected.Address(RVA = "0x8DCE890", Offset = "0x8DCD290", VA = "0x188DCE890", Slot = "0")]
		[CompilerGenerated]
		public override bool Equals(object? obj)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000BA7")]
		[Cpp2IlInjected.Address(RVA = "0x8DCE6C0", Offset = "0x8DCD0C0", VA = "0x188DCE6C0", Slot = "7")]
		[CompilerGenerated]
		public virtual bool Equals(BattlePassSkuDTO? other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000BA8")]
		[Cpp2IlInjected.Address(RVA = "0x8DCE640", Offset = "0x8DCD040", VA = "0x188DCE640", Slot = "8")]
		[CompilerGenerated]
		public virtual BattlePassSkuDTO CXDOYZBTDGW()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000BA9")]
		[Cpp2IlInjected.Address(RVA = "0x8DCEDB0", Offset = "0x8DCD7B0", VA = "0x188DCEDB0")]
		[CompilerGenerated]
		protected BattlePassSkuDTO(BattlePassSkuDTO original)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000BAA")]
		[Cpp2IlInjected.Address(RVA = "0x8DCEB20", Offset = "0x8DCD520", VA = "0x188DCEB20")]
		[CompilerGenerated]
		public void OGNPAZKLJRJ([Out] BattlePassSkuType a, [Out] int b, [Out] int c, [Out] bool d)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20001A6")]
	public enum BattlePassSkuType : byte
	{
		[Cpp2IlInjected.Token(Token = "0x4000807")]
		Invalid,
		[Cpp2IlInjected.Token(Token = "0x4000808")]
		StandardPass,
		[Cpp2IlInjected.Token(Token = "0x4000809")]
		AcceleratedPass,
		[Cpp2IlInjected.Token(Token = "0x400080A")]
		UltimatePass,
		[Cpp2IlInjected.Token(Token = "0x400080B")]
		Permaboost
	}
	[Cpp2IlInjected.Token(Token = "0x20001A7")]
	[Utf8JsonSerializable]
	public class PurchaseBattlePassPermanentBoostRequestDTO : IEquatable<PurchaseBattlePassPermanentBoostRequestDTO>
	{
		[Cpp2IlInjected.Token(Token = "0x170004D9")]
		[CompilerGenerated]
		protected virtual Type VZLUXMAJKRJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000BAC")]
			[Cpp2IlInjected.Address(RVA = "0x8DCFD70", Offset = "0x8DCE770", VA = "0x188DCFD70", Slot = "5")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170004DA")]
		public int RequestedPrice
		{
			[Cpp2IlInjected.Token(Token = "0x6000BAD")]
			[Cpp2IlInjected.Address(RVA = "0xD0F110", Offset = "0xD0DB10", VA = "0x180D0F110")]
			[CompilerGenerated]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x6000BAE")]
			[Cpp2IlInjected.Address(RVA = "0xD12F30", Offset = "0xD11930", VA = "0x180D12F30")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170004DB")]
		public int? ToAccountId
		{
			[Cpp2IlInjected.Token(Token = "0x6000BAF")]
			[Cpp2IlInjected.Address(RVA = "0x141BB20", Offset = "0x141A520", VA = "0x18141BB20")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000BB0")]
			[Cpp2IlInjected.Address(RVA = "0x141E140", Offset = "0x141CB40", VA = "0x18141E140")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000BAB")]
		[Cpp2IlInjected.Address(RVA = "0x8DCFF90", Offset = "0x8DCE990", VA = "0x188DCFF90")]
		public PurchaseBattlePassPermanentBoostRequestDTO(int RequestedPrice, int? ToAccountId)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000BB1")]
		[Cpp2IlInjected.Address(RVA = "0x8DCFDD0", Offset = "0x8DCE7D0", VA = "0x188DCFDD0", Slot = "3")]
		[CompilerGenerated]
		public override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000BB2")]
		[Cpp2IlInjected.Address(RVA = "0x8DCFEC0", Offset = "0x8DCE8C0", VA = "0x188DCFEC0", Slot = "6")]
		[CompilerGenerated]
		protected virtual bool WJJAKQGJTCH(StringBuilder a)
		{
			return default(bool);
		}

		[SpecialName]
		[Cpp2IlInjected.Token(Token = "0x6000BB3")]
		[Cpp2IlInjected.Address(RVA = "0x12EAD60", Offset = "0x12E9760", VA = "0x1812EAD60")]
		[CompilerGenerated]
		public static bool CYAUITUETAA(PurchaseBattlePassPermanentBoostRequestDTO? a, PurchaseBattlePassPermanentBoostRequestDTO? b)
		{
			return default(bool);
		}

		[SpecialName]
		[Cpp2IlInjected.Token(Token = "0x6000BB4")]
		[Cpp2IlInjected.Address(RVA = "0x12EB0B0", Offset = "0x12E9AB0", VA = "0x1812EB0B0")]
		[CompilerGenerated]
		public static bool ITVTPRNZGNV(PurchaseBattlePassPermanentBoostRequestDTO? a, PurchaseBattlePassPermanentBoostRequestDTO? b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000BB5")]
		[Cpp2IlInjected.Address(RVA = "0x8DCFC60", Offset = "0x8DCE660", VA = "0x188DCFC60", Slot = "2")]
		[CompilerGenerated]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000BB6")]
		[Cpp2IlInjected.Address(RVA = "0x8DCFA80", Offset = "0x8DCE480", VA = "0x188DCFA80", Slot = "0")]
		[CompilerGenerated]
		public override bool Equals(object? obj)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000BB7")]
		[Cpp2IlInjected.Address(RVA = "0x8DCFB10", Offset = "0x8DCE510", VA = "0x188DCFB10", Slot = "7")]
		[CompilerGenerated]
		public virtual bool Equals(PurchaseBattlePassPermanentBoostRequestDTO? other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000BB8")]
		[Cpp2IlInjected.Address(RVA = "0x8DCFA10", Offset = "0x8DCE410", VA = "0x188DCFA10", Slot = "8")]
		[CompilerGenerated]
		public virtual PurchaseBattlePassPermanentBoostRequestDTO CXDOYZBTDGW()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000BB9")]
		[Cpp2IlInjected.Address(RVA = "0x8DCFFA0", Offset = "0x8DCE9A0", VA = "0x188DCFFA0")]
		[CompilerGenerated]
		protected PurchaseBattlePassPermanentBoostRequestDTO(PurchaseBattlePassPermanentBoostRequestDTO original)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000BBA")]
		[Cpp2IlInjected.Address(RVA = "0x8DCFDC0", Offset = "0x8DCE7C0", VA = "0x188DCFDC0")]
		[CompilerGenerated]
		public void OGNPAZKLJRJ([Out] int a, [Out] int? b)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20001A8")]
	[Utf8JsonSerializable]
	public class PurchaseBattlePassRequestDTO : IEquatable<PurchaseBattlePassRequestDTO>
	{
		[Cpp2IlInjected.Token(Token = "0x170004DC")]
		[CompilerGenerated]
		protected virtual Type VZLUXMAJKRJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000BBC")]
			[Cpp2IlInjected.Address(RVA = "0x8DD03D0", Offset = "0x8DCEDD0", VA = "0x188DD03D0", Slot = "5")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170004DD")]
		public BattlePassSkuType Type
		{
			[Cpp2IlInjected.Token(Token = "0x6000BBD")]
			[Cpp2IlInjected.Address(RVA = "0xD66E30", Offset = "0xD65830", VA = "0x180D66E30")]
			[CompilerGenerated]
			get
			{
				return default(BattlePassSkuType);
			}
			[Cpp2IlInjected.Token(Token = "0x6000BBE")]
			[Cpp2IlInjected.Address(RVA = "0xE376D0", Offset = "0xE360D0", VA = "0x180E376D0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170004DE")]
		public int? ToAccountId
		{
			[Cpp2IlInjected.Token(Token = "0x6000BBF")]
			[Cpp2IlInjected.Address(RVA = "0x141BB20", Offset = "0x141A520", VA = "0x18141BB20")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000BC0")]
			[Cpp2IlInjected.Address(RVA = "0x141E140", Offset = "0x141CB40", VA = "0x18141E140")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170004DF")]
		public int? RequestedPrice
		{
			[Cpp2IlInjected.Token(Token = "0x6000BC1")]
			[Cpp2IlInjected.Address(RVA = "0x141BB50", Offset = "0x141A550", VA = "0x18141BB50")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000BC2")]
			[Cpp2IlInjected.Address(RVA = "0x141BB80", Offset = "0x141A580", VA = "0x18141BB80")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000BBB")]
		[Cpp2IlInjected.Address(RVA = "0x8DD0670", Offset = "0x8DCF070", VA = "0x188DD0670")]
		public PurchaseBattlePassRequestDTO(BattlePassSkuType Type, int? ToAccountId, int? RequestedPrice)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000BC3")]
		[Cpp2IlInjected.Address(RVA = "0x8DD0440", Offset = "0x8DCEE40", VA = "0x188DD0440", Slot = "3")]
		[CompilerGenerated]
		public override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000BC4")]
		[Cpp2IlInjected.Address(RVA = "0x8DD0530", Offset = "0x8DCEF30", VA = "0x188DD0530", Slot = "6")]
		[CompilerGenerated]
		protected virtual bool WJJAKQGJTCH(StringBuilder a)
		{
			return default(bool);
		}

		[SpecialName]
		[Cpp2IlInjected.Token(Token = "0x6000BC5")]
		[Cpp2IlInjected.Address(RVA = "0x12EAD60", Offset = "0x12E9760", VA = "0x1812EAD60")]
		[CompilerGenerated]
		public static bool CYAUITUETAA(PurchaseBattlePassRequestDTO? a, PurchaseBattlePassRequestDTO? b)
		{
			return default(bool);
		}

		[SpecialName]
		[Cpp2IlInjected.Token(Token = "0x6000BC6")]
		[Cpp2IlInjected.Address(RVA = "0x12EB0B0", Offset = "0x12E9AB0", VA = "0x1812EB0B0")]
		[CompilerGenerated]
		public static bool ITVTPRNZGNV(PurchaseBattlePassRequestDTO? a, PurchaseBattlePassRequestDTO? b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000BC7")]
		[Cpp2IlInjected.Address(RVA = "0x8DD0270", Offset = "0x8DCEC70", VA = "0x188DD0270", Slot = "2")]
		[CompilerGenerated]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000BC8")]
		[Cpp2IlInjected.Address(RVA = "0x8DD0060", Offset = "0x8DCEA60", VA = "0x188DD0060", Slot = "0")]
		[CompilerGenerated]
		public override bool Equals(object? obj)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000BC9")]
		[Cpp2IlInjected.Address(RVA = "0x8DD00F0", Offset = "0x8DCEAF0", VA = "0x188DD00F0", Slot = "7")]
		[CompilerGenerated]
		public virtual bool Equals(PurchaseBattlePassRequestDTO? other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000BCA")]
		[Cpp2IlInjected.Address(RVA = "0x8DCFFE0", Offset = "0x8DCE9E0", VA = "0x188DCFFE0", Slot = "8")]
		[CompilerGenerated]
		public virtual PurchaseBattlePassRequestDTO CXDOYZBTDGW()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000BCB")]
		[Cpp2IlInjected.Address(RVA = "0x8DD0690", Offset = "0x8DCF090", VA = "0x188DD0690")]
		[CompilerGenerated]
		protected PurchaseBattlePassRequestDTO(PurchaseBattlePassRequestDTO original)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000BCC")]
		[Cpp2IlInjected.Address(RVA = "0x8DD0420", Offset = "0x8DCEE20", VA = "0x188DD0420")]
		[CompilerGenerated]
		public void OGNPAZKLJRJ([Out] BattlePassSkuType a, [Out] int? b, [Out] int? c)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20001A9")]
	[Utf8JsonSerializable]
	public class ReportBattlePassSessionRequestDTO : IEquatable<ReportBattlePassSessionRequestDTO>
	{
		[Cpp2IlInjected.Token(Token = "0x170004E0")]
		[CompilerGenerated]
		protected virtual Type VZLUXMAJKRJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000BCE")]
			[Cpp2IlInjected.Address(RVA = "0x8DD0BB0", Offset = "0x8DCF5B0", VA = "0x188DD0BB0", Slot = "5")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170004E1")]
		public long RoomInstanceId
		{
			[Cpp2IlInjected.Token(Token = "0x6000BCF")]
			[Cpp2IlInjected.Address(RVA = "0xD117B0", Offset = "0xD101B0", VA = "0x180D117B0")]
			[CompilerGenerated]
			get
			{
				return default(long);
			}
			[Cpp2IlInjected.Token(Token = "0x6000BD0")]
			[Cpp2IlInjected.Address(RVA = "0xED90B0", Offset = "0xED7AB0", VA = "0x180ED90B0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170004E2")]
		public DateTime SessionStartTime
		{
			[Cpp2IlInjected.Token(Token = "0x6000BD1")]
			[Cpp2IlInjected.Address(RVA = "0xD11B30", Offset = "0xD10530", VA = "0x180D11B30")]
			[CompilerGenerated]
			get
			{
				return default(DateTime);
			}
			[Cpp2IlInjected.Token(Token = "0x6000BD2")]
			[Cpp2IlInjected.Address(RVA = "0xE07390", Offset = "0xE05D90", VA = "0x180E07390")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170004E3")]
		public IReadOnlyDictionary<BattlePassEvent, int> Events
		{
			[Cpp2IlInjected.Token(Token = "0x6000BD3")]
			[Cpp2IlInjected.Address(RVA = "0xD12BC0", Offset = "0xD115C0", VA = "0x180D12BC0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000BD4")]
			[Cpp2IlInjected.Address(RVA = "0xD11520", Offset = "0xD0FF20", VA = "0x180D11520")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170004E4")]
		public IReadOnlyList<int> TeammateAccountIds
		{
			[Cpp2IlInjected.Token(Token = "0x6000BD5")]
			[Cpp2IlInjected.Address(RVA = "0xD11B00", Offset = "0xD10500", VA = "0x180D11B00")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000BD6")]
			[Cpp2IlInjected.Address(RVA = "0xD11530", Offset = "0xD0FF30", VA = "0x180D11530")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000BCD")]
		[Cpp2IlInjected.Address(RVA = "0x8DD0E70", Offset = "0x8DCF870", VA = "0x188DD0E70")]
		public ReportBattlePassSessionRequestDTO(long RoomInstanceId, DateTime SessionStartTime, IReadOnlyDictionary<BattlePassEvent, int> Events, IReadOnlyList<int> TeammateAccountIds)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000BD7")]
		[Cpp2IlInjected.Address(RVA = "0x8DD0C40", Offset = "0x8DCF640", VA = "0x188DD0C40", Slot = "3")]
		[CompilerGenerated]
		public override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000BD8")]
		[Cpp2IlInjected.Address(RVA = "0x8DD0D30", Offset = "0x8DCF730", VA = "0x188DD0D30", Slot = "6")]
		[CompilerGenerated]
		protected virtual bool WJJAKQGJTCH(StringBuilder a)
		{
			return default(bool);
		}

		[SpecialName]
		[Cpp2IlInjected.Token(Token = "0x6000BD9")]
		[Cpp2IlInjected.Address(RVA = "0x12EAD60", Offset = "0x12E9760", VA = "0x1812EAD60")]
		[CompilerGenerated]
		public static bool CYAUITUETAA(ReportBattlePassSessionRequestDTO? a, ReportBattlePassSessionRequestDTO? b)
		{
			return default(bool);
		}

		[SpecialName]
		[Cpp2IlInjected.Token(Token = "0x6000BDA")]
		[Cpp2IlInjected.Address(RVA = "0x12EB0B0", Offset = "0x12E9AB0", VA = "0x1812EB0B0")]
		[CompilerGenerated]
		public static bool ITVTPRNZGNV(ReportBattlePassSessionRequestDTO? a, ReportBattlePassSessionRequestDTO? b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000BDB")]
		[Cpp2IlInjected.Address(RVA = "0x8DD09F0", Offset = "0x8DCF3F0", VA = "0x188DD09F0", Slot = "2")]
		[CompilerGenerated]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000BDC")]
		[Cpp2IlInjected.Address(RVA = "0x8DD0780", Offset = "0x8DCF180", VA = "0x188DD0780", Slot = "0")]
		[CompilerGenerated]
		public override bool Equals(object? obj)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000BDD")]
		[Cpp2IlInjected.Address(RVA = "0x8DD0810", Offset = "0x8DCF210", VA = "0x188DD0810", Slot = "7")]
		[CompilerGenerated]
		public virtual bool Equals(ReportBattlePassSessionRequestDTO? other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000BDE")]
		[Cpp2IlInjected.Address(RVA = "0x8DD06F0", Offset = "0x8DCF0F0", VA = "0x188DD06F0", Slot = "8")]
		[CompilerGenerated]
		public virtual ReportBattlePassSessionRequestDTO CXDOYZBTDGW()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000BDF")]
		[Cpp2IlInjected.Address(RVA = "0x8DD0EC0", Offset = "0x8DCF8C0", VA = "0x188DD0EC0")]
		[CompilerGenerated]
		protected ReportBattlePassSessionRequestDTO(ReportBattlePassSessionRequestDTO original)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000BE0")]
		[Cpp2IlInjected.Address(RVA = "0x8DD0C00", Offset = "0x8DCF600", VA = "0x188DD0C00")]
		[CompilerGenerated]
		public void OGNPAZKLJRJ([Out] long a, [Out] DateTime b, [Out] IReadOnlyDictionary<BattlePassEvent, int> c, [Out] IReadOnlyList<int> d)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20001AA")]
	[Utf8JsonSerializable]
	public class ReportBattlePassSessionResponseDTO : IEquatable<ReportBattlePassSessionResponseDTO>
	{
		[Cpp2IlInjected.Token(Token = "0x170004E5")]
		[CompilerGenerated]
		protected virtual Type VZLUXMAJKRJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000BE2")]
			[Cpp2IlInjected.Address(RVA = "0x8DD14B0", Offset = "0x8DCFEB0", VA = "0x188DD14B0", Slot = "5")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170004E6")]
		public BattlePassAccountProgressDTO Progress
		{
			[Cpp2IlInjected.Token(Token = "0x6000BE3")]
			[Cpp2IlInjected.Address(RVA = "0xD117B0", Offset = "0xD101B0", VA = "0x180D117B0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000BE4")]
			[Cpp2IlInjected.Address(RVA = "0xD117C0", Offset = "0xD101C0", VA = "0x180D117C0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170004E7")]
		public int EventXpEarned
		{
			[Cpp2IlInjected.Token(Token = "0x6000BE5")]
			[Cpp2IlInjected.Address(RVA = "0xD17340", Offset = "0xD15D40", VA = "0x180D17340")]
			[CompilerGenerated]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x6000BE6")]
			[Cpp2IlInjected.Address(RVA = "0xD17360", Offset = "0xD15D60", VA = "0x180D17360")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170004E8")]
		public int ParticipationBonusXpEarned
		{
			[Cpp2IlInjected.Token(Token = "0x6000BE7")]
			[Cpp2IlInjected.Address(RVA = "0x1664600", Offset = "0x1663000", VA = "0x181664600")]
			[CompilerGenerated]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x6000BE8")]
			[Cpp2IlInjected.Address(RVA = "0x1664610", Offset = "0x1663010", VA = "0x181664610")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170004E9")]
		public bool WasParticipationBonusCountIncremented
		{
			[Cpp2IlInjected.Token(Token = "0x6000BE9")]
			[Cpp2IlInjected.Address(RVA = "0xD11950", Offset = "0xD10350", VA = "0x180D11950")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000BEA")]
			[Cpp2IlInjected.Address(RVA = "0xD12250", Offset = "0xD10C50", VA = "0x180D12250")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170004EA")]
		public int BoostPercent
		{
			[Cpp2IlInjected.Token(Token = "0x6000BEB")]
			[Cpp2IlInjected.Address(RVA = "0xD38090", Offset = "0xD36A90", VA = "0x180D38090")]
			[CompilerGenerated]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x6000BEC")]
			[Cpp2IlInjected.Address(RVA = "0xF21A50", Offset = "0xF20450", VA = "0x180F21A50")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170004EB")]
		public int TeamBonusPercent
		{
			[Cpp2IlInjected.Token(Token = "0x6000BED")]
			[Cpp2IlInjected.Address(RVA = "0xD12BE0", Offset = "0xD115E0", VA = "0x180D12BE0")]
			[CompilerGenerated]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x6000BEE")]
			[Cpp2IlInjected.Address(RVA = "0xD12C40", Offset = "0xD11640", VA = "0x180D12C40")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000BE1")]
		[Cpp2IlInjected.Address(RVA = "0x8DD1890", Offset = "0x8DD0290", VA = "0x188DD1890")]
		public ReportBattlePassSessionResponseDTO(BattlePassAccountProgressDTO Progress, int EventXpEarned, int ParticipationBonusXpEarned, bool WasParticipationBonusCountIncremented, int BoostPercent, int TeamBonusPercent)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000BEF")]
		[Cpp2IlInjected.Address(RVA = "0x8DD1570", Offset = "0x8DCFF70", VA = "0x188DD1570", Slot = "3")]
		[CompilerGenerated]
		public override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000BF0")]
		[Cpp2IlInjected.Address(RVA = "0x8DD1660", Offset = "0x8DD0060", VA = "0x188DD1660", Slot = "6")]
		[CompilerGenerated]
		protected virtual bool WJJAKQGJTCH(StringBuilder a)
		{
			return default(bool);
		}

		[SpecialName]
		[Cpp2IlInjected.Token(Token = "0x6000BF1")]
		[Cpp2IlInjected.Address(RVA = "0x12EAD60", Offset = "0x12E9760", VA = "0x1812EAD60")]
		[CompilerGenerated]
		public static bool CYAUITUETAA(ReportBattlePassSessionResponseDTO? a, ReportBattlePassSessionResponseDTO? b)
		{
			return default(bool);
		}

		[SpecialName]
		[Cpp2IlInjected.Token(Token = "0x6000BF2")]
		[Cpp2IlInjected.Address(RVA = "0x12EB0B0", Offset = "0x12E9AB0", VA = "0x1812EB0B0")]
		[CompilerGenerated]
		public static bool ITVTPRNZGNV(ReportBattlePassSessionResponseDTO? a, ReportBattlePassSessionResponseDTO? b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000BF3")]
		[Cpp2IlInjected.Address(RVA = "0x8DD1280", Offset = "0x8DCFC80", VA = "0x188DD1280", Slot = "2")]
		[CompilerGenerated]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000BF4")]
		[Cpp2IlInjected.Address(RVA = "0x8DD11F0", Offset = "0x8DCFBF0", VA = "0x188DD11F0", Slot = "0")]
		[CompilerGenerated]
		public override bool Equals(object? obj)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000BF5")]
		[Cpp2IlInjected.Address(RVA = "0x8DD0FB0", Offset = "0x8DCF9B0", VA = "0x188DD0FB0", Slot = "7")]
		[CompilerGenerated]
		public virtual bool Equals(ReportBattlePassSessionResponseDTO? other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000BF6")]
		[Cpp2IlInjected.Address(RVA = "0x8DD0F20", Offset = "0x8DCF920", VA = "0x188DD0F20", Slot = "8")]
		[CompilerGenerated]
		public virtual ReportBattlePassSessionResponseDTO CXDOYZBTDGW()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000BF7")]
		[Cpp2IlInjected.Address(RVA = "0x8DD1830", Offset = "0x8DD0230", VA = "0x188DD1830")]
		[CompilerGenerated]
		protected ReportBattlePassSessionResponseDTO(ReportBattlePassSessionResponseDTO original)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000BF8")]
		[Cpp2IlInjected.Address(RVA = "0x8DD1500", Offset = "0x8DCFF00", VA = "0x188DD1500")]
		[CompilerGenerated]
		public void OGNPAZKLJRJ([Out] BattlePassAccountProgressDTO a, [Out] int b, [Out] int c, [Out] bool d, [Out] int e, [Out] int f)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20001AB")]
	public interface JEHVZWEFFVL
	{
		[Cpp2IlInjected.Token(Token = "0x6000BF9")]
		[Cpp2IlInjected.Address(Slot = "0")]
		Task<BattlePassDTO> DKHDWFFYPOC([Optional] CancellationToken a);

		[Cpp2IlInjected.Token(Token = "0x6000BFA")]
		[Cpp2IlInjected.Address(Slot = "1")]
		Task<BattlePassAccountProgressDTO> COFLBWLLQJV([Optional] CancellationToken a);

		[Cpp2IlInjected.Token(Token = "0x6000BFB")]
		[Cpp2IlInjected.Address(Slot = "2")]
		Task FPNDZOSZJXT(BattlePassSkuType a, [Optional] int? b, [Optional] int? c, [Optional] CancellationToken d);

		[Cpp2IlInjected.Token(Token = "0x6000BFC")]
		[Cpp2IlInjected.Address(Slot = "3")]
		Task XMREHHAZSST(int a, [Optional] int? b, [Optional] CancellationToken c);

		[Cpp2IlInjected.Token(Token = "0x6000BFD")]
		[Cpp2IlInjected.Address(Slot = "4")]
		Task<ReportBattlePassSessionResponseDTO> TJOSMQINHUD(DateTime a, IReadOnlyDictionary<BattlePassEvent, int> b, IReadOnlyList<int> c, [Optional] CancellationToken d);

		[Cpp2IlInjected.Token(Token = "0x6000BFE")]
		[Cpp2IlInjected.Address(Slot = "5")]
		Task VIPPZCBCXLE([Optional] CancellationToken a);
	}
}
namespace RecNet.AI
{
	[Cpp2IlInjected.Token(Token = "0x20001AC")]
	[Utf8JsonSerializable]
	public class RoomieEnergyDTO
	{
		[Cpp2IlInjected.Token(Token = "0x170004EC")]
		public long MaxEnergyFromSubscriptions
		{
			[Cpp2IlInjected.Token(Token = "0x6000BFF")]
			[Cpp2IlInjected.Address(RVA = "0xD117B0", Offset = "0xD101B0", VA = "0x180D117B0")]
			[CompilerGenerated]
			get
			{
				return default(long);
			}
			[Cpp2IlInjected.Token(Token = "0x6000C00")]
			[Cpp2IlInjected.Address(RVA = "0xED90B0", Offset = "0xED7AB0", VA = "0x180ED90B0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170004ED")]
		public long EnergyLeft
		{
			[Cpp2IlInjected.Token(Token = "0x6000C01")]
			[Cpp2IlInjected.Address(RVA = "0xD11B30", Offset = "0xD10530", VA = "0x180D11B30")]
			[CompilerGenerated]
			get
			{
				return default(long);
			}
			[Cpp2IlInjected.Token(Token = "0x6000C02")]
			[Cpp2IlInjected.Address(RVA = "0xE07390", Offset = "0xE05D90", VA = "0x180E07390")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170004EE")]
		public bool OutputAudioEnabled
		{
			[Cpp2IlInjected.Token(Token = "0x6000C03")]
			[Cpp2IlInjected.Address(RVA = "0xD11950", Offset = "0xD10350", VA = "0x180D11950")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000C04")]
			[Cpp2IlInjected.Address(RVA = "0xD12250", Offset = "0xD10C50", VA = "0x180D12250")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000C05")]
		[Cpp2IlInjected.Address(RVA = "0xD16C40", Offset = "0xD15640", VA = "0x180D16C40")]
		public RoomieEnergyDTO()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20001AD")]
	[Utf8JsonSerializable]
	public class GenerateCircuitsRequestDTO
	{
		[Cpp2IlInjected.Token(Token = "0x170004EF")]
		public string Prompt
		{
			[Cpp2IlInjected.Token(Token = "0x6000C06")]
			[Cpp2IlInjected.Address(RVA = "0xD117B0", Offset = "0xD101B0", VA = "0x180D117B0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000C07")]
			[Cpp2IlInjected.Address(RVA = "0xD117C0", Offset = "0xD101C0", VA = "0x180D117C0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170004F0")]
		public CircuitObjectDefinition? ObjectDefinition
		{
			[Cpp2IlInjected.Token(Token = "0x6000C08")]
			[Cpp2IlInjected.Address(RVA = "0xD11B30", Offset = "0xD10530", VA = "0x180D11B30")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000C09")]
			[Cpp2IlInjected.Address(RVA = "0xD12270", Offset = "0xD10C70", VA = "0x180D12270")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170004F1")]
		public IReadOnlyList<CircuitObjectDefinition>? SceneObjectDefinitions
		{
			[Cpp2IlInjected.Token(Token = "0x6000C0A")]
			[Cpp2IlInjected.Address(RVA = "0xD12BC0", Offset = "0xD115C0", VA = "0x180D12BC0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000C0B")]
			[Cpp2IlInjected.Address(RVA = "0xD11520", Offset = "0xD0FF20", VA = "0x180D11520")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170004F2")]
		public IReadOnlyList<string>? SceneTags
		{
			[Cpp2IlInjected.Token(Token = "0x6000C0C")]
			[Cpp2IlInjected.Address(RVA = "0xD11B00", Offset = "0xD10500", VA = "0x180D11B00")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000C0D")]
			[Cpp2IlInjected.Address(RVA = "0xD11530", Offset = "0xD0FF30", VA = "0x180D11530")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170004F3")]
		public CircuitGenConfigDTO Config
		{
			[Cpp2IlInjected.Token(Token = "0x6000C0E")]
			[Cpp2IlInjected.Address(RVA = "0xD11A20", Offset = "0xD10420", VA = "0x180D11A20")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000C0F")]
			[Cpp2IlInjected.Address(RVA = "0xD17350", Offset = "0xD15D50", VA = "0x180D17350")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170004F4")]
		public string? Instructions
		{
			[Cpp2IlInjected.Token(Token = "0x6000C10")]
			[Cpp2IlInjected.Address(RVA = "0xD12280", Offset = "0xD10C80", VA = "0x180D12280")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000C11")]
			[Cpp2IlInjected.Address(RVA = "0xD11B50", Offset = "0xD10550", VA = "0x180D11B50")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170004F5")]
		public string? LibraryCode
		{
			[Cpp2IlInjected.Token(Token = "0x6000C12")]
			[Cpp2IlInjected.Address(RVA = "0xD11A30", Offset = "0xD10430", VA = "0x180D11A30")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000C13")]
			[Cpp2IlInjected.Address(RVA = "0xD12260", Offset = "0xD10C60", VA = "0x180D12260")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170004F6")]
		public string? Model
		{
			[Cpp2IlInjected.Token(Token = "0x6000C14")]
			[Cpp2IlInjected.Address(RVA = "0xD122E0", Offset = "0xD10CE0", VA = "0x180D122E0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000C15")]
			[Cpp2IlInjected.Address(RVA = "0xD12290", Offset = "0xD10C90", VA = "0x180D12290")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000C16")]
		[Cpp2IlInjected.Address(RVA = "0xD16C40", Offset = "0xD15640", VA = "0x180D16C40")]
		public GenerateCircuitsRequestDTO()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20001AE")]
	[Utf8JsonSerializable]
	public class GenerateCircuitsFromCodeRequestDTO
	{
		[Cpp2IlInjected.Token(Token = "0x170004F7")]
		public string Code
		{
			[Cpp2IlInjected.Token(Token = "0x6000C17")]
			[Cpp2IlInjected.Address(RVA = "0xD117B0", Offset = "0xD101B0", VA = "0x180D117B0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000C18")]
			[Cpp2IlInjected.Address(RVA = "0xD117C0", Offset = "0xD101C0", VA = "0x180D117C0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170004F8")]
		public CircuitObjectDefinition? ObjectDefinition
		{
			[Cpp2IlInjected.Token(Token = "0x6000C19")]
			[Cpp2IlInjected.Address(RVA = "0xD11B30", Offset = "0xD10530", VA = "0x180D11B30")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000C1A")]
			[Cpp2IlInjected.Address(RVA = "0xD12270", Offset = "0xD10C70", VA = "0x180D12270")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170004F9")]
		public CircuitGenConfigDTO Config
		{
			[Cpp2IlInjected.Token(Token = "0x6000C1B")]
			[Cpp2IlInjected.Address(RVA = "0xD12BC0", Offset = "0xD115C0", VA = "0x180D12BC0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000C1C")]
			[Cpp2IlInjected.Address(RVA = "0xD11520", Offset = "0xD0FF20", VA = "0x180D11520")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170004FA")]
		public string? LibraryCode
		{
			[Cpp2IlInjected.Token(Token = "0x6000C1D")]
			[Cpp2IlInjected.Address(RVA = "0xD11B00", Offset = "0xD10500", VA = "0x180D11B00")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000C1E")]
			[Cpp2IlInjected.Address(RVA = "0xD11530", Offset = "0xD0FF30", VA = "0x180D11530")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170004FB")]
		public IReadOnlyList<string>? SceneTags
		{
			[Cpp2IlInjected.Token(Token = "0x6000C1F")]
			[Cpp2IlInjected.Address(RVA = "0xD11A20", Offset = "0xD10420", VA = "0x180D11A20")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000C20")]
			[Cpp2IlInjected.Address(RVA = "0xD17350", Offset = "0xD15D50", VA = "0x180D17350")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000C21")]
		[Cpp2IlInjected.Address(RVA = "0xD16C40", Offset = "0xD15640", VA = "0x180D16C40")]
		public GenerateCircuitsFromCodeRequestDTO()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20001AF")]
	[Utf8JsonSerializable]
	public class CircuitGenConfigDTO
	{
		[Cpp2IlInjected.Token(Token = "0x170004FC")]
		public string LibraryId
		{
			[Cpp2IlInjected.Token(Token = "0x6000C23")]
			[Cpp2IlInjected.Address(RVA = "0xD117B0", Offset = "0xD101B0", VA = "0x180D117B0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000C24")]
			[Cpp2IlInjected.Address(RVA = "0xD117C0", Offset = "0xD101C0", VA = "0x180D117C0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170004FD")]
		public bool AllowBetaContent
		{
			[Cpp2IlInjected.Token(Token = "0x6000C25")]
			[Cpp2IlInjected.Address(RVA = "0xEB2260", Offset = "0xEB0C60", VA = "0x180EB2260")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000C26")]
			[Cpp2IlInjected.Address(RVA = "0xD19FA0", Offset = "0xD189A0", VA = "0x180D19FA0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170004FE")]
		public bool ComponentModificationEnabled
		{
			[Cpp2IlInjected.Token(Token = "0x6000C27")]
			[Cpp2IlInjected.Address(RVA = "0x1290080", Offset = "0x128EA80", VA = "0x181290080")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000C28")]
			[Cpp2IlInjected.Address(RVA = "0x1414300", Offset = "0x1412D00", VA = "0x181414300")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170004FF")]
		public bool UseOnObjectSpawnedOrReset
		{
			[Cpp2IlInjected.Token(Token = "0x6000C29")]
			[Cpp2IlInjected.Address(RVA = "0x1290070", Offset = "0x128EA70", VA = "0x181290070")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000C2A")]
			[Cpp2IlInjected.Address(RVA = "0x17595B0", Offset = "0x1757FB0", VA = "0x1817595B0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000500")]
		public bool ExposeTunables
		{
			[Cpp2IlInjected.Token(Token = "0x6000C2B")]
			[Cpp2IlInjected.Address(RVA = "0x1290060", Offset = "0x128EA60", VA = "0x181290060")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000C2C")]
			[Cpp2IlInjected.Address(RVA = "0x539A4F0", Offset = "0x5398EF0", VA = "0x18539A4F0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000501")]
		public bool ExposePublicMethods
		{
			[Cpp2IlInjected.Token(Token = "0x6000C2D")]
			[Cpp2IlInjected.Address(RVA = "0xEAE2D0", Offset = "0xEACCD0", VA = "0x180EAE2D0")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000C2E")]
			[Cpp2IlInjected.Address(RVA = "0xED9400", Offset = "0xED7E00", VA = "0x180ED9400")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000502")]
		public bool ObjectEventsEnabled
		{
			[Cpp2IlInjected.Token(Token = "0x6000C2F")]
			[Cpp2IlInjected.Address(RVA = "0xED9EA0", Offset = "0xED88A0", VA = "0x180ED9EA0")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000C30")]
			[Cpp2IlInjected.Address(RVA = "0xED9870", Offset = "0xED8270", VA = "0x180ED9870")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000503")]
		public bool SpawnablesEnabled
		{
			[Cpp2IlInjected.Token(Token = "0x6000C31")]
			[Cpp2IlInjected.Address(RVA = "0x1BE6E70", Offset = "0x1BE5870", VA = "0x181BE6E70")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000C32")]
			[Cpp2IlInjected.Address(RVA = "0x8DCF110", Offset = "0x8DCDB10", VA = "0x188DCF110")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000504")]
		public bool TagEnumEnabled
		{
			[Cpp2IlInjected.Token(Token = "0x6000C33")]
			[Cpp2IlInjected.Address(RVA = "0x1BCDE00", Offset = "0x1BCC800", VA = "0x181BCDE00")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000C34")]
			[Cpp2IlInjected.Address(RVA = "0x8DCF120", Offset = "0x8DCDB20", VA = "0x188DCF120")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000505")]
		public bool IsRecRoomObjectOfTypeEnabled
		{
			[Cpp2IlInjected.Token(Token = "0x6000C35")]
			[Cpp2IlInjected.Address(RVA = "0xD11950", Offset = "0xD10350", VA = "0x180D11950")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000C36")]
			[Cpp2IlInjected.Address(RVA = "0xD12250", Offset = "0xD10C50", VA = "0x180D12250")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000506")]
		public bool VirtualMethodsEnabled
		{
			[Cpp2IlInjected.Token(Token = "0x6000C37")]
			[Cpp2IlInjected.Address(RVA = "0x1620000", Offset = "0x161EA00", VA = "0x181620000")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000C38")]
			[Cpp2IlInjected.Address(RVA = "0x161F310", Offset = "0x161DD10", VA = "0x18161F310")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000507")]
		public bool ComponentModificationEnabledForSceneObjects
		{
			[Cpp2IlInjected.Token(Token = "0x6000C39")]
			[Cpp2IlInjected.Address(RVA = "0x1BD2720", Offset = "0x1BD1120", VA = "0x181BD2720")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000C3A")]
			[Cpp2IlInjected.Address(RVA = "0x1E2E220", Offset = "0x1E2CC20", VA = "0x181E2E220")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000C22")]
		[Cpp2IlInjected.Address(RVA = "0x8DCF060", Offset = "0x8DCDA60", VA = "0x188DCF060")]
		public CircuitGenConfigDTO(string libraryId, bool allowBetaContent, bool componentModificationEnabled, bool useOnObjectSpawnedOrReset, bool exposeTunables, bool exposePublicMethods, bool objectEventsEnabled, bool spawnablesEnabled, bool tagEnumEnabled, bool isRecRoomObjectOfTypeEnabled, bool virtualMethodsEnabled, bool componentModificationEnabledForSceneObjects)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20001B0")]
	[Utf8JsonSerializable]
	public class CreateRealtimeSessionRequestDTO
	{
		[Cpp2IlInjected.Token(Token = "0x17000508")]
		public string AIType
		{
			[Cpp2IlInjected.Token(Token = "0x6000C3B")]
			[Cpp2IlInjected.Address(RVA = "0xD117B0", Offset = "0xD101B0", VA = "0x180D117B0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000C3C")]
			[Cpp2IlInjected.Address(RVA = "0xD117C0", Offset = "0xD101C0", VA = "0x180D117C0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000509")]
		public string Model
		{
			[Cpp2IlInjected.Token(Token = "0x6000C3D")]
			[Cpp2IlInjected.Address(RVA = "0xD11B30", Offset = "0xD10530", VA = "0x180D11B30")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000C3E")]
			[Cpp2IlInjected.Address(RVA = "0xD12270", Offset = "0xD10C70", VA = "0x180D12270")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700050A")]
		public string Instructions
		{
			[Cpp2IlInjected.Token(Token = "0x6000C3F")]
			[Cpp2IlInjected.Address(RVA = "0xD12BC0", Offset = "0xD115C0", VA = "0x180D12BC0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000C40")]
			[Cpp2IlInjected.Address(RVA = "0xD11520", Offset = "0xD0FF20", VA = "0x180D11520")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700050B")]
		public string? Voice
		{
			[Cpp2IlInjected.Token(Token = "0x6000C41")]
			[Cpp2IlInjected.Address(RVA = "0xD11B00", Offset = "0xD10500", VA = "0x180D11B00")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000C42")]
			[Cpp2IlInjected.Address(RVA = "0xD11530", Offset = "0xD0FF30", VA = "0x180D11530")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700050C")]
		public string? TranscriptionModel
		{
			[Cpp2IlInjected.Token(Token = "0x6000C43")]
			[Cpp2IlInjected.Address(RVA = "0xD11A20", Offset = "0xD10420", VA = "0x180D11A20")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000C44")]
			[Cpp2IlInjected.Address(RVA = "0xD17350", Offset = "0xD15D50", VA = "0x180D17350")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700050D")]
		public float Temperature
		{
			[Cpp2IlInjected.Token(Token = "0x6000C45")]
			[Cpp2IlInjected.Address(RVA = "0xDA2840", Offset = "0xDA1240", VA = "0x180DA2840")]
			[CompilerGenerated]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x6000C46")]
			[Cpp2IlInjected.Address(RVA = "0x113A6F0", Offset = "0x11390F0", VA = "0x18113A6F0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000C47")]
		[Cpp2IlInjected.Address(RVA = "0xD16C40", Offset = "0xD15640", VA = "0x180D16C40")]
		public CreateRealtimeSessionRequestDTO()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20001B1")]
	[Utf8JsonSerializable]
	public class CreateRealtimeSessionResponseDTO : CEQBEDCXYWE
	{
		[Cpp2IlInjected.Token(Token = "0x1700050E")]
		public string SessionId
		{
			[Cpp2IlInjected.Token(Token = "0x6000C48")]
			[Cpp2IlInjected.Address(RVA = "0xD117B0", Offset = "0xD101B0", VA = "0x180D117B0", Slot = "4")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000C49")]
			[Cpp2IlInjected.Address(RVA = "0xD117C0", Offset = "0xD101C0", VA = "0x180D117C0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700050F")]
		public string ClientSecret
		{
			[Cpp2IlInjected.Token(Token = "0x6000C4A")]
			[Cpp2IlInjected.Address(RVA = "0xD11B30", Offset = "0xD10530", VA = "0x180D11B30", Slot = "5")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000C4B")]
			[Cpp2IlInjected.Address(RVA = "0xD12270", Offset = "0xD10C70", VA = "0x180D12270")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000C4C")]
		[Cpp2IlInjected.Address(RVA = "0xD16C40", Offset = "0xD15640", VA = "0x180D16C40")]
		public CreateRealtimeSessionResponseDTO()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20001B2")]
	[Utf8JsonSerializable]
	public class UpdateUserSessionSpendRequestDTO
	{
		[Cpp2IlInjected.Token(Token = "0x17000510")]
		public Guid SpendSessionId
		{
			[Cpp2IlInjected.Token(Token = "0x6000C4D")]
			[Cpp2IlInjected.Address(RVA = "0xF357F0", Offset = "0xF341F0", VA = "0x180F357F0")]
			[CompilerGenerated]
			get
			{
				return default(Guid);
			}
			[Cpp2IlInjected.Token(Token = "0x6000C4E")]
			[Cpp2IlInjected.Address(RVA = "0xF35810", Offset = "0xF34210", VA = "0x180F35810")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000511")]
		public long RoomId
		{
			[Cpp2IlInjected.Token(Token = "0x6000C4F")]
			[Cpp2IlInjected.Address(RVA = "0xD12BC0", Offset = "0xD115C0", VA = "0x180D12BC0")]
			[CompilerGenerated]
			get
			{
				return default(long);
			}
			[Cpp2IlInjected.Token(Token = "0x6000C50")]
			[Cpp2IlInjected.Address(RVA = "0xE3F130", Offset = "0xE3DB30", VA = "0x180E3F130")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000512")]
		public long RoomInstanceId
		{
			[Cpp2IlInjected.Token(Token = "0x6000C51")]
			[Cpp2IlInjected.Address(RVA = "0xD11B00", Offset = "0xD10500", VA = "0x180D11B00")]
			[CompilerGenerated]
			get
			{
				return default(long);
			}
			[Cpp2IlInjected.Token(Token = "0x6000C52")]
			[Cpp2IlInjected.Address(RVA = "0xD11960", Offset = "0xD10360", VA = "0x180D11960")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000513")]
		public decimal Spend
		{
			[Cpp2IlInjected.Token(Token = "0x6000C53")]
			[Cpp2IlInjected.Address(RVA = "0xF92C90", Offset = "0xF91690", VA = "0x180F92C90")]
			[CompilerGenerated]
			get
			{
				return default(decimal);
			}
			[Cpp2IlInjected.Token(Token = "0x6000C54")]
			[Cpp2IlInjected.Address(RVA = "0xF931D0", Offset = "0xF91BD0", VA = "0x180F931D0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000C55")]
		[Cpp2IlInjected.Address(RVA = "0xD16C40", Offset = "0xD15640", VA = "0x180D16C40")]
		public UpdateUserSessionSpendRequestDTO()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20001B3")]
	[Utf8JsonSerializable]
	public class UpdateRoomieSessionSpendRequestDTO : UpdateUserSessionSpendRequestDTO
	{
		[Cpp2IlInjected.Token(Token = "0x17000514")]
		public byte RoomieEnergyMode
		{
			[Cpp2IlInjected.Token(Token = "0x6000C56")]
			[Cpp2IlInjected.Address(RVA = "0xF85FC0", Offset = "0xF849C0", VA = "0x180F85FC0")]
			[CompilerGenerated]
			get
			{
				return default(byte);
			}
			[Cpp2IlInjected.Token(Token = "0x6000C57")]
			[Cpp2IlInjected.Address(RVA = "0xF85920", Offset = "0xF84320", VA = "0x180F85920")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000C58")]
		[Cpp2IlInjected.Address(RVA = "0xD16C40", Offset = "0xD15640", VA = "0x180D16C40")]
		public UpdateRoomieSessionSpendRequestDTO()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20001B4")]
	[Utf8JsonSerializable]
	public class UploadRealtimeSessionLogsDTO
	{
		[Cpp2IlInjected.Token(Token = "0x17000515")]
		public string SessionId
		{
			[Cpp2IlInjected.Token(Token = "0x6000C59")]
			[Cpp2IlInjected.Address(RVA = "0xD117B0", Offset = "0xD101B0", VA = "0x180D117B0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000C5A")]
			[Cpp2IlInjected.Address(RVA = "0xD117C0", Offset = "0xD101C0", VA = "0x180D117C0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000516")]
		public string Logs
		{
			[Cpp2IlInjected.Token(Token = "0x6000C5B")]
			[Cpp2IlInjected.Address(RVA = "0xD11B30", Offset = "0xD10530", VA = "0x180D11B30")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000C5C")]
			[Cpp2IlInjected.Address(RVA = "0xD12270", Offset = "0xD10C70", VA = "0x180D12270")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000C5D")]
		[Cpp2IlInjected.Address(RVA = "0xD16C40", Offset = "0xD15640", VA = "0x180D16C40")]
		public UploadRealtimeSessionLogsDTO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000C5E")]
		[Cpp2IlInjected.Address(RVA = "0xD13C40", Offset = "0xD12640", VA = "0x180D13C40")]
		public UploadRealtimeSessionLogsDTO(string sessionId, string logs)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20001B5")]
	[Utf8JsonSerializable]
	public class GenerateImageRequestDTO
	{
		[Cpp2IlInjected.Token(Token = "0x17000517")]
		public string Model
		{
			[Cpp2IlInjected.Token(Token = "0x6000C5F")]
			[Cpp2IlInjected.Address(RVA = "0xD117B0", Offset = "0xD101B0", VA = "0x180D117B0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000C60")]
			[Cpp2IlInjected.Address(RVA = "0xD117C0", Offset = "0xD101C0", VA = "0x180D117C0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000518")]
		public string Prompt
		{
			[Cpp2IlInjected.Token(Token = "0x6000C61")]
			[Cpp2IlInjected.Address(RVA = "0xD11B30", Offset = "0xD10530", VA = "0x180D11B30")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000C62")]
			[Cpp2IlInjected.Address(RVA = "0xD12270", Offset = "0xD10C70", VA = "0x180D12270")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000519")]
		public bool Tileable
		{
			[Cpp2IlInjected.Token(Token = "0x6000C63")]
			[Cpp2IlInjected.Address(RVA = "0xD11950", Offset = "0xD10350", VA = "0x180D11950")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000C64")]
			[Cpp2IlInjected.Address(RVA = "0xD12250", Offset = "0xD10C50", VA = "0x180D12250")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000C65")]
		[Cpp2IlInjected.Address(RVA = "0xD16C40", Offset = "0xD15640", VA = "0x180D16C40")]
		public GenerateImageRequestDTO()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20001B6")]
	[Utf8JsonSerializable]
	public class GenerateImageResponseDTO
	{
		[Cpp2IlInjected.Token(Token = "0x1700051A")]
		public string Filename
		{
			[Cpp2IlInjected.Token(Token = "0x6000C66")]
			[Cpp2IlInjected.Address(RVA = "0xD117B0", Offset = "0xD101B0", VA = "0x180D117B0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000C67")]
			[Cpp2IlInjected.Address(RVA = "0xD117C0", Offset = "0xD101C0", VA = "0x180D117C0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700051B")]
		public decimal ImageGenerationCost
		{
			[Cpp2IlInjected.Token(Token = "0x6000C68")]
			[Cpp2IlInjected.Address(RVA = "0xDA5E80", Offset = "0xDA4880", VA = "0x180DA5E80")]
			[CompilerGenerated]
			get
			{
				return default(decimal);
			}
			[Cpp2IlInjected.Token(Token = "0x6000C69")]
			[Cpp2IlInjected.Address(RVA = "0xF82330", Offset = "0xF80D30", VA = "0x180F82330")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000C6A")]
		[Cpp2IlInjected.Address(RVA = "0xD16C40", Offset = "0xD15640", VA = "0x180D16C40")]
		public GenerateImageResponseDTO()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20001B7")]
	[Utf8JsonSerializable]
	public class DescribeImageRequestDTO
	{
		[Cpp2IlInjected.Token(Token = "0x1700051C")]
		public string? Model
		{
			[Cpp2IlInjected.Token(Token = "0x6000C6B")]
			[Cpp2IlInjected.Address(RVA = "0xD117B0", Offset = "0xD101B0", VA = "0x180D117B0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000C6C")]
			[Cpp2IlInjected.Address(RVA = "0xD117C0", Offset = "0xD101C0", VA = "0x180D117C0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700051D")]
		public string Prompt
		{
			[Cpp2IlInjected.Token(Token = "0x6000C6D")]
			[Cpp2IlInjected.Address(RVA = "0xD11B30", Offset = "0xD10530", VA = "0x180D11B30")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000C6E")]
			[Cpp2IlInjected.Address(RVA = "0xD12270", Offset = "0xD10C70", VA = "0x180D12270")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700051E")]
		public float? Temperature
		{
			[Cpp2IlInjected.Token(Token = "0x6000C6F")]
			[Cpp2IlInjected.Address(RVA = "0xD12BC0", Offset = "0xD115C0", VA = "0x180D12BC0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000C70")]
			[Cpp2IlInjected.Address(RVA = "0xE3F130", Offset = "0xE3DB30", VA = "0x180E3F130")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700051F")]
		public string? ImageName
		{
			[Cpp2IlInjected.Token(Token = "0x6000C71")]
			[Cpp2IlInjected.Address(RVA = "0xD11B00", Offset = "0xD10500", VA = "0x180D11B00")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000C72")]
			[Cpp2IlInjected.Address(RVA = "0xD11530", Offset = "0xD0FF30", VA = "0x180D11530")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000C73")]
		[Cpp2IlInjected.Address(RVA = "0xD16C40", Offset = "0xD15640", VA = "0x180D16C40")]
		public DescribeImageRequestDTO()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20001B8")]
	[Utf8JsonSerializable]
	public class DescribeImageResponseDTO : ChatResponseDTO
	{
		[Cpp2IlInjected.Token(Token = "0x6000C74")]
		[Cpp2IlInjected.Address(RVA = "0xD16C40", Offset = "0xD15640", VA = "0x180D16C40")]
		public DescribeImageResponseDTO()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20001B9")]
	[Utf8JsonSerializable]
	public class DescribeImageFileRequestDTO : ChatRequestDTO
	{
		[Cpp2IlInjected.Token(Token = "0x6000C75")]
		[Cpp2IlInjected.Address(RVA = "0xD16C40", Offset = "0xD15640", VA = "0x180D16C40")]
		public DescribeImageFileRequestDTO()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20001BA")]
	[Utf8JsonSerializable]
	public class GenerateMeshRequestDTO
	{
		[Cpp2IlInjected.Token(Token = "0x17000520")]
		public string FriendlyName
		{
			[Cpp2IlInjected.Token(Token = "0x6000C76")]
			[Cpp2IlInjected.Address(RVA = "0xD117B0", Offset = "0xD101B0", VA = "0x180D117B0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000C77")]
			[Cpp2IlInjected.Address(RVA = "0xD117C0", Offset = "0xD101C0", VA = "0x180D117C0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000521")]
		public string Prompt
		{
			[Cpp2IlInjected.Token(Token = "0x6000C78")]
			[Cpp2IlInjected.Address(RVA = "0xD11B30", Offset = "0xD10530", VA = "0x180D11B30")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000C79")]
			[Cpp2IlInjected.Address(RVA = "0xD12270", Offset = "0xD10C70", VA = "0x180D12270")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000522")]
		public bool AllowRoomInstanceAccess
		{
			[Cpp2IlInjected.Token(Token = "0x6000C7A")]
			[Cpp2IlInjected.Address(RVA = "0xD11950", Offset = "0xD10350", VA = "0x180D11950")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000C7B")]
			[Cpp2IlInjected.Address(RVA = "0xD12250", Offset = "0xD10C50", VA = "0x180D12250")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000C7C")]
		[Cpp2IlInjected.Address(RVA = "0xD16C40", Offset = "0xD15640", VA = "0x180D16C40")]
		public GenerateMeshRequestDTO()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20001BB")]
	[Utf8JsonSerializable]
	public class GenerateMeshFromImageRequestDTO : GenerateMeshRequestDTO
	{
		[Cpp2IlInjected.Token(Token = "0x17000523")]
		public string ImageName
		{
			[Cpp2IlInjected.Token(Token = "0x6000C7D")]
			[Cpp2IlInjected.Address(RVA = "0xD11B00", Offset = "0xD10500", VA = "0x180D11B00")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000C7E")]
			[Cpp2IlInjected.Address(RVA = "0xD11530", Offset = "0xD0FF30", VA = "0x180D11530")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000C7F")]
		[Cpp2IlInjected.Address(RVA = "0xD16C40", Offset = "0xD15640", VA = "0x180D16C40")]
		public GenerateMeshFromImageRequestDTO()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20001BC")]
	[Utf8JsonSerializable]
	public class GenerateMeshResponseDTO
	{
		[Cpp2IlInjected.Token(Token = "0x17000524")]
		public long GenerateMeshRequestId
		{
			[Cpp2IlInjected.Token(Token = "0x6000C80")]
			[Cpp2IlInjected.Address(RVA = "0xD117B0", Offset = "0xD101B0", VA = "0x180D117B0")]
			[CompilerGenerated]
			get
			{
				return default(long);
			}
			[Cpp2IlInjected.Token(Token = "0x6000C81")]
			[Cpp2IlInjected.Address(RVA = "0xED90B0", Offset = "0xED7AB0", VA = "0x180ED90B0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000525")]
		public string FriendlyName
		{
			[Cpp2IlInjected.Token(Token = "0x6000C82")]
			[Cpp2IlInjected.Address(RVA = "0xD11B30", Offset = "0xD10530", VA = "0x180D11B30")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000C83")]
			[Cpp2IlInjected.Address(RVA = "0xD12270", Offset = "0xD10C70", VA = "0x180D12270")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000526")]
		public GenerateMeshRequestStates GenerateMeshRequestState
		{
			[Cpp2IlInjected.Token(Token = "0x6000C84")]
			[Cpp2IlInjected.Address(RVA = "0xD215F0", Offset = "0xD1FFF0", VA = "0x180D215F0")]
			[CompilerGenerated]
			get
			{
				return default(GenerateMeshRequestStates);
			}
			[Cpp2IlInjected.Token(Token = "0x6000C85")]
			[Cpp2IlInjected.Address(RVA = "0xD682F0", Offset = "0xD66CF0", VA = "0x180D682F0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000527")]
		public Guid? UnityAssetId
		{
			[Cpp2IlInjected.Token(Token = "0x6000C86")]
			[Cpp2IlInjected.Address(RVA = "0x8DCF310", Offset = "0x8DCDD10", VA = "0x188DCF310")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000C87")]
			[Cpp2IlInjected.Address(RVA = "0x8DCF330", Offset = "0x8DCDD30", VA = "0x188DCF330")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000528")]
		public string? MeshFileName
		{
			[Cpp2IlInjected.Token(Token = "0x6000C88")]
			[Cpp2IlInjected.Address(RVA = "0xD12280", Offset = "0xD10C80", VA = "0x180D12280")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000C89")]
			[Cpp2IlInjected.Address(RVA = "0xD11B50", Offset = "0xD10550", VA = "0x180D11B50")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000C8A")]
		[Cpp2IlInjected.Address(RVA = "0xD16C40", Offset = "0xD15640", VA = "0x180D16C40")]
		public GenerateMeshResponseDTO()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20001BD")]
	public enum GenerateMeshRequestStates
	{
		[Cpp2IlInjected.Token(Token = "0x4000859")]
		Requested = 0,
		[Cpp2IlInjected.Token(Token = "0x400085A")]
		ProviderMeshRequested = 1,
		[Cpp2IlInjected.Token(Token = "0x400085B")]
		ProviderMeshGenerated = 2,
		[Cpp2IlInjected.Token(Token = "0x400085C")]
		ProviderMeshGenFailed = 3,
		[Cpp2IlInjected.Token(Token = "0x400085D")]
		CloudBuildRequested = 11,
		[Cpp2IlInjected.Token(Token = "0x400085E")]
		CloudBuildCompleted = 12,
		[Cpp2IlInjected.Token(Token = "0x400085F")]
		CloudBuildFailed = 13,
		[Cpp2IlInjected.Token(Token = "0x4000860")]
		MeshGenCompleted = 21,
		[Cpp2IlInjected.Token(Token = "0x4000861")]
		ImageReferenceRequested = 31,
		[Cpp2IlInjected.Token(Token = "0x4000862")]
		ImageReferenceGenerated = 32,
		[Cpp2IlInjected.Token(Token = "0x4000863")]
		ImageReferenceGenerationFailed = 33
	}
	[Cpp2IlInjected.Token(Token = "0x20001BE")]
	[Utf8JsonSerializable]
	public class EditImageRequestDTO
	{
		[Cpp2IlInjected.Token(Token = "0x17000529")]
		public string? Model
		{
			[Cpp2IlInjected.Token(Token = "0x6000C8B")]
			[Cpp2IlInjected.Address(RVA = "0xD117B0", Offset = "0xD101B0", VA = "0x180D117B0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000C8C")]
			[Cpp2IlInjected.Address(RVA = "0xD117C0", Offset = "0xD101C0", VA = "0x180D117C0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700052A")]
		public string Prompt
		{
			[Cpp2IlInjected.Token(Token = "0x6000C8D")]
			[Cpp2IlInjected.Address(RVA = "0xD11B30", Offset = "0xD10530", VA = "0x180D11B30")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000C8E")]
			[Cpp2IlInjected.Address(RVA = "0xD12270", Offset = "0xD10C70", VA = "0x180D12270")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000C8F")]
		[Cpp2IlInjected.Address(RVA = "0x8DCF1F0", Offset = "0x8DCDBF0", VA = "0x188DCF1F0")]
		public EditImageRequestDTO()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20001BF")]
	[Utf8JsonSerializable]
	public class ChatRequestDTO
	{
		[Cpp2IlInjected.Token(Token = "0x1700052B")]
		public string Model
		{
			[Cpp2IlInjected.Token(Token = "0x6000C90")]
			[Cpp2IlInjected.Address(RVA = "0xD117B0", Offset = "0xD101B0", VA = "0x180D117B0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000C91")]
			[Cpp2IlInjected.Address(RVA = "0xD117C0", Offset = "0xD101C0", VA = "0x180D117C0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700052C")]
		public string Prompt
		{
			[Cpp2IlInjected.Token(Token = "0x6000C92")]
			[Cpp2IlInjected.Address(RVA = "0xD11B30", Offset = "0xD10530", VA = "0x180D11B30")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000C93")]
			[Cpp2IlInjected.Address(RVA = "0xD12270", Offset = "0xD10C70", VA = "0x180D12270")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000C94")]
		[Cpp2IlInjected.Address(RVA = "0xD16C40", Offset = "0xD15640", VA = "0x180D16C40")]
		public ChatRequestDTO()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20001C0")]
	[Utf8JsonSerializable]
	public class ChatResponseDTO
	{
		[Cpp2IlInjected.Token(Token = "0x1700052D")]
		public List<string> AIResponse
		{
			[Cpp2IlInjected.Token(Token = "0x6000C95")]
			[Cpp2IlInjected.Address(RVA = "0xD117B0", Offset = "0xD101B0", VA = "0x180D117B0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000C96")]
			[Cpp2IlInjected.Address(RVA = "0xD117C0", Offset = "0xD101C0", VA = "0x180D117C0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700052E")]
		public decimal Cost
		{
			[Cpp2IlInjected.Token(Token = "0x6000C97")]
			[Cpp2IlInjected.Address(RVA = "0xDA5E80", Offset = "0xDA4880", VA = "0x180DA5E80")]
			[CompilerGenerated]
			get
			{
				return default(decimal);
			}
			[Cpp2IlInjected.Token(Token = "0x6000C98")]
			[Cpp2IlInjected.Address(RVA = "0xF82330", Offset = "0xF80D30", VA = "0x180F82330")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000C99")]
		[Cpp2IlInjected.Address(RVA = "0xD16C40", Offset = "0xD15640", VA = "0x180D16C40")]
		public ChatResponseDTO()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20001C1")]
	[Utf8JsonSerializable]
	public class ChipPort
	{
		[Cpp2IlInjected.Token(Token = "0x1700052F")]
		public int Id
		{
			[Cpp2IlInjected.Token(Token = "0x6000C9A")]
			[Cpp2IlInjected.Address(RVA = "0xD0F110", Offset = "0xD0DB10", VA = "0x180D0F110")]
			[CompilerGenerated]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x6000C9B")]
			[Cpp2IlInjected.Address(RVA = "0xD12F30", Offset = "0xD11930", VA = "0x180D12F30")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000530")]
		public string Type
		{
			[Cpp2IlInjected.Token(Token = "0x6000C9C")]
			[Cpp2IlInjected.Address(RVA = "0xD11B30", Offset = "0xD10530", VA = "0x180D11B30")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000C9D")]
			[Cpp2IlInjected.Address(RVA = "0xD12270", Offset = "0xD10C70", VA = "0x180D12270")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000531")]
		public string? Name
		{
			[Cpp2IlInjected.Token(Token = "0x6000C9E")]
			[Cpp2IlInjected.Address(RVA = "0xD12BC0", Offset = "0xD115C0", VA = "0x180D12BC0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000C9F")]
			[Cpp2IlInjected.Address(RVA = "0xD11520", Offset = "0xD0FF20", VA = "0x180D11520")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000532")]
		public IReadOnlyList<int> Connections
		{
			[Cpp2IlInjected.Token(Token = "0x6000CA0")]
			[Cpp2IlInjected.Address(RVA = "0xD11B00", Offset = "0xD10500", VA = "0x180D11B00")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000CA1")]
			[Cpp2IlInjected.Address(RVA = "0xD11530", Offset = "0xD0FF30", VA = "0x180D11530")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000533")]
		public string? DefaultValue
		{
			[Cpp2IlInjected.Token(Token = "0x6000CA2")]
			[Cpp2IlInjected.Address(RVA = "0xD11A20", Offset = "0xD10420", VA = "0x180D11A20")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000CA3")]
			[Cpp2IlInjected.Address(RVA = "0xD17350", Offset = "0xD15D50", VA = "0x180D17350")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000CA4")]
		[Cpp2IlInjected.Address(RVA = "0x8DCEE20", Offset = "0x8DCD820", VA = "0x188DCEE20")]
		public ChipPort()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20001C2")]
	[Utf8JsonSerializable]
	public class Chip
	{
		[Cpp2IlInjected.Token(Token = "0x17000534")]
		public int Id
		{
			[Cpp2IlInjected.Token(Token = "0x6000CA5")]
			[Cpp2IlInjected.Address(RVA = "0xD0F110", Offset = "0xD0DB10", VA = "0x180D0F110")]
			[CompilerGenerated]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x6000CA6")]
			[Cpp2IlInjected.Address(RVA = "0xD12F30", Offset = "0xD11930", VA = "0x180D12F30")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000535")]
		public Guid? Guid
		{
			[Cpp2IlInjected.Token(Token = "0x6000CA7")]
			[Cpp2IlInjected.Address(RVA = "0x23E5370", Offset = "0x23E3D70", VA = "0x1823E5370")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000CA8")]
			[Cpp2IlInjected.Address(RVA = "0x23E5390", Offset = "0x23E3D90", VA = "0x1823E5390")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000536")]
		public string Type
		{
			[Cpp2IlInjected.Token(Token = "0x6000CA9")]
			[Cpp2IlInjected.Address(RVA = "0xD11B00", Offset = "0xD10500", VA = "0x180D11B00")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000CAA")]
			[Cpp2IlInjected.Address(RVA = "0xD11530", Offset = "0xD0FF30", VA = "0x180D11530")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000537")]
		public List<ChipPort> Input
		{
			[Cpp2IlInjected.Token(Token = "0x6000CAB")]
			[Cpp2IlInjected.Address(RVA = "0xD11A20", Offset = "0xD10420", VA = "0x180D11A20")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000CAC")]
			[Cpp2IlInjected.Address(RVA = "0xD17350", Offset = "0xD15D50", VA = "0x180D17350")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000538")]
		public List<ChipPort> Output
		{
			[Cpp2IlInjected.Token(Token = "0x6000CAD")]
			[Cpp2IlInjected.Address(RVA = "0xD12280", Offset = "0xD10C80", VA = "0x180D12280")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000CAE")]
			[Cpp2IlInjected.Address(RVA = "0xD11B50", Offset = "0xD10550", VA = "0x180D11B50")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000539")]
		public string? Name
		{
			[Cpp2IlInjected.Token(Token = "0x6000CAF")]
			[Cpp2IlInjected.Address(RVA = "0xD11A30", Offset = "0xD10430", VA = "0x180D11A30")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000CB0")]
			[Cpp2IlInjected.Address(RVA = "0xD12260", Offset = "0xD10C60", VA = "0x180D12260")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700053A")]
		public string? DefaultValue
		{
			[Cpp2IlInjected.Token(Token = "0x6000CB1")]
			[Cpp2IlInjected.Address(RVA = "0xD122E0", Offset = "0xD10CE0", VA = "0x180D122E0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000CB2")]
			[Cpp2IlInjected.Address(RVA = "0xD12290", Offset = "0xD10C90", VA = "0x180D12290")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700053B")]
		public string? Comment
		{
			[Cpp2IlInjected.Token(Token = "0x6000CB3")]
			[Cpp2IlInjected.Address(RVA = "0xD11B20", Offset = "0xD10520", VA = "0x180D11B20")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000CB4")]
			[Cpp2IlInjected.Address(RVA = "0xD11900", Offset = "0xD10300", VA = "0x180D11900")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000CB5")]
		[Cpp2IlInjected.Address(RVA = "0x8DCEEA0", Offset = "0x8DCD8A0", VA = "0x188DCEEA0")]
		public Chip()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20001C3")]
	[Utf8JsonSerializable]
	public class PortGroup
	{
		[Cpp2IlInjected.Token(Token = "0x1700053C")]
		public string Name
		{
			[Cpp2IlInjected.Token(Token = "0x6000CB6")]
			[Cpp2IlInjected.Address(RVA = "0xD117B0", Offset = "0xD101B0", VA = "0x180D117B0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000CB7")]
			[Cpp2IlInjected.Address(RVA = "0xD117C0", Offset = "0xD101C0", VA = "0x180D117C0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700053D")]
		public Chip Input
		{
			[Cpp2IlInjected.Token(Token = "0x6000CB8")]
			[Cpp2IlInjected.Address(RVA = "0xD11B30", Offset = "0xD10530", VA = "0x180D11B30")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000CB9")]
			[Cpp2IlInjected.Address(RVA = "0xD12270", Offset = "0xD10C70", VA = "0x180D12270")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700053E")]
		public Chip Output
		{
			[Cpp2IlInjected.Token(Token = "0x6000CBA")]
			[Cpp2IlInjected.Address(RVA = "0xD12BC0", Offset = "0xD115C0", VA = "0x180D12BC0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000CBB")]
			[Cpp2IlInjected.Address(RVA = "0xD11520", Offset = "0xD0FF20", VA = "0x180D11520")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700053F")]
		public string? Comment
		{
			[Cpp2IlInjected.Token(Token = "0x6000CBC")]
			[Cpp2IlInjected.Address(RVA = "0xD11B00", Offset = "0xD10500", VA = "0x180D11B00")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000CBD")]
			[Cpp2IlInjected.Address(RVA = "0xD11530", Offset = "0xD0FF30", VA = "0x180D11530")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000CBE")]
		[Cpp2IlInjected.Address(RVA = "0xD16C40", Offset = "0xD15640", VA = "0x180D16C40")]
		public PortGroup()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20001C4")]
	[Utf8JsonSerializable]
	public class CircuitBoard
	{
		[Cpp2IlInjected.Token(Token = "0x17000540")]
		public string Name
		{
			[Cpp2IlInjected.Token(Token = "0x6000CBF")]
			[Cpp2IlInjected.Address(RVA = "0xD117B0", Offset = "0xD101B0", VA = "0x180D117B0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000CC0")]
			[Cpp2IlInjected.Address(RVA = "0xD117C0", Offset = "0xD101C0", VA = "0x180D117C0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000541")]
		public IReadOnlyList<Chip> Chips
		{
			[Cpp2IlInjected.Token(Token = "0x6000CC1")]
			[Cpp2IlInjected.Address(RVA = "0xD11B30", Offset = "0xD10530", VA = "0x180D11B30")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000CC2")]
			[Cpp2IlInjected.Address(RVA = "0xD12270", Offset = "0xD10C70", VA = "0x180D12270")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000542")]
		public IReadOnlyList<PortGroup> PortGroups
		{
			[Cpp2IlInjected.Token(Token = "0x6000CC3")]
			[Cpp2IlInjected.Address(RVA = "0xD12BC0", Offset = "0xD115C0", VA = "0x180D12BC0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000CC4")]
			[Cpp2IlInjected.Address(RVA = "0xD11520", Offset = "0xD0FF20", VA = "0x180D11520")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000543")]
		public IReadOnlyList<CircuitBoard> Functions
		{
			[Cpp2IlInjected.Token(Token = "0x6000CC5")]
			[Cpp2IlInjected.Address(RVA = "0xD11B00", Offset = "0xD10500", VA = "0x180D11B00")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000CC6")]
			[Cpp2IlInjected.Address(RVA = "0xD11530", Offset = "0xD0FF30", VA = "0x180D11530")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000544")]
		public string? Comment
		{
			[Cpp2IlInjected.Token(Token = "0x6000CC7")]
			[Cpp2IlInjected.Address(RVA = "0xD11A20", Offset = "0xD10420", VA = "0x180D11A20")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000CC8")]
			[Cpp2IlInjected.Address(RVA = "0xD17350", Offset = "0xD15D50", VA = "0x180D17350")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000CC9")]
		[Cpp2IlInjected.Address(RVA = "0x8DCEF50", Offset = "0x8DCD950", VA = "0x188DCEF50")]
		public CircuitBoard()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20001C5")]
	[Utf8JsonSerializable]
	public class CircuitObjectDefinitionSpawnableProperties
	{
		[Cpp2IlInjected.Token(Token = "0x4000880")]
		public const string IdTagPrefix = "REPL_";

		[Cpp2IlInjected.Token(Token = "0x17000545")]
		public string Id
		{
			[Cpp2IlInjected.Token(Token = "0x6000CCA")]
			[Cpp2IlInjected.Address(RVA = "0xD117B0", Offset = "0xD101B0", VA = "0x180D117B0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000CCB")]
			[Cpp2IlInjected.Address(RVA = "0xD117C0", Offset = "0xD101C0", VA = "0x180D117C0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000546")]
		public int MaxCount
		{
			[Cpp2IlInjected.Token(Token = "0x6000CCC")]
			[Cpp2IlInjected.Address(RVA = "0xD17340", Offset = "0xD15D40", VA = "0x180D17340")]
			[CompilerGenerated]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x6000CCD")]
			[Cpp2IlInjected.Address(RVA = "0xD17360", Offset = "0xD15D60", VA = "0x180D17360")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000CCE")]
		[Cpp2IlInjected.Address(RVA = "0xD16C40", Offset = "0xD15640", VA = "0x180D16C40")]
		public CircuitObjectDefinitionSpawnableProperties()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20001C6")]
	[Utf8JsonSerializable]
	public class CircuitObjectDefinition
	{
		[Cpp2IlInjected.Token(Token = "0x17000547")]
		public int? Key
		{
			[Cpp2IlInjected.Token(Token = "0x6000CCF")]
			[Cpp2IlInjected.Address(RVA = "0xD117B0", Offset = "0xD101B0", VA = "0x180D117B0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000CD0")]
			[Cpp2IlInjected.Address(RVA = "0xED90B0", Offset = "0xED7AB0", VA = "0x180ED90B0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000548")]
		public string? CodeGenId
		{
			[Cpp2IlInjected.Token(Token = "0x6000CD1")]
			[Cpp2IlInjected.Address(RVA = "0xD11B30", Offset = "0xD10530", VA = "0x180D11B30")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000CD2")]
			[Cpp2IlInjected.Address(RVA = "0xD12270", Offset = "0xD10C70", VA = "0x180D12270")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000549")]
		public string Name
		{
			[Cpp2IlInjected.Token(Token = "0x6000CD3")]
			[Cpp2IlInjected.Address(RVA = "0xD12BC0", Offset = "0xD115C0", VA = "0x180D12BC0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000CD4")]
			[Cpp2IlInjected.Address(RVA = "0xD11520", Offset = "0xD0FF20", VA = "0x180D11520")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700054A")]
		public string Type
		{
			[Cpp2IlInjected.Token(Token = "0x6000CD5")]
			[Cpp2IlInjected.Address(RVA = "0xD11B00", Offset = "0xD10500", VA = "0x180D11B00")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000CD6")]
			[Cpp2IlInjected.Address(RVA = "0xD11530", Offset = "0xD0FF30", VA = "0x180D11530")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700054B")]
		public List<CircuitObjectDefinition>? Children
		{
			[Cpp2IlInjected.Token(Token = "0x6000CD7")]
			[Cpp2IlInjected.Address(RVA = "0xD11A20", Offset = "0xD10420", VA = "0x180D11A20")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000CD8")]
			[Cpp2IlInjected.Address(RVA = "0xD17350", Offset = "0xD15D50", VA = "0x180D17350")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700054C")]
		public CircuitObjectDefinitionSpawnableProperties? SpawnableProperties
		{
			[Cpp2IlInjected.Token(Token = "0x6000CD9")]
			[Cpp2IlInjected.Address(RVA = "0xD12280", Offset = "0xD10C80", VA = "0x180D12280")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000CDA")]
			[Cpp2IlInjected.Address(RVA = "0xD11B50", Offset = "0xD10550", VA = "0x180D11B50")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000CDB")]
		[Cpp2IlInjected.Address(RVA = "0xD16C40", Offset = "0xD15640", VA = "0x180D16C40")]
		public CircuitObjectDefinition()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20001C7")]
	[Utf8JsonSerializable]
	public class CircuitObjectEvent
	{
		[Cpp2IlInjected.Token(Token = "0x1700054D")]
		public string BaseEventGuid
		{
			[Cpp2IlInjected.Token(Token = "0x6000CDC")]
			[Cpp2IlInjected.Address(RVA = "0xD117B0", Offset = "0xD101B0", VA = "0x180D117B0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000CDD")]
			[Cpp2IlInjected.Address(RVA = "0xD117C0", Offset = "0xD101C0", VA = "0x180D117C0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700054E")]
		public string Path
		{
			[Cpp2IlInjected.Token(Token = "0x6000CDE")]
			[Cpp2IlInjected.Address(RVA = "0xD11B30", Offset = "0xD10530", VA = "0x180D11B30")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000CDF")]
			[Cpp2IlInjected.Address(RVA = "0xD12270", Offset = "0xD10C70", VA = "0x180D12270")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000CE0")]
		[Cpp2IlInjected.Address(RVA = "0xD16C40", Offset = "0xD15640", VA = "0x180D16C40")]
		public CircuitObjectEvent()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20001C8")]
	[Utf8JsonSerializable]
	public class GeneratedCircuitBoardDTO
	{
		[Cpp2IlInjected.Token(Token = "0x1700054F")]
		public string Id
		{
			[Cpp2IlInjected.Token(Token = "0x6000CE1")]
			[Cpp2IlInjected.Address(RVA = "0xD117B0", Offset = "0xD101B0", VA = "0x180D117B0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000CE2")]
			[Cpp2IlInjected.Address(RVA = "0xD117C0", Offset = "0xD101C0", VA = "0x180D117C0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000550")]
		public CircuitBoard CircuitBoard
		{
			[Cpp2IlInjected.Token(Token = "0x6000CE3")]
			[Cpp2IlInjected.Address(RVA = "0xD11B30", Offset = "0xD10530", VA = "0x180D11B30")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000CE4")]
			[Cpp2IlInjected.Address(RVA = "0xD12270", Offset = "0xD10C70", VA = "0x180D12270")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000551")]
		public CircuitObjectDefinition? ObjectDefinition
		{
			[Cpp2IlInjected.Token(Token = "0x6000CE5")]
			[Cpp2IlInjected.Address(RVA = "0xD12BC0", Offset = "0xD115C0", VA = "0x180D12BC0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000CE6")]
			[Cpp2IlInjected.Address(RVA = "0xD11520", Offset = "0xD0FF20", VA = "0x180D11520")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000552")]
		public List<CircuitObjectDefinition>? SceneObjectDefinitions
		{
			[Cpp2IlInjected.Token(Token = "0x6000CE7")]
			[Cpp2IlInjected.Address(RVA = "0xD11B00", Offset = "0xD10500", VA = "0x180D11B00")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000CE8")]
			[Cpp2IlInjected.Address(RVA = "0xD11530", Offset = "0xD0FF30", VA = "0x180D11530")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000553")]
		public IReadOnlyList<Chip> EventDefinitions
		{
			[Cpp2IlInjected.Token(Token = "0x6000CE9")]
			[Cpp2IlInjected.Address(RVA = "0xD11A20", Offset = "0xD10420", VA = "0x180D11A20")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000CEA")]
			[Cpp2IlInjected.Address(RVA = "0xD17350", Offset = "0xD15D50", VA = "0x180D17350")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000554")]
		public IReadOnlyList<CircuitObjectEvent> ObjectEvents
		{
			[Cpp2IlInjected.Token(Token = "0x6000CEB")]
			[Cpp2IlInjected.Address(RVA = "0xD12280", Offset = "0xD10C80", VA = "0x180D12280")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000CEC")]
			[Cpp2IlInjected.Address(RVA = "0xD11B50", Offset = "0xD10550", VA = "0x180D11B50")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000555")]
		public string? Code
		{
			[Cpp2IlInjected.Token(Token = "0x6000CED")]
			[Cpp2IlInjected.Address(RVA = "0xD11A30", Offset = "0xD10430", VA = "0x180D11A30")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000CEE")]
			[Cpp2IlInjected.Address(RVA = "0xD12260", Offset = "0xD10C60", VA = "0x180D12260")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000CEF")]
		[Cpp2IlInjected.Address(RVA = "0x8DCF390", Offset = "0x8DCDD90", VA = "0x188DCF390")]
		public GeneratedCircuitBoardDTO()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20001C9")]
	[Utf8JsonSerializable]
	public class GenerateCircuitsResponseDTO : QPSFFVWODNU
	{
		[Cpp2IlInjected.Token(Token = "0x17000556")]
		public RecNetResultObject<GeneratedCircuitBoardDTO> Result
		{
			[Cpp2IlInjected.Token(Token = "0x6000CF0")]
			[Cpp2IlInjected.Address(RVA = "0xD117B0", Offset = "0xD101B0", VA = "0x180D117B0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000CF1")]
			[Cpp2IlInjected.Address(RVA = "0xD117C0", Offset = "0xD101C0", VA = "0x180D117C0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000557")]
		public decimal CodeGenerationCost
		{
			[Cpp2IlInjected.Token(Token = "0x6000CF2")]
			[Cpp2IlInjected.Address(RVA = "0xDA5E80", Offset = "0xDA4880", VA = "0x180DA5E80")]
			[CompilerGenerated]
			get
			{
				return default(decimal);
			}
			[Cpp2IlInjected.Token(Token = "0x6000CF3")]
			[Cpp2IlInjected.Address(RVA = "0xF82330", Offset = "0xF80D30", VA = "0x180F82330")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000CF4")]
		[Cpp2IlInjected.Address(RVA = "0x8DCF240", Offset = "0x8DCDC40", VA = "0x188DCF240", Slot = "4")]
		public Task NLARVXFWNGH()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000CF5")]
		[Cpp2IlInjected.Address(RVA = "0xD16C40", Offset = "0xD15640", VA = "0x180D16C40")]
		public GenerateCircuitsResponseDTO()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20001CA")]
	public enum AIBalanceStatus
	{
		[Cpp2IlInjected.Token(Token = "0x4000895")]
		Empty,
		[Cpp2IlInjected.Token(Token = "0x4000896")]
		Low,
		[Cpp2IlInjected.Token(Token = "0x4000897")]
		Good
	}
	[Cpp2IlInjected.Token(Token = "0x20001CB")]
	[Utf8JsonSerializable]
	public class MakerAITimeBalanceStatusUpdatePushNotification
	{
		[Cpp2IlInjected.Token(Token = "0x17000558")]
		public AIBalanceStatus TimeBalanceStatus
		{
			[Cpp2IlInjected.Token(Token = "0x6000CF6")]
			[Cpp2IlInjected.Address(RVA = "0xD0F110", Offset = "0xD0DB10", VA = "0x180D0F110")]
			[CompilerGenerated]
			get
			{
				return default(AIBalanceStatus);
			}
			[Cpp2IlInjected.Token(Token = "0x6000CF7")]
			[Cpp2IlInjected.Address(RVA = "0xD12F30", Offset = "0xD11930", VA = "0x180D12F30")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000559")]
		public DateTime TimeExpiresAt
		{
			[Cpp2IlInjected.Token(Token = "0x6000CF8")]
			[Cpp2IlInjected.Address(RVA = "0xD11B30", Offset = "0xD10530", VA = "0x180D11B30")]
			[CompilerGenerated]
			get
			{
				return default(DateTime);
			}
			[Cpp2IlInjected.Token(Token = "0x6000CF9")]
			[Cpp2IlInjected.Address(RVA = "0xE07390", Offset = "0xE05D90", VA = "0x180E07390")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000CFA")]
		[Cpp2IlInjected.Address(RVA = "0xD16C40", Offset = "0xD15640", VA = "0x180D16C40")]
		public MakerAITimeBalanceStatusUpdatePushNotification()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20001CC")]
	[Utf8JsonSerializable]
	public class MakerAIUsageBalanceStatusUpdatePushNotification
	{
		[Cpp2IlInjected.Token(Token = "0x1700055A")]
		public AIBalanceStatus UsageBalanceStatus
		{
			[Cpp2IlInjected.Token(Token = "0x6000CFB")]
			[Cpp2IlInjected.Address(RVA = "0xD0F110", Offset = "0xD0DB10", VA = "0x180D0F110")]
			[CompilerGenerated]
			get
			{
				return default(AIBalanceStatus);
			}
			[Cpp2IlInjected.Token(Token = "0x6000CFC")]
			[Cpp2IlInjected.Address(RVA = "0xD12F30", Offset = "0xD11930", VA = "0x180D12F30")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700055B")]
		public float UsagePercent
		{
			[Cpp2IlInjected.Token(Token = "0x6000CFD")]
			[Cpp2IlInjected.Address(RVA = "0xED9DB0", Offset = "0xED87B0", VA = "0x180ED9DB0")]
			[CompilerGenerated]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x6000CFE")]
			[Cpp2IlInjected.Address(RVA = "0xED94D0", Offset = "0xED7ED0", VA = "0x180ED94D0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000CFF")]
		[Cpp2IlInjected.Address(RVA = "0xD16C40", Offset = "0xD15640", VA = "0x180D16C40")]
		public MakerAIUsageBalanceStatusUpdatePushNotification()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20001CD")]
	[Utf8JsonSerializable]
	public class MakerAIBalancesDTO
	{
		[Cpp2IlInjected.Token(Token = "0x1700055C")]
		public AIBalanceStatus TimeBalanceStatus
		{
			[Cpp2IlInjected.Token(Token = "0x6000D00")]
			[Cpp2IlInjected.Address(RVA = "0xD0F110", Offset = "0xD0DB10", VA = "0x180D0F110")]
			[CompilerGenerated]
			get
			{
				return default(AIBalanceStatus);
			}
			[Cpp2IlInjected.Token(Token = "0x6000D01")]
			[Cpp2IlInjected.Address(RVA = "0xD12F30", Offset = "0xD11930", VA = "0x180D12F30")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700055D")]
		public DateTime TimeExpiresAt
		{
			[Cpp2IlInjected.Token(Token = "0x6000D02")]
			[Cpp2IlInjected.Address(RVA = "0xD11B30", Offset = "0xD10530", VA = "0x180D11B30")]
			[CompilerGenerated]
			get
			{
				return default(DateTime);
			}
			[Cpp2IlInjected.Token(Token = "0x6000D03")]
			[Cpp2IlInjected.Address(RVA = "0xE07390", Offset = "0xE05D90", VA = "0x180E07390")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700055E")]
		public AIBalanceStatus UsageBalanceStatus
		{
			[Cpp2IlInjected.Token(Token = "0x6000D04")]
			[Cpp2IlInjected.Address(RVA = "0xD215F0", Offset = "0xD1FFF0", VA = "0x180D215F0")]
			[CompilerGenerated]
			get
			{
				return default(AIBalanceStatus);
			}
			[Cpp2IlInjected.Token(Token = "0x6000D05")]
			[Cpp2IlInjected.Address(RVA = "0xD682F0", Offset = "0xD66CF0", VA = "0x180D682F0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700055F")]
		public float UsagePercent
		{
			[Cpp2IlInjected.Token(Token = "0x6000D06")]
			[Cpp2IlInjected.Address(RVA = "0xD67450", Offset = "0xD65E50", VA = "0x180D67450")]
			[CompilerGenerated]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x6000D07")]
			[Cpp2IlInjected.Address(RVA = "0xD67440", Offset = "0xD65E40", VA = "0x180D67440")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000560")]
		public AIBalanceStatus RRPlusUsageBalanceStatus
		{
			[Cpp2IlInjected.Token(Token = "0x6000D08")]
			[Cpp2IlInjected.Address(RVA = "0xD12BE0", Offset = "0xD115E0", VA = "0x180D12BE0")]
			[CompilerGenerated]
			get
			{
				return default(AIBalanceStatus);
			}
			[Cpp2IlInjected.Token(Token = "0x6000D09")]
			[Cpp2IlInjected.Address(RVA = "0xD12C40", Offset = "0xD11640", VA = "0x180D12C40")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000561")]
		public float RRPlusUsagePercent
		{
			[Cpp2IlInjected.Token(Token = "0x6000D0A")]
			[Cpp2IlInjected.Address(RVA = "0xE9AEF0", Offset = "0xE998F0", VA = "0x180E9AEF0")]
			[CompilerGenerated]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x6000D0B")]
			[Cpp2IlInjected.Address(RVA = "0xF35800", Offset = "0xF34200", VA = "0x180F35800")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000D0C")]
		[Cpp2IlInjected.Address(RVA = "0xD16C40", Offset = "0xD15640", VA = "0x180D16C40")]
		public MakerAIBalancesDTO()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20001CE")]
	[Utf8JsonSerializable]
	public class MakerAIFreeTrialConfigDTO
	{
		[Cpp2IlInjected.Token(Token = "0x17000562")]
		public TimeSpan Cooldown
		{
			[Cpp2IlInjected.Token(Token = "0x6000D0D")]
			[Cpp2IlInjected.Address(RVA = "0xD117B0", Offset = "0xD101B0", VA = "0x180D117B0")]
			[CompilerGenerated]
			get
			{
				return default(TimeSpan);
			}
			[Cpp2IlInjected.Token(Token = "0x6000D0E")]
			[Cpp2IlInjected.Address(RVA = "0xED90B0", Offset = "0xED7AB0", VA = "0x180ED90B0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000563")]
		public TimeSpan Duration
		{
			[Cpp2IlInjected.Token(Token = "0x6000D0F")]
			[Cpp2IlInjected.Address(RVA = "0xD11B30", Offset = "0xD10530", VA = "0x180D11B30")]
			[CompilerGenerated]
			get
			{
				return default(TimeSpan);
			}
			[Cpp2IlInjected.Token(Token = "0x6000D10")]
			[Cpp2IlInjected.Address(RVA = "0xE07390", Offset = "0xE05D90", VA = "0x180E07390")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000D11")]
		[Cpp2IlInjected.Address(RVA = "0xD16C40", Offset = "0xD15640", VA = "0x180D16C40")]
		public MakerAIFreeTrialConfigDTO()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20001CF")]
	[Utf8JsonSerializable]
	public class SearchRoomsResponseDTO
	{
		[Cpp2IlInjected.Token(Token = "0x17000564")]
		public List<string> Value
		{
			[Cpp2IlInjected.Token(Token = "0x6000D12")]
			[Cpp2IlInjected.Address(RVA = "0xD117B0", Offset = "0xD101B0", VA = "0x180D117B0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000D13")]
			[Cpp2IlInjected.Address(RVA = "0xD117C0", Offset = "0xD101C0", VA = "0x180D117C0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000D14")]
		[Cpp2IlInjected.Address(RVA = "0xD16C40", Offset = "0xD15640", VA = "0x180D16C40")]
		public SearchRoomsResponseDTO()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20001D0")]
	[Utf8JsonSerializable]
	public class GenerateSpeechRequestDTO
	{
		[Cpp2IlInjected.Token(Token = "0x17000565")]
		public string? Model
		{
			[Cpp2IlInjected.Token(Token = "0x6000D15")]
			[Cpp2IlInjected.Address(RVA = "0xD117B0", Offset = "0xD101B0", VA = "0x180D117B0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000D16")]
			[Cpp2IlInjected.Address(RVA = "0xD117C0", Offset = "0xD101C0", VA = "0x180D117C0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000566")]
		public string Input
		{
			[Cpp2IlInjected.Token(Token = "0x6000D17")]
			[Cpp2IlInjected.Address(RVA = "0xD11B30", Offset = "0xD10530", VA = "0x180D11B30")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000D18")]
			[Cpp2IlInjected.Address(RVA = "0xD12270", Offset = "0xD10C70", VA = "0x180D12270")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000567")]
		public string Voice
		{
			[Cpp2IlInjected.Token(Token = "0x6000D19")]
			[Cpp2IlInjected.Address(RVA = "0xD12BC0", Offset = "0xD115C0", VA = "0x180D12BC0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000D1A")]
			[Cpp2IlInjected.Address(RVA = "0xD11520", Offset = "0xD0FF20", VA = "0x180D11520")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000568")]
		public string ResponseFormat
		{
			[Cpp2IlInjected.Token(Token = "0x6000D1B")]
			[Cpp2IlInjected.Address(RVA = "0xD11B00", Offset = "0xD10500", VA = "0x180D11B00")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000D1C")]
			[Cpp2IlInjected.Address(RVA = "0xD11530", Offset = "0xD0FF30", VA = "0x180D11530")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000569")]
		public string? Instructions
		{
			[Cpp2IlInjected.Token(Token = "0x6000D1D")]
			[Cpp2IlInjected.Address(RVA = "0xD11A20", Offset = "0xD10420", VA = "0x180D11A20")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000D1E")]
			[Cpp2IlInjected.Address(RVA = "0xD17350", Offset = "0xD15D50", VA = "0x180D17350")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000D1F")]
		[Cpp2IlInjected.Address(RVA = "0x8DCF340", Offset = "0x8DCDD40", VA = "0x188DCF340")]
		public GenerateSpeechRequestDTO()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20001D1")]
	[Utf8JsonSerializable]
	public class GameAIRoomSpendSummaryDTO
	{
		[Cpp2IlInjected.Token(Token = "0x1700056A")]
		public RecNetResult GameAIStatus
		{
			[Cpp2IlInjected.Token(Token = "0x6000D20")]
			[Cpp2IlInjected.Address(RVA = "0xD117B0", Offset = "0xD101B0", VA = "0x180D117B0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000D21")]
			[Cpp2IlInjected.Address(RVA = "0xD117C0", Offset = "0xD101C0", VA = "0x180D117C0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700056B")]
		public AIBalanceStatus PromoBalanceStatus
		{
			[Cpp2IlInjected.Token(Token = "0x6000D22")]
			[Cpp2IlInjected.Address(RVA = "0xD17340", Offset = "0xD15D40", VA = "0x180D17340")]
			[CompilerGenerated]
			get
			{
				return default(AIBalanceStatus);
			}
			[Cpp2IlInjected.Token(Token = "0x6000D23")]
			[Cpp2IlInjected.Address(RVA = "0xD17360", Offset = "0xD15D60", VA = "0x180D17360")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700056C")]
		public long? AmountSpent
		{
			[Cpp2IlInjected.Token(Token = "0x6000D24")]
			[Cpp2IlInjected.Address(RVA = "0xEF2E20", Offset = "0xEF1820", VA = "0x180EF2E20")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000D25")]
			[Cpp2IlInjected.Address(RVA = "0xFBBC10", Offset = "0xFBA610", VA = "0x180FBBC10")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700056D")]
		public DateTime? AmountSpentSince
		{
			[Cpp2IlInjected.Token(Token = "0x6000D26")]
			[Cpp2IlInjected.Address(RVA = "0xF92C90", Offset = "0xF91690", VA = "0x180F92C90")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000D27")]
			[Cpp2IlInjected.Address(RVA = "0xF931D0", Offset = "0xF91BD0", VA = "0x180F931D0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700056E")]
		public long? AvailableBalance
		{
			[Cpp2IlInjected.Token(Token = "0x6000D28")]
			[Cpp2IlInjected.Address(RVA = "0x10ABB70", Offset = "0x10AA570", VA = "0x1810ABB70")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000D29")]
			[Cpp2IlInjected.Address(RVA = "0x10ABCC0", Offset = "0x10AA6C0", VA = "0x1810ABCC0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000D2A")]
		[Cpp2IlInjected.Address(RVA = "0xD16C40", Offset = "0xD15640", VA = "0x180D16C40")]
		public GameAIRoomSpendSummaryDTO()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20001D2")]
	[Utf8JsonSerializable]
	public class GameAIPromoBalanceDTO
	{
		[Cpp2IlInjected.Token(Token = "0x1700056F")]
		public int AvailableDevCreditPacks
		{
			[Cpp2IlInjected.Token(Token = "0x6000D2B")]
			[Cpp2IlInjected.Address(RVA = "0xD0F110", Offset = "0xD0DB10", VA = "0x180D0F110")]
			[CompilerGenerated]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x6000D2C")]
			[Cpp2IlInjected.Address(RVA = "0xD12F30", Offset = "0xD11930", VA = "0x180D12F30")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000570")]
		public DateTime? NextDevCreditPackGrantDate
		{
			[Cpp2IlInjected.Token(Token = "0x6000D2D")]
			[Cpp2IlInjected.Address(RVA = "0xDA5E80", Offset = "0xDA4880", VA = "0x180DA5E80")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000D2E")]
			[Cpp2IlInjected.Address(RVA = "0xF82330", Offset = "0xF80D30", VA = "0x180F82330")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000D2F")]
		[Cpp2IlInjected.Address(RVA = "0xD16C40", Offset = "0xD15640", VA = "0x180D16C40")]
		public GameAIPromoBalanceDTO()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20001D3")]
	[Utf8JsonSerializable]
	public class ConversationDTO
	{
		[Cpp2IlInjected.Token(Token = "0x17000571")]
		public List<ConversationMessageDTO> ConversationItems
		{
			[Cpp2IlInjected.Token(Token = "0x6000D30")]
			[Cpp2IlInjected.Address(RVA = "0xD117B0", Offset = "0xD101B0", VA = "0x180D117B0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000D31")]
			[Cpp2IlInjected.Address(RVA = "0xD117C0", Offset = "0xD101C0", VA = "0x180D117C0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000D32")]
		[Cpp2IlInjected.Address(RVA = "0xD16C40", Offset = "0xD15640", VA = "0x180D16C40")]
		public ConversationDTO()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20001D4")]
	[Utf8JsonSerializable]
	public class ConversationMessageDTO
	{
		[Cpp2IlInjected.Token(Token = "0x17000572")]
		public string Conversation
		{
			[Cpp2IlInjected.Token(Token = "0x6000D33")]
			[Cpp2IlInjected.Address(RVA = "0xD117B0", Offset = "0xD101B0", VA = "0x180D117B0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000D34")]
			[Cpp2IlInjected.Address(RVA = "0xD117C0", Offset = "0xD101C0", VA = "0x180D117C0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000D35")]
		[Cpp2IlInjected.Address(RVA = "0x14F8CA0", Offset = "0x14F76A0", VA = "0x1814F8CA0")]
		public ConversationMessageDTO()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20001D5")]
	[Utf8JsonSerializable]
	public class RoomieUserFactsDTO
	{
		[Cpp2IlInjected.Token(Token = "0x17000573")]
		public List<UserFactDTO> UserFacts
		{
			[Cpp2IlInjected.Token(Token = "0x6000D36")]
			[Cpp2IlInjected.Address(RVA = "0xD117B0", Offset = "0xD101B0", VA = "0x180D117B0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000D37")]
			[Cpp2IlInjected.Address(RVA = "0xD117C0", Offset = "0xD101C0", VA = "0x180D117C0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000574")]
		public string UserContext
		{
			[Cpp2IlInjected.Token(Token = "0x6000D38")]
			[Cpp2IlInjected.Address(RVA = "0xD11B30", Offset = "0xD10530", VA = "0x180D11B30")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000D39")]
			[Cpp2IlInjected.Address(RVA = "0xD12270", Offset = "0xD10C70", VA = "0x180D12270")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000D3A")]
		[Cpp2IlInjected.Address(RVA = "0x260C300", Offset = "0x260AD00", VA = "0x18260C300")]
		public RoomieUserFactsDTO()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20001D6")]
	[Utf8JsonSerializable]
	public class UserFactDTO
	{
		[Cpp2IlInjected.Token(Token = "0x17000575")]
		public string Id
		{
			[Cpp2IlInjected.Token(Token = "0x6000D3C")]
			[Cpp2IlInjected.Address(RVA = "0xD117B0", Offset = "0xD101B0", VA = "0x180D117B0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000D3D")]
			[Cpp2IlInjected.Address(RVA = "0xD117C0", Offset = "0xD101C0", VA = "0x180D117C0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000576")]
		public string Predicate
		{
			[Cpp2IlInjected.Token(Token = "0x6000D3E")]
			[Cpp2IlInjected.Address(RVA = "0xD11B30", Offset = "0xD10530", VA = "0x180D11B30")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000D3F")]
			[Cpp2IlInjected.Address(RVA = "0xD12270", Offset = "0xD10C70", VA = "0x180D12270")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000577")]
		public string Object
		{
			[Cpp2IlInjected.Token(Token = "0x6000D40")]
			[Cpp2IlInjected.Address(RVA = "0xD12BC0", Offset = "0xD115C0", VA = "0x180D12BC0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000D41")]
			[Cpp2IlInjected.Address(RVA = "0xD11520", Offset = "0xD0FF20", VA = "0x180D11520")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000578")]
		public string Emotion
		{
			[Cpp2IlInjected.Token(Token = "0x6000D42")]
			[Cpp2IlInjected.Address(RVA = "0xD11B00", Offset = "0xD10500", VA = "0x180D11B00")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000D43")]
			[Cpp2IlInjected.Address(RVA = "0xD11530", Offset = "0xD0FF30", VA = "0x180D11530")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000579")]
		public DateTime CreatedAt
		{
			[Cpp2IlInjected.Token(Token = "0x6000D44")]
			[Cpp2IlInjected.Address(RVA = "0xD11A20", Offset = "0xD10420", VA = "0x180D11A20")]
			[CompilerGenerated]
			get
			{
				return default(DateTime);
			}
			[Cpp2IlInjected.Token(Token = "0x6000D45")]
			[Cpp2IlInjected.Address(RVA = "0xD118E0", Offset = "0xD102E0", VA = "0x180D118E0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000D3B")]
		[Cpp2IlInjected.Address(RVA = "0xD118A0", Offset = "0xD102A0", VA = "0x180D118A0")]
		public UserFactDTO(string id)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20001D7")]
	public enum ConversationMessageRole
	{
		[Cpp2IlInjected.Token(Token = "0x40008BB")]
		User,
		[Cpp2IlInjected.Token(Token = "0x40008BC")]
		System,
		[Cpp2IlInjected.Token(Token = "0x40008BD")]
		AI
	}
	[Cpp2IlInjected.Token(Token = "0x20001D8")]
	[Utf8JsonSerializable]
	public class AddMessageToConversationRequestDTO
	{
		[Cpp2IlInjected.Token(Token = "0x1700057A")]
		public string ConversationId
		{
			[Cpp2IlInjected.Token(Token = "0x6000D46")]
			[Cpp2IlInjected.Address(RVA = "0xD117B0", Offset = "0xD101B0", VA = "0x180D117B0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000D47")]
			[Cpp2IlInjected.Address(RVA = "0xD117C0", Offset = "0xD101C0", VA = "0x180D117C0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700057B")]
		public ConversationMessageRole Role
		{
			[Cpp2IlInjected.Token(Token = "0x6000D48")]
			[Cpp2IlInjected.Address(RVA = "0xD17340", Offset = "0xD15D40", VA = "0x180D17340")]
			[CompilerGenerated]
			get
			{
				return default(ConversationMessageRole);
			}
			[Cpp2IlInjected.Token(Token = "0x6000D49")]
			[Cpp2IlInjected.Address(RVA = "0xD17360", Offset = "0xD15D60", VA = "0x180D17360")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700057C")]
		public string Text
		{
			[Cpp2IlInjected.Token(Token = "0x6000D4A")]
			[Cpp2IlInjected.Address(RVA = "0xD12BC0", Offset = "0xD115C0", VA = "0x180D12BC0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000D4B")]
			[Cpp2IlInjected.Address(RVA = "0xD11520", Offset = "0xD0FF20", VA = "0x180D11520")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000D4C")]
		[Cpp2IlInjected.Address(RVA = "0xD16C40", Offset = "0xD15640", VA = "0x180D16C40")]
		public AddMessageToConversationRequestDTO()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20001D9")]
	[Utf8JsonSerializable]
	public class AddToolCallResponseToConversationRequestDTO
	{
		[Cpp2IlInjected.Token(Token = "0x1700057D")]
		public string ConversationId
		{
			[Cpp2IlInjected.Token(Token = "0x6000D4D")]
			[Cpp2IlInjected.Address(RVA = "0xD117B0", Offset = "0xD101B0", VA = "0x180D117B0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000D4E")]
			[Cpp2IlInjected.Address(RVA = "0xD117C0", Offset = "0xD101C0", VA = "0x180D117C0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700057E")]
		public string ToolCallId
		{
			[Cpp2IlInjected.Token(Token = "0x6000D4F")]
			[Cpp2IlInjected.Address(RVA = "0xD11B30", Offset = "0xD10530", VA = "0x180D11B30")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000D50")]
			[Cpp2IlInjected.Address(RVA = "0xD12270", Offset = "0xD10C70", VA = "0x180D12270")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700057F")]
		public string Response
		{
			[Cpp2IlInjected.Token(Token = "0x6000D51")]
			[Cpp2IlInjected.Address(RVA = "0xD12BC0", Offset = "0xD115C0", VA = "0x180D12BC0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000D52")]
			[Cpp2IlInjected.Address(RVA = "0xD11520", Offset = "0xD0FF20", VA = "0x180D11520")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000D53")]
		[Cpp2IlInjected.Address(RVA = "0xD16C40", Offset = "0xD15640", VA = "0x180D16C40")]
		public AddToolCallResponseToConversationRequestDTO()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20001DA")]
	public enum ToolChoice
	{
		[Cpp2IlInjected.Token(Token = "0x40008C5")]
		Auto,
		[Cpp2IlInjected.Token(Token = "0x40008C6")]
		None,
		[Cpp2IlInjected.Token(Token = "0x40008C7")]
		Required,
		[Cpp2IlInjected.Token(Token = "0x40008C8")]
		Forced
	}
	[Cpp2IlInjected.Token(Token = "0x20001DB")]
	[Utf8JsonSerializable]
	public class NamedSchemaDTO
	{
		[Cpp2IlInjected.Token(Token = "0x17000580")]
		public string Name
		{
			[Cpp2IlInjected.Token(Token = "0x6000D54")]
			[Cpp2IlInjected.Address(RVA = "0xD117B0", Offset = "0xD101B0", VA = "0x180D117B0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000D55")]
			[Cpp2IlInjected.Address(RVA = "0xD117C0", Offset = "0xD101C0", VA = "0x180D117C0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000581")]
		public string Schema
		{
			[Cpp2IlInjected.Token(Token = "0x6000D56")]
			[Cpp2IlInjected.Address(RVA = "0xD11B30", Offset = "0xD10530", VA = "0x180D11B30")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000D57")]
			[Cpp2IlInjected.Address(RVA = "0xD12270", Offset = "0xD10C70", VA = "0x180D12270")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000582")]
		public string? Description
		{
			[Cpp2IlInjected.Token(Token = "0x6000D58")]
			[Cpp2IlInjected.Address(RVA = "0xD12BC0", Offset = "0xD115C0", VA = "0x180D12BC0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000D59")]
			[Cpp2IlInjected.Address(RVA = "0xD11520", Offset = "0xD0FF20", VA = "0x180D11520")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000D5A")]
		[Cpp2IlInjected.Address(RVA = "0xD16C40", Offset = "0xD15640", VA = "0x180D16C40")]
		public NamedSchemaDTO()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20001DC")]
	[Utf8JsonSerializable]
	public class GenerateConversationResponseRequestDTO
	{
		[Cpp2IlInjected.Token(Token = "0x17000583")]
		public string ConversationId
		{
			[Cpp2IlInjected.Token(Token = "0x6000D5B")]
			[Cpp2IlInjected.Address(RVA = "0xD117B0", Offset = "0xD101B0", VA = "0x180D117B0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000D5C")]
			[Cpp2IlInjected.Address(RVA = "0xD117C0", Offset = "0xD101C0", VA = "0x180D117C0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000584")]
		public string? Model
		{
			[Cpp2IlInjected.Token(Token = "0x6000D5D")]
			[Cpp2IlInjected.Address(RVA = "0xD11B30", Offset = "0xD10530", VA = "0x180D11B30")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000D5E")]
			[Cpp2IlInjected.Address(RVA = "0xD12270", Offset = "0xD10C70", VA = "0x180D12270")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000585")]
		public float? Temperature
		{
			[Cpp2IlInjected.Token(Token = "0x6000D5F")]
			[Cpp2IlInjected.Address(RVA = "0xD12BC0", Offset = "0xD115C0", VA = "0x180D12BC0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000D60")]
			[Cpp2IlInjected.Address(RVA = "0xE3F130", Offset = "0xE3DB30", VA = "0x180E3F130")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000586")]
		public NamedSchemaDTO? ResponseFormat
		{
			[Cpp2IlInjected.Token(Token = "0x6000D61")]
			[Cpp2IlInjected.Address(RVA = "0xD11B00", Offset = "0xD10500", VA = "0x180D11B00")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000D62")]
			[Cpp2IlInjected.Address(RVA = "0xD11530", Offset = "0xD0FF30", VA = "0x180D11530")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000587")]
		public List<NamedSchemaDTO> Tools
		{
			[Cpp2IlInjected.Token(Token = "0x6000D63")]
			[Cpp2IlInjected.Address(RVA = "0xD11A20", Offset = "0xD10420", VA = "0x180D11A20")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000D64")]
			[Cpp2IlInjected.Address(RVA = "0xD17350", Offset = "0xD15D50", VA = "0x180D17350")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000588")]
		public ToolChoice ToolChoice
		{
			[Cpp2IlInjected.Token(Token = "0x6000D65")]
			[Cpp2IlInjected.Address(RVA = "0xD40260", Offset = "0xD3EC60", VA = "0x180D40260")]
			[CompilerGenerated]
			get
			{
				return default(ToolChoice);
			}
			[Cpp2IlInjected.Token(Token = "0x6000D66")]
			[Cpp2IlInjected.Address(RVA = "0xE27B10", Offset = "0xE26510", VA = "0x180E27B10")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000589")]
		public string? ForceToolName
		{
			[Cpp2IlInjected.Token(Token = "0x6000D67")]
			[Cpp2IlInjected.Address(RVA = "0xD11A30", Offset = "0xD10430", VA = "0x180D11A30")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000D68")]
			[Cpp2IlInjected.Address(RVA = "0xD12260", Offset = "0xD10C60", VA = "0x180D12260")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000D69")]
		[Cpp2IlInjected.Address(RVA = "0x8DCF290", Offset = "0x8DCDC90", VA = "0x188DCF290")]
		public GenerateConversationResponseRequestDTO()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20001DD")]
	[Utf8JsonSerializable]
	public class ToolCallDTO
	{
		[Cpp2IlInjected.Token(Token = "0x1700058A")]
		public string Id
		{
			[Cpp2IlInjected.Token(Token = "0x6000D6A")]
			[Cpp2IlInjected.Address(RVA = "0xD117B0", Offset = "0xD101B0", VA = "0x180D117B0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000D6B")]
			[Cpp2IlInjected.Address(RVA = "0xD117C0", Offset = "0xD101C0", VA = "0x180D117C0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700058B")]
		public string Name
		{
			[Cpp2IlInjected.Token(Token = "0x6000D6C")]
			[Cpp2IlInjected.Address(RVA = "0xD11B30", Offset = "0xD10530", VA = "0x180D11B30")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000D6D")]
			[Cpp2IlInjected.Address(RVA = "0xD12270", Offset = "0xD10C70", VA = "0x180D12270")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700058C")]
		public string Arguments
		{
			[Cpp2IlInjected.Token(Token = "0x6000D6E")]
			[Cpp2IlInjected.Address(RVA = "0xD12BC0", Offset = "0xD115C0", VA = "0x180D12BC0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000D6F")]
			[Cpp2IlInjected.Address(RVA = "0xD11520", Offset = "0xD0FF20", VA = "0x180D11520")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000D70")]
		[Cpp2IlInjected.Address(RVA = "0xD16C40", Offset = "0xD15640", VA = "0x180D16C40")]
		public ToolCallDTO()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20001DE")]
	[Utf8JsonSerializable]
	public class GenerateConversationResponseResponseDTO
	{
		[Cpp2IlInjected.Token(Token = "0x1700058D")]
		public List<string> TextItems
		{
			[Cpp2IlInjected.Token(Token = "0x6000D71")]
			[Cpp2IlInjected.Address(RVA = "0xD117B0", Offset = "0xD101B0", VA = "0x180D117B0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000D72")]
			[Cpp2IlInjected.Address(RVA = "0xD117C0", Offset = "0xD101C0", VA = "0x180D117C0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700058E")]
		public List<ToolCallDTO>? ToolCalls
		{
			[Cpp2IlInjected.Token(Token = "0x6000D73")]
			[Cpp2IlInjected.Address(RVA = "0xD11B30", Offset = "0xD10530", VA = "0x180D11B30")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000D74")]
			[Cpp2IlInjected.Address(RVA = "0xD12270", Offset = "0xD10C70", VA = "0x180D12270")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000D75")]
		[Cpp2IlInjected.Address(RVA = "0xD16C40", Offset = "0xD15640", VA = "0x180D16C40")]
		public GenerateConversationResponseResponseDTO()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20001DF")]
	[Utf8JsonSerializable]
	public class GenerateAudioOrSongResponseDTO
	{
		[Cpp2IlInjected.Token(Token = "0x1700058F")]
		public string Filename
		{
			[Cpp2IlInjected.Token(Token = "0x6000D76")]
			[Cpp2IlInjected.Address(RVA = "0xD117B0", Offset = "0xD101B0", VA = "0x180D117B0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000D77")]
			[Cpp2IlInjected.Address(RVA = "0xD117C0", Offset = "0xD101C0", VA = "0x180D117C0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000D78")]
		[Cpp2IlInjected.Address(RVA = "0xD16C40", Offset = "0xD15640", VA = "0x180D16C40")]
		public GenerateAudioOrSongResponseDTO()
		{
		}
	}
}
namespace Cpp2IlInjected
{
	internal class AddressAttribute : Attribute
	{
		public string RVA;

		public string Offset;

		public string VA;

		public string Slot;
	}
	internal class FieldOffsetAttribute : Attribute
	{
		public string Offset;
	}
	internal class AttributeAttribute : Attribute
	{
		public string Name;

		public string RVA;

		public string Offset;
	}
	internal class MetadataOffsetAttribute : Attribute
	{
		public string Offset;
	}
	internal class TokenAttribute : Attribute
	{
		public string Token;
	}
	internal class AnalysisFailedException : Exception
	{
		public AnalysisFailedException(string message)
			: base(message)
		{
		}
	}
}
