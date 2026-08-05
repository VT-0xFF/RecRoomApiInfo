using System;
using System.Collections.Generic;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading.Tasks;
using Circuits.Static.Api;
using CodeStage.AntiCheat.ObscuredTypes;
using Cpp2IlInjected;
using JetBrains.Annotations;
using RRUI.Data;
using RRUI.Dialogs;
using RecRoom.Core.Creation.Inventions;
using RecRoom.Core.DataStructures;
using RecRoom.Creation;
using RecRoom.Foundation;
using RecRoom.Logging;
using RecRoom.Logging.Attributes;
using RecRoom.Maker.Core;
using RecRoom.Networking;
using RecRoom.Networking.DataTypes;
using RecRoom.Networking.SynchronizedFields;
using RecRoom.NoEngine.DataStructures;
using RecRoom.NoEngine.DataStructures.Tokens;
using RecRoom.ObjectModel;
using RecRoom.Protobuf;
using RecRoom.RendererV1;
using RecRoom.Tools;
using Unity.Profiling;
using UnityEngine;

[assembly: AssemblyVersion("0.0.0.0")]
namespace _LogRegistration.RecRoom_Maker_Runtime
{
	[Cpp2IlInjected.Token(Token = "0x2000002")]
	[CompilerGenerated]
	[Obfuscation(ApplyToMembers = false)]
	[Preserve]
	public class LogRegistrationIndex : RecRoom.Logging.LogRegistrationIndex
	{
		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(RVA = "0x878C6B0", Offset = "0x878B6B0", VA = "0x18878C6B0", Slot = "4")]
		public override void YTBQRMTMKZK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0xAF86F0", Offset = "0xAF76F0", VA = "0x180AF86F0")]
		public LogRegistrationIndex()
		{
		}
	}
}
namespace RecRoom.Creation
{
	[Cpp2IlInjected.Token(Token = "0x2000003")]
	public readonly struct OutlineRequest : IEquatable<OutlineRequest>
	{
		[Cpp2IlInjected.Token(Token = "0x2000004")]
		public class ZNTLUKUFYTC : SQRFHTVJNFN<OutlineRequest>
		{
			[Cpp2IlInjected.Token(Token = "0x17000001")]
			public bool TECFEJJOIIK
			{
				[Cpp2IlInjected.Token(Token = "0x6000009")]
				[Cpp2IlInjected.Address(RVA = "0x878D890", Offset = "0x878C890", VA = "0x18878D890")]
				get
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x600000A")]
			[Cpp2IlInjected.Address(RVA = "0x878D8D0", Offset = "0x878C8D0", VA = "0x18878D8D0")]
			public bool XKLEHVKDKRD(ObjectLocalId a)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600000B")]
			[Cpp2IlInjected.Address(RVA = "0x878D7D0", Offset = "0x878C7D0", VA = "0x18878D7D0")]
			public OutlineRequest QYVUUWSQRWL(ObjectLocalId a)
			{
				return default(OutlineRequest);
			}

			[Cpp2IlInjected.Token(Token = "0x600000C")]
			[Cpp2IlInjected.Address(RVA = "0x878D710", Offset = "0x878C710", VA = "0x18878D710")]
			private int KSZMTYWIJPE(ObjectLocalId a)
			{
				return default(int);
			}

			[Cpp2IlInjected.Token(Token = "0x600000D")]
			[Cpp2IlInjected.Address(RVA = "0x878D8F0", Offset = "0x878C8F0", VA = "0x18878D8F0")]
			public ZNTLUKUFYTC()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000005")]
		public enum RequestPriority
		{
			[Cpp2IlInjected.Token(Token = "0x4000006")]
			UgcGameplaySystem,
			[Cpp2IlInjected.Token(Token = "0x4000007")]
			ContentCreationTool,
			[Cpp2IlInjected.Token(Token = "0x4000008")]
			PlayerDirectInteraction,
			[Cpp2IlInjected.Token(Token = "0x4000009")]
			HackStandinPriorityToDistinguishNone
		}

		[Cpp2IlInjected.Token(Token = "0x2000006")]
		public enum RequestMode
		{
			[Cpp2IlInjected.Token(Token = "0x400000B")]
			TARGETED_OBJECT,
			[Cpp2IlInjected.Token(Token = "0x400000C")]
			ALL_UNDER_ROOT_CONNECTABLE,
			[Cpp2IlInjected.Token(Token = "0x400000D")]
			ALL_SNAP_POINT_GRAPH_OBJECTS
		}

		[Cpp2IlInjected.Token(Token = "0x4000001")]
		public static readonly OutlineRequest None;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000002")]
		public readonly RequestPriority Priority;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x4000003")]
		public readonly ObjectLocalId Requester;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
		[Cpp2IlInjected.Token(Token = "0x4000004")]
		public readonly RequestMode Mode;

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x878CE60", Offset = "0x878BE60", VA = "0x18878CE60")]
		public OutlineRequest(ObjectLocalId requester, RequestPriority priority = RequestPriority.UgcGameplaySystem, RequestMode mode = RequestMode.TARGETED_OBJECT)
		{
		}

		[SpecialName]
		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x878CDA0", Offset = "0x878BDA0", VA = "0x18878CDA0")]
		public static bool RZMMTPOVALZ(OutlineRequest a, OutlineRequest b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x878CC70", Offset = "0x878BC70", VA = "0x18878CC70", Slot = "4")]
		public bool Equals(OutlineRequest other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x878CBB0", Offset = "0x878BBB0", VA = "0x18878CBB0", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x878CD20", Offset = "0x878BD20", VA = "0x18878CD20", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000007")]
	public interface CYMUMEMOHVN
	{
		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(Slot = "0")]
		void RequestStartOutlining(OutlineRequest request);

		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(Slot = "1")]
		void RequestStopOutlining(ObjectLocalId requester, OutlineRequest.RequestMode mode);
	}
}
namespace RecRoom.Maker
{
	[Cpp2IlInjected.Token(Token = "0x2000008")]
	public abstract class YGVVTLNJMDN
	{
		[Cpp2IlInjected.Token(Token = "0x400000E")]
		public static BJQWATGADFY<Vector3> OGXMRTENWBT;

		[Cpp2IlInjected.Token(Token = "0x400000F")]
		public static BJQWATGADFY<Vector3> ZTMBNKZHSDK;

		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x878D5A0", Offset = "0x878C5A0", VA = "0x18878D5A0", Slot = "4")]
		protected virtual void ZNTYYJZDZWN(Vector3 a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0x878D510", Offset = "0x878C510", VA = "0x18878D510", Slot = "5")]
		protected virtual void JFSGJJADOFO(Vector3 a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0xAD4DA0", Offset = "0xAD3DA0", VA = "0x180AD4DA0")]
		protected YGVVTLNJMDN()
		{
		}
	}
}
namespace RecRoom.Maker.MarqueeHelper
{
	[Cpp2IlInjected.Token(Token = "0x2000009")]
	internal class BZGRXAYEGYL : YGVVTLNJMDN
	{
		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0x8788010", Offset = "0x8787010", VA = "0x188788010")]
		public void FMQNYSMJJVY(Vector3 a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0x8788040", Offset = "0x8787040", VA = "0x188788040")]
		public void LCLUTIUKQRB(Vector3 a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x8788070", Offset = "0x8787070", VA = "0x188788070")]
		public BZGRXAYEGYL()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000A")]
	public class DVEDULUSPID : IDisposable
	{
		[Cpp2IlInjected.Token(Token = "0x4000010")]
		private static ProfilerMarker GEXLJOZDHZO;

		[Cpp2IlInjected.Token(Token = "0x4000011")]
		private static ProfilerMarker FFEXVNYJIIG;

		[Cpp2IlInjected.Token(Token = "0x4000012")]
		private static readonly string ZOOUZWQPFOY;

		[Cpp2IlInjected.Token(Token = "0x4000013")]
		private static readonly string QAMVKLNIHAF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000014")]
		private readonly int[] RINMTASFVDE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000015")]
		private readonly int[] YDAXHJGWFRS;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000016")]
		private GameObject LOQVCNHDORE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000017")]
		private MeshCollider NWLTCTOOHHK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000018")]
		private GameObject TUCZNETMEGA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000019")]
		private MeshFilter BXXLKLFDWVK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400001A")]
		private Mesh LOQYCFKTNNV;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400001B")]
		private Mesh DBQFHNCSRWB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400001C")]
		private Plane[] NAZZJFGSVYS;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x400001D")]
		private Collider[] TIOHDTHZPIC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x400001E")]
		private List<ObjectLocalId> IWADSGBNKNF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x400001F")]
		private List<Collider> DJMVIAJRDDV;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x4000020")]
		private Vector3[] DWPOBBSTUDU;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x4000021")]
		private Vector3 KEQRIRFIGQC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x84")]
		[Cpp2IlInjected.Token(Token = "0x4000022")]
		private Vector3 VGEQKSYXUOJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x4000023")]
		private Quaternion YGVSMUKAHSP;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
		[Cpp2IlInjected.Token(Token = "0x4000024")]
		private Vector3[] NUPRAFAEVDG;

		[Cpp2IlInjected.Token(Token = "0x17000002")]
		private Mesh IWSOLWIFKYY
		{
			[Cpp2IlInjected.Token(Token = "0x6000017")]
			[Cpp2IlInjected.Address(RVA = "0xACFFA0", Offset = "0xACEFA0", VA = "0x180ACFFA0")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000018")]
			[Cpp2IlInjected.Address(RVA = "0x8788770", Offset = "0x8787770", VA = "0x188788770")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000003")]
		private Mesh IADSFKGGUVQ
		{
			[Cpp2IlInjected.Token(Token = "0x6000019")]
			[Cpp2IlInjected.Address(RVA = "0xAD6750", Offset = "0xAD5750", VA = "0x180AD6750")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600001A")]
			[Cpp2IlInjected.Address(RVA = "0x878AC90", Offset = "0x8789C90", VA = "0x18878AC90")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000004")]
		private int IZFYHJBLSZN
		{
			[Cpp2IlInjected.Token(Token = "0x600001B")]
			[Cpp2IlInjected.Address(RVA = "0x86C0010", Offset = "0x86BF010", VA = "0x1886C0010")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000005")]
		public IEnumerable<Collider> NIPWCGDWVPN
		{
			[Cpp2IlInjected.Token(Token = "0x6000020")]
			[Cpp2IlInjected.Address(RVA = "0x87890C0", Offset = "0x87880C0", VA = "0x1887890C0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(RVA = "0x878AE00", Offset = "0x8789E00", VA = "0x18878AE00")]
		public DVEDULUSPID(Material a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0x87890D0", Offset = "0x87880D0", VA = "0x1887890D0", Slot = "4")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x8789520", Offset = "0x8788520", VA = "0x188789520")]
		public void KJBNUTRRQNG(Vector2 a, Vector2 b, Camera c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x87894B0", Offset = "0x87884B0", VA = "0x1887894B0")]
		public void JJCCKQEKJEC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0x878A300", Offset = "0x8789300", VA = "0x18878A300")]
		private IEnumerable<Collider> VIGICAUWYYX()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(RVA = "0x8789260", Offset = "0x8788260", VA = "0x188789260")]
		public void EYLRQLDDCAM(List<ObjectLocalId> a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(RVA = "0x878A1C0", Offset = "0x87891C0", VA = "0x18878A1C0")]
		private void UEUXZAASEKK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000024")]
		[Cpp2IlInjected.Address(RVA = "0x878A910", Offset = "0x8789910", VA = "0x18878A910")]
		private void ZBHVRRREXIZ(Material a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(RVA = "0x8789D70", Offset = "0x8788D70", VA = "0x188789D70")]
		private void OEEAHKYCMDD(Vector2 a, Vector2 b, Camera c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(RVA = "0x87887C0", Offset = "0x87877C0", VA = "0x1887887C0")]
		private void AWIXGFIOGIO(Vector2 a, Vector2 b, Camera c, Vector2 d, Vector2 e, Vector3 f, Vector3 g, Vector3 h, Vector3 i)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(RVA = "0x87895F0", Offset = "0x87885F0", VA = "0x1887895F0")]
		private void LGGHNDKDJGN(Camera a, Vector3 b, Vector3 c, Vector3 d, Vector3 e, Vector3 f, Vector3 g)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(RVA = "0x878A150", Offset = "0x8789150", VA = "0x18878A150")]
		private void TLRSDVSZXJR()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(RVA = "0x878AA70", Offset = "0x8789A70", VA = "0x18878AA70")]
		private void ZITJZXXDMPO(Vector3 a, Vector3 b, Vector3 c, Vector3 d, Vector3 e)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002A")]
		[Cpp2IlInjected.Address(RVA = "0x87891C0", Offset = "0x87881C0", VA = "0x1887891C0")]
		private void ERXSWBPVGNT()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000B")]
	public class BWUGJPOBBMM<a>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000025")]
		private BYAHQUJZBFT<a> GUVIDVJKPOX;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000026")]
		private ZWMEKYBQURQ<a> FQEJPFXEPHU;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000027")]
		private List<a> ZZDMZDMQVBN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000028")]
		private List<a> BBGTVZDHCLI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000029")]
		private List<a> JEQWOOGWLVJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400002A")]
		private List<a> XPEUUXTTMOU;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400002B")]
		private List<a> XMNZHUSHFVY;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400002C")]
		private List<a> ZMSBZRHCMPX;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400002D")]
		private OngoingSelectionMode SJBPSONEQPI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400002E")]
		private BZGRXAYEGYL UURYYAWYNUN;

		[Cpp2IlInjected.Token(Token = "0x600002C")]
		[Cpp2IlInjected.Address(RVA = "0x40630B0", Offset = "0x40620B0", VA = "0x1840630B0")]
		public BWUGJPOBBMM(BYAHQUJZBFT<a> a, ZWMEKYBQURQ<a> b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002D")]
		[Cpp2IlInjected.Address(RVA = "0x4062F90", Offset = "0x4061F90", VA = "0x184062F90")]
		public void Start(OngoingSelectionMode mode = OngoingSelectionMode.Add)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(RVA = "0x4060B10", Offset = "0x405FB10", VA = "0x184060B10")]
		public void BOHGNXLWQAL(IEnumerable<Collider> a, List<a> b, Vector3 c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002F")]
		[Cpp2IlInjected.Address(RVA = "0x4063030", Offset = "0x4062030", VA = "0x184063030")]
		public bool XTNLJPCQZVI()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000030")]
		[Cpp2IlInjected.Address(RVA = "0x4062E90", Offset = "0x4061E90", VA = "0x184062E90")]
		[CompilerGenerated]
		private bool DNOIPLKWTWX(a a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000031")]
		[Cpp2IlInjected.Address(RVA = "0x4062DF0", Offset = "0x4061DF0", VA = "0x184062DF0")]
		[CompilerGenerated]
		private bool DNJBSEQZKLO(a a)
		{
			return default(bool);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000C")]
	public enum OngoingSelectionMode
	{
		[Cpp2IlInjected.Token(Token = "0x4000030")]
		Add,
		[Cpp2IlInjected.Token(Token = "0x4000031")]
		Remove
	}
}
namespace RecRoom.Core.Creation
{
	[Cpp2IlInjected.Token(Token = "0x200000D")]
	public class CZEKIJEXULS
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000032")]
		public readonly ShapeColor LRBYOOMORPK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x4000033")]
		public readonly ShapeMaterial RYWLXOHWOOI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000034")]
		public readonly float ICYUYVRKVEA;

		[Cpp2IlInjected.Token(Token = "0x17000006")]
		public bool ZRJXSFPYKWJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000033")]
			[Cpp2IlInjected.Address(RVA = "0x8788200", Offset = "0x8787200", VA = "0x188788200")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(RVA = "0x8788220", Offset = "0x8787220", VA = "0x188788220")]
		public CZEKIJEXULS(ShapeColor a, ShapeMaterial b, float c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(RVA = "0x87880C0", Offset = "0x87870C0", VA = "0x1887880C0", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(RVA = "0x8788170", Offset = "0x8787170", VA = "0x188788170", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000E")]
	public abstract class CreationOperationException : Exception, YLAKPIRTDEQ
	{
		[Cpp2IlInjected.Token(Token = "0x17000007")]
		public abstract string UserFriendlyErrorMessage
		{
			[Cpp2IlInjected.Token(Token = "0x6000036")]
			[Cpp2IlInjected.Address(Slot = "15")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(RVA = "0x8788720", Offset = "0x8787720", VA = "0x188788720")]
		protected CreationOperationException()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000F")]
	public class NonSuccessCreationResultException : CreationOperationException
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x4000035")]
		public readonly CreationResult CreationResult;

		[Cpp2IlInjected.FieldOffset(Offset = "0x94")]
		[Cpp2IlInjected.Token(Token = "0x4000036")]
		public readonly PlayerId RequestingPlayerActorNumber;

		[Cpp2IlInjected.Token(Token = "0x17000008")]
		public override string UserFriendlyErrorMessage
		{
			[Cpp2IlInjected.Token(Token = "0x6000039")]
			[Cpp2IlInjected.Address(RVA = "0x878CB80", Offset = "0x878BB80", VA = "0x18878CB80", Slot = "15")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000038")]
		[Cpp2IlInjected.Address(RVA = "0x878CAB0", Offset = "0x878BAB0", VA = "0x18878CAB0")]
		public NonSuccessCreationResultException(CreationResult creationResult, int requestingPlayerActorNumber)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000010")]
	public class UserFriendlyStringCreationException : CreationOperationException
	{
		[Cpp2IlInjected.Token(Token = "0x17000009")]
		public override string UserFriendlyErrorMessage
		{
			[Cpp2IlInjected.Token(Token = "0x600003A")]
			[Cpp2IlInjected.Address(RVA = "0xAFD970", Offset = "0xAFC970", VA = "0x180AFD970", Slot = "15")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600003B")]
		[Cpp2IlInjected.Address(RVA = "0x878D4A0", Offset = "0x878C4A0", VA = "0x18878D4A0")]
		public UserFriendlyStringCreationException(string userFacingString)
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000011")]
	public class ShapeSwatchInfo
	{
		[Serializable]
		[Cpp2IlInjected.Token(Token = "0x2000012")]
		public struct JsonShapeSwatch
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400003B")]
			public int c;

			[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
			[Cpp2IlInjected.Token(Token = "0x400003C")]
			public int m;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x400003D")]
			public float u;

			[Cpp2IlInjected.Token(Token = "0x6000044")]
			[Cpp2IlInjected.Address(RVA = "0x878C530", Offset = "0x878B530", VA = "0x18878C530")]
			public JsonShapeSwatch(ShapeSwatchInfo swatch)
			{
			}
		}

		[Serializable]
		[Cpp2IlInjected.Token(Token = "0x2000013")]
		public struct JsonShapeSwatches
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400003E")]
			public JsonShapeSwatch[] s;

			[Cpp2IlInjected.Token(Token = "0x6000045")]
			[Cpp2IlInjected.Address(RVA = "0x878C560", Offset = "0x878B560", VA = "0x18878C560")]
			public JsonShapeSwatches(ShapeSwatchInfo[] swatches)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000038")]
		public ShapeColor ShapeColorId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x4000039")]
		public ShapeMaterial ShapeMaterialId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400003A")]
		public float UVScale;

		[Cpp2IlInjected.Token(Token = "0x1700000A")]
		public static float DefaultUVScale
		{
			[Cpp2IlInjected.Token(Token = "0x600003C")]
			[Cpp2IlInjected.Address(RVA = "0xC8C1D0", Offset = "0xC8B1D0", VA = "0x180C8C1D0")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600003D")]
		[Cpp2IlInjected.Address(RVA = "0x878D190", Offset = "0x878C190", VA = "0x18878D190")]
		public ShapeSwatchInfo(ShapeColor colorId, ShapeMaterial materialId, float uvScale)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003E")]
		[Cpp2IlInjected.Address(RVA = "0x878D040", Offset = "0x878C040", VA = "0x18878D040")]
		public static ShapeSwatchInfo[] ZSBOLKPNYYQ(string a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600003F")]
		[Cpp2IlInjected.Address(RVA = "0x878CFD0", Offset = "0x878BFD0", VA = "0x18878CFD0")]
		public static string XGLCBUZQGAF(ShapeSwatchInfo[] a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000040")]
		[Cpp2IlInjected.Address(RVA = "0x878CE70", Offset = "0x878BE70", VA = "0x18878CE70")]
		public ShapeSwatchInfo Clone()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000041")]
		[Cpp2IlInjected.Address(RVA = "0x878CF80", Offset = "0x878BF80", VA = "0x18878CF80")]
		public bool VHJGLTZYSJY(ShapeSwatchInfo a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000042")]
		[Cpp2IlInjected.Address(RVA = "0x878CF40", Offset = "0x878BF40", VA = "0x18878CF40")]
		public bool VHJGLTZYSJY(ShapeMaterial a, ShapeColor b, float c)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000043")]
		[Cpp2IlInjected.Address(RVA = "0x878CF00", Offset = "0x878BF00", VA = "0x18878CF00")]
		public bool LXFPFJKFLZE()
		{
			return default(bool);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000016")]
	public class ConfigurableSubpiece : MonoBehaviour
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000043")]
		[SerializeField]
		private Collider[] colliders;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000044")]
		[SerializeField]
		private Renderer[] hoverRenderers;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000045")]
		public BJGIGFSFKJG<ConfigurableSubpiece, Collider[], Collider[]> OnCollidersChanged;

		[Cpp2IlInjected.Token(Token = "0x1700000B")]
		public IRSACJXRJFT AJTCQUWZKUA
		{
			[Cpp2IlInjected.Token(Token = "0x600004C")]
			[Cpp2IlInjected.Address(RVA = "0xACFF60", Offset = "0xACEF60", VA = "0x180ACFF60")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600004D")]
			[Cpp2IlInjected.Address(RVA = "0xAD8F70", Offset = "0xAD7F70", VA = "0x180AD8F70")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000C")]
		public Collider[] CUXIYRHXDNA
		{
			[Cpp2IlInjected.Token(Token = "0x600004E")]
			[Cpp2IlInjected.Address(RVA = "0xAD0670", Offset = "0xACF670", VA = "0x180AD0670")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000D")]
		public Renderer[] WYYDONRWTVF
		{
			[Cpp2IlInjected.Token(Token = "0x600004F")]
			[Cpp2IlInjected.Address(RVA = "0xACFF90", Offset = "0xACEF90", VA = "0x180ACFF90")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000001")]
		public event Action<IRSACJXRJFT> NHTIJOVZUNJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000050")]
			[Cpp2IlInjected.Address(RVA = "0x87885C0", Offset = "0x87875C0", VA = "0x1887885C0")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000051")]
			[Cpp2IlInjected.Address(RVA = "0x8788670", Offset = "0x8787670", VA = "0x188788670")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000052")]
		[Cpp2IlInjected.Address(RVA = "0x8788280", Offset = "0x8787280", VA = "0x188788280")]
		private void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000053")]
		[Cpp2IlInjected.Address(RVA = "0x8788330", Offset = "0x8787330", VA = "0x188788330")]
		public void Destroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000054")]
		[Cpp2IlInjected.Address(RVA = "0x8788380", Offset = "0x8787380", VA = "0x188788380")]
		public void SetIConfigurable(IRSACJXRJFT newConfigurable)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000055")]
		[Cpp2IlInjected.Address(RVA = "0x8788290", Offset = "0x8787290", VA = "0x188788290")]
		public void ChangeCollidersAndRenderers(Collider[] newColliders, Renderer[] newRenderers)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000056")]
		[Cpp2IlInjected.Address(RVA = "0x87884B0", Offset = "0x87874B0", VA = "0x1887884B0")]
		public void ValidateCollidersAndRenderers()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000057")]
		[Cpp2IlInjected.Address(RVA = "0x5E3B6C0", Offset = "0x5E3A6C0", VA = "0x185E3B6C0")]
		public void RunConfigurationSpecialActions(IRSACJXRJFT configurable)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000058")]
		[Cpp2IlInjected.Address(RVA = "0x8788540", Offset = "0x8787540", VA = "0x188788540")]
		public ConfigurableSubpiece()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000017")]
	public interface EOYLESHCQGV
	{
		[Cpp2IlInjected.Token(Token = "0x1700000E")]
		bool RJSURIWZRRK
		{
			[Cpp2IlInjected.Token(Token = "0x6000059")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x600005A")]
		[Cpp2IlInjected.Address(Slot = "1")]
		void AddIsAnimated(object token);

		[Cpp2IlInjected.Token(Token = "0x600005B")]
		[Cpp2IlInjected.Address(Slot = "2")]
		void RemoveIsAnimated(object token);
	}
	[Cpp2IlInjected.Token(Token = "0x2000018")]
	public interface JVWMKGSIWVY
	{
		[Cpp2IlInjected.Token(Token = "0x600005C")]
		[Cpp2IlInjected.Address(Slot = "0")]
		IEnumerable<CZEKIJEXULS> GetColorableSnapshots();
	}
	[Cpp2IlInjected.Token(Token = "0x2000019")]
	public interface KUBEOLHLBOS
	{
		[Cpp2IlInjected.Token(Token = "0x600005D")]
		[Cpp2IlInjected.Address(Slot = "0")]
		void RegisterConfigurablePiece(ConfigurableSubpiece subPiece);

		[Cpp2IlInjected.Token(Token = "0x600005E")]
		[Cpp2IlInjected.Address(Slot = "1")]
		void UnregisterConfigurablePiece(ConfigurableSubpiece subPiece);

		[Cpp2IlInjected.Token(Token = "0x600005F")]
		[Cpp2IlInjected.Address(Slot = "2")]
		ConfigurableSubpiece GetConfigurableSubpiece(Collider collider);
	}
	[Cpp2IlInjected.Token(Token = "0x200001A")]
	public interface QTJRLIFGYVX
	{
		[Cpp2IlInjected.Token(Token = "0x1700000F")]
		GameObject NFQJYDXAFZS
		{
			[Cpp2IlInjected.Token(Token = "0x6000062")]
			[Cpp2IlInjected.Address(Slot = "2")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000010")]
		Guid OAGTPWISQKM
		{
			[Cpp2IlInjected.Token(Token = "0x6000063")]
			[Cpp2IlInjected.Address(Slot = "3")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000011")]
		string LQPFQGKUSJI
		{
			[Cpp2IlInjected.Token(Token = "0x6000064")]
			[Cpp2IlInjected.Address(Slot = "4")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000012")]
		string Title
		{
			[Cpp2IlInjected.Token(Token = "0x6000065")]
			[Cpp2IlInjected.Address(Slot = "5")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000013")]
		Vector3 ABOALKNYRTC
		{
			[Cpp2IlInjected.Token(Token = "0x6000066")]
			[Cpp2IlInjected.Address(Slot = "6")]
			get;
			[Cpp2IlInjected.Token(Token = "0x6000067")]
			[Cpp2IlInjected.Address(Slot = "7")]
			set;
		}

		[Cpp2IlInjected.Token(Token = "0x17000014")]
		Vector3 FZEZTVXHVQL
		{
			[Cpp2IlInjected.Token(Token = "0x6000068")]
			[Cpp2IlInjected.Address(Slot = "8")]
			get;
			[Cpp2IlInjected.Token(Token = "0x6000069")]
			[Cpp2IlInjected.Address(Slot = "9")]
			set;
		}

		[Cpp2IlInjected.Token(Token = "0x17000015")]
		Quaternion COGJZYLHQKN
		{
			[Cpp2IlInjected.Token(Token = "0x600006A")]
			[Cpp2IlInjected.Address(Slot = "10")]
			get;
			[Cpp2IlInjected.Token(Token = "0x600006B")]
			[Cpp2IlInjected.Address(Slot = "11")]
			set;
		}

		[Cpp2IlInjected.Token(Token = "0x17000016")]
		Quaternion UNSWVSOJZIW
		{
			[Cpp2IlInjected.Token(Token = "0x600006C")]
			[Cpp2IlInjected.Address(Slot = "12")]
			get;
			[Cpp2IlInjected.Token(Token = "0x600006D")]
			[Cpp2IlInjected.Address(Slot = "13")]
			set;
		}

		[Cpp2IlInjected.Token(Token = "0x17000017")]
		float ZKIWDAFNCXP
		{
			[Cpp2IlInjected.Token(Token = "0x600006E")]
			[Cpp2IlInjected.Address(Slot = "14")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000018")]
		float QGZFXJVAJIS
		{
			[Cpp2IlInjected.Token(Token = "0x600006F")]
			[Cpp2IlInjected.Address(Slot = "15")]
			get;
			[Cpp2IlInjected.Token(Token = "0x6000070")]
			[Cpp2IlInjected.Address(Slot = "16")]
			set;
		}

		[Cpp2IlInjected.Token(Token = "0x17000019")]
		Vector3 SGDLQWFUYHF
		{
			[Cpp2IlInjected.Token(Token = "0x6000071")]
			[Cpp2IlInjected.Address(Slot = "17")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x1700001A")]
		Vector3 LPQDASAFPUQ
		{
			[Cpp2IlInjected.Token(Token = "0x6000072")]
			[Cpp2IlInjected.Address(Slot = "18")]
			get;
			[Cpp2IlInjected.Token(Token = "0x6000073")]
			[Cpp2IlInjected.Address(Slot = "19")]
			set;
		}

		[Cpp2IlInjected.Token(Token = "0x1700001B")]
		bool RVTZFRRNGSD
		{
			[Cpp2IlInjected.Token(Token = "0x6000074")]
			[Cpp2IlInjected.Address(Slot = "20")]
			set;
		}

		[Cpp2IlInjected.Token(Token = "0x1700001C")]
		IRSACJXRJFT AJTCQUWZKUA
		{
			[Cpp2IlInjected.Token(Token = "0x6000075")]
			[Cpp2IlInjected.Address(Slot = "21")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x1700001D")]
		[CanBeNull]
		NJABIEFNXEV EOKFJZVDPUW
		{
			[Cpp2IlInjected.Token(Token = "0x6000076")]
			[Cpp2IlInjected.Address(Slot = "22")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x14000002")]
		event Action WTHEAZKQUJO;

		[Cpp2IlInjected.Token(Token = "0x6000077")]
		[Cpp2IlInjected.Address(Slot = "23")]
		bool CanUpdateDeformation(Vector3 deformationDirection, float deformationFactor, float minAxisScale, Space relativeTo);

		[Cpp2IlInjected.Token(Token = "0x6000078")]
		[Cpp2IlInjected.Address(Slot = "24")]
		void UpdateDeformation(Vector3 deformationDirection, float deformationFactor, bool scalingAlongFixedAxis, Space relativeTo);

		[Cpp2IlInjected.Token(Token = "0x6000079")]
		[Cpp2IlInjected.Address(Slot = "25")]
		bool CanBeRaycasted(Collider collider);
	}
	[Cpp2IlInjected.Token(Token = "0x200001B")]
	public interface ALMOYXZNYOM
	{
		[Cpp2IlInjected.Token(Token = "0x1700001E")]
		bool WYEJQGSIVLQ
		{
			[Cpp2IlInjected.Token(Token = "0x600008D")]
			[Cpp2IlInjected.Address(Slot = "19")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x1700001F")]
		bool IJEXKGVBVVR
		{
			[Cpp2IlInjected.Token(Token = "0x600008E")]
			[Cpp2IlInjected.Address(Slot = "20")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000020")]
		Vector3 AOEVUIFPOUK
		{
			[Cpp2IlInjected.Token(Token = "0x600008F")]
			[Cpp2IlInjected.Address(Slot = "21")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000021")]
		Vector3 WTMFGZZXMCI
		{
			[Cpp2IlInjected.Token(Token = "0x6000090")]
			[Cpp2IlInjected.Address(Slot = "22")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000022")]
		bool BQQYECEHBVO
		{
			[Cpp2IlInjected.Token(Token = "0x6000091")]
			[Cpp2IlInjected.Address(Slot = "23")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000023")]
		bool YMIAAZUQNRT
		{
			[Cpp2IlInjected.Token(Token = "0x6000092")]
			[Cpp2IlInjected.Address(Slot = "24")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000024")]
		bool PCQCUCFCHHM
		{
			[Cpp2IlInjected.Token(Token = "0x6000093")]
			[Cpp2IlInjected.Address(Slot = "25")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000025")]
		bool QSZTPCYQLFD
		{
			[Cpp2IlInjected.Token(Token = "0x6000094")]
			[Cpp2IlInjected.Address(Slot = "26")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000026")]
		bool GIUDZCGWPCA
		{
			[Cpp2IlInjected.Token(Token = "0x6000095")]
			[Cpp2IlInjected.Address(Slot = "27")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000027")]
		bool RAYKIIMGVHI
		{
			[Cpp2IlInjected.Token(Token = "0x6000096")]
			[Cpp2IlInjected.Address(Slot = "28")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000028")]
		bool MEDJCXYFZJD
		{
			[Cpp2IlInjected.Token(Token = "0x6000097")]
			[Cpp2IlInjected.Address(Slot = "29")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000029")]
		bool KDLFMIKYICI
		{
			[Cpp2IlInjected.Token(Token = "0x6000098")]
			[Cpp2IlInjected.Address(Slot = "30")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x1700002A")]
		bool KYRMRJQIOAI
		{
			[Cpp2IlInjected.Token(Token = "0x6000099")]
			[Cpp2IlInjected.Address(Slot = "31")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x600007A")]
		[Cpp2IlInjected.Address(Slot = "0")]
		void OnCreatedBySpawning();

		[Cpp2IlInjected.Token(Token = "0x600007B")]
		[Cpp2IlInjected.Address(Slot = "1")]
		void OnCreatedFromTemplate();

		[Cpp2IlInjected.Token(Token = "0x600007C")]
		[Cpp2IlInjected.Address(Slot = "2")]
		void OnSelected();

		[Cpp2IlInjected.Token(Token = "0x600007D")]
		[Cpp2IlInjected.Address(Slot = "3")]
		void OnTranslationStart();

		[Cpp2IlInjected.Token(Token = "0x600007E")]
		[Cpp2IlInjected.Address(Slot = "4")]
		void OnRotationStart();

		[Cpp2IlInjected.Token(Token = "0x600007F")]
		[Cpp2IlInjected.Address(Slot = "5")]
		void OnScaleStart();

		[Cpp2IlInjected.Token(Token = "0x6000080")]
		[Cpp2IlInjected.Address(Slot = "6")]
		void OnDeformStart();

		[Cpp2IlInjected.Token(Token = "0x6000081")]
		[Cpp2IlInjected.Address(Slot = "7")]
		void OnTranslated();

		[Cpp2IlInjected.Token(Token = "0x6000082")]
		[Cpp2IlInjected.Address(Slot = "8")]
		void OnRotated();

		[Cpp2IlInjected.Token(Token = "0x6000083")]
		[Cpp2IlInjected.Address(Slot = "9")]
		void OnScaled();

		[Cpp2IlInjected.Token(Token = "0x6000084")]
		[Cpp2IlInjected.Address(Slot = "10")]
		void OnDeformed(Vector3 previousPosition);

		[Cpp2IlInjected.Token(Token = "0x6000085")]
		[Cpp2IlInjected.Address(Slot = "11")]
		void OnTranslationFinished();

		[Cpp2IlInjected.Token(Token = "0x6000086")]
		[Cpp2IlInjected.Address(Slot = "12")]
		void OnRotationFinished();

		[Cpp2IlInjected.Token(Token = "0x6000087")]
		[Cpp2IlInjected.Address(Slot = "13")]
		void OnScaleFinished();

		[Cpp2IlInjected.Token(Token = "0x6000088")]
		[Cpp2IlInjected.Address(Slot = "14")]
		void OnDeformationFinished();

		[Cpp2IlInjected.Token(Token = "0x6000089")]
		[Cpp2IlInjected.Address(Slot = "15")]
		void OnDeselected();

		[Cpp2IlInjected.Token(Token = "0x600008A")]
		[Cpp2IlInjected.Address(Slot = "16")]
		void OnHoverStart(ToolMode toolMode, Collider hitCollider, OutlineRequest outlineRequest);

		[Cpp2IlInjected.Token(Token = "0x600008B")]
		[Cpp2IlInjected.Address(Slot = "17")]
		void OnHovering(ToolMode toolMode, Collider hitCollider);

		[Cpp2IlInjected.Token(Token = "0x600008C")]
		[Cpp2IlInjected.Address(Slot = "18")]
		void OnHoverFinished(ToolMode toolMode, ObjectLocalId outlineRequester, OutlineRequest.RequestMode requestMode);

		[Cpp2IlInjected.Token(Token = "0x600009A")]
		[Cpp2IlInjected.Address(Slot = "32")]
		void Translate(Vector3 displacementWorldSpace);

		[Cpp2IlInjected.Token(Token = "0x600009B")]
		[Cpp2IlInjected.Address(Slot = "33")]
		void Rotate(Quaternion angularDisplacementWorldSpace);

		[Cpp2IlInjected.Token(Token = "0x600009C")]
		[Cpp2IlInjected.Address(Slot = "34")]
		bool Scale(float scaleFactor);

		[Cpp2IlInjected.Token(Token = "0x600009D")]
		[Cpp2IlInjected.Address(Slot = "35")]
		Task DeleteAsync();
	}
	[Cpp2IlInjected.Token(Token = "0x200001C")]
	public interface JGMFCYSUALU
	{
		[Cpp2IlInjected.Token(Token = "0x600009E")]
		[Cpp2IlInjected.Address(Slot = "0")]
		bool XRDMQRMUFDR([In] Vector3 origin, [In] Vector3 direction, Vector3 a, Vector3 b);
	}
	[Cpp2IlInjected.Token(Token = "0x200001D")]
	public interface BAWAKVRWXND
	{
		[Cpp2IlInjected.Token(Token = "0x1700002B")]
		bool DCDSPFHYYIQ
		{
			[Cpp2IlInjected.Token(Token = "0x600009F")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x1700002C")]
		VOFSXJFIEEZ FXJGALCQAHH
		{
			[Cpp2IlInjected.Token(Token = "0x60000A1")]
			[Cpp2IlInjected.Address(Slot = "2")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x60000A0")]
		[Cpp2IlInjected.Address(Slot = "1")]
		Task RequestMasterDespawn();
	}
	[Cpp2IlInjected.Token(Token = "0x200001E")]
	public interface GECRNRYZRQD
	{
		[Cpp2IlInjected.Token(Token = "0x1700002D")]
		bool GTCWHJWHXNY
		{
			[Cpp2IlInjected.Token(Token = "0x60000A4")]
			[Cpp2IlInjected.Address(Slot = "2")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x1700002E")]
		CQGZITPROPE GVDDIBPSGRK
		{
			[Cpp2IlInjected.Token(Token = "0x60000A5")]
			[Cpp2IlInjected.Address(Slot = "3")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x14000003")]
		event Action<bool> GLVUCBXFBZR;

		[Cpp2IlInjected.Token(Token = "0x60000A6")]
		[Cpp2IlInjected.Address(Slot = "4")]
		void LocalPlayerTakeAuthority();

		[Cpp2IlInjected.Token(Token = "0x60000A7")]
		[Cpp2IlInjected.Address(Slot = "5")]
		void TransferOwnership(int actorNumber);

		[Cpp2IlInjected.Token(Token = "0x60000A8")]
		[Cpp2IlInjected.Address(Slot = "6")]
		XLYBIIWOHJI GetCulprit(CreationResult failureReason);
	}
	[Cpp2IlInjected.Token(Token = "0x200001F")]
	public interface FKZHOAARGEN
	{
		[Cpp2IlInjected.Token(Token = "0x1700002F")]
		IEnumerable<NavMeshSupport.Restriction> YQZJDTLJNUZ
		{
			[Cpp2IlInjected.Token(Token = "0x60000A9")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x60000AA")]
		[Cpp2IlInjected.Address(Slot = "1")]
		void AddNavMeshSupportRestriction(NavMeshSupport.Restriction restriction);

		[Cpp2IlInjected.Token(Token = "0x60000AB")]
		[Cpp2IlInjected.Address(Slot = "2")]
		void RemoveNavMeshSupportRestriction(NavMeshSupport.Restriction restriction);
	}
	[Cpp2IlInjected.Token(Token = "0x2000020")]
	public interface HWEHDDVUWQW
	{
		[Cpp2IlInjected.Token(Token = "0x60000AC")]
		[Cpp2IlInjected.Address(Slot = "0")]
		void Reset();

		[Cpp2IlInjected.Token(Token = "0x60000AD")]
		[Cpp2IlInjected.Address(Slot = "1")]
		void RequestRPCReset();
	}
	[Cpp2IlInjected.Token(Token = "0x2000021")]
	public interface XSHWNRDOCYK
	{
		[Cpp2IlInjected.Token(Token = "0x17000030")]
		bool LLPANJXLETZ
		{
			[Cpp2IlInjected.Token(Token = "0x60000AE")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000031")]
		bool TEKGPQJMUGQ
		{
			[Cpp2IlInjected.Token(Token = "0x60000AF")]
			[Cpp2IlInjected.Address(Slot = "1")]
			get;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000022")]
	public interface HHZYJJMAKAT
	{
		[Cpp2IlInjected.Token(Token = "0x17000032")]
		int WXOBFWSGWCB
		{
			[Cpp2IlInjected.Token(Token = "0x60000B0")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x60000B1")]
		[Cpp2IlInjected.Address(Slot = "1")]
		void RenderSelection(SelectionEffectType? selectionEffectType);

		[Cpp2IlInjected.Token(Token = "0x60000B2")]
		[Cpp2IlInjected.Address(Slot = "2")]
		void RenderOutline(OutlineEffectType? outlineType);

		[Cpp2IlInjected.Token(Token = "0x60000B3")]
		[Cpp2IlInjected.Address(Slot = "3")]
		void RenderWorldFadeMask();

		[Cpp2IlInjected.Token(Token = "0x60000B4")]
		[Cpp2IlInjected.Address(Slot = "4")]
		Bounds GetWorldBounds();

		[Cpp2IlInjected.Token(Token = "0x60000B5")]
		[Cpp2IlInjected.Address(Slot = "5")]
		CreationResult CanBeSelected();
	}
	[Cpp2IlInjected.Token(Token = "0x2000023")]
	public interface QQEXOAZMEIQ
	{
		[Cpp2IlInjected.Token(Token = "0x17000033")]
		bool SSNGYYMBQUG
		{
			[Cpp2IlInjected.Token(Token = "0x60000B6")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
			[Cpp2IlInjected.Token(Token = "0x60000B7")]
			[Cpp2IlInjected.Address(Slot = "1")]
			set;
		}

		[Cpp2IlInjected.Token(Token = "0x17000034")]
		CanSaveObjectIntoInventionResultType TVKTITPBXDL
		{
			[Cpp2IlInjected.Token(Token = "0x60000B9")]
			[Cpp2IlInjected.Address(Slot = "3")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000035")]
		bool GKGTCIHVGRO
		{
			[Cpp2IlInjected.Token(Token = "0x60000BA")]
			[Cpp2IlInjected.Address(Slot = "4")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000036")]
		bool XFIFDGKKDXT
		{
			[Cpp2IlInjected.Token(Token = "0x60000BB")]
			[Cpp2IlInjected.Address(Slot = "5")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000037")]
		bool VLKTTCKVEXR
		{
			[Cpp2IlInjected.Token(Token = "0x60000BC")]
			[Cpp2IlInjected.Address(Slot = "6")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000038")]
		bool WYQLMHWBXZC
		{
			[Cpp2IlInjected.Token(Token = "0x60000BD")]
			[Cpp2IlInjected.Address(Slot = "7")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000039")]
		bool HEQKWQGRIFB
		{
			[Cpp2IlInjected.Token(Token = "0x60000BE")]
			[Cpp2IlInjected.Address(Slot = "8")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x1700003A")]
		IEnumerable<Collider> RXHPFQPQZYK
		{
			[Cpp2IlInjected.Token(Token = "0x60000BF")]
			[Cpp2IlInjected.Address(Slot = "9")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x1700003B")]
		RotatedBounds? MLBDWBROXVO
		{
			[Cpp2IlInjected.Token(Token = "0x60000C0")]
			[Cpp2IlInjected.Address(Slot = "10")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x1700003C")]
		bool PNTVERJLAMO
		{
			[Cpp2IlInjected.Token(Token = "0x60000C1")]
			[Cpp2IlInjected.Address(Slot = "11")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x1700003D")]
		bool HISTOTHBMFS
		{
			[Cpp2IlInjected.Token(Token = "0x60000C2")]
			[Cpp2IlInjected.Address(Slot = "12")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x60000B8")]
		[Cpp2IlInjected.Address(Slot = "2")]
		CostInfo GetSandboxResourceCost(bool verifyIntegrity = true);
	}
	[Cpp2IlInjected.Token(Token = "0x2000024")]
	public interface TRNAELAWRAR
	{
		[Cpp2IlInjected.Token(Token = "0x60000C3")]
		[Cpp2IlInjected.Address(Slot = "0")]
		CreationResult CanPerformUndoRedoOnObject();

		[Cpp2IlInjected.Token(Token = "0x60000C4")]
		[Cpp2IlInjected.Address(Slot = "1")]
		void GetTransformationDataForUndoRedo([Out] Vector3 position, [Out] Quaternion rotation, [Out] float uniformScale, [Out] Vector3 deformationScale);

		[Cpp2IlInjected.Token(Token = "0x60000C5")]
		[Cpp2IlInjected.Address(Slot = "2")]
		void SetTransformationDataForUndoRedo(Vector3? position, Quaternion? rotation, float? uniformScale, Vector3? deformationScale);
	}
	[Cpp2IlInjected.Token(Token = "0x2000025")]
	public interface JDVRWOSODJC
	{
		[Cpp2IlInjected.Token(Token = "0x1700003E")]
		object YCJSTULHATX
		{
			[Cpp2IlInjected.Token(Token = "0x60000C6")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x1700003F")]
		Type ERQBXYJELSO
		{
			[Cpp2IlInjected.Token(Token = "0x60000C7")]
			[Cpp2IlInjected.Address(Slot = "1")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000040")]
		Guid RUPXZIANFKG
		{
			[Cpp2IlInjected.Token(Token = "0x60000C8")]
			[Cpp2IlInjected.Address(Slot = "2")]
			get;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000026")]
	public interface IRSACJXRJFT
	{
		[Cpp2IlInjected.Token(Token = "0x17000041")]
		IReadOnlyList<IDynamicUIElementData> DynamicUIElements
		{
			[Cpp2IlInjected.Token(Token = "0x60000D1")]
			[Cpp2IlInjected.Address(Slot = "8")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000042")]
		string Title
		{
			[Cpp2IlInjected.Token(Token = "0x60000D2")]
			[Cpp2IlInjected.Address(Slot = "9")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000043")]
		string Subtitle
		{
			[Cpp2IlInjected.Token(Token = "0x60000D3")]
			[Cpp2IlInjected.Address(Slot = "10")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000044")]
		bool IsValid
		{
			[Cpp2IlInjected.Token(Token = "0x60000D4")]
			[Cpp2IlInjected.Address(Slot = "11")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x14000004")]
		event Action<string> CZEDYHDQEHM;

		[Cpp2IlInjected.Token(Token = "0x14000005")]
		event Action<IRSACJXRJFT> RGFMEWEZGLN;

		[Cpp2IlInjected.Token(Token = "0x14000006")]
		event Action<DialogType, WDDBBCNSQPO> UISQLTFFFPW;

		[Cpp2IlInjected.Token(Token = "0x14000007")]
		event Action DRBNAJVUSSH;

		[Cpp2IlInjected.Token(Token = "0x60000D5")]
		[Cpp2IlInjected.Address(Slot = "12")]
		void Reset();

		[Cpp2IlInjected.Token(Token = "0x60000D6")]
		[Cpp2IlInjected.Address(Slot = "13")]
		void ConfigurableWillShow();

		[Cpp2IlInjected.Token(Token = "0x60000D7")]
		[Cpp2IlInjected.Address(Slot = "14")]
		void ConfigurableWillHide();
	}
	[Cpp2IlInjected.Token(Token = "0x2000027")]
	public interface QVODXZVSUJB
	{
		[Cpp2IlInjected.Token(Token = "0x14000008")]
		event Action NMFKRMHFVCX;
	}
	[Cpp2IlInjected.Token(Token = "0x2000028")]
	public interface QLOVZBJGNOY : IRSACJXRJFT, LRNHLHNGVSE
	{
		[Cpp2IlInjected.Token(Token = "0x17000045")]
		IEnumerable<LRNHLHNGVSE> QFVTOIWMLSP
		{
			[Cpp2IlInjected.Token(Token = "0x60000DB")]
			[Cpp2IlInjected.Address(Slot = "1")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x60000DA")]
		[Cpp2IlInjected.Address(Slot = "0")]
		void RegisterConfigurableAddOn(LRNHLHNGVSE newSubConfigurable);
	}
	[Cpp2IlInjected.Token(Token = "0x2000029")]
	public interface LRNHLHNGVSE
	{
		[Cpp2IlInjected.Token(Token = "0x60000DC")]
		[Cpp2IlInjected.Address(Slot = "0")]
		IReadOnlyList<IDynamicUIElementData> GetConfigurableDynamicUI([Optional] IEnumerable<LRNHLHNGVSE> configurables);
	}
	[Cpp2IlInjected.Token(Token = "0x200002A")]
	public interface RPOBEHNSHJS
	{
		[Cpp2IlInjected.Token(Token = "0x17000046")]
		bool PSURHLXQVUT
		{
			[Cpp2IlInjected.Token(Token = "0x60000DD")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
			[Cpp2IlInjected.Token(Token = "0x60000DE")]
			[Cpp2IlInjected.Address(Slot = "1")]
			set;
		}

		[Cpp2IlInjected.Token(Token = "0x17000047")]
		bool TLEJJSAOXEY
		{
			[Cpp2IlInjected.Token(Token = "0x60000DF")]
			[Cpp2IlInjected.Address(Slot = "2")]
			get;
			[Cpp2IlInjected.Token(Token = "0x60000E0")]
			[Cpp2IlInjected.Address(Slot = "3")]
			set;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200002B")]
	public struct NavMeshSupport
	{
		[Cpp2IlInjected.Token(Token = "0x200002C")]
		public delegate NavMeshSupportStatus Restriction();

		[Cpp2IlInjected.Token(Token = "0x4000048")]
		private static readonly IEnumerable<Restriction> NoRestrictions;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000049")]
		private List<Restriction> restrictions;

		[Cpp2IlInjected.Token(Token = "0x17000048")]
		public IEnumerable<Restriction> JCATGHCUBRA
		{
			[Cpp2IlInjected.Token(Token = "0x60000E1")]
			[Cpp2IlInjected.Address(RVA = "0x878C930", Offset = "0x878B930", VA = "0x18878C930")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000E2")]
		[Cpp2IlInjected.Address(RVA = "0x878C730", Offset = "0x878B730", VA = "0x18878C730")]
		public void Add(Restriction restriction)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E3")]
		[Cpp2IlInjected.Address(RVA = "0x878C990", Offset = "0x878B990", VA = "0x18878C990")]
		public bool Remove(Restriction restriction)
		{
			return default(bool);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200002D")]
	public enum NavMeshSupportStatus
	{
		[Cpp2IlInjected.Token(Token = "0x400004B")]
		NotSupported,
		[Cpp2IlInjected.Token(Token = "0x400004C")]
		Supported
	}
}
namespace RecRoom.Core.Creation.Inventions
{
	[Cpp2IlInjected.Token(Token = "0x200002E")]
	public readonly struct TrialInventionInfo : JPXEKQKFEWW
	{
		[Cpp2IlInjected.Token(Token = "0x17000049")]
		public int SpawningPlayerId
		{
			[Cpp2IlInjected.Token(Token = "0x60000E7")]
			[Cpp2IlInjected.Address(RVA = "0xDCFD90", Offset = "0xDCED90", VA = "0x180DCFD90", Slot = "5")]
			[CompilerGenerated]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700004A")]
		public int TrialSpawnTime
		{
			[Cpp2IlInjected.Token(Token = "0x60000E8")]
			[Cpp2IlInjected.Address(RVA = "0x30BACC0", Offset = "0x30B9CC0", VA = "0x1830BACC0", Slot = "4")]
			[CompilerGenerated]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000E9")]
		[Cpp2IlInjected.Address(RVA = "0x878D1E0", Offset = "0x878C1E0", VA = "0x18878D1E0")]
		public TrialInventionInfo(int trialSpawnTime, int spawningPlayerId)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200002F")]
	public interface AVVXNMEDRZL : WWWOITQCHIY
	{
		[Cpp2IlInjected.Token(Token = "0x400004F")]
		static readonly int SGCQFWRDCIG;

		[Cpp2IlInjected.Token(Token = "0x4000050")]
		static readonly Guid RDCUXIDDCFB;

		[Cpp2IlInjected.Token(Token = "0x1700004B")]
		Guid ZOECLIKSSGP
		{
			[Cpp2IlInjected.Token(Token = "0x60000EA")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x1700004C")]
		long CLKKOSOFEGA
		{
			[Cpp2IlInjected.Token(Token = "0x60000EB")]
			[Cpp2IlInjected.Address(Slot = "1")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x1700004D")]
		[Obsolete("This is not used - version tracking is done at the server level as collections of InventionId")]
		int NHOIMXYLPAW
		{
			[Cpp2IlInjected.Token(Token = "0x60000EC")]
			[Cpp2IlInjected.Address(Slot = "2")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x60000ED")]
		[Cpp2IlInjected.Address(RVA = "0x8787FA0", Offset = "0x8786FA0", VA = "0x188787FA0")]
		static AVVXNMEDRZL()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000030")]
	[Obsolete("This is not used by anything and does not give us full provenance tracking")]
	public interface OVNGPAWQSZT
	{
		[Cpp2IlInjected.Token(Token = "0x1700004E")]
		[Obsolete("This is not currently consumed and does not give us full provenance tracking, however it does contain information that may prevent 'contamination' of invention contents by other non-monetizable inventions")]
		bool DRAOPSNHLMR
		{
			[Cpp2IlInjected.Token(Token = "0x60000EE")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000031")]
	public interface NJABIEFNXEV
	{
		[Cpp2IlInjected.Token(Token = "0x1700004F")]
		bool HFOYMYDFKWS
		{
			[Cpp2IlInjected.Token(Token = "0x60000EF")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x60000F0")]
		[Cpp2IlInjected.Address(Slot = "1")]
		[CanBeNull]
		AVVXNMEDRZL LXKGIXPHVMD();

		[Cpp2IlInjected.Token(Token = "0x60000F1")]
		[Cpp2IlInjected.Address(Slot = "2")]
		[CanBeNull]
		OVNGPAWQSZT JQRXVNFMIKD();

		[Cpp2IlInjected.Token(Token = "0x60000F2")]
		[Cpp2IlInjected.Address(Slot = "3")]
		void TOFOVGYVDYM(Guid a, long b, int c, bool d);

		[Cpp2IlInjected.Token(Token = "0x60000F3")]
		[Cpp2IlInjected.Address(Slot = "4")]
		void TOFOVGYVDYM(NJABIEFNXEV a);

		[Cpp2IlInjected.Token(Token = "0x60000F4")]
		[Cpp2IlInjected.Address(Slot = "5")]
		void SerializeTo(InventionPieceData data);
	}
	[Cpp2IlInjected.Token(Token = "0x2000032")]
	public static class UYOIDZGJDLY
	{
		[Cpp2IlInjected.Token(Token = "0x60000F5")]
		[Cpp2IlInjected.Address(RVA = "0x878D380", Offset = "0x878C380", VA = "0x18878D380")]
		public static void DeserializeFrom(this NJABIEFNXEV that, InventionPieceData inventionPieceData)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000033")]
	public interface WWWOITQCHIY
	{
		[Cpp2IlInjected.Token(Token = "0x17000050")]
		bool TNCNIEZCDAL
		{
			[Cpp2IlInjected.Token(Token = "0x60000F6")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x60000F7")]
		[Cpp2IlInjected.Address(Slot = "1")]
		[CanBeNull]
		JPXEKQKFEWW PYAGNTPWWIM();

		[Cpp2IlInjected.Token(Token = "0x60000F8")]
		[Cpp2IlInjected.Address(Slot = "2")]
		bool PYAGNTPWWIM([Out] TrialInventionInfo a);

		[Cpp2IlInjected.Token(Token = "0x60000F9")]
		[Cpp2IlInjected.Address(Slot = "3")]
		void QTHDIRQUFAL(XLYBIIWOHJI a);

		[Cpp2IlInjected.Token(Token = "0x60000FA")]
		[Cpp2IlInjected.Address(Slot = "4")]
		void DEJDJVGTWMU();
	}
	[Cpp2IlInjected.Token(Token = "0x2000034")]
	public interface JPXEKQKFEWW
	{
		[Cpp2IlInjected.Token(Token = "0x17000051")]
		int TrialSpawnTime
		{
			[Cpp2IlInjected.Token(Token = "0x60000FB")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000052")]
		int SpawningPlayerId
		{
			[Cpp2IlInjected.Token(Token = "0x60000FC")]
			[Cpp2IlInjected.Address(Slot = "1")]
			get;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000035")]
	public class InventionTrackingViaSynchronizedField : NJABIEFNXEV, AVVXNMEDRZL, WWWOITQCHIY, JPXEKQKFEWW, OVNGPAWQSZT
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000051")]
		private RBLYTPOEIRL<Guid, ObscuredLong, ObscuredInt, ObscuredBool> EQIDRFFJXCX;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000052")]
		private RABCMUEWUQA<ObscuredBool, ObscuredInt, ObscuredInt> IWROONYBORU;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000053")]
		private RRNetworkBehavior GSIRRRQANUM;

		[Cpp2IlInjected.Token(Token = "0x4000054")]
		private static readonly Log BMHSVNOOAKJ;

		[Cpp2IlInjected.Token(Token = "0x17000053")]
		private Guid ZOECLIKSSGP
		{
			[Cpp2IlInjected.Token(Token = "0x60000FE")]
			[Cpp2IlInjected.Address(RVA = "0x878B320", Offset = "0x878A320", VA = "0x18878B320")]
			get
			{
				return default(Guid);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000054")]
		private long CLKKOSOFEGA
		{
			[Cpp2IlInjected.Token(Token = "0x60000FF")]
			[Cpp2IlInjected.Address(RVA = "0x878B8C0", Offset = "0x878A8C0", VA = "0x18878B8C0")]
			get
			{
				return default(long);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000055")]
		private int NHOIMXYLPAW
		{
			[Cpp2IlInjected.Token(Token = "0x6000100")]
			[Cpp2IlInjected.Address(RVA = "0x878BF90", Offset = "0x878AF90", VA = "0x18878BF90")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000056")]
		private bool DRAOPSNHLMR
		{
			[Cpp2IlInjected.Token(Token = "0x6000101")]
			[Cpp2IlInjected.Address(RVA = "0x878B390", Offset = "0x878A390", VA = "0x18878B390")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000057")]
		private bool TNCNIEZCDAL
		{
			[Cpp2IlInjected.Token(Token = "0x6000102")]
			[Cpp2IlInjected.Address(RVA = "0x878B4F0", Offset = "0x878A4F0", VA = "0x18878B4F0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000058")]
		private int HVVYABIUMTG
		{
			[Cpp2IlInjected.Token(Token = "0x6000103")]
			[Cpp2IlInjected.Address(RVA = "0x878C0E0", Offset = "0x878B0E0", VA = "0x18878C0E0")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000059")]
		private int KSOXXMNKEYD
		{
			[Cpp2IlInjected.Token(Token = "0x6000104")]
			[Cpp2IlInjected.Address(RVA = "0x878BA40", Offset = "0x878AA40", VA = "0x18878BA40")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700005A")]
		public bool HFOYMYDFKWS
		{
			[Cpp2IlInjected.Token(Token = "0x6000107")]
			[Cpp2IlInjected.Address(RVA = "0x878B420", Offset = "0x878A420", VA = "0x18878B420", Slot = "4")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700005B")]
		private Guid AUSRXVBPQUV
		{
			[Cpp2IlInjected.Token(Token = "0x600010C")]
			[Cpp2IlInjected.Address(RVA = "0x878B320", Offset = "0x878A320", VA = "0x18878B320", Slot = "10")]
			get
			{
				return default(Guid);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700005C")]
		private long UYNUQEMADDU
		{
			[Cpp2IlInjected.Token(Token = "0x600010D")]
			[Cpp2IlInjected.Address(RVA = "0x878B730", Offset = "0x878A730", VA = "0x18878B730", Slot = "11")]
			get
			{
				return default(long);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700005D")]
		private int GUDKQHRTLSY
		{
			[Cpp2IlInjected.Token(Token = "0x600010E")]
			[Cpp2IlInjected.Address(RVA = "0x878B310", Offset = "0x878A310", VA = "0x18878B310", Slot = "12")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700005E")]
		private int DZYBLHMKTVB
		{
			[Cpp2IlInjected.Token(Token = "0x600010F")]
			[Cpp2IlInjected.Address(RVA = "0x878B740", Offset = "0x878A740", VA = "0x18878B740", Slot = "19")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700005F")]
		private int EFXEVRYBSEQ
		{
			[Cpp2IlInjected.Token(Token = "0x6000110")]
			[Cpp2IlInjected.Address(RVA = "0x878C170", Offset = "0x878B170", VA = "0x18878C170", Slot = "18")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000060")]
		private bool JUEMOTEDTCH
		{
			[Cpp2IlInjected.Token(Token = "0x6000111")]
			[Cpp2IlInjected.Address(RVA = "0x878B4A0", Offset = "0x878A4A0", VA = "0x18878B4A0", Slot = "20")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000061")]
		private bool HYXIBVHPJXG
		{
			[Cpp2IlInjected.Token(Token = "0x6000112")]
			[Cpp2IlInjected.Address(RVA = "0x878B4E0", Offset = "0x878A4E0", VA = "0x18878B4E0", Slot = "13")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000FD")]
		[Cpp2IlInjected.Address(RVA = "0x878C210", Offset = "0x878B210", VA = "0x18878C210")]
		public InventionTrackingViaSynchronizedField(RRNetworkBehavior owningBehavior, string syncKey, Guid instanceId, long inventionId, int versionNumber, bool originallyFromOtherInvention)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000105")]
		[Cpp2IlInjected.Address(RVA = "0x878B990", Offset = "0x878A990", VA = "0x18878B990", Slot = "9")]
		public void SerializeTo(InventionPieceData data)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000106")]
		[Cpp2IlInjected.Address(RVA = "0x878C020", Offset = "0x878B020", VA = "0x18878C020")]
		public static InventionPieceData UQFPHWILGWE(Guid a, long b, int c, bool d)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000108")]
		[Cpp2IlInjected.Address(RVA = "0x878B4B0", Offset = "0x878A4B0", VA = "0x18878B4B0", Slot = "5")]
		public AVVXNMEDRZL LXKGIXPHVMD()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000109")]
		[Cpp2IlInjected.Address(RVA = "0x878B4B0", Offset = "0x878A4B0", VA = "0x18878B4B0", Slot = "6")]
		public OVNGPAWQSZT JQRXVNFMIKD()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600010A")]
		[Cpp2IlInjected.Address(RVA = "0x878BAD0", Offset = "0x878AAD0", VA = "0x18878BAD0", Slot = "7")]
		public void TOFOVGYVDYM(Guid a, long b, int c, bool d)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600010B")]
		[Cpp2IlInjected.Address(RVA = "0x878BCA0", Offset = "0x878ACA0", VA = "0x18878BCA0", Slot = "8")]
		public void TOFOVGYVDYM(NJABIEFNXEV a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000113")]
		[Cpp2IlInjected.Address(RVA = "0x878B960", Offset = "0x878A960", VA = "0x18878B960", Slot = "14")]
		private JPXEKQKFEWW RZUIYGFITCV()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000114")]
		[Cpp2IlInjected.Address(RVA = "0x878B750", Offset = "0x878A750", VA = "0x18878B750", Slot = "15")]
		public bool PYAGNTPWWIM([Out] TrialInventionInfo a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000115")]
		[Cpp2IlInjected.Address(RVA = "0x878B580", Offset = "0x878A580", VA = "0x18878B580", Slot = "16")]
		private void NIISNVDGZWK(XLYBIIWOHJI a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000116")]
		[Cpp2IlInjected.Address(RVA = "0x878B7B0", Offset = "0x878A7B0", VA = "0x18878B7B0", Slot = "17")]
		private void QTXPEHLZBKR()
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
