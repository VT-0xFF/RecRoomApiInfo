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
		[Cpp2IlInjected.Address(RVA = "0x9A3A100", Offset = "0x9A38B00", VA = "0x189A3A100", Slot = "4")]
		public override void WSFSWRIEDET()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0xD3AE50", Offset = "0xD39850", VA = "0x180D3AE50")]
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
		public class SDILILNIOLP : OWOMJFMJVPY<OutlineRequest>
		{
			[Cpp2IlInjected.Token(Token = "0x17000001")]
			public bool RQLJIMEKAHB
			{
				[Cpp2IlInjected.Token(Token = "0x6000009")]
				[Cpp2IlInjected.Address(RVA = "0x9A3AA80", Offset = "0x9A39480", VA = "0x189A3AA80")]
				get
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x600000A")]
			[Cpp2IlInjected.Address(RVA = "0x9A3AB80", Offset = "0x9A39580", VA = "0x189A3AB80")]
			public bool RCWRRVNGBCU(ObjectLocalId a)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600000B")]
			[Cpp2IlInjected.Address(RVA = "0x9A3AAC0", Offset = "0x9A394C0", VA = "0x189A3AAC0")]
			public OutlineRequest MRTDVWGLSBC(ObjectLocalId a)
			{
				return default(OutlineRequest);
			}

			[Cpp2IlInjected.Token(Token = "0x600000C")]
			[Cpp2IlInjected.Address(RVA = "0x9A3ABA0", Offset = "0x9A395A0", VA = "0x189A3ABA0")]
			private int UNCVAOUSYYP(ObjectLocalId a)
			{
				return default(int);
			}

			[Cpp2IlInjected.Token(Token = "0x600000D")]
			[Cpp2IlInjected.Address(RVA = "0x9A3AC60", Offset = "0x9A39660", VA = "0x189A3AC60")]
			public SDILILNIOLP()
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
		[Cpp2IlInjected.Address(RVA = "0x9A3A8B0", Offset = "0x9A392B0", VA = "0x189A3A8B0")]
		public OutlineRequest(ObjectLocalId requester, RequestPriority priority = RequestPriority.UgcGameplaySystem, RequestMode mode = RequestMode.TARGETED_OBJECT)
		{
		}

		[SpecialName]
		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x9A3A7F0", Offset = "0x9A391F0", VA = "0x189A3A7F0")]
		public static bool SHHUBVCQRYC(OutlineRequest a, OutlineRequest b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x9A3A6C0", Offset = "0x9A390C0", VA = "0x189A3A6C0", Slot = "4")]
		public bool Equals(OutlineRequest other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x9A3A600", Offset = "0x9A39000", VA = "0x189A3A600", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x9A3A770", Offset = "0x9A39170", VA = "0x189A3A770", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000007")]
	public interface FDSQRVAPKDA
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
	public abstract class AUEGYSFYUSK
	{
		[Cpp2IlInjected.Token(Token = "0x400000E")]
		public static VEFRPOSZNGH<Vector3> YPQEPBOLIVI;

		[Cpp2IlInjected.Token(Token = "0x400000F")]
		public static VEFRPOSZNGH<Vector3> XDPWNDFFRBF;

		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x9A384A0", Offset = "0x9A36EA0", VA = "0x189A384A0", Slot = "4")]
		protected virtual void HDPMLCJBQRA(Vector3 a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0x9A38530", Offset = "0x9A36F30", VA = "0x189A38530", Slot = "5")]
		protected virtual void UHYIAXMREUL(Vector3 a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0xD179B0", Offset = "0xD163B0", VA = "0x180D179B0")]
		protected AUEGYSFYUSK()
		{
		}
	}
}
namespace RecRoom.Maker.MarqueeHelper
{
	[Cpp2IlInjected.Token(Token = "0x2000009")]
	internal class ECESLFBYHJS : AUEGYSFYUSK
	{
		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0x9A38CB0", Offset = "0x9A376B0", VA = "0x189A38CB0")]
		public void NUNVKDGGTLL(Vector3 a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0x9A38CE0", Offset = "0x9A376E0", VA = "0x189A38CE0")]
		public void WXENOLXSJBK(Vector3 a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x9A38D10", Offset = "0x9A37710", VA = "0x189A38D10")]
		public ECESLFBYHJS()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000A")]
	public class AARNNYQAAQE : IDisposable
	{
		[Cpp2IlInjected.Token(Token = "0x4000010")]
		private static ProfilerMarker HCRRGAJSPDT;

		[Cpp2IlInjected.Token(Token = "0x4000011")]
		private static ProfilerMarker CJYDUGQYTLF;

		[Cpp2IlInjected.Token(Token = "0x4000012")]
		private static readonly string GOYUZXCHITX;

		[Cpp2IlInjected.Token(Token = "0x4000013")]
		private static readonly string VLSQETCUEIG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000014")]
		private readonly int[] HGXCWVGGGPT;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000015")]
		private readonly int[] UQYRKWSYSXR;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000016")]
		private GameObject EZUNGJLIUQL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000017")]
		private MeshCollider AFTUEKWMFYN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000018")]
		private GameObject LNALDXHNDUJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000019")]
		private MeshFilter JACSWYAFHGZ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400001A")]
		private Mesh IIIOGGEMBWA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400001B")]
		private Mesh SGRMSNHIBIW;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400001C")]
		private Plane[] BAGVTFFQBHP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x400001D")]
		private Collider[] TAEZWAPNXDV;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x400001E")]
		private List<ObjectLocalId> AYNGQLGVYGK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x400001F")]
		private List<Collider> DJZCNEVVMNW;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x4000020")]
		private Vector3[] FVYPPYXFJSL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x4000021")]
		private Vector3 DCVJCTIBETD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x84")]
		[Cpp2IlInjected.Token(Token = "0x4000022")]
		private Vector3 DEKQMUKGQZW;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x4000023")]
		private Quaternion WKVVHTTKCWQ;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
		[Cpp2IlInjected.Token(Token = "0x4000024")]
		private Vector3[] MTOAOHGCUJL;

		[Cpp2IlInjected.Token(Token = "0x17000002")]
		private Mesh KPIXOJTVYQJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000017")]
			[Cpp2IlInjected.Address(RVA = "0xD161C0", Offset = "0xD14BC0", VA = "0x180D161C0")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000018")]
			[Cpp2IlInjected.Address(RVA = "0x9A36DB0", Offset = "0x9A357B0", VA = "0x189A36DB0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000003")]
		private Mesh HQMNIPHMPZJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000019")]
			[Cpp2IlInjected.Address(RVA = "0xD159A0", Offset = "0xD143A0", VA = "0x180D159A0")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600001A")]
			[Cpp2IlInjected.Address(RVA = "0x9A37490", Offset = "0x9A35E90", VA = "0x189A37490")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000004")]
		private int ASQNAHXRTQK
		{
			[Cpp2IlInjected.Token(Token = "0x600001B")]
			[Cpp2IlInjected.Address(RVA = "0x994D720", Offset = "0x994C120", VA = "0x18994D720")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000005")]
		public IEnumerable<Collider> PVYDOUZAFUE
		{
			[Cpp2IlInjected.Token(Token = "0x6000020")]
			[Cpp2IlInjected.Address(RVA = "0x9A37410", Offset = "0x9A35E10", VA = "0x189A37410")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(RVA = "0x9A37F90", Offset = "0x9A36990", VA = "0x189A37F90")]
		public AARNNYQAAQE(Material a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0x9A35900", Offset = "0x9A34300", VA = "0x189A35900", Slot = "4")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x9A37C60", Offset = "0x9A36660", VA = "0x189A37C60")]
		public void UYSLEDCJDIR(Vector2 a, Vector2 b, Camera c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x9A366D0", Offset = "0x9A350D0", VA = "0x189A366D0")]
		public void GWTCAUNFHWN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0x9A36E00", Offset = "0x9A35800", VA = "0x189A36E00")]
		private IEnumerable<Collider> OXVEMHITAPQ()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(RVA = "0x9A36B60", Offset = "0x9A35560", VA = "0x189A36B60")]
		public void LFWLPKERMIZ(List<ObjectLocalId> a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(RVA = "0x9A37D30", Offset = "0x9A36730", VA = "0x189A37D30")]
		private void XTXODEVFEBN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000024")]
		[Cpp2IlInjected.Address(RVA = "0x9A36A00", Offset = "0x9A35400", VA = "0x189A36A00")]
		private void LDBDWTMSQEA(Material a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(RVA = "0x9A362F0", Offset = "0x9A34CF0", VA = "0x189A362F0")]
		private void FIDKCVWTUBO(Vector2 a, Vector2 b, Camera c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(RVA = "0x9A359F0", Offset = "0x9A343F0", VA = "0x189A359F0")]
		private void EJFIOHVHDHN(Vector2 a, Vector2 b, Camera c, Vector2 d, Vector2 e, Vector3 f, Vector3 g, Vector3 h, Vector3 i)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(RVA = "0x9A374E0", Offset = "0x9A35EE0", VA = "0x189A374E0")]
		private void UHBPHADOVWQ(Camera a, Vector3 b, Vector3 c, Vector3 d, Vector3 e, Vector3 f, Vector3 g)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(RVA = "0x9A37420", Offset = "0x9A35E20", VA = "0x189A37420")]
		private void TBDTQKUKWTW()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(RVA = "0x9A367E0", Offset = "0x9A351E0", VA = "0x189A367E0")]
		private void ILCNMLRECFP(Vector3 a, Vector3 b, Vector3 c, Vector3 d, Vector3 e)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002A")]
		[Cpp2IlInjected.Address(RVA = "0x9A36740", Offset = "0x9A35140", VA = "0x189A36740")]
		private void HARQXXLRGUG()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000B")]
	public class ENXAANHAXGV<a>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000025")]
		private BMPNBFKSHPG<a> GLBHCFMDUHG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000026")]
		private RYZABLKKTOL<a> AYBMBRZIXLV;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000027")]
		private List<a> AHYVXUORMXO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000028")]
		private List<a> JBHDVEQNOAV;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000029")]
		private List<a> ICVIEEVKVMC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400002A")]
		private List<a> QFTTDZWCPJH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400002B")]
		private List<a> WAXOBMDBRWL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400002C")]
		private List<a> NSZLIEFFYMG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400002D")]
		private OngoingSelectionMode WKNQHFNLLEZ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400002E")]
		private ECESLFBYHJS KEBBLYYFABW;

		[Cpp2IlInjected.Token(Token = "0x600002C")]
		[Cpp2IlInjected.Address(RVA = "0x5B4E610", Offset = "0x5B4D010", VA = "0x185B4E610")]
		public ENXAANHAXGV(BMPNBFKSHPG<a> a, RYZABLKKTOL<a> b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002D")]
		[Cpp2IlInjected.Address(RVA = "0x5B4A8F0", Offset = "0x5B492F0", VA = "0x185B4A8F0")]
		public void Start(OngoingSelectionMode mode = OngoingSelectionMode.Add)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(RVA = "0x5B4AA50", Offset = "0x5B49450", VA = "0x185B4AA50")]
		public void YESCVLIMPUK(IEnumerable<Collider> a, List<a> b, Vector3 c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002F")]
		[Cpp2IlInjected.Address(RVA = "0x5B4A7A0", Offset = "0x5B491A0", VA = "0x185B4A7A0")]
		public bool EJHTALTWMIZ()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000030")]
		[Cpp2IlInjected.Address(RVA = "0x5B4A450", Offset = "0x5B48E50", VA = "0x185B4A450")]
		[CompilerGenerated]
		private bool BINZKUKWZKA(a a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000031")]
		[Cpp2IlInjected.Address(RVA = "0x5B4A5B0", Offset = "0x5B48FB0", VA = "0x185B4A5B0")]
		[CompilerGenerated]
		private bool BITGIBEUIVJ(a a)
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
	public class PTCOBNUPTQN
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000032")]
		public readonly ShapeColor SBTEGNBQFBT;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x4000033")]
		public readonly ShapeMaterial HSIUGFJSEDV;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000034")]
		public readonly float OUBFYJHONHX;

		[Cpp2IlInjected.Token(Token = "0x17000006")]
		public bool FGCJYTKVFEA
		{
			[Cpp2IlInjected.Token(Token = "0x6000033")]
			[Cpp2IlInjected.Address(RVA = "0x9A3AA00", Offset = "0x9A39400", VA = "0x189A3AA00")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(RVA = "0x9A3AA20", Offset = "0x9A39420", VA = "0x189A3AA20")]
		public PTCOBNUPTQN(ShapeColor a, ShapeMaterial b, float c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(RVA = "0x9A3A8C0", Offset = "0x9A392C0", VA = "0x189A3A8C0", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(RVA = "0x9A3A970", Offset = "0x9A39370", VA = "0x189A3A970", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000E")]
	public abstract class CreationOperationException : Exception, VIKDRDGTKDP
	{
		[Cpp2IlInjected.Token(Token = "0x17000007")]
		public abstract string UserFriendlyErrorMessage
		{
			[Cpp2IlInjected.Token(Token = "0x6000036")]
			[Cpp2IlInjected.Address(Slot = "15")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(RVA = "0x9A38C60", Offset = "0x9A37660", VA = "0x189A38C60")]
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
			[Cpp2IlInjected.Address(RVA = "0x9A3A5D0", Offset = "0x9A38FD0", VA = "0x189A3A5D0", Slot = "15")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000038")]
		[Cpp2IlInjected.Address(RVA = "0x9A3A500", Offset = "0x9A38F00", VA = "0x189A3A500")]
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
			[Cpp2IlInjected.Address(RVA = "0xD40870", Offset = "0xD3F270", VA = "0x180D40870", Slot = "15")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600003B")]
		[Cpp2IlInjected.Address(RVA = "0x9A3B1B0", Offset = "0x9A39BB0", VA = "0x189A3B1B0")]
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
			[Cpp2IlInjected.Address(RVA = "0x9A39F80", Offset = "0x9A38980", VA = "0x189A39F80")]
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
			[Cpp2IlInjected.Address(RVA = "0x9A39FB0", Offset = "0x9A389B0", VA = "0x189A39FB0")]
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
			[Cpp2IlInjected.Address(RVA = "0xDBDA60", Offset = "0xDBC460", VA = "0x180DBDA60")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600003D")]
		[Cpp2IlInjected.Address(RVA = "0x9A3AFC0", Offset = "0x9A399C0", VA = "0x189A3AFC0")]
		public ShapeSwatchInfo(ShapeColor colorId, ShapeMaterial materialId, float uvScale)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003E")]
		[Cpp2IlInjected.Address(RVA = "0x9A3AE70", Offset = "0x9A39870", VA = "0x189A3AE70")]
		public static ShapeSwatchInfo[] LPPUJDWSBEN(string a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600003F")]
		[Cpp2IlInjected.Address(RVA = "0x9A3AE00", Offset = "0x9A39800", VA = "0x189A3AE00")]
		public static string IOQDLPDRYOY(ShapeSwatchInfo[] a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000040")]
		[Cpp2IlInjected.Address(RVA = "0x9A3ACA0", Offset = "0x9A396A0", VA = "0x189A3ACA0")]
		public ShapeSwatchInfo Clone()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000041")]
		[Cpp2IlInjected.Address(RVA = "0x9A3AD30", Offset = "0x9A39730", VA = "0x189A3AD30")]
		public bool DHSPBWGEQOD(ShapeSwatchInfo a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000042")]
		[Cpp2IlInjected.Address(RVA = "0x9A3AD80", Offset = "0x9A39780", VA = "0x189A3AD80")]
		public bool DHSPBWGEQOD(ShapeMaterial a, ShapeColor b, float c)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000043")]
		[Cpp2IlInjected.Address(RVA = "0x9A3ADC0", Offset = "0x9A397C0", VA = "0x189A3ADC0")]
		public bool INEHRGNJOAX()
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
		public VEQFKCGUGCZ<ConfigurableSubpiece, Collider[], Collider[]> OnCollidersChanged;

		[Cpp2IlInjected.Token(Token = "0x1700000B")]
		public XFARLVHHMOQ YRPXUNSQYAL
		{
			[Cpp2IlInjected.Token(Token = "0x600004C")]
			[Cpp2IlInjected.Address(RVA = "0xD161A0", Offset = "0xD14BA0", VA = "0x180D161A0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600004D")]
			[Cpp2IlInjected.Address(RVA = "0xD15990", Offset = "0xD14390", VA = "0x180D15990")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000C")]
		public Collider[] MVHYODSCONN
		{
			[Cpp2IlInjected.Token(Token = "0x600004E")]
			[Cpp2IlInjected.Address(RVA = "0xD11BE0", Offset = "0xD105E0", VA = "0x180D11BE0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000D")]
		public Renderer[] OKPOASBZOQC
		{
			[Cpp2IlInjected.Token(Token = "0x600004F")]
			[Cpp2IlInjected.Address(RVA = "0xD11C00", Offset = "0xD10600", VA = "0x180D11C00")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000001")]
		public event Action<XFARLVHHMOQ> IUFEYWJKKYC
		{
			[Cpp2IlInjected.Token(Token = "0x6000050")]
			[Cpp2IlInjected.Address(RVA = "0x9A38B00", Offset = "0x9A37500", VA = "0x189A38B00")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000051")]
			[Cpp2IlInjected.Address(RVA = "0x9A38BB0", Offset = "0x9A375B0", VA = "0x189A38BB0")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000052")]
		[Cpp2IlInjected.Address(RVA = "0x9A387C0", Offset = "0x9A371C0", VA = "0x189A387C0")]
		private void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000053")]
		[Cpp2IlInjected.Address(RVA = "0x9A38870", Offset = "0x9A37270", VA = "0x189A38870")]
		public void Destroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000054")]
		[Cpp2IlInjected.Address(RVA = "0x9A388C0", Offset = "0x9A372C0", VA = "0x189A388C0")]
		public void SetIConfigurable(XFARLVHHMOQ newConfigurable)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000055")]
		[Cpp2IlInjected.Address(RVA = "0x9A387D0", Offset = "0x9A371D0", VA = "0x189A387D0")]
		public void ChangeCollidersAndRenderers(Collider[] newColliders, Renderer[] newRenderers)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000056")]
		[Cpp2IlInjected.Address(RVA = "0x9A389F0", Offset = "0x9A373F0", VA = "0x189A389F0")]
		public void ValidateCollidersAndRenderers()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000057")]
		[Cpp2IlInjected.Address(RVA = "0x66067B0", Offset = "0x66051B0", VA = "0x1866067B0")]
		public void RunConfigurationSpecialActions(XFARLVHHMOQ configurable)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000058")]
		[Cpp2IlInjected.Address(RVA = "0x9A38A80", Offset = "0x9A37480", VA = "0x189A38A80")]
		public ConfigurableSubpiece()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000017")]
	public interface DWIOKZXUMKY
	{
		[Cpp2IlInjected.Token(Token = "0x1700000E")]
		bool YYCQHDGNDNJ
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
	public interface SKKFRJDRDEL
	{
		[Cpp2IlInjected.Token(Token = "0x600005C")]
		[Cpp2IlInjected.Address(Slot = "0")]
		IEnumerable<PTCOBNUPTQN> GetColorableSnapshots();
	}
	[Cpp2IlInjected.Token(Token = "0x2000019")]
	public interface XFMPILDOEFT
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
	public interface BTEDBCBIVBM
	{
		[Cpp2IlInjected.Token(Token = "0x1700000F")]
		GameObject HSDZDWOXSYD
		{
			[Cpp2IlInjected.Token(Token = "0x6000062")]
			[Cpp2IlInjected.Address(Slot = "2")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000010")]
		Guid TYJOXAKCMXB
		{
			[Cpp2IlInjected.Token(Token = "0x6000063")]
			[Cpp2IlInjected.Address(Slot = "3")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000011")]
		string EDJPGUEQTOV
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
		Vector3 DUEENDPJJQB
		{
			[Cpp2IlInjected.Token(Token = "0x6000066")]
			[Cpp2IlInjected.Address(Slot = "6")]
			get;
			[Cpp2IlInjected.Token(Token = "0x6000067")]
			[Cpp2IlInjected.Address(Slot = "7")]
			set;
		}

		[Cpp2IlInjected.Token(Token = "0x17000014")]
		Vector3 UAQIHVSIKOG
		{
			[Cpp2IlInjected.Token(Token = "0x6000068")]
			[Cpp2IlInjected.Address(Slot = "8")]
			get;
			[Cpp2IlInjected.Token(Token = "0x6000069")]
			[Cpp2IlInjected.Address(Slot = "9")]
			set;
		}

		[Cpp2IlInjected.Token(Token = "0x17000015")]
		Quaternion NBWFGXWVQCU
		{
			[Cpp2IlInjected.Token(Token = "0x600006A")]
			[Cpp2IlInjected.Address(Slot = "10")]
			get;
			[Cpp2IlInjected.Token(Token = "0x600006B")]
			[Cpp2IlInjected.Address(Slot = "11")]
			set;
		}

		[Cpp2IlInjected.Token(Token = "0x17000016")]
		Quaternion UBMXPZFLWJF
		{
			[Cpp2IlInjected.Token(Token = "0x600006C")]
			[Cpp2IlInjected.Address(Slot = "12")]
			get;
			[Cpp2IlInjected.Token(Token = "0x600006D")]
			[Cpp2IlInjected.Address(Slot = "13")]
			set;
		}

		[Cpp2IlInjected.Token(Token = "0x17000017")]
		float WSLARIIVJKM
		{
			[Cpp2IlInjected.Token(Token = "0x600006E")]
			[Cpp2IlInjected.Address(Slot = "14")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000018")]
		float SJIQQPDCMHV
		{
			[Cpp2IlInjected.Token(Token = "0x600006F")]
			[Cpp2IlInjected.Address(Slot = "15")]
			get;
			[Cpp2IlInjected.Token(Token = "0x6000070")]
			[Cpp2IlInjected.Address(Slot = "16")]
			set;
		}

		[Cpp2IlInjected.Token(Token = "0x17000019")]
		Vector3 NVBDWYFJLJI
		{
			[Cpp2IlInjected.Token(Token = "0x6000071")]
			[Cpp2IlInjected.Address(Slot = "17")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x1700001A")]
		Vector3 RJTCYFDNKQF
		{
			[Cpp2IlInjected.Token(Token = "0x6000072")]
			[Cpp2IlInjected.Address(Slot = "18")]
			get;
			[Cpp2IlInjected.Token(Token = "0x6000073")]
			[Cpp2IlInjected.Address(Slot = "19")]
			set;
		}

		[Cpp2IlInjected.Token(Token = "0x1700001B")]
		bool AHSYZZTGXSG
		{
			[Cpp2IlInjected.Token(Token = "0x6000074")]
			[Cpp2IlInjected.Address(Slot = "20")]
			set;
		}

		[Cpp2IlInjected.Token(Token = "0x1700001C")]
		XFARLVHHMOQ YRPXUNSQYAL
		{
			[Cpp2IlInjected.Token(Token = "0x6000075")]
			[Cpp2IlInjected.Address(Slot = "21")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x1700001D")]
		[CanBeNull]
		NPKRRSHNFBA XDCVCCJCTRN
		{
			[Cpp2IlInjected.Token(Token = "0x6000076")]
			[Cpp2IlInjected.Address(Slot = "22")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x14000002")]
		event Action DYMXOJQCHPV;

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
	public interface LXEJKVDFBBR
	{
		[Cpp2IlInjected.Token(Token = "0x1700001E")]
		bool HJMKGQCCLHJ
		{
			[Cpp2IlInjected.Token(Token = "0x600008D")]
			[Cpp2IlInjected.Address(Slot = "19")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x1700001F")]
		bool JTUEPPHEGTQ
		{
			[Cpp2IlInjected.Token(Token = "0x600008E")]
			[Cpp2IlInjected.Address(Slot = "20")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000020")]
		Vector3 ICYOMUJHLLN
		{
			[Cpp2IlInjected.Token(Token = "0x600008F")]
			[Cpp2IlInjected.Address(Slot = "21")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000021")]
		Vector3 ENAVCBTCTQR
		{
			[Cpp2IlInjected.Token(Token = "0x6000090")]
			[Cpp2IlInjected.Address(Slot = "22")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000022")]
		bool PPBUJFQZDSN
		{
			[Cpp2IlInjected.Token(Token = "0x6000091")]
			[Cpp2IlInjected.Address(Slot = "23")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000023")]
		bool MHLXYZWOZWU
		{
			[Cpp2IlInjected.Token(Token = "0x6000092")]
			[Cpp2IlInjected.Address(Slot = "24")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000024")]
		bool BBLLVGXHVXB
		{
			[Cpp2IlInjected.Token(Token = "0x6000093")]
			[Cpp2IlInjected.Address(Slot = "25")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000025")]
		bool VOERPZZRNXI
		{
			[Cpp2IlInjected.Token(Token = "0x6000094")]
			[Cpp2IlInjected.Address(Slot = "26")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000026")]
		bool RCADVCXMYNF
		{
			[Cpp2IlInjected.Token(Token = "0x6000095")]
			[Cpp2IlInjected.Address(Slot = "27")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000027")]
		bool EJFMWSRLAMD
		{
			[Cpp2IlInjected.Token(Token = "0x6000096")]
			[Cpp2IlInjected.Address(Slot = "28")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000028")]
		bool RUELATKXDLU
		{
			[Cpp2IlInjected.Token(Token = "0x6000097")]
			[Cpp2IlInjected.Address(Slot = "29")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000029")]
		bool ZNMGFMCHTUL
		{
			[Cpp2IlInjected.Token(Token = "0x6000098")]
			[Cpp2IlInjected.Address(Slot = "30")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x1700002A")]
		bool MBAKRUGZLEB
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
	public interface AUXYDZWTUXT
	{
		[Cpp2IlInjected.Token(Token = "0x600009E")]
		[Cpp2IlInjected.Address(Slot = "0")]
		bool IMJGOUBOCKG([In] Vector3 origin, [In] Vector3 direction, Vector3 a, Vector3 b);
	}
	[Cpp2IlInjected.Token(Token = "0x200001D")]
	public interface NWIFKEBSWCU
	{
		[Cpp2IlInjected.Token(Token = "0x1700002B")]
		bool HEYYGZFGLIB
		{
			[Cpp2IlInjected.Token(Token = "0x600009F")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x1700002C")]
		HFGUPORPTXK FIVKQECZQQW
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
	public interface ZRVIQBOTQDO
	{
		[Cpp2IlInjected.Token(Token = "0x1700002D")]
		bool FNJBDVLYVOT
		{
			[Cpp2IlInjected.Token(Token = "0x60000A4")]
			[Cpp2IlInjected.Address(Slot = "2")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x1700002E")]
		UQKLHVFTFHP QAMBKOECQVH
		{
			[Cpp2IlInjected.Token(Token = "0x60000A5")]
			[Cpp2IlInjected.Address(Slot = "3")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x14000003")]
		event Action<bool> JMVAAZDGDWY;

		[Cpp2IlInjected.Token(Token = "0x60000A6")]
		[Cpp2IlInjected.Address(Slot = "4")]
		void LocalPlayerTakeAuthority();

		[Cpp2IlInjected.Token(Token = "0x60000A7")]
		[Cpp2IlInjected.Address(Slot = "5")]
		void TransferOwnership(int actorNumber);

		[Cpp2IlInjected.Token(Token = "0x60000A8")]
		[Cpp2IlInjected.Address(Slot = "6")]
		KDSOOWCXYNX GetCulprit(CreationResult failureReason);
	}
	[Cpp2IlInjected.Token(Token = "0x200001F")]
	public interface MIBTSKLMBBK
	{
		[Cpp2IlInjected.Token(Token = "0x1700002F")]
		IEnumerable<NavMeshSupport.Restriction> ZKXCJHMIQUG
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
	public interface DDOSYGVCRPD
	{
	}
	[Cpp2IlInjected.Token(Token = "0x2000021")]
	public interface UBBHDUWSIDF
	{
		[Cpp2IlInjected.Token(Token = "0x60000AC")]
		[Cpp2IlInjected.Address(Slot = "0")]
		void Reset();

		[Cpp2IlInjected.Token(Token = "0x60000AD")]
		[Cpp2IlInjected.Address(Slot = "1")]
		void RequestRPCReset();
	}
	[Cpp2IlInjected.Token(Token = "0x2000022")]
	public interface NYXGLJKVKWD
	{
		[Cpp2IlInjected.Token(Token = "0x17000030")]
		bool PCJQQWJEBUA
		{
			[Cpp2IlInjected.Token(Token = "0x60000AE")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000031")]
		bool KLTOGRIPZEP
		{
			[Cpp2IlInjected.Token(Token = "0x60000AF")]
			[Cpp2IlInjected.Address(Slot = "1")]
			get;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000023")]
	public interface EWQTBQGDQOG
	{
		[Cpp2IlInjected.Token(Token = "0x17000032")]
		int RMSDQXNRJKQ
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
	[Cpp2IlInjected.Token(Token = "0x2000024")]
	public interface DVPZHJCZJED
	{
		[Cpp2IlInjected.Token(Token = "0x17000033")]
		bool EEUYOHAPYPN
		{
			[Cpp2IlInjected.Token(Token = "0x60000B6")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
			[Cpp2IlInjected.Token(Token = "0x60000B7")]
			[Cpp2IlInjected.Address(Slot = "1")]
			set;
		}

		[Cpp2IlInjected.Token(Token = "0x17000034")]
		CanSaveObjectIntoInventionResultType SFWWOGWQJOU
		{
			[Cpp2IlInjected.Token(Token = "0x60000B9")]
			[Cpp2IlInjected.Address(Slot = "3")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000035")]
		bool YQTTOZVEJTJ
		{
			[Cpp2IlInjected.Token(Token = "0x60000BA")]
			[Cpp2IlInjected.Address(Slot = "4")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000036")]
		bool FFSWMMPURYU
		{
			[Cpp2IlInjected.Token(Token = "0x60000BB")]
			[Cpp2IlInjected.Address(Slot = "5")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000037")]
		bool NIJZRBVBCVW
		{
			[Cpp2IlInjected.Token(Token = "0x60000BC")]
			[Cpp2IlInjected.Address(Slot = "6")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000038")]
		bool TKRYWNCWRTT
		{
			[Cpp2IlInjected.Token(Token = "0x60000BD")]
			[Cpp2IlInjected.Address(Slot = "7")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000039")]
		bool NVRVHSCQHZQ
		{
			[Cpp2IlInjected.Token(Token = "0x60000BE")]
			[Cpp2IlInjected.Address(Slot = "8")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x1700003A")]
		IEnumerable<Collider> GHLOGPAKBXD
		{
			[Cpp2IlInjected.Token(Token = "0x60000BF")]
			[Cpp2IlInjected.Address(Slot = "9")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x1700003B")]
		RotatedBounds? ABBOCCLHXFT
		{
			[Cpp2IlInjected.Token(Token = "0x60000C0")]
			[Cpp2IlInjected.Address(Slot = "10")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x1700003C")]
		bool XNOLOVYGBZF
		{
			[Cpp2IlInjected.Token(Token = "0x60000C1")]
			[Cpp2IlInjected.Address(Slot = "11")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x1700003D")]
		bool MIJMIQYSJHH
		{
			[Cpp2IlInjected.Token(Token = "0x60000C2")]
			[Cpp2IlInjected.Address(Slot = "12")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x60000B8")]
		[Cpp2IlInjected.Address(Slot = "2")]
		CostInfo GetSandboxResourceCost(bool verifyIntegrity = true);
	}
	[Cpp2IlInjected.Token(Token = "0x2000025")]
	public interface RKFCXGYSRDI
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
	[Cpp2IlInjected.Token(Token = "0x2000026")]
	public interface OJZNEJWCHSP
	{
		[Cpp2IlInjected.Token(Token = "0x1700003E")]
		object PFNSBMRTHXY
		{
			[Cpp2IlInjected.Token(Token = "0x60000C6")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x1700003F")]
		Type HWTULNPUBGD
		{
			[Cpp2IlInjected.Token(Token = "0x60000C7")]
			[Cpp2IlInjected.Address(Slot = "1")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000040")]
		Guid LRZNGWPNMUD
		{
			[Cpp2IlInjected.Token(Token = "0x60000C8")]
			[Cpp2IlInjected.Address(Slot = "2")]
			get;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000027")]
	public interface XFARLVHHMOQ
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
		event Action<string> VNJGMUCAYOD;

		[Cpp2IlInjected.Token(Token = "0x14000005")]
		event Action<XFARLVHHMOQ> PJKVEKARECA;

		[Cpp2IlInjected.Token(Token = "0x14000006")]
		event Action<DialogType, OKDXYUBIZFR> OCHNAFLRQQH;

		[Cpp2IlInjected.Token(Token = "0x14000007")]
		event Action LCCVLNKJMRQ;

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
	[Cpp2IlInjected.Token(Token = "0x2000028")]
	public interface YVURGERPVBU
	{
		[Cpp2IlInjected.Token(Token = "0x14000008")]
		event Action QLWZUJYPXHK;
	}
	[Cpp2IlInjected.Token(Token = "0x2000029")]
	public interface TNVIZSMGURR : XFARLVHHMOQ, FAINECAMSNF
	{
		[Cpp2IlInjected.Token(Token = "0x17000045")]
		IEnumerable<FAINECAMSNF> RVSTBJNFDFG
		{
			[Cpp2IlInjected.Token(Token = "0x60000DB")]
			[Cpp2IlInjected.Address(Slot = "1")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x60000DA")]
		[Cpp2IlInjected.Address(Slot = "0")]
		void RegisterConfigurableAddOn(FAINECAMSNF newSubConfigurable);
	}
	[Cpp2IlInjected.Token(Token = "0x200002A")]
	public interface FAINECAMSNF
	{
		[Cpp2IlInjected.Token(Token = "0x60000DC")]
		[Cpp2IlInjected.Address(Slot = "0")]
		IReadOnlyList<IDynamicUIElementData> GetConfigurableDynamicUI([Optional] IEnumerable<FAINECAMSNF> configurables);
	}
	[Cpp2IlInjected.Token(Token = "0x200002B")]
	public interface PLXCFJWMZPZ
	{
		[Cpp2IlInjected.Token(Token = "0x17000046")]
		bool SOGCMBSBNQO
		{
			[Cpp2IlInjected.Token(Token = "0x60000DD")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
			[Cpp2IlInjected.Token(Token = "0x60000DE")]
			[Cpp2IlInjected.Address(Slot = "1")]
			set;
		}

		[Cpp2IlInjected.Token(Token = "0x17000047")]
		bool MUVHJREECCH
		{
			[Cpp2IlInjected.Token(Token = "0x60000DF")]
			[Cpp2IlInjected.Address(Slot = "2")]
			get;
			[Cpp2IlInjected.Token(Token = "0x60000E0")]
			[Cpp2IlInjected.Address(Slot = "3")]
			set;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200002C")]
	public struct NavMeshSupport
	{
		[Cpp2IlInjected.Token(Token = "0x200002D")]
		public delegate NavMeshSupportStatus Restriction();

		[Cpp2IlInjected.Token(Token = "0x4000048")]
		private static readonly IEnumerable<Restriction> NoRestrictions;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000049")]
		private List<Restriction> restrictions;

		[Cpp2IlInjected.Token(Token = "0x17000048")]
		public IEnumerable<Restriction> CBXEPWTIZDH
		{
			[Cpp2IlInjected.Token(Token = "0x60000E1")]
			[Cpp2IlInjected.Address(RVA = "0x9A3A3E0", Offset = "0x9A38DE0", VA = "0x189A3A3E0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000E2")]
		[Cpp2IlInjected.Address(RVA = "0x9A3A180", Offset = "0x9A38B80", VA = "0x189A3A180")]
		public void Add(Restriction restriction)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E3")]
		[Cpp2IlInjected.Address(RVA = "0x9A3A380", Offset = "0x9A38D80", VA = "0x189A3A380")]
		public bool Remove(Restriction restriction)
		{
			return default(bool);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200002E")]
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
	[Cpp2IlInjected.Token(Token = "0x200002F")]
	public readonly struct TrialInventionInfo : BNSQREGVNIT
	{
		[Cpp2IlInjected.Token(Token = "0x17000049")]
		public int SpawningPlayerId
		{
			[Cpp2IlInjected.Token(Token = "0x60000E7")]
			[Cpp2IlInjected.Address(RVA = "0xF8BD10", Offset = "0xF8A710", VA = "0x180F8BD10", Slot = "5")]
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
			[Cpp2IlInjected.Address(RVA = "0x30F7B90", Offset = "0x30F6590", VA = "0x1830F7B90", Slot = "4")]
			[CompilerGenerated]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000E9")]
		[Cpp2IlInjected.Address(RVA = "0x9A3B010", Offset = "0x9A39A10", VA = "0x189A3B010")]
		public TrialInventionInfo(int trialSpawnTime, int spawningPlayerId)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000030")]
	public interface VWITBGLQTGK : ANODUGMJHFL
	{
		[Cpp2IlInjected.Token(Token = "0x400004F")]
		static readonly int GXITOJBYYDF;

		[Cpp2IlInjected.Token(Token = "0x4000050")]
		static readonly Guid WYAABBRLKFE;

		[Cpp2IlInjected.Token(Token = "0x1700004B")]
		Guid SPZMXPGJIFS
		{
			[Cpp2IlInjected.Token(Token = "0x60000EA")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x1700004C")]
		long ZZKYOLWSDJT
		{
			[Cpp2IlInjected.Token(Token = "0x60000EB")]
			[Cpp2IlInjected.Address(Slot = "1")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x1700004D")]
		[Obsolete("This is not used - version tracking is done at the server level as collections of InventionId")]
		int MDXIABDKPBJ
		{
			[Cpp2IlInjected.Token(Token = "0x60000EC")]
			[Cpp2IlInjected.Address(Slot = "2")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x60000ED")]
		[Cpp2IlInjected.Address(RVA = "0x9A3B220", Offset = "0x9A39C20", VA = "0x189A3B220")]
		static VWITBGLQTGK()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000031")]
	[Obsolete("This is not used by anything and does not give us full provenance tracking")]
	public interface DMXBIGORXVA
	{
		[Cpp2IlInjected.Token(Token = "0x1700004E")]
		[Obsolete("This is not currently consumed and does not give us full provenance tracking, however it does contain information that may prevent 'contamination' of invention contents by other non-monetizable inventions")]
		bool PUOFXCHZYEO
		{
			[Cpp2IlInjected.Token(Token = "0x60000EE")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000032")]
	public interface NPKRRSHNFBA
	{
		[Cpp2IlInjected.Token(Token = "0x1700004F")]
		bool NJWLBFUHKDZ
		{
			[Cpp2IlInjected.Token(Token = "0x60000EF")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x60000F0")]
		[Cpp2IlInjected.Address(Slot = "1")]
		[CanBeNull]
		VWITBGLQTGK GOUQHFIWEBE();

		[Cpp2IlInjected.Token(Token = "0x60000F1")]
		[Cpp2IlInjected.Address(Slot = "2")]
		[CanBeNull]
		DMXBIGORXVA DZRIYBTPSQS();

		[Cpp2IlInjected.Token(Token = "0x60000F2")]
		[Cpp2IlInjected.Address(Slot = "3")]
		void YBSSLHLNKJF(Guid a, long b, int c, bool d);

		[Cpp2IlInjected.Token(Token = "0x60000F3")]
		[Cpp2IlInjected.Address(Slot = "4")]
		void YBSSLHLNKJF(NPKRRSHNFBA a);

		[Cpp2IlInjected.Token(Token = "0x60000F4")]
		[Cpp2IlInjected.Address(Slot = "5")]
		void SerializeTo(InventionPieceData data);
	}
	[Cpp2IlInjected.Token(Token = "0x2000033")]
	public static class CYSBBYVRSYT
	{
		[Cpp2IlInjected.Token(Token = "0x60000F5")]
		[Cpp2IlInjected.Address(RVA = "0x9A386A0", Offset = "0x9A370A0", VA = "0x189A386A0")]
		public static void DeserializeFrom(this NPKRRSHNFBA that, InventionPieceData inventionPieceData)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000034")]
	public interface ANODUGMJHFL
	{
		[Cpp2IlInjected.Token(Token = "0x17000050")]
		bool MCFAFYRRNBA
		{
			[Cpp2IlInjected.Token(Token = "0x60000F6")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x60000F7")]
		[Cpp2IlInjected.Address(Slot = "1")]
		[CanBeNull]
		BNSQREGVNIT MBYSZIHMKVB();

		[Cpp2IlInjected.Token(Token = "0x60000F8")]
		[Cpp2IlInjected.Address(Slot = "2")]
		bool MBYSZIHMKVB([Out] TrialInventionInfo a);

		[Cpp2IlInjected.Token(Token = "0x60000F9")]
		[Cpp2IlInjected.Address(Slot = "3")]
		void JNNSNVJOMKI(KDSOOWCXYNX a);

		[Cpp2IlInjected.Token(Token = "0x60000FA")]
		[Cpp2IlInjected.Address(Slot = "4")]
		void RUSZKICNXLF();
	}
	[Cpp2IlInjected.Token(Token = "0x2000035")]
	public interface BNSQREGVNIT
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
	[Cpp2IlInjected.Token(Token = "0x2000036")]
	public class InventionTrackingViaSynchronizedField : NPKRRSHNFBA, VWITBGLQTGK, ANODUGMJHFL, BNSQREGVNIT, DMXBIGORXVA
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000051")]
		private BZAMOYJTOAY<Guid, ObscuredLong, ObscuredInt, ObscuredBool> UUQVEEZSQLW;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000052")]
		private CALIVTTBCCJ<ObscuredBool, ObscuredInt, ObscuredInt> GHWGGSUBLOZ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000053")]
		private RRNetworkBehavior GXTZTHXXLWB;

		[Cpp2IlInjected.Token(Token = "0x4000054")]
		private static readonly Log WVPIFBCBMJC;

		[Cpp2IlInjected.Token(Token = "0x17000053")]
		private Guid SPZMXPGJIFS
		{
			[Cpp2IlInjected.Token(Token = "0x60000FE")]
			[Cpp2IlInjected.Address(RVA = "0x9A38D60", Offset = "0x9A37760", VA = "0x189A38D60")]
			get
			{
				return default(Guid);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000054")]
		private long ZZKYOLWSDJT
		{
			[Cpp2IlInjected.Token(Token = "0x60000FF")]
			[Cpp2IlInjected.Address(RVA = "0x9A39210", Offset = "0x9A37C10", VA = "0x189A39210")]
			get
			{
				return default(long);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000055")]
		private int MDXIABDKPBJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000100")]
			[Cpp2IlInjected.Address(RVA = "0x9A394C0", Offset = "0x9A37EC0", VA = "0x189A394C0")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000056")]
		private bool PUOFXCHZYEO
		{
			[Cpp2IlInjected.Token(Token = "0x6000101")]
			[Cpp2IlInjected.Address(RVA = "0x9A39430", Offset = "0x9A37E30", VA = "0x189A39430")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000057")]
		private bool MCFAFYRRNBA
		{
			[Cpp2IlInjected.Token(Token = "0x6000102")]
			[Cpp2IlInjected.Address(RVA = "0x9A38F50", Offset = "0x9A37950", VA = "0x189A38F50")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000058")]
		private int IVTEOKVAVMT
		{
			[Cpp2IlInjected.Token(Token = "0x6000103")]
			[Cpp2IlInjected.Address(RVA = "0x9A39B40", Offset = "0x9A38540", VA = "0x189A39B40")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000059")]
		private int HHJFUXHYGBW
		{
			[Cpp2IlInjected.Token(Token = "0x6000104")]
			[Cpp2IlInjected.Address(RVA = "0x9A392B0", Offset = "0x9A37CB0", VA = "0x189A392B0")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700005A")]
		public bool NJWLBFUHKDZ
		{
			[Cpp2IlInjected.Token(Token = "0x6000107")]
			[Cpp2IlInjected.Address(RVA = "0x9A38DD0", Offset = "0x9A377D0", VA = "0x189A38DD0", Slot = "4")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700005B")]
		private Guid DHPTACJWNES
		{
			[Cpp2IlInjected.Token(Token = "0x600010C")]
			[Cpp2IlInjected.Address(RVA = "0x9A38D60", Offset = "0x9A37760", VA = "0x189A38D60", Slot = "10")]
			get
			{
				return default(Guid);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700005C")]
		private long BYBSZSADHZN
		{
			[Cpp2IlInjected.Token(Token = "0x600010D")]
			[Cpp2IlInjected.Address(RVA = "0x9A39200", Offset = "0x9A37C00", VA = "0x189A39200", Slot = "11")]
			get
			{
				return default(long);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700005D")]
		private int GXZICNLVRNH
		{
			[Cpp2IlInjected.Token(Token = "0x600010E")]
			[Cpp2IlInjected.Address(RVA = "0x9A39560", Offset = "0x9A37F60", VA = "0x189A39560", Slot = "12")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700005E")]
		private int DEOXDCUBBWC
		{
			[Cpp2IlInjected.Token(Token = "0x600010F")]
			[Cpp2IlInjected.Address(RVA = "0x9A391F0", Offset = "0x9A37BF0", VA = "0x189A391F0", Slot = "19")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700005F")]
		private int VXFQEEPQKMR
		{
			[Cpp2IlInjected.Token(Token = "0x6000110")]
			[Cpp2IlInjected.Address(RVA = "0x9A39420", Offset = "0x9A37E20", VA = "0x189A39420", Slot = "18")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000060")]
		private bool VOJRPICRKFC
		{
			[Cpp2IlInjected.Token(Token = "0x6000111")]
			[Cpp2IlInjected.Address(RVA = "0x9A39550", Offset = "0x9A37F50", VA = "0x189A39550", Slot = "20")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000061")]
		private bool BMBAZLVTJHF
		{
			[Cpp2IlInjected.Token(Token = "0x6000112")]
			[Cpp2IlInjected.Address(RVA = "0x9A38E80", Offset = "0x9A37880", VA = "0x189A38E80", Slot = "13")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000FD")]
		[Cpp2IlInjected.Address(RVA = "0x9A39C60", Offset = "0x9A38660", VA = "0x189A39C60")]
		public InventionTrackingViaSynchronizedField(RRNetworkBehavior owningBehavior, string syncKey, Guid instanceId, long inventionId, int versionNumber, bool originallyFromOtherInvention)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000105")]
		[Cpp2IlInjected.Address(RVA = "0x9A39370", Offset = "0x9A37D70", VA = "0x189A39370", Slot = "9")]
		public void SerializeTo(InventionPieceData data)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000106")]
		[Cpp2IlInjected.Address(RVA = "0x9A38E90", Offset = "0x9A37890", VA = "0x189A38E90")]
		public static InventionPieceData GTOXPQRTKLF(Guid a, long b, int c, bool d)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000108")]
		[Cpp2IlInjected.Address(RVA = "0x9A38E50", Offset = "0x9A37850", VA = "0x189A38E50", Slot = "5")]
		public VWITBGLQTGK GOUQHFIWEBE()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000109")]
		[Cpp2IlInjected.Address(RVA = "0x9A38E50", Offset = "0x9A37850", VA = "0x189A38E50", Slot = "6")]
		public DMXBIGORXVA DZRIYBTPSQS()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600010A")]
		[Cpp2IlInjected.Address(RVA = "0x9A39970", Offset = "0x9A38370", VA = "0x189A39970", Slot = "7")]
		public void YBSSLHLNKJF(Guid a, long b, int c, bool d)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600010B")]
		[Cpp2IlInjected.Address(RVA = "0x9A39680", Offset = "0x9A38080", VA = "0x189A39680", Slot = "8")]
		public void YBSSLHLNKJF(NPKRRSHNFBA a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000113")]
		[Cpp2IlInjected.Address(RVA = "0x9A39340", Offset = "0x9A37D40", VA = "0x189A39340", Slot = "14")]
		private BNSQREGVNIT SCNPBGRCTEQ()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000114")]
		[Cpp2IlInjected.Address(RVA = "0x9A38FE0", Offset = "0x9A379E0", VA = "0x189A38FE0", Slot = "15")]
		public bool MBYSZIHMKVB([Out] TrialInventionInfo a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000115")]
		[Cpp2IlInjected.Address(RVA = "0x9A39040", Offset = "0x9A37A40", VA = "0x189A39040", Slot = "16")]
		private void MPNNNJIMHTF(KDSOOWCXYNX a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000116")]
		[Cpp2IlInjected.Address(RVA = "0x9A39570", Offset = "0x9A37F70", VA = "0x189A39570", Slot = "17")]
		private void XVBJGAVQJPS()
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
