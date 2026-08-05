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
public delegate void LNNBFANOADD(RigidbodyEx DEFGCFICOOP);
[Cpp2IlInjected.Token(Token = "0x2000003")]
public delegate void OKIHMFHNBGG(RigidbodyEx DEFGCFICOOP, bool ABHJANDGLGK = false);
[Cpp2IlInjected.Token(Token = "0x2000004")]
public enum KOJCHCLAHNC
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
public enum PHBNBKDBFOC
{
	[Cpp2IlInjected.Token(Token = "0x4000007")]
	OnlyForReducedPhysicsRateAndNotParenting,
	[Cpp2IlInjected.Token(Token = "0x4000008")]
	Never,
	[Cpp2IlInjected.Token(Token = "0x4000009")]
	OnEvenWhenParenting
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public enum NILPLAGMMGI
{
	[Cpp2IlInjected.Token(Token = "0x400000B")]
	Additive,
	[Cpp2IlInjected.Token(Token = "0x400000C")]
	Override,
	[Cpp2IlInjected.Token(Token = "0x400000D")]
	Reflective
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
[PNAJALIKCOM(typeof(JJFGCNEJLAC), new string[] { "Ignore", "Mock" })]
public class EJFGMAGBGOC : JJFGCNEJLAC
{
	[Cpp2IlInjected.Token(Token = "0x17000001")]
	public bool FGCAICKGKKG
	{
		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x7AEE20", Offset = "0x7AE220", VA = "0x1807AEE20", Slot = "4")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0x75E5B0", Offset = "0x75D9B0", VA = "0x18075E5B0", Slot = "5")]
	public void EMKLCIACEDC(string GHNPOMJGELJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x75E5B0", Offset = "0x75D9B0", VA = "0x18075E5B0", Slot = "6")]
	public void ECENADFPANM(RigidbodyEx GOCPNHJEOMK, Action GMCEKENFDDF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x75E5C0", Offset = "0x75D9C0", VA = "0x18075E5C0", Slot = "7")]
	public ADPDPCABPGF NMAAJKCJHCO(int GAMEIOIKOGN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x75E5B0", Offset = "0x75D9B0", VA = "0x18075E5B0", Slot = "8")]
	public void INEOBCPPMIL(Vector3 IBDKNACJALI, float APBCPDOCONE, Color DJDNAMFLFCL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x76C4B0", Offset = "0x76B8B0", VA = "0x18076C4B0")]
	public EJFGMAGBGOC()
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
		private static readonly FBKCBHAMJJJ DGGLNHJAFNP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000010")]
		private bool KBLKGMPKPGA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000011")]
		private MGCGGKFMJCL CHFMKNBCPND;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000012")]
		[SerializeField]
		[IEEEBECMKEA(DGGKPPHNIIC.Self, false, false, false)]
		private Rigidbody unityRigidbody;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000013")]
		[IEEEBECMKEA(DGGKPPHNIIC.SelfAndParent, true, false, false)]
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
		[FormerlySerializedAs("forceNoInterpolation")]
		[SerializeField]
		private PHBNBKDBFOC physicsInterpolation;

		[Cpp2IlInjected.FieldOffset(Offset = "0x5C")]
		[Cpp2IlInjected.Token(Token = "0x4000017")]
		[SerializeField]
		[Tooltip("If checked, this object's Unity Rigidbody will not be stripped when parenting the object to another RigidbodyEx. Only check this on objects that have a Unity Rigidbody by default and who need access to Unity physics events like OnTriggerEnter, OnCollisionEnter, etc. This is sometimes set via script instead of this flag.")]
		private bool keepUnityRigidbodyWhileParented;

		[Cpp2IlInjected.FieldOffset(Offset = "0x5D")]
		[Cpp2IlInjected.Token(Token = "0x4000018")]
		[SerializeField]
		[Tooltip("If the RigidbodyEx has a parent that is being destroyed, this flag allows this RigidbodyEx to keep the parent set. The default behavior is thatthe parent property is set to null, resetting/clearing the existing parent when it is being destroyed.")]
		private bool keepParentOnParentDestroy;

		[Cpp2IlInjected.FieldOffset(Offset = "0x5E")]
		[Cpp2IlInjected.Token(Token = "0x4000019")]
		[HideInInspector]
		[SerializeField]
		private bool hasUnityRigidbodyByDefault;

		[Cpp2IlInjected.Token(Token = "0x17000002")]
		internal MGCGGKFMJCL GHKHAMLBHKF
		{
			[Cpp2IlInjected.Token(Token = "0x600000B")]
			[Cpp2IlInjected.Address(RVA = "0x61E5680", Offset = "0x61E4A80", VA = "0x1861E5680")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000003")]
		public IReadOnlyList<RigidbodyEx> APDMNNGBLFI
		{
			[Cpp2IlInjected.Token(Token = "0x6000021")]
			[Cpp2IlInjected.Address(RVA = "0x7610A0", Offset = "0x7604A0", VA = "0x1807610A0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000022")]
			[Cpp2IlInjected.Address(RVA = "0x761110", Offset = "0x760510", VA = "0x180761110")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000004")]
		public RigidbodyEx LDJFLFBDCLN
		{
			[Cpp2IlInjected.Token(Token = "0x6000023")]
			[Cpp2IlInjected.Address(RVA = "0x61E7290", Offset = "0x61E6690", VA = "0x1861E7290")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000005")]
		public RigidbodyEx DFDPGOHHPEM
		{
			[Cpp2IlInjected.Token(Token = "0x6000024")]
			[Cpp2IlInjected.Address(RVA = "0x61E71F0", Offset = "0x61E65F0", VA = "0x1861E71F0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000006")]
		public RigidbodyEx EBFCMPBKGBM
		{
			[Cpp2IlInjected.Token(Token = "0x6000025")]
			[Cpp2IlInjected.Address(RVA = "0x61E7EB0", Offset = "0x61E72B0", VA = "0x1861E7EB0")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000026")]
			[Cpp2IlInjected.Address(RVA = "0x61E9430", Offset = "0x61E8830", VA = "0x1861E9430")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000007")]
		public Transform JKIKKGOIIBC
		{
			[Cpp2IlInjected.Token(Token = "0x6000027")]
			[Cpp2IlInjected.Address(RVA = "0x786D90", Offset = "0x786190", VA = "0x180786D90")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000008")]
		public Transform OEBHBPDHFHA
		{
			[Cpp2IlInjected.Token(Token = "0x6000028")]
			[Cpp2IlInjected.Address(RVA = "0x786D90", Offset = "0x786190", VA = "0x180786D90")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000009")]
		public BFDBALLDKAM IJNJIINAHIE
		{
			[Cpp2IlInjected.Token(Token = "0x6000029")]
			[Cpp2IlInjected.Address(RVA = "0x61E6FB0", Offset = "0x61E63B0", VA = "0x1861E6FB0")]
			get
			{
				return default(BFDBALLDKAM);
			}
			[Cpp2IlInjected.Token(Token = "0x600002A")]
			[Cpp2IlInjected.Address(RVA = "0x61E8BE0", Offset = "0x61E7FE0", VA = "0x1861E8BE0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000A")]
		public bool FFIFGPLINHH
		{
			[Cpp2IlInjected.Token(Token = "0x600002B")]
			[Cpp2IlInjected.Address(RVA = "0x61E7540", Offset = "0x61E6940", VA = "0x1861E7540")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000B")]
		public bool HAEGEFIPLPF
		{
			[Cpp2IlInjected.Token(Token = "0x600002C")]
			[Cpp2IlInjected.Address(RVA = "0x61E70D0", Offset = "0x61E64D0", VA = "0x1861E70D0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000C")]
		public JOOBEENEBAA KIPEILJOHEE
		{
			[Cpp2IlInjected.Token(Token = "0x600002D")]
			[Cpp2IlInjected.Address(RVA = "0x61E7480", Offset = "0x61E6880", VA = "0x1861E7480")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600002E")]
			[Cpp2IlInjected.Address(RVA = "0x61E8DA0", Offset = "0x61E81A0", VA = "0x1861E8DA0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000D")]
		public GKFPHOCIOLD BCAAPMKBHAM
		{
			[Cpp2IlInjected.Token(Token = "0x600002F")]
			[Cpp2IlInjected.Address(RVA = "0x61E7420", Offset = "0x61E6820", VA = "0x1861E7420")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000030")]
			[Cpp2IlInjected.Address(RVA = "0x61E8D30", Offset = "0x61E8130", VA = "0x1861E8D30")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000E")]
		public bool NCFBIAMPAHJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000031")]
			[Cpp2IlInjected.Address(RVA = "0x61E7370", Offset = "0x61E6770", VA = "0x1861E7370")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000F")]
		public Rigidbody ACNJBLDPNFK
		{
			[Cpp2IlInjected.Token(Token = "0x6000032")]
			[Cpp2IlInjected.Address(RVA = "0x61E73D0", Offset = "0x61E67D0", VA = "0x1861E73D0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000010")]
		public bool PBOGKFDNBGB
		{
			[Cpp2IlInjected.Token(Token = "0x6000033")]
			[Cpp2IlInjected.Address(RVA = "0x61E7130", Offset = "0x61E6530", VA = "0x1861E7130")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000034")]
			[Cpp2IlInjected.Address(RVA = "0x61E8C50", Offset = "0x61E8050", VA = "0x1861E8C50")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000011")]
		public bool LFBFBEGAIBD
		{
			[Cpp2IlInjected.Token(Token = "0x6000035")]
			[Cpp2IlInjected.Address(RVA = "0x1A537B0", Offset = "0x1A52BB0", VA = "0x181A537B0")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000036")]
			[Cpp2IlInjected.Address(RVA = "0x5A72D70", Offset = "0x5A72170", VA = "0x185A72D70")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000012")]
		public float EIEGGECHILO
		{
			[Cpp2IlInjected.Token(Token = "0x6000037")]
			[Cpp2IlInjected.Address(RVA = "0x61E7E50", Offset = "0x61E7250", VA = "0x1861E7E50")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000013")]
		public float HHMIADFKJAI
		{
			[Cpp2IlInjected.Token(Token = "0x6000038")]
			[Cpp2IlInjected.Address(RVA = "0x61E7DF0", Offset = "0x61E71F0", VA = "0x1861E7DF0")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x6000039")]
			[Cpp2IlInjected.Address(RVA = "0x61E93C0", Offset = "0x61E87C0", VA = "0x1861E93C0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000014")]
		public float MAGMOODPFMF
		{
			[Cpp2IlInjected.Token(Token = "0x600003A")]
			[Cpp2IlInjected.Address(RVA = "0x61E77A0", Offset = "0x61E6BA0", VA = "0x1861E77A0")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x600003B")]
			[Cpp2IlInjected.Address(RVA = "0x61E9040", Offset = "0x61E8440", VA = "0x1861E9040")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000015")]
		public float GNFCIEFCAMO
		{
			[Cpp2IlInjected.Token(Token = "0x600003C")]
			[Cpp2IlInjected.Address(RVA = "0x61E75A0", Offset = "0x61E69A0", VA = "0x1861E75A0")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x600003D")]
			[Cpp2IlInjected.Address(RVA = "0x61E8E10", Offset = "0x61E8210", VA = "0x1861E8E10")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000016")]
		public bool IOHHCAGIIOM
		{
			[Cpp2IlInjected.Token(Token = "0x600003E")]
			[Cpp2IlInjected.Address(RVA = "0x61E8410", Offset = "0x61E7810", VA = "0x1861E8410")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x600003F")]
			[Cpp2IlInjected.Address(RVA = "0x61E9990", Offset = "0x61E8D90", VA = "0x1861E9990")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000017")]
		public Vector3 LPPFPBKJMOB
		{
			[Cpp2IlInjected.Token(Token = "0x6000040")]
			[Cpp2IlInjected.Address(RVA = "0x61E7BD0", Offset = "0x61E6FD0", VA = "0x1861E7BD0")]
			get
			{
				return default(Vector3);
			}
			[Cpp2IlInjected.Token(Token = "0x6000041")]
			[Cpp2IlInjected.Address(RVA = "0x61E9190", Offset = "0x61E8590", VA = "0x1861E9190")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000018")]
		public Vector3 IBDKNACJALI
		{
			[Cpp2IlInjected.Token(Token = "0x6000042")]
			[Cpp2IlInjected.Address(RVA = "0x61E8550", Offset = "0x61E7950", VA = "0x1861E8550")]
			get
			{
				return default(Vector3);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000019")]
		public CollisionDetectionMode BJLCOFCALKF
		{
			[Cpp2IlInjected.Token(Token = "0x6000043")]
			[Cpp2IlInjected.Address(RVA = "0x61E76E0", Offset = "0x61E6AE0", VA = "0x1861E76E0")]
			get
			{
				return default(CollisionDetectionMode);
			}
			[Cpp2IlInjected.Token(Token = "0x6000044")]
			[Cpp2IlInjected.Address(RVA = "0x61E8F60", Offset = "0x61E8360", VA = "0x1861E8F60")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001A")]
		public float IMFCIBCJLIP
		{
			[Cpp2IlInjected.Token(Token = "0x6000045")]
			[Cpp2IlInjected.Address(RVA = "0x61E7190", Offset = "0x61E6590", VA = "0x1861E7190")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x6000046")]
			[Cpp2IlInjected.Address(RVA = "0x61E8CC0", Offset = "0x61E80C0", VA = "0x1861E8CC0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001B")]
		public RigidbodyConstraints GKGKDAIJEED
		{
			[Cpp2IlInjected.Token(Token = "0x6000047")]
			[Cpp2IlInjected.Address(RVA = "0x61E7740", Offset = "0x61E6B40", VA = "0x1861E7740")]
			get
			{
				return default(RigidbodyConstraints);
			}
			[Cpp2IlInjected.Token(Token = "0x6000048")]
			[Cpp2IlInjected.Address(RVA = "0x61E8FD0", Offset = "0x61E83D0", VA = "0x1861E8FD0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001C")]
		public Vector3 POMFGAHLIPB
		{
			[Cpp2IlInjected.Token(Token = "0x6000049")]
			[Cpp2IlInjected.Address(RVA = "0x61E7F50", Offset = "0x61E7350", VA = "0x1861E7F50")]
			get
			{
				return default(Vector3);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001D")]
		public Vector3 MFLGKCPKBAD
		{
			[Cpp2IlInjected.Token(Token = "0x600004A")]
			[Cpp2IlInjected.Address(RVA = "0x61E7F50", Offset = "0x61E7350", VA = "0x1861E7F50")]
			get
			{
				return default(Vector3);
			}
			[Cpp2IlInjected.Token(Token = "0x600004B")]
			[Cpp2IlInjected.Address(RVA = "0x61E9770", Offset = "0x61E8B70", VA = "0x1861E9770")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001E")]
		public float BKLOJAMMHDA
		{
			[Cpp2IlInjected.Token(Token = "0x600004C")]
			[Cpp2IlInjected.Address(RVA = "0x61E7CB0", Offset = "0x61E70B0", VA = "0x1861E7CB0")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x600004D")]
			[Cpp2IlInjected.Address(RVA = "0x61E9270", Offset = "0x61E8670", VA = "0x1861E9270")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001F")]
		public float PKKGDPGICDJ
		{
			[Cpp2IlInjected.Token(Token = "0x600004E")]
			[Cpp2IlInjected.Address(RVA = "0x61E83B0", Offset = "0x61E77B0", VA = "0x1861E83B0")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x600004F")]
			[Cpp2IlInjected.Address(RVA = "0x61E9920", Offset = "0x61E8D20", VA = "0x1861E9920")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000020")]
		public Quaternion OFBEPGLOEAK
		{
			[Cpp2IlInjected.Token(Token = "0x6000050")]
			[Cpp2IlInjected.Address(RVA = "0x61E8030", Offset = "0x61E7430", VA = "0x1861E8030")]
			get
			{
				return default(Quaternion);
			}
			[Cpp2IlInjected.Token(Token = "0x6000051")]
			[Cpp2IlInjected.Address(RVA = "0x61E94F0", Offset = "0x61E88F0", VA = "0x1861E94F0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000021")]
		public Quaternion FMBPKINDPKK
		{
			[Cpp2IlInjected.Token(Token = "0x6000052")]
			[Cpp2IlInjected.Address(RVA = "0x61E82D0", Offset = "0x61E76D0", VA = "0x1861E82D0")]
			get
			{
				return default(Quaternion);
			}
			[Cpp2IlInjected.Token(Token = "0x6000053")]
			[Cpp2IlInjected.Address(RVA = "0x61E9850", Offset = "0x61E8C50", VA = "0x1861E9850")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000022")]
		public Vector3 HAOLNFLOJKD
		{
			[Cpp2IlInjected.Token(Token = "0x6000054")]
			[Cpp2IlInjected.Address(RVA = "0x61E8110", Offset = "0x61E7510", VA = "0x1861E8110")]
			get
			{
				return default(Vector3);
			}
			[Cpp2IlInjected.Token(Token = "0x6000055")]
			[Cpp2IlInjected.Address(RVA = "0x61E95C0", Offset = "0x61E89C0", VA = "0x1861E95C0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000023")]
		public Quaternion MBJAJINGJON
		{
			[Cpp2IlInjected.Token(Token = "0x6000056")]
			[Cpp2IlInjected.Address(RVA = "0x61E81F0", Offset = "0x61E75F0", VA = "0x1861E81F0")]
			get
			{
				return default(Quaternion);
			}
			[Cpp2IlInjected.Token(Token = "0x6000057")]
			[Cpp2IlInjected.Address(RVA = "0x61E96A0", Offset = "0x61E8AA0", VA = "0x1861E96A0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000024")]
		public Vector3 GKMPFMKFGID
		{
			[Cpp2IlInjected.Token(Token = "0x6000058")]
			[Cpp2IlInjected.Address(RVA = "0x61E8470", Offset = "0x61E7870", VA = "0x1861E8470")]
			get
			{
				return default(Vector3);
			}
			[Cpp2IlInjected.Token(Token = "0x6000059")]
			[Cpp2IlInjected.Address(RVA = "0x61E9A00", Offset = "0x61E8E00", VA = "0x1861E9A00")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000025")]
		public Vector3 EKHMFCCFGPL
		{
			[Cpp2IlInjected.Token(Token = "0x600005A")]
			[Cpp2IlInjected.Address(RVA = "0x61E7D10", Offset = "0x61E7110", VA = "0x1861E7D10")]
			get
			{
				return default(Vector3);
			}
			[Cpp2IlInjected.Token(Token = "0x600005B")]
			[Cpp2IlInjected.Address(RVA = "0x61E92E0", Offset = "0x61E86E0", VA = "0x1861E92E0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000026")]
		public Vector3 BADJPOOCLHC
		{
			[Cpp2IlInjected.Token(Token = "0x600005C")]
			[Cpp2IlInjected.Address(RVA = "0x61E7600", Offset = "0x61E6A00", VA = "0x1861E7600")]
			get
			{
				return default(Vector3);
			}
			[Cpp2IlInjected.Token(Token = "0x600005D")]
			[Cpp2IlInjected.Address(RVA = "0x61E8E80", Offset = "0x61E8280", VA = "0x1861E8E80")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000027")]
		public Vector3 EFIALDMFCNH
		{
			[Cpp2IlInjected.Token(Token = "0x600005E")]
			[Cpp2IlInjected.Address(RVA = "0x61E7AF0", Offset = "0x61E6EF0", VA = "0x1861E7AF0")]
			get
			{
				return default(Vector3);
			}
			[Cpp2IlInjected.Token(Token = "0x600005F")]
			[Cpp2IlInjected.Address(RVA = "0x61E90B0", Offset = "0x61E84B0", VA = "0x1861E90B0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000028")]
		public Vector3 KOCDIBFJMBC
		{
			[Cpp2IlInjected.Token(Token = "0x6000060")]
			[Cpp2IlInjected.Address(RVA = "0x61E79B0", Offset = "0x61E6DB0", VA = "0x1861E79B0")]
			get
			{
				return default(Vector3);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000029")]
		public Quaternion IFLJBMOEDHG
		{
			[Cpp2IlInjected.Token(Token = "0x6000061")]
			[Cpp2IlInjected.Address(RVA = "0x61E78D0", Offset = "0x61E6CD0", VA = "0x1861E78D0")]
			get
			{
				return default(Quaternion);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002A")]
		public Vector3 CJLGBIDILFH
		{
			[Cpp2IlInjected.Token(Token = "0x6000063")]
			[Cpp2IlInjected.Address(RVA = "0x61E8710", Offset = "0x61E7B10", VA = "0x1861E8710")]
			get
			{
				return default(Vector3);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002B")]
		public Vector3 ENCDFKLEHBH
		{
			[Cpp2IlInjected.Token(Token = "0x6000064")]
			[Cpp2IlInjected.Address(RVA = "0x61E8630", Offset = "0x61E7A30", VA = "0x1861E8630")]
			get
			{
				return default(Vector3);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002C")]
		public bool EDKKJDCOKAE
		{
			[Cpp2IlInjected.Token(Token = "0x6000065")]
			[Cpp2IlInjected.Address(RVA = "0x61E7A90", Offset = "0x61E6E90", VA = "0x1861E7A90")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002D")]
		public bool CBOGMEEBBPL
		{
			[Cpp2IlInjected.Token(Token = "0x6000066")]
			[Cpp2IlInjected.Address(RVA = "0x61E74E0", Offset = "0x61E68E0", VA = "0x1861E74E0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002E")]
		public bool GKKLJMOMONP
		{
			[Cpp2IlInjected.Token(Token = "0x6000067")]
			[Cpp2IlInjected.Address(RVA = "0x61E7070", Offset = "0x61E6470", VA = "0x1861E7070")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002F")]
		public bool GOJPGPEEJCL
		{
			[Cpp2IlInjected.Token(Token = "0x6000068")]
			[Cpp2IlInjected.Address(RVA = "0x61E7010", Offset = "0x61E6410", VA = "0x1861E7010")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000030")]
		public bool NLCHEOGPMJH
		{
			[Cpp2IlInjected.Token(Token = "0x6000069")]
			[Cpp2IlInjected.Address(RVA = "0x61E6F50", Offset = "0x61E6350", VA = "0x1861E6F50")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000031")]
		public bool EIFKDOLMIHE
		{
			[Cpp2IlInjected.Token(Token = "0x600006A")]
			[Cpp2IlInjected.Address(RVA = "0x61E7800", Offset = "0x61E6C00", VA = "0x1861E7800")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000032")]
		public bool MDIKGCAGGPK
		{
			[Cpp2IlInjected.Token(Token = "0x600006B")]
			[Cpp2IlInjected.Address(RVA = "0x4E423F0", Offset = "0x4E417F0", VA = "0x184E423F0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000001")]
		public event LNNBFANOADD HNGPHCCHJIB
		{
			[Cpp2IlInjected.Token(Token = "0x600000F")]
			[Cpp2IlInjected.Address(RVA = "0x61E6E70", Offset = "0x61E6270", VA = "0x1861E6E70")]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000010")]
			[Cpp2IlInjected.Address(RVA = "0x61E8B00", Offset = "0x61E7F00", VA = "0x1861E8B00")]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000002")]
		public event OKIHMFHNBGG KMNHBIFCIMB
		{
			[Cpp2IlInjected.Token(Token = "0x6000011")]
			[Cpp2IlInjected.Address(RVA = "0x61E6E00", Offset = "0x61E6200", VA = "0x1861E6E00")]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000012")]
			[Cpp2IlInjected.Address(RVA = "0x61E8A90", Offset = "0x61E7E90", VA = "0x1861E8A90")]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000003")]
		public event LNNBFANOADD ELBIILPLBLJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000013")]
			[Cpp2IlInjected.Address(RVA = "0x61E6B60", Offset = "0x61E5F60", VA = "0x1861E6B60")]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000014")]
			[Cpp2IlInjected.Address(RVA = "0x61E87F0", Offset = "0x61E7BF0", VA = "0x1861E87F0")]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000004")]
		public event LNNBFANOADD CBNGEFCLMOB
		{
			[Cpp2IlInjected.Token(Token = "0x6000015")]
			[Cpp2IlInjected.Address(RVA = "0x61E6BD0", Offset = "0x61E5FD0", VA = "0x1861E6BD0")]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000016")]
			[Cpp2IlInjected.Address(RVA = "0x61E8860", Offset = "0x61E7C60", VA = "0x1861E8860")]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000005")]
		public event LNNBFANOADD LCEOKOPJBNC
		{
			[Cpp2IlInjected.Token(Token = "0x6000017")]
			[Cpp2IlInjected.Address(RVA = "0x61E6D20", Offset = "0x61E6120", VA = "0x1861E6D20")]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000018")]
			[Cpp2IlInjected.Address(RVA = "0x61E89B0", Offset = "0x61E7DB0", VA = "0x1861E89B0")]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000006")]
		public event Action<ADKLLFONPNJ, ADKLLFONPNJ> IEAAAMEAGPG
		{
			[Cpp2IlInjected.Token(Token = "0x6000019")]
			[Cpp2IlInjected.Address(RVA = "0x61E6CB0", Offset = "0x61E60B0", VA = "0x1861E6CB0")]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x600001A")]
			[Cpp2IlInjected.Address(RVA = "0x61E8940", Offset = "0x61E7D40", VA = "0x1861E8940")]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000007")]
		public event LNNBFANOADD DHLAAGBNFOO
		{
			[Cpp2IlInjected.Token(Token = "0x600001B")]
			[Cpp2IlInjected.Address(RVA = "0x61E6D90", Offset = "0x61E6190", VA = "0x1861E6D90")]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x600001C")]
			[Cpp2IlInjected.Address(RVA = "0x61E8A20", Offset = "0x61E7E20", VA = "0x1861E8A20")]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000008")]
		public event LNNBFANOADD FDGIFPDCGEI
		{
			[Cpp2IlInjected.Token(Token = "0x600001D")]
			[Cpp2IlInjected.Address(RVA = "0x61E6EE0", Offset = "0x61E62E0", VA = "0x1861E6EE0")]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x600001E")]
			[Cpp2IlInjected.Address(RVA = "0x61E8B70", Offset = "0x61E7F70", VA = "0x1861E8B70")]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000009")]
		public event LNNBFANOADD OKPCAHNBDOG
		{
			[Cpp2IlInjected.Token(Token = "0x600001F")]
			[Cpp2IlInjected.Address(RVA = "0x61E6C40", Offset = "0x61E6040", VA = "0x1861E6C40")]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000020")]
			[Cpp2IlInjected.Address(RVA = "0x61E88D0", Offset = "0x61E7CD0", VA = "0x1861E88D0")]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x760A90", Offset = "0x75FE90", VA = "0x180760A90")]
		internal void GJPIDKBNLML(MGCGGKFMJCL MPPIIABEOMK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x61E58A0", Offset = "0x61E4CA0", VA = "0x1861E58A0")]
		internal void NOOJINJDBFO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x61E6880", Offset = "0x61E5C80", VA = "0x1861E6880")]
		[Conditional("DEBUG_BUILD")]
		[Conditional("UNITY_EDITOR")]
		public void TestOverrideUnityRigidbody(Rigidbody AGBFHFNMOFE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000062")]
		[Cpp2IlInjected.Address(RVA = "0x61E6550", Offset = "0x61E5950", VA = "0x1861E6550")]
		public void SetInertiaTensor((Quaternion rot, Vector3 moments) NCNIHGBNECM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006C")]
		[Cpp2IlInjected.Address(RVA = "0x61E4F90", Offset = "0x61E4390", VA = "0x1861E4F90")]
		private void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006D")]
		[Cpp2IlInjected.Address(RVA = "0x61E5680", Offset = "0x61E4A80", VA = "0x1861E5680")]
		private MGCGGKFMJCL JDGNCPEKLEA()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600006E")]
		[Cpp2IlInjected.Address(RVA = "0x61E5A50", Offset = "0x61E4E50", VA = "0x1861E5A50")]
		private void PICNJLOMOKL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006F")]
		[Cpp2IlInjected.Address(RVA = "0x61E5990", Offset = "0x61E4D90", VA = "0x1861E5990")]
		private void OnEnable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000070")]
		[Cpp2IlInjected.Address(RVA = "0x75E5B0", Offset = "0x75D9B0", VA = "0x18075E5B0")]
		public void OnDisable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000071")]
		[Cpp2IlInjected.Address(RVA = "0x61E58A0", Offset = "0x61E4CA0", VA = "0x1861E58A0")]
		private void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000072")]
		[Cpp2IlInjected.Address(RVA = "0x61E5930", Offset = "0x61E4D30", VA = "0x1861E5930")]
		private void OnDrawGizmosSelected()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000073")]
		[Cpp2IlInjected.Address(RVA = "0x61E59F0", Offset = "0x61E4DF0", VA = "0x1861E59F0")]
		private void OnValidate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000074")]
		[Cpp2IlInjected.Address(RVA = "0x61E4640", Offset = "0x61E3A40", VA = "0x1861E4640")]
		public void AddDoNotResetVelocityOnOwnershipChangeOverride(object KJAGMGIFCEM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000075")]
		[Cpp2IlInjected.Address(RVA = "0x61E5DE0", Offset = "0x61E51E0", VA = "0x1861E5DE0")]
		public void RemoveDoNotResetVelocityOnOwnershipChangeOverride(object KJAGMGIFCEM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000076")]
		[Cpp2IlInjected.Address(RVA = "0x61E51E0", Offset = "0x61E45E0", VA = "0x1861E51E0")]
		public void DisableCachedInertialPropertyOverride()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000077")]
		[Cpp2IlInjected.Address(RVA = "0x61E5840", Offset = "0x61E4C40", VA = "0x1861E5840")]
		public void MarkCachedInertialParametersDirty()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000078")]
		[Cpp2IlInjected.Address(RVA = "0x61E66B0", Offset = "0x61E5AB0", VA = "0x1861E66B0")]
		public void SetParent(RigidbodyEx EOHMJBFGDPD, bool ABHJANDGLGK = false)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000079")]
		[Cpp2IlInjected.Address(RVA = "0x61E60F0", Offset = "0x61E54F0", VA = "0x1861E60F0")]
		public void ResetLocalCenterOfMassToPrefabDefault()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007A")]
		[Cpp2IlInjected.Address(RVA = "0x61E5460", Offset = "0x61E4860", VA = "0x1861E5460")]
		public bool IsRigidbodyAncestor(RigidbodyEx GHGIFLPNPKP)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600007B")]
		[Cpp2IlInjected.Address(RVA = "0x61E5540", Offset = "0x61E4940", VA = "0x1861E5540")]
		public bool IsRigidbodyDescendant(RigidbodyEx FLFMJFFANNH)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600007C")]
		[Cpp2IlInjected.Address(RVA = "0x61E48B0", Offset = "0x61E3CB0", VA = "0x1861E48B0")]
		public void AddInterpolationRestriction(object KJAGMGIFCEM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007D")]
		[Cpp2IlInjected.Address(RVA = "0x61E5E50", Offset = "0x61E5250", VA = "0x1861E5E50")]
		public void RemoveInterpolationRestriction(object KJAGMGIFCEM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007E")]
		[Cpp2IlInjected.Address(RVA = "0x61E5000", Offset = "0x61E4400", VA = "0x1861E5000")]
		public IDisposable BeginKinematicScope()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600007F")]
		[Cpp2IlInjected.Address(RVA = "0x61E4920", Offset = "0x61E3D20", VA = "0x1861E4920")]
		public void AddKinematic(object KJAGMGIFCEM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000080")]
		[Cpp2IlInjected.Address(RVA = "0x61E5EC0", Offset = "0x61E52C0", VA = "0x1861E5EC0")]
		public void RemoveKinematic(object KJAGMGIFCEM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000081")]
		[Cpp2IlInjected.Address(RVA = "0x61E6630", Offset = "0x61E5A30", VA = "0x1861E6630")]
		public void SetKinematic(object KJAGMGIFCEM, bool LLALDMDCIAM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000082")]
		[Cpp2IlInjected.Address(RVA = "0x61E6450", Offset = "0x61E5850", VA = "0x1861E6450")]
		public void SetDiscontinuousPositionAndRotation(Vector3 NDJBAGILJCL, Quaternion EJDCLAMMOJM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000083")]
		[Cpp2IlInjected.Address(RVA = "0x61E6350", Offset = "0x61E5750", VA = "0x1861E6350")]
		public void SetDiscontinuousLocalPositionAndLocalRotation(Vector3 GLJADFPJOGM, Quaternion FHGOIAIOLGI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000084")]
		[Cpp2IlInjected.Address(RVA = "0x61E5350", Offset = "0x61E4750", VA = "0x1861E5350")]
		public Vector3 GetConstrainedVelocity(Vector3 GKMPFMKFGID)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x6000085")]
		[Cpp2IlInjected.Address(RVA = "0x61E5240", Offset = "0x61E4640", VA = "0x1861E5240")]
		public Vector3 GetConstrainedAngularVelocity(Vector3 BADJPOOCLHC)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x6000086")]
		[Cpp2IlInjected.Address(RVA = "0x61E47C0", Offset = "0x61E3BC0", VA = "0x1861E47C0")]
		public void AddForce(Vector3 EFLODOEECNL, ForceMode ECLMBFBBBLC = ForceMode.Force)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000087")]
		[Cpp2IlInjected.Address(RVA = "0x61E46B0", Offset = "0x61E3AB0", VA = "0x1861E46B0")]
		public void AddForceAtPosition(Vector3 EFLODOEECNL, Vector3 LPAPEIIOLFG, ForceMode ECLMBFBBBLC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000088")]
		[Cpp2IlInjected.Address(RVA = "0x61E4AF0", Offset = "0x61E3EF0", VA = "0x1861E4AF0")]
		public void AddTorque(Vector3 DMFFEFOAKAN, ForceMode ECLMBFBBBLC = ForceMode.Force)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000089")]
		[Cpp2IlInjected.Address(RVA = "0x61E4990", Offset = "0x61E3D90", VA = "0x1861E4990")]
		public void AddRelativeTorque(Vector3 DMFFEFOAKAN, ForceMode ECLMBFBBBLC = ForceMode.Force)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008A")]
		[Cpp2IlInjected.Address(RVA = "0x61E6950", Offset = "0x61E5D50", VA = "0x1861E6950")]
		public Vector3 WorldToLocalVelocity(Vector3 NDMBMJJIOFA)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x600008B")]
		[Cpp2IlInjected.Address(RVA = "0x61E5730", Offset = "0x61E4B30", VA = "0x1861E5730")]
		public Vector3 LocalToWorldVelocity(Vector3 EKHMFCCFGPL)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x600008C")]
		[Cpp2IlInjected.Address(RVA = "0x61E5180", Offset = "0x61E4580", VA = "0x1861E5180")]
		public void ClearVelocity()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008D")]
		[Cpp2IlInjected.Address(RVA = "0x61E5120", Offset = "0x61E4520", VA = "0x1861E5120")]
		public void ClearUnityRigidbodyVelocity()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008E")]
		[Cpp2IlInjected.Address(RVA = "0x61E50C0", Offset = "0x61E44C0", VA = "0x1861E50C0")]
		public void ClearLinearVelocity()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008F")]
		[Cpp2IlInjected.Address(RVA = "0x61E5060", Offset = "0x61E4460", VA = "0x1861E5060")]
		public void ClearAngularVelocity()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000090")]
		[Cpp2IlInjected.Address(RVA = "0x61E6250", Offset = "0x61E5650", VA = "0x1861E6250")]
		public void ResetVelocityWorldSpace(Vector3 LHINOEFCJLG, Vector3 AIMMMFLBCHI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000091")]
		[Cpp2IlInjected.Address(RVA = "0x61E6150", Offset = "0x61E5550", VA = "0x1861E6150")]
		public void ResetVelocityLocalSpace(Vector3 HGBENCPPIOE, Vector3 EFIALDMFCNH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000092")]
		[Cpp2IlInjected.Address(RVA = "0x61E6010", Offset = "0x61E5410", VA = "0x1861E6010")]
		public void ResetLinearVelocityLocalSpace(Vector3 HGBENCPPIOE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000093")]
		[Cpp2IlInjected.Address(RVA = "0x61E67E0", Offset = "0x61E5BE0", VA = "0x1861E67E0")]
		public bool SweepTest(Vector3 PIOPMIBANBL, [Out] RaycastHit HMHFDOFNLKF, float EJKOOCGEPCD)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000094")]
		[Cpp2IlInjected.Address(RVA = "0x61E5620", Offset = "0x61E4A20", VA = "0x1861E5620")]
		public bool IsSleeping()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000095")]
		[Cpp2IlInjected.Address(RVA = "0x61E6780", Offset = "0x61E5B80", VA = "0x1861E6780")]
		public void Sleep()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000096")]
		[Cpp2IlInjected.Address(RVA = "0x61E68F0", Offset = "0x61E5CF0", VA = "0x1861E68F0")]
		public void WakeUp()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000097")]
		[Cpp2IlInjected.Address(RVA = "0x61E4A80", Offset = "0x61E3E80", VA = "0x1861E4A80")]
		public void AddShouldHaveUnityRigidbodyToken(object KJAGMGIFCEM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000098")]
		[Cpp2IlInjected.Address(RVA = "0x61E5F30", Offset = "0x61E5330", VA = "0x1861E5F30")]
		public void RemoveShouldHaveUnityRigidbodyToken(object KJAGMGIFCEM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000099")]
		[Cpp2IlInjected.Address(RVA = "0x61E4E20", Offset = "0x61E4220", VA = "0x1861E4E20")]
		public void ApplyForceVelocityChange(KOJCHCLAHNC KDAMGPKMFLN, Vector3 NEBBPBIFLLJ, float KKPMGKAMFEJ, float EFDONJDPNKE = 8f, float DCDHDFHOKAE = 1f)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009A")]
		[Cpp2IlInjected.Address(RVA = "0x61E4D80", Offset = "0x61E4180", VA = "0x1861E4D80")]
		public void ApplyAngularVelocityChange(NILPLAGMMGI DAFNMKFCJFG, Vector3 LHELLKPPHKL, float FPGCJPGJIBA = float.PositiveInfinity)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009B")]
		[Cpp2IlInjected.Address(RVA = "0x61E4EE0", Offset = "0x61E42E0", VA = "0x1861E4EE0")]
		[Obsolete("Deprecated. Still exists to support deprecated CV2 chips. Use ApplyAngularVelocityChange.")]
		public void ApplyTorqueAngularVelocityChangeDeprecated(NILPLAGMMGI DAFNMKFCJFG, Vector3 KBKHJHIFKGI, float CGNIOCJOEKL = 7f, float JKANFBIIJHK = 1f)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009C")]
		[Cpp2IlInjected.Address(RVA = "0x61E4CB0", Offset = "0x61E40B0", VA = "0x1861E4CB0")]
		public bool AllowedScaleChange(float MGOPPJOJBHN)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600009D")]
		[Cpp2IlInjected.Address(RVA = "0x61E4BE0", Offset = "0x61E3FE0", VA = "0x1861E4BE0")]
		public void AddWorldSpaceVelocityInHierarchyParentOverride(RigidbodyEx DLHNNAAEEBB, object KJAGMGIFCEM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009E")]
		[Cpp2IlInjected.Address(RVA = "0x61E5FA0", Offset = "0x61E53A0", VA = "0x1861E5FA0")]
		public void RemoveWorldSpaceVelocityInHierarchyParentOverride(object KJAGMGIFCEM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009F")]
		[Cpp2IlInjected.Address(RVA = "0x61E6AF0", Offset = "0x61E5EF0", VA = "0x1861E6AF0")]
		public RigidbodyEx()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
internal static class EJKOPOPHOKM
{
	[Cpp2IlInjected.Token(Token = "0x60000A4")]
	[Cpp2IlInjected.Address(RVA = "0x61CBF30", Offset = "0x61CB330", VA = "0x1861CBF30")]
	public static MGCGGKFMJCL GHKHAMLBHKF(this RigidbodyEx GOCPNHJEOMK)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
public struct MCODEJBAGCN
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001D")]
	public Rigidbody GEBCPMOBIAB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x400001E")]
	public PhotonView NDKIHJINLPA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400001F")]
	public OverridableVector3 FPKHOCOFJCF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000020")]
	public OverridableVector3 JCMGECPCAMP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000021")]
	public PHBNBKDBFOC LBALPLBNKBN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
	[Cpp2IlInjected.Token(Token = "0x4000022")]
	public bool GHMANJLAECO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x35")]
	[Cpp2IlInjected.Token(Token = "0x4000023")]
	public bool NKJJJGJLEEP;
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
[PNAJALIKCOM(typeof(HPGKIKLHCAJ), new string[] { })]
public class GIFLPNGJIBE : HPGKIKLHCAJ, JAKEGKENGGK
{
	[Cpp2IlInjected.Token(Token = "0x4000024")]
	private static readonly FBKCBHAMJJJ AMAPEJENOPH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000025")]
	private FDJDNGGEHIB EBNNBMFMGJK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000026")]
	private JJFGCNEJLAC LFANGALDMHE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000027")]
	private EKNPMJGCPKA PALLHKLKBIN;

	[Cpp2IlInjected.Token(Token = "0x17000033")]
	public JJFGCNEJLAC DNJGMOMNONL
	{
		[Cpp2IlInjected.Token(Token = "0x60000A5")]
		[Cpp2IlInjected.Address(RVA = "0x75C540", Offset = "0x75B940", VA = "0x18075C540", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000034")]
	public EKNPMJGCPKA KPMBOFODDKB
	{
		[Cpp2IlInjected.Token(Token = "0x60000A6")]
		[Cpp2IlInjected.Address(RVA = "0x764960", Offset = "0x763D60", VA = "0x180764960", Slot = "5")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000A7")]
	[Cpp2IlInjected.Address(RVA = "0x61D6FE0", Offset = "0x61D63E0", VA = "0x1861D6FE0", Slot = "8")]
	public void InitReferences(FJPIIIPDBML NKEGKJEJLFE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A8")]
	[Cpp2IlInjected.Address(RVA = "0x61D6D30", Offset = "0x61D6130", VA = "0x1861D6D30", Slot = "6")]
	public LHNHNFAONOD AKKBFHCBAOE(RigidbodyEx GOCPNHJEOMK)
	{
		return default(LHNHNFAONOD);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A9")]
	[Cpp2IlInjected.Address(RVA = "0x61D7110", Offset = "0x61D6510", VA = "0x1861D7110")]
	private static LHNHNFAONOD PLGDAAAFKHH(RigidbodyEx GOCPNHJEOMK)
	{
		return default(LHNHNFAONOD);
	}

	[Cpp2IlInjected.Token(Token = "0x60000AA")]
	[Cpp2IlInjected.Address(RVA = "0x61D7070", Offset = "0x61D6470", VA = "0x1861D7070", Slot = "7")]
	public MGCGGKFMJCL OJHFCPKEHNA(RigidbodyEx GOCPNHJEOMK, MCODEJBAGCN GHFAAPNAFDE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000AB")]
	[Cpp2IlInjected.Address(RVA = "0x76C4B0", Offset = "0x76B8B0", VA = "0x18076C4B0")]
	public GIFLPNGJIBE()
	{
	}
}
namespace RecRoom
{
	[Cpp2IlInjected.Token(Token = "0x200000D")]
	public class PhysicsManager : SingletonMonoBehaviour<PhysicsManager>
	{
		[Cpp2IlInjected.Token(Token = "0x4000028")]
		public static OAELJMFAJKM UpdateAfterFixedUpdateRan;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000029")]
		private int GCAAPAGJHKH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x400002A")]
		private int LFDLBMOHOLI;

		[Cpp2IlInjected.Token(Token = "0x60000AD")]
		[Cpp2IlInjected.Address(RVA = "0x61E44A0", Offset = "0x61E38A0", VA = "0x1861E44A0")]
		protected void FixedUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AE")]
		[Cpp2IlInjected.Address(RVA = "0x61E44E0", Offset = "0x61E38E0", VA = "0x1861E44E0")]
		protected void Update()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AF")]
		[Cpp2IlInjected.Address(RVA = "0x61E44C0", Offset = "0x61E38C0", VA = "0x1861E44C0")]
		protected void LateUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B0")]
		[Cpp2IlInjected.Address(RVA = "0x75E5B0", Offset = "0x75D9B0", VA = "0x18075E5B0")]
		[Conditional("UNITY_ASSERTIONS")]
		public void AssertLateColliderPositionsNotYetUpdated([Optional] string NJKPBIBMIJE, [Optional] UnityEngine.Object FJHKACIMEOO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B1")]
		[Cpp2IlInjected.Address(RVA = "0x75E5B0", Offset = "0x75D9B0", VA = "0x18075E5B0")]
		[Conditional("UNITY_ASSERTIONS")]
		public void AssertLateColliderPositionsAlreadyUpdated([Optional] string NJKPBIBMIJE, [Optional] UnityEngine.Object FJHKACIMEOO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B2")]
		[Cpp2IlInjected.Address(RVA = "0x61E45F0", Offset = "0x61E39F0", VA = "0x1861E45F0")]
		public PhysicsManager()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
public static class OBABJDJFBOJ
{
	[Cpp2IlInjected.Token(Token = "0x60000B4")]
	[Cpp2IlInjected.Address(RVA = "0x61E3550", Offset = "0x61E2950", VA = "0x1861E3550")]
	public static void EHMDJBJLNPO(this Rigidbody AGBFHFNMOFE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B5")]
	[Cpp2IlInjected.Address(RVA = "0x61E36E0", Offset = "0x61E2AE0", VA = "0x1861E36E0")]
	public static void EHMDJBJLNPO(this Rigidbody AGBFHFNMOFE, Vector3 CHMEILHMPBB, Quaternion IFLJBMOEDHG, Vector3 MIJPLMMJMMJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B6")]
	[Cpp2IlInjected.Address(RVA = "0xB34DA0", Offset = "0xB341A0", VA = "0x180B34DA0")]
	public static void BHDEAHPIENF(Vector3 GKMPFMKFGID, Vector3 MBCOBAGMLHO, [Out] Vector3 GCCALNNJOLG, [Out] Vector3 OFEFMJMAANE)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000F")]
public static class ILHMKEGCMLH
{
	[Cpp2IlInjected.Token(Token = "0x2000010")]
	private class PJEGBEAIIDK : JOOBEENEBAA, IDisposable
	{
		[Cpp2IlInjected.Token(Token = "0x60000B9")]
		[Cpp2IlInjected.Address(RVA = "0x75E5B0", Offset = "0x75D9B0", VA = "0x18075E5B0", Slot = "6")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000BA")]
		[Cpp2IlInjected.Address(RVA = "0x76D990", Offset = "0x76CD90", VA = "0x18076D990", Slot = "4")]
		public Vector3 INJKDOCGHNO()
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x60000BB")]
		[Cpp2IlInjected.Address(RVA = "0x76D990", Offset = "0x76CD90", VA = "0x18076D990", Slot = "5")]
		public Vector3 MBOBHGCLAGL()
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x60000BC")]
		[Cpp2IlInjected.Address(RVA = "0x76C4B0", Offset = "0x76B8B0", VA = "0x18076C4B0")]
		public PJEGBEAIIDK()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000035")]
	public static JOOBEENEBAA APCHFNLEOKD
	{
		[Cpp2IlInjected.Token(Token = "0x60000B7")]
		[Cpp2IlInjected.Address(RVA = "0x61DE240", Offset = "0x61DD640", VA = "0x1861DE240")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
public interface EGPHOJFLGHI
{
	[Cpp2IlInjected.Token(Token = "0x17000036")]
	CollisionDetectionMode GDLPEHNGKFD
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
	void JHKGOCECMOM();

	[Cpp2IlInjected.Token(Token = "0x60000C0")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void KFCPEKBBFHO(bool EDKKJDCOKAE);

	[Cpp2IlInjected.Token(Token = "0x60000C1")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void AIOGIJPDAML(bool EDKKJDCOKAE);

	[Cpp2IlInjected.Token(Token = "0x60000C2")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void INHOGFJCLDO(Rigidbody GEBCPMOBIAB);

	[Cpp2IlInjected.Token(Token = "0x60000C3")]
	[Cpp2IlInjected.Address(Slot = "6")]
	bool ODAFJKGPNED(Vector3 PIOPMIBANBL, [Out] RaycastHit HMHFDOFNLKF, float EJKOOCGEPCD);
}
[Cpp2IlInjected.Token(Token = "0x2000012")]
public interface KKFFFGDLIIM : IDisposable, AOCMGNBNDFN
{
	[Cpp2IlInjected.Token(Token = "0x17000037")]
	CEAJINAKHIE IJNJIINAHIE
	{
		[Cpp2IlInjected.Token(Token = "0x60000C6")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
		[Cpp2IlInjected.Token(Token = "0x60000C7")]
		[Cpp2IlInjected.Address(Slot = "3")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x1400000A")]
	event Action<ADKLLFONPNJ, ADKLLFONPNJ> IEAAAMEAGPG;

	[Cpp2IlInjected.Token(Token = "0x60000C8")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void JHKGOCECMOM();
}
[Cpp2IlInjected.Token(Token = "0x2000013")]
[CDHEJLILMFK(PIEFJKINJBJ.Application)]
public interface EKNPMJGCPKA
{
	[Cpp2IlInjected.Token(Token = "0x60000C9")]
	[Cpp2IlInjected.Address(Slot = "0")]
	DODNAMHPMBE HDJDKJBJIDM(MGCGGKFMJCL MPPIIABEOMK);

	[Cpp2IlInjected.Token(Token = "0x60000CA")]
	[Cpp2IlInjected.Address(Slot = "1")]
	DGJKOCOHMGO EFOOLAELMEL(MGCGGKFMJCL MPPIIABEOMK);

	[Cpp2IlInjected.Token(Token = "0x60000CB")]
	[Cpp2IlInjected.Address(Slot = "2")]
	ABHLGLKCJNI JKELKKKKKCF(MGCGGKFMJCL MPPIIABEOMK);

	[Cpp2IlInjected.Token(Token = "0x60000CC")]
	[Cpp2IlInjected.Address(Slot = "3")]
	AHDFOHKMEJL JDDMHOBCBMG(MGCGGKFMJCL MPPIIABEOMK);

	[Cpp2IlInjected.Token(Token = "0x60000CD")]
	[Cpp2IlInjected.Address(Slot = "4")]
	GOILCCLOPLE HDFLEEFDEGH(MGCGGKFMJCL MPPIIABEOMK);

	[Cpp2IlInjected.Token(Token = "0x60000CE")]
	[Cpp2IlInjected.Address(Slot = "5")]
	KKFFFGDLIIM LHCNNINPLHC(MGCGGKFMJCL MPPIIABEOMK);

	[Cpp2IlInjected.Token(Token = "0x60000CF")]
	[Cpp2IlInjected.Address(Slot = "6")]
	JNCIBBLAFHG EOPAPGLAECF(MGCGGKFMJCL MPPIIABEOMK);

	[Cpp2IlInjected.Token(Token = "0x60000D0")]
	[Cpp2IlInjected.Address(Slot = "7")]
	LDADHEPIIJJ PPOIFOPBCIK(MGCGGKFMJCL MPPIIABEOMK);

	[Cpp2IlInjected.Token(Token = "0x60000D1")]
	[Cpp2IlInjected.Address(Slot = "8")]
	EGPHOJFLGHI EEDCLPCPAPD(MGCGGKFMJCL MPPIIABEOMK);

	[Cpp2IlInjected.Token(Token = "0x60000D2")]
	[Cpp2IlInjected.Address(Slot = "9")]
	HOGMIDIDFNH PHLDOMEJJDH(MGCGGKFMJCL MPPIIABEOMK);

	[Cpp2IlInjected.Token(Token = "0x60000D3")]
	[Cpp2IlInjected.Address(Slot = "10")]
	NHEPMPNKBHG ALKFKFHHFDI(MGCGGKFMJCL MPPIIABEOMK, [In] MCODEJBAGCN GHFAAPNAFDE);

	[Cpp2IlInjected.Token(Token = "0x60000D4")]
	[Cpp2IlInjected.Address(Slot = "11")]
	KHGIDGJJCDM ONJKEKBDIOL(MGCGGKFMJCL MPPIIABEOMK, [In] MCODEJBAGCN GHFAAPNAFDE);

	[Cpp2IlInjected.Token(Token = "0x60000D5")]
	[Cpp2IlInjected.Address(Slot = "12")]
	MFDACKEMCFN PLBIIHNHKIC(MGCGGKFMJCL MPPIIABEOMK, [In] MCODEJBAGCN GHFAAPNAFDE);

	[Cpp2IlInjected.Token(Token = "0x60000D6")]
	[Cpp2IlInjected.Address(Slot = "13")]
	JBNKCGNKKDA OLKIFCLJICA(MGCGGKFMJCL MPPIIABEOMK, [In] MCODEJBAGCN GHFAAPNAFDE);

	[Cpp2IlInjected.Token(Token = "0x60000D7")]
	[Cpp2IlInjected.Address(Slot = "14")]
	GKGLDPLOLIH NODCFIFDCCN(MGCGGKFMJCL MPPIIABEOMK, [In] MCODEJBAGCN GHFAAPNAFDE);

	[Cpp2IlInjected.Token(Token = "0x60000D8")]
	[Cpp2IlInjected.Address(Slot = "15")]
	MGCGGKFMJCL OJHFCPKEHNA(RigidbodyEx GOCPNHJEOMK, MCODEJBAGCN GHFAAPNAFDE, HPGKIKLHCAJ GCLFDBLLOOM);
}
[Cpp2IlInjected.Token(Token = "0x2000014")]
public interface LDADHEPIIJJ
{
	[Cpp2IlInjected.Token(Token = "0x60000D9")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void JIEJNNBGOLL(Vector3 EFLODOEECNL, ForceMode ECLMBFBBBLC = ForceMode.Force);

	[Cpp2IlInjected.Token(Token = "0x60000DA")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void DAMOCKENHBN(Vector3 EFLODOEECNL, Vector3 LPAPEIIOLFG, ForceMode ECLMBFBBBLC);

	[Cpp2IlInjected.Token(Token = "0x60000DB")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void IHABFMLHECC(Vector3 DMFFEFOAKAN, ForceMode ECLMBFBBBLC = ForceMode.Force);

	[Cpp2IlInjected.Token(Token = "0x60000DC")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void HBFKEDFPHOF(Vector3 DMFFEFOAKAN, ForceMode ECLMBFBBBLC = ForceMode.Force);
}
[Cpp2IlInjected.Token(Token = "0x2000015")]
public interface HOGMIDIDFNH
{
	[Cpp2IlInjected.Token(Token = "0x17000038")]
	bool PLJCHFLJNEH
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
	void INHOGFJCLDO(Rigidbody GEBCPMOBIAB);

	[Cpp2IlInjected.Token(Token = "0x60000E0")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void FLMHAOMIJON(Rigidbody GEBCPMOBIAB);
}
[Cpp2IlInjected.Token(Token = "0x2000016")]
public interface DODNAMHPMBE : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x17000039")]
	IReadOnlyList<MGCGGKFMJCL> FCCNECOIHNG
	{
		[Cpp2IlInjected.Token(Token = "0x60000F3")]
		[Cpp2IlInjected.Address(Slot = "18")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700003A")]
	MGCGGKFMJCL DFDPGOHHPEM
	{
		[Cpp2IlInjected.Token(Token = "0x60000F4")]
		[Cpp2IlInjected.Address(Slot = "19")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700003B")]
	MGCGGKFMJCL NCEKKJFNJNC
	{
		[Cpp2IlInjected.Token(Token = "0x60000F5")]
		[Cpp2IlInjected.Address(Slot = "20")]
		get;
		[Cpp2IlInjected.Token(Token = "0x60000F6")]
		[Cpp2IlInjected.Address(Slot = "21")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x1400000B")]
	event LNNBFANOADD ELBIILPLBLJ;

	[Cpp2IlInjected.Token(Token = "0x1400000C")]
	event LNNBFANOADD CBNGEFCLMOB;

	[Cpp2IlInjected.Token(Token = "0x1400000D")]
	event OKIHMFHNBGG IACLPHDLFGN;

	[Cpp2IlInjected.Token(Token = "0x1400000E")]
	event Action GLGKNBAGMIP;

	[Cpp2IlInjected.Token(Token = "0x1400000F")]
	event Action FEEIKIIDIDI;

	[Cpp2IlInjected.Token(Token = "0x14000010")]
	event Action<MGCGGKFMJCL> HGADFPCMNGJ;

	[Cpp2IlInjected.Token(Token = "0x14000011")]
	event Action<MGCGGKFMJCL> DIBBGPAFGIG;

	[Cpp2IlInjected.Token(Token = "0x14000012")]
	event Action GMFKHKBHJIH;

	[Cpp2IlInjected.Token(Token = "0x14000013")]
	event Action<MGCGGKFMJCL> DEOECEFBMHF;

	[Cpp2IlInjected.Token(Token = "0x60000F7")]
	[Cpp2IlInjected.Address(Slot = "22")]
	void HEBPNKMJKGE(MGCGGKFMJCL JOOENMAHIDL, bool ABHJANDGLGK = false);
}
[Cpp2IlInjected.Token(Token = "0x2000017")]
public interface ABHLGLKCJNI
{
	[Cpp2IlInjected.Token(Token = "0x1700003C")]
	Vector3 IADJPHPDBGC
	{
		[Cpp2IlInjected.Token(Token = "0x60000F8")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700003D")]
	Vector3 FNFHIDNBNCJ
	{
		[Cpp2IlInjected.Token(Token = "0x60000F9")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x60000FA")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void JNLJFCKDFBA(MGCGGKFMJCL EBFCMPBKGBM, object KJAGMGIFCEM);

	[Cpp2IlInjected.Token(Token = "0x60000FB")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void JOBKNFFOIEF(object KJAGMGIFCEM);
}
[Cpp2IlInjected.Token(Token = "0x2000018")]
public interface JBNKCGNKKDA
{
	[Cpp2IlInjected.Token(Token = "0x1700003E")]
	Vector3 NIBENPFEBFL
	{
		[Cpp2IlInjected.Token(Token = "0x60000FE")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
		[Cpp2IlInjected.Token(Token = "0x60000FF")]
		[Cpp2IlInjected.Address(Slot = "3")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x1700003F")]
	Vector3 JOKPJCADMPL
	{
		[Cpp2IlInjected.Token(Token = "0x6000100")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000040")]
	float MAMOOAGGOAI
	{
		[Cpp2IlInjected.Token(Token = "0x6000101")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000041")]
	float AIGIACKFCCL
	{
		[Cpp2IlInjected.Token(Token = "0x6000102")]
		[Cpp2IlInjected.Address(Slot = "6")]
		get;
		[Cpp2IlInjected.Token(Token = "0x6000103")]
		[Cpp2IlInjected.Address(Slot = "7")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000042")]
	Vector3 CAPAJCKGOEI
	{
		[Cpp2IlInjected.Token(Token = "0x6000104")]
		[Cpp2IlInjected.Address(Slot = "8")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000043")]
	Quaternion DICIGDCIMAG
	{
		[Cpp2IlInjected.Token(Token = "0x6000105")]
		[Cpp2IlInjected.Address(Slot = "9")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x14000014")]
	event LNNBFANOADD DIFBMICLCDD;

	[Cpp2IlInjected.Token(Token = "0x6000106")]
	[Cpp2IlInjected.Address(Slot = "10")]
	void EEEEBLADLHM((Quaternion rot, Vector3 moments) NCNIHGBNECM);

	[Cpp2IlInjected.Token(Token = "0x6000107")]
	[Cpp2IlInjected.Address(Slot = "11")]
	void GGKIHNLFLKG();

	[Cpp2IlInjected.Token(Token = "0x6000108")]
	[Cpp2IlInjected.Address(Slot = "12")]
	void FJPECHAAMGI();

	[Cpp2IlInjected.Token(Token = "0x6000109")]
	[Cpp2IlInjected.Address(Slot = "13")]
	void KOHGBDIONNB();

	[Cpp2IlInjected.Token(Token = "0x600010A")]
	[Cpp2IlInjected.Address(Slot = "14")]
	void INHOGFJCLDO(Rigidbody GEBCPMOBIAB);

	[Cpp2IlInjected.Token(Token = "0x600010B")]
	[Cpp2IlInjected.Address(Slot = "15")]
	void FLMHAOMIJON(Rigidbody GEBCPMOBIAB);

	[Cpp2IlInjected.Token(Token = "0x600010C")]
	[Cpp2IlInjected.Address(Slot = "16")]
	void GKIFGLBKBIO();
}
[Cpp2IlInjected.Token(Token = "0x2000019")]
public interface MFDACKEMCFN
{
	[Cpp2IlInjected.Token(Token = "0x600010D")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void JHKGOCECMOM();

	[Cpp2IlInjected.Token(Token = "0x600010E")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void OKJADHJGFEH(object KJAGMGIFCEM);

	[Cpp2IlInjected.Token(Token = "0x600010F")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void AMFHLIBIOON(object KJAGMGIFCEM);

	[Cpp2IlInjected.Token(Token = "0x6000110")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void BKJBLAIOBGP(MGCGGKFMJCL GOCPNHJEOMK);

	[Cpp2IlInjected.Token(Token = "0x6000111")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void GNEEHHDPIKA(MGCGGKFMJCL GOCPNHJEOMK);

	[Cpp2IlInjected.Token(Token = "0x6000112")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void IGMOCGMLLHH();
}
[Cpp2IlInjected.Token(Token = "0x200001A")]
public interface JNCIBBLAFHG
{
	[Cpp2IlInjected.Token(Token = "0x17000044")]
	bool HCGHILJJDJE
	{
		[Cpp2IlInjected.Token(Token = "0x6000116")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x14000015")]
	event LNNBFANOADD OMDOLGBKNMB;

	[Cpp2IlInjected.Token(Token = "0x6000115")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void KCMCKENJMGM();

	[Cpp2IlInjected.Token(Token = "0x6000117")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void CLOLFMGHJID(object KJAGMGIFCEM);

	[Cpp2IlInjected.Token(Token = "0x6000118")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void LAPKPJEEGPL(object KJAGMGIFCEM);

	[Cpp2IlInjected.Token(Token = "0x6000119")]
	[Cpp2IlInjected.Address(Slot = "6")]
	void EHLACEEGNEA(object KJAGMGIFCEM, bool LLALDMDCIAM);

	[Cpp2IlInjected.Token(Token = "0x600011A")]
	[Cpp2IlInjected.Address(Slot = "7")]
	IDisposable ODOGLKJIBAL();

	[Cpp2IlInjected.Token(Token = "0x600011B")]
	[Cpp2IlInjected.Address(Slot = "8")]
	void INHOGFJCLDO(Rigidbody IMHHODKMCIF);

	[Cpp2IlInjected.Token(Token = "0x600011C")]
	[Cpp2IlInjected.Address(Slot = "9")]
	void FLMHAOMIJON(Rigidbody GEBCPMOBIAB);
}
[Cpp2IlInjected.Token(Token = "0x200001B")]
public interface KHGIDGJJCDM : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x17000045")]
	bool FFIFGPLINHH
	{
		[Cpp2IlInjected.Token(Token = "0x600011F")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000046")]
	bool HAEGEFIPLPF
	{
		[Cpp2IlInjected.Token(Token = "0x6000120")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x14000016")]
	event LNNBFANOADD PLAFGMCIMLA;

	[Cpp2IlInjected.Token(Token = "0x6000121")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void JHKGOCECMOM();

	[Cpp2IlInjected.Token(Token = "0x6000122")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void NBPCMILFJNH(MGCGGKFMJCL EBFCMPBKGBM);

	[Cpp2IlInjected.Token(Token = "0x6000123")]
	[Cpp2IlInjected.Address(Slot = "6")]
	void DEJHAKKIFOI(MGCGGKFMJCL EBFCMPBKGBM);
}
[Cpp2IlInjected.Token(Token = "0x200001C")]
public interface GKGLDPLOLIH
{
	[Cpp2IlInjected.Token(Token = "0x17000047")]
	bool PBOGKFDNBGB
	{
		[Cpp2IlInjected.Token(Token = "0x6000124")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
		[Cpp2IlInjected.Token(Token = "0x6000125")]
		[Cpp2IlInjected.Address(Slot = "1")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000048")]
	bool FCGKAPFLGFO
	{
		[Cpp2IlInjected.Token(Token = "0x6000126")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000049")]
	RigidbodyConstraints IEOPINFGGLF
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
	void INHOGFJCLDO(Rigidbody GEBCPMOBIAB);

	[Cpp2IlInjected.Token(Token = "0x600012A")]
	[Cpp2IlInjected.Address(Slot = "6")]
	void FLMHAOMIJON(Rigidbody GEBCPMOBIAB);
}
[Cpp2IlInjected.Token(Token = "0x200001D")]
public interface AHDFOHKMEJL
{
	[Cpp2IlInjected.Token(Token = "0x1700004A")]
	float FBLHKIOECLM
	{
		[Cpp2IlInjected.Token(Token = "0x600012B")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
		[Cpp2IlInjected.Token(Token = "0x600012C")]
		[Cpp2IlInjected.Address(Slot = "1")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x1700004B")]
	float NNGEGGCECLN
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
	void INHOGFJCLDO(Rigidbody GEBCPMOBIAB);

	[Cpp2IlInjected.Token(Token = "0x6000130")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void FLMHAOMIJON(Rigidbody GEBCPMOBIAB);
}
[Cpp2IlInjected.Token(Token = "0x200001E")]
public interface FJHBKOHIAKJ
{
	[Cpp2IlInjected.Token(Token = "0x6000131")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void OnRootRBEXChanged(RigidbodyEx AMJEKBEPFBM);
}
[Cpp2IlInjected.Token(Token = "0x200001F")]
public interface GOILCCLOPLE
{
	[Cpp2IlInjected.Token(Token = "0x14000017")]
	event LNNBFANOADD JKEEEOMBIDH;

	[Cpp2IlInjected.Token(Token = "0x6000134")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void JHKGOCECMOM();

	[Cpp2IlInjected.Token(Token = "0x6000135")]
	[Cpp2IlInjected.Address(Slot = "3")]
	bool GBMNOJMBOIA();

	[Cpp2IlInjected.Token(Token = "0x6000136")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void OHDGAPGGGEO();

	[Cpp2IlInjected.Token(Token = "0x6000137")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void DKHDPIPGLAN();

	[Cpp2IlInjected.Token(Token = "0x6000138")]
	[Cpp2IlInjected.Address(Slot = "6")]
	void FDFEHOGPDLO();

	[Cpp2IlInjected.Token(Token = "0x6000139")]
	[Cpp2IlInjected.Address(Slot = "7")]
	void MALCMJHIFLA();

	[Cpp2IlInjected.Token(Token = "0x600013A")]
	[Cpp2IlInjected.Address(Slot = "8")]
	void JPEOPDBIOFK(bool JOAAGNJLPGK);
}
[Cpp2IlInjected.Token(Token = "0x2000020")]
public interface NHEPMPNKBHG
{
	[Cpp2IlInjected.Token(Token = "0x1700004C")]
	Rigidbody ACNJBLDPNFK
	{
		[Cpp2IlInjected.Token(Token = "0x600013B")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700004D")]
	bool LOFHGPEPHPP
	{
		[Cpp2IlInjected.Token(Token = "0x600013D")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x600013C")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void JHKGOCECMOM();

	[Cpp2IlInjected.Token(Token = "0x600013E")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void CEDEMEPPALB(object KJAGMGIFCEM);

	[Cpp2IlInjected.Token(Token = "0x600013F")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void MLKIEMGEEPP(object KJAGMGIFCEM);

	[Cpp2IlInjected.Token(Token = "0x6000140")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void BNBIPPHMKFF();

	[Cpp2IlInjected.Token(Token = "0x6000141")]
	[Cpp2IlInjected.Address(Slot = "6")]
	void ACICNKEKDGI();
}
[Cpp2IlInjected.Token(Token = "0x2000021")]
public interface DGJKOCOHMGO : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x1700004E")]
	JOOBEENEBAA KIPEILJOHEE
	{
		[Cpp2IlInjected.Token(Token = "0x6000142")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
		[Cpp2IlInjected.Token(Token = "0x6000143")]
		[Cpp2IlInjected.Address(Slot = "1")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x1700004F")]
	GKFPHOCIOLD BCAAPMKBHAM
	{
		[Cpp2IlInjected.Token(Token = "0x6000144")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
		[Cpp2IlInjected.Token(Token = "0x6000145")]
		[Cpp2IlInjected.Address(Slot = "3")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000050")]
	Vector3 DPFKMNPADOM
	{
		[Cpp2IlInjected.Token(Token = "0x6000146")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
		[Cpp2IlInjected.Token(Token = "0x6000147")]
		[Cpp2IlInjected.Address(Slot = "5")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000051")]
	Vector3 GFFGILJCJLF
	{
		[Cpp2IlInjected.Token(Token = "0x6000148")]
		[Cpp2IlInjected.Address(Slot = "6")]
		get;
		[Cpp2IlInjected.Token(Token = "0x6000149")]
		[Cpp2IlInjected.Address(Slot = "7")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000052")]
	Vector3 IKKGDGHOOEN
	{
		[Cpp2IlInjected.Token(Token = "0x600014A")]
		[Cpp2IlInjected.Address(Slot = "8")]
		get;
		[Cpp2IlInjected.Token(Token = "0x600014B")]
		[Cpp2IlInjected.Address(Slot = "9")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000053")]
	Vector3 ACHPDMPDEGK
	{
		[Cpp2IlInjected.Token(Token = "0x600014C")]
		[Cpp2IlInjected.Address(Slot = "10")]
		get;
		[Cpp2IlInjected.Token(Token = "0x600014D")]
		[Cpp2IlInjected.Address(Slot = "11")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000054")]
	float IMFCIBCJLIP
	{
		[Cpp2IlInjected.Token(Token = "0x600014E")]
		[Cpp2IlInjected.Address(Slot = "12")]
		get;
		[Cpp2IlInjected.Token(Token = "0x600014F")]
		[Cpp2IlInjected.Address(Slot = "13")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000055")]
	bool NCFBIAMPAHJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000150")]
		[Cpp2IlInjected.Address(Slot = "14")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000151")]
	[Cpp2IlInjected.Address(Slot = "15")]
	void JHKGOCECMOM();

	[Cpp2IlInjected.Token(Token = "0x6000152")]
	[Cpp2IlInjected.Address(Slot = "16")]
	void NGDGOPEIOMC(object KJAGMGIFCEM);

	[Cpp2IlInjected.Token(Token = "0x6000153")]
	[Cpp2IlInjected.Address(Slot = "17")]
	void DMLNPBGDGBL(NILPLAGMMGI DAFNMKFCJFG, Vector3 LHELLKPPHKL, float FPGCJPGJIBA = float.PositiveInfinity);

	[Cpp2IlInjected.Token(Token = "0x6000154")]
	[Cpp2IlInjected.Address(Slot = "18")]
	void IKEAFEJHOCH(KOJCHCLAHNC KDAMGPKMFLN, Vector3 NEBBPBIFLLJ, float KKPMGKAMFEJ, float EFDONJDPNKE = 8f, float DCDHDFHOKAE = 1f);

	[Cpp2IlInjected.Token(Token = "0x6000155")]
	[Cpp2IlInjected.Address(Slot = "19")]
	void BFAKGADOJGG(NILPLAGMMGI DAFNMKFCJFG, Vector3 KBKHJHIFKGI, float CGNIOCJOEKL = 7f, float JKANFBIIJHK = 1f);

	[Cpp2IlInjected.Token(Token = "0x6000156")]
	[Cpp2IlInjected.Address(Slot = "20")]
	void PEPDJLKNHGG();

	[Cpp2IlInjected.Token(Token = "0x6000157")]
	[Cpp2IlInjected.Address(Slot = "21")]
	void ADFAAJPBAGA();

	[Cpp2IlInjected.Token(Token = "0x6000158")]
	[Cpp2IlInjected.Address(Slot = "22")]
	void PJFHPKDNKCK();

	[Cpp2IlInjected.Token(Token = "0x6000159")]
	[Cpp2IlInjected.Address(Slot = "23")]
	void CPOFEOBDKHH();

	[Cpp2IlInjected.Token(Token = "0x600015A")]
	[Cpp2IlInjected.Address(Slot = "24")]
	void INHOGFJCLDO(Rigidbody GEBCPMOBIAB);

	[Cpp2IlInjected.Token(Token = "0x600015B")]
	[Cpp2IlInjected.Address(Slot = "25")]
	Vector3 MLOBKENIFDB(Vector3 GKMPFMKFGID);

	[Cpp2IlInjected.Token(Token = "0x600015C")]
	[Cpp2IlInjected.Address(Slot = "26")]
	void AAADHENEFCN(object KJAGMGIFCEM);

	[Cpp2IlInjected.Token(Token = "0x600015D")]
	[Cpp2IlInjected.Address(Slot = "27")]
	void KDOMADLDDAH(Vector3 AFNABGBDBAH);

	[Cpp2IlInjected.Token(Token = "0x600015E")]
	[Cpp2IlInjected.Address(Slot = "28")]
	void ALEIMOONCKG(Vector3 HGBENCPPIOE, Vector3 EFIALDMFCNH);

	[Cpp2IlInjected.Token(Token = "0x600015F")]
	[Cpp2IlInjected.Address(Slot = "29")]
	void BIABKHBMFDC(Vector3 LHINOEFCJLG, Vector3 AIMMMFLBCHI);

	[Cpp2IlInjected.Token(Token = "0x6000160")]
	[Cpp2IlInjected.Address(Slot = "30")]
	Vector3 DMBNKHGFCEB(Vector3 EKHMFCCFGPL);

	[Cpp2IlInjected.Token(Token = "0x6000161")]
	[Cpp2IlInjected.Address(Slot = "31")]
	Vector3 FLADNKLALKJ(Vector3 NDMBMJJIOFA);
}
[Cpp2IlInjected.Token(Token = "0x2000022")]
[CDHEJLILMFK(PIEFJKINJBJ.Application)]
public interface JJFGCNEJLAC
{
	[Cpp2IlInjected.Token(Token = "0x17000056")]
	bool FGCAICKGKKG
	{
		[Cpp2IlInjected.Token(Token = "0x6000162")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000163")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void EMKLCIACEDC(string GHNPOMJGELJ);

	[Cpp2IlInjected.Token(Token = "0x6000164")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void ECENADFPANM(RigidbodyEx GOCPNHJEOMK, Action GMCEKENFDDF);

	[Cpp2IlInjected.Token(Token = "0x6000165")]
	[Cpp2IlInjected.Address(Slot = "3")]
	ADPDPCABPGF NMAAJKCJHCO(int GAMEIOIKOGN);

	[Cpp2IlInjected.Token(Token = "0x6000166")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void INEOBCPPMIL(Vector3 IBDKNACJALI, float APBCPDOCONE, Color DJDNAMFLFCL);
}
[Cpp2IlInjected.Token(Token = "0x2000023")]
[CDHEJLILMFK(PIEFJKINJBJ.Application)]
public interface HPGKIKLHCAJ
{
	[Cpp2IlInjected.Token(Token = "0x17000057")]
	JJFGCNEJLAC DNJGMOMNONL
	{
		[Cpp2IlInjected.Token(Token = "0x6000167")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000058")]
	EKNPMJGCPKA KPMBOFODDKB
	{
		[Cpp2IlInjected.Token(Token = "0x6000168")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000169")]
	[Cpp2IlInjected.Address(Slot = "2")]
	LHNHNFAONOD AKKBFHCBAOE(RigidbodyEx GOCPNHJEOMK);

	[Cpp2IlInjected.Token(Token = "0x600016A")]
	[Cpp2IlInjected.Address(Slot = "3")]
	MGCGGKFMJCL OJHFCPKEHNA(RigidbodyEx GOCPNHJEOMK, MCODEJBAGCN GHFAAPNAFDE);
}
[Cpp2IlInjected.Token(Token = "0x2000024")]
public interface GKFPHOCIOLD
{
	[Cpp2IlInjected.Token(Token = "0x600016B")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void DCHFJGPGEDG(Vector3 PGGIDAINLNJ);

	[Cpp2IlInjected.Token(Token = "0x600016C")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void OJEAPEOCDMI(Vector3 BADJPOOCLHC);

	[Cpp2IlInjected.Token(Token = "0x600016D")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void MGOKBDPBCFE(Vector3 PGGIDAINLNJ);

	[Cpp2IlInjected.Token(Token = "0x600016E")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void BNHODHEEDGG(Vector3 BADJPOOCLHC);
}
[Cpp2IlInjected.Token(Token = "0x2000025")]
public interface JOOBEENEBAA : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x600016F")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Vector3 INJKDOCGHNO();

	[Cpp2IlInjected.Token(Token = "0x6000170")]
	[Cpp2IlInjected.Address(Slot = "1")]
	Vector3 MBOBHGCLAGL();
}
[Cpp2IlInjected.Token(Token = "0x2000026")]
public interface MGCGGKFMJCL : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x17000059")]
	Rigidbody ACNJBLDPNFK
	{
		[Cpp2IlInjected.Token(Token = "0x6000171")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700005A")]
	RigidbodyEx BAOFDDACECK
	{
		[Cpp2IlInjected.Token(Token = "0x6000172")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700005B")]
	GameObject EDFMFAADHAF
	{
		[Cpp2IlInjected.Token(Token = "0x6000173")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700005C")]
	Transform JGKOKOJENGE
	{
		[Cpp2IlInjected.Token(Token = "0x6000174")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700005D")]
	MGCGGKFMJCL NCEKKJFNJNC
	{
		[Cpp2IlInjected.Token(Token = "0x6000175")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
		[Cpp2IlInjected.Token(Token = "0x6000176")]
		[Cpp2IlInjected.Address(Slot = "5")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x1700005E")]
	IReadOnlyList<MGCGGKFMJCL> FCCNECOIHNG
	{
		[Cpp2IlInjected.Token(Token = "0x6000177")]
		[Cpp2IlInjected.Address(Slot = "6")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700005F")]
	MGCGGKFMJCL DFDPGOHHPEM
	{
		[Cpp2IlInjected.Token(Token = "0x6000178")]
		[Cpp2IlInjected.Address(Slot = "7")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000060")]
	bool FFIFGPLINHH
	{
		[Cpp2IlInjected.Token(Token = "0x6000179")]
		[Cpp2IlInjected.Address(Slot = "8")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000061")]
	bool HAEGEFIPLPF
	{
		[Cpp2IlInjected.Token(Token = "0x600017A")]
		[Cpp2IlInjected.Address(Slot = "9")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000062")]
	JOOBEENEBAA KIPEILJOHEE
	{
		[Cpp2IlInjected.Token(Token = "0x600017B")]
		[Cpp2IlInjected.Address(Slot = "10")]
		get;
		[Cpp2IlInjected.Token(Token = "0x600017C")]
		[Cpp2IlInjected.Address(Slot = "11")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000063")]
	GKFPHOCIOLD BCAAPMKBHAM
	{
		[Cpp2IlInjected.Token(Token = "0x600017D")]
		[Cpp2IlInjected.Address(Slot = "12")]
		get;
		[Cpp2IlInjected.Token(Token = "0x600017E")]
		[Cpp2IlInjected.Address(Slot = "13")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000064")]
	float IMFCIBCJLIP
	{
		[Cpp2IlInjected.Token(Token = "0x600017F")]
		[Cpp2IlInjected.Address(Slot = "14")]
		get;
		[Cpp2IlInjected.Token(Token = "0x6000180")]
		[Cpp2IlInjected.Address(Slot = "15")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000065")]
	Vector3 GFFGILJCJLF
	{
		[Cpp2IlInjected.Token(Token = "0x6000181")]
		[Cpp2IlInjected.Address(Slot = "16")]
		get;
		[Cpp2IlInjected.Token(Token = "0x6000182")]
		[Cpp2IlInjected.Address(Slot = "17")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000066")]
	Vector3 ACHPDMPDEGK
	{
		[Cpp2IlInjected.Token(Token = "0x6000183")]
		[Cpp2IlInjected.Address(Slot = "18")]
		get;
		[Cpp2IlInjected.Token(Token = "0x6000184")]
		[Cpp2IlInjected.Address(Slot = "19")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000067")]
	Vector3 DPFKMNPADOM
	{
		[Cpp2IlInjected.Token(Token = "0x6000185")]
		[Cpp2IlInjected.Address(Slot = "20")]
		get;
		[Cpp2IlInjected.Token(Token = "0x6000186")]
		[Cpp2IlInjected.Address(Slot = "21")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000068")]
	Vector3 IKKGDGHOOEN
	{
		[Cpp2IlInjected.Token(Token = "0x6000187")]
		[Cpp2IlInjected.Address(Slot = "22")]
		get;
		[Cpp2IlInjected.Token(Token = "0x6000188")]
		[Cpp2IlInjected.Address(Slot = "23")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000069")]
	bool GOJPGPEEJCL
	{
		[Cpp2IlInjected.Token(Token = "0x6000189")]
		[Cpp2IlInjected.Address(Slot = "24")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700006A")]
	bool NLCHEOGPMJH
	{
		[Cpp2IlInjected.Token(Token = "0x600018A")]
		[Cpp2IlInjected.Address(Slot = "25")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700006B")]
	bool NCFBIAMPAHJ
	{
		[Cpp2IlInjected.Token(Token = "0x600018B")]
		[Cpp2IlInjected.Address(Slot = "26")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700006C")]
	Vector3 IADJPHPDBGC
	{
		[Cpp2IlInjected.Token(Token = "0x600018C")]
		[Cpp2IlInjected.Address(Slot = "27")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700006D")]
	Vector3 FNFHIDNBNCJ
	{
		[Cpp2IlInjected.Token(Token = "0x600018D")]
		[Cpp2IlInjected.Address(Slot = "28")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700006E")]
	Vector3 NIBENPFEBFL
	{
		[Cpp2IlInjected.Token(Token = "0x600018E")]
		[Cpp2IlInjected.Address(Slot = "29")]
		get;
		[Cpp2IlInjected.Token(Token = "0x600018F")]
		[Cpp2IlInjected.Address(Slot = "30")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x1700006F")]
	Vector3 JOKPJCADMPL
	{
		[Cpp2IlInjected.Token(Token = "0x6000190")]
		[Cpp2IlInjected.Address(Slot = "31")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000070")]
	float MAMOOAGGOAI
	{
		[Cpp2IlInjected.Token(Token = "0x6000191")]
		[Cpp2IlInjected.Address(Slot = "32")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000071")]
	float AIGIACKFCCL
	{
		[Cpp2IlInjected.Token(Token = "0x6000192")]
		[Cpp2IlInjected.Address(Slot = "33")]
		get;
		[Cpp2IlInjected.Token(Token = "0x6000193")]
		[Cpp2IlInjected.Address(Slot = "34")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000072")]
	Vector3 CAPAJCKGOEI
	{
		[Cpp2IlInjected.Token(Token = "0x6000194")]
		[Cpp2IlInjected.Address(Slot = "35")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000073")]
	Quaternion DICIGDCIMAG
	{
		[Cpp2IlInjected.Token(Token = "0x6000195")]
		[Cpp2IlInjected.Address(Slot = "36")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000074")]
	float FBLHKIOECLM
	{
		[Cpp2IlInjected.Token(Token = "0x6000197")]
		[Cpp2IlInjected.Address(Slot = "38")]
		get;
		[Cpp2IlInjected.Token(Token = "0x6000198")]
		[Cpp2IlInjected.Address(Slot = "39")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000075")]
	float NNGEGGCECLN
	{
		[Cpp2IlInjected.Token(Token = "0x6000199")]
		[Cpp2IlInjected.Address(Slot = "40")]
		get;
		[Cpp2IlInjected.Token(Token = "0x600019A")]
		[Cpp2IlInjected.Address(Slot = "41")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000076")]
	bool PLJCHFLJNEH
	{
		[Cpp2IlInjected.Token(Token = "0x600019B")]
		[Cpp2IlInjected.Address(Slot = "42")]
		get;
		[Cpp2IlInjected.Token(Token = "0x600019C")]
		[Cpp2IlInjected.Address(Slot = "43")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000077")]
	CEAJINAKHIE IJNJIINAHIE
	{
		[Cpp2IlInjected.Token(Token = "0x600019D")]
		[Cpp2IlInjected.Address(Slot = "44")]
		get;
		[Cpp2IlInjected.Token(Token = "0x600019E")]
		[Cpp2IlInjected.Address(Slot = "45")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000078")]
	bool HCGHILJJDJE
	{
		[Cpp2IlInjected.Token(Token = "0x600019F")]
		[Cpp2IlInjected.Address(Slot = "46")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000079")]
	Transform OEBHBPDHFHA
	{
		[Cpp2IlInjected.Token(Token = "0x60001A0")]
		[Cpp2IlInjected.Address(Slot = "47")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700007A")]
	Vector3 BFIMMMNJJEB
	{
		[Cpp2IlInjected.Token(Token = "0x60001A1")]
		[Cpp2IlInjected.Address(Slot = "48")]
		get;
		[Cpp2IlInjected.Token(Token = "0x60001A2")]
		[Cpp2IlInjected.Address(Slot = "49")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x1700007B")]
	float DLDGBIHEMNE
	{
		[Cpp2IlInjected.Token(Token = "0x60001A3")]
		[Cpp2IlInjected.Address(Slot = "50")]
		get;
		[Cpp2IlInjected.Token(Token = "0x60001A4")]
		[Cpp2IlInjected.Address(Slot = "51")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x1700007C")]
	float LHDFLHMPEDP
	{
		[Cpp2IlInjected.Token(Token = "0x60001A5")]
		[Cpp2IlInjected.Address(Slot = "52")]
		get;
		[Cpp2IlInjected.Token(Token = "0x60001A6")]
		[Cpp2IlInjected.Address(Slot = "53")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x1700007D")]
	Quaternion EOOPIAMLFFL
	{
		[Cpp2IlInjected.Token(Token = "0x60001A7")]
		[Cpp2IlInjected.Address(Slot = "54")]
		get;
		[Cpp2IlInjected.Token(Token = "0x60001A8")]
		[Cpp2IlInjected.Address(Slot = "55")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x1700007E")]
	Vector3 MKJKOHNLCOL
	{
		[Cpp2IlInjected.Token(Token = "0x60001A9")]
		[Cpp2IlInjected.Address(Slot = "56")]
		get;
		[Cpp2IlInjected.Token(Token = "0x60001AA")]
		[Cpp2IlInjected.Address(Slot = "57")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x1700007F")]
	Quaternion OIFBJHBHDIL
	{
		[Cpp2IlInjected.Token(Token = "0x60001AB")]
		[Cpp2IlInjected.Address(Slot = "58")]
		get;
		[Cpp2IlInjected.Token(Token = "0x60001AC")]
		[Cpp2IlInjected.Address(Slot = "59")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000080")]
	RigidbodyConstraints IEOPINFGGLF
	{
		[Cpp2IlInjected.Token(Token = "0x60001AD")]
		[Cpp2IlInjected.Address(Slot = "60")]
		get;
		[Cpp2IlInjected.Token(Token = "0x60001AE")]
		[Cpp2IlInjected.Address(Slot = "61")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000081")]
	bool PBOGKFDNBGB
	{
		[Cpp2IlInjected.Token(Token = "0x60001AF")]
		[Cpp2IlInjected.Address(Slot = "62")]
		get;
		[Cpp2IlInjected.Token(Token = "0x60001B0")]
		[Cpp2IlInjected.Address(Slot = "63")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000082")]
	CollisionDetectionMode GDLPEHNGKFD
	{
		[Cpp2IlInjected.Token(Token = "0x60001B1")]
		[Cpp2IlInjected.Address(Slot = "64")]
		get;
		[Cpp2IlInjected.Token(Token = "0x60001B2")]
		[Cpp2IlInjected.Address(Slot = "65")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000083")]
	bool CBOGMEEBBPL
	{
		[Cpp2IlInjected.Token(Token = "0x60001B3")]
		[Cpp2IlInjected.Address(Slot = "66")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x14000018")]
	event LNNBFANOADD ELBIILPLBLJ;

	[Cpp2IlInjected.Token(Token = "0x14000019")]
	event LNNBFANOADD CBNGEFCLMOB;

	[Cpp2IlInjected.Token(Token = "0x1400001A")]
	event OKIHMFHNBGG IACLPHDLFGN;

	[Cpp2IlInjected.Token(Token = "0x1400001B")]
	event LNNBFANOADD PLAFGMCIMLA;

	[Cpp2IlInjected.Token(Token = "0x1400001C")]
	event LNNBFANOADD LCEOKOPJBNC;

	[Cpp2IlInjected.Token(Token = "0x1400001D")]
	event LNNBFANOADD JKEEEOMBIDH;

	[Cpp2IlInjected.Token(Token = "0x1400001E")]
	event Action<ADKLLFONPNJ, ADKLLFONPNJ> IEAAAMEAGPG;

	[Cpp2IlInjected.Token(Token = "0x1400001F")]
	event LNNBFANOADD OMDOLGBKNMB;

	[Cpp2IlInjected.Token(Token = "0x14000020")]
	event LNNBFANOADD OKPCAHNBDOG;

	[Cpp2IlInjected.Token(Token = "0x6000196")]
	[Cpp2IlInjected.Address(Slot = "37")]
	void EEEEBLADLHM((Quaternion rot, Vector3 moments) NCNIHGBNECM);

	[Cpp2IlInjected.Token(Token = "0x60001B4")]
	[Cpp2IlInjected.Address(Slot = "67")]
	void JHKGOCECMOM();

	[Cpp2IlInjected.Token(Token = "0x60001B5")]
	[Cpp2IlInjected.Address(Slot = "68")]
	void ANCCAJMPGEI();

	[Cpp2IlInjected.Token(Token = "0x60001B6")]
	[Cpp2IlInjected.Address(Slot = "69")]
	void KNFPAGAHPOH();

	[Cpp2IlInjected.Token(Token = "0x60001B7")]
	[Cpp2IlInjected.Address(Slot = "70")]
	void DKHDPIPGLAN();

	[Cpp2IlInjected.Token(Token = "0x60001BE")]
	[Cpp2IlInjected.Address(Slot = "77")]
	void HEBPNKMJKGE(MGCGGKFMJCL EOHMJBFGDPD, bool ABHJANDGLGK = false);

	[Cpp2IlInjected.Token(Token = "0x60001C1")]
	[Cpp2IlInjected.Address(Slot = "80")]
	void BLMOJFOIDMP(object KJAGMGIFCEM);

	[Cpp2IlInjected.Token(Token = "0x60001C2")]
	[Cpp2IlInjected.Address(Slot = "81")]
	void NJMHFKGMAOA(object KJAGMGIFCEM);

	[Cpp2IlInjected.Token(Token = "0x60001C3")]
	[Cpp2IlInjected.Address(Slot = "82")]
	Vector3 FLADNKLALKJ(Vector3 NDMBMJJIOFA);

	[Cpp2IlInjected.Token(Token = "0x60001C4")]
	[Cpp2IlInjected.Address(Slot = "83")]
	Vector3 DMBNKHGFCEB(Vector3 EKHMFCCFGPL);

	[Cpp2IlInjected.Token(Token = "0x60001C5")]
	[Cpp2IlInjected.Address(Slot = "84")]
	void CPOFEOBDKHH();

	[Cpp2IlInjected.Token(Token = "0x60001C6")]
	[Cpp2IlInjected.Address(Slot = "85")]
	void ADFAAJPBAGA();

	[Cpp2IlInjected.Token(Token = "0x60001C7")]
	[Cpp2IlInjected.Address(Slot = "86")]
	void PEPDJLKNHGG();

	[Cpp2IlInjected.Token(Token = "0x60001C8")]
	[Cpp2IlInjected.Address(Slot = "87")]
	void BIABKHBMFDC(Vector3 LHINOEFCJLG, Vector3 AIMMMFLBCHI);

	[Cpp2IlInjected.Token(Token = "0x60001C9")]
	[Cpp2IlInjected.Address(Slot = "88")]
	void ALEIMOONCKG(Vector3 HGBENCPPIOE, Vector3 EFIALDMFCNH);

	[Cpp2IlInjected.Token(Token = "0x60001CA")]
	[Cpp2IlInjected.Address(Slot = "89")]
	void KDOMADLDDAH(Vector3 AFNABGBDBAH);

	[Cpp2IlInjected.Token(Token = "0x60001CB")]
	[Cpp2IlInjected.Address(Slot = "90")]
	void IKEAFEJHOCH(KOJCHCLAHNC KDAMGPKMFLN, Vector3 NEBBPBIFLLJ, float KKPMGKAMFEJ, float EFDONJDPNKE = 8f, float DCDHDFHOKAE = 1f);

	[Cpp2IlInjected.Token(Token = "0x60001CC")]
	[Cpp2IlInjected.Address(Slot = "91")]
	void DMLNPBGDGBL(NILPLAGMMGI DAFNMKFCJFG, Vector3 LHELLKPPHKL, float FPGCJPGJIBA = float.PositiveInfinity);

	[Cpp2IlInjected.Token(Token = "0x60001CD")]
	[Cpp2IlInjected.Address(Slot = "92")]
	void BFAKGADOJGG(NILPLAGMMGI DAFNMKFCJFG, Vector3 KBKHJHIFKGI, float CGNIOCJOEKL = 7f, float JKANFBIIJHK = 1f);

	[Cpp2IlInjected.Token(Token = "0x60001CE")]
	[Cpp2IlInjected.Address(Slot = "93")]
	Vector3 MLOBKENIFDB(Vector3 EOHMJBFGDPD);

	[Cpp2IlInjected.Token(Token = "0x60001CF")]
	[Cpp2IlInjected.Address(Slot = "94")]
	Vector3 CMHGHFBBNOH(Vector3 EOHMJBFGDPD);

	[Cpp2IlInjected.Token(Token = "0x60001D0")]
	[Cpp2IlInjected.Address(Slot = "95")]
	void PJFHPKDNKCK();

	[Cpp2IlInjected.Token(Token = "0x60001D1")]
	[Cpp2IlInjected.Address(Slot = "96")]
	void PFGLECPGEKC(MGCGGKFMJCL DLHNNAAEEBB, object KJAGMGIFCEM);

	[Cpp2IlInjected.Token(Token = "0x60001D2")]
	[Cpp2IlInjected.Address(Slot = "97")]
	void OLGKOCDKEEG(object KJAGMGIFCEM);

	[Cpp2IlInjected.Token(Token = "0x60001D5")]
	[Cpp2IlInjected.Address(Slot = "100")]
	void FJPECHAAMGI();

	[Cpp2IlInjected.Token(Token = "0x60001D6")]
	[Cpp2IlInjected.Address(Slot = "101")]
	void GGKIHNLFLKG();

	[Cpp2IlInjected.Token(Token = "0x60001D7")]
	[Cpp2IlInjected.Address(Slot = "102")]
	void KOHGBDIONNB();

	[Cpp2IlInjected.Token(Token = "0x60001DA")]
	[Cpp2IlInjected.Address(Slot = "105")]
	bool GBMNOJMBOIA();

	[Cpp2IlInjected.Token(Token = "0x60001DB")]
	[Cpp2IlInjected.Address(Slot = "106")]
	void MALCMJHIFLA();

	[Cpp2IlInjected.Token(Token = "0x60001E0")]
	[Cpp2IlInjected.Address(Slot = "111")]
	IDisposable ODOGLKJIBAL();

	[Cpp2IlInjected.Token(Token = "0x60001E1")]
	[Cpp2IlInjected.Address(Slot = "112")]
	void CLOLFMGHJID(object KJAGMGIFCEM);

	[Cpp2IlInjected.Token(Token = "0x60001E2")]
	[Cpp2IlInjected.Address(Slot = "113")]
	void LAPKPJEEGPL(object KJAGMGIFCEM);

	[Cpp2IlInjected.Token(Token = "0x60001E3")]
	[Cpp2IlInjected.Address(Slot = "114")]
	void EHLACEEGNEA(object KJAGMGIFCEM, bool LLALDMDCIAM);

	[Cpp2IlInjected.Token(Token = "0x60001E6")]
	[Cpp2IlInjected.Address(Slot = "117")]
	void ILDJMOEDAAG(Vector3 NDJBAGILJCL, Quaternion EJDCLAMMOJM);

	[Cpp2IlInjected.Token(Token = "0x60001E7")]
	[Cpp2IlInjected.Address(Slot = "118")]
	void PDHENDLLOPB(Vector3 GLJADFPJOGM, Quaternion FHGOIAIOLGI);

	[Cpp2IlInjected.Token(Token = "0x60001E8")]
	[Cpp2IlInjected.Address(Slot = "119")]
	bool AGIEFONNMMI(float MGOPPJOJBHN);

	[Cpp2IlInjected.Token(Token = "0x60001E9")]
	[Cpp2IlInjected.Address(Slot = "120")]
	void ELHOCJEEJEN(object KJAGMGIFCEM);

	[Cpp2IlInjected.Token(Token = "0x60001EA")]
	[Cpp2IlInjected.Address(Slot = "121")]
	void NMGDEFKJBOC(object KJAGMGIFCEM);

	[Cpp2IlInjected.Token(Token = "0x60001EB")]
	[Cpp2IlInjected.Address(Slot = "122")]
	void CEDEMEPPALB(object KJAGMGIFCEM);

	[Cpp2IlInjected.Token(Token = "0x60001EC")]
	[Cpp2IlInjected.Address(Slot = "123")]
	void MLKIEMGEEPP(object KJAGMGIFCEM);

	[Cpp2IlInjected.Token(Token = "0x60001ED")]
	[Cpp2IlInjected.Address(Slot = "124")]
	void JIEJNNBGOLL(Vector3 EFLODOEECNL, ForceMode ECLMBFBBBLC = ForceMode.Force);

	[Cpp2IlInjected.Token(Token = "0x60001EE")]
	[Cpp2IlInjected.Address(Slot = "125")]
	void DAMOCKENHBN(Vector3 EFLODOEECNL, Vector3 LPAPEIIOLFG, ForceMode ECLMBFBBBLC);

	[Cpp2IlInjected.Token(Token = "0x60001EF")]
	[Cpp2IlInjected.Address(Slot = "126")]
	void IHABFMLHECC(Vector3 DMFFEFOAKAN, ForceMode ECLMBFBBBLC = ForceMode.Force);

	[Cpp2IlInjected.Token(Token = "0x60001F0")]
	[Cpp2IlInjected.Address(Slot = "127")]
	void HBFKEDFPHOF(Vector3 DMFFEFOAKAN, ForceMode ECLMBFBBBLC = ForceMode.Force);

	[Cpp2IlInjected.Token(Token = "0x60001F1")]
	[Cpp2IlInjected.Address(Slot = "128")]
	bool ODAFJKGPNED(Vector3 PIOPMIBANBL, [Out] RaycastHit HMHFDOFNLKF, float EJKOOCGEPCD);

	[Cpp2IlInjected.Token(Token = "0x60001F2")]
	[Cpp2IlInjected.Address(Slot = "129")]
	void GKIFGLBKBIO();
}
[Cpp2IlInjected.Token(Token = "0x2000027")]
public class GAGFBDFNKIL : MGCGGKFMJCL, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400002C")]
	internal readonly HPGKIKLHCAJ GCLFDBLLOOM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400002D")]
	internal DODNAMHPMBE BEOJNJDKKFM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400002E")]
	internal MFDACKEMCFN NKJGAFEKCEK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400002F")]
	internal KHGIDGJJCDM ENOFBOBGGKA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000030")]
	internal DGJKOCOHMGO GKMPFMKFGID;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000031")]
	internal ABHLGLKCJNI BPJLEKADJCG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000032")]
	internal JBNKCGNKKDA GPBEADLBEDA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000033")]
	internal AHDFOHKMEJL FOGDOLBBKEM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000034")]
	internal HOGMIDIDFNH JKGEINHJFDB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x4000035")]
	internal GOILCCLOPLE APAHCCLDBLE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x4000036")]
	internal KKFFFGDLIIM MFJGKJMOCGF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x4000037")]
	internal JNCIBBLAFHG JOIJMPFDHDM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x4000038")]
	internal LDADHEPIIJJ EFLODOEECNL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
	[Cpp2IlInjected.Token(Token = "0x4000039")]
	internal GKGLDPLOLIH MKINJEPMIHP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x400003A")]
	internal NHEPMPNKBHG GEBCPMOBIAB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
	[Cpp2IlInjected.Token(Token = "0x400003B")]
	internal EGPHOJFLGHI LHNJGIDBOHH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
	[Cpp2IlInjected.Token(Token = "0x400003C")]
	internal IDisposable PJCFKLNMKJF;

	[Cpp2IlInjected.Token(Token = "0x17000084")]
	public RigidbodyEx BAOFDDACECK
	{
		[Cpp2IlInjected.Token(Token = "0x60001F3")]
		[Cpp2IlInjected.Address(RVA = "0x75F2C0", Offset = "0x75E6C0", VA = "0x18075F2C0", Slot = "5")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60001F4")]
		[Cpp2IlInjected.Address(RVA = "0x75F240", Offset = "0x75E640", VA = "0x18075F240")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000085")]
	public GameObject EDFMFAADHAF
	{
		[Cpp2IlInjected.Token(Token = "0x60001F5")]
		[Cpp2IlInjected.Address(RVA = "0x8A01E0", Offset = "0x89F5E0", VA = "0x1808A01E0", Slot = "6")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60001F6")]
		[Cpp2IlInjected.Address(RVA = "0x89FD50", Offset = "0x89F150", VA = "0x18089FD50")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000086")]
	public Transform JGKOKOJENGE
	{
		[Cpp2IlInjected.Token(Token = "0x60001F7")]
		[Cpp2IlInjected.Address(RVA = "0x61D36F0", Offset = "0x61D2AF0", VA = "0x1861D36F0", Slot = "7")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000087")]
	public Rigidbody ACNJBLDPNFK
	{
		[Cpp2IlInjected.Token(Token = "0x60001F8")]
		[Cpp2IlInjected.Address(RVA = "0x61D3D70", Offset = "0x61D3170", VA = "0x1861D3D70", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000088")]
	public MGCGGKFMJCL NCEKKJFNJNC
	{
		[Cpp2IlInjected.Token(Token = "0x6000206")]
		[Cpp2IlInjected.Address(RVA = "0x61D15A0", Offset = "0x61D09A0", VA = "0x1861D15A0", Slot = "8")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000207")]
		[Cpp2IlInjected.Address(RVA = "0x61D2BA0", Offset = "0x61D1FA0", VA = "0x1861D2BA0", Slot = "9")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000089")]
	public IReadOnlyList<MGCGGKFMJCL> FCCNECOIHNG
	{
		[Cpp2IlInjected.Token(Token = "0x6000208")]
		[Cpp2IlInjected.Address(RVA = "0x61D16B0", Offset = "0x61D0AB0", VA = "0x1861D16B0", Slot = "10")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700008A")]
	public MGCGGKFMJCL DFDPGOHHPEM
	{
		[Cpp2IlInjected.Token(Token = "0x6000209")]
		[Cpp2IlInjected.Address(RVA = "0x61D1AD0", Offset = "0x61D0ED0", VA = "0x1861D1AD0", Slot = "11")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700008B")]
	public bool EKDOCCFKAGJ
	{
		[Cpp2IlInjected.Token(Token = "0x600020A")]
		[Cpp2IlInjected.Address(RVA = "0x61D24E0", Offset = "0x61D18E0", VA = "0x1861D24E0", Slot = "137")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700008C")]
	public bool FFIFGPLINHH
	{
		[Cpp2IlInjected.Token(Token = "0x600020E")]
		[Cpp2IlInjected.Address(RVA = "0x61D5720", Offset = "0x61D4B20", VA = "0x1861D5720", Slot = "12")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700008D")]
	public bool HAEGEFIPLPF
	{
		[Cpp2IlInjected.Token(Token = "0x600020F")]
		[Cpp2IlInjected.Address(RVA = "0x61D4950", Offset = "0x61D3D50", VA = "0x1861D4950", Slot = "13")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700008E")]
	public JOOBEENEBAA KIPEILJOHEE
	{
		[Cpp2IlInjected.Token(Token = "0x6000210")]
		[Cpp2IlInjected.Address(RVA = "0x61D4480", Offset = "0x61D3880", VA = "0x1861D4480", Slot = "14")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000211")]
		[Cpp2IlInjected.Address(RVA = "0x61D3D10", Offset = "0x61D3110", VA = "0x1861D3D10", Slot = "15")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700008F")]
	public GKFPHOCIOLD BCAAPMKBHAM
	{
		[Cpp2IlInjected.Token(Token = "0x6000212")]
		[Cpp2IlInjected.Address(RVA = "0x61D18A0", Offset = "0x61D0CA0", VA = "0x1861D18A0", Slot = "16")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000213")]
		[Cpp2IlInjected.Address(RVA = "0x61D44D0", Offset = "0x61D38D0", VA = "0x1861D44D0", Slot = "17")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000090")]
	public float IMFCIBCJLIP
	{
		[Cpp2IlInjected.Token(Token = "0x6000214")]
		[Cpp2IlInjected.Address(RVA = "0x61D3A00", Offset = "0x61D2E00", VA = "0x1861D3A00", Slot = "18")]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x6000215")]
		[Cpp2IlInjected.Address(RVA = "0x61D3140", Offset = "0x61D2540", VA = "0x1861D3140", Slot = "19")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000091")]
	public Vector3 GFFGILJCJLF
	{
		[Cpp2IlInjected.Token(Token = "0x6000216")]
		[Cpp2IlInjected.Address(RVA = "0x61D0B20", Offset = "0x61CFF20", VA = "0x1861D0B20", Slot = "20")]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x6000217")]
		[Cpp2IlInjected.Address(RVA = "0x61D1760", Offset = "0x61D0B60", VA = "0x1861D1760", Slot = "21")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000092")]
	public Vector3 ACHPDMPDEGK
	{
		[Cpp2IlInjected.Token(Token = "0x6000218")]
		[Cpp2IlInjected.Address(RVA = "0x61D27A0", Offset = "0x61D1BA0", VA = "0x1861D27A0", Slot = "22")]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x6000219")]
		[Cpp2IlInjected.Address(RVA = "0x61D32F0", Offset = "0x61D26F0", VA = "0x1861D32F0", Slot = "23")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000093")]
	public Vector3 DPFKMNPADOM
	{
		[Cpp2IlInjected.Token(Token = "0x600021A")]
		[Cpp2IlInjected.Address(RVA = "0x61D1050", Offset = "0x61D0450", VA = "0x1861D1050", Slot = "24")]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x600021B")]
		[Cpp2IlInjected.Address(RVA = "0x61D20B0", Offset = "0x61D14B0", VA = "0x1861D20B0", Slot = "25")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000094")]
	public Vector3 IKKGDGHOOEN
	{
		[Cpp2IlInjected.Token(Token = "0x600021C")]
		[Cpp2IlInjected.Address(RVA = "0x61D5210", Offset = "0x61D4610", VA = "0x1861D5210", Slot = "26")]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x600021D")]
		[Cpp2IlInjected.Address(RVA = "0x61D6690", Offset = "0x61D5A90", VA = "0x1861D6690", Slot = "27")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000095")]
	public bool GKKLJMOMONP
	{
		[Cpp2IlInjected.Token(Token = "0x600021E")]
		[Cpp2IlInjected.Address(RVA = "0x61D5D90", Offset = "0x61D5190", VA = "0x1861D5D90", Slot = "138")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000096")]
	public bool GOJPGPEEJCL
	{
		[Cpp2IlInjected.Token(Token = "0x600021F")]
		[Cpp2IlInjected.Address(RVA = "0x61D6420", Offset = "0x61D5820", VA = "0x1861D6420", Slot = "28")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000097")]
	public bool NLCHEOGPMJH
	{
		[Cpp2IlInjected.Token(Token = "0x6000220")]
		[Cpp2IlInjected.Address(RVA = "0x61D2610", Offset = "0x61D1A10", VA = "0x1861D2610", Slot = "29")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000098")]
	public bool NCFBIAMPAHJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000221")]
		[Cpp2IlInjected.Address(RVA = "0x61D5FF0", Offset = "0x61D53F0", VA = "0x1861D5FF0", Slot = "30")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000099")]
	public Vector3 IADJPHPDBGC
	{
		[Cpp2IlInjected.Token(Token = "0x6000232")]
		[Cpp2IlInjected.Address(RVA = "0x61D68D0", Offset = "0x61D5CD0", VA = "0x1861D68D0", Slot = "31")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700009A")]
	public Vector3 FNFHIDNBNCJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000233")]
		[Cpp2IlInjected.Address(RVA = "0x61D1BF0", Offset = "0x61D0FF0", VA = "0x1861D1BF0", Slot = "32")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700009B")]
	public Vector3 NIBENPFEBFL
	{
		[Cpp2IlInjected.Token(Token = "0x6000238")]
		[Cpp2IlInjected.Address(RVA = "0x61D1CD0", Offset = "0x61D10D0", VA = "0x1861D1CD0", Slot = "33")]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x6000239")]
		[Cpp2IlInjected.Address(RVA = "0x61D2D80", Offset = "0x61D2180", VA = "0x1861D2D80", Slot = "34")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700009C")]
	public Vector3 JOKPJCADMPL
	{
		[Cpp2IlInjected.Token(Token = "0x600023A")]
		[Cpp2IlInjected.Address(RVA = "0x61D43A0", Offset = "0x61D37A0", VA = "0x1861D43A0", Slot = "35")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700009D")]
	public float MAMOOAGGOAI
	{
		[Cpp2IlInjected.Token(Token = "0x600023B")]
		[Cpp2IlInjected.Address(RVA = "0x61D5DE0", Offset = "0x61D51E0", VA = "0x1861D5DE0", Slot = "36")]
		get
		{
			return default(float);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700009E")]
	public float AIGIACKFCCL
	{
		[Cpp2IlInjected.Token(Token = "0x600023C")]
		[Cpp2IlInjected.Address(RVA = "0x61D2880", Offset = "0x61D1C80", VA = "0x1861D2880", Slot = "37")]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x600023D")]
		[Cpp2IlInjected.Address(RVA = "0x61D38C0", Offset = "0x61D2CC0", VA = "0x1861D38C0", Slot = "38")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700009F")]
	public Vector3 CAPAJCKGOEI
	{
		[Cpp2IlInjected.Token(Token = "0x600023E")]
		[Cpp2IlInjected.Address(RVA = "0x61D19F0", Offset = "0x61D0DF0", VA = "0x1861D19F0", Slot = "39")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A0")]
	public Quaternion DICIGDCIMAG
	{
		[Cpp2IlInjected.Token(Token = "0x600023F")]
		[Cpp2IlInjected.Address(RVA = "0x61D1B20", Offset = "0x61D0F20", VA = "0x1861D1B20", Slot = "40")]
		get
		{
			return default(Quaternion);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A1")]
	public float FBLHKIOECLM
	{
		[Cpp2IlInjected.Token(Token = "0x6000244")]
		[Cpp2IlInjected.Address(RVA = "0x61D30F0", Offset = "0x61D24F0", VA = "0x1861D30F0", Slot = "42")]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x6000245")]
		[Cpp2IlInjected.Address(RVA = "0x61D59F0", Offset = "0x61D4DF0", VA = "0x1861D59F0", Slot = "43")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A2")]
	public float NNGEGGCECLN
	{
		[Cpp2IlInjected.Token(Token = "0x6000246")]
		[Cpp2IlInjected.Address(RVA = "0x61D3E00", Offset = "0x61D3200", VA = "0x1861D3E00", Slot = "44")]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x6000247")]
		[Cpp2IlInjected.Address(RVA = "0x61D2EA0", Offset = "0x61D22A0", VA = "0x1861D2EA0", Slot = "45")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A3")]
	public bool PLJCHFLJNEH
	{
		[Cpp2IlInjected.Token(Token = "0x6000248")]
		[Cpp2IlInjected.Address(RVA = "0x61D22F0", Offset = "0x61D16F0", VA = "0x1861D22F0", Slot = "46")]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000249")]
		[Cpp2IlInjected.Address(RVA = "0x61D33D0", Offset = "0x61D27D0", VA = "0x1861D33D0", Slot = "47")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A4")]
	public CEAJINAKHIE IJNJIINAHIE
	{
		[Cpp2IlInjected.Token(Token = "0x6000251")]
		[Cpp2IlInjected.Address(RVA = "0x61D0D70", Offset = "0x61D0170", VA = "0x1861D0D70", Slot = "48")]
		get
		{
			return default(CEAJINAKHIE);
		}
		[Cpp2IlInjected.Token(Token = "0x6000252")]
		[Cpp2IlInjected.Address(RVA = "0x61D67C0", Offset = "0x61D5BC0", VA = "0x1861D67C0", Slot = "49")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A5")]
	public bool HCGHILJJDJE
	{
		[Cpp2IlInjected.Token(Token = "0x6000255")]
		[Cpp2IlInjected.Address(RVA = "0x61D2F00", Offset = "0x61D2300", VA = "0x1861D2F00", Slot = "50")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A6")]
	public Transform OEBHBPDHFHA
	{
		[Cpp2IlInjected.Token(Token = "0x600025C")]
		[Cpp2IlInjected.Address(RVA = "0x61D4BF0", Offset = "0x61D3FF0", VA = "0x1861D4BF0", Slot = "51")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A7")]
	public Vector3 BFIMMMNJJEB
	{
		[Cpp2IlInjected.Token(Token = "0x600025D")]
		[Cpp2IlInjected.Address(RVA = "0x61D5A50", Offset = "0x61D4E50", VA = "0x1861D5A50", Slot = "52")]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x600025E")]
		[Cpp2IlInjected.Address(RVA = "0x61D0C00", Offset = "0x61D0000", VA = "0x1861D0C00", Slot = "53")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A8")]
	public float DLDGBIHEMNE
	{
		[Cpp2IlInjected.Token(Token = "0x600025F")]
		[Cpp2IlInjected.Address(RVA = "0x61D3840", Offset = "0x61D2C40", VA = "0x1861D3840", Slot = "54")]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x6000260")]
		[Cpp2IlInjected.Address(RVA = "0x61D5ED0", Offset = "0x61D52D0", VA = "0x1861D5ED0", Slot = "55")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A9")]
	public float LHDFLHMPEDP
	{
		[Cpp2IlInjected.Token(Token = "0x6000261")]
		[Cpp2IlInjected.Address(RVA = "0x61D1130", Offset = "0x61D0530", VA = "0x1861D1130", Slot = "56")]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x6000262")]
		[Cpp2IlInjected.Address(RVA = "0x61D4F70", Offset = "0x61D4370", VA = "0x1861D4F70", Slot = "57")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000AA")]
	public Quaternion EOOPIAMLFFL
	{
		[Cpp2IlInjected.Token(Token = "0x6000263")]
		[Cpp2IlInjected.Address(RVA = "0x61D52F0", Offset = "0x61D46F0", VA = "0x1861D52F0", Slot = "58")]
		get
		{
			return default(Quaternion);
		}
		[Cpp2IlInjected.Token(Token = "0x6000264")]
		[Cpp2IlInjected.Address(RVA = "0x61D5CA0", Offset = "0x61D50A0", VA = "0x1861D5CA0", Slot = "59")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000AB")]
	public Vector3 MKJKOHNLCOL
	{
		[Cpp2IlInjected.Token(Token = "0x6000265")]
		[Cpp2IlInjected.Address(RVA = "0x61D0DC0", Offset = "0x61D01C0", VA = "0x1861D0DC0", Slot = "60")]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x6000266")]
		[Cpp2IlInjected.Address(RVA = "0x61D3E50", Offset = "0x61D3250", VA = "0x1861D3E50", Slot = "61")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000AC")]
	public Quaternion OIFBJHBHDIL
	{
		[Cpp2IlInjected.Token(Token = "0x6000267")]
		[Cpp2IlInjected.Address(RVA = "0x61D3DC0", Offset = "0x61D31C0", VA = "0x1861D3DC0", Slot = "62")]
		get
		{
			return default(Quaternion);
		}
		[Cpp2IlInjected.Token(Token = "0x6000268")]
		[Cpp2IlInjected.Address(RVA = "0x61D2E60", Offset = "0x61D2260", VA = "0x1861D2E60", Slot = "63")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000AD")]
	public RigidbodyConstraints IEOPINFGGLF
	{
		[Cpp2IlInjected.Token(Token = "0x600026C")]
		[Cpp2IlInjected.Address(RVA = "0x61D11F0", Offset = "0x61D05F0", VA = "0x1861D11F0", Slot = "64")]
		get
		{
			return default(RigidbodyConstraints);
		}
		[Cpp2IlInjected.Token(Token = "0x600026D")]
		[Cpp2IlInjected.Address(RVA = "0x61D1F80", Offset = "0x61D1380", VA = "0x1861D1F80", Slot = "65")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000AE")]
	public bool PBOGKFDNBGB
	{
		[Cpp2IlInjected.Token(Token = "0x600026E")]
		[Cpp2IlInjected.Address(RVA = "0x61D58D0", Offset = "0x61D4CD0", VA = "0x1861D58D0", Slot = "66")]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x600026F")]
		[Cpp2IlInjected.Address(RVA = "0x61D0E10", Offset = "0x61D0210", VA = "0x1861D0E10", Slot = "67")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000AF")]
	public CollisionDetectionMode GDLPEHNGKFD
	{
		[Cpp2IlInjected.Token(Token = "0x6000278")]
		[Cpp2IlInjected.Address(RVA = "0x61D5450", Offset = "0x61D4850", VA = "0x1861D5450", Slot = "68")]
		get
		{
			return default(CollisionDetectionMode);
		}
		[Cpp2IlInjected.Token(Token = "0x6000279")]
		[Cpp2IlInjected.Address(RVA = "0x61D37E0", Offset = "0x61D2BE0", VA = "0x1861D37E0", Slot = "69")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B0")]
	public bool DAKPPPOBNBC
	{
		[Cpp2IlInjected.Token(Token = "0x600027B")]
		[Cpp2IlInjected.Address(RVA = "0x61D50D0", Offset = "0x61D44D0", VA = "0x1861D50D0", Slot = "139")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B1")]
	public bool CBOGMEEBBPL
	{
		[Cpp2IlInjected.Token(Token = "0x600027C")]
		[Cpp2IlInjected.Address(RVA = "0x61D29B0", Offset = "0x61D1DB0", VA = "0x1861D29B0", Slot = "70")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B2")]
	public bool AIMHBJAIIBD
	{
		[Cpp2IlInjected.Token(Token = "0x600027D")]
		[Cpp2IlInjected.Address(RVA = "0x61D0E70", Offset = "0x61D0270", VA = "0x1861D0E70")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B3")]
	public bool JJHKEOCLKCA
	{
		[Cpp2IlInjected.Token(Token = "0x600027E")]
		[Cpp2IlInjected.Address(RVA = "0x61D6040", Offset = "0x61D5440", VA = "0x1861D6040")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000021")]
	public event LNNBFANOADD ELBIILPLBLJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000200")]
		[Cpp2IlInjected.Address(RVA = "0x61D5070", Offset = "0x61D4470", VA = "0x1861D5070", Slot = "75")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000201")]
		[Cpp2IlInjected.Address(RVA = "0x61D3780", Offset = "0x61D2B80", VA = "0x1861D3780", Slot = "76")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000022")]
	public event LNNBFANOADD CBNGEFCLMOB
	{
		[Cpp2IlInjected.Token(Token = "0x6000202")]
		[Cpp2IlInjected.Address(RVA = "0x61D1EC0", Offset = "0x61D12C0", VA = "0x1861D1EC0", Slot = "77")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000203")]
		[Cpp2IlInjected.Address(RVA = "0x61D1F20", Offset = "0x61D1320", VA = "0x1861D1F20", Slot = "78")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000023")]
	public event OKIHMFHNBGG IACLPHDLFGN
	{
		[Cpp2IlInjected.Token(Token = "0x6000204")]
		[Cpp2IlInjected.Address(RVA = "0x61D5F40", Offset = "0x61D5340", VA = "0x1861D5F40", Slot = "79")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000205")]
		[Cpp2IlInjected.Address(RVA = "0x61D53F0", Offset = "0x61D47F0", VA = "0x1861D53F0", Slot = "80")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000024")]
	public event LNNBFANOADD PLAFGMCIMLA
	{
		[Cpp2IlInjected.Token(Token = "0x600020C")]
		[Cpp2IlInjected.Address(RVA = "0x61D5660", Offset = "0x61D4A60", VA = "0x1861D5660", Slot = "82")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600020D")]
		[Cpp2IlInjected.Address(RVA = "0x61D1540", Offset = "0x61D0940", VA = "0x1861D1540", Slot = "83")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000025")]
	public event LNNBFANOADD LCEOKOPJBNC
	{
		[Cpp2IlInjected.Token(Token = "0x6000236")]
		[Cpp2IlInjected.Address(RVA = "0x61D1650", Offset = "0x61D0A50", VA = "0x1861D1650", Slot = "102")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000237")]
		[Cpp2IlInjected.Address(RVA = "0x61D56C0", Offset = "0x61D4AC0", VA = "0x1861D56C0", Slot = "103")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000026")]
	public event LNNBFANOADD JKEEEOMBIDH
	{
		[Cpp2IlInjected.Token(Token = "0x600024A")]
		[Cpp2IlInjected.Address(RVA = "0x61D2D20", Offset = "0x61D2120", VA = "0x1861D2D20", Slot = "107")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600024B")]
		[Cpp2IlInjected.Address(RVA = "0x61D2CC0", Offset = "0x61D20C0", VA = "0x1861D2CC0", Slot = "108")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000027")]
	public event Action<ADKLLFONPNJ, ADKLLFONPNJ> IEAAAMEAGPG
	{
		[Cpp2IlInjected.Token(Token = "0x600024F")]
		[Cpp2IlInjected.Address(RVA = "0x61D60D0", Offset = "0x61D54D0", VA = "0x1861D60D0", Slot = "111")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000250")]
		[Cpp2IlInjected.Address(RVA = "0x61D2C00", Offset = "0x61D2000", VA = "0x1861D2C00", Slot = "112")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000028")]
	public event LNNBFANOADD OMDOLGBKNMB
	{
		[Cpp2IlInjected.Token(Token = "0x6000253")]
		[Cpp2IlInjected.Address(RVA = "0x61D3860", Offset = "0x61D2C60", VA = "0x1861D3860", Slot = "113")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000254")]
		[Cpp2IlInjected.Address(RVA = "0x61D13F0", Offset = "0x61D07F0", VA = "0x1861D13F0", Slot = "114")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000029")]
	public event LNNBFANOADD OKPCAHNBDOG
	{
		[Cpp2IlInjected.Token(Token = "0x600025A")]
		[Cpp2IlInjected.Address(RVA = "0x61D4750", Offset = "0x61D3B50", VA = "0x1861D4750", Slot = "119")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600025B")]
		[Cpp2IlInjected.Address(RVA = "0x61D6820", Offset = "0x61D5C20", VA = "0x1861D6820", Slot = "120")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001F9")]
	[Cpp2IlInjected.Address(RVA = "0x61D69E0", Offset = "0x61D5DE0", VA = "0x1861D69E0")]
	public GAGFBDFNKIL(GameObject IPAGFDLNMDK, RigidbodyEx AMNEOLIHGBG, HPGKIKLHCAJ GCLFDBLLOOM, [In] MCODEJBAGCN GHFAAPNAFDE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001FA")]
	[Cpp2IlInjected.Address(RVA = "0x61D6130", Offset = "0x61D5530", VA = "0x1861D6130", Slot = "135")]
	protected virtual void PCLCNIGBNMN(HPGKIKLHCAJ GCLFDBLLOOM, MCODEJBAGCN GHFAAPNAFDE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001FB")]
	[Cpp2IlInjected.Address(RVA = "0x61D2540", Offset = "0x61D1940", VA = "0x1861D2540", Slot = "136")]
	public virtual void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001FC")]
	[Cpp2IlInjected.Address(RVA = "0x61D4530", Offset = "0x61D3930", VA = "0x1861D4530", Slot = "71")]
	public void JHKGOCECMOM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001FD")]
	[Cpp2IlInjected.Address(RVA = "0x61D1000", Offset = "0x61D0400", VA = "0x1861D1000", Slot = "72")]
	public void ANCCAJMPGEI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001FE")]
	[Cpp2IlInjected.Address(RVA = "0x61D48E0", Offset = "0x61D3CE0", VA = "0x1861D48E0", Slot = "73")]
	public void KNFPAGAHPOH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001FF")]
	[Cpp2IlInjected.Address(RVA = "0x61D26F0", Offset = "0x61D1AF0", VA = "0x1861D26F0")]
	private void EDDEBJBIJLH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600020B")]
	[Cpp2IlInjected.Address(RVA = "0x61D3680", Offset = "0x61D2A80", VA = "0x1861D3680", Slot = "81")]
	public void HEBPNKMJKGE(MGCGGKFMJCL EOHMJBFGDPD, bool ABHJANDGLGK = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000222")]
	[Cpp2IlInjected.Address(RVA = "0x61D15F0", Offset = "0x61D09F0", VA = "0x1861D15F0", Slot = "84")]
	public void BLMOJFOIDMP(object KJAGMGIFCEM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000223")]
	[Cpp2IlInjected.Address(RVA = "0x61D5B00", Offset = "0x61D4F00", VA = "0x1861D5B00", Slot = "85")]
	public void NJMHFKGMAOA(object KJAGMGIFCEM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000224")]
	[Cpp2IlInjected.Address(RVA = "0x61D2FA0", Offset = "0x61D23A0", VA = "0x1861D2FA0", Slot = "86")]
	public Vector3 FLADNKLALKJ(Vector3 NDMBMJJIOFA)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000225")]
	[Cpp2IlInjected.Address(RVA = "0x61D2340", Offset = "0x61D1740", VA = "0x1861D2340", Slot = "87")]
	public Vector3 DMBNKHGFCEB(Vector3 EKHMFCCFGPL)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000226")]
	[Cpp2IlInjected.Address(RVA = "0x61D1000", Offset = "0x61D0400", VA = "0x1861D1000", Slot = "88")]
	public void CPOFEOBDKHH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000227")]
	[Cpp2IlInjected.Address(RVA = "0x61D0CC0", Offset = "0x61D00C0", VA = "0x1861D0CC0", Slot = "89")]
	public void ADFAAJPBAGA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000228")]
	[Cpp2IlInjected.Address(RVA = "0x61D65D0", Offset = "0x61D59D0", VA = "0x1861D65D0", Slot = "90")]
	public void PEPDJLKNHGG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000229")]
	[Cpp2IlInjected.Address(RVA = "0x61D1450", Offset = "0x61D0850", VA = "0x1861D1450", Slot = "91")]
	public void BIABKHBMFDC(Vector3 LHINOEFCJLG, Vector3 AIMMMFLBCHI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600022A")]
	[Cpp2IlInjected.Address(RVA = "0x61D0F10", Offset = "0x61D0310", VA = "0x1861D0F10", Slot = "92")]
	public void ALEIMOONCKG(Vector3 HGBENCPPIOE, Vector3 EFIALDMFCNH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600022B")]
	[Cpp2IlInjected.Address(RVA = "0x61D4800", Offset = "0x61D3C00", VA = "0x1861D4800", Slot = "93")]
	public void KDOMADLDDAH(Vector3 AFNABGBDBAH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600022C")]
	[Cpp2IlInjected.Address(RVA = "0x61D3A50", Offset = "0x61D2E50", VA = "0x1861D3A50", Slot = "94")]
	public void IKEAFEJHOCH(KOJCHCLAHNC KDAMGPKMFLN, Vector3 NEBBPBIFLLJ, float KKPMGKAMFEJ, float EFDONJDPNKE = 8f, float DCDHDFHOKAE = 1f)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600022D")]
	[Cpp2IlInjected.Address(RVA = "0x61D2440", Offset = "0x61D1840", VA = "0x1861D2440", Slot = "95")]
	public void DMLNPBGDGBL(NILPLAGMMGI DAFNMKFCJFG, Vector3 LHELLKPPHKL, float FPGCJPGJIBA = float.PositiveInfinity)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600022E")]
	[Cpp2IlInjected.Address(RVA = "0x61D1340", Offset = "0x61D0740", VA = "0x1861D1340", Slot = "96")]
	[Obsolete("Deprecated. Still exists to support deprecated CV2 chips. Use ApplyAngularVelocityChange.")]
	public void BFAKGADOJGG(NILPLAGMMGI DAFNMKFCJFG, Vector3 KBKHJHIFKGI, float CGNIOCJOEKL = 7f, float JKANFBIIJHK = 1f)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600022F")]
	[Cpp2IlInjected.Address(RVA = "0x61D57D0", Offset = "0x61D4BD0", VA = "0x1861D57D0", Slot = "97")]
	public Vector3 MLOBKENIFDB(Vector3 EOHMJBFGDPD)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000230")]
	[Cpp2IlInjected.Address(RVA = "0x61D18F0", Offset = "0x61D0CF0", VA = "0x1861D18F0", Slot = "98")]
	public Vector3 CMHGHFBBNOH(Vector3 EOHMJBFGDPD)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000231")]
	[Cpp2IlInjected.Address(RVA = "0x61D6770", Offset = "0x61D5B70", VA = "0x1861D6770", Slot = "99")]
	public void PJFHPKDNKCK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000234")]
	[Cpp2IlInjected.Address(RVA = "0x61D6620", Offset = "0x61D5A20", VA = "0x1861D6620", Slot = "100")]
	public void PFGLECPGEKC(MGCGGKFMJCL DLHNNAAEEBB, object KJAGMGIFCEM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000235")]
	[Cpp2IlInjected.Address(RVA = "0x61D6070", Offset = "0x61D5470", VA = "0x1861D6070", Slot = "101")]
	public void OLGKOCDKEEG(object KJAGMGIFCEM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000240")]
	[Cpp2IlInjected.Address(RVA = "0x61D28D0", Offset = "0x61D1CD0", VA = "0x1861D28D0", Slot = "41")]
	public void EEEEBLADLHM((Quaternion rot, Vector3 moments) NCNIHGBNECM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000241")]
	[Cpp2IlInjected.Address(RVA = "0x61D2F50", Offset = "0x61D2350", VA = "0x1861D2F50", Slot = "104")]
	public void FJPECHAAMGI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000242")]
	[Cpp2IlInjected.Address(RVA = "0x61D3250", Offset = "0x61D2650", VA = "0x1861D3250", Slot = "105")]
	public void GGKIHNLFLKG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000243")]
	[Cpp2IlInjected.Address(RVA = "0x61D4900", Offset = "0x61D3D00", VA = "0x1861D4900", Slot = "106")]
	public void KOHGBDIONNB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600024C")]
	[Cpp2IlInjected.Address(RVA = "0x61D30A0", Offset = "0x61D24A0", VA = "0x1861D30A0", Slot = "109")]
	public bool GBMNOJMBOIA()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600024D")]
	[Cpp2IlInjected.Address(RVA = "0x61D22A0", Offset = "0x61D16A0", VA = "0x1861D22A0", Slot = "74")]
	public void DKHDPIPGLAN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600024E")]
	[Cpp2IlInjected.Address(RVA = "0x61D53A0", Offset = "0x61D47A0", VA = "0x1861D53A0", Slot = "110")]
	public void MALCMJHIFLA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000256")]
	[Cpp2IlInjected.Address(RVA = "0x61D5FA0", Offset = "0x61D53A0", VA = "0x1861D5FA0", Slot = "115")]
	public IDisposable ODOGLKJIBAL()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000257")]
	[Cpp2IlInjected.Address(RVA = "0x61D1840", Offset = "0x61D0C40", VA = "0x1861D1840", Slot = "116")]
	public void CLOLFMGHJID(object KJAGMGIFCEM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000258")]
	[Cpp2IlInjected.Address(RVA = "0x61D49A0", Offset = "0x61D3DA0", VA = "0x1861D49A0", Slot = "117")]
	public void LAPKPJEEGPL(object KJAGMGIFCEM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000259")]
	[Cpp2IlInjected.Address(RVA = "0x61D2B30", Offset = "0x61D1F30", VA = "0x1861D2B30", Slot = "118")]
	public void EHLACEEGNEA(object KJAGMGIFCEM, bool LLALDMDCIAM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000269")]
	[Cpp2IlInjected.Address(RVA = "0x61D3B10", Offset = "0x61D2F10", VA = "0x1861D3B10", Slot = "121")]
	public void ILDJMOEDAAG(Vector3 NDJBAGILJCL, Quaternion EJDCLAMMOJM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600026A")]
	[Cpp2IlInjected.Address(RVA = "0x61D6480", Offset = "0x61D5880", VA = "0x1861D6480", Slot = "122")]
	public void PDHENDLLOPB(Vector3 GLJADFPJOGM, Quaternion FHGOIAIOLGI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600026B")]
	[Cpp2IlInjected.Address(RVA = "0x61D0D10", Offset = "0x61D0110", VA = "0x1861D0D10", Slot = "123")]
	public bool AGIEFONNMMI(float MGOPPJOJBHN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000270")]
	[Cpp2IlInjected.Address(RVA = "0x61D2C60", Offset = "0x61D2060", VA = "0x1861D2C60", Slot = "124")]
	public void ELHOCJEEJEN(object KJAGMGIFCEM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000271")]
	[Cpp2IlInjected.Address(RVA = "0x61D5C40", Offset = "0x61D5040", VA = "0x1861D5C40", Slot = "125")]
	public void NMGDEFKJBOC(object KJAGMGIFCEM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000272")]
	[Cpp2IlInjected.Address(RVA = "0x61D1700", Offset = "0x61D0B00", VA = "0x1861D1700", Slot = "126")]
	public void CEDEMEPPALB(object KJAGMGIFCEM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000273")]
	[Cpp2IlInjected.Address(RVA = "0x61D5770", Offset = "0x61D4B70", VA = "0x1861D5770", Slot = "127")]
	public void MLKIEMGEEPP(object KJAGMGIFCEM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000274")]
	[Cpp2IlInjected.Address(RVA = "0x61D4670", Offset = "0x61D3A70", VA = "0x1861D4670", Slot = "128")]
	public void JIEJNNBGOLL(Vector3 EFLODOEECNL, ForceMode ECLMBFBBBLC = ForceMode.Force)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000275")]
	[Cpp2IlInjected.Address(RVA = "0x61D1DB0", Offset = "0x61D11B0", VA = "0x1861D1DB0", Slot = "129")]
	public void DAMOCKENHBN(Vector3 EFLODOEECNL, Vector3 LPAPEIIOLFG, ForceMode ECLMBFBBBLC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000276")]
	[Cpp2IlInjected.Address(RVA = "0x61D3920", Offset = "0x61D2D20", VA = "0x1861D3920", Slot = "130")]
	public void IHABFMLHECC(Vector3 DMFFEFOAKAN, ForceMode ECLMBFBBBLC = ForceMode.Force)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000277")]
	[Cpp2IlInjected.Address(RVA = "0x61D35A0", Offset = "0x61D29A0", VA = "0x1861D35A0", Slot = "131")]
	public void HBFKEDFPHOF(Vector3 DMFFEFOAKAN, ForceMode ECLMBFBBBLC = ForceMode.Force)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600027A")]
	[Cpp2IlInjected.Address(RVA = "0x61D5E30", Offset = "0x61D5230", VA = "0x1861D5E30", Slot = "132")]
	public bool ODAFJKGPNED(Vector3 PIOPMIBANBL, [Out] RaycastHit HMHFDOFNLKF, float EJKOOCGEPCD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600027F")]
	[Cpp2IlInjected.Address(RVA = "0x61D32A0", Offset = "0x61D26A0", VA = "0x1861D32A0", Slot = "133")]
	public void GKIFGLBKBIO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000280")]
	[Cpp2IlInjected.Address(RVA = "0x61D69A0", Offset = "0x61D5DA0", VA = "0x1861D69A0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000281")]
	[Cpp2IlInjected.Address(RVA = "0x61D5B60", Offset = "0x61D4F60", VA = "0x1861D5B60")]
	private void NKCGICGHEGO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000282")]
	[Cpp2IlInjected.Address(RVA = "0x61D2190", Offset = "0x61D1590", VA = "0x1861D2190")]
	private void DHIGCBJBOFO(MGCGGKFMJCL EBFCMPBKGBM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000283")]
	[Cpp2IlInjected.Address(RVA = "0x61D4A00", Offset = "0x61D3E00", VA = "0x1861D4A00")]
	private void LBMJPCLFBCE(MGCGGKFMJCL EBFCMPBKGBM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000284")]
	[Cpp2IlInjected.Address(RVA = "0x61D31A0", Offset = "0x61D25A0", VA = "0x1861D31A0")]
	private void GGHICJDNAHB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000285")]
	[Cpp2IlInjected.Address(RVA = "0x61D1240", Offset = "0x61D0640", VA = "0x1861D1240")]
	private void BENCOJBOFAJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000286")]
	[Cpp2IlInjected.Address(RVA = "0x61D41C0", Offset = "0x61D35C0", VA = "0x1861D41C0")]
	private void JEONMFACECB(MGCGGKFMJCL OCLMFMCHMIF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000287")]
	[Cpp2IlInjected.Address(RVA = "0x61D5920", Offset = "0x61D4D20", VA = "0x1861D5920")]
	private void NBPCMILFJNH(MGCGGKFMJCL EBFCMPBKGBM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000288")]
	[Cpp2IlInjected.Address(RVA = "0x61D1FE0", Offset = "0x61D13E0", VA = "0x1861D1FE0")]
	private void DEJHAKKIFOI(MGCGGKFMJCL EBFCMPBKGBM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000289")]
	[Cpp2IlInjected.Address(RVA = "0x61D3430", Offset = "0x61D2830", VA = "0x1861D3430")]
	private void HBEFIONOMDA(RigidbodyEx EBFCMPBKGBM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600028A")]
	[Cpp2IlInjected.Address(RVA = "0x61D54A0", Offset = "0x61D48A0", VA = "0x1861D54A0", Slot = "140")]
	protected virtual void MEPJJFMJFNH(RigidbodyEx GOCPNHJEOMK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600028B")]
	[Cpp2IlInjected.Address(RVA = "0x61D3EA0", Offset = "0x61D32A0", VA = "0x1861D3EA0")]
	protected void JDDHNBJLOPJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600028C")]
	[Cpp2IlInjected.Address(RVA = "0x61D4C00", Offset = "0x61D4000", VA = "0x1861D4C00")]
	protected void LEEFLCEAOIL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600028D")]
	[Cpp2IlInjected.Address(RVA = "0x61D1150", Offset = "0x61D0550", VA = "0x1861D1150", Slot = "141")]
	protected virtual IDisposable BDPKCANAMIG()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000028")]
internal static class GAOFHCBNCJC
{
	[Cpp2IlInjected.Token(Token = "0x600028E")]
	[Cpp2IlInjected.Address(RVA = "0x61D6B00", Offset = "0x61D5F00", VA = "0x1861D6B00")]
	public static MGCGGKFMJCL CCABLJKDLEH(this MGCGGKFMJCL GOCPNHJEOMK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600028F")]
	[Cpp2IlInjected.Address(RVA = "0x61D6C30", Offset = "0x61D6030", VA = "0x1861D6C30")]
	public static bool HFILNMMEHPM(this MGCGGKFMJCL GOCPNHJEOMK, MGCGGKFMJCL GHGIFLPNPKP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000290")]
	[Cpp2IlInjected.Address(RVA = "0x61D6BB0", Offset = "0x61D5FB0", VA = "0x1861D6BB0")]
	public static bool FOFIAOAJGMH(this MGCGGKFMJCL GOCPNHJEOMK, MGCGGKFMJCL FLFMJFFANNH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000291")]
	[Cpp2IlInjected.Address(RVA = "0x61D6AB0", Offset = "0x61D5EB0", VA = "0x1861D6AB0")]
	public static RigidbodyEx BAOFDDACECK(this MGCGGKFMJCL GHKHAMLBHKF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000292")]
	[Cpp2IlInjected.Address(RVA = "0x61D6CB0", Offset = "0x61D60B0", VA = "0x1861D6CB0")]
	public static GAGFBDFNKIL LLBAOIMAKMH(this MGCGGKFMJCL MPPIIABEOMK)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000029")]
internal class CCKPNLNDILA : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000040")]
	private readonly GAGFBDFNKIL GOCPNHJEOMK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000041")]
	private bool EJHKEMCAIJC;

	[Cpp2IlInjected.Token(Token = "0x6000293")]
	[Cpp2IlInjected.Address(RVA = "0x61C8210", Offset = "0x61C7610", VA = "0x1861C8210")]
	public CCKPNLNDILA(GAGFBDFNKIL LNNNOJDNMEH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000294")]
	[Cpp2IlInjected.Address(RVA = "0x61C81B0", Offset = "0x61C75B0", VA = "0x1861C81B0", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002A")]
internal sealed class LPEDOLOJBAL : KDPLDJDIMLC, EGPHOJFLGHI
{
	[Cpp2IlInjected.Token(Token = "0x170000B4")]
	private CollisionDetectionMode BOKEHDCPHAM
	{
		[Cpp2IlInjected.Token(Token = "0x6000296")]
		[Cpp2IlInjected.Address(RVA = "0x61E0D20", Offset = "0x61E0120", VA = "0x1861E0D20")]
		get
		{
			return default(CollisionDetectionMode);
		}
		[Cpp2IlInjected.Token(Token = "0x6000297")]
		[Cpp2IlInjected.Address(RVA = "0x61E0E60", Offset = "0x61E0260", VA = "0x1861E0E60")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B5")]
	private Rigidbody ACNJBLDPNFK
	{
		[Cpp2IlInjected.Token(Token = "0x6000298")]
		[Cpp2IlInjected.Address(RVA = "0x61C05B0", Offset = "0x61BF9B0", VA = "0x1861C05B0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B6")]
	public CollisionDetectionMode GDLPEHNGKFD
	{
		[Cpp2IlInjected.Token(Token = "0x600029B")]
		[Cpp2IlInjected.Address(RVA = "0x61E1030", Offset = "0x61E0430", VA = "0x1861E1030", Slot = "4")]
		get
		{
			return default(CollisionDetectionMode);
		}
		[Cpp2IlInjected.Token(Token = "0x600029C")]
		[Cpp2IlInjected.Address(RVA = "0x61E0C60", Offset = "0x61E0060", VA = "0x1861E0C60", Slot = "5")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000295")]
	[Cpp2IlInjected.Address(RVA = "0x61C4630", Offset = "0x61C3A30", VA = "0x1861C4630")]
	public LPEDOLOJBAL(MGCGGKFMJCL GOCPNHJEOMK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000299")]
	[Cpp2IlInjected.Address(RVA = "0x61E0ED0", Offset = "0x61E02D0", VA = "0x1861E0ED0", Slot = "6")]
	public void JHKGOCECMOM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600029A")]
	[Cpp2IlInjected.Address(RVA = "0x61E0D80", Offset = "0x61E0180", VA = "0x1861E0D80", Slot = "9")]
	public void INHOGFJCLDO(Rigidbody GEBCPMOBIAB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600029D")]
	[Cpp2IlInjected.Address(RVA = "0x61E1020", Offset = "0x61E0420", VA = "0x1861E1020", Slot = "7")]
	public void KFCPEKBBFHO(bool EDKKJDCOKAE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600029E")]
	[Cpp2IlInjected.Address(RVA = "0x61E0C50", Offset = "0x61E0050", VA = "0x1861E0C50", Slot = "8")]
	public void AIOGIJPDAML(bool EDKKJDCOKAE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600029F")]
	[Cpp2IlInjected.Address(RVA = "0x61E12B0", Offset = "0x61E06B0", VA = "0x1861E12B0", Slot = "10")]
	public bool ODAFJKGPNED(Vector3 PIOPMIBANBL, [Out] RaycastHit HMHFDOFNLKF, float EJKOOCGEPCD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002A0")]
	[Cpp2IlInjected.Address(RVA = "0x61E1140", Offset = "0x61E0540", VA = "0x1861E1140")]
	private void NOPCCBDHDEG(bool EDKKJDCOKAE)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002B")]
internal sealed class DCEKFLDAKHE : KDPLDJDIMLC, KKFFFGDLIIM, IDisposable, AOCMGNBNDFN
{
	[Cpp2IlInjected.Token(Token = "0x170000B7")]
	public CEAJINAKHIE KCOBMLEELIP
	{
		[Cpp2IlInjected.Token(Token = "0x60002A4")]
		[Cpp2IlInjected.Address(RVA = "0x61C90E0", Offset = "0x61C84E0", VA = "0x1861C90E0")]
		get
		{
			return default(CEAJINAKHIE);
		}
		[Cpp2IlInjected.Token(Token = "0x60002A5")]
		[Cpp2IlInjected.Address(RVA = "0x61C8FF0", Offset = "0x61C83F0", VA = "0x1861C8FF0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B8")]
	public CEAJINAKHIE IJNJIINAHIE
	{
		[Cpp2IlInjected.Token(Token = "0x60002A6")]
		[Cpp2IlInjected.Address(RVA = "0x61C8D40", Offset = "0x61C8140", VA = "0x1861C8D40", Slot = "6")]
		get
		{
			return default(CEAJINAKHIE);
		}
		[Cpp2IlInjected.Token(Token = "0x60002A7")]
		[Cpp2IlInjected.Address(RVA = "0x61C8FF0", Offset = "0x61C83F0", VA = "0x1861C8FF0", Slot = "7")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B9")]
	private Transform ANFMPJKHDJI
	{
		[Cpp2IlInjected.Token(Token = "0x60002AC")]
		[Cpp2IlInjected.Address(RVA = "0x75E5C0", Offset = "0x75D9C0", VA = "0x18075E5C0", Slot = "10")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400002A")]
	public event Action<ADKLLFONPNJ, ADKLLFONPNJ> IEAAAMEAGPG
	{
		[Cpp2IlInjected.Token(Token = "0x60002A2")]
		[Cpp2IlInjected.Address(RVA = "0x61C91C0", Offset = "0x61C85C0", VA = "0x1861C91C0", Slot = "4")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60002A3")]
		[Cpp2IlInjected.Address(RVA = "0x61C8F40", Offset = "0x61C8340", VA = "0x1861C8F40", Slot = "5")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60002A1")]
	[Cpp2IlInjected.Address(RVA = "0x61C4630", Offset = "0x61C3A30", VA = "0x1861C4630")]
	public DCEKFLDAKHE(MGCGGKFMJCL GOCPNHJEOMK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002A8")]
	[Cpp2IlInjected.Address(RVA = "0x61C9270", Offset = "0x61C8670", VA = "0x1861C9270", Slot = "11")]
	public void OnChangedDistanceBand(ADKLLFONPNJ DIPNGLKFBLA, ADKLLFONPNJ GBMOELLOINK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002A9")]
	[Cpp2IlInjected.Address(RVA = "0x75E5B0", Offset = "0x75D9B0", VA = "0x18075E5B0", Slot = "12")]
	public void OnChangedVisibility(bool IGHHIFPBDLK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002AA")]
	[Cpp2IlInjected.Address(RVA = "0x75E5B0", Offset = "0x75D9B0", VA = "0x18075E5B0", Slot = "8")]
	public void JHKGOCECMOM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002AB")]
	[Cpp2IlInjected.Address(RVA = "0x75E5B0", Offset = "0x75D9B0", VA = "0x18075E5B0", Slot = "9")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002C")]
internal sealed class GIHEEJNKNKO : KDPLDJDIMLC, LDADHEPIIJJ
{
	[Cpp2IlInjected.Token(Token = "0x170000BA")]
	private Rigidbody ACNJBLDPNFK
	{
		[Cpp2IlInjected.Token(Token = "0x60002AE")]
		[Cpp2IlInjected.Address(RVA = "0x61C05B0", Offset = "0x61BF9B0", VA = "0x1861C05B0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000BB")]
	private bool HCGHILJJDJE
	{
		[Cpp2IlInjected.Token(Token = "0x60002AF")]
		[Cpp2IlInjected.Address(RVA = "0x61C9910", Offset = "0x61C8D10", VA = "0x1861C9910")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000BC")]
	private bool EKDOCCFKAGJ
	{
		[Cpp2IlInjected.Token(Token = "0x60002B0")]
		[Cpp2IlInjected.Address(RVA = "0x61C98B0", Offset = "0x61C8CB0", VA = "0x1861C98B0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000BD")]
	private MGCGGKFMJCL NCEKKJFNJNC
	{
		[Cpp2IlInjected.Token(Token = "0x60002B1")]
		[Cpp2IlInjected.Address(RVA = "0x61D7270", Offset = "0x61D6670", VA = "0x1861D7270")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60002AD")]
	[Cpp2IlInjected.Address(RVA = "0x61C4630", Offset = "0x61C3A30", VA = "0x1861C4630")]
	public GIHEEJNKNKO(MGCGGKFMJCL GOCPNHJEOMK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002B2")]
	[Cpp2IlInjected.Address(RVA = "0x61D7BF0", Offset = "0x61D6FF0", VA = "0x1861D7BF0", Slot = "4")]
	public void JIEJNNBGOLL(Vector3 EFLODOEECNL, ForceMode ECLMBFBBBLC = ForceMode.Force)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002B3")]
	[Cpp2IlInjected.Address(RVA = "0x61D7910", Offset = "0x61D6D10", VA = "0x1861D7910")]
	private void JFFHCOICFAF(Vector3 EFLODOEECNL, ForceMode ECLMBFBBBLC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002B4")]
	[Cpp2IlInjected.Address(RVA = "0x61D72D0", Offset = "0x61D66D0", VA = "0x1861D72D0", Slot = "5")]
	public void DAMOCKENHBN(Vector3 EFLODOEECNL, Vector3 LPAPEIIOLFG, ForceMode ECLMBFBBBLC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002B5")]
	[Cpp2IlInjected.Address(RVA = "0x61D77B0", Offset = "0x61D6BB0", VA = "0x1861D77B0", Slot = "6")]
	public void IHABFMLHECC(Vector3 DMFFEFOAKAN, ForceMode ECLMBFBBBLC = ForceMode.Force)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002B6")]
	[Cpp2IlInjected.Address(RVA = "0x61D7D50", Offset = "0x61D7150", VA = "0x1861D7D50")]
	private void OKDFPLMECAA(Vector3 DMFFEFOAKAN, ForceMode ECLMBFBBBLC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002B7")]
	[Cpp2IlInjected.Address(RVA = "0x61D7550", Offset = "0x61D6950", VA = "0x1861D7550", Slot = "7")]
	public void HBFKEDFPHOF(Vector3 DMFFEFOAKAN, ForceMode ECLMBFBBBLC = ForceMode.Force)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002B8")]
	[Cpp2IlInjected.Address(RVA = "0x61D7FB0", Offset = "0x61D73B0", VA = "0x1861D7FB0")]
	private void PECDFFDPILO(string NJKPBIBMIJE, UnityEngine.Object FJHKACIMEOO)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002D")]
internal sealed class BAHDCAGJEHK : KDPLDJDIMLC, HOGMIDIDFNH
{
	[Cpp2IlInjected.Token(Token = "0x170000BE")]
	public bool PLJCHFLJNEH
	{
		[Cpp2IlInjected.Token(Token = "0x60002BA")]
		[Cpp2IlInjected.Address(RVA = "0x61C4790", Offset = "0x61C3B90", VA = "0x1861C4790", Slot = "4")]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x60002BB")]
		[Cpp2IlInjected.Address(RVA = "0x61C4860", Offset = "0x61C3C60", VA = "0x1861C4860", Slot = "5")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60002B9")]
	[Cpp2IlInjected.Address(RVA = "0x61C4630", Offset = "0x61C3A30", VA = "0x1861C4630")]
	public BAHDCAGJEHK(MGCGGKFMJCL GOCPNHJEOMK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002BC")]
	[Cpp2IlInjected.Address(RVA = "0x61C49B0", Offset = "0x61C3DB0", VA = "0x1861C49B0", Slot = "6")]
	public void INHOGFJCLDO(Rigidbody GEBCPMOBIAB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002BD")]
	[Cpp2IlInjected.Address(RVA = "0x61C47F0", Offset = "0x61C3BF0", VA = "0x1861C47F0", Slot = "7")]
	public void FLMHAOMIJON(Rigidbody GEBCPMOBIAB)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002E")]
internal sealed class HGMACDBIODB : KDPLDJDIMLC, DODNAMHPMBE, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x4000043")]
	private static readonly FBKCBHAMJJJ MEHMJDGHNAD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x400004D")]
	private readonly DCKDKPEEBIC MNBGAKMODOF;

	[Cpp2IlInjected.Token(Token = "0x170000BF")]
	private Transform JGKOKOJENGE
	{
		[Cpp2IlInjected.Token(Token = "0x60002D1")]
		[Cpp2IlInjected.Address(RVA = "0x61DC5F0", Offset = "0x61DB9F0", VA = "0x1861DC5F0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000C0")]
	public LHNHNFAONOD FIMKKOKGMNG
	{
		[Cpp2IlInjected.Token(Token = "0x60002D3")]
		[Cpp2IlInjected.Address(RVA = "0x61DC760", Offset = "0x61DBB60", VA = "0x1861DC760")]
		get
		{
			return default(LHNHNFAONOD);
		}
		[Cpp2IlInjected.Token(Token = "0x60002D4")]
		[Cpp2IlInjected.Address(RVA = "0x61DB780", Offset = "0x61DAB80", VA = "0x1861DB780")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000C1")]
	public MGCGGKFMJCL NCEKKJFNJNC
	{
		[Cpp2IlInjected.Token(Token = "0x60002D5")]
		[Cpp2IlInjected.Address(RVA = "0x61DB710", Offset = "0x61DAB10", VA = "0x1861DB710", Slot = "24")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60002D6")]
		[Cpp2IlInjected.Address(RVA = "0x61DBC90", Offset = "0x61DB090", VA = "0x1861DBC90", Slot = "25")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000C2")]
	public LHNHNFAONOD PFKFHAPEAEB
	{
		[Cpp2IlInjected.Token(Token = "0x60002D7")]
		[Cpp2IlInjected.Address(RVA = "0x61DBA50", Offset = "0x61DAE50", VA = "0x1861DBA50")]
		get
		{
			return default(LHNHNFAONOD);
		}
		[Cpp2IlInjected.Token(Token = "0x60002D8")]
		[Cpp2IlInjected.Address(RVA = "0x61DC2D0", Offset = "0x61DB6D0", VA = "0x1861DC2D0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000C3")]
	public MGCGGKFMJCL DFDPGOHHPEM
	{
		[Cpp2IlInjected.Token(Token = "0x60002D9")]
		[Cpp2IlInjected.Address(RVA = "0x61DB7F0", Offset = "0x61DABF0", VA = "0x1861DB7F0", Slot = "23")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000C4")]
	public IReadOnlyList<MGCGGKFMJCL> FCCNECOIHNG
	{
		[Cpp2IlInjected.Token(Token = "0x60002DA")]
		[Cpp2IlInjected.Address(RVA = "0x7610A0", Offset = "0x7604A0", VA = "0x1807610A0", Slot = "22")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400002B")]
	public event LNNBFANOADD ELBIILPLBLJ
	{
		[Cpp2IlInjected.Token(Token = "0x60002BF")]
		[Cpp2IlInjected.Address(RVA = "0x61DC910", Offset = "0x61DBD10", VA = "0x1861DC910", Slot = "4")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60002C0")]
		[Cpp2IlInjected.Address(RVA = "0x61DC620", Offset = "0x61DBA20", VA = "0x1861DC620", Slot = "5")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400002C")]
	public event LNNBFANOADD CBNGEFCLMOB
	{
		[Cpp2IlInjected.Token(Token = "0x60002C1")]
		[Cpp2IlInjected.Address(RVA = "0x61DB860", Offset = "0x61DAC60", VA = "0x1861DB860", Slot = "6")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60002C2")]
		[Cpp2IlInjected.Address(RVA = "0x61DB9B0", Offset = "0x61DADB0", VA = "0x1861DB9B0", Slot = "7")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400002D")]
	public event OKIHMFHNBGG IACLPHDLFGN
	{
		[Cpp2IlInjected.Token(Token = "0x60002C3")]
		[Cpp2IlInjected.Address(RVA = "0x61DCDD0", Offset = "0x61DC1D0", VA = "0x1861DCDD0", Slot = "8")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60002C4")]
		[Cpp2IlInjected.Address(RVA = "0x61DC9B0", Offset = "0x61DBDB0", VA = "0x1861DC9B0", Slot = "9")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400002E")]
	public event Action GLGKNBAGMIP
	{
		[Cpp2IlInjected.Token(Token = "0x60002C5")]
		[Cpp2IlInjected.Address(RVA = "0x61DC6C0", Offset = "0x61DBAC0", VA = "0x1861DC6C0", Slot = "10")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60002C6")]
		[Cpp2IlInjected.Address(RVA = "0x61DB370", Offset = "0x61DA770", VA = "0x1861DB370", Slot = "11")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400002F")]
	public event Action FEEIKIIDIDI
	{
		[Cpp2IlInjected.Token(Token = "0x60002C7")]
		[Cpp2IlInjected.Address(RVA = "0x61DCB90", Offset = "0x61DBF90", VA = "0x1861DCB90", Slot = "12")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60002C8")]
		[Cpp2IlInjected.Address(RVA = "0x61DC870", Offset = "0x61DBC70", VA = "0x1861DC870", Slot = "13")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000030")]
	public event Action<MGCGGKFMJCL> HGADFPCMNGJ
	{
		[Cpp2IlInjected.Token(Token = "0x60002C9")]
		[Cpp2IlInjected.Address(RVA = "0x61DBAB0", Offset = "0x61DAEB0", VA = "0x1861DBAB0", Slot = "14")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60002CA")]
		[Cpp2IlInjected.Address(RVA = "0x61DB900", Offset = "0x61DAD00", VA = "0x1861DB900", Slot = "15")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000031")]
	public event Action<MGCGGKFMJCL> DIBBGPAFGIG
	{
		[Cpp2IlInjected.Token(Token = "0x60002CB")]
		[Cpp2IlInjected.Address(RVA = "0x61DB660", Offset = "0x61DAA60", VA = "0x1861DB660", Slot = "16")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60002CC")]
		[Cpp2IlInjected.Address(RVA = "0x61DCC30", Offset = "0x61DC030", VA = "0x1861DCC30", Slot = "17")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000032")]
	public event Action GMFKHKBHJIH
	{
		[Cpp2IlInjected.Token(Token = "0x60002CD")]
		[Cpp2IlInjected.Address(RVA = "0x61DCA50", Offset = "0x61DBE50", VA = "0x1861DCA50", Slot = "18")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60002CE")]
		[Cpp2IlInjected.Address(RVA = "0x61DCAF0", Offset = "0x61DBEF0", VA = "0x1861DCAF0", Slot = "19")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000033")]
	public event Action<MGCGGKFMJCL> DEOECEFBMHF
	{
		[Cpp2IlInjected.Token(Token = "0x60002CF")]
		[Cpp2IlInjected.Address(RVA = "0x61DB2C0", Offset = "0x61DA6C0", VA = "0x1861DB2C0", Slot = "20")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60002D0")]
		[Cpp2IlInjected.Address(RVA = "0x61DC220", Offset = "0x61DB620", VA = "0x1861DC220", Slot = "21")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60002BE")]
	[Cpp2IlInjected.Address(RVA = "0x61DD100", Offset = "0x61DC500", VA = "0x1861DD100")]
	public HGMACDBIODB(MGCGGKFMJCL GOCPNHJEOMK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002D2")]
	[Cpp2IlInjected.Address(RVA = "0x61DBB60", Offset = "0x61DAF60", VA = "0x1861DBB60", Slot = "27")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002DB")]
	[Cpp2IlInjected.Address(RVA = "0x61DC390", Offset = "0x61DB790", VA = "0x1861DC390", Slot = "26")]
	public void HEBPNKMJKGE(MGCGGKFMJCL JOOENMAHIDL, bool ABHJANDGLGK = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002DC")]
	[Cpp2IlInjected.Address(RVA = "0x61DC340", Offset = "0x61DB740", VA = "0x1861DC340")]
	private void HEBPNKMJKGE(JHDIBBNGJAD JOOENMAHIDL, bool ABHJANDGLGK = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002DD")]
	[Cpp2IlInjected.Address(RVA = "0x61DBD00", Offset = "0x61DB100", VA = "0x1861DBD00")]
	private void EMJPBFJPMFL(JHDIBBNGJAD JOOENMAHIDL, bool ABHJANDGLGK = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002DE")]
	[Cpp2IlInjected.Address(RVA = "0x61DB410", Offset = "0x61DA810", VA = "0x1861DB410")]
	private void BBIGCFCEDHB(JHDIBBNGJAD OCLMFMCHMIF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002DF")]
	[Cpp2IlInjected.Address(RVA = "0x61DCE70", Offset = "0x61DC270", VA = "0x1861DCE70")]
	private void PDGMODPOCJI(JHDIBBNGJAD OCLMFMCHMIF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002E0")]
	[Cpp2IlInjected.Address(RVA = "0x61DC410", Offset = "0x61DB810", VA = "0x1861DC410")]
	private void HFLLBCEPJAO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002E1")]
	[Cpp2IlInjected.Address(RVA = "0x61DC7C0", Offset = "0x61DBBC0", VA = "0x1861DC7C0")]
	private void KOLJIHDPMJA(JHDIBBNGJAD OCLMFMCHMIF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002E2")]
	[Cpp2IlInjected.Address(RVA = "0x61DCCE0", Offset = "0x61DC0E0", VA = "0x1861DCCE0")]
	private void OCJOGEFDKAE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002E3")]
	[Cpp2IlInjected.Address(RVA = "0x61DC180", Offset = "0x61DB580", VA = "0x1861DC180")]
	private void FFDAFIGKKAE(JHDIBBNGJAD GOCPNHJEOMK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002E4")]
	[Cpp2IlInjected.Address(RVA = "0x61DB220", Offset = "0x61DA620", VA = "0x1861DB220")]
	private void AEELOJHOFOJ(JHDIBBNGJAD GOCPNHJEOMK)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002F")]
internal static class EOOLENABIGE
{
	[Cpp2IlInjected.Token(Token = "0x60002E6")]
	[Cpp2IlInjected.Address(RVA = "0x61CC000", Offset = "0x61CB400", VA = "0x1861CC000")]
	public static HGMACDBIODB IKJMCNLLEAF(this MGCGGKFMJCL MPPIIABEOMK)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000030")]
internal sealed class PHADLJOJEHF : KDPLDJDIMLC, ABHLGLKCJNI
{
	[Cpp2IlInjected.Token(Token = "0x170000C5")]
	public Vector3 IADJPHPDBGC
	{
		[Cpp2IlInjected.Token(Token = "0x60002E8")]
		[Cpp2IlInjected.Address(RVA = "0x61E4470", Offset = "0x61E3870", VA = "0x1861E4470", Slot = "4")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000C6")]
	public Vector3 FNFHIDNBNCJ
	{
		[Cpp2IlInjected.Token(Token = "0x60002E9")]
		[Cpp2IlInjected.Address(RVA = "0x61E3B60", Offset = "0x61E2F60", VA = "0x1861E3B60", Slot = "5")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000C7")]
	private Vector3 DPFKMNPADOM
	{
		[Cpp2IlInjected.Token(Token = "0x60002ED")]
		[Cpp2IlInjected.Address(RVA = "0x61E3910", Offset = "0x61E2D10", VA = "0x1861E3910")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000C8")]
	private MGCGGKFMJCL EACDANCLLGP
	{
		[Cpp2IlInjected.Token(Token = "0x60002EE")]
		[Cpp2IlInjected.Address(RVA = "0x61E3A00", Offset = "0x61E2E00", VA = "0x1861E3A00")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60002E7")]
	[Cpp2IlInjected.Address(RVA = "0x61C4630", Offset = "0x61C3A30", VA = "0x1861C4630")]
	public PHADLJOJEHF(MGCGGKFMJCL GOCPNHJEOMK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002EA")]
	[Cpp2IlInjected.Address(RVA = "0x61E3D90", Offset = "0x61E3190", VA = "0x1861E3D90", Slot = "6")]
	public void JNLJFCKDFBA(MGCGGKFMJCL EBFCMPBKGBM, object KJAGMGIFCEM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002EB")]
	[Cpp2IlInjected.Address(RVA = "0x61E3EE0", Offset = "0x61E32E0", VA = "0x1861E3EE0")]
	private void JNLJFCKDFBA(JHDIBBNGJAD EBFCMPBKGBM, object KJAGMGIFCEM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002EC")]
	[Cpp2IlInjected.Address(RVA = "0x61E4400", Offset = "0x61E3800", VA = "0x1861E4400", Slot = "7")]
	public void JOBKNFFOIEF(object KJAGMGIFCEM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002EF")]
	[Cpp2IlInjected.Address(RVA = "0x61E3FF0", Offset = "0x61E33F0", VA = "0x1861E3FF0")]
	private Vector3 JOAPCBPAMID()
	{
		return default(Vector3);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000031")]
internal static class DDIJNDIMPAJ
{
	[Cpp2IlInjected.Token(Token = "0x60002F0")]
	[Cpp2IlInjected.Address(RVA = "0x61C9540", Offset = "0x61C8940", VA = "0x1861C9540")]
	public static PHADLJOJEHF HEJFGDIPDIM(this MGCGGKFMJCL MPPIIABEOMK)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000032")]
internal sealed class FPIJCCFLPMN : KDPLDJDIMLC, JBNKCGNKKDA
{
	[Cpp2IlInjected.Token(Token = "0x170000C9")]
	[Obsolete("Use LocalCenterOfMassOfSelf or LocalCenterOfMassOfHierarchy, as LocalCenterOfMass changes based on context")]
	public Vector3 NIBENPFEBFL
	{
		[Cpp2IlInjected.Token(Token = "0x60002F4")]
		[Cpp2IlInjected.Address(RVA = "0x61CD520", Offset = "0x61CC920", VA = "0x1861CD520", Slot = "6")]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x60002F5")]
		[Cpp2IlInjected.Address(RVA = "0x61CD1A0", Offset = "0x61CC5A0", VA = "0x1861CD1A0", Slot = "7")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000CA")]
	public Vector3 DFDIAJHBKMD
	{
		[Cpp2IlInjected.Token(Token = "0x60002F6")]
		[Cpp2IlInjected.Address(RVA = "0x61CD5D0", Offset = "0x61CC9D0", VA = "0x1861CD5D0")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000CB")]
	public Vector3 NGFKHCOBCKD
	{
		[Cpp2IlInjected.Token(Token = "0x60002F8")]
		[Cpp2IlInjected.Address(RVA = "0x61CF200", Offset = "0x61CE600", VA = "0x1861CF200")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000CC")]
	[Obsolete("Use TryGetWorldCenterOfMassOfHierarchy() or GetWorldCenterOfMassOfSelf()")]
	public Vector3 JOKPJCADMPL
	{
		[Cpp2IlInjected.Token(Token = "0x60002F9")]
		[Cpp2IlInjected.Address(RVA = "0x61CF010", Offset = "0x61CE410", VA = "0x1861CF010", Slot = "8")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000CD")]
	[Obsolete("Use MassOfSelf or TryGetMassOfHierarchy instead")]
	public float MAMOOAGGOAI
	{
		[Cpp2IlInjected.Token(Token = "0x60002FA")]
		[Cpp2IlInjected.Address(RVA = "0x61CF570", Offset = "0x61CE970", VA = "0x1861CF570", Slot = "9")]
		get
		{
			return default(float);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000CE")]
	public float DCNIOENFGPM
	{
		[Cpp2IlInjected.Token(Token = "0x60002FB")]
		[Cpp2IlInjected.Address(RVA = "0x61CD4A0", Offset = "0x61CC8A0", VA = "0x1861CD4A0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000CF")]
	public float AIGIACKFCCL
	{
		[Cpp2IlInjected.Token(Token = "0x60002FC")]
		[Cpp2IlInjected.Address(RVA = "0x61CD740", Offset = "0x61CCB40", VA = "0x1861CD740", Slot = "10")]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x60002FD")]
		[Cpp2IlInjected.Address(RVA = "0x61CD680", Offset = "0x61CCA80", VA = "0x1861CD680", Slot = "11")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000D0")]
	public Vector3 CAPAJCKGOEI
	{
		[Cpp2IlInjected.Token(Token = "0x60002FE")]
		[Cpp2IlInjected.Address(RVA = "0x61CD440", Offset = "0x61CC840", VA = "0x1861CD440", Slot = "12")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000D1")]
	public Quaternion DICIGDCIMAG
	{
		[Cpp2IlInjected.Token(Token = "0x60002FF")]
		[Cpp2IlInjected.Address(RVA = "0x61CD470", Offset = "0x61CC870", VA = "0x1861CD470", Slot = "13")]
		get
		{
			return default(Quaternion);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000D2")]
	private Rigidbody ACNJBLDPNFK
	{
		[Cpp2IlInjected.Token(Token = "0x6000308")]
		[Cpp2IlInjected.Address(RVA = "0x61C05B0", Offset = "0x61BF9B0", VA = "0x1861C05B0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000034")]
	public event LNNBFANOADD DIFBMICLCDD
	{
		[Cpp2IlInjected.Token(Token = "0x60002F1")]
		[Cpp2IlInjected.Address(RVA = "0x61CDAD0", Offset = "0x61CCED0", VA = "0x1861CDAD0", Slot = "4")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60002F2")]
		[Cpp2IlInjected.Address(RVA = "0x61CDA30", Offset = "0x61CCE30", VA = "0x1861CDA30", Slot = "5")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60002F3")]
	[Cpp2IlInjected.Address(RVA = "0x61D0830", Offset = "0x61CFC30", VA = "0x1861D0830")]
	public FPIJCCFLPMN(MGCGGKFMJCL GOCPNHJEOMK, [In] MCODEJBAGCN GHFAAPNAFDE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002F7")]
	[Cpp2IlInjected.Address(RVA = "0x61CD320", Offset = "0x61CC720", VA = "0x1861CD320")]
	public float3 CAAFOMILCDK()
	{
		return default(float3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000300")]
	[Cpp2IlInjected.Address(RVA = "0x61CD7A0", Offset = "0x61CCBA0", VA = "0x1861CD7A0", Slot = "14")]
	public void EEEEBLADLHM((Quaternion rot, Vector3 moments) NCNIHGBNECM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000301")]
	[Cpp2IlInjected.Address(RVA = "0x61CDDD0", Offset = "0x61CD1D0", VA = "0x1861CDDD0", Slot = "16")]
	public void FJPECHAAMGI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000302")]
	[Cpp2IlInjected.Address(RVA = "0x61CE3B0", Offset = "0x61CD7B0", VA = "0x1861CE3B0", Slot = "15")]
	public void GGKIHNLFLKG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000303")]
	[Cpp2IlInjected.Address(RVA = "0x61CED00", Offset = "0x61CE100", VA = "0x1861CED00", Slot = "18")]
	public void INHOGFJCLDO(Rigidbody GEBCPMOBIAB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000304")]
	[Cpp2IlInjected.Address(RVA = "0x61CDFC0", Offset = "0x61CD3C0", VA = "0x1861CDFC0", Slot = "19")]
	public void FLMHAOMIJON(Rigidbody GEBCPMOBIAB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000305")]
	[Cpp2IlInjected.Address(RVA = "0x61CF510", Offset = "0x61CE910", VA = "0x1861CF510", Slot = "17")]
	public void KOHGBDIONNB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000306")]
	[Cpp2IlInjected.Address(RVA = "0x61CE700", Offset = "0x61CDB00", VA = "0x1861CE700", Slot = "20")]
	public void GKIFGLBKBIO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000307")]
	[Cpp2IlInjected.Address(RVA = "0x61C06B0", Offset = "0x61BFAB0", VA = "0x1861C06B0")]
	public void CIIPGGEOGAC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000309")]
	[Cpp2IlInjected.Address(RVA = "0x61CD1A0", Offset = "0x61CC5A0", VA = "0x1861CD1A0")]
	private void ALLOCBBAFBA(Vector3 EOHMJBFGDPD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600030A")]
	[Cpp2IlInjected.Address(RVA = "0x61CF330", Offset = "0x61CE730", VA = "0x1861CF330")]
	[Obsolete("Changes based on context.  the unity rigidbody center of mass has a different scale as well")]
	private Vector3 KMGAHIDPOPA()
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x600030B")]
	[Cpp2IlInjected.Address(RVA = "0x61CD680", Offset = "0x61CCA80", VA = "0x1861CD680")]
	private void DHMNCGOFAEM(float EOHMJBFGDPD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600030C")]
	[Cpp2IlInjected.Address(RVA = "0x61CDB70", Offset = "0x61CCF70", VA = "0x1861CDB70")]
	private Vector3 FAIJDFIJJFM()
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x600030D")]
	[Cpp2IlInjected.Address(RVA = "0x61CEDD0", Offset = "0x61CE1D0", VA = "0x1861CEDD0")]
	private Quaternion JCEPBBHHPHE()
	{
		return default(Quaternion);
	}

	[Cpp2IlInjected.Token(Token = "0x600030E")]
	[Cpp2IlInjected.Address(RVA = "0x61CF5D0", Offset = "0x61CE9D0", VA = "0x1861CF5D0")]
	internal (float, Vector3) PLCHCHHMFEE(Rigidbody JPOHMONKAKL)
	{
		return default((float, Vector3));
	}
}
[Cpp2IlInjected.Token(Token = "0x2000033")]
internal static class JPBHMDCCPOO
{
	[Cpp2IlInjected.Token(Token = "0x600030F")]
	[Cpp2IlInjected.Address(RVA = "0x61DFD20", Offset = "0x61DF120", VA = "0x1861DFD20")]
	public static FPIJCCFLPMN EMKLNAEGGHO(this MGCGGKFMJCL MPPIIABEOMK)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000034")]
internal sealed class KLICPBEPOII : KDPLDJDIMLC, MFDACKEMCFN
{
	[Cpp2IlInjected.Token(Token = "0x170000D3")]
	public bool GNHPGCKADIB
	{
		[Cpp2IlInjected.Token(Token = "0x6000310")]
		[Cpp2IlInjected.Address(RVA = "0x61E0950", Offset = "0x61DFD50", VA = "0x1861E0950", Slot = "10")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000D4")]
	public NCDNMOIPOGI JGLMGGBJBOL
	{
		[Cpp2IlInjected.Token(Token = "0x6000311")]
		[Cpp2IlInjected.Address(RVA = "0x61E0300", Offset = "0x61DF700", VA = "0x1861E0300", Slot = "11")]
		get
		{
			return default(NCDNMOIPOGI);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000D5")]
	private NCDNMOIPOGI HEIGCCEHHAM
	{
		[Cpp2IlInjected.Token(Token = "0x6000313")]
		[Cpp2IlInjected.Address(RVA = "0x61E0300", Offset = "0x61DF700", VA = "0x1861E0300")]
		get
		{
			return default(NCDNMOIPOGI);
		}
		[Cpp2IlInjected.Token(Token = "0x6000314")]
		[Cpp2IlInjected.Address(RVA = "0x61E0640", Offset = "0x61DFA40", VA = "0x1861E0640")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000312")]
	[Cpp2IlInjected.Address(RVA = "0x61E0A30", Offset = "0x61DFE30", VA = "0x1861E0A30")]
	public KLICPBEPOII(MGCGGKFMJCL GOCPNHJEOMK, [In] MCODEJBAGCN GHFAAPNAFDE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000315")]
	[Cpp2IlInjected.Address(RVA = "0x61E0540", Offset = "0x61DF940", VA = "0x1861E0540", Slot = "4")]
	public void JHKGOCECMOM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000316")]
	[Cpp2IlInjected.Address(RVA = "0x61E0220", Offset = "0x61DF620", VA = "0x1861E0220")]
	private bool CCFOPFIBDPE()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000317")]
	[Cpp2IlInjected.Address(RVA = "0x61E09B0", Offset = "0x61DFDB0", VA = "0x1861E09B0", Slot = "5")]
	public void OKJADHJGFEH(object KJAGMGIFCEM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000318")]
	[Cpp2IlInjected.Address(RVA = "0x61E0120", Offset = "0x61DF520", VA = "0x1861E0120", Slot = "6")]
	public void AMFHLIBIOON(object KJAGMGIFCEM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000319")]
	[Cpp2IlInjected.Address(RVA = "0x61E03E0", Offset = "0x61DF7E0", VA = "0x1861E03E0", Slot = "9")]
	public void IGMOCGMLLHH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600031A")]
	[Cpp2IlInjected.Address(RVA = "0x61E06B0", Offset = "0x61DFAB0", VA = "0x1861E06B0")]
	private void LILIIIEDPAN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600031B")]
	[Cpp2IlInjected.Address(RVA = "0x61E07B0", Offset = "0x61DFBB0", VA = "0x1861E07B0")]
	private void MKGELPDDHOJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600031C")]
	[Cpp2IlInjected.Address(RVA = "0x61E0360", Offset = "0x61DF760", VA = "0x1861E0360", Slot = "8")]
	public void GNEEHHDPIKA(MGCGGKFMJCL GOCPNHJEOMK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600031D")]
	[Cpp2IlInjected.Address(RVA = "0x61E01A0", Offset = "0x61DF5A0", VA = "0x1861E01A0", Slot = "7")]
	public void BKJBLAIOBGP(MGCGGKFMJCL GOCPNHJEOMK)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000035")]
internal sealed class FCMJHKBJLGM : KDPLDJDIMLC, JNCIBBLAFHG
{
	[Cpp2IlInjected.Token(Token = "0x170000D6")]
	public bool HCGHILJJDJE
	{
		[Cpp2IlInjected.Token(Token = "0x6000320")]
		[Cpp2IlInjected.Address(RVA = "0x61CC850", Offset = "0x61CBC50", VA = "0x1861CC850", Slot = "7")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000D7")]
	private bool FINIPFGABEF
	{
		[Cpp2IlInjected.Token(Token = "0x6000321")]
		[Cpp2IlInjected.Address(RVA = "0x61CC640", Offset = "0x61CBA40", VA = "0x1861CC640")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000035")]
	public event LNNBFANOADD OMDOLGBKNMB
	{
		[Cpp2IlInjected.Token(Token = "0x600031E")]
		[Cpp2IlInjected.Address(RVA = "0x61CC990", Offset = "0x61CBD90", VA = "0x1861CC990", Slot = "4")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600031F")]
		[Cpp2IlInjected.Address(RVA = "0x61CC6A0", Offset = "0x61CBAA0", VA = "0x1861CC6A0", Slot = "5")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000322")]
	[Cpp2IlInjected.Address(RVA = "0x61C4630", Offset = "0x61C3A30", VA = "0x1861C4630")]
	public FCMJHKBJLGM(MGCGGKFMJCL GOCPNHJEOMK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000323")]
	[Cpp2IlInjected.Address(RVA = "0x61CCB20", Offset = "0x61CBF20", VA = "0x1861CCB20", Slot = "11")]
	public IDisposable ODOGLKJIBAL()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000324")]
	[Cpp2IlInjected.Address(RVA = "0x61CC740", Offset = "0x61CBB40", VA = "0x1861CC740", Slot = "8")]
	public void CLOLFMGHJID(object KJAGMGIFCEM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000325")]
	[Cpp2IlInjected.Address(RVA = "0x61CCB10", Offset = "0x61CBF10", VA = "0x1861CCB10", Slot = "9")]
	public void LAPKPJEEGPL(object KJAGMGIFCEM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000326")]
	[Cpp2IlInjected.Address(RVA = "0x61CC750", Offset = "0x61CBB50", VA = "0x1861CC750", Slot = "10")]
	public void EHLACEEGNEA(object KJAGMGIFCEM, bool LLALDMDCIAM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000327")]
	[Cpp2IlInjected.Address(RVA = "0x61CCA30", Offset = "0x61CBE30", VA = "0x1861CCA30", Slot = "12")]
	public void INHOGFJCLDO(Rigidbody IMHHODKMCIF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000328")]
	[Cpp2IlInjected.Address(RVA = "0x61CC8B0", Offset = "0x61CBCB0", VA = "0x1861CC8B0", Slot = "13")]
	public void FLMHAOMIJON(Rigidbody GEBCPMOBIAB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000329")]
	[Cpp2IlInjected.Address(RVA = "0x61C06B0", Offset = "0x61BFAB0", VA = "0x1861C06B0", Slot = "6")]
	public void KCMCKENJMGM()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000036")]
internal sealed class NLNHPBECCKD : KDPLDJDIMLC, KHGIDGJJCDM, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000051")]
	private PhotonView NDKIHJINLPA;

	[Cpp2IlInjected.Token(Token = "0x170000D8")]
	public bool FFIFGPLINHH
	{
		[Cpp2IlInjected.Token(Token = "0x600032C")]
		[Cpp2IlInjected.Address(RVA = "0x61BFCC0", Offset = "0x61BF0C0", VA = "0x1861BFCC0", Slot = "6")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000D9")]
	public bool HAEGEFIPLPF
	{
		[Cpp2IlInjected.Token(Token = "0x600032D")]
		[Cpp2IlInjected.Address(RVA = "0x61E30A0", Offset = "0x61E24A0", VA = "0x1861E30A0", Slot = "7")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000036")]
	public event LNNBFANOADD PLAFGMCIMLA
	{
		[Cpp2IlInjected.Token(Token = "0x600032A")]
		[Cpp2IlInjected.Address(RVA = "0x61E3130", Offset = "0x61E2530", VA = "0x1861E3130", Slot = "4")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600032B")]
		[Cpp2IlInjected.Address(RVA = "0x61E2680", Offset = "0x61E1A80", VA = "0x1861E2680", Slot = "5")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600032E")]
	[Cpp2IlInjected.Address(RVA = "0x61E33D0", Offset = "0x61E27D0", VA = "0x1861E33D0")]
	public NLNHPBECCKD(MGCGGKFMJCL GOCPNHJEOMK, [In] MCODEJBAGCN GHFAAPNAFDE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600032F")]
	[Cpp2IlInjected.Address(RVA = "0x61E2F70", Offset = "0x61E2370", VA = "0x1861E2F70", Slot = "8")]
	public void JHKGOCECMOM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000330")]
	[Cpp2IlInjected.Address(RVA = "0x61E2920", Offset = "0x61E1D20", VA = "0x1861E2920", Slot = "11")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000331")]
	[Cpp2IlInjected.Address(RVA = "0x61E31D0", Offset = "0x61E25D0", VA = "0x1861E31D0", Slot = "9")]
	public void NBPCMILFJNH(MGCGGKFMJCL EBFCMPBKGBM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000332")]
	[Cpp2IlInjected.Address(RVA = "0x61E2720", Offset = "0x61E1B20", VA = "0x1861E2720", Slot = "10")]
	public void DEJHAKKIFOI(MGCGGKFMJCL EBFCMPBKGBM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000333")]
	[Cpp2IlInjected.Address(RVA = "0x61E2C40", Offset = "0x61E2040", VA = "0x1861E2C40")]
	private void IDLGHOEIKGE(PhotonView BFBAIANICFI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000334")]
	[Cpp2IlInjected.Address(RVA = "0x61E2E20", Offset = "0x61E2220", VA = "0x1861E2E20")]
	private void IHNIOPIEIMO(RigidbodyEx PBICMHFAPEC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000335")]
	[Cpp2IlInjected.Address(RVA = "0x61E2A80", Offset = "0x61E1E80", VA = "0x1861E2A80")]
	private void HJFHBBLLJME(PhotonView NMAHDDKPKAH)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000037")]
internal static class EKIBJOKGIFD
{
	[Cpp2IlInjected.Token(Token = "0x6000336")]
	[Cpp2IlInjected.Address(RVA = "0x61CBFA0", Offset = "0x61CB3A0", VA = "0x1861CBFA0")]
	public static NLNHPBECCKD NELLMLBHNDK(this GAGFBDFNKIL MPPIIABEOMK)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000038")]
internal sealed class JKMOCIGLPDA : KDPLDJDIMLC, GKGLDPLOLIH
{
	[Cpp2IlInjected.Token(Token = "0x170000DA")]
	public bool PBOGKFDNBGB
	{
		[Cpp2IlInjected.Token(Token = "0x6000337")]
		[Cpp2IlInjected.Address(RVA = "0x61DF3C0", Offset = "0x61DE7C0", VA = "0x1861DF3C0", Slot = "4")]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000338")]
		[Cpp2IlInjected.Address(RVA = "0x61DF000", Offset = "0x61DE400", VA = "0x1861DF000", Slot = "5")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000DB")]
	public bool FCGKAPFLGFO
	{
		[Cpp2IlInjected.Token(Token = "0x6000339")]
		[Cpp2IlInjected.Address(RVA = "0x61DF0D0", Offset = "0x61DE4D0", VA = "0x1861DF0D0", Slot = "6")]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x600033A")]
		[Cpp2IlInjected.Address(RVA = "0x61DF420", Offset = "0x61DE820", VA = "0x1861DF420")]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000DC")]
	public RigidbodyConstraints IEOPINFGGLF
	{
		[Cpp2IlInjected.Token(Token = "0x600033B")]
		[Cpp2IlInjected.Address(RVA = "0x61DF070", Offset = "0x61DE470", VA = "0x1861DF070", Slot = "7")]
		get
		{
			return default(RigidbodyConstraints);
		}
		[Cpp2IlInjected.Token(Token = "0x600033C")]
		[Cpp2IlInjected.Address(RVA = "0x61DF130", Offset = "0x61DE530", VA = "0x1861DF130", Slot = "8")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600033D")]
	[Cpp2IlInjected.Address(RVA = "0x61DF490", Offset = "0x61DE890", VA = "0x1861DF490")]
	public JKMOCIGLPDA(MGCGGKFMJCL GOCPNHJEOMK, [In] MCODEJBAGCN GHFAAPNAFDE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600033E")]
	[Cpp2IlInjected.Address(RVA = "0x61DF330", Offset = "0x61DE730", VA = "0x1861DF330", Slot = "9")]
	public void INHOGFJCLDO(Rigidbody GEBCPMOBIAB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600033F")]
	[Cpp2IlInjected.Address(RVA = "0x61DF2B0", Offset = "0x61DE6B0", VA = "0x1861DF2B0", Slot = "10")]
	public void FLMHAOMIJON(Rigidbody GEBCPMOBIAB)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000039")]
internal sealed class FHMAEAHGGPH : KDPLDJDIMLC, AHDFOHKMEJL
{
	[Cpp2IlInjected.Token(Token = "0x170000DD")]
	public float FBLHKIOECLM
	{
		[Cpp2IlInjected.Token(Token = "0x6000341")]
		[Cpp2IlInjected.Address(RVA = "0x61CCEA0", Offset = "0x61CC2A0", VA = "0x1861CCEA0", Slot = "4")]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x6000342")]
		[Cpp2IlInjected.Address(RVA = "0x61CD050", Offset = "0x61CC450", VA = "0x1861CD050", Slot = "5")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000DE")]
	public float NNGEGGCECLN
	{
		[Cpp2IlInjected.Token(Token = "0x6000343")]
		[Cpp2IlInjected.Address(RVA = "0x61CCFF0", Offset = "0x61CC3F0", VA = "0x1861CCFF0", Slot = "6")]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x6000344")]
		[Cpp2IlInjected.Address(RVA = "0x61CCC80", Offset = "0x61CC080", VA = "0x1861CCC80", Slot = "7")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000340")]
	[Cpp2IlInjected.Address(RVA = "0x61C4630", Offset = "0x61C3A30", VA = "0x1861C4630")]
	public FHMAEAHGGPH(MGCGGKFMJCL GOCPNHJEOMK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000345")]
	[Cpp2IlInjected.Address(RVA = "0x61CCF00", Offset = "0x61CC300", VA = "0x1861CCF00", Slot = "8")]
	public void INHOGFJCLDO(Rigidbody GEBCPMOBIAB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000346")]
	[Cpp2IlInjected.Address(RVA = "0x61CCDD0", Offset = "0x61CC1D0", VA = "0x1861CCDD0", Slot = "9")]
	public void FLMHAOMIJON(Rigidbody GEBCPMOBIAB)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200003A")]
[PNAJALIKCOM(typeof(BIPCGCLALOO), new string[] { })]
public sealed class CHANBEAOPDE : JAKEGKENGGK, BIPCGCLALOO, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000052")]
	[MFFAOKEGCNH]
	private JICJPEPDNGF GOCPNHJEOMK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000053")]
	private bool EJHKEMCAIJC;

	[Cpp2IlInjected.Token(Token = "0x170000DF")]
	public bool GHLFCACBCML
	{
		[Cpp2IlInjected.Token(Token = "0x6000349")]
		[Cpp2IlInjected.Address(RVA = "0x7D0020", Offset = "0x7CF420", VA = "0x1807D0020", Slot = "5")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000347")]
	[Cpp2IlInjected.Address(RVA = "0x61C87D0", Offset = "0x61C7BD0", VA = "0x1861C87D0", Slot = "4")]
	public void InitReferences(FJPIIIPDBML NKEGKJEJLFE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000348")]
	[Cpp2IlInjected.Address(RVA = "0x61C8440", Offset = "0x61C7840", VA = "0x1861C8440", Slot = "10")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600034A")]
	[Cpp2IlInjected.Address(RVA = "0x61C8A50", Offset = "0x61C7E50", VA = "0x1861C8A50", Slot = "6")]
	public void PLCHCHHMFEE(LHNHNFAONOD PIBFDGEOBKF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600034B")]
	[Cpp2IlInjected.Address(RVA = "0x61C85B0", Offset = "0x61C79B0", VA = "0x1861C85B0", Slot = "7")]
	public void EIKIHGOFDJE(LHNHNFAONOD PIBFDGEOBKF, bool HCNNKBKDCBO, bool NALODFLEJOB, bool NMNLIGBGBIP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600034C")]
	[Cpp2IlInjected.Address(RVA = "0x61C8470", Offset = "0x61C7870", VA = "0x1861C8470", Slot = "8")]
	public void ECMEOIKODCB(LHNHNFAONOD PIBFDGEOBKF, float3 EKHMFCCFGPL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600034D")]
	[Cpp2IlInjected.Address(RVA = "0x61C8820", Offset = "0x61C7C20", VA = "0x1861C8820", Slot = "9")]
	public void JLFOKBIEOOE(LHNHNFAONOD PIBFDGEOBKF, float3 EFIALDMFCNH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600034E")]
	[Cpp2IlInjected.Address(RVA = "0x61C8380", Offset = "0x61C7780", VA = "0x1861C8380")]
	private bool CLOCEMNNAEA(LHNHNFAONOD PIBFDGEOBKF, [Out] JHDIBBNGJAD MPPIIABEOMK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600034F")]
	[Cpp2IlInjected.Address(RVA = "0x61C8960", Offset = "0x61C7D60", VA = "0x1861C8960")]
	private bool NNGECJHBOBD(LHNHNFAONOD PIBFDGEOBKF, [Out] FPIJCCFLPMN LCNNGGKLMMA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000350")]
	[Cpp2IlInjected.Address(RVA = "0x61C8290", Offset = "0x61C7690", VA = "0x1861C8290")]
	private bool BLAPALAGHLO(LHNHNFAONOD PIBFDGEOBKF, [Out] ALJBBKBEACF HDGPCELFIJN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000351")]
	[Cpp2IlInjected.Address(RVA = "0x76C4B0", Offset = "0x76B8B0", VA = "0x18076C4B0")]
	public CHANBEAOPDE()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200003B")]
internal sealed class AJDABHGBMKJ : KDPLDJDIMLC, GOILCCLOPLE
{
	[Cpp2IlInjected.Token(Token = "0x170000E0")]
	private Rigidbody ACNJBLDPNFK
	{
		[Cpp2IlInjected.Token(Token = "0x6000354")]
		[Cpp2IlInjected.Address(RVA = "0x61C05B0", Offset = "0x61BF9B0", VA = "0x1861C05B0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000E1")]
	private bool DAKPPPOBNBC
	{
		[Cpp2IlInjected.Token(Token = "0x6000355")]
		[Cpp2IlInjected.Address(RVA = "0x61C06F0", Offset = "0x61BFAF0", VA = "0x1861C06F0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000E2")]
	private MGCGGKFMJCL NCEKKJFNJNC
	{
		[Cpp2IlInjected.Token(Token = "0x6000356")]
		[Cpp2IlInjected.Address(RVA = "0x61BFFE0", Offset = "0x61BF3E0", VA = "0x1861BFFE0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000E3")]
	private bool EKDOCCFKAGJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000357")]
		[Cpp2IlInjected.Address(RVA = "0x61C0210", Offset = "0x61BF610", VA = "0x1861C0210")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000E4")]
	private bool NBFNHCJKOEI
	{
		[Cpp2IlInjected.Token(Token = "0x6000358")]
		[Cpp2IlInjected.Address(RVA = "0x61C08C0", Offset = "0x61BFCC0", VA = "0x1861C08C0")]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000359")]
		[Cpp2IlInjected.Address(RVA = "0x61C0850", Offset = "0x61BFC50", VA = "0x1861C0850")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000E5")]
	private bool ODFNOHLDHGJ
	{
		[Cpp2IlInjected.Token(Token = "0x600035A")]
		[Cpp2IlInjected.Address(RVA = "0x61C0550", Offset = "0x61BF950", VA = "0x1861C0550")]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x600035B")]
		[Cpp2IlInjected.Address(RVA = "0x61BFF70", Offset = "0x61BF370", VA = "0x1861BFF70")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000E6")]
	private int IMBGNDIGNEF
	{
		[Cpp2IlInjected.Token(Token = "0x600035C")]
		[Cpp2IlInjected.Address(RVA = "0x61BFF00", Offset = "0x61BF300", VA = "0x1861BFF00")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000037")]
	public event LNNBFANOADD JKEEEOMBIDH
	{
		[Cpp2IlInjected.Token(Token = "0x6000352")]
		[Cpp2IlInjected.Address(RVA = "0x61C0310", Offset = "0x61BF710", VA = "0x1861C0310", Slot = "4")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000353")]
		[Cpp2IlInjected.Address(RVA = "0x61C0270", Offset = "0x61BF670", VA = "0x1861C0270", Slot = "5")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600035D")]
	[Cpp2IlInjected.Address(RVA = "0x61C0990", Offset = "0x61BFD90", VA = "0x1861C0990")]
	public AJDABHGBMKJ(MGCGGKFMJCL GOCPNHJEOMK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600035E")]
	[Cpp2IlInjected.Address(RVA = "0x61C0600", Offset = "0x61BFA00", VA = "0x1861C0600", Slot = "6")]
	public void JHKGOCECMOM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600035F")]
	[Cpp2IlInjected.Address(RVA = "0x61C0920", Offset = "0x61BFD20", VA = "0x1861C0920", Slot = "8")]
	public void OHDGAPGGGEO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000360")]
	[Cpp2IlInjected.Address(RVA = "0x61C03B0", Offset = "0x61BF7B0", VA = "0x1861C03B0", Slot = "7")]
	public bool GBMNOJMBOIA()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000361")]
	[Cpp2IlInjected.Address(RVA = "0x61C0120", Offset = "0x61BF520", VA = "0x1861C0120", Slot = "9")]
	public void DKHDPIPGLAN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000362")]
	[Cpp2IlInjected.Address(RVA = "0x61C06B0", Offset = "0x61BFAB0", VA = "0x1861C06B0", Slot = "12")]
	public void JPEOPDBIOFK(bool JOAAGNJLPGK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000363")]
	[Cpp2IlInjected.Address(RVA = "0x61C0710", Offset = "0x61BFB10", VA = "0x1861C0710", Slot = "11")]
	public void MALCMJHIFLA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000364")]
	[Cpp2IlInjected.Address(RVA = "0x75E5B0", Offset = "0x75D9B0", VA = "0x18075E5B0", Slot = "10")]
	public void FDFEHOGPDLO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000365")]
	[Cpp2IlInjected.Address(RVA = "0x61C0040", Offset = "0x61BF440", VA = "0x1861C0040")]
	private void CLBPNMKIMHN()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200003C")]
internal sealed class NJBCFHNMLDE : KDPLDJDIMLC, NHEPMPNKBHG
{
	[Cpp2IlInjected.Token(Token = "0x170000E7")]
	public Rigidbody ACNJBLDPNFK
	{
		[Cpp2IlInjected.Token(Token = "0x6000366")]
		[Cpp2IlInjected.Address(RVA = "0x61E23B0", Offset = "0x61E17B0", VA = "0x1861E23B0", Slot = "4")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000367")]
		[Cpp2IlInjected.Address(RVA = "0x61E20F0", Offset = "0x61E14F0", VA = "0x1861E20F0")]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000E8")]
	private bool EKDOCCFKAGJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000368")]
		[Cpp2IlInjected.Address(RVA = "0x61C98B0", Offset = "0x61C8CB0", VA = "0x1861C98B0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000E9")]
	public bool LOFHGPEPHPP
	{
		[Cpp2IlInjected.Token(Token = "0x600036B")]
		[Cpp2IlInjected.Address(RVA = "0x61E2010", Offset = "0x61E1410", VA = "0x1861E2010", Slot = "6")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000369")]
	[Cpp2IlInjected.Address(RVA = "0x61E25C0", Offset = "0x61E19C0", VA = "0x1861E25C0")]
	public NJBCFHNMLDE(MGCGGKFMJCL GOCPNHJEOMK, [In] MCODEJBAGCN GHFAAPNAFDE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600036A")]
	[Cpp2IlInjected.Address(RVA = "0x61E2490", Offset = "0x61E1890", VA = "0x1861E2490", Slot = "5")]
	public void JHKGOCECMOM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600036C")]
	[Cpp2IlInjected.Address(RVA = "0x61E2070", Offset = "0x61E1470", VA = "0x1861E2070", Slot = "7")]
	public void CEDEMEPPALB(object KJAGMGIFCEM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600036D")]
	[Cpp2IlInjected.Address(RVA = "0x61E2540", Offset = "0x61E1940", VA = "0x1861E2540", Slot = "8")]
	public void MLKIEMGEEPP(object KJAGMGIFCEM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600036E")]
	[Cpp2IlInjected.Address(RVA = "0x61E1B90", Offset = "0x61E0F90", VA = "0x1861E1B90", Slot = "9")]
	public void BNBIPPHMKFF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600036F")]
	[Cpp2IlInjected.Address(RVA = "0x61E1DB0", Offset = "0x61E11B0", VA = "0x1861E1DB0", Slot = "11")]
	public void CACFKJFACGP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000370")]
	[Cpp2IlInjected.Address(RVA = "0x61E21E0", Offset = "0x61E15E0", VA = "0x1861E21E0", Slot = "12")]
	public void HJMDJJEJJKD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000371")]
	[Cpp2IlInjected.Address(RVA = "0x75E5B0", Offset = "0x75D9B0", VA = "0x18075E5B0", Slot = "10")]
	public void ACICNKEKDGI()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200003D")]
internal sealed class ALJBBKBEACF : KDPLDJDIMLC, DGJKOCOHMGO, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x170000EA")]
	public JOOBEENEBAA KIPEILJOHEE
	{
		[Cpp2IlInjected.Token(Token = "0x6000372")]
		[Cpp2IlInjected.Address(RVA = "0x61C2FC0", Offset = "0x61C23C0", VA = "0x1861C2FC0", Slot = "4")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000373")]
		[Cpp2IlInjected.Address(RVA = "0x61C2DE0", Offset = "0x61C21E0", VA = "0x1861C2DE0", Slot = "5")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000EB")]
	public GKFPHOCIOLD BCAAPMKBHAM
	{
		[Cpp2IlInjected.Token(Token = "0x6000374")]
		[Cpp2IlInjected.Address(RVA = "0x61C14B0", Offset = "0x61C08B0", VA = "0x1861C14B0", Slot = "6")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000375")]
		[Cpp2IlInjected.Address(RVA = "0x61C3070", Offset = "0x61C2470", VA = "0x1861C3070", Slot = "7")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000EC")]
	public Vector3 DPFKMNPADOM
	{
		[Cpp2IlInjected.Token(Token = "0x6000376")]
		[Cpp2IlInjected.Address(RVA = "0x61C0C80", Offset = "0x61C0080", VA = "0x1861C0C80", Slot = "8")]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x6000377")]
		[Cpp2IlInjected.Address(RVA = "0x61C1610", Offset = "0x61C0A10", VA = "0x1861C1610", Slot = "9")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000ED")]
	public Vector3 GFFGILJCJLF
	{
		[Cpp2IlInjected.Token(Token = "0x6000378")]
		[Cpp2IlInjected.Address(RVA = "0x61C0B30", Offset = "0x61BFF30", VA = "0x1861C0B30", Slot = "10")]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x6000379")]
		[Cpp2IlInjected.Address(RVA = "0x61C1480", Offset = "0x61C0880", VA = "0x1861C1480", Slot = "11")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000EE")]
	public Vector3 IKKGDGHOOEN
	{
		[Cpp2IlInjected.Token(Token = "0x600037A")]
		[Cpp2IlInjected.Address(RVA = "0x61C3860", Offset = "0x61C2C60", VA = "0x1861C3860", Slot = "12")]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x600037B")]
		[Cpp2IlInjected.Address(RVA = "0x61C4380", Offset = "0x61C3780", VA = "0x1861C4380", Slot = "13")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000EF")]
	public Vector3 ACHPDMPDEGK
	{
		[Cpp2IlInjected.Token(Token = "0x600037C")]
		[Cpp2IlInjected.Address(RVA = "0x61C1C00", Offset = "0x61C1000", VA = "0x1861C1C00", Slot = "14")]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x600037D")]
		[Cpp2IlInjected.Address(RVA = "0x61C2390", Offset = "0x61C1790", VA = "0x1861C2390", Slot = "15")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000F0")]
	public float IMFCIBCJLIP
	{
		[Cpp2IlInjected.Token(Token = "0x600037E")]
		[Cpp2IlInjected.Address(RVA = "0x61C2590", Offset = "0x61C1990", VA = "0x1861C2590", Slot = "16")]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x600037F")]
		[Cpp2IlInjected.Address(RVA = "0x61C0CE0", Offset = "0x61C00E0", VA = "0x1861C0CE0", Slot = "17")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000F1")]
	public bool NCFBIAMPAHJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000381")]
		[Cpp2IlInjected.Address(RVA = "0x61C3CA0", Offset = "0x61C30A0", VA = "0x1861C3CA0", Slot = "18")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000F2")]
	private LDADHEPIIJJ HCPIIEIKLAJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000394")]
		[Cpp2IlInjected.Address(RVA = "0x1C56270", Offset = "0x1C55670", VA = "0x181C56270")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000F3")]
	private bool DAKPPPOBNBC
	{
		[Cpp2IlInjected.Token(Token = "0x6000395")]
		[Cpp2IlInjected.Address(RVA = "0x61C06F0", Offset = "0x61BFAF0", VA = "0x1861C06F0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000380")]
	[Cpp2IlInjected.Address(RVA = "0x61C4630", Offset = "0x61C3A30", VA = "0x1861C4630")]
	public ALJBBKBEACF(MGCGGKFMJCL GOCPNHJEOMK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000382")]
	[Cpp2IlInjected.Address(RVA = "0x61C3C30", Offset = "0x61C3030", VA = "0x1861C3C30", Slot = "20")]
	public void NGDGOPEIOMC(object KJAGMGIFCEM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000383")]
	[Cpp2IlInjected.Address(RVA = "0x61C0AC0", Offset = "0x61BFEC0", VA = "0x1861C0AC0", Slot = "30")]
	public void AAADHENEFCN(object KJAGMGIFCEM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000384")]
	[Cpp2IlInjected.Address(RVA = "0x61C1560", Offset = "0x61C0960", VA = "0x1861C1560", Slot = "19")]
	public void JHKGOCECMOM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000385")]
	[Cpp2IlInjected.Address(RVA = "0x61C1B40", Offset = "0x61C0F40", VA = "0x1861C1B40", Slot = "36")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000386")]
	[Cpp2IlInjected.Address(RVA = "0x61C2E50", Offset = "0x61C2250", VA = "0x1861C2E50", Slot = "28")]
	public void INHOGFJCLDO(Rigidbody GEBCPMOBIAB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000387")]
	[Cpp2IlInjected.Address(RVA = "0x61C1C30", Offset = "0x61C1030", VA = "0x1861C1C30", Slot = "35")]
	public Vector3 FLADNKLALKJ(Vector3 NDMBMJJIOFA)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000388")]
	[Cpp2IlInjected.Address(RVA = "0x61C16D0", Offset = "0x61C0AD0", VA = "0x1861C16D0", Slot = "34")]
	public Vector3 DMBNKHGFCEB(Vector3 EKHMFCCFGPL)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000389")]
	[Cpp2IlInjected.Address(RVA = "0x61C1560", Offset = "0x61C0960", VA = "0x1861C1560", Slot = "27")]
	public void CPOFEOBDKHH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600038A")]
	[Cpp2IlInjected.Address(RVA = "0x61C0B60", Offset = "0x61BFF60", VA = "0x1861C0B60", Slot = "25")]
	public void ADFAAJPBAGA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600038B")]
	[Cpp2IlInjected.Address(RVA = "0x61C4270", Offset = "0x61C3670", VA = "0x1861C4270", Slot = "24")]
	public void PEPDJLKNHGG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600038C")]
	[Cpp2IlInjected.Address(RVA = "0x61C1240", Offset = "0x61C0640", VA = "0x1861C1240", Slot = "33")]
	public void BIABKHBMFDC(Vector3 LHINOEFCJLG, Vector3 AIMMMFLBCHI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600038D")]
	[Cpp2IlInjected.Address(RVA = "0x61C0C20", Offset = "0x61C0020", VA = "0x1861C0C20", Slot = "32")]
	public void ALEIMOONCKG(Vector3 HGBENCPPIOE, Vector3 EFIALDMFCNH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600038E")]
	[Cpp2IlInjected.Address(RVA = "0x61C30E0", Offset = "0x61C24E0", VA = "0x1861C30E0", Slot = "31")]
	public void KDOMADLDDAH(Vector3 AFNABGBDBAH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600038F")]
	[Cpp2IlInjected.Address(RVA = "0x61C2870", Offset = "0x61C1C70", VA = "0x1861C2870", Slot = "22")]
	public void IKEAFEJHOCH(KOJCHCLAHNC KDAMGPKMFLN, Vector3 NEBBPBIFLLJ, float KKPMGKAMFEJ, float EFDONJDPNKE = 8f, float DCDHDFHOKAE = 1f)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000390")]
	[Cpp2IlInjected.Address(RVA = "0x61C1890", Offset = "0x61C0C90", VA = "0x1861C1890", Slot = "21")]
	public void DMLNPBGDGBL(NILPLAGMMGI DAFNMKFCJFG, Vector3 LHELLKPPHKL, float FPGCJPGJIBA = float.PositiveInfinity)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000391")]
	[Cpp2IlInjected.Address(RVA = "0x61C0E30", Offset = "0x61C0230", VA = "0x1861C0E30", Slot = "23")]
	[Obsolete("Deprecated. Still exists to support deprecated CV2 chips. Use ApplyAngularVelocityChange.")]
	public void BFAKGADOJGG(NILPLAGMMGI DAFNMKFCJFG, Vector3 KBKHJHIFKGI, float CGNIOCJOEKL = 7f, float JKANFBIIJHK = 1f)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000392")]
	[Cpp2IlInjected.Address(RVA = "0x61C3B50", Offset = "0x61C2F50", VA = "0x1861C3B50", Slot = "29")]
	public Vector3 MLOBKENIFDB(Vector3 GKMPFMKFGID)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000393")]
	[Cpp2IlInjected.Address(RVA = "0x61C44A0", Offset = "0x61C38A0", VA = "0x1861C44A0", Slot = "26")]
	public void PJFHPKDNKCK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000396")]
	[Cpp2IlInjected.Address(RVA = "0x61C0CE0", Offset = "0x61C00E0", VA = "0x1861C0CE0")]
	private void BCDCHHFFOGO(float EOHMJBFGDPD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000397")]
	[Cpp2IlInjected.Address(RVA = "0x61C23C0", Offset = "0x61C17C0", VA = "0x1861C23C0")]
	private void HACEKABHENP(Vector3 LHELLKPPHKL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000398")]
	[Cpp2IlInjected.Address(RVA = "0x61C25F0", Offset = "0x61C19F0", VA = "0x1861C25F0")]
	private Vector3 IJPEEKNJHIE()
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000399")]
	[Cpp2IlInjected.Address(RVA = "0x61C1E10", Offset = "0x61C1210", VA = "0x1861C1E10")]
	private void GCJDHLECOBJ(Vector3 EKHMFCCFGPL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600039A")]
	[Cpp2IlInjected.Address(RVA = "0x61C38C0", Offset = "0x61C2CC0", VA = "0x1861C38C0")]
	private Vector3 MBOBHGCLAGL()
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x600039B")]
	[Cpp2IlInjected.Address(RVA = "0x61C3D00", Offset = "0x61C3100", VA = "0x1861C3D00")]
	private void OJEAPEOCDMI(Vector3 EOHMJBFGDPD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600039C")]
	[Cpp2IlInjected.Address(RVA = "0x61C4440", Offset = "0x61C3840", VA = "0x1861C4440")]
	private void PJBIJEFNIAM(Vector3 GKMPFMKFGID)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600039D")]
	[Cpp2IlInjected.Address(RVA = "0x61C0BC0", Offset = "0x61BFFC0", VA = "0x1861C0BC0")]
	private void AJIEBCHPHPH(Vector3 BADJPOOCLHC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600039E")]
	[Cpp2IlInjected.Address(RVA = "0x61C32B0", Offset = "0x61C26B0", VA = "0x1861C32B0")]
	private void LADBECPGMNB(string FEABFMPANJB, Vector3 EOHMJBFGDPD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600039F")]
	[Cpp2IlInjected.Address(RVA = "0x61C42D0", Offset = "0x61C36D0", VA = "0x1861C42D0")]
	private void PGEACLLELML()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200003E")]
internal class KDPLDJDIMLC
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000055")]
	protected readonly JHDIBBNGJAD GOCPNHJEOMK;

	[Cpp2IlInjected.Token(Token = "0x170000F4")]
	protected JICJPEPDNGF KEBKKPHDJDP
	{
		[Cpp2IlInjected.Token(Token = "0x60003A0")]
		[Cpp2IlInjected.Address(RVA = "0x5393160", Offset = "0x5392560", VA = "0x185393160")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000F5")]
	protected LHNHNFAONOD NJBGKNJCFAM
	{
		[Cpp2IlInjected.Token(Token = "0x60003A1")]
		[Cpp2IlInjected.Address(RVA = "0x53931A0", Offset = "0x53925A0", VA = "0x1853931A0")]
		get
		{
			return default(LHNHNFAONOD);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60003A2")]
	[Cpp2IlInjected.Address(RVA = "0x61C4630", Offset = "0x61C3A30", VA = "0x1861C4630")]
	public KDPLDJDIMLC(MGCGGKFMJCL GOCPNHJEOMK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003A3")]
	[Cpp2IlInjected.Address(RVA = "0x61E0080", Offset = "0x61DF480", VA = "0x1861E0080")]
	protected MGCGGKFMJCL EJLACNLNBJO(LHNHNFAONOD GIPGBEGNLCD)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200003F")]
public class HNJKIONEFCD : EKNPMJGCPKA
{
	[Cpp2IlInjected.Token(Token = "0x60003A4")]
	[Cpp2IlInjected.Address(RVA = "0x61DD900", Offset = "0x61DCD00", VA = "0x1861DD900", Slot = "4")]
	public DODNAMHPMBE HDJDKJBJIDM(MGCGGKFMJCL MPPIIABEOMK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003A5")]
	[Cpp2IlInjected.Address(RVA = "0x61DD5C0", Offset = "0x61DC9C0", VA = "0x1861DD5C0", Slot = "5")]
	public DGJKOCOHMGO EFOOLAELMEL(MGCGGKFMJCL MPPIIABEOMK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003A6")]
	[Cpp2IlInjected.Address(RVA = "0x61DDAB0", Offset = "0x61DCEB0", VA = "0x1861DDAB0", Slot = "6")]
	public ABHLGLKCJNI JKELKKKKKCF(MGCGGKFMJCL MPPIIABEOMK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003A7")]
	[Cpp2IlInjected.Address(RVA = "0x61DD9D0", Offset = "0x61DCDD0", VA = "0x1861DD9D0", Slot = "7")]
	public AHDFOHKMEJL JDDMHOBCBMG(MGCGGKFMJCL MPPIIABEOMK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003A8")]
	[Cpp2IlInjected.Address(RVA = "0x61DD790", Offset = "0x61DCB90", VA = "0x1861DD790", Slot = "8")]
	public GOILCCLOPLE HDFLEEFDEGH(MGCGGKFMJCL MPPIIABEOMK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003A9")]
	[Cpp2IlInjected.Address(RVA = "0x61DDCD0", Offset = "0x61DD0D0", VA = "0x1861DDCD0", Slot = "9")]
	public KKFFFGDLIIM LHCNNINPLHC(MGCGGKFMJCL MPPIIABEOMK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003AA")]
	[Cpp2IlInjected.Address(RVA = "0x61DD6A0", Offset = "0x61DCAA0", VA = "0x1861DD6A0", Slot = "10")]
	public JNCIBBLAFHG EOPAPGLAECF(MGCGGKFMJCL MPPIIABEOMK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003AB")]
	[Cpp2IlInjected.Address(RVA = "0x61DE160", Offset = "0x61DD560", VA = "0x1861DE160", Slot = "11")]
	public LDADHEPIIJJ PPOIFOPBCIK(MGCGGKFMJCL MPPIIABEOMK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003AC")]
	[Cpp2IlInjected.Address(RVA = "0x61DD4E0", Offset = "0x61DC8E0", VA = "0x1861DD4E0", Slot = "12")]
	public EGPHOJFLGHI EEDCLPCPAPD(MGCGGKFMJCL MPPIIABEOMK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003AD")]
	[Cpp2IlInjected.Address(RVA = "0x61DE080", Offset = "0x61DD480", VA = "0x1861DE080", Slot = "13")]
	public HOGMIDIDFNH PHLDOMEJJDH(MGCGGKFMJCL MPPIIABEOMK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003AE")]
	[Cpp2IlInjected.Address(RVA = "0x61DD2E0", Offset = "0x61DC6E0", VA = "0x1861DD2E0")]
	public NHEPMPNKBHG ALKFKFHHFDI(MGCGGKFMJCL MPPIIABEOMK, [In] MCODEJBAGCN GHFAAPNAFDE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003AF")]
	[Cpp2IlInjected.Address(RVA = "0x61DD3E0", Offset = "0x61DC7E0", VA = "0x1861DD3E0")]
	public KHGIDGJJCDM ONJKEKBDIOL(MGCGGKFMJCL MPPIIABEOMK, [In] MCODEJBAGCN GHFAAPNAFDE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003B0")]
	[Cpp2IlInjected.Address(RVA = "0x61DDB90", Offset = "0x61DCF90", VA = "0x1861DDB90")]
	public MFDACKEMCFN PLBIIHNHKIC(MGCGGKFMJCL MPPIIABEOMK, [In] MCODEJBAGCN GHFAAPNAFDE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003B1")]
	[Cpp2IlInjected.Address(RVA = "0x61DD960", Offset = "0x61DCD60", VA = "0x1861DD960")]
	public JBNKCGNKKDA OLKIFCLJICA(MGCGGKFMJCL MPPIIABEOMK, [In] MCODEJBAGCN GHFAAPNAFDE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003B2")]
	[Cpp2IlInjected.Address(RVA = "0x61DDDB0", Offset = "0x61DD1B0", VA = "0x1861DDDB0")]
	public GKGLDPLOLIH NODCFIFDCCN(MGCGGKFMJCL MPPIIABEOMK, [In] MCODEJBAGCN GHFAAPNAFDE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003B3")]
	[Cpp2IlInjected.Address(RVA = "0x61DDF50", Offset = "0x61DD350", VA = "0x1861DDF50", Slot = "19")]
	public MGCGGKFMJCL OJHFCPKEHNA(RigidbodyEx GOCPNHJEOMK, MCODEJBAGCN GHFAAPNAFDE, HPGKIKLHCAJ GCLFDBLLOOM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003B4")]
	[Cpp2IlInjected.Address(RVA = "0x76C4B0", Offset = "0x76B8B0", VA = "0x18076C4B0")]
	public HNJKIONEFCD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003B5")]
	[Cpp2IlInjected.Address(RVA = "0x61DD2E0", Offset = "0x61DC6E0", VA = "0x1861DD2E0", Slot = "14")]
	private NHEPMPNKBHG OFHCFANEJKK(MGCGGKFMJCL MPPIIABEOMK, [In] MCODEJBAGCN GHFAAPNAFDE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003B6")]
	[Cpp2IlInjected.Address(RVA = "0x61DD3E0", Offset = "0x61DC7E0", VA = "0x1861DD3E0", Slot = "15")]
	private KHGIDGJJCDM BNKJDPBDJGK(MGCGGKFMJCL MPPIIABEOMK, [In] MCODEJBAGCN GHFAAPNAFDE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003B7")]
	[Cpp2IlInjected.Address(RVA = "0x61DDB90", Offset = "0x61DCF90", VA = "0x1861DDB90", Slot = "16")]
	private MFDACKEMCFN JLPNPCMPKIP(MGCGGKFMJCL MPPIIABEOMK, [In] MCODEJBAGCN GHFAAPNAFDE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003B8")]
	[Cpp2IlInjected.Address(RVA = "0x61DD960", Offset = "0x61DCD60", VA = "0x1861DD960", Slot = "17")]
	private JBNKCGNKKDA JAPAKJFFOEM(MGCGGKFMJCL MPPIIABEOMK, [In] MCODEJBAGCN GHFAAPNAFDE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003B9")]
	[Cpp2IlInjected.Address(RVA = "0x61DD780", Offset = "0x61DCB80", VA = "0x1861DD780", Slot = "18")]
	private GKGLDPLOLIH FDNJHEEAFFK(MGCGGKFMJCL MPPIIABEOMK, [In] MCODEJBAGCN GHFAAPNAFDE)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000040")]
[DefaultMember("Item")]
public sealed class DCKDKPEEBIC : IReadOnlyList<MGCGGKFMJCL>, IEnumerable<MGCGGKFMJCL>, IEnumerable, IReadOnlyCollection<MGCGGKFMJCL>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000056")]
	public readonly LHNHNFAONOD GIPGBEGNLCD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000057")]
	public readonly JICJPEPDNGF PDMNBLCHBOO;

	[Cpp2IlInjected.Token(Token = "0x170000F6")]
	public int EJNDKIEMIHK
	{
		[Cpp2IlInjected.Token(Token = "0x60003BD")]
		[Cpp2IlInjected.Address(RVA = "0x61C94F0", Offset = "0x61C88F0", VA = "0x1861C94F0", Slot = "5")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000F7")]
	public MGCGGKFMJCL LGAFKLMJDKE
	{
		[Cpp2IlInjected.Token(Token = "0x60003BE")]
		[Cpp2IlInjected.Address(RVA = "0x61C93A0", Offset = "0x61C87A0", VA = "0x1861C93A0", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60003BA")]
	[Cpp2IlInjected.Address(RVA = "0x3CFA700", Offset = "0x3CF9B00", VA = "0x183CFA700")]
	public DCKDKPEEBIC(LHNHNFAONOD GIPGBEGNLCD, JICJPEPDNGF PDMNBLCHBOO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003BB")]
	[Cpp2IlInjected.Address(RVA = "0x61C9290", Offset = "0x61C8690", VA = "0x1861C9290", Slot = "6")]
	public IEnumerator<MGCGGKFMJCL> GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003BC")]
	[Cpp2IlInjected.Address(RVA = "0x61C9290", Offset = "0x61C8690", VA = "0x1861C9290", Slot = "7")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003BF")]
	[Cpp2IlInjected.Address(RVA = "0x61C93A0", Offset = "0x61C87A0", VA = "0x1861C93A0")]
	[CompilerGenerated]
	private MGCGGKFMJCL PKDEJGAABFK(int KEFLNPGBJEJ)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000041")]
[PNAJALIKCOM(typeof(EKNPMJGCPKA), new string[] { })]
public class BLJNPMCANOO : EKNPMJGCPKA, JAKEGKENGGK
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000058")]
	private readonly EKNPMJGCPKA AJOPDFOAOJH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000059")]
	private readonly EKNPMJGCPKA EPKJOOEACNA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400005A")]
	private FDJDNGGEHIB EBNNBMFMGJK;

	[Cpp2IlInjected.Token(Token = "0x170000F8")]
	private EKNPMJGCPKA KPMBOFODDKB
	{
		[Cpp2IlInjected.Token(Token = "0x60003C1")]
		[Cpp2IlInjected.Address(RVA = "0x61C5300", Offset = "0x61C4700", VA = "0x1861C5300")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60003C0")]
	[Cpp2IlInjected.Address(RVA = "0x61C4F70", Offset = "0x61C4370", VA = "0x1861C4F70", Slot = "20")]
	public void InitReferences(FJPIIIPDBML NKEGKJEJLFE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003C2")]
	[Cpp2IlInjected.Address(RVA = "0x61C4ED0", Offset = "0x61C42D0", VA = "0x1861C4ED0", Slot = "4")]
	public DODNAMHPMBE HDJDKJBJIDM(MGCGGKFMJCL MPPIIABEOMK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003C3")]
	[Cpp2IlInjected.Address(RVA = "0x61C4C40", Offset = "0x61C4040", VA = "0x1861C4C40", Slot = "5")]
	public DGJKOCOHMGO EFOOLAELMEL(MGCGGKFMJCL MPPIIABEOMK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003C4")]
	[Cpp2IlInjected.Address(RVA = "0x61C5110", Offset = "0x61C4510", VA = "0x1861C5110", Slot = "6")]
	public ABHLGLKCJNI JKELKKKKKCF(MGCGGKFMJCL MPPIIABEOMK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003C5")]
	[Cpp2IlInjected.Address(RVA = "0x61C5070", Offset = "0x61C4470", VA = "0x1861C5070", Slot = "7")]
	public AHDFOHKMEJL JDDMHOBCBMG(MGCGGKFMJCL MPPIIABEOMK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003C6")]
	[Cpp2IlInjected.Address(RVA = "0x61C4E30", Offset = "0x61C4230", VA = "0x1861C4E30", Slot = "8")]
	public GOILCCLOPLE HDFLEEFDEGH(MGCGGKFMJCL MPPIIABEOMK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003C7")]
	[Cpp2IlInjected.Address(RVA = "0x61C5260", Offset = "0x61C4660", VA = "0x1861C5260", Slot = "9")]
	public KKFFFGDLIIM LHCNNINPLHC(MGCGGKFMJCL MPPIIABEOMK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003C8")]
	[Cpp2IlInjected.Address(RVA = "0x61C4CE0", Offset = "0x61C40E0", VA = "0x1861C4CE0", Slot = "10")]
	public JNCIBBLAFHG EOPAPGLAECF(MGCGGKFMJCL MPPIIABEOMK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003C9")]
	[Cpp2IlInjected.Address(RVA = "0x61C54F0", Offset = "0x61C48F0", VA = "0x1861C54F0", Slot = "11")]
	public LDADHEPIIJJ PPOIFOPBCIK(MGCGGKFMJCL MPPIIABEOMK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003CA")]
	[Cpp2IlInjected.Address(RVA = "0x61C4BA0", Offset = "0x61C3FA0", VA = "0x1861C4BA0", Slot = "12")]
	public EGPHOJFLGHI EEDCLPCPAPD(MGCGGKFMJCL MPPIIABEOMK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003CB")]
	[Cpp2IlInjected.Address(RVA = "0x61C5450", Offset = "0x61C4850", VA = "0x1861C5450", Slot = "13")]
	public HOGMIDIDFNH PHLDOMEJJDH(MGCGGKFMJCL MPPIIABEOMK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003CC")]
	[Cpp2IlInjected.Address(RVA = "0x61C4A40", Offset = "0x61C3E40", VA = "0x1861C4A40")]
	public NHEPMPNKBHG ALKFKFHHFDI(MGCGGKFMJCL MPPIIABEOMK, [In] MCODEJBAGCN GHFAAPNAFDE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003CD")]
	[Cpp2IlInjected.Address(RVA = "0x61C4AF0", Offset = "0x61C3EF0", VA = "0x1861C4AF0")]
	public KHGIDGJJCDM ONJKEKBDIOL(MGCGGKFMJCL MPPIIABEOMK, [In] MCODEJBAGCN GHFAAPNAFDE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003CE")]
	[Cpp2IlInjected.Address(RVA = "0x61C51B0", Offset = "0x61C45B0", VA = "0x1861C51B0")]
	public MFDACKEMCFN PLBIIHNHKIC(MGCGGKFMJCL MPPIIABEOMK, [In] MCODEJBAGCN GHFAAPNAFDE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003CF")]
	[Cpp2IlInjected.Address(RVA = "0x61C4FC0", Offset = "0x61C43C0", VA = "0x1861C4FC0")]
	public JBNKCGNKKDA OLKIFCLJICA(MGCGGKFMJCL MPPIIABEOMK, [In] MCODEJBAGCN GHFAAPNAFDE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003D0")]
	[Cpp2IlInjected.Address(RVA = "0x61C4D80", Offset = "0x61C4180", VA = "0x1861C4D80")]
	public GKGLDPLOLIH NODCFIFDCCN(MGCGGKFMJCL MPPIIABEOMK, [In] MCODEJBAGCN GHFAAPNAFDE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003D1")]
	[Cpp2IlInjected.Address(RVA = "0x61C5360", Offset = "0x61C4760", VA = "0x1861C5360", Slot = "19")]
	public MGCGGKFMJCL OJHFCPKEHNA(RigidbodyEx GOCPNHJEOMK, MCODEJBAGCN GHFAAPNAFDE, HPGKIKLHCAJ GCLFDBLLOOM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003D2")]
	[Cpp2IlInjected.Address(RVA = "0x61C5590", Offset = "0x61C4990", VA = "0x1861C5590")]
	public BLJNPMCANOO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003D3")]
	[Cpp2IlInjected.Address(RVA = "0x61C4A40", Offset = "0x61C3E40", VA = "0x1861C4A40", Slot = "14")]
	private NHEPMPNKBHG OFHCFANEJKK(MGCGGKFMJCL MPPIIABEOMK, [In] MCODEJBAGCN GHFAAPNAFDE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003D4")]
	[Cpp2IlInjected.Address(RVA = "0x61C4AF0", Offset = "0x61C3EF0", VA = "0x1861C4AF0", Slot = "15")]
	private KHGIDGJJCDM BNKJDPBDJGK(MGCGGKFMJCL MPPIIABEOMK, [In] MCODEJBAGCN GHFAAPNAFDE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003D5")]
	[Cpp2IlInjected.Address(RVA = "0x61C51B0", Offset = "0x61C45B0", VA = "0x1861C51B0", Slot = "16")]
	private MFDACKEMCFN JLPNPCMPKIP(MGCGGKFMJCL MPPIIABEOMK, [In] MCODEJBAGCN GHFAAPNAFDE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003D6")]
	[Cpp2IlInjected.Address(RVA = "0x61C4FC0", Offset = "0x61C43C0", VA = "0x1861C4FC0", Slot = "17")]
	private JBNKCGNKKDA JAPAKJFFOEM(MGCGGKFMJCL MPPIIABEOMK, [In] MCODEJBAGCN GHFAAPNAFDE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003D7")]
	[Cpp2IlInjected.Address(RVA = "0x61C4D80", Offset = "0x61C4180", VA = "0x1861C4D80", Slot = "18")]
	private GKGLDPLOLIH FDNJHEEAFFK(MGCGGKFMJCL MPPIIABEOMK, [In] MCODEJBAGCN GHFAAPNAFDE)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000042")]
[UnityEngine.Scripting.Preserve]
public sealed class FFMAHKNCHGA : MGCGGKFMJCL, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x400005B")]
	public static readonly FFMAHKNCHGA PFONNHJIIHO;

	[Cpp2IlInjected.Token(Token = "0x170000F9")]
	public Rigidbody ACNJBLDPNFK
	{
		[Cpp2IlInjected.Token(Token = "0x60003EA")]
		[Cpp2IlInjected.Address(RVA = "0x75C530", Offset = "0x75B930", VA = "0x18075C530", Slot = "4")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000FA")]
	public RigidbodyEx BAOFDDACECK
	{
		[Cpp2IlInjected.Token(Token = "0x60003EB")]
		[Cpp2IlInjected.Address(RVA = "0x75C540", Offset = "0x75B940", VA = "0x18075C540", Slot = "5")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000FB")]
	public GameObject EDFMFAADHAF
	{
		[Cpp2IlInjected.Token(Token = "0x60003EC")]
		[Cpp2IlInjected.Address(RVA = "0x764960", Offset = "0x763D60", VA = "0x180764960", Slot = "6")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000FC")]
	public Transform JGKOKOJENGE
	{
		[Cpp2IlInjected.Token(Token = "0x60003ED")]
		[Cpp2IlInjected.Address(RVA = "0x75C780", Offset = "0x75BB80", VA = "0x18075C780", Slot = "7")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000FD")]
	public MGCGGKFMJCL NCEKKJFNJNC
	{
		[Cpp2IlInjected.Token(Token = "0x60003EE")]
		[Cpp2IlInjected.Address(RVA = "0x75C7D0", Offset = "0x75BBD0", VA = "0x18075C7D0", Slot = "8")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60003EF")]
		[Cpp2IlInjected.Address(RVA = "0x7681F0", Offset = "0x7675F0", VA = "0x1807681F0", Slot = "9")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000FE")]
	public IReadOnlyList<MGCGGKFMJCL> FCCNECOIHNG
	{
		[Cpp2IlInjected.Token(Token = "0x60003F0")]
		[Cpp2IlInjected.Address(RVA = "0x75C7E0", Offset = "0x75BBE0", VA = "0x18075C7E0", Slot = "10")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000FF")]
	public MGCGGKFMJCL DFDPGOHHPEM
	{
		[Cpp2IlInjected.Token(Token = "0x60003F1")]
		[Cpp2IlInjected.Address(RVA = "0x764B70", Offset = "0x763F70", VA = "0x180764B70", Slot = "11")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000100")]
	public bool FFIFGPLINHH
	{
		[Cpp2IlInjected.Token(Token = "0x60003F2")]
		[Cpp2IlInjected.Address(RVA = "0x8411D0", Offset = "0x8405D0", VA = "0x1808411D0", Slot = "12")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000101")]
	public bool HAEGEFIPLPF
	{
		[Cpp2IlInjected.Token(Token = "0x60003F3")]
		[Cpp2IlInjected.Address(RVA = "0xCA9470", Offset = "0xCA8870", VA = "0x180CA9470", Slot = "13")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000102")]
	public JOOBEENEBAA KIPEILJOHEE
	{
		[Cpp2IlInjected.Token(Token = "0x60003F4")]
		[Cpp2IlInjected.Address(RVA = "0x7610E0", Offset = "0x7604E0", VA = "0x1807610E0", Slot = "14")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60003F5")]
		[Cpp2IlInjected.Address(RVA = "0x761100", Offset = "0x760500", VA = "0x180761100", Slot = "15")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000103")]
	public GKFPHOCIOLD BCAAPMKBHAM
	{
		[Cpp2IlInjected.Token(Token = "0x60003F6")]
		[Cpp2IlInjected.Address(RVA = "0x7610D0", Offset = "0x7604D0", VA = "0x1807610D0", Slot = "16")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60003F7")]
		[Cpp2IlInjected.Address(RVA = "0x7610B0", Offset = "0x7604B0", VA = "0x1807610B0", Slot = "17")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000104")]
	public float IMFCIBCJLIP
	{
		[Cpp2IlInjected.Token(Token = "0x60003F8")]
		[Cpp2IlInjected.Address(RVA = "0x92D8B0", Offset = "0x92CCB0", VA = "0x18092D8B0", Slot = "18")]
		[CompilerGenerated]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x60003F9")]
		[Cpp2IlInjected.Address(RVA = "0x7EA700", Offset = "0x7E9B00", VA = "0x1807EA700", Slot = "19")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000105")]
	public Vector3 GFFGILJCJLF
	{
		[Cpp2IlInjected.Token(Token = "0x60003FA")]
		[Cpp2IlInjected.Address(RVA = "0x1A033F0", Offset = "0x1A027F0", VA = "0x181A033F0", Slot = "20")]
		[CompilerGenerated]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x60003FB")]
		[Cpp2IlInjected.Address(RVA = "0x360B7B0", Offset = "0x360ABB0", VA = "0x18360B7B0", Slot = "21")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000106")]
	public Vector3 ACHPDMPDEGK
	{
		[Cpp2IlInjected.Token(Token = "0x60003FC")]
		[Cpp2IlInjected.Address(RVA = "0x61CCB90", Offset = "0x61CBF90", VA = "0x1861CCB90", Slot = "22")]
		[CompilerGenerated]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x60003FD")]
		[Cpp2IlInjected.Address(RVA = "0x61CCBB0", Offset = "0x61CBFB0", VA = "0x1861CCBB0", Slot = "23")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000107")]
	public Vector3 DPFKMNPADOM
	{
		[Cpp2IlInjected.Token(Token = "0x60003FE")]
		[Cpp2IlInjected.Address(RVA = "0x3D9E0B0", Offset = "0x3D9D4B0", VA = "0x183D9E0B0", Slot = "24")]
		[CompilerGenerated]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x60003FF")]
		[Cpp2IlInjected.Address(RVA = "0x19301E0", Offset = "0x192F5E0", VA = "0x1819301E0", Slot = "25")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000108")]
	public Vector3 IKKGDGHOOEN
	{
		[Cpp2IlInjected.Token(Token = "0x6000400")]
		[Cpp2IlInjected.Address(RVA = "0xA40A10", Offset = "0xA3FE10", VA = "0x180A40A10", Slot = "26")]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x6000401")]
		[Cpp2IlInjected.Address(RVA = "0x75E5B0", Offset = "0x75D9B0", VA = "0x18075E5B0", Slot = "27")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000109")]
	public bool GOJPGPEEJCL
	{
		[Cpp2IlInjected.Token(Token = "0x6000402")]
		[Cpp2IlInjected.Address(RVA = "0x86C6E0", Offset = "0x86BAE0", VA = "0x18086C6E0", Slot = "28")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700010A")]
	public bool NLCHEOGPMJH
	{
		[Cpp2IlInjected.Token(Token = "0x6000403")]
		[Cpp2IlInjected.Address(RVA = "0x1658C80", Offset = "0x1658080", VA = "0x181658C80", Slot = "29")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700010B")]
	public bool NCFBIAMPAHJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000404")]
		[Cpp2IlInjected.Address(RVA = "0x5AE0A40", Offset = "0x5ADFE40", VA = "0x185AE0A40", Slot = "30")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700010C")]
	public Vector3 IADJPHPDBGC
	{
		[Cpp2IlInjected.Token(Token = "0x6000405")]
		[Cpp2IlInjected.Address(RVA = "0x3DAFF90", Offset = "0x3DAF390", VA = "0x183DAFF90", Slot = "31")]
		[CompilerGenerated]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700010D")]
	public Vector3 FNFHIDNBNCJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000406")]
		[Cpp2IlInjected.Address(RVA = "0x8F6620", Offset = "0x8F5A20", VA = "0x1808F6620", Slot = "32")]
		[CompilerGenerated]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700010E")]
	public Vector3 NIBENPFEBFL
	{
		[Cpp2IlInjected.Token(Token = "0x6000407")]
		[Cpp2IlInjected.Address(RVA = "0xA40A10", Offset = "0xA3FE10", VA = "0x180A40A10", Slot = "33")]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x6000408")]
		[Cpp2IlInjected.Address(RVA = "0x75E5B0", Offset = "0x75D9B0", VA = "0x18075E5B0", Slot = "34")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700010F")]
	public Vector3 JOKPJCADMPL
	{
		[Cpp2IlInjected.Token(Token = "0x6000409")]
		[Cpp2IlInjected.Address(RVA = "0x61CCBC0", Offset = "0x61CBFC0", VA = "0x1861CCBC0", Slot = "35")]
		[CompilerGenerated]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000110")]
	public float MAMOOAGGOAI
	{
		[Cpp2IlInjected.Token(Token = "0x600040A")]
		[Cpp2IlInjected.Address(RVA = "0x52AA6A0", Offset = "0x52A9AA0", VA = "0x1852AA6A0", Slot = "36")]
		[CompilerGenerated]
		get
		{
			return default(float);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000111")]
	public float AIGIACKFCCL
	{
		[Cpp2IlInjected.Token(Token = "0x600040B")]
		[Cpp2IlInjected.Address(RVA = "0x7B0690", Offset = "0x7AFA90", VA = "0x1807B0690", Slot = "37")]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x600040C")]
		[Cpp2IlInjected.Address(RVA = "0x75E5B0", Offset = "0x75D9B0", VA = "0x18075E5B0", Slot = "38")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000112")]
	public Vector3 CAPAJCKGOEI
	{
		[Cpp2IlInjected.Token(Token = "0x600040D")]
		[Cpp2IlInjected.Address(RVA = "0xA40A10", Offset = "0xA3FE10", VA = "0x180A40A10", Slot = "39")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000113")]
	public Quaternion DICIGDCIMAG
	{
		[Cpp2IlInjected.Token(Token = "0x600040E")]
		[Cpp2IlInjected.Address(RVA = "0x7AED70", Offset = "0x7AE170", VA = "0x1807AED70", Slot = "40")]
		get
		{
			return default(Quaternion);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000114")]
	public float FBLHKIOECLM
	{
		[Cpp2IlInjected.Token(Token = "0x6000410")]
		[Cpp2IlInjected.Address(RVA = "0x7B0690", Offset = "0x7AFA90", VA = "0x1807B0690", Slot = "42")]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x6000411")]
		[Cpp2IlInjected.Address(RVA = "0x75E5B0", Offset = "0x75D9B0", VA = "0x18075E5B0", Slot = "43")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000115")]
	public float NNGEGGCECLN
	{
		[Cpp2IlInjected.Token(Token = "0x6000412")]
		[Cpp2IlInjected.Address(RVA = "0x7B0690", Offset = "0x7AFA90", VA = "0x1807B0690", Slot = "44")]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x6000413")]
		[Cpp2IlInjected.Address(RVA = "0x75E5B0", Offset = "0x75D9B0", VA = "0x18075E5B0", Slot = "45")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000116")]
	public bool PLJCHFLJNEH
	{
		[Cpp2IlInjected.Token(Token = "0x6000414")]
		[Cpp2IlInjected.Address(RVA = "0x7A7300", Offset = "0x7A6700", VA = "0x1807A7300", Slot = "46")]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000415")]
		[Cpp2IlInjected.Address(RVA = "0x75E5B0", Offset = "0x75D9B0", VA = "0x18075E5B0", Slot = "47")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000117")]
	public CEAJINAKHIE IJNJIINAHIE
	{
		[Cpp2IlInjected.Token(Token = "0x6000416")]
		[Cpp2IlInjected.Address(RVA = "0x7A7300", Offset = "0x7A6700", VA = "0x1807A7300", Slot = "48")]
		get
		{
			return default(CEAJINAKHIE);
		}
		[Cpp2IlInjected.Token(Token = "0x6000417")]
		[Cpp2IlInjected.Address(RVA = "0x75E5B0", Offset = "0x75D9B0", VA = "0x18075E5B0", Slot = "49")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000118")]
	public bool HCGHILJJDJE
	{
		[Cpp2IlInjected.Token(Token = "0x6000418")]
		[Cpp2IlInjected.Address(RVA = "0x10E0D30", Offset = "0x10E0130", VA = "0x1810E0D30", Slot = "50")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000119")]
	public Transform OEBHBPDHFHA
	{
		[Cpp2IlInjected.Token(Token = "0x6000419")]
		[Cpp2IlInjected.Address(RVA = "0x83AD80", Offset = "0x83A180", VA = "0x18083AD80", Slot = "51")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700011A")]
	public Vector3 BFIMMMNJJEB
	{
		[Cpp2IlInjected.Token(Token = "0x600041A")]
		[Cpp2IlInjected.Address(RVA = "0xA40A10", Offset = "0xA3FE10", VA = "0x180A40A10", Slot = "52")]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x600041B")]
		[Cpp2IlInjected.Address(RVA = "0x75E5B0", Offset = "0x75D9B0", VA = "0x18075E5B0", Slot = "53")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700011B")]
	public float DLDGBIHEMNE
	{
		[Cpp2IlInjected.Token(Token = "0x600041C")]
		[Cpp2IlInjected.Address(RVA = "0x7B0690", Offset = "0x7AFA90", VA = "0x1807B0690", Slot = "54")]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x600041D")]
		[Cpp2IlInjected.Address(RVA = "0x75E5B0", Offset = "0x75D9B0", VA = "0x18075E5B0", Slot = "55")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700011C")]
	public float LHDFLHMPEDP
	{
		[Cpp2IlInjected.Token(Token = "0x600041E")]
		[Cpp2IlInjected.Address(RVA = "0x7B0690", Offset = "0x7AFA90", VA = "0x1807B0690", Slot = "56")]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x600041F")]
		[Cpp2IlInjected.Address(RVA = "0x75E5B0", Offset = "0x75D9B0", VA = "0x18075E5B0", Slot = "57")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700011D")]
	public Quaternion EOOPIAMLFFL
	{
		[Cpp2IlInjected.Token(Token = "0x6000420")]
		[Cpp2IlInjected.Address(RVA = "0x89CB60", Offset = "0x89BF60", VA = "0x18089CB60", Slot = "58")]
		get
		{
			return default(Quaternion);
		}
		[Cpp2IlInjected.Token(Token = "0x6000421")]
		[Cpp2IlInjected.Address(RVA = "0x75E5B0", Offset = "0x75D9B0", VA = "0x18075E5B0", Slot = "59")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700011E")]
	public Vector3 MKJKOHNLCOL
	{
		[Cpp2IlInjected.Token(Token = "0x6000422")]
		[Cpp2IlInjected.Address(RVA = "0xA40A10", Offset = "0xA3FE10", VA = "0x180A40A10", Slot = "60")]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x6000423")]
		[Cpp2IlInjected.Address(RVA = "0x75E5B0", Offset = "0x75D9B0", VA = "0x18075E5B0", Slot = "61")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700011F")]
	public Quaternion OIFBJHBHDIL
	{
		[Cpp2IlInjected.Token(Token = "0x6000424")]
		[Cpp2IlInjected.Address(RVA = "0x89CB60", Offset = "0x89BF60", VA = "0x18089CB60", Slot = "62")]
		get
		{
			return default(Quaternion);
		}
		[Cpp2IlInjected.Token(Token = "0x6000425")]
		[Cpp2IlInjected.Address(RVA = "0x75E5B0", Offset = "0x75D9B0", VA = "0x18075E5B0", Slot = "63")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000120")]
	public RigidbodyConstraints IEOPINFGGLF
	{
		[Cpp2IlInjected.Token(Token = "0x6000426")]
		[Cpp2IlInjected.Address(RVA = "0x75E5C0", Offset = "0x75D9C0", VA = "0x18075E5C0", Slot = "64")]
		get
		{
			return default(RigidbodyConstraints);
		}
		[Cpp2IlInjected.Token(Token = "0x6000427")]
		[Cpp2IlInjected.Address(RVA = "0x75E5B0", Offset = "0x75D9B0", VA = "0x18075E5B0", Slot = "65")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000121")]
	public bool PBOGKFDNBGB
	{
		[Cpp2IlInjected.Token(Token = "0x6000428")]
		[Cpp2IlInjected.Address(RVA = "0x7A7300", Offset = "0x7A6700", VA = "0x1807A7300", Slot = "66")]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000429")]
		[Cpp2IlInjected.Address(RVA = "0x75E5B0", Offset = "0x75D9B0", VA = "0x18075E5B0", Slot = "67")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000122")]
	public CollisionDetectionMode GDLPEHNGKFD
	{
		[Cpp2IlInjected.Token(Token = "0x600042A")]
		[Cpp2IlInjected.Address(RVA = "0x75E5C0", Offset = "0x75D9C0", VA = "0x18075E5C0", Slot = "68")]
		get
		{
			return default(CollisionDetectionMode);
		}
		[Cpp2IlInjected.Token(Token = "0x600042B")]
		[Cpp2IlInjected.Address(RVA = "0x75E5B0", Offset = "0x75D9B0", VA = "0x18075E5B0", Slot = "69")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000123")]
	public bool CBOGMEEBBPL
	{
		[Cpp2IlInjected.Token(Token = "0x600042C")]
		[Cpp2IlInjected.Address(RVA = "0xA89890", Offset = "0xA88C90", VA = "0x180A89890", Slot = "70")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000038")]
	public event LNNBFANOADD ELBIILPLBLJ
	{
		[Cpp2IlInjected.Token(Token = "0x60003D8")]
		[Cpp2IlInjected.Address(RVA = "0x75E5B0", Offset = "0x75D9B0", VA = "0x18075E5B0", Slot = "75")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60003D9")]
		[Cpp2IlInjected.Address(RVA = "0x75E5B0", Offset = "0x75D9B0", VA = "0x18075E5B0", Slot = "76")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000039")]
	public event LNNBFANOADD CBNGEFCLMOB
	{
		[Cpp2IlInjected.Token(Token = "0x60003DA")]
		[Cpp2IlInjected.Address(RVA = "0x75E5B0", Offset = "0x75D9B0", VA = "0x18075E5B0", Slot = "77")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60003DB")]
		[Cpp2IlInjected.Address(RVA = "0x75E5B0", Offset = "0x75D9B0", VA = "0x18075E5B0", Slot = "78")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400003A")]
	public event OKIHMFHNBGG IACLPHDLFGN
	{
		[Cpp2IlInjected.Token(Token = "0x60003DC")]
		[Cpp2IlInjected.Address(RVA = "0x75E5B0", Offset = "0x75D9B0", VA = "0x18075E5B0", Slot = "79")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60003DD")]
		[Cpp2IlInjected.Address(RVA = "0x75E5B0", Offset = "0x75D9B0", VA = "0x18075E5B0", Slot = "80")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400003B")]
	public event LNNBFANOADD PLAFGMCIMLA
	{
		[Cpp2IlInjected.Token(Token = "0x60003DE")]
		[Cpp2IlInjected.Address(RVA = "0x75E5B0", Offset = "0x75D9B0", VA = "0x18075E5B0", Slot = "82")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60003DF")]
		[Cpp2IlInjected.Address(RVA = "0x75E5B0", Offset = "0x75D9B0", VA = "0x18075E5B0", Slot = "83")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400003C")]
	public event LNNBFANOADD LCEOKOPJBNC
	{
		[Cpp2IlInjected.Token(Token = "0x60003E0")]
		[Cpp2IlInjected.Address(RVA = "0x75E5B0", Offset = "0x75D9B0", VA = "0x18075E5B0", Slot = "102")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60003E1")]
		[Cpp2IlInjected.Address(RVA = "0x75E5B0", Offset = "0x75D9B0", VA = "0x18075E5B0", Slot = "103")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400003D")]
	public event LNNBFANOADD JKEEEOMBIDH
	{
		[Cpp2IlInjected.Token(Token = "0x60003E2")]
		[Cpp2IlInjected.Address(RVA = "0x75E5B0", Offset = "0x75D9B0", VA = "0x18075E5B0", Slot = "107")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60003E3")]
		[Cpp2IlInjected.Address(RVA = "0x75E5B0", Offset = "0x75D9B0", VA = "0x18075E5B0", Slot = "108")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400003E")]
	public event Action<ADKLLFONPNJ, ADKLLFONPNJ> IEAAAMEAGPG
	{
		[Cpp2IlInjected.Token(Token = "0x60003E4")]
		[Cpp2IlInjected.Address(RVA = "0x75E5B0", Offset = "0x75D9B0", VA = "0x18075E5B0", Slot = "111")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60003E5")]
		[Cpp2IlInjected.Address(RVA = "0x75E5B0", Offset = "0x75D9B0", VA = "0x18075E5B0", Slot = "112")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400003F")]
	public event LNNBFANOADD OMDOLGBKNMB
	{
		[Cpp2IlInjected.Token(Token = "0x60003E6")]
		[Cpp2IlInjected.Address(RVA = "0x75E5B0", Offset = "0x75D9B0", VA = "0x18075E5B0", Slot = "113")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60003E7")]
		[Cpp2IlInjected.Address(RVA = "0x75E5B0", Offset = "0x75D9B0", VA = "0x18075E5B0", Slot = "114")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000040")]
	public event LNNBFANOADD OKPCAHNBDOG
	{
		[Cpp2IlInjected.Token(Token = "0x60003E8")]
		[Cpp2IlInjected.Address(RVA = "0x75E5B0", Offset = "0x75D9B0", VA = "0x18075E5B0", Slot = "119")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60003E9")]
		[Cpp2IlInjected.Address(RVA = "0x75E5B0", Offset = "0x75D9B0", VA = "0x18075E5B0", Slot = "120")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600040F")]
	[Cpp2IlInjected.Address(RVA = "0x75E5B0", Offset = "0x75D9B0", VA = "0x18075E5B0", Slot = "41")]
	public void EEEEBLADLHM((Quaternion rot, Vector3 moments) NCNIHGBNECM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600042D")]
	[Cpp2IlInjected.Address(RVA = "0x75E5B0", Offset = "0x75D9B0", VA = "0x18075E5B0", Slot = "71")]
	public void JHKGOCECMOM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600042E")]
	[Cpp2IlInjected.Address(RVA = "0x75E5B0", Offset = "0x75D9B0", VA = "0x18075E5B0", Slot = "72")]
	public void ANCCAJMPGEI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600042F")]
	[Cpp2IlInjected.Address(RVA = "0x75E5B0", Offset = "0x75D9B0", VA = "0x18075E5B0", Slot = "73")]
	public void KNFPAGAHPOH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000430")]
	[Cpp2IlInjected.Address(RVA = "0x75E5B0", Offset = "0x75D9B0", VA = "0x18075E5B0", Slot = "74")]
	public void DKHDPIPGLAN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000431")]
	[Cpp2IlInjected.Address(RVA = "0x75E5B0", Offset = "0x75D9B0", VA = "0x18075E5B0", Slot = "134")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000432")]
	[Cpp2IlInjected.Address(RVA = "0x75E5B0", Offset = "0x75D9B0", VA = "0x18075E5B0", Slot = "81")]
	public void HEBPNKMJKGE(MGCGGKFMJCL EOHMJBFGDPD, bool ABHJANDGLGK = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000433")]
	[Cpp2IlInjected.Address(RVA = "0x75E5B0", Offset = "0x75D9B0", VA = "0x18075E5B0", Slot = "84")]
	public void BLMOJFOIDMP(object KJAGMGIFCEM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000434")]
	[Cpp2IlInjected.Address(RVA = "0x75E5B0", Offset = "0x75D9B0", VA = "0x18075E5B0", Slot = "85")]
	public void NJMHFKGMAOA(object KJAGMGIFCEM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000435")]
	[Cpp2IlInjected.Address(RVA = "0xA40A10", Offset = "0xA3FE10", VA = "0x180A40A10", Slot = "86")]
	public Vector3 FLADNKLALKJ(Vector3 NDMBMJJIOFA)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000436")]
	[Cpp2IlInjected.Address(RVA = "0xA40A10", Offset = "0xA3FE10", VA = "0x180A40A10", Slot = "87")]
	public Vector3 DMBNKHGFCEB(Vector3 EKHMFCCFGPL)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000437")]
	[Cpp2IlInjected.Address(RVA = "0x75E5B0", Offset = "0x75D9B0", VA = "0x18075E5B0", Slot = "88")]
	public void CPOFEOBDKHH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000438")]
	[Cpp2IlInjected.Address(RVA = "0x75E5B0", Offset = "0x75D9B0", VA = "0x18075E5B0", Slot = "89")]
	public void ADFAAJPBAGA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000439")]
	[Cpp2IlInjected.Address(RVA = "0x75E5B0", Offset = "0x75D9B0", VA = "0x18075E5B0", Slot = "90")]
	public void PEPDJLKNHGG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600043A")]
	[Cpp2IlInjected.Address(RVA = "0x75E5B0", Offset = "0x75D9B0", VA = "0x18075E5B0", Slot = "91")]
	public void BIABKHBMFDC(Vector3 LHINOEFCJLG, Vector3 AIMMMFLBCHI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600043B")]
	[Cpp2IlInjected.Address(RVA = "0x75E5B0", Offset = "0x75D9B0", VA = "0x18075E5B0", Slot = "92")]
	public void ALEIMOONCKG(Vector3 HGBENCPPIOE, Vector3 EFIALDMFCNH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600043C")]
	[Cpp2IlInjected.Address(RVA = "0x75E5B0", Offset = "0x75D9B0", VA = "0x18075E5B0", Slot = "93")]
	public void KDOMADLDDAH(Vector3 AFNABGBDBAH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600043D")]
	[Cpp2IlInjected.Address(RVA = "0x75E5B0", Offset = "0x75D9B0", VA = "0x18075E5B0", Slot = "94")]
	public void IKEAFEJHOCH(KOJCHCLAHNC KDAMGPKMFLN, Vector3 NEBBPBIFLLJ, float KKPMGKAMFEJ, float EFDONJDPNKE = 8f, float DCDHDFHOKAE = 1f)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600043E")]
	[Cpp2IlInjected.Address(RVA = "0x75E5B0", Offset = "0x75D9B0", VA = "0x18075E5B0", Slot = "95")]
	public void DMLNPBGDGBL(NILPLAGMMGI DAFNMKFCJFG, Vector3 LHELLKPPHKL, float FPGCJPGJIBA = float.PositiveInfinity)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600043F")]
	[Cpp2IlInjected.Address(RVA = "0x75E5B0", Offset = "0x75D9B0", VA = "0x18075E5B0", Slot = "96")]
	public void BFAKGADOJGG(NILPLAGMMGI DAFNMKFCJFG, Vector3 KBKHJHIFKGI, float CGNIOCJOEKL = 7f, float JKANFBIIJHK = 1f)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000440")]
	[Cpp2IlInjected.Address(RVA = "0xA40A10", Offset = "0xA3FE10", VA = "0x180A40A10", Slot = "97")]
	public Vector3 MLOBKENIFDB(Vector3 EOHMJBFGDPD)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000441")]
	[Cpp2IlInjected.Address(RVA = "0xA40A10", Offset = "0xA3FE10", VA = "0x180A40A10", Slot = "98")]
	public Vector3 CMHGHFBBNOH(Vector3 EOHMJBFGDPD)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000442")]
	[Cpp2IlInjected.Address(RVA = "0x75E5B0", Offset = "0x75D9B0", VA = "0x18075E5B0", Slot = "99")]
	public void PJFHPKDNKCK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000443")]
	[Cpp2IlInjected.Address(RVA = "0x75E5B0", Offset = "0x75D9B0", VA = "0x18075E5B0", Slot = "100")]
	public void PFGLECPGEKC(MGCGGKFMJCL DLHNNAAEEBB, object KJAGMGIFCEM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000444")]
	[Cpp2IlInjected.Address(RVA = "0x75E5B0", Offset = "0x75D9B0", VA = "0x18075E5B0", Slot = "101")]
	public void OLGKOCDKEEG(object KJAGMGIFCEM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000445")]
	[Cpp2IlInjected.Address(RVA = "0x75E5B0", Offset = "0x75D9B0", VA = "0x18075E5B0", Slot = "104")]
	public void FJPECHAAMGI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000446")]
	[Cpp2IlInjected.Address(RVA = "0x75E5B0", Offset = "0x75D9B0", VA = "0x18075E5B0", Slot = "105")]
	public void GGKIHNLFLKG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000447")]
	[Cpp2IlInjected.Address(RVA = "0x75E5B0", Offset = "0x75D9B0", VA = "0x18075E5B0", Slot = "106")]
	public void KOHGBDIONNB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000448")]
	[Cpp2IlInjected.Address(RVA = "0x7A7300", Offset = "0x7A6700", VA = "0x1807A7300", Slot = "109")]
	public bool GBMNOJMBOIA()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000449")]
	[Cpp2IlInjected.Address(RVA = "0x75E5B0", Offset = "0x75D9B0", VA = "0x18075E5B0", Slot = "110")]
	public void MALCMJHIFLA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600044A")]
	[Cpp2IlInjected.Address(RVA = "0x75E5C0", Offset = "0x75D9C0", VA = "0x18075E5C0", Slot = "115")]
	public IDisposable ODOGLKJIBAL()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600044B")]
	[Cpp2IlInjected.Address(RVA = "0x75E5B0", Offset = "0x75D9B0", VA = "0x18075E5B0", Slot = "116")]
	public void CLOLFMGHJID(object KJAGMGIFCEM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600044C")]
	[Cpp2IlInjected.Address(RVA = "0x75E5B0", Offset = "0x75D9B0", VA = "0x18075E5B0", Slot = "117")]
	public void LAPKPJEEGPL(object KJAGMGIFCEM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600044D")]
	[Cpp2IlInjected.Address(RVA = "0x75E5B0", Offset = "0x75D9B0", VA = "0x18075E5B0", Slot = "118")]
	public void EHLACEEGNEA(object KJAGMGIFCEM, bool LLALDMDCIAM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600044E")]
	[Cpp2IlInjected.Address(RVA = "0x75E5B0", Offset = "0x75D9B0", VA = "0x18075E5B0", Slot = "121")]
	public void ILDJMOEDAAG(Vector3 NDJBAGILJCL, Quaternion EJDCLAMMOJM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600044F")]
	[Cpp2IlInjected.Address(RVA = "0x75E5B0", Offset = "0x75D9B0", VA = "0x18075E5B0", Slot = "122")]
	public void PDHENDLLOPB(Vector3 GLJADFPJOGM, Quaternion FHGOIAIOLGI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000450")]
	[Cpp2IlInjected.Address(RVA = "0x7A7300", Offset = "0x7A6700", VA = "0x1807A7300", Slot = "123")]
	public bool AGIEFONNMMI(float MGOPPJOJBHN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000451")]
	[Cpp2IlInjected.Address(RVA = "0x75E5B0", Offset = "0x75D9B0", VA = "0x18075E5B0", Slot = "124")]
	public void ELHOCJEEJEN(object KJAGMGIFCEM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000452")]
	[Cpp2IlInjected.Address(RVA = "0x75E5B0", Offset = "0x75D9B0", VA = "0x18075E5B0", Slot = "125")]
	public void NMGDEFKJBOC(object KJAGMGIFCEM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000453")]
	[Cpp2IlInjected.Address(RVA = "0x75E5B0", Offset = "0x75D9B0", VA = "0x18075E5B0", Slot = "126")]
	public void CEDEMEPPALB(object KJAGMGIFCEM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000454")]
	[Cpp2IlInjected.Address(RVA = "0x75E5B0", Offset = "0x75D9B0", VA = "0x18075E5B0", Slot = "127")]
	public void MLKIEMGEEPP(object KJAGMGIFCEM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000455")]
	[Cpp2IlInjected.Address(RVA = "0x75E5B0", Offset = "0x75D9B0", VA = "0x18075E5B0", Slot = "128")]
	public void JIEJNNBGOLL(Vector3 EFLODOEECNL, ForceMode ECLMBFBBBLC = ForceMode.Force)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000456")]
	[Cpp2IlInjected.Address(RVA = "0x75E5B0", Offset = "0x75D9B0", VA = "0x18075E5B0", Slot = "129")]
	public void DAMOCKENHBN(Vector3 EFLODOEECNL, Vector3 LPAPEIIOLFG, ForceMode ECLMBFBBBLC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000457")]
	[Cpp2IlInjected.Address(RVA = "0x75E5B0", Offset = "0x75D9B0", VA = "0x18075E5B0", Slot = "130")]
	public void IHABFMLHECC(Vector3 DMFFEFOAKAN, ForceMode ECLMBFBBBLC = ForceMode.Force)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000458")]
	[Cpp2IlInjected.Address(RVA = "0x75E5B0", Offset = "0x75D9B0", VA = "0x18075E5B0", Slot = "131")]
	public void HBFKEDFPHOF(Vector3 DMFFEFOAKAN, ForceMode ECLMBFBBBLC = ForceMode.Force)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000459")]
	[Cpp2IlInjected.Address(RVA = "0x61CCBE0", Offset = "0x61CBFE0", VA = "0x1861CCBE0", Slot = "132")]
	public bool ODAFJKGPNED(Vector3 PIOPMIBANBL, [Out] RaycastHit HMHFDOFNLKF, float EJKOOCGEPCD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600045A")]
	[Cpp2IlInjected.Address(RVA = "0x75E5B0", Offset = "0x75D9B0", VA = "0x18075E5B0", Slot = "133")]
	public void GKIFGLBKBIO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600045B")]
	[Cpp2IlInjected.Address(RVA = "0x76C4B0", Offset = "0x76B8B0", VA = "0x18076C4B0")]
	public FFMAHKNCHGA()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000043")]
public sealed class JHDIBBNGJAD : GAGFBDFNKIL, CMHAFMKPEIJ, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
	[Cpp2IlInjected.Token(Token = "0x4000075")]
	internal LHNHNFAONOD GIPGBEGNLCD;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
	[Cpp2IlInjected.Token(Token = "0x4000076")]
	internal JICJPEPDNGF DDAGJDFMOOK;

	[Cpp2IlInjected.Token(Token = "0x600045D")]
	[Cpp2IlInjected.Address(RVA = "0x61D69E0", Offset = "0x61D5DE0", VA = "0x1861D69E0")]
	public JHDIBBNGJAD(GameObject IPAGFDLNMDK, RigidbodyEx AMNEOLIHGBG, HPGKIKLHCAJ GCLFDBLLOOM, [In] MCODEJBAGCN GHFAAPNAFDE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600045E")]
	[Cpp2IlInjected.Address(RVA = "0x61DED90", Offset = "0x61DE190", VA = "0x1861DED90", Slot = "135")]
	protected override void PCLCNIGBNMN(HPGKIKLHCAJ GCLFDBLLOOM, MCODEJBAGCN GHFAAPNAFDE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600045F")]
	[Cpp2IlInjected.Address(RVA = "0x75E5C0", Offset = "0x75D9C0", VA = "0x18075E5C0", Slot = "141")]
	protected override IDisposable BDPKCANAMIG()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000460")]
	[Cpp2IlInjected.Address(RVA = "0x61DE620", Offset = "0x61DDA20", VA = "0x1861DE620", Slot = "136")]
	public override void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000461")]
	[Cpp2IlInjected.Address(RVA = "0x61DE550", Offset = "0x61DD950", VA = "0x1861DE550", Slot = "142")]
	public void APDEAFCKNDE(AKBGEPMPOEB DIPNGLKFBLA, AKBGEPMPOEB GBMOELLOINK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000462")]
	[Cpp2IlInjected.Address(RVA = "0x61DEC70", Offset = "0x61DE070", VA = "0x1861DEC70", Slot = "143")]
	public void LOPOMNEKBAN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000463")]
	[Cpp2IlInjected.Address(RVA = "0x61DEBB0", Offset = "0x61DDFB0", VA = "0x1861DEBB0", Slot = "144")]
	public void LLCLFKGFNGB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000464")]
	[Cpp2IlInjected.Address(RVA = "0x61DEB50", Offset = "0x61DDF50", VA = "0x1861DEB50", Slot = "145")]
	public void JPEOPDBIOFK(bool JOAAGNJLPGK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000465")]
	[Cpp2IlInjected.Address(RVA = "0x61DE9C0", Offset = "0x61DDDC0", VA = "0x1861DE9C0", Slot = "146")]
	public bool IDNBMLHGDPE()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000466")]
	[Cpp2IlInjected.Address(RVA = "0x61DED30", Offset = "0x61DE130", VA = "0x1861DED30", Slot = "147")]
	public void MOMDHNAMCAE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000467")]
	[Cpp2IlInjected.Address(RVA = "0x75E5B0", Offset = "0x75D9B0", VA = "0x18075E5B0", Slot = "140")]
	protected override void MEPJJFMJFNH(RigidbodyEx IAIELCEKOPH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000468")]
	[Cpp2IlInjected.Address(RVA = "0x61DE790", Offset = "0x61DDB90", VA = "0x1861DE790")]
	private void FCBDNEPNEHB()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000044")]
internal static class LLEJEGLNEND
{
	[Cpp2IlInjected.Token(Token = "0x6000469")]
	[Cpp2IlInjected.Address(RVA = "0x61E0C00", Offset = "0x61E0000", VA = "0x1861E0C00")]
	public static GAGFBDFNKIL BAHAILFFEJD(this MGCGGKFMJCL MPPIIABEOMK)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000045")]
public interface NMDGCMCCOIC : DODNAMHPMBE, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x600046A")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void FFDAFIGKKAE(MGCGGKFMJCL GOCPNHJEOMK);

	[Cpp2IlInjected.Token(Token = "0x600046B")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void AEELOJHOFOJ(MGCGGKFMJCL GOCPNHJEOMK);

	[Cpp2IlInjected.Token(Token = "0x600046C")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void BBIGCFCEDHB(MGCGGKFMJCL OCLMFMCHMIF);

	[Cpp2IlInjected.Token(Token = "0x600046D")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void PDGMODPOCJI(MGCGGKFMJCL OCLMFMCHMIF);
}
[Cpp2IlInjected.Token(Token = "0x2000046")]
public interface NEECKHILPCI : ABHLGLKCJNI
{
	[Cpp2IlInjected.Token(Token = "0x17000124")]
	AGPLLJLGCBI<MGCGGKFMJCL> IGJGAIEIOHM
	{
		[Cpp2IlInjected.Token(Token = "0x600046E")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000125")]
	MGCGGKFMJCL EACDANCLLGP
	{
		[Cpp2IlInjected.Token(Token = "0x600046F")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000047")]
public interface OBLACOOCDDP : JBNKCGNKKDA
{
	[Cpp2IlInjected.Token(Token = "0x6000470")]
	[Cpp2IlInjected.Address(Slot = "0")]
	(float, Vector3) PLCHCHHMFEE(Rigidbody JPOHMONKAKL);
}
[Cpp2IlInjected.Token(Token = "0x2000048")]
public interface JECGIBNKHNN : KHGIDGJJCDM, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x17000126")]
	PhotonView GNBBPGMJJBA
	{
		[Cpp2IlInjected.Token(Token = "0x6000471")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000049")]
internal sealed class EPKAGLEBLDJ : EGPHOJFLGHI
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000077")]
	private readonly GAGFBDFNKIL GOCPNHJEOMK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000078")]
	private CollisionDetectionMode MIEPGEKOHHC;

	[Cpp2IlInjected.Token(Token = "0x17000127")]
	private Rigidbody ACNJBLDPNFK
	{
		[Cpp2IlInjected.Token(Token = "0x6000472")]
		[Cpp2IlInjected.Address(RVA = "0x61C05B0", Offset = "0x61BF9B0", VA = "0x1861C05B0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000128")]
	public CollisionDetectionMode GDLPEHNGKFD
	{
		[Cpp2IlInjected.Token(Token = "0x6000476")]
		[Cpp2IlInjected.Address(RVA = "0x61CC2B0", Offset = "0x61CB6B0", VA = "0x1861CC2B0", Slot = "4")]
		get
		{
			return default(CollisionDetectionMode);
		}
		[Cpp2IlInjected.Token(Token = "0x6000477")]
		[Cpp2IlInjected.Address(RVA = "0x61CC0A0", Offset = "0x61CB4A0", VA = "0x1861CC0A0", Slot = "5")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000473")]
	[Cpp2IlInjected.Address(RVA = "0x61C8CB0", Offset = "0x61C80B0", VA = "0x1861C8CB0")]
	public EPKAGLEBLDJ(MGCGGKFMJCL GOCPNHJEOMK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000474")]
	[Cpp2IlInjected.Address(RVA = "0x61CC190", Offset = "0x61CB590", VA = "0x1861CC190", Slot = "6")]
	public void JHKGOCECMOM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000475")]
	[Cpp2IlInjected.Address(RVA = "0x61CC110", Offset = "0x61CB510", VA = "0x1861CC110", Slot = "9")]
	public void INHOGFJCLDO(Rigidbody GEBCPMOBIAB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000478")]
	[Cpp2IlInjected.Address(RVA = "0x61CC2A0", Offset = "0x61CB6A0", VA = "0x1861CC2A0", Slot = "7")]
	public void KFCPEKBBFHO(bool EDKKJDCOKAE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000479")]
	[Cpp2IlInjected.Address(RVA = "0x61CC090", Offset = "0x61CB490", VA = "0x1861CC090", Slot = "8")]
	public void AIOGIJPDAML(bool EDKKJDCOKAE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600047A")]
	[Cpp2IlInjected.Address(RVA = "0x61CC4E0", Offset = "0x61CB8E0", VA = "0x1861CC4E0", Slot = "10")]
	public bool ODAFJKGPNED(Vector3 PIOPMIBANBL, [Out] RaycastHit HMHFDOFNLKF, float EJKOOCGEPCD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600047B")]
	[Cpp2IlInjected.Address(RVA = "0x61CC3C0", Offset = "0x61CB7C0", VA = "0x1861CC3C0")]
	private void NOPCCBDHDEG(bool EDKKJDCOKAE)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200004A")]
public sealed class NBFHDDJICHB : KKFFFGDLIIM, IDisposable, AOCMGNBNDFN
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400007A")]
	private readonly GAGFBDFNKIL GOCPNHJEOMK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400007B")]
	private CEAJINAKHIE HBFADNKJGAD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400007C")]
	private ADPDPCABPGF HJFNEMJECHL;

	[Cpp2IlInjected.Token(Token = "0x17000129")]
	public CEAJINAKHIE IJNJIINAHIE
	{
		[Cpp2IlInjected.Token(Token = "0x600047E")]
		[Cpp2IlInjected.Address(RVA = "0x61E1410", Offset = "0x61E0810", VA = "0x1861E1410", Slot = "6")]
		get
		{
			return default(CEAJINAKHIE);
		}
		[Cpp2IlInjected.Token(Token = "0x600047F")]
		[Cpp2IlInjected.Address(RVA = "0x61E1A30", Offset = "0x61E0E30", VA = "0x1861E1A30", Slot = "7")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700012A")]
	private Transform ANFMPJKHDJI
	{
		[Cpp2IlInjected.Token(Token = "0x6000480")]
		[Cpp2IlInjected.Address(RVA = "0x61E1660", Offset = "0x61E0A60", VA = "0x1861E1660", Slot = "10")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000041")]
	public event Action<ADKLLFONPNJ, ADKLLFONPNJ> IEAAAMEAGPG
	{
		[Cpp2IlInjected.Token(Token = "0x600047C")]
		[Cpp2IlInjected.Address(RVA = "0x61E1980", Offset = "0x61E0D80", VA = "0x1861E1980", Slot = "4")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600047D")]
		[Cpp2IlInjected.Address(RVA = "0x61E15B0", Offset = "0x61E09B0", VA = "0x1861E15B0", Slot = "5")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000481")]
	[Cpp2IlInjected.Address(RVA = "0x61E1B00", Offset = "0x61E0F00", VA = "0x1861E1B00")]
	public NBFHDDJICHB(MGCGGKFMJCL GOCPNHJEOMK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000482")]
	[Cpp2IlInjected.Address(RVA = "0x61E1680", Offset = "0x61E0A80", VA = "0x1861E1680", Slot = "8")]
	public void JHKGOCECMOM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000483")]
	[Cpp2IlInjected.Address(RVA = "0x61E1560", Offset = "0x61E0960", VA = "0x1861E1560", Slot = "9")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000484")]
	[Cpp2IlInjected.Address(RVA = "0x1A68A70", Offset = "0x1A67E70", VA = "0x181A68A70", Slot = "11")]
	private void IADNBHEEDIP(ADKLLFONPNJ MMFHEIEDPEL, ADKLLFONPNJ FIFGGNDENCP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000485")]
	[Cpp2IlInjected.Address(RVA = "0x75E5B0", Offset = "0x75D9B0", VA = "0x18075E5B0", Slot = "12")]
	private void LPEGHHFDBBO(bool IGHHIFPBDLK)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200004B")]
internal sealed class DGPNJAJFFJD : LDADHEPIIJJ
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400007D")]
	private readonly GAGFBDFNKIL GOCPNHJEOMK;

	[Cpp2IlInjected.Token(Token = "0x1700012B")]
	private Rigidbody ACNJBLDPNFK
	{
		[Cpp2IlInjected.Token(Token = "0x6000486")]
		[Cpp2IlInjected.Address(RVA = "0x61C05B0", Offset = "0x61BF9B0", VA = "0x1861C05B0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700012C")]
	private bool HCGHILJJDJE
	{
		[Cpp2IlInjected.Token(Token = "0x6000487")]
		[Cpp2IlInjected.Address(RVA = "0x61C9910", Offset = "0x61C8D10", VA = "0x1861C9910")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700012D")]
	private bool EKDOCCFKAGJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000488")]
		[Cpp2IlInjected.Address(RVA = "0x61C98B0", Offset = "0x61C8CB0", VA = "0x1861C98B0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700012E")]
	private MGCGGKFMJCL NCEKKJFNJNC
	{
		[Cpp2IlInjected.Token(Token = "0x6000489")]
		[Cpp2IlInjected.Address(RVA = "0x61C95D0", Offset = "0x61C89D0", VA = "0x1861C95D0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600048A")]
	[Cpp2IlInjected.Address(RVA = "0x61C8CB0", Offset = "0x61C80B0", VA = "0x1861C8CB0")]
	public DGPNJAJFFJD(MGCGGKFMJCL GOCPNHJEOMK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600048B")]
	[Cpp2IlInjected.Address(RVA = "0x61C9F80", Offset = "0x61C9380", VA = "0x1861C9F80", Slot = "4")]
	public void JIEJNNBGOLL(Vector3 EFLODOEECNL, ForceMode ECLMBFBBBLC = ForceMode.Force)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600048C")]
	[Cpp2IlInjected.Address(RVA = "0x61C9D20", Offset = "0x61C9120", VA = "0x1861C9D20")]
	private void JFFHCOICFAF(Vector3 EFLODOEECNL, ForceMode ECLMBFBBBLC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600048D")]
	[Cpp2IlInjected.Address(RVA = "0x61C9630", Offset = "0x61C8A30", VA = "0x1861C9630", Slot = "5")]
	public void DAMOCKENHBN(Vector3 EFLODOEECNL, Vector3 LPAPEIIOLFG, ForceMode ECLMBFBBBLC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600048E")]
	[Cpp2IlInjected.Address(RVA = "0x61C9BC0", Offset = "0x61C8FC0", VA = "0x1861C9BC0", Slot = "6")]
	public void IHABFMLHECC(Vector3 DMFFEFOAKAN, ForceMode ECLMBFBBBLC = ForceMode.Force)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600048F")]
	[Cpp2IlInjected.Address(RVA = "0x61CA0E0", Offset = "0x61C94E0", VA = "0x1861CA0E0")]
	private void OKDFPLMECAA(Vector3 DMFFEFOAKAN, ForceMode ECLMBFBBBLC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000490")]
	[Cpp2IlInjected.Address(RVA = "0x61C9960", Offset = "0x61C8D60", VA = "0x1861C9960", Slot = "7")]
	public void HBFKEDFPHOF(Vector3 DMFFEFOAKAN, ForceMode ECLMBFBBBLC = ForceMode.Force)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200004C")]
internal sealed class CMPJLMHCPGJ : HOGMIDIDFNH
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400007E")]
	private readonly GAGFBDFNKIL GOCPNHJEOMK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400007F")]
	private bool IOHHCAGIIOM;

	[Cpp2IlInjected.Token(Token = "0x1700012F")]
	public bool PLJCHFLJNEH
	{
		[Cpp2IlInjected.Token(Token = "0x6000492")]
		[Cpp2IlInjected.Address(RVA = "0x7D0020", Offset = "0x7CF420", VA = "0x1807D0020", Slot = "4")]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000493")]
		[Cpp2IlInjected.Address(RVA = "0x61C8B70", Offset = "0x61C7F70", VA = "0x1861C8B70", Slot = "5")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000491")]
	[Cpp2IlInjected.Address(RVA = "0x61C8CB0", Offset = "0x61C80B0", VA = "0x1861C8CB0")]
	public CMPJLMHCPGJ(MGCGGKFMJCL GOCPNHJEOMK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000494")]
	[Cpp2IlInjected.Address(RVA = "0x61C8C80", Offset = "0x61C8080", VA = "0x1861C8C80", Slot = "6")]
	public void INHOGFJCLDO(Rigidbody GEBCPMOBIAB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000495")]
	[Cpp2IlInjected.Address(RVA = "0x61C47F0", Offset = "0x61C3BF0", VA = "0x1861C47F0", Slot = "7")]
	public void FLMHAOMIJON(Rigidbody GEBCPMOBIAB)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200004D")]
internal sealed class GMOBIMFMLMD : NMDGCMCCOIC, DODNAMHPMBE, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x4000089")]
	private readonly MGCGGKFMJCL GOCPNHJEOMK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x400008A")]
	private readonly List<MGCGGKFMJCL> JHOBIGGNOKP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x400008B")]
	private MGCGGKFMJCL OGEFIHKILIO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x400008C")]
	private MGCGGKFMJCL EBFCMPBKGBM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
	[Cpp2IlInjected.Token(Token = "0x400008D")]
	private Transform PMIEACBJEDK;

	[Cpp2IlInjected.Token(Token = "0x17000130")]
	private Transform JGKOKOJENGE
	{
		[Cpp2IlInjected.Token(Token = "0x60004A8")]
		[Cpp2IlInjected.Address(RVA = "0x61D9E20", Offset = "0x61D9220", VA = "0x1861D9E20")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000131")]
	public MGCGGKFMJCL NCEKKJFNJNC
	{
		[Cpp2IlInjected.Token(Token = "0x60004AB")]
		[Cpp2IlInjected.Address(RVA = "0x761D10", Offset = "0x761110", VA = "0x180761D10", Slot = "28")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60004AC")]
		[Cpp2IlInjected.Address(RVA = "0x61D9650", Offset = "0x61D8A50", VA = "0x1861D9650", Slot = "29")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000132")]
	public MGCGGKFMJCL DFDPGOHHPEM
	{
		[Cpp2IlInjected.Token(Token = "0x60004AD")]
		[Cpp2IlInjected.Address(RVA = "0x7610F0", Offset = "0x7604F0", VA = "0x1807610F0", Slot = "27")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000133")]
	public IReadOnlyList<MGCGGKFMJCL> FCCNECOIHNG
	{
		[Cpp2IlInjected.Token(Token = "0x60004AE")]
		[Cpp2IlInjected.Address(RVA = "0x7610A0", Offset = "0x7604A0", VA = "0x1807610A0", Slot = "26")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000042")]
	public event LNNBFANOADD ELBIILPLBLJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000496")]
		[Cpp2IlInjected.Address(RVA = "0x61DA1E0", Offset = "0x61D95E0", VA = "0x1861DA1E0", Slot = "8")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000497")]
		[Cpp2IlInjected.Address(RVA = "0x61D9E80", Offset = "0x61D9280", VA = "0x1861D9E80", Slot = "9")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000043")]
	public event LNNBFANOADD CBNGEFCLMOB
	{
		[Cpp2IlInjected.Token(Token = "0x6000498")]
		[Cpp2IlInjected.Address(RVA = "0x61D9310", Offset = "0x61D8710", VA = "0x1861D9310", Slot = "10")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000499")]
		[Cpp2IlInjected.Address(RVA = "0x61D9460", Offset = "0x61D8860", VA = "0x1861D9460", Slot = "11")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000044")]
	public event OKIHMFHNBGG IACLPHDLFGN
	{
		[Cpp2IlInjected.Token(Token = "0x600049A")]
		[Cpp2IlInjected.Address(RVA = "0x61DA810", Offset = "0x61D9C10", VA = "0x1861DA810", Slot = "12")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600049B")]
		[Cpp2IlInjected.Address(RVA = "0x61DA3B0", Offset = "0x61D97B0", VA = "0x1861DA3B0", Slot = "13")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000045")]
	public event Action GLGKNBAGMIP
	{
		[Cpp2IlInjected.Token(Token = "0x600049C")]
		[Cpp2IlInjected.Address(RVA = "0x61D9F20", Offset = "0x61D9320", VA = "0x1861D9F20", Slot = "14")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600049D")]
		[Cpp2IlInjected.Address(RVA = "0x61D8E60", Offset = "0x61D8260", VA = "0x1861D8E60", Slot = "15")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000046")]
	public event Action FEEIKIIDIDI
	{
		[Cpp2IlInjected.Token(Token = "0x600049E")]
		[Cpp2IlInjected.Address(RVA = "0x61DA590", Offset = "0x61D9990", VA = "0x1861DA590", Slot = "16")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600049F")]
		[Cpp2IlInjected.Address(RVA = "0x61DA140", Offset = "0x61D9540", VA = "0x1861DA140", Slot = "17")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000047")]
	public event Action<MGCGGKFMJCL> HGADFPCMNGJ
	{
		[Cpp2IlInjected.Token(Token = "0x60004A0")]
		[Cpp2IlInjected.Address(RVA = "0x61D9500", Offset = "0x61D8900", VA = "0x1861D9500", Slot = "18")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60004A1")]
		[Cpp2IlInjected.Address(RVA = "0x61D93B0", Offset = "0x61D87B0", VA = "0x1861D93B0", Slot = "19")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000048")]
	public event Action<MGCGGKFMJCL> DIBBGPAFGIG
	{
		[Cpp2IlInjected.Token(Token = "0x60004A2")]
		[Cpp2IlInjected.Address(RVA = "0x61D9170", Offset = "0x61D8570", VA = "0x1861D9170", Slot = "20")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60004A3")]
		[Cpp2IlInjected.Address(RVA = "0x61DA630", Offset = "0x61D9A30", VA = "0x1861DA630", Slot = "21")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000049")]
	public event Action GMFKHKBHJIH
	{
		[Cpp2IlInjected.Token(Token = "0x60004A4")]
		[Cpp2IlInjected.Address(RVA = "0x61DA450", Offset = "0x61D9850", VA = "0x1861DA450", Slot = "22")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60004A5")]
		[Cpp2IlInjected.Address(RVA = "0x61DA4F0", Offset = "0x61D98F0", VA = "0x1861DA4F0", Slot = "23")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400004A")]
	public event Action<MGCGGKFMJCL> DEOECEFBMHF
	{
		[Cpp2IlInjected.Token(Token = "0x60004A6")]
		[Cpp2IlInjected.Address(RVA = "0x61D8DB0", Offset = "0x61D81B0", VA = "0x1861D8DB0", Slot = "24")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60004A7")]
		[Cpp2IlInjected.Address(RVA = "0x61D9750", Offset = "0x61D8B50", VA = "0x1861D9750", Slot = "25")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60004A9")]
	[Cpp2IlInjected.Address(RVA = "0x61DAB30", Offset = "0x61D9F30", VA = "0x1861DAB30")]
	public GMOBIMFMLMD(MGCGGKFMJCL GOCPNHJEOMK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004AA")]
	[Cpp2IlInjected.Address(RVA = "0x61D95B0", Offset = "0x61D89B0", VA = "0x1861D95B0", Slot = "31")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004AF")]
	[Cpp2IlInjected.Address(RVA = "0x61D9800", Offset = "0x61D8C00", VA = "0x1861D9800", Slot = "30")]
	public void HEBPNKMJKGE(MGCGGKFMJCL JOOENMAHIDL, bool ABHJANDGLGK = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004B0")]
	[Cpp2IlInjected.Address(RVA = "0x61D8F00", Offset = "0x61D8300", VA = "0x1861D8F00", Slot = "6")]
	public void BBIGCFCEDHB(MGCGGKFMJCL OCLMFMCHMIF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004B1")]
	[Cpp2IlInjected.Address(RVA = "0x61DA8B0", Offset = "0x61D9CB0", VA = "0x1861DA8B0", Slot = "7")]
	public void PDGMODPOCJI(MGCGGKFMJCL OCLMFMCHMIF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004B2")]
	[Cpp2IlInjected.Address(RVA = "0x61D9660", Offset = "0x61D8A60", VA = "0x1861D9660", Slot = "4")]
	public void FFDAFIGKKAE(MGCGGKFMJCL GOCPNHJEOMK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004B3")]
	[Cpp2IlInjected.Address(RVA = "0x61D8D10", Offset = "0x61D8110", VA = "0x1861D8D10", Slot = "5")]
	public void AEELOJHOFOJ(MGCGGKFMJCL GOCPNHJEOMK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004B4")]
	[Cpp2IlInjected.Address(RVA = "0x61D9D80", Offset = "0x61D9180", VA = "0x1861D9D80")]
	private void HFLLBCEPJAO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004B5")]
	[Cpp2IlInjected.Address(RVA = "0x61DA100", Offset = "0x61D9500", VA = "0x1861DA100")]
	private void KOLJIHDPMJA(MGCGGKFMJCL OCLMFMCHMIF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004B6")]
	[Cpp2IlInjected.Address(RVA = "0x61D9FC0", Offset = "0x61D93C0", VA = "0x1861D9FC0")]
	private void JBCPKKAMELA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004B7")]
	[Cpp2IlInjected.Address(RVA = "0x61DA6E0", Offset = "0x61D9AE0", VA = "0x1861DA6E0")]
	private void OCJOGEFDKAE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004B8")]
	[Cpp2IlInjected.Address(RVA = "0x61DA280", Offset = "0x61D9680", VA = "0x1861DA280")]
	private void LPCOGGOILJL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004B9")]
	[Cpp2IlInjected.Address(RVA = "0x61D9220", Offset = "0x61D8620", VA = "0x1861D9220")]
	[CompilerGenerated]
	private object BDHJJHFJJMI()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200004E")]
internal static class LCCJPCNFNFC
{
	[Cpp2IlInjected.Token(Token = "0x60004BA")]
	[Cpp2IlInjected.Address(RVA = "0x61E0B40", Offset = "0x61DFF40", VA = "0x1861E0B40")]
	public static NMDGCMCCOIC IKJMCNLLEAF(this MGCGGKFMJCL MPPIIABEOMK)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200004F")]
internal sealed class GJDOFKHCCBF : NEECKHILPCI, ABHLGLKCJNI
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400008E")]
	private readonly GAGFBDFNKIL GOCPNHJEOMK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400008F")]
	private readonly AGPLLJLGCBI<MGCGGKFMJCL> HPMGLEIOFBM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000090")]
	private bool KNIBOBCHDPG;

	[Cpp2IlInjected.Token(Token = "0x17000134")]
	public AGPLLJLGCBI<MGCGGKFMJCL> IGJGAIEIOHM
	{
		[Cpp2IlInjected.Token(Token = "0x60004BB")]
		[Cpp2IlInjected.Address(RVA = "0x75C540", Offset = "0x75B940", VA = "0x18075C540", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000135")]
	public Vector3 IADJPHPDBGC
	{
		[Cpp2IlInjected.Token(Token = "0x60004BC")]
		[Cpp2IlInjected.Address(RVA = "0x61D8BE0", Offset = "0x61D7FE0", VA = "0x1861D8BE0", Slot = "6")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000136")]
	public Vector3 FNFHIDNBNCJ
	{
		[Cpp2IlInjected.Token(Token = "0x60004BD")]
		[Cpp2IlInjected.Address(RVA = "0x61D85C0", Offset = "0x61D79C0", VA = "0x1861D85C0", Slot = "7")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000137")]
	private Vector3 DPFKMNPADOM
	{
		[Cpp2IlInjected.Token(Token = "0x60004C1")]
		[Cpp2IlInjected.Address(RVA = "0x61D8090", Offset = "0x61D7490", VA = "0x1861D8090")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000138")]
	public MGCGGKFMJCL EACDANCLLGP
	{
		[Cpp2IlInjected.Token(Token = "0x60004C2")]
		[Cpp2IlInjected.Address(RVA = "0x61D8510", Offset = "0x61D7910", VA = "0x1861D8510", Slot = "5")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60004BE")]
	[Cpp2IlInjected.Address(RVA = "0x61D8C10", Offset = "0x61D8010", VA = "0x1861D8C10")]
	public GJDOFKHCCBF(MGCGGKFMJCL GOCPNHJEOMK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004BF")]
	[Cpp2IlInjected.Address(RVA = "0x61D8780", Offset = "0x61D7B80", VA = "0x1861D8780", Slot = "8")]
	public void JNLJFCKDFBA(MGCGGKFMJCL EBFCMPBKGBM, object KJAGMGIFCEM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004C0")]
	[Cpp2IlInjected.Address(RVA = "0x61D8B80", Offset = "0x61D7F80", VA = "0x1861D8B80", Slot = "9")]
	public void JOBKNFFOIEF(object KJAGMGIFCEM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004C3")]
	[Cpp2IlInjected.Address(RVA = "0x61D87F0", Offset = "0x61D7BF0", VA = "0x1861D87F0")]
	private Vector3 JOAPCBPAMID()
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x60004C4")]
	[Cpp2IlInjected.Address(RVA = "0x61D8180", Offset = "0x61D7580", VA = "0x1861D8180")]
	private void BHJFDNEOAHE(MGCGGKFMJCL LFPIAGINKND)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000050")]
internal static class APDFLNDGDEI
{
	[Cpp2IlInjected.Token(Token = "0x60004C5")]
	[Cpp2IlInjected.Address(RVA = "0x61C46D0", Offset = "0x61C3AD0", VA = "0x1861C46D0")]
	public static NEECKHILPCI HEJFGDIPDIM(this MGCGGKFMJCL MPPIIABEOMK)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000051")]
internal sealed class BPPAFPILENI : OBLACOOCDDP, JBNKCGNKKDA
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000092")]
	private readonly GAGFBDFNKIL GOCPNHJEOMK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000093")]
	private readonly OverridableVector3 FPKHOCOFJCF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000094")]
	private readonly OverridableVector3 JCMGECPCAMP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000095")]
	private float HHMIADFKJAI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x44")]
	[Cpp2IlInjected.Token(Token = "0x4000096")]
	private float EIEGGECHILO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000097")]
	private Vector3 LPPFPBKJMOB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x54")]
	[Cpp2IlInjected.Token(Token = "0x4000098")]
	private Vector3? KOCDIBFJMBC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x64")]
	[Cpp2IlInjected.Token(Token = "0x4000099")]
	private Quaternion? IFLJBMOEDHG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
	[Cpp2IlInjected.Token(Token = "0x400009A")]
	private bool OGGHOJCOMLB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x79")]
	[Cpp2IlInjected.Token(Token = "0x400009B")]
	private bool BJEOGJMMHMB;

	[Cpp2IlInjected.Token(Token = "0x17000139")]
	public Vector3 NIBENPFEBFL
	{
		[Cpp2IlInjected.Token(Token = "0x60004C8")]
		[Cpp2IlInjected.Address(RVA = "0xF8CCA0", Offset = "0xF8C0A0", VA = "0x180F8CCA0", Slot = "7")]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x60004C9")]
		[Cpp2IlInjected.Address(RVA = "0x61C5A00", Offset = "0x61C4E00", VA = "0x1861C5A00", Slot = "8")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700013A")]
	public Vector3 JOKPJCADMPL
	{
		[Cpp2IlInjected.Token(Token = "0x60004CA")]
		[Cpp2IlInjected.Address(RVA = "0x61C6C30", Offset = "0x61C6030", VA = "0x1861C6C30", Slot = "9")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700013B")]
	public float MAMOOAGGOAI
	{
		[Cpp2IlInjected.Token(Token = "0x60004CB")]
		[Cpp2IlInjected.Address(RVA = "0x10354F0", Offset = "0x10348F0", VA = "0x1810354F0", Slot = "10")]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x60004CC")]
		[Cpp2IlInjected.Address(RVA = "0x61C6D30", Offset = "0x61C6130", VA = "0x1861C6D30")]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700013C")]
	public float AIGIACKFCCL
	{
		[Cpp2IlInjected.Token(Token = "0x60004CD")]
		[Cpp2IlInjected.Address(RVA = "0xAE9490", Offset = "0xAE8890", VA = "0x180AE9490", Slot = "11")]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x60004CE")]
		[Cpp2IlInjected.Address(RVA = "0x61C5950", Offset = "0x61C4D50", VA = "0x1861C5950", Slot = "12")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700013D")]
	public Vector3 CAPAJCKGOEI
	{
		[Cpp2IlInjected.Token(Token = "0x60004CF")]
		[Cpp2IlInjected.Address(RVA = "0x61C5640", Offset = "0x61C4A40", VA = "0x1861C5640", Slot = "13")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700013E")]
	public Quaternion DICIGDCIMAG
	{
		[Cpp2IlInjected.Token(Token = "0x60004D0")]
		[Cpp2IlInjected.Address(RVA = "0x61C57D0", Offset = "0x61C4BD0", VA = "0x1861C57D0", Slot = "14")]
		get
		{
			return default(Quaternion);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700013F")]
	private Rigidbody ACNJBLDPNFK
	{
		[Cpp2IlInjected.Token(Token = "0x60004D8")]
		[Cpp2IlInjected.Address(RVA = "0x61C6A60", Offset = "0x61C5E60", VA = "0x1861C6A60")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400004B")]
	public event LNNBFANOADD DIFBMICLCDD
	{
		[Cpp2IlInjected.Token(Token = "0x60004C6")]
		[Cpp2IlInjected.Address(RVA = "0x61C5D80", Offset = "0x61C5180", VA = "0x1861C5D80", Slot = "5")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60004C7")]
		[Cpp2IlInjected.Address(RVA = "0x61C5CE0", Offset = "0x61C50E0", VA = "0x1861C5CE0", Slot = "6")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60004D1")]
	[Cpp2IlInjected.Address(RVA = "0x61C80C0", Offset = "0x61C74C0", VA = "0x1861C80C0")]
	public BPPAFPILENI(MGCGGKFMJCL GOCPNHJEOMK, [In] MCODEJBAGCN GHFAAPNAFDE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004D2")]
	[Cpp2IlInjected.Address(RVA = "0x61C5FC0", Offset = "0x61C53C0", VA = "0x1861C5FC0", Slot = "17")]
	public void FJPECHAAMGI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004D3")]
	[Cpp2IlInjected.Address(RVA = "0x61C6400", Offset = "0x61C5800", VA = "0x1861C6400", Slot = "16")]
	public void GGKIHNLFLKG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004D4")]
	[Cpp2IlInjected.Address(RVA = "0x61C6980", Offset = "0x61C5D80", VA = "0x1861C6980", Slot = "19")]
	public void INHOGFJCLDO(Rigidbody GEBCPMOBIAB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004D5")]
	[Cpp2IlInjected.Address(RVA = "0x61C6170", Offset = "0x61C5570", VA = "0x1861C6170", Slot = "20")]
	public void FLMHAOMIJON(Rigidbody GEBCPMOBIAB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004D6")]
	[Cpp2IlInjected.Address(RVA = "0x61C6F30", Offset = "0x61C6330", VA = "0x1861C6F30", Slot = "18")]
	public void KOHGBDIONNB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004D7")]
	[Cpp2IlInjected.Address(RVA = "0x61C64E0", Offset = "0x61C58E0", VA = "0x1861C64E0", Slot = "21")]
	public void GKIFGLBKBIO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004D9")]
	[Cpp2IlInjected.Address(RVA = "0x61C5A00", Offset = "0x61C4E00", VA = "0x1861C5A00")]
	private void DIBKJFEGPJI(Vector3 EOHMJBFGDPD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004DA")]
	[Cpp2IlInjected.Address(RVA = "0x61C6E40", Offset = "0x61C6240", VA = "0x1861C6E40")]
	[Obsolete("This method is dangerous - the unity rigidbody is updated in a deferred manner and this world position may be stale")]
	private Vector3 KMGAHIDPOPA()
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x60004DB")]
	[Cpp2IlInjected.Address(RVA = "0x61C6D30", Offset = "0x61C6130", VA = "0x1861C6D30")]
	private void LCONLBEOBAK(float EOHMJBFGDPD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004DC")]
	[Cpp2IlInjected.Address(RVA = "0x61C5950", Offset = "0x61C4D50", VA = "0x1861C5950")]
	private void DHMNCGOFAEM(float EOHMJBFGDPD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004DD")]
	[Cpp2IlInjected.Address(RVA = "0x61C5E20", Offset = "0x61C5220", VA = "0x1861C5E20")]
	private Vector3 FAIJDFIJJFM()
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x60004DE")]
	[Cpp2IlInjected.Address(RVA = "0x61C5AB0", Offset = "0x61C4EB0", VA = "0x1861C5AB0", Slot = "15")]
	public void EEEEBLADLHM((Quaternion rot, Vector3 moments) NCNIHGBNECM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004DF")]
	[Cpp2IlInjected.Address(RVA = "0x61C6AB0", Offset = "0x61C5EB0", VA = "0x1861C6AB0")]
	private Quaternion JCEPBBHHPHE()
	{
		return default(Quaternion);
	}

	[Cpp2IlInjected.Token(Token = "0x60004E0")]
	[Cpp2IlInjected.Address(RVA = "0x61C70A0", Offset = "0x61C64A0", VA = "0x1861C70A0")]
	public void PLCHCHHMFEE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004E1")]
	[Cpp2IlInjected.Address(RVA = "0x61C7170", Offset = "0x61C6570", VA = "0x1861C7170", Slot = "4")]
	public (float, Vector3) PLCHCHHMFEE(Rigidbody JPOHMONKAKL)
	{
		return default((float, Vector3));
	}
}
[Cpp2IlInjected.Token(Token = "0x2000052")]
internal static class NMGMLCFOKON
{
	[Cpp2IlInjected.Token(Token = "0x60004E2")]
	[Cpp2IlInjected.Address(RVA = "0x61E3490", Offset = "0x61E2890", VA = "0x1861E3490")]
	public static OBLACOOCDDP EMKLNAEGGHO(this MGCGGKFMJCL MPPIIABEOMK)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000053")]
internal sealed class JKPHEILEEML : MFDACKEMCFN
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400009C")]
	private readonly GAGFBDFNKIL GOCPNHJEOMK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400009D")]
	private readonly HAMCJNIMIPK OBADADNLECC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400009E")]
	private readonly NCDNMOIPOGI LBALPLBNKBN;

	[Cpp2IlInjected.Token(Token = "0x17000140")]
	public bool GNHPGCKADIB
	{
		[Cpp2IlInjected.Token(Token = "0x60004E3")]
		[Cpp2IlInjected.Address(RVA = "0xC31A80", Offset = "0xC30E80", VA = "0x180C31A80", Slot = "10")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000141")]
	public NCDNMOIPOGI JGLMGGBJBOL
	{
		[Cpp2IlInjected.Token(Token = "0x60004E4")]
		[Cpp2IlInjected.Address(RVA = "0x8124E0", Offset = "0x8118E0", VA = "0x1808124E0", Slot = "11")]
		get
		{
			return default(NCDNMOIPOGI);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60004E5")]
	[Cpp2IlInjected.Address(RVA = "0x61DFC20", Offset = "0x61DF020", VA = "0x1861DFC20")]
	public JKPHEILEEML(MGCGGKFMJCL GOCPNHJEOMK, [In] MCODEJBAGCN GHFAAPNAFDE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004E6")]
	[Cpp2IlInjected.Address(RVA = "0x61DF890", Offset = "0x61DEC90", VA = "0x1861DF890", Slot = "4")]
	public void JHKGOCECMOM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004E7")]
	[Cpp2IlInjected.Address(RVA = "0x61DF670", Offset = "0x61DEA70", VA = "0x1861DF670")]
	private bool CCFOPFIBDPE()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60004E8")]
	[Cpp2IlInjected.Address(RVA = "0x61DFBF0", Offset = "0x61DEFF0", VA = "0x1861DFBF0", Slot = "5")]
	public void OKJADHJGFEH(object KJAGMGIFCEM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004E9")]
	[Cpp2IlInjected.Address(RVA = "0x61DF600", Offset = "0x61DEA00", VA = "0x1861DF600", Slot = "6")]
	public void AMFHLIBIOON(object KJAGMGIFCEM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004EA")]
	[Cpp2IlInjected.Address(RVA = "0x61DF750", Offset = "0x61DEB50", VA = "0x1861DF750", Slot = "9")]
	public void IGMOCGMLLHH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004EB")]
	[Cpp2IlInjected.Address(RVA = "0x61DF960", Offset = "0x61DED60", VA = "0x1861DF960")]
	private void LILIIIEDPAN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004EC")]
	[Cpp2IlInjected.Address(RVA = "0x61DFA80", Offset = "0x61DEE80", VA = "0x1861DFA80")]
	private void MKGELPDDHOJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004ED")]
	[Cpp2IlInjected.Address(RVA = "0x61DF710", Offset = "0x61DEB10", VA = "0x1861DF710", Slot = "8")]
	public void GNEEHHDPIKA(MGCGGKFMJCL GOCPNHJEOMK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004EE")]
	[Cpp2IlInjected.Address(RVA = "0x61DF630", Offset = "0x61DEA30", VA = "0x1861DF630", Slot = "7")]
	public void BKJBLAIOBGP(MGCGGKFMJCL GOCPNHJEOMK)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000054")]
internal sealed class HDBGODKFNJD : JNCIBBLAFHG
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000A0")]
	private readonly GAGFBDFNKIL GOCPNHJEOMK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000A1")]
	private readonly HAMCJNIMIPK MHCBBFOBEHI;

	[Cpp2IlInjected.Token(Token = "0x17000142")]
	public bool HCGHILJJDJE
	{
		[Cpp2IlInjected.Token(Token = "0x60004F1")]
		[Cpp2IlInjected.Address(RVA = "0x61DAE70", Offset = "0x61DA270", VA = "0x1861DAE70", Slot = "7")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400004C")]
	public event LNNBFANOADD OMDOLGBKNMB
	{
		[Cpp2IlInjected.Token(Token = "0x60004EF")]
		[Cpp2IlInjected.Address(RVA = "0x61DAF50", Offset = "0x61DA350", VA = "0x1861DAF50", Slot = "4")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60004F0")]
		[Cpp2IlInjected.Address(RVA = "0x61DACB0", Offset = "0x61DA0B0", VA = "0x1861DACB0", Slot = "5")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60004F2")]
	[Cpp2IlInjected.Address(RVA = "0x61DB130", Offset = "0x61DA530", VA = "0x1861DB130")]
	public HDBGODKFNJD(MGCGGKFMJCL GOCPNHJEOMK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004F3")]
	[Cpp2IlInjected.Address(RVA = "0x61DB0C0", Offset = "0x61DA4C0", VA = "0x1861DB0C0", Slot = "11")]
	public IDisposable ODOGLKJIBAL()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004F4")]
	[Cpp2IlInjected.Address(RVA = "0x61DAD50", Offset = "0x61DA150", VA = "0x1861DAD50", Slot = "8")]
	public void CLOLFMGHJID(object KJAGMGIFCEM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004F5")]
	[Cpp2IlInjected.Address(RVA = "0x61DB0B0", Offset = "0x61DA4B0", VA = "0x1861DB0B0", Slot = "9")]
	public void LAPKPJEEGPL(object KJAGMGIFCEM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004F6")]
	[Cpp2IlInjected.Address(RVA = "0x61DAD60", Offset = "0x61DA160", VA = "0x1861DAD60", Slot = "10")]
	public void EHLACEEGNEA(object KJAGMGIFCEM, bool LLALDMDCIAM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004F7")]
	[Cpp2IlInjected.Address(RVA = "0x61DB070", Offset = "0x61DA470", VA = "0x1861DB070", Slot = "6")]
	public void KCMCKENJMGM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004F8")]
	[Cpp2IlInjected.Address(RVA = "0x61DAFF0", Offset = "0x61DA3F0", VA = "0x1861DAFF0", Slot = "12")]
	public void INHOGFJCLDO(Rigidbody IMHHODKMCIF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004F9")]
	[Cpp2IlInjected.Address(RVA = "0x61DAF20", Offset = "0x61DA320", VA = "0x1861DAF20", Slot = "13")]
	public void FLMHAOMIJON(Rigidbody GEBCPMOBIAB)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000055")]
internal sealed class AJCANAMCOLH : JECGIBNKHNN, KHGIDGJJCDM, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000A3")]
	private readonly GAGFBDFNKIL GOCPNHJEOMK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000A4")]
	private PhotonView NDKIHJINLPA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40000A5")]
	private bool MCLEJOAMMMO;

	[Cpp2IlInjected.Token(Token = "0x17000143")]
	public PhotonView GNBBPGMJJBA
	{
		[Cpp2IlInjected.Token(Token = "0x60004FC")]
		[Cpp2IlInjected.Address(RVA = "0x764960", Offset = "0x763D60", VA = "0x180764960", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000144")]
	public bool FFIFGPLINHH
	{
		[Cpp2IlInjected.Token(Token = "0x60004FD")]
		[Cpp2IlInjected.Address(RVA = "0x61BFCC0", Offset = "0x61BF0C0", VA = "0x1861BFCC0", Slot = "7")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000145")]
	public bool HAEGEFIPLPF
	{
		[Cpp2IlInjected.Token(Token = "0x60004FE")]
		[Cpp2IlInjected.Address(RVA = "0x7CAC20", Offset = "0x7CA020", VA = "0x1807CAC20", Slot = "8")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400004D")]
	public event LNNBFANOADD PLAFGMCIMLA
	{
		[Cpp2IlInjected.Token(Token = "0x60004FA")]
		[Cpp2IlInjected.Address(RVA = "0x61BFC20", Offset = "0x61BF020", VA = "0x1861BFC20", Slot = "5")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60004FB")]
		[Cpp2IlInjected.Address(RVA = "0x61BF2A0", Offset = "0x61BE6A0", VA = "0x1861BF2A0", Slot = "6")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60004FF")]
	[Cpp2IlInjected.Address(RVA = "0x61BFE50", Offset = "0x61BF250", VA = "0x1861BFE50")]
	public AJCANAMCOLH(MGCGGKFMJCL GOCPNHJEOMK, [In] MCODEJBAGCN GHFAAPNAFDE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000500")]
	[Cpp2IlInjected.Address(RVA = "0x61BFAF0", Offset = "0x61BEEF0", VA = "0x1861BFAF0", Slot = "9")]
	public void JHKGOCECMOM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000501")]
	[Cpp2IlInjected.Address(RVA = "0x61BF4B0", Offset = "0x61BE8B0", VA = "0x1861BF4B0", Slot = "12")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000502")]
	[Cpp2IlInjected.Address(RVA = "0x61BFCE0", Offset = "0x61BF0E0", VA = "0x1861BFCE0", Slot = "10")]
	public void NBPCMILFJNH(MGCGGKFMJCL EBFCMPBKGBM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000503")]
	[Cpp2IlInjected.Address(RVA = "0x61BF340", Offset = "0x61BE740", VA = "0x1861BF340", Slot = "11")]
	public void DEJHAKKIFOI(MGCGGKFMJCL EBFCMPBKGBM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000504")]
	[Cpp2IlInjected.Address(RVA = "0x61BF820", Offset = "0x61BEC20", VA = "0x1861BF820")]
	private void IDLGHOEIKGE(PhotonView BFBAIANICFI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000505")]
	[Cpp2IlInjected.Address(RVA = "0x61BF990", Offset = "0x61BED90", VA = "0x1861BF990")]
	private void IHNIOPIEIMO(RigidbodyEx PBICMHFAPEC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000506")]
	[Cpp2IlInjected.Address(RVA = "0x61BF5B0", Offset = "0x61BE9B0", VA = "0x1861BF5B0")]
	private void HJFHBBLLJME(PhotonView NMAHDDKPKAH)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000056")]
internal static class GNOKCKBLPIE
{
	[Cpp2IlInjected.Token(Token = "0x6000507")]
	[Cpp2IlInjected.Address(RVA = "0x61DABF0", Offset = "0x61D9FF0", VA = "0x1861DABF0")]
	public static JECGIBNKHNN NELLMLBHNDK(this MGCGGKFMJCL MPPIIABEOMK)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000057")]
internal sealed class JHCNBBGPMOD : GKGLDPLOLIH
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000A6")]
	private readonly GAGFBDFNKIL GOCPNHJEOMK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000A7")]
	private RigidbodyConstraints GKGKDAIJEED;

	[Cpp2IlInjected.Token(Token = "0x17000146")]
	public bool PBOGKFDNBGB
	{
		[Cpp2IlInjected.Token(Token = "0x6000508")]
		[Cpp2IlInjected.Address(RVA = "0xA17C30", Offset = "0xA17030", VA = "0x180A17C30", Slot = "4")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000509")]
		[Cpp2IlInjected.Address(RVA = "0x3BED790", Offset = "0x3BECB90", VA = "0x183BED790", Slot = "5")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000147")]
	public bool FCGKAPFLGFO
	{
		[Cpp2IlInjected.Token(Token = "0x600050A")]
		[Cpp2IlInjected.Address(RVA = "0x19D11F0", Offset = "0x19D05F0", VA = "0x1819D11F0", Slot = "6")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x600050B")]
		[Cpp2IlInjected.Address(RVA = "0x3BED780", Offset = "0x3BECB80", VA = "0x183BED780")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000148")]
	public RigidbodyConstraints IEOPINFGGLF
	{
		[Cpp2IlInjected.Token(Token = "0x600050C")]
		[Cpp2IlInjected.Address(RVA = "0x75F130", Offset = "0x75E530", VA = "0x18075F130", Slot = "7")]
		get
		{
			return default(RigidbodyConstraints);
		}
		[Cpp2IlInjected.Token(Token = "0x600050D")]
		[Cpp2IlInjected.Address(RVA = "0x61DE310", Offset = "0x61DD710", VA = "0x1861DE310", Slot = "8")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600050E")]
	[Cpp2IlInjected.Address(RVA = "0x61DE4A0", Offset = "0x61DD8A0", VA = "0x1861DE4A0")]
	public JHCNBBGPMOD(MGCGGKFMJCL GOCPNHJEOMK, [In] MCODEJBAGCN GHFAAPNAFDE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600050F")]
	[Cpp2IlInjected.Address(RVA = "0x61DE470", Offset = "0x61DD870", VA = "0x1861DE470", Slot = "9")]
	public void INHOGFJCLDO(Rigidbody GEBCPMOBIAB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000510")]
	[Cpp2IlInjected.Address(RVA = "0x61DE440", Offset = "0x61DD840", VA = "0x1861DE440", Slot = "10")]
	public void FLMHAOMIJON(Rigidbody GEBCPMOBIAB)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000058")]
internal sealed class KBFOBOGBNNB : AHDFOHKMEJL
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000AA")]
	private readonly MGCGGKFMJCL GOCPNHJEOMK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000AB")]
	private float MAGMOODPFMF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
	[Cpp2IlInjected.Token(Token = "0x40000AC")]
	private float GNFCIEFCAMO;

	[Cpp2IlInjected.Token(Token = "0x17000149")]
	public float FBLHKIOECLM
	{
		[Cpp2IlInjected.Token(Token = "0x6000512")]
		[Cpp2IlInjected.Address(RVA = "0x7EAC90", Offset = "0x7EA090", VA = "0x1807EAC90", Slot = "4")]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x6000513")]
		[Cpp2IlInjected.Address(RVA = "0x61DFF70", Offset = "0x61DF370", VA = "0x1861DFF70", Slot = "5")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700014A")]
	public float NNGEGGCECLN
	{
		[Cpp2IlInjected.Token(Token = "0x6000514")]
		[Cpp2IlInjected.Address(RVA = "0x8891C0", Offset = "0x8885C0", VA = "0x1808891C0", Slot = "6")]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x6000515")]
		[Cpp2IlInjected.Address(RVA = "0x61DFDB0", Offset = "0x61DF1B0", VA = "0x1861DFDB0", Slot = "7")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000511")]
	[Cpp2IlInjected.Address(RVA = "0x61E0040", Offset = "0x61DF440", VA = "0x1861E0040")]
	public KBFOBOGBNNB(MGCGGKFMJCL GOCPNHJEOMK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000516")]
	[Cpp2IlInjected.Address(RVA = "0x61DFF20", Offset = "0x61DF320", VA = "0x1861DFF20", Slot = "8")]
	public void INHOGFJCLDO(Rigidbody GEBCPMOBIAB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000517")]
	[Cpp2IlInjected.Address(RVA = "0x61DFE80", Offset = "0x61DF280", VA = "0x1861DFE80", Slot = "9")]
	public void FLMHAOMIJON(Rigidbody GEBCPMOBIAB)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000059")]
internal sealed class DPPKGICEBFE : GOILCCLOPLE
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000AE")]
	private readonly GAGFBDFNKIL GOCPNHJEOMK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000AF")]
	private bool GMPHPMMJOAG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x21")]
	[Cpp2IlInjected.Token(Token = "0x40000B0")]
	private bool FIMGBAJAKCB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
	[Cpp2IlInjected.Token(Token = "0x40000B1")]
	private int DJINFINAIND;

	[Cpp2IlInjected.Token(Token = "0x1700014B")]
	private Rigidbody ACNJBLDPNFK
	{
		[Cpp2IlInjected.Token(Token = "0x600051A")]
		[Cpp2IlInjected.Address(RVA = "0x61C6A60", Offset = "0x61C5E60", VA = "0x1861C6A60")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700014C")]
	private bool DAKPPPOBNBC
	{
		[Cpp2IlInjected.Token(Token = "0x600051B")]
		[Cpp2IlInjected.Address(RVA = "0x61CAD30", Offset = "0x61CA130", VA = "0x1861CAD30")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700014D")]
	private MGCGGKFMJCL NCEKKJFNJNC
	{
		[Cpp2IlInjected.Token(Token = "0x600051C")]
		[Cpp2IlInjected.Address(RVA = "0x61CA340", Offset = "0x61C9740", VA = "0x1861CA340")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700014E")]
	private bool EKDOCCFKAGJ
	{
		[Cpp2IlInjected.Token(Token = "0x600051D")]
		[Cpp2IlInjected.Address(RVA = "0x61CA5D0", Offset = "0x61C99D0", VA = "0x1861CA5D0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400004E")]
	public event LNNBFANOADD JKEEEOMBIDH
	{
		[Cpp2IlInjected.Token(Token = "0x6000518")]
		[Cpp2IlInjected.Address(RVA = "0x61CA6D0", Offset = "0x61C9AD0", VA = "0x1861CA6D0", Slot = "4")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000519")]
		[Cpp2IlInjected.Address(RVA = "0x61CA630", Offset = "0x61C9A30", VA = "0x1861CA630", Slot = "5")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600051E")]
	[Cpp2IlInjected.Address(RVA = "0x61CAE00", Offset = "0x61CA200", VA = "0x1861CAE00")]
	public DPPKGICEBFE(MGCGGKFMJCL GOCPNHJEOMK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600051F")]
	[Cpp2IlInjected.Address(RVA = "0x61CAA70", Offset = "0x61C9E70", VA = "0x1861CAA70", Slot = "6")]
	public void JHKGOCECMOM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000520")]
	[Cpp2IlInjected.Address(RVA = "0x61CADF0", Offset = "0x61CA1F0", VA = "0x1861CADF0", Slot = "8")]
	public void OHDGAPGGGEO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000521")]
	[Cpp2IlInjected.Address(RVA = "0x61CA920", Offset = "0x61C9D20", VA = "0x1861CA920", Slot = "7")]
	public bool GBMNOJMBOIA()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000522")]
	[Cpp2IlInjected.Address(RVA = "0x61CA530", Offset = "0x61C9930", VA = "0x1861CA530", Slot = "9")]
	public void DKHDPIPGLAN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000523")]
	[Cpp2IlInjected.Address(RVA = "0x61CAD50", Offset = "0x61CA150", VA = "0x1861CAD50", Slot = "11")]
	public void MALCMJHIFLA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000524")]
	[Cpp2IlInjected.Address(RVA = "0x61CAB00", Offset = "0x61C9F00", VA = "0x1861CAB00", Slot = "12")]
	public void JPEOPDBIOFK(bool JOAAGNJLPGK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000525")]
	[Cpp2IlInjected.Address(RVA = "0x61CA770", Offset = "0x61C9B70", VA = "0x1861CA770", Slot = "10")]
	public void FDFEHOGPDLO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000526")]
	[Cpp2IlInjected.Address(RVA = "0x61CAB50", Offset = "0x61C9F50", VA = "0x1861CAB50")]
	private bool KCHOGAEINHL()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000527")]
	[Cpp2IlInjected.Address(RVA = "0x61CA3A0", Offset = "0x61C97A0", VA = "0x1861CA3A0")]
	private void CLBPNMKIMHN()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200005A")]
internal sealed class EFAOHAPPJCF : NHEPMPNKBHG
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000B2")]
	private readonly GAGFBDFNKIL GOCPNHJEOMK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000B3")]
	private readonly HAMCJNIMIPK KPINICPGIJF;

	[Cpp2IlInjected.Token(Token = "0x1700014F")]
	public Rigidbody ACNJBLDPNFK
	{
		[Cpp2IlInjected.Token(Token = "0x6000528")]
		[Cpp2IlInjected.Address(RVA = "0x764960", Offset = "0x763D60", VA = "0x180764960", Slot = "4")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000529")]
		[Cpp2IlInjected.Address(RVA = "0x760A90", Offset = "0x75FE90", VA = "0x180760A90")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000150")]
	private bool EKDOCCFKAGJ
	{
		[Cpp2IlInjected.Token(Token = "0x600052A")]
		[Cpp2IlInjected.Address(RVA = "0x61C98B0", Offset = "0x61C8CB0", VA = "0x1861C98B0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000151")]
	public bool LOFHGPEPHPP
	{
		[Cpp2IlInjected.Token(Token = "0x600052D")]
		[Cpp2IlInjected.Address(RVA = "0xC31A80", Offset = "0xC30E80", VA = "0x180C31A80", Slot = "6")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600052B")]
	[Cpp2IlInjected.Address(RVA = "0x61CBE20", Offset = "0x61CB220", VA = "0x1861CBE20")]
	public EFAOHAPPJCF(MGCGGKFMJCL GOCPNHJEOMK, [In] MCODEJBAGCN GHFAAPNAFDE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600052C")]
	[Cpp2IlInjected.Address(RVA = "0x61CBBA0", Offset = "0x61CAFA0", VA = "0x1861CBBA0", Slot = "5")]
	public void JHKGOCECMOM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600052E")]
	[Cpp2IlInjected.Address(RVA = "0x61CB9F0", Offset = "0x61CADF0", VA = "0x1861CB9F0", Slot = "7")]
	public void CEDEMEPPALB(object KJAGMGIFCEM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600052F")]
	[Cpp2IlInjected.Address(RVA = "0x61CBDF0", Offset = "0x61CB1F0", VA = "0x1861CBDF0", Slot = "8")]
	public void MLKIEMGEEPP(object KJAGMGIFCEM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000530")]
	[Cpp2IlInjected.Address(RVA = "0x61CB4D0", Offset = "0x61CA8D0", VA = "0x1861CB4D0", Slot = "9")]
	public void BNBIPPHMKFF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000531")]
	[Cpp2IlInjected.Address(RVA = "0x61CB800", Offset = "0x61CAC00", VA = "0x1861CB800", Slot = "11")]
	public void CACFKJFACGP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000532")]
	[Cpp2IlInjected.Address(RVA = "0x61CBA20", Offset = "0x61CAE20", VA = "0x1861CBA20", Slot = "12")]
	public void HJMDJJEJJKD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000533")]
	[Cpp2IlInjected.Address(RVA = "0x61CAE90", Offset = "0x61CA290", VA = "0x1861CAE90", Slot = "10")]
	public void ACICNKEKDGI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000534")]
	[Cpp2IlInjected.Address(RVA = "0x61CB320", Offset = "0x61CA720", VA = "0x1861CB320")]
	private void AMDAPLHBICD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000535")]
	[Cpp2IlInjected.Address(RVA = "0x61CBC40", Offset = "0x61CB040", VA = "0x1861CBC40")]
	private void LHONIFLCAMP()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200005B")]
internal sealed class FAHLAKICIMO : DGJKOCOHMGO, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000B5")]
	private readonly GAGFBDFNKIL GOCPNHJEOMK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000B6")]
	private readonly HAMCJNIMIPK KBFAOEEDJLH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000B7")]
	private float NFPAKGGOIFM;

	[Cpp2IlInjected.Token(Token = "0x17000152")]
	public JOOBEENEBAA KIPEILJOHEE
	{
		[Cpp2IlInjected.Token(Token = "0x6000536")]
		[Cpp2IlInjected.Address(RVA = "0x75C780", Offset = "0x75BB80", VA = "0x18075C780", Slot = "4")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000537")]
		[Cpp2IlInjected.Address(RVA = "0x764970", Offset = "0x763D70", VA = "0x180764970", Slot = "5")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000153")]
	public GKFPHOCIOLD BCAAPMKBHAM
	{
		[Cpp2IlInjected.Token(Token = "0x6000538")]
		[Cpp2IlInjected.Address(RVA = "0x75C7D0", Offset = "0x75BBD0", VA = "0x18075C7D0", Slot = "6")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000539")]
		[Cpp2IlInjected.Address(RVA = "0x7681F0", Offset = "0x7675F0", VA = "0x1807681F0", Slot = "7")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000154")]
	public Vector3 DPFKMNPADOM
	{
		[Cpp2IlInjected.Token(Token = "0x600053A")]
		[Cpp2IlInjected.Address(RVA = "0x61E9D60", Offset = "0x61E9160", VA = "0x1861E9D60", Slot = "8")]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x600053B")]
		[Cpp2IlInjected.Address(RVA = "0x61EA550", Offset = "0x61E9950", VA = "0x1861EA550", Slot = "9")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000155")]
	public Vector3 GFFGILJCJLF
	{
		[Cpp2IlInjected.Token(Token = "0x600053C")]
		[Cpp2IlInjected.Address(RVA = "0x61E9BB0", Offset = "0x61E8FB0", VA = "0x1861E9BB0", Slot = "10")]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x600053D")]
		[Cpp2IlInjected.Address(RVA = "0x61EA470", Offset = "0x61E9870", VA = "0x1861EA470", Slot = "11")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000156")]
	public Vector3 IKKGDGHOOEN
	{
		[Cpp2IlInjected.Token(Token = "0x600053E")]
		[Cpp2IlInjected.Address(RVA = "0x61EBC70", Offset = "0x61EB070", VA = "0x1861EBC70", Slot = "12")]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x600053F")]
		[Cpp2IlInjected.Address(RVA = "0x61EC520", Offset = "0x61EB920", VA = "0x1861EC520", Slot = "13")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000157")]
	public Vector3 ACHPDMPDEGK
	{
		[Cpp2IlInjected.Token(Token = "0x6000540")]
		[Cpp2IlInjected.Address(RVA = "0x61EAAC0", Offset = "0x61E9EC0", VA = "0x1861EAAC0", Slot = "14")]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x6000541")]
		[Cpp2IlInjected.Address(RVA = "0x61EB180", Offset = "0x61EA580", VA = "0x1861EB180", Slot = "15")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000158")]
	public float IMFCIBCJLIP
	{
		[Cpp2IlInjected.Token(Token = "0x6000542")]
		[Cpp2IlInjected.Address(RVA = "0x7B1850", Offset = "0x7B0C50", VA = "0x1807B1850", Slot = "16")]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x6000543")]
		[Cpp2IlInjected.Address(RVA = "0x61E9E80", Offset = "0x61E9280", VA = "0x1861E9E80", Slot = "17")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000159")]
	public bool NCFBIAMPAHJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000544")]
		[Cpp2IlInjected.Address(RVA = "0x15B4B70", Offset = "0x15B3F70", VA = "0x1815B4B70", Slot = "18")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700015A")]
	private LDADHEPIIJJ HCPIIEIKLAJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000558")]
		[Cpp2IlInjected.Address(RVA = "0x1C56270", Offset = "0x1C55670", VA = "0x181C56270")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700015B")]
	private bool DAKPPPOBNBC
	{
		[Cpp2IlInjected.Token(Token = "0x6000559")]
		[Cpp2IlInjected.Address(RVA = "0x61C06F0", Offset = "0x61BFAF0", VA = "0x1861C06F0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000545")]
	[Cpp2IlInjected.Address(RVA = "0x61ECBA0", Offset = "0x61EBFA0", VA = "0x1861ECBA0")]
	public FAHLAKICIMO(MGCGGKFMJCL GOCPNHJEOMK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000546")]
	[Cpp2IlInjected.Address(RVA = "0x61EA4A0", Offset = "0x61E98A0", VA = "0x1861EA4A0", Slot = "19")]
	public void JHKGOCECMOM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000547")]
	[Cpp2IlInjected.Address(RVA = "0x61EA9F0", Offset = "0x61E9DF0", VA = "0x1861EA9F0", Slot = "36")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000548")]
	[Cpp2IlInjected.Address(RVA = "0x61EBA30", Offset = "0x61EAE30", VA = "0x1861EBA30", Slot = "28")]
	public void INHOGFJCLDO(Rigidbody GEBCPMOBIAB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000549")]
	[Cpp2IlInjected.Address(RVA = "0xA3C730", Offset = "0xA3BB30", VA = "0x180A3C730", Slot = "20")]
	public void NGDGOPEIOMC(object KJAGMGIFCEM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600054A")]
	[Cpp2IlInjected.Address(RVA = "0xA3BEA0", Offset = "0xA3B2A0", VA = "0x180A3BEA0", Slot = "30")]
	public void AAADHENEFCN(object KJAGMGIFCEM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600054B")]
	[Cpp2IlInjected.Address(RVA = "0x61EABB0", Offset = "0x61E9FB0", VA = "0x1861EABB0", Slot = "35")]
	public Vector3 FLADNKLALKJ(Vector3 NDMBMJJIOFA)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x600054C")]
	[Cpp2IlInjected.Address(RVA = "0x61EA610", Offset = "0x61E9A10", VA = "0x1861EA610", Slot = "34")]
	public Vector3 DMBNKHGFCEB(Vector3 EKHMFCCFGPL)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x600054D")]
	[Cpp2IlInjected.Address(RVA = "0x61EA4A0", Offset = "0x61E98A0", VA = "0x1861EA4A0", Slot = "27")]
	public void CPOFEOBDKHH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600054E")]
	[Cpp2IlInjected.Address(RVA = "0x61E9CA0", Offset = "0x61E90A0", VA = "0x1861E9CA0", Slot = "25")]
	public void ADFAAJPBAGA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600054F")]
	[Cpp2IlInjected.Address(RVA = "0x61EC410", Offset = "0x61EB810", VA = "0x1861EC410", Slot = "24")]
	public void PEPDJLKNHGG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000550")]
	[Cpp2IlInjected.Address(RVA = "0x61EA2D0", Offset = "0x61E96D0", VA = "0x1861EA2D0", Slot = "33")]
	public void BIABKHBMFDC(Vector3 LHINOEFCJLG, Vector3 AIMMMFLBCHI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000551")]
	[Cpp2IlInjected.Address(RVA = "0x61E9D00", Offset = "0x61E9100", VA = "0x1861E9D00", Slot = "32")]
	public void ALEIMOONCKG(Vector3 HGBENCPPIOE, Vector3 EFIALDMFCNH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000552")]
	[Cpp2IlInjected.Address(RVA = "0x61EBB00", Offset = "0x61EAF00", VA = "0x1861EBB00", Slot = "31")]
	public void KDOMADLDDAH(Vector3 AFNABGBDBAH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000553")]
	[Cpp2IlInjected.Address(RVA = "0x61EB400", Offset = "0x61EA800", VA = "0x1861EB400", Slot = "22")]
	public void IKEAFEJHOCH(KOJCHCLAHNC KDAMGPKMFLN, Vector3 NEBBPBIFLLJ, float KKPMGKAMFEJ, float EFDONJDPNKE = 8f, float DCDHDFHOKAE = 1f)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000554")]
	[Cpp2IlInjected.Address(RVA = "0x61EA760", Offset = "0x61E9B60", VA = "0x1861EA760", Slot = "21")]
	public void DMLNPBGDGBL(NILPLAGMMGI DAFNMKFCJFG, Vector3 LHELLKPPHKL, float FPGCJPGJIBA = float.PositiveInfinity)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000555")]
	[Cpp2IlInjected.Address(RVA = "0x61E9F30", Offset = "0x61E9330", VA = "0x1861E9F30", Slot = "23")]
	[Obsolete("Deprecated. Still exists to support deprecated CV2 chips. Use ApplyAngularVelocityChange.")]
	public void BFAKGADOJGG(NILPLAGMMGI DAFNMKFCJFG, Vector3 KBKHJHIFKGI, float CGNIOCJOEKL = 7f, float JKANFBIIJHK = 1f)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000556")]
	[Cpp2IlInjected.Address(RVA = "0x61EBE70", Offset = "0x61EB270", VA = "0x1861EBE70", Slot = "29")]
	public Vector3 MLOBKENIFDB(Vector3 GKMPFMKFGID)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000557")]
	[Cpp2IlInjected.Address(RVA = "0x61ECA70", Offset = "0x61EBE70", VA = "0x1861ECA70", Slot = "26")]
	public void PJFHPKDNKCK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600055A")]
	[Cpp2IlInjected.Address(RVA = "0x61E9E80", Offset = "0x61E9280", VA = "0x1861E9E80")]
	private void BCDCHHFFOGO(float EOHMJBFGDPD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600055B")]
	[Cpp2IlInjected.Address(RVA = "0x61EB1B0", Offset = "0x61EA5B0", VA = "0x1861EB1B0")]
	private void HACEKABHENP(Vector3 LHELLKPPHKL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600055C")]
	[Cpp2IlInjected.Address(RVA = "0x61EB320", Offset = "0x61EA720", VA = "0x1861EB320")]
	private Vector3 IJPEEKNJHIE()
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x600055D")]
	[Cpp2IlInjected.Address(RVA = "0x61EAD20", Offset = "0x61EA120", VA = "0x1861EAD20")]
	private void GCJDHLECOBJ(Vector3 EKHMFCCFGPL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600055E")]
	[Cpp2IlInjected.Address(RVA = "0x61EBD90", Offset = "0x61EB190", VA = "0x1861EBD90")]
	private Vector3 MBOBHGCLAGL()
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x600055F")]
	[Cpp2IlInjected.Address(RVA = "0x61EBFD0", Offset = "0x61EB3D0", VA = "0x1861EBFD0")]
	private void OJEAPEOCDMI(Vector3 EOHMJBFGDPD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000560")]
	[Cpp2IlInjected.Address(RVA = "0x61EC5E0", Offset = "0x61EB9E0", VA = "0x1861EC5E0")]
	private void PJBIJEFNIAM(Vector3 EKHMFCCFGPL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000561")]
	[Cpp2IlInjected.Address(RVA = "0x61EC470", Offset = "0x61EB870", VA = "0x1861EC470")]
	private void PGEACLLELML()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200005C")]
public class IJMNHOKAPKG : EKNPMJGCPKA
{
	[Cpp2IlInjected.Token(Token = "0x6000562")]
	[Cpp2IlInjected.Address(RVA = "0x61ECF90", Offset = "0x61EC390", VA = "0x1861ECF90", Slot = "4")]
	public DODNAMHPMBE HDJDKJBJIDM(MGCGGKFMJCL MPPIIABEOMK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000563")]
	[Cpp2IlInjected.Address(RVA = "0x61ECD80", Offset = "0x61EC180", VA = "0x1861ECD80", Slot = "5")]
	public DGJKOCOHMGO EFOOLAELMEL(MGCGGKFMJCL MPPIIABEOMK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000564")]
	[Cpp2IlInjected.Address(RVA = "0x61ED0C0", Offset = "0x61EC4C0", VA = "0x1861ED0C0", Slot = "6")]
	public ABHLGLKCJNI JKELKKKKKCF(MGCGGKFMJCL MPPIIABEOMK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000565")]
	[Cpp2IlInjected.Address(RVA = "0x61ED060", Offset = "0x61EC460", VA = "0x1861ED060", Slot = "7")]
	public AHDFOHKMEJL JDDMHOBCBMG(MGCGGKFMJCL MPPIIABEOMK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000566")]
	[Cpp2IlInjected.Address(RVA = "0x61ECF30", Offset = "0x61EC330", VA = "0x1861ECF30", Slot = "8")]
	public GOILCCLOPLE HDFLEEFDEGH(MGCGGKFMJCL MPPIIABEOMK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000567")]
	[Cpp2IlInjected.Address(RVA = "0x61ED190", Offset = "0x61EC590", VA = "0x1861ED190", Slot = "9")]
	public KKFFFGDLIIM LHCNNINPLHC(MGCGGKFMJCL MPPIIABEOMK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000568")]
	[Cpp2IlInjected.Address(RVA = "0x61ECE60", Offset = "0x61EC260", VA = "0x1861ECE60", Slot = "10")]
	public JNCIBBLAFHG EOPAPGLAECF(MGCGGKFMJCL MPPIIABEOMK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000569")]
	[Cpp2IlInjected.Address(RVA = "0x61ED300", Offset = "0x61EC700", VA = "0x1861ED300", Slot = "11")]
	public LDADHEPIIJJ PPOIFOPBCIK(MGCGGKFMJCL MPPIIABEOMK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600056A")]
	[Cpp2IlInjected.Address(RVA = "0x61ECD20", Offset = "0x61EC120", VA = "0x1861ECD20", Slot = "12")]
	public EGPHOJFLGHI EEDCLPCPAPD(MGCGGKFMJCL MPPIIABEOMK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600056B")]
	[Cpp2IlInjected.Address(RVA = "0x61ED2A0", Offset = "0x61EC6A0", VA = "0x1861ED2A0", Slot = "13")]
	public HOGMIDIDFNH PHLDOMEJJDH(MGCGGKFMJCL MPPIIABEOMK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600056C")]
	[Cpp2IlInjected.Address(RVA = "0x61ECC40", Offset = "0x61EC040", VA = "0x1861ECC40")]
	public NHEPMPNKBHG ALKFKFHHFDI(MGCGGKFMJCL MPPIIABEOMK, [In] MCODEJBAGCN GHFAAPNAFDE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600056D")]
	[Cpp2IlInjected.Address(RVA = "0x61ECCB0", Offset = "0x61EC0B0", VA = "0x1861ECCB0")]
	public KHGIDGJJCDM ONJKEKBDIOL(MGCGGKFMJCL MPPIIABEOMK, [In] MCODEJBAGCN GHFAAPNAFDE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600056E")]
	[Cpp2IlInjected.Address(RVA = "0x61ED120", Offset = "0x61EC520", VA = "0x1861ED120")]
	public MFDACKEMCFN PLBIIHNHKIC(MGCGGKFMJCL MPPIIABEOMK, [In] MCODEJBAGCN GHFAAPNAFDE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600056F")]
	[Cpp2IlInjected.Address(RVA = "0x61ECFF0", Offset = "0x61EC3F0", VA = "0x1861ECFF0")]
	public JBNKCGNKKDA OLKIFCLJICA(MGCGGKFMJCL MPPIIABEOMK, [In] MCODEJBAGCN GHFAAPNAFDE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000570")]
	[Cpp2IlInjected.Address(RVA = "0x61ECEC0", Offset = "0x61EC2C0", VA = "0x1861ECEC0")]
	public GKGLDPLOLIH NODCFIFDCCN(MGCGGKFMJCL MPPIIABEOMK, [In] MCODEJBAGCN GHFAAPNAFDE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000571")]
	[Cpp2IlInjected.Address(RVA = "0x61ED1F0", Offset = "0x61EC5F0", VA = "0x1861ED1F0", Slot = "19")]
	public MGCGGKFMJCL OJHFCPKEHNA(RigidbodyEx GOCPNHJEOMK, MCODEJBAGCN GHFAAPNAFDE, HPGKIKLHCAJ GCLFDBLLOOM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000572")]
	[Cpp2IlInjected.Address(RVA = "0x76C4B0", Offset = "0x76B8B0", VA = "0x18076C4B0")]
	public IJMNHOKAPKG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000573")]
	[Cpp2IlInjected.Address(RVA = "0x61ECC40", Offset = "0x61EC040", VA = "0x1861ECC40", Slot = "14")]
	private NHEPMPNKBHG OFHCFANEJKK(MGCGGKFMJCL MPPIIABEOMK, [In] MCODEJBAGCN GHFAAPNAFDE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000574")]
	[Cpp2IlInjected.Address(RVA = "0x61ECCB0", Offset = "0x61EC0B0", VA = "0x1861ECCB0", Slot = "15")]
	private KHGIDGJJCDM BNKJDPBDJGK(MGCGGKFMJCL MPPIIABEOMK, [In] MCODEJBAGCN GHFAAPNAFDE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000575")]
	[Cpp2IlInjected.Address(RVA = "0x61ED120", Offset = "0x61EC520", VA = "0x1861ED120", Slot = "16")]
	private MFDACKEMCFN JLPNPCMPKIP(MGCGGKFMJCL MPPIIABEOMK, [In] MCODEJBAGCN GHFAAPNAFDE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000576")]
	[Cpp2IlInjected.Address(RVA = "0x61ECFF0", Offset = "0x61EC3F0", VA = "0x1861ECFF0", Slot = "17")]
	private JBNKCGNKKDA JAPAKJFFOEM(MGCGGKFMJCL MPPIIABEOMK, [In] MCODEJBAGCN GHFAAPNAFDE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000577")]
	[Cpp2IlInjected.Address(RVA = "0x61ECEC0", Offset = "0x61EC2C0", VA = "0x1861ECEC0", Slot = "18")]
	private GKGLDPLOLIH FDNJHEEAFFK(MGCGGKFMJCL MPPIIABEOMK, [In] MCODEJBAGCN GHFAAPNAFDE)
	{
		return null;
	}
}
namespace RRAssemblyIndex.RecRoom.Rbex.Runtime
{
	[Cpp2IlInjected.Token(Token = "0x200005D")]
	[global::RecRoom.CodeGen.Attributes.Preserve]
	internal class _RRAssemblyIndex : BAFBLMKEIGC
	{
		[Cpp2IlInjected.Token(Token = "0x6000578")]
		[Cpp2IlInjected.Address(RVA = "0x787870", Offset = "0x786C70", VA = "0x180787870")]
		[global::RecRoom.CodeGen.Attributes.Preserve]
		public _RRAssemblyIndex()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000579")]
		[Cpp2IlInjected.Address(RVA = "0x61ED360", Offset = "0x61EC760", VA = "0x1861ED360", Slot = "6")]
		public sealed override void CAGGLFMEPDA(PGKEOEMFGED IOKENELNCLP)
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
