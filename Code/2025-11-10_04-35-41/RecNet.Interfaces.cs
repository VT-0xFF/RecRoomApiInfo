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
using System.Threading;
using System.Threading.Tasks;
using Cpp2IlInjected;
using Microsoft.CodeAnalysis;
using RecNet.AI;
using RecNet.Common;
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
		[Cpp2IlInjected.Address(RVA = "0xACE190", Offset = "0xACD590", VA = "0x180ACE190")]
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
		[Cpp2IlInjected.Address(RVA = "0x771A2E0", Offset = "0x77196E0", VA = "0x18771A2E0")]
		public NullableAttribute(byte P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0xACEB40", Offset = "0xACDF40", VA = "0x180ACEB40")]
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
		[Cpp2IlInjected.Address(RVA = "0xACEB80", Offset = "0xACDF80", VA = "0x180ACEB80")]
		public NullableContextAttribute(byte P_0)
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public class BCJJYUOGOJS
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
	public string LKKEWPLBLZW;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000005")]
	public string HVCYASLBFEH;

	[Cpp2IlInjected.Token(Token = "0x17000001")]
	public ResultStates HPHMOXITLQU
	{
		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0xAA3110", Offset = "0xAA2510", VA = "0x180AA3110")]
		[CompilerGenerated]
		get
		{
			return default(ResultStates);
		}
		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0xAAB1D0", Offset = "0xAAA5D0", VA = "0x180AAB1D0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	public bool VSMKKSIWTLZ
	{
		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x1E8A200", Offset = "0x1E89600", VA = "0x181E8A200")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	public bool RUCIFJOPCFZ
	{
		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x1746480", Offset = "0x1745880", VA = "0x181746480")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x7713F10", Offset = "0x7713310", VA = "0x187713F10")]
	[Obsolete("Use RecNet.Store.SkuPurchaseResult instead")]
	public static BCJJYUOGOJS Success()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x7713E80", Offset = "0x7713280", VA = "0x187713E80")]
	[Obsolete("Use RecNet.Store.SkuPurchaseResult instead")]
	public static BCJJYUOGOJS Cancelled([Optional] string userFriendlyError, [Optional] string internalError)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0xAAC8E0", Offset = "0xAABCE0", VA = "0x180AAC8E0")]
	public BCJJYUOGOJS()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
[CompilerGenerated]
[EditorBrowsable(EditorBrowsableState.Never)]
[GeneratedCode("Unity.MonoScriptGenerator.MonoScriptInfoGenerator", null)]
internal class SVGWPJOUYUE
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
	[Cpp2IlInjected.Address(RVA = "0x771BD40", Offset = "0x771B140", VA = "0x18771BD40")]
	private static MonoScriptData Get()
	{
		return default(MonoScriptData);
	}

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0xAAC8E0", Offset = "0xAABCE0", VA = "0x180AAC8E0")]
	public SVGWPJOUYUE()
	{
	}
}
namespace RecNet
{
	[Cpp2IlInjected.Token(Token = "0x2000009")]
	public interface GMMXLNCCSCD
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
	public interface XOCMLFBRJYZ
	{
		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(Slot = "0")]
		Task<GMMXLNCCSCD> KXZXLUAWFIR(string a, string b, string c, VoiceOption d, string? transcriptionModel, float e, [Optional] CancellationToken f);
	}
	[Cpp2IlInjected.Token(Token = "0x200000B")]
	public interface RLLCPXNLAQS : XOCMLFBRJYZ
	{
		[Cpp2IlInjected.Token(Token = "0x17000006")]
		GenerateCircuitsResponseDTO? LWEUBOGQAFK
		{
			[Cpp2IlInjected.Token(Token = "0x6000011")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000007")]
		KBLPOZGJAAH<MakerAITimeBalanceStatusUpdatePushNotification> HKSJXPUNTJC
		{
			[Cpp2IlInjected.Token(Token = "0x6000013")]
			[Cpp2IlInjected.Address(Slot = "2")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000008")]
		KBLPOZGJAAH<MakerAIUsageBalanceStatusUpdatePushNotification> MTSTBPXWXFA
		{
			[Cpp2IlInjected.Token(Token = "0x6000014")]
			[Cpp2IlInjected.Address(Slot = "3")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000009")]
		KBLPOZGJAAH<GenerateMeshResponseDTO> FIOFZUDJHST
		{
			[Cpp2IlInjected.Token(Token = "0x6000015")]
			[Cpp2IlInjected.Address(Slot = "4")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x1700000A")]
		NHBLQESUHLS AHHLMGMEZZS
		{
			[Cpp2IlInjected.Token(Token = "0x6000016")]
			[Cpp2IlInjected.Address(Slot = "5")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(Slot = "1")]
		void UOZEIRDCIGI();

		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(Slot = "6")]
		Task<DisposableMemorySequence<byte>> VJUUEPGKZDV(string a, [Optional] CancellationToken b);

		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(Slot = "7")]
		Task<NRWZBJOAKFL> VKEKWXPNVFH(bool a, [Optional] CancellationToken b);

		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(Slot = "8")]
		Task<LSFOAQTOQKW<RoomieEnergyDTO>> YBRCFTPNWPI(bool a = false, [Optional] CancellationToken b);

		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(Slot = "9")]
		Task<NRWZBJOAKFL> VDLKYYHHLRH(long a, [Optional] CancellationToken b);

		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(Slot = "10")]
		Task<RecNetResultObject<GameAIRoomSpendSummaryDTO>> CBZVLLPYGGR(long a, bool b = false, [Optional] CancellationToken c);

		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(Slot = "11")]
		Task<GameAIPromoBalanceDTO> QFIVOZQLLUH([Optional] CancellationToken a);

		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(Slot = "12")]
		Task<GameAIPromoBalanceDTO> OCFVINXPQPQ(long a, [Optional] CancellationToken b);

		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(Slot = "13")]
		Task<MakerAIBalancesDTO> QWENEUYSWFX(bool a = false, [Optional] CancellationToken b);

		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(Slot = "14")]
		Task<MakerAIFreeTrialConfigDTO> QONJYVJPHNS([Optional] CancellationToken a);

		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(Slot = "15")]
		Task<NRWZBJOAKFL> BKQLFFMOKTD(bool a = false, [Optional] CancellationToken b);

		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(Slot = "16")]
		Task<NRWZBJOAKFL> KSMTGWJRYYL([Optional] CancellationToken a);

		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(Slot = "17")]
		Task<NRWZBJOAKFL> KAXIWTSLTSG(string a, Guid b, long c, long d, decimal e, [Optional] CancellationToken f);

		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(Slot = "18")]
		Task<LSFOAQTOQKW<RoomieEnergyDTO>> ZLVNCMSQEJS(Guid a, long b, long c, decimal d, byte e, [Optional] CancellationToken f);

		[Cpp2IlInjected.Token(Token = "0x6000024")]
		[Cpp2IlInjected.Address(Slot = "19")]
		Task ZDCJPEMCBUV(string a, string b, [Optional] CancellationToken c);

		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(Slot = "20")]
		Task<GenerateImageResponseDTO> SCTUTHTWFFF(string a, string b, bool c, [Optional] CancellationToken d);

		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(Slot = "21")]
		Task<GenerateMeshResponseDTO> ZRVRGLMOLTM(long a, string b, string c, string d, string e, [Optional] CancellationToken f);

		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(Slot = "22")]
		Task<GenerateMeshResponseDTO> FCRUNUPROYW(long a, [Optional] CancellationToken b);

		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(Slot = "23")]
		Task<DescribeImageResponseDTO> MTBAURKYHYK(string? model, string a, string b, [Optional] CancellationToken c);

		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(Slot = "24")]
		Task<DescribeImageResponseDTO> MTBAURKYHYK(string? model, string a, byte[] b, [Optional] CancellationToken c);

		[Cpp2IlInjected.Token(Token = "0x600002A")]
		[Cpp2IlInjected.Address(Slot = "25")]
		Task<DescribeImageResponseDTO> AABRTMLTLRP(long a, string? model, string b, string c, float? d, string e, [Optional] CancellationToken f);

		[Cpp2IlInjected.Token(Token = "0x600002B")]
		[Cpp2IlInjected.Address(Slot = "26")]
		Task<DescribeImageResponseDTO> AABRTMLTLRP(long a, string? model, string b, byte[] c, float? d, string e, [Optional] CancellationToken f);

		[Cpp2IlInjected.Token(Token = "0x600002C")]
		[Cpp2IlInjected.Address(Slot = "27")]
		Task<GenerateImageResponseDTO> ULJTLDKZRSY(long a, EditImageRequestDTO b, byte[] c, string d, [Optional] CancellationToken e);

		[Cpp2IlInjected.Token(Token = "0x600002D")]
		[Cpp2IlInjected.Address(Slot = "28")]
		Task<GenerateImageResponseDTO> FSMBEHNASWR(EditImageRequestDTO a, string b, string c, [Optional] CancellationToken d);

		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(Slot = "29")]
		Task<GenerateImageResponseDTO> HMXRCBXCOLN(long a, string? model, string b, bool c, string d, [Optional] CancellationToken e);

		[Cpp2IlInjected.Token(Token = "0x600002F")]
		[Cpp2IlInjected.Address(Slot = "30")]
		Task<GenerateAudioOrSongResponseDTO> NUUSDUMDDQN(string a, int b, string c, string d, [Optional] CancellationToken e);

		[Cpp2IlInjected.Token(Token = "0x6000030")]
		[Cpp2IlInjected.Address(Slot = "31")]
		Task<GenerateAudioOrSongResponseDTO> KNUYSDYLTTP(string a, int b, string c, [Optional] CancellationToken d);

		[Cpp2IlInjected.Token(Token = "0x6000031")]
		[Cpp2IlInjected.Address(Slot = "32")]
		Task<ChatResponseDTO> Chat(string? model, string prompt, [Optional] CancellationToken cancellationToken);

		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(Slot = "33")]
		Task<GenerateCircuitsResponseDTO> GenerateCircuits(string prompt, CircuitObjectDefinition? objectDefinition, IReadOnlyList<CircuitObjectDefinition>? sceneObjectDefinitions, IReadOnlyList<string> sceneTags, CircuitGenConfigDTO config, [Optional] string? overrideInstructions, [Optional] string? overrideLibraryCode, [Optional] string? overrideModel, [Optional] CancellationToken cancellationToken);

		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(Slot = "34")]
		Task<GenerateCircuitsResponseDTO> XLWVWCNDRUM(string a, CircuitObjectDefinition? objectDefinition, IReadOnlyList<string> b, CircuitGenConfigDTO c, [Optional] string? overrideLibraryCode, [Optional] CancellationToken d);

		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(Slot = "35")]
		Task<List<string>> SearchRooms(string prompt, [Optional] CancellationToken cancellationToken);

		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(Slot = "36")]
		Task<string> CZJNJSYLLQQ(CircuitGenConfigDTO a, [Optional] CancellationToken b);

		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(Slot = "37")]
		Task FQESVUWJNFV(string a, VoiceOption b, string? instructions, Action<string> c, string d, [Optional] CancellationToken e);

		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(Slot = "38")]
		Task<string> WOYGBXQLQBD(ReadOnlyMemory<byte> pcmData, int a, int b, string c, [Optional] CancellationToken d);

		[Cpp2IlInjected.Token(Token = "0x6000038")]
		[Cpp2IlInjected.Address(Slot = "39")]
		Task<RoomieUserFactsDTO> ADSULZFTKES(List<ConversationMessageDTO> a, [Optional] CancellationToken b);

		[Cpp2IlInjected.Token(Token = "0x6000039")]
		[Cpp2IlInjected.Address(Slot = "40")]
		Task<RoomieUserFactsDTO> ZCXBDTEDMGY([Optional] CancellationToken a);

		[Cpp2IlInjected.Token(Token = "0x600003A")]
		[Cpp2IlInjected.Address(Slot = "41")]
		Task<bool> ELATLLOPCUU(string a, [Optional] CancellationToken b);

		[Cpp2IlInjected.Token(Token = "0x600003B")]
		[Cpp2IlInjected.Address(Slot = "42")]
		Task DIBIEECBHDR(string a, ConversationMessageRole b, string c, [Optional] CancellationToken d);

		[Cpp2IlInjected.Token(Token = "0x600003C")]
		[Cpp2IlInjected.Address(Slot = "43")]
		Task TNJGOOPVHLB(string a, string b, string c, [Optional] CancellationToken d);

		[Cpp2IlInjected.Token(Token = "0x600003D")]
		[Cpp2IlInjected.Address(Slot = "44")]
		Task<GenerateConversationResponseResponseDTO> RUEBFRXQEJQ(string a, string b, [Optional] string? model, [Optional] float? c, [Optional] NamedSchemaDTO? responseFormat, [Optional] IReadOnlyCollection<NamedSchemaDTO>? tools, ToolChoice d = ToolChoice.Auto, [Optional] string? forceToolName, [Optional] CancellationToken e);
	}
	[Cpp2IlInjected.Token(Token = "0x200000C")]
	public class FILVSSXPISR
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400000F")]
		private string XXTZZSWZBBT;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000010")]
		private string SLAYQIVVCSA;

		[Cpp2IlInjected.Token(Token = "0x1700000B")]
		public string CPSFDAUIETL
		{
			[Cpp2IlInjected.Token(Token = "0x600003E")]
			[Cpp2IlInjected.Address(RVA = "0xAAB1C0", Offset = "0xAAA5C0", VA = "0x180AAB1C0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600003F")]
			[Cpp2IlInjected.Address(RVA = "0xAA67C0", Offset = "0xAA5BC0", VA = "0x180AA67C0")]
			[CompilerGenerated]
			internal set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000C")]
		public string KHBXQSOZRLX
		{
			[Cpp2IlInjected.Token(Token = "0x6000040")]
			[Cpp2IlInjected.Address(RVA = "0xAAA820", Offset = "0xAA9C20", VA = "0x180AAA820")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000041")]
			[Cpp2IlInjected.Address(RVA = "0xAA67D0", Offset = "0xAA5BD0", VA = "0x180AA67D0")]
			[CompilerGenerated]
			internal set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000D")]
		public string OEDTVKINVGN
		{
			[Cpp2IlInjected.Token(Token = "0x6000042")]
			[Cpp2IlInjected.Address(RVA = "0xAAA140", Offset = "0xAA9540", VA = "0x180AAA140")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000043")]
			[Cpp2IlInjected.Address(RVA = "0xAADB00", Offset = "0xAACF00", VA = "0x180AADB00")]
			[CompilerGenerated]
			internal set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000E")]
		public string DTWJAERUMSZ
		{
			[Cpp2IlInjected.Token(Token = "0x6000044")]
			[Cpp2IlInjected.Address(RVA = "0xAAA030", Offset = "0xAA9430", VA = "0x180AAA030")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000F")]
		public int? NKYQXSJDOYY
		{
			[Cpp2IlInjected.Token(Token = "0x6000045")]
			[Cpp2IlInjected.Address(RVA = "0xAAA810", Offset = "0xAA9C10", VA = "0x180AAA810")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000010")]
		public int? MTZHGKTSBGU
		{
			[Cpp2IlInjected.Token(Token = "0x6000046")]
			[Cpp2IlInjected.Address(RVA = "0xAAA160", Offset = "0xAA9560", VA = "0x180AAA160")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000047")]
		[Cpp2IlInjected.Address(RVA = "0x7715E10", Offset = "0x7715210", VA = "0x187715E10")]
		public FILVSSXPISR(string a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000048")]
		[Cpp2IlInjected.Address(RVA = "0x7715DE0", Offset = "0x77151E0", VA = "0x187715DE0")]
		public void XLCYVRXJIPB(string a = "")
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000049")]
		[Cpp2IlInjected.Address(RVA = "0x7715CE0", Offset = "0x77150E0", VA = "0x187715CE0")]
		private void DRLHKEQXCXI()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000E")]
	public interface IJEFPCZUVMK
	{
		[Cpp2IlInjected.Token(Token = "0x17000011")]
		QAXBUTCAZMB DHBKHCRVQSB
		{
			[Cpp2IlInjected.Token(Token = "0x600004E")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x14000001")]
		event Action<SubscriptionStatus> ERFETQTCVEN;

		[Cpp2IlInjected.Token(Token = "0x14000002")]
		event Action<SubscriptionSnapshot> FKVOZRMNCZS;

		[Cpp2IlInjected.Token(Token = "0x6000053")]
		[Cpp2IlInjected.Address(Slot = "5")]
		Task<SubscriptionSnapshot> IFRMMKZQZLQ(bool a = false, [Optional] CancellationToken b);

		[Cpp2IlInjected.Token(Token = "0x6000054")]
		[Cpp2IlInjected.Address(Slot = "6")]
		bool LBHNOURGRVK([Out] SubscriptionSnapshot a);
	}
	[Cpp2IlInjected.Token(Token = "0x200000F")]
	public static class CUMWTDQQROU
	{
		[Cpp2IlInjected.Token(Token = "0x6000055")]
		[Cpp2IlInjected.Address(RVA = "0x7715370", Offset = "0x7714770", VA = "0x187715370")]
		public static bool VFGYKBIVLTE(this IJEFPCZUVMK a, [Out] SubscriptionStatus b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000056")]
		[Cpp2IlInjected.Address(RVA = "0x7715290", Offset = "0x7714690", VA = "0x187715290")]
		public static bool RPHRFPVHRNA(this IJEFPCZUVMK a)
		{
			return default(bool);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000010")]
	public interface NPOLVZFHYBV
	{
		[Cpp2IlInjected.Token(Token = "0x6000057")]
		[Cpp2IlInjected.Address(Slot = "0")]
		Task DCZVZWLQOFI(CancellationToken a);

		[Cpp2IlInjected.Token(Token = "0x6000058")]
		[Cpp2IlInjected.Address(Slot = "1")]
		bool WWRMODXYMSX(int a, [Out] XDKIBMWIWPG? b);
	}
	[Cpp2IlInjected.Token(Token = "0x2000011")]
	public interface XDKIBMWIWPG
	{
		[Cpp2IlInjected.Token(Token = "0x17000012")]
		int EGNXYBPXAFU
		{
			[Cpp2IlInjected.Token(Token = "0x6000059")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000013")]
		string? NSNROSXPJBX
		{
			[Cpp2IlInjected.Token(Token = "0x600005A")]
			[Cpp2IlInjected.Address(Slot = "1")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000014")]
		string? SKIARNWWPAU
		{
			[Cpp2IlInjected.Token(Token = "0x600005B")]
			[Cpp2IlInjected.Address(Slot = "2")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000015")]
		bool? HXHPOGUOILM
		{
			[Cpp2IlInjected.Token(Token = "0x600005C")]
			[Cpp2IlInjected.Address(Slot = "3")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000016")]
		string? DBRQYVWCNKY
		{
			[Cpp2IlInjected.Token(Token = "0x600005D")]
			[Cpp2IlInjected.Address(Slot = "4")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000017")]
		string? JJEYTRKGPWC
		{
			[Cpp2IlInjected.Token(Token = "0x600005E")]
			[Cpp2IlInjected.Address(Slot = "5")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000018")]
		YNBOVRDTKPZ? OTNTHJUASNP
		{
			[Cpp2IlInjected.Token(Token = "0x600005F")]
			[Cpp2IlInjected.Address(Slot = "6")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x6000060")]
		[Cpp2IlInjected.Address(Slot = "7")]
		bool KFCWVZQKVBY(string a, [Out] DGMATKUDVIY? config);
	}
	[Cpp2IlInjected.Token(Token = "0x2000012")]
	public interface DGMATKUDVIY
	{
		[Cpp2IlInjected.Token(Token = "0x17000019")]
		string? PVNXHJOCPXW
		{
			[Cpp2IlInjected.Token(Token = "0x6000061")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x1700001A")]
		string? NDLHNVCRWBD
		{
			[Cpp2IlInjected.Token(Token = "0x6000062")]
			[Cpp2IlInjected.Address(Slot = "1")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x1700001B")]
		string? QXLHHTZBESA
		{
			[Cpp2IlInjected.Token(Token = "0x6000063")]
			[Cpp2IlInjected.Address(Slot = "2")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x1700001C")]
		IReadOnlyList<QQCKKGKVCKI>? WWVVWNIVYZF
		{
			[Cpp2IlInjected.Token(Token = "0x6000064")]
			[Cpp2IlInjected.Address(Slot = "3")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x1700001D")]
		YNBOVRDTKPZ? OTNTHJUASNP
		{
			[Cpp2IlInjected.Token(Token = "0x6000065")]
			[Cpp2IlInjected.Address(Slot = "4")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x1700001E")]
		long? NWSPJJGZYHZ
		{
			[Cpp2IlInjected.Token(Token = "0x6000066")]
			[Cpp2IlInjected.Address(Slot = "5")]
			get;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000013")]
	public interface QQCKKGKVCKI
	{
		[Cpp2IlInjected.Token(Token = "0x1700001F")]
		string NDLHNVCRWBD
		{
			[Cpp2IlInjected.Token(Token = "0x6000067")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000020")]
		string IRYCWFFEKLI
		{
			[Cpp2IlInjected.Token(Token = "0x6000068")]
			[Cpp2IlInjected.Address(Slot = "1")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000021")]
		SKUButtonAction POHJHINBFQN
		{
			[Cpp2IlInjected.Token(Token = "0x6000069")]
			[Cpp2IlInjected.Address(Slot = "2")]
			get;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000014")]
	public interface YNBOVRDTKPZ
	{
		[Cpp2IlInjected.Token(Token = "0x17000022")]
		string NDLHNVCRWBD
		{
			[Cpp2IlInjected.Token(Token = "0x600006A")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000023")]
		string? GMZCPUUYGVM
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
			[Cpp2IlInjected.Address(RVA = "0xAA5FB0", Offset = "0xAA53B0", VA = "0x180AA5FB0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600006D")]
			[Cpp2IlInjected.Address(RVA = "0xAA5FC0", Offset = "0xAA53C0", VA = "0x180AA5FC0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000025")]
		public int SkuId
		{
			[Cpp2IlInjected.Token(Token = "0x600006E")]
			[Cpp2IlInjected.Address(RVA = "0xAAC980", Offset = "0xAABD80", VA = "0x180AAC980")]
			[CompilerGenerated]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x600006F")]
			[Cpp2IlInjected.Address(RVA = "0xAB2F40", Offset = "0xAB2340", VA = "0x180AB2F40")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000026")]
		public int? PurchaseReminderId
		{
			[Cpp2IlInjected.Token(Token = "0x6000070")]
			[Cpp2IlInjected.Address(RVA = "0x10D2A80", Offset = "0x10D1E80", VA = "0x1810D2A80")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000071")]
			[Cpp2IlInjected.Address(RVA = "0x10D2AB0", Offset = "0x10D1EB0", VA = "0x1810D2AB0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000027")]
		public int? RRPlusSignUpBonusId
		{
			[Cpp2IlInjected.Token(Token = "0x6000072")]
			[Cpp2IlInjected.Address(RVA = "0x10D2A90", Offset = "0x10D1E90", VA = "0x1810D2A90")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000073")]
			[Cpp2IlInjected.Address(RVA = "0xDB0160", Offset = "0xDAF560", VA = "0x180DB0160")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000028")]
		public List<ItemPurchaseMethodId> BonusItemIds
		{
			[Cpp2IlInjected.Token(Token = "0x6000074")]
			[Cpp2IlInjected.Address(RVA = "0xAAA140", Offset = "0xAA9540", VA = "0x180AAA140")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000075")]
			[Cpp2IlInjected.Address(RVA = "0xAADB00", Offset = "0xAACF00", VA = "0x180AADB00")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000029")]
		public List<GrantableId> BonusSelectableGrantableIds
		{
			[Cpp2IlInjected.Token(Token = "0x6000076")]
			[Cpp2IlInjected.Address(RVA = "0xAAA030", Offset = "0xAA9430", VA = "0x180AAA030")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000077")]
			[Cpp2IlInjected.Address(RVA = "0xAAA110", Offset = "0xAA9510", VA = "0x180AAA110")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002A")]
		public int? GiftRecipientAccountId
		{
			[Cpp2IlInjected.Token(Token = "0x6000078")]
			[Cpp2IlInjected.Address(RVA = "0xAAA810", Offset = "0xAA9C10", VA = "0x180AAA810")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000079")]
			[Cpp2IlInjected.Address(RVA = "0xCDACA0", Offset = "0xCDA0A0", VA = "0x180CDACA0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002B")]
		public string GiftRecipientMessage
		{
			[Cpp2IlInjected.Token(Token = "0x600007A")]
			[Cpp2IlInjected.Address(RVA = "0xAAA160", Offset = "0xAA9560", VA = "0x180AAA160")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600007B")]
			[Cpp2IlInjected.Address(RVA = "0xAAA870", Offset = "0xAA9C70", VA = "0x180AAA870")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600007C")]
		[Cpp2IlInjected.Address(RVA = "0xAAC8E0", Offset = "0xAABCE0", VA = "0x180AAC8E0")]
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
			[Cpp2IlInjected.Address(RVA = "0xAA5FB0", Offset = "0xAA53B0", VA = "0x180AA5FB0")]
			[CompilerGenerated]
			get
			{
				return default(long);
			}
			[Cpp2IlInjected.Token(Token = "0x600007E")]
			[Cpp2IlInjected.Address(RVA = "0xB96550", Offset = "0xB95950", VA = "0x180B96550")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600007F")]
		[Cpp2IlInjected.Address(RVA = "0xAAC8E0", Offset = "0xAABCE0", VA = "0x180AAC8E0")]
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
			[Cpp2IlInjected.Address(RVA = "0xAA5FB0", Offset = "0xAA53B0", VA = "0x180AA5FB0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000081")]
			[Cpp2IlInjected.Address(RVA = "0xAA5FC0", Offset = "0xAA53C0", VA = "0x180AA5FC0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002E")]
		public string PurchaseDetails
		{
			[Cpp2IlInjected.Token(Token = "0x6000082")]
			[Cpp2IlInjected.Address(RVA = "0xAAA880", Offset = "0xAA9C80", VA = "0x180AAA880")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000083")]
			[Cpp2IlInjected.Address(RVA = "0xAAA120", Offset = "0xAA9520", VA = "0x180AAA120")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002F")]
		public int? PurchaseReminderId
		{
			[Cpp2IlInjected.Token(Token = "0x6000084")]
			[Cpp2IlInjected.Address(RVA = "0xAAB1C0", Offset = "0xAAA5C0", VA = "0x180AAB1C0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000085")]
			[Cpp2IlInjected.Address(RVA = "0xB30430", Offset = "0xB2F830", VA = "0x180B30430")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000030")]
		public int? RRPlusSignUpBonusId
		{
			[Cpp2IlInjected.Token(Token = "0x6000086")]
			[Cpp2IlInjected.Address(RVA = "0xAAA820", Offset = "0xAA9C20", VA = "0x180AAA820")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000087")]
			[Cpp2IlInjected.Address(RVA = "0xAAA000", Offset = "0xAA9400", VA = "0x180AAA000")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000031")]
		public List<ItemPurchaseMethodId> BonusItemIds
		{
			[Cpp2IlInjected.Token(Token = "0x6000088")]
			[Cpp2IlInjected.Address(RVA = "0xAAA140", Offset = "0xAA9540", VA = "0x180AAA140")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000089")]
			[Cpp2IlInjected.Address(RVA = "0xAADB00", Offset = "0xAACF00", VA = "0x180AADB00")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000032")]
		public List<GrantableId> BonusSelectableGrantableIds
		{
			[Cpp2IlInjected.Token(Token = "0x600008A")]
			[Cpp2IlInjected.Address(RVA = "0xAAA030", Offset = "0xAA9430", VA = "0x180AAA030")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600008B")]
			[Cpp2IlInjected.Address(RVA = "0xAAA110", Offset = "0xAA9510", VA = "0x180AAA110")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000033")]
		public int? GiftRecipientAccountId
		{
			[Cpp2IlInjected.Token(Token = "0x600008C")]
			[Cpp2IlInjected.Address(RVA = "0xAAA810", Offset = "0xAA9C10", VA = "0x180AAA810")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600008D")]
			[Cpp2IlInjected.Address(RVA = "0xCDACA0", Offset = "0xCDA0A0", VA = "0x180CDACA0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000034")]
		public string GiftRecipientMessage
		{
			[Cpp2IlInjected.Token(Token = "0x600008E")]
			[Cpp2IlInjected.Address(RVA = "0xAAA160", Offset = "0xAA9560", VA = "0x180AAA160")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600008F")]
			[Cpp2IlInjected.Address(RVA = "0xAAA870", Offset = "0xAA9C70", VA = "0x180AAA870")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000090")]
		[Cpp2IlInjected.Address(RVA = "0xAAC8E0", Offset = "0xAABCE0", VA = "0x180AAC8E0")]
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
			[Cpp2IlInjected.Address(RVA = "0xAA3110", Offset = "0xAA2510", VA = "0x180AA3110")]
			[CompilerGenerated]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x6000092")]
			[Cpp2IlInjected.Address(RVA = "0xAAB1D0", Offset = "0xAAA5D0", VA = "0x180AAB1D0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000036")]
		public List<SKUConfigDTO> SkuConfigs
		{
			[Cpp2IlInjected.Token(Token = "0x6000093")]
			[Cpp2IlInjected.Address(RVA = "0xAAA880", Offset = "0xAA9C80", VA = "0x180AAA880")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000094")]
			[Cpp2IlInjected.Address(RVA = "0xAAA120", Offset = "0xAA9520", VA = "0x180AAA120")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000037")]
		public Dictionary<string, string> StringReplacements
		{
			[Cpp2IlInjected.Token(Token = "0x6000095")]
			[Cpp2IlInjected.Address(RVA = "0xAAB1C0", Offset = "0xAAA5C0", VA = "0x180AAB1C0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000096")]
			[Cpp2IlInjected.Address(RVA = "0xAA67C0", Offset = "0xAA5BC0", VA = "0x180AA67C0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000097")]
		[Cpp2IlInjected.Address(RVA = "0x771B9B0", Offset = "0x771ADB0", VA = "0x18771B9B0")]
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
			[Cpp2IlInjected.Address(RVA = "0xAA3110", Offset = "0xAA2510", VA = "0x180AA3110")]
			[CompilerGenerated]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x6000099")]
			[Cpp2IlInjected.Address(RVA = "0xAAB1D0", Offset = "0xAAA5D0", VA = "0x180AAB1D0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000039")]
		public string Name
		{
			[Cpp2IlInjected.Token(Token = "0x600009A")]
			[Cpp2IlInjected.Address(RVA = "0xAAA880", Offset = "0xAA9C80", VA = "0x180AAA880")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600009B")]
			[Cpp2IlInjected.Address(RVA = "0xAAA120", Offset = "0xAA9520", VA = "0x180AAA120")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700003A")]
		public string Description
		{
			[Cpp2IlInjected.Token(Token = "0x600009C")]
			[Cpp2IlInjected.Address(RVA = "0xAAB1C0", Offset = "0xAAA5C0", VA = "0x180AAB1C0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600009D")]
			[Cpp2IlInjected.Address(RVA = "0xAA67C0", Offset = "0xAA5BC0", VA = "0x180AA67C0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700003B")]
		public string ThumbnailImageName
		{
			[Cpp2IlInjected.Token(Token = "0x600009E")]
			[Cpp2IlInjected.Address(RVA = "0xAAA820", Offset = "0xAA9C20", VA = "0x180AAA820")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600009F")]
			[Cpp2IlInjected.Address(RVA = "0xAA67D0", Offset = "0xAA5BD0", VA = "0x180AA67D0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700003C")]
		public string DetailsImageName
		{
			[Cpp2IlInjected.Token(Token = "0x60000A0")]
			[Cpp2IlInjected.Address(RVA = "0xAAA140", Offset = "0xAA9540", VA = "0x180AAA140")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60000A1")]
			[Cpp2IlInjected.Address(RVA = "0xAADB00", Offset = "0xAACF00", VA = "0x180AADB00")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700003D")]
		public bool? ShowSkuDetails
		{
			[Cpp2IlInjected.Token(Token = "0x60000A2")]
			[Cpp2IlInjected.Address(RVA = "0x21AF0D0", Offset = "0x21AE4D0", VA = "0x1821AF0D0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60000A3")]
			[Cpp2IlInjected.Address(RVA = "0x21AF130", Offset = "0x21AE530", VA = "0x1821AF130")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700003E")]
		public SKUFooterConfigDTO Footer
		{
			[Cpp2IlInjected.Token(Token = "0x60000A4")]
			[Cpp2IlInjected.Address(RVA = "0xAAA810", Offset = "0xAA9C10", VA = "0x180AAA810")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60000A5")]
			[Cpp2IlInjected.Address(RVA = "0xAAA840", Offset = "0xAA9C40", VA = "0x180AAA840")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700003F")]
		public Dictionary<string, SKUDialogConfigDTO> DialogConfigs
		{
			[Cpp2IlInjected.Token(Token = "0x60000A6")]
			[Cpp2IlInjected.Address(RVA = "0xAAA160", Offset = "0xAA9560", VA = "0x180AAA160")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60000A7")]
			[Cpp2IlInjected.Address(RVA = "0xAAA870", Offset = "0xAA9C70", VA = "0x180AAA870")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000A8")]
		[Cpp2IlInjected.Address(RVA = "0x771BA30", Offset = "0x771AE30", VA = "0x18771BA30")]
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
			[Cpp2IlInjected.Address(RVA = "0xAA5FB0", Offset = "0xAA53B0", VA = "0x180AA5FB0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60000AA")]
			[Cpp2IlInjected.Address(RVA = "0xAA5FC0", Offset = "0xAA53C0", VA = "0x180AA5FC0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000041")]
		public string ExternalUrl
		{
			[Cpp2IlInjected.Token(Token = "0x60000AB")]
			[Cpp2IlInjected.Address(RVA = "0xAAA880", Offset = "0xAA9C80", VA = "0x180AAA880")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60000AC")]
			[Cpp2IlInjected.Address(RVA = "0xAAA120", Offset = "0xAA9520", VA = "0x180AAA120")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000AD")]
		[Cpp2IlInjected.Address(RVA = "0xAAC8E0", Offset = "0xAABCE0", VA = "0x180AAC8E0")]
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
			[Cpp2IlInjected.Address(RVA = "0xAA5FB0", Offset = "0xAA53B0", VA = "0x180AA5FB0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60000AF")]
			[Cpp2IlInjected.Address(RVA = "0xAA5FC0", Offset = "0xAA53C0", VA = "0x180AA5FC0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000043")]
		public string Text
		{
			[Cpp2IlInjected.Token(Token = "0x60000B0")]
			[Cpp2IlInjected.Address(RVA = "0xAAA880", Offset = "0xAA9C80", VA = "0x180AAA880")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60000B1")]
			[Cpp2IlInjected.Address(RVA = "0xAAA120", Offset = "0xAA9520", VA = "0x180AAA120")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000044")]
		public string SpriteName
		{
			[Cpp2IlInjected.Token(Token = "0x60000B2")]
			[Cpp2IlInjected.Address(RVA = "0xAAB1C0", Offset = "0xAAA5C0", VA = "0x180AAB1C0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60000B3")]
			[Cpp2IlInjected.Address(RVA = "0xAA67C0", Offset = "0xAA5BC0", VA = "0x180AA67C0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000045")]
		public List<SKUButtonConfigDTO> Buttons
		{
			[Cpp2IlInjected.Token(Token = "0x60000B4")]
			[Cpp2IlInjected.Address(RVA = "0xAAA820", Offset = "0xAA9C20", VA = "0x180AAA820")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60000B5")]
			[Cpp2IlInjected.Address(RVA = "0xAA67D0", Offset = "0xAA5BD0", VA = "0x180AA67D0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000046")]
		public SKUFooterConfigDTO Footer
		{
			[Cpp2IlInjected.Token(Token = "0x60000B6")]
			[Cpp2IlInjected.Address(RVA = "0xAAA140", Offset = "0xAA9540", VA = "0x180AAA140")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60000B7")]
			[Cpp2IlInjected.Address(RVA = "0xAADB00", Offset = "0xAACF00", VA = "0x180AADB00")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000047")]
		public long Cooldown
		{
			[Cpp2IlInjected.Token(Token = "0x60000B8")]
			[Cpp2IlInjected.Address(RVA = "0xAAA030", Offset = "0xAA9430", VA = "0x180AAA030")]
			[CompilerGenerated]
			get
			{
				return default(long);
			}
			[Cpp2IlInjected.Token(Token = "0x60000B9")]
			[Cpp2IlInjected.Address(RVA = "0xAAF810", Offset = "0xAAEC10", VA = "0x180AAF810")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000BA")]
		[Cpp2IlInjected.Address(RVA = "0x771BAB0", Offset = "0x771AEB0", VA = "0x18771BAB0")]
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
			[Cpp2IlInjected.Address(RVA = "0xAA5FB0", Offset = "0xAA53B0", VA = "0x180AA5FB0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60000BC")]
			[Cpp2IlInjected.Address(RVA = "0xAA5FC0", Offset = "0xAA53C0", VA = "0x180AA5FC0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000049")]
		public string Type
		{
			[Cpp2IlInjected.Token(Token = "0x60000BD")]
			[Cpp2IlInjected.Address(RVA = "0xAAA880", Offset = "0xAA9C80", VA = "0x180AAA880")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60000BE")]
			[Cpp2IlInjected.Address(RVA = "0xAAA120", Offset = "0xAA9520", VA = "0x180AAA120")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700004A")]
		public SKUButtonAction OnClick
		{
			[Cpp2IlInjected.Token(Token = "0x60000BF")]
			[Cpp2IlInjected.Address(RVA = "0xAB5660", Offset = "0xAB4A60", VA = "0x180AB5660")]
			[CompilerGenerated]
			get
			{
				return default(SKUButtonAction);
			}
			[Cpp2IlInjected.Token(Token = "0x60000C0")]
			[Cpp2IlInjected.Address(RVA = "0xB07AB0", Offset = "0xB06EB0", VA = "0x180B07AB0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000C1")]
		[Cpp2IlInjected.Address(RVA = "0xAAC8E0", Offset = "0xAABCE0", VA = "0x180AAC8E0")]
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
		public static SubscriptionDetails MODPEQIAJRW
		{
			[Cpp2IlInjected.Token(Token = "0x60000C2")]
			[Cpp2IlInjected.Address(RVA = "0x2805720", Offset = "0x2804B20", VA = "0x182805720")]
			get
			{
				return default(SubscriptionDetails);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000C3")]
		[Cpp2IlInjected.Address(RVA = "0x771CE50", Offset = "0x771C250", VA = "0x18771CE50")]
		public SubscriptionDetails(DateTime expirationDateUtc, bool isAutoRenewing, PlatformType? platformType, string platformId, int? platformAccountSubscribedPlayerId)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C4")]
		[Cpp2IlInjected.Address(RVA = "0x771CD60", Offset = "0x771C160", VA = "0x18771CD60")]
		public SubscriptionStatus UGPYAPMKLJO(QAXBUTCAZMB a)
		{
			return default(SubscriptionStatus);
		}

		[Cpp2IlInjected.Token(Token = "0x60000C5")]
		[Cpp2IlInjected.Address(RVA = "0x771CC40", Offset = "0x771C040", VA = "0x18771CC40")]
		private static SubscriptionStatus IGXDMSIYFWV(QAXBUTCAZMB a, DateTime b)
		{
			return default(SubscriptionStatus);
		}

		[Cpp2IlInjected.Token(Token = "0x60000C6")]
		[Cpp2IlInjected.Address(RVA = "0x771CA30", Offset = "0x771BE30", VA = "0x18771CA30", Slot = "4")]
		public bool Equals(SubscriptionDetails other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000C7")]
		[Cpp2IlInjected.Address(RVA = "0x771C980", Offset = "0x771BD80", VA = "0x18771C980", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000C8")]
		[Cpp2IlInjected.Address(RVA = "0x771CB90", Offset = "0x771BF90", VA = "0x18771CB90", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[SpecialName]
		[Cpp2IlInjected.Token(Token = "0x60000C9")]
		[Cpp2IlInjected.Address(RVA = "0x771CE20", Offset = "0x771C220", VA = "0x18771CE20")]
		public static bool ZWISVWGZSLY(SubscriptionDetails a, SubscriptionDetails b)
		{
			return default(bool);
		}

		[SpecialName]
		[Cpp2IlInjected.Token(Token = "0x60000CA")]
		[Cpp2IlInjected.Address(RVA = "0x771CDE0", Offset = "0x771C1E0", VA = "0x18771CDE0")]
		public static bool ZPGHGHNXRJT(SubscriptionDetails a, SubscriptionDetails b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000CB")]
		[Cpp2IlInjected.Address(RVA = "0x771CCB0", Offset = "0x771C0B0", VA = "0x18771CCB0", Slot = "3")]
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
		[Cpp2IlInjected.Address(RVA = "0x771D440", Offset = "0x771C840", VA = "0x18771D440")]
		public SubscriptionSnapshot(SubscriptionStatus subscriptionStatus, SubscriptionDetails subscriptionDetails)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000CD")]
		[Cpp2IlInjected.Address(RVA = "0x771CE90", Offset = "0x771C290", VA = "0x18771CE90", Slot = "4")]
		public bool Equals(SubscriptionSnapshot other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000CE")]
		[Cpp2IlInjected.Address(RVA = "0x771CF40", Offset = "0x771C340", VA = "0x18771CF40", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000CF")]
		[Cpp2IlInjected.Address(RVA = "0x771D070", Offset = "0x771C470", VA = "0x18771D070", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[SpecialName]
		[Cpp2IlInjected.Token(Token = "0x60000D0")]
		[Cpp2IlInjected.Address(RVA = "0x771D330", Offset = "0x771C730", VA = "0x18771D330")]
		public static bool ZWISVWGZSLY(SubscriptionSnapshot a, SubscriptionSnapshot b)
		{
			return default(bool);
		}

		[SpecialName]
		[Cpp2IlInjected.Token(Token = "0x60000D1")]
		[Cpp2IlInjected.Address(RVA = "0x771D210", Offset = "0x771C610", VA = "0x18771D210")]
		public static bool ZPGHGHNXRJT(SubscriptionSnapshot a, SubscriptionSnapshot b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000D2")]
		[Cpp2IlInjected.Address(RVA = "0x771D130", Offset = "0x771C530", VA = "0x18771D130", Slot = "3")]
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
	public class BJLSTYPZWRB : QAXBUTCAZMB
	{
		[Cpp2IlInjected.Token(Token = "0x4000058")]
		public const string RWPZOZZGIYT = "ServerTime";

		[Cpp2IlInjected.Token(Token = "0x4000059")]
		private static readonly Stopwatch ERORTHQHXWK;

		[Cpp2IlInjected.Token(Token = "0x400005A")]
		private static DateTimeOffset? ABVJLYBPMRS;

		[Cpp2IlInjected.Token(Token = "0x400005B")]
		private static readonly BJLSTYPZWRB HEWJBQCTFXH;

		[Cpp2IlInjected.Token(Token = "0x1700004C")]
		public static QAXBUTCAZMB LVYKDVFRYUJ
		{
			[Cpp2IlInjected.Token(Token = "0x60000D4")]
			[Cpp2IlInjected.Address(RVA = "0x7713FC0", Offset = "0x77133C0", VA = "0x187713FC0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700004D")]
		internal static BJLSTYPZWRB BHWPOUJDNZK
		{
			[Cpp2IlInjected.Token(Token = "0x60000D5")]
			[Cpp2IlInjected.Address(RVA = "0x7713F70", Offset = "0x7713370", VA = "0x187713F70")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700004E")]
		public static DateTimeOffset ABPYCFQZTKG
		{
			[Cpp2IlInjected.Token(Token = "0x60000D6")]
			[Cpp2IlInjected.Address(RVA = "0x77143D0", Offset = "0x77137D0", VA = "0x1877143D0")]
			get
			{
				return default(DateTimeOffset);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700004F")]
		public static DateTime YWRYIVLFSEZ
		{
			[Cpp2IlInjected.Token(Token = "0x60000D7")]
			[Cpp2IlInjected.Address(RVA = "0x7714220", Offset = "0x7713620", VA = "0x187714220")]
			get
			{
				return default(DateTime);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000050")]
		public DateTime KBFTZDVUUUE
		{
			[Cpp2IlInjected.Token(Token = "0x60000D8")]
			[Cpp2IlInjected.Address(RVA = "0x77142B0", Offset = "0x77136B0", VA = "0x1877142B0", Slot = "4")]
			get
			{
				return default(DateTime);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000051")]
		public DateTimeOffset UWJCOOERDQD
		{
			[Cpp2IlInjected.Token(Token = "0x60000D9")]
			[Cpp2IlInjected.Address(RVA = "0x7714370", Offset = "0x7713770", VA = "0x187714370", Slot = "5")]
			get
			{
				return default(DateTimeOffset);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000DA")]
		[Cpp2IlInjected.Address(RVA = "0xAAC8E0", Offset = "0xAABCE0", VA = "0x180AAC8E0")]
		private BJLSTYPZWRB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000DB")]
		[Cpp2IlInjected.Address(RVA = "0x7714010", Offset = "0x7713410", VA = "0x187714010")]
		internal static void NDMYOJEDBWJ(DateTime? a)
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
	public class CustomAvatarItem : EOJDXCFUAXC, FTMSUJYXKGB, DURPPUIUDDT, OULJHHDVWBG
	{
		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x2000025")]
		[CompilerGenerated]
		private struct <OnDeserializedAsync>d__86 : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000077")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x4000078")]
			public AsyncTaskMethodBuilder <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000079")]
			public CustomAvatarItem <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x400007A")]
			private ConfiguredTaskAwaitable<string>.ConfiguredTaskAwaiter <>u__1;

			[Cpp2IlInjected.Token(Token = "0x6000114")]
			[Cpp2IlInjected.Address(RVA = "0x771E9F0", Offset = "0x771DDF0", VA = "0x18771E9F0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000115")]
			[Cpp2IlInjected.Address(RVA = "0x771ED90", Offset = "0x771E190", VA = "0x18771ED90", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000076")]
		[IgnoreDataMember]
		public static RIWMWKYZVIR RecNetPlatformAccess;

		[Cpp2IlInjected.Token(Token = "0x17000052")]
		public Guid CustomAvatarItemId
		{
			[Cpp2IlInjected.Token(Token = "0x60000DD")]
			[Cpp2IlInjected.Address(RVA = "0xBAF500", Offset = "0xBAE900", VA = "0x180BAF500", Slot = "37")]
			[CompilerGenerated]
			get
			{
				return default(Guid);
			}
			[Cpp2IlInjected.Token(Token = "0x60000DE")]
			[Cpp2IlInjected.Address(RVA = "0xBAF520", Offset = "0xBAE920", VA = "0x180BAF520")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000053")]
		public int CreatorAccountId
		{
			[Cpp2IlInjected.Token(Token = "0x60000DF")]
			[Cpp2IlInjected.Address(RVA = "0xAB5660", Offset = "0xAB4A60", VA = "0x180AB5660", Slot = "38")]
			[CompilerGenerated]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x60000E0")]
			[Cpp2IlInjected.Address(RVA = "0xB07AB0", Offset = "0xB06EB0", VA = "0x180B07AB0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000054")]
		public string Name
		{
			[Cpp2IlInjected.Token(Token = "0x60000E1")]
			[Cpp2IlInjected.Address(RVA = "0xAAA820", Offset = "0xAA9C20", VA = "0x180AAA820", Slot = "39")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60000E2")]
			[Cpp2IlInjected.Address(RVA = "0xAA67D0", Offset = "0xAA5BD0", VA = "0x180AA67D0")]
			[CompilerGenerated]
			internal set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000055")]
		public string Description
		{
			[Cpp2IlInjected.Token(Token = "0x60000E3")]
			[Cpp2IlInjected.Address(RVA = "0xAAA140", Offset = "0xAA9540", VA = "0x180AAA140", Slot = "40")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60000E4")]
			[Cpp2IlInjected.Address(RVA = "0xAADB00", Offset = "0xAACF00", VA = "0x180AADB00")]
			[CompilerGenerated]
			internal set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000056")]
		public int Price
		{
			[Cpp2IlInjected.Token(Token = "0x60000E5")]
			[Cpp2IlInjected.Address(RVA = "0xAD4020", Offset = "0xAD3420", VA = "0x180AD4020", Slot = "8")]
			[CompilerGenerated]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x60000E6")]
			[Cpp2IlInjected.Address(RVA = "0xB10400", Offset = "0xB0F800", VA = "0x180B10400")]
			[CompilerGenerated]
			internal set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000057")]
		public UgcAccessibility Accessibility
		{
			[Cpp2IlInjected.Token(Token = "0x60000E7")]
			[Cpp2IlInjected.Address(RVA = "0xAE3BC0", Offset = "0xAE2FC0", VA = "0x180AE3BC0", Slot = "44")]
			[CompilerGenerated]
			get
			{
				return default(UgcAccessibility);
			}
			[Cpp2IlInjected.Token(Token = "0x60000E8")]
			[Cpp2IlInjected.Address(RVA = "0xAE34B0", Offset = "0xAE28B0", VA = "0x180AE34B0")]
			[CompilerGenerated]
			internal set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000058")]
		public bool ForceCannotPublish
		{
			[Cpp2IlInjected.Token(Token = "0x60000E9")]
			[Cpp2IlInjected.Address(RVA = "0xC6B720", Offset = "0xC6AB20", VA = "0x180C6B720", Slot = "10")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x60000EA")]
			[Cpp2IlInjected.Address(RVA = "0xC6B160", Offset = "0xC6A560", VA = "0x180C6B160")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000059")]
		public bool IsFeatured
		{
			[Cpp2IlInjected.Token(Token = "0x60000EB")]
			[Cpp2IlInjected.Address(RVA = "0x12AD950", Offset = "0x12ACD50", VA = "0x1812AD950", Slot = "28")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x60000EC")]
			[Cpp2IlInjected.Address(RVA = "0x12AD620", Offset = "0x12ACA20", VA = "0x1812AD620")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700005A")]
		public bool IsRecRoomApproved
		{
			[Cpp2IlInjected.Token(Token = "0x60000ED")]
			[Cpp2IlInjected.Address(RVA = "0x7715B90", Offset = "0x7714F90", VA = "0x187715B90", Slot = "41")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x60000EE")]
			[Cpp2IlInjected.Address(RVA = "0x1DD5AF0", Offset = "0x1DD4EF0", VA = "0x181DD5AF0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700005B")]
		public int? BaseAvatarItemId
		{
			[Cpp2IlInjected.Token(Token = "0x60000EF")]
			[Cpp2IlInjected.Address(RVA = "0x47F8CB0", Offset = "0x47F80B0", VA = "0x1847F8CB0", Slot = "43")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60000F0")]
			[Cpp2IlInjected.Address(RVA = "0x7715BA0", Offset = "0x7714FA0", VA = "0x187715BA0", Slot = "14")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700005C")]
		public string BaseAvatarItemColor
		{
			[Cpp2IlInjected.Token(Token = "0x60000F1")]
			[Cpp2IlInjected.Address(RVA = "0xAA3370", Offset = "0xAA2770", VA = "0x180AA3370", Slot = "15")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60000F2")]
			[Cpp2IlInjected.Address(RVA = "0xAA3390", Offset = "0xAA2790", VA = "0x180AA3390")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700005D")]
		public string DesignFilename
		{
			[Cpp2IlInjected.Token(Token = "0x60000F3")]
			[Cpp2IlInjected.Address(RVA = "0xAA3150", Offset = "0xAA2550", VA = "0x180AA3150", Slot = "16")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60000F4")]
			[Cpp2IlInjected.Address(RVA = "0xAA33A0", Offset = "0xAA27A0", VA = "0x180AA33A0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700005E")]
		public string ThumbnailImageFilename
		{
			[Cpp2IlInjected.Token(Token = "0x60000F5")]
			[Cpp2IlInjected.Address(RVA = "0xAA3380", Offset = "0xAA2780", VA = "0x180AA3380", Slot = "27")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60000F6")]
			[Cpp2IlInjected.Address(RVA = "0xAA3130", Offset = "0xAA2530", VA = "0x180AA3130")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700005F")]
		public DateTime CreatedAt
		{
			[Cpp2IlInjected.Token(Token = "0x60000F7")]
			[Cpp2IlInjected.Address(RVA = "0xAA3120", Offset = "0xAA2520", VA = "0x180AA3120", Slot = "18")]
			[CompilerGenerated]
			get
			{
				return default(DateTime);
			}
			[Cpp2IlInjected.Token(Token = "0x60000F8")]
			[Cpp2IlInjected.Address(RVA = "0xCE0410", Offset = "0xCDF810", VA = "0x180CE0410")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000060")]
		public DateTime ModifiedAt
		{
			[Cpp2IlInjected.Token(Token = "0x60000F9")]
			[Cpp2IlInjected.Address(RVA = "0xAA5380", Offset = "0xAA4780", VA = "0x180AA5380", Slot = "19")]
			[CompilerGenerated]
			get
			{
				return default(DateTime);
			}
			[Cpp2IlInjected.Token(Token = "0x60000FA")]
			[Cpp2IlInjected.Address(RVA = "0xCE06C0", Offset = "0xCDFAC0", VA = "0x180CE06C0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000061")]
		public CustomAvatarItemPreviewOrientation PreviewOrientation
		{
			[Cpp2IlInjected.Token(Token = "0x60000FB")]
			[Cpp2IlInjected.Address(RVA = "0xACB690", Offset = "0xACAA90", VA = "0x180ACB690", Slot = "20")]
			[CompilerGenerated]
			get
			{
				return default(CustomAvatarItemPreviewOrientation);
			}
			[Cpp2IlInjected.Token(Token = "0x60000FC")]
			[Cpp2IlInjected.Address(RVA = "0x12E4BE0", Offset = "0x12E3FE0", VA = "0x1812E4BE0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000062")]
		public string RankingContext
		{
			[Cpp2IlInjected.Token(Token = "0x60000FD")]
			[Cpp2IlInjected.Address(RVA = "0xAAD040", Offset = "0xAAC440", VA = "0x180AAD040", Slot = "21")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60000FE")]
			[Cpp2IlInjected.Address(RVA = "0xAAC9D0", Offset = "0xAABDD0", VA = "0x180AAC9D0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000063")]
		public int OutfitType
		{
			[Cpp2IlInjected.Token(Token = "0x60000FF")]
			[Cpp2IlInjected.Address(RVA = "0xC825B0", Offset = "0xC819B0", VA = "0x180C825B0", Slot = "42")]
			[CompilerGenerated]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x6000100")]
			[Cpp2IlInjected.Address(RVA = "0x131AC60", Offset = "0x131A060", VA = "0x18131AC60")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000064")]
		public IReadOnlyList<CustomAvatarItemSaveDTO> CurrentSaves
		{
			[Cpp2IlInjected.Token(Token = "0x6000101")]
			[Cpp2IlInjected.Address(RVA = "0xAD3CC0", Offset = "0xAD30C0", VA = "0x180AD3CC0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000102")]
			[Cpp2IlInjected.Address(RVA = "0xCA6670", Offset = "0xCA5A70", VA = "0x180CA6670")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000065")]
		public IReadOnlyList<BNXSVKWEAOZ> Saves
		{
			[Cpp2IlInjected.Token(Token = "0x6000103")]
			[Cpp2IlInjected.Address(RVA = "0xAD3CC0", Offset = "0xAD30C0", VA = "0x180AD3CC0", Slot = "36")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000066")]
		public ItemPurchaseInfoDTO PurchaseInfo
		{
			[Cpp2IlInjected.Token(Token = "0x6000104")]
			[Cpp2IlInjected.Address(RVA = "0xAAC9C0", Offset = "0xAABDC0", VA = "0x180AAC9C0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000105")]
			[Cpp2IlInjected.Address(RVA = "0xAAC960", Offset = "0xAABD60", VA = "0x180AAC960")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000067")]
		public string RankedEntityId
		{
			[Cpp2IlInjected.Token(Token = "0x6000106")]
			[Cpp2IlInjected.Address(RVA = "0x7715B70", Offset = "0x7714F70", VA = "0x187715B70", Slot = "23")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000068")]
		public UnifiedItemType ItemType
		{
			[Cpp2IlInjected.Token(Token = "0x600010B")]
			[Cpp2IlInjected.Address(RVA = "0xB4FBD0", Offset = "0xB4EFD0", VA = "0x180B4FBD0", Slot = "24")]
			get
			{
				return default(UnifiedItemType);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000069")]
		public string Id
		{
			[Cpp2IlInjected.Token(Token = "0x600010C")]
			[Cpp2IlInjected.Address(RVA = "0x7715B70", Offset = "0x7714F70", VA = "0x187715B70", Slot = "25")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700006A")]
		public string FriendlyName
		{
			[Cpp2IlInjected.Token(Token = "0x600010D")]
			[Cpp2IlInjected.Address(RVA = "0xAAA820", Offset = "0xAA9C20", VA = "0x180AAA820", Slot = "26")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700006B")]
		public bool SubscribersOnly
		{
			[Cpp2IlInjected.Token(Token = "0x600010E")]
			[Cpp2IlInjected.Address(RVA = "0xAED770", Offset = "0xAECB70", VA = "0x180AED770", Slot = "29")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700006C")]
		public GiftRarity Rarity
		{
			[Cpp2IlInjected.Token(Token = "0x600010F")]
			[Cpp2IlInjected.Address(RVA = "0xAF3EB0", Offset = "0xAF32B0", VA = "0x180AF3EB0", Slot = "30")]
			get
			{
				return default(GiftRarity);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700006D")]
		public string ConsumableItemDesc
		{
			[Cpp2IlInjected.Token(Token = "0x6000110")]
			[Cpp2IlInjected.Address(RVA = "0xAA4920", Offset = "0xAA3D20", VA = "0x180AA4920", Slot = "31")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700006E")]
		public AvatarItemType? AvatarItemType
		{
			[Cpp2IlInjected.Token(Token = "0x6000111")]
			[Cpp2IlInjected.Address(RVA = "0x7715B20", Offset = "0x7714F20", VA = "0x187715B20", Slot = "32")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700006F")]
		public GiftBoxContents GiftBoxContent
		{
			[Cpp2IlInjected.Token(Token = "0x6000112")]
			[Cpp2IlInjected.Address(RVA = "0xB4FBD0", Offset = "0xB4EFD0", VA = "0x180B4FBD0", Slot = "33")]
			get
			{
				return default(GiftBoxContents);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000070")]
		public bool IsQueryGiftDrop
		{
			[Cpp2IlInjected.Token(Token = "0x6000113")]
			[Cpp2IlInjected.Address(RVA = "0xAED770", Offset = "0xAECB70", VA = "0x180AED770", Slot = "34")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000107")]
		[Cpp2IlInjected.Address(RVA = "0xAAC8E0", Offset = "0xAABCE0", VA = "0x180AAC8E0")]
		public CustomAvatarItem()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000108")]
		[Cpp2IlInjected.Address(RVA = "0xE21890", Offset = "0xE20C90", VA = "0x180E21890")]
		public CustomAvatarItem([Optional] Guid customAvatarItemId)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000109")]
		[Cpp2IlInjected.Address(RVA = "0x7715A50", Offset = "0x7714E50", VA = "0x187715A50", Slot = "35")]
		[AsyncStateMachine(typeof(<OnDeserializedAsync>d__86))]
		public Task NLICNVNCYRU()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600010A")]
		[Cpp2IlInjected.Address(RVA = "0x77159D0", Offset = "0x7714DD0", VA = "0x1877159D0")]
		public CustomAvatarItem Copy()
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000026")]
	[Utf8JsonSerializable]
	public class CustomAvatarItemCreateRequest
	{
		[Cpp2IlInjected.Token(Token = "0x17000071")]
		public string Name
		{
			[Cpp2IlInjected.Token(Token = "0x6000116")]
			[Cpp2IlInjected.Address(RVA = "0xAA5FB0", Offset = "0xAA53B0", VA = "0x180AA5FB0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000117")]
			[Cpp2IlInjected.Address(RVA = "0xAA5FC0", Offset = "0xAA53C0", VA = "0x180AA5FC0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000072")]
		public string Description
		{
			[Cpp2IlInjected.Token(Token = "0x6000118")]
			[Cpp2IlInjected.Address(RVA = "0xAAA880", Offset = "0xAA9C80", VA = "0x180AAA880")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000119")]
			[Cpp2IlInjected.Address(RVA = "0xAAA120", Offset = "0xAA9520", VA = "0x180AAA120")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000073")]
		public int Price
		{
			[Cpp2IlInjected.Token(Token = "0x600011A")]
			[Cpp2IlInjected.Address(RVA = "0xAB5660", Offset = "0xAB4A60", VA = "0x180AB5660")]
			[CompilerGenerated]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x600011B")]
			[Cpp2IlInjected.Address(RVA = "0xB07AB0", Offset = "0xB06EB0", VA = "0x180B07AB0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000074")]
		public int? BaseAvatarItemId
		{
			[Cpp2IlInjected.Token(Token = "0x600011C")]
			[Cpp2IlInjected.Address(RVA = "0x10D2A90", Offset = "0x10D1E90", VA = "0x1810D2A90")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600011D")]
			[Cpp2IlInjected.Address(RVA = "0xDB0160", Offset = "0xDAF560", VA = "0x180DB0160")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000075")]
		public string BaseAvatarItemColor
		{
			[Cpp2IlInjected.Token(Token = "0x600011E")]
			[Cpp2IlInjected.Address(RVA = "0xAAA140", Offset = "0xAA9540", VA = "0x180AAA140")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600011F")]
			[Cpp2IlInjected.Address(RVA = "0xAADB00", Offset = "0xAACF00", VA = "0x180AADB00")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000076")]
		public UgcAccessibility Accessibility
		{
			[Cpp2IlInjected.Token(Token = "0x6000120")]
			[Cpp2IlInjected.Address(RVA = "0xAD4020", Offset = "0xAD3420", VA = "0x180AD4020")]
			[CompilerGenerated]
			get
			{
				return default(UgcAccessibility);
			}
			[Cpp2IlInjected.Token(Token = "0x6000121")]
			[Cpp2IlInjected.Address(RVA = "0xB10400", Offset = "0xB0F800", VA = "0x180B10400")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000077")]
		public CustomAvatarItemPreviewOrientation? PreviewOrientation
		{
			[Cpp2IlInjected.Token(Token = "0x6000122")]
			[Cpp2IlInjected.Address(RVA = "0xAF1410", Offset = "0xAF0810", VA = "0x180AF1410")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000123")]
			[Cpp2IlInjected.Address(RVA = "0xAF1420", Offset = "0xAF0820", VA = "0x180AF1420")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000124")]
		[Cpp2IlInjected.Address(RVA = "0xAAC8E0", Offset = "0xAABCE0", VA = "0x180AAC8E0")]
		public CustomAvatarItemCreateRequest()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000027")]
	[Utf8JsonSerializable]
	public class CustomAvatarItemDesign
	{
		[Cpp2IlInjected.Token(Token = "0x17000078")]
		public int CreatorAccountId
		{
			[Cpp2IlInjected.Token(Token = "0x6000125")]
			[Cpp2IlInjected.Address(RVA = "0xAA3110", Offset = "0xAA2510", VA = "0x180AA3110")]
			[CompilerGenerated]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x6000126")]
			[Cpp2IlInjected.Address(RVA = "0xAAB1D0", Offset = "0xAAA5D0", VA = "0x180AAB1D0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000079")]
		public int? BaseAvatarItemId
		{
			[Cpp2IlInjected.Token(Token = "0x6000127")]
			[Cpp2IlInjected.Address(RVA = "0x10D2A50", Offset = "0x10D1E50", VA = "0x1810D2A50")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000128")]
			[Cpp2IlInjected.Address(RVA = "0x10D3E30", Offset = "0x10D3230", VA = "0x1810D3E30")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700007A")]
		public string DesignFilename
		{
			[Cpp2IlInjected.Token(Token = "0x6000129")]
			[Cpp2IlInjected.Address(RVA = "0xAAB1C0", Offset = "0xAAA5C0", VA = "0x180AAB1C0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600012A")]
			[Cpp2IlInjected.Address(RVA = "0xAA67C0", Offset = "0xAA5BC0", VA = "0x180AA67C0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700007B")]
		public string BaseAvatarItemColor
		{
			[Cpp2IlInjected.Token(Token = "0x600012B")]
			[Cpp2IlInjected.Address(RVA = "0xAAA820", Offset = "0xAA9C20", VA = "0x180AAA820")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600012C")]
			[Cpp2IlInjected.Address(RVA = "0xAA67D0", Offset = "0xAA5BD0", VA = "0x180AA67D0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600012D")]
		[Cpp2IlInjected.Address(RVA = "0xAAC8E0", Offset = "0xAABCE0", VA = "0x180AAC8E0")]
		public CustomAvatarItemDesign()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000028")]
	[Utf8JsonSerializable]
	public class CustomAvatarItemDesignRequest
	{
		[Cpp2IlInjected.Token(Token = "0x1700007C")]
		public int? BaseAvatarItemId
		{
			[Cpp2IlInjected.Token(Token = "0x600012E")]
			[Cpp2IlInjected.Address(RVA = "0xAA5FB0", Offset = "0xAA53B0", VA = "0x180AA5FB0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600012F")]
			[Cpp2IlInjected.Address(RVA = "0xB96550", Offset = "0xB95950", VA = "0x180B96550")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700007D")]
		public string BaseAvatarItemColor
		{
			[Cpp2IlInjected.Token(Token = "0x6000130")]
			[Cpp2IlInjected.Address(RVA = "0xAAA880", Offset = "0xAA9C80", VA = "0x180AAA880")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000131")]
			[Cpp2IlInjected.Address(RVA = "0xAAA120", Offset = "0xAA9520", VA = "0x180AAA120")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000132")]
		[Cpp2IlInjected.Address(RVA = "0xAAC8E0", Offset = "0xAABCE0", VA = "0x180AAC8E0")]
		public CustomAvatarItemDesignRequest()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000029")]
	public struct CustomAvatarItemPricingConfig
	{
		[Cpp2IlInjected.Token(Token = "0x4000088")]
		public static int DEFAULT_MIN_TOKEN_PRICE;

		[Cpp2IlInjected.Token(Token = "0x4000089")]
		public static int DEFAULT_MAX_TOKEN_PRICE;

		[Cpp2IlInjected.Token(Token = "0x1700007E")]
		public int MinimumPrice
		{
			[Cpp2IlInjected.Token(Token = "0x6000133")]
			[Cpp2IlInjected.Address(RVA = "0xC6C430", Offset = "0xC6B830", VA = "0x180C6C430")]
			[CompilerGenerated]
			readonly get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x6000134")]
			[Cpp2IlInjected.Address(RVA = "0x12A3E30", Offset = "0x12A3230", VA = "0x1812A3E30")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700007F")]
		public int MaximumPrice
		{
			[Cpp2IlInjected.Token(Token = "0x6000135")]
			[Cpp2IlInjected.Address(RVA = "0x2DAC240", Offset = "0x2DAB640", VA = "0x182DAC240")]
			[CompilerGenerated]
			readonly get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x6000136")]
			[Cpp2IlInjected.Address(RVA = "0x2DAC250", Offset = "0x2DAB650", VA = "0x182DAC250")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000080")]
		public static CustomAvatarItemPricingConfig VDDQACCVTOD
		{
			[Cpp2IlInjected.Token(Token = "0x6000138")]
			[Cpp2IlInjected.Address(RVA = "0x77156D0", Offset = "0x7714AD0", VA = "0x1877156D0")]
			get
			{
				return default(CustomAvatarItemPricingConfig);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000137")]
		[Cpp2IlInjected.Address(RVA = "0x7715780", Offset = "0x7714B80", VA = "0x187715780")]
		public CustomAvatarItemPricingConfig(int minimumTokenPrice, int maximumTokenPrice)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200002A")]
	[Utf8JsonSerializable]
	public class CustomAvatarItemPricingConfigDTO
	{
		[Cpp2IlInjected.Token(Token = "0x17000081")]
		public int MinimumPriceInTokens
		{
			[Cpp2IlInjected.Token(Token = "0x600013A")]
			[Cpp2IlInjected.Address(RVA = "0xAA3110", Offset = "0xAA2510", VA = "0x180AA3110")]
			[CompilerGenerated]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x600013B")]
			[Cpp2IlInjected.Address(RVA = "0xAAB1D0", Offset = "0xAAA5D0", VA = "0x180AAB1D0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000082")]
		public int MaximumPriceInTokens
		{
			[Cpp2IlInjected.Token(Token = "0x600013C")]
			[Cpp2IlInjected.Address(RVA = "0xC4E2B0", Offset = "0xC4D6B0", VA = "0x180C4E2B0")]
			[CompilerGenerated]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x600013D")]
			[Cpp2IlInjected.Address(RVA = "0xCDF260", Offset = "0xCDE660", VA = "0x180CDF260")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600013E")]
		[Cpp2IlInjected.Address(RVA = "0xAAC8E0", Offset = "0xAABCE0", VA = "0x180AAC8E0")]
		public CustomAvatarItemPricingConfigDTO()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200002B")]
	[Utf8JsonSerializable]
	public class CustomAvatarItemPurchaseRequest
	{
		[Cpp2IlInjected.Token(Token = "0x17000083")]
		public int RequestedPrice
		{
			[Cpp2IlInjected.Token(Token = "0x600013F")]
			[Cpp2IlInjected.Address(RVA = "0xAA3110", Offset = "0xAA2510", VA = "0x180AA3110")]
			[CompilerGenerated]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x6000140")]
			[Cpp2IlInjected.Address(RVA = "0xAAB1D0", Offset = "0xAAA5D0", VA = "0x180AAB1D0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000084")]
		public int? RecipientAccountId
		{
			[Cpp2IlInjected.Token(Token = "0x6000141")]
			[Cpp2IlInjected.Address(RVA = "0x10D2A50", Offset = "0x10D1E50", VA = "0x1810D2A50")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000142")]
			[Cpp2IlInjected.Address(RVA = "0x10D3E30", Offset = "0x10D3230", VA = "0x1810D3E30")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000085")]
		public string? Message
		{
			[Cpp2IlInjected.Token(Token = "0x6000143")]
			[Cpp2IlInjected.Address(RVA = "0xAAB1C0", Offset = "0xAAA5C0", VA = "0x180AAB1C0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000144")]
			[Cpp2IlInjected.Address(RVA = "0xAA67C0", Offset = "0xAA5BC0", VA = "0x180AA67C0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000145")]
		[Cpp2IlInjected.Address(RVA = "0x77157E0", Offset = "0x7714BE0", VA = "0x1877157E0")]
		public CustomAvatarItemPurchaseRequest(int requestedPrice, int? recipientAccountId, string? message)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000146")]
		[Cpp2IlInjected.Address(RVA = "0xAAC8E0", Offset = "0xAABCE0", VA = "0x180AAC8E0")]
		public CustomAvatarItemPurchaseRequest()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200002C")]
	[Utf8JsonSerializable]
	public class CustomAvatarItemReportRequest
	{
		[Cpp2IlInjected.Token(Token = "0x17000086")]
		public OYNLQAKUMPM.UgcReportCategory ReportCategory
		{
			[Cpp2IlInjected.Token(Token = "0x6000147")]
			[Cpp2IlInjected.Address(RVA = "0xAA3110", Offset = "0xAA2510", VA = "0x180AA3110")]
			[CompilerGenerated]
			get
			{
				return default(OYNLQAKUMPM.UgcReportCategory);
			}
			[Cpp2IlInjected.Token(Token = "0x6000148")]
			[Cpp2IlInjected.Address(RVA = "0xAAB1D0", Offset = "0xAAA5D0", VA = "0x180AAB1D0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000087")]
		public string Details
		{
			[Cpp2IlInjected.Token(Token = "0x6000149")]
			[Cpp2IlInjected.Address(RVA = "0xAAA880", Offset = "0xAA9C80", VA = "0x180AAA880")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600014A")]
			[Cpp2IlInjected.Address(RVA = "0xAAA120", Offset = "0xAA9520", VA = "0x180AAA120")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000088")]
		public int? ReportedPlayerId
		{
			[Cpp2IlInjected.Token(Token = "0x600014B")]
			[Cpp2IlInjected.Address(RVA = "0xAAB1C0", Offset = "0xAAA5C0", VA = "0x180AAB1C0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600014C")]
			[Cpp2IlInjected.Address(RVA = "0xB30430", Offset = "0xB2F830", VA = "0x180B30430")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600014D")]
		[Cpp2IlInjected.Address(RVA = "0xAAC8E0", Offset = "0xAABCE0", VA = "0x180AAC8E0")]
		public CustomAvatarItemReportRequest()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200002D")]
	public interface BNXSVKWEAOZ
	{
		[Cpp2IlInjected.Token(Token = "0x17000089")]
		long CustomAvatarItemSaveId
		{
			[Cpp2IlInjected.Token(Token = "0x600014F")]
			[Cpp2IlInjected.Address(Slot = "1")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x1700008A")]
		Guid CustomAvatarItemId
		{
			[Cpp2IlInjected.Token(Token = "0x6000150")]
			[Cpp2IlInjected.Address(Slot = "2")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x1700008B")]
		Guid UnityAssetId
		{
			[Cpp2IlInjected.Token(Token = "0x6000151")]
			[Cpp2IlInjected.Address(Slot = "3")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x1700008C")]
		string ThumbnailFileName
		{
			[Cpp2IlInjected.Token(Token = "0x6000152")]
			[Cpp2IlInjected.Address(Slot = "4")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x1700008D")]
		string AdditionalConfiguration
		{
			[Cpp2IlInjected.Token(Token = "0x6000153")]
			[Cpp2IlInjected.Address(Slot = "5")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x1700008E")]
		int BodyType
		{
			[Cpp2IlInjected.Token(Token = "0x6000154")]
			[Cpp2IlInjected.Address(Slot = "6")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x1700008F")]
		string UnityAsset
		{
			[Cpp2IlInjected.Token(Token = "0x6000155")]
			[Cpp2IlInjected.Address(Slot = "7")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000090")]
		string UnityAssetHash
		{
			[Cpp2IlInjected.Token(Token = "0x6000156")]
			[Cpp2IlInjected.Address(Slot = "8")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000091")]
		string UnityAsset2
		{
			[Cpp2IlInjected.Token(Token = "0x6000157")]
			[Cpp2IlInjected.Address(Slot = "9")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000092")]
		string UnityAsset2Hash
		{
			[Cpp2IlInjected.Token(Token = "0x6000158")]
			[Cpp2IlInjected.Address(Slot = "10")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000093")]
		int OutfitType
		{
			[Cpp2IlInjected.Token(Token = "0x6000159")]
			[Cpp2IlInjected.Address(Slot = "11")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x600014E")]
		[Cpp2IlInjected.Address(Slot = "0")]
		BNXSVKWEAOZ Clone([Optional] int? bodyTypeOverride);
	}
	[Cpp2IlInjected.Token(Token = "0x200002E")]
	[Utf8JsonSerializable]
	public class CustomAvatarItemSaveDTO : BNXSVKWEAOZ
	{
		[Cpp2IlInjected.Token(Token = "0x17000094")]
		public long CustomAvatarItemSaveId
		{
			[Cpp2IlInjected.Token(Token = "0x600015A")]
			[Cpp2IlInjected.Address(RVA = "0xAA5FB0", Offset = "0xAA53B0", VA = "0x180AA5FB0", Slot = "5")]
			[CompilerGenerated]
			get
			{
				return default(long);
			}
			[Cpp2IlInjected.Token(Token = "0x600015B")]
			[Cpp2IlInjected.Address(RVA = "0xB96550", Offset = "0xB95950", VA = "0x180B96550")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000095")]
		public Guid CustomAvatarItemId
		{
			[Cpp2IlInjected.Token(Token = "0x600015C")]
			[Cpp2IlInjected.Address(RVA = "0xC66740", Offset = "0xC65B40", VA = "0x180C66740", Slot = "6")]
			[CompilerGenerated]
			get
			{
				return default(Guid);
			}
			[Cpp2IlInjected.Token(Token = "0x600015D")]
			[Cpp2IlInjected.Address(RVA = "0xC66840", Offset = "0xC65C40", VA = "0x180C66840")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000096")]
		public Guid UnityAssetId
		{
			[Cpp2IlInjected.Token(Token = "0x600015E")]
			[Cpp2IlInjected.Address(RVA = "0x1146260", Offset = "0x1145660", VA = "0x181146260", Slot = "7")]
			[CompilerGenerated]
			get
			{
				return default(Guid);
			}
			[Cpp2IlInjected.Token(Token = "0x600015F")]
			[Cpp2IlInjected.Address(RVA = "0x128B750", Offset = "0x128AB50", VA = "0x18128B750")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000097")]
		public DateTime CreatedAt
		{
			[Cpp2IlInjected.Token(Token = "0x6000160")]
			[Cpp2IlInjected.Address(RVA = "0xAAA030", Offset = "0xAA9430", VA = "0x180AAA030")]
			[CompilerGenerated]
			get
			{
				return default(DateTime);
			}
			[Cpp2IlInjected.Token(Token = "0x6000161")]
			[Cpp2IlInjected.Address(RVA = "0xAAF810", Offset = "0xAAEC10", VA = "0x180AAF810")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000098")]
		public string ThumbnailFileName
		{
			[Cpp2IlInjected.Token(Token = "0x6000162")]
			[Cpp2IlInjected.Address(RVA = "0xAAA810", Offset = "0xAA9C10", VA = "0x180AAA810", Slot = "8")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000163")]
			[Cpp2IlInjected.Address(RVA = "0xAAA840", Offset = "0xAA9C40", VA = "0x180AAA840")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000099")]
		public string AdditionalConfiguration
		{
			[Cpp2IlInjected.Token(Token = "0x6000164")]
			[Cpp2IlInjected.Address(RVA = "0xAAA160", Offset = "0xAA9560", VA = "0x180AAA160", Slot = "9")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000165")]
			[Cpp2IlInjected.Address(RVA = "0xAAA870", Offset = "0xAA9C70", VA = "0x180AAA870")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700009A")]
		public int BodyType
		{
			[Cpp2IlInjected.Token(Token = "0x6000166")]
			[Cpp2IlInjected.Address(RVA = "0xBB86C0", Offset = "0xBB7AC0", VA = "0x180BB86C0", Slot = "10")]
			[CompilerGenerated]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x6000167")]
			[Cpp2IlInjected.Address(RVA = "0x175B160", Offset = "0x175A560", VA = "0x18175B160")]
			[CompilerGenerated]
			internal set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700009B")]
		public string UnityAsset
		{
			[Cpp2IlInjected.Token(Token = "0x6000168")]
			[Cpp2IlInjected.Address(RVA = "0xAA3150", Offset = "0xAA2550", VA = "0x180AA3150", Slot = "11")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000169")]
			[Cpp2IlInjected.Address(RVA = "0xAA33A0", Offset = "0xAA27A0", VA = "0x180AA33A0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700009C")]
		public string UnityAssetHash
		{
			[Cpp2IlInjected.Token(Token = "0x600016A")]
			[Cpp2IlInjected.Address(RVA = "0xAA3380", Offset = "0xAA2780", VA = "0x180AA3380", Slot = "12")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600016B")]
			[Cpp2IlInjected.Address(RVA = "0xAA3130", Offset = "0xAA2530", VA = "0x180AA3130")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700009D")]
		public string UnityAsset2
		{
			[Cpp2IlInjected.Token(Token = "0x600016C")]
			[Cpp2IlInjected.Address(RVA = "0xAA3120", Offset = "0xAA2520", VA = "0x180AA3120", Slot = "13")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600016D")]
			[Cpp2IlInjected.Address(RVA = "0xAA3140", Offset = "0xAA2540", VA = "0x180AA3140")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700009E")]
		public string UnityAsset2Hash
		{
			[Cpp2IlInjected.Token(Token = "0x600016E")]
			[Cpp2IlInjected.Address(RVA = "0xAA5380", Offset = "0xAA4780", VA = "0x180AA5380", Slot = "14")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600016F")]
			[Cpp2IlInjected.Address(RVA = "0xAA5390", Offset = "0xAA4790", VA = "0x180AA5390")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700009F")]
		public int OutfitType
		{
			[Cpp2IlInjected.Token(Token = "0x6000170")]
			[Cpp2IlInjected.Address(RVA = "0xACB690", Offset = "0xACAA90", VA = "0x180ACB690", Slot = "15")]
			[CompilerGenerated]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x6000171")]
			[Cpp2IlInjected.Address(RVA = "0x12E4BE0", Offset = "0x12E3FE0", VA = "0x1812E4BE0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000172")]
		[Cpp2IlInjected.Address(RVA = "0x7715840", Offset = "0x7714C40", VA = "0x187715840", Slot = "4")]
		public BNXSVKWEAOZ Clone([Optional] int? bodyTypeOverride)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000173")]
		[Cpp2IlInjected.Address(RVA = "0xAAC8E0", Offset = "0xAABCE0", VA = "0x180AAC8E0")]
		public CustomAvatarItemSaveDTO()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200002F")]
	[Flags]
	public enum CustomAvatarItemTypeFlags
	{
		[Cpp2IlInjected.Token(Token = "0x40000A1")]
		None = 0,
		[Cpp2IlInjected.Token(Token = "0x40000A2")]
		Shirt = 1,
		[Cpp2IlInjected.Token(Token = "0x40000A3")]
		All = -1
	}
	[Cpp2IlInjected.Token(Token = "0x2000030")]
	public enum CustomAvatarItemSearchOrdering
	{
		[Cpp2IlInjected.Token(Token = "0x40000A5")]
		SearchScoreDescending,
		[Cpp2IlInjected.Token(Token = "0x40000A6")]
		HotScoreDescending,
		[Cpp2IlInjected.Token(Token = "0x40000A7")]
		Newest,
		[Cpp2IlInjected.Token(Token = "0x40000A8")]
		Oldest,
		[Cpp2IlInjected.Token(Token = "0x40000A9")]
		PriceAscending,
		[Cpp2IlInjected.Token(Token = "0x40000AA")]
		PriceDescending,
		[Cpp2IlInjected.Token(Token = "0x40000AB")]
		FeaturedFirst
	}
	[Cpp2IlInjected.Token(Token = "0x2000031")]
	public static class LKOJAQLZELF
	{
		[Cpp2IlInjected.Token(Token = "0x6000174")]
		[Cpp2IlInjected.Address(RVA = "0x7719E80", Offset = "0x7719280", VA = "0x187719E80")]
		public static int? HBFFEYGCYZT(CustomAvatarItemTypeFlags? a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000175")]
		[Cpp2IlInjected.Address(RVA = "0x7719F10", Offset = "0x7719310", VA = "0x187719F10")]
		public static int? RQUGALLNIFI(CustomAvatarItemSearchOrdering? a)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000032")]
	[Utf8JsonSerializable]
	public class CustomAvatarItemSet : DURPPUIUDDT
	{
		[Cpp2IlInjected.Token(Token = "0x170000A0")]
		public string Name
		{
			[Cpp2IlInjected.Token(Token = "0x6000176")]
			[Cpp2IlInjected.Address(RVA = "0xAA5FB0", Offset = "0xAA53B0", VA = "0x180AA5FB0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000177")]
			[Cpp2IlInjected.Address(RVA = "0xAA5FC0", Offset = "0xAA53C0", VA = "0x180AA5FC0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000A1")]
		public long CreatorAccountId
		{
			[Cpp2IlInjected.Token(Token = "0x6000178")]
			[Cpp2IlInjected.Address(RVA = "0xAAA880", Offset = "0xAA9C80", VA = "0x180AAA880")]
			[CompilerGenerated]
			get
			{
				return default(long);
			}
			[Cpp2IlInjected.Token(Token = "0x6000179")]
			[Cpp2IlInjected.Address(RVA = "0x10BA780", Offset = "0x10B9B80", VA = "0x1810BA780")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000A2")]
		public List<CustomAvatarItem> CustomAvatarItems
		{
			[Cpp2IlInjected.Token(Token = "0x600017A")]
			[Cpp2IlInjected.Address(RVA = "0xAAB1C0", Offset = "0xAAA5C0", VA = "0x180AAB1C0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600017B")]
			[Cpp2IlInjected.Address(RVA = "0xAA67C0", Offset = "0xAA5BC0", VA = "0x180AA67C0")]
			[CompilerGenerated]
			internal set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600017C")]
		[Cpp2IlInjected.Address(RVA = "0x7715900", Offset = "0x7714D00", VA = "0x187715900", Slot = "4")]
		public Task NLICNVNCYRU()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600017D")]
		[Cpp2IlInjected.Address(RVA = "0xAAC8E0", Offset = "0xAABCE0", VA = "0x180AAC8E0")]
		public CustomAvatarItemSet()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000033")]
	[Utf8JsonSerializable]
	public class CustomAvatarItemUpdateRequest
	{
		[Cpp2IlInjected.Token(Token = "0x170000A3")]
		public string Name
		{
			[Cpp2IlInjected.Token(Token = "0x600017E")]
			[Cpp2IlInjected.Address(RVA = "0xAA5FB0", Offset = "0xAA53B0", VA = "0x180AA5FB0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600017F")]
			[Cpp2IlInjected.Address(RVA = "0xAA5FC0", Offset = "0xAA53C0", VA = "0x180AA5FC0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000A4")]
		public string Description
		{
			[Cpp2IlInjected.Token(Token = "0x6000180")]
			[Cpp2IlInjected.Address(RVA = "0xAAA880", Offset = "0xAA9C80", VA = "0x180AAA880")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000181")]
			[Cpp2IlInjected.Address(RVA = "0xAAA120", Offset = "0xAA9520", VA = "0x180AAA120")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000A5")]
		public int? Price
		{
			[Cpp2IlInjected.Token(Token = "0x6000182")]
			[Cpp2IlInjected.Address(RVA = "0xAAB1C0", Offset = "0xAAA5C0", VA = "0x180AAB1C0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000183")]
			[Cpp2IlInjected.Address(RVA = "0xB30430", Offset = "0xB2F830", VA = "0x180B30430")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000A6")]
		public UgcAccessibility? Accessibility
		{
			[Cpp2IlInjected.Token(Token = "0x6000184")]
			[Cpp2IlInjected.Address(RVA = "0xAAA820", Offset = "0xAA9C20", VA = "0x180AAA820")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000185")]
			[Cpp2IlInjected.Address(RVA = "0xAAA000", Offset = "0xAA9400", VA = "0x180AAA000")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000186")]
		[Cpp2IlInjected.Address(RVA = "0xAAC8E0", Offset = "0xAABCE0", VA = "0x180AAC8E0")]
		public CustomAvatarItemUpdateRequest()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000034")]
	[Utf8JsonSerializable]
	public class CustomAvatarItemVisualData
	{
		[Cpp2IlInjected.Token(Token = "0x170000A7")]
		public Guid CustomAvatarItemId
		{
			[Cpp2IlInjected.Token(Token = "0x6000187")]
			[Cpp2IlInjected.Address(RVA = "0xBAF500", Offset = "0xBAE900", VA = "0x180BAF500")]
			[CompilerGenerated]
			get
			{
				return default(Guid);
			}
			[Cpp2IlInjected.Token(Token = "0x6000188")]
			[Cpp2IlInjected.Address(RVA = "0xBAF520", Offset = "0xBAE920", VA = "0x180BAF520")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000A8")]
		public byte BodyPart
		{
			[Cpp2IlInjected.Token(Token = "0x6000189")]
			[Cpp2IlInjected.Address(RVA = "0xAAA010", Offset = "0xAA9410", VA = "0x180AAA010")]
			[CompilerGenerated]
			get
			{
				return default(byte);
			}
			[Cpp2IlInjected.Token(Token = "0x600018A")]
			[Cpp2IlInjected.Address(RVA = "0xAAA830", Offset = "0xAA9C30", VA = "0x180AAA830")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600018B")]
		[Cpp2IlInjected.Address(RVA = "0xAAC8E0", Offset = "0xAABCE0", VA = "0x180AAC8E0")]
		public CustomAvatarItemVisualData()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000035")]
	public static class ZCKKBHRHPXX
	{
		[Cpp2IlInjected.Token(Token = "0x600018C")]
		[Cpp2IlInjected.Address(RVA = "0x7720660", Offset = "0x771FA60", VA = "0x187720660")]
		public static OutfitSelectionDTO CEVTQLFHAEC(this CustomAvatarItemVisualData a)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000036")]
	public interface EOJDXCFUAXC
	{
		[Cpp2IlInjected.Token(Token = "0x170000A9")]
		Guid CustomAvatarItemId
		{
			[Cpp2IlInjected.Token(Token = "0x600018D")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x170000AA")]
		int CreatorAccountId
		{
			[Cpp2IlInjected.Token(Token = "0x600018E")]
			[Cpp2IlInjected.Address(Slot = "1")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x170000AB")]
		string Name
		{
			[Cpp2IlInjected.Token(Token = "0x600018F")]
			[Cpp2IlInjected.Address(Slot = "2")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x170000AC")]
		string Description
		{
			[Cpp2IlInjected.Token(Token = "0x6000190")]
			[Cpp2IlInjected.Address(Slot = "3")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x170000AD")]
		int Price
		{
			[Cpp2IlInjected.Token(Token = "0x6000191")]
			[Cpp2IlInjected.Address(Slot = "4")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x170000AE")]
		UgcAccessibility Accessibility
		{
			[Cpp2IlInjected.Token(Token = "0x6000192")]
			[Cpp2IlInjected.Address(Slot = "5")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x170000AF")]
		bool ForceCannotPublish
		{
			[Cpp2IlInjected.Token(Token = "0x6000193")]
			[Cpp2IlInjected.Address(Slot = "6")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x170000B0")]
		bool IsFeatured
		{
			[Cpp2IlInjected.Token(Token = "0x6000194")]
			[Cpp2IlInjected.Address(Slot = "7")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x170000B1")]
		bool IsRecRoomApproved
		{
			[Cpp2IlInjected.Token(Token = "0x6000195")]
			[Cpp2IlInjected.Address(Slot = "8")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x170000B2")]
		int? BaseAvatarItemId
		{
			[Cpp2IlInjected.Token(Token = "0x6000196")]
			[Cpp2IlInjected.Address(Slot = "9")]
			get;
			[Cpp2IlInjected.Token(Token = "0x6000197")]
			[Cpp2IlInjected.Address(Slot = "10")]
			set;
		}

		[Cpp2IlInjected.Token(Token = "0x170000B3")]
		string BaseAvatarItemColor
		{
			[Cpp2IlInjected.Token(Token = "0x6000198")]
			[Cpp2IlInjected.Address(Slot = "11")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x170000B4")]
		string DesignFilename
		{
			[Cpp2IlInjected.Token(Token = "0x6000199")]
			[Cpp2IlInjected.Address(Slot = "12")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x170000B5")]
		string ThumbnailImageFilename
		{
			[Cpp2IlInjected.Token(Token = "0x600019A")]
			[Cpp2IlInjected.Address(Slot = "13")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x170000B6")]
		DateTime CreatedAt
		{
			[Cpp2IlInjected.Token(Token = "0x600019B")]
			[Cpp2IlInjected.Address(Slot = "14")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x170000B7")]
		DateTime ModifiedAt
		{
			[Cpp2IlInjected.Token(Token = "0x600019C")]
			[Cpp2IlInjected.Address(Slot = "15")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x170000B8")]
		CustomAvatarItemPreviewOrientation PreviewOrientation
		{
			[Cpp2IlInjected.Token(Token = "0x600019D")]
			[Cpp2IlInjected.Address(Slot = "16")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x170000B9")]
		string RankingContext
		{
			[Cpp2IlInjected.Token(Token = "0x600019E")]
			[Cpp2IlInjected.Address(Slot = "17")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x170000BA")]
		int OutfitType
		{
			[Cpp2IlInjected.Token(Token = "0x600019F")]
			[Cpp2IlInjected.Address(Slot = "18")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x170000BB")]
		string RankedEntityId
		{
			[Cpp2IlInjected.Token(Token = "0x60001A0")]
			[Cpp2IlInjected.Address(RVA = "0x7715C20", Offset = "0x7715020", VA = "0x187715C20", Slot = "19")]
			get
			{
				return null;
			}
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000037")]
	public interface OULJHHDVWBG
	{
		[Cpp2IlInjected.Token(Token = "0x170000BC")]
		IReadOnlyList<BNXSVKWEAOZ> Saves
		{
			[Cpp2IlInjected.Token(Token = "0x60001A1")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x170000BD")]
		Guid CustomAvatarItemId
		{
			[Cpp2IlInjected.Token(Token = "0x60001A2")]
			[Cpp2IlInjected.Address(Slot = "1")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x170000BE")]
		int CreatorAccountId
		{
			[Cpp2IlInjected.Token(Token = "0x60001A3")]
			[Cpp2IlInjected.Address(Slot = "2")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x170000BF")]
		string Name
		{
			[Cpp2IlInjected.Token(Token = "0x60001A4")]
			[Cpp2IlInjected.Address(Slot = "3")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x170000C0")]
		string Description
		{
			[Cpp2IlInjected.Token(Token = "0x60001A5")]
			[Cpp2IlInjected.Address(Slot = "4")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x170000C1")]
		bool IsRecRoomApproved
		{
			[Cpp2IlInjected.Token(Token = "0x60001A6")]
			[Cpp2IlInjected.Address(Slot = "5")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x170000C2")]
		int OutfitType
		{
			[Cpp2IlInjected.Token(Token = "0x60001A7")]
			[Cpp2IlInjected.Address(Slot = "6")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x170000C3")]
		int? BaseAvatarItemId
		{
			[Cpp2IlInjected.Token(Token = "0x60001A8")]
			[Cpp2IlInjected.Address(Slot = "7")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x170000C4")]
		UgcAccessibility Accessibility
		{
			[Cpp2IlInjected.Token(Token = "0x60001A9")]
			[Cpp2IlInjected.Address(Slot = "8")]
			get;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000038")]
	public static class ALEZVXPIRIA
	{
		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x200003A")]
		[CompilerGenerated]
		private struct <OnDeserializedAsync>d__1 : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000B7")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x40000B8")]
			public AsyncTaskMethodBuilder <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x40000B9")]
			public IEnumerable<DURPPUIUDDT> list;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x40000BA")]
			private ConfiguredTaskAwaitable.ConfiguredTaskAwaiter <>u__1;

			[Cpp2IlInjected.Token(Token = "0x60001AF")]
			[Cpp2IlInjected.Address(RVA = "0x771E700", Offset = "0x771DB00", VA = "0x18771E700", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001B0")]
			[Cpp2IlInjected.Address(RVA = "0x771E990", Offset = "0x771DD90", VA = "0x18771E990", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60001AA")]
		[Cpp2IlInjected.Address(RVA = "0x7712FF0", Offset = "0x77123F0", VA = "0x187712FF0")]
		public static bool NTJAWBDBXVU(this IEnumerable<ZTDEQBSEMSX> a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001AB")]
		[Cpp2IlInjected.Address(RVA = "0x7712F20", Offset = "0x7712320", VA = "0x187712F20")]
		[AsyncStateMachine(typeof(<OnDeserializedAsync>d__1))]
		public static Task NLICNVNCYRU(this IEnumerable<DURPPUIUDDT> a)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200003B")]
	public struct FilenameWithHash
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000BB")]
		public readonly string Filename;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40000BC")]
		public readonly string Hash;

		[Cpp2IlInjected.Token(Token = "0x40000BD")]
		public static readonly FilenameWithHash Null;

		[Cpp2IlInjected.Token(Token = "0x60001B1")]
		[Cpp2IlInjected.Address(RVA = "0xDDEE90", Offset = "0xDDE290", VA = "0x180DDEE90")]
		public FilenameWithHash(string filename, string hash)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001B2")]
		[Cpp2IlInjected.Address(RVA = "0x1126E30", Offset = "0x1126230", VA = "0x181126E30")]
		public bool Equals(FilenameWithHash other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001B3")]
		[Cpp2IlInjected.Address(RVA = "0x77166A0", Offset = "0x7715AA0", VA = "0x1877166A0", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001B4")]
		[Cpp2IlInjected.Address(RVA = "0x7716770", Offset = "0x7715B70", VA = "0x187716770", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[SpecialName]
		[Cpp2IlInjected.Token(Token = "0x60001B5")]
		[Cpp2IlInjected.Address(RVA = "0x7716860", Offset = "0x7715C60", VA = "0x187716860")]
		public static bool ZWISVWGZSLY(FilenameWithHash a, FilenameWithHash b)
		{
			return default(bool);
		}

		[SpecialName]
		[Cpp2IlInjected.Token(Token = "0x60001B6")]
		[Cpp2IlInjected.Address(RVA = "0x77167E0", Offset = "0x7715BE0", VA = "0x1877167E0")]
		public static bool ZPGHGHNXRJT(FilenameWithHash a, FilenameWithHash b)
		{
			return default(bool);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200003C")]
	public interface NFENRGVFLZN
	{
		[Cpp2IlInjected.Token(Token = "0x170000C5")]
		FILVSSXPISR ZRFAADGABRE
		{
			[Cpp2IlInjected.Token(Token = "0x60001B8")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x170000C6")]
		string IEFCXEODBAV
		{
			[Cpp2IlInjected.Token(Token = "0x60001B9")]
			[Cpp2IlInjected.Address(Slot = "1")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x170000C7")]
		string YJNYZEBVYGJ
		{
			[Cpp2IlInjected.Token(Token = "0x60001BA")]
			[Cpp2IlInjected.Address(Slot = "2")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x170000C8")]
		long QUNNQFKSXXM
		{
			[Cpp2IlInjected.Token(Token = "0x60001BB")]
			[Cpp2IlInjected.Address(Slot = "3")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x170000C9")]
		string IMXOJHNKKJS
		{
			[Cpp2IlInjected.Token(Token = "0x60001BC")]
			[Cpp2IlInjected.Address(Slot = "4")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x170000CA")]
		string EJSCIAFFFDR
		{
			[Cpp2IlInjected.Token(Token = "0x60001BD")]
			[Cpp2IlInjected.Address(Slot = "5")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x170000CB")]
		string FKJVJAFZNEZ
		{
			[Cpp2IlInjected.Token(Token = "0x60001BE")]
			[Cpp2IlInjected.Address(Slot = "6")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x170000CC")]
		string PRKUELDCUET
		{
			[Cpp2IlInjected.Token(Token = "0x60001BF")]
			[Cpp2IlInjected.Address(Slot = "7")]
			get;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200003D")]
	[Utf8JsonSerializable]
	public class ContentBlock : OZURRVRIAWL
	{
		[Cpp2IlInjected.Token(Token = "0x170000CD")]
		public string TrackingCategory
		{
			[Cpp2IlInjected.Token(Token = "0x60001C0")]
			[Cpp2IlInjected.Address(RVA = "0xAAA880", Offset = "0xAA9C80", VA = "0x180AAA880")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60001C1")]
			[Cpp2IlInjected.Address(RVA = "0xAAA120", Offset = "0xAA9520", VA = "0x180AAA120")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000CE")]
		public ContentBlockLayout Layout
		{
			[Cpp2IlInjected.Token(Token = "0x60001C2")]
			[Cpp2IlInjected.Address(RVA = "0xAB5660", Offset = "0xAB4A60", VA = "0x180AB5660")]
			[CompilerGenerated]
			get
			{
				return default(ContentBlockLayout);
			}
			[Cpp2IlInjected.Token(Token = "0x60001C3")]
			[Cpp2IlInjected.Address(RVA = "0xB07AB0", Offset = "0xB06EB0", VA = "0x180B07AB0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000CF")]
		public ContentBlockTextSize TextSize
		{
			[Cpp2IlInjected.Token(Token = "0x60001C4")]
			[Cpp2IlInjected.Address(RVA = "0xACC3D0", Offset = "0xACB7D0", VA = "0x180ACC3D0")]
			[CompilerGenerated]
			get
			{
				return default(ContentBlockTextSize);
			}
			[Cpp2IlInjected.Token(Token = "0x60001C5")]
			[Cpp2IlInjected.Address(RVA = "0xBE18B0", Offset = "0xBE0CB0", VA = "0x180BE18B0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000D0")]
		public ContentBlockTitlePlacement TitleTextPlacement
		{
			[Cpp2IlInjected.Token(Token = "0x60001C6")]
			[Cpp2IlInjected.Address(RVA = "0xAAB1A0", Offset = "0xAAA5A0", VA = "0x180AAB1A0")]
			[CompilerGenerated]
			get
			{
				return default(ContentBlockTitlePlacement);
			}
			[Cpp2IlInjected.Token(Token = "0x60001C7")]
			[Cpp2IlInjected.Address(RVA = "0xAAB1B0", Offset = "0xAAA5B0", VA = "0x180AAB1B0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000D1")]
		[DataMember(Name = "Header")]
		public string? HeaderOverride
		{
			[Cpp2IlInjected.Token(Token = "0x60001C8")]
			[Cpp2IlInjected.Address(RVA = "0xAAA140", Offset = "0xAA9540", VA = "0x180AAA140")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60001C9")]
			[Cpp2IlInjected.Address(RVA = "0xAADB00", Offset = "0xAACF00", VA = "0x180AADB00")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000D2")]
		public string? Title
		{
			[Cpp2IlInjected.Token(Token = "0x60001CA")]
			[Cpp2IlInjected.Address(RVA = "0xAAA030", Offset = "0xAA9430", VA = "0x180AAA030")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60001CB")]
			[Cpp2IlInjected.Address(RVA = "0xAAA110", Offset = "0xAA9510", VA = "0x180AAA110")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000D3")]
		public string? Body
		{
			[Cpp2IlInjected.Token(Token = "0x60001CC")]
			[Cpp2IlInjected.Address(RVA = "0xAAA810", Offset = "0xAA9C10", VA = "0x180AAA810")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60001CD")]
			[Cpp2IlInjected.Address(RVA = "0xAAA840", Offset = "0xAA9C40", VA = "0x180AAA840")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000D4")]
		public List<string> ImageNames
		{
			[Cpp2IlInjected.Token(Token = "0x60001CE")]
			[Cpp2IlInjected.Address(RVA = "0xAAA160", Offset = "0xAA9560", VA = "0x180AAA160")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60001CF")]
			[Cpp2IlInjected.Address(RVA = "0xAAA870", Offset = "0xAA9C70", VA = "0x180AAA870")]
			[CompilerGenerated]
			internal set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000D5")]
		public List<ContentBlockButton> Buttons
		{
			[Cpp2IlInjected.Token(Token = "0x60001D0")]
			[Cpp2IlInjected.Address(RVA = "0xAA3370", Offset = "0xAA2770", VA = "0x180AA3370")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60001D1")]
			[Cpp2IlInjected.Address(RVA = "0xAA3390", Offset = "0xAA2790", VA = "0x180AA3390")]
			[CompilerGenerated]
			internal set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60001D2")]
		[Cpp2IlInjected.Address(RVA = "0x7715520", Offset = "0x7714920", VA = "0x187715520")]
		public ContentBlock()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200003E")]
	public enum ContentBlockLinkType
	{
		[Cpp2IlInjected.Token(Token = "0x40000C8")]
		Url,
		[Cpp2IlInjected.Token(Token = "0x40000C9")]
		AccountId,
		[Cpp2IlInjected.Token(Token = "0x40000CA")]
		EventId,
		[Cpp2IlInjected.Token(Token = "0x40000CB")]
		RoomName,
		[Cpp2IlInjected.Token(Token = "0x40000CC")]
		Storefront,
		[Cpp2IlInjected.Token(Token = "0x40000CD")]
		[Obsolete("6/4/21: This was only ever used for an announcement for Shawn's referral event, which is not happening again. Removing as part of a StackUI cleanup")]
		ActionCode,
		[Cpp2IlInjected.Token(Token = "0x40000CE")]
		Item,
		[Cpp2IlInjected.Token(Token = "0x40000CF")]
		CustomAvatarItem,
		[Cpp2IlInjected.Token(Token = "0x40000D0")]
		AuthorizedRecNetUrl,
		[Cpp2IlInjected.Token(Token = "0x40000D1")]
		Close
	}
	[Cpp2IlInjected.Token(Token = "0x200003F")]
	public enum ContentBlockLayout
	{
		[Cpp2IlInjected.Token(Token = "0x40000D3")]
		Default,
		[Cpp2IlInjected.Token(Token = "0x40000D4")]
		Vertical,
		[Cpp2IlInjected.Token(Token = "0x40000D5")]
		Horizontal
	}
	[Cpp2IlInjected.Token(Token = "0x2000040")]
	public enum ContentBlockTextSize
	{
		[Cpp2IlInjected.Token(Token = "0x40000D7")]
		Small,
		[Cpp2IlInjected.Token(Token = "0x40000D8")]
		Medium,
		[Cpp2IlInjected.Token(Token = "0x40000D9")]
		Large
	}
	[Cpp2IlInjected.Token(Token = "0x2000041")]
	public enum ContentBlockTitlePlacement
	{
		[Cpp2IlInjected.Token(Token = "0x40000DB")]
		Before,
		[Cpp2IlInjected.Token(Token = "0x40000DC")]
		Overlay,
		[Cpp2IlInjected.Token(Token = "0x40000DD")]
		After
	}
	[Cpp2IlInjected.Token(Token = "0x2000042")]
	[Utf8JsonSerializable]
	public class ContentBlockButton
	{
		[Cpp2IlInjected.Token(Token = "0x170000D6")]
		public ContentBlockLinkType LinkType
		{
			[Cpp2IlInjected.Token(Token = "0x60001D3")]
			[Cpp2IlInjected.Address(RVA = "0xAA3110", Offset = "0xAA2510", VA = "0x180AA3110")]
			[CompilerGenerated]
			get
			{
				return default(ContentBlockLinkType);
			}
			[Cpp2IlInjected.Token(Token = "0x60001D4")]
			[Cpp2IlInjected.Address(RVA = "0xAAB1D0", Offset = "0xAAA5D0", VA = "0x180AAB1D0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000D7")]
		public string? LinkName
		{
			[Cpp2IlInjected.Token(Token = "0x60001D5")]
			[Cpp2IlInjected.Address(RVA = "0xAAA880", Offset = "0xAA9C80", VA = "0x180AAA880")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60001D6")]
			[Cpp2IlInjected.Address(RVA = "0xAAA120", Offset = "0xAA9520", VA = "0x180AAA120")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000D8")]
		[DataMember(Name = "LinkParameter")]
		public string? LinkUriOrParameter
		{
			[Cpp2IlInjected.Token(Token = "0x60001D7")]
			[Cpp2IlInjected.Address(RVA = "0xAAB1C0", Offset = "0xAAA5C0", VA = "0x180AAB1C0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60001D8")]
			[Cpp2IlInjected.Address(RVA = "0xAA67C0", Offset = "0xAA5BC0", VA = "0x180AA67C0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000D9")]
		public string? LinkButtonLabel
		{
			[Cpp2IlInjected.Token(Token = "0x60001D9")]
			[Cpp2IlInjected.Address(RVA = "0xAAA820", Offset = "0xAA9C20", VA = "0x180AAA820")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60001DA")]
			[Cpp2IlInjected.Address(RVA = "0xAA67D0", Offset = "0xAA5BD0", VA = "0x180AA67D0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60001DB")]
		[Cpp2IlInjected.Address(RVA = "0xAAC8E0", Offset = "0xAABCE0", VA = "0x180AAC8E0")]
		public ContentBlockButton()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000043")]
	public abstract class OZURRVRIAWL
	{
		[Cpp2IlInjected.Token(Token = "0x170000DA")]
		[IgnoreDataMember]
		public string? ZIJGDJIXWAK
		{
			[Cpp2IlInjected.Token(Token = "0x60001DC")]
			[Cpp2IlInjected.Address(RVA = "0xAA5FB0", Offset = "0xAA53B0", VA = "0x180AA5FB0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60001DD")]
			[Cpp2IlInjected.Address(RVA = "0xAA5FC0", Offset = "0xAA53C0", VA = "0x180AA5FC0")]
			[CompilerGenerated]
			internal set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60001DE")]
		[Cpp2IlInjected.Address(RVA = "0x1198280", Offset = "0x1197680", VA = "0x181198280")]
		protected OZURRVRIAWL()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000044")]
	[Utf8JsonSerializable]
	public class InAppMessageIdDTO
	{
		[Cpp2IlInjected.Token(Token = "0x170000DB")]
		public string? MessageId
		{
			[Cpp2IlInjected.Token(Token = "0x60001DF")]
			[Cpp2IlInjected.Address(RVA = "0xAA5FB0", Offset = "0xAA53B0", VA = "0x180AA5FB0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60001E0")]
			[Cpp2IlInjected.Address(RVA = "0xAA5FC0", Offset = "0xAA53C0", VA = "0x180AA5FC0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60001E1")]
		[Cpp2IlInjected.Address(RVA = "0xAAC8E0", Offset = "0xAABCE0", VA = "0x180AAC8E0")]
		public InAppMessageIdDTO()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000045")]
	[Utf8JsonSerializable]
	public class InAppMessageDTO : ZTDEQBSEMSX
	{
		[Cpp2IlInjected.Token(Token = "0x40000E4")]
		internal static Func<string, ContentBlock>? KHTGJJJGVRV;

		[Cpp2IlInjected.Token(Token = "0x40000E5")]
		internal static Func<string, JustInTimeTutorialTrigger>? CFBTTLGKQXV;

		[Cpp2IlInjected.Token(Token = "0x170000DC")]
		public string? MessageId
		{
			[Cpp2IlInjected.Token(Token = "0x60001E2")]
			[Cpp2IlInjected.Address(RVA = "0xAA5FB0", Offset = "0xAA53B0", VA = "0x180AA5FB0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60001E3")]
			[Cpp2IlInjected.Address(RVA = "0xAA5FC0", Offset = "0xAA53C0", VA = "0x180AA5FC0")]
			[CompilerGenerated]
			internal set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000DD")]
		public string? SenderMessageId
		{
			[Cpp2IlInjected.Token(Token = "0x60001E4")]
			[Cpp2IlInjected.Address(RVA = "0xAAA880", Offset = "0xAA9C80", VA = "0x180AAA880")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60001E5")]
			[Cpp2IlInjected.Address(RVA = "0xAAA120", Offset = "0xAA9520", VA = "0x180AAA120")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000DE")]
		public bool IsBroadcast
		{
			[Cpp2IlInjected.Token(Token = "0x60001E6")]
			[Cpp2IlInjected.Address(RVA = "0xAAA010", Offset = "0xAA9410", VA = "0x180AAA010")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x60001E7")]
			[Cpp2IlInjected.Address(RVA = "0xAAA830", Offset = "0xAA9C30", VA = "0x180AAA830")]
			[CompilerGenerated]
			internal set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000DF")]
		public PlatformType Platform
		{
			[Cpp2IlInjected.Token(Token = "0x60001E8")]
			[Cpp2IlInjected.Address(RVA = "0xACC3D0", Offset = "0xACB7D0", VA = "0x180ACC3D0")]
			[CompilerGenerated]
			get
			{
				return default(PlatformType);
			}
			[Cpp2IlInjected.Token(Token = "0x60001E9")]
			[Cpp2IlInjected.Address(RVA = "0xBE18B0", Offset = "0xBE0CB0", VA = "0x180BE18B0")]
			[CompilerGenerated]
			internal set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000E0")]
		public PlatformMask PlatformTypeMask
		{
			[Cpp2IlInjected.Token(Token = "0x60001EA")]
			[Cpp2IlInjected.Address(RVA = "0xAAB1A0", Offset = "0xAAA5A0", VA = "0x180AAB1A0")]
			[CompilerGenerated]
			get
			{
				return default(PlatformMask);
			}
			[Cpp2IlInjected.Token(Token = "0x60001EB")]
			[Cpp2IlInjected.Address(RVA = "0xAAB1B0", Offset = "0xAAA5B0", VA = "0x180AAB1B0")]
			[CompilerGenerated]
			internal set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000E1")]
		public int Priority
		{
			[Cpp2IlInjected.Token(Token = "0x60001EC")]
			[Cpp2IlInjected.Address(RVA = "0xC4E8F0", Offset = "0xC4DCF0", VA = "0x180C4E8F0")]
			[CompilerGenerated]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x60001ED")]
			[Cpp2IlInjected.Address(RVA = "0x1ACB200", Offset = "0x1ACA600", VA = "0x181ACB200")]
			[CompilerGenerated]
			internal set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000E2")]
		public DateTime SentAt
		{
			[Cpp2IlInjected.Token(Token = "0x60001EE")]
			[Cpp2IlInjected.Address(RVA = "0xAAA140", Offset = "0xAA9540", VA = "0x180AAA140")]
			[CompilerGenerated]
			get
			{
				return default(DateTime);
			}
			[Cpp2IlInjected.Token(Token = "0x60001EF")]
			[Cpp2IlInjected.Address(RVA = "0xAAA860", Offset = "0xAA9C60", VA = "0x180AAA860")]
			[CompilerGenerated]
			internal set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000E3")]
		[DataMember(Name = "IsRead")]
		internal bool KLUAIDTLYEV
		{
			[Cpp2IlInjected.Token(Token = "0x60001F0")]
			[Cpp2IlInjected.Address(RVA = "0xAD1790", Offset = "0xAD0B90", VA = "0x180AD1790")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x60001F1")]
			[Cpp2IlInjected.Address(RVA = "0xAD17A0", Offset = "0xAD0BA0", VA = "0x180AD17A0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000E4")]
		[IgnoreDataMember]
		public bool IsClientRead
		{
			[Cpp2IlInjected.Token(Token = "0x60001F2")]
			[Cpp2IlInjected.Address(RVA = "0x1813510", Offset = "0x1812910", VA = "0x181813510")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x60001F3")]
			[Cpp2IlInjected.Address(RVA = "0x18137D0", Offset = "0x1812BD0", VA = "0x1818137D0")]
			[CompilerGenerated]
			internal set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000E5")]
		public InAppMessageChannel Channel
		{
			[Cpp2IlInjected.Token(Token = "0x60001F4")]
			[Cpp2IlInjected.Address(RVA = "0xAE3BC0", Offset = "0xAE2FC0", VA = "0x180AE3BC0")]
			[CompilerGenerated]
			get
			{
				return default(InAppMessageChannel);
			}
			[Cpp2IlInjected.Token(Token = "0x60001F5")]
			[Cpp2IlInjected.Address(RVA = "0xAE34B0", Offset = "0xAE28B0", VA = "0x180AE34B0")]
			[CompilerGenerated]
			internal set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000E6")]
		public InAppMessageContentType ContentType
		{
			[Cpp2IlInjected.Token(Token = "0x60001F6")]
			[Cpp2IlInjected.Address(RVA = "0xAC1F70", Offset = "0xAC1370", VA = "0x180AC1F70")]
			[CompilerGenerated]
			get
			{
				return default(InAppMessageContentType);
			}
			[Cpp2IlInjected.Token(Token = "0x60001F7")]
			[Cpp2IlInjected.Address(RVA = "0xBDCB60", Offset = "0xBDBF60", VA = "0x180BDCB60")]
			[CompilerGenerated]
			internal set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000E7")]
		internal string? CWIMTPRYWAX
		{
			[Cpp2IlInjected.Token(Token = "0x60001F8")]
			[Cpp2IlInjected.Address(RVA = "0xAAA160", Offset = "0xAA9560", VA = "0x180AAA160")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60001F9")]
			[Cpp2IlInjected.Address(RVA = "0xAAA870", Offset = "0xAA9C70", VA = "0x180AAA870")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000E8")]
		[IgnoreDataMember]
		public ContentBlock? ContentBlock
		{
			[Cpp2IlInjected.Token(Token = "0x60001FA")]
			[Cpp2IlInjected.Address(RVA = "0x77185A0", Offset = "0x77179A0", VA = "0x1877185A0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000E9")]
		[IgnoreDataMember]
		public JustInTimeTutorialTrigger? JustInTimeTutorialTrigger
		{
			[Cpp2IlInjected.Token(Token = "0x60001FB")]
			[Cpp2IlInjected.Address(RVA = "0x7718630", Offset = "0x7717A30", VA = "0x187718630")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000EA")]
		[IgnoreDataMember]
		public OZURRVRIAWL? ContentObject
		{
			[Cpp2IlInjected.Token(Token = "0x60001FC")]
			[Cpp2IlInjected.Address(RVA = "0xAA3370", Offset = "0xAA2770", VA = "0x180AA3370")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60001FD")]
			[Cpp2IlInjected.Address(RVA = "0xAA3390", Offset = "0xAA2790", VA = "0x180AA3390")]
			[CompilerGenerated]
			internal set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60001FE")]
		[Cpp2IlInjected.Address(RVA = "0x77182F0", Offset = "0x77176F0", VA = "0x1877182F0", Slot = "4")]
		public void NTJAWBDBXVU()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001FF")]
		[Cpp2IlInjected.Address(RVA = "0xAD1960", Offset = "0xAD0D60", VA = "0x180AD1960")]
		public InAppMessageDTO()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000046")]
	[Utf8JsonSerializable]
	public class JustInTimeTutorialCondition
	{
		[Cpp2IlInjected.Token(Token = "0x170000EB")]
		public JustInTimeTutorialTrackable Trackable
		{
			[Cpp2IlInjected.Token(Token = "0x6000200")]
			[Cpp2IlInjected.Address(RVA = "0xAA3110", Offset = "0xAA2510", VA = "0x180AA3110")]
			[CompilerGenerated]
			get
			{
				return default(JustInTimeTutorialTrackable);
			}
			[Cpp2IlInjected.Token(Token = "0x6000201")]
			[Cpp2IlInjected.Address(RVA = "0xAAB1D0", Offset = "0xAAA5D0", VA = "0x180AAB1D0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000EC")]
		public string Room
		{
			[Cpp2IlInjected.Token(Token = "0x6000202")]
			[Cpp2IlInjected.Address(RVA = "0xAAA880", Offset = "0xAA9C80", VA = "0x180AAA880")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000203")]
			[Cpp2IlInjected.Address(RVA = "0xAAA120", Offset = "0xAA9520", VA = "0x180AAA120")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000ED")]
		public int Threshold
		{
			[Cpp2IlInjected.Token(Token = "0x6000204")]
			[Cpp2IlInjected.Address(RVA = "0xAB5660", Offset = "0xAB4A60", VA = "0x180AB5660")]
			[CompilerGenerated]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x6000205")]
			[Cpp2IlInjected.Address(RVA = "0xB07AB0", Offset = "0xB06EB0", VA = "0x180B07AB0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000206")]
		[Cpp2IlInjected.Address(RVA = "0x77196D0", Offset = "0x7718AD0", VA = "0x1877196D0")]
		public JustInTimeTutorialCondition()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000047")]
	[Utf8JsonSerializable]
	public class JustInTimeTutorialTrigger : OZURRVRIAWL
	{
		[Cpp2IlInjected.Token(Token = "0x170000EE")]
		public string Identifier
		{
			[Cpp2IlInjected.Token(Token = "0x6000207")]
			[Cpp2IlInjected.Address(RVA = "0xAAA880", Offset = "0xAA9C80", VA = "0x180AAA880")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000208")]
			[Cpp2IlInjected.Address(RVA = "0xAAA120", Offset = "0xAA9520", VA = "0x180AAA120")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000EF")]
		public string? Name
		{
			[Cpp2IlInjected.Token(Token = "0x6000209")]
			[Cpp2IlInjected.Address(RVA = "0xAAB1C0", Offset = "0xAAA5C0", VA = "0x180AAB1C0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600020A")]
			[Cpp2IlInjected.Address(RVA = "0xAA67C0", Offset = "0xAA5BC0", VA = "0x180AA67C0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000F0")]
		public JustInTimeTutorialAction Action
		{
			[Cpp2IlInjected.Token(Token = "0x600020B")]
			[Cpp2IlInjected.Address(RVA = "0xAAB1A0", Offset = "0xAAA5A0", VA = "0x180AAB1A0")]
			[CompilerGenerated]
			get
			{
				return default(JustInTimeTutorialAction);
			}
			[Cpp2IlInjected.Token(Token = "0x600020C")]
			[Cpp2IlInjected.Address(RVA = "0xAAB1B0", Offset = "0xAAA5B0", VA = "0x180AAB1B0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000F1")]
		[DataMember(Name = "all_conditions_required")]
		public bool AllConditionsRequired
		{
			[Cpp2IlInjected.Token(Token = "0x600020D")]
			[Cpp2IlInjected.Address(RVA = "0x17F0050", Offset = "0x17EF450", VA = "0x1817F0050")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x600020E")]
			[Cpp2IlInjected.Address(RVA = "0xD836D0", Offset = "0xD82AD0", VA = "0x180D836D0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000F2")]
		public List<JustInTimeTutorialCondition> Conditions
		{
			[Cpp2IlInjected.Token(Token = "0x600020F")]
			[Cpp2IlInjected.Address(RVA = "0xAAA140", Offset = "0xAA9540", VA = "0x180AAA140")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000210")]
			[Cpp2IlInjected.Address(RVA = "0xAADB00", Offset = "0xAACF00", VA = "0x180AADB00")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000211")]
		[Cpp2IlInjected.Address(RVA = "0x7719720", Offset = "0x7718B20", VA = "0x187719720")]
		public JustInTimeTutorialTrigger()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000048")]
	public enum InAppMessageContentType
	{
		[Cpp2IlInjected.Token(Token = "0x40000FC")]
		Unknown,
		[Cpp2IlInjected.Token(Token = "0x40000FD")]
		ContentBlock,
		[Cpp2IlInjected.Token(Token = "0x40000FE")]
		JustInTimeTutorialTrigger
	}
	[Cpp2IlInjected.Token(Token = "0x2000049")]
	public enum InAppMessageChannel
	{
		[Cpp2IlInjected.Token(Token = "0x4000100")]
		None,
		[Cpp2IlInjected.Token(Token = "0x4000101")]
		Announcements,
		[Cpp2IlInjected.Token(Token = "0x4000102")]
		JustInTimeTutorials
	}
	[Cpp2IlInjected.Token(Token = "0x200004A")]
	public enum JustInTimeTutorialAction
	{
		[Cpp2IlInjected.Token(Token = "0x4000104")]
		Unknown = 0,
		[Cpp2IlInjected.Token(Token = "0x4000105")]
		MakerPenButtonHighlight = 1,
		[Cpp2IlInjected.Token(Token = "0x4000106")]
		PlaceControlTutorial = 3
	}
	[Cpp2IlInjected.Token(Token = "0x200004B")]
	public enum JustInTimeTutorialTrackable
	{
		[Cpp2IlInjected.Token(Token = "0x4000108")]
		EnteredRoom = 0,
		[Cpp2IlInjected.Token(Token = "0x4000109")]
		TimeInRoom = 1,
		[Cpp2IlInjected.Token(Token = "0x400010A")]
		ObjectInteractionRoom = 2,
		[Cpp2IlInjected.Token(Token = "0x400010B")]
		ObjectPlaceStartedRoom = 4
	}
	[Cpp2IlInjected.Token(Token = "0x200004C")]
	public interface FBVOMUBKERI
	{
		[Cpp2IlInjected.Token(Token = "0x170000F3")]
		bool YZZSTDFWHNC
		{
			[Cpp2IlInjected.Token(Token = "0x6000216")]
			[Cpp2IlInjected.Address(Slot = "4")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x170000F4")]
		KBLPOZGJAAH<InAppMessageDTO> TJHYPJCPFGE
		{
			[Cpp2IlInjected.Token(Token = "0x6000219")]
			[Cpp2IlInjected.Address(Slot = "7")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x170000F5")]
		KBLPOZGJAAH<string> SJNZJZMLUDZ
		{
			[Cpp2IlInjected.Token(Token = "0x600021A")]
			[Cpp2IlInjected.Address(Slot = "8")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x170000F6")]
		KBLPOZGJAAH<InAppMessageDTO> FWOSPNHTNQF
		{
			[Cpp2IlInjected.Token(Token = "0x600021B")]
			[Cpp2IlInjected.Address(Slot = "9")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x170000F7")]
		KBLPOZGJAAH<InAppMessageDTO> ZEYOELQZMFU
		{
			[Cpp2IlInjected.Token(Token = "0x600021C")]
			[Cpp2IlInjected.Address(Slot = "10")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x6000212")]
		[Cpp2IlInjected.Address(Slot = "0")]
		IReadOnlyList<InAppMessageDTO> LNGNEHDELUP(InAppMessageChannel a);

		[Cpp2IlInjected.Token(Token = "0x6000213")]
		[Cpp2IlInjected.Address(Slot = "1")]
		IReadOnlyList<InAppMessageDTO> NWESSKRARIM(InAppMessageChannel a);

		[Cpp2IlInjected.Token(Token = "0x6000214")]
		[Cpp2IlInjected.Address(Slot = "2")]
		InAppMessageDTO QCXRQYFXTMF(InAppMessageChannel a, string b);

		[Cpp2IlInjected.Token(Token = "0x6000215")]
		[Cpp2IlInjected.Address(Slot = "3")]
		InAppMessageDTO QZHVUBOPRTS(InAppMessageChannel a);

		[Cpp2IlInjected.Token(Token = "0x6000217")]
		[Cpp2IlInjected.Address(Slot = "5")]
		bool CIUSKKKDEVH(InAppMessageChannel a);

		[Cpp2IlInjected.Token(Token = "0x6000218")]
		[Cpp2IlInjected.Address(Slot = "6")]
		int ZETHEDLCTDX(InAppMessageChannel a);

		[Cpp2IlInjected.Token(Token = "0x600021D")]
		[Cpp2IlInjected.Address(Slot = "11")]
		Task Refresh();

		[Cpp2IlInjected.Token(Token = "0x600021E")]
		[Cpp2IlInjected.Address(Slot = "12")]
		Task YTZLNOHXRJZ(InAppMessageDTO a);
	}
	[Cpp2IlInjected.Token(Token = "0x200004D")]
	public interface XABSEXEZSMI
	{
		[Cpp2IlInjected.Token(Token = "0x170000F8")]
		TOESZNWFQDM DINJXGEGWIE
		{
			[Cpp2IlInjected.Token(Token = "0x6000223")]
			[Cpp2IlInjected.Address(Slot = "4")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x170000F9")]
		int PNMOCZLKHSB
		{
			[Cpp2IlInjected.Token(Token = "0x6000224")]
			[Cpp2IlInjected.Address(Slot = "5")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x170000FA")]
		bool GPOFCHYGCLH
		{
			[Cpp2IlInjected.Token(Token = "0x6000225")]
			[Cpp2IlInjected.Address(Slot = "6")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x170000FB")]
		bool GWMLPDEHRSL
		{
			[Cpp2IlInjected.Token(Token = "0x6000226")]
			[Cpp2IlInjected.Address(Slot = "7")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x170000FC")]
		bool SJPLVLZNBUD
		{
			[Cpp2IlInjected.Token(Token = "0x6000227")]
			[Cpp2IlInjected.Address(Slot = "8")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x170000FD")]
		bool COOLHYOSHYP
		{
			[Cpp2IlInjected.Token(Token = "0x6000228")]
			[Cpp2IlInjected.Address(Slot = "9")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x170000FE")]
		bool SFISNIKNXEQ
		{
			[Cpp2IlInjected.Token(Token = "0x6000229")]
			[Cpp2IlInjected.Address(Slot = "10")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x170000FF")]
		bool EFQNBWPPXZN
		{
			[Cpp2IlInjected.Token(Token = "0x600022A")]
			[Cpp2IlInjected.Address(Slot = "11")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000100")]
		bool NDKOSMTFQQO
		{
			[Cpp2IlInjected.Token(Token = "0x600022B")]
			[Cpp2IlInjected.Address(Slot = "12")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000101")]
		bool TRDZVPZVLQI
		{
			[Cpp2IlInjected.Token(Token = "0x600022C")]
			[Cpp2IlInjected.Address(Slot = "13")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000102")]
		bool CXDAMRQDQGB
		{
			[Cpp2IlInjected.Token(Token = "0x600022D")]
			[Cpp2IlInjected.Address(Slot = "14")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000103")]
		bool LGIIPIHACWM
		{
			[Cpp2IlInjected.Token(Token = "0x600022E")]
			[Cpp2IlInjected.Address(Slot = "15")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x14000003")]
		event Action DSCTMDJGZHO;

		[Cpp2IlInjected.Token(Token = "0x14000004")]
		event Action SXCIOVBIMOY;

		[Cpp2IlInjected.Token(Token = "0x600022F")]
		[Cpp2IlInjected.Address(Slot = "16")]
		SPVBYBYHFON<PWCZVKIUTHK> OWTZIOWLFLP(int a);

		[Cpp2IlInjected.Token(Token = "0x6000230")]
		[Cpp2IlInjected.Address(Slot = "17")]
		BRWPWCYORRE VIDEWXBIFFJ(DateTime a);

		[Cpp2IlInjected.Token(Token = "0x6000231")]
		[Cpp2IlInjected.Address(Slot = "18")]
		BRWPWCYORRE VKVJLJLVCRU(string a);

		[Cpp2IlInjected.Token(Token = "0x6000232")]
		[Cpp2IlInjected.Address(Slot = "19")]
		Task KSHZEZSOWIR([Optional] CancellationToken a);
	}
	[Cpp2IlInjected.Token(Token = "0x200004E")]
	public enum TestAccountAuthRole
	{
		[Cpp2IlInjected.Token(Token = "0x400010D")]
		Memory,
		[Cpp2IlInjected.Token(Token = "0x400010E")]
		Multiplayer
	}
	[Cpp2IlInjected.Token(Token = "0x200004F")]
	public static class LGOWQSCJMYS
	{
		[Cpp2IlInjected.Token(Token = "0x6000233")]
		[Cpp2IlInjected.Address(RVA = "0x7719DA0", Offset = "0x77191A0", VA = "0x187719DA0")]
		public static string GNDPVRHPSTZ(this TestAccountAuthRole a)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000050")]
	public interface OEXEMBYIRFA
	{
		[Cpp2IlInjected.Token(Token = "0x6000234")]
		[Cpp2IlInjected.Address(Slot = "0")]
		Task<List<InAppMessageDTO>> XDWQWAWDFRA(InAppMessageChannel a);

		[Cpp2IlInjected.Token(Token = "0x6000235")]
		[Cpp2IlInjected.Address(Slot = "1")]
		Task YTZLNOHXRJZ(string a);
	}
	[Cpp2IlInjected.Token(Token = "0x2000051")]
	public interface XMYHVFHJVYH
	{
		[Cpp2IlInjected.Token(Token = "0x6000236")]
		[Cpp2IlInjected.Address(Slot = "0")]
		Task<CrmAssignmentDTO> HBUXMIIVJDS();
	}
	[Cpp2IlInjected.Token(Token = "0x2000052")]
	public interface KCADNAFIILK
	{
		[Cpp2IlInjected.Token(Token = "0x17000104")]
		Guid? QFRQGGFUBTN
		{
			[Cpp2IlInjected.Token(Token = "0x6000237")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000053")]
	public interface ZQURFOBAHHP
	{
		[Cpp2IlInjected.Token(Token = "0x6000238")]
		[Cpp2IlInjected.Address(Slot = "0")]
		Task MAXWDLBIBXP(float a, [Optional] CancellationToken b);
	}
	[Cpp2IlInjected.Token(Token = "0x2000054")]
	public interface CZCZUHVSRYL
	{
		[Cpp2IlInjected.Token(Token = "0x6000239")]
		[Cpp2IlInjected.Address(Slot = "0")]
		SPVBYBYHFON<List<FSGHFJHNGMT>> WHFXTEXYMSS();

		[Cpp2IlInjected.Token(Token = "0x600023A")]
		[Cpp2IlInjected.Address(Slot = "1")]
		SPVBYBYHFON<List<FSGHFJHNGMT>> RPLNDFNJJJD();

		[Cpp2IlInjected.Token(Token = "0x600023B")]
		[Cpp2IlInjected.Address(Slot = "2")]
		Task<List<FSGHFJHNGMT>> DYHZBOLVOBL([Optional] CancellationToken a);

		[Cpp2IlInjected.Token(Token = "0x600023C")]
		[Cpp2IlInjected.Address(Slot = "3")]
		SPVBYBYHFON<List<FSGHFJHNGMT>> EXATWCMGDFK(List<AvatarItemDesc> a);

		[Cpp2IlInjected.Token(Token = "0x600023D")]
		[Cpp2IlInjected.Address(Slot = "4")]
		SPVBYBYHFON<List<FSGHFJHNGMT>> MYOAVRKGDAI(List<AvatarItemDesc> a);
	}
	[Cpp2IlInjected.Token(Token = "0x2000055")]
	public interface SWSDGEQLKKH
	{
		[Cpp2IlInjected.Token(Token = "0x17000105")]
		List<GiftPackage> ATUJCTKXPYR
		{
			[Cpp2IlInjected.Token(Token = "0x6000242")]
			[Cpp2IlInjected.Address(Slot = "4")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x14000005")]
		event Action<GiftPackageReceivedArgs> BBBSZOJMQEP;

		[Cpp2IlInjected.Token(Token = "0x14000006")]
		event Action<GiftPackage> ANMSNJHLURY;

		[Cpp2IlInjected.Token(Token = "0x6000243")]
		[Cpp2IlInjected.Address(Slot = "5")]
		BRWPWCYORRE EGDKMIDBCQB(GiftPackage a);

		[Cpp2IlInjected.Token(Token = "0x6000244")]
		[Cpp2IlInjected.Address(Slot = "6")]
		Task IPYRXENBNQP(GiftPackage a);

		[Cpp2IlInjected.Token(Token = "0x6000245")]
		[Cpp2IlInjected.Address(Slot = "7")]
		[Obsolete("Alternate gift contexts are being phased out. Use LocalRequestGiftPackage(GiftContext context, string message) instead")]
		SPVBYBYHFON<GiftPackage> JRUDXUJMCIA(GiftContext a, GiftContext? b, bool c, string d);

		[Cpp2IlInjected.Token(Token = "0x6000246")]
		[Cpp2IlInjected.Address(Slot = "8")]
		SPVBYBYHFON<GiftPackage> JRUDXUJMCIA(GiftContext a, string b);

		[Cpp2IlInjected.Token(Token = "0x6000247")]
		[Cpp2IlInjected.Address(Slot = "9")]
		void HUPNIUWFJIP(GiftPackage a, bool b = false, bool c = false, bool d = true);

		[Cpp2IlInjected.Token(Token = "0x6000248")]
		[Cpp2IlInjected.Address(Slot = "10")]
		SPVBYBYHFON<List<GiftPackage>> IHKLGBFTCMV();
	}
	[Cpp2IlInjected.Token(Token = "0x2000056")]
	public interface YUXYYXKDXRD
	{
		[Cpp2IlInjected.Token(Token = "0x17000106")]
		string TRGSHHYYHYX
		{
			[Cpp2IlInjected.Token(Token = "0x600024D")]
			[Cpp2IlInjected.Address(Slot = "4")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000107")]
		bool NFGAPEOAPUA
		{
			[Cpp2IlInjected.Token(Token = "0x600024E")]
			[Cpp2IlInjected.Address(Slot = "5")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x6000249")]
		[Cpp2IlInjected.Address(Slot = "0")]
		BRWPWCYORRE JAEMWGHOPTI();

		[Cpp2IlInjected.Token(Token = "0x600024A")]
		[Cpp2IlInjected.Address(Slot = "1")]
		BRWPWCYORRE GQDLNZVYHSH(string a, string b);

		[Cpp2IlInjected.Token(Token = "0x600024B")]
		[Cpp2IlInjected.Address(Slot = "2")]
		BRWPWCYORRE LYBPLHRYJVB(string a);

		[Cpp2IlInjected.Token(Token = "0x600024C")]
		[Cpp2IlInjected.Address(Slot = "3")]
		void VQFAVFBYSIV();

		[Cpp2IlInjected.Token(Token = "0x600024F")]
		[Cpp2IlInjected.Address(Slot = "6")]
		Task<LoginResult> WRCSXJULKXN(string a, string b, bool c, string d, string e, [Optional] CancellationToken f);

		[Cpp2IlInjected.Token(Token = "0x6000250")]
		[Cpp2IlInjected.Address(Slot = "7")]
		Task DDPVPRNRHXU(int a, string b, [Optional] CancellationToken c);

		[Cpp2IlInjected.Token(Token = "0x6000251")]
		[Cpp2IlInjected.Address(Slot = "8")]
		Task UASPVWVFCTD(int a, [Optional] CancellationToken b);

		[Cpp2IlInjected.Token(Token = "0x6000252")]
		[Cpp2IlInjected.Address(Slot = "9")]
		Task CRSQUJPIWNF([Optional] TestAccountAuthRole? a, [Optional] CancellationToken b);

		[Cpp2IlInjected.Token(Token = "0x6000253")]
		[Cpp2IlInjected.Address(Slot = "10")]
		Task<IReadOnlyList<HPMEIPJMUJG>> LGERYNFDJCC([Optional] CancellationToken a);

		[Cpp2IlInjected.Token(Token = "0x6000254")]
		[Cpp2IlInjected.Address(Slot = "11")]
		Task LJFNWOTONJP([Optional] CancellationToken a);
	}
	[Cpp2IlInjected.Token(Token = "0x2000057")]
	public interface YDQUCEDFGFL
	{
		[Cpp2IlInjected.Token(Token = "0x6000255")]
		[Cpp2IlInjected.Address(Slot = "0")]
		Task<List<StatsigMemoryOverrideParameterDTO>> XXEAARKQYGW([Optional] CancellationToken a);

		[Cpp2IlInjected.Token(Token = "0x6000256")]
		[Cpp2IlInjected.Address(Slot = "1")]
		Task<List<StatsigExperimentConfigDTO>> LCDUDZAHACY([Optional] CancellationToken a);
	}
	[Cpp2IlInjected.Token(Token = "0x2000058")]
	public interface SXBIGDZAPLW
	{
		[Cpp2IlInjected.Token(Token = "0x6000257")]
		[Cpp2IlInjected.Address(Slot = "0")]
		Task GLLJGZEDATK([Optional] CancellationToken a);

		[Cpp2IlInjected.Token(Token = "0x6000258")]
		[Cpp2IlInjected.Address(Slot = "1")]
		void Disconnect();
	}
	[Cpp2IlInjected.Token(Token = "0x2000059")]
	public interface BVANOJVYNPZ
	{
		[Cpp2IlInjected.Token(Token = "0x6000259")]
		[Cpp2IlInjected.Address(Slot = "0")]
		Task PSUJFNWVZQP(int a, [Optional] CancellationToken b);
	}
	[Cpp2IlInjected.Token(Token = "0x200005A")]
	public interface NWHXLJXQEOY
	{
		[Cpp2IlInjected.Token(Token = "0x14000007")]
		event OutfitEvent? SOZPSAKLNXC;

		[Cpp2IlInjected.Token(Token = "0x14000008")]
		event OutfitEvent? WTXIPREHGQQ;

		[Cpp2IlInjected.Token(Token = "0x14000009")]
		event OutfitEvent? XEOHEPGOWOI;

		[Cpp2IlInjected.Token(Token = "0x6000260")]
		[Cpp2IlInjected.Address(Slot = "6")]
		Task<OutfitDTO> YCWFJBWOIPU();

		[Cpp2IlInjected.Token(Token = "0x6000261")]
		[Cpp2IlInjected.Address(Slot = "7")]
		Task<OutfitDTO?>? XGBVZOEDHHV(int a);

		[Cpp2IlInjected.Token(Token = "0x6000262")]
		[Cpp2IlInjected.Address(Slot = "8")]
		Task<List<FDCQPMDXBZY>> YWEWZDXXRQT(List<int> a);

		[Cpp2IlInjected.Token(Token = "0x6000263")]
		[Cpp2IlInjected.Address(Slot = "9")]
		Task<IReadOnlyDictionary<int, OutfitDTO>> XMUCRRNFJBD();

		[Cpp2IlInjected.Token(Token = "0x6000264")]
		[Cpp2IlInjected.Address(Slot = "10")]
		Task<List<OutfitDTO?>?>? EFNEBBEDIUW(int a);

		[Cpp2IlInjected.Token(Token = "0x6000265")]
		[Cpp2IlInjected.Address(Slot = "11")]
		Task FKAESRGRFJP(int a);

		[Cpp2IlInjected.Token(Token = "0x6000266")]
		[Cpp2IlInjected.Address(Slot = "12")]
		Task<RecNetResult> WPICOOCVYIE(OutfitDTO a);
	}
	[Cpp2IlInjected.Token(Token = "0x200005B")]
	public delegate void OutfitEvent(int accountId, int slot, OutfitDTO? outfit);
	[Cpp2IlInjected.Token(Token = "0x200005C")]
	public interface RIWMWKYZVIR : UGOYJKBIWPW, PMWPFJTCYLI
	{
		[Cpp2IlInjected.Token(Token = "0x200005D")]
		[Flags]
		public enum SanitizeMode
		{
			[Cpp2IlInjected.Token(Token = "0x4000110")]
			FilterProfanity = 1,
			[Cpp2IlInjected.Token(Token = "0x4000111")]
			FilterURL = 2
		}

		[Cpp2IlInjected.Token(Token = "0x17000108")]
		string UIAVGHGLGEF
		{
			[Cpp2IlInjected.Token(Token = "0x600026B")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000109")]
		DeviceClass SLYNOUHPXVS
		{
			[Cpp2IlInjected.Token(Token = "0x600026C")]
			[Cpp2IlInjected.Address(Slot = "1")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x1700010A")]
		PlatformType CZBNIXOJCPX
		{
			[Cpp2IlInjected.Token(Token = "0x600026D")]
			[Cpp2IlInjected.Address(Slot = "2")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x1700010B")]
		string NWKBKSJEXZC
		{
			[Cpp2IlInjected.Token(Token = "0x600026E")]
			[Cpp2IlInjected.Address(Slot = "3")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x1700010C")]
		byte IIZCHHOLINO
		{
			[Cpp2IlInjected.Token(Token = "0x6000271")]
			[Cpp2IlInjected.Address(Slot = "6")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x1700010D")]
		int YDZAJSOSZJJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000272")]
			[Cpp2IlInjected.Address(Slot = "7")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x1700010E")]
		int KTPLYUXWHRN
		{
			[Cpp2IlInjected.Token(Token = "0x6000273")]
			[Cpp2IlInjected.Address(Slot = "8")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x1700010F")]
		bool WMIQVEJSZBI
		{
			[Cpp2IlInjected.Token(Token = "0x6000274")]
			[Cpp2IlInjected.Address(Slot = "9")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000110")]
		bool GCQHTMWTJYW
		{
			[Cpp2IlInjected.Token(Token = "0x6000275")]
			[Cpp2IlInjected.Address(Slot = "10")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000111")]
		bool JDURGPXVWQD
		{
			[Cpp2IlInjected.Token(Token = "0x6000276")]
			[Cpp2IlInjected.Address(Slot = "11")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000112")]
		bool JNVGCWDJWXN
		{
			[Cpp2IlInjected.Token(Token = "0x6000277")]
			[Cpp2IlInjected.Address(Slot = "12")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000113")]
		bool NWINTUQOBWR
		{
			[Cpp2IlInjected.Token(Token = "0x6000278")]
			[Cpp2IlInjected.Address(Slot = "13")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000114")]
		bool LAEBHWGZEIL
		{
			[Cpp2IlInjected.Token(Token = "0x6000279")]
			[Cpp2IlInjected.Address(Slot = "14")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000115")]
		bool JNVONYFBVJS
		{
			[Cpp2IlInjected.Token(Token = "0x6000281")]
			[Cpp2IlInjected.Address(Slot = "22")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x600026F")]
		[Cpp2IlInjected.Address(Slot = "4")]
		SPVBYBYHFON<string> RNAMMXPMFUW();

		[Cpp2IlInjected.Token(Token = "0x6000270")]
		[Cpp2IlInjected.Address(Slot = "5")]
		Task<string> WOGZUBPFZRS();

		[Cpp2IlInjected.Token(Token = "0x600027A")]
		[Cpp2IlInjected.Address(Slot = "15")]
		SPVBYBYHFON<bool> NPYHKBSTUEM(int a);

		[Cpp2IlInjected.Token(Token = "0x600027B")]
		[Cpp2IlInjected.Address(Slot = "16")]
		string MXKIQLGVKFL(string a, bool b = true);

		[Cpp2IlInjected.Token(Token = "0x600027C")]
		[Cpp2IlInjected.Address(Slot = "17")]
		Task<string> PCFNBKWXRKX(string a, bool b = true);

		[Cpp2IlInjected.Token(Token = "0x600027D")]
		[Cpp2IlInjected.Address(Slot = "18")]
		SPVBYBYHFON<string> MakeRoomNameAdhereToPlatformRequirements(long roomId, string name);

		[Cpp2IlInjected.Token(Token = "0x600027E")]
		[Cpp2IlInjected.Address(Slot = "19")]
		bool SanitizeDisplayText(string displayText, SanitizeMode sanitizeMode = SanitizeMode.FilterProfanity | SanitizeMode.FilterURL);

		[Cpp2IlInjected.Token(Token = "0x600027F")]
		[Cpp2IlInjected.Address(Slot = "20")]
		Task<string> SanitizeDisplayTextAsync(string displayText, SanitizeMode sanitizeMode = SanitizeMode.FilterProfanity | SanitizeMode.FilterURL, bool isChat = false);

		[Cpp2IlInjected.Token(Token = "0x6000280")]
		[Cpp2IlInjected.Address(Slot = "21")]
		bool CheckNameForProfanity(string name, SanitizeMode sanitizeMode = SanitizeMode.FilterProfanity | SanitizeMode.FilterURL);

		[Cpp2IlInjected.Token(Token = "0x6000282")]
		[Cpp2IlInjected.Address(Slot = "23")]
		SPVBYBYHFON<string> GetCommerceSubscriptionAccessToken();
	}
	[Cpp2IlInjected.Token(Token = "0x200005E")]
	public interface BHSGTZGQVVK
	{
		[Cpp2IlInjected.Token(Token = "0x17000116")]
		KBLPOZGJAAH<PurchasableXpBoostActivationDTO> BAECBPTPHRW
		{
			[Cpp2IlInjected.Token(Token = "0x6000283")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x6000284")]
		[Cpp2IlInjected.Address(Slot = "1")]
		void UOZEIRDCIGI();

		[Cpp2IlInjected.Token(Token = "0x6000285")]
		[Cpp2IlInjected.Address(Slot = "2")]
		Task<PPCJEJRUUPJ<PurchasableXpBoostActivationDTO>> MRSIETNTIVB(CancellationToken a);

		[Cpp2IlInjected.Token(Token = "0x6000286")]
		[Cpp2IlInjected.Address(Slot = "3")]
		void KCGZBLHQNMU();
	}
	[Cpp2IlInjected.Token(Token = "0x200005F")]
	public interface IGFNXOMNUAE
	{
		[Cpp2IlInjected.Token(Token = "0x6000287")]
		[Cpp2IlInjected.Address(Slot = "0")]
		Task<PurchasePromotionDTO> EUCJTETCOVB(PurchaseItemRequestDTO a, [Optional] CancellationToken b);
	}
	[Cpp2IlInjected.Token(Token = "0x2000060")]
	[Utf8JsonSerializable]
	public class PurchasePromotionDTO
	{
		[Cpp2IlInjected.Token(Token = "0x17000117")]
		public PurchasePromotionType Type
		{
			[Cpp2IlInjected.Token(Token = "0x6000288")]
			[Cpp2IlInjected.Address(RVA = "0xAA3110", Offset = "0xAA2510", VA = "0x180AA3110")]
			[CompilerGenerated]
			get
			{
				return default(PurchasePromotionType);
			}
			[Cpp2IlInjected.Token(Token = "0x6000289")]
			[Cpp2IlInjected.Address(RVA = "0xAAB1D0", Offset = "0xAAA5D0", VA = "0x180AAB1D0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000118")]
		public StarterPackPromotionDTO? StarterPackPromotion
		{
			[Cpp2IlInjected.Token(Token = "0x600028A")]
			[Cpp2IlInjected.Address(RVA = "0xAAA880", Offset = "0xAA9C80", VA = "0x180AAA880")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600028B")]
			[Cpp2IlInjected.Address(RVA = "0xAAA120", Offset = "0xAA9520", VA = "0x180AAA120")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000119")]
		public FreeItemsWithRRPlusPromotionDTO? FreeItemsWithRRPlusPromotion
		{
			[Cpp2IlInjected.Token(Token = "0x600028C")]
			[Cpp2IlInjected.Address(RVA = "0xAAB1C0", Offset = "0xAAA5C0", VA = "0x180AAB1C0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600028D")]
			[Cpp2IlInjected.Address(RVA = "0xAA67C0", Offset = "0xAA5BC0", VA = "0x180AA67C0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700011A")]
		public LimitedTimeDiscountPromotionDTO? LimitedTimeDiscountPromotion
		{
			[Cpp2IlInjected.Token(Token = "0x600028E")]
			[Cpp2IlInjected.Address(RVA = "0xAAA820", Offset = "0xAA9C20", VA = "0x180AAA820")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600028F")]
			[Cpp2IlInjected.Address(RVA = "0xAA67D0", Offset = "0xAA5BD0", VA = "0x180AA67D0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700011B")]
		public PurchaseCampaignPromotionDTO? PurchaseCampaignPromotion
		{
			[Cpp2IlInjected.Token(Token = "0x6000290")]
			[Cpp2IlInjected.Address(RVA = "0xAAA140", Offset = "0xAA9540", VA = "0x180AAA140")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000291")]
			[Cpp2IlInjected.Address(RVA = "0xAADB00", Offset = "0xAACF00", VA = "0x180AADB00")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000292")]
		[Cpp2IlInjected.Address(RVA = "0xAAC8E0", Offset = "0xAABCE0", VA = "0x180AAC8E0")]
		public PurchasePromotionDTO()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000061")]
	public enum PurchasePromotionType
	{
		[Cpp2IlInjected.Token(Token = "0x4000118")]
		StarterPack,
		[Cpp2IlInjected.Token(Token = "0x4000119")]
		FreeItemsWithRRPlus,
		[Cpp2IlInjected.Token(Token = "0x400011A")]
		LimitedTimeDiscount,
		[Cpp2IlInjected.Token(Token = "0x400011B")]
		PurchaseCampaign
	}
	[Cpp2IlInjected.Token(Token = "0x2000062")]
	[Utf8JsonSerializable]
	public class StarterPackPromotionDTO
	{
		[Cpp2IlInjected.Token(Token = "0x1700011C")]
		public int PurchaseReminderId
		{
			[Cpp2IlInjected.Token(Token = "0x6000293")]
			[Cpp2IlInjected.Address(RVA = "0xAA3110", Offset = "0xAA2510", VA = "0x180AA3110")]
			[CompilerGenerated]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x6000294")]
			[Cpp2IlInjected.Address(RVA = "0xAAB1D0", Offset = "0xAAA5D0", VA = "0x180AAB1D0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700011D")]
		public List<ItemPurchaseMethodId> BonusItemIds
		{
			[Cpp2IlInjected.Token(Token = "0x6000295")]
			[Cpp2IlInjected.Address(RVA = "0xAAA880", Offset = "0xAA9C80", VA = "0x180AAA880")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000296")]
			[Cpp2IlInjected.Address(RVA = "0xAAA120", Offset = "0xAA9520", VA = "0x180AAA120")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000297")]
		[Cpp2IlInjected.Address(RVA = "0xAAC8E0", Offset = "0xAABCE0", VA = "0x180AAC8E0")]
		public StarterPackPromotionDTO()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000063")]
	[Utf8JsonSerializable]
	public class FreeItemsWithRRPlusPromotionDTO
	{
		[Cpp2IlInjected.Token(Token = "0x1700011E")]
		public int RRPlusSignUpBonusId
		{
			[Cpp2IlInjected.Token(Token = "0x6000298")]
			[Cpp2IlInjected.Address(RVA = "0xAA3110", Offset = "0xAA2510", VA = "0x180AA3110")]
			[CompilerGenerated]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x6000299")]
			[Cpp2IlInjected.Address(RVA = "0xAAB1D0", Offset = "0xAAA5D0", VA = "0x180AAB1D0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700011F")]
		public List<ItemPurchaseMethodId> BonusItemIds
		{
			[Cpp2IlInjected.Token(Token = "0x600029A")]
			[Cpp2IlInjected.Address(RVA = "0xAAA880", Offset = "0xAA9C80", VA = "0x180AAA880")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600029B")]
			[Cpp2IlInjected.Address(RVA = "0xAAA120", Offset = "0xAA9520", VA = "0x180AAA120")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600029C")]
		[Cpp2IlInjected.Address(RVA = "0xAAC8E0", Offset = "0xAABCE0", VA = "0x180AAC8E0")]
		public FreeItemsWithRRPlusPromotionDTO()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000064")]
	public enum LimitedTimeDiscountPromotionType
	{
		[Cpp2IlInjected.Token(Token = "0x4000121")]
		PercentOff,
		[Cpp2IlInjected.Token(Token = "0x4000122")]
		SetPrice
	}
	[Cpp2IlInjected.Token(Token = "0x2000065")]
	[Utf8JsonSerializable]
	public class LimitedTimeDiscountPromotionDTO
	{
		[Cpp2IlInjected.Token(Token = "0x17000120")]
		public LimitedTimeDiscountPromotionType Type
		{
			[Cpp2IlInjected.Token(Token = "0x600029D")]
			[Cpp2IlInjected.Address(RVA = "0xAA3110", Offset = "0xAA2510", VA = "0x180AA3110")]
			[CompilerGenerated]
			get
			{
				return default(LimitedTimeDiscountPromotionType);
			}
			[Cpp2IlInjected.Token(Token = "0x600029E")]
			[Cpp2IlInjected.Address(RVA = "0xAAB1D0", Offset = "0xAAA5D0", VA = "0x180AAB1D0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000121")]
		public decimal? PercentOff
		{
			[Cpp2IlInjected.Token(Token = "0x600029F")]
			[Cpp2IlInjected.Address(RVA = "0xFB4250", Offset = "0xFB3650", VA = "0x180FB4250")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60002A0")]
			[Cpp2IlInjected.Address(RVA = "0x50FD7B0", Offset = "0x50FCBB0", VA = "0x1850FD7B0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000122")]
		public int? SetPrice
		{
			[Cpp2IlInjected.Token(Token = "0x60002A1")]
			[Cpp2IlInjected.Address(RVA = "0xAAA140", Offset = "0xAA9540", VA = "0x180AAA140")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60002A2")]
			[Cpp2IlInjected.Address(RVA = "0xAAA860", Offset = "0xAA9C60", VA = "0x180AAA860")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000123")]
		public int DurationInMinutes
		{
			[Cpp2IlInjected.Token(Token = "0x60002A3")]
			[Cpp2IlInjected.Address(RVA = "0xAD4020", Offset = "0xAD3420", VA = "0x180AD4020")]
			[CompilerGenerated]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x60002A4")]
			[Cpp2IlInjected.Address(RVA = "0xB10400", Offset = "0xB0F800", VA = "0x180B10400")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000124")]
		public DateTime? EndsAt
		{
			[Cpp2IlInjected.Token(Token = "0x60002A5")]
			[Cpp2IlInjected.Address(RVA = "0xD8F2E0", Offset = "0xD8E6E0", VA = "0x180D8F2E0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60002A6")]
			[Cpp2IlInjected.Address(RVA = "0xD8F190", Offset = "0xD8E590", VA = "0x180D8F190")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000125")]
		public TimeSpan Duration
		{
			[Cpp2IlInjected.Token(Token = "0x60002A7")]
			[Cpp2IlInjected.Address(RVA = "0x7719FD0", Offset = "0x77193D0", VA = "0x187719FD0")]
			get
			{
				return default(TimeSpan);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60002A8")]
		[Cpp2IlInjected.Address(RVA = "0xAAC8E0", Offset = "0xAABCE0", VA = "0x180AAC8E0")]
		public LimitedTimeDiscountPromotionDTO()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000066")]
	[Utf8JsonSerializable]
	public class PurchaseCampaignPromotionDTO
	{
		[Cpp2IlInjected.Token(Token = "0x17000126")]
		public int PurchaseCampaignId
		{
			[Cpp2IlInjected.Token(Token = "0x60002A9")]
			[Cpp2IlInjected.Address(RVA = "0xAA3110", Offset = "0xAA2510", VA = "0x180AA3110")]
			[CompilerGenerated]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x60002AA")]
			[Cpp2IlInjected.Address(RVA = "0xAAB1D0", Offset = "0xAAA5D0", VA = "0x180AAB1D0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000127")]
		public List<GrantableId?> BonusSelectableGrantableIds
		{
			[Cpp2IlInjected.Token(Token = "0x60002AB")]
			[Cpp2IlInjected.Address(RVA = "0xAAA880", Offset = "0xAA9C80", VA = "0x180AAA880")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60002AC")]
			[Cpp2IlInjected.Address(RVA = "0xAAA120", Offset = "0xAA9520", VA = "0x180AAA120")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60002AD")]
		[Cpp2IlInjected.Address(RVA = "0xAAC8E0", Offset = "0xAABCE0", VA = "0x180AAC8E0")]
		public PurchaseCampaignPromotionDTO()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000067")]
	public interface HYMOPIAIQMQ
	{
		[Cpp2IlInjected.Token(Token = "0x60002AE")]
		[Cpp2IlInjected.Address(Slot = "0")]
		Task<List<RefereeFileReferenceDTO>> PMOXVGBLTKM([Optional] CancellationToken a);
	}
	[Cpp2IlInjected.Token(Token = "0x2000068")]
	public interface HCSWLWDYORI
	{
		[Cpp2IlInjected.Token(Token = "0x60002AF")]
		[Cpp2IlInjected.Address(Slot = "0")]
		bool ACUSBKATNKT(byte[] a, byte[] b);
	}
	[Cpp2IlInjected.Token(Token = "0x2000069")]
	public interface SDHUTJSOLVL
	{
		[Cpp2IlInjected.Token(Token = "0x60002B0")]
		[Cpp2IlInjected.Address(Slot = "0")]
		Task XAOIVFSZSUM(string a);
	}
	[Cpp2IlInjected.Token(Token = "0x200006A")]
	public interface YAYJWQOUMBX
	{
		[Cpp2IlInjected.Token(Token = "0x60002B1")]
		[Cpp2IlInjected.Address(Slot = "0")]
		Task<List<RecNetResultObject<FilteredTextDTO>>> XDNJUQCUCEH(uint a, IEnumerable<string> b);
	}
	[Cpp2IlInjected.Token(Token = "0x200006B")]
	public interface NZQOOQFNVLN
	{
		[Cpp2IlInjected.Token(Token = "0x60002B2")]
		[Cpp2IlInjected.Address(Slot = "0")]
		void UOZEIRDCIGI();

		[Cpp2IlInjected.Token(Token = "0x60002B3")]
		[Cpp2IlInjected.Address(Slot = "1")]
		Task<TimedCurrencyGrantDTO> OBMMOAWRMHI(long a, [Optional] CancellationToken b);

		[Cpp2IlInjected.Token(Token = "0x60002B4")]
		[Cpp2IlInjected.Address(Slot = "2")]
		Task FSGDVFJFDYA([Optional] CancellationToken a);
	}
	[Cpp2IlInjected.Token(Token = "0x200006C")]
	public interface FGMXGVLQMCM
	{
		[Cpp2IlInjected.Token(Token = "0x17000128")]
		KBLPOZGJAAH<TimedRewardTrackRecordDTO> BVYUCAYOPIP
		{
			[Cpp2IlInjected.Token(Token = "0x60002B5")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000129")]
		KBLPOZGJAAH<TimedRewardTrackXpEarnedDTO> ZCVZRMQAHZB
		{
			[Cpp2IlInjected.Token(Token = "0x60002B6")]
			[Cpp2IlInjected.Address(Slot = "1")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x60002B7")]
		[Cpp2IlInjected.Address(Slot = "2")]
		void UOZEIRDCIGI();

		[Cpp2IlInjected.Token(Token = "0x60002B8")]
		[Cpp2IlInjected.Address(Slot = "3")]
		Task<TimedRewardTrackDTO> FCYZHHOSCBZ(long a, [Optional] CancellationToken b);

		[Cpp2IlInjected.Token(Token = "0x60002B9")]
		[Cpp2IlInjected.Address(Slot = "4")]
		Task<TimedRewardTrackDTO> FCYZHHOSCBZ(string a, [Optional] CancellationToken b);

		[Cpp2IlInjected.Token(Token = "0x60002BA")]
		[Cpp2IlInjected.Address(Slot = "5")]
		Task<TimedRewardTrackRecordDTO> GBNRJMOUJXO(long a, [Optional] CancellationToken b);
	}
	[Cpp2IlInjected.Token(Token = "0x200006D")]
	public interface CEFMWJPHZHV
	{
		[Cpp2IlInjected.Token(Token = "0x60002BB")]
		[Cpp2IlInjected.Address(Slot = "0")]
		bool DZQJKEBQRXX([Out] bool a);

		[Cpp2IlInjected.Token(Token = "0x60002BC")]
		[Cpp2IlInjected.Address(Slot = "1")]
		bool BKCHHRWMKDK([Out] bool a);

		[Cpp2IlInjected.Token(Token = "0x60002BD")]
		[Cpp2IlInjected.Address(Slot = "2")]
		bool LZUVZQWJMXW([Out] int a);

		[Cpp2IlInjected.Token(Token = "0x60002BE")]
		[Cpp2IlInjected.Address(Slot = "3")]
		bool ZPZPPLBPAPB([Out] bool a);
	}
	[Cpp2IlInjected.Token(Token = "0x200006E")]
	public enum JuniorState
	{
		[Cpp2IlInjected.Token(Token = "0x400012B")]
		BasedOnBirthday,
		[Cpp2IlInjected.Token(Token = "0x400012C")]
		ModerationOverride,
		[Cpp2IlInjected.Token(Token = "0x400012D")]
		PendingOverride
	}
	[Cpp2IlInjected.Token(Token = "0x200006F")]
	public enum PlatformDetailType
	{
		[Cpp2IlInjected.Token(Token = "0x400012F")]
		Id,
		[Cpp2IlInjected.Token(Token = "0x4000130")]
		Email,
		[Cpp2IlInjected.Token(Token = "0x4000131")]
		Phone
	}
	[Cpp2IlInjected.Token(Token = "0x2000070")]
	[Flags]
	public enum PersonalPronouns
	{
		[Cpp2IlInjected.Token(Token = "0x4000133")]
		None = 0,
		[Cpp2IlInjected.Token(Token = "0x4000134")]
		SheHer = 1,
		[Cpp2IlInjected.Token(Token = "0x4000135")]
		HeHim = 2,
		[Cpp2IlInjected.Token(Token = "0x4000136")]
		TheyThem = 4,
		[Cpp2IlInjected.Token(Token = "0x4000137")]
		ZeHir = 8,
		[Cpp2IlInjected.Token(Token = "0x4000138")]
		ZeZir = 0x10,
		[Cpp2IlInjected.Token(Token = "0x4000139")]
		XeXem = 0x20
	}
	[Cpp2IlInjected.Token(Token = "0x2000071")]
	[Flags]
	public enum IdentityFlags
	{
		[Cpp2IlInjected.Token(Token = "0x400013B")]
		None = 0,
		[Cpp2IlInjected.Token(Token = "0x400013C")]
		LGBTQIA = 1,
		[Cpp2IlInjected.Token(Token = "0x400013D")]
		Transgender = 2,
		[Cpp2IlInjected.Token(Token = "0x400013E")]
		Bisexual = 4,
		[Cpp2IlInjected.Token(Token = "0x400013F")]
		Lesbian = 8,
		[Cpp2IlInjected.Token(Token = "0x4000140")]
		Pansexual = 0x10,
		[Cpp2IlInjected.Token(Token = "0x4000141")]
		Asexual = 0x20,
		[Cpp2IlInjected.Token(Token = "0x4000142")]
		Intersex = 0x40,
		[Cpp2IlInjected.Token(Token = "0x4000143")]
		Genderqueer = 0x80,
		[Cpp2IlInjected.Token(Token = "0x4000144")]
		Nonbinary = 0x100,
		[Cpp2IlInjected.Token(Token = "0x4000145")]
		Aromantic = 0x200
	}
	[Cpp2IlInjected.Token(Token = "0x2000072")]
	public enum EmailFrequencyPreference
	{
		[Cpp2IlInjected.Token(Token = "0x4000147")]
		Daily = 10,
		[Cpp2IlInjected.Token(Token = "0x4000148")]
		Weekly = 20,
		[Cpp2IlInjected.Token(Token = "0x4000149")]
		Monthly = 30,
		[Cpp2IlInjected.Token(Token = "0x400014A")]
		Never = 40,
		[Cpp2IlInjected.Token(Token = "0x400014B")]
		Yes = 50
	}
	[Cpp2IlInjected.Token(Token = "0x2000073")]
	public enum AccountAgeBucket
	{
		[Cpp2IlInjected.Token(Token = "0x400014D")]
		BELOW_TEN = 0,
		[Cpp2IlInjected.Token(Token = "0x400014E")]
		BETWEEN_TEN_AND_TWELVE = 10,
		[Cpp2IlInjected.Token(Token = "0x400014F")]
		TEEN = 13,
		[Cpp2IlInjected.Token(Token = "0x4000150")]
		ADULT = 18,
		[Cpp2IlInjected.Token(Token = "0x4000151")]
		UNKNOWN = 999
	}
	[Cpp2IlInjected.Token(Token = "0x2000074")]
	public interface PWCZVKIUTHK
	{
		[Cpp2IlInjected.Token(Token = "0x1700012A")]
		int AccountId
		{
			[Cpp2IlInjected.Token(Token = "0x60002BF")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x1700012B")]
		string RawUsername
		{
			[Cpp2IlInjected.Token(Token = "0x60002C0")]
			[Cpp2IlInjected.Address(Slot = "1")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x1700012C")]
		string Username
		{
			[Cpp2IlInjected.Token(Token = "0x60002C1")]
			[Cpp2IlInjected.Address(Slot = "2")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x1700012D")]
		string DisplayName
		{
			[Cpp2IlInjected.Token(Token = "0x60002C2")]
			[Cpp2IlInjected.Address(Slot = "3")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x1700012E")]
		string DisplayEmoji
		{
			[Cpp2IlInjected.Token(Token = "0x60002C3")]
			[Cpp2IlInjected.Address(Slot = "4")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x1700012F")]
		string ProfileImage
		{
			[Cpp2IlInjected.Token(Token = "0x60002C4")]
			[Cpp2IlInjected.Address(Slot = "5")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000130")]
		string BannerImage
		{
			[Cpp2IlInjected.Token(Token = "0x60002C5")]
			[Cpp2IlInjected.Address(Slot = "6")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000131")]
		bool TreatAsJunior
		{
			[Cpp2IlInjected.Token(Token = "0x60002C6")]
			[Cpp2IlInjected.Address(Slot = "7")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000132")]
		bool HasBirthday
		{
			[Cpp2IlInjected.Token(Token = "0x60002C7")]
			[Cpp2IlInjected.Address(Slot = "8")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000133")]
		PersonalPronouns PersonalPronouns
		{
			[Cpp2IlInjected.Token(Token = "0x60002C8")]
			[Cpp2IlInjected.Address(Slot = "9")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000134")]
		IdentityFlags IdentityFlags
		{
			[Cpp2IlInjected.Token(Token = "0x60002C9")]
			[Cpp2IlInjected.Address(Slot = "10")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000135")]
		DateTime CreatedAt
		{
			[Cpp2IlInjected.Token(Token = "0x60002CA")]
			[Cpp2IlInjected.Address(Slot = "11")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000136")]
		bool? IsJunior
		{
			[Cpp2IlInjected.Token(Token = "0x60002CB")]
			[Cpp2IlInjected.Address(Slot = "12")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x60002CC")]
		[Cpp2IlInjected.Address(Slot = "13")]
		void WGVRXPLBZFV(bool a);

		[Cpp2IlInjected.Token(Token = "0x60002CD")]
		[Cpp2IlInjected.Address(Slot = "14")]
		void TFZLVUXNLXY(bool a);
	}
	[Cpp2IlInjected.Token(Token = "0x2000075")]
	public interface TOESZNWFQDM : PWCZVKIUTHK
	{
		[Cpp2IlInjected.Token(Token = "0x17000137")]
		string Email
		{
			[Cpp2IlInjected.Token(Token = "0x60002CE")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000138")]
		string Phone
		{
			[Cpp2IlInjected.Token(Token = "0x60002CF")]
			[Cpp2IlInjected.Address(Slot = "1")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000139")]
		DateTime? Birthday
		{
			[Cpp2IlInjected.Token(Token = "0x60002D0")]
			[Cpp2IlInjected.Address(Slot = "2")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x1700013A")]
		JuniorState JuniorState
		{
			[Cpp2IlInjected.Token(Token = "0x60002D1")]
			[Cpp2IlInjected.Address(Slot = "3")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x1700013B")]
		int? ParentAccountId
		{
			[Cpp2IlInjected.Token(Token = "0x60002D2")]
			[Cpp2IlInjected.Address(Slot = "4")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x1700013C")]
		int AvailableUsernameChanges
		{
			[Cpp2IlInjected.Token(Token = "0x60002D3")]
			[Cpp2IlInjected.Address(Slot = "5")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x1700013D")]
		bool CanChangeUsername
		{
			[Cpp2IlInjected.Token(Token = "0x60002D4")]
			[Cpp2IlInjected.Address(Slot = "6")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x1700013E")]
		bool IsConfirmed
		{
			[Cpp2IlInjected.Token(Token = "0x60002D5")]
			[Cpp2IlInjected.Address(Slot = "7")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x1700013F")]
		bool? IsFakeJuniorBirthday
		{
			[Cpp2IlInjected.Token(Token = "0x60002D6")]
			[Cpp2IlInjected.Address(Slot = "8")]
			get;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000076")]
	public class OLPAMRWEBWT
	{
		[Cpp2IlInjected.Token(Token = "0x17000140")]
		public PWCZVKIUTHK YYMISIZOKHD
		{
			[Cpp2IlInjected.Token(Token = "0x60002D7")]
			[Cpp2IlInjected.Address(RVA = "0xAA5FB0", Offset = "0xAA53B0", VA = "0x180AA5FB0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000141")]
		public PlatformDetailType JRULCMDOXMA
		{
			[Cpp2IlInjected.Token(Token = "0x60002D8")]
			[Cpp2IlInjected.Address(RVA = "0xAAC980", Offset = "0xAABD80", VA = "0x180AAC980")]
			[CompilerGenerated]
			get
			{
				return default(PlatformDetailType);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000142")]
		public string TUSCCFOBAEM
		{
			[Cpp2IlInjected.Token(Token = "0x60002D9")]
			[Cpp2IlInjected.Address(RVA = "0xAAB1C0", Offset = "0xAAA5C0", VA = "0x180AAB1C0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60002DA")]
		[Cpp2IlInjected.Address(RVA = "0x747BD30", Offset = "0x747B130", VA = "0x18747BD30")]
		public OLPAMRWEBWT(PWCZVKIUTHK a, PlatformDetailType b, string c)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000077")]
	public interface LYCQXCDLKMF
	{
		[Cpp2IlInjected.Token(Token = "0x17000143")]
		int AccountId
		{
			[Cpp2IlInjected.Token(Token = "0x60002DB")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000144")]
		bool DisallowInAppPurchases
		{
			[Cpp2IlInjected.Token(Token = "0x60002DC")]
			[Cpp2IlInjected.Address(Slot = "1")]
			get;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000078")]
	public interface WCWOUFGXXMV
	{
		[Cpp2IlInjected.Token(Token = "0x17000145")]
		int AccountId
		{
			[Cpp2IlInjected.Token(Token = "0x60002DD")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000146")]
		bool IsRecentHistoryVisible
		{
			[Cpp2IlInjected.Token(Token = "0x60002DE")]
			[Cpp2IlInjected.Address(Slot = "1")]
			get;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000079")]
	public interface YMFLPQORSBQ
	{
		[Cpp2IlInjected.Token(Token = "0x17000147")]
		int AccountId
		{
			[Cpp2IlInjected.Token(Token = "0x60002DF")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000148")]
		string Bio
		{
			[Cpp2IlInjected.Token(Token = "0x60002E0")]
			[Cpp2IlInjected.Address(Slot = "1")]
			get;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200007A")]
	public enum AvatarItemType
	{
		[Cpp2IlInjected.Token(Token = "0x4000156")]
		Outfit,
		[Cpp2IlInjected.Token(Token = "0x4000157")]
		HairDye,
		[Cpp2IlInjected.Token(Token = "0x4000158")]
		CustomOutfit
	}
	[Cpp2IlInjected.Token(Token = "0x200007B")]
	public class FSGHFJHNGMT
	{
		[Cpp2IlInjected.Token(Token = "0x17000149")]
		public AvatarItemType QPWMWZCGQBW
		{
			[Cpp2IlInjected.Token(Token = "0x60002E1")]
			[Cpp2IlInjected.Address(RVA = "0xAA3110", Offset = "0xAA2510", VA = "0x180AA3110")]
			[CompilerGenerated]
			get
			{
				return default(AvatarItemType);
			}
			[Cpp2IlInjected.Token(Token = "0x60002E2")]
			[Cpp2IlInjected.Address(RVA = "0xAAB1D0", Offset = "0xAAA5D0", VA = "0x180AAB1D0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700014A")]
		public string AMXDXJEJKJQ
		{
			[Cpp2IlInjected.Token(Token = "0x60002E3")]
			[Cpp2IlInjected.Address(RVA = "0xAAA880", Offset = "0xAA9C80", VA = "0x180AAA880")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60002E4")]
			[Cpp2IlInjected.Address(RVA = "0xAAA120", Offset = "0xAA9520", VA = "0x180AAA120")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700014B")]
		public string MCGNVIWESHH
		{
			[Cpp2IlInjected.Token(Token = "0x60002E5")]
			[Cpp2IlInjected.Address(RVA = "0xAAB1C0", Offset = "0xAAA5C0", VA = "0x180AAB1C0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60002E6")]
			[Cpp2IlInjected.Address(RVA = "0xAA67C0", Offset = "0xAA5BC0", VA = "0x180AA67C0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700014C")]
		public GiftRarity FBNCSPQDKXT
		{
			[Cpp2IlInjected.Token(Token = "0x60002E7")]
			[Cpp2IlInjected.Address(RVA = "0xAAB1A0", Offset = "0xAAA5A0", VA = "0x180AAB1A0")]
			[CompilerGenerated]
			get
			{
				return default(GiftRarity);
			}
			[Cpp2IlInjected.Token(Token = "0x60002E8")]
			[Cpp2IlInjected.Address(RVA = "0xAAB1B0", Offset = "0xAAA5B0", VA = "0x180AAB1B0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700014D")]
		public string EDUCRDDFIBY
		{
			[Cpp2IlInjected.Token(Token = "0x60002E9")]
			[Cpp2IlInjected.Address(RVA = "0xAAA140", Offset = "0xAA9540", VA = "0x180AAA140")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60002EA")]
			[Cpp2IlInjected.Address(RVA = "0xAADB00", Offset = "0xAACF00", VA = "0x180AADB00")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700014E")]
		public int IJJTSPETDBX
		{
			[Cpp2IlInjected.Token(Token = "0x60002EB")]
			[Cpp2IlInjected.Address(RVA = "0xAD4020", Offset = "0xAD3420", VA = "0x180AD4020")]
			[CompilerGenerated]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x60002EC")]
			[Cpp2IlInjected.Address(RVA = "0xB10400", Offset = "0xB0F800", VA = "0x180B10400")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700014F")]
		public bool WZGPZZORXFP
		{
			[Cpp2IlInjected.Token(Token = "0x60002ED")]
			[Cpp2IlInjected.Address(RVA = "0xBEE6C0", Offset = "0xBEDAC0", VA = "0x180BEE6C0")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x60002EE")]
			[Cpp2IlInjected.Address(RVA = "0xCDA280", Offset = "0xCD9680", VA = "0x180CDA280")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000150")]
		public AvatarItemDesc LEEPMUINQUJ
		{
			[Cpp2IlInjected.Token(Token = "0x60002EF")]
			[Cpp2IlInjected.Address(RVA = "0x77162E0", Offset = "0x77156E0", VA = "0x1877162E0")]
			[CompilerGenerated]
			get
			{
				return default(AvatarItemDesc);
			}
			[Cpp2IlInjected.Token(Token = "0x60002F0")]
			[Cpp2IlInjected.Address(RVA = "0x77162C0", Offset = "0x77156C0", VA = "0x1877162C0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000151")]
		public ColorId NJRGYKUZMJN
		{
			[Cpp2IlInjected.Token(Token = "0x60002F1")]
			[Cpp2IlInjected.Address(RVA = "0x5F1DFE0", Offset = "0x5F1D3E0", VA = "0x185F1DFE0")]
			[CompilerGenerated]
			get
			{
				return default(ColorId);
			}
			[Cpp2IlInjected.Token(Token = "0x60002F2")]
			[Cpp2IlInjected.Address(RVA = "0x5F23A80", Offset = "0x5F22E80", VA = "0x185F23A80")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000152")]
		public string DHKFNTLJFPB
		{
			[Cpp2IlInjected.Token(Token = "0x60002F3")]
			[Cpp2IlInjected.Address(RVA = "0xAAD040", Offset = "0xAAC440", VA = "0x180AAD040")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60002F4")]
			[Cpp2IlInjected.Address(RVA = "0xAAC9D0", Offset = "0xAABDD0", VA = "0x180AAC9D0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000153")]
		public DateTime UDOVAFHSSST
		{
			[Cpp2IlInjected.Token(Token = "0x60002F5")]
			[Cpp2IlInjected.Address(RVA = "0xAAC9A0", Offset = "0xAABDA0", VA = "0x180AAC9A0")]
			[CompilerGenerated]
			get
			{
				return default(DateTime);
			}
			[Cpp2IlInjected.Token(Token = "0x60002F6")]
			[Cpp2IlInjected.Address(RVA = "0x5BA20B0", Offset = "0x5BA14B0", VA = "0x185BA20B0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60002F7")]
		[Cpp2IlInjected.Address(RVA = "0x7716440", Offset = "0x7715840", VA = "0x187716440")]
		internal FSGHFJHNGMT(AvatarItemDetails a, LPSBIILHNSC b, GIRVIHNJJSH c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002F8")]
		[Cpp2IlInjected.Address(RVA = "0x7716300", Offset = "0x7715700", VA = "0x187716300")]
		public FSGHFJHNGMT(AvatarItemType a = AvatarItemType.Outfit, [Optional] AvatarItemDesc b, [Optional] string c, [Optional] string d, GiftRarity e = GiftRarity.Common, [Optional] string f, int g = 0, bool h = false, [Optional] string i, [Optional] DateTime? j)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200007C")]
	[Utf8JsonSerializable]
	public class AvatarItemDetails
	{
		[Cpp2IlInjected.Token(Token = "0x17000154")]
		public AvatarItemType AvatarItemType
		{
			[Cpp2IlInjected.Token(Token = "0x60002F9")]
			[Cpp2IlInjected.Address(RVA = "0xAA3110", Offset = "0xAA2510", VA = "0x180AA3110")]
			[CompilerGenerated]
			get
			{
				return default(AvatarItemType);
			}
			[Cpp2IlInjected.Token(Token = "0x60002FA")]
			[Cpp2IlInjected.Address(RVA = "0xAAB1D0", Offset = "0xAAA5D0", VA = "0x180AAB1D0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000155")]
		[DataMember(Name = "AvatarItemDesc")]
		public string AvatarItemDescString
		{
			[Cpp2IlInjected.Token(Token = "0x60002FB")]
			[Cpp2IlInjected.Address(RVA = "0xAAA880", Offset = "0xAA9C80", VA = "0x180AAA880")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60002FC")]
			[Cpp2IlInjected.Address(RVA = "0xAAA120", Offset = "0xAA9520", VA = "0x180AAA120")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000156")]
		public string FriendlyName
		{
			[Cpp2IlInjected.Token(Token = "0x60002FD")]
			[Cpp2IlInjected.Address(RVA = "0xAAB1C0", Offset = "0xAAA5C0", VA = "0x180AAB1C0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60002FE")]
			[Cpp2IlInjected.Address(RVA = "0xAA67C0", Offset = "0xAA5BC0", VA = "0x180AA67C0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000157")]
		public string Tooltip
		{
			[Cpp2IlInjected.Token(Token = "0x60002FF")]
			[Cpp2IlInjected.Address(RVA = "0xAAA820", Offset = "0xAA9C20", VA = "0x180AAA820")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000300")]
			[Cpp2IlInjected.Address(RVA = "0xAA67D0", Offset = "0xAA5BD0", VA = "0x180AA67D0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000158")]
		public GiftRarity Rarity
		{
			[Cpp2IlInjected.Token(Token = "0x6000301")]
			[Cpp2IlInjected.Address(RVA = "0xAAF800", Offset = "0xAAEC00", VA = "0x180AAF800")]
			[CompilerGenerated]
			get
			{
				return default(GiftRarity);
			}
			[Cpp2IlInjected.Token(Token = "0x6000302")]
			[Cpp2IlInjected.Address(RVA = "0xAAF7F0", Offset = "0xAAEBF0", VA = "0x180AAF7F0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000159")]
		public string TagList
		{
			[Cpp2IlInjected.Token(Token = "0x6000303")]
			[Cpp2IlInjected.Address(RVA = "0xAAA030", Offset = "0xAA9430", VA = "0x180AAA030")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000304")]
			[Cpp2IlInjected.Address(RVA = "0xAAA110", Offset = "0xAA9510", VA = "0x180AAA110")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700015A")]
		public int AvatarItemId
		{
			[Cpp2IlInjected.Token(Token = "0x6000305")]
			[Cpp2IlInjected.Address(RVA = "0xAC1F70", Offset = "0xAC1370", VA = "0x180AC1F70")]
			[CompilerGenerated]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x6000306")]
			[Cpp2IlInjected.Address(RVA = "0xBDCB60", Offset = "0xBDBF60", VA = "0x180BDCB60")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700015B")]
		public bool IsBaseAvatarItem
		{
			[Cpp2IlInjected.Token(Token = "0x6000307")]
			[Cpp2IlInjected.Address(RVA = "0x16C50A0", Offset = "0x16C44A0", VA = "0x1816C50A0")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000308")]
			[Cpp2IlInjected.Address(RVA = "0x16C5090", Offset = "0x16C4490", VA = "0x1816C5090")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700015C")]
		public string ThumbnailImage
		{
			[Cpp2IlInjected.Token(Token = "0x6000309")]
			[Cpp2IlInjected.Address(RVA = "0xAAA160", Offset = "0xAA9560", VA = "0x180AAA160")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600030A")]
			[Cpp2IlInjected.Address(RVA = "0xAAA870", Offset = "0xAA9C70", VA = "0x180AAA870")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700015D")]
		public DateTime CreatedAt
		{
			[Cpp2IlInjected.Token(Token = "0x600030B")]
			[Cpp2IlInjected.Address(RVA = "0xAA3370", Offset = "0xAA2770", VA = "0x180AA3370")]
			[CompilerGenerated]
			get
			{
				return default(DateTime);
			}
			[Cpp2IlInjected.Token(Token = "0x600030C")]
			[Cpp2IlInjected.Address(RVA = "0xCDA990", Offset = "0xCD9D90", VA = "0x180CDA990")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600030D")]
		[Cpp2IlInjected.Address(RVA = "0xAAC8E0", Offset = "0xAABCE0", VA = "0x180AAC8E0")]
		public AvatarItemDetails()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200007D")]
	[Utf8JsonSerializable]
	public sealed class GetLockedAvatarItemDetailsBulkAsPostRequest
	{
		[Cpp2IlInjected.Token(Token = "0x1700015E")]
		public List<string> AvatarItemDescriptions
		{
			[Cpp2IlInjected.Token(Token = "0x6000310")]
			[Cpp2IlInjected.Address(RVA = "0xAA5FB0", Offset = "0xAA53B0", VA = "0x180AA5FB0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000311")]
			[Cpp2IlInjected.Address(RVA = "0xAA5FC0", Offset = "0xAA53C0", VA = "0x180AA5FC0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600030E")]
		[Cpp2IlInjected.Address(RVA = "0x7717980", Offset = "0x7716D80", VA = "0x187717980")]
		public GetLockedAvatarItemDetailsBulkAsPostRequest()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600030F")]
		[Cpp2IlInjected.Address(RVA = "0xAA6010", Offset = "0xAA5410", VA = "0x180AA6010")]
		public GetLockedAvatarItemDetailsBulkAsPostRequest(List<string> avatarItemDescriptions)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200007E")]
	[Utf8JsonSerializable]
	public class CrmAssignmentDTO
	{
		[Cpp2IlInjected.Token(Token = "0x1700015F")]
		public CrmUserDTO UserConfig
		{
			[Cpp2IlInjected.Token(Token = "0x6000312")]
			[Cpp2IlInjected.Address(RVA = "0xAA5FB0", Offset = "0xAA53B0", VA = "0x180AA5FB0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000313")]
			[Cpp2IlInjected.Address(RVA = "0xAA5FC0", Offset = "0xAA53C0", VA = "0x180AA5FC0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000160")]
		public BrazeConfigDTO BrazeConfig
		{
			[Cpp2IlInjected.Token(Token = "0x6000314")]
			[Cpp2IlInjected.Address(RVA = "0xAAA880", Offset = "0xAA9C80", VA = "0x180AAA880")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000315")]
			[Cpp2IlInjected.Address(RVA = "0xAAA120", Offset = "0xAA9520", VA = "0x180AAA120")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000316")]
		[Cpp2IlInjected.Address(RVA = "0xAAC8E0", Offset = "0xAABCE0", VA = "0x180AAC8E0")]
		public CrmAssignmentDTO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000317")]
		[Cpp2IlInjected.Address(RVA = "0xAA8230", Offset = "0xAA7630", VA = "0x180AA8230")]
		public CrmAssignmentDTO(CrmUserDTO userConfig, BrazeConfigDTO brazeConfig)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200007F")]
	public enum CrmType
	{
		[Cpp2IlInjected.Token(Token = "0x4000172")]
		None,
		[Cpp2IlInjected.Token(Token = "0x4000173")]
		Braze,
		[Cpp2IlInjected.Token(Token = "0x4000174")]
		Rengage
	}
	[Cpp2IlInjected.Token(Token = "0x2000080")]
	public enum PushNotificationServices : byte
	{
		[Cpp2IlInjected.Token(Token = "0x4000176")]
		APNS,
		[Cpp2IlInjected.Token(Token = "0x4000177")]
		Firebase,
		[Cpp2IlInjected.Token(Token = "0x4000178")]
		Mock,
		[Cpp2IlInjected.Token(Token = "0x4000179")]
		Braze,
		[Cpp2IlInjected.Token(Token = "0x400017A")]
		Rengage
	}
	[Cpp2IlInjected.Token(Token = "0x2000081")]
	[Utf8JsonSerializable]
	public class CrmUserDTO
	{
		[Cpp2IlInjected.Token(Token = "0x17000161")]
		public CrmType AssignedCrmType
		{
			[Cpp2IlInjected.Token(Token = "0x6000318")]
			[Cpp2IlInjected.Address(RVA = "0xAA3110", Offset = "0xAA2510", VA = "0x180AA3110")]
			[CompilerGenerated]
			get
			{
				return default(CrmType);
			}
			[Cpp2IlInjected.Token(Token = "0x6000319")]
			[Cpp2IlInjected.Address(RVA = "0xAAB1D0", Offset = "0xAAA5D0", VA = "0x180AAB1D0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000162")]
		public PushNotificationServices? AssignedPushNotificationService
		{
			[Cpp2IlInjected.Token(Token = "0x600031A")]
			[Cpp2IlInjected.Address(RVA = "0x2F8EA80", Offset = "0x2F8DE80", VA = "0x182F8EA80")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600031B")]
			[Cpp2IlInjected.Address(RVA = "0x75BBBD0", Offset = "0x75BAFD0", VA = "0x1875BBBD0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000163")]
		public bool AllowPush
		{
			[Cpp2IlInjected.Token(Token = "0x600031C")]
			[Cpp2IlInjected.Address(RVA = "0x1108AD0", Offset = "0x1107ED0", VA = "0x181108AD0")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x600031D")]
			[Cpp2IlInjected.Address(RVA = "0x1108B10", Offset = "0x1107F10", VA = "0x181108B10")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600031E")]
		[Cpp2IlInjected.Address(RVA = "0x77156C0", Offset = "0x7714AC0", VA = "0x1877156C0")]
		public CrmUserDTO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600031F")]
		[Cpp2IlInjected.Address(RVA = "0x7715630", Offset = "0x7714A30", VA = "0x187715630")]
		public CrmUserDTO(CrmType assignedCrmType, PushNotificationServices assignedPushNotificationService, bool allowPush)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000082")]
	[Utf8JsonSerializable]
	public class BrazeConfigDTO
	{
		[Cpp2IlInjected.Token(Token = "0x17000164")]
		public string AppId
		{
			[Cpp2IlInjected.Token(Token = "0x6000320")]
			[Cpp2IlInjected.Address(RVA = "0xAA5FB0", Offset = "0xAA53B0", VA = "0x180AA5FB0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000321")]
			[Cpp2IlInjected.Address(RVA = "0xAA5FC0", Offset = "0xAA53C0", VA = "0x180AA5FC0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000165")]
		public string SdkEndpoint
		{
			[Cpp2IlInjected.Token(Token = "0x6000322")]
			[Cpp2IlInjected.Address(RVA = "0xAAA880", Offset = "0xAA9C80", VA = "0x180AAA880")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000323")]
			[Cpp2IlInjected.Address(RVA = "0xAAA120", Offset = "0xAA9520", VA = "0x180AAA120")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000324")]
		[Cpp2IlInjected.Address(RVA = "0xAAC8E0", Offset = "0xAABCE0", VA = "0x180AAC8E0")]
		public BrazeConfigDTO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000325")]
		[Cpp2IlInjected.Address(RVA = "0xAA8230", Offset = "0xAA7630", VA = "0x180AA8230")]
		public BrazeConfigDTO(string appId, string sdkEndpoint)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000083")]
	public enum DeviceClass
	{
		[Cpp2IlInjected.Token(Token = "0x4000181")]
		Unknown,
		[Cpp2IlInjected.Token(Token = "0x4000182")]
		VR,
		[Cpp2IlInjected.Token(Token = "0x4000183")]
		Screen,
		[Cpp2IlInjected.Token(Token = "0x4000184")]
		Mobile,
		[Cpp2IlInjected.Token(Token = "0x4000185")]
		VRLow,
		[Cpp2IlInjected.Token(Token = "0x4000186")]
		Quest2
	}
	[Cpp2IlInjected.Token(Token = "0x2000084")]
	public struct GiftPackageReceivedArgs
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000187")]
		public GiftPackage GiftPackage;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000188")]
		public bool ShowImmediately;

		[Cpp2IlInjected.FieldOffset(Offset = "0x9")]
		[Cpp2IlInjected.Token(Token = "0x4000189")]
		public bool DismissExisting;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA")]
		[Cpp2IlInjected.Token(Token = "0x400018A")]
		public bool ShowNotification;
	}
	[Cpp2IlInjected.Token(Token = "0x2000085")]
	[Utf8JsonSerializable]
	public class GiftPackage : ZTDEQBSEMSX, DURPPUIUDDT
	{
		[Cpp2IlInjected.Token(Token = "0x400018B")]
		internal static Action<GiftPackage> KEDJVRQIRCF;

		[Cpp2IlInjected.Token(Token = "0x400018C")]
		internal static Func<GiftPackage, Task> VQGQYXIGILL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x101")]
		[Cpp2IlInjected.Token(Token = "0x40001AB")]
		[IgnoreDataMember]
		public bool IsGifted;

		[Cpp2IlInjected.Token(Token = "0x17000166")]
		public long? Id
		{
			[Cpp2IlInjected.Token(Token = "0x6000326")]
			[Cpp2IlInjected.Address(RVA = "0xBAF500", Offset = "0xBAE900", VA = "0x180BAF500")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000327")]
			[Cpp2IlInjected.Address(RVA = "0xBAF520", Offset = "0xBAE920", VA = "0x180BAF520")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000167")]
		public int PlayerId
		{
			[Cpp2IlInjected.Token(Token = "0x6000328")]
			[Cpp2IlInjected.Address(RVA = "0xAB5660", Offset = "0xAB4A60", VA = "0x180AB5660")]
			[CompilerGenerated]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x6000329")]
			[Cpp2IlInjected.Address(RVA = "0xB07AB0", Offset = "0xB06EB0", VA = "0x180B07AB0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000168")]
		public int? FromPlayerId
		{
			[Cpp2IlInjected.Token(Token = "0x600032A")]
			[Cpp2IlInjected.Address(RVA = "0x10D2A90", Offset = "0x10D1E90", VA = "0x1810D2A90")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600032B")]
			[Cpp2IlInjected.Address(RVA = "0xDB0160", Offset = "0xDAF560", VA = "0x180DB0160")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000169")]
		public string ConsumableItemDesc
		{
			[Cpp2IlInjected.Token(Token = "0x600032C")]
			[Cpp2IlInjected.Address(RVA = "0xAAA140", Offset = "0xAA9540", VA = "0x180AAA140")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600032D")]
			[Cpp2IlInjected.Address(RVA = "0xAADB00", Offset = "0xAACF00", VA = "0x180AADB00")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700016A")]
		public AvatarItemType? AvatarItemType
		{
			[Cpp2IlInjected.Token(Token = "0x600032E")]
			[Cpp2IlInjected.Address(RVA = "0xAAA030", Offset = "0xAA9430", VA = "0x180AAA030")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600032F")]
			[Cpp2IlInjected.Address(RVA = "0xAAF810", Offset = "0xAAEC10", VA = "0x180AAF810")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700016B")]
		[DataMember(Name = "AvatarItemDesc")]
		public string AvatarItemDescOrHairDyeDesc
		{
			[Cpp2IlInjected.Token(Token = "0x6000330")]
			[Cpp2IlInjected.Address(RVA = "0xAAA810", Offset = "0xAA9C10", VA = "0x180AAA810")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000331")]
			[Cpp2IlInjected.Address(RVA = "0xAAA840", Offset = "0xAA9C40", VA = "0x180AAA840")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700016C")]
		public Guid? CustomAvatarItemId
		{
			[Cpp2IlInjected.Token(Token = "0x6000332")]
			[Cpp2IlInjected.Address(RVA = "0xB0DED0", Offset = "0xB0D2D0", VA = "0x180B0DED0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000333")]
			[Cpp2IlInjected.Address(RVA = "0xB0E8D0", Offset = "0xB0DCD0", VA = "0x180B0E8D0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700016D")]
		public string EquipmentPrefabName
		{
			[Cpp2IlInjected.Token(Token = "0x6000334")]
			[Cpp2IlInjected.Address(RVA = "0xAA3380", Offset = "0xAA2780", VA = "0x180AA3380")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000335")]
			[Cpp2IlInjected.Address(RVA = "0xAA3130", Offset = "0xAA2530", VA = "0x180AA3130")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700016E")]
		public string EquipmentModificationGuid
		{
			[Cpp2IlInjected.Token(Token = "0x6000336")]
			[Cpp2IlInjected.Address(RVA = "0xAA3120", Offset = "0xAA2520", VA = "0x180AA3120")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000337")]
			[Cpp2IlInjected.Address(RVA = "0xAA3140", Offset = "0xAA2540", VA = "0x180AA3140")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700016F")]
		public Guid? PurchasableXpBoostId
		{
			[Cpp2IlInjected.Token(Token = "0x6000338")]
			[Cpp2IlInjected.Address(RVA = "0x7717C50", Offset = "0x7717050", VA = "0x187717C50")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000339")]
			[Cpp2IlInjected.Address(RVA = "0x7717CA0", Offset = "0x77170A0", VA = "0x187717CA0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000170")]
		public float? XpBoostMultiplier
		{
			[Cpp2IlInjected.Token(Token = "0x600033A")]
			[Cpp2IlInjected.Address(RVA = "0x7717C90", Offset = "0x7717090", VA = "0x187717C90")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600033B")]
			[Cpp2IlInjected.Address(RVA = "0x2789400", Offset = "0x2788800", VA = "0x182789400")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000171")]
		public int? XpBoostDurationMinutes
		{
			[Cpp2IlInjected.Token(Token = "0x600033C")]
			[Cpp2IlInjected.Address(RVA = "0x7717C80", Offset = "0x7717080", VA = "0x187717C80")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600033D")]
			[Cpp2IlInjected.Address(RVA = "0x7717CD0", Offset = "0x77170D0", VA = "0x187717CD0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000172")]
		public CurrencyType CurrencyType
		{
			[Cpp2IlInjected.Token(Token = "0x600033E")]
			[Cpp2IlInjected.Address(RVA = "0x155F6B0", Offset = "0x155EAB0", VA = "0x18155F6B0")]
			[CompilerGenerated]
			get
			{
				return default(CurrencyType);
			}
			[Cpp2IlInjected.Token(Token = "0x600033F")]
			[Cpp2IlInjected.Address(RVA = "0x1559C20", Offset = "0x1559020", VA = "0x181559C20")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000173")]
		public int Currency
		{
			[Cpp2IlInjected.Token(Token = "0x6000340")]
			[Cpp2IlInjected.Address(RVA = "0x131B4B0", Offset = "0x131A8B0", VA = "0x18131B4B0")]
			[CompilerGenerated]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x6000341")]
			[Cpp2IlInjected.Address(RVA = "0x1C5CE20", Offset = "0x1C5C220", VA = "0x181C5CE20")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000174")]
		public int Xp
		{
			[Cpp2IlInjected.Token(Token = "0x6000342")]
			[Cpp2IlInjected.Address(RVA = "0x2B23DE0", Offset = "0x2B231E0", VA = "0x182B23DE0")]
			[CompilerGenerated]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x6000343")]
			[Cpp2IlInjected.Address(RVA = "0x755AEA0", Offset = "0x755A2A0", VA = "0x18755AEA0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000175")]
		public GiftContext GiftContext
		{
			[Cpp2IlInjected.Token(Token = "0x6000344")]
			[Cpp2IlInjected.Address(RVA = "0xAAC9B0", Offset = "0xAABDB0", VA = "0x180AAC9B0")]
			[CompilerGenerated]
			get
			{
				return default(GiftContext);
			}
			[Cpp2IlInjected.Token(Token = "0x6000345")]
			[Cpp2IlInjected.Address(RVA = "0xAAD020", Offset = "0xAAC420", VA = "0x180AAD020")]
			[CompilerGenerated]
			internal set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000176")]
		public GiftRarity GiftRarity
		{
			[Cpp2IlInjected.Token(Token = "0x6000346")]
			[Cpp2IlInjected.Address(RVA = "0xAFC8A0", Offset = "0xAFBCA0", VA = "0x180AFC8A0")]
			[CompilerGenerated]
			get
			{
				return default(GiftRarity);
			}
			[Cpp2IlInjected.Token(Token = "0x6000347")]
			[Cpp2IlInjected.Address(RVA = "0xC238B0", Offset = "0xC22CB0", VA = "0x180C238B0")]
			[CompilerGenerated]
			internal set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000177")]
		[DataMember(Name = "Message")]
		public string RawMessage
		{
			[Cpp2IlInjected.Token(Token = "0x6000348")]
			[Cpp2IlInjected.Address(RVA = "0xAA6A40", Offset = "0xAA5E40", VA = "0x180AA6A40")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000349")]
			[Cpp2IlInjected.Address(RVA = "0xAA6A70", Offset = "0xAA5E70", VA = "0x180AA6A70")]
			[CompilerGenerated]
			internal set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000178")]
		public string Signature
		{
			[Cpp2IlInjected.Token(Token = "0x600034A")]
			[Cpp2IlInjected.Address(RVA = "0xC24EE0", Offset = "0xC242E0", VA = "0x180C24EE0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600034B")]
			[Cpp2IlInjected.Address(RVA = "0xCE6C10", Offset = "0xCE6010", VA = "0x180CE6C10")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000179")]
		public bool IsSignatureValid
		{
			[Cpp2IlInjected.Token(Token = "0x600034C")]
			[Cpp2IlInjected.Address(RVA = "0xC4DC10", Offset = "0xC4D010", VA = "0x180C4DC10")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x600034D")]
			[Cpp2IlInjected.Address(RVA = "0xC4B940", Offset = "0xC4AD40", VA = "0x180C4B940")]
			[CompilerGenerated]
			internal set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700017A")]
		public PlatformType Platform
		{
			[Cpp2IlInjected.Token(Token = "0x600034E")]
			[Cpp2IlInjected.Address(RVA = "0xDC15F0", Offset = "0xDC09F0", VA = "0x180DC15F0")]
			[CompilerGenerated]
			get
			{
				return default(PlatformType);
			}
			[Cpp2IlInjected.Token(Token = "0x600034F")]
			[Cpp2IlInjected.Address(RVA = "0xDC1480", Offset = "0xDC0880", VA = "0x180DC1480")]
			[CompilerGenerated]
			internal set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700017B")]
		public PlatformMask PlatformsToSpawnOn
		{
			[Cpp2IlInjected.Token(Token = "0x6000350")]
			[Cpp2IlInjected.Address(RVA = "0xBE6770", Offset = "0xBE5B70", VA = "0x180BE6770")]
			[CompilerGenerated]
			get
			{
				return default(PlatformMask);
			}
			[Cpp2IlInjected.Token(Token = "0x6000351")]
			[Cpp2IlInjected.Address(RVA = "0x1F6B0B0", Offset = "0x1F6A4B0", VA = "0x181F6B0B0")]
			[CompilerGenerated]
			internal set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700017C")]
		public StorefrontBalanceType? BalanceType
		{
			[Cpp2IlInjected.Token(Token = "0x6000352")]
			[Cpp2IlInjected.Address(RVA = "0x74C0C00", Offset = "0x74C0000", VA = "0x1874C0C00")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000353")]
			[Cpp2IlInjected.Address(RVA = "0x74C0D10", Offset = "0x74C0110", VA = "0x1874C0D10")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700017D")]
		public long? RoomId
		{
			[Cpp2IlInjected.Token(Token = "0x6000354")]
			[Cpp2IlInjected.Address(RVA = "0x7717C70", Offset = "0x7717070", VA = "0x187717C70")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000355")]
			[Cpp2IlInjected.Address(RVA = "0x7717CC0", Offset = "0x77170C0", VA = "0x187717CC0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700017E")]
		public string GiftDescription
		{
			[Cpp2IlInjected.Token(Token = "0x6000356")]
			[Cpp2IlInjected.Address(RVA = "0xC666E0", Offset = "0xC65AE0", VA = "0x180C666E0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000357")]
			[Cpp2IlInjected.Address(RVA = "0xDEC850", Offset = "0xDEBC50", VA = "0x180DEC850")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700017F")]
		public bool HasAvatarItemOrHairDye
		{
			[Cpp2IlInjected.Token(Token = "0x6000358")]
			[Cpp2IlInjected.Address(RVA = "0x7717B20", Offset = "0x7716F20", VA = "0x187717B20")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000180")]
		public bool HasEquipment
		{
			[Cpp2IlInjected.Token(Token = "0x6000359")]
			[Cpp2IlInjected.Address(RVA = "0x7717BB0", Offset = "0x7716FB0", VA = "0x187717BB0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000181")]
		public bool HasConsumable
		{
			[Cpp2IlInjected.Token(Token = "0x600035A")]
			[Cpp2IlInjected.Address(RVA = "0x7717B90", Offset = "0x7716F90", VA = "0x187717B90")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000182")]
		public bool HasPurchasableXpBoost
		{
			[Cpp2IlInjected.Token(Token = "0x600035B")]
			[Cpp2IlInjected.Address(RVA = "0x7717BD0", Offset = "0x7716FD0", VA = "0x187717BD0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000183")]
		public bool HasUGCGift
		{
			[Cpp2IlInjected.Token(Token = "0x600035C")]
			[Cpp2IlInjected.Address(RVA = "0x7717C00", Offset = "0x7717000", VA = "0x187717C00")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000184")]
		[IgnoreDataMember]
		public bool Consumed
		{
			[Cpp2IlInjected.Token(Token = "0x600035D")]
			[Cpp2IlInjected.Address(RVA = "0xDC2D00", Offset = "0xDC2100", VA = "0x180DC2D00")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x600035E")]
			[Cpp2IlInjected.Address(RVA = "0xDC2430", Offset = "0xDC1830", VA = "0x180DC2430")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000185")]
		[IgnoreDataMember]
		public bool IsValid
		{
			[Cpp2IlInjected.Token(Token = "0x600035F")]
			[Cpp2IlInjected.Address(RVA = "0xDC21A0", Offset = "0xDC15A0", VA = "0x180DC21A0")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000360")]
			[Cpp2IlInjected.Address(RVA = "0xDC2000", Offset = "0xDC1400", VA = "0x180DC2000")]
			[CompilerGenerated]
			internal set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000186")]
		[IgnoreDataMember]
		public string CustomMessage
		{
			[Cpp2IlInjected.Token(Token = "0x6000361")]
			[Cpp2IlInjected.Address(RVA = "0xC666D0", Offset = "0xC65AD0", VA = "0x180C666D0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000362")]
			[Cpp2IlInjected.Address(RVA = "0x1418530", Offset = "0x1417930", VA = "0x181418530")]
			[CompilerGenerated]
			internal set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000187")]
		[IgnoreDataMember]
		public string ErrorMessage
		{
			[Cpp2IlInjected.Token(Token = "0x6000363")]
			[Cpp2IlInjected.Address(RVA = "0xB688D0", Offset = "0xB67CD0", VA = "0x180B688D0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000364")]
			[Cpp2IlInjected.Address(RVA = "0x1207780", Offset = "0x1206B80", VA = "0x181207780")]
			[CompilerGenerated]
			internal set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000188")]
		[IgnoreDataMember]
		public bool CanSpawnOnCurrentPlatform
		{
			[Cpp2IlInjected.Token(Token = "0x6000365")]
			[Cpp2IlInjected.Address(RVA = "0xFC9BB0", Offset = "0xFC8FB0", VA = "0x180FC9BB0")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000366")]
			[Cpp2IlInjected.Address(RVA = "0x12410E0", Offset = "0x12404E0", VA = "0x1812410E0")]
			[CompilerGenerated]
			internal set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000367")]
		[Cpp2IlInjected.Address(RVA = "0x7717AC0", Offset = "0x7716EC0", VA = "0x187717AC0", Slot = "4")]
		public void NTJAWBDBXVU()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000368")]
		[Cpp2IlInjected.Address(RVA = "0x7717A00", Offset = "0x7716E00", VA = "0x187717A00", Slot = "5")]
		public Task NLICNVNCYRU()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000369")]
		[Cpp2IlInjected.Address(RVA = "0xAAD020", Offset = "0xAAC420", VA = "0x180AAD020")]
		public void CSSWQKFUHET(GiftContext a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600036A")]
		[Cpp2IlInjected.Address(RVA = "0xAAC8E0", Offset = "0xAABCE0", VA = "0x180AAC8E0")]
		public GiftPackage()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000086")]
	public interface SAPTISIRZAZ
	{
		[Cpp2IlInjected.Token(Token = "0x17000189")]
		long InventionId
		{
			[Cpp2IlInjected.Token(Token = "0x600036D")]
			[Cpp2IlInjected.Address(Slot = "2")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x1700018A")]
		string ReplicationId
		{
			[Cpp2IlInjected.Token(Token = "0x600036E")]
			[Cpp2IlInjected.Address(Slot = "3")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x1700018B")]
		int CreatorPlayerId
		{
			[Cpp2IlInjected.Token(Token = "0x600036F")]
			[Cpp2IlInjected.Address(Slot = "4")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x1700018C")]
		string Name
		{
			[Cpp2IlInjected.Token(Token = "0x6000370")]
			[Cpp2IlInjected.Address(Slot = "5")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x1700018D")]
		string Description
		{
			[Cpp2IlInjected.Token(Token = "0x6000371")]
			[Cpp2IlInjected.Address(Slot = "6")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x1700018E")]
		string LongDescription
		{
			[Cpp2IlInjected.Token(Token = "0x6000372")]
			[Cpp2IlInjected.Address(Slot = "7")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x1700018F")]
		string ImageName
		{
			[Cpp2IlInjected.Token(Token = "0x6000373")]
			[Cpp2IlInjected.Address(Slot = "8")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000190")]
		byte UgcVersion
		{
			[Cpp2IlInjected.Token(Token = "0x6000374")]
			[Cpp2IlInjected.Address(Slot = "9")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000191")]
		int CurrentVersionNumber
		{
			[Cpp2IlInjected.Token(Token = "0x6000375")]
			[Cpp2IlInjected.Address(Slot = "10")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000192")]
		int LatestVersionNumber
		{
			[Cpp2IlInjected.Token(Token = "0x6000376")]
			[Cpp2IlInjected.Address(Slot = "11")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000193")]
		UgcAccessibility Accessibility
		{
			[Cpp2IlInjected.Token(Token = "0x6000377")]
			[Cpp2IlInjected.Address(Slot = "12")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000194")]
		bool ForceCannotPublish
		{
			[Cpp2IlInjected.Token(Token = "0x6000378")]
			[Cpp2IlInjected.Address(Slot = "13")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000195")]
		DateTime ModifiedAt
		{
			[Cpp2IlInjected.Token(Token = "0x6000379")]
			[Cpp2IlInjected.Address(Slot = "14")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000196")]
		DateTime CreatedAt
		{
			[Cpp2IlInjected.Token(Token = "0x600037A")]
			[Cpp2IlInjected.Address(Slot = "15")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000197")]
		DateTime? FirstPublishedAt
		{
			[Cpp2IlInjected.Token(Token = "0x600037B")]
			[Cpp2IlInjected.Address(Slot = "16")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000198")]
		long? CreationRoomId
		{
			[Cpp2IlInjected.Token(Token = "0x600037C")]
			[Cpp2IlInjected.Address(Slot = "17")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000199")]
		int NumPlayersHaveUsedInRoom
		{
			[Cpp2IlInjected.Token(Token = "0x600037D")]
			[Cpp2IlInjected.Address(Slot = "18")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x1700019A")]
		int NumDownloads
		{
			[Cpp2IlInjected.Token(Token = "0x600037E")]
			[Cpp2IlInjected.Address(Slot = "19")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x1700019B")]
		int CheerCount
		{
			[Cpp2IlInjected.Token(Token = "0x600037F")]
			[Cpp2IlInjected.Address(Slot = "20")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x1700019C")]
		InventionPermission CreatorPermission
		{
			[Cpp2IlInjected.Token(Token = "0x6000380")]
			[Cpp2IlInjected.Address(Slot = "21")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x1700019D")]
		InventionPermission GeneralPermission
		{
			[Cpp2IlInjected.Token(Token = "0x6000381")]
			[Cpp2IlInjected.Address(Slot = "22")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x1700019E")]
		bool IsAgInvention
		{
			[Cpp2IlInjected.Token(Token = "0x6000382")]
			[Cpp2IlInjected.Address(Slot = "23")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x1700019F")]
		bool IsCertifiedInvention
		{
			[Cpp2IlInjected.Token(Token = "0x6000383")]
			[Cpp2IlInjected.Address(Slot = "24")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x170001A0")]
		bool IsRecRoomApproved
		{
			[Cpp2IlInjected.Token(Token = "0x6000384")]
			[Cpp2IlInjected.Address(Slot = "25")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x170001A1")]
		bool AllowTrial
		{
			[Cpp2IlInjected.Token(Token = "0x6000385")]
			[Cpp2IlInjected.Address(Slot = "26")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x170001A2")]
		int? Price
		{
			[Cpp2IlInjected.Token(Token = "0x6000386")]
			[Cpp2IlInjected.Address(Slot = "27")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x170001A3")]
		bool HideFromPlayer
		{
			[Cpp2IlInjected.Token(Token = "0x6000387")]
			[Cpp2IlInjected.Address(Slot = "28")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x170001A4")]
		string DisplayMetadataJson
		{
			[Cpp2IlInjected.Token(Token = "0x6000388")]
			[Cpp2IlInjected.Address(Slot = "29")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x600036B")]
		[Cpp2IlInjected.Address(Slot = "0")]
		bool HJWJRNQLPGQ();

		[Cpp2IlInjected.Token(Token = "0x600036C")]
		[Cpp2IlInjected.Address(Slot = "1")]
		bool KHOPWHYZGMM();
	}
	[Cpp2IlInjected.Token(Token = "0x2000087")]
	[Utf8JsonSerializable]
	public class InventionDetails
	{
		[Cpp2IlInjected.Token(Token = "0x170001A5")]
		public List<TagDTO> Tags
		{
			[Cpp2IlInjected.Token(Token = "0x6000389")]
			[Cpp2IlInjected.Address(RVA = "0xAA5FB0", Offset = "0xAA53B0", VA = "0x180AA5FB0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600038A")]
			[Cpp2IlInjected.Address(RVA = "0xAA5FC0", Offset = "0xAA53C0", VA = "0x180AA5FC0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600038B")]
		[Cpp2IlInjected.Address(RVA = "0x77187B0", Offset = "0x7717BB0", VA = "0x1877187B0")]
		public List<string> QNFQUUIPZKG(params TagType[] tagTypes)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600038C")]
		[Cpp2IlInjected.Address(RVA = "0x7718740", Offset = "0x7717B40", VA = "0x187718740")]
		public List<string> OXQMMMELXMU()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600038D")]
		[Cpp2IlInjected.Address(RVA = "0x77186C0", Offset = "0x7717AC0", VA = "0x1877186C0")]
		public List<string> DZHNZKLHRWR()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600038E")]
		[Cpp2IlInjected.Address(RVA = "0x7718970", Offset = "0x7717D70", VA = "0x187718970")]
		public List<string> VTJHIAOYNCS()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600038F")]
		[Cpp2IlInjected.Address(RVA = "0xAAC8E0", Offset = "0xAABCE0", VA = "0x180AAC8E0")]
		public InventionDetails()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000088")]
	[Utf8JsonSerializable]
	public class InventionCreatorIdDTO
	{
		[Cpp2IlInjected.Token(Token = "0x170001A6")]
		public int CreatorPlayerId
		{
			[Cpp2IlInjected.Token(Token = "0x6000390")]
			[Cpp2IlInjected.Address(RVA = "0xAA3110", Offset = "0xAA2510", VA = "0x180AA3110")]
			[CompilerGenerated]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x6000391")]
			[Cpp2IlInjected.Address(RVA = "0xAAB1D0", Offset = "0xAAA5D0", VA = "0x180AAB1D0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000392")]
		[Cpp2IlInjected.Address(RVA = "0xAAC8E0", Offset = "0xAABCE0", VA = "0x180AAC8E0")]
		public InventionCreatorIdDTO()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000089")]
	[Utf8JsonSerializable]
	public class InventionVersion
	{
		[Cpp2IlInjected.Token(Token = "0x170001A7")]
		public long InventionId
		{
			[Cpp2IlInjected.Token(Token = "0x6000393")]
			[Cpp2IlInjected.Address(RVA = "0xAA5FB0", Offset = "0xAA53B0", VA = "0x180AA5FB0")]
			[CompilerGenerated]
			get
			{
				return default(long);
			}
			[Cpp2IlInjected.Token(Token = "0x6000394")]
			[Cpp2IlInjected.Address(RVA = "0xB96550", Offset = "0xB95950", VA = "0x180B96550")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001A8")]
		public string ReplicationId
		{
			[Cpp2IlInjected.Token(Token = "0x6000395")]
			[Cpp2IlInjected.Address(RVA = "0xAAA880", Offset = "0xAA9C80", VA = "0x180AAA880")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000396")]
			[Cpp2IlInjected.Address(RVA = "0xAAA120", Offset = "0xAA9520", VA = "0x180AAA120")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001A9")]
		public int VersionNumber
		{
			[Cpp2IlInjected.Token(Token = "0x6000397")]
			[Cpp2IlInjected.Address(RVA = "0xAB5660", Offset = "0xAB4A60", VA = "0x180AB5660")]
			[CompilerGenerated]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x6000398")]
			[Cpp2IlInjected.Address(RVA = "0xB07AB0", Offset = "0xB06EB0", VA = "0x180B07AB0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001AA")]
		public bool HasBetaContent
		{
			[Cpp2IlInjected.Token(Token = "0x6000399")]
			[Cpp2IlInjected.Address(RVA = "0xBBFFE0", Offset = "0xBBF3E0", VA = "0x180BBFFE0")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x600039A")]
			[Cpp2IlInjected.Address(RVA = "0xBC0B40", Offset = "0xBBFF40", VA = "0x180BC0B40")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001AB")]
		public int InstantiationCost
		{
			[Cpp2IlInjected.Token(Token = "0x600039B")]
			[Cpp2IlInjected.Address(RVA = "0xAAB1A0", Offset = "0xAAA5A0", VA = "0x180AAB1A0")]
			[CompilerGenerated]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x600039C")]
			[Cpp2IlInjected.Address(RVA = "0xAAB1B0", Offset = "0xAAA5B0", VA = "0x180AAB1B0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001AC")]
		public int LightsCost
		{
			[Cpp2IlInjected.Token(Token = "0x600039D")]
			[Cpp2IlInjected.Address(RVA = "0xC4E8F0", Offset = "0xC4DCF0", VA = "0x180C4E8F0")]
			[CompilerGenerated]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x600039E")]
			[Cpp2IlInjected.Address(RVA = "0x1ACB200", Offset = "0x1ACA600", VA = "0x181ACB200")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001AD")]
		public int ChipsCost
		{
			[Cpp2IlInjected.Token(Token = "0x600039F")]
			[Cpp2IlInjected.Address(RVA = "0xAAF800", Offset = "0xAAEC00", VA = "0x180AAF800")]
			[CompilerGenerated]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x60003A0")]
			[Cpp2IlInjected.Address(RVA = "0xAAF7F0", Offset = "0xAAEBF0", VA = "0x180AAF7F0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001AE")]
		public int CloudVariablesCost
		{
			[Cpp2IlInjected.Token(Token = "0x60003A1")]
			[Cpp2IlInjected.Address(RVA = "0xAF32A0", Offset = "0xAF26A0", VA = "0x180AF32A0")]
			[CompilerGenerated]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x60003A2")]
			[Cpp2IlInjected.Address(RVA = "0x13D1290", Offset = "0x13D0690", VA = "0x1813D1290")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001AF")]
		public string BlobName
		{
			[Cpp2IlInjected.Token(Token = "0x60003A3")]
			[Cpp2IlInjected.Address(RVA = "0xAAA030", Offset = "0xAA9430", VA = "0x180AAA030")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60003A4")]
			[Cpp2IlInjected.Address(RVA = "0xAAA110", Offset = "0xAA9510", VA = "0x180AAA110")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001B0")]
		public string BlobHash
		{
			[Cpp2IlInjected.Token(Token = "0x60003A5")]
			[Cpp2IlInjected.Address(RVA = "0xAAA810", Offset = "0xAA9C10", VA = "0x180AAA810")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60003A6")]
			[Cpp2IlInjected.Address(RVA = "0xAAA840", Offset = "0xAA9C40", VA = "0x180AAA840")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001B1")]
		public DateTime CreatedAt
		{
			[Cpp2IlInjected.Token(Token = "0x60003A7")]
			[Cpp2IlInjected.Address(RVA = "0xAAA160", Offset = "0xAA9560", VA = "0x180AAA160")]
			[CompilerGenerated]
			get
			{
				return default(DateTime);
			}
			[Cpp2IlInjected.Token(Token = "0x60003A8")]
			[Cpp2IlInjected.Address(RVA = "0x10D7F70", Offset = "0x10D7370", VA = "0x1810D7F70")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001B2")]
		public UgcAccessibility? UgcAccessibility
		{
			[Cpp2IlInjected.Token(Token = "0x60003A9")]
			[Cpp2IlInjected.Address(RVA = "0xAA3370", Offset = "0xAA2770", VA = "0x180AA3370")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60003AA")]
			[Cpp2IlInjected.Address(RVA = "0xCDA990", Offset = "0xCD9D90", VA = "0x180CDA990")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001B3")]
		public IReadOnlyList<Guid> ReferencedUnityAssetIds
		{
			[Cpp2IlInjected.Token(Token = "0x60003AB")]
			[Cpp2IlInjected.Address(RVA = "0xAA3150", Offset = "0xAA2550", VA = "0x180AA3150")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60003AC")]
			[Cpp2IlInjected.Address(RVA = "0xAA33A0", Offset = "0xAA27A0", VA = "0x180AA33A0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001B4")]
		public FilenameWithHash BlobNameWithHash
		{
			[Cpp2IlInjected.Token(Token = "0x60003B2")]
			[Cpp2IlInjected.Address(RVA = "0x7718CE0", Offset = "0x77180E0", VA = "0x187718CE0")]
			get
			{
				return default(FilenameWithHash);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60003AD")]
		[Cpp2IlInjected.Address(RVA = "0x77189D0", Offset = "0x7717DD0", VA = "0x1877189D0", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60003AE")]
		[Cpp2IlInjected.Address(RVA = "0x77189C0", Offset = "0x7717DC0", VA = "0x1877189C0")]
		public bool Equals(InventionVersion v2)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60003AF")]
		[Cpp2IlInjected.Address(RVA = "0x7718B00", Offset = "0x7717F00", VA = "0x187718B00")]
		private bool TJDZXJRWMUE(InventionVersion a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60003B0")]
		[Cpp2IlInjected.Address(RVA = "0x7718A60", Offset = "0x7717E60", VA = "0x187718A60")]
		private static bool HVURZLSXYJO(IReadOnlyList<Guid> a, IReadOnlyList<Guid> b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60003B1")]
		[Cpp2IlInjected.Address(RVA = "0x286F1E0", Offset = "0x286E5E0", VA = "0x18286F1E0", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60003B3")]
		[Cpp2IlInjected.Address(RVA = "0xAAC8E0", Offset = "0xAABCE0", VA = "0x180AAC8E0")]
		public InventionVersion()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200008A")]
	[Utf8JsonSerializable]
	public class InventionTrialDurationResponse
	{
		[Cpp2IlInjected.Token(Token = "0x170001B5")]
		public int Duration
		{
			[Cpp2IlInjected.Token(Token = "0x60003B4")]
			[Cpp2IlInjected.Address(RVA = "0xAA3110", Offset = "0xAA2510", VA = "0x180AA3110")]
			[CompilerGenerated]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x60003B5")]
			[Cpp2IlInjected.Address(RVA = "0xAAB1D0", Offset = "0xAAA5D0", VA = "0x180AAB1D0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60003B6")]
		[Cpp2IlInjected.Address(RVA = "0xAAC8E0", Offset = "0xAABCE0", VA = "0x180AAC8E0")]
		public InventionTrialDurationResponse()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200008B")]
	[Utf8JsonSerializable]
	public class PersonalInventionDetails
	{
		[Cpp2IlInjected.Token(Token = "0x170001B6")]
		public bool IsCheering
		{
			[Cpp2IlInjected.Token(Token = "0x60003B7")]
			[Cpp2IlInjected.Address(RVA = "0xAF8E00", Offset = "0xAF8200", VA = "0x180AF8E00")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x60003B8")]
			[Cpp2IlInjected.Address(RVA = "0xB22470", Offset = "0xB21870", VA = "0x180B22470")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60003B9")]
		[Cpp2IlInjected.Address(RVA = "0xAAC8E0", Offset = "0xAABCE0", VA = "0x180AAC8E0")]
		public PersonalInventionDetails()
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x200008C")]
	[Utf8JsonSerializable]
	public class NewInventionRequestDTO
	{
		[Cpp2IlInjected.Token(Token = "0x170001B7")]
		public string name
		{
			[Cpp2IlInjected.Token(Token = "0x60003BA")]
			[Cpp2IlInjected.Address(RVA = "0xAA5FB0", Offset = "0xAA53B0", VA = "0x180AA5FB0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60003BB")]
			[Cpp2IlInjected.Address(RVA = "0xAA5FC0", Offset = "0xAA53C0", VA = "0x180AA5FC0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001B8")]
		public string description
		{
			[Cpp2IlInjected.Token(Token = "0x60003BC")]
			[Cpp2IlInjected.Address(RVA = "0xAAA880", Offset = "0xAA9C80", VA = "0x180AAA880")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60003BD")]
			[Cpp2IlInjected.Address(RVA = "0xAAA120", Offset = "0xAA9520", VA = "0x180AAA120")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001B9")]
		public string imageName
		{
			[Cpp2IlInjected.Token(Token = "0x60003BE")]
			[Cpp2IlInjected.Address(RVA = "0xAAB1C0", Offset = "0xAAA5C0", VA = "0x180AAB1C0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60003BF")]
			[Cpp2IlInjected.Address(RVA = "0xAA67C0", Offset = "0xAA5BC0", VA = "0x180AA67C0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001BA")]
		public bool hasBetaContent
		{
			[Cpp2IlInjected.Token(Token = "0x60003C0")]
			[Cpp2IlInjected.Address(RVA = "0xC75520", Offset = "0xC74920", VA = "0x180C75520")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x60003C1")]
			[Cpp2IlInjected.Address(RVA = "0xC75550", Offset = "0xC74950", VA = "0x180C75550")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001BB")]
		public int instantiationCost
		{
			[Cpp2IlInjected.Token(Token = "0x60003C2")]
			[Cpp2IlInjected.Address(RVA = "0xC4E8F0", Offset = "0xC4DCF0", VA = "0x180C4E8F0")]
			[CompilerGenerated]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x60003C3")]
			[Cpp2IlInjected.Address(RVA = "0x1ACB200", Offset = "0x1ACA600", VA = "0x181ACB200")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001BC")]
		public int lightsCost
		{
			[Cpp2IlInjected.Token(Token = "0x60003C4")]
			[Cpp2IlInjected.Address(RVA = "0xAAF800", Offset = "0xAAEC00", VA = "0x180AAF800")]
			[CompilerGenerated]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x60003C5")]
			[Cpp2IlInjected.Address(RVA = "0xAAF7F0", Offset = "0xAAEBF0", VA = "0x180AAF7F0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001BD")]
		public int chipsCost
		{
			[Cpp2IlInjected.Token(Token = "0x60003C6")]
			[Cpp2IlInjected.Address(RVA = "0xAF32A0", Offset = "0xAF26A0", VA = "0x180AF32A0")]
			[CompilerGenerated]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x60003C7")]
			[Cpp2IlInjected.Address(RVA = "0x13D1290", Offset = "0x13D0690", VA = "0x1813D1290")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001BE")]
		public int cloudVariablesCost
		{
			[Cpp2IlInjected.Token(Token = "0x60003C8")]
			[Cpp2IlInjected.Address(RVA = "0xAD4020", Offset = "0xAD3420", VA = "0x180AD4020")]
			[CompilerGenerated]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x60003C9")]
			[Cpp2IlInjected.Address(RVA = "0xB10400", Offset = "0xB0F800", VA = "0x180B10400")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001BF")]
		public int aiCost
		{
			[Cpp2IlInjected.Token(Token = "0x60003CA")]
			[Cpp2IlInjected.Address(RVA = "0xAE3BC0", Offset = "0xAE2FC0", VA = "0x180AE3BC0")]
			[CompilerGenerated]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x60003CB")]
			[Cpp2IlInjected.Address(RVA = "0xAE34B0", Offset = "0xAE28B0", VA = "0x180AE34B0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001C0")]
		public byte ugcVersion
		{
			[Cpp2IlInjected.Token(Token = "0x60003CC")]
			[Cpp2IlInjected.Address(RVA = "0xC6B720", Offset = "0xC6AB20", VA = "0x180C6B720")]
			[CompilerGenerated]
			get
			{
				return default(byte);
			}
			[Cpp2IlInjected.Token(Token = "0x60003CD")]
			[Cpp2IlInjected.Address(RVA = "0xC6B160", Offset = "0xC6A560", VA = "0x180C6B160")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001C1")]
		public long creationRoomId
		{
			[Cpp2IlInjected.Token(Token = "0x60003CE")]
			[Cpp2IlInjected.Address(RVA = "0xAAA160", Offset = "0xAA9560", VA = "0x180AAA160")]
			[CompilerGenerated]
			get
			{
				return default(long);
			}
			[Cpp2IlInjected.Token(Token = "0x60003CF")]
			[Cpp2IlInjected.Address(RVA = "0x10D7F70", Offset = "0x10D7370", VA = "0x1810D7F70")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001C2")]
		public string inventionDataFilename
		{
			[Cpp2IlInjected.Token(Token = "0x60003D0")]
			[Cpp2IlInjected.Address(RVA = "0xAA3370", Offset = "0xAA2770", VA = "0x180AA3370")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60003D1")]
			[Cpp2IlInjected.Address(RVA = "0xAA3390", Offset = "0xAA2790", VA = "0x180AA3390")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001C3")]
		public List<long> referencedInventions
		{
			[Cpp2IlInjected.Token(Token = "0x60003D2")]
			[Cpp2IlInjected.Address(RVA = "0xAA3150", Offset = "0xAA2550", VA = "0x180AA3150")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60003D3")]
			[Cpp2IlInjected.Address(RVA = "0xAA33A0", Offset = "0xAA27A0", VA = "0x180AA33A0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001C4")]
		public IReadOnlyList<Guid> referencedUnityAssetIds
		{
			[Cpp2IlInjected.Token(Token = "0x60003D4")]
			[Cpp2IlInjected.Address(RVA = "0xAA3380", Offset = "0xAA2780", VA = "0x180AA3380")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60003D5")]
			[Cpp2IlInjected.Address(RVA = "0xAA3130", Offset = "0xAA2530", VA = "0x180AA3130")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001C5")]
		public AccountRoleType creatorAccountRole
		{
			[Cpp2IlInjected.Token(Token = "0x60003D6")]
			[Cpp2IlInjected.Address(RVA = "0xAB5E80", Offset = "0xAB5280", VA = "0x180AB5E80")]
			[CompilerGenerated]
			get
			{
				return default(AccountRoleType);
			}
			[Cpp2IlInjected.Token(Token = "0x60003D7")]
			[Cpp2IlInjected.Address(RVA = "0xAB5E50", Offset = "0xAB5250", VA = "0x180AB5E50")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001C6")]
		public long? convertedFromInventionId
		{
			[Cpp2IlInjected.Token(Token = "0x60003D8")]
			[Cpp2IlInjected.Address(RVA = "0x5F1DFE0", Offset = "0x5F1D3E0", VA = "0x185F1DFE0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60003D9")]
			[Cpp2IlInjected.Address(RVA = "0x5F23A80", Offset = "0x5F22E80", VA = "0x185F23A80")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001C7")]
		public string displayMetadataJson
		{
			[Cpp2IlInjected.Token(Token = "0x60003DA")]
			[Cpp2IlInjected.Address(RVA = "0xAAD040", Offset = "0xAAC440", VA = "0x180AAD040")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60003DB")]
			[Cpp2IlInjected.Address(RVA = "0xAAC9D0", Offset = "0xAABDD0", VA = "0x180AAC9D0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001C8")]
		public string longDescription
		{
			[Cpp2IlInjected.Token(Token = "0x60003DC")]
			[Cpp2IlInjected.Address(RVA = "0xAAC9A0", Offset = "0xAABDA0", VA = "0x180AAC9A0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60003DD")]
			[Cpp2IlInjected.Address(RVA = "0xAAC9F0", Offset = "0xAABDF0", VA = "0x180AAC9F0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001C9")]
		public ModifyTagsRequest tagsRequest
		{
			[Cpp2IlInjected.Token(Token = "0x60003DE")]
			[Cpp2IlInjected.Address(RVA = "0xAD3CC0", Offset = "0xAD30C0", VA = "0x180AD3CC0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60003DF")]
			[Cpp2IlInjected.Address(RVA = "0xCA6670", Offset = "0xCA5A70", VA = "0x180CA6670")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60003E0")]
		[Cpp2IlInjected.Address(RVA = "0x771A2D0", Offset = "0x77196D0", VA = "0x18771A2D0")]
		public NewInventionRequestDTO()
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x200008D")]
	[Utf8JsonSerializable]
	public class AddVersionInventionRequestDTO
	{
		[Cpp2IlInjected.Token(Token = "0x170001CA")]
		public long inventionId
		{
			[Cpp2IlInjected.Token(Token = "0x60003E1")]
			[Cpp2IlInjected.Address(RVA = "0xAA5FB0", Offset = "0xAA53B0", VA = "0x180AA5FB0")]
			[CompilerGenerated]
			get
			{
				return default(long);
			}
			[Cpp2IlInjected.Token(Token = "0x60003E2")]
			[Cpp2IlInjected.Address(RVA = "0xB96550", Offset = "0xB95950", VA = "0x180B96550")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001CB")]
		public bool hasBetaContent
		{
			[Cpp2IlInjected.Token(Token = "0x60003E3")]
			[Cpp2IlInjected.Address(RVA = "0xBC19C0", Offset = "0xBC0DC0", VA = "0x180BC19C0")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x60003E4")]
			[Cpp2IlInjected.Address(RVA = "0xAA7380", Offset = "0xAA6780", VA = "0x180AA7380")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001CC")]
		public int instantiationCost
		{
			[Cpp2IlInjected.Token(Token = "0x60003E5")]
			[Cpp2IlInjected.Address(RVA = "0x12E70B0", Offset = "0x12E64B0", VA = "0x1812E70B0")]
			[CompilerGenerated]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x60003E6")]
			[Cpp2IlInjected.Address(RVA = "0x12E70C0", Offset = "0x12E64C0", VA = "0x1812E70C0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001CD")]
		public int lightsCost
		{
			[Cpp2IlInjected.Token(Token = "0x60003E7")]
			[Cpp2IlInjected.Address(RVA = "0xAB5660", Offset = "0xAB4A60", VA = "0x180AB5660")]
			[CompilerGenerated]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x60003E8")]
			[Cpp2IlInjected.Address(RVA = "0xB07AB0", Offset = "0xB06EB0", VA = "0x180B07AB0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001CE")]
		public int chipsCost
		{
			[Cpp2IlInjected.Token(Token = "0x60003E9")]
			[Cpp2IlInjected.Address(RVA = "0xACC3D0", Offset = "0xACB7D0", VA = "0x180ACC3D0")]
			[CompilerGenerated]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x60003EA")]
			[Cpp2IlInjected.Address(RVA = "0xBE18B0", Offset = "0xBE0CB0", VA = "0x180BE18B0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001CF")]
		public int cloudVariablesCost
		{
			[Cpp2IlInjected.Token(Token = "0x60003EB")]
			[Cpp2IlInjected.Address(RVA = "0xAAB1A0", Offset = "0xAAA5A0", VA = "0x180AAB1A0")]
			[CompilerGenerated]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x60003EC")]
			[Cpp2IlInjected.Address(RVA = "0xAAB1B0", Offset = "0xAAA5B0", VA = "0x180AAB1B0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001D0")]
		public int aiCost
		{
			[Cpp2IlInjected.Token(Token = "0x60003ED")]
			[Cpp2IlInjected.Address(RVA = "0xC4E8F0", Offset = "0xC4DCF0", VA = "0x180C4E8F0")]
			[CompilerGenerated]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x60003EE")]
			[Cpp2IlInjected.Address(RVA = "0x1ACB200", Offset = "0x1ACA600", VA = "0x181ACB200")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001D1")]
		public byte ugcVersion
		{
			[Cpp2IlInjected.Token(Token = "0x60003EF")]
			[Cpp2IlInjected.Address(RVA = "0xAF9F90", Offset = "0xAF9390", VA = "0x180AF9F90")]
			[CompilerGenerated]
			get
			{
				return default(byte);
			}
			[Cpp2IlInjected.Token(Token = "0x60003F0")]
			[Cpp2IlInjected.Address(RVA = "0xAF9170", Offset = "0xAF8570", VA = "0x180AF9170")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001D2")]
		public long creationRoomId
		{
			[Cpp2IlInjected.Token(Token = "0x60003F1")]
			[Cpp2IlInjected.Address(RVA = "0xAAA030", Offset = "0xAA9430", VA = "0x180AAA030")]
			[CompilerGenerated]
			get
			{
				return default(long);
			}
			[Cpp2IlInjected.Token(Token = "0x60003F2")]
			[Cpp2IlInjected.Address(RVA = "0xAAF810", Offset = "0xAAEC10", VA = "0x180AAF810")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001D3")]
		public string inventionDataFilename
		{
			[Cpp2IlInjected.Token(Token = "0x60003F3")]
			[Cpp2IlInjected.Address(RVA = "0xAAA810", Offset = "0xAA9C10", VA = "0x180AAA810")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60003F4")]
			[Cpp2IlInjected.Address(RVA = "0xAAA840", Offset = "0xAA9C40", VA = "0x180AAA840")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001D4")]
		public List<long> referencedInventions
		{
			[Cpp2IlInjected.Token(Token = "0x60003F5")]
			[Cpp2IlInjected.Address(RVA = "0xAAA160", Offset = "0xAA9560", VA = "0x180AAA160")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60003F6")]
			[Cpp2IlInjected.Address(RVA = "0xAAA870", Offset = "0xAA9C70", VA = "0x180AAA870")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001D5")]
		public IReadOnlyList<Guid> referencedUnityAssetIds
		{
			[Cpp2IlInjected.Token(Token = "0x60003F7")]
			[Cpp2IlInjected.Address(RVA = "0xAA3370", Offset = "0xAA2770", VA = "0x180AA3370")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60003F8")]
			[Cpp2IlInjected.Address(RVA = "0xAA3390", Offset = "0xAA2790", VA = "0x180AA3390")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001D6")]
		public ModifyTagsRequest tagsRequest
		{
			[Cpp2IlInjected.Token(Token = "0x60003F9")]
			[Cpp2IlInjected.Address(RVA = "0xAA3150", Offset = "0xAA2550", VA = "0x180AA3150")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60003FA")]
			[Cpp2IlInjected.Address(RVA = "0xAA33A0", Offset = "0xAA27A0", VA = "0x180AA33A0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60003FB")]
		[Cpp2IlInjected.Address(RVA = "0x7713740", Offset = "0x7712B40", VA = "0x187713740")]
		public AddVersionInventionRequestDTO()
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x200008E")]
	[Utf8JsonSerializable]
	public class ModifyTagsRequest
	{
		[Cpp2IlInjected.Token(Token = "0x170001D7")]
		public List<string> AutoTags
		{
			[Cpp2IlInjected.Token(Token = "0x60003FC")]
			[Cpp2IlInjected.Address(RVA = "0xAA5FB0", Offset = "0xAA53B0", VA = "0x180AA5FB0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60003FD")]
			[Cpp2IlInjected.Address(RVA = "0xAA5FC0", Offset = "0xAA53C0", VA = "0x180AA5FC0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001D8")]
		public List<string> CustomTags
		{
			[Cpp2IlInjected.Token(Token = "0x60003FE")]
			[Cpp2IlInjected.Address(RVA = "0xAAA880", Offset = "0xAA9C80", VA = "0x180AAA880")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60003FF")]
			[Cpp2IlInjected.Address(RVA = "0xAAA120", Offset = "0xAA9520", VA = "0x180AAA120")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000400")]
		[Cpp2IlInjected.Address(RVA = "0xAAC8E0", Offset = "0xAABCE0", VA = "0x180AAC8E0")]
		public ModifyTagsRequest()
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x200008F")]
	[Utf8JsonSerializable]
	public class InventionModifyTagsRequest : ModifyTagsRequest
	{
		[Cpp2IlInjected.Token(Token = "0x170001D9")]
		public long InventionId
		{
			[Cpp2IlInjected.Token(Token = "0x6000401")]
			[Cpp2IlInjected.Address(RVA = "0xAAB1C0", Offset = "0xAAA5C0", VA = "0x180AAB1C0")]
			[CompilerGenerated]
			get
			{
				return default(long);
			}
			[Cpp2IlInjected.Token(Token = "0x6000402")]
			[Cpp2IlInjected.Address(RVA = "0xB30430", Offset = "0xB2F830", VA = "0x180B30430")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000403")]
		[Cpp2IlInjected.Address(RVA = "0xAAC8E0", Offset = "0xAABCE0", VA = "0x180AAC8E0")]
		public InventionModifyTagsRequest()
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000090")]
	[Utf8JsonSerializable]
	public class ReportRequest
	{
		[Cpp2IlInjected.Token(Token = "0x170001DA")]
		public long InventionId
		{
			[Cpp2IlInjected.Token(Token = "0x6000404")]
			[Cpp2IlInjected.Address(RVA = "0xAA5FB0", Offset = "0xAA53B0", VA = "0x180AA5FB0")]
			[CompilerGenerated]
			get
			{
				return default(long);
			}
			[Cpp2IlInjected.Token(Token = "0x6000405")]
			[Cpp2IlInjected.Address(RVA = "0xB96550", Offset = "0xB95950", VA = "0x180B96550")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001DB")]
		public string Details
		{
			[Cpp2IlInjected.Token(Token = "0x6000406")]
			[Cpp2IlInjected.Address(RVA = "0xAAA880", Offset = "0xAA9C80", VA = "0x180AAA880")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000407")]
			[Cpp2IlInjected.Address(RVA = "0xAAA120", Offset = "0xAA9520", VA = "0x180AAA120")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001DC")]
		public InventionReportCategory ReportCategory
		{
			[Cpp2IlInjected.Token(Token = "0x6000408")]
			[Cpp2IlInjected.Address(RVA = "0xAB5660", Offset = "0xAB4A60", VA = "0x180AB5660")]
			[CompilerGenerated]
			get
			{
				return default(InventionReportCategory);
			}
			[Cpp2IlInjected.Token(Token = "0x6000409")]
			[Cpp2IlInjected.Address(RVA = "0xB07AB0", Offset = "0xB06EB0", VA = "0x180B07AB0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600040A")]
		[Cpp2IlInjected.Address(RVA = "0xAAC8E0", Offset = "0xAABCE0", VA = "0x180AAC8E0")]
		public ReportRequest()
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000091")]
	[Utf8JsonSerializable]
	public class CheerRequest
	{
		[Cpp2IlInjected.Token(Token = "0x170001DD")]
		public long InventionId
		{
			[Cpp2IlInjected.Token(Token = "0x600040B")]
			[Cpp2IlInjected.Address(RVA = "0xAA5FB0", Offset = "0xAA53B0", VA = "0x180AA5FB0")]
			[CompilerGenerated]
			get
			{
				return default(long);
			}
			[Cpp2IlInjected.Token(Token = "0x600040C")]
			[Cpp2IlInjected.Address(RVA = "0xB96550", Offset = "0xB95950", VA = "0x180B96550")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001DE")]
		public bool Cheer
		{
			[Cpp2IlInjected.Token(Token = "0x600040D")]
			[Cpp2IlInjected.Address(RVA = "0xBC19C0", Offset = "0xBC0DC0", VA = "0x180BC19C0")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x600040E")]
			[Cpp2IlInjected.Address(RVA = "0xAA7380", Offset = "0xAA6780", VA = "0x180AA7380")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600040F")]
		[Cpp2IlInjected.Address(RVA = "0xAAC8E0", Offset = "0xAABCE0", VA = "0x180AAC8E0")]
		public CheerRequest()
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000092")]
	[Utf8JsonSerializable]
	public class UpdatePriceRequest
	{
		[Cpp2IlInjected.Token(Token = "0x170001DF")]
		public long InventionId
		{
			[Cpp2IlInjected.Token(Token = "0x6000410")]
			[Cpp2IlInjected.Address(RVA = "0xAA5FB0", Offset = "0xAA53B0", VA = "0x180AA5FB0")]
			[CompilerGenerated]
			get
			{
				return default(long);
			}
			[Cpp2IlInjected.Token(Token = "0x6000411")]
			[Cpp2IlInjected.Address(RVA = "0xB96550", Offset = "0xB95950", VA = "0x180B96550")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001E0")]
		public int Price
		{
			[Cpp2IlInjected.Token(Token = "0x6000412")]
			[Cpp2IlInjected.Address(RVA = "0xAAC980", Offset = "0xAABD80", VA = "0x180AAC980")]
			[CompilerGenerated]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x6000413")]
			[Cpp2IlInjected.Address(RVA = "0xAB2F40", Offset = "0xAB2340", VA = "0x180AB2F40")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000414")]
		[Cpp2IlInjected.Address(RVA = "0xAAC8E0", Offset = "0xAABCE0", VA = "0x180AAC8E0")]
		public UpdatePriceRequest()
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000093")]
	[Utf8JsonSerializable]
	public class UpdateInventionMetadataRequest
	{
		[Cpp2IlInjected.Token(Token = "0x170001E1")]
		public long InventionId
		{
			[Cpp2IlInjected.Token(Token = "0x6000415")]
			[Cpp2IlInjected.Address(RVA = "0xAA5FB0", Offset = "0xAA53B0", VA = "0x180AA5FB0")]
			[CompilerGenerated]
			get
			{
				return default(long);
			}
			[Cpp2IlInjected.Token(Token = "0x6000416")]
			[Cpp2IlInjected.Address(RVA = "0xB96550", Offset = "0xB95950", VA = "0x180B96550")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001E2")]
		public string Name
		{
			[Cpp2IlInjected.Token(Token = "0x6000417")]
			[Cpp2IlInjected.Address(RVA = "0xAAA880", Offset = "0xAA9C80", VA = "0x180AAA880")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000418")]
			[Cpp2IlInjected.Address(RVA = "0xAAA120", Offset = "0xAA9520", VA = "0x180AAA120")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001E3")]
		public string Description
		{
			[Cpp2IlInjected.Token(Token = "0x6000419")]
			[Cpp2IlInjected.Address(RVA = "0xAAB1C0", Offset = "0xAAA5C0", VA = "0x180AAB1C0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600041A")]
			[Cpp2IlInjected.Address(RVA = "0xAA67C0", Offset = "0xAA5BC0", VA = "0x180AA67C0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001E4")]
		public string LongDescription
		{
			[Cpp2IlInjected.Token(Token = "0x600041B")]
			[Cpp2IlInjected.Address(RVA = "0xAAA820", Offset = "0xAA9C20", VA = "0x180AAA820")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600041C")]
			[Cpp2IlInjected.Address(RVA = "0xAA67D0", Offset = "0xAA5BD0", VA = "0x180AA67D0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001E5")]
		public string ImageName
		{
			[Cpp2IlInjected.Token(Token = "0x600041D")]
			[Cpp2IlInjected.Address(RVA = "0xAAA140", Offset = "0xAA9540", VA = "0x180AAA140")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600041E")]
			[Cpp2IlInjected.Address(RVA = "0xAADB00", Offset = "0xAACF00", VA = "0x180AADB00")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001E6")]
		public ModifyTagsRequest TagsRequest
		{
			[Cpp2IlInjected.Token(Token = "0x600041F")]
			[Cpp2IlInjected.Address(RVA = "0xAAA030", Offset = "0xAA9430", VA = "0x180AAA030")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000420")]
			[Cpp2IlInjected.Address(RVA = "0xAAA110", Offset = "0xAA9510", VA = "0x180AAA110")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000421")]
		[Cpp2IlInjected.Address(RVA = "0xAAC8E0", Offset = "0xAABCE0", VA = "0x180AAC8E0")]
		public UpdateInventionMetadataRequest()
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000094")]
	[Utf8JsonSerializable]
	public class UpdateInventionGeneralPermissionRequest
	{
		[Cpp2IlInjected.Token(Token = "0x170001E7")]
		public long InventionId
		{
			[Cpp2IlInjected.Token(Token = "0x6000422")]
			[Cpp2IlInjected.Address(RVA = "0xAA5FB0", Offset = "0xAA53B0", VA = "0x180AA5FB0")]
			[CompilerGenerated]
			get
			{
				return default(long);
			}
			[Cpp2IlInjected.Token(Token = "0x6000423")]
			[Cpp2IlInjected.Address(RVA = "0xB96550", Offset = "0xB95950", VA = "0x180B96550")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001E8")]
		public InventionPermission Permission
		{
			[Cpp2IlInjected.Token(Token = "0x6000424")]
			[Cpp2IlInjected.Address(RVA = "0xAAC980", Offset = "0xAABD80", VA = "0x180AAC980")]
			[CompilerGenerated]
			get
			{
				return default(InventionPermission);
			}
			[Cpp2IlInjected.Token(Token = "0x6000425")]
			[Cpp2IlInjected.Address(RVA = "0xAB2F40", Offset = "0xAB2340", VA = "0x180AB2F40")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000426")]
		[Cpp2IlInjected.Address(RVA = "0xAAC8E0", Offset = "0xAABCE0", VA = "0x180AAC8E0")]
		public UpdateInventionGeneralPermissionRequest()
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000095")]
	[Utf8JsonSerializable]
	public class PublishInventionRequest
	{
		[Cpp2IlInjected.Token(Token = "0x170001E9")]
		public long InventionId
		{
			[Cpp2IlInjected.Token(Token = "0x6000427")]
			[Cpp2IlInjected.Address(RVA = "0xAA5FB0", Offset = "0xAA53B0", VA = "0x180AA5FB0")]
			[CompilerGenerated]
			get
			{
				return default(long);
			}
			[Cpp2IlInjected.Token(Token = "0x6000428")]
			[Cpp2IlInjected.Address(RVA = "0xB96550", Offset = "0xB95950", VA = "0x180B96550")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001EA")]
		public InventionPermission Permission
		{
			[Cpp2IlInjected.Token(Token = "0x6000429")]
			[Cpp2IlInjected.Address(RVA = "0xAAC980", Offset = "0xAABD80", VA = "0x180AAC980")]
			[CompilerGenerated]
			get
			{
				return default(InventionPermission);
			}
			[Cpp2IlInjected.Token(Token = "0x600042A")]
			[Cpp2IlInjected.Address(RVA = "0xAB2F40", Offset = "0xAB2340", VA = "0x180AB2F40")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001EB")]
		public UgcAccessibility Accessibility
		{
			[Cpp2IlInjected.Token(Token = "0x600042B")]
			[Cpp2IlInjected.Address(RVA = "0x12E70B0", Offset = "0x12E64B0", VA = "0x1812E70B0")]
			[CompilerGenerated]
			get
			{
				return default(UgcAccessibility);
			}
			[Cpp2IlInjected.Token(Token = "0x600042C")]
			[Cpp2IlInjected.Address(RVA = "0x12E70C0", Offset = "0x12E64C0", VA = "0x1812E70C0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001EC")]
		public int? Price
		{
			[Cpp2IlInjected.Token(Token = "0x600042D")]
			[Cpp2IlInjected.Address(RVA = "0xAAB1C0", Offset = "0xAAA5C0", VA = "0x180AAB1C0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600042E")]
			[Cpp2IlInjected.Address(RVA = "0xB30430", Offset = "0xB2F830", VA = "0x180B30430")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600042F")]
		[Cpp2IlInjected.Address(RVA = "0xAAC8E0", Offset = "0xAABCE0", VA = "0x180AAC8E0")]
		public PublishInventionRequest()
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000096")]
	[Utf8JsonSerializable]
	public class UnpublishInventionRequest
	{
		[Cpp2IlInjected.Token(Token = "0x170001ED")]
		public long InventionId
		{
			[Cpp2IlInjected.Token(Token = "0x6000430")]
			[Cpp2IlInjected.Address(RVA = "0xAA5FB0", Offset = "0xAA53B0", VA = "0x180AA5FB0")]
			[CompilerGenerated]
			get
			{
				return default(long);
			}
			[Cpp2IlInjected.Token(Token = "0x6000431")]
			[Cpp2IlInjected.Address(RVA = "0xB96550", Offset = "0xB95950", VA = "0x180B96550")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000432")]
		[Cpp2IlInjected.Address(RVA = "0xAAC8E0", Offset = "0xAABCE0", VA = "0x180AAC8E0")]
		public UnpublishInventionRequest()
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000097")]
	[Utf8JsonSerializable]
	public class DeleteInventionRequest
	{
		[Cpp2IlInjected.Token(Token = "0x170001EE")]
		public long InventionId
		{
			[Cpp2IlInjected.Token(Token = "0x6000433")]
			[Cpp2IlInjected.Address(RVA = "0xAA5FB0", Offset = "0xAA53B0", VA = "0x180AA5FB0")]
			[CompilerGenerated]
			get
			{
				return default(long);
			}
			[Cpp2IlInjected.Token(Token = "0x6000434")]
			[Cpp2IlInjected.Address(RVA = "0xB96550", Offset = "0xB95950", VA = "0x180B96550")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000435")]
		[Cpp2IlInjected.Address(RVA = "0xAAC8E0", Offset = "0xAABCE0", VA = "0x180AAC8E0")]
		public DeleteInventionRequest()
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000098")]
	[Utf8JsonSerializable]
	public class SetInventionVersionAccessibilityRequest
	{
		[Cpp2IlInjected.Token(Token = "0x170001EF")]
		public long InventionId
		{
			[Cpp2IlInjected.Token(Token = "0x6000436")]
			[Cpp2IlInjected.Address(RVA = "0xAA5FB0", Offset = "0xAA53B0", VA = "0x180AA5FB0")]
			[CompilerGenerated]
			get
			{
				return default(long);
			}
			[Cpp2IlInjected.Token(Token = "0x6000437")]
			[Cpp2IlInjected.Address(RVA = "0xB96550", Offset = "0xB95950", VA = "0x180B96550")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001F0")]
		public int VersionNumber
		{
			[Cpp2IlInjected.Token(Token = "0x6000438")]
			[Cpp2IlInjected.Address(RVA = "0xAAC980", Offset = "0xAABD80", VA = "0x180AAC980")]
			[CompilerGenerated]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x6000439")]
			[Cpp2IlInjected.Address(RVA = "0xAB2F40", Offset = "0xAB2340", VA = "0x180AB2F40")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001F1")]
		public UgcAccessibility NewAccessibility
		{
			[Cpp2IlInjected.Token(Token = "0x600043A")]
			[Cpp2IlInjected.Address(RVA = "0x12E70B0", Offset = "0x12E64B0", VA = "0x1812E70B0")]
			[CompilerGenerated]
			get
			{
				return default(UgcAccessibility);
			}
			[Cpp2IlInjected.Token(Token = "0x600043B")]
			[Cpp2IlInjected.Address(RVA = "0x12E70C0", Offset = "0x12E64C0", VA = "0x1812E70C0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600043C")]
		[Cpp2IlInjected.Address(RVA = "0xAAC8E0", Offset = "0xAABCE0", VA = "0x180AAC8E0")]
		public SetInventionVersionAccessibilityRequest()
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000099")]
	[Utf8JsonSerializable]
	public class SpecialTags
	{
		[Cpp2IlInjected.Token(Token = "0x170001F2")]
		public List<string> AutoTags
		{
			[Cpp2IlInjected.Token(Token = "0x600043D")]
			[Cpp2IlInjected.Address(RVA = "0xAA5FB0", Offset = "0xAA53B0", VA = "0x180AA5FB0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600043E")]
			[Cpp2IlInjected.Address(RVA = "0xAA5FC0", Offset = "0xAA53C0", VA = "0x180AA5FC0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001F3")]
		public List<string> AGOnlyTags
		{
			[Cpp2IlInjected.Token(Token = "0x600043F")]
			[Cpp2IlInjected.Address(RVA = "0xAAA880", Offset = "0xAA9C80", VA = "0x180AAA880")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000440")]
			[Cpp2IlInjected.Address(RVA = "0xAAA120", Offset = "0xAA9520", VA = "0x180AAA120")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000441")]
		[Cpp2IlInjected.Address(RVA = "0xAAC8E0", Offset = "0xAABCE0", VA = "0x180AAC8E0")]
		public SpecialTags()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200009A")]
	public enum InventionResult
	{
		[Cpp2IlInjected.Token(Token = "0x40001FB")]
		Success,
		[Cpp2IlInjected.Token(Token = "0x40001FC")]
		InvalidParameters,
		[Cpp2IlInjected.Token(Token = "0x40001FD")]
		PlayerCannotUpload,
		[Cpp2IlInjected.Token(Token = "0x40001FE")]
		DuplicateName,
		[Cpp2IlInjected.Token(Token = "0x40001FF")]
		NameTooShort,
		[Cpp2IlInjected.Token(Token = "0x4000200")]
		NameTooLong,
		[Cpp2IlInjected.Token(Token = "0x4000201")]
		NotCreator,
		[Cpp2IlInjected.Token(Token = "0x4000202")]
		DoesNotExist,
		[Cpp2IlInjected.Token(Token = "0x4000203")]
		ImageDoesNotExist,
		[Cpp2IlInjected.Token(Token = "0x4000204")]
		InventionLimitReached,
		[Cpp2IlInjected.Token(Token = "0x4000205")]
		DescriptionTooLong,
		[Cpp2IlInjected.Token(Token = "0x4000206")]
		InnapropriateName,
		[Cpp2IlInjected.Token(Token = "0x4000207")]
		InappropriateDescription,
		[Cpp2IlInjected.Token(Token = "0x4000208")]
		CannotBeModified,
		[Cpp2IlInjected.Token(Token = "0x4000209")]
		PlayerCannotPublish,
		[Cpp2IlInjected.Token(Token = "0x400020A")]
		AlreadyPublished,
		[Cpp2IlInjected.Token(Token = "0x400020B")]
		AlreadyUnpublished,
		[Cpp2IlInjected.Token(Token = "0x400020C")]
		InventionUnderModerationReview,
		[Cpp2IlInjected.Token(Token = "0x400020D")]
		PlayerCannotDownload,
		[Cpp2IlInjected.Token(Token = "0x400020E")]
		PlayerAlreadyOwns,
		[Cpp2IlInjected.Token(Token = "0x400020F")]
		DescriptionTooShort,
		[Cpp2IlInjected.Token(Token = "0x4000210")]
		DoesNotHavePermission,
		[Cpp2IlInjected.Token(Token = "0x4000211")]
		PermissionLevelCannotBeChanged,
		[Cpp2IlInjected.Token(Token = "0x4000212")]
		AlreadyCheered,
		[Cpp2IlInjected.Token(Token = "0x4000213")]
		AlreadyRemovedCheer,
		[Cpp2IlInjected.Token(Token = "0x4000214")]
		ModeratorRestrictedPublishing,
		[Cpp2IlInjected.Token(Token = "0x4000215")]
		PlayerCannotSell,
		[Cpp2IlInjected.Token(Token = "0x4000216")]
		InvalidPrice,
		[Cpp2IlInjected.Token(Token = "0x4000217")]
		PriceCannotBeChanged,
		[Cpp2IlInjected.Token(Token = "0x4000218")]
		InvalidPermissionForPaidInvention,
		[Cpp2IlInjected.Token(Token = "0x4000219")]
		PurchaseFailed,
		[Cpp2IlInjected.Token(Token = "0x400021A")]
		CannotDownloadPaidInvention,
		[Cpp2IlInjected.Token(Token = "0x400021B")]
		CannotSellUnownedLineage,
		[Cpp2IlInjected.Token(Token = "0x400021C")]
		DoesNotAllowTrial,
		[Cpp2IlInjected.Token(Token = "0x400021D")]
		StillOnTrialCooldown,
		[Cpp2IlInjected.Token(Token = "0x400021E")]
		PlayerCannotTrial,
		[Cpp2IlInjected.Token(Token = "0x400021F")]
		PaidInventionPublishingDisabled,
		[Cpp2IlInjected.Token(Token = "0x4000220")]
		PaidInventionPurchasingDisabled,
		[Cpp2IlInjected.Token(Token = "0x4000221")]
		OperationIsDisabled,
		[Cpp2IlInjected.Token(Token = "0x4000222")]
		PlayerRestrictedFromP2PSelling,
		[Cpp2IlInjected.Token(Token = "0x4000223")]
		PlayerNotRecRoomPlusMember,
		[Cpp2IlInjected.Token(Token = "0x4000224")]
		InvalidInstantiationCost,
		[Cpp2IlInjected.Token(Token = "0x4000225")]
		FeaturedInventionNotPublished,
		[Cpp2IlInjected.Token(Token = "0x4000226")]
		FeaturedInventionNotActive,
		[Cpp2IlInjected.Token(Token = "0x4000227")]
		InventionContainsBlockedFiles,
		[Cpp2IlInjected.Token(Token = "0x4000228")]
		PlayerRestrictedFromP2PBuying,
		[Cpp2IlInjected.Token(Token = "0x4000229")]
		ReservedWordRuleViolationInName,
		[Cpp2IlInjected.Token(Token = "0x400022A")]
		ReservedWordRuleViolationInDescription,
		[Cpp2IlInjected.Token(Token = "0x400022B")]
		InventionContainsBetaContent,
		[Cpp2IlInjected.Token(Token = "0x400022C")]
		PlatformDoesntSupportPublishing,
		[Cpp2IlInjected.Token(Token = "0x400022D")]
		MismatchedUgcVersions,
		[Cpp2IlInjected.Token(Token = "0x400022E")]
		ConvertedFromSameUgcVersion,
		[Cpp2IlInjected.Token(Token = "0x400022F")]
		ConvertedFromInventionDoesNotExist,
		[Cpp2IlInjected.Token(Token = "0x4000230")]
		ConvertedFromInventionHigherVersion,
		[Cpp2IlInjected.Token(Token = "0x4000231")]
		PlatformDoesntSupportInvention
	}
	[Cpp2IlInjected.Token(Token = "0x200009B")]
	public enum InventionReportCategory
	{
		[Cpp2IlInjected.Token(Token = "0x4000233")]
		Unknown = -1,
		[Cpp2IlInjected.Token(Token = "0x4000234")]
		CoC_Discriminatory,
		[Cpp2IlInjected.Token(Token = "0x4000235")]
		CoC_Sexual,
		[Cpp2IlInjected.Token(Token = "0x4000236")]
		CoC_Trolling,
		[Cpp2IlInjected.Token(Token = "0x4000237")]
		Misleading,
		[Cpp2IlInjected.Token(Token = "0x4000238")]
		Other
	}
	[Cpp2IlInjected.Token(Token = "0x200009C")]
	public enum RoomPermissionValue
	{
		[Cpp2IlInjected.Token(Token = "0x400023A")]
		False,
		[Cpp2IlInjected.Token(Token = "0x400023B")]
		True,
		[Cpp2IlInjected.Token(Token = "0x400023C")]
		Invited
	}
	[Cpp2IlInjected.Token(Token = "0x200009D")]
	public interface HPMEIPJMUJG
	{
		[Cpp2IlInjected.Token(Token = "0x170001F4")]
		PlatformType Platform
		{
			[Cpp2IlInjected.Token(Token = "0x6000442")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x170001F5")]
		string PlatformId
		{
			[Cpp2IlInjected.Token(Token = "0x6000443")]
			[Cpp2IlInjected.Address(Slot = "1")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x170001F6")]
		int AccountId
		{
			[Cpp2IlInjected.Token(Token = "0x6000444")]
			[Cpp2IlInjected.Address(Slot = "2")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x170001F7")]
		DateTime LastLoginTime
		{
			[Cpp2IlInjected.Token(Token = "0x6000445")]
			[Cpp2IlInjected.Address(Slot = "3")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x170001F8")]
		bool RequirePassword
		{
			[Cpp2IlInjected.Token(Token = "0x6000446")]
			[Cpp2IlInjected.Address(Slot = "4")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x170001F9")]
		string RefreshToken
		{
			[Cpp2IlInjected.Token(Token = "0x6000447")]
			[Cpp2IlInjected.Address(Slot = "5")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x170001FA")]
		PWCZVKIUTHK Account
		{
			[Cpp2IlInjected.Token(Token = "0x6000448")]
			[Cpp2IlInjected.Address(Slot = "6")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x6000449")]
		[Cpp2IlInjected.Address(Slot = "7")]
		void IFUGSYQCQLL(PWCZVKIUTHK a);
	}
	[Cpp2IlInjected.Token(Token = "0x200009E")]
	public interface JKPMZWFYQBV
	{
		[Cpp2IlInjected.Token(Token = "0x170001FB")]
		string Text
		{
			[Cpp2IlInjected.Token(Token = "0x600044A")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x170001FC")]
		int Length
		{
			[Cpp2IlInjected.Token(Token = "0x600044B")]
			[Cpp2IlInjected.Address(Slot = "1")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x170001FD")]
		bool AllowAlpha
		{
			[Cpp2IlInjected.Token(Token = "0x600044C")]
			[Cpp2IlInjected.Address(Slot = "2")]
			get;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200009F")]
	public struct LoginResult
	{
		[Cpp2IlInjected.Token(Token = "0x170001FE")]
		public LoginStatus Status
		{
			[Cpp2IlInjected.Token(Token = "0x600044E")]
			[Cpp2IlInjected.Address(RVA = "0xC6C430", Offset = "0xC6B830", VA = "0x180C6C430")]
			[CompilerGenerated]
			readonly get
			{
				return default(LoginStatus);
			}
			[Cpp2IlInjected.Token(Token = "0x600044F")]
			[Cpp2IlInjected.Address(RVA = "0x12A3E30", Offset = "0x12A3230", VA = "0x1812A3E30")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001FF")]
		public JKPMZWFYQBV SecurityCodeHint
		{
			[Cpp2IlInjected.Token(Token = "0x6000450")]
			[Cpp2IlInjected.Address(RVA = "0xC1E140", Offset = "0xC1D540", VA = "0x180C1E140")]
			[CompilerGenerated]
			readonly get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000451")]
			[Cpp2IlInjected.Address(RVA = "0xC1E150", Offset = "0xC1D550", VA = "0x180C1E150")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000200")]
		public string LoginContext
		{
			[Cpp2IlInjected.Token(Token = "0x6000452")]
			[Cpp2IlInjected.Address(RVA = "0xAA5FB0", Offset = "0xAA53B0", VA = "0x180AA5FB0")]
			[CompilerGenerated]
			readonly get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000453")]
			[Cpp2IlInjected.Address(RVA = "0xAA5FC0", Offset = "0xAA53C0", VA = "0x180AA5FC0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600044D")]
		[Cpp2IlInjected.Address(RVA = "0x6412D00", Offset = "0x6412100", VA = "0x186412D00")]
		public LoginResult(LoginStatus status, [Optional] JKPMZWFYQBV securityCodeHint, [Optional] string loginContext)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000A0")]
	public enum LoginStatus
	{
		[Cpp2IlInjected.Token(Token = "0x4000241")]
		Unknown,
		[Cpp2IlInjected.Token(Token = "0x4000242")]
		Success,
		[Cpp2IlInjected.Token(Token = "0x4000243")]
		ContinueSecurityCode,
		[Cpp2IlInjected.Token(Token = "0x4000244")]
		TryAgainSecurityCode,
		[Cpp2IlInjected.Token(Token = "0x4000245")]
		RemoteAuthPending
	}
	[Cpp2IlInjected.Token(Token = "0x20000A1")]
	[Utf8JsonSerializable]
	public class StatsigMemoryOverrideParameterDTO
	{
		[Cpp2IlInjected.Token(Token = "0x17000201")]
		public string LayerName
		{
			[Cpp2IlInjected.Token(Token = "0x6000456")]
			[Cpp2IlInjected.Address(RVA = "0xAA5FB0", Offset = "0xAA53B0", VA = "0x180AA5FB0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000457")]
			[Cpp2IlInjected.Address(RVA = "0xAA5FC0", Offset = "0xAA53C0", VA = "0x180AA5FC0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000202")]
		public string ExperimentName
		{
			[Cpp2IlInjected.Token(Token = "0x6000458")]
			[Cpp2IlInjected.Address(RVA = "0xAAA880", Offset = "0xAA9C80", VA = "0x180AAA880")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000459")]
			[Cpp2IlInjected.Address(RVA = "0xAAA120", Offset = "0xAA9520", VA = "0x180AAA120")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000203")]
		public string ParameterName
		{
			[Cpp2IlInjected.Token(Token = "0x600045A")]
			[Cpp2IlInjected.Address(RVA = "0xAAB1C0", Offset = "0xAAA5C0", VA = "0x180AAB1C0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600045B")]
			[Cpp2IlInjected.Address(RVA = "0xAA67C0", Offset = "0xAA5BC0", VA = "0x180AA67C0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000204")]
		public string ParameterValue
		{
			[Cpp2IlInjected.Token(Token = "0x600045C")]
			[Cpp2IlInjected.Address(RVA = "0xAAA820", Offset = "0xAA9C20", VA = "0x180AAA820")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600045D")]
			[Cpp2IlInjected.Address(RVA = "0xAA67D0", Offset = "0xAA5BD0", VA = "0x180AA67D0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000205")]
		public List<StatsigMemoryOverrideParameterBranchValueDTO> BranchValueOverrides
		{
			[Cpp2IlInjected.Token(Token = "0x600045E")]
			[Cpp2IlInjected.Address(RVA = "0xAAA140", Offset = "0xAA9540", VA = "0x180AAA140")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600045F")]
			[Cpp2IlInjected.Address(RVA = "0xAADB00", Offset = "0xAACF00", VA = "0x180AADB00")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000454")]
		[Cpp2IlInjected.Address(RVA = "0xAAC8E0", Offset = "0xAABCE0", VA = "0x180AAC8E0")]
		public StatsigMemoryOverrideParameterDTO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000455")]
		[Cpp2IlInjected.Address(RVA = "0x742EDD0", Offset = "0x742E1D0", VA = "0x18742EDD0")]
		public StatsigMemoryOverrideParameterDTO([Optional] string layerName, [Optional] string experimentName, [Optional] string parameterName, [Optional] string parameterValue, [Optional] List<StatsigMemoryOverrideParameterBranchValueDTO> branchValueOverrides)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000A2")]
	[Utf8JsonSerializable]
	public class StatsigMemoryOverrideParameterBranchValueDTO
	{
		[Cpp2IlInjected.Token(Token = "0x17000206")]
		public string BranchName
		{
			[Cpp2IlInjected.Token(Token = "0x6000460")]
			[Cpp2IlInjected.Address(RVA = "0xAA5FB0", Offset = "0xAA53B0", VA = "0x180AA5FB0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000461")]
			[Cpp2IlInjected.Address(RVA = "0xAA5FC0", Offset = "0xAA53C0", VA = "0x180AA5FC0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000207")]
		public string ParameterValue
		{
			[Cpp2IlInjected.Token(Token = "0x6000462")]
			[Cpp2IlInjected.Address(RVA = "0xAAA880", Offset = "0xAA9C80", VA = "0x180AAA880")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000463")]
			[Cpp2IlInjected.Address(RVA = "0xAAA120", Offset = "0xAA9520", VA = "0x180AAA120")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000464")]
		[Cpp2IlInjected.Address(RVA = "0xAAC8E0", Offset = "0xAABCE0", VA = "0x180AAC8E0")]
		public StatsigMemoryOverrideParameterBranchValueDTO()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000A3")]
	[Utf8JsonSerializable]
	public class StatsigExperimentConfigDTO
	{
		[Cpp2IlInjected.Token(Token = "0x17000208")]
		public string ExperimentName
		{
			[Cpp2IlInjected.Token(Token = "0x6000465")]
			[Cpp2IlInjected.Address(RVA = "0xAA5FB0", Offset = "0xAA53B0", VA = "0x180AA5FB0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000466")]
			[Cpp2IlInjected.Address(RVA = "0xAA5FC0", Offset = "0xAA53C0", VA = "0x180AA5FC0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000209")]
		public string Status
		{
			[Cpp2IlInjected.Token(Token = "0x6000467")]
			[Cpp2IlInjected.Address(RVA = "0xAAA880", Offset = "0xAA9C80", VA = "0x180AAA880")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000468")]
			[Cpp2IlInjected.Address(RVA = "0xAAA120", Offset = "0xAA9520", VA = "0x180AAA120")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700020A")]
		public string LayerName
		{
			[Cpp2IlInjected.Token(Token = "0x6000469")]
			[Cpp2IlInjected.Address(RVA = "0xAAB1C0", Offset = "0xAAA5C0", VA = "0x180AAB1C0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600046A")]
			[Cpp2IlInjected.Address(RVA = "0xAA67C0", Offset = "0xAA5BC0", VA = "0x180AA67C0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700020B")]
		public List<string> ParameterNames
		{
			[Cpp2IlInjected.Token(Token = "0x600046B")]
			[Cpp2IlInjected.Address(RVA = "0xAAA820", Offset = "0xAA9C20", VA = "0x180AAA820")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600046C")]
			[Cpp2IlInjected.Address(RVA = "0xAA67D0", Offset = "0xAA5BD0", VA = "0x180AA67D0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600046D")]
		[Cpp2IlInjected.Address(RVA = "0xAAC8E0", Offset = "0xAABCE0", VA = "0x180AAC8E0")]
		public StatsigExperimentConfigDTO()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000A4")]
	public interface ZTDEQBSEMSX
	{
		[Cpp2IlInjected.Token(Token = "0x600046E")]
		[Cpp2IlInjected.Address(Slot = "0")]
		void NTJAWBDBXVU();
	}
	[Cpp2IlInjected.Token(Token = "0x20000A5")]
	public interface DURPPUIUDDT
	{
		[Cpp2IlInjected.Token(Token = "0x600046F")]
		[Cpp2IlInjected.Address(Slot = "0")]
		Task NLICNVNCYRU();
	}
	[Cpp2IlInjected.Token(Token = "0x20000A6")]
	[Utf8JsonSerializable]
	public class OutfitSelectionDTO
	{
		[Cpp2IlInjected.Token(Token = "0x1700020C")]
		public Guid CustomAvatarItemId
		{
			[Cpp2IlInjected.Token(Token = "0x6000472")]
			[Cpp2IlInjected.Address(RVA = "0xBAF500", Offset = "0xBAE900", VA = "0x180BAF500")]
			[CompilerGenerated]
			get
			{
				return default(Guid);
			}
			[Cpp2IlInjected.Token(Token = "0x6000473")]
			[Cpp2IlInjected.Address(RVA = "0xBAF520", Offset = "0xBAE920", VA = "0x180BAF520")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700020D")]
		public int BodyPart
		{
			[Cpp2IlInjected.Token(Token = "0x6000474")]
			[Cpp2IlInjected.Address(RVA = "0xAB5660", Offset = "0xAB4A60", VA = "0x180AB5660")]
			[CompilerGenerated]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x6000475")]
			[Cpp2IlInjected.Address(RVA = "0xB07AB0", Offset = "0xB06EB0", VA = "0x180B07AB0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700020E")]
		public string BakedUnityAssetFileName
		{
			[Cpp2IlInjected.Token(Token = "0x6000476")]
			[Cpp2IlInjected.Address(RVA = "0xAAA820", Offset = "0xAA9C20", VA = "0x180AAA820")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000477")]
			[Cpp2IlInjected.Address(RVA = "0xAA67D0", Offset = "0xAA5BD0", VA = "0x180AA67D0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700020F")]
		public string AdditionalConfiguration
		{
			[Cpp2IlInjected.Token(Token = "0x6000478")]
			[Cpp2IlInjected.Address(RVA = "0xAAA140", Offset = "0xAA9540", VA = "0x180AAA140")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000479")]
			[Cpp2IlInjected.Address(RVA = "0xAADB00", Offset = "0xAACF00", VA = "0x180AADB00")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000470")]
		[Cpp2IlInjected.Address(RVA = "0xAAC8E0", Offset = "0xAABCE0", VA = "0x180AAC8E0")]
		public OutfitSelectionDTO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000471")]
		[Cpp2IlInjected.Address(RVA = "0x771A580", Offset = "0x7719980", VA = "0x18771A580")]
		public OutfitSelectionDTO([Optional] Guid customAvatarItemId, int bodyPart = 0, [Optional] string bakedUnityAssetFileName, [Optional] string additionalConfiguration)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000A7")]
	[Utf8JsonSerializable]
	public class OutfitDTO
	{
		[Cpp2IlInjected.Token(Token = "0x4000255")]
		public const int CurrentOutfitSlot = 0;

		[Cpp2IlInjected.Token(Token = "0x17000210")]
		public long DataVersion
		{
			[Cpp2IlInjected.Token(Token = "0x600047C")]
			[Cpp2IlInjected.Address(RVA = "0xAA5FB0", Offset = "0xAA53B0", VA = "0x180AA5FB0")]
			[CompilerGenerated]
			get
			{
				return default(long);
			}
			[Cpp2IlInjected.Token(Token = "0x600047D")]
			[Cpp2IlInjected.Address(RVA = "0xB96550", Offset = "0xB95950", VA = "0x180B96550")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000211")]
		public LegacyOutfitDataDTO LegacyData
		{
			[Cpp2IlInjected.Token(Token = "0x600047E")]
			[Cpp2IlInjected.Address(RVA = "0xAAA880", Offset = "0xAA9C80", VA = "0x180AAA880")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600047F")]
			[Cpp2IlInjected.Address(RVA = "0xAAA120", Offset = "0xAA9520", VA = "0x180AAA120")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000212")]
		public string CustomizationSettings
		{
			[Cpp2IlInjected.Token(Token = "0x6000480")]
			[Cpp2IlInjected.Address(RVA = "0xAAB1C0", Offset = "0xAAA5C0", VA = "0x180AAB1C0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000481")]
			[Cpp2IlInjected.Address(RVA = "0xAA67C0", Offset = "0xAA5BC0", VA = "0x180AA67C0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000213")]
		public List<OutfitSelectionDTO> Selections
		{
			[Cpp2IlInjected.Token(Token = "0x6000482")]
			[Cpp2IlInjected.Address(RVA = "0xAAA820", Offset = "0xAA9C20", VA = "0x180AAA820")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000483")]
			[Cpp2IlInjected.Address(RVA = "0xAA67D0", Offset = "0xAA5BD0", VA = "0x180AA67D0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000214")]
		public int Slot
		{
			[Cpp2IlInjected.Token(Token = "0x6000484")]
			[Cpp2IlInjected.Address(RVA = "0xAAF800", Offset = "0xAAEC00", VA = "0x180AAF800")]
			[CompilerGenerated]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x6000485")]
			[Cpp2IlInjected.Address(RVA = "0xAAF7F0", Offset = "0xAAEBF0", VA = "0x180AAF7F0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000215")]
		public string Name
		{
			[Cpp2IlInjected.Token(Token = "0x6000486")]
			[Cpp2IlInjected.Address(RVA = "0xAAA030", Offset = "0xAA9430", VA = "0x180AAA030")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000487")]
			[Cpp2IlInjected.Address(RVA = "0xAAA110", Offset = "0xAA9510", VA = "0x180AAA110")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000216")]
		public UgcAccessibility Accessibility
		{
			[Cpp2IlInjected.Token(Token = "0x6000488")]
			[Cpp2IlInjected.Address(RVA = "0xAC1F70", Offset = "0xAC1370", VA = "0x180AC1F70")]
			[CompilerGenerated]
			get
			{
				return default(UgcAccessibility);
			}
			[Cpp2IlInjected.Token(Token = "0x6000489")]
			[Cpp2IlInjected.Address(RVA = "0xBDCB60", Offset = "0xBDBF60", VA = "0x180BDCB60")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000217")]
		public string ThumbnailFileName
		{
			[Cpp2IlInjected.Token(Token = "0x600048A")]
			[Cpp2IlInjected.Address(RVA = "0xAAA160", Offset = "0xAA9560", VA = "0x180AAA160")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600048B")]
			[Cpp2IlInjected.Address(RVA = "0xAAA870", Offset = "0xAA9C70", VA = "0x180AAA870")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000218")]
		public bool IsCurrentlyEquipped
		{
			[Cpp2IlInjected.Token(Token = "0x600048C")]
			[Cpp2IlInjected.Address(RVA = "0x2033160", Offset = "0x2032560", VA = "0x182033160")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600047A")]
		[Cpp2IlInjected.Address(RVA = "0x771A480", Offset = "0x7719880", VA = "0x18771A480")]
		public OutfitDTO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600047B")]
		[Cpp2IlInjected.Address(RVA = "0x771A360", Offset = "0x7719760", VA = "0x18771A360")]
		public OutfitDTO(long dataVersion = 0L, [Optional] LegacyOutfitDataDTO legacyData, [Optional] string customizationSettings, [Optional] List<OutfitSelectionDTO> selections, int slot = 0, [Optional] string name, UgcAccessibility accessibility = UgcAccessibility.Private, [Optional] string thumbnailFileName)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000A8")]
	public class FDCQPMDXBZY
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400025E")]
		public readonly int QOEILSPIXVG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400025F")]
		public readonly OutfitDTO GUGKGTIJLZT;

		[Cpp2IlInjected.Token(Token = "0x600048D")]
		[Cpp2IlInjected.Address(RVA = "0xD7A3C0", Offset = "0xD797C0", VA = "0x180D7A3C0")]
		public FDCQPMDXBZY(int a, OutfitDTO b)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000A9")]
	[Utf8JsonSerializable]
	public class LegacyOutfitDataDTO
	{
		[Cpp2IlInjected.Token(Token = "0x17000219")]
		public string SelectionsV1
		{
			[Cpp2IlInjected.Token(Token = "0x6000490")]
			[Cpp2IlInjected.Address(RVA = "0xAA5FB0", Offset = "0xAA53B0", VA = "0x180AA5FB0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000491")]
			[Cpp2IlInjected.Address(RVA = "0xAA5FC0", Offset = "0xAA53C0", VA = "0x180AA5FC0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700021A")]
		public string SelectionsV2
		{
			[Cpp2IlInjected.Token(Token = "0x6000492")]
			[Cpp2IlInjected.Address(RVA = "0xAAA880", Offset = "0xAA9C80", VA = "0x180AAA880")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000493")]
			[Cpp2IlInjected.Address(RVA = "0xAAA120", Offset = "0xAA9520", VA = "0x180AAA120")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700021B")]
		public string FaceFeatures
		{
			[Cpp2IlInjected.Token(Token = "0x6000494")]
			[Cpp2IlInjected.Address(RVA = "0xAAB1C0", Offset = "0xAAA5C0", VA = "0x180AAB1C0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000495")]
			[Cpp2IlInjected.Address(RVA = "0xAA67C0", Offset = "0xAA5BC0", VA = "0x180AA67C0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700021C")]
		public string SkinColor
		{
			[Cpp2IlInjected.Token(Token = "0x6000496")]
			[Cpp2IlInjected.Address(RVA = "0xAAA820", Offset = "0xAA9C20", VA = "0x180AAA820")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000497")]
			[Cpp2IlInjected.Address(RVA = "0xAA67D0", Offset = "0xAA5BD0", VA = "0x180AA67D0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700021D")]
		public string HairColor
		{
			[Cpp2IlInjected.Token(Token = "0x6000498")]
			[Cpp2IlInjected.Address(RVA = "0xAAA140", Offset = "0xAA9540", VA = "0x180AAA140")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000499")]
			[Cpp2IlInjected.Address(RVA = "0xAADB00", Offset = "0xAACF00", VA = "0x180AADB00")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700021E")]
		public string Selections
		{
			[Cpp2IlInjected.Token(Token = "0x600049A")]
			[Cpp2IlInjected.Address(RVA = "0x7719FA0", Offset = "0x77193A0", VA = "0x187719FA0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600048E")]
		[Cpp2IlInjected.Address(RVA = "0xAAC8E0", Offset = "0xAABCE0", VA = "0x180AAC8E0")]
		public LegacyOutfitDataDTO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600048F")]
		[Cpp2IlInjected.Address(RVA = "0x742EDD0", Offset = "0x742E1D0", VA = "0x18742EDD0")]
		public LegacyOutfitDataDTO([Optional] string selectionsV1, [Optional] string selectionsV2, [Optional] string faceFeatures, [Optional] string skinColor, [Optional] string hairColor)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000AA")]
	[Utf8JsonSerializable]
	public class GetPlayersOutfitsResponseDTO
	{
		[Cpp2IlInjected.Token(Token = "0x1700021F")]
		public Dictionary<int, OutfitDTO> OutfitsByAccountId
		{
			[Cpp2IlInjected.Token(Token = "0x600049B")]
			[Cpp2IlInjected.Address(RVA = "0xAA5FB0", Offset = "0xAA53B0", VA = "0x180AA5FB0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600049C")]
			[Cpp2IlInjected.Address(RVA = "0xAA5FC0", Offset = "0xAA53C0", VA = "0x180AA5FC0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600049D")]
		[Cpp2IlInjected.Address(RVA = "0xAAC8E0", Offset = "0xAABCE0", VA = "0x180AAC8E0")]
		public GetPlayersOutfitsResponseDTO()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000AB")]
	[Utf8JsonSerializable]
	public class GetPlayersOutfitsRequestDTO
	{
		[Cpp2IlInjected.Token(Token = "0x17000220")]
		public List<int> AccountIds
		{
			[Cpp2IlInjected.Token(Token = "0x600049E")]
			[Cpp2IlInjected.Address(RVA = "0xAA5FB0", Offset = "0xAA53B0", VA = "0x180AA5FB0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600049F")]
			[Cpp2IlInjected.Address(RVA = "0xAA5FC0", Offset = "0xAA53C0", VA = "0x180AA5FC0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000221")]
		public byte? UnityAssetTarget
		{
			[Cpp2IlInjected.Token(Token = "0x60004A0")]
			[Cpp2IlInjected.Address(RVA = "0x2F84ED0", Offset = "0x2F842D0", VA = "0x182F84ED0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60004A1")]
			[Cpp2IlInjected.Address(RVA = "0x2F84EE0", Offset = "0x2F842E0", VA = "0x182F84EE0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000222")]
		public int? UnityAssetVersion
		{
			[Cpp2IlInjected.Token(Token = "0x60004A2")]
			[Cpp2IlInjected.Address(RVA = "0x10D2A80", Offset = "0x10D1E80", VA = "0x1810D2A80")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60004A3")]
			[Cpp2IlInjected.Address(RVA = "0x10D2AB0", Offset = "0x10D1EB0", VA = "0x1810D2AB0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60004A4")]
		[Cpp2IlInjected.Address(RVA = "0xAAC8E0", Offset = "0xAABCE0", VA = "0x180AAC8E0")]
		public GetPlayersOutfitsRequestDTO()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000AC")]
	public static class UQYFLXPUBQI
	{
		[Cpp2IlInjected.Token(Token = "0x60004A5")]
		[Cpp2IlInjected.Address(RVA = "0x771F610", Offset = "0x771EA10", VA = "0x18771F610")]
		public static CustomAvatarItemVisualData MUPEPEBWVVY(this OutfitSelectionDTO a)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000AD")]
	[Flags]
	public enum PlatformMask
	{
		[Cpp2IlInjected.Token(Token = "0x400026A")]
		None = 0,
		[Cpp2IlInjected.Token(Token = "0x400026B")]
		Steam = 1,
		[Cpp2IlInjected.Token(Token = "0x400026C")]
		Oculus = 2,
		[Cpp2IlInjected.Token(Token = "0x400026D")]
		PlayStation = 4,
		[Cpp2IlInjected.Token(Token = "0x400026E")]
		Xbox = 8,
		[Cpp2IlInjected.Token(Token = "0x400026F")]
		RecNet = 0x10,
		[Cpp2IlInjected.Token(Token = "0x4000270")]
		IOS = 0x20,
		[Cpp2IlInjected.Token(Token = "0x4000271")]
		GooglePlay = 0x40,
		[Cpp2IlInjected.Token(Token = "0x4000272")]
		Standalone = 0x80,
		[Cpp2IlInjected.Token(Token = "0x4000273")]
		Pico = 0x100,
		[Cpp2IlInjected.Token(Token = "0x4000274")]
		Switch = 0x200,
		[Cpp2IlInjected.Token(Token = "0x4000275")]
		All = -1
	}
	[Cpp2IlInjected.Token(Token = "0x20000AE")]
	public enum PlatformType
	{
		[Cpp2IlInjected.Token(Token = "0x4000277")]
		All = -1,
		[Cpp2IlInjected.Token(Token = "0x4000278")]
		Steam,
		[Cpp2IlInjected.Token(Token = "0x4000279")]
		Oculus,
		[Cpp2IlInjected.Token(Token = "0x400027A")]
		PlayStation,
		[Cpp2IlInjected.Token(Token = "0x400027B")]
		Xbox,
		[Cpp2IlInjected.Token(Token = "0x400027C")]
		RecNet,
		[Cpp2IlInjected.Token(Token = "0x400027D")]
		IOS,
		[Cpp2IlInjected.Token(Token = "0x400027E")]
		GooglePlay,
		[Cpp2IlInjected.Token(Token = "0x400027F")]
		Standalone,
		[Cpp2IlInjected.Token(Token = "0x4000280")]
		Pico,
		[Cpp2IlInjected.Token(Token = "0x4000281")]
		Switch
	}
	[Cpp2IlInjected.Token(Token = "0x20000AF")]
	[Utf8JsonSerializable]
	public class Progression
	{
		[Cpp2IlInjected.Token(Token = "0x17000223")]
		[DataMember(Name = "PlayerId")]
		public int AccountId
		{
			[Cpp2IlInjected.Token(Token = "0x60004A6")]
			[Cpp2IlInjected.Address(RVA = "0xAA3110", Offset = "0xAA2510", VA = "0x180AA3110")]
			[CompilerGenerated]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x60004A7")]
			[Cpp2IlInjected.Address(RVA = "0xAAB1D0", Offset = "0xAAA5D0", VA = "0x180AAB1D0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000224")]
		public int Level
		{
			[Cpp2IlInjected.Token(Token = "0x60004A8")]
			[Cpp2IlInjected.Address(RVA = "0xC4E2B0", Offset = "0xC4D6B0", VA = "0x180C4E2B0")]
			[CompilerGenerated]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x60004A9")]
			[Cpp2IlInjected.Address(RVA = "0xCDF260", Offset = "0xCDE660", VA = "0x180CDF260")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000225")]
		public int XP
		{
			[Cpp2IlInjected.Token(Token = "0x60004AA")]
			[Cpp2IlInjected.Address(RVA = "0xAAC980", Offset = "0xAABD80", VA = "0x180AAC980")]
			[CompilerGenerated]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x60004AB")]
			[Cpp2IlInjected.Address(RVA = "0xAB2F40", Offset = "0xAB2340", VA = "0x180AB2F40")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60004AC")]
		[Cpp2IlInjected.Address(RVA = "0xAAC8E0", Offset = "0xAABCE0", VA = "0x180AAC8E0")]
		public Progression()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000B0")]
	[Utf8JsonSerializable]
	public class ProgressionEventRecordDTO
	{
		[Cpp2IlInjected.Token(Token = "0x17000226")]
		public int AccountId
		{
			[Cpp2IlInjected.Token(Token = "0x60004AF")]
			[Cpp2IlInjected.Address(RVA = "0xAA3110", Offset = "0xAA2510", VA = "0x180AA3110")]
			[CompilerGenerated]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x60004B0")]
			[Cpp2IlInjected.Address(RVA = "0xAAB1D0", Offset = "0xAAA5D0", VA = "0x180AAB1D0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000227")]
		public long ProgressionEventId
		{
			[Cpp2IlInjected.Token(Token = "0x60004B1")]
			[Cpp2IlInjected.Address(RVA = "0xAAA880", Offset = "0xAA9C80", VA = "0x180AAA880")]
			[CompilerGenerated]
			get
			{
				return default(long);
			}
			[Cpp2IlInjected.Token(Token = "0x60004B2")]
			[Cpp2IlInjected.Address(RVA = "0x10BA780", Offset = "0x10B9B80", VA = "0x1810BA780")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000228")]
		public int Xp
		{
			[Cpp2IlInjected.Token(Token = "0x60004B3")]
			[Cpp2IlInjected.Address(RVA = "0xAB5660", Offset = "0xAB4A60", VA = "0x180AB5660")]
			[CompilerGenerated]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x60004B4")]
			[Cpp2IlInjected.Address(RVA = "0xB07AB0", Offset = "0xB06EB0", VA = "0x180B07AB0")]
			[CompilerGenerated]
			internal set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000229")]
		public int GameMinutesToday
		{
			[Cpp2IlInjected.Token(Token = "0x60004B5")]
			[Cpp2IlInjected.Address(RVA = "0xACC3D0", Offset = "0xACB7D0", VA = "0x180ACC3D0")]
			[CompilerGenerated]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x60004B6")]
			[Cpp2IlInjected.Address(RVA = "0xBE18B0", Offset = "0xBE0CB0", VA = "0x180BE18B0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700022A")]
		public int RewardsCollected
		{
			[Cpp2IlInjected.Token(Token = "0x60004B7")]
			[Cpp2IlInjected.Address(RVA = "0xAAB1A0", Offset = "0xAAA5A0", VA = "0x180AAB1A0")]
			[CompilerGenerated]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x60004B8")]
			[Cpp2IlInjected.Address(RVA = "0xAAB1B0", Offset = "0xAAA5B0", VA = "0x180AAB1B0")]
			[CompilerGenerated]
			internal set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700022B")]
		public int BonusRewardsCollected
		{
			[Cpp2IlInjected.Token(Token = "0x60004B9")]
			[Cpp2IlInjected.Address(RVA = "0xC4E8F0", Offset = "0xC4DCF0", VA = "0x180C4E8F0")]
			[CompilerGenerated]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x60004BA")]
			[Cpp2IlInjected.Address(RVA = "0x1ACB200", Offset = "0x1ACA600", VA = "0x181ACB200")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700022C")]
		public DateTime? XpBoostLastPurchasedAt
		{
			[Cpp2IlInjected.Token(Token = "0x60004BB")]
			[Cpp2IlInjected.Address(RVA = "0xC5CFF0", Offset = "0xC5C3F0", VA = "0x180C5CFF0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60004BC")]
			[Cpp2IlInjected.Address(RVA = "0xC5D250", Offset = "0xC5C650", VA = "0x180C5D250")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700022D")]
		public int PremiumRewardsCollected
		{
			[Cpp2IlInjected.Token(Token = "0x60004BD")]
			[Cpp2IlInjected.Address(RVA = "0xAC1F70", Offset = "0xAC1370", VA = "0x180AC1F70")]
			[CompilerGenerated]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x60004BE")]
			[Cpp2IlInjected.Address(RVA = "0xBDCB60", Offset = "0xBDBF60", VA = "0x180BDCB60")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700022E")]
		public ProgressionEventLimitedRewardCollectionState LimitedRewardCollectionState
		{
			[Cpp2IlInjected.Token(Token = "0x60004BF")]
			[Cpp2IlInjected.Address(RVA = "0xAC1F80", Offset = "0xAC1380", VA = "0x180AC1F80")]
			[CompilerGenerated]
			get
			{
				return default(ProgressionEventLimitedRewardCollectionState);
			}
			[Cpp2IlInjected.Token(Token = "0x60004C0")]
			[Cpp2IlInjected.Address(RVA = "0xCDFCC0", Offset = "0xCDF0C0", VA = "0x180CDFCC0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60004AD")]
		[Cpp2IlInjected.Address(RVA = "0xAAC8E0", Offset = "0xAABCE0", VA = "0x180AAC8E0")]
		public ProgressionEventRecordDTO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004AE")]
		[Cpp2IlInjected.Address(RVA = "0x771A7F0", Offset = "0x7719BF0", VA = "0x18771A7F0")]
		public ProgressionEventRecordDTO(int accountId = 0, long progressionEventId = 0L, int xp = 0, int gameMinutesToday = 0, int rewardsCollected = 0)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000B1")]
	[Utf8JsonSerializable]
	public class ProgressionEventDTO
	{
		[Cpp2IlInjected.Token(Token = "0x1700022F")]
		public long ProgressionEventId
		{
			[Cpp2IlInjected.Token(Token = "0x60004C3")]
			[Cpp2IlInjected.Address(RVA = "0xAA5FB0", Offset = "0xAA53B0", VA = "0x180AA5FB0")]
			[CompilerGenerated]
			get
			{
				return default(long);
			}
			[Cpp2IlInjected.Token(Token = "0x60004C4")]
			[Cpp2IlInjected.Address(RVA = "0xB96550", Offset = "0xB95950", VA = "0x180B96550")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000230")]
		public string Name
		{
			[Cpp2IlInjected.Token(Token = "0x60004C5")]
			[Cpp2IlInjected.Address(RVA = "0xAAA880", Offset = "0xAA9C80", VA = "0x180AAA880")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60004C6")]
			[Cpp2IlInjected.Address(RVA = "0xAAA120", Offset = "0xAA9520", VA = "0x180AAA120")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000231")]
		public List<ProgressionEventRewardDTO> Rewards
		{
			[Cpp2IlInjected.Token(Token = "0x60004C7")]
			[Cpp2IlInjected.Address(RVA = "0xAAB1C0", Offset = "0xAAA5C0", VA = "0x180AAB1C0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60004C8")]
			[Cpp2IlInjected.Address(RVA = "0xAA67C0", Offset = "0xAA5BC0", VA = "0x180AA67C0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000232")]
		public List<KeepsakeRoomListDTO> KeepsakeRoomLists
		{
			[Cpp2IlInjected.Token(Token = "0x60004C9")]
			[Cpp2IlInjected.Address(RVA = "0xAAA820", Offset = "0xAA9C20", VA = "0x180AAA820")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60004CA")]
			[Cpp2IlInjected.Address(RVA = "0xAA67D0", Offset = "0xAA5BD0", VA = "0x180AA67D0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000233")]
		public DateTime StartTime
		{
			[Cpp2IlInjected.Token(Token = "0x60004CB")]
			[Cpp2IlInjected.Address(RVA = "0xAAA140", Offset = "0xAA9540", VA = "0x180AAA140")]
			[CompilerGenerated]
			get
			{
				return default(DateTime);
			}
			[Cpp2IlInjected.Token(Token = "0x60004CC")]
			[Cpp2IlInjected.Address(RVA = "0xAAA860", Offset = "0xAA9C60", VA = "0x180AAA860")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000234")]
		public DateTime EndTime
		{
			[Cpp2IlInjected.Token(Token = "0x60004CD")]
			[Cpp2IlInjected.Address(RVA = "0xAAA030", Offset = "0xAA9430", VA = "0x180AAA030")]
			[CompilerGenerated]
			get
			{
				return default(DateTime);
			}
			[Cpp2IlInjected.Token(Token = "0x60004CE")]
			[Cpp2IlInjected.Address(RVA = "0xAAF810", Offset = "0xAAEC10", VA = "0x180AAF810")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000235")]
		public DateTime CollectionEndTime
		{
			[Cpp2IlInjected.Token(Token = "0x60004CF")]
			[Cpp2IlInjected.Address(RVA = "0xAAA810", Offset = "0xAA9C10", VA = "0x180AAA810")]
			[CompilerGenerated]
			get
			{
				return default(DateTime);
			}
			[Cpp2IlInjected.Token(Token = "0x60004D0")]
			[Cpp2IlInjected.Address(RVA = "0xCDACA0", Offset = "0xCDA0A0", VA = "0x180CDACA0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000236")]
		public bool UsesBoost
		{
			[Cpp2IlInjected.Token(Token = "0x60004D1")]
			[Cpp2IlInjected.Address(RVA = "0xB42090", Offset = "0xB41490", VA = "0x180B42090")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x60004D2")]
			[Cpp2IlInjected.Address(RVA = "0xB82840", Offset = "0xB81C40", VA = "0x180B82840")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000237")]
		public int BoostDailyGameplayMinutesLimit
		{
			[Cpp2IlInjected.Token(Token = "0x60004D3")]
			[Cpp2IlInjected.Address(RVA = "0x11F0980", Offset = "0x11EFD80", VA = "0x1811F0980")]
			[CompilerGenerated]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x60004D4")]
			[Cpp2IlInjected.Address(RVA = "0x1950190", Offset = "0x194F590", VA = "0x181950190")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000238")]
		public float BoostXpMultiplier
		{
			[Cpp2IlInjected.Token(Token = "0x60004D5")]
			[Cpp2IlInjected.Address(RVA = "0xAF4150", Offset = "0xAF3550", VA = "0x180AF4150")]
			[CompilerGenerated]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x60004D6")]
			[Cpp2IlInjected.Address(RVA = "0xD71010", Offset = "0xD70410", VA = "0x180D71010")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000239")]
		public Guid? PurchasableXpBoostId
		{
			[Cpp2IlInjected.Token(Token = "0x60004D7")]
			[Cpp2IlInjected.Address(RVA = "0x771A7B0", Offset = "0x7719BB0", VA = "0x18771A7B0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60004D8")]
			[Cpp2IlInjected.Address(RVA = "0x771A7D0", Offset = "0x7719BD0", VA = "0x18771A7D0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700023A")]
		public string ActiveExperiment
		{
			[Cpp2IlInjected.Token(Token = "0x60004D9")]
			[Cpp2IlInjected.Address(RVA = "0xAA3120", Offset = "0xAA2520", VA = "0x180AA3120")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60004DA")]
			[Cpp2IlInjected.Address(RVA = "0xAA3140", Offset = "0xAA2540", VA = "0x180AA3140")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700023B")]
		public string ChallengesIconImageName
		{
			[Cpp2IlInjected.Token(Token = "0x60004DB")]
			[Cpp2IlInjected.Address(RVA = "0xAA5380", Offset = "0xAA4780", VA = "0x180AA5380")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60004DC")]
			[Cpp2IlInjected.Address(RVA = "0xAA5390", Offset = "0xAA4790", VA = "0x180AA5390")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700023C")]
		public string RewardsPipImageName
		{
			[Cpp2IlInjected.Token(Token = "0x60004DD")]
			[Cpp2IlInjected.Address(RVA = "0xAAD010", Offset = "0xAAC410", VA = "0x180AAD010")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60004DE")]
			[Cpp2IlInjected.Address(RVA = "0xAAD050", Offset = "0xAAC450", VA = "0x180AAD050")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700023D")]
		public string EventInfoImageName
		{
			[Cpp2IlInjected.Token(Token = "0x60004DF")]
			[Cpp2IlInjected.Address(RVA = "0xAAD040", Offset = "0xAAC440", VA = "0x180AAD040")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60004E0")]
			[Cpp2IlInjected.Address(RVA = "0xAAC9D0", Offset = "0xAABDD0", VA = "0x180AAC9D0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700023E")]
		public long? EventLeaderboardId
		{
			[Cpp2IlInjected.Token(Token = "0x60004E1")]
			[Cpp2IlInjected.Address(RVA = "0x1E5ABB0", Offset = "0x1E59FB0", VA = "0x181E5ABB0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60004E2")]
			[Cpp2IlInjected.Address(RVA = "0x5F0E340", Offset = "0x5F0D740", VA = "0x185F0E340")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60004C1")]
		[Cpp2IlInjected.Address(RVA = "0xAAC8E0", Offset = "0xAABCE0", VA = "0x180AAC8E0")]
		public ProgressionEventDTO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004C2")]
		[Cpp2IlInjected.Address(RVA = "0x771A6F0", Offset = "0x7719AF0", VA = "0x18771A6F0")]
		public ProgressionEventDTO(long progressionEventId = 0L, [Optional] string name, [Optional] List<ProgressionEventRewardDTO> rewards, [Optional] List<KeepsakeRoomListDTO> keepsakeRoomLists, [Optional] DateTime startTime, [Optional] DateTime endTime, [Optional] DateTime collectionEndTime, bool usesBoost = false, int boostDailyGameplayMinutesLimit = 0, float boostXpMultiplier = 0f, [Optional] long? eventLeaderboardId)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000B2")]
	[Utf8JsonSerializable]
	public class KeepsakeRoomListDTO
	{
		[Cpp2IlInjected.Token(Token = "0x1700023F")]
		public long KeepsakeRoomListId
		{
			[Cpp2IlInjected.Token(Token = "0x60004E5")]
			[Cpp2IlInjected.Address(RVA = "0xAA5FB0", Offset = "0xAA53B0", VA = "0x180AA5FB0")]
			[CompilerGenerated]
			get
			{
				return default(long);
			}
			[Cpp2IlInjected.Token(Token = "0x60004E6")]
			[Cpp2IlInjected.Address(RVA = "0xB96550", Offset = "0xB95950", VA = "0x180B96550")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000240")]
		public long ProgressionEventId
		{
			[Cpp2IlInjected.Token(Token = "0x60004E7")]
			[Cpp2IlInjected.Address(RVA = "0xAAA880", Offset = "0xAA9C80", VA = "0x180AAA880")]
			[CompilerGenerated]
			get
			{
				return default(long);
			}
			[Cpp2IlInjected.Token(Token = "0x60004E8")]
			[Cpp2IlInjected.Address(RVA = "0x10BA780", Offset = "0x10B9B80", VA = "0x1810BA780")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000241")]
		public int? UnlockItemAvatarItemId
		{
			[Cpp2IlInjected.Token(Token = "0x60004E9")]
			[Cpp2IlInjected.Address(RVA = "0xAAB1C0", Offset = "0xAAA5C0", VA = "0x180AAB1C0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60004EA")]
			[Cpp2IlInjected.Address(RVA = "0xB30430", Offset = "0xB2F830", VA = "0x180B30430")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000242")]
		public int? UnlockItemGiftDropId
		{
			[Cpp2IlInjected.Token(Token = "0x60004EB")]
			[Cpp2IlInjected.Address(RVA = "0xAAA820", Offset = "0xAA9C20", VA = "0x180AAA820")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60004EC")]
			[Cpp2IlInjected.Address(RVA = "0xAAA000", Offset = "0xAA9400", VA = "0x180AAA000")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000243")]
		public long? UnlockItemLockDurationTicks
		{
			[Cpp2IlInjected.Token(Token = "0x60004ED")]
			[Cpp2IlInjected.Address(RVA = "0xC5CFF0", Offset = "0xC5C3F0", VA = "0x180C5CFF0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60004EE")]
			[Cpp2IlInjected.Address(RVA = "0xC5D250", Offset = "0xC5C650", VA = "0x180C5D250")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000244")]
		public long RoomUnlockStartOffsetTicks
		{
			[Cpp2IlInjected.Token(Token = "0x60004EF")]
			[Cpp2IlInjected.Address(RVA = "0xAAA810", Offset = "0xAA9C10", VA = "0x180AAA810")]
			[CompilerGenerated]
			get
			{
				return default(long);
			}
			[Cpp2IlInjected.Token(Token = "0x60004F0")]
			[Cpp2IlInjected.Address(RVA = "0xCDACA0", Offset = "0xCDA0A0", VA = "0x180CDACA0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000245")]
		public TimeSpan RoomUnlockStartOffset
		{
			[Cpp2IlInjected.Token(Token = "0x60004F1")]
			[Cpp2IlInjected.Address(RVA = "0x7719D10", Offset = "0x7719110", VA = "0x187719D10")]
			get
			{
				return default(TimeSpan);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000246")]
		public long RoomUnlockIntervalTicks
		{
			[Cpp2IlInjected.Token(Token = "0x60004F2")]
			[Cpp2IlInjected.Address(RVA = "0xAAA160", Offset = "0xAA9560", VA = "0x180AAA160")]
			[CompilerGenerated]
			get
			{
				return default(long);
			}
			[Cpp2IlInjected.Token(Token = "0x60004F3")]
			[Cpp2IlInjected.Address(RVA = "0x10D7F70", Offset = "0x10D7370", VA = "0x1810D7F70")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000247")]
		public TimeSpan RoomUnlockInterval
		{
			[Cpp2IlInjected.Token(Token = "0x60004F4")]
			[Cpp2IlInjected.Address(RVA = "0x7719CC0", Offset = "0x77190C0", VA = "0x187719CC0")]
			get
			{
				return default(TimeSpan);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000248")]
		public int RoomUnlockBatchSize
		{
			[Cpp2IlInjected.Token(Token = "0x60004F5")]
			[Cpp2IlInjected.Address(RVA = "0xBB86C0", Offset = "0xBB7AC0", VA = "0x180BB86C0")]
			[CompilerGenerated]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x60004F6")]
			[Cpp2IlInjected.Address(RVA = "0x175B160", Offset = "0x175A560", VA = "0x18175B160")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000249")]
		public KeepsakeRoomType RoomType
		{
			[Cpp2IlInjected.Token(Token = "0x60004F7")]
			[Cpp2IlInjected.Address(RVA = "0x1021150", Offset = "0x1020550", VA = "0x181021150")]
			[CompilerGenerated]
			get
			{
				return default(KeepsakeRoomType);
			}
			[Cpp2IlInjected.Token(Token = "0x60004F8")]
			[Cpp2IlInjected.Address(RVA = "0x1E44860", Offset = "0x1E43C60", VA = "0x181E44860")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700024A")]
		public List<KeepsakeRoomDTO> KeepsakeRooms
		{
			[Cpp2IlInjected.Token(Token = "0x60004F9")]
			[Cpp2IlInjected.Address(RVA = "0xAA3150", Offset = "0xAA2550", VA = "0x180AA3150")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60004FA")]
			[Cpp2IlInjected.Address(RVA = "0xAA33A0", Offset = "0xAA27A0", VA = "0x180AA33A0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60004E3")]
		[Cpp2IlInjected.Address(RVA = "0xAAC8E0", Offset = "0xAABCE0", VA = "0x180AAC8E0")]
		public KeepsakeRoomListDTO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004E4")]
		[Cpp2IlInjected.Address(RVA = "0x7719BD0", Offset = "0x7718FD0", VA = "0x187719BD0")]
		public KeepsakeRoomListDTO(long keepsakeRoomListId = 0L, long progressionEventId = 0L, [Optional] int? unlockItemAvatarItemId, [Optional] int? unlockItemGiftDropId, [Optional] long? unlockItemLockDurationTicks, long roomUnlockStartOffsetTicks = 0L, long roomUnlockIntervalTicks = 0L, int roomUnlockBatchSize = 0, KeepsakeRoomType roomType = KeepsakeRoomType.Standard, [Optional] List<KeepsakeRoomDTO> keepsakeRooms)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000B3")]
	[Utf8JsonSerializable]
	public class KeepsakeRoomDTO
	{
		[Cpp2IlInjected.Token(Token = "0x1700024B")]
		public long KeepsakeRoomId
		{
			[Cpp2IlInjected.Token(Token = "0x60004FD")]
			[Cpp2IlInjected.Address(RVA = "0xAA5FB0", Offset = "0xAA53B0", VA = "0x180AA5FB0")]
			[CompilerGenerated]
			get
			{
				return default(long);
			}
			[Cpp2IlInjected.Token(Token = "0x60004FE")]
			[Cpp2IlInjected.Address(RVA = "0xB96550", Offset = "0xB95950", VA = "0x180B96550")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700024C")]
		public long RoomId
		{
			[Cpp2IlInjected.Token(Token = "0x60004FF")]
			[Cpp2IlInjected.Address(RVA = "0xAAA880", Offset = "0xAA9C80", VA = "0x180AAA880")]
			[CompilerGenerated]
			get
			{
				return default(long);
			}
			[Cpp2IlInjected.Token(Token = "0x6000500")]
			[Cpp2IlInjected.Address(RVA = "0x10BA780", Offset = "0x10B9B80", VA = "0x1810BA780")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700024D")]
		public long KeepsakeRoomListId
		{
			[Cpp2IlInjected.Token(Token = "0x6000501")]
			[Cpp2IlInjected.Address(RVA = "0xAAB1C0", Offset = "0xAAA5C0", VA = "0x180AAB1C0")]
			[CompilerGenerated]
			get
			{
				return default(long);
			}
			[Cpp2IlInjected.Token(Token = "0x6000502")]
			[Cpp2IlInjected.Address(RVA = "0xB30430", Offset = "0xB2F830", VA = "0x180B30430")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700024E")]
		public KeepsakeRoomType Type
		{
			[Cpp2IlInjected.Token(Token = "0x6000503")]
			[Cpp2IlInjected.Address(RVA = "0xAAB1A0", Offset = "0xAAA5A0", VA = "0x180AAB1A0")]
			[CompilerGenerated]
			get
			{
				return default(KeepsakeRoomType);
			}
			[Cpp2IlInjected.Token(Token = "0x6000504")]
			[Cpp2IlInjected.Address(RVA = "0xAAB1B0", Offset = "0xAAA5B0", VA = "0x180AAB1B0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700024F")]
		public int Order
		{
			[Cpp2IlInjected.Token(Token = "0x6000505")]
			[Cpp2IlInjected.Address(RVA = "0xC4E8F0", Offset = "0xC4DCF0", VA = "0x180C4E8F0")]
			[CompilerGenerated]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x6000506")]
			[Cpp2IlInjected.Address(RVA = "0x1ACB200", Offset = "0x1ACA600", VA = "0x181ACB200")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60004FB")]
		[Cpp2IlInjected.Address(RVA = "0xAAC8E0", Offset = "0xAABCE0", VA = "0x180AAC8E0")]
		public KeepsakeRoomDTO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004FC")]
		[Cpp2IlInjected.Address(RVA = "0x7719B70", Offset = "0x7718F70", VA = "0x187719B70")]
		public KeepsakeRoomDTO(long keepsakeRoomId = 0L, long roomId = 0L, long keepsakeRoomListId = 0L, KeepsakeRoomType type = KeepsakeRoomType.Standard, int order = 0)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000B4")]
	[Utf8JsonSerializable]
	public class ProgressionEventRewardDTO
	{
		[Cpp2IlInjected.Token(Token = "0x17000250")]
		public long ProgressionEventRewardId
		{
			[Cpp2IlInjected.Token(Token = "0x6000507")]
			[Cpp2IlInjected.Address(RVA = "0xAA5FB0", Offset = "0xAA53B0", VA = "0x180AA5FB0")]
			[CompilerGenerated]
			get
			{
				return default(long);
			}
			[Cpp2IlInjected.Token(Token = "0x6000508")]
			[Cpp2IlInjected.Address(RVA = "0xB96550", Offset = "0xB95950", VA = "0x180B96550")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000251")]
		public string ImageName
		{
			[Cpp2IlInjected.Token(Token = "0x6000509")]
			[Cpp2IlInjected.Address(RVA = "0xAAA880", Offset = "0xAA9C80", VA = "0x180AAA880")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600050A")]
			[Cpp2IlInjected.Address(RVA = "0xAAA120", Offset = "0xAA9520", VA = "0x180AAA120")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000252")]
		public int Xp
		{
			[Cpp2IlInjected.Token(Token = "0x600050B")]
			[Cpp2IlInjected.Address(RVA = "0xAB5660", Offset = "0xAB4A60", VA = "0x180AB5660")]
			[CompilerGenerated]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x600050C")]
			[Cpp2IlInjected.Address(RVA = "0xB07AB0", Offset = "0xB06EB0", VA = "0x180B07AB0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000253")]
		public int RewardIndex
		{
			[Cpp2IlInjected.Token(Token = "0x600050D")]
			[Cpp2IlInjected.Address(RVA = "0xACC3D0", Offset = "0xACB7D0", VA = "0x180ACC3D0")]
			[CompilerGenerated]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x600050E")]
			[Cpp2IlInjected.Address(RVA = "0xBE18B0", Offset = "0xBE0CB0", VA = "0x180BE18B0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000254")]
		public bool IsBonus
		{
			[Cpp2IlInjected.Token(Token = "0x600050F")]
			[Cpp2IlInjected.Address(RVA = "0xC75520", Offset = "0xC74920", VA = "0x180C75520")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000510")]
			[Cpp2IlInjected.Address(RVA = "0xC75550", Offset = "0xC74950", VA = "0x180C75550")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000255")]
		public bool IsRRPlusExclusive
		{
			[Cpp2IlInjected.Token(Token = "0x6000511")]
			[Cpp2IlInjected.Address(RVA = "0xC75540", Offset = "0xC74940", VA = "0x180C75540")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000512")]
			[Cpp2IlInjected.Address(RVA = "0xC75530", Offset = "0xC74930", VA = "0x180C75530")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000256")]
		public int? MaxGlobalCollections
		{
			[Cpp2IlInjected.Token(Token = "0x6000513")]
			[Cpp2IlInjected.Address(RVA = "0x10D2A70", Offset = "0x10D1E70", VA = "0x1810D2A70")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000514")]
			[Cpp2IlInjected.Address(RVA = "0x10D2AA0", Offset = "0x10D1EA0", VA = "0x1810D2AA0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000515")]
		[Cpp2IlInjected.Address(RVA = "0xAAC8E0", Offset = "0xAABCE0", VA = "0x180AAC8E0")]
		public ProgressionEventRewardDTO()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000B5")]
	[Utf8JsonSerializable]
	public class ProgressionEventPurchasableXpBoostDTO
	{
		[Cpp2IlInjected.Token(Token = "0x17000257")]
		public Guid ProgressionEventPurchasableXpBoostId
		{
			[Cpp2IlInjected.Token(Token = "0x6000516")]
			[Cpp2IlInjected.Address(RVA = "0xBAF500", Offset = "0xBAE900", VA = "0x180BAF500")]
			[CompilerGenerated]
			get
			{
				return default(Guid);
			}
			[Cpp2IlInjected.Token(Token = "0x6000517")]
			[Cpp2IlInjected.Address(RVA = "0xBAF520", Offset = "0xBAE920", VA = "0x180BAF520")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000258")]
		public int Cost
		{
			[Cpp2IlInjected.Token(Token = "0x6000518")]
			[Cpp2IlInjected.Address(RVA = "0xAB5660", Offset = "0xAB4A60", VA = "0x180AB5660")]
			[CompilerGenerated]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x6000519")]
			[Cpp2IlInjected.Address(RVA = "0xB07AB0", Offset = "0xB06EB0", VA = "0x180B07AB0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000259")]
		public int XpMultiplier
		{
			[Cpp2IlInjected.Token(Token = "0x600051A")]
			[Cpp2IlInjected.Address(RVA = "0xACC3D0", Offset = "0xACB7D0", VA = "0x180ACC3D0")]
			[CompilerGenerated]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x600051B")]
			[Cpp2IlInjected.Address(RVA = "0xBE18B0", Offset = "0xBE0CB0", VA = "0x180BE18B0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700025A")]
		public int XpCap
		{
			[Cpp2IlInjected.Token(Token = "0x600051C")]
			[Cpp2IlInjected.Address(RVA = "0xAAB1A0", Offset = "0xAAA5A0", VA = "0x180AAB1A0")]
			[CompilerGenerated]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x600051D")]
			[Cpp2IlInjected.Address(RVA = "0xAAB1B0", Offset = "0xAAA5B0", VA = "0x180AAB1B0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700025B")]
		public long LookbackDurationTicks
		{
			[Cpp2IlInjected.Token(Token = "0x600051E")]
			[Cpp2IlInjected.Address(RVA = "0xAAA140", Offset = "0xAA9540", VA = "0x180AAA140")]
			[CompilerGenerated]
			get
			{
				return default(long);
			}
			[Cpp2IlInjected.Token(Token = "0x600051F")]
			[Cpp2IlInjected.Address(RVA = "0xAAA860", Offset = "0xAA9C60", VA = "0x180AAA860")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700025C")]
		public long CooldownDurationTicks
		{
			[Cpp2IlInjected.Token(Token = "0x6000520")]
			[Cpp2IlInjected.Address(RVA = "0xAAA030", Offset = "0xAA9430", VA = "0x180AAA030")]
			[CompilerGenerated]
			get
			{
				return default(long);
			}
			[Cpp2IlInjected.Token(Token = "0x6000521")]
			[Cpp2IlInjected.Address(RVA = "0xAAF810", Offset = "0xAAEC10", VA = "0x180AAF810")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700025D")]
		public CurrencyType CurrencyType
		{
			[Cpp2IlInjected.Token(Token = "0x6000522")]
			[Cpp2IlInjected.Address(RVA = "0xAC1F70", Offset = "0xAC1370", VA = "0x180AC1F70")]
			[CompilerGenerated]
			get
			{
				return default(CurrencyType);
			}
			[Cpp2IlInjected.Token(Token = "0x6000523")]
			[Cpp2IlInjected.Address(RVA = "0xBDCB60", Offset = "0xBDBF60", VA = "0x180BDCB60")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000524")]
		[Cpp2IlInjected.Address(RVA = "0x771A7E0", Offset = "0x7719BE0", VA = "0x18771A7E0")]
		public ProgressionEventPurchasableXpBoostDTO()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000B6")]
	public enum KeepsakeRoomType
	{
		[Cpp2IlInjected.Token(Token = "0x40002BC")]
		Standard,
		[Cpp2IlInjected.Token(Token = "0x40002BD")]
		Premium
	}
	[Cpp2IlInjected.Token(Token = "0x20000B7")]
	public enum KeepsakeCategory
	{
		[Cpp2IlInjected.Token(Token = "0x40002BF")]
		Explore = 0,
		[Cpp2IlInjected.Token(Token = "0x40002C0")]
		GreenPowerCore = 1,
		[Cpp2IlInjected.Token(Token = "0x40002C1")]
		Present = 2,
		[Cpp2IlInjected.Token(Token = "0x40002C2")]
		PurplePowerCore = 3,
		[Cpp2IlInjected.Token(Token = "0x40002C3")]
		UnnamedKeepsakeNumber1 = 4,
		[Cpp2IlInjected.Token(Token = "0x40002C4")]
		UnnamedKeepsakeNumber2 = 5,
		[Cpp2IlInjected.Token(Token = "0x40002C5")]
		UnnamedKeepsakeNumber3 = 6,
		[Cpp2IlInjected.Token(Token = "0x40002C6")]
		UnnamedKeepsakeNumber4 = 7,
		[Cpp2IlInjected.Token(Token = "0x40002C7")]
		UnnamedKeepsakeNumber5 = 8,
		[Cpp2IlInjected.Token(Token = "0x40002C8")]
		_Test = 1000
	}
	[Cpp2IlInjected.Token(Token = "0x20000B8")]
	public enum ProgressionEventLimitedRewardCollectionState
	{
		[Cpp2IlInjected.Token(Token = "0x40002CA")]
		NotEarned,
		[Cpp2IlInjected.Token(Token = "0x40002CB")]
		Earned,
		[Cpp2IlInjected.Token(Token = "0x40002CC")]
		Collected,
		[Cpp2IlInjected.Token(Token = "0x40002CD")]
		CannotEarn
	}
	[Cpp2IlInjected.Token(Token = "0x20000B9")]
	[Utf8JsonSerializable]
	public class PurchasableXpBoostActivationDTO
	{
		[Cpp2IlInjected.Token(Token = "0x1700025E")]
		public long PurchasableXpBoostLedgerEntryId
		{
			[Cpp2IlInjected.Token(Token = "0x6000525")]
			[Cpp2IlInjected.Address(RVA = "0xAA5FB0", Offset = "0xAA53B0", VA = "0x180AA5FB0")]
			[CompilerGenerated]
			get
			{
				return default(long);
			}
			[Cpp2IlInjected.Token(Token = "0x6000526")]
			[Cpp2IlInjected.Address(RVA = "0xB96550", Offset = "0xB95950", VA = "0x180B96550")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700025F")]
		public Guid PurchasableXpBoostId
		{
			[Cpp2IlInjected.Token(Token = "0x6000527")]
			[Cpp2IlInjected.Address(RVA = "0xC66740", Offset = "0xC65B40", VA = "0x180C66740")]
			[CompilerGenerated]
			get
			{
				return default(Guid);
			}
			[Cpp2IlInjected.Token(Token = "0x6000528")]
			[Cpp2IlInjected.Address(RVA = "0xC66840", Offset = "0xC65C40", VA = "0x180C66840")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000260")]
		public float XpMultiplier
		{
			[Cpp2IlInjected.Token(Token = "0x6000529")]
			[Cpp2IlInjected.Address(RVA = "0xDBC5E0", Offset = "0xDBB9E0", VA = "0x180DBC5E0")]
			[CompilerGenerated]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x600052A")]
			[Cpp2IlInjected.Address(RVA = "0x1104310", Offset = "0x1103710", VA = "0x181104310")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000261")]
		public DateTime StartTime
		{
			[Cpp2IlInjected.Token(Token = "0x600052B")]
			[Cpp2IlInjected.Address(RVA = "0xAAA140", Offset = "0xAA9540", VA = "0x180AAA140")]
			[CompilerGenerated]
			get
			{
				return default(DateTime);
			}
			[Cpp2IlInjected.Token(Token = "0x600052C")]
			[Cpp2IlInjected.Address(RVA = "0xAAA860", Offset = "0xAA9C60", VA = "0x180AAA860")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000262")]
		public DateTime EndTime
		{
			[Cpp2IlInjected.Token(Token = "0x600052D")]
			[Cpp2IlInjected.Address(RVA = "0xAAA030", Offset = "0xAA9430", VA = "0x180AAA030")]
			[CompilerGenerated]
			get
			{
				return default(DateTime);
			}
			[Cpp2IlInjected.Token(Token = "0x600052E")]
			[Cpp2IlInjected.Address(RVA = "0xAAF810", Offset = "0xAAEC10", VA = "0x180AAF810")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600052F")]
		[Cpp2IlInjected.Address(RVA = "0xAAC8E0", Offset = "0xAABCE0", VA = "0x180AAC8E0")]
		public PurchasableXpBoostActivationDTO()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000BA")]
	[Utf8JsonSerializableGenericSpecialization]
	public class LFRLUVFRZSO : PPCJEJRUUPJ<PurchasableXpBoostActivationDTO>
	{
		[Cpp2IlInjected.Token(Token = "0x6000530")]
		[Cpp2IlInjected.Address(RVA = "0x7719D60", Offset = "0x7719160", VA = "0x187719D60")]
		public LFRLUVFRZSO()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000BB")]
	[Utf8JsonSerializable]
	public class RefereeFileReferenceDTO
	{
		[Cpp2IlInjected.Token(Token = "0x17000263")]
		public string Filename
		{
			[Cpp2IlInjected.Token(Token = "0x6000531")]
			[Cpp2IlInjected.Address(RVA = "0xAA5FB0", Offset = "0xAA53B0", VA = "0x180AA5FB0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000532")]
			[Cpp2IlInjected.Address(RVA = "0xAA5FC0", Offset = "0xAA53C0", VA = "0x180AA5FC0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000264")]
		public string? Hash
		{
			[Cpp2IlInjected.Token(Token = "0x6000533")]
			[Cpp2IlInjected.Address(RVA = "0xAAA880", Offset = "0xAA9C80", VA = "0x180AAA880")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000534")]
			[Cpp2IlInjected.Address(RVA = "0xAAA120", Offset = "0xAA9520", VA = "0x180AAA120")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000535")]
		[Cpp2IlInjected.Address(RVA = "0xAAC8E0", Offset = "0xAABCE0", VA = "0x180AAC8E0")]
		public RefereeFileReferenceDTO()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000BC")]
	public interface NRWZBJOAKFL
	{
		[Cpp2IlInjected.Token(Token = "0x17000265")]
		bool Success
		{
			[Cpp2IlInjected.Token(Token = "0x6000536")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000266")]
		string? Error
		{
			[Cpp2IlInjected.Token(Token = "0x6000537")]
			[Cpp2IlInjected.Address(Slot = "1")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000267")]
		string? ErrorId
		{
			[Cpp2IlInjected.Token(Token = "0x6000538")]
			[Cpp2IlInjected.Address(Slot = "2")]
			get;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000BD")]
	public interface LSFOAQTOQKW<a> : NRWZBJOAKFL
	{
		[Cpp2IlInjected.Token(Token = "0x17000268")]
		a Value
		{
			[Cpp2IlInjected.Token(Token = "0x6000539")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000BE")]
	public static class KCWCWQQGOEA
	{
		[Cpp2IlInjected.Token(Token = "0x600053A")]
		[Cpp2IlInjected.Address(RVA = "0x3712AB0", Offset = "0x3711EB0", VA = "0x183712AB0")]
		public static LSFOAQTOQKW<T> Transform<T, U>(this LSFOAQTOQKW<U> result, Func<U, T> transformFunc)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000BF")]
	public struct RecNetResultUnserialized<T> : LSFOAQTOQKW<T>, NRWZBJOAKFL
	{
		[Cpp2IlInjected.Token(Token = "0x17000269")]
		public bool Success
		{
			[Cpp2IlInjected.Token(Token = "0x600053B")]
			[Cpp2IlInjected.Address(RVA = "0xDAF5E0", Offset = "0xDAE9E0", VA = "0x180DAF5E0", Slot = "5")]
			[CompilerGenerated]
			readonly get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x600053C")]
			[Cpp2IlInjected.Address(RVA = "0x2AC7A40", Offset = "0x2AC6E40", VA = "0x182AC7A40")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700026A")]
		public string? Error
		{
			[Cpp2IlInjected.Token(Token = "0x600053D")]
			[Cpp2IlInjected.Address(RVA = "0xC1E140", Offset = "0xC1D540", VA = "0x180C1E140", Slot = "6")]
			[CompilerGenerated]
			readonly get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600053E")]
			[Cpp2IlInjected.Address(RVA = "0xC1E150", Offset = "0xC1D550", VA = "0x180C1E150")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700026B")]
		public string? ErrorId
		{
			[Cpp2IlInjected.Token(Token = "0x600053F")]
			[Cpp2IlInjected.Address(RVA = "0xAA5FB0", Offset = "0xAA53B0", VA = "0x180AA5FB0", Slot = "7")]
			[CompilerGenerated]
			readonly get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000540")]
			[Cpp2IlInjected.Address(RVA = "0xAA5FC0", Offset = "0xAA53C0", VA = "0x180AA5FC0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700026C")]
		public T Value
		{
			[Cpp2IlInjected.Token(Token = "0x6000541")]
			[Cpp2IlInjected.Address(RVA = "0xAAA880", Offset = "0xAA9C80", VA = "0x180AAA880", Slot = "4")]
			[CompilerGenerated]
			readonly get
			{
				return (T)null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000542")]
			[Cpp2IlInjected.Address(RVA = "0xAAA120", Offset = "0xAA9520", VA = "0x180AAA120")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000543")]
		[Cpp2IlInjected.Address(RVA = "0x5D37640", Offset = "0x5D36A40", VA = "0x185D37640")]
		public static RecNetResultUnserialized<T> Ok(T value)
		{
			return default(RecNetResultUnserialized<T>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000544")]
		[Cpp2IlInjected.Address(RVA = "0x5D37050", Offset = "0x5D36450", VA = "0x185D37050")]
		public static RecNetResultUnserialized<T> Fail(string error, string errorId = "")
		{
			return default(RecNetResultUnserialized<T>);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000C0")]
	[Utf8JsonSerializable]
	public class RecNetResult : NRWZBJOAKFL
	{
		[Cpp2IlInjected.Token(Token = "0x1700026D")]
		public bool Success
		{
			[Cpp2IlInjected.Token(Token = "0x6000545")]
			[Cpp2IlInjected.Address(RVA = "0xAF8E00", Offset = "0xAF8200", VA = "0x180AF8E00", Slot = "4")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000546")]
			[Cpp2IlInjected.Address(RVA = "0xB22470", Offset = "0xB21870", VA = "0x180B22470")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700026E")]
		public string? Error
		{
			[Cpp2IlInjected.Token(Token = "0x6000547")]
			[Cpp2IlInjected.Address(RVA = "0xAAA880", Offset = "0xAA9C80", VA = "0x180AAA880", Slot = "5")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000548")]
			[Cpp2IlInjected.Address(RVA = "0xAAA120", Offset = "0xAA9520", VA = "0x180AAA120")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700026F")]
		[DataMember(Name = "error_id")]
		public string? ErrorId
		{
			[Cpp2IlInjected.Token(Token = "0x6000549")]
			[Cpp2IlInjected.Address(RVA = "0xAAB1C0", Offset = "0xAAA5C0", VA = "0x180AAB1C0", Slot = "6")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600054A")]
			[Cpp2IlInjected.Address(RVA = "0xAA67C0", Offset = "0xAA5BC0", VA = "0x180AA67C0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600054B")]
		[Cpp2IlInjected.Address(RVA = "0x771A9E0", Offset = "0x7719DE0", VA = "0x18771A9E0")]
		public static RecNetResult Ok()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600054C")]
		[Cpp2IlInjected.Address(RVA = "0x771A950", Offset = "0x7719D50", VA = "0x18771A950")]
		public static RecNetResult Fail(string error, string errorId = "")
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600054D")]
		[Cpp2IlInjected.Address(RVA = "0xAAC8E0", Offset = "0xAABCE0", VA = "0x180AAC8E0")]
		public RecNetResult()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000C1")]
	[Utf8JsonSerializableGeneric]
	public abstract class RecNetResult<T> : RecNetResult, LSFOAQTOQKW<T>, NRWZBJOAKFL
	{
		[Cpp2IlInjected.Token(Token = "0x17000270")]
		public T Value
		{
			[Cpp2IlInjected.Token(Token = "0x600054E")]
			[Cpp2IlInjected.Address(RVA = "0xC75520", Offset = "0xC74920", VA = "0x180C75520", Slot = "7")]
			[CompilerGenerated]
			get
			{
				return (T)null;
			}
			[Cpp2IlInjected.Token(Token = "0x600054F")]
			[Cpp2IlInjected.Address(RVA = "0xC75550", Offset = "0xC74950", VA = "0x180C75550")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000550")]
		[Cpp2IlInjected.Address(RVA = "0xACE190", Offset = "0xACD590", VA = "0x180ACE190")]
		protected RecNetResult()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000C2")]
	[Utf8JsonSerializableGeneric]
	public class RecNetResultPrimitive<T> : RecNetResult<T>
	{
		[Cpp2IlInjected.Token(Token = "0x6000551")]
		[Cpp2IlInjected.Address(RVA = "0x5D36FD0", Offset = "0x5D363D0", VA = "0x185D36FD0")]
		private static void CJMXZEAACAD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000552")]
		[Cpp2IlInjected.Address(RVA = "0xACE190", Offset = "0xACD590", VA = "0x180ACE190")]
		public RecNetResultPrimitive()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000C3")]
	[Utf8JsonSerializableGeneric]
	public class RecNetResultObject<T> : RecNetResult<T>, DURPPUIUDDT where T : class
	{
		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x20000C4")]
		[CompilerGenerated]
		private struct <OnDeserializedAsync>d__0 : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40002DD")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40002DE")]
			public AsyncTaskMethodBuilder <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40002DF")]
			public RecNetResultObject<T> <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40002E0")]
			private ZTDEQBSEMSX <obj1>5__2;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40002E1")]
			private object <>u__1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40002E2")]
			private ConfiguredTaskAwaitable.ConfiguredTaskAwaiter <>u__2;

			[Cpp2IlInjected.Token(Token = "0x6000557")]
			[Cpp2IlInjected.Address(RVA = "0x50B46E0", Offset = "0x50B3AE0", VA = "0x1850B46E0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000558")]
			[Cpp2IlInjected.Address(RVA = "0x50B4AE0", Offset = "0x50B3EE0", VA = "0x1850B4AE0", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000553")]
		[Cpp2IlInjected.Address(RVA = "0x5D36E10", Offset = "0x5D36210", VA = "0x185D36E10", Slot = "8")]
		[AsyncStateMachine(typeof(RecNetResultObject<>.<OnDeserializedAsync>d__0))]
		public Task NLICNVNCYRU()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000554")]
		[Cpp2IlInjected.Address(RVA = "0x5D36F00", Offset = "0x5D36300", VA = "0x185D36F00")]
		public static RecNetResultObject<T> Ok(T value)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000555")]
		[Cpp2IlInjected.Address(RVA = "0x5D36D30", Offset = "0x5D36130", VA = "0x185D36D30")]
		public new static RecNetResultObject<T> Fail(string error, string errorId = "")
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000556")]
		[Cpp2IlInjected.Address(RVA = "0xACE190", Offset = "0xACD590", VA = "0x180ACE190")]
		public RecNetResultObject()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000C5")]
	[Utf8JsonSerializableGeneric]
	public class RecNetResultListPrimitive<T> : RecNetResult<List<T>>
	{
		[Cpp2IlInjected.Token(Token = "0x6000559")]
		[Cpp2IlInjected.Address(RVA = "0x40C2660", Offset = "0x40C1A60", VA = "0x1840C2660")]
		public RecNetResultListPrimitive()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000C6")]
	[Utf8JsonSerializableGeneric]
	public class RecNetResultListObject<T> : RecNetResult<List<T>>, DURPPUIUDDT where T : class
	{
		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x20000C7")]
		[CompilerGenerated]
		private struct <OnDeserializedAsync>d__2 : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40002E3")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40002E4")]
			public AsyncTaskMethodBuilder <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40002E5")]
			public RecNetResultListObject<T> <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40002E6")]
			private IEnumerable<ZTDEQBSEMSX> <list1>5__2;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40002E7")]
			private object <>u__1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40002E8")]
			private ConfiguredTaskAwaitable.ConfiguredTaskAwaiter <>u__2;

			[Cpp2IlInjected.Token(Token = "0x600055E")]
			[Cpp2IlInjected.Address(RVA = "0x50B4B40", Offset = "0x50B3F40", VA = "0x1850B4B40", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600055F")]
			[Cpp2IlInjected.Address(RVA = "0x50B4F30", Offset = "0x50B4330", VA = "0x1850B4F30", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600055A")]
		[Cpp2IlInjected.Address(RVA = "0x5D36C70", Offset = "0x5D36070", VA = "0x185D36C70")]
		public static RecNetResultListObject<T> Ok(List<T> value)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600055B")]
		[Cpp2IlInjected.Address(RVA = "0x5D36AA0", Offset = "0x5D35EA0", VA = "0x185D36AA0")]
		public new static RecNetResultListObject<T> Fail(string error, string errorId = "")
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600055C")]
		[Cpp2IlInjected.Address(RVA = "0x5D36B80", Offset = "0x5D35F80", VA = "0x185D36B80", Slot = "8")]
		[AsyncStateMachine(typeof(RecNetResultListObject<>.<OnDeserializedAsync>d__2))]
		public Task NLICNVNCYRU()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600055D")]
		[Cpp2IlInjected.Address(RVA = "0xACE190", Offset = "0xACD590", VA = "0x180ACE190")]
		public RecNetResultListObject()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000C8")]
	public enum Service
	{
		[Cpp2IlInjected.Token(Token = "0x40002EA")]
		AI,
		[Cpp2IlInjected.Token(Token = "0x40002EB")]
		Auth,
		[Cpp2IlInjected.Token(Token = "0x40002EC")]
		API,
		[Cpp2IlInjected.Token(Token = "0x40002ED")]
		Commerce,
		[Cpp2IlInjected.Token(Token = "0x40002EE")]
		Matchmaking,
		[Cpp2IlInjected.Token(Token = "0x40002EF")]
		Notifications,
		[Cpp2IlInjected.Token(Token = "0x40002F0")]
		Images,
		[Cpp2IlInjected.Token(Token = "0x40002F1")]
		CDN,
		[Cpp2IlInjected.Token(Token = "0x40002F2")]
		Storage,
		[Cpp2IlInjected.Token(Token = "0x40002F3")]
		Chat,
		[Cpp2IlInjected.Token(Token = "0x40002F4")]
		Leaderboard,
		[Cpp2IlInjected.Token(Token = "0x40002F5")]
		Accounts,
		[Cpp2IlInjected.Token(Token = "0x40002F6")]
		Link,
		[Cpp2IlInjected.Token(Token = "0x40002F7")]
		Lists,
		[Cpp2IlInjected.Token(Token = "0x40002F8")]
		RoomComments,
		[Cpp2IlInjected.Token(Token = "0x40002F9")]
		Clubs,
		[Cpp2IlInjected.Token(Token = "0x40002FA")]
		Rooms,
		[Cpp2IlInjected.Token(Token = "0x40002FB")]
		PlatformNotifications,
		[Cpp2IlInjected.Token(Token = "0x40002FC")]
		Moderation,
		[Cpp2IlInjected.Token(Token = "0x40002FD")]
		DataCollection,
		[Cpp2IlInjected.Token(Token = "0x40002FE")]
		BugReporting,
		[Cpp2IlInjected.Token(Token = "0x40002FF")]
		Discovery,
		[Cpp2IlInjected.Token(Token = "0x4000300")]
		PlayerSettings,
		[Cpp2IlInjected.Token(Token = "0x4000301")]
		Studio,
		[Cpp2IlInjected.Token(Token = "0x4000302")]
		GameLogs,
		[Cpp2IlInjected.Token(Token = "0x4000303")]
		Strings,
		[Cpp2IlInjected.Token(Token = "0x4000304")]
		StringsCDN,
		[Cpp2IlInjected.Token(Token = "0x4000305")]
		WWW,
		[Cpp2IlInjected.Token(Token = "0x4000306")]
		Econ,
		[Cpp2IlInjected.Token(Token = "0x4000307")]
		Data,
		[Cpp2IlInjected.Token(Token = "0x4000308")]
		Cards
	}
	[Cpp2IlInjected.Token(Token = "0x20000C9")]
	public static class XPFJTRWIWDV
	{
		[Cpp2IlInjected.Token(Token = "0x6000560")]
		[Cpp2IlInjected.Address(RVA = "0x7720640", Offset = "0x771FA40", VA = "0x187720640")]
		public static bool GWZHGHDZKMH(this Service a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000561")]
		[Cpp2IlInjected.Address(RVA = "0x7720640", Offset = "0x771FA40", VA = "0x187720640")]
		public static bool QHZFDBUPOZD(this Service a)
		{
			return default(bool);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000CA")]
	public enum CurrencyType
	{
		[Cpp2IlInjected.Token(Token = "0x400030A")]
		Invalid = 0,
		[Cpp2IlInjected.Token(Token = "0x400030B")]
		LaserTagTickets = 1,
		[Cpp2IlInjected.Token(Token = "0x400030C")]
		RecCenterTokens = 2,
		[Cpp2IlInjected.Token(Token = "0x400030D")]
		LostSkullsGold = 100,
		[Cpp2IlInjected.Token(Token = "0x400030E")]
		DraculaSilver = 101,
		[Cpp2IlInjected.Token(Token = "0x400030F")]
		RecRoyale_Season1 = 200,
		[Cpp2IlInjected.Token(Token = "0x4000310")]
		RoomCurrency = 300,
		[Cpp2IlInjected.Token(Token = "0x4000311")]
		RoomInventoryItem = 301,
		[Cpp2IlInjected.Token(Token = "0x4000312")]
		ProgressionEvent = 400,
		[Cpp2IlInjected.Token(Token = "0x4000313")]
		RoomieCredits = 500,
		[Cpp2IlInjected.Token(Token = "0x4000314")]
		PaintballPaint = 600
	}
	[Cpp2IlInjected.Token(Token = "0x20000CB")]
	public enum StorefrontBalanceType
	{
		[Cpp2IlInjected.Token(Token = "0x4000316")]
		NonPurchasedNotUsableInP2P = -2,
		[Cpp2IlInjected.Token(Token = "0x4000317")]
		NonPurchasedDefault = -1,
		[Cpp2IlInjected.Token(Token = "0x4000318")]
		SteamPurchased = 0,
		[Cpp2IlInjected.Token(Token = "0x4000319")]
		OculusPurchased = 1,
		[Cpp2IlInjected.Token(Token = "0x400031A")]
		PlayStationPurchased = 2,
		[Cpp2IlInjected.Token(Token = "0x400031B")]
		MicrosoftPurchased = 3,
		[Cpp2IlInjected.Token(Token = "0x400031C")]
		IOSPurchased = 5,
		[Cpp2IlInjected.Token(Token = "0x400031D")]
		GooglePlayPurchased = 6,
		[Cpp2IlInjected.Token(Token = "0x400031E")]
		PicoPurchased = 8,
		[Cpp2IlInjected.Token(Token = "0x400031F")]
		RecNetPurchased = 4,
		[Cpp2IlInjected.Token(Token = "0x4000320")]
		SwitchPurchased = 9,
		[Cpp2IlInjected.Token(Token = "0x4000321")]
		[Obsolete("Subscription benefits for PS4 players were awarded with this balance type. It is not transferrable to other platforms. Usable in P2P economy. We are using PlayStationPurchased instead now. -- bilal - 11/11/2020")]
		PlayStationNonPurchasedP2P = 100,
		[Cpp2IlInjected.Token(Token = "0x4000322")]
		[Obsolete("Subscription benefits for NON PS4 players were awarded with this balance type. We are using <PlatformType>Purchased instead now. -- bilal - 11/11/2020")]
		NonPlayStationNonPurchasedP2P = 101,
		[Cpp2IlInjected.Token(Token = "0x4000323")]
		NonPurchasedEarnedByP2P = 1000,
		[Cpp2IlInjected.Token(Token = "0x4000324")]
		NonPurchasedEarnedByP2Pv2 = 1001,
		[Cpp2IlInjected.Token(Token = "0x4000325")]
		RoomieEnergyPack = 1101
	}
	[Cpp2IlInjected.Token(Token = "0x20000CC")]
	public enum GiftContext
	{
		[Cpp2IlInjected.Token(Token = "0x4000327")]
		None = -1,
		[Cpp2IlInjected.Token(Token = "0x4000328")]
		Default = 0,
		[Cpp2IlInjected.Token(Token = "0x4000329")]
		First_Activity = 1,
		[Cpp2IlInjected.Token(Token = "0x400032A")]
		Game_Drop = 2,
		[Cpp2IlInjected.Token(Token = "0x400032B")]
		All_Daily_Challenges_Complete = 3,
		[Cpp2IlInjected.Token(Token = "0x400032C")]
		All_Weekly_Challenge_Complete = 4,
		[Cpp2IlInjected.Token(Token = "0x400032D")]
		Daily_Challenge_Complete = 5,
		[Cpp2IlInjected.Token(Token = "0x400032E")]
		Weekly_Challenge_Complete = 6,
		[Cpp2IlInjected.Token(Token = "0x400032F")]
		Unassigned_Equipment = 10,
		[Cpp2IlInjected.Token(Token = "0x4000330")]
		Unassigned_Avatar = 11,
		[Cpp2IlInjected.Token(Token = "0x4000331")]
		Unassigned_Consumable = 12,
		[Cpp2IlInjected.Token(Token = "0x4000332")]
		FB_Unassigned_Avatar = 13,
		[Cpp2IlInjected.Token(Token = "0x4000333")]
		Reacquisition = 20,
		[Cpp2IlInjected.Token(Token = "0x4000334")]
		Membership = 21,
		[Cpp2IlInjected.Token(Token = "0x4000335")]
		Day2Reengagement = 22,
		[Cpp2IlInjected.Token(Token = "0x4000336")]
		NUX_TokensAndDressUp = 30,
		[Cpp2IlInjected.Token(Token = "0x4000337")]
		NUX_Experiment1 = 31,
		[Cpp2IlInjected.Token(Token = "0x4000338")]
		NUX_Experiment2 = 32,
		[Cpp2IlInjected.Token(Token = "0x4000339")]
		NUX_Experiment3 = 33,
		[Cpp2IlInjected.Token(Token = "0x400033A")]
		NUX_Experiment4 = 34,
		[Cpp2IlInjected.Token(Token = "0x400033B")]
		NUX_Experiment5 = 35,
		[Cpp2IlInjected.Token(Token = "0x400033C")]
		GameRewards = 50,
		[Cpp2IlInjected.Token(Token = "0x400033D")]
		GameRewards_Tokens = 51,
		[Cpp2IlInjected.Token(Token = "0x400033E")]
		GameRewards_Tokens_Experiment_Override = 52,
		[Cpp2IlInjected.Token(Token = "0x400033F")]
		GameRewards_A = 53,
		[Cpp2IlInjected.Token(Token = "0x4000340")]
		GameRewards_B = 54,
		[Cpp2IlInjected.Token(Token = "0x4000341")]
		LevelUp = 100,
		[Cpp2IlInjected.Token(Token = "0x4000342")]
		Purchased_Gift_A = 500,
		[Cpp2IlInjected.Token(Token = "0x4000343")]
		Purchased_Gift_B = 501,
		[Cpp2IlInjected.Token(Token = "0x4000344")]
		Purchased_Gift_C = 502,
		[Cpp2IlInjected.Token(Token = "0x4000345")]
		Purchased_Gift_D = 503,
		[Cpp2IlInjected.Token(Token = "0x4000346")]
		Rectober = 600,
		[Cpp2IlInjected.Token(Token = "0x4000347")]
		Rectober_Trick = 601,
		[Cpp2IlInjected.Token(Token = "0x4000348")]
		Rectober_Treat = 602,
		[Cpp2IlInjected.Token(Token = "0x4000349")]
		Rectober_Treat_Consumable = 603,
		[Cpp2IlInjected.Token(Token = "0x400034A")]
		Rectober_Treat_Token = 604,
		[Cpp2IlInjected.Token(Token = "0x400034B")]
		Rectober_Gift = 605,
		[Cpp2IlInjected.Token(Token = "0x400034C")]
		Store_Limited_Time_Seasonal = 1000,
		[Cpp2IlInjected.Token(Token = "0x400034D")]
		Store_Limited_Time_Contest = 1001,
		[Cpp2IlInjected.Token(Token = "0x400034E")]
		Store_Limited_Time_Promotion = 1002,
		[Cpp2IlInjected.Token(Token = "0x400034F")]
		Store_Limited_Time_Recurring = 1003,
		[Cpp2IlInjected.Token(Token = "0x4000350")]
		Store_Limited_Time_Event = 1004,
		[Cpp2IlInjected.Token(Token = "0x4000351")]
		Store_Limited_Time_Contract = 1005,
		[Cpp2IlInjected.Token(Token = "0x4000352")]
		Store_Limited_Time_Free = 1006,
		[Cpp2IlInjected.Token(Token = "0x4000353")]
		Store_Members_Only = 1010,
		[Cpp2IlInjected.Token(Token = "0x4000354")]
		Store_Free = 1011,
		[Cpp2IlInjected.Token(Token = "0x4000355")]
		Store_Indefinitely_Locked = 1090,
		[Cpp2IlInjected.Token(Token = "0x4000356")]
		Deprecated = 1100,
		[Cpp2IlInjected.Token(Token = "0x4000357")]
		RecRoyale = 1200,
		[Cpp2IlInjected.Token(Token = "0x4000358")]
		Friendotron_Gift = 1300,
		[Cpp2IlInjected.Token(Token = "0x4000359")]
		BackpackGame = 1400,
		[Cpp2IlInjected.Token(Token = "0x400035A")]
		BackpackGame_HideAndSeek = 1401,
		[Cpp2IlInjected.Token(Token = "0x400035B")]
		DEPRECATED_Paintball_ClearCut = 2000,
		[Cpp2IlInjected.Token(Token = "0x400035C")]
		DEPRECATED_Paintball_Homestead = 2001,
		[Cpp2IlInjected.Token(Token = "0x400035D")]
		DEPRECATED_Paintball_Quarry = 2002,
		[Cpp2IlInjected.Token(Token = "0x400035E")]
		DEPRECATED_Paintball_River = 2003,
		[Cpp2IlInjected.Token(Token = "0x400035F")]
		DEPRECATED_Paintball_Dam = 2004,
		[Cpp2IlInjected.Token(Token = "0x4000360")]
		DEPRECATED_Paintball_DriveIn = 2005,
		[Cpp2IlInjected.Token(Token = "0x4000361")]
		Paintball_ClearCut = 2010,
		[Cpp2IlInjected.Token(Token = "0x4000362")]
		Paintball_Homestead = 2011,
		[Cpp2IlInjected.Token(Token = "0x4000363")]
		Paintball_Quarry = 2012,
		[Cpp2IlInjected.Token(Token = "0x4000364")]
		Paintball_River = 2013,
		[Cpp2IlInjected.Token(Token = "0x4000365")]
		Paintball_Dam = 2014,
		[Cpp2IlInjected.Token(Token = "0x4000366")]
		Paintball_DriveIn = 2015,
		[Cpp2IlInjected.Token(Token = "0x4000367")]
		Paintball_MerryMidway = 2016,
		[Cpp2IlInjected.Token(Token = "0x4000368")]
		DEPRECATED_Discgolf_Propulsion = 3000,
		[Cpp2IlInjected.Token(Token = "0x4000369")]
		DEPRECATED_Discgolf_Lake = 3001,
		[Cpp2IlInjected.Token(Token = "0x400036A")]
		Discgolf_Propulsion = 3010,
		[Cpp2IlInjected.Token(Token = "0x400036B")]
		Discgolf_Lake = 3011,
		[Cpp2IlInjected.Token(Token = "0x400036C")]
		Discgolf_Mode_CoopCatch = 3500,
		[Cpp2IlInjected.Token(Token = "0x400036D")]
		Quest_Goblin_A = 4000,
		[Cpp2IlInjected.Token(Token = "0x400036E")]
		Quest_Goblin_B = 4001,
		[Cpp2IlInjected.Token(Token = "0x400036F")]
		Quest_Goblin_C = 4002,
		[Cpp2IlInjected.Token(Token = "0x4000370")]
		Quest_Goblin_S = 4003,
		[Cpp2IlInjected.Token(Token = "0x4000371")]
		Quest_Goblin_Consumable = 4004,
		[Cpp2IlInjected.Token(Token = "0x4000372")]
		Quest_Cauldron_A = 4010,
		[Cpp2IlInjected.Token(Token = "0x4000373")]
		Quest_Cauldron_B = 4011,
		[Cpp2IlInjected.Token(Token = "0x4000374")]
		Quest_Cauldron_C = 4012,
		[Cpp2IlInjected.Token(Token = "0x4000375")]
		Quest_Cauldron_S = 4013,
		[Cpp2IlInjected.Token(Token = "0x4000376")]
		Quest_Cauldron_Consumable = 4014,
		[Cpp2IlInjected.Token(Token = "0x4000377")]
		Quest_Pirate1_A = 4100,
		[Cpp2IlInjected.Token(Token = "0x4000378")]
		Quest_Pirate1_B = 4101,
		[Cpp2IlInjected.Token(Token = "0x4000379")]
		Quest_Pirate1_C = 4102,
		[Cpp2IlInjected.Token(Token = "0x400037A")]
		Quest_Pirate1_S = 4103,
		[Cpp2IlInjected.Token(Token = "0x400037B")]
		Quest_Pirate1_X = 4104,
		[Cpp2IlInjected.Token(Token = "0x400037C")]
		Quest_Pirate1_Consumable = 4105,
		[Cpp2IlInjected.Token(Token = "0x400037D")]
		Quest_Dracula1_A = 4200,
		[Cpp2IlInjected.Token(Token = "0x400037E")]
		Quest_Dracula1_B = 4201,
		[Cpp2IlInjected.Token(Token = "0x400037F")]
		Quest_Dracula1_C = 4202,
		[Cpp2IlInjected.Token(Token = "0x4000380")]
		Quest_Dracula1_S = 4203,
		[Cpp2IlInjected.Token(Token = "0x4000381")]
		Quest_Dracula1_X = 4204,
		[Cpp2IlInjected.Token(Token = "0x4000382")]
		Quest_Dracula1_Consumable = 4205,
		[Cpp2IlInjected.Token(Token = "0x4000383")]
		Quest_Dracula1_SS = 4206,
		[Cpp2IlInjected.Token(Token = "0x4000384")]
		Quest_SciFi_A = 4500,
		[Cpp2IlInjected.Token(Token = "0x4000385")]
		Quest_SciFi_B = 4501,
		[Cpp2IlInjected.Token(Token = "0x4000386")]
		Quest_SciFi_C = 4502,
		[Cpp2IlInjected.Token(Token = "0x4000387")]
		Quest_SciFi_S = 4503,
		[Cpp2IlInjected.Token(Token = "0x4000388")]
		Quest_Scifi_Consumable = 4504,
		[Cpp2IlInjected.Token(Token = "0x4000389")]
		DEPRECATED_Charades = 5000,
		[Cpp2IlInjected.Token(Token = "0x400038A")]
		Charades = 5001,
		[Cpp2IlInjected.Token(Token = "0x400038B")]
		DEPRECATED_Soccer = 6000,
		[Cpp2IlInjected.Token(Token = "0x400038C")]
		Soccer = 6001,
		[Cpp2IlInjected.Token(Token = "0x400038D")]
		DEPRECATED_Paddleball = 7000,
		[Cpp2IlInjected.Token(Token = "0x400038E")]
		Paddleball = 7001,
		[Cpp2IlInjected.Token(Token = "0x400038F")]
		DEPRECATED_Dodgeball = 8000,
		[Cpp2IlInjected.Token(Token = "0x4000390")]
		Dodgeball = 8001,
		[Cpp2IlInjected.Token(Token = "0x4000391")]
		DEPRECATED_Lasertag = 9000,
		[Cpp2IlInjected.Token(Token = "0x4000392")]
		Lasertag = 9001,
		[Cpp2IlInjected.Token(Token = "0x4000393")]
		DEPRECATED_Bowling = 10000,
		[Cpp2IlInjected.Token(Token = "0x4000394")]
		Bowling = 10001,
		[Cpp2IlInjected.Token(Token = "0x4000395")]
		StuntRunner_TheMainEvent_A = 11000,
		[Cpp2IlInjected.Token(Token = "0x4000396")]
		StuntRunner_TheMainEvent_B = 11001,
		[Cpp2IlInjected.Token(Token = "0x4000397")]
		StuntRunner_TheMainEvent_C = 11002,
		[Cpp2IlInjected.Token(Token = "0x4000398")]
		StuntRunner_TheMainEvent_D = 11003,
		[Cpp2IlInjected.Token(Token = "0x4000399")]
		StuntRunner_TheMainEvent_S = 11004,
		[Cpp2IlInjected.Token(Token = "0x400039A")]
		StuntRunner_TheMainEvent_X = 11005,
		[Cpp2IlInjected.Token(Token = "0x400039B")]
		StuntRunner_TheMainEvent_Consumable = 11006,
		[Cpp2IlInjected.Token(Token = "0x400039C")]
		StuntRunner_TheMainEvent_SS = 11007,
		[Cpp2IlInjected.Token(Token = "0x400039D")]
		RecRally = 12000,
		[Cpp2IlInjected.Token(Token = "0x400039E")]
		Showdown_A = 12100,
		[Cpp2IlInjected.Token(Token = "0x400039F")]
		Showdown_B = 12101,
		[Cpp2IlInjected.Token(Token = "0x40003A0")]
		Showdown_C = 12102,
		[Cpp2IlInjected.Token(Token = "0x40003A1")]
		MyLittleMonsters = 12200,
		[Cpp2IlInjected.Token(Token = "0x40003A2")]
		RunTheBlock = 12300,
		[Cpp2IlInjected.Token(Token = "0x40003A3")]
		RROStorefront_ToBeNamed_2 = 12400,
		[Cpp2IlInjected.Token(Token = "0x40003A4")]
		ProgressionEvent = 13000,
		[Cpp2IlInjected.Token(Token = "0x40003A5")]
		TimedRewardTrack = 13100,
		[Cpp2IlInjected.Token(Token = "0x40003A6")]
		PaintballBattlePass = 13200,
		[Cpp2IlInjected.Token(Token = "0x40003A7")]
		PaintballBattlePass_Sprays_Common = 13201,
		[Cpp2IlInjected.Token(Token = "0x40003A8")]
		PaintballBattlePass_Sprays_Uncommon = 13202,
		[Cpp2IlInjected.Token(Token = "0x40003A9")]
		PaintballBattlePass_Sprays_Rare = 13203,
		[Cpp2IlInjected.Token(Token = "0x40003AA")]
		PaintballBattlePass_Sprays_Epic = 13204,
		[Cpp2IlInjected.Token(Token = "0x40003AB")]
		PaintballBattlePass_Sprays_Legendary = 13205,
		[Cpp2IlInjected.Token(Token = "0x40003AC")]
		Store_LaserTag = 100000,
		[Cpp2IlInjected.Token(Token = "0x40003AD")]
		Store_RecCenter = 100010,
		[Cpp2IlInjected.Token(Token = "0x40003AE")]
		Consumable = 110000,
		[Cpp2IlInjected.Token(Token = "0x40003AF")]
		Token = 110100,
		[Cpp2IlInjected.Token(Token = "0x40003B0")]
		Punchcard_Challenge_Complete = 110200,
		[Cpp2IlInjected.Token(Token = "0x40003B1")]
		All_Punchcard_Challenges_Complete = 110201,
		[Cpp2IlInjected.Token(Token = "0x40003B2")]
		New_Player_Checklist_Item_Complete = 110300,
		[Cpp2IlInjected.Token(Token = "0x40003B3")]
		ShoppingBagPromotions = 110400,
		[Cpp2IlInjected.Token(Token = "0x40003B4")]
		Commerce_Purchase = 200000,
		[Cpp2IlInjected.Token(Token = "0x40003B5")]
		Gift_Card_Redemption = 210000
	}
	[Cpp2IlInjected.Token(Token = "0x20000CD")]
	public enum GiftRarity
	{
		[Cpp2IlInjected.Token(Token = "0x40003B7")]
		None = -1,
		[Cpp2IlInjected.Token(Token = "0x40003B8")]
		Common = 0,
		[Cpp2IlInjected.Token(Token = "0x40003B9")]
		Uncommon = 10,
		[Cpp2IlInjected.Token(Token = "0x40003BA")]
		Rare = 20,
		[Cpp2IlInjected.Token(Token = "0x40003BB")]
		Epic = 30,
		[Cpp2IlInjected.Token(Token = "0x40003BC")]
		Legendary = 50
	}
	[Cpp2IlInjected.Token(Token = "0x20000CE")]
	public enum UpdateResponseTypes
	{
		[Cpp2IlInjected.Token(Token = "0x40003BE")]
		OK,
		[Cpp2IlInjected.Token(Token = "0x40003BF")]
		TooManyRequests,
		[Cpp2IlInjected.Token(Token = "0x40003C0")]
		NotEnoughCredit,
		[Cpp2IlInjected.Token(Token = "0x40003C1")]
		AlreadyOwned,
		[Cpp2IlInjected.Token(Token = "0x40003C2")]
		NoItemAvailable,
		[Cpp2IlInjected.Token(Token = "0x40003C3")]
		CouponNotApplicable,
		[Cpp2IlInjected.Token(Token = "0x40003C4")]
		RequestedPriceDoesNotMatch,
		[Cpp2IlInjected.Token(Token = "0x40003C5")]
		RequestedAmountNotAllowed,
		[Cpp2IlInjected.Token(Token = "0x40003C6")]
		PlayerNotEligible,
		[Cpp2IlInjected.Token(Token = "0x40003C7")]
		RequestCannotBeRefunded,
		[Cpp2IlInjected.Token(Token = "0x40003C8")]
		PlayerNotApproved
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x20000CF")]
	[Utf8JsonSerializable]
	public class BalanceResponseDTO
	{
		[Cpp2IlInjected.Token(Token = "0x17000271")]
		public long Balance
		{
			[Cpp2IlInjected.Token(Token = "0x6000562")]
			[Cpp2IlInjected.Address(RVA = "0xAA5FB0", Offset = "0xAA53B0", VA = "0x180AA5FB0")]
			[CompilerGenerated]
			get
			{
				return default(long);
			}
			[Cpp2IlInjected.Token(Token = "0x6000563")]
			[Cpp2IlInjected.Address(RVA = "0xB96550", Offset = "0xB95950", VA = "0x180B96550")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000272")]
		public CurrencyType CurrencyType
		{
			[Cpp2IlInjected.Token(Token = "0x6000564")]
			[Cpp2IlInjected.Address(RVA = "0xAAC980", Offset = "0xAABD80", VA = "0x180AAC980")]
			[CompilerGenerated]
			get
			{
				return default(CurrencyType);
			}
			[Cpp2IlInjected.Token(Token = "0x6000565")]
			[Cpp2IlInjected.Address(RVA = "0xAB2F40", Offset = "0xAB2340", VA = "0x180AB2F40")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000273")]
		[DataMember(Name = "Platform")]
		public StorefrontBalanceType BalanceType
		{
			[Cpp2IlInjected.Token(Token = "0x6000566")]
			[Cpp2IlInjected.Address(RVA = "0x12E70B0", Offset = "0x12E64B0", VA = "0x1812E70B0")]
			[CompilerGenerated]
			get
			{
				return default(StorefrontBalanceType);
			}
			[Cpp2IlInjected.Token(Token = "0x6000567")]
			[Cpp2IlInjected.Address(RVA = "0x12E70C0", Offset = "0x12E64C0", VA = "0x1812E70C0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000568")]
		[Cpp2IlInjected.Address(RVA = "0xAAC8E0", Offset = "0xAABCE0", VA = "0x180AAC8E0")]
		public BalanceResponseDTO()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000D0")]
	[Utf8JsonSerializable]
	public class FilteredTextDTO
	{
		[Cpp2IlInjected.Token(Token = "0x17000274")]
		public string Text
		{
			[Cpp2IlInjected.Token(Token = "0x6000569")]
			[Cpp2IlInjected.Address(RVA = "0xAA5FB0", Offset = "0xAA53B0", VA = "0x180AA5FB0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600056A")]
			[Cpp2IlInjected.Address(RVA = "0xAA5FC0", Offset = "0xAA53C0", VA = "0x180AA5FC0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000275")]
		public int NumBadWords
		{
			[Cpp2IlInjected.Token(Token = "0x600056B")]
			[Cpp2IlInjected.Address(RVA = "0xAAC980", Offset = "0xAABD80", VA = "0x180AAC980")]
			[CompilerGenerated]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x600056C")]
			[Cpp2IlInjected.Address(RVA = "0xAB2F40", Offset = "0xAB2340", VA = "0x180AB2F40")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600056D")]
		[Cpp2IlInjected.Address(RVA = "0xAAC8E0", Offset = "0xAABCE0", VA = "0x180AAC8E0")]
		public FilteredTextDTO()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000D1")]
	[Utf8JsonSerializable]
	public class TimedCurrencyGrantDTO
	{
		[Cpp2IlInjected.Token(Token = "0x17000276")]
		public long TimedCurrencyGrantId
		{
			[Cpp2IlInjected.Token(Token = "0x600056E")]
			[Cpp2IlInjected.Address(RVA = "0xAA5FB0", Offset = "0xAA53B0", VA = "0x180AA5FB0")]
			[CompilerGenerated]
			get
			{
				return default(long);
			}
			[Cpp2IlInjected.Token(Token = "0x600056F")]
			[Cpp2IlInjected.Address(RVA = "0xB96550", Offset = "0xB95950", VA = "0x180B96550")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000277")]
		public string Name
		{
			[Cpp2IlInjected.Token(Token = "0x6000570")]
			[Cpp2IlInjected.Address(RVA = "0xAAA880", Offset = "0xAA9C80", VA = "0x180AAA880")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000571")]
			[Cpp2IlInjected.Address(RVA = "0xAAA120", Offset = "0xAA9520", VA = "0x180AAA120")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000278")]
		public DateTime StartTime
		{
			[Cpp2IlInjected.Token(Token = "0x6000572")]
			[Cpp2IlInjected.Address(RVA = "0xAAB1C0", Offset = "0xAAA5C0", VA = "0x180AAB1C0")]
			[CompilerGenerated]
			get
			{
				return default(DateTime);
			}
			[Cpp2IlInjected.Token(Token = "0x6000573")]
			[Cpp2IlInjected.Address(RVA = "0xB30430", Offset = "0xB2F830", VA = "0x180B30430")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000279")]
		public DateTime EndTime
		{
			[Cpp2IlInjected.Token(Token = "0x6000574")]
			[Cpp2IlInjected.Address(RVA = "0xAAA820", Offset = "0xAA9C20", VA = "0x180AAA820")]
			[CompilerGenerated]
			get
			{
				return default(DateTime);
			}
			[Cpp2IlInjected.Token(Token = "0x6000575")]
			[Cpp2IlInjected.Address(RVA = "0xAAA000", Offset = "0xAA9400", VA = "0x180AAA000")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700027A")]
		public CurrencyType CurrencyType
		{
			[Cpp2IlInjected.Token(Token = "0x6000576")]
			[Cpp2IlInjected.Address(RVA = "0xAAF800", Offset = "0xAAEC00", VA = "0x180AAF800")]
			[CompilerGenerated]
			get
			{
				return default(CurrencyType);
			}
			[Cpp2IlInjected.Token(Token = "0x6000577")]
			[Cpp2IlInjected.Address(RVA = "0xAAF7F0", Offset = "0xAAEBF0", VA = "0x180AAF7F0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700027B")]
		public float OfflineRatePerHour
		{
			[Cpp2IlInjected.Token(Token = "0x6000578")]
			[Cpp2IlInjected.Address(RVA = "0xF3EA30", Offset = "0xF3DE30", VA = "0x180F3EA30")]
			[CompilerGenerated]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x6000579")]
			[Cpp2IlInjected.Address(RVA = "0x1C75270", Offset = "0x1C74670", VA = "0x181C75270")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700027C")]
		public float OnlineRatePerHour
		{
			[Cpp2IlInjected.Token(Token = "0x600057A")]
			[Cpp2IlInjected.Address(RVA = "0xB781E0", Offset = "0xB775E0", VA = "0x180B781E0")]
			[CompilerGenerated]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x600057B")]
			[Cpp2IlInjected.Address(RVA = "0x10ECD80", Offset = "0x10EC180", VA = "0x1810ECD80")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700027D")]
		public string ActiveExperiment
		{
			[Cpp2IlInjected.Token(Token = "0x600057C")]
			[Cpp2IlInjected.Address(RVA = "0xAAA810", Offset = "0xAA9C10", VA = "0x180AAA810")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600057D")]
			[Cpp2IlInjected.Address(RVA = "0xAAA840", Offset = "0xAA9C40", VA = "0x180AAA840")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600057E")]
		[Cpp2IlInjected.Address(RVA = "0xAAC8E0", Offset = "0xAABCE0", VA = "0x180AAC8E0")]
		public TimedCurrencyGrantDTO()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000D2")]
	[Utf8JsonSerializable]
	public class TimedRewardTrackDTO
	{
		[Cpp2IlInjected.Token(Token = "0x1700027E")]
		public long TrackId
		{
			[Cpp2IlInjected.Token(Token = "0x600057F")]
			[Cpp2IlInjected.Address(RVA = "0xAA5FB0", Offset = "0xAA53B0", VA = "0x180AA5FB0")]
			[CompilerGenerated]
			get
			{
				return default(long);
			}
			[Cpp2IlInjected.Token(Token = "0x6000580")]
			[Cpp2IlInjected.Address(RVA = "0xB96550", Offset = "0xB95950", VA = "0x180B96550")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700027F")]
		public string Name
		{
			[Cpp2IlInjected.Token(Token = "0x6000581")]
			[Cpp2IlInjected.Address(RVA = "0xAAA880", Offset = "0xAA9C80", VA = "0x180AAA880")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000582")]
			[Cpp2IlInjected.Address(RVA = "0xAAA120", Offset = "0xAA9520", VA = "0x180AAA120")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000280")]
		public DateTime StartTime
		{
			[Cpp2IlInjected.Token(Token = "0x6000583")]
			[Cpp2IlInjected.Address(RVA = "0xAAB1C0", Offset = "0xAAA5C0", VA = "0x180AAB1C0")]
			[CompilerGenerated]
			get
			{
				return default(DateTime);
			}
			[Cpp2IlInjected.Token(Token = "0x6000584")]
			[Cpp2IlInjected.Address(RVA = "0xB30430", Offset = "0xB2F830", VA = "0x180B30430")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000281")]
		public DateTime EndTime
		{
			[Cpp2IlInjected.Token(Token = "0x6000585")]
			[Cpp2IlInjected.Address(RVA = "0xAAA820", Offset = "0xAA9C20", VA = "0x180AAA820")]
			[CompilerGenerated]
			get
			{
				return default(DateTime);
			}
			[Cpp2IlInjected.Token(Token = "0x6000586")]
			[Cpp2IlInjected.Address(RVA = "0xAAA000", Offset = "0xAA9400", VA = "0x180AAA000")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000282")]
		public int RequiredXp
		{
			[Cpp2IlInjected.Token(Token = "0x6000587")]
			[Cpp2IlInjected.Address(RVA = "0xAAF800", Offset = "0xAAEC00", VA = "0x180AAF800")]
			[CompilerGenerated]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x6000588")]
			[Cpp2IlInjected.Address(RVA = "0xAAF7F0", Offset = "0xAAEBF0", VA = "0x180AAF7F0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000283")]
		public int GiftDropId
		{
			[Cpp2IlInjected.Token(Token = "0x6000589")]
			[Cpp2IlInjected.Address(RVA = "0xAF32A0", Offset = "0xAF26A0", VA = "0x180AF32A0")]
			[CompilerGenerated]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x600058A")]
			[Cpp2IlInjected.Address(RVA = "0x13D1290", Offset = "0x13D0690", VA = "0x1813D1290")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600058B")]
		[Cpp2IlInjected.Address(RVA = "0xAAC8E0", Offset = "0xAABCE0", VA = "0x180AAC8E0")]
		public TimedRewardTrackDTO()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000D3")]
	[Utf8JsonSerializable]
	public class TimedRewardTrackRecordDTO
	{
		[Cpp2IlInjected.Token(Token = "0x17000284")]
		public long TrackId
		{
			[Cpp2IlInjected.Token(Token = "0x600058C")]
			[Cpp2IlInjected.Address(RVA = "0xAA5FB0", Offset = "0xAA53B0", VA = "0x180AA5FB0")]
			[CompilerGenerated]
			get
			{
				return default(long);
			}
			[Cpp2IlInjected.Token(Token = "0x600058D")]
			[Cpp2IlInjected.Address(RVA = "0xB96550", Offset = "0xB95950", VA = "0x180B96550")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000285")]
		public int AccountId
		{
			[Cpp2IlInjected.Token(Token = "0x600058E")]
			[Cpp2IlInjected.Address(RVA = "0xAAC980", Offset = "0xAABD80", VA = "0x180AAC980")]
			[CompilerGenerated]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x600058F")]
			[Cpp2IlInjected.Address(RVA = "0xAB2F40", Offset = "0xAB2340", VA = "0x180AB2F40")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000286")]
		public int Xp
		{
			[Cpp2IlInjected.Token(Token = "0x6000590")]
			[Cpp2IlInjected.Address(RVA = "0x12E70B0", Offset = "0x12E64B0", VA = "0x1812E70B0")]
			[CompilerGenerated]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x6000591")]
			[Cpp2IlInjected.Address(RVA = "0x12E70C0", Offset = "0x12E64C0", VA = "0x1812E70C0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000592")]
		[Cpp2IlInjected.Address(RVA = "0xAAC8E0", Offset = "0xAABCE0", VA = "0x180AAC8E0")]
		public TimedRewardTrackRecordDTO()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000D4")]
	[Utf8JsonSerializable]
	public class TimedRewardTrackXpEarnedDTO : IEquatable<TimedRewardTrackXpEarnedDTO>
	{
		[Cpp2IlInjected.Token(Token = "0x17000287")]
		[CompilerGenerated]
		protected virtual Type ITQAFHBSGFG
		{
			[Cpp2IlInjected.Token(Token = "0x6000594")]
			[Cpp2IlInjected.Address(RVA = "0x771DDB0", Offset = "0x771D1B0", VA = "0x18771DDB0", Slot = "5")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000288")]
		public long TrackId
		{
			[Cpp2IlInjected.Token(Token = "0x6000595")]
			[Cpp2IlInjected.Address(RVA = "0xAA5FB0", Offset = "0xAA53B0", VA = "0x180AA5FB0")]
			[CompilerGenerated]
			get
			{
				return default(long);
			}
			[Cpp2IlInjected.Token(Token = "0x6000596")]
			[Cpp2IlInjected.Address(RVA = "0xB96550", Offset = "0xB95950", VA = "0x180B96550")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000289")]
		public int AccountId
		{
			[Cpp2IlInjected.Token(Token = "0x6000597")]
			[Cpp2IlInjected.Address(RVA = "0xAAC980", Offset = "0xAABD80", VA = "0x180AAC980")]
			[CompilerGenerated]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x6000598")]
			[Cpp2IlInjected.Address(RVA = "0xAB2F40", Offset = "0xAB2340", VA = "0x180AB2F40")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700028A")]
		public int TotalXp
		{
			[Cpp2IlInjected.Token(Token = "0x6000599")]
			[Cpp2IlInjected.Address(RVA = "0x12E70B0", Offset = "0x12E64B0", VA = "0x1812E70B0")]
			[CompilerGenerated]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x600059A")]
			[Cpp2IlInjected.Address(RVA = "0x12E70C0", Offset = "0x12E64C0", VA = "0x1812E70C0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700028B")]
		public int DeltaXp
		{
			[Cpp2IlInjected.Token(Token = "0x600059B")]
			[Cpp2IlInjected.Address(RVA = "0xAB5660", Offset = "0xAB4A60", VA = "0x180AB5660")]
			[CompilerGenerated]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x600059C")]
			[Cpp2IlInjected.Address(RVA = "0xB07AB0", Offset = "0xB06EB0", VA = "0x180B07AB0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700028C")]
		public float DeltaXpMultiplier
		{
			[Cpp2IlInjected.Token(Token = "0x600059D")]
			[Cpp2IlInjected.Address(RVA = "0xB07AC0", Offset = "0xB06EC0", VA = "0x180B07AC0")]
			[CompilerGenerated]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x600059E")]
			[Cpp2IlInjected.Address(RVA = "0xB07770", Offset = "0xB06B70", VA = "0x180B07770")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000593")]
		[Cpp2IlInjected.Address(RVA = "0x771DF40", Offset = "0x771D340", VA = "0x18771DF40")]
		public TimedRewardTrackXpEarnedDTO(long TrackId, int AccountId, int TotalXp, int DeltaXp, float DeltaXpMultiplier)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600059F")]
		[Cpp2IlInjected.Address(RVA = "0x771DE00", Offset = "0x771D200", VA = "0x18771DE00", Slot = "3")]
		[CompilerGenerated]
		public override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60005A0")]
		[Cpp2IlInjected.Address(RVA = "0x771DBA0", Offset = "0x771CFA0", VA = "0x18771DBA0", Slot = "6")]
		[CompilerGenerated]
		protected virtual bool LXITBKEHWVK(StringBuilder a)
		{
			return default(bool);
		}

		[SpecialName]
		[Cpp2IlInjected.Token(Token = "0x60005A1")]
		[Cpp2IlInjected.Address(RVA = "0xFB47E0", Offset = "0xFB3BE0", VA = "0x180FB47E0")]
		[CompilerGenerated]
		public static bool ZPGHGHNXRJT(TimedRewardTrackXpEarnedDTO? a, TimedRewardTrackXpEarnedDTO? b)
		{
			return default(bool);
		}

		[SpecialName]
		[Cpp2IlInjected.Token(Token = "0x60005A2")]
		[Cpp2IlInjected.Address(RVA = "0xFB4820", Offset = "0xFB3C20", VA = "0x180FB4820")]
		[CompilerGenerated]
		public static bool ZWISVWGZSLY(TimedRewardTrackXpEarnedDTO? a, TimedRewardTrackXpEarnedDTO? b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60005A3")]
		[Cpp2IlInjected.Address(RVA = "0x771D980", Offset = "0x771CD80", VA = "0x18771D980", Slot = "2")]
		[CompilerGenerated]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60005A4")]
		[Cpp2IlInjected.Address(RVA = "0x771D6E0", Offset = "0x771CAE0", VA = "0x18771D6E0", Slot = "0")]
		[CompilerGenerated]
		public override bool Equals(object? obj)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60005A5")]
		[Cpp2IlInjected.Address(RVA = "0x771D770", Offset = "0x771CB70", VA = "0x18771D770", Slot = "7")]
		[CompilerGenerated]
		public virtual bool Equals(TimedRewardTrackXpEarnedDTO? other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60005A6")]
		[Cpp2IlInjected.Address(RVA = "0x771DD30", Offset = "0x771D130", VA = "0x18771DD30", Slot = "8")]
		[CompilerGenerated]
		public virtual TimedRewardTrackXpEarnedDTO OMSRAXDGICF()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60005A7")]
		[Cpp2IlInjected.Address(RVA = "0x771DEF0", Offset = "0x771D2F0", VA = "0x18771DEF0")]
		[CompilerGenerated]
		protected TimedRewardTrackXpEarnedDTO(TimedRewardTrackXpEarnedDTO original)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005A8")]
		[Cpp2IlInjected.Address(RVA = "0x771DB70", Offset = "0x771CF70", VA = "0x18771DB70")]
		[CompilerGenerated]
		public void HYZXLOOBRHM([Out] long a, [Out] int b, [Out] int c, [Out] int d, [Out] float e)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000D5")]
	public static class OYNLQAKUMPM
	{
		[Cpp2IlInjected.Token(Token = "0x20000D6")]
		public enum UgcReportCategory
		{
			[Cpp2IlInjected.Token(Token = "0x40003E5")]
			CoC_Discriminatory,
			[Cpp2IlInjected.Token(Token = "0x40003E6")]
			CoC_Sexual,
			[Cpp2IlInjected.Token(Token = "0x40003E7")]
			CoC_Trolling,
			[Cpp2IlInjected.Token(Token = "0x40003E8")]
			Misleading,
			[Cpp2IlInjected.Token(Token = "0x40003E9")]
			Other,
			[Cpp2IlInjected.Token(Token = "0x40003EA")]
			InappropriateClothing
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000D7")]
	[Utf8JsonSerializable]
	public class AddOrRemovePlayerRoomInventoryRequestDTO
	{
		[Cpp2IlInjected.Token(Token = "0x1700028D")]
		public long RoomId
		{
			[Cpp2IlInjected.Token(Token = "0x60005AB")]
			[Cpp2IlInjected.Address(RVA = "0xAA5FB0", Offset = "0xAA53B0", VA = "0x180AA5FB0")]
			[CompilerGenerated]
			get
			{
				return default(long);
			}
			[Cpp2IlInjected.Token(Token = "0x60005AC")]
			[Cpp2IlInjected.Address(RVA = "0xB96550", Offset = "0xB95950", VA = "0x180B96550")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700028E")]
		public Guid RoomInventoryItemOriginId
		{
			[Cpp2IlInjected.Token(Token = "0x60005AD")]
			[Cpp2IlInjected.Address(RVA = "0xC66740", Offset = "0xC65B40", VA = "0x180C66740")]
			[CompilerGenerated]
			get
			{
				return default(Guid);
			}
			[Cpp2IlInjected.Token(Token = "0x60005AE")]
			[Cpp2IlInjected.Address(RVA = "0xC66840", Offset = "0xC65C40", VA = "0x180C66840")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700028F")]
		public long Quantity
		{
			[Cpp2IlInjected.Token(Token = "0x60005AF")]
			[Cpp2IlInjected.Address(RVA = "0xAAA820", Offset = "0xAA9C20", VA = "0x180AAA820")]
			[CompilerGenerated]
			get
			{
				return default(long);
			}
			[Cpp2IlInjected.Token(Token = "0x60005B0")]
			[Cpp2IlInjected.Address(RVA = "0xAAA000", Offset = "0xAA9400", VA = "0x180AAA000")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000290")]
		public ConcurrencyCodePairDTO ConcurrencyCodes
		{
			[Cpp2IlInjected.Token(Token = "0x60005B1")]
			[Cpp2IlInjected.Address(RVA = "0xAAA140", Offset = "0xAA9540", VA = "0x180AAA140")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60005B2")]
			[Cpp2IlInjected.Address(RVA = "0xAADB00", Offset = "0xAACF00", VA = "0x180AADB00")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60005A9")]
		[Cpp2IlInjected.Address(RVA = "0xAAC8E0", Offset = "0xAABCE0", VA = "0x180AAC8E0")]
		public AddOrRemovePlayerRoomInventoryRequestDTO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005AA")]
		[Cpp2IlInjected.Address(RVA = "0x77136E0", Offset = "0x7712AE0", VA = "0x1877136E0")]
		public AddOrRemovePlayerRoomInventoryRequestDTO(long roomId, Guid roomInventoryItemOriginId, long quantity, ConcurrencyCodePairDTO concurrencyCodes)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000D8")]
	[Utf8JsonSerializable]
	public class AddOrRemovePlayerRoomInventoryItemCountResponseDTO
	{
		[Cpp2IlInjected.Token(Token = "0x17000291")]
		public PlayerRoomInventoryOperationResult Result
		{
			[Cpp2IlInjected.Token(Token = "0x60005B3")]
			[Cpp2IlInjected.Address(RVA = "0xAA3110", Offset = "0xAA2510", VA = "0x180AA3110")]
			[CompilerGenerated]
			get
			{
				return default(PlayerRoomInventoryOperationResult);
			}
			[Cpp2IlInjected.Token(Token = "0x60005B4")]
			[Cpp2IlInjected.Address(RVA = "0xAAB1D0", Offset = "0xAAA5D0", VA = "0x180AAB1D0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000292")]
		public PlayerRoomInventoryItemDTO PlayerRoomInventoryItem
		{
			[Cpp2IlInjected.Token(Token = "0x60005B5")]
			[Cpp2IlInjected.Address(RVA = "0xAAA880", Offset = "0xAA9C80", VA = "0x180AAA880")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60005B6")]
			[Cpp2IlInjected.Address(RVA = "0xAAA120", Offset = "0xAA9520", VA = "0x180AAA120")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60005B7")]
		[Cpp2IlInjected.Address(RVA = "0xAAC8E0", Offset = "0xAABCE0", VA = "0x180AAC8E0")]
		public AddOrRemovePlayerRoomInventoryItemCountResponseDTO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005B8")]
		[Cpp2IlInjected.Address(RVA = "0xD7A3C0", Offset = "0xD797C0", VA = "0x180D7A3C0")]
		public AddOrRemovePlayerRoomInventoryItemCountResponseDTO(PlayerRoomInventoryOperationResult result, PlayerRoomInventoryItemDTO playerRoomInventoryItem)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000D9")]
	[Utf8JsonSerializable]
	public class ConcurrencyCodePairDTO
	{
		[Cpp2IlInjected.Token(Token = "0x17000293")]
		public Guid? CurrentConcurrencyCode
		{
			[Cpp2IlInjected.Token(Token = "0x60005BB")]
			[Cpp2IlInjected.Address(RVA = "0x2F548A0", Offset = "0x2F53CA0", VA = "0x182F548A0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60005BC")]
			[Cpp2IlInjected.Address(RVA = "0x7715510", Offset = "0x7714910", VA = "0x187715510")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000294")]
		public Guid NewConcurrencyCode
		{
			[Cpp2IlInjected.Token(Token = "0x60005BD")]
			[Cpp2IlInjected.Address(RVA = "0xB8A250", Offset = "0xB89650", VA = "0x180B8A250")]
			[CompilerGenerated]
			get
			{
				return default(Guid);
			}
			[Cpp2IlInjected.Token(Token = "0x60005BE")]
			[Cpp2IlInjected.Address(RVA = "0xB8A0D0", Offset = "0xB894D0", VA = "0x180B8A0D0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60005B9")]
		[Cpp2IlInjected.Address(RVA = "0xAAC8E0", Offset = "0xAABCE0", VA = "0x180AAC8E0")]
		public ConcurrencyCodePairDTO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005BA")]
		[Cpp2IlInjected.Address(RVA = "0x77154C0", Offset = "0x77148C0", VA = "0x1877154C0")]
		public ConcurrencyCodePairDTO(Guid? currentConcurrencyCode, Guid newConcurrencyCodeValue)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000DA")]
	[Utf8JsonSerializable]
	public class PlayerRoomInventoryItemDTO
	{
		[Cpp2IlInjected.Token(Token = "0x17000295")]
		public long RoomId
		{
			[Cpp2IlInjected.Token(Token = "0x60005BF")]
			[Cpp2IlInjected.Address(RVA = "0xAA5FB0", Offset = "0xAA53B0", VA = "0x180AA5FB0")]
			[CompilerGenerated]
			get
			{
				return default(long);
			}
			[Cpp2IlInjected.Token(Token = "0x60005C0")]
			[Cpp2IlInjected.Address(RVA = "0xB96550", Offset = "0xB95950", VA = "0x180B96550")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000296")]
		public Guid RoomInventoryItemOriginId
		{
			[Cpp2IlInjected.Token(Token = "0x60005C1")]
			[Cpp2IlInjected.Address(RVA = "0xC66740", Offset = "0xC65B40", VA = "0x180C66740")]
			[CompilerGenerated]
			get
			{
				return default(Guid);
			}
			[Cpp2IlInjected.Token(Token = "0x60005C2")]
			[Cpp2IlInjected.Address(RVA = "0xC66840", Offset = "0xC65C40", VA = "0x180C66840")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000297")]
		public long Count
		{
			[Cpp2IlInjected.Token(Token = "0x60005C3")]
			[Cpp2IlInjected.Address(RVA = "0xAAA820", Offset = "0xAA9C20", VA = "0x180AAA820")]
			[CompilerGenerated]
			get
			{
				return default(long);
			}
			[Cpp2IlInjected.Token(Token = "0x60005C4")]
			[Cpp2IlInjected.Address(RVA = "0xAAA000", Offset = "0xAA9400", VA = "0x180AAA000")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000298")]
		public Guid ConcurrencyCode
		{
			[Cpp2IlInjected.Token(Token = "0x60005C5")]
			[Cpp2IlInjected.Address(RVA = "0xC5CFF0", Offset = "0xC5C3F0", VA = "0x180C5CFF0")]
			[CompilerGenerated]
			get
			{
				return default(Guid);
			}
			[Cpp2IlInjected.Token(Token = "0x60005C6")]
			[Cpp2IlInjected.Address(RVA = "0xC5D250", Offset = "0xC5C650", VA = "0x180C5D250")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000299")]
		public DateTime CreatedAt
		{
			[Cpp2IlInjected.Token(Token = "0x60005C7")]
			[Cpp2IlInjected.Address(RVA = "0xAAA810", Offset = "0xAA9C10", VA = "0x180AAA810")]
			[CompilerGenerated]
			get
			{
				return default(DateTime);
			}
			[Cpp2IlInjected.Token(Token = "0x60005C8")]
			[Cpp2IlInjected.Address(RVA = "0xCDACA0", Offset = "0xCDA0A0", VA = "0x180CDACA0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700029A")]
		public DateTime ModifiedAt
		{
			[Cpp2IlInjected.Token(Token = "0x60005C9")]
			[Cpp2IlInjected.Address(RVA = "0xAAA160", Offset = "0xAA9560", VA = "0x180AAA160")]
			[CompilerGenerated]
			get
			{
				return default(DateTime);
			}
			[Cpp2IlInjected.Token(Token = "0x60005CA")]
			[Cpp2IlInjected.Address(RVA = "0x10D7F70", Offset = "0x10D7370", VA = "0x1810D7F70")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60005CB")]
		[Cpp2IlInjected.Address(RVA = "0xAAC8E0", Offset = "0xAABCE0", VA = "0x180AAC8E0")]
		public PlayerRoomInventoryItemDTO()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000DB")]
	[Utf8JsonSerializable]
	public class RoomInventoryCreateOrUpdateRequestDTO
	{
		[Cpp2IlInjected.Token(Token = "0x1700029B")]
		public string Name
		{
			[Cpp2IlInjected.Token(Token = "0x60005CC")]
			[Cpp2IlInjected.Address(RVA = "0xAA5FB0", Offset = "0xAA53B0", VA = "0x180AA5FB0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60005CD")]
			[Cpp2IlInjected.Address(RVA = "0xAA5FC0", Offset = "0xAA53C0", VA = "0x180AA5FC0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700029C")]
		public string Description
		{
			[Cpp2IlInjected.Token(Token = "0x60005CE")]
			[Cpp2IlInjected.Address(RVA = "0xAAA880", Offset = "0xAA9C80", VA = "0x180AAA880")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60005CF")]
			[Cpp2IlInjected.Address(RVA = "0xAAA120", Offset = "0xAA9520", VA = "0x180AAA120")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700029D")]
		public string ImageName
		{
			[Cpp2IlInjected.Token(Token = "0x60005D0")]
			[Cpp2IlInjected.Address(RVA = "0xAAB1C0", Offset = "0xAAA5C0", VA = "0x180AAB1C0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60005D1")]
			[Cpp2IlInjected.Address(RVA = "0xAA67C0", Offset = "0xAA5BC0", VA = "0x180AA67C0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700029E")]
		public List<long> TagIds
		{
			[Cpp2IlInjected.Token(Token = "0x60005D2")]
			[Cpp2IlInjected.Address(RVA = "0xAAA820", Offset = "0xAA9C20", VA = "0x180AAA820")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60005D3")]
			[Cpp2IlInjected.Address(RVA = "0xAA67D0", Offset = "0xAA5BD0", VA = "0x180AA67D0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700029F")]
		public List<RoomInventoryItemTagCreateDTO> NewTags
		{
			[Cpp2IlInjected.Token(Token = "0x60005D4")]
			[Cpp2IlInjected.Address(RVA = "0xAAA140", Offset = "0xAA9540", VA = "0x180AAA140")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60005D5")]
			[Cpp2IlInjected.Address(RVA = "0xAADB00", Offset = "0xAACF00", VA = "0x180AADB00")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170002A0")]
		public string Properties
		{
			[Cpp2IlInjected.Token(Token = "0x60005D6")]
			[Cpp2IlInjected.Address(RVA = "0xAAA030", Offset = "0xAA9430", VA = "0x180AAA030")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60005D7")]
			[Cpp2IlInjected.Address(RVA = "0xAAA110", Offset = "0xAA9510", VA = "0x180AAA110")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170002A1")]
		public byte? IconShape
		{
			[Cpp2IlInjected.Token(Token = "0x60005D8")]
			[Cpp2IlInjected.Address(RVA = "0xBA3C80", Offset = "0xBA3080", VA = "0x180BA3C80")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60005D9")]
			[Cpp2IlInjected.Address(RVA = "0xBA3C90", Offset = "0xBA3090", VA = "0x180BA3C90")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170002A2")]
		public int? IconColor
		{
			[Cpp2IlInjected.Token(Token = "0x60005DA")]
			[Cpp2IlInjected.Address(RVA = "0x47F8CB0", Offset = "0x47F80B0", VA = "0x1847F8CB0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60005DB")]
			[Cpp2IlInjected.Address(RVA = "0x7715BA0", Offset = "0x7714FA0", VA = "0x187715BA0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170002A3")]
		public Guid? OriginId
		{
			[Cpp2IlInjected.Token(Token = "0x60005DC")]
			[Cpp2IlInjected.Address(RVA = "0x771AE60", Offset = "0x771A260", VA = "0x18771AE60")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60005DD")]
			[Cpp2IlInjected.Address(RVA = "0x771AE80", Offset = "0x771A280", VA = "0x18771AE80")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170002A4")]
		public bool AllowRename
		{
			[Cpp2IlInjected.Token(Token = "0x60005DE")]
			[Cpp2IlInjected.Address(RVA = "0xAA9F30", Offset = "0xAA9330", VA = "0x180AA9F30")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x60005DF")]
			[Cpp2IlInjected.Address(RVA = "0xAAA040", Offset = "0xAA9440", VA = "0x180AAA040")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60005E0")]
		[Cpp2IlInjected.Address(RVA = "0xAAC8E0", Offset = "0xAABCE0", VA = "0x180AAC8E0")]
		public RoomInventoryCreateOrUpdateRequestDTO()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000DC")]
	[Utf8JsonSerializable]
	public class RoomInventoryItemDTO
	{
		[Cpp2IlInjected.Token(Token = "0x170002A5")]
		public Guid OriginId
		{
			[Cpp2IlInjected.Token(Token = "0x60005E1")]
			[Cpp2IlInjected.Address(RVA = "0xBAF500", Offset = "0xBAE900", VA = "0x180BAF500")]
			[CompilerGenerated]
			get
			{
				return default(Guid);
			}
			[Cpp2IlInjected.Token(Token = "0x60005E2")]
			[Cpp2IlInjected.Address(RVA = "0xBAF520", Offset = "0xBAE920", VA = "0x180BAF520")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170002A6")]
		public long RoomId
		{
			[Cpp2IlInjected.Token(Token = "0x60005E3")]
			[Cpp2IlInjected.Address(RVA = "0xAAB1C0", Offset = "0xAAA5C0", VA = "0x180AAB1C0")]
			[CompilerGenerated]
			get
			{
				return default(long);
			}
			[Cpp2IlInjected.Token(Token = "0x60005E4")]
			[Cpp2IlInjected.Address(RVA = "0xB30430", Offset = "0xB2F830", VA = "0x180B30430")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170002A7")]
		public string Name
		{
			[Cpp2IlInjected.Token(Token = "0x60005E5")]
			[Cpp2IlInjected.Address(RVA = "0xAAA820", Offset = "0xAA9C20", VA = "0x180AAA820")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60005E6")]
			[Cpp2IlInjected.Address(RVA = "0xAA67D0", Offset = "0xAA5BD0", VA = "0x180AA67D0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170002A8")]
		public string Description
		{
			[Cpp2IlInjected.Token(Token = "0x60005E7")]
			[Cpp2IlInjected.Address(RVA = "0xAAA140", Offset = "0xAA9540", VA = "0x180AAA140")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60005E8")]
			[Cpp2IlInjected.Address(RVA = "0xAADB00", Offset = "0xAACF00", VA = "0x180AADB00")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170002A9")]
		public string ImageName
		{
			[Cpp2IlInjected.Token(Token = "0x60005E9")]
			[Cpp2IlInjected.Address(RVA = "0xAAA030", Offset = "0xAA9430", VA = "0x180AAA030")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60005EA")]
			[Cpp2IlInjected.Address(RVA = "0xAAA110", Offset = "0xAA9510", VA = "0x180AAA110")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170002AA")]
		public DateTime CreatedAt
		{
			[Cpp2IlInjected.Token(Token = "0x60005EB")]
			[Cpp2IlInjected.Address(RVA = "0xAAA810", Offset = "0xAA9C10", VA = "0x180AAA810")]
			[CompilerGenerated]
			get
			{
				return default(DateTime);
			}
			[Cpp2IlInjected.Token(Token = "0x60005EC")]
			[Cpp2IlInjected.Address(RVA = "0xCDACA0", Offset = "0xCDA0A0", VA = "0x180CDACA0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170002AB")]
		public DateTime ModifiedAt
		{
			[Cpp2IlInjected.Token(Token = "0x60005ED")]
			[Cpp2IlInjected.Address(RVA = "0xAAA160", Offset = "0xAA9560", VA = "0x180AAA160")]
			[CompilerGenerated]
			get
			{
				return default(DateTime);
			}
			[Cpp2IlInjected.Token(Token = "0x60005EE")]
			[Cpp2IlInjected.Address(RVA = "0x10D7F70", Offset = "0x10D7370", VA = "0x1810D7F70")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170002AC")]
		public string Properties
		{
			[Cpp2IlInjected.Token(Token = "0x60005EF")]
			[Cpp2IlInjected.Address(RVA = "0xAA3370", Offset = "0xAA2770", VA = "0x180AA3370")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60005F0")]
			[Cpp2IlInjected.Address(RVA = "0xAA3390", Offset = "0xAA2790", VA = "0x180AA3390")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170002AD")]
		public List<long> TagIds
		{
			[Cpp2IlInjected.Token(Token = "0x60005F1")]
			[Cpp2IlInjected.Address(RVA = "0xAA3150", Offset = "0xAA2550", VA = "0x180AA3150")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60005F2")]
			[Cpp2IlInjected.Address(RVA = "0xAA33A0", Offset = "0xAA27A0", VA = "0x180AA33A0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170002AE")]
		public List<RoomInventoryItemTagDTO> NewTags
		{
			[Cpp2IlInjected.Token(Token = "0x60005F3")]
			[Cpp2IlInjected.Address(RVA = "0xAA3380", Offset = "0xAA2780", VA = "0x180AA3380")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60005F4")]
			[Cpp2IlInjected.Address(RVA = "0xAA3130", Offset = "0xAA2530", VA = "0x180AA3130")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170002AF")]
		public byte IconShape
		{
			[Cpp2IlInjected.Token(Token = "0x60005F5")]
			[Cpp2IlInjected.Address(RVA = "0xAB5E80", Offset = "0xAB5280", VA = "0x180AB5E80")]
			[CompilerGenerated]
			get
			{
				return default(byte);
			}
			[Cpp2IlInjected.Token(Token = "0x60005F6")]
			[Cpp2IlInjected.Address(RVA = "0xAB5E50", Offset = "0xAB5250", VA = "0x180AB5E50")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170002B0")]
		public int IconColor
		{
			[Cpp2IlInjected.Token(Token = "0x60005F7")]
			[Cpp2IlInjected.Address(RVA = "0xBB85D0", Offset = "0xBB79D0", VA = "0x180BB85D0")]
			[CompilerGenerated]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x60005F8")]
			[Cpp2IlInjected.Address(RVA = "0x27A9090", Offset = "0x27A8490", VA = "0x1827A9090")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60005F9")]
		[Cpp2IlInjected.Address(RVA = "0xAAC8E0", Offset = "0xAABCE0", VA = "0x180AAC8E0")]
		public RoomInventoryItemDTO()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000DD")]
	[Utf8JsonSerializable]
	public class RoomInventoryItemReplicationDTO : RoomInventoryItemDTO
	{
		[Cpp2IlInjected.Token(Token = "0x170002B1")]
		public Guid RoomInventoryItemId
		{
			[Cpp2IlInjected.Token(Token = "0x60005FA")]
			[Cpp2IlInjected.Address(RVA = "0x5F1DFE0", Offset = "0x5F1D3E0", VA = "0x185F1DFE0")]
			[CompilerGenerated]
			get
			{
				return default(Guid);
			}
			[Cpp2IlInjected.Token(Token = "0x60005FB")]
			[Cpp2IlInjected.Address(RVA = "0x5F23A80", Offset = "0x5F22E80", VA = "0x185F23A80")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60005FC")]
		[Cpp2IlInjected.Address(RVA = "0xAAC8E0", Offset = "0xAABCE0", VA = "0x180AAC8E0")]
		public RoomInventoryItemReplicationDTO()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000DE")]
	public enum PlayerRoomInventoryOperationResult
	{
		[Cpp2IlInjected.Token(Token = "0x4000411")]
		Unknown = -1,
		[Cpp2IlInjected.Token(Token = "0x4000412")]
		Success,
		[Cpp2IlInjected.Token(Token = "0x4000413")]
		RoomInventoryItemDoesNotExist,
		[Cpp2IlInjected.Token(Token = "0x4000414")]
		PlayerDoesNotExist,
		[Cpp2IlInjected.Token(Token = "0x4000415")]
		RoomDoesNotExist,
		[Cpp2IlInjected.Token(Token = "0x4000416")]
		RequestQuantityTooLarge,
		[Cpp2IlInjected.Token(Token = "0x4000417")]
		PlayerHasReachedTheMinimumOwnedAmount,
		[Cpp2IlInjected.Token(Token = "0x4000418")]
		ConcurrencyCodeMismatch,
		[Cpp2IlInjected.Token(Token = "0x4000419")]
		InvalidConcurrencyCode
	}
	[Cpp2IlInjected.Token(Token = "0x20000DF")]
	public interface SHZTDEETFGR
	{
		[Cpp2IlInjected.Token(Token = "0x60005FD")]
		[Cpp2IlInjected.Address(Slot = "0")]
		Task<RecNetResult<RoomInventoryItemDTO>> VFPHDDHUKRK(Guid? a, long b, string c, string d, string e, string f, byte g, int h, [Optional] List<long> i, [Optional] List<RoomInventoryItemTagDTO> j, bool k = false, [Optional] CancellationToken l);

		[Cpp2IlInjected.Token(Token = "0x60005FE")]
		[Cpp2IlInjected.Address(Slot = "1")]
		Task<RecNetResult<RoomInventoryItemDTO>> MBZBIPKZQHN(Guid a, long b, [Optional] string c, [Optional] string d, [Optional] string e, [Optional] List<long> f, [Optional] Dictionary<string, string> g, [Optional] string h, [Optional] byte? i, [Optional] int? j, [Optional] CancellationToken k);

		[Cpp2IlInjected.Token(Token = "0x60005FF")]
		[Cpp2IlInjected.Address(Slot = "2")]
		Task<RecNetResult> JSVVVJWGGWV(Guid a, long b, [Optional] CancellationToken c);

		[Cpp2IlInjected.Token(Token = "0x6000600")]
		[Cpp2IlInjected.Address(Slot = "3")]
		Task<List<RoomInventoryItemDTO>> KHYXFEKSACH(long a, [Optional] CancellationToken b);

		[Cpp2IlInjected.Token(Token = "0x6000601")]
		[Cpp2IlInjected.Address(Slot = "4")]
		Task<List<PlayerRoomInventoryItemDTO>> MWYZLSCYTNK(long a, [Optional] CancellationToken b);

		[Cpp2IlInjected.Token(Token = "0x6000602")]
		[Cpp2IlInjected.Address(Slot = "5")]
		Task<List<AddOrRemovePlayerRoomInventoryItemCountResponseDTO>> UREWZOTBKQU(long a, List<AddOrRemovePlayerRoomInventoryRequestDTO> b, [Optional] CancellationToken c);
	}
	[Cpp2IlInjected.Token(Token = "0x20000E0")]
	[Utf8JsonSerializable]
	public class RoomInventoryItemTagCreateDTO
	{
		[Cpp2IlInjected.Token(Token = "0x170002B2")]
		public string Name
		{
			[Cpp2IlInjected.Token(Token = "0x6000603")]
			[Cpp2IlInjected.Address(RVA = "0xAA5FB0", Offset = "0xAA53B0", VA = "0x180AA5FB0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000604")]
			[Cpp2IlInjected.Address(RVA = "0xAA5FC0", Offset = "0xAA53C0", VA = "0x180AA5FC0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170002B3")]
		public string Properties
		{
			[Cpp2IlInjected.Token(Token = "0x6000605")]
			[Cpp2IlInjected.Address(RVA = "0xAAA880", Offset = "0xAA9C80", VA = "0x180AAA880")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000606")]
			[Cpp2IlInjected.Address(RVA = "0xAAA120", Offset = "0xAA9520", VA = "0x180AAA120")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000607")]
		[Cpp2IlInjected.Address(RVA = "0xAAC8E0", Offset = "0xAABCE0", VA = "0x180AAC8E0")]
		public RoomInventoryItemTagCreateDTO()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000E1")]
	[Utf8JsonSerializable]
	public class RoomInventoryItemTagDTO
	{
		[Cpp2IlInjected.Token(Token = "0x170002B4")]
		public long TagId
		{
			[Cpp2IlInjected.Token(Token = "0x6000608")]
			[Cpp2IlInjected.Address(RVA = "0xAA5FB0", Offset = "0xAA53B0", VA = "0x180AA5FB0")]
			[CompilerGenerated]
			get
			{
				return default(long);
			}
			[Cpp2IlInjected.Token(Token = "0x6000609")]
			[Cpp2IlInjected.Address(RVA = "0xB96550", Offset = "0xB95950", VA = "0x180B96550")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170002B5")]
		public string Name
		{
			[Cpp2IlInjected.Token(Token = "0x600060A")]
			[Cpp2IlInjected.Address(RVA = "0xAAA880", Offset = "0xAA9C80", VA = "0x180AAA880")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600060B")]
			[Cpp2IlInjected.Address(RVA = "0xAAA120", Offset = "0xAA9520", VA = "0x180AAA120")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170002B6")]
		public string Properties
		{
			[Cpp2IlInjected.Token(Token = "0x600060C")]
			[Cpp2IlInjected.Address(RVA = "0xAAB1C0", Offset = "0xAAA5C0", VA = "0x180AAB1C0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600060D")]
			[Cpp2IlInjected.Address(RVA = "0xAA67C0", Offset = "0xAA5BC0", VA = "0x180AA67C0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600060E")]
		[Cpp2IlInjected.Address(RVA = "0xAAC8E0", Offset = "0xAABCE0", VA = "0x180AAC8E0")]
		public RoomInventoryItemTagDTO()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000E2")]
	[Utf8JsonSerializable]
	public class RoomInventoryItemTagUpdateDTO
	{
		[Cpp2IlInjected.Token(Token = "0x170002B7")]
		public long TagId
		{
			[Cpp2IlInjected.Token(Token = "0x6000610")]
			[Cpp2IlInjected.Address(RVA = "0xAA5FB0", Offset = "0xAA53B0", VA = "0x180AA5FB0")]
			[CompilerGenerated]
			get
			{
				return default(long);
			}
			[Cpp2IlInjected.Token(Token = "0x6000611")]
			[Cpp2IlInjected.Address(RVA = "0xB96550", Offset = "0xB95950", VA = "0x180B96550")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170002B8")]
		public string Properties
		{
			[Cpp2IlInjected.Token(Token = "0x6000612")]
			[Cpp2IlInjected.Address(RVA = "0xAAA880", Offset = "0xAA9C80", VA = "0x180AAA880")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000613")]
			[Cpp2IlInjected.Address(RVA = "0xAAA120", Offset = "0xAA9520", VA = "0x180AAA120")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600060F")]
		[Cpp2IlInjected.Address(RVA = "0x4E2FC30", Offset = "0x4E2F030", VA = "0x184E2FC30")]
		public RoomInventoryItemTagUpdateDTO(long tagId, string properties)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000E3")]
	public interface ICZESNWUYAE
	{
		[Cpp2IlInjected.Token(Token = "0x6000614")]
		[Cpp2IlInjected.Address(Slot = "0")]
		Task<RecNetResult<List<RoomInventoryItemTagDTO>>> WOTWQTNLSWS(long a, List<RoomInventoryItemTagUpdateDTO> b, [Optional] CancellationToken c);

		[Cpp2IlInjected.Token(Token = "0x6000615")]
		[Cpp2IlInjected.Address(Slot = "1")]
		Task<RecNetResult> JZDZYZNFGPJ(long a, [Optional] CancellationToken b);

		[Cpp2IlInjected.Token(Token = "0x6000616")]
		[Cpp2IlInjected.Address(Slot = "2")]
		Task<List<RoomInventoryItemTagDTO>> YAWTQGOAQSP(long a, [Optional] CancellationToken b);
	}
	[Cpp2IlInjected.Token(Token = "0x20000E4")]
	[Utf8JsonSerializable]
	public class RoomOfferIdentifier : UGCPurchasableIdentifier, IEquatable<RoomOfferIdentifier>
	{
		[Cpp2IlInjected.Token(Token = "0x6000617")]
		[Cpp2IlInjected.Address(RVA = "0x771AF30", Offset = "0x771A330", VA = "0x18771AF30", Slot = "6")]
		public bool Equals(RoomOfferIdentifier other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000618")]
		[Cpp2IlInjected.Address(RVA = "0x771AEC0", Offset = "0x771A2C0", VA = "0x18771AEC0", Slot = "5")]
		public override UGCPurchasableIdentifier Clone()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000619")]
		[Cpp2IlInjected.Address(RVA = "0xAAC8E0", Offset = "0xAABCE0", VA = "0x180AAC8E0")]
		public RoomOfferIdentifier()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000E5")]
	public static class GMUOFHDQOGO
	{
		[Cpp2IlInjected.Token(Token = "0x600061A")]
		[Cpp2IlInjected.Address(RVA = "0x7717810", Offset = "0x7716C10", VA = "0x187717810")]
		public static RoomOfferIdentifier AODAERRLJWF(this RoomOffer a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600061B")]
		[Cpp2IlInjected.Address(RVA = "0x7717880", Offset = "0x7716C80", VA = "0x187717880")]
		public static RoomOfferIdentifier VGEAHQWEIVR(string a)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000E6")]
	[Utf8JsonSerializable]
	public class RoomOffer
	{
		[Cpp2IlInjected.Token(Token = "0x4000421")]
		public const int MIN_NAME_LENGTH = 3;

		[Cpp2IlInjected.Token(Token = "0x4000422")]
		public const int MAX_NAME_LENGTH = 40;

		[Cpp2IlInjected.Token(Token = "0x4000423")]
		public const int MAX_DESCRIPTION_LENGTH = 180;

		[Cpp2IlInjected.Token(Token = "0x4000424")]
		public const int MAX_OFFERS_COUNT_PER_ROOM = 1000;

		[Cpp2IlInjected.Token(Token = "0x4000425")]
		public const int MAX_OFFER_INVENTORY_ITEM_COUNT = 99999;

		[Cpp2IlInjected.Token(Token = "0x4000426")]
		public const int MAX_OFFER_UNIQUE_INVENTORY_ITEM_COUNT = 8;

		[Cpp2IlInjected.Token(Token = "0x4000427")]
		public const int MIN_PRICE = 1;

		[Cpp2IlInjected.Token(Token = "0x4000428")]
		public const int MAX_PRICE = 1000000000;

		[Cpp2IlInjected.Token(Token = "0x4000429")]
		public const int MAX_CHECKOUT_QUANTITY = 9999;

		[Cpp2IlInjected.Token(Token = "0x400042A")]
		public const int DEFAULT_MINIMUM_DYNAMIC_PRICE = 1;

		[Cpp2IlInjected.Token(Token = "0x400042B")]
		public const int DEFAULT_MAXIMUM_DYNAMIC_PRICE = 1000000000;

		[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
		[Cpp2IlInjected.Token(Token = "0x400043C")]
		[IgnoreDataMember]
		private IReadOnlyDictionary<Guid, int>? VCKLYUJSVNQ;

		[Cpp2IlInjected.Token(Token = "0x170002B9")]
		public Guid OriginId
		{
			[Cpp2IlInjected.Token(Token = "0x600061C")]
			[Cpp2IlInjected.Address(RVA = "0xBAF500", Offset = "0xBAE900", VA = "0x180BAF500")]
			[CompilerGenerated]
			get
			{
				return default(Guid);
			}
			[Cpp2IlInjected.Token(Token = "0x600061D")]
			[Cpp2IlInjected.Address(RVA = "0xBAF520", Offset = "0xBAE920", VA = "0x180BAF520")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170002BA")]
		public long RoomId
		{
			[Cpp2IlInjected.Token(Token = "0x600061E")]
			[Cpp2IlInjected.Address(RVA = "0xAAB1C0", Offset = "0xAAA5C0", VA = "0x180AAB1C0")]
			[CompilerGenerated]
			get
			{
				return default(long);
			}
			[Cpp2IlInjected.Token(Token = "0x600061F")]
			[Cpp2IlInjected.Address(RVA = "0xB30430", Offset = "0xB2F830", VA = "0x180B30430")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170002BB")]
		public string Name
		{
			[Cpp2IlInjected.Token(Token = "0x6000620")]
			[Cpp2IlInjected.Address(RVA = "0xAAA820", Offset = "0xAA9C20", VA = "0x180AAA820")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000621")]
			[Cpp2IlInjected.Address(RVA = "0xAA67D0", Offset = "0xAA5BD0", VA = "0x180AA67D0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170002BC")]
		public string? Description
		{
			[Cpp2IlInjected.Token(Token = "0x6000622")]
			[Cpp2IlInjected.Address(RVA = "0xAAA140", Offset = "0xAA9540", VA = "0x180AAA140")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000623")]
			[Cpp2IlInjected.Address(RVA = "0xAADB00", Offset = "0xAACF00", VA = "0x180AADB00")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170002BD")]
		public string? ImageName
		{
			[Cpp2IlInjected.Token(Token = "0x6000624")]
			[Cpp2IlInjected.Address(RVA = "0xAAA030", Offset = "0xAA9430", VA = "0x180AAA030")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000625")]
			[Cpp2IlInjected.Address(RVA = "0xAAA110", Offset = "0xAA9510", VA = "0x180AAA110")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170002BE")]
		public int Price
		{
			[Cpp2IlInjected.Token(Token = "0x6000626")]
			[Cpp2IlInjected.Address(RVA = "0xAC1F70", Offset = "0xAC1370", VA = "0x180AC1F70")]
			[CompilerGenerated]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x6000627")]
			[Cpp2IlInjected.Address(RVA = "0xBDCB60", Offset = "0xBDBF60", VA = "0x180BDCB60")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170002BF")]
		public bool HasDynamicPrice
		{
			[Cpp2IlInjected.Token(Token = "0x6000628")]
			[Cpp2IlInjected.Address(RVA = "0x16C50A0", Offset = "0x16C44A0", VA = "0x1816C50A0")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000629")]
			[Cpp2IlInjected.Address(RVA = "0x16C5090", Offset = "0x16C4490", VA = "0x1816C5090")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170002C0")]
		internal int? ZBMFHATDZCI
		{
			[Cpp2IlInjected.Token(Token = "0x600062A")]
			[Cpp2IlInjected.Address(RVA = "0xAAA160", Offset = "0xAA9560", VA = "0x180AAA160")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600062B")]
			[Cpp2IlInjected.Address(RVA = "0x10D7F70", Offset = "0x10D7370", VA = "0x1810D7F70")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170002C1")]
		[IgnoreDataMember]
		public int MinDynamicPrice
		{
			[Cpp2IlInjected.Token(Token = "0x600062C")]
			[Cpp2IlInjected.Address(RVA = "0x771B740", Offset = "0x771AB40", VA = "0x18771B740")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170002C2")]
		internal int? GNOGBEAGAIO
		{
			[Cpp2IlInjected.Token(Token = "0x600062D")]
			[Cpp2IlInjected.Address(RVA = "0xAA3370", Offset = "0xAA2770", VA = "0x180AA3370")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600062E")]
			[Cpp2IlInjected.Address(RVA = "0xCDA990", Offset = "0xCD9D90", VA = "0x180CDA990")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170002C3")]
		[IgnoreDataMember]
		public int MaxDynamicPrice
		{
			[Cpp2IlInjected.Token(Token = "0x600062F")]
			[Cpp2IlInjected.Address(RVA = "0x771B6F0", Offset = "0x771AAF0", VA = "0x18771B6F0")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170002C4")]
		public Guid? PriceUnitOriginId
		{
			[Cpp2IlInjected.Token(Token = "0x6000630")]
			[Cpp2IlInjected.Address(RVA = "0x771AE90", Offset = "0x771A290", VA = "0x18771AE90")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000631")]
			[Cpp2IlInjected.Address(RVA = "0x771AEB0", Offset = "0x771A2B0", VA = "0x18771AEB0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170002C5")]
		public int Version
		{
			[Cpp2IlInjected.Token(Token = "0x6000632")]
			[Cpp2IlInjected.Address(RVA = "0xBB85D0", Offset = "0xBB79D0", VA = "0x180BB85D0")]
			[CompilerGenerated]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x6000633")]
			[Cpp2IlInjected.Address(RVA = "0x27A9090", Offset = "0x27A8490", VA = "0x1827A9090")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170002C6")]
		public int? MaxNumPurchasesPerPlayer
		{
			[Cpp2IlInjected.Token(Token = "0x6000634")]
			[Cpp2IlInjected.Address(RVA = "0xAA5380", Offset = "0xAA4780", VA = "0x180AA5380")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000635")]
			[Cpp2IlInjected.Address(RVA = "0xCE06C0", Offset = "0xCDFAC0", VA = "0x180CE06C0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170002C7")]
		public int? MaxCountPerPurchase
		{
			[Cpp2IlInjected.Token(Token = "0x6000636")]
			[Cpp2IlInjected.Address(RVA = "0xAAD010", Offset = "0xAAC410", VA = "0x180AAD010")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000637")]
			[Cpp2IlInjected.Address(RVA = "0xCDFFC0", Offset = "0xCDF3C0", VA = "0x180CDFFC0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170002C8")]
		public IReadOnlyList<RoomOfferItemMappingDTO> ItemMappings
		{
			[Cpp2IlInjected.Token(Token = "0x6000638")]
			[Cpp2IlInjected.Address(RVA = "0xAAD040", Offset = "0xAAC440", VA = "0x180AAD040")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000639")]
			[Cpp2IlInjected.Address(RVA = "0xAAC9D0", Offset = "0xAABDD0", VA = "0x180AAC9D0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170002C9")]
		public DateTime CreatedAt
		{
			[Cpp2IlInjected.Token(Token = "0x600063A")]
			[Cpp2IlInjected.Address(RVA = "0xAAC9A0", Offset = "0xAABDA0", VA = "0x180AAC9A0")]
			[CompilerGenerated]
			get
			{
				return default(DateTime);
			}
			[Cpp2IlInjected.Token(Token = "0x600063B")]
			[Cpp2IlInjected.Address(RVA = "0x5BA20B0", Offset = "0x5BA14B0", VA = "0x185BA20B0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170002CA")]
		public DateTime ModifiedAt
		{
			[Cpp2IlInjected.Token(Token = "0x600063C")]
			[Cpp2IlInjected.Address(RVA = "0xAD3CC0", Offset = "0xAD30C0", VA = "0x180AD3CC0")]
			[CompilerGenerated]
			get
			{
				return default(DateTime);
			}
			[Cpp2IlInjected.Token(Token = "0x600063D")]
			[Cpp2IlInjected.Address(RVA = "0x27C2640", Offset = "0x27C1A40", VA = "0x1827C2640")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170002CB")]
		[IgnoreDataMember]
		public RoomOfferType RoomOfferType
		{
			[Cpp2IlInjected.Token(Token = "0x600063E")]
			[Cpp2IlInjected.Address(RVA = "0x771B810", Offset = "0x771AC10", VA = "0x18771B810")]
			get
			{
				return default(RoomOfferType);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170002CC")]
		[IgnoreDataMember]
		public IReadOnlyDictionary<Guid, int> InventoryItemMappings
		{
			[Cpp2IlInjected.Token(Token = "0x600063F")]
			[Cpp2IlInjected.Address(RVA = "0x771B690", Offset = "0x771AA90", VA = "0x18771B690")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000640")]
			[Cpp2IlInjected.Address(RVA = "0xAAC960", Offset = "0xAABD60", VA = "0x180AAC960")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170002CD")]
		[IgnoreDataMember]
		public string? LocalOverrideImageName
		{
			[Cpp2IlInjected.Token(Token = "0x6000641")]
			[Cpp2IlInjected.Address(RVA = "0xB9E4B0", Offset = "0xB9D8B0", VA = "0x180B9E4B0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000642")]
			[Cpp2IlInjected.Address(RVA = "0xB9D910", Offset = "0xB9CD10", VA = "0x180B9D910")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170002CE")]
		[IgnoreDataMember]
		public bool HasLocalOverrideImage
		{
			[Cpp2IlInjected.Token(Token = "0x6000643")]
			[Cpp2IlInjected.Address(RVA = "0x771B610", Offset = "0x771AA10", VA = "0x18771B610")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170002CF")]
		[IgnoreDataMember]
		public string? LocalOverrideDescription
		{
			[Cpp2IlInjected.Token(Token = "0x6000644")]
			[Cpp2IlInjected.Address(RVA = "0xAA6A40", Offset = "0xAA5E40", VA = "0x180AA6A40")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000645")]
			[Cpp2IlInjected.Address(RVA = "0xAA6A70", Offset = "0xAA5E70", VA = "0x180AA6A70")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170002D0")]
		[IgnoreDataMember]
		public bool HasLocalOverrideDescription
		{
			[Cpp2IlInjected.Token(Token = "0x6000646")]
			[Cpp2IlInjected.Address(RVA = "0x771B5F0", Offset = "0x771A9F0", VA = "0x18771B5F0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170002D1")]
		[IgnoreDataMember]
		public int? LocalOverridePrice
		{
			[Cpp2IlInjected.Token(Token = "0x6000647")]
			[Cpp2IlInjected.Address(RVA = "0xC24EE0", Offset = "0xC242E0", VA = "0x180C24EE0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000648")]
			[Cpp2IlInjected.Address(RVA = "0x19FB960", Offset = "0x19FAD60", VA = "0x1819FB960")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170002D2")]
		[IgnoreDataMember]
		public bool HasLocalOverridePrice
		{
			[Cpp2IlInjected.Token(Token = "0x6000649")]
			[Cpp2IlInjected.Address(RVA = "0x771B650", Offset = "0x771AA50", VA = "0x18771B650")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170002D3")]
		[IgnoreDataMember]
		public int PurchasablePrice
		{
			[Cpp2IlInjected.Token(Token = "0x600064A")]
			[Cpp2IlInjected.Address(RVA = "0x771B790", Offset = "0x771AB90", VA = "0x18771B790")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170002D4")]
		[IgnoreDataMember]
		public string? LocalOverrideName
		{
			[Cpp2IlInjected.Token(Token = "0x600064B")]
			[Cpp2IlInjected.Address(RVA = "0xBDEAA0", Offset = "0xBDDEA0", VA = "0x180BDEAA0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600064C")]
			[Cpp2IlInjected.Address(RVA = "0x1208F70", Offset = "0x1208370", VA = "0x181208F70")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170002D5")]
		[IgnoreDataMember]
		public bool HasLocalOverrideName
		{
			[Cpp2IlInjected.Token(Token = "0x600064D")]
			[Cpp2IlInjected.Address(RVA = "0x771B630", Offset = "0x771AA30", VA = "0x18771B630")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600064E")]
		[Cpp2IlInjected.Address(RVA = "0xAAC8E0", Offset = "0xAABCE0", VA = "0x180AAC8E0")]
		public RoomOffer()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600064F")]
		[Cpp2IlInjected.Address(RVA = "0x771B4E0", Offset = "0x771A8E0", VA = "0x18771B4E0")]
		public RoomOffer(Guid originId, long roomId, string name, string description, string imageName, int price, bool hasDynamicPrice, int? minimumDynamicPrice, int? maximumDynamicPrice, int? maxNumPurchasesPerPlayer, int? maxCountPerPurchase, List<RoomOfferItemMappingDTO> itemMappings, [Optional] DateTime createdAt, [Optional] DateTime modifiedAt, [Optional] Guid? priceUnitOriginId)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000650")]
		[Cpp2IlInjected.Address(RVA = "0x771B180", Offset = "0x771A580", VA = "0x18771B180")]
		private RoomOfferType ACFTRPKIIIB()
		{
			return default(RoomOfferType);
		}

		[Cpp2IlInjected.Token(Token = "0x6000651")]
		[Cpp2IlInjected.Address(RVA = "0x771B1F0", Offset = "0x771A5F0", VA = "0x18771B1F0")]
		private Dictionary<Guid, int> SDNLAVIVTDA(IReadOnlyList<RoomOfferItemMappingDTO> a)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000E7")]
	[Utf8JsonSerializable]
	public class RoomOfferIdDTO
	{
		[Cpp2IlInjected.Token(Token = "0x170002D6")]
		public Guid OriginId
		{
			[Cpp2IlInjected.Token(Token = "0x6000652")]
			[Cpp2IlInjected.Address(RVA = "0xBAF500", Offset = "0xBAE900", VA = "0x180BAF500")]
			[CompilerGenerated]
			get
			{
				return default(Guid);
			}
			[Cpp2IlInjected.Token(Token = "0x6000653")]
			[Cpp2IlInjected.Address(RVA = "0xBAF520", Offset = "0xBAE920", VA = "0x180BAF520")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170002D7")]
		public long RoomId
		{
			[Cpp2IlInjected.Token(Token = "0x6000654")]
			[Cpp2IlInjected.Address(RVA = "0xAAB1C0", Offset = "0xAAA5C0", VA = "0x180AAB1C0")]
			[CompilerGenerated]
			get
			{
				return default(long);
			}
			[Cpp2IlInjected.Token(Token = "0x6000655")]
			[Cpp2IlInjected.Address(RVA = "0xB30430", Offset = "0xB2F830", VA = "0x180B30430")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000656")]
		[Cpp2IlInjected.Address(RVA = "0xAAC8E0", Offset = "0xAABCE0", VA = "0x180AAC8E0")]
		public RoomOfferIdDTO()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000E8")]
	[Utf8JsonSerializable]
	public class RoomOfferReplicationDTO : RoomOffer
	{
		[Cpp2IlInjected.Token(Token = "0x170002D8")]
		public Guid RoomOfferId
		{
			[Cpp2IlInjected.Token(Token = "0x6000657")]
			[Cpp2IlInjected.Address(RVA = "0xFB3C50", Offset = "0xFB3050", VA = "0x180FB3C50")]
			[CompilerGenerated]
			get
			{
				return default(Guid);
			}
			[Cpp2IlInjected.Token(Token = "0x6000658")]
			[Cpp2IlInjected.Address(RVA = "0x771B170", Offset = "0x771A570", VA = "0x18771B170")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170002D9")]
		public Guid? PriceUnitId
		{
			[Cpp2IlInjected.Token(Token = "0x6000659")]
			[Cpp2IlInjected.Address(RVA = "0x771B130", Offset = "0x771A530", VA = "0x18771B130")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600065A")]
			[Cpp2IlInjected.Address(RVA = "0x771B150", Offset = "0x771A550", VA = "0x18771B150")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600065B")]
		[Cpp2IlInjected.Address(RVA = "0xAAC8E0", Offset = "0xAABCE0", VA = "0x180AAC8E0")]
		public RoomOfferReplicationDTO()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000E9")]
	[Utf8JsonSerializable]
	public class RoomOfferCreateOrUpdateRequestDTO
	{
		[Cpp2IlInjected.Token(Token = "0x170002DA")]
		public string Name
		{
			[Cpp2IlInjected.Token(Token = "0x600065C")]
			[Cpp2IlInjected.Address(RVA = "0xAA5FB0", Offset = "0xAA53B0", VA = "0x180AA5FB0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600065D")]
			[Cpp2IlInjected.Address(RVA = "0xAA5FC0", Offset = "0xAA53C0", VA = "0x180AA5FC0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170002DB")]
		public string? Description
		{
			[Cpp2IlInjected.Token(Token = "0x600065E")]
			[Cpp2IlInjected.Address(RVA = "0xAAA880", Offset = "0xAA9C80", VA = "0x180AAA880")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600065F")]
			[Cpp2IlInjected.Address(RVA = "0xAAA120", Offset = "0xAA9520", VA = "0x180AAA120")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170002DC")]
		public string? ImageName
		{
			[Cpp2IlInjected.Token(Token = "0x6000660")]
			[Cpp2IlInjected.Address(RVA = "0xAAB1C0", Offset = "0xAAA5C0", VA = "0x180AAB1C0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000661")]
			[Cpp2IlInjected.Address(RVA = "0xAA67C0", Offset = "0xAA5BC0", VA = "0x180AA67C0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170002DD")]
		public int Price
		{
			[Cpp2IlInjected.Token(Token = "0x6000662")]
			[Cpp2IlInjected.Address(RVA = "0xAAB1A0", Offset = "0xAAA5A0", VA = "0x180AAB1A0")]
			[CompilerGenerated]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x6000663")]
			[Cpp2IlInjected.Address(RVA = "0xAAB1B0", Offset = "0xAAA5B0", VA = "0x180AAB1B0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170002DE")]
		public bool HasDynamicPrice
		{
			[Cpp2IlInjected.Token(Token = "0x6000664")]
			[Cpp2IlInjected.Address(RVA = "0x17F0050", Offset = "0x17EF450", VA = "0x1817F0050")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000665")]
			[Cpp2IlInjected.Address(RVA = "0xD836D0", Offset = "0xD82AD0", VA = "0x180D836D0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170002DF")]
		public int? MinimumDynamicPrice
		{
			[Cpp2IlInjected.Token(Token = "0x6000666")]
			[Cpp2IlInjected.Address(RVA = "0xAAA140", Offset = "0xAA9540", VA = "0x180AAA140")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000667")]
			[Cpp2IlInjected.Address(RVA = "0xAAA860", Offset = "0xAA9C60", VA = "0x180AAA860")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170002E0")]
		public int? MaximumDynamicPrice
		{
			[Cpp2IlInjected.Token(Token = "0x6000668")]
			[Cpp2IlInjected.Address(RVA = "0xAAA030", Offset = "0xAA9430", VA = "0x180AAA030")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000669")]
			[Cpp2IlInjected.Address(RVA = "0xAAF810", Offset = "0xAAEC10", VA = "0x180AAF810")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170002E1")]
		public int? MaxNumPurchasesPerPlayer
		{
			[Cpp2IlInjected.Token(Token = "0x600066A")]
			[Cpp2IlInjected.Address(RVA = "0xAAA810", Offset = "0xAA9C10", VA = "0x180AAA810")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600066B")]
			[Cpp2IlInjected.Address(RVA = "0xCDACA0", Offset = "0xCDA0A0", VA = "0x180CDACA0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170002E2")]
		public int? MaxCountPerPurchase
		{
			[Cpp2IlInjected.Token(Token = "0x600066C")]
			[Cpp2IlInjected.Address(RVA = "0xAAA160", Offset = "0xAA9560", VA = "0x180AAA160")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600066D")]
			[Cpp2IlInjected.Address(RVA = "0x10D7F70", Offset = "0x10D7370", VA = "0x1810D7F70")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170002E3")]
		public List<RoomOfferItemMappingDTO> ItemMappings
		{
			[Cpp2IlInjected.Token(Token = "0x600066E")]
			[Cpp2IlInjected.Address(RVA = "0xAA3370", Offset = "0xAA2770", VA = "0x180AA3370")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600066F")]
			[Cpp2IlInjected.Address(RVA = "0xAA3390", Offset = "0xAA2790", VA = "0x180AA3390")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170002E4")]
		public Guid? PriceUnitId
		{
			[Cpp2IlInjected.Token(Token = "0x6000670")]
			[Cpp2IlInjected.Address(RVA = "0x771AE90", Offset = "0x771A290", VA = "0x18771AE90")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000671")]
			[Cpp2IlInjected.Address(RVA = "0x771AEB0", Offset = "0x771A2B0", VA = "0x18771AEB0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170002E5")]
		public Guid? OriginId
		{
			[Cpp2IlInjected.Token(Token = "0x6000672")]
			[Cpp2IlInjected.Address(RVA = "0x5F283A0", Offset = "0x5F277A0", VA = "0x185F283A0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000673")]
			[Cpp2IlInjected.Address(RVA = "0x5F2DA50", Offset = "0x5F2CE50", VA = "0x185F2DA50")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170002E6")]
		public bool AllowRename
		{
			[Cpp2IlInjected.Token(Token = "0x6000674")]
			[Cpp2IlInjected.Address(RVA = "0x11F4BC0", Offset = "0x11F3FC0", VA = "0x1811F4BC0")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000675")]
			[Cpp2IlInjected.Address(RVA = "0x11F5EB0", Offset = "0x11F52B0", VA = "0x1811F5EB0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000676")]
		[Cpp2IlInjected.Address(RVA = "0xAAC8E0", Offset = "0xAABCE0", VA = "0x180AAC8E0")]
		public RoomOfferCreateOrUpdateRequestDTO()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000EA")]
	[Utf8JsonSerializable]
	public class RoomOfferItemMappingDTO
	{
		[Cpp2IlInjected.Token(Token = "0x170002E7")]
		public RoomOfferItemType ItemType
		{
			[Cpp2IlInjected.Token(Token = "0x6000677")]
			[Cpp2IlInjected.Address(RVA = "0xAF8E00", Offset = "0xAF8200", VA = "0x180AF8E00")]
			[CompilerGenerated]
			get
			{
				return default(RoomOfferItemType);
			}
			[Cpp2IlInjected.Token(Token = "0x6000678")]
			[Cpp2IlInjected.Address(RVA = "0xB22470", Offset = "0xB21870", VA = "0x180B22470")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170002E8")]
		public Guid ItemOriginId
		{
			[Cpp2IlInjected.Token(Token = "0x6000679")]
			[Cpp2IlInjected.Address(RVA = "0x18ECC50", Offset = "0x18EC050", VA = "0x1818ECC50")]
			[CompilerGenerated]
			get
			{
				return default(Guid);
			}
			[Cpp2IlInjected.Token(Token = "0x600067A")]
			[Cpp2IlInjected.Address(RVA = "0x5E206F0", Offset = "0x5E1FAF0", VA = "0x185E206F0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170002E9")]
		public int Count
		{
			[Cpp2IlInjected.Token(Token = "0x600067B")]
			[Cpp2IlInjected.Address(RVA = "0xACC3D0", Offset = "0xACB7D0", VA = "0x180ACC3D0")]
			[CompilerGenerated]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x600067C")]
			[Cpp2IlInjected.Address(RVA = "0xBE18B0", Offset = "0xBE0CB0", VA = "0x180BE18B0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600067D")]
		[Cpp2IlInjected.Address(RVA = "0xAAC8E0", Offset = "0xAABCE0", VA = "0x180AAC8E0")]
		public RoomOfferItemMappingDTO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600067E")]
		[Cpp2IlInjected.Address(RVA = "0x771AF80", Offset = "0x771A380", VA = "0x18771AF80")]
		public RoomOfferItemMappingDTO(Guid itemOriginId, RoomOfferItemType type, int count)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000EB")]
	[Utf8JsonSerializable]
	public class RoomOfferLastPurchaseDTO
	{
		[Cpp2IlInjected.Token(Token = "0x170002EA")]
		public Guid RoomOfferOriginId
		{
			[Cpp2IlInjected.Token(Token = "0x600067F")]
			[Cpp2IlInjected.Address(RVA = "0xBAF500", Offset = "0xBAE900", VA = "0x180BAF500")]
			[CompilerGenerated]
			get
			{
				return default(Guid);
			}
			[Cpp2IlInjected.Token(Token = "0x6000680")]
			[Cpp2IlInjected.Address(RVA = "0xBAF520", Offset = "0xBAE920", VA = "0x180BAF520")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170002EB")]
		public string Name
		{
			[Cpp2IlInjected.Token(Token = "0x6000681")]
			[Cpp2IlInjected.Address(RVA = "0xAAB1C0", Offset = "0xAAA5C0", VA = "0x180AAB1C0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000682")]
			[Cpp2IlInjected.Address(RVA = "0xAA67C0", Offset = "0xAA5BC0", VA = "0x180AA67C0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170002EC")]
		public int PurchasePrice
		{
			[Cpp2IlInjected.Token(Token = "0x6000683")]
			[Cpp2IlInjected.Address(RVA = "0xAAB1A0", Offset = "0xAAA5A0", VA = "0x180AAB1A0")]
			[CompilerGenerated]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x6000684")]
			[Cpp2IlInjected.Address(RVA = "0xAAB1B0", Offset = "0xAAA5B0", VA = "0x180AAB1B0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170002ED")]
		public DateTime PurchaseDate
		{
			[Cpp2IlInjected.Token(Token = "0x6000685")]
			[Cpp2IlInjected.Address(RVA = "0xAAA140", Offset = "0xAA9540", VA = "0x180AAA140")]
			[CompilerGenerated]
			get
			{
				return default(DateTime);
			}
			[Cpp2IlInjected.Token(Token = "0x6000686")]
			[Cpp2IlInjected.Address(RVA = "0xAAA860", Offset = "0xAA9C60", VA = "0x180AAA860")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170002EE")]
		public int Version
		{
			[Cpp2IlInjected.Token(Token = "0x6000687")]
			[Cpp2IlInjected.Address(RVA = "0xAD4020", Offset = "0xAD3420", VA = "0x180AD4020")]
			[CompilerGenerated]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x6000688")]
			[Cpp2IlInjected.Address(RVA = "0xB10400", Offset = "0xB0F800", VA = "0x180B10400")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000689")]
		[Cpp2IlInjected.Address(RVA = "0x771AFD0", Offset = "0x771A3D0", VA = "0x18771AFD0")]
		public RoomOfferLastPurchaseDTO(Guid roomOfferOriginId, string name, int purchasePrice, DateTime purchaseDate, int version)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600068A")]
		[Cpp2IlInjected.Address(RVA = "0xAAC8E0", Offset = "0xAABCE0", VA = "0x180AAC8E0")]
		public RoomOfferLastPurchaseDTO()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000EC")]
	[Utf8JsonSerializable]
	public class RoomOfferPurchaseCountDTO
	{
		[Cpp2IlInjected.Token(Token = "0x170002EF")]
		public Guid RoomOfferOriginId
		{
			[Cpp2IlInjected.Token(Token = "0x600068B")]
			[Cpp2IlInjected.Address(RVA = "0xBAF500", Offset = "0xBAE900", VA = "0x180BAF500")]
			[CompilerGenerated]
			get
			{
				return default(Guid);
			}
			[Cpp2IlInjected.Token(Token = "0x600068C")]
			[Cpp2IlInjected.Address(RVA = "0xBAF520", Offset = "0xBAE920", VA = "0x180BAF520")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170002F0")]
		public int NumOffersPurchased
		{
			[Cpp2IlInjected.Token(Token = "0x600068D")]
			[Cpp2IlInjected.Address(RVA = "0xAB5660", Offset = "0xAB4A60", VA = "0x180AB5660")]
			[CompilerGenerated]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x600068E")]
			[Cpp2IlInjected.Address(RVA = "0xB07AB0", Offset = "0xB06EB0", VA = "0x180B07AB0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600068F")]
		[Cpp2IlInjected.Address(RVA = "0xAAC8E0", Offset = "0xAABCE0", VA = "0x180AAC8E0")]
		public RoomOfferPurchaseCountDTO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000690")]
		[Cpp2IlInjected.Address(RVA = "0x4150280", Offset = "0x414F680", VA = "0x184150280")]
		public RoomOfferPurchaseCountDTO(Guid roomOfferOriginId, int numOffersPurchased)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000ED")]
	[Utf8JsonSerializable]
	public class RoomOfferPurchaseRequestDTO
	{
		[Cpp2IlInjected.Token(Token = "0x170002F1")]
		public int NumOffersPurchased
		{
			[Cpp2IlInjected.Token(Token = "0x6000693")]
			[Cpp2IlInjected.Address(RVA = "0xAA3110", Offset = "0xAA2510", VA = "0x180AA3110")]
			[CompilerGenerated]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x6000694")]
			[Cpp2IlInjected.Address(RVA = "0xAAB1D0", Offset = "0xAAA5D0", VA = "0x180AAB1D0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170002F2")]
		public Guid TransactionId
		{
			[Cpp2IlInjected.Token(Token = "0x6000695")]
			[Cpp2IlInjected.Address(RVA = "0x18ECC50", Offset = "0x18EC050", VA = "0x1818ECC50")]
			[CompilerGenerated]
			get
			{
				return default(Guid);
			}
			[Cpp2IlInjected.Token(Token = "0x6000696")]
			[Cpp2IlInjected.Address(RVA = "0x5E206F0", Offset = "0x5E1FAF0", VA = "0x185E206F0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170002F3")]
		public int ExpectedTotalPrice
		{
			[Cpp2IlInjected.Token(Token = "0x6000697")]
			[Cpp2IlInjected.Address(RVA = "0xACC3D0", Offset = "0xACB7D0", VA = "0x180ACC3D0")]
			[CompilerGenerated]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x6000698")]
			[Cpp2IlInjected.Address(RVA = "0xBE18B0", Offset = "0xBE0CB0", VA = "0x180BE18B0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170002F4")]
		public Guid? ExpectedPriceUnitOriginId
		{
			[Cpp2IlInjected.Token(Token = "0x6000699")]
			[Cpp2IlInjected.Address(RVA = "0xCE0E00", Offset = "0xCE0200", VA = "0x180CE0E00")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600069A")]
			[Cpp2IlInjected.Address(RVA = "0x2005D30", Offset = "0x2005130", VA = "0x182005D30")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170002F5")]
		public int ExpectedRoomOfferVersion
		{
			[Cpp2IlInjected.Token(Token = "0x600069B")]
			[Cpp2IlInjected.Address(RVA = "0xAE3BC0", Offset = "0xAE2FC0", VA = "0x180AE3BC0")]
			[CompilerGenerated]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x600069C")]
			[Cpp2IlInjected.Address(RVA = "0xAE34B0", Offset = "0xAE28B0", VA = "0x180AE34B0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170002F6")]
		public Dictionary<Guid, Guid?> ConcurrencyCodeByItemOriginIdMap
		{
			[Cpp2IlInjected.Token(Token = "0x600069D")]
			[Cpp2IlInjected.Address(RVA = "0xAAA810", Offset = "0xAA9C10", VA = "0x180AAA810")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600069E")]
			[Cpp2IlInjected.Address(RVA = "0xAAA840", Offset = "0xAA9C40", VA = "0x180AAA840")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000691")]
		[Cpp2IlInjected.Address(RVA = "0xAAC8E0", Offset = "0xAABCE0", VA = "0x180AAC8E0")]
		public RoomOfferPurchaseRequestDTO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000692")]
		[Cpp2IlInjected.Address(RVA = "0x771B040", Offset = "0x771A440", VA = "0x18771B040")]
		public RoomOfferPurchaseRequestDTO(int numOffersPurchased, Guid transactionId, int expectedTotalPrice, Guid? expectedPriceUnitOriginId, int expectedRoomOfferVersion, Dictionary<Guid, Guid?> concurrencyCodeByItemOriginIdMap)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000EE")]
	[Utf8JsonSerializable]
	public class RoomOfferPurchaseResponseDTO
	{
		[Cpp2IlInjected.Token(Token = "0x170002F7")]
		public RoomOfferPurchaseOperationResult OperationResult
		{
			[Cpp2IlInjected.Token(Token = "0x60006A1")]
			[Cpp2IlInjected.Address(RVA = "0xAF8E00", Offset = "0xAF8200", VA = "0x180AF8E00")]
			[CompilerGenerated]
			get
			{
				return default(RoomOfferPurchaseOperationResult);
			}
			[Cpp2IlInjected.Token(Token = "0x60006A2")]
			[Cpp2IlInjected.Address(RVA = "0xB22470", Offset = "0xB21870", VA = "0x180B22470")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170002F8")]
		public UpdateResponseTypes? BalanceUpdateResult
		{
			[Cpp2IlInjected.Token(Token = "0x60006A3")]
			[Cpp2IlInjected.Address(RVA = "0x10D2A50", Offset = "0x10D1E50", VA = "0x1810D2A50")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60006A4")]
			[Cpp2IlInjected.Address(RVA = "0x10D3E30", Offset = "0x10D3230", VA = "0x1810D3E30")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170002F9")]
		public BalanceResponseDTO TokenBalanceResponse
		{
			[Cpp2IlInjected.Token(Token = "0x60006A5")]
			[Cpp2IlInjected.Address(RVA = "0xAAB1C0", Offset = "0xAAA5C0", VA = "0x180AAB1C0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60006A6")]
			[Cpp2IlInjected.Address(RVA = "0xAA67C0", Offset = "0xAA5BC0", VA = "0x180AA67C0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170002FA")]
		public List<PlayerRoomInventoryItemDTO> PlayerRoomInventoryItems
		{
			[Cpp2IlInjected.Token(Token = "0x60006A7")]
			[Cpp2IlInjected.Address(RVA = "0xAAA820", Offset = "0xAA9C20", VA = "0x180AAA820")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60006A8")]
			[Cpp2IlInjected.Address(RVA = "0xAA67D0", Offset = "0xAA5BD0", VA = "0x180AA67D0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600069F")]
		[Cpp2IlInjected.Address(RVA = "0xAAC8E0", Offset = "0xAABCE0", VA = "0x180AAC8E0")]
		public RoomOfferPurchaseResponseDTO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60006A0")]
		[Cpp2IlInjected.Address(RVA = "0x771B0C0", Offset = "0x771A4C0", VA = "0x18771B0C0")]
		public RoomOfferPurchaseResponseDTO(RoomOfferPurchaseOperationResult operationResult, UpdateResponseTypes? balanceUpdateResult, BalanceResponseDTO tokenBalanceResponse, List<PlayerRoomInventoryItemDTO> playerRoomInventoryItems)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000EF")]
	public enum RoomOfferItemType : byte
	{
		[Cpp2IlInjected.Token(Token = "0x4000467")]
		Unset,
		[Cpp2IlInjected.Token(Token = "0x4000468")]
		RoomInventoryItem
	}
	[Cpp2IlInjected.Token(Token = "0x20000F0")]
	public enum RoomOfferPurchaseOperationResult : byte
	{
		[Cpp2IlInjected.Token(Token = "0x400046A")]
		Success = 0,
		[Cpp2IlInjected.Token(Token = "0x400046B")]
		ConcurrencyCodeMismatch = 1,
		[Cpp2IlInjected.Token(Token = "0x400046C")]
		RoomOfferDoesNotExist = 2,
		[Cpp2IlInjected.Token(Token = "0x400046D")]
		InvalidRequest = 3,
		[Cpp2IlInjected.Token(Token = "0x400046E")]
		AccountIdIsInvalid = 4,
		[Cpp2IlInjected.Token(Token = "0x400046F")]
		PlayerIsP2PBuyingRestricted = 5,
		[Cpp2IlInjected.Token(Token = "0x4000470")]
		ExpectedOfferTotalPriceMismatch = 6,
		[Cpp2IlInjected.Token(Token = "0x4000471")]
		ExpectedOfferVersionMismatch = 7,
		[Cpp2IlInjected.Token(Token = "0x4000472")]
		InsufficientBalance = 8,
		[Cpp2IlInjected.Token(Token = "0x4000473")]
		OfferUnderModeration = 9,
		[Cpp2IlInjected.Token(Token = "0x4000474")]
		InvalidExpectedTotalPrice = 10,
		[Cpp2IlInjected.Token(Token = "0x4000475")]
		InvalidExpectedOfferVersion = 11,
		[Cpp2IlInjected.Token(Token = "0x4000476")]
		CannotPurchaseMoreThanPerPlayerLimit = 12,
		[Cpp2IlInjected.Token(Token = "0x4000477")]
		InvalidExpectedPriceUnit = 13,
		[Cpp2IlInjected.Token(Token = "0x4000478")]
		InsufficientInventoryItems = 14,
		[Cpp2IlInjected.Token(Token = "0x4000479")]
		InvalidDynamicPriceSettings = 15,
		[Cpp2IlInjected.Token(Token = "0x400047A")]
		InvalidDynamicPrice = 16,
		[Cpp2IlInjected.Token(Token = "0x400047B")]
		NoConcurrencyCodesForInventoryItem = 100,
		[Cpp2IlInjected.Token(Token = "0x400047C")]
		UnexpectedOfferItemType = 101,
		[Cpp2IlInjected.Token(Token = "0x400047D")]
		FeatureDisabled = 254,
		[Cpp2IlInjected.Token(Token = "0x400047E")]
		UnknownError = 255
	}
	[Cpp2IlInjected.Token(Token = "0x20000F1")]
	public enum RoomOfferType : byte
	{
		[Cpp2IlInjected.Token(Token = "0x4000480")]
		Default,
		[Cpp2IlInjected.Token(Token = "0x4000481")]
		OneTimePurchase,
		[Cpp2IlInjected.Token(Token = "0x4000482")]
		BulkPurchase
	}
	[Cpp2IlInjected.Token(Token = "0x20000F2")]
	public interface SDAXBTWTELN
	{
		[Cpp2IlInjected.Token(Token = "0x4000483")]
		static KBLPOZGJAAH<RoomOffer> OCJDEWLRPHJ;

		[Cpp2IlInjected.Token(Token = "0x4000484")]
		static KBLPOZGJAAH<RoomOffer> VERBBXJIUFY;

		[Cpp2IlInjected.Token(Token = "0x4000485")]
		static KBLPOZGJAAH<Guid> VIAEAXWAOHE;

		[Cpp2IlInjected.Token(Token = "0x60006A9")]
		[Cpp2IlInjected.Address(Slot = "0")]
		Task<RecNetResult<RoomOffer?>?>? RCSNHIYAMNH(Guid? a, long b, string name, string? c, string? d, int e, bool f, int g, int h, RoomOfferType i, [Optional] Dictionary<Guid, int>? j, [Optional] Guid? k, bool l = false, [Optional] CancellationToken m);

		[Cpp2IlInjected.Token(Token = "0x60006AA")]
		[Cpp2IlInjected.Address(Slot = "1")]
		Task<RecNetResult<RoomOffer?>?>? AZBQJJVQJLU(Guid a, long b, string name, string? c, string? d, int e, bool f, int g, int h, RoomOfferType i, [Optional] Dictionary<Guid, int>? j, [Optional] Guid? k, [Optional] CancellationToken l);

		[Cpp2IlInjected.Token(Token = "0x60006AB")]
		[Cpp2IlInjected.Address(Slot = "2")]
		Task<RecNetResult> ZAUAQBLFCQQ(Guid a, long b, [Optional] CancellationToken c);

		[Cpp2IlInjected.Token(Token = "0x60006AC")]
		[Cpp2IlInjected.Address(Slot = "3")]
		Task<List<RoomOffer>> PUHENFSHLYW(long a, [Optional] CancellationToken b);

		[Cpp2IlInjected.Token(Token = "0x60006AD")]
		[Cpp2IlInjected.Address(Slot = "4")]
		Task<RecNetResult<List<RoomOfferPurchaseCountDTO>>> GVBWMQMQXDE(long a, [Optional] CancellationToken b);

		[Cpp2IlInjected.Token(Token = "0x60006AE")]
		[Cpp2IlInjected.Address(Slot = "5")]
		Task<RecNetResult<List<RoomOfferLastPurchaseDTO>>> FMGJHNMGPHW(long a, [Optional] CancellationToken b);

		[Cpp2IlInjected.Token(Token = "0x60006AF")]
		[Cpp2IlInjected.Address(Slot = "6")]
		Task<RoomOfferPurchaseResponseDTO> ENDLBYELUVC(Guid a, long b, int c, int d, Guid? e, int f, Dictionary<Guid, Guid?> g, [Optional] CancellationToken h);

		[Cpp2IlInjected.Token(Token = "0x60006B0")]
		[Cpp2IlInjected.Address(RVA = "0x771B880", Offset = "0x771AC80", VA = "0x18771B880")]
		static SDAXBTWTELN()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000F3")]
	[Utf8JsonSerializable]
	public class RoomEconConfigDTO
	{
		[Cpp2IlInjected.Token(Token = "0x170002FB")]
		public long RoomId
		{
			[Cpp2IlInjected.Token(Token = "0x60006B1")]
			[Cpp2IlInjected.Address(RVA = "0xAA5FB0", Offset = "0xAA53B0", VA = "0x180AA5FB0")]
			[CompilerGenerated]
			get
			{
				return default(long);
			}
			[Cpp2IlInjected.Token(Token = "0x60006B2")]
			[Cpp2IlInjected.Address(RVA = "0xB96550", Offset = "0xB95950", VA = "0x180B96550")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170002FC")]
		public bool EnableSortingTabs
		{
			[Cpp2IlInjected.Token(Token = "0x60006B3")]
			[Cpp2IlInjected.Address(RVA = "0xBC19C0", Offset = "0xBC0DC0", VA = "0x180BC19C0")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x60006B4")]
			[Cpp2IlInjected.Address(RVA = "0xAA7380", Offset = "0xAA6780", VA = "0x180AA7380")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60006B5")]
		[Cpp2IlInjected.Address(RVA = "0xAAC8E0", Offset = "0xAABCE0", VA = "0x180AAC8E0")]
		public RoomEconConfigDTO()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000F4")]
	public interface ASVUKTLIULX
	{
		[Cpp2IlInjected.Token(Token = "0x60006B6")]
		[Cpp2IlInjected.Address(Slot = "0")]
		Task<RoomEconConfigDTO> LTTQUJVFOLJ(long a, [Optional] CancellationToken b);

		[Cpp2IlInjected.Token(Token = "0x60006B7")]
		[Cpp2IlInjected.Address(Slot = "1")]
		Task<RecNetResult> QTEOMHXCMCH(long a, bool b, [Optional] CancellationToken c);
	}
	[Cpp2IlInjected.Token(Token = "0x20000F5")]
	[Utf8JsonSerializableGeneric]
	public class WBHZCYWOEDT<a>
	{
		[Cpp2IlInjected.Token(Token = "0x170002FD")]
		public long HPAYHFIALWK
		{
			[Cpp2IlInjected.Token(Token = "0x60006B8")]
			[Cpp2IlInjected.Address(RVA = "0xAA5FB0", Offset = "0xAA53B0", VA = "0x180AA5FB0")]
			[CompilerGenerated]
			get
			{
				return default(long);
			}
			[Cpp2IlInjected.Token(Token = "0x60006B9")]
			[Cpp2IlInjected.Address(RVA = "0xB96550", Offset = "0xB95950", VA = "0x180B96550")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170002FE")]
		public CurrencyType RIDMZKIADUJ
		{
			[Cpp2IlInjected.Token(Token = "0x60006BA")]
			[Cpp2IlInjected.Address(RVA = "0xAAC980", Offset = "0xAABD80", VA = "0x180AAC980")]
			[CompilerGenerated]
			get
			{
				return default(CurrencyType);
			}
			[Cpp2IlInjected.Token(Token = "0x60006BB")]
			[Cpp2IlInjected.Address(RVA = "0xAB2F40", Offset = "0xAB2340", VA = "0x180AB2F40")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170002FF")]
		public StorefrontBalanceType VCBXOWXXFWK
		{
			[Cpp2IlInjected.Token(Token = "0x60006BC")]
			[Cpp2IlInjected.Address(RVA = "0x12E70B0", Offset = "0x12E64B0", VA = "0x1812E70B0")]
			[CompilerGenerated]
			get
			{
				return default(StorefrontBalanceType);
			}
			[Cpp2IlInjected.Token(Token = "0x60006BD")]
			[Cpp2IlInjected.Address(RVA = "0x12E70C0", Offset = "0x12E64C0", VA = "0x1812E70C0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000300")]
		public a VQVHWHVOHGG
		{
			[Cpp2IlInjected.Token(Token = "0x60006BE")]
			[Cpp2IlInjected.Address(RVA = "0xAAB1C0", Offset = "0xAAA5C0", VA = "0x180AAB1C0")]
			[CompilerGenerated]
			get
			{
				return (a)null;
			}
			[Cpp2IlInjected.Token(Token = "0x60006BF")]
			[Cpp2IlInjected.Address(RVA = "0xAA67C0", Offset = "0xAA5BC0", VA = "0x180AA67C0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60006C0")]
		[Cpp2IlInjected.Address(RVA = "0xAAC8E0", Offset = "0xAABCE0", VA = "0x180AAC8E0")]
		public WBHZCYWOEDT()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000F6")]
	[Utf8JsonSerializableGeneric]
	public class ZQVRMSJCNUB<a>
	{
		[Cpp2IlInjected.Token(Token = "0x17000301")]
		public long HPAYHFIALWK
		{
			[Cpp2IlInjected.Token(Token = "0x60006C1")]
			[Cpp2IlInjected.Address(RVA = "0xAA5FB0", Offset = "0xAA53B0", VA = "0x180AA5FB0")]
			[CompilerGenerated]
			get
			{
				return default(long);
			}
			[Cpp2IlInjected.Token(Token = "0x60006C2")]
			[Cpp2IlInjected.Address(RVA = "0xB96550", Offset = "0xB95950", VA = "0x180B96550")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000302")]
		public CurrencyType RIDMZKIADUJ
		{
			[Cpp2IlInjected.Token(Token = "0x60006C3")]
			[Cpp2IlInjected.Address(RVA = "0xAAC980", Offset = "0xAABD80", VA = "0x180AAC980")]
			[CompilerGenerated]
			get
			{
				return default(CurrencyType);
			}
			[Cpp2IlInjected.Token(Token = "0x60006C4")]
			[Cpp2IlInjected.Address(RVA = "0xAB2F40", Offset = "0xAB2340", VA = "0x180AB2F40")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000303")]
		public StorefrontBalanceType VCBXOWXXFWK
		{
			[Cpp2IlInjected.Token(Token = "0x60006C5")]
			[Cpp2IlInjected.Address(RVA = "0x12E70B0", Offset = "0x12E64B0", VA = "0x1812E70B0")]
			[CompilerGenerated]
			get
			{
				return default(StorefrontBalanceType);
			}
			[Cpp2IlInjected.Token(Token = "0x60006C6")]
			[Cpp2IlInjected.Address(RVA = "0x12E70C0", Offset = "0x12E64C0", VA = "0x1812E70C0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000304")]
		public List<a> VQVHWHVOHGG
		{
			[Cpp2IlInjected.Token(Token = "0x60006C7")]
			[Cpp2IlInjected.Address(RVA = "0xAAB1C0", Offset = "0xAAA5C0", VA = "0x180AAB1C0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60006C8")]
			[Cpp2IlInjected.Address(RVA = "0xAA67C0", Offset = "0xAA5BC0", VA = "0x180AA67C0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60006C9")]
		[Cpp2IlInjected.Address(RVA = "0xAAC8E0", Offset = "0xAABCE0", VA = "0x180AAC8E0")]
		public ZQVRMSJCNUB()
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x20000F7")]
	[Utf8JsonSerializableGeneric]
	public class BalanceUpdateResponseDTO<DataTypeDTO> : BalanceResponseDTO, DURPPUIUDDT where DataTypeDTO : new()
	{
		[Cpp2IlInjected.Token(Token = "0x20000F8")]
		[Utf8JsonSerializableGeneric]
		public class KGMPTSKEKKA : DURPPUIUDDT
		{
			[StructLayout((LayoutKind)3)]
			[Cpp2IlInjected.Token(Token = "0x20000F9")]
			[CompilerGenerated]
			private struct <OnDeserializedAsync>d__8 : IAsyncStateMachine
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x4000493")]
				public int <>1__state;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x4000494")]
				public AsyncTaskMethodBuilder <>t__builder;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x4000495")]
				public KGMPTSKEKKA <>4__this;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x4000496")]
				private ZTDEQBSEMSX <obj1>5__2;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x4000497")]
				private object <>u__1;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x4000498")]
				private ConfiguredTaskAwaitable.ConfiguredTaskAwaiter <>u__2;

				[Cpp2IlInjected.Token(Token = "0x60006D4")]
				[Cpp2IlInjected.Address(RVA = "0x50B67A0", Offset = "0x50B5BA0", VA = "0x1850B67A0", Slot = "4")]
				private void MoveNext()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60006D5")]
				[Cpp2IlInjected.Address(RVA = "0x50B7660", Offset = "0x50B6A60", VA = "0x1850B7660", Slot = "5")]
				[DebuggerHidden]
				private void SetStateMachine(IAsyncStateMachine stateMachine)
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000306")]
			public UpdateResponseTypes IPQUBYLOTEA
			{
				[Cpp2IlInjected.Token(Token = "0x60006CE")]
				[Cpp2IlInjected.Address(RVA = "0xAA3110", Offset = "0xAA2510", VA = "0x180AA3110")]
				[CompilerGenerated]
				get
				{
					return default(UpdateResponseTypes);
				}
				[Cpp2IlInjected.Token(Token = "0x60006CF")]
				[Cpp2IlInjected.Address(RVA = "0xAAB1D0", Offset = "0xAAA5D0", VA = "0x180AAB1D0")]
				[CompilerGenerated]
				set
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000307")]
			public DataTypeDTO VQVHWHVOHGG
			{
				[Cpp2IlInjected.Token(Token = "0x60006D0")]
				[Cpp2IlInjected.Address(RVA = "0xAAA880", Offset = "0xAA9C80", VA = "0x180AAA880")]
				[CompilerGenerated]
				get
				{
					return (DataTypeDTO)null;
				}
				[Cpp2IlInjected.Token(Token = "0x60006D1")]
				[Cpp2IlInjected.Address(RVA = "0xAAA120", Offset = "0xAA9520", VA = "0x180AAA120")]
				[CompilerGenerated]
				set
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x60006D2")]
			[Cpp2IlInjected.Address(RVA = "0x5218B30", Offset = "0x5217F30", VA = "0x185218B30", Slot = "4")]
			[AsyncStateMachine(typeof(BalanceUpdateResponseDTO<>.KGMPTSKEKKA.<OnDeserializedAsync>d__8))]
			public Task NLICNVNCYRU()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x60006D3")]
			[Cpp2IlInjected.Address(RVA = "0xAAC8E0", Offset = "0xAABCE0", VA = "0x180AAC8E0")]
			public KGMPTSKEKKA()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000305")]
		public List<KGMPTSKEKKA> BalanceUpdates
		{
			[Cpp2IlInjected.Token(Token = "0x60006CA")]
			[Cpp2IlInjected.Address(RVA = "0xAAB1C0", Offset = "0xAAA5C0", VA = "0x180AAB1C0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60006CB")]
			[Cpp2IlInjected.Address(RVA = "0xAA67C0", Offset = "0xAA5BC0", VA = "0x180AA67C0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60006CC")]
		[Cpp2IlInjected.Address(RVA = "0x5ACADD0", Offset = "0x5ACA1D0", VA = "0x185ACADD0", Slot = "4")]
		public Task NLICNVNCYRU()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60006CD")]
		[Cpp2IlInjected.Address(RVA = "0xACE190", Offset = "0xACD590", VA = "0x180ACE190")]
		public BalanceUpdateResponseDTO()
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x20000FA")]
	[Utf8JsonSerializableGeneric]
	public class PurchaseBalanceUpdateResponseDTO<DataTypeDTO> : BalanceResponseDTO, DURPPUIUDDT where DataTypeDTO : new()
	{
		[Cpp2IlInjected.Token(Token = "0x20000FB")]
		[Utf8JsonSerializableGeneric]
		public class KGMPTSKEKKA : DURPPUIUDDT
		{
			[StructLayout((LayoutKind)3)]
			[Cpp2IlInjected.Token(Token = "0x20000FC")]
			[CompilerGenerated]
			private struct <OnDeserializedAsync>d__8 : IAsyncStateMachine
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x400049C")]
				public int <>1__state;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x400049D")]
				public AsyncTaskMethodBuilder <>t__builder;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x400049E")]
				public KGMPTSKEKKA <>4__this;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x400049F")]
				private IEnumerable<ZTDEQBSEMSX> <list1>5__2;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x40004A0")]
				private object <>u__1;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x40004A1")]
				private ConfiguredTaskAwaitable.ConfiguredTaskAwaiter <>u__2;

				[Cpp2IlInjected.Token(Token = "0x60006E0")]
				[Cpp2IlInjected.Address(RVA = "0x50B6BC0", Offset = "0x50B5FC0", VA = "0x1850B6BC0", Slot = "4")]
				private void MoveNext()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60006E1")]
				[Cpp2IlInjected.Address(RVA = "0x50B77E0", Offset = "0x50B6BE0", VA = "0x1850B77E0", Slot = "5")]
				[DebuggerHidden]
				private void SetStateMachine(IAsyncStateMachine stateMachine)
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000309")]
			public UpdateResponseTypes IPQUBYLOTEA
			{
				[Cpp2IlInjected.Token(Token = "0x60006DA")]
				[Cpp2IlInjected.Address(RVA = "0xAA3110", Offset = "0xAA2510", VA = "0x180AA3110")]
				[CompilerGenerated]
				get
				{
					return default(UpdateResponseTypes);
				}
				[Cpp2IlInjected.Token(Token = "0x60006DB")]
				[Cpp2IlInjected.Address(RVA = "0xAAB1D0", Offset = "0xAAA5D0", VA = "0x180AAB1D0")]
				[CompilerGenerated]
				set
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700030A")]
			public List<DataTypeDTO> VQVHWHVOHGG
			{
				[Cpp2IlInjected.Token(Token = "0x60006DC")]
				[Cpp2IlInjected.Address(RVA = "0xAAA880", Offset = "0xAA9C80", VA = "0x180AAA880")]
				[CompilerGenerated]
				get
				{
					return null;
				}
				[Cpp2IlInjected.Token(Token = "0x60006DD")]
				[Cpp2IlInjected.Address(RVA = "0xAAA120", Offset = "0xAA9520", VA = "0x180AAA120")]
				[CompilerGenerated]
				set
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x60006DE")]
			[Cpp2IlInjected.Address(RVA = "0x5218A40", Offset = "0x5217E40", VA = "0x185218A40", Slot = "4")]
			[AsyncStateMachine(typeof(PurchaseBalanceUpdateResponseDTO<>.KGMPTSKEKKA.<OnDeserializedAsync>d__8))]
			public Task NLICNVNCYRU()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x60006DF")]
			[Cpp2IlInjected.Address(RVA = "0xAAC8E0", Offset = "0xAABCE0", VA = "0x180AAC8E0")]
			public KGMPTSKEKKA()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000308")]
		public List<KGMPTSKEKKA> BalanceUpdates
		{
			[Cpp2IlInjected.Token(Token = "0x60006D6")]
			[Cpp2IlInjected.Address(RVA = "0xAAB1C0", Offset = "0xAAA5C0", VA = "0x180AAB1C0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60006D7")]
			[Cpp2IlInjected.Address(RVA = "0xAA67C0", Offset = "0xAA5BC0", VA = "0x180AA67C0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60006D8")]
		[Cpp2IlInjected.Address(RVA = "0x5ACADD0", Offset = "0x5ACA1D0", VA = "0x185ACADD0", Slot = "4")]
		public Task NLICNVNCYRU()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60006D9")]
		[Cpp2IlInjected.Address(RVA = "0xACE190", Offset = "0xACD590", VA = "0x180ACE190")]
		public PurchaseBalanceUpdateResponseDTO()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000FD")]
	[Utf8JsonSerializableGenericSpecialization]
	public class PurchaseBalanceUpdateResponseDTO_GiftPackage : PurchaseBalanceUpdateResponseDTO<GiftPackage>
	{
		[Cpp2IlInjected.Token(Token = "0x60006E2")]
		[Cpp2IlInjected.Address(RVA = "0x771A890", Offset = "0x7719C90", VA = "0x18771A890")]
		public PurchaseBalanceUpdateResponseDTO_GiftPackage()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000FE")]
	[Utf8JsonSerializableGenericSpecialization]
	public class WHNKQZOEFFG : PurchaseBalanceUpdateResponseDTO<GiftPackage>.KGMPTSKEKKA
	{
		[Cpp2IlInjected.Token(Token = "0x60006E3")]
		[Cpp2IlInjected.Address(RVA = "0x7720600", Offset = "0x771FA00", VA = "0x187720600")]
		public WHNKQZOEFFG()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000FF")]
	[Utf8JsonSerializable]
	public class PurchaseItemRequestDTO
	{
		[Cpp2IlInjected.Token(Token = "0x1700030B")]
		public ItemPurchaseMethodId ItemPurchaseMethodId
		{
			[Cpp2IlInjected.Token(Token = "0x60006E4")]
			[Cpp2IlInjected.Address(RVA = "0xAA5FB0", Offset = "0xAA53B0", VA = "0x180AA5FB0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60006E5")]
			[Cpp2IlInjected.Address(RVA = "0xAA5FC0", Offset = "0xAA53C0", VA = "0x180AA5FC0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700030C")]
		public long RequestedPrice
		{
			[Cpp2IlInjected.Token(Token = "0x60006E6")]
			[Cpp2IlInjected.Address(RVA = "0xAAA880", Offset = "0xAA9C80", VA = "0x180AAA880")]
			[CompilerGenerated]
			get
			{
				return default(long);
			}
			[Cpp2IlInjected.Token(Token = "0x60006E7")]
			[Cpp2IlInjected.Address(RVA = "0x10BA780", Offset = "0x10B9B80", VA = "0x1810BA780")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700030D")]
		public GiftItemDTO? Gift
		{
			[Cpp2IlInjected.Token(Token = "0x60006E8")]
			[Cpp2IlInjected.Address(RVA = "0xAAB1C0", Offset = "0xAAA5C0", VA = "0x180AAB1C0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60006E9")]
			[Cpp2IlInjected.Address(RVA = "0xAA67C0", Offset = "0xAA5BC0", VA = "0x180AA67C0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700030E")]
		public long? CouponConsumablePlayerMappingId
		{
			[Cpp2IlInjected.Token(Token = "0x60006EA")]
			[Cpp2IlInjected.Address(RVA = "0x1146260", Offset = "0x1145660", VA = "0x181146260")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60006EB")]
			[Cpp2IlInjected.Address(RVA = "0x128B750", Offset = "0x128AB50", VA = "0x18128B750")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700030F")]
		public int DuplicateItemCount
		{
			[Cpp2IlInjected.Token(Token = "0x60006EC")]
			[Cpp2IlInjected.Address(RVA = "0xAD4020", Offset = "0xAD3420", VA = "0x180AD4020")]
			[CompilerGenerated]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x60006ED")]
			[Cpp2IlInjected.Address(RVA = "0xB10400", Offset = "0xB0F800", VA = "0x180B10400")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60006EE")]
		[Cpp2IlInjected.Address(RVA = "0x771A8D0", Offset = "0x7719CD0", VA = "0x18771A8D0")]
		public PurchaseItemRequestDTO(ItemPurchaseMethodId itemPurchaseMethodId, long requestedPrice, GiftItemDTO? gift, int duplicateItemCount = 1, [Optional] long? couponConsumablePlayerMappingId)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000100")]
	[Utf8JsonSerializable]
	public class BulkPurchaseItemRequestDTO
	{
		[Cpp2IlInjected.Token(Token = "0x17000310")]
		public List<PurchaseItemRequestDTO> PurchaseItemRequests
		{
			[Cpp2IlInjected.Token(Token = "0x60006EF")]
			[Cpp2IlInjected.Address(RVA = "0xAA5FB0", Offset = "0xAA53B0", VA = "0x180AA5FB0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60006F0")]
			[Cpp2IlInjected.Address(RVA = "0xAA5FC0", Offset = "0xAA53C0", VA = "0x180AA5FC0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000311")]
		public StorefrontTypes? StorefrontType
		{
			[Cpp2IlInjected.Token(Token = "0x60006F1")]
			[Cpp2IlInjected.Address(RVA = "0xAAA880", Offset = "0xAA9C80", VA = "0x180AAA880")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60006F2")]
			[Cpp2IlInjected.Address(RVA = "0x10BA780", Offset = "0x10B9B80", VA = "0x1810BA780")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000312")]
		public CurrencyType CurrencyType
		{
			[Cpp2IlInjected.Token(Token = "0x60006F3")]
			[Cpp2IlInjected.Address(RVA = "0xAB5660", Offset = "0xAB4A60", VA = "0x180AB5660")]
			[CompilerGenerated]
			get
			{
				return default(CurrencyType);
			}
			[Cpp2IlInjected.Token(Token = "0x60006F4")]
			[Cpp2IlInjected.Address(RVA = "0xB07AB0", Offset = "0xB06EB0", VA = "0x180B07AB0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000313")]
		public bool BypassGiftPackages
		{
			[Cpp2IlInjected.Token(Token = "0x60006F5")]
			[Cpp2IlInjected.Address(RVA = "0xBBFFE0", Offset = "0xBBF3E0", VA = "0x180BBFFE0")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x60006F6")]
			[Cpp2IlInjected.Address(RVA = "0xBC0B40", Offset = "0xBBFF40", VA = "0x180BC0B40")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000314")]
		public bool AllowPartialSuccess
		{
			[Cpp2IlInjected.Token(Token = "0x60006F7")]
			[Cpp2IlInjected.Address(RVA = "0x134CA30", Offset = "0x134BE30", VA = "0x18134CA30")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x60006F8")]
			[Cpp2IlInjected.Address(RVA = "0x77151B0", Offset = "0x77145B0", VA = "0x1877151B0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000315")]
		public Guid? ShoppingBagId
		{
			[Cpp2IlInjected.Token(Token = "0x60006F9")]
			[Cpp2IlInjected.Address(RVA = "0xCE0E00", Offset = "0xCE0200", VA = "0x180CE0E00")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60006FA")]
			[Cpp2IlInjected.Address(RVA = "0x2005D30", Offset = "0x2005130", VA = "0x182005D30")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60006FB")]
		[Cpp2IlInjected.Address(RVA = "0x7715130", Offset = "0x7714530", VA = "0x187715130")]
		public BulkPurchaseItemRequestDTO(List<PurchaseItemRequestDTO> purchaseItemRequests, StorefrontTypes? storefrontType, CurrencyType currencyType, bool allowPartialSuccess, bool bypassGiftPackages = false, [Optional] Guid? shoppingBagId)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000101")]
	[Utf8JsonSerializable]
	public class BulkPurchaseItemsBalanceUpdateResponseDataDTO : DURPPUIUDDT
	{
		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x2000102")]
		[CompilerGenerated]
		private struct <OnDeserializedAsync>d__14 : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40004B2")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x40004B3")]
			public AsyncTaskMethodBuilder <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x40004B4")]
			public BulkPurchaseItemsBalanceUpdateResponseDataDTO <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x40004B5")]
			private object <>u__1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x40004B6")]
			private ConfiguredTaskAwaitable.ConfiguredTaskAwaiter <>u__2;

			[Cpp2IlInjected.Token(Token = "0x6000704")]
			[Cpp2IlInjected.Address(RVA = "0x771DF70", Offset = "0x771D370", VA = "0x18771DF70", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000705")]
			[Cpp2IlInjected.Address(RVA = "0x771E6A0", Offset = "0x771DAA0", VA = "0x18771E6A0", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x40004AD")]
		internal static Action<GiftPackage>? UXKDDIDSDFR;

		[Cpp2IlInjected.Token(Token = "0x40004AE")]
		internal static Func<GiftPackage, Task>? GZHPZWZKFDJ;

		[Cpp2IlInjected.Token(Token = "0x17000316")]
		public GiftPackage GiftPackage
		{
			[Cpp2IlInjected.Token(Token = "0x60006FC")]
			[Cpp2IlInjected.Address(RVA = "0xAA5FB0", Offset = "0xAA53B0", VA = "0x180AA5FB0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60006FD")]
			[Cpp2IlInjected.Address(RVA = "0xAA5FC0", Offset = "0xAA53C0", VA = "0x180AA5FC0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000317")]
		public int? PurchasableItemId
		{
			[Cpp2IlInjected.Token(Token = "0x60006FE")]
			[Cpp2IlInjected.Address(RVA = "0xAAA880", Offset = "0xAA9C80", VA = "0x180AAA880")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60006FF")]
			[Cpp2IlInjected.Address(RVA = "0x10BA780", Offset = "0x10B9B80", VA = "0x1810BA780")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000318")]
		public CustomAvatarItem? CustomAvatarItem
		{
			[Cpp2IlInjected.Token(Token = "0x6000700")]
			[Cpp2IlInjected.Address(RVA = "0xAAB1C0", Offset = "0xAAA5C0", VA = "0x180AAB1C0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000701")]
			[Cpp2IlInjected.Address(RVA = "0xAA67C0", Offset = "0xAA5BC0", VA = "0x180AA67C0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000702")]
		[Cpp2IlInjected.Address(RVA = "0x77151C0", Offset = "0x77145C0", VA = "0x1877151C0", Slot = "4")]
		[AsyncStateMachine(typeof(<OnDeserializedAsync>d__14))]
		public Task NLICNVNCYRU()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000703")]
		[Cpp2IlInjected.Address(RVA = "0xAAC8E0", Offset = "0xAABCE0", VA = "0x180AAC8E0")]
		public BulkPurchaseItemsBalanceUpdateResponseDataDTO()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000103")]
	[Utf8JsonSerializableGenericSpecialization]
	public class BalanceUpdateResponseDTO_BulkPurchaseItemsBalanceUpdateResponseDataDTO : BalanceUpdateResponseDTO<BulkPurchaseItemsBalanceUpdateResponseDataDTO>
	{
		[Cpp2IlInjected.Token(Token = "0x6000706")]
		[Cpp2IlInjected.Address(RVA = "0x7714600", Offset = "0x7713A00", VA = "0x187714600")]
		public BalanceUpdateResponseDTO_BulkPurchaseItemsBalanceUpdateResponseDataDTO()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000104")]
	[Utf8JsonSerializableGenericSpecialization]
	public class UWJRNLQFEFP : BalanceUpdateResponseDTO<BulkPurchaseItemsBalanceUpdateResponseDataDTO>.KGMPTSKEKKA
	{
		[Cpp2IlInjected.Token(Token = "0x6000707")]
		[Cpp2IlInjected.Address(RVA = "0x771F680", Offset = "0x771EA80", VA = "0x18771F680")]
		public UWJRNLQFEFP()
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000105")]
	[Utf8JsonSerializable]
	public class GiftItemDTO
	{
		[Cpp2IlInjected.Token(Token = "0x17000319")]
		public int ToPlayerId
		{
			[Cpp2IlInjected.Token(Token = "0x6000708")]
			[Cpp2IlInjected.Address(RVA = "0xAA3110", Offset = "0xAA2510", VA = "0x180AA3110")]
			[CompilerGenerated]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x6000709")]
			[Cpp2IlInjected.Address(RVA = "0xAAB1D0", Offset = "0xAAA5D0", VA = "0x180AAB1D0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700031A")]
		public string? Message
		{
			[Cpp2IlInjected.Token(Token = "0x600070A")]
			[Cpp2IlInjected.Address(RVA = "0xAAA880", Offset = "0xAA9C80", VA = "0x180AAA880")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600070B")]
			[Cpp2IlInjected.Address(RVA = "0xAAA120", Offset = "0xAA9520", VA = "0x180AAA120")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700031B")]
		public bool Anonymous
		{
			[Cpp2IlInjected.Token(Token = "0x600070C")]
			[Cpp2IlInjected.Address(RVA = "0xAAA010", Offset = "0xAA9410", VA = "0x180AAA010")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x600070D")]
			[Cpp2IlInjected.Address(RVA = "0xAAA830", Offset = "0xAA9C30", VA = "0x180AAA830")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700031C")]
		public GiftContext GiftContext
		{
			[Cpp2IlInjected.Token(Token = "0x600070E")]
			[Cpp2IlInjected.Address(RVA = "0xACC3D0", Offset = "0xACB7D0", VA = "0x180ACC3D0")]
			[CompilerGenerated]
			get
			{
				return default(GiftContext);
			}
			[Cpp2IlInjected.Token(Token = "0x600070F")]
			[Cpp2IlInjected.Address(RVA = "0xBE18B0", Offset = "0xBE0CB0", VA = "0x180BE18B0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000710")]
		[Cpp2IlInjected.Address(RVA = "0xAAC8E0", Offset = "0xAABCE0", VA = "0x180AAC8E0")]
		public GiftItemDTO()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000106")]
	[Utf8JsonSerializable]
	public class ItemPurchaseInfoDTO : UXHFBGMMSQV
	{
		[Cpp2IlInjected.Token(Token = "0x1700031D")]
		public UGCPurchasableItemIdentifier? ItemId
		{
			[Cpp2IlInjected.Token(Token = "0x6000711")]
			[Cpp2IlInjected.Address(RVA = "0xAA5FB0", Offset = "0xAA53B0", VA = "0x180AA5FB0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000712")]
			[Cpp2IlInjected.Address(RVA = "0xAA5FC0", Offset = "0xAA53C0", VA = "0x180AA5FC0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700031E")]
		[IgnoreDataMember]
		public Guid CustomAvatarItemId
		{
			[Cpp2IlInjected.Token(Token = "0x6000713")]
			[Cpp2IlInjected.Address(RVA = "0x7718FC0", Offset = "0x77183C0", VA = "0x187718FC0", Slot = "4")]
			get
			{
				return default(Guid);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700031F")]
		public ItemPurchaseMethodId? PurchaseMethodId
		{
			[Cpp2IlInjected.Token(Token = "0x6000715")]
			[Cpp2IlInjected.Address(RVA = "0xAAA880", Offset = "0xAA9C80", VA = "0x180AAA880", Slot = "5")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000716")]
			[Cpp2IlInjected.Address(RVA = "0xAAA120", Offset = "0xAA9520", VA = "0x180AAA120")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000320")]
		public List<PurchasablePrice>? Prices
		{
			[Cpp2IlInjected.Token(Token = "0x6000717")]
			[Cpp2IlInjected.Address(RVA = "0xAAB1C0", Offset = "0xAAA5C0", VA = "0x180AAB1C0", Slot = "6")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000718")]
			[Cpp2IlInjected.Address(RVA = "0xAA67C0", Offset = "0xAA5BC0", VA = "0x180AA67C0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000321")]
		public DateTime? NewUntil
		{
			[Cpp2IlInjected.Token(Token = "0x6000719")]
			[Cpp2IlInjected.Address(RVA = "0x1146260", Offset = "0x1145660", VA = "0x181146260", Slot = "7")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600071A")]
			[Cpp2IlInjected.Address(RVA = "0x128B750", Offset = "0x128AB50", VA = "0x18128B750")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000322")]
		public DateTime? AvailableAt
		{
			[Cpp2IlInjected.Token(Token = "0x600071B")]
			[Cpp2IlInjected.Address(RVA = "0x134DB80", Offset = "0x134CF80", VA = "0x18134DB80", Slot = "8")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600071C")]
			[Cpp2IlInjected.Address(RVA = "0x134D8A0", Offset = "0x134CCA0", VA = "0x18134D8A0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000323")]
		public DateTime? AvailableUntil
		{
			[Cpp2IlInjected.Token(Token = "0x600071D")]
			[Cpp2IlInjected.Address(RVA = "0xBB85C0", Offset = "0xBB79C0", VA = "0x180BB85C0", Slot = "9")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600071E")]
			[Cpp2IlInjected.Address(RVA = "0x14DF440", Offset = "0x14DE840", VA = "0x1814DF440")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000324")]
		public bool CanBeGifted
		{
			[Cpp2IlInjected.Token(Token = "0x600071F")]
			[Cpp2IlInjected.Address(RVA = "0xB15270", Offset = "0xB14670", VA = "0x180B15270", Slot = "10")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000720")]
			[Cpp2IlInjected.Address(RVA = "0xBAA9D0", Offset = "0xBA9DD0", VA = "0x180BAA9D0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000325")]
		public bool CanApplySubscriberDiscount
		{
			[Cpp2IlInjected.Token(Token = "0x6000721")]
			[Cpp2IlInjected.Address(RVA = "0xAF6330", Offset = "0xAF5730", VA = "0x180AF6330")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000722")]
			[Cpp2IlInjected.Address(RVA = "0xAF6340", Offset = "0xAF5740", VA = "0x180AF6340")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000326")]
		public bool SubscribersOnly
		{
			[Cpp2IlInjected.Token(Token = "0x6000723")]
			[Cpp2IlInjected.Address(RVA = "0xDF8800", Offset = "0xDF7C00", VA = "0x180DF8800", Slot = "11")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000724")]
			[Cpp2IlInjected.Address(RVA = "0xFB5540", Offset = "0xFB4940", VA = "0x180FB5540")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000327")]
		public bool IsFeatured
		{
			[Cpp2IlInjected.Token(Token = "0x6000725")]
			[Cpp2IlInjected.Address(RVA = "0x2F605E0", Offset = "0x2F5F9E0", VA = "0x182F605E0", Slot = "12")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000726")]
			[Cpp2IlInjected.Address(RVA = "0x5F23A90", Offset = "0x5F22E90", VA = "0x185F23A90")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000714")]
		[Cpp2IlInjected.Address(RVA = "0x7718D30", Offset = "0x7718130", VA = "0x187718D30")]
		public static ItemPurchaseInfoDTO RNVVJPANFAM(Guid a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000727")]
		[Cpp2IlInjected.Address(RVA = "0xAAC8E0", Offset = "0xAABCE0", VA = "0x180AAC8E0")]
		public ItemPurchaseInfoDTO()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000107")]
	[Utf8JsonSerializable]
	public class RRPlusSignupConfigDTO
	{
		[Cpp2IlInjected.Token(Token = "0x17000328")]
		public int Version
		{
			[Cpp2IlInjected.Token(Token = "0x6000728")]
			[Cpp2IlInjected.Address(RVA = "0xAA3110", Offset = "0xAA2510", VA = "0x180AA3110")]
			[CompilerGenerated]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x6000729")]
			[Cpp2IlInjected.Address(RVA = "0xAAB1D0", Offset = "0xAAA5D0", VA = "0x180AAB1D0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000329")]
		public string HighlightText
		{
			[Cpp2IlInjected.Token(Token = "0x600072A")]
			[Cpp2IlInjected.Address(RVA = "0xAAA880", Offset = "0xAA9C80", VA = "0x180AAA880")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600072B")]
			[Cpp2IlInjected.Address(RVA = "0xAAA120", Offset = "0xAA9520", VA = "0x180AAA120")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700032A")]
		public string MoreDetailsText
		{
			[Cpp2IlInjected.Token(Token = "0x600072C")]
			[Cpp2IlInjected.Address(RVA = "0xAAB1C0", Offset = "0xAAA5C0", VA = "0x180AAB1C0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600072D")]
			[Cpp2IlInjected.Address(RVA = "0xAA67C0", Offset = "0xAA5BC0", VA = "0x180AA67C0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700032B")]
		public Dictionary<int, RRPlusBenefitDescriptionDto> BenefitLookup
		{
			[Cpp2IlInjected.Token(Token = "0x600072E")]
			[Cpp2IlInjected.Address(RVA = "0xAAA820", Offset = "0xAA9C20", VA = "0x180AAA820")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600072F")]
			[Cpp2IlInjected.Address(RVA = "0xAA67D0", Offset = "0xAA5BD0", VA = "0x180AA67D0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700032C")]
		public Dictionary<string, int> NumberReplacements
		{
			[Cpp2IlInjected.Token(Token = "0x6000730")]
			[Cpp2IlInjected.Address(RVA = "0xAAA140", Offset = "0xAA9540", VA = "0x180AAA140")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000731")]
			[Cpp2IlInjected.Address(RVA = "0xAADB00", Offset = "0xAACF00", VA = "0x180AADB00")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700032D")]
		public Dictionary<BenefitListType, List<int>> BenefitLists
		{
			[Cpp2IlInjected.Token(Token = "0x6000732")]
			[Cpp2IlInjected.Address(RVA = "0xAAA030", Offset = "0xAA9430", VA = "0x180AAA030")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000733")]
			[Cpp2IlInjected.Address(RVA = "0xAAA110", Offset = "0xAA9510", VA = "0x180AAA110")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700032E")]
		public Dictionary<string, string> StringConfigs
		{
			[Cpp2IlInjected.Token(Token = "0x6000734")]
			[Cpp2IlInjected.Address(RVA = "0xAAA810", Offset = "0xAA9C10", VA = "0x180AAA810")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000735")]
			[Cpp2IlInjected.Address(RVA = "0xAAA840", Offset = "0xAA9C40", VA = "0x180AAA840")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000736")]
		[Cpp2IlInjected.Address(RVA = "0xAAC8E0", Offset = "0xAABCE0", VA = "0x180AAC8E0")]
		public RRPlusSignupConfigDTO()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000108")]
	public enum BenefitListType
	{
		[Cpp2IlInjected.Token(Token = "0x40004CD")]
		DetailsScreen,
		[Cpp2IlInjected.Token(Token = "0x40004CE")]
		SignUpScreen,
		[Cpp2IlInjected.Token(Token = "0x40004CF")]
		ManageMembershipScreen,
		[Cpp2IlInjected.Token(Token = "0x40004D0")]
		ItemDetailsScreen,
		[Cpp2IlInjected.Token(Token = "0x40004D1")]
		ActivityRewardsScreen,
		[Cpp2IlInjected.Token(Token = "0x40004D2")]
		RoomPublishUpsell
	}
	[Cpp2IlInjected.Token(Token = "0x2000109")]
	[Utf8JsonSerializable]
	public class RRPlusBenefitDescriptionDto : LNXZALXHVOG
	{
		[Cpp2IlInjected.Token(Token = "0x1700032F")]
		public PlatformMask EnabledForPlatforms
		{
			[Cpp2IlInjected.Token(Token = "0x6000737")]
			[Cpp2IlInjected.Address(RVA = "0xAA3110", Offset = "0xAA2510", VA = "0x180AA3110")]
			[CompilerGenerated]
			get
			{
				return default(PlatformMask);
			}
			[Cpp2IlInjected.Token(Token = "0x6000738")]
			[Cpp2IlInjected.Address(RVA = "0xAAB1D0", Offset = "0xAAA5D0", VA = "0x180AAB1D0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000330")]
		public bool RequiresMonetizationEnabled
		{
			[Cpp2IlInjected.Token(Token = "0x6000739")]
			[Cpp2IlInjected.Address(RVA = "0x1021B40", Offset = "0x1020F40", VA = "0x181021B40")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x600073A")]
			[Cpp2IlInjected.Address(RVA = "0x134A610", Offset = "0x1349A10", VA = "0x18134A610")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000331")]
		public bool RequiresPublishingEnabled
		{
			[Cpp2IlInjected.Token(Token = "0x600073B")]
			[Cpp2IlInjected.Address(RVA = "0x1108B00", Offset = "0x1107F00", VA = "0x181108B00")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x600073C")]
			[Cpp2IlInjected.Address(RVA = "0x1108AF0", Offset = "0x1107EF0", VA = "0x181108AF0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000332")]
		public string ShortText
		{
			[Cpp2IlInjected.Token(Token = "0x600073D")]
			[Cpp2IlInjected.Address(RVA = "0xAAA880", Offset = "0xAA9C80", VA = "0x180AAA880", Slot = "5")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600073E")]
			[Cpp2IlInjected.Address(RVA = "0xAAA120", Offset = "0xAA9520", VA = "0x180AAA120")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000333")]
		public string TitleText
		{
			[Cpp2IlInjected.Token(Token = "0x600073F")]
			[Cpp2IlInjected.Address(RVA = "0xAAB1C0", Offset = "0xAAA5C0", VA = "0x180AAB1C0", Slot = "4")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000740")]
			[Cpp2IlInjected.Address(RVA = "0xAA67C0", Offset = "0xAA5BC0", VA = "0x180AA67C0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000334")]
		public string DetailedText
		{
			[Cpp2IlInjected.Token(Token = "0x6000741")]
			[Cpp2IlInjected.Address(RVA = "0xAAA820", Offset = "0xAA9C20", VA = "0x180AAA820", Slot = "6")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000742")]
			[Cpp2IlInjected.Address(RVA = "0xAA67D0", Offset = "0xAA5BD0", VA = "0x180AA67D0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000335")]
		public string CustomSpriteName
		{
			[Cpp2IlInjected.Token(Token = "0x6000743")]
			[Cpp2IlInjected.Address(RVA = "0xAAA140", Offset = "0xAA9540", VA = "0x180AAA140", Slot = "7")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000744")]
			[Cpp2IlInjected.Address(RVA = "0xAADB00", Offset = "0xAACF00", VA = "0x180AADB00")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000336")]
		public Dictionary<PlatformType, string> PlatformSpecificDetailedTexts
		{
			[Cpp2IlInjected.Token(Token = "0x6000745")]
			[Cpp2IlInjected.Address(RVA = "0xAAA030", Offset = "0xAA9430", VA = "0x180AAA030")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000746")]
			[Cpp2IlInjected.Address(RVA = "0xAAA110", Offset = "0xAA9510", VA = "0x180AAA110")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000747")]
		[Cpp2IlInjected.Address(RVA = "0x134A620", Offset = "0x1349A20", VA = "0x18134A620")]
		public RRPlusBenefitDescriptionDto()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200010A")]
	[Utf8JsonSerializable]
	public class GetItemPurchaseInfosRequestDTO
	{
		[Cpp2IlInjected.Token(Token = "0x17000337")]
		public IReadOnlyList<UGCPurchasableItemIdentifier>? Ids
		{
			[Cpp2IlInjected.Token(Token = "0x6000748")]
			[Cpp2IlInjected.Address(RVA = "0xAA5FB0", Offset = "0xAA53B0", VA = "0x180AA5FB0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000749")]
			[Cpp2IlInjected.Address(RVA = "0xAA5FC0", Offset = "0xAA53C0", VA = "0x180AA5FC0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600074A")]
		[Cpp2IlInjected.Address(RVA = "0xAAC8E0", Offset = "0xAABCE0", VA = "0x180AAC8E0")]
		public GetItemPurchaseInfosRequestDTO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600074B")]
		[Cpp2IlInjected.Address(RVA = "0xAA6010", Offset = "0xAA5410", VA = "0x180AA6010")]
		public GetItemPurchaseInfosRequestDTO(IReadOnlyList<UGCPurchasableItemIdentifier>? ids)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200010B")]
	public enum GiftBoxContents
	{
		[Cpp2IlInjected.Token(Token = "0x40004DD")]
		Unspecified = -1,
		[Cpp2IlInjected.Token(Token = "0x40004DE")]
		XP,
		[Cpp2IlInjected.Token(Token = "0x40004DF")]
		OutfitItem,
		[Cpp2IlInjected.Token(Token = "0x40004E0")]
		Equipment,
		[Cpp2IlInjected.Token(Token = "0x40004E1")]
		Currency,
		[Cpp2IlInjected.Token(Token = "0x40004E2")]
		Consumable,
		[Cpp2IlInjected.Token(Token = "0x40004E3")]
		Query,
		[Cpp2IlInjected.Token(Token = "0x40004E4")]
		HairDye,
		[Cpp2IlInjected.Token(Token = "0x40004E5")]
		Rectober_Trick,
		[Cpp2IlInjected.Token(Token = "0x40004E6")]
		PurchasableXpBoost
	}
	[Cpp2IlInjected.Token(Token = "0x200010C")]
	public enum GrantableType
	{
		[Cpp2IlInjected.Token(Token = "0x40004E8")]
		GiftDrop,
		[Cpp2IlInjected.Token(Token = "0x40004E9")]
		CustomAvatarItem
	}
	[Cpp2IlInjected.Token(Token = "0x200010D")]
	[Utf8JsonSerializable]
	public class GrantableId : IEquatable<GrantableId>
	{
		[Cpp2IlInjected.Token(Token = "0x17000338")]
		public GrantableType Type
		{
			[Cpp2IlInjected.Token(Token = "0x600074C")]
			[Cpp2IlInjected.Address(RVA = "0xAA3110", Offset = "0xAA2510", VA = "0x180AA3110")]
			[CompilerGenerated]
			get
			{
				return default(GrantableType);
			}
			[Cpp2IlInjected.Token(Token = "0x600074D")]
			[Cpp2IlInjected.Address(RVA = "0xAAB1D0", Offset = "0xAAA5D0", VA = "0x180AAB1D0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000339")]
		public int? NumberId
		{
			[Cpp2IlInjected.Token(Token = "0x600074E")]
			[Cpp2IlInjected.Address(RVA = "0x10D2A50", Offset = "0x10D1E50", VA = "0x1810D2A50")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600074F")]
			[Cpp2IlInjected.Address(RVA = "0x10D3E30", Offset = "0x10D3230", VA = "0x1810D3E30")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700033A")]
		public Guid? Guid
		{
			[Cpp2IlInjected.Token(Token = "0x6000750")]
			[Cpp2IlInjected.Address(RVA = "0xAACA30", Offset = "0xAABE30", VA = "0x180AACA30")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000751")]
			[Cpp2IlInjected.Address(RVA = "0xAAC8F0", Offset = "0xAABCF0", VA = "0x180AAC8F0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000752")]
		[Cpp2IlInjected.Address(RVA = "0x7718250", Offset = "0x7717650", VA = "0x187718250")]
		public static GrantableId SOQOAZOXLON(int a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000753")]
		[Cpp2IlInjected.Address(RVA = "0x7718190", Offset = "0x7717590", VA = "0x187718190")]
		public static GrantableId HESRGWRGYHJ(Guid a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000754")]
		[Cpp2IlInjected.Address(RVA = "0x7718000", Offset = "0x7717400", VA = "0x187718000", Slot = "4")]
		public bool Equals(GrantableId? other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000755")]
		[Cpp2IlInjected.Address(RVA = "0x7717E50", Offset = "0x7717250", VA = "0x187717E50", Slot = "0")]
		public override bool Equals(object? obj)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000756")]
		[Cpp2IlInjected.Address(RVA = "0x77180F0", Offset = "0x77174F0", VA = "0x1877180F0", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[SpecialName]
		[Cpp2IlInjected.Token(Token = "0x6000757")]
		[Cpp2IlInjected.Address(RVA = "0x128AB20", Offset = "0x1289F20", VA = "0x18128AB20")]
		public static bool ZWISVWGZSLY(GrantableId? a, GrantableId? b)
		{
			return default(bool);
		}

		[SpecialName]
		[Cpp2IlInjected.Token(Token = "0x6000758")]
		[Cpp2IlInjected.Address(RVA = "0x128AB00", Offset = "0x1289F00", VA = "0x18128AB00")]
		public static bool ZPGHGHNXRJT(GrantableId? a, GrantableId? b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000759")]
		[Cpp2IlInjected.Address(RVA = "0xAAC8E0", Offset = "0xAABCE0", VA = "0x180AAC8E0")]
		public GrantableId()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200010E")]
	public interface UXHFBGMMSQV
	{
		[Cpp2IlInjected.Token(Token = "0x1700033B")]
		Guid CustomAvatarItemId
		{
			[Cpp2IlInjected.Token(Token = "0x600075A")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x1700033C")]
		ItemPurchaseMethodId? PurchaseMethodId
		{
			[Cpp2IlInjected.Token(Token = "0x600075B")]
			[Cpp2IlInjected.Address(Slot = "1")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x1700033D")]
		List<PurchasablePrice>? Prices
		{
			[Cpp2IlInjected.Token(Token = "0x600075C")]
			[Cpp2IlInjected.Address(Slot = "2")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x1700033E")]
		DateTime? NewUntil
		{
			[Cpp2IlInjected.Token(Token = "0x600075D")]
			[Cpp2IlInjected.Address(Slot = "3")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x1700033F")]
		DateTime? AvailableAt
		{
			[Cpp2IlInjected.Token(Token = "0x600075E")]
			[Cpp2IlInjected.Address(Slot = "4")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000340")]
		DateTime? AvailableUntil
		{
			[Cpp2IlInjected.Token(Token = "0x600075F")]
			[Cpp2IlInjected.Address(Slot = "5")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000341")]
		bool CanBeGifted
		{
			[Cpp2IlInjected.Token(Token = "0x6000760")]
			[Cpp2IlInjected.Address(Slot = "6")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000342")]
		bool SubscribersOnly
		{
			[Cpp2IlInjected.Token(Token = "0x6000761")]
			[Cpp2IlInjected.Address(Slot = "7")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000343")]
		bool IsFeatured
		{
			[Cpp2IlInjected.Token(Token = "0x6000762")]
			[Cpp2IlInjected.Address(Slot = "8")]
			get;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200010F")]
	public interface KXGWQVDFSMP
	{
		[Cpp2IlInjected.Token(Token = "0x1400000A")]
		event Action TVVYDOLDGKH;

		[Cpp2IlInjected.Token(Token = "0x6000765")]
		[Cpp2IlInjected.Address(Slot = "2")]
		Task DCZVZWLQOFI(CancellationToken a);

		[Cpp2IlInjected.Token(Token = "0x6000766")]
		[Cpp2IlInjected.Address(Slot = "3")]
		Task PGTUYENVIGQ(CancellationToken a);

		[Cpp2IlInjected.Token(Token = "0x6000767")]
		[Cpp2IlInjected.Address(Slot = "4")]
		bool NWEGXGZEZEH([Out] MCBSKQJGRBJ a);
	}
	[Cpp2IlInjected.Token(Token = "0x2000110")]
	public interface MCBSKQJGRBJ
	{
		[Cpp2IlInjected.Token(Token = "0x17000344")]
		string VDRMRKYZMTD
		{
			[Cpp2IlInjected.Token(Token = "0x6000768")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000345")]
		string MNVXZTXKQTC
		{
			[Cpp2IlInjected.Token(Token = "0x6000769")]
			[Cpp2IlInjected.Address(Slot = "1")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000346")]
		IReadOnlyDictionary<BenefitListType, IReadOnlyList<LNXZALXHVOG>> QNREJFXZPDS
		{
			[Cpp2IlInjected.Token(Token = "0x600076A")]
			[Cpp2IlInjected.Address(Slot = "2")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000347")]
		IReadOnlyDictionary<string, string> XDJLIHLCSBI
		{
			[Cpp2IlInjected.Token(Token = "0x600076B")]
			[Cpp2IlInjected.Address(Slot = "3")]
			get;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000111")]
	public interface LNXZALXHVOG
	{
		[Cpp2IlInjected.Token(Token = "0x17000348")]
		string TitleText
		{
			[Cpp2IlInjected.Token(Token = "0x600076C")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000349")]
		string ShortText
		{
			[Cpp2IlInjected.Token(Token = "0x600076D")]
			[Cpp2IlInjected.Address(Slot = "1")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x1700034A")]
		string DetailedText
		{
			[Cpp2IlInjected.Token(Token = "0x600076E")]
			[Cpp2IlInjected.Address(Slot = "2")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x1700034B")]
		string CustomSpriteName
		{
			[Cpp2IlInjected.Token(Token = "0x600076F")]
			[Cpp2IlInjected.Address(Slot = "3")]
			get;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000112")]
	public interface FTMSUJYXKGB
	{
		[Cpp2IlInjected.Token(Token = "0x1700034C")]
		UnifiedItemType ItemType
		{
			[Cpp2IlInjected.Token(Token = "0x6000770")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x1700034D")]
		string Id
		{
			[Cpp2IlInjected.Token(Token = "0x6000771")]
			[Cpp2IlInjected.Address(Slot = "1")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x1700034E")]
		string FriendlyName
		{
			[Cpp2IlInjected.Token(Token = "0x6000772")]
			[Cpp2IlInjected.Address(Slot = "2")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x1700034F")]
		string ThumbnailImageFilename
		{
			[Cpp2IlInjected.Token(Token = "0x6000773")]
			[Cpp2IlInjected.Address(Slot = "3")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000350")]
		bool IsFeatured
		{
			[Cpp2IlInjected.Token(Token = "0x6000774")]
			[Cpp2IlInjected.Address(Slot = "4")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000351")]
		bool SubscribersOnly
		{
			[Cpp2IlInjected.Token(Token = "0x6000775")]
			[Cpp2IlInjected.Address(Slot = "5")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000352")]
		GiftRarity Rarity
		{
			[Cpp2IlInjected.Token(Token = "0x6000776")]
			[Cpp2IlInjected.Address(Slot = "6")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000353")]
		string ConsumableItemDesc
		{
			[Cpp2IlInjected.Token(Token = "0x6000777")]
			[Cpp2IlInjected.Address(Slot = "7")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000354")]
		AvatarItemType? AvatarItemType
		{
			[Cpp2IlInjected.Token(Token = "0x6000778")]
			[Cpp2IlInjected.Address(Slot = "8")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000355")]
		GiftBoxContents GiftBoxContent
		{
			[Cpp2IlInjected.Token(Token = "0x6000779")]
			[Cpp2IlInjected.Address(Slot = "9")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000356")]
		bool IsQueryGiftDrop
		{
			[Cpp2IlInjected.Token(Token = "0x600077A")]
			[Cpp2IlInjected.Address(Slot = "10")]
			get;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000113")]
	[Utf8JsonSerializable]
	public class ItemPurchaseMethodId : IEquatable<ItemPurchaseMethodId>
	{
		[Cpp2IlInjected.Token(Token = "0x17000357")]
		public UnifiedItemType Type
		{
			[Cpp2IlInjected.Token(Token = "0x600077B")]
			[Cpp2IlInjected.Address(RVA = "0xAA3110", Offset = "0xAA2510", VA = "0x180AA3110")]
			[CompilerGenerated]
			get
			{
				return default(UnifiedItemType);
			}
			[Cpp2IlInjected.Token(Token = "0x600077C")]
			[Cpp2IlInjected.Address(RVA = "0xAAB1D0", Offset = "0xAAA5D0", VA = "0x180AAB1D0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000358")]
		public int? NumberId
		{
			[Cpp2IlInjected.Token(Token = "0x600077D")]
			[Cpp2IlInjected.Address(RVA = "0x10D2A50", Offset = "0x10D1E50", VA = "0x1810D2A50")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600077E")]
			[Cpp2IlInjected.Address(RVA = "0x10D3E30", Offset = "0x10D3230", VA = "0x1810D3E30")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000359")]
		public Guid? Guid
		{
			[Cpp2IlInjected.Token(Token = "0x600077F")]
			[Cpp2IlInjected.Address(RVA = "0xAACA30", Offset = "0xAABE30", VA = "0x180AACA30")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000780")]
			[Cpp2IlInjected.Address(RVA = "0xAAC8F0", Offset = "0xAABCF0", VA = "0x180AAC8F0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000781")]
		[Cpp2IlInjected.Address(RVA = "0x7719040", Offset = "0x7718440", VA = "0x187719040")]
		public static ItemPurchaseMethodId ATUHERZMJAF(int a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000782")]
		[Cpp2IlInjected.Address(RVA = "0x7719420", Offset = "0x7718820", VA = "0x187719420")]
		public static ItemPurchaseMethodId HESRGWRGYHJ(Guid a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000783")]
		[Cpp2IlInjected.Address(RVA = "0x77194E0", Offset = "0x77188E0", VA = "0x1877194E0")]
		public static ItemPurchaseMethodId PPURCZPVJLQ(UnifiedItemId a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000784")]
		[Cpp2IlInjected.Address(RVA = "0x7719290", Offset = "0x7718690", VA = "0x187719290", Slot = "4")]
		public bool Equals(ItemPurchaseMethodId? other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000785")]
		[Cpp2IlInjected.Address(RVA = "0x77190E0", Offset = "0x77184E0", VA = "0x1877190E0", Slot = "0")]
		public override bool Equals(object? obj)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000786")]
		[Cpp2IlInjected.Address(RVA = "0x7719380", Offset = "0x7718780", VA = "0x187719380", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[SpecialName]
		[Cpp2IlInjected.Token(Token = "0x6000787")]
		[Cpp2IlInjected.Address(RVA = "0x128AB20", Offset = "0x1289F20", VA = "0x18128AB20")]
		public static bool ZWISVWGZSLY(ItemPurchaseMethodId? a, ItemPurchaseMethodId? b)
		{
			return default(bool);
		}

		[SpecialName]
		[Cpp2IlInjected.Token(Token = "0x6000788")]
		[Cpp2IlInjected.Address(RVA = "0x128AB00", Offset = "0x1289F00", VA = "0x18128AB00")]
		public static bool ZPGHGHNXRJT(ItemPurchaseMethodId? a, ItemPurchaseMethodId? b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000789")]
		[Cpp2IlInjected.Address(RVA = "0xAAC8E0", Offset = "0xAABCE0", VA = "0x180AAC8E0")]
		public ItemPurchaseMethodId()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000114")]
	public enum UnifiedItemType
	{
		[Cpp2IlInjected.Token(Token = "0x40004F1")]
		PurchasableItem,
		[Cpp2IlInjected.Token(Token = "0x40004F2")]
		CustomAvatarItem
	}
	[Cpp2IlInjected.Token(Token = "0x2000115")]
	[Utf8JsonSerializable]
	public class PurchasablePrice
	{
		[Cpp2IlInjected.Token(Token = "0x1700035A")]
		public CurrencyType CurrencyType
		{
			[Cpp2IlInjected.Token(Token = "0x600078A")]
			[Cpp2IlInjected.Address(RVA = "0xAA3110", Offset = "0xAA2510", VA = "0x180AA3110")]
			[CompilerGenerated]
			get
			{
				return default(CurrencyType);
			}
			[Cpp2IlInjected.Token(Token = "0x600078B")]
			[Cpp2IlInjected.Address(RVA = "0xAAB1D0", Offset = "0xAAA5D0", VA = "0x180AAB1D0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700035B")]
		public int Price
		{
			[Cpp2IlInjected.Token(Token = "0x600078C")]
			[Cpp2IlInjected.Address(RVA = "0xC4E2B0", Offset = "0xC4D6B0", VA = "0x180C4E2B0")]
			[CompilerGenerated]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x600078D")]
			[Cpp2IlInjected.Address(RVA = "0xCDF260", Offset = "0xCDE660", VA = "0x180CDF260")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700035C")]
		public StorefrontSaleData StorefrontSaleData
		{
			[Cpp2IlInjected.Token(Token = "0x600078E")]
			[Cpp2IlInjected.Address(RVA = "0xAAA880", Offset = "0xAA9C80", VA = "0x180AAA880")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600078F")]
			[Cpp2IlInjected.Address(RVA = "0xAAA120", Offset = "0xAA9520", VA = "0x180AAA120")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000790")]
		[Cpp2IlInjected.Address(RVA = "0x771A840", Offset = "0x7719C40", VA = "0x18771A840")]
		public int JPQOBZWUGTF(DateTime a)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000791")]
		[Cpp2IlInjected.Address(RVA = "0xAAC8E0", Offset = "0xAABCE0", VA = "0x180AAC8E0")]
		public PurchasablePrice()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000116")]
	[Utf8JsonSerializable]
	public class StorefrontSaleData
	{
		[Cpp2IlInjected.Token(Token = "0x1700035D")]
		public int SalePercent
		{
			[Cpp2IlInjected.Token(Token = "0x6000792")]
			[Cpp2IlInjected.Address(RVA = "0xAA3110", Offset = "0xAA2510", VA = "0x180AA3110")]
			[CompilerGenerated]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x6000793")]
			[Cpp2IlInjected.Address(RVA = "0xAAB1D0", Offset = "0xAAA5D0", VA = "0x180AAB1D0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700035E")]
		public DateTime? SaleStartDate
		{
			[Cpp2IlInjected.Token(Token = "0x6000794")]
			[Cpp2IlInjected.Address(RVA = "0xC66740", Offset = "0xC65B40", VA = "0x180C66740")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000795")]
			[Cpp2IlInjected.Address(RVA = "0xC66840", Offset = "0xC65C40", VA = "0x180C66840")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700035F")]
		public DateTime? SaleEndDate
		{
			[Cpp2IlInjected.Token(Token = "0x6000796")]
			[Cpp2IlInjected.Address(RVA = "0x1146260", Offset = "0x1145660", VA = "0x181146260")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000797")]
			[Cpp2IlInjected.Address(RVA = "0x128B750", Offset = "0x128AB50", VA = "0x18128B750")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000798")]
		[Cpp2IlInjected.Address(RVA = "0x771C770", Offset = "0x771BB70", VA = "0x18771C770")]
		public bool CLPKRLSNOHG(DateTime a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000799")]
		[Cpp2IlInjected.Address(RVA = "0x771C950", Offset = "0x771BD50", VA = "0x18771C950")]
		public int TAJAAHWDIDG(DateTime a)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600079A")]
		[Cpp2IlInjected.Address(RVA = "0x771C860", Offset = "0x771BC60", VA = "0x18771C860")]
		public TimeSpan? DCNWHNKYMWM(DateTime a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600079B")]
		[Cpp2IlInjected.Address(RVA = "0xAAC8E0", Offset = "0xAABCE0", VA = "0x180AAC8E0")]
		public StorefrontSaleData()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000117")]
	public enum StorefrontTypes
	{
		[Cpp2IlInjected.Token(Token = "0x40004FA")]
		None = 0,
		[Cpp2IlInjected.Token(Token = "0x40004FB")]
		LaserTag = 1,
		[Cpp2IlInjected.Token(Token = "0x40004FC")]
		RecCenter = 2,
		[Cpp2IlInjected.Token(Token = "0x40004FD")]
		Watch = 3,
		[Cpp2IlInjected.Token(Token = "0x40004FE")]
		Quest_LostSkulls = 100,
		[Cpp2IlInjected.Token(Token = "0x40004FF")]
		Quest_Dracula = 101,
		[Cpp2IlInjected.Token(Token = "0x4000500")]
		Quest_GoldenTrophy = 102,
		[Cpp2IlInjected.Token(Token = "0x4000501")]
		Quest_CrimsonCauldron = 103,
		[Cpp2IlInjected.Token(Token = "0x4000502")]
		RecRoyale = 200,
		[Cpp2IlInjected.Token(Token = "0x4000503")]
		Cafe = 300,
		[Cpp2IlInjected.Token(Token = "0x4000504")]
		Paintball = 400,
		[Cpp2IlInjected.Token(Token = "0x4000505")]
		Paintball_River = 401,
		[Cpp2IlInjected.Token(Token = "0x4000506")]
		Paintball_Homestead = 402,
		[Cpp2IlInjected.Token(Token = "0x4000507")]
		Paintball_Quarry = 403,
		[Cpp2IlInjected.Token(Token = "0x4000508")]
		Paintball_ClearCut = 404,
		[Cpp2IlInjected.Token(Token = "0x4000509")]
		Paintball_Spillway = 405,
		[Cpp2IlInjected.Token(Token = "0x400050A")]
		Paintball_SunsetDriveIn = 406,
		[Cpp2IlInjected.Token(Token = "0x400050B")]
		Paintball_MerryMidway = 407,
		[Cpp2IlInjected.Token(Token = "0x400050C")]
		Paintball_Lobby_1 = 450,
		[Cpp2IlInjected.Token(Token = "0x400050D")]
		Paintball_Lobby_2 = 451,
		[Cpp2IlInjected.Token(Token = "0x400050E")]
		Paintball_Lobby_3 = 452,
		[Cpp2IlInjected.Token(Token = "0x400050F")]
		Paintball_Lobby_4 = 453,
		[Cpp2IlInjected.Token(Token = "0x4000510")]
		Paintball_Lobby_5 = 454,
		[Cpp2IlInjected.Token(Token = "0x4000511")]
		Paintball_Lobby_6 = 455,
		[Cpp2IlInjected.Token(Token = "0x4000512")]
		Paintball_Lobby_7 = 456,
		[Cpp2IlInjected.Token(Token = "0x4000513")]
		Paintball_Lobby_8 = 457,
		[Cpp2IlInjected.Token(Token = "0x4000514")]
		Paintball_Lobby_9 = 458,
		[Cpp2IlInjected.Token(Token = "0x4000515")]
		Paintball_Lobby_10 = 459,
		[Cpp2IlInjected.Token(Token = "0x4000516")]
		Paintball_Lobby_11 = 460,
		[Cpp2IlInjected.Token(Token = "0x4000517")]
		Paintball_Lobby_12 = 461,
		[Cpp2IlInjected.Token(Token = "0x4000518")]
		Paintball_Lobby_13 = 462,
		[Cpp2IlInjected.Token(Token = "0x4000519")]
		Paintball_Lobby_14 = 463,
		[Cpp2IlInjected.Token(Token = "0x400051A")]
		Paintball_Lobby_15 = 464,
		[Cpp2IlInjected.Token(Token = "0x400051B")]
		Bowling = 500,
		[Cpp2IlInjected.Token(Token = "0x400051C")]
		StuntRunner = 600,
		[Cpp2IlInjected.Token(Token = "0x400051D")]
		DormMirror = 700,
		[Cpp2IlInjected.Token(Token = "0x400051E")]
		InventionStore = 800,
		[Cpp2IlInjected.Token(Token = "0x400051F")]
		RoomKeys = 900,
		[Cpp2IlInjected.Token(Token = "0x4000520")]
		Player_Profile = 1000,
		[Cpp2IlInjected.Token(Token = "0x4000521")]
		Room_Save = 1100,
		[Cpp2IlInjected.Token(Token = "0x4000522")]
		RoomCurrencies = 1200,
		[Cpp2IlInjected.Token(Token = "0x4000523")]
		Wishlist = 1300,
		[Cpp2IlInjected.Token(Token = "0x4000524")]
		Friendotron = 1400,
		[Cpp2IlInjected.Token(Token = "0x4000525")]
		RoomConsumables = 1500,
		[Cpp2IlInjected.Token(Token = "0x4000526")]
		RecRally = 1600,
		[Cpp2IlInjected.Token(Token = "0x4000527")]
		PopUpShop_1 = 1700,
		[Cpp2IlInjected.Token(Token = "0x4000528")]
		PopUpShop_2 = 1701,
		[Cpp2IlInjected.Token(Token = "0x4000529")]
		PopUpShop_3 = 1702,
		[Cpp2IlInjected.Token(Token = "0x400052A")]
		PopUpShop_4 = 1703,
		[Cpp2IlInjected.Token(Token = "0x400052B")]
		PopUpShop_5 = 1704,
		[Cpp2IlInjected.Token(Token = "0x400052C")]
		PopUpShop_6 = 1705,
		[Cpp2IlInjected.Token(Token = "0x400052D")]
		PopUpShop_7 = 1706,
		[Cpp2IlInjected.Token(Token = "0x400052E")]
		PopUpShop_8 = 1707,
		[Cpp2IlInjected.Token(Token = "0x400052F")]
		PopUpShop_9 = 1708,
		[Cpp2IlInjected.Token(Token = "0x4000530")]
		PopUpShop_10 = 1709,
		[Cpp2IlInjected.Token(Token = "0x4000531")]
		PopUpShop_11 = 1710,
		[Cpp2IlInjected.Token(Token = "0x4000532")]
		PopUpShop_12 = 1711,
		[Cpp2IlInjected.Token(Token = "0x4000533")]
		PopUpShop_13 = 1712,
		[Cpp2IlInjected.Token(Token = "0x4000534")]
		PopUpShop_14 = 1713,
		[Cpp2IlInjected.Token(Token = "0x4000535")]
		PopUpShop_15 = 1714,
		[Cpp2IlInjected.Token(Token = "0x4000536")]
		PopUpShop_16 = 1715,
		[Cpp2IlInjected.Token(Token = "0x4000537")]
		PopUpShop_17 = 1716,
		[Cpp2IlInjected.Token(Token = "0x4000538")]
		PopUpShop_18 = 1717,
		[Cpp2IlInjected.Token(Token = "0x4000539")]
		PopUpShop_19 = 1718,
		[Cpp2IlInjected.Token(Token = "0x400053A")]
		PopUpShop_20 = 1719,
		[Cpp2IlInjected.Token(Token = "0x400053B")]
		CustomAvatarItems = 1800,
		[Cpp2IlInjected.Token(Token = "0x400053C")]
		ProgressionEventPurchasableXpBoosts = 1900,
		[Cpp2IlInjected.Token(Token = "0x400053D")]
		PopUpShop_ProgressionEvent_1 = 2000,
		[Cpp2IlInjected.Token(Token = "0x400053E")]
		PopUpShop_ProgressionEvent_2 = 2001,
		[Cpp2IlInjected.Token(Token = "0x400053F")]
		PopUpShop_ProgressionEvent_3 = 2002,
		[Cpp2IlInjected.Token(Token = "0x4000540")]
		PopUpShop_ProgressionEvent_4 = 2003,
		[Cpp2IlInjected.Token(Token = "0x4000541")]
		PopUpShop_ProgressionEvent_5 = 2004,
		[Cpp2IlInjected.Token(Token = "0x4000542")]
		RoomOffers = 2100,
		[Cpp2IlInjected.Token(Token = "0x4000543")]
		MyLittleMonsters = 2200,
		[Cpp2IlInjected.Token(Token = "0x4000544")]
		Destiny = 2201,
		[Cpp2IlInjected.Token(Token = "0x4000545")]
		RunTheBlock = 2202,
		[Cpp2IlInjected.Token(Token = "0x4000546")]
		RROStorefront_ToBeNamed_2 = 2203,
		[Cpp2IlInjected.Token(Token = "0x4000547")]
		DevStorefront_DoNotAddToWatch_1 = 2300,
		[Cpp2IlInjected.Token(Token = "0x4000548")]
		DevStorefront_DoNotAddToWatch_2 = 2301,
		[Cpp2IlInjected.Token(Token = "0x4000549")]
		DevStorefront_DoNotAddToWatch_3 = 2302,
		[Cpp2IlInjected.Token(Token = "0x400054A")]
		DevStorefront_DoNotAddToWatch_4 = 2303,
		[Cpp2IlInjected.Token(Token = "0x400054B")]
		DevStorefront_DoNotAddToWatch_5 = 2304,
		[Cpp2IlInjected.Token(Token = "0x400054C")]
		Roomie = 2400,
		[Cpp2IlInjected.Token(Token = "0x400054D")]
		PurchasePromotions = 2500
	}
	[Cpp2IlInjected.Token(Token = "0x2000118")]
	public enum PurchasableItemType
	{
		[Cpp2IlInjected.Token(Token = "0x400054F")]
		GiftDrop,
		[Cpp2IlInjected.Token(Token = "0x4000550")]
		SeasonTier,
		[Cpp2IlInjected.Token(Token = "0x4000551")]
		SeasonEliteUpgrade
	}
	[Cpp2IlInjected.Token(Token = "0x2000119")]
	public enum StorefrontBalanceAddTypes
	{
		[Cpp2IlInjected.Token(Token = "0x4000553")]
		Invalid = 0,
		[Cpp2IlInjected.Token(Token = "0x4000554")]
		DirectBalanceWithMultiplier = 1,
		[Cpp2IlInjected.Token(Token = "0x4000555")]
		FromGiftBox = 2,
		[Cpp2IlInjected.Token(Token = "0x4000556")]
		NUXChallenge = 10,
		[Cpp2IlInjected.Token(Token = "0x4000557")]
		AllNUXChallenges = 11,
		[Cpp2IlInjected.Token(Token = "0x4000558")]
		DailyChallenge = 100,
		[Cpp2IlInjected.Token(Token = "0x4000559")]
		AllDailyChallenges = 101,
		[Cpp2IlInjected.Token(Token = "0x400055A")]
		FinishActivity = 200,
		[Cpp2IlInjected.Token(Token = "0x400055B")]
		RecRoyaleMatchFinished = 250,
		[Cpp2IlInjected.Token(Token = "0x400055C")]
		ChecklistCredit = 303,
		[Cpp2IlInjected.Token(Token = "0x400055D")]
		WonGame = 1000,
		[Cpp2IlInjected.Token(Token = "0x400055E")]
		LostGame = 1001,
		[Cpp2IlInjected.Token(Token = "0x400055F")]
		WonGameRateLimited = 1002,
		[Cpp2IlInjected.Token(Token = "0x4000560")]
		WonGamePartial = 1003,
		[Cpp2IlInjected.Token(Token = "0x4000561")]
		LevelUp = 1100,
		[Cpp2IlInjected.Token(Token = "0x4000562")]
		Registered = 1200,
		[Cpp2IlInjected.Token(Token = "0x4000563")]
		CreatorReward = 1300,
		[Cpp2IlInjected.Token(Token = "0x4000564")]
		CommercePurchase = 1400,
		[Cpp2IlInjected.Token(Token = "0x4000565")]
		CommercePurchaseRevoked = 1401,
		[Cpp2IlInjected.Token(Token = "0x4000566")]
		Manual_Refund = 2000,
		[Cpp2IlInjected.Token(Token = "0x4000567")]
		Manual_Thanks = 2010,
		[Cpp2IlInjected.Token(Token = "0x4000568")]
		Manual_Apology = 2020,
		[Cpp2IlInjected.Token(Token = "0x4000569")]
		TestOnly = 8000
	}
	[Cpp2IlInjected.Token(Token = "0x200011A")]
	public enum RateLimitTypes
	{
		[Cpp2IlInjected.Token(Token = "0x400056B")]
		Interval,
		[Cpp2IlInjected.Token(Token = "0x400056C")]
		PerDay
	}
	[Cpp2IlInjected.Token(Token = "0x200011B")]
	public enum Discount
	{
		[Cpp2IlInjected.Token(Token = "0x400056E")]
		PERCENTAGE = 1,
		[Cpp2IlInjected.Token(Token = "0x400056F")]
		EXACT_AMOUNT
	}
	[Cpp2IlInjected.Token(Token = "0x200011C")]
	[Utf8JsonSerializable]
	public class SkuPurchaseMetadata : IEquatable<SkuPurchaseMetadata>
	{
		[Cpp2IlInjected.Token(Token = "0x17000360")]
		public int? PurchaseReminderId
		{
			[Cpp2IlInjected.Token(Token = "0x600079C")]
			[Cpp2IlInjected.Address(RVA = "0xAA5FB0", Offset = "0xAA53B0", VA = "0x180AA5FB0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600079D")]
			[Cpp2IlInjected.Address(RVA = "0xB96550", Offset = "0xB95950", VA = "0x180B96550")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000361")]
		public int? PurchaseCampaignId
		{
			[Cpp2IlInjected.Token(Token = "0x600079E")]
			[Cpp2IlInjected.Address(RVA = "0xAAA880", Offset = "0xAA9C80", VA = "0x180AAA880")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600079F")]
			[Cpp2IlInjected.Address(RVA = "0x10BA780", Offset = "0x10B9B80", VA = "0x1810BA780")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000362")]
		public int? RRPlusSignUpBonusId
		{
			[Cpp2IlInjected.Token(Token = "0x60007A0")]
			[Cpp2IlInjected.Address(RVA = "0xAAB1C0", Offset = "0xAAA5C0", VA = "0x180AAB1C0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60007A1")]
			[Cpp2IlInjected.Address(RVA = "0xB30430", Offset = "0xB2F830", VA = "0x180B30430")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000363")]
		public List<ItemPurchaseMethodId>? BonusPurchasableItemIds
		{
			[Cpp2IlInjected.Token(Token = "0x60007A2")]
			[Cpp2IlInjected.Address(RVA = "0xAAA820", Offset = "0xAA9C20", VA = "0x180AAA820")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60007A3")]
			[Cpp2IlInjected.Address(RVA = "0xAA67D0", Offset = "0xAA5BD0", VA = "0x180AA67D0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000364")]
		public List<GrantableId>? BonusSelectableGrantableIds
		{
			[Cpp2IlInjected.Token(Token = "0x60007A4")]
			[Cpp2IlInjected.Address(RVA = "0xAAA140", Offset = "0xAA9540", VA = "0x180AAA140")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60007A5")]
			[Cpp2IlInjected.Address(RVA = "0xAADB00", Offset = "0xAACF00", VA = "0x180AADB00")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000365")]
		public int? GiftRecipientAccountId
		{
			[Cpp2IlInjected.Token(Token = "0x60007A6")]
			[Cpp2IlInjected.Address(RVA = "0xAAA030", Offset = "0xAA9430", VA = "0x180AAA030")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60007A7")]
			[Cpp2IlInjected.Address(RVA = "0xAAF810", Offset = "0xAAEC10", VA = "0x180AAF810")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000366")]
		public string? GiftRecipientMessage
		{
			[Cpp2IlInjected.Token(Token = "0x60007A8")]
			[Cpp2IlInjected.Address(RVA = "0xAAA810", Offset = "0xAA9C10", VA = "0x180AAA810")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60007A9")]
			[Cpp2IlInjected.Address(RVA = "0xAAA840", Offset = "0xAA9C40", VA = "0x180AAA840")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60007AA")]
		[Cpp2IlInjected.Address(RVA = "0x771C420", Offset = "0x771B820", VA = "0x18771C420", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60007AB")]
		[Cpp2IlInjected.Address(RVA = "0x771C6A0", Offset = "0x771BAA0", VA = "0x18771C6A0")]
		public static SkuPurchaseMetadata WTGHORWCNUN(int? a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60007AC")]
		[Cpp2IlInjected.Address(RVA = "0x771BE20", Offset = "0x771B220", VA = "0x18771BE20", Slot = "4")]
		public bool Equals(SkuPurchaseMetadata? other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60007AD")]
		[Cpp2IlInjected.Address(RVA = "0x771C0E0", Offset = "0x771B4E0", VA = "0x18771C0E0")]
		private static bool FZSCKJAUNVT(List<ItemPurchaseMethodId>? a, List<ItemPurchaseMethodId>? b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60007AE")]
		[Cpp2IlInjected.Address(RVA = "0x771BFE0", Offset = "0x771B3E0", VA = "0x18771BFE0", Slot = "0")]
		public override bool Equals(object? obj)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60007AF")]
		[Cpp2IlInjected.Address(RVA = "0x771C180", Offset = "0x771B580", VA = "0x18771C180", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60007B0")]
		[Cpp2IlInjected.Address(RVA = "0xAAC8E0", Offset = "0xAABCE0", VA = "0x180AAC8E0")]
		public SkuPurchaseMetadata()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200011D")]
	public struct UnifiedItemId : IEquatable<UnifiedItemId>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000577")]
		public readonly UnifiedItemType ItemType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x4000578")]
		private readonly int NumberId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000579")]
		private readonly Guid Guid;

		[Cpp2IlInjected.Token(Token = "0x17000367")]
		public Guid RJLHPNPKKRE
		{
			[Cpp2IlInjected.Token(Token = "0x60007B1")]
			[Cpp2IlInjected.Address(RVA = "0x771FA30", Offset = "0x771EE30", VA = "0x18771FA30")]
			get
			{
				return default(Guid);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000368")]
		public int XZQBFWBFLPG
		{
			[Cpp2IlInjected.Token(Token = "0x60007B2")]
			[Cpp2IlInjected.Address(RVA = "0x771F6C0", Offset = "0x771EAC0", VA = "0x18771F6C0")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000369")]
		public string EOWRDLLBFKA
		{
			[Cpp2IlInjected.Token(Token = "0x60007B3")]
			[Cpp2IlInjected.Address(RVA = "0x771F6D0", Offset = "0x771EAD0", VA = "0x18771F6D0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60007B4")]
		[Cpp2IlInjected.Address(RVA = "0x7720020", Offset = "0x771F420", VA = "0x187720020")]
		public static bool WNIWTQLPHSC(string a, [Out] UnifiedItemId b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60007B5")]
		[Cpp2IlInjected.Address(RVA = "0x771FAA0", Offset = "0x771EEA0", VA = "0x18771FAA0")]
		public static bool QJTEWQCVSKB(string a, [Out] UnifiedItemId b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60007B6")]
		[Cpp2IlInjected.Address(RVA = "0x771F870", Offset = "0x771EC70", VA = "0x18771F870")]
		public static UnifiedItemId GOSREBZXXNK(int a)
		{
			return default(UnifiedItemId);
		}

		[Cpp2IlInjected.Token(Token = "0x60007B7")]
		[Cpp2IlInjected.Address(RVA = "0x771FEE0", Offset = "0x771F2E0", VA = "0x18771FEE0")]
		public static UnifiedItemId VHVGTPOUVUW(Guid a)
		{
			return default(UnifiedItemId);
		}

		[Cpp2IlInjected.Token(Token = "0x60007B8")]
		[Cpp2IlInjected.Address(RVA = "0x771FD60", Offset = "0x771F160", VA = "0x18771FD60")]
		private static bool QWXABWWECLT(string a, [Out] UnifiedItemType b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60007B9")]
		[Cpp2IlInjected.Address(RVA = "0x7720420", Offset = "0x771F820", VA = "0x187720420")]
		private UnifiedItemId(UnifiedItemType itemType, int? purchasableGiftDropId, Guid? customAvatarItemId)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60007BA")]
		[Cpp2IlInjected.Address(RVA = "0x771F710", Offset = "0x771EB10", VA = "0x18771F710", Slot = "4")]
		public bool Equals(UnifiedItemId other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60007BB")]
		[Cpp2IlInjected.Address(RVA = "0x771F780", Offset = "0x771EB80", VA = "0x18771F780", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60007BC")]
		[Cpp2IlInjected.Address(RVA = "0x771F9A0", Offset = "0x771EDA0", VA = "0x18771F9A0", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60007BD")]
		[Cpp2IlInjected.Address(RVA = "0x771FE50", Offset = "0x771F250", VA = "0x18771FE50", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200011E")]
	[Utf8JsonSerializable]
	public abstract class UGCPurchasableIdentifier : IEquatable<UGCPurchasableIdentifier>
	{
		[Cpp2IlInjected.Token(Token = "0x1700036A")]
		public Guid itemId
		{
			[Cpp2IlInjected.Token(Token = "0x60007BE")]
			[Cpp2IlInjected.Address(RVA = "0xBAF500", Offset = "0xBAE900", VA = "0x180BAF500")]
			[CompilerGenerated]
			get
			{
				return default(Guid);
			}
			[Cpp2IlInjected.Token(Token = "0x60007BF")]
			[Cpp2IlInjected.Address(RVA = "0xBAF520", Offset = "0xBAE920", VA = "0x180BAF520")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60007C0")]
		[Cpp2IlInjected.Address(RVA = "0x771F1B0", Offset = "0x771E5B0", VA = "0x18771F1B0", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60007C1")]
		[Cpp2IlInjected.Address(RVA = "0x771F130", Offset = "0x771E530", VA = "0x18771F130", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60007C2")]
		[Cpp2IlInjected.Address(RVA = "0x771AF30", Offset = "0x771A330", VA = "0x18771AF30", Slot = "4")]
		public bool Equals(UGCPurchasableIdentifier other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60007C3")]
		[Cpp2IlInjected.Address(RVA = "0x771F020", Offset = "0x771E420", VA = "0x18771F020", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60007C4")]
		[Cpp2IlInjected.Address(Slot = "5")]
		public abstract UGCPurchasableIdentifier Clone();

		[Cpp2IlInjected.Token(Token = "0x60007C5")]
		[Cpp2IlInjected.Address(RVA = "0xAAC8E0", Offset = "0xAABCE0", VA = "0x180AAC8E0")]
		protected UGCPurchasableIdentifier()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200011F")]
	public enum UGCPurchasableItemType
	{
		[Cpp2IlInjected.Token(Token = "0x400057C")]
		RoomKey,
		[Cpp2IlInjected.Token(Token = "0x400057D")]
		RoomConsumable,
		[Cpp2IlInjected.Token(Token = "0x400057E")]
		RoomCurrencyPurchaseOffer,
		[Cpp2IlInjected.Token(Token = "0x400057F")]
		CustomAvatarItem,
		[Cpp2IlInjected.Token(Token = "0x4000580")]
		StoreUGCAvatarItem,
		[Cpp2IlInjected.Token(Token = "0x4000581")]
		RoomOffer,
		[Cpp2IlInjected.Token(Token = "0x4000582")]
		UNDEFINED
	}
	[Cpp2IlInjected.Token(Token = "0x2000120")]
	[Utf8JsonSerializable]
	public class UGCPurchasableItemIdentifier : UGCPurchasableIdentifier, IEquatable<UGCPurchasableItemIdentifier>
	{
		[Cpp2IlInjected.Token(Token = "0x1700036B")]
		public UGCPurchasableItemType itemType
		{
			[Cpp2IlInjected.Token(Token = "0x60007C6")]
			[Cpp2IlInjected.Address(RVA = "0xAB5660", Offset = "0xAB4A60", VA = "0x180AB5660")]
			[CompilerGenerated]
			get
			{
				return default(UGCPurchasableItemType);
			}
			[Cpp2IlInjected.Token(Token = "0x60007C7")]
			[Cpp2IlInjected.Address(RVA = "0xB07AB0", Offset = "0xB06EB0", VA = "0x180B07AB0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60007C8")]
		[Cpp2IlInjected.Address(RVA = "0x771F370", Offset = "0x771E770", VA = "0x18771F370", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60007C9")]
		[Cpp2IlInjected.Address(RVA = "0x771F2F0", Offset = "0x771E6F0", VA = "0x18771F2F0", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60007CA")]
		[Cpp2IlInjected.Address(RVA = "0xAAC8E0", Offset = "0xAABCE0", VA = "0x180AAC8E0")]
		public UGCPurchasableItemIdentifier()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60007CB")]
		[Cpp2IlInjected.Address(RVA = "0x771F460", Offset = "0x771E860", VA = "0x18771F460")]
		public UGCPurchasableItemIdentifier(UGCPurchasableItemType itemType, Guid itemId)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60007CC")]
		[Cpp2IlInjected.Address(RVA = "0x771F400", Offset = "0x771E800", VA = "0x18771F400")]
		public static UGCPurchasableItemIdentifier VHVGTPOUVUW(Guid a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60007CD")]
		[Cpp2IlInjected.Address(RVA = "0x771F290", Offset = "0x771E690", VA = "0x18771F290", Slot = "6")]
		public bool Equals(UGCPurchasableItemIdentifier other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60007CE")]
		[Cpp2IlInjected.Address(RVA = "0x771F220", Offset = "0x771E620", VA = "0x18771F220", Slot = "5")]
		public override UGCPurchasableIdentifier Clone()
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000121")]
	public static class GFQREDGJCBF
	{
		[Cpp2IlInjected.Token(Token = "0x60007CF")]
		[Cpp2IlInjected.Address(RVA = "0x7717640", Offset = "0x7716A40", VA = "0x187717640")]
		public static UGCPurchasableItemIdentifier AODAERRLJWF(this UGCPurchasableItem a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60007D0")]
		[Cpp2IlInjected.Address(RVA = "0x7717720", Offset = "0x7716B20", VA = "0x187717720")]
		public static UGCPurchasableItemIdentifier VGEAHQWEIVR(string a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60007D1")]
		[Cpp2IlInjected.Address(RVA = "0x77176B0", Offset = "0x7716AB0", VA = "0x1877176B0")]
		public static UGCPurchasableItemIdentifier GKWGCJXHNOM(Guid a)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000122")]
	[Utf8JsonSerializable]
	public class UGCPurchasableItem
	{
		[Cpp2IlInjected.Token(Token = "0x1700036C")]
		public UGCPurchasableItemType ItemType
		{
			[Cpp2IlInjected.Token(Token = "0x60007D2")]
			[Cpp2IlInjected.Address(RVA = "0xAA3110", Offset = "0xAA2510", VA = "0x180AA3110")]
			[CompilerGenerated]
			get
			{
				return default(UGCPurchasableItemType);
			}
			[Cpp2IlInjected.Token(Token = "0x60007D3")]
			[Cpp2IlInjected.Address(RVA = "0xAAB1D0", Offset = "0xAAA5D0", VA = "0x180AAB1D0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700036D")]
		public Guid ItemId
		{
			[Cpp2IlInjected.Token(Token = "0x60007D4")]
			[Cpp2IlInjected.Address(RVA = "0x18ECC50", Offset = "0x18EC050", VA = "0x1818ECC50")]
			[CompilerGenerated]
			get
			{
				return default(Guid);
			}
			[Cpp2IlInjected.Token(Token = "0x60007D5")]
			[Cpp2IlInjected.Address(RVA = "0x5E206F0", Offset = "0x5E1FAF0", VA = "0x185E206F0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700036E")]
		public string Name
		{
			[Cpp2IlInjected.Token(Token = "0x60007D6")]
			[Cpp2IlInjected.Address(RVA = "0xAAA820", Offset = "0xAA9C20", VA = "0x180AAA820")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60007D7")]
			[Cpp2IlInjected.Address(RVA = "0xAA67D0", Offset = "0xAA5BD0", VA = "0x180AA67D0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700036F")]
		public string Description
		{
			[Cpp2IlInjected.Token(Token = "0x60007D8")]
			[Cpp2IlInjected.Address(RVA = "0xAAA140", Offset = "0xAA9540", VA = "0x180AAA140")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60007D9")]
			[Cpp2IlInjected.Address(RVA = "0xAADB00", Offset = "0xAACF00", VA = "0x180AADB00")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000370")]
		public string ImageName
		{
			[Cpp2IlInjected.Token(Token = "0x60007DA")]
			[Cpp2IlInjected.Address(RVA = "0xAAA030", Offset = "0xAA9430", VA = "0x180AAA030")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60007DB")]
			[Cpp2IlInjected.Address(RVA = "0xAAA110", Offset = "0xAA9510", VA = "0x180AAA110")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000371")]
		public long? RoomId
		{
			[Cpp2IlInjected.Token(Token = "0x60007DC")]
			[Cpp2IlInjected.Address(RVA = "0xD8F2E0", Offset = "0xD8E6E0", VA = "0x180D8F2E0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60007DD")]
			[Cpp2IlInjected.Address(RVA = "0xD8F190", Offset = "0xD8E590", VA = "0x180D8F190")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000372")]
		public long Price
		{
			[Cpp2IlInjected.Token(Token = "0x60007DE")]
			[Cpp2IlInjected.Address(RVA = "0xAA3370", Offset = "0xAA2770", VA = "0x180AA3370")]
			[CompilerGenerated]
			get
			{
				return default(long);
			}
			[Cpp2IlInjected.Token(Token = "0x60007DF")]
			[Cpp2IlInjected.Address(RVA = "0xCDA990", Offset = "0xCD9D90", VA = "0x180CDA990")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000373")]
		public Guid? PurchaseCurrencyId
		{
			[Cpp2IlInjected.Token(Token = "0x60007E0")]
			[Cpp2IlInjected.Address(RVA = "0x771AE90", Offset = "0x771A290", VA = "0x18771AE90")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60007E1")]
			[Cpp2IlInjected.Address(RVA = "0x771AEB0", Offset = "0x771A2B0", VA = "0x18771AEB0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000374")]
		public DateTime CreatedAt
		{
			[Cpp2IlInjected.Token(Token = "0x60007E2")]
			[Cpp2IlInjected.Address(RVA = "0xAA5380", Offset = "0xAA4780", VA = "0x180AA5380")]
			[CompilerGenerated]
			get
			{
				return default(DateTime);
			}
			[Cpp2IlInjected.Token(Token = "0x60007E3")]
			[Cpp2IlInjected.Address(RVA = "0xCE06C0", Offset = "0xCDFAC0", VA = "0x180CE06C0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000375")]
		public DateTime ModifiedAt
		{
			[Cpp2IlInjected.Token(Token = "0x60007E4")]
			[Cpp2IlInjected.Address(RVA = "0xAAD010", Offset = "0xAAC410", VA = "0x180AAD010")]
			[CompilerGenerated]
			get
			{
				return default(DateTime);
			}
			[Cpp2IlInjected.Token(Token = "0x60007E5")]
			[Cpp2IlInjected.Address(RVA = "0xCDFFC0", Offset = "0xCDF3C0", VA = "0x180CDFFC0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60007E6")]
		[Cpp2IlInjected.Address(RVA = "0xAAC8E0", Offset = "0xAABCE0", VA = "0x180AAC8E0")]
		public UGCPurchasableItem()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60007E7")]
		[Cpp2IlInjected.Address(RVA = "0x771F550", Offset = "0x771E950", VA = "0x18771F550")]
		public UGCPurchasableItem(UGCPurchasableItemType itemType, Guid itemId, [Optional] string name, [Optional] string description, [Optional] string imageName, [Optional] long? roomId, long price = 0L, [Optional] Guid? purchaseCurrencyId, [Optional] DateTime createdAt, [Optional] DateTime modifiedAt)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60007E8")]
		[Cpp2IlInjected.Address(RVA = "0x771F4A0", Offset = "0x771E8A0", VA = "0x18771F4A0", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}
}
namespace RecNet.ConsumableEffects.AvatarItemEffects
{
	[Cpp2IlInjected.Token(Token = "0x2000123")]
	public interface BTEMKFGAFEH
	{
		[Cpp2IlInjected.Token(Token = "0x17000376")]
		string Name
		{
			[Cpp2IlInjected.Token(Token = "0x60007E9")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000124")]
	public interface XGXXIDUPYSM<out a> : BTEMKFGAFEH where a : struct
	{
		[Cpp2IlInjected.Token(Token = "0x17000377")]
		a Id
		{
			[Cpp2IlInjected.Token(Token = "0x60007EA")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000125")]
	[Utf8JsonSerializable]
	public class AvatarEffectConfigDTO : ZTDEQBSEMSX
	{
		[Cpp2IlInjected.Token(Token = "0x17000378")]
		public List<AvatarEffectKeyDTO> AvailableEffects
		{
			[Cpp2IlInjected.Token(Token = "0x60007EB")]
			[Cpp2IlInjected.Address(RVA = "0xAA5FB0", Offset = "0xAA53B0", VA = "0x180AA5FB0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60007EC")]
			[Cpp2IlInjected.Address(RVA = "0xAA5FC0", Offset = "0xAA53C0", VA = "0x180AA5FC0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000379")]
		public List<PotionBottleConfigDTO> PotionBottleOverrides
		{
			[Cpp2IlInjected.Token(Token = "0x60007ED")]
			[Cpp2IlInjected.Address(RVA = "0xAAA880", Offset = "0xAA9C80", VA = "0x180AAA880")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60007EE")]
			[Cpp2IlInjected.Address(RVA = "0xAAA120", Offset = "0xAA9520", VA = "0x180AAA120")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700037A")]
		public List<DriverTypeBottleConfigDTO> DriverTypeConfigs
		{
			[Cpp2IlInjected.Token(Token = "0x60007EF")]
			[Cpp2IlInjected.Address(RVA = "0xAAB1C0", Offset = "0xAAA5C0", VA = "0x180AAB1C0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60007F0")]
			[Cpp2IlInjected.Address(RVA = "0xAA67C0", Offset = "0xAA5BC0", VA = "0x180AA67C0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700037B")]
		public List<AuraConfigDTO> AuraConfigs
		{
			[Cpp2IlInjected.Token(Token = "0x60007F1")]
			[Cpp2IlInjected.Address(RVA = "0xAAA820", Offset = "0xAA9C20", VA = "0x180AAA820")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60007F2")]
			[Cpp2IlInjected.Address(RVA = "0xAA67D0", Offset = "0xAA5BD0", VA = "0x180AA67D0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700037C")]
		public List<GradientConfigDTO> GradientConfigs
		{
			[Cpp2IlInjected.Token(Token = "0x60007F3")]
			[Cpp2IlInjected.Address(RVA = "0xAAA140", Offset = "0xAA9540", VA = "0x180AAA140")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60007F4")]
			[Cpp2IlInjected.Address(RVA = "0xAADB00", Offset = "0xAACF00", VA = "0x180AADB00")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700037D")]
		public List<AnimationCurveConfigDTO> AnimationCurveConfigs
		{
			[Cpp2IlInjected.Token(Token = "0x60007F5")]
			[Cpp2IlInjected.Address(RVA = "0xAAA030", Offset = "0xAA9430", VA = "0x180AAA030")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60007F6")]
			[Cpp2IlInjected.Address(RVA = "0xAAA110", Offset = "0xAA9510", VA = "0x180AAA110")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700037E")]
		public List<TextureEffectDTO> TextureEffectConfigs
		{
			[Cpp2IlInjected.Token(Token = "0x60007F7")]
			[Cpp2IlInjected.Address(RVA = "0xAAA810", Offset = "0xAA9C10", VA = "0x180AAA810")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60007F8")]
			[Cpp2IlInjected.Address(RVA = "0xAAA840", Offset = "0xAA9C40", VA = "0x180AAA840")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700037F")]
		public List<PlayerScaleEffectDTO> PlayerScaleEffectConfigs
		{
			[Cpp2IlInjected.Token(Token = "0x60007F9")]
			[Cpp2IlInjected.Address(RVA = "0xAAA160", Offset = "0xAA9560", VA = "0x180AAA160")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60007FA")]
			[Cpp2IlInjected.Address(RVA = "0xAAA870", Offset = "0xAA9C70", VA = "0x180AAA870")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000380")]
		public List<PlayerMovementSpeedEffectDTO> PlayerMovementSpeedEffectConfigs
		{
			[Cpp2IlInjected.Token(Token = "0x60007FB")]
			[Cpp2IlInjected.Address(RVA = "0xAA3370", Offset = "0xAA2770", VA = "0x180AA3370")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60007FC")]
			[Cpp2IlInjected.Address(RVA = "0xAA3390", Offset = "0xAA2790", VA = "0x180AA3390")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000381")]
		public DriverConfigDTO PlayerVelocityDriverConfig
		{
			[Cpp2IlInjected.Token(Token = "0x60007FD")]
			[Cpp2IlInjected.Address(RVA = "0xAA3150", Offset = "0xAA2550", VA = "0x180AA3150")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60007FE")]
			[Cpp2IlInjected.Address(RVA = "0xAA33A0", Offset = "0xAA27A0", VA = "0x180AA33A0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000382")]
		public DriverConfigDTO PlayerVoiceVolumeDriverConfig
		{
			[Cpp2IlInjected.Token(Token = "0x60007FF")]
			[Cpp2IlInjected.Address(RVA = "0xAA3380", Offset = "0xAA2780", VA = "0x180AA3380")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000800")]
			[Cpp2IlInjected.Address(RVA = "0xAA3130", Offset = "0xAA2530", VA = "0x180AA3130")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000383")]
		public DriverConfigDTO PlayerHighFivesDriverConfig
		{
			[Cpp2IlInjected.Token(Token = "0x6000801")]
			[Cpp2IlInjected.Address(RVA = "0xAA3120", Offset = "0xAA2520", VA = "0x180AA3120")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000802")]
			[Cpp2IlInjected.Address(RVA = "0xAA3140", Offset = "0xAA2540", VA = "0x180AA3140")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000803")]
		[Cpp2IlInjected.Address(RVA = "0x7713910", Offset = "0x7712D10", VA = "0x187713910", Slot = "4")]
		public void NTJAWBDBXVU()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000804")]
		[Cpp2IlInjected.Address(RVA = "0x7713920", Offset = "0x7712D20", VA = "0x187713920")]
		public AvatarEffectConfigDTO()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000126")]
	[Utf8JsonSerializable]
	public class AvatarEffectKeyDTO : IEquatable<AvatarEffectKeyDTO>
	{
		[Cpp2IlInjected.Token(Token = "0x17000384")]
		public AvatarItemEffectChannel EffectChannel
		{
			[Cpp2IlInjected.Token(Token = "0x6000805")]
			[Cpp2IlInjected.Address(RVA = "0xAF8E00", Offset = "0xAF8200", VA = "0x180AF8E00")]
			[CompilerGenerated]
			get
			{
				return default(AvatarItemEffectChannel);
			}
			[Cpp2IlInjected.Token(Token = "0x6000806")]
			[Cpp2IlInjected.Address(RVA = "0xB22470", Offset = "0xB21870", VA = "0x180B22470")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000385")]
		public DriverType DriverType
		{
			[Cpp2IlInjected.Token(Token = "0x6000807")]
			[Cpp2IlInjected.Address(RVA = "0xB22480", Offset = "0xB21880", VA = "0x180B22480")]
			[CompilerGenerated]
			get
			{
				return default(DriverType);
			}
			[Cpp2IlInjected.Token(Token = "0x6000808")]
			[Cpp2IlInjected.Address(RVA = "0xB22790", Offset = "0xB21B90", VA = "0x180B22790")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000386")]
		public Guid DriverConfigKey
		{
			[Cpp2IlInjected.Token(Token = "0x6000809")]
			[Cpp2IlInjected.Address(RVA = "0x18ECC50", Offset = "0x18EC050", VA = "0x1818ECC50")]
			[CompilerGenerated]
			get
			{
				return default(Guid);
			}
			[Cpp2IlInjected.Token(Token = "0x600080A")]
			[Cpp2IlInjected.Address(RVA = "0x5E206F0", Offset = "0x5E1FAF0", VA = "0x185E206F0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000387")]
		public Guid ApplierConfigKey
		{
			[Cpp2IlInjected.Token(Token = "0x600080B")]
			[Cpp2IlInjected.Address(RVA = "0xB8A250", Offset = "0xB89650", VA = "0x180B8A250")]
			[CompilerGenerated]
			get
			{
				return default(Guid);
			}
			[Cpp2IlInjected.Token(Token = "0x600080C")]
			[Cpp2IlInjected.Address(RVA = "0xB8A0D0", Offset = "0xB894D0", VA = "0x180B8A0D0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600080D")]
		[Cpp2IlInjected.Address(RVA = "0x7713BD0", Offset = "0x7712FD0", VA = "0x187713BD0", Slot = "4")]
		public bool Equals(AvatarEffectKeyDTO other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600080E")]
		[Cpp2IlInjected.Address(RVA = "0x7713C70", Offset = "0x7713070", VA = "0x187713C70", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600080F")]
		[Cpp2IlInjected.Address(RVA = "0x7713DD0", Offset = "0x77131D0", VA = "0x187713DD0", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[SpecialName]
		[Cpp2IlInjected.Token(Token = "0x6000810")]
		[Cpp2IlInjected.Address(RVA = "0x128AB20", Offset = "0x1289F20", VA = "0x18128AB20")]
		public static bool ZWISVWGZSLY(AvatarEffectKeyDTO a, AvatarEffectKeyDTO b)
		{
			return default(bool);
		}

		[SpecialName]
		[Cpp2IlInjected.Token(Token = "0x6000811")]
		[Cpp2IlInjected.Address(RVA = "0x128AB00", Offset = "0x1289F00", VA = "0x18128AB00")]
		public static bool ZPGHGHNXRJT(AvatarEffectKeyDTO a, AvatarEffectKeyDTO b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000812")]
		[Cpp2IlInjected.Address(RVA = "0xAAC8E0", Offset = "0xAABCE0", VA = "0x180AAC8E0")]
		public AvatarEffectKeyDTO()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000127")]
	[Utf8JsonSerializable]
	public class DriverConfigDTO : XGXXIDUPYSM<DriverType>, BTEMKFGAFEH
	{
		[Cpp2IlInjected.Token(Token = "0x17000388")]
		public DriverType Id
		{
			[Cpp2IlInjected.Token(Token = "0x6000813")]
			[Cpp2IlInjected.Address(RVA = "0xAF8E00", Offset = "0xAF8200", VA = "0x180AF8E00", Slot = "4")]
			[CompilerGenerated]
			get
			{
				return default(DriverType);
			}
			[Cpp2IlInjected.Token(Token = "0x6000814")]
			[Cpp2IlInjected.Address(RVA = "0xB22470", Offset = "0xB21870", VA = "0x180B22470")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000389")]
		public string Name
		{
			[Cpp2IlInjected.Token(Token = "0x6000815")]
			[Cpp2IlInjected.Address(RVA = "0xAAA880", Offset = "0xAA9C80", VA = "0x180AAA880", Slot = "5")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000816")]
			[Cpp2IlInjected.Address(RVA = "0xAAA120", Offset = "0xAA9520", VA = "0x180AAA120")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700038A")]
		public AnimationCurveDTO AnimationCurve
		{
			[Cpp2IlInjected.Token(Token = "0x6000817")]
			[Cpp2IlInjected.Address(RVA = "0xAAB1C0", Offset = "0xAAA5C0", VA = "0x180AAB1C0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000818")]
			[Cpp2IlInjected.Address(RVA = "0xAA67C0", Offset = "0xAA5BC0", VA = "0x180AA67C0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700038B")]
		public float ValueAttackRate
		{
			[Cpp2IlInjected.Token(Token = "0x6000819")]
			[Cpp2IlInjected.Address(RVA = "0xDBC5E0", Offset = "0xDBB9E0", VA = "0x180DBC5E0")]
			[CompilerGenerated]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x600081A")]
			[Cpp2IlInjected.Address(RVA = "0x1104310", Offset = "0x1103710", VA = "0x181104310")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700038C")]
		public float ValueDecayRate
		{
			[Cpp2IlInjected.Token(Token = "0x600081B")]
			[Cpp2IlInjected.Address(RVA = "0xB781D0", Offset = "0xB775D0", VA = "0x180B781D0")]
			[CompilerGenerated]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x600081C")]
			[Cpp2IlInjected.Address(RVA = "0xBAF510", Offset = "0xBAE910", VA = "0x180BAF510")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700038D")]
		public float EffectOverdrive
		{
			[Cpp2IlInjected.Token(Token = "0x600081D")]
			[Cpp2IlInjected.Address(RVA = "0xB781C0", Offset = "0xB775C0", VA = "0x180B781C0")]
			[CompilerGenerated]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x600081E")]
			[Cpp2IlInjected.Address(RVA = "0xD82740", Offset = "0xD81B40", VA = "0x180D82740")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600081F")]
		[Cpp2IlInjected.Address(RVA = "0x7715BB0", Offset = "0x7714FB0", VA = "0x187715BB0")]
		public DriverConfigDTO()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000128")]
	[Utf8JsonSerializable]
	public class PotionBottleConfigDTO
	{
		[Cpp2IlInjected.Token(Token = "0x1700038E")]
		public AvatarEffectKeyDTO Key
		{
			[Cpp2IlInjected.Token(Token = "0x6000820")]
			[Cpp2IlInjected.Address(RVA = "0xAA5FB0", Offset = "0xAA53B0", VA = "0x180AA5FB0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000821")]
			[Cpp2IlInjected.Address(RVA = "0xAA5FC0", Offset = "0xAA53C0", VA = "0x180AA5FC0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700038F")]
		public string BottleTextureName
		{
			[Cpp2IlInjected.Token(Token = "0x6000822")]
			[Cpp2IlInjected.Address(RVA = "0xAAA880", Offset = "0xAA9C80", VA = "0x180AAA880")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000823")]
			[Cpp2IlInjected.Address(RVA = "0xAAA120", Offset = "0xAA9520", VA = "0x180AAA120")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000390")]
		public ColorConfig LiquidColor
		{
			[Cpp2IlInjected.Token(Token = "0x6000824")]
			[Cpp2IlInjected.Address(RVA = "0xAAB1C0", Offset = "0xAAA5C0", VA = "0x180AAB1C0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000825")]
			[Cpp2IlInjected.Address(RVA = "0xAA67C0", Offset = "0xAA5BC0", VA = "0x180AA67C0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000826")]
		[Cpp2IlInjected.Address(RVA = "0x771A680", Offset = "0x7719A80", VA = "0x18771A680")]
		public PotionBottleConfigDTO()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000129")]
	[Utf8JsonSerializable]
	public class DriverTypeBottleConfigDTO
	{
		[Cpp2IlInjected.Token(Token = "0x17000391")]
		public DriverType DriverType
		{
			[Cpp2IlInjected.Token(Token = "0x6000827")]
			[Cpp2IlInjected.Address(RVA = "0xAF8E00", Offset = "0xAF8200", VA = "0x180AF8E00")]
			[CompilerGenerated]
			get
			{
				return default(DriverType);
			}
			[Cpp2IlInjected.Token(Token = "0x6000828")]
			[Cpp2IlInjected.Address(RVA = "0xB22470", Offset = "0xB21870", VA = "0x180B22470")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000392")]
		public string TextureName
		{
			[Cpp2IlInjected.Token(Token = "0x6000829")]
			[Cpp2IlInjected.Address(RVA = "0xAAA880", Offset = "0xAA9C80", VA = "0x180AAA880")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600082A")]
			[Cpp2IlInjected.Address(RVA = "0xAAA120", Offset = "0xAA9520", VA = "0x180AAA120")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600082B")]
		[Cpp2IlInjected.Address(RVA = "0xAAC8E0", Offset = "0xAABCE0", VA = "0x180AAC8E0")]
		public DriverTypeBottleConfigDTO()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200012A")]
	[Utf8JsonSerializable]
	public class RemapConfigDTO : XGXXIDUPYSM<Guid>, BTEMKFGAFEH
	{
		[Cpp2IlInjected.Token(Token = "0x17000393")]
		public string Name
		{
			[Cpp2IlInjected.Token(Token = "0x600082C")]
			[Cpp2IlInjected.Address(RVA = "0xAA5FB0", Offset = "0xAA53B0", VA = "0x180AA5FB0", Slot = "5")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600082D")]
			[Cpp2IlInjected.Address(RVA = "0xAA5FC0", Offset = "0xAA53C0", VA = "0x180AA5FC0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000394")]
		public Guid Id
		{
			[Cpp2IlInjected.Token(Token = "0x600082E")]
			[Cpp2IlInjected.Address(RVA = "0xC66740", Offset = "0xC65B40", VA = "0x180C66740", Slot = "4")]
			[CompilerGenerated]
			get
			{
				return default(Guid);
			}
			[Cpp2IlInjected.Token(Token = "0x600082F")]
			[Cpp2IlInjected.Address(RVA = "0xC66840", Offset = "0xC65C40", VA = "0x180C66840")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000395")]
		public float MinRemappedValue
		{
			[Cpp2IlInjected.Token(Token = "0x6000830")]
			[Cpp2IlInjected.Address(RVA = "0xDBC5E0", Offset = "0xDBB9E0", VA = "0x180DBC5E0")]
			[CompilerGenerated]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x6000831")]
			[Cpp2IlInjected.Address(RVA = "0x1104310", Offset = "0x1103710", VA = "0x181104310")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000396")]
		public float MinRemappedNormalValue
		{
			[Cpp2IlInjected.Token(Token = "0x6000832")]
			[Cpp2IlInjected.Address(RVA = "0xB781D0", Offset = "0xB775D0", VA = "0x180B781D0")]
			[CompilerGenerated]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x6000833")]
			[Cpp2IlInjected.Address(RVA = "0xBAF510", Offset = "0xBAE910", VA = "0x180BAF510")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000397")]
		public float MaxRemappedNormalValue
		{
			[Cpp2IlInjected.Token(Token = "0x6000834")]
			[Cpp2IlInjected.Address(RVA = "0xB781C0", Offset = "0xB775C0", VA = "0x180B781C0")]
			[CompilerGenerated]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x6000835")]
			[Cpp2IlInjected.Address(RVA = "0xD82740", Offset = "0xD81B40", VA = "0x180D82740")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000398")]
		public float MaxRemappedValue
		{
			[Cpp2IlInjected.Token(Token = "0x6000836")]
			[Cpp2IlInjected.Address(RVA = "0xF3EA30", Offset = "0xF3DE30", VA = "0x180F3EA30")]
			[CompilerGenerated]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x6000837")]
			[Cpp2IlInjected.Address(RVA = "0x1C75270", Offset = "0x1C74670", VA = "0x181C75270")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000838")]
		[Cpp2IlInjected.Address(RVA = "0xAAC8E0", Offset = "0xAABCE0", VA = "0x180AAC8E0")]
		public RemapConfigDTO()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200012B")]
	[Utf8JsonSerializable]
	public class AuraConfigDTO : XGXXIDUPYSM<Guid>, BTEMKFGAFEH
	{
		[Cpp2IlInjected.Token(Token = "0x17000399")]
		public string Name
		{
			[Cpp2IlInjected.Token(Token = "0x6000839")]
			[Cpp2IlInjected.Address(RVA = "0x77138B0", Offset = "0x7712CB0", VA = "0x1877138B0", Slot = "5")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700039A")]
		public Guid Id
		{
			[Cpp2IlInjected.Token(Token = "0x600083A")]
			[Cpp2IlInjected.Address(RVA = "0xBAF500", Offset = "0xBAE900", VA = "0x180BAF500", Slot = "4")]
			[CompilerGenerated]
			get
			{
				return default(Guid);
			}
			[Cpp2IlInjected.Token(Token = "0x600083B")]
			[Cpp2IlInjected.Address(RVA = "0xBAF520", Offset = "0xBAE920", VA = "0x180BAF520")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700039B")]
		public int AuraId
		{
			[Cpp2IlInjected.Token(Token = "0x600083C")]
			[Cpp2IlInjected.Address(RVA = "0xAB5660", Offset = "0xAB4A60", VA = "0x180AB5660")]
			[CompilerGenerated]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x600083D")]
			[Cpp2IlInjected.Address(RVA = "0xB07AB0", Offset = "0xB06EB0", VA = "0x180B07AB0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700039C")]
		public string TextureName
		{
			[Cpp2IlInjected.Token(Token = "0x600083E")]
			[Cpp2IlInjected.Address(RVA = "0xAAA820", Offset = "0xAA9C20", VA = "0x180AAA820")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600083F")]
			[Cpp2IlInjected.Address(RVA = "0xAA67D0", Offset = "0xAA5BD0", VA = "0x180AA67D0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700039D")]
		public ColorConfig Color
		{
			[Cpp2IlInjected.Token(Token = "0x6000840")]
			[Cpp2IlInjected.Address(RVA = "0xAAA140", Offset = "0xAA9540", VA = "0x180AAA140")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000841")]
			[Cpp2IlInjected.Address(RVA = "0xAADB00", Offset = "0xAACF00", VA = "0x180AADB00")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000842")]
		[Cpp2IlInjected.Address(RVA = "0x7713840", Offset = "0x7712C40", VA = "0x187713840")]
		public AuraConfigDTO()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200012C")]
	[Utf8JsonSerializable]
	public class GradientConfigDTO : ZTDEQBSEMSX, XGXXIDUPYSM<Guid>, BTEMKFGAFEH
	{
		[Cpp2IlInjected.Token(Token = "0x1700039E")]
		public string Name
		{
			[Cpp2IlInjected.Token(Token = "0x6000843")]
			[Cpp2IlInjected.Address(RVA = "0xAA5FB0", Offset = "0xAA53B0", VA = "0x180AA5FB0", Slot = "6")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000844")]
			[Cpp2IlInjected.Address(RVA = "0xAA5FC0", Offset = "0xAA53C0", VA = "0x180AA5FC0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700039F")]
		public Guid Id
		{
			[Cpp2IlInjected.Token(Token = "0x6000845")]
			[Cpp2IlInjected.Address(RVA = "0xC66740", Offset = "0xC65B40", VA = "0x180C66740", Slot = "5")]
			[CompilerGenerated]
			get
			{
				return default(Guid);
			}
			[Cpp2IlInjected.Token(Token = "0x6000846")]
			[Cpp2IlInjected.Address(RVA = "0xC66840", Offset = "0xC65C40", VA = "0x180C66840")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170003A0")]
		public float GradientTime
		{
			[Cpp2IlInjected.Token(Token = "0x6000847")]
			[Cpp2IlInjected.Address(RVA = "0xDBC5E0", Offset = "0xDBB9E0", VA = "0x180DBC5E0")]
			[CompilerGenerated]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x6000848")]
			[Cpp2IlInjected.Address(RVA = "0x1104310", Offset = "0x1103710", VA = "0x181104310")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170003A1")]
		public GradientType GradientType
		{
			[Cpp2IlInjected.Token(Token = "0x6000849")]
			[Cpp2IlInjected.Address(RVA = "0x17F0050", Offset = "0x17EF450", VA = "0x1817F0050")]
			[CompilerGenerated]
			get
			{
				return default(GradientType);
			}
			[Cpp2IlInjected.Token(Token = "0x600084A")]
			[Cpp2IlInjected.Address(RVA = "0xD836D0", Offset = "0xD82AD0", VA = "0x180D836D0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170003A2")]
		public List<GradientKeyDTO> ColorKeys
		{
			[Cpp2IlInjected.Token(Token = "0x600084B")]
			[Cpp2IlInjected.Address(RVA = "0xAAA140", Offset = "0xAA9540", VA = "0x180AAA140")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600084C")]
			[Cpp2IlInjected.Address(RVA = "0xAADB00", Offset = "0xAACF00", VA = "0x180AADB00")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600084D")]
		[Cpp2IlInjected.Address(RVA = "0x7717CE0", Offset = "0x77170E0", VA = "0x187717CE0", Slot = "4")]
		public void NTJAWBDBXVU()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600084E")]
		[Cpp2IlInjected.Address(RVA = "0x7717D50", Offset = "0x7717150", VA = "0x187717D50")]
		public GradientConfigDTO()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200012D")]
	[Utf8JsonSerializable]
	public class AnimationCurveConfigDTO : XGXXIDUPYSM<Guid>, BTEMKFGAFEH
	{
		[Cpp2IlInjected.Token(Token = "0x170003A3")]
		public string Name
		{
			[Cpp2IlInjected.Token(Token = "0x600084F")]
			[Cpp2IlInjected.Address(RVA = "0xAA5FB0", Offset = "0xAA53B0", VA = "0x180AA5FB0", Slot = "5")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000850")]
			[Cpp2IlInjected.Address(RVA = "0xAA5FC0", Offset = "0xAA53C0", VA = "0x180AA5FC0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170003A4")]
		public Guid Id
		{
			[Cpp2IlInjected.Token(Token = "0x6000851")]
			[Cpp2IlInjected.Address(RVA = "0xC66740", Offset = "0xC65B40", VA = "0x180C66740", Slot = "4")]
			[CompilerGenerated]
			get
			{
				return default(Guid);
			}
			[Cpp2IlInjected.Token(Token = "0x6000852")]
			[Cpp2IlInjected.Address(RVA = "0xC66840", Offset = "0xC65C40", VA = "0x180C66840")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170003A5")]
		public AnimationCurveDTO AnimationCurve
		{
			[Cpp2IlInjected.Token(Token = "0x6000853")]
			[Cpp2IlInjected.Address(RVA = "0xAAA820", Offset = "0xAA9C20", VA = "0x180AAA820")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000854")]
			[Cpp2IlInjected.Address(RVA = "0xAA67D0", Offset = "0xAA5BD0", VA = "0x180AA67D0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000855")]
		[Cpp2IlInjected.Address(RVA = "0x7713750", Offset = "0x7712B50", VA = "0x187713750")]
		public AnimationCurveConfigDTO()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200012E")]
	[Utf8JsonSerializable]
	public class AnimationCurveDTO
	{
		[Cpp2IlInjected.Token(Token = "0x170003A6")]
		public List<AnimationCurveKeyDTO> CurveKeys
		{
			[Cpp2IlInjected.Token(Token = "0x6000856")]
			[Cpp2IlInjected.Address(RVA = "0xAA5FB0", Offset = "0xAA53B0", VA = "0x180AA5FB0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000857")]
			[Cpp2IlInjected.Address(RVA = "0xAA5FC0", Offset = "0xAA53C0", VA = "0x180AA5FC0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000858")]
		[Cpp2IlInjected.Address(RVA = "0x77137C0", Offset = "0x7712BC0", VA = "0x1877137C0")]
		public AnimationCurveDTO()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200012F")]
	[Utf8JsonSerializable]
	public class AnimationCurveKeyDTO
	{
		[Cpp2IlInjected.Token(Token = "0x170003A7")]
		public float Time
		{
			[Cpp2IlInjected.Token(Token = "0x6000859")]
			[Cpp2IlInjected.Address(RVA = "0x10BF500", Offset = "0x10BE900", VA = "0x1810BF500")]
			[CompilerGenerated]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x600085A")]
			[Cpp2IlInjected.Address(RVA = "0x10D7F80", Offset = "0x10D7380", VA = "0x1810D7F80")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170003A8")]
		public float Value
		{
			[Cpp2IlInjected.Token(Token = "0x600085B")]
			[Cpp2IlInjected.Address(RVA = "0xBC0B50", Offset = "0xBBFF50", VA = "0x180BC0B50")]
			[CompilerGenerated]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x600085C")]
			[Cpp2IlInjected.Address(RVA = "0xBC04D0", Offset = "0xBBF8D0", VA = "0x180BC04D0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170003A9")]
		public float InSlope
		{
			[Cpp2IlInjected.Token(Token = "0x600085D")]
			[Cpp2IlInjected.Address(RVA = "0xB05AA0", Offset = "0xB04EA0", VA = "0x180B05AA0")]
			[CompilerGenerated]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x600085E")]
			[Cpp2IlInjected.Address(RVA = "0x10D4A80", Offset = "0x10D3E80", VA = "0x1810D4A80")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170003AA")]
		public float OutSlope
		{
			[Cpp2IlInjected.Token(Token = "0x600085F")]
			[Cpp2IlInjected.Address(RVA = "0xB05E50", Offset = "0xB05250", VA = "0x180B05E50")]
			[CompilerGenerated]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x6000860")]
			[Cpp2IlInjected.Address(RVA = "0x10D4A90", Offset = "0x10D3E90", VA = "0x1810D4A90")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170003AB")]
		public float InWeight
		{
			[Cpp2IlInjected.Token(Token = "0x6000861")]
			[Cpp2IlInjected.Address(RVA = "0xB05E60", Offset = "0xB05260", VA = "0x180B05E60")]
			[CompilerGenerated]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x6000862")]
			[Cpp2IlInjected.Address(RVA = "0xDB0130", Offset = "0xDAF530", VA = "0x180DB0130")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170003AC")]
		public float OutWeight
		{
			[Cpp2IlInjected.Token(Token = "0x6000863")]
			[Cpp2IlInjected.Address(RVA = "0xB07AC0", Offset = "0xB06EC0", VA = "0x180B07AC0")]
			[CompilerGenerated]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x6000864")]
			[Cpp2IlInjected.Address(RVA = "0xB07770", Offset = "0xB06B70", VA = "0x180B07770")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170003AD")]
		public int TangentMode
		{
			[Cpp2IlInjected.Token(Token = "0x6000865")]
			[Cpp2IlInjected.Address(RVA = "0xAAB1A0", Offset = "0xAAA5A0", VA = "0x180AAB1A0")]
			[CompilerGenerated]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x6000866")]
			[Cpp2IlInjected.Address(RVA = "0xAAB1B0", Offset = "0xAAA5B0", VA = "0x180AAB1B0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170003AE")]
		public int WeightedMode
		{
			[Cpp2IlInjected.Token(Token = "0x6000867")]
			[Cpp2IlInjected.Address(RVA = "0xC4E8F0", Offset = "0xC4DCF0", VA = "0x180C4E8F0")]
			[CompilerGenerated]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x6000868")]
			[Cpp2IlInjected.Address(RVA = "0x1ACB200", Offset = "0x1ACA600", VA = "0x181ACB200")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000869")]
		[Cpp2IlInjected.Address(RVA = "0xAAC8E0", Offset = "0xAABCE0", VA = "0x180AAC8E0")]
		public AnimationCurveKeyDTO()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000130")]
	[Utf8JsonSerializable]
	public class GradientKeyDTO
	{
		[Cpp2IlInjected.Token(Token = "0x170003AF")]
		public float Time
		{
			[Cpp2IlInjected.Token(Token = "0x600086A")]
			[Cpp2IlInjected.Address(RVA = "0x10BF500", Offset = "0x10BE900", VA = "0x1810BF500")]
			[CompilerGenerated]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x600086B")]
			[Cpp2IlInjected.Address(RVA = "0x10D7F80", Offset = "0x10D7380", VA = "0x1810D7F80")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170003B0")]
		public ColorConfig Color
		{
			[Cpp2IlInjected.Token(Token = "0x600086C")]
			[Cpp2IlInjected.Address(RVA = "0xAAA880", Offset = "0xAA9C80", VA = "0x180AAA880")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600086D")]
			[Cpp2IlInjected.Address(RVA = "0xAAA120", Offset = "0xAA9520", VA = "0x180AAA120")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600086E")]
		[Cpp2IlInjected.Address(RVA = "0x7717DE0", Offset = "0x77171E0", VA = "0x187717DE0")]
		public GradientKeyDTO()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000131")]
	[Utf8JsonSerializable]
	public class ColorConfig
	{
		[Cpp2IlInjected.Token(Token = "0x170003B1")]
		public float R
		{
			[Cpp2IlInjected.Token(Token = "0x600086F")]
			[Cpp2IlInjected.Address(RVA = "0x10BF500", Offset = "0x10BE900", VA = "0x1810BF500")]
			[CompilerGenerated]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x6000870")]
			[Cpp2IlInjected.Address(RVA = "0x10D7F80", Offset = "0x10D7380", VA = "0x1810D7F80")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170003B2")]
		public float G
		{
			[Cpp2IlInjected.Token(Token = "0x6000871")]
			[Cpp2IlInjected.Address(RVA = "0xBC0B50", Offset = "0xBBFF50", VA = "0x180BC0B50")]
			[CompilerGenerated]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x6000872")]
			[Cpp2IlInjected.Address(RVA = "0xBC04D0", Offset = "0xBBF8D0", VA = "0x180BC04D0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170003B3")]
		public float B
		{
			[Cpp2IlInjected.Token(Token = "0x6000873")]
			[Cpp2IlInjected.Address(RVA = "0xB05AA0", Offset = "0xB04EA0", VA = "0x180B05AA0")]
			[CompilerGenerated]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x6000874")]
			[Cpp2IlInjected.Address(RVA = "0x10D4A80", Offset = "0x10D3E80", VA = "0x1810D4A80")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170003B4")]
		public float A
		{
			[Cpp2IlInjected.Token(Token = "0x6000875")]
			[Cpp2IlInjected.Address(RVA = "0xB05E50", Offset = "0xB05250", VA = "0x180B05E50")]
			[CompilerGenerated]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x6000876")]
			[Cpp2IlInjected.Address(RVA = "0x10D4A90", Offset = "0x10D3E90", VA = "0x1810D4A90")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000877")]
		[Cpp2IlInjected.Address(RVA = "0xAAC8E0", Offset = "0xAABCE0", VA = "0x180AAC8E0")]
		public ColorConfig()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000878")]
		[Cpp2IlInjected.Address(RVA = "0x7715460", Offset = "0x7714860", VA = "0x187715460")]
		public ColorConfig(float r, float g, float b, float a = 1f)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000132")]
	[Utf8JsonSerializable]
	public class PlayerScaleEffectDTO : XGXXIDUPYSM<Guid>, BTEMKFGAFEH
	{
		[Cpp2IlInjected.Token(Token = "0x170003B5")]
		public string Name
		{
			[Cpp2IlInjected.Token(Token = "0x6000879")]
			[Cpp2IlInjected.Address(RVA = "0xAA5FB0", Offset = "0xAA53B0", VA = "0x180AA5FB0", Slot = "5")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600087A")]
			[Cpp2IlInjected.Address(RVA = "0xAA5FC0", Offset = "0xAA53C0", VA = "0x180AA5FC0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170003B6")]
		public Guid Id
		{
			[Cpp2IlInjected.Token(Token = "0x600087B")]
			[Cpp2IlInjected.Address(RVA = "0xC66740", Offset = "0xC65B40", VA = "0x180C66740", Slot = "4")]
			[CompilerGenerated]
			get
			{
				return default(Guid);
			}
			[Cpp2IlInjected.Token(Token = "0x600087C")]
			[Cpp2IlInjected.Address(RVA = "0xC66840", Offset = "0xC65C40", VA = "0x180C66840")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170003B7")]
		public AnimationCurveDTO RemapCurve
		{
			[Cpp2IlInjected.Token(Token = "0x600087D")]
			[Cpp2IlInjected.Address(RVA = "0xAAA820", Offset = "0xAA9C20", VA = "0x180AAA820")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600087E")]
			[Cpp2IlInjected.Address(RVA = "0xAA67D0", Offset = "0xAA5BD0", VA = "0x180AA67D0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600087F")]
		[Cpp2IlInjected.Address(RVA = "0x771A610", Offset = "0x7719A10", VA = "0x18771A610")]
		public PlayerScaleEffectDTO()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000133")]
	[Utf8JsonSerializable]
	public class PlayerMovementSpeedEffectDTO : XGXXIDUPYSM<Guid>, BTEMKFGAFEH
	{
		[Cpp2IlInjected.Token(Token = "0x170003B8")]
		public string Name
		{
			[Cpp2IlInjected.Token(Token = "0x6000880")]
			[Cpp2IlInjected.Address(RVA = "0xAA5FB0", Offset = "0xAA53B0", VA = "0x180AA5FB0", Slot = "5")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000881")]
			[Cpp2IlInjected.Address(RVA = "0xAA5FC0", Offset = "0xAA53C0", VA = "0x180AA5FC0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170003B9")]
		public Guid Id
		{
			[Cpp2IlInjected.Token(Token = "0x6000882")]
			[Cpp2IlInjected.Address(RVA = "0xC66740", Offset = "0xC65B40", VA = "0x180C66740", Slot = "4")]
			[CompilerGenerated]
			get
			{
				return default(Guid);
			}
			[Cpp2IlInjected.Token(Token = "0x6000883")]
			[Cpp2IlInjected.Address(RVA = "0xC66840", Offset = "0xC65C40", VA = "0x180C66840")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170003BA")]
		public float WalkSpeedMultiplier
		{
			[Cpp2IlInjected.Token(Token = "0x6000884")]
			[Cpp2IlInjected.Address(RVA = "0xDBC5E0", Offset = "0xDBB9E0", VA = "0x180DBC5E0")]
			[CompilerGenerated]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x6000885")]
			[Cpp2IlInjected.Address(RVA = "0x1104310", Offset = "0x1103710", VA = "0x181104310")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170003BB")]
		public float? CrouchSpeedMultiplier
		{
			[Cpp2IlInjected.Token(Token = "0x6000886")]
			[Cpp2IlInjected.Address(RVA = "0x10D2A70", Offset = "0x10D1E70", VA = "0x1810D2A70")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000887")]
			[Cpp2IlInjected.Address(RVA = "0x10D2AA0", Offset = "0x10D1EA0", VA = "0x1810D2AA0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170003BC")]
		public float? ProneSpeedMultiplier
		{
			[Cpp2IlInjected.Token(Token = "0x6000888")]
			[Cpp2IlInjected.Address(RVA = "0xB30400", Offset = "0xB2F800", VA = "0x180B30400")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000889")]
			[Cpp2IlInjected.Address(RVA = "0xB30440", Offset = "0xB2F840", VA = "0x180B30440")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170003BD")]
		public float TeleportCooldownTimerMultiplier
		{
			[Cpp2IlInjected.Token(Token = "0x600088A")]
			[Cpp2IlInjected.Address(RVA = "0xAD4010", Offset = "0xAD3410", VA = "0x180AD4010")]
			[CompilerGenerated]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x600088B")]
			[Cpp2IlInjected.Address(RVA = "0xAD3D50", Offset = "0xAD3150", VA = "0x180AD3D50")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170003BE")]
		public float? TeleportCrouchCooldownTimerMultiplier
		{
			[Cpp2IlInjected.Token(Token = "0x600088C")]
			[Cpp2IlInjected.Address(RVA = "0xAAA810", Offset = "0xAA9C10", VA = "0x180AAA810")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600088D")]
			[Cpp2IlInjected.Address(RVA = "0xCDACA0", Offset = "0xCDA0A0", VA = "0x180CDACA0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170003BF")]
		public float? TeleportProneCooldownTimerMultiplier
		{
			[Cpp2IlInjected.Token(Token = "0x600088E")]
			[Cpp2IlInjected.Address(RVA = "0xAAA160", Offset = "0xAA9560", VA = "0x180AAA160")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600088F")]
			[Cpp2IlInjected.Address(RVA = "0x10D7F70", Offset = "0x10D7370", VA = "0x1810D7F70")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000890")]
		[Cpp2IlInjected.Address(RVA = "0x771A5F0", Offset = "0x77199F0", VA = "0x18771A5F0")]
		public PlayerMovementSpeedEffectDTO()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000134")]
	[Utf8JsonSerializable]
	public class TextureEffectDTO : XGXXIDUPYSM<Guid>, BTEMKFGAFEH
	{
		[Cpp2IlInjected.Token(Token = "0x170003C0")]
		public string Name
		{
			[Cpp2IlInjected.Token(Token = "0x6000891")]
			[Cpp2IlInjected.Address(RVA = "0xAA5FB0", Offset = "0xAA53B0", VA = "0x180AA5FB0", Slot = "5")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000892")]
			[Cpp2IlInjected.Address(RVA = "0xAA5FC0", Offset = "0xAA53C0", VA = "0x180AA5FC0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170003C1")]
		public Guid Id
		{
			[Cpp2IlInjected.Token(Token = "0x6000893")]
			[Cpp2IlInjected.Address(RVA = "0xC66740", Offset = "0xC65B40", VA = "0x180C66740", Slot = "4")]
			[CompilerGenerated]
			get
			{
				return default(Guid);
			}
			[Cpp2IlInjected.Token(Token = "0x6000894")]
			[Cpp2IlInjected.Address(RVA = "0xC66840", Offset = "0xC65C40", VA = "0x180C66840")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170003C2")]
		public string MaskTextureName
		{
			[Cpp2IlInjected.Token(Token = "0x6000895")]
			[Cpp2IlInjected.Address(RVA = "0xAAA820", Offset = "0xAA9C20", VA = "0x180AAA820")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000896")]
			[Cpp2IlInjected.Address(RVA = "0xAA67D0", Offset = "0xAA5BD0", VA = "0x180AA67D0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170003C3")]
		public string LUTTextureName
		{
			[Cpp2IlInjected.Token(Token = "0x6000897")]
			[Cpp2IlInjected.Address(RVA = "0xAAA140", Offset = "0xAA9540", VA = "0x180AAA140")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000898")]
			[Cpp2IlInjected.Address(RVA = "0xAADB00", Offset = "0xAACF00", VA = "0x180AADB00")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170003C4")]
		public bool UseNormalFade
		{
			[Cpp2IlInjected.Token(Token = "0x6000899")]
			[Cpp2IlInjected.Address(RVA = "0xAD1790", Offset = "0xAD0B90", VA = "0x180AD1790")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x600089A")]
			[Cpp2IlInjected.Address(RVA = "0xAD17A0", Offset = "0xAD0BA0", VA = "0x180AD17A0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170003C5")]
		public float GlobalIntensity
		{
			[Cpp2IlInjected.Token(Token = "0x600089B")]
			[Cpp2IlInjected.Address(RVA = "0xAD4010", Offset = "0xAD3410", VA = "0x180AD4010")]
			[CompilerGenerated]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x600089C")]
			[Cpp2IlInjected.Address(RVA = "0xAD3D50", Offset = "0xAD3150", VA = "0x180AD3D50")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170003C6")]
		public TextureChannelDTO Vfx1
		{
			[Cpp2IlInjected.Token(Token = "0x600089D")]
			[Cpp2IlInjected.Address(RVA = "0xAAA810", Offset = "0xAA9C10", VA = "0x180AAA810")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600089E")]
			[Cpp2IlInjected.Address(RVA = "0xAAA840", Offset = "0xAA9C40", VA = "0x180AAA840")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170003C7")]
		public TextureChannelDTO Vfx2
		{
			[Cpp2IlInjected.Token(Token = "0x600089F")]
			[Cpp2IlInjected.Address(RVA = "0xAAA160", Offset = "0xAA9560", VA = "0x180AAA160")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60008A0")]
			[Cpp2IlInjected.Address(RVA = "0xAAA870", Offset = "0xAA9C70", VA = "0x180AAA870")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170003C8")]
		public TextureChannelDTO Vfx3
		{
			[Cpp2IlInjected.Token(Token = "0x60008A1")]
			[Cpp2IlInjected.Address(RVA = "0xAA3370", Offset = "0xAA2770", VA = "0x180AA3370")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60008A2")]
			[Cpp2IlInjected.Address(RVA = "0xAA3390", Offset = "0xAA2790", VA = "0x180AA3390")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170003C9")]
		public TextureChannelDTO Vfx4
		{
			[Cpp2IlInjected.Token(Token = "0x60008A3")]
			[Cpp2IlInjected.Address(RVA = "0xAA3150", Offset = "0xAA2550", VA = "0x180AA3150")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60008A4")]
			[Cpp2IlInjected.Address(RVA = "0xAA33A0", Offset = "0xAA27A0", VA = "0x180AA33A0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170003CA")]
		public Vector4Dto LUT_ST
		{
			[Cpp2IlInjected.Token(Token = "0x60008A5")]
			[Cpp2IlInjected.Address(RVA = "0xAA3380", Offset = "0xAA2780", VA = "0x180AA3380")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60008A6")]
			[Cpp2IlInjected.Address(RVA = "0xAA3130", Offset = "0xAA2530", VA = "0x180AA3130")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60008A7")]
		[Cpp2IlInjected.Address(RVA = "0x771D4E0", Offset = "0x771C8E0", VA = "0x18771D4E0")]
		public TextureEffectDTO()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000135")]
	[Utf8JsonSerializable]
	public class TextureChannelDTO
	{
		[Cpp2IlInjected.Token(Token = "0x170003CB")]
		public Vector2Dto Scroll
		{
			[Cpp2IlInjected.Token(Token = "0x60008A8")]
			[Cpp2IlInjected.Address(RVA = "0xAA5FB0", Offset = "0xAA53B0", VA = "0x180AA5FB0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60008A9")]
			[Cpp2IlInjected.Address(RVA = "0xAA5FC0", Offset = "0xAA53C0", VA = "0x180AA5FC0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170003CC")]
		public float ColorIntensity
		{
			[Cpp2IlInjected.Token(Token = "0x60008AA")]
			[Cpp2IlInjected.Address(RVA = "0xB05AA0", Offset = "0xB04EA0", VA = "0x180B05AA0")]
			[CompilerGenerated]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x60008AB")]
			[Cpp2IlInjected.Address(RVA = "0x10D4A80", Offset = "0x10D3E80", VA = "0x1810D4A80")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170003CD")]
		public float AlphaIntensity
		{
			[Cpp2IlInjected.Token(Token = "0x60008AC")]
			[Cpp2IlInjected.Address(RVA = "0xB05E50", Offset = "0xB05250", VA = "0x180B05E50")]
			[CompilerGenerated]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x60008AD")]
			[Cpp2IlInjected.Address(RVA = "0x10D4A90", Offset = "0x10D3E90", VA = "0x1810D4A90")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170003CE")]
		public Vector4Dto ST
		{
			[Cpp2IlInjected.Token(Token = "0x60008AE")]
			[Cpp2IlInjected.Address(RVA = "0xAAB1C0", Offset = "0xAAA5C0", VA = "0x180AAB1C0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60008AF")]
			[Cpp2IlInjected.Address(RVA = "0xAA67C0", Offset = "0xAA5BC0", VA = "0x180AA67C0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60008B0")]
		[Cpp2IlInjected.Address(RVA = "0x771D470", Offset = "0x771C870", VA = "0x18771D470")]
		public TextureChannelDTO()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000136")]
	[Utf8JsonSerializable]
	public class Vector2Dto
	{
		[Cpp2IlInjected.Token(Token = "0x170003CF")]
		public float X
		{
			[Cpp2IlInjected.Token(Token = "0x60008B1")]
			[Cpp2IlInjected.Address(RVA = "0x10BF500", Offset = "0x10BE900", VA = "0x1810BF500")]
			[CompilerGenerated]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x60008B2")]
			[Cpp2IlInjected.Address(RVA = "0x10D7F80", Offset = "0x10D7380", VA = "0x1810D7F80")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170003D0")]
		public float Y
		{
			[Cpp2IlInjected.Token(Token = "0x60008B3")]
			[Cpp2IlInjected.Address(RVA = "0xBC0B50", Offset = "0xBBFF50", VA = "0x180BC0B50")]
			[CompilerGenerated]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x60008B4")]
			[Cpp2IlInjected.Address(RVA = "0xBC04D0", Offset = "0xBBF8D0", VA = "0x180BC04D0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60008B5")]
		[Cpp2IlInjected.Address(RVA = "0xAAC8E0", Offset = "0xAABCE0", VA = "0x180AAC8E0")]
		public Vector2Dto()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60008B6")]
		[Cpp2IlInjected.Address(RVA = "0x4E0EE30", Offset = "0x4E0E230", VA = "0x184E0EE30")]
		public Vector2Dto(float x, float y)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000137")]
	[Utf8JsonSerializable]
	public class Vector4Dto : Vector2Dto
	{
		[Cpp2IlInjected.Token(Token = "0x170003D1")]
		public float Z
		{
			[Cpp2IlInjected.Token(Token = "0x60008B7")]
			[Cpp2IlInjected.Address(RVA = "0xB05AA0", Offset = "0xB04EA0", VA = "0x180B05AA0")]
			[CompilerGenerated]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x60008B8")]
			[Cpp2IlInjected.Address(RVA = "0x10D4A80", Offset = "0x10D3E80", VA = "0x1810D4A80")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170003D2")]
		public float W
		{
			[Cpp2IlInjected.Token(Token = "0x60008B9")]
			[Cpp2IlInjected.Address(RVA = "0xB05E50", Offset = "0xB05250", VA = "0x180B05E50")]
			[CompilerGenerated]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x60008BA")]
			[Cpp2IlInjected.Address(RVA = "0x10D4A90", Offset = "0x10D3E90", VA = "0x1810D4A90")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60008BB")]
		[Cpp2IlInjected.Address(RVA = "0xAAC8E0", Offset = "0xAABCE0", VA = "0x180AAC8E0")]
		public Vector4Dto()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60008BC")]
		[Cpp2IlInjected.Address(RVA = "0x7715460", Offset = "0x7714860", VA = "0x187715460")]
		public Vector4Dto(float x, float y, float z, float w)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000138")]
	public enum AvatarItemEffectChannel : byte
	{
		[Cpp2IlInjected.Token(Token = "0x40005E9")]
		Invalid,
		[Cpp2IlInjected.Token(Token = "0x40005EA")]
		Emission,
		[Cpp2IlInjected.Token(Token = "0x40005EB")]
		HairColor,
		[Cpp2IlInjected.Token(Token = "0x40005EC")]
		PlayerHeadScale,
		[Cpp2IlInjected.Token(Token = "0x40005ED")]
		Aura,
		[Cpp2IlInjected.Token(Token = "0x40005EE")]
		Texture,
		[Cpp2IlInjected.Token(Token = "0x40005EF")]
		PlayerAvatarScale,
		[Cpp2IlInjected.Token(Token = "0x40005F0")]
		PlayerMovementSpeed
	}
	[Cpp2IlInjected.Token(Token = "0x2000139")]
	public enum DriverType : byte
	{
		[Cpp2IlInjected.Token(Token = "0x40005F2")]
		Invalid,
		[Cpp2IlInjected.Token(Token = "0x40005F3")]
		PlayerVoiceInput,
		[Cpp2IlInjected.Token(Token = "0x40005F4")]
		PlayerVelocity,
		[Cpp2IlInjected.Token(Token = "0x40005F5")]
		AnimationCurve,
		[Cpp2IlInjected.Token(Token = "0x40005F6")]
		HighFiveCount,
		[Cpp2IlInjected.Token(Token = "0x40005F7")]
		AlwaysOn
	}
	[Cpp2IlInjected.Token(Token = "0x200013A")]
	public enum GradientType : byte
	{
		[Cpp2IlInjected.Token(Token = "0x40005F9")]
		Invalid,
		[Cpp2IlInjected.Token(Token = "0x40005FA")]
		Time,
		[Cpp2IlInjected.Token(Token = "0x40005FB")]
		ValueRamp
	}
	[Cpp2IlInjected.Token(Token = "0x200013B")]
	public static class KTJPWAJARYY
	{
		[Cpp2IlInjected.Token(Token = "0x40005FC")]
		public static readonly AvatarItemEffectChannel[] KCKWUMOZVAS;

		[Cpp2IlInjected.Token(Token = "0x40005FD")]
		public static readonly AvatarItemEffectChannel[] VGBYUBGLYLM;

		[Cpp2IlInjected.Token(Token = "0x40005FE")]
		public static readonly DriverType[] ZRVJPWYVSER;

		[Cpp2IlInjected.Token(Token = "0x40005FF")]
		public static readonly DriverType[] OGTNTKVRKDB;

		[Cpp2IlInjected.Token(Token = "0x60008BD")]
		[Cpp2IlInjected.Address(RVA = "0x77197C0", Offset = "0x7718BC0", VA = "0x1877197C0")]
		public static bool MSKRMMDWAXE(this AvatarItemEffectChannel a)
		{
			return default(bool);
		}
	}
}
namespace RecNet.RoomBoosts
{
	[Cpp2IlInjected.Token(Token = "0x200013D")]
	public interface JKZERUNJVZC
	{
		[Cpp2IlInjected.Token(Token = "0x1400000B")]
		event Action<long, int> HRIWQNIREKQ;

		[Cpp2IlInjected.Token(Token = "0x1400000C")]
		event Action<long> LIPKWGLGLJI;

		[Cpp2IlInjected.Token(Token = "0x60008C7")]
		[Cpp2IlInjected.Address(Slot = "4")]
		Task<int> UUSSABHRBHP(long a, bool b = false, [Optional] CancellationToken c);

		[Cpp2IlInjected.Token(Token = "0x60008C8")]
		[Cpp2IlInjected.Address(Slot = "5")]
		Task<int> XIRFOZXPONG(long a, int b, bool c = false, [Optional] CancellationToken d);

		[Cpp2IlInjected.Token(Token = "0x60008C9")]
		[Cpp2IlInjected.Address(Slot = "6")]
		Task<Dictionary<int, int>> ZIOICATRMJU(long a, IEnumerable<int> b, bool c = false, [Optional] CancellationToken d);
	}
	[Cpp2IlInjected.Token(Token = "0x200013E")]
	public interface XQFRMJKEWXQ
	{
		[Cpp2IlInjected.Token(Token = "0x170003D3")]
		RoomBoostEnabledConfig TQVWMBPOJUC
		{
			[Cpp2IlInjected.Token(Token = "0x60008CB")]
			[Cpp2IlInjected.Address(Slot = "1")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x1400000D")]
		event Action<RoomBoostEnabledConfig> MOXRWNMHABF;

		[Cpp2IlInjected.Token(Token = "0x60008CA")]
		[Cpp2IlInjected.Address(Slot = "0")]
		RoomBoostEnabledState NHMKDTDXATW([Optional] long? a);
	}
	[Cpp2IlInjected.Token(Token = "0x200013F")]
	public enum RoomBoostEnabledState
	{
		[Cpp2IlInjected.Token(Token = "0x4000602")]
		Invalid,
		[Cpp2IlInjected.Token(Token = "0x4000603")]
		Ok,
		[Cpp2IlInjected.Token(Token = "0x4000604")]
		DisabledGlobally,
		[Cpp2IlInjected.Token(Token = "0x4000605")]
		DisabledForRoom
	}
	[Cpp2IlInjected.Token(Token = "0x2000140")]
	public static class YMZXGKJCFKV
	{
		[Cpp2IlInjected.Token(Token = "0x60008CE")]
		[Cpp2IlInjected.Address(RVA = "0x1227D50", Offset = "0x1227150", VA = "0x181227D50")]
		public static bool EMTBUBXDYMW(this RoomBoostEnabledState a)
		{
			return default(bool);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000141")]
	public struct RoomBoostEnabledConfig
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000606")]
		private readonly bool isValid;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1")]
		[Cpp2IlInjected.Token(Token = "0x4000607")]
		private readonly bool roomBoostsEnabledGlobally;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2")]
		[Cpp2IlInjected.Token(Token = "0x4000608")]
		private readonly bool checkRoomIds;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000609")]
		private readonly Func<long, bool> isRoomValidFunc;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400060A")]
		private readonly HashSet<long> roomBoostsEnabledForRooms;

		[Cpp2IlInjected.Token(Token = "0x60008CF")]
		[Cpp2IlInjected.Address(RVA = "0x771ADB0", Offset = "0x771A1B0", VA = "0x18771ADB0")]
		public RoomBoostEnabledConfig(bool roomBoostsEnabledGlobally, bool checkRoomIds, HashSet<long> roomBoostsEnabledForRooms, Func<long, bool> isRoomValidFunc)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60008D0")]
		[Cpp2IlInjected.Address(RVA = "0x771AA50", Offset = "0x7719E50", VA = "0x18771AA50")]
		public RoomBoostEnabledState NHMKDTDXATW(long? a)
		{
			return default(RoomBoostEnabledState);
		}

		[Cpp2IlInjected.Token(Token = "0x60008D1")]
		[Cpp2IlInjected.Address(RVA = "0x771ACB0", Offset = "0x771A0B0", VA = "0x18771ACB0")]
		public bool YCFHXRQDUDB(RoomBoostEnabledConfig a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60008D2")]
		[Cpp2IlInjected.Address(RVA = "0x771AB70", Offset = "0x7719F70", VA = "0x18771AB70", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}
}
namespace RecNet.Tags
{
	[Cpp2IlInjected.Token(Token = "0x2000142")]
	public enum TagType
	{
		[Cpp2IlInjected.Token(Token = "0x400060C")]
		General,
		[Cpp2IlInjected.Token(Token = "0x400060D")]
		Auto,
		[Cpp2IlInjected.Token(Token = "0x400060E")]
		AGOnly,
		[Cpp2IlInjected.Token(Token = "0x400060F")]
		Banned
	}
	[Cpp2IlInjected.Token(Token = "0x2000143")]
	public enum TagStatus
	{
		[Cpp2IlInjected.Token(Token = "0x4000611")]
		Success,
		[Cpp2IlInjected.Token(Token = "0x4000612")]
		TooManyTags,
		[Cpp2IlInjected.Token(Token = "0x4000613")]
		TagUseRestricted,
		[Cpp2IlInjected.Token(Token = "0x4000614")]
		InvalidTag,
		[Cpp2IlInjected.Token(Token = "0x4000615")]
		InappropriateTag,
		[Cpp2IlInjected.Token(Token = "0x4000616")]
		TagTooLong,
		[Cpp2IlInjected.Token(Token = "0x4000617")]
		TagNotFound,
		[Cpp2IlInjected.Token(Token = "0x4000618")]
		TagAlreadyExists,
		[Cpp2IlInjected.Token(Token = "0x4000619")]
		NoChange,
		[Cpp2IlInjected.Token(Token = "0x400061A")]
		TagRepeated,
		[Cpp2IlInjected.Token(Token = "0x400061B")]
		LacksPermission,
		[Cpp2IlInjected.Token(Token = "0x400061C")]
		RoomDoesNotExist,
		[Cpp2IlInjected.Token(Token = "0x400061D")]
		InventionDoesNotExist,
		[Cpp2IlInjected.Token(Token = "0x400061E")]
		ReservedWordViolation
	}
	[Cpp2IlInjected.Token(Token = "0x2000144")]
	[Utf8JsonSerializable]
	public class ModifyTagsResponse
	{
		[Cpp2IlInjected.Token(Token = "0x170003D4")]
		public TagStatus Result
		{
			[Cpp2IlInjected.Token(Token = "0x60008D3")]
			[Cpp2IlInjected.Address(RVA = "0xAA3110", Offset = "0xAA2510", VA = "0x180AA3110")]
			[CompilerGenerated]
			get
			{
				return default(TagStatus);
			}
			[Cpp2IlInjected.Token(Token = "0x60008D4")]
			[Cpp2IlInjected.Address(RVA = "0xAAB1D0", Offset = "0xAAA5D0", VA = "0x180AAB1D0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170003D5")]
		public List<string> Tags
		{
			[Cpp2IlInjected.Token(Token = "0x60008D5")]
			[Cpp2IlInjected.Address(RVA = "0xAAA880", Offset = "0xAA9C80", VA = "0x180AAA880")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60008D6")]
			[Cpp2IlInjected.Address(RVA = "0xAAA120", Offset = "0xAA9520", VA = "0x180AAA120")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60008D7")]
		[Cpp2IlInjected.Address(RVA = "0x771A030", Offset = "0x7719430", VA = "0x18771A030")]
		public string SIGAYAQXLMT(int a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60008D8")]
		[Cpp2IlInjected.Address(RVA = "0xAAC8E0", Offset = "0xAABCE0", VA = "0x180AAC8E0")]
		public ModifyTagsResponse()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000145")]
	[Utf8JsonSerializable]
	public class TagDTO
	{
		[Cpp2IlInjected.Token(Token = "0x170003D6")]
		public string Tag
		{
			[Cpp2IlInjected.Token(Token = "0x60008D9")]
			[Cpp2IlInjected.Address(RVA = "0xAA5FB0", Offset = "0xAA53B0", VA = "0x180AA5FB0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60008DA")]
			[Cpp2IlInjected.Address(RVA = "0xAA5FC0", Offset = "0xAA53C0", VA = "0x180AA5FC0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170003D7")]
		public TagType Type
		{
			[Cpp2IlInjected.Token(Token = "0x60008DB")]
			[Cpp2IlInjected.Address(RVA = "0xAAC980", Offset = "0xAABD80", VA = "0x180AAC980")]
			[CompilerGenerated]
			get
			{
				return default(TagType);
			}
			[Cpp2IlInjected.Token(Token = "0x60008DC")]
			[Cpp2IlInjected.Address(RVA = "0xAB2F40", Offset = "0xAB2340", VA = "0x180AB2F40")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60008DD")]
		[Cpp2IlInjected.Address(RVA = "0xAAC8E0", Offset = "0xAABCE0", VA = "0x180AAC8E0")]
		public TagDTO()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000146")]
	public static class ARSUDJVEZHM
	{
		[Cpp2IlInjected.Token(Token = "0x4000623")]
		public const string LVPKNZWLVJO = "costume";

		[Cpp2IlInjected.Token(Token = "0x4000624")]
		public const string VGSPOLNAFVE = "gadget";

		[Cpp2IlInjected.Token(Token = "0x4000625")]
		public const string FHCINEHDMRX = "holotar";

		[Cpp2IlInjected.Token(Token = "0x4000626")]
		public const string DOFHVCXEPOX = "large";

		[Cpp2IlInjected.Token(Token = "0x4000627")]
		public const string IBVPRFXNQXR = "medium";

		[Cpp2IlInjected.Token(Token = "0x4000628")]
		public const string LTXSKJSXFCX = "small";

		[Cpp2IlInjected.Token(Token = "0x4000629")]
		public const string YJVXZEDOVUB = "sound";

		[Cpp2IlInjected.Token(Token = "0x400062A")]
		public const string LPRHKZQUOMW = "dormanchor";

		[Cpp2IlInjected.Token(Token = "0x400062B")]
		public const string VCWVHUNZKJZ = "reccenteranchor";

		[Cpp2IlInjected.Token(Token = "0x400062C")]
		public const string OTZZJKAXYYX = "r2";

		[Cpp2IlInjected.Token(Token = "0x170003D8")]
		public static List<string> LQCQSIERGFF
		{
			[Cpp2IlInjected.Token(Token = "0x60008DE")]
			[Cpp2IlInjected.Address(RVA = "0x7713220", Offset = "0x7712620", VA = "0x187713220")]
			get
			{
				return null;
			}
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000147")]
	public static class ZBWMXIOGVJR
	{
		[Cpp2IlInjected.Token(Token = "0x400062D")]
		public const string FASWYCXPCMW = "beta";

		[Cpp2IlInjected.Token(Token = "0x400062E")]
		public const string YQOMXXPGCYD = "limitsv2";
	}
	[Cpp2IlInjected.Token(Token = "0x2000148")]
	[Utf8JsonSerializable]
	public class GetFiltersResponse
	{
		[Cpp2IlInjected.Token(Token = "0x170003D9")]
		public List<string> PinnedFilters
		{
			[Cpp2IlInjected.Token(Token = "0x60008DF")]
			[Cpp2IlInjected.Address(RVA = "0xAA5FB0", Offset = "0xAA53B0", VA = "0x180AA5FB0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60008E0")]
			[Cpp2IlInjected.Address(RVA = "0xAA5FC0", Offset = "0xAA53C0", VA = "0x180AA5FC0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170003DA")]
		public List<string> PopularFilters
		{
			[Cpp2IlInjected.Token(Token = "0x60008E1")]
			[Cpp2IlInjected.Address(RVA = "0xAAA880", Offset = "0xAA9C80", VA = "0x180AAA880")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60008E2")]
			[Cpp2IlInjected.Address(RVA = "0xAAA120", Offset = "0xAA9520", VA = "0x180AAA120")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170003DB")]
		public List<string> TrendingFilters
		{
			[Cpp2IlInjected.Token(Token = "0x60008E3")]
			[Cpp2IlInjected.Address(RVA = "0xAAB1C0", Offset = "0xAAA5C0", VA = "0x180AAB1C0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60008E4")]
			[Cpp2IlInjected.Address(RVA = "0xAA67C0", Offset = "0xAA5BC0", VA = "0x180AA67C0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60008E5")]
		[Cpp2IlInjected.Address(RVA = "0xAAC8E0", Offset = "0xAABCE0", VA = "0x180AAC8E0")]
		public GetFiltersResponse()
		{
		}
	}
}
namespace RecNet.NetworkSimulator
{
	[Cpp2IlInjected.Token(Token = "0x2000149")]
	public class FilterKey : IEquatable<FilterKey>
	{
		[Cpp2IlInjected.Token(Token = "0x170003DC")]
		[CompilerGenerated]
		protected virtual Type ITQAFHBSGFG
		{
			[Cpp2IlInjected.Token(Token = "0x60008E7")]
			[Cpp2IlInjected.Address(RVA = "0x7717450", Offset = "0x7716850", VA = "0x187717450", Slot = "5")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170003DD")]
		public Service? PKNGRYXVNMR
		{
			[Cpp2IlInjected.Token(Token = "0x60008E8")]
			[Cpp2IlInjected.Address(RVA = "0xAA5FB0", Offset = "0xAA53B0", VA = "0x180AA5FB0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60008E9")]
			[Cpp2IlInjected.Address(RVA = "0xB96550", Offset = "0xB95950", VA = "0x180B96550")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170003DE")]
		public HttpMethod? OBRCJMZKSVJ
		{
			[Cpp2IlInjected.Token(Token = "0x60008EA")]
			[Cpp2IlInjected.Address(RVA = "0xAAA880", Offset = "0xAA9C80", VA = "0x180AAA880")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60008EB")]
			[Cpp2IlInjected.Address(RVA = "0xAAA120", Offset = "0xAA9520", VA = "0x180AAA120")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170003DF")]
		public string? FEZQBCMCKTZ
		{
			[Cpp2IlInjected.Token(Token = "0x60008EC")]
			[Cpp2IlInjected.Address(RVA = "0xAAB1C0", Offset = "0xAAA5C0", VA = "0x180AAB1C0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60008ED")]
			[Cpp2IlInjected.Address(RVA = "0xAA67C0", Offset = "0xAA5BC0", VA = "0x180AA67C0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60008E6")]
		[Cpp2IlInjected.Address(RVA = "0x77175F0", Offset = "0x77169F0", VA = "0x1877175F0")]
		public FilterKey(Service? Service, HttpMethod? Method, string? RequestUriPrefix)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60008EE")]
		[Cpp2IlInjected.Address(RVA = "0x77174A0", Offset = "0x77168A0", VA = "0x1877174A0", Slot = "3")]
		[CompilerGenerated]
		public override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60008EF")]
		[Cpp2IlInjected.Address(RVA = "0x77172D0", Offset = "0x77166D0", VA = "0x1877172D0", Slot = "6")]
		[CompilerGenerated]
		protected virtual bool LXITBKEHWVK(StringBuilder a)
		{
			return default(bool);
		}

		[SpecialName]
		[Cpp2IlInjected.Token(Token = "0x60008F0")]
		[Cpp2IlInjected.Address(RVA = "0xFB47E0", Offset = "0xFB3BE0", VA = "0x180FB47E0")]
		[CompilerGenerated]
		public static bool ZPGHGHNXRJT(FilterKey? a, FilterKey? b)
		{
			return default(bool);
		}

		[SpecialName]
		[Cpp2IlInjected.Token(Token = "0x60008F1")]
		[Cpp2IlInjected.Address(RVA = "0xFB4820", Offset = "0xFB3C20", VA = "0x180FB4820")]
		[CompilerGenerated]
		public static bool ZWISVWGZSLY(FilterKey? a, FilterKey? b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60008F2")]
		[Cpp2IlInjected.Address(RVA = "0x7717120", Offset = "0x7716520", VA = "0x187717120", Slot = "2")]
		[CompilerGenerated]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60008F3")]
		[Cpp2IlInjected.Address(RVA = "0x7716F00", Offset = "0x7716300", VA = "0x187716F00", Slot = "0")]
		[CompilerGenerated]
		public override bool Equals(object? obj)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60008F4")]
		[Cpp2IlInjected.Address(RVA = "0x7716F90", Offset = "0x7716390", VA = "0x187716F90", Slot = "7")]
		[CompilerGenerated]
		public virtual bool Equals(FilterKey? other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60008F5")]
		[Cpp2IlInjected.Address(RVA = "0x77173C0", Offset = "0x77167C0", VA = "0x1877173C0", Slot = "8")]
		[CompilerGenerated]
		public virtual FilterKey OMSRAXDGICF()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60008F6")]
		[Cpp2IlInjected.Address(RVA = "0x7717590", Offset = "0x7716990", VA = "0x187717590")]
		[CompilerGenerated]
		protected FilterKey(FilterKey original)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60008F7")]
		[Cpp2IlInjected.Address(RVA = "0x7717290", Offset = "0x7716690", VA = "0x187717290")]
		[CompilerGenerated]
		public void HYZXLOOBRHM([Out] Service? a, [Out] HttpMethod? b, [Out] string? c)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200014A")]
	public class FilterAction : IEquatable<FilterAction>
	{
		[Cpp2IlInjected.Token(Token = "0x170003E0")]
		[CompilerGenerated]
		protected virtual Type ITQAFHBSGFG
		{
			[Cpp2IlInjected.Token(Token = "0x60008F9")]
			[Cpp2IlInjected.Address(RVA = "0x7716DB0", Offset = "0x77161B0", VA = "0x187716DB0", Slot = "5")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170003E1")]
		public int FTWAEJOVAIS
		{
			[Cpp2IlInjected.Token(Token = "0x60008FA")]
			[Cpp2IlInjected.Address(RVA = "0xAA3110", Offset = "0xAA2510", VA = "0x180AA3110")]
			[CompilerGenerated]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x60008FB")]
			[Cpp2IlInjected.Address(RVA = "0xAAB1D0", Offset = "0xAAA5D0", VA = "0x180AAB1D0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170003E2")]
		public FailureModes RMVLKOSAIQX
		{
			[Cpp2IlInjected.Token(Token = "0x60008FC")]
			[Cpp2IlInjected.Address(RVA = "0xC4E2B0", Offset = "0xC4D6B0", VA = "0x180C4E2B0")]
			[CompilerGenerated]
			get
			{
				return default(FailureModes);
			}
			[Cpp2IlInjected.Token(Token = "0x60008FD")]
			[Cpp2IlInjected.Address(RVA = "0xCDF260", Offset = "0xCDE660", VA = "0x180CDF260")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60008F8")]
		[Cpp2IlInjected.Address(RVA = "0x7716EF0", Offset = "0x77162F0", VA = "0x187716EF0")]
		public FilterAction(int MillisecondDelay, FailureModes FailureMode)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60008FE")]
		[Cpp2IlInjected.Address(RVA = "0x7716E00", Offset = "0x7716200", VA = "0x187716E00", Slot = "3")]
		[CompilerGenerated]
		public override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60008FF")]
		[Cpp2IlInjected.Address(RVA = "0x7716C50", Offset = "0x7716050", VA = "0x187716C50", Slot = "6")]
		[CompilerGenerated]
		protected virtual bool LXITBKEHWVK(StringBuilder a)
		{
			return default(bool);
		}

		[SpecialName]
		[Cpp2IlInjected.Token(Token = "0x6000900")]
		[Cpp2IlInjected.Address(RVA = "0xFB47E0", Offset = "0xFB3BE0", VA = "0x180FB47E0")]
		[CompilerGenerated]
		public static bool ZPGHGHNXRJT(FilterAction? a, FilterAction? b)
		{
			return default(bool);
		}

		[SpecialName]
		[Cpp2IlInjected.Token(Token = "0x6000901")]
		[Cpp2IlInjected.Address(RVA = "0xFB4820", Offset = "0xFB3C20", VA = "0x180FB4820")]
		[CompilerGenerated]
		public static bool ZWISVWGZSLY(FilterAction? a, FilterAction? b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000902")]
		[Cpp2IlInjected.Address(RVA = "0x7716B30", Offset = "0x7715F30", VA = "0x187716B30", Slot = "2")]
		[CompilerGenerated]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000903")]
		[Cpp2IlInjected.Address(RVA = "0x7716AA0", Offset = "0x7715EA0", VA = "0x187716AA0", Slot = "0")]
		[CompilerGenerated]
		public override bool Equals(object? obj)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000904")]
		[Cpp2IlInjected.Address(RVA = "0x7716960", Offset = "0x7715D60", VA = "0x187716960", Slot = "7")]
		[CompilerGenerated]
		public virtual bool Equals(FilterAction? other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000905")]
		[Cpp2IlInjected.Address(RVA = "0x7716D40", Offset = "0x7716140", VA = "0x187716D40", Slot = "8")]
		[CompilerGenerated]
		public virtual FilterAction OMSRAXDGICF()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000906")]
		[Cpp2IlInjected.Address(RVA = "0x25FB0B0", Offset = "0x25FA4B0", VA = "0x1825FB0B0")]
		[CompilerGenerated]
		protected FilterAction(FilterAction original)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000907")]
		[Cpp2IlInjected.Address(RVA = "0x7716C40", Offset = "0x7716040", VA = "0x187716C40")]
		[CompilerGenerated]
		public void HYZXLOOBRHM([Out] int a, [Out] FailureModes b)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200014B")]
	public enum FailureModes
	{
		[Cpp2IlInjected.Token(Token = "0x4000638")]
		None,
		[Cpp2IlInjected.Token(Token = "0x4000639")]
		ConnectionTimeout,
		[Cpp2IlInjected.Token(Token = "0x400063A")]
		InternalServerError
	}
	[Cpp2IlInjected.Token(Token = "0x200014C")]
	public interface SNQKLUNTCHW
	{
		[Cpp2IlInjected.Token(Token = "0x6000908")]
		[Cpp2IlInjected.Address(Slot = "0")]
		IReadOnlyDictionary<FilterKey, FilterAction> WUNTYEPUEOJ();

		[Cpp2IlInjected.Token(Token = "0x6000909")]
		[Cpp2IlInjected.Address(Slot = "1")]
		void RUAFBXGROSM(FilterKey a, FilterAction b);

		[Cpp2IlInjected.Token(Token = "0x600090A")]
		[Cpp2IlInjected.Address(Slot = "2")]
		void UECVKPCKCWA(FilterKey a);

		[Cpp2IlInjected.Token(Token = "0x600090B")]
		[Cpp2IlInjected.Address(Slot = "3")]
		void FBSEIIQIKCE();

		[Cpp2IlInjected.Token(Token = "0x600090C")]
		[Cpp2IlInjected.Address(Slot = "4")]
		Task DDCLHBYWEYZ(Service a, HttpMethod b, string c, CancellationToken d);
	}
}
namespace RecNet.Interfaces
{
	[Cpp2IlInjected.Token(Token = "0x200014D")]
	public interface CSMOEMKHSMU
	{
		[Cpp2IlInjected.Token(Token = "0x600090D")]
		[Cpp2IlInjected.Address(Slot = "0")]
		Task COSYOSEHWVX(bool a, [Optional] CancellationToken b);

		[Cpp2IlInjected.Token(Token = "0x600090E")]
		[Cpp2IlInjected.Address(Slot = "1")]
		Task<int> YBQJDMWVOEI([Optional] CancellationToken a);
	}
}
namespace RecNet.Common
{
	[Cpp2IlInjected.Token(Token = "0x200014E")]
	[Utf8JsonSerializableGeneric]
	public class PPCJEJRUUPJ<a> : DURPPUIUDDT where a : new()
	{
		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x200014F")]
		[CompilerGenerated]
		private struct <OnDeserializedAsync>d__8 : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400063D")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400063E")]
			public AsyncTaskMethodBuilder <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400063F")]
			public PPCJEJRUUPJ<a> <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000640")]
			private IEnumerable<ZTDEQBSEMSX> <list1>5__2;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000641")]
			private object <>u__1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000642")]
			private ConfiguredTaskAwaitable.ConfiguredTaskAwaiter <>u__2;

			[Cpp2IlInjected.Token(Token = "0x6000915")]
			[Cpp2IlInjected.Address(RVA = "0x50B63B0", Offset = "0x50B57B0", VA = "0x1850B63B0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000916")]
			[Cpp2IlInjected.Address(RVA = "0x50B76C0", Offset = "0x50B6AC0", VA = "0x1850B76C0", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170003E3")]
		public IReadOnlyList<a> EUKJLWLSSAE
		{
			[Cpp2IlInjected.Token(Token = "0x600090F")]
			[Cpp2IlInjected.Address(RVA = "0xAA5FB0", Offset = "0xAA53B0", VA = "0x180AA5FB0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000910")]
			[Cpp2IlInjected.Address(RVA = "0xAA5FC0", Offset = "0xAA53C0", VA = "0x180AA5FC0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170003E4")]
		public long CVXFWDKZMDI
		{
			[Cpp2IlInjected.Token(Token = "0x6000911")]
			[Cpp2IlInjected.Address(RVA = "0xAAA880", Offset = "0xAA9C80", VA = "0x180AAA880")]
			[CompilerGenerated]
			get
			{
				return default(long);
			}
			[Cpp2IlInjected.Token(Token = "0x6000912")]
			[Cpp2IlInjected.Address(RVA = "0x10BA780", Offset = "0x10B9B80", VA = "0x1810BA780")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000913")]
		[Cpp2IlInjected.Address(RVA = "0x5A59200", Offset = "0x5A58600", VA = "0x185A59200", Slot = "4")]
		[AsyncStateMachine(typeof(PPCJEJRUUPJ<>.<OnDeserializedAsync>d__8))]
		public Task NLICNVNCYRU()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000914")]
		[Cpp2IlInjected.Address(RVA = "0xAAC8E0", Offset = "0xAABCE0", VA = "0x180AAC8E0")]
		public PPCJEJRUUPJ()
		{
		}
	}
}
namespace RecNet.Common.PlatformPartners
{
	[Cpp2IlInjected.Token(Token = "0x2000150")]
	public enum PlayStationEnvironment
	{
		[Cpp2IlInjected.Token(Token = "0x4000644")]
		Development = 1,
		[Cpp2IlInjected.Token(Token = "0x4000645")]
		QA = 8,
		[Cpp2IlInjected.Token(Token = "0x4000646")]
		Production = 0x100
	}
}
namespace RecNet.Store
{
	[Cpp2IlInjected.Token(Token = "0x2000151")]
	public interface UGOYJKBIWPW : PMWPFJTCYLI
	{
		[Cpp2IlInjected.Token(Token = "0x170003E5")]
		bool PXYPQPIZGMV
		{
			[Cpp2IlInjected.Token(Token = "0x6000917")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x6000918")]
		[Cpp2IlInjected.Address(Slot = "1")]
		Task AuthorizePurchaseAsync(long transactionId, SKU sku);

		[Cpp2IlInjected.Token(Token = "0x6000919")]
		[Cpp2IlInjected.Address(Slot = "2")]
		Task<BCJJYUOGOJS> PurchaseAsync(SKU sku, SkuPurchaseMetadata purchaseMetadata);

		[Cpp2IlInjected.Token(Token = "0x600091A")]
		[Cpp2IlInjected.Address(Slot = "3")]
		Task ValidatePurchasingSupported(AUZBTHOOZRI skuTransaction, CancellationToken cancellationToken);
	}
	[Cpp2IlInjected.Token(Token = "0x2000152")]
	public interface PMWPFJTCYLI
	{
		[Cpp2IlInjected.Token(Token = "0x170003E6")]
		bool JJILEHKBNBS
		{
			[Cpp2IlInjected.Token(Token = "0x600091B")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x600091C")]
		[Cpp2IlInjected.Address(Slot = "1")]
		Task<string> FetchCommerceAccessToken([Optional] CancellationToken cancellationToken);
	}
	[Cpp2IlInjected.Token(Token = "0x2000153")]
	public interface VYZOWKUOHVM
	{
		[Cpp2IlInjected.Token(Token = "0x170003E7")]
		int NUIBZIUXUGF
		{
			[Cpp2IlInjected.Token(Token = "0x6000921")]
			[Cpp2IlInjected.Address(Slot = "4")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x600091D")]
		[Cpp2IlInjected.Address(Slot = "0")]
		Task<IReadOnlyList<SKU>> WGRVUJYCFNR(bool a = false, [Optional] CancellationToken b);

		[Cpp2IlInjected.Token(Token = "0x600091E")]
		[Cpp2IlInjected.Address(Slot = "1")]
		bool UGWTQEUQEET([Out] SKU? a);

		[Cpp2IlInjected.Token(Token = "0x600091F")]
		[Cpp2IlInjected.Address(Slot = "2")]
		Task<SKU> ZDJEXWHTRUP(bool a = false, [Optional] CancellationToken b);

		[Cpp2IlInjected.Token(Token = "0x6000920")]
		[Cpp2IlInjected.Address(Slot = "3")]
		void VSSTEDAXWID(string a = "");
	}
	[Cpp2IlInjected.Token(Token = "0x2000154")]
	public interface THNKXAOQPBK
	{
		[Cpp2IlInjected.Token(Token = "0x6000922")]
		[Cpp2IlInjected.Address(Slot = "0")]
		Task NCATHFYKYBI(AUZBTHOOZRI a, CancellationToken b);

		[Cpp2IlInjected.Token(Token = "0x6000923")]
		[Cpp2IlInjected.Address(Slot = "1")]
		Task YGRRPQMUPGC(AUZBTHOOZRI a, CancellationToken b, [Optional] IILPMOMYNDL? purchaseProgress);
	}
	[Cpp2IlInjected.Token(Token = "0x2000155")]
	public interface IILPMOMYNDL
	{
		[Cpp2IlInjected.Token(Token = "0x6000924")]
		[Cpp2IlInjected.Address(Slot = "0")]
		void UpdateProgress(string text);
	}
	[Cpp2IlInjected.Token(Token = "0x2000156")]
	public interface NOINKPPPCZJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000925")]
		[Cpp2IlInjected.Address(Slot = "0")]
		Task ILEZMUEMZME(AUZBTHOOZRI a, CancellationToken b);
	}
	[Cpp2IlInjected.Token(Token = "0x2000157")]
	public interface ZASLIZELODR
	{
		[Cpp2IlInjected.Token(Token = "0x170003E8")]
		bool MRJMVQUZYXH
		{
			[Cpp2IlInjected.Token(Token = "0x6000926")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000158")]
	public interface KAPLRIRURTO
	{
		[Cpp2IlInjected.Token(Token = "0x6000927")]
		[Cpp2IlInjected.Address(Slot = "0")]
		AUZBTHOOZRI MJJPZLWDGIG(SKU a, SkuPurchaseMetadata b, string c, [Optional] THNKXAOQPBK? purchaseProcessorBehaviorOverride);
	}
	[Cpp2IlInjected.Token(Token = "0x2000159")]
	public interface IPIRDJZWFHF
	{
		[Cpp2IlInjected.Token(Token = "0x6000928")]
		[Cpp2IlInjected.Address(Slot = "0")]
		bool EAUIRUTTZRF(NOINKPPPCZJ a);

		[Cpp2IlInjected.Token(Token = "0x6000929")]
		[Cpp2IlInjected.Address(Slot = "1")]
		bool VUBEIFDETSI(NOINKPPPCZJ a);

		[Cpp2IlInjected.Token(Token = "0x600092A")]
		[Cpp2IlInjected.Address(Slot = "2")]
		Task ORJQNBPWJSC(AUZBTHOOZRI a, CancellationToken b);
	}
	[Cpp2IlInjected.Token(Token = "0x200015A")]
	public interface AUZBTHOOZRI : IDisposable
	{
		[Cpp2IlInjected.Token(Token = "0x170003E9")]
		TransactionState ELTZKMTZBSP
		{
			[Cpp2IlInjected.Token(Token = "0x600092B")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x170003EA")]
		SKU PBJKFHMFCQD
		{
			[Cpp2IlInjected.Token(Token = "0x600092C")]
			[Cpp2IlInjected.Address(Slot = "1")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x170003EB")]
		SkuPurchaseMetadata RRUPSVWOSSU
		{
			[Cpp2IlInjected.Token(Token = "0x600092D")]
			[Cpp2IlInjected.Address(Slot = "2")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x170003EC")]
		string PXJXKOGOJNV
		{
			[Cpp2IlInjected.Token(Token = "0x600092E")]
			[Cpp2IlInjected.Address(Slot = "3")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x170003ED")]
		string PIYBQDESWLG
		{
			[Cpp2IlInjected.Token(Token = "0x600092F")]
			[Cpp2IlInjected.Address(Slot = "4")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x6000930")]
		[Cpp2IlInjected.Address(Slot = "5")]
		Task<SkuPurchaseResult> Purchase(CancellationToken externalToken, [Optional] IILPMOMYNDL? purchaseProgress);

		[Cpp2IlInjected.Token(Token = "0x6000931")]
		[Cpp2IlInjected.Address(Slot = "6")]
		void RSRHMVAYVVK(string a);

		[Cpp2IlInjected.Token(Token = "0x6000932")]
		[Cpp2IlInjected.Address(Slot = "7")]
		void RSRHMVAYVVK<a>(Func<a, string> a, [In] a msgArgs);
	}
	[Cpp2IlInjected.Token(Token = "0x200015B")]
	public abstract class MYOZSVWEHTY
	{
		[Cpp2IlInjected.Token(Token = "0x6000933")]
		[Cpp2IlInjected.Address(RVA = "0xAAC8E0", Offset = "0xAABCE0", VA = "0x180AAC8E0")]
		protected MYOZSVWEHTY()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200015C")]
	public enum PurchaseFailureError
	{
		[Cpp2IlInjected.Token(Token = "0x4000648")]
		Unknown,
		[Cpp2IlInjected.Token(Token = "0x4000649")]
		InAppPurchaseNotAllowedOnAccount,
		[Cpp2IlInjected.Token(Token = "0x400064A")]
		PlatformPurchaseException,
		[Cpp2IlInjected.Token(Token = "0x400064B")]
		PlatformPurchaseFailure,
		[Cpp2IlInjected.Token(Token = "0x400064C")]
		CommerceInitiatePurchaseFailure,
		[Cpp2IlInjected.Token(Token = "0x400064D")]
		FailedToGetPlatformAccessToken,
		[Cpp2IlInjected.Token(Token = "0x400064E")]
		PlatformAuthorizePurchaseFailure,
		[Cpp2IlInjected.Token(Token = "0x400064F")]
		CommerceCompletePurchaseFailure,
		[Cpp2IlInjected.Token(Token = "0x4000650")]
		PlatformSubscriptionNotSupported,
		[Cpp2IlInjected.Token(Token = "0x4000651")]
		PlatformPurchasesNotSupported,
		[Cpp2IlInjected.Token(Token = "0x4000652")]
		OculusDesktopPlayersMustBeInVR,
		[Cpp2IlInjected.Token(Token = "0x4000653")]
		FailedToRetrieveParentalControls,
		[Cpp2IlInjected.Token(Token = "0x4000654")]
		UserCanceled,
		[Cpp2IlInjected.Token(Token = "0x4000655")]
		DebugError
	}
	[Cpp2IlInjected.Token(Token = "0x200015D")]
	public enum PurchaseFailureType : byte
	{
		[Cpp2IlInjected.Token(Token = "0x4000657")]
		Unknown,
		[Cpp2IlInjected.Token(Token = "0x4000658")]
		AccountError,
		[Cpp2IlInjected.Token(Token = "0x4000659")]
		PlatformError,
		[Cpp2IlInjected.Token(Token = "0x400065A")]
		CommerceError,
		[Cpp2IlInjected.Token(Token = "0x400065B")]
		UserAction
	}
	[Cpp2IlInjected.Token(Token = "0x200015E")]
	[Utf8JsonSerializable]
	public class SKU : ZTDEQBSEMSX
	{
		[Cpp2IlInjected.Token(Token = "0x170003EE")]
		public int SkuId
		{
			[Cpp2IlInjected.Token(Token = "0x6000934")]
			[Cpp2IlInjected.Address(RVA = "0xAA3110", Offset = "0xAA2510", VA = "0x180AA3110")]
			[CompilerGenerated]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x6000935")]
			[Cpp2IlInjected.Address(RVA = "0xAAB1D0", Offset = "0xAAA5D0", VA = "0x180AAB1D0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170003EF")]
		public string Name
		{
			[Cpp2IlInjected.Token(Token = "0x6000936")]
			[Cpp2IlInjected.Address(RVA = "0xAAA880", Offset = "0xAA9C80", VA = "0x180AAA880")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000937")]
			[Cpp2IlInjected.Address(RVA = "0xAAA120", Offset = "0xAA9520", VA = "0x180AAA120")]
			[CompilerGenerated]
			internal set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170003F0")]
		public string Description
		{
			[Cpp2IlInjected.Token(Token = "0x6000938")]
			[Cpp2IlInjected.Address(RVA = "0xAAB1C0", Offset = "0xAAA5C0", VA = "0x180AAB1C0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000939")]
			[Cpp2IlInjected.Address(RVA = "0xAA67C0", Offset = "0xAA5BC0", VA = "0x180AA67C0")]
			[CompilerGenerated]
			internal set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170003F1")]
		public string ImageName
		{
			[Cpp2IlInjected.Token(Token = "0x600093A")]
			[Cpp2IlInjected.Address(RVA = "0xAAA820", Offset = "0xAA9C20", VA = "0x180AAA820")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600093B")]
			[Cpp2IlInjected.Address(RVA = "0xAA67D0", Offset = "0xAA5BD0", VA = "0x180AA67D0")]
			[CompilerGenerated]
			internal set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170003F2")]
		public int Price
		{
			[Cpp2IlInjected.Token(Token = "0x600093C")]
			[Cpp2IlInjected.Address(RVA = "0xAAF800", Offset = "0xAAEC00", VA = "0x180AAF800")]
			[CompilerGenerated]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x600093D")]
			[Cpp2IlInjected.Address(RVA = "0xAAF7F0", Offset = "0xAAEBF0", VA = "0x180AAF7F0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170003F3")]
		public string OculusSkuId
		{
			[Cpp2IlInjected.Token(Token = "0x600093E")]
			[Cpp2IlInjected.Address(RVA = "0xAAA030", Offset = "0xAA9430", VA = "0x180AAA030")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600093F")]
			[Cpp2IlInjected.Address(RVA = "0xAAA110", Offset = "0xAA9510", VA = "0x180AAA110")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170003F4")]
		public string AppleProductId
		{
			[Cpp2IlInjected.Token(Token = "0x6000940")]
			[Cpp2IlInjected.Address(RVA = "0xAAA810", Offset = "0xAA9C10", VA = "0x180AAA810")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000941")]
			[Cpp2IlInjected.Address(RVA = "0xAAA840", Offset = "0xAA9C40", VA = "0x180AAA840")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170003F5")]
		[DataMember(Name = "PsnProductLabel")]
		public string PSNProductLabel
		{
			[Cpp2IlInjected.Token(Token = "0x6000942")]
			[Cpp2IlInjected.Address(RVA = "0xAAA160", Offset = "0xAA9560", VA = "0x180AAA160")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000943")]
			[Cpp2IlInjected.Address(RVA = "0xAAA870", Offset = "0xAA9C70", VA = "0x180AAA870")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170003F6")]
		public string XboxProductId
		{
			[Cpp2IlInjected.Token(Token = "0x6000944")]
			[Cpp2IlInjected.Address(RVA = "0xAA3370", Offset = "0xAA2770", VA = "0x180AA3370")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000945")]
			[Cpp2IlInjected.Address(RVA = "0xAA3390", Offset = "0xAA2790", VA = "0x180AA3390")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170003F7")]
		public string XboxStoreId
		{
			[Cpp2IlInjected.Token(Token = "0x6000946")]
			[Cpp2IlInjected.Address(RVA = "0xAA3150", Offset = "0xAA2550", VA = "0x180AA3150")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000947")]
			[Cpp2IlInjected.Address(RVA = "0xAA33A0", Offset = "0xAA27A0", VA = "0x180AA33A0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170003F8")]
		public string GooglePlaySkuId
		{
			[Cpp2IlInjected.Token(Token = "0x6000948")]
			[Cpp2IlInjected.Address(RVA = "0xAA3380", Offset = "0xAA2780", VA = "0x180AA3380")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000949")]
			[Cpp2IlInjected.Address(RVA = "0xAA3130", Offset = "0xAA2530", VA = "0x180AA3130")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170003F9")]
		public string PicoSkuId
		{
			[Cpp2IlInjected.Token(Token = "0x600094A")]
			[Cpp2IlInjected.Address(RVA = "0xAA3120", Offset = "0xAA2520", VA = "0x180AA3120")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600094B")]
			[Cpp2IlInjected.Address(RVA = "0xAA3140", Offset = "0xAA2540", VA = "0x180AA3140")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170003FA")]
		public string NintendoSkuId
		{
			[Cpp2IlInjected.Token(Token = "0x600094C")]
			[Cpp2IlInjected.Address(RVA = "0xAA5380", Offset = "0xAA4780", VA = "0x180AA5380")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600094D")]
			[Cpp2IlInjected.Address(RVA = "0xAA5390", Offset = "0xAA4790", VA = "0x180AA5390")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170003FB")]
		public bool IsSingleUse
		{
			[Cpp2IlInjected.Token(Token = "0x600094E")]
			[Cpp2IlInjected.Address(RVA = "0xCAAC50", Offset = "0xCAA050", VA = "0x180CAAC50")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x600094F")]
			[Cpp2IlInjected.Address(RVA = "0xCABB70", Offset = "0xCAAF70", VA = "0x180CABB70")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170003FC")]
		public bool ShouldAppearInTokenStore
		{
			[Cpp2IlInjected.Token(Token = "0x6000950")]
			[Cpp2IlInjected.Address(RVA = "0x14DF530", Offset = "0x14DE930", VA = "0x1814DF530")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000951")]
			[Cpp2IlInjected.Address(RVA = "0x14DF420", Offset = "0x14DE820", VA = "0x1814DF420")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170003FD")]
		public SKUData Data
		{
			[Cpp2IlInjected.Token(Token = "0x6000952")]
			[Cpp2IlInjected.Address(RVA = "0xAAD040", Offset = "0xAAC440", VA = "0x180AAD040")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000953")]
			[Cpp2IlInjected.Address(RVA = "0xAAC9D0", Offset = "0xAABDD0", VA = "0x180AAC9D0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170003FE")]
		[IgnoreDataMember]
		public string DisplayPrice
		{
			[Cpp2IlInjected.Token(Token = "0x6000954")]
			[Cpp2IlInjected.Address(RVA = "0xAAC9A0", Offset = "0xAABDA0", VA = "0x180AAC9A0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000955")]
			[Cpp2IlInjected.Address(RVA = "0xAAC9F0", Offset = "0xAABDF0", VA = "0x180AAC9F0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170003FF")]
		[IgnoreDataMember]
		public string LongDescription
		{
			[Cpp2IlInjected.Token(Token = "0x6000956")]
			[Cpp2IlInjected.Address(RVA = "0xAD3CC0", Offset = "0xAD30C0", VA = "0x180AD3CC0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000957")]
			[Cpp2IlInjected.Address(RVA = "0xCA6670", Offset = "0xCA5A70", VA = "0x180CA6670")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000400")]
		[IgnoreDataMember]
		public string ConfirmationMessage
		{
			[Cpp2IlInjected.Token(Token = "0x6000958")]
			[Cpp2IlInjected.Address(RVA = "0xAAC9C0", Offset = "0xAABDC0", VA = "0x180AAC9C0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000959")]
			[Cpp2IlInjected.Address(RVA = "0xAAC960", Offset = "0xAABD60", VA = "0x180AAC960")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000401")]
		[IgnoreDataMember]
		public MYOZSVWEHTY PlatformSku
		{
			[Cpp2IlInjected.Token(Token = "0x600095A")]
			[Cpp2IlInjected.Address(RVA = "0xB9E4B0", Offset = "0xB9D8B0", VA = "0x180B9E4B0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600095B")]
			[Cpp2IlInjected.Address(RVA = "0xB9D910", Offset = "0xB9CD10", VA = "0x180B9D910")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000402")]
		[IgnoreDataMember]
		public bool IsSubscription
		{
			[Cpp2IlInjected.Token(Token = "0x600095C")]
			[Cpp2IlInjected.Address(RVA = "0x771BD20", Offset = "0x771B120", VA = "0x18771BD20")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000403")]
		[IgnoreDataMember]
		public string ThumbnailImageName
		{
			[Cpp2IlInjected.Token(Token = "0x600095D")]
			[Cpp2IlInjected.Address(RVA = "0xAA6A40", Offset = "0xAA5E40", VA = "0x180AA6A40")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600095E")]
			[Cpp2IlInjected.Address(RVA = "0xAA6A70", Offset = "0xAA5E70", VA = "0x180AA6A70")]
			[CompilerGenerated]
			internal set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600095F")]
		[Cpp2IlInjected.Address(RVA = "0x771BB30", Offset = "0x771AF30", VA = "0x18771BB30", Slot = "4")]
		public void NTJAWBDBXVU()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000960")]
		[Cpp2IlInjected.Address(RVA = "0x771BC80", Offset = "0x771B080", VA = "0x18771BC80")]
		public static SKU UJEGZRHCWGF(int a, string b, string c)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000961")]
		[Cpp2IlInjected.Address(RVA = "0x771BC20", Offset = "0x771B020", VA = "0x18771BC20", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000962")]
		[Cpp2IlInjected.Address(RVA = "0xAAC8E0", Offset = "0xAABCE0", VA = "0x180AAC8E0")]
		public SKU()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200015F")]
	[Utf8JsonSerializable]
	public class SKUData
	{
		[Cpp2IlInjected.Token(Token = "0x17000404")]
		public List<int> GiftDropIds
		{
			[Cpp2IlInjected.Token(Token = "0x6000963")]
			[Cpp2IlInjected.Address(RVA = "0xAA5FB0", Offset = "0xAA53B0", VA = "0x180AA5FB0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000964")]
			[Cpp2IlInjected.Address(RVA = "0xAA5FC0", Offset = "0xAA53C0", VA = "0x180AA5FC0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000405")]
		public string Message
		{
			[Cpp2IlInjected.Token(Token = "0x6000965")]
			[Cpp2IlInjected.Address(RVA = "0xAAA880", Offset = "0xAA9C80", VA = "0x180AAA880")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000966")]
			[Cpp2IlInjected.Address(RVA = "0xAAA120", Offset = "0xAA9520", VA = "0x180AAA120")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000406")]
		public SubscriptionPurchase SubscriptionPurchase
		{
			[Cpp2IlInjected.Token(Token = "0x6000967")]
			[Cpp2IlInjected.Address(RVA = "0xAAB1C0", Offset = "0xAAA5C0", VA = "0x180AAB1C0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000968")]
			[Cpp2IlInjected.Address(RVA = "0xAA67C0", Offset = "0xAA5BC0", VA = "0x180AA67C0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000969")]
		[Cpp2IlInjected.Address(RVA = "0xAAC8E0", Offset = "0xAABCE0", VA = "0x180AAC8E0")]
		public SKUData()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000160")]
	public readonly struct SkuPurchaseResult
	{
		[Cpp2IlInjected.Token(Token = "0x2000161")]
		public enum States : byte
		{
			[Cpp2IlInjected.Token(Token = "0x4000678")]
			Error,
			[Cpp2IlInjected.Token(Token = "0x4000679")]
			CancelledByUser,
			[Cpp2IlInjected.Token(Token = "0x400067A")]
			Success
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000674")]
		public readonly States State;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1")]
		[Cpp2IlInjected.Token(Token = "0x4000675")]
		public readonly PurchaseFailureType PurchaseFailureType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x4000676")]
		public readonly PurchaseFailureError PurchaseFailureError;

		[Cpp2IlInjected.Token(Token = "0x600096A")]
		[Cpp2IlInjected.Address(RVA = "0x771C760", Offset = "0x771BB60", VA = "0x18771C760")]
		private SkuPurchaseResult(States state, PurchaseFailureType purchaseFailureType = PurchaseFailureType.Unknown, PurchaseFailureError purchaseFailureError = PurchaseFailureError.Unknown)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600096B")]
		[Cpp2IlInjected.Address(RVA = "0x771C740", Offset = "0x771BB40", VA = "0x18771C740")]
		public static SkuPurchaseResult Success()
		{
			return default(SkuPurchaseResult);
		}

		[Cpp2IlInjected.Token(Token = "0x600096C")]
		[Cpp2IlInjected.Address(RVA = "0x771C700", Offset = "0x771BB00", VA = "0x18771C700")]
		public static SkuPurchaseResult Cancelled()
		{
			return default(SkuPurchaseResult);
		}

		[Cpp2IlInjected.Token(Token = "0x600096D")]
		[Cpp2IlInjected.Address(RVA = "0x771C720", Offset = "0x771BB20", VA = "0x18771C720")]
		public static SkuPurchaseResult Error(PurchaseFailureType purchaseFailureType, PurchaseFailureError purchaseFailureError)
		{
			return default(SkuPurchaseResult);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000162")]
	public enum SubscriptionLevel
	{
		[Cpp2IlInjected.Token(Token = "0x400067C")]
		Gold,
		[Cpp2IlInjected.Token(Token = "0x400067D")]
		Platinum
	}
	[Cpp2IlInjected.Token(Token = "0x2000163")]
	public enum SubscriptionPeriod
	{
		[Cpp2IlInjected.Token(Token = "0x400067F")]
		Month,
		[Cpp2IlInjected.Token(Token = "0x4000680")]
		Year,
		[Cpp2IlInjected.Token(Token = "0x4000681")]
		ThreeMonth,
		[Cpp2IlInjected.Token(Token = "0x4000682")]
		SixMonth
	}
	[Cpp2IlInjected.Token(Token = "0x2000164")]
	[Utf8JsonSerializable]
	public class SubscriptionPurchase
	{
		[Cpp2IlInjected.Token(Token = "0x17000407")]
		public SubscriptionLevel Level
		{
			[Cpp2IlInjected.Token(Token = "0x600096E")]
			[Cpp2IlInjected.Address(RVA = "0xAA3110", Offset = "0xAA2510", VA = "0x180AA3110")]
			[CompilerGenerated]
			get
			{
				return default(SubscriptionLevel);
			}
			[Cpp2IlInjected.Token(Token = "0x600096F")]
			[Cpp2IlInjected.Address(RVA = "0xAAB1D0", Offset = "0xAAA5D0", VA = "0x180AAB1D0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000408")]
		public SubscriptionPeriod Period
		{
			[Cpp2IlInjected.Token(Token = "0x6000970")]
			[Cpp2IlInjected.Address(RVA = "0xC4E2B0", Offset = "0xC4D6B0", VA = "0x180C4E2B0")]
			[CompilerGenerated]
			get
			{
				return default(SubscriptionPeriod);
			}
			[Cpp2IlInjected.Token(Token = "0x6000971")]
			[Cpp2IlInjected.Address(RVA = "0xCDF260", Offset = "0xCDE660", VA = "0x180CDF260")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000409")]
		public bool IsAutoRenewing
		{
			[Cpp2IlInjected.Token(Token = "0x6000972")]
			[Cpp2IlInjected.Address(RVA = "0xBC19C0", Offset = "0xBC0DC0", VA = "0x180BC19C0")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000973")]
			[Cpp2IlInjected.Address(RVA = "0xAA7380", Offset = "0xAA6780", VA = "0x180AA7380")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000974")]
		[Cpp2IlInjected.Address(RVA = "0xAAC8E0", Offset = "0xAABCE0", VA = "0x180AAC8E0")]
		public SubscriptionPurchase()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000165")]
	public enum TransactionState
	{
		[Cpp2IlInjected.Token(Token = "0x4000687")]
		Error = -2,
		[Cpp2IlInjected.Token(Token = "0x4000688")]
		Cancelled,
		[Cpp2IlInjected.Token(Token = "0x4000689")]
		Uninitialized,
		[Cpp2IlInjected.Token(Token = "0x400068A")]
		AttemptStarted,
		[Cpp2IlInjected.Token(Token = "0x400068B")]
		PurchaseComplete
	}
}
namespace RecNet.Econ.BattlePass
{
	[Cpp2IlInjected.Token(Token = "0x2000166")]
	[Utf8JsonSerializable]
	public class BattlePassAccountProgressDTO : IEquatable<BattlePassAccountProgressDTO>
	{
		[Cpp2IlInjected.Token(Token = "0x1700040A")]
		[CompilerGenerated]
		protected virtual Type ITQAFHBSGFG
		{
			[Cpp2IlInjected.Token(Token = "0x6000976")]
			[Cpp2IlInjected.Address(RVA = "0x7714F50", Offset = "0x7714350", VA = "0x187714F50", Slot = "5")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700040B")]
		public long BattlePassId
		{
			[Cpp2IlInjected.Token(Token = "0x6000977")]
			[Cpp2IlInjected.Address(RVA = "0xAA5FB0", Offset = "0xAA53B0", VA = "0x180AA5FB0")]
			[CompilerGenerated]
			get
			{
				return default(long);
			}
			[Cpp2IlInjected.Token(Token = "0x6000978")]
			[Cpp2IlInjected.Address(RVA = "0xB96550", Offset = "0xB95950", VA = "0x180B96550")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700040C")]
		public int AccountId
		{
			[Cpp2IlInjected.Token(Token = "0x6000979")]
			[Cpp2IlInjected.Address(RVA = "0xAAC980", Offset = "0xAABD80", VA = "0x180AAC980")]
			[CompilerGenerated]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x600097A")]
			[Cpp2IlInjected.Address(RVA = "0xAB2F40", Offset = "0xAB2340", VA = "0x180AB2F40")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700040D")]
		public int Xp
		{
			[Cpp2IlInjected.Token(Token = "0x600097B")]
			[Cpp2IlInjected.Address(RVA = "0x12E70B0", Offset = "0x12E64B0", VA = "0x1812E70B0")]
			[CompilerGenerated]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x600097C")]
			[Cpp2IlInjected.Address(RVA = "0x12E70C0", Offset = "0x12E64C0", VA = "0x1812E70C0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700040E")]
		public bool IsPurchased
		{
			[Cpp2IlInjected.Token(Token = "0x600097D")]
			[Cpp2IlInjected.Address(RVA = "0xAAA010", Offset = "0xAA9410", VA = "0x180AAA010")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x600097E")]
			[Cpp2IlInjected.Address(RVA = "0xAAA830", Offset = "0xAA9C30", VA = "0x180AAA830")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700040F")]
		public int DailyParticipationBonusCount
		{
			[Cpp2IlInjected.Token(Token = "0x600097F")]
			[Cpp2IlInjected.Address(RVA = "0xACC3D0", Offset = "0xACB7D0", VA = "0x180ACC3D0")]
			[CompilerGenerated]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x6000980")]
			[Cpp2IlInjected.Address(RVA = "0xBE18B0", Offset = "0xBE0CB0", VA = "0x180BE18B0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000410")]
		public DateTime? BoostedUntil
		{
			[Cpp2IlInjected.Token(Token = "0x6000981")]
			[Cpp2IlInjected.Address(RVA = "0x1146260", Offset = "0x1145660", VA = "0x181146260")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000982")]
			[Cpp2IlInjected.Address(RVA = "0x128B750", Offset = "0x128AB50", VA = "0x18128B750")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000411")]
		public DateTime? CompletionDate
		{
			[Cpp2IlInjected.Token(Token = "0x6000983")]
			[Cpp2IlInjected.Address(RVA = "0x134DB80", Offset = "0x134CF80", VA = "0x18134DB80")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000984")]
			[Cpp2IlInjected.Address(RVA = "0x134D8A0", Offset = "0x134CCA0", VA = "0x18134D8A0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000975")]
		[Cpp2IlInjected.Address(RVA = "0x77150F0", Offset = "0x77144F0", VA = "0x1877150F0")]
		public BattlePassAccountProgressDTO(long BattlePassId, int AccountId, int Xp, bool IsPurchased, int DailyParticipationBonusCount, DateTime? BoostedUntil, DateTime? CompletionDate)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000985")]
		[Cpp2IlInjected.Address(RVA = "0x7714FA0", Offset = "0x77143A0", VA = "0x187714FA0", Slot = "3")]
		[CompilerGenerated]
		public override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000986")]
		[Cpp2IlInjected.Address(RVA = "0x7714C80", Offset = "0x7714080", VA = "0x187714C80", Slot = "6")]
		[CompilerGenerated]
		protected virtual bool LXITBKEHWVK(StringBuilder a)
		{
			return default(bool);
		}

		[SpecialName]
		[Cpp2IlInjected.Token(Token = "0x6000987")]
		[Cpp2IlInjected.Address(RVA = "0xFB47E0", Offset = "0xFB3BE0", VA = "0x180FB47E0")]
		[CompilerGenerated]
		public static bool ZPGHGHNXRJT(BattlePassAccountProgressDTO? a, BattlePassAccountProgressDTO? b)
		{
			return default(bool);
		}

		[SpecialName]
		[Cpp2IlInjected.Token(Token = "0x6000988")]
		[Cpp2IlInjected.Address(RVA = "0xFB4820", Offset = "0xFB3C20", VA = "0x180FB4820")]
		[CompilerGenerated]
		public static bool ZWISVWGZSLY(BattlePassAccountProgressDTO? a, BattlePassAccountProgressDTO? b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000989")]
		[Cpp2IlInjected.Address(RVA = "0x7714990", Offset = "0x7713D90", VA = "0x187714990", Slot = "2")]
		[CompilerGenerated]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600098A")]
		[Cpp2IlInjected.Address(RVA = "0x7714900", Offset = "0x7713D00", VA = "0x187714900", Slot = "0")]
		[CompilerGenerated]
		public override bool Equals(object? obj)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600098B")]
		[Cpp2IlInjected.Address(RVA = "0x7714640", Offset = "0x7713A40", VA = "0x187714640", Slot = "7")]
		[CompilerGenerated]
		public virtual bool Equals(BattlePassAccountProgressDTO? other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600098C")]
		[Cpp2IlInjected.Address(RVA = "0x7714EC0", Offset = "0x77142C0", VA = "0x187714EC0", Slot = "8")]
		[CompilerGenerated]
		public virtual BattlePassAccountProgressDTO OMSRAXDGICF()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600098D")]
		[Cpp2IlInjected.Address(RVA = "0x7715090", Offset = "0x7714490", VA = "0x187715090")]
		[CompilerGenerated]
		protected BattlePassAccountProgressDTO(BattlePassAccountProgressDTO original)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600098E")]
		[Cpp2IlInjected.Address(RVA = "0x7714C30", Offset = "0x7714030", VA = "0x187714C30")]
		[CompilerGenerated]
		public void HYZXLOOBRHM([Out] long a, [Out] int b, [Out] int c, [Out] bool d, [Out] int e, [Out] DateTime? f, [Out] DateTime? g)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000167")]
	[Utf8JsonSerializable]
	public class BattlePassDTO : IEquatable<BattlePassDTO>
	{
		[Cpp2IlInjected.Token(Token = "0x17000412")]
		[CompilerGenerated]
		protected virtual Type ITQAFHBSGFG
		{
			[Cpp2IlInjected.Token(Token = "0x6000990")]
			[Cpp2IlInjected.Address(RVA = "0x7721330", Offset = "0x7720730", VA = "0x187721330", Slot = "5")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000413")]
		public long BattlePassId
		{
			[Cpp2IlInjected.Token(Token = "0x6000991")]
			[Cpp2IlInjected.Address(RVA = "0xAA5FB0", Offset = "0xAA53B0", VA = "0x180AA5FB0")]
			[CompilerGenerated]
			get
			{
				return default(long);
			}
			[Cpp2IlInjected.Token(Token = "0x6000992")]
			[Cpp2IlInjected.Address(RVA = "0xB96550", Offset = "0xB95950", VA = "0x180B96550")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000414")]
		public string Name
		{
			[Cpp2IlInjected.Token(Token = "0x6000993")]
			[Cpp2IlInjected.Address(RVA = "0xAAA880", Offset = "0xAA9C80", VA = "0x180AAA880")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000994")]
			[Cpp2IlInjected.Address(RVA = "0xAAA120", Offset = "0xAA9520", VA = "0x180AAA120")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000415")]
		public DateTime StartTime
		{
			[Cpp2IlInjected.Token(Token = "0x6000995")]
			[Cpp2IlInjected.Address(RVA = "0xAAB1C0", Offset = "0xAAA5C0", VA = "0x180AAB1C0")]
			[CompilerGenerated]
			get
			{
				return default(DateTime);
			}
			[Cpp2IlInjected.Token(Token = "0x6000996")]
			[Cpp2IlInjected.Address(RVA = "0xB30430", Offset = "0xB2F830", VA = "0x180B30430")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000416")]
		public DateTime EndTime
		{
			[Cpp2IlInjected.Token(Token = "0x6000997")]
			[Cpp2IlInjected.Address(RVA = "0xAAA820", Offset = "0xAA9C20", VA = "0x180AAA820")]
			[CompilerGenerated]
			get
			{
				return default(DateTime);
			}
			[Cpp2IlInjected.Token(Token = "0x6000998")]
			[Cpp2IlInjected.Address(RVA = "0xAAA000", Offset = "0xAA9400", VA = "0x180AAA000")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000417")]
		public IReadOnlyList<BattlePassLevelDTO> Levels
		{
			[Cpp2IlInjected.Token(Token = "0x6000999")]
			[Cpp2IlInjected.Address(RVA = "0xAAA140", Offset = "0xAA9540", VA = "0x180AAA140")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600099A")]
			[Cpp2IlInjected.Address(RVA = "0xAADB00", Offset = "0xAACF00", VA = "0x180AADB00")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000418")]
		public IReadOnlyDictionary<BattlePassEvent, int> EventXP
		{
			[Cpp2IlInjected.Token(Token = "0x600099B")]
			[Cpp2IlInjected.Address(RVA = "0xAAA030", Offset = "0xAA9430", VA = "0x180AAA030")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600099C")]
			[Cpp2IlInjected.Address(RVA = "0xAAA110", Offset = "0xAA9510", VA = "0x180AAA110")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000419")]
		public int DailyParticipationBonusLimit
		{
			[Cpp2IlInjected.Token(Token = "0x600099D")]
			[Cpp2IlInjected.Address(RVA = "0xAC1F70", Offset = "0xAC1370", VA = "0x180AC1F70")]
			[CompilerGenerated]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x600099E")]
			[Cpp2IlInjected.Address(RVA = "0xBDCB60", Offset = "0xBDBF60", VA = "0x180BDCB60")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700041A")]
		public int MinimumParticipationTimeInSeconds
		{
			[Cpp2IlInjected.Token(Token = "0x600099F")]
			[Cpp2IlInjected.Address(RVA = "0xAC1F80", Offset = "0xAC1380", VA = "0x180AC1F80")]
			[CompilerGenerated]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x60009A0")]
			[Cpp2IlInjected.Address(RVA = "0xCDFCC0", Offset = "0xCDF0C0", VA = "0x180CDFCC0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700041B")]
		public IReadOnlyList<BattlePassSkuDTO> PurchasableSkus
		{
			[Cpp2IlInjected.Token(Token = "0x60009A1")]
			[Cpp2IlInjected.Address(RVA = "0xAAA160", Offset = "0xAA9560", VA = "0x180AAA160")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60009A2")]
			[Cpp2IlInjected.Address(RVA = "0xAAA870", Offset = "0xAA9C70", VA = "0x180AAA870")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700041C")]
		public int PermanentBoostTokenPrice
		{
			[Cpp2IlInjected.Token(Token = "0x60009A3")]
			[Cpp2IlInjected.Address(RVA = "0xBB86C0", Offset = "0xBB7AC0", VA = "0x180BB86C0")]
			[CompilerGenerated]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x60009A4")]
			[Cpp2IlInjected.Address(RVA = "0x175B160", Offset = "0x175A560", VA = "0x18175B160")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700041D")]
		public BattlePassLimitedTimeRewardDTO? LimitedTimeReward
		{
			[Cpp2IlInjected.Token(Token = "0x60009A5")]
			[Cpp2IlInjected.Address(RVA = "0xAA3150", Offset = "0xAA2550", VA = "0x180AA3150")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60009A6")]
			[Cpp2IlInjected.Address(RVA = "0xAA33A0", Offset = "0xAA27A0", VA = "0x180AA33A0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600098F")]
		[Cpp2IlInjected.Address(RVA = "0x7721520", Offset = "0x7720920", VA = "0x187721520")]
		public BattlePassDTO(long BattlePassId, string Name, DateTime StartTime, DateTime EndTime, IReadOnlyList<BattlePassLevelDTO> Levels, IReadOnlyDictionary<BattlePassEvent, int> EventXP, int DailyParticipationBonusLimit, int MinimumParticipationTimeInSeconds, IReadOnlyList<BattlePassSkuDTO> PurchasableSkus, int PermanentBoostTokenPrice, BattlePassLimitedTimeRewardDTO? LimitedTimeReward)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60009A7")]
		[Cpp2IlInjected.Address(RVA = "0x7721380", Offset = "0x7720780", VA = "0x187721380", Slot = "3")]
		[CompilerGenerated]
		public override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60009A8")]
		[Cpp2IlInjected.Address(RVA = "0x7720F80", Offset = "0x7720380", VA = "0x187720F80", Slot = "6")]
		[CompilerGenerated]
		protected virtual bool LXITBKEHWVK(StringBuilder a)
		{
			return default(bool);
		}

		[SpecialName]
		[Cpp2IlInjected.Token(Token = "0x60009A9")]
		[Cpp2IlInjected.Address(RVA = "0xFB47E0", Offset = "0xFB3BE0", VA = "0x180FB47E0")]
		[CompilerGenerated]
		public static bool ZPGHGHNXRJT(BattlePassDTO? a, BattlePassDTO? b)
		{
			return default(bool);
		}

		[SpecialName]
		[Cpp2IlInjected.Token(Token = "0x60009AA")]
		[Cpp2IlInjected.Address(RVA = "0xFB4820", Offset = "0xFB3C20", VA = "0x180FB4820")]
		[CompilerGenerated]
		public static bool ZWISVWGZSLY(BattlePassDTO? a, BattlePassDTO? b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60009AB")]
		[Cpp2IlInjected.Address(RVA = "0x7720B10", Offset = "0x771FF10", VA = "0x187720B10", Slot = "2")]
		[CompilerGenerated]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60009AC")]
		[Cpp2IlInjected.Address(RVA = "0x77206D0", Offset = "0x771FAD0", VA = "0x1877206D0", Slot = "0")]
		[CompilerGenerated]
		public override bool Equals(object? obj)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60009AD")]
		[Cpp2IlInjected.Address(RVA = "0x7720760", Offset = "0x771FB60", VA = "0x187720760", Slot = "7")]
		[CompilerGenerated]
		public virtual bool Equals(BattlePassDTO? other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60009AE")]
		[Cpp2IlInjected.Address(RVA = "0x7721250", Offset = "0x7720650", VA = "0x187721250", Slot = "8")]
		[CompilerGenerated]
		public virtual BattlePassDTO OMSRAXDGICF()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60009AF")]
		[Cpp2IlInjected.Address(RVA = "0x7721470", Offset = "0x7720870", VA = "0x187721470")]
		[CompilerGenerated]
		protected BattlePassDTO(BattlePassDTO original)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60009B0")]
		[Cpp2IlInjected.Address(RVA = "0x7720ED0", Offset = "0x77202D0", VA = "0x187720ED0")]
		[CompilerGenerated]
		public void HYZXLOOBRHM([Out] long a, [Out] string b, [Out] DateTime c, [Out] DateTime d, [Out] IReadOnlyList<BattlePassLevelDTO> e, [Out] IReadOnlyDictionary<BattlePassEvent, int> f, [Out] int g, [Out] int h, [Out] IReadOnlyList<BattlePassSkuDTO> i, [Out] int j, [Out] BattlePassLimitedTimeRewardDTO? LimitedTimeReward)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000168")]
	public enum BattlePassEvent
	{
		[Cpp2IlInjected.Token(Token = "0x400069F")]
		Unknown,
		[Cpp2IlInjected.Token(Token = "0x40006A0")]
		Paintball_KO,
		[Cpp2IlInjected.Token(Token = "0x40006A1")]
		Paintball_FlagCapture,
		[Cpp2IlInjected.Token(Token = "0x40006A2")]
		Paintball_FinishGame,
		[Cpp2IlInjected.Token(Token = "0x40006A3")]
		Paintball_WinGame
	}
	[Cpp2IlInjected.Token(Token = "0x2000169")]
	[Utf8JsonSerializable]
	public class BattlePassLevelDTO : IEquatable<BattlePassLevelDTO>
	{
		[Cpp2IlInjected.Token(Token = "0x1700041E")]
		[CompilerGenerated]
		protected virtual Type ITQAFHBSGFG
		{
			[Cpp2IlInjected.Token(Token = "0x60009B2")]
			[Cpp2IlInjected.Address(RVA = "0x7721A10", Offset = "0x7720E10", VA = "0x187721A10", Slot = "5")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700041F")]
		public int XpRequired
		{
			[Cpp2IlInjected.Token(Token = "0x60009B3")]
			[Cpp2IlInjected.Address(RVA = "0xAA3110", Offset = "0xAA2510", VA = "0x180AA3110")]
			[CompilerGenerated]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x60009B4")]
			[Cpp2IlInjected.Address(RVA = "0xAAB1D0", Offset = "0xAAA5D0", VA = "0x180AAB1D0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000420")]
		public IReadOnlyList<int> RewardGiftDropIds
		{
			[Cpp2IlInjected.Token(Token = "0x60009B5")]
			[Cpp2IlInjected.Address(RVA = "0xAAA880", Offset = "0xAA9C80", VA = "0x180AAA880")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60009B6")]
			[Cpp2IlInjected.Address(RVA = "0xAAA120", Offset = "0xAA9520", VA = "0x180AAA120")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60009B1")]
		[Cpp2IlInjected.Address(RVA = "0x11269C0", Offset = "0x1125DC0", VA = "0x1811269C0")]
		public BattlePassLevelDTO(int XpRequired, IReadOnlyList<int> RewardGiftDropIds)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60009B7")]
		[Cpp2IlInjected.Address(RVA = "0x7721A60", Offset = "0x7720E60", VA = "0x187721A60", Slot = "3")]
		[CompilerGenerated]
		public override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60009B8")]
		[Cpp2IlInjected.Address(RVA = "0x77218E0", Offset = "0x7720CE0", VA = "0x1877218E0", Slot = "6")]
		[CompilerGenerated]
		protected virtual bool LXITBKEHWVK(StringBuilder a)
		{
			return default(bool);
		}

		[SpecialName]
		[Cpp2IlInjected.Token(Token = "0x60009B9")]
		[Cpp2IlInjected.Address(RVA = "0xFB47E0", Offset = "0xFB3BE0", VA = "0x180FB47E0")]
		[CompilerGenerated]
		public static bool ZPGHGHNXRJT(BattlePassLevelDTO? a, BattlePassLevelDTO? b)
		{
			return default(bool);
		}

		[SpecialName]
		[Cpp2IlInjected.Token(Token = "0x60009BA")]
		[Cpp2IlInjected.Address(RVA = "0xFB4820", Offset = "0xFB3C20", VA = "0x180FB4820")]
		[CompilerGenerated]
		public static bool ZWISVWGZSLY(BattlePassLevelDTO? a, BattlePassLevelDTO? b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60009BB")]
		[Cpp2IlInjected.Address(RVA = "0x77217B0", Offset = "0x7720BB0", VA = "0x1877217B0", Slot = "2")]
		[CompilerGenerated]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60009BC")]
		[Cpp2IlInjected.Address(RVA = "0x7721720", Offset = "0x7720B20", VA = "0x187721720", Slot = "0")]
		[CompilerGenerated]
		public override bool Equals(object? obj)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60009BD")]
		[Cpp2IlInjected.Address(RVA = "0x77215D0", Offset = "0x77209D0", VA = "0x1877215D0", Slot = "7")]
		[CompilerGenerated]
		public virtual bool Equals(BattlePassLevelDTO? other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60009BE")]
		[Cpp2IlInjected.Address(RVA = "0x7721990", Offset = "0x7720D90", VA = "0x187721990", Slot = "8")]
		[CompilerGenerated]
		public virtual BattlePassLevelDTO OMSRAXDGICF()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60009BF")]
		[Cpp2IlInjected.Address(RVA = "0x7721B50", Offset = "0x7720F50", VA = "0x187721B50")]
		[CompilerGenerated]
		protected BattlePassLevelDTO(BattlePassLevelDTO original)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60009C0")]
		[Cpp2IlInjected.Address(RVA = "0x77218C0", Offset = "0x7720CC0", VA = "0x1877218C0")]
		[CompilerGenerated]
		public void HYZXLOOBRHM([Out] int a, [Out] IReadOnlyList<int> b)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200016A")]
	[Utf8JsonSerializable]
	public class BattlePassLimitedTimeRewardDTO : IEquatable<BattlePassLimitedTimeRewardDTO>
	{
		[Cpp2IlInjected.Token(Token = "0x17000421")]
		[CompilerGenerated]
		protected virtual Type ITQAFHBSGFG
		{
			[Cpp2IlInjected.Token(Token = "0x60009C2")]
			[Cpp2IlInjected.Address(RVA = "0x7722010", Offset = "0x7721410", VA = "0x187722010", Slot = "5")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000422")]
		public DateTime CompletionDeadline
		{
			[Cpp2IlInjected.Token(Token = "0x60009C3")]
			[Cpp2IlInjected.Address(RVA = "0xAA5FB0", Offset = "0xAA53B0", VA = "0x180AA5FB0")]
			[CompilerGenerated]
			get
			{
				return default(DateTime);
			}
			[Cpp2IlInjected.Token(Token = "0x60009C4")]
			[Cpp2IlInjected.Address(RVA = "0xB96550", Offset = "0xB95950", VA = "0x180B96550")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000423")]
		public IReadOnlyList<int> GiftDropIds
		{
			[Cpp2IlInjected.Token(Token = "0x60009C5")]
			[Cpp2IlInjected.Address(RVA = "0xAAA880", Offset = "0xAA9C80", VA = "0x180AAA880")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60009C6")]
			[Cpp2IlInjected.Address(RVA = "0xAAA120", Offset = "0xAA9520", VA = "0x180AAA120")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60009C1")]
		[Cpp2IlInjected.Address(RVA = "0x77221A0", Offset = "0x77215A0", VA = "0x1877221A0")]
		public BattlePassLimitedTimeRewardDTO(DateTime CompletionDeadline, IReadOnlyList<int> GiftDropIds)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60009C7")]
		[Cpp2IlInjected.Address(RVA = "0x7722060", Offset = "0x7721460", VA = "0x187722060", Slot = "3")]
		[CompilerGenerated]
		public override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60009C8")]
		[Cpp2IlInjected.Address(RVA = "0x7721EC0", Offset = "0x77212C0", VA = "0x187721EC0", Slot = "6")]
		[CompilerGenerated]
		protected virtual bool LXITBKEHWVK(StringBuilder a)
		{
			return default(bool);
		}

		[SpecialName]
		[Cpp2IlInjected.Token(Token = "0x60009C9")]
		[Cpp2IlInjected.Address(RVA = "0xFB47E0", Offset = "0xFB3BE0", VA = "0x180FB47E0")]
		[CompilerGenerated]
		public static bool ZPGHGHNXRJT(BattlePassLimitedTimeRewardDTO? a, BattlePassLimitedTimeRewardDTO? b)
		{
			return default(bool);
		}

		[SpecialName]
		[Cpp2IlInjected.Token(Token = "0x60009CA")]
		[Cpp2IlInjected.Address(RVA = "0xFB4820", Offset = "0xFB3C20", VA = "0x180FB4820")]
		[CompilerGenerated]
		public static bool ZWISVWGZSLY(BattlePassLimitedTimeRewardDTO? a, BattlePassLimitedTimeRewardDTO? b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60009CB")]
		[Cpp2IlInjected.Address(RVA = "0x7721D80", Offset = "0x7721180", VA = "0x187721D80", Slot = "2")]
		[CompilerGenerated]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60009CC")]
		[Cpp2IlInjected.Address(RVA = "0x7721BA0", Offset = "0x7720FA0", VA = "0x187721BA0", Slot = "0")]
		[CompilerGenerated]
		public override bool Equals(object? obj)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60009CD")]
		[Cpp2IlInjected.Address(RVA = "0x7721C30", Offset = "0x7721030", VA = "0x187721C30", Slot = "7")]
		[CompilerGenerated]
		public virtual bool Equals(BattlePassLimitedTimeRewardDTO? other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60009CE")]
		[Cpp2IlInjected.Address(RVA = "0x7721F90", Offset = "0x7721390", VA = "0x187721F90", Slot = "8")]
		[CompilerGenerated]
		public virtual BattlePassLimitedTimeRewardDTO OMSRAXDGICF()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60009CF")]
		[Cpp2IlInjected.Address(RVA = "0x7722150", Offset = "0x7721550", VA = "0x187722150")]
		[CompilerGenerated]
		protected BattlePassLimitedTimeRewardDTO(BattlePassLimitedTimeRewardDTO original)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60009D0")]
		[Cpp2IlInjected.Address(RVA = "0x7721EA0", Offset = "0x77212A0", VA = "0x187721EA0")]
		[CompilerGenerated]
		public void HYZXLOOBRHM([Out] DateTime a, [Out] IReadOnlyList<int> b)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200016B")]
	[Utf8JsonSerializable]
	public class BattlePassSkuDTO : IEquatable<BattlePassSkuDTO>
	{
		[Cpp2IlInjected.Token(Token = "0x17000424")]
		[CompilerGenerated]
		protected virtual Type ITQAFHBSGFG
		{
			[Cpp2IlInjected.Token(Token = "0x60009D2")]
			[Cpp2IlInjected.Address(RVA = "0x77227C0", Offset = "0x7721BC0", VA = "0x1877227C0", Slot = "5")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000425")]
		public int BattlePassSkuId
		{
			[Cpp2IlInjected.Token(Token = "0x60009D3")]
			[Cpp2IlInjected.Address(RVA = "0xAA3110", Offset = "0xAA2510", VA = "0x180AA3110")]
			[CompilerGenerated]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x60009D4")]
			[Cpp2IlInjected.Address(RVA = "0xAAB1D0", Offset = "0xAAA5D0", VA = "0x180AAB1D0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000426")]
		public int TokenPrice
		{
			[Cpp2IlInjected.Token(Token = "0x60009D5")]
			[Cpp2IlInjected.Address(RVA = "0xC4E2B0", Offset = "0xC4D6B0", VA = "0x180C4E2B0")]
			[CompilerGenerated]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x60009D6")]
			[Cpp2IlInjected.Address(RVA = "0xCDF260", Offset = "0xCDE660", VA = "0x180CDF260")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000427")]
		public int BonusLevels
		{
			[Cpp2IlInjected.Token(Token = "0x60009D7")]
			[Cpp2IlInjected.Address(RVA = "0xAAC980", Offset = "0xAABD80", VA = "0x180AAC980")]
			[CompilerGenerated]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x60009D8")]
			[Cpp2IlInjected.Address(RVA = "0xAB2F40", Offset = "0xAB2340", VA = "0x180AB2F40")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000428")]
		public bool PermanentBoost
		{
			[Cpp2IlInjected.Token(Token = "0x60009D9")]
			[Cpp2IlInjected.Address(RVA = "0xBC0680", Offset = "0xBBFA80", VA = "0x180BC0680")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x60009DA")]
			[Cpp2IlInjected.Address(RVA = "0xBC0B60", Offset = "0xBBFF60", VA = "0x180BC0B60")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60009D1")]
		[Cpp2IlInjected.Address(RVA = "0x7722900", Offset = "0x7721D00", VA = "0x187722900")]
		public BattlePassSkuDTO(int BattlePassSkuId, int TokenPrice, int BonusLevels = 0, bool PermanentBoost = false)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60009DB")]
		[Cpp2IlInjected.Address(RVA = "0x7722810", Offset = "0x7721C10", VA = "0x187722810", Slot = "3")]
		[CompilerGenerated]
		public override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60009DC")]
		[Cpp2IlInjected.Address(RVA = "0x77225E0", Offset = "0x77219E0", VA = "0x1877225E0", Slot = "6")]
		[CompilerGenerated]
		protected virtual bool LXITBKEHWVK(StringBuilder a)
		{
			return default(bool);
		}

		[SpecialName]
		[Cpp2IlInjected.Token(Token = "0x60009DD")]
		[Cpp2IlInjected.Address(RVA = "0xFB47E0", Offset = "0xFB3BE0", VA = "0x180FB47E0")]
		[CompilerGenerated]
		public static bool ZPGHGHNXRJT(BattlePassSkuDTO? a, BattlePassSkuDTO? b)
		{
			return default(bool);
		}

		[SpecialName]
		[Cpp2IlInjected.Token(Token = "0x60009DE")]
		[Cpp2IlInjected.Address(RVA = "0xFB4820", Offset = "0xFB3C20", VA = "0x180FB4820")]
		[CompilerGenerated]
		public static bool ZWISVWGZSLY(BattlePassSkuDTO? a, BattlePassSkuDTO? b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60009DF")]
		[Cpp2IlInjected.Address(RVA = "0x7722420", Offset = "0x7721820", VA = "0x187722420", Slot = "2")]
		[CompilerGenerated]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60009E0")]
		[Cpp2IlInjected.Address(RVA = "0x7722390", Offset = "0x7721790", VA = "0x187722390", Slot = "0")]
		[CompilerGenerated]
		public override bool Equals(object? obj)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60009E1")]
		[Cpp2IlInjected.Address(RVA = "0x77221D0", Offset = "0x77215D0", VA = "0x1877221D0", Slot = "7")]
		[CompilerGenerated]
		public virtual bool Equals(BattlePassSkuDTO? other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60009E2")]
		[Cpp2IlInjected.Address(RVA = "0x7722740", Offset = "0x7721B40", VA = "0x187722740", Slot = "8")]
		[CompilerGenerated]
		public virtual BattlePassSkuDTO OMSRAXDGICF()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60009E3")]
		[Cpp2IlInjected.Address(RVA = "0x7722920", Offset = "0x7721D20", VA = "0x187722920")]
		[CompilerGenerated]
		protected BattlePassSkuDTO(BattlePassSkuDTO original)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60009E4")]
		[Cpp2IlInjected.Address(RVA = "0x77225C0", Offset = "0x77219C0", VA = "0x1877225C0")]
		[CompilerGenerated]
		public void HYZXLOOBRHM([Out] int a, [Out] int b, [Out] int c, [Out] bool d)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200016C")]
	[Utf8JsonSerializable]
	public class PurchaseBattlePassPermanentBoostRequestDTO : IEquatable<PurchaseBattlePassPermanentBoostRequestDTO>
	{
		[Cpp2IlInjected.Token(Token = "0x17000429")]
		[CompilerGenerated]
		protected virtual Type ITQAFHBSGFG
		{
			[Cpp2IlInjected.Token(Token = "0x60009E6")]
			[Cpp2IlInjected.Address(RVA = "0x7723320", Offset = "0x7722720", VA = "0x187723320", Slot = "5")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700042A")]
		public int RequestedPrice
		{
			[Cpp2IlInjected.Token(Token = "0x60009E7")]
			[Cpp2IlInjected.Address(RVA = "0xAA3110", Offset = "0xAA2510", VA = "0x180AA3110")]
			[CompilerGenerated]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x60009E8")]
			[Cpp2IlInjected.Address(RVA = "0xAAB1D0", Offset = "0xAAA5D0", VA = "0x180AAB1D0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700042B")]
		public int? ToAccountId
		{
			[Cpp2IlInjected.Token(Token = "0x60009E9")]
			[Cpp2IlInjected.Address(RVA = "0x10D2A50", Offset = "0x10D1E50", VA = "0x1810D2A50")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60009EA")]
			[Cpp2IlInjected.Address(RVA = "0x10D3E30", Offset = "0x10D3230", VA = "0x1810D3E30")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60009E5")]
		[Cpp2IlInjected.Address(RVA = "0x7723460", Offset = "0x7722860", VA = "0x187723460")]
		public PurchaseBattlePassPermanentBoostRequestDTO(int RequestedPrice, int? ToAccountId)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60009EB")]
		[Cpp2IlInjected.Address(RVA = "0x7723370", Offset = "0x7722770", VA = "0x187723370", Slot = "3")]
		[CompilerGenerated]
		public override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60009EC")]
		[Cpp2IlInjected.Address(RVA = "0x77231E0", Offset = "0x77225E0", VA = "0x1877231E0", Slot = "6")]
		[CompilerGenerated]
		protected virtual bool LXITBKEHWVK(StringBuilder a)
		{
			return default(bool);
		}

		[SpecialName]
		[Cpp2IlInjected.Token(Token = "0x60009ED")]
		[Cpp2IlInjected.Address(RVA = "0xFB47E0", Offset = "0xFB3BE0", VA = "0x180FB47E0")]
		[CompilerGenerated]
		public static bool ZPGHGHNXRJT(PurchaseBattlePassPermanentBoostRequestDTO? a, PurchaseBattlePassPermanentBoostRequestDTO? b)
		{
			return default(bool);
		}

		[SpecialName]
		[Cpp2IlInjected.Token(Token = "0x60009EE")]
		[Cpp2IlInjected.Address(RVA = "0xFB4820", Offset = "0xFB3C20", VA = "0x180FB4820")]
		[CompilerGenerated]
		public static bool ZWISVWGZSLY(PurchaseBattlePassPermanentBoostRequestDTO? a, PurchaseBattlePassPermanentBoostRequestDTO? b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60009EF")]
		[Cpp2IlInjected.Address(RVA = "0x77230C0", Offset = "0x77224C0", VA = "0x1877230C0", Slot = "2")]
		[CompilerGenerated]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60009F0")]
		[Cpp2IlInjected.Address(RVA = "0x7722EE0", Offset = "0x77222E0", VA = "0x187722EE0", Slot = "0")]
		[CompilerGenerated]
		public override bool Equals(object? obj)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60009F1")]
		[Cpp2IlInjected.Address(RVA = "0x7722F70", Offset = "0x7722370", VA = "0x187722F70", Slot = "7")]
		[CompilerGenerated]
		public virtual bool Equals(PurchaseBattlePassPermanentBoostRequestDTO? other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60009F2")]
		[Cpp2IlInjected.Address(RVA = "0x77232B0", Offset = "0x77226B0", VA = "0x1877232B0", Slot = "8")]
		[CompilerGenerated]
		public virtual PurchaseBattlePassPermanentBoostRequestDTO OMSRAXDGICF()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60009F3")]
		[Cpp2IlInjected.Address(RVA = "0x7723470", Offset = "0x7722870", VA = "0x187723470")]
		[CompilerGenerated]
		protected PurchaseBattlePassPermanentBoostRequestDTO(PurchaseBattlePassPermanentBoostRequestDTO original)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60009F4")]
		[Cpp2IlInjected.Address(RVA = "0x77231D0", Offset = "0x77225D0", VA = "0x1877231D0")]
		[CompilerGenerated]
		public void HYZXLOOBRHM([Out] int a, [Out] int? b)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200016D")]
	[Utf8JsonSerializable]
	public class PurchaseBattlePassRequestDTO : IEquatable<PurchaseBattlePassRequestDTO>
	{
		[Cpp2IlInjected.Token(Token = "0x1700042C")]
		[CompilerGenerated]
		protected virtual Type ITQAFHBSGFG
		{
			[Cpp2IlInjected.Token(Token = "0x60009F6")]
			[Cpp2IlInjected.Address(RVA = "0x77239E0", Offset = "0x7722DE0", VA = "0x1877239E0", Slot = "5")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700042D")]
		public int BattlePassSkuId
		{
			[Cpp2IlInjected.Token(Token = "0x60009F7")]
			[Cpp2IlInjected.Address(RVA = "0xAA3110", Offset = "0xAA2510", VA = "0x180AA3110")]
			[CompilerGenerated]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x60009F8")]
			[Cpp2IlInjected.Address(RVA = "0xAAB1D0", Offset = "0xAAA5D0", VA = "0x180AAB1D0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700042E")]
		public int? ToAccountId
		{
			[Cpp2IlInjected.Token(Token = "0x60009F9")]
			[Cpp2IlInjected.Address(RVA = "0x10D2A50", Offset = "0x10D1E50", VA = "0x1810D2A50")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60009FA")]
			[Cpp2IlInjected.Address(RVA = "0x10D3E30", Offset = "0x10D3230", VA = "0x1810D3E30")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700042F")]
		public int? RequestedPrice
		{
			[Cpp2IlInjected.Token(Token = "0x60009FB")]
			[Cpp2IlInjected.Address(RVA = "0x10D2A80", Offset = "0x10D1E80", VA = "0x1810D2A80")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60009FC")]
			[Cpp2IlInjected.Address(RVA = "0x10D2AB0", Offset = "0x10D1EB0", VA = "0x1810D2AB0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60009F5")]
		[Cpp2IlInjected.Address(RVA = "0x7723B70", Offset = "0x7722F70", VA = "0x187723B70")]
		public PurchaseBattlePassRequestDTO(int BattlePassSkuId, int? ToAccountId, int? RequestedPrice)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60009FD")]
		[Cpp2IlInjected.Address(RVA = "0x7723A30", Offset = "0x7722E30", VA = "0x187723A30", Slot = "3")]
		[CompilerGenerated]
		public override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60009FE")]
		[Cpp2IlInjected.Address(RVA = "0x7723840", Offset = "0x7722C40", VA = "0x187723840", Slot = "6")]
		[CompilerGenerated]
		protected virtual bool LXITBKEHWVK(StringBuilder a)
		{
			return default(bool);
		}

		[SpecialName]
		[Cpp2IlInjected.Token(Token = "0x60009FF")]
		[Cpp2IlInjected.Address(RVA = "0xFB47E0", Offset = "0xFB3BE0", VA = "0x180FB47E0")]
		[CompilerGenerated]
		public static bool ZPGHGHNXRJT(PurchaseBattlePassRequestDTO? a, PurchaseBattlePassRequestDTO? b)
		{
			return default(bool);
		}

		[SpecialName]
		[Cpp2IlInjected.Token(Token = "0x6000A00")]
		[Cpp2IlInjected.Address(RVA = "0xFB4820", Offset = "0xFB3C20", VA = "0x180FB4820")]
		[CompilerGenerated]
		public static bool ZWISVWGZSLY(PurchaseBattlePassRequestDTO? a, PurchaseBattlePassRequestDTO? b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000A01")]
		[Cpp2IlInjected.Address(RVA = "0x77236C0", Offset = "0x7722AC0", VA = "0x1877236C0", Slot = "2")]
		[CompilerGenerated]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000A02")]
		[Cpp2IlInjected.Address(RVA = "0x77234B0", Offset = "0x77228B0", VA = "0x1877234B0", Slot = "0")]
		[CompilerGenerated]
		public override bool Equals(object? obj)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000A03")]
		[Cpp2IlInjected.Address(RVA = "0x7723540", Offset = "0x7722940", VA = "0x187723540", Slot = "7")]
		[CompilerGenerated]
		public virtual bool Equals(PurchaseBattlePassRequestDTO? other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000A04")]
		[Cpp2IlInjected.Address(RVA = "0x7723960", Offset = "0x7722D60", VA = "0x187723960", Slot = "8")]
		[CompilerGenerated]
		public virtual PurchaseBattlePassRequestDTO OMSRAXDGICF()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000A05")]
		[Cpp2IlInjected.Address(RVA = "0x7723B20", Offset = "0x7722F20", VA = "0x187723B20")]
		[CompilerGenerated]
		protected PurchaseBattlePassRequestDTO(PurchaseBattlePassRequestDTO original)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000A06")]
		[Cpp2IlInjected.Address(RVA = "0x7723820", Offset = "0x7722C20", VA = "0x187723820")]
		[CompilerGenerated]
		public void HYZXLOOBRHM([Out] int a, [Out] int? b, [Out] int? c)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200016E")]
	[Utf8JsonSerializable]
	public class ReportBattlePassSessionRequestDTO : IEquatable<ReportBattlePassSessionRequestDTO>
	{
		[Cpp2IlInjected.Token(Token = "0x17000430")]
		[CompilerGenerated]
		protected virtual Type ITQAFHBSGFG
		{
			[Cpp2IlInjected.Token(Token = "0x6000A08")]
			[Cpp2IlInjected.Address(RVA = "0x77241D0", Offset = "0x77235D0", VA = "0x1877241D0", Slot = "5")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000431")]
		public long RoomInstanceId
		{
			[Cpp2IlInjected.Token(Token = "0x6000A09")]
			[Cpp2IlInjected.Address(RVA = "0xAA5FB0", Offset = "0xAA53B0", VA = "0x180AA5FB0")]
			[CompilerGenerated]
			get
			{
				return default(long);
			}
			[Cpp2IlInjected.Token(Token = "0x6000A0A")]
			[Cpp2IlInjected.Address(RVA = "0xB96550", Offset = "0xB95950", VA = "0x180B96550")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000432")]
		public DateTime SessionStartTime
		{
			[Cpp2IlInjected.Token(Token = "0x6000A0B")]
			[Cpp2IlInjected.Address(RVA = "0xAAA880", Offset = "0xAA9C80", VA = "0x180AAA880")]
			[CompilerGenerated]
			get
			{
				return default(DateTime);
			}
			[Cpp2IlInjected.Token(Token = "0x6000A0C")]
			[Cpp2IlInjected.Address(RVA = "0x10BA780", Offset = "0x10B9B80", VA = "0x1810BA780")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000433")]
		public IReadOnlyDictionary<BattlePassEvent, int> Events
		{
			[Cpp2IlInjected.Token(Token = "0x6000A0D")]
			[Cpp2IlInjected.Address(RVA = "0xAAB1C0", Offset = "0xAAA5C0", VA = "0x180AAB1C0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000A0E")]
			[Cpp2IlInjected.Address(RVA = "0xAA67C0", Offset = "0xAA5BC0", VA = "0x180AA67C0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000434")]
		public IReadOnlyList<int> TeammateAccountIds
		{
			[Cpp2IlInjected.Token(Token = "0x6000A0F")]
			[Cpp2IlInjected.Address(RVA = "0xAAA820", Offset = "0xAA9C20", VA = "0x180AAA820")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000A10")]
			[Cpp2IlInjected.Address(RVA = "0xAA67D0", Offset = "0xAA5BD0", VA = "0x180AA67D0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000A07")]
		[Cpp2IlInjected.Address(RVA = "0x7724310", Offset = "0x7723710", VA = "0x187724310")]
		public ReportBattlePassSessionRequestDTO(long RoomInstanceId, DateTime SessionStartTime, IReadOnlyDictionary<BattlePassEvent, int> Events, IReadOnlyList<int> TeammateAccountIds)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000A11")]
		[Cpp2IlInjected.Address(RVA = "0x7724220", Offset = "0x7723620", VA = "0x187724220", Slot = "3")]
		[CompilerGenerated]
		public override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000A12")]
		[Cpp2IlInjected.Address(RVA = "0x7724000", Offset = "0x7723400", VA = "0x187724000", Slot = "6")]
		[CompilerGenerated]
		protected virtual bool LXITBKEHWVK(StringBuilder a)
		{
			return default(bool);
		}

		[SpecialName]
		[Cpp2IlInjected.Token(Token = "0x6000A13")]
		[Cpp2IlInjected.Address(RVA = "0xFB47E0", Offset = "0xFB3BE0", VA = "0x180FB47E0")]
		[CompilerGenerated]
		public static bool ZPGHGHNXRJT(ReportBattlePassSessionRequestDTO? a, ReportBattlePassSessionRequestDTO? b)
		{
			return default(bool);
		}

		[SpecialName]
		[Cpp2IlInjected.Token(Token = "0x6000A14")]
		[Cpp2IlInjected.Address(RVA = "0xFB4820", Offset = "0xFB3C20", VA = "0x180FB4820")]
		[CompilerGenerated]
		public static bool ZWISVWGZSLY(ReportBattlePassSessionRequestDTO? a, ReportBattlePassSessionRequestDTO? b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000A15")]
		[Cpp2IlInjected.Address(RVA = "0x7723E00", Offset = "0x7723200", VA = "0x187723E00", Slot = "2")]
		[CompilerGenerated]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000A16")]
		[Cpp2IlInjected.Address(RVA = "0x7723B90", Offset = "0x7722F90", VA = "0x187723B90", Slot = "0")]
		[CompilerGenerated]
		public override bool Equals(object? obj)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000A17")]
		[Cpp2IlInjected.Address(RVA = "0x7723C20", Offset = "0x7723020", VA = "0x187723C20", Slot = "7")]
		[CompilerGenerated]
		public virtual bool Equals(ReportBattlePassSessionRequestDTO? other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000A18")]
		[Cpp2IlInjected.Address(RVA = "0x7724140", Offset = "0x7723540", VA = "0x187724140", Slot = "8")]
		[CompilerGenerated]
		public virtual ReportBattlePassSessionRequestDTO OMSRAXDGICF()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000A19")]
		[Cpp2IlInjected.Address(RVA = "0x7724360", Offset = "0x7723760", VA = "0x187724360")]
		[CompilerGenerated]
		protected ReportBattlePassSessionRequestDTO(ReportBattlePassSessionRequestDTO original)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000A1A")]
		[Cpp2IlInjected.Address(RVA = "0x7723FC0", Offset = "0x77233C0", VA = "0x187723FC0")]
		[CompilerGenerated]
		public void HYZXLOOBRHM([Out] long a, [Out] DateTime b, [Out] IReadOnlyDictionary<BattlePassEvent, int> c, [Out] IReadOnlyList<int> d)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200016F")]
	[Utf8JsonSerializable]
	public class ReportBattlePassSessionResponseDTO : IEquatable<ReportBattlePassSessionResponseDTO>
	{
		[Cpp2IlInjected.Token(Token = "0x17000435")]
		[CompilerGenerated]
		protected virtual Type ITQAFHBSGFG
		{
			[Cpp2IlInjected.Token(Token = "0x6000A1C")]
			[Cpp2IlInjected.Address(RVA = "0x7724A90", Offset = "0x7723E90", VA = "0x187724A90", Slot = "5")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000436")]
		public BattlePassAccountProgressDTO Progress
		{
			[Cpp2IlInjected.Token(Token = "0x6000A1D")]
			[Cpp2IlInjected.Address(RVA = "0xAA5FB0", Offset = "0xAA53B0", VA = "0x180AA5FB0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000A1E")]
			[Cpp2IlInjected.Address(RVA = "0xAA5FC0", Offset = "0xAA53C0", VA = "0x180AA5FC0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000437")]
		public int EventXpEarned
		{
			[Cpp2IlInjected.Token(Token = "0x6000A1F")]
			[Cpp2IlInjected.Address(RVA = "0xAAC980", Offset = "0xAABD80", VA = "0x180AAC980")]
			[CompilerGenerated]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x6000A20")]
			[Cpp2IlInjected.Address(RVA = "0xAB2F40", Offset = "0xAB2340", VA = "0x180AB2F40")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000438")]
		public int ParticipationBonusXpEarned
		{
			[Cpp2IlInjected.Token(Token = "0x6000A21")]
			[Cpp2IlInjected.Address(RVA = "0x12E70B0", Offset = "0x12E64B0", VA = "0x1812E70B0")]
			[CompilerGenerated]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x6000A22")]
			[Cpp2IlInjected.Address(RVA = "0x12E70C0", Offset = "0x12E64C0", VA = "0x1812E70C0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000439")]
		public int BoostPercent
		{
			[Cpp2IlInjected.Token(Token = "0x6000A23")]
			[Cpp2IlInjected.Address(RVA = "0xAB5660", Offset = "0xAB4A60", VA = "0x180AB5660")]
			[CompilerGenerated]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x6000A24")]
			[Cpp2IlInjected.Address(RVA = "0xB07AB0", Offset = "0xB06EB0", VA = "0x180B07AB0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700043A")]
		public int TeamBonusPercent
		{
			[Cpp2IlInjected.Token(Token = "0x6000A25")]
			[Cpp2IlInjected.Address(RVA = "0xACC3D0", Offset = "0xACB7D0", VA = "0x180ACC3D0")]
			[CompilerGenerated]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x6000A26")]
			[Cpp2IlInjected.Address(RVA = "0xBE18B0", Offset = "0xBE0CB0", VA = "0x180BE18B0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000A1B")]
		[Cpp2IlInjected.Address(RVA = "0x7724C30", Offset = "0x7724030", VA = "0x187724C30")]
		public ReportBattlePassSessionResponseDTO(BattlePassAccountProgressDTO Progress, int EventXpEarned, int ParticipationBonusXpEarned, int BoostPercent, int TeamBonusPercent)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000A27")]
		[Cpp2IlInjected.Address(RVA = "0x7724AE0", Offset = "0x7723EE0", VA = "0x187724AE0", Slot = "3")]
		[CompilerGenerated]
		public override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000A28")]
		[Cpp2IlInjected.Address(RVA = "0x7724890", Offset = "0x7723C90", VA = "0x187724890", Slot = "6")]
		[CompilerGenerated]
		protected virtual bool LXITBKEHWVK(StringBuilder a)
		{
			return default(bool);
		}

		[SpecialName]
		[Cpp2IlInjected.Token(Token = "0x6000A29")]
		[Cpp2IlInjected.Address(RVA = "0xFB47E0", Offset = "0xFB3BE0", VA = "0x180FB47E0")]
		[CompilerGenerated]
		public static bool ZPGHGHNXRJT(ReportBattlePassSessionResponseDTO? a, ReportBattlePassSessionResponseDTO? b)
		{
			return default(bool);
		}

		[SpecialName]
		[Cpp2IlInjected.Token(Token = "0x6000A2A")]
		[Cpp2IlInjected.Address(RVA = "0xFB4820", Offset = "0xFB3C20", VA = "0x180FB4820")]
		[CompilerGenerated]
		public static bool ZWISVWGZSLY(ReportBattlePassSessionResponseDTO? a, ReportBattlePassSessionResponseDTO? b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000A2B")]
		[Cpp2IlInjected.Address(RVA = "0x7724650", Offset = "0x7723A50", VA = "0x187724650", Slot = "2")]
		[CompilerGenerated]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000A2C")]
		[Cpp2IlInjected.Address(RVA = "0x77245C0", Offset = "0x77239C0", VA = "0x1877245C0", Slot = "0")]
		[CompilerGenerated]
		public override bool Equals(object? obj)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000A2D")]
		[Cpp2IlInjected.Address(RVA = "0x77243C0", Offset = "0x77237C0", VA = "0x1877243C0", Slot = "7")]
		[CompilerGenerated]
		public virtual bool Equals(ReportBattlePassSessionResponseDTO? other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000A2E")]
		[Cpp2IlInjected.Address(RVA = "0x7724A00", Offset = "0x7723E00", VA = "0x187724A00", Slot = "8")]
		[CompilerGenerated]
		public virtual ReportBattlePassSessionResponseDTO OMSRAXDGICF()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000A2F")]
		[Cpp2IlInjected.Address(RVA = "0x7724BD0", Offset = "0x7723FD0", VA = "0x187724BD0")]
		[CompilerGenerated]
		protected ReportBattlePassSessionResponseDTO(ReportBattlePassSessionResponseDTO original)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000A30")]
		[Cpp2IlInjected.Address(RVA = "0x7724830", Offset = "0x7723C30", VA = "0x187724830")]
		[CompilerGenerated]
		public void HYZXLOOBRHM([Out] BattlePassAccountProgressDTO a, [Out] int b, [Out] int c, [Out] int d, [Out] int e)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000170")]
	public interface IBVTTMIBQLU
	{
		[Cpp2IlInjected.Token(Token = "0x6000A31")]
		[Cpp2IlInjected.Address(Slot = "0")]
		Task<BattlePassDTO> VYTNRJHSLLB([Optional] CancellationToken a);

		[Cpp2IlInjected.Token(Token = "0x6000A32")]
		[Cpp2IlInjected.Address(Slot = "1")]
		Task<BattlePassAccountProgressDTO> YWECGNRDAFI([Optional] CancellationToken a);

		[Cpp2IlInjected.Token(Token = "0x6000A33")]
		[Cpp2IlInjected.Address(Slot = "2")]
		Task SFXJGDDRQIS(int a, [Optional] int? b, [Optional] int? c, [Optional] CancellationToken d);

		[Cpp2IlInjected.Token(Token = "0x6000A34")]
		[Cpp2IlInjected.Address(Slot = "3")]
		Task ICANHRYUECI(int a, [Optional] int? b, [Optional] CancellationToken c);

		[Cpp2IlInjected.Token(Token = "0x6000A35")]
		[Cpp2IlInjected.Address(Slot = "4")]
		Task<ReportBattlePassSessionResponseDTO> YDBVGFXHPLY(DateTime a, IReadOnlyDictionary<BattlePassEvent, int> b, IReadOnlyList<int> c, [Optional] CancellationToken d);

		[Cpp2IlInjected.Token(Token = "0x6000A36")]
		[Cpp2IlInjected.Address(Slot = "5")]
		Task RHGKEIXDCCB([Optional] CancellationToken a);
	}
}
namespace RecNet.AI
{
	[Cpp2IlInjected.Token(Token = "0x2000171")]
	[Utf8JsonSerializable]
	public class RoomieEnergyDTO
	{
		[Cpp2IlInjected.Token(Token = "0x1700043B")]
		public long MaxEnergyFromSubscriptions
		{
			[Cpp2IlInjected.Token(Token = "0x6000A37")]
			[Cpp2IlInjected.Address(RVA = "0xAA5FB0", Offset = "0xAA53B0", VA = "0x180AA5FB0")]
			[CompilerGenerated]
			get
			{
				return default(long);
			}
			[Cpp2IlInjected.Token(Token = "0x6000A38")]
			[Cpp2IlInjected.Address(RVA = "0xB96550", Offset = "0xB95950", VA = "0x180B96550")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700043C")]
		public long EnergyLeft
		{
			[Cpp2IlInjected.Token(Token = "0x6000A39")]
			[Cpp2IlInjected.Address(RVA = "0xAAA880", Offset = "0xAA9C80", VA = "0x180AAA880")]
			[CompilerGenerated]
			get
			{
				return default(long);
			}
			[Cpp2IlInjected.Token(Token = "0x6000A3A")]
			[Cpp2IlInjected.Address(RVA = "0x10BA780", Offset = "0x10B9B80", VA = "0x1810BA780")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700043D")]
		public bool OutputAudioEnabled
		{
			[Cpp2IlInjected.Token(Token = "0x6000A3B")]
			[Cpp2IlInjected.Address(RVA = "0xAAA010", Offset = "0xAA9410", VA = "0x180AAA010")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000A3C")]
			[Cpp2IlInjected.Address(RVA = "0xAAA830", Offset = "0xAA9C30", VA = "0x180AAA830")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000A3D")]
		[Cpp2IlInjected.Address(RVA = "0xAAC8E0", Offset = "0xAABCE0", VA = "0x180AAC8E0")]
		public RoomieEnergyDTO()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000172")]
	[Utf8JsonSerializable]
	public class GenerateCircuitsRequestDTO
	{
		[Cpp2IlInjected.Token(Token = "0x1700043E")]
		public string Prompt
		{
			[Cpp2IlInjected.Token(Token = "0x6000A3E")]
			[Cpp2IlInjected.Address(RVA = "0xAA5FB0", Offset = "0xAA53B0", VA = "0x180AA5FB0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000A3F")]
			[Cpp2IlInjected.Address(RVA = "0xAA5FC0", Offset = "0xAA53C0", VA = "0x180AA5FC0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700043F")]
		public CircuitObjectDefinition? ObjectDefinition
		{
			[Cpp2IlInjected.Token(Token = "0x6000A40")]
			[Cpp2IlInjected.Address(RVA = "0xAAA880", Offset = "0xAA9C80", VA = "0x180AAA880")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000A41")]
			[Cpp2IlInjected.Address(RVA = "0xAAA120", Offset = "0xAA9520", VA = "0x180AAA120")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000440")]
		public IReadOnlyList<CircuitObjectDefinition>? SceneObjectDefinitions
		{
			[Cpp2IlInjected.Token(Token = "0x6000A42")]
			[Cpp2IlInjected.Address(RVA = "0xAAB1C0", Offset = "0xAAA5C0", VA = "0x180AAB1C0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000A43")]
			[Cpp2IlInjected.Address(RVA = "0xAA67C0", Offset = "0xAA5BC0", VA = "0x180AA67C0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000441")]
		public IReadOnlyList<string>? SceneTags
		{
			[Cpp2IlInjected.Token(Token = "0x6000A44")]
			[Cpp2IlInjected.Address(RVA = "0xAAA820", Offset = "0xAA9C20", VA = "0x180AAA820")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000A45")]
			[Cpp2IlInjected.Address(RVA = "0xAA67D0", Offset = "0xAA5BD0", VA = "0x180AA67D0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000442")]
		public CircuitGenConfigDTO Config
		{
			[Cpp2IlInjected.Token(Token = "0x6000A46")]
			[Cpp2IlInjected.Address(RVA = "0xAAA140", Offset = "0xAA9540", VA = "0x180AAA140")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000A47")]
			[Cpp2IlInjected.Address(RVA = "0xAADB00", Offset = "0xAACF00", VA = "0x180AADB00")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000443")]
		public string? Instructions
		{
			[Cpp2IlInjected.Token(Token = "0x6000A48")]
			[Cpp2IlInjected.Address(RVA = "0xAAA030", Offset = "0xAA9430", VA = "0x180AAA030")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000A49")]
			[Cpp2IlInjected.Address(RVA = "0xAAA110", Offset = "0xAA9510", VA = "0x180AAA110")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000444")]
		public string? LibraryCode
		{
			[Cpp2IlInjected.Token(Token = "0x6000A4A")]
			[Cpp2IlInjected.Address(RVA = "0xAAA810", Offset = "0xAA9C10", VA = "0x180AAA810")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000A4B")]
			[Cpp2IlInjected.Address(RVA = "0xAAA840", Offset = "0xAA9C40", VA = "0x180AAA840")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000445")]
		public string? Model
		{
			[Cpp2IlInjected.Token(Token = "0x6000A4C")]
			[Cpp2IlInjected.Address(RVA = "0xAAA160", Offset = "0xAA9560", VA = "0x180AAA160")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000A4D")]
			[Cpp2IlInjected.Address(RVA = "0xAAA870", Offset = "0xAA9C70", VA = "0x180AAA870")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000A4E")]
		[Cpp2IlInjected.Address(RVA = "0xAAC8E0", Offset = "0xAABCE0", VA = "0x180AAC8E0")]
		public GenerateCircuitsRequestDTO()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000173")]
	[Utf8JsonSerializable]
	public class GenerateCircuitsFromCodeRequestDTO
	{
		[Cpp2IlInjected.Token(Token = "0x17000446")]
		public string Code
		{
			[Cpp2IlInjected.Token(Token = "0x6000A4F")]
			[Cpp2IlInjected.Address(RVA = "0xAA5FB0", Offset = "0xAA53B0", VA = "0x180AA5FB0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000A50")]
			[Cpp2IlInjected.Address(RVA = "0xAA5FC0", Offset = "0xAA53C0", VA = "0x180AA5FC0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000447")]
		public CircuitObjectDefinition? ObjectDefinition
		{
			[Cpp2IlInjected.Token(Token = "0x6000A51")]
			[Cpp2IlInjected.Address(RVA = "0xAAA880", Offset = "0xAA9C80", VA = "0x180AAA880")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000A52")]
			[Cpp2IlInjected.Address(RVA = "0xAAA120", Offset = "0xAA9520", VA = "0x180AAA120")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000448")]
		public CircuitGenConfigDTO Config
		{
			[Cpp2IlInjected.Token(Token = "0x6000A53")]
			[Cpp2IlInjected.Address(RVA = "0xAAB1C0", Offset = "0xAAA5C0", VA = "0x180AAB1C0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000A54")]
			[Cpp2IlInjected.Address(RVA = "0xAA67C0", Offset = "0xAA5BC0", VA = "0x180AA67C0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000449")]
		public string? LibraryCode
		{
			[Cpp2IlInjected.Token(Token = "0x6000A55")]
			[Cpp2IlInjected.Address(RVA = "0xAAA820", Offset = "0xAA9C20", VA = "0x180AAA820")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000A56")]
			[Cpp2IlInjected.Address(RVA = "0xAA67D0", Offset = "0xAA5BD0", VA = "0x180AA67D0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700044A")]
		public IReadOnlyList<string>? SceneTags
		{
			[Cpp2IlInjected.Token(Token = "0x6000A57")]
			[Cpp2IlInjected.Address(RVA = "0xAAA140", Offset = "0xAA9540", VA = "0x180AAA140")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000A58")]
			[Cpp2IlInjected.Address(RVA = "0xAADB00", Offset = "0xAACF00", VA = "0x180AADB00")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000A59")]
		[Cpp2IlInjected.Address(RVA = "0xAAC8E0", Offset = "0xAABCE0", VA = "0x180AAC8E0")]
		public GenerateCircuitsFromCodeRequestDTO()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000174")]
	[Utf8JsonSerializable]
	public class CircuitGenConfigDTO
	{
		[Cpp2IlInjected.Token(Token = "0x1700044B")]
		public string LibraryId
		{
			[Cpp2IlInjected.Token(Token = "0x6000A5B")]
			[Cpp2IlInjected.Address(RVA = "0xAA5FB0", Offset = "0xAA53B0", VA = "0x180AA5FB0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000A5C")]
			[Cpp2IlInjected.Address(RVA = "0xAA5FC0", Offset = "0xAA53C0", VA = "0x180AA5FC0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700044C")]
		public bool AllowBetaContent
		{
			[Cpp2IlInjected.Token(Token = "0x6000A5D")]
			[Cpp2IlInjected.Address(RVA = "0xBC19C0", Offset = "0xBC0DC0", VA = "0x180BC19C0")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000A5E")]
			[Cpp2IlInjected.Address(RVA = "0xAA7380", Offset = "0xAA6780", VA = "0x180AA7380")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700044D")]
		public bool ComponentModificationEnabled
		{
			[Cpp2IlInjected.Token(Token = "0x6000A5F")]
			[Cpp2IlInjected.Address(RVA = "0xF3EA50", Offset = "0xF3DE50", VA = "0x180F3EA50")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000A60")]
			[Cpp2IlInjected.Address(RVA = "0x109A760", Offset = "0x1099B60", VA = "0x18109A760")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700044E")]
		public bool UseOnObjectSpawnedOrReset
		{
			[Cpp2IlInjected.Token(Token = "0x6000A61")]
			[Cpp2IlInjected.Address(RVA = "0xF3EA40", Offset = "0xF3DE40", VA = "0x180F3EA40")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000A62")]
			[Cpp2IlInjected.Address(RVA = "0x1420D30", Offset = "0x1420130", VA = "0x181420D30")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700044F")]
		public bool ExposeTunables
		{
			[Cpp2IlInjected.Token(Token = "0x6000A63")]
			[Cpp2IlInjected.Address(RVA = "0xF3EA20", Offset = "0xF3DE20", VA = "0x180F3EA20")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000A64")]
			[Cpp2IlInjected.Address(RVA = "0x5300BD0", Offset = "0x52FFFD0", VA = "0x185300BD0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000450")]
		public bool ExposePublicMethods
		{
			[Cpp2IlInjected.Token(Token = "0x6000A65")]
			[Cpp2IlInjected.Address(RVA = "0xBC0680", Offset = "0xBBFA80", VA = "0x180BC0680")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000A66")]
			[Cpp2IlInjected.Address(RVA = "0xBC0B60", Offset = "0xBBFF60", VA = "0x180BC0B60")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000451")]
		public bool ObjectEventsEnabled
		{
			[Cpp2IlInjected.Token(Token = "0x6000A67")]
			[Cpp2IlInjected.Address(RVA = "0xBBFFD0", Offset = "0xBBF3D0", VA = "0x180BBFFD0")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000A68")]
			[Cpp2IlInjected.Address(RVA = "0xBBFFF0", Offset = "0xBBF3F0", VA = "0x180BBFFF0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000452")]
		public bool SpawnablesEnabled
		{
			[Cpp2IlInjected.Token(Token = "0x6000A69")]
			[Cpp2IlInjected.Address(RVA = "0x1860F70", Offset = "0x1860370", VA = "0x181860F70")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000A6A")]
			[Cpp2IlInjected.Address(RVA = "0x7722C60", Offset = "0x7722060", VA = "0x187722C60")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000453")]
		public bool TagEnumEnabled
		{
			[Cpp2IlInjected.Token(Token = "0x6000A6B")]
			[Cpp2IlInjected.Address(RVA = "0x18482C0", Offset = "0x18476C0", VA = "0x1818482C0")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000A6C")]
			[Cpp2IlInjected.Address(RVA = "0x7722C70", Offset = "0x7722070", VA = "0x187722C70")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000454")]
		public bool IsRecRoomObjectOfTypeEnabled
		{
			[Cpp2IlInjected.Token(Token = "0x6000A6D")]
			[Cpp2IlInjected.Address(RVA = "0xAAA010", Offset = "0xAA9410", VA = "0x180AAA010")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000A6E")]
			[Cpp2IlInjected.Address(RVA = "0xAAA830", Offset = "0xAA9C30", VA = "0x180AAA830")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000455")]
		public bool VirtualMethodsEnabled
		{
			[Cpp2IlInjected.Token(Token = "0x6000A6F")]
			[Cpp2IlInjected.Address(RVA = "0x12D46D0", Offset = "0x12D3AD0", VA = "0x1812D46D0")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000A70")]
			[Cpp2IlInjected.Address(RVA = "0x12D41C0", Offset = "0x12D35C0", VA = "0x1812D41C0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000456")]
		public bool ComponentModificationEnabledForSceneObjects
		{
			[Cpp2IlInjected.Token(Token = "0x6000A71")]
			[Cpp2IlInjected.Address(RVA = "0x1857B90", Offset = "0x1856F90", VA = "0x181857B90")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000A72")]
			[Cpp2IlInjected.Address(RVA = "0x1ACB0C0", Offset = "0x1ACA4C0", VA = "0x181ACB0C0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000A5A")]
		[Cpp2IlInjected.Address(RVA = "0x7722BB0", Offset = "0x7721FB0", VA = "0x187722BB0")]
		public CircuitGenConfigDTO(string libraryId, bool allowBetaContent, bool componentModificationEnabled, bool useOnObjectSpawnedOrReset, bool exposeTunables, bool exposePublicMethods, bool objectEventsEnabled, bool spawnablesEnabled, bool tagEnumEnabled, bool isRecRoomObjectOfTypeEnabled, bool virtualMethodsEnabled, bool componentModificationEnabledForSceneObjects)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000175")]
	[Utf8JsonSerializable]
	public class CreateRealtimeSessionRequestDTO
	{
		[Cpp2IlInjected.Token(Token = "0x17000457")]
		public string AIType
		{
			[Cpp2IlInjected.Token(Token = "0x6000A73")]
			[Cpp2IlInjected.Address(RVA = "0xAA5FB0", Offset = "0xAA53B0", VA = "0x180AA5FB0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000A74")]
			[Cpp2IlInjected.Address(RVA = "0xAA5FC0", Offset = "0xAA53C0", VA = "0x180AA5FC0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000458")]
		public string Model
		{
			[Cpp2IlInjected.Token(Token = "0x6000A75")]
			[Cpp2IlInjected.Address(RVA = "0xAAA880", Offset = "0xAA9C80", VA = "0x180AAA880")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000A76")]
			[Cpp2IlInjected.Address(RVA = "0xAAA120", Offset = "0xAA9520", VA = "0x180AAA120")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000459")]
		public string Instructions
		{
			[Cpp2IlInjected.Token(Token = "0x6000A77")]
			[Cpp2IlInjected.Address(RVA = "0xAAB1C0", Offset = "0xAAA5C0", VA = "0x180AAB1C0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000A78")]
			[Cpp2IlInjected.Address(RVA = "0xAA67C0", Offset = "0xAA5BC0", VA = "0x180AA67C0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700045A")]
		public string? Voice
		{
			[Cpp2IlInjected.Token(Token = "0x6000A79")]
			[Cpp2IlInjected.Address(RVA = "0xAAA820", Offset = "0xAA9C20", VA = "0x180AAA820")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000A7A")]
			[Cpp2IlInjected.Address(RVA = "0xAA67D0", Offset = "0xAA5BD0", VA = "0x180AA67D0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700045B")]
		public string? TranscriptionModel
		{
			[Cpp2IlInjected.Token(Token = "0x6000A7B")]
			[Cpp2IlInjected.Address(RVA = "0xAAA140", Offset = "0xAA9540", VA = "0x180AAA140")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000A7C")]
			[Cpp2IlInjected.Address(RVA = "0xAADB00", Offset = "0xAACF00", VA = "0x180AADB00")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700045C")]
		public float Temperature
		{
			[Cpp2IlInjected.Token(Token = "0x6000A7D")]
			[Cpp2IlInjected.Address(RVA = "0xB781E0", Offset = "0xB775E0", VA = "0x180B781E0")]
			[CompilerGenerated]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x6000A7E")]
			[Cpp2IlInjected.Address(RVA = "0x10ECD80", Offset = "0x10EC180", VA = "0x1810ECD80")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000A7F")]
		[Cpp2IlInjected.Address(RVA = "0xAAC8E0", Offset = "0xAABCE0", VA = "0x180AAC8E0")]
		public CreateRealtimeSessionRequestDTO()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000176")]
	[Utf8JsonSerializable]
	public class CreateRealtimeSessionResponseDTO : GMMXLNCCSCD
	{
		[Cpp2IlInjected.Token(Token = "0x1700045D")]
		public string SessionId
		{
			[Cpp2IlInjected.Token(Token = "0x6000A80")]
			[Cpp2IlInjected.Address(RVA = "0xAA5FB0", Offset = "0xAA53B0", VA = "0x180AA5FB0", Slot = "4")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000A81")]
			[Cpp2IlInjected.Address(RVA = "0xAA5FC0", Offset = "0xAA53C0", VA = "0x180AA5FC0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700045E")]
		public string ClientSecret
		{
			[Cpp2IlInjected.Token(Token = "0x6000A82")]
			[Cpp2IlInjected.Address(RVA = "0xAAA880", Offset = "0xAA9C80", VA = "0x180AAA880", Slot = "5")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000A83")]
			[Cpp2IlInjected.Address(RVA = "0xAAA120", Offset = "0xAA9520", VA = "0x180AAA120")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000A84")]
		[Cpp2IlInjected.Address(RVA = "0xAAC8E0", Offset = "0xAABCE0", VA = "0x180AAC8E0")]
		public CreateRealtimeSessionResponseDTO()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000177")]
	[Utf8JsonSerializable]
	public class UpdateUserSessionSpendRequestDTO
	{
		[Cpp2IlInjected.Token(Token = "0x1700045F")]
		public Guid SpendSessionId
		{
			[Cpp2IlInjected.Token(Token = "0x6000A85")]
			[Cpp2IlInjected.Address(RVA = "0xBAF500", Offset = "0xBAE900", VA = "0x180BAF500")]
			[CompilerGenerated]
			get
			{
				return default(Guid);
			}
			[Cpp2IlInjected.Token(Token = "0x6000A86")]
			[Cpp2IlInjected.Address(RVA = "0xBAF520", Offset = "0xBAE920", VA = "0x180BAF520")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000460")]
		public long RoomId
		{
			[Cpp2IlInjected.Token(Token = "0x6000A87")]
			[Cpp2IlInjected.Address(RVA = "0xAAB1C0", Offset = "0xAAA5C0", VA = "0x180AAB1C0")]
			[CompilerGenerated]
			get
			{
				return default(long);
			}
			[Cpp2IlInjected.Token(Token = "0x6000A88")]
			[Cpp2IlInjected.Address(RVA = "0xB30430", Offset = "0xB2F830", VA = "0x180B30430")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000461")]
		public long RoomInstanceId
		{
			[Cpp2IlInjected.Token(Token = "0x6000A89")]
			[Cpp2IlInjected.Address(RVA = "0xAAA820", Offset = "0xAA9C20", VA = "0x180AAA820")]
			[CompilerGenerated]
			get
			{
				return default(long);
			}
			[Cpp2IlInjected.Token(Token = "0x6000A8A")]
			[Cpp2IlInjected.Address(RVA = "0xAAA000", Offset = "0xAA9400", VA = "0x180AAA000")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000462")]
		public decimal Spend
		{
			[Cpp2IlInjected.Token(Token = "0x6000A8B")]
			[Cpp2IlInjected.Address(RVA = "0xC5CFF0", Offset = "0xC5C3F0", VA = "0x180C5CFF0")]
			[CompilerGenerated]
			get
			{
				return default(decimal);
			}
			[Cpp2IlInjected.Token(Token = "0x6000A8C")]
			[Cpp2IlInjected.Address(RVA = "0xC5D250", Offset = "0xC5C650", VA = "0x180C5D250")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000A8D")]
		[Cpp2IlInjected.Address(RVA = "0xAAC8E0", Offset = "0xAABCE0", VA = "0x180AAC8E0")]
		public UpdateUserSessionSpendRequestDTO()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000178")]
	[Utf8JsonSerializable]
	public class UpdateRoomieSessionSpendRequestDTO : UpdateUserSessionSpendRequestDTO
	{
		[Cpp2IlInjected.Token(Token = "0x17000463")]
		public byte RoomieEnergyMode
		{
			[Cpp2IlInjected.Token(Token = "0x6000A8E")]
			[Cpp2IlInjected.Address(RVA = "0xC6B720", Offset = "0xC6AB20", VA = "0x180C6B720")]
			[CompilerGenerated]
			get
			{
				return default(byte);
			}
			[Cpp2IlInjected.Token(Token = "0x6000A8F")]
			[Cpp2IlInjected.Address(RVA = "0xC6B160", Offset = "0xC6A560", VA = "0x180C6B160")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000A90")]
		[Cpp2IlInjected.Address(RVA = "0xAAC8E0", Offset = "0xAABCE0", VA = "0x180AAC8E0")]
		public UpdateRoomieSessionSpendRequestDTO()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000179")]
	[Utf8JsonSerializable]
	public class UploadRealtimeSessionLogsDTO
	{
		[Cpp2IlInjected.Token(Token = "0x17000464")]
		public string SessionId
		{
			[Cpp2IlInjected.Token(Token = "0x6000A91")]
			[Cpp2IlInjected.Address(RVA = "0xAA5FB0", Offset = "0xAA53B0", VA = "0x180AA5FB0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000A92")]
			[Cpp2IlInjected.Address(RVA = "0xAA5FC0", Offset = "0xAA53C0", VA = "0x180AA5FC0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000465")]
		public string Logs
		{
			[Cpp2IlInjected.Token(Token = "0x6000A93")]
			[Cpp2IlInjected.Address(RVA = "0xAAA880", Offset = "0xAA9C80", VA = "0x180AAA880")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000A94")]
			[Cpp2IlInjected.Address(RVA = "0xAAA120", Offset = "0xAA9520", VA = "0x180AAA120")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000A95")]
		[Cpp2IlInjected.Address(RVA = "0xAAC8E0", Offset = "0xAABCE0", VA = "0x180AAC8E0")]
		public UploadRealtimeSessionLogsDTO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000A96")]
		[Cpp2IlInjected.Address(RVA = "0xAA8230", Offset = "0xAA7630", VA = "0x180AA8230")]
		public UploadRealtimeSessionLogsDTO(string sessionId, string logs)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200017A")]
	[Utf8JsonSerializable]
	public class GenerateImageRequestDTO
	{
		[Cpp2IlInjected.Token(Token = "0x17000466")]
		public string Model
		{
			[Cpp2IlInjected.Token(Token = "0x6000A97")]
			[Cpp2IlInjected.Address(RVA = "0xAA5FB0", Offset = "0xAA53B0", VA = "0x180AA5FB0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000A98")]
			[Cpp2IlInjected.Address(RVA = "0xAA5FC0", Offset = "0xAA53C0", VA = "0x180AA5FC0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000467")]
		public string Prompt
		{
			[Cpp2IlInjected.Token(Token = "0x6000A99")]
			[Cpp2IlInjected.Address(RVA = "0xAAA880", Offset = "0xAA9C80", VA = "0x180AAA880")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000A9A")]
			[Cpp2IlInjected.Address(RVA = "0xAAA120", Offset = "0xAA9520", VA = "0x180AAA120")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000468")]
		public bool Tileable
		{
			[Cpp2IlInjected.Token(Token = "0x6000A9B")]
			[Cpp2IlInjected.Address(RVA = "0xAAA010", Offset = "0xAA9410", VA = "0x180AAA010")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000A9C")]
			[Cpp2IlInjected.Address(RVA = "0xAAA830", Offset = "0xAA9C30", VA = "0x180AAA830")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000A9D")]
		[Cpp2IlInjected.Address(RVA = "0xAAC8E0", Offset = "0xAABCE0", VA = "0x180AAC8E0")]
		public GenerateImageRequestDTO()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200017B")]
	[Utf8JsonSerializable]
	public class GenerateImageResponseDTO
	{
		[Cpp2IlInjected.Token(Token = "0x17000469")]
		public string Filename
		{
			[Cpp2IlInjected.Token(Token = "0x6000A9E")]
			[Cpp2IlInjected.Address(RVA = "0xAA5FB0", Offset = "0xAA53B0", VA = "0x180AA5FB0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000A9F")]
			[Cpp2IlInjected.Address(RVA = "0xAA5FC0", Offset = "0xAA53C0", VA = "0x180AA5FC0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700046A")]
		public decimal ImageGenerationCost
		{
			[Cpp2IlInjected.Token(Token = "0x6000AA0")]
			[Cpp2IlInjected.Address(RVA = "0xC66740", Offset = "0xC65B40", VA = "0x180C66740")]
			[CompilerGenerated]
			get
			{
				return default(decimal);
			}
			[Cpp2IlInjected.Token(Token = "0x6000AA1")]
			[Cpp2IlInjected.Address(RVA = "0xC66840", Offset = "0xC65C40", VA = "0x180C66840")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000AA2")]
		[Cpp2IlInjected.Address(RVA = "0xAAC8E0", Offset = "0xAABCE0", VA = "0x180AAC8E0")]
		public GenerateImageResponseDTO()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200017C")]
	[Utf8JsonSerializable]
	public class DescribeImageRequestDTO
	{
		[Cpp2IlInjected.Token(Token = "0x1700046B")]
		public string? Model
		{
			[Cpp2IlInjected.Token(Token = "0x6000AA3")]
			[Cpp2IlInjected.Address(RVA = "0xAA5FB0", Offset = "0xAA53B0", VA = "0x180AA5FB0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000AA4")]
			[Cpp2IlInjected.Address(RVA = "0xAA5FC0", Offset = "0xAA53C0", VA = "0x180AA5FC0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700046C")]
		public string Prompt
		{
			[Cpp2IlInjected.Token(Token = "0x6000AA5")]
			[Cpp2IlInjected.Address(RVA = "0xAAA880", Offset = "0xAA9C80", VA = "0x180AAA880")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000AA6")]
			[Cpp2IlInjected.Address(RVA = "0xAAA120", Offset = "0xAA9520", VA = "0x180AAA120")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700046D")]
		public float? Temperature
		{
			[Cpp2IlInjected.Token(Token = "0x6000AA7")]
			[Cpp2IlInjected.Address(RVA = "0xAAB1C0", Offset = "0xAAA5C0", VA = "0x180AAB1C0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000AA8")]
			[Cpp2IlInjected.Address(RVA = "0xB30430", Offset = "0xB2F830", VA = "0x180B30430")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700046E")]
		public string? ImageName
		{
			[Cpp2IlInjected.Token(Token = "0x6000AA9")]
			[Cpp2IlInjected.Address(RVA = "0xAAA820", Offset = "0xAA9C20", VA = "0x180AAA820")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000AAA")]
			[Cpp2IlInjected.Address(RVA = "0xAA67D0", Offset = "0xAA5BD0", VA = "0x180AA67D0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000AAB")]
		[Cpp2IlInjected.Address(RVA = "0xAAC8E0", Offset = "0xAABCE0", VA = "0x180AAC8E0")]
		public DescribeImageRequestDTO()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200017D")]
	[Utf8JsonSerializable]
	public class DescribeImageResponseDTO : ChatResponseDTO
	{
		[Cpp2IlInjected.Token(Token = "0x6000AAC")]
		[Cpp2IlInjected.Address(RVA = "0xAAC8E0", Offset = "0xAABCE0", VA = "0x180AAC8E0")]
		public DescribeImageResponseDTO()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200017E")]
	[Utf8JsonSerializable]
	public class DescribeImageFileRequestDTO : ChatRequestDTO
	{
		[Cpp2IlInjected.Token(Token = "0x6000AAD")]
		[Cpp2IlInjected.Address(RVA = "0xAAC8E0", Offset = "0xAABCE0", VA = "0x180AAC8E0")]
		public DescribeImageFileRequestDTO()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200017F")]
	[Utf8JsonSerializable]
	public class GenerateMeshRequestDTO
	{
		[Cpp2IlInjected.Token(Token = "0x1700046F")]
		public string FriendlyName
		{
			[Cpp2IlInjected.Token(Token = "0x6000AAE")]
			[Cpp2IlInjected.Address(RVA = "0xAA5FB0", Offset = "0xAA53B0", VA = "0x180AA5FB0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000AAF")]
			[Cpp2IlInjected.Address(RVA = "0xAA5FC0", Offset = "0xAA53C0", VA = "0x180AA5FC0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000470")]
		public string Prompt
		{
			[Cpp2IlInjected.Token(Token = "0x6000AB0")]
			[Cpp2IlInjected.Address(RVA = "0xAAA880", Offset = "0xAA9C80", VA = "0x180AAA880")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000AB1")]
			[Cpp2IlInjected.Address(RVA = "0xAAA120", Offset = "0xAA9520", VA = "0x180AAA120")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000471")]
		public bool AllowRoomInstanceAccess
		{
			[Cpp2IlInjected.Token(Token = "0x6000AB2")]
			[Cpp2IlInjected.Address(RVA = "0xAAA010", Offset = "0xAA9410", VA = "0x180AAA010")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000AB3")]
			[Cpp2IlInjected.Address(RVA = "0xAAA830", Offset = "0xAA9C30", VA = "0x180AAA830")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000AB4")]
		[Cpp2IlInjected.Address(RVA = "0xAAC8E0", Offset = "0xAABCE0", VA = "0x180AAC8E0")]
		public GenerateMeshRequestDTO()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000180")]
	[Utf8JsonSerializable]
	public class GenerateMeshFromImageRequestDTO : GenerateMeshRequestDTO
	{
		[Cpp2IlInjected.Token(Token = "0x17000472")]
		public string ImageName
		{
			[Cpp2IlInjected.Token(Token = "0x6000AB5")]
			[Cpp2IlInjected.Address(RVA = "0xAAA820", Offset = "0xAA9C20", VA = "0x180AAA820")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000AB6")]
			[Cpp2IlInjected.Address(RVA = "0xAA67D0", Offset = "0xAA5BD0", VA = "0x180AA67D0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000AB7")]
		[Cpp2IlInjected.Address(RVA = "0xAAC8E0", Offset = "0xAABCE0", VA = "0x180AAC8E0")]
		public GenerateMeshFromImageRequestDTO()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000181")]
	[Utf8JsonSerializable]
	public class GenerateMeshResponseDTO
	{
		[Cpp2IlInjected.Token(Token = "0x17000473")]
		public long GenerateMeshRequestId
		{
			[Cpp2IlInjected.Token(Token = "0x6000AB8")]
			[Cpp2IlInjected.Address(RVA = "0xAA5FB0", Offset = "0xAA53B0", VA = "0x180AA5FB0")]
			[CompilerGenerated]
			get
			{
				return default(long);
			}
			[Cpp2IlInjected.Token(Token = "0x6000AB9")]
			[Cpp2IlInjected.Address(RVA = "0xB96550", Offset = "0xB95950", VA = "0x180B96550")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000474")]
		public string FriendlyName
		{
			[Cpp2IlInjected.Token(Token = "0x6000ABA")]
			[Cpp2IlInjected.Address(RVA = "0xAAA880", Offset = "0xAA9C80", VA = "0x180AAA880")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000ABB")]
			[Cpp2IlInjected.Address(RVA = "0xAAA120", Offset = "0xAA9520", VA = "0x180AAA120")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000475")]
		public GenerateMeshRequestStates GenerateMeshRequestState
		{
			[Cpp2IlInjected.Token(Token = "0x6000ABC")]
			[Cpp2IlInjected.Address(RVA = "0xAB5660", Offset = "0xAB4A60", VA = "0x180AB5660")]
			[CompilerGenerated]
			get
			{
				return default(GenerateMeshRequestStates);
			}
			[Cpp2IlInjected.Token(Token = "0x6000ABD")]
			[Cpp2IlInjected.Address(RVA = "0xB07AB0", Offset = "0xB06EB0", VA = "0x180B07AB0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000476")]
		public Guid? UnityAssetId
		{
			[Cpp2IlInjected.Token(Token = "0x6000ABE")]
			[Cpp2IlInjected.Address(RVA = "0x7722DA0", Offset = "0x77221A0", VA = "0x187722DA0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000ABF")]
			[Cpp2IlInjected.Address(RVA = "0x7722DC0", Offset = "0x77221C0", VA = "0x187722DC0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000477")]
		public string? MeshFileName
		{
			[Cpp2IlInjected.Token(Token = "0x6000AC0")]
			[Cpp2IlInjected.Address(RVA = "0xAAA030", Offset = "0xAA9430", VA = "0x180AAA030")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000AC1")]
			[Cpp2IlInjected.Address(RVA = "0xAAA110", Offset = "0xAA9510", VA = "0x180AAA110")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000AC2")]
		[Cpp2IlInjected.Address(RVA = "0xAAC8E0", Offset = "0xAABCE0", VA = "0x180AAC8E0")]
		public GenerateMeshResponseDTO()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000182")]
	public enum GenerateMeshRequestStates
	{
		[Cpp2IlInjected.Token(Token = "0x40006F8")]
		Requested = 0,
		[Cpp2IlInjected.Token(Token = "0x40006F9")]
		ProviderMeshRequested = 1,
		[Cpp2IlInjected.Token(Token = "0x40006FA")]
		ProviderMeshGenerated = 2,
		[Cpp2IlInjected.Token(Token = "0x40006FB")]
		ProviderMeshGenFailed = 3,
		[Cpp2IlInjected.Token(Token = "0x40006FC")]
		CloudBuildRequested = 11,
		[Cpp2IlInjected.Token(Token = "0x40006FD")]
		CloudBuildCompleted = 12,
		[Cpp2IlInjected.Token(Token = "0x40006FE")]
		CloudBuildFailed = 13,
		[Cpp2IlInjected.Token(Token = "0x40006FF")]
		MeshGenCompleted = 21,
		[Cpp2IlInjected.Token(Token = "0x4000700")]
		ImageReferenceRequested = 31,
		[Cpp2IlInjected.Token(Token = "0x4000701")]
		ImageReferenceGenerated = 32,
		[Cpp2IlInjected.Token(Token = "0x4000702")]
		ImageReferenceGenerationFailed = 33
	}
	[Cpp2IlInjected.Token(Token = "0x2000183")]
	[Utf8JsonSerializable]
	public class EditImageRequestDTO
	{
		[Cpp2IlInjected.Token(Token = "0x17000478")]
		public string? Model
		{
			[Cpp2IlInjected.Token(Token = "0x6000AC3")]
			[Cpp2IlInjected.Address(RVA = "0xAA5FB0", Offset = "0xAA53B0", VA = "0x180AA5FB0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000AC4")]
			[Cpp2IlInjected.Address(RVA = "0xAA5FC0", Offset = "0xAA53C0", VA = "0x180AA5FC0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000479")]
		public string Prompt
		{
			[Cpp2IlInjected.Token(Token = "0x6000AC5")]
			[Cpp2IlInjected.Address(RVA = "0xAAA880", Offset = "0xAA9C80", VA = "0x180AAA880")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000AC6")]
			[Cpp2IlInjected.Address(RVA = "0xAAA120", Offset = "0xAA9520", VA = "0x180AAA120")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000AC7")]
		[Cpp2IlInjected.Address(RVA = "0x7722C80", Offset = "0x7722080", VA = "0x187722C80")]
		public EditImageRequestDTO()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000184")]
	[Utf8JsonSerializable]
	public class ChatRequestDTO
	{
		[Cpp2IlInjected.Token(Token = "0x1700047A")]
		public string Model
		{
			[Cpp2IlInjected.Token(Token = "0x6000AC8")]
			[Cpp2IlInjected.Address(RVA = "0xAA5FB0", Offset = "0xAA53B0", VA = "0x180AA5FB0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000AC9")]
			[Cpp2IlInjected.Address(RVA = "0xAA5FC0", Offset = "0xAA53C0", VA = "0x180AA5FC0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700047B")]
		public string Prompt
		{
			[Cpp2IlInjected.Token(Token = "0x6000ACA")]
			[Cpp2IlInjected.Address(RVA = "0xAAA880", Offset = "0xAA9C80", VA = "0x180AAA880")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000ACB")]
			[Cpp2IlInjected.Address(RVA = "0xAAA120", Offset = "0xAA9520", VA = "0x180AAA120")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000ACC")]
		[Cpp2IlInjected.Address(RVA = "0xAAC8E0", Offset = "0xAABCE0", VA = "0x180AAC8E0")]
		public ChatRequestDTO()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000185")]
	[Utf8JsonSerializable]
	public class ChatResponseDTO
	{
		[Cpp2IlInjected.Token(Token = "0x1700047C")]
		public List<string> AIResponse
		{
			[Cpp2IlInjected.Token(Token = "0x6000ACD")]
			[Cpp2IlInjected.Address(RVA = "0xAA5FB0", Offset = "0xAA53B0", VA = "0x180AA5FB0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000ACE")]
			[Cpp2IlInjected.Address(RVA = "0xAA5FC0", Offset = "0xAA53C0", VA = "0x180AA5FC0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700047D")]
		public decimal Cost
		{
			[Cpp2IlInjected.Token(Token = "0x6000ACF")]
			[Cpp2IlInjected.Address(RVA = "0xC66740", Offset = "0xC65B40", VA = "0x180C66740")]
			[CompilerGenerated]
			get
			{
				return default(decimal);
			}
			[Cpp2IlInjected.Token(Token = "0x6000AD0")]
			[Cpp2IlInjected.Address(RVA = "0xC66840", Offset = "0xC65C40", VA = "0x180C66840")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000AD1")]
		[Cpp2IlInjected.Address(RVA = "0xAAC8E0", Offset = "0xAABCE0", VA = "0x180AAC8E0")]
		public ChatResponseDTO()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000186")]
	[Utf8JsonSerializable]
	public class ChipPort
	{
		[Cpp2IlInjected.Token(Token = "0x1700047E")]
		public int Id
		{
			[Cpp2IlInjected.Token(Token = "0x6000AD2")]
			[Cpp2IlInjected.Address(RVA = "0xAA3110", Offset = "0xAA2510", VA = "0x180AA3110")]
			[CompilerGenerated]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x6000AD3")]
			[Cpp2IlInjected.Address(RVA = "0xAAB1D0", Offset = "0xAAA5D0", VA = "0x180AAB1D0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700047F")]
		public string Type
		{
			[Cpp2IlInjected.Token(Token = "0x6000AD4")]
			[Cpp2IlInjected.Address(RVA = "0xAAA880", Offset = "0xAA9C80", VA = "0x180AAA880")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000AD5")]
			[Cpp2IlInjected.Address(RVA = "0xAAA120", Offset = "0xAA9520", VA = "0x180AAA120")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000480")]
		public string? Name
		{
			[Cpp2IlInjected.Token(Token = "0x6000AD6")]
			[Cpp2IlInjected.Address(RVA = "0xAAB1C0", Offset = "0xAAA5C0", VA = "0x180AAB1C0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000AD7")]
			[Cpp2IlInjected.Address(RVA = "0xAA67C0", Offset = "0xAA5BC0", VA = "0x180AA67C0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000481")]
		public IReadOnlyList<int> Connections
		{
			[Cpp2IlInjected.Token(Token = "0x6000AD8")]
			[Cpp2IlInjected.Address(RVA = "0xAAA820", Offset = "0xAA9C20", VA = "0x180AAA820")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000AD9")]
			[Cpp2IlInjected.Address(RVA = "0xAA67D0", Offset = "0xAA5BD0", VA = "0x180AA67D0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000482")]
		public string? DefaultValue
		{
			[Cpp2IlInjected.Token(Token = "0x6000ADA")]
			[Cpp2IlInjected.Address(RVA = "0xAAA140", Offset = "0xAA9540", VA = "0x180AAA140")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000ADB")]
			[Cpp2IlInjected.Address(RVA = "0xAADB00", Offset = "0xAACF00", VA = "0x180AADB00")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000ADC")]
		[Cpp2IlInjected.Address(RVA = "0x7722970", Offset = "0x7721D70", VA = "0x187722970")]
		public ChipPort()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000187")]
	[Utf8JsonSerializable]
	public class Chip
	{
		[Cpp2IlInjected.Token(Token = "0x17000483")]
		public int Id
		{
			[Cpp2IlInjected.Token(Token = "0x6000ADD")]
			[Cpp2IlInjected.Address(RVA = "0xAA3110", Offset = "0xAA2510", VA = "0x180AA3110")]
			[CompilerGenerated]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x6000ADE")]
			[Cpp2IlInjected.Address(RVA = "0xAAB1D0", Offset = "0xAAA5D0", VA = "0x180AAB1D0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000484")]
		public Guid? Guid
		{
			[Cpp2IlInjected.Token(Token = "0x6000ADF")]
			[Cpp2IlInjected.Address(RVA = "0x2005CF0", Offset = "0x20050F0", VA = "0x182005CF0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000AE0")]
			[Cpp2IlInjected.Address(RVA = "0x2005D10", Offset = "0x2005110", VA = "0x182005D10")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000485")]
		public string Type
		{
			[Cpp2IlInjected.Token(Token = "0x6000AE1")]
			[Cpp2IlInjected.Address(RVA = "0xAAA820", Offset = "0xAA9C20", VA = "0x180AAA820")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000AE2")]
			[Cpp2IlInjected.Address(RVA = "0xAA67D0", Offset = "0xAA5BD0", VA = "0x180AA67D0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000486")]
		public List<ChipPort> Input
		{
			[Cpp2IlInjected.Token(Token = "0x6000AE3")]
			[Cpp2IlInjected.Address(RVA = "0xAAA140", Offset = "0xAA9540", VA = "0x180AAA140")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000AE4")]
			[Cpp2IlInjected.Address(RVA = "0xAADB00", Offset = "0xAACF00", VA = "0x180AADB00")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000487")]
		public List<ChipPort> Output
		{
			[Cpp2IlInjected.Token(Token = "0x6000AE5")]
			[Cpp2IlInjected.Address(RVA = "0xAAA030", Offset = "0xAA9430", VA = "0x180AAA030")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000AE6")]
			[Cpp2IlInjected.Address(RVA = "0xAAA110", Offset = "0xAA9510", VA = "0x180AAA110")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000488")]
		public string? Name
		{
			[Cpp2IlInjected.Token(Token = "0x6000AE7")]
			[Cpp2IlInjected.Address(RVA = "0xAAA810", Offset = "0xAA9C10", VA = "0x180AAA810")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000AE8")]
			[Cpp2IlInjected.Address(RVA = "0xAAA840", Offset = "0xAA9C40", VA = "0x180AAA840")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000489")]
		public string? DefaultValue
		{
			[Cpp2IlInjected.Token(Token = "0x6000AE9")]
			[Cpp2IlInjected.Address(RVA = "0xAAA160", Offset = "0xAA9560", VA = "0x180AAA160")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000AEA")]
			[Cpp2IlInjected.Address(RVA = "0xAAA870", Offset = "0xAA9C70", VA = "0x180AAA870")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700048A")]
		public string? Comment
		{
			[Cpp2IlInjected.Token(Token = "0x6000AEB")]
			[Cpp2IlInjected.Address(RVA = "0xAA3370", Offset = "0xAA2770", VA = "0x180AA3370")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000AEC")]
			[Cpp2IlInjected.Address(RVA = "0xAA3390", Offset = "0xAA2790", VA = "0x180AA3390")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000AED")]
		[Cpp2IlInjected.Address(RVA = "0x77229F0", Offset = "0x7721DF0", VA = "0x1877229F0")]
		public Chip()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000188")]
	[Utf8JsonSerializable]
	public class PortGroup
	{
		[Cpp2IlInjected.Token(Token = "0x1700048B")]
		public string Name
		{
			[Cpp2IlInjected.Token(Token = "0x6000AEE")]
			[Cpp2IlInjected.Address(RVA = "0xAA5FB0", Offset = "0xAA53B0", VA = "0x180AA5FB0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000AEF")]
			[Cpp2IlInjected.Address(RVA = "0xAA5FC0", Offset = "0xAA53C0", VA = "0x180AA5FC0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700048C")]
		public Chip Input
		{
			[Cpp2IlInjected.Token(Token = "0x6000AF0")]
			[Cpp2IlInjected.Address(RVA = "0xAAA880", Offset = "0xAA9C80", VA = "0x180AAA880")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000AF1")]
			[Cpp2IlInjected.Address(RVA = "0xAAA120", Offset = "0xAA9520", VA = "0x180AAA120")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700048D")]
		public Chip Output
		{
			[Cpp2IlInjected.Token(Token = "0x6000AF2")]
			[Cpp2IlInjected.Address(RVA = "0xAAB1C0", Offset = "0xAAA5C0", VA = "0x180AAB1C0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000AF3")]
			[Cpp2IlInjected.Address(RVA = "0xAA67C0", Offset = "0xAA5BC0", VA = "0x180AA67C0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700048E")]
		public string? Comment
		{
			[Cpp2IlInjected.Token(Token = "0x6000AF4")]
			[Cpp2IlInjected.Address(RVA = "0xAAA820", Offset = "0xAA9C20", VA = "0x180AAA820")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000AF5")]
			[Cpp2IlInjected.Address(RVA = "0xAA67D0", Offset = "0xAA5BD0", VA = "0x180AA67D0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000AF6")]
		[Cpp2IlInjected.Address(RVA = "0xAAC8E0", Offset = "0xAABCE0", VA = "0x180AAC8E0")]
		public PortGroup()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000189")]
	[Utf8JsonSerializable]
	public class CircuitBoard
	{
		[Cpp2IlInjected.Token(Token = "0x1700048F")]
		public string Name
		{
			[Cpp2IlInjected.Token(Token = "0x6000AF7")]
			[Cpp2IlInjected.Address(RVA = "0xAA5FB0", Offset = "0xAA53B0", VA = "0x180AA5FB0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000AF8")]
			[Cpp2IlInjected.Address(RVA = "0xAA5FC0", Offset = "0xAA53C0", VA = "0x180AA5FC0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000490")]
		public IReadOnlyList<Chip> Chips
		{
			[Cpp2IlInjected.Token(Token = "0x6000AF9")]
			[Cpp2IlInjected.Address(RVA = "0xAAA880", Offset = "0xAA9C80", VA = "0x180AAA880")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000AFA")]
			[Cpp2IlInjected.Address(RVA = "0xAAA120", Offset = "0xAA9520", VA = "0x180AAA120")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000491")]
		public IReadOnlyList<PortGroup> PortGroups
		{
			[Cpp2IlInjected.Token(Token = "0x6000AFB")]
			[Cpp2IlInjected.Address(RVA = "0xAAB1C0", Offset = "0xAAA5C0", VA = "0x180AAB1C0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000AFC")]
			[Cpp2IlInjected.Address(RVA = "0xAA67C0", Offset = "0xAA5BC0", VA = "0x180AA67C0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000492")]
		public IReadOnlyList<CircuitBoard> Functions
		{
			[Cpp2IlInjected.Token(Token = "0x6000AFD")]
			[Cpp2IlInjected.Address(RVA = "0xAAA820", Offset = "0xAA9C20", VA = "0x180AAA820")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000AFE")]
			[Cpp2IlInjected.Address(RVA = "0xAA67D0", Offset = "0xAA5BD0", VA = "0x180AA67D0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000493")]
		public string? Comment
		{
			[Cpp2IlInjected.Token(Token = "0x6000AFF")]
			[Cpp2IlInjected.Address(RVA = "0xAAA140", Offset = "0xAA9540", VA = "0x180AAA140")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000B00")]
			[Cpp2IlInjected.Address(RVA = "0xAADB00", Offset = "0xAACF00", VA = "0x180AADB00")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000B01")]
		[Cpp2IlInjected.Address(RVA = "0x7722AA0", Offset = "0x7721EA0", VA = "0x187722AA0")]
		public CircuitBoard()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200018A")]
	[Utf8JsonSerializable]
	public class CircuitObjectDefinitionSpawnableProperties
	{
		[Cpp2IlInjected.Token(Token = "0x400071F")]
		public const string IdTagPrefix = "REPL_";

		[Cpp2IlInjected.Token(Token = "0x17000494")]
		public string Id
		{
			[Cpp2IlInjected.Token(Token = "0x6000B02")]
			[Cpp2IlInjected.Address(RVA = "0xAA5FB0", Offset = "0xAA53B0", VA = "0x180AA5FB0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000B03")]
			[Cpp2IlInjected.Address(RVA = "0xAA5FC0", Offset = "0xAA53C0", VA = "0x180AA5FC0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000495")]
		public int MaxCount
		{
			[Cpp2IlInjected.Token(Token = "0x6000B04")]
			[Cpp2IlInjected.Address(RVA = "0xAAC980", Offset = "0xAABD80", VA = "0x180AAC980")]
			[CompilerGenerated]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x6000B05")]
			[Cpp2IlInjected.Address(RVA = "0xAB2F40", Offset = "0xAB2340", VA = "0x180AB2F40")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000B06")]
		[Cpp2IlInjected.Address(RVA = "0xAAC8E0", Offset = "0xAABCE0", VA = "0x180AAC8E0")]
		public CircuitObjectDefinitionSpawnableProperties()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200018B")]
	[Utf8JsonSerializable]
	public class CircuitObjectDefinition
	{
		[Cpp2IlInjected.Token(Token = "0x17000496")]
		public int? Key
		{
			[Cpp2IlInjected.Token(Token = "0x6000B07")]
			[Cpp2IlInjected.Address(RVA = "0xAA5FB0", Offset = "0xAA53B0", VA = "0x180AA5FB0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000B08")]
			[Cpp2IlInjected.Address(RVA = "0xB96550", Offset = "0xB95950", VA = "0x180B96550")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000497")]
		public string? CodeGenId
		{
			[Cpp2IlInjected.Token(Token = "0x6000B09")]
			[Cpp2IlInjected.Address(RVA = "0xAAA880", Offset = "0xAA9C80", VA = "0x180AAA880")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000B0A")]
			[Cpp2IlInjected.Address(RVA = "0xAAA120", Offset = "0xAA9520", VA = "0x180AAA120")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000498")]
		public string Name
		{
			[Cpp2IlInjected.Token(Token = "0x6000B0B")]
			[Cpp2IlInjected.Address(RVA = "0xAAB1C0", Offset = "0xAAA5C0", VA = "0x180AAB1C0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000B0C")]
			[Cpp2IlInjected.Address(RVA = "0xAA67C0", Offset = "0xAA5BC0", VA = "0x180AA67C0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000499")]
		public string Type
		{
			[Cpp2IlInjected.Token(Token = "0x6000B0D")]
			[Cpp2IlInjected.Address(RVA = "0xAAA820", Offset = "0xAA9C20", VA = "0x180AAA820")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000B0E")]
			[Cpp2IlInjected.Address(RVA = "0xAA67D0", Offset = "0xAA5BD0", VA = "0x180AA67D0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700049A")]
		public List<CircuitObjectDefinition>? Children
		{
			[Cpp2IlInjected.Token(Token = "0x6000B0F")]
			[Cpp2IlInjected.Address(RVA = "0xAAA140", Offset = "0xAA9540", VA = "0x180AAA140")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000B10")]
			[Cpp2IlInjected.Address(RVA = "0xAADB00", Offset = "0xAACF00", VA = "0x180AADB00")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700049B")]
		public CircuitObjectDefinitionSpawnableProperties? SpawnableProperties
		{
			[Cpp2IlInjected.Token(Token = "0x6000B11")]
			[Cpp2IlInjected.Address(RVA = "0xAAA030", Offset = "0xAA9430", VA = "0x180AAA030")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000B12")]
			[Cpp2IlInjected.Address(RVA = "0xAAA110", Offset = "0xAA9510", VA = "0x180AAA110")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000B13")]
		[Cpp2IlInjected.Address(RVA = "0xAAC8E0", Offset = "0xAABCE0", VA = "0x180AAC8E0")]
		public CircuitObjectDefinition()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200018C")]
	[Utf8JsonSerializable]
	public class CircuitObjectEvent
	{
		[Cpp2IlInjected.Token(Token = "0x1700049C")]
		public string BaseEventGuid
		{
			[Cpp2IlInjected.Token(Token = "0x6000B14")]
			[Cpp2IlInjected.Address(RVA = "0xAA5FB0", Offset = "0xAA53B0", VA = "0x180AA5FB0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000B15")]
			[Cpp2IlInjected.Address(RVA = "0xAA5FC0", Offset = "0xAA53C0", VA = "0x180AA5FC0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700049D")]
		public string Path
		{
			[Cpp2IlInjected.Token(Token = "0x6000B16")]
			[Cpp2IlInjected.Address(RVA = "0xAAA880", Offset = "0xAA9C80", VA = "0x180AAA880")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000B17")]
			[Cpp2IlInjected.Address(RVA = "0xAAA120", Offset = "0xAA9520", VA = "0x180AAA120")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000B18")]
		[Cpp2IlInjected.Address(RVA = "0xAAC8E0", Offset = "0xAABCE0", VA = "0x180AAC8E0")]
		public CircuitObjectEvent()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200018D")]
	[Utf8JsonSerializable]
	public class GeneratedCircuitBoardDTO
	{
		[Cpp2IlInjected.Token(Token = "0x1700049E")]
		public string Id
		{
			[Cpp2IlInjected.Token(Token = "0x6000B19")]
			[Cpp2IlInjected.Address(RVA = "0xAA5FB0", Offset = "0xAA53B0", VA = "0x180AA5FB0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000B1A")]
			[Cpp2IlInjected.Address(RVA = "0xAA5FC0", Offset = "0xAA53C0", VA = "0x180AA5FC0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700049F")]
		public CircuitBoard CircuitBoard
		{
			[Cpp2IlInjected.Token(Token = "0x6000B1B")]
			[Cpp2IlInjected.Address(RVA = "0xAAA880", Offset = "0xAA9C80", VA = "0x180AAA880")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000B1C")]
			[Cpp2IlInjected.Address(RVA = "0xAAA120", Offset = "0xAA9520", VA = "0x180AAA120")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170004A0")]
		public CircuitObjectDefinition? ObjectDefinition
		{
			[Cpp2IlInjected.Token(Token = "0x6000B1D")]
			[Cpp2IlInjected.Address(RVA = "0xAAB1C0", Offset = "0xAAA5C0", VA = "0x180AAB1C0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000B1E")]
			[Cpp2IlInjected.Address(RVA = "0xAA67C0", Offset = "0xAA5BC0", VA = "0x180AA67C0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170004A1")]
		public List<CircuitObjectDefinition>? SceneObjectDefinitions
		{
			[Cpp2IlInjected.Token(Token = "0x6000B1F")]
			[Cpp2IlInjected.Address(RVA = "0xAAA820", Offset = "0xAA9C20", VA = "0x180AAA820")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000B20")]
			[Cpp2IlInjected.Address(RVA = "0xAA67D0", Offset = "0xAA5BD0", VA = "0x180AA67D0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170004A2")]
		public IReadOnlyList<Chip> EventDefinitions
		{
			[Cpp2IlInjected.Token(Token = "0x6000B21")]
			[Cpp2IlInjected.Address(RVA = "0xAAA140", Offset = "0xAA9540", VA = "0x180AAA140")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000B22")]
			[Cpp2IlInjected.Address(RVA = "0xAADB00", Offset = "0xAACF00", VA = "0x180AADB00")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170004A3")]
		public IReadOnlyList<CircuitObjectEvent> ObjectEvents
		{
			[Cpp2IlInjected.Token(Token = "0x6000B23")]
			[Cpp2IlInjected.Address(RVA = "0xAAA030", Offset = "0xAA9430", VA = "0x180AAA030")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000B24")]
			[Cpp2IlInjected.Address(RVA = "0xAAA110", Offset = "0xAA9510", VA = "0x180AAA110")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170004A4")]
		public string? Code
		{
			[Cpp2IlInjected.Token(Token = "0x6000B25")]
			[Cpp2IlInjected.Address(RVA = "0xAAA810", Offset = "0xAA9C10", VA = "0x180AAA810")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000B26")]
			[Cpp2IlInjected.Address(RVA = "0xAAA840", Offset = "0xAA9C40", VA = "0x180AAA840")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000B27")]
		[Cpp2IlInjected.Address(RVA = "0x7722E20", Offset = "0x7722220", VA = "0x187722E20")]
		public GeneratedCircuitBoardDTO()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200018E")]
	[Utf8JsonSerializable]
	public class GenerateCircuitsResponseDTO : DURPPUIUDDT
	{
		[Cpp2IlInjected.Token(Token = "0x170004A5")]
		public RecNetResultObject<GeneratedCircuitBoardDTO> Result
		{
			[Cpp2IlInjected.Token(Token = "0x6000B28")]
			[Cpp2IlInjected.Address(RVA = "0xAA5FB0", Offset = "0xAA53B0", VA = "0x180AA5FB0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000B29")]
			[Cpp2IlInjected.Address(RVA = "0xAA5FC0", Offset = "0xAA53C0", VA = "0x180AA5FC0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170004A6")]
		public decimal CodeGenerationCost
		{
			[Cpp2IlInjected.Token(Token = "0x6000B2A")]
			[Cpp2IlInjected.Address(RVA = "0xC66740", Offset = "0xC65B40", VA = "0x180C66740")]
			[CompilerGenerated]
			get
			{
				return default(decimal);
			}
			[Cpp2IlInjected.Token(Token = "0x6000B2B")]
			[Cpp2IlInjected.Address(RVA = "0xC66840", Offset = "0xC65C40", VA = "0x180C66840")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000B2C")]
		[Cpp2IlInjected.Address(RVA = "0x7722CD0", Offset = "0x77220D0", VA = "0x187722CD0", Slot = "4")]
		public Task NLICNVNCYRU()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000B2D")]
		[Cpp2IlInjected.Address(RVA = "0xAAC8E0", Offset = "0xAABCE0", VA = "0x180AAC8E0")]
		public GenerateCircuitsResponseDTO()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200018F")]
	public enum AIBalanceStatus
	{
		[Cpp2IlInjected.Token(Token = "0x4000734")]
		Empty,
		[Cpp2IlInjected.Token(Token = "0x4000735")]
		Low,
		[Cpp2IlInjected.Token(Token = "0x4000736")]
		Good
	}
	[Cpp2IlInjected.Token(Token = "0x2000190")]
	[Utf8JsonSerializable]
	public class MakerAITimeBalanceStatusUpdatePushNotification
	{
		[Cpp2IlInjected.Token(Token = "0x170004A7")]
		public AIBalanceStatus TimeBalanceStatus
		{
			[Cpp2IlInjected.Token(Token = "0x6000B2E")]
			[Cpp2IlInjected.Address(RVA = "0xAA3110", Offset = "0xAA2510", VA = "0x180AA3110")]
			[CompilerGenerated]
			get
			{
				return default(AIBalanceStatus);
			}
			[Cpp2IlInjected.Token(Token = "0x6000B2F")]
			[Cpp2IlInjected.Address(RVA = "0xAAB1D0", Offset = "0xAAA5D0", VA = "0x180AAB1D0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170004A8")]
		public DateTime TimeExpiresAt
		{
			[Cpp2IlInjected.Token(Token = "0x6000B30")]
			[Cpp2IlInjected.Address(RVA = "0xAAA880", Offset = "0xAA9C80", VA = "0x180AAA880")]
			[CompilerGenerated]
			get
			{
				return default(DateTime);
			}
			[Cpp2IlInjected.Token(Token = "0x6000B31")]
			[Cpp2IlInjected.Address(RVA = "0x10BA780", Offset = "0x10B9B80", VA = "0x1810BA780")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000B32")]
		[Cpp2IlInjected.Address(RVA = "0xAAC8E0", Offset = "0xAABCE0", VA = "0x180AAC8E0")]
		public MakerAITimeBalanceStatusUpdatePushNotification()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000191")]
	[Utf8JsonSerializable]
	public class MakerAIUsageBalanceStatusUpdatePushNotification
	{
		[Cpp2IlInjected.Token(Token = "0x170004A9")]
		public AIBalanceStatus UsageBalanceStatus
		{
			[Cpp2IlInjected.Token(Token = "0x6000B33")]
			[Cpp2IlInjected.Address(RVA = "0xAA3110", Offset = "0xAA2510", VA = "0x180AA3110")]
			[CompilerGenerated]
			get
			{
				return default(AIBalanceStatus);
			}
			[Cpp2IlInjected.Token(Token = "0x6000B34")]
			[Cpp2IlInjected.Address(RVA = "0xAAB1D0", Offset = "0xAAA5D0", VA = "0x180AAB1D0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170004AA")]
		public float UsagePercent
		{
			[Cpp2IlInjected.Token(Token = "0x6000B35")]
			[Cpp2IlInjected.Address(RVA = "0xBC0B50", Offset = "0xBBFF50", VA = "0x180BC0B50")]
			[CompilerGenerated]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x6000B36")]
			[Cpp2IlInjected.Address(RVA = "0xBC04D0", Offset = "0xBBF8D0", VA = "0x180BC04D0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000B37")]
		[Cpp2IlInjected.Address(RVA = "0xAAC8E0", Offset = "0xAABCE0", VA = "0x180AAC8E0")]
		public MakerAIUsageBalanceStatusUpdatePushNotification()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000192")]
	[Utf8JsonSerializable]
	public class MakerAIBalancesDTO
	{
		[Cpp2IlInjected.Token(Token = "0x170004AB")]
		public AIBalanceStatus TimeBalanceStatus
		{
			[Cpp2IlInjected.Token(Token = "0x6000B38")]
			[Cpp2IlInjected.Address(RVA = "0xAA3110", Offset = "0xAA2510", VA = "0x180AA3110")]
			[CompilerGenerated]
			get
			{
				return default(AIBalanceStatus);
			}
			[Cpp2IlInjected.Token(Token = "0x6000B39")]
			[Cpp2IlInjected.Address(RVA = "0xAAB1D0", Offset = "0xAAA5D0", VA = "0x180AAB1D0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170004AC")]
		public DateTime TimeExpiresAt
		{
			[Cpp2IlInjected.Token(Token = "0x6000B3A")]
			[Cpp2IlInjected.Address(RVA = "0xAAA880", Offset = "0xAA9C80", VA = "0x180AAA880")]
			[CompilerGenerated]
			get
			{
				return default(DateTime);
			}
			[Cpp2IlInjected.Token(Token = "0x6000B3B")]
			[Cpp2IlInjected.Address(RVA = "0x10BA780", Offset = "0x10B9B80", VA = "0x1810BA780")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170004AD")]
		public AIBalanceStatus UsageBalanceStatus
		{
			[Cpp2IlInjected.Token(Token = "0x6000B3C")]
			[Cpp2IlInjected.Address(RVA = "0xAB5660", Offset = "0xAB4A60", VA = "0x180AB5660")]
			[CompilerGenerated]
			get
			{
				return default(AIBalanceStatus);
			}
			[Cpp2IlInjected.Token(Token = "0x6000B3D")]
			[Cpp2IlInjected.Address(RVA = "0xB07AB0", Offset = "0xB06EB0", VA = "0x180B07AB0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170004AE")]
		public float UsagePercent
		{
			[Cpp2IlInjected.Token(Token = "0x6000B3E")]
			[Cpp2IlInjected.Address(RVA = "0xB07AC0", Offset = "0xB06EC0", VA = "0x180B07AC0")]
			[CompilerGenerated]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x6000B3F")]
			[Cpp2IlInjected.Address(RVA = "0xB07770", Offset = "0xB06B70", VA = "0x180B07770")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170004AF")]
		public AIBalanceStatus RRPlusUsageBalanceStatus
		{
			[Cpp2IlInjected.Token(Token = "0x6000B40")]
			[Cpp2IlInjected.Address(RVA = "0xAAB1A0", Offset = "0xAAA5A0", VA = "0x180AAB1A0")]
			[CompilerGenerated]
			get
			{
				return default(AIBalanceStatus);
			}
			[Cpp2IlInjected.Token(Token = "0x6000B41")]
			[Cpp2IlInjected.Address(RVA = "0xAAB1B0", Offset = "0xAAA5B0", VA = "0x180AAB1B0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170004B0")]
		public float RRPlusUsagePercent
		{
			[Cpp2IlInjected.Token(Token = "0x6000B42")]
			[Cpp2IlInjected.Address(RVA = "0xB781D0", Offset = "0xB775D0", VA = "0x180B781D0")]
			[CompilerGenerated]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x6000B43")]
			[Cpp2IlInjected.Address(RVA = "0xBAF510", Offset = "0xBAE910", VA = "0x180BAF510")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000B44")]
		[Cpp2IlInjected.Address(RVA = "0xAAC8E0", Offset = "0xAABCE0", VA = "0x180AAC8E0")]
		public MakerAIBalancesDTO()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000193")]
	[Utf8JsonSerializable]
	public class MakerAIFreeTrialConfigDTO
	{
		[Cpp2IlInjected.Token(Token = "0x170004B1")]
		public TimeSpan Cooldown
		{
			[Cpp2IlInjected.Token(Token = "0x6000B45")]
			[Cpp2IlInjected.Address(RVA = "0xAA5FB0", Offset = "0xAA53B0", VA = "0x180AA5FB0")]
			[CompilerGenerated]
			get
			{
				return default(TimeSpan);
			}
			[Cpp2IlInjected.Token(Token = "0x6000B46")]
			[Cpp2IlInjected.Address(RVA = "0xB96550", Offset = "0xB95950", VA = "0x180B96550")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170004B2")]
		public TimeSpan Duration
		{
			[Cpp2IlInjected.Token(Token = "0x6000B47")]
			[Cpp2IlInjected.Address(RVA = "0xAAA880", Offset = "0xAA9C80", VA = "0x180AAA880")]
			[CompilerGenerated]
			get
			{
				return default(TimeSpan);
			}
			[Cpp2IlInjected.Token(Token = "0x6000B48")]
			[Cpp2IlInjected.Address(RVA = "0x10BA780", Offset = "0x10B9B80", VA = "0x1810BA780")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000B49")]
		[Cpp2IlInjected.Address(RVA = "0xAAC8E0", Offset = "0xAABCE0", VA = "0x180AAC8E0")]
		public MakerAIFreeTrialConfigDTO()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000194")]
	[Utf8JsonSerializable]
	public class SearchRoomsResponseDTO
	{
		[Cpp2IlInjected.Token(Token = "0x170004B3")]
		public List<string> Value
		{
			[Cpp2IlInjected.Token(Token = "0x6000B4A")]
			[Cpp2IlInjected.Address(RVA = "0xAA5FB0", Offset = "0xAA53B0", VA = "0x180AA5FB0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000B4B")]
			[Cpp2IlInjected.Address(RVA = "0xAA5FC0", Offset = "0xAA53C0", VA = "0x180AA5FC0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000B4C")]
		[Cpp2IlInjected.Address(RVA = "0xAAC8E0", Offset = "0xAABCE0", VA = "0x180AAC8E0")]
		public SearchRoomsResponseDTO()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000195")]
	[Utf8JsonSerializable]
	public class GenerateSpeechRequestDTO
	{
		[Cpp2IlInjected.Token(Token = "0x170004B4")]
		public string? Model
		{
			[Cpp2IlInjected.Token(Token = "0x6000B4D")]
			[Cpp2IlInjected.Address(RVA = "0xAA5FB0", Offset = "0xAA53B0", VA = "0x180AA5FB0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000B4E")]
			[Cpp2IlInjected.Address(RVA = "0xAA5FC0", Offset = "0xAA53C0", VA = "0x180AA5FC0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170004B5")]
		public string Input
		{
			[Cpp2IlInjected.Token(Token = "0x6000B4F")]
			[Cpp2IlInjected.Address(RVA = "0xAAA880", Offset = "0xAA9C80", VA = "0x180AAA880")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000B50")]
			[Cpp2IlInjected.Address(RVA = "0xAAA120", Offset = "0xAA9520", VA = "0x180AAA120")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170004B6")]
		public string Voice
		{
			[Cpp2IlInjected.Token(Token = "0x6000B51")]
			[Cpp2IlInjected.Address(RVA = "0xAAB1C0", Offset = "0xAAA5C0", VA = "0x180AAB1C0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000B52")]
			[Cpp2IlInjected.Address(RVA = "0xAA67C0", Offset = "0xAA5BC0", VA = "0x180AA67C0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170004B7")]
		public string ResponseFormat
		{
			[Cpp2IlInjected.Token(Token = "0x6000B53")]
			[Cpp2IlInjected.Address(RVA = "0xAAA820", Offset = "0xAA9C20", VA = "0x180AAA820")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000B54")]
			[Cpp2IlInjected.Address(RVA = "0xAA67D0", Offset = "0xAA5BD0", VA = "0x180AA67D0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170004B8")]
		public string? Instructions
		{
			[Cpp2IlInjected.Token(Token = "0x6000B55")]
			[Cpp2IlInjected.Address(RVA = "0xAAA140", Offset = "0xAA9540", VA = "0x180AAA140")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000B56")]
			[Cpp2IlInjected.Address(RVA = "0xAADB00", Offset = "0xAACF00", VA = "0x180AADB00")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000B57")]
		[Cpp2IlInjected.Address(RVA = "0x7722DD0", Offset = "0x77221D0", VA = "0x187722DD0")]
		public GenerateSpeechRequestDTO()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000196")]
	[Utf8JsonSerializable]
	public class GameAIRoomSpendSummaryDTO
	{
		[Cpp2IlInjected.Token(Token = "0x170004B9")]
		public RecNetResult GameAIStatus
		{
			[Cpp2IlInjected.Token(Token = "0x6000B58")]
			[Cpp2IlInjected.Address(RVA = "0xAA5FB0", Offset = "0xAA53B0", VA = "0x180AA5FB0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000B59")]
			[Cpp2IlInjected.Address(RVA = "0xAA5FC0", Offset = "0xAA53C0", VA = "0x180AA5FC0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170004BA")]
		public AIBalanceStatus PromoBalanceStatus
		{
			[Cpp2IlInjected.Token(Token = "0x6000B5A")]
			[Cpp2IlInjected.Address(RVA = "0xAAC980", Offset = "0xAABD80", VA = "0x180AAC980")]
			[CompilerGenerated]
			get
			{
				return default(AIBalanceStatus);
			}
			[Cpp2IlInjected.Token(Token = "0x6000B5B")]
			[Cpp2IlInjected.Address(RVA = "0xAB2F40", Offset = "0xAB2340", VA = "0x180AB2F40")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170004BB")]
		public long? AmountSpent
		{
			[Cpp2IlInjected.Token(Token = "0x6000B5C")]
			[Cpp2IlInjected.Address(RVA = "0xBB85E0", Offset = "0xBB79E0", VA = "0x180BB85E0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000B5D")]
			[Cpp2IlInjected.Address(RVA = "0xC99FF0", Offset = "0xC993F0", VA = "0x180C99FF0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170004BC")]
		public DateTime? AmountSpentSince
		{
			[Cpp2IlInjected.Token(Token = "0x6000B5E")]
			[Cpp2IlInjected.Address(RVA = "0xC5CFF0", Offset = "0xC5C3F0", VA = "0x180C5CFF0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000B5F")]
			[Cpp2IlInjected.Address(RVA = "0xC5D250", Offset = "0xC5C650", VA = "0x180C5D250")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170004BD")]
		public long? AvailableBalance
		{
			[Cpp2IlInjected.Token(Token = "0x6000B60")]
			[Cpp2IlInjected.Address(RVA = "0xD8F2E0", Offset = "0xD8E6E0", VA = "0x180D8F2E0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000B61")]
			[Cpp2IlInjected.Address(RVA = "0xD8F190", Offset = "0xD8E590", VA = "0x180D8F190")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000B62")]
		[Cpp2IlInjected.Address(RVA = "0xAAC8E0", Offset = "0xAABCE0", VA = "0x180AAC8E0")]
		public GameAIRoomSpendSummaryDTO()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000197")]
	[Utf8JsonSerializable]
	public class GameAIPromoBalanceDTO
	{
		[Cpp2IlInjected.Token(Token = "0x170004BE")]
		public int AvailableDevCreditPacks
		{
			[Cpp2IlInjected.Token(Token = "0x6000B63")]
			[Cpp2IlInjected.Address(RVA = "0xAA3110", Offset = "0xAA2510", VA = "0x180AA3110")]
			[CompilerGenerated]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x6000B64")]
			[Cpp2IlInjected.Address(RVA = "0xAAB1D0", Offset = "0xAAA5D0", VA = "0x180AAB1D0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170004BF")]
		public DateTime? NextDevCreditPackGrantDate
		{
			[Cpp2IlInjected.Token(Token = "0x6000B65")]
			[Cpp2IlInjected.Address(RVA = "0xC66740", Offset = "0xC65B40", VA = "0x180C66740")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000B66")]
			[Cpp2IlInjected.Address(RVA = "0xC66840", Offset = "0xC65C40", VA = "0x180C66840")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000B67")]
		[Cpp2IlInjected.Address(RVA = "0xAAC8E0", Offset = "0xAABCE0", VA = "0x180AAC8E0")]
		public GameAIPromoBalanceDTO()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000198")]
	[Utf8JsonSerializable]
	public class ConversationDTO
	{
		[Cpp2IlInjected.Token(Token = "0x170004C0")]
		public List<ConversationMessageDTO> ConversationItems
		{
			[Cpp2IlInjected.Token(Token = "0x6000B68")]
			[Cpp2IlInjected.Address(RVA = "0xAA5FB0", Offset = "0xAA53B0", VA = "0x180AA5FB0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000B69")]
			[Cpp2IlInjected.Address(RVA = "0xAA5FC0", Offset = "0xAA53C0", VA = "0x180AA5FC0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000B6A")]
		[Cpp2IlInjected.Address(RVA = "0xAAC8E0", Offset = "0xAABCE0", VA = "0x180AAC8E0")]
		public ConversationDTO()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000199")]
	[Utf8JsonSerializable]
	public class ConversationMessageDTO
	{
		[Cpp2IlInjected.Token(Token = "0x170004C1")]
		public string Conversation
		{
			[Cpp2IlInjected.Token(Token = "0x6000B6B")]
			[Cpp2IlInjected.Address(RVA = "0xAA5FB0", Offset = "0xAA53B0", VA = "0x180AA5FB0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000B6C")]
			[Cpp2IlInjected.Address(RVA = "0xAA5FC0", Offset = "0xAA53C0", VA = "0x180AA5FC0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000B6D")]
		[Cpp2IlInjected.Address(RVA = "0x1198280", Offset = "0x1197680", VA = "0x181198280")]
		public ConversationMessageDTO()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200019A")]
	[Utf8JsonSerializable]
	public class RoomieUserFactsDTO
	{
		[Cpp2IlInjected.Token(Token = "0x170004C2")]
		public List<UserFactDTO> UserFacts
		{
			[Cpp2IlInjected.Token(Token = "0x6000B6E")]
			[Cpp2IlInjected.Address(RVA = "0xAA5FB0", Offset = "0xAA53B0", VA = "0x180AA5FB0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000B6F")]
			[Cpp2IlInjected.Address(RVA = "0xAA5FC0", Offset = "0xAA53C0", VA = "0x180AA5FC0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170004C3")]
		public string UserContext
		{
			[Cpp2IlInjected.Token(Token = "0x6000B70")]
			[Cpp2IlInjected.Address(RVA = "0xAAA880", Offset = "0xAA9C80", VA = "0x180AAA880")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000B71")]
			[Cpp2IlInjected.Address(RVA = "0xAAA120", Offset = "0xAA9520", VA = "0x180AAA120")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000B72")]
		[Cpp2IlInjected.Address(RVA = "0x22D6FD0", Offset = "0x22D63D0", VA = "0x1822D6FD0")]
		public RoomieUserFactsDTO()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200019B")]
	[Utf8JsonSerializable]
	public class UserFactDTO
	{
		[Cpp2IlInjected.Token(Token = "0x170004C4")]
		public string Id
		{
			[Cpp2IlInjected.Token(Token = "0x6000B74")]
			[Cpp2IlInjected.Address(RVA = "0xAA5FB0", Offset = "0xAA53B0", VA = "0x180AA5FB0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000B75")]
			[Cpp2IlInjected.Address(RVA = "0xAA5FC0", Offset = "0xAA53C0", VA = "0x180AA5FC0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170004C5")]
		public string Predicate
		{
			[Cpp2IlInjected.Token(Token = "0x6000B76")]
			[Cpp2IlInjected.Address(RVA = "0xAAA880", Offset = "0xAA9C80", VA = "0x180AAA880")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000B77")]
			[Cpp2IlInjected.Address(RVA = "0xAAA120", Offset = "0xAA9520", VA = "0x180AAA120")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170004C6")]
		public string Object
		{
			[Cpp2IlInjected.Token(Token = "0x6000B78")]
			[Cpp2IlInjected.Address(RVA = "0xAAB1C0", Offset = "0xAAA5C0", VA = "0x180AAB1C0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000B79")]
			[Cpp2IlInjected.Address(RVA = "0xAA67C0", Offset = "0xAA5BC0", VA = "0x180AA67C0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170004C7")]
		public string Emotion
		{
			[Cpp2IlInjected.Token(Token = "0x6000B7A")]
			[Cpp2IlInjected.Address(RVA = "0xAAA820", Offset = "0xAA9C20", VA = "0x180AAA820")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000B7B")]
			[Cpp2IlInjected.Address(RVA = "0xAA67D0", Offset = "0xAA5BD0", VA = "0x180AA67D0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170004C8")]
		public DateTime CreatedAt
		{
			[Cpp2IlInjected.Token(Token = "0x6000B7C")]
			[Cpp2IlInjected.Address(RVA = "0xAAA140", Offset = "0xAA9540", VA = "0x180AAA140")]
			[CompilerGenerated]
			get
			{
				return default(DateTime);
			}
			[Cpp2IlInjected.Token(Token = "0x6000B7D")]
			[Cpp2IlInjected.Address(RVA = "0xAAA860", Offset = "0xAA9C60", VA = "0x180AAA860")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000B73")]
		[Cpp2IlInjected.Address(RVA = "0xAA6010", Offset = "0xAA5410", VA = "0x180AA6010")]
		public UserFactDTO(string id)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200019C")]
	public enum ConversationMessageRole
	{
		[Cpp2IlInjected.Token(Token = "0x400075A")]
		User,
		[Cpp2IlInjected.Token(Token = "0x400075B")]
		System,
		[Cpp2IlInjected.Token(Token = "0x400075C")]
		AI
	}
	[Cpp2IlInjected.Token(Token = "0x200019D")]
	[Utf8JsonSerializable]
	public class AddMessageToConversationRequestDTO
	{
		[Cpp2IlInjected.Token(Token = "0x170004C9")]
		public string ConversationId
		{
			[Cpp2IlInjected.Token(Token = "0x6000B7E")]
			[Cpp2IlInjected.Address(RVA = "0xAA5FB0", Offset = "0xAA53B0", VA = "0x180AA5FB0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000B7F")]
			[Cpp2IlInjected.Address(RVA = "0xAA5FC0", Offset = "0xAA53C0", VA = "0x180AA5FC0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170004CA")]
		public ConversationMessageRole Role
		{
			[Cpp2IlInjected.Token(Token = "0x6000B80")]
			[Cpp2IlInjected.Address(RVA = "0xAAC980", Offset = "0xAABD80", VA = "0x180AAC980")]
			[CompilerGenerated]
			get
			{
				return default(ConversationMessageRole);
			}
			[Cpp2IlInjected.Token(Token = "0x6000B81")]
			[Cpp2IlInjected.Address(RVA = "0xAB2F40", Offset = "0xAB2340", VA = "0x180AB2F40")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170004CB")]
		public string Text
		{
			[Cpp2IlInjected.Token(Token = "0x6000B82")]
			[Cpp2IlInjected.Address(RVA = "0xAAB1C0", Offset = "0xAAA5C0", VA = "0x180AAB1C0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000B83")]
			[Cpp2IlInjected.Address(RVA = "0xAA67C0", Offset = "0xAA5BC0", VA = "0x180AA67C0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000B84")]
		[Cpp2IlInjected.Address(RVA = "0xAAC8E0", Offset = "0xAABCE0", VA = "0x180AAC8E0")]
		public AddMessageToConversationRequestDTO()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200019E")]
	[Utf8JsonSerializable]
	public class AddToolCallResponseToConversationRequestDTO
	{
		[Cpp2IlInjected.Token(Token = "0x170004CC")]
		public string ConversationId
		{
			[Cpp2IlInjected.Token(Token = "0x6000B85")]
			[Cpp2IlInjected.Address(RVA = "0xAA5FB0", Offset = "0xAA53B0", VA = "0x180AA5FB0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000B86")]
			[Cpp2IlInjected.Address(RVA = "0xAA5FC0", Offset = "0xAA53C0", VA = "0x180AA5FC0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170004CD")]
		public string ToolCallId
		{
			[Cpp2IlInjected.Token(Token = "0x6000B87")]
			[Cpp2IlInjected.Address(RVA = "0xAAA880", Offset = "0xAA9C80", VA = "0x180AAA880")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000B88")]
			[Cpp2IlInjected.Address(RVA = "0xAAA120", Offset = "0xAA9520", VA = "0x180AAA120")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170004CE")]
		public string Response
		{
			[Cpp2IlInjected.Token(Token = "0x6000B89")]
			[Cpp2IlInjected.Address(RVA = "0xAAB1C0", Offset = "0xAAA5C0", VA = "0x180AAB1C0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000B8A")]
			[Cpp2IlInjected.Address(RVA = "0xAA67C0", Offset = "0xAA5BC0", VA = "0x180AA67C0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000B8B")]
		[Cpp2IlInjected.Address(RVA = "0xAAC8E0", Offset = "0xAABCE0", VA = "0x180AAC8E0")]
		public AddToolCallResponseToConversationRequestDTO()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200019F")]
	public enum ToolChoice
	{
		[Cpp2IlInjected.Token(Token = "0x4000764")]
		Auto,
		[Cpp2IlInjected.Token(Token = "0x4000765")]
		None,
		[Cpp2IlInjected.Token(Token = "0x4000766")]
		Required,
		[Cpp2IlInjected.Token(Token = "0x4000767")]
		Forced
	}
	[Cpp2IlInjected.Token(Token = "0x20001A0")]
	[Utf8JsonSerializable]
	public class NamedSchemaDTO
	{
		[Cpp2IlInjected.Token(Token = "0x170004CF")]
		public string Name
		{
			[Cpp2IlInjected.Token(Token = "0x6000B8C")]
			[Cpp2IlInjected.Address(RVA = "0xAA5FB0", Offset = "0xAA53B0", VA = "0x180AA5FB0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000B8D")]
			[Cpp2IlInjected.Address(RVA = "0xAA5FC0", Offset = "0xAA53C0", VA = "0x180AA5FC0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170004D0")]
		public string Schema
		{
			[Cpp2IlInjected.Token(Token = "0x6000B8E")]
			[Cpp2IlInjected.Address(RVA = "0xAAA880", Offset = "0xAA9C80", VA = "0x180AAA880")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000B8F")]
			[Cpp2IlInjected.Address(RVA = "0xAAA120", Offset = "0xAA9520", VA = "0x180AAA120")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170004D1")]
		public string? Description
		{
			[Cpp2IlInjected.Token(Token = "0x6000B90")]
			[Cpp2IlInjected.Address(RVA = "0xAAB1C0", Offset = "0xAAA5C0", VA = "0x180AAB1C0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000B91")]
			[Cpp2IlInjected.Address(RVA = "0xAA67C0", Offset = "0xAA5BC0", VA = "0x180AA67C0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000B92")]
		[Cpp2IlInjected.Address(RVA = "0xAAC8E0", Offset = "0xAABCE0", VA = "0x180AAC8E0")]
		public NamedSchemaDTO()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20001A1")]
	[Utf8JsonSerializable]
	public class GenerateConversationResponseRequestDTO
	{
		[Cpp2IlInjected.Token(Token = "0x170004D2")]
		public string ConversationId
		{
			[Cpp2IlInjected.Token(Token = "0x6000B93")]
			[Cpp2IlInjected.Address(RVA = "0xAA5FB0", Offset = "0xAA53B0", VA = "0x180AA5FB0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000B94")]
			[Cpp2IlInjected.Address(RVA = "0xAA5FC0", Offset = "0xAA53C0", VA = "0x180AA5FC0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170004D3")]
		public string? Model
		{
			[Cpp2IlInjected.Token(Token = "0x6000B95")]
			[Cpp2IlInjected.Address(RVA = "0xAAA880", Offset = "0xAA9C80", VA = "0x180AAA880")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000B96")]
			[Cpp2IlInjected.Address(RVA = "0xAAA120", Offset = "0xAA9520", VA = "0x180AAA120")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170004D4")]
		public float? Temperature
		{
			[Cpp2IlInjected.Token(Token = "0x6000B97")]
			[Cpp2IlInjected.Address(RVA = "0xAAB1C0", Offset = "0xAAA5C0", VA = "0x180AAB1C0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000B98")]
			[Cpp2IlInjected.Address(RVA = "0xB30430", Offset = "0xB2F830", VA = "0x180B30430")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170004D5")]
		public NamedSchemaDTO? ResponseFormat
		{
			[Cpp2IlInjected.Token(Token = "0x6000B99")]
			[Cpp2IlInjected.Address(RVA = "0xAAA820", Offset = "0xAA9C20", VA = "0x180AAA820")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000B9A")]
			[Cpp2IlInjected.Address(RVA = "0xAA67D0", Offset = "0xAA5BD0", VA = "0x180AA67D0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170004D6")]
		public List<NamedSchemaDTO> Tools
		{
			[Cpp2IlInjected.Token(Token = "0x6000B9B")]
			[Cpp2IlInjected.Address(RVA = "0xAAA140", Offset = "0xAA9540", VA = "0x180AAA140")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000B9C")]
			[Cpp2IlInjected.Address(RVA = "0xAADB00", Offset = "0xAACF00", VA = "0x180AADB00")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170004D7")]
		public ToolChoice ToolChoice
		{
			[Cpp2IlInjected.Token(Token = "0x6000B9D")]
			[Cpp2IlInjected.Address(RVA = "0xAD4020", Offset = "0xAD3420", VA = "0x180AD4020")]
			[CompilerGenerated]
			get
			{
				return default(ToolChoice);
			}
			[Cpp2IlInjected.Token(Token = "0x6000B9E")]
			[Cpp2IlInjected.Address(RVA = "0xB10400", Offset = "0xB0F800", VA = "0x180B10400")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170004D8")]
		public string? ForceToolName
		{
			[Cpp2IlInjected.Token(Token = "0x6000B9F")]
			[Cpp2IlInjected.Address(RVA = "0xAAA810", Offset = "0xAA9C10", VA = "0x180AAA810")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000BA0")]
			[Cpp2IlInjected.Address(RVA = "0xAAA840", Offset = "0xAA9C40", VA = "0x180AAA840")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000BA1")]
		[Cpp2IlInjected.Address(RVA = "0x7722D20", Offset = "0x7722120", VA = "0x187722D20")]
		public GenerateConversationResponseRequestDTO()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20001A2")]
	[Utf8JsonSerializable]
	public class ToolCallDTO
	{
		[Cpp2IlInjected.Token(Token = "0x170004D9")]
		public string Id
		{
			[Cpp2IlInjected.Token(Token = "0x6000BA2")]
			[Cpp2IlInjected.Address(RVA = "0xAA5FB0", Offset = "0xAA53B0", VA = "0x180AA5FB0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000BA3")]
			[Cpp2IlInjected.Address(RVA = "0xAA5FC0", Offset = "0xAA53C0", VA = "0x180AA5FC0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170004DA")]
		public string Name
		{
			[Cpp2IlInjected.Token(Token = "0x6000BA4")]
			[Cpp2IlInjected.Address(RVA = "0xAAA880", Offset = "0xAA9C80", VA = "0x180AAA880")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000BA5")]
			[Cpp2IlInjected.Address(RVA = "0xAAA120", Offset = "0xAA9520", VA = "0x180AAA120")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170004DB")]
		public string Arguments
		{
			[Cpp2IlInjected.Token(Token = "0x6000BA6")]
			[Cpp2IlInjected.Address(RVA = "0xAAB1C0", Offset = "0xAAA5C0", VA = "0x180AAB1C0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000BA7")]
			[Cpp2IlInjected.Address(RVA = "0xAA67C0", Offset = "0xAA5BC0", VA = "0x180AA67C0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000BA8")]
		[Cpp2IlInjected.Address(RVA = "0xAAC8E0", Offset = "0xAABCE0", VA = "0x180AAC8E0")]
		public ToolCallDTO()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20001A3")]
	[Utf8JsonSerializable]
	public class GenerateConversationResponseResponseDTO
	{
		[Cpp2IlInjected.Token(Token = "0x170004DC")]
		public List<string> TextItems
		{
			[Cpp2IlInjected.Token(Token = "0x6000BA9")]
			[Cpp2IlInjected.Address(RVA = "0xAA5FB0", Offset = "0xAA53B0", VA = "0x180AA5FB0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000BAA")]
			[Cpp2IlInjected.Address(RVA = "0xAA5FC0", Offset = "0xAA53C0", VA = "0x180AA5FC0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170004DD")]
		public List<ToolCallDTO>? ToolCalls
		{
			[Cpp2IlInjected.Token(Token = "0x6000BAB")]
			[Cpp2IlInjected.Address(RVA = "0xAAA880", Offset = "0xAA9C80", VA = "0x180AAA880")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000BAC")]
			[Cpp2IlInjected.Address(RVA = "0xAAA120", Offset = "0xAA9520", VA = "0x180AAA120")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000BAD")]
		[Cpp2IlInjected.Address(RVA = "0xAAC8E0", Offset = "0xAABCE0", VA = "0x180AAC8E0")]
		public GenerateConversationResponseResponseDTO()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20001A4")]
	[Utf8JsonSerializable]
	public class GenerateAudioOrSongResponseDTO
	{
		[Cpp2IlInjected.Token(Token = "0x170004DE")]
		public string Filename
		{
			[Cpp2IlInjected.Token(Token = "0x6000BAE")]
			[Cpp2IlInjected.Address(RVA = "0xAA5FB0", Offset = "0xAA53B0", VA = "0x180AA5FB0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000BAF")]
			[Cpp2IlInjected.Address(RVA = "0xAA5FC0", Offset = "0xAA53C0", VA = "0x180AA5FC0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000BB0")]
		[Cpp2IlInjected.Address(RVA = "0xAAC8E0", Offset = "0xAABCE0", VA = "0x180AAC8E0")]
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
