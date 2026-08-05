using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Cpp2IlInjected;
using Photon.Pun;
using RecRoom;
using RecRoom.DataLayer.Attributes;
using RecRoom.Logging.Attributes;
using RecRoom.Utils.OverridableFields;
using UnityEngine;
using UnityEngine.Serialization;

[assembly: AssemblyVersion("0.0.0.0")]
namespace _LogRegistration.RecRoom_Rbex_Runtime
{
	[Cpp2IlInjected.Token(Token = "0x2000002")]
	[CompilerGenerated]
	[RecRoom.Logging.Attributes.Preserve]
	public class LogRegistrationIndex : OACCHOKJOKN
	{
		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(RVA = "0x7468500", Offset = "0x7467900", VA = "0x187468500", Slot = "4")]
		public override void PFLPBBOAAPI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0x8D4B40", Offset = "0x8D3F40", VA = "0x1808D4B40")]
		public LogRegistrationIndex()
		{
		}
	}
}
namespace _AssemblyRegistry.RecRoom_Rbex_Runtime
{
	[Cpp2IlInjected.Token(Token = "0x2000003")]
	[CompilerGenerated]
	[RecRoom.DataLayer.Attributes.Preserve]
	public class _AssemblyIndex : GADMOBJFAOI
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000001")]
		private int[] localIndices0;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000002")]
		private OGGMFKFHPGE bitset0;

		[Cpp2IlInjected.Token(Token = "0x17000001")]
		public override string[] ServiceCategories
		{
			[Cpp2IlInjected.Token(Token = "0x6000003")]
			[Cpp2IlInjected.Address(RVA = "0x8AA340", Offset = "0x8A9740", VA = "0x1808AA340", Slot = "4")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x19B7800", Offset = "0x19B6C00", VA = "0x1819B7800", Slot = "5")]
		public override void OHILFHDNMJH(List<int> globalFromLocalIndices)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x7475C60", Offset = "0x7475060", VA = "0x187475C60")]
		private void MBBEPNKNMNH(OOCPEHCJIIC registry)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x7475C00", Offset = "0x7475000", VA = "0x187475C00", Slot = "6")]
		public override void CKKGPJCNOFN(OOCPEHCJIIC registry, [In] DEPDLDENAIO filter)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x7475F60", Offset = "0x7475360", VA = "0x187475F60")]
		public _AssemblyIndex()
		{
		}
	}
}
namespace RecRoom
{
	[Cpp2IlInjected.Token(Token = "0x2000004")]
	[DisallowMultipleComponent]
	public sealed class RigidbodyEx : MonoBehaviour, NADAIAGKPNF
	{
		[Cpp2IlInjected.Token(Token = "0x4000004")]
		private static readonly EGGMDNJPOBA CFGOFNJGCBG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000005")]
		private bool DIGPGLNJKPO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000006")]
		private IFCIIPLFOCA IKJCOPNBHKP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000007")]
		[SerializeField]
		[KKFPOGPNFEA(GODLKEADDAA.Self, false, false, false)]
		private Rigidbody unityRigidbody;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000008")]
		[SerializeField]
		[KKFPOGPNFEA(GODLKEADDAA.SelfAndParent, true, false, false)]
		private PhotonView photonView;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000009")]
		[SerializeField]
		private OverridableVector3 precomputedCenterOfMass;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400000A")]
		[SerializeField]
		private OverridableVector3 customCenterOfMass;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x400000B")]
		[FormerlySerializedAs("forceNoInterpolation")]
		[SerializeField]
		private JKBHAFMADLE physicsInterpolation;

		[Cpp2IlInjected.FieldOffset(Offset = "0x5C")]
		[Cpp2IlInjected.Token(Token = "0x400000C")]
		[SerializeField]
		[Tooltip("If checked, this object's Unity Rigidbody will not be stripped when parenting the object to another RigidbodyEx. Only check this on objects that have a Unity Rigidbody by default and who need access to Unity physics events like OnTriggerEnter, OnCollisionEnter, etc. This is sometimes set via script instead of this flag.")]
		private bool keepUnityRigidbodyWhileParented;

		[Cpp2IlInjected.FieldOffset(Offset = "0x5D")]
		[Cpp2IlInjected.Token(Token = "0x400000D")]
		[Tooltip("If the RigidbodyEx has a parent that is being destroyed, this flag allows this RigidbodyEx to keep the parent set. The default behavior is thatthe parent property is set to null, resetting/clearing the existing parent when it is being destroyed.")]
		[SerializeField]
		private bool keepParentOnParentDestroy;

		[Cpp2IlInjected.FieldOffset(Offset = "0x5E")]
		[Cpp2IlInjected.Token(Token = "0x400000E")]
		[SerializeField]
		[HideInInspector]
		private bool hasUnityRigidbodyByDefault;

		[Cpp2IlInjected.Token(Token = "0x17000002")]
		internal IFCIIPLFOCA JLNLNODPCMP
		{
			[Cpp2IlInjected.Token(Token = "0x6000008")]
			[Cpp2IlInjected.Address(RVA = "0x7471720", Offset = "0x7470B20", VA = "0x187471720")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000003")]
		private IFCIIPLFOCA EPBGOLGPJPH
		{
			[Cpp2IlInjected.Token(Token = "0x6000009")]
			[Cpp2IlInjected.Address(RVA = "0x8AA330", Offset = "0x8A9730", VA = "0x1808AA330", Slot = "6")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000004")]
		public int PIMDPKMMCEK
		{
			[Cpp2IlInjected.Token(Token = "0x600001D")]
			[Cpp2IlInjected.Address(RVA = "0x7473110", Offset = "0x7472510", VA = "0x187473110")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000005")]
		public RigidbodyEx GAOPFGMDPMK
		{
			[Cpp2IlInjected.Token(Token = "0x600001F")]
			[Cpp2IlInjected.Address(RVA = "0x7473470", Offset = "0x7472870", VA = "0x187473470")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000006")]
		public RigidbodyEx FKDEHKMEOCL
		{
			[Cpp2IlInjected.Token(Token = "0x6000020")]
			[Cpp2IlInjected.Address(RVA = "0x74733B0", Offset = "0x74727B0", VA = "0x1874733B0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000007")]
		public RigidbodyEx IIOPLDELPHL
		{
			[Cpp2IlInjected.Token(Token = "0x6000021")]
			[Cpp2IlInjected.Address(RVA = "0x7474070", Offset = "0x7473470", VA = "0x187474070")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000022")]
			[Cpp2IlInjected.Address(RVA = "0x7475570", Offset = "0x7474970", VA = "0x187475570")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000008")]
		public Transform ADKLBBNAOED
		{
			[Cpp2IlInjected.Token(Token = "0x6000023")]
			[Cpp2IlInjected.Address(RVA = "0x8D3D90", Offset = "0x8D3190", VA = "0x1808D3D90", Slot = "9")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000009")]
		public Transform ELDALOHKJAP
		{
			[Cpp2IlInjected.Token(Token = "0x6000024")]
			[Cpp2IlInjected.Address(RVA = "0x8D3D90", Offset = "0x8D3190", VA = "0x1808D3D90", Slot = "10")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000A")]
		public NKELFIBCFCE HJPEGFBCCAB
		{
			[Cpp2IlInjected.Token(Token = "0x6000025")]
			[Cpp2IlInjected.Address(RVA = "0x7473170", Offset = "0x7472570", VA = "0x187473170")]
			get
			{
				return default(NKELFIBCFCE);
			}
			[Cpp2IlInjected.Token(Token = "0x6000026")]
			[Cpp2IlInjected.Address(RVA = "0x7474D20", Offset = "0x7474120", VA = "0x187474D20")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000B")]
		public bool FCDOJOKBAME
		{
			[Cpp2IlInjected.Token(Token = "0x6000027")]
			[Cpp2IlInjected.Address(RVA = "0x7473780", Offset = "0x7472B80", VA = "0x187473780")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000C")]
		public bool LFAFJEIDHAH
		{
			[Cpp2IlInjected.Token(Token = "0x6000028")]
			[Cpp2IlInjected.Address(RVA = "0x7473290", Offset = "0x7472690", VA = "0x187473290")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000D")]
		public KKMOFMFLGOJ JKDOEOFLFNE
		{
			[Cpp2IlInjected.Token(Token = "0x6000029")]
			[Cpp2IlInjected.Address(RVA = "0x74736C0", Offset = "0x7472AC0", VA = "0x1874736C0")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600002A")]
			[Cpp2IlInjected.Address(RVA = "0x7474EE0", Offset = "0x74742E0", VA = "0x187474EE0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000E")]
		public LPNGIGIDBDB NENIHDOJFOO
		{
			[Cpp2IlInjected.Token(Token = "0x600002B")]
			[Cpp2IlInjected.Address(RVA = "0x7473660", Offset = "0x7472A60", VA = "0x187473660")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600002C")]
			[Cpp2IlInjected.Address(RVA = "0x7474E70", Offset = "0x7474270", VA = "0x187474E70")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000F")]
		public bool JLDMJGGIEPO
		{
			[Cpp2IlInjected.Token(Token = "0x600002D")]
			[Cpp2IlInjected.Address(RVA = "0x74735B0", Offset = "0x74729B0", VA = "0x1874735B0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000010")]
		public Rigidbody CFDDIFJHEKO
		{
			[Cpp2IlInjected.Token(Token = "0x600002E")]
			[Cpp2IlInjected.Address(RVA = "0x7473610", Offset = "0x7472A10", VA = "0x187473610")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000011")]
		public bool LHMAAJBCAPO
		{
			[Cpp2IlInjected.Token(Token = "0x600002F")]
			[Cpp2IlInjected.Address(RVA = "0x74732F0", Offset = "0x74726F0", VA = "0x1874732F0")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000030")]
			[Cpp2IlInjected.Address(RVA = "0x7474D90", Offset = "0x7474190", VA = "0x187474D90")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000012")]
		public bool LOFCIJILFCP
		{
			[Cpp2IlInjected.Token(Token = "0x6000031")]
			[Cpp2IlInjected.Address(RVA = "0x71361F0", Offset = "0x71355F0", VA = "0x1871361F0", Slot = "7")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000013")]
		public float IBAIKJKNOPE
		{
			[Cpp2IlInjected.Token(Token = "0x6000032")]
			[Cpp2IlInjected.Address(RVA = "0x7474010", Offset = "0x7473410", VA = "0x187474010")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000014")]
		public float APCOMMKOIJO
		{
			[Cpp2IlInjected.Token(Token = "0x6000033")]
			[Cpp2IlInjected.Address(RVA = "0x7473FB0", Offset = "0x74733B0", VA = "0x187473FB0")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x6000034")]
			[Cpp2IlInjected.Address(RVA = "0x7475500", Offset = "0x7474900", VA = "0x187475500")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000015")]
		public float BGEJOOEAEGP
		{
			[Cpp2IlInjected.Token(Token = "0x6000035")]
			[Cpp2IlInjected.Address(RVA = "0x74739E0", Offset = "0x7472DE0", VA = "0x1874739E0")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x6000036")]
			[Cpp2IlInjected.Address(RVA = "0x7475180", Offset = "0x7474580", VA = "0x187475180")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000016")]
		public float KFCIMOFFMKG
		{
			[Cpp2IlInjected.Token(Token = "0x6000037")]
			[Cpp2IlInjected.Address(RVA = "0x74737E0", Offset = "0x7472BE0", VA = "0x1874737E0")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x6000038")]
			[Cpp2IlInjected.Address(RVA = "0x7474F50", Offset = "0x7474350", VA = "0x187474F50")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000017")]
		public bool MPCPHCDONPP
		{
			[Cpp2IlInjected.Token(Token = "0x6000039")]
			[Cpp2IlInjected.Address(RVA = "0x74745C0", Offset = "0x74739C0", VA = "0x1874745C0")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x600003A")]
			[Cpp2IlInjected.Address(RVA = "0x7475AB0", Offset = "0x7474EB0", VA = "0x187475AB0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000018")]
		public Vector3 NLIINEOEMBH
		{
			[Cpp2IlInjected.Token(Token = "0x600003B")]
			[Cpp2IlInjected.Address(RVA = "0x7473D90", Offset = "0x7473190", VA = "0x187473D90")]
			get
			{
				return default(Vector3);
			}
			[Cpp2IlInjected.Token(Token = "0x600003C")]
			[Cpp2IlInjected.Address(RVA = "0x74752D0", Offset = "0x74746D0", VA = "0x1874752D0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000019")]
		public Vector3 KCENOGICPMA
		{
			[Cpp2IlInjected.Token(Token = "0x600003D")]
			[Cpp2IlInjected.Address(RVA = "0x7474700", Offset = "0x7473B00", VA = "0x187474700")]
			get
			{
				return default(Vector3);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001A")]
		public CollisionDetectionMode MCJKPGLBFEM
		{
			[Cpp2IlInjected.Token(Token = "0x600003E")]
			[Cpp2IlInjected.Address(RVA = "0x7473920", Offset = "0x7472D20", VA = "0x187473920")]
			get
			{
				return default(CollisionDetectionMode);
			}
			[Cpp2IlInjected.Token(Token = "0x600003F")]
			[Cpp2IlInjected.Address(RVA = "0x74750A0", Offset = "0x74744A0", VA = "0x1874750A0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001B")]
		public float GLHFEEBAFIJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000040")]
			[Cpp2IlInjected.Address(RVA = "0x7473350", Offset = "0x7472750", VA = "0x187473350")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x6000041")]
			[Cpp2IlInjected.Address(RVA = "0x7474E00", Offset = "0x7474200", VA = "0x187474E00")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001C")]
		public RigidbodyConstraints ANBNDKFDKOP
		{
			[Cpp2IlInjected.Token(Token = "0x6000042")]
			[Cpp2IlInjected.Address(RVA = "0x7473980", Offset = "0x7472D80", VA = "0x187473980")]
			get
			{
				return default(RigidbodyConstraints);
			}
			[Cpp2IlInjected.Token(Token = "0x6000043")]
			[Cpp2IlInjected.Address(RVA = "0x7475110", Offset = "0x7474510", VA = "0x187475110")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001D")]
		public Vector3 PDCKJFNGKIO
		{
			[Cpp2IlInjected.Token(Token = "0x6000044")]
			[Cpp2IlInjected.Address(RVA = "0x7474130", Offset = "0x7473530", VA = "0x187474130")]
			get
			{
				return default(Vector3);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001E")]
		public Vector3 NEMMGADHHND
		{
			[Cpp2IlInjected.Token(Token = "0x6000045")]
			[Cpp2IlInjected.Address(RVA = "0x7474130", Offset = "0x7473530", VA = "0x187474130")]
			get
			{
				return default(Vector3);
			}
			[Cpp2IlInjected.Token(Token = "0x6000046")]
			[Cpp2IlInjected.Address(RVA = "0x7475890", Offset = "0x7474C90", VA = "0x187475890")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001F")]
		public float NDFBABACJEK
		{
			[Cpp2IlInjected.Token(Token = "0x6000047")]
			[Cpp2IlInjected.Address(RVA = "0x7473E70", Offset = "0x7473270", VA = "0x187473E70")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x6000048")]
			[Cpp2IlInjected.Address(RVA = "0x74753B0", Offset = "0x74747B0", VA = "0x1874753B0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000020")]
		public float IPCBIBILLCK
		{
			[Cpp2IlInjected.Token(Token = "0x6000049")]
			[Cpp2IlInjected.Address(RVA = "0x7474560", Offset = "0x7473960", VA = "0x187474560")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x600004A")]
			[Cpp2IlInjected.Address(RVA = "0x7475A40", Offset = "0x7474E40", VA = "0x187475A40")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000021")]
		public Quaternion KNBFEKKCCOJ
		{
			[Cpp2IlInjected.Token(Token = "0x600004B")]
			[Cpp2IlInjected.Address(RVA = "0x7474210", Offset = "0x7473610", VA = "0x187474210")]
			get
			{
				return default(Quaternion);
			}
			[Cpp2IlInjected.Token(Token = "0x600004C")]
			[Cpp2IlInjected.Address(RVA = "0x7475610", Offset = "0x7474A10", VA = "0x187475610")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000022")]
		public Quaternion ACJPMEEMBMI
		{
			[Cpp2IlInjected.Token(Token = "0x600004D")]
			[Cpp2IlInjected.Address(RVA = "0x7474490", Offset = "0x7473890", VA = "0x187474490")]
			get
			{
				return default(Quaternion);
			}
			[Cpp2IlInjected.Token(Token = "0x600004E")]
			[Cpp2IlInjected.Address(RVA = "0x7475970", Offset = "0x7474D70", VA = "0x187475970")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000023")]
		public Vector3 HPBBGDILHLI
		{
			[Cpp2IlInjected.Token(Token = "0x600004F")]
			[Cpp2IlInjected.Address(RVA = "0x74742E0", Offset = "0x74736E0", VA = "0x1874742E0")]
			get
			{
				return default(Vector3);
			}
			[Cpp2IlInjected.Token(Token = "0x6000050")]
			[Cpp2IlInjected.Address(RVA = "0x74756E0", Offset = "0x7474AE0", VA = "0x1874756E0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000024")]
		public Quaternion BICOAPMDOOE
		{
			[Cpp2IlInjected.Token(Token = "0x6000051")]
			[Cpp2IlInjected.Address(RVA = "0x74743C0", Offset = "0x74737C0", VA = "0x1874743C0")]
			get
			{
				return default(Quaternion);
			}
			[Cpp2IlInjected.Token(Token = "0x6000052")]
			[Cpp2IlInjected.Address(RVA = "0x74757C0", Offset = "0x7474BC0", VA = "0x1874757C0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000025")]
		public Vector3 NBBOFJMDBHM
		{
			[Cpp2IlInjected.Token(Token = "0x6000053")]
			[Cpp2IlInjected.Address(RVA = "0x7474620", Offset = "0x7473A20", VA = "0x187474620")]
			get
			{
				return default(Vector3);
			}
			[Cpp2IlInjected.Token(Token = "0x6000054")]
			[Cpp2IlInjected.Address(RVA = "0x7475B20", Offset = "0x7474F20", VA = "0x187475B20")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000026")]
		public Vector3 BPCNDMDPEND
		{
			[Cpp2IlInjected.Token(Token = "0x6000055")]
			[Cpp2IlInjected.Address(RVA = "0x7473ED0", Offset = "0x74732D0", VA = "0x187473ED0")]
			get
			{
				return default(Vector3);
			}
			[Cpp2IlInjected.Token(Token = "0x6000056")]
			[Cpp2IlInjected.Address(RVA = "0x7475420", Offset = "0x7474820", VA = "0x187475420")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000027")]
		public Vector3 DKHLGFLPFKA
		{
			[Cpp2IlInjected.Token(Token = "0x6000057")]
			[Cpp2IlInjected.Address(RVA = "0x7473840", Offset = "0x7472C40", VA = "0x187473840")]
			get
			{
				return default(Vector3);
			}
			[Cpp2IlInjected.Token(Token = "0x6000058")]
			[Cpp2IlInjected.Address(RVA = "0x7474FC0", Offset = "0x74743C0", VA = "0x187474FC0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000028")]
		public Vector3 EDLBDGENHAA
		{
			[Cpp2IlInjected.Token(Token = "0x6000059")]
			[Cpp2IlInjected.Address(RVA = "0x7473CB0", Offset = "0x74730B0", VA = "0x187473CB0")]
			get
			{
				return default(Vector3);
			}
			[Cpp2IlInjected.Token(Token = "0x600005A")]
			[Cpp2IlInjected.Address(RVA = "0x74751F0", Offset = "0x74745F0", VA = "0x1874751F0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000029")]
		public Vector3 KPHEAMINHPD
		{
			[Cpp2IlInjected.Token(Token = "0x600005B")]
			[Cpp2IlInjected.Address(RVA = "0x7473B70", Offset = "0x7472F70", VA = "0x187473B70")]
			get
			{
				return default(Vector3);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002A")]
		public Quaternion DDJHJPNPPDF
		{
			[Cpp2IlInjected.Token(Token = "0x600005C")]
			[Cpp2IlInjected.Address(RVA = "0x7473AA0", Offset = "0x7472EA0", VA = "0x187473AA0")]
			get
			{
				return default(Quaternion);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002B")]
		public Vector3 DCHOCHOIADB
		{
			[Cpp2IlInjected.Token(Token = "0x600005E")]
			[Cpp2IlInjected.Address(RVA = "0x74748C0", Offset = "0x7473CC0", VA = "0x1874748C0")]
			get
			{
				return default(Vector3);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002C")]
		public Vector3 NONOFIEAGPK
		{
			[Cpp2IlInjected.Token(Token = "0x600005F")]
			[Cpp2IlInjected.Address(RVA = "0x74747E0", Offset = "0x7473BE0", VA = "0x1874747E0")]
			get
			{
				return default(Vector3);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002D")]
		public bool DOCADGKKNNG
		{
			[Cpp2IlInjected.Token(Token = "0x6000060")]
			[Cpp2IlInjected.Address(RVA = "0x7473C50", Offset = "0x7473050", VA = "0x187473C50")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002E")]
		public bool JBAHNOEKKHB
		{
			[Cpp2IlInjected.Token(Token = "0x6000061")]
			[Cpp2IlInjected.Address(RVA = "0x7473720", Offset = "0x7472B20", VA = "0x187473720")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002F")]
		public bool KBELHLINADK
		{
			[Cpp2IlInjected.Token(Token = "0x6000062")]
			[Cpp2IlInjected.Address(RVA = "0x7473230", Offset = "0x7472630", VA = "0x187473230")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000030")]
		public bool BEKHABCBNKO
		{
			[Cpp2IlInjected.Token(Token = "0x6000063")]
			[Cpp2IlInjected.Address(RVA = "0x74731D0", Offset = "0x74725D0", VA = "0x1874731D0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000031")]
		public bool HOMKACFGKHM
		{
			[Cpp2IlInjected.Token(Token = "0x6000064")]
			[Cpp2IlInjected.Address(RVA = "0x74730B0", Offset = "0x74724B0", VA = "0x1874730B0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000032")]
		public bool JOEEADDENEG
		{
			[Cpp2IlInjected.Token(Token = "0x6000065")]
			[Cpp2IlInjected.Address(RVA = "0x7473A40", Offset = "0x7472E40", VA = "0x187473A40")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000033")]
		public bool NMBIACJCIOL
		{
			[Cpp2IlInjected.Token(Token = "0x6000066")]
			[Cpp2IlInjected.Address(RVA = "0x1C3F480", Offset = "0x1C3E880", VA = "0x181C3F480")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000001")]
		public event EGODMMHJIHF KLBJDGEBFGH
		{
			[Cpp2IlInjected.Token(Token = "0x600000D")]
			[Cpp2IlInjected.Address(RVA = "0x7472FD0", Offset = "0x74723D0", VA = "0x187472FD0")]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x600000E")]
			[Cpp2IlInjected.Address(RVA = "0x7474C40", Offset = "0x7474040", VA = "0x187474C40")]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000002")]
		public event NAKAIBCOGCG GDBMDOOJHFI
		{
			[Cpp2IlInjected.Token(Token = "0x600000F")]
			[Cpp2IlInjected.Address(RVA = "0x7472D40", Offset = "0x7472140", VA = "0x187472D40")]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000010")]
			[Cpp2IlInjected.Address(RVA = "0x74749A0", Offset = "0x7473DA0", VA = "0x1874749A0")]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000003")]
		public event NAKAIBCOGCG PGCCLNEEMNN
		{
			[Cpp2IlInjected.Token(Token = "0x6000011")]
			[Cpp2IlInjected.Address(RVA = "0x7472DA0", Offset = "0x74721A0", VA = "0x187472DA0")]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000012")]
			[Cpp2IlInjected.Address(RVA = "0x7474A10", Offset = "0x7473E10", VA = "0x187474A10")]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000004")]
		public event NAKAIBCOGCG MGMJFBGNMDA
		{
			[Cpp2IlInjected.Token(Token = "0x6000013")]
			[Cpp2IlInjected.Address(RVA = "0x7472EF0", Offset = "0x74722F0", VA = "0x187472EF0")]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000014")]
			[Cpp2IlInjected.Address(RVA = "0x7474B60", Offset = "0x7473F60", VA = "0x187474B60")]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000005")]
		public event Action<GGHKEJOODBA, GGHKEJOODBA> ICBMGNDEMLD
		{
			[Cpp2IlInjected.Token(Token = "0x6000015")]
			[Cpp2IlInjected.Address(RVA = "0x7472E80", Offset = "0x7472280", VA = "0x187472E80")]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000016")]
			[Cpp2IlInjected.Address(RVA = "0x7474AF0", Offset = "0x7473EF0", VA = "0x187474AF0")]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000006")]
		public event NAKAIBCOGCG BOLDJILGLMM
		{
			[Cpp2IlInjected.Token(Token = "0x6000017")]
			[Cpp2IlInjected.Address(RVA = "0x7472F60", Offset = "0x7472360", VA = "0x187472F60")]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000018")]
			[Cpp2IlInjected.Address(RVA = "0x7474BD0", Offset = "0x7473FD0", VA = "0x187474BD0")]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000007")]
		public event NAKAIBCOGCG MOALONIIINL
		{
			[Cpp2IlInjected.Token(Token = "0x6000019")]
			[Cpp2IlInjected.Address(RVA = "0x7473040", Offset = "0x7472440", VA = "0x187473040")]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x600001A")]
			[Cpp2IlInjected.Address(RVA = "0x7474CB0", Offset = "0x74740B0", VA = "0x187474CB0")]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000008")]
		public event NAKAIBCOGCG PIGECBNIHOO
		{
			[Cpp2IlInjected.Token(Token = "0x600001B")]
			[Cpp2IlInjected.Address(RVA = "0x7472E10", Offset = "0x7472210", VA = "0x187472E10")]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x600001C")]
			[Cpp2IlInjected.Address(RVA = "0x7474A80", Offset = "0x7473E80", VA = "0x187474A80")]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x8AA350", Offset = "0x8A9750", VA = "0x1808AA350", Slot = "8")]
		private void IMHLNMJJOMI(IFCIIPLFOCA GDIPKBJJCBL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x7471A30", Offset = "0x7470E30", VA = "0x187471A30")]
		internal void JJDINJBLOPG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x7472A70", Offset = "0x7471E70", VA = "0x187472A70")]
		[Conditional("DEBUG_BUILD")]
		[Conditional("UNITY_EDITOR")]
		public void TestOverrideUnityRigidbody(Rigidbody PJKIJHBJDPG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x7471470", Offset = "0x7470870", VA = "0x187471470")]
		public NADAIAGKPNF GetChild(int AEAHMAMPNLO)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600005D")]
		[Cpp2IlInjected.Address(RVA = "0x74726E0", Offset = "0x7471AE0", VA = "0x1874726E0")]
		public void SetInertiaTensor((Quaternion rot, Vector3 moments) FHCHCEFKJNC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000067")]
		[Cpp2IlInjected.Address(RVA = "0x7471220", Offset = "0x7470620", VA = "0x187471220")]
		private void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000068")]
		[Cpp2IlInjected.Address(RVA = "0x7471720", Offset = "0x7470B20", VA = "0x187471720")]
		private IFCIIPLFOCA IJAGADEGMFN()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000069")]
		[Cpp2IlInjected.Address(RVA = "0x7471AC0", Offset = "0x7470EC0", VA = "0x187471AC0")]
		private void LHMGAKDCLGK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006A")]
		[Cpp2IlInjected.Address(RVA = "0x7471EB0", Offset = "0x74712B0", VA = "0x187471EB0")]
		private void OnEnable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006B")]
		[Cpp2IlInjected.Address(RVA = "0x7471A30", Offset = "0x7470E30", VA = "0x187471A30")]
		private void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006C")]
		[Cpp2IlInjected.Address(RVA = "0x7471E50", Offset = "0x7471250", VA = "0x187471E50")]
		private void OnDrawGizmosSelected()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006D")]
		[Cpp2IlInjected.Address(RVA = "0x7471F10", Offset = "0x7471310", VA = "0x187471F10")]
		private void OnValidate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006E")]
		[Cpp2IlInjected.Address(RVA = "0x7470810", Offset = "0x746FC10", VA = "0x187470810")]
		public void AddDoNotResetVelocityOnOwnershipChangeOverride(object FDAIGOGAKMH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006F")]
		[Cpp2IlInjected.Address(RVA = "0x7471F70", Offset = "0x7471370", VA = "0x187471F70")]
		public void RemoveDoNotResetVelocityOnOwnershipChangeOverride(object FDAIGOGAKMH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000070")]
		[Cpp2IlInjected.Address(RVA = "0x7471410", Offset = "0x7470810", VA = "0x187471410")]
		public void DisableCachedInertialPropertyOverride()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000071")]
		[Cpp2IlInjected.Address(RVA = "0x7471DF0", Offset = "0x74711F0", VA = "0x187471DF0")]
		public void MarkCachedInertialParametersDirty()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000072")]
		[Cpp2IlInjected.Address(RVA = "0x7472840", Offset = "0x7471C40", VA = "0x187472840")]
		public void SetParent(RigidbodyEx LIHHDPOHLDK, bool FHCBEIGKGNF = false)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000073")]
		[Cpp2IlInjected.Address(RVA = "0x7472280", Offset = "0x7471680", VA = "0x187472280")]
		public void ResetLocalCenterOfMassToPrefabDefault()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000074")]
		[Cpp2IlInjected.Address(RVA = "0x74717D0", Offset = "0x7470BD0", VA = "0x1874717D0")]
		public bool IsRigidbodyAncestor(RigidbodyEx NJFKHIKGMKO)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000075")]
		[Cpp2IlInjected.Address(RVA = "0x74718D0", Offset = "0x7470CD0", VA = "0x1874718D0")]
		public bool IsRigidbodyDescendant(RigidbodyEx BABEFKNCIME)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000076")]
		[Cpp2IlInjected.Address(RVA = "0x7470A80", Offset = "0x746FE80", VA = "0x187470A80")]
		public void AddInterpolationRestriction(object FDAIGOGAKMH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000077")]
		[Cpp2IlInjected.Address(RVA = "0x7471FE0", Offset = "0x74713E0", VA = "0x187471FE0")]
		public void RemoveInterpolationRestriction(object FDAIGOGAKMH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000078")]
		[Cpp2IlInjected.Address(RVA = "0x7470AF0", Offset = "0x746FEF0", VA = "0x187470AF0")]
		public void AddKinematic(object FDAIGOGAKMH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000079")]
		[Cpp2IlInjected.Address(RVA = "0x7472050", Offset = "0x7471450", VA = "0x187472050")]
		public void RemoveKinematic(object FDAIGOGAKMH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007A")]
		[Cpp2IlInjected.Address(RVA = "0x74727C0", Offset = "0x7471BC0", VA = "0x1874727C0")]
		public void SetKinematic(object FDAIGOGAKMH, bool ONDEKDBNJLL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007B")]
		[Cpp2IlInjected.Address(RVA = "0x74725E0", Offset = "0x74719E0", VA = "0x1874725E0")]
		public void SetDiscontinuousPositionAndRotation(Vector3 EFNINBBEGAA, Quaternion CAKGDLIFNNG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007C")]
		[Cpp2IlInjected.Address(RVA = "0x74724E0", Offset = "0x74718E0", VA = "0x1874724E0")]
		public void SetDiscontinuousLocalPositionAndLocalRotation(Vector3 AMAEBLOGDOI, Quaternion CADLCHPONLN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007D")]
		[Cpp2IlInjected.Address(RVA = "0x7471610", Offset = "0x7470A10", VA = "0x187471610")]
		public Vector3 GetConstrainedVelocity(Vector3 NBBOFJMDBHM)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x600007E")]
		[Cpp2IlInjected.Address(RVA = "0x7471500", Offset = "0x7470900", VA = "0x187471500")]
		public Vector3 GetConstrainedAngularVelocity(Vector3 DKHLGFLPFKA)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x600007F")]
		[Cpp2IlInjected.Address(RVA = "0x7470990", Offset = "0x746FD90", VA = "0x187470990")]
		public void AddForce(Vector3 DPEDJCGKFCE, ForceMode BHNFLFIOPOK = ForceMode.Force)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000080")]
		[Cpp2IlInjected.Address(RVA = "0x7470880", Offset = "0x746FC80", VA = "0x187470880")]
		public void AddForceAtPosition(Vector3 DPEDJCGKFCE, Vector3 MBJNFCDOKCE, ForceMode BHNFLFIOPOK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000081")]
		[Cpp2IlInjected.Address(RVA = "0x7470CC0", Offset = "0x74700C0", VA = "0x187470CC0")]
		public void AddTorque(Vector3 DLBJNJMLGAM, ForceMode BHNFLFIOPOK = ForceMode.Force)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000082")]
		[Cpp2IlInjected.Address(RVA = "0x7470B60", Offset = "0x746FF60", VA = "0x187470B60")]
		public void AddRelativeTorque(Vector3 DLBJNJMLGAM, ForceMode BHNFLFIOPOK = ForceMode.Force)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000083")]
		[Cpp2IlInjected.Address(RVA = "0x7472B40", Offset = "0x7471F40", VA = "0x187472B40")]
		public Vector3 WorldToLocalVelocity(Vector3 EBLBHKKBIIJ)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x6000084")]
		[Cpp2IlInjected.Address(RVA = "0x7471CE0", Offset = "0x74710E0", VA = "0x187471CE0")]
		public Vector3 LocalToWorldVelocity(Vector3 BPCNDMDPEND)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x6000085")]
		[Cpp2IlInjected.Address(RVA = "0x74713B0", Offset = "0x74707B0", VA = "0x1874713B0")]
		public void ClearVelocity()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000086")]
		[Cpp2IlInjected.Address(RVA = "0x7471350", Offset = "0x7470750", VA = "0x187471350")]
		public void ClearUnityRigidbodyVelocity()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000087")]
		[Cpp2IlInjected.Address(RVA = "0x74712F0", Offset = "0x74706F0", VA = "0x1874712F0")]
		public void ClearLinearVelocity()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000088")]
		[Cpp2IlInjected.Address(RVA = "0x7471290", Offset = "0x7470690", VA = "0x187471290")]
		public void ClearAngularVelocity()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000089")]
		[Cpp2IlInjected.Address(RVA = "0x74723E0", Offset = "0x74717E0", VA = "0x1874723E0")]
		public void ResetVelocityWorldSpace(Vector3 GOFDGAKBMGI, Vector3 FCECEIAJGMC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008A")]
		[Cpp2IlInjected.Address(RVA = "0x74722E0", Offset = "0x74716E0", VA = "0x1874722E0")]
		public void ResetVelocityLocalSpace(Vector3 KELAFHBGMAO, Vector3 EDLBDGENHAA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008B")]
		[Cpp2IlInjected.Address(RVA = "0x74721A0", Offset = "0x74715A0", VA = "0x1874721A0")]
		public void ResetLinearVelocityLocalSpace(Vector3 KELAFHBGMAO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008C")]
		[Cpp2IlInjected.Address(RVA = "0x7472970", Offset = "0x7471D70", VA = "0x187472970")]
		public bool SweepTest(Vector3 NLEBNOPPEID, [Out] RaycastHit EDEJMIIPLJN, float MALFDDNHAMM)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600008D")]
		[Cpp2IlInjected.Address(RVA = "0x74719D0", Offset = "0x7470DD0", VA = "0x1874719D0")]
		public bool IsSleeping()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600008E")]
		[Cpp2IlInjected.Address(RVA = "0x7472910", Offset = "0x7471D10", VA = "0x187472910")]
		public void Sleep()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008F")]
		[Cpp2IlInjected.Address(RVA = "0x7472AE0", Offset = "0x7471EE0", VA = "0x187472AE0")]
		public void WakeUp()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000090")]
		[Cpp2IlInjected.Address(RVA = "0x7470C50", Offset = "0x7470050", VA = "0x187470C50")]
		public void AddShouldHaveUnityRigidbodyToken(object FDAIGOGAKMH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000091")]
		[Cpp2IlInjected.Address(RVA = "0x74720C0", Offset = "0x74714C0", VA = "0x1874720C0")]
		public void RemoveShouldHaveUnityRigidbodyToken(object FDAIGOGAKMH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000092")]
		[Cpp2IlInjected.Address(RVA = "0x7471050", Offset = "0x7470450", VA = "0x187471050")]
		public void ApplyForceVelocityChange(IIKHDPMFHDE BAPJDEHMLHH, Vector3 MNDBPOBDCNJ, float BFAPEHFPHCD, float NBNFHECNAHB = 8f, float INCOBGEGFMH = 1f)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000093")]
		[Cpp2IlInjected.Address(RVA = "0x7470F50", Offset = "0x7470350", VA = "0x187470F50")]
		public void ApplyAngularVelocityChange(CNPLNPFECCE JHMJLILENAP, Vector3 OKNBNOENDPK, float BMCEHNOGEJG = float.PositiveInfinity)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000094")]
		[Cpp2IlInjected.Address(RVA = "0x7471110", Offset = "0x7470510", VA = "0x187471110")]
		[Obsolete("Deprecated. Still exists to support deprecated CV2 chips. Use ApplyAngularVelocityChange.")]
		public void ApplyTorqueAngularVelocityChangeDeprecated(CNPLNPFECCE JHMJLILENAP, Vector3 EFFHGIJAIIE, float BJOPNKBDJGB = 7f, float IPFBOIJJMOB = 1f)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000095")]
		[Cpp2IlInjected.Address(RVA = "0x7470E80", Offset = "0x7470280", VA = "0x187470E80")]
		public bool AllowedScaleChange(float EGIABFGPJJA)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000096")]
		[Cpp2IlInjected.Address(RVA = "0x7470DB0", Offset = "0x74701B0", VA = "0x187470DB0")]
		public void AddWorldSpaceVelocityInHierarchyParentOverride(RigidbodyEx HOOAJDBEAGF, object FDAIGOGAKMH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000097")]
		[Cpp2IlInjected.Address(RVA = "0x7472130", Offset = "0x7471530", VA = "0x187472130")]
		public void RemoveWorldSpaceVelocityInHierarchyParentOverride(object FDAIGOGAKMH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000098")]
		[Cpp2IlInjected.Address(RVA = "0x7472CD0", Offset = "0x74720D0", VA = "0x187472CD0")]
		public RigidbodyEx()
		{
		}

		[SpecialName]
		[Cpp2IlInjected.Token(Token = "0x600009A")]
		[Cpp2IlInjected.Address(RVA = "0xCDBB70", Offset = "0xCDAF70", VA = "0x180CDBB70", Slot = "4")]
		private GameObject ILEPGEGLPNI()
		{
			return null;
		}

		[SpecialName]
		[Cpp2IlInjected.Token(Token = "0x600009B")]
		[Cpp2IlInjected.Address(RVA = "0x8D3D90", Offset = "0x8D3190", VA = "0x1808D3D90", Slot = "5")]
		private Transform CBDFOJDMJFC()
		{
			return null;
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
internal static class BAIDOPNHPAM
{
	[Cpp2IlInjected.Token(Token = "0x600009C")]
	[Cpp2IlInjected.Address(RVA = "0x745A490", Offset = "0x7459890", VA = "0x18745A490")]
	public static IFCIIPLFOCA JLNLNODPCMP(this RigidbodyEx DODIHPOGMBH)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
[DKHNDPDIDGH(typeof(KFKIDNCNBPA), new string[] { })]
public class KGCJOIKINBG : KFKIDNCNBPA, KHBMANBAPGM
{
	[Cpp2IlInjected.Token(Token = "0x400000F")]
	private static readonly EGGMDNJPOBA DFDLACHAHGJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000010")]
	private KBDFHAMLBOL KLBPBADFKHP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000011")]
	private MEELPKKBHKP AJKICPHDFFF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000012")]
	private GKAOAHDNLME JBCHOEJDLGI;

	[Cpp2IlInjected.Token(Token = "0x17000034")]
	public MEELPKKBHKP HEHDJMJINLD
	{
		[Cpp2IlInjected.Token(Token = "0x600009D")]
		[Cpp2IlInjected.Address(RVA = "0x8A9F10", Offset = "0x8A9310", VA = "0x1808A9F10", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000035")]
	public GKAOAHDNLME CKCHNKBNKLN
	{
		[Cpp2IlInjected.Token(Token = "0x600009E")]
		[Cpp2IlInjected.Address(RVA = "0x8AA330", Offset = "0x8A9730", VA = "0x1808AA330", Slot = "5")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600009F")]
	[Cpp2IlInjected.Address(RVA = "0x7468330", Offset = "0x7467730", VA = "0x187468330", Slot = "7")]
	public void InitReferences(IAKDMLIJPDA NEOPINGDODK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A0")]
	[Cpp2IlInjected.Address(RVA = "0x7468220", Offset = "0x7467620", VA = "0x187468220", Slot = "6")]
	public IFCIIPLFOCA DNNIJNIMPPK(RigidbodyEx DODIHPOGMBH, KDAAIDJOOBC MPMEGOKIEPF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000A1")]
	[Cpp2IlInjected.Address(RVA = "0x8B7800", Offset = "0x8B6C00", VA = "0x1808B7800")]
	public KGCJOIKINBG()
	{
	}
}
namespace RecRoom
{
	[Cpp2IlInjected.Token(Token = "0x2000007")]
	public class PhysicsManager : SingletonMonoBehaviour<PhysicsManager>
	{
		[Cpp2IlInjected.Token(Token = "0x4000013")]
		public static LKILNMKOKHH UpdateAfterFixedUpdateRan;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000014")]
		private int EEFFNPDEAIJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x4000015")]
		private int ECGPDANIFPN;

		[Cpp2IlInjected.Token(Token = "0x60000A3")]
		[Cpp2IlInjected.Address(RVA = "0x7470690", Offset = "0x746FA90", VA = "0x187470690")]
		protected void FixedUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A4")]
		[Cpp2IlInjected.Address(RVA = "0x74706D0", Offset = "0x746FAD0", VA = "0x1874706D0")]
		protected void Update()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A5")]
		[Cpp2IlInjected.Address(RVA = "0x74706B0", Offset = "0x746FAB0", VA = "0x1874706B0")]
		protected void LateUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A6")]
		[Cpp2IlInjected.Address(RVA = "0x8ABE30", Offset = "0x8AB230", VA = "0x1808ABE30")]
		[Conditional("UNITY_ASSERTIONS")]
		public void AssertLateColliderPositionsNotYetUpdated([Optional] string ADPAIBGIHMB, [Optional] UnityEngine.Object JCPOMHNJOIE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A7")]
		[Cpp2IlInjected.Address(RVA = "0x8ABE30", Offset = "0x8AB230", VA = "0x1808ABE30")]
		[Conditional("UNITY_ASSERTIONS")]
		public void AssertLateColliderPositionsAlreadyUpdated([Optional] string ADPAIBGIHMB, [Optional] UnityEngine.Object JCPOMHNJOIE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A8")]
		[Cpp2IlInjected.Address(RVA = "0x74707C0", Offset = "0x746FBC0", VA = "0x1874707C0")]
		public PhysicsManager()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
public static class NDCKLJACCHM
{
	[Cpp2IlInjected.Token(Token = "0x2000009")]
	private class GIAFNAKIDDD : KKMOFMFLGOJ, IDisposable
	{
		[Cpp2IlInjected.Token(Token = "0x60000AC")]
		[Cpp2IlInjected.Address(RVA = "0x8ABE30", Offset = "0x8AB230", VA = "0x1808ABE30", Slot = "6")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AD")]
		[Cpp2IlInjected.Address(RVA = "0x8BAB70", Offset = "0x8B9F70", VA = "0x1808BAB70", Slot = "4")]
		public Vector3 DAABBPKHGBF()
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x60000AE")]
		[Cpp2IlInjected.Address(RVA = "0x8BAB70", Offset = "0x8B9F70", VA = "0x1808BAB70", Slot = "5")]
		public Vector3 KAMLPICJAPD()
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x60000AF")]
		[Cpp2IlInjected.Address(RVA = "0x8B7800", Offset = "0x8B6C00", VA = "0x1808B7800")]
		public GIAFNAKIDDD()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000036")]
	public static KKMOFMFLGOJ JJDFHALFGIG
	{
		[Cpp2IlInjected.Token(Token = "0x60000AA")]
		[Cpp2IlInjected.Address(RVA = "0x7468690", Offset = "0x7467A90", VA = "0x187468690")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
public interface NIOGLPDPALJ
{
	[Cpp2IlInjected.Token(Token = "0x17000037")]
	CollisionDetectionMode ANEBIFEMAJG
	{
		[Cpp2IlInjected.Token(Token = "0x60000B0")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
		[Cpp2IlInjected.Token(Token = "0x60000B1")]
		[Cpp2IlInjected.Address(Slot = "1")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x60000B2")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void JBLDGJLDMEF();

	[Cpp2IlInjected.Token(Token = "0x60000B3")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void DCLILJNDEOI(bool DOCADGKKNNG);

	[Cpp2IlInjected.Token(Token = "0x60000B4")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void PNKBMGGOAMP(bool DOCADGKKNNG);

	[Cpp2IlInjected.Token(Token = "0x60000B5")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void BLEFDCFMIJN(Rigidbody GJHIIOHAAJN);

	[Cpp2IlInjected.Token(Token = "0x60000B6")]
	[Cpp2IlInjected.Address(Slot = "6")]
	bool MGCMBIFLOBP(Vector3 NLEBNOPPEID, [Out] RaycastHit EDEJMIIPLJN, float MALFDDNHAMM);
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
public interface OIHMMOOMIOD : IDisposable, MGJHENFBMOI
{
	[Cpp2IlInjected.Token(Token = "0x17000038")]
	NKELFIBCFCE HJPEGFBCCAB
	{
		[Cpp2IlInjected.Token(Token = "0x60000B9")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
		[Cpp2IlInjected.Token(Token = "0x60000BA")]
		[Cpp2IlInjected.Address(Slot = "3")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x14000009")]
	event Action<GGHKEJOODBA, GGHKEJOODBA> ICBMGNDEMLD;

	[Cpp2IlInjected.Token(Token = "0x60000BB")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void JBLDGJLDMEF();
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
[CMNNIKGKEON(MFDGBKGGINJ.Application)]
public interface GKAOAHDNLME
{
	[Cpp2IlInjected.Token(Token = "0x60000BC")]
	[Cpp2IlInjected.Address(Slot = "0")]
	IBKMOLDIGIP FNHHFOECKIG(IFCIIPLFOCA GDIPKBJJCBL);

	[Cpp2IlInjected.Token(Token = "0x60000BD")]
	[Cpp2IlInjected.Address(Slot = "1")]
	MHEKBCJDIFI ABJIOJDACHB(IFCIIPLFOCA GDIPKBJJCBL);

	[Cpp2IlInjected.Token(Token = "0x60000BE")]
	[Cpp2IlInjected.Address(Slot = "2")]
	BAFNGHIJNLF NDKGKONIHNN(IFCIIPLFOCA GDIPKBJJCBL);

	[Cpp2IlInjected.Token(Token = "0x60000BF")]
	[Cpp2IlInjected.Address(Slot = "3")]
	NAONIBBKJJC PFEPECCPNKM(IFCIIPLFOCA GDIPKBJJCBL);

	[Cpp2IlInjected.Token(Token = "0x60000C0")]
	[Cpp2IlInjected.Address(Slot = "4")]
	BMLKALHMELK CDDPEOPCDFG(IFCIIPLFOCA GDIPKBJJCBL);

	[Cpp2IlInjected.Token(Token = "0x60000C1")]
	[Cpp2IlInjected.Address(Slot = "5")]
	OIHMMOOMIOD KGNLENCICKN(IFCIIPLFOCA GDIPKBJJCBL);

	[Cpp2IlInjected.Token(Token = "0x60000C2")]
	[Cpp2IlInjected.Address(Slot = "6")]
	APAEMPIJCMB JHICAJAJFKA(IFCIIPLFOCA GDIPKBJJCBL);

	[Cpp2IlInjected.Token(Token = "0x60000C3")]
	[Cpp2IlInjected.Address(Slot = "7")]
	NLEBPALKPEF LLDKKJIANAG(IFCIIPLFOCA GDIPKBJJCBL);

	[Cpp2IlInjected.Token(Token = "0x60000C4")]
	[Cpp2IlInjected.Address(Slot = "8")]
	NIOGLPDPALJ AHLLGGGOLHC(IFCIIPLFOCA GDIPKBJJCBL);

	[Cpp2IlInjected.Token(Token = "0x60000C5")]
	[Cpp2IlInjected.Address(Slot = "9")]
	EDMKMOGFBPP MPBPAHCBHAE(IFCIIPLFOCA GDIPKBJJCBL);

	[Cpp2IlInjected.Token(Token = "0x60000C6")]
	[Cpp2IlInjected.Address(Slot = "10")]
	LIOKBCGOPHC LDKDGLKNNMN(IFCIIPLFOCA GDIPKBJJCBL, [In] KDAAIDJOOBC MPMEGOKIEPF);

	[Cpp2IlInjected.Token(Token = "0x60000C7")]
	[Cpp2IlInjected.Address(Slot = "11")]
	FNCIFHKHEPA POLPMIGLGPM(IFCIIPLFOCA GDIPKBJJCBL, [In] KDAAIDJOOBC MPMEGOKIEPF);

	[Cpp2IlInjected.Token(Token = "0x60000C8")]
	[Cpp2IlInjected.Address(Slot = "12")]
	CJNBDDJPPFL EPELFPBDIPB(IFCIIPLFOCA GDIPKBJJCBL, [In] KDAAIDJOOBC MPMEGOKIEPF);

	[Cpp2IlInjected.Token(Token = "0x60000C9")]
	[Cpp2IlInjected.Address(Slot = "13")]
	EHCMCNEDKLA HHEJNEOAJNI(IFCIIPLFOCA GDIPKBJJCBL, [In] KDAAIDJOOBC MPMEGOKIEPF);

	[Cpp2IlInjected.Token(Token = "0x60000CA")]
	[Cpp2IlInjected.Address(Slot = "14")]
	NPPMLEINIBM MPPKBLFBIOD(IFCIIPLFOCA GDIPKBJJCBL, [In] KDAAIDJOOBC MPMEGOKIEPF);

	[Cpp2IlInjected.Token(Token = "0x60000CB")]
	[Cpp2IlInjected.Address(Slot = "15")]
	IFCIIPLFOCA DNNIJNIMPPK(RigidbodyEx DODIHPOGMBH, KDAAIDJOOBC MPMEGOKIEPF, KFKIDNCNBPA HPCAPMNEHGA);
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
public interface NLEBPALKPEF
{
	[Cpp2IlInjected.Token(Token = "0x60000CC")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void INGLGIDKDGP(Vector3 DPEDJCGKFCE, ForceMode BHNFLFIOPOK = ForceMode.Force);

	[Cpp2IlInjected.Token(Token = "0x60000CD")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void DCOANGBBPLD(Vector3 DPEDJCGKFCE, Vector3 MBJNFCDOKCE, ForceMode BHNFLFIOPOK);

	[Cpp2IlInjected.Token(Token = "0x60000CE")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void JLECGFMKICL(Vector3 DLBJNJMLGAM, ForceMode BHNFLFIOPOK = ForceMode.Force);

	[Cpp2IlInjected.Token(Token = "0x60000CF")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void HJKCNGGNMIG(Vector3 DLBJNJMLGAM, ForceMode BHNFLFIOPOK = ForceMode.Force);
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
public interface EDMKMOGFBPP
{
	[Cpp2IlInjected.Token(Token = "0x17000039")]
	bool DEFHIOIJCFC
	{
		[Cpp2IlInjected.Token(Token = "0x60000D0")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
		[Cpp2IlInjected.Token(Token = "0x60000D1")]
		[Cpp2IlInjected.Address(Slot = "1")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x60000D2")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void BLEFDCFMIJN(Rigidbody GJHIIOHAAJN);

	[Cpp2IlInjected.Token(Token = "0x60000D3")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void NMLKFMMMKPL(Rigidbody GJHIIOHAAJN);
}
[Cpp2IlInjected.Token(Token = "0x200000F")]
public interface IBKMOLDIGIP : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x1700003A")]
	IReadOnlyList<IFCIIPLFOCA> PMONIJFECNE
	{
		[Cpp2IlInjected.Token(Token = "0x60000E6")]
		[Cpp2IlInjected.Address(Slot = "18")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700003B")]
	IFCIIPLFOCA FKDEHKMEOCL
	{
		[Cpp2IlInjected.Token(Token = "0x60000E7")]
		[Cpp2IlInjected.Address(Slot = "19")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700003C")]
	IFCIIPLFOCA DIEIKKLOHIA
	{
		[Cpp2IlInjected.Token(Token = "0x60000E8")]
		[Cpp2IlInjected.Address(Slot = "20")]
		get;
		[Cpp2IlInjected.Token(Token = "0x60000E9")]
		[Cpp2IlInjected.Address(Slot = "21")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x1400000A")]
	event NAKAIBCOGCG GDBMDOOJHFI;

	[Cpp2IlInjected.Token(Token = "0x1400000B")]
	event NAKAIBCOGCG PGCCLNEEMNN;

	[Cpp2IlInjected.Token(Token = "0x1400000C")]
	event EGODMMHJIHF GGLBNLKBFBC;

	[Cpp2IlInjected.Token(Token = "0x1400000D")]
	event Action BGFGNGIAHPP;

	[Cpp2IlInjected.Token(Token = "0x1400000E")]
	event Action KDFKEHPMAFO;

	[Cpp2IlInjected.Token(Token = "0x1400000F")]
	event Action<IFCIIPLFOCA> NIBDNIAMOKD;

	[Cpp2IlInjected.Token(Token = "0x14000010")]
	event Action<IFCIIPLFOCA> HIODMAHJOKN;

	[Cpp2IlInjected.Token(Token = "0x14000011")]
	event Action JHIDFLNDFIO;

	[Cpp2IlInjected.Token(Token = "0x14000012")]
	event Action<IFCIIPLFOCA> AOLCDDNCKOH;

	[Cpp2IlInjected.Token(Token = "0x60000EA")]
	[Cpp2IlInjected.Address(Slot = "22")]
	void DDIJPNBLPCC(IFCIIPLFOCA FFCFOAEFPGC, bool FHCBEIGKGNF = false);
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
public interface BAFNGHIJNLF
{
	[Cpp2IlInjected.Token(Token = "0x1700003D")]
	Vector3 LJEFKJLILDI
	{
		[Cpp2IlInjected.Token(Token = "0x60000EB")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700003E")]
	Vector3 HMEFMECHEOB
	{
		[Cpp2IlInjected.Token(Token = "0x60000EC")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x60000ED")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void EDDFFEFGFPP(IFCIIPLFOCA IIOPLDELPHL, object FDAIGOGAKMH);

	[Cpp2IlInjected.Token(Token = "0x60000EE")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void AMAPHGFGPCJ(object FDAIGOGAKMH);
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
public interface EHCMCNEDKLA
{
	[Cpp2IlInjected.Token(Token = "0x1700003F")]
	Vector3 KOJBKCKDCOM
	{
		[Cpp2IlInjected.Token(Token = "0x60000F1")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
		[Cpp2IlInjected.Token(Token = "0x60000F2")]
		[Cpp2IlInjected.Address(Slot = "3")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000040")]
	Vector3 ADOGIKLOPOE
	{
		[Cpp2IlInjected.Token(Token = "0x60000F3")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000041")]
	float PKEBGGMFHGB
	{
		[Cpp2IlInjected.Token(Token = "0x60000F4")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000042")]
	float JACGGPKPOHK
	{
		[Cpp2IlInjected.Token(Token = "0x60000F5")]
		[Cpp2IlInjected.Address(Slot = "6")]
		get;
		[Cpp2IlInjected.Token(Token = "0x60000F6")]
		[Cpp2IlInjected.Address(Slot = "7")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000043")]
	Vector3 AGJEOCNFDLJ
	{
		[Cpp2IlInjected.Token(Token = "0x60000F7")]
		[Cpp2IlInjected.Address(Slot = "8")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000044")]
	Quaternion NKHOHGNBGLO
	{
		[Cpp2IlInjected.Token(Token = "0x60000F8")]
		[Cpp2IlInjected.Address(Slot = "9")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x14000013")]
	event NAKAIBCOGCG KDIGJAFGOED;

	[Cpp2IlInjected.Token(Token = "0x60000F9")]
	[Cpp2IlInjected.Address(Slot = "10")]
	void BDFAMNPGEOK((Quaternion rot, Vector3 moments) FHCHCEFKJNC);

	[Cpp2IlInjected.Token(Token = "0x60000FA")]
	[Cpp2IlInjected.Address(Slot = "11")]
	void GLPGBCBEBAK();

	[Cpp2IlInjected.Token(Token = "0x60000FB")]
	[Cpp2IlInjected.Address(Slot = "12")]
	void EAKOJKGNPNH();

	[Cpp2IlInjected.Token(Token = "0x60000FC")]
	[Cpp2IlInjected.Address(Slot = "13")]
	void IGOIGPBJBLN();

	[Cpp2IlInjected.Token(Token = "0x60000FD")]
	[Cpp2IlInjected.Address(Slot = "14")]
	void BLEFDCFMIJN(Rigidbody GJHIIOHAAJN);

	[Cpp2IlInjected.Token(Token = "0x60000FE")]
	[Cpp2IlInjected.Address(Slot = "15")]
	void NMLKFMMMKPL(Rigidbody GJHIIOHAAJN);

	[Cpp2IlInjected.Token(Token = "0x60000FF")]
	[Cpp2IlInjected.Address(Slot = "16")]
	void FHIJIPKLAKG();
}
[Cpp2IlInjected.Token(Token = "0x2000012")]
public interface CJNBDDJPPFL
{
	[Cpp2IlInjected.Token(Token = "0x6000100")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void JBLDGJLDMEF();

	[Cpp2IlInjected.Token(Token = "0x6000101")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void NEELPFHOPGA(object FDAIGOGAKMH);

	[Cpp2IlInjected.Token(Token = "0x6000102")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void AMMODAKCNKO(object FDAIGOGAKMH);

	[Cpp2IlInjected.Token(Token = "0x6000103")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void FHIAEOEOEBJ(IFCIIPLFOCA DODIHPOGMBH);

	[Cpp2IlInjected.Token(Token = "0x6000104")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void KKFJNIBFFEB(IFCIIPLFOCA DODIHPOGMBH);

	[Cpp2IlInjected.Token(Token = "0x6000105")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void OMGIAIPKGHE();
}
[Cpp2IlInjected.Token(Token = "0x2000013")]
public interface APAEMPIJCMB
{
	[Cpp2IlInjected.Token(Token = "0x17000045")]
	bool DBMGBKHLGGG
	{
		[Cpp2IlInjected.Token(Token = "0x6000108")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x14000014")]
	event NAKAIBCOGCG HBPOHBEMCJE;

	[Cpp2IlInjected.Token(Token = "0x6000109")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void NCOOPPCENCG(object FDAIGOGAKMH);

	[Cpp2IlInjected.Token(Token = "0x600010A")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void GNNECMKMACC(object FDAIGOGAKMH);

	[Cpp2IlInjected.Token(Token = "0x600010B")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void JKCFLPNEIDO(object FDAIGOGAKMH, bool ONDEKDBNJLL);

	[Cpp2IlInjected.Token(Token = "0x600010C")]
	[Cpp2IlInjected.Address(Slot = "6")]
	void BLEFDCFMIJN(Rigidbody AMNBHPNNAMP);

	[Cpp2IlInjected.Token(Token = "0x600010D")]
	[Cpp2IlInjected.Address(Slot = "7")]
	void NMLKFMMMKPL(Rigidbody GJHIIOHAAJN);
}
[Cpp2IlInjected.Token(Token = "0x2000014")]
public interface FNCIFHKHEPA : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x17000046")]
	bool FCDOJOKBAME
	{
		[Cpp2IlInjected.Token(Token = "0x6000110")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000047")]
	bool LFAFJEIDHAH
	{
		[Cpp2IlInjected.Token(Token = "0x6000111")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x14000015")]
	event NAKAIBCOGCG HNJMPMFKHDK;

	[Cpp2IlInjected.Token(Token = "0x6000112")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void JBLDGJLDMEF();

	[Cpp2IlInjected.Token(Token = "0x6000113")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void BDDHKFOMOLP(IFCIIPLFOCA IIOPLDELPHL);

	[Cpp2IlInjected.Token(Token = "0x6000114")]
	[Cpp2IlInjected.Address(Slot = "6")]
	void FCGLPJAFLJE(IFCIIPLFOCA IIOPLDELPHL);
}
[Cpp2IlInjected.Token(Token = "0x2000015")]
public interface NPPMLEINIBM
{
	[Cpp2IlInjected.Token(Token = "0x17000048")]
	bool LHMAAJBCAPO
	{
		[Cpp2IlInjected.Token(Token = "0x6000115")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
		[Cpp2IlInjected.Token(Token = "0x6000116")]
		[Cpp2IlInjected.Address(Slot = "1")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000049")]
	bool AIDGFLJIEHK
	{
		[Cpp2IlInjected.Token(Token = "0x6000117")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700004A")]
	RigidbodyConstraints CAEDCEJJOFG
	{
		[Cpp2IlInjected.Token(Token = "0x6000118")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
		[Cpp2IlInjected.Token(Token = "0x6000119")]
		[Cpp2IlInjected.Address(Slot = "4")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x600011A")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void BLEFDCFMIJN(Rigidbody GJHIIOHAAJN);

	[Cpp2IlInjected.Token(Token = "0x600011B")]
	[Cpp2IlInjected.Address(Slot = "6")]
	void NMLKFMMMKPL(Rigidbody GJHIIOHAAJN);
}
[Cpp2IlInjected.Token(Token = "0x2000016")]
public interface NAONIBBKJJC
{
	[Cpp2IlInjected.Token(Token = "0x1700004B")]
	float IKAGHIPEEBN
	{
		[Cpp2IlInjected.Token(Token = "0x600011C")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
		[Cpp2IlInjected.Token(Token = "0x600011D")]
		[Cpp2IlInjected.Address(Slot = "1")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x1700004C")]
	float KGMBLHLCENB
	{
		[Cpp2IlInjected.Token(Token = "0x600011E")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
		[Cpp2IlInjected.Token(Token = "0x600011F")]
		[Cpp2IlInjected.Address(Slot = "3")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x6000120")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void BLEFDCFMIJN(Rigidbody GJHIIOHAAJN);

	[Cpp2IlInjected.Token(Token = "0x6000121")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void NMLKFMMMKPL(Rigidbody GJHIIOHAAJN);
}
[Cpp2IlInjected.Token(Token = "0x2000017")]
public interface BMLKALHMELK
{
	[Cpp2IlInjected.Token(Token = "0x14000016")]
	event NAKAIBCOGCG PFLKFCKJCJF;

	[Cpp2IlInjected.Token(Token = "0x6000124")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void JBLDGJLDMEF();

	[Cpp2IlInjected.Token(Token = "0x6000125")]
	[Cpp2IlInjected.Address(Slot = "3")]
	bool BIGMGDJCGKO();

	[Cpp2IlInjected.Token(Token = "0x6000126")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void GIJMAKELMMM();

	[Cpp2IlInjected.Token(Token = "0x6000127")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void MAJHCNGPJBC();

	[Cpp2IlInjected.Token(Token = "0x6000128")]
	[Cpp2IlInjected.Address(Slot = "6")]
	void HNPAAENDJDK();

	[Cpp2IlInjected.Token(Token = "0x6000129")]
	[Cpp2IlInjected.Address(Slot = "7")]
	void DCLBODONNLA();
}
[Cpp2IlInjected.Token(Token = "0x2000018")]
public interface LIOKBCGOPHC
{
	[Cpp2IlInjected.Token(Token = "0x1700004D")]
	Rigidbody CFDDIFJHEKO
	{
		[Cpp2IlInjected.Token(Token = "0x600012A")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700004E")]
	bool EEFBODKLIOD
	{
		[Cpp2IlInjected.Token(Token = "0x600012C")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x600012B")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void JBLDGJLDMEF();

	[Cpp2IlInjected.Token(Token = "0x600012D")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void FFOFEFGFLKG(object FDAIGOGAKMH);

	[Cpp2IlInjected.Token(Token = "0x600012E")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void OEMBIKBABCD(object FDAIGOGAKMH);

	[Cpp2IlInjected.Token(Token = "0x600012F")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void PBANNELBKIE();
}
[Cpp2IlInjected.Token(Token = "0x2000019")]
public interface MHEKBCJDIFI : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x1700004F")]
	KKMOFMFLGOJ JKDOEOFLFNE
	{
		[Cpp2IlInjected.Token(Token = "0x6000130")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
		[Cpp2IlInjected.Token(Token = "0x6000131")]
		[Cpp2IlInjected.Address(Slot = "1")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000050")]
	LPNGIGIDBDB NENIHDOJFOO
	{
		[Cpp2IlInjected.Token(Token = "0x6000132")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
		[Cpp2IlInjected.Token(Token = "0x6000133")]
		[Cpp2IlInjected.Address(Slot = "3")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000051")]
	Vector3 OEJJEAHPBHE
	{
		[Cpp2IlInjected.Token(Token = "0x6000134")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
		[Cpp2IlInjected.Token(Token = "0x6000135")]
		[Cpp2IlInjected.Address(Slot = "5")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000052")]
	Vector3 MIAFPIJOAPP
	{
		[Cpp2IlInjected.Token(Token = "0x6000136")]
		[Cpp2IlInjected.Address(Slot = "6")]
		get;
		[Cpp2IlInjected.Token(Token = "0x6000137")]
		[Cpp2IlInjected.Address(Slot = "7")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000053")]
	Vector3 BAKJLLNDMGH
	{
		[Cpp2IlInjected.Token(Token = "0x6000138")]
		[Cpp2IlInjected.Address(Slot = "8")]
		get;
		[Cpp2IlInjected.Token(Token = "0x6000139")]
		[Cpp2IlInjected.Address(Slot = "9")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000054")]
	Vector3 AMPOKOPEKFE
	{
		[Cpp2IlInjected.Token(Token = "0x600013A")]
		[Cpp2IlInjected.Address(Slot = "10")]
		get;
		[Cpp2IlInjected.Token(Token = "0x600013B")]
		[Cpp2IlInjected.Address(Slot = "11")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000055")]
	float GLHFEEBAFIJ
	{
		[Cpp2IlInjected.Token(Token = "0x600013C")]
		[Cpp2IlInjected.Address(Slot = "12")]
		get;
		[Cpp2IlInjected.Token(Token = "0x600013D")]
		[Cpp2IlInjected.Address(Slot = "13")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000056")]
	bool JLDMJGGIEPO
	{
		[Cpp2IlInjected.Token(Token = "0x600013E")]
		[Cpp2IlInjected.Address(Slot = "14")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x600013F")]
	[Cpp2IlInjected.Address(Slot = "15")]
	void JBLDGJLDMEF();

	[Cpp2IlInjected.Token(Token = "0x6000140")]
	[Cpp2IlInjected.Address(Slot = "16")]
	void BCLKDGMKLLK(object FDAIGOGAKMH);

	[Cpp2IlInjected.Token(Token = "0x6000141")]
	[Cpp2IlInjected.Address(Slot = "17")]
	void NNJFGFGOMEF(CNPLNPFECCE JHMJLILENAP, Vector3 OKNBNOENDPK, float BMCEHNOGEJG = float.PositiveInfinity);

	[Cpp2IlInjected.Token(Token = "0x6000142")]
	[Cpp2IlInjected.Address(Slot = "18")]
	void JJGCADCFNDB(IIKHDPMFHDE BAPJDEHMLHH, Vector3 MNDBPOBDCNJ, float BFAPEHFPHCD, float NBNFHECNAHB = 8f, float INCOBGEGFMH = 1f);

	[Cpp2IlInjected.Token(Token = "0x6000143")]
	[Cpp2IlInjected.Address(Slot = "19")]
	void IFPOABMPLJP(CNPLNPFECCE JHMJLILENAP, Vector3 EFFHGIJAIIE, float BJOPNKBDJGB = 7f, float IPFBOIJJMOB = 1f);

	[Cpp2IlInjected.Token(Token = "0x6000144")]
	[Cpp2IlInjected.Address(Slot = "20")]
	void NNMPGFKCLEC();

	[Cpp2IlInjected.Token(Token = "0x6000145")]
	[Cpp2IlInjected.Address(Slot = "21")]
	void CEALOANFKBH();

	[Cpp2IlInjected.Token(Token = "0x6000146")]
	[Cpp2IlInjected.Address(Slot = "22")]
	void ONIAFGKNHNP();

	[Cpp2IlInjected.Token(Token = "0x6000147")]
	[Cpp2IlInjected.Address(Slot = "23")]
	void PPBMOAJIDKC();

	[Cpp2IlInjected.Token(Token = "0x6000148")]
	[Cpp2IlInjected.Address(Slot = "24")]
	void BLEFDCFMIJN(Rigidbody GJHIIOHAAJN);

	[Cpp2IlInjected.Token(Token = "0x6000149")]
	[Cpp2IlInjected.Address(Slot = "25")]
	Vector3 BDFCCMMIAAO(Vector3 NBBOFJMDBHM);

	[Cpp2IlInjected.Token(Token = "0x600014A")]
	[Cpp2IlInjected.Address(Slot = "26")]
	void DNJLEHGDFPN(object FDAIGOGAKMH);

	[Cpp2IlInjected.Token(Token = "0x600014B")]
	[Cpp2IlInjected.Address(Slot = "27")]
	void MJFCOFBOIIN(Vector3 JEGDENCLKDF);

	[Cpp2IlInjected.Token(Token = "0x600014C")]
	[Cpp2IlInjected.Address(Slot = "28")]
	void FAPJHKNNAPN(Vector3 KELAFHBGMAO, Vector3 EDLBDGENHAA);

	[Cpp2IlInjected.Token(Token = "0x600014D")]
	[Cpp2IlInjected.Address(Slot = "29")]
	void LABDHLMFMLI(Vector3 GOFDGAKBMGI, Vector3 FCECEIAJGMC);

	[Cpp2IlInjected.Token(Token = "0x600014E")]
	[Cpp2IlInjected.Address(Slot = "30")]
	Vector3 GAJLJHAODIA(Vector3 BPCNDMDPEND);

	[Cpp2IlInjected.Token(Token = "0x600014F")]
	[Cpp2IlInjected.Address(Slot = "31")]
	Vector3 LKAMGHHKPOF(Vector3 EBLBHKKBIIJ);
}
[Cpp2IlInjected.Token(Token = "0x200001A")]
[CMNNIKGKEON(MFDGBKGGINJ.Application)]
public interface MEELPKKBHKP
{
	[Cpp2IlInjected.Token(Token = "0x17000057")]
	bool BPCPANINDAG
	{
		[Cpp2IlInjected.Token(Token = "0x6000150")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000151")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void MAEGPJAFMJO(string GJAHCEMFFMA);

	[Cpp2IlInjected.Token(Token = "0x6000152")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void CIGBCJEHCDF(RigidbodyEx DODIHPOGMBH, Action MDOOJHKFGMP);

	[Cpp2IlInjected.Token(Token = "0x6000153")]
	[Cpp2IlInjected.Address(Slot = "3")]
	ECODPLJIFEC PLDMFBCICOO(int NDBFOLOIOMM);

	[Cpp2IlInjected.Token(Token = "0x6000154")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void ECOOIKNAACB(Vector3 KCENOGICPMA, float OLEIBGGPMFC, Color DFKHKPKCOFI);
}
[Cpp2IlInjected.Token(Token = "0x200001B")]
[CMNNIKGKEON(MFDGBKGGINJ.Application)]
public interface KFKIDNCNBPA
{
	[Cpp2IlInjected.Token(Token = "0x17000058")]
	MEELPKKBHKP HEHDJMJINLD
	{
		[Cpp2IlInjected.Token(Token = "0x6000155")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000059")]
	GKAOAHDNLME CKCHNKBNKLN
	{
		[Cpp2IlInjected.Token(Token = "0x6000156")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000157")]
	[Cpp2IlInjected.Address(Slot = "2")]
	IFCIIPLFOCA DNNIJNIMPPK(RigidbodyEx DODIHPOGMBH, KDAAIDJOOBC MPMEGOKIEPF);
}
[Cpp2IlInjected.Token(Token = "0x200001C")]
public class FKMFAEODDLC : IFCIIPLFOCA, IDisposable, ALCCGGBGIAM
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000017")]
	internal readonly KFKIDNCNBPA HPCAPMNEHGA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000018")]
	internal IBKMOLDIGIP IDIMPCEPAJA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000019")]
	internal CJNBDDJPPFL AAJLADIJALI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400001A")]
	internal FNCIFHKHEPA PNKGEKHICOE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400001B")]
	internal MHEKBCJDIFI NBBOFJMDBHM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x400001C")]
	internal BAFNGHIJNLF EPCNGPDIOAE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x400001D")]
	internal EHCMCNEDKLA ODPLHNAPHHB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x400001E")]
	internal NAONIBBKJJC MMPGBLDJJMG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x400001F")]
	internal EDMKMOGFBPP NPJNLGMAKCK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x4000020")]
	internal BMLKALHMELK ONLAHGMKPLH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x4000021")]
	internal OIHMMOOMIOD LPGPIIMOBEI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x4000022")]
	internal APAEMPIJCMB PELPMIGEPOF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x4000023")]
	internal NLEBPALKPEF DPEDJCGKFCE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
	[Cpp2IlInjected.Token(Token = "0x4000024")]
	internal NPPMLEINIBM BFELPEBOLFL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x4000025")]
	internal LIOKBCGOPHC GJHIIOHAAJN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
	[Cpp2IlInjected.Token(Token = "0x4000026")]
	internal NIOGLPDPALJ IBKCLEMOKJO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
	[Cpp2IlInjected.Token(Token = "0x4000027")]
	internal IDisposable HPKMCJMIJDH;

	[Cpp2IlInjected.Token(Token = "0x1700005A")]
	public EJCLGEIBEFL BENKNCHEADJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000158")]
		[Cpp2IlInjected.Address(RVA = "0x8ABE40", Offset = "0x8AB240", VA = "0x1808ABE40", Slot = "22")]
		get
		{
			return default(EJCLGEIBEFL);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700005B")]
	public NADAIAGKPNF GEFANEGNHEG
	{
		[Cpp2IlInjected.Token(Token = "0x6000159")]
		[Cpp2IlInjected.Address(RVA = "0x8AFA70", Offset = "0x8AEE70", VA = "0x1808AFA70", Slot = "24")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600015A")]
		[Cpp2IlInjected.Address(RVA = "0x8AFBA0", Offset = "0x8AEFA0", VA = "0x1808AFBA0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700005C")]
	public GameObject IPFINNCCMDB
	{
		[Cpp2IlInjected.Token(Token = "0x600015B")]
		[Cpp2IlInjected.Address(RVA = "0x9EA8E0", Offset = "0x9E9CE0", VA = "0x1809EA8E0", Slot = "25")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600015C")]
		[Cpp2IlInjected.Address(RVA = "0x9DFEB0", Offset = "0x9DF2B0", VA = "0x1809DFEB0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700005D")]
	public Transform GCKCOGKHDGG
	{
		[Cpp2IlInjected.Token(Token = "0x600015D")]
		[Cpp2IlInjected.Address(RVA = "0x8B4B10", Offset = "0x8B3F10", VA = "0x1808B4B10", Slot = "26")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600015E")]
		[Cpp2IlInjected.Address(RVA = "0x8B4B40", Offset = "0x8B3F40", VA = "0x1808B4B40")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700005E")]
	public Rigidbody CFDDIFJHEKO
	{
		[Cpp2IlInjected.Token(Token = "0x600015F")]
		[Cpp2IlInjected.Address(RVA = "0x7464990", Offset = "0x7463D90", VA = "0x187464990", Slot = "23")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700005F")]
	public IFCIIPLFOCA DIEIKKLOHIA
	{
		[Cpp2IlInjected.Token(Token = "0x600016D")]
		[Cpp2IlInjected.Address(RVA = "0x7465440", Offset = "0x7464840", VA = "0x187465440", Slot = "27")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600016E")]
		[Cpp2IlInjected.Address(RVA = "0x7462720", Offset = "0x7461B20", VA = "0x187462720", Slot = "28")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000060")]
	public int PIMDPKMMCEK
	{
		[Cpp2IlInjected.Token(Token = "0x600016F")]
		[Cpp2IlInjected.Address(RVA = "0x7461870", Offset = "0x7460C70", VA = "0x187461870", Slot = "31")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000061")]
	public IFCIIPLFOCA FKDEHKMEOCL
	{
		[Cpp2IlInjected.Token(Token = "0x6000171")]
		[Cpp2IlInjected.Address(RVA = "0x7464320", Offset = "0x7463720", VA = "0x187464320", Slot = "29")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000062")]
	public bool JIJHHIKHFHH
	{
		[Cpp2IlInjected.Token(Token = "0x6000172")]
		[Cpp2IlInjected.Address(RVA = "0x74629B0", Offset = "0x7461DB0", VA = "0x1874629B0", Slot = "32")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000063")]
	public bool FCDOJOKBAME
	{
		[Cpp2IlInjected.Token(Token = "0x6000176")]
		[Cpp2IlInjected.Address(RVA = "0x7461360", Offset = "0x7460760", VA = "0x187461360", Slot = "33")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000064")]
	public bool LFAFJEIDHAH
	{
		[Cpp2IlInjected.Token(Token = "0x6000177")]
		[Cpp2IlInjected.Address(RVA = "0x74663B0", Offset = "0x74657B0", VA = "0x1874663B0", Slot = "34")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000065")]
	public KKMOFMFLGOJ JKDOEOFLFNE
	{
		[Cpp2IlInjected.Token(Token = "0x6000178")]
		[Cpp2IlInjected.Address(RVA = "0x74635E0", Offset = "0x74629E0", VA = "0x1874635E0", Slot = "35")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000179")]
		[Cpp2IlInjected.Address(RVA = "0x7461B90", Offset = "0x7460F90", VA = "0x187461B90", Slot = "36")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000066")]
	public LPNGIGIDBDB NENIHDOJFOO
	{
		[Cpp2IlInjected.Token(Token = "0x600017A")]
		[Cpp2IlInjected.Address(RVA = "0x7462B10", Offset = "0x7461F10", VA = "0x187462B10", Slot = "37")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600017B")]
		[Cpp2IlInjected.Address(RVA = "0x74637B0", Offset = "0x7462BB0", VA = "0x1874637B0", Slot = "38")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000067")]
	public float GLHFEEBAFIJ
	{
		[Cpp2IlInjected.Token(Token = "0x600017C")]
		[Cpp2IlInjected.Address(RVA = "0x7462C40", Offset = "0x7462040", VA = "0x187462C40", Slot = "39")]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x600017D")]
		[Cpp2IlInjected.Address(RVA = "0x7464370", Offset = "0x7463770", VA = "0x187464370", Slot = "40")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000068")]
	public Vector3 MIAFPIJOAPP
	{
		[Cpp2IlInjected.Token(Token = "0x600017E")]
		[Cpp2IlInjected.Address(RVA = "0x7464B80", Offset = "0x7463F80", VA = "0x187464B80", Slot = "41")]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x600017F")]
		[Cpp2IlInjected.Address(RVA = "0x74622F0", Offset = "0x74616F0", VA = "0x1874622F0", Slot = "42")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000069")]
	public Vector3 AMPOKOPEKFE
	{
		[Cpp2IlInjected.Token(Token = "0x6000180")]
		[Cpp2IlInjected.Address(RVA = "0x7462B60", Offset = "0x7461F60", VA = "0x187462B60", Slot = "43")]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x6000181")]
		[Cpp2IlInjected.Address(RVA = "0x7464780", Offset = "0x7463B80", VA = "0x187464780", Slot = "44")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700006A")]
	public Vector3 OEJJEAHPBHE
	{
		[Cpp2IlInjected.Token(Token = "0x6000182")]
		[Cpp2IlInjected.Address(RVA = "0x7462480", Offset = "0x7461880", VA = "0x187462480", Slot = "45")]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x6000183")]
		[Cpp2IlInjected.Address(RVA = "0x7460C50", Offset = "0x7460050", VA = "0x187460C50", Slot = "46")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700006B")]
	public Vector3 BAKJLLNDMGH
	{
		[Cpp2IlInjected.Token(Token = "0x6000184")]
		[Cpp2IlInjected.Address(RVA = "0x7461600", Offset = "0x7460A00", VA = "0x187461600", Slot = "47")]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x6000185")]
		[Cpp2IlInjected.Address(RVA = "0x74614B0", Offset = "0x74608B0", VA = "0x1874614B0", Slot = "48")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700006C")]
	public bool KBELHLINADK
	{
		[Cpp2IlInjected.Token(Token = "0x6000186")]
		[Cpp2IlInjected.Address(RVA = "0x74623D0", Offset = "0x74617D0", VA = "0x1874623D0", Slot = "139")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700006D")]
	public bool BEKHABCBNKO
	{
		[Cpp2IlInjected.Token(Token = "0x6000187")]
		[Cpp2IlInjected.Address(RVA = "0x7460A80", Offset = "0x745FE80", VA = "0x187460A80", Slot = "49")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700006E")]
	public bool HOMKACFGKHM
	{
		[Cpp2IlInjected.Token(Token = "0x6000188")]
		[Cpp2IlInjected.Address(RVA = "0x7460950", Offset = "0x745FD50", VA = "0x187460950", Slot = "50")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700006F")]
	public bool JLDMJGGIEPO
	{
		[Cpp2IlInjected.Token(Token = "0x6000189")]
		[Cpp2IlInjected.Address(RVA = "0x74620F0", Offset = "0x74614F0", VA = "0x1874620F0", Slot = "51")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000070")]
	public Vector3 LJEFKJLILDI
	{
		[Cpp2IlInjected.Token(Token = "0x600019A")]
		[Cpp2IlInjected.Address(RVA = "0x7460D30", Offset = "0x7460130", VA = "0x187460D30", Slot = "52")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000071")]
	public Vector3 HMEFMECHEOB
	{
		[Cpp2IlInjected.Token(Token = "0x600019B")]
		[Cpp2IlInjected.Address(RVA = "0x7464FF0", Offset = "0x74643F0", VA = "0x187464FF0", Slot = "53")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000072")]
	public Vector3 KOJBKCKDCOM
	{
		[Cpp2IlInjected.Token(Token = "0x60001A0")]
		[Cpp2IlInjected.Address(RVA = "0x74631E0", Offset = "0x74625E0", VA = "0x1874631E0", Slot = "54")]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x60001A1")]
		[Cpp2IlInjected.Address(RVA = "0x74610B0", Offset = "0x74604B0", VA = "0x1874610B0", Slot = "55")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000073")]
	public Vector3 ADOGIKLOPOE
	{
		[Cpp2IlInjected.Token(Token = "0x60001A2")]
		[Cpp2IlInjected.Address(RVA = "0x7464640", Offset = "0x7463A40", VA = "0x187464640", Slot = "56")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000074")]
	public float PKEBGGMFHGB
	{
		[Cpp2IlInjected.Token(Token = "0x60001A3")]
		[Cpp2IlInjected.Address(RVA = "0x74615B0", Offset = "0x74609B0", VA = "0x1874615B0", Slot = "57")]
		get
		{
			return default(float);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000075")]
	public float JACGGPKPOHK
	{
		[Cpp2IlInjected.Token(Token = "0x60001A4")]
		[Cpp2IlInjected.Address(RVA = "0x7465FF0", Offset = "0x74653F0", VA = "0x187465FF0", Slot = "58")]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x60001A5")]
		[Cpp2IlInjected.Address(RVA = "0x7464AC0", Offset = "0x7463EC0", VA = "0x187464AC0", Slot = "59")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000076")]
	public Vector3 AGJEOCNFDLJ
	{
		[Cpp2IlInjected.Token(Token = "0x60001A6")]
		[Cpp2IlInjected.Address(RVA = "0x7466540", Offset = "0x7465940", VA = "0x187466540", Slot = "60")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000077")]
	public Quaternion NKHOHGNBGLO
	{
		[Cpp2IlInjected.Token(Token = "0x60001A7")]
		[Cpp2IlInjected.Address(RVA = "0x7462780", Offset = "0x7461B80", VA = "0x187462780", Slot = "61")]
		get
		{
			return default(Quaternion);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000078")]
	public float IKAGHIPEEBN
	{
		[Cpp2IlInjected.Token(Token = "0x60001AC")]
		[Cpp2IlInjected.Address(RVA = "0x7463D60", Offset = "0x7463160", VA = "0x187463D60", Slot = "63")]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x60001AD")]
		[Cpp2IlInjected.Address(RVA = "0x7461B30", Offset = "0x7460F30", VA = "0x187461B30", Slot = "64")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000079")]
	public float KGMBLHLCENB
	{
		[Cpp2IlInjected.Token(Token = "0x60001AE")]
		[Cpp2IlInjected.Address(RVA = "0x7464FA0", Offset = "0x74643A0", VA = "0x187464FA0", Slot = "65")]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x60001AF")]
		[Cpp2IlInjected.Address(RVA = "0x74613B0", Offset = "0x74607B0", VA = "0x1874613B0", Slot = "66")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700007A")]
	public bool DEFHIOIJCFC
	{
		[Cpp2IlInjected.Token(Token = "0x60001B0")]
		[Cpp2IlInjected.Address(RVA = "0x74659C0", Offset = "0x7464DC0", VA = "0x1874659C0", Slot = "67")]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x60001B1")]
		[Cpp2IlInjected.Address(RVA = "0x7466350", Offset = "0x7465750", VA = "0x187466350", Slot = "68")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700007B")]
	public NKELFIBCFCE HJPEGFBCCAB
	{
		[Cpp2IlInjected.Token(Token = "0x60001B9")]
		[Cpp2IlInjected.Address(RVA = "0x7460A30", Offset = "0x745FE30", VA = "0x187460A30", Slot = "69")]
		get
		{
			return default(NKELFIBCFCE);
		}
		[Cpp2IlInjected.Token(Token = "0x60001BA")]
		[Cpp2IlInjected.Address(RVA = "0x74652E0", Offset = "0x74646E0", VA = "0x1874652E0", Slot = "70")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700007C")]
	public bool DBMGBKHLGGG
	{
		[Cpp2IlInjected.Token(Token = "0x60001BD")]
		[Cpp2IlInjected.Address(RVA = "0x7464C60", Offset = "0x7464060", VA = "0x187464C60", Slot = "71")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700007D")]
	public Transform ELDALOHKJAP
	{
		[Cpp2IlInjected.Token(Token = "0x60001C3")]
		[Cpp2IlInjected.Address(RVA = "0x8B4B10", Offset = "0x8B3F10", VA = "0x1808B4B10", Slot = "72")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700007E")]
	public Vector3 HBGAPGGIOCM
	{
		[Cpp2IlInjected.Token(Token = "0x60001C4")]
		[Cpp2IlInjected.Address(RVA = "0x7463920", Offset = "0x7462D20", VA = "0x187463920", Slot = "73")]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x60001C5")]
		[Cpp2IlInjected.Address(RVA = "0x7466620", Offset = "0x7465A20", VA = "0x187466620", Slot = "74")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700007F")]
	public float OCPBDLIMJHO
	{
		[Cpp2IlInjected.Token(Token = "0x60001C6")]
		[Cpp2IlInjected.Address(RVA = "0x7466450", Offset = "0x7465850", VA = "0x187466450", Slot = "75")]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x60001C7")]
		[Cpp2IlInjected.Address(RVA = "0x7465EE0", Offset = "0x74652E0", VA = "0x187465EE0", Slot = "76")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000080")]
	public float GKFDLDIHJIP
	{
		[Cpp2IlInjected.Token(Token = "0x60001C8")]
		[Cpp2IlInjected.Address(RVA = "0x7461F50", Offset = "0x7461350", VA = "0x187461F50", Slot = "77")]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x60001C9")]
		[Cpp2IlInjected.Address(RVA = "0x74649E0", Offset = "0x7463DE0", VA = "0x1874649E0", Slot = "78")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000081")]
	public Quaternion HAFBLEHKBMN
	{
		[Cpp2IlInjected.Token(Token = "0x60001CA")]
		[Cpp2IlInjected.Address(RVA = "0x7465F50", Offset = "0x7465350", VA = "0x187465F50", Slot = "79")]
		get
		{
			return default(Quaternion);
		}
		[Cpp2IlInjected.Token(Token = "0x60001CB")]
		[Cpp2IlInjected.Address(RVA = "0x7466210", Offset = "0x7465610", VA = "0x187466210", Slot = "80")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000082")]
	public Vector3 CBMADBKBACD
	{
		[Cpp2IlInjected.Token(Token = "0x60001CC")]
		[Cpp2IlInjected.Address(RVA = "0x74631A0", Offset = "0x74625A0", VA = "0x1874631A0", Slot = "81")]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x60001CD")]
		[Cpp2IlInjected.Address(RVA = "0x74618E0", Offset = "0x7460CE0", VA = "0x1874618E0", Slot = "82")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000083")]
	public Quaternion AOFACHKJMAP
	{
		[Cpp2IlInjected.Token(Token = "0x60001CE")]
		[Cpp2IlInjected.Address(RVA = "0x7461470", Offset = "0x7460870", VA = "0x187461470", Slot = "83")]
		get
		{
			return default(Quaternion);
		}
		[Cpp2IlInjected.Token(Token = "0x60001CF")]
		[Cpp2IlInjected.Address(RVA = "0x7460920", Offset = "0x745FD20", VA = "0x187460920", Slot = "84")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000084")]
	public RigidbodyConstraints CAEDCEJJOFG
	{
		[Cpp2IlInjected.Token(Token = "0x60001D3")]
		[Cpp2IlInjected.Address(RVA = "0x74642D0", Offset = "0x74636D0", VA = "0x1874642D0", Slot = "85")]
		get
		{
			return default(RigidbodyConstraints);
		}
		[Cpp2IlInjected.Token(Token = "0x60001D4")]
		[Cpp2IlInjected.Address(RVA = "0x7465220", Offset = "0x7464620", VA = "0x187465220", Slot = "86")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000085")]
	public bool LHMAAJBCAPO
	{
		[Cpp2IlInjected.Token(Token = "0x60001D5")]
		[Cpp2IlInjected.Address(RVA = "0x7466400", Offset = "0x7465800", VA = "0x187466400", Slot = "87")]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x60001D6")]
		[Cpp2IlInjected.Address(RVA = "0x7465280", Offset = "0x7464680", VA = "0x187465280", Slot = "88")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000086")]
	public CollisionDetectionMode ANEBIFEMAJG
	{
		[Cpp2IlInjected.Token(Token = "0x60001DF")]
		[Cpp2IlInjected.Address(RVA = "0x7462140", Offset = "0x7461540", VA = "0x187462140", Slot = "89")]
		get
		{
			return default(CollisionDetectionMode);
		}
		[Cpp2IlInjected.Token(Token = "0x60001E0")]
		[Cpp2IlInjected.Address(RVA = "0x7464B20", Offset = "0x7463F20", VA = "0x187464B20", Slot = "90")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000087")]
	public bool OPKBCEDKDNC
	{
		[Cpp2IlInjected.Token(Token = "0x60001E2")]
		[Cpp2IlInjected.Address(RVA = "0x7465BF0", Offset = "0x7464FF0", VA = "0x187465BF0", Slot = "140")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000088")]
	public bool JBAHNOEKKHB
	{
		[Cpp2IlInjected.Token(Token = "0x60001E3")]
		[Cpp2IlInjected.Address(RVA = "0x7461190", Offset = "0x7460590", VA = "0x187461190", Slot = "91")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000017")]
	public event NAKAIBCOGCG GDBMDOOJHFI
	{
		[Cpp2IlInjected.Token(Token = "0x6000167")]
		[Cpp2IlInjected.Address(RVA = "0x7466160", Offset = "0x7465560", VA = "0x187466160", Slot = "4")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000168")]
		[Cpp2IlInjected.Address(RVA = "0x74662F0", Offset = "0x74656F0", VA = "0x1874662F0", Slot = "5")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000018")]
	public event NAKAIBCOGCG PGCCLNEEMNN
	{
		[Cpp2IlInjected.Token(Token = "0x6000169")]
		[Cpp2IlInjected.Address(RVA = "0x7462900", Offset = "0x7461D00", VA = "0x187462900", Slot = "6")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600016A")]
		[Cpp2IlInjected.Address(RVA = "0x7461410", Offset = "0x7460810", VA = "0x187461410", Slot = "7")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000019")]
	public event EGODMMHJIHF GGLBNLKBFBC
	{
		[Cpp2IlInjected.Token(Token = "0x600016B")]
		[Cpp2IlInjected.Address(RVA = "0x7461A20", Offset = "0x7460E20", VA = "0x187461A20", Slot = "18")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600016C")]
		[Cpp2IlInjected.Address(RVA = "0x7462420", Offset = "0x7461820", VA = "0x187462420", Slot = "19")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400001A")]
	public event NAKAIBCOGCG HNJMPMFKHDK
	{
		[Cpp2IlInjected.Token(Token = "0x6000174")]
		[Cpp2IlInjected.Address(RVA = "0x7466100", Offset = "0x7465500", VA = "0x187466100", Slot = "8")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000175")]
		[Cpp2IlInjected.Address(RVA = "0x7462290", Offset = "0x7461690", VA = "0x187462290", Slot = "9")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400001B")]
	public event NAKAIBCOGCG MGMJFBGNMDA
	{
		[Cpp2IlInjected.Token(Token = "0x600019E")]
		[Cpp2IlInjected.Address(RVA = "0x74658B0", Offset = "0x7464CB0", VA = "0x1874658B0", Slot = "14")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600019F")]
		[Cpp2IlInjected.Address(RVA = "0x74650D0", Offset = "0x74644D0", VA = "0x1874650D0", Slot = "15")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400001C")]
	public event NAKAIBCOGCG PFLKFCKJCJF
	{
		[Cpp2IlInjected.Token(Token = "0x60001B2")]
		[Cpp2IlInjected.Address(RVA = "0x7460AE0", Offset = "0x745FEE0", VA = "0x187460AE0", Slot = "16")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60001B3")]
		[Cpp2IlInjected.Address(RVA = "0x7461AD0", Offset = "0x7460ED0", VA = "0x187461AD0", Slot = "17")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400001D")]
	public event Action<GGHKEJOODBA, GGHKEJOODBA> ICBMGNDEMLD
	{
		[Cpp2IlInjected.Token(Token = "0x60001B7")]
		[Cpp2IlInjected.Address(RVA = "0x7460BF0", Offset = "0x745FFF0", VA = "0x187460BF0", Slot = "20")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60001B8")]
		[Cpp2IlInjected.Address(RVA = "0x7463750", Offset = "0x7462B50", VA = "0x187463750", Slot = "21")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400001E")]
	public event NAKAIBCOGCG HBPOHBEMCJE
	{
		[Cpp2IlInjected.Token(Token = "0x60001BB")]
		[Cpp2IlInjected.Address(RVA = "0x7464720", Offset = "0x7463B20", VA = "0x187464720", Slot = "12")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60001BC")]
		[Cpp2IlInjected.Address(RVA = "0x7465960", Offset = "0x7464D60", VA = "0x187465960", Slot = "13")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400001F")]
	public event NAKAIBCOGCG PIGECBNIHOO
	{
		[Cpp2IlInjected.Token(Token = "0x60001C1")]
		[Cpp2IlInjected.Address(RVA = "0x74648E0", Offset = "0x7463CE0", VA = "0x1874648E0", Slot = "10")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60001C2")]
		[Cpp2IlInjected.Address(RVA = "0x7460B40", Offset = "0x745FF40", VA = "0x187460B40", Slot = "11")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000160")]
	[Cpp2IlInjected.Address(RVA = "0x7466710", Offset = "0x7465B10", VA = "0x187466710")]
	public FKMFAEODDLC(GameObject JPONDMDOHLN, RigidbodyEx LOFMEKEIBEJ, KFKIDNCNBPA HPCAPMNEHGA, [In] KDAAIDJOOBC MPMEGOKIEPF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000161")]
	[Cpp2IlInjected.Address(RVA = "0x7464CB0", Offset = "0x74640B0", VA = "0x187464CB0", Slot = "137")]
	protected virtual void KILGOMAJHGL(KFKIDNCNBPA HPCAPMNEHGA, KDAAIDJOOBC MPMEGOKIEPF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000162")]
	[Cpp2IlInjected.Address(RVA = "0x7461FD0", Offset = "0x74613D0", VA = "0x187461FD0", Slot = "138")]
	public virtual void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000163")]
	[Cpp2IlInjected.Address(RVA = "0x7464190", Offset = "0x7463590", VA = "0x187464190", Slot = "92")]
	public void JBLDGJLDMEF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000164")]
	[Cpp2IlInjected.Address(RVA = "0x7462850", Offset = "0x7461C50", VA = "0x187462850", Slot = "93")]
	public void FFIMAGJIDFP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000165")]
	[Cpp2IlInjected.Address(RVA = "0x7461590", Offset = "0x7460990", VA = "0x187461590", Slot = "94")]
	public void BPMNAMMLPEI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000166")]
	[Cpp2IlInjected.Address(RVA = "0x7464860", Offset = "0x7463C60", VA = "0x187464860")]
	private void KAHPMMMCNAP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000170")]
	[Cpp2IlInjected.Address(RVA = "0x7463E10", Offset = "0x7463210", VA = "0x187463E10", Slot = "30")]
	public IFCIIPLFOCA IFBNFADBFBH(int AEAHMAMPNLO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000173")]
	[Cpp2IlInjected.Address(RVA = "0x7461F60", Offset = "0x7461360", VA = "0x187461F60", Slot = "96")]
	public void DDIJPNBLPCC(IFCIIPLFOCA LIHHDPOHLDK, bool FHCBEIGKGNF = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600018A")]
	[Cpp2IlInjected.Address(RVA = "0x7463D00", Offset = "0x7463100", VA = "0x187463D00", Slot = "97")]
	public void HNICEGJEBKC(object FDAIGOGAKMH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600018B")]
	[Cpp2IlInjected.Address(RVA = "0x7463CA0", Offset = "0x74630A0", VA = "0x187463CA0", Slot = "98")]
	public void HKDBOAMEFCG(object FDAIGOGAKMH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600018C")]
	[Cpp2IlInjected.Address(RVA = "0x7465340", Offset = "0x7464740", VA = "0x187465340", Slot = "99")]
	public Vector3 LKAMGHHKPOF(Vector3 EBLBHKKBIIJ)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x600018D")]
	[Cpp2IlInjected.Address(RVA = "0x7462A10", Offset = "0x7461E10", VA = "0x187462A10", Slot = "100")]
	public Vector3 GAJLJHAODIA(Vector3 BPCNDMDPEND)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x600018E")]
	[Cpp2IlInjected.Address(RVA = "0x7462850", Offset = "0x7461C50", VA = "0x187462850", Slot = "101")]
	public void PPBMOAJIDKC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600018F")]
	[Cpp2IlInjected.Address(RVA = "0x7461820", Offset = "0x7460C20", VA = "0x187461820", Slot = "102")]
	public void CEALOANFKBH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000190")]
	[Cpp2IlInjected.Address(RVA = "0x7465E90", Offset = "0x7465290", VA = "0x187465E90", Slot = "103")]
	public void NNMPGFKCLEC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000191")]
	[Cpp2IlInjected.Address(RVA = "0x7465130", Offset = "0x7464530", VA = "0x187465130", Slot = "104")]
	public void LABDHLMFMLI(Vector3 GOFDGAKBMGI, Vector3 FCECEIAJGMC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000192")]
	[Cpp2IlInjected.Address(RVA = "0x7462560", Offset = "0x7461960", VA = "0x187462560", Slot = "105")]
	public void FAPJHKNNAPN(Vector3 KELAFHBGMAO, Vector3 EDLBDGENHAA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000193")]
	[Cpp2IlInjected.Address(RVA = "0x7465B10", Offset = "0x7464F10", VA = "0x187465B10", Slot = "106")]
	public void MJFCOFBOIIN(Vector3 JEGDENCLKDF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000194")]
	[Cpp2IlInjected.Address(RVA = "0x74643D0", Offset = "0x74637D0", VA = "0x1874643D0", Slot = "107")]
	public void JJGCADCFNDB(IIKHDPMFHDE BAPJDEHMLHH, Vector3 MNDBPOBDCNJ, float BFAPEHFPHCD, float NBNFHECNAHB = 8f, float INCOBGEGFMH = 1f)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000195")]
	[Cpp2IlInjected.Address(RVA = "0x7465D90", Offset = "0x7465190", VA = "0x187465D90", Slot = "108")]
	public void NNJFGFGOMEF(CNPLNPFECCE JHMJLILENAP, Vector3 OKNBNOENDPK, float BMCEHNOGEJG = float.PositiveInfinity)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000196")]
	[Cpp2IlInjected.Address(RVA = "0x7463E90", Offset = "0x7463290", VA = "0x187463E90", Slot = "109")]
	[Obsolete("Deprecated. Still exists to support deprecated CV2 chips. Use ApplyAngularVelocityChange.")]
	public void IFPOABMPLJP(CNPLNPFECCE JHMJLILENAP, Vector3 EFFHGIJAIIE, float BJOPNKBDJGB = 7f, float IPFBOIJJMOB = 1f)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000197")]
	[Cpp2IlInjected.Address(RVA = "0x7460FB0", Offset = "0x74603B0", VA = "0x187460FB0", Slot = "110")]
	public Vector3 BDFCCMMIAAO(Vector3 LIHHDPOHLDK)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000198")]
	[Cpp2IlInjected.Address(RVA = "0x7462190", Offset = "0x7461590", VA = "0x187462190", Slot = "111")]
	public Vector3 EFBGBLMFPLD(Vector3 LIHHDPOHLDK)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000199")]
	[Cpp2IlInjected.Address(RVA = "0x74661C0", Offset = "0x74655C0", VA = "0x1874661C0", Slot = "112")]
	public void ONIAFGKNHNP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600019C")]
	[Cpp2IlInjected.Address(RVA = "0x7463680", Offset = "0x7462A80", VA = "0x187463680", Slot = "113")]
	public void GNGACCFEPAO(IFCIIPLFOCA HOOAJDBEAGF, object FDAIGOGAKMH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600019D")]
	[Cpp2IlInjected.Address(RVA = "0x7463DB0", Offset = "0x74631B0", VA = "0x187463DB0", Slot = "114")]
	public void HPJJEGAFKNA(object FDAIGOGAKMH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001A8")]
	[Cpp2IlInjected.Address(RVA = "0x7460ED0", Offset = "0x74602D0", VA = "0x187460ED0", Slot = "62")]
	public void BDFAMNPGEOK((Quaternion rot, Vector3 moments) FHCHCEFKJNC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001A9")]
	[Cpp2IlInjected.Address(RVA = "0x74620A0", Offset = "0x74614A0", VA = "0x1874620A0", Slot = "115")]
	public void EAKOJKGNPNH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001AA")]
	[Cpp2IlInjected.Address(RVA = "0x7463630", Offset = "0x7462A30", VA = "0x187463630", Slot = "116")]
	public void GLPGBCBEBAK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001AB")]
	[Cpp2IlInjected.Address(RVA = "0x7464060", Offset = "0x7463460", VA = "0x187464060", Slot = "117")]
	public void IGOIGPBJBLN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001B4")]
	[Cpp2IlInjected.Address(RVA = "0x7461310", Offset = "0x7460710", VA = "0x187461310", Slot = "118")]
	public bool BIGMGDJCGKO()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001B5")]
	[Cpp2IlInjected.Address(RVA = "0x7465910", Offset = "0x7464D10", VA = "0x187465910", Slot = "95")]
	public void MAJHCNGPJBC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001B6")]
	[Cpp2IlInjected.Address(RVA = "0x7461DF0", Offset = "0x74611F0", VA = "0x187461DF0", Slot = "119")]
	public void DCLBODONNLA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001BE")]
	[Cpp2IlInjected.Address(RVA = "0x7465D30", Offset = "0x7465130", VA = "0x187465D30", Slot = "120")]
	public void NCOOPPCENCG(object FDAIGOGAKMH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001BF")]
	[Cpp2IlInjected.Address(RVA = "0x74636F0", Offset = "0x7462AF0", VA = "0x1874636F0", Slot = "121")]
	public void GNNECMKMACC(object FDAIGOGAKMH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001C0")]
	[Cpp2IlInjected.Address(RVA = "0x7464490", Offset = "0x7463890", VA = "0x187464490", Slot = "122")]
	public void JKCFLPNEIDO(object FDAIGOGAKMH, bool ONDEKDBNJLL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001D0")]
	[Cpp2IlInjected.Address(RVA = "0x7461BF0", Offset = "0x7460FF0", VA = "0x187461BF0", Slot = "123")]
	public void DBFNFHPKMFL(Vector3 EFNINBBEGAA, Quaternion CAKGDLIFNNG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001D1")]
	[Cpp2IlInjected.Address(RVA = "0x74616E0", Offset = "0x7460AE0", VA = "0x1874616E0", Slot = "124")]
	public void CDPLMCAIILK(Vector3 AMAEBLOGDOI, Quaternion CADLCHPONLN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001D2")]
	[Cpp2IlInjected.Address(RVA = "0x7461A80", Offset = "0x7460E80", VA = "0x187461A80", Slot = "125")]
	public bool CKAKMNOCHIM(float EGIABFGPJJA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001D7")]
	[Cpp2IlInjected.Address(RVA = "0x7464500", Offset = "0x7463900", VA = "0x187464500", Slot = "126")]
	public void JKNBEHHPBPM(object FDAIGOGAKMH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001D8")]
	[Cpp2IlInjected.Address(RVA = "0x7466040", Offset = "0x7465440", VA = "0x187466040", Slot = "127")]
	public void OECJNDGOCJP(object FDAIGOGAKMH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001D9")]
	[Cpp2IlInjected.Address(RVA = "0x74628A0", Offset = "0x7461CA0", VA = "0x1874628A0", Slot = "128")]
	public void FFOFEFGFLKG(object FDAIGOGAKMH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001DA")]
	[Cpp2IlInjected.Address(RVA = "0x74660A0", Offset = "0x74654A0", VA = "0x1874660A0", Slot = "129")]
	public void OEMBIKBABCD(object FDAIGOGAKMH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001DB")]
	[Cpp2IlInjected.Address(RVA = "0x74640B0", Offset = "0x74634B0", VA = "0x1874640B0", Slot = "130")]
	public void INGLGIDKDGP(Vector3 DPEDJCGKFCE, ForceMode BHNFLFIOPOK = ForceMode.Force)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001DC")]
	[Cpp2IlInjected.Address(RVA = "0x7461E40", Offset = "0x7461240", VA = "0x187461E40", Slot = "131")]
	public void DCOANGBBPLD(Vector3 DPEDJCGKFCE, Vector3 MBJNFCDOKCE, ForceMode BHNFLFIOPOK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001DD")]
	[Cpp2IlInjected.Address(RVA = "0x7464560", Offset = "0x7463960", VA = "0x187464560", Slot = "132")]
	public void JLECGFMKICL(Vector3 DLBJNJMLGAM, ForceMode BHNFLFIOPOK = ForceMode.Force)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001DE")]
	[Cpp2IlInjected.Address(RVA = "0x7463BC0", Offset = "0x7462FC0", VA = "0x187463BC0", Slot = "133")]
	public void HJKCNGGNMIG(Vector3 DLBJNJMLGAM, ForceMode BHNFLFIOPOK = ForceMode.Force)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001E1")]
	[Cpp2IlInjected.Address(RVA = "0x7465A10", Offset = "0x7464E10", VA = "0x187465A10", Slot = "134")]
	public bool MGCMBIFLOBP(Vector3 NLEBNOPPEID, [Out] RaycastHit EDEJMIIPLJN, float MALFDDNHAMM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001E4")]
	[Cpp2IlInjected.Address(RVA = "0x7462960", Offset = "0x7461D60", VA = "0x187462960", Slot = "135")]
	public void FHIJIPKLAKG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001E5")]
	[Cpp2IlInjected.Address(RVA = "0x74666D0", Offset = "0x7465AD0", VA = "0x1874666D0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001E6")]
	[Cpp2IlInjected.Address(RVA = "0x7466460", Offset = "0x7465860", VA = "0x187466460")]
	private void PPDDJLFLNCN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001E7")]
	[Cpp2IlInjected.Address(RVA = "0x7463810", Offset = "0x7462C10", VA = "0x187463810")]
	private void HDDMCIDMCKM(IFCIIPLFOCA IIOPLDELPHL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001E8")]
	[Cpp2IlInjected.Address(RVA = "0x74639D0", Offset = "0x7462DD0", VA = "0x1874639D0")]
	private void HHDJOINCALL(IFCIIPLFOCA IIOPLDELPHL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001E9")]
	[Cpp2IlInjected.Address(RVA = "0x7465800", Offset = "0x7464C00", VA = "0x187465800")]
	private void LNIFHIKKDLO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001EA")]
	[Cpp2IlInjected.Address(RVA = "0x7461920", Offset = "0x7460D20", VA = "0x187461920")]
	private void CGLMJJAGDMI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001EB")]
	[Cpp2IlInjected.Address(RVA = "0x74607A0", Offset = "0x745FBA0", VA = "0x1874607A0")]
	private void AAFCKIMFJFJ(IFCIIPLFOCA KNIGLOAPIND)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001EC")]
	[Cpp2IlInjected.Address(RVA = "0x7460E00", Offset = "0x7460200", VA = "0x187460E00")]
	private void BDDHKFOMOLP(IFCIIPLFOCA IIOPLDELPHL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001ED")]
	[Cpp2IlInjected.Address(RVA = "0x7462650", Offset = "0x7461A50", VA = "0x187462650")]
	private void FCGLPJAFLJE(IFCIIPLFOCA IIOPLDELPHL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001EE")]
	[Cpp2IlInjected.Address(RVA = "0x7462C90", Offset = "0x7462090", VA = "0x187462C90")]
	private void GIBEALPELJN(NADAIAGKPNF IIOPLDELPHL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001EF")]
	[Cpp2IlInjected.Address(RVA = "0x7462DE0", Offset = "0x74621E0", VA = "0x187462DE0", Slot = "141")]
	protected virtual void GIHHEHACPCP(NADAIAGKPNF DODIHPOGMBH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001F0")]
	[Cpp2IlInjected.Address(RVA = "0x74632C0", Offset = "0x74626C0", VA = "0x1874632C0")]
	protected void GKKKALJIFMH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001F1")]
	[Cpp2IlInjected.Address(RVA = "0x7465490", Offset = "0x7464890", VA = "0x187465490")]
	protected void LMNPBACKDHK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001F2")]
	[Cpp2IlInjected.Address(RVA = "0x7463FA0", Offset = "0x74633A0", VA = "0x187463FA0", Slot = "142")]
	protected virtual IDisposable IGJEMBMGCOP()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200001D")]
internal static class EAMGPIOLMGG
{
	[Cpp2IlInjected.Token(Token = "0x60001F3")]
	[Cpp2IlInjected.Address(RVA = "0x745F650", Offset = "0x745EA50", VA = "0x18745F650")]
	public static IFCIIPLFOCA PACOAJACOMB(this IFCIIPLFOCA DODIHPOGMBH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001F4")]
	[Cpp2IlInjected.Address(RVA = "0x745F560", Offset = "0x745E960", VA = "0x18745F560")]
	public static bool MGJBDBBOCED(this IFCIIPLFOCA DODIHPOGMBH, IFCIIPLFOCA NJFKHIKGMKO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001F5")]
	[Cpp2IlInjected.Address(RVA = "0x745F440", Offset = "0x745E840", VA = "0x18745F440")]
	public static bool CHGLIFMAOCM(this IFCIIPLFOCA DODIHPOGMBH, IFCIIPLFOCA BABEFKNCIME)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001F6")]
	[Cpp2IlInjected.Address(RVA = "0x745F600", Offset = "0x745EA00", VA = "0x18745F600")]
	public static NADAIAGKPNF OLEMGLFONFF(this IFCIIPLFOCA GDIPKBJJCBL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001F7")]
	[Cpp2IlInjected.Address(RVA = "0x745F4E0", Offset = "0x745E8E0", VA = "0x18745F4E0")]
	public static FKMFAEODDLC DLGPGDIHPDN(this IFCIIPLFOCA GDIPKBJJCBL)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200001E")]
public class PGNJNHOAKHO : GKAOAHDNLME
{
	[Cpp2IlInjected.Token(Token = "0x60001F8")]
	[Cpp2IlInjected.Address(RVA = "0x746F990", Offset = "0x746ED90", VA = "0x18746F990", Slot = "19")]
	public IFCIIPLFOCA DNNIJNIMPPK(RigidbodyEx DODIHPOGMBH, KDAAIDJOOBC MPMEGOKIEPF, KFKIDNCNBPA HPCAPMNEHGA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001F9")]
	[Cpp2IlInjected.Address(RVA = "0x8ABE40", Offset = "0x8AB240", VA = "0x1808ABE40", Slot = "4")]
	public IBKMOLDIGIP FNHHFOECKIG(IFCIIPLFOCA GDIPKBJJCBL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001FA")]
	[Cpp2IlInjected.Address(RVA = "0x8ABE40", Offset = "0x8AB240", VA = "0x1808ABE40", Slot = "5")]
	public MHEKBCJDIFI ABJIOJDACHB(IFCIIPLFOCA GDIPKBJJCBL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001FB")]
	[Cpp2IlInjected.Address(RVA = "0x8ABE40", Offset = "0x8AB240", VA = "0x1808ABE40", Slot = "6")]
	public BAFNGHIJNLF NDKGKONIHNN(IFCIIPLFOCA GDIPKBJJCBL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001FC")]
	[Cpp2IlInjected.Address(RVA = "0x8ABE40", Offset = "0x8AB240", VA = "0x1808ABE40", Slot = "7")]
	public NAONIBBKJJC PFEPECCPNKM(IFCIIPLFOCA GDIPKBJJCBL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001FD")]
	[Cpp2IlInjected.Address(RVA = "0x8ABE40", Offset = "0x8AB240", VA = "0x1808ABE40", Slot = "8")]
	public BMLKALHMELK CDDPEOPCDFG(IFCIIPLFOCA GDIPKBJJCBL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001FE")]
	[Cpp2IlInjected.Address(RVA = "0x8ABE40", Offset = "0x8AB240", VA = "0x1808ABE40", Slot = "9")]
	public OIHMMOOMIOD KGNLENCICKN(IFCIIPLFOCA GDIPKBJJCBL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001FF")]
	[Cpp2IlInjected.Address(RVA = "0x8ABE40", Offset = "0x8AB240", VA = "0x1808ABE40", Slot = "10")]
	public APAEMPIJCMB JHICAJAJFKA(IFCIIPLFOCA GDIPKBJJCBL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000200")]
	[Cpp2IlInjected.Address(RVA = "0x8ABE40", Offset = "0x8AB240", VA = "0x1808ABE40", Slot = "11")]
	public NLEBPALKPEF LLDKKJIANAG(IFCIIPLFOCA GDIPKBJJCBL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000201")]
	[Cpp2IlInjected.Address(RVA = "0x8ABE40", Offset = "0x8AB240", VA = "0x1808ABE40", Slot = "12")]
	public NIOGLPDPALJ AHLLGGGOLHC(IFCIIPLFOCA GDIPKBJJCBL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000202")]
	[Cpp2IlInjected.Address(RVA = "0x8ABE40", Offset = "0x8AB240", VA = "0x1808ABE40", Slot = "13")]
	public EDMKMOGFBPP MPBPAHCBHAE(IFCIIPLFOCA GDIPKBJJCBL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000203")]
	[Cpp2IlInjected.Address(RVA = "0x8ABE40", Offset = "0x8AB240", VA = "0x1808ABE40")]
	public LIOKBCGOPHC LDKDGLKNNMN(IFCIIPLFOCA GDIPKBJJCBL, [In] KDAAIDJOOBC MPMEGOKIEPF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000204")]
	[Cpp2IlInjected.Address(RVA = "0x8ABE40", Offset = "0x8AB240", VA = "0x1808ABE40")]
	public FNCIFHKHEPA POLPMIGLGPM(IFCIIPLFOCA GDIPKBJJCBL, [In] KDAAIDJOOBC MPMEGOKIEPF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000205")]
	[Cpp2IlInjected.Address(RVA = "0x8ABE40", Offset = "0x8AB240", VA = "0x1808ABE40")]
	public CJNBDDJPPFL EPELFPBDIPB(IFCIIPLFOCA GDIPKBJJCBL, [In] KDAAIDJOOBC MPMEGOKIEPF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000206")]
	[Cpp2IlInjected.Address(RVA = "0x8ABE40", Offset = "0x8AB240", VA = "0x1808ABE40")]
	public EHCMCNEDKLA HHEJNEOAJNI(IFCIIPLFOCA GDIPKBJJCBL, [In] KDAAIDJOOBC MPMEGOKIEPF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000207")]
	[Cpp2IlInjected.Address(RVA = "0x8ABE40", Offset = "0x8AB240", VA = "0x1808ABE40")]
	public NPPMLEINIBM MPPKBLFBIOD(IFCIIPLFOCA GDIPKBJJCBL, [In] KDAAIDJOOBC MPMEGOKIEPF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000208")]
	[Cpp2IlInjected.Address(RVA = "0x8B7800", Offset = "0x8B6C00", VA = "0x1808B7800")]
	public PGNJNHOAKHO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000209")]
	[Cpp2IlInjected.Address(RVA = "0x8ABE40", Offset = "0x8AB240", VA = "0x1808ABE40", Slot = "14")]
	private LIOKBCGOPHC BABBOCIKCEP(IFCIIPLFOCA GDIPKBJJCBL, [In] KDAAIDJOOBC MPMEGOKIEPF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600020A")]
	[Cpp2IlInjected.Address(RVA = "0x8ABE40", Offset = "0x8AB240", VA = "0x1808ABE40", Slot = "15")]
	private FNCIFHKHEPA LMELGPEFLNG(IFCIIPLFOCA GDIPKBJJCBL, [In] KDAAIDJOOBC MPMEGOKIEPF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600020B")]
	[Cpp2IlInjected.Address(RVA = "0x8ABE40", Offset = "0x8AB240", VA = "0x1808ABE40", Slot = "16")]
	private CJNBDDJPPFL PACAGMHFNCK(IFCIIPLFOCA GDIPKBJJCBL, [In] KDAAIDJOOBC MPMEGOKIEPF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600020C")]
	[Cpp2IlInjected.Address(RVA = "0x8ABE40", Offset = "0x8AB240", VA = "0x1808ABE40", Slot = "17")]
	private EHCMCNEDKLA AAEHALACEMH(IFCIIPLFOCA GDIPKBJJCBL, [In] KDAAIDJOOBC MPMEGOKIEPF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600020D")]
	[Cpp2IlInjected.Address(RVA = "0x8ABE40", Offset = "0x8AB240", VA = "0x1808ABE40", Slot = "18")]
	private NPPMLEINIBM NMFHHLDBLJC(IFCIIPLFOCA GDIPKBJJCBL, [In] KDAAIDJOOBC MPMEGOKIEPF)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200001F")]
[DKHNDPDIDGH(typeof(GKAOAHDNLME), new string[] { })]
public class PIPJDCCOPNB : GKAOAHDNLME, KHBMANBAPGM
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400002C")]
	private readonly GKAOAHDNLME JNBHCNBKJNB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400002D")]
	private readonly GKAOAHDNLME LDDJFGEDAHF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400002E")]
	private KBDFHAMLBOL KLBPBADFKHP;

	[Cpp2IlInjected.Token(Token = "0x17000089")]
	private GKAOAHDNLME CKCHNKBNKLN
	{
		[Cpp2IlInjected.Token(Token = "0x600020F")]
		[Cpp2IlInjected.Address(RVA = "0x746FD70", Offset = "0x746F170", VA = "0x18746FD70")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600020E")]
	[Cpp2IlInjected.Address(RVA = "0x7470070", Offset = "0x746F470", VA = "0x187470070", Slot = "20")]
	public void InitReferences(IAKDMLIJPDA NEOPINGDODK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000210")]
	[Cpp2IlInjected.Address(RVA = "0x746FFD0", Offset = "0x746F3D0", VA = "0x18746FFD0", Slot = "4")]
	public IBKMOLDIGIP FNHHFOECKIG(IFCIIPLFOCA GDIPKBJJCBL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000211")]
	[Cpp2IlInjected.Address(RVA = "0x746FAE0", Offset = "0x746EEE0", VA = "0x18746FAE0", Slot = "5")]
	public MHEKBCJDIFI ABJIOJDACHB(IFCIIPLFOCA GDIPKBJJCBL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000212")]
	[Cpp2IlInjected.Address(RVA = "0x74704A0", Offset = "0x746F8A0", VA = "0x1874704A0", Slot = "6")]
	public BAFNGHIJNLF NDKGKONIHNN(IFCIIPLFOCA GDIPKBJJCBL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000213")]
	[Cpp2IlInjected.Address(RVA = "0x7470540", Offset = "0x746F940", VA = "0x187470540", Slot = "7")]
	public NAONIBBKJJC PFEPECCPNKM(IFCIIPLFOCA GDIPKBJJCBL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000214")]
	[Cpp2IlInjected.Address(RVA = "0x746FCD0", Offset = "0x746F0D0", VA = "0x18746FCD0", Slot = "8")]
	public BMLKALHMELK CDDPEOPCDFG(IFCIIPLFOCA GDIPKBJJCBL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000215")]
	[Cpp2IlInjected.Address(RVA = "0x7470160", Offset = "0x746F560", VA = "0x187470160", Slot = "9")]
	public OIHMMOOMIOD KGNLENCICKN(IFCIIPLFOCA GDIPKBJJCBL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000216")]
	[Cpp2IlInjected.Address(RVA = "0x74700C0", Offset = "0x746F4C0", VA = "0x1874700C0", Slot = "10")]
	public APAEMPIJCMB JHICAJAJFKA(IFCIIPLFOCA GDIPKBJJCBL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000217")]
	[Cpp2IlInjected.Address(RVA = "0x7470200", Offset = "0x746F600", VA = "0x187470200", Slot = "11")]
	public NLEBPALKPEF LLDKKJIANAG(IFCIIPLFOCA GDIPKBJJCBL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000218")]
	[Cpp2IlInjected.Address(RVA = "0x746FB80", Offset = "0x746EF80", VA = "0x18746FB80", Slot = "12")]
	public NIOGLPDPALJ AHLLGGGOLHC(IFCIIPLFOCA GDIPKBJJCBL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000219")]
	[Cpp2IlInjected.Address(RVA = "0x7470350", Offset = "0x746F750", VA = "0x187470350", Slot = "13")]
	public EDMKMOGFBPP MPBPAHCBHAE(IFCIIPLFOCA GDIPKBJJCBL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600021A")]
	[Cpp2IlInjected.Address(RVA = "0x746FC20", Offset = "0x746F020", VA = "0x18746FC20")]
	public LIOKBCGOPHC LDKDGLKNNMN(IFCIIPLFOCA GDIPKBJJCBL, [In] KDAAIDJOOBC MPMEGOKIEPF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600021B")]
	[Cpp2IlInjected.Address(RVA = "0x74702A0", Offset = "0x746F6A0", VA = "0x1874702A0")]
	public FNCIFHKHEPA POLPMIGLGPM(IFCIIPLFOCA GDIPKBJJCBL, [In] KDAAIDJOOBC MPMEGOKIEPF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600021C")]
	[Cpp2IlInjected.Address(RVA = "0x746FF20", Offset = "0x746F320", VA = "0x18746FF20")]
	public CJNBDDJPPFL EPELFPBDIPB(IFCIIPLFOCA GDIPKBJJCBL, [In] KDAAIDJOOBC MPMEGOKIEPF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600021D")]
	[Cpp2IlInjected.Address(RVA = "0x746FA30", Offset = "0x746EE30", VA = "0x18746FA30")]
	public EHCMCNEDKLA HHEJNEOAJNI(IFCIIPLFOCA GDIPKBJJCBL, [In] KDAAIDJOOBC MPMEGOKIEPF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600021E")]
	[Cpp2IlInjected.Address(RVA = "0x74703F0", Offset = "0x746F7F0", VA = "0x1874703F0")]
	public NPPMLEINIBM MPPKBLFBIOD(IFCIIPLFOCA GDIPKBJJCBL, [In] KDAAIDJOOBC MPMEGOKIEPF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600021F")]
	[Cpp2IlInjected.Address(RVA = "0x746FDD0", Offset = "0x746F1D0", VA = "0x18746FDD0", Slot = "19")]
	public IFCIIPLFOCA DNNIJNIMPPK(RigidbodyEx DODIHPOGMBH, KDAAIDJOOBC MPMEGOKIEPF, KFKIDNCNBPA HPCAPMNEHGA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000220")]
	[Cpp2IlInjected.Address(RVA = "0x74705E0", Offset = "0x746F9E0", VA = "0x1874705E0")]
	public PIPJDCCOPNB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000221")]
	[Cpp2IlInjected.Address(RVA = "0x746FC20", Offset = "0x746F020", VA = "0x18746FC20", Slot = "14")]
	private LIOKBCGOPHC BABBOCIKCEP(IFCIIPLFOCA GDIPKBJJCBL, [In] KDAAIDJOOBC MPMEGOKIEPF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000222")]
	[Cpp2IlInjected.Address(RVA = "0x74702A0", Offset = "0x746F6A0", VA = "0x1874702A0", Slot = "15")]
	private FNCIFHKHEPA LMELGPEFLNG(IFCIIPLFOCA GDIPKBJJCBL, [In] KDAAIDJOOBC MPMEGOKIEPF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000223")]
	[Cpp2IlInjected.Address(RVA = "0x746FF20", Offset = "0x746F320", VA = "0x18746FF20", Slot = "16")]
	private CJNBDDJPPFL PACAGMHFNCK(IFCIIPLFOCA GDIPKBJJCBL, [In] KDAAIDJOOBC MPMEGOKIEPF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000224")]
	[Cpp2IlInjected.Address(RVA = "0x746FA30", Offset = "0x746EE30", VA = "0x18746FA30", Slot = "17")]
	private EHCMCNEDKLA AAEHALACEMH(IFCIIPLFOCA GDIPKBJJCBL, [In] KDAAIDJOOBC MPMEGOKIEPF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000225")]
	[Cpp2IlInjected.Address(RVA = "0x74703F0", Offset = "0x746F7F0", VA = "0x1874703F0", Slot = "18")]
	private NPPMLEINIBM NMFHHLDBLJC(IFCIIPLFOCA GDIPKBJJCBL, [In] KDAAIDJOOBC MPMEGOKIEPF)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000020")]
public interface HAKEFFOFKFC : IBKMOLDIGIP, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x6000226")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void IPADPHKPOBL(IFCIIPLFOCA DODIHPOGMBH);

	[Cpp2IlInjected.Token(Token = "0x6000227")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void LGFCHGJCHPJ(IFCIIPLFOCA DODIHPOGMBH);

	[Cpp2IlInjected.Token(Token = "0x6000228")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void GFNMIAAGAGA(IFCIIPLFOCA KNIGLOAPIND);

	[Cpp2IlInjected.Token(Token = "0x6000229")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void CMMNLOMKNFB(IFCIIPLFOCA KNIGLOAPIND);
}
[Cpp2IlInjected.Token(Token = "0x2000021")]
public interface PKDAKDEJBFF : BAFNGHIJNLF
{
	[Cpp2IlInjected.Token(Token = "0x1700008A")]
	EDLOJEAHDJH<IFCIIPLFOCA> JHBHHMGJABD
	{
		[Cpp2IlInjected.Token(Token = "0x600022A")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700008B")]
	IFCIIPLFOCA PLAPFABEBGM
	{
		[Cpp2IlInjected.Token(Token = "0x600022B")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000022")]
public interface FKJIHDDFECN : EHCMCNEDKLA
{
	[Cpp2IlInjected.Token(Token = "0x600022C")]
	[Cpp2IlInjected.Address(Slot = "0")]
	(float, Vector3) DHLNGHDDEPJ(Rigidbody CPIILEDGANK);
}
[Cpp2IlInjected.Token(Token = "0x2000023")]
public interface NDPNKMNENHG : FNCIFHKHEPA, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x1700008C")]
	PhotonView NJAJDNJCFPE
	{
		[Cpp2IlInjected.Token(Token = "0x600022D")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000024")]
internal sealed class NNIKBPFBFED : NIOGLPDPALJ
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400002F")]
	private readonly FKMFAEODDLC DODIHPOGMBH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000030")]
	private CollisionDetectionMode DIKOJDOOKMD;

	[Cpp2IlInjected.Token(Token = "0x1700008D")]
	private Rigidbody CFDDIFJHEKO
	{
		[Cpp2IlInjected.Token(Token = "0x600022E")]
		[Cpp2IlInjected.Address(RVA = "0x7467060", Offset = "0x7466460", VA = "0x187467060")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700008E")]
	public CollisionDetectionMode ANEBIFEMAJG
	{
		[Cpp2IlInjected.Token(Token = "0x6000232")]
		[Cpp2IlInjected.Address(RVA = "0x7468910", Offset = "0x7467D10", VA = "0x187468910", Slot = "4")]
		get
		{
			return default(CollisionDetectionMode);
		}
		[Cpp2IlInjected.Token(Token = "0x6000233")]
		[Cpp2IlInjected.Address(RVA = "0x7468B30", Offset = "0x7467F30", VA = "0x187468B30", Slot = "5")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600022F")]
	[Cpp2IlInjected.Address(RVA = "0x745A770", Offset = "0x7459B70", VA = "0x18745A770")]
	public NNIKBPFBFED(IFCIIPLFOCA DODIHPOGMBH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000230")]
	[Cpp2IlInjected.Address(RVA = "0x7468A20", Offset = "0x7467E20", VA = "0x187468A20", Slot = "6")]
	public void JBLDGJLDMEF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000231")]
	[Cpp2IlInjected.Address(RVA = "0x7468760", Offset = "0x7467B60", VA = "0x187468760", Slot = "9")]
	public void BLEFDCFMIJN(Rigidbody GJHIIOHAAJN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000234")]
	[Cpp2IlInjected.Address(RVA = "0x74687E0", Offset = "0x7467BE0", VA = "0x1874687E0", Slot = "7")]
	public void DCLILJNDEOI(bool DOCADGKKNNG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000235")]
	[Cpp2IlInjected.Address(RVA = "0x7468D00", Offset = "0x7468100", VA = "0x187468D00", Slot = "8")]
	public void PNKBMGGOAMP(bool DOCADGKKNNG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000236")]
	[Cpp2IlInjected.Address(RVA = "0x7468BA0", Offset = "0x7467FA0", VA = "0x187468BA0", Slot = "10")]
	public bool MGCMBIFLOBP(Vector3 NLEBNOPPEID, [Out] RaycastHit EDEJMIIPLJN, float MALFDDNHAMM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000237")]
	[Cpp2IlInjected.Address(RVA = "0x74687F0", Offset = "0x7467BF0", VA = "0x1874687F0")]
	private void DNFECDDLHFM(bool DOCADGKKNNG)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000025")]
public sealed class KAJBABPKACD : OIHMMOOMIOD, IDisposable, MGJHENFBMOI
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000032")]
	private readonly FKMFAEODDLC DODIHPOGMBH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000033")]
	private NKELFIBCFCE PDLFPJFMGFB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000034")]
	private ECODPLJIFEC OHGCFCIIOAE;

	[Cpp2IlInjected.Token(Token = "0x1700008F")]
	public NKELFIBCFCE HJPEGFBCCAB
	{
		[Cpp2IlInjected.Token(Token = "0x600023A")]
		[Cpp2IlInjected.Address(RVA = "0x7467B20", Offset = "0x7466F20", VA = "0x187467B20", Slot = "6")]
		get
		{
			return default(NKELFIBCFCE);
		}
		[Cpp2IlInjected.Token(Token = "0x600023B")]
		[Cpp2IlInjected.Address(RVA = "0x74680C0", Offset = "0x74674C0", VA = "0x1874680C0", Slot = "7")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000090")]
	private Transform DKPLNFOBBHH
	{
		[Cpp2IlInjected.Token(Token = "0x600023C")]
		[Cpp2IlInjected.Address(RVA = "0x7467D20", Offset = "0x7467120", VA = "0x187467D20", Slot = "10")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000020")]
	public event Action<GGHKEJOODBA, GGHKEJOODBA> ICBMGNDEMLD
	{
		[Cpp2IlInjected.Token(Token = "0x6000238")]
		[Cpp2IlInjected.Address(RVA = "0x7467C70", Offset = "0x7467070", VA = "0x187467C70", Slot = "4")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000239")]
		[Cpp2IlInjected.Address(RVA = "0x7467D90", Offset = "0x7467190", VA = "0x187467D90", Slot = "5")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600023D")]
	[Cpp2IlInjected.Address(RVA = "0x7468190", Offset = "0x7467590", VA = "0x187468190")]
	public KAJBABPKACD(IFCIIPLFOCA DODIHPOGMBH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600023E")]
	[Cpp2IlInjected.Address(RVA = "0x7467E40", Offset = "0x7467240", VA = "0x187467E40", Slot = "8")]
	public void JBLDGJLDMEF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600023F")]
	[Cpp2IlInjected.Address(RVA = "0x7467D40", Offset = "0x7467140", VA = "0x187467D40", Slot = "9")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000240")]
	[Cpp2IlInjected.Address(RVA = "0xC91660", Offset = "0xC90A60", VA = "0x180C91660", Slot = "11")]
	private void BJPGECJKICP(GGHKEJOODBA JDADDGIEFHK, GGHKEJOODBA DHLGCOJLBKM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000241")]
	[Cpp2IlInjected.Address(RVA = "0x8ABE30", Offset = "0x8AB230", VA = "0x1808ABE30", Slot = "12")]
	private void MBMPFEPFGJD(bool LNDNKAMNDAA)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000026")]
public class ENHEPDLLHNB : GKAOAHDNLME
{
	[Cpp2IlInjected.Token(Token = "0x6000242")]
	[Cpp2IlInjected.Address(RVA = "0x745FF20", Offset = "0x745F320", VA = "0x18745FF20", Slot = "4")]
	public IBKMOLDIGIP FNHHFOECKIG(IFCIIPLFOCA GDIPKBJJCBL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000243")]
	[Cpp2IlInjected.Address(RVA = "0x745F8A0", Offset = "0x745ECA0", VA = "0x18745F8A0", Slot = "5")]
	public MHEKBCJDIFI ABJIOJDACHB(IFCIIPLFOCA GDIPKBJJCBL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000244")]
	[Cpp2IlInjected.Address(RVA = "0x74605F0", Offset = "0x745F9F0", VA = "0x1874605F0", Slot = "6")]
	public BAFNGHIJNLF NDKGKONIHNN(IFCIIPLFOCA GDIPKBJJCBL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000245")]
	[Cpp2IlInjected.Address(RVA = "0x7460720", Offset = "0x745FB20", VA = "0x187460720", Slot = "7")]
	public NAONIBBKJJC PFEPECCPNKM(IFCIIPLFOCA GDIPKBJJCBL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000246")]
	[Cpp2IlInjected.Address(RVA = "0x745FBD0", Offset = "0x745EFD0", VA = "0x18745FBD0", Slot = "8")]
	public BMLKALHMELK CDDPEOPCDFG(IFCIIPLFOCA GDIPKBJJCBL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000247")]
	[Cpp2IlInjected.Address(RVA = "0x7460130", Offset = "0x745F530", VA = "0x187460130", Slot = "9")]
	public OIHMMOOMIOD KGNLENCICKN(IFCIIPLFOCA GDIPKBJJCBL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000248")]
	[Cpp2IlInjected.Address(RVA = "0x7460010", Offset = "0x745F410", VA = "0x187460010", Slot = "10")]
	public APAEMPIJCMB JHICAJAJFKA(IFCIIPLFOCA GDIPKBJJCBL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000249")]
	[Cpp2IlInjected.Address(RVA = "0x7460200", Offset = "0x745F600", VA = "0x187460200", Slot = "11")]
	public NLEBPALKPEF LLDKKJIANAG(IFCIIPLFOCA GDIPKBJJCBL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600024A")]
	[Cpp2IlInjected.Address(RVA = "0x745F9D0", Offset = "0x745EDD0", VA = "0x18745F9D0", Slot = "12")]
	public NIOGLPDPALJ AHLLGGGOLHC(IFCIIPLFOCA GDIPKBJJCBL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600024B")]
	[Cpp2IlInjected.Address(RVA = "0x7460450", Offset = "0x745F850", VA = "0x187460450", Slot = "13")]
	public EDMKMOGFBPP MPBPAHCBHAE(IFCIIPLFOCA GDIPKBJJCBL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600024C")]
	[Cpp2IlInjected.Address(RVA = "0x745FA90", Offset = "0x745EE90", VA = "0x18745FA90")]
	public LIOKBCGOPHC LDKDGLKNNMN(IFCIIPLFOCA GDIPKBJJCBL, [In] KDAAIDJOOBC MPMEGOKIEPF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600024D")]
	[Cpp2IlInjected.Address(RVA = "0x74602C0", Offset = "0x745F6C0", VA = "0x1874602C0")]
	public FNCIFHKHEPA POLPMIGLGPM(IFCIIPLFOCA GDIPKBJJCBL, [In] KDAAIDJOOBC MPMEGOKIEPF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600024E")]
	[Cpp2IlInjected.Address(RVA = "0x745FDF0", Offset = "0x745F1F0", VA = "0x18745FDF0")]
	public CJNBDDJPPFL EPELFPBDIPB(IFCIIPLFOCA GDIPKBJJCBL, [In] KDAAIDJOOBC MPMEGOKIEPF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600024F")]
	[Cpp2IlInjected.Address(RVA = "0x745F710", Offset = "0x745EB10", VA = "0x18745F710")]
	public EHCMCNEDKLA HHEJNEOAJNI(IFCIIPLFOCA GDIPKBJJCBL, [In] KDAAIDJOOBC MPMEGOKIEPF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000250")]
	[Cpp2IlInjected.Address(RVA = "0x7460510", Offset = "0x745F910", VA = "0x187460510")]
	public NPPMLEINIBM MPPKBLFBIOD(IFCIIPLFOCA GDIPKBJJCBL, [In] KDAAIDJOOBC MPMEGOKIEPF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000251")]
	[Cpp2IlInjected.Address(RVA = "0x745FCA0", Offset = "0x745F0A0", VA = "0x18745FCA0", Slot = "19")]
	public IFCIIPLFOCA DNNIJNIMPPK(RigidbodyEx DODIHPOGMBH, KDAAIDJOOBC MPMEGOKIEPF, KFKIDNCNBPA HPCAPMNEHGA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000252")]
	[Cpp2IlInjected.Address(RVA = "0x8B7800", Offset = "0x8B6C00", VA = "0x1808B7800")]
	public ENHEPDLLHNB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000253")]
	[Cpp2IlInjected.Address(RVA = "0x745FA90", Offset = "0x745EE90", VA = "0x18745FA90", Slot = "14")]
	private LIOKBCGOPHC BABBOCIKCEP(IFCIIPLFOCA GDIPKBJJCBL, [In] KDAAIDJOOBC MPMEGOKIEPF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000254")]
	[Cpp2IlInjected.Address(RVA = "0x74602C0", Offset = "0x745F6C0", VA = "0x1874602C0", Slot = "15")]
	private FNCIFHKHEPA LMELGPEFLNG(IFCIIPLFOCA GDIPKBJJCBL, [In] KDAAIDJOOBC MPMEGOKIEPF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000255")]
	[Cpp2IlInjected.Address(RVA = "0x745FDF0", Offset = "0x745F1F0", VA = "0x18745FDF0", Slot = "16")]
	private CJNBDDJPPFL PACAGMHFNCK(IFCIIPLFOCA GDIPKBJJCBL, [In] KDAAIDJOOBC MPMEGOKIEPF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000256")]
	[Cpp2IlInjected.Address(RVA = "0x745F710", Offset = "0x745EB10", VA = "0x18745F710", Slot = "17")]
	private EHCMCNEDKLA AAEHALACEMH(IFCIIPLFOCA GDIPKBJJCBL, [In] KDAAIDJOOBC MPMEGOKIEPF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000257")]
	[Cpp2IlInjected.Address(RVA = "0x7460510", Offset = "0x745F910", VA = "0x187460510", Slot = "18")]
	private NPPMLEINIBM NMFHHLDBLJC(IFCIIPLFOCA GDIPKBJJCBL, [In] KDAAIDJOOBC MPMEGOKIEPF)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000027")]
internal sealed class IBJLOJLMMMD : NLEBPALKPEF
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000035")]
	private readonly FKMFAEODDLC DODIHPOGMBH;

	[Cpp2IlInjected.Token(Token = "0x17000091")]
	private Rigidbody CFDDIFJHEKO
	{
		[Cpp2IlInjected.Token(Token = "0x6000258")]
		[Cpp2IlInjected.Address(RVA = "0x7467060", Offset = "0x7466460", VA = "0x187467060")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000092")]
	private bool DBMGBKHLGGG
	{
		[Cpp2IlInjected.Token(Token = "0x6000259")]
		[Cpp2IlInjected.Address(RVA = "0x74670B0", Offset = "0x74664B0", VA = "0x1874670B0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000093")]
	private bool JIJHHIKHFHH
	{
		[Cpp2IlInjected.Token(Token = "0x600025A")]
		[Cpp2IlInjected.Address(RVA = "0x745ED50", Offset = "0x745E150", VA = "0x18745ED50")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000094")]
	private IFCIIPLFOCA DIEIKKLOHIA
	{
		[Cpp2IlInjected.Token(Token = "0x600025B")]
		[Cpp2IlInjected.Address(RVA = "0x7467100", Offset = "0x7466500", VA = "0x187467100")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600025C")]
	[Cpp2IlInjected.Address(RVA = "0x745A770", Offset = "0x7459B70", VA = "0x18745A770")]
	public IBJLOJLMMMD(IFCIIPLFOCA DODIHPOGMBH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600025D")]
	[Cpp2IlInjected.Address(RVA = "0x7466DA0", Offset = "0x74661A0", VA = "0x187466DA0", Slot = "4")]
	public void INGLGIDKDGP(Vector3 DPEDJCGKFCE, ForceMode BHNFLFIOPOK = ForceMode.Force)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600025E")]
	[Cpp2IlInjected.Address(RVA = "0x74673C0", Offset = "0x74667C0", VA = "0x1874673C0")]
	private void PCAENEHCANM(Vector3 DPEDJCGKFCE, ForceMode BHNFLFIOPOK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600025F")]
	[Cpp2IlInjected.Address(RVA = "0x74668C0", Offset = "0x7465CC0", VA = "0x1874668C0", Slot = "5")]
	public void DCOANGBBPLD(Vector3 DPEDJCGKFCE, Vector3 MBJNFCDOKCE, ForceMode BHNFLFIOPOK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000260")]
	[Cpp2IlInjected.Address(RVA = "0x7466F00", Offset = "0x7466300", VA = "0x187466F00", Slot = "6")]
	public void JLECGFMKICL(Vector3 DLBJNJMLGAM, ForceMode BHNFLFIOPOK = ForceMode.Force)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000261")]
	[Cpp2IlInjected.Address(RVA = "0x7467160", Offset = "0x7466560", VA = "0x187467160")]
	private void NEGHCHKMKHN(Vector3 DLBJNJMLGAM, ForceMode BHNFLFIOPOK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000262")]
	[Cpp2IlInjected.Address(RVA = "0x7466B40", Offset = "0x7465F40", VA = "0x187466B40", Slot = "7")]
	public void HJKCNGGNMIG(Vector3 DLBJNJMLGAM, ForceMode BHNFLFIOPOK = ForceMode.Force)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000028")]
internal sealed class CHCKNPBEPEH : EDMKMOGFBPP
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000036")]
	private readonly FKMFAEODDLC DODIHPOGMBH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000037")]
	private bool MPCPHCDONPP;

	[Cpp2IlInjected.Token(Token = "0x17000095")]
	public bool DEFHIOIJCFC
	{
		[Cpp2IlInjected.Token(Token = "0x6000264")]
		[Cpp2IlInjected.Address(RVA = "0xB81E30", Offset = "0xB81230", VA = "0x180B81E30", Slot = "4")]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000265")]
		[Cpp2IlInjected.Address(RVA = "0x745A660", Offset = "0x7459A60", VA = "0x18745A660", Slot = "5")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000263")]
	[Cpp2IlInjected.Address(RVA = "0x745A770", Offset = "0x7459B70", VA = "0x18745A770")]
	public CHCKNPBEPEH(IFCIIPLFOCA DODIHPOGMBH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000266")]
	[Cpp2IlInjected.Address(RVA = "0x745A5C0", Offset = "0x74599C0", VA = "0x18745A5C0", Slot = "6")]
	public void BLEFDCFMIJN(Rigidbody GJHIIOHAAJN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000267")]
	[Cpp2IlInjected.Address(RVA = "0x745A5F0", Offset = "0x74599F0", VA = "0x18745A5F0", Slot = "7")]
	public void NMLKFMMMKPL(Rigidbody GJHIIOHAAJN)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000029")]
internal sealed class CKGDAMIMHNJ : HAKEFFOFKFC, IBKMOLDIGIP, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x4000041")]
	private readonly IFCIIPLFOCA DODIHPOGMBH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x4000042")]
	private readonly List<IFCIIPLFOCA> DAJDKFBPNJD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x4000043")]
	private IFCIIPLFOCA FINELPFBLOK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x4000044")]
	private IFCIIPLFOCA IIOPLDELPHL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
	[Cpp2IlInjected.Token(Token = "0x4000045")]
	private Transform KMDKIGODBCM;

	[Cpp2IlInjected.Token(Token = "0x17000096")]
	private Transform GCKCOGKHDGG
	{
		[Cpp2IlInjected.Token(Token = "0x600027A")]
		[Cpp2IlInjected.Address(RVA = "0x745B680", Offset = "0x745AA80", VA = "0x18745B680")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000097")]
	public IFCIIPLFOCA DIEIKKLOHIA
	{
		[Cpp2IlInjected.Token(Token = "0x600027D")]
		[Cpp2IlInjected.Address(RVA = "0x8ADBD0", Offset = "0x8ACFD0", VA = "0x1808ADBD0", Slot = "28")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600027E")]
		[Cpp2IlInjected.Address(RVA = "0x745B490", Offset = "0x745A890", VA = "0x18745B490", Slot = "29")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000098")]
	public IFCIIPLFOCA FKDEHKMEOCL
	{
		[Cpp2IlInjected.Token(Token = "0x600027F")]
		[Cpp2IlInjected.Address(RVA = "0x8ADC00", Offset = "0x8AD000", VA = "0x1808ADC00", Slot = "27")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000099")]
	public IReadOnlyList<IFCIIPLFOCA> PMONIJFECNE
	{
		[Cpp2IlInjected.Token(Token = "0x6000280")]
		[Cpp2IlInjected.Address(RVA = "0x8ADBE0", Offset = "0x8ACFE0", VA = "0x1808ADBE0", Slot = "26")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000021")]
	public event NAKAIBCOGCG GDBMDOOJHFI
	{
		[Cpp2IlInjected.Token(Token = "0x6000268")]
		[Cpp2IlInjected.Address(RVA = "0x745C390", Offset = "0x745B790", VA = "0x18745C390", Slot = "8")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000269")]
		[Cpp2IlInjected.Address(RVA = "0x745C430", Offset = "0x745B830", VA = "0x18745C430", Slot = "9")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000022")]
	public event NAKAIBCOGCG PGCCLNEEMNN
	{
		[Cpp2IlInjected.Token(Token = "0x600026A")]
		[Cpp2IlInjected.Address(RVA = "0x745B4A0", Offset = "0x745A8A0", VA = "0x18745B4A0", Slot = "10")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600026B")]
		[Cpp2IlInjected.Address(RVA = "0x745A960", Offset = "0x7459D60", VA = "0x18745A960", Slot = "11")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000023")]
	public event EGODMMHJIHF GGLBNLKBFBC
	{
		[Cpp2IlInjected.Token(Token = "0x600026C")]
		[Cpp2IlInjected.Address(RVA = "0x745AA00", Offset = "0x7459E00", VA = "0x18745AA00", Slot = "12")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600026D")]
		[Cpp2IlInjected.Address(RVA = "0x745B3F0", Offset = "0x745A7F0", VA = "0x18745B3F0", Slot = "13")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000024")]
	public event Action BGFGNGIAHPP
	{
		[Cpp2IlInjected.Token(Token = "0x600026E")]
		[Cpp2IlInjected.Address(RVA = "0x745C1A0", Offset = "0x745B5A0", VA = "0x18745C1A0", Slot = "14")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600026F")]
		[Cpp2IlInjected.Address(RVA = "0x745B540", Offset = "0x745A940", VA = "0x18745B540", Slot = "15")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000025")]
	public event Action KDFKEHPMAFO
	{
		[Cpp2IlInjected.Token(Token = "0x6000270")]
		[Cpp2IlInjected.Address(RVA = "0x745BEC0", Offset = "0x745B2C0", VA = "0x18745BEC0", Slot = "16")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000271")]
		[Cpp2IlInjected.Address(RVA = "0x745C020", Offset = "0x745B420", VA = "0x18745C020", Slot = "17")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000026")]
	public event Action<IFCIIPLFOCA> NIBDNIAMOKD
	{
		[Cpp2IlInjected.Token(Token = "0x6000272")]
		[Cpp2IlInjected.Address(RVA = "0x745BBB0", Offset = "0x745AFB0", VA = "0x18745BBB0", Slot = "18")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000273")]
		[Cpp2IlInjected.Address(RVA = "0x745A800", Offset = "0x7459C00", VA = "0x18745A800", Slot = "19")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000027")]
	public event Action<IFCIIPLFOCA> HIODMAHJOKN
	{
		[Cpp2IlInjected.Token(Token = "0x6000274")]
		[Cpp2IlInjected.Address(RVA = "0x745B340", Offset = "0x745A740", VA = "0x18745B340", Slot = "20")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000275")]
		[Cpp2IlInjected.Address(RVA = "0x745C2E0", Offset = "0x745B6E0", VA = "0x18745C2E0", Slot = "21")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000028")]
	public event Action JHIDFLNDFIO
	{
		[Cpp2IlInjected.Token(Token = "0x6000276")]
		[Cpp2IlInjected.Address(RVA = "0x745C240", Offset = "0x745B640", VA = "0x18745C240", Slot = "22")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000277")]
		[Cpp2IlInjected.Address(RVA = "0x745BC60", Offset = "0x745B060", VA = "0x18745BC60", Slot = "23")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000029")]
	public event Action<IFCIIPLFOCA> AOLCDDNCKOH
	{
		[Cpp2IlInjected.Token(Token = "0x6000278")]
		[Cpp2IlInjected.Address(RVA = "0x745A8B0", Offset = "0x7459CB0", VA = "0x18745A8B0", Slot = "24")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000279")]
		[Cpp2IlInjected.Address(RVA = "0x745BE10", Offset = "0x745B210", VA = "0x18745BE10", Slot = "25")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600027B")]
	[Cpp2IlInjected.Address(RVA = "0x745C600", Offset = "0x745BA00", VA = "0x18745C600")]
	public CKGDAMIMHNJ(IFCIIPLFOCA DODIHPOGMBH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600027C")]
	[Cpp2IlInjected.Address(RVA = "0x745B2A0", Offset = "0x745A6A0", VA = "0x18745B2A0", Slot = "31")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000281")]
	[Cpp2IlInjected.Address(RVA = "0x745AD20", Offset = "0x745A120", VA = "0x18745AD20", Slot = "30")]
	public void DDIJPNBLPCC(IFCIIPLFOCA FFCFOAEFPGC, bool FHCBEIGKGNF = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000282")]
	[Cpp2IlInjected.Address(RVA = "0x745B940", Offset = "0x745AD40", VA = "0x18745B940", Slot = "6")]
	public void GFNMIAAGAGA(IFCIIPLFOCA KNIGLOAPIND)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000283")]
	[Cpp2IlInjected.Address(RVA = "0x745AAA0", Offset = "0x7459EA0", VA = "0x18745AAA0", Slot = "7")]
	public void CMMNLOMKNFB(IFCIIPLFOCA KNIGLOAPIND)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000284")]
	[Cpp2IlInjected.Address(RVA = "0x745BD00", Offset = "0x745B100", VA = "0x18745BD00", Slot = "4")]
	public void IPADPHKPOBL(IFCIIPLFOCA DODIHPOGMBH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000285")]
	[Cpp2IlInjected.Address(RVA = "0x745C0C0", Offset = "0x745B4C0", VA = "0x18745C0C0", Slot = "5")]
	public void LGFCHGJCHPJ(IFCIIPLFOCA DODIHPOGMBH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000286")]
	[Cpp2IlInjected.Address(RVA = "0x745B5E0", Offset = "0x745A9E0", VA = "0x18745B5E0")]
	private void FOKBPHLBOCB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000287")]
	[Cpp2IlInjected.Address(RVA = "0x745C160", Offset = "0x745B560", VA = "0x18745C160")]
	private void LMMHKBKIOHE(IFCIIPLFOCA KNIGLOAPIND)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000288")]
	[Cpp2IlInjected.Address(RVA = "0x745B800", Offset = "0x745AC00", VA = "0x18745B800")]
	private void GFMHKFKLEEM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000289")]
	[Cpp2IlInjected.Address(RVA = "0x745C4D0", Offset = "0x745B8D0", VA = "0x18745C4D0")]
	private void PLKOMACINND()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600028A")]
	[Cpp2IlInjected.Address(RVA = "0x745B6E0", Offset = "0x745AAE0", VA = "0x18745B6E0")]
	private void GBOJHKCOJKO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600028B")]
	[Cpp2IlInjected.Address(RVA = "0x745BF60", Offset = "0x745B360", VA = "0x18745BF60")]
	[CompilerGenerated]
	private object KDGEMPPPKPO()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200002A")]
internal static class GJMHLHKEKOG
{
	[Cpp2IlInjected.Token(Token = "0x600028C")]
	[Cpp2IlInjected.Address(RVA = "0x7466800", Offset = "0x7465C00", VA = "0x187466800")]
	public static HAKEFFOFKFC NCDLNPPNMIJ(this IFCIIPLFOCA GDIPKBJJCBL)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200002B")]
internal sealed class PGEALEODADH : PKDAKDEJBFF, BAFNGHIJNLF
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000046")]
	private readonly FKMFAEODDLC DODIHPOGMBH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000047")]
	private readonly EDLOJEAHDJH<IFCIIPLFOCA> GDKHHBCBEGJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000048")]
	private bool EHCBJFKFOHN;

	[Cpp2IlInjected.Token(Token = "0x1700009A")]
	public EDLOJEAHDJH<IFCIIPLFOCA> JHBHHMGJABD
	{
		[Cpp2IlInjected.Token(Token = "0x600028D")]
		[Cpp2IlInjected.Address(RVA = "0x8A9F10", Offset = "0x8A9310", VA = "0x1808A9F10", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700009B")]
	public Vector3 LJEFKJLILDI
	{
		[Cpp2IlInjected.Token(Token = "0x600028E")]
		[Cpp2IlInjected.Address(RVA = "0x746ED60", Offset = "0x746E160", VA = "0x18746ED60", Slot = "6")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700009C")]
	public Vector3 HMEFMECHEOB
	{
		[Cpp2IlInjected.Token(Token = "0x600028F")]
		[Cpp2IlInjected.Address(RVA = "0x746F340", Offset = "0x746E740", VA = "0x18746F340", Slot = "7")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700009D")]
	private Vector3 OEJJEAHPBHE
	{
		[Cpp2IlInjected.Token(Token = "0x6000293")]
		[Cpp2IlInjected.Address(RVA = "0x746EEB0", Offset = "0x746E2B0", VA = "0x18746EEB0")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700009E")]
	public IFCIIPLFOCA PLAPFABEBGM
	{
		[Cpp2IlInjected.Token(Token = "0x6000294")]
		[Cpp2IlInjected.Address(RVA = "0x746ED90", Offset = "0x746E190", VA = "0x18746ED90", Slot = "5")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000290")]
	[Cpp2IlInjected.Address(RVA = "0x746F890", Offset = "0x746EC90", VA = "0x18746F890")]
	public PGEALEODADH(IFCIIPLFOCA DODIHPOGMBH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000291")]
	[Cpp2IlInjected.Address(RVA = "0x746EE40", Offset = "0x746E240", VA = "0x18746EE40", Slot = "8")]
	public void EDDFFEFGFPP(IFCIIPLFOCA IIOPLDELPHL, object FDAIGOGAKMH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000292")]
	[Cpp2IlInjected.Address(RVA = "0x746ED00", Offset = "0x746E100", VA = "0x18746ED00", Slot = "9")]
	public void AMAPHGFGPCJ(object FDAIGOGAKMH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000295")]
	[Cpp2IlInjected.Address(RVA = "0x746EFA0", Offset = "0x746E3A0", VA = "0x18746EFA0")]
	private Vector3 IMMBHKIHJMJ()
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000296")]
	[Cpp2IlInjected.Address(RVA = "0x746F500", Offset = "0x746E900", VA = "0x18746F500")]
	private void KOJGJBHKBGB(IFCIIPLFOCA NAHPEANKDPL)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002C")]
internal static class BLHDNOKFCKL
{
	[Cpp2IlInjected.Token(Token = "0x6000297")]
	[Cpp2IlInjected.Address(RVA = "0x745A500", Offset = "0x7459900", VA = "0x18745A500")]
	public static PKDAKDEJBFF FNFHCKCGNMF(this IFCIIPLFOCA GDIPKBJJCBL)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200002D")]
internal sealed class PFINPEPGNEL : FKJIHDDFECN, EHCMCNEDKLA
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400004A")]
	private readonly FKMFAEODDLC DODIHPOGMBH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400004B")]
	private readonly OverridableVector3 DLDHGCMFNCN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400004C")]
	private readonly OverridableVector3 JHHMDEPKMHK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x400004D")]
	private float APCOMMKOIJO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x44")]
	[Cpp2IlInjected.Token(Token = "0x400004E")]
	private float IBAIKJKNOPE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x400004F")]
	private Vector3 NLIINEOEMBH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x54")]
	[Cpp2IlInjected.Token(Token = "0x4000050")]
	private Vector3? KPHEAMINHPD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x64")]
	[Cpp2IlInjected.Token(Token = "0x4000051")]
	private Quaternion? DDJHJPNPPDF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
	[Cpp2IlInjected.Token(Token = "0x4000052")]
	private bool KJAFFFOMHGD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x79")]
	[Cpp2IlInjected.Token(Token = "0x4000053")]
	private bool NDFHONMLAJH;

	[Cpp2IlInjected.Token(Token = "0x1700009F")]
	public Vector3 KOJBKCKDCOM
	{
		[Cpp2IlInjected.Token(Token = "0x600029A")]
		[Cpp2IlInjected.Address(RVA = "0x108CBD0", Offset = "0x108BFD0", VA = "0x18108CBD0", Slot = "7")]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x600029B")]
		[Cpp2IlInjected.Address(RVA = "0x746C5E0", Offset = "0x746B9E0", VA = "0x18746C5E0", Slot = "8")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A0")]
	public Vector3 ADOGIKLOPOE
	{
		[Cpp2IlInjected.Token(Token = "0x600029C")]
		[Cpp2IlInjected.Address(RVA = "0x746E690", Offset = "0x746DA90", VA = "0x18746E690", Slot = "9")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A1")]
	public float PKEBGGMFHGB
	{
		[Cpp2IlInjected.Token(Token = "0x600029D")]
		[Cpp2IlInjected.Address(RVA = "0xB81E50", Offset = "0xB81250", VA = "0x180B81E50", Slot = "10")]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x600029E")]
		[Cpp2IlInjected.Address(RVA = "0x746C910", Offset = "0x746BD10", VA = "0x18746C910")]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A2")]
	public float JACGGPKPOHK
	{
		[Cpp2IlInjected.Token(Token = "0x600029F")]
		[Cpp2IlInjected.Address(RVA = "0xB81E40", Offset = "0xB81240", VA = "0x180B81E40", Slot = "11")]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x60002A0")]
		[Cpp2IlInjected.Address(RVA = "0x746E780", Offset = "0x746DB80", VA = "0x18746E780", Slot = "12")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A3")]
	public Vector3 AGJEOCNFDLJ
	{
		[Cpp2IlInjected.Token(Token = "0x60002A1")]
		[Cpp2IlInjected.Address(RVA = "0x746EA10", Offset = "0x746DE10", VA = "0x18746EA10", Slot = "13")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A4")]
	public Quaternion NKHOHGNBGLO
	{
		[Cpp2IlInjected.Token(Token = "0x60002A2")]
		[Cpp2IlInjected.Address(RVA = "0x746DB30", Offset = "0x746CF30", VA = "0x18746DB30", Slot = "14")]
		get
		{
			return default(Quaternion);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A5")]
	private Rigidbody CFDDIFJHEKO
	{
		[Cpp2IlInjected.Token(Token = "0x60002AA")]
		[Cpp2IlInjected.Address(RVA = "0x745E480", Offset = "0x745D880", VA = "0x18745E480")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400002A")]
	public event NAKAIBCOGCG KDIGJAFGOED
	{
		[Cpp2IlInjected.Token(Token = "0x6000298")]
		[Cpp2IlInjected.Address(RVA = "0x746E220", Offset = "0x746D620", VA = "0x18746E220", Slot = "5")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000299")]
		[Cpp2IlInjected.Address(RVA = "0x746E2C0", Offset = "0x746D6C0", VA = "0x18746E2C0", Slot = "6")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60002A3")]
	[Cpp2IlInjected.Address(RVA = "0x746EBA0", Offset = "0x746DFA0", VA = "0x18746EBA0")]
	public PFINPEPGNEL(IFCIIPLFOCA DODIHPOGMBH, [In] KDAAIDJOOBC MPMEGOKIEPF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002A4")]
	[Cpp2IlInjected.Address(RVA = "0x746D980", Offset = "0x746CD80", VA = "0x18746D980", Slot = "17")]
	public void EAKOJKGNPNH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002A5")]
	[Cpp2IlInjected.Address(RVA = "0x746E140", Offset = "0x746D540", VA = "0x18746E140", Slot = "16")]
	public void GLPGBCBEBAK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002A6")]
	[Cpp2IlInjected.Address(RVA = "0x746C690", Offset = "0x746BA90", VA = "0x18746C690", Slot = "19")]
	public void BLEFDCFMIJN(Rigidbody GJHIIOHAAJN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002A7")]
	[Cpp2IlInjected.Address(RVA = "0x746E830", Offset = "0x746DC30", VA = "0x18746E830", Slot = "20")]
	public void NMLKFMMMKPL(Rigidbody GJHIIOHAAJN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002A8")]
	[Cpp2IlInjected.Address(RVA = "0x746E360", Offset = "0x746D760", VA = "0x18746E360", Slot = "18")]
	public void IGOIGPBJBLN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002A9")]
	[Cpp2IlInjected.Address(RVA = "0x746DCB0", Offset = "0x746D0B0", VA = "0x18746DCB0", Slot = "21")]
	public void FHIJIPKLAKG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002AB")]
	[Cpp2IlInjected.Address(RVA = "0x746C5E0", Offset = "0x746B9E0", VA = "0x18746C5E0")]
	private void KNNCGPAPKCC(Vector3 LIHHDPOHLDK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002AC")]
	[Cpp2IlInjected.Address(RVA = "0x746CA20", Offset = "0x746BE20", VA = "0x18746CA20")]
	[Obsolete("This method is dangerous - the unity rigidbody is updated in a deferred manner and this world position may be stale")]
	private Vector3 DEIMOBFEBBE()
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x60002AD")]
	[Cpp2IlInjected.Address(RVA = "0x746C910", Offset = "0x746BD10", VA = "0x18746C910")]
	private void NAODFCKIFKK(float LIHHDPOHLDK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002AE")]
	[Cpp2IlInjected.Address(RVA = "0x746E780", Offset = "0x746DB80", VA = "0x18746E780")]
	private void MCDDCPPJAJL(float LIHHDPOHLDK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002AF")]
	[Cpp2IlInjected.Address(RVA = "0x746C770", Offset = "0x746BB70", VA = "0x18746C770")]
	private Vector3 BOMOKBHJCFE()
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x60002B0")]
	[Cpp2IlInjected.Address(RVA = "0x746C3B0", Offset = "0x746B7B0", VA = "0x18746C3B0", Slot = "15")]
	public void BDFAMNPGEOK((Quaternion rot, Vector3 moments) FHCHCEFKJNC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002B1")]
	[Cpp2IlInjected.Address(RVA = "0x746E510", Offset = "0x746D910", VA = "0x18746E510")]
	private Quaternion JJOJFAKKPMF()
	{
		return default(Quaternion);
	}

	[Cpp2IlInjected.Token(Token = "0x60002B2")]
	[Cpp2IlInjected.Address(RVA = "0x746D8B0", Offset = "0x746CCB0", VA = "0x18746D8B0")]
	public void DHLNGHDDEPJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002B3")]
	[Cpp2IlInjected.Address(RVA = "0x746CB10", Offset = "0x746BF10", VA = "0x18746CB10", Slot = "4")]
	public (float, Vector3) DHLNGHDDEPJ(Rigidbody CPIILEDGANK)
	{
		return default((float, Vector3));
	}
}
[Cpp2IlInjected.Token(Token = "0x200002E")]
internal static class MMFCHLMMDLJ
{
	[Cpp2IlInjected.Token(Token = "0x60002B4")]
	[Cpp2IlInjected.Address(RVA = "0x74685D0", Offset = "0x74679D0", VA = "0x1874685D0")]
	public static FKJIHDDFECN MIBDNBPIOHN(this IFCIIPLFOCA GDIPKBJJCBL)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200002F")]
internal sealed class CKOFMPOLLIK : CJNBDDJPPFL
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000054")]
	private readonly FKMFAEODDLC DODIHPOGMBH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000055")]
	private readonly BLJEMJOJOGI DKIANILLGHE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000056")]
	private readonly JKBHAFMADLE GELMBKBNOMH;

	[Cpp2IlInjected.Token(Token = "0x170000A6")]
	public bool LJNKIFKAHAK
	{
		[Cpp2IlInjected.Token(Token = "0x60002B5")]
		[Cpp2IlInjected.Address(RVA = "0x1228B20", Offset = "0x1227F20", VA = "0x181228B20", Slot = "10")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A7")]
	public JKBHAFMADLE DBCMAKMNNKD
	{
		[Cpp2IlInjected.Token(Token = "0x60002B6")]
		[Cpp2IlInjected.Address(RVA = "0x952F70", Offset = "0x952370", VA = "0x180952F70", Slot = "11")]
		get
		{
			return default(JKBHAFMADLE);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60002B7")]
	[Cpp2IlInjected.Address(RVA = "0x745CF10", Offset = "0x745C310", VA = "0x18745CF10")]
	public CKOFMPOLLIK(IFCIIPLFOCA DODIHPOGMBH, [In] KDAAIDJOOBC MPMEGOKIEPF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002B8")]
	[Cpp2IlInjected.Address(RVA = "0x745CB90", Offset = "0x745BF90", VA = "0x18745CB90", Slot = "4")]
	public void JBLDGJLDMEF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002B9")]
	[Cpp2IlInjected.Address(RVA = "0x745C970", Offset = "0x745BD70", VA = "0x18745C970")]
	private bool FMKOAMNMKOM()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002BA")]
	[Cpp2IlInjected.Address(RVA = "0x745CDB0", Offset = "0x745C1B0", VA = "0x18745CDB0", Slot = "5")]
	public void NEELPFHOPGA(object FDAIGOGAKMH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002BB")]
	[Cpp2IlInjected.Address(RVA = "0x745C900", Offset = "0x745BD00", VA = "0x18745C900", Slot = "6")]
	public void AMMODAKCNKO(object FDAIGOGAKMH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002BC")]
	[Cpp2IlInjected.Address(RVA = "0x745CDE0", Offset = "0x745C1E0", VA = "0x18745CDE0", Slot = "9")]
	public void OMGIAIPKGHE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002BD")]
	[Cpp2IlInjected.Address(RVA = "0x745CCA0", Offset = "0x745C0A0", VA = "0x18745CCA0")]
	private void NCDDMEAMEAH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002BE")]
	[Cpp2IlInjected.Address(RVA = "0x745CA10", Offset = "0x745BE10", VA = "0x18745CA10")]
	private void IBKBMEMOAOJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002BF")]
	[Cpp2IlInjected.Address(RVA = "0x745CC60", Offset = "0x745C060", VA = "0x18745CC60", Slot = "8")]
	public void KKFJNIBFFEB(IFCIIPLFOCA DODIHPOGMBH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002C0")]
	[Cpp2IlInjected.Address(RVA = "0x745C930", Offset = "0x745BD30", VA = "0x18745C930", Slot = "7")]
	public void FHIAEOEOEBJ(IFCIIPLFOCA DODIHPOGMBH)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000030")]
internal sealed class IHNIPKCCAFA : APAEMPIJCMB
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000058")]
	private readonly FKMFAEODDLC DODIHPOGMBH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000059")]
	private readonly BLJEMJOJOGI DNEHPMJDJLP;

	[Cpp2IlInjected.Token(Token = "0x170000A8")]
	public bool DBMGBKHLGGG
	{
		[Cpp2IlInjected.Token(Token = "0x60002C3")]
		[Cpp2IlInjected.Address(RVA = "0x74678A0", Offset = "0x7466CA0", VA = "0x1874678A0", Slot = "6")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400002B")]
	public event NAKAIBCOGCG HBPOHBEMCJE
	{
		[Cpp2IlInjected.Token(Token = "0x60002C1")]
		[Cpp2IlInjected.Address(RVA = "0x7467800", Offset = "0x7466C00", VA = "0x187467800", Slot = "4")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60002C2")]
		[Cpp2IlInjected.Address(RVA = "0x7467950", Offset = "0x7466D50", VA = "0x187467950", Slot = "5")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60002C4")]
	[Cpp2IlInjected.Address(RVA = "0x7467A30", Offset = "0x7466E30", VA = "0x187467A30")]
	public IHNIPKCCAFA(IFCIIPLFOCA DODIHPOGMBH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002C5")]
	[Cpp2IlInjected.Address(RVA = "0x74679F0", Offset = "0x7466DF0", VA = "0x1874679F0", Slot = "7")]
	public void NCOOPPCENCG(object FDAIGOGAKMH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002C6")]
	[Cpp2IlInjected.Address(RVA = "0x74676E0", Offset = "0x7466AE0", VA = "0x1874676E0", Slot = "8")]
	public void GNNECMKMACC(object FDAIGOGAKMH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002C7")]
	[Cpp2IlInjected.Address(RVA = "0x74676F0", Offset = "0x7466AF0", VA = "0x1874676F0", Slot = "9")]
	public void JKCFLPNEIDO(object FDAIGOGAKMH, bool ONDEKDBNJLL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002C8")]
	[Cpp2IlInjected.Address(RVA = "0x74676A0", Offset = "0x7466AA0", VA = "0x1874676A0", Slot = "12")]
	public void GCOIOGILKMP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002C9")]
	[Cpp2IlInjected.Address(RVA = "0x7467620", Offset = "0x7466A20", VA = "0x187467620", Slot = "10")]
	public void BLEFDCFMIJN(Rigidbody AMNBHPNNAMP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002CA")]
	[Cpp2IlInjected.Address(RVA = "0x7467A00", Offset = "0x7466E00", VA = "0x187467A00", Slot = "11")]
	public void NMLKFMMMKPL(Rigidbody GJHIIOHAAJN)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000031")]
internal sealed class CPHCLIFEDFK : NDPNKMNENHG, FNCIFHKHEPA, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400005B")]
	private readonly FKMFAEODDLC DODIHPOGMBH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400005C")]
	private PhotonView DGMAGOKPCJG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400005D")]
	private bool IAGMLHNIPBB;

	[Cpp2IlInjected.Token(Token = "0x170000A9")]
	public PhotonView NJAJDNJCFPE
	{
		[Cpp2IlInjected.Token(Token = "0x60002CD")]
		[Cpp2IlInjected.Address(RVA = "0x8AA330", Offset = "0x8A9730", VA = "0x1808AA330", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000AA")]
	public bool FCDOJOKBAME
	{
		[Cpp2IlInjected.Token(Token = "0x60002CE")]
		[Cpp2IlInjected.Address(RVA = "0x745D180", Offset = "0x745C580", VA = "0x18745D180", Slot = "7")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000AB")]
	public bool LFAFJEIDHAH
	{
		[Cpp2IlInjected.Token(Token = "0x60002CF")]
		[Cpp2IlInjected.Address(RVA = "0x982980", Offset = "0x981D80", VA = "0x180982980", Slot = "8")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400002C")]
	public event NAKAIBCOGCG HNJMPMFKHDK
	{
		[Cpp2IlInjected.Token(Token = "0x60002CB")]
		[Cpp2IlInjected.Address(RVA = "0x745DB10", Offset = "0x745CF10", VA = "0x18745DB10", Slot = "5")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60002CC")]
		[Cpp2IlInjected.Address(RVA = "0x745D2A0", Offset = "0x745C6A0", VA = "0x18745D2A0", Slot = "6")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60002D0")]
	[Cpp2IlInjected.Address(RVA = "0x745DBB0", Offset = "0x745CFB0", VA = "0x18745DBB0")]
	public CPHCLIFEDFK(IFCIIPLFOCA DODIHPOGMBH, [In] KDAAIDJOOBC MPMEGOKIEPF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002D1")]
	[Cpp2IlInjected.Address(RVA = "0x745D870", Offset = "0x745CC70", VA = "0x18745D870", Slot = "9")]
	public void JBLDGJLDMEF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002D2")]
	[Cpp2IlInjected.Address(RVA = "0x745D1A0", Offset = "0x745C5A0", VA = "0x18745D1A0", Slot = "12")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002D3")]
	[Cpp2IlInjected.Address(RVA = "0x745D010", Offset = "0x745C410", VA = "0x18745D010", Slot = "10")]
	public void BDDHKFOMOLP(IFCIIPLFOCA IIOPLDELPHL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002D4")]
	[Cpp2IlInjected.Address(RVA = "0x745D340", Offset = "0x745C740", VA = "0x18745D340", Slot = "11")]
	public void FCGLPJAFLJE(IFCIIPLFOCA IIOPLDELPHL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002D5")]
	[Cpp2IlInjected.Address(RVA = "0x745D9A0", Offset = "0x745CDA0", VA = "0x18745D9A0")]
	private void KBPNLKOPCJF(PhotonView FKPGACGGNFJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002D6")]
	[Cpp2IlInjected.Address(RVA = "0x745D720", Offset = "0x745CB20", VA = "0x18745D720")]
	private void GOFBCLCKOPE(NADAIAGKPNF OAGAGFAJLLP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002D7")]
	[Cpp2IlInjected.Address(RVA = "0x745D4B0", Offset = "0x745C8B0", VA = "0x18745D4B0")]
	private void GIKHECMPNMD(PhotonView MPKLAPEOJOK)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000032")]
internal static class KIHFNAGOCDB
{
	[Cpp2IlInjected.Token(Token = "0x60002D8")]
	[Cpp2IlInjected.Address(RVA = "0x7468440", Offset = "0x7467840", VA = "0x187468440")]
	public static NDPNKMNENHG AOBLOEGIPNF(this IFCIIPLFOCA GDIPKBJJCBL)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000033")]
internal sealed class CKHBPEIHGJO : NPPMLEINIBM
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400005E")]
	private readonly FKMFAEODDLC DODIHPOGMBH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400005F")]
	private RigidbodyConstraints ANBNDKFDKOP;

	[Cpp2IlInjected.Token(Token = "0x170000AC")]
	public bool LHMAAJBCAPO
	{
		[Cpp2IlInjected.Token(Token = "0x60002D9")]
		[Cpp2IlInjected.Address(RVA = "0x939550", Offset = "0x938950", VA = "0x180939550", Slot = "4")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x60002DA")]
		[Cpp2IlInjected.Address(RVA = "0x4888D40", Offset = "0x4888140", VA = "0x184888D40", Slot = "5")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000AD")]
	public bool AIDGFLJIEHK
	{
		[Cpp2IlInjected.Token(Token = "0x60002DB")]
		[Cpp2IlInjected.Address(RVA = "0xB81DF0", Offset = "0xB811F0", VA = "0x180B81DF0", Slot = "6")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x60002DC")]
		[Cpp2IlInjected.Address(RVA = "0x4888D30", Offset = "0x4888130", VA = "0x184888D30")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000AE")]
	public RigidbodyConstraints CAEDCEJJOFG
	{
		[Cpp2IlInjected.Token(Token = "0x60002DD")]
		[Cpp2IlInjected.Address(RVA = "0x8AE510", Offset = "0x8AD910", VA = "0x1808AE510", Slot = "7")]
		get
		{
			return default(RigidbodyConstraints);
		}
		[Cpp2IlInjected.Token(Token = "0x60002DE")]
		[Cpp2IlInjected.Address(RVA = "0x745C6F0", Offset = "0x745BAF0", VA = "0x18745C6F0", Slot = "8")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60002DF")]
	[Cpp2IlInjected.Address(RVA = "0x745C850", Offset = "0x745BC50", VA = "0x18745C850")]
	public CKHBPEIHGJO(IFCIIPLFOCA DODIHPOGMBH, [In] KDAAIDJOOBC MPMEGOKIEPF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002E0")]
	[Cpp2IlInjected.Address(RVA = "0x745C6C0", Offset = "0x745BAC0", VA = "0x18745C6C0", Slot = "9")]
	public void BLEFDCFMIJN(Rigidbody GJHIIOHAAJN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002E1")]
	[Cpp2IlInjected.Address(RVA = "0x745C820", Offset = "0x745BC20", VA = "0x18745C820", Slot = "10")]
	public void NMLKFMMMKPL(Rigidbody GJHIIOHAAJN)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000034")]
internal sealed class DAPPFMONACI : NAONIBBKJJC
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000062")]
	private readonly IFCIIPLFOCA DODIHPOGMBH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000063")]
	private float BGEJOOEAEGP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
	[Cpp2IlInjected.Token(Token = "0x4000064")]
	private float KFCIMOFFMKG;

	[Cpp2IlInjected.Token(Token = "0x170000AF")]
	public float IKAGHIPEEBN
	{
		[Cpp2IlInjected.Token(Token = "0x60002E3")]
		[Cpp2IlInjected.Address(RVA = "0xA7A1B0", Offset = "0xA795B0", VA = "0x180A7A1B0", Slot = "4")]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x60002E4")]
		[Cpp2IlInjected.Address(RVA = "0x745E980", Offset = "0x745DD80", VA = "0x18745E980", Slot = "5")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B0")]
	public float KGMBLHLCENB
	{
		[Cpp2IlInjected.Token(Token = "0x60002E5")]
		[Cpp2IlInjected.Address(RVA = "0xBBF830", Offset = "0xBBEC30", VA = "0x180BBF830", Slot = "6")]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x60002E6")]
		[Cpp2IlInjected.Address(RVA = "0x745E8B0", Offset = "0x745DCB0", VA = "0x18745E8B0", Slot = "7")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60002E2")]
	[Cpp2IlInjected.Address(RVA = "0x745EAF0", Offset = "0x745DEF0", VA = "0x18745EAF0")]
	public DAPPFMONACI(IFCIIPLFOCA DODIHPOGMBH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002E7")]
	[Cpp2IlInjected.Address(RVA = "0x745E860", Offset = "0x745DC60", VA = "0x18745E860", Slot = "8")]
	public void BLEFDCFMIJN(Rigidbody GJHIIOHAAJN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002E8")]
	[Cpp2IlInjected.Address(RVA = "0x745EA50", Offset = "0x745DE50", VA = "0x18745EA50", Slot = "9")]
	public void NMLKFMMMKPL(Rigidbody GJHIIOHAAJN)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000035")]
internal sealed class CPHOMMDAKNL : BMLKALHMELK
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000066")]
	private readonly FKMFAEODDLC DODIHPOGMBH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000067")]
	private bool MBBEMLGGBON;

	[Cpp2IlInjected.FieldOffset(Offset = "0x21")]
	[Cpp2IlInjected.Token(Token = "0x4000068")]
	private bool NOAKMHMAIBG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
	[Cpp2IlInjected.Token(Token = "0x4000069")]
	private int JJFHGHDBJLF;

	[Cpp2IlInjected.Token(Token = "0x170000B1")]
	private Rigidbody CFDDIFJHEKO
	{
		[Cpp2IlInjected.Token(Token = "0x60002EB")]
		[Cpp2IlInjected.Address(RVA = "0x745E480", Offset = "0x745D880", VA = "0x18745E480")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B2")]
	private bool OPKBCEDKDNC
	{
		[Cpp2IlInjected.Token(Token = "0x60002EC")]
		[Cpp2IlInjected.Address(RVA = "0x745E5D0", Offset = "0x745D9D0", VA = "0x18745E5D0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B3")]
	private IFCIIPLFOCA DIEIKKLOHIA
	{
		[Cpp2IlInjected.Token(Token = "0x60002ED")]
		[Cpp2IlInjected.Address(RVA = "0x745E4D0", Offset = "0x745D8D0", VA = "0x18745E4D0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B4")]
	private bool JIJHHIKHFHH
	{
		[Cpp2IlInjected.Token(Token = "0x60002EE")]
		[Cpp2IlInjected.Address(RVA = "0x745E1D0", Offset = "0x745D5D0", VA = "0x18745E1D0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400002D")]
	public event NAKAIBCOGCG PFLKFCKJCJF
	{
		[Cpp2IlInjected.Token(Token = "0x60002E9")]
		[Cpp2IlInjected.Address(RVA = "0x745DD10", Offset = "0x745D110", VA = "0x18745DD10", Slot = "4")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60002EA")]
		[Cpp2IlInjected.Address(RVA = "0x745DF00", Offset = "0x745D300", VA = "0x18745DF00", Slot = "5")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60002EF")]
	[Cpp2IlInjected.Address(RVA = "0x745E7D0", Offset = "0x745DBD0", VA = "0x18745E7D0")]
	public CPHOMMDAKNL(IFCIIPLFOCA DODIHPOGMBH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002F0")]
	[Cpp2IlInjected.Address(RVA = "0x745E3F0", Offset = "0x745D7F0", VA = "0x18745E3F0", Slot = "6")]
	public void JBLDGJLDMEF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002F1")]
	[Cpp2IlInjected.Address(RVA = "0x745E230", Offset = "0x745D630", VA = "0x18745E230", Slot = "8")]
	public void GIJMAKELMMM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002F2")]
	[Cpp2IlInjected.Address(RVA = "0x745DDB0", Offset = "0x745D1B0", VA = "0x18745DDB0", Slot = "7")]
	public bool BIGMGDJCGKO()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002F3")]
	[Cpp2IlInjected.Address(RVA = "0x745E530", Offset = "0x745D930", VA = "0x18745E530", Slot = "9")]
	public void MAJHCNGPJBC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002F4")]
	[Cpp2IlInjected.Address(RVA = "0x745DFA0", Offset = "0x745D3A0", VA = "0x18745DFA0", Slot = "11")]
	public void DCLBODONNLA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002F5")]
	[Cpp2IlInjected.Address(RVA = "0x745E240", Offset = "0x745D640", VA = "0x18745E240", Slot = "10")]
	public void HNPAAENDJDK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002F6")]
	[Cpp2IlInjected.Address(RVA = "0x745E5F0", Offset = "0x745D9F0", VA = "0x18745E5F0")]
	private bool PGLFONMOILP()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002F7")]
	[Cpp2IlInjected.Address(RVA = "0x745E040", Offset = "0x745D440", VA = "0x18745E040")]
	private void EAMBLFIAEDN()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000036")]
internal sealed class DNJANPPHCDD : LIOKBCGOPHC
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400006A")]
	private readonly FKMFAEODDLC DODIHPOGMBH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400006B")]
	private readonly BLJEMJOJOGI EIOELMEKEIF;

	[Cpp2IlInjected.Token(Token = "0x170000B5")]
	public Rigidbody CFDDIFJHEKO
	{
		[Cpp2IlInjected.Token(Token = "0x60002F8")]
		[Cpp2IlInjected.Address(RVA = "0x8AA330", Offset = "0x8A9730", VA = "0x1808AA330", Slot = "4")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60002F9")]
		[Cpp2IlInjected.Address(RVA = "0x8AA350", Offset = "0x8A9750", VA = "0x1808AA350")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B6")]
	private bool JIJHHIKHFHH
	{
		[Cpp2IlInjected.Token(Token = "0x60002FA")]
		[Cpp2IlInjected.Address(RVA = "0x745ED50", Offset = "0x745E150", VA = "0x18745ED50")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B7")]
	public bool EEFBODKLIOD
	{
		[Cpp2IlInjected.Token(Token = "0x60002FD")]
		[Cpp2IlInjected.Address(RVA = "0x1228B20", Offset = "0x1227F20", VA = "0x181228B20", Slot = "6")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60002FB")]
	[Cpp2IlInjected.Address(RVA = "0x745F330", Offset = "0x745E730", VA = "0x18745F330")]
	public DNJANPPHCDD(IFCIIPLFOCA DODIHPOGMBH, [In] KDAAIDJOOBC MPMEGOKIEPF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002FC")]
	[Cpp2IlInjected.Address(RVA = "0x745EDB0", Offset = "0x745E1B0", VA = "0x18745EDB0", Slot = "5")]
	public void JBLDGJLDMEF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002FE")]
	[Cpp2IlInjected.Address(RVA = "0x745ED20", Offset = "0x745E120", VA = "0x18745ED20", Slot = "7")]
	public void FFOFEFGFLKG(object FDAIGOGAKMH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002FF")]
	[Cpp2IlInjected.Address(RVA = "0x745EE50", Offset = "0x745E250", VA = "0x18745EE50", Slot = "8")]
	public void OEMBIKBABCD(object FDAIGOGAKMH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000300")]
	[Cpp2IlInjected.Address(RVA = "0x745EE80", Offset = "0x745E280", VA = "0x18745EE80", Slot = "9")]
	public void PBANNELBKIE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000301")]
	[Cpp2IlInjected.Address(RVA = "0x745EB30", Offset = "0x745DF30", VA = "0x18745EB30", Slot = "10")]
	public void FDAODPAIPLG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000302")]
	[Cpp2IlInjected.Address(RVA = "0x745F1B0", Offset = "0x745E5B0", VA = "0x18745F1B0", Slot = "11")]
	public void PBOMHDAPPJO()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000037")]
internal sealed class PBMJDNCFOMM : MHEKBCJDIFI, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400006D")]
	private readonly FKMFAEODDLC DODIHPOGMBH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400006E")]
	private readonly BLJEMJOJOGI CKBGEPMBPAK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400006F")]
	private float EIBFMEAJEBJ;

	[Cpp2IlInjected.Token(Token = "0x170000B8")]
	public KKMOFMFLGOJ JKDOEOFLFNE
	{
		[Cpp2IlInjected.Token(Token = "0x6000303")]
		[Cpp2IlInjected.Address(RVA = "0x8AA340", Offset = "0x8A9740", VA = "0x1808AA340", Slot = "4")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000304")]
		[Cpp2IlInjected.Address(RVA = "0x8A9F60", Offset = "0x8A9360", VA = "0x1808A9F60", Slot = "5")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B9")]
	public LPNGIGIDBDB NENIHDOJFOO
	{
		[Cpp2IlInjected.Token(Token = "0x6000305")]
		[Cpp2IlInjected.Address(RVA = "0x8AE500", Offset = "0x8AD900", VA = "0x1808AE500", Slot = "6")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000306")]
		[Cpp2IlInjected.Address(RVA = "0x8AE4F0", Offset = "0x8AD8F0", VA = "0x1808AE4F0", Slot = "7")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000BA")]
	public Vector3 OEJJEAHPBHE
	{
		[Cpp2IlInjected.Token(Token = "0x6000307")]
		[Cpp2IlInjected.Address(RVA = "0x7469760", Offset = "0x7468B60", VA = "0x187469760", Slot = "8")]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x6000308")]
		[Cpp2IlInjected.Address(RVA = "0x7469190", Offset = "0x7468590", VA = "0x187469190", Slot = "9")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000BB")]
	public Vector3 MIAFPIJOAPP
	{
		[Cpp2IlInjected.Token(Token = "0x6000309")]
		[Cpp2IlInjected.Address(RVA = "0x746A9C0", Offset = "0x7469DC0", VA = "0x18746A9C0", Slot = "10")]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x600030A")]
		[Cpp2IlInjected.Address(RVA = "0x7469730", Offset = "0x7468B30", VA = "0x187469730", Slot = "11")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000BC")]
	public Vector3 BAKJLLNDMGH
	{
		[Cpp2IlInjected.Token(Token = "0x600030B")]
		[Cpp2IlInjected.Address(RVA = "0x7469520", Offset = "0x7468920", VA = "0x187469520", Slot = "12")]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x600030C")]
		[Cpp2IlInjected.Address(RVA = "0x7469460", Offset = "0x7468860", VA = "0x187469460", Slot = "13")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000BD")]
	public Vector3 AMPOKOPEKFE
	{
		[Cpp2IlInjected.Token(Token = "0x600030D")]
		[Cpp2IlInjected.Address(RVA = "0x7469AD0", Offset = "0x7468ED0", VA = "0x187469AD0", Slot = "14")]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x600030E")]
		[Cpp2IlInjected.Address(RVA = "0x746A870", Offset = "0x7469C70", VA = "0x18746A870", Slot = "15")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000BE")]
	public float GLHFEEBAFIJ
	{
		[Cpp2IlInjected.Token(Token = "0x600030F")]
		[Cpp2IlInjected.Address(RVA = "0xB81E60", Offset = "0xB81260", VA = "0x180B81E60", Slot = "16")]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x6000310")]
		[Cpp2IlInjected.Address(RVA = "0x746A110", Offset = "0x7469510", VA = "0x18746A110", Slot = "17")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000BF")]
	public bool JLDMJGGIEPO
	{
		[Cpp2IlInjected.Token(Token = "0x6000311")]
		[Cpp2IlInjected.Address(RVA = "0x1B933E0", Offset = "0x1B927E0", VA = "0x181B933E0", Slot = "18")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000C0")]
	private NLEBPALKPEF CBICFGJPNMK
	{
		[Cpp2IlInjected.Token(Token = "0x6000326")]
		[Cpp2IlInjected.Address(RVA = "0x6C4C8B0", Offset = "0x6C4BCB0", VA = "0x186C4C8B0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000C1")]
	private bool OPKBCEDKDNC
	{
		[Cpp2IlInjected.Token(Token = "0x6000327")]
		[Cpp2IlInjected.Address(RVA = "0x746BC70", Offset = "0x746B070", VA = "0x18746BC70")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000312")]
	[Cpp2IlInjected.Address(RVA = "0x746C2C0", Offset = "0x746B6C0", VA = "0x18746C2C0")]
	public PBMJDNCFOMM(IFCIIPLFOCA DODIHPOGMBH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000313")]
	[Cpp2IlInjected.Address(RVA = "0x746A070", Offset = "0x7469470", VA = "0x18746A070", Slot = "19")]
	public void JBLDGJLDMEF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000314")]
	[Cpp2IlInjected.Address(RVA = "0x74696D0", Offset = "0x7468AD0", VA = "0x1874696D0", Slot = "36")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000315")]
	[Cpp2IlInjected.Address(RVA = "0x7469330", Offset = "0x7468730", VA = "0x187469330", Slot = "28")]
	public void BLEFDCFMIJN(Rigidbody GJHIIOHAAJN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000316")]
	[Cpp2IlInjected.Address(RVA = "0x10517A0", Offset = "0x1050BA0", VA = "0x1810517A0", Slot = "20")]
	public void BCLKDGMKLLK(object FDAIGOGAKMH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000317")]
	[Cpp2IlInjected.Address(RVA = "0x10515F0", Offset = "0x10509F0", VA = "0x1810515F0", Slot = "30")]
	public void DNJLEHGDFPN(object FDAIGOGAKMH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000318")]
	[Cpp2IlInjected.Address(RVA = "0x746B750", Offset = "0x746AB50", VA = "0x18746B750", Slot = "35")]
	public Vector3 LKAMGHHKPOF(Vector3 EBLBHKKBIIJ)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000319")]
	[Cpp2IlInjected.Address(RVA = "0x7469910", Offset = "0x7468D10", VA = "0x187469910", Slot = "34")]
	public Vector3 GAJLJHAODIA(Vector3 BPCNDMDPEND)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x600031A")]
	[Cpp2IlInjected.Address(RVA = "0x746A070", Offset = "0x7469470", VA = "0x18746A070", Slot = "27")]
	public void PPBMOAJIDKC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600031B")]
	[Cpp2IlInjected.Address(RVA = "0x7469670", Offset = "0x7468A70", VA = "0x187469670", Slot = "25")]
	public void CEALOANFKBH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600031C")]
	[Cpp2IlInjected.Address(RVA = "0x746BFC0", Offset = "0x746B3C0", VA = "0x18746BFC0", Slot = "24")]
	public void NNMPGFKCLEC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600031D")]
	[Cpp2IlInjected.Address(RVA = "0x746AAE0", Offset = "0x7469EE0", VA = "0x18746AAE0", Slot = "33")]
	public void LABDHLMFMLI(Vector3 GOFDGAKBMGI, Vector3 FCECEIAJGMC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600031E")]
	[Cpp2IlInjected.Address(RVA = "0x74698B0", Offset = "0x7468CB0", VA = "0x1874698B0", Slot = "32")]
	public void FAPJHKNNAPN(Vector3 KELAFHBGMAO, Vector3 EDLBDGENHAA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600031F")]
	[Cpp2IlInjected.Address(RVA = "0x746BAD0", Offset = "0x746AED0", VA = "0x18746BAD0", Slot = "31")]
	public void MJFCOFBOIIN(Vector3 JEGDENCLKDF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000320")]
	[Cpp2IlInjected.Address(RVA = "0x746A220", Offset = "0x7469620", VA = "0x18746A220", Slot = "22")]
	public void JJGCADCFNDB(IIKHDPMFHDE BAPJDEHMLHH, Vector3 MNDBPOBDCNJ, float BFAPEHFPHCD, float NBNFHECNAHB = 8f, float INCOBGEGFMH = 1f)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000321")]
	[Cpp2IlInjected.Address(RVA = "0x746BD40", Offset = "0x746B140", VA = "0x18746BD40", Slot = "21")]
	public void NNJFGFGOMEF(CNPLNPFECCE JHMJLILENAP, Vector3 OKNBNOENDPK, float BMCEHNOGEJG = float.PositiveInfinity)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000322")]
	[Cpp2IlInjected.Address(RVA = "0x7469BF0", Offset = "0x7468FF0", VA = "0x187469BF0", Slot = "23")]
	[Obsolete("Deprecated. Still exists to support deprecated CV2 chips. Use ApplyAngularVelocityChange.")]
	public void IFPOABMPLJP(CNPLNPFECCE JHMJLILENAP, Vector3 EFFHGIJAIIE, float BJOPNKBDJGB = 7f, float IPFBOIJJMOB = 1f)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000323")]
	[Cpp2IlInjected.Address(RVA = "0x113FD70", Offset = "0x113F170", VA = "0x18113FD70")]
	private static void FPKJDJKGMGI(Vector3 NBBOFJMDBHM, Vector3 JNKEFPKOLCG, [Out] Vector3 JPJJAHGCMEC, [Out] Vector3 NJADDMLNNKK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000324")]
	[Cpp2IlInjected.Address(RVA = "0x7469250", Offset = "0x7468650", VA = "0x187469250", Slot = "29")]
	public Vector3 BDFCCMMIAAO(Vector3 NBBOFJMDBHM)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000325")]
	[Cpp2IlInjected.Address(RVA = "0x746C130", Offset = "0x746B530", VA = "0x18746C130", Slot = "26")]
	public void ONIAFGKNHNP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000328")]
	[Cpp2IlInjected.Address(RVA = "0x746A110", Offset = "0x7469510", VA = "0x18746A110")]
	private void MBOPPNGDKJL(float LIHHDPOHLDK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000329")]
	[Cpp2IlInjected.Address(RVA = "0x746B930", Offset = "0x746AD30", VA = "0x18746B930")]
	private void LPLNCHFBIHF(Vector3 OKNBNOENDPK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600032A")]
	[Cpp2IlInjected.Address(RVA = "0x746C020", Offset = "0x746B420", VA = "0x18746C020")]
	private Vector3 OELOHJNKNJN()
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x600032B")]
	[Cpp2IlInjected.Address(RVA = "0x7468D10", Offset = "0x7468110", VA = "0x187468D10")]
	private void AIOGGLBGEIF(Vector3 BPCNDMDPEND)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600032C")]
	[Cpp2IlInjected.Address(RVA = "0x746A8A0", Offset = "0x7469CA0", VA = "0x18746A8A0")]
	private Vector3 KAMLPICJAPD()
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x600032D")]
	[Cpp2IlInjected.Address(RVA = "0x746B2D0", Offset = "0x746A6D0", VA = "0x18746B2D0")]
	private void LILIKKKPFCD(Vector3 LIHHDPOHLDK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600032E")]
	[Cpp2IlInjected.Address(RVA = "0x746AD20", Offset = "0x746A120", VA = "0x18746AD20")]
	private void LCJPGGFHMNP(Vector3 BPCNDMDPEND)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600032F")]
	[Cpp2IlInjected.Address(RVA = "0x746BC90", Offset = "0x746B090", VA = "0x18746BC90")]
	private void NIMEDNFNPAG()
	{
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
