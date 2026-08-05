using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Cpp2IlInjected;
using Mono.Math;
using Photon.Pun;
using RecRoom;
using RecRoom.Utils.OverridableFields;
using UnityEngine;
using UnityEngine.Scripting;
using UnityEngine.Serialization;

[assembly: AssemblyVersion("0.0.0.0")]
[Cpp2IlInjected.Token(Token = "0x2000002")]
internal class LJCCPBNJAHG
{
	[Cpp2IlInjected.Token(Token = "0x4000001")]
	public const string JGFHJMOMLGL = "RBEX_DEFAULT";

	[Cpp2IlInjected.Token(Token = "0x4000002")]
	public const float ECPJJHIPOHI = 0.001f;

	[Cpp2IlInjected.Token(Token = "0x4000003")]
	public const float IECOBGKLLDL = 0f;

	[Cpp2IlInjected.Token(Token = "0x4000004")]
	public const float OKAHGMBILAB = 0.05f;

	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(RVA = "0x703570", Offset = "0x702770", VA = "0x180703570")]
	public LJCCPBNJAHG()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
public delegate void FGJCBPBEFOP(RigidbodyEx BJHLKOMIJEL);
[Cpp2IlInjected.Token(Token = "0x2000004")]
public delegate void OHFGCHALJBC(RigidbodyEx BJHLKOMIJEL, bool LDEEGDEKBLJ = false);
[Cpp2IlInjected.Token(Token = "0x2000005")]
public enum LJPGLADCBCM
{
	[Cpp2IlInjected.Token(Token = "0x4000006")]
	Additive,
	[Cpp2IlInjected.Token(Token = "0x4000007")]
	Override,
	[Cpp2IlInjected.Token(Token = "0x4000008")]
	Reflective
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public enum KHNEINFFHJE
{
	[Cpp2IlInjected.Token(Token = "0x400000A")]
	OnlyForReducedPhysicsRateAndNotParenting,
	[Cpp2IlInjected.Token(Token = "0x400000B")]
	Never,
	[Cpp2IlInjected.Token(Token = "0x400000C")]
	OnEvenWhenParenting
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
public enum HKGKLOMPNFJ
{
	[Cpp2IlInjected.Token(Token = "0x400000E")]
	Additive,
	[Cpp2IlInjected.Token(Token = "0x400000F")]
	Override,
	[Cpp2IlInjected.Token(Token = "0x4000010")]
	Reflective
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
public class EEHPCNOMOPF : PEMDLLFJFDM
{
	[Cpp2IlInjected.Token(Token = "0x17000001")]
	public int HDDGHKJOJDI
	{
		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x6F6400", Offset = "0x6F5600", VA = "0x1806F6400", Slot = "4")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	public int OBFAIFKBINK
	{
		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x7E4830", Offset = "0x7E3A30", VA = "0x1807E4830", Slot = "5")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0x6F8490", Offset = "0x6F7690", VA = "0x1806F8490", Slot = "6")]
	public AMBBOEBJPNH OANKBGNEFLM(float DAMOGGANOJL)
	{
		return default(AMBBOEBJPNH);
	}

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0x6F84D0", Offset = "0x6F76D0", VA = "0x1806F84D0", Slot = "7")]
	public void CPCILMEHKPA(DFBGLPCFOHL ICHBECDKHOJ, float NNLEGJGIGHA, HOHEMHOGNPJ OOPMGGPMMEJ = HOHEMHOGNPJ.Off)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(RVA = "0x6F84D0", Offset = "0x6F76D0", VA = "0x1806F84D0", Slot = "8")]
	public void CPCILMEHKPA(DFBGLPCFOHL ICHBECDKHOJ, Transform LKHNIDJAMCA, float NNLEGJGIGHA, HOHEMHOGNPJ OOPMGGPMMEJ = HOHEMHOGNPJ.Off)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(RVA = "0x6F84D0", Offset = "0x6F76D0", VA = "0x1806F84D0", Slot = "9")]
	public void PPNODFFOFGD(DFBGLPCFOHL ICHBECDKHOJ, [Optional] float? NNLEGJGIGHA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(RVA = "0x6F84D0", Offset = "0x6F76D0", VA = "0x1806F84D0", Slot = "10")]
	public void MILDLLFOGOM(DFBGLPCFOHL GOINOPMKPDD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(RVA = "0x6F8490", Offset = "0x6F7690", VA = "0x1806F8490", Slot = "11")]
	public AMBBOEBJPNH NOBCIHFNGCH(DFBGLPCFOHL ICHBECDKHOJ)
	{
		return default(AMBBOEBJPNH);
	}

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(RVA = "0x7004F0", Offset = "0x6FF6F0", VA = "0x1807004F0", Slot = "12")]
	public bool OMBHCPANOCL(DFBGLPCFOHL ICHBECDKHOJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(RVA = "0x6F84D0", Offset = "0x6F76D0", VA = "0x1806F84D0", Slot = "13")]
	public void IPFKHECOFDN(DFBGLPCFOHL ICHBECDKHOJ, HOHEMHOGNPJ CPOGMHGKBPB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(RVA = "0x703570", Offset = "0x702770", VA = "0x180703570")]
	public EEHPCNOMOPF()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
[PNCLNBNALEO(typeof(KKMPBNDGPDK), new string[] { "Ignore", "Mock" })]
public class LAENAIPCELP : KKMPBNDGPDK
{
	[Cpp2IlInjected.Token(Token = "0x17000003")]
	public bool NLDDBJGMJOA
	{
		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0x707B80", Offset = "0x706D80", VA = "0x180707B80", Slot = "4")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(RVA = "0x6F84D0", Offset = "0x6F76D0", VA = "0x1806F84D0", Slot = "5")]
	public void FOFGCCCFKHB(string NLJOHEKGNDH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(RVA = "0x6F84D0", Offset = "0x6F76D0", VA = "0x1806F84D0", Slot = "6")]
	public void EOKBFFEJHHG(RigidbodyEx EHHPLBPDKBE, Action IBKGKDECOEG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(RVA = "0x6F8490", Offset = "0x6F7690", VA = "0x1806F8490", Slot = "7")]
	public PEMDLLFJFDM PELEBHNNNPD(int NMMLCFOALFP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(RVA = "0x6F84D0", Offset = "0x6F76D0", VA = "0x1806F84D0", Slot = "8")]
	public void PKAAFHPDFGD(Vector3 DBKAIKHNCKG, float AAPKAJOCACA, Color HMCAFGCGFJF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(RVA = "0x703570", Offset = "0x702770", VA = "0x180703570")]
	public LAENAIPCELP()
	{
	}
}
namespace RecRoom
{
	[Cpp2IlInjected.Token(Token = "0x200000A")]
	[DisallowMultipleComponent]
	[CGDKNMKPKIP(OOBCCNCEGNI.Physics)]
	public sealed class RigidbodyEx : MonoBehaviour
	{
		[Cpp2IlInjected.Token(Token = "0x4000014")]
		private static readonly HDHIMOFHFJL AHADDDAMGKE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000015")]
		private bool HOCFFNMCCJJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000016")]
		private OINPHBHEBFM HIJBENKAEJP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000017")]
		[SerializeField]
		[MKPBLGADCLO(MFGBMPAPHGB.Self, false, false, false)]
		private Rigidbody unityRigidbody;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000018")]
		[SerializeField]
		[MKPBLGADCLO(MFGBMPAPHGB.SelfAndParent, true, false, false)]
		private PhotonView photonView;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000019")]
		[SerializeField]
		private OverridableVector3 precomputedCenterOfMass;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400001A")]
		[SerializeField]
		private OverridableVector3 customCenterOfMass;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x400001B")]
		[SerializeField]
		[FormerlySerializedAs("forceNoInterpolation")]
		private KHNEINFFHJE physicsInterpolation;

		[Cpp2IlInjected.FieldOffset(Offset = "0x5C")]
		[Cpp2IlInjected.Token(Token = "0x400001C")]
		[SerializeField]
		[Tooltip("If checked, this object's Unity Rigidbody will not be stripped when parenting the object to another RigidbodyEx. Only check this on objects that have a Unity Rigidbody by default and who need access to Unity physics events like OnTriggerEnter, OnCollisionEnter, etc. This is sometimes set via script instead of this flag.")]
		private bool keepUnityRigidbodyWhileParented;

		[Cpp2IlInjected.FieldOffset(Offset = "0x5D")]
		[Cpp2IlInjected.Token(Token = "0x400001D")]
		[SerializeField]
		[Tooltip("If the RigidbodyEx has a parent that is being destroyed, this flag allows this RigidbodyEx to keep the parent set. The default behavior is thatthe parent property is set to null, resetting/clearing the existing parent when it is being destroyed.")]
		private bool keepParentOnParentDestroy;

		[Cpp2IlInjected.FieldOffset(Offset = "0x5E")]
		[Cpp2IlInjected.Token(Token = "0x400001E")]
		[HideInInspector]
		[SerializeField]
		private bool hasUnityRigidbodyByDefault;

		[Cpp2IlInjected.Token(Token = "0x17000004")]
		internal OINPHBHEBFM DLGMOOCFLIK
		{
			[Cpp2IlInjected.Token(Token = "0x600001B")]
			[Cpp2IlInjected.Address(RVA = "0x675BAB0", Offset = "0x675ACB0", VA = "0x18675BAB0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000005")]
		public IReadOnlyList<RigidbodyEx> NCLNEDAIDDA
		{
			[Cpp2IlInjected.Token(Token = "0x6000031")]
			[Cpp2IlInjected.Address(RVA = "0x817390", Offset = "0x816590", VA = "0x180817390")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000032")]
			[Cpp2IlInjected.Address(RVA = "0x815C60", Offset = "0x814E60", VA = "0x180815C60")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000006")]
		public RigidbodyEx IOIJBFJFENJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000033")]
			[Cpp2IlInjected.Address(RVA = "0x675D9C0", Offset = "0x675CBC0", VA = "0x18675D9C0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000007")]
		public RigidbodyEx CFHDLGEGDFD
		{
			[Cpp2IlInjected.Token(Token = "0x6000034")]
			[Cpp2IlInjected.Address(RVA = "0x675D960", Offset = "0x675CB60", VA = "0x18675D960")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000008")]
		public RigidbodyEx HHFDFFDPCGO
		{
			[Cpp2IlInjected.Token(Token = "0x6000035")]
			[Cpp2IlInjected.Address(RVA = "0x675E520", Offset = "0x675D720", VA = "0x18675E520")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000036")]
			[Cpp2IlInjected.Address(RVA = "0x675FC70", Offset = "0x675EE70", VA = "0x18675FC70")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000009")]
		public Transform ABGJKHNEALI
		{
			[Cpp2IlInjected.Token(Token = "0x6000037")]
			[Cpp2IlInjected.Address(RVA = "0xDC5ED0", Offset = "0xDC50D0", VA = "0x180DC5ED0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000A")]
		public Transform LCAKADOIIEB
		{
			[Cpp2IlInjected.Token(Token = "0x6000038")]
			[Cpp2IlInjected.Address(RVA = "0xDC5ED0", Offset = "0xDC50D0", VA = "0x180DC5ED0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000B")]
		public HOHEMHOGNPJ AJFBHNJDDCE
		{
			[Cpp2IlInjected.Token(Token = "0x6000039")]
			[Cpp2IlInjected.Address(RVA = "0x675D650", Offset = "0x675C850", VA = "0x18675D650")]
			get
			{
				return default(HOHEMHOGNPJ);
			}
			[Cpp2IlInjected.Token(Token = "0x600003A")]
			[Cpp2IlInjected.Address(RVA = "0x675F210", Offset = "0x675E410", VA = "0x18675F210")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000C")]
		public bool NKELDOMJEGL
		{
			[Cpp2IlInjected.Token(Token = "0x600003B")]
			[Cpp2IlInjected.Address(RVA = "0x675DBD0", Offset = "0x675CDD0", VA = "0x18675DBD0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000D")]
		public bool DMMCOKOAOJI
		{
			[Cpp2IlInjected.Token(Token = "0x600003C")]
			[Cpp2IlInjected.Address(RVA = "0x675D7E0", Offset = "0x675C9E0", VA = "0x18675D7E0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000E")]
		public OEEBBDJIDDP PJJKMCINJBG
		{
			[Cpp2IlInjected.Token(Token = "0x600003D")]
			[Cpp2IlInjected.Address(RVA = "0x675DB70", Offset = "0x675CD70", VA = "0x18675DB70")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600003E")]
			[Cpp2IlInjected.Address(RVA = "0x675F420", Offset = "0x675E620", VA = "0x18675F420")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000F")]
		public JIKDBJBLNKK GLMECOENJFF
		{
			[Cpp2IlInjected.Token(Token = "0x600003F")]
			[Cpp2IlInjected.Address(RVA = "0x675DB10", Offset = "0x675CD10", VA = "0x18675DB10")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000040")]
			[Cpp2IlInjected.Address(RVA = "0x675F3B0", Offset = "0x675E5B0", VA = "0x18675F3B0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000010")]
		public bool PHFFHNKCAKG
		{
			[Cpp2IlInjected.Token(Token = "0x6000041")]
			[Cpp2IlInjected.Address(RVA = "0x675D9F0", Offset = "0x675CBF0", VA = "0x18675D9F0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000011")]
		public Rigidbody JMCCCFFEIIG
		{
			[Cpp2IlInjected.Token(Token = "0x6000042")]
			[Cpp2IlInjected.Address(RVA = "0x675DA50", Offset = "0x675CC50", VA = "0x18675DA50")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000012")]
		public bool ADJEMOAFAPK
		{
			[Cpp2IlInjected.Token(Token = "0x6000043")]
			[Cpp2IlInjected.Address(RVA = "0x675D8A0", Offset = "0x675CAA0", VA = "0x18675D8A0")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000044")]
			[Cpp2IlInjected.Address(RVA = "0x675F2D0", Offset = "0x675E4D0", VA = "0x18675F2D0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000013")]
		public bool GLKPKJJLKNP
		{
			[Cpp2IlInjected.Token(Token = "0x6000045")]
			[Cpp2IlInjected.Address(RVA = "0x369B2A0", Offset = "0x369A4A0", VA = "0x18369B2A0")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000046")]
			[Cpp2IlInjected.Address(RVA = "0x369B310", Offset = "0x369A510", VA = "0x18369B310")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000014")]
		public float BODPGOIGEFH
		{
			[Cpp2IlInjected.Token(Token = "0x6000047")]
			[Cpp2IlInjected.Address(RVA = "0x675E4C0", Offset = "0x675D6C0", VA = "0x18675E4C0")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000015")]
		public float OBEADAGDFAM
		{
			[Cpp2IlInjected.Token(Token = "0x6000048")]
			[Cpp2IlInjected.Address(RVA = "0x675E460", Offset = "0x675D660", VA = "0x18675E460")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x6000049")]
			[Cpp2IlInjected.Address(RVA = "0x675FC00", Offset = "0x675EE00", VA = "0x18675FC00")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000016")]
		public float LEFNKNIEOMM
		{
			[Cpp2IlInjected.Token(Token = "0x600004A")]
			[Cpp2IlInjected.Address(RVA = "0x675DE30", Offset = "0x675D030", VA = "0x18675DE30")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x600004B")]
			[Cpp2IlInjected.Address(RVA = "0x675F6C0", Offset = "0x675E8C0", VA = "0x18675F6C0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000017")]
		public float CCIDBFAPCKG
		{
			[Cpp2IlInjected.Token(Token = "0x600004C")]
			[Cpp2IlInjected.Address(RVA = "0x675DC30", Offset = "0x675CE30", VA = "0x18675DC30")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x600004D")]
			[Cpp2IlInjected.Address(RVA = "0x675F490", Offset = "0x675E690", VA = "0x18675F490")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000018")]
		public bool MOIKHBKFGCG
		{
			[Cpp2IlInjected.Token(Token = "0x600004E")]
			[Cpp2IlInjected.Address(RVA = "0x675EA40", Offset = "0x675DC40", VA = "0x18675EA40")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x600004F")]
			[Cpp2IlInjected.Address(RVA = "0x67601B0", Offset = "0x675F3B0", VA = "0x1867601B0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000019")]
		public Vector3 HEKNBIPIBAH
		{
			[Cpp2IlInjected.Token(Token = "0x6000050")]
			[Cpp2IlInjected.Address(RVA = "0x675E240", Offset = "0x675D440", VA = "0x18675E240")]
			get
			{
				return default(Vector3);
			}
			[Cpp2IlInjected.Token(Token = "0x6000051")]
			[Cpp2IlInjected.Address(RVA = "0x675F9D0", Offset = "0x675EBD0", VA = "0x18675F9D0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001A")]
		public Vector3 DBKAIKHNCKG
		{
			[Cpp2IlInjected.Token(Token = "0x6000052")]
			[Cpp2IlInjected.Address(RVA = "0x675EB80", Offset = "0x675DD80", VA = "0x18675EB80")]
			get
			{
				return default(Vector3);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001B")]
		public CollisionDetectionMode OEGHLCDBHKO
		{
			[Cpp2IlInjected.Token(Token = "0x6000053")]
			[Cpp2IlInjected.Address(RVA = "0x675DD70", Offset = "0x675CF70", VA = "0x18675DD70")]
			get
			{
				return default(CollisionDetectionMode);
			}
			[Cpp2IlInjected.Token(Token = "0x6000054")]
			[Cpp2IlInjected.Address(RVA = "0x675F5E0", Offset = "0x675E7E0", VA = "0x18675F5E0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001C")]
		public float LMKDGNICGIN
		{
			[Cpp2IlInjected.Token(Token = "0x6000055")]
			[Cpp2IlInjected.Address(RVA = "0x675D900", Offset = "0x675CB00", VA = "0x18675D900")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x6000056")]
			[Cpp2IlInjected.Address(RVA = "0x675F340", Offset = "0x675E540", VA = "0x18675F340")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001D")]
		public RigidbodyConstraints KMKMKEJDMDN
		{
			[Cpp2IlInjected.Token(Token = "0x6000057")]
			[Cpp2IlInjected.Address(RVA = "0x675DDD0", Offset = "0x675CFD0", VA = "0x18675DDD0")]
			get
			{
				return default(RigidbodyConstraints);
			}
			[Cpp2IlInjected.Token(Token = "0x6000058")]
			[Cpp2IlInjected.Address(RVA = "0x675F650", Offset = "0x675E850", VA = "0x18675F650")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001E")]
		public Vector3 GPIGNGPLMOE
		{
			[Cpp2IlInjected.Token(Token = "0x6000059")]
			[Cpp2IlInjected.Address(RVA = "0x675E580", Offset = "0x675D780", VA = "0x18675E580")]
			get
			{
				return default(Vector3);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001F")]
		public Vector3 INKGHPCDMCG
		{
			[Cpp2IlInjected.Token(Token = "0x600005A")]
			[Cpp2IlInjected.Address(RVA = "0x675E580", Offset = "0x675D780", VA = "0x18675E580")]
			get
			{
				return default(Vector3);
			}
			[Cpp2IlInjected.Token(Token = "0x600005B")]
			[Cpp2IlInjected.Address(RVA = "0x675FF80", Offset = "0x675F180", VA = "0x18675FF80")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000020")]
		public float DDJODLEKNIM
		{
			[Cpp2IlInjected.Token(Token = "0x600005C")]
			[Cpp2IlInjected.Address(RVA = "0x675E320", Offset = "0x675D520", VA = "0x18675E320")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x600005D")]
			[Cpp2IlInjected.Address(RVA = "0x675FAB0", Offset = "0x675ECB0", VA = "0x18675FAB0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000021")]
		public float PDNBMOJFPKO
		{
			[Cpp2IlInjected.Token(Token = "0x600005E")]
			[Cpp2IlInjected.Address(RVA = "0x675E9E0", Offset = "0x675DBE0", VA = "0x18675E9E0")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x600005F")]
			[Cpp2IlInjected.Address(RVA = "0x6760140", Offset = "0x675F340", VA = "0x186760140")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000022")]
		public Quaternion FMCEIDJGNFC
		{
			[Cpp2IlInjected.Token(Token = "0x6000060")]
			[Cpp2IlInjected.Address(RVA = "0x675E660", Offset = "0x675D860", VA = "0x18675E660")]
			get
			{
				return default(Quaternion);
			}
			[Cpp2IlInjected.Token(Token = "0x6000061")]
			[Cpp2IlInjected.Address(RVA = "0x675FCE0", Offset = "0x675EEE0", VA = "0x18675FCE0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000023")]
		public Quaternion OOFIIEKBKAE
		{
			[Cpp2IlInjected.Token(Token = "0x6000062")]
			[Cpp2IlInjected.Address(RVA = "0x675E900", Offset = "0x675DB00", VA = "0x18675E900")]
			get
			{
				return default(Quaternion);
			}
			[Cpp2IlInjected.Token(Token = "0x6000063")]
			[Cpp2IlInjected.Address(RVA = "0x6760060", Offset = "0x675F260", VA = "0x186760060")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000024")]
		public Vector3 ECLKCFJCCPK
		{
			[Cpp2IlInjected.Token(Token = "0x6000064")]
			[Cpp2IlInjected.Address(RVA = "0x675E740", Offset = "0x675D940", VA = "0x18675E740")]
			get
			{
				return default(Vector3);
			}
			[Cpp2IlInjected.Token(Token = "0x6000065")]
			[Cpp2IlInjected.Address(RVA = "0x675FDC0", Offset = "0x675EFC0", VA = "0x18675FDC0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000025")]
		public Quaternion IFLPKMMMHCF
		{
			[Cpp2IlInjected.Token(Token = "0x6000066")]
			[Cpp2IlInjected.Address(RVA = "0x675E820", Offset = "0x675DA20", VA = "0x18675E820")]
			get
			{
				return default(Quaternion);
			}
			[Cpp2IlInjected.Token(Token = "0x6000067")]
			[Cpp2IlInjected.Address(RVA = "0x675FEA0", Offset = "0x675F0A0", VA = "0x18675FEA0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000026")]
		public Vector3 OIEPDFJCEHE
		{
			[Cpp2IlInjected.Token(Token = "0x6000068")]
			[Cpp2IlInjected.Address(RVA = "0x675EAA0", Offset = "0x675DCA0", VA = "0x18675EAA0")]
			get
			{
				return default(Vector3);
			}
			[Cpp2IlInjected.Token(Token = "0x6000069")]
			[Cpp2IlInjected.Address(RVA = "0x6760220", Offset = "0x675F420", VA = "0x186760220")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000027")]
		public Vector3 BPBFEPBHJOA
		{
			[Cpp2IlInjected.Token(Token = "0x600006A")]
			[Cpp2IlInjected.Address(RVA = "0x675E380", Offset = "0x675D580", VA = "0x18675E380")]
			get
			{
				return default(Vector3);
			}
			[Cpp2IlInjected.Token(Token = "0x600006B")]
			[Cpp2IlInjected.Address(RVA = "0x675FB20", Offset = "0x675ED20", VA = "0x18675FB20")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000028")]
		public Vector3 MEBJBANMPLK
		{
			[Cpp2IlInjected.Token(Token = "0x600006C")]
			[Cpp2IlInjected.Address(RVA = "0x675DC90", Offset = "0x675CE90", VA = "0x18675DC90")]
			get
			{
				return default(Vector3);
			}
			[Cpp2IlInjected.Token(Token = "0x600006D")]
			[Cpp2IlInjected.Address(RVA = "0x675F500", Offset = "0x675E700", VA = "0x18675F500")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000029")]
		public Vector3 NMCANIJEPAA
		{
			[Cpp2IlInjected.Token(Token = "0x600006E")]
			[Cpp2IlInjected.Address(RVA = "0x675E160", Offset = "0x675D360", VA = "0x18675E160")]
			get
			{
				return default(Vector3);
			}
			[Cpp2IlInjected.Token(Token = "0x600006F")]
			[Cpp2IlInjected.Address(RVA = "0x675F8F0", Offset = "0x675EAF0", VA = "0x18675F8F0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002A")]
		public Vector3 NBKEAILGEND
		{
			[Cpp2IlInjected.Token(Token = "0x6000070")]
			[Cpp2IlInjected.Address(RVA = "0x675E020", Offset = "0x675D220", VA = "0x18675E020")]
			get
			{
				return default(Vector3);
			}
			[Cpp2IlInjected.Token(Token = "0x6000071")]
			[Cpp2IlInjected.Address(RVA = "0x675F810", Offset = "0x675EA10", VA = "0x18675F810")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002B")]
		public Quaternion HFLGIFBAEKG
		{
			[Cpp2IlInjected.Token(Token = "0x6000072")]
			[Cpp2IlInjected.Address(RVA = "0x675DF40", Offset = "0x675D140", VA = "0x18675DF40")]
			get
			{
				return default(Quaternion);
			}
			[Cpp2IlInjected.Token(Token = "0x6000073")]
			[Cpp2IlInjected.Address(RVA = "0x675F730", Offset = "0x675E930", VA = "0x18675F730")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002C")]
		public Vector3 DBANBPKANJC
		{
			[Cpp2IlInjected.Token(Token = "0x6000074")]
			[Cpp2IlInjected.Address(RVA = "0x675ED40", Offset = "0x675DF40", VA = "0x18675ED40")]
			get
			{
				return default(Vector3);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002D")]
		public Vector3 HAHOHCIFHFB
		{
			[Cpp2IlInjected.Token(Token = "0x6000075")]
			[Cpp2IlInjected.Address(RVA = "0x675EC60", Offset = "0x675DE60", VA = "0x18675EC60")]
			get
			{
				return default(Vector3);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002E")]
		public bool AALOAMDFFGP
		{
			[Cpp2IlInjected.Token(Token = "0x6000076")]
			[Cpp2IlInjected.Address(RVA = "0x675E100", Offset = "0x675D300", VA = "0x18675E100")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002F")]
		public bool GCHJHCHGGCH
		{
			[Cpp2IlInjected.Token(Token = "0x6000077")]
			[Cpp2IlInjected.Address(RVA = "0x675D840", Offset = "0x675CA40", VA = "0x18675D840")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000030")]
		public bool CDFPEFIDNLO
		{
			[Cpp2IlInjected.Token(Token = "0x6000078")]
			[Cpp2IlInjected.Address(RVA = "0x675D780", Offset = "0x675C980", VA = "0x18675D780")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000031")]
		public bool HGMNJFIAPOP
		{
			[Cpp2IlInjected.Token(Token = "0x6000079")]
			[Cpp2IlInjected.Address(RVA = "0x675D720", Offset = "0x675C920", VA = "0x18675D720")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000032")]
		public bool KEAFALNHKKC
		{
			[Cpp2IlInjected.Token(Token = "0x600007A")]
			[Cpp2IlInjected.Address(RVA = "0x675D5F0", Offset = "0x675C7F0", VA = "0x18675D5F0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000033")]
		public bool AACMDEKGGIG
		{
			[Cpp2IlInjected.Token(Token = "0x600007B")]
			[Cpp2IlInjected.Address(RVA = "0x675DE90", Offset = "0x675D090", VA = "0x18675DE90")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000034")]
		public bool KKKHNMGIFMF
		{
			[Cpp2IlInjected.Token(Token = "0x600007C")]
			[Cpp2IlInjected.Address(RVA = "0x16B7370", Offset = "0x16B6570", VA = "0x1816B7370")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000001")]
		public event FGJCBPBEFOP FHAIHMAOAJM
		{
			[Cpp2IlInjected.Token(Token = "0x600001F")]
			[Cpp2IlInjected.Address(RVA = "0x675D510", Offset = "0x675C710", VA = "0x18675D510")]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000020")]
			[Cpp2IlInjected.Address(RVA = "0x675F130", Offset = "0x675E330", VA = "0x18675F130")]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000002")]
		public event OHFGCHALJBC AICPEIKMPML
		{
			[Cpp2IlInjected.Token(Token = "0x6000021")]
			[Cpp2IlInjected.Address(RVA = "0x675D4A0", Offset = "0x675C6A0", VA = "0x18675D4A0")]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000022")]
			[Cpp2IlInjected.Address(RVA = "0x675F0C0", Offset = "0x675E2C0", VA = "0x18675F0C0")]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000003")]
		public event FGJCBPBEFOP PBANFIJELBE
		{
			[Cpp2IlInjected.Token(Token = "0x6000023")]
			[Cpp2IlInjected.Address(RVA = "0x675D200", Offset = "0x675C400", VA = "0x18675D200")]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000024")]
			[Cpp2IlInjected.Address(RVA = "0x675EE20", Offset = "0x675E020", VA = "0x18675EE20")]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000004")]
		public event FGJCBPBEFOP MGANLNPCDNF
		{
			[Cpp2IlInjected.Token(Token = "0x6000025")]
			[Cpp2IlInjected.Address(RVA = "0x675D270", Offset = "0x675C470", VA = "0x18675D270")]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000026")]
			[Cpp2IlInjected.Address(RVA = "0x675EE90", Offset = "0x675E090", VA = "0x18675EE90")]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000005")]
		public event FGJCBPBEFOP HLDPKPODLLN
		{
			[Cpp2IlInjected.Token(Token = "0x6000027")]
			[Cpp2IlInjected.Address(RVA = "0x675D3C0", Offset = "0x675C5C0", VA = "0x18675D3C0")]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000028")]
			[Cpp2IlInjected.Address(RVA = "0x675EFE0", Offset = "0x675E1E0", VA = "0x18675EFE0")]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000006")]
		public event Action<AMBBOEBJPNH, AMBBOEBJPNH> FIKAFLHBAHL
		{
			[Cpp2IlInjected.Token(Token = "0x6000029")]
			[Cpp2IlInjected.Address(RVA = "0x675D350", Offset = "0x675C550", VA = "0x18675D350")]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x600002A")]
			[Cpp2IlInjected.Address(RVA = "0x675EF70", Offset = "0x675E170", VA = "0x18675EF70")]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000007")]
		public event FGJCBPBEFOP HPDODLFHIOG
		{
			[Cpp2IlInjected.Token(Token = "0x600002B")]
			[Cpp2IlInjected.Address(RVA = "0x675D430", Offset = "0x675C630", VA = "0x18675D430")]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x600002C")]
			[Cpp2IlInjected.Address(RVA = "0x675F050", Offset = "0x675E250", VA = "0x18675F050")]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000008")]
		public event FGJCBPBEFOP KINFMJICIBP
		{
			[Cpp2IlInjected.Token(Token = "0x600002D")]
			[Cpp2IlInjected.Address(RVA = "0x675D580", Offset = "0x675C780", VA = "0x18675D580")]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x600002E")]
			[Cpp2IlInjected.Address(RVA = "0x675F1A0", Offset = "0x675E3A0", VA = "0x18675F1A0")]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000009")]
		public event FGJCBPBEFOP MGBAEGFBPNJ
		{
			[Cpp2IlInjected.Token(Token = "0x600002F")]
			[Cpp2IlInjected.Address(RVA = "0x675D2E0", Offset = "0x675C4E0", VA = "0x18675D2E0")]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000030")]
			[Cpp2IlInjected.Address(RVA = "0x675EF00", Offset = "0x675E100", VA = "0x18675EF00")]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(RVA = "0x7BB020", Offset = "0x7BA220", VA = "0x1807BB020")]
		internal void CCODFLIBNPF(OINPHBHEBFM IDCNELICAAG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0x675C4D0", Offset = "0x675B6D0", VA = "0x18675C4D0")]
		internal void PPNJDANDELI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x675CF50", Offset = "0x675C150", VA = "0x18675CF50")]
		[Conditional("DEBUG_BUILD")]
		[Conditional("UNITY_EDITOR")]
		public void TestOverrideUnityRigidbody(Rigidbody EACAGOOIFKJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007D")]
		[Cpp2IlInjected.Address(RVA = "0x675B800", Offset = "0x675AA00", VA = "0x18675B800")]
		private void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007E")]
		[Cpp2IlInjected.Address(RVA = "0x675BAB0", Offset = "0x675ACB0", VA = "0x18675BAB0")]
		private OINPHBHEBFM NFNNOEDMHMM()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600007F")]
		[Cpp2IlInjected.Address(RVA = "0x675BEA0", Offset = "0x675B0A0", VA = "0x18675BEA0")]
		private void LLLPMINBGLL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000080")]
		[Cpp2IlInjected.Address(RVA = "0x675C400", Offset = "0x675B600", VA = "0x18675C400")]
		private void OnEnable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000081")]
		[Cpp2IlInjected.Address(RVA = "0x675C390", Offset = "0x675B590", VA = "0x18675C390")]
		private void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000082")]
		[Cpp2IlInjected.Address(RVA = "0x675BB60", Offset = "0x675AD60", VA = "0x18675BB60")]
		private void FixedUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000083")]
		[Cpp2IlInjected.Address(RVA = "0x675C3A0", Offset = "0x675B5A0", VA = "0x18675C3A0")]
		private void OnDrawGizmosSelected()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000084")]
		[Cpp2IlInjected.Address(RVA = "0x675C460", Offset = "0x675B660", VA = "0x18675C460")]
		private void OnValidate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000085")]
		[Cpp2IlInjected.Address(RVA = "0x675AE90", Offset = "0x675A090", VA = "0x18675AE90")]
		public void AddDoNotResetVelocityOnOwnershipChangeOverride(object IALNODEHBNN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000086")]
		[Cpp2IlInjected.Address(RVA = "0x675C560", Offset = "0x675B760", VA = "0x18675C560")]
		public void RemoveDoNotResetVelocityOnOwnershipChangeOverride(object IALNODEHBNN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000087")]
		[Cpp2IlInjected.Address(RVA = "0x675BA50", Offset = "0x675AC50", VA = "0x18675BA50")]
		public void DisableCachedInertialPropertyOverride()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000088")]
		[Cpp2IlInjected.Address(RVA = "0x675C330", Offset = "0x675B530", VA = "0x18675C330")]
		public void MarkCachedInertialParametersDirty()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000089")]
		[Cpp2IlInjected.Address(RVA = "0x675CD50", Offset = "0x675BF50", VA = "0x18675CD50")]
		public void SetParent(RigidbodyEx IPMIIEAGJKC, bool LDEEGDEKBLJ = false)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008A")]
		[Cpp2IlInjected.Address(RVA = "0x675C870", Offset = "0x675BA70", VA = "0x18675C870")]
		public void ResetLocalCenterOfMassToPrefabDefault()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008B")]
		[Cpp2IlInjected.Address(RVA = "0x675BDC0", Offset = "0x675AFC0", VA = "0x18675BDC0")]
		public bool IsRigidbodyAncestor(RigidbodyEx JFIPBDILNIA)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600008C")]
		[Cpp2IlInjected.Address(RVA = "0x675BE00", Offset = "0x675B000", VA = "0x18675BE00")]
		public bool IsRigidbodyDescendant(RigidbodyEx LNLMJNMBENE)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600008D")]
		[Cpp2IlInjected.Address(RVA = "0x675B0B0", Offset = "0x675A2B0", VA = "0x18675B0B0")]
		public void AddInterpolationRestriction(object IALNODEHBNN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008E")]
		[Cpp2IlInjected.Address(RVA = "0x675C5D0", Offset = "0x675B7D0", VA = "0x18675C5D0")]
		public void RemoveInterpolationRestriction(object IALNODEHBNN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008F")]
		[Cpp2IlInjected.Address(RVA = "0x675B870", Offset = "0x675AA70", VA = "0x18675B870")]
		public IDisposable BeginKinematicScope()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000090")]
		[Cpp2IlInjected.Address(RVA = "0x675B120", Offset = "0x675A320", VA = "0x18675B120")]
		public void AddKinematic(object IALNODEHBNN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000091")]
		[Cpp2IlInjected.Address(RVA = "0x675C640", Offset = "0x675B840", VA = "0x18675C640")]
		public void RemoveKinematic(object IALNODEHBNN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000092")]
		[Cpp2IlInjected.Address(RVA = "0x675CCD0", Offset = "0x675BED0", VA = "0x18675CCD0")]
		public void SetKinematic(object IALNODEHBNN, bool DKKAHPAOACL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000093")]
		[Cpp2IlInjected.Address(RVA = "0x675CBD0", Offset = "0x675BDD0", VA = "0x18675CBD0")]
		public void SetDiscontinuousPositionAndRotation(Vector3 GACEEHCHKKI, Quaternion EMJCGIGPJKI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000094")]
		[Cpp2IlInjected.Address(RVA = "0x675CAD0", Offset = "0x675BCD0", VA = "0x18675CAD0")]
		public void SetDiscontinuousLocalPositionAndLocalRotation(Vector3 FJDPKNPNDDO, Quaternion CPOKLKIGKAG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000095")]
		[Cpp2IlInjected.Address(RVA = "0x675BCC0", Offset = "0x675AEC0", VA = "0x18675BCC0")]
		public Vector3 GetConstrainedVelocity(Vector3 OIEPDFJCEHE)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x6000096")]
		[Cpp2IlInjected.Address(RVA = "0x675BBC0", Offset = "0x675ADC0", VA = "0x18675BBC0")]
		public Vector3 GetConstrainedAngularVelocity(Vector3 MEBJBANMPLK)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x6000097")]
		[Cpp2IlInjected.Address(RVA = "0x675B020", Offset = "0x675A220", VA = "0x18675B020")]
		public void AddForce(Vector3 COPOILGLIAJ, ForceMode OJOAKAEAKAC = ForceMode.Force)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000098")]
		[Cpp2IlInjected.Address(RVA = "0x675AF00", Offset = "0x675A100", VA = "0x18675AF00")]
		public void AddForceAtPosition(Vector3 COPOILGLIAJ, Vector3 INLGLHIPOMC, ForceMode OJOAKAEAKAC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000099")]
		[Cpp2IlInjected.Address(RVA = "0x675B220", Offset = "0x675A420", VA = "0x18675B220")]
		public void AddTorque(Vector3 HMKLOLJGHPK, ForceMode OJOAKAEAKAC = ForceMode.Force)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009A")]
		[Cpp2IlInjected.Address(RVA = "0x675B190", Offset = "0x675A390", VA = "0x18675B190")]
		public void AddRelativeTorque(Vector3 HMKLOLJGHPK, ForceMode OJOAKAEAKAC = ForceMode.Force)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009B")]
		[Cpp2IlInjected.Address(RVA = "0x675D030", Offset = "0x675C230", VA = "0x18675D030")]
		public Vector3 WorldToLocalVelocity(Vector3 LMLFDADCHBI)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x600009C")]
		[Cpp2IlInjected.Address(RVA = "0x675C230", Offset = "0x675B430", VA = "0x18675C230")]
		public Vector3 LocalToWorldVelocity(Vector3 BPBFEPBHJOA)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x600009D")]
		[Cpp2IlInjected.Address(RVA = "0x675B9F0", Offset = "0x675ABF0", VA = "0x18675B9F0")]
		public void ClearVelocity()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009E")]
		[Cpp2IlInjected.Address(RVA = "0x675B990", Offset = "0x675AB90", VA = "0x18675B990")]
		public void ClearUnityRigidbodyVelocity()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009F")]
		[Cpp2IlInjected.Address(RVA = "0x675B930", Offset = "0x675AB30", VA = "0x18675B930")]
		public void ClearLinearVelocity()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A0")]
		[Cpp2IlInjected.Address(RVA = "0x675B8D0", Offset = "0x675AAD0", VA = "0x18675B8D0")]
		public void ClearAngularVelocity()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A1")]
		[Cpp2IlInjected.Address(RVA = "0x675C9D0", Offset = "0x675BBD0", VA = "0x18675C9D0")]
		public void ResetVelocityWorldSpace(Vector3 PHMOADGIOAB, Vector3 FHAOAKNDIMF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A2")]
		[Cpp2IlInjected.Address(RVA = "0x675C8D0", Offset = "0x675BAD0", VA = "0x18675C8D0")]
		public void ResetVelocityLocalSpace(Vector3 LGOGCCAJHAG, Vector3 NMCANIJEPAA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A3")]
		[Cpp2IlInjected.Address(RVA = "0x675C790", Offset = "0x675B990", VA = "0x18675C790")]
		public void ResetLinearVelocityLocalSpace(Vector3 LGOGCCAJHAG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A4")]
		[Cpp2IlInjected.Address(RVA = "0x675CE40", Offset = "0x675C040", VA = "0x18675CE40")]
		public bool SweepTest(Vector3 HLFIBIDOLEF, out RaycastHit KNFIEECFHPI, float GKJHODLJDHD)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000A5")]
		[Cpp2IlInjected.Address(RVA = "0x675BE40", Offset = "0x675B040", VA = "0x18675BE40")]
		public bool IsSleeping()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000A6")]
		[Cpp2IlInjected.Address(RVA = "0x675CDE0", Offset = "0x675BFE0", VA = "0x18675CDE0")]
		public void Sleep()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A7")]
		[Cpp2IlInjected.Address(RVA = "0x675CFD0", Offset = "0x675C1D0", VA = "0x18675CFD0")]
		public void WakeUp()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A8")]
		[Cpp2IlInjected.Address(RVA = "0x675B2B0", Offset = "0x675A4B0", VA = "0x18675B2B0")]
		public void AddUnityRigidbody(object IALNODEHBNN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A9")]
		[Cpp2IlInjected.Address(RVA = "0x675C6B0", Offset = "0x675B8B0", VA = "0x18675C6B0")]
		public void RemoveUnityRigidbody(object IALNODEHBNN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AA")]
		[Cpp2IlInjected.Address(RVA = "0x675B5D0", Offset = "0x675A7D0", VA = "0x18675B5D0")]
		public void ApplyForceVelocityChange(LJPGLADCBCM AKMNMFJGAOB, Vector3 GDBGENEPKJJ, float JCOIPNJNGNL, float JCNBFPLMFDC = 8f, float NCEHNBMCDCP = 1f)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AB")]
		[Cpp2IlInjected.Address(RVA = "0x675B4D0", Offset = "0x675A6D0", VA = "0x18675B4D0")]
		public void ApplyAngularVelocityChange(HKGKLOMPNFJ PLKHOFBGABO, Vector3 FLBMFCPCPEF, float OIOPGDDKGKH = float.PositiveInfinity)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AC")]
		[Cpp2IlInjected.Address(RVA = "0x675B6F0", Offset = "0x675A8F0", VA = "0x18675B6F0")]
		[Obsolete]
		public void ApplyTorqueAngularVelocityChangeDeprecated(HKGKLOMPNFJ PLKHOFBGABO, Vector3 HEGBBJCMANH, float MJJDNDIGKOE = 7f, float KDGELBODBFF = 1f)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AD")]
		[Cpp2IlInjected.Address(RVA = "0x675B410", Offset = "0x675A610", VA = "0x18675B410")]
		public bool AllowedScaleChange(float LJCAHLAFIEP)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000AE")]
		[Cpp2IlInjected.Address(RVA = "0x675B320", Offset = "0x675A520", VA = "0x18675B320")]
		public void AddWorldSpaceVelocityInHierarchyParentOverride(RigidbodyEx LBILOIKCIOK, object IALNODEHBNN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AF")]
		[Cpp2IlInjected.Address(RVA = "0x675C720", Offset = "0x675B920", VA = "0x18675C720")]
		public void RemoveWorldSpaceVelocityInHierarchyParentOverride(object IALNODEHBNN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B0")]
		[Cpp2IlInjected.Address(RVA = "0x675D180", Offset = "0x675C380", VA = "0x18675D180")]
		public RigidbodyEx()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
internal static class OHCHBOLPHEL
{
	[Cpp2IlInjected.Token(Token = "0x60000B5")]
	[Cpp2IlInjected.Address(RVA = "0x52C6190", Offset = "0x52C5390", VA = "0x1852C6190")]
	public static OINPHBHEBFM DLGMOOCFLIK(this RigidbodyEx EHHPLBPDKBE)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
public struct IPGEEHAGLOI
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000022")]
	public Rigidbody NBJEPCGIGPN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000023")]
	public PhotonView OGMNKDNMJCB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000024")]
	public OverridableVector3 ANDPMGMCECJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000025")]
	public OverridableVector3 EMKAIKHLGLK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000026")]
	public KHNEINFFHJE BGNILMBFPPE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
	[Cpp2IlInjected.Token(Token = "0x4000027")]
	public bool DLFJLCKGOKL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x35")]
	[Cpp2IlInjected.Token(Token = "0x4000028")]
	public bool PGPCBCLDNGO;
}
namespace RecRoom
{
	[Cpp2IlInjected.Token(Token = "0x200000E")]
	[CGDKNMKPKIP(OOBCCNCEGNI.Physics)]
	[PNCLNBNALEO(typeof(LNFAMCIHAGC), new string[] { })]
	public class RigidbodyExManager : LNFAMCIHAGC, CMLEAAEGAAL
	{
		[Cpp2IlInjected.Token(Token = "0x4000029")]
		private static readonly HDHIMOFHFJL AHADDDAMGKE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400002A")]
		private MFNEEGAKIKC JKCBLHNHOFH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400002B")]
		private KKMPBNDGPDK FPLPHBFOJPL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400002C")]
		private OGOEFOMBPJH OCOKLGBMDOL;

		[Cpp2IlInjected.Token(Token = "0x17000035")]
		public bool GPECOIAKPHM
		{
			[Cpp2IlInjected.Token(Token = "0x60000B6")]
			[Cpp2IlInjected.Address(RVA = "0x675AB20", Offset = "0x6759D20", VA = "0x18675AB20", Slot = "6")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000036")]
		public KKMPBNDGPDK KNPHKPIJPNO
		{
			[Cpp2IlInjected.Token(Token = "0x60000B7")]
			[Cpp2IlInjected.Address(RVA = "0x6FA000", Offset = "0x6F9200", VA = "0x1806FA000", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000037")]
		public OGOEFOMBPJH KGAOAOICALJ
		{
			[Cpp2IlInjected.Token(Token = "0x60000B8")]
			[Cpp2IlInjected.Address(RVA = "0x6F6390", Offset = "0x6F5590", VA = "0x1806F6390", Slot = "5")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000B9")]
		[Cpp2IlInjected.Address(RVA = "0x675AC60", Offset = "0x6759E60", VA = "0x18675AC60", Slot = "12")]
		public void PACELKAFLHO(BLBDINABANB LBBJCIBEDFD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000BA")]
		[Cpp2IlInjected.Address(RVA = "0x675A780", Offset = "0x6759980", VA = "0x18675A780", Slot = "7")]
		public HPHBHAKAACD CPDICKNJLLP(RigidbodyEx EHHPLBPDKBE)
		{
			return default(HPHBHAKAACD);
		}

		[Cpp2IlInjected.Token(Token = "0x60000BB")]
		[Cpp2IlInjected.Address(RVA = "0x675AB70", Offset = "0x6759D70", VA = "0x18675AB70")]
		private static HPHBHAKAACD NKICFNAJAJA(RigidbodyEx EHHPLBPDKBE)
		{
			return default(HPHBHAKAACD);
		}

		[Cpp2IlInjected.Token(Token = "0x60000BC")]
		[Cpp2IlInjected.Address(RVA = "0x675A580", Offset = "0x6759780", VA = "0x18675A580", Slot = "8")]
		public OINPHBHEBFM CLHPBOHHPLL(RigidbodyEx EHHPLBPDKBE, IPGEEHAGLOI PCPEJHIMHJJ)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000BD")]
		[Cpp2IlInjected.Address(RVA = "0x675AA50", Offset = "0x6759C50", VA = "0x18675AA50", Slot = "11")]
		private RigidbodyEx KGHFEHJFLFA(GameObject HKPJJHILEBG, IPGEEHAGLOI PCPEJHIMHJJ)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000BE")]
		[Cpp2IlInjected.Address(RVA = "0x675A690", Offset = "0x6759890", VA = "0x18675A690", Slot = "9")]
		public void CMABGKHLIIH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000BF")]
		[Cpp2IlInjected.Address(RVA = "0x675ACF0", Offset = "0x6759EF0", VA = "0x18675ACF0", Slot = "10")]
		public void PIIGHFINGLC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C0")]
		[Cpp2IlInjected.Address(RVA = "0x703570", Offset = "0x702770", VA = "0x180703570")]
		public RigidbodyExManager()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000F")]
	public class PhysicsManager : SingletonMonoBehaviour<PhysicsManager>
	{
		[Cpp2IlInjected.Token(Token = "0x400002D")]
		public static EEANDDJEMJC UpdateAfterFixedUpdateRan;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400002E")]
		private int DNCNPEIGIPJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x400002F")]
		private int EPCPBHKCEGK;

		[Cpp2IlInjected.Token(Token = "0x60000C2")]
		[Cpp2IlInjected.Address(RVA = "0x675A060", Offset = "0x6759260", VA = "0x18675A060")]
		protected void FixedUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C3")]
		[Cpp2IlInjected.Address(RVA = "0x675A0A0", Offset = "0x67592A0", VA = "0x18675A0A0")]
		protected void Update()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C4")]
		[Cpp2IlInjected.Address(RVA = "0x675A080", Offset = "0x6759280", VA = "0x18675A080")]
		protected void LateUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C5")]
		[Cpp2IlInjected.Address(RVA = "0x6F84D0", Offset = "0x6F76D0", VA = "0x1806F84D0")]
		[Conditional("UNITY_ASSERTIONS")]
		public void AssertLateColliderPositionsNotYetUpdated([Optional] string OFCFPGACNJB, [Optional] UnityEngine.Object DELCOFCGDFF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C6")]
		[Cpp2IlInjected.Address(RVA = "0x6F84D0", Offset = "0x6F76D0", VA = "0x1806F84D0")]
		[Conditional("UNITY_ASSERTIONS")]
		public void AssertLateColliderPositionsAlreadyUpdated([Optional] string OFCFPGACNJB, [Optional] UnityEngine.Object DELCOFCGDFF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C7")]
		[Cpp2IlInjected.Address(RVA = "0x675A190", Offset = "0x6759390", VA = "0x18675A190")]
		public PhysicsManager()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
public static class CKDPOPNCMGA
{
	[Cpp2IlInjected.Token(Token = "0x60000C9")]
	[Cpp2IlInjected.Address(RVA = "0x52A4ED0", Offset = "0x52A40D0", VA = "0x1852A4ED0")]
	public static void MMBMKGHCCMB(this Rigidbody EACAGOOIFKJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CA")]
	[Cpp2IlInjected.Address(RVA = "0x52A5020", Offset = "0x52A4220", VA = "0x1852A5020")]
	public static void MMBMKGHCCMB(this Rigidbody EACAGOOIFKJ, Vector3 NBKEAILGEND, Quaternion HFLGIFBAEKG, Vector3 DNLNKBOBHJB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CB")]
	[Cpp2IlInjected.Address(RVA = "0x52A5130", Offset = "0x52A4330", VA = "0x1852A5130")]
	public static void NEEDPODBLJH(Vector3 OIEPDFJCEHE, Vector3 CHEKLLFMKBP, out Vector3 KGBDNFMMAEI, out Vector3 FBFBBCCDGJA)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
public static class GCFLKLFLKCE
{
	[Cpp2IlInjected.Token(Token = "0x2000012")]
	private class GDJGMIDIHJB : OEEBBDJIDDP, IDisposable
	{
		[Cpp2IlInjected.Token(Token = "0x60000CE")]
		[Cpp2IlInjected.Address(RVA = "0x6F84D0", Offset = "0x6F76D0", VA = "0x1806F84D0", Slot = "6")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000CF")]
		[Cpp2IlInjected.Address(RVA = "0xCB54E0", Offset = "0xCB46E0", VA = "0x180CB54E0", Slot = "4")]
		public Vector3 ECFALEPCOLJ()
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x60000D0")]
		[Cpp2IlInjected.Address(RVA = "0xCB54E0", Offset = "0xCB46E0", VA = "0x180CB54E0", Slot = "5")]
		public Vector3 OLEFKCKECDC()
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x60000D1")]
		[Cpp2IlInjected.Address(RVA = "0x703570", Offset = "0x702770", VA = "0x180703570")]
		public GDJGMIDIHJB()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000038")]
	public static OEEBBDJIDDP ECDFGDPLFEO
	{
		[Cpp2IlInjected.Token(Token = "0x60000CC")]
		[Cpp2IlInjected.Address(RVA = "0x52AF660", Offset = "0x52AE860", VA = "0x1852AF660")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000013")]
public interface CEEAALLPPCM
{
	[Cpp2IlInjected.Token(Token = "0x17000039")]
	CollisionDetectionMode FEOBMNMPKBK
	{
		[Cpp2IlInjected.Token(Token = "0x60000D2")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
		[Cpp2IlInjected.Token(Token = "0x60000D3")]
		[Cpp2IlInjected.Address(Slot = "1")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x60000D4")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void JDBMEAOELGO();

	[Cpp2IlInjected.Token(Token = "0x60000D5")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void FBBHPGOJJEA(bool AALOAMDFFGP);

	[Cpp2IlInjected.Token(Token = "0x60000D6")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void LBLCJPGOPBO(bool AALOAMDFFGP);

	[Cpp2IlInjected.Token(Token = "0x60000D7")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void NJINOCNPPGC(Rigidbody NBJEPCGIGPN);

	[Cpp2IlInjected.Token(Token = "0x60000D8")]
	[Cpp2IlInjected.Address(Slot = "6")]
	bool FHJIOGHMPNH(Vector3 HLFIBIDOLEF, out RaycastHit KNFIEECFHPI, float GKJHODLJDHD);
}
[Cpp2IlInjected.Token(Token = "0x2000014")]
public interface NOIDPDKILCA : IDisposable, DFBGLPCFOHL
{
	[Cpp2IlInjected.Token(Token = "0x1700003A")]
	HHLALPMEMBB AJFBHNJDDCE
	{
		[Cpp2IlInjected.Token(Token = "0x60000DB")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
		[Cpp2IlInjected.Token(Token = "0x60000DC")]
		[Cpp2IlInjected.Address(Slot = "3")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x1400000A")]
	event Action<AMBBOEBJPNH, AMBBOEBJPNH> FIKAFLHBAHL;

	[Cpp2IlInjected.Token(Token = "0x60000DD")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void JDBMEAOELGO();
}
[Cpp2IlInjected.Token(Token = "0x2000015")]
[OHBLGBNBPGG(IHBBGOJDEFH.Application)]
public interface OGOEFOMBPJH
{
	[Cpp2IlInjected.Token(Token = "0x60000DE")]
	[Cpp2IlInjected.Address(Slot = "0")]
	ACEBILIFEIP EJNJPHFBJAM(OINPHBHEBFM IDCNELICAAG);

	[Cpp2IlInjected.Token(Token = "0x60000DF")]
	[Cpp2IlInjected.Address(Slot = "1")]
	BNAKOLNKNGH OOJKGMEHDNF(OINPHBHEBFM IDCNELICAAG);

	[Cpp2IlInjected.Token(Token = "0x60000E0")]
	[Cpp2IlInjected.Address(Slot = "2")]
	OPBHABCMHHK CEEMIGDENAG(OINPHBHEBFM IDCNELICAAG);

	[Cpp2IlInjected.Token(Token = "0x60000E1")]
	[Cpp2IlInjected.Address(Slot = "3")]
	CAMJCFKKLPP MABBNAIELLP(OINPHBHEBFM IDCNELICAAG);

	[Cpp2IlInjected.Token(Token = "0x60000E2")]
	[Cpp2IlInjected.Address(Slot = "4")]
	GEILDFNHLPL CGFFJKNNLNE(OINPHBHEBFM IDCNELICAAG);

	[Cpp2IlInjected.Token(Token = "0x60000E3")]
	[Cpp2IlInjected.Address(Slot = "5")]
	NOIDPDKILCA KOLDEJMAFHK(OINPHBHEBFM IDCNELICAAG);

	[Cpp2IlInjected.Token(Token = "0x60000E4")]
	[Cpp2IlInjected.Address(Slot = "6")]
	KJLCKLHHAII BMLHJBKCGFH(OINPHBHEBFM IDCNELICAAG);

	[Cpp2IlInjected.Token(Token = "0x60000E5")]
	[Cpp2IlInjected.Address(Slot = "7")]
	EJPBMJKJDKA PAFCLIMBNAE(OINPHBHEBFM IDCNELICAAG);

	[Cpp2IlInjected.Token(Token = "0x60000E6")]
	[Cpp2IlInjected.Address(Slot = "8")]
	CEEAALLPPCM OKEMMGAOJKM(OINPHBHEBFM IDCNELICAAG);

	[Cpp2IlInjected.Token(Token = "0x60000E7")]
	[Cpp2IlInjected.Address(Slot = "9")]
	JIHFCAHMINI BFDNMJBGHBI(OINPHBHEBFM IDCNELICAAG);

	[Cpp2IlInjected.Token(Token = "0x60000E8")]
	[Cpp2IlInjected.Address(Slot = "10")]
	COPEPEMIJFF FPJHOFIMCCE(OINPHBHEBFM IDCNELICAAG, in IPGEEHAGLOI PCPEJHIMHJJ);

	[Cpp2IlInjected.Token(Token = "0x60000E9")]
	[Cpp2IlInjected.Address(Slot = "11")]
	HDMHGHFDNPO FPADGNCCPBE(OINPHBHEBFM IDCNELICAAG, in IPGEEHAGLOI PCPEJHIMHJJ);

	[Cpp2IlInjected.Token(Token = "0x60000EA")]
	[Cpp2IlInjected.Address(Slot = "12")]
	POMIHBCAKMM JCPGNOCGCJF(OINPHBHEBFM IDCNELICAAG, in IPGEEHAGLOI PCPEJHIMHJJ);

	[Cpp2IlInjected.Token(Token = "0x60000EB")]
	[Cpp2IlInjected.Address(Slot = "13")]
	KMFGIPGBMDB LFCHENHLEOJ(OINPHBHEBFM IDCNELICAAG, in IPGEEHAGLOI PCPEJHIMHJJ);

	[Cpp2IlInjected.Token(Token = "0x60000EC")]
	[Cpp2IlInjected.Address(Slot = "14")]
	KJDGGMNDKPF HMGIHLCDOBO(OINPHBHEBFM IDCNELICAAG, in IPGEEHAGLOI PCPEJHIMHJJ);

	[Cpp2IlInjected.Token(Token = "0x60000ED")]
	[Cpp2IlInjected.Address(Slot = "15")]
	OINPHBHEBFM CLHPBOHHPLL(RigidbodyEx EHHPLBPDKBE, IPGEEHAGLOI PCPEJHIMHJJ, LNFAMCIHAGC ACDHNMANGFE);
}
[Cpp2IlInjected.Token(Token = "0x2000016")]
public interface EJPBMJKJDKA
{
	[Cpp2IlInjected.Token(Token = "0x60000EE")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void OPLMNHEAGKL(Vector3 COPOILGLIAJ, ForceMode OJOAKAEAKAC = ForceMode.Force);

	[Cpp2IlInjected.Token(Token = "0x60000EF")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void FLNNLAIJPLD(Vector3 COPOILGLIAJ, Vector3 INLGLHIPOMC, ForceMode OJOAKAEAKAC);

	[Cpp2IlInjected.Token(Token = "0x60000F0")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void FLJCPNJHDAE(Vector3 HMKLOLJGHPK, ForceMode OJOAKAEAKAC = ForceMode.Force);

	[Cpp2IlInjected.Token(Token = "0x60000F1")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void DLOBEAKDAFF(Vector3 HMKLOLJGHPK, ForceMode OJOAKAEAKAC = ForceMode.Force);
}
[Cpp2IlInjected.Token(Token = "0x2000017")]
public interface JIHFCAHMINI
{
	[Cpp2IlInjected.Token(Token = "0x1700003B")]
	bool NFPCLOGDCAI
	{
		[Cpp2IlInjected.Token(Token = "0x60000F2")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
		[Cpp2IlInjected.Token(Token = "0x60000F3")]
		[Cpp2IlInjected.Address(Slot = "1")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x60000F4")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void NJINOCNPPGC(Rigidbody NBJEPCGIGPN);

	[Cpp2IlInjected.Token(Token = "0x60000F5")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void NNCOBAOCBLO(Rigidbody NBJEPCGIGPN);
}
[Cpp2IlInjected.Token(Token = "0x2000018")]
public interface ACEBILIFEIP : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x1700003C")]
	IReadOnlyList<OINPHBHEBFM> NCLNEDAIDDA
	{
		[Cpp2IlInjected.Token(Token = "0x6000108")]
		[Cpp2IlInjected.Address(Slot = "18")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700003D")]
	OINPHBHEBFM CFHDLGEGDFD
	{
		[Cpp2IlInjected.Token(Token = "0x6000109")]
		[Cpp2IlInjected.Address(Slot = "19")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700003E")]
	OINPHBHEBFM HKAHNOCIENG
	{
		[Cpp2IlInjected.Token(Token = "0x600010A")]
		[Cpp2IlInjected.Address(Slot = "20")]
		get;
		[Cpp2IlInjected.Token(Token = "0x600010B")]
		[Cpp2IlInjected.Address(Slot = "21")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x1400000B")]
	event FGJCBPBEFOP PBANFIJELBE;

	[Cpp2IlInjected.Token(Token = "0x1400000C")]
	event FGJCBPBEFOP MGANLNPCDNF;

	[Cpp2IlInjected.Token(Token = "0x1400000D")]
	event OHFGCHALJBC CLHKPMHNJGH;

	[Cpp2IlInjected.Token(Token = "0x1400000E")]
	event Action LEPPBOOKMBH;

	[Cpp2IlInjected.Token(Token = "0x1400000F")]
	event Action KDMAPDBOBHG;

	[Cpp2IlInjected.Token(Token = "0x14000010")]
	event Action<OINPHBHEBFM> NKBGAPIKEDN;

	[Cpp2IlInjected.Token(Token = "0x14000011")]
	event Action<OINPHBHEBFM> GBNGEPPDDCO;

	[Cpp2IlInjected.Token(Token = "0x14000012")]
	event Action NELDKADHHEN;

	[Cpp2IlInjected.Token(Token = "0x14000013")]
	event Action<OINPHBHEBFM> BCMOPJLPDJI;

	[Cpp2IlInjected.Token(Token = "0x600010C")]
	[Cpp2IlInjected.Address(Slot = "22")]
	void HMBNJDPGAJN(OINPHBHEBFM BDBBMBMDCFP, bool LDEEGDEKBLJ = false);
}
[Cpp2IlInjected.Token(Token = "0x2000019")]
public interface OPBHABCMHHK
{
	[Cpp2IlInjected.Token(Token = "0x1700003F")]
	Vector3 CEAFBIINOKH
	{
		[Cpp2IlInjected.Token(Token = "0x600010D")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000040")]
	Vector3 NHENIPHGFOP
	{
		[Cpp2IlInjected.Token(Token = "0x600010E")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x600010F")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void KDCKLPJMBKN(OINPHBHEBFM HHFDFFDPCGO, object IALNODEHBNN);

	[Cpp2IlInjected.Token(Token = "0x6000110")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void OMINIIDBGAF(object IALNODEHBNN);
}
[Cpp2IlInjected.Token(Token = "0x200001A")]
public interface KMFGIPGBMDB
{
	[Cpp2IlInjected.Token(Token = "0x17000041")]
	Vector3 CMPGKEOHLJC
	{
		[Cpp2IlInjected.Token(Token = "0x6000113")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
		[Cpp2IlInjected.Token(Token = "0x6000114")]
		[Cpp2IlInjected.Address(Slot = "3")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000042")]
	Vector3 EIMEJLMMLMA
	{
		[Cpp2IlInjected.Token(Token = "0x6000115")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000043")]
	float EHLCHKMKGBK
	{
		[Cpp2IlInjected.Token(Token = "0x6000116")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000044")]
	float BENEGDAHFLL
	{
		[Cpp2IlInjected.Token(Token = "0x6000117")]
		[Cpp2IlInjected.Address(Slot = "6")]
		get;
		[Cpp2IlInjected.Token(Token = "0x6000118")]
		[Cpp2IlInjected.Address(Slot = "7")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000045")]
	Vector3 NGJFIKPFMML
	{
		[Cpp2IlInjected.Token(Token = "0x6000119")]
		[Cpp2IlInjected.Address(Slot = "8")]
		get;
		[Cpp2IlInjected.Token(Token = "0x600011A")]
		[Cpp2IlInjected.Address(Slot = "9")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000046")]
	Quaternion LKICJOBKNGL
	{
		[Cpp2IlInjected.Token(Token = "0x600011B")]
		[Cpp2IlInjected.Address(Slot = "10")]
		get;
		[Cpp2IlInjected.Token(Token = "0x600011C")]
		[Cpp2IlInjected.Address(Slot = "11")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x14000014")]
	event FGJCBPBEFOP DABDOEGBNOF;

	[Cpp2IlInjected.Token(Token = "0x600011D")]
	[Cpp2IlInjected.Address(Slot = "12")]
	void OLIDEBFPCBJ();

	[Cpp2IlInjected.Token(Token = "0x600011E")]
	[Cpp2IlInjected.Address(Slot = "13")]
	void LILDLMIHEAF();

	[Cpp2IlInjected.Token(Token = "0x600011F")]
	[Cpp2IlInjected.Address(Slot = "14")]
	void KJCFGELAPLM();

	[Cpp2IlInjected.Token(Token = "0x6000120")]
	[Cpp2IlInjected.Address(Slot = "15")]
	void NJINOCNPPGC(Rigidbody NBJEPCGIGPN);

	[Cpp2IlInjected.Token(Token = "0x6000121")]
	[Cpp2IlInjected.Address(Slot = "16")]
	void NNCOBAOCBLO(Rigidbody NBJEPCGIGPN);

	[Cpp2IlInjected.Token(Token = "0x6000122")]
	[Cpp2IlInjected.Address(Slot = "17")]
	void AMMOJMDCBMC();
}
[Cpp2IlInjected.Token(Token = "0x200001B")]
public interface POMIHBCAKMM
{
	[Cpp2IlInjected.Token(Token = "0x17000047")]
	bool MGOICACOHNO
	{
		[Cpp2IlInjected.Token(Token = "0x6000123")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000048")]
	MGFMFIIFDMD MDEOCKDFDNK
	{
		[Cpp2IlInjected.Token(Token = "0x6000124")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000125")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void JDBMEAOELGO();

	[Cpp2IlInjected.Token(Token = "0x6000126")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void DOAIEIBIBFL(object IALNODEHBNN);

	[Cpp2IlInjected.Token(Token = "0x6000127")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void OEGPCOAFMDB(object IALNODEHBNN);

	[Cpp2IlInjected.Token(Token = "0x6000128")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void FGILIJPPIJA(OINPHBHEBFM EHHPLBPDKBE);

	[Cpp2IlInjected.Token(Token = "0x6000129")]
	[Cpp2IlInjected.Address(Slot = "6")]
	void NFHJNCFFDIO(OINPHBHEBFM EHHPLBPDKBE);

	[Cpp2IlInjected.Token(Token = "0x600012A")]
	[Cpp2IlInjected.Address(Slot = "7")]
	void IKKEJJKEGGH();
}
[Cpp2IlInjected.Token(Token = "0x200001C")]
public interface KJLCKLHHAII
{
	[Cpp2IlInjected.Token(Token = "0x17000049")]
	bool KFFOOLFOADP
	{
		[Cpp2IlInjected.Token(Token = "0x600012D")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700004A")]
	IEnumerable<object> NHEINPMGMGO
	{
		[Cpp2IlInjected.Token(Token = "0x600012E")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x14000015")]
	event FGJCBPBEFOP OLENKEHDGAF;

	[Cpp2IlInjected.Token(Token = "0x600012F")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void ANNHOHNEGBC(object IALNODEHBNN);

	[Cpp2IlInjected.Token(Token = "0x6000130")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void DIACCKFBBFC(object IALNODEHBNN);

	[Cpp2IlInjected.Token(Token = "0x6000131")]
	[Cpp2IlInjected.Address(Slot = "6")]
	void IMCEFNKDLJE(object IALNODEHBNN, bool DKKAHPAOACL);

	[Cpp2IlInjected.Token(Token = "0x6000132")]
	[Cpp2IlInjected.Address(Slot = "7")]
	IDisposable EEBIOLKMNJN();

	[Cpp2IlInjected.Token(Token = "0x6000133")]
	[Cpp2IlInjected.Address(Slot = "8")]
	void NJINOCNPPGC(Rigidbody FNBMGBEMKPE);

	[Cpp2IlInjected.Token(Token = "0x6000134")]
	[Cpp2IlInjected.Address(Slot = "9")]
	void NNCOBAOCBLO(Rigidbody NBJEPCGIGPN);
}
[Cpp2IlInjected.Token(Token = "0x200001D")]
public interface HDMHGHFDNPO : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x1700004B")]
	bool NKELDOMJEGL
	{
		[Cpp2IlInjected.Token(Token = "0x6000137")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700004C")]
	bool DMMCOKOAOJI
	{
		[Cpp2IlInjected.Token(Token = "0x6000138")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x14000016")]
	event FGJCBPBEFOP EBDIBBFMNAG;

	[Cpp2IlInjected.Token(Token = "0x6000139")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void JDBMEAOELGO();

	[Cpp2IlInjected.Token(Token = "0x600013A")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void JLNECFHPDHL(OINPHBHEBFM HHFDFFDPCGO);

	[Cpp2IlInjected.Token(Token = "0x600013B")]
	[Cpp2IlInjected.Address(Slot = "6")]
	void LAJHBEDDHLL(OINPHBHEBFM HHFDFFDPCGO);
}
[Cpp2IlInjected.Token(Token = "0x200001E")]
public interface KJDGGMNDKPF
{
	[Cpp2IlInjected.Token(Token = "0x1700004D")]
	bool ADJEMOAFAPK
	{
		[Cpp2IlInjected.Token(Token = "0x600013C")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
		[Cpp2IlInjected.Token(Token = "0x600013D")]
		[Cpp2IlInjected.Address(Slot = "1")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x1700004E")]
	bool CEBDHLOLCGG
	{
		[Cpp2IlInjected.Token(Token = "0x600013E")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700004F")]
	RigidbodyConstraints PILCFECIKIL
	{
		[Cpp2IlInjected.Token(Token = "0x600013F")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
		[Cpp2IlInjected.Token(Token = "0x6000140")]
		[Cpp2IlInjected.Address(Slot = "4")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x6000141")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void NJINOCNPPGC(Rigidbody NBJEPCGIGPN);

	[Cpp2IlInjected.Token(Token = "0x6000142")]
	[Cpp2IlInjected.Address(Slot = "6")]
	void NNCOBAOCBLO(Rigidbody NBJEPCGIGPN);
}
[Cpp2IlInjected.Token(Token = "0x200001F")]
public interface CAMJCFKKLPP
{
	[Cpp2IlInjected.Token(Token = "0x17000050")]
	float PIPAENOKBKE
	{
		[Cpp2IlInjected.Token(Token = "0x6000143")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
		[Cpp2IlInjected.Token(Token = "0x6000144")]
		[Cpp2IlInjected.Address(Slot = "1")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000051")]
	float HGOJLGHHICI
	{
		[Cpp2IlInjected.Token(Token = "0x6000145")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
		[Cpp2IlInjected.Token(Token = "0x6000146")]
		[Cpp2IlInjected.Address(Slot = "3")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x6000147")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void NJINOCNPPGC(Rigidbody NBJEPCGIGPN);

	[Cpp2IlInjected.Token(Token = "0x6000148")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void NNCOBAOCBLO(Rigidbody NBJEPCGIGPN);
}
[Cpp2IlInjected.Token(Token = "0x2000020")]
public interface ADJIPENKGPB
{
	[Cpp2IlInjected.Token(Token = "0x6000149")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void OnRootRBEXChanged(RigidbodyEx NJNKCEEIMHB);
}
[Cpp2IlInjected.Token(Token = "0x2000021")]
public interface GEILDFNHLPL
{
	[Cpp2IlInjected.Token(Token = "0x14000017")]
	event FGJCBPBEFOP MLKAKEPMHOI;

	[Cpp2IlInjected.Token(Token = "0x600014C")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void JDBMEAOELGO();

	[Cpp2IlInjected.Token(Token = "0x600014D")]
	[Cpp2IlInjected.Address(Slot = "3")]
	bool JIPELJMHGEE();

	[Cpp2IlInjected.Token(Token = "0x600014E")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void OBJEFDDDJLF();

	[Cpp2IlInjected.Token(Token = "0x600014F")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void HILGCFFPCIP();

	[Cpp2IlInjected.Token(Token = "0x6000150")]
	[Cpp2IlInjected.Address(Slot = "6")]
	void HNHGDPMCPBD();

	[Cpp2IlInjected.Token(Token = "0x6000151")]
	[Cpp2IlInjected.Address(Slot = "7")]
	void EMMDJJNLKHB();

	[Cpp2IlInjected.Token(Token = "0x6000152")]
	[Cpp2IlInjected.Address(Slot = "8")]
	void EGIBKKKFHBP(bool JJOFBIIKAHB);
}
[Cpp2IlInjected.Token(Token = "0x2000022")]
public interface COPEPEMIJFF
{
	[Cpp2IlInjected.Token(Token = "0x17000052")]
	Rigidbody JMCCCFFEIIG
	{
		[Cpp2IlInjected.Token(Token = "0x6000153")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000154")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void JDBMEAOELGO();

	[Cpp2IlInjected.Token(Token = "0x6000155")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void IKBIHMLDNON(object IALNODEHBNN);

	[Cpp2IlInjected.Token(Token = "0x6000156")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void AIKKIMKHEPL(object IALNODEHBNN);

	[Cpp2IlInjected.Token(Token = "0x6000157")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void GDKFAEBPNCL();

	[Cpp2IlInjected.Token(Token = "0x6000158")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void GHFFCHLHKOL();

	[Cpp2IlInjected.Token(Token = "0x6000159")]
	[Cpp2IlInjected.Address(Slot = "6")]
	void DGCJEMMNGLK();

	[Cpp2IlInjected.Token(Token = "0x600015A")]
	[Cpp2IlInjected.Address(Slot = "7")]
	void NKAMGMBLDMK();
}
[Cpp2IlInjected.Token(Token = "0x2000023")]
public interface BNAKOLNKNGH : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x17000053")]
	OEEBBDJIDDP PJJKMCINJBG
	{
		[Cpp2IlInjected.Token(Token = "0x600015B")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
		[Cpp2IlInjected.Token(Token = "0x600015C")]
		[Cpp2IlInjected.Address(Slot = "1")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000054")]
	JIKDBJBLNKK GLMECOENJFF
	{
		[Cpp2IlInjected.Token(Token = "0x600015D")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
		[Cpp2IlInjected.Token(Token = "0x600015E")]
		[Cpp2IlInjected.Address(Slot = "3")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000055")]
	Vector3 BNMCMLCKBOK
	{
		[Cpp2IlInjected.Token(Token = "0x600015F")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
		[Cpp2IlInjected.Token(Token = "0x6000160")]
		[Cpp2IlInjected.Address(Slot = "5")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000056")]
	Vector3 PIHKAJHIGPH
	{
		[Cpp2IlInjected.Token(Token = "0x6000161")]
		[Cpp2IlInjected.Address(Slot = "6")]
		get;
		[Cpp2IlInjected.Token(Token = "0x6000162")]
		[Cpp2IlInjected.Address(Slot = "7")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000057")]
	Vector3 IIALMKBBALJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000163")]
		[Cpp2IlInjected.Address(Slot = "8")]
		get;
		[Cpp2IlInjected.Token(Token = "0x6000164")]
		[Cpp2IlInjected.Address(Slot = "9")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000058")]
	Vector3 KAHCHGJGLPH
	{
		[Cpp2IlInjected.Token(Token = "0x6000165")]
		[Cpp2IlInjected.Address(Slot = "10")]
		get;
		[Cpp2IlInjected.Token(Token = "0x6000166")]
		[Cpp2IlInjected.Address(Slot = "11")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000059")]
	float LMKDGNICGIN
	{
		[Cpp2IlInjected.Token(Token = "0x6000167")]
		[Cpp2IlInjected.Address(Slot = "12")]
		get;
		[Cpp2IlInjected.Token(Token = "0x6000168")]
		[Cpp2IlInjected.Address(Slot = "13")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x1700005A")]
	bool PHFFHNKCAKG
	{
		[Cpp2IlInjected.Token(Token = "0x6000169")]
		[Cpp2IlInjected.Address(Slot = "14")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x600016A")]
	[Cpp2IlInjected.Address(Slot = "15")]
	void JDBMEAOELGO();

	[Cpp2IlInjected.Token(Token = "0x600016B")]
	[Cpp2IlInjected.Address(Slot = "16")]
	void JGLKJDEBKJD(object IALNODEHBNN);

	[Cpp2IlInjected.Token(Token = "0x600016C")]
	[Cpp2IlInjected.Address(Slot = "17")]
	void HAMEOACBGEL(HKGKLOMPNFJ PLKHOFBGABO, Vector3 FLBMFCPCPEF, float OIOPGDDKGKH = float.PositiveInfinity);

	[Cpp2IlInjected.Token(Token = "0x600016D")]
	[Cpp2IlInjected.Address(Slot = "18")]
	void CNBEOMCPCEP(LJPGLADCBCM AKMNMFJGAOB, Vector3 GDBGENEPKJJ, float JCOIPNJNGNL, float JCNBFPLMFDC = 8f, float NCEHNBMCDCP = 1f);

	[Cpp2IlInjected.Token(Token = "0x600016E")]
	[Cpp2IlInjected.Address(Slot = "19")]
	void HLLOHDECLDE(HKGKLOMPNFJ PLKHOFBGABO, Vector3 HEGBBJCMANH, float MJJDNDIGKOE = 7f, float KDGELBODBFF = 1f);

	[Cpp2IlInjected.Token(Token = "0x600016F")]
	[Cpp2IlInjected.Address(Slot = "20")]
	void BCEKGKJPMMM();

	[Cpp2IlInjected.Token(Token = "0x6000170")]
	[Cpp2IlInjected.Address(Slot = "21")]
	void FFKNMCPIGAB();

	[Cpp2IlInjected.Token(Token = "0x6000171")]
	[Cpp2IlInjected.Address(Slot = "22")]
	void IDHDDIPDPEN();

	[Cpp2IlInjected.Token(Token = "0x6000172")]
	[Cpp2IlInjected.Address(Slot = "23")]
	void OIHOBLKLMEH();

	[Cpp2IlInjected.Token(Token = "0x6000173")]
	[Cpp2IlInjected.Address(Slot = "24")]
	void NJINOCNPPGC(Rigidbody NBJEPCGIGPN);

	[Cpp2IlInjected.Token(Token = "0x6000174")]
	[Cpp2IlInjected.Address(Slot = "25")]
	Vector3 AIJJDEBMEOJ(Vector3 MEBJBANMPLK);

	[Cpp2IlInjected.Token(Token = "0x6000175")]
	[Cpp2IlInjected.Address(Slot = "26")]
	Vector3 LKFCAEEDGGD(Vector3 OIEPDFJCEHE);

	[Cpp2IlInjected.Token(Token = "0x6000176")]
	[Cpp2IlInjected.Address(Slot = "27")]
	void EHJEMGCAHFC(object IALNODEHBNN);

	[Cpp2IlInjected.Token(Token = "0x6000177")]
	[Cpp2IlInjected.Address(Slot = "28")]
	void MKJDMMPONGJ(Vector3 PLAPBHBFKOO);

	[Cpp2IlInjected.Token(Token = "0x6000178")]
	[Cpp2IlInjected.Address(Slot = "29")]
	void JGGAJCAAMOB(Vector3 LGOGCCAJHAG, Vector3 NMCANIJEPAA);

	[Cpp2IlInjected.Token(Token = "0x6000179")]
	[Cpp2IlInjected.Address(Slot = "30")]
	void GLPKKFBJAKC(Vector3 PHMOADGIOAB, Vector3 FHAOAKNDIMF);

	[Cpp2IlInjected.Token(Token = "0x600017A")]
	[Cpp2IlInjected.Address(Slot = "31")]
	Vector3 HPOIKDMPEGF(Vector3 BPBFEPBHJOA);

	[Cpp2IlInjected.Token(Token = "0x600017B")]
	[Cpp2IlInjected.Address(Slot = "32")]
	Vector3 JLCJMKPHEDJ(Vector3 LMLFDADCHBI);
}
[Cpp2IlInjected.Token(Token = "0x2000024")]
[OHBLGBNBPGG(IHBBGOJDEFH.Application)]
public interface KKMPBNDGPDK
{
	[Cpp2IlInjected.Token(Token = "0x1700005B")]
	bool NLDDBJGMJOA
	{
		[Cpp2IlInjected.Token(Token = "0x600017C")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x600017D")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void FOFGCCCFKHB(string NLJOHEKGNDH);

	[Cpp2IlInjected.Token(Token = "0x600017E")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void EOKBFFEJHHG(RigidbodyEx EHHPLBPDKBE, Action IBKGKDECOEG);

	[Cpp2IlInjected.Token(Token = "0x600017F")]
	[Cpp2IlInjected.Address(Slot = "3")]
	PEMDLLFJFDM PELEBHNNNPD(int NMMLCFOALFP);

	[Cpp2IlInjected.Token(Token = "0x6000180")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void PKAAFHPDFGD(Vector3 DBKAIKHNCKG, float AAPKAJOCACA, Color HMCAFGCGFJF);
}
[Cpp2IlInjected.Token(Token = "0x2000025")]
[OHBLGBNBPGG(IHBBGOJDEFH.Application)]
public interface LNFAMCIHAGC
{
	[Cpp2IlInjected.Token(Token = "0x1700005C")]
	KKMPBNDGPDK KNPHKPIJPNO
	{
		[Cpp2IlInjected.Token(Token = "0x6000181")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700005D")]
	OGOEFOMBPJH KGAOAOICALJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000182")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700005E")]
	bool GPECOIAKPHM
	{
		[Cpp2IlInjected.Token(Token = "0x6000183")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000184")]
	[Cpp2IlInjected.Address(Slot = "3")]
	HPHBHAKAACD CPDICKNJLLP(RigidbodyEx EHHPLBPDKBE);

	[Cpp2IlInjected.Token(Token = "0x6000185")]
	[Cpp2IlInjected.Address(Slot = "4")]
	OINPHBHEBFM CLHPBOHHPLL(RigidbodyEx EHHPLBPDKBE, IPGEEHAGLOI PCPEJHIMHJJ);

	[Cpp2IlInjected.Token(Token = "0x6000186")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void CMABGKHLIIH();

	[Cpp2IlInjected.Token(Token = "0x6000187")]
	[Cpp2IlInjected.Address(Slot = "6")]
	void PIIGHFINGLC();

	[Cpp2IlInjected.Token(Token = "0x6000188")]
	[Cpp2IlInjected.Address(Slot = "7")]
	internal RigidbodyEx JLKDNHLKANG(GameObject HKPJJHILEBG, [Optional] IPGEEHAGLOI PCPEJHIMHJJ);
}
[Cpp2IlInjected.Token(Token = "0x2000026")]
public interface JIKDBJBLNKK
{
	[Cpp2IlInjected.Token(Token = "0x6000189")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void COHDEDLDEBK(Vector3 MCBCBMFBKCA);

	[Cpp2IlInjected.Token(Token = "0x600018A")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void LPOFAPPMPPG(Vector3 MEBJBANMPLK);

	[Cpp2IlInjected.Token(Token = "0x600018B")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void AICBLOMEKOO(Vector3 MCBCBMFBKCA);

	[Cpp2IlInjected.Token(Token = "0x600018C")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void MNKHOPCBOOD(Vector3 MEBJBANMPLK);
}
[Cpp2IlInjected.Token(Token = "0x2000027")]
public interface OEEBBDJIDDP : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x600018D")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Vector3 ECFALEPCOLJ();

	[Cpp2IlInjected.Token(Token = "0x600018E")]
	[Cpp2IlInjected.Address(Slot = "1")]
	Vector3 OLEFKCKECDC();
}
[Cpp2IlInjected.Token(Token = "0x2000028")]
public interface OINPHBHEBFM : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x1700005F")]
	Rigidbody JMCCCFFEIIG
	{
		[Cpp2IlInjected.Token(Token = "0x600018F")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000060")]
	RigidbodyEx LKJNPFKMFEJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000190")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000061")]
	GameObject HCEKAIAAOOF
	{
		[Cpp2IlInjected.Token(Token = "0x6000191")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000062")]
	Transform DHGHIDOLKGM
	{
		[Cpp2IlInjected.Token(Token = "0x6000192")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000063")]
	IEnumerable<object> MBNCNEFIHAG
	{
		[Cpp2IlInjected.Token(Token = "0x6000193")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000064")]
	OINPHBHEBFM HKAHNOCIENG
	{
		[Cpp2IlInjected.Token(Token = "0x6000194")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
		[Cpp2IlInjected.Token(Token = "0x6000195")]
		[Cpp2IlInjected.Address(Slot = "6")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000065")]
	IReadOnlyList<OINPHBHEBFM> NCLNEDAIDDA
	{
		[Cpp2IlInjected.Token(Token = "0x6000196")]
		[Cpp2IlInjected.Address(Slot = "7")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000066")]
	OINPHBHEBFM CFHDLGEGDFD
	{
		[Cpp2IlInjected.Token(Token = "0x6000197")]
		[Cpp2IlInjected.Address(Slot = "8")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000067")]
	bool LLNINBLBFFN
	{
		[Cpp2IlInjected.Token(Token = "0x6000198")]
		[Cpp2IlInjected.Address(Slot = "9")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000068")]
	bool NKELDOMJEGL
	{
		[Cpp2IlInjected.Token(Token = "0x6000199")]
		[Cpp2IlInjected.Address(Slot = "10")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000069")]
	bool DMMCOKOAOJI
	{
		[Cpp2IlInjected.Token(Token = "0x600019A")]
		[Cpp2IlInjected.Address(Slot = "11")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700006A")]
	OEEBBDJIDDP PJJKMCINJBG
	{
		[Cpp2IlInjected.Token(Token = "0x600019B")]
		[Cpp2IlInjected.Address(Slot = "12")]
		get;
		[Cpp2IlInjected.Token(Token = "0x600019C")]
		[Cpp2IlInjected.Address(Slot = "13")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x1700006B")]
	JIKDBJBLNKK GLMECOENJFF
	{
		[Cpp2IlInjected.Token(Token = "0x600019D")]
		[Cpp2IlInjected.Address(Slot = "14")]
		get;
		[Cpp2IlInjected.Token(Token = "0x600019E")]
		[Cpp2IlInjected.Address(Slot = "15")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x1700006C")]
	float LMKDGNICGIN
	{
		[Cpp2IlInjected.Token(Token = "0x600019F")]
		[Cpp2IlInjected.Address(Slot = "16")]
		get;
		[Cpp2IlInjected.Token(Token = "0x60001A0")]
		[Cpp2IlInjected.Address(Slot = "17")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x1700006D")]
	Vector3 PIHKAJHIGPH
	{
		[Cpp2IlInjected.Token(Token = "0x60001A1")]
		[Cpp2IlInjected.Address(Slot = "18")]
		get;
		[Cpp2IlInjected.Token(Token = "0x60001A2")]
		[Cpp2IlInjected.Address(Slot = "19")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x1700006E")]
	Vector3 KAHCHGJGLPH
	{
		[Cpp2IlInjected.Token(Token = "0x60001A3")]
		[Cpp2IlInjected.Address(Slot = "20")]
		get;
		[Cpp2IlInjected.Token(Token = "0x60001A4")]
		[Cpp2IlInjected.Address(Slot = "21")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x1700006F")]
	Vector3 BNMCMLCKBOK
	{
		[Cpp2IlInjected.Token(Token = "0x60001A5")]
		[Cpp2IlInjected.Address(Slot = "22")]
		get;
		[Cpp2IlInjected.Token(Token = "0x60001A6")]
		[Cpp2IlInjected.Address(Slot = "23")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000070")]
	Vector3 IIALMKBBALJ
	{
		[Cpp2IlInjected.Token(Token = "0x60001A7")]
		[Cpp2IlInjected.Address(Slot = "24")]
		get;
		[Cpp2IlInjected.Token(Token = "0x60001A8")]
		[Cpp2IlInjected.Address(Slot = "25")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000071")]
	bool CDFPEFIDNLO
	{
		[Cpp2IlInjected.Token(Token = "0x60001A9")]
		[Cpp2IlInjected.Address(Slot = "26")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000072")]
	bool HGMNJFIAPOP
	{
		[Cpp2IlInjected.Token(Token = "0x60001AA")]
		[Cpp2IlInjected.Address(Slot = "27")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000073")]
	bool KEAFALNHKKC
	{
		[Cpp2IlInjected.Token(Token = "0x60001AB")]
		[Cpp2IlInjected.Address(Slot = "28")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000074")]
	bool PHFFHNKCAKG
	{
		[Cpp2IlInjected.Token(Token = "0x60001AC")]
		[Cpp2IlInjected.Address(Slot = "29")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000075")]
	Vector3 CEAFBIINOKH
	{
		[Cpp2IlInjected.Token(Token = "0x60001AD")]
		[Cpp2IlInjected.Address(Slot = "30")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000076")]
	Vector3 NHENIPHGFOP
	{
		[Cpp2IlInjected.Token(Token = "0x60001AE")]
		[Cpp2IlInjected.Address(Slot = "31")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000077")]
	Vector3 CMPGKEOHLJC
	{
		[Cpp2IlInjected.Token(Token = "0x60001AF")]
		[Cpp2IlInjected.Address(Slot = "32")]
		get;
		[Cpp2IlInjected.Token(Token = "0x60001B0")]
		[Cpp2IlInjected.Address(Slot = "33")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000078")]
	Vector3 EIMEJLMMLMA
	{
		[Cpp2IlInjected.Token(Token = "0x60001B1")]
		[Cpp2IlInjected.Address(Slot = "34")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000079")]
	float EHLCHKMKGBK
	{
		[Cpp2IlInjected.Token(Token = "0x60001B2")]
		[Cpp2IlInjected.Address(Slot = "35")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700007A")]
	float BENEGDAHFLL
	{
		[Cpp2IlInjected.Token(Token = "0x60001B3")]
		[Cpp2IlInjected.Address(Slot = "36")]
		get;
		[Cpp2IlInjected.Token(Token = "0x60001B4")]
		[Cpp2IlInjected.Address(Slot = "37")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x1700007B")]
	Vector3 NGJFIKPFMML
	{
		[Cpp2IlInjected.Token(Token = "0x60001B5")]
		[Cpp2IlInjected.Address(Slot = "38")]
		get;
		[Cpp2IlInjected.Token(Token = "0x60001B6")]
		[Cpp2IlInjected.Address(Slot = "39")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x1700007C")]
	Quaternion LKICJOBKNGL
	{
		[Cpp2IlInjected.Token(Token = "0x60001B7")]
		[Cpp2IlInjected.Address(Slot = "40")]
		get;
		[Cpp2IlInjected.Token(Token = "0x60001B8")]
		[Cpp2IlInjected.Address(Slot = "41")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x1700007D")]
	float PIPAENOKBKE
	{
		[Cpp2IlInjected.Token(Token = "0x60001B9")]
		[Cpp2IlInjected.Address(Slot = "42")]
		get;
		[Cpp2IlInjected.Token(Token = "0x60001BA")]
		[Cpp2IlInjected.Address(Slot = "43")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x1700007E")]
	float HGOJLGHHICI
	{
		[Cpp2IlInjected.Token(Token = "0x60001BB")]
		[Cpp2IlInjected.Address(Slot = "44")]
		get;
		[Cpp2IlInjected.Token(Token = "0x60001BC")]
		[Cpp2IlInjected.Address(Slot = "45")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x1700007F")]
	bool NFPCLOGDCAI
	{
		[Cpp2IlInjected.Token(Token = "0x60001BD")]
		[Cpp2IlInjected.Address(Slot = "46")]
		get;
		[Cpp2IlInjected.Token(Token = "0x60001BE")]
		[Cpp2IlInjected.Address(Slot = "47")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000080")]
	HHLALPMEMBB AJFBHNJDDCE
	{
		[Cpp2IlInjected.Token(Token = "0x60001BF")]
		[Cpp2IlInjected.Address(Slot = "48")]
		get;
		[Cpp2IlInjected.Token(Token = "0x60001C0")]
		[Cpp2IlInjected.Address(Slot = "49")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000081")]
	bool KFFOOLFOADP
	{
		[Cpp2IlInjected.Token(Token = "0x60001C1")]
		[Cpp2IlInjected.Address(Slot = "50")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000082")]
	Transform ABGJKHNEALI
	{
		[Cpp2IlInjected.Token(Token = "0x60001C2")]
		[Cpp2IlInjected.Address(Slot = "51")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000083")]
	Transform LCAKADOIIEB
	{
		[Cpp2IlInjected.Token(Token = "0x60001C3")]
		[Cpp2IlInjected.Address(Slot = "52")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000084")]
	Vector3 ABELHODFPEO
	{
		[Cpp2IlInjected.Token(Token = "0x60001C4")]
		[Cpp2IlInjected.Address(Slot = "53")]
		get;
		[Cpp2IlInjected.Token(Token = "0x60001C5")]
		[Cpp2IlInjected.Address(Slot = "54")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000085")]
	float FDENPIIEFIG
	{
		[Cpp2IlInjected.Token(Token = "0x60001C6")]
		[Cpp2IlInjected.Address(Slot = "55")]
		get;
		[Cpp2IlInjected.Token(Token = "0x60001C7")]
		[Cpp2IlInjected.Address(Slot = "56")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000086")]
	float OMJLKOFJKHD
	{
		[Cpp2IlInjected.Token(Token = "0x60001C8")]
		[Cpp2IlInjected.Address(Slot = "57")]
		get;
		[Cpp2IlInjected.Token(Token = "0x60001C9")]
		[Cpp2IlInjected.Address(Slot = "58")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000087")]
	Quaternion MIDFMPBGHMA
	{
		[Cpp2IlInjected.Token(Token = "0x60001CA")]
		[Cpp2IlInjected.Address(Slot = "59")]
		get;
		[Cpp2IlInjected.Token(Token = "0x60001CB")]
		[Cpp2IlInjected.Address(Slot = "60")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000088")]
	Vector3 KIJJFLMPGME
	{
		[Cpp2IlInjected.Token(Token = "0x60001CC")]
		[Cpp2IlInjected.Address(Slot = "61")]
		get;
		[Cpp2IlInjected.Token(Token = "0x60001CD")]
		[Cpp2IlInjected.Address(Slot = "62")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000089")]
	Quaternion NELEDPLLGGE
	{
		[Cpp2IlInjected.Token(Token = "0x60001CE")]
		[Cpp2IlInjected.Address(Slot = "63")]
		get;
		[Cpp2IlInjected.Token(Token = "0x60001CF")]
		[Cpp2IlInjected.Address(Slot = "64")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x1700008A")]
	RigidbodyConstraints PILCFECIKIL
	{
		[Cpp2IlInjected.Token(Token = "0x60001D0")]
		[Cpp2IlInjected.Address(Slot = "65")]
		get;
		[Cpp2IlInjected.Token(Token = "0x60001D1")]
		[Cpp2IlInjected.Address(Slot = "66")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x1700008B")]
	bool ADJEMOAFAPK
	{
		[Cpp2IlInjected.Token(Token = "0x60001D2")]
		[Cpp2IlInjected.Address(Slot = "67")]
		get;
		[Cpp2IlInjected.Token(Token = "0x60001D3")]
		[Cpp2IlInjected.Address(Slot = "68")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x1700008C")]
	CollisionDetectionMode FEOBMNMPKBK
	{
		[Cpp2IlInjected.Token(Token = "0x60001D4")]
		[Cpp2IlInjected.Address(Slot = "69")]
		get;
		[Cpp2IlInjected.Token(Token = "0x60001D5")]
		[Cpp2IlInjected.Address(Slot = "70")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x1700008D")]
	bool GCHJHCHGGCH
	{
		[Cpp2IlInjected.Token(Token = "0x60001D6")]
		[Cpp2IlInjected.Address(Slot = "71")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x14000018")]
	event FGJCBPBEFOP PBANFIJELBE;

	[Cpp2IlInjected.Token(Token = "0x14000019")]
	event FGJCBPBEFOP MGANLNPCDNF;

	[Cpp2IlInjected.Token(Token = "0x1400001A")]
	event OHFGCHALJBC CLHKPMHNJGH;

	[Cpp2IlInjected.Token(Token = "0x1400001B")]
	event FGJCBPBEFOP EBDIBBFMNAG;

	[Cpp2IlInjected.Token(Token = "0x1400001C")]
	event FGJCBPBEFOP HLDPKPODLLN;

	[Cpp2IlInjected.Token(Token = "0x1400001D")]
	event FGJCBPBEFOP MLKAKEPMHOI;

	[Cpp2IlInjected.Token(Token = "0x1400001E")]
	event Action<AMBBOEBJPNH, AMBBOEBJPNH> FIKAFLHBAHL;

	[Cpp2IlInjected.Token(Token = "0x1400001F")]
	event FGJCBPBEFOP FGLCADMIKCE;

	[Cpp2IlInjected.Token(Token = "0x14000020")]
	event FGJCBPBEFOP MGBAEGFBPNJ;

	[Cpp2IlInjected.Token(Token = "0x60001D7")]
	[Cpp2IlInjected.Address(Slot = "72")]
	void JDBMEAOELGO();

	[Cpp2IlInjected.Token(Token = "0x60001D8")]
	[Cpp2IlInjected.Address(Slot = "73")]
	void LDBOEGKIPKO();

	[Cpp2IlInjected.Token(Token = "0x60001D9")]
	[Cpp2IlInjected.Address(Slot = "74")]
	void LJODMHLJPAD();

	[Cpp2IlInjected.Token(Token = "0x60001DA")]
	[Cpp2IlInjected.Address(Slot = "75")]
	void HILGCFFPCIP();

	[Cpp2IlInjected.Token(Token = "0x60001DB")]
	[Cpp2IlInjected.Address(Slot = "76")]
	void NLGFHJEKOON();

	[Cpp2IlInjected.Token(Token = "0x60001E2")]
	[Cpp2IlInjected.Address(Slot = "83")]
	void HMBNJDPGAJN(OINPHBHEBFM IPMIIEAGJKC, bool LDEEGDEKBLJ = false);

	[Cpp2IlInjected.Token(Token = "0x60001E5")]
	[Cpp2IlInjected.Address(Slot = "86")]
	void JPAMNHEGNMA(object IALNODEHBNN);

	[Cpp2IlInjected.Token(Token = "0x60001E6")]
	[Cpp2IlInjected.Address(Slot = "87")]
	void JECFPOIDGHE(object IALNODEHBNN);

	[Cpp2IlInjected.Token(Token = "0x60001E7")]
	[Cpp2IlInjected.Address(Slot = "88")]
	Vector3 JLCJMKPHEDJ(Vector3 LMLFDADCHBI);

	[Cpp2IlInjected.Token(Token = "0x60001E8")]
	[Cpp2IlInjected.Address(Slot = "89")]
	Vector3 HPOIKDMPEGF(Vector3 BPBFEPBHJOA);

	[Cpp2IlInjected.Token(Token = "0x60001E9")]
	[Cpp2IlInjected.Address(Slot = "90")]
	void OIHOBLKLMEH();

	[Cpp2IlInjected.Token(Token = "0x60001EA")]
	[Cpp2IlInjected.Address(Slot = "91")]
	void FFKNMCPIGAB();

	[Cpp2IlInjected.Token(Token = "0x60001EB")]
	[Cpp2IlInjected.Address(Slot = "92")]
	void BCEKGKJPMMM();

	[Cpp2IlInjected.Token(Token = "0x60001EC")]
	[Cpp2IlInjected.Address(Slot = "93")]
	void GLPKKFBJAKC(Vector3 PHMOADGIOAB, Vector3 FHAOAKNDIMF);

	[Cpp2IlInjected.Token(Token = "0x60001ED")]
	[Cpp2IlInjected.Address(Slot = "94")]
	void JGGAJCAAMOB(Vector3 LGOGCCAJHAG, Vector3 NMCANIJEPAA);

	[Cpp2IlInjected.Token(Token = "0x60001EE")]
	[Cpp2IlInjected.Address(Slot = "95")]
	void MKJDMMPONGJ(Vector3 PLAPBHBFKOO);

	[Cpp2IlInjected.Token(Token = "0x60001EF")]
	[Cpp2IlInjected.Address(Slot = "96")]
	void CNBEOMCPCEP(LJPGLADCBCM AKMNMFJGAOB, Vector3 GDBGENEPKJJ, float JCOIPNJNGNL, float JCNBFPLMFDC = 8f, float NCEHNBMCDCP = 1f);

	[Cpp2IlInjected.Token(Token = "0x60001F0")]
	[Cpp2IlInjected.Address(Slot = "97")]
	void HAMEOACBGEL(HKGKLOMPNFJ PLKHOFBGABO, Vector3 FLBMFCPCPEF, float OIOPGDDKGKH = float.PositiveInfinity);

	[Cpp2IlInjected.Token(Token = "0x60001F1")]
	[Cpp2IlInjected.Address(Slot = "98")]
	void HLLOHDECLDE(HKGKLOMPNFJ PLKHOFBGABO, Vector3 HEGBBJCMANH, float MJJDNDIGKOE = 7f, float KDGELBODBFF = 1f);

	[Cpp2IlInjected.Token(Token = "0x60001F2")]
	[Cpp2IlInjected.Address(Slot = "99")]
	Vector3 LKFCAEEDGGD(Vector3 IPMIIEAGJKC);

	[Cpp2IlInjected.Token(Token = "0x60001F3")]
	[Cpp2IlInjected.Address(Slot = "100")]
	Vector3 AIJJDEBMEOJ(Vector3 IPMIIEAGJKC);

	[Cpp2IlInjected.Token(Token = "0x60001F4")]
	[Cpp2IlInjected.Address(Slot = "101")]
	void IDHDDIPDPEN();

	[Cpp2IlInjected.Token(Token = "0x60001F5")]
	[Cpp2IlInjected.Address(Slot = "102")]
	void AILDDDNLPHO(OINPHBHEBFM LBILOIKCIOK, object IALNODEHBNN);

	[Cpp2IlInjected.Token(Token = "0x60001F6")]
	[Cpp2IlInjected.Address(Slot = "103")]
	void HELNOLDOAMO(object IALNODEHBNN);

	[Cpp2IlInjected.Token(Token = "0x60001F9")]
	[Cpp2IlInjected.Address(Slot = "106")]
	void LILDLMIHEAF();

	[Cpp2IlInjected.Token(Token = "0x60001FA")]
	[Cpp2IlInjected.Address(Slot = "107")]
	void OLIDEBFPCBJ();

	[Cpp2IlInjected.Token(Token = "0x60001FB")]
	[Cpp2IlInjected.Address(Slot = "108")]
	void KJCFGELAPLM();

	[Cpp2IlInjected.Token(Token = "0x60001FE")]
	[Cpp2IlInjected.Address(Slot = "111")]
	bool JIPELJMHGEE();

	[Cpp2IlInjected.Token(Token = "0x60001FF")]
	[Cpp2IlInjected.Address(Slot = "112")]
	void EMMDJJNLKHB();

	[Cpp2IlInjected.Token(Token = "0x6000204")]
	[Cpp2IlInjected.Address(Slot = "117")]
	IDisposable EEBIOLKMNJN();

	[Cpp2IlInjected.Token(Token = "0x6000205")]
	[Cpp2IlInjected.Address(Slot = "118")]
	void ANNHOHNEGBC(object IALNODEHBNN);

	[Cpp2IlInjected.Token(Token = "0x6000206")]
	[Cpp2IlInjected.Address(Slot = "119")]
	void DIACCKFBBFC(object IALNODEHBNN);

	[Cpp2IlInjected.Token(Token = "0x6000207")]
	[Cpp2IlInjected.Address(Slot = "120")]
	void IMCEFNKDLJE(object IALNODEHBNN, bool DKKAHPAOACL);

	[Cpp2IlInjected.Token(Token = "0x600020A")]
	[Cpp2IlInjected.Address(Slot = "123")]
	void IJJADLBMFDP(Vector3 GACEEHCHKKI, Quaternion EMJCGIGPJKI);

	[Cpp2IlInjected.Token(Token = "0x600020B")]
	[Cpp2IlInjected.Address(Slot = "124")]
	void ODKKDCFIJOF(Vector3 FJDPKNPNDDO, Quaternion CPOKLKIGKAG);

	[Cpp2IlInjected.Token(Token = "0x600020C")]
	[Cpp2IlInjected.Address(Slot = "125")]
	bool PCEMENCMDLB(float LJCAHLAFIEP);

	[Cpp2IlInjected.Token(Token = "0x600020D")]
	[Cpp2IlInjected.Address(Slot = "126")]
	void MHDBMJDNLON(object IALNODEHBNN);

	[Cpp2IlInjected.Token(Token = "0x600020E")]
	[Cpp2IlInjected.Address(Slot = "127")]
	void ICLJJAAMJBD(object IALNODEHBNN);

	[Cpp2IlInjected.Token(Token = "0x600020F")]
	[Cpp2IlInjected.Address(Slot = "128")]
	void IKBIHMLDNON(object IALNODEHBNN);

	[Cpp2IlInjected.Token(Token = "0x6000210")]
	[Cpp2IlInjected.Address(Slot = "129")]
	void AIKKIMKHEPL(object IALNODEHBNN);

	[Cpp2IlInjected.Token(Token = "0x6000211")]
	[Cpp2IlInjected.Address(Slot = "130")]
	void OPLMNHEAGKL(Vector3 COPOILGLIAJ, ForceMode OJOAKAEAKAC = ForceMode.Force);

	[Cpp2IlInjected.Token(Token = "0x6000212")]
	[Cpp2IlInjected.Address(Slot = "131")]
	void FLNNLAIJPLD(Vector3 COPOILGLIAJ, Vector3 INLGLHIPOMC, ForceMode OJOAKAEAKAC);

	[Cpp2IlInjected.Token(Token = "0x6000213")]
	[Cpp2IlInjected.Address(Slot = "132")]
	void FLJCPNJHDAE(Vector3 HMKLOLJGHPK, ForceMode OJOAKAEAKAC = ForceMode.Force);

	[Cpp2IlInjected.Token(Token = "0x6000214")]
	[Cpp2IlInjected.Address(Slot = "133")]
	void DLOBEAKDAFF(Vector3 HMKLOLJGHPK, ForceMode OJOAKAEAKAC = ForceMode.Force);

	[Cpp2IlInjected.Token(Token = "0x6000215")]
	[Cpp2IlInjected.Address(Slot = "134")]
	bool FHJIOGHMPNH(Vector3 HLFIBIDOLEF, out RaycastHit KNFIEECFHPI, float GKJHODLJDHD);

	[Cpp2IlInjected.Token(Token = "0x6000216")]
	[Cpp2IlInjected.Address(Slot = "135")]
	void AMMOJMDCBMC();

	[Cpp2IlInjected.Token(Token = "0x6000217")]
	[Cpp2IlInjected.Address(Slot = "136")]
	new string ToString();
}
[Cpp2IlInjected.Token(Token = "0x2000029")]
public class FFNHAGGANGK : OINPHBHEBFM, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000031")]
	internal readonly LNFAMCIHAGC ACDHNMANGFE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000032")]
	internal ACEBILIFEIP HKPONLMBIIB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000033")]
	internal POMIHBCAKMM HLFPKOMKNDJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000034")]
	internal HDMHGHFDNPO FBCDDJGNMEF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000035")]
	internal BNAKOLNKNGH OIEPDFJCEHE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000036")]
	internal OPBHABCMHHK FOAINIHBELG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000037")]
	internal KMFGIPGBMDB PMFPKDFALBN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000038")]
	internal CAMJCFKKLPP GOEPJCEHAPF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000039")]
	internal JIHFCAHMINI HNGHILFKNGE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x400003A")]
	internal GEILDFNHLPL GNLJKLNDOBK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x400003B")]
	internal NOIDPDKILCA NLKJJAKFOLE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x400003C")]
	internal KJLCKLHHAII KEBFOCNPJLL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x400003D")]
	internal EJPBMJKJDKA COPOILGLIAJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
	[Cpp2IlInjected.Token(Token = "0x400003E")]
	internal KJDGGMNDKPF FJLDFIKJGPJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x400003F")]
	internal COPEPEMIJFF NBJEPCGIGPN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
	[Cpp2IlInjected.Token(Token = "0x4000040")]
	internal CEEAALLPPCM BLHGHKLPLLB;

	[Cpp2IlInjected.Token(Token = "0x1700008E")]
	public RigidbodyEx LKJNPFKMFEJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000218")]
		[Cpp2IlInjected.Address(RVA = "0x82B680", Offset = "0x82A880", VA = "0x18082B680", Slot = "5")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000219")]
		[Cpp2IlInjected.Address(RVA = "0x82B690", Offset = "0x82A890", VA = "0x18082B690")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700008F")]
	public GameObject HCEKAIAAOOF
	{
		[Cpp2IlInjected.Token(Token = "0x600021A")]
		[Cpp2IlInjected.Address(RVA = "0x91EA50", Offset = "0x91DC50", VA = "0x18091EA50", Slot = "6")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600021B")]
		[Cpp2IlInjected.Address(RVA = "0x91E5B0", Offset = "0x91D7B0", VA = "0x18091E5B0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000090")]
	public Transform DHGHIDOLKGM
	{
		[Cpp2IlInjected.Token(Token = "0x600021C")]
		[Cpp2IlInjected.Address(RVA = "0x52AA5F0", Offset = "0x52A97F0", VA = "0x1852AA5F0", Slot = "7")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000091")]
	public IEnumerable<object> MBNCNEFIHAG
	{
		[Cpp2IlInjected.Token(Token = "0x600021D")]
		[Cpp2IlInjected.Address(RVA = "0x52AA680", Offset = "0x52A9880", VA = "0x1852AA680", Slot = "8")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000092")]
	public Rigidbody JMCCCFFEIIG
	{
		[Cpp2IlInjected.Token(Token = "0x600021E")]
		[Cpp2IlInjected.Address(RVA = "0x52AE350", Offset = "0x52AD550", VA = "0x1852AE350", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000093")]
	public OINPHBHEBFM HKAHNOCIENG
	{
		[Cpp2IlInjected.Token(Token = "0x600022C")]
		[Cpp2IlInjected.Address(RVA = "0x52A9270", Offset = "0x52A8470", VA = "0x1852A9270", Slot = "9")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600022D")]
		[Cpp2IlInjected.Address(RVA = "0x52AAD40", Offset = "0x52A9F40", VA = "0x1852AAD40", Slot = "10")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000094")]
	public IReadOnlyList<OINPHBHEBFM> NCLNEDAIDDA
	{
		[Cpp2IlInjected.Token(Token = "0x600022E")]
		[Cpp2IlInjected.Address(RVA = "0x52A9AE0", Offset = "0x52A8CE0", VA = "0x1852A9AE0", Slot = "11")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000095")]
	public OINPHBHEBFM CFHDLGEGDFD
	{
		[Cpp2IlInjected.Token(Token = "0x600022F")]
		[Cpp2IlInjected.Address(RVA = "0x52AE4B0", Offset = "0x52AD6B0", VA = "0x1852AE4B0", Slot = "12")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000096")]
	public bool LLNINBLBFFN
	{
		[Cpp2IlInjected.Token(Token = "0x6000230")]
		[Cpp2IlInjected.Address(RVA = "0x52AD3D0", Offset = "0x52AC5D0", VA = "0x1852AD3D0", Slot = "13")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000097")]
	public bool NKELDOMJEGL
	{
		[Cpp2IlInjected.Token(Token = "0x6000234")]
		[Cpp2IlInjected.Address(RVA = "0x52AD110", Offset = "0x52AC310", VA = "0x1852AD110", Slot = "14")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000098")]
	public bool DMMCOKOAOJI
	{
		[Cpp2IlInjected.Token(Token = "0x6000235")]
		[Cpp2IlInjected.Address(RVA = "0x52AB9E0", Offset = "0x52AABE0", VA = "0x1852AB9E0", Slot = "15")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000099")]
	public OEEBBDJIDDP PJJKMCINJBG
	{
		[Cpp2IlInjected.Token(Token = "0x6000236")]
		[Cpp2IlInjected.Address(RVA = "0x52A85C0", Offset = "0x52A77C0", VA = "0x1852A85C0", Slot = "16")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000237")]
		[Cpp2IlInjected.Address(RVA = "0x52AA720", Offset = "0x52A9920", VA = "0x1852AA720", Slot = "17")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700009A")]
	public JIKDBJBLNKK GLMECOENJFF
	{
		[Cpp2IlInjected.Token(Token = "0x6000238")]
		[Cpp2IlInjected.Address(RVA = "0x52A8570", Offset = "0x52A7770", VA = "0x1852A8570", Slot = "18")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000239")]
		[Cpp2IlInjected.Address(RVA = "0x52AA9A0", Offset = "0x52A9BA0", VA = "0x1852AA9A0", Slot = "19")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700009B")]
	public float LMKDGNICGIN
	{
		[Cpp2IlInjected.Token(Token = "0x600023A")]
		[Cpp2IlInjected.Address(RVA = "0x52A99B0", Offset = "0x52A8BB0", VA = "0x1852A99B0", Slot = "20")]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x600023B")]
		[Cpp2IlInjected.Address(RVA = "0x52A96F0", Offset = "0x52A88F0", VA = "0x1852A96F0", Slot = "21")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700009C")]
	public Vector3 PIHKAJHIGPH
	{
		[Cpp2IlInjected.Token(Token = "0x600023C")]
		[Cpp2IlInjected.Address(RVA = "0x52ACCD0", Offset = "0x52ABED0", VA = "0x1852ACCD0", Slot = "22")]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x600023D")]
		[Cpp2IlInjected.Address(RVA = "0x52AD040", Offset = "0x52AC240", VA = "0x1852AD040", Slot = "23")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700009D")]
	public Vector3 KAHCHGJGLPH
	{
		[Cpp2IlInjected.Token(Token = "0x600023E")]
		[Cpp2IlInjected.Address(RVA = "0x52AC510", Offset = "0x52AB710", VA = "0x1852AC510", Slot = "24")]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x600023F")]
		[Cpp2IlInjected.Address(RVA = "0x52A8B00", Offset = "0x52A7D00", VA = "0x1852A8B00", Slot = "25")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700009E")]
	public Vector3 BNMCMLCKBOK
	{
		[Cpp2IlInjected.Token(Token = "0x6000240")]
		[Cpp2IlInjected.Address(RVA = "0x52A9750", Offset = "0x52A8950", VA = "0x1852A9750", Slot = "26")]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x6000241")]
		[Cpp2IlInjected.Address(RVA = "0x52AD520", Offset = "0x52AC720", VA = "0x1852AD520", Slot = "27")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700009F")]
	public Vector3 IIALMKBBALJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000242")]
		[Cpp2IlInjected.Address(RVA = "0x52ABEA0", Offset = "0x52AB0A0", VA = "0x1852ABEA0", Slot = "28")]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x6000243")]
		[Cpp2IlInjected.Address(RVA = "0x52A9B30", Offset = "0x52A8D30", VA = "0x1852A9B30", Slot = "29")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A0")]
	public bool CDFPEFIDNLO
	{
		[Cpp2IlInjected.Token(Token = "0x6000244")]
		[Cpp2IlInjected.Address(RVA = "0x52AE0D0", Offset = "0x52AD2D0", VA = "0x1852AE0D0", Slot = "30")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A1")]
	public bool HGMNJFIAPOP
	{
		[Cpp2IlInjected.Token(Token = "0x6000245")]
		[Cpp2IlInjected.Address(RVA = "0x52AAEA0", Offset = "0x52AA0A0", VA = "0x1852AAEA0", Slot = "31")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A2")]
	public bool KEAFALNHKKC
	{
		[Cpp2IlInjected.Token(Token = "0x6000246")]
		[Cpp2IlInjected.Address(RVA = "0x52A88D0", Offset = "0x52A7AD0", VA = "0x1852A88D0", Slot = "32")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A3")]
	public bool PHFFHNKCAKG
	{
		[Cpp2IlInjected.Token(Token = "0x6000247")]
		[Cpp2IlInjected.Address(RVA = "0x52AE500", Offset = "0x52AD700", VA = "0x1852AE500", Slot = "33")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A4")]
	public Vector3 CEAFBIINOKH
	{
		[Cpp2IlInjected.Token(Token = "0x6000258")]
		[Cpp2IlInjected.Address(RVA = "0x52AAF60", Offset = "0x52AA160", VA = "0x1852AAF60", Slot = "34")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A5")]
	public Vector3 NHENIPHGFOP
	{
		[Cpp2IlInjected.Token(Token = "0x6000259")]
		[Cpp2IlInjected.Address(RVA = "0x52ADB30", Offset = "0x52ACD30", VA = "0x1852ADB30", Slot = "35")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A6")]
	public Vector3 CMPGKEOHLJC
	{
		[Cpp2IlInjected.Token(Token = "0x600025E")]
		[Cpp2IlInjected.Address(RVA = "0x52A8CE0", Offset = "0x52A7EE0", VA = "0x1852A8CE0", Slot = "36")]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x600025F")]
		[Cpp2IlInjected.Address(RVA = "0x52AA8D0", Offset = "0x52A9AD0", VA = "0x1852AA8D0", Slot = "37")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A7")]
	public Vector3 EIMEJLMMLMA
	{
		[Cpp2IlInjected.Token(Token = "0x6000260")]
		[Cpp2IlInjected.Address(RVA = "0x52A8DB0", Offset = "0x52A7FB0", VA = "0x1852A8DB0", Slot = "38")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A8")]
	public float EHLCHKMKGBK
	{
		[Cpp2IlInjected.Token(Token = "0x6000261")]
		[Cpp2IlInjected.Address(RVA = "0x52A9C00", Offset = "0x52A8E00", VA = "0x1852A9C00", Slot = "39")]
		get
		{
			return default(float);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A9")]
	public float BENEGDAHFLL
	{
		[Cpp2IlInjected.Token(Token = "0x6000262")]
		[Cpp2IlInjected.Address(RVA = "0x52AAC40", Offset = "0x52A9E40", VA = "0x1852AAC40", Slot = "40")]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x6000263")]
		[Cpp2IlInjected.Address(RVA = "0x52AA3F0", Offset = "0x52A95F0", VA = "0x1852AA3F0", Slot = "41")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000AA")]
	public Vector3 NGJFIKPFMML
	{
		[Cpp2IlInjected.Token(Token = "0x6000264")]
		[Cpp2IlInjected.Address(RVA = "0x52AD650", Offset = "0x52AC850", VA = "0x1852AD650", Slot = "42")]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x6000265")]
		[Cpp2IlInjected.Address(RVA = "0x52A9820", Offset = "0x52A8A20", VA = "0x1852A9820", Slot = "43")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000AB")]
	public Quaternion LKICJOBKNGL
	{
		[Cpp2IlInjected.Token(Token = "0x6000266")]
		[Cpp2IlInjected.Address(RVA = "0x52AC0C0", Offset = "0x52AB2C0", VA = "0x1852AC0C0", Slot = "44")]
		get
		{
			return default(Quaternion);
		}
		[Cpp2IlInjected.Token(Token = "0x6000267")]
		[Cpp2IlInjected.Address(RVA = "0x52AD7F0", Offset = "0x52AC9F0", VA = "0x1852AD7F0", Slot = "45")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000AC")]
	public float PIPAENOKBKE
	{
		[Cpp2IlInjected.Token(Token = "0x600026B")]
		[Cpp2IlInjected.Address(RVA = "0x52AA6D0", Offset = "0x52A98D0", VA = "0x1852AA6D0", Slot = "46")]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x600026C")]
		[Cpp2IlInjected.Address(RVA = "0x52AE450", Offset = "0x52AD650", VA = "0x1852AE450", Slot = "47")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000AD")]
	public float HGOJLGHHICI
	{
		[Cpp2IlInjected.Token(Token = "0x600026D")]
		[Cpp2IlInjected.Address(RVA = "0x52ABA30", Offset = "0x52AAC30", VA = "0x1852ABA30", Slot = "48")]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x600026E")]
		[Cpp2IlInjected.Address(RVA = "0x52A9450", Offset = "0x52A8650", VA = "0x1852A9450", Slot = "49")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000AE")]
	public bool NFPCLOGDCAI
	{
		[Cpp2IlInjected.Token(Token = "0x600026F")]
		[Cpp2IlInjected.Address(RVA = "0x52AC640", Offset = "0x52AB840", VA = "0x1852AC640", Slot = "50")]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000270")]
		[Cpp2IlInjected.Address(RVA = "0x52A9FC0", Offset = "0x52A91C0", VA = "0x1852A9FC0", Slot = "51")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000AF")]
	public HHLALPMEMBB AJFBHNJDDCE
	{
		[Cpp2IlInjected.Token(Token = "0x6000278")]
		[Cpp2IlInjected.Address(RVA = "0x52AD210", Offset = "0x52AC410", VA = "0x1852AD210", Slot = "52")]
		get
		{
			return default(HHLALPMEMBB);
		}
		[Cpp2IlInjected.Token(Token = "0x6000279")]
		[Cpp2IlInjected.Address(RVA = "0x52AD2B0", Offset = "0x52AC4B0", VA = "0x1852AD2B0", Slot = "53")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B0")]
	public bool KFFOOLFOADP
	{
		[Cpp2IlInjected.Token(Token = "0x600027C")]
		[Cpp2IlInjected.Address(RVA = "0x52AD8C0", Offset = "0x52ACAC0", VA = "0x1852AD8C0", Slot = "54")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B1")]
	public Transform ABGJKHNEALI
	{
		[Cpp2IlInjected.Token(Token = "0x6000283")]
		[Cpp2IlInjected.Address(RVA = "0x52A9320", Offset = "0x52A8520", VA = "0x1852A9320", Slot = "55")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B2")]
	public Transform LCAKADOIIEB
	{
		[Cpp2IlInjected.Token(Token = "0x6000284")]
		[Cpp2IlInjected.Address(RVA = "0x52A9320", Offset = "0x52A8520", VA = "0x1852A9320", Slot = "56")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B3")]
	public Vector3 ABELHODFPEO
	{
		[Cpp2IlInjected.Token(Token = "0x6000285")]
		[Cpp2IlInjected.Address(RVA = "0x52AE3A0", Offset = "0x52AD5A0", VA = "0x1852AE3A0", Slot = "57")]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x6000286")]
		[Cpp2IlInjected.Address(RVA = "0x52ACC20", Offset = "0x52ABE20", VA = "0x1852ACC20", Slot = "58")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B4")]
	public float FDENPIIEFIG
	{
		[Cpp2IlInjected.Token(Token = "0x6000287")]
		[Cpp2IlInjected.Address(RVA = "0x52AE170", Offset = "0x52AD370", VA = "0x1852AE170", Slot = "59")]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x6000288")]
		[Cpp2IlInjected.Address(RVA = "0x52AADA0", Offset = "0x52A9FA0", VA = "0x1852AADA0", Slot = "60")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B5")]
	public float OMJLKOFJKHD
	{
		[Cpp2IlInjected.Token(Token = "0x6000289")]
		[Cpp2IlInjected.Address(RVA = "0x52A92C0", Offset = "0x52A84C0", VA = "0x1852A92C0", Slot = "61")]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x600028A")]
		[Cpp2IlInjected.Address(RVA = "0x52AC740", Offset = "0x52AB940", VA = "0x1852AC740", Slot = "62")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B6")]
	public Quaternion MIDFMPBGHMA
	{
		[Cpp2IlInjected.Token(Token = "0x600028B")]
		[Cpp2IlInjected.Address(RVA = "0x52AC690", Offset = "0x52AB890", VA = "0x1852AC690", Slot = "63")]
		get
		{
			return default(Quaternion);
		}
		[Cpp2IlInjected.Token(Token = "0x600028C")]
		[Cpp2IlInjected.Address(RVA = "0x52A8A10", Offset = "0x52A7C10", VA = "0x1852A8A10", Slot = "64")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B7")]
	public Vector3 KIJJFLMPGME
	{
		[Cpp2IlInjected.Token(Token = "0x600028D")]
		[Cpp2IlInjected.Address(RVA = "0x52A8830", Offset = "0x52A7A30", VA = "0x1852A8830", Slot = "65")]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x600028E")]
		[Cpp2IlInjected.Address(RVA = "0x52AAA00", Offset = "0x52A9C00", VA = "0x1852AAA00", Slot = "66")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B8")]
	public Quaternion NELEDPLLGGE
	{
		[Cpp2IlInjected.Token(Token = "0x600028F")]
		[Cpp2IlInjected.Address(RVA = "0x52AA450", Offset = "0x52A9650", VA = "0x1852AA450", Slot = "67")]
		get
		{
			return default(Quaternion);
		}
		[Cpp2IlInjected.Token(Token = "0x6000290")]
		[Cpp2IlInjected.Address(RVA = "0x52AD390", Offset = "0x52AC590", VA = "0x1852AD390", Slot = "68")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B9")]
	public RigidbodyConstraints PILCFECIKIL
	{
		[Cpp2IlInjected.Token(Token = "0x6000294")]
		[Cpp2IlInjected.Address(RVA = "0x52ACE00", Offset = "0x52AC000", VA = "0x1852ACE00", Slot = "69")]
		get
		{
			return default(RigidbodyConstraints);
		}
		[Cpp2IlInjected.Token(Token = "0x6000295")]
		[Cpp2IlInjected.Address(RVA = "0x52A9C50", Offset = "0x52A8E50", VA = "0x1852A9C50", Slot = "70")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000BA")]
	public bool ADJEMOAFAPK
	{
		[Cpp2IlInjected.Token(Token = "0x6000296")]
		[Cpp2IlInjected.Address(RVA = "0x52AB990", Offset = "0x52AAB90", VA = "0x1852AB990", Slot = "71")]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000297")]
		[Cpp2IlInjected.Address(RVA = "0x52AE070", Offset = "0x52AD270", VA = "0x1852AE070", Slot = "72")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000BB")]
	public CollisionDetectionMode FEOBMNMPKBK
	{
		[Cpp2IlInjected.Token(Token = "0x60002A0")]
		[Cpp2IlInjected.Address(RVA = "0x52A9220", Offset = "0x52A8420", VA = "0x1852A9220", Slot = "73")]
		get
		{
			return default(CollisionDetectionMode);
		}
		[Cpp2IlInjected.Token(Token = "0x60002A1")]
		[Cpp2IlInjected.Address(RVA = "0x52A9EB0", Offset = "0x52A90B0", VA = "0x1852A9EB0", Slot = "74")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000BC")]
	public bool GCHJHCHGGCH
	{
		[Cpp2IlInjected.Token(Token = "0x60002A3")]
		[Cpp2IlInjected.Address(RVA = "0x52A94B0", Offset = "0x52A86B0", VA = "0x1852A94B0", Slot = "75")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000021")]
	public event FGJCBPBEFOP PBANFIJELBE
	{
		[Cpp2IlInjected.Token(Token = "0x6000226")]
		[Cpp2IlInjected.Address(RVA = "0x52AAF00", Offset = "0x52AA100", VA = "0x1852AAF00", Slot = "81")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000227")]
		[Cpp2IlInjected.Address(RVA = "0x52ACF80", Offset = "0x52AC180", VA = "0x1852ACF80", Slot = "82")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000022")]
	public event FGJCBPBEFOP MGANLNPCDNF
	{
		[Cpp2IlInjected.Token(Token = "0x6000228")]
		[Cpp2IlInjected.Address(RVA = "0x52A8BD0", Offset = "0x52A7DD0", VA = "0x1852A8BD0", Slot = "83")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000229")]
		[Cpp2IlInjected.Address(RVA = "0x52AC4B0", Offset = "0x52AB6B0", VA = "0x1852AC4B0", Slot = "84")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000023")]
	public event OHFGCHALJBC CLHKPMHNJGH
	{
		[Cpp2IlInjected.Token(Token = "0x600022A")]
		[Cpp2IlInjected.Address(RVA = "0x52AB560", Offset = "0x52AA760", VA = "0x1852AB560", Slot = "85")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600022B")]
		[Cpp2IlInjected.Address(RVA = "0x52ACFE0", Offset = "0x52AC1E0", VA = "0x1852ACFE0", Slot = "86")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000024")]
	public event FGJCBPBEFOP EBDIBBFMNAG
	{
		[Cpp2IlInjected.Token(Token = "0x6000232")]
		[Cpp2IlInjected.Address(RVA = "0x52A9950", Offset = "0x52A8B50", VA = "0x1852A9950", Slot = "88")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000233")]
		[Cpp2IlInjected.Address(RVA = "0x52AAA50", Offset = "0x52A9C50", VA = "0x1852AAA50", Slot = "89")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000025")]
	public event FGJCBPBEFOP HLDPKPODLLN
	{
		[Cpp2IlInjected.Token(Token = "0x600025C")]
		[Cpp2IlInjected.Address(RVA = "0x52A8AA0", Offset = "0x52A7CA0", VA = "0x1852A8AA0", Slot = "108")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600025D")]
		[Cpp2IlInjected.Address(RVA = "0x52A9F60", Offset = "0x52A9160", VA = "0x1852A9F60", Slot = "109")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000026")]
	public event FGJCBPBEFOP MLKAKEPMHOI
	{
		[Cpp2IlInjected.Token(Token = "0x6000271")]
		[Cpp2IlInjected.Address(RVA = "0x52AE250", Offset = "0x52AD450", VA = "0x1852AE250", Slot = "113")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000272")]
		[Cpp2IlInjected.Address(RVA = "0x52AB880", Offset = "0x52AAA80", VA = "0x1852AB880", Slot = "114")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000027")]
	public event Action<AMBBOEBJPNH, AMBBOEBJPNH> FIKAFLHBAHL
	{
		[Cpp2IlInjected.Token(Token = "0x6000276")]
		[Cpp2IlInjected.Address(RVA = "0x52A8C80", Offset = "0x52A7E80", VA = "0x1852A8C80", Slot = "117")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000277")]
		[Cpp2IlInjected.Address(RVA = "0x52ACDA0", Offset = "0x52ABFA0", VA = "0x1852ACDA0", Slot = "118")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000028")]
	public event FGJCBPBEFOP FGLCADMIKCE
	{
		[Cpp2IlInjected.Token(Token = "0x600027A")]
		[Cpp2IlInjected.Address(RVA = "0x52A9A00", Offset = "0x52A8C00", VA = "0x1852A9A00", Slot = "119")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600027B")]
		[Cpp2IlInjected.Address(RVA = "0x52AC5E0", Offset = "0x52AB7E0", VA = "0x1852AC5E0", Slot = "120")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000029")]
	public event FGJCBPBEFOP MGBAEGFBPNJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000281")]
		[Cpp2IlInjected.Address(RVA = "0x52AA020", Offset = "0x52A9220", VA = "0x1852AA020", Slot = "125")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000282")]
		[Cpp2IlInjected.Address(RVA = "0x52AC3B0", Offset = "0x52AB5B0", VA = "0x1852AC3B0", Slot = "126")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600021F")]
	[Cpp2IlInjected.Address(RVA = "0x52AE590", Offset = "0x52AD790", VA = "0x1852AE590")]
	public FFNHAGGANGK(GameObject BMNLOPDIJGF, RigidbodyEx NJFHMJJGBJJ, LNFAMCIHAGC ACDHNMANGFE, in IPGEEHAGLOI PCPEJHIMHJJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000220")]
	[Cpp2IlInjected.Address(RVA = "0x52AC940", Offset = "0x52ABB40", VA = "0x1852AC940", Slot = "142")]
	protected virtual void KJODCDCKGLH(LNFAMCIHAGC ACDHNMANGFE, IPGEEHAGLOI PCPEJHIMHJJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000221")]
	[Cpp2IlInjected.Address(RVA = "0x52A9CB0", Offset = "0x52A8EB0", VA = "0x1852A9CB0", Slot = "143")]
	public virtual void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000222")]
	[Cpp2IlInjected.Address(RVA = "0x52ABD60", Offset = "0x52AAF60", VA = "0x1852ABD60", Slot = "76")]
	public void JDBMEAOELGO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000223")]
	[Cpp2IlInjected.Address(RVA = "0x52ACF30", Offset = "0x52AC130", VA = "0x1852ACF30", Slot = "77")]
	public void LDBOEGKIPKO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000224")]
	[Cpp2IlInjected.Address(RVA = "0x52AD370", Offset = "0x52AC570", VA = "0x1852AD370", Slot = "78")]
	public void LJODMHLJPAD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000225")]
	[Cpp2IlInjected.Address(RVA = "0x52ADA80", Offset = "0x52ACC80", VA = "0x1852ADA80", Slot = "144")]
	public virtual void NLGFHJEKOON()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000231")]
	[Cpp2IlInjected.Address(RVA = "0x52AB720", Offset = "0x52AA920", VA = "0x1852AB720", Slot = "87")]
	public void HMBNJDPGAJN(OINPHBHEBFM IPMIIEAGJKC, bool LDEEGDEKBLJ = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000248")]
	[Cpp2IlInjected.Address(RVA = "0x52AC450", Offset = "0x52AB650", VA = "0x1852AC450", Slot = "90")]
	public void JPAMNHEGNMA(object IALNODEHBNN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000249")]
	[Cpp2IlInjected.Address(RVA = "0x52ABF70", Offset = "0x52AB170", VA = "0x1852ABF70", Slot = "91")]
	public void JECFPOIDGHE(object IALNODEHBNN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600024A")]
	[Cpp2IlInjected.Address(RVA = "0x52AC1E0", Offset = "0x52AB3E0", VA = "0x1852AC1E0", Slot = "92")]
	public Vector3 JLCJMKPHEDJ(Vector3 LMLFDADCHBI)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x600024B")]
	[Cpp2IlInjected.Address(RVA = "0x52AB790", Offset = "0x52AA990", VA = "0x1852AB790", Slot = "93")]
	public Vector3 HPOIKDMPEGF(Vector3 BPBFEPBHJOA)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x600024C")]
	[Cpp2IlInjected.Address(RVA = "0x52ACF30", Offset = "0x52AC130", VA = "0x1852ACF30", Slot = "94")]
	public void OIHOBLKLMEH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600024D")]
	[Cpp2IlInjected.Address(RVA = "0x52AA780", Offset = "0x52A9980", VA = "0x1852AA780", Slot = "95")]
	public void FFKNMCPIGAB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600024E")]
	[Cpp2IlInjected.Address(RVA = "0x52A8C30", Offset = "0x52A7E30", VA = "0x1852A8C30", Slot = "96")]
	public void BCEKGKJPMMM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600024F")]
	[Cpp2IlInjected.Address(RVA = "0x52AB030", Offset = "0x52AA230", VA = "0x1852AB030", Slot = "97")]
	public void GLPKKFBJAKC(Vector3 PHMOADGIOAB, Vector3 FHAOAKNDIMF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000250")]
	[Cpp2IlInjected.Address(RVA = "0x52ABFD0", Offset = "0x52AB1D0", VA = "0x1852ABFD0", Slot = "98")]
	public void JGGAJCAAMOB(Vector3 LGOGCCAJHAG, Vector3 NMCANIJEPAA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000251")]
	[Cpp2IlInjected.Address(RVA = "0x52AD720", Offset = "0x52AC920", VA = "0x1852AD720", Slot = "99")]
	public void MKJDMMPONGJ(Vector3 PLAPBHBFKOO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000252")]
	[Cpp2IlInjected.Address(RVA = "0x52A9330", Offset = "0x52A8530", VA = "0x1852A9330", Slot = "100")]
	public void CNBEOMCPCEP(LJPGLADCBCM AKMNMFJGAOB, Vector3 GDBGENEPKJJ, float JCOIPNJNGNL, float JCNBFPLMFDC = 8f, float NCEHNBMCDCP = 1f)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000253")]
	[Cpp2IlInjected.Address(RVA = "0x52AB400", Offset = "0x52AA600", VA = "0x1852AB400", Slot = "101")]
	public void HAMEOACBGEL(HKGKLOMPNFJ PLKHOFBGABO, Vector3 FLBMFCPCPEF, float OIOPGDDKGKH = float.PositiveInfinity)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000254")]
	[Cpp2IlInjected.Address(RVA = "0x52AB610", Offset = "0x52AA810", VA = "0x1852AB610", Slot = "102")]
	[Obsolete]
	public void HLLOHDECLDE(HKGKLOMPNFJ PLKHOFBGABO, Vector3 HEGBBJCMANH, float MJJDNDIGKOE = 7f, float KDGELBODBFF = 1f)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000255")]
	[Cpp2IlInjected.Address(RVA = "0x52AD430", Offset = "0x52AC630", VA = "0x1852AD430", Slot = "103")]
	public Vector3 LKFCAEEDGGD(Vector3 IPMIIEAGJKC)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000256")]
	[Cpp2IlInjected.Address(RVA = "0x52A8610", Offset = "0x52A7810", VA = "0x1852A8610", Slot = "104")]
	public Vector3 AIJJDEBMEOJ(Vector3 IPMIIEAGJKC)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000257")]
	[Cpp2IlInjected.Address(RVA = "0x52AB940", Offset = "0x52AAB40", VA = "0x1852AB940", Slot = "105")]
	public void IDHDDIPDPEN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600025A")]
	[Cpp2IlInjected.Address(RVA = "0x52A8760", Offset = "0x52A7960", VA = "0x1852A8760", Slot = "106")]
	public void AILDDDNLPHO(OINPHBHEBFM LBILOIKCIOK, object IALNODEHBNN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600025B")]
	[Cpp2IlInjected.Address(RVA = "0x52AB500", Offset = "0x52AA700", VA = "0x1852AB500", Slot = "107")]
	public void HELNOLDOAMO(object IALNODEHBNN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000268")]
	[Cpp2IlInjected.Address(RVA = "0x52AD260", Offset = "0x52AC460", VA = "0x1852AD260", Slot = "110")]
	public void LILDLMIHEAF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000269")]
	[Cpp2IlInjected.Address(RVA = "0x52AE120", Offset = "0x52AD320", VA = "0x1852AE120", Slot = "111")]
	public void OLIDEBFPCBJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600026A")]
	[Cpp2IlInjected.Address(RVA = "0x52AC8F0", Offset = "0x52ABAF0", VA = "0x1852AC8F0", Slot = "112")]
	public void KJCFGELAPLM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000273")]
	[Cpp2IlInjected.Address(RVA = "0x52AC190", Offset = "0x52AB390", VA = "0x1852AC190", Slot = "115")]
	public bool JIPELJMHGEE()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000274")]
	[Cpp2IlInjected.Address(RVA = "0x52AB5C0", Offset = "0x52AA7C0", VA = "0x1852AB5C0", Slot = "79")]
	public void HILGCFFPCIP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000275")]
	[Cpp2IlInjected.Address(RVA = "0x52AA5A0", Offset = "0x52A97A0", VA = "0x1852AA5A0", Slot = "116")]
	public void EMMDJJNLKHB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600027D")]
	[Cpp2IlInjected.Address(RVA = "0x52A9F10", Offset = "0x52A9110", VA = "0x1852A9F10", Slot = "121")]
	public IDisposable EEBIOLKMNJN()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600027E")]
	[Cpp2IlInjected.Address(RVA = "0x52A89B0", Offset = "0x52A7BB0", VA = "0x1852A89B0", Slot = "122")]
	public void ANNHOHNEGBC(object IALNODEHBNN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600027F")]
	[Cpp2IlInjected.Address(RVA = "0x52A98F0", Offset = "0x52A8AF0", VA = "0x1852A98F0", Slot = "123")]
	public void DIACCKFBBFC(object IALNODEHBNN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000280")]
	[Cpp2IlInjected.Address(RVA = "0x52ABCF0", Offset = "0x52AAEF0", VA = "0x1852ABCF0", Slot = "124")]
	public void IMCEFNKDLJE(object IALNODEHBNN, bool DKKAHPAOACL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000291")]
	[Cpp2IlInjected.Address(RVA = "0x52ABA80", Offset = "0x52AAC80", VA = "0x1852ABA80", Slot = "127")]
	public void IJJADLBMFDP(Vector3 GACEEHCHKKI, Quaternion EMJCGIGPJKI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000292")]
	[Cpp2IlInjected.Address(RVA = "0x52ADC00", Offset = "0x52ACE00", VA = "0x1852ADC00", Slot = "128")]
	public void ODKKDCFIJOF(Vector3 FJDPKNPNDDO, Quaternion CPOKLKIGKAG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000293")]
	[Cpp2IlInjected.Address(RVA = "0x52AE2B0", Offset = "0x52AD4B0", VA = "0x1852AE2B0", Slot = "129")]
	public bool PCEMENCMDLB(float LJCAHLAFIEP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000298")]
	[Cpp2IlInjected.Address(RVA = "0x52AD5F0", Offset = "0x52AC7F0", VA = "0x1852AD5F0", Slot = "130")]
	public void MHDBMJDNLON(object IALNODEHBNN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000299")]
	[Cpp2IlInjected.Address(RVA = "0x52AB8E0", Offset = "0x52AAAE0", VA = "0x1852AB8E0", Slot = "131")]
	public void ICLJJAAMJBD(object IALNODEHBNN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600029A")]
	[Cpp2IlInjected.Address(RVA = "0x52ABC90", Offset = "0x52AAE90", VA = "0x1852ABC90", Slot = "132")]
	public void IKBIHMLDNON(object IALNODEHBNN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600029B")]
	[Cpp2IlInjected.Address(RVA = "0x52A8700", Offset = "0x52A7900", VA = "0x1852A8700", Slot = "133")]
	public void AIKKIMKHEPL(object IALNODEHBNN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600029C")]
	[Cpp2IlInjected.Address(RVA = "0x52AE1D0", Offset = "0x52AD3D0", VA = "0x1852AE1D0", Slot = "134")]
	public void OPLMNHEAGKL(Vector3 COPOILGLIAJ, ForceMode OJOAKAEAKAC = ForceMode.Force)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600029D")]
	[Cpp2IlInjected.Address(RVA = "0x52AAB30", Offset = "0x52A9D30", VA = "0x1852AAB30", Slot = "135")]
	public void FLNNLAIJPLD(Vector3 COPOILGLIAJ, Vector3 INLGLHIPOMC, ForceMode OJOAKAEAKAC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600029E")]
	[Cpp2IlInjected.Address(RVA = "0x52AAAB0", Offset = "0x52A9CB0", VA = "0x1852AAAB0", Slot = "136")]
	public void FLJCPNJHDAE(Vector3 HMKLOLJGHPK, ForceMode OJOAKAEAKAC = ForceMode.Force)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600029F")]
	[Cpp2IlInjected.Address(RVA = "0x52A9A60", Offset = "0x52A8C60", VA = "0x1852A9A60", Slot = "137")]
	public void DLOBEAKDAFF(Vector3 HMKLOLJGHPK, ForceMode OJOAKAEAKAC = ForceMode.Force)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002A2")]
	[Cpp2IlInjected.Address(RVA = "0x52AA7D0", Offset = "0x52A99D0", VA = "0x1852AA7D0", Slot = "138")]
	public bool FHJIOGHMPNH(Vector3 HLFIBIDOLEF, out RaycastHit KNFIEECFHPI, float GKJHODLJDHD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002A4")]
	[Cpp2IlInjected.Address(RVA = "0x52A8880", Offset = "0x52A7A80", VA = "0x1852A8880", Slot = "139")]
	public void AMMOJMDCBMC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002A5")]
	[Cpp2IlInjected.Address(RVA = "0x52AE550", Offset = "0x52AD750", VA = "0x1852AE550", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002A6")]
	[Cpp2IlInjected.Address(RVA = "0x52ADDB0", Offset = "0x52ACFB0", VA = "0x1852ADDB0")]
	private void OGEHIDPDHJD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002A7")]
	[Cpp2IlInjected.Address(RVA = "0x52AA490", Offset = "0x52A9690", VA = "0x1852AA490")]
	private void ELLDNOEPCPD(OINPHBHEBFM HHFDFFDPCGO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002A8")]
	[Cpp2IlInjected.Address(RVA = "0x52ADE80", Offset = "0x52AD080", VA = "0x1852ADE80")]
	private void OKDKOEFKNFG(OINPHBHEBFM HHFDFFDPCGO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002A9")]
	[Cpp2IlInjected.Address(RVA = "0x52AAC90", Offset = "0x52A9E90", VA = "0x1852AAC90")]
	private void GBMMEHCCPJF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002AA")]
	[Cpp2IlInjected.Address(RVA = "0x52A95F0", Offset = "0x52A87F0", VA = "0x1852A95F0")]
	private void COPDKDAHBHC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002AB")]
	[Cpp2IlInjected.Address(RVA = "0x52AD160", Offset = "0x52AC360", VA = "0x1852AD160")]
	private void LHIDILOCCJI(OINPHBHEBFM DLHNFCJIJJD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002AC")]
	[Cpp2IlInjected.Address(RVA = "0x52AC2D0", Offset = "0x52AB4D0", VA = "0x1852AC2D0")]
	private void JLNECFHPDHL(OINPHBHEBFM HHFDFFDPCGO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002AD")]
	[Cpp2IlInjected.Address(RVA = "0x52ACE50", Offset = "0x52AC050", VA = "0x1852ACE50")]
	private void LAJHBEDDHLL(OINPHBHEBFM HHFDFFDPCGO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002AE")]
	[Cpp2IlInjected.Address(RVA = "0x52AD910", Offset = "0x52ACB10", VA = "0x1852AD910")]
	private void NJPBADJMPLJ(RigidbodyEx HHFDFFDPCGO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002AF")]
	[Cpp2IlInjected.Address(RVA = "0x52A8E80", Offset = "0x52A8080", VA = "0x1852A8E80")]
	private void BLAGANBLLGC(RigidbodyEx EHHPLBPDKBE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002B0")]
	[Cpp2IlInjected.Address(RVA = "0x52A9D80", Offset = "0x52A8F80", VA = "0x1852A9D80")]
	[Conditional("UNITY_EDITOR")]
	private void ECMOKKCHALP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002B1")]
	[Cpp2IlInjected.Address(RVA = "0x52AB120", Offset = "0x52AA320", VA = "0x1852AB120")]
	protected void GMAPINHCACM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002B2")]
	[Cpp2IlInjected.Address(RVA = "0x52AA0C0", Offset = "0x52A92C0", VA = "0x1852AA0C0")]
	protected void EHOCBEKJBPJ()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002A")]
internal static class PNMPNACFAOA
{
	[Cpp2IlInjected.Token(Token = "0x60002B3")]
	[Cpp2IlInjected.Address(RVA = "0x52CAE70", Offset = "0x52CA070", VA = "0x1852CAE70")]
	public static OINPHBHEBFM NAPKGIEFEGE(this OINPHBHEBFM EHHPLBPDKBE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002B4")]
	[Cpp2IlInjected.Address(RVA = "0x52CACB0", Offset = "0x52C9EB0", VA = "0x1852CACB0")]
	public static bool JFKLBGBFCMD(this OINPHBHEBFM EHHPLBPDKBE, OINPHBHEBFM JFIPBDILNIA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002B5")]
	[Cpp2IlInjected.Address(RVA = "0x52CADA0", Offset = "0x52C9FA0", VA = "0x1852CADA0")]
	public static bool LJFCGLCHKKG(this OINPHBHEBFM EHHPLBPDKBE, OINPHBHEBFM LNLMJNMBENE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002B6")]
	[Cpp2IlInjected.Address(RVA = "0x52CAE20", Offset = "0x52CA020", VA = "0x1852CAE20")]
	public static RigidbodyEx LKJNPFKMFEJ(this OINPHBHEBFM DLGMOOCFLIK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002B7")]
	[Cpp2IlInjected.Address(RVA = "0x52CAD30", Offset = "0x52C9F30", VA = "0x1852CAD30")]
	public static FFNHAGGANGK JGNKCAOMOPE(this OINPHBHEBFM IDCNELICAAG)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200002B")]
internal class LGHMMDNMHBD : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000044")]
	private readonly FFNHAGGANGK EHHPLBPDKBE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000045")]
	private bool KBDIBPJIHNN;

	[Cpp2IlInjected.Token(Token = "0x60002B8")]
	[Cpp2IlInjected.Address(RVA = "0x52BF6E0", Offset = "0x52BE8E0", VA = "0x1852BF6E0")]
	public LGHMMDNMHBD(FFNHAGGANGK GOJCEBCMFJK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002B9")]
	[Cpp2IlInjected.Address(RVA = "0x52BF680", Offset = "0x52BE880", VA = "0x1852BF680", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002C")]
internal sealed class ACEHBIJCEDH : KGGBOPCKBMM, CEEAALLPPCM
{
	[Cpp2IlInjected.Token(Token = "0x170000BD")]
	private CollisionDetectionMode EDKFCKAJPPD
	{
		[Cpp2IlInjected.Token(Token = "0x60002BB")]
		[Cpp2IlInjected.Address(RVA = "0x52A2230", Offset = "0x52A1430", VA = "0x1852A2230")]
		get
		{
			return default(CollisionDetectionMode);
		}
		[Cpp2IlInjected.Token(Token = "0x60002BC")]
		[Cpp2IlInjected.Address(RVA = "0x52A2630", Offset = "0x52A1830", VA = "0x1852A2630")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000BE")]
	private Rigidbody JMCCCFFEIIG
	{
		[Cpp2IlInjected.Token(Token = "0x60002BD")]
		[Cpp2IlInjected.Address(RVA = "0x52A2720", Offset = "0x52A1920", VA = "0x1852A2720")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000BF")]
	public CollisionDetectionMode FEOBMNMPKBK
	{
		[Cpp2IlInjected.Token(Token = "0x60002C0")]
		[Cpp2IlInjected.Address(RVA = "0x52A1E90", Offset = "0x52A1090", VA = "0x1852A1E90", Slot = "4")]
		get
		{
			return default(CollisionDetectionMode);
		}
		[Cpp2IlInjected.Token(Token = "0x60002C1")]
		[Cpp2IlInjected.Address(RVA = "0x52A21A0", Offset = "0x52A13A0", VA = "0x1852A21A0", Slot = "5")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60002BA")]
	[Cpp2IlInjected.Address(RVA = "0x52A2770", Offset = "0x52A1970", VA = "0x1852A2770")]
	public ACEHBIJCEDH(OINPHBHEBFM EHHPLBPDKBE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002BE")]
	[Cpp2IlInjected.Address(RVA = "0x52A2480", Offset = "0x52A1680", VA = "0x1852A2480", Slot = "6")]
	public void JDBMEAOELGO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002BF")]
	[Cpp2IlInjected.Address(RVA = "0x52A25A0", Offset = "0x52A17A0", VA = "0x1852A25A0", Slot = "9")]
	public void NJINOCNPPGC(Rigidbody NBJEPCGIGPN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002C2")]
	[Cpp2IlInjected.Address(RVA = "0x52A2220", Offset = "0x52A1420", VA = "0x1852A2220", Slot = "7")]
	public void FBBHPGOJJEA(bool AALOAMDFFGP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002C3")]
	[Cpp2IlInjected.Address(RVA = "0x52A2590", Offset = "0x52A1790", VA = "0x1852A2590", Slot = "8")]
	public void LBLCJPGOPBO(bool AALOAMDFFGP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002C4")]
	[Cpp2IlInjected.Address(RVA = "0x52A2310", Offset = "0x52A1510", VA = "0x1852A2310", Slot = "10")]
	public bool FHJIOGHMPNH(Vector3 HLFIBIDOLEF, out RaycastHit KNFIEECFHPI, float GKJHODLJDHD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002C5")]
	[Cpp2IlInjected.Address(RVA = "0x52A1FA0", Offset = "0x52A11A0", VA = "0x1852A1FA0")]
	private void DCAPPBIJNHD(bool AALOAMDFFGP)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002D")]
internal sealed class NKFJHPHMBHA : KGGBOPCKBMM, NOIDPDKILCA, IDisposable, DFBGLPCFOHL
{
	[Cpp2IlInjected.Token(Token = "0x170000C0")]
	public HHLALPMEMBB JOFBBAHBNBK
	{
		[Cpp2IlInjected.Token(Token = "0x60002C9")]
		[Cpp2IlInjected.Address(RVA = "0x52C5C10", Offset = "0x52C4E10", VA = "0x1852C5C10")]
		get
		{
			return default(HHLALPMEMBB);
		}
		[Cpp2IlInjected.Token(Token = "0x60002CA")]
		[Cpp2IlInjected.Address(RVA = "0x52C5FB0", Offset = "0x52C51B0", VA = "0x1852C5FB0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000C1")]
	public HHLALPMEMBB AJFBHNJDDCE
	{
		[Cpp2IlInjected.Token(Token = "0x60002CB")]
		[Cpp2IlInjected.Address(RVA = "0x52C5D90", Offset = "0x52C4F90", VA = "0x1852C5D90", Slot = "6")]
		get
		{
			return default(HHLALPMEMBB);
		}
		[Cpp2IlInjected.Token(Token = "0x60002CC")]
		[Cpp2IlInjected.Address(RVA = "0x52C5FB0", Offset = "0x52C51B0", VA = "0x1852C5FB0", Slot = "7")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000C2")]
	private Transform NFMNHNCFMEK
	{
		[Cpp2IlInjected.Token(Token = "0x60002D1")]
		[Cpp2IlInjected.Address(RVA = "0x6F8490", Offset = "0x6F7690", VA = "0x1806F8490", Slot = "10")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400002A")]
	public event Action<AMBBOEBJPNH, AMBBOEBJPNH> FIKAFLHBAHL
	{
		[Cpp2IlInjected.Token(Token = "0x60002C7")]
		[Cpp2IlInjected.Address(RVA = "0x52C5B70", Offset = "0x52C4D70", VA = "0x1852C5B70", Slot = "4")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60002C8")]
		[Cpp2IlInjected.Address(RVA = "0x52C5CF0", Offset = "0x52C4EF0", VA = "0x1852C5CF0", Slot = "5")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60002C6")]
	[Cpp2IlInjected.Address(RVA = "0x52A2770", Offset = "0x52A1970", VA = "0x1852A2770")]
	public NKFJHPHMBHA(OINPHBHEBFM EHHPLBPDKBE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002CD")]
	[Cpp2IlInjected.Address(RVA = "0x52C60A0", Offset = "0x52C52A0", VA = "0x1852C60A0", Slot = "11")]
	public void OnChangedDistanceBand(AMBBOEBJPNH HKPEMIJGIMD, AMBBOEBJPNH INPBMNIIHJJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002CE")]
	[Cpp2IlInjected.Address(RVA = "0x6F84D0", Offset = "0x6F76D0", VA = "0x1806F84D0", Slot = "12")]
	public void OnChangedVisibility(bool GMEKKCPLMOB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002CF")]
	[Cpp2IlInjected.Address(RVA = "0x6F84D0", Offset = "0x6F76D0", VA = "0x1806F84D0", Slot = "8")]
	public void JDBMEAOELGO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002D0")]
	[Cpp2IlInjected.Address(RVA = "0x6F84D0", Offset = "0x6F76D0", VA = "0x1806F84D0", Slot = "9")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002E")]
internal sealed class PALIEMLJCAE : KGGBOPCKBMM, EJPBMJKJDKA
{
	[Cpp2IlInjected.Token(Token = "0x170000C3")]
	private Rigidbody JMCCCFFEIIG
	{
		[Cpp2IlInjected.Token(Token = "0x60002D3")]
		[Cpp2IlInjected.Address(RVA = "0x52A2720", Offset = "0x52A1920", VA = "0x1852A2720")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000C4")]
	private bool KFFOOLFOADP
	{
		[Cpp2IlInjected.Token(Token = "0x60002D4")]
		[Cpp2IlInjected.Address(RVA = "0x52B0370", Offset = "0x52AF570", VA = "0x1852B0370")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000C5")]
	private bool LLNINBLBFFN
	{
		[Cpp2IlInjected.Token(Token = "0x60002D5")]
		[Cpp2IlInjected.Address(RVA = "0x52B0310", Offset = "0x52AF510", VA = "0x1852B0310")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000C6")]
	private OINPHBHEBFM HKAHNOCIENG
	{
		[Cpp2IlInjected.Token(Token = "0x60002D6")]
		[Cpp2IlInjected.Address(RVA = "0x52CA1F0", Offset = "0x52C93F0", VA = "0x1852CA1F0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60002D2")]
	[Cpp2IlInjected.Address(RVA = "0x52A2770", Offset = "0x52A1970", VA = "0x1852A2770")]
	public PALIEMLJCAE(OINPHBHEBFM EHHPLBPDKBE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002D7")]
	[Cpp2IlInjected.Address(RVA = "0x52CAB50", Offset = "0x52C9D50", VA = "0x1852CAB50", Slot = "4")]
	public void OPLMNHEAGKL(Vector3 COPOILGLIAJ, ForceMode OJOAKAEAKAC = ForceMode.Force)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002D8")]
	[Cpp2IlInjected.Address(RVA = "0x52CA250", Offset = "0x52C9450", VA = "0x1852CA250")]
	private void CLODOAOGOKG(Vector3 COPOILGLIAJ, ForceMode OJOAKAEAKAC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002D9")]
	[Cpp2IlInjected.Address(RVA = "0x52CA8B0", Offset = "0x52C9AB0", VA = "0x1852CA8B0", Slot = "5")]
	public void FLNNLAIJPLD(Vector3 COPOILGLIAJ, Vector3 INLGLHIPOMC, ForceMode OJOAKAEAKAC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002DA")]
	[Cpp2IlInjected.Address(RVA = "0x52CA750", Offset = "0x52C9950", VA = "0x1852CA750", Slot = "6")]
	public void FLJCPNJHDAE(Vector3 HMKLOLJGHPK, ForceMode OJOAKAEAKAC = ForceMode.Force)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002DB")]
	[Cpp2IlInjected.Address(RVA = "0x52C9F70", Offset = "0x52C9170", VA = "0x1852C9F70")]
	private void AKDNGGALPNM(Vector3 HMKLOLJGHPK, ForceMode OJOAKAEAKAC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002DC")]
	[Cpp2IlInjected.Address(RVA = "0x52CA4D0", Offset = "0x52C96D0", VA = "0x1852CA4D0", Slot = "7")]
	public void DLOBEAKDAFF(Vector3 HMKLOLJGHPK, ForceMode OJOAKAEAKAC = ForceMode.Force)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002F")]
internal sealed class COBJIBKKAMJ : KGGBOPCKBMM, JIHFCAHMINI
{
	[Cpp2IlInjected.Token(Token = "0x170000C7")]
	public bool NFPCLOGDCAI
	{
		[Cpp2IlInjected.Token(Token = "0x60002DE")]
		[Cpp2IlInjected.Address(RVA = "0x52A60D0", Offset = "0x52A52D0", VA = "0x1852A60D0", Slot = "4")]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x60002DF")]
		[Cpp2IlInjected.Address(RVA = "0x52A5EF0", Offset = "0x52A50F0", VA = "0x1852A5EF0", Slot = "5")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60002DD")]
	[Cpp2IlInjected.Address(RVA = "0x52A2770", Offset = "0x52A1970", VA = "0x1852A2770")]
	public COBJIBKKAMJ(OINPHBHEBFM EHHPLBPDKBE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002E0")]
	[Cpp2IlInjected.Address(RVA = "0x52A61B0", Offset = "0x52A53B0", VA = "0x1852A61B0", Slot = "6")]
	public void NJINOCNPPGC(Rigidbody NBJEPCGIGPN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002E1")]
	[Cpp2IlInjected.Address(RVA = "0x52A62B0", Offset = "0x52A54B0", VA = "0x1852A62B0", Slot = "7")]
	public void NNCOBAOCBLO(Rigidbody NBJEPCGIGPN)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000030")]
internal sealed class GHKFOOJBCPI : KGGBOPCKBMM, ACEBILIFEIP, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x4000050")]
	private readonly DOPLKJCNONA OKKDPEMOHMC;

	[Cpp2IlInjected.Token(Token = "0x170000C8")]
	private Transform DHGHIDOLKGM
	{
		[Cpp2IlInjected.Token(Token = "0x60002F5")]
		[Cpp2IlInjected.Address(RVA = "0x52B1010", Offset = "0x52B0210", VA = "0x1852B1010")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000C9")]
	public HPHBHAKAACD KEKHMGGAFDD
	{
		[Cpp2IlInjected.Token(Token = "0x60002F7")]
		[Cpp2IlInjected.Address(RVA = "0x52B0F10", Offset = "0x52B0110", VA = "0x1852B0F10")]
		get
		{
			return default(HPHBHAKAACD);
		}
		[Cpp2IlInjected.Token(Token = "0x60002F8")]
		[Cpp2IlInjected.Address(RVA = "0x52B0E10", Offset = "0x52B0010", VA = "0x1852B0E10")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000CA")]
	public OINPHBHEBFM HKAHNOCIENG
	{
		[Cpp2IlInjected.Token(Token = "0x60002F9")]
		[Cpp2IlInjected.Address(RVA = "0x52B0760", Offset = "0x52AF960", VA = "0x1852B0760", Slot = "24")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60002FA")]
		[Cpp2IlInjected.Address(RVA = "0x52B1140", Offset = "0x52B0340", VA = "0x1852B1140", Slot = "25")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000CB")]
	public HPHBHAKAACD IFNPAPKDGEI
	{
		[Cpp2IlInjected.Token(Token = "0x60002FB")]
		[Cpp2IlInjected.Address(RVA = "0x52B2390", Offset = "0x52B1590", VA = "0x1852B2390")]
		get
		{
			return default(HPHBHAKAACD);
		}
		[Cpp2IlInjected.Token(Token = "0x60002FC")]
		[Cpp2IlInjected.Address(RVA = "0x52B1040", Offset = "0x52B0240", VA = "0x1852B1040")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000CC")]
	public OINPHBHEBFM CFHDLGEGDFD
	{
		[Cpp2IlInjected.Token(Token = "0x60002FD")]
		[Cpp2IlInjected.Address(RVA = "0x52B2B60", Offset = "0x52B1D60", VA = "0x1852B2B60", Slot = "23")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000CD")]
	public IReadOnlyList<OINPHBHEBFM> NCLNEDAIDDA
	{
		[Cpp2IlInjected.Token(Token = "0x60002FE")]
		[Cpp2IlInjected.Address(RVA = "0x817390", Offset = "0x816590", VA = "0x180817390", Slot = "22")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400002B")]
	public event FGJCBPBEFOP PBANFIJELBE
	{
		[Cpp2IlInjected.Token(Token = "0x60002E3")]
		[Cpp2IlInjected.Address(RVA = "0x52B11B0", Offset = "0x52B03B0", VA = "0x1852B11B0", Slot = "4")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60002E4")]
		[Cpp2IlInjected.Address(RVA = "0x52B25D0", Offset = "0x52B17D0", VA = "0x1852B25D0", Slot = "5")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400002C")]
	public event FGJCBPBEFOP MGANLNPCDNF
	{
		[Cpp2IlInjected.Token(Token = "0x60002E5")]
		[Cpp2IlInjected.Address(RVA = "0x52B0620", Offset = "0x52AF820", VA = "0x1852B0620", Slot = "6")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60002E6")]
		[Cpp2IlInjected.Address(RVA = "0x52B2530", Offset = "0x52B1730", VA = "0x1852B2530", Slot = "7")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400002D")]
	public event OHFGCHALJBC CLHKPMHNJGH
	{
		[Cpp2IlInjected.Token(Token = "0x60002E7")]
		[Cpp2IlInjected.Address(RVA = "0x52B1720", Offset = "0x52B0920", VA = "0x1852B1720", Slot = "8")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60002E8")]
		[Cpp2IlInjected.Address(RVA = "0x52B2670", Offset = "0x52B1870", VA = "0x1852B2670", Slot = "9")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400002E")]
	public event Action LEPPBOOKMBH
	{
		[Cpp2IlInjected.Token(Token = "0x60002E9")]
		[Cpp2IlInjected.Address(RVA = "0x52B19D0", Offset = "0x52B0BD0", VA = "0x1852B19D0", Slot = "10")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60002EA")]
		[Cpp2IlInjected.Address(RVA = "0x52B2710", Offset = "0x52B1910", VA = "0x1852B2710", Slot = "11")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400002F")]
	public event Action KDMAPDBOBHG
	{
		[Cpp2IlInjected.Token(Token = "0x60002EB")]
		[Cpp2IlInjected.Address(RVA = "0x52B27B0", Offset = "0x52B19B0", VA = "0x1852B27B0", Slot = "12")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60002EC")]
		[Cpp2IlInjected.Address(RVA = "0x52B1250", Offset = "0x52B0450", VA = "0x1852B1250", Slot = "13")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000030")]
	public event Action<OINPHBHEBFM> NKBGAPIKEDN
	{
		[Cpp2IlInjected.Token(Token = "0x60002ED")]
		[Cpp2IlInjected.Address(RVA = "0x52B07A0", Offset = "0x52AF9A0", VA = "0x1852B07A0", Slot = "14")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60002EE")]
		[Cpp2IlInjected.Address(RVA = "0x52B1550", Offset = "0x52B0750", VA = "0x1852B1550", Slot = "15")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000031")]
	public event Action<OINPHBHEBFM> GBNGEPPDDCO
	{
		[Cpp2IlInjected.Token(Token = "0x60002EF")]
		[Cpp2IlInjected.Address(RVA = "0x52B14B0", Offset = "0x52B06B0", VA = "0x1852B14B0", Slot = "16")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60002F0")]
		[Cpp2IlInjected.Address(RVA = "0x52B2AC0", Offset = "0x52B1CC0", VA = "0x1852B2AC0", Slot = "17")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000032")]
	public event Action NELDKADHHEN
	{
		[Cpp2IlInjected.Token(Token = "0x60002F1")]
		[Cpp2IlInjected.Address(RVA = "0x52B2490", Offset = "0x52B1690", VA = "0x1852B2490", Slot = "18")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60002F2")]
		[Cpp2IlInjected.Address(RVA = "0x52B1A70", Offset = "0x52B0C70", VA = "0x1852B1A70", Slot = "19")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000033")]
	public event Action<OINPHBHEBFM> BCMOPJLPDJI
	{
		[Cpp2IlInjected.Token(Token = "0x60002F3")]
		[Cpp2IlInjected.Address(RVA = "0x52B18B0", Offset = "0x52B0AB0", VA = "0x1852B18B0", Slot = "20")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60002F4")]
		[Cpp2IlInjected.Address(RVA = "0x52B06C0", Offset = "0x52AF8C0", VA = "0x1852B06C0", Slot = "21")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60002E2")]
	[Cpp2IlInjected.Address(RVA = "0x52B2BA0", Offset = "0x52B1DA0", VA = "0x1852B2BA0")]
	public GHKFOOJBCPI(OINPHBHEBFM EHHPLBPDKBE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002F6")]
	[Cpp2IlInjected.Address(RVA = "0x52B0C40", Offset = "0x52AFE40", VA = "0x1852B0C40", Slot = "27")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002FF")]
	[Cpp2IlInjected.Address(RVA = "0x52B1830", Offset = "0x52B0A30", VA = "0x1852B1830", Slot = "26")]
	public void HMBNJDPGAJN(OINPHBHEBFM BDBBMBMDCFP, bool LDEEGDEKBLJ = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000300")]
	[Cpp2IlInjected.Address(RVA = "0x52B17C0", Offset = "0x52B09C0", VA = "0x1852B17C0")]
	private void HMBNJDPGAJN(FPAEMFDCAME BDBBMBMDCFP, bool LDEEGDEKBLJ = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000301")]
	[Cpp2IlInjected.Address(RVA = "0x52B1B10", Offset = "0x52B0D10", VA = "0x1852B1B10")]
	private void JKGECANFLKM(FPAEMFDCAME BDBBMBMDCFP, bool LDEEGDEKBLJ = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000302")]
	[Cpp2IlInjected.Address(RVA = "0x52B12F0", Offset = "0x52B04F0", VA = "0x1852B12F0")]
	private void GNNBGIOKGLJ(FPAEMFDCAME DLHNFCJIJJD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000303")]
	[Cpp2IlInjected.Address(RVA = "0x52B2850", Offset = "0x52B1A50", VA = "0x1852B2850")]
	private void PAINNLINJFA(FPAEMFDCAME DLHNFCJIJJD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000304")]
	[Cpp2IlInjected.Address(RVA = "0x52B0AA0", Offset = "0x52AFCA0", VA = "0x1852B0AA0")]
	private void DLCMANLNGDI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000305")]
	[Cpp2IlInjected.Address(RVA = "0x52B1950", Offset = "0x52B0B50", VA = "0x1852B1950")]
	private void IOJGOGBBBID(FPAEMFDCAME DLHNFCJIJJD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000306")]
	[Cpp2IlInjected.Address(RVA = "0x52B2A10", Offset = "0x52B1C10", VA = "0x1852B2A10")]
	private void PJIEKOAPMDB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000307")]
	[Cpp2IlInjected.Address(RVA = "0x52B0970", Offset = "0x52AFB70", VA = "0x1852B0970")]
	private void DKBLHMAEHGG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000308")]
	[Cpp2IlInjected.Address(RVA = "0x52B15F0", Offset = "0x52B07F0", VA = "0x1852B15F0")]
	private void HDJNLHIMONE(FPAEMFDCAME EHHPLBPDKBE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000309")]
	[Cpp2IlInjected.Address(RVA = "0x52B0840", Offset = "0x52AFA40", VA = "0x1852B0840")]
	private void DFCNILODFON(FPAEMFDCAME EHHPLBPDKBE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600030A")]
	[Cpp2IlInjected.Address(RVA = "0x52B0520", Offset = "0x52AF720", VA = "0x1852B0520")]
	[CompilerGenerated]
	private object ADMDELBIGHI()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000031")]
internal static class KBEHALDIIBG
{
	[Cpp2IlInjected.Token(Token = "0x600030B")]
	[Cpp2IlInjected.Address(RVA = "0x52BDFD0", Offset = "0x52BD1D0", VA = "0x1852BDFD0")]
	public static GHKFOOJBCPI ILLFGBFMOKO(this OINPHBHEBFM IDCNELICAAG)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000032")]
internal sealed class JEPLAFNIGJD : KGGBOPCKBMM, OPBHABCMHHK
{
	[Cpp2IlInjected.Token(Token = "0x170000CE")]
	public Vector3 CEAFBIINOKH
	{
		[Cpp2IlInjected.Token(Token = "0x600030D")]
		[Cpp2IlInjected.Address(RVA = "0x52BC390", Offset = "0x52BB590", VA = "0x1852BC390", Slot = "4")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000CF")]
	public Vector3 NHENIPHGFOP
	{
		[Cpp2IlInjected.Token(Token = "0x600030E")]
		[Cpp2IlInjected.Address(RVA = "0x52BCBD0", Offset = "0x52BBDD0", VA = "0x1852BCBD0", Slot = "5")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000D0")]
	private Vector3 BNMCMLCKBOK
	{
		[Cpp2IlInjected.Token(Token = "0x6000312")]
		[Cpp2IlInjected.Address(RVA = "0x52BC2B0", Offset = "0x52BB4B0", VA = "0x1852BC2B0")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000D1")]
	private OINPHBHEBFM OEPBOFMCNBN
	{
		[Cpp2IlInjected.Token(Token = "0x6000313")]
		[Cpp2IlInjected.Address(RVA = "0x52BCA70", Offset = "0x52BBC70", VA = "0x1852BCA70")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600030C")]
	[Cpp2IlInjected.Address(RVA = "0x52A2770", Offset = "0x52A1970", VA = "0x1852A2770")]
	public JEPLAFNIGJD(OINPHBHEBFM EHHPLBPDKBE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600030F")]
	[Cpp2IlInjected.Address(RVA = "0x52BC8E0", Offset = "0x52BBAE0", VA = "0x1852BC8E0", Slot = "6")]
	public void KDCKLPJMBKN(OINPHBHEBFM HHFDFFDPCGO, object IALNODEHBNN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000310")]
	[Cpp2IlInjected.Address(RVA = "0x52BC7B0", Offset = "0x52BB9B0", VA = "0x1852BC7B0")]
	private void KDCKLPJMBKN(FPAEMFDCAME HHFDFFDPCGO, object IALNODEHBNN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000311")]
	[Cpp2IlInjected.Address(RVA = "0x52BCE10", Offset = "0x52BC010", VA = "0x1852BCE10", Slot = "7")]
	public void OMINIIDBGAF(object IALNODEHBNN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000314")]
	[Cpp2IlInjected.Address(RVA = "0x52BC3C0", Offset = "0x52BB5C0", VA = "0x1852BC3C0")]
	private Vector3 IDDGPBEGFAK()
	{
		return default(Vector3);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000033")]
internal static class NLHHKGHOEHM
{
	[Cpp2IlInjected.Token(Token = "0x6000315")]
	[Cpp2IlInjected.Address(RVA = "0x52C6100", Offset = "0x52C5300", VA = "0x1852C6100")]
	public static JEPLAFNIGJD DMGNAPMCCPA(this OINPHBHEBFM IDCNELICAAG)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000034")]
internal sealed class PAKDKJEGKHG : KGGBOPCKBMM, KMFGIPGBMDB
{
	[Cpp2IlInjected.Token(Token = "0x170000D2")]
	public Vector3 CMPGKEOHLJC
	{
		[Cpp2IlInjected.Token(Token = "0x6000319")]
		[Cpp2IlInjected.Address(RVA = "0x52C6BC0", Offset = "0x52C5DC0", VA = "0x1852C6BC0", Slot = "6")]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x600031A")]
		[Cpp2IlInjected.Address(RVA = "0x52C72A0", Offset = "0x52C64A0", VA = "0x1852C72A0", Slot = "7")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000D3")]
	public Vector3 EIMEJLMMLMA
	{
		[Cpp2IlInjected.Token(Token = "0x600031B")]
		[Cpp2IlInjected.Address(RVA = "0x52C6CF0", Offset = "0x52C5EF0", VA = "0x1852C6CF0", Slot = "8")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000D4")]
	public float EHLCHKMKGBK
	{
		[Cpp2IlInjected.Token(Token = "0x600031C")]
		[Cpp2IlInjected.Address(RVA = "0x52C7070", Offset = "0x52C6270", VA = "0x1852C7070", Slot = "9")]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x600031D")]
		[Cpp2IlInjected.Address(RVA = "0x52C73E0", Offset = "0x52C65E0", VA = "0x1852C73E0")]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000D5")]
	public float BENEGDAHFLL
	{
		[Cpp2IlInjected.Token(Token = "0x600031E")]
		[Cpp2IlInjected.Address(RVA = "0x52C73F0", Offset = "0x52C65F0", VA = "0x1852C73F0", Slot = "10")]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x600031F")]
		[Cpp2IlInjected.Address(RVA = "0x52C71F0", Offset = "0x52C63F0", VA = "0x1852C71F0", Slot = "11")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000D6")]
	public Vector3 NGJFIKPFMML
	{
		[Cpp2IlInjected.Token(Token = "0x6000320")]
		[Cpp2IlInjected.Address(RVA = "0x52C8BD0", Offset = "0x52C7DD0", VA = "0x1852C8BD0", Slot = "12")]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x6000321")]
		[Cpp2IlInjected.Address(RVA = "0x52C6E10", Offset = "0x52C6010", VA = "0x1852C6E10", Slot = "13")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000D7")]
	public Quaternion LKICJOBKNGL
	{
		[Cpp2IlInjected.Token(Token = "0x6000322")]
		[Cpp2IlInjected.Address(RVA = "0x52C76A0", Offset = "0x52C68A0", VA = "0x1852C76A0", Slot = "14")]
		get
		{
			return default(Quaternion);
		}
		[Cpp2IlInjected.Token(Token = "0x6000323")]
		[Cpp2IlInjected.Address(RVA = "0x52C8E10", Offset = "0x52C8010", VA = "0x1852C8E10", Slot = "15")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000D8")]
	private Rigidbody JMCCCFFEIIG
	{
		[Cpp2IlInjected.Token(Token = "0x600032B")]
		[Cpp2IlInjected.Address(RVA = "0x52A2720", Offset = "0x52A1920", VA = "0x1852A2720")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000034")]
	public event FGJCBPBEFOP DABDOEGBNOF
	{
		[Cpp2IlInjected.Token(Token = "0x6000316")]
		[Cpp2IlInjected.Address(RVA = "0x52C7200", Offset = "0x52C6400", VA = "0x1852C7200", Slot = "4")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000317")]
		[Cpp2IlInjected.Address(RVA = "0x52C7150", Offset = "0x52C6350", VA = "0x1852C7150", Slot = "5")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000318")]
	[Cpp2IlInjected.Address(RVA = "0x52C9CB0", Offset = "0x52C8EB0", VA = "0x1852C9CB0")]
	public PAKDKJEGKHG(OINPHBHEBFM EHHPLBPDKBE, in IPGEEHAGLOI PCPEJHIMHJJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000324")]
	[Cpp2IlInjected.Address(RVA = "0x52C89C0", Offset = "0x52C7BC0", VA = "0x1852C89C0", Slot = "17")]
	public void LILDLMIHEAF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000325")]
	[Cpp2IlInjected.Address(RVA = "0x52C94F0", Offset = "0x52C86F0", VA = "0x1852C94F0", Slot = "16")]
	public void OLIDEBFPCBJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000326")]
	[Cpp2IlInjected.Address(RVA = "0x52C8E30", Offset = "0x52C8030", VA = "0x1852C8E30", Slot = "19")]
	public void NJINOCNPPGC(Rigidbody NBJEPCGIGPN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000327")]
	[Cpp2IlInjected.Address(RVA = "0x52C9050", Offset = "0x52C8250", VA = "0x1852C9050", Slot = "20")]
	public void NNCOBAOCBLO(Rigidbody NBJEPCGIGPN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000328")]
	[Cpp2IlInjected.Address(RVA = "0x52C7890", Offset = "0x52C6A90", VA = "0x1852C7890", Slot = "18")]
	public void KJCFGELAPLM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000329")]
	[Cpp2IlInjected.Address(RVA = "0x52C66D0", Offset = "0x52C58D0", VA = "0x1852C66D0", Slot = "21")]
	public void AMMOJMDCBMC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600032A")]
	[Cpp2IlInjected.Address(RVA = "0x52A4020", Offset = "0x52A3220", VA = "0x1852A4020")]
	public void HLMMELBPINF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600032C")]
	[Cpp2IlInjected.Address(RVA = "0x52C72A0", Offset = "0x52C64A0", VA = "0x1852C72A0")]
	private void KEDJCFDKLAO(Vector3 IPMIIEAGJKC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600032D")]
	[Cpp2IlInjected.Address(RVA = "0x52C93D0", Offset = "0x52C85D0", VA = "0x1852C93D0")]
	private Vector3 OFGCAAHHPPH()
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x600032E")]
	[Cpp2IlInjected.Address(RVA = "0x52C74D0", Offset = "0x52C66D0", VA = "0x1852C74D0")]
	private void IMILCKKKLDJ(float IPMIIEAGJKC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600032F")]
	[Cpp2IlInjected.Address(RVA = "0x52C76D0", Offset = "0x52C68D0", VA = "0x1852C76D0")]
	private void KCLPHGPBFDD(float IPMIIEAGJKC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000330")]
	[Cpp2IlInjected.Address(RVA = "0x52C6E40", Offset = "0x52C6040", VA = "0x1852C6E40")]
	private Vector3 DIDEHKMFMDM()
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000331")]
	[Cpp2IlInjected.Address(RVA = "0x52C9870", Offset = "0x52C8A70", VA = "0x1852C9870")]
	private void PGEMLHNKMFA(Vector3 IPMIIEAGJKC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000332")]
	[Cpp2IlInjected.Address(RVA = "0x52C9AA0", Offset = "0x52C8CA0", VA = "0x1852C9AA0")]
	private Quaternion PKFDOANKKGD()
	{
		return default(Quaternion);
	}

	[Cpp2IlInjected.Token(Token = "0x6000333")]
	[Cpp2IlInjected.Address(RVA = "0x52C8C00", Offset = "0x52C7E00", VA = "0x1852C8C00")]
	private void NAHEMADMLCM(Quaternion IPMIIEAGJKC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000334")]
	[Cpp2IlInjected.Address(RVA = "0x52C7970", Offset = "0x52C6B70", VA = "0x1852C7970")]
	internal (float, Vector3) KNMMHOMBDMC(Rigidbody DJLPCBPBOHF)
	{
		return default((float, Vector3));
	}
}
[Cpp2IlInjected.Token(Token = "0x2000035")]
internal static class JKFLGIDLMMJ
{
	[Cpp2IlInjected.Token(Token = "0x6000335")]
	[Cpp2IlInjected.Address(RVA = "0x52BCFC0", Offset = "0x52BC1C0", VA = "0x1852BCFC0")]
	public static PAKDKJEGKHG BPCPJFNAOMK(this OINPHBHEBFM IDCNELICAAG)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000036")]
internal sealed class AGIGEMMJAJO : KGGBOPCKBMM, POMIHBCAKMM
{
	[Cpp2IlInjected.Token(Token = "0x4000052")]
	private const string NABPFCBNOPO = "INTERP_PAUSE";

	[Cpp2IlInjected.Token(Token = "0x170000D9")]
	public bool MGOICACOHNO
	{
		[Cpp2IlInjected.Token(Token = "0x6000336")]
		[Cpp2IlInjected.Address(RVA = "0x52A2F20", Offset = "0x52A2120", VA = "0x1852A2F20", Slot = "4")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000DA")]
	public MGFMFIIFDMD MDEOCKDFDNK
	{
		[Cpp2IlInjected.Token(Token = "0x6000337")]
		[Cpp2IlInjected.Address(RVA = "0x52A2D40", Offset = "0x52A1F40", VA = "0x1852A2D40", Slot = "5")]
		get
		{
			return default(MGFMFIIFDMD);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000DB")]
	private MGFMFIIFDMD GHHPIANKIEL
	{
		[Cpp2IlInjected.Token(Token = "0x6000339")]
		[Cpp2IlInjected.Address(RVA = "0x52A27F0", Offset = "0x52A19F0", VA = "0x1852A27F0")]
		get
		{
			return default(MGFMFIIFDMD);
		}
		[Cpp2IlInjected.Token(Token = "0x600033A")]
		[Cpp2IlInjected.Address(RVA = "0x52A2A10", Offset = "0x52A1C10", VA = "0x1852A2A10")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000338")]
	[Cpp2IlInjected.Address(RVA = "0x52A31E0", Offset = "0x52A23E0", VA = "0x1852A31E0")]
	public AGIGEMMJAJO(OINPHBHEBFM EHHPLBPDKBE, in IPGEEHAGLOI PCPEJHIMHJJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600033B")]
	[Cpp2IlInjected.Address(RVA = "0x52A2E60", Offset = "0x52A2060", VA = "0x1852A2E60", Slot = "6")]
	public void JDBMEAOELGO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600033C")]
	[Cpp2IlInjected.Address(RVA = "0x52A3040", Offset = "0x52A2240", VA = "0x1852A3040")]
	private bool NGHBNAILKLI()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600033D")]
	[Cpp2IlInjected.Address(RVA = "0x52A28D0", Offset = "0x52A1AD0", VA = "0x1852A28D0", Slot = "7")]
	public void DOAIEIBIBFL(object IALNODEHBNN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600033E")]
	[Cpp2IlInjected.Address(RVA = "0x52A30E0", Offset = "0x52A22E0", VA = "0x1852A30E0", Slot = "8")]
	public void OEGPCOAFMDB(object IALNODEHBNN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600033F")]
	[Cpp2IlInjected.Address(RVA = "0x52A2D50", Offset = "0x52A1F50", VA = "0x1852A2D50", Slot = "11")]
	public void IKKEJJKEGGH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000340")]
	[Cpp2IlInjected.Address(RVA = "0x52A2B00", Offset = "0x52A1D00", VA = "0x1852A2B00")]
	private void HMKLPMPBPND()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000341")]
	[Cpp2IlInjected.Address(RVA = "0x52A2BF0", Offset = "0x52A1DF0", VA = "0x1852A2BF0")]
	private void IBOLLAOMABA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000342")]
	[Cpp2IlInjected.Address(RVA = "0x52A3000", Offset = "0x52A2200", VA = "0x1852A3000", Slot = "10")]
	public void NFHJNCFFDIO(OINPHBHEBFM EHHPLBPDKBE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000343")]
	[Cpp2IlInjected.Address(RVA = "0x52A29D0", Offset = "0x52A1BD0", VA = "0x1852A29D0", Slot = "9")]
	public void FGILIJPPIJA(OINPHBHEBFM EHHPLBPDKBE)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000037")]
internal sealed class KLNGLGILHHJ : KGGBOPCKBMM, KJLCKLHHAII
{
	[Cpp2IlInjected.Token(Token = "0x170000DC")]
	public bool KFFOOLFOADP
	{
		[Cpp2IlInjected.Token(Token = "0x6000346")]
		[Cpp2IlInjected.Address(RVA = "0x52BE610", Offset = "0x52BD810", VA = "0x1852BE610", Slot = "6")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000DD")]
	public IEnumerable<object> NHEINPMGMGO
	{
		[Cpp2IlInjected.Token(Token = "0x6000347")]
		[Cpp2IlInjected.Address(RVA = "0x52BE530", Offset = "0x52BD730", VA = "0x1852BE530", Slot = "7")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000DE")]
	private bool DBHEPBMPBMM
	{
		[Cpp2IlInjected.Token(Token = "0x6000348")]
		[Cpp2IlInjected.Address(RVA = "0x52BE1C0", Offset = "0x52BD3C0", VA = "0x1852BE1C0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000035")]
	public event FGJCBPBEFOP OLENKEHDGAF
	{
		[Cpp2IlInjected.Token(Token = "0x6000344")]
		[Cpp2IlInjected.Address(RVA = "0x52BE770", Offset = "0x52BD970", VA = "0x1852BE770", Slot = "4")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000345")]
		[Cpp2IlInjected.Address(RVA = "0x52BE310", Offset = "0x52BD510", VA = "0x1852BE310", Slot = "5")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000349")]
	[Cpp2IlInjected.Address(RVA = "0x52A2770", Offset = "0x52A1970", VA = "0x1852A2770")]
	public KLNGLGILHHJ(OINPHBHEBFM EHHPLBPDKBE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600034A")]
	[Cpp2IlInjected.Address(RVA = "0x52BE2B0", Offset = "0x52BD4B0", VA = "0x1852BE2B0", Slot = "11")]
	public IDisposable EEBIOLKMNJN()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600034B")]
	[Cpp2IlInjected.Address(RVA = "0x52BE1B0", Offset = "0x52BD3B0", VA = "0x1852BE1B0", Slot = "8")]
	public void ANNHOHNEGBC(object IALNODEHBNN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600034C")]
	[Cpp2IlInjected.Address(RVA = "0x52BE2A0", Offset = "0x52BD4A0", VA = "0x1852BE2A0", Slot = "9")]
	public void DIACCKFBBFC(object IALNODEHBNN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600034D")]
	[Cpp2IlInjected.Address(RVA = "0x52BE3B0", Offset = "0x52BD5B0", VA = "0x1852BE3B0", Slot = "10")]
	public void IMCEFNKDLJE(object IALNODEHBNN, bool DKKAHPAOACL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600034E")]
	[Cpp2IlInjected.Address(RVA = "0x52BE6D0", Offset = "0x52BD8D0", VA = "0x1852BE6D0", Slot = "12")]
	public void NJINOCNPPGC(Rigidbody FNBMGBEMKPE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600034F")]
	[Cpp2IlInjected.Address(RVA = "0x52BE740", Offset = "0x52BD940", VA = "0x1852BE740", Slot = "13")]
	public void NNCOBAOCBLO(Rigidbody NBJEPCGIGPN)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000038")]
internal sealed class MHCLHKLLNED : KGGBOPCKBMM, HDMHGHFDNPO, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000055")]
	private PhotonView OGMNKDNMJCB;

	[Cpp2IlInjected.Token(Token = "0x170000DF")]
	public bool NKELDOMJEGL
	{
		[Cpp2IlInjected.Token(Token = "0x6000352")]
		[Cpp2IlInjected.Address(RVA = "0x52A5B40", Offset = "0x52A4D40", VA = "0x1852A5B40", Slot = "6")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000E0")]
	public bool DMMCOKOAOJI
	{
		[Cpp2IlInjected.Token(Token = "0x6000353")]
		[Cpp2IlInjected.Address(RVA = "0x52C1650", Offset = "0x52C0850", VA = "0x1852C1650", Slot = "7")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000036")]
	public event FGJCBPBEFOP EBDIBBFMNAG
	{
		[Cpp2IlInjected.Token(Token = "0x6000350")]
		[Cpp2IlInjected.Address(RVA = "0x52C1320", Offset = "0x52C0520", VA = "0x1852C1320", Slot = "4")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000351")]
		[Cpp2IlInjected.Address(RVA = "0x52C15B0", Offset = "0x52C07B0", VA = "0x1852C15B0", Slot = "5")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000354")]
	[Cpp2IlInjected.Address(RVA = "0x52C2020", Offset = "0x52C1220", VA = "0x1852C2020")]
	public MHCLHKLLNED(OINPHBHEBFM EHHPLBPDKBE, in IPGEEHAGLOI PCPEJHIMHJJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000355")]
	[Cpp2IlInjected.Address(RVA = "0x52C1760", Offset = "0x52C0960", VA = "0x1852C1760", Slot = "8")]
	public void JDBMEAOELGO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000356")]
	[Cpp2IlInjected.Address(RVA = "0x52C13C0", Offset = "0x52C05C0", VA = "0x1852C13C0", Slot = "11")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000357")]
	[Cpp2IlInjected.Address(RVA = "0x52C18B0", Offset = "0x52C0AB0", VA = "0x1852C18B0", Slot = "9")]
	public void JLNECFHPDHL(OINPHBHEBFM HHFDFFDPCGO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000358")]
	[Cpp2IlInjected.Address(RVA = "0x52C1AC0", Offset = "0x52C0CC0", VA = "0x1852C1AC0", Slot = "10")]
	public void LAJHBEDDHLL(OINPHBHEBFM HHFDFFDPCGO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000359")]
	[Cpp2IlInjected.Address(RVA = "0x52C1E30", Offset = "0x52C1030", VA = "0x1852C1E30")]
	private void NKJIAOABNBM(PhotonView CIPJGOKLPNK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600035A")]
	[Cpp2IlInjected.Address(RVA = "0x52C1CD0", Offset = "0x52C0ED0", VA = "0x1852C1CD0")]
	private void MKEKIECENPJ(RigidbodyEx CHCEHPOABNL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600035B")]
	[Cpp2IlInjected.Address(RVA = "0x52C1150", Offset = "0x52C0350", VA = "0x1852C1150")]
	private void DBDBMELKCNL(PhotonView PAOKDHCCPKP)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000039")]
internal static class CFKLKKMGCBD
{
	[Cpp2IlInjected.Token(Token = "0x600035C")]
	[Cpp2IlInjected.Address(RVA = "0x52A4DB0", Offset = "0x52A3FB0", VA = "0x1852A4DB0")]
	public static MHCLHKLLNED EACALKEIBCF(this FFNHAGGANGK IDCNELICAAG)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200003A")]
internal sealed class HBFOBGKLFBJ : KGGBOPCKBMM, KJDGGMNDKPF
{
	[Cpp2IlInjected.Token(Token = "0x170000E1")]
	public bool ADJEMOAFAPK
	{
		[Cpp2IlInjected.Token(Token = "0x600035D")]
		[Cpp2IlInjected.Address(RVA = "0x52B3830", Offset = "0x52B2A30", VA = "0x1852B3830", Slot = "4")]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x600035E")]
		[Cpp2IlInjected.Address(RVA = "0x52B3CD0", Offset = "0x52B2ED0", VA = "0x1852B3CD0", Slot = "5")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000E2")]
	public bool CEBDHLOLCGG
	{
		[Cpp2IlInjected.Token(Token = "0x600035F")]
		[Cpp2IlInjected.Address(RVA = "0x52B39F0", Offset = "0x52B2BF0", VA = "0x1852B39F0", Slot = "6")]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000360")]
		[Cpp2IlInjected.Address(RVA = "0x52B3540", Offset = "0x52B2740", VA = "0x1852B3540")]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000E3")]
	public RigidbodyConstraints PILCFECIKIL
	{
		[Cpp2IlInjected.Token(Token = "0x6000361")]
		[Cpp2IlInjected.Address(RVA = "0x52B3910", Offset = "0x52B2B10", VA = "0x1852B3910", Slot = "7")]
		get
		{
			return default(RigidbodyConstraints);
		}
		[Cpp2IlInjected.Token(Token = "0x6000362")]
		[Cpp2IlInjected.Address(RVA = "0x52B3630", Offset = "0x52B2830", VA = "0x1852B3630", Slot = "8")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000363")]
	[Cpp2IlInjected.Address(RVA = "0x52B3DC0", Offset = "0x52B2FC0", VA = "0x1852B3DC0")]
	public HBFOBGKLFBJ(OINPHBHEBFM EHHPLBPDKBE, in IPGEEHAGLOI PCPEJHIMHJJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000364")]
	[Cpp2IlInjected.Address(RVA = "0x52B3AD0", Offset = "0x52B2CD0", VA = "0x1852B3AD0", Slot = "9")]
	public void NJINOCNPPGC(Rigidbody NBJEPCGIGPN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000365")]
	[Cpp2IlInjected.Address(RVA = "0x52B3BD0", Offset = "0x52B2DD0", VA = "0x1852B3BD0", Slot = "10")]
	public void NNCOBAOCBLO(Rigidbody NBJEPCGIGPN)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200003B")]
internal sealed class HFPALLDJOJL : KGGBOPCKBMM, CAMJCFKKLPP
{
	[Cpp2IlInjected.Token(Token = "0x170000E4")]
	public float PIPAENOKBKE
	{
		[Cpp2IlInjected.Token(Token = "0x6000367")]
		[Cpp2IlInjected.Address(RVA = "0x52B41D0", Offset = "0x52B33D0", VA = "0x1852B41D0", Slot = "4")]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x6000368")]
		[Cpp2IlInjected.Address(RVA = "0x52B4630", Offset = "0x52B3830", VA = "0x1852B4630", Slot = "5")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000E5")]
	public float HGOJLGHHICI
	{
		[Cpp2IlInjected.Token(Token = "0x6000369")]
		[Cpp2IlInjected.Address(RVA = "0x52B42B0", Offset = "0x52B34B0", VA = "0x1852B42B0", Slot = "6")]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x600036A")]
		[Cpp2IlInjected.Address(RVA = "0x52B4000", Offset = "0x52B3200", VA = "0x1852B4000", Slot = "7")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000366")]
	[Cpp2IlInjected.Address(RVA = "0x52A2770", Offset = "0x52A1970", VA = "0x1852A2770")]
	public HFPALLDJOJL(OINPHBHEBFM EHHPLBPDKBE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600036B")]
	[Cpp2IlInjected.Address(RVA = "0x52B4390", Offset = "0x52B3590", VA = "0x1852B4390", Slot = "8")]
	public void NJINOCNPPGC(Rigidbody NBJEPCGIGPN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600036C")]
	[Cpp2IlInjected.Address(RVA = "0x52B4560", Offset = "0x52B3760", VA = "0x1852B4560", Slot = "9")]
	public void NNCOBAOCBLO(Rigidbody NBJEPCGIGPN)
	{
	}
}
namespace RecRoom.Rbex.ObjectModel
{
	[Cpp2IlInjected.Token(Token = "0x200003C")]
	[PNCLNBNALEO(typeof(FPOFHEKDION), new string[] { })]
	[CGDKNMKPKIP(OOBCCNCEGNI.Physics)]
	public sealed class RbexServiceCallbacks : CMLEAAEGAAL, FPOFHEKDION, IDisposable
	{
		[Cpp2IlInjected.Token(Token = "0x4000056")]
		private static readonly HDHIMOFHFJL AHADDDAMGKE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000057")]
		private APGPGBLMNNP EHHPLBPDKBE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000058")]
		private bool KBDIBPJIHNN;

		[Cpp2IlInjected.Token(Token = "0x170000E6")]
		public bool ICJICHLKHIE
		{
			[Cpp2IlInjected.Token(Token = "0x600036F")]
			[Cpp2IlInjected.Address(RVA = "0x7E49F0", Offset = "0x7E3BF0", VA = "0x1807E49F0", Slot = "5")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600036D")]
		[Cpp2IlInjected.Address(RVA = "0x675A4E0", Offset = "0x67596E0", VA = "0x18675A4E0", Slot = "4")]
		public void PACELKAFLHO(BLBDINABANB LBBJCIBEDFD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600036E")]
		[Cpp2IlInjected.Address(RVA = "0x675A200", Offset = "0x6759400", VA = "0x18675A200", Slot = "7")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000370")]
		[Cpp2IlInjected.Address(RVA = "0x675A230", Offset = "0x6759430", VA = "0x18675A230", Slot = "6")]
		public void KNMMHOMBDMC(HPHBHAKAACD EHNNHDBEJOG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000371")]
		[Cpp2IlInjected.Address(RVA = "0x703570", Offset = "0x702770", VA = "0x180703570")]
		public RbexServiceCallbacks()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200003D")]
internal sealed class CDHDNJKEBKF : KGGBOPCKBMM, GEILDFNHLPL
{
	[Cpp2IlInjected.Token(Token = "0x4000059")]
	public const int IABAEFMEJHP = 10;

	[Cpp2IlInjected.Token(Token = "0x400005A")]
	public const float CIAPHLDENLL = 9E-05f;

	[Cpp2IlInjected.Token(Token = "0x400005B")]
	public const float HCAACDBPPJM = 0.0001f;

	[Cpp2IlInjected.Token(Token = "0x400005C")]
	public const float HJCIDJFGMFP = 5f;

	[Cpp2IlInjected.Token(Token = "0x170000E7")]
	private Rigidbody JMCCCFFEIIG
	{
		[Cpp2IlInjected.Token(Token = "0x6000375")]
		[Cpp2IlInjected.Address(RVA = "0x52A2720", Offset = "0x52A1920", VA = "0x1852A2720")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000E8")]
	private bool HECHJGDGAKL
	{
		[Cpp2IlInjected.Token(Token = "0x6000376")]
		[Cpp2IlInjected.Address(RVA = "0x52A4500", Offset = "0x52A3700", VA = "0x1852A4500")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000E9")]
	private bool GCHJHCHGGCH
	{
		[Cpp2IlInjected.Token(Token = "0x6000377")]
		[Cpp2IlInjected.Address(RVA = "0x52A3F10", Offset = "0x52A3110", VA = "0x1852A3F10")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000EA")]
	private OINPHBHEBFM HKAHNOCIENG
	{
		[Cpp2IlInjected.Token(Token = "0x6000378")]
		[Cpp2IlInjected.Address(RVA = "0x52A3DD0", Offset = "0x52A2FD0", VA = "0x1852A3DD0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000EB")]
	private bool LLNINBLBFFN
	{
		[Cpp2IlInjected.Token(Token = "0x6000379")]
		[Cpp2IlInjected.Address(RVA = "0x52A4AA0", Offset = "0x52A3CA0", VA = "0x1852A4AA0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000EC")]
	private bool LLPJIADAKGC
	{
		[Cpp2IlInjected.Token(Token = "0x600037A")]
		[Cpp2IlInjected.Address(RVA = "0x52A3E30", Offset = "0x52A3030", VA = "0x1852A3E30")]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x600037B")]
		[Cpp2IlInjected.Address(RVA = "0x52A3F30", Offset = "0x52A3130", VA = "0x1852A3F30")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000ED")]
	private bool MHGKECJGPLP
	{
		[Cpp2IlInjected.Token(Token = "0x600037C")]
		[Cpp2IlInjected.Address(RVA = "0x52A4650", Offset = "0x52A3850", VA = "0x1852A4650")]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x600037D")]
		[Cpp2IlInjected.Address(RVA = "0x52A4110", Offset = "0x52A3310", VA = "0x1852A4110")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000EE")]
	private int KBAGHAHJHLN
	{
		[Cpp2IlInjected.Token(Token = "0x600037E")]
		[Cpp2IlInjected.Address(RVA = "0x52A3C00", Offset = "0x52A2E00", VA = "0x1852A3C00")]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x600037F")]
		[Cpp2IlInjected.Address(RVA = "0x52A3CE0", Offset = "0x52A2EE0", VA = "0x1852A3CE0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000037")]
	public event FGJCBPBEFOP MLKAKEPMHOI
	{
		[Cpp2IlInjected.Token(Token = "0x6000373")]
		[Cpp2IlInjected.Address(RVA = "0x52A4B10", Offset = "0x52A3D10", VA = "0x1852A4B10", Slot = "4")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000374")]
		[Cpp2IlInjected.Address(RVA = "0x52A4730", Offset = "0x52A3930", VA = "0x1852A4730", Slot = "5")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000380")]
	[Cpp2IlInjected.Address(RVA = "0x52A4BB0", Offset = "0x52A3DB0", VA = "0x1852A4BB0")]
	public CDHDNJKEBKF(OINPHBHEBFM EHHPLBPDKBE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000381")]
	[Cpp2IlInjected.Address(RVA = "0x52A47D0", Offset = "0x52A39D0", VA = "0x1852A47D0", Slot = "6")]
	public void JDBMEAOELGO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000382")]
	[Cpp2IlInjected.Address(RVA = "0x52A4B00", Offset = "0x52A3D00", VA = "0x1852A4B00", Slot = "8")]
	public void OBJEFDDDJLF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000383")]
	[Cpp2IlInjected.Address(RVA = "0x52A4880", Offset = "0x52A3A80", VA = "0x1852A4880", Slot = "7")]
	public bool JIPELJMHGEE()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000384")]
	[Cpp2IlInjected.Address(RVA = "0x52A45A0", Offset = "0x52A37A0", VA = "0x1852A45A0", Slot = "9")]
	public void HILGCFFPCIP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000385")]
	[Cpp2IlInjected.Address(RVA = "0x52A4020", Offset = "0x52A3220", VA = "0x1852A4020", Slot = "12")]
	public void EGIBKKKFHBP(bool JJOFBIIKAHB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000386")]
	[Cpp2IlInjected.Address(RVA = "0x52A4060", Offset = "0x52A3260", VA = "0x1852A4060", Slot = "11")]
	public void EMMDJJNLKHB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000387")]
	[Cpp2IlInjected.Address(RVA = "0x6F84D0", Offset = "0x6F76D0", VA = "0x1806F84D0", Slot = "10")]
	public void HNHGDPMCPBD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000388")]
	[Cpp2IlInjected.Address(RVA = "0x52A4350", Offset = "0x52A3550", VA = "0x1852A4350")]
	private bool GCLCJFPENDP()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000389")]
	[Cpp2IlInjected.Address(RVA = "0x52A4200", Offset = "0x52A3400", VA = "0x1852A4200")]
	private void FALKONLFKKA()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200003E")]
internal sealed class JKNDIEEAFMK : KGGBOPCKBMM, COPEPEMIJFF
{
	[Cpp2IlInjected.Token(Token = "0x400005E")]
	private const string NNKIPIEBCKF = "RBEX_ANIM";

	[Cpp2IlInjected.Token(Token = "0x170000EF")]
	public Rigidbody JMCCCFFEIIG
	{
		[Cpp2IlInjected.Token(Token = "0x600038A")]
		[Cpp2IlInjected.Address(RVA = "0x52BDE60", Offset = "0x52BD060", VA = "0x1852BDE60", Slot = "4")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600038B")]
		[Cpp2IlInjected.Address(RVA = "0x52BD050", Offset = "0x52BC250", VA = "0x1852BD050")]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000F0")]
	private bool LLNINBLBFFN
	{
		[Cpp2IlInjected.Token(Token = "0x600038C")]
		[Cpp2IlInjected.Address(RVA = "0x52B0310", Offset = "0x52AF510", VA = "0x1852B0310")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600038D")]
	[Cpp2IlInjected.Address(RVA = "0x52BDF40", Offset = "0x52BD140", VA = "0x1852BDF40")]
	public JKNDIEEAFMK(OINPHBHEBFM EHHPLBPDKBE, in IPGEEHAGLOI PCPEJHIMHJJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600038E")]
	[Cpp2IlInjected.Address(RVA = "0x52BDBF0", Offset = "0x52BCDF0", VA = "0x1852BDBF0", Slot = "5")]
	public void JDBMEAOELGO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600038F")]
	[Cpp2IlInjected.Address(RVA = "0x52BDAF0", Offset = "0x52BCCF0", VA = "0x1852BDAF0", Slot = "6")]
	public void IKBIHMLDNON(object IALNODEHBNN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000390")]
	[Cpp2IlInjected.Address(RVA = "0x52BD140", Offset = "0x52BC340", VA = "0x1852BD140", Slot = "7")]
	public void AIKKIMKHEPL(object IALNODEHBNN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000391")]
	[Cpp2IlInjected.Address(RVA = "0x52BD5D0", Offset = "0x52BC7D0", VA = "0x1852BD5D0", Slot = "8")]
	public void GDKFAEBPNCL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000392")]
	[Cpp2IlInjected.Address(RVA = "0x52BD890", Offset = "0x52BCA90", VA = "0x1852BD890", Slot = "9")]
	public void GHFFCHLHKOL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000393")]
	[Cpp2IlInjected.Address(RVA = "0x52BD240", Offset = "0x52BC440", VA = "0x1852BD240", Slot = "10")]
	public void DGCJEMMNGLK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000394")]
	[Cpp2IlInjected.Address(RVA = "0x6F84D0", Offset = "0x6F76D0", VA = "0x1806F84D0", Slot = "11")]
	public void NKAMGMBLDMK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000395")]
	[Cpp2IlInjected.Address(RVA = "0x52BD410", Offset = "0x52BC610", VA = "0x1852BD410")]
	private void DLIAOMALOAD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000396")]
	[Cpp2IlInjected.Address(RVA = "0x52BDCA0", Offset = "0x52BCEA0", VA = "0x1852BDCA0")]
	private void NLHAOKJLAIP()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200003F")]
internal sealed class JDLBPOEOJEH : KGGBOPCKBMM, BNAKOLNKNGH, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x170000F1")]
	public OEEBBDJIDDP PJJKMCINJBG
	{
		[Cpp2IlInjected.Token(Token = "0x6000397")]
		[Cpp2IlInjected.Address(RVA = "0x52B8C40", Offset = "0x52B7E40", VA = "0x1852B8C40", Slot = "4")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000398")]
		[Cpp2IlInjected.Address(RVA = "0x52B9860", Offset = "0x52B8A60", VA = "0x1852B9860", Slot = "5")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000F2")]
	public JIKDBJBLNKK GLMECOENJFF
	{
		[Cpp2IlInjected.Token(Token = "0x6000399")]
		[Cpp2IlInjected.Address(RVA = "0x52B8B10", Offset = "0x52B7D10", VA = "0x1852B8B10", Slot = "6")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600039A")]
		[Cpp2IlInjected.Address(RVA = "0x52B9B60", Offset = "0x52B8D60", VA = "0x1852B9B60", Slot = "7")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000F3")]
	public Vector3 BNMCMLCKBOK
	{
		[Cpp2IlInjected.Token(Token = "0x600039B")]
		[Cpp2IlInjected.Address(RVA = "0x52B9350", Offset = "0x52B8550", VA = "0x1852B9350", Slot = "8")]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x600039C")]
		[Cpp2IlInjected.Address(RVA = "0x52BB520", Offset = "0x52BA720", VA = "0x1852BB520", Slot = "9")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000F4")]
	public Vector3 PIHKAJHIGPH
	{
		[Cpp2IlInjected.Token(Token = "0x600039D")]
		[Cpp2IlInjected.Address(RVA = "0x52BAEB0", Offset = "0x52BA0B0", VA = "0x1852BAEB0", Slot = "10")]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x600039E")]
		[Cpp2IlInjected.Address(RVA = "0x52BAFC0", Offset = "0x52BA1C0", VA = "0x1852BAFC0", Slot = "11")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000F5")]
	public Vector3 IIALMKBBALJ
	{
		[Cpp2IlInjected.Token(Token = "0x600039F")]
		[Cpp2IlInjected.Address(RVA = "0x52BA910", Offset = "0x52B9B10", VA = "0x1852BA910", Slot = "12")]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x60003A0")]
		[Cpp2IlInjected.Address(RVA = "0x52B9580", Offset = "0x52B8780", VA = "0x1852B9580", Slot = "13")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000F6")]
	public Vector3 KAHCHGJGLPH
	{
		[Cpp2IlInjected.Token(Token = "0x60003A1")]
		[Cpp2IlInjected.Address(RVA = "0x52BAD90", Offset = "0x52B9F90", VA = "0x1852BAD90", Slot = "14")]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x60003A2")]
		[Cpp2IlInjected.Address(RVA = "0x52B8E60", Offset = "0x52B8060", VA = "0x1852B8E60", Slot = "15")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000F7")]
	public float LMKDGNICGIN
	{
		[Cpp2IlInjected.Token(Token = "0x60003A3")]
		[Cpp2IlInjected.Address(RVA = "0x52B94A0", Offset = "0x52B86A0", VA = "0x1852B94A0", Slot = "16")]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x60003A4")]
		[Cpp2IlInjected.Address(RVA = "0x52B9340", Offset = "0x52B8540", VA = "0x1852B9340", Slot = "17")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000F8")]
	public bool PHFFHNKCAKG
	{
		[Cpp2IlInjected.Token(Token = "0x60003A6")]
		[Cpp2IlInjected.Address(RVA = "0x52BC1D0", Offset = "0x52BB3D0", VA = "0x1852BC1D0", Slot = "18")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000F9")]
	private EJPBMJKJDKA PAIBJOCPBJA
	{
		[Cpp2IlInjected.Token(Token = "0x60003BA")]
		[Cpp2IlInjected.Address(RVA = "0x16E9550", Offset = "0x16E8750", VA = "0x1816E9550")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000FA")]
	private bool GCHJHCHGGCH
	{
		[Cpp2IlInjected.Token(Token = "0x60003BB")]
		[Cpp2IlInjected.Address(RVA = "0x52A3F10", Offset = "0x52A3110", VA = "0x1852A3F10")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60003A5")]
	[Cpp2IlInjected.Address(RVA = "0x52A2770", Offset = "0x52A1970", VA = "0x1852A2770")]
	public JDLBPOEOJEH(OINPHBHEBFM EHHPLBPDKBE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003A7")]
	[Cpp2IlInjected.Address(RVA = "0x52BAAC0", Offset = "0x52B9CC0", VA = "0x1852BAAC0", Slot = "20")]
	public void JGLKJDEBKJD(object IALNODEHBNN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003A8")]
	[Cpp2IlInjected.Address(RVA = "0x52B9770", Offset = "0x52B8970", VA = "0x1852B9770", Slot = "31")]
	public void EHJEMGCAHFC(object IALNODEHBNN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003A9")]
	[Cpp2IlInjected.Address(RVA = "0x52BA8A0", Offset = "0x52B9AA0", VA = "0x1852BA8A0", Slot = "19")]
	public void JDBMEAOELGO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003AA")]
	[Cpp2IlInjected.Address(RVA = "0x52B9640", Offset = "0x52B8840", VA = "0x1852B9640", Slot = "37")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003AB")]
	[Cpp2IlInjected.Address(RVA = "0x52BB740", Offset = "0x52BA940", VA = "0x1852BB740", Slot = "28")]
	public void NJINOCNPPGC(Rigidbody NBJEPCGIGPN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003AC")]
	[Cpp2IlInjected.Address(RVA = "0x52BABB0", Offset = "0x52B9DB0", VA = "0x1852BABB0", Slot = "36")]
	public Vector3 JLCJMKPHEDJ(Vector3 LMLFDADCHBI)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x60003AD")]
	[Cpp2IlInjected.Address(RVA = "0x52BA5B0", Offset = "0x52B97B0", VA = "0x1852BA5B0", Slot = "35")]
	public Vector3 HPOIKDMPEGF(Vector3 BPBFEPBHJOA)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x60003AE")]
	[Cpp2IlInjected.Address(RVA = "0x52BA8A0", Offset = "0x52B9AA0", VA = "0x1852BA8A0", Slot = "27")]
	public void OIHOBLKLMEH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003AF")]
	[Cpp2IlInjected.Address(RVA = "0x52B9950", Offset = "0x52B8B50", VA = "0x1852B9950", Slot = "25")]
	public void FFKNMCPIGAB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003B0")]
	[Cpp2IlInjected.Address(RVA = "0x52B8E90", Offset = "0x52B8090", VA = "0x1852B8E90", Slot = "24")]
	public void BCEKGKJPMMM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003B1")]
	[Cpp2IlInjected.Address(RVA = "0x52B9DB0", Offset = "0x52B8FB0", VA = "0x1852B9DB0", Slot = "34")]
	public void GLPKKFBJAKC(Vector3 PHMOADGIOAB, Vector3 FHAOAKNDIMF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003B2")]
	[Cpp2IlInjected.Address(RVA = "0x52BAA60", Offset = "0x52B9C60", VA = "0x1852BAA60", Slot = "33")]
	public void JGGAJCAAMOB(Vector3 LGOGCCAJHAG, Vector3 NMCANIJEPAA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003B3")]
	[Cpp2IlInjected.Address(RVA = "0x52BB5E0", Offset = "0x52BA7E0", VA = "0x1852BB5E0", Slot = "32")]
	public void MKJDMMPONGJ(Vector3 PLAPBHBFKOO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003B4")]
	[Cpp2IlInjected.Address(RVA = "0x52B8ED0", Offset = "0x52B80D0", VA = "0x1852B8ED0", Slot = "22")]
	public void CNBEOMCPCEP(LJPGLADCBCM AKMNMFJGAOB, Vector3 GDBGENEPKJJ, float JCOIPNJNGNL, float JCNBFPLMFDC = 8f, float NCEHNBMCDCP = 1f)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003B5")]
	[Cpp2IlInjected.Address(RVA = "0x52B9FF0", Offset = "0x52B91F0", VA = "0x1852B9FF0", Slot = "21")]
	public void HAMEOACBGEL(HKGKLOMPNFJ PLKHOFBGABO, Vector3 FLBMFCPCPEF, float OIOPGDDKGKH = float.PositiveInfinity)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003B6")]
	[Cpp2IlInjected.Address(RVA = "0x52BA2E0", Offset = "0x52B94E0", VA = "0x1852BA2E0", Slot = "23")]
	[Obsolete]
	public void HLLOHDECLDE(HKGKLOMPNFJ PLKHOFBGABO, Vector3 HEGBBJCMANH, float MJJDNDIGKOE = 7f, float KDGELBODBFF = 1f)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003B7")]
	[Cpp2IlInjected.Address(RVA = "0x52BB100", Offset = "0x52BA300", VA = "0x1852BB100", Slot = "30")]
	public Vector3 LKFCAEEDGGD(Vector3 OIEPDFJCEHE)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x60003B8")]
	[Cpp2IlInjected.Address(RVA = "0x52B8D70", Offset = "0x52B7F70", VA = "0x1852B8D70", Slot = "29")]
	public Vector3 AIJJDEBMEOJ(Vector3 MEBJBANMPLK)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x60003B9")]
	[Cpp2IlInjected.Address(RVA = "0x52BA770", Offset = "0x52B9970", VA = "0x1852BA770", Slot = "26")]
	public void IDHDDIPDPEN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003BC")]
	[Cpp2IlInjected.Address(RVA = "0x52B9990", Offset = "0x52B8B90", VA = "0x1852B9990")]
	private void FGCECCNOHHA(float IPMIIEAGJKC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003BD")]
	[Cpp2IlInjected.Address(RVA = "0x52B9C50", Offset = "0x52B8E50", VA = "0x1852B9C50")]
	private void GFCGPKJIELB(Vector3 FLBMFCPCPEF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003BE")]
	[Cpp2IlInjected.Address(RVA = "0x52BAFF0", Offset = "0x52BA1F0", VA = "0x1852BAFF0")]
	private Vector3 LGFOCDABPHD()
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x60003BF")]
	[Cpp2IlInjected.Address(RVA = "0x52BB780", Offset = "0x52BA980", VA = "0x1852BB780")]
	private void ODFONKFPKEI(Vector3 BPBFEPBHJOA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003C0")]
	[Cpp2IlInjected.Address(RVA = "0x52BBAC0", Offset = "0x52BACC0", VA = "0x1852BBAC0")]
	private Vector3 OLEFKCKECDC()
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x60003C1")]
	[Cpp2IlInjected.Address(RVA = "0x52BB1C0", Offset = "0x52BA3C0", VA = "0x1852BB1C0")]
	private void LPOFAPPMPPG(Vector3 IPMIIEAGJKC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003C2")]
	[Cpp2IlInjected.Address(RVA = "0x52BBBD0", Offset = "0x52BADD0", VA = "0x1852BBBD0")]
	private void PAGNADEDCHE(Vector3 BPBFEPBHJOA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003C3")]
	[Cpp2IlInjected.Address(RVA = "0x52BA220", Offset = "0x52B9420", VA = "0x1852BA220")]
	private void HKNNLIKIPEM()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000040")]
internal class KGGBOPCKBMM
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400005F")]
	protected readonly FPAEMFDCAME EHHPLBPDKBE;

	[Cpp2IlInjected.Token(Token = "0x170000FB")]
	protected APGPGBLMNNP EPGENHCJJPK
	{
		[Cpp2IlInjected.Token(Token = "0x60003C4")]
		[Cpp2IlInjected.Address(RVA = "0x52362D0", Offset = "0x52354D0", VA = "0x1852362D0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000FC")]
	protected HPHBHAKAACD GGFLINHGDJF
	{
		[Cpp2IlInjected.Token(Token = "0x60003C5")]
		[Cpp2IlInjected.Address(RVA = "0x52BE060", Offset = "0x52BD260", VA = "0x1852BE060")]
		get
		{
			return default(HPHBHAKAACD);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60003C6")]
	[Cpp2IlInjected.Address(RVA = "0x52A2770", Offset = "0x52A1970", VA = "0x1852A2770")]
	public KGGBOPCKBMM(OINPHBHEBFM EHHPLBPDKBE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003C7")]
	[Cpp2IlInjected.Address(RVA = "0x52BE090", Offset = "0x52BD290", VA = "0x1852BE090")]
	protected OINPHBHEBFM OEHHKGOLFMF(HPHBHAKAACD FLKGABKFAPI)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000041")]
public class HLFFOMOJIGM : OGOEFOMBPJH
{
	[Cpp2IlInjected.Token(Token = "0x60003C8")]
	[Cpp2IlInjected.Address(RVA = "0x52B4E70", Offset = "0x52B4070", VA = "0x1852B4E70", Slot = "4")]
	public ACEBILIFEIP EJNJPHFBJAM(OINPHBHEBFM IDCNELICAAG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003C9")]
	[Cpp2IlInjected.Address(RVA = "0x52B5230", Offset = "0x52B4430", VA = "0x1852B5230", Slot = "5")]
	public BNAKOLNKNGH OOJKGMEHDNF(OINPHBHEBFM IDCNELICAAG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003CA")]
	[Cpp2IlInjected.Address(RVA = "0x52B4A70", Offset = "0x52B3C70", VA = "0x1852B4A70", Slot = "6")]
	public OPBHABCMHHK CEEMIGDENAG(OINPHBHEBFM IDCNELICAAG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003CB")]
	[Cpp2IlInjected.Address(RVA = "0x52B50F0", Offset = "0x52B42F0", VA = "0x1852B50F0", Slot = "7")]
	public CAMJCFKKLPP MABBNAIELLP(OINPHBHEBFM IDCNELICAAG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003CC")]
	[Cpp2IlInjected.Address(RVA = "0x52B4B10", Offset = "0x52B3D10", VA = "0x1852B4B10", Slot = "8")]
	public GEILDFNHLPL CGFFJKNNLNE(OINPHBHEBFM IDCNELICAAG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003CD")]
	[Cpp2IlInjected.Address(RVA = "0x52B5050", Offset = "0x52B4250", VA = "0x1852B5050", Slot = "9")]
	public NOIDPDKILCA KOLDEJMAFHK(OINPHBHEBFM IDCNELICAAG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003CE")]
	[Cpp2IlInjected.Address(RVA = "0x52B49D0", Offset = "0x52B3BD0", VA = "0x1852B49D0", Slot = "10")]
	public KJLCKLHHAII BMLHJBKCGFH(OINPHBHEBFM IDCNELICAAG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003CF")]
	[Cpp2IlInjected.Address(RVA = "0x52B52D0", Offset = "0x52B44D0", VA = "0x1852B52D0", Slot = "11")]
	public EJPBMJKJDKA PAFCLIMBNAE(OINPHBHEBFM IDCNELICAAG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003D0")]
	[Cpp2IlInjected.Address(RVA = "0x52B5190", Offset = "0x52B4390", VA = "0x1852B5190", Slot = "12")]
	public CEEAALLPPCM OKEMMGAOJKM(OINPHBHEBFM IDCNELICAAG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003D1")]
	[Cpp2IlInjected.Address(RVA = "0x52B48C0", Offset = "0x52B3AC0", VA = "0x1852B48C0", Slot = "13")]
	public JIHFCAHMINI BFDNMJBGHBI(OINPHBHEBFM IDCNELICAAG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003D2")]
	[Cpp2IlInjected.Address(RVA = "0x52B4C20", Offset = "0x52B3E20", VA = "0x1852B4C20")]
	public COPEPEMIJFF FPJHOFIMCCE(OINPHBHEBFM IDCNELICAAG, in IPGEEHAGLOI PCPEJHIMHJJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003D3")]
	[Cpp2IlInjected.Address(RVA = "0x52B4800", Offset = "0x52B3A00", VA = "0x1852B4800")]
	public HDMHGHFDNPO FPADGNCCPBE(OINPHBHEBFM IDCNELICAAG, in IPGEEHAGLOI PCPEJHIMHJJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003D4")]
	[Cpp2IlInjected.Address(RVA = "0x52B4CE0", Offset = "0x52B3EE0", VA = "0x1852B4CE0")]
	public POMIHBCAKMM JCPGNOCGCJF(OINPHBHEBFM IDCNELICAAG, in IPGEEHAGLOI PCPEJHIMHJJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003D5")]
	[Cpp2IlInjected.Address(RVA = "0x52B4960", Offset = "0x52B3B60", VA = "0x1852B4960")]
	public KMFGIPGBMDB LFCHENHLEOJ(OINPHBHEBFM IDCNELICAAG, in IPGEEHAGLOI PCPEJHIMHJJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003D6")]
	[Cpp2IlInjected.Address(RVA = "0x52B4FE0", Offset = "0x52B41E0", VA = "0x1852B4FE0")]
	public KJDGGMNDKPF HMGIHLCDOBO(OINPHBHEBFM IDCNELICAAG, in IPGEEHAGLOI PCPEJHIMHJJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003D7")]
	[Cpp2IlInjected.Address(RVA = "0x52B4B70", Offset = "0x52B3D70", VA = "0x1852B4B70", Slot = "19")]
	public OINPHBHEBFM CLHPBOHHPLL(RigidbodyEx EHHPLBPDKBE, IPGEEHAGLOI PCPEJHIMHJJ, LNFAMCIHAGC ACDHNMANGFE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003D8")]
	[Cpp2IlInjected.Address(RVA = "0x703570", Offset = "0x702770", VA = "0x180703570")]
	public HLFFOMOJIGM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003D9")]
	[Cpp2IlInjected.Address(RVA = "0x52B4C20", Offset = "0x52B3E20", VA = "0x1852B4C20", Slot = "14")]
	private COPEPEMIJFF DDCOFFEPHGK(OINPHBHEBFM IDCNELICAAG, in IPGEEHAGLOI PCPEJHIMHJJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003DA")]
	[Cpp2IlInjected.Address(RVA = "0x52B4800", Offset = "0x52B3A00", VA = "0x1852B4800", Slot = "15")]
	private HDMHGHFDNPO AMDPCMJOHIN(OINPHBHEBFM IDCNELICAAG, in IPGEEHAGLOI PCPEJHIMHJJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003DB")]
	[Cpp2IlInjected.Address(RVA = "0x52B4CE0", Offset = "0x52B3EE0", VA = "0x1852B4CE0", Slot = "16")]
	private POMIHBCAKMM EGCJDLMOKDO(OINPHBHEBFM IDCNELICAAG, in IPGEEHAGLOI PCPEJHIMHJJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003DC")]
	[Cpp2IlInjected.Address(RVA = "0x52B4960", Offset = "0x52B3B60", VA = "0x1852B4960", Slot = "17")]
	private KMFGIPGBMDB BGPFOHNLJNL(OINPHBHEBFM IDCNELICAAG, in IPGEEHAGLOI PCPEJHIMHJJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003DD")]
	[Cpp2IlInjected.Address(RVA = "0x52B4FE0", Offset = "0x52B41E0", VA = "0x1852B4FE0", Slot = "18")]
	private KJDGGMNDKPF ICKAOJEOIEH(OINPHBHEBFM IDCNELICAAG, in IPGEEHAGLOI PCPEJHIMHJJ)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000042")]
[DefaultMember("Item")]
public sealed class DOPLKJCNONA : IReadOnlyList<OINPHBHEBFM>, IEnumerable<OINPHBHEBFM>, IEnumerable, IReadOnlyCollection<OINPHBHEBFM>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000060")]
	public readonly HPHBHAKAACD FLKGABKFAPI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000061")]
	public readonly APGPGBLMNNP BDIJLBAAEHA;

	[Cpp2IlInjected.Token(Token = "0x170000FD")]
	public int BPIIJGBNBGB
	{
		[Cpp2IlInjected.Token(Token = "0x60003E1")]
		[Cpp2IlInjected.Address(RVA = "0x52A82F0", Offset = "0x52A74F0", VA = "0x1852A82F0", Slot = "5")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000FE")]
	public OINPHBHEBFM POFBPBHJKPE
	{
		[Cpp2IlInjected.Token(Token = "0x60003E2")]
		[Cpp2IlInjected.Address(RVA = "0x52A83C0", Offset = "0x52A75C0", VA = "0x1852A83C0", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60003DE")]
	[Cpp2IlInjected.Address(RVA = "0x52A82A0", Offset = "0x52A74A0", VA = "0x1852A82A0")]
	public DOPLKJCNONA(HPHBHAKAACD FLKGABKFAPI, APGPGBLMNNP BDIJLBAAEHA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003DF")]
	[Cpp2IlInjected.Address(RVA = "0x52A8100", Offset = "0x52A7300", VA = "0x1852A8100", Slot = "6")]
	public IEnumerator<OINPHBHEBFM> GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003E0")]
	[Cpp2IlInjected.Address(RVA = "0x52A8100", Offset = "0x52A7300", VA = "0x1852A8100", Slot = "7")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003E3")]
	[Cpp2IlInjected.Address(RVA = "0x52A8290", Offset = "0x52A7490", VA = "0x1852A8290")]
	[CompilerGenerated]
	private OINPHBHEBFM HJEDJHAIKHO(int MLECAGAJCGO)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000043")]
[PNCLNBNALEO(typeof(OGOEFOMBPJH), new string[] { })]
public class MDGDBMFPOKL : OGOEFOMBPJH, CMLEAAEGAAL
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000062")]
	private readonly OGOEFOMBPJH BGDGGNMJPBJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000063")]
	private readonly OGOEFOMBPJH OPMONFEOPPL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000064")]
	private MFNEEGAKIKC JKCBLHNHOFH;

	[Cpp2IlInjected.Token(Token = "0x170000FF")]
	private OGOEFOMBPJH KGAOAOICALJ
	{
		[Cpp2IlInjected.Token(Token = "0x60003E5")]
		[Cpp2IlInjected.Address(RVA = "0x52C0CE0", Offset = "0x52BFEE0", VA = "0x1852C0CE0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60003E4")]
	[Cpp2IlInjected.Address(RVA = "0x52C0FC0", Offset = "0x52C01C0", VA = "0x1852C0FC0", Slot = "20")]
	public void PACELKAFLHO(BLBDINABANB LBBJCIBEDFD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003E6")]
	[Cpp2IlInjected.Address(RVA = "0x52C0B90", Offset = "0x52BFD90", VA = "0x1852C0B90", Slot = "4")]
	public ACEBILIFEIP EJNJPHFBJAM(OINPHBHEBFM IDCNELICAAG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003E7")]
	[Cpp2IlInjected.Address(RVA = "0x52C0F20", Offset = "0x52C0120", VA = "0x1852C0F20", Slot = "5")]
	public BNAKOLNKNGH OOJKGMEHDNF(OINPHBHEBFM IDCNELICAAG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003E8")]
	[Cpp2IlInjected.Address(RVA = "0x52C07A0", Offset = "0x52BF9A0", VA = "0x1852C07A0", Slot = "6")]
	public OPBHABCMHHK CEEMIGDENAG(OINPHBHEBFM IDCNELICAAG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003E9")]
	[Cpp2IlInjected.Address(RVA = "0x52C0DE0", Offset = "0x52BFFE0", VA = "0x1852C0DE0", Slot = "7")]
	public CAMJCFKKLPP MABBNAIELLP(OINPHBHEBFM IDCNELICAAG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003EA")]
	[Cpp2IlInjected.Address(RVA = "0x52C0840", Offset = "0x52BFA40", VA = "0x1852C0840", Slot = "8")]
	public GEILDFNHLPL CGFFJKNNLNE(OINPHBHEBFM IDCNELICAAG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003EB")]
	[Cpp2IlInjected.Address(RVA = "0x52C0D40", Offset = "0x52BFF40", VA = "0x1852C0D40", Slot = "9")]
	public NOIDPDKILCA KOLDEJMAFHK(OINPHBHEBFM IDCNELICAAG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003EC")]
	[Cpp2IlInjected.Address(RVA = "0x52C0700", Offset = "0x52BF900", VA = "0x1852C0700", Slot = "10")]
	public KJLCKLHHAII BMLHJBKCGFH(OINPHBHEBFM IDCNELICAAG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003ED")]
	[Cpp2IlInjected.Address(RVA = "0x52C1010", Offset = "0x52C0210", VA = "0x1852C1010", Slot = "11")]
	public EJPBMJKJDKA PAFCLIMBNAE(OINPHBHEBFM IDCNELICAAG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003EE")]
	[Cpp2IlInjected.Address(RVA = "0x52C0E80", Offset = "0x52C0080", VA = "0x1852C0E80", Slot = "12")]
	public CEEAALLPPCM OKEMMGAOJKM(OINPHBHEBFM IDCNELICAAG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003EF")]
	[Cpp2IlInjected.Address(RVA = "0x52C05B0", Offset = "0x52BF7B0", VA = "0x1852C05B0", Slot = "13")]
	public JIHFCAHMINI BFDNMJBGHBI(OINPHBHEBFM IDCNELICAAG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003F0")]
	[Cpp2IlInjected.Address(RVA = "0x52C0A30", Offset = "0x52BFC30", VA = "0x1852C0A30")]
	public COPEPEMIJFF FPJHOFIMCCE(OINPHBHEBFM IDCNELICAAG, in IPGEEHAGLOI PCPEJHIMHJJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003F1")]
	[Cpp2IlInjected.Address(RVA = "0x52C0500", Offset = "0x52BF700", VA = "0x1852C0500")]
	public HDMHGHFDNPO FPADGNCCPBE(OINPHBHEBFM IDCNELICAAG, in IPGEEHAGLOI PCPEJHIMHJJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003F2")]
	[Cpp2IlInjected.Address(RVA = "0x52C0AE0", Offset = "0x52BFCE0", VA = "0x1852C0AE0")]
	public POMIHBCAKMM JCPGNOCGCJF(OINPHBHEBFM IDCNELICAAG, in IPGEEHAGLOI PCPEJHIMHJJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003F3")]
	[Cpp2IlInjected.Address(RVA = "0x52C0650", Offset = "0x52BF850", VA = "0x1852C0650")]
	public KMFGIPGBMDB LFCHENHLEOJ(OINPHBHEBFM IDCNELICAAG, in IPGEEHAGLOI PCPEJHIMHJJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003F4")]
	[Cpp2IlInjected.Address(RVA = "0x52C0C30", Offset = "0x52BFE30", VA = "0x1852C0C30")]
	public KJDGGMNDKPF HMGIHLCDOBO(OINPHBHEBFM IDCNELICAAG, in IPGEEHAGLOI PCPEJHIMHJJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003F5")]
	[Cpp2IlInjected.Address(RVA = "0x52C08E0", Offset = "0x52BFAE0", VA = "0x1852C08E0", Slot = "19")]
	public OINPHBHEBFM CLHPBOHHPLL(RigidbodyEx EHHPLBPDKBE, IPGEEHAGLOI PCPEJHIMHJJ, LNFAMCIHAGC ACDHNMANGFE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003F6")]
	[Cpp2IlInjected.Address(RVA = "0x52C10B0", Offset = "0x52C02B0", VA = "0x1852C10B0")]
	public MDGDBMFPOKL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003F7")]
	[Cpp2IlInjected.Address(RVA = "0x52C0A30", Offset = "0x52BFC30", VA = "0x1852C0A30", Slot = "14")]
	private COPEPEMIJFF DDCOFFEPHGK(OINPHBHEBFM IDCNELICAAG, in IPGEEHAGLOI PCPEJHIMHJJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003F8")]
	[Cpp2IlInjected.Address(RVA = "0x52C0500", Offset = "0x52BF700", VA = "0x1852C0500", Slot = "15")]
	private HDMHGHFDNPO AMDPCMJOHIN(OINPHBHEBFM IDCNELICAAG, in IPGEEHAGLOI PCPEJHIMHJJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003F9")]
	[Cpp2IlInjected.Address(RVA = "0x52C0AE0", Offset = "0x52BFCE0", VA = "0x1852C0AE0", Slot = "16")]
	private POMIHBCAKMM EGCJDLMOKDO(OINPHBHEBFM IDCNELICAAG, in IPGEEHAGLOI PCPEJHIMHJJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003FA")]
	[Cpp2IlInjected.Address(RVA = "0x52C0650", Offset = "0x52BF850", VA = "0x1852C0650", Slot = "17")]
	private KMFGIPGBMDB BGPFOHNLJNL(OINPHBHEBFM IDCNELICAAG, in IPGEEHAGLOI PCPEJHIMHJJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003FB")]
	[Cpp2IlInjected.Address(RVA = "0x52C0C30", Offset = "0x52BFE30", VA = "0x1852C0C30", Slot = "18")]
	private KJDGGMNDKPF ICKAOJEOIEH(OINPHBHEBFM IDCNELICAAG, in IPGEEHAGLOI PCPEJHIMHJJ)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000044")]
[Preserve]
public sealed class GMIFALLGEPO : OINPHBHEBFM, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x4000065")]
	public static readonly GMIFALLGEPO OFDKPDDLIJC;

	[Cpp2IlInjected.Token(Token = "0x17000100")]
	public Rigidbody JMCCCFFEIIG
	{
		[Cpp2IlInjected.Token(Token = "0x600040E")]
		[Cpp2IlInjected.Address(RVA = "0x6FAB10", Offset = "0x6F9D10", VA = "0x1806FAB10", Slot = "4")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000101")]
	public RigidbodyEx LKJNPFKMFEJ
	{
		[Cpp2IlInjected.Token(Token = "0x600040F")]
		[Cpp2IlInjected.Address(RVA = "0x6FA000", Offset = "0x6F9200", VA = "0x1806FA000", Slot = "5")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000102")]
	public GameObject HCEKAIAAOOF
	{
		[Cpp2IlInjected.Token(Token = "0x6000410")]
		[Cpp2IlInjected.Address(RVA = "0x6F6390", Offset = "0x6F5590", VA = "0x1806F6390", Slot = "6")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000103")]
	public Transform DHGHIDOLKGM
	{
		[Cpp2IlInjected.Token(Token = "0x6000411")]
		[Cpp2IlInjected.Address(RVA = "0x75C710", Offset = "0x75B910", VA = "0x18075C710", Slot = "7")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000104")]
	public IEnumerable<object> MBNCNEFIHAG
	{
		[Cpp2IlInjected.Token(Token = "0x6000412")]
		[Cpp2IlInjected.Address(RVA = "0x75C700", Offset = "0x75B900", VA = "0x18075C700", Slot = "8")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000105")]
	public OINPHBHEBFM HKAHNOCIENG
	{
		[Cpp2IlInjected.Token(Token = "0x6000413")]
		[Cpp2IlInjected.Address(RVA = "0x6FB850", Offset = "0x6FAA50", VA = "0x1806FB850", Slot = "9")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000414")]
		[Cpp2IlInjected.Address(RVA = "0x814E40", Offset = "0x814040", VA = "0x180814E40", Slot = "10")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000106")]
	public IReadOnlyList<OINPHBHEBFM> NCLNEDAIDDA
	{
		[Cpp2IlInjected.Token(Token = "0x6000415")]
		[Cpp2IlInjected.Address(RVA = "0x813690", Offset = "0x812890", VA = "0x180813690", Slot = "11")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000107")]
	public OINPHBHEBFM CFHDLGEGDFD
	{
		[Cpp2IlInjected.Token(Token = "0x6000416")]
		[Cpp2IlInjected.Address(RVA = "0x75F110", Offset = "0x75E310", VA = "0x18075F110", Slot = "12")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000108")]
	public bool LLNINBLBFFN
	{
		[Cpp2IlInjected.Token(Token = "0x6000417")]
		[Cpp2IlInjected.Address(RVA = "0x6FD200", Offset = "0x6FC400", VA = "0x1806FD200", Slot = "13")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000109")]
	public bool NKELDOMJEGL
	{
		[Cpp2IlInjected.Token(Token = "0x6000418")]
		[Cpp2IlInjected.Address(RVA = "0xA106D0", Offset = "0xA0F8D0", VA = "0x180A106D0", Slot = "14")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700010A")]
	public bool DMMCOKOAOJI
	{
		[Cpp2IlInjected.Token(Token = "0x6000419")]
		[Cpp2IlInjected.Address(RVA = "0xA106E0", Offset = "0xA0F8E0", VA = "0x180A106E0", Slot = "15")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700010B")]
	public OEEBBDJIDDP PJJKMCINJBG
	{
		[Cpp2IlInjected.Token(Token = "0x600041A")]
		[Cpp2IlInjected.Address(RVA = "0x8532C0", Offset = "0x8524C0", VA = "0x1808532C0", Slot = "16")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600041B")]
		[Cpp2IlInjected.Address(RVA = "0x852DD0", Offset = "0x851FD0", VA = "0x180852DD0", Slot = "17")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700010C")]
	public JIKDBJBLNKK GLMECOENJFF
	{
		[Cpp2IlInjected.Token(Token = "0x600041C")]
		[Cpp2IlInjected.Address(RVA = "0x817390", Offset = "0x816590", VA = "0x180817390", Slot = "18")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600041D")]
		[Cpp2IlInjected.Address(RVA = "0x815C60", Offset = "0x814E60", VA = "0x180815C60", Slot = "19")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700010D")]
	public float LMKDGNICGIN
	{
		[Cpp2IlInjected.Token(Token = "0x600041E")]
		[Cpp2IlInjected.Address(RVA = "0xE5D200", Offset = "0xE5C400", VA = "0x180E5D200", Slot = "20")]
		[CompilerGenerated]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x600041F")]
		[Cpp2IlInjected.Address(RVA = "0xE5D2A0", Offset = "0xE5C4A0", VA = "0x180E5D2A0", Slot = "21")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700010E")]
	public Vector3 PIHKAJHIGPH
	{
		[Cpp2IlInjected.Token(Token = "0x6000420")]
		[Cpp2IlInjected.Address(RVA = "0x2C27F70", Offset = "0x2C27170", VA = "0x182C27F70", Slot = "22")]
		[CompilerGenerated]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x6000421")]
		[Cpp2IlInjected.Address(RVA = "0x2C27E70", Offset = "0x2C27070", VA = "0x182C27E70", Slot = "23")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700010F")]
	public Vector3 KAHCHGJGLPH
	{
		[Cpp2IlInjected.Token(Token = "0x6000422")]
		[Cpp2IlInjected.Address(RVA = "0x16A6E60", Offset = "0x16A6060", VA = "0x1816A6E60", Slot = "24")]
		[CompilerGenerated]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x6000423")]
		[Cpp2IlInjected.Address(RVA = "0x16A4C90", Offset = "0x16A3E90", VA = "0x1816A4C90", Slot = "25")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000110")]
	public Vector3 BNMCMLCKBOK
	{
		[Cpp2IlInjected.Token(Token = "0x6000424")]
		[Cpp2IlInjected.Address(RVA = "0x16A6E80", Offset = "0x16A6080", VA = "0x1816A6E80", Slot = "26")]
		[CompilerGenerated]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x6000425")]
		[Cpp2IlInjected.Address(RVA = "0x16A2890", Offset = "0x16A1A90", VA = "0x1816A2890", Slot = "27")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000111")]
	public Vector3 IIALMKBBALJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000426")]
		[Cpp2IlInjected.Address(RVA = "0xA7C580", Offset = "0xA7B780", VA = "0x180A7C580", Slot = "28")]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x6000427")]
		[Cpp2IlInjected.Address(RVA = "0x6F84D0", Offset = "0x6F76D0", VA = "0x1806F84D0", Slot = "29")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000112")]
	public bool CDFPEFIDNLO
	{
		[Cpp2IlInjected.Token(Token = "0x6000428")]
		[Cpp2IlInjected.Address(RVA = "0xAA6B80", Offset = "0xAA5D80", VA = "0x180AA6B80", Slot = "30")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000113")]
	public bool HGMNJFIAPOP
	{
		[Cpp2IlInjected.Token(Token = "0x6000429")]
		[Cpp2IlInjected.Address(RVA = "0xC24FC0", Offset = "0xC241C0", VA = "0x180C24FC0", Slot = "31")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000114")]
	public bool KEAFALNHKKC
	{
		[Cpp2IlInjected.Token(Token = "0x600042A")]
		[Cpp2IlInjected.Address(RVA = "0xC25000", Offset = "0xC24200", VA = "0x180C25000", Slot = "32")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000115")]
	public bool PHFFHNKCAKG
	{
		[Cpp2IlInjected.Token(Token = "0x600042B")]
		[Cpp2IlInjected.Address(RVA = "0xC25060", Offset = "0xC24260", VA = "0x180C25060", Slot = "33")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000116")]
	public Vector3 CEAFBIINOKH
	{
		[Cpp2IlInjected.Token(Token = "0x600042C")]
		[Cpp2IlInjected.Address(RVA = "0x10C0F20", Offset = "0x10C0120", VA = "0x1810C0F20", Slot = "34")]
		[CompilerGenerated]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000117")]
	public Vector3 NHENIPHGFOP
	{
		[Cpp2IlInjected.Token(Token = "0x600042D")]
		[Cpp2IlInjected.Address(RVA = "0xCAD5C0", Offset = "0xCAC7C0", VA = "0x180CAD5C0", Slot = "35")]
		[CompilerGenerated]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000118")]
	public Vector3 CMPGKEOHLJC
	{
		[Cpp2IlInjected.Token(Token = "0x600042E")]
		[Cpp2IlInjected.Address(RVA = "0xA7C580", Offset = "0xA7B780", VA = "0x180A7C580", Slot = "36")]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x600042F")]
		[Cpp2IlInjected.Address(RVA = "0x6F84D0", Offset = "0x6F76D0", VA = "0x1806F84D0", Slot = "37")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000119")]
	public Vector3 EIMEJLMMLMA
	{
		[Cpp2IlInjected.Token(Token = "0x6000430")]
		[Cpp2IlInjected.Address(RVA = "0x16A6F40", Offset = "0x16A6140", VA = "0x1816A6F40", Slot = "38")]
		[CompilerGenerated]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700011A")]
	public float EHLCHKMKGBK
	{
		[Cpp2IlInjected.Token(Token = "0x6000431")]
		[Cpp2IlInjected.Address(RVA = "0xA60D10", Offset = "0xA5FF10", VA = "0x180A60D10", Slot = "39")]
		[CompilerGenerated]
		get
		{
			return default(float);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700011B")]
	public float BENEGDAHFLL
	{
		[Cpp2IlInjected.Token(Token = "0x6000432")]
		[Cpp2IlInjected.Address(RVA = "0x908D40", Offset = "0x907F40", VA = "0x180908D40", Slot = "40")]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x6000433")]
		[Cpp2IlInjected.Address(RVA = "0x6F84D0", Offset = "0x6F76D0", VA = "0x1806F84D0", Slot = "41")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700011C")]
	public Vector3 NGJFIKPFMML
	{
		[Cpp2IlInjected.Token(Token = "0x6000434")]
		[Cpp2IlInjected.Address(RVA = "0xA7C580", Offset = "0xA7B780", VA = "0x180A7C580", Slot = "42")]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x6000435")]
		[Cpp2IlInjected.Address(RVA = "0x6F84D0", Offset = "0x6F76D0", VA = "0x1806F84D0", Slot = "43")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700011D")]
	public Quaternion LKICJOBKNGL
	{
		[Cpp2IlInjected.Token(Token = "0x6000436")]
		[Cpp2IlInjected.Address(RVA = "0xAE9B00", Offset = "0xAE8D00", VA = "0x180AE9B00", Slot = "44")]
		get
		{
			return default(Quaternion);
		}
		[Cpp2IlInjected.Token(Token = "0x6000437")]
		[Cpp2IlInjected.Address(RVA = "0x6F84D0", Offset = "0x6F76D0", VA = "0x1806F84D0", Slot = "45")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700011E")]
	public float PIPAENOKBKE
	{
		[Cpp2IlInjected.Token(Token = "0x6000438")]
		[Cpp2IlInjected.Address(RVA = "0x908D40", Offset = "0x907F40", VA = "0x180908D40", Slot = "46")]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x6000439")]
		[Cpp2IlInjected.Address(RVA = "0x6F84D0", Offset = "0x6F76D0", VA = "0x1806F84D0", Slot = "47")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700011F")]
	public float HGOJLGHHICI
	{
		[Cpp2IlInjected.Token(Token = "0x600043A")]
		[Cpp2IlInjected.Address(RVA = "0x908D40", Offset = "0x907F40", VA = "0x180908D40", Slot = "48")]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x600043B")]
		[Cpp2IlInjected.Address(RVA = "0x6F84D0", Offset = "0x6F76D0", VA = "0x1806F84D0", Slot = "49")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000120")]
	public bool NFPCLOGDCAI
	{
		[Cpp2IlInjected.Token(Token = "0x600043C")]
		[Cpp2IlInjected.Address(RVA = "0x6F83F0", Offset = "0x6F75F0", VA = "0x1806F83F0", Slot = "50")]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x600043D")]
		[Cpp2IlInjected.Address(RVA = "0x6F84D0", Offset = "0x6F76D0", VA = "0x1806F84D0", Slot = "51")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000121")]
	public bool PCILGMNHDNA
	{
		[Cpp2IlInjected.Token(Token = "0x600043E")]
		[Cpp2IlInjected.Address(RVA = "0x6F83F0", Offset = "0x6F75F0", VA = "0x1806F83F0")]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x600043F")]
		[Cpp2IlInjected.Address(RVA = "0x6F84D0", Offset = "0x6F76D0", VA = "0x1806F84D0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000122")]
	public HHLALPMEMBB AJFBHNJDDCE
	{
		[Cpp2IlInjected.Token(Token = "0x6000440")]
		[Cpp2IlInjected.Address(RVA = "0x6F83F0", Offset = "0x6F75F0", VA = "0x1806F83F0", Slot = "52")]
		get
		{
			return default(HHLALPMEMBB);
		}
		[Cpp2IlInjected.Token(Token = "0x6000441")]
		[Cpp2IlInjected.Address(RVA = "0x6F84D0", Offset = "0x6F76D0", VA = "0x1806F84D0", Slot = "53")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000123")]
	public bool KFFOOLFOADP
	{
		[Cpp2IlInjected.Token(Token = "0x6000442")]
		[Cpp2IlInjected.Address(RVA = "0x1A2F090", Offset = "0x1A2E290", VA = "0x181A2F090", Slot = "54")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000124")]
	public Transform ABGJKHNEALI
	{
		[Cpp2IlInjected.Token(Token = "0x6000443")]
		[Cpp2IlInjected.Address(RVA = "0xA449E0", Offset = "0xA43BE0", VA = "0x180A449E0", Slot = "55")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000125")]
	public Transform LCAKADOIIEB
	{
		[Cpp2IlInjected.Token(Token = "0x6000444")]
		[Cpp2IlInjected.Address(RVA = "0x97E990", Offset = "0x97DB90", VA = "0x18097E990", Slot = "56")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000126")]
	public Vector3 ABELHODFPEO
	{
		[Cpp2IlInjected.Token(Token = "0x6000445")]
		[Cpp2IlInjected.Address(RVA = "0xA7C580", Offset = "0xA7B780", VA = "0x180A7C580", Slot = "57")]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x6000446")]
		[Cpp2IlInjected.Address(RVA = "0x6F84D0", Offset = "0x6F76D0", VA = "0x1806F84D0", Slot = "58")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000127")]
	public float FDENPIIEFIG
	{
		[Cpp2IlInjected.Token(Token = "0x6000447")]
		[Cpp2IlInjected.Address(RVA = "0x908D40", Offset = "0x907F40", VA = "0x180908D40", Slot = "59")]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x6000448")]
		[Cpp2IlInjected.Address(RVA = "0x6F84D0", Offset = "0x6F76D0", VA = "0x1806F84D0", Slot = "60")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000128")]
	public float OMJLKOFJKHD
	{
		[Cpp2IlInjected.Token(Token = "0x6000449")]
		[Cpp2IlInjected.Address(RVA = "0x908D40", Offset = "0x907F40", VA = "0x180908D40", Slot = "61")]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x600044A")]
		[Cpp2IlInjected.Address(RVA = "0x6F84D0", Offset = "0x6F76D0", VA = "0x1806F84D0", Slot = "62")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000129")]
	public Quaternion MIDFMPBGHMA
	{
		[Cpp2IlInjected.Token(Token = "0x600044B")]
		[Cpp2IlInjected.Address(RVA = "0x920230", Offset = "0x91F430", VA = "0x180920230", Slot = "63")]
		get
		{
			return default(Quaternion);
		}
		[Cpp2IlInjected.Token(Token = "0x600044C")]
		[Cpp2IlInjected.Address(RVA = "0x6F84D0", Offset = "0x6F76D0", VA = "0x1806F84D0", Slot = "64")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700012A")]
	public Vector3 KIJJFLMPGME
	{
		[Cpp2IlInjected.Token(Token = "0x600044D")]
		[Cpp2IlInjected.Address(RVA = "0xA7C580", Offset = "0xA7B780", VA = "0x180A7C580", Slot = "65")]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x600044E")]
		[Cpp2IlInjected.Address(RVA = "0x6F84D0", Offset = "0x6F76D0", VA = "0x1806F84D0", Slot = "66")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700012B")]
	public Quaternion NELEDPLLGGE
	{
		[Cpp2IlInjected.Token(Token = "0x600044F")]
		[Cpp2IlInjected.Address(RVA = "0x920230", Offset = "0x91F430", VA = "0x180920230", Slot = "67")]
		get
		{
			return default(Quaternion);
		}
		[Cpp2IlInjected.Token(Token = "0x6000450")]
		[Cpp2IlInjected.Address(RVA = "0x6F84D0", Offset = "0x6F76D0", VA = "0x1806F84D0", Slot = "68")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700012C")]
	public RigidbodyConstraints PILCFECIKIL
	{
		[Cpp2IlInjected.Token(Token = "0x6000451")]
		[Cpp2IlInjected.Address(RVA = "0x6F8490", Offset = "0x6F7690", VA = "0x1806F8490", Slot = "69")]
		get
		{
			return default(RigidbodyConstraints);
		}
		[Cpp2IlInjected.Token(Token = "0x6000452")]
		[Cpp2IlInjected.Address(RVA = "0x6F84D0", Offset = "0x6F76D0", VA = "0x1806F84D0", Slot = "70")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700012D")]
	public bool ADJEMOAFAPK
	{
		[Cpp2IlInjected.Token(Token = "0x6000453")]
		[Cpp2IlInjected.Address(RVA = "0x6F83F0", Offset = "0x6F75F0", VA = "0x1806F83F0", Slot = "71")]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000454")]
		[Cpp2IlInjected.Address(RVA = "0x6F84D0", Offset = "0x6F76D0", VA = "0x1806F84D0", Slot = "72")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700012E")]
	public CollisionDetectionMode FEOBMNMPKBK
	{
		[Cpp2IlInjected.Token(Token = "0x6000455")]
		[Cpp2IlInjected.Address(RVA = "0x6F8490", Offset = "0x6F7690", VA = "0x1806F8490", Slot = "73")]
		get
		{
			return default(CollisionDetectionMode);
		}
		[Cpp2IlInjected.Token(Token = "0x6000456")]
		[Cpp2IlInjected.Address(RVA = "0x6F84D0", Offset = "0x6F76D0", VA = "0x1806F84D0", Slot = "74")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700012F")]
	public bool GCHJHCHGGCH
	{
		[Cpp2IlInjected.Token(Token = "0x6000457")]
		[Cpp2IlInjected.Address(RVA = "0xAF1420", Offset = "0xAF0620", VA = "0x180AF1420", Slot = "75")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000038")]
	public event FGJCBPBEFOP PBANFIJELBE
	{
		[Cpp2IlInjected.Token(Token = "0x60003FC")]
		[Cpp2IlInjected.Address(RVA = "0x6F84D0", Offset = "0x6F76D0", VA = "0x1806F84D0", Slot = "81")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60003FD")]
		[Cpp2IlInjected.Address(RVA = "0x6F84D0", Offset = "0x6F76D0", VA = "0x1806F84D0", Slot = "82")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000039")]
	public event FGJCBPBEFOP MGANLNPCDNF
	{
		[Cpp2IlInjected.Token(Token = "0x60003FE")]
		[Cpp2IlInjected.Address(RVA = "0x6F84D0", Offset = "0x6F76D0", VA = "0x1806F84D0", Slot = "83")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60003FF")]
		[Cpp2IlInjected.Address(RVA = "0x6F84D0", Offset = "0x6F76D0", VA = "0x1806F84D0", Slot = "84")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400003A")]
	public event OHFGCHALJBC CLHKPMHNJGH
	{
		[Cpp2IlInjected.Token(Token = "0x6000400")]
		[Cpp2IlInjected.Address(RVA = "0x6F84D0", Offset = "0x6F76D0", VA = "0x1806F84D0", Slot = "85")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000401")]
		[Cpp2IlInjected.Address(RVA = "0x6F84D0", Offset = "0x6F76D0", VA = "0x1806F84D0", Slot = "86")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400003B")]
	public event FGJCBPBEFOP EBDIBBFMNAG
	{
		[Cpp2IlInjected.Token(Token = "0x6000402")]
		[Cpp2IlInjected.Address(RVA = "0x6F84D0", Offset = "0x6F76D0", VA = "0x1806F84D0", Slot = "88")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000403")]
		[Cpp2IlInjected.Address(RVA = "0x6F84D0", Offset = "0x6F76D0", VA = "0x1806F84D0", Slot = "89")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400003C")]
	public event FGJCBPBEFOP HLDPKPODLLN
	{
		[Cpp2IlInjected.Token(Token = "0x6000404")]
		[Cpp2IlInjected.Address(RVA = "0x6F84D0", Offset = "0x6F76D0", VA = "0x1806F84D0", Slot = "108")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000405")]
		[Cpp2IlInjected.Address(RVA = "0x6F84D0", Offset = "0x6F76D0", VA = "0x1806F84D0", Slot = "109")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400003D")]
	public event FGJCBPBEFOP MLKAKEPMHOI
	{
		[Cpp2IlInjected.Token(Token = "0x6000406")]
		[Cpp2IlInjected.Address(RVA = "0x6F84D0", Offset = "0x6F76D0", VA = "0x1806F84D0", Slot = "113")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000407")]
		[Cpp2IlInjected.Address(RVA = "0x6F84D0", Offset = "0x6F76D0", VA = "0x1806F84D0", Slot = "114")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400003E")]
	public event Action<AMBBOEBJPNH, AMBBOEBJPNH> FIKAFLHBAHL
	{
		[Cpp2IlInjected.Token(Token = "0x6000408")]
		[Cpp2IlInjected.Address(RVA = "0x6F84D0", Offset = "0x6F76D0", VA = "0x1806F84D0", Slot = "117")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000409")]
		[Cpp2IlInjected.Address(RVA = "0x6F84D0", Offset = "0x6F76D0", VA = "0x1806F84D0", Slot = "118")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400003F")]
	public event FGJCBPBEFOP FGLCADMIKCE
	{
		[Cpp2IlInjected.Token(Token = "0x600040A")]
		[Cpp2IlInjected.Address(RVA = "0x6F84D0", Offset = "0x6F76D0", VA = "0x1806F84D0", Slot = "119")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600040B")]
		[Cpp2IlInjected.Address(RVA = "0x6F84D0", Offset = "0x6F76D0", VA = "0x1806F84D0", Slot = "120")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000040")]
	public event FGJCBPBEFOP MGBAEGFBPNJ
	{
		[Cpp2IlInjected.Token(Token = "0x600040C")]
		[Cpp2IlInjected.Address(RVA = "0x6F84D0", Offset = "0x6F76D0", VA = "0x1806F84D0", Slot = "125")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600040D")]
		[Cpp2IlInjected.Address(RVA = "0x6F84D0", Offset = "0x6F76D0", VA = "0x1806F84D0", Slot = "126")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000458")]
	[Cpp2IlInjected.Address(RVA = "0x6F84D0", Offset = "0x6F76D0", VA = "0x1806F84D0", Slot = "76")]
	public void JDBMEAOELGO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000459")]
	[Cpp2IlInjected.Address(RVA = "0x6F84D0", Offset = "0x6F76D0", VA = "0x1806F84D0", Slot = "77")]
	public void LDBOEGKIPKO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600045A")]
	[Cpp2IlInjected.Address(RVA = "0x6F84D0", Offset = "0x6F76D0", VA = "0x1806F84D0", Slot = "78")]
	public void LJODMHLJPAD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600045B")]
	[Cpp2IlInjected.Address(RVA = "0x6F84D0", Offset = "0x6F76D0", VA = "0x1806F84D0", Slot = "79")]
	public void HILGCFFPCIP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600045C")]
	[Cpp2IlInjected.Address(RVA = "0x6F84D0", Offset = "0x6F76D0", VA = "0x1806F84D0", Slot = "80")]
	public void NLGFHJEKOON()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600045D")]
	[Cpp2IlInjected.Address(RVA = "0x6F84D0", Offset = "0x6F76D0", VA = "0x1806F84D0", Slot = "141")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600045E")]
	[Cpp2IlInjected.Address(RVA = "0x6F84D0", Offset = "0x6F76D0", VA = "0x1806F84D0", Slot = "87")]
	public void HMBNJDPGAJN(OINPHBHEBFM IPMIIEAGJKC, bool LDEEGDEKBLJ = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600045F")]
	[Cpp2IlInjected.Address(RVA = "0x6F84D0", Offset = "0x6F76D0", VA = "0x1806F84D0", Slot = "90")]
	public void JPAMNHEGNMA(object IALNODEHBNN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000460")]
	[Cpp2IlInjected.Address(RVA = "0x6F84D0", Offset = "0x6F76D0", VA = "0x1806F84D0", Slot = "91")]
	public void JECFPOIDGHE(object IALNODEHBNN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000461")]
	[Cpp2IlInjected.Address(RVA = "0xA7C580", Offset = "0xA7B780", VA = "0x180A7C580", Slot = "92")]
	public Vector3 JLCJMKPHEDJ(Vector3 LMLFDADCHBI)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000462")]
	[Cpp2IlInjected.Address(RVA = "0xA7C580", Offset = "0xA7B780", VA = "0x180A7C580", Slot = "93")]
	public Vector3 HPOIKDMPEGF(Vector3 BPBFEPBHJOA)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000463")]
	[Cpp2IlInjected.Address(RVA = "0x6F84D0", Offset = "0x6F76D0", VA = "0x1806F84D0", Slot = "94")]
	public void OIHOBLKLMEH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000464")]
	[Cpp2IlInjected.Address(RVA = "0x6F84D0", Offset = "0x6F76D0", VA = "0x1806F84D0", Slot = "95")]
	public void FFKNMCPIGAB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000465")]
	[Cpp2IlInjected.Address(RVA = "0x6F84D0", Offset = "0x6F76D0", VA = "0x1806F84D0", Slot = "96")]
	public void BCEKGKJPMMM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000466")]
	[Cpp2IlInjected.Address(RVA = "0x6F84D0", Offset = "0x6F76D0", VA = "0x1806F84D0", Slot = "97")]
	public void GLPKKFBJAKC(Vector3 PHMOADGIOAB, Vector3 FHAOAKNDIMF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000467")]
	[Cpp2IlInjected.Address(RVA = "0x6F84D0", Offset = "0x6F76D0", VA = "0x1806F84D0", Slot = "98")]
	public void JGGAJCAAMOB(Vector3 LGOGCCAJHAG, Vector3 NMCANIJEPAA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000468")]
	[Cpp2IlInjected.Address(RVA = "0x6F84D0", Offset = "0x6F76D0", VA = "0x1806F84D0", Slot = "99")]
	public void MKJDMMPONGJ(Vector3 PLAPBHBFKOO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000469")]
	[Cpp2IlInjected.Address(RVA = "0x6F84D0", Offset = "0x6F76D0", VA = "0x1806F84D0", Slot = "100")]
	public void CNBEOMCPCEP(LJPGLADCBCM AKMNMFJGAOB, Vector3 GDBGENEPKJJ, float JCOIPNJNGNL, float JCNBFPLMFDC = 8f, float NCEHNBMCDCP = 1f)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600046A")]
	[Cpp2IlInjected.Address(RVA = "0x6F84D0", Offset = "0x6F76D0", VA = "0x1806F84D0", Slot = "101")]
	public void HAMEOACBGEL(HKGKLOMPNFJ PLKHOFBGABO, Vector3 FLBMFCPCPEF, float OIOPGDDKGKH = float.PositiveInfinity)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600046B")]
	[Cpp2IlInjected.Address(RVA = "0x6F84D0", Offset = "0x6F76D0", VA = "0x1806F84D0", Slot = "102")]
	public void HLLOHDECLDE(HKGKLOMPNFJ PLKHOFBGABO, Vector3 HEGBBJCMANH, float MJJDNDIGKOE = 7f, float KDGELBODBFF = 1f)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600046C")]
	[Cpp2IlInjected.Address(RVA = "0xA7C580", Offset = "0xA7B780", VA = "0x180A7C580", Slot = "103")]
	public Vector3 LKFCAEEDGGD(Vector3 IPMIIEAGJKC)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x600046D")]
	[Cpp2IlInjected.Address(RVA = "0xA7C580", Offset = "0xA7B780", VA = "0x180A7C580", Slot = "104")]
	public Vector3 AIJJDEBMEOJ(Vector3 IPMIIEAGJKC)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x600046E")]
	[Cpp2IlInjected.Address(RVA = "0x6F84D0", Offset = "0x6F76D0", VA = "0x1806F84D0", Slot = "105")]
	public void IDHDDIPDPEN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600046F")]
	[Cpp2IlInjected.Address(RVA = "0x6F84D0", Offset = "0x6F76D0", VA = "0x1806F84D0", Slot = "106")]
	public void AILDDDNLPHO(OINPHBHEBFM LBILOIKCIOK, object IALNODEHBNN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000470")]
	[Cpp2IlInjected.Address(RVA = "0x6F84D0", Offset = "0x6F76D0", VA = "0x1806F84D0", Slot = "107")]
	public void HELNOLDOAMO(object IALNODEHBNN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000471")]
	[Cpp2IlInjected.Address(RVA = "0x6F84D0", Offset = "0x6F76D0", VA = "0x1806F84D0", Slot = "110")]
	public void LILDLMIHEAF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000472")]
	[Cpp2IlInjected.Address(RVA = "0x6F84D0", Offset = "0x6F76D0", VA = "0x1806F84D0", Slot = "111")]
	public void OLIDEBFPCBJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000473")]
	[Cpp2IlInjected.Address(RVA = "0x6F84D0", Offset = "0x6F76D0", VA = "0x1806F84D0", Slot = "112")]
	public void KJCFGELAPLM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000474")]
	[Cpp2IlInjected.Address(RVA = "0x6F83F0", Offset = "0x6F75F0", VA = "0x1806F83F0", Slot = "115")]
	public bool JIPELJMHGEE()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000475")]
	[Cpp2IlInjected.Address(RVA = "0x6F84D0", Offset = "0x6F76D0", VA = "0x1806F84D0", Slot = "116")]
	public void EMMDJJNLKHB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000476")]
	[Cpp2IlInjected.Address(RVA = "0x6F8490", Offset = "0x6F7690", VA = "0x1806F8490", Slot = "121")]
	public IDisposable EEBIOLKMNJN()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000477")]
	[Cpp2IlInjected.Address(RVA = "0x6F84D0", Offset = "0x6F76D0", VA = "0x1806F84D0", Slot = "122")]
	public void ANNHOHNEGBC(object IALNODEHBNN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000478")]
	[Cpp2IlInjected.Address(RVA = "0x6F84D0", Offset = "0x6F76D0", VA = "0x1806F84D0", Slot = "123")]
	public void DIACCKFBBFC(object IALNODEHBNN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000479")]
	[Cpp2IlInjected.Address(RVA = "0x6F84D0", Offset = "0x6F76D0", VA = "0x1806F84D0", Slot = "124")]
	public void IMCEFNKDLJE(object IALNODEHBNN, bool DKKAHPAOACL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600047A")]
	[Cpp2IlInjected.Address(RVA = "0x6F84D0", Offset = "0x6F76D0", VA = "0x1806F84D0", Slot = "127")]
	public void IJJADLBMFDP(Vector3 GACEEHCHKKI, Quaternion EMJCGIGPJKI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600047B")]
	[Cpp2IlInjected.Address(RVA = "0x6F84D0", Offset = "0x6F76D0", VA = "0x1806F84D0", Slot = "128")]
	public void ODKKDCFIJOF(Vector3 FJDPKNPNDDO, Quaternion CPOKLKIGKAG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600047C")]
	[Cpp2IlInjected.Address(RVA = "0x6F83F0", Offset = "0x6F75F0", VA = "0x1806F83F0", Slot = "129")]
	public bool PCEMENCMDLB(float LJCAHLAFIEP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600047D")]
	[Cpp2IlInjected.Address(RVA = "0x6F84D0", Offset = "0x6F76D0", VA = "0x1806F84D0", Slot = "130")]
	public void MHDBMJDNLON(object IALNODEHBNN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600047E")]
	[Cpp2IlInjected.Address(RVA = "0x6F84D0", Offset = "0x6F76D0", VA = "0x1806F84D0", Slot = "131")]
	public void ICLJJAAMJBD(object IALNODEHBNN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600047F")]
	[Cpp2IlInjected.Address(RVA = "0x6F84D0", Offset = "0x6F76D0", VA = "0x1806F84D0", Slot = "132")]
	public void IKBIHMLDNON(object IALNODEHBNN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000480")]
	[Cpp2IlInjected.Address(RVA = "0x6F84D0", Offset = "0x6F76D0", VA = "0x1806F84D0", Slot = "133")]
	public void AIKKIMKHEPL(object IALNODEHBNN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000481")]
	[Cpp2IlInjected.Address(RVA = "0x6F84D0", Offset = "0x6F76D0", VA = "0x1806F84D0", Slot = "134")]
	public void OPLMNHEAGKL(Vector3 COPOILGLIAJ, ForceMode OJOAKAEAKAC = ForceMode.Force)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000482")]
	[Cpp2IlInjected.Address(RVA = "0x6F84D0", Offset = "0x6F76D0", VA = "0x1806F84D0", Slot = "135")]
	public void FLNNLAIJPLD(Vector3 COPOILGLIAJ, Vector3 INLGLHIPOMC, ForceMode OJOAKAEAKAC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000483")]
	[Cpp2IlInjected.Address(RVA = "0x6F84D0", Offset = "0x6F76D0", VA = "0x1806F84D0", Slot = "136")]
	public void FLJCPNJHDAE(Vector3 HMKLOLJGHPK, ForceMode OJOAKAEAKAC = ForceMode.Force)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000484")]
	[Cpp2IlInjected.Address(RVA = "0x6F84D0", Offset = "0x6F76D0", VA = "0x1806F84D0", Slot = "137")]
	public void DLOBEAKDAFF(Vector3 HMKLOLJGHPK, ForceMode OJOAKAEAKAC = ForceMode.Force)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000485")]
	[Cpp2IlInjected.Address(RVA = "0x52B2CE0", Offset = "0x52B1EE0", VA = "0x1852B2CE0", Slot = "138")]
	public bool FHJIOGHMPNH(Vector3 HLFIBIDOLEF, out RaycastHit KNFIEECFHPI, float GKJHODLJDHD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000486")]
	[Cpp2IlInjected.Address(RVA = "0x6F84D0", Offset = "0x6F76D0", VA = "0x1806F84D0", Slot = "139")]
	public void AMMOJMDCBMC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000487")]
	[Cpp2IlInjected.Address(RVA = "0x703570", Offset = "0x702770", VA = "0x180703570")]
	public GMIFALLGEPO()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000045")]
public sealed class FPAEMFDCAME : FFNHAGGANGK, AEPAMCILECN, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
	[Cpp2IlInjected.Token(Token = "0x4000083")]
	internal HPHBHAKAACD FLKGABKFAPI;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
	[Cpp2IlInjected.Token(Token = "0x4000084")]
	internal APGPGBLMNNP EDOCMOEILLH;

	[Cpp2IlInjected.Token(Token = "0x6000489")]
	[Cpp2IlInjected.Address(RVA = "0x52AF650", Offset = "0x52AE850", VA = "0x1852AF650")]
	public FPAEMFDCAME(GameObject BMNLOPDIJGF, RigidbodyEx NJFHMJJGBJJ, LNFAMCIHAGC ACDHNMANGFE, in IPGEEHAGLOI PCPEJHIMHJJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600048A")]
	[Cpp2IlInjected.Address(RVA = "0x52AF2F0", Offset = "0x52AE4F0", VA = "0x1852AF2F0", Slot = "142")]
	protected override void KJODCDCKGLH(LNFAMCIHAGC ACDHNMANGFE, IPGEEHAGLOI PCPEJHIMHJJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600048B")]
	[Cpp2IlInjected.Address(RVA = "0x52AF040", Offset = "0x52AE240", VA = "0x1852AF040", Slot = "143")]
	public override void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600048C")]
	[Cpp2IlInjected.Address(RVA = "0x52AF580", Offset = "0x52AE780", VA = "0x1852AF580", Slot = "145")]
	public void LKLNCHMDODC(AIDCDLFPLAF HKPEMIJGIMD, AIDCDLFPLAF INPBMNIIHJJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600048D")]
	[Cpp2IlInjected.Address(RVA = "0x52AF230", Offset = "0x52AE430", VA = "0x1852AF230", Slot = "146")]
	public void HCPDOMPHDGL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600048E")]
	[Cpp2IlInjected.Address(RVA = "0x52AEF80", Offset = "0x52AE180", VA = "0x1852AEF80", Slot = "147")]
	public void DNNLBEEPHPL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600048F")]
	[Cpp2IlInjected.Address(RVA = "0x52AF1D0", Offset = "0x52AE3D0", VA = "0x1852AF1D0", Slot = "148")]
	public void EGIBKKKFHBP(bool JJOFBIIKAHB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000490")]
	[Cpp2IlInjected.Address(RVA = "0x52AEE20", Offset = "0x52AE020", VA = "0x1852AEE20", Slot = "149")]
	public bool CDBIIFGOIKO()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000491")]
	[Cpp2IlInjected.Address(RVA = "0x6F84D0", Offset = "0x6F76D0", VA = "0x1806F84D0", Slot = "144")]
	public override void NLGFHJEKOON()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000046")]
internal static class GMNFBDLHGDB
{
	[Cpp2IlInjected.Token(Token = "0x6000492")]
	[Cpp2IlInjected.Address(RVA = "0x52B2D60", Offset = "0x52B1F60", VA = "0x1852B2D60")]
	public static FFNHAGGANGK OGFMLMGPOKE(this OINPHBHEBFM IDCNELICAAG)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000047")]
public interface MFACNIJADCN : ACEBILIFEIP, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x6000493")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void HDJNLHIMONE(OINPHBHEBFM EHHPLBPDKBE);

	[Cpp2IlInjected.Token(Token = "0x6000494")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void DFCNILODFON(OINPHBHEBFM EHHPLBPDKBE);

	[Cpp2IlInjected.Token(Token = "0x6000495")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void GNNBGIOKGLJ(OINPHBHEBFM DLHNFCJIJJD);

	[Cpp2IlInjected.Token(Token = "0x6000496")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void PAINNLINJFA(OINPHBHEBFM DLHNFCJIJJD);
}
[Cpp2IlInjected.Token(Token = "0x2000048")]
public interface CPAKIGNIADK : OPBHABCMHHK
{
	[Cpp2IlInjected.Token(Token = "0x17000130")]
	global::MKJNCDLHHNA<OINPHBHEBFM> GCPMKIEAPKF
	{
		[Cpp2IlInjected.Token(Token = "0x6000497")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000131")]
	OINPHBHEBFM OEPBOFMCNBN
	{
		[Cpp2IlInjected.Token(Token = "0x6000498")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000049")]
public interface NOFINPJFCLP : KMFGIPGBMDB
{
	[Cpp2IlInjected.Token(Token = "0x6000499")]
	[Cpp2IlInjected.Address(Slot = "0")]
	(float, Vector3) KNMMHOMBDMC(Rigidbody DJLPCBPBOHF);
}
[Cpp2IlInjected.Token(Token = "0x200004A")]
public interface GHHJPNLPLLI : HDMHGHFDNPO, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x17000132")]
	PhotonView BEPJHNBHMKL
	{
		[Cpp2IlInjected.Token(Token = "0x600049A")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x200004B")]
internal sealed class BBHEGMJIEOG : CEEAALLPPCM
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000085")]
	private readonly FFNHAGGANGK EHHPLBPDKBE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000086")]
	private CollisionDetectionMode DAIDKFPNGGA;

	[Cpp2IlInjected.Token(Token = "0x17000133")]
	private Rigidbody JMCCCFFEIIG
	{
		[Cpp2IlInjected.Token(Token = "0x600049B")]
		[Cpp2IlInjected.Address(RVA = "0x52A2720", Offset = "0x52A1920", VA = "0x1852A2720")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000134")]
	public CollisionDetectionMode FEOBMNMPKBK
	{
		[Cpp2IlInjected.Token(Token = "0x600049F")]
		[Cpp2IlInjected.Address(RVA = "0x52A3590", Offset = "0x52A2790", VA = "0x1852A3590", Slot = "4")]
		get
		{
			return default(CollisionDetectionMode);
		}
		[Cpp2IlInjected.Token(Token = "0x60004A0")]
		[Cpp2IlInjected.Address(RVA = "0x52A37D0", Offset = "0x52A29D0", VA = "0x1852A37D0", Slot = "5")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600049C")]
	[Cpp2IlInjected.Address(RVA = "0x52A3B70", Offset = "0x52A2D70", VA = "0x1852A3B70")]
	public BBHEGMJIEOG(OINPHBHEBFM EHHPLBPDKBE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600049D")]
	[Cpp2IlInjected.Address(RVA = "0x52A39C0", Offset = "0x52A2BC0", VA = "0x1852A39C0", Slot = "6")]
	public void JDBMEAOELGO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600049E")]
	[Cpp2IlInjected.Address(RVA = "0x52A3AF0", Offset = "0x52A2CF0", VA = "0x1852A3AF0", Slot = "9")]
	public void NJINOCNPPGC(Rigidbody NBJEPCGIGPN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004A1")]
	[Cpp2IlInjected.Address(RVA = "0x52A3840", Offset = "0x52A2A40", VA = "0x1852A3840", Slot = "7")]
	public void FBBHPGOJJEA(bool AALOAMDFFGP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004A2")]
	[Cpp2IlInjected.Address(RVA = "0x52A3AE0", Offset = "0x52A2CE0", VA = "0x1852A3AE0", Slot = "8")]
	public void LBLCJPGOPBO(bool AALOAMDFFGP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004A3")]
	[Cpp2IlInjected.Address(RVA = "0x52A3850", Offset = "0x52A2A50", VA = "0x1852A3850", Slot = "10")]
	public bool FHJIOGHMPNH(Vector3 HLFIBIDOLEF, out RaycastHit KNFIEECFHPI, float GKJHODLJDHD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60004A4")]
	[Cpp2IlInjected.Address(RVA = "0x52A36A0", Offset = "0x52A28A0", VA = "0x1852A36A0")]
	private void DCAPPBIJNHD(bool AALOAMDFFGP)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200004C")]
public sealed class HALJNPLAEFI : NOIDPDKILCA, IDisposable, DFBGLPCFOHL
{
	[Cpp2IlInjected.Token(Token = "0x4000087")]
	public const int JGMNFKDGFJK = 350;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000089")]
	private readonly FFNHAGGANGK EHHPLBPDKBE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400008A")]
	private HHLALPMEMBB BNPBKJKCDOH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400008B")]
	private PEMDLLFJFDM OKEJBDKIECP;

	[Cpp2IlInjected.Token(Token = "0x17000135")]
	public HHLALPMEMBB AJFBHNJDDCE
	{
		[Cpp2IlInjected.Token(Token = "0x60004A7")]
		[Cpp2IlInjected.Address(RVA = "0x52B32A0", Offset = "0x52B24A0", VA = "0x1852B32A0", Slot = "6")]
		get
		{
			return default(HHLALPMEMBB);
		}
		[Cpp2IlInjected.Token(Token = "0x60004A8")]
		[Cpp2IlInjected.Address(RVA = "0x52B33E0", Offset = "0x52B25E0", VA = "0x1852B33E0", Slot = "7")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000136")]
	private Transform NFMNHNCFMEK
	{
		[Cpp2IlInjected.Token(Token = "0x60004A9")]
		[Cpp2IlInjected.Address(RVA = "0x52B2E50", Offset = "0x52B2050", VA = "0x1852B2E50", Slot = "10")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000041")]
	public event Action<AMBBOEBJPNH, AMBBOEBJPNH> FIKAFLHBAHL
	{
		[Cpp2IlInjected.Token(Token = "0x60004A5")]
		[Cpp2IlInjected.Address(RVA = "0x52B2DB0", Offset = "0x52B1FB0", VA = "0x1852B2DB0", Slot = "4")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60004A6")]
		[Cpp2IlInjected.Address(RVA = "0x52B3200", Offset = "0x52B2400", VA = "0x1852B3200", Slot = "5")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60004AA")]
	[Cpp2IlInjected.Address(RVA = "0x52B34B0", Offset = "0x52B26B0", VA = "0x1852B34B0")]
	public HALJNPLAEFI(OINPHBHEBFM EHHPLBPDKBE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004AB")]
	[Cpp2IlInjected.Address(RVA = "0x52B2F20", Offset = "0x52B2120", VA = "0x1852B2F20", Slot = "8")]
	public void JDBMEAOELGO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004AC")]
	[Cpp2IlInjected.Address(RVA = "0x52B2E70", Offset = "0x52B2070", VA = "0x1852B2E70", Slot = "9")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004AD")]
	[Cpp2IlInjected.Address(RVA = "0x52B2EC0", Offset = "0x52B20C0", VA = "0x1852B2EC0", Slot = "11")]
	private void FFOPNFELAEB(AMBBOEBJPNH MOCEBLJHGPF, AMBBOEBJPNH ELOPMNNDIJD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004AE")]
	[Cpp2IlInjected.Address(RVA = "0x6F84D0", Offset = "0x6F76D0", VA = "0x1806F84D0", Slot = "12")]
	private void KEOCMDLHALC(bool GMEKKCPLMOB)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200004D")]
internal sealed class GEHAOKONKFM : EJPBMJKJDKA
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400008C")]
	private readonly FFNHAGGANGK EHHPLBPDKBE;

	[Cpp2IlInjected.Token(Token = "0x17000137")]
	private Rigidbody JMCCCFFEIIG
	{
		[Cpp2IlInjected.Token(Token = "0x60004AF")]
		[Cpp2IlInjected.Address(RVA = "0x52A2720", Offset = "0x52A1920", VA = "0x1852A2720")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000138")]
	private bool KFFOOLFOADP
	{
		[Cpp2IlInjected.Token(Token = "0x60004B0")]
		[Cpp2IlInjected.Address(RVA = "0x52B0370", Offset = "0x52AF570", VA = "0x1852B0370")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000139")]
	private bool LLNINBLBFFN
	{
		[Cpp2IlInjected.Token(Token = "0x60004B1")]
		[Cpp2IlInjected.Address(RVA = "0x52B0310", Offset = "0x52AF510", VA = "0x1852B0310")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700013A")]
	private OINPHBHEBFM HKAHNOCIENG
	{
		[Cpp2IlInjected.Token(Token = "0x60004B2")]
		[Cpp2IlInjected.Address(RVA = "0x52AF9B0", Offset = "0x52AEBB0", VA = "0x1852AF9B0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60004B3")]
	[Cpp2IlInjected.Address(RVA = "0x52A3B70", Offset = "0x52A2D70", VA = "0x1852A3B70")]
	public GEHAOKONKFM(OINPHBHEBFM EHHPLBPDKBE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004B4")]
	[Cpp2IlInjected.Address(RVA = "0x52B03C0", Offset = "0x52AF5C0", VA = "0x1852B03C0", Slot = "4")]
	public void OPLMNHEAGKL(Vector3 COPOILGLIAJ, ForceMode OJOAKAEAKAC = ForceMode.Force)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004B5")]
	[Cpp2IlInjected.Address(RVA = "0x52AFA10", Offset = "0x52AEC10", VA = "0x1852AFA10")]
	private void CLODOAOGOKG(Vector3 COPOILGLIAJ, ForceMode OJOAKAEAKAC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004B6")]
	[Cpp2IlInjected.Address(RVA = "0x52B0070", Offset = "0x52AF270", VA = "0x1852B0070", Slot = "5")]
	public void FLNNLAIJPLD(Vector3 COPOILGLIAJ, Vector3 INLGLHIPOMC, ForceMode OJOAKAEAKAC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004B7")]
	[Cpp2IlInjected.Address(RVA = "0x52AFF10", Offset = "0x52AF110", VA = "0x1852AFF10", Slot = "6")]
	public void FLJCPNJHDAE(Vector3 HMKLOLJGHPK, ForceMode OJOAKAEAKAC = ForceMode.Force)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004B8")]
	[Cpp2IlInjected.Address(RVA = "0x52AF730", Offset = "0x52AE930", VA = "0x1852AF730")]
	private void AKDNGGALPNM(Vector3 HMKLOLJGHPK, ForceMode OJOAKAEAKAC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004B9")]
	[Cpp2IlInjected.Address(RVA = "0x52AFC90", Offset = "0x52AEE90", VA = "0x1852AFC90", Slot = "7")]
	public void DLOBEAKDAFF(Vector3 HMKLOLJGHPK, ForceMode OJOAKAEAKAC = ForceMode.Force)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200004E")]
internal sealed class KPKGNDLEIAF : JIHFCAHMINI
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400008D")]
	private readonly FFNHAGGANGK EHHPLBPDKBE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400008E")]
	private bool MOIKHBKFGCG;

	[Cpp2IlInjected.Token(Token = "0x1700013B")]
	public bool NFPCLOGDCAI
	{
		[Cpp2IlInjected.Token(Token = "0x60004BB")]
		[Cpp2IlInjected.Address(RVA = "0x7E49F0", Offset = "0x7E3BF0", VA = "0x1807E49F0", Slot = "4")]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x60004BC")]
		[Cpp2IlInjected.Address(RVA = "0x52BE810", Offset = "0x52BDA10", VA = "0x1852BE810", Slot = "5")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60004BA")]
	[Cpp2IlInjected.Address(RVA = "0x52A3B70", Offset = "0x52A2D70", VA = "0x1852A3B70")]
	public KPKGNDLEIAF(OINPHBHEBFM EHHPLBPDKBE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004BD")]
	[Cpp2IlInjected.Address(RVA = "0x52BE920", Offset = "0x52BDB20", VA = "0x1852BE920", Slot = "6")]
	public void NJINOCNPPGC(Rigidbody NBJEPCGIGPN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004BE")]
	[Cpp2IlInjected.Address(RVA = "0x52A62B0", Offset = "0x52A54B0", VA = "0x1852A62B0", Slot = "7")]
	public void NNCOBAOCBLO(Rigidbody NBJEPCGIGPN)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200004F")]
internal sealed class DNMJCMKDANB : MFACNIJADCN, ACEBILIFEIP, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x4000098")]
	private readonly OINPHBHEBFM EHHPLBPDKBE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x4000099")]
	private readonly List<OINPHBHEBFM> OKKDPEMOHMC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x400009A")]
	private OINPHBHEBFM KPDGHDGLMHO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x400009B")]
	private OINPHBHEBFM HHFDFFDPCGO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
	[Cpp2IlInjected.Token(Token = "0x400009C")]
	private Transform ECMOEPJPAGG;

	[Cpp2IlInjected.Token(Token = "0x1700013C")]
	private Transform DHGHIDOLKGM
	{
		[Cpp2IlInjected.Token(Token = "0x60004D1")]
		[Cpp2IlInjected.Address(RVA = "0x52A67E0", Offset = "0x52A59E0", VA = "0x1852A67E0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700013D")]
	public OINPHBHEBFM HKAHNOCIENG
	{
		[Cpp2IlInjected.Token(Token = "0x60004D4")]
		[Cpp2IlInjected.Address(RVA = "0x9AD0E0", Offset = "0x9AC2E0", VA = "0x1809AD0E0", Slot = "28")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60004D5")]
		[Cpp2IlInjected.Address(RVA = "0x52A6840", Offset = "0x52A5A40", VA = "0x1852A6840", Slot = "29")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700013E")]
	public OINPHBHEBFM CFHDLGEGDFD
	{
		[Cpp2IlInjected.Token(Token = "0x60004D6")]
		[Cpp2IlInjected.Address(RVA = "0x7118C0", Offset = "0x710AC0", VA = "0x1807118C0", Slot = "27")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700013F")]
	public IReadOnlyList<OINPHBHEBFM> NCLNEDAIDDA
	{
		[Cpp2IlInjected.Token(Token = "0x60004D7")]
		[Cpp2IlInjected.Address(RVA = "0x817390", Offset = "0x816590", VA = "0x180817390", Slot = "26")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000042")]
	public event FGJCBPBEFOP PBANFIJELBE
	{
		[Cpp2IlInjected.Token(Token = "0x60004BF")]
		[Cpp2IlInjected.Address(RVA = "0x52A6850", Offset = "0x52A5A50", VA = "0x1852A6850", Slot = "8")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60004C0")]
		[Cpp2IlInjected.Address(RVA = "0x52A79A0", Offset = "0x52A6BA0", VA = "0x1852A79A0", Slot = "9")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000043")]
	public event FGJCBPBEFOP MGANLNPCDNF
	{
		[Cpp2IlInjected.Token(Token = "0x60004C1")]
		[Cpp2IlInjected.Address(RVA = "0x52A6320", Offset = "0x52A5520", VA = "0x1852A6320", Slot = "10")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60004C2")]
		[Cpp2IlInjected.Address(RVA = "0x52A7810", Offset = "0x52A6A10", VA = "0x1852A7810", Slot = "11")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000044")]
	public event OHFGCHALJBC CLHKPMHNJGH
	{
		[Cpp2IlInjected.Token(Token = "0x60004C3")]
		[Cpp2IlInjected.Address(RVA = "0x52A6DC0", Offset = "0x52A5FC0", VA = "0x1852A6DC0", Slot = "12")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60004C4")]
		[Cpp2IlInjected.Address(RVA = "0x52A7A40", Offset = "0x52A6C40", VA = "0x1852A7A40", Slot = "13")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000045")]
	public event Action LEPPBOOKMBH
	{
		[Cpp2IlInjected.Token(Token = "0x60004C5")]
		[Cpp2IlInjected.Address(RVA = "0x52A74E0", Offset = "0x52A66E0", VA = "0x1852A74E0", Slot = "14")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60004C6")]
		[Cpp2IlInjected.Address(RVA = "0x52A7AE0", Offset = "0x52A6CE0", VA = "0x1852A7AE0", Slot = "15")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000046")]
	public event Action KDMAPDBOBHG
	{
		[Cpp2IlInjected.Token(Token = "0x60004C7")]
		[Cpp2IlInjected.Address(RVA = "0x52A7B80", Offset = "0x52A6D80", VA = "0x1852A7B80", Slot = "16")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60004C8")]
		[Cpp2IlInjected.Address(RVA = "0x52A68F0", Offset = "0x52A5AF0", VA = "0x1852A68F0", Slot = "17")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000047")]
	public event Action<OINPHBHEBFM> NKBGAPIKEDN
	{
		[Cpp2IlInjected.Token(Token = "0x60004C9")]
		[Cpp2IlInjected.Address(RVA = "0x52A6460", Offset = "0x52A5660", VA = "0x1852A6460", Slot = "18")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60004CA")]
		[Cpp2IlInjected.Address(RVA = "0x52A6C80", Offset = "0x52A5E80", VA = "0x1852A6C80", Slot = "19")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000048")]
	public event Action<OINPHBHEBFM> GBNGEPPDDCO
	{
		[Cpp2IlInjected.Token(Token = "0x60004CB")]
		[Cpp2IlInjected.Address(RVA = "0x52A6BE0", Offset = "0x52A5DE0", VA = "0x1852A6BE0", Slot = "20")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60004CC")]
		[Cpp2IlInjected.Address(RVA = "0x52A7FB0", Offset = "0x52A71B0", VA = "0x1852A7FB0", Slot = "21")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000049")]
	public event Action NELDKADHHEN
	{
		[Cpp2IlInjected.Token(Token = "0x60004CD")]
		[Cpp2IlInjected.Address(RVA = "0x52A7770", Offset = "0x52A6970", VA = "0x1852A7770", Slot = "22")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60004CE")]
		[Cpp2IlInjected.Address(RVA = "0x52A7580", Offset = "0x52A6780", VA = "0x1852A7580", Slot = "23")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400004A")]
	public event Action<OINPHBHEBFM> BCMOPJLPDJI
	{
		[Cpp2IlInjected.Token(Token = "0x60004CF")]
		[Cpp2IlInjected.Address(RVA = "0x52A7400", Offset = "0x52A6600", VA = "0x1852A7400", Slot = "24")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60004D0")]
		[Cpp2IlInjected.Address(RVA = "0x52A63C0", Offset = "0x52A55C0", VA = "0x1852A63C0", Slot = "25")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60004D2")]
	[Cpp2IlInjected.Address(RVA = "0x52A8050", Offset = "0x52A7250", VA = "0x1852A8050")]
	public DNMJCMKDANB(OINPHBHEBFM EHHPLBPDKBE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004D3")]
	[Cpp2IlInjected.Address(RVA = "0x52A6760", Offset = "0x52A5960", VA = "0x1852A6760", Slot = "31")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004D8")]
	[Cpp2IlInjected.Address(RVA = "0x52A6E60", Offset = "0x52A6060", VA = "0x1852A6E60", Slot = "30")]
	public void HMBNJDPGAJN(OINPHBHEBFM BDBBMBMDCFP, bool LDEEGDEKBLJ = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004D9")]
	[Cpp2IlInjected.Address(RVA = "0x52A6990", Offset = "0x52A5B90", VA = "0x1852A6990", Slot = "6")]
	public void GNNBGIOKGLJ(OINPHBHEBFM DLHNFCJIJJD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004DA")]
	[Cpp2IlInjected.Address(RVA = "0x52A7C20", Offset = "0x52A6E20", VA = "0x1852A7C20", Slot = "7")]
	public void PAINNLINJFA(OINPHBHEBFM DLHNFCJIJJD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004DB")]
	[Cpp2IlInjected.Address(RVA = "0x52A6D20", Offset = "0x52A5F20", VA = "0x1852A6D20", Slot = "4")]
	public void HDJNLHIMONE(OINPHBHEBFM EHHPLBPDKBE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004DC")]
	[Cpp2IlInjected.Address(RVA = "0x52A6500", Offset = "0x52A5700", VA = "0x1852A6500", Slot = "5")]
	public void DFCNILODFON(OINPHBHEBFM EHHPLBPDKBE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004DD")]
	[Cpp2IlInjected.Address(RVA = "0x52A66D0", Offset = "0x52A58D0", VA = "0x1852A66D0")]
	private void DLCMANLNGDI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004DE")]
	[Cpp2IlInjected.Address(RVA = "0x52A74A0", Offset = "0x52A66A0", VA = "0x1852A74A0")]
	private void IOJGOGBBBID(OINPHBHEBFM DLHNFCJIJJD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004DF")]
	[Cpp2IlInjected.Address(RVA = "0x52A7620", Offset = "0x52A6820", VA = "0x1852A7620")]
	private void JLJONPOLHDN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004E0")]
	[Cpp2IlInjected.Address(RVA = "0x52A7E80", Offset = "0x52A7080", VA = "0x1852A7E80")]
	private void PJIEKOAPMDB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004E1")]
	[Cpp2IlInjected.Address(RVA = "0x52A65A0", Offset = "0x52A57A0", VA = "0x1852A65A0")]
	private void DKBLHMAEHGG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004E2")]
	[Cpp2IlInjected.Address(RVA = "0x52A78B0", Offset = "0x52A6AB0", VA = "0x1852A78B0")]
	[CompilerGenerated]
	private object KIADHPCNGJN()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000050")]
internal static class JFJNKGKBMDO
{
	[Cpp2IlInjected.Token(Token = "0x60004E3")]
	[Cpp2IlInjected.Address(RVA = "0x52BCF00", Offset = "0x52BC100", VA = "0x1852BCF00")]
	public static MFACNIJADCN ILLFGBFMOKO(this OINPHBHEBFM IDCNELICAAG)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000051")]
internal sealed class IOCODCFECCJ : CPAKIGNIADK, OPBHABCMHHK
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400009D")]
	private readonly FFNHAGGANGK EHHPLBPDKBE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400009E")]
	private readonly global::MKJNCDLHHNA<OINPHBHEBFM> BDLPHJFPKIM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400009F")]
	private bool EKCKJOIKPBF;

	[Cpp2IlInjected.Token(Token = "0x17000140")]
	public global::MKJNCDLHHNA<OINPHBHEBFM> GCPMKIEAPKF
	{
		[Cpp2IlInjected.Token(Token = "0x60004E4")]
		[Cpp2IlInjected.Address(RVA = "0x6FA000", Offset = "0x6F9200", VA = "0x1806FA000", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000141")]
	public Vector3 CEAFBIINOKH
	{
		[Cpp2IlInjected.Token(Token = "0x60004E5")]
		[Cpp2IlInjected.Address(RVA = "0x52B7EF0", Offset = "0x52B70F0", VA = "0x1852B7EF0", Slot = "6")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000142")]
	public Vector3 NHENIPHGFOP
	{
		[Cpp2IlInjected.Token(Token = "0x60004E6")]
		[Cpp2IlInjected.Address(RVA = "0x52B8390", Offset = "0x52B7590", VA = "0x1852B8390", Slot = "7")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000143")]
	private Vector3 BNMCMLCKBOK
	{
		[Cpp2IlInjected.Token(Token = "0x60004EA")]
		[Cpp2IlInjected.Address(RVA = "0x52B7E10", Offset = "0x52B7010", VA = "0x1852B7E10")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000144")]
	public OINPHBHEBFM OEPBOFMCNBN
	{
		[Cpp2IlInjected.Token(Token = "0x60004EB")]
		[Cpp2IlInjected.Address(RVA = "0x52B82E0", Offset = "0x52B74E0", VA = "0x1852B82E0", Slot = "5")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60004E7")]
	[Cpp2IlInjected.Address(RVA = "0x52B8960", Offset = "0x52B7B60", VA = "0x1852B8960")]
	public IOCODCFECCJ(OINPHBHEBFM EHHPLBPDKBE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004E8")]
	[Cpp2IlInjected.Address(RVA = "0x52B8270", Offset = "0x52B7470", VA = "0x1852B8270", Slot = "8")]
	public void KDCKLPJMBKN(OINPHBHEBFM HHFDFFDPCGO, object IALNODEHBNN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004E9")]
	[Cpp2IlInjected.Address(RVA = "0x52B8900", Offset = "0x52B7B00", VA = "0x1852B8900", Slot = "9")]
	public void OMINIIDBGAF(object IALNODEHBNN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004EC")]
	[Cpp2IlInjected.Address(RVA = "0x52B7F20", Offset = "0x52B7120", VA = "0x1852B7F20")]
	private Vector3 IDDGPBEGFAK()
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x60004ED")]
	[Cpp2IlInjected.Address(RVA = "0x52B8560", Offset = "0x52B7760", VA = "0x1852B8560")]
	private void OJJPKFBAGKD(OINPHBHEBFM DNAONFHHNFH)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000052")]
internal static class FJIOBFJBNNF
{
	[Cpp2IlInjected.Token(Token = "0x60004EE")]
	[Cpp2IlInjected.Address(RVA = "0x52AED60", Offset = "0x52ADF60", VA = "0x1852AED60")]
	public static CPAKIGNIADK DMGNAPMCCPA(this OINPHBHEBFM IDCNELICAAG)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000053")]
internal sealed class IEKBOFJEHKL : NOFINPJFCLP, KMFGIPGBMDB
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000A1")]
	private readonly FFNHAGGANGK EHHPLBPDKBE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000A2")]
	private readonly OverridableVector3 ANDPMGMCECJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40000A3")]
	private readonly OverridableVector3 EMKAIKHLGLK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x40000A4")]
	private float OBEADAGDFAM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x44")]
	[Cpp2IlInjected.Token(Token = "0x40000A5")]
	private float BODPGOIGEFH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x40000A6")]
	private Vector3 HEKNBIPIBAH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x54")]
	[Cpp2IlInjected.Token(Token = "0x40000A7")]
	private Vector3? NBKEAILGEND;

	[Cpp2IlInjected.FieldOffset(Offset = "0x64")]
	[Cpp2IlInjected.Token(Token = "0x40000A8")]
	private Quaternion? HFLGIFBAEKG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
	[Cpp2IlInjected.Token(Token = "0x40000A9")]
	private bool EGJOCJMIDHD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x79")]
	[Cpp2IlInjected.Token(Token = "0x40000AA")]
	private bool KLJPBNHNKLM;

	[Cpp2IlInjected.Token(Token = "0x17000145")]
	public Vector3 CMPGKEOHLJC
	{
		[Cpp2IlInjected.Token(Token = "0x60004F1")]
		[Cpp2IlInjected.Address(RVA = "0xB4EA40", Offset = "0xB4DC40", VA = "0x180B4EA40", Slot = "7")]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x60004F2")]
		[Cpp2IlInjected.Address(RVA = "0x52B5DB0", Offset = "0x52B4FB0", VA = "0x1852B5DB0", Slot = "8")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000146")]
	public Vector3 EIMEJLMMLMA
	{
		[Cpp2IlInjected.Token(Token = "0x60004F3")]
		[Cpp2IlInjected.Address(RVA = "0x52B5830", Offset = "0x52B4A30", VA = "0x1852B5830", Slot = "9")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000147")]
	public float EHLCHKMKGBK
	{
		[Cpp2IlInjected.Token(Token = "0x60004F4")]
		[Cpp2IlInjected.Address(RVA = "0xCBF8C0", Offset = "0xCBEAC0", VA = "0x180CBF8C0", Slot = "10")]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x60004F5")]
		[Cpp2IlInjected.Address(RVA = "0x52B5DD0", Offset = "0x52B4FD0", VA = "0x1852B5DD0")]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000148")]
	public float BENEGDAHFLL
	{
		[Cpp2IlInjected.Token(Token = "0x60004F6")]
		[Cpp2IlInjected.Address(RVA = "0x9D23D0", Offset = "0x9D15D0", VA = "0x1809D23D0", Slot = "11")]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x60004F7")]
		[Cpp2IlInjected.Address(RVA = "0x52B5CF0", Offset = "0x52B4EF0", VA = "0x1852B5CF0", Slot = "12")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000149")]
	public Vector3 NGJFIKPFMML
	{
		[Cpp2IlInjected.Token(Token = "0x60004F8")]
		[Cpp2IlInjected.Address(RVA = "0x52B7330", Offset = "0x52B6530", VA = "0x1852B7330", Slot = "13")]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x60004F9")]
		[Cpp2IlInjected.Address(RVA = "0x52B5930", Offset = "0x52B4B30", VA = "0x1852B5930", Slot = "14")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700014A")]
	public Quaternion LKICJOBKNGL
	{
		[Cpp2IlInjected.Token(Token = "0x60004FA")]
		[Cpp2IlInjected.Address(RVA = "0x52B5EF0", Offset = "0x52B50F0", VA = "0x1852B5EF0", Slot = "15")]
		get
		{
			return default(Quaternion);
		}
		[Cpp2IlInjected.Token(Token = "0x60004FB")]
		[Cpp2IlInjected.Address(RVA = "0x52B74A0", Offset = "0x52B66A0", VA = "0x1852B74A0", Slot = "16")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700014B")]
	private Rigidbody JMCCCFFEIIG
	{
		[Cpp2IlInjected.Token(Token = "0x6000503")]
		[Cpp2IlInjected.Address(RVA = "0x52B7B90", Offset = "0x52B6D90", VA = "0x1852B7B90")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400004B")]
	public event FGJCBPBEFOP DABDOEGBNOF
	{
		[Cpp2IlInjected.Token(Token = "0x60004EF")]
		[Cpp2IlInjected.Address(RVA = "0x52B5D10", Offset = "0x52B4F10", VA = "0x1852B5D10", Slot = "5")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60004F0")]
		[Cpp2IlInjected.Address(RVA = "0x52B5C50", Offset = "0x52B4E50", VA = "0x1852B5C50", Slot = "6")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60004FC")]
	[Cpp2IlInjected.Address(RVA = "0x52B7D40", Offset = "0x52B6F40", VA = "0x1852B7D40")]
	public IEKBOFJEHKL(OINPHBHEBFM EHHPLBPDKBE, in IPGEEHAGLOI PCPEJHIMHJJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004FD")]
	[Cpp2IlInjected.Address(RVA = "0x52B7170", Offset = "0x52B6370", VA = "0x1852B7170", Slot = "18")]
	public void LILDLMIHEAF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004FE")]
	[Cpp2IlInjected.Address(RVA = "0x52B7AB0", Offset = "0x52B6CB0", VA = "0x1852B7AB0", Slot = "17")]
	public void OLIDEBFPCBJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004FF")]
	[Cpp2IlInjected.Address(RVA = "0x52B7640", Offset = "0x52B6840", VA = "0x1852B7640", Slot = "20")]
	public void NJINOCNPPGC(Rigidbody NBJEPCGIGPN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000500")]
	[Cpp2IlInjected.Address(RVA = "0x52B7720", Offset = "0x52B6920", VA = "0x1852B7720", Slot = "21")]
	public void NNCOBAOCBLO(Rigidbody NBJEPCGIGPN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000501")]
	[Cpp2IlInjected.Address(RVA = "0x52B6060", Offset = "0x52B5260", VA = "0x1852B6060", Slot = "19")]
	public void KJCFGELAPLM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000502")]
	[Cpp2IlInjected.Address(RVA = "0x52B5370", Offset = "0x52B4570", VA = "0x1852B5370", Slot = "22")]
	public void AMMOJMDCBMC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000504")]
	[Cpp2IlInjected.Address(RVA = "0x52B5DB0", Offset = "0x52B4FB0", VA = "0x1852B5DB0")]
	private void KEDJCFDKLAO(Vector3 IPMIIEAGJKC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000505")]
	[Cpp2IlInjected.Address(RVA = "0x52B79C0", Offset = "0x52B6BC0", VA = "0x1852B79C0")]
	private Vector3 OFGCAAHHPPH()
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000506")]
	[Cpp2IlInjected.Address(RVA = "0x52B5DD0", Offset = "0x52B4FD0", VA = "0x1852B5DD0")]
	private void IMILCKKKLDJ(float IPMIIEAGJKC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000507")]
	[Cpp2IlInjected.Address(RVA = "0x52B5CF0", Offset = "0x52B4EF0", VA = "0x1852B5CF0")]
	private void KCLPHGPBFDD(float IPMIIEAGJKC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000508")]
	[Cpp2IlInjected.Address(RVA = "0x52B5AD0", Offset = "0x52B4CD0", VA = "0x1852B5AD0")]
	private Vector3 DIDEHKMFMDM()
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000509")]
	[Cpp2IlInjected.Address(RVA = "0x52B5930", Offset = "0x52B4B30", VA = "0x1852B5930")]
	private void PGEMLHNKMFA(Vector3 IPMIIEAGJKC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600050A")]
	[Cpp2IlInjected.Address(RVA = "0x52B7BE0", Offset = "0x52B6DE0", VA = "0x1852B7BE0")]
	private Quaternion PKFDOANKKGD()
	{
		return default(Quaternion);
	}

	[Cpp2IlInjected.Token(Token = "0x600050B")]
	[Cpp2IlInjected.Address(RVA = "0x52B74A0", Offset = "0x52B66A0", VA = "0x1852B74A0")]
	private void NAHEMADMLCM(Quaternion IPMIIEAGJKC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600050C")]
	[Cpp2IlInjected.Address(RVA = "0x52B61D0", Offset = "0x52B53D0", VA = "0x1852B61D0")]
	public void KNMMHOMBDMC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600050D")]
	[Cpp2IlInjected.Address(RVA = "0x52B62B0", Offset = "0x52B54B0", VA = "0x1852B62B0", Slot = "4")]
	public (float, Vector3) KNMMHOMBDMC(Rigidbody DJLPCBPBOHF)
	{
		return default((float, Vector3));
	}
}
[Cpp2IlInjected.Token(Token = "0x2000054")]
internal static class IPBKFNIBDEK
{
	[Cpp2IlInjected.Token(Token = "0x600050E")]
	[Cpp2IlInjected.Address(RVA = "0x52B8A50", Offset = "0x52B7C50", VA = "0x1852B8A50")]
	public static NOFINPJFCLP BPCPJFNAOMK(this OINPHBHEBFM IDCNELICAAG)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000055")]
internal sealed class FGLENFAAPAM : POMIHBCAKMM
{
	[Cpp2IlInjected.Token(Token = "0x40000AB")]
	private const string NABPFCBNOPO = "INTERP_PAUSE";

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000AC")]
	private readonly FFNHAGGANGK EHHPLBPDKBE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000AD")]
	private readonly FIHGBEHGLGB DPBJNBNPNFL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000AE")]
	private readonly MGFMFIIFDMD BGNILMBFPPE;

	[Cpp2IlInjected.Token(Token = "0x1700014C")]
	public bool MGOICACOHNO
	{
		[Cpp2IlInjected.Token(Token = "0x600050F")]
		[Cpp2IlInjected.Address(RVA = "0x70DCA0", Offset = "0x70CEA0", VA = "0x18070DCA0", Slot = "4")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700014D")]
	public MGFMFIIFDMD MDEOCKDFDNK
	{
		[Cpp2IlInjected.Token(Token = "0x6000510")]
		[Cpp2IlInjected.Address(RVA = "0x6FB720", Offset = "0x6FA920", VA = "0x1806FB720", Slot = "5")]
		get
		{
			return default(MGFMFIIFDMD);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000511")]
	[Cpp2IlInjected.Address(RVA = "0x52AEC70", Offset = "0x52ADE70", VA = "0x1852AEC70")]
	public FGLENFAAPAM(OINPHBHEBFM EHHPLBPDKBE, in IPGEEHAGLOI PCPEJHIMHJJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000512")]
	[Cpp2IlInjected.Address(RVA = "0x52AEA90", Offset = "0x52ADC90", VA = "0x1852AEA90", Slot = "6")]
	public void JDBMEAOELGO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000513")]
	[Cpp2IlInjected.Address(RVA = "0x52AEBA0", Offset = "0x52ADDA0", VA = "0x1852AEBA0")]
	private bool NGHBNAILKLI()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000514")]
	[Cpp2IlInjected.Address(RVA = "0x52AE660", Offset = "0x52AD860", VA = "0x1852AE660", Slot = "7")]
	public void DOAIEIBIBFL(object IALNODEHBNN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000515")]
	[Cpp2IlInjected.Address(RVA = "0x52AEC40", Offset = "0x52ADE40", VA = "0x1852AEC40", Slot = "8")]
	public void OEGPCOAFMDB(object IALNODEHBNN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000516")]
	[Cpp2IlInjected.Address(RVA = "0x52AE960", Offset = "0x52ADB60", VA = "0x1852AE960", Slot = "11")]
	public void IKKEJJKEGGH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000517")]
	[Cpp2IlInjected.Address(RVA = "0x52AE6D0", Offset = "0x52AD8D0", VA = "0x1852AE6D0")]
	private void HMKLPMPBPND()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000518")]
	[Cpp2IlInjected.Address(RVA = "0x52AE7E0", Offset = "0x52AD9E0", VA = "0x1852AE7E0")]
	private void IBOLLAOMABA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000519")]
	[Cpp2IlInjected.Address(RVA = "0x52AEB60", Offset = "0x52ADD60", VA = "0x1852AEB60", Slot = "10")]
	public void NFHJNCFFDIO(OINPHBHEBFM EHHPLBPDKBE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600051A")]
	[Cpp2IlInjected.Address(RVA = "0x52AE690", Offset = "0x52AD890", VA = "0x1852AE690", Slot = "9")]
	public void FGILIJPPIJA(OINPHBHEBFM EHHPLBPDKBE)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000056")]
internal sealed class MPHIPKLDKFI : KJLCKLHHAII
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000B0")]
	private readonly FFNHAGGANGK EHHPLBPDKBE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000B1")]
	private readonly FIHGBEHGLGB BBAAEIJBNPH;

	[Cpp2IlInjected.Token(Token = "0x1700014E")]
	public bool KFFOOLFOADP
	{
		[Cpp2IlInjected.Token(Token = "0x600051D")]
		[Cpp2IlInjected.Address(RVA = "0x52C5250", Offset = "0x52C4450", VA = "0x1852C5250", Slot = "6")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700014F")]
	public IEnumerable<object> NHEINPMGMGO
	{
		[Cpp2IlInjected.Token(Token = "0x600051E")]
		[Cpp2IlInjected.Address(RVA = "0x52C5230", Offset = "0x52C4430", VA = "0x1852C5230", Slot = "7")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400004C")]
	public event FGJCBPBEFOP OLENKEHDGAF
	{
		[Cpp2IlInjected.Token(Token = "0x600051B")]
		[Cpp2IlInjected.Address(RVA = "0x52C53C0", Offset = "0x52C45C0", VA = "0x1852C53C0", Slot = "4")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600051C")]
		[Cpp2IlInjected.Address(RVA = "0x52C5090", Offset = "0x52C4290", VA = "0x1852C5090", Slot = "5")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600051F")]
	[Cpp2IlInjected.Address(RVA = "0x52C5460", Offset = "0x52C4660", VA = "0x1852C5460")]
	public MPHIPKLDKFI(OINPHBHEBFM EHHPLBPDKBE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000520")]
	[Cpp2IlInjected.Address(RVA = "0x52C5030", Offset = "0x52C4230", VA = "0x1852C5030", Slot = "11")]
	public IDisposable EEBIOLKMNJN()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000521")]
	[Cpp2IlInjected.Address(RVA = "0x52C4F40", Offset = "0x52C4140", VA = "0x1852C4F40", Slot = "8")]
	public void ANNHOHNEGBC(object IALNODEHBNN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000522")]
	[Cpp2IlInjected.Address(RVA = "0x52C5020", Offset = "0x52C4220", VA = "0x1852C5020", Slot = "9")]
	public void DIACCKFBBFC(object IALNODEHBNN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000523")]
	[Cpp2IlInjected.Address(RVA = "0x52C5130", Offset = "0x52C4330", VA = "0x1852C5130", Slot = "10")]
	public void IMCEFNKDLJE(object IALNODEHBNN, bool DKKAHPAOACL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000524")]
	[Cpp2IlInjected.Address(RVA = "0x52C5310", Offset = "0x52C4510", VA = "0x1852C5310", Slot = "12")]
	public void NJINOCNPPGC(Rigidbody FNBMGBEMKPE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000525")]
	[Cpp2IlInjected.Address(RVA = "0x52C5390", Offset = "0x52C4590", VA = "0x1852C5390", Slot = "13")]
	public void NNCOBAOCBLO(Rigidbody NBJEPCGIGPN)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000057")]
internal sealed class CLKFKJCNDDP : GHHJPNLPLLI, HDMHGHFDNPO, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000B3")]
	private readonly FFNHAGGANGK EHHPLBPDKBE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000B4")]
	private PhotonView OGMNKDNMJCB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40000B5")]
	private bool PFGCFMLPLKK;

	[Cpp2IlInjected.Token(Token = "0x17000150")]
	public PhotonView BEPJHNBHMKL
	{
		[Cpp2IlInjected.Token(Token = "0x6000528")]
		[Cpp2IlInjected.Address(RVA = "0x6F6390", Offset = "0x6F5590", VA = "0x1806F6390", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000151")]
	public bool NKELDOMJEGL
	{
		[Cpp2IlInjected.Token(Token = "0x6000529")]
		[Cpp2IlInjected.Address(RVA = "0x52A5B40", Offset = "0x52A4D40", VA = "0x1852A5B40", Slot = "7")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000152")]
	public bool DMMCOKOAOJI
	{
		[Cpp2IlInjected.Token(Token = "0x600052A")]
		[Cpp2IlInjected.Address(RVA = "0xAD84D0", Offset = "0xAD76D0", VA = "0x180AD84D0", Slot = "8")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400004D")]
	public event FGJCBPBEFOP EBDIBBFMNAG
	{
		[Cpp2IlInjected.Token(Token = "0x6000526")]
		[Cpp2IlInjected.Address(RVA = "0x52A5480", Offset = "0x52A4680", VA = "0x1852A5480", Slot = "5")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000527")]
		[Cpp2IlInjected.Address(RVA = "0x52A5630", Offset = "0x52A4830", VA = "0x1852A5630", Slot = "6")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600052B")]
	[Cpp2IlInjected.Address(RVA = "0x52A5E50", Offset = "0x52A5050", VA = "0x1852A5E50")]
	public CLKFKJCNDDP(OINPHBHEBFM EHHPLBPDKBE, in IPGEEHAGLOI PCPEJHIMHJJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600052C")]
	[Cpp2IlInjected.Address(RVA = "0x52A56D0", Offset = "0x52A48D0", VA = "0x1852A56D0", Slot = "9")]
	public void JDBMEAOELGO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600052D")]
	[Cpp2IlInjected.Address(RVA = "0x52A5520", Offset = "0x52A4720", VA = "0x1852A5520", Slot = "12")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600052E")]
	[Cpp2IlInjected.Address(RVA = "0x52A5820", Offset = "0x52A4A20", VA = "0x1852A5820", Slot = "10")]
	public void JLNECFHPDHL(OINPHBHEBFM HHFDFFDPCGO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600052F")]
	[Cpp2IlInjected.Address(RVA = "0x52A59B0", Offset = "0x52A4BB0", VA = "0x1852A59B0", Slot = "11")]
	public void LAJHBEDDHLL(OINPHBHEBFM HHFDFFDPCGO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000530")]
	[Cpp2IlInjected.Address(RVA = "0x52A5CD0", Offset = "0x52A4ED0", VA = "0x1852A5CD0")]
	private void NKJIAOABNBM(PhotonView CIPJGOKLPNK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000531")]
	[Cpp2IlInjected.Address(RVA = "0x52A5B60", Offset = "0x52A4D60", VA = "0x1852A5B60")]
	private void MKEKIECENPJ(RigidbodyEx CHCEHPOABNL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000532")]
	[Cpp2IlInjected.Address(RVA = "0x52A5200", Offset = "0x52A4400", VA = "0x1852A5200")]
	private void DBDBMELKCNL(PhotonView PAOKDHCCPKP)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000058")]
internal static class CHLMELBGBBA
{
	[Cpp2IlInjected.Token(Token = "0x6000533")]
	[Cpp2IlInjected.Address(RVA = "0x52A4E10", Offset = "0x52A4010", VA = "0x1852A4E10")]
	public static GHHJPNLPLLI EACALKEIBCF(this OINPHBHEBFM IDCNELICAAG)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000059")]
internal sealed class APLAGAGKDLI : KJDGGMNDKPF
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000B6")]
	private readonly FFNHAGGANGK EHHPLBPDKBE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000B7")]
	private RigidbodyConstraints KMKMKEJDMDN;

	[Cpp2IlInjected.Token(Token = "0x17000153")]
	public bool ADJEMOAFAPK
	{
		[Cpp2IlInjected.Token(Token = "0x6000534")]
		[Cpp2IlInjected.Address(RVA = "0x8C13E0", Offset = "0x8C05E0", VA = "0x1808C13E0", Slot = "4")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000535")]
		[Cpp2IlInjected.Address(RVA = "0x1FC3D00", Offset = "0x1FC2F00", VA = "0x181FC3D00", Slot = "5")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000154")]
	public bool CEBDHLOLCGG
	{
		[Cpp2IlInjected.Token(Token = "0x6000536")]
		[Cpp2IlInjected.Address(RVA = "0x1FC3CF0", Offset = "0x1FC2EF0", VA = "0x181FC3CF0", Slot = "6")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000537")]
		[Cpp2IlInjected.Address(RVA = "0x1FC3D10", Offset = "0x1FC2F10", VA = "0x181FC3D10")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000155")]
	public RigidbodyConstraints PILCFECIKIL
	{
		[Cpp2IlInjected.Token(Token = "0x6000538")]
		[Cpp2IlInjected.Address(RVA = "0x7DEBF0", Offset = "0x7DDDF0", VA = "0x1807DEBF0", Slot = "7")]
		get
		{
			return default(RigidbodyConstraints);
		}
		[Cpp2IlInjected.Token(Token = "0x6000539")]
		[Cpp2IlInjected.Address(RVA = "0x52A3350", Offset = "0x52A2550", VA = "0x1852A3350", Slot = "8")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600053A")]
	[Cpp2IlInjected.Address(RVA = "0x52A34F0", Offset = "0x52A26F0", VA = "0x1852A34F0")]
	public APLAGAGKDLI(OINPHBHEBFM EHHPLBPDKBE, in IPGEEHAGLOI PCPEJHIMHJJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600053B")]
	[Cpp2IlInjected.Address(RVA = "0x52A3490", Offset = "0x52A2690", VA = "0x1852A3490", Slot = "9")]
	public void NJINOCNPPGC(Rigidbody NBJEPCGIGPN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600053C")]
	[Cpp2IlInjected.Address(RVA = "0x52A34C0", Offset = "0x52A26C0", VA = "0x1852A34C0", Slot = "10")]
	public void NNCOBAOCBLO(Rigidbody NBJEPCGIGPN)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200005A")]
internal sealed class ABHDLHHOFDI : CAMJCFKKLPP
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000BA")]
	private readonly OINPHBHEBFM EHHPLBPDKBE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000BB")]
	private float LEFNKNIEOMM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
	[Cpp2IlInjected.Token(Token = "0x40000BC")]
	private float CCIDBFAPCKG;

	[Cpp2IlInjected.Token(Token = "0x17000156")]
	public float PIPAENOKBKE
	{
		[Cpp2IlInjected.Token(Token = "0x600053E")]
		[Cpp2IlInjected.Address(RVA = "0xB53E30", Offset = "0xB53030", VA = "0x180B53E30", Slot = "4")]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x600053F")]
		[Cpp2IlInjected.Address(RVA = "0x52A1D80", Offset = "0x52A0F80", VA = "0x1852A1D80", Slot = "5")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000157")]
	public float HGOJLGHHICI
	{
		[Cpp2IlInjected.Token(Token = "0x6000540")]
		[Cpp2IlInjected.Address(RVA = "0xB53E20", Offset = "0xB53020", VA = "0x180B53E20", Slot = "6")]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x6000541")]
		[Cpp2IlInjected.Address(RVA = "0x52A1BC0", Offset = "0x52A0DC0", VA = "0x1852A1BC0", Slot = "7")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600053D")]
	[Cpp2IlInjected.Address(RVA = "0x52A1E50", Offset = "0x52A1050", VA = "0x1852A1E50")]
	public ABHDLHHOFDI(OINPHBHEBFM EHHPLBPDKBE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000542")]
	[Cpp2IlInjected.Address(RVA = "0x52A1C90", Offset = "0x52A0E90", VA = "0x1852A1C90", Slot = "8")]
	public void NJINOCNPPGC(Rigidbody NBJEPCGIGPN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000543")]
	[Cpp2IlInjected.Address(RVA = "0x52A1CE0", Offset = "0x52A0EE0", VA = "0x1852A1CE0", Slot = "9")]
	public void NNCOBAOCBLO(Rigidbody NBJEPCGIGPN)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200005B")]
internal sealed class LEJLJDHINGJ : GEILDFNHLPL
{
	[Cpp2IlInjected.Token(Token = "0x40000BD")]
	private const int IABAEFMEJHP = 10;

	[Cpp2IlInjected.Token(Token = "0x40000BE")]
	private const float CIAPHLDENLL = 9E-05f;

	[Cpp2IlInjected.Token(Token = "0x40000BF")]
	private const float HCAACDBPPJM = 0.0001f;

	[Cpp2IlInjected.Token(Token = "0x40000C0")]
	private const float HJCIDJFGMFP = 5f;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000C2")]
	private readonly FFNHAGGANGK EHHPLBPDKBE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000C3")]
	private bool DIJJBFBJJPF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x21")]
	[Cpp2IlInjected.Token(Token = "0x40000C4")]
	private bool AGMBMKOKGPI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
	[Cpp2IlInjected.Token(Token = "0x40000C5")]
	private int IJGDNCANPKD;

	[Cpp2IlInjected.Token(Token = "0x17000158")]
	private Rigidbody JMCCCFFEIIG
	{
		[Cpp2IlInjected.Token(Token = "0x6000546")]
		[Cpp2IlInjected.Address(RVA = "0x52B7B90", Offset = "0x52B6D90", VA = "0x1852B7B90")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000159")]
	private bool HECHJGDGAKL
	{
		[Cpp2IlInjected.Token(Token = "0x6000547")]
		[Cpp2IlInjected.Address(RVA = "0x52BEDF0", Offset = "0x52BDFF0", VA = "0x1852BEDF0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700015A")]
	private bool GCHJHCHGGCH
	{
		[Cpp2IlInjected.Token(Token = "0x6000548")]
		[Cpp2IlInjected.Address(RVA = "0x52BE9B0", Offset = "0x52BDBB0", VA = "0x1852BE9B0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700015B")]
	private OINPHBHEBFM HKAHNOCIENG
	{
		[Cpp2IlInjected.Token(Token = "0x6000549")]
		[Cpp2IlInjected.Address(RVA = "0x52BE950", Offset = "0x52BDB50", VA = "0x1852BE950")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700015C")]
	private bool LLNINBLBFFN
	{
		[Cpp2IlInjected.Token(Token = "0x600054A")]
		[Cpp2IlInjected.Address(RVA = "0x52BF4E0", Offset = "0x52BE6E0", VA = "0x1852BF4E0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400004E")]
	public event FGJCBPBEFOP MLKAKEPMHOI
	{
		[Cpp2IlInjected.Token(Token = "0x6000544")]
		[Cpp2IlInjected.Address(RVA = "0x52BF550", Offset = "0x52BE750", VA = "0x1852BF550", Slot = "4")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000545")]
		[Cpp2IlInjected.Address(RVA = "0x52BF260", Offset = "0x52BE460", VA = "0x1852BF260", Slot = "5")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600054B")]
	[Cpp2IlInjected.Address(RVA = "0x52BF5F0", Offset = "0x52BE7F0", VA = "0x1852BF5F0")]
	public LEJLJDHINGJ(OINPHBHEBFM EHHPLBPDKBE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600054C")]
	[Cpp2IlInjected.Address(RVA = "0x52BF300", Offset = "0x52BE500", VA = "0x1852BF300", Slot = "6")]
	public void JDBMEAOELGO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600054D")]
	[Cpp2IlInjected.Address(RVA = "0x52BF540", Offset = "0x52BE740", VA = "0x1852BF540", Slot = "8")]
	public void OBJEFDDDJLF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600054E")]
	[Cpp2IlInjected.Address(RVA = "0x52BF390", Offset = "0x52BE590", VA = "0x1852BF390", Slot = "7")]
	public bool JIPELJMHGEE()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600054F")]
	[Cpp2IlInjected.Address(RVA = "0x52BEE90", Offset = "0x52BE090", VA = "0x1852BEE90", Slot = "9")]
	public void HILGCFFPCIP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000550")]
	[Cpp2IlInjected.Address(RVA = "0x52BEA10", Offset = "0x52BDC10", VA = "0x1852BEA10", Slot = "11")]
	public void EMMDJJNLKHB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000551")]
	[Cpp2IlInjected.Address(RVA = "0x52BE9D0", Offset = "0x52BDBD0", VA = "0x1852BE9D0", Slot = "12")]
	public void EGIBKKKFHBP(bool JJOFBIIKAHB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000552")]
	[Cpp2IlInjected.Address(RVA = "0x52BEF30", Offset = "0x52BE130", VA = "0x1852BEF30", Slot = "10")]
	public void HNHGDPMCPBD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000553")]
	[Cpp2IlInjected.Address(RVA = "0x52BEC40", Offset = "0x52BDE40", VA = "0x1852BEC40")]
	private bool GCLCJFPENDP()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000554")]
	[Cpp2IlInjected.Address(RVA = "0x52BEAB0", Offset = "0x52BDCB0", VA = "0x1852BEAB0")]
	private void FALKONLFKKA()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200005C")]
internal sealed class PPHBHGPDLAF : COPEPEMIJFF
{
	[Cpp2IlInjected.Token(Token = "0x40000C6")]
	private const string NNKIPIEBCKF = "RBEX_ANIM";

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000C7")]
	private readonly FFNHAGGANGK EHHPLBPDKBE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000C8")]
	private readonly FIHGBEHGLGB BJCKANPHHED;

	[Cpp2IlInjected.Token(Token = "0x1700015D")]
	public Rigidbody JMCCCFFEIIG
	{
		[Cpp2IlInjected.Token(Token = "0x6000555")]
		[Cpp2IlInjected.Address(RVA = "0x6F6390", Offset = "0x6F5590", VA = "0x1806F6390", Slot = "4")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000556")]
		[Cpp2IlInjected.Address(RVA = "0x7BB020", Offset = "0x7BA220", VA = "0x1807BB020")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700015E")]
	private bool LLNINBLBFFN
	{
		[Cpp2IlInjected.Token(Token = "0x6000557")]
		[Cpp2IlInjected.Address(RVA = "0x52B0310", Offset = "0x52AF510", VA = "0x1852B0310")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000558")]
	[Cpp2IlInjected.Address(RVA = "0x52CBF20", Offset = "0x52CB120", VA = "0x1852CBF20")]
	public PPHBHGPDLAF(OINPHBHEBFM EHHPLBPDKBE, in IPGEEHAGLOI PCPEJHIMHJJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000559")]
	[Cpp2IlInjected.Address(RVA = "0x52CB820", Offset = "0x52CAA20", VA = "0x1852CB820", Slot = "5")]
	public void JDBMEAOELGO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600055A")]
	[Cpp2IlInjected.Address(RVA = "0x52CB7F0", Offset = "0x52CA9F0", VA = "0x1852CB7F0", Slot = "6")]
	public void IKBIHMLDNON(object IALNODEHBNN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600055B")]
	[Cpp2IlInjected.Address(RVA = "0x52CAF30", Offset = "0x52CA130", VA = "0x1852CAF30", Slot = "7")]
	public void AIKKIMKHEPL(object IALNODEHBNN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600055C")]
	[Cpp2IlInjected.Address(RVA = "0x52CB290", Offset = "0x52CA490", VA = "0x1852CB290", Slot = "8")]
	public void GDKFAEBPNCL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600055D")]
	[Cpp2IlInjected.Address(RVA = "0x52CB5F0", Offset = "0x52CA7F0", VA = "0x1852CB5F0", Slot = "9")]
	public void GHFFCHLHKOL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600055E")]
	[Cpp2IlInjected.Address(RVA = "0x52CAF60", Offset = "0x52CA160", VA = "0x1852CAF60", Slot = "10")]
	public void DGCJEMMNGLK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600055F")]
	[Cpp2IlInjected.Address(RVA = "0x52CB8D0", Offset = "0x52CAAD0", VA = "0x1852CB8D0", Slot = "11")]
	public void NKAMGMBLDMK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000560")]
	[Cpp2IlInjected.Address(RVA = "0x52CB0E0", Offset = "0x52CA2E0", VA = "0x1852CB0E0")]
	private void DLIAOMALOAD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000561")]
	[Cpp2IlInjected.Address(RVA = "0x52CBD70", Offset = "0x52CAF70", VA = "0x1852CBD70")]
	private void NLHAOKJLAIP()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200005D")]
internal sealed class MINJEANMDIJ : BNAKOLNKNGH, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000CA")]
	private readonly FFNHAGGANGK EHHPLBPDKBE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000CB")]
	private readonly FIHGBEHGLGB BEAEFAIKMNH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000CC")]
	private float EFDGJHIBBHP;

	[Cpp2IlInjected.Token(Token = "0x1700015F")]
	public OEEBBDJIDDP PJJKMCINJBG
	{
		[Cpp2IlInjected.Token(Token = "0x6000562")]
		[Cpp2IlInjected.Address(RVA = "0x75C710", Offset = "0x75B910", VA = "0x18075C710", Slot = "4")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000563")]
		[Cpp2IlInjected.Address(RVA = "0x7BB010", Offset = "0x7BA210", VA = "0x1807BB010", Slot = "5")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000160")]
	public JIKDBJBLNKK GLMECOENJFF
	{
		[Cpp2IlInjected.Token(Token = "0x6000564")]
		[Cpp2IlInjected.Address(RVA = "0x75C700", Offset = "0x75B900", VA = "0x18075C700", Slot = "6")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000565")]
		[Cpp2IlInjected.Address(RVA = "0x7B43F0", Offset = "0x7B35F0", VA = "0x1807B43F0", Slot = "7")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000161")]
	public Vector3 BNMCMLCKBOK
	{
		[Cpp2IlInjected.Token(Token = "0x6000566")]
		[Cpp2IlInjected.Address(RVA = "0x52C2780", Offset = "0x52C1980", VA = "0x1852C2780", Slot = "8")]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x6000567")]
		[Cpp2IlInjected.Address(RVA = "0x52C4110", Offset = "0x52C3310", VA = "0x1852C4110", Slot = "9")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000162")]
	public Vector3 PIHKAJHIGPH
	{
		[Cpp2IlInjected.Token(Token = "0x6000568")]
		[Cpp2IlInjected.Address(RVA = "0x52C3B00", Offset = "0x52C2D00", VA = "0x1852C3B00", Slot = "10")]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x6000569")]
		[Cpp2IlInjected.Address(RVA = "0x52C3BF0", Offset = "0x52C2DF0", VA = "0x1852C3BF0", Slot = "11")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000163")]
	public Vector3 IIALMKBBALJ
	{
		[Cpp2IlInjected.Token(Token = "0x600056A")]
		[Cpp2IlInjected.Address(RVA = "0x52C36A0", Offset = "0x52C28A0", VA = "0x1852C36A0", Slot = "12")]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x600056B")]
		[Cpp2IlInjected.Address(RVA = "0x52C28A0", Offset = "0x52C1AA0", VA = "0x1852C28A0", Slot = "13")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000164")]
	public Vector3 KAHCHGJGLPH
	{
		[Cpp2IlInjected.Token(Token = "0x600056C")]
		[Cpp2IlInjected.Address(RVA = "0x52C3A10", Offset = "0x52C2C10", VA = "0x1852C3A10", Slot = "14")]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x600056D")]
		[Cpp2IlInjected.Address(RVA = "0x52C21A0", Offset = "0x52C13A0", VA = "0x1852C21A0", Slot = "15")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000165")]
	public float LMKDGNICGIN
	{
		[Cpp2IlInjected.Token(Token = "0x600056E")]
		[Cpp2IlInjected.Address(RVA = "0x7B4780", Offset = "0x7B3980", VA = "0x1807B4780", Slot = "16")]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x600056F")]
		[Cpp2IlInjected.Address(RVA = "0x52C2660", Offset = "0x52C1860", VA = "0x1852C2660", Slot = "17")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000166")]
	public bool PHFFHNKCAKG
	{
		[Cpp2IlInjected.Token(Token = "0x6000570")]
		[Cpp2IlInjected.Address(RVA = "0x18FF400", Offset = "0x18FE600", VA = "0x1818FF400", Slot = "18")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000167")]
	private EJPBMJKJDKA PAIBJOCPBJA
	{
		[Cpp2IlInjected.Token(Token = "0x6000585")]
		[Cpp2IlInjected.Address(RVA = "0x16E9550", Offset = "0x16E8750", VA = "0x1816E9550")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000168")]
	private bool GCHJHCHGGCH
	{
		[Cpp2IlInjected.Token(Token = "0x6000586")]
		[Cpp2IlInjected.Address(RVA = "0x52A3F10", Offset = "0x52A3110", VA = "0x1852A3F10")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000571")]
	[Cpp2IlInjected.Address(RVA = "0x52C4E60", Offset = "0x52C4060", VA = "0x1852C4E60")]
	public MINJEANMDIJ(OINPHBHEBFM EHHPLBPDKBE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000572")]
	[Cpp2IlInjected.Address(RVA = "0x52C3630", Offset = "0x52C2830", VA = "0x1852C3630", Slot = "19")]
	public void JDBMEAOELGO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000573")]
	[Cpp2IlInjected.Address(RVA = "0x52C2960", Offset = "0x52C1B60", VA = "0x1852C2960", Slot = "37")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000574")]
	[Cpp2IlInjected.Address(RVA = "0x52C4310", Offset = "0x52C3510", VA = "0x1852C4310", Slot = "28")]
	public void NJINOCNPPGC(Rigidbody NBJEPCGIGPN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000575")]
	[Cpp2IlInjected.Address(RVA = "0x861C50", Offset = "0x860E50", VA = "0x180861C50", Slot = "20")]
	public void JGLKJDEBKJD(object IALNODEHBNN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000576")]
	[Cpp2IlInjected.Address(RVA = "0x861E60", Offset = "0x861060", VA = "0x180861E60", Slot = "31")]
	public void EHJEMGCAHFC(object IALNODEHBNN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000577")]
	[Cpp2IlInjected.Address(RVA = "0x52C3830", Offset = "0x52C2A30", VA = "0x1852C3830", Slot = "36")]
	public Vector3 JLCJMKPHEDJ(Vector3 LMLFDADCHBI)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000578")]
	[Cpp2IlInjected.Address(RVA = "0x52C3340", Offset = "0x52C2540", VA = "0x1852C3340", Slot = "35")]
	public Vector3 HPOIKDMPEGF(Vector3 BPBFEPBHJOA)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000579")]
	[Cpp2IlInjected.Address(RVA = "0x52C3630", Offset = "0x52C2830", VA = "0x1852C3630", Slot = "27")]
	public void OIHOBLKLMEH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600057A")]
	[Cpp2IlInjected.Address(RVA = "0x52C29C0", Offset = "0x52C1BC0", VA = "0x1852C29C0", Slot = "25")]
	public void FFKNMCPIGAB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600057B")]
	[Cpp2IlInjected.Address(RVA = "0x52C21D0", Offset = "0x52C13D0", VA = "0x1852C21D0", Slot = "24")]
	public void BCEKGKJPMMM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600057C")]
	[Cpp2IlInjected.Address(RVA = "0x52C2B40", Offset = "0x52C1D40", VA = "0x1852C2B40", Slot = "34")]
	public void GLPKKFBJAKC(Vector3 PHMOADGIOAB, Vector3 FHAOAKNDIMF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600057D")]
	[Cpp2IlInjected.Address(RVA = "0x52C37D0", Offset = "0x52C29D0", VA = "0x1852C37D0", Slot = "33")]
	public void JGGAJCAAMOB(Vector3 LGOGCCAJHAG, Vector3 NMCANIJEPAA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600057E")]
	[Cpp2IlInjected.Address(RVA = "0x52C41D0", Offset = "0x52C33D0", VA = "0x1852C41D0", Slot = "32")]
	public void MKJDMMPONGJ(Vector3 PLAPBHBFKOO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600057F")]
	[Cpp2IlInjected.Address(RVA = "0x52C2210", Offset = "0x52C1410", VA = "0x1852C2210", Slot = "22")]
	public void CNBEOMCPCEP(LJPGLADCBCM AKMNMFJGAOB, Vector3 GDBGENEPKJJ, float JCOIPNJNGNL, float JCNBFPLMFDC = 8f, float NCEHNBMCDCP = 1f)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000580")]
	[Cpp2IlInjected.Address(RVA = "0x52C2D80", Offset = "0x52C1F80", VA = "0x1852C2D80", Slot = "21")]
	public void HAMEOACBGEL(HKGKLOMPNFJ PLKHOFBGABO, Vector3 FLBMFCPCPEF, float OIOPGDDKGKH = float.PositiveInfinity)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000581")]
	[Cpp2IlInjected.Address(RVA = "0x52C3070", Offset = "0x52C2270", VA = "0x1852C3070", Slot = "23")]
	[Obsolete]
	public void HLLOHDECLDE(HKGKLOMPNFJ PLKHOFBGABO, Vector3 HEGBBJCMANH, float MJJDNDIGKOE = 7f, float KDGELBODBFF = 1f)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000582")]
	[Cpp2IlInjected.Address(RVA = "0x52C3D10", Offset = "0x52C2F10", VA = "0x1852C3D10", Slot = "30")]
	public Vector3 LKFCAEEDGGD(Vector3 OIEPDFJCEHE)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000583")]
	[Cpp2IlInjected.Address(RVA = "0x52C20B0", Offset = "0x52C12B0", VA = "0x1852C20B0", Slot = "29")]
	public Vector3 AIJJDEBMEOJ(Vector3 MEBJBANMPLK)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000584")]
	[Cpp2IlInjected.Address(RVA = "0x52C3500", Offset = "0x52C2700", VA = "0x1852C3500", Slot = "26")]
	public void IDHDDIPDPEN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000587")]
	[Cpp2IlInjected.Address(RVA = "0x52C2660", Offset = "0x52C1860", VA = "0x1852C2660")]
	private void FGCECCNOHHA(float IPMIIEAGJKC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000588")]
	[Cpp2IlInjected.Address(RVA = "0x52C2A00", Offset = "0x52C1C00", VA = "0x1852C2A00")]
	private void GFCGPKJIELB(Vector3 FLBMFCPCPEF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000589")]
	[Cpp2IlInjected.Address(RVA = "0x52C3C20", Offset = "0x52C2E20", VA = "0x1852C3C20")]
	private Vector3 LGFOCDABPHD()
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x600058A")]
	[Cpp2IlInjected.Address(RVA = "0x52C4440", Offset = "0x52C3640", VA = "0x1852C4440")]
	private void ODFONKFPKEI(Vector3 BPBFEPBHJOA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600058B")]
	[Cpp2IlInjected.Address(RVA = "0x52C4770", Offset = "0x52C3970", VA = "0x1852C4770")]
	private Vector3 OLEFKCKECDC()
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x600058C")]
	[Cpp2IlInjected.Address(RVA = "0x52C3DD0", Offset = "0x52C2FD0", VA = "0x1852C3DD0")]
	private void LPOFAPPMPPG(Vector3 IPMIIEAGJKC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600058D")]
	[Cpp2IlInjected.Address(RVA = "0x52C4860", Offset = "0x52C3A60", VA = "0x1852C4860")]
	private void PAGNADEDCHE(Vector3 BPBFEPBHJOA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600058E")]
	[Cpp2IlInjected.Address(RVA = "0x52C2FB0", Offset = "0x52C21B0", VA = "0x1852C2FB0")]
	private void HKNNLIKIPEM()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200005E")]
public class LIIDDEOKMCJ : OGOEFOMBPJH
{
	[Cpp2IlInjected.Token(Token = "0x600058F")]
	[Cpp2IlInjected.Address(RVA = "0x52BFFB0", Offset = "0x52BF1B0", VA = "0x1852BFFB0", Slot = "4")]
	public ACEBILIFEIP EJNJPHFBJAM(OINPHBHEBFM IDCNELICAAG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000590")]
	[Cpp2IlInjected.Address(RVA = "0x52C0340", Offset = "0x52BF540", VA = "0x1852C0340", Slot = "5")]
	public BNAKOLNKNGH OOJKGMEHDNF(OINPHBHEBFM IDCNELICAAG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000591")]
	[Cpp2IlInjected.Address(RVA = "0x52BFAF0", Offset = "0x52BECF0", VA = "0x1852BFAF0", Slot = "6")]
	public OPBHABCMHHK CEEMIGDENAG(OINPHBHEBFM IDCNELICAAG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000592")]
	[Cpp2IlInjected.Address(RVA = "0x52C0220", Offset = "0x52BF420", VA = "0x1852C0220", Slot = "7")]
	public CAMJCFKKLPP MABBNAIELLP(OINPHBHEBFM IDCNELICAAG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000593")]
	[Cpp2IlInjected.Address(RVA = "0x52BFC00", Offset = "0x52BEE00", VA = "0x1852BFC00", Slot = "8")]
	public GEILDFNHLPL CGFFJKNNLNE(OINPHBHEBFM IDCNELICAAG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000594")]
	[Cpp2IlInjected.Address(RVA = "0x52C0160", Offset = "0x52BF360", VA = "0x1852C0160", Slot = "9")]
	public NOIDPDKILCA KOLDEJMAFHK(OINPHBHEBFM IDCNELICAAG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000595")]
	[Cpp2IlInjected.Address(RVA = "0x52BF9F0", Offset = "0x52BEBF0", VA = "0x1852BF9F0", Slot = "10")]
	public KJLCKLHHAII BMLHJBKCGFH(OINPHBHEBFM IDCNELICAAG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000596")]
	[Cpp2IlInjected.Address(RVA = "0x52C0450", Offset = "0x52BF650", VA = "0x1852C0450", Slot = "11")]
	public EJPBMJKJDKA PAFCLIMBNAE(OINPHBHEBFM IDCNELICAAG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000597")]
	[Cpp2IlInjected.Address(RVA = "0x52C0290", Offset = "0x52BF490", VA = "0x1852C0290", Slot = "12")]
	public CEEAALLPPCM OKEMMGAOJKM(OINPHBHEBFM IDCNELICAAG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000598")]
	[Cpp2IlInjected.Address(RVA = "0x52BF840", Offset = "0x52BEA40", VA = "0x1852BF840", Slot = "13")]
	public JIHFCAHMINI BFDNMJBGHBI(OINPHBHEBFM IDCNELICAAG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000599")]
	[Cpp2IlInjected.Address(RVA = "0x52BFD70", Offset = "0x52BEF70", VA = "0x1852BFD70")]
	public COPEPEMIJFF FPJHOFIMCCE(OINPHBHEBFM IDCNELICAAG, in IPGEEHAGLOI PCPEJHIMHJJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600059A")]
	[Cpp2IlInjected.Address(RVA = "0x52BF770", Offset = "0x52BE970", VA = "0x1852BF770")]
	public HDMHGHFDNPO FPADGNCCPBE(OINPHBHEBFM IDCNELICAAG, in IPGEEHAGLOI PCPEJHIMHJJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600059B")]
	[Cpp2IlInjected.Address(RVA = "0x52BFE90", Offset = "0x52BF090", VA = "0x1852BFE90")]
	public POMIHBCAKMM JCPGNOCGCJF(OINPHBHEBFM IDCNELICAAG, in IPGEEHAGLOI PCPEJHIMHJJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600059C")]
	[Cpp2IlInjected.Address(RVA = "0x52BF8F0", Offset = "0x52BEAF0", VA = "0x1852BF8F0")]
	public KMFGIPGBMDB LFCHENHLEOJ(OINPHBHEBFM IDCNELICAAG, in IPGEEHAGLOI PCPEJHIMHJJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600059D")]
	[Cpp2IlInjected.Address(RVA = "0x52C0090", Offset = "0x52BF290", VA = "0x1852C0090")]
	public KJDGGMNDKPF HMGIHLCDOBO(OINPHBHEBFM IDCNELICAAG, in IPGEEHAGLOI PCPEJHIMHJJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600059E")]
	[Cpp2IlInjected.Address(RVA = "0x52BFCC0", Offset = "0x52BEEC0", VA = "0x1852BFCC0", Slot = "19")]
	public OINPHBHEBFM CLHPBOHHPLL(RigidbodyEx EHHPLBPDKBE, IPGEEHAGLOI PCPEJHIMHJJ, LNFAMCIHAGC ACDHNMANGFE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600059F")]
	[Cpp2IlInjected.Address(RVA = "0x703570", Offset = "0x702770", VA = "0x180703570")]
	public LIIDDEOKMCJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60005A0")]
	[Cpp2IlInjected.Address(RVA = "0x52BFD70", Offset = "0x52BEF70", VA = "0x1852BFD70", Slot = "14")]
	private COPEPEMIJFF DDCOFFEPHGK(OINPHBHEBFM IDCNELICAAG, in IPGEEHAGLOI PCPEJHIMHJJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60005A1")]
	[Cpp2IlInjected.Address(RVA = "0x52BF770", Offset = "0x52BE970", VA = "0x1852BF770", Slot = "15")]
	private HDMHGHFDNPO AMDPCMJOHIN(OINPHBHEBFM IDCNELICAAG, in IPGEEHAGLOI PCPEJHIMHJJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60005A2")]
	[Cpp2IlInjected.Address(RVA = "0x52BFE90", Offset = "0x52BF090", VA = "0x1852BFE90", Slot = "16")]
	private POMIHBCAKMM EGCJDLMOKDO(OINPHBHEBFM IDCNELICAAG, in IPGEEHAGLOI PCPEJHIMHJJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60005A3")]
	[Cpp2IlInjected.Address(RVA = "0x52BF8F0", Offset = "0x52BEAF0", VA = "0x1852BF8F0", Slot = "17")]
	private KMFGIPGBMDB BGPFOHNLJNL(OINPHBHEBFM IDCNELICAAG, in IPGEEHAGLOI PCPEJHIMHJJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60005A4")]
	[Cpp2IlInjected.Address(RVA = "0x52C0090", Offset = "0x52BF290", VA = "0x1852C0090", Slot = "18")]
	private KJDGGMNDKPF ICKAOJEOIEH(OINPHBHEBFM IDCNELICAAG, in IPGEEHAGLOI PCPEJHIMHJJ)
	{
		return null;
	}
}
namespace RRAssemblyIndex.RecRoom.Rbex.Runtime
{
	[Cpp2IlInjected.Token(Token = "0x200005F")]
	[Preserve]
	internal class _RRAssemblyIndex : HDLOHLLNPIL
	{
		[Cpp2IlInjected.Token(Token = "0x60005A5")]
		[Cpp2IlInjected.Address(RVA = "0x703EA0", Offset = "0x7030A0", VA = "0x180703EA0")]
		[Preserve]
		public _RRAssemblyIndex()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005A6")]
		[Cpp2IlInjected.Address(RVA = "0x6760420", Offset = "0x675F620", VA = "0x186760420", Slot = "6")]
		public sealed override void FHPMCAKDNGP(DAOLJFMJMGL ONAFALABHKI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005A7")]
		[Cpp2IlInjected.Address(RVA = "0x6760600", Offset = "0x675F800", VA = "0x186760600", Slot = "4")]
		public sealed override void GAJKJBJLBCF()
		{
		}
	}
}
[StructLayout((LayoutKind)3, CharSet = CharSet.Auto)]
[Cpp2IlInjected.Token(Token = "0x2000060")]
public class NFLCIDIFMGO
{
	[Cpp2IlInjected.Token(Token = "0x40000CF")]
	private static byte[] OFIIJNPNABI;

	[Cpp2IlInjected.Token(Token = "0x40000D0")]
	private static int AJJJCGJNNOF;

	[Cpp2IlInjected.Token(Token = "0x40000D1")]
	private static int HJKCCLPHOML;

	[Cpp2IlInjected.Token(Token = "0x40000D2")]
	private static BigInteger KJPEHCDEKDE;

	[Cpp2IlInjected.Token(Token = "0x60005A8")]
	[Cpp2IlInjected.Address(RVA = "0x703570", Offset = "0x702770", VA = "0x180703570")]
	public NFLCIDIFMGO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60005AA")]
	[Cpp2IlInjected.Address(RVA = "0x52C5540", Offset = "0x52C4740", VA = "0x1852C5540")]
	private static string DHECIEFNHGE(byte[] EFNJCAIBDLA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60005AB")]
	[Cpp2IlInjected.Address(RVA = "0x52C5650", Offset = "0x52C4850", VA = "0x1852C5650")]
	public static string EAFEFBMLFGD(byte[] ODBGNNDKAMK, bool MKOEKIGFDJD)
	{
		return null;
	}
}
namespace PrivateImplementationDetailsQOELAJF
{
	[StructLayout((LayoutKind)3, CharSet = CharSet.Auto)]
	[Cpp2IlInjected.Token(Token = "0x2000061")]
	internal class ArrayCopy148
	{
		[StructLayout((LayoutKind)2, Pack = 1, Size = 151)]
		[Cpp2IlInjected.Token(Token = "0x2000062")]
		private struct $ArrayType$151
		{
		}

		[Cpp2IlInjected.Token(Token = "0x40000D3")]
		internal static $ArrayType$151 $$field-0;

		[Cpp2IlInjected.Token(Token = "0x60005AC")]
		[Cpp2IlInjected.Address(RVA = "0x703570", Offset = "0x702770", VA = "0x180703570")]
		public ArrayCopy148()
		{
		}
	}
}
namespace PrivateImplementationDetailsKQPLETG
{
	[StructLayout((LayoutKind)3, CharSet = CharSet.Auto)]
	[Cpp2IlInjected.Token(Token = "0x2000063")]
	public class __BB_OBFUSCATOR_VERSION_3_8_2
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
