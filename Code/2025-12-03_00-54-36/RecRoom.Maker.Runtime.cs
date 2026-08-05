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
		[Cpp2IlInjected.Address(RVA = "0x8239F40", Offset = "0x8238B40", VA = "0x188239F40", Slot = "4")]
		public override void OGBNJYRINGK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0xABFE50", Offset = "0xABEA50", VA = "0x180ABFE50")]
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
		public class GXYBTDTWHMS : PTMXKMZRVKJ<OutlineRequest>
		{
			[Cpp2IlInjected.Token(Token = "0x17000001")]
			public bool XIYOMFQFIIA
			{
				[Cpp2IlInjected.Token(Token = "0x6000009")]
				[Cpp2IlInjected.Address(RVA = "0x8238A60", Offset = "0x8237660", VA = "0x188238A60")]
				get
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x600000A")]
			[Cpp2IlInjected.Address(RVA = "0x8238980", Offset = "0x8237580", VA = "0x188238980")]
			public bool AWCJQUFWHGX(ObjectLocalId a)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600000B")]
			[Cpp2IlInjected.Address(RVA = "0x8238AA0", Offset = "0x82376A0", VA = "0x188238AA0")]
			public OutlineRequest XWOPJUNIGFH(ObjectLocalId a)
			{
				return default(OutlineRequest);
			}

			[Cpp2IlInjected.Token(Token = "0x600000C")]
			[Cpp2IlInjected.Address(RVA = "0x82389A0", Offset = "0x82375A0", VA = "0x1882389A0")]
			private int DHAAJZUMVJO(ObjectLocalId a)
			{
				return default(int);
			}

			[Cpp2IlInjected.Token(Token = "0x600000D")]
			[Cpp2IlInjected.Address(RVA = "0x8238B60", Offset = "0x8237760", VA = "0x188238B60")]
			public GXYBTDTWHMS()
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
		[Cpp2IlInjected.Address(RVA = "0x823A8F0", Offset = "0x82394F0", VA = "0x18823A8F0")]
		public OutlineRequest(ObjectLocalId requester, RequestPriority priority = RequestPriority.UgcGameplaySystem, RequestMode mode = RequestMode.TARGETED_OBJECT)
		{
		}

		[SpecialName]
		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x823A830", Offset = "0x8239430", VA = "0x18823A830")]
		public static bool OKWKXGGAXFT(OutlineRequest a, OutlineRequest b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x823A700", Offset = "0x8239300", VA = "0x18823A700", Slot = "4")]
		public bool Equals(OutlineRequest other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x823A640", Offset = "0x8239240", VA = "0x18823A640", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x823A7B0", Offset = "0x82393B0", VA = "0x18823A7B0", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000007")]
	public interface BRJENMWPNXH
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
	public abstract class OEFYHTFCDGV
	{
		[Cpp2IlInjected.Token(Token = "0x400000E")]
		public static NWSEZICLNSM<Vector3> GNRKJCHUOGD;

		[Cpp2IlInjected.Token(Token = "0x400000F")]
		public static NWSEZICLNSM<Vector3> YJDASLPQFHU;

		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x823A4D0", Offset = "0x82390D0", VA = "0x18823A4D0", Slot = "4")]
		protected virtual void ZGSNCOILTOH(Vector3 a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0x823A440", Offset = "0x8239040", VA = "0x18823A440", Slot = "5")]
		protected virtual void ZGHXPYMVJTE(Vector3 a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0xA9C6D0", Offset = "0xA9B2D0", VA = "0x180A9C6D0")]
		protected OEFYHTFCDGV()
		{
		}
	}
}
namespace RecRoom.Maker.MarqueeHelper
{
	[Cpp2IlInjected.Token(Token = "0x2000009")]
	internal class EIVOZAEKOGR : OEFYHTFCDGV
	{
		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0x8238620", Offset = "0x8237220", VA = "0x188238620")]
		public void THVVNEINSJS(Vector3 a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0x82385F0", Offset = "0x82371F0", VA = "0x1882385F0")]
		public void DNOVGEFGWMJ(Vector3 a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x8238650", Offset = "0x8237250", VA = "0x188238650")]
		public EIVOZAEKOGR()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000A")]
	public class BQGWXXZZPOF : IDisposable
	{
		[Cpp2IlInjected.Token(Token = "0x4000010")]
		private static ProfilerMarker IAMMGGLTQDM;

		[Cpp2IlInjected.Token(Token = "0x4000011")]
		private static ProfilerMarker JKLQEKJIPVO;

		[Cpp2IlInjected.Token(Token = "0x4000012")]
		private static readonly string MZRQQZIURJI;

		[Cpp2IlInjected.Token(Token = "0x4000013")]
		private static readonly string DYCGRVNJGFV;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000014")]
		private readonly int[] OFTANDNTIEI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000015")]
		private readonly int[] QJACYOTJUNI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000016")]
		private GameObject FSIAAMNUEQE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000017")]
		private MeshCollider PDNKZCGVWLU;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000018")]
		private GameObject XLSRJQDNPXQ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000019")]
		private MeshFilter GVBNTZTWCNE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400001A")]
		private Mesh FLWEEDIRYSZ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400001B")]
		private Mesh WRTJNXEFDXR;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400001C")]
		private Plane[] BTOMVHYUKTO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x400001D")]
		private Collider[] LRPKPIRZNIA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x400001E")]
		private List<ObjectLocalId> XSKMLMRKVOV;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x400001F")]
		private List<Collider> IKOHIAUHOHT;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x4000020")]
		private Vector3[] NHDZRWPYBAM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x4000021")]
		private Vector3 WSZMBWPITZW;

		[Cpp2IlInjected.FieldOffset(Offset = "0x84")]
		[Cpp2IlInjected.Token(Token = "0x4000022")]
		private Vector3 YWVDTUUJFZR;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x4000023")]
		private Quaternion GGFMNUTSONX;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
		[Cpp2IlInjected.Token(Token = "0x4000024")]
		private Vector3[] OCQJAVUHMNU;

		[Cpp2IlInjected.Token(Token = "0x17000002")]
		private Mesh XJULVPYHSNI
		{
			[Cpp2IlInjected.Token(Token = "0x6000017")]
			[Cpp2IlInjected.Address(RVA = "0xAA0C00", Offset = "0xA9F800", VA = "0x180AA0C00")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000018")]
			[Cpp2IlInjected.Address(RVA = "0x8237860", Offset = "0x8236460", VA = "0x188237860")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000003")]
		private Mesh COVPXCMMNHS
		{
			[Cpp2IlInjected.Token(Token = "0x6000019")]
			[Cpp2IlInjected.Address(RVA = "0xA988D0", Offset = "0xA974D0", VA = "0x180A988D0")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600001A")]
			[Cpp2IlInjected.Address(RVA = "0x82361B0", Offset = "0x8234DB0", VA = "0x1882361B0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000004")]
		private int TIURZOWFNSF
		{
			[Cpp2IlInjected.Token(Token = "0x600001B")]
			[Cpp2IlInjected.Address(RVA = "0x8153B20", Offset = "0x8152720", VA = "0x188153B20")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000005")]
		public IEnumerable<Collider> XHPGTVETRYN
		{
			[Cpp2IlInjected.Token(Token = "0x6000020")]
			[Cpp2IlInjected.Address(RVA = "0x82361A0", Offset = "0x8234DA0", VA = "0x1882361A0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(RVA = "0x8237B80", Offset = "0x8236780", VA = "0x188237B80")]
		public BQGWXXZZPOF(Material a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0x82357B0", Offset = "0x82343B0", VA = "0x1882357B0", Slot = "4")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x8237920", Offset = "0x8236520", VA = "0x188237920")]
		public void VMJOPWOFBJI(Vector2 a, Vector2 b, Camera c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x82379F0", Offset = "0x82365F0", VA = "0x1882379F0")]
		public void WDTWJCAJMVO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0x8236450", Offset = "0x8235050", VA = "0x188236450")]
		private IEnumerable<Collider> KNUYIOZENIV()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(RVA = "0x8236200", Offset = "0x8234E00", VA = "0x188236200")]
		public void KBPQDRJPXDI(List<ObjectLocalId> a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(RVA = "0x8237720", Offset = "0x8236320", VA = "0x188237720")]
		private void PRNZASKNCDO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000024")]
		[Cpp2IlInjected.Address(RVA = "0x82375C0", Offset = "0x82361C0", VA = "0x1882375C0")]
		private void OKKFNGFKFHR(Material a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(RVA = "0x82371E0", Offset = "0x8235DE0", VA = "0x1882371E0")]
		private void MZNQITPJDHZ(Vector2 a, Vector2 b, Camera c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(RVA = "0x82358A0", Offset = "0x82344A0", VA = "0x1882358A0")]
		private void ERZFMDANLUI(Vector2 a, Vector2 b, Camera c, Vector2 d, Vector2 e, Vector3 f, Vector3 g, Vector3 h, Vector3 i)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(RVA = "0x8236A60", Offset = "0x8235660", VA = "0x188236A60")]
		private void KRJLFAUJAWX(Camera a, Vector3 b, Vector3 c, Vector3 d, Vector3 e, Vector3 f, Vector3 g)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(RVA = "0x82378B0", Offset = "0x82364B0", VA = "0x1882378B0")]
		private void SCOARQZMIBD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(RVA = "0x8235590", Offset = "0x8234190", VA = "0x188235590")]
		private void DPWXDIOYMRY(Vector3 a, Vector3 b, Vector3 c, Vector3 d, Vector3 e)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002A")]
		[Cpp2IlInjected.Address(RVA = "0x82354F0", Offset = "0x82340F0", VA = "0x1882354F0")]
		private void DCLRLZBQDQX()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000B")]
	public class YOUKSUTMRSK<a>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000025")]
		private ZGQMAURHZTZ<a> QGUMOJKKZQB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000026")]
		private MPDEDVOOOOY<a> JOITCTXBSRW;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000027")]
		private List<a> UCILCDRTQVL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000028")]
		private List<a> DDZRFDEVOEY;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000029")]
		private List<a> QSZEQMZZYWR;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400002A")]
		private List<a> PXKNJCWPFYW;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400002B")]
		private List<a> QFHAQDJKYEM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400002C")]
		private List<a> JRSBWYGSYNB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400002D")]
		private OngoingSelectionMode DISNEEEJDBS;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400002E")]
		private EIVOZAEKOGR IKQERGFJKWL;

		[Cpp2IlInjected.Token(Token = "0x600002C")]
		[Cpp2IlInjected.Address(RVA = "0x3E402C0", Offset = "0x3E3EEC0", VA = "0x183E402C0")]
		public YOUKSUTMRSK(ZGQMAURHZTZ<a> a, MPDEDVOOOOY<a> b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002D")]
		[Cpp2IlInjected.Address(RVA = "0x3E3C5A0", Offset = "0x3E3B1A0", VA = "0x183E3C5A0")]
		public void Start(OngoingSelectionMode mode = OngoingSelectionMode.Add)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(RVA = "0x3E3E0F0", Offset = "0x3E3CCF0", VA = "0x183E3E0F0")]
		public void YRAVVIHKYQN(IEnumerable<Collider> a, List<a> b, Vector3 c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002F")]
		[Cpp2IlInjected.Address(RVA = "0x3E3C3F0", Offset = "0x3E3AFF0", VA = "0x183E3C3F0")]
		public bool SSREQBLPEHS()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000030")]
		[Cpp2IlInjected.Address(RVA = "0x3E3C8C0", Offset = "0x3E3B4C0", VA = "0x183E3C8C0")]
		[CompilerGenerated]
		private bool UVBYXOIRNPL(a a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000031")]
		[Cpp2IlInjected.Address(RVA = "0x3E3C760", Offset = "0x3E3B360", VA = "0x183E3C760")]
		[CompilerGenerated]
		private bool UUWSAHOUEEC(a a)
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
	public class EYDZBAXNEPI
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000032")]
		public readonly ShapeColor FJMIRNGGFGW;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x4000033")]
		public readonly ShapeMaterial ZZRIAUJAGUO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000034")]
		public readonly float EOMSKGXLXMG;

		[Cpp2IlInjected.Token(Token = "0x17000006")]
		public bool HYLNHOWUFPN
		{
			[Cpp2IlInjected.Token(Token = "0x6000033")]
			[Cpp2IlInjected.Address(RVA = "0x82387E0", Offset = "0x82373E0", VA = "0x1882387E0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(RVA = "0x8238800", Offset = "0x8237400", VA = "0x188238800")]
		public EYDZBAXNEPI(ShapeColor a, ShapeMaterial b, float c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(RVA = "0x82386A0", Offset = "0x82372A0", VA = "0x1882386A0", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(RVA = "0x8238750", Offset = "0x8237350", VA = "0x188238750", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000E")]
	public abstract class CreationOperationException : Exception, IVCXOGJKZQS
	{
		[Cpp2IlInjected.Token(Token = "0x17000007")]
		public abstract string UserFriendlyErrorMessage
		{
			[Cpp2IlInjected.Token(Token = "0x6000036")]
			[Cpp2IlInjected.Address(Slot = "15")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(RVA = "0x82385A0", Offset = "0x82371A0", VA = "0x1882385A0")]
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
			[Cpp2IlInjected.Address(RVA = "0x823A410", Offset = "0x8239010", VA = "0x18823A410", Slot = "15")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000038")]
		[Cpp2IlInjected.Address(RVA = "0x823A340", Offset = "0x8238F40", VA = "0x18823A340")]
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
			[Cpp2IlInjected.Address(RVA = "0xAC5C70", Offset = "0xAC4870", VA = "0x180AC5C70", Slot = "15")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600003B")]
		[Cpp2IlInjected.Address(RVA = "0x823AE10", Offset = "0x8239A10", VA = "0x18823AE10")]
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
			[Cpp2IlInjected.Address(RVA = "0x8239DC0", Offset = "0x82389C0", VA = "0x188239DC0")]
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
			[Cpp2IlInjected.Address(RVA = "0x8239DF0", Offset = "0x82389F0", VA = "0x188239DF0")]
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
			[Cpp2IlInjected.Address(RVA = "0xB49200", Offset = "0xB47E00", VA = "0x180B49200")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600003D")]
		[Cpp2IlInjected.Address(RVA = "0x823AC20", Offset = "0x8239820", VA = "0x18823AC20")]
		public ShapeSwatchInfo(ShapeColor colorId, ShapeMaterial materialId, float uvScale)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003E")]
		[Cpp2IlInjected.Address(RVA = "0x823AA90", Offset = "0x8239690", VA = "0x18823AA90")]
		public static ShapeSwatchInfo[] NZUEDNRKHNA(string a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600003F")]
		[Cpp2IlInjected.Address(RVA = "0x823A990", Offset = "0x8239590", VA = "0x18823A990")]
		public static string LVFJGBKZELF(ShapeSwatchInfo[] a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000040")]
		[Cpp2IlInjected.Address(RVA = "0x823A900", Offset = "0x8239500", VA = "0x18823A900")]
		public ShapeSwatchInfo Clone()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000041")]
		[Cpp2IlInjected.Address(RVA = "0x823AA00", Offset = "0x8239600", VA = "0x18823AA00")]
		public bool LWTWWESXHAQ(ShapeSwatchInfo a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000042")]
		[Cpp2IlInjected.Address(RVA = "0x823AA50", Offset = "0x8239650", VA = "0x18823AA50")]
		public bool LWTWWESXHAQ(ShapeMaterial a, ShapeColor b, float c)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000043")]
		[Cpp2IlInjected.Address(RVA = "0x823ABE0", Offset = "0x82397E0", VA = "0x18823ABE0")]
		public bool QSQNQIVSLFC()
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
		public NXCSTVQGGPE<ConfigurableSubpiece, Collider[], Collider[]> OnCollidersChanged;

		[Cpp2IlInjected.Token(Token = "0x1700000B")]
		public JVEDKGCJXZR PEPLCFBKYFI
		{
			[Cpp2IlInjected.Token(Token = "0x600004C")]
			[Cpp2IlInjected.Address(RVA = "0xA98620", Offset = "0xA97220", VA = "0x180A98620")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600004D")]
			[Cpp2IlInjected.Address(RVA = "0xA98C70", Offset = "0xA97870", VA = "0x180A98C70")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000C")]
		public Collider[] HLGBLWZNHIE
		{
			[Cpp2IlInjected.Token(Token = "0x600004E")]
			[Cpp2IlInjected.Address(RVA = "0xA9FED0", Offset = "0xA9EAD0", VA = "0x180A9FED0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000D")]
		public Renderer[] RVBPLKEJCQR
		{
			[Cpp2IlInjected.Token(Token = "0x600004F")]
			[Cpp2IlInjected.Address(RVA = "0xA98640", Offset = "0xA97240", VA = "0x180A98640")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000001")]
		public event Action<JVEDKGCJXZR> DXKNRRLGNFH
		{
			[Cpp2IlInjected.Token(Token = "0x6000050")]
			[Cpp2IlInjected.Address(RVA = "0x8238440", Offset = "0x8237040", VA = "0x188238440")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000051")]
			[Cpp2IlInjected.Address(RVA = "0x82384F0", Offset = "0x82370F0", VA = "0x1882384F0")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000052")]
		[Cpp2IlInjected.Address(RVA = "0x8238100", Offset = "0x8236D00", VA = "0x188238100")]
		private void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000053")]
		[Cpp2IlInjected.Address(RVA = "0x82381B0", Offset = "0x8236DB0", VA = "0x1882381B0")]
		public void Destroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000054")]
		[Cpp2IlInjected.Address(RVA = "0x8238200", Offset = "0x8236E00", VA = "0x188238200")]
		public void SetIConfigurable(JVEDKGCJXZR newConfigurable)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000055")]
		[Cpp2IlInjected.Address(RVA = "0x8238110", Offset = "0x8236D10", VA = "0x188238110")]
		public void ChangeCollidersAndRenderers(Collider[] newColliders, Renderer[] newRenderers)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000056")]
		[Cpp2IlInjected.Address(RVA = "0x8238330", Offset = "0x8236F30", VA = "0x188238330")]
		public void ValidateCollidersAndRenderers()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000057")]
		[Cpp2IlInjected.Address(RVA = "0x6D96250", Offset = "0x6D94E50", VA = "0x186D96250")]
		public void RunConfigurationSpecialActions(JVEDKGCJXZR configurable)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000058")]
		[Cpp2IlInjected.Address(RVA = "0x82383C0", Offset = "0x8236FC0", VA = "0x1882383C0")]
		public ConfigurableSubpiece()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000017")]
	public interface DHOSWMEWABZ
	{
		[Cpp2IlInjected.Token(Token = "0x1700000E")]
		bool CMUCBQXQPHE
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
	public interface ZMTYHOMSLJO
	{
		[Cpp2IlInjected.Token(Token = "0x600005C")]
		[Cpp2IlInjected.Address(Slot = "0")]
		IEnumerable<EYDZBAXNEPI> GetColorableSnapshots();
	}
	[Cpp2IlInjected.Token(Token = "0x2000019")]
	public interface DAFNKYKBJSM
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
	public interface JRIZEDSAQGD
	{
		[Cpp2IlInjected.Token(Token = "0x1700000F")]
		GameObject NDIXLSKEJMG
		{
			[Cpp2IlInjected.Token(Token = "0x6000062")]
			[Cpp2IlInjected.Address(Slot = "2")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000010")]
		Guid YQMTQVAKWIK
		{
			[Cpp2IlInjected.Token(Token = "0x6000063")]
			[Cpp2IlInjected.Address(Slot = "3")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000011")]
		string XPPEXRAPNHC
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
		Vector3 ACQPXVQRUAC
		{
			[Cpp2IlInjected.Token(Token = "0x6000066")]
			[Cpp2IlInjected.Address(Slot = "6")]
			get;
			[Cpp2IlInjected.Token(Token = "0x6000067")]
			[Cpp2IlInjected.Address(Slot = "7")]
			set;
		}

		[Cpp2IlInjected.Token(Token = "0x17000014")]
		Vector3 JTXETNBCQZH
		{
			[Cpp2IlInjected.Token(Token = "0x6000068")]
			[Cpp2IlInjected.Address(Slot = "8")]
			get;
			[Cpp2IlInjected.Token(Token = "0x6000069")]
			[Cpp2IlInjected.Address(Slot = "9")]
			set;
		}

		[Cpp2IlInjected.Token(Token = "0x17000015")]
		Quaternion PAYQNKAOPXN
		{
			[Cpp2IlInjected.Token(Token = "0x600006A")]
			[Cpp2IlInjected.Address(Slot = "10")]
			get;
			[Cpp2IlInjected.Token(Token = "0x600006B")]
			[Cpp2IlInjected.Address(Slot = "11")]
			set;
		}

		[Cpp2IlInjected.Token(Token = "0x17000016")]
		Quaternion ZAMKQYUDRUI
		{
			[Cpp2IlInjected.Token(Token = "0x600006C")]
			[Cpp2IlInjected.Address(Slot = "12")]
			get;
			[Cpp2IlInjected.Token(Token = "0x600006D")]
			[Cpp2IlInjected.Address(Slot = "13")]
			set;
		}

		[Cpp2IlInjected.Token(Token = "0x17000017")]
		float DLDTFSJAVPR
		{
			[Cpp2IlInjected.Token(Token = "0x600006E")]
			[Cpp2IlInjected.Address(Slot = "14")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000018")]
		float LJIEMERTDBK
		{
			[Cpp2IlInjected.Token(Token = "0x600006F")]
			[Cpp2IlInjected.Address(Slot = "15")]
			get;
			[Cpp2IlInjected.Token(Token = "0x6000070")]
			[Cpp2IlInjected.Address(Slot = "16")]
			set;
		}

		[Cpp2IlInjected.Token(Token = "0x17000019")]
		Vector3 DQTNAJHAQDH
		{
			[Cpp2IlInjected.Token(Token = "0x6000071")]
			[Cpp2IlInjected.Address(Slot = "17")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x1700001A")]
		Vector3 WFFPFVTPSWO
		{
			[Cpp2IlInjected.Token(Token = "0x6000072")]
			[Cpp2IlInjected.Address(Slot = "18")]
			get;
			[Cpp2IlInjected.Token(Token = "0x6000073")]
			[Cpp2IlInjected.Address(Slot = "19")]
			set;
		}

		[Cpp2IlInjected.Token(Token = "0x1700001B")]
		bool NUKJZTNVLIR
		{
			[Cpp2IlInjected.Token(Token = "0x6000074")]
			[Cpp2IlInjected.Address(Slot = "20")]
			set;
		}

		[Cpp2IlInjected.Token(Token = "0x1700001C")]
		JVEDKGCJXZR PEPLCFBKYFI
		{
			[Cpp2IlInjected.Token(Token = "0x6000075")]
			[Cpp2IlInjected.Address(Slot = "21")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x1700001D")]
		[CanBeNull]
		HSNDSXMEYJF CIHTISEFDOU
		{
			[Cpp2IlInjected.Token(Token = "0x6000076")]
			[Cpp2IlInjected.Address(Slot = "22")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x14000002")]
		event Action SMLAUYAQLBI;

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
	public interface PYZHHXNQDGO
	{
		[Cpp2IlInjected.Token(Token = "0x1700001E")]
		bool HOCTMKXWQCI
		{
			[Cpp2IlInjected.Token(Token = "0x600008D")]
			[Cpp2IlInjected.Address(Slot = "19")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x1700001F")]
		bool KLXSQMGLOCV
		{
			[Cpp2IlInjected.Token(Token = "0x600008E")]
			[Cpp2IlInjected.Address(Slot = "20")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000020")]
		Vector3 ENLNFBFXGXK
		{
			[Cpp2IlInjected.Token(Token = "0x600008F")]
			[Cpp2IlInjected.Address(Slot = "21")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000021")]
		Vector3 OJRKEQYKGKK
		{
			[Cpp2IlInjected.Token(Token = "0x6000090")]
			[Cpp2IlInjected.Address(Slot = "22")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000022")]
		bool CUWPELIUVLQ
		{
			[Cpp2IlInjected.Token(Token = "0x6000091")]
			[Cpp2IlInjected.Address(Slot = "23")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000023")]
		bool ILDTLENRXFB
		{
			[Cpp2IlInjected.Token(Token = "0x6000092")]
			[Cpp2IlInjected.Address(Slot = "24")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000024")]
		bool URMTPGYDOIY
		{
			[Cpp2IlInjected.Token(Token = "0x6000093")]
			[Cpp2IlInjected.Address(Slot = "25")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000025")]
		bool IHHOLAFMUBB
		{
			[Cpp2IlInjected.Token(Token = "0x6000094")]
			[Cpp2IlInjected.Address(Slot = "26")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000026")]
		bool XYCZUGTAUWO
		{
			[Cpp2IlInjected.Token(Token = "0x6000095")]
			[Cpp2IlInjected.Address(Slot = "27")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000027")]
		bool BILUOLCPGNO
		{
			[Cpp2IlInjected.Token(Token = "0x6000096")]
			[Cpp2IlInjected.Address(Slot = "28")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000028")]
		bool AQHZDUBZKQD
		{
			[Cpp2IlInjected.Token(Token = "0x6000097")]
			[Cpp2IlInjected.Address(Slot = "29")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000029")]
		bool IQYHWACXKZE
		{
			[Cpp2IlInjected.Token(Token = "0x6000098")]
			[Cpp2IlInjected.Address(Slot = "30")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x1700002A")]
		bool SAPWMJIOXOK
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
	public interface HWUTMYXSNWE
	{
		[Cpp2IlInjected.Token(Token = "0x600009E")]
		[Cpp2IlInjected.Address(Slot = "0")]
		bool YKTZYDWNIUZ([In] Vector3 origin, [In] Vector3 direction, Vector3 a, Vector3 b);
	}
	[Cpp2IlInjected.Token(Token = "0x200001D")]
	public interface VYIXSUAOHCD
	{
		[Cpp2IlInjected.Token(Token = "0x1700002B")]
		bool AEQGHCUNGOW
		{
			[Cpp2IlInjected.Token(Token = "0x600009F")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x1700002C")]
		DXNVWYSIFYL CKHEFOPQPHR
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
	public interface ALCVWQMWAAV
	{
		[Cpp2IlInjected.Token(Token = "0x1700002D")]
		bool XFYTULHJCAI
		{
			[Cpp2IlInjected.Token(Token = "0x60000A4")]
			[Cpp2IlInjected.Address(Slot = "2")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x1700002E")]
		SPLOTWJQNFG ZWHPIMUTUFM
		{
			[Cpp2IlInjected.Token(Token = "0x60000A5")]
			[Cpp2IlInjected.Address(Slot = "3")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x14000003")]
		event Action<bool> EDDYBUCIWRD;

		[Cpp2IlInjected.Token(Token = "0x60000A6")]
		[Cpp2IlInjected.Address(Slot = "4")]
		void LocalPlayerTakeAuthority();

		[Cpp2IlInjected.Token(Token = "0x60000A7")]
		[Cpp2IlInjected.Address(Slot = "5")]
		void TransferOwnership(int actorNumber);

		[Cpp2IlInjected.Token(Token = "0x60000A8")]
		[Cpp2IlInjected.Address(Slot = "6")]
		HNNNRVHBOIU GetCulprit(CreationResult failureReason);
	}
	[Cpp2IlInjected.Token(Token = "0x200001F")]
	public interface TWLAQUPNITR
	{
		[Cpp2IlInjected.Token(Token = "0x1700002F")]
		IEnumerable<NavMeshSupport.Restriction> KVIRMCWKDNJ
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
	public interface JLLDFPRMVUY
	{
		[Cpp2IlInjected.Token(Token = "0x60000AC")]
		[Cpp2IlInjected.Address(Slot = "0")]
		void Reset();

		[Cpp2IlInjected.Token(Token = "0x60000AD")]
		[Cpp2IlInjected.Address(Slot = "1")]
		void RequestRPCReset();
	}
	[Cpp2IlInjected.Token(Token = "0x2000021")]
	public interface ZYRQGVIYDYE
	{
		[Cpp2IlInjected.Token(Token = "0x17000030")]
		bool TIXIPTKVMVT
		{
			[Cpp2IlInjected.Token(Token = "0x60000AE")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000031")]
		bool PBJHEFSCMES
		{
			[Cpp2IlInjected.Token(Token = "0x60000AF")]
			[Cpp2IlInjected.Address(Slot = "1")]
			get;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000022")]
	public interface QZLICILGFDP
	{
		[Cpp2IlInjected.Token(Token = "0x17000032")]
		int QAVYGACSRZN
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
	public interface POIRGGDBQEC
	{
		[Cpp2IlInjected.Token(Token = "0x17000033")]
		bool NYMCBUJSVNS
		{
			[Cpp2IlInjected.Token(Token = "0x60000B6")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
			[Cpp2IlInjected.Token(Token = "0x60000B7")]
			[Cpp2IlInjected.Address(Slot = "1")]
			set;
		}

		[Cpp2IlInjected.Token(Token = "0x17000034")]
		CanSaveObjectIntoInventionResultType WOQDQWLMDZJ
		{
			[Cpp2IlInjected.Token(Token = "0x60000B9")]
			[Cpp2IlInjected.Address(Slot = "3")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000035")]
		bool NICUQCBZXRE
		{
			[Cpp2IlInjected.Token(Token = "0x60000BA")]
			[Cpp2IlInjected.Address(Slot = "4")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000036")]
		bool OTLHBVCWGHV
		{
			[Cpp2IlInjected.Token(Token = "0x60000BB")]
			[Cpp2IlInjected.Address(Slot = "5")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000037")]
		bool ADBPQLQIPUZ
		{
			[Cpp2IlInjected.Token(Token = "0x60000BC")]
			[Cpp2IlInjected.Address(Slot = "6")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000038")]
		bool IVPTSMTKNZE
		{
			[Cpp2IlInjected.Token(Token = "0x60000BD")]
			[Cpp2IlInjected.Address(Slot = "7")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000039")]
		bool SJYZZOYMYMJ
		{
			[Cpp2IlInjected.Token(Token = "0x60000BE")]
			[Cpp2IlInjected.Address(Slot = "8")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x1700003A")]
		IEnumerable<Collider> VSKQQLWFDDC
		{
			[Cpp2IlInjected.Token(Token = "0x60000BF")]
			[Cpp2IlInjected.Address(Slot = "9")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x1700003B")]
		RotatedBounds? QOBAFETHYCS
		{
			[Cpp2IlInjected.Token(Token = "0x60000C0")]
			[Cpp2IlInjected.Address(Slot = "10")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x1700003C")]
		bool SNTHFVTBZEI
		{
			[Cpp2IlInjected.Token(Token = "0x60000C1")]
			[Cpp2IlInjected.Address(Slot = "11")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x1700003D")]
		bool DTCRJJXGGGC
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
	public interface TBYJZAUSUCD
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
	public interface BPMYBFNRMYC
	{
		[Cpp2IlInjected.Token(Token = "0x1700003E")]
		object ZPNUDSXHWDV
		{
			[Cpp2IlInjected.Token(Token = "0x60000C6")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x1700003F")]
		Type DHERLHROKWM
		{
			[Cpp2IlInjected.Token(Token = "0x60000C7")]
			[Cpp2IlInjected.Address(Slot = "1")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000040")]
		Guid XUBJHNMOBSE
		{
			[Cpp2IlInjected.Token(Token = "0x60000C8")]
			[Cpp2IlInjected.Address(Slot = "2")]
			get;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000026")]
	public interface JVEDKGCJXZR
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
		event Action<string> DSHSATVAOEU;

		[Cpp2IlInjected.Token(Token = "0x14000005")]
		event Action<JVEDKGCJXZR> HHTSCFYSIKR;

		[Cpp2IlInjected.Token(Token = "0x14000006")]
		event Action<DialogType, OSLPSGYPPSC> NCYPGVGKNGK;

		[Cpp2IlInjected.Token(Token = "0x14000007")]
		event Action IPWCWJQSTPD;

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
	public interface KZBSMCQAFXX
	{
		[Cpp2IlInjected.Token(Token = "0x14000008")]
		event Action TUYMSPCCJFD;
	}
	[Cpp2IlInjected.Token(Token = "0x2000028")]
	public interface TQJBBIDJEUO : JVEDKGCJXZR, UGBYCXBRIYW
	{
		[Cpp2IlInjected.Token(Token = "0x17000045")]
		IEnumerable<UGBYCXBRIYW> CFXHFWUZGJT
		{
			[Cpp2IlInjected.Token(Token = "0x60000DB")]
			[Cpp2IlInjected.Address(Slot = "1")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x60000DA")]
		[Cpp2IlInjected.Address(Slot = "0")]
		void RegisterConfigurableAddOn(UGBYCXBRIYW newSubConfigurable);
	}
	[Cpp2IlInjected.Token(Token = "0x2000029")]
	public interface UGBYCXBRIYW
	{
		[Cpp2IlInjected.Token(Token = "0x60000DC")]
		[Cpp2IlInjected.Address(Slot = "0")]
		IReadOnlyList<IDynamicUIElementData> GetConfigurableDynamicUI([Optional] IEnumerable<UGBYCXBRIYW> configurables);
	}
	[Cpp2IlInjected.Token(Token = "0x200002A")]
	public interface MLYRPVDRMJA
	{
		[Cpp2IlInjected.Token(Token = "0x17000046")]
		bool HSYWVSDEUUR
		{
			[Cpp2IlInjected.Token(Token = "0x60000DD")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
			[Cpp2IlInjected.Token(Token = "0x60000DE")]
			[Cpp2IlInjected.Address(Slot = "1")]
			set;
		}

		[Cpp2IlInjected.Token(Token = "0x17000047")]
		bool EITAULQPRUW
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
		public IEnumerable<Restriction> BFIIFZWZZFK
		{
			[Cpp2IlInjected.Token(Token = "0x60000E1")]
			[Cpp2IlInjected.Address(RVA = "0x823A1C0", Offset = "0x8238DC0", VA = "0x18823A1C0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000E2")]
		[Cpp2IlInjected.Address(RVA = "0x8239FC0", Offset = "0x8238BC0", VA = "0x188239FC0")]
		public void Add(Restriction restriction)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E3")]
		[Cpp2IlInjected.Address(RVA = "0x823A220", Offset = "0x8238E20", VA = "0x18823A220")]
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
	public readonly struct TrialInventionInfo : UBOFFIBECXK
	{
		[Cpp2IlInjected.Token(Token = "0x17000049")]
		public int SpawningPlayerId
		{
			[Cpp2IlInjected.Token(Token = "0x60000E7")]
			[Cpp2IlInjected.Address(RVA = "0xC6CF70", Offset = "0xC6BB70", VA = "0x180C6CF70", Slot = "5")]
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
			[Cpp2IlInjected.Address(RVA = "0x2DEBBC0", Offset = "0x2DEA7C0", VA = "0x182DEBBC0", Slot = "4")]
			[CompilerGenerated]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000E9")]
		[Cpp2IlInjected.Address(RVA = "0x823AC70", Offset = "0x8239870", VA = "0x18823AC70")]
		public TrialInventionInfo(int trialSpawnTime, int spawningPlayerId)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200002F")]
	public interface CMHKSEOEBIX : UPHCOUWBEYW
	{
		[Cpp2IlInjected.Token(Token = "0x400004F")]
		static readonly int TQAMMZHVMHS;

		[Cpp2IlInjected.Token(Token = "0x4000050")]
		static readonly Guid QIABJHOBYKJ;

		[Cpp2IlInjected.Token(Token = "0x1700004B")]
		Guid CHRGTRTBTGZ
		{
			[Cpp2IlInjected.Token(Token = "0x60000EA")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x1700004C")]
		long ZTFCHXJICRQ
		{
			[Cpp2IlInjected.Token(Token = "0x60000EB")]
			[Cpp2IlInjected.Address(Slot = "1")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x1700004D")]
		[Obsolete("This is not used - version tracking is done at the server level as collections of InventionId")]
		int BGWQSVGDUBS
		{
			[Cpp2IlInjected.Token(Token = "0x60000EC")]
			[Cpp2IlInjected.Address(Slot = "2")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x60000ED")]
		[Cpp2IlInjected.Address(RVA = "0x8238090", Offset = "0x8236C90", VA = "0x188238090")]
		static CMHKSEOEBIX()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000030")]
	[Obsolete("This is not used by anything and does not give us full provenance tracking")]
	public interface INILDERQZXR
	{
		[Cpp2IlInjected.Token(Token = "0x1700004E")]
		[Obsolete("This is not currently consumed and does not give us full provenance tracking, however it does contain information that may prevent 'contamination' of invention contents by other non-monetizable inventions")]
		bool FCNDTKITTTZ
		{
			[Cpp2IlInjected.Token(Token = "0x60000EE")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000031")]
	public interface HSNDSXMEYJF
	{
		[Cpp2IlInjected.Token(Token = "0x1700004F")]
		bool BQSPPIXRULW
		{
			[Cpp2IlInjected.Token(Token = "0x60000EF")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x60000F0")]
		[Cpp2IlInjected.Address(Slot = "1")]
		[CanBeNull]
		CMHKSEOEBIX YALAEWCCZDL();

		[Cpp2IlInjected.Token(Token = "0x60000F1")]
		[Cpp2IlInjected.Address(Slot = "2")]
		[CanBeNull]
		INILDERQZXR OWOWIRUWWSV();

		[Cpp2IlInjected.Token(Token = "0x60000F2")]
		[Cpp2IlInjected.Address(Slot = "3")]
		void PGGZSDCJWPA(Guid a, long b, int c, bool d);

		[Cpp2IlInjected.Token(Token = "0x60000F3")]
		[Cpp2IlInjected.Address(Slot = "4")]
		void PGGZSDCJWPA(HSNDSXMEYJF a);

		[Cpp2IlInjected.Token(Token = "0x60000F4")]
		[Cpp2IlInjected.Address(Slot = "5")]
		void SerializeTo(InventionPieceData data);
	}
	[Cpp2IlInjected.Token(Token = "0x2000032")]
	public static class GKQJNMWKIYQ
	{
		[Cpp2IlInjected.Token(Token = "0x60000F5")]
		[Cpp2IlInjected.Address(RVA = "0x8238860", Offset = "0x8237460", VA = "0x188238860")]
		public static void DeserializeFrom(this HSNDSXMEYJF that, InventionPieceData inventionPieceData)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000033")]
	public interface UPHCOUWBEYW
	{
		[Cpp2IlInjected.Token(Token = "0x17000050")]
		bool ZZAXKMCLGRH
		{
			[Cpp2IlInjected.Token(Token = "0x60000F6")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x60000F7")]
		[Cpp2IlInjected.Address(Slot = "1")]
		[CanBeNull]
		UBOFFIBECXK INJOTKLFNJQ();

		[Cpp2IlInjected.Token(Token = "0x60000F8")]
		[Cpp2IlInjected.Address(Slot = "2")]
		bool INJOTKLFNJQ([Out] TrialInventionInfo a);

		[Cpp2IlInjected.Token(Token = "0x60000F9")]
		[Cpp2IlInjected.Address(Slot = "3")]
		void NAKDCASPJGV(HNNNRVHBOIU a);

		[Cpp2IlInjected.Token(Token = "0x60000FA")]
		[Cpp2IlInjected.Address(Slot = "4")]
		void DOPBNTMRFLE();
	}
	[Cpp2IlInjected.Token(Token = "0x2000034")]
	public interface UBOFFIBECXK
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
	public class InventionTrackingViaSynchronizedField : HSNDSXMEYJF, CMHKSEOEBIX, UPHCOUWBEYW, UBOFFIBECXK, INILDERQZXR
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000051")]
		private QXTZTLCIJNJ<Guid, ObscuredLong, ObscuredInt, ObscuredBool> SRNHIAYHNYJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000052")]
		private QXEFBQUQHFI<ObscuredBool, ObscuredInt, ObscuredInt> FJRRPUDVFQA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000053")]
		private RRNetworkBehavior GGAKNSHIHOK;

		[Cpp2IlInjected.Token(Token = "0x4000054")]
		private static readonly Log JVTVAZRWBFB;

		[Cpp2IlInjected.Token(Token = "0x17000053")]
		private Guid CHRGTRTBTGZ
		{
			[Cpp2IlInjected.Token(Token = "0x60000FE")]
			[Cpp2IlInjected.Address(RVA = "0x8238E70", Offset = "0x8237A70", VA = "0x188238E70")]
			get
			{
				return default(Guid);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000054")]
		private long ZTFCHXJICRQ
		{
			[Cpp2IlInjected.Token(Token = "0x60000FF")]
			[Cpp2IlInjected.Address(RVA = "0x8238BA0", Offset = "0x82377A0", VA = "0x188238BA0")]
			get
			{
				return default(long);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000055")]
		private int BGWQSVGDUBS
		{
			[Cpp2IlInjected.Token(Token = "0x6000100")]
			[Cpp2IlInjected.Address(RVA = "0x82398F0", Offset = "0x82384F0", VA = "0x1882398F0")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000056")]
		private bool FCNDTKITTTZ
		{
			[Cpp2IlInjected.Token(Token = "0x6000101")]
			[Cpp2IlInjected.Address(RVA = "0x8238F10", Offset = "0x8237B10", VA = "0x188238F10")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000057")]
		private bool ZZAXKMCLGRH
		{
			[Cpp2IlInjected.Token(Token = "0x6000102")]
			[Cpp2IlInjected.Address(RVA = "0x8239980", Offset = "0x8238580", VA = "0x188239980")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000058")]
		private int IOPSZKYKHOS
		{
			[Cpp2IlInjected.Token(Token = "0x6000103")]
			[Cpp2IlInjected.Address(RVA = "0x8238C40", Offset = "0x8237840", VA = "0x188238C40")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000059")]
		private int UZGMFVCIDLX
		{
			[Cpp2IlInjected.Token(Token = "0x6000104")]
			[Cpp2IlInjected.Address(RVA = "0x8239780", Offset = "0x8238380", VA = "0x188239780")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700005A")]
		public bool BQSPPIXRULW
		{
			[Cpp2IlInjected.Token(Token = "0x6000107")]
			[Cpp2IlInjected.Address(RVA = "0x8238CD0", Offset = "0x82378D0", VA = "0x188238CD0", Slot = "4")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700005B")]
		private Guid OUKRPORVCVB
		{
			[Cpp2IlInjected.Token(Token = "0x600010C")]
			[Cpp2IlInjected.Address(RVA = "0x8238E70", Offset = "0x8237A70", VA = "0x188238E70", Slot = "10")]
			get
			{
				return default(Guid);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700005C")]
		private long IRJDIYOAWJS
		{
			[Cpp2IlInjected.Token(Token = "0x600010D")]
			[Cpp2IlInjected.Address(RVA = "0x8239820", Offset = "0x8238420", VA = "0x188239820", Slot = "11")]
			get
			{
				return default(long);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700005D")]
		private int PXJAHVUNNLQ
		{
			[Cpp2IlInjected.Token(Token = "0x600010E")]
			[Cpp2IlInjected.Address(RVA = "0x8239810", Offset = "0x8238410", VA = "0x188239810", Slot = "12")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700005E")]
		private int BSHPZTZTHCR
		{
			[Cpp2IlInjected.Token(Token = "0x600010F")]
			[Cpp2IlInjected.Address(RVA = "0x8238E60", Offset = "0x8237A60", VA = "0x188238E60", Slot = "19")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700005F")]
		private int OBFOAHRCDMG
		{
			[Cpp2IlInjected.Token(Token = "0x6000110")]
			[Cpp2IlInjected.Address(RVA = "0x82398E0", Offset = "0x82384E0", VA = "0x1882398E0", Slot = "18")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000060")]
		private bool AKBAJWZCYFP
		{
			[Cpp2IlInjected.Token(Token = "0x6000111")]
			[Cpp2IlInjected.Address(RVA = "0x8239000", Offset = "0x8237C00", VA = "0x188239000", Slot = "20")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000061")]
		private bool TBKMOYJPKDE
		{
			[Cpp2IlInjected.Token(Token = "0x6000112")]
			[Cpp2IlInjected.Address(RVA = "0x8239280", Offset = "0x8237E80", VA = "0x188239280", Slot = "13")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000FD")]
		[Cpp2IlInjected.Address(RVA = "0x8239AA0", Offset = "0x82386A0", VA = "0x188239AA0")]
		public InventionTrackingViaSynchronizedField(RRNetworkBehavior owningBehavior, string syncKey, Guid instanceId, long inventionId, int versionNumber, bool originallyFromOtherInvention)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000105")]
		[Cpp2IlInjected.Address(RVA = "0x8239830", Offset = "0x8238430", VA = "0x188239830", Slot = "9")]
		public void SerializeTo(InventionPieceData data)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000106")]
		[Cpp2IlInjected.Address(RVA = "0x8239010", Offset = "0x8237C10", VA = "0x188239010")]
		public static InventionPieceData LSUVFAQKSHY(Guid a, long b, int c, bool d)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000108")]
		[Cpp2IlInjected.Address(RVA = "0x8239290", Offset = "0x8237E90", VA = "0x188239290", Slot = "5")]
		public CMHKSEOEBIX YALAEWCCZDL()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000109")]
		[Cpp2IlInjected.Address(RVA = "0x8239290", Offset = "0x8237E90", VA = "0x188239290", Slot = "6")]
		public INILDERQZXR OWOWIRUWWSV()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600010A")]
		[Cpp2IlInjected.Address(RVA = "0x82395B0", Offset = "0x82381B0", VA = "0x1882395B0", Slot = "7")]
		public void PGGZSDCJWPA(Guid a, long b, int c, bool d)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600010B")]
		[Cpp2IlInjected.Address(RVA = "0x82392C0", Offset = "0x8237EC0", VA = "0x1882392C0", Slot = "8")]
		public void PGGZSDCJWPA(HSNDSXMEYJF a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000113")]
		[Cpp2IlInjected.Address(RVA = "0x8238EE0", Offset = "0x8237AE0", VA = "0x188238EE0", Slot = "14")]
		private UBOFFIBECXK HSQJCEOYWLJ()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000114")]
		[Cpp2IlInjected.Address(RVA = "0x8238FA0", Offset = "0x8237BA0", VA = "0x188238FA0", Slot = "15")]
		public bool INJOTKLFNJQ([Out] TrialInventionInfo a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000115")]
		[Cpp2IlInjected.Address(RVA = "0x82390D0", Offset = "0x8237CD0", VA = "0x1882390D0", Slot = "16")]
		private void NYXCGBDRGVG(HNNNRVHBOIU a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000116")]
		[Cpp2IlInjected.Address(RVA = "0x8238D50", Offset = "0x8237950", VA = "0x188238D50", Slot = "17")]
		private void GKSGIQGIKDN()
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
