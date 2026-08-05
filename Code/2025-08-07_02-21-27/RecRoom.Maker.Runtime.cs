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
		[Cpp2IlInjected.Address(RVA = "0x8A6AD30", Offset = "0x8A69930", VA = "0x188A6AD30", Slot = "4")]
		public override void Register()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0xB3E190", Offset = "0xB3CD90", VA = "0x180B3E190")]
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
		public class DNUFRFNVXRG : TBEDMVTRVED<OutlineRequest>
		{
			[Cpp2IlInjected.Token(Token = "0x17000001")]
			public bool HJSDDFNTWQO
			{
				[Cpp2IlInjected.Token(Token = "0x6000009")]
				[Cpp2IlInjected.Address(RVA = "0x8A69480", Offset = "0x8A68080", VA = "0x188A69480")]
				get
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x600000A")]
			[Cpp2IlInjected.Address(RVA = "0x8A693A0", Offset = "0x8A67FA0", VA = "0x188A693A0")]
			public bool FLUUMCNOXQV(ObjectLocalId a)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600000B")]
			[Cpp2IlInjected.Address(RVA = "0x8A693C0", Offset = "0x8A67FC0", VA = "0x188A693C0")]
			public OutlineRequest GEBAZHHFWCD(ObjectLocalId a)
			{
				return default(OutlineRequest);
			}

			[Cpp2IlInjected.Token(Token = "0x600000C")]
			[Cpp2IlInjected.Address(RVA = "0x8A694C0", Offset = "0x8A680C0", VA = "0x188A694C0")]
			private int THGDMEXTXJM(ObjectLocalId a)
			{
				return default(int);
			}

			[Cpp2IlInjected.Token(Token = "0x600000D")]
			[Cpp2IlInjected.Address(RVA = "0x8A69580", Offset = "0x8A68180", VA = "0x188A69580")]
			public DNUFRFNVXRG()
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
		[Cpp2IlInjected.Address(RVA = "0x8A6B950", Offset = "0x8A6A550", VA = "0x188A6B950")]
		public OutlineRequest(ObjectLocalId requester, RequestPriority priority = RequestPriority.UgcGameplaySystem, RequestMode mode = RequestMode.TARGETED_OBJECT)
		{
		}

		[SpecialName]
		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x8A6B6A0", Offset = "0x8A6A2A0", VA = "0x188A6B6A0")]
		public static bool EOXNKNKFOQL(OutlineRequest a, OutlineRequest b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x8A6B7B0", Offset = "0x8A6A3B0", VA = "0x188A6B7B0", Slot = "4")]
		public bool Equals(OutlineRequest other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x8A6B6F0", Offset = "0x8A6A2F0", VA = "0x188A6B6F0", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x8A6B860", Offset = "0x8A6A460", VA = "0x188A6B860", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000007")]
	public interface KMMJUBXJDWP
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
	public abstract class JDSLIZBXRPF
	{
		[Cpp2IlInjected.Token(Token = "0x400000E")]
		public static HWNZTWGRXOC<Vector3> BUCXSJXQBTX;

		[Cpp2IlInjected.Token(Token = "0x400000F")]
		public static HWNZTWGRXOC<Vector3> RDUEWAWLGSY;

		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x8A6A9D0", Offset = "0x8A695D0", VA = "0x188A6A9D0", Slot = "4")]
		protected virtual void BLFTJDTKKCV(Vector3 a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0x8A6A940", Offset = "0x8A69540", VA = "0x188A6A940", Slot = "5")]
		protected virtual void AUBKDNAIUZK(Vector3 a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0xB1CF80", Offset = "0xB1BB80", VA = "0x180B1CF80")]
		protected JDSLIZBXRPF()
		{
		}
	}
}
namespace RecRoom.Maker.MarqueeHelper
{
	[Cpp2IlInjected.Token(Token = "0x2000009")]
	internal class NYYHXRATRSH : JDSLIZBXRPF
	{
		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0x8A6ADB0", Offset = "0x8A699B0", VA = "0x188A6ADB0")]
		public void QRFDAHKMGMS(Vector3 a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0x8A6ADE0", Offset = "0x8A699E0", VA = "0x188A6ADE0")]
		public void WDKKJAZYWDB(Vector3 a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x8A6AE10", Offset = "0x8A69A10", VA = "0x188A6AE10")]
		public NYYHXRATRSH()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000A")]
	public class PMZVNYZHCQL : IDisposable
	{
		[Cpp2IlInjected.Token(Token = "0x4000010")]
		private static ProfilerMarker CAJSKVCMBXO;

		[Cpp2IlInjected.Token(Token = "0x4000011")]
		private static ProfilerMarker WTGJETBVCRA;

		[Cpp2IlInjected.Token(Token = "0x4000012")]
		private static readonly string NGXJNFBHSQU;

		[Cpp2IlInjected.Token(Token = "0x4000013")]
		private static readonly string HJMCEYTERFP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000014")]
		private readonly int[] IAJWOBRHGWW;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000015")]
		private readonly int[] YFSEKUNUCRK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000016")]
		private GameObject SQKZWIBWFPQ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000017")]
		private MeshCollider IDJEUOZNXGI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000018")]
		private GameObject FZGOHIGFAPC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000019")]
		private MeshFilter HKOPIPREQCU;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400001A")]
		private Mesh UWMPLQBTIMX;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400001B")]
		private Mesh TYEFSSJQXUZ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400001C")]
		private Plane[] FNBXQMVHIYK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x400001D")]
		private Collider[] QRRUNCOIKYC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x400001E")]
		private List<ObjectLocalId> DAGEJEGGGGX;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x400001F")]
		private List<Collider> SLJFWQOTLDR;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x4000020")]
		private Vector3[] ZNLSLPTZKPY;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x4000021")]
		private Vector3 HDXPEHJYSMG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x84")]
		[Cpp2IlInjected.Token(Token = "0x4000022")]
		private Vector3 RWHDGZVHQMJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x4000023")]
		private Quaternion PKXDPIJZXZV;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
		[Cpp2IlInjected.Token(Token = "0x4000024")]
		private Vector3[] IJQYWRXWFIQ;

		[Cpp2IlInjected.Token(Token = "0x17000002")]
		private Mesh UMJWZVMPYVS
		{
			[Cpp2IlInjected.Token(Token = "0x6000017")]
			[Cpp2IlInjected.Address(RVA = "0xB13240", Offset = "0xB11E40", VA = "0x180B13240")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000018")]
			[Cpp2IlInjected.Address(RVA = "0x8A6DA80", Offset = "0x8A6C680", VA = "0x188A6DA80")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000003")]
		private Mesh GIBXATYHKNM
		{
			[Cpp2IlInjected.Token(Token = "0x6000019")]
			[Cpp2IlInjected.Address(RVA = "0xB13230", Offset = "0xB11E30", VA = "0x180B13230")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600001A")]
			[Cpp2IlInjected.Address(RVA = "0x8A6DD20", Offset = "0x8A6C920", VA = "0x188A6DD20")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000004")]
		private int OVWHRCRKOLN
		{
			[Cpp2IlInjected.Token(Token = "0x600001B")]
			[Cpp2IlInjected.Address(RVA = "0x898BB20", Offset = "0x898A720", VA = "0x18898BB20")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000005")]
		public IEnumerable<Collider> AYHXWDXLMVJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000020")]
			[Cpp2IlInjected.Address(RVA = "0x8A6CC50", Offset = "0x8A6B850", VA = "0x188A6CC50")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(RVA = "0x8A6DFF0", Offset = "0x8A6CBF0", VA = "0x188A6DFF0")]
		public PMZVNYZHCQL(Material a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0x8A6C190", Offset = "0x8A6AD90", VA = "0x188A6C190", Slot = "4")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x8A6C280", Offset = "0x8A6AE80", VA = "0x188A6C280")]
		public void EAWSPMYSLTS(Vector2 a, Vector2 b, Camera c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x8A6DCB0", Offset = "0x8A6C8B0", VA = "0x188A6DCB0")]
		public void WJYRYGCCHVE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0x8A6BB80", Offset = "0x8A6A780", VA = "0x188A6BB80")]
		private IEnumerable<Collider> CRRFJFLNCLV()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(RVA = "0x8A6D3E0", Offset = "0x8A6BFE0", VA = "0x188A6D3E0")]
		public void IZYPOMOLUDC(List<ObjectLocalId> a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(RVA = "0x8A6DAD0", Offset = "0x8A6C6D0", VA = "0x188A6DAD0")]
		private void PBDQWZEDNZM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000024")]
		[Cpp2IlInjected.Address(RVA = "0x8A6DD70", Offset = "0x8A6C970", VA = "0x188A6DD70")]
		private void YRYKFADGPGZ(Material a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(RVA = "0x8A6D6A0", Offset = "0x8A6C2A0", VA = "0x188A6D6A0")]
		private void MIQFHVLEDFH(Vector2 a, Vector2 b, Camera c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(RVA = "0x8A6C350", Offset = "0x8A6AF50", VA = "0x188A6C350")]
		private void ECKOYHODXGK(Vector2 a, Vector2 b, Camera c, Vector2 d, Vector2 e, Vector3 f, Vector3 g, Vector3 h, Vector3 i)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(RVA = "0x8A6CC60", Offset = "0x8A6B860", VA = "0x188A6CC60")]
		private void HDCSZSJACKV(Camera a, Vector3 b, Vector3 c, Vector3 d, Vector3 e, Vector3 f, Vector3 g)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(RVA = "0x8A6D630", Offset = "0x8A6C230", VA = "0x188A6D630")]
		private void KKGCVWWECRB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(RVA = "0x8A6B960", Offset = "0x8A6A560", VA = "0x188A6B960")]
		private void ASMTJZXYFRC(Vector3 a, Vector3 b, Vector3 c, Vector3 d, Vector3 e)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002A")]
		[Cpp2IlInjected.Address(RVA = "0x8A6DC10", Offset = "0x8A6C810", VA = "0x188A6DC10")]
		private void UMKDCVEIIRH()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000B")]
	public class DTZXLHGIAEE<a>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000025")]
		private SCJJEBIJALH<a> PKLDQYCBKQD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000026")]
		private YFTIQDJETNQ<a> GNEBXVJEKTU;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000027")]
		private List<a> EYGCQVCRLJZ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000028")]
		private List<a> KSKKXWQELGK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000029")]
		private List<a> YKVOBJKQXDB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400002A")]
		private List<a> LXVKACCOSSQ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400002B")]
		private List<a> SSDORPTIHJU;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400002C")]
		private List<a> BEKALBRKYFX;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400002D")]
		private OngoingSelectionMode HUHRBNLLDOC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400002E")]
		private NYYHXRATRSH ZYBMMYJDIAV;

		[Cpp2IlInjected.Token(Token = "0x600002C")]
		[Cpp2IlInjected.Address(RVA = "0x466D290", Offset = "0x466BE90", VA = "0x18466D290")]
		public DTZXLHGIAEE(SCJJEBIJALH<a> a, YFTIQDJETNQ<a> b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002D")]
		[Cpp2IlInjected.Address(RVA = "0x466CD90", Offset = "0x466B990", VA = "0x18466CD90")]
		public void Start(OngoingSelectionMode mode = OngoingSelectionMode.Add)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(RVA = "0x466A6B0", Offset = "0x46692B0", VA = "0x18466A6B0")]
		public void DGXIJJYLIDZ(IEnumerable<Collider> a, List<a> b, Vector3 c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002F")]
		[Cpp2IlInjected.Address(RVA = "0x466CBE0", Offset = "0x466B7E0", VA = "0x18466CBE0")]
		public bool SBJHABZEWMC()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000030")]
		[Cpp2IlInjected.Address(RVA = "0x466C9E0", Offset = "0x466B5E0", VA = "0x18466C9E0")]
		[CompilerGenerated]
		private bool GQICEYWVBBN(a a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000031")]
		[Cpp2IlInjected.Address(RVA = "0x466C940", Offset = "0x466B540", VA = "0x18466C940")]
		[CompilerGenerated]
		private bool GQCVHSCXRQE(a a)
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
	public class UKSUCGGDLBW
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000032")]
		public readonly ShapeColor JJFMUAEDKSU;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x4000033")]
		public readonly ShapeMaterial LANAIIHWVIM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000034")]
		public readonly float EBWOVUWGJCQ;

		[Cpp2IlInjected.Token(Token = "0x17000006")]
		public bool SNDHVNFTAHT
		{
			[Cpp2IlInjected.Token(Token = "0x6000033")]
			[Cpp2IlInjected.Address(RVA = "0x8A6EA10", Offset = "0x8A6D610", VA = "0x188A6EA10")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(RVA = "0x8A6EB70", Offset = "0x8A6D770", VA = "0x188A6EB70")]
		public UKSUCGGDLBW(ShapeColor a, ShapeMaterial b, float c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(RVA = "0x8A6EA30", Offset = "0x8A6D630", VA = "0x188A6EA30", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(RVA = "0x8A6EAE0", Offset = "0x8A6D6E0", VA = "0x188A6EAE0", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000E")]
	public abstract class CreationOperationException : Exception, KXIWHZSEGUA
	{
		[Cpp2IlInjected.Token(Token = "0x17000007")]
		public abstract string UserFriendlyErrorMessage
		{
			[Cpp2IlInjected.Token(Token = "0x6000036")]
			[Cpp2IlInjected.Address(Slot = "15")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(RVA = "0x8A69350", Offset = "0x8A67F50", VA = "0x188A69350")]
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
			[Cpp2IlInjected.Address(RVA = "0x8A6B2B0", Offset = "0x8A69EB0", VA = "0x188A6B2B0", Slot = "15")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000038")]
		[Cpp2IlInjected.Address(RVA = "0x8A6B1E0", Offset = "0x8A69DE0", VA = "0x188A6B1E0")]
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
			[Cpp2IlInjected.Address(RVA = "0xB44440", Offset = "0xB43040", VA = "0x180B44440", Slot = "15")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600003B")]
		[Cpp2IlInjected.Address(RVA = "0x8A6EBD0", Offset = "0x8A6D7D0", VA = "0x188A6EBD0")]
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
			[Cpp2IlInjected.Address(RVA = "0x8A6AB40", Offset = "0x8A69740", VA = "0x188A6AB40")]
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
			[Cpp2IlInjected.Address(RVA = "0x8A6AB70", Offset = "0x8A69770", VA = "0x188A6AB70")]
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
			[Cpp2IlInjected.Address(RVA = "0xCB0AF0", Offset = "0xCAF6F0", VA = "0x180CB0AF0")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600003D")]
		[Cpp2IlInjected.Address(RVA = "0x8A6E820", Offset = "0x8A6D420", VA = "0x188A6E820")]
		public ShapeSwatchInfo(ShapeColor colorId, ShapeMaterial materialId, float uvScale)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003E")]
		[Cpp2IlInjected.Address(RVA = "0x8A6E590", Offset = "0x8A6D190", VA = "0x188A6E590")]
		public static ShapeSwatchInfo[] GABBKAWFKBC(string a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600003F")]
		[Cpp2IlInjected.Address(RVA = "0x8A6E7B0", Offset = "0x8A6D3B0", VA = "0x188A6E7B0")]
		public static string VSBQJMJZKBP(ShapeSwatchInfo[] a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000040")]
		[Cpp2IlInjected.Address(RVA = "0x8A6E500", Offset = "0x8A6D100", VA = "0x188A6E500")]
		public ShapeSwatchInfo Clone()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000041")]
		[Cpp2IlInjected.Address(RVA = "0x8A6E6E0", Offset = "0x8A6D2E0", VA = "0x188A6E6E0")]
		public bool HBXZJJOJJDE(ShapeSwatchInfo a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000042")]
		[Cpp2IlInjected.Address(RVA = "0x8A6E730", Offset = "0x8A6D330", VA = "0x188A6E730")]
		public bool HBXZJJOJJDE(ShapeMaterial a, ShapeColor b, float c)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000043")]
		[Cpp2IlInjected.Address(RVA = "0x8A6E770", Offset = "0x8A6D370", VA = "0x188A6E770")]
		public bool RGMAHPEISXQ()
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
		public HWDLZISXERK<ConfigurableSubpiece, Collider[], Collider[]> OnCollidersChanged;

		[Cpp2IlInjected.Token(Token = "0x1700000B")]
		public TMJIXIOYVGV JTVSZDMXYPG
		{
			[Cpp2IlInjected.Token(Token = "0x600004C")]
			[Cpp2IlInjected.Address(RVA = "0xB13A50", Offset = "0xB12650", VA = "0x180B13A50")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600004D")]
			[Cpp2IlInjected.Address(RVA = "0xB13200", Offset = "0xB11E00", VA = "0x180B13200")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000C")]
		public Collider[] QKENQSWYMJA
		{
			[Cpp2IlInjected.Token(Token = "0x600004E")]
			[Cpp2IlInjected.Address(RVA = "0xB18810", Offset = "0xB17410", VA = "0x180B18810")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000D")]
		public Renderer[] SHNKFWVGZML
		{
			[Cpp2IlInjected.Token(Token = "0x600004F")]
			[Cpp2IlInjected.Address(RVA = "0xB131D0", Offset = "0xB11DD0", VA = "0x180B131D0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000001")]
		public event Action<TMJIXIOYVGV> LUUNZUONYPJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000050")]
			[Cpp2IlInjected.Address(RVA = "0x8A691F0", Offset = "0x8A67DF0", VA = "0x188A691F0")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000051")]
			[Cpp2IlInjected.Address(RVA = "0x8A692A0", Offset = "0x8A67EA0", VA = "0x188A692A0")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000052")]
		[Cpp2IlInjected.Address(RVA = "0x8A68EB0", Offset = "0x8A67AB0", VA = "0x188A68EB0")]
		private void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000053")]
		[Cpp2IlInjected.Address(RVA = "0x8A68F60", Offset = "0x8A67B60", VA = "0x188A68F60")]
		public void Destroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000054")]
		[Cpp2IlInjected.Address(RVA = "0x8A68FB0", Offset = "0x8A67BB0", VA = "0x188A68FB0")]
		public void SetIConfigurable(TMJIXIOYVGV newConfigurable)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000055")]
		[Cpp2IlInjected.Address(RVA = "0x8A68EC0", Offset = "0x8A67AC0", VA = "0x188A68EC0")]
		public void ChangeCollidersAndRenderers(Collider[] newColliders, Renderer[] newRenderers)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000056")]
		[Cpp2IlInjected.Address(RVA = "0x8A690E0", Offset = "0x8A67CE0", VA = "0x188A690E0")]
		public void ValidateCollidersAndRenderers()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000057")]
		[Cpp2IlInjected.Address(RVA = "0x1AD9E20", Offset = "0x1AD8A20", VA = "0x181AD9E20")]
		public void RunConfigurationSpecialActions(TMJIXIOYVGV configurable)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000058")]
		[Cpp2IlInjected.Address(RVA = "0x8A69170", Offset = "0x8A67D70", VA = "0x188A69170")]
		public ConfigurableSubpiece()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000017")]
	public interface LIEOGVWCKNT
	{
		[Cpp2IlInjected.Token(Token = "0x1700000E")]
		bool TUVWCBJPGGA
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
	public interface MUQCSKNLFAK
	{
		[Cpp2IlInjected.Token(Token = "0x600005C")]
		[Cpp2IlInjected.Address(Slot = "0")]
		IEnumerable<UKSUCGGDLBW> GetColorableSnapshots();
	}
	[Cpp2IlInjected.Token(Token = "0x2000019")]
	public interface DCYHBTNUAHI
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
	public interface USZOLJEHWJD
	{
		[Cpp2IlInjected.Token(Token = "0x1700000F")]
		GameObject EGFDRJDHUWA
		{
			[Cpp2IlInjected.Token(Token = "0x6000062")]
			[Cpp2IlInjected.Address(Slot = "2")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000010")]
		Guid VAEOEDUIVNW
		{
			[Cpp2IlInjected.Token(Token = "0x6000063")]
			[Cpp2IlInjected.Address(Slot = "3")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000011")]
		string QMZMPPIFWAW
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
		Vector3 EQTWTLMMIIA
		{
			[Cpp2IlInjected.Token(Token = "0x6000066")]
			[Cpp2IlInjected.Address(Slot = "6")]
			get;
			[Cpp2IlInjected.Token(Token = "0x6000067")]
			[Cpp2IlInjected.Address(Slot = "7")]
			set;
		}

		[Cpp2IlInjected.Token(Token = "0x17000014")]
		Vector3 JITWWCSUOYD
		{
			[Cpp2IlInjected.Token(Token = "0x6000068")]
			[Cpp2IlInjected.Address(Slot = "8")]
			get;
			[Cpp2IlInjected.Token(Token = "0x6000069")]
			[Cpp2IlInjected.Address(Slot = "9")]
			set;
		}

		[Cpp2IlInjected.Token(Token = "0x17000015")]
		Quaternion GSRSZCJWLFP
		{
			[Cpp2IlInjected.Token(Token = "0x600006A")]
			[Cpp2IlInjected.Address(Slot = "10")]
			get;
			[Cpp2IlInjected.Token(Token = "0x600006B")]
			[Cpp2IlInjected.Address(Slot = "11")]
			set;
		}

		[Cpp2IlInjected.Token(Token = "0x17000016")]
		Quaternion CVDXFZWARDM
		{
			[Cpp2IlInjected.Token(Token = "0x600006C")]
			[Cpp2IlInjected.Address(Slot = "12")]
			get;
			[Cpp2IlInjected.Token(Token = "0x600006D")]
			[Cpp2IlInjected.Address(Slot = "13")]
			set;
		}

		[Cpp2IlInjected.Token(Token = "0x17000017")]
		float BPQFRDQATYN
		{
			[Cpp2IlInjected.Token(Token = "0x600006E")]
			[Cpp2IlInjected.Address(Slot = "14")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000018")]
		float JGLJZPQEFWS
		{
			[Cpp2IlInjected.Token(Token = "0x600006F")]
			[Cpp2IlInjected.Address(Slot = "15")]
			get;
			[Cpp2IlInjected.Token(Token = "0x6000070")]
			[Cpp2IlInjected.Address(Slot = "16")]
			set;
		}

		[Cpp2IlInjected.Token(Token = "0x17000019")]
		Vector3 BAZLFXVZBPV
		{
			[Cpp2IlInjected.Token(Token = "0x6000071")]
			[Cpp2IlInjected.Address(Slot = "17")]
			get;
			[Cpp2IlInjected.Token(Token = "0x6000072")]
			[Cpp2IlInjected.Address(Slot = "18")]
			set;
		}

		[Cpp2IlInjected.Token(Token = "0x1700001A")]
		Vector3 YCAIRIWLUCU
		{
			[Cpp2IlInjected.Token(Token = "0x6000073")]
			[Cpp2IlInjected.Address(Slot = "19")]
			get;
			[Cpp2IlInjected.Token(Token = "0x6000074")]
			[Cpp2IlInjected.Address(Slot = "20")]
			set;
		}

		[Cpp2IlInjected.Token(Token = "0x1700001B")]
		bool OUOUMQTQRRN
		{
			[Cpp2IlInjected.Token(Token = "0x6000075")]
			[Cpp2IlInjected.Address(Slot = "21")]
			set;
		}

		[Cpp2IlInjected.Token(Token = "0x1700001C")]
		TMJIXIOYVGV JTVSZDMXYPG
		{
			[Cpp2IlInjected.Token(Token = "0x6000076")]
			[Cpp2IlInjected.Address(Slot = "22")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x1700001D")]
		[CanBeNull]
		WFVJLHULQVT FGILGSETPLE
		{
			[Cpp2IlInjected.Token(Token = "0x6000077")]
			[Cpp2IlInjected.Address(Slot = "23")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x14000002")]
		event Action HTFGPFHOTUY;

		[Cpp2IlInjected.Token(Token = "0x6000078")]
		[Cpp2IlInjected.Address(Slot = "24")]
		bool CanUpdateDeformation(Vector3 deformationDirection, float deformationFactor, float minAxisScale, Space relativeTo);

		[Cpp2IlInjected.Token(Token = "0x6000079")]
		[Cpp2IlInjected.Address(Slot = "25")]
		void UpdateDeformation(Vector3 deformationDirection, float deformationFactor, bool scalingAlongFixedAxis, Space relativeTo);

		[Cpp2IlInjected.Token(Token = "0x600007A")]
		[Cpp2IlInjected.Address(Slot = "26")]
		bool CanBeRaycasted(Collider collider);
	}
	[Cpp2IlInjected.Token(Token = "0x200001B")]
	public interface NEVOXOXRTII
	{
		[Cpp2IlInjected.Token(Token = "0x1700001E")]
		bool HPFBLLYLJIS
		{
			[Cpp2IlInjected.Token(Token = "0x600008E")]
			[Cpp2IlInjected.Address(Slot = "19")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x1700001F")]
		bool PGCQRCEOJFF
		{
			[Cpp2IlInjected.Token(Token = "0x600008F")]
			[Cpp2IlInjected.Address(Slot = "20")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000020")]
		Vector3 OSQVJRQABSG
		{
			[Cpp2IlInjected.Token(Token = "0x6000090")]
			[Cpp2IlInjected.Address(Slot = "21")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000021")]
		Vector3 WQZRNIQFXEM
		{
			[Cpp2IlInjected.Token(Token = "0x6000091")]
			[Cpp2IlInjected.Address(Slot = "22")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000022")]
		bool YPITRNNIGBO
		{
			[Cpp2IlInjected.Token(Token = "0x6000092")]
			[Cpp2IlInjected.Address(Slot = "23")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000023")]
		bool BRJCDRPZPAB
		{
			[Cpp2IlInjected.Token(Token = "0x6000093")]
			[Cpp2IlInjected.Address(Slot = "24")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000024")]
		bool SWWDCKBCPXA
		{
			[Cpp2IlInjected.Token(Token = "0x6000094")]
			[Cpp2IlInjected.Address(Slot = "25")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000025")]
		bool CXFNLZZQDUZ
		{
			[Cpp2IlInjected.Token(Token = "0x6000095")]
			[Cpp2IlInjected.Address(Slot = "26")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000026")]
		bool QBZGOOKGQSI
		{
			[Cpp2IlInjected.Token(Token = "0x6000096")]
			[Cpp2IlInjected.Address(Slot = "27")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000027")]
		bool EELFCQNXQQO
		{
			[Cpp2IlInjected.Token(Token = "0x6000097")]
			[Cpp2IlInjected.Address(Slot = "28")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000028")]
		bool OIGKZHXCFMJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000098")]
			[Cpp2IlInjected.Address(Slot = "29")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000029")]
		bool AJSAUXFXNFK
		{
			[Cpp2IlInjected.Token(Token = "0x6000099")]
			[Cpp2IlInjected.Address(Slot = "30")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x1700002A")]
		bool YWPAMIQKKWA
		{
			[Cpp2IlInjected.Token(Token = "0x600009A")]
			[Cpp2IlInjected.Address(Slot = "31")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x600007B")]
		[Cpp2IlInjected.Address(Slot = "0")]
		void OnCreatedBySpawning();

		[Cpp2IlInjected.Token(Token = "0x600007C")]
		[Cpp2IlInjected.Address(Slot = "1")]
		void OnCreatedFromTemplate();

		[Cpp2IlInjected.Token(Token = "0x600007D")]
		[Cpp2IlInjected.Address(Slot = "2")]
		void OnSelected();

		[Cpp2IlInjected.Token(Token = "0x600007E")]
		[Cpp2IlInjected.Address(Slot = "3")]
		void OnTranslationStart();

		[Cpp2IlInjected.Token(Token = "0x600007F")]
		[Cpp2IlInjected.Address(Slot = "4")]
		void OnRotationStart();

		[Cpp2IlInjected.Token(Token = "0x6000080")]
		[Cpp2IlInjected.Address(Slot = "5")]
		void OnScaleStart();

		[Cpp2IlInjected.Token(Token = "0x6000081")]
		[Cpp2IlInjected.Address(Slot = "6")]
		void OnDeformStart();

		[Cpp2IlInjected.Token(Token = "0x6000082")]
		[Cpp2IlInjected.Address(Slot = "7")]
		void OnTranslated();

		[Cpp2IlInjected.Token(Token = "0x6000083")]
		[Cpp2IlInjected.Address(Slot = "8")]
		void OnRotated();

		[Cpp2IlInjected.Token(Token = "0x6000084")]
		[Cpp2IlInjected.Address(Slot = "9")]
		void OnScaled();

		[Cpp2IlInjected.Token(Token = "0x6000085")]
		[Cpp2IlInjected.Address(Slot = "10")]
		void OnDeformed(Vector3 previousPosition);

		[Cpp2IlInjected.Token(Token = "0x6000086")]
		[Cpp2IlInjected.Address(Slot = "11")]
		void OnTranslationFinished();

		[Cpp2IlInjected.Token(Token = "0x6000087")]
		[Cpp2IlInjected.Address(Slot = "12")]
		void OnRotationFinished();

		[Cpp2IlInjected.Token(Token = "0x6000088")]
		[Cpp2IlInjected.Address(Slot = "13")]
		void OnScaleFinished();

		[Cpp2IlInjected.Token(Token = "0x6000089")]
		[Cpp2IlInjected.Address(Slot = "14")]
		void OnDeformationFinished();

		[Cpp2IlInjected.Token(Token = "0x600008A")]
		[Cpp2IlInjected.Address(Slot = "15")]
		void OnDeselected();

		[Cpp2IlInjected.Token(Token = "0x600008B")]
		[Cpp2IlInjected.Address(Slot = "16")]
		void OnHoverStart(ToolMode toolMode, Collider hitCollider, OutlineRequest outlineRequest);

		[Cpp2IlInjected.Token(Token = "0x600008C")]
		[Cpp2IlInjected.Address(Slot = "17")]
		void OnHovering(ToolMode toolMode, Collider hitCollider);

		[Cpp2IlInjected.Token(Token = "0x600008D")]
		[Cpp2IlInjected.Address(Slot = "18")]
		void OnHoverFinished(ToolMode toolMode, ObjectLocalId outlineRequester, OutlineRequest.RequestMode requestMode);

		[Cpp2IlInjected.Token(Token = "0x600009B")]
		[Cpp2IlInjected.Address(Slot = "32")]
		void Translate(Vector3 displacementWorldSpace);

		[Cpp2IlInjected.Token(Token = "0x600009C")]
		[Cpp2IlInjected.Address(Slot = "33")]
		void Rotate(Quaternion angularDisplacementWorldSpace);

		[Cpp2IlInjected.Token(Token = "0x600009D")]
		[Cpp2IlInjected.Address(Slot = "34")]
		bool Scale(float scaleFactor);

		[Cpp2IlInjected.Token(Token = "0x600009E")]
		[Cpp2IlInjected.Address(Slot = "35")]
		Task DeleteAsync();
	}
	[Cpp2IlInjected.Token(Token = "0x200001C")]
	public interface MSPXFZZSFXU
	{
		[Cpp2IlInjected.Token(Token = "0x600009F")]
		[Cpp2IlInjected.Address(Slot = "0")]
		bool SCOQOKPYBET([In] Vector3 origin, [In] Vector3 direction, Vector3 a, Vector3 b);
	}
	[Cpp2IlInjected.Token(Token = "0x200001D")]
	public interface RQQDCCEDGWJ
	{
		[Cpp2IlInjected.Token(Token = "0x1700002B")]
		bool ZALVYUUURPC
		{
			[Cpp2IlInjected.Token(Token = "0x60000A0")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x1700002C")]
		SVJYJIPYDON HBMBIQEHIPT
		{
			[Cpp2IlInjected.Token(Token = "0x60000A2")]
			[Cpp2IlInjected.Address(Slot = "2")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x60000A1")]
		[Cpp2IlInjected.Address(Slot = "1")]
		Task RequestMasterDespawn();
	}
	[Cpp2IlInjected.Token(Token = "0x200001E")]
	public interface GCGLHPDXBYX
	{
		[Cpp2IlInjected.Token(Token = "0x1700002D")]
		bool OULUFOFTFHY
		{
			[Cpp2IlInjected.Token(Token = "0x60000A5")]
			[Cpp2IlInjected.Address(Slot = "2")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x1700002E")]
		KMCHCCTYLVI XTNDWAWSUEI
		{
			[Cpp2IlInjected.Token(Token = "0x60000A6")]
			[Cpp2IlInjected.Address(Slot = "3")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x14000003")]
		event Action<bool> TFWLXGWLCIT;

		[Cpp2IlInjected.Token(Token = "0x60000A7")]
		[Cpp2IlInjected.Address(Slot = "4")]
		void LocalPlayerTakeAuthority();

		[Cpp2IlInjected.Token(Token = "0x60000A8")]
		[Cpp2IlInjected.Address(Slot = "5")]
		void TransferOwnership(int actorNumber);

		[Cpp2IlInjected.Token(Token = "0x60000A9")]
		[Cpp2IlInjected.Address(Slot = "6")]
		WJBKOLNRRJE GetCulprit(CreationResult failureReason);
	}
	[Cpp2IlInjected.Token(Token = "0x200001F")]
	public interface CVYXOYBXDCJ
	{
		[Cpp2IlInjected.Token(Token = "0x1700002F")]
		IEnumerable<NavMeshSupport.Restriction> OKPJDQVYQGF
		{
			[Cpp2IlInjected.Token(Token = "0x60000AA")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x60000AB")]
		[Cpp2IlInjected.Address(Slot = "1")]
		void AddNavMeshSupportRestriction(NavMeshSupport.Restriction restriction);

		[Cpp2IlInjected.Token(Token = "0x60000AC")]
		[Cpp2IlInjected.Address(Slot = "2")]
		void RemoveNavMeshSupportRestriction(NavMeshSupport.Restriction restriction);
	}
	[Cpp2IlInjected.Token(Token = "0x2000020")]
	public interface GBKOKNQARBU
	{
		[Cpp2IlInjected.Token(Token = "0x60000AD")]
		[Cpp2IlInjected.Address(Slot = "0")]
		void Reset();

		[Cpp2IlInjected.Token(Token = "0x60000AE")]
		[Cpp2IlInjected.Address(Slot = "1")]
		void RequestRPCReset();
	}
	[Cpp2IlInjected.Token(Token = "0x2000021")]
	public interface NWSFQILTTWW
	{
		[Cpp2IlInjected.Token(Token = "0x17000030")]
		bool EFIMGRRTNOT
		{
			[Cpp2IlInjected.Token(Token = "0x60000AF")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000031")]
		bool EMFWROESXBS
		{
			[Cpp2IlInjected.Token(Token = "0x60000B0")]
			[Cpp2IlInjected.Address(Slot = "1")]
			get;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000022")]
	public interface KFMPMWGHUFN
	{
		[Cpp2IlInjected.Token(Token = "0x17000032")]
		int SAEQVXCEJYV
		{
			[Cpp2IlInjected.Token(Token = "0x60000B1")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x60000B2")]
		[Cpp2IlInjected.Address(Slot = "1")]
		void RenderSelection(SelectionEffectType? selectionEffectType);

		[Cpp2IlInjected.Token(Token = "0x60000B3")]
		[Cpp2IlInjected.Address(Slot = "2")]
		void RenderOutline(OutlineEffectType? outlineType);

		[Cpp2IlInjected.Token(Token = "0x60000B4")]
		[Cpp2IlInjected.Address(Slot = "3")]
		void RenderWorldFadeMask();

		[Cpp2IlInjected.Token(Token = "0x60000B5")]
		[Cpp2IlInjected.Address(Slot = "4")]
		Bounds GetWorldBounds();

		[Cpp2IlInjected.Token(Token = "0x60000B6")]
		[Cpp2IlInjected.Address(Slot = "5")]
		CreationResult CanBeSelected();
	}
	[Cpp2IlInjected.Token(Token = "0x2000023")]
	public interface KIBXCVXFDMQ
	{
		[Cpp2IlInjected.Token(Token = "0x17000033")]
		bool OIQVJNHGRAO
		{
			[Cpp2IlInjected.Token(Token = "0x60000B7")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
			[Cpp2IlInjected.Token(Token = "0x60000B8")]
			[Cpp2IlInjected.Address(Slot = "1")]
			set;
		}

		[Cpp2IlInjected.Token(Token = "0x17000034")]
		CanSaveObjectIntoInventionResultType TNKLZHGEOUR
		{
			[Cpp2IlInjected.Token(Token = "0x60000BA")]
			[Cpp2IlInjected.Address(Slot = "3")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000035")]
		bool FPTZOXXBFMA
		{
			[Cpp2IlInjected.Token(Token = "0x60000BB")]
			[Cpp2IlInjected.Address(Slot = "4")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000036")]
		bool CEAFYLALKTD
		{
			[Cpp2IlInjected.Token(Token = "0x60000BC")]
			[Cpp2IlInjected.Address(Slot = "5")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000037")]
		bool LYMGRWWOMFR
		{
			[Cpp2IlInjected.Token(Token = "0x60000BD")]
			[Cpp2IlInjected.Address(Slot = "6")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000038")]
		bool KHKMWTVYGYU
		{
			[Cpp2IlInjected.Token(Token = "0x60000BE")]
			[Cpp2IlInjected.Address(Slot = "7")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000039")]
		bool YFRCLFMJZRB
		{
			[Cpp2IlInjected.Token(Token = "0x60000BF")]
			[Cpp2IlInjected.Address(Slot = "8")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x1700003A")]
		IEnumerable<Collider> RUZPSXRREJY
		{
			[Cpp2IlInjected.Token(Token = "0x60000C0")]
			[Cpp2IlInjected.Address(Slot = "9")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x1700003B")]
		RotatedBounds? WBGEQZXKUMI
		{
			[Cpp2IlInjected.Token(Token = "0x60000C1")]
			[Cpp2IlInjected.Address(Slot = "10")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x1700003C")]
		bool DJTHGGVPACO
		{
			[Cpp2IlInjected.Token(Token = "0x60000C2")]
			[Cpp2IlInjected.Address(Slot = "11")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x1700003D")]
		bool MJKXQLAEBHW
		{
			[Cpp2IlInjected.Token(Token = "0x60000C3")]
			[Cpp2IlInjected.Address(Slot = "12")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x60000B9")]
		[Cpp2IlInjected.Address(Slot = "2")]
		CostInfo GetSandboxResourceCost(bool verifyIntegrity = true);
	}
	[Cpp2IlInjected.Token(Token = "0x2000024")]
	public interface XOSIADKLSQB
	{
		[Cpp2IlInjected.Token(Token = "0x60000C4")]
		[Cpp2IlInjected.Address(Slot = "0")]
		CreationResult CanPerformUndoRedoOnObject();

		[Cpp2IlInjected.Token(Token = "0x60000C5")]
		[Cpp2IlInjected.Address(Slot = "1")]
		void GetTransformationDataForUndoRedo([Out] Vector3 position, [Out] Quaternion rotation, [Out] float uniformScale, [Out] Vector3 deformationScale);

		[Cpp2IlInjected.Token(Token = "0x60000C6")]
		[Cpp2IlInjected.Address(Slot = "2")]
		void SetTransformationDataForUndoRedo(Vector3? position, Quaternion? rotation, float? uniformScale, Vector3? deformationScale);
	}
	[Cpp2IlInjected.Token(Token = "0x2000025")]
	public interface AJMLDEBNKFS
	{
		[Cpp2IlInjected.Token(Token = "0x1700003E")]
		object HEAGSDFSYLL
		{
			[Cpp2IlInjected.Token(Token = "0x60000C7")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x1700003F")]
		Type KUJGCJVKTFM
		{
			[Cpp2IlInjected.Token(Token = "0x60000C8")]
			[Cpp2IlInjected.Address(Slot = "1")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000040")]
		Guid RGZLFSJIOSW
		{
			[Cpp2IlInjected.Token(Token = "0x60000C9")]
			[Cpp2IlInjected.Address(Slot = "2")]
			get;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000026")]
	public interface TMJIXIOYVGV
	{
		[Cpp2IlInjected.Token(Token = "0x17000041")]
		IReadOnlyList<ZAPQAZWXYYV> DynamicUIElements
		{
			[Cpp2IlInjected.Token(Token = "0x60000D2")]
			[Cpp2IlInjected.Address(Slot = "8")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000042")]
		string Title
		{
			[Cpp2IlInjected.Token(Token = "0x60000D3")]
			[Cpp2IlInjected.Address(Slot = "9")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000043")]
		string Subtitle
		{
			[Cpp2IlInjected.Token(Token = "0x60000D4")]
			[Cpp2IlInjected.Address(Slot = "10")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000044")]
		bool IsValid
		{
			[Cpp2IlInjected.Token(Token = "0x60000D5")]
			[Cpp2IlInjected.Address(Slot = "11")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x14000004")]
		event Action<string> TKJDMEBWPSG;

		[Cpp2IlInjected.Token(Token = "0x14000005")]
		event Action<TMJIXIOYVGV> PLCNMBUBFWP;

		[Cpp2IlInjected.Token(Token = "0x14000006")]
		event Action<DialogType, PVIOTSLZPKY> FNDPRDJFMCQ;

		[Cpp2IlInjected.Token(Token = "0x14000007")]
		event Action QOFSHICWFHF;

		[Cpp2IlInjected.Token(Token = "0x60000D6")]
		[Cpp2IlInjected.Address(Slot = "12")]
		void Reset();

		[Cpp2IlInjected.Token(Token = "0x60000D7")]
		[Cpp2IlInjected.Address(Slot = "13")]
		void ConfigurableWillShow();

		[Cpp2IlInjected.Token(Token = "0x60000D8")]
		[Cpp2IlInjected.Address(Slot = "14")]
		void ConfigurableWillHide();
	}
	[Cpp2IlInjected.Token(Token = "0x2000027")]
	public interface VYFNFMVPAFF
	{
		[Cpp2IlInjected.Token(Token = "0x14000008")]
		event Action MJATLWVVAFZ;
	}
	[Cpp2IlInjected.Token(Token = "0x2000028")]
	public interface RZHZMZRJMNK : TMJIXIOYVGV, IYUUTKXIJQE
	{
		[Cpp2IlInjected.Token(Token = "0x17000045")]
		IEnumerable<IYUUTKXIJQE> MFAGDHVMSLV
		{
			[Cpp2IlInjected.Token(Token = "0x60000DC")]
			[Cpp2IlInjected.Address(Slot = "1")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x60000DB")]
		[Cpp2IlInjected.Address(Slot = "0")]
		void RegisterConfigurableAddOn(IYUUTKXIJQE newSubConfigurable);
	}
	[Cpp2IlInjected.Token(Token = "0x2000029")]
	public interface IYUUTKXIJQE
	{
		[Cpp2IlInjected.Token(Token = "0x60000DD")]
		[Cpp2IlInjected.Address(Slot = "0")]
		IReadOnlyList<ZAPQAZWXYYV> GetConfigurableDynamicUI([Optional] IEnumerable<IYUUTKXIJQE> configurables);
	}
	[Cpp2IlInjected.Token(Token = "0x200002A")]
	public interface ZZENPLRICME
	{
		[Cpp2IlInjected.Token(Token = "0x17000046")]
		bool YJXNAZMGIID
		{
			[Cpp2IlInjected.Token(Token = "0x60000DE")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
			[Cpp2IlInjected.Token(Token = "0x60000DF")]
			[Cpp2IlInjected.Address(Slot = "1")]
			set;
		}

		[Cpp2IlInjected.Token(Token = "0x17000047")]
		bool RQOEODGYSJW
		{
			[Cpp2IlInjected.Token(Token = "0x60000E0")]
			[Cpp2IlInjected.Address(Slot = "2")]
			get;
			[Cpp2IlInjected.Token(Token = "0x60000E1")]
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
		public IEnumerable<Restriction> ODKCYCRKOIC
		{
			[Cpp2IlInjected.Token(Token = "0x60000E2")]
			[Cpp2IlInjected.Address(RVA = "0x8A6B060", Offset = "0x8A69C60", VA = "0x188A6B060")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000E3")]
		[Cpp2IlInjected.Address(RVA = "0x8A6AE60", Offset = "0x8A69A60", VA = "0x188A6AE60")]
		public void Add(Restriction restriction)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E4")]
		[Cpp2IlInjected.Address(RVA = "0x8A6B0C0", Offset = "0x8A69CC0", VA = "0x188A6B0C0")]
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
	public readonly struct TrialInventionInfo : DLWLZVEDFPU
	{
		[Cpp2IlInjected.Token(Token = "0x17000049")]
		public int SpawningPlayerId
		{
			[Cpp2IlInjected.Token(Token = "0x60000E8")]
			[Cpp2IlInjected.Address(RVA = "0xCE0880", Offset = "0xCDF480", VA = "0x180CE0880", Slot = "5")]
			[CompilerGenerated]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700004A")]
		public int TrialSpawnTime
		{
			[Cpp2IlInjected.Token(Token = "0x60000E9")]
			[Cpp2IlInjected.Address(RVA = "0x32F76D0", Offset = "0x32F62D0", VA = "0x1832F76D0", Slot = "4")]
			[CompilerGenerated]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000EA")]
		[Cpp2IlInjected.Address(RVA = "0x8A6E870", Offset = "0x8A6D470", VA = "0x188A6E870")]
		public TrialInventionInfo(int trialSpawnTime, int spawningPlayerId)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200002F")]
	public interface KFMRSFVBCUF : RJUXLOZNZDG
	{
		[Cpp2IlInjected.Token(Token = "0x400004F")]
		static readonly int KZUFHUUWRHQ;

		[Cpp2IlInjected.Token(Token = "0x4000050")]
		static readonly Guid ENHSCZEERXN;

		[Cpp2IlInjected.Token(Token = "0x1700004B")]
		Guid SOCZHUYDANF
		{
			[Cpp2IlInjected.Token(Token = "0x60000EB")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x1700004C")]
		long IPHYAQBVRBK
		{
			[Cpp2IlInjected.Token(Token = "0x60000EC")]
			[Cpp2IlInjected.Address(Slot = "1")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x1700004D")]
		[Obsolete("This is not used - version tracking is done at the server level as collections of InventionId")]
		int JTTBFFMRCVU
		{
			[Cpp2IlInjected.Token(Token = "0x60000ED")]
			[Cpp2IlInjected.Address(Slot = "2")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x60000EE")]
		[Cpp2IlInjected.Address(RVA = "0x8A6ACC0", Offset = "0x8A698C0", VA = "0x188A6ACC0")]
		static KFMRSFVBCUF()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000030")]
	[Obsolete("This is not used by anything and does not give us full provenance tracking")]
	public interface ASYBRPPDEZP
	{
		[Cpp2IlInjected.Token(Token = "0x1700004E")]
		[Obsolete("This is not currently consumed and does not give us full provenance tracking, however it does contain information that may prevent 'contamination' of invention contents by other non-monetizable inventions")]
		bool IECEWASATUN
		{
			[Cpp2IlInjected.Token(Token = "0x60000EF")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000031")]
	public interface WFVJLHULQVT
	{
		[Cpp2IlInjected.Token(Token = "0x1700004F")]
		bool ESKXRRGJGEC
		{
			[Cpp2IlInjected.Token(Token = "0x60000F0")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x60000F1")]
		[Cpp2IlInjected.Address(Slot = "1")]
		[CanBeNull]
		KFMRSFVBCUF JQLXKLYQUXF();

		[Cpp2IlInjected.Token(Token = "0x60000F2")]
		[Cpp2IlInjected.Address(Slot = "2")]
		[CanBeNull]
		ASYBRPPDEZP LMEZXGXFVZF();

		[Cpp2IlInjected.Token(Token = "0x60000F3")]
		[Cpp2IlInjected.Address(Slot = "3")]
		void JXEZXKJMRFW(Guid a, long b, int c, bool d);

		[Cpp2IlInjected.Token(Token = "0x60000F4")]
		[Cpp2IlInjected.Address(Slot = "4")]
		void JXEZXKJMRFW(WFVJLHULQVT a);

		[Cpp2IlInjected.Token(Token = "0x60000F5")]
		[Cpp2IlInjected.Address(Slot = "5")]
		void SerializeTo(InventionPieceData data);
	}
	[Cpp2IlInjected.Token(Token = "0x2000032")]
	public static class OYULPZCVUOS
	{
		[Cpp2IlInjected.Token(Token = "0x60000F6")]
		[Cpp2IlInjected.Address(RVA = "0x8A6B580", Offset = "0x8A6A180", VA = "0x188A6B580")]
		public static void DeserializeFrom(this WFVJLHULQVT that, InventionPieceData inventionPieceData)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000033")]
	public interface RJUXLOZNZDG
	{
		[Cpp2IlInjected.Token(Token = "0x17000050")]
		bool DSJLRMLCJJF
		{
			[Cpp2IlInjected.Token(Token = "0x60000F7")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x60000F8")]
		[Cpp2IlInjected.Address(Slot = "1")]
		[CanBeNull]
		DLWLZVEDFPU OZFVKCDFGYY();

		[Cpp2IlInjected.Token(Token = "0x60000F9")]
		[Cpp2IlInjected.Address(Slot = "2")]
		bool OZFVKCDFGYY([Out] TrialInventionInfo a);

		[Cpp2IlInjected.Token(Token = "0x60000FA")]
		[Cpp2IlInjected.Address(Slot = "3")]
		void JPMYOGOZMZZ(WJBKOLNRRJE a);

		[Cpp2IlInjected.Token(Token = "0x60000FB")]
		[Cpp2IlInjected.Address(Slot = "4")]
		void QTKLBGHELYM();
	}
	[Cpp2IlInjected.Token(Token = "0x2000034")]
	public interface DLWLZVEDFPU
	{
		[Cpp2IlInjected.Token(Token = "0x17000051")]
		int TrialSpawnTime
		{
			[Cpp2IlInjected.Token(Token = "0x60000FC")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000052")]
		int SpawningPlayerId
		{
			[Cpp2IlInjected.Token(Token = "0x60000FD")]
			[Cpp2IlInjected.Address(Slot = "1")]
			get;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000035")]
	public class InventionTrackingViaSynchronizedField : WFVJLHULQVT, KFMRSFVBCUF, RJUXLOZNZDG, DLWLZVEDFPU, ASYBRPPDEZP
	{
		[Cpp2IlInjected.Token(Token = "0x2000036")]
		[CompilerGenerated]
		private sealed class OMRVDWPWADA
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000055")]
			public InventionTrackingViaSynchronizedField VISDDFDIKLJ;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000056")]
			public Guid HBVEVMRCGED;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000057")]
			public long CQFAWAXMYWU;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000058")]
			public int EUOYQZEIMFU;

			[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
			[Cpp2IlInjected.Token(Token = "0x4000059")]
			public bool IFNELLDEGVX;

			[Cpp2IlInjected.Token(Token = "0x6000119")]
			[Cpp2IlInjected.Address(RVA = "0xB1CF80", Offset = "0xB1BB80", VA = "0x180B1CF80")]
			public OMRVDWPWADA()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600011A")]
			[Cpp2IlInjected.Address(RVA = "0x8A6B2E0", Offset = "0x8A69EE0", VA = "0x188A6B2E0")]
			internal object PQAHOWWQJRK((Guid newInstanceId, long inventionId, int versionNumber, bool originallyFromOtherInvention) x)
			{
				return null;
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000051")]
		private XRWGFEQXNJL<Guid, ObscuredLong, ObscuredInt, ObscuredBool> AQAJWNJPHQH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000052")]
		private XSBNCLKUWUU<ObscuredBool, ObscuredInt, ObscuredInt> QFDASAHSNBM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000053")]
		private RRNetworkBehavior TPGTEFQVGCQ;

		[Cpp2IlInjected.Token(Token = "0x4000054")]
		private static readonly Log DNBXSEXRPWR;

		[Cpp2IlInjected.Token(Token = "0x17000053")]
		private Guid SOCZHUYDANF
		{
			[Cpp2IlInjected.Token(Token = "0x60000FF")]
			[Cpp2IlInjected.Address(RVA = "0x8A6A030", Offset = "0x8A68C30", VA = "0x188A6A030")]
			get
			{
				return default(Guid);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000054")]
		private long IPHYAQBVRBK
		{
			[Cpp2IlInjected.Token(Token = "0x6000100")]
			[Cpp2IlInjected.Address(RVA = "0x8A6A450", Offset = "0x8A69050", VA = "0x188A6A450")]
			get
			{
				return default(long);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000055")]
		private int JTTBFFMRCVU
		{
			[Cpp2IlInjected.Token(Token = "0x6000101")]
			[Cpp2IlInjected.Address(RVA = "0x8A69F90", Offset = "0x8A68B90", VA = "0x188A69F90")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000056")]
		private bool IECEWASATUN
		{
			[Cpp2IlInjected.Token(Token = "0x6000102")]
			[Cpp2IlInjected.Address(RVA = "0x8A69F00", Offset = "0x8A68B00", VA = "0x188A69F00")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000057")]
		private bool DSJLRMLCJJF
		{
			[Cpp2IlInjected.Token(Token = "0x6000103")]
			[Cpp2IlInjected.Address(RVA = "0x8A69820", Offset = "0x8A68420", VA = "0x188A69820")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000058")]
		private int ILNWOVVADJK
		{
			[Cpp2IlInjected.Token(Token = "0x6000104")]
			[Cpp2IlInjected.Address(RVA = "0x8A6A500", Offset = "0x8A69100", VA = "0x188A6A500")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000059")]
		private int ZABTYQYGKGL
		{
			[Cpp2IlInjected.Token(Token = "0x6000105")]
			[Cpp2IlInjected.Address(RVA = "0x8A6A3B0", Offset = "0x8A68FB0", VA = "0x188A6A3B0")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700005A")]
		public bool ESKXRRGJGEC
		{
			[Cpp2IlInjected.Token(Token = "0x6000108")]
			[Cpp2IlInjected.Address(RVA = "0x8A69680", Offset = "0x8A68280", VA = "0x188A69680", Slot = "4")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700005B")]
		private Guid TRDJMUZVZRD
		{
			[Cpp2IlInjected.Token(Token = "0x600010D")]
			[Cpp2IlInjected.Address(RVA = "0x8A6A030", Offset = "0x8A68C30", VA = "0x188A6A030", Slot = "10")]
			get
			{
				return default(Guid);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700005C")]
		private long YQQCXCFXEKG
		{
			[Cpp2IlInjected.Token(Token = "0x600010E")]
			[Cpp2IlInjected.Address(RVA = "0x8A6A4F0", Offset = "0x8A690F0", VA = "0x188A6A4F0", Slot = "11")]
			get
			{
				return default(long);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700005D")]
		private int PKAKEDMDEHW
		{
			[Cpp2IlInjected.Token(Token = "0x600010F")]
			[Cpp2IlInjected.Address(RVA = "0x8A6A3A0", Offset = "0x8A68FA0", VA = "0x188A6A3A0", Slot = "12")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700005E")]
		private int OTGYJDCQCVZ
		{
			[Cpp2IlInjected.Token(Token = "0x6000110")]
			[Cpp2IlInjected.Address(RVA = "0x8A6A0A0", Offset = "0x8A68CA0", VA = "0x188A6A0A0", Slot = "19")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700005F")]
		private int BGUHGGXQBSE
		{
			[Cpp2IlInjected.Token(Token = "0x6000111")]
			[Cpp2IlInjected.Address(RVA = "0x8A69810", Offset = "0x8A68410", VA = "0x188A69810", Slot = "18")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000060")]
		private bool VEBIKXWSCFR
		{
			[Cpp2IlInjected.Token(Token = "0x6000112")]
			[Cpp2IlInjected.Address(RVA = "0x8A6A020", Offset = "0x8A68C20", VA = "0x188A6A020", Slot = "20")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000061")]
		private bool LEROXLTQJGM
		{
			[Cpp2IlInjected.Token(Token = "0x6000113")]
			[Cpp2IlInjected.Address(RVA = "0x8A6A440", Offset = "0x8A69040", VA = "0x188A6A440", Slot = "13")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000FE")]
		[Cpp2IlInjected.Address(RVA = "0x8A6A620", Offset = "0x8A69220", VA = "0x188A6A620")]
		public InventionTrackingViaSynchronizedField(RRNetworkBehavior owningBehavior, string syncKey, Guid instanceId, long inventionId, int versionNumber, bool originallyFromOtherInvention)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000106")]
		[Cpp2IlInjected.Address(RVA = "0x8A6A2C0", Offset = "0x8A68EC0", VA = "0x188A6A2C0", Slot = "9")]
		public void SerializeTo(InventionPieceData data)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000107")]
		[Cpp2IlInjected.Address(RVA = "0x8A695C0", Offset = "0x8A681C0", VA = "0x188A695C0")]
		public static InventionPieceData CZETGSAYEVS(Guid a, long b, int c, bool d)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000109")]
		[Cpp2IlInjected.Address(RVA = "0x8A698B0", Offset = "0x8A684B0", VA = "0x188A698B0", Slot = "5")]
		public KFMRSFVBCUF JQLXKLYQUXF()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600010A")]
		[Cpp2IlInjected.Address(RVA = "0x8A698B0", Offset = "0x8A684B0", VA = "0x188A698B0", Slot = "6")]
		public ASYBRPPDEZP LMEZXGXFVZF()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600010B")]
		[Cpp2IlInjected.Address(RVA = "0x8A69BD0", Offset = "0x8A687D0", VA = "0x188A69BD0", Slot = "7")]
		public void JXEZXKJMRFW(Guid a, long b, int c, bool d)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600010C")]
		[Cpp2IlInjected.Address(RVA = "0x8A698E0", Offset = "0x8A684E0", VA = "0x188A698E0", Slot = "8")]
		public void JXEZXKJMRFW(WFVJLHULQVT a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000114")]
		[Cpp2IlInjected.Address(RVA = "0x8A6A370", Offset = "0x8A68F70", VA = "0x188A6A370", Slot = "14")]
		private DLWLZVEDFPU TCBSTYKVINX()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000115")]
		[Cpp2IlInjected.Address(RVA = "0x8A6A0B0", Offset = "0x8A68CB0", VA = "0x188A6A0B0", Slot = "15")]
		public bool OZFVKCDFGYY([Out] TrialInventionInfo a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000116")]
		[Cpp2IlInjected.Address(RVA = "0x8A6A110", Offset = "0x8A68D10", VA = "0x188A6A110", Slot = "16")]
		private void SLNSUAZPZIC(WJBKOLNRRJE a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000117")]
		[Cpp2IlInjected.Address(RVA = "0x8A69700", Offset = "0x8A68300", VA = "0x188A69700", Slot = "17")]
		private void EAUPFWCOHMB()
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
