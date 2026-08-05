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
		[Cpp2IlInjected.Address(RVA = "0xAE81C0", Offset = "0xAE6FC0", VA = "0x180AE81C0")]
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
		[Cpp2IlInjected.Address(RVA = "0x7A5EFD0", Offset = "0x7A5DDD0", VA = "0x187A5EFD0")]
		public NullableAttribute(byte P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0xAE8B20", Offset = "0xAE7920", VA = "0x180AE8B20")]
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
		[Cpp2IlInjected.Address(RVA = "0xAE8B60", Offset = "0xAE7960", VA = "0x180AE8B60")]
		public NullableContextAttribute(byte P_0)
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public class MPNRIWAASCV
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
	public string XECXVNHZMRR;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000005")]
	public string JXJFZFRDRHW;

	[Cpp2IlInjected.Token(Token = "0x17000001")]
	public ResultStates DYYVSHAQLVF
	{
		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0xABD110", Offset = "0xABBF10", VA = "0x180ABD110")]
		[CompilerGenerated]
		get
		{
			return default(ResultStates);
		}
		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0xAC1D40", Offset = "0xAC0B40", VA = "0x180AC1D40")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	public bool TMQLSHMTEXW
	{
		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x2374580", Offset = "0x2373380", VA = "0x182374580")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	public bool BSBXOYDZRAA
	{
		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x1A75430", Offset = "0x1A74230", VA = "0x181A75430")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x7A5E600", Offset = "0x7A5D400", VA = "0x187A5E600")]
	[Obsolete("Use RecNet.Store.SkuPurchaseResult instead")]
	public static MPNRIWAASCV Success()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x7A5E570", Offset = "0x7A5D370", VA = "0x187A5E570")]
	[Obsolete("Use RecNet.Store.SkuPurchaseResult instead")]
	public static MPNRIWAASCV Cancelled([Optional] string userFriendlyError, [Optional] string internalError)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0xAC4840", Offset = "0xAC3640", VA = "0x180AC4840")]
	public MPNRIWAASCV()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
[CompilerGenerated]
[EditorBrowsable(EditorBrowsableState.Never)]
[GeneratedCode("Unity.MonoScriptGenerator.MonoScriptInfoGenerator", null)]
internal class MUPXUODILAN
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
	[Cpp2IlInjected.Address(RVA = "0x7A5E660", Offset = "0x7A5D460", VA = "0x187A5E660")]
	private static MonoScriptData Get()
	{
		return default(MonoScriptData);
	}

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0xAC4840", Offset = "0xAC3640", VA = "0x180AC4840")]
	public MUPXUODILAN()
	{
	}
}
namespace RecNet
{
	[Cpp2IlInjected.Token(Token = "0x2000009")]
	public interface DKEQGCPNGFY
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
	public interface GASUPBWPYQE
	{
		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(Slot = "0")]
		Task<DKEQGCPNGFY> WQNSDLQCLMC(string a, string b, string c, VoiceOption d, string? transcriptionModel, float e, [Optional] CancellationToken f);
	}
	[Cpp2IlInjected.Token(Token = "0x200000B")]
	public interface ERHONSLNWDT : GASUPBWPYQE
	{
		[Cpp2IlInjected.Token(Token = "0x17000006")]
		GenerateCircuitsResponseDTO? CALSIFGVYKV
		{
			[Cpp2IlInjected.Token(Token = "0x6000011")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000007")]
		OZAYXQWBYWY<MakerAITimeBalanceStatusUpdatePushNotification> UYRGMVNVUMF
		{
			[Cpp2IlInjected.Token(Token = "0x6000013")]
			[Cpp2IlInjected.Address(Slot = "2")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000008")]
		OZAYXQWBYWY<MakerAIUsageBalanceStatusUpdatePushNotification> GJWOYEVZLRX
		{
			[Cpp2IlInjected.Token(Token = "0x6000014")]
			[Cpp2IlInjected.Address(Slot = "3")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000009")]
		OZAYXQWBYWY<GenerateMeshResponseDTO> KBFXBMJNCEM
		{
			[Cpp2IlInjected.Token(Token = "0x6000015")]
			[Cpp2IlInjected.Address(Slot = "4")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x1700000A")]
		DQHMEXLDKHB QTXMFRAZWNX
		{
			[Cpp2IlInjected.Token(Token = "0x6000016")]
			[Cpp2IlInjected.Address(Slot = "5")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(Slot = "1")]
		void QPVANJJYXHX();

		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(Slot = "6")]
		Task<DisposableMemorySequence<byte>> BSCYLZXVRLM(string a, [Optional] CancellationToken b);

		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(Slot = "7")]
		Task<DEUOTOOEDVA> BCZPSQJOWNS(bool a, [Optional] CancellationToken b);

		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(Slot = "8")]
		Task<XBMGONGUUVP<RoomieEnergyDTO>> PYWVUXHTKKN(bool a = false, [Optional] CancellationToken b);

		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(Slot = "9")]
		Task<DEUOTOOEDVA> MCWVHMNCTAC(long a, [Optional] CancellationToken b);

		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(Slot = "10")]
		Task<RecNetResultObject<GameAIRoomSpendSummaryDTO>> BIKNWAPJVHQ(long a, bool b = false, [Optional] CancellationToken c);

		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(Slot = "11")]
		Task<GameAIPromoBalanceDTO> BSZZFGGJOFS([Optional] CancellationToken a);

		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(Slot = "12")]
		Task<GameAIPromoBalanceDTO> HKAWUBCBSWR(long a, [Optional] CancellationToken b);

		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(Slot = "13")]
		Task<MakerAIBalancesDTO> JDDIUFMTYEY(bool a = false, [Optional] CancellationToken b);

		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(Slot = "14")]
		Task<MakerAIFreeTrialConfigDTO> MPRRPGNYFXJ([Optional] CancellationToken a);

		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(Slot = "15")]
		Task<DEUOTOOEDVA> WNINWXQPKYO(bool a = false, [Optional] CancellationToken b);

		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(Slot = "16")]
		Task<DEUOTOOEDVA> FEJDCHDMNTU([Optional] CancellationToken a);

		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(Slot = "17")]
		Task<DEUOTOOEDVA> TYZTSNFNFCJ(string a, Guid b, long c, long d, decimal e, [Optional] CancellationToken f);

		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(Slot = "18")]
		Task<XBMGONGUUVP<RoomieEnergyDTO>> GSMDBOYTPDX(Guid a, long b, long c, decimal d, byte e, [Optional] CancellationToken f);

		[Cpp2IlInjected.Token(Token = "0x6000024")]
		[Cpp2IlInjected.Address(Slot = "19")]
		Task ZPDYTQHATMS(string a, string b, [Optional] CancellationToken c);

		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(Slot = "20")]
		Task<GenerateImageResponseDTO> UALPFRMPUGE(string a, string b, bool c, [Optional] CancellationToken d);

		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(Slot = "21")]
		Task<GenerateMeshResponseDTO> KSGHKBVRIWH(long a, string b, string c, string d, string e, [Optional] CancellationToken f);

		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(Slot = "22")]
		Task<GenerateMeshResponseDTO> KXXKWHJBXXB(long a, [Optional] CancellationToken b);

		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(Slot = "23")]
		Task<DescribeImageResponseDTO> TMTSJVBTKZB(string? model, string a, string b, [Optional] CancellationToken c);

		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(Slot = "24")]
		Task<DescribeImageResponseDTO> TMTSJVBTKZB(string? model, string a, byte[] b, [Optional] CancellationToken c);

		[Cpp2IlInjected.Token(Token = "0x600002A")]
		[Cpp2IlInjected.Address(Slot = "25")]
		Task<DescribeImageResponseDTO> GMDTGKGYNSY(long a, string? model, string b, string c, float? d, string e, [Optional] CancellationToken f);

		[Cpp2IlInjected.Token(Token = "0x600002B")]
		[Cpp2IlInjected.Address(Slot = "26")]
		Task<DescribeImageResponseDTO> GMDTGKGYNSY(long a, string? model, string b, byte[] c, float? d, string e, [Optional] CancellationToken f);

		[Cpp2IlInjected.Token(Token = "0x600002C")]
		[Cpp2IlInjected.Address(Slot = "27")]
		Task<GenerateImageResponseDTO> VYRIAABGDKZ(long a, EditImageRequestDTO b, byte[] c, string d, [Optional] CancellationToken e);

		[Cpp2IlInjected.Token(Token = "0x600002D")]
		[Cpp2IlInjected.Address(Slot = "28")]
		Task<GenerateImageResponseDTO> UCHOPEBSHGU(EditImageRequestDTO a, string b, string c, [Optional] CancellationToken d);

		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(Slot = "29")]
		Task<GenerateImageResponseDTO> BDRKJOHOOBY(long a, string? model, string b, bool c, string d, [Optional] CancellationToken e);

		[Cpp2IlInjected.Token(Token = "0x600002F")]
		[Cpp2IlInjected.Address(Slot = "30")]
		Task<GenerateAudioOrSongResponseDTO> QLOQMSLCUMU(string a, int b, string c, string d, [Optional] CancellationToken e);

		[Cpp2IlInjected.Token(Token = "0x6000030")]
		[Cpp2IlInjected.Address(Slot = "31")]
		Task<GenerateAudioOrSongResponseDTO> QZZVJZVRAIY(string a, int b, string c, [Optional] CancellationToken d);

		[Cpp2IlInjected.Token(Token = "0x6000031")]
		[Cpp2IlInjected.Address(Slot = "32")]
		Task<ChatResponseDTO> Chat(string? model, string prompt, [Optional] CancellationToken cancellationToken);

		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(Slot = "33")]
		Task<GenerateCircuitsResponseDTO> GenerateCircuits(string prompt, CircuitObjectDefinition? objectDefinition, IReadOnlyList<CircuitObjectDefinition>? sceneObjectDefinitions, IReadOnlyList<string> sceneTags, CircuitGenConfigDTO config, [Optional] string? overrideInstructions, [Optional] string? overrideLibraryCode, [Optional] string? overrideModel, [Optional] CancellationToken cancellationToken);

		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(Slot = "34")]
		Task<GenerateCircuitsResponseDTO> WHHJUVNHLTT(string a, CircuitObjectDefinition? objectDefinition, IReadOnlyList<string> b, CircuitGenConfigDTO c, [Optional] string? overrideLibraryCode, [Optional] CancellationToken d);

		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(Slot = "35")]
		Task<List<string>> SearchRooms(string prompt, [Optional] CancellationToken cancellationToken);

		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(Slot = "36")]
		Task<string> THJBYYNYKHZ(CircuitGenConfigDTO a, [Optional] CancellationToken b);

		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(Slot = "37")]
		Task GKLOLAYXDUK(string a, VoiceOption b, string? instructions, Action<string> c, string d, [Optional] CancellationToken e);

		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(Slot = "38")]
		Task<string> GUSNMCYFWFI(ReadOnlyMemory<byte> pcmData, int a, int b, string c, [Optional] CancellationToken d);

		[Cpp2IlInjected.Token(Token = "0x6000038")]
		[Cpp2IlInjected.Address(Slot = "39")]
		Task<RoomieUserFactsDTO> GRYXNLZSDTD(List<ConversationMessageDTO> a, [Optional] CancellationToken b);

		[Cpp2IlInjected.Token(Token = "0x6000039")]
		[Cpp2IlInjected.Address(Slot = "40")]
		Task<RoomieUserFactsDTO> QXFUMTSBQZT([Optional] CancellationToken a);

		[Cpp2IlInjected.Token(Token = "0x600003A")]
		[Cpp2IlInjected.Address(Slot = "41")]
		Task<bool> QITHIXNKMZH(string a, [Optional] CancellationToken b);

		[Cpp2IlInjected.Token(Token = "0x600003B")]
		[Cpp2IlInjected.Address(Slot = "42")]
		Task CQZBHNPOGYY(string a, ConversationMessageRole b, string c, [Optional] CancellationToken d);

		[Cpp2IlInjected.Token(Token = "0x600003C")]
		[Cpp2IlInjected.Address(Slot = "43")]
		Task XUMEOPLQBIG(string a, string b, string c, [Optional] CancellationToken d);

		[Cpp2IlInjected.Token(Token = "0x600003D")]
		[Cpp2IlInjected.Address(Slot = "44")]
		Task<GenerateConversationResponseResponseDTO> RDKXFXOTNEB(string a, string b, [Optional] string? model, [Optional] float? c, [Optional] NamedSchemaDTO? responseFormat, [Optional] IReadOnlyCollection<NamedSchemaDTO>? tools, ToolChoice d = ToolChoice.Auto, [Optional] string? forceToolName, [Optional] CancellationToken e);
	}
	[Cpp2IlInjected.Token(Token = "0x200000C")]
	public class NIWFOENLDJY
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400000F")]
		private string APXVUNFVPEI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000010")]
		private string QFKRMGEMMFP;

		[Cpp2IlInjected.Token(Token = "0x1700000B")]
		public string IAWXBDDOOFE
		{
			[Cpp2IlInjected.Token(Token = "0x600003E")]
			[Cpp2IlInjected.Address(RVA = "0xAC1D20", Offset = "0xAC0B20", VA = "0x180AC1D20")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600003F")]
			[Cpp2IlInjected.Address(RVA = "0xAC0640", Offset = "0xABF440", VA = "0x180AC0640")]
			[CompilerGenerated]
			internal set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000C")]
		public string GRRNVRRPKQU
		{
			[Cpp2IlInjected.Token(Token = "0x6000040")]
			[Cpp2IlInjected.Address(RVA = "0xAC0F90", Offset = "0xABFD90", VA = "0x180AC0F90")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000041")]
			[Cpp2IlInjected.Address(RVA = "0xAC0650", Offset = "0xABF450", VA = "0x180AC0650")]
			[CompilerGenerated]
			internal set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000D")]
		public string FDLIZFDOZAE
		{
			[Cpp2IlInjected.Token(Token = "0x6000042")]
			[Cpp2IlInjected.Address(RVA = "0xAC0F80", Offset = "0xABFD80", VA = "0x180AC0F80")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000043")]
			[Cpp2IlInjected.Address(RVA = "0xAC8C50", Offset = "0xAC7A50", VA = "0x180AC8C50")]
			[CompilerGenerated]
			internal set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000E")]
		public string FDFXGMQAYRI
		{
			[Cpp2IlInjected.Token(Token = "0x6000044")]
			[Cpp2IlInjected.Address(RVA = "0xAC0FC0", Offset = "0xABFDC0", VA = "0x180AC0FC0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000F")]
		public int? WTTTDUHXUKH
		{
			[Cpp2IlInjected.Token(Token = "0x6000045")]
			[Cpp2IlInjected.Address(RVA = "0xAC5120", Offset = "0xAC3F20", VA = "0x180AC5120")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000010")]
		public int? DNKAVFHUUMP
		{
			[Cpp2IlInjected.Token(Token = "0x6000046")]
			[Cpp2IlInjected.Address(RVA = "0xAC0D30", Offset = "0xABFB30", VA = "0x180AC0D30")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000047")]
		[Cpp2IlInjected.Address(RVA = "0x7A5EB10", Offset = "0x7A5D910", VA = "0x187A5EB10")]
		public NIWFOENLDJY(string a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000048")]
		[Cpp2IlInjected.Address(RVA = "0x7A5E9E0", Offset = "0x7A5D7E0", VA = "0x187A5E9E0")]
		public void HOLDWAPADPI(string a = "")
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000049")]
		[Cpp2IlInjected.Address(RVA = "0x7A5EA10", Offset = "0x7A5D810", VA = "0x187A5EA10")]
		private void QHBCXTSQXLX()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000E")]
	public interface SVQUJRLMYQN
	{
		[Cpp2IlInjected.Token(Token = "0x17000011")]
		FMNIXJKWAVU FXKXAOONCWY
		{
			[Cpp2IlInjected.Token(Token = "0x600004E")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x14000001")]
		event Action<SubscriptionStatus> PQGBRAUMVUE;

		[Cpp2IlInjected.Token(Token = "0x14000002")]
		event Action<SubscriptionSnapshot> CESDUEUTSNL;

		[Cpp2IlInjected.Token(Token = "0x6000053")]
		[Cpp2IlInjected.Address(Slot = "5")]
		Task<SubscriptionSnapshot> WZGBZHCJBPB(bool a = false, [Optional] CancellationToken b);

		[Cpp2IlInjected.Token(Token = "0x6000054")]
		[Cpp2IlInjected.Address(Slot = "6")]
		bool QBPOQDMMBJD([Out] SubscriptionSnapshot a);
	}
	[Cpp2IlInjected.Token(Token = "0x200000F")]
	public static class LGRZNKZFMGH
	{
		[Cpp2IlInjected.Token(Token = "0x6000055")]
		[Cpp2IlInjected.Address(RVA = "0x7A5DF80", Offset = "0x7A5CD80", VA = "0x187A5DF80")]
		public static bool ANZDRFECAYD(this SVQUJRLMYQN a, [Out] SubscriptionStatus b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000056")]
		[Cpp2IlInjected.Address(RVA = "0x7A5E070", Offset = "0x7A5CE70", VA = "0x187A5E070")]
		public static bool LIWPCPLVDJB(this SVQUJRLMYQN a)
		{
			return default(bool);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000010")]
	public interface YASSPLOXQYU
	{
		[Cpp2IlInjected.Token(Token = "0x6000057")]
		[Cpp2IlInjected.Address(Slot = "0")]
		Task PKHWZPOXHPR(CancellationToken a);

		[Cpp2IlInjected.Token(Token = "0x6000058")]
		[Cpp2IlInjected.Address(Slot = "1")]
		bool XNTUIRQCUTY(int a, [Out] SRUMTHPJTKV? b);
	}
	[Cpp2IlInjected.Token(Token = "0x2000011")]
	public interface SRUMTHPJTKV
	{
		[Cpp2IlInjected.Token(Token = "0x17000012")]
		int FOBTRZXDEYF
		{
			[Cpp2IlInjected.Token(Token = "0x6000059")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000013")]
		string? JDIPTDKIYCA
		{
			[Cpp2IlInjected.Token(Token = "0x600005A")]
			[Cpp2IlInjected.Address(Slot = "1")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000014")]
		string? DQPGZQUGAMT
		{
			[Cpp2IlInjected.Token(Token = "0x600005B")]
			[Cpp2IlInjected.Address(Slot = "2")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000015")]
		bool? KQNBPYCRDDV
		{
			[Cpp2IlInjected.Token(Token = "0x600005C")]
			[Cpp2IlInjected.Address(Slot = "3")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000016")]
		string? PCUZNQXOVQF
		{
			[Cpp2IlInjected.Token(Token = "0x600005D")]
			[Cpp2IlInjected.Address(Slot = "4")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000017")]
		string? LSFLUBOQNJB
		{
			[Cpp2IlInjected.Token(Token = "0x600005E")]
			[Cpp2IlInjected.Address(Slot = "5")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000018")]
		YWXWOQPKHHI? SJRQLCYFSSQ
		{
			[Cpp2IlInjected.Token(Token = "0x600005F")]
			[Cpp2IlInjected.Address(Slot = "6")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x6000060")]
		[Cpp2IlInjected.Address(Slot = "7")]
		bool BMDVVYVQHVH(string a, [Out] IIRFHOIYFJL? config);
	}
	[Cpp2IlInjected.Token(Token = "0x2000012")]
	public interface IIRFHOIYFJL
	{
		[Cpp2IlInjected.Token(Token = "0x17000019")]
		string? QUKHOKRQDML
		{
			[Cpp2IlInjected.Token(Token = "0x6000061")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x1700001A")]
		string? AKJCSRXRASE
		{
			[Cpp2IlInjected.Token(Token = "0x6000062")]
			[Cpp2IlInjected.Address(Slot = "1")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x1700001B")]
		string? GLSIDVMSIWR
		{
			[Cpp2IlInjected.Token(Token = "0x6000063")]
			[Cpp2IlInjected.Address(Slot = "2")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x1700001C")]
		IReadOnlyList<MQVGOBNXULX>? TGTANWSJHCE
		{
			[Cpp2IlInjected.Token(Token = "0x6000064")]
			[Cpp2IlInjected.Address(Slot = "3")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x1700001D")]
		YWXWOQPKHHI? SJRQLCYFSSQ
		{
			[Cpp2IlInjected.Token(Token = "0x6000065")]
			[Cpp2IlInjected.Address(Slot = "4")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x1700001E")]
		long? IJSIQHZCRXY
		{
			[Cpp2IlInjected.Token(Token = "0x6000066")]
			[Cpp2IlInjected.Address(Slot = "5")]
			get;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000013")]
	public interface MQVGOBNXULX
	{
		[Cpp2IlInjected.Token(Token = "0x1700001F")]
		string AKJCSRXRASE
		{
			[Cpp2IlInjected.Token(Token = "0x6000067")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000020")]
		string QCFSUOQZRCP
		{
			[Cpp2IlInjected.Token(Token = "0x6000068")]
			[Cpp2IlInjected.Address(Slot = "1")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000021")]
		SKUButtonAction ZHOIZUXKHXA
		{
			[Cpp2IlInjected.Token(Token = "0x6000069")]
			[Cpp2IlInjected.Address(Slot = "2")]
			get;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000014")]
	public interface YWXWOQPKHHI
	{
		[Cpp2IlInjected.Token(Token = "0x17000022")]
		string AKJCSRXRASE
		{
			[Cpp2IlInjected.Token(Token = "0x600006A")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000023")]
		string? RIRBECKIQRL
		{
			[Cpp2IlInjected.Token(Token = "0x600006B")]
			[Cpp2IlInjected.Address(Slot = "1")]
			get;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000015")]
	[Utf8JsonSerializable]
	public class InitiatePurchaseRequest : IRecNetUtf8JsonObject
	{
		[Cpp2IlInjected.Token(Token = "0x17000024")]
		public string AccessToken
		{
			[Cpp2IlInjected.Token(Token = "0x600006C")]
			[Cpp2IlInjected.Address(RVA = "0xABD130", Offset = "0xABBF30", VA = "0x180ABD130")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600006D")]
			[Cpp2IlInjected.Address(RVA = "0xABD120", Offset = "0xABBF20", VA = "0x180ABD120")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000025")]
		public int SkuId
		{
			[Cpp2IlInjected.Token(Token = "0x600006E")]
			[Cpp2IlInjected.Address(RVA = "0xAC7B20", Offset = "0xAC6920", VA = "0x180AC7B20")]
			[CompilerGenerated]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x600006F")]
			[Cpp2IlInjected.Address(RVA = "0xACAE40", Offset = "0xAC9C40", VA = "0x180ACAE40")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000026")]
		public int? PurchaseReminderId
		{
			[Cpp2IlInjected.Token(Token = "0x6000070")]
			[Cpp2IlInjected.Address(RVA = "0x13E8E60", Offset = "0x13E7C60", VA = "0x1813E8E60")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000071")]
			[Cpp2IlInjected.Address(RVA = "0x13E8E90", Offset = "0x13E7C90", VA = "0x1813E8E90")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000027")]
		public int? RRPlusSignUpBonusId
		{
			[Cpp2IlInjected.Token(Token = "0x6000072")]
			[Cpp2IlInjected.Address(RVA = "0x13E8E70", Offset = "0x13E7C70", VA = "0x1813E8E70")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000073")]
			[Cpp2IlInjected.Address(RVA = "0x10D56B0", Offset = "0x10D44B0", VA = "0x1810D56B0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000028")]
		public List<ItemPurchaseMethodId> BonusItemIds
		{
			[Cpp2IlInjected.Token(Token = "0x6000074")]
			[Cpp2IlInjected.Address(RVA = "0xAC0F80", Offset = "0xABFD80", VA = "0x180AC0F80")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000075")]
			[Cpp2IlInjected.Address(RVA = "0xAC8C50", Offset = "0xAC7A50", VA = "0x180AC8C50")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000076")]
		[Cpp2IlInjected.Address(RVA = "0xABE8D0", Offset = "0xABD6D0", VA = "0x180ABE8D0", Slot = "4")]
		public void DNRPRHFLPRB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000077")]
		[Cpp2IlInjected.Address(RVA = "0xAC4840", Offset = "0xAC3640", VA = "0x180AC4840")]
		public InitiatePurchaseRequest()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000016")]
	[Utf8JsonSerializable]
	public class InitiatePurchaseResponse : IRecNetUtf8JsonObject
	{
		[Cpp2IlInjected.Token(Token = "0x17000029")]
		public long TransactionId
		{
			[Cpp2IlInjected.Token(Token = "0x6000078")]
			[Cpp2IlInjected.Address(RVA = "0xABD130", Offset = "0xABBF30", VA = "0x180ABD130")]
			[CompilerGenerated]
			get
			{
				return default(long);
			}
			[Cpp2IlInjected.Token(Token = "0x6000079")]
			[Cpp2IlInjected.Address(RVA = "0xEABA00", Offset = "0xEAA800", VA = "0x180EABA00")]
			[CompilerGenerated]
			internal set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600007A")]
		[Cpp2IlInjected.Address(RVA = "0xABE8D0", Offset = "0xABD6D0", VA = "0x180ABE8D0", Slot = "4")]
		public void DNRPRHFLPRB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007B")]
		[Cpp2IlInjected.Address(RVA = "0xAC4840", Offset = "0xAC3640", VA = "0x180AC4840")]
		public InitiatePurchaseResponse()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000017")]
	[Utf8JsonSerializable]
	public class ProcessPurchaseRequest : IRecNetUtf8JsonObject
	{
		[Cpp2IlInjected.Token(Token = "0x1700002A")]
		public string AccessToken
		{
			[Cpp2IlInjected.Token(Token = "0x600007C")]
			[Cpp2IlInjected.Address(RVA = "0xABD130", Offset = "0xABBF30", VA = "0x180ABD130")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600007D")]
			[Cpp2IlInjected.Address(RVA = "0xABD120", Offset = "0xABBF20", VA = "0x180ABD120")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002B")]
		public string PurchaseDetails
		{
			[Cpp2IlInjected.Token(Token = "0x600007E")]
			[Cpp2IlInjected.Address(RVA = "0xAC0D20", Offset = "0xABFB20", VA = "0x180AC0D20")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600007F")]
			[Cpp2IlInjected.Address(RVA = "0xAC0D10", Offset = "0xABFB10", VA = "0x180AC0D10")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002C")]
		public int? PurchaseReminderId
		{
			[Cpp2IlInjected.Token(Token = "0x6000080")]
			[Cpp2IlInjected.Address(RVA = "0xAC1D20", Offset = "0xAC0B20", VA = "0x180AC1D20")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000081")]
			[Cpp2IlInjected.Address(RVA = "0xE33D40", Offset = "0xE32B40", VA = "0x180E33D40")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002D")]
		public int? RRPlusSignUpBonusId
		{
			[Cpp2IlInjected.Token(Token = "0x6000082")]
			[Cpp2IlInjected.Address(RVA = "0xAC0F90", Offset = "0xABFD90", VA = "0x180AC0F90")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000083")]
			[Cpp2IlInjected.Address(RVA = "0xAC0D00", Offset = "0xABFB00", VA = "0x180AC0D00")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002E")]
		public List<ItemPurchaseMethodId> BonusItemIds
		{
			[Cpp2IlInjected.Token(Token = "0x6000084")]
			[Cpp2IlInjected.Address(RVA = "0xAC0F80", Offset = "0xABFD80", VA = "0x180AC0F80")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000085")]
			[Cpp2IlInjected.Address(RVA = "0xAC8C50", Offset = "0xAC7A50", VA = "0x180AC8C50")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000086")]
		[Cpp2IlInjected.Address(RVA = "0xABE8D0", Offset = "0xABD6D0", VA = "0x180ABE8D0", Slot = "4")]
		public void DNRPRHFLPRB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000087")]
		[Cpp2IlInjected.Address(RVA = "0xAC4840", Offset = "0xAC3640", VA = "0x180AC4840")]
		public ProcessPurchaseRequest()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000018")]
	[Utf8JsonSerializable]
	public class SKUConfigCollectionDTO
	{
		[Cpp2IlInjected.Token(Token = "0x1700002F")]
		public int Version
		{
			[Cpp2IlInjected.Token(Token = "0x6000088")]
			[Cpp2IlInjected.Address(RVA = "0xABD110", Offset = "0xABBF10", VA = "0x180ABD110")]
			[CompilerGenerated]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x6000089")]
			[Cpp2IlInjected.Address(RVA = "0xAC1D40", Offset = "0xAC0B40", VA = "0x180AC1D40")]
			[CompilerGenerated]
			internal set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000030")]
		public List<SKUConfigDTO> SkuConfigs
		{
			[Cpp2IlInjected.Token(Token = "0x600008A")]
			[Cpp2IlInjected.Address(RVA = "0xAC0D20", Offset = "0xABFB20", VA = "0x180AC0D20")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600008B")]
			[Cpp2IlInjected.Address(RVA = "0xAC0D10", Offset = "0xABFB10", VA = "0x180AC0D10")]
			[CompilerGenerated]
			internal set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000031")]
		public Dictionary<string, string> StringReplacements
		{
			[Cpp2IlInjected.Token(Token = "0x600008C")]
			[Cpp2IlInjected.Address(RVA = "0xAC1D20", Offset = "0xAC0B20", VA = "0x180AC1D20")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600008D")]
			[Cpp2IlInjected.Address(RVA = "0xAC0640", Offset = "0xABF440", VA = "0x180AC0640")]
			[CompilerGenerated]
			internal set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600008E")]
		[Cpp2IlInjected.Address(RVA = "0x7A60F90", Offset = "0x7A5FD90", VA = "0x187A60F90")]
		public SKUConfigCollectionDTO()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000019")]
	[Utf8JsonSerializable]
	public class SKUConfigDTO
	{
		[Cpp2IlInjected.Token(Token = "0x17000032")]
		public int SkuId
		{
			[Cpp2IlInjected.Token(Token = "0x600008F")]
			[Cpp2IlInjected.Address(RVA = "0xABD110", Offset = "0xABBF10", VA = "0x180ABD110")]
			[CompilerGenerated]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x6000090")]
			[Cpp2IlInjected.Address(RVA = "0xAC1D40", Offset = "0xAC0B40", VA = "0x180AC1D40")]
			[CompilerGenerated]
			internal set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000033")]
		public string Name
		{
			[Cpp2IlInjected.Token(Token = "0x6000091")]
			[Cpp2IlInjected.Address(RVA = "0xAC0D20", Offset = "0xABFB20", VA = "0x180AC0D20")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000092")]
			[Cpp2IlInjected.Address(RVA = "0xAC0D10", Offset = "0xABFB10", VA = "0x180AC0D10")]
			[CompilerGenerated]
			internal set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000034")]
		public string Description
		{
			[Cpp2IlInjected.Token(Token = "0x6000093")]
			[Cpp2IlInjected.Address(RVA = "0xAC1D20", Offset = "0xAC0B20", VA = "0x180AC1D20")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000094")]
			[Cpp2IlInjected.Address(RVA = "0xAC0640", Offset = "0xABF440", VA = "0x180AC0640")]
			[CompilerGenerated]
			internal set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000035")]
		public string ThumbnailImageName
		{
			[Cpp2IlInjected.Token(Token = "0x6000095")]
			[Cpp2IlInjected.Address(RVA = "0xAC0F90", Offset = "0xABFD90", VA = "0x180AC0F90")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000096")]
			[Cpp2IlInjected.Address(RVA = "0xAC0650", Offset = "0xABF450", VA = "0x180AC0650")]
			[CompilerGenerated]
			internal set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000036")]
		public string DetailsImageName
		{
			[Cpp2IlInjected.Token(Token = "0x6000097")]
			[Cpp2IlInjected.Address(RVA = "0xAC0F80", Offset = "0xABFD80", VA = "0x180AC0F80")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000098")]
			[Cpp2IlInjected.Address(RVA = "0xAC8C50", Offset = "0xAC7A50", VA = "0x180AC8C50")]
			[CompilerGenerated]
			internal set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000037")]
		public bool? ShowSkuDetails
		{
			[Cpp2IlInjected.Token(Token = "0x6000099")]
			[Cpp2IlInjected.Address(RVA = "0x2683620", Offset = "0x2682420", VA = "0x182683620")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600009A")]
			[Cpp2IlInjected.Address(RVA = "0x2683610", Offset = "0x2682410", VA = "0x182683610")]
			[CompilerGenerated]
			internal set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000038")]
		public SKUFooterConfigDTO Footer
		{
			[Cpp2IlInjected.Token(Token = "0x600009B")]
			[Cpp2IlInjected.Address(RVA = "0xAC5120", Offset = "0xAC3F20", VA = "0x180AC5120")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600009C")]
			[Cpp2IlInjected.Address(RVA = "0xAC0FB0", Offset = "0xABFDB0", VA = "0x180AC0FB0")]
			[CompilerGenerated]
			internal set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000039")]
		public Dictionary<string, SKUDialogConfigDTO> DialogConfigs
		{
			[Cpp2IlInjected.Token(Token = "0x600009D")]
			[Cpp2IlInjected.Address(RVA = "0xAC0D30", Offset = "0xABFB30", VA = "0x180AC0D30")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600009E")]
			[Cpp2IlInjected.Address(RVA = "0xAC1370", Offset = "0xAC0170", VA = "0x180AC1370")]
			[CompilerGenerated]
			internal set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600009F")]
		[Cpp2IlInjected.Address(RVA = "0x7A61010", Offset = "0x7A5FE10", VA = "0x187A61010")]
		public SKUConfigDTO()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200001A")]
	[Utf8JsonSerializable]
	public class SKUFooterConfigDTO
	{
		[Cpp2IlInjected.Token(Token = "0x1700003A")]
		public string Text
		{
			[Cpp2IlInjected.Token(Token = "0x60000A0")]
			[Cpp2IlInjected.Address(RVA = "0xABD130", Offset = "0xABBF30", VA = "0x180ABD130")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60000A1")]
			[Cpp2IlInjected.Address(RVA = "0xABD120", Offset = "0xABBF20", VA = "0x180ABD120")]
			[CompilerGenerated]
			internal set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700003B")]
		public string ExternalUrl
		{
			[Cpp2IlInjected.Token(Token = "0x60000A2")]
			[Cpp2IlInjected.Address(RVA = "0xAC0D20", Offset = "0xABFB20", VA = "0x180AC0D20")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60000A3")]
			[Cpp2IlInjected.Address(RVA = "0xAC0D10", Offset = "0xABFB10", VA = "0x180AC0D10")]
			[CompilerGenerated]
			internal set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000A4")]
		[Cpp2IlInjected.Address(RVA = "0xAC4840", Offset = "0xAC3640", VA = "0x180AC4840")]
		public SKUFooterConfigDTO()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200001B")]
	[Utf8JsonSerializable]
	public class SKUDialogConfigDTO
	{
		[Cpp2IlInjected.Token(Token = "0x1700003C")]
		public string Title
		{
			[Cpp2IlInjected.Token(Token = "0x60000A5")]
			[Cpp2IlInjected.Address(RVA = "0xABD130", Offset = "0xABBF30", VA = "0x180ABD130")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60000A6")]
			[Cpp2IlInjected.Address(RVA = "0xABD120", Offset = "0xABBF20", VA = "0x180ABD120")]
			[CompilerGenerated]
			internal set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700003D")]
		public string Text
		{
			[Cpp2IlInjected.Token(Token = "0x60000A7")]
			[Cpp2IlInjected.Address(RVA = "0xAC0D20", Offset = "0xABFB20", VA = "0x180AC0D20")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60000A8")]
			[Cpp2IlInjected.Address(RVA = "0xAC0D10", Offset = "0xABFB10", VA = "0x180AC0D10")]
			[CompilerGenerated]
			internal set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700003E")]
		public string SpriteName
		{
			[Cpp2IlInjected.Token(Token = "0x60000A9")]
			[Cpp2IlInjected.Address(RVA = "0xAC1D20", Offset = "0xAC0B20", VA = "0x180AC1D20")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60000AA")]
			[Cpp2IlInjected.Address(RVA = "0xAC0640", Offset = "0xABF440", VA = "0x180AC0640")]
			[CompilerGenerated]
			internal set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700003F")]
		public List<SKUButtonConfigDTO> Buttons
		{
			[Cpp2IlInjected.Token(Token = "0x60000AB")]
			[Cpp2IlInjected.Address(RVA = "0xAC0F90", Offset = "0xABFD90", VA = "0x180AC0F90")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60000AC")]
			[Cpp2IlInjected.Address(RVA = "0xAC0650", Offset = "0xABF450", VA = "0x180AC0650")]
			[CompilerGenerated]
			internal set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000040")]
		public SKUFooterConfigDTO Footer
		{
			[Cpp2IlInjected.Token(Token = "0x60000AD")]
			[Cpp2IlInjected.Address(RVA = "0xAC0F80", Offset = "0xABFD80", VA = "0x180AC0F80")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60000AE")]
			[Cpp2IlInjected.Address(RVA = "0xAC8C50", Offset = "0xAC7A50", VA = "0x180AC8C50")]
			[CompilerGenerated]
			internal set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000041")]
		public long Cooldown
		{
			[Cpp2IlInjected.Token(Token = "0x60000AF")]
			[Cpp2IlInjected.Address(RVA = "0xAC0FC0", Offset = "0xABFDC0", VA = "0x180AC0FC0")]
			[CompilerGenerated]
			get
			{
				return default(long);
			}
			[Cpp2IlInjected.Token(Token = "0x60000B0")]
			[Cpp2IlInjected.Address(RVA = "0xAC6570", Offset = "0xAC5370", VA = "0x180AC6570")]
			[CompilerGenerated]
			internal set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000B1")]
		[Cpp2IlInjected.Address(RVA = "0x7A61090", Offset = "0x7A5FE90", VA = "0x187A61090")]
		public SKUDialogConfigDTO()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200001C")]
	public enum SKUButtonAction
	{
		[Cpp2IlInjected.Token(Token = "0x4000039")]
		DismissDialog,
		[Cpp2IlInjected.Token(Token = "0x400003A")]
		CloseWatch,
		[Cpp2IlInjected.Token(Token = "0x400003B")]
		GoToStore,
		[Cpp2IlInjected.Token(Token = "0x400003C")]
		GoToCreate,
		[Cpp2IlInjected.Token(Token = "0x400003D")]
		GoToDayPass,
		[Cpp2IlInjected.Token(Token = "0x400003E")]
		PositiveEvent,
		[Cpp2IlInjected.Token(Token = "0x400003F")]
		NegativeEvent,
		[Cpp2IlInjected.Token(Token = "0x4000040")]
		CancelEvent
	}
	[Cpp2IlInjected.Token(Token = "0x200001D")]
	[Utf8JsonSerializable]
	public class SKUButtonConfigDTO
	{
		[Cpp2IlInjected.Token(Token = "0x17000042")]
		public string Text
		{
			[Cpp2IlInjected.Token(Token = "0x60000B2")]
			[Cpp2IlInjected.Address(RVA = "0xABD130", Offset = "0xABBF30", VA = "0x180ABD130")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60000B3")]
			[Cpp2IlInjected.Address(RVA = "0xABD120", Offset = "0xABBF20", VA = "0x180ABD120")]
			[CompilerGenerated]
			internal set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000043")]
		public string Type
		{
			[Cpp2IlInjected.Token(Token = "0x60000B4")]
			[Cpp2IlInjected.Address(RVA = "0xAC0D20", Offset = "0xABFB20", VA = "0x180AC0D20")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60000B5")]
			[Cpp2IlInjected.Address(RVA = "0xAC0D10", Offset = "0xABFB10", VA = "0x180AC0D10")]
			[CompilerGenerated]
			internal set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000044")]
		public SKUButtonAction OnClick
		{
			[Cpp2IlInjected.Token(Token = "0x60000B6")]
			[Cpp2IlInjected.Address(RVA = "0xACF4D0", Offset = "0xACE2D0", VA = "0x180ACF4D0")]
			[CompilerGenerated]
			get
			{
				return default(SKUButtonAction);
			}
			[Cpp2IlInjected.Token(Token = "0x60000B7")]
			[Cpp2IlInjected.Address(RVA = "0xB20FD0", Offset = "0xB1FDD0", VA = "0x180B20FD0")]
			[CompilerGenerated]
			internal set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000B8")]
		[Cpp2IlInjected.Address(RVA = "0xAC4840", Offset = "0xAC3640", VA = "0x180AC4840")]
		public SKUButtonConfigDTO()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200001E")]
	public readonly struct SubscriptionDetails : IEquatable<SubscriptionDetails>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000044")]
		private readonly bool isValid;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000045")]
		public readonly DateTime ExpirationDateUtc;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000046")]
		public readonly bool IsAutoRenewing;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x4000047")]
		public readonly PlatformType? PlatformType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000048")]
		public readonly string PlatformId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000049")]
		public readonly int? PlatformAccountSubscribedPlayerId;

		[Cpp2IlInjected.Token(Token = "0x17000045")]
		public static SubscriptionDetails RKYYZPHGRGJ
		{
			[Cpp2IlInjected.Token(Token = "0x60000B9")]
			[Cpp2IlInjected.Address(RVA = "0x2A7D850", Offset = "0x2A7C650", VA = "0x182A7D850")]
			get
			{
				return default(SubscriptionDetails);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000BA")]
		[Cpp2IlInjected.Address(RVA = "0x7A62260", Offset = "0x7A61060", VA = "0x187A62260")]
		public SubscriptionDetails(DateTime expirationDateUtc, bool isAutoRenewing, PlatformType? platformType, string platformId, int? platformAccountSubscribedPlayerId)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000BB")]
		[Cpp2IlInjected.Address(RVA = "0x7A62170", Offset = "0x7A60F70", VA = "0x187A62170")]
		public SubscriptionStatus UNESFSDJBIN(FMNIXJKWAVU a)
		{
			return default(SubscriptionStatus);
		}

		[Cpp2IlInjected.Token(Token = "0x60000BC")]
		[Cpp2IlInjected.Address(RVA = "0x7A621F0", Offset = "0x7A60FF0", VA = "0x187A621F0")]
		private static SubscriptionStatus VKXCUXMKDFE(FMNIXJKWAVU a, DateTime b)
		{
			return default(SubscriptionStatus);
		}

		[Cpp2IlInjected.Token(Token = "0x60000BD")]
		[Cpp2IlInjected.Address(RVA = "0x7A61E80", Offset = "0x7A60C80", VA = "0x187A61E80", Slot = "4")]
		public bool Equals(SubscriptionDetails other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000BE")]
		[Cpp2IlInjected.Address(RVA = "0x7A61DD0", Offset = "0x7A60BD0", VA = "0x187A61DD0", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000BF")]
		[Cpp2IlInjected.Address(RVA = "0x7A62010", Offset = "0x7A60E10", VA = "0x187A62010", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[SpecialName]
		[Cpp2IlInjected.Token(Token = "0x60000C0")]
		[Cpp2IlInjected.Address(RVA = "0x7A61FE0", Offset = "0x7A60DE0", VA = "0x187A61FE0")]
		public static bool GFBRUTYEXQF(SubscriptionDetails a, SubscriptionDetails b)
		{
			return default(bool);
		}

		[SpecialName]
		[Cpp2IlInjected.Token(Token = "0x60000C1")]
		[Cpp2IlInjected.Address(RVA = "0x7A61D90", Offset = "0x7A60B90", VA = "0x187A61D90")]
		public static bool CQBJVGKOTGK(SubscriptionDetails a, SubscriptionDetails b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000C2")]
		[Cpp2IlInjected.Address(RVA = "0x7A620C0", Offset = "0x7A60EC0", VA = "0x187A620C0", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200001F")]
	public readonly struct SubscriptionSnapshot : IEquatable<SubscriptionSnapshot>
	{
		[Cpp2IlInjected.Token(Token = "0x400004A")]
		public static readonly SubscriptionSnapshot None;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004B")]
		public readonly bool IsValid;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1")]
		[Cpp2IlInjected.Token(Token = "0x400004C")]
		public readonly SubscriptionStatus SubscriptionStatus;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400004D")]
		public readonly SubscriptionDetails SubscriptionDetails;

		[Cpp2IlInjected.Token(Token = "0x60000C3")]
		[Cpp2IlInjected.Address(RVA = "0x7A62850", Offset = "0x7A61650", VA = "0x187A62850")]
		public SubscriptionSnapshot(SubscriptionStatus subscriptionStatus, SubscriptionDetails subscriptionDetails)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C4")]
		[Cpp2IlInjected.Address(RVA = "0x7A623C0", Offset = "0x7A611C0", VA = "0x187A623C0", Slot = "4")]
		public bool Equals(SubscriptionSnapshot other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000C5")]
		[Cpp2IlInjected.Address(RVA = "0x7A62470", Offset = "0x7A61270", VA = "0x187A62470", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000C6")]
		[Cpp2IlInjected.Address(RVA = "0x7A626B0", Offset = "0x7A614B0", VA = "0x187A626B0", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[SpecialName]
		[Cpp2IlInjected.Token(Token = "0x60000C7")]
		[Cpp2IlInjected.Address(RVA = "0x7A625A0", Offset = "0x7A613A0", VA = "0x187A625A0")]
		public static bool GFBRUTYEXQF(SubscriptionSnapshot a, SubscriptionSnapshot b)
		{
			return default(bool);
		}

		[SpecialName]
		[Cpp2IlInjected.Token(Token = "0x60000C8")]
		[Cpp2IlInjected.Address(RVA = "0x7A622A0", Offset = "0x7A610A0", VA = "0x187A622A0")]
		public static bool CQBJVGKOTGK(SubscriptionSnapshot a, SubscriptionSnapshot b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000C9")]
		[Cpp2IlInjected.Address(RVA = "0x7A62770", Offset = "0x7A61570", VA = "0x187A62770", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000020")]
	public enum SubscriptionStatus : byte
	{
		[Cpp2IlInjected.Token(Token = "0x400004F")]
		None,
		[Cpp2IlInjected.Token(Token = "0x4000050")]
		Expired,
		[Cpp2IlInjected.Token(Token = "0x4000051")]
		Active
	}
	[Cpp2IlInjected.Token(Token = "0x2000021")]
	public class QSKKFISXVGQ : FMNIXJKWAVU
	{
		[Cpp2IlInjected.Token(Token = "0x4000052")]
		public const string HKPFFIZAVJY = "ServerTime";

		[Cpp2IlInjected.Token(Token = "0x4000053")]
		private static readonly Stopwatch QFLJWQWVSEJ;

		[Cpp2IlInjected.Token(Token = "0x4000054")]
		private static DateTimeOffset? ASUGTHJHHFX;

		[Cpp2IlInjected.Token(Token = "0x4000055")]
		private static readonly QSKKFISXVGQ VUSGKOYVZZO;

		[Cpp2IlInjected.Token(Token = "0x17000046")]
		public static FMNIXJKWAVU GUIRZRNRSLG
		{
			[Cpp2IlInjected.Token(Token = "0x60000CB")]
			[Cpp2IlInjected.Address(RVA = "0x7A5FDD0", Offset = "0x7A5EBD0", VA = "0x187A5FDD0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000047")]
		internal static QSKKFISXVGQ JSSJCUNLCVH
		{
			[Cpp2IlInjected.Token(Token = "0x60000CC")]
			[Cpp2IlInjected.Address(RVA = "0x7A60340", Offset = "0x7A5F140", VA = "0x187A60340")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000048")]
		public static DateTimeOffset OTXEUYYBOXT
		{
			[Cpp2IlInjected.Token(Token = "0x60000CD")]
			[Cpp2IlInjected.Address(RVA = "0x7A5FE20", Offset = "0x7A5EC20", VA = "0x187A5FE20")]
			get
			{
				return default(DateTimeOffset);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000049")]
		public static DateTime PMVYIYZUTHM
		{
			[Cpp2IlInjected.Token(Token = "0x60000CE")]
			[Cpp2IlInjected.Address(RVA = "0x7A60190", Offset = "0x7A5EF90", VA = "0x187A60190")]
			get
			{
				return default(DateTime);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700004A")]
		public DateTime UMKJZYIDEUJ
		{
			[Cpp2IlInjected.Token(Token = "0x60000CF")]
			[Cpp2IlInjected.Address(RVA = "0x7A60220", Offset = "0x7A5F020", VA = "0x187A60220", Slot = "4")]
			get
			{
				return default(DateTime);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700004B")]
		public DateTimeOffset NQPQJYZJZWO
		{
			[Cpp2IlInjected.Token(Token = "0x60000D0")]
			[Cpp2IlInjected.Address(RVA = "0x7A602E0", Offset = "0x7A5F0E0", VA = "0x187A602E0", Slot = "5")]
			get
			{
				return default(DateTimeOffset);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000D1")]
		[Cpp2IlInjected.Address(RVA = "0xAC4840", Offset = "0xAC3640", VA = "0x180AC4840")]
		private QSKKFISXVGQ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D2")]
		[Cpp2IlInjected.Address(RVA = "0x7A5FF80", Offset = "0x7A5ED80", VA = "0x187A5FF80")]
		internal static void OXWTRONXJVY(DateTime? a)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000022")]
	public enum CustomAvatarItemPreviewOrientation
	{
		[Cpp2IlInjected.Token(Token = "0x4000057")]
		Front,
		[Cpp2IlInjected.Token(Token = "0x4000058")]
		Back
	}
	[Cpp2IlInjected.Token(Token = "0x2000023")]
	public enum CustomAvatarItemSource
	{
		[Cpp2IlInjected.Token(Token = "0x400005A")]
		AnimatedPuppet,
		[Cpp2IlInjected.Token(Token = "0x400005B")]
		Imposter
	}
	[Cpp2IlInjected.Token(Token = "0x2000024")]
	[Utf8JsonSerializable]
	public class CustomAvatarItem : LEAFOUXJKMH, NSVNCQQULFO, IRecNetUtf8JsonObject, IRecNetUtf8JsonObjectPerformsPostProcessing, WNRHSJCQDZB
	{
		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x2000025")]
		[CompilerGenerated]
		private struct <OnPostDeserialized>d__87 : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000071")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x4000072")]
			public AsyncTaskMethodBuilder <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000073")]
			public CustomAvatarItem <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000074")]
			private ConfiguredTaskAwaitable<string>.ConfiguredTaskAwaiter <>u__1;

			[Cpp2IlInjected.Token(Token = "0x600010C")]
			[Cpp2IlInjected.Address(RVA = "0x7A63100", Offset = "0x7A61F00", VA = "0x187A63100", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600010D")]
			[Cpp2IlInjected.Address(RVA = "0x7A634A0", Offset = "0x7A622A0", VA = "0x187A634A0", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000070")]
		[IgnoreDataMember]
		public static NZNQCQEACIC RecNetPlatformAccess;

		[Cpp2IlInjected.Token(Token = "0x1700004C")]
		public Guid CustomAvatarItemId
		{
			[Cpp2IlInjected.Token(Token = "0x60000D4")]
			[Cpp2IlInjected.Address(RVA = "0xEC6860", Offset = "0xEC5660", VA = "0x180EC6860", Slot = "38")]
			[CompilerGenerated]
			get
			{
				return default(Guid);
			}
			[Cpp2IlInjected.Token(Token = "0x60000D5")]
			[Cpp2IlInjected.Address(RVA = "0xEC6880", Offset = "0xEC5680", VA = "0x180EC6880")]
			[CompilerGenerated]
			internal set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700004D")]
		public int CreatorAccountId
		{
			[Cpp2IlInjected.Token(Token = "0x60000D6")]
			[Cpp2IlInjected.Address(RVA = "0xACF4D0", Offset = "0xACE2D0", VA = "0x180ACF4D0", Slot = "39")]
			[CompilerGenerated]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x60000D7")]
			[Cpp2IlInjected.Address(RVA = "0xB20FD0", Offset = "0xB1FDD0", VA = "0x180B20FD0")]
			[CompilerGenerated]
			internal set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700004E")]
		public string Name
		{
			[Cpp2IlInjected.Token(Token = "0x60000D8")]
			[Cpp2IlInjected.Address(RVA = "0xAC0F90", Offset = "0xABFD90", VA = "0x180AC0F90", Slot = "40")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60000D9")]
			[Cpp2IlInjected.Address(RVA = "0xAC0650", Offset = "0xABF450", VA = "0x180AC0650")]
			[CompilerGenerated]
			internal set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700004F")]
		public string Description
		{
			[Cpp2IlInjected.Token(Token = "0x60000DA")]
			[Cpp2IlInjected.Address(RVA = "0xAC0F80", Offset = "0xABFD80", VA = "0x180AC0F80", Slot = "7")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60000DB")]
			[Cpp2IlInjected.Address(RVA = "0xAC8C50", Offset = "0xAC7A50", VA = "0x180AC8C50")]
			[CompilerGenerated]
			internal set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000050")]
		public int Price
		{
			[Cpp2IlInjected.Token(Token = "0x60000DC")]
			[Cpp2IlInjected.Address(RVA = "0xAEE0C0", Offset = "0xAECEC0", VA = "0x180AEE0C0", Slot = "8")]
			[CompilerGenerated]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x60000DD")]
			[Cpp2IlInjected.Address(RVA = "0xE1B620", Offset = "0xE1A420", VA = "0x180E1B620")]
			[CompilerGenerated]
			internal set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000051")]
		public UgcAccessibility Accessibility
		{
			[Cpp2IlInjected.Token(Token = "0x60000DE")]
			[Cpp2IlInjected.Address(RVA = "0xAFE430", Offset = "0xAFD230", VA = "0x180AFE430", Slot = "44")]
			[CompilerGenerated]
			get
			{
				return default(UgcAccessibility);
			}
			[Cpp2IlInjected.Token(Token = "0x60000DF")]
			[Cpp2IlInjected.Address(RVA = "0xAFD5C0", Offset = "0xAFC3C0", VA = "0x180AFD5C0")]
			[CompilerGenerated]
			internal set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000052")]
		public bool ForceCannotPublish
		{
			[Cpp2IlInjected.Token(Token = "0x60000E0")]
			[Cpp2IlInjected.Address(RVA = "0xF7B8E0", Offset = "0xF7A6E0", VA = "0x180F7B8E0", Slot = "10")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x60000E1")]
			[Cpp2IlInjected.Address(RVA = "0xF7B4A0", Offset = "0xF7A2A0", VA = "0x180F7B4A0")]
			[CompilerGenerated]
			internal set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000053")]
		public bool IsFeatured
		{
			[Cpp2IlInjected.Token(Token = "0x60000E2")]
			[Cpp2IlInjected.Address(RVA = "0x15A35D0", Offset = "0x15A23D0", VA = "0x1815A35D0", Slot = "28")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x60000E3")]
			[Cpp2IlInjected.Address(RVA = "0x15A2FF0", Offset = "0x15A1DF0", VA = "0x1815A2FF0")]
			[CompilerGenerated]
			internal set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000054")]
		public bool IsRecRoomApproved
		{
			[Cpp2IlInjected.Token(Token = "0x60000E4")]
			[Cpp2IlInjected.Address(RVA = "0x7A5AB00", Offset = "0x7A59900", VA = "0x187A5AB00", Slot = "41")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x60000E5")]
			[Cpp2IlInjected.Address(RVA = "0x22AA560", Offset = "0x22A9360", VA = "0x1822AA560")]
			[CompilerGenerated]
			internal set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000055")]
		public int? BaseAvatarItemId
		{
			[Cpp2IlInjected.Token(Token = "0x60000E6")]
			[Cpp2IlInjected.Address(RVA = "0x4AE4FA0", Offset = "0x4AE3DA0", VA = "0x184AE4FA0", Slot = "43")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60000E7")]
			[Cpp2IlInjected.Address(RVA = "0x7A5AB10", Offset = "0x7A59910", VA = "0x187A5AB10", Slot = "14")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000056")]
		public string BaseAvatarItemColor
		{
			[Cpp2IlInjected.Token(Token = "0x60000E8")]
			[Cpp2IlInjected.Address(RVA = "0xAC31E0", Offset = "0xAC1FE0", VA = "0x180AC31E0", Slot = "15")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60000E9")]
			[Cpp2IlInjected.Address(RVA = "0xAC31C0", Offset = "0xAC1FC0", VA = "0x180AC31C0")]
			[CompilerGenerated]
			internal set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000057")]
		public string DesignFilename
		{
			[Cpp2IlInjected.Token(Token = "0x60000EA")]
			[Cpp2IlInjected.Address(RVA = "0xAC3430", Offset = "0xAC2230", VA = "0x180AC3430", Slot = "16")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60000EB")]
			[Cpp2IlInjected.Address(RVA = "0xAC31B0", Offset = "0xAC1FB0", VA = "0x180AC31B0")]
			[CompilerGenerated]
			internal set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000058")]
		public string ThumbnailImageFilename
		{
			[Cpp2IlInjected.Token(Token = "0x60000EC")]
			[Cpp2IlInjected.Address(RVA = "0xAC31D0", Offset = "0xAC1FD0", VA = "0x180AC31D0", Slot = "27")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60000ED")]
			[Cpp2IlInjected.Address(RVA = "0xAC3420", Offset = "0xAC2220", VA = "0x180AC3420")]
			[CompilerGenerated]
			internal set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000059")]
		public DateTime CreatedAt
		{
			[Cpp2IlInjected.Token(Token = "0x60000EE")]
			[Cpp2IlInjected.Address(RVA = "0xAC3410", Offset = "0xAC2210", VA = "0x180AC3410", Slot = "18")]
			[CompilerGenerated]
			get
			{
				return default(DateTime);
			}
			[Cpp2IlInjected.Token(Token = "0x60000EF")]
			[Cpp2IlInjected.Address(RVA = "0xFF2F90", Offset = "0xFF1D90", VA = "0x180FF2F90")]
			[CompilerGenerated]
			internal set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700005A")]
		public DateTime ModifiedAt
		{
			[Cpp2IlInjected.Token(Token = "0x60000F0")]
			[Cpp2IlInjected.Address(RVA = "0xAC50D0", Offset = "0xAC3ED0", VA = "0x180AC50D0", Slot = "19")]
			[CompilerGenerated]
			get
			{
				return default(DateTime);
			}
			[Cpp2IlInjected.Token(Token = "0x60000F1")]
			[Cpp2IlInjected.Address(RVA = "0xFF2C50", Offset = "0xFF1A50", VA = "0x180FF2C50")]
			[CompilerGenerated]
			internal set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700005B")]
		public CustomAvatarItemPreviewOrientation PreviewOrientation
		{
			[Cpp2IlInjected.Token(Token = "0x60000F2")]
			[Cpp2IlInjected.Address(RVA = "0xAE56C0", Offset = "0xAE44C0", VA = "0x180AE56C0", Slot = "20")]
			[CompilerGenerated]
			get
			{
				return default(CustomAvatarItemPreviewOrientation);
			}
			[Cpp2IlInjected.Token(Token = "0x60000F3")]
			[Cpp2IlInjected.Address(RVA = "0x15F6100", Offset = "0x15F4F00", VA = "0x1815F6100")]
			[CompilerGenerated]
			internal set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700005C")]
		public string RankingContext
		{
			[Cpp2IlInjected.Token(Token = "0x60000F4")]
			[Cpp2IlInjected.Address(RVA = "0xAC7AA0", Offset = "0xAC68A0", VA = "0x180AC7AA0", Slot = "21")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60000F5")]
			[Cpp2IlInjected.Address(RVA = "0xAC8140", Offset = "0xAC6F40", VA = "0x180AC8140")]
			[CompilerGenerated]
			internal set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700005D")]
		public int OutfitType
		{
			[Cpp2IlInjected.Token(Token = "0x60000F6")]
			[Cpp2IlInjected.Address(RVA = "0xD857B0", Offset = "0xD845B0", VA = "0x180D857B0", Slot = "42")]
			[CompilerGenerated]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x60000F7")]
			[Cpp2IlInjected.Address(RVA = "0x1617730", Offset = "0x1616530", VA = "0x181617730")]
			[CompilerGenerated]
			internal set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700005E")]
		public IReadOnlyList<CustomAvatarItemSaveDTO> CurrentSaves
		{
			[Cpp2IlInjected.Token(Token = "0x60000F8")]
			[Cpp2IlInjected.Address(RVA = "0xAEDD70", Offset = "0xAECB70", VA = "0x180AEDD70")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60000F9")]
			[Cpp2IlInjected.Address(RVA = "0xB880F0", Offset = "0xB86EF0", VA = "0x180B880F0")]
			[CompilerGenerated]
			internal set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700005F")]
		public IReadOnlyList<WESGMYVWMPU> Saves
		{
			[Cpp2IlInjected.Token(Token = "0x60000FA")]
			[Cpp2IlInjected.Address(RVA = "0xAEDD70", Offset = "0xAECB70", VA = "0x180AEDD70", Slot = "37")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000060")]
		public ItemPurchaseInfoDTO PurchaseInfo
		{
			[Cpp2IlInjected.Token(Token = "0x60000FB")]
			[Cpp2IlInjected.Address(RVA = "0xAC7A60", Offset = "0xAC6860", VA = "0x180AC7A60")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60000FC")]
			[Cpp2IlInjected.Address(RVA = "0xAC7AB0", Offset = "0xAC68B0", VA = "0x180AC7AB0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000061")]
		public string RankedEntityId
		{
			[Cpp2IlInjected.Token(Token = "0x60000FD")]
			[Cpp2IlInjected.Address(RVA = "0x7A5AAE0", Offset = "0x7A598E0", VA = "0x187A5AAE0", Slot = "23")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000062")]
		public UnifiedItemType ItemType
		{
			[Cpp2IlInjected.Token(Token = "0x6000103")]
			[Cpp2IlInjected.Address(RVA = "0xC4F2E0", Offset = "0xC4E0E0", VA = "0x180C4F2E0", Slot = "24")]
			get
			{
				return default(UnifiedItemType);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000063")]
		public string Id
		{
			[Cpp2IlInjected.Token(Token = "0x6000104")]
			[Cpp2IlInjected.Address(RVA = "0x7A5AAE0", Offset = "0x7A598E0", VA = "0x187A5AAE0", Slot = "25")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000064")]
		public string FriendlyName
		{
			[Cpp2IlInjected.Token(Token = "0x6000105")]
			[Cpp2IlInjected.Address(RVA = "0xAC0F90", Offset = "0xABFD90", VA = "0x180AC0F90", Slot = "26")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000065")]
		public bool SubscribersOnly
		{
			[Cpp2IlInjected.Token(Token = "0x6000106")]
			[Cpp2IlInjected.Address(RVA = "0xB07AA0", Offset = "0xB068A0", VA = "0x180B07AA0", Slot = "29")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000066")]
		public GiftRarity Rarity
		{
			[Cpp2IlInjected.Token(Token = "0x6000107")]
			[Cpp2IlInjected.Address(RVA = "0xB0DD60", Offset = "0xB0CB60", VA = "0x180B0DD60", Slot = "30")]
			get
			{
				return default(GiftRarity);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000067")]
		public string ConsumableItemDesc
		{
			[Cpp2IlInjected.Token(Token = "0x6000108")]
			[Cpp2IlInjected.Address(RVA = "0xABE8E0", Offset = "0xABD6E0", VA = "0x180ABE8E0", Slot = "31")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000068")]
		public AvatarItemType? AvatarItemType
		{
			[Cpp2IlInjected.Token(Token = "0x6000109")]
			[Cpp2IlInjected.Address(RVA = "0x7A5AA90", Offset = "0x7A59890", VA = "0x187A5AA90", Slot = "32")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000069")]
		public GiftBoxContents GiftBoxContent
		{
			[Cpp2IlInjected.Token(Token = "0x600010A")]
			[Cpp2IlInjected.Address(RVA = "0xC4F2E0", Offset = "0xC4E0E0", VA = "0x180C4F2E0", Slot = "33")]
			get
			{
				return default(GiftBoxContents);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700006A")]
		public bool IsQueryGiftDrop
		{
			[Cpp2IlInjected.Token(Token = "0x600010B")]
			[Cpp2IlInjected.Address(RVA = "0xB07AA0", Offset = "0xB068A0", VA = "0x180B07AA0", Slot = "34")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000FE")]
		[Cpp2IlInjected.Address(RVA = "0xAC4840", Offset = "0xAC3640", VA = "0x180AC4840")]
		public CustomAvatarItem()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000FF")]
		[Cpp2IlInjected.Address(RVA = "0x10F2410", Offset = "0x10F1210", VA = "0x1810F2410")]
		public CustomAvatarItem([Optional] Guid customAvatarItemId)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000100")]
		[Cpp2IlInjected.Address(RVA = "0x7A5A810", Offset = "0x7A59610", VA = "0x187A5A810", Slot = "35")]
		public void DNRPRHFLPRB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000101")]
		[Cpp2IlInjected.Address(RVA = "0x7A5A9C0", Offset = "0x7A597C0", VA = "0x187A5A9C0", Slot = "36")]
		[AsyncStateMachine(typeof(<OnPostDeserialized>d__87))]
		public Task WSLKELMBPUB()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000102")]
		[Cpp2IlInjected.Address(RVA = "0x7A5A7A0", Offset = "0x7A595A0", VA = "0x187A5A7A0")]
		public CustomAvatarItem Copy()
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000026")]
	[Utf8JsonSerializable]
	public class CustomAvatarItemCreateRequest : IRecNetUtf8JsonObject
	{
		[Cpp2IlInjected.Token(Token = "0x1700006B")]
		public string Name
		{
			[Cpp2IlInjected.Token(Token = "0x600010E")]
			[Cpp2IlInjected.Address(RVA = "0xABD130", Offset = "0xABBF30", VA = "0x180ABD130")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600010F")]
			[Cpp2IlInjected.Address(RVA = "0xABD120", Offset = "0xABBF20", VA = "0x180ABD120")]
			[CompilerGenerated]
			internal set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700006C")]
		public string Description
		{
			[Cpp2IlInjected.Token(Token = "0x6000110")]
			[Cpp2IlInjected.Address(RVA = "0xAC0D20", Offset = "0xABFB20", VA = "0x180AC0D20")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000111")]
			[Cpp2IlInjected.Address(RVA = "0xAC0D10", Offset = "0xABFB10", VA = "0x180AC0D10")]
			[CompilerGenerated]
			internal set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700006D")]
		public int Price
		{
			[Cpp2IlInjected.Token(Token = "0x6000112")]
			[Cpp2IlInjected.Address(RVA = "0xACF4D0", Offset = "0xACE2D0", VA = "0x180ACF4D0")]
			[CompilerGenerated]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x6000113")]
			[Cpp2IlInjected.Address(RVA = "0xB20FD0", Offset = "0xB1FDD0", VA = "0x180B20FD0")]
			[CompilerGenerated]
			internal set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700006E")]
		public int? BaseAvatarItemId
		{
			[Cpp2IlInjected.Token(Token = "0x6000114")]
			[Cpp2IlInjected.Address(RVA = "0x13E8E70", Offset = "0x13E7C70", VA = "0x1813E8E70")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000115")]
			[Cpp2IlInjected.Address(RVA = "0x10D56B0", Offset = "0x10D44B0", VA = "0x1810D56B0")]
			[CompilerGenerated]
			internal set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700006F")]
		public string BaseAvatarItemColor
		{
			[Cpp2IlInjected.Token(Token = "0x6000116")]
			[Cpp2IlInjected.Address(RVA = "0xAC0F80", Offset = "0xABFD80", VA = "0x180AC0F80")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000117")]
			[Cpp2IlInjected.Address(RVA = "0xAC8C50", Offset = "0xAC7A50", VA = "0x180AC8C50")]
			[CompilerGenerated]
			internal set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000070")]
		public UgcAccessibility Accessibility
		{
			[Cpp2IlInjected.Token(Token = "0x6000118")]
			[Cpp2IlInjected.Address(RVA = "0xAEE0C0", Offset = "0xAECEC0", VA = "0x180AEE0C0")]
			[CompilerGenerated]
			get
			{
				return default(UgcAccessibility);
			}
			[Cpp2IlInjected.Token(Token = "0x6000119")]
			[Cpp2IlInjected.Address(RVA = "0xE1B620", Offset = "0xE1A420", VA = "0x180E1B620")]
			[CompilerGenerated]
			internal set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000071")]
		public CustomAvatarItemPreviewOrientation? PreviewOrientation
		{
			[Cpp2IlInjected.Token(Token = "0x600011A")]
			[Cpp2IlInjected.Address(RVA = "0xB0B530", Offset = "0xB0A330", VA = "0x180B0B530")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600011B")]
			[Cpp2IlInjected.Address(RVA = "0xB0B540", Offset = "0xB0A340", VA = "0x180B0B540")]
			[CompilerGenerated]
			internal set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600011C")]
		[Cpp2IlInjected.Address(RVA = "0xABE8D0", Offset = "0xABD6D0", VA = "0x180ABE8D0", Slot = "4")]
		public void DNRPRHFLPRB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600011D")]
		[Cpp2IlInjected.Address(RVA = "0xAC4840", Offset = "0xAC3640", VA = "0x180AC4840")]
		public CustomAvatarItemCreateRequest()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000027")]
	[Utf8JsonSerializable]
	public class CustomAvatarItemDesign : IRecNetUtf8JsonObject
	{
		[Cpp2IlInjected.Token(Token = "0x17000072")]
		public int CreatorAccountId
		{
			[Cpp2IlInjected.Token(Token = "0x600011E")]
			[Cpp2IlInjected.Address(RVA = "0xABD110", Offset = "0xABBF10", VA = "0x180ABD110")]
			[CompilerGenerated]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x600011F")]
			[Cpp2IlInjected.Address(RVA = "0xAC1D40", Offset = "0xAC0B40", VA = "0x180AC1D40")]
			[CompilerGenerated]
			internal set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000073")]
		public int? BaseAvatarItemId
		{
			[Cpp2IlInjected.Token(Token = "0x6000120")]
			[Cpp2IlInjected.Address(RVA = "0x13E8E30", Offset = "0x13E7C30", VA = "0x1813E8E30")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000121")]
			[Cpp2IlInjected.Address(RVA = "0x13EA240", Offset = "0x13E9040", VA = "0x1813EA240")]
			[CompilerGenerated]
			internal set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000074")]
		public string DesignFilename
		{
			[Cpp2IlInjected.Token(Token = "0x6000122")]
			[Cpp2IlInjected.Address(RVA = "0xAC1D20", Offset = "0xAC0B20", VA = "0x180AC1D20")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000123")]
			[Cpp2IlInjected.Address(RVA = "0xAC0640", Offset = "0xABF440", VA = "0x180AC0640")]
			[CompilerGenerated]
			internal set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000075")]
		public string BaseAvatarItemColor
		{
			[Cpp2IlInjected.Token(Token = "0x6000124")]
			[Cpp2IlInjected.Address(RVA = "0xAC0F90", Offset = "0xABFD90", VA = "0x180AC0F90")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000125")]
			[Cpp2IlInjected.Address(RVA = "0xAC0650", Offset = "0xABF450", VA = "0x180AC0650")]
			[CompilerGenerated]
			internal set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000126")]
		[Cpp2IlInjected.Address(RVA = "0xABE8D0", Offset = "0xABD6D0", VA = "0x180ABE8D0", Slot = "4")]
		public void DNRPRHFLPRB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000127")]
		[Cpp2IlInjected.Address(RVA = "0xAC4840", Offset = "0xAC3640", VA = "0x180AC4840")]
		public CustomAvatarItemDesign()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000028")]
	[Utf8JsonSerializable]
	public class CustomAvatarItemDesignRequest : IRecNetUtf8JsonObject
	{
		[Cpp2IlInjected.Token(Token = "0x17000076")]
		public int? BaseAvatarItemId
		{
			[Cpp2IlInjected.Token(Token = "0x6000128")]
			[Cpp2IlInjected.Address(RVA = "0xABD130", Offset = "0xABBF30", VA = "0x180ABD130")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000129")]
			[Cpp2IlInjected.Address(RVA = "0xEABA00", Offset = "0xEAA800", VA = "0x180EABA00")]
			[CompilerGenerated]
			internal set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000077")]
		public string BaseAvatarItemColor
		{
			[Cpp2IlInjected.Token(Token = "0x600012A")]
			[Cpp2IlInjected.Address(RVA = "0xAC0D20", Offset = "0xABFB20", VA = "0x180AC0D20")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600012B")]
			[Cpp2IlInjected.Address(RVA = "0xAC0D10", Offset = "0xABFB10", VA = "0x180AC0D10")]
			[CompilerGenerated]
			internal set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600012C")]
		[Cpp2IlInjected.Address(RVA = "0xABE8D0", Offset = "0xABD6D0", VA = "0x180ABE8D0", Slot = "4")]
		public void DNRPRHFLPRB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600012D")]
		[Cpp2IlInjected.Address(RVA = "0xAC4840", Offset = "0xAC3640", VA = "0x180AC4840")]
		public CustomAvatarItemDesignRequest()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000029")]
	public struct CustomAvatarItemPricingConfig
	{
		[Cpp2IlInjected.Token(Token = "0x4000082")]
		public static int DEFAULT_MIN_TOKEN_PRICE;

		[Cpp2IlInjected.Token(Token = "0x4000083")]
		public static int DEFAULT_MAX_TOKEN_PRICE;

		[Cpp2IlInjected.Token(Token = "0x17000078")]
		public int MinimumPrice
		{
			[Cpp2IlInjected.Token(Token = "0x600012E")]
			[Cpp2IlInjected.Address(RVA = "0xDB2230", Offset = "0xDB1030", VA = "0x180DB2230")]
			[CompilerGenerated]
			readonly get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x600012F")]
			[Cpp2IlInjected.Address(RVA = "0x15B1800", Offset = "0x15B0600", VA = "0x1815B1800")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000079")]
		public int MaximumPrice
		{
			[Cpp2IlInjected.Token(Token = "0x6000130")]
			[Cpp2IlInjected.Address(RVA = "0x30206B0", Offset = "0x301F4B0", VA = "0x1830206B0")]
			[CompilerGenerated]
			readonly get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x6000131")]
			[Cpp2IlInjected.Address(RVA = "0x30206C0", Offset = "0x301F4C0", VA = "0x1830206C0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700007A")]
		public static CustomAvatarItemPricingConfig GUTFKAZYITC
		{
			[Cpp2IlInjected.Token(Token = "0x6000133")]
			[Cpp2IlInjected.Address(RVA = "0x7A5A620", Offset = "0x7A59420", VA = "0x187A5A620")]
			get
			{
				return default(CustomAvatarItemPricingConfig);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000132")]
		[Cpp2IlInjected.Address(RVA = "0x7A5A6D0", Offset = "0x7A594D0", VA = "0x187A5A6D0")]
		public CustomAvatarItemPricingConfig(int minimumTokenPrice, int maximumTokenPrice)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200002A")]
	[Utf8JsonSerializable]
	public class CustomAvatarItemPricingConfigDTO : IRecNetUtf8JsonObject
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000086")]
		public int MinimumPriceInTokens;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x4000087")]
		public int MaximumPriceInTokens;

		[Cpp2IlInjected.Token(Token = "0x6000135")]
		[Cpp2IlInjected.Address(RVA = "0xABE8D0", Offset = "0xABD6D0", VA = "0x180ABE8D0", Slot = "4")]
		public void DNRPRHFLPRB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000136")]
		[Cpp2IlInjected.Address(RVA = "0xAC4840", Offset = "0xAC3640", VA = "0x180AC4840")]
		public CustomAvatarItemPricingConfigDTO()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200002B")]
	[Utf8JsonSerializable]
	public class CustomAvatarItemPurchaseRequest : IRecNetUtf8JsonObject
	{
		[Cpp2IlInjected.Token(Token = "0x1700007B")]
		public int RequestedPrice
		{
			[Cpp2IlInjected.Token(Token = "0x6000137")]
			[Cpp2IlInjected.Address(RVA = "0xABD110", Offset = "0xABBF10", VA = "0x180ABD110")]
			[CompilerGenerated]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x6000138")]
			[Cpp2IlInjected.Address(RVA = "0xAC1D40", Offset = "0xAC0B40", VA = "0x180AC1D40")]
			[CompilerGenerated]
			internal set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700007C")]
		public int? RecipientAccountId
		{
			[Cpp2IlInjected.Token(Token = "0x6000139")]
			[Cpp2IlInjected.Address(RVA = "0x13E8E30", Offset = "0x13E7C30", VA = "0x1813E8E30")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600013A")]
			[Cpp2IlInjected.Address(RVA = "0x13EA240", Offset = "0x13E9040", VA = "0x1813EA240")]
			[CompilerGenerated]
			internal set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700007D")]
		public string? Message
		{
			[Cpp2IlInjected.Token(Token = "0x600013B")]
			[Cpp2IlInjected.Address(RVA = "0xAC1D20", Offset = "0xAC0B20", VA = "0x180AC1D20")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600013C")]
			[Cpp2IlInjected.Address(RVA = "0xAC0640", Offset = "0xABF440", VA = "0x180AC0640")]
			[CompilerGenerated]
			internal set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600013D")]
		[Cpp2IlInjected.Address(RVA = "0x7A5A730", Offset = "0x7A59530", VA = "0x187A5A730")]
		public CustomAvatarItemPurchaseRequest(int requestedPrice, int? recipientAccountId, string? message)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600013E")]
		[Cpp2IlInjected.Address(RVA = "0xAC4840", Offset = "0xAC3640", VA = "0x180AC4840")]
		public CustomAvatarItemPurchaseRequest()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600013F")]
		[Cpp2IlInjected.Address(RVA = "0xABE8D0", Offset = "0xABD6D0", VA = "0x180ABE8D0", Slot = "4")]
		public void DNRPRHFLPRB()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200002C")]
	[Utf8JsonSerializable]
	public class CustomAvatarItemReportRequest : IRecNetUtf8JsonObject
	{
		[Cpp2IlInjected.Token(Token = "0x1700007E")]
		public ZZGUTIMJBOP.UgcReportCategory ReportCategory
		{
			[Cpp2IlInjected.Token(Token = "0x6000140")]
			[Cpp2IlInjected.Address(RVA = "0xABD110", Offset = "0xABBF10", VA = "0x180ABD110")]
			[CompilerGenerated]
			get
			{
				return default(ZZGUTIMJBOP.UgcReportCategory);
			}
			[Cpp2IlInjected.Token(Token = "0x6000141")]
			[Cpp2IlInjected.Address(RVA = "0xAC1D40", Offset = "0xAC0B40", VA = "0x180AC1D40")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700007F")]
		public string Details
		{
			[Cpp2IlInjected.Token(Token = "0x6000142")]
			[Cpp2IlInjected.Address(RVA = "0xAC0D20", Offset = "0xABFB20", VA = "0x180AC0D20")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000143")]
			[Cpp2IlInjected.Address(RVA = "0xAC0D10", Offset = "0xABFB10", VA = "0x180AC0D10")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000080")]
		public int? ReportedPlayerId
		{
			[Cpp2IlInjected.Token(Token = "0x6000144")]
			[Cpp2IlInjected.Address(RVA = "0xAC1D20", Offset = "0xAC0B20", VA = "0x180AC1D20")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000145")]
			[Cpp2IlInjected.Address(RVA = "0xE33D40", Offset = "0xE32B40", VA = "0x180E33D40")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000146")]
		[Cpp2IlInjected.Address(RVA = "0xABE8D0", Offset = "0xABD6D0", VA = "0x180ABE8D0", Slot = "4")]
		public void DNRPRHFLPRB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000147")]
		[Cpp2IlInjected.Address(RVA = "0xAC4840", Offset = "0xAC3640", VA = "0x180AC4840")]
		public CustomAvatarItemReportRequest()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200002D")]
	public interface WESGMYVWMPU
	{
		[Cpp2IlInjected.Token(Token = "0x17000081")]
		long CustomAvatarItemSaveId
		{
			[Cpp2IlInjected.Token(Token = "0x6000148")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000082")]
		Guid CustomAvatarItemId
		{
			[Cpp2IlInjected.Token(Token = "0x6000149")]
			[Cpp2IlInjected.Address(Slot = "1")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000083")]
		Guid UnityAssetId
		{
			[Cpp2IlInjected.Token(Token = "0x600014A")]
			[Cpp2IlInjected.Address(Slot = "2")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000084")]
		string ThumbnailFileName
		{
			[Cpp2IlInjected.Token(Token = "0x600014B")]
			[Cpp2IlInjected.Address(Slot = "3")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000085")]
		string AdditionalConfiguration
		{
			[Cpp2IlInjected.Token(Token = "0x600014C")]
			[Cpp2IlInjected.Address(Slot = "4")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000086")]
		int BodyType
		{
			[Cpp2IlInjected.Token(Token = "0x600014D")]
			[Cpp2IlInjected.Address(Slot = "5")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000087")]
		string UnityAsset
		{
			[Cpp2IlInjected.Token(Token = "0x600014E")]
			[Cpp2IlInjected.Address(Slot = "6")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000088")]
		string UnityAssetHash
		{
			[Cpp2IlInjected.Token(Token = "0x600014F")]
			[Cpp2IlInjected.Address(Slot = "7")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000089")]
		string UnityAsset2
		{
			[Cpp2IlInjected.Token(Token = "0x6000150")]
			[Cpp2IlInjected.Address(Slot = "8")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x1700008A")]
		string UnityAsset2Hash
		{
			[Cpp2IlInjected.Token(Token = "0x6000151")]
			[Cpp2IlInjected.Address(Slot = "9")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x1700008B")]
		int OutfitType
		{
			[Cpp2IlInjected.Token(Token = "0x6000152")]
			[Cpp2IlInjected.Address(Slot = "10")]
			get;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200002E")]
	[Utf8JsonSerializable]
	public class CustomAvatarItemSaveDTO : WESGMYVWMPU, IRecNetUtf8JsonObject
	{
		[Cpp2IlInjected.Token(Token = "0x1700008C")]
		public long CustomAvatarItemSaveId
		{
			[Cpp2IlInjected.Token(Token = "0x6000153")]
			[Cpp2IlInjected.Address(RVA = "0xABD130", Offset = "0xABBF30", VA = "0x180ABD130", Slot = "4")]
			[CompilerGenerated]
			get
			{
				return default(long);
			}
			[Cpp2IlInjected.Token(Token = "0x6000154")]
			[Cpp2IlInjected.Address(RVA = "0xEABA00", Offset = "0xEAA800", VA = "0x180EABA00")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700008D")]
		public Guid CustomAvatarItemId
		{
			[Cpp2IlInjected.Token(Token = "0x6000155")]
			[Cpp2IlInjected.Address(RVA = "0xBED410", Offset = "0xBEC210", VA = "0x180BED410", Slot = "5")]
			[CompilerGenerated]
			get
			{
				return default(Guid);
			}
			[Cpp2IlInjected.Token(Token = "0x6000156")]
			[Cpp2IlInjected.Address(RVA = "0xF76460", Offset = "0xF75260", VA = "0x180F76460")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700008E")]
		public Guid UnityAssetId
		{
			[Cpp2IlInjected.Token(Token = "0x6000157")]
			[Cpp2IlInjected.Address(RVA = "0x143F690", Offset = "0x143E490", VA = "0x18143F690", Slot = "6")]
			[CompilerGenerated]
			get
			{
				return default(Guid);
			}
			[Cpp2IlInjected.Token(Token = "0x6000158")]
			[Cpp2IlInjected.Address(RVA = "0x159EF20", Offset = "0x159DD20", VA = "0x18159EF20")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700008F")]
		public DateTime CreatedAt
		{
			[Cpp2IlInjected.Token(Token = "0x6000159")]
			[Cpp2IlInjected.Address(RVA = "0xAC0FC0", Offset = "0xABFDC0", VA = "0x180AC0FC0")]
			[CompilerGenerated]
			get
			{
				return default(DateTime);
			}
			[Cpp2IlInjected.Token(Token = "0x600015A")]
			[Cpp2IlInjected.Address(RVA = "0xAC6570", Offset = "0xAC5370", VA = "0x180AC6570")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000090")]
		public string ThumbnailFileName
		{
			[Cpp2IlInjected.Token(Token = "0x600015B")]
			[Cpp2IlInjected.Address(RVA = "0xAC5120", Offset = "0xAC3F20", VA = "0x180AC5120", Slot = "7")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600015C")]
			[Cpp2IlInjected.Address(RVA = "0xAC0FB0", Offset = "0xABFDB0", VA = "0x180AC0FB0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000091")]
		public string AdditionalConfiguration
		{
			[Cpp2IlInjected.Token(Token = "0x600015D")]
			[Cpp2IlInjected.Address(RVA = "0xAC0D30", Offset = "0xABFB30", VA = "0x180AC0D30", Slot = "8")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600015E")]
			[Cpp2IlInjected.Address(RVA = "0xAC1370", Offset = "0xAC0170", VA = "0x180AC1370")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000092")]
		public int BodyType
		{
			[Cpp2IlInjected.Token(Token = "0x600015F")]
			[Cpp2IlInjected.Address(RVA = "0xECA790", Offset = "0xEC9590", VA = "0x180ECA790", Slot = "9")]
			[CompilerGenerated]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x6000160")]
			[Cpp2IlInjected.Address(RVA = "0x1A8D0D0", Offset = "0x1A8BED0", VA = "0x181A8D0D0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000093")]
		public string UnityAsset
		{
			[Cpp2IlInjected.Token(Token = "0x6000161")]
			[Cpp2IlInjected.Address(RVA = "0xAC3430", Offset = "0xAC2230", VA = "0x180AC3430", Slot = "10")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000162")]
			[Cpp2IlInjected.Address(RVA = "0xAC31B0", Offset = "0xAC1FB0", VA = "0x180AC31B0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000094")]
		public string UnityAssetHash
		{
			[Cpp2IlInjected.Token(Token = "0x6000163")]
			[Cpp2IlInjected.Address(RVA = "0xAC31D0", Offset = "0xAC1FD0", VA = "0x180AC31D0", Slot = "11")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000164")]
			[Cpp2IlInjected.Address(RVA = "0xAC3420", Offset = "0xAC2220", VA = "0x180AC3420")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000095")]
		public string UnityAsset2
		{
			[Cpp2IlInjected.Token(Token = "0x6000165")]
			[Cpp2IlInjected.Address(RVA = "0xAC3410", Offset = "0xAC2210", VA = "0x180AC3410", Slot = "12")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000166")]
			[Cpp2IlInjected.Address(RVA = "0xAC31A0", Offset = "0xAC1FA0", VA = "0x180AC31A0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000096")]
		public string UnityAsset2Hash
		{
			[Cpp2IlInjected.Token(Token = "0x6000167")]
			[Cpp2IlInjected.Address(RVA = "0xAC50D0", Offset = "0xAC3ED0", VA = "0x180AC50D0", Slot = "13")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000168")]
			[Cpp2IlInjected.Address(RVA = "0xAC58D0", Offset = "0xAC46D0", VA = "0x180AC58D0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000097")]
		public int OutfitType
		{
			[Cpp2IlInjected.Token(Token = "0x6000169")]
			[Cpp2IlInjected.Address(RVA = "0xAE56C0", Offset = "0xAE44C0", VA = "0x180AE56C0", Slot = "14")]
			[CompilerGenerated]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x600016A")]
			[Cpp2IlInjected.Address(RVA = "0x15F6100", Offset = "0x15F4F00", VA = "0x1815F6100")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600016B")]
		[Cpp2IlInjected.Address(RVA = "0xABE8D0", Offset = "0xABD6D0", VA = "0x180ABE8D0", Slot = "15")]
		public void DNRPRHFLPRB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600016C")]
		[Cpp2IlInjected.Address(RVA = "0xAC4840", Offset = "0xAC3640", VA = "0x180AC4840")]
		public CustomAvatarItemSaveDTO()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200002F")]
	[Flags]
	public enum CustomAvatarItemTypeFlags
	{
		[Cpp2IlInjected.Token(Token = "0x400009B")]
		None = 0,
		[Cpp2IlInjected.Token(Token = "0x400009C")]
		Shirt = 1,
		[Cpp2IlInjected.Token(Token = "0x400009D")]
		All = -1
	}
	[Cpp2IlInjected.Token(Token = "0x2000030")]
	public enum CustomAvatarItemSearchOrdering
	{
		[Cpp2IlInjected.Token(Token = "0x400009F")]
		SearchScoreDescending,
		[Cpp2IlInjected.Token(Token = "0x40000A0")]
		HotScoreDescending,
		[Cpp2IlInjected.Token(Token = "0x40000A1")]
		Newest,
		[Cpp2IlInjected.Token(Token = "0x40000A2")]
		Oldest,
		[Cpp2IlInjected.Token(Token = "0x40000A3")]
		PriceAscending,
		[Cpp2IlInjected.Token(Token = "0x40000A4")]
		PriceDescending,
		[Cpp2IlInjected.Token(Token = "0x40000A5")]
		FeaturedFirst
	}
	[Cpp2IlInjected.Token(Token = "0x2000031")]
	public static class ILTVGJJDDQK
	{
		[Cpp2IlInjected.Token(Token = "0x600016D")]
		[Cpp2IlInjected.Address(RVA = "0x7A5C5E0", Offset = "0x7A5B3E0", VA = "0x187A5C5E0")]
		public static int? IKGQGCAINWW(CustomAvatarItemTypeFlags? a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600016E")]
		[Cpp2IlInjected.Address(RVA = "0x7A5C670", Offset = "0x7A5B470", VA = "0x187A5C670")]
		public static int? SZBFSUMYSVD(CustomAvatarItemSearchOrdering? a)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000032")]
	[Utf8JsonSerializable]
	public class CustomAvatarItemSet : IRecNetUtf8JsonObject
	{
		[Cpp2IlInjected.Token(Token = "0x17000098")]
		public string Name
		{
			[Cpp2IlInjected.Token(Token = "0x600016F")]
			[Cpp2IlInjected.Address(RVA = "0xABD130", Offset = "0xABBF30", VA = "0x180ABD130")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000170")]
			[Cpp2IlInjected.Address(RVA = "0xABD120", Offset = "0xABBF20", VA = "0x180ABD120")]
			[CompilerGenerated]
			internal set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000099")]
		public long CreatorAccountId
		{
			[Cpp2IlInjected.Token(Token = "0x6000171")]
			[Cpp2IlInjected.Address(RVA = "0xAC0D20", Offset = "0xABFB20", VA = "0x180AC0D20")]
			[CompilerGenerated]
			get
			{
				return default(long);
			}
			[Cpp2IlInjected.Token(Token = "0x6000172")]
			[Cpp2IlInjected.Address(RVA = "0xE27A80", Offset = "0xE26880", VA = "0x180E27A80")]
			[CompilerGenerated]
			internal set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700009A")]
		public List<CustomAvatarItem> CustomAvatarItems
		{
			[Cpp2IlInjected.Token(Token = "0x6000173")]
			[Cpp2IlInjected.Address(RVA = "0xAC1D20", Offset = "0xAC0B20", VA = "0x180AC1D20")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000174")]
			[Cpp2IlInjected.Address(RVA = "0xAC0640", Offset = "0xABF440", VA = "0x180AC0640")]
			[CompilerGenerated]
			internal set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000175")]
		[Cpp2IlInjected.Address(RVA = "0x7A5A790", Offset = "0x7A59590", VA = "0x187A5A790", Slot = "4")]
		public void DNRPRHFLPRB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000176")]
		[Cpp2IlInjected.Address(RVA = "0xAC4840", Offset = "0xAC3640", VA = "0x180AC4840")]
		public CustomAvatarItemSet()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000033")]
	[Utf8JsonSerializable]
	public class CustomAvatarItemUpdateRequest : IRecNetUtf8JsonObject
	{
		[Cpp2IlInjected.Token(Token = "0x1700009B")]
		public string Name
		{
			[Cpp2IlInjected.Token(Token = "0x6000177")]
			[Cpp2IlInjected.Address(RVA = "0xABD130", Offset = "0xABBF30", VA = "0x180ABD130")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000178")]
			[Cpp2IlInjected.Address(RVA = "0xABD120", Offset = "0xABBF20", VA = "0x180ABD120")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700009C")]
		public string Description
		{
			[Cpp2IlInjected.Token(Token = "0x6000179")]
			[Cpp2IlInjected.Address(RVA = "0xAC0D20", Offset = "0xABFB20", VA = "0x180AC0D20")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600017A")]
			[Cpp2IlInjected.Address(RVA = "0xAC0D10", Offset = "0xABFB10", VA = "0x180AC0D10")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700009D")]
		public int? Price
		{
			[Cpp2IlInjected.Token(Token = "0x600017B")]
			[Cpp2IlInjected.Address(RVA = "0xAC1D20", Offset = "0xAC0B20", VA = "0x180AC1D20")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600017C")]
			[Cpp2IlInjected.Address(RVA = "0xE33D40", Offset = "0xE32B40", VA = "0x180E33D40")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700009E")]
		public UgcAccessibility? Accessibility
		{
			[Cpp2IlInjected.Token(Token = "0x600017D")]
			[Cpp2IlInjected.Address(RVA = "0xAC0F90", Offset = "0xABFD90", VA = "0x180AC0F90")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600017E")]
			[Cpp2IlInjected.Address(RVA = "0xAC0D00", Offset = "0xABFB00", VA = "0x180AC0D00")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600017F")]
		[Cpp2IlInjected.Address(RVA = "0xABE8D0", Offset = "0xABD6D0", VA = "0x180ABE8D0", Slot = "4")]
		public void DNRPRHFLPRB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000180")]
		[Cpp2IlInjected.Address(RVA = "0xAC4840", Offset = "0xAC3640", VA = "0x180AC4840")]
		public CustomAvatarItemUpdateRequest()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000034")]
	[Utf8JsonSerializable]
	public class CustomAvatarItemVisualData : DGCGJUHCULN, IRecNetUtf8JsonObject
	{
		[Cpp2IlInjected.Token(Token = "0x1700009F")]
		public Guid CustomAvatarItemId
		{
			[Cpp2IlInjected.Token(Token = "0x6000181")]
			[Cpp2IlInjected.Address(RVA = "0xEC6860", Offset = "0xEC5660", VA = "0x180EC6860")]
			[CompilerGenerated]
			get
			{
				return default(Guid);
			}
			[Cpp2IlInjected.Token(Token = "0x6000182")]
			[Cpp2IlInjected.Address(RVA = "0xEC6880", Offset = "0xEC5680", VA = "0x180EC6880")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000A0")]
		public byte BodyPart
		{
			[Cpp2IlInjected.Token(Token = "0x6000183")]
			[Cpp2IlInjected.Address(RVA = "0xAC1360", Offset = "0xAC0160", VA = "0x180AC1360")]
			[CompilerGenerated]
			get
			{
				return default(byte);
			}
			[Cpp2IlInjected.Token(Token = "0x6000184")]
			[Cpp2IlInjected.Address(RVA = "0xAC0FD0", Offset = "0xABFDD0", VA = "0x180AC0FD0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000185")]
		[Cpp2IlInjected.Address(RVA = "0xABE8D0", Offset = "0xABD6D0", VA = "0x180ABE8D0", Slot = "4")]
		public void DNRPRHFLPRB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000186")]
		[Cpp2IlInjected.Address(RVA = "0xAC4840", Offset = "0xAC3640", VA = "0x180AC4840")]
		public CustomAvatarItemVisualData()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000035")]
	public static class HZXJFCTKYRG
	{
		[Cpp2IlInjected.Token(Token = "0x6000187")]
		[Cpp2IlInjected.Address(RVA = "0x7A5C570", Offset = "0x7A5B370", VA = "0x187A5C570")]
		public static OutfitSelectionDTO JMAHJFCFJAR(this CustomAvatarItemVisualData a)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000036")]
	public interface LEAFOUXJKMH
	{
		[Cpp2IlInjected.Token(Token = "0x170000A1")]
		Guid CustomAvatarItemId
		{
			[Cpp2IlInjected.Token(Token = "0x6000188")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x170000A2")]
		int CreatorAccountId
		{
			[Cpp2IlInjected.Token(Token = "0x6000189")]
			[Cpp2IlInjected.Address(Slot = "1")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x170000A3")]
		string Name
		{
			[Cpp2IlInjected.Token(Token = "0x600018A")]
			[Cpp2IlInjected.Address(Slot = "2")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x170000A4")]
		string Description
		{
			[Cpp2IlInjected.Token(Token = "0x600018B")]
			[Cpp2IlInjected.Address(Slot = "3")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x170000A5")]
		int Price
		{
			[Cpp2IlInjected.Token(Token = "0x600018C")]
			[Cpp2IlInjected.Address(Slot = "4")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x170000A6")]
		UgcAccessibility Accessibility
		{
			[Cpp2IlInjected.Token(Token = "0x600018D")]
			[Cpp2IlInjected.Address(Slot = "5")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x170000A7")]
		bool ForceCannotPublish
		{
			[Cpp2IlInjected.Token(Token = "0x600018E")]
			[Cpp2IlInjected.Address(Slot = "6")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x170000A8")]
		bool IsFeatured
		{
			[Cpp2IlInjected.Token(Token = "0x600018F")]
			[Cpp2IlInjected.Address(Slot = "7")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x170000A9")]
		bool IsRecRoomApproved
		{
			[Cpp2IlInjected.Token(Token = "0x6000190")]
			[Cpp2IlInjected.Address(Slot = "8")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x170000AA")]
		int? BaseAvatarItemId
		{
			[Cpp2IlInjected.Token(Token = "0x6000191")]
			[Cpp2IlInjected.Address(Slot = "9")]
			get;
			[Cpp2IlInjected.Token(Token = "0x6000192")]
			[Cpp2IlInjected.Address(Slot = "10")]
			set;
		}

		[Cpp2IlInjected.Token(Token = "0x170000AB")]
		string BaseAvatarItemColor
		{
			[Cpp2IlInjected.Token(Token = "0x6000193")]
			[Cpp2IlInjected.Address(Slot = "11")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x170000AC")]
		string DesignFilename
		{
			[Cpp2IlInjected.Token(Token = "0x6000194")]
			[Cpp2IlInjected.Address(Slot = "12")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x170000AD")]
		string ThumbnailImageFilename
		{
			[Cpp2IlInjected.Token(Token = "0x6000195")]
			[Cpp2IlInjected.Address(Slot = "13")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x170000AE")]
		DateTime CreatedAt
		{
			[Cpp2IlInjected.Token(Token = "0x6000196")]
			[Cpp2IlInjected.Address(Slot = "14")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x170000AF")]
		DateTime ModifiedAt
		{
			[Cpp2IlInjected.Token(Token = "0x6000197")]
			[Cpp2IlInjected.Address(Slot = "15")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x170000B0")]
		CustomAvatarItemPreviewOrientation PreviewOrientation
		{
			[Cpp2IlInjected.Token(Token = "0x6000198")]
			[Cpp2IlInjected.Address(Slot = "16")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x170000B1")]
		string RankingContext
		{
			[Cpp2IlInjected.Token(Token = "0x6000199")]
			[Cpp2IlInjected.Address(Slot = "17")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x170000B2")]
		int OutfitType
		{
			[Cpp2IlInjected.Token(Token = "0x600019A")]
			[Cpp2IlInjected.Address(Slot = "18")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x170000B3")]
		string RankedEntityId
		{
			[Cpp2IlInjected.Token(Token = "0x600019B")]
			[Cpp2IlInjected.Address(RVA = "0x7A5DEC0", Offset = "0x7A5CCC0", VA = "0x187A5DEC0", Slot = "19")]
			get
			{
				return null;
			}
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000037")]
	public interface WNRHSJCQDZB
	{
		[Cpp2IlInjected.Token(Token = "0x170000B4")]
		IReadOnlyList<WESGMYVWMPU> Saves
		{
			[Cpp2IlInjected.Token(Token = "0x600019C")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x170000B5")]
		Guid CustomAvatarItemId
		{
			[Cpp2IlInjected.Token(Token = "0x600019D")]
			[Cpp2IlInjected.Address(Slot = "1")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x170000B6")]
		int CreatorAccountId
		{
			[Cpp2IlInjected.Token(Token = "0x600019E")]
			[Cpp2IlInjected.Address(Slot = "2")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x170000B7")]
		string Name
		{
			[Cpp2IlInjected.Token(Token = "0x600019F")]
			[Cpp2IlInjected.Address(Slot = "3")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x170000B8")]
		bool IsRecRoomApproved
		{
			[Cpp2IlInjected.Token(Token = "0x60001A0")]
			[Cpp2IlInjected.Address(Slot = "4")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x170000B9")]
		int OutfitType
		{
			[Cpp2IlInjected.Token(Token = "0x60001A1")]
			[Cpp2IlInjected.Address(Slot = "5")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x170000BA")]
		int? BaseAvatarItemId
		{
			[Cpp2IlInjected.Token(Token = "0x60001A2")]
			[Cpp2IlInjected.Address(Slot = "6")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x170000BB")]
		UgcAccessibility Accessibility
		{
			[Cpp2IlInjected.Token(Token = "0x60001A3")]
			[Cpp2IlInjected.Address(Slot = "7")]
			get;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000038")]
	public static class AECGQXBYGVN
	{
		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x200003A")]
		[CompilerGenerated]
		private struct <PostDeserializeAll>d__1 : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000B1")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x40000B2")]
			public AsyncTaskMethodBuilder <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x40000B3")]
			public IEnumerable<IRecNetUtf8JsonObjectPerformsPostProcessing> list;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x40000B4")]
			private ConfiguredTaskAwaitable.ConfiguredTaskAwaiter <>u__1;

			[Cpp2IlInjected.Token(Token = "0x60001A9")]
			[Cpp2IlInjected.Address(RVA = "0x7A63500", Offset = "0x7A62300", VA = "0x187A63500", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001AA")]
			[Cpp2IlInjected.Address(RVA = "0x7A63790", Offset = "0x7A62590", VA = "0x187A63790", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60001A4")]
		[Cpp2IlInjected.Address(RVA = "0x7A58CE0", Offset = "0x7A57AE0", VA = "0x187A58CE0")]
		public static bool GOGNWVQWGIZ(this IEnumerable<IRecNetUtf8JsonObject> a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001A5")]
		[Cpp2IlInjected.Address(RVA = "0x7A58F20", Offset = "0x7A57D20", VA = "0x187A58F20")]
		[AsyncStateMachine(typeof(<PostDeserializeAll>d__1))]
		public static Task LMIJKUELIIH(this IEnumerable<IRecNetUtf8JsonObjectPerformsPostProcessing> a)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200003B")]
	public struct FilenameWithHash
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000B5")]
		public readonly string Filename;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40000B6")]
		public readonly string Hash;

		[Cpp2IlInjected.Token(Token = "0x40000B7")]
		public static readonly FilenameWithHash Null;

		[Cpp2IlInjected.Token(Token = "0x60001AB")]
		[Cpp2IlInjected.Address(RVA = "0xC88220", Offset = "0xC87020", VA = "0x180C88220")]
		public FilenameWithHash(string filename, string hash)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001AC")]
		[Cpp2IlInjected.Address(RVA = "0x141FF70", Offset = "0x141ED70", VA = "0x18141FF70")]
		public bool Equals(FilenameWithHash other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001AD")]
		[Cpp2IlInjected.Address(RVA = "0x7A5ACB0", Offset = "0x7A59AB0", VA = "0x187A5ACB0", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001AE")]
		[Cpp2IlInjected.Address(RVA = "0x7A5AE10", Offset = "0x7A59C10", VA = "0x187A5AE10", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[SpecialName]
		[Cpp2IlInjected.Token(Token = "0x60001AF")]
		[Cpp2IlInjected.Address(RVA = "0x7A5AD90", Offset = "0x7A59B90", VA = "0x187A5AD90")]
		public static bool GFBRUTYEXQF(FilenameWithHash a, FilenameWithHash b)
		{
			return default(bool);
		}

		[SpecialName]
		[Cpp2IlInjected.Token(Token = "0x60001B0")]
		[Cpp2IlInjected.Address(RVA = "0x7A5AC30", Offset = "0x7A59A30", VA = "0x187A5AC30")]
		public static bool CQBJVGKOTGK(FilenameWithHash a, FilenameWithHash b)
		{
			return default(bool);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200003C")]
	public interface MZNKMHHBZRA
	{
		[Cpp2IlInjected.Token(Token = "0x170000BC")]
		NIWFOENLDJY TVMQSEZQBBL
		{
			[Cpp2IlInjected.Token(Token = "0x60001B2")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x170000BD")]
		string WQXROWBLNBG
		{
			[Cpp2IlInjected.Token(Token = "0x60001B3")]
			[Cpp2IlInjected.Address(Slot = "1")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x170000BE")]
		string OQXLYHILQBC
		{
			[Cpp2IlInjected.Token(Token = "0x60001B4")]
			[Cpp2IlInjected.Address(Slot = "2")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x170000BF")]
		long BRRDRADXWBB
		{
			[Cpp2IlInjected.Token(Token = "0x60001B5")]
			[Cpp2IlInjected.Address(Slot = "3")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x170000C0")]
		string HEEIGOYVJRR
		{
			[Cpp2IlInjected.Token(Token = "0x60001B6")]
			[Cpp2IlInjected.Address(Slot = "4")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x170000C1")]
		string KYSMIDRLUIO
		{
			[Cpp2IlInjected.Token(Token = "0x60001B7")]
			[Cpp2IlInjected.Address(Slot = "5")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x170000C2")]
		string SUALDVTZKYU
		{
			[Cpp2IlInjected.Token(Token = "0x60001B8")]
			[Cpp2IlInjected.Address(Slot = "6")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x170000C3")]
		string IHTGDGTFASG
		{
			[Cpp2IlInjected.Token(Token = "0x60001B9")]
			[Cpp2IlInjected.Address(Slot = "7")]
			get;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200003D")]
	[Utf8JsonSerializable]
	public class ContentBlock : FNDKLNUTQRK
	{
		[Cpp2IlInjected.Token(Token = "0x170000C4")]
		public string TrackingCategory
		{
			[Cpp2IlInjected.Token(Token = "0x60001BA")]
			[Cpp2IlInjected.Address(RVA = "0xAC0D20", Offset = "0xABFB20", VA = "0x180AC0D20")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60001BB")]
			[Cpp2IlInjected.Address(RVA = "0xAC0D10", Offset = "0xABFB10", VA = "0x180AC0D10")]
			[CompilerGenerated]
			internal set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000C5")]
		public ContentBlockLayout Layout
		{
			[Cpp2IlInjected.Token(Token = "0x60001BC")]
			[Cpp2IlInjected.Address(RVA = "0xACF4D0", Offset = "0xACE2D0", VA = "0x180ACF4D0")]
			[CompilerGenerated]
			get
			{
				return default(ContentBlockLayout);
			}
			[Cpp2IlInjected.Token(Token = "0x60001BD")]
			[Cpp2IlInjected.Address(RVA = "0xB20FD0", Offset = "0xB1FDD0", VA = "0x180B20FD0")]
			[CompilerGenerated]
			internal set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000C6")]
		public ContentBlockTextSize TextSize
		{
			[Cpp2IlInjected.Token(Token = "0x60001BE")]
			[Cpp2IlInjected.Address(RVA = "0xAE6400", Offset = "0xAE5200", VA = "0x180AE6400")]
			[CompilerGenerated]
			get
			{
				return default(ContentBlockTextSize);
			}
			[Cpp2IlInjected.Token(Token = "0x60001BF")]
			[Cpp2IlInjected.Address(RVA = "0xEF6710", Offset = "0xEF5510", VA = "0x180EF6710")]
			[CompilerGenerated]
			internal set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000C7")]
		public ContentBlockTitlePlacement TitleTextPlacement
		{
			[Cpp2IlInjected.Token(Token = "0x60001C0")]
			[Cpp2IlInjected.Address(RVA = "0xAC2060", Offset = "0xAC0E60", VA = "0x180AC2060")]
			[CompilerGenerated]
			get
			{
				return default(ContentBlockTitlePlacement);
			}
			[Cpp2IlInjected.Token(Token = "0x60001C1")]
			[Cpp2IlInjected.Address(RVA = "0xAC1D30", Offset = "0xAC0B30", VA = "0x180AC1D30")]
			[CompilerGenerated]
			internal set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000C8")]
		[DataMember(Name = "Header")]
		public string? HeaderOverride
		{
			[Cpp2IlInjected.Token(Token = "0x60001C2")]
			[Cpp2IlInjected.Address(RVA = "0xAC0F80", Offset = "0xABFD80", VA = "0x180AC0F80")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60001C3")]
			[Cpp2IlInjected.Address(RVA = "0xAC8C50", Offset = "0xAC7A50", VA = "0x180AC8C50")]
			[CompilerGenerated]
			internal set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000C9")]
		public string? Title
		{
			[Cpp2IlInjected.Token(Token = "0x60001C4")]
			[Cpp2IlInjected.Address(RVA = "0xAC0FC0", Offset = "0xABFDC0", VA = "0x180AC0FC0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60001C5")]
			[Cpp2IlInjected.Address(RVA = "0xAC0CF0", Offset = "0xABFAF0", VA = "0x180AC0CF0")]
			[CompilerGenerated]
			internal set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000CA")]
		public string? Body
		{
			[Cpp2IlInjected.Token(Token = "0x60001C6")]
			[Cpp2IlInjected.Address(RVA = "0xAC5120", Offset = "0xAC3F20", VA = "0x180AC5120")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60001C7")]
			[Cpp2IlInjected.Address(RVA = "0xAC0FB0", Offset = "0xABFDB0", VA = "0x180AC0FB0")]
			[CompilerGenerated]
			internal set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000CB")]
		public List<string> ImageNames
		{
			[Cpp2IlInjected.Token(Token = "0x60001C8")]
			[Cpp2IlInjected.Address(RVA = "0xAC0D30", Offset = "0xABFB30", VA = "0x180AC0D30")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60001C9")]
			[Cpp2IlInjected.Address(RVA = "0xAC1370", Offset = "0xAC0170", VA = "0x180AC1370")]
			[CompilerGenerated]
			internal set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000CC")]
		public List<ContentBlockButton> Buttons
		{
			[Cpp2IlInjected.Token(Token = "0x60001CA")]
			[Cpp2IlInjected.Address(RVA = "0xAC31E0", Offset = "0xAC1FE0", VA = "0x180AC31E0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60001CB")]
			[Cpp2IlInjected.Address(RVA = "0xAC31C0", Offset = "0xAC1FC0", VA = "0x180AC31C0")]
			[CompilerGenerated]
			internal set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60001CC")]
		[Cpp2IlInjected.Address(RVA = "0x7A5A460", Offset = "0x7A59260", VA = "0x187A5A460", Slot = "5")]
		public override void DNRPRHFLPRB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001CD")]
		[Cpp2IlInjected.Address(RVA = "0x7A5A470", Offset = "0x7A59270", VA = "0x187A5A470")]
		public ContentBlock()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200003E")]
	public enum ContentBlockLinkType
	{
		[Cpp2IlInjected.Token(Token = "0x40000C2")]
		Url,
		[Cpp2IlInjected.Token(Token = "0x40000C3")]
		AccountId,
		[Cpp2IlInjected.Token(Token = "0x40000C4")]
		EventId,
		[Cpp2IlInjected.Token(Token = "0x40000C5")]
		RoomName,
		[Cpp2IlInjected.Token(Token = "0x40000C6")]
		Storefront,
		[Cpp2IlInjected.Token(Token = "0x40000C7")]
		[Obsolete("6/4/21: This was only ever used for an announcement for Shawn's referral event, which is not happening again. Removing as part of a StackUI cleanup")]
		ActionCode,
		[Cpp2IlInjected.Token(Token = "0x40000C8")]
		Item,
		[Cpp2IlInjected.Token(Token = "0x40000C9")]
		CustomAvatarItem,
		[Cpp2IlInjected.Token(Token = "0x40000CA")]
		AuthorizedRecNetUrl,
		[Cpp2IlInjected.Token(Token = "0x40000CB")]
		Close
	}
	[Cpp2IlInjected.Token(Token = "0x200003F")]
	public enum ContentBlockLayout
	{
		[Cpp2IlInjected.Token(Token = "0x40000CD")]
		Default,
		[Cpp2IlInjected.Token(Token = "0x40000CE")]
		Vertical,
		[Cpp2IlInjected.Token(Token = "0x40000CF")]
		Horizontal
	}
	[Cpp2IlInjected.Token(Token = "0x2000040")]
	public enum ContentBlockTextSize
	{
		[Cpp2IlInjected.Token(Token = "0x40000D1")]
		Small,
		[Cpp2IlInjected.Token(Token = "0x40000D2")]
		Medium,
		[Cpp2IlInjected.Token(Token = "0x40000D3")]
		Large
	}
	[Cpp2IlInjected.Token(Token = "0x2000041")]
	public enum ContentBlockTitlePlacement
	{
		[Cpp2IlInjected.Token(Token = "0x40000D5")]
		Before,
		[Cpp2IlInjected.Token(Token = "0x40000D6")]
		Overlay,
		[Cpp2IlInjected.Token(Token = "0x40000D7")]
		After
	}
	[Cpp2IlInjected.Token(Token = "0x2000042")]
	[Utf8JsonSerializable]
	public class ContentBlockButton : IRecNetUtf8JsonObject
	{
		[Cpp2IlInjected.Token(Token = "0x170000CD")]
		public ContentBlockLinkType LinkType
		{
			[Cpp2IlInjected.Token(Token = "0x60001CE")]
			[Cpp2IlInjected.Address(RVA = "0xABD110", Offset = "0xABBF10", VA = "0x180ABD110")]
			[CompilerGenerated]
			get
			{
				return default(ContentBlockLinkType);
			}
			[Cpp2IlInjected.Token(Token = "0x60001CF")]
			[Cpp2IlInjected.Address(RVA = "0xAC1D40", Offset = "0xAC0B40", VA = "0x180AC1D40")]
			[CompilerGenerated]
			internal set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000CE")]
		public string? LinkName
		{
			[Cpp2IlInjected.Token(Token = "0x60001D0")]
			[Cpp2IlInjected.Address(RVA = "0xAC0D20", Offset = "0xABFB20", VA = "0x180AC0D20")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60001D1")]
			[Cpp2IlInjected.Address(RVA = "0xAC0D10", Offset = "0xABFB10", VA = "0x180AC0D10")]
			[CompilerGenerated]
			internal set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000CF")]
		[DataMember(Name = "LinkParameter")]
		public string? LinkUriOrParameter
		{
			[Cpp2IlInjected.Token(Token = "0x60001D2")]
			[Cpp2IlInjected.Address(RVA = "0xAC1D20", Offset = "0xAC0B20", VA = "0x180AC1D20")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60001D3")]
			[Cpp2IlInjected.Address(RVA = "0xAC0640", Offset = "0xABF440", VA = "0x180AC0640")]
			[CompilerGenerated]
			internal set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000D0")]
		public string? LinkButtonLabel
		{
			[Cpp2IlInjected.Token(Token = "0x60001D4")]
			[Cpp2IlInjected.Address(RVA = "0xAC0F90", Offset = "0xABFD90", VA = "0x180AC0F90")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60001D5")]
			[Cpp2IlInjected.Address(RVA = "0xAC0650", Offset = "0xABF450", VA = "0x180AC0650")]
			[CompilerGenerated]
			internal set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60001D6")]
		[Cpp2IlInjected.Address(RVA = "0xABE8D0", Offset = "0xABD6D0", VA = "0x180ABE8D0", Slot = "4")]
		public void DNRPRHFLPRB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001D7")]
		[Cpp2IlInjected.Address(RVA = "0xAC4840", Offset = "0xAC3640", VA = "0x180AC4840")]
		public ContentBlockButton()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000043")]
	public abstract class FNDKLNUTQRK : IRecNetUtf8JsonObject
	{
		[Cpp2IlInjected.Token(Token = "0x170000D1")]
		[IgnoreDataMember]
		public string? TMMYHDOENBV
		{
			[Cpp2IlInjected.Token(Token = "0x60001D8")]
			[Cpp2IlInjected.Address(RVA = "0xABD130", Offset = "0xABBF30", VA = "0x180ABD130")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60001D9")]
			[Cpp2IlInjected.Address(RVA = "0xABD120", Offset = "0xABBF20", VA = "0x180ABD120")]
			[CompilerGenerated]
			internal set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60001DA")]
		[Cpp2IlInjected.Address(Slot = "5")]
		public abstract void DNRPRHFLPRB();

		[Cpp2IlInjected.Token(Token = "0x60001DB")]
		[Cpp2IlInjected.Address(RVA = "0x14914E0", Offset = "0x14902E0", VA = "0x1814914E0")]
		protected FNDKLNUTQRK()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000044")]
	[Utf8JsonSerializable]
	public class InAppMessageIdDTO : IRecNetUtf8JsonObject
	{
		[Cpp2IlInjected.Token(Token = "0x170000D2")]
		public string? MessageId
		{
			[Cpp2IlInjected.Token(Token = "0x60001DC")]
			[Cpp2IlInjected.Address(RVA = "0xABD130", Offset = "0xABBF30", VA = "0x180ABD130")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60001DD")]
			[Cpp2IlInjected.Address(RVA = "0xABD120", Offset = "0xABBF20", VA = "0x180ABD120")]
			[CompilerGenerated]
			internal set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60001DE")]
		[Cpp2IlInjected.Address(RVA = "0xABE8D0", Offset = "0xABD6D0", VA = "0x180ABE8D0", Slot = "4")]
		public void DNRPRHFLPRB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001DF")]
		[Cpp2IlInjected.Address(RVA = "0xAC4840", Offset = "0xAC3640", VA = "0x180AC4840")]
		public InAppMessageIdDTO()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000045")]
	[Utf8JsonSerializable]
	public class InAppMessageDTO : IRecNetUtf8JsonObject
	{
		[Cpp2IlInjected.Token(Token = "0x40000DE")]
		internal static Func<string, ContentBlock>? DJFYOYMXHVM;

		[Cpp2IlInjected.Token(Token = "0x40000DF")]
		internal static Func<string, JustInTimeTutorialTrigger>? VGBZVJXYXIU;

		[Cpp2IlInjected.Token(Token = "0x170000D3")]
		public string? MessageId
		{
			[Cpp2IlInjected.Token(Token = "0x60001E0")]
			[Cpp2IlInjected.Address(RVA = "0xABD130", Offset = "0xABBF30", VA = "0x180ABD130")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60001E1")]
			[Cpp2IlInjected.Address(RVA = "0xABD120", Offset = "0xABBF20", VA = "0x180ABD120")]
			[CompilerGenerated]
			internal set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000D4")]
		public string? SenderMessageId
		{
			[Cpp2IlInjected.Token(Token = "0x60001E2")]
			[Cpp2IlInjected.Address(RVA = "0xAC0D20", Offset = "0xABFB20", VA = "0x180AC0D20")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60001E3")]
			[Cpp2IlInjected.Address(RVA = "0xAC0D10", Offset = "0xABFB10", VA = "0x180AC0D10")]
			[CompilerGenerated]
			internal set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000D5")]
		public bool IsBroadcast
		{
			[Cpp2IlInjected.Token(Token = "0x60001E4")]
			[Cpp2IlInjected.Address(RVA = "0xAC1360", Offset = "0xAC0160", VA = "0x180AC1360")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x60001E5")]
			[Cpp2IlInjected.Address(RVA = "0xAC0FD0", Offset = "0xABFDD0", VA = "0x180AC0FD0")]
			[CompilerGenerated]
			internal set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000D6")]
		public PlatformType Platform
		{
			[Cpp2IlInjected.Token(Token = "0x60001E6")]
			[Cpp2IlInjected.Address(RVA = "0xAE6400", Offset = "0xAE5200", VA = "0x180AE6400")]
			[CompilerGenerated]
			get
			{
				return default(PlatformType);
			}
			[Cpp2IlInjected.Token(Token = "0x60001E7")]
			[Cpp2IlInjected.Address(RVA = "0xEF6710", Offset = "0xEF5510", VA = "0x180EF6710")]
			[CompilerGenerated]
			internal set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000D7")]
		public PlatformMask PlatformTypeMask
		{
			[Cpp2IlInjected.Token(Token = "0x60001E8")]
			[Cpp2IlInjected.Address(RVA = "0xAC2060", Offset = "0xAC0E60", VA = "0x180AC2060")]
			[CompilerGenerated]
			get
			{
				return default(PlatformMask);
			}
			[Cpp2IlInjected.Token(Token = "0x60001E9")]
			[Cpp2IlInjected.Address(RVA = "0xAC1D30", Offset = "0xAC0B30", VA = "0x180AC1D30")]
			[CompilerGenerated]
			internal set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000D8")]
		public int Priority
		{
			[Cpp2IlInjected.Token(Token = "0x60001EA")]
			[Cpp2IlInjected.Address(RVA = "0xC56CD0", Offset = "0xC55AD0", VA = "0x180C56CD0")]
			[CompilerGenerated]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x60001EB")]
			[Cpp2IlInjected.Address(RVA = "0x1D9ACF0", Offset = "0x1D99AF0", VA = "0x181D9ACF0")]
			[CompilerGenerated]
			internal set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000D9")]
		public DateTime SentAt
		{
			[Cpp2IlInjected.Token(Token = "0x60001EC")]
			[Cpp2IlInjected.Address(RVA = "0xAC0F80", Offset = "0xABFD80", VA = "0x180AC0F80")]
			[CompilerGenerated]
			get
			{
				return default(DateTime);
			}
			[Cpp2IlInjected.Token(Token = "0x60001ED")]
			[Cpp2IlInjected.Address(RVA = "0xAC0FA0", Offset = "0xABFDA0", VA = "0x180AC0FA0")]
			[CompilerGenerated]
			internal set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000DA")]
		[DataMember(Name = "IsRead")]
		internal bool JINFBJALGLO
		{
			[Cpp2IlInjected.Token(Token = "0x60001EE")]
			[Cpp2IlInjected.Address(RVA = "0xAEBAB0", Offset = "0xAEA8B0", VA = "0x180AEBAB0")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x60001EF")]
			[Cpp2IlInjected.Address(RVA = "0xAEBA10", Offset = "0xAEA810", VA = "0x180AEBA10")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000DB")]
		[IgnoreDataMember]
		public bool IsClientRead
		{
			[Cpp2IlInjected.Token(Token = "0x60001F0")]
			[Cpp2IlInjected.Address(RVA = "0x1B1A460", Offset = "0x1B19260", VA = "0x181B1A460")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x60001F1")]
			[Cpp2IlInjected.Address(RVA = "0x1B1A720", Offset = "0x1B19520", VA = "0x181B1A720")]
			[CompilerGenerated]
			internal set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000DC")]
		public InAppMessageChannel Channel
		{
			[Cpp2IlInjected.Token(Token = "0x60001F2")]
			[Cpp2IlInjected.Address(RVA = "0xAFE430", Offset = "0xAFD230", VA = "0x180AFE430")]
			[CompilerGenerated]
			get
			{
				return default(InAppMessageChannel);
			}
			[Cpp2IlInjected.Token(Token = "0x60001F3")]
			[Cpp2IlInjected.Address(RVA = "0xAFD5C0", Offset = "0xAFC3C0", VA = "0x180AFD5C0")]
			[CompilerGenerated]
			internal set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000DD")]
		public InAppMessageContentType ContentType
		{
			[Cpp2IlInjected.Token(Token = "0x60001F4")]
			[Cpp2IlInjected.Address(RVA = "0xADBF60", Offset = "0xADAD60", VA = "0x180ADBF60")]
			[CompilerGenerated]
			get
			{
				return default(InAppMessageContentType);
			}
			[Cpp2IlInjected.Token(Token = "0x60001F5")]
			[Cpp2IlInjected.Address(RVA = "0xB3EC20", Offset = "0xB3DA20", VA = "0x180B3EC20")]
			[CompilerGenerated]
			internal set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000DE")]
		internal string? ZSRTGYCRWEY
		{
			[Cpp2IlInjected.Token(Token = "0x60001F6")]
			[Cpp2IlInjected.Address(RVA = "0xAC0D30", Offset = "0xABFB30", VA = "0x180AC0D30")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60001F7")]
			[Cpp2IlInjected.Address(RVA = "0xAC1370", Offset = "0xAC0170", VA = "0x180AC1370")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000DF")]
		[IgnoreDataMember]
		public ContentBlock? ContentBlock
		{
			[Cpp2IlInjected.Token(Token = "0x60001F8")]
			[Cpp2IlInjected.Address(RVA = "0x7A5C9C0", Offset = "0x7A5B7C0", VA = "0x187A5C9C0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000E0")]
		[IgnoreDataMember]
		public JustInTimeTutorialTrigger? JustInTimeTutorialTrigger
		{
			[Cpp2IlInjected.Token(Token = "0x60001F9")]
			[Cpp2IlInjected.Address(RVA = "0x7A5CA40", Offset = "0x7A5B840", VA = "0x187A5CA40")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000E1")]
		[IgnoreDataMember]
		public FNDKLNUTQRK? ContentObject
		{
			[Cpp2IlInjected.Token(Token = "0x60001FA")]
			[Cpp2IlInjected.Address(RVA = "0xAC31E0", Offset = "0xAC1FE0", VA = "0x180AC31E0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60001FB")]
			[Cpp2IlInjected.Address(RVA = "0xAC31C0", Offset = "0xAC1FC0", VA = "0x180AC31C0")]
			[CompilerGenerated]
			internal set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60001FC")]
		[Cpp2IlInjected.Address(RVA = "0x7A5C700", Offset = "0x7A5B500", VA = "0x187A5C700", Slot = "4")]
		public void DNRPRHFLPRB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001FD")]
		[Cpp2IlInjected.Address(RVA = "0xAE8380", Offset = "0xAE7180", VA = "0x180AE8380")]
		public InAppMessageDTO()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000046")]
	[Utf8JsonSerializable]
	public class JustInTimeTutorialCondition : IRecNetUtf8JsonObject
	{
		[Cpp2IlInjected.Token(Token = "0x170000E2")]
		public JustInTimeTutorialTrackable Trackable
		{
			[Cpp2IlInjected.Token(Token = "0x60001FE")]
			[Cpp2IlInjected.Address(RVA = "0xABD110", Offset = "0xABBF10", VA = "0x180ABD110")]
			[CompilerGenerated]
			get
			{
				return default(JustInTimeTutorialTrackable);
			}
			[Cpp2IlInjected.Token(Token = "0x60001FF")]
			[Cpp2IlInjected.Address(RVA = "0xAC1D40", Offset = "0xAC0B40", VA = "0x180AC1D40")]
			[CompilerGenerated]
			internal set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000E3")]
		public string Room
		{
			[Cpp2IlInjected.Token(Token = "0x6000200")]
			[Cpp2IlInjected.Address(RVA = "0xAC0D20", Offset = "0xABFB20", VA = "0x180AC0D20")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000201")]
			[Cpp2IlInjected.Address(RVA = "0xAC0D10", Offset = "0xABFB10", VA = "0x180AC0D10")]
			[CompilerGenerated]
			internal set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000E4")]
		public int Threshold
		{
			[Cpp2IlInjected.Token(Token = "0x6000202")]
			[Cpp2IlInjected.Address(RVA = "0xACF4D0", Offset = "0xACE2D0", VA = "0x180ACF4D0")]
			[CompilerGenerated]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x6000203")]
			[Cpp2IlInjected.Address(RVA = "0xB20FD0", Offset = "0xB1FDD0", VA = "0x180B20FD0")]
			[CompilerGenerated]
			internal set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000204")]
		[Cpp2IlInjected.Address(RVA = "0xABE8D0", Offset = "0xABD6D0", VA = "0x180ABE8D0", Slot = "4")]
		public void DNRPRHFLPRB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000205")]
		[Cpp2IlInjected.Address(RVA = "0x7A5DBD0", Offset = "0x7A5C9D0", VA = "0x187A5DBD0")]
		public JustInTimeTutorialCondition()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000047")]
	[Utf8JsonSerializable]
	public class JustInTimeTutorialTrigger : FNDKLNUTQRK
	{
		[Cpp2IlInjected.Token(Token = "0x170000E5")]
		public string Identifier
		{
			[Cpp2IlInjected.Token(Token = "0x6000206")]
			[Cpp2IlInjected.Address(RVA = "0xAC0D20", Offset = "0xABFB20", VA = "0x180AC0D20")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000207")]
			[Cpp2IlInjected.Address(RVA = "0xAC0D10", Offset = "0xABFB10", VA = "0x180AC0D10")]
			[CompilerGenerated]
			internal set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000E6")]
		public string? Name
		{
			[Cpp2IlInjected.Token(Token = "0x6000208")]
			[Cpp2IlInjected.Address(RVA = "0xAC1D20", Offset = "0xAC0B20", VA = "0x180AC1D20")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000209")]
			[Cpp2IlInjected.Address(RVA = "0xAC0640", Offset = "0xABF440", VA = "0x180AC0640")]
			[CompilerGenerated]
			internal set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000E7")]
		public JustInTimeTutorialAction Action
		{
			[Cpp2IlInjected.Token(Token = "0x600020A")]
			[Cpp2IlInjected.Address(RVA = "0xAC2060", Offset = "0xAC0E60", VA = "0x180AC2060")]
			[CompilerGenerated]
			get
			{
				return default(JustInTimeTutorialAction);
			}
			[Cpp2IlInjected.Token(Token = "0x600020B")]
			[Cpp2IlInjected.Address(RVA = "0xAC1D30", Offset = "0xAC0B30", VA = "0x180AC1D30")]
			[CompilerGenerated]
			internal set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000E8")]
		[DataMember(Name = "all_conditions_required")]
		public bool AllConditionsRequired
		{
			[Cpp2IlInjected.Token(Token = "0x600020C")]
			[Cpp2IlInjected.Address(RVA = "0x1ADD440", Offset = "0x1ADC240", VA = "0x181ADD440")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x600020D")]
			[Cpp2IlInjected.Address(RVA = "0x10AC4A0", Offset = "0x10AB2A0", VA = "0x1810AC4A0")]
			[CompilerGenerated]
			internal set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000E9")]
		public List<JustInTimeTutorialCondition> Conditions
		{
			[Cpp2IlInjected.Token(Token = "0x600020E")]
			[Cpp2IlInjected.Address(RVA = "0xAC0F80", Offset = "0xABFD80", VA = "0x180AC0F80")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600020F")]
			[Cpp2IlInjected.Address(RVA = "0xAC8C50", Offset = "0xAC7A50", VA = "0x180AC8C50")]
			[CompilerGenerated]
			internal set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000210")]
		[Cpp2IlInjected.Address(RVA = "0x7A5DC20", Offset = "0x7A5CA20", VA = "0x187A5DC20", Slot = "5")]
		public override void DNRPRHFLPRB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000211")]
		[Cpp2IlInjected.Address(RVA = "0x7A5DC30", Offset = "0x7A5CA30", VA = "0x187A5DC30")]
		public JustInTimeTutorialTrigger()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000048")]
	public enum InAppMessageContentType
	{
		[Cpp2IlInjected.Token(Token = "0x40000F6")]
		Unknown,
		[Cpp2IlInjected.Token(Token = "0x40000F7")]
		ContentBlock,
		[Cpp2IlInjected.Token(Token = "0x40000F8")]
		JustInTimeTutorialTrigger
	}
	[Cpp2IlInjected.Token(Token = "0x2000049")]
	public enum InAppMessageChannel
	{
		[Cpp2IlInjected.Token(Token = "0x40000FA")]
		None,
		[Cpp2IlInjected.Token(Token = "0x40000FB")]
		Announcements,
		[Cpp2IlInjected.Token(Token = "0x40000FC")]
		JustInTimeTutorials
	}
	[Cpp2IlInjected.Token(Token = "0x200004A")]
	public enum JustInTimeTutorialAction
	{
		[Cpp2IlInjected.Token(Token = "0x40000FE")]
		Unknown = 0,
		[Cpp2IlInjected.Token(Token = "0x40000FF")]
		MakerPenButtonHighlight = 1,
		[Cpp2IlInjected.Token(Token = "0x4000100")]
		PlaceControlTutorial = 3
	}
	[Cpp2IlInjected.Token(Token = "0x200004B")]
	public enum JustInTimeTutorialTrackable
	{
		[Cpp2IlInjected.Token(Token = "0x4000102")]
		EnteredRoom = 0,
		[Cpp2IlInjected.Token(Token = "0x4000103")]
		TimeInRoom = 1,
		[Cpp2IlInjected.Token(Token = "0x4000104")]
		ObjectInteractionRoom = 2,
		[Cpp2IlInjected.Token(Token = "0x4000105")]
		ObjectPlaceStartedRoom = 4
	}
	[Cpp2IlInjected.Token(Token = "0x200004C")]
	public interface LRZGBKTKHSH
	{
		[Cpp2IlInjected.Token(Token = "0x170000EA")]
		bool IUOFMHMYYSH
		{
			[Cpp2IlInjected.Token(Token = "0x6000216")]
			[Cpp2IlInjected.Address(Slot = "4")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x170000EB")]
		OZAYXQWBYWY<InAppMessageDTO> JNYPDFZBJKB
		{
			[Cpp2IlInjected.Token(Token = "0x6000219")]
			[Cpp2IlInjected.Address(Slot = "7")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x170000EC")]
		OZAYXQWBYWY<string> IWWLIHIBBQC
		{
			[Cpp2IlInjected.Token(Token = "0x600021A")]
			[Cpp2IlInjected.Address(Slot = "8")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x170000ED")]
		OZAYXQWBYWY<InAppMessageDTO> XTMKMSIPKVS
		{
			[Cpp2IlInjected.Token(Token = "0x600021B")]
			[Cpp2IlInjected.Address(Slot = "9")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x170000EE")]
		OZAYXQWBYWY<InAppMessageDTO> NGTCQPYLCNH
		{
			[Cpp2IlInjected.Token(Token = "0x600021C")]
			[Cpp2IlInjected.Address(Slot = "10")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x6000212")]
		[Cpp2IlInjected.Address(Slot = "0")]
		IReadOnlyList<InAppMessageDTO> OFDYIMQCDXY(InAppMessageChannel a);

		[Cpp2IlInjected.Token(Token = "0x6000213")]
		[Cpp2IlInjected.Address(Slot = "1")]
		IReadOnlyList<InAppMessageDTO> UMUGQPEMCVD(InAppMessageChannel a);

		[Cpp2IlInjected.Token(Token = "0x6000214")]
		[Cpp2IlInjected.Address(Slot = "2")]
		InAppMessageDTO SMLNFLNBNAM(InAppMessageChannel a, string b);

		[Cpp2IlInjected.Token(Token = "0x6000215")]
		[Cpp2IlInjected.Address(Slot = "3")]
		InAppMessageDTO SCTLCEKHQHL(InAppMessageChannel a);

		[Cpp2IlInjected.Token(Token = "0x6000217")]
		[Cpp2IlInjected.Address(Slot = "5")]
		bool PZGXJBBOVAU(InAppMessageChannel a);

		[Cpp2IlInjected.Token(Token = "0x6000218")]
		[Cpp2IlInjected.Address(Slot = "6")]
		int QURNHSVKFMU(InAppMessageChannel a);

		[Cpp2IlInjected.Token(Token = "0x600021D")]
		[Cpp2IlInjected.Address(Slot = "11")]
		Task Refresh();

		[Cpp2IlInjected.Token(Token = "0x600021E")]
		[Cpp2IlInjected.Address(Slot = "12")]
		Task QBLFBQVHFXE(InAppMessageDTO a);
	}
	[Cpp2IlInjected.Token(Token = "0x200004D")]
	public interface RRAAAEBKPOL
	{
		[Cpp2IlInjected.Token(Token = "0x170000EF")]
		DTLVXBHLOJJ XEPTFIVYQVX
		{
			[Cpp2IlInjected.Token(Token = "0x6000223")]
			[Cpp2IlInjected.Address(Slot = "4")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x170000F0")]
		int TFLJXQBEOKA
		{
			[Cpp2IlInjected.Token(Token = "0x6000224")]
			[Cpp2IlInjected.Address(Slot = "5")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x170000F1")]
		bool SNOWEDNFSJK
		{
			[Cpp2IlInjected.Token(Token = "0x6000225")]
			[Cpp2IlInjected.Address(Slot = "6")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x170000F2")]
		bool ETBUUJYAFMU
		{
			[Cpp2IlInjected.Token(Token = "0x6000226")]
			[Cpp2IlInjected.Address(Slot = "7")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x170000F3")]
		bool HGHURNIKDUW
		{
			[Cpp2IlInjected.Token(Token = "0x6000227")]
			[Cpp2IlInjected.Address(Slot = "8")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x170000F4")]
		bool DLNSQNBPKWG
		{
			[Cpp2IlInjected.Token(Token = "0x6000228")]
			[Cpp2IlInjected.Address(Slot = "9")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x170000F5")]
		bool EKUTTWXCDLV
		{
			[Cpp2IlInjected.Token(Token = "0x6000229")]
			[Cpp2IlInjected.Address(Slot = "10")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x170000F6")]
		bool MDJRCWGQVEA
		{
			[Cpp2IlInjected.Token(Token = "0x600022A")]
			[Cpp2IlInjected.Address(Slot = "11")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x170000F7")]
		bool BKLYLTFUUEP
		{
			[Cpp2IlInjected.Token(Token = "0x600022B")]
			[Cpp2IlInjected.Address(Slot = "12")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x170000F8")]
		bool JRGAPAUAOMP
		{
			[Cpp2IlInjected.Token(Token = "0x600022C")]
			[Cpp2IlInjected.Address(Slot = "13")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x170000F9")]
		bool MCMGPBCDDAU
		{
			[Cpp2IlInjected.Token(Token = "0x600022D")]
			[Cpp2IlInjected.Address(Slot = "14")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x170000FA")]
		bool MOIXQYJYHAB
		{
			[Cpp2IlInjected.Token(Token = "0x600022E")]
			[Cpp2IlInjected.Address(Slot = "15")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x14000003")]
		event Action XJFDBBFNKNJ;

		[Cpp2IlInjected.Token(Token = "0x14000004")]
		event Action SBHYEDBVONF;

		[Cpp2IlInjected.Token(Token = "0x600022F")]
		[Cpp2IlInjected.Address(Slot = "16")]
		YLZUVDOLRNC<XTOYSWYWUAV> LGWNNZFUKYQ(int a);

		[Cpp2IlInjected.Token(Token = "0x6000230")]
		[Cpp2IlInjected.Address(Slot = "17")]
		WGVXBSAEBCD OAFILVSNTVO(DateTime a);

		[Cpp2IlInjected.Token(Token = "0x6000231")]
		[Cpp2IlInjected.Address(Slot = "18")]
		WGVXBSAEBCD EQDLLNBBQSH(string a);

		[Cpp2IlInjected.Token(Token = "0x6000232")]
		[Cpp2IlInjected.Address(Slot = "19")]
		Task THZLKAZVVIE([Optional] CancellationToken a);
	}
	[Cpp2IlInjected.Token(Token = "0x200004E")]
	public enum TestAccountAuthRole
	{
		[Cpp2IlInjected.Token(Token = "0x4000107")]
		Memory,
		[Cpp2IlInjected.Token(Token = "0x4000108")]
		Multiplayer
	}
	[Cpp2IlInjected.Token(Token = "0x200004F")]
	public static class PYQAZODYUUH
	{
		[Cpp2IlInjected.Token(Token = "0x6000233")]
		[Cpp2IlInjected.Address(RVA = "0x7A5F2E0", Offset = "0x7A5E0E0", VA = "0x187A5F2E0")]
		public static string RWVXMNWUVFE(this TestAccountAuthRole a)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000050")]
	public interface QFJMJPBFYHP
	{
		[Cpp2IlInjected.Token(Token = "0x6000234")]
		[Cpp2IlInjected.Address(Slot = "0")]
		Task<List<InAppMessageDTO>> KGPWJGXHFOJ(InAppMessageChannel a);

		[Cpp2IlInjected.Token(Token = "0x6000235")]
		[Cpp2IlInjected.Address(Slot = "1")]
		Task QBLFBQVHFXE(string a);
	}
	[Cpp2IlInjected.Token(Token = "0x2000051")]
	public interface JKDXUPBYRIA
	{
		[Cpp2IlInjected.Token(Token = "0x6000236")]
		[Cpp2IlInjected.Address(Slot = "0")]
		Task<CrmAssignmentDTO> DAWLPZGFBIF();
	}
	[Cpp2IlInjected.Token(Token = "0x2000052")]
	public interface FTAXPDLGYMH
	{
		[Cpp2IlInjected.Token(Token = "0x170000FB")]
		Guid? FECFUXWRMAM
		{
			[Cpp2IlInjected.Token(Token = "0x6000237")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000053")]
	public interface QSDHNYFLZPQ
	{
		[Cpp2IlInjected.Token(Token = "0x6000238")]
		[Cpp2IlInjected.Address(Slot = "0")]
		YLZUVDOLRNC<List<LSUQAIIBHFQ>> GLHRCXSVNOV();

		[Cpp2IlInjected.Token(Token = "0x6000239")]
		[Cpp2IlInjected.Address(Slot = "1")]
		YLZUVDOLRNC<List<LSUQAIIBHFQ>> HESKSEIFQIM();

		[Cpp2IlInjected.Token(Token = "0x600023A")]
		[Cpp2IlInjected.Address(Slot = "2")]
		Task<List<LSUQAIIBHFQ>> LVYPNKQOGVK([Optional] CancellationToken a);

		[Cpp2IlInjected.Token(Token = "0x600023B")]
		[Cpp2IlInjected.Address(Slot = "3")]
		YLZUVDOLRNC<List<LSUQAIIBHFQ>> LBDVEAIUNXZ(List<AvatarItemDesc> a);

		[Cpp2IlInjected.Token(Token = "0x600023C")]
		[Cpp2IlInjected.Address(Slot = "4")]
		YLZUVDOLRNC<List<LSUQAIIBHFQ>> RJJTFCQQTKT(List<AvatarItemDesc> a);
	}
	[Cpp2IlInjected.Token(Token = "0x2000054")]
	public interface YWRRCWZAAWC
	{
		[Cpp2IlInjected.Token(Token = "0x170000FC")]
		List<GiftPackage> OBONUXLHRTC
		{
			[Cpp2IlInjected.Token(Token = "0x6000241")]
			[Cpp2IlInjected.Address(Slot = "4")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x14000005")]
		event Action<GiftPackageReceivedArgs> CGZMUGNKYAI;

		[Cpp2IlInjected.Token(Token = "0x14000006")]
		event Action<GiftPackage> SQFINRMQQTL;

		[Cpp2IlInjected.Token(Token = "0x6000242")]
		[Cpp2IlInjected.Address(Slot = "5")]
		WGVXBSAEBCD CMYYYEEJFKW(GiftPackage a);

		[Cpp2IlInjected.Token(Token = "0x6000243")]
		[Cpp2IlInjected.Address(Slot = "6")]
		Task PKMJGUMKCEK(GiftPackage a);

		[Cpp2IlInjected.Token(Token = "0x6000244")]
		[Cpp2IlInjected.Address(Slot = "7")]
		[Obsolete("Alternate gift contexts are being phased out. Use LocalRequestGiftPackage(GiftContext context, string message) instead")]
		YLZUVDOLRNC<GiftPackage> FDQINBNURNV(GiftContext a, GiftContext? b, bool c, string d);

		[Cpp2IlInjected.Token(Token = "0x6000245")]
		[Cpp2IlInjected.Address(Slot = "8")]
		YLZUVDOLRNC<GiftPackage> FDQINBNURNV(GiftContext a, string b);

		[Cpp2IlInjected.Token(Token = "0x6000246")]
		[Cpp2IlInjected.Address(Slot = "9")]
		void VHLLXFMLVVE(GiftPackage a, bool b = false, bool c = false, bool d = true);

		[Cpp2IlInjected.Token(Token = "0x6000247")]
		[Cpp2IlInjected.Address(Slot = "10")]
		YLZUVDOLRNC<List<GiftPackage>> UVIBAFXGNLO();
	}
	[Cpp2IlInjected.Token(Token = "0x2000055")]
	public interface HJSYEXRHMLG
	{
		[Cpp2IlInjected.Token(Token = "0x170000FD")]
		string BFVLPQOVLSG
		{
			[Cpp2IlInjected.Token(Token = "0x600024C")]
			[Cpp2IlInjected.Address(Slot = "4")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x170000FE")]
		bool NVFMIVQZXRD
		{
			[Cpp2IlInjected.Token(Token = "0x600024D")]
			[Cpp2IlInjected.Address(Slot = "5")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x6000248")]
		[Cpp2IlInjected.Address(Slot = "0")]
		WGVXBSAEBCD CQKWCVCCQJV();

		[Cpp2IlInjected.Token(Token = "0x6000249")]
		[Cpp2IlInjected.Address(Slot = "1")]
		WGVXBSAEBCD AEUIGNCRZEO(string a, string b);

		[Cpp2IlInjected.Token(Token = "0x600024A")]
		[Cpp2IlInjected.Address(Slot = "2")]
		WGVXBSAEBCD QTTVRSDGYXA(string a);

		[Cpp2IlInjected.Token(Token = "0x600024B")]
		[Cpp2IlInjected.Address(Slot = "3")]
		void ECKWLGPKEIK();

		[Cpp2IlInjected.Token(Token = "0x600024E")]
		[Cpp2IlInjected.Address(Slot = "6")]
		Task<LoginResult> DSUTVTHTSXK(string a, string b, bool c, string d, string e, [Optional] CancellationToken f);

		[Cpp2IlInjected.Token(Token = "0x600024F")]
		[Cpp2IlInjected.Address(Slot = "7")]
		Task GGWNWSVYENJ(int a, string b, [Optional] CancellationToken c);

		[Cpp2IlInjected.Token(Token = "0x6000250")]
		[Cpp2IlInjected.Address(Slot = "8")]
		Task CFSPQFZMBLI(int a, [Optional] CancellationToken b);

		[Cpp2IlInjected.Token(Token = "0x6000251")]
		[Cpp2IlInjected.Address(Slot = "9")]
		Task APVRNGMHCXY([Optional] TestAccountAuthRole? a, [Optional] CancellationToken b);

		[Cpp2IlInjected.Token(Token = "0x6000252")]
		[Cpp2IlInjected.Address(Slot = "10")]
		Task<IReadOnlyList<UUEPUWLRWCF>> ZHLRVGRKHCP([Optional] CancellationToken a);

		[Cpp2IlInjected.Token(Token = "0x6000253")]
		[Cpp2IlInjected.Address(Slot = "11")]
		Task STVITMADNHS([Optional] CancellationToken a);
	}
	[Cpp2IlInjected.Token(Token = "0x2000056")]
	public interface ZZMICKCKHUU
	{
		[Cpp2IlInjected.Token(Token = "0x6000254")]
		[Cpp2IlInjected.Address(Slot = "0")]
		Task<List<StatsigMemoryOverrideParameterDTO>> DJLTMGBBMZT([Optional] CancellationToken a);

		[Cpp2IlInjected.Token(Token = "0x6000255")]
		[Cpp2IlInjected.Address(Slot = "1")]
		Task<List<StatsigExperimentConfigDTO>> ABZOEXITRIF([Optional] CancellationToken a);
	}
	[Cpp2IlInjected.Token(Token = "0x2000057")]
	public interface XIPPFMSATGZ
	{
		[Cpp2IlInjected.Token(Token = "0x6000256")]
		[Cpp2IlInjected.Address(Slot = "0")]
		Task GEVBJNSTFEZ([Optional] CancellationToken a);

		[Cpp2IlInjected.Token(Token = "0x6000257")]
		[Cpp2IlInjected.Address(Slot = "1")]
		void Disconnect();
	}
	[Cpp2IlInjected.Token(Token = "0x2000058")]
	public interface TWKXMCGWMFS
	{
		[Cpp2IlInjected.Token(Token = "0x6000258")]
		[Cpp2IlInjected.Address(Slot = "0")]
		Task YVMFTILFBFC(int a, [Optional] CancellationToken b);
	}
	[Cpp2IlInjected.Token(Token = "0x2000059")]
	public interface SZFXHMPWSLL
	{
		[Cpp2IlInjected.Token(Token = "0x14000007")]
		event OutfitEvent? WKEDGDFAHTP;

		[Cpp2IlInjected.Token(Token = "0x14000008")]
		event OutfitEvent? JJWNFILZAJB;

		[Cpp2IlInjected.Token(Token = "0x14000009")]
		event OutfitEvent? PPZFQJIAPBR;

		[Cpp2IlInjected.Token(Token = "0x600025F")]
		[Cpp2IlInjected.Address(Slot = "6")]
		Task<OutfitDTO> LWVSGMCWQNB();

		[Cpp2IlInjected.Token(Token = "0x6000260")]
		[Cpp2IlInjected.Address(Slot = "7")]
		Task<OutfitDTO?>? INSUMQKVLFM(int a);

		[Cpp2IlInjected.Token(Token = "0x6000261")]
		[Cpp2IlInjected.Address(Slot = "8")]
		Task<List<GELYNSCEPVX>> ZEOTSMNYRDI(List<int> a);

		[Cpp2IlInjected.Token(Token = "0x6000262")]
		[Cpp2IlInjected.Address(Slot = "9")]
		Task<IReadOnlyDictionary<int, OutfitDTO>> KMEHFSUFWVI();

		[Cpp2IlInjected.Token(Token = "0x6000263")]
		[Cpp2IlInjected.Address(Slot = "10")]
		Task<List<OutfitDTO?>?>? VXCSUEKUNJT(int a);

		[Cpp2IlInjected.Token(Token = "0x6000264")]
		[Cpp2IlInjected.Address(Slot = "11")]
		Task PCMVUHVIPZA(int a);

		[Cpp2IlInjected.Token(Token = "0x6000265")]
		[Cpp2IlInjected.Address(Slot = "12")]
		Task<RecNetResult> GKAXRHGRONX(OutfitDTO a);
	}
	[Cpp2IlInjected.Token(Token = "0x200005A")]
	public delegate void OutfitEvent(int accountId, int slot, OutfitDTO? outfit);
	[Cpp2IlInjected.Token(Token = "0x200005B")]
	public interface NZNQCQEACIC : NFGFAVEOVGR, EKFPOTOCRBP
	{
		[Cpp2IlInjected.Token(Token = "0x200005C")]
		[Flags]
		public enum SanitizeMode
		{
			[Cpp2IlInjected.Token(Token = "0x400010A")]
			FilterProfanity = 1,
			[Cpp2IlInjected.Token(Token = "0x400010B")]
			FilterURL = 2
		}

		[Cpp2IlInjected.Token(Token = "0x170000FF")]
		string MDTGBQIEKQA
		{
			[Cpp2IlInjected.Token(Token = "0x600026A")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000100")]
		DeviceClass DAUFHUALWWL
		{
			[Cpp2IlInjected.Token(Token = "0x600026B")]
			[Cpp2IlInjected.Address(Slot = "1")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000101")]
		PlatformType FOLNNGSJLCA
		{
			[Cpp2IlInjected.Token(Token = "0x600026C")]
			[Cpp2IlInjected.Address(Slot = "2")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000102")]
		string OCRQWACOXWN
		{
			[Cpp2IlInjected.Token(Token = "0x600026D")]
			[Cpp2IlInjected.Address(Slot = "3")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000103")]
		byte XHUBUZESHEB
		{
			[Cpp2IlInjected.Token(Token = "0x6000270")]
			[Cpp2IlInjected.Address(Slot = "6")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000104")]
		int XWMCXLLOUDC
		{
			[Cpp2IlInjected.Token(Token = "0x6000271")]
			[Cpp2IlInjected.Address(Slot = "7")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000105")]
		int RIOFBXHCIMK
		{
			[Cpp2IlInjected.Token(Token = "0x6000272")]
			[Cpp2IlInjected.Address(Slot = "8")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000106")]
		bool JPNCOAXDGJT
		{
			[Cpp2IlInjected.Token(Token = "0x6000273")]
			[Cpp2IlInjected.Address(Slot = "9")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000107")]
		bool GKWGHLEFPTR
		{
			[Cpp2IlInjected.Token(Token = "0x6000274")]
			[Cpp2IlInjected.Address(Slot = "10")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000108")]
		bool HBNXTVNTYDW
		{
			[Cpp2IlInjected.Token(Token = "0x6000275")]
			[Cpp2IlInjected.Address(Slot = "11")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000109")]
		bool CRPLPIXVSME
		{
			[Cpp2IlInjected.Token(Token = "0x6000276")]
			[Cpp2IlInjected.Address(Slot = "12")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x1700010A")]
		bool SBFYJECIMWC
		{
			[Cpp2IlInjected.Token(Token = "0x6000277")]
			[Cpp2IlInjected.Address(Slot = "13")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x1700010B")]
		bool XPBHJPYYTQI
		{
			[Cpp2IlInjected.Token(Token = "0x6000278")]
			[Cpp2IlInjected.Address(Slot = "14")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x1700010C")]
		bool JBAJDDWJWIB
		{
			[Cpp2IlInjected.Token(Token = "0x6000280")]
			[Cpp2IlInjected.Address(Slot = "22")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x600026E")]
		[Cpp2IlInjected.Address(Slot = "4")]
		YLZUVDOLRNC<string> TSAGZDJIJAP();

		[Cpp2IlInjected.Token(Token = "0x600026F")]
		[Cpp2IlInjected.Address(Slot = "5")]
		Task<string> PZCOQSVSDUT();

		[Cpp2IlInjected.Token(Token = "0x6000279")]
		[Cpp2IlInjected.Address(Slot = "15")]
		YLZUVDOLRNC<bool> HQLSGFHMYKH(int a);

		[Cpp2IlInjected.Token(Token = "0x600027A")]
		[Cpp2IlInjected.Address(Slot = "16")]
		string KBCUAMBNNLG(string a, bool b = true);

		[Cpp2IlInjected.Token(Token = "0x600027B")]
		[Cpp2IlInjected.Address(Slot = "17")]
		Task<string> PIZGQSNZAEU(string a, bool b = true);

		[Cpp2IlInjected.Token(Token = "0x600027C")]
		[Cpp2IlInjected.Address(Slot = "18")]
		YLZUVDOLRNC<string> MakeRoomNameAdhereToPlatformRequirements(long roomId, string name);

		[Cpp2IlInjected.Token(Token = "0x600027D")]
		[Cpp2IlInjected.Address(Slot = "19")]
		bool SanitizeDisplayText(string displayText, SanitizeMode sanitizeMode = SanitizeMode.FilterProfanity | SanitizeMode.FilterURL);

		[Cpp2IlInjected.Token(Token = "0x600027E")]
		[Cpp2IlInjected.Address(Slot = "20")]
		Task<string> SanitizeDisplayTextAsync(string displayText, SanitizeMode sanitizeMode = SanitizeMode.FilterProfanity | SanitizeMode.FilterURL, bool isChat = false);

		[Cpp2IlInjected.Token(Token = "0x600027F")]
		[Cpp2IlInjected.Address(Slot = "21")]
		bool CheckNameForProfanity(string name, SanitizeMode sanitizeMode = SanitizeMode.FilterProfanity | SanitizeMode.FilterURL);

		[Cpp2IlInjected.Token(Token = "0x6000281")]
		[Cpp2IlInjected.Address(Slot = "23")]
		YLZUVDOLRNC<string> GetCommerceSubscriptionAccessToken();
	}
	[Cpp2IlInjected.Token(Token = "0x200005D")]
	public interface JPOBBFXOFZD
	{
		[Cpp2IlInjected.Token(Token = "0x6000282")]
		[Cpp2IlInjected.Address(Slot = "0")]
		Task<List<RefereeFileReferenceDTO>> UREPXOSCTSZ([Optional] CancellationToken a);
	}
	[Cpp2IlInjected.Token(Token = "0x200005E")]
	public interface MAHAVXVSVPH
	{
		[Cpp2IlInjected.Token(Token = "0x6000283")]
		[Cpp2IlInjected.Address(Slot = "0")]
		bool YHGBTOYYXVS(byte[] a, byte[] b);
	}
	[Cpp2IlInjected.Token(Token = "0x200005F")]
	public interface CZZAERPUWYM
	{
		[Cpp2IlInjected.Token(Token = "0x6000284")]
		[Cpp2IlInjected.Address(Slot = "0")]
		Task JZREDFDLGOH(string a);
	}
	[Cpp2IlInjected.Token(Token = "0x2000060")]
	public interface DMRTAQYEPBQ
	{
		[Cpp2IlInjected.Token(Token = "0x6000285")]
		[Cpp2IlInjected.Address(Slot = "0")]
		Task<List<RecNetResultObject<FilteredTextDTO>>> FJSAXVJHKWU(uint a, IEnumerable<string> b);
	}
	[Cpp2IlInjected.Token(Token = "0x2000061")]
	public interface SYSZMYKVTSB
	{
		[Cpp2IlInjected.Token(Token = "0x1700010D")]
		OZAYXQWBYWY<TimedRewardTrackRecordDTO> WEHBTGSIAHM
		{
			[Cpp2IlInjected.Token(Token = "0x6000286")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x6000287")]
		[Cpp2IlInjected.Address(Slot = "1")]
		void QPVANJJYXHX();

		[Cpp2IlInjected.Token(Token = "0x6000288")]
		[Cpp2IlInjected.Address(Slot = "2")]
		Task<TimedRewardTrackDTO> AGXYLVNTNFY(long a, [Optional] CancellationToken b);

		[Cpp2IlInjected.Token(Token = "0x6000289")]
		[Cpp2IlInjected.Address(Slot = "3")]
		Task<TimedRewardTrackDTO> AGXYLVNTNFY(string a, [Optional] CancellationToken b);

		[Cpp2IlInjected.Token(Token = "0x600028A")]
		[Cpp2IlInjected.Address(Slot = "4")]
		Task<TimedRewardTrackRecordDTO> HURESHURKJT(long a, [Optional] CancellationToken b);
	}
	[Cpp2IlInjected.Token(Token = "0x2000062")]
	public interface DIDNNXSXDZQ
	{
		[Cpp2IlInjected.Token(Token = "0x600028B")]
		[Cpp2IlInjected.Address(Slot = "0")]
		bool UKGGEJMXDAI([Out] bool a);

		[Cpp2IlInjected.Token(Token = "0x600028C")]
		[Cpp2IlInjected.Address(Slot = "1")]
		bool WSVJXTVKFRZ([Out] bool a);

		[Cpp2IlInjected.Token(Token = "0x600028D")]
		[Cpp2IlInjected.Address(Slot = "2")]
		bool QIKONNIELKN([Out] int a);

		[Cpp2IlInjected.Token(Token = "0x600028E")]
		[Cpp2IlInjected.Address(Slot = "3")]
		bool GSJEKDASAOO([Out] bool a);
	}
	[Cpp2IlInjected.Token(Token = "0x2000063")]
	public enum JuniorState
	{
		[Cpp2IlInjected.Token(Token = "0x400010D")]
		BasedOnBirthday,
		[Cpp2IlInjected.Token(Token = "0x400010E")]
		ModerationOverride,
		[Cpp2IlInjected.Token(Token = "0x400010F")]
		PendingOverride
	}
	[Cpp2IlInjected.Token(Token = "0x2000064")]
	public enum PlatformDetailType
	{
		[Cpp2IlInjected.Token(Token = "0x4000111")]
		Id,
		[Cpp2IlInjected.Token(Token = "0x4000112")]
		Email,
		[Cpp2IlInjected.Token(Token = "0x4000113")]
		Phone
	}
	[Cpp2IlInjected.Token(Token = "0x2000065")]
	[Flags]
	public enum PersonalPronouns
	{
		[Cpp2IlInjected.Token(Token = "0x4000115")]
		None = 0,
		[Cpp2IlInjected.Token(Token = "0x4000116")]
		SheHer = 1,
		[Cpp2IlInjected.Token(Token = "0x4000117")]
		HeHim = 2,
		[Cpp2IlInjected.Token(Token = "0x4000118")]
		TheyThem = 4,
		[Cpp2IlInjected.Token(Token = "0x4000119")]
		ZeHir = 8,
		[Cpp2IlInjected.Token(Token = "0x400011A")]
		ZeZir = 0x10,
		[Cpp2IlInjected.Token(Token = "0x400011B")]
		XeXem = 0x20
	}
	[Cpp2IlInjected.Token(Token = "0x2000066")]
	[Flags]
	public enum IdentityFlags
	{
		[Cpp2IlInjected.Token(Token = "0x400011D")]
		None = 0,
		[Cpp2IlInjected.Token(Token = "0x400011E")]
		LGBTQIA = 1,
		[Cpp2IlInjected.Token(Token = "0x400011F")]
		Transgender = 2,
		[Cpp2IlInjected.Token(Token = "0x4000120")]
		Bisexual = 4,
		[Cpp2IlInjected.Token(Token = "0x4000121")]
		Lesbian = 8,
		[Cpp2IlInjected.Token(Token = "0x4000122")]
		Pansexual = 0x10,
		[Cpp2IlInjected.Token(Token = "0x4000123")]
		Asexual = 0x20,
		[Cpp2IlInjected.Token(Token = "0x4000124")]
		Intersex = 0x40,
		[Cpp2IlInjected.Token(Token = "0x4000125")]
		Genderqueer = 0x80,
		[Cpp2IlInjected.Token(Token = "0x4000126")]
		Nonbinary = 0x100,
		[Cpp2IlInjected.Token(Token = "0x4000127")]
		Aromantic = 0x200
	}
	[Cpp2IlInjected.Token(Token = "0x2000067")]
	public enum EmailFrequencyPreference
	{
		[Cpp2IlInjected.Token(Token = "0x4000129")]
		Daily = 10,
		[Cpp2IlInjected.Token(Token = "0x400012A")]
		Weekly = 20,
		[Cpp2IlInjected.Token(Token = "0x400012B")]
		Monthly = 30,
		[Cpp2IlInjected.Token(Token = "0x400012C")]
		Never = 40,
		[Cpp2IlInjected.Token(Token = "0x400012D")]
		Yes = 50
	}
	[Cpp2IlInjected.Token(Token = "0x2000068")]
	public enum AccountAgeBucket
	{
		[Cpp2IlInjected.Token(Token = "0x400012F")]
		BELOW_TEN = 0,
		[Cpp2IlInjected.Token(Token = "0x4000130")]
		BETWEEN_TEN_AND_TWELVE = 10,
		[Cpp2IlInjected.Token(Token = "0x4000131")]
		TEEN = 13,
		[Cpp2IlInjected.Token(Token = "0x4000132")]
		ADULT = 18,
		[Cpp2IlInjected.Token(Token = "0x4000133")]
		UNKNOWN = 999
	}
	[Cpp2IlInjected.Token(Token = "0x2000069")]
	public interface XTOYSWYWUAV
	{
		[Cpp2IlInjected.Token(Token = "0x1700010E")]
		int AccountId
		{
			[Cpp2IlInjected.Token(Token = "0x600028F")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x1700010F")]
		string RawUsername
		{
			[Cpp2IlInjected.Token(Token = "0x6000290")]
			[Cpp2IlInjected.Address(Slot = "1")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000110")]
		string Username
		{
			[Cpp2IlInjected.Token(Token = "0x6000291")]
			[Cpp2IlInjected.Address(Slot = "2")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000111")]
		string DisplayName
		{
			[Cpp2IlInjected.Token(Token = "0x6000292")]
			[Cpp2IlInjected.Address(Slot = "3")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000112")]
		string DisplayEmoji
		{
			[Cpp2IlInjected.Token(Token = "0x6000293")]
			[Cpp2IlInjected.Address(Slot = "4")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000113")]
		string ProfileImage
		{
			[Cpp2IlInjected.Token(Token = "0x6000294")]
			[Cpp2IlInjected.Address(Slot = "5")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000114")]
		string BannerImage
		{
			[Cpp2IlInjected.Token(Token = "0x6000295")]
			[Cpp2IlInjected.Address(Slot = "6")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000115")]
		bool TreatAsJunior
		{
			[Cpp2IlInjected.Token(Token = "0x6000296")]
			[Cpp2IlInjected.Address(Slot = "7")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000116")]
		bool HasBirthday
		{
			[Cpp2IlInjected.Token(Token = "0x6000297")]
			[Cpp2IlInjected.Address(Slot = "8")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000117")]
		PersonalPronouns PersonalPronouns
		{
			[Cpp2IlInjected.Token(Token = "0x6000298")]
			[Cpp2IlInjected.Address(Slot = "9")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000118")]
		IdentityFlags IdentityFlags
		{
			[Cpp2IlInjected.Token(Token = "0x6000299")]
			[Cpp2IlInjected.Address(Slot = "10")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000119")]
		DateTime CreatedAt
		{
			[Cpp2IlInjected.Token(Token = "0x600029A")]
			[Cpp2IlInjected.Address(Slot = "11")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x1700011A")]
		bool? IsJunior
		{
			[Cpp2IlInjected.Token(Token = "0x600029B")]
			[Cpp2IlInjected.Address(Slot = "12")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x600029C")]
		[Cpp2IlInjected.Address(Slot = "13")]
		void OQVMOZKCJZC(bool a);

		[Cpp2IlInjected.Token(Token = "0x600029D")]
		[Cpp2IlInjected.Address(Slot = "14")]
		void PJVOTNPEAMD(bool a);
	}
	[Cpp2IlInjected.Token(Token = "0x200006A")]
	public interface DTLVXBHLOJJ : XTOYSWYWUAV
	{
		[Cpp2IlInjected.Token(Token = "0x1700011B")]
		string Email
		{
			[Cpp2IlInjected.Token(Token = "0x600029E")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x1700011C")]
		string Phone
		{
			[Cpp2IlInjected.Token(Token = "0x600029F")]
			[Cpp2IlInjected.Address(Slot = "1")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x1700011D")]
		DateTime? Birthday
		{
			[Cpp2IlInjected.Token(Token = "0x60002A0")]
			[Cpp2IlInjected.Address(Slot = "2")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x1700011E")]
		JuniorState JuniorState
		{
			[Cpp2IlInjected.Token(Token = "0x60002A1")]
			[Cpp2IlInjected.Address(Slot = "3")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x1700011F")]
		int? ParentAccountId
		{
			[Cpp2IlInjected.Token(Token = "0x60002A2")]
			[Cpp2IlInjected.Address(Slot = "4")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000120")]
		int AvailableUsernameChanges
		{
			[Cpp2IlInjected.Token(Token = "0x60002A3")]
			[Cpp2IlInjected.Address(Slot = "5")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000121")]
		bool CanChangeUsername
		{
			[Cpp2IlInjected.Token(Token = "0x60002A4")]
			[Cpp2IlInjected.Address(Slot = "6")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000122")]
		bool IsConfirmed
		{
			[Cpp2IlInjected.Token(Token = "0x60002A5")]
			[Cpp2IlInjected.Address(Slot = "7")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000123")]
		bool? IsFakeJuniorBirthday
		{
			[Cpp2IlInjected.Token(Token = "0x60002A6")]
			[Cpp2IlInjected.Address(Slot = "8")]
			get;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200006B")]
	public class KCQZDJGMCNC
	{
		[Cpp2IlInjected.Token(Token = "0x17000124")]
		public XTOYSWYWUAV QLZYKYFIALE
		{
			[Cpp2IlInjected.Token(Token = "0x60002A7")]
			[Cpp2IlInjected.Address(RVA = "0xABD130", Offset = "0xABBF30", VA = "0x180ABD130")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000125")]
		public PlatformDetailType ETDCYHBZORX
		{
			[Cpp2IlInjected.Token(Token = "0x60002A8")]
			[Cpp2IlInjected.Address(RVA = "0xAC7B20", Offset = "0xAC6920", VA = "0x180AC7B20")]
			[CompilerGenerated]
			get
			{
				return default(PlatformDetailType);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000126")]
		public string WNKDPLRNSQJ
		{
			[Cpp2IlInjected.Token(Token = "0x60002A9")]
			[Cpp2IlInjected.Address(RVA = "0xAC1D20", Offset = "0xAC0B20", VA = "0x180AC1D20")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60002AA")]
		[Cpp2IlInjected.Address(RVA = "0x77C0570", Offset = "0x77BF370", VA = "0x1877C0570")]
		public KCQZDJGMCNC(XTOYSWYWUAV a, PlatformDetailType b, string c)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200006C")]
	public interface NLEMYQJSXWI
	{
		[Cpp2IlInjected.Token(Token = "0x17000127")]
		int AccountId
		{
			[Cpp2IlInjected.Token(Token = "0x60002AB")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000128")]
		bool DisallowInAppPurchases
		{
			[Cpp2IlInjected.Token(Token = "0x60002AC")]
			[Cpp2IlInjected.Address(Slot = "1")]
			get;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200006D")]
	public interface MIFDFLJJVTQ
	{
		[Cpp2IlInjected.Token(Token = "0x17000129")]
		int AccountId
		{
			[Cpp2IlInjected.Token(Token = "0x60002AD")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x1700012A")]
		bool IsRecentHistoryVisible
		{
			[Cpp2IlInjected.Token(Token = "0x60002AE")]
			[Cpp2IlInjected.Address(Slot = "1")]
			get;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200006E")]
	public interface QAPREWUWBWJ
	{
		[Cpp2IlInjected.Token(Token = "0x1700012B")]
		int AccountId
		{
			[Cpp2IlInjected.Token(Token = "0x60002AF")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x1700012C")]
		string Bio
		{
			[Cpp2IlInjected.Token(Token = "0x60002B0")]
			[Cpp2IlInjected.Address(Slot = "1")]
			get;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200006F")]
	public enum AvatarItemType
	{
		[Cpp2IlInjected.Token(Token = "0x4000138")]
		Outfit,
		[Cpp2IlInjected.Token(Token = "0x4000139")]
		HairDye,
		[Cpp2IlInjected.Token(Token = "0x400013A")]
		CustomOutfit
	}
	[Cpp2IlInjected.Token(Token = "0x2000070")]
	public class LSUQAIIBHFQ
	{
		[Cpp2IlInjected.Token(Token = "0x1700012D")]
		public AvatarItemType TJITCFARDCN
		{
			[Cpp2IlInjected.Token(Token = "0x60002B1")]
			[Cpp2IlInjected.Address(RVA = "0xABD110", Offset = "0xABBF10", VA = "0x180ABD110")]
			[CompilerGenerated]
			get
			{
				return default(AvatarItemType);
			}
			[Cpp2IlInjected.Token(Token = "0x60002B2")]
			[Cpp2IlInjected.Address(RVA = "0xAC1D40", Offset = "0xAC0B40", VA = "0x180AC1D40")]
			[CompilerGenerated]
			internal set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700012E")]
		public string EXGJUDSWVUT
		{
			[Cpp2IlInjected.Token(Token = "0x60002B3")]
			[Cpp2IlInjected.Address(RVA = "0xAC0D20", Offset = "0xABFB20", VA = "0x180AC0D20")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60002B4")]
			[Cpp2IlInjected.Address(RVA = "0xAC0D10", Offset = "0xABFB10", VA = "0x180AC0D10")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700012F")]
		public string AHYWEPLNNSG
		{
			[Cpp2IlInjected.Token(Token = "0x60002B5")]
			[Cpp2IlInjected.Address(RVA = "0xAC1D20", Offset = "0xAC0B20", VA = "0x180AC1D20")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60002B6")]
			[Cpp2IlInjected.Address(RVA = "0xAC0640", Offset = "0xABF440", VA = "0x180AC0640")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000130")]
		public GiftRarity XFHQSABRBIY
		{
			[Cpp2IlInjected.Token(Token = "0x60002B7")]
			[Cpp2IlInjected.Address(RVA = "0xAC2060", Offset = "0xAC0E60", VA = "0x180AC2060")]
			[CompilerGenerated]
			get
			{
				return default(GiftRarity);
			}
			[Cpp2IlInjected.Token(Token = "0x60002B8")]
			[Cpp2IlInjected.Address(RVA = "0xAC1D30", Offset = "0xAC0B30", VA = "0x180AC1D30")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000131")]
		public string OHGVKFTDDCR
		{
			[Cpp2IlInjected.Token(Token = "0x60002B9")]
			[Cpp2IlInjected.Address(RVA = "0xAC0F80", Offset = "0xABFD80", VA = "0x180AC0F80")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60002BA")]
			[Cpp2IlInjected.Address(RVA = "0xAC8C50", Offset = "0xAC7A50", VA = "0x180AC8C50")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000132")]
		public int DYPDACIQDHG
		{
			[Cpp2IlInjected.Token(Token = "0x60002BB")]
			[Cpp2IlInjected.Address(RVA = "0xAEE0C0", Offset = "0xAECEC0", VA = "0x180AEE0C0")]
			[CompilerGenerated]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x60002BC")]
			[Cpp2IlInjected.Address(RVA = "0xE1B620", Offset = "0xE1A420", VA = "0x180E1B620")]
			[CompilerGenerated]
			internal set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000133")]
		public bool ACVPJCLQBJC
		{
			[Cpp2IlInjected.Token(Token = "0x60002BD")]
			[Cpp2IlInjected.Address(RVA = "0xF20E00", Offset = "0xF1FC00", VA = "0x180F20E00")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x60002BE")]
			[Cpp2IlInjected.Address(RVA = "0xFDBE10", Offset = "0xFDAC10", VA = "0x180FDBE10")]
			[CompilerGenerated]
			internal set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000134")]
		public AvatarItemDesc HNLOVZOLPKA
		{
			[Cpp2IlInjected.Token(Token = "0x60002BF")]
			[Cpp2IlInjected.Address(RVA = "0x7A5E180", Offset = "0x7A5CF80", VA = "0x187A5E180")]
			[CompilerGenerated]
			get
			{
				return default(AvatarItemDesc);
			}
			[Cpp2IlInjected.Token(Token = "0x60002C0")]
			[Cpp2IlInjected.Address(RVA = "0x7A5E160", Offset = "0x7A5CF60", VA = "0x187A5E160")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000135")]
		public ColorId DZXWBWUJJUS
		{
			[Cpp2IlInjected.Token(Token = "0x60002C1")]
			[Cpp2IlInjected.Address(RVA = "0x4A19200", Offset = "0x4A18000", VA = "0x184A19200")]
			[CompilerGenerated]
			get
			{
				return default(ColorId);
			}
			[Cpp2IlInjected.Token(Token = "0x60002C2")]
			[Cpp2IlInjected.Address(RVA = "0x4A18F80", Offset = "0x4A17D80", VA = "0x184A18F80")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000136")]
		public string KTRMDXJBSBW
		{
			[Cpp2IlInjected.Token(Token = "0x60002C3")]
			[Cpp2IlInjected.Address(RVA = "0xAC7AA0", Offset = "0xAC68A0", VA = "0x180AC7AA0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60002C4")]
			[Cpp2IlInjected.Address(RVA = "0xAC8140", Offset = "0xAC6F40", VA = "0x180AC8140")]
			[CompilerGenerated]
			internal set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000137")]
		public DateTime SVCWCLBJHIY
		{
			[Cpp2IlInjected.Token(Token = "0x60002C5")]
			[Cpp2IlInjected.Address(RVA = "0xAC7B00", Offset = "0xAC6900", VA = "0x180AC7B00")]
			[CompilerGenerated]
			get
			{
				return default(DateTime);
			}
			[Cpp2IlInjected.Token(Token = "0x60002C6")]
			[Cpp2IlInjected.Address(RVA = "0x52EE050", Offset = "0x52ECE50", VA = "0x1852EE050")]
			[CompilerGenerated]
			internal set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60002C7")]
		[Cpp2IlInjected.Address(RVA = "0x7A5E1A0", Offset = "0x7A5CFA0", VA = "0x187A5E1A0")]
		internal LSUQAIIBHFQ(AvatarItemDetails a, PJVZSNZGULD b, OGJAWYXTLDA c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002C8")]
		[Cpp2IlInjected.Address(RVA = "0x7A5E400", Offset = "0x7A5D200", VA = "0x187A5E400")]
		public LSUQAIIBHFQ(AvatarItemType a = AvatarItemType.Outfit, [Optional] AvatarItemDesc b, [Optional] string c, [Optional] string d, GiftRarity e = GiftRarity.Common, [Optional] string f, int g = 0, bool h = false, [Optional] string i, [Optional] DateTime? j)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000071")]
	[Utf8JsonSerializable]
	public class AvatarItemDetails : IRecNetUtf8JsonObject
	{
		[Cpp2IlInjected.Token(Token = "0x17000138")]
		public AvatarItemType AvatarItemType
		{
			[Cpp2IlInjected.Token(Token = "0x60002C9")]
			[Cpp2IlInjected.Address(RVA = "0xABD110", Offset = "0xABBF10", VA = "0x180ABD110")]
			[CompilerGenerated]
			get
			{
				return default(AvatarItemType);
			}
			[Cpp2IlInjected.Token(Token = "0x60002CA")]
			[Cpp2IlInjected.Address(RVA = "0xAC1D40", Offset = "0xAC0B40", VA = "0x180AC1D40")]
			[CompilerGenerated]
			internal set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000139")]
		[DataMember(Name = "AvatarItemDesc")]
		public string AvatarItemDescString
		{
			[Cpp2IlInjected.Token(Token = "0x60002CB")]
			[Cpp2IlInjected.Address(RVA = "0xAC0D20", Offset = "0xABFB20", VA = "0x180AC0D20")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60002CC")]
			[Cpp2IlInjected.Address(RVA = "0xAC0D10", Offset = "0xABFB10", VA = "0x180AC0D10")]
			[CompilerGenerated]
			internal set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700013A")]
		public string FriendlyName
		{
			[Cpp2IlInjected.Token(Token = "0x60002CD")]
			[Cpp2IlInjected.Address(RVA = "0xAC1D20", Offset = "0xAC0B20", VA = "0x180AC1D20")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60002CE")]
			[Cpp2IlInjected.Address(RVA = "0xAC0640", Offset = "0xABF440", VA = "0x180AC0640")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700013B")]
		public string Tooltip
		{
			[Cpp2IlInjected.Token(Token = "0x60002CF")]
			[Cpp2IlInjected.Address(RVA = "0xAC0F90", Offset = "0xABFD90", VA = "0x180AC0F90")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60002D0")]
			[Cpp2IlInjected.Address(RVA = "0xAC0650", Offset = "0xABF450", VA = "0x180AC0650")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700013C")]
		public GiftRarity Rarity
		{
			[Cpp2IlInjected.Token(Token = "0x60002D1")]
			[Cpp2IlInjected.Address(RVA = "0xAC6560", Offset = "0xAC5360", VA = "0x180AC6560")]
			[CompilerGenerated]
			get
			{
				return default(GiftRarity);
			}
			[Cpp2IlInjected.Token(Token = "0x60002D2")]
			[Cpp2IlInjected.Address(RVA = "0xAC6870", Offset = "0xAC5670", VA = "0x180AC6870")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700013D")]
		public string TagList
		{
			[Cpp2IlInjected.Token(Token = "0x60002D3")]
			[Cpp2IlInjected.Address(RVA = "0xAC0FC0", Offset = "0xABFDC0", VA = "0x180AC0FC0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60002D4")]
			[Cpp2IlInjected.Address(RVA = "0xAC0CF0", Offset = "0xABFAF0", VA = "0x180AC0CF0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700013E")]
		public int AvatarItemId
		{
			[Cpp2IlInjected.Token(Token = "0x60002D5")]
			[Cpp2IlInjected.Address(RVA = "0xADBF60", Offset = "0xADAD60", VA = "0x180ADBF60")]
			[CompilerGenerated]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x60002D6")]
			[Cpp2IlInjected.Address(RVA = "0xB3EC20", Offset = "0xB3DA20", VA = "0x180B3EC20")]
			[CompilerGenerated]
			internal set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700013F")]
		public bool IsBaseAvatarItem
		{
			[Cpp2IlInjected.Token(Token = "0x60002D7")]
			[Cpp2IlInjected.Address(RVA = "0x19B7770", Offset = "0x19B6570", VA = "0x1819B7770")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x60002D8")]
			[Cpp2IlInjected.Address(RVA = "0x19B7760", Offset = "0x19B6560", VA = "0x1819B7760")]
			[CompilerGenerated]
			internal set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000140")]
		public string ThumbnailImage
		{
			[Cpp2IlInjected.Token(Token = "0x60002D9")]
			[Cpp2IlInjected.Address(RVA = "0xAC0D30", Offset = "0xABFB30", VA = "0x180AC0D30")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60002DA")]
			[Cpp2IlInjected.Address(RVA = "0xAC1370", Offset = "0xAC0170", VA = "0x180AC1370")]
			[CompilerGenerated]
			internal set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000141")]
		public DateTime CreatedAt
		{
			[Cpp2IlInjected.Token(Token = "0x60002DB")]
			[Cpp2IlInjected.Address(RVA = "0xAC31E0", Offset = "0xAC1FE0", VA = "0x180AC31E0")]
			[CompilerGenerated]
			get
			{
				return default(DateTime);
			}
			[Cpp2IlInjected.Token(Token = "0x60002DC")]
			[Cpp2IlInjected.Address(RVA = "0xFDBE00", Offset = "0xFDAC00", VA = "0x180FDBE00")]
			[CompilerGenerated]
			internal set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60002DD")]
		[Cpp2IlInjected.Address(RVA = "0xABE8D0", Offset = "0xABD6D0", VA = "0x180ABE8D0", Slot = "4")]
		public void DNRPRHFLPRB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002DE")]
		[Cpp2IlInjected.Address(RVA = "0xAC4840", Offset = "0xAC3640", VA = "0x180AC4840")]
		public AvatarItemDetails()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000072")]
	[Utf8JsonSerializable]
	public sealed class GetLockedAvatarItemDetailsBulkAsPostRequest : IRecNetUtf8JsonObject
	{
		[Cpp2IlInjected.Token(Token = "0x17000142")]
		public List<string> AvatarItemDescriptions
		{
			[Cpp2IlInjected.Token(Token = "0x60002E1")]
			[Cpp2IlInjected.Address(RVA = "0xABD130", Offset = "0xABBF30", VA = "0x180ABD130")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60002E2")]
			[Cpp2IlInjected.Address(RVA = "0xABD120", Offset = "0xABBF20", VA = "0x180ABD120")]
			[CompilerGenerated]
			internal set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60002DF")]
		[Cpp2IlInjected.Address(RVA = "0x7A5BE70", Offset = "0x7A5AC70", VA = "0x187A5BE70")]
		public GetLockedAvatarItemDetailsBulkAsPostRequest()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002E0")]
		[Cpp2IlInjected.Address(RVA = "0xACD980", Offset = "0xACC780", VA = "0x180ACD980")]
		public GetLockedAvatarItemDetailsBulkAsPostRequest(List<string> avatarItemDescriptions)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002E3")]
		[Cpp2IlInjected.Address(RVA = "0xABE8D0", Offset = "0xABD6D0", VA = "0x180ABE8D0", Slot = "4")]
		public void DNRPRHFLPRB()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000073")]
	[Utf8JsonSerializable]
	public class CrmAssignmentDTO : IRecNetUtf8JsonObject
	{
		[Cpp2IlInjected.Token(Token = "0x17000143")]
		public CrmUserDTO UserConfig
		{
			[Cpp2IlInjected.Token(Token = "0x60002E4")]
			[Cpp2IlInjected.Address(RVA = "0xABD130", Offset = "0xABBF30", VA = "0x180ABD130")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60002E5")]
			[Cpp2IlInjected.Address(RVA = "0xABD120", Offset = "0xABBF20", VA = "0x180ABD120")]
			[CompilerGenerated]
			internal set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000144")]
		public BrazeConfigDTO BrazeConfig
		{
			[Cpp2IlInjected.Token(Token = "0x60002E6")]
			[Cpp2IlInjected.Address(RVA = "0xAC0D20", Offset = "0xABFB20", VA = "0x180AC0D20")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60002E7")]
			[Cpp2IlInjected.Address(RVA = "0xAC0D10", Offset = "0xABFB10", VA = "0x180AC0D10")]
			[CompilerGenerated]
			internal set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60002E8")]
		[Cpp2IlInjected.Address(RVA = "0xAC4840", Offset = "0xAC3640", VA = "0x180AC4840")]
		public CrmAssignmentDTO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002E9")]
		[Cpp2IlInjected.Address(RVA = "0xABFA30", Offset = "0xABE830", VA = "0x180ABFA30")]
		public CrmAssignmentDTO(CrmUserDTO userConfig, BrazeConfigDTO brazeConfig)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002EA")]
		[Cpp2IlInjected.Address(RVA = "0xABE8D0", Offset = "0xABD6D0", VA = "0x180ABE8D0", Slot = "4")]
		public void DNRPRHFLPRB()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000074")]
	public enum CrmType
	{
		[Cpp2IlInjected.Token(Token = "0x4000154")]
		None,
		[Cpp2IlInjected.Token(Token = "0x4000155")]
		Braze,
		[Cpp2IlInjected.Token(Token = "0x4000156")]
		Rengage
	}
	[Cpp2IlInjected.Token(Token = "0x2000075")]
	public enum PushNotificationServices : byte
	{
		[Cpp2IlInjected.Token(Token = "0x4000158")]
		APNS,
		[Cpp2IlInjected.Token(Token = "0x4000159")]
		Firebase,
		[Cpp2IlInjected.Token(Token = "0x400015A")]
		Mock,
		[Cpp2IlInjected.Token(Token = "0x400015B")]
		Braze,
		[Cpp2IlInjected.Token(Token = "0x400015C")]
		Rengage
	}
	[Cpp2IlInjected.Token(Token = "0x2000076")]
	[Utf8JsonSerializable]
	public class CrmUserDTO : IRecNetUtf8JsonObject
	{
		[Cpp2IlInjected.Token(Token = "0x17000145")]
		public CrmType AssignedCrmType
		{
			[Cpp2IlInjected.Token(Token = "0x60002EB")]
			[Cpp2IlInjected.Address(RVA = "0xABD110", Offset = "0xABBF10", VA = "0x180ABD110")]
			[CompilerGenerated]
			get
			{
				return default(CrmType);
			}
			[Cpp2IlInjected.Token(Token = "0x60002EC")]
			[Cpp2IlInjected.Address(RVA = "0xAC1D40", Offset = "0xAC0B40", VA = "0x180AC1D40")]
			[CompilerGenerated]
			internal set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000146")]
		public PushNotificationServices? AssignedPushNotificationService
		{
			[Cpp2IlInjected.Token(Token = "0x60002ED")]
			[Cpp2IlInjected.Address(RVA = "0x3203830", Offset = "0x3202630", VA = "0x183203830")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60002EE")]
			[Cpp2IlInjected.Address(RVA = "0x7900E30", Offset = "0x78FFC30", VA = "0x187900E30")]
			[CompilerGenerated]
			internal set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000147")]
		public bool AllowPush
		{
			[Cpp2IlInjected.Token(Token = "0x60002EF")]
			[Cpp2IlInjected.Address(RVA = "0x209AB20", Offset = "0x2099920", VA = "0x18209AB20")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x60002F0")]
			[Cpp2IlInjected.Address(RVA = "0x209AB10", Offset = "0x2099910", VA = "0x18209AB10")]
			[CompilerGenerated]
			internal set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60002F1")]
		[Cpp2IlInjected.Address(RVA = "0x7A5A610", Offset = "0x7A59410", VA = "0x187A5A610")]
		public CrmUserDTO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002F2")]
		[Cpp2IlInjected.Address(RVA = "0x7A5A580", Offset = "0x7A59380", VA = "0x187A5A580")]
		public CrmUserDTO(CrmType assignedCrmType, PushNotificationServices assignedPushNotificationService, bool allowPush)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002F3")]
		[Cpp2IlInjected.Address(RVA = "0xABE8D0", Offset = "0xABD6D0", VA = "0x180ABE8D0", Slot = "4")]
		public void DNRPRHFLPRB()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000077")]
	[Utf8JsonSerializable]
	public class BrazeConfigDTO : IRecNetUtf8JsonObject
	{
		[Cpp2IlInjected.Token(Token = "0x17000148")]
		public string AppId
		{
			[Cpp2IlInjected.Token(Token = "0x60002F4")]
			[Cpp2IlInjected.Address(RVA = "0xABD130", Offset = "0xABBF30", VA = "0x180ABD130")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60002F5")]
			[Cpp2IlInjected.Address(RVA = "0xABD120", Offset = "0xABBF20", VA = "0x180ABD120")]
			[CompilerGenerated]
			internal set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000149")]
		public string SdkEndpoint
		{
			[Cpp2IlInjected.Token(Token = "0x60002F6")]
			[Cpp2IlInjected.Address(RVA = "0xAC0D20", Offset = "0xABFB20", VA = "0x180AC0D20")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60002F7")]
			[Cpp2IlInjected.Address(RVA = "0xAC0D10", Offset = "0xABFB10", VA = "0x180AC0D10")]
			[CompilerGenerated]
			internal set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60002F8")]
		[Cpp2IlInjected.Address(RVA = "0xAC4840", Offset = "0xAC3640", VA = "0x180AC4840")]
		public BrazeConfigDTO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002F9")]
		[Cpp2IlInjected.Address(RVA = "0xABFA30", Offset = "0xABE830", VA = "0x180ABFA30")]
		public BrazeConfigDTO(string appId, string sdkEndpoint)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002FA")]
		[Cpp2IlInjected.Address(RVA = "0xABE8D0", Offset = "0xABD6D0", VA = "0x180ABE8D0", Slot = "4")]
		public void DNRPRHFLPRB()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000078")]
	public enum DeviceClass
	{
		[Cpp2IlInjected.Token(Token = "0x4000163")]
		Unknown,
		[Cpp2IlInjected.Token(Token = "0x4000164")]
		VR,
		[Cpp2IlInjected.Token(Token = "0x4000165")]
		Screen,
		[Cpp2IlInjected.Token(Token = "0x4000166")]
		Mobile,
		[Cpp2IlInjected.Token(Token = "0x4000167")]
		VRLow,
		[Cpp2IlInjected.Token(Token = "0x4000168")]
		Quest2
	}
	[Cpp2IlInjected.Token(Token = "0x2000079")]
	public struct GiftPackageReceivedArgs
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000169")]
		public GiftPackage GiftPackage;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400016A")]
		public bool ShowImmediately;

		[Cpp2IlInjected.FieldOffset(Offset = "0x9")]
		[Cpp2IlInjected.Token(Token = "0x400016B")]
		public bool DismissExisting;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA")]
		[Cpp2IlInjected.Token(Token = "0x400016C")]
		public bool ShowNotification;
	}
	[Cpp2IlInjected.Token(Token = "0x200007A")]
	[Utf8JsonSerializable]
	public class GiftPackage : IRecNetUtf8JsonObjectPerformsPostProcessing, IRecNetUtf8JsonObject
	{
		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x200007B")]
		[CompilerGenerated]
		private struct <OnPostDeserialized>d__110 : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000189")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x400018A")]
			public AsyncTaskMethodBuilder <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400018B")]
			public GiftPackage <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x400018C")]
			private TaskAwaiter <>u__1;

			[Cpp2IlInjected.Token(Token = "0x6000334")]
			[Cpp2IlInjected.Address(RVA = "0x7A62BD0", Offset = "0x7A619D0", VA = "0x187A62BD0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000335")]
			[Cpp2IlInjected.Address(RVA = "0x7A62D60", Offset = "0x7A61B60", VA = "0x187A62D60", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x400016D")]
		internal static Action<GiftPackage> LZHTVDPEIKI;

		[Cpp2IlInjected.Token(Token = "0x400016E")]
		internal static Func<GiftPackage, Task> YBJPTPEPDQG;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC1")]
		[Cpp2IlInjected.Token(Token = "0x4000188")]
		[IgnoreDataMember]
		public bool IsGifted;

		[Cpp2IlInjected.Token(Token = "0x1700014A")]
		public long? Id
		{
			[Cpp2IlInjected.Token(Token = "0x60002FB")]
			[Cpp2IlInjected.Address(RVA = "0xEC6860", Offset = "0xEC5660", VA = "0x180EC6860")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60002FC")]
			[Cpp2IlInjected.Address(RVA = "0xEC6880", Offset = "0xEC5680", VA = "0x180EC6880")]
			[CompilerGenerated]
			internal set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700014B")]
		public int PlayerId
		{
			[Cpp2IlInjected.Token(Token = "0x60002FD")]
			[Cpp2IlInjected.Address(RVA = "0xACF4D0", Offset = "0xACE2D0", VA = "0x180ACF4D0")]
			[CompilerGenerated]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x60002FE")]
			[Cpp2IlInjected.Address(RVA = "0xB20FD0", Offset = "0xB1FDD0", VA = "0x180B20FD0")]
			[CompilerGenerated]
			internal set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700014C")]
		public int? FromPlayerId
		{
			[Cpp2IlInjected.Token(Token = "0x60002FF")]
			[Cpp2IlInjected.Address(RVA = "0x13E8E70", Offset = "0x13E7C70", VA = "0x1813E8E70")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000300")]
			[Cpp2IlInjected.Address(RVA = "0x10D56B0", Offset = "0x10D44B0", VA = "0x1810D56B0")]
			[CompilerGenerated]
			internal set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700014D")]
		public string ConsumableItemDesc
		{
			[Cpp2IlInjected.Token(Token = "0x6000301")]
			[Cpp2IlInjected.Address(RVA = "0xAC0F80", Offset = "0xABFD80", VA = "0x180AC0F80")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000302")]
			[Cpp2IlInjected.Address(RVA = "0xAC8C50", Offset = "0xAC7A50", VA = "0x180AC8C50")]
			[CompilerGenerated]
			internal set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700014E")]
		public AvatarItemType? AvatarItemType
		{
			[Cpp2IlInjected.Token(Token = "0x6000303")]
			[Cpp2IlInjected.Address(RVA = "0xAC0FC0", Offset = "0xABFDC0", VA = "0x180AC0FC0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000304")]
			[Cpp2IlInjected.Address(RVA = "0xAC6570", Offset = "0xAC5370", VA = "0x180AC6570")]
			[CompilerGenerated]
			internal set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700014F")]
		[DataMember(Name = "AvatarItemDesc")]
		public string AvatarItemDescOrHairDyeDesc
		{
			[Cpp2IlInjected.Token(Token = "0x6000305")]
			[Cpp2IlInjected.Address(RVA = "0xAC5120", Offset = "0xAC3F20", VA = "0x180AC5120")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000306")]
			[Cpp2IlInjected.Address(RVA = "0xAC0FB0", Offset = "0xABFDB0", VA = "0x180AC0FB0")]
			[CompilerGenerated]
			internal set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000150")]
		public Guid? CustomAvatarItemId
		{
			[Cpp2IlInjected.Token(Token = "0x6000307")]
			[Cpp2IlInjected.Address(RVA = "0xE2B770", Offset = "0xE2A570", VA = "0x180E2B770")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000308")]
			[Cpp2IlInjected.Address(RVA = "0xE2C080", Offset = "0xE2AE80", VA = "0x180E2C080")]
			[CompilerGenerated]
			internal set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000151")]
		public string EquipmentPrefabName
		{
			[Cpp2IlInjected.Token(Token = "0x6000309")]
			[Cpp2IlInjected.Address(RVA = "0xAC31D0", Offset = "0xAC1FD0", VA = "0x180AC31D0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600030A")]
			[Cpp2IlInjected.Address(RVA = "0xAC3420", Offset = "0xAC2220", VA = "0x180AC3420")]
			[CompilerGenerated]
			internal set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000152")]
		public string EquipmentModificationGuid
		{
			[Cpp2IlInjected.Token(Token = "0x600030B")]
			[Cpp2IlInjected.Address(RVA = "0xAC3410", Offset = "0xAC2210", VA = "0x180AC3410")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600030C")]
			[Cpp2IlInjected.Address(RVA = "0xAC31A0", Offset = "0xAC1FA0", VA = "0x180AC31A0")]
			[CompilerGenerated]
			internal set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000153")]
		public CurrencyType CurrencyType
		{
			[Cpp2IlInjected.Token(Token = "0x600030D")]
			[Cpp2IlInjected.Address(RVA = "0x128BCF0", Offset = "0x128AAF0", VA = "0x18128BCF0")]
			[CompilerGenerated]
			get
			{
				return default(CurrencyType);
			}
			[Cpp2IlInjected.Token(Token = "0x600030E")]
			[Cpp2IlInjected.Address(RVA = "0x1817B80", Offset = "0x1816980", VA = "0x181817B80")]
			[CompilerGenerated]
			internal set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000154")]
		public int Currency
		{
			[Cpp2IlInjected.Token(Token = "0x600030F")]
			[Cpp2IlInjected.Address(RVA = "0xAF4E10", Offset = "0xAF3C10", VA = "0x180AF4E10")]
			[CompilerGenerated]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x6000310")]
			[Cpp2IlInjected.Address(RVA = "0x15F65B0", Offset = "0x15F53B0", VA = "0x1815F65B0")]
			[CompilerGenerated]
			internal set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000155")]
		public int Xp
		{
			[Cpp2IlInjected.Token(Token = "0x6000311")]
			[Cpp2IlInjected.Address(RVA = "0xAE56C0", Offset = "0xAE44C0", VA = "0x180AE56C0")]
			[CompilerGenerated]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x6000312")]
			[Cpp2IlInjected.Address(RVA = "0x15F6100", Offset = "0x15F4F00", VA = "0x1815F6100")]
			[CompilerGenerated]
			internal set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000156")]
		public GiftContext GiftContext
		{
			[Cpp2IlInjected.Token(Token = "0x6000313")]
			[Cpp2IlInjected.Address(RVA = "0xAE5720", Offset = "0xAE4520", VA = "0x180AE5720")]
			[CompilerGenerated]
			get
			{
				return default(GiftContext);
			}
			[Cpp2IlInjected.Token(Token = "0x6000314")]
			[Cpp2IlInjected.Address(RVA = "0x15F58D0", Offset = "0x15F46D0", VA = "0x1815F58D0")]
			[CompilerGenerated]
			internal set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000157")]
		public GiftRarity GiftRarity
		{
			[Cpp2IlInjected.Token(Token = "0x6000315")]
			[Cpp2IlInjected.Address(RVA = "0xFABA20", Offset = "0xFAA820", VA = "0x180FABA20")]
			[CompilerGenerated]
			get
			{
				return default(GiftRarity);
			}
			[Cpp2IlInjected.Token(Token = "0x6000316")]
			[Cpp2IlInjected.Address(RVA = "0x1AC10A0", Offset = "0x1ABFEA0", VA = "0x181AC10A0")]
			[CompilerGenerated]
			internal set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000158")]
		[DataMember(Name = "Message")]
		public string RawMessage
		{
			[Cpp2IlInjected.Token(Token = "0x6000317")]
			[Cpp2IlInjected.Address(RVA = "0xAC7B00", Offset = "0xAC6900", VA = "0x180AC7B00")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000318")]
			[Cpp2IlInjected.Address(RVA = "0xAC81D0", Offset = "0xAC6FD0", VA = "0x180AC81D0")]
			[CompilerGenerated]
			internal set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000159")]
		public string Signature
		{
			[Cpp2IlInjected.Token(Token = "0x6000319")]
			[Cpp2IlInjected.Address(RVA = "0xAEDD70", Offset = "0xAECB70", VA = "0x180AEDD70")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600031A")]
			[Cpp2IlInjected.Address(RVA = "0xB880F0", Offset = "0xB86EF0", VA = "0x180B880F0")]
			[CompilerGenerated]
			internal set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700015A")]
		public bool IsSignatureValid
		{
			[Cpp2IlInjected.Token(Token = "0x600031B")]
			[Cpp2IlInjected.Address(RVA = "0xAEDD60", Offset = "0xAECB60", VA = "0x180AEDD60")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x600031C")]
			[Cpp2IlInjected.Address(RVA = "0xAED2F0", Offset = "0xAEC0F0", VA = "0x180AED2F0")]
			[CompilerGenerated]
			internal set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700015B")]
		public PlatformType Platform
		{
			[Cpp2IlInjected.Token(Token = "0x600031D")]
			[Cpp2IlInjected.Address(RVA = "0x2D95BC0", Offset = "0x2D949C0", VA = "0x182D95BC0")]
			[CompilerGenerated]
			get
			{
				return default(PlatformType);
			}
			[Cpp2IlInjected.Token(Token = "0x600031E")]
			[Cpp2IlInjected.Address(RVA = "0x78A1140", Offset = "0x789FF40", VA = "0x1878A1140")]
			[CompilerGenerated]
			internal set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700015C")]
		public PlatformMask PlatformsToSpawnOn
		{
			[Cpp2IlInjected.Token(Token = "0x600031F")]
			[Cpp2IlInjected.Address(RVA = "0xAC7B10", Offset = "0xAC6910", VA = "0x180AC7B10")]
			[CompilerGenerated]
			get
			{
				return default(PlatformMask);
			}
			[Cpp2IlInjected.Token(Token = "0x6000320")]
			[Cpp2IlInjected.Address(RVA = "0xAC7B40", Offset = "0xAC6940", VA = "0x180AC7B40")]
			[CompilerGenerated]
			internal set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700015D")]
		public StorefrontBalanceType? BalanceType
		{
			[Cpp2IlInjected.Token(Token = "0x6000321")]
			[Cpp2IlInjected.Address(RVA = "0x7A5C020", Offset = "0x7A5AE20", VA = "0x187A5C020")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000322")]
			[Cpp2IlInjected.Address(RVA = "0x1E1C500", Offset = "0x1E1B300", VA = "0x181E1C500")]
			[CompilerGenerated]
			internal set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700015E")]
		public bool HasAvatarItemOrHairDye
		{
			[Cpp2IlInjected.Token(Token = "0x6000323")]
			[Cpp2IlInjected.Address(RVA = "0x7A5C030", Offset = "0x7A5AE30", VA = "0x187A5C030")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700015F")]
		public bool HasEquipment
		{
			[Cpp2IlInjected.Token(Token = "0x6000324")]
			[Cpp2IlInjected.Address(RVA = "0x7A5C0C0", Offset = "0x7A5AEC0", VA = "0x187A5C0C0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000160")]
		public bool HasConsumable
		{
			[Cpp2IlInjected.Token(Token = "0x6000325")]
			[Cpp2IlInjected.Address(RVA = "0x7A5C0A0", Offset = "0x7A5AEA0", VA = "0x187A5C0A0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000161")]
		[IgnoreDataMember]
		public bool Consumed
		{
			[Cpp2IlInjected.Token(Token = "0x6000326")]
			[Cpp2IlInjected.Address(RVA = "0xAC4890", Offset = "0xAC3690", VA = "0x180AC4890")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000327")]
			[Cpp2IlInjected.Address(RVA = "0xAC4B00", Offset = "0xAC3900", VA = "0x180AC4B00")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000162")]
		[IgnoreDataMember]
		public bool IsValid
		{
			[Cpp2IlInjected.Token(Token = "0x6000328")]
			[Cpp2IlInjected.Address(RVA = "0x2EA08F0", Offset = "0x2E9F6F0", VA = "0x182EA08F0")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000329")]
			[Cpp2IlInjected.Address(RVA = "0x2EA08E0", Offset = "0x2E9F6E0", VA = "0x182EA08E0")]
			[CompilerGenerated]
			internal set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000163")]
		[IgnoreDataMember]
		public string CustomMessage
		{
			[Cpp2IlInjected.Token(Token = "0x600032A")]
			[Cpp2IlInjected.Address(RVA = "0xB88130", Offset = "0xB86F30", VA = "0x180B88130")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600032B")]
			[Cpp2IlInjected.Address(RVA = "0xB880C0", Offset = "0xB86EC0", VA = "0x180B880C0")]
			[CompilerGenerated]
			internal set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000164")]
		[IgnoreDataMember]
		public string ErrorMessage
		{
			[Cpp2IlInjected.Token(Token = "0x600032C")]
			[Cpp2IlInjected.Address(RVA = "0xEF42F0", Offset = "0xEF30F0", VA = "0x180EF42F0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600032D")]
			[Cpp2IlInjected.Address(RVA = "0x151C850", Offset = "0x151B650", VA = "0x18151C850")]
			[CompilerGenerated]
			internal set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000165")]
		[IgnoreDataMember]
		public bool CanSpawnOnCurrentPlatform
		{
			[Cpp2IlInjected.Token(Token = "0x600032E")]
			[Cpp2IlInjected.Address(RVA = "0xE1D040", Offset = "0xE1BE40", VA = "0x180E1D040")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x600032F")]
			[Cpp2IlInjected.Address(RVA = "0xE1B5D0", Offset = "0xE1A3D0", VA = "0x180E1B5D0")]
			[CompilerGenerated]
			internal set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000330")]
		[Cpp2IlInjected.Address(RVA = "0x7A5BEF0", Offset = "0x7A5ACF0", VA = "0x187A5BEF0", Slot = "5")]
		public void DNRPRHFLPRB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000331")]
		[Cpp2IlInjected.Address(RVA = "0x7A5BF50", Offset = "0x7A5AD50", VA = "0x187A5BF50", Slot = "6")]
		[AsyncStateMachine(typeof(<OnPostDeserialized>d__110))]
		public virtual Task WSLKELMBPUB()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000332")]
		[Cpp2IlInjected.Address(RVA = "0x15F58D0", Offset = "0x15F46D0", VA = "0x1815F58D0")]
		public void INPASNKHKWS(GiftContext a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000333")]
		[Cpp2IlInjected.Address(RVA = "0xAC4840", Offset = "0xAC3640", VA = "0x180AC4840")]
		public GiftPackage()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200007C")]
	public interface GTJRSZJNGMY
	{
		[Cpp2IlInjected.Token(Token = "0x17000166")]
		long InventionId
		{
			[Cpp2IlInjected.Token(Token = "0x6000338")]
			[Cpp2IlInjected.Address(Slot = "2")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000167")]
		string ReplicationId
		{
			[Cpp2IlInjected.Token(Token = "0x6000339")]
			[Cpp2IlInjected.Address(Slot = "3")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000168")]
		int CreatorPlayerId
		{
			[Cpp2IlInjected.Token(Token = "0x600033A")]
			[Cpp2IlInjected.Address(Slot = "4")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000169")]
		string Name
		{
			[Cpp2IlInjected.Token(Token = "0x600033B")]
			[Cpp2IlInjected.Address(Slot = "5")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x1700016A")]
		string Description
		{
			[Cpp2IlInjected.Token(Token = "0x600033C")]
			[Cpp2IlInjected.Address(Slot = "6")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x1700016B")]
		string LongDescription
		{
			[Cpp2IlInjected.Token(Token = "0x600033D")]
			[Cpp2IlInjected.Address(Slot = "7")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x1700016C")]
		string ImageName
		{
			[Cpp2IlInjected.Token(Token = "0x600033E")]
			[Cpp2IlInjected.Address(Slot = "8")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x1700016D")]
		byte UgcVersion
		{
			[Cpp2IlInjected.Token(Token = "0x600033F")]
			[Cpp2IlInjected.Address(Slot = "9")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x1700016E")]
		int CurrentVersionNumber
		{
			[Cpp2IlInjected.Token(Token = "0x6000340")]
			[Cpp2IlInjected.Address(Slot = "10")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x1700016F")]
		int LatestVersionNumber
		{
			[Cpp2IlInjected.Token(Token = "0x6000341")]
			[Cpp2IlInjected.Address(Slot = "11")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000170")]
		UgcAccessibility Accessibility
		{
			[Cpp2IlInjected.Token(Token = "0x6000342")]
			[Cpp2IlInjected.Address(Slot = "12")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000171")]
		bool ForceCannotPublish
		{
			[Cpp2IlInjected.Token(Token = "0x6000343")]
			[Cpp2IlInjected.Address(Slot = "13")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000172")]
		DateTime ModifiedAt
		{
			[Cpp2IlInjected.Token(Token = "0x6000344")]
			[Cpp2IlInjected.Address(Slot = "14")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000173")]
		DateTime CreatedAt
		{
			[Cpp2IlInjected.Token(Token = "0x6000345")]
			[Cpp2IlInjected.Address(Slot = "15")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000174")]
		DateTime? FirstPublishedAt
		{
			[Cpp2IlInjected.Token(Token = "0x6000346")]
			[Cpp2IlInjected.Address(Slot = "16")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000175")]
		long? CreationRoomId
		{
			[Cpp2IlInjected.Token(Token = "0x6000347")]
			[Cpp2IlInjected.Address(Slot = "17")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000176")]
		int NumPlayersHaveUsedInRoom
		{
			[Cpp2IlInjected.Token(Token = "0x6000348")]
			[Cpp2IlInjected.Address(Slot = "18")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000177")]
		int NumDownloads
		{
			[Cpp2IlInjected.Token(Token = "0x6000349")]
			[Cpp2IlInjected.Address(Slot = "19")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000178")]
		int CheerCount
		{
			[Cpp2IlInjected.Token(Token = "0x600034A")]
			[Cpp2IlInjected.Address(Slot = "20")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000179")]
		InventionPermission CreatorPermission
		{
			[Cpp2IlInjected.Token(Token = "0x600034B")]
			[Cpp2IlInjected.Address(Slot = "21")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x1700017A")]
		InventionPermission GeneralPermission
		{
			[Cpp2IlInjected.Token(Token = "0x600034C")]
			[Cpp2IlInjected.Address(Slot = "22")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x1700017B")]
		bool IsAgInvention
		{
			[Cpp2IlInjected.Token(Token = "0x600034D")]
			[Cpp2IlInjected.Address(Slot = "23")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x1700017C")]
		bool IsCertifiedInvention
		{
			[Cpp2IlInjected.Token(Token = "0x600034E")]
			[Cpp2IlInjected.Address(Slot = "24")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x1700017D")]
		bool IsRecRoomApproved
		{
			[Cpp2IlInjected.Token(Token = "0x600034F")]
			[Cpp2IlInjected.Address(Slot = "25")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x1700017E")]
		bool AllowTrial
		{
			[Cpp2IlInjected.Token(Token = "0x6000350")]
			[Cpp2IlInjected.Address(Slot = "26")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x1700017F")]
		int? Price
		{
			[Cpp2IlInjected.Token(Token = "0x6000351")]
			[Cpp2IlInjected.Address(Slot = "27")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000180")]
		bool HideFromPlayer
		{
			[Cpp2IlInjected.Token(Token = "0x6000352")]
			[Cpp2IlInjected.Address(Slot = "28")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000181")]
		string DisplayMetadataJson
		{
			[Cpp2IlInjected.Token(Token = "0x6000353")]
			[Cpp2IlInjected.Address(Slot = "29")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x6000336")]
		[Cpp2IlInjected.Address(Slot = "0")]
		bool COSBFXWSQJB();

		[Cpp2IlInjected.Token(Token = "0x6000337")]
		[Cpp2IlInjected.Address(Slot = "1")]
		bool RSSMEGDIPWN();
	}
	[Cpp2IlInjected.Token(Token = "0x200007D")]
	[Utf8JsonSerializable]
	public class InventionDetails : IRecNetUtf8JsonObject
	{
		[Cpp2IlInjected.Token(Token = "0x17000182")]
		public List<TagDTO> Tags
		{
			[Cpp2IlInjected.Token(Token = "0x6000354")]
			[Cpp2IlInjected.Address(RVA = "0xABD130", Offset = "0xABBF30", VA = "0x180ABD130")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000355")]
			[Cpp2IlInjected.Address(RVA = "0xABD120", Offset = "0xABBF20", VA = "0x180ABD120")]
			[CompilerGenerated]
			internal set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000356")]
		[Cpp2IlInjected.Address(RVA = "0x7A5CCF0", Offset = "0x7A5BAF0", VA = "0x187A5CCF0")]
		public List<string> QSCQLRXVVIJ(params TagType[] tagTypes)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000357")]
		[Cpp2IlInjected.Address(RVA = "0x7A5CBB0", Offset = "0x7A5B9B0", VA = "0x187A5CBB0")]
		public List<string> DOYQBHHMUKP()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000358")]
		[Cpp2IlInjected.Address(RVA = "0x7A5CC70", Offset = "0x7A5BA70", VA = "0x187A5CC70")]
		public List<string> HBLUNSGXOXK()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000359")]
		[Cpp2IlInjected.Address(RVA = "0x7A5CC20", Offset = "0x7A5BA20", VA = "0x187A5CC20")]
		public List<string> GIFPXWXIBOP()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600035A")]
		[Cpp2IlInjected.Address(RVA = "0x7A5CAC0", Offset = "0x7A5B8C0", VA = "0x187A5CAC0", Slot = "4")]
		public void DNRPRHFLPRB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600035B")]
		[Cpp2IlInjected.Address(RVA = "0xAC4840", Offset = "0xAC3640", VA = "0x180AC4840")]
		public InventionDetails()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200007E")]
	[Utf8JsonSerializable]
	public class InventionCreatorIdDTO : IRecNetUtf8JsonObject
	{
		[Cpp2IlInjected.Token(Token = "0x17000183")]
		public int CreatorPlayerId
		{
			[Cpp2IlInjected.Token(Token = "0x600035C")]
			[Cpp2IlInjected.Address(RVA = "0xABD110", Offset = "0xABBF10", VA = "0x180ABD110")]
			[CompilerGenerated]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x600035D")]
			[Cpp2IlInjected.Address(RVA = "0xAC1D40", Offset = "0xAC0B40", VA = "0x180AC1D40")]
			[CompilerGenerated]
			internal set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600035E")]
		[Cpp2IlInjected.Address(RVA = "0xABE8D0", Offset = "0xABD6D0", VA = "0x180ABE8D0", Slot = "4")]
		public void DNRPRHFLPRB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600035F")]
		[Cpp2IlInjected.Address(RVA = "0xAC4840", Offset = "0xAC3640", VA = "0x180AC4840")]
		public InventionCreatorIdDTO()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200007F")]
	[Utf8JsonSerializable]
	public class InventionVersion : IRecNetUtf8JsonObject
	{
		[Cpp2IlInjected.Token(Token = "0x17000184")]
		public long InventionId
		{
			[Cpp2IlInjected.Token(Token = "0x6000360")]
			[Cpp2IlInjected.Address(RVA = "0xABD130", Offset = "0xABBF30", VA = "0x180ABD130")]
			[CompilerGenerated]
			get
			{
				return default(long);
			}
			[Cpp2IlInjected.Token(Token = "0x6000361")]
			[Cpp2IlInjected.Address(RVA = "0xEABA00", Offset = "0xEAA800", VA = "0x180EABA00")]
			[CompilerGenerated]
			internal set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000185")]
		public string ReplicationId
		{
			[Cpp2IlInjected.Token(Token = "0x6000362")]
			[Cpp2IlInjected.Address(RVA = "0xAC0D20", Offset = "0xABFB20", VA = "0x180AC0D20")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000363")]
			[Cpp2IlInjected.Address(RVA = "0xAC0D10", Offset = "0xABFB10", VA = "0x180AC0D10")]
			[CompilerGenerated]
			internal set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000186")]
		public int VersionNumber
		{
			[Cpp2IlInjected.Token(Token = "0x6000364")]
			[Cpp2IlInjected.Address(RVA = "0xACF4D0", Offset = "0xACE2D0", VA = "0x180ACF4D0")]
			[CompilerGenerated]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x6000365")]
			[Cpp2IlInjected.Address(RVA = "0xB20FD0", Offset = "0xB1FDD0", VA = "0x180B20FD0")]
			[CompilerGenerated]
			internal set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000187")]
		public bool HasBetaContent
		{
			[Cpp2IlInjected.Token(Token = "0x6000366")]
			[Cpp2IlInjected.Address(RVA = "0xEBF2C0", Offset = "0xEBE0C0", VA = "0x180EBF2C0")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000367")]
			[Cpp2IlInjected.Address(RVA = "0xEBF160", Offset = "0xEBDF60", VA = "0x180EBF160")]
			[CompilerGenerated]
			internal set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000188")]
		public int InstantiationCost
		{
			[Cpp2IlInjected.Token(Token = "0x6000368")]
			[Cpp2IlInjected.Address(RVA = "0xAC2060", Offset = "0xAC0E60", VA = "0x180AC2060")]
			[CompilerGenerated]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x6000369")]
			[Cpp2IlInjected.Address(RVA = "0xAC1D30", Offset = "0xAC0B30", VA = "0x180AC1D30")]
			[CompilerGenerated]
			internal set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000189")]
		public int LightsCost
		{
			[Cpp2IlInjected.Token(Token = "0x600036A")]
			[Cpp2IlInjected.Address(RVA = "0xC56CD0", Offset = "0xC55AD0", VA = "0x180C56CD0")]
			[CompilerGenerated]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x600036B")]
			[Cpp2IlInjected.Address(RVA = "0x1D9ACF0", Offset = "0x1D99AF0", VA = "0x181D9ACF0")]
			[CompilerGenerated]
			internal set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700018A")]
		public int ChipsCost
		{
			[Cpp2IlInjected.Token(Token = "0x600036C")]
			[Cpp2IlInjected.Address(RVA = "0xAC6560", Offset = "0xAC5360", VA = "0x180AC6560")]
			[CompilerGenerated]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x600036D")]
			[Cpp2IlInjected.Address(RVA = "0xAC6870", Offset = "0xAC5670", VA = "0x180AC6870")]
			[CompilerGenerated]
			internal set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700018B")]
		public int CloudVariablesCost
		{
			[Cpp2IlInjected.Token(Token = "0x600036E")]
			[Cpp2IlInjected.Address(RVA = "0xB0D1F0", Offset = "0xB0BFF0", VA = "0x180B0D1F0")]
			[CompilerGenerated]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x600036F")]
			[Cpp2IlInjected.Address(RVA = "0x16C3590", Offset = "0x16C2390", VA = "0x1816C3590")]
			[CompilerGenerated]
			internal set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700018C")]
		public string BlobName
		{
			[Cpp2IlInjected.Token(Token = "0x6000370")]
			[Cpp2IlInjected.Address(RVA = "0xAC0FC0", Offset = "0xABFDC0", VA = "0x180AC0FC0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000371")]
			[Cpp2IlInjected.Address(RVA = "0xAC0CF0", Offset = "0xABFAF0", VA = "0x180AC0CF0")]
			[CompilerGenerated]
			internal set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700018D")]
		public string BlobHash
		{
			[Cpp2IlInjected.Token(Token = "0x6000372")]
			[Cpp2IlInjected.Address(RVA = "0xAC5120", Offset = "0xAC3F20", VA = "0x180AC5120")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000373")]
			[Cpp2IlInjected.Address(RVA = "0xAC0FB0", Offset = "0xABFDB0", VA = "0x180AC0FB0")]
			[CompilerGenerated]
			internal set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700018E")]
		public DateTime CreatedAt
		{
			[Cpp2IlInjected.Token(Token = "0x6000374")]
			[Cpp2IlInjected.Address(RVA = "0xAC0D30", Offset = "0xABFB30", VA = "0x180AC0D30")]
			[CompilerGenerated]
			get
			{
				return default(DateTime);
			}
			[Cpp2IlInjected.Token(Token = "0x6000375")]
			[Cpp2IlInjected.Address(RVA = "0x13EE3C0", Offset = "0x13ED1C0", VA = "0x1813EE3C0")]
			[CompilerGenerated]
			internal set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700018F")]
		public UgcAccessibility? UgcAccessibility
		{
			[Cpp2IlInjected.Token(Token = "0x6000376")]
			[Cpp2IlInjected.Address(RVA = "0xAC31E0", Offset = "0xAC1FE0", VA = "0x180AC31E0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000377")]
			[Cpp2IlInjected.Address(RVA = "0xFDBE00", Offset = "0xFDAC00", VA = "0x180FDBE00")]
			[CompilerGenerated]
			internal set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000190")]
		public IReadOnlyList<Guid> ReferencedUnityAssetIds
		{
			[Cpp2IlInjected.Token(Token = "0x6000378")]
			[Cpp2IlInjected.Address(RVA = "0xAC3430", Offset = "0xAC2230", VA = "0x180AC3430")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000379")]
			[Cpp2IlInjected.Address(RVA = "0xAC31B0", Offset = "0xAC1FB0", VA = "0x180AC31B0")]
			[CompilerGenerated]
			internal set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000191")]
		public FilenameWithHash BlobNameWithHash
		{
			[Cpp2IlInjected.Token(Token = "0x6000380")]
			[Cpp2IlInjected.Address(RVA = "0x7A5D1C0", Offset = "0x7A5BFC0", VA = "0x187A5D1C0")]
			get
			{
				return default(FilenameWithHash);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600037A")]
		[Cpp2IlInjected.Address(RVA = "0xABE8D0", Offset = "0xABD6D0", VA = "0x180ABE8D0", Slot = "4")]
		public void DNRPRHFLPRB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600037B")]
		[Cpp2IlInjected.Address(RVA = "0x7A5CEC0", Offset = "0x7A5BCC0", VA = "0x187A5CEC0", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600037C")]
		[Cpp2IlInjected.Address(RVA = "0x7A5CEB0", Offset = "0x7A5BCB0", VA = "0x187A5CEB0")]
		public bool Equals(InventionVersion v2)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600037D")]
		[Cpp2IlInjected.Address(RVA = "0x7A5CF40", Offset = "0x7A5BD40", VA = "0x187A5CF40")]
		private bool HXZVREQJAZR(InventionVersion a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600037E")]
		[Cpp2IlInjected.Address(RVA = "0x7A5D120", Offset = "0x7A5BF20", VA = "0x187A5D120")]
		private static bool KYDWIKHCRGX(IReadOnlyList<Guid> a, IReadOnlyList<Guid> b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600037F")]
		[Cpp2IlInjected.Address(RVA = "0x2AE0F10", Offset = "0x2ADFD10", VA = "0x182AE0F10", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000381")]
		[Cpp2IlInjected.Address(RVA = "0xAC4840", Offset = "0xAC3640", VA = "0x180AC4840")]
		public InventionVersion()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000080")]
	[Utf8JsonSerializable]
	public class InventionTrialDurationResponse : IRecNetUtf8JsonObject
	{
		[Cpp2IlInjected.Token(Token = "0x17000192")]
		public int Duration
		{
			[Cpp2IlInjected.Token(Token = "0x6000382")]
			[Cpp2IlInjected.Address(RVA = "0xABD110", Offset = "0xABBF10", VA = "0x180ABD110")]
			[CompilerGenerated]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x6000383")]
			[Cpp2IlInjected.Address(RVA = "0xAC1D40", Offset = "0xAC0B40", VA = "0x180AC1D40")]
			[CompilerGenerated]
			internal set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000384")]
		[Cpp2IlInjected.Address(RVA = "0xABE8D0", Offset = "0xABD6D0", VA = "0x180ABE8D0", Slot = "4")]
		public void DNRPRHFLPRB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000385")]
		[Cpp2IlInjected.Address(RVA = "0xAC4840", Offset = "0xAC3640", VA = "0x180AC4840")]
		public InventionTrialDurationResponse()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000081")]
	[Utf8JsonSerializable]
	public class PersonalInventionDetails : IRecNetUtf8JsonObject
	{
		[Cpp2IlInjected.Token(Token = "0x17000193")]
		public bool IsCheering
		{
			[Cpp2IlInjected.Token(Token = "0x6000386")]
			[Cpp2IlInjected.Address(RVA = "0xB12A00", Offset = "0xB11800", VA = "0x180B12A00")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000387")]
			[Cpp2IlInjected.Address(RVA = "0xBA1650", Offset = "0xBA0450", VA = "0x180BA1650")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000388")]
		[Cpp2IlInjected.Address(RVA = "0xABE8D0", Offset = "0xABD6D0", VA = "0x180ABE8D0", Slot = "4")]
		public void DNRPRHFLPRB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000389")]
		[Cpp2IlInjected.Address(RVA = "0xAC4840", Offset = "0xAC3640", VA = "0x180AC4840")]
		public PersonalInventionDetails()
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000082")]
	[Utf8JsonSerializable]
	public class NewInventionRequestDTO : IRecNetUtf8JsonObject
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400019E")]
		public string name;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400019F")]
		public string description;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40001A0")]
		public string imageName;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40001A1")]
		public bool hasBetaContent;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
		[Cpp2IlInjected.Token(Token = "0x40001A2")]
		public int instantiationCost;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40001A3")]
		public int lightsCost;

		[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
		[Cpp2IlInjected.Token(Token = "0x40001A4")]
		public int chipsCost;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40001A5")]
		public int cloudVariablesCost;

		[Cpp2IlInjected.FieldOffset(Offset = "0x3C")]
		[Cpp2IlInjected.Token(Token = "0x40001A6")]
		public int aiCost;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40001A7")]
		public byte ugcVersion;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40001A8")]
		public long creationRoomId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40001A9")]
		public string inventionDataFilename;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40001AA")]
		public List<long> referencedInventions;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x40001AB")]
		public IReadOnlyList<Guid> referencedUnityAssetIds;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x40001AC")]
		public AccountRoleType creatorAccountRole;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x40001AD")]
		public long? convertedFromInventionId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x40001AE")]
		public string displayMetadataJson;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x40001AF")]
		public string longDescription;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x40001B0")]
		public ModifyTagsRequest tagsRequest;

		[Cpp2IlInjected.Token(Token = "0x600038A")]
		[Cpp2IlInjected.Address(RVA = "0x1091BE0", Offset = "0x10909E0", VA = "0x181091BE0", Slot = "4")]
		public void DNRPRHFLPRB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600038B")]
		[Cpp2IlInjected.Address(RVA = "0x7A5EFC0", Offset = "0x7A5DDC0", VA = "0x187A5EFC0")]
		public NewInventionRequestDTO()
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000083")]
	[Utf8JsonSerializable]
	public class AddVersionInventionRequestDTO : IRecNetUtf8JsonObject
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40001B1")]
		public long inventionId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40001B2")]
		public bool hasBetaContent;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x40001B3")]
		public int instantiationCost;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40001B4")]
		public int lightsCost;

		[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
		[Cpp2IlInjected.Token(Token = "0x40001B5")]
		public int chipsCost;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40001B6")]
		public int cloudVariablesCost;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
		[Cpp2IlInjected.Token(Token = "0x40001B7")]
		public int aiCost;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40001B8")]
		public byte ugcVersion;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40001B9")]
		public long creationRoomId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40001BA")]
		public string inventionDataFilename;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40001BB")]
		public List<long> referencedInventions;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40001BC")]
		public IReadOnlyList<Guid> referencedUnityAssetIds;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40001BD")]
		public ModifyTagsRequest tagsRequest;

		[Cpp2IlInjected.Token(Token = "0x600038C")]
		[Cpp2IlInjected.Address(RVA = "0x1091BE0", Offset = "0x10909E0", VA = "0x181091BE0", Slot = "4")]
		public void DNRPRHFLPRB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600038D")]
		[Cpp2IlInjected.Address(RVA = "0x7A59070", Offset = "0x7A57E70", VA = "0x187A59070")]
		public AddVersionInventionRequestDTO()
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000084")]
	[Utf8JsonSerializable]
	public class ModifyTagsRequest : IRecNetUtf8JsonObject
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40001BE")]
		public List<string> AutoTags;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40001BF")]
		public List<string> CustomTags;

		[Cpp2IlInjected.Token(Token = "0x600038E")]
		[Cpp2IlInjected.Address(RVA = "0xABE8D0", Offset = "0xABD6D0", VA = "0x180ABE8D0", Slot = "4")]
		public void DNRPRHFLPRB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600038F")]
		[Cpp2IlInjected.Address(RVA = "0xAC4840", Offset = "0xAC3640", VA = "0x180AC4840")]
		public ModifyTagsRequest()
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000085")]
	[Utf8JsonSerializable]
	public class InventionModifyTagsRequest : ModifyTagsRequest
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40001C0")]
		public long InventionId;

		[Cpp2IlInjected.Token(Token = "0x6000390")]
		[Cpp2IlInjected.Address(RVA = "0xAC4840", Offset = "0xAC3640", VA = "0x180AC4840")]
		public InventionModifyTagsRequest()
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000086")]
	[Utf8JsonSerializable]
	public class ReportRequest : IRecNetUtf8JsonObject
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40001C1")]
		public long InventionId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40001C2")]
		public string Details;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40001C3")]
		public InventionReportCategory ReportCategory;

		[Cpp2IlInjected.Token(Token = "0x6000391")]
		[Cpp2IlInjected.Address(RVA = "0xABE8D0", Offset = "0xABD6D0", VA = "0x180ABE8D0", Slot = "4")]
		public void DNRPRHFLPRB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000392")]
		[Cpp2IlInjected.Address(RVA = "0xAC4840", Offset = "0xAC3640", VA = "0x180AC4840")]
		public ReportRequest()
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000087")]
	[Utf8JsonSerializable]
	public class CheerRequest : IRecNetUtf8JsonObject
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40001C4")]
		public long InventionId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40001C5")]
		public bool Cheer;

		[Cpp2IlInjected.Token(Token = "0x6000393")]
		[Cpp2IlInjected.Address(RVA = "0xABE8D0", Offset = "0xABD6D0", VA = "0x180ABE8D0", Slot = "4")]
		public void DNRPRHFLPRB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000394")]
		[Cpp2IlInjected.Address(RVA = "0xAC4840", Offset = "0xAC3640", VA = "0x180AC4840")]
		public CheerRequest()
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000088")]
	[Utf8JsonSerializable]
	public class UpdatePriceRequest : IRecNetUtf8JsonObject
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40001C6")]
		public long InventionId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40001C7")]
		public int Price;

		[Cpp2IlInjected.Token(Token = "0x6000395")]
		[Cpp2IlInjected.Address(RVA = "0xABE8D0", Offset = "0xABD6D0", VA = "0x180ABE8D0", Slot = "4")]
		public void DNRPRHFLPRB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000396")]
		[Cpp2IlInjected.Address(RVA = "0xAC4840", Offset = "0xAC3640", VA = "0x180AC4840")]
		public UpdatePriceRequest()
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000089")]
	[Utf8JsonSerializable]
	public class UpdateInventionMetadataRequest : IRecNetUtf8JsonObject
	{
		[Cpp2IlInjected.Token(Token = "0x17000194")]
		public long InventionId
		{
			[Cpp2IlInjected.Token(Token = "0x6000397")]
			[Cpp2IlInjected.Address(RVA = "0xABD130", Offset = "0xABBF30", VA = "0x180ABD130")]
			[CompilerGenerated]
			get
			{
				return default(long);
			}
			[Cpp2IlInjected.Token(Token = "0x6000398")]
			[Cpp2IlInjected.Address(RVA = "0xEABA00", Offset = "0xEAA800", VA = "0x180EABA00")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000195")]
		public string Name
		{
			[Cpp2IlInjected.Token(Token = "0x6000399")]
			[Cpp2IlInjected.Address(RVA = "0xAC0D20", Offset = "0xABFB20", VA = "0x180AC0D20")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600039A")]
			[Cpp2IlInjected.Address(RVA = "0xAC0D10", Offset = "0xABFB10", VA = "0x180AC0D10")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000196")]
		public string Description
		{
			[Cpp2IlInjected.Token(Token = "0x600039B")]
			[Cpp2IlInjected.Address(RVA = "0xAC1D20", Offset = "0xAC0B20", VA = "0x180AC1D20")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600039C")]
			[Cpp2IlInjected.Address(RVA = "0xAC0640", Offset = "0xABF440", VA = "0x180AC0640")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000197")]
		public string LongDescription
		{
			[Cpp2IlInjected.Token(Token = "0x600039D")]
			[Cpp2IlInjected.Address(RVA = "0xAC0F90", Offset = "0xABFD90", VA = "0x180AC0F90")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600039E")]
			[Cpp2IlInjected.Address(RVA = "0xAC0650", Offset = "0xABF450", VA = "0x180AC0650")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000198")]
		public string ImageName
		{
			[Cpp2IlInjected.Token(Token = "0x600039F")]
			[Cpp2IlInjected.Address(RVA = "0xAC0F80", Offset = "0xABFD80", VA = "0x180AC0F80")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60003A0")]
			[Cpp2IlInjected.Address(RVA = "0xAC8C50", Offset = "0xAC7A50", VA = "0x180AC8C50")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000199")]
		public ModifyTagsRequest TagsRequest
		{
			[Cpp2IlInjected.Token(Token = "0x60003A1")]
			[Cpp2IlInjected.Address(RVA = "0xAC0FC0", Offset = "0xABFDC0", VA = "0x180AC0FC0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60003A2")]
			[Cpp2IlInjected.Address(RVA = "0xAC0CF0", Offset = "0xABFAF0", VA = "0x180AC0CF0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60003A3")]
		[Cpp2IlInjected.Address(RVA = "0x1091BE0", Offset = "0x10909E0", VA = "0x181091BE0", Slot = "4")]
		public void DNRPRHFLPRB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003A4")]
		[Cpp2IlInjected.Address(RVA = "0xAC4840", Offset = "0xAC3640", VA = "0x180AC4840")]
		public UpdateInventionMetadataRequest()
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x200008A")]
	[Utf8JsonSerializable]
	public class UpdateInventionGeneralPermissionRequest : IRecNetUtf8JsonObject
	{
		[Cpp2IlInjected.Token(Token = "0x1700019A")]
		public long InventionId
		{
			[Cpp2IlInjected.Token(Token = "0x60003A5")]
			[Cpp2IlInjected.Address(RVA = "0xABD130", Offset = "0xABBF30", VA = "0x180ABD130")]
			[CompilerGenerated]
			get
			{
				return default(long);
			}
			[Cpp2IlInjected.Token(Token = "0x60003A6")]
			[Cpp2IlInjected.Address(RVA = "0xEABA00", Offset = "0xEAA800", VA = "0x180EABA00")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700019B")]
		public InventionPermission Permission
		{
			[Cpp2IlInjected.Token(Token = "0x60003A7")]
			[Cpp2IlInjected.Address(RVA = "0xAC7B20", Offset = "0xAC6920", VA = "0x180AC7B20")]
			[CompilerGenerated]
			get
			{
				return default(InventionPermission);
			}
			[Cpp2IlInjected.Token(Token = "0x60003A8")]
			[Cpp2IlInjected.Address(RVA = "0xACAE40", Offset = "0xAC9C40", VA = "0x180ACAE40")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60003A9")]
		[Cpp2IlInjected.Address(RVA = "0xABE8D0", Offset = "0xABD6D0", VA = "0x180ABE8D0", Slot = "4")]
		public void DNRPRHFLPRB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003AA")]
		[Cpp2IlInjected.Address(RVA = "0xAC4840", Offset = "0xAC3640", VA = "0x180AC4840")]
		public UpdateInventionGeneralPermissionRequest()
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x200008B")]
	[Utf8JsonSerializable]
	public class PublishInventionRequest : IRecNetUtf8JsonObject
	{
		[Cpp2IlInjected.Token(Token = "0x1700019C")]
		public long InventionId
		{
			[Cpp2IlInjected.Token(Token = "0x60003AB")]
			[Cpp2IlInjected.Address(RVA = "0xABD130", Offset = "0xABBF30", VA = "0x180ABD130")]
			[CompilerGenerated]
			get
			{
				return default(long);
			}
			[Cpp2IlInjected.Token(Token = "0x60003AC")]
			[Cpp2IlInjected.Address(RVA = "0xEABA00", Offset = "0xEAA800", VA = "0x180EABA00")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700019D")]
		public InventionPermission Permission
		{
			[Cpp2IlInjected.Token(Token = "0x60003AD")]
			[Cpp2IlInjected.Address(RVA = "0xAC7B20", Offset = "0xAC6920", VA = "0x180AC7B20")]
			[CompilerGenerated]
			get
			{
				return default(InventionPermission);
			}
			[Cpp2IlInjected.Token(Token = "0x60003AE")]
			[Cpp2IlInjected.Address(RVA = "0xACAE40", Offset = "0xAC9C40", VA = "0x180ACAE40")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700019E")]
		public UgcAccessibility Accessibility
		{
			[Cpp2IlInjected.Token(Token = "0x60003AF")]
			[Cpp2IlInjected.Address(RVA = "0x15FD4F0", Offset = "0x15FC2F0", VA = "0x1815FD4F0")]
			[CompilerGenerated]
			get
			{
				return default(UgcAccessibility);
			}
			[Cpp2IlInjected.Token(Token = "0x60003B0")]
			[Cpp2IlInjected.Address(RVA = "0x15FD4E0", Offset = "0x15FC2E0", VA = "0x1815FD4E0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700019F")]
		public int? Price
		{
			[Cpp2IlInjected.Token(Token = "0x60003B1")]
			[Cpp2IlInjected.Address(RVA = "0xAC1D20", Offset = "0xAC0B20", VA = "0x180AC1D20")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60003B2")]
			[Cpp2IlInjected.Address(RVA = "0xE33D40", Offset = "0xE32B40", VA = "0x180E33D40")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60003B3")]
		[Cpp2IlInjected.Address(RVA = "0xABE8D0", Offset = "0xABD6D0", VA = "0x180ABE8D0", Slot = "4")]
		public void DNRPRHFLPRB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003B4")]
		[Cpp2IlInjected.Address(RVA = "0xAC4840", Offset = "0xAC3640", VA = "0x180AC4840")]
		public PublishInventionRequest()
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x200008C")]
	[Utf8JsonSerializable]
	public class UnpublishInventionRequest : IRecNetUtf8JsonObject
	{
		[Cpp2IlInjected.Token(Token = "0x170001A0")]
		public long InventionId
		{
			[Cpp2IlInjected.Token(Token = "0x60003B5")]
			[Cpp2IlInjected.Address(RVA = "0xABD130", Offset = "0xABBF30", VA = "0x180ABD130")]
			[CompilerGenerated]
			get
			{
				return default(long);
			}
			[Cpp2IlInjected.Token(Token = "0x60003B6")]
			[Cpp2IlInjected.Address(RVA = "0xEABA00", Offset = "0xEAA800", VA = "0x180EABA00")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60003B7")]
		[Cpp2IlInjected.Address(RVA = "0xABE8D0", Offset = "0xABD6D0", VA = "0x180ABE8D0", Slot = "4")]
		public void DNRPRHFLPRB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003B8")]
		[Cpp2IlInjected.Address(RVA = "0xAC4840", Offset = "0xAC3640", VA = "0x180AC4840")]
		public UnpublishInventionRequest()
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x200008D")]
	[Utf8JsonSerializable]
	public class DeleteInventionRequest : IRecNetUtf8JsonObject
	{
		[Cpp2IlInjected.Token(Token = "0x170001A1")]
		public long InventionId
		{
			[Cpp2IlInjected.Token(Token = "0x60003B9")]
			[Cpp2IlInjected.Address(RVA = "0xABD130", Offset = "0xABBF30", VA = "0x180ABD130")]
			[CompilerGenerated]
			get
			{
				return default(long);
			}
			[Cpp2IlInjected.Token(Token = "0x60003BA")]
			[Cpp2IlInjected.Address(RVA = "0xEABA00", Offset = "0xEAA800", VA = "0x180EABA00")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60003BB")]
		[Cpp2IlInjected.Address(RVA = "0xABE8D0", Offset = "0xABD6D0", VA = "0x180ABE8D0", Slot = "4")]
		public void DNRPRHFLPRB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003BC")]
		[Cpp2IlInjected.Address(RVA = "0xAC4840", Offset = "0xAC3640", VA = "0x180AC4840")]
		public DeleteInventionRequest()
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x200008E")]
	[Utf8JsonSerializable]
	public class SetInventionVersionAccessibilityRequest : IRecNetUtf8JsonObject
	{
		[Cpp2IlInjected.Token(Token = "0x170001A2")]
		public long InventionId
		{
			[Cpp2IlInjected.Token(Token = "0x60003BD")]
			[Cpp2IlInjected.Address(RVA = "0xABD130", Offset = "0xABBF30", VA = "0x180ABD130")]
			[CompilerGenerated]
			get
			{
				return default(long);
			}
			[Cpp2IlInjected.Token(Token = "0x60003BE")]
			[Cpp2IlInjected.Address(RVA = "0xEABA00", Offset = "0xEAA800", VA = "0x180EABA00")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001A3")]
		public int VersionNumber
		{
			[Cpp2IlInjected.Token(Token = "0x60003BF")]
			[Cpp2IlInjected.Address(RVA = "0xAC7B20", Offset = "0xAC6920", VA = "0x180AC7B20")]
			[CompilerGenerated]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x60003C0")]
			[Cpp2IlInjected.Address(RVA = "0xACAE40", Offset = "0xAC9C40", VA = "0x180ACAE40")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001A4")]
		public UgcAccessibility NewAccessibility
		{
			[Cpp2IlInjected.Token(Token = "0x60003C1")]
			[Cpp2IlInjected.Address(RVA = "0x15FD4F0", Offset = "0x15FC2F0", VA = "0x1815FD4F0")]
			[CompilerGenerated]
			get
			{
				return default(UgcAccessibility);
			}
			[Cpp2IlInjected.Token(Token = "0x60003C2")]
			[Cpp2IlInjected.Address(RVA = "0x15FD4E0", Offset = "0x15FC2E0", VA = "0x1815FD4E0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60003C3")]
		[Cpp2IlInjected.Address(RVA = "0xABE8D0", Offset = "0xABD6D0", VA = "0x180ABE8D0", Slot = "4")]
		public void DNRPRHFLPRB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003C4")]
		[Cpp2IlInjected.Address(RVA = "0xAC4840", Offset = "0xAC3640", VA = "0x180AC4840")]
		public SetInventionVersionAccessibilityRequest()
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x200008F")]
	[Utf8JsonSerializable]
	public class SpecialTags : IRecNetUtf8JsonObject
	{
		[Cpp2IlInjected.Token(Token = "0x170001A5")]
		public List<string> AutoTags
		{
			[Cpp2IlInjected.Token(Token = "0x60003C5")]
			[Cpp2IlInjected.Address(RVA = "0xABD130", Offset = "0xABBF30", VA = "0x180ABD130")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60003C6")]
			[Cpp2IlInjected.Address(RVA = "0xABD120", Offset = "0xABBF20", VA = "0x180ABD120")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001A6")]
		public List<string> AGOnlyTags
		{
			[Cpp2IlInjected.Token(Token = "0x60003C7")]
			[Cpp2IlInjected.Address(RVA = "0xAC0D20", Offset = "0xABFB20", VA = "0x180AC0D20")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60003C8")]
			[Cpp2IlInjected.Address(RVA = "0xAC0D10", Offset = "0xABFB10", VA = "0x180AC0D10")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60003C9")]
		[Cpp2IlInjected.Address(RVA = "0xABE8D0", Offset = "0xABD6D0", VA = "0x180ABE8D0", Slot = "4")]
		public void DNRPRHFLPRB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003CA")]
		[Cpp2IlInjected.Address(RVA = "0xAC4840", Offset = "0xAC3640", VA = "0x180AC4840")]
		public SpecialTags()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000090")]
	public enum InventionResult
	{
		[Cpp2IlInjected.Token(Token = "0x40001DC")]
		Success,
		[Cpp2IlInjected.Token(Token = "0x40001DD")]
		InvalidParameters,
		[Cpp2IlInjected.Token(Token = "0x40001DE")]
		PlayerCannotUpload,
		[Cpp2IlInjected.Token(Token = "0x40001DF")]
		DuplicateName,
		[Cpp2IlInjected.Token(Token = "0x40001E0")]
		NameTooShort,
		[Cpp2IlInjected.Token(Token = "0x40001E1")]
		NameTooLong,
		[Cpp2IlInjected.Token(Token = "0x40001E2")]
		NotCreator,
		[Cpp2IlInjected.Token(Token = "0x40001E3")]
		DoesNotExist,
		[Cpp2IlInjected.Token(Token = "0x40001E4")]
		ImageDoesNotExist,
		[Cpp2IlInjected.Token(Token = "0x40001E5")]
		InventionLimitReached,
		[Cpp2IlInjected.Token(Token = "0x40001E6")]
		DescriptionTooLong,
		[Cpp2IlInjected.Token(Token = "0x40001E7")]
		InnapropriateName,
		[Cpp2IlInjected.Token(Token = "0x40001E8")]
		InappropriateDescription,
		[Cpp2IlInjected.Token(Token = "0x40001E9")]
		CannotBeModified,
		[Cpp2IlInjected.Token(Token = "0x40001EA")]
		PlayerCannotPublish,
		[Cpp2IlInjected.Token(Token = "0x40001EB")]
		AlreadyPublished,
		[Cpp2IlInjected.Token(Token = "0x40001EC")]
		AlreadyUnpublished,
		[Cpp2IlInjected.Token(Token = "0x40001ED")]
		InventionUnderModerationReview,
		[Cpp2IlInjected.Token(Token = "0x40001EE")]
		PlayerCannotDownload,
		[Cpp2IlInjected.Token(Token = "0x40001EF")]
		PlayerAlreadyOwns,
		[Cpp2IlInjected.Token(Token = "0x40001F0")]
		DescriptionTooShort,
		[Cpp2IlInjected.Token(Token = "0x40001F1")]
		DoesNotHavePermission,
		[Cpp2IlInjected.Token(Token = "0x40001F2")]
		PermissionLevelCannotBeChanged,
		[Cpp2IlInjected.Token(Token = "0x40001F3")]
		AlreadyCheered,
		[Cpp2IlInjected.Token(Token = "0x40001F4")]
		AlreadyRemovedCheer,
		[Cpp2IlInjected.Token(Token = "0x40001F5")]
		ModeratorRestrictedPublishing,
		[Cpp2IlInjected.Token(Token = "0x40001F6")]
		PlayerCannotSell,
		[Cpp2IlInjected.Token(Token = "0x40001F7")]
		InvalidPrice,
		[Cpp2IlInjected.Token(Token = "0x40001F8")]
		PriceCannotBeChanged,
		[Cpp2IlInjected.Token(Token = "0x40001F9")]
		InvalidPermissionForPaidInvention,
		[Cpp2IlInjected.Token(Token = "0x40001FA")]
		PurchaseFailed,
		[Cpp2IlInjected.Token(Token = "0x40001FB")]
		CannotDownloadPaidInvention,
		[Cpp2IlInjected.Token(Token = "0x40001FC")]
		CannotSellUnownedLineage,
		[Cpp2IlInjected.Token(Token = "0x40001FD")]
		DoesNotAllowTrial,
		[Cpp2IlInjected.Token(Token = "0x40001FE")]
		StillOnTrialCooldown,
		[Cpp2IlInjected.Token(Token = "0x40001FF")]
		PlayerCannotTrial,
		[Cpp2IlInjected.Token(Token = "0x4000200")]
		PaidInventionPublishingDisabled,
		[Cpp2IlInjected.Token(Token = "0x4000201")]
		PaidInventionPurchasingDisabled,
		[Cpp2IlInjected.Token(Token = "0x4000202")]
		OperationIsDisabled,
		[Cpp2IlInjected.Token(Token = "0x4000203")]
		PlayerRestrictedFromP2PSelling,
		[Cpp2IlInjected.Token(Token = "0x4000204")]
		PlayerNotRecRoomPlusMember,
		[Cpp2IlInjected.Token(Token = "0x4000205")]
		InvalidInstantiationCost,
		[Cpp2IlInjected.Token(Token = "0x4000206")]
		FeaturedInventionNotPublished,
		[Cpp2IlInjected.Token(Token = "0x4000207")]
		FeaturedInventionNotActive,
		[Cpp2IlInjected.Token(Token = "0x4000208")]
		InventionContainsBlockedFiles,
		[Cpp2IlInjected.Token(Token = "0x4000209")]
		PlayerRestrictedFromP2PBuying,
		[Cpp2IlInjected.Token(Token = "0x400020A")]
		ReservedWordRuleViolationInName,
		[Cpp2IlInjected.Token(Token = "0x400020B")]
		ReservedWordRuleViolationInDescription,
		[Cpp2IlInjected.Token(Token = "0x400020C")]
		InventionContainsBetaContent,
		[Cpp2IlInjected.Token(Token = "0x400020D")]
		PlatformDoesntSupportPublishing,
		[Cpp2IlInjected.Token(Token = "0x400020E")]
		MismatchedUgcVersions,
		[Cpp2IlInjected.Token(Token = "0x400020F")]
		ConvertedFromSameUgcVersion,
		[Cpp2IlInjected.Token(Token = "0x4000210")]
		ConvertedFromInventionDoesNotExist,
		[Cpp2IlInjected.Token(Token = "0x4000211")]
		ConvertedFromInventionHigherVersion,
		[Cpp2IlInjected.Token(Token = "0x4000212")]
		PlatformDoesntSupportInvention
	}
	[Cpp2IlInjected.Token(Token = "0x2000091")]
	public enum InventionReportCategory
	{
		[Cpp2IlInjected.Token(Token = "0x4000214")]
		Unknown = -1,
		[Cpp2IlInjected.Token(Token = "0x4000215")]
		CoC_Discriminatory,
		[Cpp2IlInjected.Token(Token = "0x4000216")]
		CoC_Sexual,
		[Cpp2IlInjected.Token(Token = "0x4000217")]
		CoC_Trolling,
		[Cpp2IlInjected.Token(Token = "0x4000218")]
		Misleading,
		[Cpp2IlInjected.Token(Token = "0x4000219")]
		Other
	}
	[Cpp2IlInjected.Token(Token = "0x2000092")]
	public enum RoomPermissionValue
	{
		[Cpp2IlInjected.Token(Token = "0x400021B")]
		False,
		[Cpp2IlInjected.Token(Token = "0x400021C")]
		True,
		[Cpp2IlInjected.Token(Token = "0x400021D")]
		Invited
	}
	[Cpp2IlInjected.Token(Token = "0x2000093")]
	public interface UUEPUWLRWCF
	{
		[Cpp2IlInjected.Token(Token = "0x170001A7")]
		PlatformType Platform
		{
			[Cpp2IlInjected.Token(Token = "0x60003CB")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x170001A8")]
		string PlatformId
		{
			[Cpp2IlInjected.Token(Token = "0x60003CC")]
			[Cpp2IlInjected.Address(Slot = "1")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x170001A9")]
		int AccountId
		{
			[Cpp2IlInjected.Token(Token = "0x60003CD")]
			[Cpp2IlInjected.Address(Slot = "2")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x170001AA")]
		DateTime LastLoginTime
		{
			[Cpp2IlInjected.Token(Token = "0x60003CE")]
			[Cpp2IlInjected.Address(Slot = "3")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x170001AB")]
		bool RequirePassword
		{
			[Cpp2IlInjected.Token(Token = "0x60003CF")]
			[Cpp2IlInjected.Address(Slot = "4")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x170001AC")]
		string RefreshToken
		{
			[Cpp2IlInjected.Token(Token = "0x60003D0")]
			[Cpp2IlInjected.Address(Slot = "5")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x170001AD")]
		XTOYSWYWUAV Account
		{
			[Cpp2IlInjected.Token(Token = "0x60003D1")]
			[Cpp2IlInjected.Address(Slot = "6")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x60003D2")]
		[Cpp2IlInjected.Address(Slot = "7")]
		void DNRPRHFLPRB();

		[Cpp2IlInjected.Token(Token = "0x60003D3")]
		[Cpp2IlInjected.Address(Slot = "8")]
		void BNSEFLUOVTC(XTOYSWYWUAV a);
	}
	[Cpp2IlInjected.Token(Token = "0x2000094")]
	public interface XFTJQLDOGBC
	{
		[Cpp2IlInjected.Token(Token = "0x170001AE")]
		string Text
		{
			[Cpp2IlInjected.Token(Token = "0x60003D4")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x170001AF")]
		int Length
		{
			[Cpp2IlInjected.Token(Token = "0x60003D5")]
			[Cpp2IlInjected.Address(Slot = "1")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x170001B0")]
		bool AllowAlpha
		{
			[Cpp2IlInjected.Token(Token = "0x60003D6")]
			[Cpp2IlInjected.Address(Slot = "2")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x60003D7")]
		[Cpp2IlInjected.Address(Slot = "3")]
		void DNRPRHFLPRB();
	}
	[Cpp2IlInjected.Token(Token = "0x2000095")]
	public struct LoginResult
	{
		[Cpp2IlInjected.Token(Token = "0x170001B1")]
		public LoginStatus Status
		{
			[Cpp2IlInjected.Token(Token = "0x60003D9")]
			[Cpp2IlInjected.Address(RVA = "0xDB2230", Offset = "0xDB1030", VA = "0x180DB2230")]
			[CompilerGenerated]
			readonly get
			{
				return default(LoginStatus);
			}
			[Cpp2IlInjected.Token(Token = "0x60003DA")]
			[Cpp2IlInjected.Address(RVA = "0x15B1800", Offset = "0x15B0600", VA = "0x1815B1800")]
			[CompilerGenerated]
			internal set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001B2")]
		public XFTJQLDOGBC SecurityCodeHint
		{
			[Cpp2IlInjected.Token(Token = "0x60003DB")]
			[Cpp2IlInjected.Address(RVA = "0xB72150", Offset = "0xB70F50", VA = "0x180B72150")]
			[CompilerGenerated]
			readonly get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60003DC")]
			[Cpp2IlInjected.Address(RVA = "0xF4F940", Offset = "0xF4E740", VA = "0x180F4F940")]
			[CompilerGenerated]
			internal set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001B3")]
		public string LoginContext
		{
			[Cpp2IlInjected.Token(Token = "0x60003DD")]
			[Cpp2IlInjected.Address(RVA = "0xABD130", Offset = "0xABBF30", VA = "0x180ABD130")]
			[CompilerGenerated]
			readonly get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60003DE")]
			[Cpp2IlInjected.Address(RVA = "0xABD120", Offset = "0xABBF20", VA = "0x180ABD120")]
			[CompilerGenerated]
			internal set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60003D8")]
		[Cpp2IlInjected.Address(RVA = "0x6763490", Offset = "0x6762290", VA = "0x186763490")]
		public LoginResult(LoginStatus status, [Optional] XFTJQLDOGBC securityCodeHint, [Optional] string loginContext)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000096")]
	public enum LoginStatus
	{
		[Cpp2IlInjected.Token(Token = "0x4000222")]
		Unknown,
		[Cpp2IlInjected.Token(Token = "0x4000223")]
		Success,
		[Cpp2IlInjected.Token(Token = "0x4000224")]
		ContinueSecurityCode,
		[Cpp2IlInjected.Token(Token = "0x4000225")]
		TryAgainSecurityCode,
		[Cpp2IlInjected.Token(Token = "0x4000226")]
		RemoteAuthPending
	}
	[Cpp2IlInjected.Token(Token = "0x2000097")]
	[Utf8JsonSerializable]
	public class StatsigMemoryOverrideParameterDTO : IRecNetUtf8JsonObject
	{
		[Cpp2IlInjected.Token(Token = "0x170001B4")]
		public string LayerName
		{
			[Cpp2IlInjected.Token(Token = "0x60003E1")]
			[Cpp2IlInjected.Address(RVA = "0xABD130", Offset = "0xABBF30", VA = "0x180ABD130")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60003E2")]
			[Cpp2IlInjected.Address(RVA = "0xABD120", Offset = "0xABBF20", VA = "0x180ABD120")]
			[CompilerGenerated]
			internal set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001B5")]
		public string ExperimentName
		{
			[Cpp2IlInjected.Token(Token = "0x60003E3")]
			[Cpp2IlInjected.Address(RVA = "0xAC0D20", Offset = "0xABFB20", VA = "0x180AC0D20")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60003E4")]
			[Cpp2IlInjected.Address(RVA = "0xAC0D10", Offset = "0xABFB10", VA = "0x180AC0D10")]
			[CompilerGenerated]
			internal set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001B6")]
		public string ParameterName
		{
			[Cpp2IlInjected.Token(Token = "0x60003E5")]
			[Cpp2IlInjected.Address(RVA = "0xAC1D20", Offset = "0xAC0B20", VA = "0x180AC1D20")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60003E6")]
			[Cpp2IlInjected.Address(RVA = "0xAC0640", Offset = "0xABF440", VA = "0x180AC0640")]
			[CompilerGenerated]
			internal set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001B7")]
		public string ParameterValue
		{
			[Cpp2IlInjected.Token(Token = "0x60003E7")]
			[Cpp2IlInjected.Address(RVA = "0xAC0F90", Offset = "0xABFD90", VA = "0x180AC0F90")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60003E8")]
			[Cpp2IlInjected.Address(RVA = "0xAC0650", Offset = "0xABF450", VA = "0x180AC0650")]
			[CompilerGenerated]
			internal set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001B8")]
		public List<StatsigMemoryOverrideParameterBranchValueDTO> BranchValueOverrides
		{
			[Cpp2IlInjected.Token(Token = "0x60003E9")]
			[Cpp2IlInjected.Address(RVA = "0xAC0F80", Offset = "0xABFD80", VA = "0x180AC0F80")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60003EA")]
			[Cpp2IlInjected.Address(RVA = "0xAC8C50", Offset = "0xAC7A50", VA = "0x180AC8C50")]
			[CompilerGenerated]
			internal set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60003DF")]
		[Cpp2IlInjected.Address(RVA = "0xAC4840", Offset = "0xAC3640", VA = "0x180AC4840")]
		public StatsigMemoryOverrideParameterDTO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003E0")]
		[Cpp2IlInjected.Address(RVA = "0x77738C0", Offset = "0x77726C0", VA = "0x1877738C0")]
		public StatsigMemoryOverrideParameterDTO([Optional] string layerName, [Optional] string experimentName, [Optional] string parameterName, [Optional] string parameterValue, [Optional] List<StatsigMemoryOverrideParameterBranchValueDTO> branchValueOverrides)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003EB")]
		[Cpp2IlInjected.Address(RVA = "0xABE8D0", Offset = "0xABD6D0", VA = "0x180ABE8D0", Slot = "4")]
		public void DNRPRHFLPRB()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000098")]
	[Utf8JsonSerializable]
	public class StatsigMemoryOverrideParameterBranchValueDTO : IRecNetUtf8JsonObject
	{
		[Cpp2IlInjected.Token(Token = "0x170001B9")]
		public string BranchName
		{
			[Cpp2IlInjected.Token(Token = "0x60003EC")]
			[Cpp2IlInjected.Address(RVA = "0xABD130", Offset = "0xABBF30", VA = "0x180ABD130")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60003ED")]
			[Cpp2IlInjected.Address(RVA = "0xABD120", Offset = "0xABBF20", VA = "0x180ABD120")]
			[CompilerGenerated]
			internal set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001BA")]
		public string ParameterValue
		{
			[Cpp2IlInjected.Token(Token = "0x60003EE")]
			[Cpp2IlInjected.Address(RVA = "0xAC0D20", Offset = "0xABFB20", VA = "0x180AC0D20")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60003EF")]
			[Cpp2IlInjected.Address(RVA = "0xAC0D10", Offset = "0xABFB10", VA = "0x180AC0D10")]
			[CompilerGenerated]
			internal set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60003F0")]
		[Cpp2IlInjected.Address(RVA = "0xABE8D0", Offset = "0xABD6D0", VA = "0x180ABE8D0", Slot = "4")]
		public void DNRPRHFLPRB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003F1")]
		[Cpp2IlInjected.Address(RVA = "0xAC4840", Offset = "0xAC3640", VA = "0x180AC4840")]
		public StatsigMemoryOverrideParameterBranchValueDTO()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000099")]
	[Utf8JsonSerializable]
	public class StatsigExperimentConfigDTO : IRecNetUtf8JsonObject
	{
		[Cpp2IlInjected.Token(Token = "0x170001BB")]
		public string ExperimentName
		{
			[Cpp2IlInjected.Token(Token = "0x60003F2")]
			[Cpp2IlInjected.Address(RVA = "0xABD130", Offset = "0xABBF30", VA = "0x180ABD130")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60003F3")]
			[Cpp2IlInjected.Address(RVA = "0xABD120", Offset = "0xABBF20", VA = "0x180ABD120")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001BC")]
		public string Status
		{
			[Cpp2IlInjected.Token(Token = "0x60003F4")]
			[Cpp2IlInjected.Address(RVA = "0xAC0D20", Offset = "0xABFB20", VA = "0x180AC0D20")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60003F5")]
			[Cpp2IlInjected.Address(RVA = "0xAC0D10", Offset = "0xABFB10", VA = "0x180AC0D10")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001BD")]
		public string LayerName
		{
			[Cpp2IlInjected.Token(Token = "0x60003F6")]
			[Cpp2IlInjected.Address(RVA = "0xAC1D20", Offset = "0xAC0B20", VA = "0x180AC1D20")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60003F7")]
			[Cpp2IlInjected.Address(RVA = "0xAC0640", Offset = "0xABF440", VA = "0x180AC0640")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001BE")]
		public List<string> ParameterNames
		{
			[Cpp2IlInjected.Token(Token = "0x60003F8")]
			[Cpp2IlInjected.Address(RVA = "0xAC0F90", Offset = "0xABFD90", VA = "0x180AC0F90")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60003F9")]
			[Cpp2IlInjected.Address(RVA = "0xAC0650", Offset = "0xABF450", VA = "0x180AC0650")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60003FA")]
		[Cpp2IlInjected.Address(RVA = "0xABE8D0", Offset = "0xABD6D0", VA = "0x180ABE8D0", Slot = "4")]
		public void DNRPRHFLPRB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003FB")]
		[Cpp2IlInjected.Address(RVA = "0xAC4840", Offset = "0xAC3640", VA = "0x180AC4840")]
		public StatsigExperimentConfigDTO()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200009A")]
	[Utf8JsonSerializable]
	public interface IRecNetUtf8JsonObject
	{
		[Cpp2IlInjected.Token(Token = "0x60003FC")]
		[Cpp2IlInjected.Address(Slot = "0")]
		void DNRPRHFLPRB();
	}
	[Cpp2IlInjected.Token(Token = "0x200009B")]
	[Utf8JsonSerializable]
	public interface IRecNetUtf8JsonObjectPerformsPostProcessing : IRecNetUtf8JsonObject
	{
		[Cpp2IlInjected.Token(Token = "0x60003FD")]
		[Cpp2IlInjected.Address(Slot = "0")]
		Task WSLKELMBPUB();
	}
	[Cpp2IlInjected.Token(Token = "0x200009C")]
	[Utf8JsonSerializableIgnore]
	public interface DGCGJUHCULN : IRecNetUtf8JsonObject
	{
	}
	[Cpp2IlInjected.Token(Token = "0x200009D")]
	[Utf8JsonSerializable]
	public class OutfitSelectionDTO : IRecNetUtf8JsonObject
	{
		[Cpp2IlInjected.Token(Token = "0x170001BF")]
		public Guid CustomAvatarItemId
		{
			[Cpp2IlInjected.Token(Token = "0x6000400")]
			[Cpp2IlInjected.Address(RVA = "0xEC6860", Offset = "0xEC5660", VA = "0x180EC6860")]
			[CompilerGenerated]
			get
			{
				return default(Guid);
			}
			[Cpp2IlInjected.Token(Token = "0x6000401")]
			[Cpp2IlInjected.Address(RVA = "0xEC6880", Offset = "0xEC5680", VA = "0x180EC6880")]
			[CompilerGenerated]
			internal set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001C0")]
		public int BodyPart
		{
			[Cpp2IlInjected.Token(Token = "0x6000402")]
			[Cpp2IlInjected.Address(RVA = "0xACF4D0", Offset = "0xACE2D0", VA = "0x180ACF4D0")]
			[CompilerGenerated]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x6000403")]
			[Cpp2IlInjected.Address(RVA = "0xB20FD0", Offset = "0xB1FDD0", VA = "0x180B20FD0")]
			[CompilerGenerated]
			internal set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001C1")]
		public string BakedUnityAssetFileName
		{
			[Cpp2IlInjected.Token(Token = "0x6000404")]
			[Cpp2IlInjected.Address(RVA = "0xAC0F90", Offset = "0xABFD90", VA = "0x180AC0F90")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000405")]
			[Cpp2IlInjected.Address(RVA = "0xAC0650", Offset = "0xABF450", VA = "0x180AC0650")]
			[CompilerGenerated]
			internal set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001C2")]
		public string AdditionalConfiguration
		{
			[Cpp2IlInjected.Token(Token = "0x6000406")]
			[Cpp2IlInjected.Address(RVA = "0xAC0F80", Offset = "0xABFD80", VA = "0x180AC0F80")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000407")]
			[Cpp2IlInjected.Address(RVA = "0xAC8C50", Offset = "0xAC7A50", VA = "0x180AC8C50")]
			[CompilerGenerated]
			internal set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60003FE")]
		[Cpp2IlInjected.Address(RVA = "0xAC4840", Offset = "0xAC3640", VA = "0x180AC4840")]
		public OutfitSelectionDTO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003FF")]
		[Cpp2IlInjected.Address(RVA = "0x7A5F270", Offset = "0x7A5E070", VA = "0x187A5F270")]
		public OutfitSelectionDTO([Optional] Guid customAvatarItemId, int bodyPart = 0, [Optional] string bakedUnityAssetFileName, [Optional] string additionalConfiguration)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000408")]
		[Cpp2IlInjected.Address(RVA = "0xABE8D0", Offset = "0xABD6D0", VA = "0x180ABE8D0", Slot = "4")]
		public void DNRPRHFLPRB()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200009E")]
	[Utf8JsonSerializable]
	public class OutfitDTO : IRecNetUtf8JsonObject
	{
		[Cpp2IlInjected.Token(Token = "0x4000236")]
		public const int CurrentOutfitSlot = 0;

		[Cpp2IlInjected.Token(Token = "0x170001C3")]
		public long DataVersion
		{
			[Cpp2IlInjected.Token(Token = "0x600040B")]
			[Cpp2IlInjected.Address(RVA = "0xABD130", Offset = "0xABBF30", VA = "0x180ABD130")]
			[CompilerGenerated]
			get
			{
				return default(long);
			}
			[Cpp2IlInjected.Token(Token = "0x600040C")]
			[Cpp2IlInjected.Address(RVA = "0xEABA00", Offset = "0xEAA800", VA = "0x180EABA00")]
			[CompilerGenerated]
			internal set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001C4")]
		public LegacyOutfitDataDTO LegacyData
		{
			[Cpp2IlInjected.Token(Token = "0x600040D")]
			[Cpp2IlInjected.Address(RVA = "0xAC0D20", Offset = "0xABFB20", VA = "0x180AC0D20")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600040E")]
			[Cpp2IlInjected.Address(RVA = "0xAC0D10", Offset = "0xABFB10", VA = "0x180AC0D10")]
			[CompilerGenerated]
			internal set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001C5")]
		public string CustomizationSettings
		{
			[Cpp2IlInjected.Token(Token = "0x600040F")]
			[Cpp2IlInjected.Address(RVA = "0xAC1D20", Offset = "0xAC0B20", VA = "0x180AC1D20")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000410")]
			[Cpp2IlInjected.Address(RVA = "0xAC0640", Offset = "0xABF440", VA = "0x180AC0640")]
			[CompilerGenerated]
			internal set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001C6")]
		public List<OutfitSelectionDTO> Selections
		{
			[Cpp2IlInjected.Token(Token = "0x6000411")]
			[Cpp2IlInjected.Address(RVA = "0xAC0F90", Offset = "0xABFD90", VA = "0x180AC0F90")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000412")]
			[Cpp2IlInjected.Address(RVA = "0xAC0650", Offset = "0xABF450", VA = "0x180AC0650")]
			[CompilerGenerated]
			internal set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001C7")]
		public int Slot
		{
			[Cpp2IlInjected.Token(Token = "0x6000413")]
			[Cpp2IlInjected.Address(RVA = "0xAC6560", Offset = "0xAC5360", VA = "0x180AC6560")]
			[CompilerGenerated]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x6000414")]
			[Cpp2IlInjected.Address(RVA = "0xAC6870", Offset = "0xAC5670", VA = "0x180AC6870")]
			[CompilerGenerated]
			internal set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001C8")]
		public string Name
		{
			[Cpp2IlInjected.Token(Token = "0x6000415")]
			[Cpp2IlInjected.Address(RVA = "0xAC0FC0", Offset = "0xABFDC0", VA = "0x180AC0FC0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000416")]
			[Cpp2IlInjected.Address(RVA = "0xAC0CF0", Offset = "0xABFAF0", VA = "0x180AC0CF0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001C9")]
		public UgcAccessibility Accessibility
		{
			[Cpp2IlInjected.Token(Token = "0x6000417")]
			[Cpp2IlInjected.Address(RVA = "0xADBF60", Offset = "0xADAD60", VA = "0x180ADBF60")]
			[CompilerGenerated]
			get
			{
				return default(UgcAccessibility);
			}
			[Cpp2IlInjected.Token(Token = "0x6000418")]
			[Cpp2IlInjected.Address(RVA = "0xB3EC20", Offset = "0xB3DA20", VA = "0x180B3EC20")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001CA")]
		public string ThumbnailFileName
		{
			[Cpp2IlInjected.Token(Token = "0x6000419")]
			[Cpp2IlInjected.Address(RVA = "0xAC0D30", Offset = "0xABFB30", VA = "0x180AC0D30")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600041A")]
			[Cpp2IlInjected.Address(RVA = "0xAC1370", Offset = "0xAC0170", VA = "0x180AC1370")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001CB")]
		public bool IsCurrentlyEquipped
		{
			[Cpp2IlInjected.Token(Token = "0x600041B")]
			[Cpp2IlInjected.Address(RVA = "0x2165840", Offset = "0x2164640", VA = "0x182165840")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000409")]
		[Cpp2IlInjected.Address(RVA = "0x7A5F170", Offset = "0x7A5DF70", VA = "0x187A5F170")]
		public OutfitDTO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600040A")]
		[Cpp2IlInjected.Address(RVA = "0x7A5F050", Offset = "0x7A5DE50", VA = "0x187A5F050")]
		public OutfitDTO(long dataVersion = 0L, [Optional] LegacyOutfitDataDTO legacyData, [Optional] string customizationSettings, [Optional] List<OutfitSelectionDTO> selections, int slot = 0, [Optional] string name, UgcAccessibility accessibility = UgcAccessibility.Private, [Optional] string thumbnailFileName)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600041C")]
		[Cpp2IlInjected.Address(RVA = "0xABE8D0", Offset = "0xABD6D0", VA = "0x180ABE8D0", Slot = "4")]
		public void DNRPRHFLPRB()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200009F")]
	public class GELYNSCEPVX
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400023F")]
		public readonly int TRPCFZNMMNN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000240")]
		public readonly OutfitDTO YJHISTBPCHS;

		[Cpp2IlInjected.Token(Token = "0x600041D")]
		[Cpp2IlInjected.Address(RVA = "0x1088910", Offset = "0x1087710", VA = "0x181088910")]
		public GELYNSCEPVX(int a, OutfitDTO b)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000A0")]
	[Utf8JsonSerializable]
	public class LegacyOutfitDataDTO : IRecNetUtf8JsonObject
	{
		[Cpp2IlInjected.Token(Token = "0x170001CC")]
		public string SelectionsV1
		{
			[Cpp2IlInjected.Token(Token = "0x6000420")]
			[Cpp2IlInjected.Address(RVA = "0xABD130", Offset = "0xABBF30", VA = "0x180ABD130")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000421")]
			[Cpp2IlInjected.Address(RVA = "0xABD120", Offset = "0xABBF20", VA = "0x180ABD120")]
			[CompilerGenerated]
			internal set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001CD")]
		public string SelectionsV2
		{
			[Cpp2IlInjected.Token(Token = "0x6000422")]
			[Cpp2IlInjected.Address(RVA = "0xAC0D20", Offset = "0xABFB20", VA = "0x180AC0D20")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000423")]
			[Cpp2IlInjected.Address(RVA = "0xAC0D10", Offset = "0xABFB10", VA = "0x180AC0D10")]
			[CompilerGenerated]
			internal set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001CE")]
		public string FaceFeatures
		{
			[Cpp2IlInjected.Token(Token = "0x6000424")]
			[Cpp2IlInjected.Address(RVA = "0xAC1D20", Offset = "0xAC0B20", VA = "0x180AC1D20")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000425")]
			[Cpp2IlInjected.Address(RVA = "0xAC0640", Offset = "0xABF440", VA = "0x180AC0640")]
			[CompilerGenerated]
			internal set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001CF")]
		public string SkinColor
		{
			[Cpp2IlInjected.Token(Token = "0x6000426")]
			[Cpp2IlInjected.Address(RVA = "0xAC0F90", Offset = "0xABFD90", VA = "0x180AC0F90")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000427")]
			[Cpp2IlInjected.Address(RVA = "0xAC0650", Offset = "0xABF450", VA = "0x180AC0650")]
			[CompilerGenerated]
			internal set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001D0")]
		public string HairColor
		{
			[Cpp2IlInjected.Token(Token = "0x6000428")]
			[Cpp2IlInjected.Address(RVA = "0xAC0F80", Offset = "0xABFD80", VA = "0x180AC0F80")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000429")]
			[Cpp2IlInjected.Address(RVA = "0xAC8C50", Offset = "0xAC7A50", VA = "0x180AC8C50")]
			[CompilerGenerated]
			internal set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001D1")]
		public string Selections
		{
			[Cpp2IlInjected.Token(Token = "0x600042A")]
			[Cpp2IlInjected.Address(RVA = "0x7A5E540", Offset = "0x7A5D340", VA = "0x187A5E540")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600041E")]
		[Cpp2IlInjected.Address(RVA = "0xAC4840", Offset = "0xAC3640", VA = "0x180AC4840")]
		public LegacyOutfitDataDTO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600041F")]
		[Cpp2IlInjected.Address(RVA = "0x77738C0", Offset = "0x77726C0", VA = "0x1877738C0")]
		public LegacyOutfitDataDTO([Optional] string selectionsV1, [Optional] string selectionsV2, [Optional] string faceFeatures, [Optional] string skinColor, [Optional] string hairColor)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600042B")]
		[Cpp2IlInjected.Address(RVA = "0xABE8D0", Offset = "0xABD6D0", VA = "0x180ABE8D0", Slot = "4")]
		public void DNRPRHFLPRB()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000A1")]
	[Utf8JsonSerializable]
	public class GetPlayersOutfitsResponseDTO : IRecNetUtf8JsonObject
	{
		[Cpp2IlInjected.Token(Token = "0x170001D2")]
		public Dictionary<int, OutfitDTO> OutfitsByAccountId
		{
			[Cpp2IlInjected.Token(Token = "0x600042C")]
			[Cpp2IlInjected.Address(RVA = "0xABD130", Offset = "0xABBF30", VA = "0x180ABD130")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600042D")]
			[Cpp2IlInjected.Address(RVA = "0xABD120", Offset = "0xABBF20", VA = "0x180ABD120")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600042E")]
		[Cpp2IlInjected.Address(RVA = "0xABE8D0", Offset = "0xABD6D0", VA = "0x180ABE8D0", Slot = "4")]
		public void DNRPRHFLPRB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600042F")]
		[Cpp2IlInjected.Address(RVA = "0xAC4840", Offset = "0xAC3640", VA = "0x180AC4840")]
		public GetPlayersOutfitsResponseDTO()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000A2")]
	[Utf8JsonSerializable]
	public class GetPlayersOutfitsRequestDTO : IRecNetUtf8JsonObject
	{
		[Cpp2IlInjected.Token(Token = "0x170001D3")]
		public List<int> AccountIds
		{
			[Cpp2IlInjected.Token(Token = "0x6000430")]
			[Cpp2IlInjected.Address(RVA = "0xABD130", Offset = "0xABBF30", VA = "0x180ABD130")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000431")]
			[Cpp2IlInjected.Address(RVA = "0xABD120", Offset = "0xABBF20", VA = "0x180ABD120")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001D4")]
		public byte? UnityAssetTarget
		{
			[Cpp2IlInjected.Token(Token = "0x6000432")]
			[Cpp2IlInjected.Address(RVA = "0x31F89B0", Offset = "0x31F77B0", VA = "0x1831F89B0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000433")]
			[Cpp2IlInjected.Address(RVA = "0x31F89A0", Offset = "0x31F77A0", VA = "0x1831F89A0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001D5")]
		public int? UnityAssetVersion
		{
			[Cpp2IlInjected.Token(Token = "0x6000434")]
			[Cpp2IlInjected.Address(RVA = "0x13E8E60", Offset = "0x13E7C60", VA = "0x1813E8E60")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000435")]
			[Cpp2IlInjected.Address(RVA = "0x13E8E90", Offset = "0x13E7C90", VA = "0x1813E8E90")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000436")]
		[Cpp2IlInjected.Address(RVA = "0xABE8D0", Offset = "0xABD6D0", VA = "0x180ABE8D0", Slot = "4")]
		public void DNRPRHFLPRB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000437")]
		[Cpp2IlInjected.Address(RVA = "0xAC4840", Offset = "0xAC3640", VA = "0x180AC4840")]
		public GetPlayersOutfitsRequestDTO()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000A3")]
	public static class CGGTLOATKIJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000438")]
		[Cpp2IlInjected.Address(RVA = "0x7A59FA0", Offset = "0x7A58DA0", VA = "0x187A59FA0")]
		public static CustomAvatarItemVisualData HCTPDWSMLKD(this OutfitSelectionDTO a)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000A4")]
	[Flags]
	public enum PlatformMask
	{
		[Cpp2IlInjected.Token(Token = "0x400024B")]
		None = 0,
		[Cpp2IlInjected.Token(Token = "0x400024C")]
		Steam = 1,
		[Cpp2IlInjected.Token(Token = "0x400024D")]
		Oculus = 2,
		[Cpp2IlInjected.Token(Token = "0x400024E")]
		PlayStation = 4,
		[Cpp2IlInjected.Token(Token = "0x400024F")]
		Xbox = 8,
		[Cpp2IlInjected.Token(Token = "0x4000250")]
		RecNet = 0x10,
		[Cpp2IlInjected.Token(Token = "0x4000251")]
		IOS = 0x20,
		[Cpp2IlInjected.Token(Token = "0x4000252")]
		GooglePlay = 0x40,
		[Cpp2IlInjected.Token(Token = "0x4000253")]
		Standalone = 0x80,
		[Cpp2IlInjected.Token(Token = "0x4000254")]
		Pico = 0x100,
		[Cpp2IlInjected.Token(Token = "0x4000255")]
		Switch = 0x200,
		[Cpp2IlInjected.Token(Token = "0x4000256")]
		All = -1
	}
	[Cpp2IlInjected.Token(Token = "0x20000A5")]
	public enum PlatformType
	{
		[Cpp2IlInjected.Token(Token = "0x4000258")]
		All = -1,
		[Cpp2IlInjected.Token(Token = "0x4000259")]
		Steam,
		[Cpp2IlInjected.Token(Token = "0x400025A")]
		Oculus,
		[Cpp2IlInjected.Token(Token = "0x400025B")]
		PlayStation,
		[Cpp2IlInjected.Token(Token = "0x400025C")]
		Xbox,
		[Cpp2IlInjected.Token(Token = "0x400025D")]
		RecNet,
		[Cpp2IlInjected.Token(Token = "0x400025E")]
		IOS,
		[Cpp2IlInjected.Token(Token = "0x400025F")]
		GooglePlay,
		[Cpp2IlInjected.Token(Token = "0x4000260")]
		Standalone,
		[Cpp2IlInjected.Token(Token = "0x4000261")]
		Pico,
		[Cpp2IlInjected.Token(Token = "0x4000262")]
		Switch
	}
	[Cpp2IlInjected.Token(Token = "0x20000A6")]
	[Utf8JsonSerializable]
	public class Progression : IRecNetUtf8JsonObject
	{
		[Cpp2IlInjected.Token(Token = "0x170001D6")]
		[DataMember(Name = "PlayerId")]
		public int AccountId
		{
			[Cpp2IlInjected.Token(Token = "0x6000439")]
			[Cpp2IlInjected.Address(RVA = "0xABD110", Offset = "0xABBF10", VA = "0x180ABD110")]
			[CompilerGenerated]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x600043A")]
			[Cpp2IlInjected.Address(RVA = "0xAC1D40", Offset = "0xAC0B40", VA = "0x180AC1D40")]
			[CompilerGenerated]
			internal set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001D7")]
		public int Level
		{
			[Cpp2IlInjected.Token(Token = "0x600043B")]
			[Cpp2IlInjected.Address(RVA = "0xBBC350", Offset = "0xBBB150", VA = "0x180BBC350")]
			[CompilerGenerated]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x600043C")]
			[Cpp2IlInjected.Address(RVA = "0xBBC340", Offset = "0xBBB140", VA = "0x180BBC340")]
			[CompilerGenerated]
			internal set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001D8")]
		public int XP
		{
			[Cpp2IlInjected.Token(Token = "0x600043D")]
			[Cpp2IlInjected.Address(RVA = "0xAC7B20", Offset = "0xAC6920", VA = "0x180AC7B20")]
			[CompilerGenerated]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x600043E")]
			[Cpp2IlInjected.Address(RVA = "0xACAE40", Offset = "0xAC9C40", VA = "0x180ACAE40")]
			[CompilerGenerated]
			internal set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600043F")]
		[Cpp2IlInjected.Address(RVA = "0xABE8D0", Offset = "0xABD6D0", VA = "0x180ABE8D0", Slot = "4")]
		public void DNRPRHFLPRB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000440")]
		[Cpp2IlInjected.Address(RVA = "0xAC4840", Offset = "0xAC3640", VA = "0x180AC4840")]
		public Progression()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000A7")]
	[Utf8JsonSerializable]
	public class ProgressionEventRecordDTO : IRecNetUtf8JsonObject
	{
		[Cpp2IlInjected.Token(Token = "0x170001D9")]
		public int AccountId
		{
			[Cpp2IlInjected.Token(Token = "0x6000443")]
			[Cpp2IlInjected.Address(RVA = "0xABD110", Offset = "0xABBF10", VA = "0x180ABD110")]
			[CompilerGenerated]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x6000444")]
			[Cpp2IlInjected.Address(RVA = "0xAC1D40", Offset = "0xAC0B40", VA = "0x180AC1D40")]
			[CompilerGenerated]
			internal set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001DA")]
		public int Xp
		{
			[Cpp2IlInjected.Token(Token = "0x6000445")]
			[Cpp2IlInjected.Address(RVA = "0xBBC350", Offset = "0xBBB150", VA = "0x180BBC350")]
			[CompilerGenerated]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x6000446")]
			[Cpp2IlInjected.Address(RVA = "0xBBC340", Offset = "0xBBB140", VA = "0x180BBC340")]
			[CompilerGenerated]
			internal set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001DB")]
		public int GameMinutesToday
		{
			[Cpp2IlInjected.Token(Token = "0x6000447")]
			[Cpp2IlInjected.Address(RVA = "0xAC7B20", Offset = "0xAC6920", VA = "0x180AC7B20")]
			[CompilerGenerated]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x6000448")]
			[Cpp2IlInjected.Address(RVA = "0xACAE40", Offset = "0xAC9C40", VA = "0x180ACAE40")]
			[CompilerGenerated]
			internal set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001DC")]
		public int RewardsCollected
		{
			[Cpp2IlInjected.Token(Token = "0x6000449")]
			[Cpp2IlInjected.Address(RVA = "0x15FD4F0", Offset = "0x15FC2F0", VA = "0x1815FD4F0")]
			[CompilerGenerated]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x600044A")]
			[Cpp2IlInjected.Address(RVA = "0x15FD4E0", Offset = "0x15FC2E0", VA = "0x1815FD4E0")]
			[CompilerGenerated]
			internal set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001DD")]
		public int BonusRewardsCollected
		{
			[Cpp2IlInjected.Token(Token = "0x600044B")]
			[Cpp2IlInjected.Address(RVA = "0xACF4D0", Offset = "0xACE2D0", VA = "0x180ACF4D0")]
			[CompilerGenerated]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x600044C")]
			[Cpp2IlInjected.Address(RVA = "0xB20FD0", Offset = "0xB1FDD0", VA = "0x180B20FD0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001DE")]
		public DateTime? XpBoostLastPurchasedAt
		{
			[Cpp2IlInjected.Token(Token = "0x600044D")]
			[Cpp2IlInjected.Address(RVA = "0x143F690", Offset = "0x143E490", VA = "0x18143F690")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600044E")]
			[Cpp2IlInjected.Address(RVA = "0x159EF20", Offset = "0x159DD20", VA = "0x18159EF20")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001DF")]
		public int PremiumRewardsCollected
		{
			[Cpp2IlInjected.Token(Token = "0x600044F")]
			[Cpp2IlInjected.Address(RVA = "0xAEE0C0", Offset = "0xAECEC0", VA = "0x180AEE0C0")]
			[CompilerGenerated]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x6000450")]
			[Cpp2IlInjected.Address(RVA = "0xE1B620", Offset = "0xE1A420", VA = "0x180E1B620")]
			[CompilerGenerated]
			internal set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000441")]
		[Cpp2IlInjected.Address(RVA = "0xAC4840", Offset = "0xAC3640", VA = "0x180AC4840")]
		public ProgressionEventRecordDTO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000442")]
		[Cpp2IlInjected.Address(RVA = "0x7A5F5E0", Offset = "0x7A5E3E0", VA = "0x187A5F5E0")]
		public ProgressionEventRecordDTO(int accountId = 0, int xp = 0, int gameMinutesToday = 0, int rewardsCollected = 0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000451")]
		[Cpp2IlInjected.Address(RVA = "0xABE8D0", Offset = "0xABD6D0", VA = "0x180ABE8D0", Slot = "4")]
		public void DNRPRHFLPRB()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000A8")]
	[Utf8JsonSerializable]
	public class ProgressionEventDTO : IRecNetUtf8JsonObject
	{
		[Cpp2IlInjected.Token(Token = "0x170001E0")]
		public long ProgressionEventId
		{
			[Cpp2IlInjected.Token(Token = "0x6000454")]
			[Cpp2IlInjected.Address(RVA = "0xABD130", Offset = "0xABBF30", VA = "0x180ABD130")]
			[CompilerGenerated]
			get
			{
				return default(long);
			}
			[Cpp2IlInjected.Token(Token = "0x6000455")]
			[Cpp2IlInjected.Address(RVA = "0xEABA00", Offset = "0xEAA800", VA = "0x180EABA00")]
			[CompilerGenerated]
			internal set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001E1")]
		public string Name
		{
			[Cpp2IlInjected.Token(Token = "0x6000456")]
			[Cpp2IlInjected.Address(RVA = "0xAC0D20", Offset = "0xABFB20", VA = "0x180AC0D20")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000457")]
			[Cpp2IlInjected.Address(RVA = "0xAC0D10", Offset = "0xABFB10", VA = "0x180AC0D10")]
			[CompilerGenerated]
			internal set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001E2")]
		public List<ProgressionEventRewardDTO> Rewards
		{
			[Cpp2IlInjected.Token(Token = "0x6000458")]
			[Cpp2IlInjected.Address(RVA = "0xAC1D20", Offset = "0xAC0B20", VA = "0x180AC1D20")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000459")]
			[Cpp2IlInjected.Address(RVA = "0xAC0640", Offset = "0xABF440", VA = "0x180AC0640")]
			[CompilerGenerated]
			internal set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001E3")]
		public List<KeepsakeRoomListDTO> KeepsakeRoomLists
		{
			[Cpp2IlInjected.Token(Token = "0x600045A")]
			[Cpp2IlInjected.Address(RVA = "0xAC0F90", Offset = "0xABFD90", VA = "0x180AC0F90")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600045B")]
			[Cpp2IlInjected.Address(RVA = "0xAC0650", Offset = "0xABF450", VA = "0x180AC0650")]
			[CompilerGenerated]
			internal set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001E4")]
		public DateTime StartTime
		{
			[Cpp2IlInjected.Token(Token = "0x600045C")]
			[Cpp2IlInjected.Address(RVA = "0xAC0F80", Offset = "0xABFD80", VA = "0x180AC0F80")]
			[CompilerGenerated]
			get
			{
				return default(DateTime);
			}
			[Cpp2IlInjected.Token(Token = "0x600045D")]
			[Cpp2IlInjected.Address(RVA = "0xAC0FA0", Offset = "0xABFDA0", VA = "0x180AC0FA0")]
			[CompilerGenerated]
			internal set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001E5")]
		public DateTime EndTime
		{
			[Cpp2IlInjected.Token(Token = "0x600045E")]
			[Cpp2IlInjected.Address(RVA = "0xAC0FC0", Offset = "0xABFDC0", VA = "0x180AC0FC0")]
			[CompilerGenerated]
			get
			{
				return default(DateTime);
			}
			[Cpp2IlInjected.Token(Token = "0x600045F")]
			[Cpp2IlInjected.Address(RVA = "0xAC6570", Offset = "0xAC5370", VA = "0x180AC6570")]
			[CompilerGenerated]
			internal set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001E6")]
		public DateTime CollectionEndTime
		{
			[Cpp2IlInjected.Token(Token = "0x6000460")]
			[Cpp2IlInjected.Address(RVA = "0xAC5120", Offset = "0xAC3F20", VA = "0x180AC5120")]
			[CompilerGenerated]
			get
			{
				return default(DateTime);
			}
			[Cpp2IlInjected.Token(Token = "0x6000461")]
			[Cpp2IlInjected.Address(RVA = "0xFDBAB0", Offset = "0xFDA8B0", VA = "0x180FDBAB0")]
			[CompilerGenerated]
			internal set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001E7")]
		public bool UsesBoost
		{
			[Cpp2IlInjected.Token(Token = "0x6000462")]
			[Cpp2IlInjected.Address(RVA = "0xDAAA60", Offset = "0xDA9860", VA = "0x180DAAA60")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000463")]
			[Cpp2IlInjected.Address(RVA = "0xE9A850", Offset = "0xE99650", VA = "0x180E9A850")]
			[CompilerGenerated]
			internal set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001E8")]
		public int BoostDailyGameplayMinutesLimit
		{
			[Cpp2IlInjected.Token(Token = "0x6000464")]
			[Cpp2IlInjected.Address(RVA = "0x15040E0", Offset = "0x1502EE0", VA = "0x1815040E0")]
			[CompilerGenerated]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x6000465")]
			[Cpp2IlInjected.Address(RVA = "0x1C2EDA0", Offset = "0x1C2DBA0", VA = "0x181C2EDA0")]
			[CompilerGenerated]
			internal set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001E9")]
		public float BoostXpMultiplier
		{
			[Cpp2IlInjected.Token(Token = "0x6000466")]
			[Cpp2IlInjected.Address(RVA = "0xB0E1D0", Offset = "0xB0CFD0", VA = "0x180B0E1D0")]
			[CompilerGenerated]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x6000467")]
			[Cpp2IlInjected.Address(RVA = "0x109F1E0", Offset = "0x109DFE0", VA = "0x18109F1E0")]
			[CompilerGenerated]
			internal set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001EA")]
		public Guid? PurchasableXpBoostId
		{
			[Cpp2IlInjected.Token(Token = "0x6000468")]
			[Cpp2IlInjected.Address(RVA = "0x7A5F5B0", Offset = "0x7A5E3B0", VA = "0x187A5F5B0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000469")]
			[Cpp2IlInjected.Address(RVA = "0x7A5F5D0", Offset = "0x7A5E3D0", VA = "0x187A5F5D0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001EB")]
		public string ActiveExperiment
		{
			[Cpp2IlInjected.Token(Token = "0x600046A")]
			[Cpp2IlInjected.Address(RVA = "0xAC3410", Offset = "0xAC2210", VA = "0x180AC3410")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600046B")]
			[Cpp2IlInjected.Address(RVA = "0xAC31A0", Offset = "0xAC1FA0", VA = "0x180AC31A0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001EC")]
		public string ChallengesIconImageName
		{
			[Cpp2IlInjected.Token(Token = "0x600046C")]
			[Cpp2IlInjected.Address(RVA = "0xAC50D0", Offset = "0xAC3ED0", VA = "0x180AC50D0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600046D")]
			[Cpp2IlInjected.Address(RVA = "0xAC58D0", Offset = "0xAC46D0", VA = "0x180AC58D0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001ED")]
		public string RewardsPipImageName
		{
			[Cpp2IlInjected.Token(Token = "0x600046E")]
			[Cpp2IlInjected.Address(RVA = "0xAC8150", Offset = "0xAC6F50", VA = "0x180AC8150")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600046F")]
			[Cpp2IlInjected.Address(RVA = "0xAC81C0", Offset = "0xAC6FC0", VA = "0x180AC81C0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001EE")]
		public string EventInfoImageName
		{
			[Cpp2IlInjected.Token(Token = "0x6000470")]
			[Cpp2IlInjected.Address(RVA = "0xAC7AA0", Offset = "0xAC68A0", VA = "0x180AC7AA0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000471")]
			[Cpp2IlInjected.Address(RVA = "0xAC8140", Offset = "0xAC6F40", VA = "0x180AC8140")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000452")]
		[Cpp2IlInjected.Address(RVA = "0xAC4840", Offset = "0xAC3640", VA = "0x180AC4840")]
		public ProgressionEventDTO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000453")]
		[Cpp2IlInjected.Address(RVA = "0x7A5F500", Offset = "0x7A5E300", VA = "0x187A5F500")]
		public ProgressionEventDTO(long progressionEventId = 0L, [Optional] string name, [Optional] List<ProgressionEventRewardDTO> rewards, [Optional] List<KeepsakeRoomListDTO> keepsakeRoomLists, [Optional] DateTime startTime, [Optional] DateTime endTime, [Optional] DateTime collectionEndTime, bool usesBoost = false, int boostDailyGameplayMinutesLimit = 0, float boostXpMultiplier = 0f)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000472")]
		[Cpp2IlInjected.Address(RVA = "0xABE8D0", Offset = "0xABD6D0", VA = "0x180ABE8D0", Slot = "4")]
		public void DNRPRHFLPRB()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000A9")]
	[Utf8JsonSerializable]
	public class KeepsakeRoomListDTO
	{
		[Cpp2IlInjected.Token(Token = "0x170001EF")]
		public long KeepsakeRoomListId
		{
			[Cpp2IlInjected.Token(Token = "0x6000475")]
			[Cpp2IlInjected.Address(RVA = "0xABD130", Offset = "0xABBF30", VA = "0x180ABD130")]
			[CompilerGenerated]
			get
			{
				return default(long);
			}
			[Cpp2IlInjected.Token(Token = "0x6000476")]
			[Cpp2IlInjected.Address(RVA = "0xEABA00", Offset = "0xEAA800", VA = "0x180EABA00")]
			[CompilerGenerated]
			internal set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001F0")]
		public long ProgressionEventId
		{
			[Cpp2IlInjected.Token(Token = "0x6000477")]
			[Cpp2IlInjected.Address(RVA = "0xAC0D20", Offset = "0xABFB20", VA = "0x180AC0D20")]
			[CompilerGenerated]
			get
			{
				return default(long);
			}
			[Cpp2IlInjected.Token(Token = "0x6000478")]
			[Cpp2IlInjected.Address(RVA = "0xE27A80", Offset = "0xE26880", VA = "0x180E27A80")]
			[CompilerGenerated]
			internal set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001F1")]
		public int? UnlockItemAvatarItemId
		{
			[Cpp2IlInjected.Token(Token = "0x6000479")]
			[Cpp2IlInjected.Address(RVA = "0xAC1D20", Offset = "0xAC0B20", VA = "0x180AC1D20")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600047A")]
			[Cpp2IlInjected.Address(RVA = "0xE33D40", Offset = "0xE32B40", VA = "0x180E33D40")]
			[CompilerGenerated]
			internal set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001F2")]
		public int? UnlockItemGiftDropId
		{
			[Cpp2IlInjected.Token(Token = "0x600047B")]
			[Cpp2IlInjected.Address(RVA = "0xAC0F90", Offset = "0xABFD90", VA = "0x180AC0F90")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600047C")]
			[Cpp2IlInjected.Address(RVA = "0xAC0D00", Offset = "0xABFB00", VA = "0x180AC0D00")]
			[CompilerGenerated]
			internal set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001F3")]
		public long? UnlockItemLockDurationTicks
		{
			[Cpp2IlInjected.Token(Token = "0x600047D")]
			[Cpp2IlInjected.Address(RVA = "0xF782C0", Offset = "0xF770C0", VA = "0x180F782C0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600047E")]
			[Cpp2IlInjected.Address(RVA = "0xF782D0", Offset = "0xF770D0", VA = "0x180F782D0")]
			[CompilerGenerated]
			internal set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001F4")]
		public long RoomUnlockStartOffsetTicks
		{
			[Cpp2IlInjected.Token(Token = "0x600047F")]
			[Cpp2IlInjected.Address(RVA = "0xAC5120", Offset = "0xAC3F20", VA = "0x180AC5120")]
			[CompilerGenerated]
			get
			{
				return default(long);
			}
			[Cpp2IlInjected.Token(Token = "0x6000480")]
			[Cpp2IlInjected.Address(RVA = "0xFDBAB0", Offset = "0xFDA8B0", VA = "0x180FDBAB0")]
			[CompilerGenerated]
			internal set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001F5")]
		public TimeSpan RoomUnlockStartOffset
		{
			[Cpp2IlInjected.Token(Token = "0x6000481")]
			[Cpp2IlInjected.Address(RVA = "0x7A5DE70", Offset = "0x7A5CC70", VA = "0x187A5DE70")]
			get
			{
				return default(TimeSpan);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001F6")]
		public long RoomUnlockIntervalTicks
		{
			[Cpp2IlInjected.Token(Token = "0x6000482")]
			[Cpp2IlInjected.Address(RVA = "0xAC0D30", Offset = "0xABFB30", VA = "0x180AC0D30")]
			[CompilerGenerated]
			get
			{
				return default(long);
			}
			[Cpp2IlInjected.Token(Token = "0x6000483")]
			[Cpp2IlInjected.Address(RVA = "0x13EE3C0", Offset = "0x13ED1C0", VA = "0x1813EE3C0")]
			[CompilerGenerated]
			internal set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001F7")]
		public TimeSpan RoomUnlockInterval
		{
			[Cpp2IlInjected.Token(Token = "0x6000484")]
			[Cpp2IlInjected.Address(RVA = "0x7A5DE20", Offset = "0x7A5CC20", VA = "0x187A5DE20")]
			get
			{
				return default(TimeSpan);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001F8")]
		public int RoomUnlockBatchSize
		{
			[Cpp2IlInjected.Token(Token = "0x6000485")]
			[Cpp2IlInjected.Address(RVA = "0xECA790", Offset = "0xEC9590", VA = "0x180ECA790")]
			[CompilerGenerated]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x6000486")]
			[Cpp2IlInjected.Address(RVA = "0x1A8D0D0", Offset = "0x1A8BED0", VA = "0x181A8D0D0")]
			[CompilerGenerated]
			internal set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001F9")]
		public KeepsakeRoomType RoomType
		{
			[Cpp2IlInjected.Token(Token = "0x6000487")]
			[Cpp2IlInjected.Address(RVA = "0x1323F70", Offset = "0x1322D70", VA = "0x181323F70")]
			[CompilerGenerated]
			get
			{
				return default(KeepsakeRoomType);
			}
			[Cpp2IlInjected.Token(Token = "0x6000488")]
			[Cpp2IlInjected.Address(RVA = "0x23375E0", Offset = "0x23363E0", VA = "0x1823375E0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001FA")]
		public List<KeepsakeRoomDTO> KeepsakeRooms
		{
			[Cpp2IlInjected.Token(Token = "0x6000489")]
			[Cpp2IlInjected.Address(RVA = "0xAC3430", Offset = "0xAC2230", VA = "0x180AC3430")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600048A")]
			[Cpp2IlInjected.Address(RVA = "0xAC31B0", Offset = "0xAC1FB0", VA = "0x180AC31B0")]
			[CompilerGenerated]
			internal set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000473")]
		[Cpp2IlInjected.Address(RVA = "0xAC4840", Offset = "0xAC3640", VA = "0x180AC4840")]
		public KeepsakeRoomListDTO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000474")]
		[Cpp2IlInjected.Address(RVA = "0x7A5DD30", Offset = "0x7A5CB30", VA = "0x187A5DD30")]
		public KeepsakeRoomListDTO(long keepsakeRoomListId = 0L, long progressionEventId = 0L, [Optional] int? unlockItemAvatarItemId, [Optional] int? unlockItemGiftDropId, [Optional] long? unlockItemLockDurationTicks, long roomUnlockStartOffsetTicks = 0L, long roomUnlockIntervalTicks = 0L, int roomUnlockBatchSize = 0, KeepsakeRoomType roomType = KeepsakeRoomType.Standard, [Optional] List<KeepsakeRoomDTO> keepsakeRooms)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000AA")]
	[Utf8JsonSerializable]
	public class KeepsakeRoomDTO
	{
		[Cpp2IlInjected.Token(Token = "0x170001FB")]
		public long KeepsakeRoomId
		{
			[Cpp2IlInjected.Token(Token = "0x600048D")]
			[Cpp2IlInjected.Address(RVA = "0xABD130", Offset = "0xABBF30", VA = "0x180ABD130")]
			[CompilerGenerated]
			get
			{
				return default(long);
			}
			[Cpp2IlInjected.Token(Token = "0x600048E")]
			[Cpp2IlInjected.Address(RVA = "0xEABA00", Offset = "0xEAA800", VA = "0x180EABA00")]
			[CompilerGenerated]
			internal set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001FC")]
		public long RoomId
		{
			[Cpp2IlInjected.Token(Token = "0x600048F")]
			[Cpp2IlInjected.Address(RVA = "0xAC0D20", Offset = "0xABFB20", VA = "0x180AC0D20")]
			[CompilerGenerated]
			get
			{
				return default(long);
			}
			[Cpp2IlInjected.Token(Token = "0x6000490")]
			[Cpp2IlInjected.Address(RVA = "0xE27A80", Offset = "0xE26880", VA = "0x180E27A80")]
			[CompilerGenerated]
			internal set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001FD")]
		public long KeepsakeRoomListId
		{
			[Cpp2IlInjected.Token(Token = "0x6000491")]
			[Cpp2IlInjected.Address(RVA = "0xAC1D20", Offset = "0xAC0B20", VA = "0x180AC1D20")]
			[CompilerGenerated]
			get
			{
				return default(long);
			}
			[Cpp2IlInjected.Token(Token = "0x6000492")]
			[Cpp2IlInjected.Address(RVA = "0xE33D40", Offset = "0xE32B40", VA = "0x180E33D40")]
			[CompilerGenerated]
			internal set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001FE")]
		public KeepsakeRoomType Type
		{
			[Cpp2IlInjected.Token(Token = "0x6000493")]
			[Cpp2IlInjected.Address(RVA = "0xAC2060", Offset = "0xAC0E60", VA = "0x180AC2060")]
			[CompilerGenerated]
			get
			{
				return default(KeepsakeRoomType);
			}
			[Cpp2IlInjected.Token(Token = "0x6000494")]
			[Cpp2IlInjected.Address(RVA = "0xAC1D30", Offset = "0xAC0B30", VA = "0x180AC1D30")]
			[CompilerGenerated]
			internal set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001FF")]
		public int Order
		{
			[Cpp2IlInjected.Token(Token = "0x6000495")]
			[Cpp2IlInjected.Address(RVA = "0xC56CD0", Offset = "0xC55AD0", VA = "0x180C56CD0")]
			[CompilerGenerated]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x6000496")]
			[Cpp2IlInjected.Address(RVA = "0x1D9ACF0", Offset = "0x1D99AF0", VA = "0x181D9ACF0")]
			[CompilerGenerated]
			internal set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600048B")]
		[Cpp2IlInjected.Address(RVA = "0xAC4840", Offset = "0xAC3640", VA = "0x180AC4840")]
		public KeepsakeRoomDTO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600048C")]
		[Cpp2IlInjected.Address(RVA = "0x7A5DCD0", Offset = "0x7A5CAD0", VA = "0x187A5DCD0")]
		public KeepsakeRoomDTO(long keepsakeRoomId = 0L, long roomId = 0L, long keepsakeRoomListId = 0L, KeepsakeRoomType type = KeepsakeRoomType.Standard, int order = 0)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000AB")]
	[Utf8JsonSerializable]
	public class ProgressionEventRewardDTO : IRecNetUtf8JsonObject
	{
		[Cpp2IlInjected.Token(Token = "0x17000200")]
		public long ProgressionEventRewardId
		{
			[Cpp2IlInjected.Token(Token = "0x6000497")]
			[Cpp2IlInjected.Address(RVA = "0xABD130", Offset = "0xABBF30", VA = "0x180ABD130")]
			[CompilerGenerated]
			get
			{
				return default(long);
			}
			[Cpp2IlInjected.Token(Token = "0x6000498")]
			[Cpp2IlInjected.Address(RVA = "0xEABA00", Offset = "0xEAA800", VA = "0x180EABA00")]
			[CompilerGenerated]
			internal set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000201")]
		public int GiftDropId
		{
			[Cpp2IlInjected.Token(Token = "0x6000499")]
			[Cpp2IlInjected.Address(RVA = "0xAC7B20", Offset = "0xAC6920", VA = "0x180AC7B20")]
			[CompilerGenerated]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x600049A")]
			[Cpp2IlInjected.Address(RVA = "0xACAE40", Offset = "0xAC9C40", VA = "0x180ACAE40")]
			[CompilerGenerated]
			internal set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000202")]
		public string ImageName
		{
			[Cpp2IlInjected.Token(Token = "0x600049B")]
			[Cpp2IlInjected.Address(RVA = "0xAC1D20", Offset = "0xAC0B20", VA = "0x180AC1D20")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600049C")]
			[Cpp2IlInjected.Address(RVA = "0xAC0640", Offset = "0xABF440", VA = "0x180AC0640")]
			[CompilerGenerated]
			internal set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000203")]
		public int Xp
		{
			[Cpp2IlInjected.Token(Token = "0x600049D")]
			[Cpp2IlInjected.Address(RVA = "0xAC2060", Offset = "0xAC0E60", VA = "0x180AC2060")]
			[CompilerGenerated]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x600049E")]
			[Cpp2IlInjected.Address(RVA = "0xAC1D30", Offset = "0xAC0B30", VA = "0x180AC1D30")]
			[CompilerGenerated]
			internal set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000204")]
		public int RewardIndex
		{
			[Cpp2IlInjected.Token(Token = "0x600049F")]
			[Cpp2IlInjected.Address(RVA = "0xC56CD0", Offset = "0xC55AD0", VA = "0x180C56CD0")]
			[CompilerGenerated]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x60004A0")]
			[Cpp2IlInjected.Address(RVA = "0x1D9ACF0", Offset = "0x1D99AF0", VA = "0x181D9ACF0")]
			[CompilerGenerated]
			internal set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000205")]
		public bool IsBonus
		{
			[Cpp2IlInjected.Token(Token = "0x60004A1")]
			[Cpp2IlInjected.Address(RVA = "0xC12EC0", Offset = "0xC11CC0", VA = "0x180C12EC0")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x60004A2")]
			[Cpp2IlInjected.Address(RVA = "0xC56AC0", Offset = "0xC558C0", VA = "0x180C56AC0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000206")]
		public bool IsRRPlusExclusive
		{
			[Cpp2IlInjected.Token(Token = "0x60004A3")]
			[Cpp2IlInjected.Address(RVA = "0xF6D050", Offset = "0xF6BE50", VA = "0x180F6D050")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x60004A4")]
			[Cpp2IlInjected.Address(RVA = "0xFB6170", Offset = "0xFB4F70", VA = "0x180FB6170")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60004A5")]
		[Cpp2IlInjected.Address(RVA = "0xABE8D0", Offset = "0xABD6D0", VA = "0x180ABE8D0", Slot = "4")]
		public void DNRPRHFLPRB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004A6")]
		[Cpp2IlInjected.Address(RVA = "0xAC4840", Offset = "0xAC3640", VA = "0x180AC4840")]
		public ProgressionEventRewardDTO()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000AC")]
	[Utf8JsonSerializable]
	public class ProgressionEventPurchasableXpBoostDTO : IRecNetUtf8JsonObject
	{
		[Cpp2IlInjected.Token(Token = "0x17000207")]
		public Guid ProgressionEventPurchasableXpBoostId
		{
			[Cpp2IlInjected.Token(Token = "0x60004A7")]
			[Cpp2IlInjected.Address(RVA = "0xEC6860", Offset = "0xEC5660", VA = "0x180EC6860")]
			[CompilerGenerated]
			get
			{
				return default(Guid);
			}
			[Cpp2IlInjected.Token(Token = "0x60004A8")]
			[Cpp2IlInjected.Address(RVA = "0xEC6880", Offset = "0xEC5680", VA = "0x180EC6880")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000208")]
		public int Cost
		{
			[Cpp2IlInjected.Token(Token = "0x60004A9")]
			[Cpp2IlInjected.Address(RVA = "0xACF4D0", Offset = "0xACE2D0", VA = "0x180ACF4D0")]
			[CompilerGenerated]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x60004AA")]
			[Cpp2IlInjected.Address(RVA = "0xB20FD0", Offset = "0xB1FDD0", VA = "0x180B20FD0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000209")]
		public int XpMultiplier
		{
			[Cpp2IlInjected.Token(Token = "0x60004AB")]
			[Cpp2IlInjected.Address(RVA = "0xAE6400", Offset = "0xAE5200", VA = "0x180AE6400")]
			[CompilerGenerated]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x60004AC")]
			[Cpp2IlInjected.Address(RVA = "0xEF6710", Offset = "0xEF5510", VA = "0x180EF6710")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700020A")]
		public int XpCap
		{
			[Cpp2IlInjected.Token(Token = "0x60004AD")]
			[Cpp2IlInjected.Address(RVA = "0xAC2060", Offset = "0xAC0E60", VA = "0x180AC2060")]
			[CompilerGenerated]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x60004AE")]
			[Cpp2IlInjected.Address(RVA = "0xAC1D30", Offset = "0xAC0B30", VA = "0x180AC1D30")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700020B")]
		public long LookbackDurationTicks
		{
			[Cpp2IlInjected.Token(Token = "0x60004AF")]
			[Cpp2IlInjected.Address(RVA = "0xAC0F80", Offset = "0xABFD80", VA = "0x180AC0F80")]
			[CompilerGenerated]
			get
			{
				return default(long);
			}
			[Cpp2IlInjected.Token(Token = "0x60004B0")]
			[Cpp2IlInjected.Address(RVA = "0xAC0FA0", Offset = "0xABFDA0", VA = "0x180AC0FA0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700020C")]
		public long CooldownDurationTicks
		{
			[Cpp2IlInjected.Token(Token = "0x60004B1")]
			[Cpp2IlInjected.Address(RVA = "0xAC0FC0", Offset = "0xABFDC0", VA = "0x180AC0FC0")]
			[CompilerGenerated]
			get
			{
				return default(long);
			}
			[Cpp2IlInjected.Token(Token = "0x60004B2")]
			[Cpp2IlInjected.Address(RVA = "0xAC6570", Offset = "0xAC5370", VA = "0x180AC6570")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60004B3")]
		[Cpp2IlInjected.Address(RVA = "0xABE8D0", Offset = "0xABD6D0", VA = "0x180ABE8D0", Slot = "4")]
		public void DNRPRHFLPRB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004B4")]
		[Cpp2IlInjected.Address(RVA = "0xAC4840", Offset = "0xAC3640", VA = "0x180AC4840")]
		public ProgressionEventPurchasableXpBoostDTO()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000AD")]
	public enum KeepsakeRoomType
	{
		[Cpp2IlInjected.Token(Token = "0x4000299")]
		Standard,
		[Cpp2IlInjected.Token(Token = "0x400029A")]
		Premium
	}
	[Cpp2IlInjected.Token(Token = "0x20000AE")]
	public enum KeepsakeCategory
	{
		[Cpp2IlInjected.Token(Token = "0x400029C")]
		Explore = 0,
		[Cpp2IlInjected.Token(Token = "0x400029D")]
		GreenPowerCore = 1,
		[Cpp2IlInjected.Token(Token = "0x400029E")]
		Present = 2,
		[Cpp2IlInjected.Token(Token = "0x400029F")]
		PurplePowerCore = 3,
		[Cpp2IlInjected.Token(Token = "0x40002A0")]
		UnnamedKeepsakeNumber1 = 4,
		[Cpp2IlInjected.Token(Token = "0x40002A1")]
		UnnamedKeepsakeNumber2 = 5,
		[Cpp2IlInjected.Token(Token = "0x40002A2")]
		UnnamedKeepsakeNumber3 = 6,
		[Cpp2IlInjected.Token(Token = "0x40002A3")]
		UnnamedKeepsakeNumber4 = 7,
		[Cpp2IlInjected.Token(Token = "0x40002A4")]
		UnnamedKeepsakeNumber5 = 8,
		[Cpp2IlInjected.Token(Token = "0x40002A5")]
		_Test = 1000
	}
	[Cpp2IlInjected.Token(Token = "0x20000AF")]
	[Utf8JsonSerializable]
	public class RefereeFileReferenceDTO : IRecNetUtf8JsonObject
	{
		[Cpp2IlInjected.Token(Token = "0x1700020D")]
		public string Filename
		{
			[Cpp2IlInjected.Token(Token = "0x60004B5")]
			[Cpp2IlInjected.Address(RVA = "0xABD130", Offset = "0xABBF30", VA = "0x180ABD130")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60004B6")]
			[Cpp2IlInjected.Address(RVA = "0xABD120", Offset = "0xABBF20", VA = "0x180ABD120")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700020E")]
		public string? Hash
		{
			[Cpp2IlInjected.Token(Token = "0x60004B7")]
			[Cpp2IlInjected.Address(RVA = "0xAC0D20", Offset = "0xABFB20", VA = "0x180AC0D20")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60004B8")]
			[Cpp2IlInjected.Address(RVA = "0xAC0D10", Offset = "0xABFB10", VA = "0x180AC0D10")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60004B9")]
		[Cpp2IlInjected.Address(RVA = "0xABE8D0", Offset = "0xABD6D0", VA = "0x180ABE8D0", Slot = "4")]
		public void DNRPRHFLPRB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004BA")]
		[Cpp2IlInjected.Address(RVA = "0xAC4840", Offset = "0xAC3640", VA = "0x180AC4840")]
		public RefereeFileReferenceDTO()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000B0")]
	public interface DEUOTOOEDVA
	{
		[Cpp2IlInjected.Token(Token = "0x1700020F")]
		bool Success
		{
			[Cpp2IlInjected.Token(Token = "0x60004BB")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000210")]
		string? Error
		{
			[Cpp2IlInjected.Token(Token = "0x60004BC")]
			[Cpp2IlInjected.Address(Slot = "1")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000211")]
		string? ErrorId
		{
			[Cpp2IlInjected.Token(Token = "0x60004BD")]
			[Cpp2IlInjected.Address(Slot = "2")]
			get;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000B1")]
	public interface XBMGONGUUVP<a> : DEUOTOOEDVA
	{
		[Cpp2IlInjected.Token(Token = "0x17000212")]
		a Value
		{
			[Cpp2IlInjected.Token(Token = "0x60004BE")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000B2")]
	public static class OUEAGJKIHGN
	{
		[Cpp2IlInjected.Token(Token = "0x60004BF")]
		[Cpp2IlInjected.Address(RVA = "0x3B13370", Offset = "0x3B12170", VA = "0x183B13370")]
		public static XBMGONGUUVP<T> Transform<T, U>(this XBMGONGUUVP<U> result, Func<U, T> transformFunc)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000B3")]
	public struct RecNetResultUnserialized<T> : XBMGONGUUVP<T>, DEUOTOOEDVA
	{
		[Cpp2IlInjected.Token(Token = "0x17000213")]
		public bool Success
		{
			[Cpp2IlInjected.Token(Token = "0x60004C0")]
			[Cpp2IlInjected.Address(RVA = "0x10BC830", Offset = "0x10BB630", VA = "0x1810BC830", Slot = "5")]
			[CompilerGenerated]
			readonly get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x60004C1")]
			[Cpp2IlInjected.Address(RVA = "0x2D38590", Offset = "0x2D37390", VA = "0x182D38590")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000214")]
		public string? Error
		{
			[Cpp2IlInjected.Token(Token = "0x60004C2")]
			[Cpp2IlInjected.Address(RVA = "0xB72150", Offset = "0xB70F50", VA = "0x180B72150", Slot = "6")]
			[CompilerGenerated]
			readonly get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60004C3")]
			[Cpp2IlInjected.Address(RVA = "0xF4F940", Offset = "0xF4E740", VA = "0x180F4F940")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000215")]
		public string? ErrorId
		{
			[Cpp2IlInjected.Token(Token = "0x60004C4")]
			[Cpp2IlInjected.Address(RVA = "0xABD130", Offset = "0xABBF30", VA = "0x180ABD130", Slot = "7")]
			[CompilerGenerated]
			readonly get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60004C5")]
			[Cpp2IlInjected.Address(RVA = "0xABD120", Offset = "0xABBF20", VA = "0x180ABD120")]
			[CompilerGenerated]
			internal set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000216")]
		public T Value
		{
			[Cpp2IlInjected.Token(Token = "0x60004C6")]
			[Cpp2IlInjected.Address(RVA = "0xAC0D20", Offset = "0xABFB20", VA = "0x180AC0D20", Slot = "4")]
			[CompilerGenerated]
			readonly get
			{
				return (T)null;
			}
			[Cpp2IlInjected.Token(Token = "0x60004C7")]
			[Cpp2IlInjected.Address(RVA = "0xAC0D10", Offset = "0xABFB10", VA = "0x180AC0D10")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60004C8")]
		[Cpp2IlInjected.Address(RVA = "0x605C970", Offset = "0x605B770", VA = "0x18605C970")]
		public static RecNetResultUnserialized<T> Ok(T value)
		{
			return default(RecNetResultUnserialized<T>);
		}

		[Cpp2IlInjected.Token(Token = "0x60004C9")]
		[Cpp2IlInjected.Address(RVA = "0x605C340", Offset = "0x605B140", VA = "0x18605C340")]
		public static RecNetResultUnserialized<T> Fail(string error, string errorId = "")
		{
			return default(RecNetResultUnserialized<T>);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000B4")]
	[Utf8JsonSerializable]
	public class RecNetResult : DEUOTOOEDVA, IRecNetUtf8JsonObject
	{
		[Cpp2IlInjected.Token(Token = "0x17000217")]
		public bool Success
		{
			[Cpp2IlInjected.Token(Token = "0x60004CA")]
			[Cpp2IlInjected.Address(RVA = "0xB12A00", Offset = "0xB11800", VA = "0x180B12A00", Slot = "4")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x60004CB")]
			[Cpp2IlInjected.Address(RVA = "0xBA1650", Offset = "0xBA0450", VA = "0x180BA1650")]
			[CompilerGenerated]
			internal set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000218")]
		public string? Error
		{
			[Cpp2IlInjected.Token(Token = "0x60004CC")]
			[Cpp2IlInjected.Address(RVA = "0xAC0D20", Offset = "0xABFB20", VA = "0x180AC0D20", Slot = "5")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60004CD")]
			[Cpp2IlInjected.Address(RVA = "0xAC0D10", Offset = "0xABFB10", VA = "0x180AC0D10")]
			[CompilerGenerated]
			internal set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000219")]
		[DataMember(Name = "error_id")]
		public string? ErrorId
		{
			[Cpp2IlInjected.Token(Token = "0x60004CE")]
			[Cpp2IlInjected.Address(RVA = "0xAC1D20", Offset = "0xAC0B20", VA = "0x180AC1D20", Slot = "6")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60004CF")]
			[Cpp2IlInjected.Address(RVA = "0xAC0640", Offset = "0xABF440", VA = "0x180AC0640")]
			[CompilerGenerated]
			internal set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60004D0")]
		[Cpp2IlInjected.Address(RVA = "0xABE8D0", Offset = "0xABD6D0", VA = "0x180ABE8D0", Slot = "8")]
		public virtual void DNRPRHFLPRB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004D1")]
		[Cpp2IlInjected.Address(RVA = "0x7A604F0", Offset = "0x7A5F2F0", VA = "0x187A604F0")]
		public static RecNetResult Ok()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60004D2")]
		[Cpp2IlInjected.Address(RVA = "0x7A60460", Offset = "0x7A5F260", VA = "0x187A60460")]
		public static RecNetResult Fail(string error, string errorId = "")
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60004D3")]
		[Cpp2IlInjected.Address(RVA = "0xAC4840", Offset = "0xAC3640", VA = "0x180AC4840")]
		public RecNetResult()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000B5")]
	[Utf8JsonSerializableGeneric]
	public abstract class RecNetResult<T> : RecNetResult, XBMGONGUUVP<T>, DEUOTOOEDVA
	{
		[Cpp2IlInjected.Token(Token = "0x1700021A")]
		public T Value
		{
			[Cpp2IlInjected.Token(Token = "0x60004D4")]
			[Cpp2IlInjected.Address(RVA = "0xD79680", Offset = "0xD78480", VA = "0x180D79680", Slot = "9")]
			[CompilerGenerated]
			get
			{
				return (T)null;
			}
			[Cpp2IlInjected.Token(Token = "0x60004D5")]
			[Cpp2IlInjected.Address(RVA = "0xC330C0", Offset = "0xC31EC0", VA = "0x180C330C0")]
			[CompilerGenerated]
			internal set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60004D6")]
		[Cpp2IlInjected.Address(RVA = "0xAE81C0", Offset = "0xAE6FC0", VA = "0x180AE81C0")]
		protected RecNetResult()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000B6")]
	[Utf8JsonSerializableGeneric]
	public class RecNetResultPrimitive<T> : RecNetResult<T>
	{
		[Cpp2IlInjected.Token(Token = "0x60004D7")]
		[Cpp2IlInjected.Address(RVA = "0x605C2C0", Offset = "0x605B0C0", VA = "0x18605C2C0")]
		private static void BNYPKEUBUJE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004D8")]
		[Cpp2IlInjected.Address(RVA = "0xAE81C0", Offset = "0xAE6FC0", VA = "0x180AE81C0")]
		public RecNetResultPrimitive()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000B7")]
	[Utf8JsonSerializableGeneric]
	public class RecNetResultObject<T> : RecNetResult<T>, IRecNetUtf8JsonObjectPerformsPostProcessing, IRecNetUtf8JsonObject where T : IRecNetUtf8JsonObject, new()
	{
		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x20000B8")]
		[CompilerGenerated]
		private struct <OnPostDeserialized>d__1 : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40002B0")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40002B1")]
			public AsyncTaskMethodBuilder <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40002B2")]
			public RecNetResultObject<T> <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40002B3")]
			private TaskAwaiter <>u__1;

			[Cpp2IlInjected.Token(Token = "0x60004DE")]
			[Cpp2IlInjected.Address(RVA = "0x531A7D0", Offset = "0x53195D0", VA = "0x18531A7D0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60004DF")]
			[Cpp2IlInjected.Address(RVA = "0x531A9F0", Offset = "0x53197F0", VA = "0x18531A9F0", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60004D9")]
		[Cpp2IlInjected.Address(RVA = "0x605BAB0", Offset = "0x605A8B0", VA = "0x18605BAB0", Slot = "8")]
		public override void DNRPRHFLPRB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004DA")]
		[Cpp2IlInjected.Address(RVA = "0x605C1F0", Offset = "0x605AFF0", VA = "0x18605C1F0", Slot = "10")]
		[AsyncStateMachine(typeof(RecNetResultObject<>.<OnPostDeserialized>d__1))]
		public Task WSLKELMBPUB()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60004DB")]
		[Cpp2IlInjected.Address(RVA = "0x605BE20", Offset = "0x605AC20", VA = "0x18605BE20")]
		public static RecNetResultObject<T> Ok(T value)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60004DC")]
		[Cpp2IlInjected.Address(RVA = "0x605BB10", Offset = "0x605A910", VA = "0x18605BB10")]
		public new static RecNetResultObject<T> Fail(string error, string errorId = "")
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60004DD")]
		[Cpp2IlInjected.Address(RVA = "0xAE81C0", Offset = "0xAE6FC0", VA = "0x180AE81C0")]
		public RecNetResultObject()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000B9")]
	[Utf8JsonSerializableGeneric]
	public class RecNetResultListPrimitive<T> : RecNetResult<List<T>>
	{
		[Cpp2IlInjected.Token(Token = "0x60004E0")]
		[Cpp2IlInjected.Address(RVA = "0x427C160", Offset = "0x427AF60", VA = "0x18427C160")]
		public RecNetResultListPrimitive()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000BA")]
	[Utf8JsonSerializableGeneric]
	public class RecNetResultListObject<T> : RecNetResult<List<T>>, IRecNetUtf8JsonObjectPerformsPostProcessing, IRecNetUtf8JsonObject where T : IRecNetUtf8JsonObject, new()
	{
		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x20000BB")]
		[CompilerGenerated]
		private struct <OnPostDeserialized>d__3 : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40002B4")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40002B5")]
			public AsyncTaskMethodBuilder <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40002B6")]
			public RecNetResultListObject<T> <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40002B7")]
			private TaskAwaiter <>u__1;

			[Cpp2IlInjected.Token(Token = "0x60004E6")]
			[Cpp2IlInjected.Address(RVA = "0x531AF50", Offset = "0x5319D50", VA = "0x18531AF50", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60004E7")]
			[Cpp2IlInjected.Address(RVA = "0x531B350", Offset = "0x531A150", VA = "0x18531B350", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60004E1")]
		[Cpp2IlInjected.Address(RVA = "0x605B5C0", Offset = "0x605A3C0", VA = "0x18605B5C0")]
		public static RecNetResultListObject<T> Ok(List<T> value)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60004E2")]
		[Cpp2IlInjected.Address(RVA = "0x605B250", Offset = "0x605A050", VA = "0x18605B250")]
		public new static RecNetResultListObject<T> Fail(string error, string errorId = "")
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60004E3")]
		[Cpp2IlInjected.Address(RVA = "0x605ACC0", Offset = "0x6059AC0", VA = "0x18605ACC0", Slot = "8")]
		public override void DNRPRHFLPRB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004E4")]
		[Cpp2IlInjected.Address(RVA = "0x605B770", Offset = "0x605A570", VA = "0x18605B770", Slot = "10")]
		[AsyncStateMachine(typeof(RecNetResultListObject<>.<OnPostDeserialized>d__3))]
		public Task WSLKELMBPUB()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60004E5")]
		[Cpp2IlInjected.Address(RVA = "0xAE81C0", Offset = "0xAE6FC0", VA = "0x180AE81C0")]
		public RecNetResultListObject()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000BC")]
	public enum Service
	{
		[Cpp2IlInjected.Token(Token = "0x40002B9")]
		AI,
		[Cpp2IlInjected.Token(Token = "0x40002BA")]
		Auth,
		[Cpp2IlInjected.Token(Token = "0x40002BB")]
		API,
		[Cpp2IlInjected.Token(Token = "0x40002BC")]
		Commerce,
		[Cpp2IlInjected.Token(Token = "0x40002BD")]
		Matchmaking,
		[Cpp2IlInjected.Token(Token = "0x40002BE")]
		Notifications,
		[Cpp2IlInjected.Token(Token = "0x40002BF")]
		Images,
		[Cpp2IlInjected.Token(Token = "0x40002C0")]
		CDN,
		[Cpp2IlInjected.Token(Token = "0x40002C1")]
		Storage,
		[Cpp2IlInjected.Token(Token = "0x40002C2")]
		Chat,
		[Cpp2IlInjected.Token(Token = "0x40002C3")]
		Leaderboard,
		[Cpp2IlInjected.Token(Token = "0x40002C4")]
		Accounts,
		[Cpp2IlInjected.Token(Token = "0x40002C5")]
		Link,
		[Cpp2IlInjected.Token(Token = "0x40002C6")]
		Lists,
		[Cpp2IlInjected.Token(Token = "0x40002C7")]
		RoomComments,
		[Cpp2IlInjected.Token(Token = "0x40002C8")]
		Clubs,
		[Cpp2IlInjected.Token(Token = "0x40002C9")]
		Rooms,
		[Cpp2IlInjected.Token(Token = "0x40002CA")]
		PlatformNotifications,
		[Cpp2IlInjected.Token(Token = "0x40002CB")]
		Moderation,
		[Cpp2IlInjected.Token(Token = "0x40002CC")]
		DataCollection,
		[Cpp2IlInjected.Token(Token = "0x40002CD")]
		BugReporting,
		[Cpp2IlInjected.Token(Token = "0x40002CE")]
		Discovery,
		[Cpp2IlInjected.Token(Token = "0x40002CF")]
		PlayerSettings,
		[Cpp2IlInjected.Token(Token = "0x40002D0")]
		Studio,
		[Cpp2IlInjected.Token(Token = "0x40002D1")]
		GameLogs,
		[Cpp2IlInjected.Token(Token = "0x40002D2")]
		Strings,
		[Cpp2IlInjected.Token(Token = "0x40002D3")]
		StringsCDN,
		[Cpp2IlInjected.Token(Token = "0x40002D4")]
		WWW,
		[Cpp2IlInjected.Token(Token = "0x40002D5")]
		Econ,
		[Cpp2IlInjected.Token(Token = "0x40002D6")]
		Data,
		[Cpp2IlInjected.Token(Token = "0x40002D7")]
		Cards
	}
	[Cpp2IlInjected.Token(Token = "0x20000BD")]
	public static class JNCRQOWXNHG
	{
		[Cpp2IlInjected.Token(Token = "0x60004E8")]
		[Cpp2IlInjected.Address(RVA = "0x7A5DBB0", Offset = "0x7A5C9B0", VA = "0x187A5DBB0")]
		public static bool STQARDLETNM(this Service a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60004E9")]
		[Cpp2IlInjected.Address(RVA = "0x7A5DBB0", Offset = "0x7A5C9B0", VA = "0x187A5DBB0")]
		public static bool SPMKVNFPQHA(this Service a)
		{
			return default(bool);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000BE")]
	public enum CurrencyType
	{
		[Cpp2IlInjected.Token(Token = "0x40002D9")]
		Invalid = 0,
		[Cpp2IlInjected.Token(Token = "0x40002DA")]
		LaserTagTickets = 1,
		[Cpp2IlInjected.Token(Token = "0x40002DB")]
		RecCenterTokens = 2,
		[Cpp2IlInjected.Token(Token = "0x40002DC")]
		LostSkullsGold = 100,
		[Cpp2IlInjected.Token(Token = "0x40002DD")]
		DraculaSilver = 101,
		[Cpp2IlInjected.Token(Token = "0x40002DE")]
		RecRoyale_Season1 = 200,
		[Cpp2IlInjected.Token(Token = "0x40002DF")]
		RoomCurrency = 300,
		[Cpp2IlInjected.Token(Token = "0x40002E0")]
		RoomInventoryItem = 301,
		[Cpp2IlInjected.Token(Token = "0x40002E1")]
		ProgressionEvent = 400,
		[Cpp2IlInjected.Token(Token = "0x40002E2")]
		RoomieCredits = 500
	}
	[Cpp2IlInjected.Token(Token = "0x20000BF")]
	public enum StorefrontBalanceType
	{
		[Cpp2IlInjected.Token(Token = "0x40002E4")]
		NonPurchasedNotUsableInP2P = -2,
		[Cpp2IlInjected.Token(Token = "0x40002E5")]
		NonPurchasedDefault = -1,
		[Cpp2IlInjected.Token(Token = "0x40002E6")]
		SteamPurchased = 0,
		[Cpp2IlInjected.Token(Token = "0x40002E7")]
		OculusPurchased = 1,
		[Cpp2IlInjected.Token(Token = "0x40002E8")]
		PlayStationPurchased = 2,
		[Cpp2IlInjected.Token(Token = "0x40002E9")]
		MicrosoftPurchased = 3,
		[Cpp2IlInjected.Token(Token = "0x40002EA")]
		IOSPurchased = 5,
		[Cpp2IlInjected.Token(Token = "0x40002EB")]
		GooglePlayPurchased = 6,
		[Cpp2IlInjected.Token(Token = "0x40002EC")]
		PicoPurchased = 8,
		[Cpp2IlInjected.Token(Token = "0x40002ED")]
		RecNetPurchased = 4,
		[Cpp2IlInjected.Token(Token = "0x40002EE")]
		SwitchPurchased = 9,
		[Cpp2IlInjected.Token(Token = "0x40002EF")]
		[Obsolete("Subscription benefits for PS4 players were awarded with this balance type. It is not transferrable to other platforms. Usable in P2P economy. We are using PlayStationPurchased instead now. -- bilal - 11/11/2020")]
		PlayStationNonPurchasedP2P = 100,
		[Cpp2IlInjected.Token(Token = "0x40002F0")]
		[Obsolete("Subscription benefits for NON PS4 players were awarded with this balance type. We are using <PlatformType>Purchased instead now. -- bilal - 11/11/2020")]
		NonPlayStationNonPurchasedP2P = 101,
		[Cpp2IlInjected.Token(Token = "0x40002F1")]
		NonPurchasedEarnedByP2P = 1000,
		[Cpp2IlInjected.Token(Token = "0x40002F2")]
		NonPurchasedEarnedByP2Pv2 = 1001,
		[Cpp2IlInjected.Token(Token = "0x40002F3")]
		RoomieEnergyPack = 1101
	}
	[Cpp2IlInjected.Token(Token = "0x20000C0")]
	public enum GiftContext
	{
		[Cpp2IlInjected.Token(Token = "0x40002F5")]
		None = -1,
		[Cpp2IlInjected.Token(Token = "0x40002F6")]
		Default = 0,
		[Cpp2IlInjected.Token(Token = "0x40002F7")]
		First_Activity = 1,
		[Cpp2IlInjected.Token(Token = "0x40002F8")]
		Game_Drop = 2,
		[Cpp2IlInjected.Token(Token = "0x40002F9")]
		All_Daily_Challenges_Complete = 3,
		[Cpp2IlInjected.Token(Token = "0x40002FA")]
		All_Weekly_Challenge_Complete = 4,
		[Cpp2IlInjected.Token(Token = "0x40002FB")]
		Daily_Challenge_Complete = 5,
		[Cpp2IlInjected.Token(Token = "0x40002FC")]
		Weekly_Challenge_Complete = 6,
		[Cpp2IlInjected.Token(Token = "0x40002FD")]
		Unassigned_Equipment = 10,
		[Cpp2IlInjected.Token(Token = "0x40002FE")]
		Unassigned_Avatar = 11,
		[Cpp2IlInjected.Token(Token = "0x40002FF")]
		Unassigned_Consumable = 12,
		[Cpp2IlInjected.Token(Token = "0x4000300")]
		Reacquisition = 20,
		[Cpp2IlInjected.Token(Token = "0x4000301")]
		Membership = 21,
		[Cpp2IlInjected.Token(Token = "0x4000302")]
		NUX_TokensAndDressUp = 30,
		[Cpp2IlInjected.Token(Token = "0x4000303")]
		NUX_Experiment1 = 31,
		[Cpp2IlInjected.Token(Token = "0x4000304")]
		NUX_Experiment2 = 32,
		[Cpp2IlInjected.Token(Token = "0x4000305")]
		NUX_Experiment3 = 33,
		[Cpp2IlInjected.Token(Token = "0x4000306")]
		NUX_Experiment4 = 34,
		[Cpp2IlInjected.Token(Token = "0x4000307")]
		NUX_Experiment5 = 35,
		[Cpp2IlInjected.Token(Token = "0x4000308")]
		GameRewards = 50,
		[Cpp2IlInjected.Token(Token = "0x4000309")]
		GameRewards_Tokens = 51,
		[Cpp2IlInjected.Token(Token = "0x400030A")]
		GameRewards_Tokens_Experiment_Override = 52,
		[Cpp2IlInjected.Token(Token = "0x400030B")]
		GameRewards_A = 53,
		[Cpp2IlInjected.Token(Token = "0x400030C")]
		GameRewards_B = 54,
		[Cpp2IlInjected.Token(Token = "0x400030D")]
		LevelUp = 100,
		[Cpp2IlInjected.Token(Token = "0x400030E")]
		Purchased_Gift_A = 500,
		[Cpp2IlInjected.Token(Token = "0x400030F")]
		Purchased_Gift_B = 501,
		[Cpp2IlInjected.Token(Token = "0x4000310")]
		Purchased_Gift_C = 502,
		[Cpp2IlInjected.Token(Token = "0x4000311")]
		Purchased_Gift_D = 503,
		[Cpp2IlInjected.Token(Token = "0x4000312")]
		Holiday = 1000,
		[Cpp2IlInjected.Token(Token = "0x4000313")]
		Contest = 1001,
		[Cpp2IlInjected.Token(Token = "0x4000314")]
		Promotion = 1002,
		[Cpp2IlInjected.Token(Token = "0x4000315")]
		LimitedTime = 1003,
		[Cpp2IlInjected.Token(Token = "0x4000316")]
		LimitedTimeEvent = 1004,
		[Cpp2IlInjected.Token(Token = "0x4000317")]
		Deprecated = 1100,
		[Cpp2IlInjected.Token(Token = "0x4000318")]
		RecRoyale = 1200,
		[Cpp2IlInjected.Token(Token = "0x4000319")]
		Friendotron_Gift = 1300,
		[Cpp2IlInjected.Token(Token = "0x400031A")]
		DEPRECATED_Paintball_ClearCut = 2000,
		[Cpp2IlInjected.Token(Token = "0x400031B")]
		DEPRECATED_Paintball_Homestead = 2001,
		[Cpp2IlInjected.Token(Token = "0x400031C")]
		DEPRECATED_Paintball_Quarry = 2002,
		[Cpp2IlInjected.Token(Token = "0x400031D")]
		DEPRECATED_Paintball_River = 2003,
		[Cpp2IlInjected.Token(Token = "0x400031E")]
		DEPRECATED_Paintball_Dam = 2004,
		[Cpp2IlInjected.Token(Token = "0x400031F")]
		DEPRECATED_Paintball_DriveIn = 2005,
		[Cpp2IlInjected.Token(Token = "0x4000320")]
		Paintball_ClearCut = 2010,
		[Cpp2IlInjected.Token(Token = "0x4000321")]
		Paintball_Homestead = 2011,
		[Cpp2IlInjected.Token(Token = "0x4000322")]
		Paintball_Quarry = 2012,
		[Cpp2IlInjected.Token(Token = "0x4000323")]
		Paintball_River = 2013,
		[Cpp2IlInjected.Token(Token = "0x4000324")]
		Paintball_Dam = 2014,
		[Cpp2IlInjected.Token(Token = "0x4000325")]
		Paintball_DriveIn = 2015,
		[Cpp2IlInjected.Token(Token = "0x4000326")]
		Paintball_MerryMidway = 2016,
		[Cpp2IlInjected.Token(Token = "0x4000327")]
		DEPRECATED_Discgolf_Propulsion = 3000,
		[Cpp2IlInjected.Token(Token = "0x4000328")]
		DEPRECATED_Discgolf_Lake = 3001,
		[Cpp2IlInjected.Token(Token = "0x4000329")]
		Discgolf_Propulsion = 3010,
		[Cpp2IlInjected.Token(Token = "0x400032A")]
		Discgolf_Lake = 3011,
		[Cpp2IlInjected.Token(Token = "0x400032B")]
		Discgolf_Mode_CoopCatch = 3500,
		[Cpp2IlInjected.Token(Token = "0x400032C")]
		Quest_Goblin_A = 4000,
		[Cpp2IlInjected.Token(Token = "0x400032D")]
		Quest_Goblin_B = 4001,
		[Cpp2IlInjected.Token(Token = "0x400032E")]
		Quest_Goblin_C = 4002,
		[Cpp2IlInjected.Token(Token = "0x400032F")]
		Quest_Goblin_S = 4003,
		[Cpp2IlInjected.Token(Token = "0x4000330")]
		Quest_Goblin_Consumable = 4004,
		[Cpp2IlInjected.Token(Token = "0x4000331")]
		Quest_Cauldron_A = 4010,
		[Cpp2IlInjected.Token(Token = "0x4000332")]
		Quest_Cauldron_B = 4011,
		[Cpp2IlInjected.Token(Token = "0x4000333")]
		Quest_Cauldron_C = 4012,
		[Cpp2IlInjected.Token(Token = "0x4000334")]
		Quest_Cauldron_S = 4013,
		[Cpp2IlInjected.Token(Token = "0x4000335")]
		Quest_Cauldron_Consumable = 4014,
		[Cpp2IlInjected.Token(Token = "0x4000336")]
		Quest_Pirate1_A = 4100,
		[Cpp2IlInjected.Token(Token = "0x4000337")]
		Quest_Pirate1_B = 4101,
		[Cpp2IlInjected.Token(Token = "0x4000338")]
		Quest_Pirate1_C = 4102,
		[Cpp2IlInjected.Token(Token = "0x4000339")]
		Quest_Pirate1_S = 4103,
		[Cpp2IlInjected.Token(Token = "0x400033A")]
		Quest_Pirate1_X = 4104,
		[Cpp2IlInjected.Token(Token = "0x400033B")]
		Quest_Pirate1_Consumable = 4105,
		[Cpp2IlInjected.Token(Token = "0x400033C")]
		Quest_Dracula1_A = 4200,
		[Cpp2IlInjected.Token(Token = "0x400033D")]
		Quest_Dracula1_B = 4201,
		[Cpp2IlInjected.Token(Token = "0x400033E")]
		Quest_Dracula1_C = 4202,
		[Cpp2IlInjected.Token(Token = "0x400033F")]
		Quest_Dracula1_S = 4203,
		[Cpp2IlInjected.Token(Token = "0x4000340")]
		Quest_Dracula1_X = 4204,
		[Cpp2IlInjected.Token(Token = "0x4000341")]
		Quest_Dracula1_Consumable = 4205,
		[Cpp2IlInjected.Token(Token = "0x4000342")]
		Quest_Dracula1_SS = 4206,
		[Cpp2IlInjected.Token(Token = "0x4000343")]
		Quest_SciFi_A = 4500,
		[Cpp2IlInjected.Token(Token = "0x4000344")]
		Quest_SciFi_B = 4501,
		[Cpp2IlInjected.Token(Token = "0x4000345")]
		Quest_SciFi_C = 4502,
		[Cpp2IlInjected.Token(Token = "0x4000346")]
		Quest_SciFi_S = 4503,
		[Cpp2IlInjected.Token(Token = "0x4000347")]
		Quest_Scifi_Consumable = 4504,
		[Cpp2IlInjected.Token(Token = "0x4000348")]
		DEPRECATED_Charades = 5000,
		[Cpp2IlInjected.Token(Token = "0x4000349")]
		Charades = 5001,
		[Cpp2IlInjected.Token(Token = "0x400034A")]
		DEPRECATED_Soccer = 6000,
		[Cpp2IlInjected.Token(Token = "0x400034B")]
		Soccer = 6001,
		[Cpp2IlInjected.Token(Token = "0x400034C")]
		DEPRECATED_Paddleball = 7000,
		[Cpp2IlInjected.Token(Token = "0x400034D")]
		Paddleball = 7001,
		[Cpp2IlInjected.Token(Token = "0x400034E")]
		DEPRECATED_Dodgeball = 8000,
		[Cpp2IlInjected.Token(Token = "0x400034F")]
		Dodgeball = 8001,
		[Cpp2IlInjected.Token(Token = "0x4000350")]
		DEPRECATED_Lasertag = 9000,
		[Cpp2IlInjected.Token(Token = "0x4000351")]
		Lasertag = 9001,
		[Cpp2IlInjected.Token(Token = "0x4000352")]
		DEPRECATED_Bowling = 10000,
		[Cpp2IlInjected.Token(Token = "0x4000353")]
		Bowling = 10001,
		[Cpp2IlInjected.Token(Token = "0x4000354")]
		StuntRunner_TheMainEvent_A = 11000,
		[Cpp2IlInjected.Token(Token = "0x4000355")]
		StuntRunner_TheMainEvent_B = 11001,
		[Cpp2IlInjected.Token(Token = "0x4000356")]
		StuntRunner_TheMainEvent_C = 11002,
		[Cpp2IlInjected.Token(Token = "0x4000357")]
		StuntRunner_TheMainEvent_D = 11003,
		[Cpp2IlInjected.Token(Token = "0x4000358")]
		StuntRunner_TheMainEvent_S = 11004,
		[Cpp2IlInjected.Token(Token = "0x4000359")]
		StuntRunner_TheMainEvent_X = 11005,
		[Cpp2IlInjected.Token(Token = "0x400035A")]
		StuntRunner_TheMainEvent_Consumable = 11006,
		[Cpp2IlInjected.Token(Token = "0x400035B")]
		StuntRunner_TheMainEvent_SS = 11007,
		[Cpp2IlInjected.Token(Token = "0x400035C")]
		RecRally = 12000,
		[Cpp2IlInjected.Token(Token = "0x400035D")]
		Showdown_A = 12100,
		[Cpp2IlInjected.Token(Token = "0x400035E")]
		Showdown_B = 12101,
		[Cpp2IlInjected.Token(Token = "0x400035F")]
		Showdown_C = 12102,
		[Cpp2IlInjected.Token(Token = "0x4000360")]
		MyLittleMonsters = 12200,
		[Cpp2IlInjected.Token(Token = "0x4000361")]
		RunTheBlock = 12300,
		[Cpp2IlInjected.Token(Token = "0x4000362")]
		RROStorefront_ToBeNamed_2 = 12400,
		[Cpp2IlInjected.Token(Token = "0x4000363")]
		ProgressionEvent = 13000,
		[Cpp2IlInjected.Token(Token = "0x4000364")]
		Store_LaserTag = 100000,
		[Cpp2IlInjected.Token(Token = "0x4000365")]
		Store_RecCenter = 100010,
		[Cpp2IlInjected.Token(Token = "0x4000366")]
		Consumable = 110000,
		[Cpp2IlInjected.Token(Token = "0x4000367")]
		Token = 110100,
		[Cpp2IlInjected.Token(Token = "0x4000368")]
		Punchcard_Challenge_Complete = 110200,
		[Cpp2IlInjected.Token(Token = "0x4000369")]
		All_Punchcard_Challenges_Complete = 110201,
		[Cpp2IlInjected.Token(Token = "0x400036A")]
		New_Player_Checklist_Item_Complete = 110300,
		[Cpp2IlInjected.Token(Token = "0x400036B")]
		Commerce_Purchase = 200000,
		[Cpp2IlInjected.Token(Token = "0x400036C")]
		Gift_Card_Redemption = 210000
	}
	[Cpp2IlInjected.Token(Token = "0x20000C1")]
	public enum GiftRarity
	{
		[Cpp2IlInjected.Token(Token = "0x400036E")]
		None = -1,
		[Cpp2IlInjected.Token(Token = "0x400036F")]
		Common = 0,
		[Cpp2IlInjected.Token(Token = "0x4000370")]
		Uncommon = 10,
		[Cpp2IlInjected.Token(Token = "0x4000371")]
		Rare = 20,
		[Cpp2IlInjected.Token(Token = "0x4000372")]
		Epic = 30,
		[Cpp2IlInjected.Token(Token = "0x4000373")]
		Legendary = 50
	}
	[Cpp2IlInjected.Token(Token = "0x20000C2")]
	public enum UpdateResponseTypes
	{
		[Cpp2IlInjected.Token(Token = "0x4000375")]
		OK,
		[Cpp2IlInjected.Token(Token = "0x4000376")]
		TooManyRequests,
		[Cpp2IlInjected.Token(Token = "0x4000377")]
		NotEnoughCredit,
		[Cpp2IlInjected.Token(Token = "0x4000378")]
		AlreadyOwned,
		[Cpp2IlInjected.Token(Token = "0x4000379")]
		NoItemAvailable,
		[Cpp2IlInjected.Token(Token = "0x400037A")]
		CouponNotApplicable,
		[Cpp2IlInjected.Token(Token = "0x400037B")]
		RequestedPriceDoesNotMatch,
		[Cpp2IlInjected.Token(Token = "0x400037C")]
		RequestedAmountNotAllowed,
		[Cpp2IlInjected.Token(Token = "0x400037D")]
		PlayerNotEligible,
		[Cpp2IlInjected.Token(Token = "0x400037E")]
		RequestCannotBeRefunded,
		[Cpp2IlInjected.Token(Token = "0x400037F")]
		PlayerNotApproved
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x20000C3")]
	[Utf8JsonSerializable]
	public class BalanceResponseDTO : IRecNetUtf8JsonObject
	{
		[Cpp2IlInjected.Token(Token = "0x1700021B")]
		public long Balance
		{
			[Cpp2IlInjected.Token(Token = "0x60004EA")]
			[Cpp2IlInjected.Address(RVA = "0xABD130", Offset = "0xABBF30", VA = "0x180ABD130")]
			[CompilerGenerated]
			get
			{
				return default(long);
			}
			[Cpp2IlInjected.Token(Token = "0x60004EB")]
			[Cpp2IlInjected.Address(RVA = "0xEABA00", Offset = "0xEAA800", VA = "0x180EABA00")]
			[CompilerGenerated]
			internal set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700021C")]
		public CurrencyType CurrencyType
		{
			[Cpp2IlInjected.Token(Token = "0x60004EC")]
			[Cpp2IlInjected.Address(RVA = "0xAC7B20", Offset = "0xAC6920", VA = "0x180AC7B20")]
			[CompilerGenerated]
			get
			{
				return default(CurrencyType);
			}
			[Cpp2IlInjected.Token(Token = "0x60004ED")]
			[Cpp2IlInjected.Address(RVA = "0xACAE40", Offset = "0xAC9C40", VA = "0x180ACAE40")]
			[CompilerGenerated]
			internal set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700021D")]
		[DataMember(Name = "Platform")]
		public StorefrontBalanceType BalanceType
		{
			[Cpp2IlInjected.Token(Token = "0x60004EE")]
			[Cpp2IlInjected.Address(RVA = "0x15FD4F0", Offset = "0x15FC2F0", VA = "0x1815FD4F0")]
			[CompilerGenerated]
			get
			{
				return default(StorefrontBalanceType);
			}
			[Cpp2IlInjected.Token(Token = "0x60004EF")]
			[Cpp2IlInjected.Address(RVA = "0x15FD4E0", Offset = "0x15FC2E0", VA = "0x1815FD4E0")]
			[CompilerGenerated]
			internal set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60004F0")]
		[Cpp2IlInjected.Address(RVA = "0xABE8D0", Offset = "0xABD6D0", VA = "0x180ABE8D0", Slot = "5")]
		public virtual void DNRPRHFLPRB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004F1")]
		[Cpp2IlInjected.Address(RVA = "0xAC4840", Offset = "0xAC3640", VA = "0x180AC4840")]
		public BalanceResponseDTO()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000C4")]
	[Utf8JsonSerializable]
	public class FilteredTextDTO : IRecNetUtf8JsonObject
	{
		[Cpp2IlInjected.Token(Token = "0x1700021E")]
		public string Text
		{
			[Cpp2IlInjected.Token(Token = "0x60004F2")]
			[Cpp2IlInjected.Address(RVA = "0xABD130", Offset = "0xABBF30", VA = "0x180ABD130")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60004F3")]
			[Cpp2IlInjected.Address(RVA = "0xABD120", Offset = "0xABBF20", VA = "0x180ABD120")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700021F")]
		public int NumBadWords
		{
			[Cpp2IlInjected.Token(Token = "0x60004F4")]
			[Cpp2IlInjected.Address(RVA = "0xAC7B20", Offset = "0xAC6920", VA = "0x180AC7B20")]
			[CompilerGenerated]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x60004F5")]
			[Cpp2IlInjected.Address(RVA = "0xACAE40", Offset = "0xAC9C40", VA = "0x180ACAE40")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60004F6")]
		[Cpp2IlInjected.Address(RVA = "0xABE8D0", Offset = "0xABD6D0", VA = "0x180ABE8D0", Slot = "4")]
		public void DNRPRHFLPRB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004F7")]
		[Cpp2IlInjected.Address(RVA = "0xAC4840", Offset = "0xAC3640", VA = "0x180AC4840")]
		public FilteredTextDTO()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000C5")]
	[Utf8JsonSerializable]
	public class TimedRewardTrackDTO : IRecNetUtf8JsonObject
	{
		[Cpp2IlInjected.Token(Token = "0x17000220")]
		public long TrackId
		{
			[Cpp2IlInjected.Token(Token = "0x60004F8")]
			[Cpp2IlInjected.Address(RVA = "0xABD130", Offset = "0xABBF30", VA = "0x180ABD130")]
			[CompilerGenerated]
			get
			{
				return default(long);
			}
			[Cpp2IlInjected.Token(Token = "0x60004F9")]
			[Cpp2IlInjected.Address(RVA = "0xEABA00", Offset = "0xEAA800", VA = "0x180EABA00")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000221")]
		public string Name
		{
			[Cpp2IlInjected.Token(Token = "0x60004FA")]
			[Cpp2IlInjected.Address(RVA = "0xAC0D20", Offset = "0xABFB20", VA = "0x180AC0D20")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60004FB")]
			[Cpp2IlInjected.Address(RVA = "0xAC0D10", Offset = "0xABFB10", VA = "0x180AC0D10")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000222")]
		public DateTime StartTime
		{
			[Cpp2IlInjected.Token(Token = "0x60004FC")]
			[Cpp2IlInjected.Address(RVA = "0xAC1D20", Offset = "0xAC0B20", VA = "0x180AC1D20")]
			[CompilerGenerated]
			get
			{
				return default(DateTime);
			}
			[Cpp2IlInjected.Token(Token = "0x60004FD")]
			[Cpp2IlInjected.Address(RVA = "0xE33D40", Offset = "0xE32B40", VA = "0x180E33D40")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000223")]
		public DateTime EndTime
		{
			[Cpp2IlInjected.Token(Token = "0x60004FE")]
			[Cpp2IlInjected.Address(RVA = "0xAC0F90", Offset = "0xABFD90", VA = "0x180AC0F90")]
			[CompilerGenerated]
			get
			{
				return default(DateTime);
			}
			[Cpp2IlInjected.Token(Token = "0x60004FF")]
			[Cpp2IlInjected.Address(RVA = "0xAC0D00", Offset = "0xABFB00", VA = "0x180AC0D00")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000224")]
		public int RequiredXp
		{
			[Cpp2IlInjected.Token(Token = "0x6000500")]
			[Cpp2IlInjected.Address(RVA = "0xAC6560", Offset = "0xAC5360", VA = "0x180AC6560")]
			[CompilerGenerated]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x6000501")]
			[Cpp2IlInjected.Address(RVA = "0xAC6870", Offset = "0xAC5670", VA = "0x180AC6870")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000225")]
		public int GiftDropId
		{
			[Cpp2IlInjected.Token(Token = "0x6000502")]
			[Cpp2IlInjected.Address(RVA = "0xB0D1F0", Offset = "0xB0BFF0", VA = "0x180B0D1F0")]
			[CompilerGenerated]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x6000503")]
			[Cpp2IlInjected.Address(RVA = "0x16C3590", Offset = "0x16C2390", VA = "0x1816C3590")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000504")]
		[Cpp2IlInjected.Address(RVA = "0xABE8D0", Offset = "0xABD6D0", VA = "0x180ABE8D0", Slot = "4")]
		public void DNRPRHFLPRB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000505")]
		[Cpp2IlInjected.Address(RVA = "0xAC4840", Offset = "0xAC3640", VA = "0x180AC4840")]
		public TimedRewardTrackDTO()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000C6")]
	[Utf8JsonSerializable]
	public class TimedRewardTrackRecordDTO : IRecNetUtf8JsonObject
	{
		[Cpp2IlInjected.Token(Token = "0x17000226")]
		public long TrackId
		{
			[Cpp2IlInjected.Token(Token = "0x6000506")]
			[Cpp2IlInjected.Address(RVA = "0xABD130", Offset = "0xABBF30", VA = "0x180ABD130")]
			[CompilerGenerated]
			get
			{
				return default(long);
			}
			[Cpp2IlInjected.Token(Token = "0x6000507")]
			[Cpp2IlInjected.Address(RVA = "0xEABA00", Offset = "0xEAA800", VA = "0x180EABA00")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000227")]
		public int AccountId
		{
			[Cpp2IlInjected.Token(Token = "0x6000508")]
			[Cpp2IlInjected.Address(RVA = "0xAC7B20", Offset = "0xAC6920", VA = "0x180AC7B20")]
			[CompilerGenerated]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x6000509")]
			[Cpp2IlInjected.Address(RVA = "0xACAE40", Offset = "0xAC9C40", VA = "0x180ACAE40")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000228")]
		public int Xp
		{
			[Cpp2IlInjected.Token(Token = "0x600050A")]
			[Cpp2IlInjected.Address(RVA = "0x15FD4F0", Offset = "0x15FC2F0", VA = "0x1815FD4F0")]
			[CompilerGenerated]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x600050B")]
			[Cpp2IlInjected.Address(RVA = "0x15FD4E0", Offset = "0x15FC2E0", VA = "0x1815FD4E0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600050C")]
		[Cpp2IlInjected.Address(RVA = "0xABE8D0", Offset = "0xABD6D0", VA = "0x180ABE8D0", Slot = "4")]
		public void DNRPRHFLPRB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600050D")]
		[Cpp2IlInjected.Address(RVA = "0xAC4840", Offset = "0xAC3640", VA = "0x180AC4840")]
		public TimedRewardTrackRecordDTO()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000C7")]
	public static class ZZGUTIMJBOP
	{
		[Cpp2IlInjected.Token(Token = "0x20000C8")]
		public enum UgcReportCategory
		{
			[Cpp2IlInjected.Token(Token = "0x400038F")]
			CoC_Discriminatory,
			[Cpp2IlInjected.Token(Token = "0x4000390")]
			CoC_Sexual,
			[Cpp2IlInjected.Token(Token = "0x4000391")]
			CoC_Trolling,
			[Cpp2IlInjected.Token(Token = "0x4000392")]
			Misleading,
			[Cpp2IlInjected.Token(Token = "0x4000393")]
			Other,
			[Cpp2IlInjected.Token(Token = "0x4000394")]
			InappropriateClothing
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000C9")]
	[Utf8JsonSerializable]
	public class AddOrRemovePlayerRoomInventoryRequestDTO : IRecNetUtf8JsonObject
	{
		[Cpp2IlInjected.Token(Token = "0x17000229")]
		public long RoomId
		{
			[Cpp2IlInjected.Token(Token = "0x6000510")]
			[Cpp2IlInjected.Address(RVA = "0xABD130", Offset = "0xABBF30", VA = "0x180ABD130")]
			[CompilerGenerated]
			get
			{
				return default(long);
			}
			[Cpp2IlInjected.Token(Token = "0x6000511")]
			[Cpp2IlInjected.Address(RVA = "0xEABA00", Offset = "0xEAA800", VA = "0x180EABA00")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700022A")]
		public Guid RoomInventoryItemOriginId
		{
			[Cpp2IlInjected.Token(Token = "0x6000512")]
			[Cpp2IlInjected.Address(RVA = "0xBED410", Offset = "0xBEC210", VA = "0x180BED410")]
			[CompilerGenerated]
			get
			{
				return default(Guid);
			}
			[Cpp2IlInjected.Token(Token = "0x6000513")]
			[Cpp2IlInjected.Address(RVA = "0xF76460", Offset = "0xF75260", VA = "0x180F76460")]
			[CompilerGenerated]
			internal set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700022B")]
		public long Quantity
		{
			[Cpp2IlInjected.Token(Token = "0x6000514")]
			[Cpp2IlInjected.Address(RVA = "0xAC0F90", Offset = "0xABFD90", VA = "0x180AC0F90")]
			[CompilerGenerated]
			get
			{
				return default(long);
			}
			[Cpp2IlInjected.Token(Token = "0x6000515")]
			[Cpp2IlInjected.Address(RVA = "0xAC0D00", Offset = "0xABFB00", VA = "0x180AC0D00")]
			[CompilerGenerated]
			internal set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700022C")]
		public ConcurrencyCodePairDTO ConcurrencyCodes
		{
			[Cpp2IlInjected.Token(Token = "0x6000516")]
			[Cpp2IlInjected.Address(RVA = "0xAC0F80", Offset = "0xABFD80", VA = "0x180AC0F80")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000517")]
			[Cpp2IlInjected.Address(RVA = "0xAC8C50", Offset = "0xAC7A50", VA = "0x180AC8C50")]
			[CompilerGenerated]
			internal set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600050E")]
		[Cpp2IlInjected.Address(RVA = "0xAC4840", Offset = "0xAC3640", VA = "0x180AC4840")]
		public AddOrRemovePlayerRoomInventoryRequestDTO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600050F")]
		[Cpp2IlInjected.Address(RVA = "0x7A59010", Offset = "0x7A57E10", VA = "0x187A59010")]
		public AddOrRemovePlayerRoomInventoryRequestDTO(long roomId, Guid roomInventoryItemOriginId, long quantity, ConcurrencyCodePairDTO concurrencyCodes)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000518")]
		[Cpp2IlInjected.Address(RVA = "0x7A58FF0", Offset = "0x7A57DF0", VA = "0x187A58FF0", Slot = "4")]
		public void DNRPRHFLPRB()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000CA")]
	[Utf8JsonSerializable]
	public class AddOrRemovePlayerRoomInventoryItemCountResponseDTO : IRecNetUtf8JsonObject
	{
		[Cpp2IlInjected.Token(Token = "0x1700022D")]
		public PlayerRoomInventoryOperationResult Result
		{
			[Cpp2IlInjected.Token(Token = "0x6000519")]
			[Cpp2IlInjected.Address(RVA = "0xABD110", Offset = "0xABBF10", VA = "0x180ABD110")]
			[CompilerGenerated]
			get
			{
				return default(PlayerRoomInventoryOperationResult);
			}
			[Cpp2IlInjected.Token(Token = "0x600051A")]
			[Cpp2IlInjected.Address(RVA = "0xAC1D40", Offset = "0xAC0B40", VA = "0x180AC1D40")]
			[CompilerGenerated]
			internal set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700022E")]
		public PlayerRoomInventoryItemDTO PlayerRoomInventoryItem
		{
			[Cpp2IlInjected.Token(Token = "0x600051B")]
			[Cpp2IlInjected.Address(RVA = "0xAC0D20", Offset = "0xABFB20", VA = "0x180AC0D20")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600051C")]
			[Cpp2IlInjected.Address(RVA = "0xAC0D10", Offset = "0xABFB10", VA = "0x180AC0D10")]
			[CompilerGenerated]
			internal set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600051D")]
		[Cpp2IlInjected.Address(RVA = "0xAC4840", Offset = "0xAC3640", VA = "0x180AC4840")]
		public AddOrRemovePlayerRoomInventoryItemCountResponseDTO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600051E")]
		[Cpp2IlInjected.Address(RVA = "0x1088910", Offset = "0x1087710", VA = "0x181088910")]
		public AddOrRemovePlayerRoomInventoryItemCountResponseDTO(PlayerRoomInventoryOperationResult result, PlayerRoomInventoryItemDTO playerRoomInventoryItem)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600051F")]
		[Cpp2IlInjected.Address(RVA = "0xABE8D0", Offset = "0xABD6D0", VA = "0x180ABE8D0", Slot = "4")]
		public void DNRPRHFLPRB()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000CB")]
	[Utf8JsonSerializable]
	public class ConcurrencyCodePairDTO : IRecNetUtf8JsonObject
	{
		[Cpp2IlInjected.Token(Token = "0x1700022F")]
		public Guid? CurrentConcurrencyCode
		{
			[Cpp2IlInjected.Token(Token = "0x6000522")]
			[Cpp2IlInjected.Address(RVA = "0x31C93F0", Offset = "0x31C81F0", VA = "0x1831C93F0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000523")]
			[Cpp2IlInjected.Address(RVA = "0x7A5A450", Offset = "0x7A59250", VA = "0x187A5A450")]
			[CompilerGenerated]
			internal set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000230")]
		public Guid NewConcurrencyCode
		{
			[Cpp2IlInjected.Token(Token = "0x6000524")]
			[Cpp2IlInjected.Address(RVA = "0xEA1240", Offset = "0xEA0040", VA = "0x180EA1240")]
			[CompilerGenerated]
			get
			{
				return default(Guid);
			}
			[Cpp2IlInjected.Token(Token = "0x6000525")]
			[Cpp2IlInjected.Address(RVA = "0xEA10C0", Offset = "0xE9FEC0", VA = "0x180EA10C0")]
			[CompilerGenerated]
			internal set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000520")]
		[Cpp2IlInjected.Address(RVA = "0xAC4840", Offset = "0xAC3640", VA = "0x180AC4840")]
		public ConcurrencyCodePairDTO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000521")]
		[Cpp2IlInjected.Address(RVA = "0x7A5A400", Offset = "0x7A59200", VA = "0x187A5A400")]
		public ConcurrencyCodePairDTO(Guid? currentConcurrencyCode, Guid newConcurrencyCodeValue)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000526")]
		[Cpp2IlInjected.Address(RVA = "0xABE8D0", Offset = "0xABD6D0", VA = "0x180ABE8D0", Slot = "4")]
		public void DNRPRHFLPRB()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000CC")]
	[Utf8JsonSerializable]
	public class PlayerRoomInventoryItemDTO : IRecNetUtf8JsonObject
	{
		[Cpp2IlInjected.Token(Token = "0x17000231")]
		public long RoomId
		{
			[Cpp2IlInjected.Token(Token = "0x6000527")]
			[Cpp2IlInjected.Address(RVA = "0xABD130", Offset = "0xABBF30", VA = "0x180ABD130")]
			[CompilerGenerated]
			get
			{
				return default(long);
			}
			[Cpp2IlInjected.Token(Token = "0x6000528")]
			[Cpp2IlInjected.Address(RVA = "0xEABA00", Offset = "0xEAA800", VA = "0x180EABA00")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000232")]
		public Guid RoomInventoryItemOriginId
		{
			[Cpp2IlInjected.Token(Token = "0x6000529")]
			[Cpp2IlInjected.Address(RVA = "0xBED410", Offset = "0xBEC210", VA = "0x180BED410")]
			[CompilerGenerated]
			get
			{
				return default(Guid);
			}
			[Cpp2IlInjected.Token(Token = "0x600052A")]
			[Cpp2IlInjected.Address(RVA = "0xF76460", Offset = "0xF75260", VA = "0x180F76460")]
			[CompilerGenerated]
			internal set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000233")]
		public long Count
		{
			[Cpp2IlInjected.Token(Token = "0x600052B")]
			[Cpp2IlInjected.Address(RVA = "0xAC0F90", Offset = "0xABFD90", VA = "0x180AC0F90")]
			[CompilerGenerated]
			get
			{
				return default(long);
			}
			[Cpp2IlInjected.Token(Token = "0x600052C")]
			[Cpp2IlInjected.Address(RVA = "0xAC0D00", Offset = "0xABFB00", VA = "0x180AC0D00")]
			[CompilerGenerated]
			internal set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000234")]
		public Guid ConcurrencyCode
		{
			[Cpp2IlInjected.Token(Token = "0x600052D")]
			[Cpp2IlInjected.Address(RVA = "0xF782C0", Offset = "0xF770C0", VA = "0x180F782C0")]
			[CompilerGenerated]
			get
			{
				return default(Guid);
			}
			[Cpp2IlInjected.Token(Token = "0x600052E")]
			[Cpp2IlInjected.Address(RVA = "0xF782D0", Offset = "0xF770D0", VA = "0x180F782D0")]
			[CompilerGenerated]
			internal set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000235")]
		public DateTime CreatedAt
		{
			[Cpp2IlInjected.Token(Token = "0x600052F")]
			[Cpp2IlInjected.Address(RVA = "0xAC5120", Offset = "0xAC3F20", VA = "0x180AC5120")]
			[CompilerGenerated]
			get
			{
				return default(DateTime);
			}
			[Cpp2IlInjected.Token(Token = "0x6000530")]
			[Cpp2IlInjected.Address(RVA = "0xFDBAB0", Offset = "0xFDA8B0", VA = "0x180FDBAB0")]
			[CompilerGenerated]
			internal set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000236")]
		public DateTime ModifiedAt
		{
			[Cpp2IlInjected.Token(Token = "0x6000531")]
			[Cpp2IlInjected.Address(RVA = "0xAC0D30", Offset = "0xABFB30", VA = "0x180AC0D30")]
			[CompilerGenerated]
			get
			{
				return default(DateTime);
			}
			[Cpp2IlInjected.Token(Token = "0x6000532")]
			[Cpp2IlInjected.Address(RVA = "0x13EE3C0", Offset = "0x13ED1C0", VA = "0x1813EE3C0")]
			[CompilerGenerated]
			internal set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000533")]
		[Cpp2IlInjected.Address(RVA = "0xABE8D0", Offset = "0xABD6D0", VA = "0x180ABE8D0", Slot = "4")]
		public void DNRPRHFLPRB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000534")]
		[Cpp2IlInjected.Address(RVA = "0xAC4840", Offset = "0xAC3640", VA = "0x180AC4840")]
		public PlayerRoomInventoryItemDTO()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000CD")]
	[Utf8JsonSerializable]
	public class RoomInventoryCreateOrUpdateRequestDTO : IRecNetUtf8JsonObject
	{
		[Cpp2IlInjected.Token(Token = "0x17000237")]
		public string Name
		{
			[Cpp2IlInjected.Token(Token = "0x6000535")]
			[Cpp2IlInjected.Address(RVA = "0xABD130", Offset = "0xABBF30", VA = "0x180ABD130")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000536")]
			[Cpp2IlInjected.Address(RVA = "0xABD120", Offset = "0xABBF20", VA = "0x180ABD120")]
			[CompilerGenerated]
			internal set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000238")]
		public string Description
		{
			[Cpp2IlInjected.Token(Token = "0x6000537")]
			[Cpp2IlInjected.Address(RVA = "0xAC0D20", Offset = "0xABFB20", VA = "0x180AC0D20")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000538")]
			[Cpp2IlInjected.Address(RVA = "0xAC0D10", Offset = "0xABFB10", VA = "0x180AC0D10")]
			[CompilerGenerated]
			internal set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000239")]
		public string ImageName
		{
			[Cpp2IlInjected.Token(Token = "0x6000539")]
			[Cpp2IlInjected.Address(RVA = "0xAC1D20", Offset = "0xAC0B20", VA = "0x180AC1D20")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600053A")]
			[Cpp2IlInjected.Address(RVA = "0xAC0640", Offset = "0xABF440", VA = "0x180AC0640")]
			[CompilerGenerated]
			internal set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700023A")]
		public List<long> TagIds
		{
			[Cpp2IlInjected.Token(Token = "0x600053B")]
			[Cpp2IlInjected.Address(RVA = "0xAC0F90", Offset = "0xABFD90", VA = "0x180AC0F90")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600053C")]
			[Cpp2IlInjected.Address(RVA = "0xAC0650", Offset = "0xABF450", VA = "0x180AC0650")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700023B")]
		public List<RoomInventoryItemTagCreateDTO> NewTags
		{
			[Cpp2IlInjected.Token(Token = "0x600053D")]
			[Cpp2IlInjected.Address(RVA = "0xAC0F80", Offset = "0xABFD80", VA = "0x180AC0F80")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600053E")]
			[Cpp2IlInjected.Address(RVA = "0xAC8C50", Offset = "0xAC7A50", VA = "0x180AC8C50")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700023C")]
		public string Properties
		{
			[Cpp2IlInjected.Token(Token = "0x600053F")]
			[Cpp2IlInjected.Address(RVA = "0xAC0FC0", Offset = "0xABFDC0", VA = "0x180AC0FC0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000540")]
			[Cpp2IlInjected.Address(RVA = "0xAC0CF0", Offset = "0xABFAF0", VA = "0x180AC0CF0")]
			[CompilerGenerated]
			internal set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700023D")]
		public byte? IconShape
		{
			[Cpp2IlInjected.Token(Token = "0x6000541")]
			[Cpp2IlInjected.Address(RVA = "0xEB79C0", Offset = "0xEB67C0", VA = "0x180EB79C0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000542")]
			[Cpp2IlInjected.Address(RVA = "0xEB79D0", Offset = "0xEB67D0", VA = "0x180EB79D0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700023E")]
		public int? IconColor
		{
			[Cpp2IlInjected.Token(Token = "0x6000543")]
			[Cpp2IlInjected.Address(RVA = "0x4AE4FA0", Offset = "0x4AE3DA0", VA = "0x184AE4FA0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000544")]
			[Cpp2IlInjected.Address(RVA = "0x7A5AB10", Offset = "0x7A59910", VA = "0x187A5AB10")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700023F")]
		public Guid? OriginId
		{
			[Cpp2IlInjected.Token(Token = "0x6000545")]
			[Cpp2IlInjected.Address(RVA = "0x7A60560", Offset = "0x7A5F360", VA = "0x187A60560")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000546")]
			[Cpp2IlInjected.Address(RVA = "0x7A60580", Offset = "0x7A5F380", VA = "0x187A60580")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000240")]
		public bool AllowRename
		{
			[Cpp2IlInjected.Token(Token = "0x6000547")]
			[Cpp2IlInjected.Address(RVA = "0xAC50F0", Offset = "0xAC3EF0", VA = "0x180AC50F0")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000548")]
			[Cpp2IlInjected.Address(RVA = "0xAC5100", Offset = "0xAC3F00", VA = "0x180AC5100")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000549")]
		[Cpp2IlInjected.Address(RVA = "0xABE8D0", Offset = "0xABD6D0", VA = "0x180ABE8D0", Slot = "4")]
		public void DNRPRHFLPRB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600054A")]
		[Cpp2IlInjected.Address(RVA = "0xAC4840", Offset = "0xAC3640", VA = "0x180AC4840")]
		public RoomInventoryCreateOrUpdateRequestDTO()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000CE")]
	[Utf8JsonSerializable]
	public class RoomInventoryItemDTO : IRecNetUtf8JsonObject
	{
		[Cpp2IlInjected.Token(Token = "0x17000241")]
		public Guid OriginId
		{
			[Cpp2IlInjected.Token(Token = "0x600054B")]
			[Cpp2IlInjected.Address(RVA = "0xEC6860", Offset = "0xEC5660", VA = "0x180EC6860")]
			[CompilerGenerated]
			get
			{
				return default(Guid);
			}
			[Cpp2IlInjected.Token(Token = "0x600054C")]
			[Cpp2IlInjected.Address(RVA = "0xEC6880", Offset = "0xEC5680", VA = "0x180EC6880")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000242")]
		public long RoomId
		{
			[Cpp2IlInjected.Token(Token = "0x600054D")]
			[Cpp2IlInjected.Address(RVA = "0xAC1D20", Offset = "0xAC0B20", VA = "0x180AC1D20")]
			[CompilerGenerated]
			get
			{
				return default(long);
			}
			[Cpp2IlInjected.Token(Token = "0x600054E")]
			[Cpp2IlInjected.Address(RVA = "0xE33D40", Offset = "0xE32B40", VA = "0x180E33D40")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000243")]
		public string Name
		{
			[Cpp2IlInjected.Token(Token = "0x600054F")]
			[Cpp2IlInjected.Address(RVA = "0xAC0F90", Offset = "0xABFD90", VA = "0x180AC0F90")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000550")]
			[Cpp2IlInjected.Address(RVA = "0xAC0650", Offset = "0xABF450", VA = "0x180AC0650")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000244")]
		public string Description
		{
			[Cpp2IlInjected.Token(Token = "0x6000551")]
			[Cpp2IlInjected.Address(RVA = "0xAC0F80", Offset = "0xABFD80", VA = "0x180AC0F80")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000552")]
			[Cpp2IlInjected.Address(RVA = "0xAC8C50", Offset = "0xAC7A50", VA = "0x180AC8C50")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000245")]
		public string ImageName
		{
			[Cpp2IlInjected.Token(Token = "0x6000553")]
			[Cpp2IlInjected.Address(RVA = "0xAC0FC0", Offset = "0xABFDC0", VA = "0x180AC0FC0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000554")]
			[Cpp2IlInjected.Address(RVA = "0xAC0CF0", Offset = "0xABFAF0", VA = "0x180AC0CF0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000246")]
		public DateTime CreatedAt
		{
			[Cpp2IlInjected.Token(Token = "0x6000555")]
			[Cpp2IlInjected.Address(RVA = "0xAC5120", Offset = "0xAC3F20", VA = "0x180AC5120")]
			[CompilerGenerated]
			get
			{
				return default(DateTime);
			}
			[Cpp2IlInjected.Token(Token = "0x6000556")]
			[Cpp2IlInjected.Address(RVA = "0xFDBAB0", Offset = "0xFDA8B0", VA = "0x180FDBAB0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000247")]
		public DateTime ModifiedAt
		{
			[Cpp2IlInjected.Token(Token = "0x6000557")]
			[Cpp2IlInjected.Address(RVA = "0xAC0D30", Offset = "0xABFB30", VA = "0x180AC0D30")]
			[CompilerGenerated]
			get
			{
				return default(DateTime);
			}
			[Cpp2IlInjected.Token(Token = "0x6000558")]
			[Cpp2IlInjected.Address(RVA = "0x13EE3C0", Offset = "0x13ED1C0", VA = "0x1813EE3C0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000248")]
		public string Properties
		{
			[Cpp2IlInjected.Token(Token = "0x6000559")]
			[Cpp2IlInjected.Address(RVA = "0xAC31E0", Offset = "0xAC1FE0", VA = "0x180AC31E0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600055A")]
			[Cpp2IlInjected.Address(RVA = "0xAC31C0", Offset = "0xAC1FC0", VA = "0x180AC31C0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000249")]
		public List<long> TagIds
		{
			[Cpp2IlInjected.Token(Token = "0x600055B")]
			[Cpp2IlInjected.Address(RVA = "0xAC3430", Offset = "0xAC2230", VA = "0x180AC3430")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600055C")]
			[Cpp2IlInjected.Address(RVA = "0xAC31B0", Offset = "0xAC1FB0", VA = "0x180AC31B0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700024A")]
		public List<RoomInventoryItemTagDTO> NewTags
		{
			[Cpp2IlInjected.Token(Token = "0x600055D")]
			[Cpp2IlInjected.Address(RVA = "0xAC31D0", Offset = "0xAC1FD0", VA = "0x180AC31D0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600055E")]
			[Cpp2IlInjected.Address(RVA = "0xAC3420", Offset = "0xAC2220", VA = "0x180AC3420")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700024B")]
		public byte IconShape
		{
			[Cpp2IlInjected.Token(Token = "0x600055F")]
			[Cpp2IlInjected.Address(RVA = "0xACFCF0", Offset = "0xACEAF0", VA = "0x180ACFCF0")]
			[CompilerGenerated]
			get
			{
				return default(byte);
			}
			[Cpp2IlInjected.Token(Token = "0x6000560")]
			[Cpp2IlInjected.Address(RVA = "0xACF6D0", Offset = "0xACE4D0", VA = "0x180ACF6D0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700024C")]
		public int IconColor
		{
			[Cpp2IlInjected.Token(Token = "0x6000561")]
			[Cpp2IlInjected.Address(RVA = "0xED04E0", Offset = "0xECF2E0", VA = "0x180ED04E0")]
			[CompilerGenerated]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x6000562")]
			[Cpp2IlInjected.Address(RVA = "0x2A1B270", Offset = "0x2A1A070", VA = "0x182A1B270")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000563")]
		[Cpp2IlInjected.Address(RVA = "0xABE8D0", Offset = "0xABD6D0", VA = "0x180ABE8D0", Slot = "4")]
		public void DNRPRHFLPRB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000564")]
		[Cpp2IlInjected.Address(RVA = "0xAC4840", Offset = "0xAC3640", VA = "0x180AC4840")]
		public RoomInventoryItemDTO()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000CF")]
	[Utf8JsonSerializable]
	public class RoomInventoryItemReplicationDTO : RoomInventoryItemDTO
	{
		[Cpp2IlInjected.Token(Token = "0x1700024D")]
		public Guid RoomInventoryItemId
		{
			[Cpp2IlInjected.Token(Token = "0x6000565")]
			[Cpp2IlInjected.Address(RVA = "0x4A19200", Offset = "0x4A18000", VA = "0x184A19200")]
			[CompilerGenerated]
			get
			{
				return default(Guid);
			}
			[Cpp2IlInjected.Token(Token = "0x6000566")]
			[Cpp2IlInjected.Address(RVA = "0x4A18F80", Offset = "0x4A17D80", VA = "0x184A18F80")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000567")]
		[Cpp2IlInjected.Address(RVA = "0xAC4840", Offset = "0xAC3640", VA = "0x180AC4840")]
		public RoomInventoryItemReplicationDTO()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000D0")]
	public enum PlayerRoomInventoryOperationResult
	{
		[Cpp2IlInjected.Token(Token = "0x40003BB")]
		Unknown = -1,
		[Cpp2IlInjected.Token(Token = "0x40003BC")]
		Success,
		[Cpp2IlInjected.Token(Token = "0x40003BD")]
		RoomInventoryItemDoesNotExist,
		[Cpp2IlInjected.Token(Token = "0x40003BE")]
		PlayerDoesNotExist,
		[Cpp2IlInjected.Token(Token = "0x40003BF")]
		RoomDoesNotExist,
		[Cpp2IlInjected.Token(Token = "0x40003C0")]
		RequestQuantityTooLarge,
		[Cpp2IlInjected.Token(Token = "0x40003C1")]
		PlayerHasReachedTheMinimumOwnedAmount,
		[Cpp2IlInjected.Token(Token = "0x40003C2")]
		ConcurrencyCodeMismatch,
		[Cpp2IlInjected.Token(Token = "0x40003C3")]
		InvalidConcurrencyCode
	}
	[Cpp2IlInjected.Token(Token = "0x20000D1")]
	public interface PXBUCELGLKU
	{
		[Cpp2IlInjected.Token(Token = "0x6000568")]
		[Cpp2IlInjected.Address(Slot = "0")]
		Task<RecNetResult<RoomInventoryItemDTO>> ZYJMDEKIYJJ(Guid? a, long b, string c, string d, string e, string f, byte g, int h, [Optional] List<long> i, [Optional] List<RoomInventoryItemTagDTO> j, bool k = false, [Optional] CancellationToken l);

		[Cpp2IlInjected.Token(Token = "0x6000569")]
		[Cpp2IlInjected.Address(Slot = "1")]
		Task<RecNetResult<RoomInventoryItemDTO>> DRSFXLWCULC(Guid a, long b, [Optional] string c, [Optional] string d, [Optional] string e, [Optional] List<long> f, [Optional] Dictionary<string, string> g, [Optional] string h, [Optional] byte? i, [Optional] int? j, [Optional] CancellationToken k);

		[Cpp2IlInjected.Token(Token = "0x600056A")]
		[Cpp2IlInjected.Address(Slot = "2")]
		Task<RecNetResult> CMCKCEOYPUW(Guid a, long b, [Optional] CancellationToken c);

		[Cpp2IlInjected.Token(Token = "0x600056B")]
		[Cpp2IlInjected.Address(Slot = "3")]
		Task<List<RoomInventoryItemDTO>> LSPDVVCDCGW(long a, [Optional] CancellationToken b);

		[Cpp2IlInjected.Token(Token = "0x600056C")]
		[Cpp2IlInjected.Address(Slot = "4")]
		Task<List<PlayerRoomInventoryItemDTO>> DMWPQMKOMYX(long a, [Optional] CancellationToken b);

		[Cpp2IlInjected.Token(Token = "0x600056D")]
		[Cpp2IlInjected.Address(Slot = "5")]
		Task<List<AddOrRemovePlayerRoomInventoryItemCountResponseDTO>> RMUXUFGFRHH(long a, List<AddOrRemovePlayerRoomInventoryRequestDTO> b, [Optional] CancellationToken c);
	}
	[Cpp2IlInjected.Token(Token = "0x20000D2")]
	[Utf8JsonSerializable]
	public class RoomInventoryItemTagCreateDTO : IRecNetUtf8JsonObject
	{
		[Cpp2IlInjected.Token(Token = "0x1700024E")]
		public string Name
		{
			[Cpp2IlInjected.Token(Token = "0x600056E")]
			[Cpp2IlInjected.Address(RVA = "0xABD130", Offset = "0xABBF30", VA = "0x180ABD130")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600056F")]
			[Cpp2IlInjected.Address(RVA = "0xABD120", Offset = "0xABBF20", VA = "0x180ABD120")]
			[CompilerGenerated]
			internal set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700024F")]
		public string Properties
		{
			[Cpp2IlInjected.Token(Token = "0x6000570")]
			[Cpp2IlInjected.Address(RVA = "0xAC0D20", Offset = "0xABFB20", VA = "0x180AC0D20")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000571")]
			[Cpp2IlInjected.Address(RVA = "0xAC0D10", Offset = "0xABFB10", VA = "0x180AC0D10")]
			[CompilerGenerated]
			internal set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000572")]
		[Cpp2IlInjected.Address(RVA = "0xABE8D0", Offset = "0xABD6D0", VA = "0x180ABE8D0", Slot = "4")]
		public void DNRPRHFLPRB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000573")]
		[Cpp2IlInjected.Address(RVA = "0xAC4840", Offset = "0xAC3640", VA = "0x180AC4840")]
		public RoomInventoryItemTagCreateDTO()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000D3")]
	[Utf8JsonSerializable]
	public class RoomInventoryItemTagDTO : IRecNetUtf8JsonObject
	{
		[Cpp2IlInjected.Token(Token = "0x17000250")]
		public long TagId
		{
			[Cpp2IlInjected.Token(Token = "0x6000574")]
			[Cpp2IlInjected.Address(RVA = "0xABD130", Offset = "0xABBF30", VA = "0x180ABD130")]
			[CompilerGenerated]
			get
			{
				return default(long);
			}
			[Cpp2IlInjected.Token(Token = "0x6000575")]
			[Cpp2IlInjected.Address(RVA = "0xEABA00", Offset = "0xEAA800", VA = "0x180EABA00")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000251")]
		public string Name
		{
			[Cpp2IlInjected.Token(Token = "0x6000576")]
			[Cpp2IlInjected.Address(RVA = "0xAC0D20", Offset = "0xABFB20", VA = "0x180AC0D20")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000577")]
			[Cpp2IlInjected.Address(RVA = "0xAC0D10", Offset = "0xABFB10", VA = "0x180AC0D10")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000252")]
		public string Properties
		{
			[Cpp2IlInjected.Token(Token = "0x6000578")]
			[Cpp2IlInjected.Address(RVA = "0xAC1D20", Offset = "0xAC0B20", VA = "0x180AC1D20")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000579")]
			[Cpp2IlInjected.Address(RVA = "0xAC0640", Offset = "0xABF440", VA = "0x180AC0640")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600057A")]
		[Cpp2IlInjected.Address(RVA = "0xABE8D0", Offset = "0xABD6D0", VA = "0x180ABE8D0", Slot = "4")]
		public void DNRPRHFLPRB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600057B")]
		[Cpp2IlInjected.Address(RVA = "0xAC4840", Offset = "0xAC3640", VA = "0x180AC4840")]
		public RoomInventoryItemTagDTO()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000D4")]
	[Utf8JsonSerializable]
	public class RoomInventoryItemTagUpdateDTO : IRecNetUtf8JsonObject
	{
		[Cpp2IlInjected.Token(Token = "0x17000253")]
		public long TagId
		{
			[Cpp2IlInjected.Token(Token = "0x600057D")]
			[Cpp2IlInjected.Address(RVA = "0xABD130", Offset = "0xABBF30", VA = "0x180ABD130")]
			[CompilerGenerated]
			get
			{
				return default(long);
			}
			[Cpp2IlInjected.Token(Token = "0x600057E")]
			[Cpp2IlInjected.Address(RVA = "0xEABA00", Offset = "0xEAA800", VA = "0x180EABA00")]
			[CompilerGenerated]
			internal set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000254")]
		public string Properties
		{
			[Cpp2IlInjected.Token(Token = "0x600057F")]
			[Cpp2IlInjected.Address(RVA = "0xAC0D20", Offset = "0xABFB20", VA = "0x180AC0D20")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000580")]
			[Cpp2IlInjected.Address(RVA = "0xAC0D10", Offset = "0xABFB10", VA = "0x180AC0D10")]
			[CompilerGenerated]
			internal set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600057C")]
		[Cpp2IlInjected.Address(RVA = "0x1CC1A50", Offset = "0x1CC0850", VA = "0x181CC1A50")]
		public RoomInventoryItemTagUpdateDTO(long tagId, string properties)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000581")]
		[Cpp2IlInjected.Address(RVA = "0xABE8D0", Offset = "0xABD6D0", VA = "0x180ABE8D0", Slot = "4")]
		public void DNRPRHFLPRB()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000D5")]
	public interface QTZXSRBVNYR
	{
		[Cpp2IlInjected.Token(Token = "0x6000582")]
		[Cpp2IlInjected.Address(Slot = "0")]
		Task<RecNetResult<List<RoomInventoryItemTagDTO>>> LJINTYAAGVP(long a, List<RoomInventoryItemTagUpdateDTO> b, [Optional] CancellationToken c);

		[Cpp2IlInjected.Token(Token = "0x6000583")]
		[Cpp2IlInjected.Address(Slot = "1")]
		Task<RecNetResult> YBUPMRCIXHQ(long a, [Optional] CancellationToken b);

		[Cpp2IlInjected.Token(Token = "0x6000584")]
		[Cpp2IlInjected.Address(Slot = "2")]
		Task<List<RoomInventoryItemTagDTO>> WSFMLZORLQA(long a, [Optional] CancellationToken b);
	}
	[Cpp2IlInjected.Token(Token = "0x20000D6")]
	[Utf8JsonSerializable]
	public class RoomOfferIdentifier : UGCPurchasableIdentifier, IEquatable<RoomOfferIdentifier>
	{
		[Cpp2IlInjected.Token(Token = "0x6000585")]
		[Cpp2IlInjected.Address(RVA = "0x7A60630", Offset = "0x7A5F430", VA = "0x187A60630", Slot = "7")]
		public bool Equals(RoomOfferIdentifier other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000586")]
		[Cpp2IlInjected.Address(RVA = "0x7A605C0", Offset = "0x7A5F3C0", VA = "0x187A605C0", Slot = "6")]
		public override UGCPurchasableIdentifier Clone()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000587")]
		[Cpp2IlInjected.Address(RVA = "0xAC4840", Offset = "0xAC3640", VA = "0x180AC4840")]
		public RoomOfferIdentifier()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000D7")]
	public static class QQYAMDXBWBJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000588")]
		[Cpp2IlInjected.Address(RVA = "0x7A5FC60", Offset = "0x7A5EA60", VA = "0x187A5FC60")]
		public static RoomOfferIdentifier BLVAROODRXK(this RoomOffer a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000589")]
		[Cpp2IlInjected.Address(RVA = "0x7A5FCD0", Offset = "0x7A5EAD0", VA = "0x187A5FCD0")]
		public static RoomOfferIdentifier JVVTESJDXCW(string a)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000D8")]
	[Utf8JsonSerializable]
	public class RoomOffer : IRecNetUtf8JsonObject
	{
		[Cpp2IlInjected.Token(Token = "0x40003CB")]
		public const int MIN_NAME_LENGTH = 3;

		[Cpp2IlInjected.Token(Token = "0x40003CC")]
		public const int MAX_NAME_LENGTH = 40;

		[Cpp2IlInjected.Token(Token = "0x40003CD")]
		public const int MAX_DESCRIPTION_LENGTH = 180;

		[Cpp2IlInjected.Token(Token = "0x40003CE")]
		public const int MAX_OFFERS_COUNT_PER_ROOM = 1000;

		[Cpp2IlInjected.Token(Token = "0x40003CF")]
		public const int MAX_OFFER_INVENTORY_ITEM_COUNT = 99999;

		[Cpp2IlInjected.Token(Token = "0x40003D0")]
		public const int MAX_OFFER_UNIQUE_INVENTORY_ITEM_COUNT = 8;

		[Cpp2IlInjected.Token(Token = "0x40003D1")]
		public const int MIN_PRICE = 1;

		[Cpp2IlInjected.Token(Token = "0x40003D2")]
		public const int MAX_PRICE = 1000000000;

		[Cpp2IlInjected.Token(Token = "0x40003D3")]
		public const int MAX_CHECKOUT_QUANTITY = 9999;

		[Cpp2IlInjected.Token(Token = "0x40003D4")]
		public const int DEFAULT_MINIMUM_DYNAMIC_PRICE = 1;

		[Cpp2IlInjected.Token(Token = "0x40003D5")]
		public const int DEFAULT_MAXIMUM_DYNAMIC_PRICE = 1000000000;

		[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
		[Cpp2IlInjected.Token(Token = "0x40003E6")]
		[IgnoreDataMember]
		private IReadOnlyDictionary<Guid, int>? CIHQPCJPLDD;

		[Cpp2IlInjected.Token(Token = "0x17000255")]
		public Guid OriginId
		{
			[Cpp2IlInjected.Token(Token = "0x600058A")]
			[Cpp2IlInjected.Address(RVA = "0xEC6860", Offset = "0xEC5660", VA = "0x180EC6860")]
			[CompilerGenerated]
			get
			{
				return default(Guid);
			}
			[Cpp2IlInjected.Token(Token = "0x600058B")]
			[Cpp2IlInjected.Address(RVA = "0xEC6880", Offset = "0xEC5680", VA = "0x180EC6880")]
			[CompilerGenerated]
			internal set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000256")]
		public long RoomId
		{
			[Cpp2IlInjected.Token(Token = "0x600058C")]
			[Cpp2IlInjected.Address(RVA = "0xAC1D20", Offset = "0xAC0B20", VA = "0x180AC1D20")]
			[CompilerGenerated]
			get
			{
				return default(long);
			}
			[Cpp2IlInjected.Token(Token = "0x600058D")]
			[Cpp2IlInjected.Address(RVA = "0xE33D40", Offset = "0xE32B40", VA = "0x180E33D40")]
			[CompilerGenerated]
			internal set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000257")]
		public string Name
		{
			[Cpp2IlInjected.Token(Token = "0x600058E")]
			[Cpp2IlInjected.Address(RVA = "0xAC0F90", Offset = "0xABFD90", VA = "0x180AC0F90")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600058F")]
			[Cpp2IlInjected.Address(RVA = "0xAC0650", Offset = "0xABF450", VA = "0x180AC0650")]
			[CompilerGenerated]
			internal set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000258")]
		public string? Description
		{
			[Cpp2IlInjected.Token(Token = "0x6000590")]
			[Cpp2IlInjected.Address(RVA = "0xAC0F80", Offset = "0xABFD80", VA = "0x180AC0F80")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000591")]
			[Cpp2IlInjected.Address(RVA = "0xAC8C50", Offset = "0xAC7A50", VA = "0x180AC8C50")]
			[CompilerGenerated]
			internal set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000259")]
		public string? ImageName
		{
			[Cpp2IlInjected.Token(Token = "0x6000592")]
			[Cpp2IlInjected.Address(RVA = "0xAC0FC0", Offset = "0xABFDC0", VA = "0x180AC0FC0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000593")]
			[Cpp2IlInjected.Address(RVA = "0xAC0CF0", Offset = "0xABFAF0", VA = "0x180AC0CF0")]
			[CompilerGenerated]
			internal set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700025A")]
		public int Price
		{
			[Cpp2IlInjected.Token(Token = "0x6000594")]
			[Cpp2IlInjected.Address(RVA = "0xADBF60", Offset = "0xADAD60", VA = "0x180ADBF60")]
			[CompilerGenerated]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x6000595")]
			[Cpp2IlInjected.Address(RVA = "0xB3EC20", Offset = "0xB3DA20", VA = "0x180B3EC20")]
			[CompilerGenerated]
			internal set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700025B")]
		public bool HasDynamicPrice
		{
			[Cpp2IlInjected.Token(Token = "0x6000596")]
			[Cpp2IlInjected.Address(RVA = "0x19B7770", Offset = "0x19B6570", VA = "0x1819B7770")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000597")]
			[Cpp2IlInjected.Address(RVA = "0x19B7760", Offset = "0x19B6560", VA = "0x1819B7760")]
			[CompilerGenerated]
			internal set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700025C")]
		internal int? DYOOMYVDFSD
		{
			[Cpp2IlInjected.Token(Token = "0x6000598")]
			[Cpp2IlInjected.Address(RVA = "0xAC0D30", Offset = "0xABFB30", VA = "0x180AC0D30")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000599")]
			[Cpp2IlInjected.Address(RVA = "0x13EE3C0", Offset = "0x13ED1C0", VA = "0x1813EE3C0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700025D")]
		[IgnoreDataMember]
		public int MinDynamicPrice
		{
			[Cpp2IlInjected.Token(Token = "0x600059A")]
			[Cpp2IlInjected.Address(RVA = "0x7A60E50", Offset = "0x7A5FC50", VA = "0x187A60E50")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700025E")]
		internal int? KYYCICSMMAB
		{
			[Cpp2IlInjected.Token(Token = "0x600059B")]
			[Cpp2IlInjected.Address(RVA = "0xAC31E0", Offset = "0xAC1FE0", VA = "0x180AC31E0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600059C")]
			[Cpp2IlInjected.Address(RVA = "0xFDBE00", Offset = "0xFDAC00", VA = "0x180FDBE00")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700025F")]
		[IgnoreDataMember]
		public int MaxDynamicPrice
		{
			[Cpp2IlInjected.Token(Token = "0x600059D")]
			[Cpp2IlInjected.Address(RVA = "0x7A60E00", Offset = "0x7A5FC00", VA = "0x187A60E00")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000260")]
		public Guid? PriceUnitOriginId
		{
			[Cpp2IlInjected.Token(Token = "0x600059E")]
			[Cpp2IlInjected.Address(RVA = "0x7A60590", Offset = "0x7A5F390", VA = "0x187A60590")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600059F")]
			[Cpp2IlInjected.Address(RVA = "0x7A605B0", Offset = "0x7A5F3B0", VA = "0x187A605B0")]
			[CompilerGenerated]
			internal set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000261")]
		public int Version
		{
			[Cpp2IlInjected.Token(Token = "0x60005A0")]
			[Cpp2IlInjected.Address(RVA = "0xED04E0", Offset = "0xECF2E0", VA = "0x180ED04E0")]
			[CompilerGenerated]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x60005A1")]
			[Cpp2IlInjected.Address(RVA = "0x2A1B270", Offset = "0x2A1A070", VA = "0x182A1B270")]
			[CompilerGenerated]
			internal set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000262")]
		public int? MaxNumPurchasesPerPlayer
		{
			[Cpp2IlInjected.Token(Token = "0x60005A2")]
			[Cpp2IlInjected.Address(RVA = "0xAC50D0", Offset = "0xAC3ED0", VA = "0x180AC50D0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60005A3")]
			[Cpp2IlInjected.Address(RVA = "0xFF2C50", Offset = "0xFF1A50", VA = "0x180FF2C50")]
			[CompilerGenerated]
			internal set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000263")]
		public int? MaxCountPerPurchase
		{
			[Cpp2IlInjected.Token(Token = "0x60005A4")]
			[Cpp2IlInjected.Address(RVA = "0xAC8150", Offset = "0xAC6F50", VA = "0x180AC8150")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60005A5")]
			[Cpp2IlInjected.Address(RVA = "0xFF2C40", Offset = "0xFF1A40", VA = "0x180FF2C40")]
			[CompilerGenerated]
			internal set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000264")]
		public IReadOnlyList<RoomOfferItemMappingDTO> ItemMappings
		{
			[Cpp2IlInjected.Token(Token = "0x60005A6")]
			[Cpp2IlInjected.Address(RVA = "0xAC7AA0", Offset = "0xAC68A0", VA = "0x180AC7AA0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60005A7")]
			[Cpp2IlInjected.Address(RVA = "0xAC8140", Offset = "0xAC6F40", VA = "0x180AC8140")]
			[CompilerGenerated]
			internal set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000265")]
		public DateTime CreatedAt
		{
			[Cpp2IlInjected.Token(Token = "0x60005A8")]
			[Cpp2IlInjected.Address(RVA = "0xAC7B00", Offset = "0xAC6900", VA = "0x180AC7B00")]
			[CompilerGenerated]
			get
			{
				return default(DateTime);
			}
			[Cpp2IlInjected.Token(Token = "0x60005A9")]
			[Cpp2IlInjected.Address(RVA = "0x52EE050", Offset = "0x52ECE50", VA = "0x1852EE050")]
			[CompilerGenerated]
			internal set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000266")]
		public DateTime ModifiedAt
		{
			[Cpp2IlInjected.Token(Token = "0x60005AA")]
			[Cpp2IlInjected.Address(RVA = "0xAEDD70", Offset = "0xAECB70", VA = "0x180AEDD70")]
			[CompilerGenerated]
			get
			{
				return default(DateTime);
			}
			[Cpp2IlInjected.Token(Token = "0x60005AB")]
			[Cpp2IlInjected.Address(RVA = "0x2A242C0", Offset = "0x2A230C0", VA = "0x182A242C0")]
			[CompilerGenerated]
			internal set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000267")]
		[IgnoreDataMember]
		public RoomOfferType RoomOfferType
		{
			[Cpp2IlInjected.Token(Token = "0x60005AD")]
			[Cpp2IlInjected.Address(RVA = "0x7A60F20", Offset = "0x7A5FD20", VA = "0x187A60F20")]
			get
			{
				return default(RoomOfferType);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000268")]
		[IgnoreDataMember]
		public IReadOnlyDictionary<Guid, int> InventoryItemMappings
		{
			[Cpp2IlInjected.Token(Token = "0x60005AE")]
			[Cpp2IlInjected.Address(RVA = "0x7A60DA0", Offset = "0x7A5FBA0", VA = "0x187A60DA0")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60005AF")]
			[Cpp2IlInjected.Address(RVA = "0xAC7AB0", Offset = "0xAC68B0", VA = "0x180AC7AB0")]
			internal set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000269")]
		[IgnoreDataMember]
		public string? LocalOverrideImageName
		{
			[Cpp2IlInjected.Token(Token = "0x60005B0")]
			[Cpp2IlInjected.Address(RVA = "0xB882D0", Offset = "0xB870D0", VA = "0x180B882D0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60005B1")]
			[Cpp2IlInjected.Address(RVA = "0xB88330", Offset = "0xB87130", VA = "0x180B88330")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700026A")]
		[IgnoreDataMember]
		public bool HasLocalOverrideImage
		{
			[Cpp2IlInjected.Token(Token = "0x60005B2")]
			[Cpp2IlInjected.Address(RVA = "0x7A60D20", Offset = "0x7A5FB20", VA = "0x187A60D20")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700026B")]
		[IgnoreDataMember]
		public string? LocalOverrideDescription
		{
			[Cpp2IlInjected.Token(Token = "0x60005B3")]
			[Cpp2IlInjected.Address(RVA = "0xAC7160", Offset = "0xAC5F60", VA = "0x180AC7160")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60005B4")]
			[Cpp2IlInjected.Address(RVA = "0xAC7450", Offset = "0xAC6250", VA = "0x180AC7450")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700026C")]
		[IgnoreDataMember]
		public bool HasLocalOverrideDescription
		{
			[Cpp2IlInjected.Token(Token = "0x60005B5")]
			[Cpp2IlInjected.Address(RVA = "0x7A60D00", Offset = "0x7A5FB00", VA = "0x187A60D00")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700026D")]
		[IgnoreDataMember]
		public int? LocalOverridePrice
		{
			[Cpp2IlInjected.Token(Token = "0x60005B6")]
			[Cpp2IlInjected.Address(RVA = "0xB88130", Offset = "0xB86F30", VA = "0x180B88130")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60005B7")]
			[Cpp2IlInjected.Address(RVA = "0x1CC70E0", Offset = "0x1CC5EE0", VA = "0x181CC70E0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700026E")]
		[IgnoreDataMember]
		public bool HasLocalOverridePrice
		{
			[Cpp2IlInjected.Token(Token = "0x60005B8")]
			[Cpp2IlInjected.Address(RVA = "0x7A60D60", Offset = "0x7A5FB60", VA = "0x187A60D60")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700026F")]
		[IgnoreDataMember]
		public int PurchasablePrice
		{
			[Cpp2IlInjected.Token(Token = "0x60005B9")]
			[Cpp2IlInjected.Address(RVA = "0x7A60EA0", Offset = "0x7A5FCA0", VA = "0x187A60EA0")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000270")]
		[IgnoreDataMember]
		public string? LocalOverrideName
		{
			[Cpp2IlInjected.Token(Token = "0x60005BA")]
			[Cpp2IlInjected.Address(RVA = "0xEF42F0", Offset = "0xEF30F0", VA = "0x180EF42F0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60005BB")]
			[Cpp2IlInjected.Address(RVA = "0x151C850", Offset = "0x151B650", VA = "0x18151C850")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000271")]
		[IgnoreDataMember]
		public bool HasLocalOverrideName
		{
			[Cpp2IlInjected.Token(Token = "0x60005BC")]
			[Cpp2IlInjected.Address(RVA = "0x7A60D40", Offset = "0x7A5FB40", VA = "0x187A60D40")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60005AC")]
		[Cpp2IlInjected.Address(RVA = "0x7A60880", Offset = "0x7A5F680", VA = "0x187A60880", Slot = "4")]
		public void DNRPRHFLPRB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005BD")]
		[Cpp2IlInjected.Address(RVA = "0xAC4840", Offset = "0xAC3640", VA = "0x180AC4840")]
		public RoomOffer()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005BE")]
		[Cpp2IlInjected.Address(RVA = "0x7A60BF0", Offset = "0x7A5F9F0", VA = "0x187A60BF0")]
		public RoomOffer(Guid originId, long roomId, string name, string description, string imageName, int price, bool hasDynamicPrice, int? minimumDynamicPrice, int? maximumDynamicPrice, int? maxNumPurchasesPerPlayer, int? maxCountPerPurchase, List<RoomOfferItemMappingDTO> itemMappings, [Optional] DateTime createdAt, [Optional] DateTime modifiedAt, [Optional] Guid? priceUnitOriginId)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005BF")]
		[Cpp2IlInjected.Address(RVA = "0x7A60B80", Offset = "0x7A5F980", VA = "0x187A60B80")]
		private RoomOfferType YAXQIZTWSUA()
		{
			return default(RoomOfferType);
		}

		[Cpp2IlInjected.Token(Token = "0x60005C0")]
		[Cpp2IlInjected.Address(RVA = "0x7A60890", Offset = "0x7A5F690", VA = "0x187A60890")]
		private Dictionary<Guid, int> PQWTUKJZLRR(IReadOnlyList<RoomOfferItemMappingDTO> a)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000D9")]
	[Utf8JsonSerializable]
	public class RoomOfferIdDTO : IRecNetUtf8JsonObject
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40003EB")]
		public Guid OriginId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40003EC")]
		public long RoomId;

		[Cpp2IlInjected.Token(Token = "0x60005C1")]
		[Cpp2IlInjected.Address(RVA = "0xABE8D0", Offset = "0xABD6D0", VA = "0x180ABE8D0", Slot = "4")]
		public void DNRPRHFLPRB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005C2")]
		[Cpp2IlInjected.Address(RVA = "0xAC4840", Offset = "0xAC3640", VA = "0x180AC4840")]
		public RoomOfferIdDTO()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000DA")]
	[Utf8JsonSerializable]
	public class RoomOfferReplicationDTO : RoomOffer
	{
		[Cpp2IlInjected.Token(Token = "0x17000272")]
		public Guid RoomOfferId
		{
			[Cpp2IlInjected.Token(Token = "0x60005C3")]
			[Cpp2IlInjected.Address(RVA = "0x12B3550", Offset = "0x12B2350", VA = "0x1812B3550")]
			[CompilerGenerated]
			get
			{
				return default(Guid);
			}
			[Cpp2IlInjected.Token(Token = "0x60005C4")]
			[Cpp2IlInjected.Address(RVA = "0x7A60870", Offset = "0x7A5F670", VA = "0x187A60870")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000273")]
		public Guid? PriceUnitId
		{
			[Cpp2IlInjected.Token(Token = "0x60005C5")]
			[Cpp2IlInjected.Address(RVA = "0x7A60830", Offset = "0x7A5F630", VA = "0x187A60830")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60005C6")]
			[Cpp2IlInjected.Address(RVA = "0x7A60850", Offset = "0x7A5F650", VA = "0x187A60850")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60005C7")]
		[Cpp2IlInjected.Address(RVA = "0xAC4840", Offset = "0xAC3640", VA = "0x180AC4840")]
		public RoomOfferReplicationDTO()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000DB")]
	[Utf8JsonSerializable]
	public class RoomOfferCreateOrUpdateRequestDTO : IRecNetUtf8JsonObject
	{
		[Cpp2IlInjected.Token(Token = "0x17000274")]
		public string Name
		{
			[Cpp2IlInjected.Token(Token = "0x60005C8")]
			[Cpp2IlInjected.Address(RVA = "0xABD130", Offset = "0xABBF30", VA = "0x180ABD130")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60005C9")]
			[Cpp2IlInjected.Address(RVA = "0xABD120", Offset = "0xABBF20", VA = "0x180ABD120")]
			[CompilerGenerated]
			internal set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000275")]
		public string? Description
		{
			[Cpp2IlInjected.Token(Token = "0x60005CA")]
			[Cpp2IlInjected.Address(RVA = "0xAC0D20", Offset = "0xABFB20", VA = "0x180AC0D20")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60005CB")]
			[Cpp2IlInjected.Address(RVA = "0xAC0D10", Offset = "0xABFB10", VA = "0x180AC0D10")]
			[CompilerGenerated]
			internal set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000276")]
		public string? ImageName
		{
			[Cpp2IlInjected.Token(Token = "0x60005CC")]
			[Cpp2IlInjected.Address(RVA = "0xAC1D20", Offset = "0xAC0B20", VA = "0x180AC1D20")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60005CD")]
			[Cpp2IlInjected.Address(RVA = "0xAC0640", Offset = "0xABF440", VA = "0x180AC0640")]
			[CompilerGenerated]
			internal set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000277")]
		public int Price
		{
			[Cpp2IlInjected.Token(Token = "0x60005CE")]
			[Cpp2IlInjected.Address(RVA = "0xAC2060", Offset = "0xAC0E60", VA = "0x180AC2060")]
			[CompilerGenerated]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x60005CF")]
			[Cpp2IlInjected.Address(RVA = "0xAC1D30", Offset = "0xAC0B30", VA = "0x180AC1D30")]
			[CompilerGenerated]
			internal set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000278")]
		public bool HasDynamicPrice
		{
			[Cpp2IlInjected.Token(Token = "0x60005D0")]
			[Cpp2IlInjected.Address(RVA = "0x1ADD440", Offset = "0x1ADC240", VA = "0x181ADD440")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x60005D1")]
			[Cpp2IlInjected.Address(RVA = "0x10AC4A0", Offset = "0x10AB2A0", VA = "0x1810AC4A0")]
			[CompilerGenerated]
			internal set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000279")]
		public int? MinimumDynamicPrice
		{
			[Cpp2IlInjected.Token(Token = "0x60005D2")]
			[Cpp2IlInjected.Address(RVA = "0xAC0F80", Offset = "0xABFD80", VA = "0x180AC0F80")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60005D3")]
			[Cpp2IlInjected.Address(RVA = "0xAC0FA0", Offset = "0xABFDA0", VA = "0x180AC0FA0")]
			[CompilerGenerated]
			internal set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700027A")]
		public int? MaximumDynamicPrice
		{
			[Cpp2IlInjected.Token(Token = "0x60005D4")]
			[Cpp2IlInjected.Address(RVA = "0xAC0FC0", Offset = "0xABFDC0", VA = "0x180AC0FC0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60005D5")]
			[Cpp2IlInjected.Address(RVA = "0xAC6570", Offset = "0xAC5370", VA = "0x180AC6570")]
			[CompilerGenerated]
			internal set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700027B")]
		public int? MaxNumPurchasesPerPlayer
		{
			[Cpp2IlInjected.Token(Token = "0x60005D6")]
			[Cpp2IlInjected.Address(RVA = "0xAC5120", Offset = "0xAC3F20", VA = "0x180AC5120")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60005D7")]
			[Cpp2IlInjected.Address(RVA = "0xFDBAB0", Offset = "0xFDA8B0", VA = "0x180FDBAB0")]
			[CompilerGenerated]
			internal set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700027C")]
		public int? MaxCountPerPurchase
		{
			[Cpp2IlInjected.Token(Token = "0x60005D8")]
			[Cpp2IlInjected.Address(RVA = "0xAC0D30", Offset = "0xABFB30", VA = "0x180AC0D30")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60005D9")]
			[Cpp2IlInjected.Address(RVA = "0x13EE3C0", Offset = "0x13ED1C0", VA = "0x1813EE3C0")]
			[CompilerGenerated]
			internal set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700027D")]
		public List<RoomOfferItemMappingDTO> ItemMappings
		{
			[Cpp2IlInjected.Token(Token = "0x60005DA")]
			[Cpp2IlInjected.Address(RVA = "0xAC31E0", Offset = "0xAC1FE0", VA = "0x180AC31E0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60005DB")]
			[Cpp2IlInjected.Address(RVA = "0xAC31C0", Offset = "0xAC1FC0", VA = "0x180AC31C0")]
			[CompilerGenerated]
			internal set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700027E")]
		public Guid? PriceUnitId
		{
			[Cpp2IlInjected.Token(Token = "0x60005DC")]
			[Cpp2IlInjected.Address(RVA = "0x7A60590", Offset = "0x7A5F390", VA = "0x187A60590")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60005DD")]
			[Cpp2IlInjected.Address(RVA = "0x7A605B0", Offset = "0x7A5F3B0", VA = "0x187A605B0")]
			[CompilerGenerated]
			internal set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700027F")]
		public Guid? OriginId
		{
			[Cpp2IlInjected.Token(Token = "0x60005DE")]
			[Cpp2IlInjected.Address(RVA = "0x4A2EBE0", Offset = "0x4A2D9E0", VA = "0x184A2EBE0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60005DF")]
			[Cpp2IlInjected.Address(RVA = "0x4A2EB50", Offset = "0x4A2D950", VA = "0x184A2EB50")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000280")]
		public bool AllowRename
		{
			[Cpp2IlInjected.Token(Token = "0x60005E0")]
			[Cpp2IlInjected.Address(RVA = "0xD5E570", Offset = "0xD5D370", VA = "0x180D5E570")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x60005E1")]
			[Cpp2IlInjected.Address(RVA = "0xDCFC00", Offset = "0xDCEA00", VA = "0x180DCFC00")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60005E2")]
		[Cpp2IlInjected.Address(RVA = "0x7A5A460", Offset = "0x7A59260", VA = "0x187A5A460", Slot = "4")]
		public void DNRPRHFLPRB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005E3")]
		[Cpp2IlInjected.Address(RVA = "0xAC4840", Offset = "0xAC3640", VA = "0x180AC4840")]
		public RoomOfferCreateOrUpdateRequestDTO()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000DC")]
	[Utf8JsonSerializable]
	public class RoomOfferItemMappingDTO : IRecNetUtf8JsonObject
	{
		[Cpp2IlInjected.Token(Token = "0x17000281")]
		public RoomOfferItemType ItemType
		{
			[Cpp2IlInjected.Token(Token = "0x60005E4")]
			[Cpp2IlInjected.Address(RVA = "0xB12A00", Offset = "0xB11800", VA = "0x180B12A00")]
			[CompilerGenerated]
			get
			{
				return default(RoomOfferItemType);
			}
			[Cpp2IlInjected.Token(Token = "0x60005E5")]
			[Cpp2IlInjected.Address(RVA = "0xBA1650", Offset = "0xBA0450", VA = "0x180BA1650")]
			[CompilerGenerated]
			internal set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000282")]
		public Guid ItemOriginId
		{
			[Cpp2IlInjected.Token(Token = "0x60005E6")]
			[Cpp2IlInjected.Address(RVA = "0x1BF2010", Offset = "0x1BF0E10", VA = "0x181BF2010")]
			[CompilerGenerated]
			get
			{
				return default(Guid);
			}
			[Cpp2IlInjected.Token(Token = "0x60005E7")]
			[Cpp2IlInjected.Address(RVA = "0x6140810", Offset = "0x613F610", VA = "0x186140810")]
			[CompilerGenerated]
			internal set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000283")]
		public int Count
		{
			[Cpp2IlInjected.Token(Token = "0x60005E8")]
			[Cpp2IlInjected.Address(RVA = "0xAE6400", Offset = "0xAE5200", VA = "0x180AE6400")]
			[CompilerGenerated]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x60005E9")]
			[Cpp2IlInjected.Address(RVA = "0xEF6710", Offset = "0xEF5510", VA = "0x180EF6710")]
			[CompilerGenerated]
			internal set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60005EA")]
		[Cpp2IlInjected.Address(RVA = "0xAC4840", Offset = "0xAC3640", VA = "0x180AC4840")]
		public RoomOfferItemMappingDTO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005EB")]
		[Cpp2IlInjected.Address(RVA = "0x7A60670", Offset = "0x7A5F470", VA = "0x187A60670")]
		public RoomOfferItemMappingDTO(Guid itemOriginId, RoomOfferItemType type, int count)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005EC")]
		[Cpp2IlInjected.Address(RVA = "0xABE8D0", Offset = "0xABD6D0", VA = "0x180ABE8D0", Slot = "4")]
		public void DNRPRHFLPRB()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000DD")]
	[Utf8JsonSerializable]
	public class RoomOfferLastPurchaseDTO : IRecNetUtf8JsonObject
	{
		[Cpp2IlInjected.Token(Token = "0x17000284")]
		public Guid RoomOfferOriginId
		{
			[Cpp2IlInjected.Token(Token = "0x60005ED")]
			[Cpp2IlInjected.Address(RVA = "0xEC6860", Offset = "0xEC5660", VA = "0x180EC6860")]
			[CompilerGenerated]
			get
			{
				return default(Guid);
			}
			[Cpp2IlInjected.Token(Token = "0x60005EE")]
			[Cpp2IlInjected.Address(RVA = "0xEC6880", Offset = "0xEC5680", VA = "0x180EC6880")]
			[CompilerGenerated]
			internal set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000285")]
		public string Name
		{
			[Cpp2IlInjected.Token(Token = "0x60005EF")]
			[Cpp2IlInjected.Address(RVA = "0xAC1D20", Offset = "0xAC0B20", VA = "0x180AC1D20")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60005F0")]
			[Cpp2IlInjected.Address(RVA = "0xAC0640", Offset = "0xABF440", VA = "0x180AC0640")]
			[CompilerGenerated]
			internal set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000286")]
		public int PurchasePrice
		{
			[Cpp2IlInjected.Token(Token = "0x60005F1")]
			[Cpp2IlInjected.Address(RVA = "0xAC2060", Offset = "0xAC0E60", VA = "0x180AC2060")]
			[CompilerGenerated]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x60005F2")]
			[Cpp2IlInjected.Address(RVA = "0xAC1D30", Offset = "0xAC0B30", VA = "0x180AC1D30")]
			[CompilerGenerated]
			internal set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000287")]
		public DateTime PurchaseDate
		{
			[Cpp2IlInjected.Token(Token = "0x60005F3")]
			[Cpp2IlInjected.Address(RVA = "0xAC0F80", Offset = "0xABFD80", VA = "0x180AC0F80")]
			[CompilerGenerated]
			get
			{
				return default(DateTime);
			}
			[Cpp2IlInjected.Token(Token = "0x60005F4")]
			[Cpp2IlInjected.Address(RVA = "0xAC0FA0", Offset = "0xABFDA0", VA = "0x180AC0FA0")]
			[CompilerGenerated]
			internal set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000288")]
		public int Version
		{
			[Cpp2IlInjected.Token(Token = "0x60005F5")]
			[Cpp2IlInjected.Address(RVA = "0xAEE0C0", Offset = "0xAECEC0", VA = "0x180AEE0C0")]
			[CompilerGenerated]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x60005F6")]
			[Cpp2IlInjected.Address(RVA = "0xE1B620", Offset = "0xE1A420", VA = "0x180E1B620")]
			[CompilerGenerated]
			internal set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60005F7")]
		[Cpp2IlInjected.Address(RVA = "0x7A606C0", Offset = "0x7A5F4C0", VA = "0x187A606C0")]
		public RoomOfferLastPurchaseDTO(Guid roomOfferOriginId, string name, int purchasePrice, DateTime purchaseDate, int version)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005F8")]
		[Cpp2IlInjected.Address(RVA = "0xAC4840", Offset = "0xAC3640", VA = "0x180AC4840")]
		public RoomOfferLastPurchaseDTO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005F9")]
		[Cpp2IlInjected.Address(RVA = "0xABE8D0", Offset = "0xABD6D0", VA = "0x180ABE8D0", Slot = "4")]
		public void DNRPRHFLPRB()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000DE")]
	[Utf8JsonSerializable]
	public class RoomOfferPurchaseCountDTO : IRecNetUtf8JsonObject
	{
		[Cpp2IlInjected.Token(Token = "0x17000289")]
		public Guid RoomOfferOriginId
		{
			[Cpp2IlInjected.Token(Token = "0x60005FA")]
			[Cpp2IlInjected.Address(RVA = "0xEC6860", Offset = "0xEC5660", VA = "0x180EC6860")]
			[CompilerGenerated]
			get
			{
				return default(Guid);
			}
			[Cpp2IlInjected.Token(Token = "0x60005FB")]
			[Cpp2IlInjected.Address(RVA = "0xEC6880", Offset = "0xEC5680", VA = "0x180EC6880")]
			[CompilerGenerated]
			internal set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700028A")]
		public int NumOffersPurchased
		{
			[Cpp2IlInjected.Token(Token = "0x60005FC")]
			[Cpp2IlInjected.Address(RVA = "0xACF4D0", Offset = "0xACE2D0", VA = "0x180ACF4D0")]
			[CompilerGenerated]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x60005FD")]
			[Cpp2IlInjected.Address(RVA = "0xB20FD0", Offset = "0xB1FDD0", VA = "0x180B20FD0")]
			[CompilerGenerated]
			internal set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60005FE")]
		[Cpp2IlInjected.Address(RVA = "0xAC4840", Offset = "0xAC3640", VA = "0x180AC4840")]
		public RoomOfferPurchaseCountDTO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005FF")]
		[Cpp2IlInjected.Address(RVA = "0x68D2080", Offset = "0x68D0E80", VA = "0x1868D2080")]
		public RoomOfferPurchaseCountDTO(Guid roomOfferOriginId, int numOffersPurchased)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000600")]
		[Cpp2IlInjected.Address(RVA = "0xABE8D0", Offset = "0xABD6D0", VA = "0x180ABE8D0", Slot = "4")]
		public void DNRPRHFLPRB()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000DF")]
	[Utf8JsonSerializable]
	public class RoomOfferPurchaseRequestDTO : IRecNetUtf8JsonObject
	{
		[Cpp2IlInjected.Token(Token = "0x1700028B")]
		public int NumOffersPurchased
		{
			[Cpp2IlInjected.Token(Token = "0x6000603")]
			[Cpp2IlInjected.Address(RVA = "0xABD110", Offset = "0xABBF10", VA = "0x180ABD110")]
			[CompilerGenerated]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x6000604")]
			[Cpp2IlInjected.Address(RVA = "0xAC1D40", Offset = "0xAC0B40", VA = "0x180AC1D40")]
			[CompilerGenerated]
			internal set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700028C")]
		public Guid TransactionId
		{
			[Cpp2IlInjected.Token(Token = "0x6000605")]
			[Cpp2IlInjected.Address(RVA = "0x1BF2010", Offset = "0x1BF0E10", VA = "0x181BF2010")]
			[CompilerGenerated]
			get
			{
				return default(Guid);
			}
			[Cpp2IlInjected.Token(Token = "0x6000606")]
			[Cpp2IlInjected.Address(RVA = "0x6140810", Offset = "0x613F610", VA = "0x186140810")]
			[CompilerGenerated]
			internal set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700028D")]
		public int ExpectedTotalPrice
		{
			[Cpp2IlInjected.Token(Token = "0x6000607")]
			[Cpp2IlInjected.Address(RVA = "0xAE6400", Offset = "0xAE5200", VA = "0x180AE6400")]
			[CompilerGenerated]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x6000608")]
			[Cpp2IlInjected.Address(RVA = "0xEF6710", Offset = "0xEF5510", VA = "0x180EF6710")]
			[CompilerGenerated]
			internal set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700028E")]
		public Guid? ExpectedPriceUnitOriginId
		{
			[Cpp2IlInjected.Token(Token = "0x6000609")]
			[Cpp2IlInjected.Address(RVA = "0xFF23A0", Offset = "0xFF11A0", VA = "0x180FF23A0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600060A")]
			[Cpp2IlInjected.Address(RVA = "0x24F3FA0", Offset = "0x24F2DA0", VA = "0x1824F3FA0")]
			[CompilerGenerated]
			internal set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700028F")]
		public int ExpectedRoomOfferVersion
		{
			[Cpp2IlInjected.Token(Token = "0x600060B")]
			[Cpp2IlInjected.Address(RVA = "0xAFE430", Offset = "0xAFD230", VA = "0x180AFE430")]
			[CompilerGenerated]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x600060C")]
			[Cpp2IlInjected.Address(RVA = "0xAFD5C0", Offset = "0xAFC3C0", VA = "0x180AFD5C0")]
			[CompilerGenerated]
			internal set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000290")]
		public Dictionary<Guid, Guid?> ConcurrencyCodeByItemOriginIdMap
		{
			[Cpp2IlInjected.Token(Token = "0x600060D")]
			[Cpp2IlInjected.Address(RVA = "0xAC5120", Offset = "0xAC3F20", VA = "0x180AC5120")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600060E")]
			[Cpp2IlInjected.Address(RVA = "0xAC0FB0", Offset = "0xABFDB0", VA = "0x180AC0FB0")]
			[CompilerGenerated]
			internal set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000601")]
		[Cpp2IlInjected.Address(RVA = "0xAC4840", Offset = "0xAC3640", VA = "0x180AC4840")]
		public RoomOfferPurchaseRequestDTO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000602")]
		[Cpp2IlInjected.Address(RVA = "0x7A60730", Offset = "0x7A5F530", VA = "0x187A60730")]
		public RoomOfferPurchaseRequestDTO(int numOffersPurchased, Guid transactionId, int expectedTotalPrice, Guid? expectedPriceUnitOriginId, int expectedRoomOfferVersion, Dictionary<Guid, Guid?> concurrencyCodeByItemOriginIdMap)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600060F")]
		[Cpp2IlInjected.Address(RVA = "0xABE8D0", Offset = "0xABD6D0", VA = "0x180ABE8D0", Slot = "4")]
		public void DNRPRHFLPRB()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000E0")]
	[Utf8JsonSerializable]
	public class RoomOfferPurchaseResponseDTO : IRecNetUtf8JsonObject
	{
		[Cpp2IlInjected.Token(Token = "0x17000291")]
		public RoomOfferPurchaseOperationResult OperationResult
		{
			[Cpp2IlInjected.Token(Token = "0x6000612")]
			[Cpp2IlInjected.Address(RVA = "0xB12A00", Offset = "0xB11800", VA = "0x180B12A00")]
			[CompilerGenerated]
			get
			{
				return default(RoomOfferPurchaseOperationResult);
			}
			[Cpp2IlInjected.Token(Token = "0x6000613")]
			[Cpp2IlInjected.Address(RVA = "0xBA1650", Offset = "0xBA0450", VA = "0x180BA1650")]
			[CompilerGenerated]
			internal set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000292")]
		public UpdateResponseTypes? BalanceUpdateResult
		{
			[Cpp2IlInjected.Token(Token = "0x6000614")]
			[Cpp2IlInjected.Address(RVA = "0x13E8E30", Offset = "0x13E7C30", VA = "0x1813E8E30")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000615")]
			[Cpp2IlInjected.Address(RVA = "0x13EA240", Offset = "0x13E9040", VA = "0x1813EA240")]
			[CompilerGenerated]
			internal set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000293")]
		public BalanceResponseDTO TokenBalanceResponse
		{
			[Cpp2IlInjected.Token(Token = "0x6000616")]
			[Cpp2IlInjected.Address(RVA = "0xAC1D20", Offset = "0xAC0B20", VA = "0x180AC1D20")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000617")]
			[Cpp2IlInjected.Address(RVA = "0xAC0640", Offset = "0xABF440", VA = "0x180AC0640")]
			[CompilerGenerated]
			internal set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000294")]
		public List<PlayerRoomInventoryItemDTO> PlayerRoomInventoryItems
		{
			[Cpp2IlInjected.Token(Token = "0x6000618")]
			[Cpp2IlInjected.Address(RVA = "0xAC0F90", Offset = "0xABFD90", VA = "0x180AC0F90")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000619")]
			[Cpp2IlInjected.Address(RVA = "0xAC0650", Offset = "0xABF450", VA = "0x180AC0650")]
			[CompilerGenerated]
			internal set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000610")]
		[Cpp2IlInjected.Address(RVA = "0xAC4840", Offset = "0xAC3640", VA = "0x180AC4840")]
		public RoomOfferPurchaseResponseDTO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000611")]
		[Cpp2IlInjected.Address(RVA = "0x7A607C0", Offset = "0x7A5F5C0", VA = "0x187A607C0")]
		public RoomOfferPurchaseResponseDTO(RoomOfferPurchaseOperationResult operationResult, UpdateResponseTypes? balanceUpdateResult, BalanceResponseDTO tokenBalanceResponse, List<PlayerRoomInventoryItemDTO> playerRoomInventoryItems)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600061A")]
		[Cpp2IlInjected.Address(RVA = "0x7A607B0", Offset = "0x7A5F5B0", VA = "0x187A607B0", Slot = "4")]
		public void DNRPRHFLPRB()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000E1")]
	public enum RoomOfferItemType : byte
	{
		[Cpp2IlInjected.Token(Token = "0x4000411")]
		Unset,
		[Cpp2IlInjected.Token(Token = "0x4000412")]
		RoomInventoryItem
	}
	[Cpp2IlInjected.Token(Token = "0x20000E2")]
	public enum RoomOfferPurchaseOperationResult : byte
	{
		[Cpp2IlInjected.Token(Token = "0x4000414")]
		Success = 0,
		[Cpp2IlInjected.Token(Token = "0x4000415")]
		ConcurrencyCodeMismatch = 1,
		[Cpp2IlInjected.Token(Token = "0x4000416")]
		RoomOfferDoesNotExist = 2,
		[Cpp2IlInjected.Token(Token = "0x4000417")]
		InvalidRequest = 3,
		[Cpp2IlInjected.Token(Token = "0x4000418")]
		AccountIdIsInvalid = 4,
		[Cpp2IlInjected.Token(Token = "0x4000419")]
		PlayerIsP2PBuyingRestricted = 5,
		[Cpp2IlInjected.Token(Token = "0x400041A")]
		ExpectedOfferTotalPriceMismatch = 6,
		[Cpp2IlInjected.Token(Token = "0x400041B")]
		ExpectedOfferVersionMismatch = 7,
		[Cpp2IlInjected.Token(Token = "0x400041C")]
		InsufficientBalance = 8,
		[Cpp2IlInjected.Token(Token = "0x400041D")]
		OfferUnderModeration = 9,
		[Cpp2IlInjected.Token(Token = "0x400041E")]
		InvalidExpectedTotalPrice = 10,
		[Cpp2IlInjected.Token(Token = "0x400041F")]
		InvalidExpectedOfferVersion = 11,
		[Cpp2IlInjected.Token(Token = "0x4000420")]
		CannotPurchaseMoreThanPerPlayerLimit = 12,
		[Cpp2IlInjected.Token(Token = "0x4000421")]
		InvalidExpectedPriceUnit = 13,
		[Cpp2IlInjected.Token(Token = "0x4000422")]
		InsufficientInventoryItems = 14,
		[Cpp2IlInjected.Token(Token = "0x4000423")]
		InvalidDynamicPriceSettings = 15,
		[Cpp2IlInjected.Token(Token = "0x4000424")]
		InvalidDynamicPrice = 16,
		[Cpp2IlInjected.Token(Token = "0x4000425")]
		NoConcurrencyCodesForInventoryItem = 100,
		[Cpp2IlInjected.Token(Token = "0x4000426")]
		UnexpectedOfferItemType = 101,
		[Cpp2IlInjected.Token(Token = "0x4000427")]
		FeatureDisabled = 254,
		[Cpp2IlInjected.Token(Token = "0x4000428")]
		UnknownError = 255
	}
	[Cpp2IlInjected.Token(Token = "0x20000E3")]
	public enum RoomOfferType : byte
	{
		[Cpp2IlInjected.Token(Token = "0x400042A")]
		Default,
		[Cpp2IlInjected.Token(Token = "0x400042B")]
		OneTimePurchase,
		[Cpp2IlInjected.Token(Token = "0x400042C")]
		BulkPurchase
	}
	[Cpp2IlInjected.Token(Token = "0x20000E4")]
	public interface HTRUPSOSJBI
	{
		[Cpp2IlInjected.Token(Token = "0x400042D")]
		static OZAYXQWBYWY<RoomOffer> SEVOUNUEZWC;

		[Cpp2IlInjected.Token(Token = "0x400042E")]
		static OZAYXQWBYWY<RoomOffer> UCACUFXEOCB;

		[Cpp2IlInjected.Token(Token = "0x400042F")]
		static OZAYXQWBYWY<Guid> YOOTRNYEOEP;

		[Cpp2IlInjected.Token(Token = "0x600061B")]
		[Cpp2IlInjected.Address(Slot = "0")]
		Task<RecNetResult<RoomOffer?>?>? KCLEGIEQUZU(Guid? a, long b, string name, string? c, string? d, int e, bool f, int g, int h, RoomOfferType i, [Optional] Dictionary<Guid, int>? j, [Optional] Guid? k, bool l = false, [Optional] CancellationToken m);

		[Cpp2IlInjected.Token(Token = "0x600061C")]
		[Cpp2IlInjected.Address(Slot = "1")]
		Task<RecNetResult<RoomOffer?>?>? VAWVYPNWQWJ(Guid a, long b, string name, string? c, string? d, int e, bool f, int g, int h, RoomOfferType i, [Optional] Dictionary<Guid, int>? j, [Optional] Guid? k, [Optional] CancellationToken l);

		[Cpp2IlInjected.Token(Token = "0x600061D")]
		[Cpp2IlInjected.Address(Slot = "2")]
		Task<RecNetResult> VJHZLJRSKLV(Guid a, long b, [Optional] CancellationToken c);

		[Cpp2IlInjected.Token(Token = "0x600061E")]
		[Cpp2IlInjected.Address(Slot = "3")]
		Task<List<RoomOffer>> DXKVMVLREIX(long a, [Optional] CancellationToken b);

		[Cpp2IlInjected.Token(Token = "0x600061F")]
		[Cpp2IlInjected.Address(Slot = "4")]
		Task<RecNetResult<List<RoomOfferPurchaseCountDTO>>> LSNKHIPKYAN(long a, [Optional] CancellationToken b);

		[Cpp2IlInjected.Token(Token = "0x6000620")]
		[Cpp2IlInjected.Address(Slot = "5")]
		Task<RecNetResult<List<RoomOfferLastPurchaseDTO>>> HDBVZLTBBCJ(long a, [Optional] CancellationToken b);

		[Cpp2IlInjected.Token(Token = "0x6000621")]
		[Cpp2IlInjected.Address(Slot = "6")]
		Task<RoomOfferPurchaseResponseDTO> WTTHCDWTEXR(Guid a, long b, int c, int d, Guid? e, int f, Dictionary<Guid, Guid?> g, [Optional] CancellationToken h);

		[Cpp2IlInjected.Token(Token = "0x6000622")]
		[Cpp2IlInjected.Address(RVA = "0x7A5C440", Offset = "0x7A5B240", VA = "0x187A5C440")]
		static HTRUPSOSJBI()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000E5")]
	[Utf8JsonSerializable]
	public class RoomEconConfigDTO : IRecNetUtf8JsonObject
	{
		[Cpp2IlInjected.Token(Token = "0x17000295")]
		public long RoomId
		{
			[Cpp2IlInjected.Token(Token = "0x6000623")]
			[Cpp2IlInjected.Address(RVA = "0xABD130", Offset = "0xABBF30", VA = "0x180ABD130")]
			[CompilerGenerated]
			get
			{
				return default(long);
			}
			[Cpp2IlInjected.Token(Token = "0x6000624")]
			[Cpp2IlInjected.Address(RVA = "0xEABA00", Offset = "0xEAA800", VA = "0x180EABA00")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000296")]
		public bool EnableSortingTabs
		{
			[Cpp2IlInjected.Token(Token = "0x6000625")]
			[Cpp2IlInjected.Address(RVA = "0xB40C50", Offset = "0xB3FA50", VA = "0x180B40C50")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000626")]
			[Cpp2IlInjected.Address(RVA = "0xABD140", Offset = "0xABBF40", VA = "0x180ABD140")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000627")]
		[Cpp2IlInjected.Address(RVA = "0xABE8D0", Offset = "0xABD6D0", VA = "0x180ABE8D0", Slot = "4")]
		public void DNRPRHFLPRB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000628")]
		[Cpp2IlInjected.Address(RVA = "0xAC4840", Offset = "0xAC3640", VA = "0x180AC4840")]
		public RoomEconConfigDTO()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000E6")]
	public interface AISLVOLJCIE
	{
		[Cpp2IlInjected.Token(Token = "0x6000629")]
		[Cpp2IlInjected.Address(Slot = "0")]
		Task<RoomEconConfigDTO> OHSZQXAECKO(long a, [Optional] CancellationToken b);

		[Cpp2IlInjected.Token(Token = "0x600062A")]
		[Cpp2IlInjected.Address(Slot = "1")]
		Task<RecNetResult> LVXDFQBUQZU(long a, bool b, [Optional] CancellationToken c);
	}
	[Cpp2IlInjected.Token(Token = "0x20000E7")]
	[Utf8JsonSerializableGeneric]
	public class NZLAWKABKFG<a> where a : IRecNetUtf8JsonObject
	{
		[Cpp2IlInjected.Token(Token = "0x17000297")]
		public long ULYDKSDQCTP
		{
			[Cpp2IlInjected.Token(Token = "0x600062B")]
			[Cpp2IlInjected.Address(RVA = "0xABD130", Offset = "0xABBF30", VA = "0x180ABD130")]
			[CompilerGenerated]
			get
			{
				return default(long);
			}
			[Cpp2IlInjected.Token(Token = "0x600062C")]
			[Cpp2IlInjected.Address(RVA = "0xEABA00", Offset = "0xEAA800", VA = "0x180EABA00")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000298")]
		public CurrencyType HKRFIPLNXLS
		{
			[Cpp2IlInjected.Token(Token = "0x600062D")]
			[Cpp2IlInjected.Address(RVA = "0xAC7B20", Offset = "0xAC6920", VA = "0x180AC7B20")]
			[CompilerGenerated]
			get
			{
				return default(CurrencyType);
			}
			[Cpp2IlInjected.Token(Token = "0x600062E")]
			[Cpp2IlInjected.Address(RVA = "0xACAE40", Offset = "0xAC9C40", VA = "0x180ACAE40")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000299")]
		public StorefrontBalanceType BVSTSBNEOQV
		{
			[Cpp2IlInjected.Token(Token = "0x600062F")]
			[Cpp2IlInjected.Address(RVA = "0x15FD4F0", Offset = "0x15FC2F0", VA = "0x1815FD4F0")]
			[CompilerGenerated]
			get
			{
				return default(StorefrontBalanceType);
			}
			[Cpp2IlInjected.Token(Token = "0x6000630")]
			[Cpp2IlInjected.Address(RVA = "0x15FD4E0", Offset = "0x15FC2E0", VA = "0x1815FD4E0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700029A")]
		public a YTUDXKSFVRJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000631")]
			[Cpp2IlInjected.Address(RVA = "0xAC1D20", Offset = "0xAC0B20", VA = "0x180AC1D20")]
			[CompilerGenerated]
			get
			{
				return (a)null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000632")]
			[Cpp2IlInjected.Address(RVA = "0xAC0640", Offset = "0xABF440", VA = "0x180AC0640")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000633")]
		[Cpp2IlInjected.Address(RVA = "0xAC4840", Offset = "0xAC3640", VA = "0x180AC4840")]
		public NZLAWKABKFG()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000E8")]
	[Utf8JsonSerializableGeneric]
	public class YMBBIASXKQU<a> where a : IRecNetUtf8JsonObject
	{
		[Cpp2IlInjected.Token(Token = "0x1700029B")]
		public long ULYDKSDQCTP
		{
			[Cpp2IlInjected.Token(Token = "0x6000634")]
			[Cpp2IlInjected.Address(RVA = "0xABD130", Offset = "0xABBF30", VA = "0x180ABD130")]
			[CompilerGenerated]
			get
			{
				return default(long);
			}
			[Cpp2IlInjected.Token(Token = "0x6000635")]
			[Cpp2IlInjected.Address(RVA = "0xEABA00", Offset = "0xEAA800", VA = "0x180EABA00")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700029C")]
		public CurrencyType HKRFIPLNXLS
		{
			[Cpp2IlInjected.Token(Token = "0x6000636")]
			[Cpp2IlInjected.Address(RVA = "0xAC7B20", Offset = "0xAC6920", VA = "0x180AC7B20")]
			[CompilerGenerated]
			get
			{
				return default(CurrencyType);
			}
			[Cpp2IlInjected.Token(Token = "0x6000637")]
			[Cpp2IlInjected.Address(RVA = "0xACAE40", Offset = "0xAC9C40", VA = "0x180ACAE40")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700029D")]
		public StorefrontBalanceType BVSTSBNEOQV
		{
			[Cpp2IlInjected.Token(Token = "0x6000638")]
			[Cpp2IlInjected.Address(RVA = "0x15FD4F0", Offset = "0x15FC2F0", VA = "0x1815FD4F0")]
			[CompilerGenerated]
			get
			{
				return default(StorefrontBalanceType);
			}
			[Cpp2IlInjected.Token(Token = "0x6000639")]
			[Cpp2IlInjected.Address(RVA = "0x15FD4E0", Offset = "0x15FC2E0", VA = "0x1815FD4E0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700029E")]
		public List<a> YTUDXKSFVRJ
		{
			[Cpp2IlInjected.Token(Token = "0x600063A")]
			[Cpp2IlInjected.Address(RVA = "0xAC1D20", Offset = "0xAC0B20", VA = "0x180AC1D20")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600063B")]
			[Cpp2IlInjected.Address(RVA = "0xAC0640", Offset = "0xABF440", VA = "0x180AC0640")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600063C")]
		[Cpp2IlInjected.Address(RVA = "0xAC4840", Offset = "0xAC3640", VA = "0x180AC4840")]
		public YMBBIASXKQU()
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x20000E9")]
	[Utf8JsonSerializableGeneric]
	public class BalanceUpdateResponseDTO<DataTypeDTO> : BalanceResponseDTO where DataTypeDTO : IRecNetUtf8JsonObject, new()
	{
		[Cpp2IlInjected.Token(Token = "0x20000EA")]
		[Utf8JsonSerializableGeneric]
		public class QZLWGWJOYLL : IRecNetUtf8JsonObjectPerformsPostProcessing, IRecNetUtf8JsonObject
		{
			[StructLayout((LayoutKind)3)]
			[Cpp2IlInjected.Token(Token = "0x20000EB")]
			[CompilerGenerated]
			private struct <OnPostDeserialized>d__9 : IAsyncStateMachine
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x400043D")]
				public int <>1__state;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x400043E")]
				public AsyncTaskMethodBuilder <>t__builder;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x400043F")]
				public QZLWGWJOYLL <>4__this;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x4000440")]
				private TaskAwaiter <>u__1;

				[Cpp2IlInjected.Token(Token = "0x6000648")]
				[Cpp2IlInjected.Address(RVA = "0x531BB70", Offset = "0x531A970", VA = "0x18531BB70", Slot = "4")]
				private void MoveNext()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000649")]
				[Cpp2IlInjected.Address(RVA = "0x531BDB0", Offset = "0x531ABB0", VA = "0x18531BDB0", Slot = "5")]
				[DebuggerHidden]
				private void SetStateMachine(IAsyncStateMachine stateMachine)
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x170002A0")]
			public UpdateResponseTypes ILHVZFZEGLD
			{
				[Cpp2IlInjected.Token(Token = "0x6000641")]
				[Cpp2IlInjected.Address(RVA = "0xABD110", Offset = "0xABBF10", VA = "0x180ABD110")]
				[CompilerGenerated]
				get
				{
					return default(UpdateResponseTypes);
				}
				[Cpp2IlInjected.Token(Token = "0x6000642")]
				[Cpp2IlInjected.Address(RVA = "0xAC1D40", Offset = "0xAC0B40", VA = "0x180AC1D40")]
				[CompilerGenerated]
				internal set
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x170002A1")]
			public DataTypeDTO YTUDXKSFVRJ
			{
				[Cpp2IlInjected.Token(Token = "0x6000643")]
				[Cpp2IlInjected.Address(RVA = "0xAC0D20", Offset = "0xABFB20", VA = "0x180AC0D20")]
				[CompilerGenerated]
				get
				{
					return (DataTypeDTO)null;
				}
				[Cpp2IlInjected.Token(Token = "0x6000644")]
				[Cpp2IlInjected.Address(RVA = "0xAC0D10", Offset = "0xABFB10", VA = "0x180AC0D10")]
				[CompilerGenerated]
				internal set
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000645")]
			[Cpp2IlInjected.Address(RVA = "0x5E424C0", Offset = "0x5E412C0", VA = "0x185E424C0", Slot = "5")]
			public void DNRPRHFLPRB()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000646")]
			[Cpp2IlInjected.Address(RVA = "0x5E42DF0", Offset = "0x5E41BF0", VA = "0x185E42DF0", Slot = "4")]
			[AsyncStateMachine(typeof(BalanceUpdateResponseDTO<>.QZLWGWJOYLL.<OnPostDeserialized>d__9))]
			public Task WSLKELMBPUB()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000647")]
			[Cpp2IlInjected.Address(RVA = "0xAC4840", Offset = "0xAC3640", VA = "0x180AC4840")]
			public QZLWGWJOYLL()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700029F")]
		public List<QZLWGWJOYLL> BalanceUpdates
		{
			[Cpp2IlInjected.Token(Token = "0x600063D")]
			[Cpp2IlInjected.Address(RVA = "0xAC1D20", Offset = "0xAC0B20", VA = "0x180AC1D20")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600063E")]
			[Cpp2IlInjected.Address(RVA = "0xAC0640", Offset = "0xABF440", VA = "0x180AC0640")]
			[CompilerGenerated]
			internal set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600063F")]
		[Cpp2IlInjected.Address(RVA = "0x5DD75F0", Offset = "0x5DD63F0", VA = "0x185DD75F0", Slot = "5")]
		public override void DNRPRHFLPRB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000640")]
		[Cpp2IlInjected.Address(RVA = "0xAE81C0", Offset = "0xAE6FC0", VA = "0x180AE81C0")]
		public BalanceUpdateResponseDTO()
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x20000EC")]
	[Utf8JsonSerializableGeneric]
	public class PurchaseBalanceUpdateResponseDTO<DataTypeDTO> : BalanceResponseDTO where DataTypeDTO : IRecNetUtf8JsonObject, new()
	{
		[Cpp2IlInjected.Token(Token = "0x20000ED")]
		[Utf8JsonSerializableGeneric]
		public class QZLWGWJOYLL : IRecNetUtf8JsonObjectPerformsPostProcessing, IRecNetUtf8JsonObject
		{
			[StructLayout((LayoutKind)3)]
			[Cpp2IlInjected.Token(Token = "0x20000EE")]
			[CompilerGenerated]
			private struct <OnPostDeserialized>d__9 : IAsyncStateMachine
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x4000444")]
				public int <>1__state;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x4000445")]
				public AsyncTaskMethodBuilder <>t__builder;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x4000446")]
				public QZLWGWJOYLL <>4__this;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x4000447")]
				private TaskAwaiter <>u__1;

				[Cpp2IlInjected.Token(Token = "0x6000655")]
				[Cpp2IlInjected.Address(RVA = "0x531B410", Offset = "0x531A210", VA = "0x18531B410", Slot = "4")]
				private void MoveNext()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000656")]
				[Cpp2IlInjected.Address(RVA = "0x531BE10", Offset = "0x531AC10", VA = "0x18531BE10", Slot = "5")]
				[DebuggerHidden]
				private void SetStateMachine(IAsyncStateMachine stateMachine)
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x170002A3")]
			public UpdateResponseTypes ILHVZFZEGLD
			{
				[Cpp2IlInjected.Token(Token = "0x600064E")]
				[Cpp2IlInjected.Address(RVA = "0xABD110", Offset = "0xABBF10", VA = "0x180ABD110")]
				[CompilerGenerated]
				get
				{
					return default(UpdateResponseTypes);
				}
				[Cpp2IlInjected.Token(Token = "0x600064F")]
				[Cpp2IlInjected.Address(RVA = "0xAC1D40", Offset = "0xAC0B40", VA = "0x180AC1D40")]
				[CompilerGenerated]
				internal set
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x170002A4")]
			public List<DataTypeDTO> YTUDXKSFVRJ
			{
				[Cpp2IlInjected.Token(Token = "0x6000650")]
				[Cpp2IlInjected.Address(RVA = "0xAC0D20", Offset = "0xABFB20", VA = "0x180AC0D20")]
				[CompilerGenerated]
				get
				{
					return null;
				}
				[Cpp2IlInjected.Token(Token = "0x6000651")]
				[Cpp2IlInjected.Address(RVA = "0xAC0D10", Offset = "0xABFB10", VA = "0x180AC0D10")]
				[CompilerGenerated]
				internal set
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000652")]
			[Cpp2IlInjected.Address(RVA = "0x5E428F0", Offset = "0x5E416F0", VA = "0x185E428F0", Slot = "5")]
			public void DNRPRHFLPRB()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000653")]
			[Cpp2IlInjected.Address(RVA = "0x5E42D20", Offset = "0x5E41B20", VA = "0x185E42D20", Slot = "4")]
			[AsyncStateMachine(typeof(PurchaseBalanceUpdateResponseDTO<>.QZLWGWJOYLL.<OnPostDeserialized>d__9))]
			public Task WSLKELMBPUB()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000654")]
			[Cpp2IlInjected.Address(RVA = "0xAC4840", Offset = "0xAC3640", VA = "0x180AC4840")]
			public QZLWGWJOYLL()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170002A2")]
		public List<QZLWGWJOYLL> BalanceUpdates
		{
			[Cpp2IlInjected.Token(Token = "0x600064A")]
			[Cpp2IlInjected.Address(RVA = "0xAC1D20", Offset = "0xAC0B20", VA = "0x180AC1D20")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600064B")]
			[Cpp2IlInjected.Address(RVA = "0xAC0640", Offset = "0xABF440", VA = "0x180AC0640")]
			[CompilerGenerated]
			internal set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600064C")]
		[Cpp2IlInjected.Address(RVA = "0x5DD75F0", Offset = "0x5DD63F0", VA = "0x185DD75F0", Slot = "5")]
		public override void DNRPRHFLPRB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600064D")]
		[Cpp2IlInjected.Address(RVA = "0xAE81C0", Offset = "0xAE6FC0", VA = "0x180AE81C0")]
		public PurchaseBalanceUpdateResponseDTO()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000EF")]
	[Utf8JsonSerializableGenericSpecialization]
	public class PurchaseBalanceUpdateResponseDTO_GiftPackage : PurchaseBalanceUpdateResponseDTO<GiftPackage>
	{
		[Cpp2IlInjected.Token(Token = "0x6000657")]
		[Cpp2IlInjected.Address(RVA = "0x7A5F680", Offset = "0x7A5E480", VA = "0x187A5F680")]
		public PurchaseBalanceUpdateResponseDTO_GiftPackage()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000F0")]
	[Utf8JsonSerializableGenericSpecialization]
	public class QOXBAKLQSBN : PurchaseBalanceUpdateResponseDTO<GiftPackage>.QZLWGWJOYLL
	{
		[Cpp2IlInjected.Token(Token = "0x6000658")]
		[Cpp2IlInjected.Address(RVA = "0x7A5FC20", Offset = "0x7A5EA20", VA = "0x187A5FC20")]
		public QOXBAKLQSBN()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000F1")]
	[Utf8JsonSerializable]
	public class PurchaseItemRequestDTO : IRecNetUtf8JsonObject
	{
		[Cpp2IlInjected.Token(Token = "0x170002A5")]
		public ItemPurchaseMethodId ItemPurchaseMethodId
		{
			[Cpp2IlInjected.Token(Token = "0x6000659")]
			[Cpp2IlInjected.Address(RVA = "0xABD130", Offset = "0xABBF30", VA = "0x180ABD130")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600065A")]
			[Cpp2IlInjected.Address(RVA = "0xABD120", Offset = "0xABBF20", VA = "0x180ABD120")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170002A6")]
		public long RequestedPrice
		{
			[Cpp2IlInjected.Token(Token = "0x600065B")]
			[Cpp2IlInjected.Address(RVA = "0xAC0D20", Offset = "0xABFB20", VA = "0x180AC0D20")]
			[CompilerGenerated]
			get
			{
				return default(long);
			}
			[Cpp2IlInjected.Token(Token = "0x600065C")]
			[Cpp2IlInjected.Address(RVA = "0xE27A80", Offset = "0xE26880", VA = "0x180E27A80")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170002A7")]
		public GiftItemDTO? Gift
		{
			[Cpp2IlInjected.Token(Token = "0x600065D")]
			[Cpp2IlInjected.Address(RVA = "0xAC1D20", Offset = "0xAC0B20", VA = "0x180AC1D20")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600065E")]
			[Cpp2IlInjected.Address(RVA = "0xAC0640", Offset = "0xABF440", VA = "0x180AC0640")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170002A8")]
		public long? CouponConsumablePlayerMappingId
		{
			[Cpp2IlInjected.Token(Token = "0x600065F")]
			[Cpp2IlInjected.Address(RVA = "0x143F690", Offset = "0x143E490", VA = "0x18143F690")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000660")]
			[Cpp2IlInjected.Address(RVA = "0x159EF20", Offset = "0x159DD20", VA = "0x18159EF20")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170002A9")]
		public int DuplicateItemCount
		{
			[Cpp2IlInjected.Token(Token = "0x6000661")]
			[Cpp2IlInjected.Address(RVA = "0xAEE0C0", Offset = "0xAECEC0", VA = "0x180AEE0C0")]
			[CompilerGenerated]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x6000662")]
			[Cpp2IlInjected.Address(RVA = "0xE1B620", Offset = "0xE1A420", VA = "0x180E1B620")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000663")]
		[Cpp2IlInjected.Address(RVA = "0x7A5F6C0", Offset = "0x7A5E4C0", VA = "0x187A5F6C0")]
		public PurchaseItemRequestDTO(ItemPurchaseMethodId itemPurchaseMethodId, long requestedPrice, GiftItemDTO? gift, int duplicateItemCount = 1, [Optional] long? couponConsumablePlayerMappingId)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000664")]
		[Cpp2IlInjected.Address(RVA = "0xABE8D0", Offset = "0xABD6D0", VA = "0x180ABE8D0", Slot = "4")]
		public void DNRPRHFLPRB()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000F2")]
	[Utf8JsonSerializable]
	public class BulkPurchaseItemRequestDTO : IRecNetUtf8JsonObject
	{
		[Cpp2IlInjected.Token(Token = "0x170002AA")]
		public List<PurchaseItemRequestDTO> PurchaseItemRequests
		{
			[Cpp2IlInjected.Token(Token = "0x6000665")]
			[Cpp2IlInjected.Address(RVA = "0xABD130", Offset = "0xABBF30", VA = "0x180ABD130")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000666")]
			[Cpp2IlInjected.Address(RVA = "0xABD120", Offset = "0xABBF20", VA = "0x180ABD120")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170002AB")]
		public StorefrontTypes? StorefrontType
		{
			[Cpp2IlInjected.Token(Token = "0x6000667")]
			[Cpp2IlInjected.Address(RVA = "0xAC0D20", Offset = "0xABFB20", VA = "0x180AC0D20")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000668")]
			[Cpp2IlInjected.Address(RVA = "0xE27A80", Offset = "0xE26880", VA = "0x180E27A80")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170002AC")]
		public CurrencyType CurrencyType
		{
			[Cpp2IlInjected.Token(Token = "0x6000669")]
			[Cpp2IlInjected.Address(RVA = "0xACF4D0", Offset = "0xACE2D0", VA = "0x180ACF4D0")]
			[CompilerGenerated]
			get
			{
				return default(CurrencyType);
			}
			[Cpp2IlInjected.Token(Token = "0x600066A")]
			[Cpp2IlInjected.Address(RVA = "0xB20FD0", Offset = "0xB1FDD0", VA = "0x180B20FD0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170002AD")]
		public bool BypassGiftPackages
		{
			[Cpp2IlInjected.Token(Token = "0x600066B")]
			[Cpp2IlInjected.Address(RVA = "0xEBF2C0", Offset = "0xEBE0C0", VA = "0x180EBF2C0")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x600066C")]
			[Cpp2IlInjected.Address(RVA = "0xEBF160", Offset = "0xEBDF60", VA = "0x180EBF160")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170002AE")]
		public bool AllowPartialSuccess
		{
			[Cpp2IlInjected.Token(Token = "0x600066D")]
			[Cpp2IlInjected.Address(RVA = "0x165FB60", Offset = "0x165E960", VA = "0x18165FB60")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x600066E")]
			[Cpp2IlInjected.Address(RVA = "0x7A59E00", Offset = "0x7A58C00", VA = "0x187A59E00")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170002AF")]
		public Guid? ShoppingBagId
		{
			[Cpp2IlInjected.Token(Token = "0x600066F")]
			[Cpp2IlInjected.Address(RVA = "0xFF23A0", Offset = "0xFF11A0", VA = "0x180FF23A0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000670")]
			[Cpp2IlInjected.Address(RVA = "0x24F3FA0", Offset = "0x24F2DA0", VA = "0x1824F3FA0")]
			[CompilerGenerated]
			internal set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000671")]
		[Cpp2IlInjected.Address(RVA = "0x7A59D80", Offset = "0x7A58B80", VA = "0x187A59D80")]
		public BulkPurchaseItemRequestDTO(List<PurchaseItemRequestDTO> purchaseItemRequests, StorefrontTypes? storefrontType, CurrencyType currencyType, bool allowPartialSuccess, bool bypassGiftPackages = false, [Optional] Guid? shoppingBagId)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000672")]
		[Cpp2IlInjected.Address(RVA = "0xABE8D0", Offset = "0xABD6D0", VA = "0x180ABE8D0", Slot = "4")]
		public void DNRPRHFLPRB()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000F3")]
	[Utf8JsonSerializable]
	public class BulkPurchaseItemsBalanceUpdateResponseDataDTO : IRecNetUtf8JsonObjectPerformsPostProcessing, IRecNetUtf8JsonObject
	{
		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x20000F4")]
		[CompilerGenerated]
		private struct <OnPostDeserialized>d__15 : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000458")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x4000459")]
			public AsyncTaskMethodBuilder <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400045A")]
			public BulkPurchaseItemsBalanceUpdateResponseDataDTO <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x400045B")]
			private TaskAwaiter <>u__1;

			[Cpp2IlInjected.Token(Token = "0x600067C")]
			[Cpp2IlInjected.Address(RVA = "0x7A62DC0", Offset = "0x7A61BC0", VA = "0x187A62DC0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600067D")]
			[Cpp2IlInjected.Address(RVA = "0x7A630A0", Offset = "0x7A61EA0", VA = "0x187A630A0", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000453")]
		internal static Action<GiftPackage>? FFPYAORTGZC;

		[Cpp2IlInjected.Token(Token = "0x4000454")]
		internal static Func<GiftPackage, Task>? LHNVZUTKYSG;

		[Cpp2IlInjected.Token(Token = "0x170002B0")]
		public GiftPackage GiftPackage
		{
			[Cpp2IlInjected.Token(Token = "0x6000673")]
			[Cpp2IlInjected.Address(RVA = "0xABD130", Offset = "0xABBF30", VA = "0x180ABD130")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000674")]
			[Cpp2IlInjected.Address(RVA = "0xABD120", Offset = "0xABBF20", VA = "0x180ABD120")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170002B1")]
		public int? PurchasableItemId
		{
			[Cpp2IlInjected.Token(Token = "0x6000675")]
			[Cpp2IlInjected.Address(RVA = "0xAC0D20", Offset = "0xABFB20", VA = "0x180AC0D20")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000676")]
			[Cpp2IlInjected.Address(RVA = "0xE27A80", Offset = "0xE26880", VA = "0x180E27A80")]
			[CompilerGenerated]
			internal set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170002B2")]
		public CustomAvatarItem? CustomAvatarItem
		{
			[Cpp2IlInjected.Token(Token = "0x6000677")]
			[Cpp2IlInjected.Address(RVA = "0xAC1D20", Offset = "0xAC0B20", VA = "0x180AC1D20")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000678")]
			[Cpp2IlInjected.Address(RVA = "0xAC0640", Offset = "0xABF440", VA = "0x180AC0640")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000679")]
		[Cpp2IlInjected.Address(RVA = "0x7A59E10", Offset = "0x7A58C10", VA = "0x187A59E10", Slot = "5")]
		public void DNRPRHFLPRB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600067A")]
		[Cpp2IlInjected.Address(RVA = "0x7A59ED0", Offset = "0x7A58CD0", VA = "0x187A59ED0", Slot = "6")]
		[AsyncStateMachine(typeof(<OnPostDeserialized>d__15))]
		public virtual Task WSLKELMBPUB()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600067B")]
		[Cpp2IlInjected.Address(RVA = "0xAC4840", Offset = "0xAC3640", VA = "0x180AC4840")]
		public BulkPurchaseItemsBalanceUpdateResponseDataDTO()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000F5")]
	[Utf8JsonSerializableGenericSpecialization]
	public class BalanceUpdateResponseDTO_BulkPurchaseItemsBalanceUpdateResponseDataDTO : BalanceUpdateResponseDTO<BulkPurchaseItemsBalanceUpdateResponseDataDTO>
	{
		[Cpp2IlInjected.Token(Token = "0x600067E")]
		[Cpp2IlInjected.Address(RVA = "0x7A59D40", Offset = "0x7A58B40", VA = "0x187A59D40")]
		public BalanceUpdateResponseDTO_BulkPurchaseItemsBalanceUpdateResponseDataDTO()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000F6")]
	[Utf8JsonSerializableGenericSpecialization]
	public class URFBPYGDDUK : BalanceUpdateResponseDTO<BulkPurchaseItemsBalanceUpdateResponseDataDTO>.QZLWGWJOYLL
	{
		[Cpp2IlInjected.Token(Token = "0x600067F")]
		[Cpp2IlInjected.Address(RVA = "0x7A64000", Offset = "0x7A62E00", VA = "0x187A64000")]
		public URFBPYGDDUK()
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x20000F7")]
	[Utf8JsonSerializable]
	public class GiftItemDTO
	{
		[Cpp2IlInjected.Token(Token = "0x170002B3")]
		public int ToPlayerId
		{
			[Cpp2IlInjected.Token(Token = "0x6000680")]
			[Cpp2IlInjected.Address(RVA = "0xABD110", Offset = "0xABBF10", VA = "0x180ABD110")]
			[CompilerGenerated]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x6000681")]
			[Cpp2IlInjected.Address(RVA = "0xAC1D40", Offset = "0xAC0B40", VA = "0x180AC1D40")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170002B4")]
		public string? Message
		{
			[Cpp2IlInjected.Token(Token = "0x6000682")]
			[Cpp2IlInjected.Address(RVA = "0xAC0D20", Offset = "0xABFB20", VA = "0x180AC0D20")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000683")]
			[Cpp2IlInjected.Address(RVA = "0xAC0D10", Offset = "0xABFB10", VA = "0x180AC0D10")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170002B5")]
		public bool Anonymous
		{
			[Cpp2IlInjected.Token(Token = "0x6000684")]
			[Cpp2IlInjected.Address(RVA = "0xAC1360", Offset = "0xAC0160", VA = "0x180AC1360")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000685")]
			[Cpp2IlInjected.Address(RVA = "0xAC0FD0", Offset = "0xABFDD0", VA = "0x180AC0FD0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170002B6")]
		public GiftContext GiftContext
		{
			[Cpp2IlInjected.Token(Token = "0x6000686")]
			[Cpp2IlInjected.Address(RVA = "0xAE6400", Offset = "0xAE5200", VA = "0x180AE6400")]
			[CompilerGenerated]
			get
			{
				return default(GiftContext);
			}
			[Cpp2IlInjected.Token(Token = "0x6000687")]
			[Cpp2IlInjected.Address(RVA = "0xEF6710", Offset = "0xEF5510", VA = "0x180EF6710")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000688")]
		[Cpp2IlInjected.Address(RVA = "0xAC4840", Offset = "0xAC3640", VA = "0x180AC4840")]
		public GiftItemDTO()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000F8")]
	[Utf8JsonSerializable]
	public class ItemPurchaseInfoDTO : IRecNetUtf8JsonObject, XIVKWLCGGPQ
	{
		[Cpp2IlInjected.Token(Token = "0x170002B7")]
		public UGCPurchasableItemIdentifier? ItemId
		{
			[Cpp2IlInjected.Token(Token = "0x6000689")]
			[Cpp2IlInjected.Address(RVA = "0xABD130", Offset = "0xABBF30", VA = "0x180ABD130")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600068A")]
			[Cpp2IlInjected.Address(RVA = "0xABD120", Offset = "0xABBF20", VA = "0x180ABD120")]
			[CompilerGenerated]
			internal set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170002B8")]
		[IgnoreDataMember]
		public Guid CustomAvatarItemId
		{
			[Cpp2IlInjected.Token(Token = "0x600068B")]
			[Cpp2IlInjected.Address(RVA = "0x7A5D4A0", Offset = "0x7A5C2A0", VA = "0x187A5D4A0", Slot = "5")]
			get
			{
				return default(Guid);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170002B9")]
		public ItemPurchaseMethodId? PurchaseMethodId
		{
			[Cpp2IlInjected.Token(Token = "0x600068D")]
			[Cpp2IlInjected.Address(RVA = "0xAC0D20", Offset = "0xABFB20", VA = "0x180AC0D20", Slot = "6")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600068E")]
			[Cpp2IlInjected.Address(RVA = "0xAC0D10", Offset = "0xABFB10", VA = "0x180AC0D10")]
			[CompilerGenerated]
			internal set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170002BA")]
		public List<PurchasablePrice>? Prices
		{
			[Cpp2IlInjected.Token(Token = "0x600068F")]
			[Cpp2IlInjected.Address(RVA = "0xAC1D20", Offset = "0xAC0B20", VA = "0x180AC1D20", Slot = "7")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000690")]
			[Cpp2IlInjected.Address(RVA = "0xAC0640", Offset = "0xABF440", VA = "0x180AC0640")]
			[CompilerGenerated]
			internal set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170002BB")]
		public DateTime? NewUntil
		{
			[Cpp2IlInjected.Token(Token = "0x6000691")]
			[Cpp2IlInjected.Address(RVA = "0x143F690", Offset = "0x143E490", VA = "0x18143F690", Slot = "8")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000692")]
			[Cpp2IlInjected.Address(RVA = "0x159EF20", Offset = "0x159DD20", VA = "0x18159EF20")]
			[CompilerGenerated]
			internal set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170002BC")]
		public DateTime? AvailableAt
		{
			[Cpp2IlInjected.Token(Token = "0x6000693")]
			[Cpp2IlInjected.Address(RVA = "0x1669DE0", Offset = "0x1668BE0", VA = "0x181669DE0", Slot = "9")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000694")]
			[Cpp2IlInjected.Address(RVA = "0x1667DE0", Offset = "0x1666BE0", VA = "0x181667DE0")]
			[CompilerGenerated]
			internal set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170002BD")]
		public DateTime? AvailableUntil
		{
			[Cpp2IlInjected.Token(Token = "0x6000695")]
			[Cpp2IlInjected.Address(RVA = "0xED04D0", Offset = "0xECF2D0", VA = "0x180ED04D0", Slot = "10")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000696")]
			[Cpp2IlInjected.Address(RVA = "0x20F70C0", Offset = "0x20F5EC0", VA = "0x1820F70C0")]
			[CompilerGenerated]
			internal set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170002BE")]
		public bool CanBeGifted
		{
			[Cpp2IlInjected.Token(Token = "0x6000697")]
			[Cpp2IlInjected.Address(RVA = "0xE16FB0", Offset = "0xE15DB0", VA = "0x180E16FB0", Slot = "11")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000698")]
			[Cpp2IlInjected.Address(RVA = "0xE16AE0", Offset = "0xE158E0", VA = "0x180E16AE0")]
			[CompilerGenerated]
			internal set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170002BF")]
		public bool CanApplySubscriberDiscount
		{
			[Cpp2IlInjected.Token(Token = "0x6000699")]
			[Cpp2IlInjected.Address(RVA = "0xB104D0", Offset = "0xB0F2D0", VA = "0x180B104D0")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x600069A")]
			[Cpp2IlInjected.Address(RVA = "0xB104E0", Offset = "0xB0F2E0", VA = "0x180B104E0")]
			[CompilerGenerated]
			internal set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170002C0")]
		public bool SubscribersOnly
		{
			[Cpp2IlInjected.Token(Token = "0x600069B")]
			[Cpp2IlInjected.Address(RVA = "0x10E06E0", Offset = "0x10DF4E0", VA = "0x1810E06E0", Slot = "12")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x600069C")]
			[Cpp2IlInjected.Address(RVA = "0x12B51B0", Offset = "0x12B3FB0", VA = "0x1812B51B0")]
			[CompilerGenerated]
			internal set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170002C1")]
		public bool IsFeatured
		{
			[Cpp2IlInjected.Token(Token = "0x600069D")]
			[Cpp2IlInjected.Address(RVA = "0x31D59E0", Offset = "0x31D47E0", VA = "0x1831D59E0", Slot = "13")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x600069E")]
			[Cpp2IlInjected.Address(RVA = "0x4A19060", Offset = "0x4A17E60", VA = "0x184A19060")]
			[CompilerGenerated]
			internal set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600068C")]
		[Cpp2IlInjected.Address(RVA = "0x7A5D210", Offset = "0x7A5C010", VA = "0x187A5D210")]
		public static ItemPurchaseInfoDTO QKIBEFSZICB(Guid a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600069F")]
		[Cpp2IlInjected.Address(RVA = "0xABE8D0", Offset = "0xABD6D0", VA = "0x180ABE8D0", Slot = "4")]
		public void DNRPRHFLPRB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60006A0")]
		[Cpp2IlInjected.Address(RVA = "0xAC4840", Offset = "0xAC3640", VA = "0x180AC4840")]
		public ItemPurchaseInfoDTO()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000F9")]
	[Utf8JsonSerializable]
	public class RRPlusSignupConfigDTO
	{
		[Cpp2IlInjected.Token(Token = "0x170002C2")]
		public int Version
		{
			[Cpp2IlInjected.Token(Token = "0x60006A1")]
			[Cpp2IlInjected.Address(RVA = "0xABD110", Offset = "0xABBF10", VA = "0x180ABD110")]
			[CompilerGenerated]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x60006A2")]
			[Cpp2IlInjected.Address(RVA = "0xAC1D40", Offset = "0xAC0B40", VA = "0x180AC1D40")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170002C3")]
		public string HighlightText
		{
			[Cpp2IlInjected.Token(Token = "0x60006A3")]
			[Cpp2IlInjected.Address(RVA = "0xAC0D20", Offset = "0xABFB20", VA = "0x180AC0D20")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60006A4")]
			[Cpp2IlInjected.Address(RVA = "0xAC0D10", Offset = "0xABFB10", VA = "0x180AC0D10")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170002C4")]
		public string MoreDetailsText
		{
			[Cpp2IlInjected.Token(Token = "0x60006A5")]
			[Cpp2IlInjected.Address(RVA = "0xAC1D20", Offset = "0xAC0B20", VA = "0x180AC1D20")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60006A6")]
			[Cpp2IlInjected.Address(RVA = "0xAC0640", Offset = "0xABF440", VA = "0x180AC0640")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170002C5")]
		public Dictionary<int, RRPlusBenefitDescriptionDto> BenefitLookup
		{
			[Cpp2IlInjected.Token(Token = "0x60006A7")]
			[Cpp2IlInjected.Address(RVA = "0xAC0F90", Offset = "0xABFD90", VA = "0x180AC0F90")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60006A8")]
			[Cpp2IlInjected.Address(RVA = "0xAC0650", Offset = "0xABF450", VA = "0x180AC0650")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170002C6")]
		public Dictionary<string, int> NumberReplacements
		{
			[Cpp2IlInjected.Token(Token = "0x60006A9")]
			[Cpp2IlInjected.Address(RVA = "0xAC0F80", Offset = "0xABFD80", VA = "0x180AC0F80")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60006AA")]
			[Cpp2IlInjected.Address(RVA = "0xAC8C50", Offset = "0xAC7A50", VA = "0x180AC8C50")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170002C7")]
		public Dictionary<BenefitListType, List<int>> BenefitLists
		{
			[Cpp2IlInjected.Token(Token = "0x60006AB")]
			[Cpp2IlInjected.Address(RVA = "0xAC0FC0", Offset = "0xABFDC0", VA = "0x180AC0FC0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60006AC")]
			[Cpp2IlInjected.Address(RVA = "0xAC0CF0", Offset = "0xABFAF0", VA = "0x180AC0CF0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170002C8")]
		public Dictionary<string, string> StringConfigs
		{
			[Cpp2IlInjected.Token(Token = "0x60006AD")]
			[Cpp2IlInjected.Address(RVA = "0xAC5120", Offset = "0xAC3F20", VA = "0x180AC5120")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60006AE")]
			[Cpp2IlInjected.Address(RVA = "0xAC0FB0", Offset = "0xABFDB0", VA = "0x180AC0FB0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60006AF")]
		[Cpp2IlInjected.Address(RVA = "0xAC4840", Offset = "0xAC3640", VA = "0x180AC4840")]
		public RRPlusSignupConfigDTO()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000FA")]
	public enum BenefitListType
	{
		[Cpp2IlInjected.Token(Token = "0x4000472")]
		DetailsScreen,
		[Cpp2IlInjected.Token(Token = "0x4000473")]
		SignUpScreen,
		[Cpp2IlInjected.Token(Token = "0x4000474")]
		ManageMembershipScreen,
		[Cpp2IlInjected.Token(Token = "0x4000475")]
		ItemDetailsScreen,
		[Cpp2IlInjected.Token(Token = "0x4000476")]
		ActivityRewardsScreen,
		[Cpp2IlInjected.Token(Token = "0x4000477")]
		RoomPublishUpsell
	}
	[Cpp2IlInjected.Token(Token = "0x20000FB")]
	[Utf8JsonSerializable]
	public class RRPlusBenefitDescriptionDto : NFCRWBWZFXT
	{
		[Cpp2IlInjected.Token(Token = "0x170002C9")]
		public PlatformMask EnabledForPlatforms
		{
			[Cpp2IlInjected.Token(Token = "0x60006B0")]
			[Cpp2IlInjected.Address(RVA = "0xABD110", Offset = "0xABBF10", VA = "0x180ABD110")]
			[CompilerGenerated]
			get
			{
				return default(PlatformMask);
			}
			[Cpp2IlInjected.Token(Token = "0x60006B1")]
			[Cpp2IlInjected.Address(RVA = "0xAC1D40", Offset = "0xAC0B40", VA = "0x180AC1D40")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170002CA")]
		public bool RequiresMonetizationEnabled
		{
			[Cpp2IlInjected.Token(Token = "0x60006B2")]
			[Cpp2IlInjected.Address(RVA = "0x1324960", Offset = "0x1323760", VA = "0x181324960")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x60006B3")]
			[Cpp2IlInjected.Address(RVA = "0x16701F0", Offset = "0x166EFF0", VA = "0x1816701F0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170002CB")]
		public bool RequiresPublishingEnabled
		{
			[Cpp2IlInjected.Token(Token = "0x60006B4")]
			[Cpp2IlInjected.Address(RVA = "0x209AB00", Offset = "0x2099900", VA = "0x18209AB00")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x60006B5")]
			[Cpp2IlInjected.Address(RVA = "0x209AAF0", Offset = "0x20998F0", VA = "0x18209AAF0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170002CC")]
		public string ShortText
		{
			[Cpp2IlInjected.Token(Token = "0x60006B6")]
			[Cpp2IlInjected.Address(RVA = "0xAC0D20", Offset = "0xABFB20", VA = "0x180AC0D20", Slot = "5")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60006B7")]
			[Cpp2IlInjected.Address(RVA = "0xAC0D10", Offset = "0xABFB10", VA = "0x180AC0D10")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170002CD")]
		public string TitleText
		{
			[Cpp2IlInjected.Token(Token = "0x60006B8")]
			[Cpp2IlInjected.Address(RVA = "0xAC1D20", Offset = "0xAC0B20", VA = "0x180AC1D20", Slot = "4")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60006B9")]
			[Cpp2IlInjected.Address(RVA = "0xAC0640", Offset = "0xABF440", VA = "0x180AC0640")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170002CE")]
		public string DetailedText
		{
			[Cpp2IlInjected.Token(Token = "0x60006BA")]
			[Cpp2IlInjected.Address(RVA = "0xAC0F90", Offset = "0xABFD90", VA = "0x180AC0F90", Slot = "6")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60006BB")]
			[Cpp2IlInjected.Address(RVA = "0xAC0650", Offset = "0xABF450", VA = "0x180AC0650")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170002CF")]
		public string CustomSpriteName
		{
			[Cpp2IlInjected.Token(Token = "0x60006BC")]
			[Cpp2IlInjected.Address(RVA = "0xAC0F80", Offset = "0xABFD80", VA = "0x180AC0F80", Slot = "7")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60006BD")]
			[Cpp2IlInjected.Address(RVA = "0xAC8C50", Offset = "0xAC7A50", VA = "0x180AC8C50")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170002D0")]
		public Dictionary<PlatformType, string> PlatformSpecificDetailedTexts
		{
			[Cpp2IlInjected.Token(Token = "0x60006BE")]
			[Cpp2IlInjected.Address(RVA = "0xAC0FC0", Offset = "0xABFDC0", VA = "0x180AC0FC0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60006BF")]
			[Cpp2IlInjected.Address(RVA = "0xAC0CF0", Offset = "0xABFAF0", VA = "0x180AC0CF0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60006C0")]
		[Cpp2IlInjected.Address(RVA = "0x1670200", Offset = "0x166F000", VA = "0x181670200")]
		public RRPlusBenefitDescriptionDto()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000FC")]
	[Utf8JsonSerializable]
	public class GetItemPurchaseInfosRequestDTO : IRecNetUtf8JsonObject
	{
		[Cpp2IlInjected.Token(Token = "0x170002D1")]
		public IReadOnlyList<UGCPurchasableItemIdentifier>? Ids
		{
			[Cpp2IlInjected.Token(Token = "0x60006C1")]
			[Cpp2IlInjected.Address(RVA = "0xABD130", Offset = "0xABBF30", VA = "0x180ABD130")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60006C2")]
			[Cpp2IlInjected.Address(RVA = "0xABD120", Offset = "0xABBF20", VA = "0x180ABD120")]
			[CompilerGenerated]
			internal set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60006C3")]
		[Cpp2IlInjected.Address(RVA = "0xAC4840", Offset = "0xAC3640", VA = "0x180AC4840")]
		public GetItemPurchaseInfosRequestDTO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60006C4")]
		[Cpp2IlInjected.Address(RVA = "0xACD980", Offset = "0xACC780", VA = "0x180ACD980")]
		public GetItemPurchaseInfosRequestDTO(IReadOnlyList<UGCPurchasableItemIdentifier>? ids)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60006C5")]
		[Cpp2IlInjected.Address(RVA = "0xABE8D0", Offset = "0xABD6D0", VA = "0x180ABE8D0", Slot = "4")]
		public void DNRPRHFLPRB()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000FD")]
	public enum GiftBoxContents
	{
		[Cpp2IlInjected.Token(Token = "0x4000482")]
		Unspecified = -1,
		[Cpp2IlInjected.Token(Token = "0x4000483")]
		XP,
		[Cpp2IlInjected.Token(Token = "0x4000484")]
		OutfitItem,
		[Cpp2IlInjected.Token(Token = "0x4000485")]
		Equipment,
		[Cpp2IlInjected.Token(Token = "0x4000486")]
		Currency,
		[Cpp2IlInjected.Token(Token = "0x4000487")]
		Consumable,
		[Cpp2IlInjected.Token(Token = "0x4000488")]
		Query,
		[Cpp2IlInjected.Token(Token = "0x4000489")]
		HairDye
	}
	[Cpp2IlInjected.Token(Token = "0x20000FE")]
	public interface XIVKWLCGGPQ
	{
		[Cpp2IlInjected.Token(Token = "0x170002D2")]
		Guid CustomAvatarItemId
		{
			[Cpp2IlInjected.Token(Token = "0x60006C6")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x170002D3")]
		ItemPurchaseMethodId? PurchaseMethodId
		{
			[Cpp2IlInjected.Token(Token = "0x60006C7")]
			[Cpp2IlInjected.Address(Slot = "1")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x170002D4")]
		List<PurchasablePrice>? Prices
		{
			[Cpp2IlInjected.Token(Token = "0x60006C8")]
			[Cpp2IlInjected.Address(Slot = "2")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x170002D5")]
		DateTime? NewUntil
		{
			[Cpp2IlInjected.Token(Token = "0x60006C9")]
			[Cpp2IlInjected.Address(Slot = "3")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x170002D6")]
		DateTime? AvailableAt
		{
			[Cpp2IlInjected.Token(Token = "0x60006CA")]
			[Cpp2IlInjected.Address(Slot = "4")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x170002D7")]
		DateTime? AvailableUntil
		{
			[Cpp2IlInjected.Token(Token = "0x60006CB")]
			[Cpp2IlInjected.Address(Slot = "5")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x170002D8")]
		bool CanBeGifted
		{
			[Cpp2IlInjected.Token(Token = "0x60006CC")]
			[Cpp2IlInjected.Address(Slot = "6")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x170002D9")]
		bool SubscribersOnly
		{
			[Cpp2IlInjected.Token(Token = "0x60006CD")]
			[Cpp2IlInjected.Address(Slot = "7")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x170002DA")]
		bool IsFeatured
		{
			[Cpp2IlInjected.Token(Token = "0x60006CE")]
			[Cpp2IlInjected.Address(Slot = "8")]
			get;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000FF")]
	public interface SIZHLAFQMAI
	{
		[Cpp2IlInjected.Token(Token = "0x1400000A")]
		event Action ACPZWGMJRUE;

		[Cpp2IlInjected.Token(Token = "0x60006D1")]
		[Cpp2IlInjected.Address(Slot = "2")]
		Task PKHWZPOXHPR(CancellationToken a);

		[Cpp2IlInjected.Token(Token = "0x60006D2")]
		[Cpp2IlInjected.Address(Slot = "3")]
		Task TLCZQYHZDCJ(CancellationToken a);

		[Cpp2IlInjected.Token(Token = "0x60006D3")]
		[Cpp2IlInjected.Address(Slot = "4")]
		bool MACTFXOHXWO([Out] TWQVJEECKVS a);
	}
	[Cpp2IlInjected.Token(Token = "0x2000100")]
	public interface TWQVJEECKVS
	{
		[Cpp2IlInjected.Token(Token = "0x170002DB")]
		string GICFEGVCUAO
		{
			[Cpp2IlInjected.Token(Token = "0x60006D4")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x170002DC")]
		string ARFOWRNLWJN
		{
			[Cpp2IlInjected.Token(Token = "0x60006D5")]
			[Cpp2IlInjected.Address(Slot = "1")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x170002DD")]
		IReadOnlyDictionary<BenefitListType, IReadOnlyList<NFCRWBWZFXT>> ADUSLBOZXND
		{
			[Cpp2IlInjected.Token(Token = "0x60006D6")]
			[Cpp2IlInjected.Address(Slot = "2")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x170002DE")]
		IReadOnlyDictionary<string, string> LSBIEVPUCIF
		{
			[Cpp2IlInjected.Token(Token = "0x60006D7")]
			[Cpp2IlInjected.Address(Slot = "3")]
			get;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000101")]
	public interface NFCRWBWZFXT
	{
		[Cpp2IlInjected.Token(Token = "0x170002DF")]
		string TitleText
		{
			[Cpp2IlInjected.Token(Token = "0x60006D8")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x170002E0")]
		string ShortText
		{
			[Cpp2IlInjected.Token(Token = "0x60006D9")]
			[Cpp2IlInjected.Address(Slot = "1")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x170002E1")]
		string DetailedText
		{
			[Cpp2IlInjected.Token(Token = "0x60006DA")]
			[Cpp2IlInjected.Address(Slot = "2")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x170002E2")]
		string CustomSpriteName
		{
			[Cpp2IlInjected.Token(Token = "0x60006DB")]
			[Cpp2IlInjected.Address(Slot = "3")]
			get;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000102")]
	public interface NSVNCQQULFO
	{
		[Cpp2IlInjected.Token(Token = "0x170002E3")]
		UnifiedItemType ItemType
		{
			[Cpp2IlInjected.Token(Token = "0x60006DC")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x170002E4")]
		string Id
		{
			[Cpp2IlInjected.Token(Token = "0x60006DD")]
			[Cpp2IlInjected.Address(Slot = "1")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x170002E5")]
		string FriendlyName
		{
			[Cpp2IlInjected.Token(Token = "0x60006DE")]
			[Cpp2IlInjected.Address(Slot = "2")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x170002E6")]
		string ThumbnailImageFilename
		{
			[Cpp2IlInjected.Token(Token = "0x60006DF")]
			[Cpp2IlInjected.Address(Slot = "3")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x170002E7")]
		bool IsFeatured
		{
			[Cpp2IlInjected.Token(Token = "0x60006E0")]
			[Cpp2IlInjected.Address(Slot = "4")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x170002E8")]
		bool SubscribersOnly
		{
			[Cpp2IlInjected.Token(Token = "0x60006E1")]
			[Cpp2IlInjected.Address(Slot = "5")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x170002E9")]
		GiftRarity Rarity
		{
			[Cpp2IlInjected.Token(Token = "0x60006E2")]
			[Cpp2IlInjected.Address(Slot = "6")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x170002EA")]
		string ConsumableItemDesc
		{
			[Cpp2IlInjected.Token(Token = "0x60006E3")]
			[Cpp2IlInjected.Address(Slot = "7")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x170002EB")]
		AvatarItemType? AvatarItemType
		{
			[Cpp2IlInjected.Token(Token = "0x60006E4")]
			[Cpp2IlInjected.Address(Slot = "8")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x170002EC")]
		GiftBoxContents GiftBoxContent
		{
			[Cpp2IlInjected.Token(Token = "0x60006E5")]
			[Cpp2IlInjected.Address(Slot = "9")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x170002ED")]
		bool IsQueryGiftDrop
		{
			[Cpp2IlInjected.Token(Token = "0x60006E6")]
			[Cpp2IlInjected.Address(Slot = "10")]
			get;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000103")]
	[Utf8JsonSerializable]
	public class ItemPurchaseMethodId : IRecNetUtf8JsonObject, IEquatable<ItemPurchaseMethodId>
	{
		[Cpp2IlInjected.Token(Token = "0x170002EE")]
		public UnifiedItemType Type
		{
			[Cpp2IlInjected.Token(Token = "0x60006E7")]
			[Cpp2IlInjected.Address(RVA = "0xABD110", Offset = "0xABBF10", VA = "0x180ABD110")]
			[CompilerGenerated]
			get
			{
				return default(UnifiedItemType);
			}
			[Cpp2IlInjected.Token(Token = "0x60006E8")]
			[Cpp2IlInjected.Address(RVA = "0xAC1D40", Offset = "0xAC0B40", VA = "0x180AC1D40")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170002EF")]
		public int? NumberId
		{
			[Cpp2IlInjected.Token(Token = "0x60006E9")]
			[Cpp2IlInjected.Address(RVA = "0x13E8E30", Offset = "0x13E7C30", VA = "0x1813E8E30")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60006EA")]
			[Cpp2IlInjected.Address(RVA = "0x13EA240", Offset = "0x13E9040", VA = "0x1813EA240")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170002F0")]
		public Guid? Guid
		{
			[Cpp2IlInjected.Token(Token = "0x60006EB")]
			[Cpp2IlInjected.Address(RVA = "0xAC8190", Offset = "0xAC6F90", VA = "0x180AC8190")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60006EC")]
			[Cpp2IlInjected.Address(RVA = "0xAC7B30", Offset = "0xAC6930", VA = "0x180AC7B30")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60006ED")]
		[Cpp2IlInjected.Address(RVA = "0x7A5DB10", Offset = "0x7A5C910", VA = "0x187A5DB10")]
		public static ItemPurchaseMethodId YRRQLUSSCOW(int a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60006EE")]
		[Cpp2IlInjected.Address(RVA = "0x7A5D520", Offset = "0x7A5C320", VA = "0x187A5D520")]
		public static ItemPurchaseMethodId BNBQDTNZUGG(Guid a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60006EF")]
		[Cpp2IlInjected.Address(RVA = "0x7A5D920", Offset = "0x7A5C720", VA = "0x187A5D920")]
		public static ItemPurchaseMethodId IAVDHLETFKN(UnifiedItemId a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60006F0")]
		[Cpp2IlInjected.Address(RVA = "0xABE8D0", Offset = "0xABD6D0", VA = "0x180ABE8D0", Slot = "4")]
		public void DNRPRHFLPRB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60006F1")]
		[Cpp2IlInjected.Address(RVA = "0x7A5D790", Offset = "0x7A5C590", VA = "0x187A5D790", Slot = "5")]
		public bool Equals(ItemPurchaseMethodId? other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60006F2")]
		[Cpp2IlInjected.Address(RVA = "0x7A5D5E0", Offset = "0x7A5C3E0", VA = "0x187A5D5E0", Slot = "0")]
		public override bool Equals(object? obj)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60006F3")]
		[Cpp2IlInjected.Address(RVA = "0x7A5D880", Offset = "0x7A5C680", VA = "0x187A5D880", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[SpecialName]
		[Cpp2IlInjected.Token(Token = "0x60006F4")]
		[Cpp2IlInjected.Address(RVA = "0x1580560", Offset = "0x157F360", VA = "0x181580560")]
		public static bool GFBRUTYEXQF(ItemPurchaseMethodId? a, ItemPurchaseMethodId? b)
		{
			return default(bool);
		}

		[SpecialName]
		[Cpp2IlInjected.Token(Token = "0x60006F5")]
		[Cpp2IlInjected.Address(RVA = "0x1580260", Offset = "0x157F060", VA = "0x181580260")]
		public static bool CQBJVGKOTGK(ItemPurchaseMethodId? a, ItemPurchaseMethodId? b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60006F6")]
		[Cpp2IlInjected.Address(RVA = "0xAC4840", Offset = "0xAC3640", VA = "0x180AC4840")]
		public ItemPurchaseMethodId()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000104")]
	public enum UnifiedItemType
	{
		[Cpp2IlInjected.Token(Token = "0x400048E")]
		PurchasableItem,
		[Cpp2IlInjected.Token(Token = "0x400048F")]
		CustomAvatarItem
	}
	[Cpp2IlInjected.Token(Token = "0x2000105")]
	[Utf8JsonSerializable]
	public class PurchasablePrice : IRecNetUtf8JsonObject
	{
		[Cpp2IlInjected.Token(Token = "0x170002F1")]
		public CurrencyType CurrencyType
		{
			[Cpp2IlInjected.Token(Token = "0x60006F7")]
			[Cpp2IlInjected.Address(RVA = "0xABD110", Offset = "0xABBF10", VA = "0x180ABD110")]
			[CompilerGenerated]
			get
			{
				return default(CurrencyType);
			}
			[Cpp2IlInjected.Token(Token = "0x60006F8")]
			[Cpp2IlInjected.Address(RVA = "0xAC1D40", Offset = "0xAC0B40", VA = "0x180AC1D40")]
			[CompilerGenerated]
			internal set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170002F2")]
		public int Price
		{
			[Cpp2IlInjected.Token(Token = "0x60006F9")]
			[Cpp2IlInjected.Address(RVA = "0xBBC350", Offset = "0xBBB150", VA = "0x180BBC350")]
			[CompilerGenerated]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x60006FA")]
			[Cpp2IlInjected.Address(RVA = "0xBBC340", Offset = "0xBBB140", VA = "0x180BBC340")]
			[CompilerGenerated]
			internal set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170002F3")]
		public StorefrontSaleData StorefrontSaleData
		{
			[Cpp2IlInjected.Token(Token = "0x60006FB")]
			[Cpp2IlInjected.Address(RVA = "0xAC0D20", Offset = "0xABFB20", VA = "0x180AC0D20")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60006FC")]
			[Cpp2IlInjected.Address(RVA = "0xAC0D10", Offset = "0xABFB10", VA = "0x180AC0D10")]
			[CompilerGenerated]
			internal set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60006FD")]
		[Cpp2IlInjected.Address(RVA = "0x1091BE0", Offset = "0x10909E0", VA = "0x181091BE0", Slot = "4")]
		public void DNRPRHFLPRB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60006FE")]
		[Cpp2IlInjected.Address(RVA = "0x7A5F630", Offset = "0x7A5E430", VA = "0x187A5F630")]
		public int OTWMPPGHZNE(DateTime a)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60006FF")]
		[Cpp2IlInjected.Address(RVA = "0xAC4840", Offset = "0xAC3640", VA = "0x180AC4840")]
		public PurchasablePrice()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000106")]
	[Utf8JsonSerializable]
	public class StorefrontSaleData : IRecNetUtf8JsonObject
	{
		[Cpp2IlInjected.Token(Token = "0x170002F4")]
		public int SalePercent
		{
			[Cpp2IlInjected.Token(Token = "0x6000700")]
			[Cpp2IlInjected.Address(RVA = "0xABD110", Offset = "0xABBF10", VA = "0x180ABD110")]
			[CompilerGenerated]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x6000701")]
			[Cpp2IlInjected.Address(RVA = "0xAC1D40", Offset = "0xAC0B40", VA = "0x180AC1D40")]
			[CompilerGenerated]
			internal set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170002F5")]
		public DateTime? SaleStartDate
		{
			[Cpp2IlInjected.Token(Token = "0x6000702")]
			[Cpp2IlInjected.Address(RVA = "0xBED410", Offset = "0xBEC210", VA = "0x180BED410")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000703")]
			[Cpp2IlInjected.Address(RVA = "0xF76460", Offset = "0xF75260", VA = "0x180F76460")]
			[CompilerGenerated]
			internal set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170002F6")]
		public DateTime? SaleEndDate
		{
			[Cpp2IlInjected.Token(Token = "0x6000704")]
			[Cpp2IlInjected.Address(RVA = "0x143F690", Offset = "0x143E490", VA = "0x18143F690")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000705")]
			[Cpp2IlInjected.Address(RVA = "0x159EF20", Offset = "0x159DD20", VA = "0x18159EF20")]
			[CompilerGenerated]
			internal set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000706")]
		[Cpp2IlInjected.Address(RVA = "0xABE8D0", Offset = "0xABD6D0", VA = "0x180ABE8D0", Slot = "4")]
		public void DNRPRHFLPRB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000707")]
		[Cpp2IlInjected.Address(RVA = "0x7A61B80", Offset = "0x7A60980", VA = "0x187A61B80")]
		public bool FXOSONGPFFP(DateTime a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000708")]
		[Cpp2IlInjected.Address(RVA = "0x7A61C70", Offset = "0x7A60A70", VA = "0x187A61C70")]
		public int OCTHKCEFEEJ(DateTime a)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000709")]
		[Cpp2IlInjected.Address(RVA = "0x7A61CA0", Offset = "0x7A60AA0", VA = "0x187A61CA0")]
		public TimeSpan? YFXQCGVTGZH(DateTime a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600070A")]
		[Cpp2IlInjected.Address(RVA = "0xAC4840", Offset = "0xAC3640", VA = "0x180AC4840")]
		public StorefrontSaleData()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000107")]
	public enum StorefrontTypes
	{
		[Cpp2IlInjected.Token(Token = "0x4000497")]
		None = 0,
		[Cpp2IlInjected.Token(Token = "0x4000498")]
		LaserTag = 1,
		[Cpp2IlInjected.Token(Token = "0x4000499")]
		RecCenter = 2,
		[Cpp2IlInjected.Token(Token = "0x400049A")]
		Watch = 3,
		[Cpp2IlInjected.Token(Token = "0x400049B")]
		Quest_LostSkulls = 100,
		[Cpp2IlInjected.Token(Token = "0x400049C")]
		Quest_Dracula = 101,
		[Cpp2IlInjected.Token(Token = "0x400049D")]
		Quest_GoldenTrophy = 102,
		[Cpp2IlInjected.Token(Token = "0x400049E")]
		Quest_CrimsonCauldron = 103,
		[Cpp2IlInjected.Token(Token = "0x400049F")]
		RecRoyale = 200,
		[Cpp2IlInjected.Token(Token = "0x40004A0")]
		Cafe = 300,
		[Cpp2IlInjected.Token(Token = "0x40004A1")]
		Paintball = 400,
		[Cpp2IlInjected.Token(Token = "0x40004A2")]
		Paintball_River = 401,
		[Cpp2IlInjected.Token(Token = "0x40004A3")]
		Paintball_Homestead = 402,
		[Cpp2IlInjected.Token(Token = "0x40004A4")]
		Paintball_Quarry = 403,
		[Cpp2IlInjected.Token(Token = "0x40004A5")]
		Paintball_ClearCut = 404,
		[Cpp2IlInjected.Token(Token = "0x40004A6")]
		Paintball_Spillway = 405,
		[Cpp2IlInjected.Token(Token = "0x40004A7")]
		Paintball_SunsetDriveIn = 406,
		[Cpp2IlInjected.Token(Token = "0x40004A8")]
		Bowling = 500,
		[Cpp2IlInjected.Token(Token = "0x40004A9")]
		StuntRunner = 600,
		[Cpp2IlInjected.Token(Token = "0x40004AA")]
		DormMirror = 700,
		[Cpp2IlInjected.Token(Token = "0x40004AB")]
		InventionStore = 800,
		[Cpp2IlInjected.Token(Token = "0x40004AC")]
		RoomKeys = 900,
		[Cpp2IlInjected.Token(Token = "0x40004AD")]
		Player_Profile = 1000,
		[Cpp2IlInjected.Token(Token = "0x40004AE")]
		Room_Save = 1100,
		[Cpp2IlInjected.Token(Token = "0x40004AF")]
		RoomCurrencies = 1200,
		[Cpp2IlInjected.Token(Token = "0x40004B0")]
		Wishlist = 1300,
		[Cpp2IlInjected.Token(Token = "0x40004B1")]
		Friendotron = 1400,
		[Cpp2IlInjected.Token(Token = "0x40004B2")]
		RoomConsumables = 1500,
		[Cpp2IlInjected.Token(Token = "0x40004B3")]
		RecRally = 1600,
		[Cpp2IlInjected.Token(Token = "0x40004B4")]
		PopUpShop_1 = 1700,
		[Cpp2IlInjected.Token(Token = "0x40004B5")]
		PopUpShop_2 = 1701,
		[Cpp2IlInjected.Token(Token = "0x40004B6")]
		PopUpShop_3 = 1702,
		[Cpp2IlInjected.Token(Token = "0x40004B7")]
		PopUpShop_4 = 1703,
		[Cpp2IlInjected.Token(Token = "0x40004B8")]
		PopUpShop_5 = 1704,
		[Cpp2IlInjected.Token(Token = "0x40004B9")]
		PopUpShop_6 = 1705,
		[Cpp2IlInjected.Token(Token = "0x40004BA")]
		PopUpShop_7 = 1706,
		[Cpp2IlInjected.Token(Token = "0x40004BB")]
		PopUpShop_8 = 1707,
		[Cpp2IlInjected.Token(Token = "0x40004BC")]
		PopUpShop_9 = 1708,
		[Cpp2IlInjected.Token(Token = "0x40004BD")]
		PopUpShop_10 = 1709,
		[Cpp2IlInjected.Token(Token = "0x40004BE")]
		PopUpShop_11 = 1710,
		[Cpp2IlInjected.Token(Token = "0x40004BF")]
		PopUpShop_12 = 1711,
		[Cpp2IlInjected.Token(Token = "0x40004C0")]
		PopUpShop_13 = 1712,
		[Cpp2IlInjected.Token(Token = "0x40004C1")]
		PopUpShop_14 = 1713,
		[Cpp2IlInjected.Token(Token = "0x40004C2")]
		PopUpShop_15 = 1714,
		[Cpp2IlInjected.Token(Token = "0x40004C3")]
		PopUpShop_16 = 1715,
		[Cpp2IlInjected.Token(Token = "0x40004C4")]
		PopUpShop_17 = 1716,
		[Cpp2IlInjected.Token(Token = "0x40004C5")]
		PopUpShop_18 = 1717,
		[Cpp2IlInjected.Token(Token = "0x40004C6")]
		PopUpShop_19 = 1718,
		[Cpp2IlInjected.Token(Token = "0x40004C7")]
		PopUpShop_20 = 1719,
		[Cpp2IlInjected.Token(Token = "0x40004C8")]
		CustomAvatarItems = 1800,
		[Cpp2IlInjected.Token(Token = "0x40004C9")]
		ProgressionEventPurchasableXpBoosts = 1900,
		[Cpp2IlInjected.Token(Token = "0x40004CA")]
		PopUpShop_ProgressionEvent_1 = 2000,
		[Cpp2IlInjected.Token(Token = "0x40004CB")]
		PopUpShop_ProgressionEvent_2 = 2001,
		[Cpp2IlInjected.Token(Token = "0x40004CC")]
		PopUpShop_ProgressionEvent_3 = 2002,
		[Cpp2IlInjected.Token(Token = "0x40004CD")]
		PopUpShop_ProgressionEvent_4 = 2003,
		[Cpp2IlInjected.Token(Token = "0x40004CE")]
		PopUpShop_ProgressionEvent_5 = 2004,
		[Cpp2IlInjected.Token(Token = "0x40004CF")]
		RoomOffers = 2100,
		[Cpp2IlInjected.Token(Token = "0x40004D0")]
		MyLittleMonsters = 2200,
		[Cpp2IlInjected.Token(Token = "0x40004D1")]
		Destiny = 2201,
		[Cpp2IlInjected.Token(Token = "0x40004D2")]
		RunTheBlock = 2202,
		[Cpp2IlInjected.Token(Token = "0x40004D3")]
		RROStorefront_ToBeNamed_2 = 2203,
		[Cpp2IlInjected.Token(Token = "0x40004D4")]
		DevStorefront_DoNotAddToWatch_1 = 2300,
		[Cpp2IlInjected.Token(Token = "0x40004D5")]
		DevStorefront_DoNotAddToWatch_2 = 2301,
		[Cpp2IlInjected.Token(Token = "0x40004D6")]
		DevStorefront_DoNotAddToWatch_3 = 2302,
		[Cpp2IlInjected.Token(Token = "0x40004D7")]
		DevStorefront_DoNotAddToWatch_4 = 2303,
		[Cpp2IlInjected.Token(Token = "0x40004D8")]
		DevStorefront_DoNotAddToWatch_5 = 2304
	}
	[Cpp2IlInjected.Token(Token = "0x2000108")]
	public enum PurchasableItemType
	{
		[Cpp2IlInjected.Token(Token = "0x40004DA")]
		GiftDrop,
		[Cpp2IlInjected.Token(Token = "0x40004DB")]
		SeasonTier,
		[Cpp2IlInjected.Token(Token = "0x40004DC")]
		SeasonEliteUpgrade
	}
	[Cpp2IlInjected.Token(Token = "0x2000109")]
	public enum StorefrontBalanceAddTypes
	{
		[Cpp2IlInjected.Token(Token = "0x40004DE")]
		Invalid = 0,
		[Cpp2IlInjected.Token(Token = "0x40004DF")]
		DirectBalanceWithMultiplier = 1,
		[Cpp2IlInjected.Token(Token = "0x40004E0")]
		FromGiftBox = 2,
		[Cpp2IlInjected.Token(Token = "0x40004E1")]
		NUXChallenge = 10,
		[Cpp2IlInjected.Token(Token = "0x40004E2")]
		AllNUXChallenges = 11,
		[Cpp2IlInjected.Token(Token = "0x40004E3")]
		DailyChallenge = 100,
		[Cpp2IlInjected.Token(Token = "0x40004E4")]
		AllDailyChallenges = 101,
		[Cpp2IlInjected.Token(Token = "0x40004E5")]
		FinishActivity = 200,
		[Cpp2IlInjected.Token(Token = "0x40004E6")]
		RecRoyaleMatchFinished = 250,
		[Cpp2IlInjected.Token(Token = "0x40004E7")]
		ChecklistCredit = 303,
		[Cpp2IlInjected.Token(Token = "0x40004E8")]
		WonGame = 1000,
		[Cpp2IlInjected.Token(Token = "0x40004E9")]
		LostGame = 1001,
		[Cpp2IlInjected.Token(Token = "0x40004EA")]
		WonGameRateLimited = 1002,
		[Cpp2IlInjected.Token(Token = "0x40004EB")]
		WonGamePartial = 1003,
		[Cpp2IlInjected.Token(Token = "0x40004EC")]
		LevelUp = 1100,
		[Cpp2IlInjected.Token(Token = "0x40004ED")]
		Registered = 1200,
		[Cpp2IlInjected.Token(Token = "0x40004EE")]
		CreatorReward = 1300,
		[Cpp2IlInjected.Token(Token = "0x40004EF")]
		CommercePurchase = 1400,
		[Cpp2IlInjected.Token(Token = "0x40004F0")]
		CommercePurchaseRevoked = 1401,
		[Cpp2IlInjected.Token(Token = "0x40004F1")]
		Manual_Refund = 2000,
		[Cpp2IlInjected.Token(Token = "0x40004F2")]
		Manual_Thanks = 2010,
		[Cpp2IlInjected.Token(Token = "0x40004F3")]
		Manual_Apology = 2020,
		[Cpp2IlInjected.Token(Token = "0x40004F4")]
		TestOnly = 8000
	}
	[Cpp2IlInjected.Token(Token = "0x200010A")]
	public enum RateLimitTypes
	{
		[Cpp2IlInjected.Token(Token = "0x40004F6")]
		Interval,
		[Cpp2IlInjected.Token(Token = "0x40004F7")]
		PerDay
	}
	[Cpp2IlInjected.Token(Token = "0x200010B")]
	public enum Discount
	{
		[Cpp2IlInjected.Token(Token = "0x40004F9")]
		PERCENTAGE = 1,
		[Cpp2IlInjected.Token(Token = "0x40004FA")]
		EXACT_AMOUNT
	}
	[Cpp2IlInjected.Token(Token = "0x200010C")]
	[Utf8JsonSerializable]
	public class SkuPurchaseMetadata : IEquatable<SkuPurchaseMetadata>
	{
		[Cpp2IlInjected.Token(Token = "0x170002F7")]
		public int? PurchaseReminderId
		{
			[Cpp2IlInjected.Token(Token = "0x600070B")]
			[Cpp2IlInjected.Address(RVA = "0xABD130", Offset = "0xABBF30", VA = "0x180ABD130")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600070C")]
			[Cpp2IlInjected.Address(RVA = "0xEABA00", Offset = "0xEAA800", VA = "0x180EABA00")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170002F8")]
		public int? PurchaseCampaignId
		{
			[Cpp2IlInjected.Token(Token = "0x600070D")]
			[Cpp2IlInjected.Address(RVA = "0xAC0D20", Offset = "0xABFB20", VA = "0x180AC0D20")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600070E")]
			[Cpp2IlInjected.Address(RVA = "0xE27A80", Offset = "0xE26880", VA = "0x180E27A80")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170002F9")]
		public int? RRPlusSignUpBonusId
		{
			[Cpp2IlInjected.Token(Token = "0x600070F")]
			[Cpp2IlInjected.Address(RVA = "0xAC1D20", Offset = "0xAC0B20", VA = "0x180AC1D20")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000710")]
			[Cpp2IlInjected.Address(RVA = "0xE33D40", Offset = "0xE32B40", VA = "0x180E33D40")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170002FA")]
		public List<ItemPurchaseMethodId>? BonusPurchasableItemIds
		{
			[Cpp2IlInjected.Token(Token = "0x6000711")]
			[Cpp2IlInjected.Address(RVA = "0xAC0F90", Offset = "0xABFD90", VA = "0x180AC0F90")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000712")]
			[Cpp2IlInjected.Address(RVA = "0xAC0650", Offset = "0xABF450", VA = "0x180AC0650")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000713")]
		[Cpp2IlInjected.Address(RVA = "0x7A619A0", Offset = "0x7A607A0", VA = "0x187A619A0", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000714")]
		[Cpp2IlInjected.Address(RVA = "0x7A61320", Offset = "0x7A60120", VA = "0x187A61320")]
		public static SkuPurchaseMetadata BHVCAWKAKWY(int? a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000715")]
		[Cpp2IlInjected.Address(RVA = "0x7A61380", Offset = "0x7A60180", VA = "0x187A61380", Slot = "4")]
		public bool Equals(SkuPurchaseMetadata? other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000716")]
		[Cpp2IlInjected.Address(RVA = "0x7A61900", Offset = "0x7A60700", VA = "0x187A61900")]
		private static bool JDFIJEOBRYE(List<ItemPurchaseMethodId>? a, List<ItemPurchaseMethodId>? b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000717")]
		[Cpp2IlInjected.Address(RVA = "0x7A61500", Offset = "0x7A60300", VA = "0x187A61500", Slot = "0")]
		public override bool Equals(object? obj)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000718")]
		[Cpp2IlInjected.Address(RVA = "0x7A61720", Offset = "0x7A60520", VA = "0x187A61720", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000719")]
		[Cpp2IlInjected.Address(RVA = "0xAC4840", Offset = "0xAC3640", VA = "0x180AC4840")]
		public SkuPurchaseMetadata()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200010D")]
	public struct UnifiedItemId : IEquatable<UnifiedItemId>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40004FF")]
		public readonly UnifiedItemType ItemType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x4000500")]
		private readonly int NumberId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000501")]
		private readonly Guid Guid;

		[Cpp2IlInjected.Token(Token = "0x170002FB")]
		public Guid UXISWGECOPF
		{
			[Cpp2IlInjected.Token(Token = "0x600071A")]
			[Cpp2IlInjected.Address(RVA = "0x7A64730", Offset = "0x7A63530", VA = "0x187A64730")]
			get
			{
				return default(Guid);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170002FC")]
		public int LSEPLWRJPXZ
		{
			[Cpp2IlInjected.Token(Token = "0x600071B")]
			[Cpp2IlInjected.Address(RVA = "0x7A64C70", Offset = "0x7A63A70", VA = "0x187A64C70")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170002FD")]
		public string AMMWJGPCQBL
		{
			[Cpp2IlInjected.Token(Token = "0x600071C")]
			[Cpp2IlInjected.Address(RVA = "0x7A64C30", Offset = "0x7A63A30", VA = "0x187A64C30")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600071D")]
		[Cpp2IlInjected.Address(RVA = "0x7A647A0", Offset = "0x7A635A0", VA = "0x187A647A0")]
		public static bool JWCZNXMOHLN(string a, [Out] UnifiedItemId b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600071E")]
		[Cpp2IlInjected.Address(RVA = "0x7A642A0", Offset = "0x7A630A0", VA = "0x187A642A0")]
		public static bool GDIUADRLWNE(string a, [Out] UnifiedItemId b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600071F")]
		[Cpp2IlInjected.Address(RVA = "0x7A64C80", Offset = "0x7A63A80", VA = "0x187A64C80")]
		public static UnifiedItemId ZVWKPSVQSUX(int a)
		{
			return default(UnifiedItemId);
		}

		[Cpp2IlInjected.Token(Token = "0x6000720")]
		[Cpp2IlInjected.Address(RVA = "0x7A645F0", Offset = "0x7A633F0", VA = "0x187A645F0")]
		public static UnifiedItemId HMIGSCLAWIP(Guid a)
		{
			return default(UnifiedItemId);
		}

		[Cpp2IlInjected.Token(Token = "0x6000721")]
		[Cpp2IlInjected.Address(RVA = "0x7A64040", Offset = "0x7A62E40", VA = "0x187A64040")]
		private static bool CZZTMNNOJVS(string a, [Out] UnifiedItemType b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000722")]
		[Cpp2IlInjected.Address(RVA = "0x7A64DB0", Offset = "0x7A63BB0", VA = "0x187A64DB0")]
		private UnifiedItemId(UnifiedItemType itemType, int? purchasableGiftDropId, Guid? customAvatarItemId)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000723")]
		[Cpp2IlInjected.Address(RVA = "0x7A64130", Offset = "0x7A62F30", VA = "0x187A64130", Slot = "4")]
		public bool Equals(UnifiedItemId other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000724")]
		[Cpp2IlInjected.Address(RVA = "0x7A641A0", Offset = "0x7A62FA0", VA = "0x187A641A0", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000725")]
		[Cpp2IlInjected.Address(RVA = "0x7A64560", Offset = "0x7A63360", VA = "0x187A64560", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000726")]
		[Cpp2IlInjected.Address(RVA = "0x7A64BA0", Offset = "0x7A639A0", VA = "0x187A64BA0", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200010E")]
	[Utf8JsonSerializable]
	public abstract class UGCPurchasableIdentifier : IEquatable<UGCPurchasableIdentifier>, IRecNetUtf8JsonObject
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000502")]
		public Guid itemId;

		[Cpp2IlInjected.Token(Token = "0x6000727")]
		[Cpp2IlInjected.Address(RVA = "0x7A63BB0", Offset = "0x7A629B0", VA = "0x187A63BB0", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000728")]
		[Cpp2IlInjected.Address(RVA = "0x7A63B30", Offset = "0x7A62930", VA = "0x187A63B30", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000729")]
		[Cpp2IlInjected.Address(RVA = "0x7A60630", Offset = "0x7A5F430", VA = "0x187A60630", Slot = "4")]
		public bool Equals(UGCPurchasableIdentifier other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600072A")]
		[Cpp2IlInjected.Address(RVA = "0x7A63A20", Offset = "0x7A62820", VA = "0x187A63A20", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600072B")]
		[Cpp2IlInjected.Address(RVA = "0xABE8D0", Offset = "0xABD6D0", VA = "0x180ABE8D0", Slot = "5")]
		public void DNRPRHFLPRB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600072C")]
		[Cpp2IlInjected.Address(Slot = "6")]
		public abstract UGCPurchasableIdentifier Clone();

		[Cpp2IlInjected.Token(Token = "0x600072D")]
		[Cpp2IlInjected.Address(RVA = "0xAC4840", Offset = "0xAC3640", VA = "0x180AC4840")]
		protected UGCPurchasableIdentifier()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200010F")]
	public enum UGCPurchasableItemType
	{
		[Cpp2IlInjected.Token(Token = "0x4000504")]
		RoomKey,
		[Cpp2IlInjected.Token(Token = "0x4000505")]
		RoomConsumable,
		[Cpp2IlInjected.Token(Token = "0x4000506")]
		RoomCurrencyPurchaseOffer,
		[Cpp2IlInjected.Token(Token = "0x4000507")]
		CustomAvatarItem,
		[Cpp2IlInjected.Token(Token = "0x4000508")]
		StoreUGCAvatarItem,
		[Cpp2IlInjected.Token(Token = "0x4000509")]
		RoomOffer,
		[Cpp2IlInjected.Token(Token = "0x400050A")]
		UNDEFINED
	}
	[Cpp2IlInjected.Token(Token = "0x2000110")]
	[Utf8JsonSerializable]
	public class UGCPurchasableItemIdentifier : UGCPurchasableIdentifier, IEquatable<UGCPurchasableItemIdentifier>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400050B")]
		public UGCPurchasableItemType itemType;

		[Cpp2IlInjected.Token(Token = "0x600072E")]
		[Cpp2IlInjected.Address(RVA = "0x7A63DC0", Offset = "0x7A62BC0", VA = "0x187A63DC0", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600072F")]
		[Cpp2IlInjected.Address(RVA = "0x7A63CE0", Offset = "0x7A62AE0", VA = "0x187A63CE0", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000730")]
		[Cpp2IlInjected.Address(RVA = "0xAC4840", Offset = "0xAC3640", VA = "0x180AC4840")]
		public UGCPurchasableItemIdentifier()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000731")]
		[Cpp2IlInjected.Address(RVA = "0x7A63E50", Offset = "0x7A62C50", VA = "0x187A63E50")]
		public UGCPurchasableItemIdentifier(UGCPurchasableItemType itemType, Guid itemId)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000732")]
		[Cpp2IlInjected.Address(RVA = "0x7A63D60", Offset = "0x7A62B60", VA = "0x187A63D60")]
		public static UGCPurchasableItemIdentifier HMIGSCLAWIP(Guid a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000733")]
		[Cpp2IlInjected.Address(RVA = "0x7A63C90", Offset = "0x7A62A90", VA = "0x187A63C90", Slot = "7")]
		public bool Equals(UGCPurchasableItemIdentifier other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000734")]
		[Cpp2IlInjected.Address(RVA = "0x7A63C20", Offset = "0x7A62A20", VA = "0x187A63C20", Slot = "6")]
		public override UGCPurchasableIdentifier Clone()
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000111")]
	public static class HHQNKYQBLPK
	{
		[Cpp2IlInjected.Token(Token = "0x6000735")]
		[Cpp2IlInjected.Address(RVA = "0x7A5C270", Offset = "0x7A5B070", VA = "0x187A5C270")]
		public static UGCPurchasableItemIdentifier BLVAROODRXK(this UGCPurchasableItem a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000736")]
		[Cpp2IlInjected.Address(RVA = "0x7A5C350", Offset = "0x7A5B150", VA = "0x187A5C350")]
		public static UGCPurchasableItemIdentifier JVVTESJDXCW(string a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000737")]
		[Cpp2IlInjected.Address(RVA = "0x7A5C2E0", Offset = "0x7A5B0E0", VA = "0x187A5C2E0")]
		public static UGCPurchasableItemIdentifier GPIPADMLYBV(Guid a)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000112")]
	[Utf8JsonSerializable]
	public class UGCPurchasableItem : DGCGJUHCULN, IRecNetUtf8JsonObject
	{
		[Cpp2IlInjected.Token(Token = "0x170002FE")]
		public UGCPurchasableItemType ItemType
		{
			[Cpp2IlInjected.Token(Token = "0x6000738")]
			[Cpp2IlInjected.Address(RVA = "0xABD110", Offset = "0xABBF10", VA = "0x180ABD110")]
			[CompilerGenerated]
			get
			{
				return default(UGCPurchasableItemType);
			}
			[Cpp2IlInjected.Token(Token = "0x6000739")]
			[Cpp2IlInjected.Address(RVA = "0xAC1D40", Offset = "0xAC0B40", VA = "0x180AC1D40")]
			[CompilerGenerated]
			internal set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170002FF")]
		public Guid ItemId
		{
			[Cpp2IlInjected.Token(Token = "0x600073A")]
			[Cpp2IlInjected.Address(RVA = "0x1BF2010", Offset = "0x1BF0E10", VA = "0x181BF2010")]
			[CompilerGenerated]
			get
			{
				return default(Guid);
			}
			[Cpp2IlInjected.Token(Token = "0x600073B")]
			[Cpp2IlInjected.Address(RVA = "0x6140810", Offset = "0x613F610", VA = "0x186140810")]
			[CompilerGenerated]
			internal set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000300")]
		public string Name
		{
			[Cpp2IlInjected.Token(Token = "0x600073C")]
			[Cpp2IlInjected.Address(RVA = "0xAC0F90", Offset = "0xABFD90", VA = "0x180AC0F90")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600073D")]
			[Cpp2IlInjected.Address(RVA = "0xAC0650", Offset = "0xABF450", VA = "0x180AC0650")]
			[CompilerGenerated]
			internal set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000301")]
		public string Description
		{
			[Cpp2IlInjected.Token(Token = "0x600073E")]
			[Cpp2IlInjected.Address(RVA = "0xAC0F80", Offset = "0xABFD80", VA = "0x180AC0F80")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600073F")]
			[Cpp2IlInjected.Address(RVA = "0xAC8C50", Offset = "0xAC7A50", VA = "0x180AC8C50")]
			[CompilerGenerated]
			internal set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000302")]
		public string ImageName
		{
			[Cpp2IlInjected.Token(Token = "0x6000740")]
			[Cpp2IlInjected.Address(RVA = "0xAC0FC0", Offset = "0xABFDC0", VA = "0x180AC0FC0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000741")]
			[Cpp2IlInjected.Address(RVA = "0xAC0CF0", Offset = "0xABFAF0", VA = "0x180AC0CF0")]
			[CompilerGenerated]
			internal set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000303")]
		public long? RoomId
		{
			[Cpp2IlInjected.Token(Token = "0x6000742")]
			[Cpp2IlInjected.Address(RVA = "0x108B4B0", Offset = "0x108A2B0", VA = "0x18108B4B0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000743")]
			[Cpp2IlInjected.Address(RVA = "0x108B5F0", Offset = "0x108A3F0", VA = "0x18108B5F0")]
			[CompilerGenerated]
			internal set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000304")]
		public long Price
		{
			[Cpp2IlInjected.Token(Token = "0x6000744")]
			[Cpp2IlInjected.Address(RVA = "0xAC31E0", Offset = "0xAC1FE0", VA = "0x180AC31E0")]
			[CompilerGenerated]
			get
			{
				return default(long);
			}
			[Cpp2IlInjected.Token(Token = "0x6000745")]
			[Cpp2IlInjected.Address(RVA = "0xFDBE00", Offset = "0xFDAC00", VA = "0x180FDBE00")]
			[CompilerGenerated]
			internal set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000305")]
		public Guid? PurchaseCurrencyId
		{
			[Cpp2IlInjected.Token(Token = "0x6000746")]
			[Cpp2IlInjected.Address(RVA = "0x7A60590", Offset = "0x7A5F390", VA = "0x187A60590")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000747")]
			[Cpp2IlInjected.Address(RVA = "0x7A605B0", Offset = "0x7A5F3B0", VA = "0x187A605B0")]
			[CompilerGenerated]
			internal set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000306")]
		public DateTime CreatedAt
		{
			[Cpp2IlInjected.Token(Token = "0x6000748")]
			[Cpp2IlInjected.Address(RVA = "0xAC50D0", Offset = "0xAC3ED0", VA = "0x180AC50D0")]
			[CompilerGenerated]
			get
			{
				return default(DateTime);
			}
			[Cpp2IlInjected.Token(Token = "0x6000749")]
			[Cpp2IlInjected.Address(RVA = "0xFF2C50", Offset = "0xFF1A50", VA = "0x180FF2C50")]
			[CompilerGenerated]
			internal set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000307")]
		public DateTime ModifiedAt
		{
			[Cpp2IlInjected.Token(Token = "0x600074A")]
			[Cpp2IlInjected.Address(RVA = "0xAC8150", Offset = "0xAC6F50", VA = "0x180AC8150")]
			[CompilerGenerated]
			get
			{
				return default(DateTime);
			}
			[Cpp2IlInjected.Token(Token = "0x600074B")]
			[Cpp2IlInjected.Address(RVA = "0xFF2C40", Offset = "0xFF1A40", VA = "0x180FF2C40")]
			[CompilerGenerated]
			internal set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600074C")]
		[Cpp2IlInjected.Address(RVA = "0xAC4840", Offset = "0xAC3640", VA = "0x180AC4840")]
		public UGCPurchasableItem()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600074D")]
		[Cpp2IlInjected.Address(RVA = "0x7A63F40", Offset = "0x7A62D40", VA = "0x187A63F40")]
		public UGCPurchasableItem(UGCPurchasableItemType itemType, Guid itemId, [Optional] string name, [Optional] string description, [Optional] string imageName, [Optional] long? roomId, long price = 0L, [Optional] Guid? purchaseCurrencyId, [Optional] DateTime createdAt, [Optional] DateTime modifiedAt)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600074E")]
		[Cpp2IlInjected.Address(RVA = "0xABE8D0", Offset = "0xABD6D0", VA = "0x180ABE8D0", Slot = "4")]
		public void DNRPRHFLPRB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600074F")]
		[Cpp2IlInjected.Address(RVA = "0x7A63E90", Offset = "0x7A62C90", VA = "0x187A63E90", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}
}
namespace RecNet.ConsumableEffects.AvatarItemEffects
{
	[Cpp2IlInjected.Token(Token = "0x2000113")]
	public interface YGAKBOSJSEK
	{
		[Cpp2IlInjected.Token(Token = "0x17000308")]
		string Name
		{
			[Cpp2IlInjected.Token(Token = "0x6000750")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000114")]
	public interface YHOPTHDGBFP<out a> : YGAKBOSJSEK where a : struct
	{
		[Cpp2IlInjected.Token(Token = "0x17000309")]
		a Id
		{
			[Cpp2IlInjected.Token(Token = "0x6000751")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000115")]
	[Utf8JsonSerializable]
	public class AvatarEffectConfigDTO : IRecNetUtf8JsonObject
	{
		[Cpp2IlInjected.Token(Token = "0x1700030A")]
		public List<AvatarEffectKeyDTO> AvailableEffects
		{
			[Cpp2IlInjected.Token(Token = "0x6000752")]
			[Cpp2IlInjected.Address(RVA = "0xABD130", Offset = "0xABBF30", VA = "0x180ABD130")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000753")]
			[Cpp2IlInjected.Address(RVA = "0xABD120", Offset = "0xABBF20", VA = "0x180ABD120")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700030B")]
		public List<PotionBottleConfigDTO> PotionBottleOverrides
		{
			[Cpp2IlInjected.Token(Token = "0x6000754")]
			[Cpp2IlInjected.Address(RVA = "0xAC0D20", Offset = "0xABFB20", VA = "0x180AC0D20")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000755")]
			[Cpp2IlInjected.Address(RVA = "0xAC0D10", Offset = "0xABFB10", VA = "0x180AC0D10")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700030C")]
		public List<DriverTypeBottleConfigDTO> DriverTypeConfigs
		{
			[Cpp2IlInjected.Token(Token = "0x6000756")]
			[Cpp2IlInjected.Address(RVA = "0xAC1D20", Offset = "0xAC0B20", VA = "0x180AC1D20")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000757")]
			[Cpp2IlInjected.Address(RVA = "0xAC0640", Offset = "0xABF440", VA = "0x180AC0640")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700030D")]
		public List<AuraConfigDTO> AuraConfigs
		{
			[Cpp2IlInjected.Token(Token = "0x6000758")]
			[Cpp2IlInjected.Address(RVA = "0xAC0F90", Offset = "0xABFD90", VA = "0x180AC0F90")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000759")]
			[Cpp2IlInjected.Address(RVA = "0xAC0650", Offset = "0xABF450", VA = "0x180AC0650")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700030E")]
		public List<GradientConfigDTO> GradientConfigs
		{
			[Cpp2IlInjected.Token(Token = "0x600075A")]
			[Cpp2IlInjected.Address(RVA = "0xAC0F80", Offset = "0xABFD80", VA = "0x180AC0F80")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600075B")]
			[Cpp2IlInjected.Address(RVA = "0xAC8C50", Offset = "0xAC7A50", VA = "0x180AC8C50")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700030F")]
		public List<AnimationCurveConfigDTO> AnimationCurveConfigs
		{
			[Cpp2IlInjected.Token(Token = "0x600075C")]
			[Cpp2IlInjected.Address(RVA = "0xAC0FC0", Offset = "0xABFDC0", VA = "0x180AC0FC0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600075D")]
			[Cpp2IlInjected.Address(RVA = "0xAC0CF0", Offset = "0xABFAF0", VA = "0x180AC0CF0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000310")]
		public List<TextureEffectDTO> TextureEffectConfigs
		{
			[Cpp2IlInjected.Token(Token = "0x600075E")]
			[Cpp2IlInjected.Address(RVA = "0xAC5120", Offset = "0xAC3F20", VA = "0x180AC5120")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600075F")]
			[Cpp2IlInjected.Address(RVA = "0xAC0FB0", Offset = "0xABFDB0", VA = "0x180AC0FB0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000311")]
		public List<PlayerScaleEffectDTO> PlayerScaleEffectConfigs
		{
			[Cpp2IlInjected.Token(Token = "0x6000760")]
			[Cpp2IlInjected.Address(RVA = "0xAC0D30", Offset = "0xABFB30", VA = "0x180AC0D30")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000761")]
			[Cpp2IlInjected.Address(RVA = "0xAC1370", Offset = "0xAC0170", VA = "0x180AC1370")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000312")]
		public DriverConfigDTO PlayerVelocityDriverConfig
		{
			[Cpp2IlInjected.Token(Token = "0x6000762")]
			[Cpp2IlInjected.Address(RVA = "0xAC31E0", Offset = "0xAC1FE0", VA = "0x180AC31E0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000763")]
			[Cpp2IlInjected.Address(RVA = "0xAC31C0", Offset = "0xAC1FC0", VA = "0x180AC31C0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000313")]
		public DriverConfigDTO PlayerVoiceVolumeDriverConfig
		{
			[Cpp2IlInjected.Token(Token = "0x6000764")]
			[Cpp2IlInjected.Address(RVA = "0xAC3430", Offset = "0xAC2230", VA = "0x180AC3430")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000765")]
			[Cpp2IlInjected.Address(RVA = "0xAC31B0", Offset = "0xAC1FB0", VA = "0x180AC31B0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000314")]
		public DriverConfigDTO PlayerHighFivesDriverConfig
		{
			[Cpp2IlInjected.Token(Token = "0x6000766")]
			[Cpp2IlInjected.Address(RVA = "0xAC31D0", Offset = "0xAC1FD0", VA = "0x180AC31D0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000767")]
			[Cpp2IlInjected.Address(RVA = "0xAC3420", Offset = "0xAC2220", VA = "0x180AC3420")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000768")]
		[Cpp2IlInjected.Address(RVA = "0x7A592D0", Offset = "0x7A580D0", VA = "0x187A592D0", Slot = "4")]
		public void DNRPRHFLPRB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000769")]
		[Cpp2IlInjected.Address(RVA = "0x7A59480", Offset = "0x7A58280", VA = "0x187A59480")]
		public AvatarEffectConfigDTO()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000116")]
	[Utf8JsonSerializable]
	public class AvatarEffectKeyDTO : IRecNetUtf8JsonObject, IEquatable<AvatarEffectKeyDTO>
	{
		[Cpp2IlInjected.Token(Token = "0x17000315")]
		public AvatarItemEffectChannel EffectChannel
		{
			[Cpp2IlInjected.Token(Token = "0x600076A")]
			[Cpp2IlInjected.Address(RVA = "0xB12A00", Offset = "0xB11800", VA = "0x180B12A00")]
			[CompilerGenerated]
			get
			{
				return default(AvatarItemEffectChannel);
			}
			[Cpp2IlInjected.Token(Token = "0x600076B")]
			[Cpp2IlInjected.Address(RVA = "0xBA1650", Offset = "0xBA0450", VA = "0x180BA1650")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000316")]
		public DriverType DriverType
		{
			[Cpp2IlInjected.Token(Token = "0x600076C")]
			[Cpp2IlInjected.Address(RVA = "0xBA1640", Offset = "0xBA0440", VA = "0x180BA1640")]
			[CompilerGenerated]
			get
			{
				return default(DriverType);
			}
			[Cpp2IlInjected.Token(Token = "0x600076D")]
			[Cpp2IlInjected.Address(RVA = "0xBA15D0", Offset = "0xBA03D0", VA = "0x180BA15D0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000317")]
		public Guid DriverConfigKey
		{
			[Cpp2IlInjected.Token(Token = "0x600076E")]
			[Cpp2IlInjected.Address(RVA = "0x1BF2010", Offset = "0x1BF0E10", VA = "0x181BF2010")]
			[CompilerGenerated]
			get
			{
				return default(Guid);
			}
			[Cpp2IlInjected.Token(Token = "0x600076F")]
			[Cpp2IlInjected.Address(RVA = "0x6140810", Offset = "0x613F610", VA = "0x186140810")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000318")]
		public Guid ApplierConfigKey
		{
			[Cpp2IlInjected.Token(Token = "0x6000770")]
			[Cpp2IlInjected.Address(RVA = "0xEA1240", Offset = "0xEA0040", VA = "0x180EA1240")]
			[CompilerGenerated]
			get
			{
				return default(Guid);
			}
			[Cpp2IlInjected.Token(Token = "0x6000771")]
			[Cpp2IlInjected.Address(RVA = "0xEA10C0", Offset = "0xE9FEC0", VA = "0x180EA10C0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000772")]
		[Cpp2IlInjected.Address(RVA = "0xABE8D0", Offset = "0xABD6D0", VA = "0x180ABE8D0", Slot = "4")]
		public void DNRPRHFLPRB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000773")]
		[Cpp2IlInjected.Address(RVA = "0x7A596F0", Offset = "0x7A584F0", VA = "0x187A596F0", Slot = "5")]
		public bool Equals(AvatarEffectKeyDTO other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000774")]
		[Cpp2IlInjected.Address(RVA = "0x7A59790", Offset = "0x7A58590", VA = "0x187A59790", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000775")]
		[Cpp2IlInjected.Address(RVA = "0x7A598F0", Offset = "0x7A586F0", VA = "0x187A598F0", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[SpecialName]
		[Cpp2IlInjected.Token(Token = "0x6000776")]
		[Cpp2IlInjected.Address(RVA = "0x1580560", Offset = "0x157F360", VA = "0x181580560")]
		public static bool GFBRUTYEXQF(AvatarEffectKeyDTO a, AvatarEffectKeyDTO b)
		{
			return default(bool);
		}

		[SpecialName]
		[Cpp2IlInjected.Token(Token = "0x6000777")]
		[Cpp2IlInjected.Address(RVA = "0x1580260", Offset = "0x157F060", VA = "0x181580260")]
		public static bool CQBJVGKOTGK(AvatarEffectKeyDTO a, AvatarEffectKeyDTO b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000778")]
		[Cpp2IlInjected.Address(RVA = "0xAC4840", Offset = "0xAC3640", VA = "0x180AC4840")]
		public AvatarEffectKeyDTO()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000117")]
	[Utf8JsonSerializable]
	public class DriverConfigDTO : IRecNetUtf8JsonObject, YHOPTHDGBFP<DriverType>, YGAKBOSJSEK
	{
		[Cpp2IlInjected.Token(Token = "0x17000319")]
		public DriverType Id
		{
			[Cpp2IlInjected.Token(Token = "0x6000779")]
			[Cpp2IlInjected.Address(RVA = "0xB12A00", Offset = "0xB11800", VA = "0x180B12A00", Slot = "5")]
			[CompilerGenerated]
			get
			{
				return default(DriverType);
			}
			[Cpp2IlInjected.Token(Token = "0x600077A")]
			[Cpp2IlInjected.Address(RVA = "0xBA1650", Offset = "0xBA0450", VA = "0x180BA1650")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700031A")]
		public string Name
		{
			[Cpp2IlInjected.Token(Token = "0x600077B")]
			[Cpp2IlInjected.Address(RVA = "0xAC0D20", Offset = "0xABFB20", VA = "0x180AC0D20", Slot = "6")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600077C")]
			[Cpp2IlInjected.Address(RVA = "0xAC0D10", Offset = "0xABFB10", VA = "0x180AC0D10")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700031B")]
		public AnimationCurveDTO AnimationCurve
		{
			[Cpp2IlInjected.Token(Token = "0x600077D")]
			[Cpp2IlInjected.Address(RVA = "0xAC1D20", Offset = "0xAC0B20", VA = "0x180AC1D20")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600077E")]
			[Cpp2IlInjected.Address(RVA = "0xAC0640", Offset = "0xABF440", VA = "0x180AC0640")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700031C")]
		public float ValueAttackRate
		{
			[Cpp2IlInjected.Token(Token = "0x600077F")]
			[Cpp2IlInjected.Address(RVA = "0x10C0DA0", Offset = "0x10BFBA0", VA = "0x1810C0DA0")]
			[CompilerGenerated]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x6000780")]
			[Cpp2IlInjected.Address(RVA = "0x1D9B370", Offset = "0x1D9A170", VA = "0x181D9B370")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700031D")]
		public float ValueDecayRate
		{
			[Cpp2IlInjected.Token(Token = "0x6000781")]
			[Cpp2IlInjected.Address(RVA = "0xE8CCD0", Offset = "0xE8BAD0", VA = "0x180E8CCD0")]
			[CompilerGenerated]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x6000782")]
			[Cpp2IlInjected.Address(RVA = "0xEC6870", Offset = "0xEC5670", VA = "0x180EC6870")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700031E")]
		public float EffectOverdrive
		{
			[Cpp2IlInjected.Token(Token = "0x6000783")]
			[Cpp2IlInjected.Address(RVA = "0xE8CCC0", Offset = "0xE8BAC0", VA = "0x180E8CCC0")]
			[CompilerGenerated]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x6000784")]
			[Cpp2IlInjected.Address(RVA = "0x10AC270", Offset = "0x10AB070", VA = "0x1810AC270")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000785")]
		[Cpp2IlInjected.Address(RVA = "0x7A5AB20", Offset = "0x7A59920", VA = "0x187A5AB20", Slot = "4")]
		public void DNRPRHFLPRB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000786")]
		[Cpp2IlInjected.Address(RVA = "0x7A5AB70", Offset = "0x7A59970", VA = "0x187A5AB70")]
		public DriverConfigDTO()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000118")]
	[Utf8JsonSerializable]
	public class PotionBottleConfigDTO : IRecNetUtf8JsonObject
	{
		[Cpp2IlInjected.Token(Token = "0x1700031F")]
		public AvatarEffectKeyDTO Key
		{
			[Cpp2IlInjected.Token(Token = "0x6000787")]
			[Cpp2IlInjected.Address(RVA = "0xABD130", Offset = "0xABBF30", VA = "0x180ABD130")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000788")]
			[Cpp2IlInjected.Address(RVA = "0xABD120", Offset = "0xABBF20", VA = "0x180ABD120")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000320")]
		public string BottleTextureName
		{
			[Cpp2IlInjected.Token(Token = "0x6000789")]
			[Cpp2IlInjected.Address(RVA = "0xAC0D20", Offset = "0xABFB20", VA = "0x180AC0D20")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600078A")]
			[Cpp2IlInjected.Address(RVA = "0xAC0D10", Offset = "0xABFB10", VA = "0x180AC0D10")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000321")]
		public ColorConfig LiquidColor
		{
			[Cpp2IlInjected.Token(Token = "0x600078B")]
			[Cpp2IlInjected.Address(RVA = "0xAC1D20", Offset = "0xAC0B20", VA = "0x180AC1D20")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600078C")]
			[Cpp2IlInjected.Address(RVA = "0xAC0640", Offset = "0xABF440", VA = "0x180AC0640")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600078D")]
		[Cpp2IlInjected.Address(RVA = "0x1091BE0", Offset = "0x10909E0", VA = "0x181091BE0", Slot = "4")]
		public void DNRPRHFLPRB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600078E")]
		[Cpp2IlInjected.Address(RVA = "0x7A5F490", Offset = "0x7A5E290", VA = "0x187A5F490")]
		public PotionBottleConfigDTO()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000119")]
	[Utf8JsonSerializable]
	public class DriverTypeBottleConfigDTO : IRecNetUtf8JsonObject
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400052F")]
		public string TextureName;

		[Cpp2IlInjected.Token(Token = "0x17000322")]
		public DriverType DriverType
		{
			[Cpp2IlInjected.Token(Token = "0x600078F")]
			[Cpp2IlInjected.Address(RVA = "0xB12A00", Offset = "0xB11800", VA = "0x180B12A00")]
			[CompilerGenerated]
			get
			{
				return default(DriverType);
			}
			[Cpp2IlInjected.Token(Token = "0x6000790")]
			[Cpp2IlInjected.Address(RVA = "0xBA1650", Offset = "0xBA0450", VA = "0x180BA1650")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000791")]
		[Cpp2IlInjected.Address(RVA = "0xABE8D0", Offset = "0xABD6D0", VA = "0x180ABE8D0", Slot = "4")]
		public void DNRPRHFLPRB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000792")]
		[Cpp2IlInjected.Address(RVA = "0xAC4840", Offset = "0xAC3640", VA = "0x180AC4840")]
		public DriverTypeBottleConfigDTO()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200011A")]
	[Utf8JsonSerializable]
	public class RemapConfigDTO : IRecNetUtf8JsonObject, YHOPTHDGBFP<Guid>, YGAKBOSJSEK
	{
		[Cpp2IlInjected.Token(Token = "0x17000323")]
		public string Name
		{
			[Cpp2IlInjected.Token(Token = "0x6000793")]
			[Cpp2IlInjected.Address(RVA = "0xABD130", Offset = "0xABBF30", VA = "0x180ABD130", Slot = "6")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000794")]
			[Cpp2IlInjected.Address(RVA = "0xABD120", Offset = "0xABBF20", VA = "0x180ABD120")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000324")]
		public Guid Id
		{
			[Cpp2IlInjected.Token(Token = "0x6000795")]
			[Cpp2IlInjected.Address(RVA = "0xBED410", Offset = "0xBEC210", VA = "0x180BED410", Slot = "5")]
			[CompilerGenerated]
			get
			{
				return default(Guid);
			}
			[Cpp2IlInjected.Token(Token = "0x6000796")]
			[Cpp2IlInjected.Address(RVA = "0xF76460", Offset = "0xF75260", VA = "0x180F76460")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000325")]
		public float MinRemappedValue
		{
			[Cpp2IlInjected.Token(Token = "0x6000797")]
			[Cpp2IlInjected.Address(RVA = "0x10C0DA0", Offset = "0x10BFBA0", VA = "0x1810C0DA0")]
			[CompilerGenerated]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x6000798")]
			[Cpp2IlInjected.Address(RVA = "0x1D9B370", Offset = "0x1D9A170", VA = "0x181D9B370")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000326")]
		public float MinRemappedNormalValue
		{
			[Cpp2IlInjected.Token(Token = "0x6000799")]
			[Cpp2IlInjected.Address(RVA = "0xE8CCD0", Offset = "0xE8BAD0", VA = "0x180E8CCD0")]
			[CompilerGenerated]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x600079A")]
			[Cpp2IlInjected.Address(RVA = "0xEC6870", Offset = "0xEC5670", VA = "0x180EC6870")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000327")]
		public float MaxRemappedNormalValue
		{
			[Cpp2IlInjected.Token(Token = "0x600079B")]
			[Cpp2IlInjected.Address(RVA = "0xE8CCC0", Offset = "0xE8BAC0", VA = "0x180E8CCC0")]
			[CompilerGenerated]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x600079C")]
			[Cpp2IlInjected.Address(RVA = "0x10AC270", Offset = "0x10AB070", VA = "0x1810AC270")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000328")]
		public float MaxRemappedValue
		{
			[Cpp2IlInjected.Token(Token = "0x600079D")]
			[Cpp2IlInjected.Address(RVA = "0xDD7550", Offset = "0xDD6350", VA = "0x180DD7550")]
			[CompilerGenerated]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x600079E")]
			[Cpp2IlInjected.Address(RVA = "0xDD7560", Offset = "0xDD6360", VA = "0x180DD7560")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600079F")]
		[Cpp2IlInjected.Address(RVA = "0xABE8D0", Offset = "0xABD6D0", VA = "0x180ABE8D0", Slot = "4")]
		public void DNRPRHFLPRB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60007A0")]
		[Cpp2IlInjected.Address(RVA = "0xAC4840", Offset = "0xAC3640", VA = "0x180AC4840")]
		public RemapConfigDTO()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200011B")]
	[Utf8JsonSerializable]
	public class AuraConfigDTO : IRecNetUtf8JsonObject, YHOPTHDGBFP<Guid>, YGAKBOSJSEK
	{
		[Cpp2IlInjected.Token(Token = "0x17000329")]
		public string Name
		{
			[Cpp2IlInjected.Token(Token = "0x60007A1")]
			[Cpp2IlInjected.Address(RVA = "0x7A59270", Offset = "0x7A58070", VA = "0x187A59270", Slot = "6")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700032A")]
		public Guid Id
		{
			[Cpp2IlInjected.Token(Token = "0x60007A2")]
			[Cpp2IlInjected.Address(RVA = "0xEC6860", Offset = "0xEC5660", VA = "0x180EC6860", Slot = "5")]
			[CompilerGenerated]
			get
			{
				return default(Guid);
			}
			[Cpp2IlInjected.Token(Token = "0x60007A3")]
			[Cpp2IlInjected.Address(RVA = "0xEC6880", Offset = "0xEC5680", VA = "0x180EC6880")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700032B")]
		public int AuraId
		{
			[Cpp2IlInjected.Token(Token = "0x60007A4")]
			[Cpp2IlInjected.Address(RVA = "0xACF4D0", Offset = "0xACE2D0", VA = "0x180ACF4D0")]
			[CompilerGenerated]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x60007A5")]
			[Cpp2IlInjected.Address(RVA = "0xB20FD0", Offset = "0xB1FDD0", VA = "0x180B20FD0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700032C")]
		public string TextureName
		{
			[Cpp2IlInjected.Token(Token = "0x60007A6")]
			[Cpp2IlInjected.Address(RVA = "0xAC0F90", Offset = "0xABFD90", VA = "0x180AC0F90")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60007A7")]
			[Cpp2IlInjected.Address(RVA = "0xAC0650", Offset = "0xABF450", VA = "0x180AC0650")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700032D")]
		public ColorConfig Color
		{
			[Cpp2IlInjected.Token(Token = "0x60007A8")]
			[Cpp2IlInjected.Address(RVA = "0xAC0F80", Offset = "0xABFD80", VA = "0x180AC0F80")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60007A9")]
			[Cpp2IlInjected.Address(RVA = "0xAC8C50", Offset = "0xAC7A50", VA = "0x180AC8C50")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60007AA")]
		[Cpp2IlInjected.Address(RVA = "0x7A58FF0", Offset = "0x7A57DF0", VA = "0x187A58FF0", Slot = "4")]
		public void DNRPRHFLPRB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60007AB")]
		[Cpp2IlInjected.Address(RVA = "0x7A59200", Offset = "0x7A58000", VA = "0x187A59200")]
		public AuraConfigDTO()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200011C")]
	[Utf8JsonSerializable]
	public class GradientConfigDTO : IRecNetUtf8JsonObject, YHOPTHDGBFP<Guid>, YGAKBOSJSEK
	{
		[Cpp2IlInjected.Token(Token = "0x1700032E")]
		public string Name
		{
			[Cpp2IlInjected.Token(Token = "0x60007AC")]
			[Cpp2IlInjected.Address(RVA = "0xABD130", Offset = "0xABBF30", VA = "0x180ABD130", Slot = "6")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60007AD")]
			[Cpp2IlInjected.Address(RVA = "0xABD120", Offset = "0xABBF20", VA = "0x180ABD120")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700032F")]
		public Guid Id
		{
			[Cpp2IlInjected.Token(Token = "0x60007AE")]
			[Cpp2IlInjected.Address(RVA = "0xBED410", Offset = "0xBEC210", VA = "0x180BED410", Slot = "5")]
			[CompilerGenerated]
			get
			{
				return default(Guid);
			}
			[Cpp2IlInjected.Token(Token = "0x60007AF")]
			[Cpp2IlInjected.Address(RVA = "0xF76460", Offset = "0xF75260", VA = "0x180F76460")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000330")]
		public float GradientTime
		{
			[Cpp2IlInjected.Token(Token = "0x60007B0")]
			[Cpp2IlInjected.Address(RVA = "0x10C0DA0", Offset = "0x10BFBA0", VA = "0x1810C0DA0")]
			[CompilerGenerated]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x60007B1")]
			[Cpp2IlInjected.Address(RVA = "0x1D9B370", Offset = "0x1D9A170", VA = "0x181D9B370")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000331")]
		public GradientType GradientType
		{
			[Cpp2IlInjected.Token(Token = "0x60007B2")]
			[Cpp2IlInjected.Address(RVA = "0x1ADD440", Offset = "0x1ADC240", VA = "0x181ADD440")]
			[CompilerGenerated]
			get
			{
				return default(GradientType);
			}
			[Cpp2IlInjected.Token(Token = "0x60007B3")]
			[Cpp2IlInjected.Address(RVA = "0x10AC4A0", Offset = "0x10AB2A0", VA = "0x1810AC4A0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000332")]
		public List<GradientKeyDTO> ColorKeys
		{
			[Cpp2IlInjected.Token(Token = "0x60007B4")]
			[Cpp2IlInjected.Address(RVA = "0xAC0F80", Offset = "0xABFD80", VA = "0x180AC0F80")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60007B5")]
			[Cpp2IlInjected.Address(RVA = "0xAC8C50", Offset = "0xAC7A50", VA = "0x180AC8C50")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60007B6")]
		[Cpp2IlInjected.Address(RVA = "0x7A5C0E0", Offset = "0x7A5AEE0", VA = "0x187A5C0E0", Slot = "4")]
		public void DNRPRHFLPRB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60007B7")]
		[Cpp2IlInjected.Address(RVA = "0x7A5C170", Offset = "0x7A5AF70", VA = "0x187A5C170")]
		public GradientConfigDTO()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200011D")]
	[Utf8JsonSerializable]
	public class AnimationCurveConfigDTO : IRecNetUtf8JsonObject, YHOPTHDGBFP<Guid>, YGAKBOSJSEK
	{
		[Cpp2IlInjected.Token(Token = "0x17000333")]
		public string Name
		{
			[Cpp2IlInjected.Token(Token = "0x60007B8")]
			[Cpp2IlInjected.Address(RVA = "0xABD130", Offset = "0xABBF30", VA = "0x180ABD130", Slot = "6")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60007B9")]
			[Cpp2IlInjected.Address(RVA = "0xABD120", Offset = "0xABBF20", VA = "0x180ABD120")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000334")]
		public Guid Id
		{
			[Cpp2IlInjected.Token(Token = "0x60007BA")]
			[Cpp2IlInjected.Address(RVA = "0xBED410", Offset = "0xBEC210", VA = "0x180BED410", Slot = "5")]
			[CompilerGenerated]
			get
			{
				return default(Guid);
			}
			[Cpp2IlInjected.Token(Token = "0x60007BB")]
			[Cpp2IlInjected.Address(RVA = "0xF76460", Offset = "0xF75260", VA = "0x180F76460")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000335")]
		public AnimationCurveDTO AnimationCurve
		{
			[Cpp2IlInjected.Token(Token = "0x60007BC")]
			[Cpp2IlInjected.Address(RVA = "0xAC0F90", Offset = "0xABFD90", VA = "0x180AC0F90")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60007BD")]
			[Cpp2IlInjected.Address(RVA = "0xAC0650", Offset = "0xABF450", VA = "0x180AC0650")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60007BE")]
		[Cpp2IlInjected.Address(RVA = "0x7A59080", Offset = "0x7A57E80", VA = "0x187A59080", Slot = "4")]
		public void DNRPRHFLPRB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60007BF")]
		[Cpp2IlInjected.Address(RVA = "0x7A590D0", Offset = "0x7A57ED0", VA = "0x187A590D0")]
		public AnimationCurveConfigDTO()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200011E")]
	[Utf8JsonSerializable]
	public class AnimationCurveDTO : IRecNetUtf8JsonObject
	{
		[Cpp2IlInjected.Token(Token = "0x17000336")]
		public List<AnimationCurveKeyDTO> CurveKeys
		{
			[Cpp2IlInjected.Token(Token = "0x60007C0")]
			[Cpp2IlInjected.Address(RVA = "0xABD130", Offset = "0xABBF30", VA = "0x180ABD130")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60007C1")]
			[Cpp2IlInjected.Address(RVA = "0xABD120", Offset = "0xABBF20", VA = "0x180ABD120")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60007C2")]
		[Cpp2IlInjected.Address(RVA = "0x7A59140", Offset = "0x7A57F40", VA = "0x187A59140", Slot = "4")]
		public void DNRPRHFLPRB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60007C3")]
		[Cpp2IlInjected.Address(RVA = "0x7A59180", Offset = "0x7A57F80", VA = "0x187A59180")]
		public AnimationCurveDTO()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200011F")]
	[Utf8JsonSerializable]
	public class AnimationCurveKeyDTO : IRecNetUtf8JsonObject
	{
		[Cpp2IlInjected.Token(Token = "0x17000337")]
		public float Time
		{
			[Cpp2IlInjected.Token(Token = "0x60007C4")]
			[Cpp2IlInjected.Address(RVA = "0xD97BD0", Offset = "0xD969D0", VA = "0x180D97BD0")]
			[CompilerGenerated]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x60007C5")]
			[Cpp2IlInjected.Address(RVA = "0xE284C0", Offset = "0xE272C0", VA = "0x180E284C0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000338")]
		public float Value
		{
			[Cpp2IlInjected.Token(Token = "0x60007C6")]
			[Cpp2IlInjected.Address(RVA = "0xEBF250", Offset = "0xEBE050", VA = "0x180EBF250")]
			[CompilerGenerated]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x60007C7")]
			[Cpp2IlInjected.Address(RVA = "0xEBF2B0", Offset = "0xEBE0B0", VA = "0x180EBF2B0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000339")]
		public float InSlope
		{
			[Cpp2IlInjected.Token(Token = "0x60007C8")]
			[Cpp2IlInjected.Address(RVA = "0xB1A960", Offset = "0xB19760", VA = "0x180B1A960")]
			[CompilerGenerated]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x60007C9")]
			[Cpp2IlInjected.Address(RVA = "0x13EAEA0", Offset = "0x13E9CA0", VA = "0x1813EAEA0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700033A")]
		public float OutSlope
		{
			[Cpp2IlInjected.Token(Token = "0x60007CA")]
			[Cpp2IlInjected.Address(RVA = "0xB1AB70", Offset = "0xB19970", VA = "0x180B1AB70")]
			[CompilerGenerated]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x60007CB")]
			[Cpp2IlInjected.Address(RVA = "0x13EAEB0", Offset = "0x13E9CB0", VA = "0x1813EAEB0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700033B")]
		public float InWeight
		{
			[Cpp2IlInjected.Token(Token = "0x60007CC")]
			[Cpp2IlInjected.Address(RVA = "0xB1A860", Offset = "0xB19660", VA = "0x180B1A860")]
			[CompilerGenerated]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x60007CD")]
			[Cpp2IlInjected.Address(RVA = "0x10D56A0", Offset = "0x10D44A0", VA = "0x1810D56A0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700033C")]
		public float OutWeight
		{
			[Cpp2IlInjected.Token(Token = "0x60007CE")]
			[Cpp2IlInjected.Address(RVA = "0xB21BD0", Offset = "0xB209D0", VA = "0x180B21BD0")]
			[CompilerGenerated]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x60007CF")]
			[Cpp2IlInjected.Address(RVA = "0xB20FC0", Offset = "0xB1FDC0", VA = "0x180B20FC0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700033D")]
		public int TangentMode
		{
			[Cpp2IlInjected.Token(Token = "0x60007D0")]
			[Cpp2IlInjected.Address(RVA = "0xAC2060", Offset = "0xAC0E60", VA = "0x180AC2060")]
			[CompilerGenerated]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x60007D1")]
			[Cpp2IlInjected.Address(RVA = "0xAC1D30", Offset = "0xAC0B30", VA = "0x180AC1D30")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700033E")]
		public int WeightedMode
		{
			[Cpp2IlInjected.Token(Token = "0x60007D2")]
			[Cpp2IlInjected.Address(RVA = "0xC56CD0", Offset = "0xC55AD0", VA = "0x180C56CD0")]
			[CompilerGenerated]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x60007D3")]
			[Cpp2IlInjected.Address(RVA = "0x1D9ACF0", Offset = "0x1D99AF0", VA = "0x181D9ACF0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60007D4")]
		[Cpp2IlInjected.Address(RVA = "0xABE8D0", Offset = "0xABD6D0", VA = "0x180ABE8D0", Slot = "4")]
		public void DNRPRHFLPRB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60007D5")]
		[Cpp2IlInjected.Address(RVA = "0xAC4840", Offset = "0xAC3640", VA = "0x180AC4840")]
		public AnimationCurveKeyDTO()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000120")]
	[Utf8JsonSerializable]
	public class GradientKeyDTO : IRecNetUtf8JsonObject
	{
		[Cpp2IlInjected.Token(Token = "0x1700033F")]
		public float Time
		{
			[Cpp2IlInjected.Token(Token = "0x60007D6")]
			[Cpp2IlInjected.Address(RVA = "0xD97BD0", Offset = "0xD969D0", VA = "0x180D97BD0")]
			[CompilerGenerated]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x60007D7")]
			[Cpp2IlInjected.Address(RVA = "0xE284C0", Offset = "0xE272C0", VA = "0x180E284C0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000340")]
		public ColorConfig Color
		{
			[Cpp2IlInjected.Token(Token = "0x60007D8")]
			[Cpp2IlInjected.Address(RVA = "0xAC0D20", Offset = "0xABFB20", VA = "0x180AC0D20")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60007D9")]
			[Cpp2IlInjected.Address(RVA = "0xAC0D10", Offset = "0xABFB10", VA = "0x180AC0D10")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60007DA")]
		[Cpp2IlInjected.Address(RVA = "0x1091BE0", Offset = "0x10909E0", VA = "0x181091BE0", Slot = "4")]
		public void DNRPRHFLPRB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60007DB")]
		[Cpp2IlInjected.Address(RVA = "0x7A5C200", Offset = "0x7A5B000", VA = "0x187A5C200")]
		public GradientKeyDTO()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000121")]
	[Utf8JsonSerializable]
	public class ColorConfig : IRecNetUtf8JsonObject
	{
		[Cpp2IlInjected.Token(Token = "0x17000341")]
		public float R
		{
			[Cpp2IlInjected.Token(Token = "0x60007DC")]
			[Cpp2IlInjected.Address(RVA = "0xD97BD0", Offset = "0xD969D0", VA = "0x180D97BD0")]
			[CompilerGenerated]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x60007DD")]
			[Cpp2IlInjected.Address(RVA = "0xE284C0", Offset = "0xE272C0", VA = "0x180E284C0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000342")]
		public float G
		{
			[Cpp2IlInjected.Token(Token = "0x60007DE")]
			[Cpp2IlInjected.Address(RVA = "0xEBF250", Offset = "0xEBE050", VA = "0x180EBF250")]
			[CompilerGenerated]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x60007DF")]
			[Cpp2IlInjected.Address(RVA = "0xEBF2B0", Offset = "0xEBE0B0", VA = "0x180EBF2B0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000343")]
		public float B
		{
			[Cpp2IlInjected.Token(Token = "0x60007E0")]
			[Cpp2IlInjected.Address(RVA = "0xB1A960", Offset = "0xB19760", VA = "0x180B1A960")]
			[CompilerGenerated]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x60007E1")]
			[Cpp2IlInjected.Address(RVA = "0x13EAEA0", Offset = "0x13E9CA0", VA = "0x1813EAEA0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000344")]
		public float A
		{
			[Cpp2IlInjected.Token(Token = "0x60007E2")]
			[Cpp2IlInjected.Address(RVA = "0xB1AB70", Offset = "0xB19970", VA = "0x180B1AB70")]
			[CompilerGenerated]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x60007E3")]
			[Cpp2IlInjected.Address(RVA = "0x13EAEB0", Offset = "0x13E9CB0", VA = "0x1813EAEB0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60007E4")]
		[Cpp2IlInjected.Address(RVA = "0xAC4840", Offset = "0xAC3640", VA = "0x180AC4840")]
		public ColorConfig()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60007E5")]
		[Cpp2IlInjected.Address(RVA = "0x7A5A3A0", Offset = "0x7A591A0", VA = "0x187A5A3A0")]
		public ColorConfig(float r, float g, float b, float a = 1f)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60007E6")]
		[Cpp2IlInjected.Address(RVA = "0xABE8D0", Offset = "0xABD6D0", VA = "0x180ABE8D0", Slot = "4")]
		public void DNRPRHFLPRB()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000122")]
	[Utf8JsonSerializable]
	public class PlayerScaleEffectDTO : IRecNetUtf8JsonObject, YHOPTHDGBFP<Guid>, YGAKBOSJSEK
	{
		[Cpp2IlInjected.Token(Token = "0x17000345")]
		public string Name
		{
			[Cpp2IlInjected.Token(Token = "0x60007E7")]
			[Cpp2IlInjected.Address(RVA = "0xABD130", Offset = "0xABBF30", VA = "0x180ABD130", Slot = "6")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60007E8")]
			[Cpp2IlInjected.Address(RVA = "0xABD120", Offset = "0xABBF20", VA = "0x180ABD120")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000346")]
		public Guid Id
		{
			[Cpp2IlInjected.Token(Token = "0x60007E9")]
			[Cpp2IlInjected.Address(RVA = "0xBED410", Offset = "0xBEC210", VA = "0x180BED410", Slot = "5")]
			[CompilerGenerated]
			get
			{
				return default(Guid);
			}
			[Cpp2IlInjected.Token(Token = "0x60007EA")]
			[Cpp2IlInjected.Address(RVA = "0xF76460", Offset = "0xF75260", VA = "0x180F76460")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000347")]
		public AnimationCurveDTO RemapCurve
		{
			[Cpp2IlInjected.Token(Token = "0x60007EB")]
			[Cpp2IlInjected.Address(RVA = "0xAC0F90", Offset = "0xABFD90", VA = "0x180AC0F90")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60007EC")]
			[Cpp2IlInjected.Address(RVA = "0xAC0650", Offset = "0xABF450", VA = "0x180AC0650")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60007ED")]
		[Cpp2IlInjected.Address(RVA = "0x7A59080", Offset = "0x7A57E80", VA = "0x187A59080", Slot = "4")]
		public void DNRPRHFLPRB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60007EE")]
		[Cpp2IlInjected.Address(RVA = "0x7A5F3C0", Offset = "0x7A5E1C0", VA = "0x187A5F3C0")]
		public PlayerScaleEffectDTO()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000123")]
	[Utf8JsonSerializable]
	public class TextureEffectDTO : IRecNetUtf8JsonObject, YHOPTHDGBFP<Guid>, YGAKBOSJSEK
	{
		[Cpp2IlInjected.Token(Token = "0x17000348")]
		public string Name
		{
			[Cpp2IlInjected.Token(Token = "0x60007EF")]
			[Cpp2IlInjected.Address(RVA = "0xABD130", Offset = "0xABBF30", VA = "0x180ABD130", Slot = "6")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60007F0")]
			[Cpp2IlInjected.Address(RVA = "0xABD120", Offset = "0xABBF20", VA = "0x180ABD120")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000349")]
		public Guid Id
		{
			[Cpp2IlInjected.Token(Token = "0x60007F1")]
			[Cpp2IlInjected.Address(RVA = "0xBED410", Offset = "0xBEC210", VA = "0x180BED410", Slot = "5")]
			[CompilerGenerated]
			get
			{
				return default(Guid);
			}
			[Cpp2IlInjected.Token(Token = "0x60007F2")]
			[Cpp2IlInjected.Address(RVA = "0xF76460", Offset = "0xF75260", VA = "0x180F76460")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700034A")]
		public string MaskTextureName
		{
			[Cpp2IlInjected.Token(Token = "0x60007F3")]
			[Cpp2IlInjected.Address(RVA = "0xAC0F90", Offset = "0xABFD90", VA = "0x180AC0F90")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60007F4")]
			[Cpp2IlInjected.Address(RVA = "0xAC0650", Offset = "0xABF450", VA = "0x180AC0650")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700034B")]
		public string LUTTextureName
		{
			[Cpp2IlInjected.Token(Token = "0x60007F5")]
			[Cpp2IlInjected.Address(RVA = "0xAC0F80", Offset = "0xABFD80", VA = "0x180AC0F80")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60007F6")]
			[Cpp2IlInjected.Address(RVA = "0xAC8C50", Offset = "0xAC7A50", VA = "0x180AC8C50")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700034C")]
		public bool UseNormalFade
		{
			[Cpp2IlInjected.Token(Token = "0x60007F7")]
			[Cpp2IlInjected.Address(RVA = "0xAEBAB0", Offset = "0xAEA8B0", VA = "0x180AEBAB0")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x60007F8")]
			[Cpp2IlInjected.Address(RVA = "0xAEBA10", Offset = "0xAEA810", VA = "0x180AEBA10")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700034D")]
		public float GlobalIntensity
		{
			[Cpp2IlInjected.Token(Token = "0x60007F9")]
			[Cpp2IlInjected.Address(RVA = "0xAEE0B0", Offset = "0xAECEB0", VA = "0x180AEE0B0")]
			[CompilerGenerated]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x60007FA")]
			[Cpp2IlInjected.Address(RVA = "0xAEDDF0", Offset = "0xAECBF0", VA = "0x180AEDDF0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700034E")]
		public TextureChannelDTO Vfx1
		{
			[Cpp2IlInjected.Token(Token = "0x60007FB")]
			[Cpp2IlInjected.Address(RVA = "0xAC5120", Offset = "0xAC3F20", VA = "0x180AC5120")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60007FC")]
			[Cpp2IlInjected.Address(RVA = "0xAC0FB0", Offset = "0xABFDB0", VA = "0x180AC0FB0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700034F")]
		public TextureChannelDTO Vfx2
		{
			[Cpp2IlInjected.Token(Token = "0x60007FD")]
			[Cpp2IlInjected.Address(RVA = "0xAC0D30", Offset = "0xABFB30", VA = "0x180AC0D30")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60007FE")]
			[Cpp2IlInjected.Address(RVA = "0xAC1370", Offset = "0xAC0170", VA = "0x180AC1370")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000350")]
		public TextureChannelDTO Vfx3
		{
			[Cpp2IlInjected.Token(Token = "0x60007FF")]
			[Cpp2IlInjected.Address(RVA = "0xAC31E0", Offset = "0xAC1FE0", VA = "0x180AC31E0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000800")]
			[Cpp2IlInjected.Address(RVA = "0xAC31C0", Offset = "0xAC1FC0", VA = "0x180AC31C0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000351")]
		public TextureChannelDTO Vfx4
		{
			[Cpp2IlInjected.Token(Token = "0x6000801")]
			[Cpp2IlInjected.Address(RVA = "0xAC3430", Offset = "0xAC2230", VA = "0x180AC3430")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000802")]
			[Cpp2IlInjected.Address(RVA = "0xAC31B0", Offset = "0xAC1FB0", VA = "0x180AC31B0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000352")]
		public Vector4Dto LUT_ST
		{
			[Cpp2IlInjected.Token(Token = "0x6000803")]
			[Cpp2IlInjected.Address(RVA = "0xAC31D0", Offset = "0xAC1FD0", VA = "0x180AC31D0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000804")]
			[Cpp2IlInjected.Address(RVA = "0xAC3420", Offset = "0xAC2220", VA = "0x180AC3420")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000805")]
		[Cpp2IlInjected.Address(RVA = "0x7A62910", Offset = "0x7A61710", VA = "0x187A62910", Slot = "4")]
		public void DNRPRHFLPRB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000806")]
		[Cpp2IlInjected.Address(RVA = "0x7A629D0", Offset = "0x7A617D0", VA = "0x187A629D0")]
		public TextureEffectDTO()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000124")]
	[Utf8JsonSerializable]
	public class TextureChannelDTO : IRecNetUtf8JsonObject
	{
		[Cpp2IlInjected.Token(Token = "0x17000353")]
		public Vector2Dto Scroll
		{
			[Cpp2IlInjected.Token(Token = "0x6000807")]
			[Cpp2IlInjected.Address(RVA = "0xABD130", Offset = "0xABBF30", VA = "0x180ABD130")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000808")]
			[Cpp2IlInjected.Address(RVA = "0xABD120", Offset = "0xABBF20", VA = "0x180ABD120")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000354")]
		public float ColorIntensity
		{
			[Cpp2IlInjected.Token(Token = "0x6000809")]
			[Cpp2IlInjected.Address(RVA = "0xB1A960", Offset = "0xB19760", VA = "0x180B1A960")]
			[CompilerGenerated]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x600080A")]
			[Cpp2IlInjected.Address(RVA = "0x13EAEA0", Offset = "0x13E9CA0", VA = "0x1813EAEA0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000355")]
		public float AlphaIntensity
		{
			[Cpp2IlInjected.Token(Token = "0x600080B")]
			[Cpp2IlInjected.Address(RVA = "0xB1AB70", Offset = "0xB19970", VA = "0x180B1AB70")]
			[CompilerGenerated]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x600080C")]
			[Cpp2IlInjected.Address(RVA = "0x13EAEB0", Offset = "0x13E9CB0", VA = "0x1813EAEB0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000356")]
		public Vector4Dto ST
		{
			[Cpp2IlInjected.Token(Token = "0x600080D")]
			[Cpp2IlInjected.Address(RVA = "0xAC1D20", Offset = "0xAC0B20", VA = "0x180AC1D20")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600080E")]
			[Cpp2IlInjected.Address(RVA = "0xAC0640", Offset = "0xABF440", VA = "0x180AC0640")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600080F")]
		[Cpp2IlInjected.Address(RVA = "0x7A62880", Offset = "0x7A61680", VA = "0x187A62880", Slot = "4")]
		public void DNRPRHFLPRB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000810")]
		[Cpp2IlInjected.Address(RVA = "0x7A628A0", Offset = "0x7A616A0", VA = "0x187A628A0")]
		public TextureChannelDTO()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000125")]
	[Utf8JsonSerializable]
	public class Vector2Dto : IRecNetUtf8JsonObject
	{
		[Cpp2IlInjected.Token(Token = "0x17000357")]
		public float X
		{
			[Cpp2IlInjected.Token(Token = "0x6000811")]
			[Cpp2IlInjected.Address(RVA = "0xD97BD0", Offset = "0xD969D0", VA = "0x180D97BD0")]
			[CompilerGenerated]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x6000812")]
			[Cpp2IlInjected.Address(RVA = "0xE284C0", Offset = "0xE272C0", VA = "0x180E284C0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000358")]
		public float Y
		{
			[Cpp2IlInjected.Token(Token = "0x6000813")]
			[Cpp2IlInjected.Address(RVA = "0xEBF250", Offset = "0xEBE050", VA = "0x180EBF250")]
			[CompilerGenerated]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x6000814")]
			[Cpp2IlInjected.Address(RVA = "0xEBF2B0", Offset = "0xEBE0B0", VA = "0x180EBF2B0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000815")]
		[Cpp2IlInjected.Address(RVA = "0xAC4840", Offset = "0xAC3640", VA = "0x180AC4840")]
		public Vector2Dto()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000816")]
		[Cpp2IlInjected.Address(RVA = "0x7A3B800", Offset = "0x7A3A600", VA = "0x187A3B800")]
		public Vector2Dto(float x, float y)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000817")]
		[Cpp2IlInjected.Address(RVA = "0xABE8D0", Offset = "0xABD6D0", VA = "0x180ABE8D0", Slot = "5")]
		public virtual void DNRPRHFLPRB()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000126")]
	[Utf8JsonSerializable]
	public class Vector4Dto : Vector2Dto
	{
		[Cpp2IlInjected.Token(Token = "0x17000359")]
		public float Z
		{
			[Cpp2IlInjected.Token(Token = "0x6000818")]
			[Cpp2IlInjected.Address(RVA = "0xB1A960", Offset = "0xB19760", VA = "0x180B1A960")]
			[CompilerGenerated]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x6000819")]
			[Cpp2IlInjected.Address(RVA = "0x13EAEA0", Offset = "0x13E9CA0", VA = "0x1813EAEA0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700035A")]
		public float W
		{
			[Cpp2IlInjected.Token(Token = "0x600081A")]
			[Cpp2IlInjected.Address(RVA = "0xB1AB70", Offset = "0xB19970", VA = "0x180B1AB70")]
			[CompilerGenerated]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x600081B")]
			[Cpp2IlInjected.Address(RVA = "0x13EAEB0", Offset = "0x13E9CB0", VA = "0x1813EAEB0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600081C")]
		[Cpp2IlInjected.Address(RVA = "0xAC4840", Offset = "0xAC3640", VA = "0x180AC4840")]
		public Vector4Dto()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600081D")]
		[Cpp2IlInjected.Address(RVA = "0x7A5A3A0", Offset = "0x7A591A0", VA = "0x187A5A3A0")]
		public Vector4Dto(float x, float y, float z, float w)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600081E")]
		[Cpp2IlInjected.Address(RVA = "0xABE8D0", Offset = "0xABD6D0", VA = "0x180ABE8D0", Slot = "5")]
		public override void DNRPRHFLPRB()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000127")]
	internal static class EKKKSQUDTFY
	{
		[Cpp2IlInjected.Token(Token = "0x600081F")]
		[Cpp2IlInjected.Address(RVA = "0x37F3540", Offset = "0x37F2340", VA = "0x1837F3540")]
		public static void EHGVEYXTOYO<a>(IList<a>? objs) where a : IRecNetUtf8JsonObject
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000128")]
	public enum AvatarItemEffectChannel : byte
	{
		[Cpp2IlInjected.Token(Token = "0x4000568")]
		Invalid,
		[Cpp2IlInjected.Token(Token = "0x4000569")]
		Emission,
		[Cpp2IlInjected.Token(Token = "0x400056A")]
		HairColor,
		[Cpp2IlInjected.Token(Token = "0x400056B")]
		PlayerHeadScale,
		[Cpp2IlInjected.Token(Token = "0x400056C")]
		Aura,
		[Cpp2IlInjected.Token(Token = "0x400056D")]
		Texture,
		[Cpp2IlInjected.Token(Token = "0x400056E")]
		PlayerAvatarScale
	}
	[Cpp2IlInjected.Token(Token = "0x2000129")]
	public enum DriverType : byte
	{
		[Cpp2IlInjected.Token(Token = "0x4000570")]
		Invalid,
		[Cpp2IlInjected.Token(Token = "0x4000571")]
		PlayerVoiceInput,
		[Cpp2IlInjected.Token(Token = "0x4000572")]
		PlayerVelocity,
		[Cpp2IlInjected.Token(Token = "0x4000573")]
		AnimationCurve,
		[Cpp2IlInjected.Token(Token = "0x4000574")]
		HighFiveCount,
		[Cpp2IlInjected.Token(Token = "0x4000575")]
		AlwaysOn
	}
	[Cpp2IlInjected.Token(Token = "0x200012A")]
	public enum GradientType : byte
	{
		[Cpp2IlInjected.Token(Token = "0x4000577")]
		Invalid,
		[Cpp2IlInjected.Token(Token = "0x4000578")]
		Time,
		[Cpp2IlInjected.Token(Token = "0x4000579")]
		ValueRamp
	}
	[Cpp2IlInjected.Token(Token = "0x200012B")]
	public static class BBYIZOJAJXP
	{
		[Cpp2IlInjected.Token(Token = "0x400057A")]
		public static readonly AvatarItemEffectChannel[] NMIYUGRZQDJ;

		[Cpp2IlInjected.Token(Token = "0x400057B")]
		public static readonly AvatarItemEffectChannel[] LILCNPQFUCJ;

		[Cpp2IlInjected.Token(Token = "0x400057C")]
		public static readonly DriverType[] LYFKWQSYANY;

		[Cpp2IlInjected.Token(Token = "0x400057D")]
		public static readonly DriverType[] PLBUENWBDUS;

		[Cpp2IlInjected.Token(Token = "0x6000820")]
		[Cpp2IlInjected.Address(RVA = "0x7A599A0", Offset = "0x7A587A0", VA = "0x187A599A0")]
		public static bool OMRHYLPLFQS(this AvatarItemEffectChannel a)
		{
			return default(bool);
		}
	}
}
namespace RecNet.Tags
{
	[Cpp2IlInjected.Token(Token = "0x200012D")]
	public enum TagType
	{
		[Cpp2IlInjected.Token(Token = "0x4000580")]
		General,
		[Cpp2IlInjected.Token(Token = "0x4000581")]
		Auto,
		[Cpp2IlInjected.Token(Token = "0x4000582")]
		AGOnly,
		[Cpp2IlInjected.Token(Token = "0x4000583")]
		Banned
	}
	[Cpp2IlInjected.Token(Token = "0x200012E")]
	public enum TagStatus
	{
		[Cpp2IlInjected.Token(Token = "0x4000585")]
		Success,
		[Cpp2IlInjected.Token(Token = "0x4000586")]
		TooManyTags,
		[Cpp2IlInjected.Token(Token = "0x4000587")]
		TagUseRestricted,
		[Cpp2IlInjected.Token(Token = "0x4000588")]
		InvalidTag,
		[Cpp2IlInjected.Token(Token = "0x4000589")]
		InappropriateTag,
		[Cpp2IlInjected.Token(Token = "0x400058A")]
		TagTooLong,
		[Cpp2IlInjected.Token(Token = "0x400058B")]
		TagNotFound,
		[Cpp2IlInjected.Token(Token = "0x400058C")]
		TagAlreadyExists,
		[Cpp2IlInjected.Token(Token = "0x400058D")]
		NoChange,
		[Cpp2IlInjected.Token(Token = "0x400058E")]
		TagRepeated,
		[Cpp2IlInjected.Token(Token = "0x400058F")]
		LacksPermission,
		[Cpp2IlInjected.Token(Token = "0x4000590")]
		RoomDoesNotExist,
		[Cpp2IlInjected.Token(Token = "0x4000591")]
		InventionDoesNotExist,
		[Cpp2IlInjected.Token(Token = "0x4000592")]
		ReservedWordViolation
	}
	[Cpp2IlInjected.Token(Token = "0x200012F")]
	[Utf8JsonSerializable]
	public class ModifyTagsResponse : IRecNetUtf8JsonObject
	{
		[Cpp2IlInjected.Token(Token = "0x1700035B")]
		public TagStatus Result
		{
			[Cpp2IlInjected.Token(Token = "0x6000826")]
			[Cpp2IlInjected.Address(RVA = "0xABD110", Offset = "0xABBF10", VA = "0x180ABD110")]
			[CompilerGenerated]
			get
			{
				return default(TagStatus);
			}
			[Cpp2IlInjected.Token(Token = "0x6000827")]
			[Cpp2IlInjected.Address(RVA = "0xAC1D40", Offset = "0xAC0B40", VA = "0x180AC1D40")]
			[CompilerGenerated]
			internal set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700035C")]
		public List<string> Tags
		{
			[Cpp2IlInjected.Token(Token = "0x6000828")]
			[Cpp2IlInjected.Address(RVA = "0xAC0D20", Offset = "0xABFB20", VA = "0x180AC0D20")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000829")]
			[Cpp2IlInjected.Address(RVA = "0xAC0D10", Offset = "0xABFB10", VA = "0x180AC0D10")]
			[CompilerGenerated]
			internal set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600082A")]
		[Cpp2IlInjected.Address(RVA = "0xABE8D0", Offset = "0xABD6D0", VA = "0x180ABE8D0", Slot = "4")]
		public void DNRPRHFLPRB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600082B")]
		[Cpp2IlInjected.Address(RVA = "0x7A5E740", Offset = "0x7A5D540", VA = "0x187A5E740")]
		public string VGRJBLRPTNG(int a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600082C")]
		[Cpp2IlInjected.Address(RVA = "0xAC4840", Offset = "0xAC3640", VA = "0x180AC4840")]
		public ModifyTagsResponse()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000130")]
	[Utf8JsonSerializable]
	public class TagDTO : IRecNetUtf8JsonObject
	{
		[Cpp2IlInjected.Token(Token = "0x1700035D")]
		public string Tag
		{
			[Cpp2IlInjected.Token(Token = "0x600082D")]
			[Cpp2IlInjected.Address(RVA = "0xABD130", Offset = "0xABBF30", VA = "0x180ABD130")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600082E")]
			[Cpp2IlInjected.Address(RVA = "0xABD120", Offset = "0xABBF20", VA = "0x180ABD120")]
			[CompilerGenerated]
			internal set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700035E")]
		public TagType Type
		{
			[Cpp2IlInjected.Token(Token = "0x600082F")]
			[Cpp2IlInjected.Address(RVA = "0xAC7B20", Offset = "0xAC6920", VA = "0x180AC7B20")]
			[CompilerGenerated]
			get
			{
				return default(TagType);
			}
			[Cpp2IlInjected.Token(Token = "0x6000830")]
			[Cpp2IlInjected.Address(RVA = "0xACAE40", Offset = "0xAC9C40", VA = "0x180ACAE40")]
			[CompilerGenerated]
			internal set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000831")]
		[Cpp2IlInjected.Address(RVA = "0xABE8D0", Offset = "0xABD6D0", VA = "0x180ABE8D0", Slot = "4")]
		public void DNRPRHFLPRB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000832")]
		[Cpp2IlInjected.Address(RVA = "0xAC4840", Offset = "0xAC3640", VA = "0x180AC4840")]
		public TagDTO()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000131")]
	public static class QGUDQNUEYPP
	{
		[Cpp2IlInjected.Token(Token = "0x4000597")]
		public const string TMZSPKCYFSL = "costume";

		[Cpp2IlInjected.Token(Token = "0x4000598")]
		public const string NSKFECPBZBB = "gadget";

		[Cpp2IlInjected.Token(Token = "0x4000599")]
		public const string ERVZFDEPYVQ = "holotar";

		[Cpp2IlInjected.Token(Token = "0x400059A")]
		public const string ZIJPFYOUYNM = "large";

		[Cpp2IlInjected.Token(Token = "0x400059B")]
		public const string TQYSOLLZSXG = "medium";

		[Cpp2IlInjected.Token(Token = "0x400059C")]
		public const string FEJKICHUPVU = "small";

		[Cpp2IlInjected.Token(Token = "0x400059D")]
		public const string CGLVBJUIUIO = "sound";

		[Cpp2IlInjected.Token(Token = "0x400059E")]
		public const string WNFDTLGSLKZ = "dormanchor";

		[Cpp2IlInjected.Token(Token = "0x400059F")]
		public const string SYNWZJUYDPU = "reccenteranchor";

		[Cpp2IlInjected.Token(Token = "0x40005A0")]
		public const string CASYAYJMNVK = "r2";

		[Cpp2IlInjected.Token(Token = "0x1700035F")]
		public static List<string> TLRVPAPUMUK
		{
			[Cpp2IlInjected.Token(Token = "0x6000833")]
			[Cpp2IlInjected.Address(RVA = "0x7A5F740", Offset = "0x7A5E540", VA = "0x187A5F740")]
			get
			{
				return null;
			}
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000132")]
	public static class TREVSNDYTGC
	{
		[Cpp2IlInjected.Token(Token = "0x40005A1")]
		public const string QSOJQHZUTPV = "beta";

		[Cpp2IlInjected.Token(Token = "0x40005A2")]
		public const string SRBJCBFHHPC = "limitsv2";
	}
	[Cpp2IlInjected.Token(Token = "0x2000133")]
	[Utf8JsonSerializable]
	public class GetFiltersResponse : IRecNetUtf8JsonObject
	{
		[Cpp2IlInjected.Token(Token = "0x17000360")]
		public List<string> PinnedFilters
		{
			[Cpp2IlInjected.Token(Token = "0x6000834")]
			[Cpp2IlInjected.Address(RVA = "0xABD130", Offset = "0xABBF30", VA = "0x180ABD130")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000835")]
			[Cpp2IlInjected.Address(RVA = "0xABD120", Offset = "0xABBF20", VA = "0x180ABD120")]
			[CompilerGenerated]
			internal set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000361")]
		public List<string> PopularFilters
		{
			[Cpp2IlInjected.Token(Token = "0x6000836")]
			[Cpp2IlInjected.Address(RVA = "0xAC0D20", Offset = "0xABFB20", VA = "0x180AC0D20")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000837")]
			[Cpp2IlInjected.Address(RVA = "0xAC0D10", Offset = "0xABFB10", VA = "0x180AC0D10")]
			[CompilerGenerated]
			internal set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000362")]
		public List<string> TrendingFilters
		{
			[Cpp2IlInjected.Token(Token = "0x6000838")]
			[Cpp2IlInjected.Address(RVA = "0xAC1D20", Offset = "0xAC0B20", VA = "0x180AC1D20")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000839")]
			[Cpp2IlInjected.Address(RVA = "0xAC0640", Offset = "0xABF440", VA = "0x180AC0640")]
			[CompilerGenerated]
			internal set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600083A")]
		[Cpp2IlInjected.Address(RVA = "0xABE8D0", Offset = "0xABD6D0", VA = "0x180ABE8D0", Slot = "4")]
		public void DNRPRHFLPRB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600083B")]
		[Cpp2IlInjected.Address(RVA = "0xAC4840", Offset = "0xAC3640", VA = "0x180AC4840")]
		public GetFiltersResponse()
		{
		}
	}
}
namespace RecNet.NetworkSimulator
{
	[Cpp2IlInjected.Token(Token = "0x2000134")]
	public class FilterKey : IEquatable<FilterKey>
	{
		[Cpp2IlInjected.Token(Token = "0x17000363")]
		[CompilerGenerated]
		protected virtual Type AJGMYVEHKXH
		{
			[Cpp2IlInjected.Token(Token = "0x600083D")]
			[Cpp2IlInjected.Address(RVA = "0x7A5B9F0", Offset = "0x7A5A7F0", VA = "0x187A5B9F0", Slot = "5")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000364")]
		public Service? QQDQVPURIRY
		{
			[Cpp2IlInjected.Token(Token = "0x600083E")]
			[Cpp2IlInjected.Address(RVA = "0xABD130", Offset = "0xABBF30", VA = "0x180ABD130")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600083F")]
			[Cpp2IlInjected.Address(RVA = "0xEABA00", Offset = "0xEAA800", VA = "0x180EABA00")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000365")]
		public HttpMethod? TUOHUTAGYHY
		{
			[Cpp2IlInjected.Token(Token = "0x6000840")]
			[Cpp2IlInjected.Address(RVA = "0xAC0D20", Offset = "0xABFB20", VA = "0x180AC0D20")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000841")]
			[Cpp2IlInjected.Address(RVA = "0xAC0D10", Offset = "0xABFB10", VA = "0x180AC0D10")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000366")]
		public string? KLGNQXIUVNQ
		{
			[Cpp2IlInjected.Token(Token = "0x6000842")]
			[Cpp2IlInjected.Address(RVA = "0xAC1D20", Offset = "0xAC0B20", VA = "0x180AC1D20")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000843")]
			[Cpp2IlInjected.Address(RVA = "0xAC0640", Offset = "0xABF440", VA = "0x180AC0640")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600083C")]
		[Cpp2IlInjected.Address(RVA = "0x7A5BB90", Offset = "0x7A5A990", VA = "0x187A5BB90")]
		public FilterKey(Service? Service, HttpMethod? Method, string? RequestUriPrefix)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000844")]
		[Cpp2IlInjected.Address(RVA = "0x7A5BA40", Offset = "0x7A5A840", VA = "0x187A5BA40", Slot = "3")]
		[CompilerGenerated]
		public override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000845")]
		[Cpp2IlInjected.Address(RVA = "0x7A5B8C0", Offset = "0x7A5A6C0", VA = "0x187A5B8C0", Slot = "6")]
		[CompilerGenerated]
		protected virtual bool IKAQPGIIUAB(StringBuilder a)
		{
			return default(bool);
		}

		[SpecialName]
		[Cpp2IlInjected.Token(Token = "0x6000846")]
		[Cpp2IlInjected.Address(RVA = "0x12B3BA0", Offset = "0x12B29A0", VA = "0x1812B3BA0")]
		[CompilerGenerated]
		public static bool CQBJVGKOTGK(FilterKey? a, FilterKey? b)
		{
			return default(bool);
		}

		[SpecialName]
		[Cpp2IlInjected.Token(Token = "0x6000847")]
		[Cpp2IlInjected.Address(RVA = "0x12B3DF0", Offset = "0x12B2BF0", VA = "0x1812B3DF0")]
		[CompilerGenerated]
		public static bool GFBRUTYEXQF(FilterKey? a, FilterKey? b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000848")]
		[Cpp2IlInjected.Address(RVA = "0x7A5B750", Offset = "0x7A5A550", VA = "0x187A5B750", Slot = "2")]
		[CompilerGenerated]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000849")]
		[Cpp2IlInjected.Address(RVA = "0x7A5B530", Offset = "0x7A5A330", VA = "0x187A5B530", Slot = "0")]
		[CompilerGenerated]
		public override bool Equals(object? obj)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600084A")]
		[Cpp2IlInjected.Address(RVA = "0x7A5B5C0", Offset = "0x7A5A3C0", VA = "0x187A5B5C0", Slot = "7")]
		[CompilerGenerated]
		public virtual bool Equals(FilterKey? other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600084B")]
		[Cpp2IlInjected.Address(RVA = "0x7A5B4A0", Offset = "0x7A5A2A0", VA = "0x187A5B4A0", Slot = "8")]
		[CompilerGenerated]
		public virtual FilterKey BKCOQPLGRYQ()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600084C")]
		[Cpp2IlInjected.Address(RVA = "0x7A5BB30", Offset = "0x7A5A930", VA = "0x187A5BB30")]
		[CompilerGenerated]
		protected FilterKey(FilterKey original)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600084D")]
		[Cpp2IlInjected.Address(RVA = "0x7A5B9B0", Offset = "0x7A5A7B0", VA = "0x187A5B9B0")]
		[CompilerGenerated]
		public void KAKPPNOMYGN([Out] Service? a, [Out] HttpMethod? b, [Out] string? c)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000135")]
	public class FilterAction : IEquatable<FilterAction>
	{
		[Cpp2IlInjected.Token(Token = "0x17000367")]
		[CompilerGenerated]
		protected virtual Type AJGMYVEHKXH
		{
			[Cpp2IlInjected.Token(Token = "0x600084F")]
			[Cpp2IlInjected.Address(RVA = "0x7A5B350", Offset = "0x7A5A150", VA = "0x187A5B350", Slot = "5")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000368")]
		public int MSQNDZVTFJZ
		{
			[Cpp2IlInjected.Token(Token = "0x6000850")]
			[Cpp2IlInjected.Address(RVA = "0xABD110", Offset = "0xABBF10", VA = "0x180ABD110")]
			[CompilerGenerated]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x6000851")]
			[Cpp2IlInjected.Address(RVA = "0xAC1D40", Offset = "0xAC0B40", VA = "0x180AC1D40")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000369")]
		public FailureModes BRRJOMGZQSM
		{
			[Cpp2IlInjected.Token(Token = "0x6000852")]
			[Cpp2IlInjected.Address(RVA = "0xBBC350", Offset = "0xBBB150", VA = "0x180BBC350")]
			[CompilerGenerated]
			get
			{
				return default(FailureModes);
			}
			[Cpp2IlInjected.Token(Token = "0x6000853")]
			[Cpp2IlInjected.Address(RVA = "0xBBC340", Offset = "0xBBB140", VA = "0x180BBC340")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600084E")]
		[Cpp2IlInjected.Address(RVA = "0x7A5B490", Offset = "0x7A5A290", VA = "0x187A5B490")]
		public FilterAction(int MillisecondDelay, FailureModes FailureMode)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000854")]
		[Cpp2IlInjected.Address(RVA = "0x7A5B3A0", Offset = "0x7A5A1A0", VA = "0x187A5B3A0", Slot = "3")]
		[CompilerGenerated]
		public override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000855")]
		[Cpp2IlInjected.Address(RVA = "0x7A5B250", Offset = "0x7A5A050", VA = "0x187A5B250", Slot = "6")]
		[CompilerGenerated]
		protected virtual bool IKAQPGIIUAB(StringBuilder a)
		{
			return default(bool);
		}

		[SpecialName]
		[Cpp2IlInjected.Token(Token = "0x6000856")]
		[Cpp2IlInjected.Address(RVA = "0x12B3BA0", Offset = "0x12B29A0", VA = "0x1812B3BA0")]
		[CompilerGenerated]
		public static bool CQBJVGKOTGK(FilterAction? a, FilterAction? b)
		{
			return default(bool);
		}

		[SpecialName]
		[Cpp2IlInjected.Token(Token = "0x6000857")]
		[Cpp2IlInjected.Address(RVA = "0x12B3DF0", Offset = "0x12B2BF0", VA = "0x1812B3DF0")]
		[CompilerGenerated]
		public static bool GFBRUTYEXQF(FilterAction? a, FilterAction? b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000858")]
		[Cpp2IlInjected.Address(RVA = "0x7A5B140", Offset = "0x7A59F40", VA = "0x187A5B140", Slot = "2")]
		[CompilerGenerated]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000859")]
		[Cpp2IlInjected.Address(RVA = "0x7A5B0B0", Offset = "0x7A59EB0", VA = "0x187A5B0B0", Slot = "0")]
		[CompilerGenerated]
		public override bool Equals(object? obj)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600085A")]
		[Cpp2IlInjected.Address(RVA = "0x7A5AF70", Offset = "0x7A59D70", VA = "0x187A5AF70", Slot = "7")]
		[CompilerGenerated]
		public virtual bool Equals(FilterAction? other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600085B")]
		[Cpp2IlInjected.Address(RVA = "0x7A5AF00", Offset = "0x7A59D00", VA = "0x187A5AF00", Slot = "8")]
		[CompilerGenerated]
		public virtual FilterAction BKCOQPLGRYQ()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600085C")]
		[Cpp2IlInjected.Address(RVA = "0xD16B60", Offset = "0xD15960", VA = "0x180D16B60")]
		[CompilerGenerated]
		protected FilterAction(FilterAction original)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600085D")]
		[Cpp2IlInjected.Address(RVA = "0x7A5B340", Offset = "0x7A5A140", VA = "0x187A5B340")]
		[CompilerGenerated]
		public void KAKPPNOMYGN([Out] int a, [Out] FailureModes b)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000136")]
	public enum FailureModes
	{
		[Cpp2IlInjected.Token(Token = "0x40005AC")]
		None,
		[Cpp2IlInjected.Token(Token = "0x40005AD")]
		ConnectionTimeout,
		[Cpp2IlInjected.Token(Token = "0x40005AE")]
		InternalServerError
	}
	[Cpp2IlInjected.Token(Token = "0x2000137")]
	public interface BOXCMRRGEDR
	{
		[Cpp2IlInjected.Token(Token = "0x600085E")]
		[Cpp2IlInjected.Address(Slot = "0")]
		IReadOnlyDictionary<FilterKey, FilterAction> PZISQKNTFQE();

		[Cpp2IlInjected.Token(Token = "0x600085F")]
		[Cpp2IlInjected.Address(Slot = "1")]
		void WFTVTFGILVR(FilterKey a, FilterAction b);

		[Cpp2IlInjected.Token(Token = "0x6000860")]
		[Cpp2IlInjected.Address(Slot = "2")]
		void JNZCEPMFYIN(FilterKey a);

		[Cpp2IlInjected.Token(Token = "0x6000861")]
		[Cpp2IlInjected.Address(Slot = "3")]
		void BLTAQAUXVLH();

		[Cpp2IlInjected.Token(Token = "0x6000862")]
		[Cpp2IlInjected.Address(Slot = "4")]
		Task FXWQWBRTRKY(Service a, HttpMethod b, string c, CancellationToken d);
	}
}
namespace RecNet.Common
{
	[Cpp2IlInjected.Token(Token = "0x2000138")]
	[Utf8JsonSerializableGeneric]
	public class MJUEXNDRTSY<a> where a : IRecNetUtf8JsonObject, new()
	{
		[Cpp2IlInjected.Token(Token = "0x1700036A")]
		public IReadOnlyList<a> OOAPGIDKWRV
		{
			[Cpp2IlInjected.Token(Token = "0x6000863")]
			[Cpp2IlInjected.Address(RVA = "0xABD130", Offset = "0xABBF30", VA = "0x180ABD130")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000864")]
			[Cpp2IlInjected.Address(RVA = "0xABD120", Offset = "0xABBF20", VA = "0x180ABD120")]
			[CompilerGenerated]
			internal set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700036B")]
		public long WSTETWWAUAP
		{
			[Cpp2IlInjected.Token(Token = "0x6000865")]
			[Cpp2IlInjected.Address(RVA = "0xAC0D20", Offset = "0xABFB20", VA = "0x180AC0D20")]
			[CompilerGenerated]
			get
			{
				return default(long);
			}
			[Cpp2IlInjected.Token(Token = "0x6000866")]
			[Cpp2IlInjected.Address(RVA = "0xE27A80", Offset = "0xE26880", VA = "0x180E27A80")]
			[CompilerGenerated]
			internal set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000867")]
		[Cpp2IlInjected.Address(RVA = "0xAC4840", Offset = "0xAC3640", VA = "0x180AC4840")]
		public MJUEXNDRTSY()
		{
		}
	}
}
namespace RecNet.Common.PlatformPartners
{
	[Cpp2IlInjected.Token(Token = "0x2000139")]
	public enum PlayStationEnvironment
	{
		[Cpp2IlInjected.Token(Token = "0x40005B2")]
		Development = 1,
		[Cpp2IlInjected.Token(Token = "0x40005B3")]
		QA = 8,
		[Cpp2IlInjected.Token(Token = "0x40005B4")]
		Production = 0x100
	}
}
namespace RecNet.Store
{
	[Cpp2IlInjected.Token(Token = "0x200013A")]
	public interface NFGFAVEOVGR : EKFPOTOCRBP
	{
		[Cpp2IlInjected.Token(Token = "0x1700036C")]
		bool MNEHTYIFAYO
		{
			[Cpp2IlInjected.Token(Token = "0x6000868")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x6000869")]
		[Cpp2IlInjected.Address(Slot = "1")]
		Task AuthorizePurchaseAsync(long transactionId, SKU sku);

		[Cpp2IlInjected.Token(Token = "0x600086A")]
		[Cpp2IlInjected.Address(Slot = "2")]
		Task<MPNRIWAASCV> PurchaseAsync(SKU sku, SkuPurchaseMetadata purchaseMetadata);

		[Cpp2IlInjected.Token(Token = "0x600086B")]
		[Cpp2IlInjected.Address(Slot = "3")]
		Task ValidatePurchasingSupported(WRKWUZDACKV skuTransaction, CancellationToken cancellationToken);
	}
	[Cpp2IlInjected.Token(Token = "0x200013B")]
	public interface EKFPOTOCRBP
	{
		[Cpp2IlInjected.Token(Token = "0x1700036D")]
		bool BABUQEPRDVJ
		{
			[Cpp2IlInjected.Token(Token = "0x600086C")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x600086D")]
		[Cpp2IlInjected.Address(Slot = "1")]
		Task<string> FetchCommerceAccessToken([Optional] CancellationToken cancellationToken);
	}
	[Cpp2IlInjected.Token(Token = "0x200013C")]
	public interface YDYRRQVTUND
	{
		[Cpp2IlInjected.Token(Token = "0x1700036E")]
		int ZSKDHUDFACC
		{
			[Cpp2IlInjected.Token(Token = "0x6000872")]
			[Cpp2IlInjected.Address(Slot = "4")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x600086E")]
		[Cpp2IlInjected.Address(Slot = "0")]
		Task<IReadOnlyList<SKU>> MRODKONPEVI(bool a = false, [Optional] CancellationToken b);

		[Cpp2IlInjected.Token(Token = "0x600086F")]
		[Cpp2IlInjected.Address(Slot = "1")]
		bool EASYDMOBWES([Out] SKU? a);

		[Cpp2IlInjected.Token(Token = "0x6000870")]
		[Cpp2IlInjected.Address(Slot = "2")]
		Task<SKU> ZJWMDKIQQFY(bool a = false, [Optional] CancellationToken b);

		[Cpp2IlInjected.Token(Token = "0x6000871")]
		[Cpp2IlInjected.Address(Slot = "3")]
		void PDFBVQAECXE(string a = "");
	}
	[Cpp2IlInjected.Token(Token = "0x200013D")]
	public interface PICPVTJCYGJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000873")]
		[Cpp2IlInjected.Address(Slot = "0")]
		Task EUGKYJEDKNT(WRKWUZDACKV a, CancellationToken b);

		[Cpp2IlInjected.Token(Token = "0x6000874")]
		[Cpp2IlInjected.Address(Slot = "1")]
		Task PRTBRJMNIXD(WRKWUZDACKV a, CancellationToken b, [Optional] XHRIDFGQZQW? purchaseProgress);
	}
	[Cpp2IlInjected.Token(Token = "0x200013E")]
	public interface XHRIDFGQZQW
	{
		[Cpp2IlInjected.Token(Token = "0x6000875")]
		[Cpp2IlInjected.Address(Slot = "0")]
		void AZUPMVHWXVL(string a);
	}
	[Cpp2IlInjected.Token(Token = "0x200013F")]
	public interface JNQCBQEJQAQ
	{
		[Cpp2IlInjected.Token(Token = "0x6000876")]
		[Cpp2IlInjected.Address(Slot = "0")]
		Task CVXZNMRZFYX(WRKWUZDACKV a, CancellationToken b);
	}
	[Cpp2IlInjected.Token(Token = "0x2000140")]
	public interface PZTJCEZXLCQ
	{
		[Cpp2IlInjected.Token(Token = "0x1700036F")]
		bool IKNQXGRWNBO
		{
			[Cpp2IlInjected.Token(Token = "0x6000877")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000141")]
	public interface TNQTXTNFHPJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000878")]
		[Cpp2IlInjected.Address(Slot = "0")]
		WRKWUZDACKV QSREDTUFDHX(SKU a, SkuPurchaseMetadata b, string c, [Optional] PICPVTJCYGJ? purchaseProcessorBehaviorOverride);
	}
	[Cpp2IlInjected.Token(Token = "0x2000142")]
	public interface RFTCOYWQOUO
	{
		[Cpp2IlInjected.Token(Token = "0x6000879")]
		[Cpp2IlInjected.Address(Slot = "0")]
		bool XORTXTGTYXS(JNQCBQEJQAQ a);

		[Cpp2IlInjected.Token(Token = "0x600087A")]
		[Cpp2IlInjected.Address(Slot = "1")]
		bool OOSSRPBSDWJ(JNQCBQEJQAQ a);

		[Cpp2IlInjected.Token(Token = "0x600087B")]
		[Cpp2IlInjected.Address(Slot = "2")]
		Task GZTBGETGKMP(WRKWUZDACKV a, CancellationToken b);
	}
	[Cpp2IlInjected.Token(Token = "0x2000143")]
	public interface WRKWUZDACKV : IDisposable
	{
		[Cpp2IlInjected.Token(Token = "0x17000370")]
		TransactionState VIIDACNXBXI
		{
			[Cpp2IlInjected.Token(Token = "0x600087C")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000371")]
		SKU CEPLHZISNGQ
		{
			[Cpp2IlInjected.Token(Token = "0x600087D")]
			[Cpp2IlInjected.Address(Slot = "1")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000372")]
		SkuPurchaseMetadata SLXZHWDMZSV
		{
			[Cpp2IlInjected.Token(Token = "0x600087E")]
			[Cpp2IlInjected.Address(Slot = "2")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000373")]
		string ZXLCDZSVSBE
		{
			[Cpp2IlInjected.Token(Token = "0x600087F")]
			[Cpp2IlInjected.Address(Slot = "3")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000374")]
		string ZAUMDXYOJBL
		{
			[Cpp2IlInjected.Token(Token = "0x6000880")]
			[Cpp2IlInjected.Address(Slot = "4")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x6000881")]
		[Cpp2IlInjected.Address(Slot = "5")]
		Task<SkuPurchaseResult> Purchase(CancellationToken externalToken, [Optional] XHRIDFGQZQW? purchaseProgress);

		[Cpp2IlInjected.Token(Token = "0x6000882")]
		[Cpp2IlInjected.Address(Slot = "6")]
		void OFNTEOFHFYJ(string a);

		[Cpp2IlInjected.Token(Token = "0x6000883")]
		[Cpp2IlInjected.Address(Slot = "7")]
		void OFNTEOFHFYJ<a>(Func<a, string> a, [In] a msgArgs);
	}
	[Cpp2IlInjected.Token(Token = "0x2000144")]
	public abstract class ZCTPRFDQWYZ
	{
		[Cpp2IlInjected.Token(Token = "0x6000884")]
		[Cpp2IlInjected.Address(RVA = "0xAC4840", Offset = "0xAC3640", VA = "0x180AC4840")]
		protected ZCTPRFDQWYZ()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000145")]
	public enum PurchaseFailureError
	{
		[Cpp2IlInjected.Token(Token = "0x40005B6")]
		Unknown,
		[Cpp2IlInjected.Token(Token = "0x40005B7")]
		InAppPurchaseNotAllowedOnAccount,
		[Cpp2IlInjected.Token(Token = "0x40005B8")]
		PlatformPurchaseException,
		[Cpp2IlInjected.Token(Token = "0x40005B9")]
		PlatformPurchaseFailure,
		[Cpp2IlInjected.Token(Token = "0x40005BA")]
		CommerceInitiatePurchaseFailure,
		[Cpp2IlInjected.Token(Token = "0x40005BB")]
		FailedToGetPlatformAccessToken,
		[Cpp2IlInjected.Token(Token = "0x40005BC")]
		PlatformAuthorizePurchaseFailure,
		[Cpp2IlInjected.Token(Token = "0x40005BD")]
		CommerceCompletePurchaseFailure,
		[Cpp2IlInjected.Token(Token = "0x40005BE")]
		PlatformSubscriptionNotSupported,
		[Cpp2IlInjected.Token(Token = "0x40005BF")]
		PlatformPurchasesNotSupported,
		[Cpp2IlInjected.Token(Token = "0x40005C0")]
		OculusDesktopPlayersMustBeInVR,
		[Cpp2IlInjected.Token(Token = "0x40005C1")]
		FailedToRetrieveParentalControls,
		[Cpp2IlInjected.Token(Token = "0x40005C2")]
		UserCanceled,
		[Cpp2IlInjected.Token(Token = "0x40005C3")]
		DebugError
	}
	[Cpp2IlInjected.Token(Token = "0x2000146")]
	public enum PurchaseFailureType : byte
	{
		[Cpp2IlInjected.Token(Token = "0x40005C5")]
		Unknown,
		[Cpp2IlInjected.Token(Token = "0x40005C6")]
		AccountError,
		[Cpp2IlInjected.Token(Token = "0x40005C7")]
		PlatformError,
		[Cpp2IlInjected.Token(Token = "0x40005C8")]
		CommerceError,
		[Cpp2IlInjected.Token(Token = "0x40005C9")]
		UserAction
	}
	[Cpp2IlInjected.Token(Token = "0x2000147")]
	[Utf8JsonSerializable]
	public class SKU : IRecNetUtf8JsonObject
	{
		[Cpp2IlInjected.Token(Token = "0x17000375")]
		public int SkuId
		{
			[Cpp2IlInjected.Token(Token = "0x6000885")]
			[Cpp2IlInjected.Address(RVA = "0xABD110", Offset = "0xABBF10", VA = "0x180ABD110")]
			[CompilerGenerated]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x6000886")]
			[Cpp2IlInjected.Address(RVA = "0xAC1D40", Offset = "0xAC0B40", VA = "0x180AC1D40")]
			[CompilerGenerated]
			internal set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000376")]
		public string Name
		{
			[Cpp2IlInjected.Token(Token = "0x6000887")]
			[Cpp2IlInjected.Address(RVA = "0xAC0D20", Offset = "0xABFB20", VA = "0x180AC0D20")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000888")]
			[Cpp2IlInjected.Address(RVA = "0xAC0D10", Offset = "0xABFB10", VA = "0x180AC0D10")]
			[CompilerGenerated]
			internal set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000377")]
		public string Description
		{
			[Cpp2IlInjected.Token(Token = "0x6000889")]
			[Cpp2IlInjected.Address(RVA = "0xAC1D20", Offset = "0xAC0B20", VA = "0x180AC1D20")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600088A")]
			[Cpp2IlInjected.Address(RVA = "0xAC0640", Offset = "0xABF440", VA = "0x180AC0640")]
			[CompilerGenerated]
			internal set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000378")]
		public string ImageName
		{
			[Cpp2IlInjected.Token(Token = "0x600088B")]
			[Cpp2IlInjected.Address(RVA = "0xAC0F90", Offset = "0xABFD90", VA = "0x180AC0F90")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600088C")]
			[Cpp2IlInjected.Address(RVA = "0xAC0650", Offset = "0xABF450", VA = "0x180AC0650")]
			[CompilerGenerated]
			internal set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000379")]
		public int Price
		{
			[Cpp2IlInjected.Token(Token = "0x600088D")]
			[Cpp2IlInjected.Address(RVA = "0xAC6560", Offset = "0xAC5360", VA = "0x180AC6560")]
			[CompilerGenerated]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x600088E")]
			[Cpp2IlInjected.Address(RVA = "0xAC6870", Offset = "0xAC5670", VA = "0x180AC6870")]
			[CompilerGenerated]
			internal set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700037A")]
		public string OculusSkuId
		{
			[Cpp2IlInjected.Token(Token = "0x600088F")]
			[Cpp2IlInjected.Address(RVA = "0xAC0FC0", Offset = "0xABFDC0", VA = "0x180AC0FC0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000890")]
			[Cpp2IlInjected.Address(RVA = "0xAC0CF0", Offset = "0xABFAF0", VA = "0x180AC0CF0")]
			[CompilerGenerated]
			internal set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700037B")]
		public string AppleProductId
		{
			[Cpp2IlInjected.Token(Token = "0x6000891")]
			[Cpp2IlInjected.Address(RVA = "0xAC5120", Offset = "0xAC3F20", VA = "0x180AC5120")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000892")]
			[Cpp2IlInjected.Address(RVA = "0xAC0FB0", Offset = "0xABFDB0", VA = "0x180AC0FB0")]
			[CompilerGenerated]
			internal set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700037C")]
		[DataMember(Name = "PsnProductLabel")]
		public string PSNProductLabel
		{
			[Cpp2IlInjected.Token(Token = "0x6000893")]
			[Cpp2IlInjected.Address(RVA = "0xAC0D30", Offset = "0xABFB30", VA = "0x180AC0D30")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000894")]
			[Cpp2IlInjected.Address(RVA = "0xAC1370", Offset = "0xAC0170", VA = "0x180AC1370")]
			[CompilerGenerated]
			internal set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700037D")]
		public string XboxProductId
		{
			[Cpp2IlInjected.Token(Token = "0x6000895")]
			[Cpp2IlInjected.Address(RVA = "0xAC31E0", Offset = "0xAC1FE0", VA = "0x180AC31E0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000896")]
			[Cpp2IlInjected.Address(RVA = "0xAC31C0", Offset = "0xAC1FC0", VA = "0x180AC31C0")]
			[CompilerGenerated]
			internal set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700037E")]
		public string XboxStoreId
		{
			[Cpp2IlInjected.Token(Token = "0x6000897")]
			[Cpp2IlInjected.Address(RVA = "0xAC3430", Offset = "0xAC2230", VA = "0x180AC3430")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000898")]
			[Cpp2IlInjected.Address(RVA = "0xAC31B0", Offset = "0xAC1FB0", VA = "0x180AC31B0")]
			[CompilerGenerated]
			internal set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700037F")]
		public string GooglePlaySkuId
		{
			[Cpp2IlInjected.Token(Token = "0x6000899")]
			[Cpp2IlInjected.Address(RVA = "0xAC31D0", Offset = "0xAC1FD0", VA = "0x180AC31D0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600089A")]
			[Cpp2IlInjected.Address(RVA = "0xAC3420", Offset = "0xAC2220", VA = "0x180AC3420")]
			[CompilerGenerated]
			internal set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000380")]
		public string PicoSkuId
		{
			[Cpp2IlInjected.Token(Token = "0x600089B")]
			[Cpp2IlInjected.Address(RVA = "0xAC3410", Offset = "0xAC2210", VA = "0x180AC3410")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600089C")]
			[Cpp2IlInjected.Address(RVA = "0xAC31A0", Offset = "0xAC1FA0", VA = "0x180AC31A0")]
			[CompilerGenerated]
			internal set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000381")]
		public string NintendoSkuId
		{
			[Cpp2IlInjected.Token(Token = "0x600089D")]
			[Cpp2IlInjected.Address(RVA = "0xAC50D0", Offset = "0xAC3ED0", VA = "0x180AC50D0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600089E")]
			[Cpp2IlInjected.Address(RVA = "0xAC58D0", Offset = "0xAC46D0", VA = "0x180AC58D0")]
			[CompilerGenerated]
			internal set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000382")]
		public bool IsSingleUse
		{
			[Cpp2IlInjected.Token(Token = "0x600089F")]
			[Cpp2IlInjected.Address(RVA = "0xFC0E90", Offset = "0xFBFC90", VA = "0x180FC0E90")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x60008A0")]
			[Cpp2IlInjected.Address(RVA = "0xFBFE70", Offset = "0xFBEC70", VA = "0x180FBFE70")]
			[CompilerGenerated]
			internal set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000383")]
		public bool ShouldAppearInTokenStore
		{
			[Cpp2IlInjected.Token(Token = "0x60008A1")]
			[Cpp2IlInjected.Address(RVA = "0x199B090", Offset = "0x1999E90", VA = "0x18199B090")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x60008A2")]
			[Cpp2IlInjected.Address(RVA = "0x199ABB0", Offset = "0x19999B0", VA = "0x18199ABB0")]
			[CompilerGenerated]
			internal set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000384")]
		public SKUData Data
		{
			[Cpp2IlInjected.Token(Token = "0x60008A3")]
			[Cpp2IlInjected.Address(RVA = "0xAC7AA0", Offset = "0xAC68A0", VA = "0x180AC7AA0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60008A4")]
			[Cpp2IlInjected.Address(RVA = "0xAC8140", Offset = "0xAC6F40", VA = "0x180AC8140")]
			[CompilerGenerated]
			internal set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000385")]
		[IgnoreDataMember]
		public string DisplayPrice
		{
			[Cpp2IlInjected.Token(Token = "0x60008A5")]
			[Cpp2IlInjected.Address(RVA = "0xAC7B00", Offset = "0xAC6900", VA = "0x180AC7B00")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60008A6")]
			[Cpp2IlInjected.Address(RVA = "0xAC81D0", Offset = "0xAC6FD0", VA = "0x180AC81D0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000386")]
		[IgnoreDataMember]
		public string LongDescription
		{
			[Cpp2IlInjected.Token(Token = "0x60008A7")]
			[Cpp2IlInjected.Address(RVA = "0xAEDD70", Offset = "0xAECB70", VA = "0x180AEDD70")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60008A8")]
			[Cpp2IlInjected.Address(RVA = "0xB880F0", Offset = "0xB86EF0", VA = "0x180B880F0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000387")]
		[IgnoreDataMember]
		public string ConfirmationMessage
		{
			[Cpp2IlInjected.Token(Token = "0x60008A9")]
			[Cpp2IlInjected.Address(RVA = "0xAC7A60", Offset = "0xAC6860", VA = "0x180AC7A60")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60008AA")]
			[Cpp2IlInjected.Address(RVA = "0xAC7AB0", Offset = "0xAC68B0", VA = "0x180AC7AB0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000388")]
		[IgnoreDataMember]
		public ZCTPRFDQWYZ PlatformSku
		{
			[Cpp2IlInjected.Token(Token = "0x60008AB")]
			[Cpp2IlInjected.Address(RVA = "0xB882D0", Offset = "0xB870D0", VA = "0x180B882D0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60008AC")]
			[Cpp2IlInjected.Address(RVA = "0xB88330", Offset = "0xB87130", VA = "0x180B88330")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000389")]
		[IgnoreDataMember]
		public bool IsSubscription
		{
			[Cpp2IlInjected.Token(Token = "0x60008AD")]
			[Cpp2IlInjected.Address(RVA = "0x7A61300", Offset = "0x7A60100", VA = "0x187A61300")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700038A")]
		[IgnoreDataMember]
		public string ThumbnailImageName
		{
			[Cpp2IlInjected.Token(Token = "0x60008AE")]
			[Cpp2IlInjected.Address(RVA = "0xAC7160", Offset = "0xAC5F60", VA = "0x180AC7160")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60008AF")]
			[Cpp2IlInjected.Address(RVA = "0xAC7450", Offset = "0xAC6250", VA = "0x180AC7450")]
			[CompilerGenerated]
			internal set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60008B0")]
		[Cpp2IlInjected.Address(RVA = "0x7A61110", Offset = "0x7A5FF10", VA = "0x187A61110", Slot = "4")]
		public void DNRPRHFLPRB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60008B1")]
		[Cpp2IlInjected.Address(RVA = "0x7A61260", Offset = "0x7A60060", VA = "0x187A61260")]
		public static SKU ZLKPMLVHMKC(int a, string b, string c)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60008B2")]
		[Cpp2IlInjected.Address(RVA = "0x7A61200", Offset = "0x7A60000", VA = "0x187A61200", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60008B3")]
		[Cpp2IlInjected.Address(RVA = "0xAC4840", Offset = "0xAC3640", VA = "0x180AC4840")]
		public SKU()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000148")]
	[Utf8JsonSerializable]
	public class SKUData : IRecNetUtf8JsonObject
	{
		[Cpp2IlInjected.Token(Token = "0x1700038B")]
		public List<int> GiftDropIds
		{
			[Cpp2IlInjected.Token(Token = "0x60008B4")]
			[Cpp2IlInjected.Address(RVA = "0xABD130", Offset = "0xABBF30", VA = "0x180ABD130")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60008B5")]
			[Cpp2IlInjected.Address(RVA = "0xABD120", Offset = "0xABBF20", VA = "0x180ABD120")]
			[CompilerGenerated]
			internal set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700038C")]
		public string Message
		{
			[Cpp2IlInjected.Token(Token = "0x60008B6")]
			[Cpp2IlInjected.Address(RVA = "0xAC0D20", Offset = "0xABFB20", VA = "0x180AC0D20")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60008B7")]
			[Cpp2IlInjected.Address(RVA = "0xAC0D10", Offset = "0xABFB10", VA = "0x180AC0D10")]
			[CompilerGenerated]
			internal set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700038D")]
		public SubscriptionPurchase SubscriptionPurchase
		{
			[Cpp2IlInjected.Token(Token = "0x60008B8")]
			[Cpp2IlInjected.Address(RVA = "0xAC1D20", Offset = "0xAC0B20", VA = "0x180AC1D20")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60008B9")]
			[Cpp2IlInjected.Address(RVA = "0xAC0640", Offset = "0xABF440", VA = "0x180AC0640")]
			[CompilerGenerated]
			internal set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60008BA")]
		[Cpp2IlInjected.Address(RVA = "0x1091BE0", Offset = "0x10909E0", VA = "0x181091BE0", Slot = "4")]
		public void DNRPRHFLPRB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60008BB")]
		[Cpp2IlInjected.Address(RVA = "0xAC4840", Offset = "0xAC3640", VA = "0x180AC4840")]
		public SKUData()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000149")]
	public readonly struct SkuPurchaseResult
	{
		[Cpp2IlInjected.Token(Token = "0x200014A")]
		public enum States : byte
		{
			[Cpp2IlInjected.Token(Token = "0x40005E6")]
			Error,
			[Cpp2IlInjected.Token(Token = "0x40005E7")]
			CancelledByUser,
			[Cpp2IlInjected.Token(Token = "0x40005E8")]
			Success
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40005E2")]
		public readonly States State;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1")]
		[Cpp2IlInjected.Token(Token = "0x40005E3")]
		public readonly PurchaseFailureType PurchaseFailureType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x40005E4")]
		public readonly PurchaseFailureError PurchaseFailureError;

		[Cpp2IlInjected.Token(Token = "0x60008BC")]
		[Cpp2IlInjected.Address(RVA = "0x7A61B70", Offset = "0x7A60970", VA = "0x187A61B70")]
		private SkuPurchaseResult(States state, PurchaseFailureType purchaseFailureType = PurchaseFailureType.Unknown, PurchaseFailureError purchaseFailureError = PurchaseFailureError.Unknown)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60008BD")]
		[Cpp2IlInjected.Address(RVA = "0x7A61B50", Offset = "0x7A60950", VA = "0x187A61B50")]
		public static SkuPurchaseResult Success()
		{
			return default(SkuPurchaseResult);
		}

		[Cpp2IlInjected.Token(Token = "0x60008BE")]
		[Cpp2IlInjected.Address(RVA = "0x7A61B10", Offset = "0x7A60910", VA = "0x187A61B10")]
		public static SkuPurchaseResult Cancelled()
		{
			return default(SkuPurchaseResult);
		}

		[Cpp2IlInjected.Token(Token = "0x60008BF")]
		[Cpp2IlInjected.Address(RVA = "0x7A61B30", Offset = "0x7A60930", VA = "0x187A61B30")]
		public static SkuPurchaseResult Error(PurchaseFailureType purchaseFailureType, PurchaseFailureError purchaseFailureError)
		{
			return default(SkuPurchaseResult);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200014B")]
	public enum SubscriptionLevel
	{
		[Cpp2IlInjected.Token(Token = "0x40005EA")]
		Gold,
		[Cpp2IlInjected.Token(Token = "0x40005EB")]
		Platinum
	}
	[Cpp2IlInjected.Token(Token = "0x200014C")]
	public enum SubscriptionPeriod
	{
		[Cpp2IlInjected.Token(Token = "0x40005ED")]
		Month,
		[Cpp2IlInjected.Token(Token = "0x40005EE")]
		Year,
		[Cpp2IlInjected.Token(Token = "0x40005EF")]
		ThreeMonth,
		[Cpp2IlInjected.Token(Token = "0x40005F0")]
		SixMonth
	}
	[Cpp2IlInjected.Token(Token = "0x200014D")]
	[Utf8JsonSerializable]
	public class SubscriptionPurchase : IRecNetUtf8JsonObject
	{
		[Cpp2IlInjected.Token(Token = "0x1700038E")]
		public SubscriptionLevel Level
		{
			[Cpp2IlInjected.Token(Token = "0x60008C0")]
			[Cpp2IlInjected.Address(RVA = "0xABD110", Offset = "0xABBF10", VA = "0x180ABD110")]
			[CompilerGenerated]
			get
			{
				return default(SubscriptionLevel);
			}
			[Cpp2IlInjected.Token(Token = "0x60008C1")]
			[Cpp2IlInjected.Address(RVA = "0xAC1D40", Offset = "0xAC0B40", VA = "0x180AC1D40")]
			[CompilerGenerated]
			internal set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700038F")]
		public SubscriptionPeriod Period
		{
			[Cpp2IlInjected.Token(Token = "0x60008C2")]
			[Cpp2IlInjected.Address(RVA = "0xBBC350", Offset = "0xBBB150", VA = "0x180BBC350")]
			[CompilerGenerated]
			get
			{
				return default(SubscriptionPeriod);
			}
			[Cpp2IlInjected.Token(Token = "0x60008C3")]
			[Cpp2IlInjected.Address(RVA = "0xBBC340", Offset = "0xBBB140", VA = "0x180BBC340")]
			[CompilerGenerated]
			internal set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000390")]
		public bool IsAutoRenewing
		{
			[Cpp2IlInjected.Token(Token = "0x60008C4")]
			[Cpp2IlInjected.Address(RVA = "0xB40C50", Offset = "0xB3FA50", VA = "0x180B40C50")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x60008C5")]
			[Cpp2IlInjected.Address(RVA = "0xABD140", Offset = "0xABBF40", VA = "0x180ABD140")]
			[CompilerGenerated]
			internal set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60008C6")]
		[Cpp2IlInjected.Address(RVA = "0xABE8D0", Offset = "0xABD6D0", VA = "0x180ABE8D0", Slot = "4")]
		public void DNRPRHFLPRB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60008C7")]
		[Cpp2IlInjected.Address(RVA = "0xAC4840", Offset = "0xAC3640", VA = "0x180AC4840")]
		public SubscriptionPurchase()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200014E")]
	public enum TransactionState
	{
		[Cpp2IlInjected.Token(Token = "0x40005F5")]
		Error = -2,
		[Cpp2IlInjected.Token(Token = "0x40005F6")]
		Cancelled,
		[Cpp2IlInjected.Token(Token = "0x40005F7")]
		Uninitialized,
		[Cpp2IlInjected.Token(Token = "0x40005F8")]
		AttemptStarted,
		[Cpp2IlInjected.Token(Token = "0x40005F9")]
		PurchaseComplete
	}
}
namespace RecNet.AI
{
	[Cpp2IlInjected.Token(Token = "0x200014F")]
	[Utf8JsonSerializable]
	public class RoomieEnergyDTO : IRecNetUtf8JsonObject
	{
		[Cpp2IlInjected.Token(Token = "0x17000391")]
		public long MaxEnergyFromSubscriptions
		{
			[Cpp2IlInjected.Token(Token = "0x60008C8")]
			[Cpp2IlInjected.Address(RVA = "0xABD130", Offset = "0xABBF30", VA = "0x180ABD130")]
			[CompilerGenerated]
			get
			{
				return default(long);
			}
			[Cpp2IlInjected.Token(Token = "0x60008C9")]
			[Cpp2IlInjected.Address(RVA = "0xEABA00", Offset = "0xEAA800", VA = "0x180EABA00")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000392")]
		public long EnergyLeft
		{
			[Cpp2IlInjected.Token(Token = "0x60008CA")]
			[Cpp2IlInjected.Address(RVA = "0xAC0D20", Offset = "0xABFB20", VA = "0x180AC0D20")]
			[CompilerGenerated]
			get
			{
				return default(long);
			}
			[Cpp2IlInjected.Token(Token = "0x60008CB")]
			[Cpp2IlInjected.Address(RVA = "0xE27A80", Offset = "0xE26880", VA = "0x180E27A80")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000393")]
		public bool OutputAudioEnabled
		{
			[Cpp2IlInjected.Token(Token = "0x60008CC")]
			[Cpp2IlInjected.Address(RVA = "0xAC1360", Offset = "0xAC0160", VA = "0x180AC1360")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x60008CD")]
			[Cpp2IlInjected.Address(RVA = "0xAC0FD0", Offset = "0xABFDD0", VA = "0x180AC0FD0")]
			[CompilerGenerated]
			internal set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60008CE")]
		[Cpp2IlInjected.Address(RVA = "0xABE8D0", Offset = "0xABD6D0", VA = "0x180ABE8D0", Slot = "4")]
		public void DNRPRHFLPRB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60008CF")]
		[Cpp2IlInjected.Address(RVA = "0xAC4840", Offset = "0xAC3640", VA = "0x180AC4840")]
		public RoomieEnergyDTO()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000150")]
	[Utf8JsonSerializable]
	public class GenerateCircuitsRequestDTO : IRecNetUtf8JsonObject
	{
		[Cpp2IlInjected.Token(Token = "0x17000394")]
		public string Prompt
		{
			[Cpp2IlInjected.Token(Token = "0x60008D0")]
			[Cpp2IlInjected.Address(RVA = "0xABD130", Offset = "0xABBF30", VA = "0x180ABD130")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60008D1")]
			[Cpp2IlInjected.Address(RVA = "0xABD120", Offset = "0xABBF20", VA = "0x180ABD120")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000395")]
		public CircuitObjectDefinition? ObjectDefinition
		{
			[Cpp2IlInjected.Token(Token = "0x60008D2")]
			[Cpp2IlInjected.Address(RVA = "0xAC0D20", Offset = "0xABFB20", VA = "0x180AC0D20")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60008D3")]
			[Cpp2IlInjected.Address(RVA = "0xAC0D10", Offset = "0xABFB10", VA = "0x180AC0D10")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000396")]
		public IReadOnlyList<CircuitObjectDefinition>? SceneObjectDefinitions
		{
			[Cpp2IlInjected.Token(Token = "0x60008D4")]
			[Cpp2IlInjected.Address(RVA = "0xAC1D20", Offset = "0xAC0B20", VA = "0x180AC1D20")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60008D5")]
			[Cpp2IlInjected.Address(RVA = "0xAC0640", Offset = "0xABF440", VA = "0x180AC0640")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000397")]
		public IReadOnlyList<string>? SceneTags
		{
			[Cpp2IlInjected.Token(Token = "0x60008D6")]
			[Cpp2IlInjected.Address(RVA = "0xAC0F90", Offset = "0xABFD90", VA = "0x180AC0F90")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60008D7")]
			[Cpp2IlInjected.Address(RVA = "0xAC0650", Offset = "0xABF450", VA = "0x180AC0650")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000398")]
		public CircuitGenConfigDTO Config
		{
			[Cpp2IlInjected.Token(Token = "0x60008D8")]
			[Cpp2IlInjected.Address(RVA = "0xAC0F80", Offset = "0xABFD80", VA = "0x180AC0F80")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60008D9")]
			[Cpp2IlInjected.Address(RVA = "0xAC8C50", Offset = "0xAC7A50", VA = "0x180AC8C50")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000399")]
		public string? Instructions
		{
			[Cpp2IlInjected.Token(Token = "0x60008DA")]
			[Cpp2IlInjected.Address(RVA = "0xAC0FC0", Offset = "0xABFDC0", VA = "0x180AC0FC0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60008DB")]
			[Cpp2IlInjected.Address(RVA = "0xAC0CF0", Offset = "0xABFAF0", VA = "0x180AC0CF0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700039A")]
		public string? LibraryCode
		{
			[Cpp2IlInjected.Token(Token = "0x60008DC")]
			[Cpp2IlInjected.Address(RVA = "0xAC5120", Offset = "0xAC3F20", VA = "0x180AC5120")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60008DD")]
			[Cpp2IlInjected.Address(RVA = "0xAC0FB0", Offset = "0xABFDB0", VA = "0x180AC0FB0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700039B")]
		public string? Model
		{
			[Cpp2IlInjected.Token(Token = "0x60008DE")]
			[Cpp2IlInjected.Address(RVA = "0xAC0D30", Offset = "0xABFB30", VA = "0x180AC0D30")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60008DF")]
			[Cpp2IlInjected.Address(RVA = "0xAC1370", Offset = "0xAC0170", VA = "0x180AC1370")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60008E0")]
		[Cpp2IlInjected.Address(RVA = "0xABE8D0", Offset = "0xABD6D0", VA = "0x180ABE8D0", Slot = "4")]
		public void DNRPRHFLPRB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60008E1")]
		[Cpp2IlInjected.Address(RVA = "0xAC4840", Offset = "0xAC3640", VA = "0x180AC4840")]
		public GenerateCircuitsRequestDTO()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000151")]
	[Utf8JsonSerializable]
	public class GenerateCircuitsFromCodeRequestDTO : IRecNetUtf8JsonObject
	{
		[Cpp2IlInjected.Token(Token = "0x1700039C")]
		public string Code
		{
			[Cpp2IlInjected.Token(Token = "0x60008E2")]
			[Cpp2IlInjected.Address(RVA = "0xABD130", Offset = "0xABBF30", VA = "0x180ABD130")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60008E3")]
			[Cpp2IlInjected.Address(RVA = "0xABD120", Offset = "0xABBF20", VA = "0x180ABD120")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700039D")]
		public CircuitObjectDefinition? ObjectDefinition
		{
			[Cpp2IlInjected.Token(Token = "0x60008E4")]
			[Cpp2IlInjected.Address(RVA = "0xAC0D20", Offset = "0xABFB20", VA = "0x180AC0D20")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60008E5")]
			[Cpp2IlInjected.Address(RVA = "0xAC0D10", Offset = "0xABFB10", VA = "0x180AC0D10")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700039E")]
		public CircuitGenConfigDTO Config
		{
			[Cpp2IlInjected.Token(Token = "0x60008E6")]
			[Cpp2IlInjected.Address(RVA = "0xAC1D20", Offset = "0xAC0B20", VA = "0x180AC1D20")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60008E7")]
			[Cpp2IlInjected.Address(RVA = "0xAC0640", Offset = "0xABF440", VA = "0x180AC0640")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700039F")]
		public string? LibraryCode
		{
			[Cpp2IlInjected.Token(Token = "0x60008E8")]
			[Cpp2IlInjected.Address(RVA = "0xAC0F90", Offset = "0xABFD90", VA = "0x180AC0F90")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60008E9")]
			[Cpp2IlInjected.Address(RVA = "0xAC0650", Offset = "0xABF450", VA = "0x180AC0650")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170003A0")]
		public IReadOnlyList<string>? SceneTags
		{
			[Cpp2IlInjected.Token(Token = "0x60008EA")]
			[Cpp2IlInjected.Address(RVA = "0xAC0F80", Offset = "0xABFD80", VA = "0x180AC0F80")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60008EB")]
			[Cpp2IlInjected.Address(RVA = "0xAC8C50", Offset = "0xAC7A50", VA = "0x180AC8C50")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60008EC")]
		[Cpp2IlInjected.Address(RVA = "0xABE8D0", Offset = "0xABD6D0", VA = "0x180ABE8D0", Slot = "4")]
		public void DNRPRHFLPRB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60008ED")]
		[Cpp2IlInjected.Address(RVA = "0xAC4840", Offset = "0xAC3640", VA = "0x180AC4840")]
		public GenerateCircuitsFromCodeRequestDTO()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000152")]
	[Utf8JsonSerializable]
	public class CircuitGenConfigDTO : IRecNetUtf8JsonObject
	{
		[Cpp2IlInjected.Token(Token = "0x170003A1")]
		public string LibraryId
		{
			[Cpp2IlInjected.Token(Token = "0x60008EF")]
			[Cpp2IlInjected.Address(RVA = "0xABD130", Offset = "0xABBF30", VA = "0x180ABD130")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60008F0")]
			[Cpp2IlInjected.Address(RVA = "0xABD120", Offset = "0xABBF20", VA = "0x180ABD120")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170003A2")]
		public bool AllowBetaContent
		{
			[Cpp2IlInjected.Token(Token = "0x60008F1")]
			[Cpp2IlInjected.Address(RVA = "0xB40C50", Offset = "0xB3FA50", VA = "0x180B40C50")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x60008F2")]
			[Cpp2IlInjected.Address(RVA = "0xABD140", Offset = "0xABBF40", VA = "0x180ABD140")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170003A3")]
		public bool ComponentModificationEnabled
		{
			[Cpp2IlInjected.Token(Token = "0x60008F3")]
			[Cpp2IlInjected.Address(RVA = "0x123BE30", Offset = "0x123AC30", VA = "0x18123BE30")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x60008F4")]
			[Cpp2IlInjected.Address(RVA = "0x139A690", Offset = "0x1399490", VA = "0x18139A690")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170003A4")]
		public bool UseOnObjectSpawnedOrReset
		{
			[Cpp2IlInjected.Token(Token = "0x60008F5")]
			[Cpp2IlInjected.Address(RVA = "0x123BE20", Offset = "0x123AC20", VA = "0x18123BE20")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x60008F6")]
			[Cpp2IlInjected.Address(RVA = "0x16FB500", Offset = "0x16FA300", VA = "0x1816FB500")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170003A5")]
		public bool ExposeTunables
		{
			[Cpp2IlInjected.Token(Token = "0x60008F7")]
			[Cpp2IlInjected.Address(RVA = "0x123BE10", Offset = "0x123AC10", VA = "0x18123BE10")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x60008F8")]
			[Cpp2IlInjected.Address(RVA = "0x56899C0", Offset = "0x56887C0", VA = "0x1856899C0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170003A6")]
		public bool ExposePublicMethods
		{
			[Cpp2IlInjected.Token(Token = "0x60008F9")]
			[Cpp2IlInjected.Address(RVA = "0xB856B0", Offset = "0xB844B0", VA = "0x180B856B0")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x60008FA")]
			[Cpp2IlInjected.Address(RVA = "0xEBEC40", Offset = "0xEBDA40", VA = "0x180EBEC40")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170003A7")]
		public bool ObjectEventsEnabled
		{
			[Cpp2IlInjected.Token(Token = "0x60008FB")]
			[Cpp2IlInjected.Address(RVA = "0xB85700", Offset = "0xB84500", VA = "0x180B85700")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x60008FC")]
			[Cpp2IlInjected.Address(RVA = "0xEBEF90", Offset = "0xEBDD90", VA = "0x180EBEF90")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170003A8")]
		public bool SpawnablesEnabled
		{
			[Cpp2IlInjected.Token(Token = "0x60008FD")]
			[Cpp2IlInjected.Address(RVA = "0x1B501C0", Offset = "0x1B4EFC0", VA = "0x181B501C0")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x60008FE")]
			[Cpp2IlInjected.Address(RVA = "0x7A5A360", Offset = "0x7A59160", VA = "0x187A5A360")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170003A9")]
		public bool TagEnumEnabled
		{
			[Cpp2IlInjected.Token(Token = "0x60008FF")]
			[Cpp2IlInjected.Address(RVA = "0x1B4A7C0", Offset = "0x1B495C0", VA = "0x181B4A7C0")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000900")]
			[Cpp2IlInjected.Address(RVA = "0x7A5A370", Offset = "0x7A59170", VA = "0x187A5A370")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170003AA")]
		public bool IsRecRoomObjectOfTypeEnabled
		{
			[Cpp2IlInjected.Token(Token = "0x6000901")]
			[Cpp2IlInjected.Address(RVA = "0xAC1360", Offset = "0xAC0160", VA = "0x180AC1360")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000902")]
			[Cpp2IlInjected.Address(RVA = "0xAC0FD0", Offset = "0xABFDD0", VA = "0x180AC0FD0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170003AB")]
		public bool VirtualMethodsEnabled
		{
			[Cpp2IlInjected.Token(Token = "0x6000903")]
			[Cpp2IlInjected.Address(RVA = "0x15CB330", Offset = "0x15CA130", VA = "0x1815CB330")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000904")]
			[Cpp2IlInjected.Address(RVA = "0x15CA4E0", Offset = "0x15C92E0", VA = "0x1815CA4E0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170003AC")]
		public bool ComponentModificationEnabledForSceneObjects
		{
			[Cpp2IlInjected.Token(Token = "0x6000905")]
			[Cpp2IlInjected.Address(RVA = "0x1B351F0", Offset = "0x1B33FF0", VA = "0x181B351F0")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000906")]
			[Cpp2IlInjected.Address(RVA = "0x1D9AD50", Offset = "0x1D99B50", VA = "0x181D9AD50")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60008EE")]
		[Cpp2IlInjected.Address(RVA = "0x7A5A2B0", Offset = "0x7A590B0", VA = "0x187A5A2B0")]
		public CircuitGenConfigDTO(string libraryId, bool allowBetaContent, bool componentModificationEnabled, bool useOnObjectSpawnedOrReset, bool exposeTunables, bool exposePublicMethods, bool objectEventsEnabled, bool spawnablesEnabled, bool tagEnumEnabled, bool isRecRoomObjectOfTypeEnabled, bool virtualMethodsEnabled, bool componentModificationEnabledForSceneObjects)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000907")]
		[Cpp2IlInjected.Address(RVA = "0xABE8D0", Offset = "0xABD6D0", VA = "0x180ABE8D0", Slot = "4")]
		public void DNRPRHFLPRB()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000153")]
	[Utf8JsonSerializable]
	public class CreateRealtimeSessionRequestDTO : IRecNetUtf8JsonObject
	{
		[Cpp2IlInjected.Token(Token = "0x170003AD")]
		public string AIType
		{
			[Cpp2IlInjected.Token(Token = "0x6000908")]
			[Cpp2IlInjected.Address(RVA = "0xABD130", Offset = "0xABBF30", VA = "0x180ABD130")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000909")]
			[Cpp2IlInjected.Address(RVA = "0xABD120", Offset = "0xABBF20", VA = "0x180ABD120")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170003AE")]
		public string Model
		{
			[Cpp2IlInjected.Token(Token = "0x600090A")]
			[Cpp2IlInjected.Address(RVA = "0xAC0D20", Offset = "0xABFB20", VA = "0x180AC0D20")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600090B")]
			[Cpp2IlInjected.Address(RVA = "0xAC0D10", Offset = "0xABFB10", VA = "0x180AC0D10")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170003AF")]
		public string Instructions
		{
			[Cpp2IlInjected.Token(Token = "0x600090C")]
			[Cpp2IlInjected.Address(RVA = "0xAC1D20", Offset = "0xAC0B20", VA = "0x180AC1D20")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600090D")]
			[Cpp2IlInjected.Address(RVA = "0xAC0640", Offset = "0xABF440", VA = "0x180AC0640")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170003B0")]
		public string? Voice
		{
			[Cpp2IlInjected.Token(Token = "0x600090E")]
			[Cpp2IlInjected.Address(RVA = "0xAC0F90", Offset = "0xABFD90", VA = "0x180AC0F90")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600090F")]
			[Cpp2IlInjected.Address(RVA = "0xAC0650", Offset = "0xABF450", VA = "0x180AC0650")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170003B1")]
		public string? TranscriptionModel
		{
			[Cpp2IlInjected.Token(Token = "0x6000910")]
			[Cpp2IlInjected.Address(RVA = "0xAC0F80", Offset = "0xABFD80", VA = "0x180AC0F80")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000911")]
			[Cpp2IlInjected.Address(RVA = "0xAC8C50", Offset = "0xAC7A50", VA = "0x180AC8C50")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170003B2")]
		public float Temperature
		{
			[Cpp2IlInjected.Token(Token = "0x6000912")]
			[Cpp2IlInjected.Address(RVA = "0xD79AB0", Offset = "0xD788B0", VA = "0x180D79AB0")]
			[CompilerGenerated]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x6000913")]
			[Cpp2IlInjected.Address(RVA = "0x147BB40", Offset = "0x147A940", VA = "0x18147BB40")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000914")]
		[Cpp2IlInjected.Address(RVA = "0xABE8D0", Offset = "0xABD6D0", VA = "0x180ABE8D0", Slot = "4")]
		public void DNRPRHFLPRB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000915")]
		[Cpp2IlInjected.Address(RVA = "0xAC4840", Offset = "0xAC3640", VA = "0x180AC4840")]
		public CreateRealtimeSessionRequestDTO()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000154")]
	[Utf8JsonSerializable]
	public class CreateRealtimeSessionResponseDTO : DKEQGCPNGFY, IRecNetUtf8JsonObject
	{
		[Cpp2IlInjected.Token(Token = "0x170003B3")]
		public string SessionId
		{
			[Cpp2IlInjected.Token(Token = "0x6000916")]
			[Cpp2IlInjected.Address(RVA = "0xABD130", Offset = "0xABBF30", VA = "0x180ABD130", Slot = "4")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000917")]
			[Cpp2IlInjected.Address(RVA = "0xABD120", Offset = "0xABBF20", VA = "0x180ABD120")]
			[CompilerGenerated]
			internal set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170003B4")]
		public string ClientSecret
		{
			[Cpp2IlInjected.Token(Token = "0x6000918")]
			[Cpp2IlInjected.Address(RVA = "0xAC0D20", Offset = "0xABFB20", VA = "0x180AC0D20", Slot = "5")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000919")]
			[Cpp2IlInjected.Address(RVA = "0xAC0D10", Offset = "0xABFB10", VA = "0x180AC0D10")]
			[CompilerGenerated]
			internal set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600091A")]
		[Cpp2IlInjected.Address(RVA = "0xABE8D0", Offset = "0xABD6D0", VA = "0x180ABE8D0", Slot = "6")]
		public void DNRPRHFLPRB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600091B")]
		[Cpp2IlInjected.Address(RVA = "0xAC4840", Offset = "0xAC3640", VA = "0x180AC4840")]
		public CreateRealtimeSessionResponseDTO()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000155")]
	[Utf8JsonSerializable]
	public class UpdateUserSessionSpendRequestDTO : IRecNetUtf8JsonObject
	{
		[Cpp2IlInjected.Token(Token = "0x170003B5")]
		public Guid SpendSessionId
		{
			[Cpp2IlInjected.Token(Token = "0x600091C")]
			[Cpp2IlInjected.Address(RVA = "0xEC6860", Offset = "0xEC5660", VA = "0x180EC6860")]
			[CompilerGenerated]
			get
			{
				return default(Guid);
			}
			[Cpp2IlInjected.Token(Token = "0x600091D")]
			[Cpp2IlInjected.Address(RVA = "0xEC6880", Offset = "0xEC5680", VA = "0x180EC6880")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170003B6")]
		public long RoomId
		{
			[Cpp2IlInjected.Token(Token = "0x600091E")]
			[Cpp2IlInjected.Address(RVA = "0xAC1D20", Offset = "0xAC0B20", VA = "0x180AC1D20")]
			[CompilerGenerated]
			get
			{
				return default(long);
			}
			[Cpp2IlInjected.Token(Token = "0x600091F")]
			[Cpp2IlInjected.Address(RVA = "0xE33D40", Offset = "0xE32B40", VA = "0x180E33D40")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170003B7")]
		public long RoomInstanceId
		{
			[Cpp2IlInjected.Token(Token = "0x6000920")]
			[Cpp2IlInjected.Address(RVA = "0xAC0F90", Offset = "0xABFD90", VA = "0x180AC0F90")]
			[CompilerGenerated]
			get
			{
				return default(long);
			}
			[Cpp2IlInjected.Token(Token = "0x6000921")]
			[Cpp2IlInjected.Address(RVA = "0xAC0D00", Offset = "0xABFB00", VA = "0x180AC0D00")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170003B8")]
		public decimal Spend
		{
			[Cpp2IlInjected.Token(Token = "0x6000922")]
			[Cpp2IlInjected.Address(RVA = "0xF782C0", Offset = "0xF770C0", VA = "0x180F782C0")]
			[CompilerGenerated]
			get
			{
				return default(decimal);
			}
			[Cpp2IlInjected.Token(Token = "0x6000923")]
			[Cpp2IlInjected.Address(RVA = "0xF782D0", Offset = "0xF770D0", VA = "0x180F782D0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000924")]
		[Cpp2IlInjected.Address(RVA = "0xABE8D0", Offset = "0xABD6D0", VA = "0x180ABE8D0", Slot = "4")]
		public void DNRPRHFLPRB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000925")]
		[Cpp2IlInjected.Address(RVA = "0xAC4840", Offset = "0xAC3640", VA = "0x180AC4840")]
		public UpdateUserSessionSpendRequestDTO()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000156")]
	[Utf8JsonSerializable]
	public class UpdateRoomieSessionSpendRequestDTO : UpdateUserSessionSpendRequestDTO
	{
		[Cpp2IlInjected.Token(Token = "0x170003B9")]
		public byte RoomieEnergyMode
		{
			[Cpp2IlInjected.Token(Token = "0x6000926")]
			[Cpp2IlInjected.Address(RVA = "0xF7B8E0", Offset = "0xF7A6E0", VA = "0x180F7B8E0")]
			[CompilerGenerated]
			get
			{
				return default(byte);
			}
			[Cpp2IlInjected.Token(Token = "0x6000927")]
			[Cpp2IlInjected.Address(RVA = "0xF7B4A0", Offset = "0xF7A2A0", VA = "0x180F7B4A0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000928")]
		[Cpp2IlInjected.Address(RVA = "0xAC4840", Offset = "0xAC3640", VA = "0x180AC4840")]
		public UpdateRoomieSessionSpendRequestDTO()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000157")]
	[Utf8JsonSerializable]
	public class UploadRealtimeSessionLogsDTO : IRecNetUtf8JsonObject
	{
		[Cpp2IlInjected.Token(Token = "0x170003BA")]
		public string SessionId
		{
			[Cpp2IlInjected.Token(Token = "0x6000929")]
			[Cpp2IlInjected.Address(RVA = "0xABD130", Offset = "0xABBF30", VA = "0x180ABD130")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600092A")]
			[Cpp2IlInjected.Address(RVA = "0xABD120", Offset = "0xABBF20", VA = "0x180ABD120")]
			[CompilerGenerated]
			internal set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170003BB")]
		public string Logs
		{
			[Cpp2IlInjected.Token(Token = "0x600092B")]
			[Cpp2IlInjected.Address(RVA = "0xAC0D20", Offset = "0xABFB20", VA = "0x180AC0D20")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600092C")]
			[Cpp2IlInjected.Address(RVA = "0xAC0D10", Offset = "0xABFB10", VA = "0x180AC0D10")]
			[CompilerGenerated]
			internal set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600092D")]
		[Cpp2IlInjected.Address(RVA = "0xAC4840", Offset = "0xAC3640", VA = "0x180AC4840")]
		public UploadRealtimeSessionLogsDTO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600092E")]
		[Cpp2IlInjected.Address(RVA = "0xABFA30", Offset = "0xABE830", VA = "0x180ABFA30")]
		public UploadRealtimeSessionLogsDTO(string sessionId, string logs)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600092F")]
		[Cpp2IlInjected.Address(RVA = "0xABE8D0", Offset = "0xABD6D0", VA = "0x180ABE8D0", Slot = "4")]
		public void DNRPRHFLPRB()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000158")]
	[Utf8JsonSerializable]
	public class GenerateImageRequestDTO : IRecNetUtf8JsonObject
	{
		[Cpp2IlInjected.Token(Token = "0x170003BC")]
		public string Model
		{
			[Cpp2IlInjected.Token(Token = "0x6000930")]
			[Cpp2IlInjected.Address(RVA = "0xABD130", Offset = "0xABBF30", VA = "0x180ABD130")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000931")]
			[Cpp2IlInjected.Address(RVA = "0xABD120", Offset = "0xABBF20", VA = "0x180ABD120")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170003BD")]
		public string Prompt
		{
			[Cpp2IlInjected.Token(Token = "0x6000932")]
			[Cpp2IlInjected.Address(RVA = "0xAC0D20", Offset = "0xABFB20", VA = "0x180AC0D20")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000933")]
			[Cpp2IlInjected.Address(RVA = "0xAC0D10", Offset = "0xABFB10", VA = "0x180AC0D10")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170003BE")]
		public bool Tileable
		{
			[Cpp2IlInjected.Token(Token = "0x6000934")]
			[Cpp2IlInjected.Address(RVA = "0xAC1360", Offset = "0xAC0160", VA = "0x180AC1360")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000935")]
			[Cpp2IlInjected.Address(RVA = "0xAC0FD0", Offset = "0xABFDD0", VA = "0x180AC0FD0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000936")]
		[Cpp2IlInjected.Address(RVA = "0xABE8D0", Offset = "0xABD6D0", VA = "0x180ABE8D0", Slot = "4")]
		public void DNRPRHFLPRB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000937")]
		[Cpp2IlInjected.Address(RVA = "0xAC4840", Offset = "0xAC3640", VA = "0x180AC4840")]
		public GenerateImageRequestDTO()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000159")]
	[Utf8JsonSerializable]
	public class GenerateImageResponseDTO : IRecNetUtf8JsonObject
	{
		[Cpp2IlInjected.Token(Token = "0x170003BF")]
		public string Filename
		{
			[Cpp2IlInjected.Token(Token = "0x6000938")]
			[Cpp2IlInjected.Address(RVA = "0xABD130", Offset = "0xABBF30", VA = "0x180ABD130")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000939")]
			[Cpp2IlInjected.Address(RVA = "0xABD120", Offset = "0xABBF20", VA = "0x180ABD120")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170003C0")]
		public decimal ImageGenerationCost
		{
			[Cpp2IlInjected.Token(Token = "0x600093A")]
			[Cpp2IlInjected.Address(RVA = "0xBED410", Offset = "0xBEC210", VA = "0x180BED410")]
			[CompilerGenerated]
			get
			{
				return default(decimal);
			}
			[Cpp2IlInjected.Token(Token = "0x600093B")]
			[Cpp2IlInjected.Address(RVA = "0xF76460", Offset = "0xF75260", VA = "0x180F76460")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600093C")]
		[Cpp2IlInjected.Address(RVA = "0xABE8D0", Offset = "0xABD6D0", VA = "0x180ABE8D0", Slot = "4")]
		public void DNRPRHFLPRB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600093D")]
		[Cpp2IlInjected.Address(RVA = "0xAC4840", Offset = "0xAC3640", VA = "0x180AC4840")]
		public GenerateImageResponseDTO()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200015A")]
	[Utf8JsonSerializable]
	public class DescribeImageRequestDTO : IRecNetUtf8JsonObject
	{
		[Cpp2IlInjected.Token(Token = "0x170003C1")]
		public string? Model
		{
			[Cpp2IlInjected.Token(Token = "0x600093E")]
			[Cpp2IlInjected.Address(RVA = "0xABD130", Offset = "0xABBF30", VA = "0x180ABD130")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600093F")]
			[Cpp2IlInjected.Address(RVA = "0xABD120", Offset = "0xABBF20", VA = "0x180ABD120")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170003C2")]
		public string Prompt
		{
			[Cpp2IlInjected.Token(Token = "0x6000940")]
			[Cpp2IlInjected.Address(RVA = "0xAC0D20", Offset = "0xABFB20", VA = "0x180AC0D20")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000941")]
			[Cpp2IlInjected.Address(RVA = "0xAC0D10", Offset = "0xABFB10", VA = "0x180AC0D10")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170003C3")]
		public float? Temperature
		{
			[Cpp2IlInjected.Token(Token = "0x6000942")]
			[Cpp2IlInjected.Address(RVA = "0xAC1D20", Offset = "0xAC0B20", VA = "0x180AC1D20")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000943")]
			[Cpp2IlInjected.Address(RVA = "0xE33D40", Offset = "0xE32B40", VA = "0x180E33D40")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170003C4")]
		public string? ImageName
		{
			[Cpp2IlInjected.Token(Token = "0x6000944")]
			[Cpp2IlInjected.Address(RVA = "0xAC0F90", Offset = "0xABFD90", VA = "0x180AC0F90")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000945")]
			[Cpp2IlInjected.Address(RVA = "0xAC0650", Offset = "0xABF450", VA = "0x180AC0650")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000946")]
		[Cpp2IlInjected.Address(RVA = "0xABE8D0", Offset = "0xABD6D0", VA = "0x180ABE8D0", Slot = "4")]
		public void DNRPRHFLPRB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000947")]
		[Cpp2IlInjected.Address(RVA = "0xAC4840", Offset = "0xAC3640", VA = "0x180AC4840")]
		public DescribeImageRequestDTO()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200015B")]
	[Utf8JsonSerializable]
	public class DescribeImageResponseDTO : ChatResponseDTO
	{
		[Cpp2IlInjected.Token(Token = "0x6000948")]
		[Cpp2IlInjected.Address(RVA = "0xAC4840", Offset = "0xAC3640", VA = "0x180AC4840")]
		public DescribeImageResponseDTO()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200015C")]
	[Utf8JsonSerializable]
	public class DescribeImageFileRequestDTO : ChatRequestDTO
	{
		[Cpp2IlInjected.Token(Token = "0x6000949")]
		[Cpp2IlInjected.Address(RVA = "0xAC4840", Offset = "0xAC3640", VA = "0x180AC4840")]
		public DescribeImageFileRequestDTO()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200015D")]
	[Utf8JsonSerializable]
	public class GenerateMeshRequestDTO : IRecNetUtf8JsonObject
	{
		[Cpp2IlInjected.Token(Token = "0x170003C5")]
		public string FriendlyName
		{
			[Cpp2IlInjected.Token(Token = "0x600094A")]
			[Cpp2IlInjected.Address(RVA = "0xABD130", Offset = "0xABBF30", VA = "0x180ABD130")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600094B")]
			[Cpp2IlInjected.Address(RVA = "0xABD120", Offset = "0xABBF20", VA = "0x180ABD120")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170003C6")]
		public string Prompt
		{
			[Cpp2IlInjected.Token(Token = "0x600094C")]
			[Cpp2IlInjected.Address(RVA = "0xAC0D20", Offset = "0xABFB20", VA = "0x180AC0D20")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600094D")]
			[Cpp2IlInjected.Address(RVA = "0xAC0D10", Offset = "0xABFB10", VA = "0x180AC0D10")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170003C7")]
		public bool AllowRoomInstanceAccess
		{
			[Cpp2IlInjected.Token(Token = "0x600094E")]
			[Cpp2IlInjected.Address(RVA = "0xAC1360", Offset = "0xAC0160", VA = "0x180AC1360")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x600094F")]
			[Cpp2IlInjected.Address(RVA = "0xAC0FD0", Offset = "0xABFDD0", VA = "0x180AC0FD0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000950")]
		[Cpp2IlInjected.Address(RVA = "0xABE8D0", Offset = "0xABD6D0", VA = "0x180ABE8D0", Slot = "4")]
		public void DNRPRHFLPRB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000951")]
		[Cpp2IlInjected.Address(RVA = "0xAC4840", Offset = "0xAC3640", VA = "0x180AC4840")]
		public GenerateMeshRequestDTO()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200015E")]
	[Utf8JsonSerializable]
	public class GenerateMeshFromImageRequestDTO : GenerateMeshRequestDTO
	{
		[Cpp2IlInjected.Token(Token = "0x170003C8")]
		public string ImageName
		{
			[Cpp2IlInjected.Token(Token = "0x6000952")]
			[Cpp2IlInjected.Address(RVA = "0xAC0F90", Offset = "0xABFD90", VA = "0x180AC0F90")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000953")]
			[Cpp2IlInjected.Address(RVA = "0xAC0650", Offset = "0xABF450", VA = "0x180AC0650")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000954")]
		[Cpp2IlInjected.Address(RVA = "0xAC4840", Offset = "0xAC3640", VA = "0x180AC4840")]
		public GenerateMeshFromImageRequestDTO()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200015F")]
	[Utf8JsonSerializable]
	public class GenerateMeshResponseDTO : IRecNetUtf8JsonObject
	{
		[Cpp2IlInjected.Token(Token = "0x170003C9")]
		public long GenerateMeshRequestId
		{
			[Cpp2IlInjected.Token(Token = "0x6000955")]
			[Cpp2IlInjected.Address(RVA = "0xABD130", Offset = "0xABBF30", VA = "0x180ABD130")]
			[CompilerGenerated]
			get
			{
				return default(long);
			}
			[Cpp2IlInjected.Token(Token = "0x6000956")]
			[Cpp2IlInjected.Address(RVA = "0xEABA00", Offset = "0xEAA800", VA = "0x180EABA00")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170003CA")]
		public string FriendlyName
		{
			[Cpp2IlInjected.Token(Token = "0x6000957")]
			[Cpp2IlInjected.Address(RVA = "0xAC0D20", Offset = "0xABFB20", VA = "0x180AC0D20")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000958")]
			[Cpp2IlInjected.Address(RVA = "0xAC0D10", Offset = "0xABFB10", VA = "0x180AC0D10")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170003CB")]
		public GenerateMeshRequestStates GenerateMeshRequestState
		{
			[Cpp2IlInjected.Token(Token = "0x6000959")]
			[Cpp2IlInjected.Address(RVA = "0xACF4D0", Offset = "0xACE2D0", VA = "0x180ACF4D0")]
			[CompilerGenerated]
			get
			{
				return default(GenerateMeshRequestStates);
			}
			[Cpp2IlInjected.Token(Token = "0x600095A")]
			[Cpp2IlInjected.Address(RVA = "0xB20FD0", Offset = "0xB1FDD0", VA = "0x180B20FD0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170003CC")]
		public Guid? UnityAssetId
		{
			[Cpp2IlInjected.Token(Token = "0x600095B")]
			[Cpp2IlInjected.Address(RVA = "0x7A5BCA0", Offset = "0x7A5AAA0", VA = "0x187A5BCA0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600095C")]
			[Cpp2IlInjected.Address(RVA = "0x7A5BCC0", Offset = "0x7A5AAC0", VA = "0x187A5BCC0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170003CD")]
		public string? MeshFileName
		{
			[Cpp2IlInjected.Token(Token = "0x600095D")]
			[Cpp2IlInjected.Address(RVA = "0xAC0FC0", Offset = "0xABFDC0", VA = "0x180AC0FC0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600095E")]
			[Cpp2IlInjected.Address(RVA = "0xAC0CF0", Offset = "0xABFAF0", VA = "0x180AC0CF0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600095F")]
		[Cpp2IlInjected.Address(RVA = "0xABE8D0", Offset = "0xABD6D0", VA = "0x180ABE8D0", Slot = "4")]
		public void DNRPRHFLPRB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000960")]
		[Cpp2IlInjected.Address(RVA = "0xAC4840", Offset = "0xAC3640", VA = "0x180AC4840")]
		public GenerateMeshResponseDTO()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000160")]
	public enum GenerateMeshRequestStates
	{
		[Cpp2IlInjected.Token(Token = "0x4000638")]
		Requested = 0,
		[Cpp2IlInjected.Token(Token = "0x4000639")]
		ProviderMeshRequested = 1,
		[Cpp2IlInjected.Token(Token = "0x400063A")]
		ProviderMeshGenerated = 2,
		[Cpp2IlInjected.Token(Token = "0x400063B")]
		ProviderMeshGenFailed = 3,
		[Cpp2IlInjected.Token(Token = "0x400063C")]
		CloudBuildRequested = 11,
		[Cpp2IlInjected.Token(Token = "0x400063D")]
		CloudBuildCompleted = 12,
		[Cpp2IlInjected.Token(Token = "0x400063E")]
		CloudBuildFailed = 13,
		[Cpp2IlInjected.Token(Token = "0x400063F")]
		MeshGenCompleted = 21,
		[Cpp2IlInjected.Token(Token = "0x4000640")]
		ImageReferenceRequested = 31,
		[Cpp2IlInjected.Token(Token = "0x4000641")]
		ImageReferenceGenerated = 32,
		[Cpp2IlInjected.Token(Token = "0x4000642")]
		ImageReferenceGenerationFailed = 33
	}
	[Cpp2IlInjected.Token(Token = "0x2000161")]
	[Utf8JsonSerializable]
	public class EditImageRequestDTO : IRecNetUtf8JsonObject
	{
		[Cpp2IlInjected.Token(Token = "0x170003CE")]
		public string? Model
		{
			[Cpp2IlInjected.Token(Token = "0x6000961")]
			[Cpp2IlInjected.Address(RVA = "0xABD130", Offset = "0xABBF30", VA = "0x180ABD130")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000962")]
			[Cpp2IlInjected.Address(RVA = "0xABD120", Offset = "0xABBF20", VA = "0x180ABD120")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170003CF")]
		public string Prompt
		{
			[Cpp2IlInjected.Token(Token = "0x6000963")]
			[Cpp2IlInjected.Address(RVA = "0xAC0D20", Offset = "0xABFB20", VA = "0x180AC0D20")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000964")]
			[Cpp2IlInjected.Address(RVA = "0xAC0D10", Offset = "0xABFB10", VA = "0x180AC0D10")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000965")]
		[Cpp2IlInjected.Address(RVA = "0xABE8D0", Offset = "0xABD6D0", VA = "0x180ABE8D0", Slot = "4")]
		public void DNRPRHFLPRB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000966")]
		[Cpp2IlInjected.Address(RVA = "0x7A5ABE0", Offset = "0x7A599E0", VA = "0x187A5ABE0")]
		public EditImageRequestDTO()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000162")]
	[Utf8JsonSerializable]
	public class ChatRequestDTO : IRecNetUtf8JsonObject
	{
		[Cpp2IlInjected.Token(Token = "0x170003D0")]
		public string Model
		{
			[Cpp2IlInjected.Token(Token = "0x6000967")]
			[Cpp2IlInjected.Address(RVA = "0xABD130", Offset = "0xABBF30", VA = "0x180ABD130")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000968")]
			[Cpp2IlInjected.Address(RVA = "0xABD120", Offset = "0xABBF20", VA = "0x180ABD120")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170003D1")]
		public string Prompt
		{
			[Cpp2IlInjected.Token(Token = "0x6000969")]
			[Cpp2IlInjected.Address(RVA = "0xAC0D20", Offset = "0xABFB20", VA = "0x180AC0D20")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600096A")]
			[Cpp2IlInjected.Address(RVA = "0xAC0D10", Offset = "0xABFB10", VA = "0x180AC0D10")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600096B")]
		[Cpp2IlInjected.Address(RVA = "0xABE8D0", Offset = "0xABD6D0", VA = "0x180ABE8D0", Slot = "4")]
		public void DNRPRHFLPRB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600096C")]
		[Cpp2IlInjected.Address(RVA = "0xAC4840", Offset = "0xAC3640", VA = "0x180AC4840")]
		public ChatRequestDTO()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000163")]
	[Utf8JsonSerializable]
	public class ChatResponseDTO : IRecNetUtf8JsonObject
	{
		[Cpp2IlInjected.Token(Token = "0x170003D2")]
		public List<string> AIResponse
		{
			[Cpp2IlInjected.Token(Token = "0x600096D")]
			[Cpp2IlInjected.Address(RVA = "0xABD130", Offset = "0xABBF30", VA = "0x180ABD130")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600096E")]
			[Cpp2IlInjected.Address(RVA = "0xABD120", Offset = "0xABBF20", VA = "0x180ABD120")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170003D3")]
		public decimal Cost
		{
			[Cpp2IlInjected.Token(Token = "0x600096F")]
			[Cpp2IlInjected.Address(RVA = "0xBED410", Offset = "0xBEC210", VA = "0x180BED410")]
			[CompilerGenerated]
			get
			{
				return default(decimal);
			}
			[Cpp2IlInjected.Token(Token = "0x6000970")]
			[Cpp2IlInjected.Address(RVA = "0xF76460", Offset = "0xF75260", VA = "0x180F76460")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000971")]
		[Cpp2IlInjected.Address(RVA = "0xABE8D0", Offset = "0xABD6D0", VA = "0x180ABE8D0", Slot = "4")]
		public void DNRPRHFLPRB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000972")]
		[Cpp2IlInjected.Address(RVA = "0xAC4840", Offset = "0xAC3640", VA = "0x180AC4840")]
		public ChatResponseDTO()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000164")]
	[Utf8JsonSerializable]
	public class ChipPort : IRecNetUtf8JsonObject
	{
		[Cpp2IlInjected.Token(Token = "0x170003D4")]
		public int Id
		{
			[Cpp2IlInjected.Token(Token = "0x6000973")]
			[Cpp2IlInjected.Address(RVA = "0xABD110", Offset = "0xABBF10", VA = "0x180ABD110")]
			[CompilerGenerated]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x6000974")]
			[Cpp2IlInjected.Address(RVA = "0xAC1D40", Offset = "0xAC0B40", VA = "0x180AC1D40")]
			[CompilerGenerated]
			internal set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170003D5")]
		public string Type
		{
			[Cpp2IlInjected.Token(Token = "0x6000975")]
			[Cpp2IlInjected.Address(RVA = "0xAC0D20", Offset = "0xABFB20", VA = "0x180AC0D20")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000976")]
			[Cpp2IlInjected.Address(RVA = "0xAC0D10", Offset = "0xABFB10", VA = "0x180AC0D10")]
			[CompilerGenerated]
			internal set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170003D6")]
		public string? Name
		{
			[Cpp2IlInjected.Token(Token = "0x6000977")]
			[Cpp2IlInjected.Address(RVA = "0xAC1D20", Offset = "0xAC0B20", VA = "0x180AC1D20")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000978")]
			[Cpp2IlInjected.Address(RVA = "0xAC0640", Offset = "0xABF440", VA = "0x180AC0640")]
			[CompilerGenerated]
			internal set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170003D7")]
		public IReadOnlyList<int> Connections
		{
			[Cpp2IlInjected.Token(Token = "0x6000979")]
			[Cpp2IlInjected.Address(RVA = "0xAC0F90", Offset = "0xABFD90", VA = "0x180AC0F90")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600097A")]
			[Cpp2IlInjected.Address(RVA = "0xAC0650", Offset = "0xABF450", VA = "0x180AC0650")]
			[CompilerGenerated]
			internal set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170003D8")]
		public string? DefaultValue
		{
			[Cpp2IlInjected.Token(Token = "0x600097B")]
			[Cpp2IlInjected.Address(RVA = "0xAC0F80", Offset = "0xABFD80", VA = "0x180AC0F80")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600097C")]
			[Cpp2IlInjected.Address(RVA = "0xAC8C50", Offset = "0xAC7A50", VA = "0x180AC8C50")]
			[CompilerGenerated]
			internal set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600097D")]
		[Cpp2IlInjected.Address(RVA = "0xABE8D0", Offset = "0xABD6D0", VA = "0x180ABE8D0", Slot = "4")]
		public void DNRPRHFLPRB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600097E")]
		[Cpp2IlInjected.Address(RVA = "0x7A5A010", Offset = "0x7A58E10", VA = "0x187A5A010")]
		public ChipPort()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000165")]
	[Utf8JsonSerializable]
	public class Chip : IRecNetUtf8JsonObject
	{
		[Cpp2IlInjected.Token(Token = "0x170003D9")]
		public int Id
		{
			[Cpp2IlInjected.Token(Token = "0x600097F")]
			[Cpp2IlInjected.Address(RVA = "0xABD110", Offset = "0xABBF10", VA = "0x180ABD110")]
			[CompilerGenerated]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x6000980")]
			[Cpp2IlInjected.Address(RVA = "0xAC1D40", Offset = "0xAC0B40", VA = "0x180AC1D40")]
			[CompilerGenerated]
			internal set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170003DA")]
		public Guid? Guid
		{
			[Cpp2IlInjected.Token(Token = "0x6000981")]
			[Cpp2IlInjected.Address(RVA = "0x24F3F40", Offset = "0x24F2D40", VA = "0x1824F3F40")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000982")]
			[Cpp2IlInjected.Address(RVA = "0x24F3F80", Offset = "0x24F2D80", VA = "0x1824F3F80")]
			[CompilerGenerated]
			internal set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170003DB")]
		public string Type
		{
			[Cpp2IlInjected.Token(Token = "0x6000983")]
			[Cpp2IlInjected.Address(RVA = "0xAC0F90", Offset = "0xABFD90", VA = "0x180AC0F90")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000984")]
			[Cpp2IlInjected.Address(RVA = "0xAC0650", Offset = "0xABF450", VA = "0x180AC0650")]
			[CompilerGenerated]
			internal set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170003DC")]
		public List<ChipPort> Input
		{
			[Cpp2IlInjected.Token(Token = "0x6000985")]
			[Cpp2IlInjected.Address(RVA = "0xAC0F80", Offset = "0xABFD80", VA = "0x180AC0F80")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000986")]
			[Cpp2IlInjected.Address(RVA = "0xAC8C50", Offset = "0xAC7A50", VA = "0x180AC8C50")]
			[CompilerGenerated]
			internal set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170003DD")]
		public List<ChipPort> Output
		{
			[Cpp2IlInjected.Token(Token = "0x6000987")]
			[Cpp2IlInjected.Address(RVA = "0xAC0FC0", Offset = "0xABFDC0", VA = "0x180AC0FC0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000988")]
			[Cpp2IlInjected.Address(RVA = "0xAC0CF0", Offset = "0xABFAF0", VA = "0x180AC0CF0")]
			[CompilerGenerated]
			internal set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170003DE")]
		public string? Name
		{
			[Cpp2IlInjected.Token(Token = "0x6000989")]
			[Cpp2IlInjected.Address(RVA = "0xAC5120", Offset = "0xAC3F20", VA = "0x180AC5120")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600098A")]
			[Cpp2IlInjected.Address(RVA = "0xAC0FB0", Offset = "0xABFDB0", VA = "0x180AC0FB0")]
			[CompilerGenerated]
			internal set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170003DF")]
		public string? DefaultValue
		{
			[Cpp2IlInjected.Token(Token = "0x600098B")]
			[Cpp2IlInjected.Address(RVA = "0xAC0D30", Offset = "0xABFB30", VA = "0x180AC0D30")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600098C")]
			[Cpp2IlInjected.Address(RVA = "0xAC1370", Offset = "0xAC0170", VA = "0x180AC1370")]
			[CompilerGenerated]
			internal set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170003E0")]
		public string? Comment
		{
			[Cpp2IlInjected.Token(Token = "0x600098D")]
			[Cpp2IlInjected.Address(RVA = "0xAC31E0", Offset = "0xAC1FE0", VA = "0x180AC31E0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600098E")]
			[Cpp2IlInjected.Address(RVA = "0xAC31C0", Offset = "0xAC1FC0", VA = "0x180AC31C0")]
			[CompilerGenerated]
			internal set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600098F")]
		[Cpp2IlInjected.Address(RVA = "0x7A5A090", Offset = "0x7A58E90", VA = "0x187A5A090", Slot = "4")]
		public void DNRPRHFLPRB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000990")]
		[Cpp2IlInjected.Address(RVA = "0x7A5A0C0", Offset = "0x7A58EC0", VA = "0x187A5A0C0")]
		public Chip()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000166")]
	[Utf8JsonSerializable]
	public class PortGroup : IRecNetUtf8JsonObject
	{
		[Cpp2IlInjected.Token(Token = "0x170003E1")]
		public string Name
		{
			[Cpp2IlInjected.Token(Token = "0x6000991")]
			[Cpp2IlInjected.Address(RVA = "0xABD130", Offset = "0xABBF30", VA = "0x180ABD130")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000992")]
			[Cpp2IlInjected.Address(RVA = "0xABD120", Offset = "0xABBF20", VA = "0x180ABD120")]
			[CompilerGenerated]
			internal set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170003E2")]
		public Chip Input
		{
			[Cpp2IlInjected.Token(Token = "0x6000993")]
			[Cpp2IlInjected.Address(RVA = "0xAC0D20", Offset = "0xABFB20", VA = "0x180AC0D20")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000994")]
			[Cpp2IlInjected.Address(RVA = "0xAC0D10", Offset = "0xABFB10", VA = "0x180AC0D10")]
			[CompilerGenerated]
			internal set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170003E3")]
		public Chip Output
		{
			[Cpp2IlInjected.Token(Token = "0x6000995")]
			[Cpp2IlInjected.Address(RVA = "0xAC1D20", Offset = "0xAC0B20", VA = "0x180AC1D20")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000996")]
			[Cpp2IlInjected.Address(RVA = "0xAC0640", Offset = "0xABF440", VA = "0x180AC0640")]
			[CompilerGenerated]
			internal set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170003E4")]
		public string? Comment
		{
			[Cpp2IlInjected.Token(Token = "0x6000997")]
			[Cpp2IlInjected.Address(RVA = "0xAC0F90", Offset = "0xABFD90", VA = "0x180AC0F90")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000998")]
			[Cpp2IlInjected.Address(RVA = "0xAC0650", Offset = "0xABF450", VA = "0x180AC0650")]
			[CompilerGenerated]
			internal set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000999")]
		[Cpp2IlInjected.Address(RVA = "0x7A5F430", Offset = "0x7A5E230", VA = "0x187A5F430", Slot = "5")]
		public virtual void DNRPRHFLPRB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600099A")]
		[Cpp2IlInjected.Address(RVA = "0xAC4840", Offset = "0xAC3640", VA = "0x180AC4840")]
		public PortGroup()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000167")]
	[Utf8JsonSerializable]
	public class CircuitBoard : IRecNetUtf8JsonObject
	{
		[Cpp2IlInjected.Token(Token = "0x170003E5")]
		public string Name
		{
			[Cpp2IlInjected.Token(Token = "0x600099B")]
			[Cpp2IlInjected.Address(RVA = "0xABD130", Offset = "0xABBF30", VA = "0x180ABD130")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600099C")]
			[Cpp2IlInjected.Address(RVA = "0xABD120", Offset = "0xABBF20", VA = "0x180ABD120")]
			[CompilerGenerated]
			internal set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170003E6")]
		public IReadOnlyList<Chip> Chips
		{
			[Cpp2IlInjected.Token(Token = "0x600099D")]
			[Cpp2IlInjected.Address(RVA = "0xAC0D20", Offset = "0xABFB20", VA = "0x180AC0D20")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600099E")]
			[Cpp2IlInjected.Address(RVA = "0xAC0D10", Offset = "0xABFB10", VA = "0x180AC0D10")]
			[CompilerGenerated]
			internal set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170003E7")]
		public IReadOnlyList<PortGroup> PortGroups
		{
			[Cpp2IlInjected.Token(Token = "0x600099F")]
			[Cpp2IlInjected.Address(RVA = "0xAC1D20", Offset = "0xAC0B20", VA = "0x180AC1D20")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60009A0")]
			[Cpp2IlInjected.Address(RVA = "0xAC0640", Offset = "0xABF440", VA = "0x180AC0640")]
			[CompilerGenerated]
			internal set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170003E8")]
		public IReadOnlyList<CircuitBoard> Functions
		{
			[Cpp2IlInjected.Token(Token = "0x60009A1")]
			[Cpp2IlInjected.Address(RVA = "0xAC0F90", Offset = "0xABFD90", VA = "0x180AC0F90")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60009A2")]
			[Cpp2IlInjected.Address(RVA = "0xAC0650", Offset = "0xABF450", VA = "0x180AC0650")]
			[CompilerGenerated]
			internal set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170003E9")]
		public string? Comment
		{
			[Cpp2IlInjected.Token(Token = "0x60009A3")]
			[Cpp2IlInjected.Address(RVA = "0xAC0F80", Offset = "0xABFD80", VA = "0x180AC0F80")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60009A4")]
			[Cpp2IlInjected.Address(RVA = "0xAC8C50", Offset = "0xAC7A50", VA = "0x180AC8C50")]
			[CompilerGenerated]
			internal set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60009A5")]
		[Cpp2IlInjected.Address(RVA = "0x7A5A170", Offset = "0x7A58F70", VA = "0x187A5A170", Slot = "4")]
		public void DNRPRHFLPRB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60009A6")]
		[Cpp2IlInjected.Address(RVA = "0x7A5A1A0", Offset = "0x7A58FA0", VA = "0x187A5A1A0")]
		public CircuitBoard()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000168")]
	[Utf8JsonSerializable]
	public class CircuitObjectDefinitionSpawnableProperties : IRecNetUtf8JsonObject
	{
		[Cpp2IlInjected.Token(Token = "0x400065F")]
		public const string IdTagPrefix = "REPL_";

		[Cpp2IlInjected.Token(Token = "0x170003EA")]
		public string Id
		{
			[Cpp2IlInjected.Token(Token = "0x60009A7")]
			[Cpp2IlInjected.Address(RVA = "0xABD130", Offset = "0xABBF30", VA = "0x180ABD130")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60009A8")]
			[Cpp2IlInjected.Address(RVA = "0xABD120", Offset = "0xABBF20", VA = "0x180ABD120")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170003EB")]
		public int MaxCount
		{
			[Cpp2IlInjected.Token(Token = "0x60009A9")]
			[Cpp2IlInjected.Address(RVA = "0xAC7B20", Offset = "0xAC6920", VA = "0x180AC7B20")]
			[CompilerGenerated]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x60009AA")]
			[Cpp2IlInjected.Address(RVA = "0xACAE40", Offset = "0xAC9C40", VA = "0x180ACAE40")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60009AB")]
		[Cpp2IlInjected.Address(RVA = "0xABE8D0", Offset = "0xABD6D0", VA = "0x180ABE8D0", Slot = "4")]
		public void DNRPRHFLPRB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60009AC")]
		[Cpp2IlInjected.Address(RVA = "0xAC4840", Offset = "0xAC3640", VA = "0x180AC4840")]
		public CircuitObjectDefinitionSpawnableProperties()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000169")]
	[Utf8JsonSerializable]
	public class CircuitObjectDefinition : IRecNetUtf8JsonObject
	{
		[Cpp2IlInjected.Token(Token = "0x170003EC")]
		public int? Key
		{
			[Cpp2IlInjected.Token(Token = "0x60009AD")]
			[Cpp2IlInjected.Address(RVA = "0xABD130", Offset = "0xABBF30", VA = "0x180ABD130")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60009AE")]
			[Cpp2IlInjected.Address(RVA = "0xEABA00", Offset = "0xEAA800", VA = "0x180EABA00")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170003ED")]
		public string? CodeGenId
		{
			[Cpp2IlInjected.Token(Token = "0x60009AF")]
			[Cpp2IlInjected.Address(RVA = "0xAC0D20", Offset = "0xABFB20", VA = "0x180AC0D20")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60009B0")]
			[Cpp2IlInjected.Address(RVA = "0xAC0D10", Offset = "0xABFB10", VA = "0x180AC0D10")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170003EE")]
		public string Name
		{
			[Cpp2IlInjected.Token(Token = "0x60009B1")]
			[Cpp2IlInjected.Address(RVA = "0xAC1D20", Offset = "0xAC0B20", VA = "0x180AC1D20")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60009B2")]
			[Cpp2IlInjected.Address(RVA = "0xAC0640", Offset = "0xABF440", VA = "0x180AC0640")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170003EF")]
		public string Type
		{
			[Cpp2IlInjected.Token(Token = "0x60009B3")]
			[Cpp2IlInjected.Address(RVA = "0xAC0F90", Offset = "0xABFD90", VA = "0x180AC0F90")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60009B4")]
			[Cpp2IlInjected.Address(RVA = "0xAC0650", Offset = "0xABF450", VA = "0x180AC0650")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170003F0")]
		public List<CircuitObjectDefinition>? Children
		{
			[Cpp2IlInjected.Token(Token = "0x60009B5")]
			[Cpp2IlInjected.Address(RVA = "0xAC0F80", Offset = "0xABFD80", VA = "0x180AC0F80")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60009B6")]
			[Cpp2IlInjected.Address(RVA = "0xAC8C50", Offset = "0xAC7A50", VA = "0x180AC8C50")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170003F1")]
		public CircuitObjectDefinitionSpawnableProperties? SpawnableProperties
		{
			[Cpp2IlInjected.Token(Token = "0x60009B7")]
			[Cpp2IlInjected.Address(RVA = "0xAC0FC0", Offset = "0xABFDC0", VA = "0x180AC0FC0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60009B8")]
			[Cpp2IlInjected.Address(RVA = "0xAC0CF0", Offset = "0xABFAF0", VA = "0x180AC0CF0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60009B9")]
		[Cpp2IlInjected.Address(RVA = "0x7A5A380", Offset = "0x7A59180", VA = "0x187A5A380", Slot = "4")]
		public void DNRPRHFLPRB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60009BA")]
		[Cpp2IlInjected.Address(RVA = "0xAC4840", Offset = "0xAC3640", VA = "0x180AC4840")]
		public CircuitObjectDefinition()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200016A")]
	[Utf8JsonSerializable]
	public class CircuitObjectEvent : IRecNetUtf8JsonObject
	{
		[Cpp2IlInjected.Token(Token = "0x170003F2")]
		public string BaseEventGuid
		{
			[Cpp2IlInjected.Token(Token = "0x60009BB")]
			[Cpp2IlInjected.Address(RVA = "0xABD130", Offset = "0xABBF30", VA = "0x180ABD130")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60009BC")]
			[Cpp2IlInjected.Address(RVA = "0xABD120", Offset = "0xABBF20", VA = "0x180ABD120")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170003F3")]
		public string Path
		{
			[Cpp2IlInjected.Token(Token = "0x60009BD")]
			[Cpp2IlInjected.Address(RVA = "0xAC0D20", Offset = "0xABFB20", VA = "0x180AC0D20")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60009BE")]
			[Cpp2IlInjected.Address(RVA = "0xAC0D10", Offset = "0xABFB10", VA = "0x180AC0D10")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60009BF")]
		[Cpp2IlInjected.Address(RVA = "0xABE8D0", Offset = "0xABD6D0", VA = "0x180ABE8D0", Slot = "4")]
		public void DNRPRHFLPRB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60009C0")]
		[Cpp2IlInjected.Address(RVA = "0xAC4840", Offset = "0xAC3640", VA = "0x180AC4840")]
		public CircuitObjectEvent()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200016B")]
	[Utf8JsonSerializable]
	public class GeneratedCircuitBoardDTO : IRecNetUtf8JsonObject
	{
		[Cpp2IlInjected.Token(Token = "0x170003F4")]
		public string Id
		{
			[Cpp2IlInjected.Token(Token = "0x60009C1")]
			[Cpp2IlInjected.Address(RVA = "0xABD130", Offset = "0xABBF30", VA = "0x180ABD130")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60009C2")]
			[Cpp2IlInjected.Address(RVA = "0xABD120", Offset = "0xABBF20", VA = "0x180ABD120")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170003F5")]
		public CircuitBoard CircuitBoard
		{
			[Cpp2IlInjected.Token(Token = "0x60009C3")]
			[Cpp2IlInjected.Address(RVA = "0xAC0D20", Offset = "0xABFB20", VA = "0x180AC0D20")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60009C4")]
			[Cpp2IlInjected.Address(RVA = "0xAC0D10", Offset = "0xABFB10", VA = "0x180AC0D10")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170003F6")]
		public CircuitObjectDefinition? ObjectDefinition
		{
			[Cpp2IlInjected.Token(Token = "0x60009C5")]
			[Cpp2IlInjected.Address(RVA = "0xAC1D20", Offset = "0xAC0B20", VA = "0x180AC1D20")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60009C6")]
			[Cpp2IlInjected.Address(RVA = "0xAC0640", Offset = "0xABF440", VA = "0x180AC0640")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170003F7")]
		public List<CircuitObjectDefinition>? SceneObjectDefinitions
		{
			[Cpp2IlInjected.Token(Token = "0x60009C7")]
			[Cpp2IlInjected.Address(RVA = "0xAC0F90", Offset = "0xABFD90", VA = "0x180AC0F90")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60009C8")]
			[Cpp2IlInjected.Address(RVA = "0xAC0650", Offset = "0xABF450", VA = "0x180AC0650")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170003F8")]
		public IReadOnlyList<Chip> EventDefinitions
		{
			[Cpp2IlInjected.Token(Token = "0x60009C9")]
			[Cpp2IlInjected.Address(RVA = "0xAC0F80", Offset = "0xABFD80", VA = "0x180AC0F80")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60009CA")]
			[Cpp2IlInjected.Address(RVA = "0xAC8C50", Offset = "0xAC7A50", VA = "0x180AC8C50")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170003F9")]
		public IReadOnlyList<CircuitObjectEvent> ObjectEvents
		{
			[Cpp2IlInjected.Token(Token = "0x60009CB")]
			[Cpp2IlInjected.Address(RVA = "0xAC0FC0", Offset = "0xABFDC0", VA = "0x180AC0FC0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60009CC")]
			[Cpp2IlInjected.Address(RVA = "0xAC0CF0", Offset = "0xABFAF0", VA = "0x180AC0CF0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170003FA")]
		public string? Code
		{
			[Cpp2IlInjected.Token(Token = "0x60009CD")]
			[Cpp2IlInjected.Address(RVA = "0xAC5120", Offset = "0xAC3F20", VA = "0x180AC5120")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60009CE")]
			[Cpp2IlInjected.Address(RVA = "0xAC0FB0", Offset = "0xABFDB0", VA = "0x180AC0FB0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60009CF")]
		[Cpp2IlInjected.Address(RVA = "0x7A5BD20", Offset = "0x7A5AB20", VA = "0x187A5BD20", Slot = "4")]
		public void DNRPRHFLPRB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60009D0")]
		[Cpp2IlInjected.Address(RVA = "0x7A5BDB0", Offset = "0x7A5ABB0", VA = "0x187A5BDB0")]
		public GeneratedCircuitBoardDTO()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200016C")]
	[Utf8JsonSerializable]
	public class GenerateCircuitsResponseDTO : IRecNetUtf8JsonObject
	{
		[Cpp2IlInjected.Token(Token = "0x170003FB")]
		public RecNetResultObject<GeneratedCircuitBoardDTO> Result
		{
			[Cpp2IlInjected.Token(Token = "0x60009D1")]
			[Cpp2IlInjected.Address(RVA = "0xABD130", Offset = "0xABBF30", VA = "0x180ABD130")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60009D2")]
			[Cpp2IlInjected.Address(RVA = "0xABD120", Offset = "0xABBF20", VA = "0x180ABD120")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170003FC")]
		public decimal CodeGenerationCost
		{
			[Cpp2IlInjected.Token(Token = "0x60009D3")]
			[Cpp2IlInjected.Address(RVA = "0xBED410", Offset = "0xBEC210", VA = "0x180BED410")]
			[CompilerGenerated]
			get
			{
				return default(decimal);
			}
			[Cpp2IlInjected.Token(Token = "0x60009D4")]
			[Cpp2IlInjected.Address(RVA = "0xF76460", Offset = "0xF75260", VA = "0x180F76460")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60009D5")]
		[Cpp2IlInjected.Address(RVA = "0x7976050", Offset = "0x7974E50", VA = "0x187976050", Slot = "4")]
		public void DNRPRHFLPRB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60009D6")]
		[Cpp2IlInjected.Address(RVA = "0xAC4840", Offset = "0xAC3640", VA = "0x180AC4840")]
		public GenerateCircuitsResponseDTO()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200016D")]
	public enum AIBalanceStatus
	{
		[Cpp2IlInjected.Token(Token = "0x4000674")]
		Empty,
		[Cpp2IlInjected.Token(Token = "0x4000675")]
		Low,
		[Cpp2IlInjected.Token(Token = "0x4000676")]
		Good
	}
	[Cpp2IlInjected.Token(Token = "0x200016E")]
	[Utf8JsonSerializable]
	public class MakerAITimeBalanceStatusUpdatePushNotification : IRecNetUtf8JsonObject
	{
		[Cpp2IlInjected.Token(Token = "0x170003FD")]
		public AIBalanceStatus TimeBalanceStatus
		{
			[Cpp2IlInjected.Token(Token = "0x60009D7")]
			[Cpp2IlInjected.Address(RVA = "0xABD110", Offset = "0xABBF10", VA = "0x180ABD110")]
			[CompilerGenerated]
			get
			{
				return default(AIBalanceStatus);
			}
			[Cpp2IlInjected.Token(Token = "0x60009D8")]
			[Cpp2IlInjected.Address(RVA = "0xAC1D40", Offset = "0xAC0B40", VA = "0x180AC1D40")]
			[CompilerGenerated]
			internal set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170003FE")]
		public DateTime TimeExpiresAt
		{
			[Cpp2IlInjected.Token(Token = "0x60009D9")]
			[Cpp2IlInjected.Address(RVA = "0xAC0D20", Offset = "0xABFB20", VA = "0x180AC0D20")]
			[CompilerGenerated]
			get
			{
				return default(DateTime);
			}
			[Cpp2IlInjected.Token(Token = "0x60009DA")]
			[Cpp2IlInjected.Address(RVA = "0xE27A80", Offset = "0xE26880", VA = "0x180E27A80")]
			[CompilerGenerated]
			internal set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60009DB")]
		[Cpp2IlInjected.Address(RVA = "0xABE8D0", Offset = "0xABD6D0", VA = "0x180ABE8D0", Slot = "4")]
		public void DNRPRHFLPRB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60009DC")]
		[Cpp2IlInjected.Address(RVA = "0xAC4840", Offset = "0xAC3640", VA = "0x180AC4840")]
		public MakerAITimeBalanceStatusUpdatePushNotification()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200016F")]
	[Utf8JsonSerializable]
	public class MakerAIUsageBalanceStatusUpdatePushNotification : IRecNetUtf8JsonObject
	{
		[Cpp2IlInjected.Token(Token = "0x170003FF")]
		public AIBalanceStatus UsageBalanceStatus
		{
			[Cpp2IlInjected.Token(Token = "0x60009DD")]
			[Cpp2IlInjected.Address(RVA = "0xABD110", Offset = "0xABBF10", VA = "0x180ABD110")]
			[CompilerGenerated]
			get
			{
				return default(AIBalanceStatus);
			}
			[Cpp2IlInjected.Token(Token = "0x60009DE")]
			[Cpp2IlInjected.Address(RVA = "0xAC1D40", Offset = "0xAC0B40", VA = "0x180AC1D40")]
			[CompilerGenerated]
			internal set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000400")]
		public float UsagePercent
		{
			[Cpp2IlInjected.Token(Token = "0x60009DF")]
			[Cpp2IlInjected.Address(RVA = "0xEBF250", Offset = "0xEBE050", VA = "0x180EBF250")]
			[CompilerGenerated]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x60009E0")]
			[Cpp2IlInjected.Address(RVA = "0xEBF2B0", Offset = "0xEBE0B0", VA = "0x180EBF2B0")]
			[CompilerGenerated]
			internal set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60009E1")]
		[Cpp2IlInjected.Address(RVA = "0xABE8D0", Offset = "0xABD6D0", VA = "0x180ABE8D0", Slot = "4")]
		public void DNRPRHFLPRB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60009E2")]
		[Cpp2IlInjected.Address(RVA = "0xAC4840", Offset = "0xAC3640", VA = "0x180AC4840")]
		public MakerAIUsageBalanceStatusUpdatePushNotification()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000170")]
	[Utf8JsonSerializable]
	public class MakerAIBalancesDTO : IRecNetUtf8JsonObject
	{
		[Cpp2IlInjected.Token(Token = "0x17000401")]
		public AIBalanceStatus TimeBalanceStatus
		{
			[Cpp2IlInjected.Token(Token = "0x60009E3")]
			[Cpp2IlInjected.Address(RVA = "0xABD110", Offset = "0xABBF10", VA = "0x180ABD110")]
			[CompilerGenerated]
			get
			{
				return default(AIBalanceStatus);
			}
			[Cpp2IlInjected.Token(Token = "0x60009E4")]
			[Cpp2IlInjected.Address(RVA = "0xAC1D40", Offset = "0xAC0B40", VA = "0x180AC1D40")]
			[CompilerGenerated]
			internal set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000402")]
		public DateTime TimeExpiresAt
		{
			[Cpp2IlInjected.Token(Token = "0x60009E5")]
			[Cpp2IlInjected.Address(RVA = "0xAC0D20", Offset = "0xABFB20", VA = "0x180AC0D20")]
			[CompilerGenerated]
			get
			{
				return default(DateTime);
			}
			[Cpp2IlInjected.Token(Token = "0x60009E6")]
			[Cpp2IlInjected.Address(RVA = "0xE27A80", Offset = "0xE26880", VA = "0x180E27A80")]
			[CompilerGenerated]
			internal set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000403")]
		public AIBalanceStatus UsageBalanceStatus
		{
			[Cpp2IlInjected.Token(Token = "0x60009E7")]
			[Cpp2IlInjected.Address(RVA = "0xACF4D0", Offset = "0xACE2D0", VA = "0x180ACF4D0")]
			[CompilerGenerated]
			get
			{
				return default(AIBalanceStatus);
			}
			[Cpp2IlInjected.Token(Token = "0x60009E8")]
			[Cpp2IlInjected.Address(RVA = "0xB20FD0", Offset = "0xB1FDD0", VA = "0x180B20FD0")]
			[CompilerGenerated]
			internal set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000404")]
		public float UsagePercent
		{
			[Cpp2IlInjected.Token(Token = "0x60009E9")]
			[Cpp2IlInjected.Address(RVA = "0xB21BD0", Offset = "0xB209D0", VA = "0x180B21BD0")]
			[CompilerGenerated]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x60009EA")]
			[Cpp2IlInjected.Address(RVA = "0xB20FC0", Offset = "0xB1FDC0", VA = "0x180B20FC0")]
			[CompilerGenerated]
			internal set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000405")]
		public AIBalanceStatus RRPlusUsageBalanceStatus
		{
			[Cpp2IlInjected.Token(Token = "0x60009EB")]
			[Cpp2IlInjected.Address(RVA = "0xAC2060", Offset = "0xAC0E60", VA = "0x180AC2060")]
			[CompilerGenerated]
			get
			{
				return default(AIBalanceStatus);
			}
			[Cpp2IlInjected.Token(Token = "0x60009EC")]
			[Cpp2IlInjected.Address(RVA = "0xAC1D30", Offset = "0xAC0B30", VA = "0x180AC1D30")]
			[CompilerGenerated]
			internal set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000406")]
		public float RRPlusUsagePercent
		{
			[Cpp2IlInjected.Token(Token = "0x60009ED")]
			[Cpp2IlInjected.Address(RVA = "0xE8CCD0", Offset = "0xE8BAD0", VA = "0x180E8CCD0")]
			[CompilerGenerated]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x60009EE")]
			[Cpp2IlInjected.Address(RVA = "0xEC6870", Offset = "0xEC5670", VA = "0x180EC6870")]
			[CompilerGenerated]
			internal set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60009EF")]
		[Cpp2IlInjected.Address(RVA = "0xABE8D0", Offset = "0xABD6D0", VA = "0x180ABE8D0", Slot = "4")]
		public void DNRPRHFLPRB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60009F0")]
		[Cpp2IlInjected.Address(RVA = "0xAC4840", Offset = "0xAC3640", VA = "0x180AC4840")]
		public MakerAIBalancesDTO()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000171")]
	[Utf8JsonSerializable]
	public class MakerAIFreeTrialConfigDTO : IRecNetUtf8JsonObject
	{
		[Cpp2IlInjected.Token(Token = "0x17000407")]
		public TimeSpan Cooldown
		{
			[Cpp2IlInjected.Token(Token = "0x60009F1")]
			[Cpp2IlInjected.Address(RVA = "0xABD130", Offset = "0xABBF30", VA = "0x180ABD130")]
			[CompilerGenerated]
			get
			{
				return default(TimeSpan);
			}
			[Cpp2IlInjected.Token(Token = "0x60009F2")]
			[Cpp2IlInjected.Address(RVA = "0xEABA00", Offset = "0xEAA800", VA = "0x180EABA00")]
			[CompilerGenerated]
			internal set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000408")]
		public TimeSpan Duration
		{
			[Cpp2IlInjected.Token(Token = "0x60009F3")]
			[Cpp2IlInjected.Address(RVA = "0xAC0D20", Offset = "0xABFB20", VA = "0x180AC0D20")]
			[CompilerGenerated]
			get
			{
				return default(TimeSpan);
			}
			[Cpp2IlInjected.Token(Token = "0x60009F4")]
			[Cpp2IlInjected.Address(RVA = "0xE27A80", Offset = "0xE26880", VA = "0x180E27A80")]
			[CompilerGenerated]
			internal set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60009F5")]
		[Cpp2IlInjected.Address(RVA = "0xABE8D0", Offset = "0xABD6D0", VA = "0x180ABE8D0", Slot = "4")]
		public void DNRPRHFLPRB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60009F6")]
		[Cpp2IlInjected.Address(RVA = "0xAC4840", Offset = "0xAC3640", VA = "0x180AC4840")]
		public MakerAIFreeTrialConfigDTO()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000172")]
	[Utf8JsonSerializable]
	public class SearchRoomsResponseDTO : IRecNetUtf8JsonObject
	{
		[Cpp2IlInjected.Token(Token = "0x17000409")]
		public List<string> Value
		{
			[Cpp2IlInjected.Token(Token = "0x60009F7")]
			[Cpp2IlInjected.Address(RVA = "0xABD130", Offset = "0xABBF30", VA = "0x180ABD130")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60009F8")]
			[Cpp2IlInjected.Address(RVA = "0xABD120", Offset = "0xABBF20", VA = "0x180ABD120")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60009F9")]
		[Cpp2IlInjected.Address(RVA = "0xABE8D0", Offset = "0xABD6D0", VA = "0x180ABE8D0", Slot = "4")]
		public void DNRPRHFLPRB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60009FA")]
		[Cpp2IlInjected.Address(RVA = "0xAC4840", Offset = "0xAC3640", VA = "0x180AC4840")]
		public SearchRoomsResponseDTO()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000173")]
	[Utf8JsonSerializable]
	public class GenerateSpeechRequestDTO : IRecNetUtf8JsonObject
	{
		[Cpp2IlInjected.Token(Token = "0x1700040A")]
		public string? Model
		{
			[Cpp2IlInjected.Token(Token = "0x60009FB")]
			[Cpp2IlInjected.Address(RVA = "0xABD130", Offset = "0xABBF30", VA = "0x180ABD130")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60009FC")]
			[Cpp2IlInjected.Address(RVA = "0xABD120", Offset = "0xABBF20", VA = "0x180ABD120")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700040B")]
		public string Input
		{
			[Cpp2IlInjected.Token(Token = "0x60009FD")]
			[Cpp2IlInjected.Address(RVA = "0xAC0D20", Offset = "0xABFB20", VA = "0x180AC0D20")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60009FE")]
			[Cpp2IlInjected.Address(RVA = "0xAC0D10", Offset = "0xABFB10", VA = "0x180AC0D10")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700040C")]
		public string Voice
		{
			[Cpp2IlInjected.Token(Token = "0x60009FF")]
			[Cpp2IlInjected.Address(RVA = "0xAC1D20", Offset = "0xAC0B20", VA = "0x180AC1D20")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000A00")]
			[Cpp2IlInjected.Address(RVA = "0xAC0640", Offset = "0xABF440", VA = "0x180AC0640")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700040D")]
		public string ResponseFormat
		{
			[Cpp2IlInjected.Token(Token = "0x6000A01")]
			[Cpp2IlInjected.Address(RVA = "0xAC0F90", Offset = "0xABFD90", VA = "0x180AC0F90")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000A02")]
			[Cpp2IlInjected.Address(RVA = "0xAC0650", Offset = "0xABF450", VA = "0x180AC0650")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700040E")]
		public string? Instructions
		{
			[Cpp2IlInjected.Token(Token = "0x6000A03")]
			[Cpp2IlInjected.Address(RVA = "0xAC0F80", Offset = "0xABFD80", VA = "0x180AC0F80")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000A04")]
			[Cpp2IlInjected.Address(RVA = "0xAC8C50", Offset = "0xAC7A50", VA = "0x180AC8C50")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000A05")]
		[Cpp2IlInjected.Address(RVA = "0xABE8D0", Offset = "0xABD6D0", VA = "0x180ABE8D0", Slot = "4")]
		public void DNRPRHFLPRB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000A06")]
		[Cpp2IlInjected.Address(RVA = "0x7A5BCD0", Offset = "0x7A5AAD0", VA = "0x187A5BCD0")]
		public GenerateSpeechRequestDTO()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000174")]
	[Utf8JsonSerializable]
	public class GameAIRoomSpendSummaryDTO : IRecNetUtf8JsonObject
	{
		[Cpp2IlInjected.Token(Token = "0x1700040F")]
		public RecNetResult GameAIStatus
		{
			[Cpp2IlInjected.Token(Token = "0x6000A07")]
			[Cpp2IlInjected.Address(RVA = "0xABD130", Offset = "0xABBF30", VA = "0x180ABD130")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000A08")]
			[Cpp2IlInjected.Address(RVA = "0xABD120", Offset = "0xABBF20", VA = "0x180ABD120")]
			[CompilerGenerated]
			internal set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000410")]
		public AIBalanceStatus PromoBalanceStatus
		{
			[Cpp2IlInjected.Token(Token = "0x6000A09")]
			[Cpp2IlInjected.Address(RVA = "0xAC7B20", Offset = "0xAC6920", VA = "0x180AC7B20")]
			[CompilerGenerated]
			get
			{
				return default(AIBalanceStatus);
			}
			[Cpp2IlInjected.Token(Token = "0x6000A0A")]
			[Cpp2IlInjected.Address(RVA = "0xACAE40", Offset = "0xAC9C40", VA = "0x180ACAE40")]
			[CompilerGenerated]
			internal set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000411")]
		public long? AmountSpent
		{
			[Cpp2IlInjected.Token(Token = "0x6000A0B")]
			[Cpp2IlInjected.Address(RVA = "0xED04F0", Offset = "0xECF2F0", VA = "0x180ED04F0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000A0C")]
			[Cpp2IlInjected.Address(RVA = "0xFAD4B0", Offset = "0xFAC2B0", VA = "0x180FAD4B0")]
			[CompilerGenerated]
			internal set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000412")]
		public DateTime? AmountSpentSince
		{
			[Cpp2IlInjected.Token(Token = "0x6000A0D")]
			[Cpp2IlInjected.Address(RVA = "0xF782C0", Offset = "0xF770C0", VA = "0x180F782C0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000A0E")]
			[Cpp2IlInjected.Address(RVA = "0xF782D0", Offset = "0xF770D0", VA = "0x180F782D0")]
			[CompilerGenerated]
			internal set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000413")]
		public long? AvailableBalance
		{
			[Cpp2IlInjected.Token(Token = "0x6000A0F")]
			[Cpp2IlInjected.Address(RVA = "0x108B4B0", Offset = "0x108A2B0", VA = "0x18108B4B0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000A10")]
			[Cpp2IlInjected.Address(RVA = "0x108B5F0", Offset = "0x108A3F0", VA = "0x18108B5F0")]
			[CompilerGenerated]
			internal set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000A11")]
		[Cpp2IlInjected.Address(RVA = "0xABE8D0", Offset = "0xABD6D0", VA = "0x180ABE8D0", Slot = "4")]
		public void DNRPRHFLPRB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000A12")]
		[Cpp2IlInjected.Address(RVA = "0xAC4840", Offset = "0xAC3640", VA = "0x180AC4840")]
		public GameAIRoomSpendSummaryDTO()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000175")]
	[Utf8JsonSerializable]
	public class GameAIPromoBalanceDTO : IRecNetUtf8JsonObject
	{
		[Cpp2IlInjected.Token(Token = "0x17000414")]
		public int AvailableDevCreditPacks
		{
			[Cpp2IlInjected.Token(Token = "0x6000A13")]
			[Cpp2IlInjected.Address(RVA = "0xABD110", Offset = "0xABBF10", VA = "0x180ABD110")]
			[CompilerGenerated]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x6000A14")]
			[Cpp2IlInjected.Address(RVA = "0xAC1D40", Offset = "0xAC0B40", VA = "0x180AC1D40")]
			[CompilerGenerated]
			internal set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000415")]
		public DateTime? NextDevCreditPackGrantDate
		{
			[Cpp2IlInjected.Token(Token = "0x6000A15")]
			[Cpp2IlInjected.Address(RVA = "0xBED410", Offset = "0xBEC210", VA = "0x180BED410")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000A16")]
			[Cpp2IlInjected.Address(RVA = "0xF76460", Offset = "0xF75260", VA = "0x180F76460")]
			[CompilerGenerated]
			internal set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000A17")]
		[Cpp2IlInjected.Address(RVA = "0xABE8D0", Offset = "0xABD6D0", VA = "0x180ABE8D0", Slot = "4")]
		public void DNRPRHFLPRB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000A18")]
		[Cpp2IlInjected.Address(RVA = "0xAC4840", Offset = "0xAC3640", VA = "0x180AC4840")]
		public GameAIPromoBalanceDTO()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000176")]
	[Utf8JsonSerializable]
	public class ConversationDTO : IRecNetUtf8JsonObject
	{
		[Cpp2IlInjected.Token(Token = "0x17000416")]
		public List<ConversationMessageDTO> ConversationItems
		{
			[Cpp2IlInjected.Token(Token = "0x6000A19")]
			[Cpp2IlInjected.Address(RVA = "0xABD130", Offset = "0xABBF30", VA = "0x180ABD130")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000A1A")]
			[Cpp2IlInjected.Address(RVA = "0xABD120", Offset = "0xABBF20", VA = "0x180ABD120")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000A1B")]
		[Cpp2IlInjected.Address(RVA = "0xABE8D0", Offset = "0xABD6D0", VA = "0x180ABE8D0", Slot = "4")]
		public void DNRPRHFLPRB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000A1C")]
		[Cpp2IlInjected.Address(RVA = "0xAC4840", Offset = "0xAC3640", VA = "0x180AC4840")]
		public ConversationDTO()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000177")]
	[Utf8JsonSerializable]
	public class ConversationMessageDTO : IRecNetUtf8JsonObject
	{
		[Cpp2IlInjected.Token(Token = "0x17000417")]
		public string Conversation
		{
			[Cpp2IlInjected.Token(Token = "0x6000A1D")]
			[Cpp2IlInjected.Address(RVA = "0xABD130", Offset = "0xABBF30", VA = "0x180ABD130")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000A1E")]
			[Cpp2IlInjected.Address(RVA = "0xABD120", Offset = "0xABBF20", VA = "0x180ABD120")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000A1F")]
		[Cpp2IlInjected.Address(RVA = "0xABE8D0", Offset = "0xABD6D0", VA = "0x180ABE8D0", Slot = "4")]
		public void DNRPRHFLPRB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000A20")]
		[Cpp2IlInjected.Address(RVA = "0x14914E0", Offset = "0x14902E0", VA = "0x1814914E0")]
		public ConversationMessageDTO()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000178")]
	[Utf8JsonSerializable]
	public class RoomieUserFactsDTO : IRecNetUtf8JsonObject
	{
		[Cpp2IlInjected.Token(Token = "0x17000418")]
		public List<UserFactDTO> UserFacts
		{
			[Cpp2IlInjected.Token(Token = "0x6000A21")]
			[Cpp2IlInjected.Address(RVA = "0xABD130", Offset = "0xABBF30", VA = "0x180ABD130")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000A22")]
			[Cpp2IlInjected.Address(RVA = "0xABD120", Offset = "0xABBF20", VA = "0x180ABD120")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000419")]
		public string UserContext
		{
			[Cpp2IlInjected.Token(Token = "0x6000A23")]
			[Cpp2IlInjected.Address(RVA = "0xAC0D20", Offset = "0xABFB20", VA = "0x180AC0D20")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000A24")]
			[Cpp2IlInjected.Address(RVA = "0xAC0D10", Offset = "0xABFB10", VA = "0x180AC0D10")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000A25")]
		[Cpp2IlInjected.Address(RVA = "0xABE8D0", Offset = "0xABD6D0", VA = "0x180ABE8D0", Slot = "4")]
		public void DNRPRHFLPRB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000A26")]
		[Cpp2IlInjected.Address(RVA = "0x2525900", Offset = "0x2524700", VA = "0x182525900")]
		public RoomieUserFactsDTO()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000179")]
	[Utf8JsonSerializable]
	public class UserFactDTO : IRecNetUtf8JsonObject
	{
		[Cpp2IlInjected.Token(Token = "0x1700041A")]
		public string Id
		{
			[Cpp2IlInjected.Token(Token = "0x6000A28")]
			[Cpp2IlInjected.Address(RVA = "0xABD130", Offset = "0xABBF30", VA = "0x180ABD130")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000A29")]
			[Cpp2IlInjected.Address(RVA = "0xABD120", Offset = "0xABBF20", VA = "0x180ABD120")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700041B")]
		public string Predicate
		{
			[Cpp2IlInjected.Token(Token = "0x6000A2A")]
			[Cpp2IlInjected.Address(RVA = "0xAC0D20", Offset = "0xABFB20", VA = "0x180AC0D20")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000A2B")]
			[Cpp2IlInjected.Address(RVA = "0xAC0D10", Offset = "0xABFB10", VA = "0x180AC0D10")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700041C")]
		public string Object
		{
			[Cpp2IlInjected.Token(Token = "0x6000A2C")]
			[Cpp2IlInjected.Address(RVA = "0xAC1D20", Offset = "0xAC0B20", VA = "0x180AC1D20")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000A2D")]
			[Cpp2IlInjected.Address(RVA = "0xAC0640", Offset = "0xABF440", VA = "0x180AC0640")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700041D")]
		public string Emotion
		{
			[Cpp2IlInjected.Token(Token = "0x6000A2E")]
			[Cpp2IlInjected.Address(RVA = "0xAC0F90", Offset = "0xABFD90", VA = "0x180AC0F90")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000A2F")]
			[Cpp2IlInjected.Address(RVA = "0xAC0650", Offset = "0xABF450", VA = "0x180AC0650")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700041E")]
		public DateTime CreatedAt
		{
			[Cpp2IlInjected.Token(Token = "0x6000A30")]
			[Cpp2IlInjected.Address(RVA = "0xAC0F80", Offset = "0xABFD80", VA = "0x180AC0F80")]
			[CompilerGenerated]
			get
			{
				return default(DateTime);
			}
			[Cpp2IlInjected.Token(Token = "0x6000A31")]
			[Cpp2IlInjected.Address(RVA = "0xAC0FA0", Offset = "0xABFDA0", VA = "0x180AC0FA0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000A27")]
		[Cpp2IlInjected.Address(RVA = "0xACD980", Offset = "0xACC780", VA = "0x180ACD980")]
		public UserFactDTO(string id)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000A32")]
		[Cpp2IlInjected.Address(RVA = "0xABE8D0", Offset = "0xABD6D0", VA = "0x180ABE8D0", Slot = "4")]
		public void DNRPRHFLPRB()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200017A")]
	public enum ConversationMessageRole
	{
		[Cpp2IlInjected.Token(Token = "0x400069A")]
		User,
		[Cpp2IlInjected.Token(Token = "0x400069B")]
		System,
		[Cpp2IlInjected.Token(Token = "0x400069C")]
		AI
	}
	[Cpp2IlInjected.Token(Token = "0x200017B")]
	[Utf8JsonSerializable]
	public class AddMessageToConversationRequestDTO : IRecNetUtf8JsonObject
	{
		[Cpp2IlInjected.Token(Token = "0x1700041F")]
		public string ConversationId
		{
			[Cpp2IlInjected.Token(Token = "0x6000A33")]
			[Cpp2IlInjected.Address(RVA = "0xABD130", Offset = "0xABBF30", VA = "0x180ABD130")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000A34")]
			[Cpp2IlInjected.Address(RVA = "0xABD120", Offset = "0xABBF20", VA = "0x180ABD120")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000420")]
		public ConversationMessageRole Role
		{
			[Cpp2IlInjected.Token(Token = "0x6000A35")]
			[Cpp2IlInjected.Address(RVA = "0xAC7B20", Offset = "0xAC6920", VA = "0x180AC7B20")]
			[CompilerGenerated]
			get
			{
				return default(ConversationMessageRole);
			}
			[Cpp2IlInjected.Token(Token = "0x6000A36")]
			[Cpp2IlInjected.Address(RVA = "0xACAE40", Offset = "0xAC9C40", VA = "0x180ACAE40")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000421")]
		public string Text
		{
			[Cpp2IlInjected.Token(Token = "0x6000A37")]
			[Cpp2IlInjected.Address(RVA = "0xAC1D20", Offset = "0xAC0B20", VA = "0x180AC1D20")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000A38")]
			[Cpp2IlInjected.Address(RVA = "0xAC0640", Offset = "0xABF440", VA = "0x180AC0640")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000A39")]
		[Cpp2IlInjected.Address(RVA = "0xABE8D0", Offset = "0xABD6D0", VA = "0x180ABE8D0", Slot = "4")]
		public void DNRPRHFLPRB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000A3A")]
		[Cpp2IlInjected.Address(RVA = "0xAC4840", Offset = "0xAC3640", VA = "0x180AC4840")]
		public AddMessageToConversationRequestDTO()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200017C")]
	[Utf8JsonSerializable]
	public class AddToolCallResponseToConversationRequestDTO : IRecNetUtf8JsonObject
	{
		[Cpp2IlInjected.Token(Token = "0x17000422")]
		public string ConversationId
		{
			[Cpp2IlInjected.Token(Token = "0x6000A3B")]
			[Cpp2IlInjected.Address(RVA = "0xABD130", Offset = "0xABBF30", VA = "0x180ABD130")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000A3C")]
			[Cpp2IlInjected.Address(RVA = "0xABD120", Offset = "0xABBF20", VA = "0x180ABD120")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000423")]
		public string ToolCallId
		{
			[Cpp2IlInjected.Token(Token = "0x6000A3D")]
			[Cpp2IlInjected.Address(RVA = "0xAC0D20", Offset = "0xABFB20", VA = "0x180AC0D20")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000A3E")]
			[Cpp2IlInjected.Address(RVA = "0xAC0D10", Offset = "0xABFB10", VA = "0x180AC0D10")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000424")]
		public string Response
		{
			[Cpp2IlInjected.Token(Token = "0x6000A3F")]
			[Cpp2IlInjected.Address(RVA = "0xAC1D20", Offset = "0xAC0B20", VA = "0x180AC1D20")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000A40")]
			[Cpp2IlInjected.Address(RVA = "0xAC0640", Offset = "0xABF440", VA = "0x180AC0640")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000A41")]
		[Cpp2IlInjected.Address(RVA = "0xABE8D0", Offset = "0xABD6D0", VA = "0x180ABE8D0", Slot = "4")]
		public void DNRPRHFLPRB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000A42")]
		[Cpp2IlInjected.Address(RVA = "0xAC4840", Offset = "0xAC3640", VA = "0x180AC4840")]
		public AddToolCallResponseToConversationRequestDTO()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200017D")]
	public enum ToolChoice
	{
		[Cpp2IlInjected.Token(Token = "0x40006A4")]
		Auto,
		[Cpp2IlInjected.Token(Token = "0x40006A5")]
		None,
		[Cpp2IlInjected.Token(Token = "0x40006A6")]
		Required,
		[Cpp2IlInjected.Token(Token = "0x40006A7")]
		Forced
	}
	[Cpp2IlInjected.Token(Token = "0x200017E")]
	[Utf8JsonSerializable]
	public class NamedSchemaDTO : IRecNetUtf8JsonObject
	{
		[Cpp2IlInjected.Token(Token = "0x17000425")]
		public string Name
		{
			[Cpp2IlInjected.Token(Token = "0x6000A43")]
			[Cpp2IlInjected.Address(RVA = "0xABD130", Offset = "0xABBF30", VA = "0x180ABD130")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000A44")]
			[Cpp2IlInjected.Address(RVA = "0xABD120", Offset = "0xABBF20", VA = "0x180ABD120")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000426")]
		public string Schema
		{
			[Cpp2IlInjected.Token(Token = "0x6000A45")]
			[Cpp2IlInjected.Address(RVA = "0xAC0D20", Offset = "0xABFB20", VA = "0x180AC0D20")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000A46")]
			[Cpp2IlInjected.Address(RVA = "0xAC0D10", Offset = "0xABFB10", VA = "0x180AC0D10")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000427")]
		public string? Description
		{
			[Cpp2IlInjected.Token(Token = "0x6000A47")]
			[Cpp2IlInjected.Address(RVA = "0xAC1D20", Offset = "0xAC0B20", VA = "0x180AC1D20")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000A48")]
			[Cpp2IlInjected.Address(RVA = "0xAC0640", Offset = "0xABF440", VA = "0x180AC0640")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000A49")]
		[Cpp2IlInjected.Address(RVA = "0xABE8D0", Offset = "0xABD6D0", VA = "0x180ABE8D0", Slot = "4")]
		public void DNRPRHFLPRB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000A4A")]
		[Cpp2IlInjected.Address(RVA = "0xAC4840", Offset = "0xAC3640", VA = "0x180AC4840")]
		public NamedSchemaDTO()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200017F")]
	[Utf8JsonSerializable]
	public class GenerateConversationResponseRequestDTO : IRecNetUtf8JsonObject
	{
		[Cpp2IlInjected.Token(Token = "0x17000428")]
		public string ConversationId
		{
			[Cpp2IlInjected.Token(Token = "0x6000A4B")]
			[Cpp2IlInjected.Address(RVA = "0xABD130", Offset = "0xABBF30", VA = "0x180ABD130")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000A4C")]
			[Cpp2IlInjected.Address(RVA = "0xABD120", Offset = "0xABBF20", VA = "0x180ABD120")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000429")]
		public string? Model
		{
			[Cpp2IlInjected.Token(Token = "0x6000A4D")]
			[Cpp2IlInjected.Address(RVA = "0xAC0D20", Offset = "0xABFB20", VA = "0x180AC0D20")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000A4E")]
			[Cpp2IlInjected.Address(RVA = "0xAC0D10", Offset = "0xABFB10", VA = "0x180AC0D10")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700042A")]
		public float? Temperature
		{
			[Cpp2IlInjected.Token(Token = "0x6000A4F")]
			[Cpp2IlInjected.Address(RVA = "0xAC1D20", Offset = "0xAC0B20", VA = "0x180AC1D20")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000A50")]
			[Cpp2IlInjected.Address(RVA = "0xE33D40", Offset = "0xE32B40", VA = "0x180E33D40")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700042B")]
		public NamedSchemaDTO? ResponseFormat
		{
			[Cpp2IlInjected.Token(Token = "0x6000A51")]
			[Cpp2IlInjected.Address(RVA = "0xAC0F90", Offset = "0xABFD90", VA = "0x180AC0F90")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000A52")]
			[Cpp2IlInjected.Address(RVA = "0xAC0650", Offset = "0xABF450", VA = "0x180AC0650")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700042C")]
		public List<NamedSchemaDTO> Tools
		{
			[Cpp2IlInjected.Token(Token = "0x6000A53")]
			[Cpp2IlInjected.Address(RVA = "0xAC0F80", Offset = "0xABFD80", VA = "0x180AC0F80")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000A54")]
			[Cpp2IlInjected.Address(RVA = "0xAC8C50", Offset = "0xAC7A50", VA = "0x180AC8C50")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700042D")]
		public ToolChoice ToolChoice
		{
			[Cpp2IlInjected.Token(Token = "0x6000A55")]
			[Cpp2IlInjected.Address(RVA = "0xAEE0C0", Offset = "0xAECEC0", VA = "0x180AEE0C0")]
			[CompilerGenerated]
			get
			{
				return default(ToolChoice);
			}
			[Cpp2IlInjected.Token(Token = "0x6000A56")]
			[Cpp2IlInjected.Address(RVA = "0xE1B620", Offset = "0xE1A420", VA = "0x180E1B620")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700042E")]
		public string? ForceToolName
		{
			[Cpp2IlInjected.Token(Token = "0x6000A57")]
			[Cpp2IlInjected.Address(RVA = "0xAC5120", Offset = "0xAC3F20", VA = "0x180AC5120")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000A58")]
			[Cpp2IlInjected.Address(RVA = "0xAC0FB0", Offset = "0xABFDB0", VA = "0x180AC0FB0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000A59")]
		[Cpp2IlInjected.Address(RVA = "0x7A5BBE0", Offset = "0x7A5A9E0", VA = "0x187A5BBE0", Slot = "4")]
		public void DNRPRHFLPRB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000A5A")]
		[Cpp2IlInjected.Address(RVA = "0x7A5BC00", Offset = "0x7A5AA00", VA = "0x187A5BC00")]
		public GenerateConversationResponseRequestDTO()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000180")]
	[Utf8JsonSerializable]
	public class ToolCallDTO : IRecNetUtf8JsonObject
	{
		[Cpp2IlInjected.Token(Token = "0x1700042F")]
		public string Id
		{
			[Cpp2IlInjected.Token(Token = "0x6000A5B")]
			[Cpp2IlInjected.Address(RVA = "0xABD130", Offset = "0xABBF30", VA = "0x180ABD130")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000A5C")]
			[Cpp2IlInjected.Address(RVA = "0xABD120", Offset = "0xABBF20", VA = "0x180ABD120")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000430")]
		public string Name
		{
			[Cpp2IlInjected.Token(Token = "0x6000A5D")]
			[Cpp2IlInjected.Address(RVA = "0xAC0D20", Offset = "0xABFB20", VA = "0x180AC0D20")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000A5E")]
			[Cpp2IlInjected.Address(RVA = "0xAC0D10", Offset = "0xABFB10", VA = "0x180AC0D10")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000431")]
		public string Arguments
		{
			[Cpp2IlInjected.Token(Token = "0x6000A5F")]
			[Cpp2IlInjected.Address(RVA = "0xAC1D20", Offset = "0xAC0B20", VA = "0x180AC1D20")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000A60")]
			[Cpp2IlInjected.Address(RVA = "0xAC0640", Offset = "0xABF440", VA = "0x180AC0640")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000A61")]
		[Cpp2IlInjected.Address(RVA = "0xABE8D0", Offset = "0xABD6D0", VA = "0x180ABE8D0", Slot = "4")]
		public void DNRPRHFLPRB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000A62")]
		[Cpp2IlInjected.Address(RVA = "0xAC4840", Offset = "0xAC3640", VA = "0x180AC4840")]
		public ToolCallDTO()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000181")]
	[Utf8JsonSerializable]
	public class GenerateConversationResponseResponseDTO : IRecNetUtf8JsonObject
	{
		[Cpp2IlInjected.Token(Token = "0x17000432")]
		public List<string> TextItems
		{
			[Cpp2IlInjected.Token(Token = "0x6000A63")]
			[Cpp2IlInjected.Address(RVA = "0xABD130", Offset = "0xABBF30", VA = "0x180ABD130")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000A64")]
			[Cpp2IlInjected.Address(RVA = "0xABD120", Offset = "0xABBF20", VA = "0x180ABD120")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000433")]
		public List<ToolCallDTO>? ToolCalls
		{
			[Cpp2IlInjected.Token(Token = "0x6000A65")]
			[Cpp2IlInjected.Address(RVA = "0xAC0D20", Offset = "0xABFB20", VA = "0x180AC0D20")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000A66")]
			[Cpp2IlInjected.Address(RVA = "0xAC0D10", Offset = "0xABFB10", VA = "0x180AC0D10")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000A67")]
		[Cpp2IlInjected.Address(RVA = "0x7A5BC80", Offset = "0x7A5AA80", VA = "0x187A5BC80", Slot = "4")]
		public void DNRPRHFLPRB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000A68")]
		[Cpp2IlInjected.Address(RVA = "0xAC4840", Offset = "0xAC3640", VA = "0x180AC4840")]
		public GenerateConversationResponseResponseDTO()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000182")]
	[Utf8JsonSerializable]
	public class GenerateAudioOrSongResponseDTO : IRecNetUtf8JsonObject
	{
		[Cpp2IlInjected.Token(Token = "0x17000434")]
		public string Filename
		{
			[Cpp2IlInjected.Token(Token = "0x6000A69")]
			[Cpp2IlInjected.Address(RVA = "0xABD130", Offset = "0xABBF30", VA = "0x180ABD130")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000A6A")]
			[Cpp2IlInjected.Address(RVA = "0xABD120", Offset = "0xABBF20", VA = "0x180ABD120")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000A6B")]
		[Cpp2IlInjected.Address(RVA = "0xABE8D0", Offset = "0xABD6D0", VA = "0x180ABE8D0", Slot = "4")]
		public void DNRPRHFLPRB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000A6C")]
		[Cpp2IlInjected.Address(RVA = "0xAC4840", Offset = "0xAC3640", VA = "0x180AC4840")]
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
