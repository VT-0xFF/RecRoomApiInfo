using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Cpp2IlInjected;
using Photon.Pun;
using RecRoom;
using RecRoom.CodeGen.Attributes;
using RecRoom.Utils.OverridableFields;
using Unity.Mathematics;
using UnityEngine;
using UnityEngine.Scripting;
using UnityEngine.Serialization;

[assembly: AssemblyVersion("0.0.0.0")]
[Cpp2IlInjected.Token(Token = "0x2000002")]
public delegate void EBFBHNJDFMO(RigidbodyEx FCJLHJKHGFA);
[Cpp2IlInjected.Token(Token = "0x2000003")]
public delegate void GHEEFDJOPPC(RigidbodyEx FCJLHJKHGFA, bool CGKOADMHFLC = false);
[Cpp2IlInjected.Token(Token = "0x2000004")]
public enum BPNODJIJBLA
{
	[Cpp2IlInjected.Token(Token = "0x4000002")]
	Additive,
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	Override,
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	Reflective,
	[Cpp2IlInjected.Token(Token = "0x4000005")]
	FullOverride
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public enum JCKLAKCMHFC
{
	[Cpp2IlInjected.Token(Token = "0x4000007")]
	OnlyForReducedPhysicsRateAndNotParenting,
	[Cpp2IlInjected.Token(Token = "0x4000008")]
	Never,
	[Cpp2IlInjected.Token(Token = "0x4000009")]
	OnEvenWhenParenting
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public enum LJGOMBGDPDM
{
	[Cpp2IlInjected.Token(Token = "0x400000B")]
	Additive,
	[Cpp2IlInjected.Token(Token = "0x400000C")]
	Override,
	[Cpp2IlInjected.Token(Token = "0x400000D")]
	Reflective
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
[DEONFKEHMJD(typeof(JFOPDBBEICP), new string[] { "Ignore", "Mock" })]
public class MHGDGPLIFKG : JFOPDBBEICP
{
	[Cpp2IlInjected.Token(Token = "0x17000001")]
	public bool PCAJPDAOMGC
	{
		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x7B39F0", Offset = "0x7B21F0", VA = "0x1807B39F0", Slot = "4")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0x7644F0", Offset = "0x762CF0", VA = "0x1807644F0", Slot = "5")]
	public void FIGHIEPAKPO(string HLPKEEDLIBL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x7644F0", Offset = "0x762CF0", VA = "0x1807644F0", Slot = "6")]
	public void DPFLPAJBCAN(RigidbodyEx AHGOPBJOELE, Action OONIIOMBHJI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x764500", Offset = "0x762D00", VA = "0x180764500", Slot = "7")]
	public BMACFOJPCPM EJPKNPOEFHP(int JDPFEOMAPCB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x7644F0", Offset = "0x762CF0", VA = "0x1807644F0", Slot = "8")]
	public void LCMNMGNPAFG(Vector3 BCJKOGIBLJJ, float KFALDNLFOPK, Color MOJKBHCPNEF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x76E470", Offset = "0x76CC70", VA = "0x18076E470")]
	public MHGDGPLIFKG()
	{
	}
}
namespace RecRoom
{
	[Cpp2IlInjected.Token(Token = "0x2000008")]
	[DisallowMultipleComponent]
	public sealed class RigidbodyEx : MonoBehaviour
	{
		[Cpp2IlInjected.Token(Token = "0x400000F")]
		private static readonly DGJIKJLGCCH LEIHHFDOLCB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000010")]
		private bool NNANMBJOLCK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000011")]
		private ACNEEEENOML MHJHGEAMNGH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000012")]
		[PDDJFAPJMON(LFNBNCHIJGL.Self, false, false, false)]
		[SerializeField]
		private Rigidbody unityRigidbody;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000013")]
		[PDDJFAPJMON(LFNBNCHIJGL.SelfAndParent, true, false, false)]
		[SerializeField]
		private PhotonView photonView;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000014")]
		[SerializeField]
		private OverridableVector3 precomputedCenterOfMass;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000015")]
		[SerializeField]
		private OverridableVector3 customCenterOfMass;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000016")]
		[SerializeField]
		[FormerlySerializedAs("forceNoInterpolation")]
		private JCKLAKCMHFC physicsInterpolation;

		[Cpp2IlInjected.FieldOffset(Offset = "0x5C")]
		[Cpp2IlInjected.Token(Token = "0x4000017")]
		[SerializeField]
		[Tooltip("If checked, this object's Unity Rigidbody will not be stripped when parenting the object to another RigidbodyEx. Only check this on objects that have a Unity Rigidbody by default and who need access to Unity physics events like OnTriggerEnter, OnCollisionEnter, etc. This is sometimes set via script instead of this flag.")]
		private bool keepUnityRigidbodyWhileParented;

		[Cpp2IlInjected.FieldOffset(Offset = "0x5D")]
		[Cpp2IlInjected.Token(Token = "0x4000018")]
		[Tooltip("If the RigidbodyEx has a parent that is being destroyed, this flag allows this RigidbodyEx to keep the parent set. The default behavior is thatthe parent property is set to null, resetting/clearing the existing parent when it is being destroyed.")]
		[SerializeField]
		private bool keepParentOnParentDestroy;

		[Cpp2IlInjected.FieldOffset(Offset = "0x5E")]
		[Cpp2IlInjected.Token(Token = "0x4000019")]
		[SerializeField]
		[HideInInspector]
		private bool hasUnityRigidbodyByDefault;

		[Cpp2IlInjected.Token(Token = "0x17000002")]
		internal ACNEEEENOML HDDKOOHNGPB
		{
			[Cpp2IlInjected.Token(Token = "0x600000B")]
			[Cpp2IlInjected.Address(RVA = "0x622FF90", Offset = "0x622E790", VA = "0x18622FF90")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000003")]
		public IReadOnlyList<RigidbodyEx> JFHGFAJNLCE
		{
			[Cpp2IlInjected.Token(Token = "0x6000021")]
			[Cpp2IlInjected.Address(RVA = "0x761C00", Offset = "0x760400", VA = "0x180761C00")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000022")]
			[Cpp2IlInjected.Address(RVA = "0x761BE0", Offset = "0x7603E0", VA = "0x180761BE0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000004")]
		public RigidbodyEx HLPLOGEKDGP
		{
			[Cpp2IlInjected.Token(Token = "0x6000023")]
			[Cpp2IlInjected.Address(RVA = "0x6231610", Offset = "0x622FE10", VA = "0x186231610")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000005")]
		public RigidbodyEx IDPDODAHCDH
		{
			[Cpp2IlInjected.Token(Token = "0x6000024")]
			[Cpp2IlInjected.Address(RVA = "0x6231570", Offset = "0x622FD70", VA = "0x186231570")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000006")]
		public RigidbodyEx OBIIIBPBMLD
		{
			[Cpp2IlInjected.Token(Token = "0x6000025")]
			[Cpp2IlInjected.Address(RVA = "0x6232230", Offset = "0x6230A30", VA = "0x186232230")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000026")]
			[Cpp2IlInjected.Address(RVA = "0x62337B0", Offset = "0x6231FB0", VA = "0x1862337B0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000007")]
		public Transform KOGDNGIFDKB
		{
			[Cpp2IlInjected.Token(Token = "0x6000027")]
			[Cpp2IlInjected.Address(RVA = "0x78BCB0", Offset = "0x78A4B0", VA = "0x18078BCB0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000008")]
		public Transform FHODNODINAI
		{
			[Cpp2IlInjected.Token(Token = "0x6000028")]
			[Cpp2IlInjected.Address(RVA = "0x78BCB0", Offset = "0x78A4B0", VA = "0x18078BCB0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000009")]
		public GOBOFKKAMEO FADDMLIMLLG
		{
			[Cpp2IlInjected.Token(Token = "0x6000029")]
			[Cpp2IlInjected.Address(RVA = "0x6231330", Offset = "0x622FB30", VA = "0x186231330")]
			get
			{
				return default(GOBOFKKAMEO);
			}
			[Cpp2IlInjected.Token(Token = "0x600002A")]
			[Cpp2IlInjected.Address(RVA = "0x6232F60", Offset = "0x6231760", VA = "0x186232F60")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000A")]
		public bool LFEOJFGHFML
		{
			[Cpp2IlInjected.Token(Token = "0x600002B")]
			[Cpp2IlInjected.Address(RVA = "0x62318C0", Offset = "0x62300C0", VA = "0x1862318C0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000B")]
		public bool NEIGPDMIINK
		{
			[Cpp2IlInjected.Token(Token = "0x600002C")]
			[Cpp2IlInjected.Address(RVA = "0x6231450", Offset = "0x622FC50", VA = "0x186231450")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000C")]
		public CPIKNIBKFKL GNLKAEJNEDB
		{
			[Cpp2IlInjected.Token(Token = "0x600002D")]
			[Cpp2IlInjected.Address(RVA = "0x6231800", Offset = "0x6230000", VA = "0x186231800")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600002E")]
			[Cpp2IlInjected.Address(RVA = "0x6233120", Offset = "0x6231920", VA = "0x186233120")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000D")]
		public OKPICPJMDEO JKKMJBKLALO
		{
			[Cpp2IlInjected.Token(Token = "0x600002F")]
			[Cpp2IlInjected.Address(RVA = "0x62317A0", Offset = "0x622FFA0", VA = "0x1862317A0")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000030")]
			[Cpp2IlInjected.Address(RVA = "0x62330B0", Offset = "0x62318B0", VA = "0x1862330B0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000E")]
		public bool KIEFCCGGPLM
		{
			[Cpp2IlInjected.Token(Token = "0x6000031")]
			[Cpp2IlInjected.Address(RVA = "0x62316F0", Offset = "0x622FEF0", VA = "0x1862316F0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000F")]
		public Rigidbody AIOLOONKHDH
		{
			[Cpp2IlInjected.Token(Token = "0x6000032")]
			[Cpp2IlInjected.Address(RVA = "0x6231750", Offset = "0x622FF50", VA = "0x186231750")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000010")]
		public bool JIAMCDEEBDI
		{
			[Cpp2IlInjected.Token(Token = "0x6000033")]
			[Cpp2IlInjected.Address(RVA = "0x62314B0", Offset = "0x622FCB0", VA = "0x1862314B0")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000034")]
			[Cpp2IlInjected.Address(RVA = "0x6232FD0", Offset = "0x62317D0", VA = "0x186232FD0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000011")]
		public bool GBMJECKHCFP
		{
			[Cpp2IlInjected.Token(Token = "0x6000035")]
			[Cpp2IlInjected.Address(RVA = "0x1A20560", Offset = "0x1A1ED60", VA = "0x181A20560")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000036")]
			[Cpp2IlInjected.Address(RVA = "0x5AC5700", Offset = "0x5AC3F00", VA = "0x185AC5700")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000012")]
		public float FABLLLKKOKH
		{
			[Cpp2IlInjected.Token(Token = "0x6000037")]
			[Cpp2IlInjected.Address(RVA = "0x62321D0", Offset = "0x62309D0", VA = "0x1862321D0")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000013")]
		public float FELOCIBFPFA
		{
			[Cpp2IlInjected.Token(Token = "0x6000038")]
			[Cpp2IlInjected.Address(RVA = "0x6232170", Offset = "0x6230970", VA = "0x186232170")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x6000039")]
			[Cpp2IlInjected.Address(RVA = "0x6233740", Offset = "0x6231F40", VA = "0x186233740")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000014")]
		public float KHKHCHJFFEJ
		{
			[Cpp2IlInjected.Token(Token = "0x600003A")]
			[Cpp2IlInjected.Address(RVA = "0x6231B20", Offset = "0x6230320", VA = "0x186231B20")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x600003B")]
			[Cpp2IlInjected.Address(RVA = "0x62333C0", Offset = "0x6231BC0", VA = "0x1862333C0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000015")]
		public float FNLHMFOPCIN
		{
			[Cpp2IlInjected.Token(Token = "0x600003C")]
			[Cpp2IlInjected.Address(RVA = "0x6231920", Offset = "0x6230120", VA = "0x186231920")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x600003D")]
			[Cpp2IlInjected.Address(RVA = "0x6233190", Offset = "0x6231990", VA = "0x186233190")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000016")]
		public bool ILJCCPMKGED
		{
			[Cpp2IlInjected.Token(Token = "0x600003E")]
			[Cpp2IlInjected.Address(RVA = "0x6232790", Offset = "0x6230F90", VA = "0x186232790")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x600003F")]
			[Cpp2IlInjected.Address(RVA = "0x6233D10", Offset = "0x6232510", VA = "0x186233D10")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000017")]
		public Vector3 AOMNMAJCKEJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000040")]
			[Cpp2IlInjected.Address(RVA = "0x6231F50", Offset = "0x6230750", VA = "0x186231F50")]
			get
			{
				return default(Vector3);
			}
			[Cpp2IlInjected.Token(Token = "0x6000041")]
			[Cpp2IlInjected.Address(RVA = "0x6233510", Offset = "0x6231D10", VA = "0x186233510")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000018")]
		public Vector3 BCJKOGIBLJJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000042")]
			[Cpp2IlInjected.Address(RVA = "0x62328D0", Offset = "0x62310D0", VA = "0x1862328D0")]
			get
			{
				return default(Vector3);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000019")]
		public CollisionDetectionMode NECGEKMDLBC
		{
			[Cpp2IlInjected.Token(Token = "0x6000043")]
			[Cpp2IlInjected.Address(RVA = "0x6231A60", Offset = "0x6230260", VA = "0x186231A60")]
			get
			{
				return default(CollisionDetectionMode);
			}
			[Cpp2IlInjected.Token(Token = "0x6000044")]
			[Cpp2IlInjected.Address(RVA = "0x62332E0", Offset = "0x6231AE0", VA = "0x1862332E0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001A")]
		public float ICPKIGJHHCD
		{
			[Cpp2IlInjected.Token(Token = "0x6000045")]
			[Cpp2IlInjected.Address(RVA = "0x6231510", Offset = "0x622FD10", VA = "0x186231510")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x6000046")]
			[Cpp2IlInjected.Address(RVA = "0x6233040", Offset = "0x6231840", VA = "0x186233040")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001B")]
		public RigidbodyConstraints FMPNKBADMFO
		{
			[Cpp2IlInjected.Token(Token = "0x6000047")]
			[Cpp2IlInjected.Address(RVA = "0x6231AC0", Offset = "0x62302C0", VA = "0x186231AC0")]
			get
			{
				return default(RigidbodyConstraints);
			}
			[Cpp2IlInjected.Token(Token = "0x6000048")]
			[Cpp2IlInjected.Address(RVA = "0x6233350", Offset = "0x6231B50", VA = "0x186233350")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001C")]
		public Vector3 DFPHCBEMDNN
		{
			[Cpp2IlInjected.Token(Token = "0x6000049")]
			[Cpp2IlInjected.Address(RVA = "0x62322D0", Offset = "0x6230AD0", VA = "0x1862322D0")]
			get
			{
				return default(Vector3);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001D")]
		public Vector3 DDBHAPOFGPF
		{
			[Cpp2IlInjected.Token(Token = "0x600004A")]
			[Cpp2IlInjected.Address(RVA = "0x62322D0", Offset = "0x6230AD0", VA = "0x1862322D0")]
			get
			{
				return default(Vector3);
			}
			[Cpp2IlInjected.Token(Token = "0x600004B")]
			[Cpp2IlInjected.Address(RVA = "0x6233AF0", Offset = "0x62322F0", VA = "0x186233AF0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001E")]
		public float KJDBOBHCLDP
		{
			[Cpp2IlInjected.Token(Token = "0x600004C")]
			[Cpp2IlInjected.Address(RVA = "0x6232030", Offset = "0x6230830", VA = "0x186232030")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x600004D")]
			[Cpp2IlInjected.Address(RVA = "0x62335F0", Offset = "0x6231DF0", VA = "0x1862335F0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001F")]
		public float CBLDPENDOHC
		{
			[Cpp2IlInjected.Token(Token = "0x600004E")]
			[Cpp2IlInjected.Address(RVA = "0x6232730", Offset = "0x6230F30", VA = "0x186232730")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x600004F")]
			[Cpp2IlInjected.Address(RVA = "0x6233CA0", Offset = "0x62324A0", VA = "0x186233CA0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000020")]
		public Quaternion AKOFCBJNDMG
		{
			[Cpp2IlInjected.Token(Token = "0x6000050")]
			[Cpp2IlInjected.Address(RVA = "0x62323B0", Offset = "0x6230BB0", VA = "0x1862323B0")]
			get
			{
				return default(Quaternion);
			}
			[Cpp2IlInjected.Token(Token = "0x6000051")]
			[Cpp2IlInjected.Address(RVA = "0x6233870", Offset = "0x6232070", VA = "0x186233870")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000021")]
		public Quaternion OLHKBAOPOGF
		{
			[Cpp2IlInjected.Token(Token = "0x6000052")]
			[Cpp2IlInjected.Address(RVA = "0x6232650", Offset = "0x6230E50", VA = "0x186232650")]
			get
			{
				return default(Quaternion);
			}
			[Cpp2IlInjected.Token(Token = "0x6000053")]
			[Cpp2IlInjected.Address(RVA = "0x6233BD0", Offset = "0x62323D0", VA = "0x186233BD0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000022")]
		public Vector3 LCLGHLIMFEE
		{
			[Cpp2IlInjected.Token(Token = "0x6000054")]
			[Cpp2IlInjected.Address(RVA = "0x6232490", Offset = "0x6230C90", VA = "0x186232490")]
			get
			{
				return default(Vector3);
			}
			[Cpp2IlInjected.Token(Token = "0x6000055")]
			[Cpp2IlInjected.Address(RVA = "0x6233940", Offset = "0x6232140", VA = "0x186233940")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000023")]
		public Quaternion MFFLJFHDBIC
		{
			[Cpp2IlInjected.Token(Token = "0x6000056")]
			[Cpp2IlInjected.Address(RVA = "0x6232570", Offset = "0x6230D70", VA = "0x186232570")]
			get
			{
				return default(Quaternion);
			}
			[Cpp2IlInjected.Token(Token = "0x6000057")]
			[Cpp2IlInjected.Address(RVA = "0x6233A20", Offset = "0x6232220", VA = "0x186233A20")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000024")]
		public Vector3 NOCGKJGODHL
		{
			[Cpp2IlInjected.Token(Token = "0x6000058")]
			[Cpp2IlInjected.Address(RVA = "0x62327F0", Offset = "0x6230FF0", VA = "0x1862327F0")]
			get
			{
				return default(Vector3);
			}
			[Cpp2IlInjected.Token(Token = "0x6000059")]
			[Cpp2IlInjected.Address(RVA = "0x6233D80", Offset = "0x6232580", VA = "0x186233D80")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000025")]
		public Vector3 AMLAOHJLKAL
		{
			[Cpp2IlInjected.Token(Token = "0x600005A")]
			[Cpp2IlInjected.Address(RVA = "0x6232090", Offset = "0x6230890", VA = "0x186232090")]
			get
			{
				return default(Vector3);
			}
			[Cpp2IlInjected.Token(Token = "0x600005B")]
			[Cpp2IlInjected.Address(RVA = "0x6233660", Offset = "0x6231E60", VA = "0x186233660")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000026")]
		public Vector3 NMAGMMAOJAD
		{
			[Cpp2IlInjected.Token(Token = "0x600005C")]
			[Cpp2IlInjected.Address(RVA = "0x6231980", Offset = "0x6230180", VA = "0x186231980")]
			get
			{
				return default(Vector3);
			}
			[Cpp2IlInjected.Token(Token = "0x600005D")]
			[Cpp2IlInjected.Address(RVA = "0x6233200", Offset = "0x6231A00", VA = "0x186233200")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000027")]
		public Vector3 CHFCHAFCOBM
		{
			[Cpp2IlInjected.Token(Token = "0x600005E")]
			[Cpp2IlInjected.Address(RVA = "0x6231E70", Offset = "0x6230670", VA = "0x186231E70")]
			get
			{
				return default(Vector3);
			}
			[Cpp2IlInjected.Token(Token = "0x600005F")]
			[Cpp2IlInjected.Address(RVA = "0x6233430", Offset = "0x6231C30", VA = "0x186233430")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000028")]
		public Vector3 IKDLKPGINHP
		{
			[Cpp2IlInjected.Token(Token = "0x6000060")]
			[Cpp2IlInjected.Address(RVA = "0x6231D30", Offset = "0x6230530", VA = "0x186231D30")]
			get
			{
				return default(Vector3);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000029")]
		public Quaternion EMFIIFKPNLG
		{
			[Cpp2IlInjected.Token(Token = "0x6000061")]
			[Cpp2IlInjected.Address(RVA = "0x6231C50", Offset = "0x6230450", VA = "0x186231C50")]
			get
			{
				return default(Quaternion);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002A")]
		public Vector3 GMIHDKEJGLC
		{
			[Cpp2IlInjected.Token(Token = "0x6000063")]
			[Cpp2IlInjected.Address(RVA = "0x6232A90", Offset = "0x6231290", VA = "0x186232A90")]
			get
			{
				return default(Vector3);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002B")]
		public Vector3 FAJLNFHEENK
		{
			[Cpp2IlInjected.Token(Token = "0x6000064")]
			[Cpp2IlInjected.Address(RVA = "0x62329B0", Offset = "0x62311B0", VA = "0x1862329B0")]
			get
			{
				return default(Vector3);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002C")]
		public bool EKPIMFFAAJH
		{
			[Cpp2IlInjected.Token(Token = "0x6000065")]
			[Cpp2IlInjected.Address(RVA = "0x6231E10", Offset = "0x6230610", VA = "0x186231E10")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002D")]
		public bool HDHFPOGMJNC
		{
			[Cpp2IlInjected.Token(Token = "0x6000066")]
			[Cpp2IlInjected.Address(RVA = "0x6231860", Offset = "0x6230060", VA = "0x186231860")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002E")]
		public bool OJIENIPMIAF
		{
			[Cpp2IlInjected.Token(Token = "0x6000067")]
			[Cpp2IlInjected.Address(RVA = "0x62313F0", Offset = "0x622FBF0", VA = "0x1862313F0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002F")]
		public bool PCBADJMLDFE
		{
			[Cpp2IlInjected.Token(Token = "0x6000068")]
			[Cpp2IlInjected.Address(RVA = "0x6231390", Offset = "0x622FB90", VA = "0x186231390")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000030")]
		public bool KJEMIFCOIFF
		{
			[Cpp2IlInjected.Token(Token = "0x6000069")]
			[Cpp2IlInjected.Address(RVA = "0x62312D0", Offset = "0x622FAD0", VA = "0x1862312D0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000031")]
		public bool EFPJCFMCMPM
		{
			[Cpp2IlInjected.Token(Token = "0x600006A")]
			[Cpp2IlInjected.Address(RVA = "0x6231B80", Offset = "0x6230380", VA = "0x186231B80")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000032")]
		public bool PODDKBEPHJP
		{
			[Cpp2IlInjected.Token(Token = "0x600006B")]
			[Cpp2IlInjected.Address(RVA = "0x4EA7450", Offset = "0x4EA5C50", VA = "0x184EA7450")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000001")]
		public event EBFBHNJDFMO CDNFNNDAFPE
		{
			[Cpp2IlInjected.Token(Token = "0x600000F")]
			[Cpp2IlInjected.Address(RVA = "0x62311F0", Offset = "0x622F9F0", VA = "0x1862311F0")]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000010")]
			[Cpp2IlInjected.Address(RVA = "0x6232E80", Offset = "0x6231680", VA = "0x186232E80")]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000002")]
		public event GHEEFDJOPPC DAFIKNOGCIK
		{
			[Cpp2IlInjected.Token(Token = "0x6000011")]
			[Cpp2IlInjected.Address(RVA = "0x6231180", Offset = "0x622F980", VA = "0x186231180")]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000012")]
			[Cpp2IlInjected.Address(RVA = "0x6232E10", Offset = "0x6231610", VA = "0x186232E10")]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000003")]
		public event EBFBHNJDFMO PAAEJBNAELP
		{
			[Cpp2IlInjected.Token(Token = "0x6000013")]
			[Cpp2IlInjected.Address(RVA = "0x6230EE0", Offset = "0x622F6E0", VA = "0x186230EE0")]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000014")]
			[Cpp2IlInjected.Address(RVA = "0x6232B70", Offset = "0x6231370", VA = "0x186232B70")]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000004")]
		public event EBFBHNJDFMO ANLGMIPOGHH
		{
			[Cpp2IlInjected.Token(Token = "0x6000015")]
			[Cpp2IlInjected.Address(RVA = "0x6230F50", Offset = "0x622F750", VA = "0x186230F50")]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000016")]
			[Cpp2IlInjected.Address(RVA = "0x6232BE0", Offset = "0x62313E0", VA = "0x186232BE0")]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000005")]
		public event EBFBHNJDFMO PPOOMLEKHLL
		{
			[Cpp2IlInjected.Token(Token = "0x6000017")]
			[Cpp2IlInjected.Address(RVA = "0x62310A0", Offset = "0x622F8A0", VA = "0x1862310A0")]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000018")]
			[Cpp2IlInjected.Address(RVA = "0x6232D30", Offset = "0x6231530", VA = "0x186232D30")]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000006")]
		public event Action<LMALNIIPHAC, LMALNIIPHAC> ENBBGJAGBJJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000019")]
			[Cpp2IlInjected.Address(RVA = "0x6231030", Offset = "0x622F830", VA = "0x186231030")]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x600001A")]
			[Cpp2IlInjected.Address(RVA = "0x6232CC0", Offset = "0x62314C0", VA = "0x186232CC0")]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000007")]
		public event EBFBHNJDFMO CHNPNHBMGDG
		{
			[Cpp2IlInjected.Token(Token = "0x600001B")]
			[Cpp2IlInjected.Address(RVA = "0x6231110", Offset = "0x622F910", VA = "0x186231110")]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x600001C")]
			[Cpp2IlInjected.Address(RVA = "0x6232DA0", Offset = "0x62315A0", VA = "0x186232DA0")]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000008")]
		public event EBFBHNJDFMO NPANCDHMPLH
		{
			[Cpp2IlInjected.Token(Token = "0x600001D")]
			[Cpp2IlInjected.Address(RVA = "0x6231260", Offset = "0x622FA60", VA = "0x186231260")]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x600001E")]
			[Cpp2IlInjected.Address(RVA = "0x6232EF0", Offset = "0x62316F0", VA = "0x186232EF0")]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000009")]
		public event EBFBHNJDFMO NDADBNMCKJG
		{
			[Cpp2IlInjected.Token(Token = "0x600001F")]
			[Cpp2IlInjected.Address(RVA = "0x6230FC0", Offset = "0x622F7C0", VA = "0x186230FC0")]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000020")]
			[Cpp2IlInjected.Address(RVA = "0x6232C50", Offset = "0x6231450", VA = "0x186232C50")]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x7662F0", Offset = "0x764AF0", VA = "0x1807662F0")]
		internal void GOBDGPJBOHO(ACNEEEENOML PCEPPDLMHCM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x622F380", Offset = "0x622DB80", VA = "0x18622F380")]
		internal void BPCANHIHDEE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x6230C00", Offset = "0x622F400", VA = "0x186230C00")]
		[Conditional("UNITY_EDITOR")]
		[Conditional("DEBUG_BUILD")]
		public void TestOverrideUnityRigidbody(Rigidbody IGFBEKNILFA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000062")]
		[Cpp2IlInjected.Address(RVA = "0x62308D0", Offset = "0x622F0D0", VA = "0x1862308D0")]
		public void SetInertiaTensor((Quaternion rot, Vector3 moments) MOGJAEMHOKI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006C")]
		[Cpp2IlInjected.Address(RVA = "0x622F310", Offset = "0x622DB10", VA = "0x18622F310")]
		private void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006D")]
		[Cpp2IlInjected.Address(RVA = "0x622FF90", Offset = "0x622E790", VA = "0x18622FF90")]
		private ACNEEEENOML NDNBJMMEIEO()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600006E")]
		[Cpp2IlInjected.Address(RVA = "0x622F650", Offset = "0x622DE50", VA = "0x18622F650")]
		private void FCMGAGDDFDK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006F")]
		[Cpp2IlInjected.Address(RVA = "0x62300A0", Offset = "0x622E8A0", VA = "0x1862300A0")]
		private void OnEnable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000070")]
		[Cpp2IlInjected.Address(RVA = "0x7644F0", Offset = "0x762CF0", VA = "0x1807644F0")]
		public void OnDisable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000071")]
		[Cpp2IlInjected.Address(RVA = "0x622F380", Offset = "0x622DB80", VA = "0x18622F380")]
		private void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000072")]
		[Cpp2IlInjected.Address(RVA = "0x6230040", Offset = "0x622E840", VA = "0x186230040")]
		private void OnDrawGizmosSelected()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000073")]
		[Cpp2IlInjected.Address(RVA = "0x6230100", Offset = "0x622E900", VA = "0x186230100")]
		private void OnValidate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000074")]
		[Cpp2IlInjected.Address(RVA = "0x622E9C0", Offset = "0x622D1C0", VA = "0x18622E9C0")]
		public void AddDoNotResetVelocityOnOwnershipChangeOverride(object KIAKEGJPMAL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000075")]
		[Cpp2IlInjected.Address(RVA = "0x6230160", Offset = "0x622E960", VA = "0x186230160")]
		public void RemoveDoNotResetVelocityOnOwnershipChangeOverride(object KIAKEGJPMAL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000076")]
		[Cpp2IlInjected.Address(RVA = "0x622F5F0", Offset = "0x622DDF0", VA = "0x18622F5F0")]
		public void DisableCachedInertialPropertyOverride()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000077")]
		[Cpp2IlInjected.Address(RVA = "0x622FF30", Offset = "0x622E730", VA = "0x18622FF30")]
		public void MarkCachedInertialParametersDirty()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000078")]
		[Cpp2IlInjected.Address(RVA = "0x6230A30", Offset = "0x622F230", VA = "0x186230A30")]
		public void SetParent(RigidbodyEx FKKGMPDEPMA, bool CGKOADMHFLC = false)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000079")]
		[Cpp2IlInjected.Address(RVA = "0x6230470", Offset = "0x622EC70", VA = "0x186230470")]
		public void ResetLocalCenterOfMassToPrefabDefault()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007A")]
		[Cpp2IlInjected.Address(RVA = "0x622FC00", Offset = "0x622E400", VA = "0x18622FC00")]
		public bool IsRigidbodyAncestor(RigidbodyEx FFMBJOHCBPE)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600007B")]
		[Cpp2IlInjected.Address(RVA = "0x622FCE0", Offset = "0x622E4E0", VA = "0x18622FCE0")]
		public bool IsRigidbodyDescendant(RigidbodyEx IALCJLJEKEF)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600007C")]
		[Cpp2IlInjected.Address(RVA = "0x622EC30", Offset = "0x622D430", VA = "0x18622EC30")]
		public void AddInterpolationRestriction(object KIAKEGJPMAL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007D")]
		[Cpp2IlInjected.Address(RVA = "0x62301D0", Offset = "0x622E9D0", VA = "0x1862301D0")]
		public void RemoveInterpolationRestriction(object KIAKEGJPMAL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007E")]
		[Cpp2IlInjected.Address(RVA = "0x622F410", Offset = "0x622DC10", VA = "0x18622F410")]
		public IDisposable BeginKinematicScope()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600007F")]
		[Cpp2IlInjected.Address(RVA = "0x622ECA0", Offset = "0x622D4A0", VA = "0x18622ECA0")]
		public void AddKinematic(object KIAKEGJPMAL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000080")]
		[Cpp2IlInjected.Address(RVA = "0x6230240", Offset = "0x622EA40", VA = "0x186230240")]
		public void RemoveKinematic(object KIAKEGJPMAL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000081")]
		[Cpp2IlInjected.Address(RVA = "0x62309B0", Offset = "0x622F1B0", VA = "0x1862309B0")]
		public void SetKinematic(object KIAKEGJPMAL, bool JMNDFKAOINO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000082")]
		[Cpp2IlInjected.Address(RVA = "0x62307D0", Offset = "0x622EFD0", VA = "0x1862307D0")]
		public void SetDiscontinuousPositionAndRotation(Vector3 AAMDDKIBNEM, Quaternion AHHDHIOJLHB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000083")]
		[Cpp2IlInjected.Address(RVA = "0x62306D0", Offset = "0x622EED0", VA = "0x1862306D0")]
		public void SetDiscontinuousLocalPositionAndLocalRotation(Vector3 LHHPNCJCHFD, Quaternion CDONFJKGJGK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000084")]
		[Cpp2IlInjected.Address(RVA = "0x622FAF0", Offset = "0x622E2F0", VA = "0x18622FAF0")]
		public Vector3 GetConstrainedVelocity(Vector3 NOCGKJGODHL)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x6000085")]
		[Cpp2IlInjected.Address(RVA = "0x622F9E0", Offset = "0x622E1E0", VA = "0x18622F9E0")]
		public Vector3 GetConstrainedAngularVelocity(Vector3 NMAGMMAOJAD)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x6000086")]
		[Cpp2IlInjected.Address(RVA = "0x622EB40", Offset = "0x622D340", VA = "0x18622EB40")]
		public void AddForce(Vector3 AKFFELDLHDA, ForceMode ACFLBCIEBAA = ForceMode.Force)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000087")]
		[Cpp2IlInjected.Address(RVA = "0x622EA30", Offset = "0x622D230", VA = "0x18622EA30")]
		public void AddForceAtPosition(Vector3 AKFFELDLHDA, Vector3 MCLBBPPAHAP, ForceMode ACFLBCIEBAA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000088")]
		[Cpp2IlInjected.Address(RVA = "0x622EE70", Offset = "0x622D670", VA = "0x18622EE70")]
		public void AddTorque(Vector3 FNPOFGBLJMD, ForceMode ACFLBCIEBAA = ForceMode.Force)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000089")]
		[Cpp2IlInjected.Address(RVA = "0x622ED10", Offset = "0x622D510", VA = "0x18622ED10")]
		public void AddRelativeTorque(Vector3 FNPOFGBLJMD, ForceMode ACFLBCIEBAA = ForceMode.Force)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008A")]
		[Cpp2IlInjected.Address(RVA = "0x6230CD0", Offset = "0x622F4D0", VA = "0x186230CD0")]
		public Vector3 WorldToLocalVelocity(Vector3 CPFDNDKFHHH)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x600008B")]
		[Cpp2IlInjected.Address(RVA = "0x622FE20", Offset = "0x622E620", VA = "0x18622FE20")]
		public Vector3 LocalToWorldVelocity(Vector3 AMLAOHJLKAL)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x600008C")]
		[Cpp2IlInjected.Address(RVA = "0x622F590", Offset = "0x622DD90", VA = "0x18622F590")]
		public void ClearVelocity()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008D")]
		[Cpp2IlInjected.Address(RVA = "0x622F530", Offset = "0x622DD30", VA = "0x18622F530")]
		public void ClearUnityRigidbodyVelocity()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008E")]
		[Cpp2IlInjected.Address(RVA = "0x622F4D0", Offset = "0x622DCD0", VA = "0x18622F4D0")]
		public void ClearLinearVelocity()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008F")]
		[Cpp2IlInjected.Address(RVA = "0x622F470", Offset = "0x622DC70", VA = "0x18622F470")]
		public void ClearAngularVelocity()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000090")]
		[Cpp2IlInjected.Address(RVA = "0x62305D0", Offset = "0x622EDD0", VA = "0x1862305D0")]
		public void ResetVelocityWorldSpace(Vector3 HDFIANGNHPD, Vector3 OPNLLPIFKNP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000091")]
		[Cpp2IlInjected.Address(RVA = "0x62304D0", Offset = "0x622ECD0", VA = "0x1862304D0")]
		public void ResetVelocityLocalSpace(Vector3 JPNLAOHAPPM, Vector3 CHFCHAFCOBM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000092")]
		[Cpp2IlInjected.Address(RVA = "0x6230390", Offset = "0x622EB90", VA = "0x186230390")]
		public void ResetLinearVelocityLocalSpace(Vector3 JPNLAOHAPPM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000093")]
		[Cpp2IlInjected.Address(RVA = "0x6230B60", Offset = "0x622F360", VA = "0x186230B60")]
		public bool SweepTest(Vector3 GJMNPFFBJPA, [Out] RaycastHit LGAEEAFDDFJ, float LNHOFLIBFND)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000094")]
		[Cpp2IlInjected.Address(RVA = "0x622FDC0", Offset = "0x622E5C0", VA = "0x18622FDC0")]
		public bool IsSleeping()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000095")]
		[Cpp2IlInjected.Address(RVA = "0x6230B00", Offset = "0x622F300", VA = "0x186230B00")]
		public void Sleep()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000096")]
		[Cpp2IlInjected.Address(RVA = "0x6230C70", Offset = "0x622F470", VA = "0x186230C70")]
		public void WakeUp()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000097")]
		[Cpp2IlInjected.Address(RVA = "0x622EE00", Offset = "0x622D600", VA = "0x18622EE00")]
		public void AddShouldHaveUnityRigidbodyToken(object KIAKEGJPMAL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000098")]
		[Cpp2IlInjected.Address(RVA = "0x62302B0", Offset = "0x622EAB0", VA = "0x1862302B0")]
		public void RemoveShouldHaveUnityRigidbodyToken(object KIAKEGJPMAL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000099")]
		[Cpp2IlInjected.Address(RVA = "0x622F1A0", Offset = "0x622D9A0", VA = "0x18622F1A0")]
		public void ApplyForceVelocityChange(BPNODJIJBLA KADKJKFHDBE, Vector3 MCCPDDLJGEG, float EGMGOJMNMKL, float FLCBFAEIBEI = 8f, float MMINJAGEDBL = 1f)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009A")]
		[Cpp2IlInjected.Address(RVA = "0x622F100", Offset = "0x622D900", VA = "0x18622F100")]
		public void ApplyAngularVelocityChange(LJGOMBGDPDM GJBGJOHBOBM, Vector3 GNFMGLELAKB, float JICJOBGCGOP = float.PositiveInfinity)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009B")]
		[Cpp2IlInjected.Address(RVA = "0x622F260", Offset = "0x622DA60", VA = "0x18622F260")]
		[Obsolete("Deprecated. Still exists to support deprecated CV2 chips. Use ApplyAngularVelocityChange.")]
		public void ApplyTorqueAngularVelocityChangeDeprecated(LJGOMBGDPDM GJBGJOHBOBM, Vector3 OHMBDAJNEIJ, float GEPDJOHNEPN = 7f, float JINKMCECFKA = 1f)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009C")]
		[Cpp2IlInjected.Address(RVA = "0x622F030", Offset = "0x622D830", VA = "0x18622F030")]
		public bool AllowedScaleChange(float JJLGAOMIEEO)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600009D")]
		[Cpp2IlInjected.Address(RVA = "0x622EF60", Offset = "0x622D760", VA = "0x18622EF60")]
		public void AddWorldSpaceVelocityInHierarchyParentOverride(RigidbodyEx FFGBMPIEMIB, object KIAKEGJPMAL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009E")]
		[Cpp2IlInjected.Address(RVA = "0x6230320", Offset = "0x622EB20", VA = "0x186230320")]
		public void RemoveWorldSpaceVelocityInHierarchyParentOverride(object KIAKEGJPMAL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009F")]
		[Cpp2IlInjected.Address(RVA = "0x6230E70", Offset = "0x622F670", VA = "0x186230E70")]
		public RigidbodyEx()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
internal static class MPDLFGFBKDD
{
	[Cpp2IlInjected.Token(Token = "0x60000A4")]
	[Cpp2IlInjected.Address(RVA = "0x6228840", Offset = "0x6227040", VA = "0x186228840")]
	public static ACNEEEENOML HDDKOOHNGPB(this RigidbodyEx AHGOPBJOELE)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
public struct ACDBPOHPAKH
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001D")]
	public Rigidbody JFKGLMKHADB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x400001E")]
	public PhotonView LOIBHJHOJDK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400001F")]
	public OverridableVector3 DIDJMHLGDCH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000020")]
	public OverridableVector3 HMLDCLIHLHH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000021")]
	public JCKLAKCMHFC CKKKGDFOKIB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
	[Cpp2IlInjected.Token(Token = "0x4000022")]
	public bool OEHDPAKLGJI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x35")]
	[Cpp2IlInjected.Token(Token = "0x4000023")]
	public bool AJLMKHKENGC;
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
[DEONFKEHMJD(typeof(HGMBJJHEAKJ), new string[] { })]
public class PNDNPGCJEED : HGMBJJHEAKJ, GJOKPFDLDCJ
{
	[Cpp2IlInjected.Token(Token = "0x4000024")]
	private static readonly DGJIKJLGCCH KFIEDGIKACP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000025")]
	private DEDLLFMJKEO GNKGFOJBFBA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000026")]
	private JFOPDBBEICP HGOFPLJJILB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000027")]
	private MIAHMAGCEAF PAHIDOLBIME;

	[Cpp2IlInjected.Token(Token = "0x17000033")]
	public JFOPDBBEICP JAIBLGKGHED
	{
		[Cpp2IlInjected.Token(Token = "0x60000A5")]
		[Cpp2IlInjected.Address(RVA = "0x765620", Offset = "0x763E20", VA = "0x180765620", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000034")]
	public MIAHMAGCEAF CJMIFCIPBNF
	{
		[Cpp2IlInjected.Token(Token = "0x60000A6")]
		[Cpp2IlInjected.Address(RVA = "0x766110", Offset = "0x764910", VA = "0x180766110", Slot = "5")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000A7")]
	[Cpp2IlInjected.Address(RVA = "0x622E630", Offset = "0x622CE30", VA = "0x18622E630", Slot = "8")]
	public void InitReferences(HMNFMHNMJBH CJEADCONOPM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A8")]
	[Cpp2IlInjected.Address(RVA = "0x622E380", Offset = "0x622CB80", VA = "0x18622E380", Slot = "6")]
	public INJNNPDEJLM GKGJCBCGHLJ(RigidbodyEx AHGOPBJOELE)
	{
		return default(INJNNPDEJLM);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A9")]
	[Cpp2IlInjected.Address(RVA = "0x622E6C0", Offset = "0x622CEC0", VA = "0x18622E6C0")]
	private static INJNNPDEJLM KOCIKNBJDEG(RigidbodyEx AHGOPBJOELE)
	{
		return default(INJNNPDEJLM);
	}

	[Cpp2IlInjected.Token(Token = "0x60000AA")]
	[Cpp2IlInjected.Address(RVA = "0x622E2E0", Offset = "0x622CAE0", VA = "0x18622E2E0", Slot = "7")]
	public ACNEEEENOML GAFOKFHHMAF(RigidbodyEx AHGOPBJOELE, ACDBPOHPAKH AELCABDCBDD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000AB")]
	[Cpp2IlInjected.Address(RVA = "0x76E470", Offset = "0x76CC70", VA = "0x18076E470")]
	public PNDNPGCJEED()
	{
	}
}
namespace RecRoom
{
	[Cpp2IlInjected.Token(Token = "0x200000D")]
	public class PhysicsManager : SingletonMonoBehaviour<PhysicsManager>
	{
		[Cpp2IlInjected.Token(Token = "0x4000028")]
		public static BJPMGBAMGNN UpdateAfterFixedUpdateRan;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000029")]
		private int OKEBFAEEDHI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x400002A")]
		private int EKKPENOBDJA;

		[Cpp2IlInjected.Token(Token = "0x60000AD")]
		[Cpp2IlInjected.Address(RVA = "0x622E820", Offset = "0x622D020", VA = "0x18622E820")]
		protected void FixedUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AE")]
		[Cpp2IlInjected.Address(RVA = "0x622E860", Offset = "0x622D060", VA = "0x18622E860")]
		protected void Update()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AF")]
		[Cpp2IlInjected.Address(RVA = "0x622E840", Offset = "0x622D040", VA = "0x18622E840")]
		protected void LateUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B0")]
		[Cpp2IlInjected.Address(RVA = "0x7644F0", Offset = "0x762CF0", VA = "0x1807644F0")]
		[Conditional("UNITY_ASSERTIONS")]
		public void AssertLateColliderPositionsNotYetUpdated([Optional] string BKGEBGGPBLH, [Optional] UnityEngine.Object FJNGJOFLBMD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B1")]
		[Cpp2IlInjected.Address(RVA = "0x7644F0", Offset = "0x762CF0", VA = "0x1807644F0")]
		[Conditional("UNITY_ASSERTIONS")]
		public void AssertLateColliderPositionsAlreadyUpdated([Optional] string BKGEBGGPBLH, [Optional] UnityEngine.Object FJNGJOFLBMD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B2")]
		[Cpp2IlInjected.Address(RVA = "0x622E970", Offset = "0x622D170", VA = "0x18622E970")]
		public PhysicsManager()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
public static class NPIDFOPEDCN
{
	[Cpp2IlInjected.Token(Token = "0x60000B4")]
	[Cpp2IlInjected.Address(RVA = "0x622B360", Offset = "0x6229B60", VA = "0x18622B360")]
	public static void NBDDLJHPMCD(this Rigidbody IGFBEKNILFA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B5")]
	[Cpp2IlInjected.Address(RVA = "0x622B4F0", Offset = "0x6229CF0", VA = "0x18622B4F0")]
	public static void NBDDLJHPMCD(this Rigidbody IGFBEKNILFA, Vector3 HLEPMEILDNG, Quaternion EMFIIFKPNLG, Vector3 HPBNFEFIJPF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B6")]
	[Cpp2IlInjected.Address(RVA = "0xB39210", Offset = "0xB37A10", VA = "0x180B39210")]
	public static void OKLIDLLEDPL(Vector3 NOCGKJGODHL, Vector3 LOKKODLNJFI, [Out] Vector3 BMJPBIBIFHF, [Out] Vector3 AGIFEJKFONI)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000F")]
public static class PJOPDJBMAOL
{
	[Cpp2IlInjected.Token(Token = "0x2000010")]
	private class CGNEMPEMHFB : CPIKNIBKFKL, IDisposable
	{
		[Cpp2IlInjected.Token(Token = "0x60000B9")]
		[Cpp2IlInjected.Address(RVA = "0x7644F0", Offset = "0x762CF0", VA = "0x1807644F0", Slot = "6")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000BA")]
		[Cpp2IlInjected.Address(RVA = "0x772AA0", Offset = "0x7712A0", VA = "0x180772AA0", Slot = "4")]
		public Vector3 NGGKHGLLJJM()
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x60000BB")]
		[Cpp2IlInjected.Address(RVA = "0x772AA0", Offset = "0x7712A0", VA = "0x180772AA0", Slot = "5")]
		public Vector3 OOGKEFBBBJM()
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x60000BC")]
		[Cpp2IlInjected.Address(RVA = "0x76E470", Offset = "0x76CC70", VA = "0x18076E470")]
		public CGNEMPEMHFB()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000035")]
	public static CPIKNIBKFKL BJMMJHMCDNO
	{
		[Cpp2IlInjected.Token(Token = "0x60000B7")]
		[Cpp2IlInjected.Address(RVA = "0x622E210", Offset = "0x622CA10", VA = "0x18622E210")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
public interface NDKMMOHJIND
{
	[Cpp2IlInjected.Token(Token = "0x17000036")]
	CollisionDetectionMode EJKKFAEAAME
	{
		[Cpp2IlInjected.Token(Token = "0x60000BD")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
		[Cpp2IlInjected.Token(Token = "0x60000BE")]
		[Cpp2IlInjected.Address(Slot = "1")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x60000BF")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void BMFHLKIGOGD();

	[Cpp2IlInjected.Token(Token = "0x60000C0")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void JJAEHGOMMFB(bool EKPIMFFAAJH);

	[Cpp2IlInjected.Token(Token = "0x60000C1")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void PIIIJOOFJJP(bool EKPIMFFAAJH);

	[Cpp2IlInjected.Token(Token = "0x60000C2")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void DOIABHKLMHG(Rigidbody JFKGLMKHADB);

	[Cpp2IlInjected.Token(Token = "0x60000C3")]
	[Cpp2IlInjected.Address(Slot = "6")]
	bool HOKBEJGNALC(Vector3 GJMNPFFBJPA, [Out] RaycastHit LGAEEAFDDFJ, float LNHOFLIBFND);
}
[Cpp2IlInjected.Token(Token = "0x2000012")]
public interface MCEBLIDMGME : IDisposable, EDAFEFMMNAG
{
	[Cpp2IlInjected.Token(Token = "0x17000037")]
	ABDACCGDOPN FADDMLIMLLG
	{
		[Cpp2IlInjected.Token(Token = "0x60000C6")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
		[Cpp2IlInjected.Token(Token = "0x60000C7")]
		[Cpp2IlInjected.Address(Slot = "3")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x1400000A")]
	event Action<LMALNIIPHAC, LMALNIIPHAC> ENBBGJAGBJJ;

	[Cpp2IlInjected.Token(Token = "0x60000C8")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void BMFHLKIGOGD();
}
[Cpp2IlInjected.Token(Token = "0x2000013")]
[PHKIPGBLCCH(PJHIMKBCGDP.Application)]
public interface MIAHMAGCEAF
{
	[Cpp2IlInjected.Token(Token = "0x60000C9")]
	[Cpp2IlInjected.Address(Slot = "0")]
	PMHIGDLAJOP LPHHNKPAPHN(ACNEEEENOML PCEPPDLMHCM);

	[Cpp2IlInjected.Token(Token = "0x60000CA")]
	[Cpp2IlInjected.Address(Slot = "1")]
	LGAMKIPMADE DFLGBNMMLBE(ACNEEEENOML PCEPPDLMHCM);

	[Cpp2IlInjected.Token(Token = "0x60000CB")]
	[Cpp2IlInjected.Address(Slot = "2")]
	LMDEEHLJMOK HBEJLKNNCLJ(ACNEEEENOML PCEPPDLMHCM);

	[Cpp2IlInjected.Token(Token = "0x60000CC")]
	[Cpp2IlInjected.Address(Slot = "3")]
	BMMIOFOJJEB ENNPPKGHEND(ACNEEEENOML PCEPPDLMHCM);

	[Cpp2IlInjected.Token(Token = "0x60000CD")]
	[Cpp2IlInjected.Address(Slot = "4")]
	CCAMOPPOPEI NJJBCPEJOKJ(ACNEEEENOML PCEPPDLMHCM);

	[Cpp2IlInjected.Token(Token = "0x60000CE")]
	[Cpp2IlInjected.Address(Slot = "5")]
	MCEBLIDMGME JEJILAFPABO(ACNEEEENOML PCEPPDLMHCM);

	[Cpp2IlInjected.Token(Token = "0x60000CF")]
	[Cpp2IlInjected.Address(Slot = "6")]
	DMPEOOKGLDG HMGGCOHPDKE(ACNEEEENOML PCEPPDLMHCM);

	[Cpp2IlInjected.Token(Token = "0x60000D0")]
	[Cpp2IlInjected.Address(Slot = "7")]
	AICDKPBPOFE GLEICABECAF(ACNEEEENOML PCEPPDLMHCM);

	[Cpp2IlInjected.Token(Token = "0x60000D1")]
	[Cpp2IlInjected.Address(Slot = "8")]
	NDKMMOHJIND LLPJONABCKF(ACNEEEENOML PCEPPDLMHCM);

	[Cpp2IlInjected.Token(Token = "0x60000D2")]
	[Cpp2IlInjected.Address(Slot = "9")]
	HEEAIGPCPDE KKCAOPGKIHB(ACNEEEENOML PCEPPDLMHCM);

	[Cpp2IlInjected.Token(Token = "0x60000D3")]
	[Cpp2IlInjected.Address(Slot = "10")]
	JGMBKBLBJEA CLIDGNAHFEE(ACNEEEENOML PCEPPDLMHCM, [In] ACDBPOHPAKH AELCABDCBDD);

	[Cpp2IlInjected.Token(Token = "0x60000D4")]
	[Cpp2IlInjected.Address(Slot = "11")]
	DCKAOPOPPEM IBAPHKBNBJH(ACNEEEENOML PCEPPDLMHCM, [In] ACDBPOHPAKH AELCABDCBDD);

	[Cpp2IlInjected.Token(Token = "0x60000D5")]
	[Cpp2IlInjected.Address(Slot = "12")]
	CFLOPMDOLBK EMOCJGFEGOK(ACNEEEENOML PCEPPDLMHCM, [In] ACDBPOHPAKH AELCABDCBDD);

	[Cpp2IlInjected.Token(Token = "0x60000D6")]
	[Cpp2IlInjected.Address(Slot = "13")]
	KFKLGADFDEA GAKGMHFGJEP(ACNEEEENOML PCEPPDLMHCM, [In] ACDBPOHPAKH AELCABDCBDD);

	[Cpp2IlInjected.Token(Token = "0x60000D7")]
	[Cpp2IlInjected.Address(Slot = "14")]
	GCEONIOPFOG ONLCELJFDGF(ACNEEEENOML PCEPPDLMHCM, [In] ACDBPOHPAKH AELCABDCBDD);

	[Cpp2IlInjected.Token(Token = "0x60000D8")]
	[Cpp2IlInjected.Address(Slot = "15")]
	ACNEEEENOML GAFOKFHHMAF(RigidbodyEx AHGOPBJOELE, ACDBPOHPAKH AELCABDCBDD, HGMBJJHEAKJ PNFHHOFJABN);
}
[Cpp2IlInjected.Token(Token = "0x2000014")]
public interface AICDKPBPOFE
{
	[Cpp2IlInjected.Token(Token = "0x60000D9")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void EGEGKPJLIKO(Vector3 AKFFELDLHDA, ForceMode ACFLBCIEBAA = ForceMode.Force);

	[Cpp2IlInjected.Token(Token = "0x60000DA")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void NOAIHMJOFMI(Vector3 AKFFELDLHDA, Vector3 MCLBBPPAHAP, ForceMode ACFLBCIEBAA);

	[Cpp2IlInjected.Token(Token = "0x60000DB")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void JHDOIGEAHPA(Vector3 FNPOFGBLJMD, ForceMode ACFLBCIEBAA = ForceMode.Force);

	[Cpp2IlInjected.Token(Token = "0x60000DC")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void INFGEGJJGIJ(Vector3 FNPOFGBLJMD, ForceMode ACFLBCIEBAA = ForceMode.Force);
}
[Cpp2IlInjected.Token(Token = "0x2000015")]
public interface HEEAIGPCPDE
{
	[Cpp2IlInjected.Token(Token = "0x17000038")]
	bool DAFMFMBFKBE
	{
		[Cpp2IlInjected.Token(Token = "0x60000DD")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
		[Cpp2IlInjected.Token(Token = "0x60000DE")]
		[Cpp2IlInjected.Address(Slot = "1")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x60000DF")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void DOIABHKLMHG(Rigidbody JFKGLMKHADB);

	[Cpp2IlInjected.Token(Token = "0x60000E0")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void HAKPNCDKJGA(Rigidbody JFKGLMKHADB);
}
[Cpp2IlInjected.Token(Token = "0x2000016")]
public interface PMHIGDLAJOP : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x17000039")]
	IReadOnlyList<ACNEEEENOML> FKAHMBHHHJN
	{
		[Cpp2IlInjected.Token(Token = "0x60000F3")]
		[Cpp2IlInjected.Address(Slot = "18")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700003A")]
	ACNEEEENOML IDPDODAHCDH
	{
		[Cpp2IlInjected.Token(Token = "0x60000F4")]
		[Cpp2IlInjected.Address(Slot = "19")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700003B")]
	ACNEEEENOML MLDLDJMPPGN
	{
		[Cpp2IlInjected.Token(Token = "0x60000F5")]
		[Cpp2IlInjected.Address(Slot = "20")]
		get;
		[Cpp2IlInjected.Token(Token = "0x60000F6")]
		[Cpp2IlInjected.Address(Slot = "21")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x1400000B")]
	event EBFBHNJDFMO PAAEJBNAELP;

	[Cpp2IlInjected.Token(Token = "0x1400000C")]
	event EBFBHNJDFMO ANLGMIPOGHH;

	[Cpp2IlInjected.Token(Token = "0x1400000D")]
	event GHEEFDJOPPC GDBIGLFOIGG;

	[Cpp2IlInjected.Token(Token = "0x1400000E")]
	event Action LEDOPACHHJI;

	[Cpp2IlInjected.Token(Token = "0x1400000F")]
	event Action PMKLHIGJFKE;

	[Cpp2IlInjected.Token(Token = "0x14000010")]
	event Action<ACNEEEENOML> DICGHONINEC;

	[Cpp2IlInjected.Token(Token = "0x14000011")]
	event Action<ACNEEEENOML> DHKNBNGMEPD;

	[Cpp2IlInjected.Token(Token = "0x14000012")]
	event Action EIPNHPBGMNG;

	[Cpp2IlInjected.Token(Token = "0x14000013")]
	event Action<ACNEEEENOML> FGIJOHKDECO;

	[Cpp2IlInjected.Token(Token = "0x60000F7")]
	[Cpp2IlInjected.Address(Slot = "22")]
	void JLJFDADNEME(ACNEEEENOML KEDAAEKKLOL, bool CGKOADMHFLC = false);
}
[Cpp2IlInjected.Token(Token = "0x2000017")]
public interface LMDEEHLJMOK
{
	[Cpp2IlInjected.Token(Token = "0x1700003C")]
	Vector3 EEEHLJDAFJK
	{
		[Cpp2IlInjected.Token(Token = "0x60000F8")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700003D")]
	Vector3 JDGLCEIOOBF
	{
		[Cpp2IlInjected.Token(Token = "0x60000F9")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x60000FA")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void HHGGBNOHIJM(ACNEEEENOML OBIIIBPBMLD, object KIAKEGJPMAL);

	[Cpp2IlInjected.Token(Token = "0x60000FB")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void LPFADOHJNOB(object KIAKEGJPMAL);
}
[Cpp2IlInjected.Token(Token = "0x2000018")]
public interface KFKLGADFDEA
{
	[Cpp2IlInjected.Token(Token = "0x1700003E")]
	Vector3 LBFLJMHMJDO
	{
		[Cpp2IlInjected.Token(Token = "0x60000FE")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
		[Cpp2IlInjected.Token(Token = "0x60000FF")]
		[Cpp2IlInjected.Address(Slot = "3")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x1700003F")]
	Vector3 CCEGGEBAGNO
	{
		[Cpp2IlInjected.Token(Token = "0x6000100")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000040")]
	float FDPCBODPJHG
	{
		[Cpp2IlInjected.Token(Token = "0x6000101")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000041")]
	float PFMNCEKEBOC
	{
		[Cpp2IlInjected.Token(Token = "0x6000102")]
		[Cpp2IlInjected.Address(Slot = "6")]
		get;
		[Cpp2IlInjected.Token(Token = "0x6000103")]
		[Cpp2IlInjected.Address(Slot = "7")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000042")]
	Vector3 ONJLJDCPIMM
	{
		[Cpp2IlInjected.Token(Token = "0x6000104")]
		[Cpp2IlInjected.Address(Slot = "8")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000043")]
	Quaternion EKDPJMOLPAE
	{
		[Cpp2IlInjected.Token(Token = "0x6000105")]
		[Cpp2IlInjected.Address(Slot = "9")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x14000014")]
	event EBFBHNJDFMO OEPHAIEKDOP;

	[Cpp2IlInjected.Token(Token = "0x6000106")]
	[Cpp2IlInjected.Address(Slot = "10")]
	void HFHDCMEIKAH((Quaternion rot, Vector3 moments) MOGJAEMHOKI);

	[Cpp2IlInjected.Token(Token = "0x6000107")]
	[Cpp2IlInjected.Address(Slot = "11")]
	void AECDOEBBECA();

	[Cpp2IlInjected.Token(Token = "0x6000108")]
	[Cpp2IlInjected.Address(Slot = "12")]
	void ALFIJHNHMBG();

	[Cpp2IlInjected.Token(Token = "0x6000109")]
	[Cpp2IlInjected.Address(Slot = "13")]
	void PFMKNBPMAJC();

	[Cpp2IlInjected.Token(Token = "0x600010A")]
	[Cpp2IlInjected.Address(Slot = "14")]
	void DOIABHKLMHG(Rigidbody JFKGLMKHADB);

	[Cpp2IlInjected.Token(Token = "0x600010B")]
	[Cpp2IlInjected.Address(Slot = "15")]
	void HAKPNCDKJGA(Rigidbody JFKGLMKHADB);

	[Cpp2IlInjected.Token(Token = "0x600010C")]
	[Cpp2IlInjected.Address(Slot = "16")]
	void FCAHOLPEHIP();
}
[Cpp2IlInjected.Token(Token = "0x2000019")]
public interface CFLOPMDOLBK
{
	[Cpp2IlInjected.Token(Token = "0x600010D")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void BMFHLKIGOGD();

	[Cpp2IlInjected.Token(Token = "0x600010E")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void DOABBELLDJM(object KIAKEGJPMAL);

	[Cpp2IlInjected.Token(Token = "0x600010F")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void BDNICLLPIJJ(object KIAKEGJPMAL);

	[Cpp2IlInjected.Token(Token = "0x6000110")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void OONMABADHAF(ACNEEEENOML AHGOPBJOELE);

	[Cpp2IlInjected.Token(Token = "0x6000111")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void MECFNGIPFAC(ACNEEEENOML AHGOPBJOELE);

	[Cpp2IlInjected.Token(Token = "0x6000112")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void OPGFFJKLKHF();
}
[Cpp2IlInjected.Token(Token = "0x200001A")]
public interface DMPEOOKGLDG
{
	[Cpp2IlInjected.Token(Token = "0x17000044")]
	bool AIFLGAACHML
	{
		[Cpp2IlInjected.Token(Token = "0x6000116")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x14000015")]
	event EBFBHNJDFMO KOMDEBFEEEP;

	[Cpp2IlInjected.Token(Token = "0x6000115")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void GPJJKLDHAFI();

	[Cpp2IlInjected.Token(Token = "0x6000117")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void JOKCPNGIIMH(object KIAKEGJPMAL);

	[Cpp2IlInjected.Token(Token = "0x6000118")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void CFLECLOAECH(object KIAKEGJPMAL);

	[Cpp2IlInjected.Token(Token = "0x6000119")]
	[Cpp2IlInjected.Address(Slot = "6")]
	void PHMJJJCNKII(object KIAKEGJPMAL, bool JMNDFKAOINO);

	[Cpp2IlInjected.Token(Token = "0x600011A")]
	[Cpp2IlInjected.Address(Slot = "7")]
	IDisposable HIJEMOJOGMK();

	[Cpp2IlInjected.Token(Token = "0x600011B")]
	[Cpp2IlInjected.Address(Slot = "8")]
	void DOIABHKLMHG(Rigidbody KFJMODPJOOA);

	[Cpp2IlInjected.Token(Token = "0x600011C")]
	[Cpp2IlInjected.Address(Slot = "9")]
	void HAKPNCDKJGA(Rigidbody JFKGLMKHADB);
}
[Cpp2IlInjected.Token(Token = "0x200001B")]
public interface DCKAOPOPPEM : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x17000045")]
	bool LFEOJFGHFML
	{
		[Cpp2IlInjected.Token(Token = "0x600011F")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000046")]
	bool NEIGPDMIINK
	{
		[Cpp2IlInjected.Token(Token = "0x6000120")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x14000016")]
	event EBFBHNJDFMO GILKHDKMEND;

	[Cpp2IlInjected.Token(Token = "0x6000121")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void BMFHLKIGOGD();

	[Cpp2IlInjected.Token(Token = "0x6000122")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void ACFBEMHJHMI(ACNEEEENOML OBIIIBPBMLD);

	[Cpp2IlInjected.Token(Token = "0x6000123")]
	[Cpp2IlInjected.Address(Slot = "6")]
	void DDKAOBEOLDP(ACNEEEENOML OBIIIBPBMLD);
}
[Cpp2IlInjected.Token(Token = "0x200001C")]
public interface GCEONIOPFOG
{
	[Cpp2IlInjected.Token(Token = "0x17000047")]
	bool JIAMCDEEBDI
	{
		[Cpp2IlInjected.Token(Token = "0x6000124")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
		[Cpp2IlInjected.Token(Token = "0x6000125")]
		[Cpp2IlInjected.Address(Slot = "1")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000048")]
	bool OHGMMHIOBGA
	{
		[Cpp2IlInjected.Token(Token = "0x6000126")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000049")]
	RigidbodyConstraints LKJNJPEFLGB
	{
		[Cpp2IlInjected.Token(Token = "0x6000127")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
		[Cpp2IlInjected.Token(Token = "0x6000128")]
		[Cpp2IlInjected.Address(Slot = "4")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x6000129")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void DOIABHKLMHG(Rigidbody JFKGLMKHADB);

	[Cpp2IlInjected.Token(Token = "0x600012A")]
	[Cpp2IlInjected.Address(Slot = "6")]
	void HAKPNCDKJGA(Rigidbody JFKGLMKHADB);
}
[Cpp2IlInjected.Token(Token = "0x200001D")]
public interface BMMIOFOJJEB
{
	[Cpp2IlInjected.Token(Token = "0x1700004A")]
	float EPNHAMDEIMB
	{
		[Cpp2IlInjected.Token(Token = "0x600012B")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
		[Cpp2IlInjected.Token(Token = "0x600012C")]
		[Cpp2IlInjected.Address(Slot = "1")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x1700004B")]
	float FJKLFMLIIEM
	{
		[Cpp2IlInjected.Token(Token = "0x600012D")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
		[Cpp2IlInjected.Token(Token = "0x600012E")]
		[Cpp2IlInjected.Address(Slot = "3")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x600012F")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void DOIABHKLMHG(Rigidbody JFKGLMKHADB);

	[Cpp2IlInjected.Token(Token = "0x6000130")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void HAKPNCDKJGA(Rigidbody JFKGLMKHADB);
}
[Cpp2IlInjected.Token(Token = "0x200001E")]
public interface LDPMIHCKDAJ
{
	[Cpp2IlInjected.Token(Token = "0x6000131")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void OnRootRBEXChanged(RigidbodyEx HJAMGEAMDOJ);
}
[Cpp2IlInjected.Token(Token = "0x200001F")]
public interface CCAMOPPOPEI
{
	[Cpp2IlInjected.Token(Token = "0x14000017")]
	event EBFBHNJDFMO CDIFNKKNIAI;

	[Cpp2IlInjected.Token(Token = "0x6000134")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void BMFHLKIGOGD();

	[Cpp2IlInjected.Token(Token = "0x6000135")]
	[Cpp2IlInjected.Address(Slot = "3")]
	bool ICIHJKDLIHF();

	[Cpp2IlInjected.Token(Token = "0x6000136")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void OPPINPEGPBG();

	[Cpp2IlInjected.Token(Token = "0x6000137")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void BHMFFCOHDEE();

	[Cpp2IlInjected.Token(Token = "0x6000138")]
	[Cpp2IlInjected.Address(Slot = "6")]
	void KNGOMHMODPL();

	[Cpp2IlInjected.Token(Token = "0x6000139")]
	[Cpp2IlInjected.Address(Slot = "7")]
	void JAEFDNECOPP();

	[Cpp2IlInjected.Token(Token = "0x600013A")]
	[Cpp2IlInjected.Address(Slot = "8")]
	void MMKNBNPGODE(bool IIBPGCHKBGC);
}
[Cpp2IlInjected.Token(Token = "0x2000020")]
public interface JGMBKBLBJEA
{
	[Cpp2IlInjected.Token(Token = "0x1700004C")]
	Rigidbody AIOLOONKHDH
	{
		[Cpp2IlInjected.Token(Token = "0x600013B")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700004D")]
	bool GFPPOAEOHBK
	{
		[Cpp2IlInjected.Token(Token = "0x600013D")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x600013C")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void BMFHLKIGOGD();

	[Cpp2IlInjected.Token(Token = "0x600013E")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void JBAEFNMGPHP(object KIAKEGJPMAL);

	[Cpp2IlInjected.Token(Token = "0x600013F")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void MODGFAKLIIP(object KIAKEGJPMAL);

	[Cpp2IlInjected.Token(Token = "0x6000140")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void OJCMDDNBENE();

	[Cpp2IlInjected.Token(Token = "0x6000141")]
	[Cpp2IlInjected.Address(Slot = "6")]
	void FGAAMJAJOOG();
}
[Cpp2IlInjected.Token(Token = "0x2000021")]
public interface LGAMKIPMADE : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x1700004E")]
	CPIKNIBKFKL GNLKAEJNEDB
	{
		[Cpp2IlInjected.Token(Token = "0x6000142")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
		[Cpp2IlInjected.Token(Token = "0x6000143")]
		[Cpp2IlInjected.Address(Slot = "1")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x1700004F")]
	OKPICPJMDEO JKKMJBKLALO
	{
		[Cpp2IlInjected.Token(Token = "0x6000144")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
		[Cpp2IlInjected.Token(Token = "0x6000145")]
		[Cpp2IlInjected.Address(Slot = "3")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000050")]
	Vector3 NBKAJOJDMMI
	{
		[Cpp2IlInjected.Token(Token = "0x6000146")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
		[Cpp2IlInjected.Token(Token = "0x6000147")]
		[Cpp2IlInjected.Address(Slot = "5")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000051")]
	Vector3 LAGBGBLAELJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000148")]
		[Cpp2IlInjected.Address(Slot = "6")]
		get;
		[Cpp2IlInjected.Token(Token = "0x6000149")]
		[Cpp2IlInjected.Address(Slot = "7")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000052")]
	Vector3 POIAGHOEFEB
	{
		[Cpp2IlInjected.Token(Token = "0x600014A")]
		[Cpp2IlInjected.Address(Slot = "8")]
		get;
		[Cpp2IlInjected.Token(Token = "0x600014B")]
		[Cpp2IlInjected.Address(Slot = "9")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000053")]
	Vector3 FFPCNDPLCPM
	{
		[Cpp2IlInjected.Token(Token = "0x600014C")]
		[Cpp2IlInjected.Address(Slot = "10")]
		get;
		[Cpp2IlInjected.Token(Token = "0x600014D")]
		[Cpp2IlInjected.Address(Slot = "11")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000054")]
	float ICPKIGJHHCD
	{
		[Cpp2IlInjected.Token(Token = "0x600014E")]
		[Cpp2IlInjected.Address(Slot = "12")]
		get;
		[Cpp2IlInjected.Token(Token = "0x600014F")]
		[Cpp2IlInjected.Address(Slot = "13")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000055")]
	bool KIEFCCGGPLM
	{
		[Cpp2IlInjected.Token(Token = "0x6000150")]
		[Cpp2IlInjected.Address(Slot = "14")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000151")]
	[Cpp2IlInjected.Address(Slot = "15")]
	void BMFHLKIGOGD();

	[Cpp2IlInjected.Token(Token = "0x6000152")]
	[Cpp2IlInjected.Address(Slot = "16")]
	void BAFPOBKCHMD(object KIAKEGJPMAL);

	[Cpp2IlInjected.Token(Token = "0x6000153")]
	[Cpp2IlInjected.Address(Slot = "17")]
	void AFAJHDMGFMF(LJGOMBGDPDM GJBGJOHBOBM, Vector3 GNFMGLELAKB, float JICJOBGCGOP = float.PositiveInfinity);

	[Cpp2IlInjected.Token(Token = "0x6000154")]
	[Cpp2IlInjected.Address(Slot = "18")]
	void CCOMMPLBNFB(BPNODJIJBLA KADKJKFHDBE, Vector3 MCCPDDLJGEG, float EGMGOJMNMKL, float FLCBFAEIBEI = 8f, float MMINJAGEDBL = 1f);

	[Cpp2IlInjected.Token(Token = "0x6000155")]
	[Cpp2IlInjected.Address(Slot = "19")]
	void MPMCBKEHDIK(LJGOMBGDPDM GJBGJOHBOBM, Vector3 OHMBDAJNEIJ, float GEPDJOHNEPN = 7f, float JINKMCECFKA = 1f);

	[Cpp2IlInjected.Token(Token = "0x6000156")]
	[Cpp2IlInjected.Address(Slot = "20")]
	void GAIPCILJLMB();

	[Cpp2IlInjected.Token(Token = "0x6000157")]
	[Cpp2IlInjected.Address(Slot = "21")]
	void ELAIKNOJDMF();

	[Cpp2IlInjected.Token(Token = "0x6000158")]
	[Cpp2IlInjected.Address(Slot = "22")]
	void JIMNECMIFKB();

	[Cpp2IlInjected.Token(Token = "0x6000159")]
	[Cpp2IlInjected.Address(Slot = "23")]
	void HPICNCAEGKH();

	[Cpp2IlInjected.Token(Token = "0x600015A")]
	[Cpp2IlInjected.Address(Slot = "24")]
	void DOIABHKLMHG(Rigidbody JFKGLMKHADB);

	[Cpp2IlInjected.Token(Token = "0x600015B")]
	[Cpp2IlInjected.Address(Slot = "25")]
	Vector3 EMEDMNCJCCM(Vector3 NOCGKJGODHL);

	[Cpp2IlInjected.Token(Token = "0x600015C")]
	[Cpp2IlInjected.Address(Slot = "26")]
	void CNCFJMCKEII(object KIAKEGJPMAL);

	[Cpp2IlInjected.Token(Token = "0x600015D")]
	[Cpp2IlInjected.Address(Slot = "27")]
	void OGHMBOLGHFB(Vector3 FJNLGGLHPIL);

	[Cpp2IlInjected.Token(Token = "0x600015E")]
	[Cpp2IlInjected.Address(Slot = "28")]
	void MDMIGCOMJCF(Vector3 JPNLAOHAPPM, Vector3 CHFCHAFCOBM);

	[Cpp2IlInjected.Token(Token = "0x600015F")]
	[Cpp2IlInjected.Address(Slot = "29")]
	void FOPGOBMGCOM(Vector3 HDFIANGNHPD, Vector3 OPNLLPIFKNP);

	[Cpp2IlInjected.Token(Token = "0x6000160")]
	[Cpp2IlInjected.Address(Slot = "30")]
	Vector3 OJGIMCLJCBO(Vector3 AMLAOHJLKAL);

	[Cpp2IlInjected.Token(Token = "0x6000161")]
	[Cpp2IlInjected.Address(Slot = "31")]
	Vector3 JOHAPINPNIG(Vector3 CPFDNDKFHHH);
}
[Cpp2IlInjected.Token(Token = "0x2000022")]
[PHKIPGBLCCH(PJHIMKBCGDP.Application)]
public interface JFOPDBBEICP
{
	[Cpp2IlInjected.Token(Token = "0x17000056")]
	bool PCAJPDAOMGC
	{
		[Cpp2IlInjected.Token(Token = "0x6000162")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000163")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void FIGHIEPAKPO(string HLPKEEDLIBL);

	[Cpp2IlInjected.Token(Token = "0x6000164")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void DPFLPAJBCAN(RigidbodyEx AHGOPBJOELE, Action OONIIOMBHJI);

	[Cpp2IlInjected.Token(Token = "0x6000165")]
	[Cpp2IlInjected.Address(Slot = "3")]
	BMACFOJPCPM EJPKNPOEFHP(int JDPFEOMAPCB);

	[Cpp2IlInjected.Token(Token = "0x6000166")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void LCMNMGNPAFG(Vector3 BCJKOGIBLJJ, float KFALDNLFOPK, Color MOJKBHCPNEF);
}
[Cpp2IlInjected.Token(Token = "0x2000023")]
[PHKIPGBLCCH(PJHIMKBCGDP.Application)]
public interface HGMBJJHEAKJ
{
	[Cpp2IlInjected.Token(Token = "0x17000057")]
	JFOPDBBEICP JAIBLGKGHED
	{
		[Cpp2IlInjected.Token(Token = "0x6000167")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000058")]
	MIAHMAGCEAF CJMIFCIPBNF
	{
		[Cpp2IlInjected.Token(Token = "0x6000168")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000169")]
	[Cpp2IlInjected.Address(Slot = "2")]
	INJNNPDEJLM GKGJCBCGHLJ(RigidbodyEx AHGOPBJOELE);

	[Cpp2IlInjected.Token(Token = "0x600016A")]
	[Cpp2IlInjected.Address(Slot = "3")]
	ACNEEEENOML GAFOKFHHMAF(RigidbodyEx AHGOPBJOELE, ACDBPOHPAKH AELCABDCBDD);
}
[Cpp2IlInjected.Token(Token = "0x2000024")]
public interface OKPICPJMDEO
{
	[Cpp2IlInjected.Token(Token = "0x600016B")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void HOHFNBHAKOA(Vector3 NHDDBEGKBMN);

	[Cpp2IlInjected.Token(Token = "0x600016C")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void KGNMMCGBPJC(Vector3 NMAGMMAOJAD);

	[Cpp2IlInjected.Token(Token = "0x600016D")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void JCEGMIHEPHD(Vector3 NHDDBEGKBMN);

	[Cpp2IlInjected.Token(Token = "0x600016E")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void OGDDDMBLINL(Vector3 NMAGMMAOJAD);
}
[Cpp2IlInjected.Token(Token = "0x2000025")]
public interface CPIKNIBKFKL : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x600016F")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Vector3 NGGKHGLLJJM();

	[Cpp2IlInjected.Token(Token = "0x6000170")]
	[Cpp2IlInjected.Address(Slot = "1")]
	Vector3 OOGKEFBBBJM();
}
[Cpp2IlInjected.Token(Token = "0x2000026")]
public interface ACNEEEENOML : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x17000059")]
	Rigidbody AIOLOONKHDH
	{
		[Cpp2IlInjected.Token(Token = "0x6000171")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700005A")]
	RigidbodyEx PCBHPDJNNIB
	{
		[Cpp2IlInjected.Token(Token = "0x6000172")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700005B")]
	GameObject MLINCMAHJGP
	{
		[Cpp2IlInjected.Token(Token = "0x6000173")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700005C")]
	Transform BDOKOMBLFFF
	{
		[Cpp2IlInjected.Token(Token = "0x6000174")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700005D")]
	ACNEEEENOML MLDLDJMPPGN
	{
		[Cpp2IlInjected.Token(Token = "0x6000175")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
		[Cpp2IlInjected.Token(Token = "0x6000176")]
		[Cpp2IlInjected.Address(Slot = "5")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x1700005E")]
	IReadOnlyList<ACNEEEENOML> FKAHMBHHHJN
	{
		[Cpp2IlInjected.Token(Token = "0x6000177")]
		[Cpp2IlInjected.Address(Slot = "6")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700005F")]
	ACNEEEENOML IDPDODAHCDH
	{
		[Cpp2IlInjected.Token(Token = "0x6000178")]
		[Cpp2IlInjected.Address(Slot = "7")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000060")]
	bool LFEOJFGHFML
	{
		[Cpp2IlInjected.Token(Token = "0x6000179")]
		[Cpp2IlInjected.Address(Slot = "8")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000061")]
	bool NEIGPDMIINK
	{
		[Cpp2IlInjected.Token(Token = "0x600017A")]
		[Cpp2IlInjected.Address(Slot = "9")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000062")]
	CPIKNIBKFKL GNLKAEJNEDB
	{
		[Cpp2IlInjected.Token(Token = "0x600017B")]
		[Cpp2IlInjected.Address(Slot = "10")]
		get;
		[Cpp2IlInjected.Token(Token = "0x600017C")]
		[Cpp2IlInjected.Address(Slot = "11")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000063")]
	OKPICPJMDEO JKKMJBKLALO
	{
		[Cpp2IlInjected.Token(Token = "0x600017D")]
		[Cpp2IlInjected.Address(Slot = "12")]
		get;
		[Cpp2IlInjected.Token(Token = "0x600017E")]
		[Cpp2IlInjected.Address(Slot = "13")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000064")]
	float ICPKIGJHHCD
	{
		[Cpp2IlInjected.Token(Token = "0x600017F")]
		[Cpp2IlInjected.Address(Slot = "14")]
		get;
		[Cpp2IlInjected.Token(Token = "0x6000180")]
		[Cpp2IlInjected.Address(Slot = "15")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000065")]
	Vector3 LAGBGBLAELJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000181")]
		[Cpp2IlInjected.Address(Slot = "16")]
		get;
		[Cpp2IlInjected.Token(Token = "0x6000182")]
		[Cpp2IlInjected.Address(Slot = "17")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000066")]
	Vector3 FFPCNDPLCPM
	{
		[Cpp2IlInjected.Token(Token = "0x6000183")]
		[Cpp2IlInjected.Address(Slot = "18")]
		get;
		[Cpp2IlInjected.Token(Token = "0x6000184")]
		[Cpp2IlInjected.Address(Slot = "19")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000067")]
	Vector3 NBKAJOJDMMI
	{
		[Cpp2IlInjected.Token(Token = "0x6000185")]
		[Cpp2IlInjected.Address(Slot = "20")]
		get;
		[Cpp2IlInjected.Token(Token = "0x6000186")]
		[Cpp2IlInjected.Address(Slot = "21")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000068")]
	Vector3 POIAGHOEFEB
	{
		[Cpp2IlInjected.Token(Token = "0x6000187")]
		[Cpp2IlInjected.Address(Slot = "22")]
		get;
		[Cpp2IlInjected.Token(Token = "0x6000188")]
		[Cpp2IlInjected.Address(Slot = "23")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000069")]
	bool PCBADJMLDFE
	{
		[Cpp2IlInjected.Token(Token = "0x6000189")]
		[Cpp2IlInjected.Address(Slot = "24")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700006A")]
	bool KJEMIFCOIFF
	{
		[Cpp2IlInjected.Token(Token = "0x600018A")]
		[Cpp2IlInjected.Address(Slot = "25")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700006B")]
	bool KIEFCCGGPLM
	{
		[Cpp2IlInjected.Token(Token = "0x600018B")]
		[Cpp2IlInjected.Address(Slot = "26")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700006C")]
	Vector3 EEEHLJDAFJK
	{
		[Cpp2IlInjected.Token(Token = "0x600018C")]
		[Cpp2IlInjected.Address(Slot = "27")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700006D")]
	Vector3 JDGLCEIOOBF
	{
		[Cpp2IlInjected.Token(Token = "0x600018D")]
		[Cpp2IlInjected.Address(Slot = "28")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700006E")]
	Vector3 LBFLJMHMJDO
	{
		[Cpp2IlInjected.Token(Token = "0x600018E")]
		[Cpp2IlInjected.Address(Slot = "29")]
		get;
		[Cpp2IlInjected.Token(Token = "0x600018F")]
		[Cpp2IlInjected.Address(Slot = "30")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x1700006F")]
	Vector3 CCEGGEBAGNO
	{
		[Cpp2IlInjected.Token(Token = "0x6000190")]
		[Cpp2IlInjected.Address(Slot = "31")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000070")]
	float FDPCBODPJHG
	{
		[Cpp2IlInjected.Token(Token = "0x6000191")]
		[Cpp2IlInjected.Address(Slot = "32")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000071")]
	float PFMNCEKEBOC
	{
		[Cpp2IlInjected.Token(Token = "0x6000192")]
		[Cpp2IlInjected.Address(Slot = "33")]
		get;
		[Cpp2IlInjected.Token(Token = "0x6000193")]
		[Cpp2IlInjected.Address(Slot = "34")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000072")]
	Vector3 ONJLJDCPIMM
	{
		[Cpp2IlInjected.Token(Token = "0x6000194")]
		[Cpp2IlInjected.Address(Slot = "35")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000073")]
	Quaternion EKDPJMOLPAE
	{
		[Cpp2IlInjected.Token(Token = "0x6000195")]
		[Cpp2IlInjected.Address(Slot = "36")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000074")]
	float EPNHAMDEIMB
	{
		[Cpp2IlInjected.Token(Token = "0x6000197")]
		[Cpp2IlInjected.Address(Slot = "38")]
		get;
		[Cpp2IlInjected.Token(Token = "0x6000198")]
		[Cpp2IlInjected.Address(Slot = "39")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000075")]
	float FJKLFMLIIEM
	{
		[Cpp2IlInjected.Token(Token = "0x6000199")]
		[Cpp2IlInjected.Address(Slot = "40")]
		get;
		[Cpp2IlInjected.Token(Token = "0x600019A")]
		[Cpp2IlInjected.Address(Slot = "41")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000076")]
	bool DAFMFMBFKBE
	{
		[Cpp2IlInjected.Token(Token = "0x600019B")]
		[Cpp2IlInjected.Address(Slot = "42")]
		get;
		[Cpp2IlInjected.Token(Token = "0x600019C")]
		[Cpp2IlInjected.Address(Slot = "43")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000077")]
	ABDACCGDOPN FADDMLIMLLG
	{
		[Cpp2IlInjected.Token(Token = "0x600019D")]
		[Cpp2IlInjected.Address(Slot = "44")]
		get;
		[Cpp2IlInjected.Token(Token = "0x600019E")]
		[Cpp2IlInjected.Address(Slot = "45")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000078")]
	bool AIFLGAACHML
	{
		[Cpp2IlInjected.Token(Token = "0x600019F")]
		[Cpp2IlInjected.Address(Slot = "46")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000079")]
	Transform FHODNODINAI
	{
		[Cpp2IlInjected.Token(Token = "0x60001A0")]
		[Cpp2IlInjected.Address(Slot = "47")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700007A")]
	Vector3 KDEBKPHAANG
	{
		[Cpp2IlInjected.Token(Token = "0x60001A1")]
		[Cpp2IlInjected.Address(Slot = "48")]
		get;
		[Cpp2IlInjected.Token(Token = "0x60001A2")]
		[Cpp2IlInjected.Address(Slot = "49")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x1700007B")]
	float JBNHCEBOIMF
	{
		[Cpp2IlInjected.Token(Token = "0x60001A3")]
		[Cpp2IlInjected.Address(Slot = "50")]
		get;
		[Cpp2IlInjected.Token(Token = "0x60001A4")]
		[Cpp2IlInjected.Address(Slot = "51")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x1700007C")]
	float PAMDAKFFDPC
	{
		[Cpp2IlInjected.Token(Token = "0x60001A5")]
		[Cpp2IlInjected.Address(Slot = "52")]
		get;
		[Cpp2IlInjected.Token(Token = "0x60001A6")]
		[Cpp2IlInjected.Address(Slot = "53")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x1700007D")]
	Quaternion ELDJEJICFFN
	{
		[Cpp2IlInjected.Token(Token = "0x60001A7")]
		[Cpp2IlInjected.Address(Slot = "54")]
		get;
		[Cpp2IlInjected.Token(Token = "0x60001A8")]
		[Cpp2IlInjected.Address(Slot = "55")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x1700007E")]
	Vector3 MJCFJPNCBDO
	{
		[Cpp2IlInjected.Token(Token = "0x60001A9")]
		[Cpp2IlInjected.Address(Slot = "56")]
		get;
		[Cpp2IlInjected.Token(Token = "0x60001AA")]
		[Cpp2IlInjected.Address(Slot = "57")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x1700007F")]
	Quaternion CGLJKEJLMFK
	{
		[Cpp2IlInjected.Token(Token = "0x60001AB")]
		[Cpp2IlInjected.Address(Slot = "58")]
		get;
		[Cpp2IlInjected.Token(Token = "0x60001AC")]
		[Cpp2IlInjected.Address(Slot = "59")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000080")]
	RigidbodyConstraints LKJNJPEFLGB
	{
		[Cpp2IlInjected.Token(Token = "0x60001AD")]
		[Cpp2IlInjected.Address(Slot = "60")]
		get;
		[Cpp2IlInjected.Token(Token = "0x60001AE")]
		[Cpp2IlInjected.Address(Slot = "61")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000081")]
	bool JIAMCDEEBDI
	{
		[Cpp2IlInjected.Token(Token = "0x60001AF")]
		[Cpp2IlInjected.Address(Slot = "62")]
		get;
		[Cpp2IlInjected.Token(Token = "0x60001B0")]
		[Cpp2IlInjected.Address(Slot = "63")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000082")]
	CollisionDetectionMode EJKKFAEAAME
	{
		[Cpp2IlInjected.Token(Token = "0x60001B1")]
		[Cpp2IlInjected.Address(Slot = "64")]
		get;
		[Cpp2IlInjected.Token(Token = "0x60001B2")]
		[Cpp2IlInjected.Address(Slot = "65")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000083")]
	bool HDHFPOGMJNC
	{
		[Cpp2IlInjected.Token(Token = "0x60001B3")]
		[Cpp2IlInjected.Address(Slot = "66")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x14000018")]
	event EBFBHNJDFMO PAAEJBNAELP;

	[Cpp2IlInjected.Token(Token = "0x14000019")]
	event EBFBHNJDFMO ANLGMIPOGHH;

	[Cpp2IlInjected.Token(Token = "0x1400001A")]
	event GHEEFDJOPPC GDBIGLFOIGG;

	[Cpp2IlInjected.Token(Token = "0x1400001B")]
	event EBFBHNJDFMO GILKHDKMEND;

	[Cpp2IlInjected.Token(Token = "0x1400001C")]
	event EBFBHNJDFMO PPOOMLEKHLL;

	[Cpp2IlInjected.Token(Token = "0x1400001D")]
	event EBFBHNJDFMO CDIFNKKNIAI;

	[Cpp2IlInjected.Token(Token = "0x1400001E")]
	event Action<LMALNIIPHAC, LMALNIIPHAC> ENBBGJAGBJJ;

	[Cpp2IlInjected.Token(Token = "0x1400001F")]
	event EBFBHNJDFMO KOMDEBFEEEP;

	[Cpp2IlInjected.Token(Token = "0x14000020")]
	event EBFBHNJDFMO NDADBNMCKJG;

	[Cpp2IlInjected.Token(Token = "0x6000196")]
	[Cpp2IlInjected.Address(Slot = "37")]
	void HFHDCMEIKAH((Quaternion rot, Vector3 moments) MOGJAEMHOKI);

	[Cpp2IlInjected.Token(Token = "0x60001B4")]
	[Cpp2IlInjected.Address(Slot = "67")]
	void BMFHLKIGOGD();

	[Cpp2IlInjected.Token(Token = "0x60001B5")]
	[Cpp2IlInjected.Address(Slot = "68")]
	void LKJFMPHLLAI();

	[Cpp2IlInjected.Token(Token = "0x60001B6")]
	[Cpp2IlInjected.Address(Slot = "69")]
	void IKAJDAOJONJ();

	[Cpp2IlInjected.Token(Token = "0x60001B7")]
	[Cpp2IlInjected.Address(Slot = "70")]
	void BHMFFCOHDEE();

	[Cpp2IlInjected.Token(Token = "0x60001BE")]
	[Cpp2IlInjected.Address(Slot = "77")]
	void JLJFDADNEME(ACNEEEENOML FKKGMPDEPMA, bool CGKOADMHFLC = false);

	[Cpp2IlInjected.Token(Token = "0x60001C1")]
	[Cpp2IlInjected.Address(Slot = "80")]
	void JAFBLGBFIGL(object KIAKEGJPMAL);

	[Cpp2IlInjected.Token(Token = "0x60001C2")]
	[Cpp2IlInjected.Address(Slot = "81")]
	void KLHEGIFEBJI(object KIAKEGJPMAL);

	[Cpp2IlInjected.Token(Token = "0x60001C3")]
	[Cpp2IlInjected.Address(Slot = "82")]
	Vector3 JOHAPINPNIG(Vector3 CPFDNDKFHHH);

	[Cpp2IlInjected.Token(Token = "0x60001C4")]
	[Cpp2IlInjected.Address(Slot = "83")]
	Vector3 OJGIMCLJCBO(Vector3 AMLAOHJLKAL);

	[Cpp2IlInjected.Token(Token = "0x60001C5")]
	[Cpp2IlInjected.Address(Slot = "84")]
	void HPICNCAEGKH();

	[Cpp2IlInjected.Token(Token = "0x60001C6")]
	[Cpp2IlInjected.Address(Slot = "85")]
	void ELAIKNOJDMF();

	[Cpp2IlInjected.Token(Token = "0x60001C7")]
	[Cpp2IlInjected.Address(Slot = "86")]
	void GAIPCILJLMB();

	[Cpp2IlInjected.Token(Token = "0x60001C8")]
	[Cpp2IlInjected.Address(Slot = "87")]
	void FOPGOBMGCOM(Vector3 HDFIANGNHPD, Vector3 OPNLLPIFKNP);

	[Cpp2IlInjected.Token(Token = "0x60001C9")]
	[Cpp2IlInjected.Address(Slot = "88")]
	void MDMIGCOMJCF(Vector3 JPNLAOHAPPM, Vector3 CHFCHAFCOBM);

	[Cpp2IlInjected.Token(Token = "0x60001CA")]
	[Cpp2IlInjected.Address(Slot = "89")]
	void OGHMBOLGHFB(Vector3 FJNLGGLHPIL);

	[Cpp2IlInjected.Token(Token = "0x60001CB")]
	[Cpp2IlInjected.Address(Slot = "90")]
	void CCOMMPLBNFB(BPNODJIJBLA KADKJKFHDBE, Vector3 MCCPDDLJGEG, float EGMGOJMNMKL, float FLCBFAEIBEI = 8f, float MMINJAGEDBL = 1f);

	[Cpp2IlInjected.Token(Token = "0x60001CC")]
	[Cpp2IlInjected.Address(Slot = "91")]
	void AFAJHDMGFMF(LJGOMBGDPDM GJBGJOHBOBM, Vector3 GNFMGLELAKB, float JICJOBGCGOP = float.PositiveInfinity);

	[Cpp2IlInjected.Token(Token = "0x60001CD")]
	[Cpp2IlInjected.Address(Slot = "92")]
	void MPMCBKEHDIK(LJGOMBGDPDM GJBGJOHBOBM, Vector3 OHMBDAJNEIJ, float GEPDJOHNEPN = 7f, float JINKMCECFKA = 1f);

	[Cpp2IlInjected.Token(Token = "0x60001CE")]
	[Cpp2IlInjected.Address(Slot = "93")]
	Vector3 EMEDMNCJCCM(Vector3 FKKGMPDEPMA);

	[Cpp2IlInjected.Token(Token = "0x60001CF")]
	[Cpp2IlInjected.Address(Slot = "94")]
	Vector3 AFNJAEPBIFC(Vector3 FKKGMPDEPMA);

	[Cpp2IlInjected.Token(Token = "0x60001D0")]
	[Cpp2IlInjected.Address(Slot = "95")]
	void JIMNECMIFKB();

	[Cpp2IlInjected.Token(Token = "0x60001D1")]
	[Cpp2IlInjected.Address(Slot = "96")]
	void DGFANBIPFEE(ACNEEEENOML FFGBMPIEMIB, object KIAKEGJPMAL);

	[Cpp2IlInjected.Token(Token = "0x60001D2")]
	[Cpp2IlInjected.Address(Slot = "97")]
	void DCFJHAGIOEM(object KIAKEGJPMAL);

	[Cpp2IlInjected.Token(Token = "0x60001D5")]
	[Cpp2IlInjected.Address(Slot = "100")]
	void ALFIJHNHMBG();

	[Cpp2IlInjected.Token(Token = "0x60001D6")]
	[Cpp2IlInjected.Address(Slot = "101")]
	void AECDOEBBECA();

	[Cpp2IlInjected.Token(Token = "0x60001D7")]
	[Cpp2IlInjected.Address(Slot = "102")]
	void PFMKNBPMAJC();

	[Cpp2IlInjected.Token(Token = "0x60001DA")]
	[Cpp2IlInjected.Address(Slot = "105")]
	bool ICIHJKDLIHF();

	[Cpp2IlInjected.Token(Token = "0x60001DB")]
	[Cpp2IlInjected.Address(Slot = "106")]
	void JAEFDNECOPP();

	[Cpp2IlInjected.Token(Token = "0x60001E0")]
	[Cpp2IlInjected.Address(Slot = "111")]
	IDisposable HIJEMOJOGMK();

	[Cpp2IlInjected.Token(Token = "0x60001E1")]
	[Cpp2IlInjected.Address(Slot = "112")]
	void JOKCPNGIIMH(object KIAKEGJPMAL);

	[Cpp2IlInjected.Token(Token = "0x60001E2")]
	[Cpp2IlInjected.Address(Slot = "113")]
	void CFLECLOAECH(object KIAKEGJPMAL);

	[Cpp2IlInjected.Token(Token = "0x60001E3")]
	[Cpp2IlInjected.Address(Slot = "114")]
	void PHMJJJCNKII(object KIAKEGJPMAL, bool JMNDFKAOINO);

	[Cpp2IlInjected.Token(Token = "0x60001E6")]
	[Cpp2IlInjected.Address(Slot = "117")]
	void JLBDGAIPDBF(Vector3 AAMDDKIBNEM, Quaternion AHHDHIOJLHB);

	[Cpp2IlInjected.Token(Token = "0x60001E7")]
	[Cpp2IlInjected.Address(Slot = "118")]
	void MBKDHNHMLBH(Vector3 LHHPNCJCHFD, Quaternion CDONFJKGJGK);

	[Cpp2IlInjected.Token(Token = "0x60001E8")]
	[Cpp2IlInjected.Address(Slot = "119")]
	bool CACNNIFAFBA(float JJLGAOMIEEO);

	[Cpp2IlInjected.Token(Token = "0x60001E9")]
	[Cpp2IlInjected.Address(Slot = "120")]
	void AGDOBNJPBGB(object KIAKEGJPMAL);

	[Cpp2IlInjected.Token(Token = "0x60001EA")]
	[Cpp2IlInjected.Address(Slot = "121")]
	void FPLFJLMJDOL(object KIAKEGJPMAL);

	[Cpp2IlInjected.Token(Token = "0x60001EB")]
	[Cpp2IlInjected.Address(Slot = "122")]
	void JBAEFNMGPHP(object KIAKEGJPMAL);

	[Cpp2IlInjected.Token(Token = "0x60001EC")]
	[Cpp2IlInjected.Address(Slot = "123")]
	void MODGFAKLIIP(object KIAKEGJPMAL);

	[Cpp2IlInjected.Token(Token = "0x60001ED")]
	[Cpp2IlInjected.Address(Slot = "124")]
	void EGEGKPJLIKO(Vector3 AKFFELDLHDA, ForceMode ACFLBCIEBAA = ForceMode.Force);

	[Cpp2IlInjected.Token(Token = "0x60001EE")]
	[Cpp2IlInjected.Address(Slot = "125")]
	void NOAIHMJOFMI(Vector3 AKFFELDLHDA, Vector3 MCLBBPPAHAP, ForceMode ACFLBCIEBAA);

	[Cpp2IlInjected.Token(Token = "0x60001EF")]
	[Cpp2IlInjected.Address(Slot = "126")]
	void JHDOIGEAHPA(Vector3 FNPOFGBLJMD, ForceMode ACFLBCIEBAA = ForceMode.Force);

	[Cpp2IlInjected.Token(Token = "0x60001F0")]
	[Cpp2IlInjected.Address(Slot = "127")]
	void INFGEGJJGIJ(Vector3 FNPOFGBLJMD, ForceMode ACFLBCIEBAA = ForceMode.Force);

	[Cpp2IlInjected.Token(Token = "0x60001F1")]
	[Cpp2IlInjected.Address(Slot = "128")]
	bool HOKBEJGNALC(Vector3 GJMNPFFBJPA, [Out] RaycastHit LGAEEAFDDFJ, float LNHOFLIBFND);

	[Cpp2IlInjected.Token(Token = "0x60001F2")]
	[Cpp2IlInjected.Address(Slot = "129")]
	void FCAHOLPEHIP();
}
[Cpp2IlInjected.Token(Token = "0x2000027")]
public class ALHCFOHGNMD : ACNEEEENOML, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400002C")]
	internal readonly HGMBJJHEAKJ PNFHHOFJABN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400002D")]
	internal PMHIGDLAJOP DEIGKNMHENH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400002E")]
	internal CFLOPMDOLBK DENEGFMFHAI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400002F")]
	internal DCKAOPOPPEM KOJOEBGFGAH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000030")]
	internal LGAMKIPMADE NOCGKJGODHL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000031")]
	internal LMDEEHLJMOK KGEFPLBHAEJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000032")]
	internal KFKLGADFDEA BMHPMKABANG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000033")]
	internal BMMIOFOJJEB HCDOKCEMCCJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000034")]
	internal HEEAIGPCPDE LMMGFDNIEOF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x4000035")]
	internal CCAMOPPOPEI NIDCPGCKEOI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x4000036")]
	internal MCEBLIDMGME LLGGDMIKNIK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x4000037")]
	internal DMPEOOKGLDG NJOAJGHCOFG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x4000038")]
	internal AICDKPBPOFE AKFFELDLHDA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
	[Cpp2IlInjected.Token(Token = "0x4000039")]
	internal GCEONIOPFOG PKPHFNPPOIC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x400003A")]
	internal JGMBKBLBJEA JFKGLMKHADB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
	[Cpp2IlInjected.Token(Token = "0x400003B")]
	internal NDKMMOHJIND CDAPDJIBAIO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
	[Cpp2IlInjected.Token(Token = "0x400003C")]
	internal IDisposable JGJPOAABPCJ;

	[Cpp2IlInjected.Token(Token = "0x17000084")]
	public RigidbodyEx PCBHPDJNNIB
	{
		[Cpp2IlInjected.Token(Token = "0x60001F3")]
		[Cpp2IlInjected.Address(RVA = "0x768E20", Offset = "0x767620", VA = "0x180768E20", Slot = "5")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60001F4")]
		[Cpp2IlInjected.Address(RVA = "0x768DE0", Offset = "0x7675E0", VA = "0x180768DE0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000085")]
	public GameObject MLINCMAHJGP
	{
		[Cpp2IlInjected.Token(Token = "0x60001F5")]
		[Cpp2IlInjected.Address(RVA = "0x8A33B0", Offset = "0x8A1BB0", VA = "0x1808A33B0", Slot = "6")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60001F6")]
		[Cpp2IlInjected.Address(RVA = "0x8A3700", Offset = "0x8A1F00", VA = "0x1808A3700")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000086")]
	public Transform BDOKOMBLFFF
	{
		[Cpp2IlInjected.Token(Token = "0x60001F7")]
		[Cpp2IlInjected.Address(RVA = "0x620FDD0", Offset = "0x620E5D0", VA = "0x18620FDD0", Slot = "7")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000087")]
	public Rigidbody AIOLOONKHDH
	{
		[Cpp2IlInjected.Token(Token = "0x60001F8")]
		[Cpp2IlInjected.Address(RVA = "0x620EDE0", Offset = "0x620D5E0", VA = "0x18620EDE0", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000088")]
	public ACNEEEENOML MLDLDJMPPGN
	{
		[Cpp2IlInjected.Token(Token = "0x6000206")]
		[Cpp2IlInjected.Address(RVA = "0x620CC80", Offset = "0x620B480", VA = "0x18620CC80", Slot = "8")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000207")]
		[Cpp2IlInjected.Address(RVA = "0x62112B0", Offset = "0x620FAB0", VA = "0x1862112B0", Slot = "9")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000089")]
	public IReadOnlyList<ACNEEEENOML> FKAHMBHHHJN
	{
		[Cpp2IlInjected.Token(Token = "0x6000208")]
		[Cpp2IlInjected.Address(RVA = "0x6210D70", Offset = "0x620F570", VA = "0x186210D70", Slot = "10")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700008A")]
	public ACNEEEENOML IDPDODAHCDH
	{
		[Cpp2IlInjected.Token(Token = "0x6000209")]
		[Cpp2IlInjected.Address(RVA = "0x620E8F0", Offset = "0x620D0F0", VA = "0x18620E8F0", Slot = "11")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700008B")]
	public bool IDEKMMEBDBI
	{
		[Cpp2IlInjected.Token(Token = "0x600020A")]
		[Cpp2IlInjected.Address(RVA = "0x62115B0", Offset = "0x620FDB0", VA = "0x1862115B0", Slot = "137")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700008C")]
	public bool LFEOJFGHFML
	{
		[Cpp2IlInjected.Token(Token = "0x600020E")]
		[Cpp2IlInjected.Address(RVA = "0x6211480", Offset = "0x620FC80", VA = "0x186211480", Slot = "12")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700008D")]
	public bool NEIGPDMIINK
	{
		[Cpp2IlInjected.Token(Token = "0x600020F")]
		[Cpp2IlInjected.Address(RVA = "0x6210DC0", Offset = "0x620F5C0", VA = "0x186210DC0", Slot = "13")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700008E")]
	public CPIKNIBKFKL GNLKAEJNEDB
	{
		[Cpp2IlInjected.Token(Token = "0x6000210")]
		[Cpp2IlInjected.Address(RVA = "0x620DE70", Offset = "0x620C670", VA = "0x18620DE70", Slot = "14")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000211")]
		[Cpp2IlInjected.Address(RVA = "0x620CE20", Offset = "0x620B620", VA = "0x18620CE20", Slot = "15")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700008F")]
	public OKPICPJMDEO JKKMJBKLALO
	{
		[Cpp2IlInjected.Token(Token = "0x6000212")]
		[Cpp2IlInjected.Address(RVA = "0x620CCD0", Offset = "0x620B4D0", VA = "0x18620CCD0", Slot = "16")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000213")]
		[Cpp2IlInjected.Address(RVA = "0x62105F0", Offset = "0x620EDF0", VA = "0x1862105F0", Slot = "17")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000090")]
	public float ICPKIGJHHCD
	{
		[Cpp2IlInjected.Token(Token = "0x6000214")]
		[Cpp2IlInjected.Address(RVA = "0x6210C30", Offset = "0x620F430", VA = "0x186210C30", Slot = "18")]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x6000215")]
		[Cpp2IlInjected.Address(RVA = "0x620DDD0", Offset = "0x620C5D0", VA = "0x18620DDD0", Slot = "19")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000091")]
	public Vector3 LAGBGBLAELJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000216")]
		[Cpp2IlInjected.Address(RVA = "0x62114D0", Offset = "0x620FCD0", VA = "0x1862114D0", Slot = "20")]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x6000217")]
		[Cpp2IlInjected.Address(RVA = "0x6210220", Offset = "0x620EA20", VA = "0x186210220", Slot = "21")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000092")]
	public Vector3 FFPCNDPLCPM
	{
		[Cpp2IlInjected.Token(Token = "0x6000218")]
		[Cpp2IlInjected.Address(RVA = "0x6211610", Offset = "0x620FE10", VA = "0x186211610", Slot = "22")]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x6000219")]
		[Cpp2IlInjected.Address(RVA = "0x620DF10", Offset = "0x620C710", VA = "0x18620DF10", Slot = "23")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000093")]
	public Vector3 NBKAJOJDMMI
	{
		[Cpp2IlInjected.Token(Token = "0x600021A")]
		[Cpp2IlInjected.Address(RVA = "0x6210720", Offset = "0x620EF20", VA = "0x186210720", Slot = "24")]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x600021B")]
		[Cpp2IlInjected.Address(RVA = "0x620F820", Offset = "0x620E020", VA = "0x18620F820", Slot = "25")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000094")]
	public Vector3 POIAGHOEFEB
	{
		[Cpp2IlInjected.Token(Token = "0x600021C")]
		[Cpp2IlInjected.Address(RVA = "0x620CBA0", Offset = "0x620B3A0", VA = "0x18620CBA0", Slot = "26")]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x600021D")]
		[Cpp2IlInjected.Address(RVA = "0x620D380", Offset = "0x620BB80", VA = "0x18620D380", Slot = "27")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000095")]
	public bool OJIENIPMIAF
	{
		[Cpp2IlInjected.Token(Token = "0x600021E")]
		[Cpp2IlInjected.Address(RVA = "0x62105A0", Offset = "0x620EDA0", VA = "0x1862105A0", Slot = "138")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000096")]
	public bool PCBADJMLDFE
	{
		[Cpp2IlInjected.Token(Token = "0x600021F")]
		[Cpp2IlInjected.Address(RVA = "0x620D160", Offset = "0x620B960", VA = "0x18620D160", Slot = "28")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000097")]
	public bool KJEMIFCOIFF
	{
		[Cpp2IlInjected.Token(Token = "0x6000220")]
		[Cpp2IlInjected.Address(RVA = "0x620EF80", Offset = "0x620D780", VA = "0x18620EF80", Slot = "29")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000098")]
	public bool KIEFCCGGPLM
	{
		[Cpp2IlInjected.Token(Token = "0x6000221")]
		[Cpp2IlInjected.Address(RVA = "0x620D220", Offset = "0x620BA20", VA = "0x18620D220", Slot = "30")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000099")]
	public Vector3 EEEHLJDAFJK
	{
		[Cpp2IlInjected.Token(Token = "0x6000232")]
		[Cpp2IlInjected.Address(RVA = "0x62122B0", Offset = "0x6210AB0", VA = "0x1862122B0", Slot = "31")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700009A")]
	public Vector3 JDGLCEIOOBF
	{
		[Cpp2IlInjected.Token(Token = "0x6000233")]
		[Cpp2IlInjected.Address(RVA = "0x6211DC0", Offset = "0x62105C0", VA = "0x186211DC0", Slot = "32")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700009B")]
	public Vector3 LBFLJMHMJDO
	{
		[Cpp2IlInjected.Token(Token = "0x6000238")]
		[Cpp2IlInjected.Address(RVA = "0x620F6F0", Offset = "0x620DEF0", VA = "0x18620F6F0", Slot = "33")]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x6000239")]
		[Cpp2IlInjected.Address(RVA = "0x620C8C0", Offset = "0x620B0C0", VA = "0x18620C8C0", Slot = "34")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700009C")]
	public Vector3 CCEGGEBAGNO
	{
		[Cpp2IlInjected.Token(Token = "0x600023A")]
		[Cpp2IlInjected.Address(RVA = "0x620EC40", Offset = "0x620D440", VA = "0x18620EC40", Slot = "35")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700009D")]
	public float FDPCBODPJHG
	{
		[Cpp2IlInjected.Token(Token = "0x600023B")]
		[Cpp2IlInjected.Address(RVA = "0x620CA00", Offset = "0x620B200", VA = "0x18620CA00", Slot = "36")]
		get
		{
			return default(float);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700009E")]
	public float PFMNCEKEBOC
	{
		[Cpp2IlInjected.Token(Token = "0x600023C")]
		[Cpp2IlInjected.Address(RVA = "0x620DFF0", Offset = "0x620C7F0", VA = "0x18620DFF0", Slot = "37")]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x600023D")]
		[Cpp2IlInjected.Address(RVA = "0x6210360", Offset = "0x620EB60", VA = "0x186210360", Slot = "38")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700009F")]
	public Vector3 ONJLJDCPIMM
	{
		[Cpp2IlInjected.Token(Token = "0x600023E")]
		[Cpp2IlInjected.Address(RVA = "0x620E040", Offset = "0x620C840", VA = "0x18620E040", Slot = "39")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A0")]
	public Quaternion EKDPJMOLPAE
	{
		[Cpp2IlInjected.Token(Token = "0x600023F")]
		[Cpp2IlInjected.Address(RVA = "0x620EB20", Offset = "0x620D320", VA = "0x18620EB20", Slot = "40")]
		get
		{
			return default(Quaternion);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A1")]
	public float EPNHAMDEIMB
	{
		[Cpp2IlInjected.Token(Token = "0x6000244")]
		[Cpp2IlInjected.Address(RVA = "0x620F950", Offset = "0x620E150", VA = "0x18620F950", Slot = "42")]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x6000245")]
		[Cpp2IlInjected.Address(RVA = "0x6210E10", Offset = "0x620F610", VA = "0x186210E10", Slot = "43")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A2")]
	public float FJKLFMLIIEM
	{
		[Cpp2IlInjected.Token(Token = "0x6000246")]
		[Cpp2IlInjected.Address(RVA = "0x620E680", Offset = "0x620CE80", VA = "0x18620E680", Slot = "44")]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x6000247")]
		[Cpp2IlInjected.Address(RVA = "0x6211B80", Offset = "0x6210380", VA = "0x186211B80", Slot = "45")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A3")]
	public bool DAFMFMBFKBE
	{
		[Cpp2IlInjected.Token(Token = "0x6000248")]
		[Cpp2IlInjected.Address(RVA = "0x620F560", Offset = "0x620DD60", VA = "0x18620F560", Slot = "46")]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000249")]
		[Cpp2IlInjected.Address(RVA = "0x620DB80", Offset = "0x620C380", VA = "0x18620DB80", Slot = "47")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A4")]
	public ABDACCGDOPN FADDMLIMLLG
	{
		[Cpp2IlInjected.Token(Token = "0x6000251")]
		[Cpp2IlInjected.Address(RVA = "0x620F900", Offset = "0x620E100", VA = "0x18620F900", Slot = "48")]
		get
		{
			return default(ABDACCGDOPN);
		}
		[Cpp2IlInjected.Token(Token = "0x6000252")]
		[Cpp2IlInjected.Address(RVA = "0x620DA40", Offset = "0x620C240", VA = "0x18620DA40", Slot = "49")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A5")]
	public bool AIFLGAACHML
	{
		[Cpp2IlInjected.Token(Token = "0x6000255")]
		[Cpp2IlInjected.Address(RVA = "0x620CA50", Offset = "0x620B250", VA = "0x18620CA50", Slot = "50")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A6")]
	public Transform FHODNODINAI
	{
		[Cpp2IlInjected.Token(Token = "0x600025C")]
		[Cpp2IlInjected.Address(RVA = "0x620D6D0", Offset = "0x620BED0", VA = "0x18620D6D0", Slot = "51")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A7")]
	public Vector3 KDEBKPHAANG
	{
		[Cpp2IlInjected.Token(Token = "0x600025D")]
		[Cpp2IlInjected.Address(RVA = "0x620D750", Offset = "0x620BF50", VA = "0x18620D750", Slot = "52")]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x600025E")]
		[Cpp2IlInjected.Address(RVA = "0x620FE60", Offset = "0x620E660", VA = "0x18620FE60", Slot = "53")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A8")]
	public float JBNHCEBOIMF
	{
		[Cpp2IlInjected.Token(Token = "0x600025F")]
		[Cpp2IlInjected.Address(RVA = "0x620CE80", Offset = "0x620B680", VA = "0x18620CE80", Slot = "54")]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x6000260")]
		[Cpp2IlInjected.Address(RVA = "0x62108F0", Offset = "0x620F0F0", VA = "0x1862108F0", Slot = "55")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A9")]
	public float PAMDAKFFDPC
	{
		[Cpp2IlInjected.Token(Token = "0x6000261")]
		[Cpp2IlInjected.Address(RVA = "0x6210650", Offset = "0x620EE50", VA = "0x186210650", Slot = "56")]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x6000262")]
		[Cpp2IlInjected.Address(RVA = "0x620EA20", Offset = "0x620D220", VA = "0x18620EA20", Slot = "57")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000AA")]
	public Quaternion ELDJEJICFFN
	{
		[Cpp2IlInjected.Token(Token = "0x6000263")]
		[Cpp2IlInjected.Address(RVA = "0x620D990", Offset = "0x620C190", VA = "0x18620D990", Slot = "58")]
		get
		{
			return default(Quaternion);
		}
		[Cpp2IlInjected.Token(Token = "0x6000264")]
		[Cpp2IlInjected.Address(RVA = "0x620FFD0", Offset = "0x620E7D0", VA = "0x18620FFD0", Slot = "59")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000AB")]
	public Vector3 MJCFJPNCBDO
	{
		[Cpp2IlInjected.Token(Token = "0x6000265")]
		[Cpp2IlInjected.Address(RVA = "0x620DD30", Offset = "0x620C530", VA = "0x18620DD30", Slot = "60")]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x6000266")]
		[Cpp2IlInjected.Address(RVA = "0x620E120", Offset = "0x620C920", VA = "0x18620E120", Slot = "61")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000AC")]
	public Quaternion CGLJKEJLMFK
	{
		[Cpp2IlInjected.Token(Token = "0x6000267")]
		[Cpp2IlInjected.Address(RVA = "0x620F170", Offset = "0x620D970", VA = "0x18620F170", Slot = "62")]
		get
		{
			return default(Quaternion);
		}
		[Cpp2IlInjected.Token(Token = "0x6000268")]
		[Cpp2IlInjected.Address(RVA = "0x620DE30", Offset = "0x620C630", VA = "0x18620DE30", Slot = "63")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000AD")]
	public RigidbodyConstraints LKJNJPEFLGB
	{
		[Cpp2IlInjected.Token(Token = "0x600026C")]
		[Cpp2IlInjected.Address(RVA = "0x620DD80", Offset = "0x620C580", VA = "0x18620DD80", Slot = "64")]
		get
		{
			return default(RigidbodyConstraints);
		}
		[Cpp2IlInjected.Token(Token = "0x600026D")]
		[Cpp2IlInjected.Address(RVA = "0x620CFE0", Offset = "0x620B7E0", VA = "0x18620CFE0", Slot = "65")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000AE")]
	public bool JIAMCDEEBDI
	{
		[Cpp2IlInjected.Token(Token = "0x600026E")]
		[Cpp2IlInjected.Address(RVA = "0x620F290", Offset = "0x620DA90", VA = "0x18620F290", Slot = "66")]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x600026F")]
		[Cpp2IlInjected.Address(RVA = "0x62113C0", Offset = "0x620FBC0", VA = "0x1862113C0", Slot = "67")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000AF")]
	public CollisionDetectionMode EJKKFAEAAME
	{
		[Cpp2IlInjected.Token(Token = "0x6000278")]
		[Cpp2IlInjected.Address(RVA = "0x620CAA0", Offset = "0x620B2A0", VA = "0x18620CAA0", Slot = "68")]
		get
		{
			return default(CollisionDetectionMode);
		}
		[Cpp2IlInjected.Token(Token = "0x6000279")]
		[Cpp2IlInjected.Address(RVA = "0x6210890", Offset = "0x620F090", VA = "0x186210890", Slot = "69")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B0")]
	public bool FAHPFCJEPJO
	{
		[Cpp2IlInjected.Token(Token = "0x600027B")]
		[Cpp2IlInjected.Address(RVA = "0x620D460", Offset = "0x620BC60", VA = "0x18620D460", Slot = "139")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B1")]
	public bool HDHFPOGMJNC
	{
		[Cpp2IlInjected.Token(Token = "0x600027C")]
		[Cpp2IlInjected.Address(RVA = "0x6210AB0", Offset = "0x620F2B0", VA = "0x186210AB0", Slot = "70")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B2")]
	public bool ENLLCHJAKOC
	{
		[Cpp2IlInjected.Token(Token = "0x600027D")]
		[Cpp2IlInjected.Address(RVA = "0x620C680", Offset = "0x620AE80", VA = "0x18620C680")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B3")]
	public bool NIOAPKILLLI
	{
		[Cpp2IlInjected.Token(Token = "0x600027E")]
		[Cpp2IlInjected.Address(RVA = "0x6210800", Offset = "0x620F000", VA = "0x186210800")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000021")]
	public event EBFBHNJDFMO PAAEJBNAELP
	{
		[Cpp2IlInjected.Token(Token = "0x6000200")]
		[Cpp2IlInjected.Address(RVA = "0x6210F50", Offset = "0x620F750", VA = "0x186210F50", Slot = "75")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000201")]
		[Cpp2IlInjected.Address(RVA = "0x62100C0", Offset = "0x620E8C0", VA = "0x1862100C0", Slot = "76")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000022")]
	public event EBFBHNJDFMO ANLGMIPOGHH
	{
		[Cpp2IlInjected.Token(Token = "0x6000202")]
		[Cpp2IlInjected.Address(RVA = "0x620D800", Offset = "0x620C000", VA = "0x18620D800", Slot = "77")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000203")]
		[Cpp2IlInjected.Address(RVA = "0x620D860", Offset = "0x620C060", VA = "0x18620D860", Slot = "78")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000023")]
	public event GHEEFDJOPPC GDBIGLFOIGG
	{
		[Cpp2IlInjected.Token(Token = "0x6000204")]
		[Cpp2IlInjected.Address(RVA = "0x620C500", Offset = "0x620AD00", VA = "0x18620C500", Slot = "79")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000205")]
		[Cpp2IlInjected.Address(RVA = "0x620E6D0", Offset = "0x620CED0", VA = "0x18620E6D0", Slot = "80")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000024")]
	public event EBFBHNJDFMO GILKHDKMEND
	{
		[Cpp2IlInjected.Token(Token = "0x600020C")]
		[Cpp2IlInjected.Address(RVA = "0x620CB40", Offset = "0x620B340", VA = "0x18620CB40", Slot = "82")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600020D")]
		[Cpp2IlInjected.Address(RVA = "0x620FC10", Offset = "0x620E410", VA = "0x18620FC10", Slot = "83")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000025")]
	public event EBFBHNJDFMO PPOOMLEKHLL
	{
		[Cpp2IlInjected.Token(Token = "0x6000236")]
		[Cpp2IlInjected.Address(RVA = "0x6211B20", Offset = "0x6210320", VA = "0x186211B20", Slot = "102")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000237")]
		[Cpp2IlInjected.Address(RVA = "0x6210830", Offset = "0x620F030", VA = "0x186210830", Slot = "103")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000026")]
	public event EBFBHNJDFMO CDIFNKKNIAI
	{
		[Cpp2IlInjected.Token(Token = "0x600024A")]
		[Cpp2IlInjected.Address(RVA = "0x620EED0", Offset = "0x620D6D0", VA = "0x18620EED0", Slot = "107")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600024B")]
		[Cpp2IlInjected.Address(RVA = "0x620ED20", Offset = "0x620D520", VA = "0x18620ED20", Slot = "108")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000027")]
	public event Action<LMALNIIPHAC, LMALNIIPHAC> ENBBGJAGBJJ
	{
		[Cpp2IlInjected.Token(Token = "0x600024F")]
		[Cpp2IlInjected.Address(RVA = "0x6211420", Offset = "0x620FC20", VA = "0x186211420", Slot = "111")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000250")]
		[Cpp2IlInjected.Address(RVA = "0x62121E0", Offset = "0x62109E0", VA = "0x1862121E0", Slot = "112")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000028")]
	public event EBFBHNJDFMO KOMDEBFEEEP
	{
		[Cpp2IlInjected.Token(Token = "0x6000253")]
		[Cpp2IlInjected.Address(RVA = "0x620ED80", Offset = "0x620D580", VA = "0x18620ED80", Slot = "113")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000254")]
		[Cpp2IlInjected.Address(RVA = "0x620F5B0", Offset = "0x620DDB0", VA = "0x18620F5B0", Slot = "114")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000029")]
	public event EBFBHNJDFMO NDADBNMCKJG
	{
		[Cpp2IlInjected.Token(Token = "0x600025A")]
		[Cpp2IlInjected.Address(RVA = "0x620FF20", Offset = "0x620E720", VA = "0x18620FF20", Slot = "119")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600025B")]
		[Cpp2IlInjected.Address(RVA = "0x6211310", Offset = "0x620FB10", VA = "0x186211310", Slot = "120")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001F9")]
	[Cpp2IlInjected.Address(RVA = "0x62123C0", Offset = "0x6210BC0", VA = "0x1862123C0")]
	public ALHCFOHGNMD(GameObject GOGHJGCCDJI, RigidbodyEx BACCFODJEJB, HGMBJJHEAKJ PNFHHOFJABN, [In] ACDBPOHPAKH AELCABDCBDD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001FA")]
	[Cpp2IlInjected.Address(RVA = "0x6211EF0", Offset = "0x62106F0", VA = "0x186211EF0", Slot = "135")]
	protected virtual void PHAFPIOAAOD(HGMBJJHEAKJ PNFHHOFJABN, ACDBPOHPAKH AELCABDCBDD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001FB")]
	[Cpp2IlInjected.Address(RVA = "0x620D8C0", Offset = "0x620C0C0", VA = "0x18620D8C0", Slot = "136")]
	public virtual void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001FC")]
	[Cpp2IlInjected.Address(RVA = "0x620CEA0", Offset = "0x620B6A0", VA = "0x18620CEA0", Slot = "71")]
	public void BMFHLKIGOGD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001FD")]
	[Cpp2IlInjected.Address(RVA = "0x620EF30", Offset = "0x620D730", VA = "0x18620EF30", Slot = "72")]
	public void LKJFMPHLLAI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001FE")]
	[Cpp2IlInjected.Address(RVA = "0x620F150", Offset = "0x620D950", VA = "0x18620F150", Slot = "73")]
	public void IKAJDAOJONJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001FF")]
	[Cpp2IlInjected.Address(RVA = "0x620CD70", Offset = "0x620B570", VA = "0x18620CD70")]
	private void BJCOGLJOKLA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600020B")]
	[Cpp2IlInjected.Address(RVA = "0x620FBA0", Offset = "0x620E3A0", VA = "0x18620FBA0", Slot = "81")]
	public void JLJFDADNEME(ACNEEEENOML FKKGMPDEPMA, bool CGKOADMHFLC = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000222")]
	[Cpp2IlInjected.Address(RVA = "0x620F330", Offset = "0x620DB30", VA = "0x18620F330", Slot = "84")]
	public void JAFBLGBFIGL(object KIAKEGJPMAL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000223")]
	[Cpp2IlInjected.Address(RVA = "0x6210300", Offset = "0x620EB00", VA = "0x186210300", Slot = "85")]
	public void KLHEGIFEBJI(object KIAKEGJPMAL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000224")]
	[Cpp2IlInjected.Address(RVA = "0x620FC70", Offset = "0x620E470", VA = "0x18620FC70", Slot = "86")]
	public Vector3 JOHAPINPNIG(Vector3 CPFDNDKFHHH)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000225")]
	[Cpp2IlInjected.Address(RVA = "0x6211CC0", Offset = "0x62104C0", VA = "0x186211CC0", Slot = "87")]
	public Vector3 OJGIMCLJCBO(Vector3 AMLAOHJLKAL)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000226")]
	[Cpp2IlInjected.Address(RVA = "0x620EF30", Offset = "0x620D730", VA = "0x18620EF30", Slot = "88")]
	public void HPICNCAEGKH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000227")]
	[Cpp2IlInjected.Address(RVA = "0x620DBE0", Offset = "0x620C3E0", VA = "0x18620DBE0", Slot = "89")]
	public void ELAIKNOJDMF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000228")]
	[Cpp2IlInjected.Address(RVA = "0x620E2C0", Offset = "0x620CAC0", VA = "0x18620E2C0", Slot = "90")]
	public void GAIPCILJLMB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000229")]
	[Cpp2IlInjected.Address(RVA = "0x620E170", Offset = "0x620C970", VA = "0x18620E170", Slot = "91")]
	public void FOPGOBMGCOM(Vector3 HDFIANGNHPD, Vector3 OPNLLPIFKNP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600022A")]
	[Cpp2IlInjected.Address(RVA = "0x6210C80", Offset = "0x620F480", VA = "0x186210C80", Slot = "92")]
	public void MDMIGCOMJCF(Vector3 JPNLAOHAPPM, Vector3 CHFCHAFCOBM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600022B")]
	[Cpp2IlInjected.Address(RVA = "0x6211BE0", Offset = "0x62103E0", VA = "0x186211BE0", Slot = "93")]
	public void OGHMBOLGHFB(Vector3 FJNLGGLHPIL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600022C")]
	[Cpp2IlInjected.Address(RVA = "0x620D0A0", Offset = "0x620B8A0", VA = "0x18620D0A0", Slot = "94")]
	public void CCOMMPLBNFB(BPNODJIJBLA KADKJKFHDBE, Vector3 MCCPDDLJGEG, float EGMGOJMNMKL, float FLCBFAEIBEI = 8f, float MMINJAGEDBL = 1f)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600022D")]
	[Cpp2IlInjected.Address(RVA = "0x620C720", Offset = "0x620AF20", VA = "0x18620C720", Slot = "95")]
	public void AFAJHDMGFMF(LJGOMBGDPDM GJBGJOHBOBM, Vector3 GNFMGLELAKB, float JICJOBGCGOP = float.PositiveInfinity)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600022E")]
	[Cpp2IlInjected.Address(RVA = "0x6211200", Offset = "0x620FA00", VA = "0x186211200", Slot = "96")]
	[Obsolete("Deprecated. Still exists to support deprecated CV2 chips. Use ApplyAngularVelocityChange.")]
	public void MPMCBKEHDIK(LJGOMBGDPDM GJBGJOHBOBM, Vector3 OHMBDAJNEIJ, float GEPDJOHNEPN = 7f, float JINKMCECFKA = 1f)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600022F")]
	[Cpp2IlInjected.Address(RVA = "0x620DC30", Offset = "0x620C430", VA = "0x18620DC30", Slot = "97")]
	public Vector3 EMEDMNCJCCM(Vector3 FKKGMPDEPMA)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000230")]
	[Cpp2IlInjected.Address(RVA = "0x620C7C0", Offset = "0x620AFC0", VA = "0x18620C7C0", Slot = "98")]
	public Vector3 AFNJAEPBIFC(Vector3 FKKGMPDEPMA)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000231")]
	[Cpp2IlInjected.Address(RVA = "0x620F7D0", Offset = "0x620DFD0", VA = "0x18620F7D0", Slot = "99")]
	public void JIMNECMIFKB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000234")]
	[Cpp2IlInjected.Address(RVA = "0x620D6E0", Offset = "0x620BEE0", VA = "0x18620D6E0", Slot = "100")]
	public void DGFANBIPFEE(ACNEEEENOML FFGBMPIEMIB, object KIAKEGJPMAL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000235")]
	[Cpp2IlInjected.Address(RVA = "0x620D5A0", Offset = "0x620BDA0", VA = "0x18620D5A0", Slot = "101")]
	public void DCFJHAGIOEM(object KIAKEGJPMAL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000240")]
	[Cpp2IlInjected.Address(RVA = "0x620E940", Offset = "0x620D140", VA = "0x18620E940", Slot = "41")]
	public void HFHDCMEIKAH((Quaternion rot, Vector3 moments) MOGJAEMHOKI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000241")]
	[Cpp2IlInjected.Address(RVA = "0x620CAF0", Offset = "0x620B2F0", VA = "0x18620CAF0", Slot = "104")]
	public void ALFIJHNHMBG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000242")]
	[Cpp2IlInjected.Address(RVA = "0x620C630", Offset = "0x620AE30", VA = "0x18620C630", Slot = "105")]
	public void AECDOEBBECA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000243")]
	[Cpp2IlInjected.Address(RVA = "0x6211EA0", Offset = "0x62106A0", VA = "0x186211EA0", Slot = "106")]
	public void PFMKNBPMAJC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600024C")]
	[Cpp2IlInjected.Address(RVA = "0x620F060", Offset = "0x620D860", VA = "0x18620F060", Slot = "109")]
	public bool ICIHJKDLIHF()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600024D")]
	[Cpp2IlInjected.Address(RVA = "0x620CD20", Offset = "0x620B520", VA = "0x18620CD20", Slot = "74")]
	public void BHMFFCOHDEE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600024E")]
	[Cpp2IlInjected.Address(RVA = "0x620F2E0", Offset = "0x620DAE0", VA = "0x18620F2E0", Slot = "110")]
	public void JAEFDNECOPP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000256")]
	[Cpp2IlInjected.Address(RVA = "0x620EBF0", Offset = "0x620D3F0", VA = "0x18620EBF0", Slot = "115")]
	public IDisposable HIJEMOJOGMK()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000257")]
	[Cpp2IlInjected.Address(RVA = "0x620FD70", Offset = "0x620E570", VA = "0x18620FD70", Slot = "116")]
	public void JOKCPNGIIMH(object KIAKEGJPMAL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000258")]
	[Cpp2IlInjected.Address(RVA = "0x620D1C0", Offset = "0x620B9C0", VA = "0x18620D1C0", Slot = "117")]
	public void CFLECLOAECH(object KIAKEGJPMAL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000259")]
	[Cpp2IlInjected.Address(RVA = "0x6212240", Offset = "0x6210A40", VA = "0x186212240", Slot = "118")]
	public void PHMJJJCNKII(object KIAKEGJPMAL, bool JMNDFKAOINO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000269")]
	[Cpp2IlInjected.Address(RVA = "0x620F9A0", Offset = "0x620E1A0", VA = "0x18620F9A0", Slot = "121")]
	public void JLBDGAIPDBF(Vector3 AAMDDKIBNEM, Quaternion AHHDHIOJLHB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600026A")]
	[Cpp2IlInjected.Address(RVA = "0x6210960", Offset = "0x620F160", VA = "0x186210960", Slot = "122")]
	public void MBKDHNHMLBH(Vector3 LHHPNCJCHFD, Quaternion CDONFJKGJGK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600026B")]
	[Cpp2IlInjected.Address(RVA = "0x620D040", Offset = "0x620B840", VA = "0x18620D040", Slot = "123")]
	public bool CACNNIFAFBA(float JJLGAOMIEEO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000270")]
	[Cpp2IlInjected.Address(RVA = "0x620C9A0", Offset = "0x620B1A0", VA = "0x18620C9A0", Slot = "124")]
	public void AGDOBNJPBGB(object KIAKEGJPMAL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000271")]
	[Cpp2IlInjected.Address(RVA = "0x620E260", Offset = "0x620CA60", VA = "0x18620E260", Slot = "125")]
	public void FPLFJLMJDOL(object KIAKEGJPMAL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000272")]
	[Cpp2IlInjected.Address(RVA = "0x620F390", Offset = "0x620DB90", VA = "0x18620F390", Slot = "126")]
	public void JBAEFNMGPHP(object KIAKEGJPMAL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000273")]
	[Cpp2IlInjected.Address(RVA = "0x6210FB0", Offset = "0x620F7B0", VA = "0x186210FB0", Slot = "127")]
	public void MODGFAKLIIP(object KIAKEGJPMAL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000274")]
	[Cpp2IlInjected.Address(RVA = "0x620DAA0", Offset = "0x620C2A0", VA = "0x18620DAA0", Slot = "128")]
	public void EGEGKPJLIKO(Vector3 AKFFELDLHDA, ForceMode ACFLBCIEBAA = ForceMode.Force)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000275")]
	[Cpp2IlInjected.Address(RVA = "0x62116F0", Offset = "0x620FEF0", VA = "0x1862116F0", Slot = "129")]
	public void NOAIHMJOFMI(Vector3 AKFFELDLHDA, Vector3 MCLBBPPAHAP, ForceMode ACFLBCIEBAA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000276")]
	[Cpp2IlInjected.Address(RVA = "0x620F610", Offset = "0x620DE10", VA = "0x18620F610", Slot = "130")]
	public void JHDOIGEAHPA(Vector3 FNPOFGBLJMD, ForceMode ACFLBCIEBAA = ForceMode.Force)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000277")]
	[Cpp2IlInjected.Address(RVA = "0x620F1B0", Offset = "0x620D9B0", VA = "0x18620F1B0", Slot = "131")]
	public void INFGEGJJGIJ(Vector3 FNPOFGBLJMD, ForceMode ACFLBCIEBAA = ForceMode.Force)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600027A")]
	[Cpp2IlInjected.Address(RVA = "0x620EE30", Offset = "0x620D630", VA = "0x18620EE30", Slot = "132")]
	public bool HOKBEJGNALC(Vector3 GJMNPFFBJPA, [Out] RaycastHit LGAEEAFDDFJ, float LNHOFLIBFND)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600027F")]
	[Cpp2IlInjected.Address(RVA = "0x620DEC0", Offset = "0x620C6C0", VA = "0x18620DEC0", Slot = "133")]
	public void FCAHOLPEHIP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000280")]
	[Cpp2IlInjected.Address(RVA = "0x6212380", Offset = "0x6210B80", VA = "0x186212380", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000281")]
	[Cpp2IlInjected.Address(RVA = "0x6210E70", Offset = "0x620F670", VA = "0x186210E70")]
	private void MNNNDHPECOP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000282")]
	[Cpp2IlInjected.Address(RVA = "0x620D270", Offset = "0x620BA70", VA = "0x18620D270")]
	private void CIFJMLAKOMA(ACNEEEENOML OBIIIBPBMLD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000283")]
	[Cpp2IlInjected.Address(RVA = "0x6211010", Offset = "0x620F810", VA = "0x186211010")]
	private void MOJGDECALDG(ACNEEEENOML OBIIIBPBMLD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000284")]
	[Cpp2IlInjected.Address(RVA = "0x6210670", Offset = "0x620EE70", VA = "0x186210670")]
	private void LGGDMMFCBHE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000285")]
	[Cpp2IlInjected.Address(RVA = "0x6210120", Offset = "0x620E920", VA = "0x186210120")]
	private void KIJFDGMFGGN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000286")]
	[Cpp2IlInjected.Address(RVA = "0x62103C0", Offset = "0x620EBC0", VA = "0x1862103C0")]
	private void LAFIBAKECOE(ACNEEEENOML HKJABBNKIDD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000287")]
	[Cpp2IlInjected.Address(RVA = "0x620C560", Offset = "0x620AD60", VA = "0x18620C560")]
	private void ACFBEMHJHMI(ACNEEEENOML OBIIIBPBMLD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000288")]
	[Cpp2IlInjected.Address(RVA = "0x620D600", Offset = "0x620BE00", VA = "0x18620D600")]
	private void DDKAOBEOLDP(ACNEEEENOML OBIIIBPBMLD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000289")]
	[Cpp2IlInjected.Address(RVA = "0x620F3F0", Offset = "0x620DBF0", VA = "0x18620F3F0")]
	private void JDCNIGIMOJM(RigidbodyEx OBIIIBPBMLD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600028A")]
	[Cpp2IlInjected.Address(RVA = "0x620E730", Offset = "0x620CF30", VA = "0x18620E730", Slot = "140")]
	protected virtual void GLDNEHFMFPP(RigidbodyEx AHGOPBJOELE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600028B")]
	[Cpp2IlInjected.Address(RVA = "0x6211800", Offset = "0x6210000", VA = "0x186211800")]
	protected void OCHMMLOBGLH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600028C")]
	[Cpp2IlInjected.Address(RVA = "0x620E310", Offset = "0x620CB10", VA = "0x18620E310")]
	protected void GCDCMLAPEBH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600028D")]
	[Cpp2IlInjected.Address(RVA = "0x620F0B0", Offset = "0x620D8B0", VA = "0x18620F0B0", Slot = "141")]
	protected virtual IDisposable IHONCCCEIPE()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000028")]
internal static class MDHIPDLBEOP
{
	[Cpp2IlInjected.Token(Token = "0x600028E")]
	[Cpp2IlInjected.Address(RVA = "0x6228740", Offset = "0x6226F40", VA = "0x186228740")]
	public static ACNEEEENOML MKEMMKKBLEG(this ACNEEEENOML AHGOPBJOELE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600028F")]
	[Cpp2IlInjected.Address(RVA = "0x62285C0", Offset = "0x6226DC0", VA = "0x1862285C0")]
	public static bool BAKFEEBPNEM(this ACNEEEENOML AHGOPBJOELE, ACNEEEENOML FFMBJOHCBPE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000290")]
	[Cpp2IlInjected.Address(RVA = "0x6228640", Offset = "0x6226E40", VA = "0x186228640")]
	public static bool DHPFCPPJJFH(this ACNEEEENOML AHGOPBJOELE, ACNEEEENOML IALCJLJEKEF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000291")]
	[Cpp2IlInjected.Address(RVA = "0x62287F0", Offset = "0x6226FF0", VA = "0x1862287F0")]
	public static RigidbodyEx PCBHPDJNNIB(this ACNEEEENOML HDDKOOHNGPB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000292")]
	[Cpp2IlInjected.Address(RVA = "0x62286C0", Offset = "0x6226EC0", VA = "0x1862286C0")]
	public static ALHCFOHGNMD JAEIIBFAIKF(this ACNEEEENOML PCEPPDLMHCM)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000029")]
internal class EMDMAMHDHNA : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000040")]
	private readonly ALHCFOHGNMD AHGOPBJOELE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000041")]
	private bool KIMEMKKPGDJ;

	[Cpp2IlInjected.Token(Token = "0x6000293")]
	[Cpp2IlInjected.Address(RVA = "0x6217DF0", Offset = "0x62165F0", VA = "0x186217DF0")]
	public EMDMAMHDHNA(ALHCFOHGNMD FPMFDFOAOMK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000294")]
	[Cpp2IlInjected.Address(RVA = "0x6217D90", Offset = "0x6216590", VA = "0x186217D90", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002A")]
internal sealed class PDNNHJLBFDJ : JFBGLNFANHP, NDKMMOHJIND
{
	[Cpp2IlInjected.Token(Token = "0x170000B4")]
	private CollisionDetectionMode LNFJOJOEBFJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000296")]
		[Cpp2IlInjected.Address(RVA = "0x622DCA0", Offset = "0x622C4A0", VA = "0x18622DCA0")]
		get
		{
			return default(CollisionDetectionMode);
		}
		[Cpp2IlInjected.Token(Token = "0x6000297")]
		[Cpp2IlInjected.Address(RVA = "0x622DD00", Offset = "0x622C500", VA = "0x18622DD00")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B5")]
	private Rigidbody AIOLOONKHDH
	{
		[Cpp2IlInjected.Token(Token = "0x6000298")]
		[Cpp2IlInjected.Address(RVA = "0x62126A0", Offset = "0x6210EA0", VA = "0x1862126A0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B6")]
	public CollisionDetectionMode EJKKFAEAAME
	{
		[Cpp2IlInjected.Token(Token = "0x600029B")]
		[Cpp2IlInjected.Address(RVA = "0x622D960", Offset = "0x622C160", VA = "0x18622D960", Slot = "4")]
		get
		{
			return default(CollisionDetectionMode);
		}
		[Cpp2IlInjected.Token(Token = "0x600029C")]
		[Cpp2IlInjected.Address(RVA = "0x622DEE0", Offset = "0x622C6E0", VA = "0x18622DEE0", Slot = "5")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000295")]
	[Cpp2IlInjected.Address(RVA = "0x6216F70", Offset = "0x6215770", VA = "0x186216F70")]
	public PDNNHJLBFDJ(ACNEEEENOML AHGOPBJOELE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000299")]
	[Cpp2IlInjected.Address(RVA = "0x622DA70", Offset = "0x622C270", VA = "0x18622DA70", Slot = "6")]
	public void BMFHLKIGOGD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600029A")]
	[Cpp2IlInjected.Address(RVA = "0x622DBC0", Offset = "0x622C3C0", VA = "0x18622DBC0", Slot = "9")]
	public void DOIABHKLMHG(Rigidbody JFKGLMKHADB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600029D")]
	[Cpp2IlInjected.Address(RVA = "0x622DED0", Offset = "0x622C6D0", VA = "0x18622DED0", Slot = "7")]
	public void JJAEHGOMMFB(bool EKPIMFFAAJH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600029E")]
	[Cpp2IlInjected.Address(RVA = "0x622E110", Offset = "0x622C910", VA = "0x18622E110", Slot = "8")]
	public void PIIIJOOFJJP(bool EKPIMFFAAJH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600029F")]
	[Cpp2IlInjected.Address(RVA = "0x622DD70", Offset = "0x622C570", VA = "0x18622DD70", Slot = "10")]
	public bool HOKBEJGNALC(Vector3 GJMNPFFBJPA, [Out] RaycastHit LGAEEAFDDFJ, float LNHOFLIBFND)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002A0")]
	[Cpp2IlInjected.Address(RVA = "0x622DFA0", Offset = "0x622C7A0", VA = "0x18622DFA0")]
	private void NFFFMMPNHDG(bool EKPIMFFAAJH)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002B")]
internal sealed class JAFJEKKALLE : JFBGLNFANHP, MCEBLIDMGME, IDisposable, EDAFEFMMNAG
{
	[Cpp2IlInjected.Token(Token = "0x170000B7")]
	public ABDACCGDOPN ADLHFECMHNJ
	{
		[Cpp2IlInjected.Token(Token = "0x60002A4")]
		[Cpp2IlInjected.Address(RVA = "0x62205D0", Offset = "0x621EDD0", VA = "0x1862205D0")]
		get
		{
			return default(ABDACCGDOPN);
		}
		[Cpp2IlInjected.Token(Token = "0x60002A5")]
		[Cpp2IlInjected.Address(RVA = "0x62204E0", Offset = "0x621ECE0", VA = "0x1862204E0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B8")]
	public ABDACCGDOPN FADDMLIMLLG
	{
		[Cpp2IlInjected.Token(Token = "0x60002A6")]
		[Cpp2IlInjected.Address(RVA = "0x62206B0", Offset = "0x621EEB0", VA = "0x1862206B0", Slot = "6")]
		get
		{
			return default(ABDACCGDOPN);
		}
		[Cpp2IlInjected.Token(Token = "0x60002A7")]
		[Cpp2IlInjected.Address(RVA = "0x62204E0", Offset = "0x621ECE0", VA = "0x1862204E0", Slot = "7")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B9")]
	private Transform KBMBAPEAMKN
	{
		[Cpp2IlInjected.Token(Token = "0x60002AC")]
		[Cpp2IlInjected.Address(RVA = "0x764500", Offset = "0x762D00", VA = "0x180764500", Slot = "10")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400002A")]
	public event Action<LMALNIIPHAC, LMALNIIPHAC> ENBBGJAGBJJ
	{
		[Cpp2IlInjected.Token(Token = "0x60002A2")]
		[Cpp2IlInjected.Address(RVA = "0x62208B0", Offset = "0x621F0B0", VA = "0x1862208B0", Slot = "4")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60002A3")]
		[Cpp2IlInjected.Address(RVA = "0x6220980", Offset = "0x621F180", VA = "0x186220980", Slot = "5")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60002A1")]
	[Cpp2IlInjected.Address(RVA = "0x6216F70", Offset = "0x6215770", VA = "0x186216F70")]
	public JAFJEKKALLE(ACNEEEENOML AHGOPBJOELE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002A8")]
	[Cpp2IlInjected.Address(RVA = "0x6220960", Offset = "0x621F160", VA = "0x186220960", Slot = "11")]
	public void OnChangedDistanceBand(LMALNIIPHAC OEHHBJMJCPL, LMALNIIPHAC JHENJKJEFON)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002A9")]
	[Cpp2IlInjected.Address(RVA = "0x7644F0", Offset = "0x762CF0", VA = "0x1807644F0", Slot = "12")]
	public void OnChangedVisibility(bool GHGJICDKEHL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002AA")]
	[Cpp2IlInjected.Address(RVA = "0x7644F0", Offset = "0x762CF0", VA = "0x1807644F0", Slot = "8")]
	public void BMFHLKIGOGD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002AB")]
	[Cpp2IlInjected.Address(RVA = "0x7644F0", Offset = "0x762CF0", VA = "0x1807644F0", Slot = "9")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002C")]
internal sealed class NFBAPDHPIDJ : JFBGLNFANHP, AICDKPBPOFE
{
	[Cpp2IlInjected.Token(Token = "0x170000BA")]
	private Rigidbody AIOLOONKHDH
	{
		[Cpp2IlInjected.Token(Token = "0x60002AE")]
		[Cpp2IlInjected.Address(RVA = "0x62126A0", Offset = "0x6210EA0", VA = "0x1862126A0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000BB")]
	private bool AIFLGAACHML
	{
		[Cpp2IlInjected.Token(Token = "0x60002AF")]
		[Cpp2IlInjected.Address(RVA = "0x6212490", Offset = "0x6210C90", VA = "0x186212490")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000BC")]
	private bool IDEKMMEBDBI
	{
		[Cpp2IlInjected.Token(Token = "0x60002B0")]
		[Cpp2IlInjected.Address(RVA = "0x6212F70", Offset = "0x6211770", VA = "0x186212F70")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000BD")]
	private ACNEEEENOML MLDLDJMPPGN
	{
		[Cpp2IlInjected.Token(Token = "0x60002B1")]
		[Cpp2IlInjected.Address(RVA = "0x62299F0", Offset = "0x62281F0", VA = "0x1862299F0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60002AD")]
	[Cpp2IlInjected.Address(RVA = "0x6216F70", Offset = "0x6215770", VA = "0x186216F70")]
	public NFBAPDHPIDJ(ACNEEEENOML AHGOPBJOELE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002B2")]
	[Cpp2IlInjected.Address(RVA = "0x6229A50", Offset = "0x6228250", VA = "0x186229A50", Slot = "4")]
	public void EGEGKPJLIKO(Vector3 AKFFELDLHDA, ForceMode ACFLBCIEBAA = ForceMode.Force)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002B3")]
	[Cpp2IlInjected.Address(RVA = "0x6229F70", Offset = "0x6228770", VA = "0x186229F70")]
	private void MHHBGHDJNEF(Vector3 AKFFELDLHDA, ForceMode ACFLBCIEBAA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002B4")]
	[Cpp2IlInjected.Address(RVA = "0x622A4B0", Offset = "0x6228CB0", VA = "0x18622A4B0", Slot = "5")]
	public void NOAIHMJOFMI(Vector3 AKFFELDLHDA, Vector3 MCLBBPPAHAP, ForceMode ACFLBCIEBAA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002B5")]
	[Cpp2IlInjected.Address(RVA = "0x6229E10", Offset = "0x6228610", VA = "0x186229E10", Slot = "6")]
	public void JHDOIGEAHPA(Vector3 FNPOFGBLJMD, ForceMode ACFLBCIEBAA = ForceMode.Force)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002B6")]
	[Cpp2IlInjected.Address(RVA = "0x622A250", Offset = "0x6228A50", VA = "0x18622A250")]
	private void NGHNPIFHLLG(Vector3 FNPOFGBLJMD, ForceMode ACFLBCIEBAA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002B7")]
	[Cpp2IlInjected.Address(RVA = "0x6229BB0", Offset = "0x62283B0", VA = "0x186229BB0", Slot = "7")]
	public void INFGEGJJGIJ(Vector3 FNPOFGBLJMD, ForceMode ACFLBCIEBAA = ForceMode.Force)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002B8")]
	[Cpp2IlInjected.Address(RVA = "0x622A730", Offset = "0x6228F30", VA = "0x18622A730")]
	private void NOCJPHOMELN(string BKGEBGGPBLH, UnityEngine.Object FJNGJOFLBMD)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002D")]
internal sealed class GNCKCLHNGHA : JFBGLNFANHP, HEEAIGPCPDE
{
	[Cpp2IlInjected.Token(Token = "0x170000BE")]
	public bool DAFMFMBFKBE
	{
		[Cpp2IlInjected.Token(Token = "0x60002BA")]
		[Cpp2IlInjected.Address(RVA = "0x621CDC0", Offset = "0x621B5C0", VA = "0x18621CDC0", Slot = "4")]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x60002BB")]
		[Cpp2IlInjected.Address(RVA = "0x621CC00", Offset = "0x621B400", VA = "0x18621CC00", Slot = "5")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60002B9")]
	[Cpp2IlInjected.Address(RVA = "0x6216F70", Offset = "0x6215770", VA = "0x186216F70")]
	public GNCKCLHNGHA(ACNEEEENOML AHGOPBJOELE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002BC")]
	[Cpp2IlInjected.Address(RVA = "0x621CB70", Offset = "0x621B370", VA = "0x18621CB70", Slot = "6")]
	public void DOIABHKLMHG(Rigidbody JFKGLMKHADB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002BD")]
	[Cpp2IlInjected.Address(RVA = "0x621CD50", Offset = "0x621B550", VA = "0x18621CD50", Slot = "7")]
	public void HAKPNCDKJGA(Rigidbody JFKGLMKHADB)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002E")]
internal sealed class BFOOKJBDJJD : JFBGLNFANHP, PMHIGDLAJOP, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x4000043")]
	private static readonly DGJIKJLGCCH JFJHPDMMICL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x400004D")]
	private readonly FMLCBGNJKFI EMJALNHBEEI;

	[Cpp2IlInjected.Token(Token = "0x170000BF")]
	private Transform BDOKOMBLFFF
	{
		[Cpp2IlInjected.Token(Token = "0x60002D1")]
		[Cpp2IlInjected.Address(RVA = "0x6214CA0", Offset = "0x62134A0", VA = "0x186214CA0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000C0")]
	public INJNNPDEJLM CJAFAELLAHN
	{
		[Cpp2IlInjected.Token(Token = "0x60002D3")]
		[Cpp2IlInjected.Address(RVA = "0x6214180", Offset = "0x6212980", VA = "0x186214180")]
		get
		{
			return default(INJNNPDEJLM);
		}
		[Cpp2IlInjected.Token(Token = "0x60002D4")]
		[Cpp2IlInjected.Address(RVA = "0x6213650", Offset = "0x6211E50", VA = "0x186213650")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000C1")]
	public ACNEEEENOML MLDLDJMPPGN
	{
		[Cpp2IlInjected.Token(Token = "0x60002D5")]
		[Cpp2IlInjected.Address(RVA = "0x62133F0", Offset = "0x6211BF0", VA = "0x1862133F0", Slot = "24")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60002D6")]
		[Cpp2IlInjected.Address(RVA = "0x6214EC0", Offset = "0x62136C0", VA = "0x186214EC0", Slot = "25")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000C2")]
	public INJNNPDEJLM DBCLKFCCNFO
	{
		[Cpp2IlInjected.Token(Token = "0x60002D7")]
		[Cpp2IlInjected.Address(RVA = "0x6214B70", Offset = "0x6213370", VA = "0x186214B70")]
		get
		{
			return default(INJNNPDEJLM);
		}
		[Cpp2IlInjected.Token(Token = "0x60002D8")]
		[Cpp2IlInjected.Address(RVA = "0x6213380", Offset = "0x6211B80", VA = "0x186213380")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000C3")]
	public ACNEEEENOML IDPDODAHCDH
	{
		[Cpp2IlInjected.Token(Token = "0x60002D9")]
		[Cpp2IlInjected.Address(RVA = "0x6214320", Offset = "0x6212B20", VA = "0x186214320", Slot = "23")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000C4")]
	public IReadOnlyList<ACNEEEENOML> FKAHMBHHHJN
	{
		[Cpp2IlInjected.Token(Token = "0x60002DA")]
		[Cpp2IlInjected.Address(RVA = "0x761C00", Offset = "0x760400", VA = "0x180761C00", Slot = "22")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400002B")]
	public event EBFBHNJDFMO PAAEJBNAELP
	{
		[Cpp2IlInjected.Token(Token = "0x60002BF")]
		[Cpp2IlInjected.Address(RVA = "0x6214E20", Offset = "0x6213620", VA = "0x186214E20", Slot = "4")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60002C0")]
		[Cpp2IlInjected.Address(RVA = "0x6214CD0", Offset = "0x62134D0", VA = "0x186214CD0", Slot = "5")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400002C")]
	public event EBFBHNJDFMO ANLGMIPOGHH
	{
		[Cpp2IlInjected.Token(Token = "0x60002C1")]
		[Cpp2IlInjected.Address(RVA = "0x6213770", Offset = "0x6211F70", VA = "0x186213770", Slot = "6")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60002C2")]
		[Cpp2IlInjected.Address(RVA = "0x6213810", Offset = "0x6212010", VA = "0x186213810", Slot = "7")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400002D")]
	public event GHEEFDJOPPC GDBIGLFOIGG
	{
		[Cpp2IlInjected.Token(Token = "0x60002C3")]
		[Cpp2IlInjected.Address(RVA = "0x62132E0", Offset = "0x6211AE0", VA = "0x1862132E0", Slot = "8")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60002C4")]
		[Cpp2IlInjected.Address(RVA = "0x6214280", Offset = "0x6212A80", VA = "0x186214280", Slot = "9")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400002E")]
	public event Action LEDOPACHHJI
	{
		[Cpp2IlInjected.Token(Token = "0x60002C5")]
		[Cpp2IlInjected.Address(RVA = "0x6214040", Offset = "0x6212840", VA = "0x186214040", Slot = "10")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60002C6")]
		[Cpp2IlInjected.Address(RVA = "0x6215090", Offset = "0x6213890", VA = "0x186215090", Slot = "11")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400002F")]
	public event Action PMKLHIGJFKE
	{
		[Cpp2IlInjected.Token(Token = "0x60002C7")]
		[Cpp2IlInjected.Address(RVA = "0x62141E0", Offset = "0x62129E0", VA = "0x1862141E0", Slot = "12")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60002C8")]
		[Cpp2IlInjected.Address(RVA = "0x62140E0", Offset = "0x62128E0", VA = "0x1862140E0", Slot = "13")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000030")]
	public event Action<ACNEEEENOML> DICGHONINEC
	{
		[Cpp2IlInjected.Token(Token = "0x60002C9")]
		[Cpp2IlInjected.Address(RVA = "0x6214820", Offset = "0x6213020", VA = "0x186214820", Slot = "14")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60002CA")]
		[Cpp2IlInjected.Address(RVA = "0x6214FE0", Offset = "0x62137E0", VA = "0x186214FE0", Slot = "15")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000031")]
	public event Action<ACNEEEENOML> DHKNBNGMEPD
	{
		[Cpp2IlInjected.Token(Token = "0x60002CB")]
		[Cpp2IlInjected.Address(RVA = "0x6214F30", Offset = "0x6213730", VA = "0x186214F30", Slot = "16")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60002CC")]
		[Cpp2IlInjected.Address(RVA = "0x6213500", Offset = "0x6211D00", VA = "0x186213500", Slot = "17")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000032")]
	public event Action EIPNHPBGMNG
	{
		[Cpp2IlInjected.Token(Token = "0x60002CD")]
		[Cpp2IlInjected.Address(RVA = "0x62135B0", Offset = "0x6211DB0", VA = "0x1862135B0", Slot = "18")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60002CE")]
		[Cpp2IlInjected.Address(RVA = "0x62148D0", Offset = "0x62130D0", VA = "0x1862148D0", Slot = "19")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000033")]
	public event Action<ACNEEEENOML> FGIJOHKDECO
	{
		[Cpp2IlInjected.Token(Token = "0x60002CF")]
		[Cpp2IlInjected.Address(RVA = "0x6214D70", Offset = "0x6213570", VA = "0x186214D70", Slot = "20")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60002D0")]
		[Cpp2IlInjected.Address(RVA = "0x62146D0", Offset = "0x6212ED0", VA = "0x1862146D0", Slot = "21")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60002BE")]
	[Cpp2IlInjected.Address(RVA = "0x62151C0", Offset = "0x62139C0", VA = "0x1862151C0")]
	public BFOOKJBDJJD(ACNEEEENOML AHGOPBJOELE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002D2")]
	[Cpp2IlInjected.Address(RVA = "0x62138B0", Offset = "0x62120B0", VA = "0x1862138B0", Slot = "27")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002DB")]
	[Cpp2IlInjected.Address(RVA = "0x6214BD0", Offset = "0x62133D0", VA = "0x186214BD0", Slot = "26")]
	public void JLJFDADNEME(ACNEEEENOML KEDAAEKKLOL, bool CGKOADMHFLC = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002DC")]
	[Cpp2IlInjected.Address(RVA = "0x6214C50", Offset = "0x6213450", VA = "0x186214C50")]
	private void JLJFDADNEME(LNEFAENNCOP KEDAAEKKLOL, bool CGKOADMHFLC = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002DD")]
	[Cpp2IlInjected.Address(RVA = "0x62139E0", Offset = "0x62121E0", VA = "0x1862139E0")]
	private void EGLDDENFJLM(LNEFAENNCOP KEDAAEKKLOL, bool CGKOADMHFLC = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002DE")]
	[Cpp2IlInjected.Address(RVA = "0x6214390", Offset = "0x6212B90", VA = "0x186214390")]
	private void HALBFMEBFHC(LNEFAENNCOP HKJABBNKIDD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002DF")]
	[Cpp2IlInjected.Address(RVA = "0x6214970", Offset = "0x6213170", VA = "0x186214970")]
	private void JDIMBCAFGPK(LNEFAENNCOP HKJABBNKIDD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002E0")]
	[Cpp2IlInjected.Address(RVA = "0x6213E60", Offset = "0x6212660", VA = "0x186213E60")]
	private void EHJIMIBKHAN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002E1")]
	[Cpp2IlInjected.Address(RVA = "0x62136C0", Offset = "0x6211EC0", VA = "0x1862136C0")]
	private void DGEDOGIJEFN(LNEFAENNCOP HKJABBNKIDD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002E2")]
	[Cpp2IlInjected.Address(RVA = "0x62145E0", Offset = "0x6212DE0", VA = "0x1862145E0")]
	private void HHOBHOHCAOO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002E3")]
	[Cpp2IlInjected.Address(RVA = "0x6213460", Offset = "0x6211C60", VA = "0x186213460")]
	private void CCIOJOCPJBE(LNEFAENNCOP AHGOPBJOELE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002E4")]
	[Cpp2IlInjected.Address(RVA = "0x6214780", Offset = "0x6212F80", VA = "0x186214780")]
	private void IIMOIKPKMHN(LNEFAENNCOP AHGOPBJOELE)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002F")]
internal static class IPFCEJAOHCA
{
	[Cpp2IlInjected.Token(Token = "0x60002E6")]
	[Cpp2IlInjected.Address(RVA = "0x6220450", Offset = "0x621EC50", VA = "0x186220450")]
	public static BFOOKJBDJJD DNDCCOBNFMK(this ACNEEEENOML PCEPPDLMHCM)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000030")]
internal sealed class NEENBAHHLAA : JFBGLNFANHP, LMDEEHLJMOK
{
	[Cpp2IlInjected.Token(Token = "0x170000C5")]
	public Vector3 EEEHLJDAFJK
	{
		[Cpp2IlInjected.Token(Token = "0x60002E8")]
		[Cpp2IlInjected.Address(RVA = "0x62299C0", Offset = "0x62281C0", VA = "0x1862299C0", Slot = "4")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000C6")]
	public Vector3 JDGLCEIOOBF
	{
		[Cpp2IlInjected.Token(Token = "0x60002E9")]
		[Cpp2IlInjected.Address(RVA = "0x6229790", Offset = "0x6227F90", VA = "0x186229790", Slot = "5")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000C7")]
	private Vector3 NBKAJOJDMMI
	{
		[Cpp2IlInjected.Token(Token = "0x60002ED")]
		[Cpp2IlInjected.Address(RVA = "0x6229630", Offset = "0x6227E30", VA = "0x186229630")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000C8")]
	private ACNEEEENOML KIHKKDCAAPO
	{
		[Cpp2IlInjected.Token(Token = "0x60002EE")]
		[Cpp2IlInjected.Address(RVA = "0x62290C0", Offset = "0x62278C0", VA = "0x1862290C0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60002E7")]
	[Cpp2IlInjected.Address(RVA = "0x6216F70", Offset = "0x6215770", VA = "0x186216F70")]
	public NEENBAHHLAA(ACNEEEENOML AHGOPBJOELE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002EA")]
	[Cpp2IlInjected.Address(RVA = "0x6228E60", Offset = "0x6227660", VA = "0x186228E60", Slot = "6")]
	public void HHGGBNOHIJM(ACNEEEENOML OBIIIBPBMLD, object KIAKEGJPMAL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002EB")]
	[Cpp2IlInjected.Address(RVA = "0x6228FB0", Offset = "0x62277B0", VA = "0x186228FB0")]
	private void HHGGBNOHIJM(LNEFAENNCOP OBIIIBPBMLD, object KIAKEGJPMAL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002EC")]
	[Cpp2IlInjected.Address(RVA = "0x6229720", Offset = "0x6227F20", VA = "0x186229720", Slot = "7")]
	public void LPFADOHJNOB(object KIAKEGJPMAL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002EF")]
	[Cpp2IlInjected.Address(RVA = "0x6229220", Offset = "0x6227A20", VA = "0x186229220")]
	private Vector3 KDFDHKNFKIK()
	{
		return default(Vector3);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000031")]
internal static class DOCJACPDMBN
{
	[Cpp2IlInjected.Token(Token = "0x60002F0")]
	[Cpp2IlInjected.Address(RVA = "0x62169C0", Offset = "0x62151C0", VA = "0x1862169C0")]
	public static NEENBAHHLAA FEJBGBGEANI(this ACNEEEENOML PCEPPDLMHCM)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000032")]
internal sealed class FCMELOBGJFH : JFBGLNFANHP, KFKLGADFDEA
{
	[Cpp2IlInjected.Token(Token = "0x170000C9")]
	[Obsolete("Use LocalCenterOfMassOfSelf or LocalCenterOfMassOfHierarchy, as LocalCenterOfMass changes based on context")]
	public Vector3 LBFLJMHMJDO
	{
		[Cpp2IlInjected.Token(Token = "0x60002F4")]
		[Cpp2IlInjected.Address(RVA = "0x621ADD0", Offset = "0x62195D0", VA = "0x18621ADD0", Slot = "6")]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x60002F5")]
		[Cpp2IlInjected.Address(RVA = "0x62181C0", Offset = "0x62169C0", VA = "0x1862181C0", Slot = "7")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000CA")]
	public Vector3 MIFNADCKEAD
	{
		[Cpp2IlInjected.Token(Token = "0x60002F6")]
		[Cpp2IlInjected.Address(RVA = "0x62183A0", Offset = "0x6216BA0", VA = "0x1862183A0")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000CB")]
	public Vector3 HJGLFOOGCAF
	{
		[Cpp2IlInjected.Token(Token = "0x60002F8")]
		[Cpp2IlInjected.Address(RVA = "0x621A400", Offset = "0x6218C00", VA = "0x18621A400")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000CC")]
	[Obsolete("Use TryGetWorldCenterOfMassOfHierarchy() or GetWorldCenterOfMassOfSelf()")]
	public Vector3 CCEGGEBAGNO
	{
		[Cpp2IlInjected.Token(Token = "0x60002F9")]
		[Cpp2IlInjected.Address(RVA = "0x621ABE0", Offset = "0x62193E0", VA = "0x18621ABE0", Slot = "8")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000CD")]
	[Obsolete("Use MassOfSelf or TryGetMassOfHierarchy instead")]
	public float FDPCBODPJHG
	{
		[Cpp2IlInjected.Token(Token = "0x60002FA")]
		[Cpp2IlInjected.Address(RVA = "0x6218340", Offset = "0x6216B40", VA = "0x186218340", Slot = "9")]
		get
		{
			return default(float);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000CE")]
	public float FFHDEPNCMPL
	{
		[Cpp2IlInjected.Token(Token = "0x60002FB")]
		[Cpp2IlInjected.Address(RVA = "0x6218640", Offset = "0x6216E40", VA = "0x186218640")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000CF")]
	public float PFMNCEKEBOC
	{
		[Cpp2IlInjected.Token(Token = "0x60002FC")]
		[Cpp2IlInjected.Address(RVA = "0x6218EF0", Offset = "0x62176F0", VA = "0x186218EF0", Slot = "10")]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x60002FD")]
		[Cpp2IlInjected.Address(RVA = "0x62186C0", Offset = "0x6216EC0", VA = "0x1862186C0", Slot = "11")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000D0")]
	public Vector3 ONJLJDCPIMM
	{
		[Cpp2IlInjected.Token(Token = "0x60002FE")]
		[Cpp2IlInjected.Address(RVA = "0x621A1F0", Offset = "0x62189F0", VA = "0x18621A1F0", Slot = "12")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000D1")]
	public Quaternion EKDPJMOLPAE
	{
		[Cpp2IlInjected.Token(Token = "0x60002FF")]
		[Cpp2IlInjected.Address(RVA = "0x621ABB0", Offset = "0x62193B0", VA = "0x18621ABB0", Slot = "13")]
		get
		{
			return default(Quaternion);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000D2")]
	private Rigidbody AIOLOONKHDH
	{
		[Cpp2IlInjected.Token(Token = "0x6000308")]
		[Cpp2IlInjected.Address(RVA = "0x62126A0", Offset = "0x6210EA0", VA = "0x1862126A0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000034")]
	public event EBFBHNJDFMO OEPHAIEKDOP
	{
		[Cpp2IlInjected.Token(Token = "0x60002F1")]
		[Cpp2IlInjected.Address(RVA = "0x6218850", Offset = "0x6217050", VA = "0x186218850", Slot = "4")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60002F2")]
		[Cpp2IlInjected.Address(RVA = "0x621B320", Offset = "0x6219B20", VA = "0x18621B320", Slot = "5")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60002F3")]
	[Cpp2IlInjected.Address(RVA = "0x621B540", Offset = "0x6219D40", VA = "0x18621B540")]
	public FCMELOBGJFH(ACNEEEENOML AHGOPBJOELE, [In] ACDBPOHPAKH AELCABDCBDD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002F7")]
	[Cpp2IlInjected.Address(RVA = "0x621B420", Offset = "0x6219C20", VA = "0x18621B420")]
	public float3 PHJPKPNMEDK()
	{
		return default(float3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000300")]
	[Cpp2IlInjected.Address(RVA = "0x621A920", Offset = "0x6219120", VA = "0x18621A920", Slot = "14")]
	public void HFHDCMEIKAH((Quaternion rot, Vector3 moments) MOGJAEMHOKI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000301")]
	[Cpp2IlInjected.Address(RVA = "0x6218450", Offset = "0x6216C50", VA = "0x186218450", Slot = "16")]
	public void ALFIJHNHMBG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000302")]
	[Cpp2IlInjected.Address(RVA = "0x6217E70", Offset = "0x6216670", VA = "0x186217E70", Slot = "15")]
	public void AECDOEBBECA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000303")]
	[Cpp2IlInjected.Address(RVA = "0x6218780", Offset = "0x6216F80", VA = "0x186218780", Slot = "18")]
	public void DOIABHKLMHG(Rigidbody JFKGLMKHADB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000304")]
	[Cpp2IlInjected.Address(RVA = "0x621A530", Offset = "0x6218D30", VA = "0x18621A530", Slot = "19")]
	public void HAKPNCDKJGA(Rigidbody JFKGLMKHADB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000305")]
	[Cpp2IlInjected.Address(RVA = "0x621B3C0", Offset = "0x6219BC0", VA = "0x18621B3C0", Slot = "17")]
	public void PFMKNBPMAJC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000306")]
	[Cpp2IlInjected.Address(RVA = "0x62188F0", Offset = "0x62170F0", VA = "0x1862188F0", Slot = "20")]
	public void FCAHOLPEHIP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000307")]
	[Cpp2IlInjected.Address(RVA = "0x6218F50", Offset = "0x6217750", VA = "0x186218F50")]
	public void FHEJIMLBMMB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000309")]
	[Cpp2IlInjected.Address(RVA = "0x62181C0", Offset = "0x62169C0", VA = "0x1862181C0")]
	private void GJHMJCDBJPJ(Vector3 FKKGMPDEPMA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600030A")]
	[Cpp2IlInjected.Address(RVA = "0x621A220", Offset = "0x6218A20", VA = "0x18621A220")]
	[Obsolete("Changes based on context.  the unity rigidbody center of mass has a different scale as well")]
	private Vector3 GBEENDIEECB()
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x600030B")]
	[Cpp2IlInjected.Address(RVA = "0x62186C0", Offset = "0x6216EC0", VA = "0x1862186C0")]
	private void CLPJMBCAHEL(float FKKGMPDEPMA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600030C")]
	[Cpp2IlInjected.Address(RVA = "0x621AE80", Offset = "0x6219680", VA = "0x18621AE80")]
	private Vector3 LODNGBLOAPP()
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x600030D")]
	[Cpp2IlInjected.Address(RVA = "0x621B0E0", Offset = "0x62198E0", VA = "0x18621B0E0")]
	private Quaternion MGGBONNJOOL()
	{
		return default(Quaternion);
	}

	[Cpp2IlInjected.Token(Token = "0x600030E")]
	[Cpp2IlInjected.Address(RVA = "0x6218F90", Offset = "0x6217790", VA = "0x186218F90")]
	internal (float, Vector3) FJHOJGMHILJ(Rigidbody EIHBMPLDGIB)
	{
		return default((float, Vector3));
	}
}
[Cpp2IlInjected.Token(Token = "0x2000033")]
internal static class EICHJIEFDKO
{
	[Cpp2IlInjected.Token(Token = "0x600030F")]
	[Cpp2IlInjected.Address(RVA = "0x62172E0", Offset = "0x6215AE0", VA = "0x1862172E0")]
	public static FCMELOBGJFH KFCBJHMAPGF(this ACNEEEENOML PCEPPDLMHCM)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000034")]
internal sealed class EJELAKIHFDF : JFBGLNFANHP, CFLOPMDOLBK
{
	[Cpp2IlInjected.Token(Token = "0x170000D3")]
	public bool ALFMGFEAILH
	{
		[Cpp2IlInjected.Token(Token = "0x6000310")]
		[Cpp2IlInjected.Address(RVA = "0x6217550", Offset = "0x6215D50", VA = "0x186217550", Slot = "10")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000D4")]
	public LKCJDGFAJNM LHLDLDFNNPI
	{
		[Cpp2IlInjected.Token(Token = "0x6000311")]
		[Cpp2IlInjected.Address(RVA = "0x62174F0", Offset = "0x6215CF0", VA = "0x1862174F0", Slot = "11")]
		get
		{
			return default(LKCJDGFAJNM);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000D5")]
	private LKCJDGFAJNM FLILNPFHLJG
	{
		[Cpp2IlInjected.Token(Token = "0x6000313")]
		[Cpp2IlInjected.Address(RVA = "0x62174F0", Offset = "0x6215CF0", VA = "0x1862174F0")]
		get
		{
			return default(LKCJDGFAJNM);
		}
		[Cpp2IlInjected.Token(Token = "0x6000314")]
		[Cpp2IlInjected.Address(RVA = "0x6217930", Offset = "0x6216130", VA = "0x186217930")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000312")]
	[Cpp2IlInjected.Address(RVA = "0x6217C80", Offset = "0x6216480", VA = "0x186217C80")]
	public EJELAKIHFDF(ACNEEEENOML AHGOPBJOELE, [In] ACDBPOHPAKH AELCABDCBDD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000315")]
	[Cpp2IlInjected.Address(RVA = "0x62173F0", Offset = "0x6215BF0", VA = "0x1862173F0", Slot = "4")]
	public void BMFHLKIGOGD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000316")]
	[Cpp2IlInjected.Address(RVA = "0x62177D0", Offset = "0x6215FD0", VA = "0x1862177D0")]
	private bool IHHEDOOEMJC()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000317")]
	[Cpp2IlInjected.Address(RVA = "0x62175B0", Offset = "0x6215DB0", VA = "0x1862175B0", Slot = "5")]
	public void DOABBELLDJM(object KIAKEGJPMAL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000318")]
	[Cpp2IlInjected.Address(RVA = "0x6217370", Offset = "0x6215B70", VA = "0x186217370", Slot = "6")]
	public void BDNICLLPIJJ(object KIAKEGJPMAL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000319")]
	[Cpp2IlInjected.Address(RVA = "0x6217B20", Offset = "0x6216320", VA = "0x186217B20", Slot = "9")]
	public void OPGFFJKLKHF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600031A")]
	[Cpp2IlInjected.Address(RVA = "0x62179A0", Offset = "0x62161A0", VA = "0x1862179A0")]
	private void OFPKPHPPIAJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600031B")]
	[Cpp2IlInjected.Address(RVA = "0x6217630", Offset = "0x6215E30", VA = "0x186217630")]
	private void HBPOAAAGACC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600031C")]
	[Cpp2IlInjected.Address(RVA = "0x62178B0", Offset = "0x62160B0", VA = "0x1862178B0", Slot = "8")]
	public void MECFNGIPFAC(ACNEEEENOML AHGOPBJOELE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600031D")]
	[Cpp2IlInjected.Address(RVA = "0x6217AA0", Offset = "0x62162A0", VA = "0x186217AA0", Slot = "7")]
	public void OONMABADHAF(ACNEEEENOML AHGOPBJOELE)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000035")]
internal sealed class LJNONOCEPGC : JFBGLNFANHP, DMPEOOKGLDG
{
	[Cpp2IlInjected.Token(Token = "0x170000D6")]
	public bool AIFLGAACHML
	{
		[Cpp2IlInjected.Token(Token = "0x6000320")]
		[Cpp2IlInjected.Address(RVA = "0x62232B0", Offset = "0x6221AB0", VA = "0x1862232B0", Slot = "7")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000D7")]
	private bool LIHNCLAKMFG
	{
		[Cpp2IlInjected.Token(Token = "0x6000321")]
		[Cpp2IlInjected.Address(RVA = "0x62236A0", Offset = "0x6221EA0", VA = "0x1862236A0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000035")]
	public event EBFBHNJDFMO KOMDEBFEEEP
	{
		[Cpp2IlInjected.Token(Token = "0x600031E")]
		[Cpp2IlInjected.Address(RVA = "0x6223550", Offset = "0x6221D50", VA = "0x186223550", Slot = "4")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600031F")]
		[Cpp2IlInjected.Address(RVA = "0x62235F0", Offset = "0x6221DF0", VA = "0x1862235F0", Slot = "5")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000322")]
	[Cpp2IlInjected.Address(RVA = "0x6216F70", Offset = "0x6215770", VA = "0x186216F70")]
	public LJNONOCEPGC(ACNEEEENOML AHGOPBJOELE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000323")]
	[Cpp2IlInjected.Address(RVA = "0x62234E0", Offset = "0x6221CE0", VA = "0x1862234E0", Slot = "11")]
	public IDisposable HIJEMOJOGMK()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000324")]
	[Cpp2IlInjected.Address(RVA = "0x6223690", Offset = "0x6221E90", VA = "0x186223690", Slot = "8")]
	public void JOKCPNGIIMH(object KIAKEGJPMAL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000325")]
	[Cpp2IlInjected.Address(RVA = "0x6223310", Offset = "0x6221B10", VA = "0x186223310", Slot = "9")]
	public void CFLECLOAECH(object KIAKEGJPMAL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000326")]
	[Cpp2IlInjected.Address(RVA = "0x6223700", Offset = "0x6221F00", VA = "0x186223700", Slot = "10")]
	public void PHMJJJCNKII(object KIAKEGJPMAL, bool JMNDFKAOINO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000327")]
	[Cpp2IlInjected.Address(RVA = "0x6223320", Offset = "0x6221B20", VA = "0x186223320", Slot = "12")]
	public void DOIABHKLMHG(Rigidbody KFJMODPJOOA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000328")]
	[Cpp2IlInjected.Address(RVA = "0x6223400", Offset = "0x6221C00", VA = "0x186223400", Slot = "13")]
	public void HAKPNCDKJGA(Rigidbody JFKGLMKHADB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000329")]
	[Cpp2IlInjected.Address(RVA = "0x6218F50", Offset = "0x6217750", VA = "0x186218F50", Slot = "6")]
	public void GPJJKLDHAFI()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000036")]
internal sealed class LJKOHGONIHB : JFBGLNFANHP, DCKAOPOPPEM, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000051")]
	private PhotonView LOIBHJHOJDK;

	[Cpp2IlInjected.Token(Token = "0x170000D8")]
	public bool LFEOJFGHFML
	{
		[Cpp2IlInjected.Token(Token = "0x600032C")]
		[Cpp2IlInjected.Address(RVA = "0x6222050", Offset = "0x6220850", VA = "0x186222050", Slot = "6")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000D9")]
	public bool NEIGPDMIINK
	{
		[Cpp2IlInjected.Token(Token = "0x600032D")]
		[Cpp2IlInjected.Address(RVA = "0x6222FA0", Offset = "0x62217A0", VA = "0x186222FA0", Slot = "7")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000036")]
	public event EBFBHNJDFMO GILKHDKMEND
	{
		[Cpp2IlInjected.Token(Token = "0x600032A")]
		[Cpp2IlInjected.Address(RVA = "0x62226A0", Offset = "0x6220EA0", VA = "0x1862226A0", Slot = "4")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600032B")]
		[Cpp2IlInjected.Address(RVA = "0x6222F00", Offset = "0x6221700", VA = "0x186222F00", Slot = "5")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600032E")]
	[Cpp2IlInjected.Address(RVA = "0x62231F0", Offset = "0x62219F0", VA = "0x1862231F0")]
	public LJKOHGONIHB(ACNEEEENOML AHGOPBJOELE, [In] ACDBPOHPAKH AELCABDCBDD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600032F")]
	[Cpp2IlInjected.Address(RVA = "0x6222740", Offset = "0x6220F40", VA = "0x186222740", Slot = "8")]
	public void BMFHLKIGOGD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000330")]
	[Cpp2IlInjected.Address(RVA = "0x6222C50", Offset = "0x6221450", VA = "0x186222C50", Slot = "11")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000331")]
	[Cpp2IlInjected.Address(RVA = "0x62224A0", Offset = "0x6220CA0", VA = "0x1862224A0", Slot = "9")]
	public void ACFBEMHJHMI(ACNEEEENOML OBIIIBPBMLD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000332")]
	[Cpp2IlInjected.Address(RVA = "0x6222870", Offset = "0x6221070", VA = "0x186222870", Slot = "10")]
	public void DDKAOBEOLDP(ACNEEEENOML OBIIIBPBMLD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000333")]
	[Cpp2IlInjected.Address(RVA = "0x6222A70", Offset = "0x6221270", VA = "0x186222A70")]
	private void DKLKILDINMO(PhotonView PJIECOLLBDM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000334")]
	[Cpp2IlInjected.Address(RVA = "0x6222DB0", Offset = "0x62215B0", VA = "0x186222DB0")]
	private void JKCNNCNLLDO(RigidbodyEx LKDGACMBLIN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000335")]
	[Cpp2IlInjected.Address(RVA = "0x6223030", Offset = "0x6221830", VA = "0x186223030")]
	private void PHMOFOGLJEL(PhotonView HELMMFHGEMG)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000037")]
internal static class JOBKBACAJIK
{
	[Cpp2IlInjected.Token(Token = "0x6000336")]
	[Cpp2IlInjected.Address(RVA = "0x62216D0", Offset = "0x621FED0", VA = "0x1862216D0")]
	public static LJKOHGONIHB IHAICJCJPBD(this ALHCFOHGNMD PCEPPDLMHCM)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000038")]
internal sealed class CMCMKGDDJNN : JFBGLNFANHP, GCEONIOPFOG
{
	[Cpp2IlInjected.Token(Token = "0x170000DA")]
	public bool JIAMCDEEBDI
	{
		[Cpp2IlInjected.Token(Token = "0x6000337")]
		[Cpp2IlInjected.Address(RVA = "0x6215760", Offset = "0x6213F60", VA = "0x186215760", Slot = "4")]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000338")]
		[Cpp2IlInjected.Address(RVA = "0x62157C0", Offset = "0x6213FC0", VA = "0x1862157C0", Slot = "5")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000DB")]
	public bool OHGMMHIOBGA
	{
		[Cpp2IlInjected.Token(Token = "0x6000339")]
		[Cpp2IlInjected.Address(RVA = "0x6215680", Offset = "0x6213E80", VA = "0x186215680", Slot = "6")]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x600033A")]
		[Cpp2IlInjected.Address(RVA = "0x6215610", Offset = "0x6213E10", VA = "0x186215610")]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000DC")]
	public RigidbodyConstraints LKJNJPEFLGB
	{
		[Cpp2IlInjected.Token(Token = "0x600033B")]
		[Cpp2IlInjected.Address(RVA = "0x62155B0", Offset = "0x6213DB0", VA = "0x1862155B0", Slot = "7")]
		get
		{
			return default(RigidbodyConstraints);
		}
		[Cpp2IlInjected.Token(Token = "0x600033C")]
		[Cpp2IlInjected.Address(RVA = "0x62153A0", Offset = "0x6213BA0", VA = "0x1862153A0", Slot = "8")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600033D")]
	[Cpp2IlInjected.Address(RVA = "0x6215830", Offset = "0x6214030", VA = "0x186215830")]
	public CMCMKGDDJNN(ACNEEEENOML AHGOPBJOELE, [In] ACDBPOHPAKH AELCABDCBDD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600033E")]
	[Cpp2IlInjected.Address(RVA = "0x6215520", Offset = "0x6213D20", VA = "0x186215520", Slot = "9")]
	public void DOIABHKLMHG(Rigidbody JFKGLMKHADB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600033F")]
	[Cpp2IlInjected.Address(RVA = "0x62156E0", Offset = "0x6213EE0", VA = "0x1862156E0", Slot = "10")]
	public void HAKPNCDKJGA(Rigidbody JFKGLMKHADB)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000039")]
internal sealed class EBJEIJDKGGA : JFBGLNFANHP, BMMIOFOJJEB
{
	[Cpp2IlInjected.Token(Token = "0x170000DD")]
	public float EPNHAMDEIMB
	{
		[Cpp2IlInjected.Token(Token = "0x6000341")]
		[Cpp2IlInjected.Address(RVA = "0x6216C70", Offset = "0x6215470", VA = "0x186216C70", Slot = "4")]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x6000342")]
		[Cpp2IlInjected.Address(RVA = "0x6216CD0", Offset = "0x62154D0", VA = "0x186216CD0", Slot = "5")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000DE")]
	public float FJKLFMLIIEM
	{
		[Cpp2IlInjected.Token(Token = "0x6000343")]
		[Cpp2IlInjected.Address(RVA = "0x6216B40", Offset = "0x6215340", VA = "0x186216B40", Slot = "6")]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x6000344")]
		[Cpp2IlInjected.Address(RVA = "0x6216E20", Offset = "0x6215620", VA = "0x186216E20", Slot = "7")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000340")]
	[Cpp2IlInjected.Address(RVA = "0x6216F70", Offset = "0x6215770", VA = "0x186216F70")]
	public EBJEIJDKGGA(ACNEEEENOML AHGOPBJOELE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000345")]
	[Cpp2IlInjected.Address(RVA = "0x6216A50", Offset = "0x6215250", VA = "0x186216A50", Slot = "8")]
	public void DOIABHKLMHG(Rigidbody JFKGLMKHADB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000346")]
	[Cpp2IlInjected.Address(RVA = "0x6216BA0", Offset = "0x62153A0", VA = "0x186216BA0", Slot = "9")]
	public void HAKPNCDKJGA(Rigidbody JFKGLMKHADB)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200003A")]
[DEONFKEHMJD(typeof(BMDAIBCMAJA), new string[] { })]
public sealed class HMAAKHOBFEL : GJOKPFDLDCJ, BMDAIBCMAJA, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000052")]
	[NMIHDJKFGCM]
	private HCLOJIAEBDJ AHGOPBJOELE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000053")]
	private bool KIMEMKKPGDJ;

	[Cpp2IlInjected.Token(Token = "0x170000DF")]
	public bool AMDAEMPIIPG
	{
		[Cpp2IlInjected.Token(Token = "0x6000349")]
		[Cpp2IlInjected.Address(RVA = "0x7D07D0", Offset = "0x7CEFD0", VA = "0x1807D07D0", Slot = "5")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000347")]
	[Cpp2IlInjected.Address(RVA = "0x621EF40", Offset = "0x621D740", VA = "0x18621EF40", Slot = "4")]
	public void InitReferences(HMNFMHNMJBH CJEADCONOPM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000348")]
	[Cpp2IlInjected.Address(RVA = "0x621ED00", Offset = "0x621D500", VA = "0x18621ED00", Slot = "8")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600034A")]
	[Cpp2IlInjected.Address(RVA = "0x621ED30", Offset = "0x621D530", VA = "0x18621ED30", Slot = "6")]
	public void FJHOJGMHILJ(INJNNPDEJLM JFIBILKOJPE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600034B")]
	[Cpp2IlInjected.Address(RVA = "0x621EF90", Offset = "0x621D790", VA = "0x18621EF90", Slot = "7")]
	public void JPNFKGDLPJK(INJNNPDEJLM JFIBILKOJPE, bool FOMHBABPBHI, bool DENPJGOIMJC, bool NGGLFKLDIBJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600034C")]
	[Cpp2IlInjected.Address(RVA = "0x621F1B0", Offset = "0x621D9B0", VA = "0x18621F1B0")]
	private bool OCFDBCCLHJG(INJNNPDEJLM JFIBILKOJPE, [Out] LNEFAENNCOP PCEPPDLMHCM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600034D")]
	[Cpp2IlInjected.Address(RVA = "0x621EE50", Offset = "0x621D650", VA = "0x18621EE50")]
	private bool FLKLKIAOJFB(INJNNPDEJLM JFIBILKOJPE, [Out] FCMELOBGJFH JEKBCFJMHGC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600034E")]
	[Cpp2IlInjected.Address(RVA = "0x76E470", Offset = "0x76CC70", VA = "0x18076E470")]
	public HMAAKHOBFEL()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200003B")]
internal sealed class PDDMPDPAFDD : JFBGLNFANHP, CCAMOPPOPEI
{
	[Cpp2IlInjected.Token(Token = "0x170000E0")]
	private Rigidbody AIOLOONKHDH
	{
		[Cpp2IlInjected.Token(Token = "0x6000351")]
		[Cpp2IlInjected.Address(RVA = "0x62126A0", Offset = "0x6210EA0", VA = "0x1862126A0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000E1")]
	private bool FAHPFCJEPJO
	{
		[Cpp2IlInjected.Token(Token = "0x6000352")]
		[Cpp2IlInjected.Address(RVA = "0x6224700", Offset = "0x6222F00", VA = "0x186224700")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000E2")]
	private ACNEEEENOML MLDLDJMPPGN
	{
		[Cpp2IlInjected.Token(Token = "0x6000353")]
		[Cpp2IlInjected.Address(RVA = "0x622C240", Offset = "0x622AA40", VA = "0x18622C240")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000E3")]
	private bool IDEKMMEBDBI
	{
		[Cpp2IlInjected.Token(Token = "0x6000354")]
		[Cpp2IlInjected.Address(RVA = "0x622CAE0", Offset = "0x622B2E0", VA = "0x18622CAE0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000E4")]
	private bool POFPFELPEIB
	{
		[Cpp2IlInjected.Token(Token = "0x6000355")]
		[Cpp2IlInjected.Address(RVA = "0x622C510", Offset = "0x622AD10", VA = "0x18622C510")]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000356")]
		[Cpp2IlInjected.Address(RVA = "0x622C2A0", Offset = "0x622AAA0", VA = "0x18622C2A0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000E5")]
	private bool JJNGFMOGHMM
	{
		[Cpp2IlInjected.Token(Token = "0x6000357")]
		[Cpp2IlInjected.Address(RVA = "0x622C4B0", Offset = "0x622ACB0", VA = "0x18622C4B0")]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000358")]
		[Cpp2IlInjected.Address(RVA = "0x622C1D0", Offset = "0x622A9D0", VA = "0x18622C1D0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000E6")]
	private int HHOCBENELJA
	{
		[Cpp2IlInjected.Token(Token = "0x6000359")]
		[Cpp2IlInjected.Address(RVA = "0x622C6B0", Offset = "0x622AEB0", VA = "0x18622C6B0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000037")]
	public event EBFBHNJDFMO CDIFNKKNIAI
	{
		[Cpp2IlInjected.Token(Token = "0x600034F")]
		[Cpp2IlInjected.Address(RVA = "0x622C610", Offset = "0x622AE10", VA = "0x18622C610", Slot = "4")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000350")]
		[Cpp2IlInjected.Address(RVA = "0x622C570", Offset = "0x622AD70", VA = "0x18622C570", Slot = "5")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600035A")]
	[Cpp2IlInjected.Address(RVA = "0x622CBB0", Offset = "0x622B3B0", VA = "0x18622CBB0")]
	public PDDMPDPAFDD(ACNEEEENOML AHGOPBJOELE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600035B")]
	[Cpp2IlInjected.Address(RVA = "0x622C400", Offset = "0x622AC00", VA = "0x18622C400", Slot = "6")]
	public void BMFHLKIGOGD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600035C")]
	[Cpp2IlInjected.Address(RVA = "0x622CB40", Offset = "0x622B340", VA = "0x18622CB40", Slot = "8")]
	public void OPPINPEGPBG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600035D")]
	[Cpp2IlInjected.Address(RVA = "0x622C720", Offset = "0x622AF20", VA = "0x18622C720", Slot = "7")]
	public bool ICIHJKDLIHF()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600035E")]
	[Cpp2IlInjected.Address(RVA = "0x622C310", Offset = "0x622AB10", VA = "0x18622C310", Slot = "9")]
	public void BHMFFCOHDEE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600035F")]
	[Cpp2IlInjected.Address(RVA = "0x6218F50", Offset = "0x6217750", VA = "0x186218F50", Slot = "12")]
	public void MMKNBNPGODE(bool IIBPGCHKBGC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000360")]
	[Cpp2IlInjected.Address(RVA = "0x622C9A0", Offset = "0x622B1A0", VA = "0x18622C9A0", Slot = "11")]
	public void JAEFDNECOPP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000361")]
	[Cpp2IlInjected.Address(RVA = "0x7644F0", Offset = "0x762CF0", VA = "0x1807644F0", Slot = "10")]
	public void KNGOMHMODPL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000362")]
	[Cpp2IlInjected.Address(RVA = "0x622C8C0", Offset = "0x622B0C0", VA = "0x18622C8C0")]
	private void IKMBINBPBPA()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200003C")]
internal sealed class ONLECKMHKOE : JFBGLNFANHP, JGMBKBLBJEA
{
	[Cpp2IlInjected.Token(Token = "0x170000E7")]
	public Rigidbody AIOLOONKHDH
	{
		[Cpp2IlInjected.Token(Token = "0x6000363")]
		[Cpp2IlInjected.Address(RVA = "0x622BA50", Offset = "0x622A250", VA = "0x18622BA50", Slot = "4")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000364")]
		[Cpp2IlInjected.Address(RVA = "0x622BD80", Offset = "0x622A580", VA = "0x18622BD80")]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000E8")]
	private bool IDEKMMEBDBI
	{
		[Cpp2IlInjected.Token(Token = "0x6000365")]
		[Cpp2IlInjected.Address(RVA = "0x6212F70", Offset = "0x6211770", VA = "0x186212F70")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000E9")]
	public bool GFPPOAEOHBK
	{
		[Cpp2IlInjected.Token(Token = "0x6000368")]
		[Cpp2IlInjected.Address(RVA = "0x622B6E0", Offset = "0x6229EE0", VA = "0x18622B6E0", Slot = "6")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000366")]
	[Cpp2IlInjected.Address(RVA = "0x622C110", Offset = "0x622A910", VA = "0x18622C110")]
	public ONLECKMHKOE(ACNEEEENOML AHGOPBJOELE, [In] ACDBPOHPAKH AELCABDCBDD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000367")]
	[Cpp2IlInjected.Address(RVA = "0x622B740", Offset = "0x6229F40", VA = "0x18622B740", Slot = "5")]
	public void BMFHLKIGOGD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000369")]
	[Cpp2IlInjected.Address(RVA = "0x622BD00", Offset = "0x622A500", VA = "0x18622BD00", Slot = "7")]
	public void JBAEFNMGPHP(object KIAKEGJPMAL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600036A")]
	[Cpp2IlInjected.Address(RVA = "0x622BE70", Offset = "0x622A670", VA = "0x18622BE70", Slot = "8")]
	public void MODGFAKLIIP(object KIAKEGJPMAL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600036B")]
	[Cpp2IlInjected.Address(RVA = "0x622BEF0", Offset = "0x622A6F0", VA = "0x18622BEF0", Slot = "9")]
	public void OJCMDDNBENE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600036C")]
	[Cpp2IlInjected.Address(RVA = "0x622B7F0", Offset = "0x6229FF0", VA = "0x18622B7F0", Slot = "11")]
	public void DLHJKDHKDKC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600036D")]
	[Cpp2IlInjected.Address(RVA = "0x622BB30", Offset = "0x622A330", VA = "0x18622BB30", Slot = "12")]
	public void HPFPPKNCMIM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600036E")]
	[Cpp2IlInjected.Address(RVA = "0x7644F0", Offset = "0x762CF0", VA = "0x1807644F0", Slot = "10")]
	public void FGAAMJAJOOG()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200003D")]
internal sealed class LLMDKOFHJPP : JFBGLNFANHP, LGAMKIPMADE, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x170000EA")]
	public CPIKNIBKFKL GNLKAEJNEDB
	{
		[Cpp2IlInjected.Token(Token = "0x600036F")]
		[Cpp2IlInjected.Address(RVA = "0x6224B00", Offset = "0x6223300", VA = "0x186224B00", Slot = "4")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000370")]
		[Cpp2IlInjected.Address(RVA = "0x6223D80", Offset = "0x6222580", VA = "0x186223D80", Slot = "5")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000EB")]
	public OKPICPJMDEO JKKMJBKLALO
	{
		[Cpp2IlInjected.Token(Token = "0x6000371")]
		[Cpp2IlInjected.Address(RVA = "0x6223CD0", Offset = "0x62224D0", VA = "0x186223CD0", Slot = "6")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000372")]
		[Cpp2IlInjected.Address(RVA = "0x6225F70", Offset = "0x6224770", VA = "0x186225F70", Slot = "7")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000EC")]
	public Vector3 NBKAJOJDMMI
	{
		[Cpp2IlInjected.Token(Token = "0x6000373")]
		[Cpp2IlInjected.Address(RVA = "0x6226260", Offset = "0x6224A60", VA = "0x186226260", Slot = "8")]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x6000374")]
		[Cpp2IlInjected.Address(RVA = "0x6225620", Offset = "0x6223E20", VA = "0x186225620", Slot = "9")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000ED")]
	public Vector3 LAGBGBLAELJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000375")]
		[Cpp2IlInjected.Address(RVA = "0x6226D10", Offset = "0x6225510", VA = "0x186226D10", Slot = "10")]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x6000376")]
		[Cpp2IlInjected.Address(RVA = "0x6225F40", Offset = "0x6224740", VA = "0x186225F40", Slot = "11")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000EE")]
	public Vector3 POIAGHOEFEB
	{
		[Cpp2IlInjected.Token(Token = "0x6000377")]
		[Cpp2IlInjected.Address(RVA = "0x6223C70", Offset = "0x6222470", VA = "0x186223C70", Slot = "12")]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x6000378")]
		[Cpp2IlInjected.Address(RVA = "0x6224640", Offset = "0x6222E40", VA = "0x186224640", Slot = "13")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000EF")]
	public Vector3 FFPCNDPLCPM
	{
		[Cpp2IlInjected.Token(Token = "0x6000379")]
		[Cpp2IlInjected.Address(RVA = "0x6226D40", Offset = "0x6225540", VA = "0x186226D40", Slot = "14")]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x600037A")]
		[Cpp2IlInjected.Address(RVA = "0x6224BB0", Offset = "0x62233B0", VA = "0x186224BB0", Slot = "15")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000F0")]
	public float ICPKIGJHHCD
	{
		[Cpp2IlInjected.Token(Token = "0x600037B")]
		[Cpp2IlInjected.Address(RVA = "0x6226840", Offset = "0x6225040", VA = "0x186226840", Slot = "16")]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x600037C")]
		[Cpp2IlInjected.Address(RVA = "0x6223800", Offset = "0x6222000", VA = "0x186223800", Slot = "17")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000F1")]
	public bool KIEFCCGGPLM
	{
		[Cpp2IlInjected.Token(Token = "0x600037E")]
		[Cpp2IlInjected.Address(RVA = "0x6224410", Offset = "0x6222C10", VA = "0x186224410", Slot = "18")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000F2")]
	private AICDKPBPOFE BKGLDNDEEPH
	{
		[Cpp2IlInjected.Token(Token = "0x6000391")]
		[Cpp2IlInjected.Address(RVA = "0x1C13E70", Offset = "0x1C12670", VA = "0x181C13E70")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000F3")]
	private bool FAHPFCJEPJO
	{
		[Cpp2IlInjected.Token(Token = "0x6000392")]
		[Cpp2IlInjected.Address(RVA = "0x6224700", Offset = "0x6222F00", VA = "0x186224700")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600037D")]
	[Cpp2IlInjected.Address(RVA = "0x6216F70", Offset = "0x6215770", VA = "0x186216F70")]
	public LLMDKOFHJPP(ACNEEEENOML AHGOPBJOELE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600037F")]
	[Cpp2IlInjected.Address(RVA = "0x6223C00", Offset = "0x6222400", VA = "0x186223C00", Slot = "20")]
	public void BAFPOBKCHMD(object KIAKEGJPMAL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000380")]
	[Cpp2IlInjected.Address(RVA = "0x6224720", Offset = "0x6222F20", VA = "0x186224720", Slot = "30")]
	public void CNCFJMCKEII(object KIAKEGJPMAL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000381")]
	[Cpp2IlInjected.Address(RVA = "0x6223DF0", Offset = "0x62225F0", VA = "0x186223DF0", Slot = "19")]
	public void BMFHLKIGOGD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000382")]
	[Cpp2IlInjected.Address(RVA = "0x6224900", Offset = "0x6223100", VA = "0x186224900", Slot = "36")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000383")]
	[Cpp2IlInjected.Address(RVA = "0x6224790", Offset = "0x6222F90", VA = "0x186224790", Slot = "28")]
	public void DOIABHKLMHG(Rigidbody JFKGLMKHADB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000384")]
	[Cpp2IlInjected.Address(RVA = "0x6225740", Offset = "0x6223F40", VA = "0x186225740", Slot = "35")]
	public Vector3 JOHAPINPNIG(Vector3 CPFDNDKFHHH)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000385")]
	[Cpp2IlInjected.Address(RVA = "0x6226F40", Offset = "0x6225740", VA = "0x186226F40", Slot = "34")]
	public Vector3 OJGIMCLJCBO(Vector3 AMLAOHJLKAL)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000386")]
	[Cpp2IlInjected.Address(RVA = "0x6223DF0", Offset = "0x62225F0", VA = "0x186223DF0", Slot = "27")]
	public void HPICNCAEGKH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000387")]
	[Cpp2IlInjected.Address(RVA = "0x62249C0", Offset = "0x62231C0", VA = "0x1862249C0", Slot = "25")]
	public void ELAIKNOJDMF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000388")]
	[Cpp2IlInjected.Address(RVA = "0x6224E20", Offset = "0x6223620", VA = "0x186224E20", Slot = "24")]
	public void GAIPCILJLMB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000389")]
	[Cpp2IlInjected.Address(RVA = "0x6224BE0", Offset = "0x62233E0", VA = "0x186224BE0", Slot = "33")]
	public void FOPGOBMGCOM(Vector3 HDFIANGNHPD, Vector3 OPNLLPIFKNP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600038A")]
	[Cpp2IlInjected.Address(RVA = "0x62268A0", Offset = "0x62250A0", VA = "0x1862268A0", Slot = "32")]
	public void MDMIGCOMJCF(Vector3 JPNLAOHAPPM, Vector3 CHFCHAFCOBM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600038B")]
	[Cpp2IlInjected.Address(RVA = "0x6226D70", Offset = "0x6225570", VA = "0x186226D70", Slot = "31")]
	public void OGHMBOLGHFB(Vector3 FJNLGGLHPIL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600038C")]
	[Cpp2IlInjected.Address(RVA = "0x6223EA0", Offset = "0x62226A0", VA = "0x186223EA0", Slot = "22")]
	public void CCOMMPLBNFB(BPNODJIJBLA KADKJKFHDBE, Vector3 MCCPDDLJGEG, float EGMGOJMNMKL, float FLCBFAEIBEI = 8f, float MMINJAGEDBL = 1f)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600038D")]
	[Cpp2IlInjected.Address(RVA = "0x6223950", Offset = "0x6222150", VA = "0x186223950", Slot = "21")]
	public void AFAJHDMGFMF(LJGOMBGDPDM GJBGJOHBOBM, Vector3 GNFMGLELAKB, float JICJOBGCGOP = float.PositiveInfinity)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600038E")]
	[Cpp2IlInjected.Address(RVA = "0x6226900", Offset = "0x6225100", VA = "0x186226900", Slot = "23")]
	[Obsolete("Deprecated. Still exists to support deprecated CV2 chips. Use ApplyAngularVelocityChange.")]
	public void MPMCBKEHDIK(LJGOMBGDPDM GJBGJOHBOBM, Vector3 OHMBDAJNEIJ, float GEPDJOHNEPN = 7f, float JINKMCECFKA = 1f)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600038F")]
	[Cpp2IlInjected.Address(RVA = "0x6224A20", Offset = "0x6223220", VA = "0x186224A20", Slot = "29")]
	public Vector3 EMEDMNCJCCM(Vector3 NOCGKJGODHL)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000390")]
	[Cpp2IlInjected.Address(RVA = "0x6225490", Offset = "0x6223C90", VA = "0x186225490", Slot = "26")]
	public void JIMNECMIFKB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000393")]
	[Cpp2IlInjected.Address(RVA = "0x6223800", Offset = "0x6222000", VA = "0x186223800")]
	private void ABMCLIFBNMI(float FKKGMPDEPMA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000394")]
	[Cpp2IlInjected.Address(RVA = "0x6224470", Offset = "0x6222C70", VA = "0x186224470")]
	private void CIAJNBCJPIN(Vector3 GNFMGLELAKB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000395")]
	[Cpp2IlInjected.Address(RVA = "0x6225FE0", Offset = "0x62247E0", VA = "0x186225FE0")]
	private Vector3 LCGKOEAJLMA()
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000396")]
	[Cpp2IlInjected.Address(RVA = "0x62262C0", Offset = "0x6224AC0", VA = "0x1862262C0")]
	private void MDANCAMHGHE(Vector3 AMLAOHJLKAL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000397")]
	[Cpp2IlInjected.Address(RVA = "0x6227100", Offset = "0x6225900", VA = "0x186227100")]
	private Vector3 OOGKEFBBBJM()
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000398")]
	[Cpp2IlInjected.Address(RVA = "0x62259D0", Offset = "0x62241D0", VA = "0x1862259D0")]
	private void KGNMMCGBPJC(Vector3 FKKGMPDEPMA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000399")]
	[Cpp2IlInjected.Address(RVA = "0x62256E0", Offset = "0x6223EE0", VA = "0x1862256E0")]
	private void JMPHAECMPDJ(Vector3 NOCGKJGODHL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600039A")]
	[Cpp2IlInjected.Address(RVA = "0x6224E80", Offset = "0x6223680", VA = "0x186224E80")]
	private void IBFKCIFGDMP(Vector3 NMAGMMAOJAD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600039B")]
	[Cpp2IlInjected.Address(RVA = "0x6224EE0", Offset = "0x62236E0", VA = "0x186224EE0")]
	private void IPGGOCBALPD(string JOHPPIADHFA, Vector3 FKKGMPDEPMA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600039C")]
	[Cpp2IlInjected.Address(RVA = "0x6225920", Offset = "0x6224120", VA = "0x186225920")]
	private void KGMJDFGDNNO()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200003E")]
internal class JFBGLNFANHP
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000055")]
	protected readonly LNEFAENNCOP AHGOPBJOELE;

	[Cpp2IlInjected.Token(Token = "0x170000F4")]
	protected HCLOJIAEBDJ AKPDHIHOAHE
	{
		[Cpp2IlInjected.Token(Token = "0x600039D")]
		[Cpp2IlInjected.Address(RVA = "0x53F5930", Offset = "0x53F4130", VA = "0x1853F5930")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000F5")]
	protected INJNNPDEJLM NPICDLBODMG
	{
		[Cpp2IlInjected.Token(Token = "0x600039E")]
		[Cpp2IlInjected.Address(RVA = "0x53F5970", Offset = "0x53F4170", VA = "0x1853F5970")]
		get
		{
			return default(INJNNPDEJLM);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600039F")]
	[Cpp2IlInjected.Address(RVA = "0x6216F70", Offset = "0x6215770", VA = "0x186216F70")]
	public JFBGLNFANHP(ACNEEEENOML AHGOPBJOELE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003A0")]
	[Cpp2IlInjected.Address(RVA = "0x6220A30", Offset = "0x621F230", VA = "0x186220A30")]
	protected ACNEEEENOML IPJOIMABEBF(INJNNPDEJLM LHIGGCOIHEC)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200003F")]
public class DMDABBJBJAB : MIAHMAGCEAF
{
	[Cpp2IlInjected.Token(Token = "0x60003A1")]
	[Cpp2IlInjected.Address(RVA = "0x6216640", Offset = "0x6214E40", VA = "0x186216640", Slot = "4")]
	public PMHIGDLAJOP LPHHNKPAPHN(ACNEEEENOML PCEPPDLMHCM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003A2")]
	[Cpp2IlInjected.Address(RVA = "0x6215B60", Offset = "0x6214360", VA = "0x186215B60", Slot = "5")]
	public LGAMKIPMADE DFLGBNMMLBE(ACNEEEENOML PCEPPDLMHCM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003A3")]
	[Cpp2IlInjected.Address(RVA = "0x62160E0", Offset = "0x62148E0", VA = "0x1862160E0", Slot = "6")]
	public LMDEEHLJMOK HBEJLKNNCLJ(ACNEEEENOML PCEPPDLMHCM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003A4")]
	[Cpp2IlInjected.Address(RVA = "0x6215D80", Offset = "0x6214580", VA = "0x186215D80", Slot = "7")]
	public BMMIOFOJJEB ENNPPKGHEND(ACNEEEENOML PCEPPDLMHCM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003A5")]
	[Cpp2IlInjected.Address(RVA = "0x62166A0", Offset = "0x6214EA0", VA = "0x1862166A0", Slot = "8")]
	public CCAMOPPOPEI NJJBCPEJOKJ(ACNEEEENOML PCEPPDLMHCM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003A6")]
	[Cpp2IlInjected.Address(RVA = "0x62163A0", Offset = "0x6214BA0", VA = "0x1862163A0", Slot = "9")]
	public MCEBLIDMGME JEJILAFPABO(ACNEEEENOML PCEPPDLMHCM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003A7")]
	[Cpp2IlInjected.Address(RVA = "0x62161C0", Offset = "0x62149C0", VA = "0x1862161C0", Slot = "10")]
	public DMPEOOKGLDG HMGGCOHPDKE(ACNEEEENOML PCEPPDLMHCM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003A8")]
	[Cpp2IlInjected.Address(RVA = "0x6216000", Offset = "0x6214800", VA = "0x186216000", Slot = "11")]
	public AICDKPBPOFE GLEICABECAF(ACNEEEENOML PCEPPDLMHCM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003A9")]
	[Cpp2IlInjected.Address(RVA = "0x6216560", Offset = "0x6214D60", VA = "0x186216560", Slot = "12")]
	public NDKMMOHJIND LLPJONABCKF(ACNEEEENOML PCEPPDLMHCM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003AA")]
	[Cpp2IlInjected.Address(RVA = "0x6216480", Offset = "0x6214C80", VA = "0x186216480", Slot = "13")]
	public HEEAIGPCPDE KKCAOPGKIHB(ACNEEEENOML PCEPPDLMHCM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003AB")]
	[Cpp2IlInjected.Address(RVA = "0x6215A60", Offset = "0x6214260", VA = "0x186215A60")]
	public JGMBKBLBJEA CLIDGNAHFEE(ACNEEEENOML PCEPPDLMHCM, [In] ACDBPOHPAKH AELCABDCBDD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003AC")]
	[Cpp2IlInjected.Address(RVA = "0x62162A0", Offset = "0x6214AA0", VA = "0x1862162A0")]
	public DCKAOPOPPEM IBAPHKBNBJH(ACNEEEENOML PCEPPDLMHCM, [In] ACDBPOHPAKH AELCABDCBDD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003AD")]
	[Cpp2IlInjected.Address(RVA = "0x6215C40", Offset = "0x6214440", VA = "0x186215C40")]
	public CFLOPMDOLBK EMOCJGFEGOK(ACNEEEENOML PCEPPDLMHCM, [In] ACDBPOHPAKH AELCABDCBDD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003AE")]
	[Cpp2IlInjected.Address(RVA = "0x6215F90", Offset = "0x6214790", VA = "0x186215F90")]
	public KFKLGADFDEA GAKGMHFGJEP(ACNEEEENOML PCEPPDLMHCM, [In] ACDBPOHPAKH AELCABDCBDD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003AF")]
	[Cpp2IlInjected.Address(RVA = "0x6216820", Offset = "0x6215020", VA = "0x186216820")]
	public GCEONIOPFOG ONLCELJFDGF(ACNEEEENOML PCEPPDLMHCM, [In] ACDBPOHPAKH AELCABDCBDD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003B0")]
	[Cpp2IlInjected.Address(RVA = "0x6215E60", Offset = "0x6214660", VA = "0x186215E60", Slot = "19")]
	public ACNEEEENOML GAFOKFHHMAF(RigidbodyEx AHGOPBJOELE, ACDBPOHPAKH AELCABDCBDD, HGMBJJHEAKJ PNFHHOFJABN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003B1")]
	[Cpp2IlInjected.Address(RVA = "0x76E470", Offset = "0x76CC70", VA = "0x18076E470")]
	public DMDABBJBJAB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003B2")]
	[Cpp2IlInjected.Address(RVA = "0x6215A60", Offset = "0x6214260", VA = "0x186215A60", Slot = "14")]
	private JGMBKBLBJEA JGBBLPMFDAA(ACNEEEENOML PCEPPDLMHCM, [In] ACDBPOHPAKH AELCABDCBDD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003B3")]
	[Cpp2IlInjected.Address(RVA = "0x62162A0", Offset = "0x6214AA0", VA = "0x1862162A0", Slot = "15")]
	private DCKAOPOPPEM NBCJBJBBGJA(ACNEEEENOML PCEPPDLMHCM, [In] ACDBPOHPAKH AELCABDCBDD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003B4")]
	[Cpp2IlInjected.Address(RVA = "0x6215C40", Offset = "0x6214440", VA = "0x186215C40", Slot = "16")]
	private CFLOPMDOLBK DIGHOBCMEPJ(ACNEEEENOML PCEPPDLMHCM, [In] ACDBPOHPAKH AELCABDCBDD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003B5")]
	[Cpp2IlInjected.Address(RVA = "0x6215F90", Offset = "0x6214790", VA = "0x186215F90", Slot = "17")]
	private KFKLGADFDEA PPCAJAAIJOO(ACNEEEENOML PCEPPDLMHCM, [In] ACDBPOHPAKH AELCABDCBDD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003B6")]
	[Cpp2IlInjected.Address(RVA = "0x6216810", Offset = "0x6215010", VA = "0x186216810", Slot = "18")]
	private GCEONIOPFOG ONEDKFJHFID(ACNEEEENOML PCEPPDLMHCM, [In] ACDBPOHPAKH AELCABDCBDD)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000040")]
[DefaultMember("Item")]
public sealed class FMLCBGNJKFI : IReadOnlyList<ACNEEEENOML>, IEnumerable<ACNEEEENOML>, IEnumerable, IReadOnlyCollection<ACNEEEENOML>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000056")]
	public readonly INJNNPDEJLM LHIGGCOIHEC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000057")]
	public readonly HCLOJIAEBDJ HOKHBOHACNK;

	[Cpp2IlInjected.Token(Token = "0x170000F6")]
	public int HLNPNOBJJGG
	{
		[Cpp2IlInjected.Token(Token = "0x60003BA")]
		[Cpp2IlInjected.Address(RVA = "0x621C240", Offset = "0x621AA40", VA = "0x18621C240", Slot = "5")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000F7")]
	public ACNEEEENOML HBLJIDEPNJF
	{
		[Cpp2IlInjected.Token(Token = "0x60003BB")]
		[Cpp2IlInjected.Address(RVA = "0x621C0F0", Offset = "0x621A8F0", VA = "0x18621C0F0", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60003B7")]
	[Cpp2IlInjected.Address(RVA = "0x33FC540", Offset = "0x33FAD40", VA = "0x1833FC540")]
	public FMLCBGNJKFI(INJNNPDEJLM LHIGGCOIHEC, HCLOJIAEBDJ HOKHBOHACNK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003B8")]
	[Cpp2IlInjected.Address(RVA = "0x621BFE0", Offset = "0x621A7E0", VA = "0x18621BFE0", Slot = "6")]
	public IEnumerator<ACNEEEENOML> GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003B9")]
	[Cpp2IlInjected.Address(RVA = "0x621BFE0", Offset = "0x621A7E0", VA = "0x18621BFE0", Slot = "7")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003BC")]
	[Cpp2IlInjected.Address(RVA = "0x621C0F0", Offset = "0x621A8F0", VA = "0x18621C0F0")]
	[CompilerGenerated]
	private ACNEEEENOML ICPENKDHKAI(int DKLECPOCCOI)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000041")]
[DEONFKEHMJD(typeof(MIAHMAGCEAF), new string[] { })]
public class JFCICHLMIKM : MIAHMAGCEAF, GJOKPFDLDCJ
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000058")]
	private readonly MIAHMAGCEAF KCAIFAJJIPK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000059")]
	private readonly MIAHMAGCEAF OHCKDBMMLJD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400005A")]
	private DEDLLFMJKEO GNKGFOJBFBA;

	[Cpp2IlInjected.Token(Token = "0x170000F8")]
	private MIAHMAGCEAF CJMIFCIPBNF
	{
		[Cpp2IlInjected.Token(Token = "0x60003BE")]
		[Cpp2IlInjected.Address(RVA = "0x6220D70", Offset = "0x621F570", VA = "0x186220D70")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60003BD")]
	[Cpp2IlInjected.Address(RVA = "0x6221200", Offset = "0x621FA00", VA = "0x186221200", Slot = "20")]
	public void InitReferences(HMNFMHNMJBH CJEADCONOPM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003BF")]
	[Cpp2IlInjected.Address(RVA = "0x6221430", Offset = "0x621FC30", VA = "0x186221430", Slot = "4")]
	public PMHIGDLAJOP LPHHNKPAPHN(ACNEEEENOML PCEPPDLMHCM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003C0")]
	[Cpp2IlInjected.Address(RVA = "0x6220B80", Offset = "0x621F380", VA = "0x186220B80", Slot = "5")]
	public LGAMKIPMADE DFLGBNMMLBE(ACNEEEENOML PCEPPDLMHCM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003C1")]
	[Cpp2IlInjected.Address(RVA = "0x6221010", Offset = "0x621F810", VA = "0x186221010", Slot = "6")]
	public LMDEEHLJMOK HBEJLKNNCLJ(ACNEEEENOML PCEPPDLMHCM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003C2")]
	[Cpp2IlInjected.Address(RVA = "0x6220CD0", Offset = "0x621F4D0", VA = "0x186220CD0", Slot = "7")]
	public BMMIOFOJJEB ENNPPKGHEND(ACNEEEENOML PCEPPDLMHCM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003C3")]
	[Cpp2IlInjected.Address(RVA = "0x62214D0", Offset = "0x621FCD0", VA = "0x1862214D0", Slot = "8")]
	public CCAMOPPOPEI NJJBCPEJOKJ(ACNEEEENOML PCEPPDLMHCM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003C4")]
	[Cpp2IlInjected.Address(RVA = "0x6221250", Offset = "0x621FA50", VA = "0x186221250", Slot = "9")]
	public MCEBLIDMGME JEJILAFPABO(ACNEEEENOML PCEPPDLMHCM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003C5")]
	[Cpp2IlInjected.Address(RVA = "0x62210B0", Offset = "0x621F8B0", VA = "0x1862210B0", Slot = "10")]
	public DMPEOOKGLDG HMGGCOHPDKE(ACNEEEENOML PCEPPDLMHCM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003C6")]
	[Cpp2IlInjected.Address(RVA = "0x6220F70", Offset = "0x621F770", VA = "0x186220F70", Slot = "11")]
	public AICDKPBPOFE GLEICABECAF(ACNEEEENOML PCEPPDLMHCM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003C7")]
	[Cpp2IlInjected.Address(RVA = "0x6221390", Offset = "0x621FB90", VA = "0x186221390", Slot = "12")]
	public NDKMMOHJIND LLPJONABCKF(ACNEEEENOML PCEPPDLMHCM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003C8")]
	[Cpp2IlInjected.Address(RVA = "0x62212F0", Offset = "0x621FAF0", VA = "0x1862212F0", Slot = "13")]
	public HEEAIGPCPDE KKCAOPGKIHB(ACNEEEENOML PCEPPDLMHCM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003C9")]
	[Cpp2IlInjected.Address(RVA = "0x6220AD0", Offset = "0x621F2D0", VA = "0x186220AD0")]
	public JGMBKBLBJEA CLIDGNAHFEE(ACNEEEENOML PCEPPDLMHCM, [In] ACDBPOHPAKH AELCABDCBDD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003CA")]
	[Cpp2IlInjected.Address(RVA = "0x6221150", Offset = "0x621F950", VA = "0x186221150")]
	public DCKAOPOPPEM IBAPHKBNBJH(ACNEEEENOML PCEPPDLMHCM, [In] ACDBPOHPAKH AELCABDCBDD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003CB")]
	[Cpp2IlInjected.Address(RVA = "0x6220C20", Offset = "0x621F420", VA = "0x186220C20")]
	public CFLOPMDOLBK EMOCJGFEGOK(ACNEEEENOML PCEPPDLMHCM, [In] ACDBPOHPAKH AELCABDCBDD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003CC")]
	[Cpp2IlInjected.Address(RVA = "0x6220EC0", Offset = "0x621F6C0", VA = "0x186220EC0")]
	public KFKLGADFDEA GAKGMHFGJEP(ACNEEEENOML PCEPPDLMHCM, [In] ACDBPOHPAKH AELCABDCBDD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003CD")]
	[Cpp2IlInjected.Address(RVA = "0x6221570", Offset = "0x621FD70", VA = "0x186221570")]
	public GCEONIOPFOG ONLCELJFDGF(ACNEEEENOML PCEPPDLMHCM, [In] ACDBPOHPAKH AELCABDCBDD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003CE")]
	[Cpp2IlInjected.Address(RVA = "0x6220DD0", Offset = "0x621F5D0", VA = "0x186220DD0", Slot = "19")]
	public ACNEEEENOML GAFOKFHHMAF(RigidbodyEx AHGOPBJOELE, ACDBPOHPAKH AELCABDCBDD, HGMBJJHEAKJ PNFHHOFJABN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003CF")]
	[Cpp2IlInjected.Address(RVA = "0x6221620", Offset = "0x621FE20", VA = "0x186221620")]
	public JFCICHLMIKM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003D0")]
	[Cpp2IlInjected.Address(RVA = "0x6220AD0", Offset = "0x621F2D0", VA = "0x186220AD0", Slot = "14")]
	private JGMBKBLBJEA JGBBLPMFDAA(ACNEEEENOML PCEPPDLMHCM, [In] ACDBPOHPAKH AELCABDCBDD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003D1")]
	[Cpp2IlInjected.Address(RVA = "0x6221150", Offset = "0x621F950", VA = "0x186221150", Slot = "15")]
	private DCKAOPOPPEM NBCJBJBBGJA(ACNEEEENOML PCEPPDLMHCM, [In] ACDBPOHPAKH AELCABDCBDD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003D2")]
	[Cpp2IlInjected.Address(RVA = "0x6220C20", Offset = "0x621F420", VA = "0x186220C20", Slot = "16")]
	private CFLOPMDOLBK DIGHOBCMEPJ(ACNEEEENOML PCEPPDLMHCM, [In] ACDBPOHPAKH AELCABDCBDD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003D3")]
	[Cpp2IlInjected.Address(RVA = "0x6220EC0", Offset = "0x621F6C0", VA = "0x186220EC0", Slot = "17")]
	private KFKLGADFDEA PPCAJAAIJOO(ACNEEEENOML PCEPPDLMHCM, [In] ACDBPOHPAKH AELCABDCBDD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003D4")]
	[Cpp2IlInjected.Address(RVA = "0x6221570", Offset = "0x621FD70", VA = "0x186221570", Slot = "18")]
	private GCEONIOPFOG ONEDKFJHFID(ACNEEEENOML PCEPPDLMHCM, [In] ACDBPOHPAKH AELCABDCBDD)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000042")]
[UnityEngine.Scripting.Preserve]
public sealed class PGNKFIPOGMF : ACNEEEENOML, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x400005B")]
	public static readonly PGNKFIPOGMF FLMPJFHFLHM;

	[Cpp2IlInjected.Token(Token = "0x170000F9")]
	public Rigidbody AIOLOONKHDH
	{
		[Cpp2IlInjected.Token(Token = "0x60003E7")]
		[Cpp2IlInjected.Address(RVA = "0x765EF0", Offset = "0x7646F0", VA = "0x180765EF0", Slot = "4")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000FA")]
	public RigidbodyEx PCBHPDJNNIB
	{
		[Cpp2IlInjected.Token(Token = "0x60003E8")]
		[Cpp2IlInjected.Address(RVA = "0x765620", Offset = "0x763E20", VA = "0x180765620", Slot = "5")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000FB")]
	public GameObject MLINCMAHJGP
	{
		[Cpp2IlInjected.Token(Token = "0x60003E9")]
		[Cpp2IlInjected.Address(RVA = "0x766110", Offset = "0x764910", VA = "0x180766110", Slot = "6")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000FC")]
	public Transform BDOKOMBLFFF
	{
		[Cpp2IlInjected.Token(Token = "0x60003EA")]
		[Cpp2IlInjected.Address(RVA = "0x765D00", Offset = "0x764500", VA = "0x180765D00", Slot = "7")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000FD")]
	public ACNEEEENOML MLDLDJMPPGN
	{
		[Cpp2IlInjected.Token(Token = "0x60003EB")]
		[Cpp2IlInjected.Address(RVA = "0x76B5B0", Offset = "0x769DB0", VA = "0x18076B5B0", Slot = "8")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60003EC")]
		[Cpp2IlInjected.Address(RVA = "0x76BD00", Offset = "0x76A500", VA = "0x18076BD00", Slot = "9")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000FE")]
	public IReadOnlyList<ACNEEEENOML> FKAHMBHHHJN
	{
		[Cpp2IlInjected.Token(Token = "0x60003ED")]
		[Cpp2IlInjected.Address(RVA = "0x7660F0", Offset = "0x7648F0", VA = "0x1807660F0", Slot = "10")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000FF")]
	public ACNEEEENOML IDPDODAHCDH
	{
		[Cpp2IlInjected.Token(Token = "0x60003EE")]
		[Cpp2IlInjected.Address(RVA = "0x766140", Offset = "0x764940", VA = "0x180766140", Slot = "11")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000100")]
	public bool LFEOJFGHFML
	{
		[Cpp2IlInjected.Token(Token = "0x60003EF")]
		[Cpp2IlInjected.Address(RVA = "0x84EF10", Offset = "0x84D710", VA = "0x18084EF10", Slot = "12")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000101")]
	public bool NEIGPDMIINK
	{
		[Cpp2IlInjected.Token(Token = "0x60003F0")]
		[Cpp2IlInjected.Address(RVA = "0xC96580", Offset = "0xC94D80", VA = "0x180C96580", Slot = "13")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000102")]
	public CPIKNIBKFKL GNLKAEJNEDB
	{
		[Cpp2IlInjected.Token(Token = "0x60003F1")]
		[Cpp2IlInjected.Address(RVA = "0x761C50", Offset = "0x760450", VA = "0x180761C50", Slot = "14")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60003F2")]
		[Cpp2IlInjected.Address(RVA = "0x761BD0", Offset = "0x7603D0", VA = "0x180761BD0", Slot = "15")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000103")]
	public OKPICPJMDEO JKKMJBKLALO
	{
		[Cpp2IlInjected.Token(Token = "0x60003F3")]
		[Cpp2IlInjected.Address(RVA = "0x761BF0", Offset = "0x7603F0", VA = "0x180761BF0", Slot = "16")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60003F4")]
		[Cpp2IlInjected.Address(RVA = "0x761C10", Offset = "0x760410", VA = "0x180761C10", Slot = "17")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000104")]
	public float ICPKIGJHHCD
	{
		[Cpp2IlInjected.Token(Token = "0x60003F5")]
		[Cpp2IlInjected.Address(RVA = "0x9254A0", Offset = "0x923CA0", VA = "0x1809254A0", Slot = "18")]
		[CompilerGenerated]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x60003F6")]
		[Cpp2IlInjected.Address(RVA = "0x7EE250", Offset = "0x7ECA50", VA = "0x1807EE250", Slot = "19")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000105")]
	public Vector3 LAGBGBLAELJ
	{
		[Cpp2IlInjected.Token(Token = "0x60003F7")]
		[Cpp2IlInjected.Address(RVA = "0x19D4520", Offset = "0x19D2D20", VA = "0x1819D4520", Slot = "20")]
		[CompilerGenerated]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x60003F8")]
		[Cpp2IlInjected.Address(RVA = "0x3CCE7F0", Offset = "0x3CCCFF0", VA = "0x183CCE7F0", Slot = "21")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000106")]
	public Vector3 FFPCNDPLCPM
	{
		[Cpp2IlInjected.Token(Token = "0x60003F9")]
		[Cpp2IlInjected.Address(RVA = "0x622E170", Offset = "0x622C970", VA = "0x18622E170", Slot = "22")]
		[CompilerGenerated]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x60003FA")]
		[Cpp2IlInjected.Address(RVA = "0x622E120", Offset = "0x622C920", VA = "0x18622E120", Slot = "23")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000107")]
	public Vector3 NBKAJOJDMMI
	{
		[Cpp2IlInjected.Token(Token = "0x60003FB")]
		[Cpp2IlInjected.Address(RVA = "0x3C00AC0", Offset = "0x3BFF2C0", VA = "0x183C00AC0", Slot = "24")]
		[CompilerGenerated]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x60003FC")]
		[Cpp2IlInjected.Address(RVA = "0x19055F0", Offset = "0x1903DF0", VA = "0x1819055F0", Slot = "25")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000108")]
	public Vector3 POIAGHOEFEB
	{
		[Cpp2IlInjected.Token(Token = "0x60003FD")]
		[Cpp2IlInjected.Address(RVA = "0xA38BE0", Offset = "0xA373E0", VA = "0x180A38BE0", Slot = "26")]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x60003FE")]
		[Cpp2IlInjected.Address(RVA = "0x7644F0", Offset = "0x762CF0", VA = "0x1807644F0", Slot = "27")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000109")]
	public bool PCBADJMLDFE
	{
		[Cpp2IlInjected.Token(Token = "0x60003FF")]
		[Cpp2IlInjected.Address(RVA = "0x869A10", Offset = "0x868210", VA = "0x180869A10", Slot = "28")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700010A")]
	public bool KJEMIFCOIFF
	{
		[Cpp2IlInjected.Token(Token = "0x6000400")]
		[Cpp2IlInjected.Address(RVA = "0x1635C10", Offset = "0x1634410", VA = "0x181635C10", Slot = "29")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700010B")]
	public bool KIEFCCGGPLM
	{
		[Cpp2IlInjected.Token(Token = "0x6000401")]
		[Cpp2IlInjected.Address(RVA = "0x1069F20", Offset = "0x1068720", VA = "0x181069F20", Slot = "30")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700010C")]
	public Vector3 EEEHLJDAFJK
	{
		[Cpp2IlInjected.Token(Token = "0x6000402")]
		[Cpp2IlInjected.Address(RVA = "0x3C059D0", Offset = "0x3C041D0", VA = "0x183C059D0", Slot = "31")]
		[CompilerGenerated]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700010D")]
	public Vector3 JDGLCEIOOBF
	{
		[Cpp2IlInjected.Token(Token = "0x6000403")]
		[Cpp2IlInjected.Address(RVA = "0x8EF490", Offset = "0x8EDC90", VA = "0x1808EF490", Slot = "32")]
		[CompilerGenerated]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700010E")]
	public Vector3 LBFLJMHMJDO
	{
		[Cpp2IlInjected.Token(Token = "0x6000404")]
		[Cpp2IlInjected.Address(RVA = "0xA38BE0", Offset = "0xA373E0", VA = "0x180A38BE0", Slot = "33")]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x6000405")]
		[Cpp2IlInjected.Address(RVA = "0x7644F0", Offset = "0x762CF0", VA = "0x1807644F0", Slot = "34")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700010F")]
	public Vector3 CCEGGEBAGNO
	{
		[Cpp2IlInjected.Token(Token = "0x6000406")]
		[Cpp2IlInjected.Address(RVA = "0x622E130", Offset = "0x622C930", VA = "0x18622E130", Slot = "35")]
		[CompilerGenerated]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000110")]
	public float FDPCBODPJHG
	{
		[Cpp2IlInjected.Token(Token = "0x6000407")]
		[Cpp2IlInjected.Address(RVA = "0x530FED0", Offset = "0x530E6D0", VA = "0x18530FED0", Slot = "36")]
		[CompilerGenerated]
		get
		{
			return default(float);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000111")]
	public float PFMNCEKEBOC
	{
		[Cpp2IlInjected.Token(Token = "0x6000408")]
		[Cpp2IlInjected.Address(RVA = "0x7B5580", Offset = "0x7B3D80", VA = "0x1807B5580", Slot = "37")]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x6000409")]
		[Cpp2IlInjected.Address(RVA = "0x7644F0", Offset = "0x762CF0", VA = "0x1807644F0", Slot = "38")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000112")]
	public Vector3 ONJLJDCPIMM
	{
		[Cpp2IlInjected.Token(Token = "0x600040A")]
		[Cpp2IlInjected.Address(RVA = "0xA38BE0", Offset = "0xA373E0", VA = "0x180A38BE0", Slot = "39")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000113")]
	public Quaternion EKDPJMOLPAE
	{
		[Cpp2IlInjected.Token(Token = "0x600040B")]
		[Cpp2IlInjected.Address(RVA = "0x7B3940", Offset = "0x7B2140", VA = "0x1807B3940", Slot = "40")]
		get
		{
			return default(Quaternion);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000114")]
	public float EPNHAMDEIMB
	{
		[Cpp2IlInjected.Token(Token = "0x600040D")]
		[Cpp2IlInjected.Address(RVA = "0x7B5580", Offset = "0x7B3D80", VA = "0x1807B5580", Slot = "42")]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x600040E")]
		[Cpp2IlInjected.Address(RVA = "0x7644F0", Offset = "0x762CF0", VA = "0x1807644F0", Slot = "43")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000115")]
	public float FJKLFMLIIEM
	{
		[Cpp2IlInjected.Token(Token = "0x600040F")]
		[Cpp2IlInjected.Address(RVA = "0x7B5580", Offset = "0x7B3D80", VA = "0x1807B5580", Slot = "44")]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x6000410")]
		[Cpp2IlInjected.Address(RVA = "0x7644F0", Offset = "0x762CF0", VA = "0x1807644F0", Slot = "45")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000116")]
	public bool DAFMFMBFKBE
	{
		[Cpp2IlInjected.Token(Token = "0x6000411")]
		[Cpp2IlInjected.Address(RVA = "0x7AC370", Offset = "0x7AAB70", VA = "0x1807AC370", Slot = "46")]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000412")]
		[Cpp2IlInjected.Address(RVA = "0x7644F0", Offset = "0x762CF0", VA = "0x1807644F0", Slot = "47")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000117")]
	public ABDACCGDOPN FADDMLIMLLG
	{
		[Cpp2IlInjected.Token(Token = "0x6000413")]
		[Cpp2IlInjected.Address(RVA = "0x7AC370", Offset = "0x7AAB70", VA = "0x1807AC370", Slot = "48")]
		get
		{
			return default(ABDACCGDOPN);
		}
		[Cpp2IlInjected.Token(Token = "0x6000414")]
		[Cpp2IlInjected.Address(RVA = "0x7644F0", Offset = "0x762CF0", VA = "0x1807644F0", Slot = "49")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000118")]
	public bool AIFLGAACHML
	{
		[Cpp2IlInjected.Token(Token = "0x6000415")]
		[Cpp2IlInjected.Address(RVA = "0x10C26C0", Offset = "0x10C0EC0", VA = "0x1810C26C0", Slot = "50")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000119")]
	public Transform FHODNODINAI
	{
		[Cpp2IlInjected.Token(Token = "0x6000416")]
		[Cpp2IlInjected.Address(RVA = "0x83D270", Offset = "0x83BA70", VA = "0x18083D270", Slot = "51")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700011A")]
	public Vector3 KDEBKPHAANG
	{
		[Cpp2IlInjected.Token(Token = "0x6000417")]
		[Cpp2IlInjected.Address(RVA = "0xA38BE0", Offset = "0xA373E0", VA = "0x180A38BE0", Slot = "52")]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x6000418")]
		[Cpp2IlInjected.Address(RVA = "0x7644F0", Offset = "0x762CF0", VA = "0x1807644F0", Slot = "53")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700011B")]
	public float JBNHCEBOIMF
	{
		[Cpp2IlInjected.Token(Token = "0x6000419")]
		[Cpp2IlInjected.Address(RVA = "0x7B5580", Offset = "0x7B3D80", VA = "0x1807B5580", Slot = "54")]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x600041A")]
		[Cpp2IlInjected.Address(RVA = "0x7644F0", Offset = "0x762CF0", VA = "0x1807644F0", Slot = "55")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700011C")]
	public float PAMDAKFFDPC
	{
		[Cpp2IlInjected.Token(Token = "0x600041B")]
		[Cpp2IlInjected.Address(RVA = "0x7B5580", Offset = "0x7B3D80", VA = "0x1807B5580", Slot = "56")]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x600041C")]
		[Cpp2IlInjected.Address(RVA = "0x7644F0", Offset = "0x762CF0", VA = "0x1807644F0", Slot = "57")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700011D")]
	public Quaternion ELDJEJICFFN
	{
		[Cpp2IlInjected.Token(Token = "0x600041D")]
		[Cpp2IlInjected.Address(RVA = "0x8A5CD0", Offset = "0x8A44D0", VA = "0x1808A5CD0", Slot = "58")]
		get
		{
			return default(Quaternion);
		}
		[Cpp2IlInjected.Token(Token = "0x600041E")]
		[Cpp2IlInjected.Address(RVA = "0x7644F0", Offset = "0x762CF0", VA = "0x1807644F0", Slot = "59")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700011E")]
	public Vector3 MJCFJPNCBDO
	{
		[Cpp2IlInjected.Token(Token = "0x600041F")]
		[Cpp2IlInjected.Address(RVA = "0xA38BE0", Offset = "0xA373E0", VA = "0x180A38BE0", Slot = "60")]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x6000420")]
		[Cpp2IlInjected.Address(RVA = "0x7644F0", Offset = "0x762CF0", VA = "0x1807644F0", Slot = "61")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700011F")]
	public Quaternion CGLJKEJLMFK
	{
		[Cpp2IlInjected.Token(Token = "0x6000421")]
		[Cpp2IlInjected.Address(RVA = "0x8A5CD0", Offset = "0x8A44D0", VA = "0x1808A5CD0", Slot = "62")]
		get
		{
			return default(Quaternion);
		}
		[Cpp2IlInjected.Token(Token = "0x6000422")]
		[Cpp2IlInjected.Address(RVA = "0x7644F0", Offset = "0x762CF0", VA = "0x1807644F0", Slot = "63")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000120")]
	public RigidbodyConstraints LKJNJPEFLGB
	{
		[Cpp2IlInjected.Token(Token = "0x6000423")]
		[Cpp2IlInjected.Address(RVA = "0x764500", Offset = "0x762D00", VA = "0x180764500", Slot = "64")]
		get
		{
			return default(RigidbodyConstraints);
		}
		[Cpp2IlInjected.Token(Token = "0x6000424")]
		[Cpp2IlInjected.Address(RVA = "0x7644F0", Offset = "0x762CF0", VA = "0x1807644F0", Slot = "65")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000121")]
	public bool JIAMCDEEBDI
	{
		[Cpp2IlInjected.Token(Token = "0x6000425")]
		[Cpp2IlInjected.Address(RVA = "0x7AC370", Offset = "0x7AAB70", VA = "0x1807AC370", Slot = "66")]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000426")]
		[Cpp2IlInjected.Address(RVA = "0x7644F0", Offset = "0x762CF0", VA = "0x1807644F0", Slot = "67")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000122")]
	public CollisionDetectionMode EJKKFAEAAME
	{
		[Cpp2IlInjected.Token(Token = "0x6000427")]
		[Cpp2IlInjected.Address(RVA = "0x764500", Offset = "0x762D00", VA = "0x180764500", Slot = "68")]
		get
		{
			return default(CollisionDetectionMode);
		}
		[Cpp2IlInjected.Token(Token = "0x6000428")]
		[Cpp2IlInjected.Address(RVA = "0x7644F0", Offset = "0x762CF0", VA = "0x1807644F0", Slot = "69")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000123")]
	public bool HDHFPOGMJNC
	{
		[Cpp2IlInjected.Token(Token = "0x6000429")]
		[Cpp2IlInjected.Address(RVA = "0x19F48D0", Offset = "0x19F30D0", VA = "0x1819F48D0", Slot = "70")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000038")]
	public event EBFBHNJDFMO PAAEJBNAELP
	{
		[Cpp2IlInjected.Token(Token = "0x60003D5")]
		[Cpp2IlInjected.Address(RVA = "0x7644F0", Offset = "0x762CF0", VA = "0x1807644F0", Slot = "75")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60003D6")]
		[Cpp2IlInjected.Address(RVA = "0x7644F0", Offset = "0x762CF0", VA = "0x1807644F0", Slot = "76")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000039")]
	public event EBFBHNJDFMO ANLGMIPOGHH
	{
		[Cpp2IlInjected.Token(Token = "0x60003D7")]
		[Cpp2IlInjected.Address(RVA = "0x7644F0", Offset = "0x762CF0", VA = "0x1807644F0", Slot = "77")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60003D8")]
		[Cpp2IlInjected.Address(RVA = "0x7644F0", Offset = "0x762CF0", VA = "0x1807644F0", Slot = "78")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400003A")]
	public event GHEEFDJOPPC GDBIGLFOIGG
	{
		[Cpp2IlInjected.Token(Token = "0x60003D9")]
		[Cpp2IlInjected.Address(RVA = "0x7644F0", Offset = "0x762CF0", VA = "0x1807644F0", Slot = "79")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60003DA")]
		[Cpp2IlInjected.Address(RVA = "0x7644F0", Offset = "0x762CF0", VA = "0x1807644F0", Slot = "80")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400003B")]
	public event EBFBHNJDFMO GILKHDKMEND
	{
		[Cpp2IlInjected.Token(Token = "0x60003DB")]
		[Cpp2IlInjected.Address(RVA = "0x7644F0", Offset = "0x762CF0", VA = "0x1807644F0", Slot = "82")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60003DC")]
		[Cpp2IlInjected.Address(RVA = "0x7644F0", Offset = "0x762CF0", VA = "0x1807644F0", Slot = "83")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400003C")]
	public event EBFBHNJDFMO PPOOMLEKHLL
	{
		[Cpp2IlInjected.Token(Token = "0x60003DD")]
		[Cpp2IlInjected.Address(RVA = "0x7644F0", Offset = "0x762CF0", VA = "0x1807644F0", Slot = "102")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60003DE")]
		[Cpp2IlInjected.Address(RVA = "0x7644F0", Offset = "0x762CF0", VA = "0x1807644F0", Slot = "103")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400003D")]
	public event EBFBHNJDFMO CDIFNKKNIAI
	{
		[Cpp2IlInjected.Token(Token = "0x60003DF")]
		[Cpp2IlInjected.Address(RVA = "0x7644F0", Offset = "0x762CF0", VA = "0x1807644F0", Slot = "107")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60003E0")]
		[Cpp2IlInjected.Address(RVA = "0x7644F0", Offset = "0x762CF0", VA = "0x1807644F0", Slot = "108")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400003E")]
	public event Action<LMALNIIPHAC, LMALNIIPHAC> ENBBGJAGBJJ
	{
		[Cpp2IlInjected.Token(Token = "0x60003E1")]
		[Cpp2IlInjected.Address(RVA = "0x7644F0", Offset = "0x762CF0", VA = "0x1807644F0", Slot = "111")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60003E2")]
		[Cpp2IlInjected.Address(RVA = "0x7644F0", Offset = "0x762CF0", VA = "0x1807644F0", Slot = "112")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400003F")]
	public event EBFBHNJDFMO KOMDEBFEEEP
	{
		[Cpp2IlInjected.Token(Token = "0x60003E3")]
		[Cpp2IlInjected.Address(RVA = "0x7644F0", Offset = "0x762CF0", VA = "0x1807644F0", Slot = "113")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60003E4")]
		[Cpp2IlInjected.Address(RVA = "0x7644F0", Offset = "0x762CF0", VA = "0x1807644F0", Slot = "114")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000040")]
	public event EBFBHNJDFMO NDADBNMCKJG
	{
		[Cpp2IlInjected.Token(Token = "0x60003E5")]
		[Cpp2IlInjected.Address(RVA = "0x7644F0", Offset = "0x762CF0", VA = "0x1807644F0", Slot = "119")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60003E6")]
		[Cpp2IlInjected.Address(RVA = "0x7644F0", Offset = "0x762CF0", VA = "0x1807644F0", Slot = "120")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600040C")]
	[Cpp2IlInjected.Address(RVA = "0x7644F0", Offset = "0x762CF0", VA = "0x1807644F0", Slot = "41")]
	public void HFHDCMEIKAH((Quaternion rot, Vector3 moments) MOGJAEMHOKI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600042A")]
	[Cpp2IlInjected.Address(RVA = "0x7644F0", Offset = "0x762CF0", VA = "0x1807644F0", Slot = "71")]
	public void BMFHLKIGOGD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600042B")]
	[Cpp2IlInjected.Address(RVA = "0x7644F0", Offset = "0x762CF0", VA = "0x1807644F0", Slot = "72")]
	public void LKJFMPHLLAI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600042C")]
	[Cpp2IlInjected.Address(RVA = "0x7644F0", Offset = "0x762CF0", VA = "0x1807644F0", Slot = "73")]
	public void IKAJDAOJONJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600042D")]
	[Cpp2IlInjected.Address(RVA = "0x7644F0", Offset = "0x762CF0", VA = "0x1807644F0", Slot = "74")]
	public void BHMFFCOHDEE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600042E")]
	[Cpp2IlInjected.Address(RVA = "0x7644F0", Offset = "0x762CF0", VA = "0x1807644F0", Slot = "134")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600042F")]
	[Cpp2IlInjected.Address(RVA = "0x7644F0", Offset = "0x762CF0", VA = "0x1807644F0", Slot = "81")]
	public void JLJFDADNEME(ACNEEEENOML FKKGMPDEPMA, bool CGKOADMHFLC = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000430")]
	[Cpp2IlInjected.Address(RVA = "0x7644F0", Offset = "0x762CF0", VA = "0x1807644F0", Slot = "84")]
	public void JAFBLGBFIGL(object KIAKEGJPMAL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000431")]
	[Cpp2IlInjected.Address(RVA = "0x7644F0", Offset = "0x762CF0", VA = "0x1807644F0", Slot = "85")]
	public void KLHEGIFEBJI(object KIAKEGJPMAL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000432")]
	[Cpp2IlInjected.Address(RVA = "0xA38BE0", Offset = "0xA373E0", VA = "0x180A38BE0", Slot = "86")]
	public Vector3 JOHAPINPNIG(Vector3 CPFDNDKFHHH)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000433")]
	[Cpp2IlInjected.Address(RVA = "0xA38BE0", Offset = "0xA373E0", VA = "0x180A38BE0", Slot = "87")]
	public Vector3 OJGIMCLJCBO(Vector3 AMLAOHJLKAL)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000434")]
	[Cpp2IlInjected.Address(RVA = "0x7644F0", Offset = "0x762CF0", VA = "0x1807644F0", Slot = "88")]
	public void HPICNCAEGKH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000435")]
	[Cpp2IlInjected.Address(RVA = "0x7644F0", Offset = "0x762CF0", VA = "0x1807644F0", Slot = "89")]
	public void ELAIKNOJDMF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000436")]
	[Cpp2IlInjected.Address(RVA = "0x7644F0", Offset = "0x762CF0", VA = "0x1807644F0", Slot = "90")]
	public void GAIPCILJLMB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000437")]
	[Cpp2IlInjected.Address(RVA = "0x7644F0", Offset = "0x762CF0", VA = "0x1807644F0", Slot = "91")]
	public void FOPGOBMGCOM(Vector3 HDFIANGNHPD, Vector3 OPNLLPIFKNP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000438")]
	[Cpp2IlInjected.Address(RVA = "0x7644F0", Offset = "0x762CF0", VA = "0x1807644F0", Slot = "92")]
	public void MDMIGCOMJCF(Vector3 JPNLAOHAPPM, Vector3 CHFCHAFCOBM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000439")]
	[Cpp2IlInjected.Address(RVA = "0x7644F0", Offset = "0x762CF0", VA = "0x1807644F0", Slot = "93")]
	public void OGHMBOLGHFB(Vector3 FJNLGGLHPIL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600043A")]
	[Cpp2IlInjected.Address(RVA = "0x7644F0", Offset = "0x762CF0", VA = "0x1807644F0", Slot = "94")]
	public void CCOMMPLBNFB(BPNODJIJBLA KADKJKFHDBE, Vector3 MCCPDDLJGEG, float EGMGOJMNMKL, float FLCBFAEIBEI = 8f, float MMINJAGEDBL = 1f)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600043B")]
	[Cpp2IlInjected.Address(RVA = "0x7644F0", Offset = "0x762CF0", VA = "0x1807644F0", Slot = "95")]
	public void AFAJHDMGFMF(LJGOMBGDPDM GJBGJOHBOBM, Vector3 GNFMGLELAKB, float JICJOBGCGOP = float.PositiveInfinity)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600043C")]
	[Cpp2IlInjected.Address(RVA = "0x7644F0", Offset = "0x762CF0", VA = "0x1807644F0", Slot = "96")]
	public void MPMCBKEHDIK(LJGOMBGDPDM GJBGJOHBOBM, Vector3 OHMBDAJNEIJ, float GEPDJOHNEPN = 7f, float JINKMCECFKA = 1f)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600043D")]
	[Cpp2IlInjected.Address(RVA = "0xA38BE0", Offset = "0xA373E0", VA = "0x180A38BE0", Slot = "97")]
	public Vector3 EMEDMNCJCCM(Vector3 FKKGMPDEPMA)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x600043E")]
	[Cpp2IlInjected.Address(RVA = "0xA38BE0", Offset = "0xA373E0", VA = "0x180A38BE0", Slot = "98")]
	public Vector3 AFNJAEPBIFC(Vector3 FKKGMPDEPMA)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x600043F")]
	[Cpp2IlInjected.Address(RVA = "0x7644F0", Offset = "0x762CF0", VA = "0x1807644F0", Slot = "99")]
	public void JIMNECMIFKB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000440")]
	[Cpp2IlInjected.Address(RVA = "0x7644F0", Offset = "0x762CF0", VA = "0x1807644F0", Slot = "100")]
	public void DGFANBIPFEE(ACNEEEENOML FFGBMPIEMIB, object KIAKEGJPMAL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000441")]
	[Cpp2IlInjected.Address(RVA = "0x7644F0", Offset = "0x762CF0", VA = "0x1807644F0", Slot = "101")]
	public void DCFJHAGIOEM(object KIAKEGJPMAL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000442")]
	[Cpp2IlInjected.Address(RVA = "0x7644F0", Offset = "0x762CF0", VA = "0x1807644F0", Slot = "104")]
	public void ALFIJHNHMBG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000443")]
	[Cpp2IlInjected.Address(RVA = "0x7644F0", Offset = "0x762CF0", VA = "0x1807644F0", Slot = "105")]
	public void AECDOEBBECA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000444")]
	[Cpp2IlInjected.Address(RVA = "0x7644F0", Offset = "0x762CF0", VA = "0x1807644F0", Slot = "106")]
	public void PFMKNBPMAJC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000445")]
	[Cpp2IlInjected.Address(RVA = "0x7AC370", Offset = "0x7AAB70", VA = "0x1807AC370", Slot = "109")]
	public bool ICIHJKDLIHF()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000446")]
	[Cpp2IlInjected.Address(RVA = "0x7644F0", Offset = "0x762CF0", VA = "0x1807644F0", Slot = "110")]
	public void JAEFDNECOPP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000447")]
	[Cpp2IlInjected.Address(RVA = "0x764500", Offset = "0x762D00", VA = "0x180764500", Slot = "115")]
	public IDisposable HIJEMOJOGMK()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000448")]
	[Cpp2IlInjected.Address(RVA = "0x7644F0", Offset = "0x762CF0", VA = "0x1807644F0", Slot = "116")]
	public void JOKCPNGIIMH(object KIAKEGJPMAL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000449")]
	[Cpp2IlInjected.Address(RVA = "0x7644F0", Offset = "0x762CF0", VA = "0x1807644F0", Slot = "117")]
	public void CFLECLOAECH(object KIAKEGJPMAL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600044A")]
	[Cpp2IlInjected.Address(RVA = "0x7644F0", Offset = "0x762CF0", VA = "0x1807644F0", Slot = "118")]
	public void PHMJJJCNKII(object KIAKEGJPMAL, bool JMNDFKAOINO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600044B")]
	[Cpp2IlInjected.Address(RVA = "0x7644F0", Offset = "0x762CF0", VA = "0x1807644F0", Slot = "121")]
	public void JLBDGAIPDBF(Vector3 AAMDDKIBNEM, Quaternion AHHDHIOJLHB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600044C")]
	[Cpp2IlInjected.Address(RVA = "0x7644F0", Offset = "0x762CF0", VA = "0x1807644F0", Slot = "122")]
	public void MBKDHNHMLBH(Vector3 LHHPNCJCHFD, Quaternion CDONFJKGJGK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600044D")]
	[Cpp2IlInjected.Address(RVA = "0x7AC370", Offset = "0x7AAB70", VA = "0x1807AC370", Slot = "123")]
	public bool CACNNIFAFBA(float JJLGAOMIEEO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600044E")]
	[Cpp2IlInjected.Address(RVA = "0x7644F0", Offset = "0x762CF0", VA = "0x1807644F0", Slot = "124")]
	public void AGDOBNJPBGB(object KIAKEGJPMAL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600044F")]
	[Cpp2IlInjected.Address(RVA = "0x7644F0", Offset = "0x762CF0", VA = "0x1807644F0", Slot = "125")]
	public void FPLFJLMJDOL(object KIAKEGJPMAL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000450")]
	[Cpp2IlInjected.Address(RVA = "0x7644F0", Offset = "0x762CF0", VA = "0x1807644F0", Slot = "126")]
	public void JBAEFNMGPHP(object KIAKEGJPMAL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000451")]
	[Cpp2IlInjected.Address(RVA = "0x7644F0", Offset = "0x762CF0", VA = "0x1807644F0", Slot = "127")]
	public void MODGFAKLIIP(object KIAKEGJPMAL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000452")]
	[Cpp2IlInjected.Address(RVA = "0x7644F0", Offset = "0x762CF0", VA = "0x1807644F0", Slot = "128")]
	public void EGEGKPJLIKO(Vector3 AKFFELDLHDA, ForceMode ACFLBCIEBAA = ForceMode.Force)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000453")]
	[Cpp2IlInjected.Address(RVA = "0x7644F0", Offset = "0x762CF0", VA = "0x1807644F0", Slot = "129")]
	public void NOAIHMJOFMI(Vector3 AKFFELDLHDA, Vector3 MCLBBPPAHAP, ForceMode ACFLBCIEBAA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000454")]
	[Cpp2IlInjected.Address(RVA = "0x7644F0", Offset = "0x762CF0", VA = "0x1807644F0", Slot = "130")]
	public void JHDOIGEAHPA(Vector3 FNPOFGBLJMD, ForceMode ACFLBCIEBAA = ForceMode.Force)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000455")]
	[Cpp2IlInjected.Address(RVA = "0x7644F0", Offset = "0x762CF0", VA = "0x1807644F0", Slot = "131")]
	public void INFGEGJJGIJ(Vector3 FNPOFGBLJMD, ForceMode ACFLBCIEBAA = ForceMode.Force)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000456")]
	[Cpp2IlInjected.Address(RVA = "0x622E150", Offset = "0x622C950", VA = "0x18622E150", Slot = "132")]
	public bool HOKBEJGNALC(Vector3 GJMNPFFBJPA, [Out] RaycastHit LGAEEAFDDFJ, float LNHOFLIBFND)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000457")]
	[Cpp2IlInjected.Address(RVA = "0x7644F0", Offset = "0x762CF0", VA = "0x1807644F0", Slot = "133")]
	public void FCAHOLPEHIP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000458")]
	[Cpp2IlInjected.Address(RVA = "0x76E470", Offset = "0x76CC70", VA = "0x18076E470")]
	public PGNKFIPOGMF()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000043")]
public sealed class LNEFAENNCOP : ALHCFOHGNMD, BOFNPIGFHNE, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
	[Cpp2IlInjected.Token(Token = "0x4000075")]
	internal INJNNPDEJLM LHIGGCOIHEC;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
	[Cpp2IlInjected.Token(Token = "0x4000076")]
	internal HCLOJIAEBDJ AIMFKPMGGJM;

	[Cpp2IlInjected.Token(Token = "0x600045A")]
	[Cpp2IlInjected.Address(RVA = "0x62123C0", Offset = "0x6210BC0", VA = "0x1862123C0")]
	public LNEFAENNCOP(GameObject GOGHJGCCDJI, RigidbodyEx BACCFODJEJB, HGMBJJHEAKJ PNFHHOFJABN, [In] ACDBPOHPAKH AELCABDCBDD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600045B")]
	[Cpp2IlInjected.Address(RVA = "0x6227B10", Offset = "0x6226310", VA = "0x186227B10", Slot = "135")]
	protected override void PHAFPIOAAOD(HGMBJJHEAKJ PNFHHOFJABN, ACDBPOHPAKH AELCABDCBDD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600045C")]
	[Cpp2IlInjected.Address(RVA = "0x764500", Offset = "0x762D00", VA = "0x180764500", Slot = "141")]
	protected override IDisposable IHONCCCEIPE()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600045D")]
	[Cpp2IlInjected.Address(RVA = "0x62276B0", Offset = "0x6225EB0", VA = "0x1862276B0", Slot = "136")]
	public override void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600045E")]
	[Cpp2IlInjected.Address(RVA = "0x6227450", Offset = "0x6225C50", VA = "0x186227450", Slot = "142")]
	public void BKELIJOCCBI(DAIDGMABGPE OEHHBJMJCPL, DAIDGMABGPE JHENJKJEFON)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600045F")]
	[Cpp2IlInjected.Address(RVA = "0x6227D80", Offset = "0x6226580", VA = "0x186227D80", Slot = "143")]
	public void POACJFGBJCP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000460")]
	[Cpp2IlInjected.Address(RVA = "0x6227390", Offset = "0x6225B90", VA = "0x186227390", Slot = "144")]
	public void BBOEGFAMJOD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000461")]
	[Cpp2IlInjected.Address(RVA = "0x6227880", Offset = "0x6226080", VA = "0x186227880", Slot = "145")]
	public void MMKNBNPGODE(bool IIBPGCHKBGC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000462")]
	[Cpp2IlInjected.Address(RVA = "0x6227520", Offset = "0x6225D20", VA = "0x186227520", Slot = "146")]
	public bool BLINNJBNGEM()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000463")]
	[Cpp2IlInjected.Address(RVA = "0x6227820", Offset = "0x6226020", VA = "0x186227820", Slot = "147")]
	public void JLCCGEOBJNC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000464")]
	[Cpp2IlInjected.Address(RVA = "0x7644F0", Offset = "0x762CF0", VA = "0x1807644F0", Slot = "140")]
	protected override void GLDNEHFMFPP(RigidbodyEx EANKMFHELBA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000465")]
	[Cpp2IlInjected.Address(RVA = "0x62278E0", Offset = "0x62260E0", VA = "0x1862278E0")]
	private void OJPGPHGIHNO()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000044")]
internal static class KNDPGPPLJEC
{
	[Cpp2IlInjected.Token(Token = "0x6000466")]
	[Cpp2IlInjected.Address(RVA = "0x6222390", Offset = "0x6220B90", VA = "0x186222390")]
	public static ALHCFOHGNMD IHGNKCNGGLA(this ACNEEEENOML PCEPPDLMHCM)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000045")]
public interface EBDLADNIDOH : PMHIGDLAJOP, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x6000467")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void CCIOJOCPJBE(ACNEEEENOML AHGOPBJOELE);

	[Cpp2IlInjected.Token(Token = "0x6000468")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void IIMOIKPKMHN(ACNEEEENOML AHGOPBJOELE);

	[Cpp2IlInjected.Token(Token = "0x6000469")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void HALBFMEBFHC(ACNEEEENOML HKJABBNKIDD);

	[Cpp2IlInjected.Token(Token = "0x600046A")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void JDIMBCAFGPK(ACNEEEENOML HKJABBNKIDD);
}
[Cpp2IlInjected.Token(Token = "0x2000046")]
public interface AKACGEKEHCH : LMDEEHLJMOK
{
	[Cpp2IlInjected.Token(Token = "0x17000124")]
	AAKBOGCEFIH<ACNEEEENOML> CLFJOLBOENB
	{
		[Cpp2IlInjected.Token(Token = "0x600046B")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000125")]
	ACNEEEENOML KIHKKDCAAPO
	{
		[Cpp2IlInjected.Token(Token = "0x600046C")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000047")]
public interface MKGDOFOGMMF : KFKLGADFDEA
{
	[Cpp2IlInjected.Token(Token = "0x600046D")]
	[Cpp2IlInjected.Address(Slot = "0")]
	(float, Vector3) FJHOJGMHILJ(Rigidbody EIHBMPLDGIB);
}
[Cpp2IlInjected.Token(Token = "0x2000048")]
public interface PCOFBEEFBPN : DCKAOPOPPEM, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x17000126")]
	PhotonView HLDIKJHKBKI
	{
		[Cpp2IlInjected.Token(Token = "0x600046E")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000049")]
internal sealed class NCOGELKMHCJ : NDKMMOHJIND
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000077")]
	private readonly ALHCFOHGNMD AHGOPBJOELE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000078")]
	private CollisionDetectionMode GCHDPOLENDJ;

	[Cpp2IlInjected.Token(Token = "0x17000127")]
	private Rigidbody AIOLOONKHDH
	{
		[Cpp2IlInjected.Token(Token = "0x600046F")]
		[Cpp2IlInjected.Address(RVA = "0x62126A0", Offset = "0x6210EA0", VA = "0x1862126A0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000128")]
	public CollisionDetectionMode EJKKFAEAAME
	{
		[Cpp2IlInjected.Token(Token = "0x6000473")]
		[Cpp2IlInjected.Address(RVA = "0x62288B0", Offset = "0x62270B0", VA = "0x1862288B0", Slot = "4")]
		get
		{
			return default(CollisionDetectionMode);
		}
		[Cpp2IlInjected.Token(Token = "0x6000474")]
		[Cpp2IlInjected.Address(RVA = "0x6228CC0", Offset = "0x62274C0", VA = "0x186228CC0", Slot = "5")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000470")]
	[Cpp2IlInjected.Address(RVA = "0x6213250", Offset = "0x6211A50", VA = "0x186213250")]
	public NCOGELKMHCJ(ACNEEEENOML AHGOPBJOELE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000471")]
	[Cpp2IlInjected.Address(RVA = "0x62289C0", Offset = "0x62271C0", VA = "0x1862289C0", Slot = "6")]
	public void BMFHLKIGOGD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000472")]
	[Cpp2IlInjected.Address(RVA = "0x6228AD0", Offset = "0x62272D0", VA = "0x186228AD0", Slot = "9")]
	public void DOIABHKLMHG(Rigidbody JFKGLMKHADB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000475")]
	[Cpp2IlInjected.Address(RVA = "0x6228CB0", Offset = "0x62274B0", VA = "0x186228CB0", Slot = "7")]
	public void JJAEHGOMMFB(bool EKPIMFFAAJH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000476")]
	[Cpp2IlInjected.Address(RVA = "0x6228E50", Offset = "0x6227650", VA = "0x186228E50", Slot = "8")]
	public void PIIIJOOFJJP(bool EKPIMFFAAJH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000477")]
	[Cpp2IlInjected.Address(RVA = "0x6228B50", Offset = "0x6227350", VA = "0x186228B50", Slot = "10")]
	public bool HOKBEJGNALC(Vector3 GJMNPFFBJPA, [Out] RaycastHit LGAEEAFDDFJ, float LNHOFLIBFND)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000478")]
	[Cpp2IlInjected.Address(RVA = "0x6228D30", Offset = "0x6227530", VA = "0x186228D30")]
	private void NFFFMMPNHDG(bool EKPIMFFAAJH)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200004A")]
public sealed class MAHAFKJLJIE : MCEBLIDMGME, IDisposable, EDAFEFMMNAG
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400007A")]
	private readonly ALHCFOHGNMD AHGOPBJOELE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400007B")]
	private ABDACCGDOPN DNHJCBNEHIE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400007C")]
	private BMACFOJPCPM FEINMOBOBHC;

	[Cpp2IlInjected.Token(Token = "0x17000129")]
	public ABDACCGDOPN FADDMLIMLLG
	{
		[Cpp2IlInjected.Token(Token = "0x600047B")]
		[Cpp2IlInjected.Address(RVA = "0x6228280", Offset = "0x6226A80", VA = "0x186228280", Slot = "6")]
		get
		{
			return default(ABDACCGDOPN);
		}
		[Cpp2IlInjected.Token(Token = "0x600047C")]
		[Cpp2IlInjected.Address(RVA = "0x62281B0", Offset = "0x62269B0", VA = "0x1862281B0", Slot = "7")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700012A")]
	private Transform KBMBAPEAMKN
	{
		[Cpp2IlInjected.Token(Token = "0x600047D")]
		[Cpp2IlInjected.Address(RVA = "0x6228140", Offset = "0x6226940", VA = "0x186228140", Slot = "10")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000041")]
	public event Action<LMALNIIPHAC, LMALNIIPHAC> ENBBGJAGBJJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000479")]
		[Cpp2IlInjected.Address(RVA = "0x62283D0", Offset = "0x6226BD0", VA = "0x1862283D0", Slot = "4")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600047A")]
		[Cpp2IlInjected.Address(RVA = "0x6228480", Offset = "0x6226C80", VA = "0x186228480", Slot = "5")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600047E")]
	[Cpp2IlInjected.Address(RVA = "0x6228530", Offset = "0x6226D30", VA = "0x186228530")]
	public MAHAFKJLJIE(ACNEEEENOML AHGOPBJOELE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600047F")]
	[Cpp2IlInjected.Address(RVA = "0x6227E40", Offset = "0x6226640", VA = "0x186227E40", Slot = "8")]
	public void BMFHLKIGOGD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000480")]
	[Cpp2IlInjected.Address(RVA = "0x6228160", Offset = "0x6226960", VA = "0x186228160", Slot = "9")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000481")]
	[Cpp2IlInjected.Address(RVA = "0x1A36E80", Offset = "0x1A35680", VA = "0x181A36E80", Slot = "11")]
	private void DLMAECDPPFA(LMALNIIPHAC ANBIOJLLMHI, LMALNIIPHAC BMJMPKJOAMG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000482")]
	[Cpp2IlInjected.Address(RVA = "0x7644F0", Offset = "0x762CF0", VA = "0x1807644F0", Slot = "12")]
	private void ELIBDIKAJHB(bool GHGJICDKEHL)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200004B")]
internal sealed class BFKAHOKGMKE : AICDKPBPOFE
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400007D")]
	private readonly ALHCFOHGNMD AHGOPBJOELE;

	[Cpp2IlInjected.Token(Token = "0x1700012B")]
	private Rigidbody AIOLOONKHDH
	{
		[Cpp2IlInjected.Token(Token = "0x6000483")]
		[Cpp2IlInjected.Address(RVA = "0x62126A0", Offset = "0x6210EA0", VA = "0x1862126A0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700012C")]
	private bool AIFLGAACHML
	{
		[Cpp2IlInjected.Token(Token = "0x6000484")]
		[Cpp2IlInjected.Address(RVA = "0x6212490", Offset = "0x6210C90", VA = "0x186212490")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700012D")]
	private bool IDEKMMEBDBI
	{
		[Cpp2IlInjected.Token(Token = "0x6000485")]
		[Cpp2IlInjected.Address(RVA = "0x6212F70", Offset = "0x6211770", VA = "0x186212F70")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700012E")]
	private ACNEEEENOML MLDLDJMPPGN
	{
		[Cpp2IlInjected.Token(Token = "0x6000486")]
		[Cpp2IlInjected.Address(RVA = "0x62124E0", Offset = "0x6210CE0", VA = "0x1862124E0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000487")]
	[Cpp2IlInjected.Address(RVA = "0x6213250", Offset = "0x6211A50", VA = "0x186213250")]
	public BFKAHOKGMKE(ACNEEEENOML AHGOPBJOELE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000488")]
	[Cpp2IlInjected.Address(RVA = "0x6212540", Offset = "0x6210D40", VA = "0x186212540", Slot = "4")]
	public void EGEGKPJLIKO(Vector3 AKFFELDLHDA, ForceMode ACFLBCIEBAA = ForceMode.Force)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000489")]
	[Cpp2IlInjected.Address(RVA = "0x6212AB0", Offset = "0x62112B0", VA = "0x186212AB0")]
	private void MHHBGHDJNEF(Vector3 AKFFELDLHDA, ForceMode ACFLBCIEBAA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600048A")]
	[Cpp2IlInjected.Address(RVA = "0x6212FD0", Offset = "0x62117D0", VA = "0x186212FD0", Slot = "5")]
	public void NOAIHMJOFMI(Vector3 AKFFELDLHDA, Vector3 MCLBBPPAHAP, ForceMode ACFLBCIEBAA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600048B")]
	[Cpp2IlInjected.Address(RVA = "0x6212950", Offset = "0x6211150", VA = "0x186212950", Slot = "6")]
	public void JHDOIGEAHPA(Vector3 FNPOFGBLJMD, ForceMode ACFLBCIEBAA = ForceMode.Force)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600048C")]
	[Cpp2IlInjected.Address(RVA = "0x6212D10", Offset = "0x6211510", VA = "0x186212D10")]
	private void NGHNPIFHLLG(Vector3 FNPOFGBLJMD, ForceMode ACFLBCIEBAA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600048D")]
	[Cpp2IlInjected.Address(RVA = "0x62126F0", Offset = "0x6210EF0", VA = "0x1862126F0", Slot = "7")]
	public void INFGEGJJGIJ(Vector3 FNPOFGBLJMD, ForceMode ACFLBCIEBAA = ForceMode.Force)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200004C")]
internal sealed class IENKIDOLBFF : HEEAIGPCPDE
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400007E")]
	private readonly ALHCFOHGNMD AHGOPBJOELE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400007F")]
	private bool ILJCCPMKGED;

	[Cpp2IlInjected.Token(Token = "0x1700012F")]
	public bool DAFMFMBFKBE
	{
		[Cpp2IlInjected.Token(Token = "0x600048F")]
		[Cpp2IlInjected.Address(RVA = "0x7D07D0", Offset = "0x7CEFD0", VA = "0x1807D07D0", Slot = "4")]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000490")]
		[Cpp2IlInjected.Address(RVA = "0x621F2A0", Offset = "0x621DAA0", VA = "0x18621F2A0", Slot = "5")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600048E")]
	[Cpp2IlInjected.Address(RVA = "0x6213250", Offset = "0x6211A50", VA = "0x186213250")]
	public IENKIDOLBFF(ACNEEEENOML AHGOPBJOELE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000491")]
	[Cpp2IlInjected.Address(RVA = "0x621F270", Offset = "0x621DA70", VA = "0x18621F270", Slot = "6")]
	public void DOIABHKLMHG(Rigidbody JFKGLMKHADB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000492")]
	[Cpp2IlInjected.Address(RVA = "0x621CD50", Offset = "0x621B550", VA = "0x18621CD50", Slot = "7")]
	public void HAKPNCDKJGA(Rigidbody JFKGLMKHADB)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200004D")]
internal sealed class HEEGLMPJKGA : EBDLADNIDOH, PMHIGDLAJOP, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x4000089")]
	private readonly ACNEEEENOML AHGOPBJOELE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x400008A")]
	private readonly List<ACNEEEENOML> NLFNHIPAONL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x400008B")]
	private ACNEEEENOML DIPDOFGLHFF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x400008C")]
	private ACNEEEENOML OBIIIBPBMLD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
	[Cpp2IlInjected.Token(Token = "0x400008D")]
	private Transform BEPJNHBHBCI;

	[Cpp2IlInjected.Token(Token = "0x17000130")]
	private Transform BDOKOMBLFFF
	{
		[Cpp2IlInjected.Token(Token = "0x60004A5")]
		[Cpp2IlInjected.Address(RVA = "0x621E5B0", Offset = "0x621CDB0", VA = "0x18621E5B0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000131")]
	public ACNEEEENOML MLDLDJMPPGN
	{
		[Cpp2IlInjected.Token(Token = "0x60004A8")]
		[Cpp2IlInjected.Address(RVA = "0x761C20", Offset = "0x760420", VA = "0x180761C20", Slot = "28")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60004A9")]
		[Cpp2IlInjected.Address(RVA = "0x621E800", Offset = "0x621D000", VA = "0x18621E800", Slot = "29")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000132")]
	public ACNEEEENOML IDPDODAHCDH
	{
		[Cpp2IlInjected.Token(Token = "0x60004AA")]
		[Cpp2IlInjected.Address(RVA = "0x761C30", Offset = "0x760430", VA = "0x180761C30", Slot = "27")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000133")]
	public IReadOnlyList<ACNEEEENOML> FKAHMBHHHJN
	{
		[Cpp2IlInjected.Token(Token = "0x60004AB")]
		[Cpp2IlInjected.Address(RVA = "0x761C00", Offset = "0x760400", VA = "0x180761C00", Slot = "26")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000042")]
	public event EBFBHNJDFMO PAAEJBNAELP
	{
		[Cpp2IlInjected.Token(Token = "0x6000493")]
		[Cpp2IlInjected.Address(RVA = "0x621E760", Offset = "0x621CF60", VA = "0x18621E760", Slot = "8")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000494")]
		[Cpp2IlInjected.Address(RVA = "0x621E610", Offset = "0x621CE10", VA = "0x18621E610", Slot = "9")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000043")]
	public event EBFBHNJDFMO ANLGMIPOGHH
	{
		[Cpp2IlInjected.Token(Token = "0x6000495")]
		[Cpp2IlInjected.Address(RVA = "0x621D270", Offset = "0x621BA70", VA = "0x18621D270", Slot = "10")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000496")]
		[Cpp2IlInjected.Address(RVA = "0x621D310", Offset = "0x621BB10", VA = "0x18621D310", Slot = "11")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000044")]
	public event GHEEFDJOPPC GDBIGLFOIGG
	{
		[Cpp2IlInjected.Token(Token = "0x6000497")]
		[Cpp2IlInjected.Address(RVA = "0x621CE20", Offset = "0x621B620", VA = "0x18621CE20", Slot = "12")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000498")]
		[Cpp2IlInjected.Address(RVA = "0x621D6D0", Offset = "0x621BED0", VA = "0x18621D6D0", Slot = "13")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000045")]
	public event Action LEDOPACHHJI
	{
		[Cpp2IlInjected.Token(Token = "0x6000499")]
		[Cpp2IlInjected.Address(RVA = "0x621D4F0", Offset = "0x621BCF0", VA = "0x18621D4F0", Slot = "14")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600049A")]
		[Cpp2IlInjected.Address(RVA = "0x621EBA0", Offset = "0x621D3A0", VA = "0x18621EBA0", Slot = "15")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000046")]
	public event Action PMKLHIGJFKE
	{
		[Cpp2IlInjected.Token(Token = "0x600049B")]
		[Cpp2IlInjected.Address(RVA = "0x621D630", Offset = "0x621BE30", VA = "0x18621D630", Slot = "16")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600049C")]
		[Cpp2IlInjected.Address(RVA = "0x621D590", Offset = "0x621BD90", VA = "0x18621D590", Slot = "17")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000047")]
	public event Action<ACNEEEENOML> DICGHONINEC
	{
		[Cpp2IlInjected.Token(Token = "0x600049D")]
		[Cpp2IlInjected.Address(RVA = "0x621DC60", Offset = "0x621C460", VA = "0x18621DC60", Slot = "18")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600049E")]
		[Cpp2IlInjected.Address(RVA = "0x621E9B0", Offset = "0x621D1B0", VA = "0x18621E9B0", Slot = "19")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000048")]
	public event Action<ACNEEEENOML> DHKNBNGMEPD
	{
		[Cpp2IlInjected.Token(Token = "0x600049F")]
		[Cpp2IlInjected.Address(RVA = "0x621E900", Offset = "0x621D100", VA = "0x18621E900", Slot = "20")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60004A0")]
		[Cpp2IlInjected.Address(RVA = "0x621CFB0", Offset = "0x621B7B0", VA = "0x18621CFB0", Slot = "21")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000049")]
	public event Action EIPNHPBGMNG
	{
		[Cpp2IlInjected.Token(Token = "0x60004A1")]
		[Cpp2IlInjected.Address(RVA = "0x621D060", Offset = "0x621B860", VA = "0x18621D060", Slot = "22")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60004A2")]
		[Cpp2IlInjected.Address(RVA = "0x621DD10", Offset = "0x621C510", VA = "0x18621DD10", Slot = "23")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400004A")]
	public event Action<ACNEEEENOML> FGIJOHKDECO
	{
		[Cpp2IlInjected.Token(Token = "0x60004A3")]
		[Cpp2IlInjected.Address(RVA = "0x621E6B0", Offset = "0x621CEB0", VA = "0x18621E6B0", Slot = "24")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60004A4")]
		[Cpp2IlInjected.Address(RVA = "0x621DB10", Offset = "0x621C310", VA = "0x18621DB10", Slot = "25")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60004A6")]
	[Cpp2IlInjected.Address(RVA = "0x621EC40", Offset = "0x621D440", VA = "0x18621EC40")]
	public HEEGLMPJKGA(ACNEEEENOML AHGOPBJOELE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004A7")]
	[Cpp2IlInjected.Address(RVA = "0x621D3B0", Offset = "0x621BBB0", VA = "0x18621D3B0", Slot = "31")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004AC")]
	[Cpp2IlInjected.Address(RVA = "0x621E030", Offset = "0x621C830", VA = "0x18621E030", Slot = "30")]
	public void JLJFDADNEME(ACNEEEENOML KEDAAEKKLOL, bool CGKOADMHFLC = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004AD")]
	[Cpp2IlInjected.Address(RVA = "0x621D770", Offset = "0x621BF70", VA = "0x18621D770", Slot = "6")]
	public void HALBFMEBFHC(ACNEEEENOML HKJABBNKIDD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004AE")]
	[Cpp2IlInjected.Address(RVA = "0x621DDB0", Offset = "0x621C5B0", VA = "0x18621DDB0", Slot = "7")]
	public void JDIMBCAFGPK(ACNEEEENOML HKJABBNKIDD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004AF")]
	[Cpp2IlInjected.Address(RVA = "0x621CEC0", Offset = "0x621B6C0", VA = "0x18621CEC0", Slot = "4")]
	public void CCIOJOCPJBE(ACNEEEENOML AHGOPBJOELE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004B0")]
	[Cpp2IlInjected.Address(RVA = "0x621DBC0", Offset = "0x621C3C0", VA = "0x18621DBC0", Slot = "5")]
	public void IIMOIKPKMHN(ACNEEEENOML AHGOPBJOELE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004B1")]
	[Cpp2IlInjected.Address(RVA = "0x621D450", Offset = "0x621BC50", VA = "0x18621D450")]
	private void EHJIMIBKHAN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004B2")]
	[Cpp2IlInjected.Address(RVA = "0x621D230", Offset = "0x621BA30", VA = "0x18621D230")]
	private void DGEDOGIJEFN(ACNEEEENOML HKJABBNKIDD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004B3")]
	[Cpp2IlInjected.Address(RVA = "0x621EA60", Offset = "0x621D260", VA = "0x18621EA60")]
	private void ONPMKPGFHMH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004B4")]
	[Cpp2IlInjected.Address(RVA = "0x621D9E0", Offset = "0x621C1E0", VA = "0x18621D9E0")]
	private void HHOBHOHCAOO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004B5")]
	[Cpp2IlInjected.Address(RVA = "0x621D100", Offset = "0x621B900", VA = "0x18621D100")]
	private void CMMHBDBPGLC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004B6")]
	[Cpp2IlInjected.Address(RVA = "0x621E810", Offset = "0x621D010", VA = "0x18621E810")]
	[CompilerGenerated]
	private object NPBKLNALNNK()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200004E")]
internal static class ONBDFNIGFHM
{
	[Cpp2IlInjected.Token(Token = "0x60004B7")]
	[Cpp2IlInjected.Address(RVA = "0x622B620", Offset = "0x6229E20", VA = "0x18622B620")]
	public static EBDLADNIDOH DNDCCOBNFMK(this ACNEEEENOML PCEPPDLMHCM)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200004F")]
internal sealed class PDKLCAJEGIC : AKACGEKEHCH, LMDEEHLJMOK
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400008E")]
	private readonly ALHCFOHGNMD AHGOPBJOELE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400008F")]
	private readonly AAKBOGCEFIH<ACNEEEENOML> FDNCGHAGPJC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000090")]
	private bool PELLBJAIBNN;

	[Cpp2IlInjected.Token(Token = "0x17000134")]
	public AAKBOGCEFIH<ACNEEEENOML> CLFJOLBOENB
	{
		[Cpp2IlInjected.Token(Token = "0x60004B8")]
		[Cpp2IlInjected.Address(RVA = "0x765620", Offset = "0x763E20", VA = "0x180765620", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000135")]
	public Vector3 EEEHLJDAFJK
	{
		[Cpp2IlInjected.Token(Token = "0x60004B9")]
		[Cpp2IlInjected.Address(RVA = "0x622D830", Offset = "0x622C030", VA = "0x18622D830", Slot = "6")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000136")]
	public Vector3 JDGLCEIOOBF
	{
		[Cpp2IlInjected.Token(Token = "0x60004BA")]
		[Cpp2IlInjected.Address(RVA = "0x622D670", Offset = "0x622BE70", VA = "0x18622D670", Slot = "7")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000137")]
	private Vector3 NBKAJOJDMMI
	{
		[Cpp2IlInjected.Token(Token = "0x60004BE")]
		[Cpp2IlInjected.Address(RVA = "0x622D520", Offset = "0x622BD20", VA = "0x18622D520")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000138")]
	public ACNEEEENOML KIHKKDCAAPO
	{
		[Cpp2IlInjected.Token(Token = "0x60004BF")]
		[Cpp2IlInjected.Address(RVA = "0x622CD50", Offset = "0x622B550", VA = "0x18622CD50", Slot = "5")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60004BB")]
	[Cpp2IlInjected.Address(RVA = "0x622D860", Offset = "0x622C060", VA = "0x18622D860")]
	public PDKLCAJEGIC(ACNEEEENOML AHGOPBJOELE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004BC")]
	[Cpp2IlInjected.Address(RVA = "0x622CCE0", Offset = "0x622B4E0", VA = "0x18622CCE0", Slot = "8")]
	public void HHGGBNOHIJM(ACNEEEENOML OBIIIBPBMLD, object KIAKEGJPMAL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004BD")]
	[Cpp2IlInjected.Address(RVA = "0x622D610", Offset = "0x622BE10", VA = "0x18622D610", Slot = "9")]
	public void LPFADOHJNOB(object KIAKEGJPMAL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004C0")]
	[Cpp2IlInjected.Address(RVA = "0x622CE00", Offset = "0x622B600", VA = "0x18622CE00")]
	private Vector3 KDFDHKNFKIK()
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x60004C1")]
	[Cpp2IlInjected.Address(RVA = "0x622D190", Offset = "0x622B990", VA = "0x18622D190")]
	private void LDJGHEBJLCA(ACNEEEENOML BAEJBKKNKIE)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000050")]
internal static class DIILPGJEFDB
{
	[Cpp2IlInjected.Token(Token = "0x60004C2")]
	[Cpp2IlInjected.Address(RVA = "0x62159A0", Offset = "0x62141A0", VA = "0x1862159A0")]
	public static AKACGEKEHCH FEJBGBGEANI(this ACNEEEENOML PCEPPDLMHCM)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000051")]
internal sealed class AIDBKEINGJH : MKGDOFOGMMF, KFKLGADFDEA
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000092")]
	private readonly ALHCFOHGNMD AHGOPBJOELE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000093")]
	private readonly OverridableVector3 DIDJMHLGDCH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000094")]
	private readonly OverridableVector3 HMLDCLIHLHH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000095")]
	private float FELOCIBFPFA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x44")]
	[Cpp2IlInjected.Token(Token = "0x4000096")]
	private float FABLLLKKOKH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000097")]
	private Vector3 AOMNMAJCKEJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x54")]
	[Cpp2IlInjected.Token(Token = "0x4000098")]
	private Vector3? IKDLKPGINHP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x64")]
	[Cpp2IlInjected.Token(Token = "0x4000099")]
	private Quaternion? EMFIIFKPNLG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
	[Cpp2IlInjected.Token(Token = "0x400009A")]
	private bool NOJNOBDMDAN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x79")]
	[Cpp2IlInjected.Token(Token = "0x400009B")]
	private bool GFMIKFLMDFF;

	[Cpp2IlInjected.Token(Token = "0x17000139")]
	public Vector3 LBFLJMHMJDO
	{
		[Cpp2IlInjected.Token(Token = "0x60004C5")]
		[Cpp2IlInjected.Address(RVA = "0xF6F670", Offset = "0xF6DE70", VA = "0x180F6F670", Slot = "7")]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x60004C6")]
		[Cpp2IlInjected.Address(RVA = "0x6209A70", Offset = "0x6208270", VA = "0x186209A70", Slot = "8")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700013A")]
	public Vector3 CCEGGEBAGNO
	{
		[Cpp2IlInjected.Token(Token = "0x60004C7")]
		[Cpp2IlInjected.Address(RVA = "0x620BC80", Offset = "0x620A480", VA = "0x18620BC80", Slot = "9")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700013B")]
	public float FDPCBODPJHG
	{
		[Cpp2IlInjected.Token(Token = "0x60004C8")]
		[Cpp2IlInjected.Address(RVA = "0x1017550", Offset = "0x1015D50", VA = "0x181017550", Slot = "10")]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x60004C9")]
		[Cpp2IlInjected.Address(RVA = "0x620BDD0", Offset = "0x620A5D0", VA = "0x18620BDD0")]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700013C")]
	public float PFMNCEKEBOC
	{
		[Cpp2IlInjected.Token(Token = "0x60004CA")]
		[Cpp2IlInjected.Address(RVA = "0xAE4A20", Offset = "0xAE3220", VA = "0x180AE4A20", Slot = "11")]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x60004CB")]
		[Cpp2IlInjected.Address(RVA = "0x6209CD0", Offset = "0x62084D0", VA = "0x186209CD0", Slot = "12")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700013D")]
	public Vector3 ONJLJDCPIMM
	{
		[Cpp2IlInjected.Token(Token = "0x60004CC")]
		[Cpp2IlInjected.Address(RVA = "0x620B3C0", Offset = "0x6209BC0", VA = "0x18620B3C0", Slot = "13")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700013E")]
	public Quaternion EKDPJMOLPAE
	{
		[Cpp2IlInjected.Token(Token = "0x60004CD")]
		[Cpp2IlInjected.Address(RVA = "0x620BB00", Offset = "0x620A300", VA = "0x18620BB00", Slot = "14")]
		get
		{
			return default(Quaternion);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700013F")]
	private Rigidbody AIOLOONKHDH
	{
		[Cpp2IlInjected.Token(Token = "0x60004D5")]
		[Cpp2IlInjected.Address(RVA = "0x620BD80", Offset = "0x620A580", VA = "0x18620BD80")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400004B")]
	public event EBFBHNJDFMO OEPHAIEKDOP
	{
		[Cpp2IlInjected.Token(Token = "0x60004C3")]
		[Cpp2IlInjected.Address(RVA = "0x6209E60", Offset = "0x6208660", VA = "0x186209E60", Slot = "5")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60004C4")]
		[Cpp2IlInjected.Address(RVA = "0x620C200", Offset = "0x620AA00", VA = "0x18620C200", Slot = "6")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60004CE")]
	[Cpp2IlInjected.Address(RVA = "0x620C410", Offset = "0x620AC10", VA = "0x18620C410")]
	public AIDBKEINGJH(ACNEEEENOML AHGOPBJOELE, [In] ACDBPOHPAKH AELCABDCBDD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004CF")]
	[Cpp2IlInjected.Address(RVA = "0x6209B20", Offset = "0x6208320", VA = "0x186209B20", Slot = "17")]
	public void ALFIJHNHMBG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004D0")]
	[Cpp2IlInjected.Address(RVA = "0x6209990", Offset = "0x6208190", VA = "0x186209990", Slot = "16")]
	public void AECDOEBBECA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004D1")]
	[Cpp2IlInjected.Address(RVA = "0x6209D80", Offset = "0x6208580", VA = "0x186209D80", Slot = "19")]
	public void DOIABHKLMHG(Rigidbody JFKGLMKHADB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004D2")]
	[Cpp2IlInjected.Address(RVA = "0x620B640", Offset = "0x6209E40", VA = "0x18620B640", Slot = "20")]
	public void HAKPNCDKJGA(Rigidbody JFKGLMKHADB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004D3")]
	[Cpp2IlInjected.Address(RVA = "0x620C2A0", Offset = "0x620AAA0", VA = "0x18620C2A0", Slot = "18")]
	public void PFMKNBPMAJC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004D4")]
	[Cpp2IlInjected.Address(RVA = "0x6209F00", Offset = "0x6208700", VA = "0x186209F00", Slot = "21")]
	public void FCAHOLPEHIP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004D6")]
	[Cpp2IlInjected.Address(RVA = "0x6209A70", Offset = "0x6208270", VA = "0x186209A70")]
	private void BDIDNGBLJBE(Vector3 FKKGMPDEPMA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004D7")]
	[Cpp2IlInjected.Address(RVA = "0x620B550", Offset = "0x6209D50", VA = "0x18620B550")]
	[Obsolete("This method is dangerous - the unity rigidbody is updated in a deferred manner and this world position may be stale")]
	private Vector3 GBEENDIEECB()
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x60004D8")]
	[Cpp2IlInjected.Address(RVA = "0x620BDD0", Offset = "0x620A5D0", VA = "0x18620BDD0")]
	private void KJHIOANOABA(float FKKGMPDEPMA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004D9")]
	[Cpp2IlInjected.Address(RVA = "0x6209CD0", Offset = "0x62084D0", VA = "0x186209CD0")]
	private void CLPJMBCAHEL(float FKKGMPDEPMA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004DA")]
	[Cpp2IlInjected.Address(RVA = "0x620BEE0", Offset = "0x620A6E0", VA = "0x18620BEE0")]
	private Vector3 LODNGBLOAPP()
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x60004DB")]
	[Cpp2IlInjected.Address(RVA = "0x620B8D0", Offset = "0x620A0D0", VA = "0x18620B8D0", Slot = "15")]
	public void HFHDCMEIKAH((Quaternion rot, Vector3 moments) MOGJAEMHOKI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004DC")]
	[Cpp2IlInjected.Address(RVA = "0x620C080", Offset = "0x620A880", VA = "0x18620C080")]
	private Quaternion MGGBONNJOOL()
	{
		return default(Quaternion);
	}

	[Cpp2IlInjected.Token(Token = "0x60004DD")]
	[Cpp2IlInjected.Address(RVA = "0x620B2F0", Offset = "0x6209AF0", VA = "0x18620B2F0")]
	public void FJHOJGMHILJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004DE")]
	[Cpp2IlInjected.Address(RVA = "0x620A3A0", Offset = "0x6208BA0", VA = "0x18620A3A0", Slot = "4")]
	public (float, Vector3) FJHOJGMHILJ(Rigidbody EIHBMPLDGIB)
	{
		return default((float, Vector3));
	}
}
[Cpp2IlInjected.Token(Token = "0x2000052")]
internal static class FPCEKBLHMCN
{
	[Cpp2IlInjected.Token(Token = "0x60004DF")]
	[Cpp2IlInjected.Address(RVA = "0x621C290", Offset = "0x621AA90", VA = "0x18621C290")]
	public static MKGDOFOGMMF KFCBJHMAPGF(this ACNEEEENOML PCEPPDLMHCM)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000053")]
internal sealed class GHLEMKGFCHG : CFLOPMDOLBK
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400009C")]
	private readonly ALHCFOHGNMD AHGOPBJOELE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400009D")]
	private readonly BOKOFNDFGJO JDDCKHMBAFB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400009E")]
	private readonly LKCJDGFAJNM CKKKGDFOKIB;

	[Cpp2IlInjected.Token(Token = "0x17000140")]
	public bool ALFMGFEAILH
	{
		[Cpp2IlInjected.Token(Token = "0x60004E0")]
		[Cpp2IlInjected.Address(RVA = "0xC1D140", Offset = "0xC1B940", VA = "0x180C1D140", Slot = "10")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000141")]
	public LKCJDGFAJNM LHLDLDFNNPI
	{
		[Cpp2IlInjected.Token(Token = "0x60004E1")]
		[Cpp2IlInjected.Address(RVA = "0x80C100", Offset = "0x80A900", VA = "0x18080C100", Slot = "11")]
		get
		{
			return default(LKCJDGFAJNM);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60004E2")]
	[Cpp2IlInjected.Address(RVA = "0x621CA70", Offset = "0x621B270", VA = "0x18621CA70")]
	public GHLEMKGFCHG(ACNEEEENOML AHGOPBJOELE, [In] ACDBPOHPAKH AELCABDCBDD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004E3")]
	[Cpp2IlInjected.Address(RVA = "0x621C480", Offset = "0x621AC80", VA = "0x18621C480", Slot = "4")]
	public void BMFHLKIGOGD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004E4")]
	[Cpp2IlInjected.Address(RVA = "0x621C6F0", Offset = "0x621AEF0", VA = "0x18621C6F0")]
	private bool IHHEDOOEMJC()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60004E5")]
	[Cpp2IlInjected.Address(RVA = "0x621C550", Offset = "0x621AD50", VA = "0x18621C550", Slot = "5")]
	public void DOABBELLDJM(object KIAKEGJPMAL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004E6")]
	[Cpp2IlInjected.Address(RVA = "0x621C450", Offset = "0x621AC50", VA = "0x18621C450", Slot = "6")]
	public void BDNICLLPIJJ(object KIAKEGJPMAL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004E7")]
	[Cpp2IlInjected.Address(RVA = "0x621C930", Offset = "0x621B130", VA = "0x18621C930", Slot = "9")]
	public void OPGFFJKLKHF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004E8")]
	[Cpp2IlInjected.Address(RVA = "0x621C7D0", Offset = "0x621AFD0", VA = "0x18621C7D0")]
	private void OFPKPHPPIAJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004E9")]
	[Cpp2IlInjected.Address(RVA = "0x621C580", Offset = "0x621AD80", VA = "0x18621C580")]
	private void HBPOAAAGACC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004EA")]
	[Cpp2IlInjected.Address(RVA = "0x621C790", Offset = "0x621AF90", VA = "0x18621C790", Slot = "8")]
	public void MECFNGIPFAC(ACNEEEENOML AHGOPBJOELE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004EB")]
	[Cpp2IlInjected.Address(RVA = "0x621C8F0", Offset = "0x621B0F0", VA = "0x18621C8F0", Slot = "7")]
	public void OONMABADHAF(ACNEEEENOML AHGOPBJOELE)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000054")]
internal sealed class FKOIAHAJHBI : DMPEOOKGLDG
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000A0")]
	private readonly ALHCFOHGNMD AHGOPBJOELE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000A1")]
	private readonly BOKOFNDFGJO ICLPFFAMGEO;

	[Cpp2IlInjected.Token(Token = "0x17000142")]
	public bool AIFLGAACHML
	{
		[Cpp2IlInjected.Token(Token = "0x60004EE")]
		[Cpp2IlInjected.Address(RVA = "0x621B830", Offset = "0x621A030", VA = "0x18621B830", Slot = "7")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400004C")]
	public event EBFBHNJDFMO KOMDEBFEEEP
	{
		[Cpp2IlInjected.Token(Token = "0x60004EC")]
		[Cpp2IlInjected.Address(RVA = "0x621BA50", Offset = "0x621A250", VA = "0x18621BA50", Slot = "4")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60004ED")]
		[Cpp2IlInjected.Address(RVA = "0x621BAF0", Offset = "0x621A2F0", VA = "0x18621BAF0", Slot = "5")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60004EF")]
	[Cpp2IlInjected.Address(RVA = "0x621BCB0", Offset = "0x621A4B0", VA = "0x18621BCB0")]
	public FKOIAHAJHBI(ACNEEEENOML AHGOPBJOELE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004F0")]
	[Cpp2IlInjected.Address(RVA = "0x621B9E0", Offset = "0x621A1E0", VA = "0x18621B9E0", Slot = "11")]
	public IDisposable HIJEMOJOGMK()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004F1")]
	[Cpp2IlInjected.Address(RVA = "0x621BB90", Offset = "0x621A390", VA = "0x18621BB90", Slot = "8")]
	public void JOKCPNGIIMH(object KIAKEGJPMAL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004F2")]
	[Cpp2IlInjected.Address(RVA = "0x621B8E0", Offset = "0x621A0E0", VA = "0x18621B8E0", Slot = "9")]
	public void CFLECLOAECH(object KIAKEGJPMAL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004F3")]
	[Cpp2IlInjected.Address(RVA = "0x621BBA0", Offset = "0x621A3A0", VA = "0x18621BBA0", Slot = "10")]
	public void PHMJJJCNKII(object KIAKEGJPMAL, bool JMNDFKAOINO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004F4")]
	[Cpp2IlInjected.Address(RVA = "0x621B970", Offset = "0x621A170", VA = "0x18621B970", Slot = "6")]
	public void GPJJKLDHAFI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004F5")]
	[Cpp2IlInjected.Address(RVA = "0x621B8F0", Offset = "0x621A0F0", VA = "0x18621B8F0", Slot = "12")]
	public void DOIABHKLMHG(Rigidbody KFJMODPJOOA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004F6")]
	[Cpp2IlInjected.Address(RVA = "0x621B9B0", Offset = "0x621A1B0", VA = "0x18621B9B0", Slot = "13")]
	public void HAKPNCDKJGA(Rigidbody JFKGLMKHADB)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000055")]
internal sealed class JOKLCAONHGP : PCOFBEEFBPN, DCKAOPOPPEM, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000A3")]
	private readonly ALHCFOHGNMD AHGOPBJOELE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000A4")]
	private PhotonView LOIBHJHOJDK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40000A5")]
	private bool MBCKJAOKOJM;

	[Cpp2IlInjected.Token(Token = "0x17000143")]
	public PhotonView HLDIKJHKBKI
	{
		[Cpp2IlInjected.Token(Token = "0x60004F9")]
		[Cpp2IlInjected.Address(RVA = "0x766110", Offset = "0x764910", VA = "0x180766110", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000144")]
	public bool LFEOJFGHFML
	{
		[Cpp2IlInjected.Token(Token = "0x60004FA")]
		[Cpp2IlInjected.Address(RVA = "0x6222050", Offset = "0x6220850", VA = "0x186222050", Slot = "7")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000145")]
	public bool NEIGPDMIINK
	{
		[Cpp2IlInjected.Token(Token = "0x60004FB")]
		[Cpp2IlInjected.Address(RVA = "0x7FCD80", Offset = "0x7FB580", VA = "0x1807FCD80", Slot = "8")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400004D")]
	public event EBFBHNJDFMO GILKHDKMEND
	{
		[Cpp2IlInjected.Token(Token = "0x60004F7")]
		[Cpp2IlInjected.Address(RVA = "0x62218A0", Offset = "0x62200A0", VA = "0x1862218A0", Slot = "5")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60004F8")]
		[Cpp2IlInjected.Address(RVA = "0x6221FB0", Offset = "0x62207B0", VA = "0x186221FB0", Slot = "6")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60004FC")]
	[Cpp2IlInjected.Address(RVA = "0x62222E0", Offset = "0x6220AE0", VA = "0x1862222E0")]
	public JOKLCAONHGP(ACNEEEENOML AHGOPBJOELE, [In] ACDBPOHPAKH AELCABDCBDD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004FD")]
	[Cpp2IlInjected.Address(RVA = "0x6221940", Offset = "0x6220140", VA = "0x186221940", Slot = "9")]
	public void BMFHLKIGOGD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004FE")]
	[Cpp2IlInjected.Address(RVA = "0x6221D50", Offset = "0x6220550", VA = "0x186221D50", Slot = "12")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004FF")]
	[Cpp2IlInjected.Address(RVA = "0x6221730", Offset = "0x621FF30", VA = "0x186221730", Slot = "10")]
	public void ACFBEMHJHMI(ACNEEEENOML OBIIIBPBMLD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000500")]
	[Cpp2IlInjected.Address(RVA = "0x6221A70", Offset = "0x6220270", VA = "0x186221A70", Slot = "11")]
	public void DDKAOBEOLDP(ACNEEEENOML OBIIIBPBMLD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000501")]
	[Cpp2IlInjected.Address(RVA = "0x6221BE0", Offset = "0x62203E0", VA = "0x186221BE0")]
	private void DKLKILDINMO(PhotonView PJIECOLLBDM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000502")]
	[Cpp2IlInjected.Address(RVA = "0x6221E50", Offset = "0x6220650", VA = "0x186221E50")]
	private void JKCNNCNLLDO(RigidbodyEx LKDGACMBLIN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000503")]
	[Cpp2IlInjected.Address(RVA = "0x6222070", Offset = "0x6220870", VA = "0x186222070")]
	private void PHMOFOGLJEL(PhotonView HELMMFHGEMG)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000056")]
internal static class KOOFJCJEDEI
{
	[Cpp2IlInjected.Token(Token = "0x6000504")]
	[Cpp2IlInjected.Address(RVA = "0x62223E0", Offset = "0x6220BE0", VA = "0x1862223E0")]
	public static PCOFBEEFBPN IHAICJCJPBD(this ACNEEEENOML PCEPPDLMHCM)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000057")]
internal sealed class FMIKEIGFLPB : GCEONIOPFOG
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000A6")]
	private readonly ALHCFOHGNMD AHGOPBJOELE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000A7")]
	private RigidbodyConstraints FMPNKBADMFO;

	[Cpp2IlInjected.Token(Token = "0x17000146")]
	public bool JIAMCDEEBDI
	{
		[Cpp2IlInjected.Token(Token = "0x6000505")]
		[Cpp2IlInjected.Address(RVA = "0xA0F5A0", Offset = "0xA0DDA0", VA = "0x180A0F5A0", Slot = "4")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000506")]
		[Cpp2IlInjected.Address(RVA = "0x36245D0", Offset = "0x3622DD0", VA = "0x1836245D0", Slot = "5")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000147")]
	public bool OHGMMHIOBGA
	{
		[Cpp2IlInjected.Token(Token = "0x6000507")]
		[Cpp2IlInjected.Address(RVA = "0x3B881D0", Offset = "0x3B869D0", VA = "0x183B881D0", Slot = "6")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000508")]
		[Cpp2IlInjected.Address(RVA = "0x36245E0", Offset = "0x3622DE0", VA = "0x1836245E0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000148")]
	public RigidbodyConstraints LKJNJPEFLGB
	{
		[Cpp2IlInjected.Token(Token = "0x6000509")]
		[Cpp2IlInjected.Address(RVA = "0x768D90", Offset = "0x767590", VA = "0x180768D90", Slot = "7")]
		get
		{
			return default(RigidbodyConstraints);
		}
		[Cpp2IlInjected.Token(Token = "0x600050A")]
		[Cpp2IlInjected.Address(RVA = "0x621BDA0", Offset = "0x621A5A0", VA = "0x18621BDA0", Slot = "8")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600050B")]
	[Cpp2IlInjected.Address(RVA = "0x621BF30", Offset = "0x621A730", VA = "0x18621BF30")]
	public FMIKEIGFLPB(ACNEEEENOML AHGOPBJOELE, [In] ACDBPOHPAKH AELCABDCBDD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600050C")]
	[Cpp2IlInjected.Address(RVA = "0x621BED0", Offset = "0x621A6D0", VA = "0x18621BED0", Slot = "9")]
	public void DOIABHKLMHG(Rigidbody JFKGLMKHADB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600050D")]
	[Cpp2IlInjected.Address(RVA = "0x621BF00", Offset = "0x621A700", VA = "0x18621BF00", Slot = "10")]
	public void HAKPNCDKJGA(Rigidbody JFKGLMKHADB)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000058")]
internal sealed class ECIKKAOPKAP : BMMIOFOJJEB
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000AA")]
	private readonly ACNEEEENOML AHGOPBJOELE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000AB")]
	private float KHKHCHJFFEJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
	[Cpp2IlInjected.Token(Token = "0x40000AC")]
	private float FNLHMFOPCIN;

	[Cpp2IlInjected.Token(Token = "0x17000149")]
	public float EPNHAMDEIMB
	{
		[Cpp2IlInjected.Token(Token = "0x600050F")]
		[Cpp2IlInjected.Address(RVA = "0x7EE890", Offset = "0x7ED090", VA = "0x1807EE890", Slot = "4")]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x6000510")]
		[Cpp2IlInjected.Address(RVA = "0x6217100", Offset = "0x6215900", VA = "0x186217100", Slot = "5")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700014A")]
	public float FJKLFMLIIEM
	{
		[Cpp2IlInjected.Token(Token = "0x6000511")]
		[Cpp2IlInjected.Address(RVA = "0x86FB70", Offset = "0x86E370", VA = "0x18086FB70", Slot = "6")]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x6000512")]
		[Cpp2IlInjected.Address(RVA = "0x62171D0", Offset = "0x62159D0", VA = "0x1862171D0", Slot = "7")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600050E")]
	[Cpp2IlInjected.Address(RVA = "0x62172A0", Offset = "0x6215AA0", VA = "0x1862172A0")]
	public ECIKKAOPKAP(ACNEEEENOML AHGOPBJOELE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000513")]
	[Cpp2IlInjected.Address(RVA = "0x6217010", Offset = "0x6215810", VA = "0x186217010", Slot = "8")]
	public void DOIABHKLMHG(Rigidbody JFKGLMKHADB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000514")]
	[Cpp2IlInjected.Address(RVA = "0x6217060", Offset = "0x6215860", VA = "0x186217060", Slot = "9")]
	public void HAKPNCDKJGA(Rigidbody JFKGLMKHADB)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000059")]
internal sealed class NNOOGCPCBDE : CCAMOPPOPEI
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000AE")]
	private readonly ALHCFOHGNMD AHGOPBJOELE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000AF")]
	private bool FLJANOGJCOO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x21")]
	[Cpp2IlInjected.Token(Token = "0x40000B0")]
	private bool KEJMOFLOBFP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
	[Cpp2IlInjected.Token(Token = "0x40000B1")]
	private int EOHLJFOADON;

	[Cpp2IlInjected.Token(Token = "0x1700014B")]
	private Rigidbody AIOLOONKHDH
	{
		[Cpp2IlInjected.Token(Token = "0x6000517")]
		[Cpp2IlInjected.Address(RVA = "0x620BD80", Offset = "0x620A580", VA = "0x18620BD80")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700014C")]
	private bool FAHPFCJEPJO
	{
		[Cpp2IlInjected.Token(Token = "0x6000518")]
		[Cpp2IlInjected.Address(RVA = "0x622A9A0", Offset = "0x62291A0", VA = "0x18622A9A0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700014D")]
	private ACNEEEENOML MLDLDJMPPGN
	{
		[Cpp2IlInjected.Token(Token = "0x6000519")]
		[Cpp2IlInjected.Address(RVA = "0x622A810", Offset = "0x6229010", VA = "0x18622A810")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700014E")]
	private bool IDEKMMEBDBI
	{
		[Cpp2IlInjected.Token(Token = "0x600051A")]
		[Cpp2IlInjected.Address(RVA = "0x622B260", Offset = "0x6229A60", VA = "0x18622B260")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400004E")]
	public event EBFBHNJDFMO CDIFNKKNIAI
	{
		[Cpp2IlInjected.Token(Token = "0x6000515")]
		[Cpp2IlInjected.Address(RVA = "0x622AA60", Offset = "0x6229260", VA = "0x18622AA60", Slot = "4")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000516")]
		[Cpp2IlInjected.Address(RVA = "0x622A9C0", Offset = "0x62291C0", VA = "0x18622A9C0", Slot = "5")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600051B")]
	[Cpp2IlInjected.Address(RVA = "0x622B2D0", Offset = "0x6229AD0", VA = "0x18622B2D0")]
	public NNOOGCPCBDE(ACNEEEENOML AHGOPBJOELE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600051C")]
	[Cpp2IlInjected.Address(RVA = "0x622A910", Offset = "0x6229110", VA = "0x18622A910", Slot = "6")]
	public void BMFHLKIGOGD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600051D")]
	[Cpp2IlInjected.Address(RVA = "0x622B2C0", Offset = "0x6229AC0", VA = "0x18622B2C0", Slot = "8")]
	public void OPPINPEGPBG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600051E")]
	[Cpp2IlInjected.Address(RVA = "0x622AB00", Offset = "0x6229300", VA = "0x18622AB00", Slot = "7")]
	public bool ICIHJKDLIHF()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600051F")]
	[Cpp2IlInjected.Address(RVA = "0x622A870", Offset = "0x6229070", VA = "0x18622A870", Slot = "9")]
	public void BHMFFCOHDEE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000520")]
	[Cpp2IlInjected.Address(RVA = "0x622ADE0", Offset = "0x62295E0", VA = "0x18622ADE0", Slot = "11")]
	public void JAEFDNECOPP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000521")]
	[Cpp2IlInjected.Address(RVA = "0x622B210", Offset = "0x6229A10", VA = "0x18622B210", Slot = "12")]
	public void MMKNBNPGODE(bool IIBPGCHKBGC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000522")]
	[Cpp2IlInjected.Address(RVA = "0x622AE80", Offset = "0x6229680", VA = "0x18622AE80", Slot = "10")]
	public void KNGOMHMODPL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000523")]
	[Cpp2IlInjected.Address(RVA = "0x622B030", Offset = "0x6229830", VA = "0x18622B030")]
	private bool LMCLNANCCDK()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000524")]
	[Cpp2IlInjected.Address(RVA = "0x622AC50", Offset = "0x6229450", VA = "0x18622AC50")]
	private void IKMBINBPBPA()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200005A")]
internal sealed class IKAOJPHKPKL : JGMBKBLBJEA
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000B2")]
	private readonly ALHCFOHGNMD AHGOPBJOELE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000B3")]
	private readonly BOKOFNDFGJO KLFEOJAJDAL;

	[Cpp2IlInjected.Token(Token = "0x1700014F")]
	public Rigidbody AIOLOONKHDH
	{
		[Cpp2IlInjected.Token(Token = "0x6000525")]
		[Cpp2IlInjected.Address(RVA = "0x766110", Offset = "0x764910", VA = "0x180766110", Slot = "4")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000526")]
		[Cpp2IlInjected.Address(RVA = "0x7662F0", Offset = "0x764AF0", VA = "0x1807662F0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000150")]
	private bool IDEKMMEBDBI
	{
		[Cpp2IlInjected.Token(Token = "0x6000527")]
		[Cpp2IlInjected.Address(RVA = "0x6212F70", Offset = "0x6211770", VA = "0x186212F70")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000151")]
	public bool GFPPOAEOHBK
	{
		[Cpp2IlInjected.Token(Token = "0x600052A")]
		[Cpp2IlInjected.Address(RVA = "0xC1D140", Offset = "0xC1B940", VA = "0x180C1D140", Slot = "6")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000528")]
	[Cpp2IlInjected.Address(RVA = "0x6220340", Offset = "0x621EB40", VA = "0x186220340")]
	public IKAOJPHKPKL(ACNEEEENOML AHGOPBJOELE, [In] ACDBPOHPAKH AELCABDCBDD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000529")]
	[Cpp2IlInjected.Address(RVA = "0x621F3B0", Offset = "0x621DBB0", VA = "0x18621F3B0", Slot = "5")]
	public void BMFHLKIGOGD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600052B")]
	[Cpp2IlInjected.Address(RVA = "0x621FFB0", Offset = "0x621E7B0", VA = "0x18621FFB0", Slot = "7")]
	public void JBAEFNMGPHP(object KIAKEGJPMAL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600052C")]
	[Cpp2IlInjected.Address(RVA = "0x621FFE0", Offset = "0x621E7E0", VA = "0x18621FFE0", Slot = "8")]
	public void MODGFAKLIIP(object KIAKEGJPMAL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600052D")]
	[Cpp2IlInjected.Address(RVA = "0x6220010", Offset = "0x621E810", VA = "0x186220010", Slot = "9")]
	public void OJCMDDNBENE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600052E")]
	[Cpp2IlInjected.Address(RVA = "0x621F600", Offset = "0x621DE00", VA = "0x18621F600", Slot = "11")]
	public void DLHJKDHKDKC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600052F")]
	[Cpp2IlInjected.Address(RVA = "0x621FE30", Offset = "0x621E630", VA = "0x18621FE30", Slot = "12")]
	public void HPFPPKNCMIM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000530")]
	[Cpp2IlInjected.Address(RVA = "0x621F9A0", Offset = "0x621E1A0", VA = "0x18621F9A0", Slot = "10")]
	public void FGAAMJAJOOG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000531")]
	[Cpp2IlInjected.Address(RVA = "0x621F450", Offset = "0x621DC50", VA = "0x18621F450")]
	private void CCBJJALKHIO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000532")]
	[Cpp2IlInjected.Address(RVA = "0x621F7F0", Offset = "0x621DFF0", VA = "0x18621F7F0")]
	private void DNINDGODPJP()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200005B")]
internal sealed class BKIDONDLJNP : LGAMKIPMADE, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000B5")]
	private readonly ALHCFOHGNMD AHGOPBJOELE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000B6")]
	private readonly BOKOFNDFGJO CANEJCKKODK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000B7")]
	private float KDFFCAGNMFJ;

	[Cpp2IlInjected.Token(Token = "0x17000152")]
	public CPIKNIBKFKL GNLKAEJNEDB
	{
		[Cpp2IlInjected.Token(Token = "0x6000533")]
		[Cpp2IlInjected.Address(RVA = "0x765D00", Offset = "0x764500", VA = "0x180765D00", Slot = "4")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000534")]
		[Cpp2IlInjected.Address(RVA = "0x766120", Offset = "0x764920", VA = "0x180766120", Slot = "5")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000153")]
	public OKPICPJMDEO JKKMJBKLALO
	{
		[Cpp2IlInjected.Token(Token = "0x6000535")]
		[Cpp2IlInjected.Address(RVA = "0x76B5B0", Offset = "0x769DB0", VA = "0x18076B5B0", Slot = "6")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000536")]
		[Cpp2IlInjected.Address(RVA = "0x76BD00", Offset = "0x76A500", VA = "0x18076BD00", Slot = "7")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000154")]
	public Vector3 NBKAJOJDMMI
	{
		[Cpp2IlInjected.Token(Token = "0x6000537")]
		[Cpp2IlInjected.Address(RVA = "0x6236740", Offset = "0x6234F40", VA = "0x186236740", Slot = "8")]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x6000538")]
		[Cpp2IlInjected.Address(RVA = "0x6235A80", Offset = "0x6234280", VA = "0x186235A80", Slot = "9")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000155")]
	public Vector3 LAGBGBLAELJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000539")]
		[Cpp2IlInjected.Address(RVA = "0x62370C0", Offset = "0x62358C0", VA = "0x1862370C0", Slot = "10")]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x600053A")]
		[Cpp2IlInjected.Address(RVA = "0x6236630", Offset = "0x6234E30", VA = "0x186236630", Slot = "11")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000156")]
	public Vector3 POIAGHOEFEB
	{
		[Cpp2IlInjected.Token(Token = "0x600053B")]
		[Cpp2IlInjected.Address(RVA = "0x6234990", Offset = "0x6233190", VA = "0x186234990", Slot = "12")]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x600053C")]
		[Cpp2IlInjected.Address(RVA = "0x6235300", Offset = "0x6233B00", VA = "0x186235300", Slot = "13")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000157")]
	public Vector3 FFPCNDPLCPM
	{
		[Cpp2IlInjected.Token(Token = "0x600053D")]
		[Cpp2IlInjected.Address(RVA = "0x62371B0", Offset = "0x62359B0", VA = "0x1862371B0", Slot = "14")]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x600053E")]
		[Cpp2IlInjected.Address(RVA = "0x6235720", Offset = "0x6233F20", VA = "0x186235720", Slot = "15")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000158")]
	public float ICPKIGJHHCD
	{
		[Cpp2IlInjected.Token(Token = "0x600053F")]
		[Cpp2IlInjected.Address(RVA = "0x7B7860", Offset = "0x7B6060", VA = "0x1807B7860", Slot = "16")]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x6000540")]
		[Cpp2IlInjected.Address(RVA = "0x6234650", Offset = "0x6232E50", VA = "0x186234650", Slot = "17")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000159")]
	public bool KIEFCCGGPLM
	{
		[Cpp2IlInjected.Token(Token = "0x6000541")]
		[Cpp2IlInjected.Address(RVA = "0x158E060", Offset = "0x158C860", VA = "0x18158E060", Slot = "18")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700015A")]
	private AICDKPBPOFE BKGLDNDEEPH
	{
		[Cpp2IlInjected.Token(Token = "0x6000555")]
		[Cpp2IlInjected.Address(RVA = "0x1C13E70", Offset = "0x1C12670", VA = "0x181C13E70")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700015B")]
	private bool FAHPFCJEPJO
	{
		[Cpp2IlInjected.Token(Token = "0x6000556")]
		[Cpp2IlInjected.Address(RVA = "0x6224700", Offset = "0x6222F00", VA = "0x186224700")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000542")]
	[Cpp2IlInjected.Address(RVA = "0x6237640", Offset = "0x6235E40", VA = "0x186237640")]
	public BKIDONDLJNP(ACNEEEENOML AHGOPBJOELE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000543")]
	[Cpp2IlInjected.Address(RVA = "0x6234AB0", Offset = "0x62332B0", VA = "0x186234AB0", Slot = "19")]
	public void BMFHLKIGOGD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000544")]
	[Cpp2IlInjected.Address(RVA = "0x6235490", Offset = "0x6233C90", VA = "0x186235490", Slot = "36")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000545")]
	[Cpp2IlInjected.Address(RVA = "0x62353C0", Offset = "0x6233BC0", VA = "0x1862353C0", Slot = "28")]
	public void DOIABHKLMHG(Rigidbody JFKGLMKHADB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000546")]
	[Cpp2IlInjected.Address(RVA = "0xA2EDD0", Offset = "0xA2D5D0", VA = "0x180A2EDD0", Slot = "20")]
	public void BAFPOBKCHMD(object KIAKEGJPMAL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000547")]
	[Cpp2IlInjected.Address(RVA = "0xA2E510", Offset = "0xA2CD10", VA = "0x180A2E510", Slot = "30")]
	public void CNCFJMCKEII(object KIAKEGJPMAL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000548")]
	[Cpp2IlInjected.Address(RVA = "0x6235FD0", Offset = "0x62347D0", VA = "0x186235FD0", Slot = "35")]
	public Vector3 JOHAPINPNIG(Vector3 CPFDNDKFHHH)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000549")]
	[Cpp2IlInjected.Address(RVA = "0x6237410", Offset = "0x6235C10", VA = "0x186237410", Slot = "34")]
	public Vector3 OJGIMCLJCBO(Vector3 AMLAOHJLKAL)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x600054A")]
	[Cpp2IlInjected.Address(RVA = "0x6234AB0", Offset = "0x62332B0", VA = "0x186234AB0", Slot = "27")]
	public void HPICNCAEGKH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600054B")]
	[Cpp2IlInjected.Address(RVA = "0x6235560", Offset = "0x6233D60", VA = "0x186235560", Slot = "25")]
	public void ELAIKNOJDMF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600054C")]
	[Cpp2IlInjected.Address(RVA = "0x62358F0", Offset = "0x62340F0", VA = "0x1862358F0", Slot = "24")]
	public void GAIPCILJLMB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600054D")]
	[Cpp2IlInjected.Address(RVA = "0x6235750", Offset = "0x6233F50", VA = "0x186235750", Slot = "33")]
	public void FOPGOBMGCOM(Vector3 HDFIANGNHPD, Vector3 OPNLLPIFKNP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600054E")]
	[Cpp2IlInjected.Address(RVA = "0x6236CC0", Offset = "0x62354C0", VA = "0x186236CC0", Slot = "32")]
	public void MDMIGCOMJCF(Vector3 JPNLAOHAPPM, Vector3 CHFCHAFCOBM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600054F")]
	[Cpp2IlInjected.Address(RVA = "0x62372A0", Offset = "0x6235AA0", VA = "0x1862372A0", Slot = "31")]
	public void OGHMBOLGHFB(Vector3 FJNLGGLHPIL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000550")]
	[Cpp2IlInjected.Address(RVA = "0x6234B60", Offset = "0x6233360", VA = "0x186234B60", Slot = "22")]
	public void CCOMMPLBNFB(BPNODJIJBLA KADKJKFHDBE, Vector3 MCCPDDLJGEG, float EGMGOJMNMKL, float FLCBFAEIBEI = 8f, float MMINJAGEDBL = 1f)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000551")]
	[Cpp2IlInjected.Address(RVA = "0x6234700", Offset = "0x6232F00", VA = "0x186234700", Slot = "21")]
	public void AFAJHDMGFMF(LJGOMBGDPDM GJBGJOHBOBM, Vector3 GNFMGLELAKB, float JICJOBGCGOP = float.PositiveInfinity)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000552")]
	[Cpp2IlInjected.Address(RVA = "0x6236D20", Offset = "0x6235520", VA = "0x186236D20", Slot = "23")]
	[Obsolete("Deprecated. Still exists to support deprecated CV2 chips. Use ApplyAngularVelocityChange.")]
	public void MPMCBKEHDIK(LJGOMBGDPDM GJBGJOHBOBM, Vector3 OHMBDAJNEIJ, float GEPDJOHNEPN = 7f, float JINKMCECFKA = 1f)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000553")]
	[Cpp2IlInjected.Address(RVA = "0x62355C0", Offset = "0x6233DC0", VA = "0x1862355C0", Slot = "29")]
	public Vector3 EMEDMNCJCCM(Vector3 NOCGKJGODHL)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000554")]
	[Cpp2IlInjected.Address(RVA = "0x6235950", Offset = "0x6234150", VA = "0x186235950", Slot = "26")]
	public void JIMNECMIFKB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000557")]
	[Cpp2IlInjected.Address(RVA = "0x6234650", Offset = "0x6232E50", VA = "0x186234650")]
	private void ABMCLIFBNMI(float FKKGMPDEPMA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000558")]
	[Cpp2IlInjected.Address(RVA = "0x6235190", Offset = "0x6233990", VA = "0x186235190")]
	private void CIAJNBCJPIN(Vector3 GNFMGLELAKB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000559")]
	[Cpp2IlInjected.Address(RVA = "0x6236660", Offset = "0x6234E60", VA = "0x186236660")]
	private Vector3 LCGKOEAJLMA()
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x600055A")]
	[Cpp2IlInjected.Address(RVA = "0x6236860", Offset = "0x6235060", VA = "0x186236860")]
	private void MDANCAMHGHE(Vector3 AMLAOHJLKAL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600055B")]
	[Cpp2IlInjected.Address(RVA = "0x6237560", Offset = "0x6235D60", VA = "0x186237560")]
	private Vector3 OOGKEFBBBJM()
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x600055C")]
	[Cpp2IlInjected.Address(RVA = "0x62361F0", Offset = "0x62349F0", VA = "0x1862361F0")]
	private void KGNMMCGBPJC(Vector3 FKKGMPDEPMA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600055D")]
	[Cpp2IlInjected.Address(RVA = "0x6235B40", Offset = "0x6234340", VA = "0x186235B40")]
	private void JMPHAECMPDJ(Vector3 AMLAOHJLKAL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600055E")]
	[Cpp2IlInjected.Address(RVA = "0x6236140", Offset = "0x6234940", VA = "0x186236140")]
	private void KGMJDFGDNNO()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200005C")]
public class AJNIMCHCEBO : MIAHMAGCEAF
{
	[Cpp2IlInjected.Token(Token = "0x600055F")]
	[Cpp2IlInjected.Address(RVA = "0x6234520", Offset = "0x6232D20", VA = "0x186234520", Slot = "4")]
	public PMHIGDLAJOP LPHHNKPAPHN(ACNEEEENOML PCEPPDLMHCM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000560")]
	[Cpp2IlInjected.Address(RVA = "0x6233FA0", Offset = "0x62327A0", VA = "0x186233FA0", Slot = "5")]
	public LGAMKIPMADE DFLGBNMMLBE(ACNEEEENOML PCEPPDLMHCM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000561")]
	[Cpp2IlInjected.Address(RVA = "0x62342D0", Offset = "0x6232AD0", VA = "0x1862342D0", Slot = "6")]
	public LMDEEHLJMOK HBEJLKNNCLJ(ACNEEEENOML PCEPPDLMHCM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000562")]
	[Cpp2IlInjected.Address(RVA = "0x62340F0", Offset = "0x62328F0", VA = "0x1862340F0", Slot = "7")]
	public BMMIOFOJJEB ENNPPKGHEND(ACNEEEENOML PCEPPDLMHCM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000563")]
	[Cpp2IlInjected.Address(RVA = "0x6234580", Offset = "0x6232D80", VA = "0x186234580", Slot = "8")]
	public CCAMOPPOPEI NJJBCPEJOKJ(ACNEEEENOML PCEPPDLMHCM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000564")]
	[Cpp2IlInjected.Address(RVA = "0x6234400", Offset = "0x6232C00", VA = "0x186234400", Slot = "9")]
	public MCEBLIDMGME JEJILAFPABO(ACNEEEENOML PCEPPDLMHCM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000565")]
	[Cpp2IlInjected.Address(RVA = "0x6234330", Offset = "0x6232B30", VA = "0x186234330", Slot = "10")]
	public DMPEOOKGLDG HMGGCOHPDKE(ACNEEEENOML PCEPPDLMHCM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000566")]
	[Cpp2IlInjected.Address(RVA = "0x6234270", Offset = "0x6232A70", VA = "0x186234270", Slot = "11")]
	public AICDKPBPOFE GLEICABECAF(ACNEEEENOML PCEPPDLMHCM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000567")]
	[Cpp2IlInjected.Address(RVA = "0x62344C0", Offset = "0x6232CC0", VA = "0x1862344C0", Slot = "12")]
	public NDKMMOHJIND LLPJONABCKF(ACNEEEENOML PCEPPDLMHCM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000568")]
	[Cpp2IlInjected.Address(RVA = "0x6234460", Offset = "0x6232C60", VA = "0x186234460", Slot = "13")]
	public HEEAIGPCPDE KKCAOPGKIHB(ACNEEEENOML PCEPPDLMHCM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000569")]
	[Cpp2IlInjected.Address(RVA = "0x6233F30", Offset = "0x6232730", VA = "0x186233F30")]
	public JGMBKBLBJEA CLIDGNAHFEE(ACNEEEENOML PCEPPDLMHCM, [In] ACDBPOHPAKH AELCABDCBDD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600056A")]
	[Cpp2IlInjected.Address(RVA = "0x6234390", Offset = "0x6232B90", VA = "0x186234390")]
	public DCKAOPOPPEM IBAPHKBNBJH(ACNEEEENOML PCEPPDLMHCM, [In] ACDBPOHPAKH AELCABDCBDD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600056B")]
	[Cpp2IlInjected.Address(RVA = "0x6234080", Offset = "0x6232880", VA = "0x186234080")]
	public CFLOPMDOLBK EMOCJGFEGOK(ACNEEEENOML PCEPPDLMHCM, [In] ACDBPOHPAKH AELCABDCBDD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600056C")]
	[Cpp2IlInjected.Address(RVA = "0x6234200", Offset = "0x6232A00", VA = "0x186234200")]
	public KFKLGADFDEA GAKGMHFGJEP(ACNEEEENOML PCEPPDLMHCM, [In] ACDBPOHPAKH AELCABDCBDD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600056D")]
	[Cpp2IlInjected.Address(RVA = "0x62345E0", Offset = "0x6232DE0", VA = "0x1862345E0")]
	public GCEONIOPFOG ONLCELJFDGF(ACNEEEENOML PCEPPDLMHCM, [In] ACDBPOHPAKH AELCABDCBDD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600056E")]
	[Cpp2IlInjected.Address(RVA = "0x6234150", Offset = "0x6232950", VA = "0x186234150", Slot = "19")]
	public ACNEEEENOML GAFOKFHHMAF(RigidbodyEx AHGOPBJOELE, ACDBPOHPAKH AELCABDCBDD, HGMBJJHEAKJ PNFHHOFJABN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600056F")]
	[Cpp2IlInjected.Address(RVA = "0x76E470", Offset = "0x76CC70", VA = "0x18076E470")]
	public AJNIMCHCEBO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000570")]
	[Cpp2IlInjected.Address(RVA = "0x6233F30", Offset = "0x6232730", VA = "0x186233F30", Slot = "14")]
	private JGMBKBLBJEA JGBBLPMFDAA(ACNEEEENOML PCEPPDLMHCM, [In] ACDBPOHPAKH AELCABDCBDD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000571")]
	[Cpp2IlInjected.Address(RVA = "0x6234390", Offset = "0x6232B90", VA = "0x186234390", Slot = "15")]
	private DCKAOPOPPEM NBCJBJBBGJA(ACNEEEENOML PCEPPDLMHCM, [In] ACDBPOHPAKH AELCABDCBDD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000572")]
	[Cpp2IlInjected.Address(RVA = "0x6234080", Offset = "0x6232880", VA = "0x186234080", Slot = "16")]
	private CFLOPMDOLBK DIGHOBCMEPJ(ACNEEEENOML PCEPPDLMHCM, [In] ACDBPOHPAKH AELCABDCBDD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000573")]
	[Cpp2IlInjected.Address(RVA = "0x6234200", Offset = "0x6232A00", VA = "0x186234200", Slot = "17")]
	private KFKLGADFDEA PPCAJAAIJOO(ACNEEEENOML PCEPPDLMHCM, [In] ACDBPOHPAKH AELCABDCBDD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000574")]
	[Cpp2IlInjected.Address(RVA = "0x62345E0", Offset = "0x6232DE0", VA = "0x1862345E0", Slot = "18")]
	private GCEONIOPFOG ONEDKFJHFID(ACNEEEENOML PCEPPDLMHCM, [In] ACDBPOHPAKH AELCABDCBDD)
	{
		return null;
	}
}
namespace RRAssemblyIndex.RecRoom.Rbex.Runtime
{
	[Cpp2IlInjected.Token(Token = "0x200005D")]
	[global::RecRoom.CodeGen.Attributes.Preserve]
	internal class _RRAssemblyIndex : DPPANEPAGBC
	{
		[Cpp2IlInjected.Token(Token = "0x6000575")]
		[Cpp2IlInjected.Address(RVA = "0x78CB70", Offset = "0x78B370", VA = "0x18078CB70")]
		[global::RecRoom.CodeGen.Attributes.Preserve]
		public _RRAssemblyIndex()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000576")]
		[Cpp2IlInjected.Address(RVA = "0x62376E0", Offset = "0x6235EE0", VA = "0x1862376E0", Slot = "6")]
		public sealed override void KOKMPMBBHDI(MAMGJDJIBCG ABCKGGDLEKO)
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
