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
internal class KHIGDDLLBNM
{
	[Cpp2IlInjected.Token(Token = "0x4000001")]
	public const string JLMJDPOFOFJ = "RBEX_DEFAULT";

	[Cpp2IlInjected.Token(Token = "0x4000002")]
	public const float DOMGMBBKKNL = 0.001f;

	[Cpp2IlInjected.Token(Token = "0x4000003")]
	public const float KAJBIEGIFHM = 0f;

	[Cpp2IlInjected.Token(Token = "0x4000004")]
	public const float IFFPFCEKOFM = 0.05f;

	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(RVA = "0x6A82D0", Offset = "0x6A68D0", VA = "0x1806A82D0")]
	public KHIGDDLLBNM()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
public delegate void HOBHPHAMKBD(RigidbodyEx HEJFGNJDHHA);
[Cpp2IlInjected.Token(Token = "0x2000004")]
public delegate void ABBLHFOFAPM(RigidbodyEx HEJFGNJDHHA, bool JAHLDBIKCJI = false);
[Cpp2IlInjected.Token(Token = "0x2000005")]
public enum CKAOOODELAE
{
	[Cpp2IlInjected.Token(Token = "0x4000006")]
	Additive,
	[Cpp2IlInjected.Token(Token = "0x4000007")]
	Override,
	[Cpp2IlInjected.Token(Token = "0x4000008")]
	Reflective
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public enum CBKDGAPHHKJ
{
	[Cpp2IlInjected.Token(Token = "0x400000A")]
	OnlyForReducedPhysicsRateAndNotParenting,
	[Cpp2IlInjected.Token(Token = "0x400000B")]
	Never,
	[Cpp2IlInjected.Token(Token = "0x400000C")]
	OnEvenWhenParenting
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
public enum MCMFGEDCCGC
{
	[Cpp2IlInjected.Token(Token = "0x400000E")]
	Additive,
	[Cpp2IlInjected.Token(Token = "0x400000F")]
	Override,
	[Cpp2IlInjected.Token(Token = "0x4000010")]
	Reflective
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
public class JDBLGHLEPJL : IPLAPPDCGPJ
{
	[Cpp2IlInjected.Token(Token = "0x17000001")]
	public int LLFNNPACIND
	{
		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x695660", Offset = "0x693C60", VA = "0x180695660", Slot = "4")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	public int LOLMGFJPBPN
	{
		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x777490", Offset = "0x775A90", VA = "0x180777490", Slot = "5")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0x677290", Offset = "0x675890", VA = "0x180677290", Slot = "6")]
	public CEAPFNKIAFO HNHHADBNINI(float JDMNPNJKCII)
	{
		return default(CEAPFNKIAFO);
	}

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0x6A8920", Offset = "0x6A6F20", VA = "0x1806A8920", Slot = "7")]
	public void MFMCNFFMIAP(KCLAPJNLDEK LGKNNMGLNIA, float FFODLHNKOLL, CECCAGGGBNA BFKJAGEEEEO = CECCAGGGBNA.Off)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(RVA = "0x6A8920", Offset = "0x6A6F20", VA = "0x1806A8920", Slot = "8")]
	public void MFMCNFFMIAP(KCLAPJNLDEK LGKNNMGLNIA, Transform BLBOCBHMNFG, float FFODLHNKOLL, CECCAGGGBNA BFKJAGEEEEO = CECCAGGGBNA.Off)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(RVA = "0x6A8920", Offset = "0x6A6F20", VA = "0x1806A8920", Slot = "9")]
	public void LECMNFFELEH(KCLAPJNLDEK LGKNNMGLNIA, [Optional] float? FFODLHNKOLL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(RVA = "0x6A8920", Offset = "0x6A6F20", VA = "0x1806A8920", Slot = "10")]
	public void EMIFMEAGDDE(KCLAPJNLDEK MADBLMMGOPC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(RVA = "0x677290", Offset = "0x675890", VA = "0x180677290", Slot = "11")]
	public CEAPFNKIAFO DKPBJIEGAPJ(KCLAPJNLDEK LGKNNMGLNIA)
	{
		return default(CEAPFNKIAFO);
	}

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(RVA = "0x747120", Offset = "0x745720", VA = "0x180747120", Slot = "12")]
	public bool OEBKBHCCBKH(KCLAPJNLDEK LGKNNMGLNIA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(RVA = "0x6A8920", Offset = "0x6A6F20", VA = "0x1806A8920", Slot = "13")]
	public void CJOGBMHCIKK(KCLAPJNLDEK LGKNNMGLNIA, CECCAGGGBNA NENHIJHKOLI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(RVA = "0x6A82D0", Offset = "0x6A68D0", VA = "0x1806A82D0")]
	public JDBLGHLEPJL()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
[DHKIICMHACJ(typeof(ILPLCBJNHLG), new string[] { "Ignore", "Mock" })]
public class GNLNHMALNKI : ILPLCBJNHLG
{
	[Cpp2IlInjected.Token(Token = "0x17000003")]
	public bool KEDNBFMFDIB
	{
		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0x7F09A0", Offset = "0x7EEFA0", VA = "0x1807F09A0", Slot = "4")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(RVA = "0x6A8920", Offset = "0x6A6F20", VA = "0x1806A8920", Slot = "5")]
	public void CJLBEJJPLHJ(string OOMNIJBIFDC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(RVA = "0x6A8920", Offset = "0x6A6F20", VA = "0x1806A8920", Slot = "6")]
	public void CCBKFKILGIF(RigidbodyEx FHCKPPNILHO, Action PBOHOIMMGFG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(RVA = "0x677290", Offset = "0x675890", VA = "0x180677290", Slot = "7")]
	public IPLAPPDCGPJ AIPGIJNOLBD(int GIHMJHPHLNL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(RVA = "0x6A8920", Offset = "0x6A6F20", VA = "0x1806A8920", Slot = "8")]
	public void FKCBIGGCCPD(Vector3 NOJGOAEBGFN, float DONJHLJNIDL, Color GCBELIJEOPF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(RVA = "0x6A82D0", Offset = "0x6A68D0", VA = "0x1806A82D0")]
	public GNLNHMALNKI()
	{
	}
}
namespace RecRoom
{
	[Cpp2IlInjected.Token(Token = "0x200000A")]
	[DisallowMultipleComponent]
	[DAINLFLPADL(OHEDAGNNHJA.Physics)]
	public sealed class RigidbodyEx : MonoBehaviour
	{
		[Cpp2IlInjected.Token(Token = "0x4000014")]
		private static readonly FGGEJMNNOEE LAEOPKAJMLP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000015")]
		private bool PHMAAFIDHJK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000016")]
		private FFCGIONKJBI KJMBMCGJAMG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000017")]
		[SerializeField]
		[KFELBNBEBCO(BHMLOOPGMEN.Self, false, false, false)]
		private Rigidbody unityRigidbody;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000018")]
		[SerializeField]
		[KFELBNBEBCO(BHMLOOPGMEN.SelfAndParent, true, false, false)]
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
		private CBKDGAPHHKJ physicsInterpolation;

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
		[SerializeField]
		[HideInInspector]
		private bool hasUnityRigidbodyByDefault;

		[Cpp2IlInjected.Token(Token = "0x17000004")]
		internal FFCGIONKJBI JHGMMLCOACP
		{
			[Cpp2IlInjected.Token(Token = "0x600001B")]
			[Cpp2IlInjected.Address(RVA = "0x1CB9420", Offset = "0x1CB7A20", VA = "0x181CB9420")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000005")]
		public IReadOnlyList<RigidbodyEx> KEPEEEPLAGJ
		{
			[Cpp2IlInjected.Token(Token = "0x600002F")]
			[Cpp2IlInjected.Address(RVA = "0x810200", Offset = "0x80E800", VA = "0x180810200")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000030")]
			[Cpp2IlInjected.Address(RVA = "0x753B10", Offset = "0x752110", VA = "0x180753B10")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000006")]
		public RigidbodyEx FNKEKCEGNCI
		{
			[Cpp2IlInjected.Token(Token = "0x6000031")]
			[Cpp2IlInjected.Address(RVA = "0x1CBAAE0", Offset = "0x1CB90E0", VA = "0x181CBAAE0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000007")]
		public RigidbodyEx AMKPOIHFDKH
		{
			[Cpp2IlInjected.Token(Token = "0x6000032")]
			[Cpp2IlInjected.Address(RVA = "0x1CBAA80", Offset = "0x1CB9080", VA = "0x181CBAA80")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000008")]
		public RigidbodyEx LFAIGCEGCPL
		{
			[Cpp2IlInjected.Token(Token = "0x6000033")]
			[Cpp2IlInjected.Address(RVA = "0x1CBB640", Offset = "0x1CB9C40", VA = "0x181CBB640")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000034")]
			[Cpp2IlInjected.Address(RVA = "0x1CBCDA0", Offset = "0x1CBB3A0", VA = "0x181CBCDA0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000009")]
		public Transform DPCGIDOBNGL
		{
			[Cpp2IlInjected.Token(Token = "0x6000035")]
			[Cpp2IlInjected.Address(RVA = "0x10C4290", Offset = "0x10C2890", VA = "0x1810C4290")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000A")]
		public Transform EAILDMMFMIE
		{
			[Cpp2IlInjected.Token(Token = "0x6000036")]
			[Cpp2IlInjected.Address(RVA = "0x10C4290", Offset = "0x10C2890", VA = "0x1810C4290")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000B")]
		public CECCAGGGBNA GGJLBGDDKGJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000037")]
			[Cpp2IlInjected.Address(RVA = "0x1CBA770", Offset = "0x1CB8D70", VA = "0x181CBA770")]
			get
			{
				return default(CECCAGGGBNA);
			}
			[Cpp2IlInjected.Token(Token = "0x6000038")]
			[Cpp2IlInjected.Address(RVA = "0x1CBC330", Offset = "0x1CBA930", VA = "0x181CBC330")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000C")]
		public bool BKKAMGPIPMG
		{
			[Cpp2IlInjected.Token(Token = "0x6000039")]
			[Cpp2IlInjected.Address(RVA = "0x1CBACF0", Offset = "0x1CB92F0", VA = "0x181CBACF0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000D")]
		public bool OFHGFFKKEMJ
		{
			[Cpp2IlInjected.Token(Token = "0x600003A")]
			[Cpp2IlInjected.Address(RVA = "0x1CBA900", Offset = "0x1CB8F00", VA = "0x181CBA900")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000E")]
		public IIENCNCJIKK OEBLLEKPOOI
		{
			[Cpp2IlInjected.Token(Token = "0x600003B")]
			[Cpp2IlInjected.Address(RVA = "0x1CBAC90", Offset = "0x1CB9290", VA = "0x181CBAC90")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600003C")]
			[Cpp2IlInjected.Address(RVA = "0x1CBC550", Offset = "0x1CBAB50", VA = "0x181CBC550")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000F")]
		public JGKAIJBBCDC KPBINMPEPCH
		{
			[Cpp2IlInjected.Token(Token = "0x600003D")]
			[Cpp2IlInjected.Address(RVA = "0x1CBAC30", Offset = "0x1CB9230", VA = "0x181CBAC30")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600003E")]
			[Cpp2IlInjected.Address(RVA = "0x1CBC4E0", Offset = "0x1CBAAE0", VA = "0x181CBC4E0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000010")]
		public bool NKPLDABKJCL
		{
			[Cpp2IlInjected.Token(Token = "0x600003F")]
			[Cpp2IlInjected.Address(RVA = "0x1CBAB10", Offset = "0x1CB9110", VA = "0x181CBAB10")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000011")]
		public Rigidbody BKIDAKAFFMP
		{
			[Cpp2IlInjected.Token(Token = "0x6000040")]
			[Cpp2IlInjected.Address(RVA = "0x1CBAB70", Offset = "0x1CB9170", VA = "0x181CBAB70")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000012")]
		public bool IELKFNIBHFB
		{
			[Cpp2IlInjected.Token(Token = "0x6000041")]
			[Cpp2IlInjected.Address(RVA = "0x1CBA9C0", Offset = "0x1CB8FC0", VA = "0x181CBA9C0")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000042")]
			[Cpp2IlInjected.Address(RVA = "0x1CBC400", Offset = "0x1CBAA00", VA = "0x181CBC400")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000013")]
		public bool PLOENPNIDDH
		{
			[Cpp2IlInjected.Token(Token = "0x6000043")]
			[Cpp2IlInjected.Address(RVA = "0xEEB0F0", Offset = "0xEE96F0", VA = "0x180EEB0F0")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000044")]
			[Cpp2IlInjected.Address(RVA = "0x1CBC3F0", Offset = "0x1CBA9F0", VA = "0x181CBC3F0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000014")]
		public float BCCFBPPIBNF
		{
			[Cpp2IlInjected.Token(Token = "0x6000045")]
			[Cpp2IlInjected.Address(RVA = "0x1CBB5E0", Offset = "0x1CB9BE0", VA = "0x181CBB5E0")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000015")]
		public float MNOFKHGJHAL
		{
			[Cpp2IlInjected.Token(Token = "0x6000046")]
			[Cpp2IlInjected.Address(RVA = "0x1CBB580", Offset = "0x1CB9B80", VA = "0x181CBB580")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x6000047")]
			[Cpp2IlInjected.Address(RVA = "0x1CBCD30", Offset = "0x1CBB330", VA = "0x181CBCD30")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000016")]
		public float ELGKPJENLOI
		{
			[Cpp2IlInjected.Token(Token = "0x6000048")]
			[Cpp2IlInjected.Address(RVA = "0x1CBAF50", Offset = "0x1CB9550", VA = "0x181CBAF50")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x6000049")]
			[Cpp2IlInjected.Address(RVA = "0x1CBC7F0", Offset = "0x1CBADF0", VA = "0x181CBC7F0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000017")]
		public float CHHDLHAEMBC
		{
			[Cpp2IlInjected.Token(Token = "0x600004A")]
			[Cpp2IlInjected.Address(RVA = "0x1CBAD50", Offset = "0x1CB9350", VA = "0x181CBAD50")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x600004B")]
			[Cpp2IlInjected.Address(RVA = "0x1CBC5C0", Offset = "0x1CBABC0", VA = "0x181CBC5C0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000018")]
		public bool DAIBFNHELEC
		{
			[Cpp2IlInjected.Token(Token = "0x600004C")]
			[Cpp2IlInjected.Address(RVA = "0x1CBBB60", Offset = "0x1CBA160", VA = "0x181CBBB60")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x600004D")]
			[Cpp2IlInjected.Address(RVA = "0x1CBD2E0", Offset = "0x1CBB8E0", VA = "0x181CBD2E0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000019")]
		public Vector3 KDBLJOCPCPM
		{
			[Cpp2IlInjected.Token(Token = "0x600004E")]
			[Cpp2IlInjected.Address(RVA = "0x1CBB360", Offset = "0x1CB9960", VA = "0x181CBB360")]
			get
			{
				return default(Vector3);
			}
			[Cpp2IlInjected.Token(Token = "0x600004F")]
			[Cpp2IlInjected.Address(RVA = "0x1CBCB00", Offset = "0x1CBB100", VA = "0x181CBCB00")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001A")]
		public Vector3 NOJGOAEBGFN
		{
			[Cpp2IlInjected.Token(Token = "0x6000050")]
			[Cpp2IlInjected.Address(RVA = "0x1CBBCA0", Offset = "0x1CBA2A0", VA = "0x181CBBCA0")]
			get
			{
				return default(Vector3);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001B")]
		public CollisionDetectionMode GAPECEDJFOA
		{
			[Cpp2IlInjected.Token(Token = "0x6000051")]
			[Cpp2IlInjected.Address(RVA = "0x1CBAE90", Offset = "0x1CB9490", VA = "0x181CBAE90")]
			get
			{
				return default(CollisionDetectionMode);
			}
			[Cpp2IlInjected.Token(Token = "0x6000052")]
			[Cpp2IlInjected.Address(RVA = "0x1CBC710", Offset = "0x1CBAD10", VA = "0x181CBC710")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001C")]
		public float KJKDBCBOHIJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000053")]
			[Cpp2IlInjected.Address(RVA = "0x1CBAA20", Offset = "0x1CB9020", VA = "0x181CBAA20")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x6000054")]
			[Cpp2IlInjected.Address(RVA = "0x1CBC470", Offset = "0x1CBAA70", VA = "0x181CBC470")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001D")]
		public RigidbodyConstraints ILIMCMHHIEN
		{
			[Cpp2IlInjected.Token(Token = "0x6000055")]
			[Cpp2IlInjected.Address(RVA = "0x1CBAEF0", Offset = "0x1CB94F0", VA = "0x181CBAEF0")]
			get
			{
				return default(RigidbodyConstraints);
			}
			[Cpp2IlInjected.Token(Token = "0x6000056")]
			[Cpp2IlInjected.Address(RVA = "0x1CBC780", Offset = "0x1CBAD80", VA = "0x181CBC780")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001E")]
		public Vector3 JIHNPHLJCMM
		{
			[Cpp2IlInjected.Token(Token = "0x6000057")]
			[Cpp2IlInjected.Address(RVA = "0x1CBB6A0", Offset = "0x1CB9CA0", VA = "0x181CBB6A0")]
			get
			{
				return default(Vector3);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001F")]
		public Vector3 AANPNCAOFJC
		{
			[Cpp2IlInjected.Token(Token = "0x6000058")]
			[Cpp2IlInjected.Address(RVA = "0x1CBB6A0", Offset = "0x1CB9CA0", VA = "0x181CBB6A0")]
			get
			{
				return default(Vector3);
			}
			[Cpp2IlInjected.Token(Token = "0x6000059")]
			[Cpp2IlInjected.Address(RVA = "0x1CBD0B0", Offset = "0x1CBB6B0", VA = "0x181CBD0B0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000020")]
		public float HGBKAJOPNCH
		{
			[Cpp2IlInjected.Token(Token = "0x600005A")]
			[Cpp2IlInjected.Address(RVA = "0x1CBB440", Offset = "0x1CB9A40", VA = "0x181CBB440")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x600005B")]
			[Cpp2IlInjected.Address(RVA = "0x1CBCBE0", Offset = "0x1CBB1E0", VA = "0x181CBCBE0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000021")]
		public float NMPAKEMAEHA
		{
			[Cpp2IlInjected.Token(Token = "0x600005C")]
			[Cpp2IlInjected.Address(RVA = "0x1CBBB00", Offset = "0x1CBA100", VA = "0x181CBBB00")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x600005D")]
			[Cpp2IlInjected.Address(RVA = "0x1CBD270", Offset = "0x1CBB870", VA = "0x181CBD270")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000022")]
		public Quaternion DFIHKNCOEJM
		{
			[Cpp2IlInjected.Token(Token = "0x600005E")]
			[Cpp2IlInjected.Address(RVA = "0x1CBB780", Offset = "0x1CB9D80", VA = "0x181CBB780")]
			get
			{
				return default(Quaternion);
			}
			[Cpp2IlInjected.Token(Token = "0x600005F")]
			[Cpp2IlInjected.Address(RVA = "0x1CBCE10", Offset = "0x1CBB410", VA = "0x181CBCE10")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000023")]
		public Quaternion AGPDEBCIBKN
		{
			[Cpp2IlInjected.Token(Token = "0x6000060")]
			[Cpp2IlInjected.Address(RVA = "0x1CBBA20", Offset = "0x1CBA020", VA = "0x181CBBA20")]
			get
			{
				return default(Quaternion);
			}
			[Cpp2IlInjected.Token(Token = "0x6000061")]
			[Cpp2IlInjected.Address(RVA = "0x1CBD190", Offset = "0x1CBB790", VA = "0x181CBD190")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000024")]
		public Vector3 JAOLFALPFED
		{
			[Cpp2IlInjected.Token(Token = "0x6000062")]
			[Cpp2IlInjected.Address(RVA = "0x1CBB860", Offset = "0x1CB9E60", VA = "0x181CBB860")]
			get
			{
				return default(Vector3);
			}
			[Cpp2IlInjected.Token(Token = "0x6000063")]
			[Cpp2IlInjected.Address(RVA = "0x1CBCEF0", Offset = "0x1CBB4F0", VA = "0x181CBCEF0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000025")]
		public Quaternion KLBBPOKDLCL
		{
			[Cpp2IlInjected.Token(Token = "0x6000064")]
			[Cpp2IlInjected.Address(RVA = "0x1CBB940", Offset = "0x1CB9F40", VA = "0x181CBB940")]
			get
			{
				return default(Quaternion);
			}
			[Cpp2IlInjected.Token(Token = "0x6000065")]
			[Cpp2IlInjected.Address(RVA = "0x1CBCFD0", Offset = "0x1CBB5D0", VA = "0x181CBCFD0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000026")]
		public Vector3 CPHPLAEKCBK
		{
			[Cpp2IlInjected.Token(Token = "0x6000066")]
			[Cpp2IlInjected.Address(RVA = "0x1CBBBC0", Offset = "0x1CBA1C0", VA = "0x181CBBBC0")]
			get
			{
				return default(Vector3);
			}
			[Cpp2IlInjected.Token(Token = "0x6000067")]
			[Cpp2IlInjected.Address(RVA = "0x1CBD350", Offset = "0x1CBB950", VA = "0x181CBD350")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000027")]
		public Vector3 OLLLCEPAFHE
		{
			[Cpp2IlInjected.Token(Token = "0x6000068")]
			[Cpp2IlInjected.Address(RVA = "0x1CBB4A0", Offset = "0x1CB9AA0", VA = "0x181CBB4A0")]
			get
			{
				return default(Vector3);
			}
			[Cpp2IlInjected.Token(Token = "0x6000069")]
			[Cpp2IlInjected.Address(RVA = "0x1CBCC50", Offset = "0x1CBB250", VA = "0x181CBCC50")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000028")]
		public Vector3 HOLPFINNOLF
		{
			[Cpp2IlInjected.Token(Token = "0x600006A")]
			[Cpp2IlInjected.Address(RVA = "0x1CBADB0", Offset = "0x1CB93B0", VA = "0x181CBADB0")]
			get
			{
				return default(Vector3);
			}
			[Cpp2IlInjected.Token(Token = "0x600006B")]
			[Cpp2IlInjected.Address(RVA = "0x1CBC630", Offset = "0x1CBAC30", VA = "0x181CBC630")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000029")]
		public Vector3 OGPMEJLJLFA
		{
			[Cpp2IlInjected.Token(Token = "0x600006C")]
			[Cpp2IlInjected.Address(RVA = "0x1CBB280", Offset = "0x1CB9880", VA = "0x181CBB280")]
			get
			{
				return default(Vector3);
			}
			[Cpp2IlInjected.Token(Token = "0x600006D")]
			[Cpp2IlInjected.Address(RVA = "0x1CBCA20", Offset = "0x1CBB020", VA = "0x181CBCA20")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002A")]
		public Vector3 ILIIJCFJEHJ
		{
			[Cpp2IlInjected.Token(Token = "0x600006E")]
			[Cpp2IlInjected.Address(RVA = "0x1CBB140", Offset = "0x1CB9740", VA = "0x181CBB140")]
			get
			{
				return default(Vector3);
			}
			[Cpp2IlInjected.Token(Token = "0x600006F")]
			[Cpp2IlInjected.Address(RVA = "0x1CBC940", Offset = "0x1CBAF40", VA = "0x181CBC940")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002B")]
		public Quaternion LKDKKEEAFEJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000070")]
			[Cpp2IlInjected.Address(RVA = "0x1CBB060", Offset = "0x1CB9660", VA = "0x181CBB060")]
			get
			{
				return default(Quaternion);
			}
			[Cpp2IlInjected.Token(Token = "0x6000071")]
			[Cpp2IlInjected.Address(RVA = "0x1CBC860", Offset = "0x1CBAE60", VA = "0x181CBC860")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002C")]
		public Vector3 DILEEABKBCF
		{
			[Cpp2IlInjected.Token(Token = "0x6000072")]
			[Cpp2IlInjected.Address(RVA = "0x1CBBE60", Offset = "0x1CBA460", VA = "0x181CBBE60")]
			get
			{
				return default(Vector3);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002D")]
		public Vector3 DOGPJJMFEDI
		{
			[Cpp2IlInjected.Token(Token = "0x6000073")]
			[Cpp2IlInjected.Address(RVA = "0x1CBBD80", Offset = "0x1CBA380", VA = "0x181CBBD80")]
			get
			{
				return default(Vector3);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002E")]
		public bool IGMFHMLOGDC
		{
			[Cpp2IlInjected.Token(Token = "0x6000074")]
			[Cpp2IlInjected.Address(RVA = "0x1CBB220", Offset = "0x1CB9820", VA = "0x181CBB220")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002F")]
		public bool CEDDMPPAJDO
		{
			[Cpp2IlInjected.Token(Token = "0x6000075")]
			[Cpp2IlInjected.Address(RVA = "0x1CBA960", Offset = "0x1CB8F60", VA = "0x181CBA960")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000030")]
		public bool KENDHOCAHBA
		{
			[Cpp2IlInjected.Token(Token = "0x6000076")]
			[Cpp2IlInjected.Address(RVA = "0x1CBA8A0", Offset = "0x1CB8EA0", VA = "0x181CBA8A0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000031")]
		public bool EHJFPLNBAAH
		{
			[Cpp2IlInjected.Token(Token = "0x6000077")]
			[Cpp2IlInjected.Address(RVA = "0x1CBA840", Offset = "0x1CB8E40", VA = "0x181CBA840")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000032")]
		public bool PLHBBEKOBGN
		{
			[Cpp2IlInjected.Token(Token = "0x6000078")]
			[Cpp2IlInjected.Address(RVA = "0x1CBA710", Offset = "0x1CB8D10", VA = "0x181CBA710")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000033")]
		public bool KIGGBNOJLJJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000079")]
			[Cpp2IlInjected.Address(RVA = "0x1CBAFB0", Offset = "0x1CB95B0", VA = "0x181CBAFB0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000034")]
		public bool MGEAADBCNEJ
		{
			[Cpp2IlInjected.Token(Token = "0x600007A")]
			[Cpp2IlInjected.Address(RVA = "0x706630", Offset = "0x704C30", VA = "0x180706630")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000001")]
		public event HOBHPHAMKBD COOHJIJKDEA
		{
			[Cpp2IlInjected.Token(Token = "0x600001D")]
			[Cpp2IlInjected.Address(RVA = "0x1CBA630", Offset = "0x1CB8C30", VA = "0x181CBA630")]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x600001E")]
			[Cpp2IlInjected.Address(RVA = "0x1CBC250", Offset = "0x1CBA850", VA = "0x181CBC250")]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000002")]
		public event ABBLHFOFAPM GIHKCKOLIHJ
		{
			[Cpp2IlInjected.Token(Token = "0x600001F")]
			[Cpp2IlInjected.Address(RVA = "0x1CBA5C0", Offset = "0x1CB8BC0", VA = "0x181CBA5C0")]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000020")]
			[Cpp2IlInjected.Address(RVA = "0x1CBC1E0", Offset = "0x1CBA7E0", VA = "0x181CBC1E0")]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000003")]
		public event HOBHPHAMKBD IAOFFICNEFM
		{
			[Cpp2IlInjected.Token(Token = "0x6000021")]
			[Cpp2IlInjected.Address(RVA = "0x1CBA320", Offset = "0x1CB8920", VA = "0x181CBA320")]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000022")]
			[Cpp2IlInjected.Address(RVA = "0x1CBBF40", Offset = "0x1CBA540", VA = "0x181CBBF40")]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000004")]
		public event HOBHPHAMKBD BPJGPOJJOIC
		{
			[Cpp2IlInjected.Token(Token = "0x6000023")]
			[Cpp2IlInjected.Address(RVA = "0x1CBA390", Offset = "0x1CB8990", VA = "0x181CBA390")]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000024")]
			[Cpp2IlInjected.Address(RVA = "0x1CBBFB0", Offset = "0x1CBA5B0", VA = "0x181CBBFB0")]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000005")]
		public event HOBHPHAMKBD MPMMHJCOBJO
		{
			[Cpp2IlInjected.Token(Token = "0x6000025")]
			[Cpp2IlInjected.Address(RVA = "0x1CBA4E0", Offset = "0x1CB8AE0", VA = "0x181CBA4E0")]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000026")]
			[Cpp2IlInjected.Address(RVA = "0x1CBC100", Offset = "0x1CBA700", VA = "0x181CBC100")]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000006")]
		public event Action<CEAPFNKIAFO, CEAPFNKIAFO> GAJNIIPFKOP
		{
			[Cpp2IlInjected.Token(Token = "0x6000027")]
			[Cpp2IlInjected.Address(RVA = "0x1CBA470", Offset = "0x1CB8A70", VA = "0x181CBA470")]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000028")]
			[Cpp2IlInjected.Address(RVA = "0x1CBC090", Offset = "0x1CBA690", VA = "0x181CBC090")]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000007")]
		public event HOBHPHAMKBD BAGPPKHMIEK
		{
			[Cpp2IlInjected.Token(Token = "0x6000029")]
			[Cpp2IlInjected.Address(RVA = "0x1CBA550", Offset = "0x1CB8B50", VA = "0x181CBA550")]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x600002A")]
			[Cpp2IlInjected.Address(RVA = "0x1CBC170", Offset = "0x1CBA770", VA = "0x181CBC170")]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000008")]
		public event HOBHPHAMKBD AHGHHKNNOOF
		{
			[Cpp2IlInjected.Token(Token = "0x600002B")]
			[Cpp2IlInjected.Address(RVA = "0x1CBA6A0", Offset = "0x1CB8CA0", VA = "0x181CBA6A0")]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x600002C")]
			[Cpp2IlInjected.Address(RVA = "0x1CBC2C0", Offset = "0x1CBA8C0", VA = "0x181CBC2C0")]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000009")]
		public event HOBHPHAMKBD JDPDGOHICPK
		{
			[Cpp2IlInjected.Token(Token = "0x600002D")]
			[Cpp2IlInjected.Address(RVA = "0x1CBA400", Offset = "0x1CB8A00", VA = "0x181CBA400")]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x600002E")]
			[Cpp2IlInjected.Address(RVA = "0x1CBC020", Offset = "0x1CBA620", VA = "0x181CBC020")]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(RVA = "0x70DB30", Offset = "0x70C130", VA = "0x18070DB30")]
		internal void EKCHCBGJJIL(FFCGIONKJBI BMFGKMDOFCF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007B")]
		[Cpp2IlInjected.Address(RVA = "0x1CB89A0", Offset = "0x1CB6FA0", VA = "0x181CB89A0")]
		private void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007C")]
		[Cpp2IlInjected.Address(RVA = "0x1CB9420", Offset = "0x1CB7A20", VA = "0x181CB9420")]
		private FFCGIONKJBI MDDDKMBLKCN()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600007D")]
		[Cpp2IlInjected.Address(RVA = "0x1CB8EB0", Offset = "0x1CB74B0", VA = "0x181CB8EB0")]
		private void IFEPEMKMGAF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007E")]
		[Cpp2IlInjected.Address(RVA = "0x1CB9630", Offset = "0x1CB7C30", VA = "0x181CB9630")]
		private void OnEnable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007F")]
		[Cpp2IlInjected.Address(RVA = "0x1CB9530", Offset = "0x1CB7B30", VA = "0x181CB9530")]
		private void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000080")]
		[Cpp2IlInjected.Address(RVA = "0x1CB8C50", Offset = "0x1CB7250", VA = "0x181CB8C50")]
		private void FixedUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000081")]
		[Cpp2IlInjected.Address(RVA = "0x1CB95D0", Offset = "0x1CB7BD0", VA = "0x181CB95D0")]
		private void OnDrawGizmosSelected()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000082")]
		[Cpp2IlInjected.Address(RVA = "0x1CB9690", Offset = "0x1CB7C90", VA = "0x181CB9690")]
		private void OnValidate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000083")]
		[Cpp2IlInjected.Address(RVA = "0x1CB8030", Offset = "0x1CB6630", VA = "0x181CB8030")]
		public void AddDoNotResetVelocityOnOwnershipChangeOverride(object HKLDIENGNNB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000084")]
		[Cpp2IlInjected.Address(RVA = "0x1CB9700", Offset = "0x1CB7D00", VA = "0x181CB9700")]
		public void RemoveDoNotResetVelocityOnOwnershipChangeOverride(object HKLDIENGNNB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000085")]
		[Cpp2IlInjected.Address(RVA = "0x1CB8BF0", Offset = "0x1CB71F0", VA = "0x181CB8BF0")]
		public void DisableCachedInertialPropertyOverride()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000086")]
		[Cpp2IlInjected.Address(RVA = "0x1CB94D0", Offset = "0x1CB7AD0", VA = "0x181CB94D0")]
		public void MarkCachedInertialParametersDirty()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000087")]
		[Cpp2IlInjected.Address(RVA = "0x1CB9EF0", Offset = "0x1CB84F0", VA = "0x181CB9EF0")]
		public void SetParent(RigidbodyEx MAKFNMHIJIF, bool JAHLDBIKCJI = false)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000088")]
		[Cpp2IlInjected.Address(RVA = "0x1CB9A10", Offset = "0x1CB8010", VA = "0x181CB9A10")]
		public void ResetLocalCenterOfMassToPrefabDefault()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000089")]
		[Cpp2IlInjected.Address(RVA = "0x1CB9240", Offset = "0x1CB7840", VA = "0x181CB9240")]
		public bool IsRigidbodyAncestor(RigidbodyEx EPDAFINDPJC)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600008A")]
		[Cpp2IlInjected.Address(RVA = "0x1CB9280", Offset = "0x1CB7880", VA = "0x181CB9280")]
		public bool IsRigidbodyDescendant(RigidbodyEx PPMNPHOOLCH)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600008B")]
		[Cpp2IlInjected.Address(RVA = "0x1CB8250", Offset = "0x1CB6850", VA = "0x181CB8250")]
		public void AddInterpolationRestriction(object HKLDIENGNNB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008C")]
		[Cpp2IlInjected.Address(RVA = "0x1CB9770", Offset = "0x1CB7D70", VA = "0x181CB9770")]
		public void RemoveInterpolationRestriction(object HKLDIENGNNB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008D")]
		[Cpp2IlInjected.Address(RVA = "0x1CB8A10", Offset = "0x1CB7010", VA = "0x181CB8A10")]
		public IDisposable BeginKinematicScope()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600008E")]
		[Cpp2IlInjected.Address(RVA = "0x1CB82C0", Offset = "0x1CB68C0", VA = "0x181CB82C0")]
		public void AddKinematic(object HKLDIENGNNB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008F")]
		[Cpp2IlInjected.Address(RVA = "0x1CB97E0", Offset = "0x1CB7DE0", VA = "0x181CB97E0")]
		public void RemoveKinematic(object HKLDIENGNNB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000090")]
		[Cpp2IlInjected.Address(RVA = "0x1CB9E70", Offset = "0x1CB8470", VA = "0x181CB9E70")]
		public void SetKinematic(object HKLDIENGNNB, bool BKHDMOGADPG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000091")]
		[Cpp2IlInjected.Address(RVA = "0x1CB9D70", Offset = "0x1CB8370", VA = "0x181CB9D70")]
		public void SetDiscontinuousPositionAndRotation(Vector3 AFHANPMAJON, Quaternion MGLHGJDPDPO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000092")]
		[Cpp2IlInjected.Address(RVA = "0x1CB9C70", Offset = "0x1CB8270", VA = "0x181CB9C70")]
		public void SetDiscontinuousLocalPositionAndLocalRotation(Vector3 JGOFLNCMNEF, Quaternion HHGDJGKIPDH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000093")]
		[Cpp2IlInjected.Address(RVA = "0x1CB8DB0", Offset = "0x1CB73B0", VA = "0x181CB8DB0")]
		public Vector3 GetConstrainedVelocity(Vector3 CPHPLAEKCBK)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x6000094")]
		[Cpp2IlInjected.Address(RVA = "0x1CB8CB0", Offset = "0x1CB72B0", VA = "0x181CB8CB0")]
		public Vector3 GetConstrainedAngularVelocity(Vector3 HOLPFINNOLF)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x6000095")]
		[Cpp2IlInjected.Address(RVA = "0x1CB81C0", Offset = "0x1CB67C0", VA = "0x181CB81C0")]
		public void AddForce(Vector3 CBEIFKNKIIE, ForceMode OEBHACLNMCB = ForceMode.Force)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000096")]
		[Cpp2IlInjected.Address(RVA = "0x1CB80A0", Offset = "0x1CB66A0", VA = "0x181CB80A0")]
		public void AddForceAtPosition(Vector3 CBEIFKNKIIE, Vector3 EINGNKDKDHC, ForceMode OEBHACLNMCB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000097")]
		[Cpp2IlInjected.Address(RVA = "0x1CB83C0", Offset = "0x1CB69C0", VA = "0x181CB83C0")]
		public void AddTorque(Vector3 DEMLAEGANDJ, ForceMode OEBHACLNMCB = ForceMode.Force)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000098")]
		[Cpp2IlInjected.Address(RVA = "0x1CB8330", Offset = "0x1CB6930", VA = "0x181CB8330")]
		public void AddRelativeTorque(Vector3 DEMLAEGANDJ, ForceMode OEBHACLNMCB = ForceMode.Force)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000099")]
		[Cpp2IlInjected.Address(RVA = "0x1CBA150", Offset = "0x1CB8750", VA = "0x181CBA150")]
		public Vector3 WorldToLocalVelocity(Vector3 JMLACAFKJOF)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x600009A")]
		[Cpp2IlInjected.Address(RVA = "0x1CB9320", Offset = "0x1CB7920", VA = "0x181CB9320")]
		public Vector3 LocalToWorldVelocity(Vector3 OLLLCEPAFHE)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x600009B")]
		[Cpp2IlInjected.Address(RVA = "0x1CB8B90", Offset = "0x1CB7190", VA = "0x181CB8B90")]
		public void ClearVelocity()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009C")]
		[Cpp2IlInjected.Address(RVA = "0x1CB8B30", Offset = "0x1CB7130", VA = "0x181CB8B30")]
		public void ClearUnityRigidbodyVelocity()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009D")]
		[Cpp2IlInjected.Address(RVA = "0x1CB8AD0", Offset = "0x1CB70D0", VA = "0x181CB8AD0")]
		public void ClearLinearVelocity()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009E")]
		[Cpp2IlInjected.Address(RVA = "0x1CB8A70", Offset = "0x1CB7070", VA = "0x181CB8A70")]
		public void ClearAngularVelocity()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009F")]
		[Cpp2IlInjected.Address(RVA = "0x1CB9B70", Offset = "0x1CB8170", VA = "0x181CB9B70")]
		public void ResetVelocityWorldSpace(Vector3 PFDFFPLAJJP, Vector3 HGIFCPKBAGG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A0")]
		[Cpp2IlInjected.Address(RVA = "0x1CB9A70", Offset = "0x1CB8070", VA = "0x181CB9A70")]
		public void ResetVelocityLocalSpace(Vector3 LOGKBIHCFJD, Vector3 OGPMEJLJLFA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A1")]
		[Cpp2IlInjected.Address(RVA = "0x1CB9930", Offset = "0x1CB7F30", VA = "0x181CB9930")]
		public void ResetLinearVelocityLocalSpace(Vector3 LOGKBIHCFJD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A2")]
		[Cpp2IlInjected.Address(RVA = "0x1CB9FE0", Offset = "0x1CB85E0", VA = "0x181CB9FE0")]
		public bool SweepTest(Vector3 FOGEFLLJLFJ, out RaycastHit LOOJGACDMOC, float IDHCBHDHMCK)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000A3")]
		[Cpp2IlInjected.Address(RVA = "0x1CB92C0", Offset = "0x1CB78C0", VA = "0x181CB92C0")]
		public bool IsSleeping()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000A4")]
		[Cpp2IlInjected.Address(RVA = "0x1CB9F80", Offset = "0x1CB8580", VA = "0x181CB9F80")]
		public void Sleep()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A5")]
		[Cpp2IlInjected.Address(RVA = "0x1CBA0F0", Offset = "0x1CB86F0", VA = "0x181CBA0F0")]
		public void WakeUp()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A6")]
		[Cpp2IlInjected.Address(RVA = "0x1CB8450", Offset = "0x1CB6A50", VA = "0x181CB8450")]
		public void AddUnityRigidbody(object HKLDIENGNNB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A7")]
		[Cpp2IlInjected.Address(RVA = "0x1CB9850", Offset = "0x1CB7E50", VA = "0x181CB9850")]
		public void RemoveUnityRigidbody(object HKLDIENGNNB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A8")]
		[Cpp2IlInjected.Address(RVA = "0x1CB8770", Offset = "0x1CB6D70", VA = "0x181CB8770")]
		public void ApplyForceVelocityChange(CKAOOODELAE IKFPEHIFEPN, Vector3 NMBFBKMEJKN, float FEHHFHACKBK, float IOFMPFNPHNC = 8f, float JKLGNKAKKLG = 1f)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A9")]
		[Cpp2IlInjected.Address(RVA = "0x1CB8670", Offset = "0x1CB6C70", VA = "0x181CB8670")]
		public void ApplyAngularVelocityChange(MCMFGEDCCGC LMLMHHPMBJO, Vector3 OFLGCJLDNJJ, float IPAPNFBMGEF = float.PositiveInfinity)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AA")]
		[Cpp2IlInjected.Address(RVA = "0x1CB8890", Offset = "0x1CB6E90", VA = "0x181CB8890")]
		[Obsolete]
		public void ApplyTorqueAngularVelocityChangeDeprecated(MCMFGEDCCGC LMLMHHPMBJO, Vector3 JGCPJBFFFAC, float NMBEKOOKPJA = 7f, float MFBAPHBIEKM = 1f)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AB")]
		[Cpp2IlInjected.Address(RVA = "0x1CB85B0", Offset = "0x1CB6BB0", VA = "0x181CB85B0")]
		public bool AllowedScaleChange(float CJJGIOGGJMO)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000AC")]
		[Cpp2IlInjected.Address(RVA = "0x1CB84C0", Offset = "0x1CB6AC0", VA = "0x181CB84C0")]
		public void AddWorldSpaceVelocityInHierarchyParentOverride(RigidbodyEx HJFPEPOCKIC, object HKLDIENGNNB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AD")]
		[Cpp2IlInjected.Address(RVA = "0x1CB98C0", Offset = "0x1CB7EC0", VA = "0x181CB98C0")]
		public void RemoveWorldSpaceVelocityInHierarchyParentOverride(object HKLDIENGNNB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AE")]
		[Cpp2IlInjected.Address(RVA = "0x1CBA2A0", Offset = "0x1CB88A0", VA = "0x181CBA2A0")]
		public RigidbodyEx()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
internal static class LBJKOHGMCPE
{
	[Cpp2IlInjected.Token(Token = "0x60000B3")]
	[Cpp2IlInjected.Address(RVA = "0x5450D90", Offset = "0x544F390", VA = "0x185450D90")]
	public static FFCGIONKJBI JHGMMLCOACP(this RigidbodyEx FHCKPPNILHO)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
public struct IMECCMKFBII
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000022")]
	public Rigidbody MKOMGOCHBJC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000023")]
	public PhotonView GJEOCFNIENJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000024")]
	public OverridableVector3 KKHPEDMDNHD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000025")]
	public OverridableVector3 HGJNFBEOBMB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000026")]
	public CBKDGAPHHKJ BKKPLIKBIMJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
	[Cpp2IlInjected.Token(Token = "0x4000027")]
	public bool KHABMLAAPHG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x35")]
	[Cpp2IlInjected.Token(Token = "0x4000028")]
	public bool LDNCGNJHOLI;
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
[DHKIICMHACJ(typeof(MPHIHDCLPDB), new string[] { })]
public class OFGPJGFLJPA : MPHIHDCLPDB, GOJCOOFCPOI
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000029")]
	private PCJLBILJHMN NBBMAFFHAAA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400002A")]
	private ILPLCBJNHLG NBJJAAKBODP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400002B")]
	private LGNFMEIAMDG CHMHOLIMEDK;

	[Cpp2IlInjected.Token(Token = "0x17000035")]
	public bool JIIADOBNPCP
	{
		[Cpp2IlInjected.Token(Token = "0x60000B4")]
		[Cpp2IlInjected.Address(RVA = "0x545AB60", Offset = "0x5459160", VA = "0x18545AB60", Slot = "6")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000036")]
	public ILPLCBJNHLG KEPKLMOMNIE
	{
		[Cpp2IlInjected.Token(Token = "0x60000B5")]
		[Cpp2IlInjected.Address(RVA = "0x706850", Offset = "0x704E50", VA = "0x180706850", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000037")]
	public LGNFMEIAMDG AAIBAGIBCOG
	{
		[Cpp2IlInjected.Token(Token = "0x60000B6")]
		[Cpp2IlInjected.Address(RVA = "0x706620", Offset = "0x704C20", VA = "0x180706620", Slot = "5")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000B7")]
	[Cpp2IlInjected.Address(RVA = "0x545A9E0", Offset = "0x5458FE0", VA = "0x18545A9E0", Slot = "10")]
	public void NDFJIGFEFMN(PFKGIHKPIGG GOCENLCAMDB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B8")]
	[Cpp2IlInjected.Address(RVA = "0x545A610", Offset = "0x5458C10", VA = "0x18545A610", Slot = "7")]
	public NIALADIPDNC DJNCPPLECDP(RigidbodyEx FHCKPPNILHO)
	{
		return default(NIALADIPDNC);
	}

	[Cpp2IlInjected.Token(Token = "0x60000B9")]
	[Cpp2IlInjected.Address(RVA = "0x545AA70", Offset = "0x5459070", VA = "0x18545AA70")]
	private static NIALADIPDNC PDLLBGNJLCN(RigidbodyEx FHCKPPNILHO)
	{
		return default(NIALADIPDNC);
	}

	[Cpp2IlInjected.Token(Token = "0x60000BA")]
	[Cpp2IlInjected.Address(RVA = "0x545A570", Offset = "0x5458B70", VA = "0x18545A570", Slot = "8")]
	public FFCGIONKJBI CAKONGBGLCH(RigidbodyEx FHCKPPNILHO, IMECCMKFBII JIHCLPECHIB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000BB")]
	[Cpp2IlInjected.Address(RVA = "0x545A8B0", Offset = "0x5458EB0", VA = "0x18545A8B0", Slot = "9")]
	private RigidbodyEx EKIBPBAJBJF(GameObject POFNLMLLLOA, IMECCMKFBII JIHCLPECHIB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000BC")]
	[Cpp2IlInjected.Address(RVA = "0x6A82D0", Offset = "0x6A68D0", VA = "0x1806A82D0")]
	public OFGPJGFLJPA()
	{
	}
}
namespace RecRoom
{
	[Cpp2IlInjected.Token(Token = "0x200000F")]
	public class PhysicsManager : SingletonMonoBehaviour<PhysicsManager>
	{
		[Cpp2IlInjected.Token(Token = "0x400002C")]
		public static FHIFKLKAEJA UpdateAfterFixedUpdateRan;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400002D")]
		private int ICFPJPJKGOO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x400002E")]
		private int IEPDAJPMGIH;

		[Cpp2IlInjected.Token(Token = "0x60000BD")]
		[Cpp2IlInjected.Address(RVA = "0x1CB7B10", Offset = "0x1CB6110", VA = "0x181CB7B10")]
		protected void FixedUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000BE")]
		[Cpp2IlInjected.Address(RVA = "0x1CB7B50", Offset = "0x1CB6150", VA = "0x181CB7B50")]
		protected void Update()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000BF")]
		[Cpp2IlInjected.Address(RVA = "0x1CB7B30", Offset = "0x1CB6130", VA = "0x181CB7B30")]
		protected void LateUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C0")]
		[Cpp2IlInjected.Address(RVA = "0x6A8920", Offset = "0x6A6F20", VA = "0x1806A8920")]
		[Conditional("UNITY_ASSERTIONS")]
		public void AssertLateColliderPositionsNotYetUpdated([Optional] string DIDMFBHHIEC, [Optional] UnityEngine.Object JOOJGLPIMBB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C1")]
		[Cpp2IlInjected.Address(RVA = "0x6A8920", Offset = "0x6A6F20", VA = "0x1806A8920")]
		[Conditional("UNITY_ASSERTIONS")]
		public void AssertLateColliderPositionsAlreadyUpdated([Optional] string DIDMFBHHIEC, [Optional] UnityEngine.Object JOOJGLPIMBB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C2")]
		[Cpp2IlInjected.Address(RVA = "0x1CB7C40", Offset = "0x1CB6240", VA = "0x181CB7C40")]
		public PhysicsManager()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
public static class ACKNGOIHNIM
{
	[Cpp2IlInjected.Token(Token = "0x60000C4")]
	[Cpp2IlInjected.Address(RVA = "0x5432830", Offset = "0x5430E30", VA = "0x185432830")]
	public static void AKMPDFHDMEE(this Rigidbody OIGIAECEHDG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C5")]
	[Cpp2IlInjected.Address(RVA = "0x5432720", Offset = "0x5430D20", VA = "0x185432720")]
	public static void AKMPDFHDMEE(this Rigidbody OIGIAECEHDG, Vector3 ILIIJCFJEHJ, Quaternion LKDKKEEAFEJ, Vector3 CMPHOGNEMFN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C6")]
	[Cpp2IlInjected.Address(RVA = "0x5432980", Offset = "0x5430F80", VA = "0x185432980")]
	public static void NIIFBNIMDPI(Vector3 CPHPLAEKCBK, Vector3 FACACMFGKHI, out Vector3 KGFFEPAJKCM, out Vector3 DPBJPIBFIOM)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
public static class ACJPJOHKBOB
{
	[Cpp2IlInjected.Token(Token = "0x2000012")]
	private class GKKNALCIODH : IIENCNCJIKK, IDisposable
	{
		[Cpp2IlInjected.Token(Token = "0x60000C9")]
		[Cpp2IlInjected.Address(RVA = "0x6A8920", Offset = "0x6A6F20", VA = "0x1806A8920", Slot = "6")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000CA")]
		[Cpp2IlInjected.Address(RVA = "0xAA81A0", Offset = "0xAA67A0", VA = "0x180AA81A0", Slot = "4")]
		public Vector3 NMMDPBJGGGJ()
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x60000CB")]
		[Cpp2IlInjected.Address(RVA = "0xAA81A0", Offset = "0xAA67A0", VA = "0x180AA81A0", Slot = "5")]
		public Vector3 CHBOIJCOGNN()
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x60000CC")]
		[Cpp2IlInjected.Address(RVA = "0x6A82D0", Offset = "0x6A68D0", VA = "0x1806A82D0")]
		public GKKNALCIODH()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000038")]
	public static IIENCNCJIKK GBPPBMLHFNG
	{
		[Cpp2IlInjected.Token(Token = "0x60000C7")]
		[Cpp2IlInjected.Address(RVA = "0x5432650", Offset = "0x5430C50", VA = "0x185432650")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000013")]
public interface MFNEPAJBKBE
{
	[Cpp2IlInjected.Token(Token = "0x17000039")]
	CollisionDetectionMode GDCFMCCNNGL
	{
		[Cpp2IlInjected.Token(Token = "0x60000CD")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
		[Cpp2IlInjected.Token(Token = "0x60000CE")]
		[Cpp2IlInjected.Address(Slot = "1")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x60000CF")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void NOMIHBFFLNG();

	[Cpp2IlInjected.Token(Token = "0x60000D0")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void FICELACKBCB(bool IGMFHMLOGDC);

	[Cpp2IlInjected.Token(Token = "0x60000D1")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void GDPJJGMKJBP(bool IGMFHMLOGDC);

	[Cpp2IlInjected.Token(Token = "0x60000D2")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void KDPOLAHOOPE(Rigidbody MKOMGOCHBJC);

	[Cpp2IlInjected.Token(Token = "0x60000D3")]
	[Cpp2IlInjected.Address(Slot = "6")]
	bool COKAFBGHKMH(Vector3 FOGEFLLJLFJ, out RaycastHit LOOJGACDMOC, float IDHCBHDHMCK);
}
[Cpp2IlInjected.Token(Token = "0x2000014")]
public interface CGKAANMHLMI : IDisposable, KCLAPJNLDEK
{
	[Cpp2IlInjected.Token(Token = "0x1700003A")]
	CKHEJONCKGK GGJLBGDDKGJ
	{
		[Cpp2IlInjected.Token(Token = "0x60000D6")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
		[Cpp2IlInjected.Token(Token = "0x60000D7")]
		[Cpp2IlInjected.Address(Slot = "3")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x1400000A")]
	event Action<CEAPFNKIAFO, CEAPFNKIAFO> GAJNIIPFKOP;

	[Cpp2IlInjected.Token(Token = "0x60000D8")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void NOMIHBFFLNG();
}
[Cpp2IlInjected.Token(Token = "0x2000015")]
[LOICNDEPMOJ(HIFIKBEHMNK.Application)]
public interface LGNFMEIAMDG
{
	[Cpp2IlInjected.Token(Token = "0x60000D9")]
	[Cpp2IlInjected.Address(Slot = "0")]
	IPLGDMEHBOJ JLMEDKOMLPH(FFCGIONKJBI BMFGKMDOFCF);

	[Cpp2IlInjected.Token(Token = "0x60000DA")]
	[Cpp2IlInjected.Address(Slot = "1")]
	GLBLEGFKOKL FNHIMIMINLC(FFCGIONKJBI BMFGKMDOFCF);

	[Cpp2IlInjected.Token(Token = "0x60000DB")]
	[Cpp2IlInjected.Address(Slot = "2")]
	EBAADMBJLMD IIOHLMKEJEJ(FFCGIONKJBI BMFGKMDOFCF);

	[Cpp2IlInjected.Token(Token = "0x60000DC")]
	[Cpp2IlInjected.Address(Slot = "3")]
	EKNFOOIEIBK NHGIHLGNLLB(FFCGIONKJBI BMFGKMDOFCF);

	[Cpp2IlInjected.Token(Token = "0x60000DD")]
	[Cpp2IlInjected.Address(Slot = "4")]
	MNHBOEHCOIK AMEBPOAGMKI(FFCGIONKJBI BMFGKMDOFCF);

	[Cpp2IlInjected.Token(Token = "0x60000DE")]
	[Cpp2IlInjected.Address(Slot = "5")]
	CGKAANMHLMI CCKENOLAJIO(FFCGIONKJBI BMFGKMDOFCF);

	[Cpp2IlInjected.Token(Token = "0x60000DF")]
	[Cpp2IlInjected.Address(Slot = "6")]
	MAMDKJFPNFM AOODCJDCKDB(FFCGIONKJBI BMFGKMDOFCF);

	[Cpp2IlInjected.Token(Token = "0x60000E0")]
	[Cpp2IlInjected.Address(Slot = "7")]
	GIGBMEPJFND IIMNBFJLPGA(FFCGIONKJBI BMFGKMDOFCF);

	[Cpp2IlInjected.Token(Token = "0x60000E1")]
	[Cpp2IlInjected.Address(Slot = "8")]
	MFNEPAJBKBE GLEBFEAEHBH(FFCGIONKJBI BMFGKMDOFCF);

	[Cpp2IlInjected.Token(Token = "0x60000E2")]
	[Cpp2IlInjected.Address(Slot = "9")]
	JJPLOLDPKDF BBOIPMMNANN(FFCGIONKJBI BMFGKMDOFCF);

	[Cpp2IlInjected.Token(Token = "0x60000E3")]
	[Cpp2IlInjected.Address(Slot = "10")]
	OOPDNBAAJIE LKGBOKHAFIF(FFCGIONKJBI BMFGKMDOFCF, in IMECCMKFBII JIHCLPECHIB);

	[Cpp2IlInjected.Token(Token = "0x60000E4")]
	[Cpp2IlInjected.Address(Slot = "11")]
	BHMDAAMOACJ GLKJADAGIAD(FFCGIONKJBI BMFGKMDOFCF, in IMECCMKFBII JIHCLPECHIB);

	[Cpp2IlInjected.Token(Token = "0x60000E5")]
	[Cpp2IlInjected.Address(Slot = "12")]
	CMCPDJMPOKN FOJJLIDIPCI(FFCGIONKJBI BMFGKMDOFCF, in IMECCMKFBII JIHCLPECHIB);

	[Cpp2IlInjected.Token(Token = "0x60000E6")]
	[Cpp2IlInjected.Address(Slot = "13")]
	CHBALODMMNE GLGIJKKAPGN(FFCGIONKJBI BMFGKMDOFCF, in IMECCMKFBII JIHCLPECHIB);

	[Cpp2IlInjected.Token(Token = "0x60000E7")]
	[Cpp2IlInjected.Address(Slot = "14")]
	KPBILAHOHAH ODODIKBAKJK(FFCGIONKJBI BMFGKMDOFCF, in IMECCMKFBII JIHCLPECHIB);

	[Cpp2IlInjected.Token(Token = "0x60000E8")]
	[Cpp2IlInjected.Address(Slot = "15")]
	FFCGIONKJBI CAKONGBGLCH(RigidbodyEx FHCKPPNILHO, IMECCMKFBII JIHCLPECHIB, MPHIHDCLPDB HKMONJIHHIH);
}
[Cpp2IlInjected.Token(Token = "0x2000016")]
public interface GIGBMEPJFND
{
	[Cpp2IlInjected.Token(Token = "0x60000E9")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void PADGBNKEIIJ(Vector3 CBEIFKNKIIE, ForceMode OEBHACLNMCB = ForceMode.Force);

	[Cpp2IlInjected.Token(Token = "0x60000EA")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void HKDCNICIFFL(Vector3 CBEIFKNKIIE, Vector3 EINGNKDKDHC, ForceMode OEBHACLNMCB);

	[Cpp2IlInjected.Token(Token = "0x60000EB")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void EPMGKEGNALO(Vector3 DEMLAEGANDJ, ForceMode OEBHACLNMCB = ForceMode.Force);

	[Cpp2IlInjected.Token(Token = "0x60000EC")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void PINFLFOIKOH(Vector3 DEMLAEGANDJ, ForceMode OEBHACLNMCB = ForceMode.Force);
}
[Cpp2IlInjected.Token(Token = "0x2000017")]
public interface JJPLOLDPKDF
{
	[Cpp2IlInjected.Token(Token = "0x1700003B")]
	bool HGEMBEONDNJ
	{
		[Cpp2IlInjected.Token(Token = "0x60000ED")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
		[Cpp2IlInjected.Token(Token = "0x60000EE")]
		[Cpp2IlInjected.Address(Slot = "1")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x60000EF")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void KDPOLAHOOPE(Rigidbody MKOMGOCHBJC);

	[Cpp2IlInjected.Token(Token = "0x60000F0")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void DIDIIBMEDJD(Rigidbody MKOMGOCHBJC);
}
[Cpp2IlInjected.Token(Token = "0x2000018")]
public interface IPLGDMEHBOJ : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x1700003C")]
	IReadOnlyList<FFCGIONKJBI> KEPEEEPLAGJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000103")]
		[Cpp2IlInjected.Address(Slot = "18")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700003D")]
	FFCGIONKJBI AMKPOIHFDKH
	{
		[Cpp2IlInjected.Token(Token = "0x6000104")]
		[Cpp2IlInjected.Address(Slot = "19")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700003E")]
	FFCGIONKJBI HDIMMFJBNPK
	{
		[Cpp2IlInjected.Token(Token = "0x6000105")]
		[Cpp2IlInjected.Address(Slot = "20")]
		get;
		[Cpp2IlInjected.Token(Token = "0x6000106")]
		[Cpp2IlInjected.Address(Slot = "21")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x1400000B")]
	event HOBHPHAMKBD IAOFFICNEFM;

	[Cpp2IlInjected.Token(Token = "0x1400000C")]
	event HOBHPHAMKBD BPJGPOJJOIC;

	[Cpp2IlInjected.Token(Token = "0x1400000D")]
	event ABBLHFOFAPM IANJCDBCFAJ;

	[Cpp2IlInjected.Token(Token = "0x1400000E")]
	event Action HGFICMNEKPD;

	[Cpp2IlInjected.Token(Token = "0x1400000F")]
	event Action AOLPOEKDAPB;

	[Cpp2IlInjected.Token(Token = "0x14000010")]
	event Action<FFCGIONKJBI> MIDFDOJCFED;

	[Cpp2IlInjected.Token(Token = "0x14000011")]
	event Action<FFCGIONKJBI> ENHLMFMKKOI;

	[Cpp2IlInjected.Token(Token = "0x14000012")]
	event Action CBAHCMEOEBH;

	[Cpp2IlInjected.Token(Token = "0x14000013")]
	event Action<FFCGIONKJBI> PNGLKBMDHIJ;

	[Cpp2IlInjected.Token(Token = "0x6000107")]
	[Cpp2IlInjected.Address(Slot = "22")]
	void OGODNIIEFFB(FFCGIONKJBI EBIGGMLCEAF, bool JAHLDBIKCJI = false);
}
[Cpp2IlInjected.Token(Token = "0x2000019")]
public interface EBAADMBJLMD
{
	[Cpp2IlInjected.Token(Token = "0x1700003F")]
	Vector3 GNKPAMJBNBD
	{
		[Cpp2IlInjected.Token(Token = "0x6000108")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000040")]
	Vector3 DECHPPBODKH
	{
		[Cpp2IlInjected.Token(Token = "0x6000109")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x600010A")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void KJONOMFBLIP(FFCGIONKJBI LFAIGCEGCPL, object HKLDIENGNNB);

	[Cpp2IlInjected.Token(Token = "0x600010B")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void GBBOCMNIAIE(object HKLDIENGNNB);
}
[Cpp2IlInjected.Token(Token = "0x200001A")]
public interface CHBALODMMNE
{
	[Cpp2IlInjected.Token(Token = "0x17000041")]
	Vector3 AAGDOJLDOMM
	{
		[Cpp2IlInjected.Token(Token = "0x600010E")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
		[Cpp2IlInjected.Token(Token = "0x600010F")]
		[Cpp2IlInjected.Address(Slot = "3")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000042")]
	Vector3 DJLPMKOMOHI
	{
		[Cpp2IlInjected.Token(Token = "0x6000110")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000043")]
	float MGOEPMCMEHB
	{
		[Cpp2IlInjected.Token(Token = "0x6000111")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000044")]
	float OEDNFOGCCII
	{
		[Cpp2IlInjected.Token(Token = "0x6000112")]
		[Cpp2IlInjected.Address(Slot = "6")]
		get;
		[Cpp2IlInjected.Token(Token = "0x6000113")]
		[Cpp2IlInjected.Address(Slot = "7")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000045")]
	Vector3 KGPDAOIKKOA
	{
		[Cpp2IlInjected.Token(Token = "0x6000114")]
		[Cpp2IlInjected.Address(Slot = "8")]
		get;
		[Cpp2IlInjected.Token(Token = "0x6000115")]
		[Cpp2IlInjected.Address(Slot = "9")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000046")]
	Quaternion GADCINNEPIK
	{
		[Cpp2IlInjected.Token(Token = "0x6000116")]
		[Cpp2IlInjected.Address(Slot = "10")]
		get;
		[Cpp2IlInjected.Token(Token = "0x6000117")]
		[Cpp2IlInjected.Address(Slot = "11")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x14000014")]
	event HOBHPHAMKBD HHGAGCIOJJG;

	[Cpp2IlInjected.Token(Token = "0x6000118")]
	[Cpp2IlInjected.Address(Slot = "12")]
	void BANKNELMPFP();

	[Cpp2IlInjected.Token(Token = "0x6000119")]
	[Cpp2IlInjected.Address(Slot = "13")]
	void CAALKOKEPPD();

	[Cpp2IlInjected.Token(Token = "0x600011A")]
	[Cpp2IlInjected.Address(Slot = "14")]
	void GAANFDFDMKC();

	[Cpp2IlInjected.Token(Token = "0x600011B")]
	[Cpp2IlInjected.Address(Slot = "15")]
	void KDPOLAHOOPE(Rigidbody MKOMGOCHBJC);

	[Cpp2IlInjected.Token(Token = "0x600011C")]
	[Cpp2IlInjected.Address(Slot = "16")]
	void DIDIIBMEDJD(Rigidbody MKOMGOCHBJC);

	[Cpp2IlInjected.Token(Token = "0x600011D")]
	[Cpp2IlInjected.Address(Slot = "17")]
	void DFDCFAGILJM();
}
[Cpp2IlInjected.Token(Token = "0x200001B")]
public interface CMCPDJMPOKN
{
	[Cpp2IlInjected.Token(Token = "0x17000047")]
	bool NBDADIFMHHK
	{
		[Cpp2IlInjected.Token(Token = "0x600011E")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000048")]
	MGONBPIMIEF AIAKBOMPCEL
	{
		[Cpp2IlInjected.Token(Token = "0x600011F")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000120")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void NOMIHBFFLNG();

	[Cpp2IlInjected.Token(Token = "0x6000121")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void FCLIOEABILH(object HKLDIENGNNB);

	[Cpp2IlInjected.Token(Token = "0x6000122")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void HFELMDDPCOH(object HKLDIENGNNB);

	[Cpp2IlInjected.Token(Token = "0x6000123")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void GJFLJCFCCKJ(FFCGIONKJBI FHCKPPNILHO);

	[Cpp2IlInjected.Token(Token = "0x6000124")]
	[Cpp2IlInjected.Address(Slot = "6")]
	void DAHMBDFDEKP(FFCGIONKJBI FHCKPPNILHO);

	[Cpp2IlInjected.Token(Token = "0x6000125")]
	[Cpp2IlInjected.Address(Slot = "7")]
	void OLOGEBHENON();
}
[Cpp2IlInjected.Token(Token = "0x200001C")]
public interface MAMDKJFPNFM
{
	[Cpp2IlInjected.Token(Token = "0x17000049")]
	bool DEHDGKEMKCA
	{
		[Cpp2IlInjected.Token(Token = "0x6000128")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700004A")]
	IEnumerable<object> JCMEBGAMNHL
	{
		[Cpp2IlInjected.Token(Token = "0x6000129")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x14000015")]
	event HOBHPHAMKBD EOJIPPCPFCI;

	[Cpp2IlInjected.Token(Token = "0x600012A")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void FKOFNEMGINM(object HKLDIENGNNB);

	[Cpp2IlInjected.Token(Token = "0x600012B")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void BEHGOGKEFEN(object HKLDIENGNNB);

	[Cpp2IlInjected.Token(Token = "0x600012C")]
	[Cpp2IlInjected.Address(Slot = "6")]
	void DLBAIGNALBD(object HKLDIENGNNB, bool BKHDMOGADPG);

	[Cpp2IlInjected.Token(Token = "0x600012D")]
	[Cpp2IlInjected.Address(Slot = "7")]
	IDisposable IFKNDGBNBEF();

	[Cpp2IlInjected.Token(Token = "0x600012E")]
	[Cpp2IlInjected.Address(Slot = "8")]
	void KDPOLAHOOPE(Rigidbody CCLEKJNADLB);

	[Cpp2IlInjected.Token(Token = "0x600012F")]
	[Cpp2IlInjected.Address(Slot = "9")]
	void DIDIIBMEDJD(Rigidbody MKOMGOCHBJC);
}
[Cpp2IlInjected.Token(Token = "0x200001D")]
public interface BHMDAAMOACJ : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x1700004B")]
	bool BKKAMGPIPMG
	{
		[Cpp2IlInjected.Token(Token = "0x6000132")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700004C")]
	bool OFHGFFKKEMJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000133")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x14000016")]
	event HOBHPHAMKBD IBIGIAONNFK;

	[Cpp2IlInjected.Token(Token = "0x6000134")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void NOMIHBFFLNG();

	[Cpp2IlInjected.Token(Token = "0x6000135")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void MELFMEBHFAF(FFCGIONKJBI LFAIGCEGCPL);

	[Cpp2IlInjected.Token(Token = "0x6000136")]
	[Cpp2IlInjected.Address(Slot = "6")]
	void BLHLKMFLDGD(FFCGIONKJBI LFAIGCEGCPL);
}
[Cpp2IlInjected.Token(Token = "0x200001E")]
public interface KPBILAHOHAH
{
	[Cpp2IlInjected.Token(Token = "0x1700004D")]
	bool IELKFNIBHFB
	{
		[Cpp2IlInjected.Token(Token = "0x6000137")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
		[Cpp2IlInjected.Token(Token = "0x6000138")]
		[Cpp2IlInjected.Address(Slot = "1")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x1700004E")]
	bool FDKFFCJABEN
	{
		[Cpp2IlInjected.Token(Token = "0x6000139")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700004F")]
	RigidbodyConstraints AKGJCKADCBH
	{
		[Cpp2IlInjected.Token(Token = "0x600013A")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
		[Cpp2IlInjected.Token(Token = "0x600013B")]
		[Cpp2IlInjected.Address(Slot = "4")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x600013C")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void KDPOLAHOOPE(Rigidbody MKOMGOCHBJC);

	[Cpp2IlInjected.Token(Token = "0x600013D")]
	[Cpp2IlInjected.Address(Slot = "6")]
	void DIDIIBMEDJD(Rigidbody MKOMGOCHBJC);
}
[Cpp2IlInjected.Token(Token = "0x200001F")]
public interface EKNFOOIEIBK
{
	[Cpp2IlInjected.Token(Token = "0x17000050")]
	float KDAOPIJAMOB
	{
		[Cpp2IlInjected.Token(Token = "0x600013E")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
		[Cpp2IlInjected.Token(Token = "0x600013F")]
		[Cpp2IlInjected.Address(Slot = "1")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000051")]
	float FEGLLEJAJOH
	{
		[Cpp2IlInjected.Token(Token = "0x6000140")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
		[Cpp2IlInjected.Token(Token = "0x6000141")]
		[Cpp2IlInjected.Address(Slot = "3")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x6000142")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void KDPOLAHOOPE(Rigidbody MKOMGOCHBJC);

	[Cpp2IlInjected.Token(Token = "0x6000143")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void DIDIIBMEDJD(Rigidbody MKOMGOCHBJC);
}
[Cpp2IlInjected.Token(Token = "0x2000020")]
public interface LKPFFAJGKDN
{
	[Cpp2IlInjected.Token(Token = "0x6000144")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void OnRootRBEXChanged(RigidbodyEx CCOHAEKNGFH);
}
[Cpp2IlInjected.Token(Token = "0x2000021")]
public interface MNHBOEHCOIK
{
	[Cpp2IlInjected.Token(Token = "0x14000017")]
	event HOBHPHAMKBD IHIJNHOELAG;

	[Cpp2IlInjected.Token(Token = "0x6000147")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void NOMIHBFFLNG();

	[Cpp2IlInjected.Token(Token = "0x6000148")]
	[Cpp2IlInjected.Address(Slot = "3")]
	bool MNIMMDJAIIP();

	[Cpp2IlInjected.Token(Token = "0x6000149")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void JPLMLMHPLJA();

	[Cpp2IlInjected.Token(Token = "0x600014A")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void ALKMJGDDHDA();

	[Cpp2IlInjected.Token(Token = "0x600014B")]
	[Cpp2IlInjected.Address(Slot = "6")]
	void HOBDPIODPAL();

	[Cpp2IlInjected.Token(Token = "0x600014C")]
	[Cpp2IlInjected.Address(Slot = "7")]
	void LEMLLHIPKGE();

	[Cpp2IlInjected.Token(Token = "0x600014D")]
	[Cpp2IlInjected.Address(Slot = "8")]
	void HKDHIFCLEOH(bool HBGILCDGAGC);
}
[Cpp2IlInjected.Token(Token = "0x2000022")]
public interface OOPDNBAAJIE
{
	[Cpp2IlInjected.Token(Token = "0x17000052")]
	Rigidbody BKIDAKAFFMP
	{
		[Cpp2IlInjected.Token(Token = "0x600014E")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x600014F")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void NOMIHBFFLNG();

	[Cpp2IlInjected.Token(Token = "0x6000150")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void HCDCAKONHKH(object HKLDIENGNNB);

	[Cpp2IlInjected.Token(Token = "0x6000151")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void ANODKIPNKGG(object HKLDIENGNNB);

	[Cpp2IlInjected.Token(Token = "0x6000152")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void CHKIFMMFIIK();

	[Cpp2IlInjected.Token(Token = "0x6000153")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void JEGLELMGMOF();

	[Cpp2IlInjected.Token(Token = "0x6000154")]
	[Cpp2IlInjected.Address(Slot = "6")]
	void NFMKBGIADML();

	[Cpp2IlInjected.Token(Token = "0x6000155")]
	[Cpp2IlInjected.Address(Slot = "7")]
	void DHPOOPPINJB();
}
[Cpp2IlInjected.Token(Token = "0x2000023")]
public interface GLBLEGFKOKL : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x17000053")]
	IIENCNCJIKK OEBLLEKPOOI
	{
		[Cpp2IlInjected.Token(Token = "0x6000156")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
		[Cpp2IlInjected.Token(Token = "0x6000157")]
		[Cpp2IlInjected.Address(Slot = "1")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000054")]
	JGKAIJBBCDC KPBINMPEPCH
	{
		[Cpp2IlInjected.Token(Token = "0x6000158")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
		[Cpp2IlInjected.Token(Token = "0x6000159")]
		[Cpp2IlInjected.Address(Slot = "3")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000055")]
	Vector3 OMPLHOFEJAN
	{
		[Cpp2IlInjected.Token(Token = "0x600015A")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
		[Cpp2IlInjected.Token(Token = "0x600015B")]
		[Cpp2IlInjected.Address(Slot = "5")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000056")]
	Vector3 BOJDMEIPMAO
	{
		[Cpp2IlInjected.Token(Token = "0x600015C")]
		[Cpp2IlInjected.Address(Slot = "6")]
		get;
		[Cpp2IlInjected.Token(Token = "0x600015D")]
		[Cpp2IlInjected.Address(Slot = "7")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000057")]
	Vector3 IPICDHHHJOG
	{
		[Cpp2IlInjected.Token(Token = "0x600015E")]
		[Cpp2IlInjected.Address(Slot = "8")]
		get;
		[Cpp2IlInjected.Token(Token = "0x600015F")]
		[Cpp2IlInjected.Address(Slot = "9")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000058")]
	Vector3 DALJIIPOFIE
	{
		[Cpp2IlInjected.Token(Token = "0x6000160")]
		[Cpp2IlInjected.Address(Slot = "10")]
		get;
		[Cpp2IlInjected.Token(Token = "0x6000161")]
		[Cpp2IlInjected.Address(Slot = "11")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000059")]
	float KJKDBCBOHIJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000162")]
		[Cpp2IlInjected.Address(Slot = "12")]
		get;
		[Cpp2IlInjected.Token(Token = "0x6000163")]
		[Cpp2IlInjected.Address(Slot = "13")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x1700005A")]
	bool NKPLDABKJCL
	{
		[Cpp2IlInjected.Token(Token = "0x6000164")]
		[Cpp2IlInjected.Address(Slot = "14")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000165")]
	[Cpp2IlInjected.Address(Slot = "15")]
	void NOMIHBFFLNG();

	[Cpp2IlInjected.Token(Token = "0x6000166")]
	[Cpp2IlInjected.Address(Slot = "16")]
	void OGEMIEDCOED(object HKLDIENGNNB);

	[Cpp2IlInjected.Token(Token = "0x6000167")]
	[Cpp2IlInjected.Address(Slot = "17")]
	void NCIJALPIGCE(MCMFGEDCCGC LMLMHHPMBJO, Vector3 OFLGCJLDNJJ, float IPAPNFBMGEF = float.PositiveInfinity);

	[Cpp2IlInjected.Token(Token = "0x6000168")]
	[Cpp2IlInjected.Address(Slot = "18")]
	void CBHLOBJDACM(CKAOOODELAE IKFPEHIFEPN, Vector3 NMBFBKMEJKN, float FEHHFHACKBK, float IOFMPFNPHNC = 8f, float JKLGNKAKKLG = 1f);

	[Cpp2IlInjected.Token(Token = "0x6000169")]
	[Cpp2IlInjected.Address(Slot = "19")]
	void FDJHKHJGOHO(MCMFGEDCCGC LMLMHHPMBJO, Vector3 JGCPJBFFFAC, float NMBEKOOKPJA = 7f, float MFBAPHBIEKM = 1f);

	[Cpp2IlInjected.Token(Token = "0x600016A")]
	[Cpp2IlInjected.Address(Slot = "20")]
	void NFCJHIFEHGE();

	[Cpp2IlInjected.Token(Token = "0x600016B")]
	[Cpp2IlInjected.Address(Slot = "21")]
	void NLLIBPNNBGH();

	[Cpp2IlInjected.Token(Token = "0x600016C")]
	[Cpp2IlInjected.Address(Slot = "22")]
	void LADPNNADDEK();

	[Cpp2IlInjected.Token(Token = "0x600016D")]
	[Cpp2IlInjected.Address(Slot = "23")]
	void BCKDLBEFMPH();

	[Cpp2IlInjected.Token(Token = "0x600016E")]
	[Cpp2IlInjected.Address(Slot = "24")]
	void KDPOLAHOOPE(Rigidbody MKOMGOCHBJC);

	[Cpp2IlInjected.Token(Token = "0x600016F")]
	[Cpp2IlInjected.Address(Slot = "25")]
	Vector3 PIFNCDNOKAD(Vector3 HOLPFINNOLF);

	[Cpp2IlInjected.Token(Token = "0x6000170")]
	[Cpp2IlInjected.Address(Slot = "26")]
	Vector3 AJLBGCPJCKN(Vector3 CPHPLAEKCBK);

	[Cpp2IlInjected.Token(Token = "0x6000171")]
	[Cpp2IlInjected.Address(Slot = "27")]
	void LPJEFBBEPMD(object HKLDIENGNNB);

	[Cpp2IlInjected.Token(Token = "0x6000172")]
	[Cpp2IlInjected.Address(Slot = "28")]
	void DNAJDFGLENG(Vector3 OANHHGBFKAN);

	[Cpp2IlInjected.Token(Token = "0x6000173")]
	[Cpp2IlInjected.Address(Slot = "29")]
	void EBKBGNAGIOD(Vector3 LOGKBIHCFJD, Vector3 OGPMEJLJLFA);

	[Cpp2IlInjected.Token(Token = "0x6000174")]
	[Cpp2IlInjected.Address(Slot = "30")]
	void KPJAOLBLIEI(Vector3 PFDFFPLAJJP, Vector3 HGIFCPKBAGG);

	[Cpp2IlInjected.Token(Token = "0x6000175")]
	[Cpp2IlInjected.Address(Slot = "31")]
	Vector3 PIFFFCJGHPG(Vector3 OLLLCEPAFHE);

	[Cpp2IlInjected.Token(Token = "0x6000176")]
	[Cpp2IlInjected.Address(Slot = "32")]
	Vector3 LKOKGKNLODE(Vector3 JMLACAFKJOF);
}
[Cpp2IlInjected.Token(Token = "0x2000024")]
[LOICNDEPMOJ(HIFIKBEHMNK.Application)]
public interface ILPLCBJNHLG
{
	[Cpp2IlInjected.Token(Token = "0x1700005B")]
	bool KEDNBFMFDIB
	{
		[Cpp2IlInjected.Token(Token = "0x6000177")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000178")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void CJLBEJJPLHJ(string OOMNIJBIFDC);

	[Cpp2IlInjected.Token(Token = "0x6000179")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void CCBKFKILGIF(RigidbodyEx FHCKPPNILHO, Action PBOHOIMMGFG);

	[Cpp2IlInjected.Token(Token = "0x600017A")]
	[Cpp2IlInjected.Address(Slot = "3")]
	IPLAPPDCGPJ AIPGIJNOLBD(int GIHMJHPHLNL);

	[Cpp2IlInjected.Token(Token = "0x600017B")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void FKCBIGGCCPD(Vector3 NOJGOAEBGFN, float DONJHLJNIDL, Color GCBELIJEOPF);
}
[Cpp2IlInjected.Token(Token = "0x2000025")]
[LOICNDEPMOJ(HIFIKBEHMNK.Application)]
public interface MPHIHDCLPDB
{
	[Cpp2IlInjected.Token(Token = "0x1700005C")]
	ILPLCBJNHLG KEPKLMOMNIE
	{
		[Cpp2IlInjected.Token(Token = "0x600017C")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700005D")]
	LGNFMEIAMDG AAIBAGIBCOG
	{
		[Cpp2IlInjected.Token(Token = "0x600017D")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700005E")]
	bool JIIADOBNPCP
	{
		[Cpp2IlInjected.Token(Token = "0x600017E")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x600017F")]
	[Cpp2IlInjected.Address(Slot = "3")]
	NIALADIPDNC DJNCPPLECDP(RigidbodyEx FHCKPPNILHO);

	[Cpp2IlInjected.Token(Token = "0x6000180")]
	[Cpp2IlInjected.Address(Slot = "4")]
	FFCGIONKJBI CAKONGBGLCH(RigidbodyEx FHCKPPNILHO, IMECCMKFBII JIHCLPECHIB);

	[Cpp2IlInjected.Token(Token = "0x6000181")]
	[Cpp2IlInjected.Address(Slot = "5")]
	internal RigidbodyEx DPKDIGCGLHK(GameObject POFNLMLLLOA, [Optional] IMECCMKFBII JIHCLPECHIB);
}
[Cpp2IlInjected.Token(Token = "0x2000026")]
public interface JGKAIJBBCDC
{
	[Cpp2IlInjected.Token(Token = "0x6000182")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void POPNLNKGNFK(Vector3 FHCLDLDBGMF);

	[Cpp2IlInjected.Token(Token = "0x6000183")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void DEJPPLEHGBP(Vector3 HOLPFINNOLF);

	[Cpp2IlInjected.Token(Token = "0x6000184")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void NMBNJPACBCA(Vector3 FHCLDLDBGMF);

	[Cpp2IlInjected.Token(Token = "0x6000185")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void NNEBCFJGPML(Vector3 HOLPFINNOLF);
}
[Cpp2IlInjected.Token(Token = "0x2000027")]
public interface IIENCNCJIKK : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x6000186")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Vector3 NMMDPBJGGGJ();

	[Cpp2IlInjected.Token(Token = "0x6000187")]
	[Cpp2IlInjected.Address(Slot = "1")]
	Vector3 CHBOIJCOGNN();
}
[Cpp2IlInjected.Token(Token = "0x2000028")]
public interface FFCGIONKJBI : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x1700005F")]
	Rigidbody BKIDAKAFFMP
	{
		[Cpp2IlInjected.Token(Token = "0x6000188")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000060")]
	RigidbodyEx MDFBJOGOGGI
	{
		[Cpp2IlInjected.Token(Token = "0x6000189")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000061")]
	GameObject LPLGJEFNKNH
	{
		[Cpp2IlInjected.Token(Token = "0x600018A")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000062")]
	Transform DACDPJCIAKE
	{
		[Cpp2IlInjected.Token(Token = "0x600018B")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000063")]
	IEnumerable<object> CMDPIDMOANK
	{
		[Cpp2IlInjected.Token(Token = "0x600018C")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000064")]
	FFCGIONKJBI HDIMMFJBNPK
	{
		[Cpp2IlInjected.Token(Token = "0x600018D")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
		[Cpp2IlInjected.Token(Token = "0x600018E")]
		[Cpp2IlInjected.Address(Slot = "6")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000065")]
	IReadOnlyList<FFCGIONKJBI> KEPEEEPLAGJ
	{
		[Cpp2IlInjected.Token(Token = "0x600018F")]
		[Cpp2IlInjected.Address(Slot = "7")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000066")]
	FFCGIONKJBI AMKPOIHFDKH
	{
		[Cpp2IlInjected.Token(Token = "0x6000190")]
		[Cpp2IlInjected.Address(Slot = "8")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000067")]
	bool CAIEJEMCAII
	{
		[Cpp2IlInjected.Token(Token = "0x6000191")]
		[Cpp2IlInjected.Address(Slot = "9")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000068")]
	bool BKKAMGPIPMG
	{
		[Cpp2IlInjected.Token(Token = "0x6000192")]
		[Cpp2IlInjected.Address(Slot = "10")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000069")]
	bool OFHGFFKKEMJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000193")]
		[Cpp2IlInjected.Address(Slot = "11")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700006A")]
	IIENCNCJIKK OEBLLEKPOOI
	{
		[Cpp2IlInjected.Token(Token = "0x6000194")]
		[Cpp2IlInjected.Address(Slot = "12")]
		get;
		[Cpp2IlInjected.Token(Token = "0x6000195")]
		[Cpp2IlInjected.Address(Slot = "13")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x1700006B")]
	JGKAIJBBCDC KPBINMPEPCH
	{
		[Cpp2IlInjected.Token(Token = "0x6000196")]
		[Cpp2IlInjected.Address(Slot = "14")]
		get;
		[Cpp2IlInjected.Token(Token = "0x6000197")]
		[Cpp2IlInjected.Address(Slot = "15")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x1700006C")]
	float KJKDBCBOHIJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000198")]
		[Cpp2IlInjected.Address(Slot = "16")]
		get;
		[Cpp2IlInjected.Token(Token = "0x6000199")]
		[Cpp2IlInjected.Address(Slot = "17")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x1700006D")]
	Vector3 BOJDMEIPMAO
	{
		[Cpp2IlInjected.Token(Token = "0x600019A")]
		[Cpp2IlInjected.Address(Slot = "18")]
		get;
		[Cpp2IlInjected.Token(Token = "0x600019B")]
		[Cpp2IlInjected.Address(Slot = "19")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x1700006E")]
	Vector3 DALJIIPOFIE
	{
		[Cpp2IlInjected.Token(Token = "0x600019C")]
		[Cpp2IlInjected.Address(Slot = "20")]
		get;
		[Cpp2IlInjected.Token(Token = "0x600019D")]
		[Cpp2IlInjected.Address(Slot = "21")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x1700006F")]
	Vector3 OMPLHOFEJAN
	{
		[Cpp2IlInjected.Token(Token = "0x600019E")]
		[Cpp2IlInjected.Address(Slot = "22")]
		get;
		[Cpp2IlInjected.Token(Token = "0x600019F")]
		[Cpp2IlInjected.Address(Slot = "23")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000070")]
	Vector3 IPICDHHHJOG
	{
		[Cpp2IlInjected.Token(Token = "0x60001A0")]
		[Cpp2IlInjected.Address(Slot = "24")]
		get;
		[Cpp2IlInjected.Token(Token = "0x60001A1")]
		[Cpp2IlInjected.Address(Slot = "25")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000071")]
	bool KENDHOCAHBA
	{
		[Cpp2IlInjected.Token(Token = "0x60001A2")]
		[Cpp2IlInjected.Address(Slot = "26")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000072")]
	bool EHJFPLNBAAH
	{
		[Cpp2IlInjected.Token(Token = "0x60001A3")]
		[Cpp2IlInjected.Address(Slot = "27")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000073")]
	bool PLHBBEKOBGN
	{
		[Cpp2IlInjected.Token(Token = "0x60001A4")]
		[Cpp2IlInjected.Address(Slot = "28")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000074")]
	bool NKPLDABKJCL
	{
		[Cpp2IlInjected.Token(Token = "0x60001A5")]
		[Cpp2IlInjected.Address(Slot = "29")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000075")]
	Vector3 GNKPAMJBNBD
	{
		[Cpp2IlInjected.Token(Token = "0x60001A6")]
		[Cpp2IlInjected.Address(Slot = "30")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000076")]
	Vector3 DECHPPBODKH
	{
		[Cpp2IlInjected.Token(Token = "0x60001A7")]
		[Cpp2IlInjected.Address(Slot = "31")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000077")]
	Vector3 AAGDOJLDOMM
	{
		[Cpp2IlInjected.Token(Token = "0x60001A8")]
		[Cpp2IlInjected.Address(Slot = "32")]
		get;
		[Cpp2IlInjected.Token(Token = "0x60001A9")]
		[Cpp2IlInjected.Address(Slot = "33")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000078")]
	Vector3 DJLPMKOMOHI
	{
		[Cpp2IlInjected.Token(Token = "0x60001AA")]
		[Cpp2IlInjected.Address(Slot = "34")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000079")]
	float MGOEPMCMEHB
	{
		[Cpp2IlInjected.Token(Token = "0x60001AB")]
		[Cpp2IlInjected.Address(Slot = "35")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700007A")]
	float OEDNFOGCCII
	{
		[Cpp2IlInjected.Token(Token = "0x60001AC")]
		[Cpp2IlInjected.Address(Slot = "36")]
		get;
		[Cpp2IlInjected.Token(Token = "0x60001AD")]
		[Cpp2IlInjected.Address(Slot = "37")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x1700007B")]
	Vector3 KGPDAOIKKOA
	{
		[Cpp2IlInjected.Token(Token = "0x60001AE")]
		[Cpp2IlInjected.Address(Slot = "38")]
		get;
		[Cpp2IlInjected.Token(Token = "0x60001AF")]
		[Cpp2IlInjected.Address(Slot = "39")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x1700007C")]
	Quaternion GADCINNEPIK
	{
		[Cpp2IlInjected.Token(Token = "0x60001B0")]
		[Cpp2IlInjected.Address(Slot = "40")]
		get;
		[Cpp2IlInjected.Token(Token = "0x60001B1")]
		[Cpp2IlInjected.Address(Slot = "41")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x1700007D")]
	float KDAOPIJAMOB
	{
		[Cpp2IlInjected.Token(Token = "0x60001B2")]
		[Cpp2IlInjected.Address(Slot = "42")]
		get;
		[Cpp2IlInjected.Token(Token = "0x60001B3")]
		[Cpp2IlInjected.Address(Slot = "43")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x1700007E")]
	float FEGLLEJAJOH
	{
		[Cpp2IlInjected.Token(Token = "0x60001B4")]
		[Cpp2IlInjected.Address(Slot = "44")]
		get;
		[Cpp2IlInjected.Token(Token = "0x60001B5")]
		[Cpp2IlInjected.Address(Slot = "45")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x1700007F")]
	bool HGEMBEONDNJ
	{
		[Cpp2IlInjected.Token(Token = "0x60001B6")]
		[Cpp2IlInjected.Address(Slot = "46")]
		get;
		[Cpp2IlInjected.Token(Token = "0x60001B7")]
		[Cpp2IlInjected.Address(Slot = "47")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000080")]
	CKHEJONCKGK GGJLBGDDKGJ
	{
		[Cpp2IlInjected.Token(Token = "0x60001B8")]
		[Cpp2IlInjected.Address(Slot = "48")]
		get;
		[Cpp2IlInjected.Token(Token = "0x60001B9")]
		[Cpp2IlInjected.Address(Slot = "49")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000081")]
	bool DEHDGKEMKCA
	{
		[Cpp2IlInjected.Token(Token = "0x60001BA")]
		[Cpp2IlInjected.Address(Slot = "50")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000082")]
	Transform DPCGIDOBNGL
	{
		[Cpp2IlInjected.Token(Token = "0x60001BB")]
		[Cpp2IlInjected.Address(Slot = "51")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000083")]
	Transform EAILDMMFMIE
	{
		[Cpp2IlInjected.Token(Token = "0x60001BC")]
		[Cpp2IlInjected.Address(Slot = "52")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000084")]
	Vector3 HAPPDNNLGPN
	{
		[Cpp2IlInjected.Token(Token = "0x60001BD")]
		[Cpp2IlInjected.Address(Slot = "53")]
		get;
		[Cpp2IlInjected.Token(Token = "0x60001BE")]
		[Cpp2IlInjected.Address(Slot = "54")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000085")]
	float MAFJLHAELCE
	{
		[Cpp2IlInjected.Token(Token = "0x60001BF")]
		[Cpp2IlInjected.Address(Slot = "55")]
		get;
		[Cpp2IlInjected.Token(Token = "0x60001C0")]
		[Cpp2IlInjected.Address(Slot = "56")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000086")]
	float EEAGMHLGCPI
	{
		[Cpp2IlInjected.Token(Token = "0x60001C1")]
		[Cpp2IlInjected.Address(Slot = "57")]
		get;
		[Cpp2IlInjected.Token(Token = "0x60001C2")]
		[Cpp2IlInjected.Address(Slot = "58")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000087")]
	Quaternion BDIPPGABHED
	{
		[Cpp2IlInjected.Token(Token = "0x60001C3")]
		[Cpp2IlInjected.Address(Slot = "59")]
		get;
		[Cpp2IlInjected.Token(Token = "0x60001C4")]
		[Cpp2IlInjected.Address(Slot = "60")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000088")]
	Vector3 MLJGHHMBALO
	{
		[Cpp2IlInjected.Token(Token = "0x60001C5")]
		[Cpp2IlInjected.Address(Slot = "61")]
		get;
		[Cpp2IlInjected.Token(Token = "0x60001C6")]
		[Cpp2IlInjected.Address(Slot = "62")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000089")]
	Quaternion ADAPJGEEEOL
	{
		[Cpp2IlInjected.Token(Token = "0x60001C7")]
		[Cpp2IlInjected.Address(Slot = "63")]
		get;
		[Cpp2IlInjected.Token(Token = "0x60001C8")]
		[Cpp2IlInjected.Address(Slot = "64")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x1700008A")]
	RigidbodyConstraints AKGJCKADCBH
	{
		[Cpp2IlInjected.Token(Token = "0x60001C9")]
		[Cpp2IlInjected.Address(Slot = "65")]
		get;
		[Cpp2IlInjected.Token(Token = "0x60001CA")]
		[Cpp2IlInjected.Address(Slot = "66")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x1700008B")]
	bool IELKFNIBHFB
	{
		[Cpp2IlInjected.Token(Token = "0x60001CB")]
		[Cpp2IlInjected.Address(Slot = "67")]
		get;
		[Cpp2IlInjected.Token(Token = "0x60001CC")]
		[Cpp2IlInjected.Address(Slot = "68")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x1700008C")]
	CollisionDetectionMode GDCFMCCNNGL
	{
		[Cpp2IlInjected.Token(Token = "0x60001CD")]
		[Cpp2IlInjected.Address(Slot = "69")]
		get;
		[Cpp2IlInjected.Token(Token = "0x60001CE")]
		[Cpp2IlInjected.Address(Slot = "70")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x1700008D")]
	bool CEDDMPPAJDO
	{
		[Cpp2IlInjected.Token(Token = "0x60001CF")]
		[Cpp2IlInjected.Address(Slot = "71")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x14000018")]
	event HOBHPHAMKBD IAOFFICNEFM;

	[Cpp2IlInjected.Token(Token = "0x14000019")]
	event HOBHPHAMKBD BPJGPOJJOIC;

	[Cpp2IlInjected.Token(Token = "0x1400001A")]
	event ABBLHFOFAPM IANJCDBCFAJ;

	[Cpp2IlInjected.Token(Token = "0x1400001B")]
	event HOBHPHAMKBD IBIGIAONNFK;

	[Cpp2IlInjected.Token(Token = "0x1400001C")]
	event HOBHPHAMKBD MPMMHJCOBJO;

	[Cpp2IlInjected.Token(Token = "0x1400001D")]
	event HOBHPHAMKBD IHIJNHOELAG;

	[Cpp2IlInjected.Token(Token = "0x1400001E")]
	event Action<CEAPFNKIAFO, CEAPFNKIAFO> GAJNIIPFKOP;

	[Cpp2IlInjected.Token(Token = "0x1400001F")]
	event HOBHPHAMKBD PJPDOAADALA;

	[Cpp2IlInjected.Token(Token = "0x14000020")]
	event HOBHPHAMKBD JDPDGOHICPK;

	[Cpp2IlInjected.Token(Token = "0x60001D0")]
	[Cpp2IlInjected.Address(Slot = "72")]
	void NOMIHBFFLNG();

	[Cpp2IlInjected.Token(Token = "0x60001D1")]
	[Cpp2IlInjected.Address(Slot = "73")]
	void EFPEPNDIDBP();

	[Cpp2IlInjected.Token(Token = "0x60001D2")]
	[Cpp2IlInjected.Address(Slot = "74")]
	void AHFFBOOJKLD();

	[Cpp2IlInjected.Token(Token = "0x60001D3")]
	[Cpp2IlInjected.Address(Slot = "75")]
	void ALKMJGDDHDA();

	[Cpp2IlInjected.Token(Token = "0x60001D4")]
	[Cpp2IlInjected.Address(Slot = "76")]
	void MKJLJFAPFNF();

	[Cpp2IlInjected.Token(Token = "0x60001DB")]
	[Cpp2IlInjected.Address(Slot = "83")]
	void OGODNIIEFFB(FFCGIONKJBI MAKFNMHIJIF, bool JAHLDBIKCJI = false);

	[Cpp2IlInjected.Token(Token = "0x60001DE")]
	[Cpp2IlInjected.Address(Slot = "86")]
	void DPOKFGFKBCC(object HKLDIENGNNB);

	[Cpp2IlInjected.Token(Token = "0x60001DF")]
	[Cpp2IlInjected.Address(Slot = "87")]
	void EEPLGJOEHDM(object HKLDIENGNNB);

	[Cpp2IlInjected.Token(Token = "0x60001E0")]
	[Cpp2IlInjected.Address(Slot = "88")]
	Vector3 LKOKGKNLODE(Vector3 JMLACAFKJOF);

	[Cpp2IlInjected.Token(Token = "0x60001E1")]
	[Cpp2IlInjected.Address(Slot = "89")]
	Vector3 PIFFFCJGHPG(Vector3 OLLLCEPAFHE);

	[Cpp2IlInjected.Token(Token = "0x60001E2")]
	[Cpp2IlInjected.Address(Slot = "90")]
	void BCKDLBEFMPH();

	[Cpp2IlInjected.Token(Token = "0x60001E3")]
	[Cpp2IlInjected.Address(Slot = "91")]
	void NLLIBPNNBGH();

	[Cpp2IlInjected.Token(Token = "0x60001E4")]
	[Cpp2IlInjected.Address(Slot = "92")]
	void NFCJHIFEHGE();

	[Cpp2IlInjected.Token(Token = "0x60001E5")]
	[Cpp2IlInjected.Address(Slot = "93")]
	void KPJAOLBLIEI(Vector3 PFDFFPLAJJP, Vector3 HGIFCPKBAGG);

	[Cpp2IlInjected.Token(Token = "0x60001E6")]
	[Cpp2IlInjected.Address(Slot = "94")]
	void EBKBGNAGIOD(Vector3 LOGKBIHCFJD, Vector3 OGPMEJLJLFA);

	[Cpp2IlInjected.Token(Token = "0x60001E7")]
	[Cpp2IlInjected.Address(Slot = "95")]
	void DNAJDFGLENG(Vector3 OANHHGBFKAN);

	[Cpp2IlInjected.Token(Token = "0x60001E8")]
	[Cpp2IlInjected.Address(Slot = "96")]
	void CBHLOBJDACM(CKAOOODELAE IKFPEHIFEPN, Vector3 NMBFBKMEJKN, float FEHHFHACKBK, float IOFMPFNPHNC = 8f, float JKLGNKAKKLG = 1f);

	[Cpp2IlInjected.Token(Token = "0x60001E9")]
	[Cpp2IlInjected.Address(Slot = "97")]
	void NCIJALPIGCE(MCMFGEDCCGC LMLMHHPMBJO, Vector3 OFLGCJLDNJJ, float IPAPNFBMGEF = float.PositiveInfinity);

	[Cpp2IlInjected.Token(Token = "0x60001EA")]
	[Cpp2IlInjected.Address(Slot = "98")]
	void FDJHKHJGOHO(MCMFGEDCCGC LMLMHHPMBJO, Vector3 JGCPJBFFFAC, float NMBEKOOKPJA = 7f, float MFBAPHBIEKM = 1f);

	[Cpp2IlInjected.Token(Token = "0x60001EB")]
	[Cpp2IlInjected.Address(Slot = "99")]
	Vector3 AJLBGCPJCKN(Vector3 MAKFNMHIJIF);

	[Cpp2IlInjected.Token(Token = "0x60001EC")]
	[Cpp2IlInjected.Address(Slot = "100")]
	Vector3 PIFNCDNOKAD(Vector3 MAKFNMHIJIF);

	[Cpp2IlInjected.Token(Token = "0x60001ED")]
	[Cpp2IlInjected.Address(Slot = "101")]
	void LADPNNADDEK();

	[Cpp2IlInjected.Token(Token = "0x60001EE")]
	[Cpp2IlInjected.Address(Slot = "102")]
	void LJGPKEPDMFN(FFCGIONKJBI HJFPEPOCKIC, object HKLDIENGNNB);

	[Cpp2IlInjected.Token(Token = "0x60001EF")]
	[Cpp2IlInjected.Address(Slot = "103")]
	void GBMKLKMCAMC(object HKLDIENGNNB);

	[Cpp2IlInjected.Token(Token = "0x60001F2")]
	[Cpp2IlInjected.Address(Slot = "106")]
	void CAALKOKEPPD();

	[Cpp2IlInjected.Token(Token = "0x60001F3")]
	[Cpp2IlInjected.Address(Slot = "107")]
	void BANKNELMPFP();

	[Cpp2IlInjected.Token(Token = "0x60001F4")]
	[Cpp2IlInjected.Address(Slot = "108")]
	void GAANFDFDMKC();

	[Cpp2IlInjected.Token(Token = "0x60001F7")]
	[Cpp2IlInjected.Address(Slot = "111")]
	bool MNIMMDJAIIP();

	[Cpp2IlInjected.Token(Token = "0x60001F8")]
	[Cpp2IlInjected.Address(Slot = "112")]
	void LEMLLHIPKGE();

	[Cpp2IlInjected.Token(Token = "0x60001FD")]
	[Cpp2IlInjected.Address(Slot = "117")]
	IDisposable IFKNDGBNBEF();

	[Cpp2IlInjected.Token(Token = "0x60001FE")]
	[Cpp2IlInjected.Address(Slot = "118")]
	void FKOFNEMGINM(object HKLDIENGNNB);

	[Cpp2IlInjected.Token(Token = "0x60001FF")]
	[Cpp2IlInjected.Address(Slot = "119")]
	void BEHGOGKEFEN(object HKLDIENGNNB);

	[Cpp2IlInjected.Token(Token = "0x6000200")]
	[Cpp2IlInjected.Address(Slot = "120")]
	void DLBAIGNALBD(object HKLDIENGNNB, bool BKHDMOGADPG);

	[Cpp2IlInjected.Token(Token = "0x6000203")]
	[Cpp2IlInjected.Address(Slot = "123")]
	void JEBPKKGFEDL(Vector3 AFHANPMAJON, Quaternion MGLHGJDPDPO);

	[Cpp2IlInjected.Token(Token = "0x6000204")]
	[Cpp2IlInjected.Address(Slot = "124")]
	void CIOEFCEIHBP(Vector3 JGOFLNCMNEF, Quaternion HHGDJGKIPDH);

	[Cpp2IlInjected.Token(Token = "0x6000205")]
	[Cpp2IlInjected.Address(Slot = "125")]
	bool OJPJAEOKAPC(float CJJGIOGGJMO);

	[Cpp2IlInjected.Token(Token = "0x6000206")]
	[Cpp2IlInjected.Address(Slot = "126")]
	void FLGEALADFAB(object HKLDIENGNNB);

	[Cpp2IlInjected.Token(Token = "0x6000207")]
	[Cpp2IlInjected.Address(Slot = "127")]
	void GOLJJNAJJDK(object HKLDIENGNNB);

	[Cpp2IlInjected.Token(Token = "0x6000208")]
	[Cpp2IlInjected.Address(Slot = "128")]
	void HCDCAKONHKH(object HKLDIENGNNB);

	[Cpp2IlInjected.Token(Token = "0x6000209")]
	[Cpp2IlInjected.Address(Slot = "129")]
	void ANODKIPNKGG(object HKLDIENGNNB);

	[Cpp2IlInjected.Token(Token = "0x600020A")]
	[Cpp2IlInjected.Address(Slot = "130")]
	void PADGBNKEIIJ(Vector3 CBEIFKNKIIE, ForceMode OEBHACLNMCB = ForceMode.Force);

	[Cpp2IlInjected.Token(Token = "0x600020B")]
	[Cpp2IlInjected.Address(Slot = "131")]
	void HKDCNICIFFL(Vector3 CBEIFKNKIIE, Vector3 EINGNKDKDHC, ForceMode OEBHACLNMCB);

	[Cpp2IlInjected.Token(Token = "0x600020C")]
	[Cpp2IlInjected.Address(Slot = "132")]
	void EPMGKEGNALO(Vector3 DEMLAEGANDJ, ForceMode OEBHACLNMCB = ForceMode.Force);

	[Cpp2IlInjected.Token(Token = "0x600020D")]
	[Cpp2IlInjected.Address(Slot = "133")]
	void PINFLFOIKOH(Vector3 DEMLAEGANDJ, ForceMode OEBHACLNMCB = ForceMode.Force);

	[Cpp2IlInjected.Token(Token = "0x600020E")]
	[Cpp2IlInjected.Address(Slot = "134")]
	bool COKAFBGHKMH(Vector3 FOGEFLLJLFJ, out RaycastHit LOOJGACDMOC, float IDHCBHDHMCK);

	[Cpp2IlInjected.Token(Token = "0x600020F")]
	[Cpp2IlInjected.Address(Slot = "135")]
	void DFDCFAGILJM();

	[Cpp2IlInjected.Token(Token = "0x6000210")]
	[Cpp2IlInjected.Address(Slot = "136")]
	new string ToString();
}
[Cpp2IlInjected.Token(Token = "0x2000029")]
public class NMHAAMBBHKD : FFCGIONKJBI, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000030")]
	internal readonly MPHIHDCLPDB HKMONJIHHIH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000031")]
	internal IPLGDMEHBOJ BFIDBOCPJCM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000032")]
	internal CMCPDJMPOKN EHLLJKCJBHB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000033")]
	internal BHMDAAMOACJ BKOGMAMFIBB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000034")]
	internal GLBLEGFKOKL CPHPLAEKCBK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000035")]
	internal EBAADMBJLMD JIJLJHEKPHI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000036")]
	internal CHBALODMMNE CACPCHFGFFN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000037")]
	internal EKNFOOIEIBK FNPJMOMIBHM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000038")]
	internal JJPLOLDPKDF NEAKFKKCBNC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x4000039")]
	internal MNHBOEHCOIK AEOFJAOMIBF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x400003A")]
	internal CGKAANMHLMI OPJHBKHDEMF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x400003B")]
	internal MAMDKJFPNFM PNJNFBIBPGG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x400003C")]
	internal GIGBMEPJFND CBEIFKNKIIE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
	[Cpp2IlInjected.Token(Token = "0x400003D")]
	internal KPBILAHOHAH EELFOMBMENA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x400003E")]
	internal OOPDNBAAJIE MKOMGOCHBJC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
	[Cpp2IlInjected.Token(Token = "0x400003F")]
	internal MFNEPAJBKBE OFBKFFJLDKE;

	[Cpp2IlInjected.Token(Token = "0x1700008E")]
	public RigidbodyEx MDFBJOGOGGI
	{
		[Cpp2IlInjected.Token(Token = "0x6000211")]
		[Cpp2IlInjected.Address(RVA = "0x822190", Offset = "0x820790", VA = "0x180822190", Slot = "5")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000212")]
		[Cpp2IlInjected.Address(RVA = "0x8FD980", Offset = "0x8FBF80", VA = "0x1808FD980")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700008F")]
	public GameObject LPLGJEFNKNH
	{
		[Cpp2IlInjected.Token(Token = "0x6000213")]
		[Cpp2IlInjected.Address(RVA = "0x744A80", Offset = "0x743080", VA = "0x180744A80", Slot = "6")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000214")]
		[Cpp2IlInjected.Address(RVA = "0x744B40", Offset = "0x743140", VA = "0x180744B40")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000090")]
	public Transform DACDPJCIAKE
	{
		[Cpp2IlInjected.Token(Token = "0x6000215")]
		[Cpp2IlInjected.Address(RVA = "0x54586E0", Offset = "0x5456CE0", VA = "0x1854586E0", Slot = "7")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000091")]
	public IEnumerable<object> CMDPIDMOANK
	{
		[Cpp2IlInjected.Token(Token = "0x6000216")]
		[Cpp2IlInjected.Address(RVA = "0x5458690", Offset = "0x5456C90", VA = "0x185458690", Slot = "8")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000092")]
	public Rigidbody BKIDAKAFFMP
	{
		[Cpp2IlInjected.Token(Token = "0x6000217")]
		[Cpp2IlInjected.Address(RVA = "0x54543D0", Offset = "0x54529D0", VA = "0x1854543D0", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000093")]
	public FFCGIONKJBI HDIMMFJBNPK
	{
		[Cpp2IlInjected.Token(Token = "0x6000225")]
		[Cpp2IlInjected.Address(RVA = "0x5454D20", Offset = "0x5453320", VA = "0x185454D20", Slot = "9")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000226")]
		[Cpp2IlInjected.Address(RVA = "0x5458450", Offset = "0x5456A50", VA = "0x185458450", Slot = "10")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000094")]
	public IReadOnlyList<FFCGIONKJBI> KEPEEEPLAGJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000227")]
		[Cpp2IlInjected.Address(RVA = "0x54549D0", Offset = "0x5452FD0", VA = "0x1854549D0", Slot = "11")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000095")]
	public FFCGIONKJBI AMKPOIHFDKH
	{
		[Cpp2IlInjected.Token(Token = "0x6000228")]
		[Cpp2IlInjected.Address(RVA = "0x5458110", Offset = "0x5456710", VA = "0x185458110", Slot = "12")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000096")]
	public bool CAIEJEMCAII
	{
		[Cpp2IlInjected.Token(Token = "0x6000229")]
		[Cpp2IlInjected.Address(RVA = "0x5459BE0", Offset = "0x54581E0", VA = "0x185459BE0", Slot = "13")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000097")]
	public bool BKKAMGPIPMG
	{
		[Cpp2IlInjected.Token(Token = "0x600022D")]
		[Cpp2IlInjected.Address(RVA = "0x54572A0", Offset = "0x54558A0", VA = "0x1854572A0", Slot = "14")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000098")]
	public bool OFHGFFKKEMJ
	{
		[Cpp2IlInjected.Token(Token = "0x600022E")]
		[Cpp2IlInjected.Address(RVA = "0x5457F30", Offset = "0x5456530", VA = "0x185457F30", Slot = "15")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000099")]
	public IIENCNCJIKK OEBLLEKPOOI
	{
		[Cpp2IlInjected.Token(Token = "0x600022F")]
		[Cpp2IlInjected.Address(RVA = "0x5455BB0", Offset = "0x54541B0", VA = "0x185455BB0", Slot = "16")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000230")]
		[Cpp2IlInjected.Address(RVA = "0x5456130", Offset = "0x5454730", VA = "0x185456130", Slot = "17")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700009A")]
	public JGKAIJBBCDC KPBINMPEPCH
	{
		[Cpp2IlInjected.Token(Token = "0x6000231")]
		[Cpp2IlInjected.Address(RVA = "0x54585F0", Offset = "0x5456BF0", VA = "0x1854585F0", Slot = "18")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000232")]
		[Cpp2IlInjected.Address(RVA = "0x5459920", Offset = "0x5457F20", VA = "0x185459920", Slot = "19")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700009B")]
	public float KJKDBCBOHIJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000233")]
		[Cpp2IlInjected.Address(RVA = "0x5454240", Offset = "0x5452840", VA = "0x185454240", Slot = "20")]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x6000234")]
		[Cpp2IlInjected.Address(RVA = "0x5459500", Offset = "0x5457B00", VA = "0x185459500", Slot = "21")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700009C")]
	public Vector3 BOJDMEIPMAO
	{
		[Cpp2IlInjected.Token(Token = "0x6000235")]
		[Cpp2IlInjected.Address(RVA = "0x5458840", Offset = "0x5456E40", VA = "0x185458840", Slot = "22")]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x6000236")]
		[Cpp2IlInjected.Address(RVA = "0x5456250", Offset = "0x5454850", VA = "0x185456250", Slot = "23")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700009D")]
	public Vector3 DALJIIPOFIE
	{
		[Cpp2IlInjected.Token(Token = "0x6000237")]
		[Cpp2IlInjected.Address(RVA = "0x5454900", Offset = "0x5452F00", VA = "0x185454900", Slot = "24")]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x6000238")]
		[Cpp2IlInjected.Address(RVA = "0x54545A0", Offset = "0x5452BA0", VA = "0x1854545A0", Slot = "25")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700009E")]
	public Vector3 OMPLHOFEJAN
	{
		[Cpp2IlInjected.Token(Token = "0x6000239")]
		[Cpp2IlInjected.Address(RVA = "0x5455E80", Offset = "0x5454480", VA = "0x185455E80", Slot = "26")]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x600023A")]
		[Cpp2IlInjected.Address(RVA = "0x5457F80", Offset = "0x5456580", VA = "0x185457F80", Slot = "27")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700009F")]
	public Vector3 IPICDHHHJOG
	{
		[Cpp2IlInjected.Token(Token = "0x600023B")]
		[Cpp2IlInjected.Address(RVA = "0x5455310", Offset = "0x5453910", VA = "0x185455310", Slot = "28")]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x600023C")]
		[Cpp2IlInjected.Address(RVA = "0x5458380", Offset = "0x5456980", VA = "0x185458380", Slot = "29")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A0")]
	public bool KENDHOCAHBA
	{
		[Cpp2IlInjected.Token(Token = "0x600023D")]
		[Cpp2IlInjected.Address(RVA = "0x5455B60", Offset = "0x5454160", VA = "0x185455B60", Slot = "30")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A1")]
	public bool EHJFPLNBAAH
	{
		[Cpp2IlInjected.Token(Token = "0x600023E")]
		[Cpp2IlInjected.Address(RVA = "0x5454110", Offset = "0x5452710", VA = "0x185454110", Slot = "31")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A2")]
	public bool PLHBBEKOBGN
	{
		[Cpp2IlInjected.Token(Token = "0x600023F")]
		[Cpp2IlInjected.Address(RVA = "0x5458F80", Offset = "0x5457580", VA = "0x185458F80", Slot = "32")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A3")]
	public bool NKPLDABKJCL
	{
		[Cpp2IlInjected.Token(Token = "0x6000240")]
		[Cpp2IlInjected.Address(RVA = "0x5457790", Offset = "0x5455D90", VA = "0x185457790", Slot = "33")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A4")]
	public Vector3 GNKPAMJBNBD
	{
		[Cpp2IlInjected.Token(Token = "0x6000251")]
		[Cpp2IlInjected.Address(RVA = "0x5455DB0", Offset = "0x54543B0", VA = "0x185455DB0", Slot = "34")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A5")]
	public Vector3 DECHPPBODKH
	{
		[Cpp2IlInjected.Token(Token = "0x6000252")]
		[Cpp2IlInjected.Address(RVA = "0x5455CE0", Offset = "0x54542E0", VA = "0x185455CE0", Slot = "35")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A6")]
	public Vector3 AAGDOJLDOMM
	{
		[Cpp2IlInjected.Token(Token = "0x6000257")]
		[Cpp2IlInjected.Address(RVA = "0x5459E80", Offset = "0x5458480", VA = "0x185459E80", Slot = "36")]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x6000258")]
		[Cpp2IlInjected.Address(RVA = "0x5459430", Offset = "0x5457A30", VA = "0x185459430", Slot = "37")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A7")]
	public Vector3 DJLPMKOMOHI
	{
		[Cpp2IlInjected.Token(Token = "0x6000259")]
		[Cpp2IlInjected.Address(RVA = "0x5454480", Offset = "0x5452A80", VA = "0x185454480", Slot = "38")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A8")]
	public float MGOEPMCMEHB
	{
		[Cpp2IlInjected.Token(Token = "0x600025A")]
		[Cpp2IlInjected.Address(RVA = "0x5454C70", Offset = "0x5453270", VA = "0x185454C70", Slot = "39")]
		get
		{
			return default(float);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A9")]
	public float OEDNFOGCCII
	{
		[Cpp2IlInjected.Token(Token = "0x600025B")]
		[Cpp2IlInjected.Address(RVA = "0x5456C00", Offset = "0x5455200", VA = "0x185456C00", Slot = "40")]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x600025C")]
		[Cpp2IlInjected.Address(RVA = "0x5455C00", Offset = "0x5454200", VA = "0x185455C00", Slot = "41")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000AA")]
	public Vector3 KGPDAOIKKOA
	{
		[Cpp2IlInjected.Token(Token = "0x600025D")]
		[Cpp2IlInjected.Address(RVA = "0x5453F90", Offset = "0x5452590", VA = "0x185453F90", Slot = "42")]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x600025E")]
		[Cpp2IlInjected.Address(RVA = "0x5454170", Offset = "0x5452770", VA = "0x185454170", Slot = "43")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000AB")]
	public Quaternion GADCINNEPIK
	{
		[Cpp2IlInjected.Token(Token = "0x600025F")]
		[Cpp2IlInjected.Address(RVA = "0x5456A70", Offset = "0x5455070", VA = "0x185456A70", Slot = "44")]
		get
		{
			return default(Quaternion);
		}
		[Cpp2IlInjected.Token(Token = "0x6000260")]
		[Cpp2IlInjected.Address(RVA = "0x5456490", Offset = "0x5454A90", VA = "0x185456490", Slot = "45")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000AC")]
	public float KDAOPIJAMOB
	{
		[Cpp2IlInjected.Token(Token = "0x6000264")]
		[Cpp2IlInjected.Address(RVA = "0x5454F70", Offset = "0x5453570", VA = "0x185454F70", Slot = "46")]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x6000265")]
		[Cpp2IlInjected.Address(RVA = "0x5455170", Offset = "0x5453770", VA = "0x185455170", Slot = "47")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000AD")]
	public float FEGLLEJAJOH
	{
		[Cpp2IlInjected.Token(Token = "0x6000266")]
		[Cpp2IlInjected.Address(RVA = "0x5458C40", Offset = "0x5457240", VA = "0x185458C40", Slot = "48")]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x6000267")]
		[Cpp2IlInjected.Address(RVA = "0x5455B00", Offset = "0x5454100", VA = "0x185455B00", Slot = "49")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000AE")]
	public bool HGEMBEONDNJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000268")]
		[Cpp2IlInjected.Address(RVA = "0x5458A40", Offset = "0x5457040", VA = "0x185458A40", Slot = "50")]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000269")]
		[Cpp2IlInjected.Address(RVA = "0x54546C0", Offset = "0x5452CC0", VA = "0x1854546C0", Slot = "51")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000AF")]
	public CKHEJONCKGK GGJLBGDDKGJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000271")]
		[Cpp2IlInjected.Address(RVA = "0x54566A0", Offset = "0x5454CA0", VA = "0x1854566A0", Slot = "52")]
		get
		{
			return default(CKHEJONCKGK);
		}
		[Cpp2IlInjected.Token(Token = "0x6000272")]
		[Cpp2IlInjected.Address(RVA = "0x5458050", Offset = "0x5456650", VA = "0x185458050", Slot = "53")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B0")]
	public bool DEHDGKEMKCA
	{
		[Cpp2IlInjected.Token(Token = "0x6000275")]
		[Cpp2IlInjected.Address(RVA = "0x5458D70", Offset = "0x5457370", VA = "0x185458D70", Slot = "54")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B1")]
	public Transform DPCGIDOBNGL
	{
		[Cpp2IlInjected.Token(Token = "0x600027C")]
		[Cpp2IlInjected.Address(RVA = "0x54579D0", Offset = "0x5455FD0", VA = "0x1854579D0", Slot = "55")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B2")]
	public Transform EAILDMMFMIE
	{
		[Cpp2IlInjected.Token(Token = "0x600027D")]
		[Cpp2IlInjected.Address(RVA = "0x54579D0", Offset = "0x5455FD0", VA = "0x1854579D0", Slot = "56")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B3")]
	public Vector3 HAPPDNNLGPN
	{
		[Cpp2IlInjected.Token(Token = "0x600027E")]
		[Cpp2IlInjected.Address(RVA = "0x5459DD0", Offset = "0x54583D0", VA = "0x185459DD0", Slot = "57")]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x600027F")]
		[Cpp2IlInjected.Address(RVA = "0x5458E20", Offset = "0x5457420", VA = "0x185458E20", Slot = "58")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B4")]
	public float MAFJLHAELCE
	{
		[Cpp2IlInjected.Token(Token = "0x6000280")]
		[Cpp2IlInjected.Address(RVA = "0x5456380", Offset = "0x5454980", VA = "0x185456380", Slot = "59")]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x6000281")]
		[Cpp2IlInjected.Address(RVA = "0x5456970", Offset = "0x5454F70", VA = "0x185456970", Slot = "60")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B5")]
	public float EEAGMHLGCPI
	{
		[Cpp2IlInjected.Token(Token = "0x6000282")]
		[Cpp2IlInjected.Address(RVA = "0x5459380", Offset = "0x5457980", VA = "0x185459380", Slot = "61")]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x6000283")]
		[Cpp2IlInjected.Address(RVA = "0x5458A90", Offset = "0x5457090", VA = "0x185458A90", Slot = "62")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B6")]
	public Quaternion BDIPPGABHED
	{
		[Cpp2IlInjected.Token(Token = "0x6000284")]
		[Cpp2IlInjected.Address(RVA = "0x54563E0", Offset = "0x54549E0", VA = "0x1854563E0", Slot = "63")]
		get
		{
			return default(Quaternion);
		}
		[Cpp2IlInjected.Token(Token = "0x6000285")]
		[Cpp2IlInjected.Address(RVA = "0x5456060", Offset = "0x5454660", VA = "0x185456060", Slot = "64")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B7")]
	public Vector3 MLJGHHMBALO
	{
		[Cpp2IlInjected.Token(Token = "0x6000286")]
		[Cpp2IlInjected.Address(RVA = "0x5454060", Offset = "0x5452660", VA = "0x185454060", Slot = "65")]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x6000287")]
		[Cpp2IlInjected.Address(RVA = "0x5458160", Offset = "0x5456760", VA = "0x185458160", Slot = "66")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B8")]
	public Quaternion ADAPJGEEEOL
	{
		[Cpp2IlInjected.Token(Token = "0x6000288")]
		[Cpp2IlInjected.Address(RVA = "0x5458910", Offset = "0x5456F10", VA = "0x185458910", Slot = "67")]
		get
		{
			return default(Quaternion);
		}
		[Cpp2IlInjected.Token(Token = "0x6000289")]
		[Cpp2IlInjected.Address(RVA = "0x54560F0", Offset = "0x54546F0", VA = "0x1854560F0", Slot = "68")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B9")]
	public RigidbodyConstraints AKGJCKADCBH
	{
		[Cpp2IlInjected.Token(Token = "0x600028D")]
		[Cpp2IlInjected.Address(RVA = "0x5457740", Offset = "0x5455D40", VA = "0x185457740", Slot = "69")]
		get
		{
			return default(RigidbodyConstraints);
		}
		[Cpp2IlInjected.Token(Token = "0x600028E")]
		[Cpp2IlInjected.Address(RVA = "0x5454CC0", Offset = "0x54532C0", VA = "0x185454CC0", Slot = "70")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000BA")]
	public bool IELKFNIBHFB
	{
		[Cpp2IlInjected.Token(Token = "0x600028F")]
		[Cpp2IlInjected.Address(RVA = "0x5454D70", Offset = "0x5453370", VA = "0x185454D70", Slot = "71")]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000290")]
		[Cpp2IlInjected.Address(RVA = "0x54579E0", Offset = "0x5455FE0", VA = "0x1854579E0", Slot = "72")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000BB")]
	public CollisionDetectionMode GDCFMCCNNGL
	{
		[Cpp2IlInjected.Token(Token = "0x6000299")]
		[Cpp2IlInjected.Address(RVA = "0x5454670", Offset = "0x5452C70", VA = "0x185454670", Slot = "73")]
		get
		{
			return default(CollisionDetectionMode);
		}
		[Cpp2IlInjected.Token(Token = "0x600029A")]
		[Cpp2IlInjected.Address(RVA = "0x5459060", Offset = "0x5457660", VA = "0x185459060", Slot = "74")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000BC")]
	public bool CEDDMPPAJDO
	{
		[Cpp2IlInjected.Token(Token = "0x600029C")]
		[Cpp2IlInjected.Address(RVA = "0x5456560", Offset = "0x5454B60", VA = "0x185456560", Slot = "75")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000021")]
	public event HOBHPHAMKBD IAOFFICNEFM
	{
		[Cpp2IlInjected.Token(Token = "0x600021F")]
		[Cpp2IlInjected.Address(RVA = "0x54559E0", Offset = "0x5453FE0", VA = "0x1854559E0", Slot = "81")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000220")]
		[Cpp2IlInjected.Address(RVA = "0x5455480", Offset = "0x5453A80", VA = "0x185455480", Slot = "82")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000022")]
	public event HOBHPHAMKBD BPJGPOJJOIC
	{
		[Cpp2IlInjected.Token(Token = "0x6000221")]
		[Cpp2IlInjected.Address(RVA = "0x54550C0", Offset = "0x54536C0", VA = "0x1854550C0", Slot = "83")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000222")]
		[Cpp2IlInjected.Address(RVA = "0x5459110", Offset = "0x5457710", VA = "0x185459110", Slot = "84")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000023")]
	public event ABBLHFOFAPM IANJCDBCFAJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000223")]
		[Cpp2IlInjected.Address(RVA = "0x5459CC0", Offset = "0x54582C0", VA = "0x185459CC0", Slot = "85")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000224")]
		[Cpp2IlInjected.Address(RVA = "0x5456320", Offset = "0x5454920", VA = "0x185456320", Slot = "86")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000024")]
	public event HOBHPHAMKBD IBIGIAONNFK
	{
		[Cpp2IlInjected.Token(Token = "0x600022B")]
		[Cpp2IlInjected.Address(RVA = "0x5457690", Offset = "0x5455C90", VA = "0x185457690", Slot = "88")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600022C")]
		[Cpp2IlInjected.Address(RVA = "0x5455AA0", Offset = "0x54540A0", VA = "0x185455AA0", Slot = "89")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000025")]
	public event HOBHPHAMKBD MPMMHJCOBJO
	{
		[Cpp2IlInjected.Token(Token = "0x6000255")]
		[Cpp2IlInjected.Address(RVA = "0x5459320", Offset = "0x5457920", VA = "0x185459320", Slot = "108")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000256")]
		[Cpp2IlInjected.Address(RVA = "0x5459270", Offset = "0x5457870", VA = "0x185459270", Slot = "109")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000026")]
	public event HOBHPHAMKBD IHIJNHOELAG
	{
		[Cpp2IlInjected.Token(Token = "0x600026A")]
		[Cpp2IlInjected.Address(RVA = "0x54540B0", Offset = "0x54526B0", VA = "0x1854540B0", Slot = "113")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600026B")]
		[Cpp2IlInjected.Address(RVA = "0x5459710", Offset = "0x5457D10", VA = "0x185459710", Slot = "114")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000027")]
	public event Action<CEAPFNKIAFO, CEAPFNKIAFO> GAJNIIPFKOP
	{
		[Cpp2IlInjected.Token(Token = "0x600026F")]
		[Cpp2IlInjected.Address(RVA = "0x54567A0", Offset = "0x5454DA0", VA = "0x1854567A0", Slot = "117")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000270")]
		[Cpp2IlInjected.Address(RVA = "0x5456B40", Offset = "0x5455140", VA = "0x185456B40", Slot = "118")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000028")]
	public event HOBHPHAMKBD PJPDOAADALA
	{
		[Cpp2IlInjected.Token(Token = "0x6000273")]
		[Cpp2IlInjected.Address(RVA = "0x5458DC0", Offset = "0x54573C0", VA = "0x185458DC0", Slot = "119")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000274")]
		[Cpp2IlInjected.Address(RVA = "0x5457090", Offset = "0x5455690", VA = "0x185457090", Slot = "120")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000029")]
	public event HOBHPHAMKBD JDPDGOHICPK
	{
		[Cpp2IlInjected.Token(Token = "0x600027A")]
		[Cpp2IlInjected.Address(RVA = "0x5457200", Offset = "0x5455800", VA = "0x185457200", Slot = "125")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600027B")]
		[Cpp2IlInjected.Address(RVA = "0x54553E0", Offset = "0x54539E0", VA = "0x1854553E0", Slot = "126")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000218")]
	[Cpp2IlInjected.Address(RVA = "0x5443CE0", Offset = "0x54422E0", VA = "0x185443CE0")]
	public NMHAAMBBHKD(GameObject EHEABJNEALG, RigidbodyEx LMKJNNOGFLA, MPHIHDCLPDB HKMONJIHHIH, in IMECCMKFBII JIHCLPECHIB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000219")]
	[Cpp2IlInjected.Address(RVA = "0x5455700", Offset = "0x5453D00", VA = "0x185455700", Slot = "142")]
	protected virtual void EBMDLPECLDP(MPHIHDCLPDB HKMONJIHHIH, IMECCMKFBII JIHCLPECHIB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600021A")]
	[Cpp2IlInjected.Address(RVA = "0x5455540", Offset = "0x5453B40", VA = "0x185455540", Slot = "143")]
	public virtual void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600021B")]
	[Cpp2IlInjected.Address(RVA = "0x5459560", Offset = "0x5457B60", VA = "0x185459560", Slot = "76")]
	public void NOMIHBFFLNG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600021C")]
	[Cpp2IlInjected.Address(RVA = "0x5454720", Offset = "0x5452D20", VA = "0x185454720", Slot = "77")]
	public void EFPEPNDIDBP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600021D")]
	[Cpp2IlInjected.Address(RVA = "0x1D9D200", Offset = "0x1D9B800", VA = "0x181D9D200", Slot = "78")]
	public void AHFFBOOJKLD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600021E")]
	[Cpp2IlInjected.Address(RVA = "0x5458ED0", Offset = "0x54574D0", VA = "0x185458ED0", Slot = "144")]
	public virtual void MKJLJFAPFNF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600022A")]
	[Cpp2IlInjected.Address(RVA = "0x54596A0", Offset = "0x5457CA0", VA = "0x1854596A0", Slot = "87")]
	public void OGODNIIEFFB(FFCGIONKJBI MAKFNMHIJIF, bool JAHLDBIKCJI = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000241")]
	[Cpp2IlInjected.Address(RVA = "0x54554E0", Offset = "0x5453AE0", VA = "0x1854554E0", Slot = "90")]
	public void DPOKFGFKBCC(object HKLDIENGNNB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000242")]
	[Cpp2IlInjected.Address(RVA = "0x5455A40", Offset = "0x5454040", VA = "0x185455A40", Slot = "91")]
	public void EEPLGJOEHDM(object HKLDIENGNNB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000243")]
	[Cpp2IlInjected.Address(RVA = "0x5458950", Offset = "0x5456F50", VA = "0x185458950", Slot = "92")]
	public Vector3 LKOKGKNLODE(Vector3 JMLACAFKJOF)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000244")]
	[Cpp2IlInjected.Address(RVA = "0x5459A00", Offset = "0x5458000", VA = "0x185459A00", Slot = "93")]
	public Vector3 PIFFFCJGHPG(Vector3 OLLLCEPAFHE)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000245")]
	[Cpp2IlInjected.Address(RVA = "0x5454720", Offset = "0x5452D20", VA = "0x185454720", Slot = "94")]
	public void BCKDLBEFMPH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000246")]
	[Cpp2IlInjected.Address(RVA = "0x54593E0", Offset = "0x54579E0", VA = "0x1854593E0", Slot = "95")]
	public void NLLIBPNNBGH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000247")]
	[Cpp2IlInjected.Address(RVA = "0x54592D0", Offset = "0x54578D0", VA = "0x1854592D0", Slot = "96")]
	public void NFCJHIFEHGE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000248")]
	[Cpp2IlInjected.Address(RVA = "0x54584B0", Offset = "0x5456AB0", VA = "0x1854584B0", Slot = "97")]
	public void KPJAOLBLIEI(Vector3 PFDFFPLAJJP, Vector3 HGIFCPKBAGG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000249")]
	[Cpp2IlInjected.Address(RVA = "0x5455610", Offset = "0x5453C10", VA = "0x185455610", Slot = "98")]
	public void EBKBGNAGIOD(Vector3 LOGKBIHCFJD, Vector3 OGPMEJLJLFA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600024A")]
	[Cpp2IlInjected.Address(RVA = "0x5455240", Offset = "0x5453840", VA = "0x185455240", Slot = "99")]
	public void DNAJDFGLENG(Vector3 OANHHGBFKAN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600024B")]
	[Cpp2IlInjected.Address(RVA = "0x5454B50", Offset = "0x5453150", VA = "0x185454B50", Slot = "100")]
	public void CBHLOBJDACM(CKAOOODELAE IKFPEHIFEPN, Vector3 NMBFBKMEJKN, float FEHHFHACKBK, float IOFMPFNPHNC = 8f, float JKLGNKAKKLG = 1f)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600024C")]
	[Cpp2IlInjected.Address(RVA = "0x5459170", Offset = "0x5457770", VA = "0x185459170", Slot = "101")]
	public void NCIJALPIGCE(MCMFGEDCCGC LMLMHHPMBJO, Vector3 OFLGCJLDNJJ, float IPAPNFBMGEF = float.PositiveInfinity)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600024D")]
	[Cpp2IlInjected.Address(RVA = "0x5455F50", Offset = "0x5454550", VA = "0x185455F50", Slot = "102")]
	[Obsolete]
	public void FDJHKHJGOHO(MCMFGEDCCGC LMLMHHPMBJO, Vector3 JGCPJBFFFAC, float NMBEKOOKPJA = 7f, float MFBAPHBIEKM = 1f)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600024E")]
	[Cpp2IlInjected.Address(RVA = "0x5454290", Offset = "0x5452890", VA = "0x185454290", Slot = "103")]
	public Vector3 AJLBGCPJCKN(Vector3 MAKFNMHIJIF)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x600024F")]
	[Cpp2IlInjected.Address(RVA = "0x5459AF0", Offset = "0x54580F0", VA = "0x185459AF0", Slot = "104")]
	public Vector3 PIFNCDNOKAD(Vector3 MAKFNMHIJIF)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000250")]
	[Cpp2IlInjected.Address(RVA = "0x54585A0", Offset = "0x5456BA0", VA = "0x1854585A0", Slot = "105")]
	public void LADPNNADDEK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000253")]
	[Cpp2IlInjected.Address(RVA = "0x5458770", Offset = "0x5456D70", VA = "0x185458770", Slot = "106")]
	public void LJGPKEPDMFN(FFCGIONKJBI HJFPEPOCKIC, object HKLDIENGNNB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000254")]
	[Cpp2IlInjected.Address(RVA = "0x5456740", Offset = "0x5454D40", VA = "0x185456740", Slot = "107")]
	public void GBMKLKMCAMC(object HKLDIENGNNB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000261")]
	[Cpp2IlInjected.Address(RVA = "0x5454B00", Offset = "0x5453100", VA = "0x185454B00", Slot = "110")]
	public void CAALKOKEPPD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000262")]
	[Cpp2IlInjected.Address(RVA = "0x5454550", Offset = "0x5452B50", VA = "0x185454550", Slot = "111")]
	public void BANKNELMPFP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000263")]
	[Cpp2IlInjected.Address(RVA = "0x54566F0", Offset = "0x5454CF0", VA = "0x1854566F0", Slot = "112")]
	public void GAANFDFDMKC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600026C")]
	[Cpp2IlInjected.Address(RVA = "0x54590C0", Offset = "0x54576C0", VA = "0x1854590C0", Slot = "115")]
	public bool MNIMMDJAIIP()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600026D")]
	[Cpp2IlInjected.Address(RVA = "0x5454380", Offset = "0x5452980", VA = "0x185454380", Slot = "79")]
	public void ALKMJGDDHDA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600026E")]
	[Cpp2IlInjected.Address(RVA = "0x5458640", Offset = "0x5456C40", VA = "0x185458640", Slot = "116")]
	public void LEMLLHIPKGE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000276")]
	[Cpp2IlInjected.Address(RVA = "0x54576F0", Offset = "0x5455CF0", VA = "0x1854576F0", Slot = "121")]
	public IDisposable IFKNDGBNBEF()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000277")]
	[Cpp2IlInjected.Address(RVA = "0x5456190", Offset = "0x5454790", VA = "0x185456190", Slot = "122")]
	public void FKOFNEMGINM(object HKLDIENGNNB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000278")]
	[Cpp2IlInjected.Address(RVA = "0x5454770", Offset = "0x5452D70", VA = "0x185454770", Slot = "123")]
	public void BEHGOGKEFEN(object HKLDIENGNNB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000279")]
	[Cpp2IlInjected.Address(RVA = "0x54551D0", Offset = "0x54537D0", VA = "0x1854551D0", Slot = "124")]
	public void DLBAIGNALBD(object HKLDIENGNNB, bool BKHDMOGADPG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600028A")]
	[Cpp2IlInjected.Address(RVA = "0x5457D20", Offset = "0x5456320", VA = "0x185457D20", Slot = "127")]
	public void JEBPKKGFEDL(Vector3 AFHANPMAJON, Quaternion MGLHGJDPDPO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600028B")]
	[Cpp2IlInjected.Address(RVA = "0x5454DC0", Offset = "0x54533C0", VA = "0x185454DC0", Slot = "128")]
	public void CIOEFCEIHBP(Vector3 JGOFLNCMNEF, Quaternion HHGDJGKIPDH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600028C")]
	[Cpp2IlInjected.Address(RVA = "0x5459770", Offset = "0x5457D70", VA = "0x185459770", Slot = "129")]
	public bool OJPJAEOKAPC(float CJJGIOGGJMO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000291")]
	[Cpp2IlInjected.Address(RVA = "0x54561F0", Offset = "0x54547F0", VA = "0x1854561F0", Slot = "130")]
	public void FLGEALADFAB(object HKLDIENGNNB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000292")]
	[Cpp2IlInjected.Address(RVA = "0x5456BA0", Offset = "0x54551A0", VA = "0x185456BA0", Slot = "131")]
	public void GOLJJNAJJDK(object HKLDIENGNNB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000293")]
	[Cpp2IlInjected.Address(RVA = "0x5456C50", Offset = "0x5455250", VA = "0x185456C50", Slot = "132")]
	public void HCDCAKONHKH(object HKLDIENGNNB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000294")]
	[Cpp2IlInjected.Address(RVA = "0x5454420", Offset = "0x5452A20", VA = "0x185454420", Slot = "133")]
	public void ANODKIPNKGG(object HKLDIENGNNB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000295")]
	[Cpp2IlInjected.Address(RVA = "0x5459980", Offset = "0x5457F80", VA = "0x185459980", Slot = "134")]
	public void PADGBNKEIIJ(Vector3 CBEIFKNKIIE, ForceMode OEBHACLNMCB = ForceMode.Force)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000296")]
	[Cpp2IlInjected.Address(RVA = "0x54570F0", Offset = "0x54556F0", VA = "0x1854570F0", Slot = "135")]
	public void HKDCNICIFFL(Vector3 CBEIFKNKIIE, Vector3 EINGNKDKDHC, ForceMode OEBHACLNMCB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000297")]
	[Cpp2IlInjected.Address(RVA = "0x5455C60", Offset = "0x5454260", VA = "0x185455C60", Slot = "136")]
	public void EPMGKEGNALO(Vector3 DEMLAEGANDJ, ForceMode OEBHACLNMCB = ForceMode.Force)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000298")]
	[Cpp2IlInjected.Address(RVA = "0x5459C40", Offset = "0x5458240", VA = "0x185459C40", Slot = "137")]
	public void PINFLFOIKOH(Vector3 DEMLAEGANDJ, ForceMode OEBHACLNMCB = ForceMode.Force)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600029B")]
	[Cpp2IlInjected.Address(RVA = "0x5454FC0", Offset = "0x54535C0", VA = "0x185454FC0", Slot = "138")]
	public bool COKAFBGHKMH(Vector3 FOGEFLLJLFJ, out RaycastHit LOOJGACDMOC, float IDHCBHDHMCK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600029D")]
	[Cpp2IlInjected.Address(RVA = "0x5455120", Offset = "0x5453720", VA = "0x185455120", Slot = "139")]
	public void DFDCFAGILJM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600029E")]
	[Cpp2IlInjected.Address(RVA = "0x5459F50", Offset = "0x5458550", VA = "0x185459F50", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600029F")]
	[Cpp2IlInjected.Address(RVA = "0x54581B0", Offset = "0x54567B0", VA = "0x1854581B0")]
	private void KLDMCFHBMON()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002A0")]
	[Cpp2IlInjected.Address(RVA = "0x5459810", Offset = "0x5457E10", VA = "0x185459810")]
	private void OKOCHAGMMEH(FFCGIONKJBI LFAIGCEGCPL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002A1")]
	[Cpp2IlInjected.Address(RVA = "0x54577E0", Offset = "0x5455DE0", VA = "0x1854577E0")]
	private void ILOIOLJPCJK(FFCGIONKJBI LFAIGCEGCPL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002A2")]
	[Cpp2IlInjected.Address(RVA = "0x5456FE0", Offset = "0x54555E0", VA = "0x185456FE0")]
	private void HEKIMGDLLBA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002A3")]
	[Cpp2IlInjected.Address(RVA = "0x5458280", Offset = "0x5456880", VA = "0x185458280")]
	private void KLNLDCHFHKA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002A4")]
	[Cpp2IlInjected.Address(RVA = "0x5459D20", Offset = "0x5458320", VA = "0x185459D20")]
	private void PNEHJDGDGIB(FFCGIONKJBI EBNAKIGKECH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002A5")]
	[Cpp2IlInjected.Address(RVA = "0x5458C90", Offset = "0x5457290", VA = "0x185458C90")]
	private void MELFMEBHFAF(FFCGIONKJBI LFAIGCEGCPL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002A6")]
	[Cpp2IlInjected.Address(RVA = "0x5454A20", Offset = "0x5453020", VA = "0x185454A20")]
	private void BLHLKMFLDGD(FFCGIONKJBI LFAIGCEGCPL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002A7")]
	[Cpp2IlInjected.Address(RVA = "0x5456800", Offset = "0x5454E00", VA = "0x185456800")]
	private void GIDDHIIKING(RigidbodyEx LFAIGCEGCPL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002A8")]
	[Cpp2IlInjected.Address(RVA = "0x54572F0", Offset = "0x54558F0", VA = "0x1854572F0")]
	private void IDAHAJGPEBI(RigidbodyEx FHCKPPNILHO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002A9")]
	[Cpp2IlInjected.Address(RVA = "0x54547D0", Offset = "0x5452DD0", VA = "0x1854547D0")]
	[Conditional("UNITY_EDITOR")]
	private void BFCFJGIMHOP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002AA")]
	[Cpp2IlInjected.Address(RVA = "0x5457A40", Offset = "0x5456040", VA = "0x185457A40")]
	protected void JBCBJFDKAKF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002AB")]
	[Cpp2IlInjected.Address(RVA = "0x5456CB0", Offset = "0x54552B0", VA = "0x185456CB0")]
	protected void HCLPGFICBAA()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002A")]
internal static class CEKIFKHKOKD
{
	[Cpp2IlInjected.Token(Token = "0x60002AC")]
	[Cpp2IlInjected.Address(RVA = "0x543ABD0", Offset = "0x54391D0", VA = "0x18543ABD0")]
	public static FFCGIONKJBI DDJFGNKMBJL(this FFCGIONKJBI FHCKPPNILHO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002AD")]
	[Cpp2IlInjected.Address(RVA = "0x543AD10", Offset = "0x5439310", VA = "0x18543AD10")]
	public static bool FIKNKJFNOKF(this FFCGIONKJBI FHCKPPNILHO, FFCGIONKJBI EPDAFINDPJC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002AE")]
	[Cpp2IlInjected.Address(RVA = "0x543AC90", Offset = "0x5439290", VA = "0x18543AC90")]
	public static bool FDEMDGEAPGF(this FFCGIONKJBI FHCKPPNILHO, FFCGIONKJBI PPMNPHOOLCH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002AF")]
	[Cpp2IlInjected.Address(RVA = "0x543AE00", Offset = "0x5439400", VA = "0x18543AE00")]
	public static RigidbodyEx MDFBJOGOGGI(this FFCGIONKJBI JHGMMLCOACP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002B0")]
	[Cpp2IlInjected.Address(RVA = "0x543AD90", Offset = "0x5439390", VA = "0x18543AD90")]
	public static NMHAAMBBHKD HEGHHKAAEFO(this FFCGIONKJBI BMFGKMDOFCF)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200002B")]
internal class FBOFBKLHDPE : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000043")]
	private readonly NMHAAMBBHKD FHCKPPNILHO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000044")]
	private bool LNPMOHBLPOO;

	[Cpp2IlInjected.Token(Token = "0x60002B1")]
	[Cpp2IlInjected.Address(RVA = "0x5443E10", Offset = "0x5442410", VA = "0x185443E10")]
	public FBOFBKLHDPE(NMHAAMBBHKD KNIJILCEPPI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002B2")]
	[Cpp2IlInjected.Address(RVA = "0x5443DB0", Offset = "0x54423B0", VA = "0x185443DB0", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002C")]
internal sealed class LFJKEMJKDPC : KCCPFAJLCEJ, MFNEPAJBKBE
{
	[Cpp2IlInjected.Token(Token = "0x170000BD")]
	private CollisionDetectionMode HMGMMLOFAKG
	{
		[Cpp2IlInjected.Token(Token = "0x60002B4")]
		[Cpp2IlInjected.Address(RVA = "0x5452590", Offset = "0x5450B90", VA = "0x185452590")]
		get
		{
			return default(CollisionDetectionMode);
		}
		[Cpp2IlInjected.Token(Token = "0x60002B5")]
		[Cpp2IlInjected.Address(RVA = "0x5452410", Offset = "0x5450A10", VA = "0x185452410")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000BE")]
	private Rigidbody BKIDAKAFFMP
	{
		[Cpp2IlInjected.Token(Token = "0x60002B6")]
		[Cpp2IlInjected.Address(RVA = "0x5440010", Offset = "0x543E610", VA = "0x185440010")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000BF")]
	public CollisionDetectionMode GDCFMCCNNGL
	{
		[Cpp2IlInjected.Token(Token = "0x60002B9")]
		[Cpp2IlInjected.Address(RVA = "0x5452170", Offset = "0x5450770", VA = "0x185452170", Slot = "4")]
		get
		{
			return default(CollisionDetectionMode);
		}
		[Cpp2IlInjected.Token(Token = "0x60002BA")]
		[Cpp2IlInjected.Address(RVA = "0x5452670", Offset = "0x5450C70", VA = "0x185452670", Slot = "5")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60002B3")]
	[Cpp2IlInjected.Address(RVA = "0x5436210", Offset = "0x5434810", VA = "0x185436210")]
	public LFJKEMJKDPC(FFCGIONKJBI FHCKPPNILHO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002B7")]
	[Cpp2IlInjected.Address(RVA = "0x54526F0", Offset = "0x5450CF0", VA = "0x1854526F0", Slot = "6")]
	public void NOMIHBFFLNG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002B8")]
	[Cpp2IlInjected.Address(RVA = "0x5452500", Offset = "0x5450B00", VA = "0x185452500", Slot = "9")]
	public void KDPOLAHOOPE(Rigidbody MKOMGOCHBJC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002BB")]
	[Cpp2IlInjected.Address(RVA = "0x54523F0", Offset = "0x54509F0", VA = "0x1854523F0", Slot = "7")]
	public void FICELACKBCB(bool IGMFHMLOGDC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002BC")]
	[Cpp2IlInjected.Address(RVA = "0x5452400", Offset = "0x5450A00", VA = "0x185452400", Slot = "8")]
	public void GDPJJGMKJBP(bool IGMFHMLOGDC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002BD")]
	[Cpp2IlInjected.Address(RVA = "0x5452280", Offset = "0x5450880", VA = "0x185452280", Slot = "10")]
	public bool COKAFBGHKMH(Vector3 FOGEFLLJLFJ, out RaycastHit LOOJGACDMOC, float IDHCBHDHMCK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002BE")]
	[Cpp2IlInjected.Address(RVA = "0x5452800", Offset = "0x5450E00", VA = "0x185452800")]
	private void PIOIFMODKCP(bool IGMFHMLOGDC)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002D")]
internal sealed class LFGDFNGNDPM : KCCPFAJLCEJ, CGKAANMHLMI, IDisposable, KCLAPJNLDEK
{
	[Cpp2IlInjected.Token(Token = "0x170000C0")]
	public CKHEJONCKGK KNJLCIBALHC
	{
		[Cpp2IlInjected.Token(Token = "0x60002C2")]
		[Cpp2IlInjected.Address(RVA = "0x5452090", Offset = "0x5450690", VA = "0x185452090")]
		get
		{
			return default(CKHEJONCKGK);
		}
		[Cpp2IlInjected.Token(Token = "0x60002C3")]
		[Cpp2IlInjected.Address(RVA = "0x5451F40", Offset = "0x5450540", VA = "0x185451F40")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000C1")]
	public CKHEJONCKGK GGJLBGDDKGJ
	{
		[Cpp2IlInjected.Token(Token = "0x60002C4")]
		[Cpp2IlInjected.Address(RVA = "0x5451BE0", Offset = "0x54501E0", VA = "0x185451BE0", Slot = "6")]
		get
		{
			return default(CKHEJONCKGK);
		}
		[Cpp2IlInjected.Token(Token = "0x60002C5")]
		[Cpp2IlInjected.Address(RVA = "0x5451F40", Offset = "0x5450540", VA = "0x185451F40", Slot = "7")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000C2")]
	private Transform PDEMFIDJPNF
	{
		[Cpp2IlInjected.Token(Token = "0x60002CA")]
		[Cpp2IlInjected.Address(RVA = "0x677290", Offset = "0x675890", VA = "0x180677290", Slot = "10")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400002A")]
	public event Action<CEAPFNKIAFO, CEAPFNKIAFO> GAJNIIPFKOP
	{
		[Cpp2IlInjected.Token(Token = "0x60002C0")]
		[Cpp2IlInjected.Address(RVA = "0x5451E00", Offset = "0x5450400", VA = "0x185451E00", Slot = "4")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60002C1")]
		[Cpp2IlInjected.Address(RVA = "0x5451EA0", Offset = "0x54504A0", VA = "0x185451EA0", Slot = "5")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60002BF")]
	[Cpp2IlInjected.Address(RVA = "0x5436210", Offset = "0x5434810", VA = "0x185436210")]
	public LFGDFNGNDPM(FFCGIONKJBI FHCKPPNILHO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002C6")]
	[Cpp2IlInjected.Address(RVA = "0x5452030", Offset = "0x5450630", VA = "0x185452030", Slot = "11")]
	public void OnChangedDistanceBand(CEAPFNKIAFO GLJCMMBCBOC, CEAPFNKIAFO PNPBNOELPMC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002C7")]
	[Cpp2IlInjected.Address(RVA = "0x6A8920", Offset = "0x6A6F20", VA = "0x1806A8920", Slot = "12")]
	public void OnChangedVisibility(bool MDMFNFBFLBD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002C8")]
	[Cpp2IlInjected.Address(RVA = "0x6A8920", Offset = "0x6A6F20", VA = "0x1806A8920", Slot = "8")]
	public void NOMIHBFFLNG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002C9")]
	[Cpp2IlInjected.Address(RVA = "0x6A8920", Offset = "0x6A6F20", VA = "0x1806A8920", Slot = "9")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002E")]
internal sealed class DCODNFJFBCO : KCCPFAJLCEJ, GIGBMEPJFND
{
	[Cpp2IlInjected.Token(Token = "0x170000C3")]
	private Rigidbody BKIDAKAFFMP
	{
		[Cpp2IlInjected.Token(Token = "0x60002CC")]
		[Cpp2IlInjected.Address(RVA = "0x5440010", Offset = "0x543E610", VA = "0x185440010")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000C4")]
	private bool DEHDGKEMKCA
	{
		[Cpp2IlInjected.Token(Token = "0x60002CD")]
		[Cpp2IlInjected.Address(RVA = "0x5440740", Offset = "0x543ED40", VA = "0x185440740")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000C5")]
	private bool CAIEJEMCAII
	{
		[Cpp2IlInjected.Token(Token = "0x60002CE")]
		[Cpp2IlInjected.Address(RVA = "0x5437180", Offset = "0x5435780", VA = "0x185437180")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000C6")]
	private FFCGIONKJBI HDIMMFJBNPK
	{
		[Cpp2IlInjected.Token(Token = "0x60002CF")]
		[Cpp2IlInjected.Address(RVA = "0x54402E0", Offset = "0x543E8E0", VA = "0x1854402E0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60002CB")]
	[Cpp2IlInjected.Address(RVA = "0x5436210", Offset = "0x5434810", VA = "0x185436210")]
	public DCODNFJFBCO(FFCGIONKJBI FHCKPPNILHO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002D0")]
	[Cpp2IlInjected.Address(RVA = "0x5440A10", Offset = "0x543F010", VA = "0x185440A10", Slot = "4")]
	public void PADGBNKEIIJ(Vector3 CBEIFKNKIIE, ForceMode OEBHACLNMCB = ForceMode.Force)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002D1")]
	[Cpp2IlInjected.Address(RVA = "0x5440790", Offset = "0x543ED90", VA = "0x185440790")]
	private void OFMHFHDJNMM(Vector3 CBEIFKNKIIE, ForceMode OEBHACLNMCB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002D2")]
	[Cpp2IlInjected.Address(RVA = "0x54404A0", Offset = "0x543EAA0", VA = "0x1854404A0", Slot = "5")]
	public void HKDCNICIFFL(Vector3 CBEIFKNKIIE, Vector3 EINGNKDKDHC, ForceMode OEBHACLNMCB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002D3")]
	[Cpp2IlInjected.Address(RVA = "0x5440340", Offset = "0x543E940", VA = "0x185440340", Slot = "6")]
	public void EPMGKEGNALO(Vector3 DEMLAEGANDJ, ForceMode OEBHACLNMCB = ForceMode.Force)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002D4")]
	[Cpp2IlInjected.Address(RVA = "0x5440060", Offset = "0x543E660", VA = "0x185440060")]
	private void AOALFPILCPL(Vector3 DEMLAEGANDJ, ForceMode OEBHACLNMCB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002D5")]
	[Cpp2IlInjected.Address(RVA = "0x5440B70", Offset = "0x543F170", VA = "0x185440B70", Slot = "7")]
	public void PINFLFOIKOH(Vector3 DEMLAEGANDJ, ForceMode OEBHACLNMCB = ForceMode.Force)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002F")]
internal sealed class HBCABALLLDO : KCCPFAJLCEJ, JJPLOLDPKDF
{
	[Cpp2IlInjected.Token(Token = "0x170000C7")]
	public bool HGEMBEONDNJ
	{
		[Cpp2IlInjected.Token(Token = "0x60002D7")]
		[Cpp2IlInjected.Address(RVA = "0x5445BC0", Offset = "0x54441C0", VA = "0x185445BC0", Slot = "4")]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x60002D8")]
		[Cpp2IlInjected.Address(RVA = "0x5445870", Offset = "0x5443E70", VA = "0x185445870", Slot = "5")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60002D6")]
	[Cpp2IlInjected.Address(RVA = "0x5436210", Offset = "0x5434810", VA = "0x185436210")]
	public HBCABALLLDO(FFCGIONKJBI FHCKPPNILHO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002D9")]
	[Cpp2IlInjected.Address(RVA = "0x5445AC0", Offset = "0x54440C0", VA = "0x185445AC0", Slot = "6")]
	public void KDPOLAHOOPE(Rigidbody MKOMGOCHBJC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002DA")]
	[Cpp2IlInjected.Address(RVA = "0x5445A50", Offset = "0x5444050", VA = "0x185445A50", Slot = "7")]
	public void DIDIIBMEDJD(Rigidbody MKOMGOCHBJC)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000030")]
internal sealed class BEAHBKMBHFL : KCCPFAJLCEJ, IPLGDMEHBOJ, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x400004F")]
	private readonly PBMBFCMPFNE PAHCBODMCHK;

	[Cpp2IlInjected.Token(Token = "0x170000C8")]
	private Transform DACDPJCIAKE
	{
		[Cpp2IlInjected.Token(Token = "0x60002EE")]
		[Cpp2IlInjected.Address(RVA = "0x54391E0", Offset = "0x54377E0", VA = "0x1854391E0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000C9")]
	public NIALADIPDNC OBOIDIJMIJI
	{
		[Cpp2IlInjected.Token(Token = "0x60002F0")]
		[Cpp2IlInjected.Address(RVA = "0x54375A0", Offset = "0x5435BA0", VA = "0x1854375A0")]
		get
		{
			return default(NIALADIPDNC);
		}
		[Cpp2IlInjected.Token(Token = "0x60002F1")]
		[Cpp2IlInjected.Address(RVA = "0x54396C0", Offset = "0x5437CC0", VA = "0x1854396C0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000CA")]
	public FFCGIONKJBI HDIMMFJBNPK
	{
		[Cpp2IlInjected.Token(Token = "0x60002F2")]
		[Cpp2IlInjected.Address(RVA = "0x54378E0", Offset = "0x5435EE0", VA = "0x1854378E0", Slot = "24")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60002F3")]
		[Cpp2IlInjected.Address(RVA = "0x54390D0", Offset = "0x54376D0", VA = "0x1854390D0", Slot = "25")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000CB")]
	public NIALADIPDNC PPLLNBIKJPO
	{
		[Cpp2IlInjected.Token(Token = "0x60002F4")]
		[Cpp2IlInjected.Address(RVA = "0x54376A0", Offset = "0x5435CA0", VA = "0x1854376A0")]
		get
		{
			return default(NIALADIPDNC);
		}
		[Cpp2IlInjected.Token(Token = "0x60002F5")]
		[Cpp2IlInjected.Address(RVA = "0x5437370", Offset = "0x5435970", VA = "0x185437370")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000CC")]
	public FFCGIONKJBI AMKPOIHFDKH
	{
		[Cpp2IlInjected.Token(Token = "0x60002F6")]
		[Cpp2IlInjected.Address(RVA = "0x5438770", Offset = "0x5436D70", VA = "0x185438770", Slot = "23")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000CD")]
	public IReadOnlyList<FFCGIONKJBI> KEPEEEPLAGJ
	{
		[Cpp2IlInjected.Token(Token = "0x60002F7")]
		[Cpp2IlInjected.Address(RVA = "0x810200", Offset = "0x80E800", VA = "0x180810200", Slot = "22")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400002B")]
	public event HOBHPHAMKBD IAOFFICNEFM
	{
		[Cpp2IlInjected.Token(Token = "0x60002DC")]
		[Cpp2IlInjected.Address(RVA = "0x5437E90", Offset = "0x5436490", VA = "0x185437E90", Slot = "4")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60002DD")]
		[Cpp2IlInjected.Address(RVA = "0x5437C20", Offset = "0x5436220", VA = "0x185437C20", Slot = "5")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400002C")]
	public event HOBHPHAMKBD BPJGPOJJOIC
	{
		[Cpp2IlInjected.Token(Token = "0x60002DE")]
		[Cpp2IlInjected.Address(RVA = "0x5437920", Offset = "0x5435F20", VA = "0x185437920", Slot = "6")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60002DF")]
		[Cpp2IlInjected.Address(RVA = "0x5439210", Offset = "0x5437810", VA = "0x185439210", Slot = "7")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400002D")]
	public event ABBLHFOFAPM IANJCDBCFAJ
	{
		[Cpp2IlInjected.Token(Token = "0x60002E0")]
		[Cpp2IlInjected.Address(RVA = "0x5439620", Offset = "0x5437C20", VA = "0x185439620", Slot = "8")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60002E1")]
		[Cpp2IlInjected.Address(RVA = "0x54380F0", Offset = "0x54366F0", VA = "0x1854380F0", Slot = "9")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400002E")]
	public event Action HGFICMNEKPD
	{
		[Cpp2IlInjected.Token(Token = "0x60002E2")]
		[Cpp2IlInjected.Address(RVA = "0x5438190", Offset = "0x5436790", VA = "0x185438190", Slot = "10")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60002E3")]
		[Cpp2IlInjected.Address(RVA = "0x5438370", Offset = "0x5436970", VA = "0x185438370", Slot = "11")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400002F")]
	public event Action AOLPOEKDAPB
	{
		[Cpp2IlInjected.Token(Token = "0x60002E4")]
		[Cpp2IlInjected.Address(RVA = "0x5438230", Offset = "0x5436830", VA = "0x185438230", Slot = "12")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60002E5")]
		[Cpp2IlInjected.Address(RVA = "0x5439140", Offset = "0x5437740", VA = "0x185439140", Slot = "13")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000030")]
	public event Action<FFCGIONKJBI> MIDFDOJCFED
	{
		[Cpp2IlInjected.Token(Token = "0x60002E6")]
		[Cpp2IlInjected.Address(RVA = "0x5437B80", Offset = "0x5436180", VA = "0x185437B80", Slot = "14")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60002E7")]
		[Cpp2IlInjected.Address(RVA = "0x54377A0", Offset = "0x5435DA0", VA = "0x1854377A0", Slot = "15")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000031")]
	public event Action<FFCGIONKJBI> ENHLMFMKKOI
	{
		[Cpp2IlInjected.Token(Token = "0x60002E8")]
		[Cpp2IlInjected.Address(RVA = "0x5439840", Offset = "0x5437E40", VA = "0x185439840", Slot = "16")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60002E9")]
		[Cpp2IlInjected.Address(RVA = "0x54382D0", Offset = "0x54368D0", VA = "0x1854382D0", Slot = "17")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000032")]
	public event Action CBAHCMEOEBH
	{
		[Cpp2IlInjected.Token(Token = "0x60002EA")]
		[Cpp2IlInjected.Address(RVA = "0x5439580", Offset = "0x5437B80", VA = "0x185439580", Slot = "18")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60002EB")]
		[Cpp2IlInjected.Address(RVA = "0x54386D0", Offset = "0x5436CD0", VA = "0x1854386D0", Slot = "19")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000033")]
	public event Action<FFCGIONKJBI> PNGLKBMDHIJ
	{
		[Cpp2IlInjected.Token(Token = "0x60002EC")]
		[Cpp2IlInjected.Address(RVA = "0x54387B0", Offset = "0x5436DB0", VA = "0x1854387B0", Slot = "20")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60002ED")]
		[Cpp2IlInjected.Address(RVA = "0x5437840", Offset = "0x5435E40", VA = "0x185437840", Slot = "21")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60002DB")]
	[Cpp2IlInjected.Address(RVA = "0x54398E0", Offset = "0x5437EE0", VA = "0x1854398E0")]
	public BEAHBKMBHFL(FFCGIONKJBI FHCKPPNILHO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002EF")]
	[Cpp2IlInjected.Address(RVA = "0x5437CC0", Offset = "0x54362C0", VA = "0x185437CC0", Slot = "27")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002F8")]
	[Cpp2IlInjected.Address(RVA = "0x54392B0", Offset = "0x54378B0", VA = "0x1854392B0", Slot = "26")]
	public void OGODNIIEFFB(FFCGIONKJBI EBIGGMLCEAF, bool JAHLDBIKCJI = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002F9")]
	[Cpp2IlInjected.Address(RVA = "0x5439330", Offset = "0x5437930", VA = "0x185439330")]
	private void OGODNIIEFFB(FAEFMAFLNLK EBIGGMLCEAF, bool JAHLDBIKCJI = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002FA")]
	[Cpp2IlInjected.Address(RVA = "0x5438850", Offset = "0x5436E50", VA = "0x185438850")]
	private void KJJDIBPOPCP(FAEFMAFLNLK EBIGGMLCEAF, bool JAHLDBIKCJI = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002FB")]
	[Cpp2IlInjected.Address(RVA = "0x5437F30", Offset = "0x5436530", VA = "0x185437F30")]
	private void FKPIKBICOFJ(FAEFMAFLNLK EBNAKIGKECH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002FC")]
	[Cpp2IlInjected.Address(RVA = "0x54379C0", Offset = "0x5435FC0", VA = "0x1854379C0")]
	private void DCJINOKJEFG(FAEFMAFLNLK EBNAKIGKECH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002FD")]
	[Cpp2IlInjected.Address(RVA = "0x5438530", Offset = "0x5436B30", VA = "0x185438530")]
	private void IIHIMCEPCEK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002FE")]
	[Cpp2IlInjected.Address(RVA = "0x54397C0", Offset = "0x5437DC0", VA = "0x1854397C0")]
	private void PKKLCJELFEI(FAEFMAFLNLK EBNAKIGKECH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002FF")]
	[Cpp2IlInjected.Address(RVA = "0x54393A0", Offset = "0x54379A0", VA = "0x1854393A0")]
	private void ONAEFPLNEDD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000300")]
	[Cpp2IlInjected.Address(RVA = "0x5438410", Offset = "0x5436A10", VA = "0x185438410")]
	private void IBNBBPLEKPA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000301")]
	[Cpp2IlInjected.Address(RVA = "0x5439450", Offset = "0x5437A50", VA = "0x185439450")]
	private void OPJJCFHECII(FAEFMAFLNLK FHCKPPNILHO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000302")]
	[Cpp2IlInjected.Address(RVA = "0x5437470", Offset = "0x5435A70", VA = "0x185437470")]
	private void APJHAKKKPLO(FAEFMAFLNLK FHCKPPNILHO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000303")]
	[Cpp2IlInjected.Address(RVA = "0x5437270", Offset = "0x5435870", VA = "0x185437270")]
	[CompilerGenerated]
	private object AAAKBILJDGK()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000031")]
internal static class LKGDOEILMLL
{
	[Cpp2IlInjected.Token(Token = "0x6000304")]
	[Cpp2IlInjected.Address(RVA = "0x54536D0", Offset = "0x5451CD0", VA = "0x1854536D0")]
	public static BEAHBKMBHFL MLMCGKJNBJK(this FFCGIONKJBI BMFGKMDOFCF)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000032")]
internal sealed class HMENFJMBNPD : KCCPFAJLCEJ, EBAADMBJLMD
{
	[Cpp2IlInjected.Token(Token = "0x170000CE")]
	public Vector3 GNKPAMJBNBD
	{
		[Cpp2IlInjected.Token(Token = "0x6000306")]
		[Cpp2IlInjected.Address(RVA = "0x5446100", Offset = "0x5444700", VA = "0x185446100", Slot = "4")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000CF")]
	public Vector3 DECHPPBODKH
	{
		[Cpp2IlInjected.Token(Token = "0x6000307")]
		[Cpp2IlInjected.Address(RVA = "0x5445EC0", Offset = "0x54444C0", VA = "0x185445EC0", Slot = "5")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000D0")]
	private Vector3 OMPLHOFEJAN
	{
		[Cpp2IlInjected.Token(Token = "0x600030B")]
		[Cpp2IlInjected.Address(RVA = "0x5446130", Offset = "0x5444730", VA = "0x185446130")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000D1")]
	private FFCGIONKJBI POKCCLODFLP
	{
		[Cpp2IlInjected.Token(Token = "0x600030C")]
		[Cpp2IlInjected.Address(RVA = "0x5445D60", Offset = "0x5444360", VA = "0x185445D60")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000305")]
	[Cpp2IlInjected.Address(RVA = "0x5436210", Offset = "0x5434810", VA = "0x185436210")]
	public HMENFJMBNPD(FFCGIONKJBI FHCKPPNILHO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000308")]
	[Cpp2IlInjected.Address(RVA = "0x54466F0", Offset = "0x5444CF0", VA = "0x1854466F0", Slot = "6")]
	public void KJONOMFBLIP(FFCGIONKJBI LFAIGCEGCPL, object HKLDIENGNNB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000309")]
	[Cpp2IlInjected.Address(RVA = "0x5446880", Offset = "0x5444E80", VA = "0x185446880")]
	private void KJONOMFBLIP(FAEFMAFLNLK LFAIGCEGCPL, object HKLDIENGNNB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600030A")]
	[Cpp2IlInjected.Address(RVA = "0x5446210", Offset = "0x5444810", VA = "0x185446210", Slot = "7")]
	public void GBBOCMNIAIE(object HKLDIENGNNB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600030D")]
	[Cpp2IlInjected.Address(RVA = "0x5446300", Offset = "0x5444900", VA = "0x185446300")]
	private Vector3 JCHOIMFBPCP()
	{
		return default(Vector3);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000033")]
internal static class KEJNAKAPHBH
{
	[Cpp2IlInjected.Token(Token = "0x600030E")]
	[Cpp2IlInjected.Address(RVA = "0x5450CB0", Offset = "0x544F2B0", VA = "0x185450CB0")]
	public static HMENFJMBNPD KMOKGEHBCHJ(this FFCGIONKJBI BMFGKMDOFCF)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000034")]
internal sealed class ICCILKHGIAP : KCCPFAJLCEJ, CHBALODMMNE
{
	[Cpp2IlInjected.Token(Token = "0x170000D2")]
	public Vector3 AAGDOJLDOMM
	{
		[Cpp2IlInjected.Token(Token = "0x6000312")]
		[Cpp2IlInjected.Address(RVA = "0x544CCF0", Offset = "0x544B2F0", VA = "0x18544CCF0", Slot = "6")]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x6000313")]
		[Cpp2IlInjected.Address(RVA = "0x544ABD0", Offset = "0x54491D0", VA = "0x18544ABD0", Slot = "7")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000D3")]
	public Vector3 DJLPMKOMOHI
	{
		[Cpp2IlInjected.Token(Token = "0x6000314")]
		[Cpp2IlInjected.Address(RVA = "0x54498A0", Offset = "0x5447EA0", VA = "0x1854498A0", Slot = "8")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000D4")]
	public float MGOEPMCMEHB
	{
		[Cpp2IlInjected.Token(Token = "0x6000315")]
		[Cpp2IlInjected.Address(RVA = "0x544A280", Offset = "0x5448880", VA = "0x18544A280", Slot = "9")]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x6000316")]
		[Cpp2IlInjected.Address(RVA = "0x544AF30", Offset = "0x5449530", VA = "0x18544AF30")]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000D5")]
	public float OEDNFOGCCII
	{
		[Cpp2IlInjected.Token(Token = "0x6000317")]
		[Cpp2IlInjected.Address(RVA = "0x544AE50", Offset = "0x5449450", VA = "0x18544AE50", Slot = "10")]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x6000318")]
		[Cpp2IlInjected.Address(RVA = "0x544AD10", Offset = "0x5449310", VA = "0x18544AD10", Slot = "11")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000D6")]
	public Vector3 KGPDAOIKKOA
	{
		[Cpp2IlInjected.Token(Token = "0x6000319")]
		[Cpp2IlInjected.Address(RVA = "0x5449840", Offset = "0x5447E40", VA = "0x185449840", Slot = "12")]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x600031A")]
		[Cpp2IlInjected.Address(RVA = "0x5449870", Offset = "0x5447E70", VA = "0x185449870", Slot = "13")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000D7")]
	public Quaternion GADCINNEPIK
	{
		[Cpp2IlInjected.Token(Token = "0x600031B")]
		[Cpp2IlInjected.Address(RVA = "0x544AE20", Offset = "0x5449420", VA = "0x18544AE20", Slot = "14")]
		get
		{
			return default(Quaternion);
		}
		[Cpp2IlInjected.Token(Token = "0x600031C")]
		[Cpp2IlInjected.Address(RVA = "0x544AD20", Offset = "0x5449320", VA = "0x18544AD20", Slot = "15")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000D8")]
	private Rigidbody BKIDAKAFFMP
	{
		[Cpp2IlInjected.Token(Token = "0x6000324")]
		[Cpp2IlInjected.Address(RVA = "0x5440010", Offset = "0x543E610", VA = "0x185440010")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000034")]
	public event HOBHPHAMKBD HHGAGCIOJJG
	{
		[Cpp2IlInjected.Token(Token = "0x600030F")]
		[Cpp2IlInjected.Address(RVA = "0x544C250", Offset = "0x544A850", VA = "0x18544C250", Slot = "4")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000310")]
		[Cpp2IlInjected.Address(RVA = "0x544BF90", Offset = "0x544A590", VA = "0x18544BF90", Slot = "5")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000311")]
	[Cpp2IlInjected.Address(RVA = "0x544CE20", Offset = "0x544B420", VA = "0x18544CE20")]
	public ICCILKHGIAP(FFCGIONKJBI FHCKPPNILHO, in IMECCMKFBII JIHCLPECHIB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600031D")]
	[Cpp2IlInjected.Address(RVA = "0x544A070", Offset = "0x5448670", VA = "0x18544A070", Slot = "17")]
	public void CAALKOKEPPD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600031E")]
	[Cpp2IlInjected.Address(RVA = "0x54499C0", Offset = "0x5447FC0", VA = "0x1854499C0", Slot = "16")]
	public void BANKNELMPFP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600031F")]
	[Cpp2IlInjected.Address(RVA = "0x544C030", Offset = "0x544A630", VA = "0x18544C030", Slot = "19")]
	public void KDPOLAHOOPE(Rigidbody MKOMGOCHBJC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000320")]
	[Cpp2IlInjected.Address(RVA = "0x544A850", Offset = "0x5448E50", VA = "0x18544A850", Slot = "20")]
	public void DIDIIBMEDJD(Rigidbody MKOMGOCHBJC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000321")]
	[Cpp2IlInjected.Address(RVA = "0x544AD40", Offset = "0x5449340", VA = "0x18544AD40", Slot = "18")]
	public void GAANFDFDMKC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000322")]
	[Cpp2IlInjected.Address(RVA = "0x544A360", Offset = "0x5448960", VA = "0x18544A360", Slot = "21")]
	public void DFDCFAGILJM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000323")]
	[Cpp2IlInjected.Address(RVA = "0x5442A40", Offset = "0x5441040", VA = "0x185442A40")]
	public void GHILHKNDAJA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000325")]
	[Cpp2IlInjected.Address(RVA = "0x544ABD0", Offset = "0x54491D0", VA = "0x18544ABD0")]
	private void EDLHINCKBGC(Vector3 MAKFNMHIJIF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000326")]
	[Cpp2IlInjected.Address(RVA = "0x5449F50", Offset = "0x5448550", VA = "0x185449F50")]
	private Vector3 BKOHCPKDCEP()
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000327")]
	[Cpp2IlInjected.Address(RVA = "0x544C960", Offset = "0x544AF60", VA = "0x18544C960")]
	private void NFOOMMJHALN(float MAKFNMHIJIF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000328")]
	[Cpp2IlInjected.Address(RVA = "0x544CB30", Offset = "0x544B130", VA = "0x18544CB30")]
	private void NGBNHFHHKHB(float MAKFNMHIJIF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000329")]
	[Cpp2IlInjected.Address(RVA = "0x544C520", Offset = "0x544AB20", VA = "0x18544C520")]
	private Vector3 MHIHKHCHKBK()
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x600032A")]
	[Cpp2IlInjected.Address(RVA = "0x544C2F0", Offset = "0x544A8F0", VA = "0x18544C2F0")]
	private void MEKMDDFDCDF(Vector3 MAKFNMHIJIF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600032B")]
	[Cpp2IlInjected.Address(RVA = "0x5449D40", Offset = "0x5448340", VA = "0x185449D40")]
	private Quaternion BJFOMIEDANP()
	{
		return default(Quaternion);
	}

	[Cpp2IlInjected.Token(Token = "0x600032C")]
	[Cpp2IlInjected.Address(RVA = "0x544C750", Offset = "0x544AD50", VA = "0x18544C750")]
	private void NBKELJCOCGM(Quaternion MAKFNMHIJIF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600032D")]
	[Cpp2IlInjected.Address(RVA = "0x544AF40", Offset = "0x5449540", VA = "0x18544AF40")]
	internal (float, Vector3) JIKMNOJPHEP(Rigidbody KBIMEMIPFEL)
	{
		return default((float, Vector3));
	}
}
[Cpp2IlInjected.Token(Token = "0x2000035")]
internal static class DDHDAKDHKEI
{
	[Cpp2IlInjected.Token(Token = "0x600032E")]
	[Cpp2IlInjected.Address(RVA = "0x5440DF0", Offset = "0x543F3F0", VA = "0x185440DF0")]
	public static ICCILKHGIAP GEGGBHNBONP(this FFCGIONKJBI BMFGKMDOFCF)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000036")]
internal sealed class CPFELHILEBO : KCCPFAJLCEJ, CMCPDJMPOKN
{
	[Cpp2IlInjected.Token(Token = "0x4000051")]
	private const string PDLLOKAFLJL = "INTERP_PAUSE";

	[Cpp2IlInjected.Token(Token = "0x170000D9")]
	public bool NBDADIFMHHK
	{
		[Cpp2IlInjected.Token(Token = "0x600032F")]
		[Cpp2IlInjected.Address(RVA = "0x543F880", Offset = "0x543DE80", VA = "0x18543F880", Slot = "4")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000DA")]
	public MGONBPIMIEF AIAKBOMPCEL
	{
		[Cpp2IlInjected.Token(Token = "0x6000330")]
		[Cpp2IlInjected.Address(RVA = "0x543FA40", Offset = "0x543E040", VA = "0x18543FA40", Slot = "5")]
		get
		{
			return default(MGONBPIMIEF);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000DB")]
	private MGONBPIMIEF NMCGDNPMDNG
	{
		[Cpp2IlInjected.Token(Token = "0x6000332")]
		[Cpp2IlInjected.Address(RVA = "0x543F960", Offset = "0x543DF60", VA = "0x18543F960")]
		get
		{
			return default(MGONBPIMIEF);
		}
		[Cpp2IlInjected.Token(Token = "0x6000333")]
		[Cpp2IlInjected.Address(RVA = "0x543FBE0", Offset = "0x543E1E0", VA = "0x18543FBE0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000331")]
	[Cpp2IlInjected.Address(RVA = "0x543FEA0", Offset = "0x543E4A0", VA = "0x18543FEA0")]
	public CPFELHILEBO(FFCGIONKJBI FHCKPPNILHO, in IMECCMKFBII JIHCLPECHIB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000334")]
	[Cpp2IlInjected.Address(RVA = "0x543FCD0", Offset = "0x543E2D0", VA = "0x18543FCD0", Slot = "6")]
	public void NOMIHBFFLNG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000335")]
	[Cpp2IlInjected.Address(RVA = "0x543FB40", Offset = "0x543E140", VA = "0x18543FB40")]
	private bool MLCFJHLPAFK()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000336")]
	[Cpp2IlInjected.Address(RVA = "0x543F640", Offset = "0x543DC40", VA = "0x18543F640", Slot = "7")]
	public void FCLIOEABILH(object HKLDIENGNNB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000337")]
	[Cpp2IlInjected.Address(RVA = "0x543F780", Offset = "0x543DD80", VA = "0x18543F780", Slot = "8")]
	public void HFELMDDPCOH(object HKLDIENGNNB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000338")]
	[Cpp2IlInjected.Address(RVA = "0x543FD90", Offset = "0x543E390", VA = "0x18543FD90", Slot = "11")]
	public void OLOGEBHENON()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000339")]
	[Cpp2IlInjected.Address(RVA = "0x543FA50", Offset = "0x543E050", VA = "0x18543FA50")]
	private void MDLEKMKMEOD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600033A")]
	[Cpp2IlInjected.Address(RVA = "0x543F4B0", Offset = "0x543DAB0", VA = "0x18543F4B0")]
	private void BLBJEECBPFI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600033B")]
	[Cpp2IlInjected.Address(RVA = "0x543F600", Offset = "0x543DC00", VA = "0x18543F600", Slot = "10")]
	public void DAHMBDFDEKP(FFCGIONKJBI FHCKPPNILHO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600033C")]
	[Cpp2IlInjected.Address(RVA = "0x543F740", Offset = "0x543DD40", VA = "0x18543F740", Slot = "9")]
	public void GJFLJCFCCKJ(FFCGIONKJBI FHCKPPNILHO)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000037")]
internal sealed class OKDICOADNMH : KCCPFAJLCEJ, MAMDKJFPNFM
{
	[Cpp2IlInjected.Token(Token = "0x170000DC")]
	public bool DEHDGKEMKCA
	{
		[Cpp2IlInjected.Token(Token = "0x600033F")]
		[Cpp2IlInjected.Address(RVA = "0x1CB6720", Offset = "0x1CB4D20", VA = "0x181CB6720", Slot = "6")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000DD")]
	public IEnumerable<object> JCMEBGAMNHL
	{
		[Cpp2IlInjected.Token(Token = "0x6000340")]
		[Cpp2IlInjected.Address(RVA = "0x1CB6250", Offset = "0x1CB4850", VA = "0x181CB6250", Slot = "7")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000DE")]
	private bool EPJKDKDIKNE
	{
		[Cpp2IlInjected.Token(Token = "0x6000341")]
		[Cpp2IlInjected.Address(RVA = "0x1CB67B0", Offset = "0x1CB4DB0", VA = "0x181CB67B0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000035")]
	public event HOBHPHAMKBD EOJIPPCPFCI
	{
		[Cpp2IlInjected.Token(Token = "0x600033D")]
		[Cpp2IlInjected.Address(RVA = "0x1CB6340", Offset = "0x1CB4940", VA = "0x181CB6340", Slot = "4")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600033E")]
		[Cpp2IlInjected.Address(RVA = "0x1CB6610", Offset = "0x1CB4C10", VA = "0x181CB6610", Slot = "5")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000342")]
	[Cpp2IlInjected.Address(RVA = "0x1CB68A0", Offset = "0x1CB4EA0", VA = "0x181CB68A0")]
	public OKDICOADNMH(FFCGIONKJBI FHCKPPNILHO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000343")]
	[Cpp2IlInjected.Address(RVA = "0x1CB65B0", Offset = "0x1CB4BB0", VA = "0x181CB65B0", Slot = "11")]
	public IDisposable IFKNDGBNBEF()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000344")]
	[Cpp2IlInjected.Address(RVA = "0x1CB65A0", Offset = "0x1CB4BA0", VA = "0x181CB65A0", Slot = "8")]
	public void FKOFNEMGINM(object HKLDIENGNNB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000345")]
	[Cpp2IlInjected.Address(RVA = "0x1CB6240", Offset = "0x1CB4840", VA = "0x181CB6240", Slot = "9")]
	public void BEHGOGKEFEN(object HKLDIENGNNB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000346")]
	[Cpp2IlInjected.Address(RVA = "0x1CB6410", Offset = "0x1CB4A10", VA = "0x181CB6410", Slot = "10")]
	public void DLBAIGNALBD(object HKLDIENGNNB, bool BKHDMOGADPG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000347")]
	[Cpp2IlInjected.Address(RVA = "0x1CB66B0", Offset = "0x1CB4CB0", VA = "0x181CB66B0", Slot = "12")]
	public void KDPOLAHOOPE(Rigidbody CCLEKJNADLB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000348")]
	[Cpp2IlInjected.Address(RVA = "0x1CB63E0", Offset = "0x1CB49E0", VA = "0x181CB63E0", Slot = "13")]
	public void DIDIIBMEDJD(Rigidbody MKOMGOCHBJC)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000038")]
internal sealed class CLOGHEEOGJN : KCCPFAJLCEJ, BHMDAAMOACJ, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000054")]
	private PhotonView GJEOCFNIENJ;

	[Cpp2IlInjected.Token(Token = "0x170000DF")]
	public bool BKKAMGPIPMG
	{
		[Cpp2IlInjected.Token(Token = "0x600034B")]
		[Cpp2IlInjected.Address(RVA = "0x543DD90", Offset = "0x543C390", VA = "0x18543DD90", Slot = "6")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000E0")]
	public bool OFHGFFKKEMJ
	{
		[Cpp2IlInjected.Token(Token = "0x600034C")]
		[Cpp2IlInjected.Address(RVA = "0x543DE50", Offset = "0x543C450", VA = "0x18543DE50", Slot = "7")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000036")]
	public event HOBHPHAMKBD IBIGIAONNFK
	{
		[Cpp2IlInjected.Token(Token = "0x6000349")]
		[Cpp2IlInjected.Address(RVA = "0x543DDB0", Offset = "0x543C3B0", VA = "0x18543DDB0", Slot = "4")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600034A")]
		[Cpp2IlInjected.Address(RVA = "0x543DCF0", Offset = "0x543C2F0", VA = "0x18543DCF0", Slot = "5")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600034D")]
	[Cpp2IlInjected.Address(RVA = "0x543E7E0", Offset = "0x543CDE0", VA = "0x18543E7E0")]
	public CLOGHEEOGJN(FFCGIONKJBI FHCKPPNILHO, in IMECCMKFBII JIHCLPECHIB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600034E")]
	[Cpp2IlInjected.Address(RVA = "0x543E530", Offset = "0x543CB30", VA = "0x18543E530", Slot = "8")]
	public void NOMIHBFFLNG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600034F")]
	[Cpp2IlInjected.Address(RVA = "0x543DB00", Offset = "0x543C100", VA = "0x18543DB00", Slot = "11")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000350")]
	[Cpp2IlInjected.Address(RVA = "0x543E130", Offset = "0x543C730", VA = "0x18543E130", Slot = "9")]
	public void MELFMEBHFAF(FFCGIONKJBI LFAIGCEGCPL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000351")]
	[Cpp2IlInjected.Address(RVA = "0x543D8F0", Offset = "0x543BEF0", VA = "0x18543D8F0", Slot = "10")]
	public void BLHLKMFLDGD(FFCGIONKJBI LFAIGCEGCPL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000352")]
	[Cpp2IlInjected.Address(RVA = "0x543E340", Offset = "0x543C940", VA = "0x18543E340")]
	private void NGOCABNBNDE(PhotonView MJGOFLGOOBD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000353")]
	[Cpp2IlInjected.Address(RVA = "0x543E680", Offset = "0x543CC80", VA = "0x18543E680")]
	private void OHFDKKBKPFB(RigidbodyEx NAKLMJNOFNJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000354")]
	[Cpp2IlInjected.Address(RVA = "0x543DF60", Offset = "0x543C560", VA = "0x18543DF60")]
	private void JOPMEJPILKG(PhotonView PAFPMHNEHHP)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000039")]
internal static class GGEMMNDABGL
{
	[Cpp2IlInjected.Token(Token = "0x6000355")]
	[Cpp2IlInjected.Address(RVA = "0x5444C90", Offset = "0x5443290", VA = "0x185444C90")]
	public static CLOGHEEOGJN BEFAHGEGGKH(this NMHAAMBBHKD BMFGKMDOFCF)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200003A")]
internal sealed class CCLHEEOJOIK : KCCPFAJLCEJ, KPBILAHOHAH
{
	[Cpp2IlInjected.Token(Token = "0x170000E1")]
	public bool IELKFNIBHFB
	{
		[Cpp2IlInjected.Token(Token = "0x6000356")]
		[Cpp2IlInjected.Address(RVA = "0x543A310", Offset = "0x5438910", VA = "0x18543A310", Slot = "4")]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000357")]
		[Cpp2IlInjected.Address(RVA = "0x543A5D0", Offset = "0x5438BD0", VA = "0x18543A5D0", Slot = "5")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000E2")]
	public bool FDKFFCJABEN
	{
		[Cpp2IlInjected.Token(Token = "0x6000358")]
		[Cpp2IlInjected.Address(RVA = "0x543A7C0", Offset = "0x5438DC0", VA = "0x18543A7C0", Slot = "6")]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000359")]
		[Cpp2IlInjected.Address(RVA = "0x543A8A0", Offset = "0x5438EA0", VA = "0x18543A8A0")]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000E3")]
	public RigidbodyConstraints AKGJCKADCBH
	{
		[Cpp2IlInjected.Token(Token = "0x600035A")]
		[Cpp2IlInjected.Address(RVA = "0x543A4F0", Offset = "0x5438AF0", VA = "0x18543A4F0", Slot = "7")]
		get
		{
			return default(RigidbodyConstraints);
		}
		[Cpp2IlInjected.Token(Token = "0x600035B")]
		[Cpp2IlInjected.Address(RVA = "0x543A110", Offset = "0x5438710", VA = "0x18543A110", Slot = "8")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600035C")]
	[Cpp2IlInjected.Address(RVA = "0x543A990", Offset = "0x5438F90", VA = "0x18543A990")]
	public CCLHEEOJOIK(FFCGIONKJBI FHCKPPNILHO, in IMECCMKFBII JIHCLPECHIB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600035D")]
	[Cpp2IlInjected.Address(RVA = "0x543A6C0", Offset = "0x5438CC0", VA = "0x18543A6C0", Slot = "9")]
	public void KDPOLAHOOPE(Rigidbody MKOMGOCHBJC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600035E")]
	[Cpp2IlInjected.Address(RVA = "0x543A3F0", Offset = "0x54389F0", VA = "0x18543A3F0", Slot = "10")]
	public void DIDIIBMEDJD(Rigidbody MKOMGOCHBJC)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200003B")]
internal sealed class DDPOLBEBBIP : KCCPFAJLCEJ, EKNFOOIEIBK
{
	[Cpp2IlInjected.Token(Token = "0x170000E4")]
	public float KDAOPIJAMOB
	{
		[Cpp2IlInjected.Token(Token = "0x6000360")]
		[Cpp2IlInjected.Address(RVA = "0x54410C0", Offset = "0x543F6C0", VA = "0x1854410C0", Slot = "4")]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x6000361")]
		[Cpp2IlInjected.Address(RVA = "0x54411A0", Offset = "0x543F7A0", VA = "0x1854411A0", Slot = "5")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000E5")]
	public float FEGLLEJAJOH
	{
		[Cpp2IlInjected.Token(Token = "0x6000362")]
		[Cpp2IlInjected.Address(RVA = "0x54417E0", Offset = "0x543FDE0", VA = "0x1854417E0", Slot = "6")]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x6000363")]
		[Cpp2IlInjected.Address(RVA = "0x5441440", Offset = "0x543FA40", VA = "0x185441440", Slot = "7")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600035F")]
	[Cpp2IlInjected.Address(RVA = "0x5436210", Offset = "0x5434810", VA = "0x185436210")]
	public DDPOLBEBBIP(FFCGIONKJBI FHCKPPNILHO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000364")]
	[Cpp2IlInjected.Address(RVA = "0x5441610", Offset = "0x543FC10", VA = "0x185441610", Slot = "8")]
	public void KDPOLAHOOPE(Rigidbody MKOMGOCHBJC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000365")]
	[Cpp2IlInjected.Address(RVA = "0x5441370", Offset = "0x543F970", VA = "0x185441370", Slot = "9")]
	public void DIDIIBMEDJD(Rigidbody MKOMGOCHBJC)
	{
	}
}
namespace RecRoom.Rbex.ObjectModel
{
	[Cpp2IlInjected.Token(Token = "0x200003C")]
	[DHKIICMHACJ(typeof(JIFLJCNHFKJ), new string[] { })]
	[DAINLFLPADL(OHEDAGNNHJA.Physics)]
	public sealed class RbexServiceCallbacks : GOJCOOFCPOI, JIFLJCNHFKJ, IDisposable
	{
		[Cpp2IlInjected.Token(Token = "0x4000055")]
		private static readonly FGGEJMNNOEE LAEOPKAJMLP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000056")]
		private PJCBAJNDEOE FHCKPPNILHO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000057")]
		private bool LNPMOHBLPOO;

		[Cpp2IlInjected.Token(Token = "0x170000E6")]
		public bool OKJAKPPJFHO
		{
			[Cpp2IlInjected.Token(Token = "0x6000368")]
			[Cpp2IlInjected.Address(RVA = "0x7834A0", Offset = "0x781AA0", VA = "0x1807834A0", Slot = "5")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000366")]
		[Cpp2IlInjected.Address(RVA = "0x1CB7F90", Offset = "0x1CB6590", VA = "0x181CB7F90", Slot = "4")]
		public void NDFJIGFEFMN(PFKGIHKPIGG GOCENLCAMDB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000367")]
		[Cpp2IlInjected.Address(RVA = "0x1CB7CB0", Offset = "0x1CB62B0", VA = "0x181CB7CB0", Slot = "7")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000369")]
		[Cpp2IlInjected.Address(RVA = "0x1CB7CE0", Offset = "0x1CB62E0", VA = "0x181CB7CE0", Slot = "6")]
		public void JIKMNOJPHEP(NIALADIPDNC KLCGNDEDAPD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600036A")]
		[Cpp2IlInjected.Address(RVA = "0x6A82D0", Offset = "0x6A68D0", VA = "0x1806A82D0")]
		public RbexServiceCallbacks()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200003D")]
internal sealed class EMHKLOKAGMK : KCCPFAJLCEJ, MNHBOEHCOIK
{
	[Cpp2IlInjected.Token(Token = "0x4000058")]
	public const int KPHOMKKJGAI = 10;

	[Cpp2IlInjected.Token(Token = "0x4000059")]
	public const float EDBEMPEMOMA = 9E-05f;

	[Cpp2IlInjected.Token(Token = "0x400005A")]
	public const float GGLNEEMIJHI = 0.0001f;

	[Cpp2IlInjected.Token(Token = "0x400005B")]
	public const float HJJLBLIFGJP = 5f;

	[Cpp2IlInjected.Token(Token = "0x170000E7")]
	private Rigidbody BKIDAKAFFMP
	{
		[Cpp2IlInjected.Token(Token = "0x600036E")]
		[Cpp2IlInjected.Address(RVA = "0x5440010", Offset = "0x543E610", VA = "0x185440010")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000E8")]
	private bool IALJHIOHBON
	{
		[Cpp2IlInjected.Token(Token = "0x600036F")]
		[Cpp2IlInjected.Address(RVA = "0x54429A0", Offset = "0x5440FA0", VA = "0x1854429A0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000E9")]
	private bool CEDDMPPAJDO
	{
		[Cpp2IlInjected.Token(Token = "0x6000370")]
		[Cpp2IlInjected.Address(RVA = "0x5434200", Offset = "0x5432800", VA = "0x185434200")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000EA")]
	private FFCGIONKJBI HDIMMFJBNPK
	{
		[Cpp2IlInjected.Token(Token = "0x6000371")]
		[Cpp2IlInjected.Address(RVA = "0x5442470", Offset = "0x5440A70", VA = "0x185442470")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000EB")]
	private bool CAIEJEMCAII
	{
		[Cpp2IlInjected.Token(Token = "0x6000372")]
		[Cpp2IlInjected.Address(RVA = "0x5443250", Offset = "0x5441850", VA = "0x185443250")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000EC")]
	private bool ICIOBCKDGCC
	{
		[Cpp2IlInjected.Token(Token = "0x6000373")]
		[Cpp2IlInjected.Address(RVA = "0x5442A80", Offset = "0x5441080", VA = "0x185442A80")]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000374")]
		[Cpp2IlInjected.Address(RVA = "0x54424D0", Offset = "0x5440AD0", VA = "0x1854424D0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000ED")]
	private bool LGCJELGHLMM
	{
		[Cpp2IlInjected.Token(Token = "0x6000375")]
		[Cpp2IlInjected.Address(RVA = "0x54425C0", Offset = "0x5440BC0", VA = "0x1854425C0")]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000376")]
		[Cpp2IlInjected.Address(RVA = "0x5442B70", Offset = "0x5441170", VA = "0x185442B70")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000EE")]
	private int JMJIFDDFDLJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000377")]
		[Cpp2IlInjected.Address(RVA = "0x5442F30", Offset = "0x5441530", VA = "0x185442F30")]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000378")]
		[Cpp2IlInjected.Address(RVA = "0x5443010", Offset = "0x5441610", VA = "0x185443010")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000037")]
	public event HOBHPHAMKBD IHIJNHOELAG
	{
		[Cpp2IlInjected.Token(Token = "0x600036C")]
		[Cpp2IlInjected.Address(RVA = "0x5442320", Offset = "0x5440920", VA = "0x185442320", Slot = "4")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600036D")]
		[Cpp2IlInjected.Address(RVA = "0x54431B0", Offset = "0x54417B0", VA = "0x1854431B0", Slot = "5")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000379")]
	[Cpp2IlInjected.Address(RVA = "0x54432B0", Offset = "0x54418B0", VA = "0x1854432B0")]
	public EMHKLOKAGMK(FFCGIONKJBI FHCKPPNILHO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600037A")]
	[Cpp2IlInjected.Address(RVA = "0x5443100", Offset = "0x5441700", VA = "0x185443100", Slot = "6")]
	public void NOMIHBFFLNG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600037B")]
	[Cpp2IlInjected.Address(RVA = "0x5442B60", Offset = "0x5441160", VA = "0x185442B60", Slot = "8")]
	public void JPLMLMHPLJA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600037C")]
	[Cpp2IlInjected.Address(RVA = "0x5442D10", Offset = "0x5441310", VA = "0x185442D10", Slot = "7")]
	public bool MNIMMDJAIIP()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600037D")]
	[Cpp2IlInjected.Address(RVA = "0x54423C0", Offset = "0x54409C0", VA = "0x1854423C0", Slot = "9")]
	public void ALKMJGDDHDA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600037E")]
	[Cpp2IlInjected.Address(RVA = "0x5442A40", Offset = "0x5441040", VA = "0x185442A40", Slot = "12")]
	public void HKDHIFCLEOH(bool HBGILCDGAGC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600037F")]
	[Cpp2IlInjected.Address(RVA = "0x5442C60", Offset = "0x5441260", VA = "0x185442C60", Slot = "11")]
	public void LEMLLHIPKGE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000380")]
	[Cpp2IlInjected.Address(RVA = "0x6A8920", Offset = "0x6A6F20", VA = "0x1806A8920", Slot = "10")]
	public void HOBDPIODPAL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000381")]
	[Cpp2IlInjected.Address(RVA = "0x54426A0", Offset = "0x5440CA0", VA = "0x1854426A0")]
	private bool FCFJIFCJPMN()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000382")]
	[Cpp2IlInjected.Address(RVA = "0x5442850", Offset = "0x5440E50", VA = "0x185442850")]
	private void GMGFEAJPFOF()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200003E")]
internal sealed class BDPJCILGMIH : KCCPFAJLCEJ, OOPDNBAAJIE
{
	[Cpp2IlInjected.Token(Token = "0x400005D")]
	private const string NLBEODMOBCK = "RBEX_ANIM";

	[Cpp2IlInjected.Token(Token = "0x170000EF")]
	public Rigidbody BKIDAKAFFMP
	{
		[Cpp2IlInjected.Token(Token = "0x6000383")]
		[Cpp2IlInjected.Address(RVA = "0x5436290", Offset = "0x5434890", VA = "0x185436290", Slot = "4")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000384")]
		[Cpp2IlInjected.Address(RVA = "0x54368F0", Offset = "0x5434EF0", VA = "0x1854368F0")]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000F0")]
	private bool CAIEJEMCAII
	{
		[Cpp2IlInjected.Token(Token = "0x6000385")]
		[Cpp2IlInjected.Address(RVA = "0x5437180", Offset = "0x5435780", VA = "0x185437180")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000386")]
	[Cpp2IlInjected.Address(RVA = "0x54371E0", Offset = "0x54357E0", VA = "0x1854371E0")]
	public BDPJCILGMIH(FFCGIONKJBI FHCKPPNILHO, in IMECCMKFBII JIHCLPECHIB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000387")]
	[Cpp2IlInjected.Address(RVA = "0x54370D0", Offset = "0x54356D0", VA = "0x1854370D0", Slot = "5")]
	public void NOMIHBFFLNG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000388")]
	[Cpp2IlInjected.Address(RVA = "0x54369E0", Offset = "0x5434FE0", VA = "0x1854369E0", Slot = "6")]
	public void HCDCAKONHKH(object HKLDIENGNNB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000389")]
	[Cpp2IlInjected.Address(RVA = "0x5436370", Offset = "0x5434970", VA = "0x185436370", Slot = "7")]
	public void ANODKIPNKGG(object HKLDIENGNNB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600038A")]
	[Cpp2IlInjected.Address(RVA = "0x5436470", Offset = "0x5434A70", VA = "0x185436470", Slot = "8")]
	public void CHKIFMMFIIK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600038B")]
	[Cpp2IlInjected.Address(RVA = "0x5436AE0", Offset = "0x54350E0", VA = "0x185436AE0", Slot = "9")]
	public void JEGLELMGMOF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600038C")]
	[Cpp2IlInjected.Address(RVA = "0x5436F00", Offset = "0x5435500", VA = "0x185436F00", Slot = "10")]
	public void NFMKBGIADML()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600038D")]
	[Cpp2IlInjected.Address(RVA = "0x6A8920", Offset = "0x6A6F20", VA = "0x1806A8920", Slot = "11")]
	public void DHPOOPPINJB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600038E")]
	[Cpp2IlInjected.Address(RVA = "0x5436730", Offset = "0x5434D30", VA = "0x185436730")]
	private void CPKMCFBJNFD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600038F")]
	[Cpp2IlInjected.Address(RVA = "0x5436D40", Offset = "0x5435340", VA = "0x185436D40")]
	private void NDFBDKFJEON()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200003F")]
internal sealed class ACPDPJKCAGM : KCCPFAJLCEJ, GLBLEGFKOKL, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x170000F1")]
	public IIENCNCJIKK OEBLLEKPOOI
	{
		[Cpp2IlInjected.Token(Token = "0x6000390")]
		[Cpp2IlInjected.Address(RVA = "0x5433B90", Offset = "0x5432190", VA = "0x185433B90", Slot = "4")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000391")]
		[Cpp2IlInjected.Address(RVA = "0x54340E0", Offset = "0x54326E0", VA = "0x1854340E0", Slot = "5")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000F2")]
	public JGKAIJBBCDC KPBINMPEPCH
	{
		[Cpp2IlInjected.Token(Token = "0x6000392")]
		[Cpp2IlInjected.Address(RVA = "0x5434FB0", Offset = "0x54335B0", VA = "0x185434FB0", Slot = "6")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000393")]
		[Cpp2IlInjected.Address(RVA = "0x5435E70", Offset = "0x5434470", VA = "0x185435E70", Slot = "7")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000F3")]
	public Vector3 OMPLHOFEJAN
	{
		[Cpp2IlInjected.Token(Token = "0x6000394")]
		[Cpp2IlInjected.Address(RVA = "0x5433CC0", Offset = "0x54322C0", VA = "0x185433CC0", Slot = "8")]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x6000395")]
		[Cpp2IlInjected.Address(RVA = "0x5434740", Offset = "0x5432D40", VA = "0x185434740", Slot = "9")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000F4")]
	public Vector3 BOJDMEIPMAO
	{
		[Cpp2IlInjected.Token(Token = "0x6000396")]
		[Cpp2IlInjected.Address(RVA = "0x54350E0", Offset = "0x54336E0", VA = "0x1854350E0", Slot = "10")]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x6000397")]
		[Cpp2IlInjected.Address(RVA = "0x54341D0", Offset = "0x54327D0", VA = "0x1854341D0", Slot = "11")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000F5")]
	public Vector3 IPICDHHHJOG
	{
		[Cpp2IlInjected.Token(Token = "0x6000398")]
		[Cpp2IlInjected.Address(RVA = "0x54337F0", Offset = "0x5431DF0", VA = "0x1854337F0", Slot = "12")]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x6000399")]
		[Cpp2IlInjected.Address(RVA = "0x5434B80", Offset = "0x5433180", VA = "0x185434B80", Slot = "13")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000F6")]
	public Vector3 DALJIIPOFIE
	{
		[Cpp2IlInjected.Token(Token = "0x600039A")]
		[Cpp2IlInjected.Address(RVA = "0x5432C90", Offset = "0x5431290", VA = "0x185432C90", Slot = "14")]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x600039B")]
		[Cpp2IlInjected.Address(RVA = "0x5432BF0", Offset = "0x54311F0", VA = "0x185432BF0", Slot = "15")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000F7")]
	public float KJKDBCBOHIJ
	{
		[Cpp2IlInjected.Token(Token = "0x600039C")]
		[Cpp2IlInjected.Address(RVA = "0x5432A50", Offset = "0x5431050", VA = "0x185432A50", Slot = "16")]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x600039D")]
		[Cpp2IlInjected.Address(RVA = "0x5435D70", Offset = "0x5434370", VA = "0x185435D70", Slot = "17")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000F8")]
	public bool NKPLDABKJCL
	{
		[Cpp2IlInjected.Token(Token = "0x600039F")]
		[Cpp2IlInjected.Address(RVA = "0x54343F0", Offset = "0x54329F0", VA = "0x1854343F0", Slot = "18")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000F9")]
	private GIGBMEPJFND IPDPPPGBPIC
	{
		[Cpp2IlInjected.Token(Token = "0x60003B3")]
		[Cpp2IlInjected.Address(RVA = "0x2CB3860", Offset = "0x2CB1E60", VA = "0x182CB3860")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000FA")]
	private bool CEDDMPPAJDO
	{
		[Cpp2IlInjected.Token(Token = "0x60003B4")]
		[Cpp2IlInjected.Address(RVA = "0x5434200", Offset = "0x5432800", VA = "0x185434200")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600039E")]
	[Cpp2IlInjected.Address(RVA = "0x5436210", Offset = "0x5434810", VA = "0x185436210")]
	public ACPDPJKCAGM(FFCGIONKJBI FHCKPPNILHO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003A0")]
	[Cpp2IlInjected.Address(RVA = "0x5435D80", Offset = "0x5434380", VA = "0x185435D80", Slot = "20")]
	public void OGEMIEDCOED(object HKLDIENGNNB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003A1")]
	[Cpp2IlInjected.Address(RVA = "0x54353D0", Offset = "0x54339D0", VA = "0x1854353D0", Slot = "31")]
	public void LPJEFBBEPMD(object HKLDIENGNNB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003A2")]
	[Cpp2IlInjected.Address(RVA = "0x5432C20", Offset = "0x5431220", VA = "0x185432C20", Slot = "19")]
	public void NOMIHBFFLNG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003A3")]
	[Cpp2IlInjected.Address(RVA = "0x5433940", Offset = "0x5431F40", VA = "0x185433940", Slot = "37")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003A4")]
	[Cpp2IlInjected.Address(RVA = "0x5434B40", Offset = "0x5433140", VA = "0x185434B40", Slot = "28")]
	public void KDPOLAHOOPE(Rigidbody MKOMGOCHBJC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003A5")]
	[Cpp2IlInjected.Address(RVA = "0x54351F0", Offset = "0x54337F0", VA = "0x1854351F0", Slot = "36")]
	public Vector3 LKOKGKNLODE(Vector3 JMLACAFKJOF)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x60003A6")]
	[Cpp2IlInjected.Address(RVA = "0x5435F60", Offset = "0x5434560", VA = "0x185435F60", Slot = "35")]
	public Vector3 PIFFFCJGHPG(Vector3 OLLLCEPAFHE)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x60003A7")]
	[Cpp2IlInjected.Address(RVA = "0x5432C20", Offset = "0x5431220", VA = "0x185432C20", Slot = "27")]
	public void BCKDLBEFMPH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003A8")]
	[Cpp2IlInjected.Address(RVA = "0x5435D30", Offset = "0x5434330", VA = "0x185435D30", Slot = "25")]
	public void NLLIBPNNBGH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003A9")]
	[Cpp2IlInjected.Address(RVA = "0x5435CF0", Offset = "0x54342F0", VA = "0x185435CF0", Slot = "24")]
	public void NFCJHIFEHGE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003AA")]
	[Cpp2IlInjected.Address(RVA = "0x5434C40", Offset = "0x5433240", VA = "0x185434C40", Slot = "34")]
	public void KPJAOLBLIEI(Vector3 PFDFFPLAJJP, Vector3 HGIFCPKBAGG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003AB")]
	[Cpp2IlInjected.Address(RVA = "0x5433A70", Offset = "0x5432070", VA = "0x185433A70", Slot = "33")]
	public void EBKBGNAGIOD(Vector3 LOGKBIHCFJD, Vector3 OGPMEJLJLFA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003AC")]
	[Cpp2IlInjected.Address(RVA = "0x5433690", Offset = "0x5431C90", VA = "0x185433690", Slot = "32")]
	public void DNAJDFGLENG(Vector3 OANHHGBFKAN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003AD")]
	[Cpp2IlInjected.Address(RVA = "0x5432DB0", Offset = "0x54313B0", VA = "0x185432DB0", Slot = "22")]
	public void CBHLOBJDACM(CKAOOODELAE IKFPEHIFEPN, Vector3 NMBFBKMEJKN, float FEHHFHACKBK, float IOFMPFNPHNC = 8f, float JKLGNKAKKLG = 1f)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003AE")]
	[Cpp2IlInjected.Address(RVA = "0x54354C0", Offset = "0x5433AC0", VA = "0x1854354C0", Slot = "21")]
	public void NCIJALPIGCE(MCMFGEDCCGC LMLMHHPMBJO, Vector3 OFLGCJLDNJJ, float IPAPNFBMGEF = float.PositiveInfinity)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003AF")]
	[Cpp2IlInjected.Address(RVA = "0x5433E10", Offset = "0x5432410", VA = "0x185433E10", Slot = "23")]
	[Obsolete]
	public void FDJHKHJGOHO(MCMFGEDCCGC LMLMHHPMBJO, Vector3 JGCPJBFFFAC, float NMBEKOOKPJA = 7f, float MFBAPHBIEKM = 1f)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003B0")]
	[Cpp2IlInjected.Address(RVA = "0x5432B30", Offset = "0x5431130", VA = "0x185432B30", Slot = "30")]
	public Vector3 AJLBGCPJCKN(Vector3 CPHPLAEKCBK)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x60003B1")]
	[Cpp2IlInjected.Address(RVA = "0x5436120", Offset = "0x5434720", VA = "0x185436120", Slot = "29")]
	public Vector3 PIFNCDNOKAD(Vector3 HOLPFINNOLF)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x60003B2")]
	[Cpp2IlInjected.Address(RVA = "0x5434E80", Offset = "0x5433480", VA = "0x185434E80", Slot = "26")]
	public void LADPNNADDEK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003B5")]
	[Cpp2IlInjected.Address(RVA = "0x5434220", Offset = "0x5432820", VA = "0x185434220")]
	private void GKNBMLJEJOF(float MAKFNMHIJIF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003B6")]
	[Cpp2IlInjected.Address(RVA = "0x54345E0", Offset = "0x5432BE0", VA = "0x1854345E0")]
	private void JEPNOFCGPGB(Vector3 OFLGCJLDNJJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003B7")]
	[Cpp2IlInjected.Address(RVA = "0x54344D0", Offset = "0x5432AD0", VA = "0x1854344D0")]
	private Vector3 JAOHNCJGCMP()
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x60003B8")]
	[Cpp2IlInjected.Address(RVA = "0x5434800", Offset = "0x5432E00", VA = "0x185434800")]
	private void JHJGANJBJGJ(Vector3 OLLLCEPAFHE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003B9")]
	[Cpp2IlInjected.Address(RVA = "0x5433220", Offset = "0x5431820", VA = "0x185433220")]
	private Vector3 CHBOIJCOGNN()
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x60003BA")]
	[Cpp2IlInjected.Address(RVA = "0x5433330", Offset = "0x5431930", VA = "0x185433330")]
	private void DEJPPLEHGBP(Vector3 MAKFNMHIJIF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003BB")]
	[Cpp2IlInjected.Address(RVA = "0x54356F0", Offset = "0x5433CF0", VA = "0x1854356F0")]
	private void NDFOCMJNPHI(Vector3 OLLLCEPAFHE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003BC")]
	[Cpp2IlInjected.Address(RVA = "0x5433AD0", Offset = "0x54320D0", VA = "0x185433AD0")]
	private void EIEPCDLOKOO()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000040")]
internal class KCCPFAJLCEJ
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400005E")]
	protected readonly FAEFMAFLNLK FHCKPPNILHO;

	[Cpp2IlInjected.Token(Token = "0x170000FB")]
	protected PJCBAJNDEOE DMKGOAHIBEA
	{
		[Cpp2IlInjected.Token(Token = "0x60003BD")]
		[Cpp2IlInjected.Address(RVA = "0x166DD30", Offset = "0x166C330", VA = "0x18166DD30")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000FC")]
	protected NIALADIPDNC CDCHGJINIFC
	{
		[Cpp2IlInjected.Token(Token = "0x60003BE")]
		[Cpp2IlInjected.Address(RVA = "0x5450C80", Offset = "0x544F280", VA = "0x185450C80")]
		get
		{
			return default(NIALADIPDNC);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60003BF")]
	[Cpp2IlInjected.Address(RVA = "0x5436210", Offset = "0x5434810", VA = "0x185436210")]
	public KCCPFAJLCEJ(FFCGIONKJBI FHCKPPNILHO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003C0")]
	[Cpp2IlInjected.Address(RVA = "0x5450B60", Offset = "0x544F160", VA = "0x185450B60")]
	protected FFCGIONKJBI FBJEIPCCEHK(NIALADIPDNC EHLCJHMJBBP)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000041")]
public class GONMKKHBNCK : LGNFMEIAMDG
{
	[Cpp2IlInjected.Token(Token = "0x60003C1")]
	[Cpp2IlInjected.Address(RVA = "0x54455C0", Offset = "0x5443BC0", VA = "0x1854455C0", Slot = "4")]
	public IPLGDMEHBOJ JLMEDKOMLPH(FFCGIONKJBI BMFGKMDOFCF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003C2")]
	[Cpp2IlInjected.Address(RVA = "0x54450F0", Offset = "0x54436F0", VA = "0x1854450F0", Slot = "5")]
	public GLBLEGFKOKL FNHIMIMINLC(FFCGIONKJBI BMFGKMDOFCF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003C3")]
	[Cpp2IlInjected.Address(RVA = "0x5445520", Offset = "0x5443B20", VA = "0x185445520", Slot = "6")]
	public EBAADMBJLMD IIOHLMKEJEJ(FFCGIONKJBI BMFGKMDOFCF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003C4")]
	[Cpp2IlInjected.Address(RVA = "0x54457D0", Offset = "0x5443DD0", VA = "0x1854457D0", Slot = "7")]
	public EKNFOOIEIBK NHGIHLGNLLB(FFCGIONKJBI BMFGKMDOFCF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003C5")]
	[Cpp2IlInjected.Address(RVA = "0x5444D60", Offset = "0x5443360", VA = "0x185444D60", Slot = "8")]
	public MNHBOEHCOIK AMEBPOAGMKI(FFCGIONKJBI BMFGKMDOFCF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003C6")]
	[Cpp2IlInjected.Address(RVA = "0x5445050", Offset = "0x5443650", VA = "0x185445050", Slot = "9")]
	public CGKAANMHLMI CCKENOLAJIO(FFCGIONKJBI BMFGKMDOFCF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003C7")]
	[Cpp2IlInjected.Address(RVA = "0x5444DC0", Offset = "0x54433C0", VA = "0x185444DC0", Slot = "10")]
	public MAMDKJFPNFM AOODCJDCKDB(FFCGIONKJBI BMFGKMDOFCF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003C8")]
	[Cpp2IlInjected.Address(RVA = "0x5445480", Offset = "0x5443A80", VA = "0x185445480", Slot = "11")]
	public GIGBMEPJFND IIMNBFJLPGA(FFCGIONKJBI BMFGKMDOFCF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003C9")]
	[Cpp2IlInjected.Address(RVA = "0x5445320", Offset = "0x5443920", VA = "0x185445320", Slot = "12")]
	public MFNEPAJBKBE GLEBFEAEHBH(FFCGIONKJBI BMFGKMDOFCF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003CA")]
	[Cpp2IlInjected.Address(RVA = "0x5444E90", Offset = "0x5443490", VA = "0x185444E90", Slot = "13")]
	public JJPLOLDPKDF BBOIPMMNANN(FFCGIONKJBI BMFGKMDOFCF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003CB")]
	[Cpp2IlInjected.Address(RVA = "0x5445710", Offset = "0x5443D10", VA = "0x185445710")]
	public OOPDNBAAJIE LKGBOKHAFIF(FFCGIONKJBI BMFGKMDOFCF, in IMECCMKFBII JIHCLPECHIB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003CC")]
	[Cpp2IlInjected.Address(RVA = "0x54453C0", Offset = "0x54439C0", VA = "0x1854453C0")]
	public BHMDAAMOACJ GLKJADAGIAD(FFCGIONKJBI BMFGKMDOFCF, in IMECCMKFBII JIHCLPECHIB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003CD")]
	[Cpp2IlInjected.Address(RVA = "0x5445190", Offset = "0x5443790", VA = "0x185445190")]
	public CMCPDJMPOKN FOJJLIDIPCI(FFCGIONKJBI BMFGKMDOFCF, in IMECCMKFBII JIHCLPECHIB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003CE")]
	[Cpp2IlInjected.Address(RVA = "0x5444CF0", Offset = "0x54432F0", VA = "0x185444CF0")]
	public CHBALODMMNE GLGIJKKAPGN(FFCGIONKJBI BMFGKMDOFCF, in IMECCMKFBII JIHCLPECHIB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003CF")]
	[Cpp2IlInjected.Address(RVA = "0x5444E20", Offset = "0x5443420", VA = "0x185444E20")]
	public KPBILAHOHAH ODODIKBAKJK(FFCGIONKJBI BMFGKMDOFCF, in IMECCMKFBII JIHCLPECHIB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003D0")]
	[Cpp2IlInjected.Address(RVA = "0x5444F30", Offset = "0x5443530", VA = "0x185444F30", Slot = "19")]
	public FFCGIONKJBI CAKONGBGLCH(RigidbodyEx FHCKPPNILHO, IMECCMKFBII JIHCLPECHIB, MPHIHDCLPDB HKMONJIHHIH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003D1")]
	[Cpp2IlInjected.Address(RVA = "0x6A82D0", Offset = "0x6A68D0", VA = "0x1806A82D0")]
	public GONMKKHBNCK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003D2")]
	[Cpp2IlInjected.Address(RVA = "0x5445710", Offset = "0x5443D10", VA = "0x185445710", Slot = "14")]
	private OOPDNBAAJIE KGODCDCCGDL(FFCGIONKJBI BMFGKMDOFCF, in IMECCMKFBII JIHCLPECHIB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003D3")]
	[Cpp2IlInjected.Address(RVA = "0x54453C0", Offset = "0x54439C0", VA = "0x1854453C0", Slot = "15")]
	private BHMDAAMOACJ PJPJIFJAEAJ(FFCGIONKJBI BMFGKMDOFCF, in IMECCMKFBII JIHCLPECHIB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003D4")]
	[Cpp2IlInjected.Address(RVA = "0x5445190", Offset = "0x5443790", VA = "0x185445190", Slot = "16")]
	private CMCPDJMPOKN IHLIJBJMJOL(FFCGIONKJBI BMFGKMDOFCF, in IMECCMKFBII JIHCLPECHIB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003D5")]
	[Cpp2IlInjected.Address(RVA = "0x5444CF0", Offset = "0x54432F0", VA = "0x185444CF0", Slot = "17")]
	private CHBALODMMNE AHPBLOONHKN(FFCGIONKJBI BMFGKMDOFCF, in IMECCMKFBII JIHCLPECHIB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003D6")]
	[Cpp2IlInjected.Address(RVA = "0x5444E20", Offset = "0x5443420", VA = "0x185444E20", Slot = "18")]
	private KPBILAHOHAH APMCPBGPIFH(FFCGIONKJBI BMFGKMDOFCF, in IMECCMKFBII JIHCLPECHIB)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000042")]
[DefaultMember("Item")]
public sealed class PBMBFCMPFNE : IReadOnlyList<FFCGIONKJBI>, IEnumerable<FFCGIONKJBI>, IEnumerable, IReadOnlyCollection<FFCGIONKJBI>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400005F")]
	public readonly NIALADIPDNC EHLCJHMJBBP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000060")]
	public readonly PJCBAJNDEOE AGMOENMHCDB;

	[Cpp2IlInjected.Token(Token = "0x170000FD")]
	public int ICNBMEOIEJL
	{
		[Cpp2IlInjected.Token(Token = "0x60003DA")]
		[Cpp2IlInjected.Address(RVA = "0x1CB7310", Offset = "0x1CB5910", VA = "0x181CB7310", Slot = "5")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000FE")]
	public FFCGIONKJBI EAAIOELEIIM
	{
		[Cpp2IlInjected.Token(Token = "0x60003DB")]
		[Cpp2IlInjected.Address(RVA = "0x1CB73E0", Offset = "0x1CB59E0", VA = "0x181CB73E0", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60003D7")]
	[Cpp2IlInjected.Address(RVA = "0x1CB72C0", Offset = "0x1CB58C0", VA = "0x181CB72C0")]
	public PBMBFCMPFNE(NIALADIPDNC EHLCJHMJBBP, PJCBAJNDEOE AGMOENMHCDB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003D8")]
	[Cpp2IlInjected.Address(RVA = "0x1CB7130", Offset = "0x1CB5730", VA = "0x181CB7130", Slot = "6")]
	public IEnumerator<FFCGIONKJBI> GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003D9")]
	[Cpp2IlInjected.Address(RVA = "0x1CB7130", Offset = "0x1CB5730", VA = "0x181CB7130", Slot = "7")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003DC")]
	[Cpp2IlInjected.Address(RVA = "0x1CB7120", Offset = "0x1CB5720", VA = "0x181CB7120")]
	[CompilerGenerated]
	private FFCGIONKJBI CBEMGPEJDDN(int LJOFAPCHBHE)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000043")]
[DHKIICMHACJ(typeof(LGNFMEIAMDG), new string[] { })]
public class JGHLLDIPGHD : LGNFMEIAMDG, GOJCOOFCPOI
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000061")]
	private readonly LGNFMEIAMDG MHEDDELAMEM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000062")]
	private readonly LGNFMEIAMDG IJJOMIGFFLF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000063")]
	private PCJLBILJHMN NBBMAFFHAAA;

	[Cpp2IlInjected.Token(Token = "0x170000FF")]
	private LGNFMEIAMDG AAIBAGIBCOG
	{
		[Cpp2IlInjected.Token(Token = "0x60003DE")]
		[Cpp2IlInjected.Address(RVA = "0x5450820", Offset = "0x544EE20", VA = "0x185450820")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60003DD")]
	[Cpp2IlInjected.Address(RVA = "0x54509D0", Offset = "0x544EFD0", VA = "0x1854509D0", Slot = "20")]
	public void NDFJIGFEFMN(PFKGIHKPIGG GOCENLCAMDB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003DF")]
	[Cpp2IlInjected.Address(RVA = "0x5450880", Offset = "0x544EE80", VA = "0x185450880", Slot = "4")]
	public IPLGDMEHBOJ JLMEDKOMLPH(FFCGIONKJBI BMFGKMDOFCF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003E0")]
	[Cpp2IlInjected.Address(RVA = "0x5450440", Offset = "0x544EA40", VA = "0x185450440", Slot = "5")]
	public GLBLEGFKOKL FNHIMIMINLC(FFCGIONKJBI BMFGKMDOFCF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003E1")]
	[Cpp2IlInjected.Address(RVA = "0x5450780", Offset = "0x544ED80", VA = "0x185450780", Slot = "6")]
	public EBAADMBJLMD IIOHLMKEJEJ(FFCGIONKJBI BMFGKMDOFCF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003E2")]
	[Cpp2IlInjected.Address(RVA = "0x5450A20", Offset = "0x544F020", VA = "0x185450A20", Slot = "7")]
	public EKNFOOIEIBK NHGIHLGNLLB(FFCGIONKJBI BMFGKMDOFCF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003E3")]
	[Cpp2IlInjected.Address(RVA = "0x5450020", Offset = "0x544E620", VA = "0x185450020", Slot = "8")]
	public MNHBOEHCOIK AMEBPOAGMKI(FFCGIONKJBI BMFGKMDOFCF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003E4")]
	[Cpp2IlInjected.Address(RVA = "0x54503A0", Offset = "0x544E9A0", VA = "0x1854503A0", Slot = "9")]
	public CGKAANMHLMI CCKENOLAJIO(FFCGIONKJBI BMFGKMDOFCF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003E5")]
	[Cpp2IlInjected.Address(RVA = "0x54500C0", Offset = "0x544E6C0", VA = "0x1854500C0", Slot = "10")]
	public MAMDKJFPNFM AOODCJDCKDB(FFCGIONKJBI BMFGKMDOFCF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003E6")]
	[Cpp2IlInjected.Address(RVA = "0x54506E0", Offset = "0x544ECE0", VA = "0x1854506E0", Slot = "11")]
	public GIGBMEPJFND IIMNBFJLPGA(FFCGIONKJBI BMFGKMDOFCF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003E7")]
	[Cpp2IlInjected.Address(RVA = "0x5450590", Offset = "0x544EB90", VA = "0x185450590", Slot = "12")]
	public MFNEPAJBKBE GLEBFEAEHBH(FFCGIONKJBI BMFGKMDOFCF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003E8")]
	[Cpp2IlInjected.Address(RVA = "0x5450210", Offset = "0x544E810", VA = "0x185450210", Slot = "13")]
	public JJPLOLDPKDF BBOIPMMNANN(FFCGIONKJBI BMFGKMDOFCF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003E9")]
	[Cpp2IlInjected.Address(RVA = "0x5450920", Offset = "0x544EF20", VA = "0x185450920")]
	public OOPDNBAAJIE LKGBOKHAFIF(FFCGIONKJBI BMFGKMDOFCF, in IMECCMKFBII JIHCLPECHIB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003EA")]
	[Cpp2IlInjected.Address(RVA = "0x5450630", Offset = "0x544EC30", VA = "0x185450630")]
	public BHMDAAMOACJ GLKJADAGIAD(FFCGIONKJBI BMFGKMDOFCF, in IMECCMKFBII JIHCLPECHIB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003EB")]
	[Cpp2IlInjected.Address(RVA = "0x54504E0", Offset = "0x544EAE0", VA = "0x1854504E0")]
	public CMCPDJMPOKN FOJJLIDIPCI(FFCGIONKJBI BMFGKMDOFCF, in IMECCMKFBII JIHCLPECHIB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003EC")]
	[Cpp2IlInjected.Address(RVA = "0x544FF70", Offset = "0x544E570", VA = "0x18544FF70")]
	public CHBALODMMNE GLGIJKKAPGN(FFCGIONKJBI BMFGKMDOFCF, in IMECCMKFBII JIHCLPECHIB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003ED")]
	[Cpp2IlInjected.Address(RVA = "0x5450160", Offset = "0x544E760", VA = "0x185450160")]
	public KPBILAHOHAH ODODIKBAKJK(FFCGIONKJBI BMFGKMDOFCF, in IMECCMKFBII JIHCLPECHIB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003EE")]
	[Cpp2IlInjected.Address(RVA = "0x54502B0", Offset = "0x544E8B0", VA = "0x1854502B0", Slot = "19")]
	public FFCGIONKJBI CAKONGBGLCH(RigidbodyEx FHCKPPNILHO, IMECCMKFBII JIHCLPECHIB, MPHIHDCLPDB HKMONJIHHIH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003EF")]
	[Cpp2IlInjected.Address(RVA = "0x5450AC0", Offset = "0x544F0C0", VA = "0x185450AC0")]
	public JGHLLDIPGHD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003F0")]
	[Cpp2IlInjected.Address(RVA = "0x5450920", Offset = "0x544EF20", VA = "0x185450920", Slot = "14")]
	private OOPDNBAAJIE KGODCDCCGDL(FFCGIONKJBI BMFGKMDOFCF, in IMECCMKFBII JIHCLPECHIB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003F1")]
	[Cpp2IlInjected.Address(RVA = "0x5450630", Offset = "0x544EC30", VA = "0x185450630", Slot = "15")]
	private BHMDAAMOACJ PJPJIFJAEAJ(FFCGIONKJBI BMFGKMDOFCF, in IMECCMKFBII JIHCLPECHIB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003F2")]
	[Cpp2IlInjected.Address(RVA = "0x54504E0", Offset = "0x544EAE0", VA = "0x1854504E0", Slot = "16")]
	private CMCPDJMPOKN IHLIJBJMJOL(FFCGIONKJBI BMFGKMDOFCF, in IMECCMKFBII JIHCLPECHIB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003F3")]
	[Cpp2IlInjected.Address(RVA = "0x544FF70", Offset = "0x544E570", VA = "0x18544FF70", Slot = "17")]
	private CHBALODMMNE AHPBLOONHKN(FFCGIONKJBI BMFGKMDOFCF, in IMECCMKFBII JIHCLPECHIB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003F4")]
	[Cpp2IlInjected.Address(RVA = "0x5450160", Offset = "0x544E760", VA = "0x185450160", Slot = "18")]
	private KPBILAHOHAH APMCPBGPIFH(FFCGIONKJBI BMFGKMDOFCF, in IMECCMKFBII JIHCLPECHIB)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000044")]
[Preserve]
public sealed class MKNGOFHDHJF : FFCGIONKJBI, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x4000064")]
	public static readonly MKNGOFHDHJF LOGBPMLPMIM;

	[Cpp2IlInjected.Token(Token = "0x17000100")]
	public Rigidbody BKIDAKAFFMP
	{
		[Cpp2IlInjected.Token(Token = "0x6000407")]
		[Cpp2IlInjected.Address(RVA = "0x6BA620", Offset = "0x6B8C20", VA = "0x1806BA620", Slot = "4")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000101")]
	public RigidbodyEx MDFBJOGOGGI
	{
		[Cpp2IlInjected.Token(Token = "0x6000408")]
		[Cpp2IlInjected.Address(RVA = "0x706850", Offset = "0x704E50", VA = "0x180706850", Slot = "5")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000102")]
	public GameObject LPLGJEFNKNH
	{
		[Cpp2IlInjected.Token(Token = "0x6000409")]
		[Cpp2IlInjected.Address(RVA = "0x706620", Offset = "0x704C20", VA = "0x180706620", Slot = "6")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000103")]
	public Transform DACDPJCIAKE
	{
		[Cpp2IlInjected.Token(Token = "0x600040A")]
		[Cpp2IlInjected.Address(RVA = "0x681C00", Offset = "0x680200", VA = "0x180681C00", Slot = "7")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000104")]
	public IEnumerable<object> CMDPIDMOANK
	{
		[Cpp2IlInjected.Token(Token = "0x600040B")]
		[Cpp2IlInjected.Address(RVA = "0x67A0D0", Offset = "0x6786D0", VA = "0x18067A0D0", Slot = "8")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000105")]
	public FFCGIONKJBI HDIMMFJBNPK
	{
		[Cpp2IlInjected.Token(Token = "0x600040C")]
		[Cpp2IlInjected.Address(RVA = "0x679E00", Offset = "0x678400", VA = "0x180679E00", Slot = "9")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600040D")]
		[Cpp2IlInjected.Address(RVA = "0x722690", Offset = "0x720C90", VA = "0x180722690", Slot = "10")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000106")]
	public IReadOnlyList<FFCGIONKJBI> KEPEEEPLAGJ
	{
		[Cpp2IlInjected.Token(Token = "0x600040E")]
		[Cpp2IlInjected.Address(RVA = "0x684420", Offset = "0x682A20", VA = "0x180684420", Slot = "11")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000107")]
	public FFCGIONKJBI AMKPOIHFDKH
	{
		[Cpp2IlInjected.Token(Token = "0x600040F")]
		[Cpp2IlInjected.Address(RVA = "0x694B00", Offset = "0x693100", VA = "0x180694B00", Slot = "12")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000108")]
	public bool CAIEJEMCAII
	{
		[Cpp2IlInjected.Token(Token = "0x6000410")]
		[Cpp2IlInjected.Address(RVA = "0x8ADED0", Offset = "0x8AC4D0", VA = "0x1808ADED0", Slot = "13")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000109")]
	public bool BKKAMGPIPMG
	{
		[Cpp2IlInjected.Token(Token = "0x6000411")]
		[Cpp2IlInjected.Address(RVA = "0x722510", Offset = "0x720B10", VA = "0x180722510", Slot = "14")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700010A")]
	public bool OFHGFFKKEMJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000412")]
		[Cpp2IlInjected.Address(RVA = "0x1156030", Offset = "0x1154630", VA = "0x181156030", Slot = "15")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700010B")]
	public IIENCNCJIKK OEBLLEKPOOI
	{
		[Cpp2IlInjected.Token(Token = "0x6000413")]
		[Cpp2IlInjected.Address(RVA = "0x683BB0", Offset = "0x6821B0", VA = "0x180683BB0", Slot = "16")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000414")]
		[Cpp2IlInjected.Address(RVA = "0x817260", Offset = "0x815860", VA = "0x180817260", Slot = "17")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700010C")]
	public JGKAIJBBCDC KPBINMPEPCH
	{
		[Cpp2IlInjected.Token(Token = "0x6000415")]
		[Cpp2IlInjected.Address(RVA = "0x810200", Offset = "0x80E800", VA = "0x180810200", Slot = "18")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000416")]
		[Cpp2IlInjected.Address(RVA = "0x753B10", Offset = "0x752110", VA = "0x180753B10", Slot = "19")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700010D")]
	public float KJKDBCBOHIJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000417")]
		[Cpp2IlInjected.Address(RVA = "0x237DE40", Offset = "0x237C440", VA = "0x18237DE40", Slot = "20")]
		[CompilerGenerated]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x6000418")]
		[Cpp2IlInjected.Address(RVA = "0x17DF050", Offset = "0x17DD650", VA = "0x1817DF050", Slot = "21")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700010E")]
	public Vector3 BOJDMEIPMAO
	{
		[Cpp2IlInjected.Token(Token = "0x6000419")]
		[Cpp2IlInjected.Address(RVA = "0x427A1E0", Offset = "0x42787E0", VA = "0x18427A1E0", Slot = "22")]
		[CompilerGenerated]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x600041A")]
		[Cpp2IlInjected.Address(RVA = "0x427A0F0", Offset = "0x42786F0", VA = "0x18427A0F0", Slot = "23")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700010F")]
	public Vector3 DALJIIPOFIE
	{
		[Cpp2IlInjected.Token(Token = "0x600041B")]
		[Cpp2IlInjected.Address(RVA = "0x27DDA40", Offset = "0x27DC040", VA = "0x1827DDA40", Slot = "24")]
		[CompilerGenerated]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x600041C")]
		[Cpp2IlInjected.Address(RVA = "0x27DACF0", Offset = "0x27D92F0", VA = "0x1827DACF0", Slot = "25")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000110")]
	public Vector3 OMPLHOFEJAN
	{
		[Cpp2IlInjected.Token(Token = "0x600041D")]
		[Cpp2IlInjected.Address(RVA = "0x27DDA60", Offset = "0x27DC060", VA = "0x1827DDA60", Slot = "26")]
		[CompilerGenerated]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x600041E")]
		[Cpp2IlInjected.Address(RVA = "0x27DC700", Offset = "0x27DAD00", VA = "0x1827DC700", Slot = "27")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000111")]
	public Vector3 IPICDHHHJOG
	{
		[Cpp2IlInjected.Token(Token = "0x600041F")]
		[Cpp2IlInjected.Address(RVA = "0x682700", Offset = "0x680D00", VA = "0x180682700", Slot = "28")]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x6000420")]
		[Cpp2IlInjected.Address(RVA = "0x6A8920", Offset = "0x6A6F20", VA = "0x1806A8920", Slot = "29")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000112")]
	public bool KENDHOCAHBA
	{
		[Cpp2IlInjected.Token(Token = "0x6000421")]
		[Cpp2IlInjected.Address(RVA = "0x9B27E0", Offset = "0x9B0DE0", VA = "0x1809B27E0", Slot = "30")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000113")]
	public bool EHJFPLNBAAH
	{
		[Cpp2IlInjected.Token(Token = "0x6000422")]
		[Cpp2IlInjected.Address(RVA = "0xE9D8C0", Offset = "0xE9BEC0", VA = "0x180E9D8C0", Slot = "31")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000114")]
	public bool PLHBBEKOBGN
	{
		[Cpp2IlInjected.Token(Token = "0x6000423")]
		[Cpp2IlInjected.Address(RVA = "0xE9D8B0", Offset = "0xE9BEB0", VA = "0x180E9D8B0", Slot = "32")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000115")]
	public bool NKPLDABKJCL
	{
		[Cpp2IlInjected.Token(Token = "0x6000424")]
		[Cpp2IlInjected.Address(RVA = "0x13AEB30", Offset = "0x13AD130", VA = "0x1813AEB30", Slot = "33")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000116")]
	public Vector3 GNKPAMJBNBD
	{
		[Cpp2IlInjected.Token(Token = "0x6000425")]
		[Cpp2IlInjected.Address(RVA = "0x148CDC0", Offset = "0x148B3C0", VA = "0x18148CDC0", Slot = "34")]
		[CompilerGenerated]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000117")]
	public Vector3 DECHPPBODKH
	{
		[Cpp2IlInjected.Token(Token = "0x6000426")]
		[Cpp2IlInjected.Address(RVA = "0x1541420", Offset = "0x153FA20", VA = "0x181541420", Slot = "35")]
		[CompilerGenerated]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000118")]
	public Vector3 AAGDOJLDOMM
	{
		[Cpp2IlInjected.Token(Token = "0x6000427")]
		[Cpp2IlInjected.Address(RVA = "0x682700", Offset = "0x680D00", VA = "0x180682700", Slot = "36")]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x6000428")]
		[Cpp2IlInjected.Address(RVA = "0x6A8920", Offset = "0x6A6F20", VA = "0x1806A8920", Slot = "37")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000119")]
	public Vector3 DJLPMKOMOHI
	{
		[Cpp2IlInjected.Token(Token = "0x6000429")]
		[Cpp2IlInjected.Address(RVA = "0x27DDB20", Offset = "0x27DC120", VA = "0x1827DDB20", Slot = "38")]
		[CompilerGenerated]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700011A")]
	public float MGOEPMCMEHB
	{
		[Cpp2IlInjected.Token(Token = "0x600042A")]
		[Cpp2IlInjected.Address(RVA = "0x824540", Offset = "0x822B40", VA = "0x180824540", Slot = "39")]
		[CompilerGenerated]
		get
		{
			return default(float);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700011B")]
	public float OEDNFOGCCII
	{
		[Cpp2IlInjected.Token(Token = "0x600042B")]
		[Cpp2IlInjected.Address(RVA = "0x9FB070", Offset = "0x9F9670", VA = "0x1809FB070", Slot = "40")]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x600042C")]
		[Cpp2IlInjected.Address(RVA = "0x6A8920", Offset = "0x6A6F20", VA = "0x1806A8920", Slot = "41")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700011C")]
	public Vector3 KGPDAOIKKOA
	{
		[Cpp2IlInjected.Token(Token = "0x600042D")]
		[Cpp2IlInjected.Address(RVA = "0x682700", Offset = "0x680D00", VA = "0x180682700", Slot = "42")]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x600042E")]
		[Cpp2IlInjected.Address(RVA = "0x6A8920", Offset = "0x6A6F20", VA = "0x1806A8920", Slot = "43")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700011D")]
	public Quaternion GADCINNEPIK
	{
		[Cpp2IlInjected.Token(Token = "0x600042F")]
		[Cpp2IlInjected.Address(RVA = "0x6851F0", Offset = "0x6837F0", VA = "0x1806851F0", Slot = "44")]
		get
		{
			return default(Quaternion);
		}
		[Cpp2IlInjected.Token(Token = "0x6000430")]
		[Cpp2IlInjected.Address(RVA = "0x6A8920", Offset = "0x6A6F20", VA = "0x1806A8920", Slot = "45")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700011E")]
	public float KDAOPIJAMOB
	{
		[Cpp2IlInjected.Token(Token = "0x6000431")]
		[Cpp2IlInjected.Address(RVA = "0x9FB070", Offset = "0x9F9670", VA = "0x1809FB070", Slot = "46")]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x6000432")]
		[Cpp2IlInjected.Address(RVA = "0x6A8920", Offset = "0x6A6F20", VA = "0x1806A8920", Slot = "47")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700011F")]
	public float FEGLLEJAJOH
	{
		[Cpp2IlInjected.Token(Token = "0x6000433")]
		[Cpp2IlInjected.Address(RVA = "0x9FB070", Offset = "0x9F9670", VA = "0x1809FB070", Slot = "48")]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x6000434")]
		[Cpp2IlInjected.Address(RVA = "0x6A8920", Offset = "0x6A6F20", VA = "0x1806A8920", Slot = "49")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000120")]
	public bool HGEMBEONDNJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000435")]
		[Cpp2IlInjected.Address(RVA = "0x677260", Offset = "0x675860", VA = "0x180677260", Slot = "50")]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000436")]
		[Cpp2IlInjected.Address(RVA = "0x6A8920", Offset = "0x6A6F20", VA = "0x1806A8920", Slot = "51")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000121")]
	public bool JMKHFLEOLCK
	{
		[Cpp2IlInjected.Token(Token = "0x6000437")]
		[Cpp2IlInjected.Address(RVA = "0x677260", Offset = "0x675860", VA = "0x180677260")]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000438")]
		[Cpp2IlInjected.Address(RVA = "0x6A8920", Offset = "0x6A6F20", VA = "0x1806A8920")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000122")]
	public CKHEJONCKGK GGJLBGDDKGJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000439")]
		[Cpp2IlInjected.Address(RVA = "0x677260", Offset = "0x675860", VA = "0x180677260", Slot = "52")]
		get
		{
			return default(CKHEJONCKGK);
		}
		[Cpp2IlInjected.Token(Token = "0x600043A")]
		[Cpp2IlInjected.Address(RVA = "0x6A8920", Offset = "0x6A6F20", VA = "0x1806A8920", Slot = "53")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000123")]
	public bool DEHDGKEMKCA
	{
		[Cpp2IlInjected.Token(Token = "0x600043B")]
		[Cpp2IlInjected.Address(RVA = "0x1262370", Offset = "0x1260970", VA = "0x181262370", Slot = "54")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000124")]
	public Transform DPCGIDOBNGL
	{
		[Cpp2IlInjected.Token(Token = "0x600043C")]
		[Cpp2IlInjected.Address(RVA = "0x74FC30", Offset = "0x74E230", VA = "0x18074FC30", Slot = "55")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000125")]
	public Transform EAILDMMFMIE
	{
		[Cpp2IlInjected.Token(Token = "0x600043D")]
		[Cpp2IlInjected.Address(RVA = "0x828910", Offset = "0x826F10", VA = "0x180828910", Slot = "56")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000126")]
	public Vector3 HAPPDNNLGPN
	{
		[Cpp2IlInjected.Token(Token = "0x600043E")]
		[Cpp2IlInjected.Address(RVA = "0x682700", Offset = "0x680D00", VA = "0x180682700", Slot = "57")]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x600043F")]
		[Cpp2IlInjected.Address(RVA = "0x6A8920", Offset = "0x6A6F20", VA = "0x1806A8920", Slot = "58")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000127")]
	public float MAFJLHAELCE
	{
		[Cpp2IlInjected.Token(Token = "0x6000440")]
		[Cpp2IlInjected.Address(RVA = "0x9FB070", Offset = "0x9F9670", VA = "0x1809FB070", Slot = "59")]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x6000441")]
		[Cpp2IlInjected.Address(RVA = "0x6A8920", Offset = "0x6A6F20", VA = "0x1806A8920", Slot = "60")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000128")]
	public float EEAGMHLGCPI
	{
		[Cpp2IlInjected.Token(Token = "0x6000442")]
		[Cpp2IlInjected.Address(RVA = "0x9FB070", Offset = "0x9F9670", VA = "0x1809FB070", Slot = "61")]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x6000443")]
		[Cpp2IlInjected.Address(RVA = "0x6A8920", Offset = "0x6A6F20", VA = "0x1806A8920", Slot = "62")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000129")]
	public Quaternion BDIPPGABHED
	{
		[Cpp2IlInjected.Token(Token = "0x6000444")]
		[Cpp2IlInjected.Address(RVA = "0x1F9C610", Offset = "0x1F9AC10", VA = "0x181F9C610", Slot = "63")]
		get
		{
			return default(Quaternion);
		}
		[Cpp2IlInjected.Token(Token = "0x6000445")]
		[Cpp2IlInjected.Address(RVA = "0x6A8920", Offset = "0x6A6F20", VA = "0x1806A8920", Slot = "64")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700012A")]
	public Vector3 MLJGHHMBALO
	{
		[Cpp2IlInjected.Token(Token = "0x6000446")]
		[Cpp2IlInjected.Address(RVA = "0x682700", Offset = "0x680D00", VA = "0x180682700", Slot = "65")]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x6000447")]
		[Cpp2IlInjected.Address(RVA = "0x6A8920", Offset = "0x6A6F20", VA = "0x1806A8920", Slot = "66")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700012B")]
	public Quaternion ADAPJGEEEOL
	{
		[Cpp2IlInjected.Token(Token = "0x6000448")]
		[Cpp2IlInjected.Address(RVA = "0x1F9C610", Offset = "0x1F9AC10", VA = "0x181F9C610", Slot = "67")]
		get
		{
			return default(Quaternion);
		}
		[Cpp2IlInjected.Token(Token = "0x6000449")]
		[Cpp2IlInjected.Address(RVA = "0x6A8920", Offset = "0x6A6F20", VA = "0x1806A8920", Slot = "68")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700012C")]
	public RigidbodyConstraints AKGJCKADCBH
	{
		[Cpp2IlInjected.Token(Token = "0x600044A")]
		[Cpp2IlInjected.Address(RVA = "0x677290", Offset = "0x675890", VA = "0x180677290", Slot = "69")]
		get
		{
			return default(RigidbodyConstraints);
		}
		[Cpp2IlInjected.Token(Token = "0x600044B")]
		[Cpp2IlInjected.Address(RVA = "0x6A8920", Offset = "0x6A6F20", VA = "0x1806A8920", Slot = "70")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700012D")]
	public bool IELKFNIBHFB
	{
		[Cpp2IlInjected.Token(Token = "0x600044C")]
		[Cpp2IlInjected.Address(RVA = "0x677260", Offset = "0x675860", VA = "0x180677260", Slot = "71")]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x600044D")]
		[Cpp2IlInjected.Address(RVA = "0x6A8920", Offset = "0x6A6F20", VA = "0x1806A8920", Slot = "72")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700012E")]
	public CollisionDetectionMode GDCFMCCNNGL
	{
		[Cpp2IlInjected.Token(Token = "0x600044E")]
		[Cpp2IlInjected.Address(RVA = "0x677290", Offset = "0x675890", VA = "0x180677290", Slot = "73")]
		get
		{
			return default(CollisionDetectionMode);
		}
		[Cpp2IlInjected.Token(Token = "0x600044F")]
		[Cpp2IlInjected.Address(RVA = "0x6A8920", Offset = "0x6A6F20", VA = "0x1806A8920", Slot = "74")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700012F")]
	public bool CEDDMPPAJDO
	{
		[Cpp2IlInjected.Token(Token = "0x6000450")]
		[Cpp2IlInjected.Address(RVA = "0x828DA0", Offset = "0x8273A0", VA = "0x180828DA0", Slot = "75")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000038")]
	public event HOBHPHAMKBD IAOFFICNEFM
	{
		[Cpp2IlInjected.Token(Token = "0x60003F5")]
		[Cpp2IlInjected.Address(RVA = "0x6A8920", Offset = "0x6A6F20", VA = "0x1806A8920", Slot = "81")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60003F6")]
		[Cpp2IlInjected.Address(RVA = "0x6A8920", Offset = "0x6A6F20", VA = "0x1806A8920", Slot = "82")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000039")]
	public event HOBHPHAMKBD BPJGPOJJOIC
	{
		[Cpp2IlInjected.Token(Token = "0x60003F7")]
		[Cpp2IlInjected.Address(RVA = "0x6A8920", Offset = "0x6A6F20", VA = "0x1806A8920", Slot = "83")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60003F8")]
		[Cpp2IlInjected.Address(RVA = "0x6A8920", Offset = "0x6A6F20", VA = "0x1806A8920", Slot = "84")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400003A")]
	public event ABBLHFOFAPM IANJCDBCFAJ
	{
		[Cpp2IlInjected.Token(Token = "0x60003F9")]
		[Cpp2IlInjected.Address(RVA = "0x6A8920", Offset = "0x6A6F20", VA = "0x1806A8920", Slot = "85")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60003FA")]
		[Cpp2IlInjected.Address(RVA = "0x6A8920", Offset = "0x6A6F20", VA = "0x1806A8920", Slot = "86")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400003B")]
	public event HOBHPHAMKBD IBIGIAONNFK
	{
		[Cpp2IlInjected.Token(Token = "0x60003FB")]
		[Cpp2IlInjected.Address(RVA = "0x6A8920", Offset = "0x6A6F20", VA = "0x1806A8920", Slot = "88")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60003FC")]
		[Cpp2IlInjected.Address(RVA = "0x6A8920", Offset = "0x6A6F20", VA = "0x1806A8920", Slot = "89")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400003C")]
	public event HOBHPHAMKBD MPMMHJCOBJO
	{
		[Cpp2IlInjected.Token(Token = "0x60003FD")]
		[Cpp2IlInjected.Address(RVA = "0x6A8920", Offset = "0x6A6F20", VA = "0x1806A8920", Slot = "108")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60003FE")]
		[Cpp2IlInjected.Address(RVA = "0x6A8920", Offset = "0x6A6F20", VA = "0x1806A8920", Slot = "109")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400003D")]
	public event HOBHPHAMKBD IHIJNHOELAG
	{
		[Cpp2IlInjected.Token(Token = "0x60003FF")]
		[Cpp2IlInjected.Address(RVA = "0x6A8920", Offset = "0x6A6F20", VA = "0x1806A8920", Slot = "113")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000400")]
		[Cpp2IlInjected.Address(RVA = "0x6A8920", Offset = "0x6A6F20", VA = "0x1806A8920", Slot = "114")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400003E")]
	public event Action<CEAPFNKIAFO, CEAPFNKIAFO> GAJNIIPFKOP
	{
		[Cpp2IlInjected.Token(Token = "0x6000401")]
		[Cpp2IlInjected.Address(RVA = "0x6A8920", Offset = "0x6A6F20", VA = "0x1806A8920", Slot = "117")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000402")]
		[Cpp2IlInjected.Address(RVA = "0x6A8920", Offset = "0x6A6F20", VA = "0x1806A8920", Slot = "118")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400003F")]
	public event HOBHPHAMKBD PJPDOAADALA
	{
		[Cpp2IlInjected.Token(Token = "0x6000403")]
		[Cpp2IlInjected.Address(RVA = "0x6A8920", Offset = "0x6A6F20", VA = "0x1806A8920", Slot = "119")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000404")]
		[Cpp2IlInjected.Address(RVA = "0x6A8920", Offset = "0x6A6F20", VA = "0x1806A8920", Slot = "120")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000040")]
	public event HOBHPHAMKBD JDPDGOHICPK
	{
		[Cpp2IlInjected.Token(Token = "0x6000405")]
		[Cpp2IlInjected.Address(RVA = "0x6A8920", Offset = "0x6A6F20", VA = "0x1806A8920", Slot = "125")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000406")]
		[Cpp2IlInjected.Address(RVA = "0x6A8920", Offset = "0x6A6F20", VA = "0x1806A8920", Slot = "126")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000451")]
	[Cpp2IlInjected.Address(RVA = "0x6A8920", Offset = "0x6A6F20", VA = "0x1806A8920", Slot = "76")]
	public void NOMIHBFFLNG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000452")]
	[Cpp2IlInjected.Address(RVA = "0x6A8920", Offset = "0x6A6F20", VA = "0x1806A8920", Slot = "77")]
	public void EFPEPNDIDBP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000453")]
	[Cpp2IlInjected.Address(RVA = "0x6A8920", Offset = "0x6A6F20", VA = "0x1806A8920", Slot = "78")]
	public void AHFFBOOJKLD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000454")]
	[Cpp2IlInjected.Address(RVA = "0x6A8920", Offset = "0x6A6F20", VA = "0x1806A8920", Slot = "79")]
	public void ALKMJGDDHDA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000455")]
	[Cpp2IlInjected.Address(RVA = "0x6A8920", Offset = "0x6A6F20", VA = "0x1806A8920", Slot = "80")]
	public void MKJLJFAPFNF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000456")]
	[Cpp2IlInjected.Address(RVA = "0x6A8920", Offset = "0x6A6F20", VA = "0x1806A8920", Slot = "141")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000457")]
	[Cpp2IlInjected.Address(RVA = "0x6A8920", Offset = "0x6A6F20", VA = "0x1806A8920", Slot = "87")]
	public void OGODNIIEFFB(FFCGIONKJBI MAKFNMHIJIF, bool JAHLDBIKCJI = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000458")]
	[Cpp2IlInjected.Address(RVA = "0x6A8920", Offset = "0x6A6F20", VA = "0x1806A8920", Slot = "90")]
	public void DPOKFGFKBCC(object HKLDIENGNNB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000459")]
	[Cpp2IlInjected.Address(RVA = "0x6A8920", Offset = "0x6A6F20", VA = "0x1806A8920", Slot = "91")]
	public void EEPLGJOEHDM(object HKLDIENGNNB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600045A")]
	[Cpp2IlInjected.Address(RVA = "0x682700", Offset = "0x680D00", VA = "0x180682700", Slot = "92")]
	public Vector3 LKOKGKNLODE(Vector3 JMLACAFKJOF)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x600045B")]
	[Cpp2IlInjected.Address(RVA = "0x682700", Offset = "0x680D00", VA = "0x180682700", Slot = "93")]
	public Vector3 PIFFFCJGHPG(Vector3 OLLLCEPAFHE)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x600045C")]
	[Cpp2IlInjected.Address(RVA = "0x6A8920", Offset = "0x6A6F20", VA = "0x1806A8920", Slot = "94")]
	public void BCKDLBEFMPH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600045D")]
	[Cpp2IlInjected.Address(RVA = "0x6A8920", Offset = "0x6A6F20", VA = "0x1806A8920", Slot = "95")]
	public void NLLIBPNNBGH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600045E")]
	[Cpp2IlInjected.Address(RVA = "0x6A8920", Offset = "0x6A6F20", VA = "0x1806A8920", Slot = "96")]
	public void NFCJHIFEHGE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600045F")]
	[Cpp2IlInjected.Address(RVA = "0x6A8920", Offset = "0x6A6F20", VA = "0x1806A8920", Slot = "97")]
	public void KPJAOLBLIEI(Vector3 PFDFFPLAJJP, Vector3 HGIFCPKBAGG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000460")]
	[Cpp2IlInjected.Address(RVA = "0x6A8920", Offset = "0x6A6F20", VA = "0x1806A8920", Slot = "98")]
	public void EBKBGNAGIOD(Vector3 LOGKBIHCFJD, Vector3 OGPMEJLJLFA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000461")]
	[Cpp2IlInjected.Address(RVA = "0x6A8920", Offset = "0x6A6F20", VA = "0x1806A8920", Slot = "99")]
	public void DNAJDFGLENG(Vector3 OANHHGBFKAN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000462")]
	[Cpp2IlInjected.Address(RVA = "0x6A8920", Offset = "0x6A6F20", VA = "0x1806A8920", Slot = "100")]
	public void CBHLOBJDACM(CKAOOODELAE IKFPEHIFEPN, Vector3 NMBFBKMEJKN, float FEHHFHACKBK, float IOFMPFNPHNC = 8f, float JKLGNKAKKLG = 1f)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000463")]
	[Cpp2IlInjected.Address(RVA = "0x6A8920", Offset = "0x6A6F20", VA = "0x1806A8920", Slot = "101")]
	public void NCIJALPIGCE(MCMFGEDCCGC LMLMHHPMBJO, Vector3 OFLGCJLDNJJ, float IPAPNFBMGEF = float.PositiveInfinity)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000464")]
	[Cpp2IlInjected.Address(RVA = "0x6A8920", Offset = "0x6A6F20", VA = "0x1806A8920", Slot = "102")]
	public void FDJHKHJGOHO(MCMFGEDCCGC LMLMHHPMBJO, Vector3 JGCPJBFFFAC, float NMBEKOOKPJA = 7f, float MFBAPHBIEKM = 1f)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000465")]
	[Cpp2IlInjected.Address(RVA = "0x682700", Offset = "0x680D00", VA = "0x180682700", Slot = "103")]
	public Vector3 AJLBGCPJCKN(Vector3 MAKFNMHIJIF)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000466")]
	[Cpp2IlInjected.Address(RVA = "0x682700", Offset = "0x680D00", VA = "0x180682700", Slot = "104")]
	public Vector3 PIFNCDNOKAD(Vector3 MAKFNMHIJIF)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000467")]
	[Cpp2IlInjected.Address(RVA = "0x6A8920", Offset = "0x6A6F20", VA = "0x1806A8920", Slot = "105")]
	public void LADPNNADDEK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000468")]
	[Cpp2IlInjected.Address(RVA = "0x6A8920", Offset = "0x6A6F20", VA = "0x1806A8920", Slot = "106")]
	public void LJGPKEPDMFN(FFCGIONKJBI HJFPEPOCKIC, object HKLDIENGNNB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000469")]
	[Cpp2IlInjected.Address(RVA = "0x6A8920", Offset = "0x6A6F20", VA = "0x1806A8920", Slot = "107")]
	public void GBMKLKMCAMC(object HKLDIENGNNB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600046A")]
	[Cpp2IlInjected.Address(RVA = "0x6A8920", Offset = "0x6A6F20", VA = "0x1806A8920", Slot = "110")]
	public void CAALKOKEPPD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600046B")]
	[Cpp2IlInjected.Address(RVA = "0x6A8920", Offset = "0x6A6F20", VA = "0x1806A8920", Slot = "111")]
	public void BANKNELMPFP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600046C")]
	[Cpp2IlInjected.Address(RVA = "0x6A8920", Offset = "0x6A6F20", VA = "0x1806A8920", Slot = "112")]
	public void GAANFDFDMKC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600046D")]
	[Cpp2IlInjected.Address(RVA = "0x677260", Offset = "0x675860", VA = "0x180677260", Slot = "115")]
	public bool MNIMMDJAIIP()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600046E")]
	[Cpp2IlInjected.Address(RVA = "0x6A8920", Offset = "0x6A6F20", VA = "0x1806A8920", Slot = "116")]
	public void LEMLLHIPKGE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600046F")]
	[Cpp2IlInjected.Address(RVA = "0x677290", Offset = "0x675890", VA = "0x180677290", Slot = "121")]
	public IDisposable IFKNDGBNBEF()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000470")]
	[Cpp2IlInjected.Address(RVA = "0x6A8920", Offset = "0x6A6F20", VA = "0x1806A8920", Slot = "122")]
	public void FKOFNEMGINM(object HKLDIENGNNB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000471")]
	[Cpp2IlInjected.Address(RVA = "0x6A8920", Offset = "0x6A6F20", VA = "0x1806A8920", Slot = "123")]
	public void BEHGOGKEFEN(object HKLDIENGNNB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000472")]
	[Cpp2IlInjected.Address(RVA = "0x6A8920", Offset = "0x6A6F20", VA = "0x1806A8920", Slot = "124")]
	public void DLBAIGNALBD(object HKLDIENGNNB, bool BKHDMOGADPG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000473")]
	[Cpp2IlInjected.Address(RVA = "0x6A8920", Offset = "0x6A6F20", VA = "0x1806A8920", Slot = "127")]
	public void JEBPKKGFEDL(Vector3 AFHANPMAJON, Quaternion MGLHGJDPDPO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000474")]
	[Cpp2IlInjected.Address(RVA = "0x6A8920", Offset = "0x6A6F20", VA = "0x1806A8920", Slot = "128")]
	public void CIOEFCEIHBP(Vector3 JGOFLNCMNEF, Quaternion HHGDJGKIPDH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000475")]
	[Cpp2IlInjected.Address(RVA = "0x677260", Offset = "0x675860", VA = "0x180677260", Slot = "129")]
	public bool OJPJAEOKAPC(float CJJGIOGGJMO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000476")]
	[Cpp2IlInjected.Address(RVA = "0x6A8920", Offset = "0x6A6F20", VA = "0x1806A8920", Slot = "130")]
	public void FLGEALADFAB(object HKLDIENGNNB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000477")]
	[Cpp2IlInjected.Address(RVA = "0x6A8920", Offset = "0x6A6F20", VA = "0x1806A8920", Slot = "131")]
	public void GOLJJNAJJDK(object HKLDIENGNNB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000478")]
	[Cpp2IlInjected.Address(RVA = "0x6A8920", Offset = "0x6A6F20", VA = "0x1806A8920", Slot = "132")]
	public void HCDCAKONHKH(object HKLDIENGNNB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000479")]
	[Cpp2IlInjected.Address(RVA = "0x6A8920", Offset = "0x6A6F20", VA = "0x1806A8920", Slot = "133")]
	public void ANODKIPNKGG(object HKLDIENGNNB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600047A")]
	[Cpp2IlInjected.Address(RVA = "0x6A8920", Offset = "0x6A6F20", VA = "0x1806A8920", Slot = "134")]
	public void PADGBNKEIIJ(Vector3 CBEIFKNKIIE, ForceMode OEBHACLNMCB = ForceMode.Force)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600047B")]
	[Cpp2IlInjected.Address(RVA = "0x6A8920", Offset = "0x6A6F20", VA = "0x1806A8920", Slot = "135")]
	public void HKDCNICIFFL(Vector3 CBEIFKNKIIE, Vector3 EINGNKDKDHC, ForceMode OEBHACLNMCB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600047C")]
	[Cpp2IlInjected.Address(RVA = "0x6A8920", Offset = "0x6A6F20", VA = "0x1806A8920", Slot = "136")]
	public void EPMGKEGNALO(Vector3 DEMLAEGANDJ, ForceMode OEBHACLNMCB = ForceMode.Force)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600047D")]
	[Cpp2IlInjected.Address(RVA = "0x6A8920", Offset = "0x6A6F20", VA = "0x1806A8920", Slot = "137")]
	public void PINFLFOIKOH(Vector3 DEMLAEGANDJ, ForceMode OEBHACLNMCB = ForceMode.Force)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600047E")]
	[Cpp2IlInjected.Address(RVA = "0x5453D90", Offset = "0x5452390", VA = "0x185453D90", Slot = "138")]
	public bool COKAFBGHKMH(Vector3 FOGEFLLJLFJ, out RaycastHit LOOJGACDMOC, float IDHCBHDHMCK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600047F")]
	[Cpp2IlInjected.Address(RVA = "0x6A8920", Offset = "0x6A6F20", VA = "0x1806A8920", Slot = "139")]
	public void DFDCFAGILJM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000480")]
	[Cpp2IlInjected.Address(RVA = "0x6A82D0", Offset = "0x6A68D0", VA = "0x1806A82D0")]
	public MKNGOFHDHJF()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000045")]
public sealed class FAEFMAFLNLK : NMHAAMBBHKD, IAEKLBCNHIG, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
	[Cpp2IlInjected.Token(Token = "0x4000082")]
	internal NIALADIPDNC EHLCJHMJBBP;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
	[Cpp2IlInjected.Token(Token = "0x4000083")]
	internal PJCBAJNDEOE FFIAOEIJKKJ;

	[Cpp2IlInjected.Token(Token = "0x6000482")]
	[Cpp2IlInjected.Address(RVA = "0x5443CE0", Offset = "0x54422E0", VA = "0x185443CE0")]
	public FAEFMAFLNLK(GameObject EHEABJNEALG, RigidbodyEx LMKJNNOGFLA, MPHIHDCLPDB HKMONJIHHIH, in IMECCMKFBII JIHCLPECHIB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000483")]
	[Cpp2IlInjected.Address(RVA = "0x54437D0", Offset = "0x5441DD0", VA = "0x1854437D0", Slot = "142")]
	protected override void EBMDLPECLDP(MPHIHDCLPDB HKMONJIHHIH, IMECCMKFBII JIHCLPECHIB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000484")]
	[Cpp2IlInjected.Address(RVA = "0x5443640", Offset = "0x5441C40", VA = "0x185443640", Slot = "143")]
	public override void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000485")]
	[Cpp2IlInjected.Address(RVA = "0x54434B0", Offset = "0x5441AB0", VA = "0x1854434B0", Slot = "145")]
	public void ADGNAFGAAEA(CEFLALGDCIE GLJCMMBCBOC, CEFLALGDCIE PNPBNOELPMC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000486")]
	[Cpp2IlInjected.Address(RVA = "0x5443580", Offset = "0x5441B80", VA = "0x185443580", Slot = "146")]
	public void DNKIHCFNJJA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000487")]
	[Cpp2IlInjected.Address(RVA = "0x5443C20", Offset = "0x5442220", VA = "0x185443C20", Slot = "147")]
	public void JKINNNDBIAE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000488")]
	[Cpp2IlInjected.Address(RVA = "0x5443BC0", Offset = "0x54421C0", VA = "0x185443BC0", Slot = "148")]
	public void HKDHIFCLEOH(bool HBGILCDGAGC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000489")]
	[Cpp2IlInjected.Address(RVA = "0x5443A60", Offset = "0x5442060", VA = "0x185443A60", Slot = "149")]
	public bool FAKDMJMODLG()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600048A")]
	[Cpp2IlInjected.Address(RVA = "0x6A8920", Offset = "0x6A6F20", VA = "0x1806A8920", Slot = "144")]
	public override void MKJLJFAPFNF()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000046")]
internal static class KGEGGDHDLCI
{
	[Cpp2IlInjected.Token(Token = "0x600048B")]
	[Cpp2IlInjected.Address(RVA = "0x5450D40", Offset = "0x544F340", VA = "0x185450D40")]
	public static NMHAAMBBHKD HMBPKFNKMBD(this FFCGIONKJBI BMFGKMDOFCF)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000047")]
public interface LIHGGLMICBO : IPLGDMEHBOJ, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x600048C")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void OPJJCFHECII(FFCGIONKJBI FHCKPPNILHO);

	[Cpp2IlInjected.Token(Token = "0x600048D")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void APJHAKKKPLO(FFCGIONKJBI FHCKPPNILHO);

	[Cpp2IlInjected.Token(Token = "0x600048E")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void FKPIKBICOFJ(FFCGIONKJBI EBNAKIGKECH);

	[Cpp2IlInjected.Token(Token = "0x600048F")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void DCJINOKJEFG(FFCGIONKJBI EBNAKIGKECH);
}
[Cpp2IlInjected.Token(Token = "0x2000048")]
public interface CDOGOKAHBFC : EBAADMBJLMD
{
	[Cpp2IlInjected.Token(Token = "0x17000130")]
	global::MKJFLENGDLA<FFCGIONKJBI> KDBBCEGKHJG
	{
		[Cpp2IlInjected.Token(Token = "0x6000490")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000131")]
	FFCGIONKJBI POKCCLODFLP
	{
		[Cpp2IlInjected.Token(Token = "0x6000491")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000049")]
public interface MIHKGHPJGIN : CHBALODMMNE
{
	[Cpp2IlInjected.Token(Token = "0x6000492")]
	[Cpp2IlInjected.Address(Slot = "0")]
	(float, Vector3) JIKMNOJPHEP(Rigidbody KBIMEMIPFEL);
}
[Cpp2IlInjected.Token(Token = "0x200004A")]
public interface DAEFAEBHLJK : BHMDAAMOACJ, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x17000132")]
	PhotonView NJAFHGPCJKE
	{
		[Cpp2IlInjected.Token(Token = "0x6000493")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x200004B")]
internal sealed class NOLNDJIHAGN : MFNEPAJBKBE
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000084")]
	private readonly NMHAAMBBHKD FHCKPPNILHO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000085")]
	private CollisionDetectionMode NDNMPGDEEHP;

	[Cpp2IlInjected.Token(Token = "0x17000133")]
	private Rigidbody BKIDAKAFFMP
	{
		[Cpp2IlInjected.Token(Token = "0x6000494")]
		[Cpp2IlInjected.Address(RVA = "0x5440010", Offset = "0x543E610", VA = "0x185440010")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000134")]
	public CollisionDetectionMode GDCFMCCNNGL
	{
		[Cpp2IlInjected.Token(Token = "0x6000498")]
		[Cpp2IlInjected.Address(RVA = "0x5459F90", Offset = "0x5458590", VA = "0x185459F90", Slot = "4")]
		get
		{
			return default(CollisionDetectionMode);
		}
		[Cpp2IlInjected.Token(Token = "0x6000499")]
		[Cpp2IlInjected.Address(RVA = "0x545A2B0", Offset = "0x54588B0", VA = "0x18545A2B0", Slot = "5")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000495")]
	[Cpp2IlInjected.Address(RVA = "0x5451B50", Offset = "0x5450150", VA = "0x185451B50")]
	public NOLNDJIHAGN(FFCGIONKJBI FHCKPPNILHO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000496")]
	[Cpp2IlInjected.Address(RVA = "0x545A320", Offset = "0x5458920", VA = "0x18545A320", Slot = "6")]
	public void NOMIHBFFLNG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000497")]
	[Cpp2IlInjected.Address(RVA = "0x545A230", Offset = "0x5458830", VA = "0x18545A230", Slot = "9")]
	public void KDPOLAHOOPE(Rigidbody MKOMGOCHBJC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600049A")]
	[Cpp2IlInjected.Address(RVA = "0x545A210", Offset = "0x5458810", VA = "0x18545A210", Slot = "7")]
	public void FICELACKBCB(bool IGMFHMLOGDC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600049B")]
	[Cpp2IlInjected.Address(RVA = "0x545A220", Offset = "0x5458820", VA = "0x18545A220", Slot = "8")]
	public void GDPJJGMKJBP(bool IGMFHMLOGDC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600049C")]
	[Cpp2IlInjected.Address(RVA = "0x545A0A0", Offset = "0x54586A0", VA = "0x18545A0A0", Slot = "10")]
	public bool COKAFBGHKMH(Vector3 FOGEFLLJLFJ, out RaycastHit LOOJGACDMOC, float IDHCBHDHMCK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600049D")]
	[Cpp2IlInjected.Address(RVA = "0x545A440", Offset = "0x5458A40", VA = "0x18545A440")]
	private void PIOIFMODKCP(bool IGMFHMLOGDC)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200004C")]
public sealed class DFCEDAGNFJI : CGKAANMHLMI, IDisposable, KCLAPJNLDEK
{
	[Cpp2IlInjected.Token(Token = "0x4000086")]
	public const int BOICEILCGAB = 350;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000088")]
	private readonly NMHAAMBBHKD FHCKPPNILHO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000089")]
	private CKHEJONCKGK LFMHGHDEAIB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400008A")]
	private IPLAPPDCGPJ LCMDEKCOFAH;

	[Cpp2IlInjected.Token(Token = "0x17000135")]
	public CKHEJONCKGK GGJLBGDDKGJ
	{
		[Cpp2IlInjected.Token(Token = "0x60004A0")]
		[Cpp2IlInjected.Address(RVA = "0x5441970", Offset = "0x543FF70", VA = "0x185441970", Slot = "6")]
		get
		{
			return default(CKHEJONCKGK);
		}
		[Cpp2IlInjected.Token(Token = "0x60004A1")]
		[Cpp2IlInjected.Address(RVA = "0x5441BF0", Offset = "0x54401F0", VA = "0x185441BF0", Slot = "7")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000136")]
	private Transform PDEMFIDJPNF
	{
		[Cpp2IlInjected.Token(Token = "0x60004A2")]
		[Cpp2IlInjected.Address(RVA = "0x5441CC0", Offset = "0x54402C0", VA = "0x185441CC0", Slot = "10")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000041")]
	public event Action<CEAPFNKIAFO, CEAPFNKIAFO> GAJNIIPFKOP
	{
		[Cpp2IlInjected.Token(Token = "0x600049E")]
		[Cpp2IlInjected.Address(RVA = "0x5441AB0", Offset = "0x54400B0", VA = "0x185441AB0", Slot = "4")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600049F")]
		[Cpp2IlInjected.Address(RVA = "0x5441B50", Offset = "0x5440150", VA = "0x185441B50", Slot = "5")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60004A3")]
	[Cpp2IlInjected.Address(RVA = "0x5441FC0", Offset = "0x54405C0", VA = "0x185441FC0")]
	public DFCEDAGNFJI(FFCGIONKJBI FHCKPPNILHO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004A4")]
	[Cpp2IlInjected.Address(RVA = "0x5441CE0", Offset = "0x54402E0", VA = "0x185441CE0", Slot = "8")]
	public void NOMIHBFFLNG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004A5")]
	[Cpp2IlInjected.Address(RVA = "0x54418C0", Offset = "0x543FEC0", VA = "0x1854418C0", Slot = "9")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004A6")]
	[Cpp2IlInjected.Address(RVA = "0x5441910", Offset = "0x543FF10", VA = "0x185441910", Slot = "11")]
	private void ELOHKMMAIIJ(CEAPFNKIAFO HPKJNHPLCPI, CEAPFNKIAFO FBLLAOEFGAF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004A7")]
	[Cpp2IlInjected.Address(RVA = "0x6A8920", Offset = "0x6A6F20", VA = "0x1806A8920", Slot = "12")]
	private void LKOJOAKCABA(bool MDMFNFBFLBD)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200004D")]
internal sealed class LCGAJDOHAGD : GIGBMEPJFND
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400008B")]
	private readonly NMHAAMBBHKD FHCKPPNILHO;

	[Cpp2IlInjected.Token(Token = "0x17000137")]
	private Rigidbody BKIDAKAFFMP
	{
		[Cpp2IlInjected.Token(Token = "0x60004A8")]
		[Cpp2IlInjected.Address(RVA = "0x5440010", Offset = "0x543E610", VA = "0x185440010")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000138")]
	private bool DEHDGKEMKCA
	{
		[Cpp2IlInjected.Token(Token = "0x60004A9")]
		[Cpp2IlInjected.Address(RVA = "0x5440740", Offset = "0x543ED40", VA = "0x185440740")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000139")]
	private bool CAIEJEMCAII
	{
		[Cpp2IlInjected.Token(Token = "0x60004AA")]
		[Cpp2IlInjected.Address(RVA = "0x5437180", Offset = "0x5435780", VA = "0x185437180")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700013A")]
	private FFCGIONKJBI HDIMMFJBNPK
	{
		[Cpp2IlInjected.Token(Token = "0x60004AB")]
		[Cpp2IlInjected.Address(RVA = "0x5451090", Offset = "0x544F690", VA = "0x185451090")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60004AC")]
	[Cpp2IlInjected.Address(RVA = "0x5451B50", Offset = "0x5450150", VA = "0x185451B50")]
	public LCGAJDOHAGD(FFCGIONKJBI FHCKPPNILHO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004AD")]
	[Cpp2IlInjected.Address(RVA = "0x5451770", Offset = "0x544FD70", VA = "0x185451770", Slot = "4")]
	public void PADGBNKEIIJ(Vector3 CBEIFKNKIIE, ForceMode OEBHACLNMCB = ForceMode.Force)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004AE")]
	[Cpp2IlInjected.Address(RVA = "0x54514F0", Offset = "0x544FAF0", VA = "0x1854514F0")]
	private void OFMHFHDJNMM(Vector3 CBEIFKNKIIE, ForceMode OEBHACLNMCB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004AF")]
	[Cpp2IlInjected.Address(RVA = "0x5451250", Offset = "0x544F850", VA = "0x185451250", Slot = "5")]
	public void HKDCNICIFFL(Vector3 CBEIFKNKIIE, Vector3 EINGNKDKDHC, ForceMode OEBHACLNMCB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004B0")]
	[Cpp2IlInjected.Address(RVA = "0x54510F0", Offset = "0x544F6F0", VA = "0x1854510F0", Slot = "6")]
	public void EPMGKEGNALO(Vector3 DEMLAEGANDJ, ForceMode OEBHACLNMCB = ForceMode.Force)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004B1")]
	[Cpp2IlInjected.Address(RVA = "0x5450E10", Offset = "0x544F410", VA = "0x185450E10")]
	private void AOALFPILCPL(Vector3 DEMLAEGANDJ, ForceMode OEBHACLNMCB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004B2")]
	[Cpp2IlInjected.Address(RVA = "0x54518D0", Offset = "0x544FED0", VA = "0x1854518D0", Slot = "7")]
	public void PINFLFOIKOH(Vector3 DEMLAEGANDJ, ForceMode OEBHACLNMCB = ForceMode.Force)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200004E")]
internal sealed class ONONMKHEBAI : JJPLOLDPKDF
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400008C")]
	private readonly NMHAAMBBHKD FHCKPPNILHO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400008D")]
	private bool DAIBFNHELEC;

	[Cpp2IlInjected.Token(Token = "0x1700013B")]
	public bool HGEMBEONDNJ
	{
		[Cpp2IlInjected.Token(Token = "0x60004B4")]
		[Cpp2IlInjected.Address(RVA = "0x7834A0", Offset = "0x781AA0", VA = "0x1807834A0", Slot = "4")]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x60004B5")]
		[Cpp2IlInjected.Address(RVA = "0x1CB6FC0", Offset = "0x1CB55C0", VA = "0x181CB6FC0", Slot = "5")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60004B3")]
	[Cpp2IlInjected.Address(RVA = "0x1CB70E0", Offset = "0x1CB56E0", VA = "0x181CB70E0")]
	public ONONMKHEBAI(FFCGIONKJBI FHCKPPNILHO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004B6")]
	[Cpp2IlInjected.Address(RVA = "0x1CB70B0", Offset = "0x1CB56B0", VA = "0x181CB70B0", Slot = "6")]
	public void KDPOLAHOOPE(Rigidbody MKOMGOCHBJC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004B7")]
	[Cpp2IlInjected.Address(RVA = "0x1CB7070", Offset = "0x1CB5670", VA = "0x181CB7070", Slot = "7")]
	public void DIDIIBMEDJD(Rigidbody MKOMGOCHBJC)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200004F")]
internal sealed class IBJDNMPHFOA : LIHGGLMICBO, IPLGDMEHBOJ, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x4000097")]
	private readonly FFCGIONKJBI FHCKPPNILHO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x4000098")]
	private readonly List<FFCGIONKJBI> PAHCBODMCHK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x4000099")]
	private FFCGIONKJBI COMPFMNMPEI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x400009A")]
	private FFCGIONKJBI LFAIGCEGCPL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
	[Cpp2IlInjected.Token(Token = "0x400009B")]
	private Transform PMLOOMMLBAG;

	[Cpp2IlInjected.Token(Token = "0x1700013C")]
	private Transform DACDPJCIAKE
	{
		[Cpp2IlInjected.Token(Token = "0x60004CA")]
		[Cpp2IlInjected.Address(RVA = "0x5447C40", Offset = "0x5446240", VA = "0x185447C40")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700013D")]
	public FFCGIONKJBI HDIMMFJBNPK
	{
		[Cpp2IlInjected.Token(Token = "0x60004CD")]
		[Cpp2IlInjected.Address(RVA = "0x708FA0", Offset = "0x7075A0", VA = "0x180708FA0", Slot = "28")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60004CE")]
		[Cpp2IlInjected.Address(RVA = "0x5447B90", Offset = "0x5446190", VA = "0x185447B90", Slot = "29")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700013E")]
	public FFCGIONKJBI AMKPOIHFDKH
	{
		[Cpp2IlInjected.Token(Token = "0x60004CF")]
		[Cpp2IlInjected.Address(RVA = "0x810210", Offset = "0x80E810", VA = "0x180810210", Slot = "27")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700013F")]
	public IReadOnlyList<FFCGIONKJBI> KEPEEEPLAGJ
	{
		[Cpp2IlInjected.Token(Token = "0x60004D0")]
		[Cpp2IlInjected.Address(RVA = "0x810200", Offset = "0x80E800", VA = "0x180810200", Slot = "26")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000042")]
	public event HOBHPHAMKBD IAOFFICNEFM
	{
		[Cpp2IlInjected.Token(Token = "0x60004B8")]
		[Cpp2IlInjected.Address(RVA = "0x54471A0", Offset = "0x54457A0", VA = "0x1854471A0", Slot = "8")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60004B9")]
		[Cpp2IlInjected.Address(RVA = "0x5447080", Offset = "0x5445680", VA = "0x185447080", Slot = "9")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000043")]
	public event HOBHPHAMKBD BPJGPOJJOIC
	{
		[Cpp2IlInjected.Token(Token = "0x60004BA")]
		[Cpp2IlInjected.Address(RVA = "0x5446CE0", Offset = "0x54452E0", VA = "0x185446CE0", Slot = "10")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60004BB")]
		[Cpp2IlInjected.Address(RVA = "0x5447CA0", Offset = "0x54462A0", VA = "0x185447CA0", Slot = "11")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000044")]
	public event ABBLHFOFAPM IANJCDBCFAJ
	{
		[Cpp2IlInjected.Token(Token = "0x60004BC")]
		[Cpp2IlInjected.Address(RVA = "0x5448530", Offset = "0x5446B30", VA = "0x185448530", Slot = "12")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60004BD")]
		[Cpp2IlInjected.Address(RVA = "0x5447490", Offset = "0x5445A90", VA = "0x185447490", Slot = "13")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000045")]
	public event Action HGFICMNEKPD
	{
		[Cpp2IlInjected.Token(Token = "0x60004BE")]
		[Cpp2IlInjected.Address(RVA = "0x5447530", Offset = "0x5445B30", VA = "0x185447530", Slot = "14")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60004BF")]
		[Cpp2IlInjected.Address(RVA = "0x5447710", Offset = "0x5445D10", VA = "0x185447710", Slot = "15")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000046")]
	public event Action AOLPOEKDAPB
	{
		[Cpp2IlInjected.Token(Token = "0x60004C0")]
		[Cpp2IlInjected.Address(RVA = "0x54475D0", Offset = "0x5445BD0", VA = "0x1854475D0", Slot = "16")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60004C1")]
		[Cpp2IlInjected.Address(RVA = "0x5447BA0", Offset = "0x54461A0", VA = "0x185447BA0", Slot = "17")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000047")]
	public event Action<FFCGIONKJBI> MIDFDOJCFED
	{
		[Cpp2IlInjected.Token(Token = "0x60004C2")]
		[Cpp2IlInjected.Address(RVA = "0x5446FE0", Offset = "0x54455E0", VA = "0x185446FE0", Slot = "18")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60004C3")]
		[Cpp2IlInjected.Address(RVA = "0x5446A50", Offset = "0x5445050", VA = "0x185446A50", Slot = "19")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000048")]
	public event Action<FFCGIONKJBI> ENHLMFMKKOI
	{
		[Cpp2IlInjected.Token(Token = "0x60004C4")]
		[Cpp2IlInjected.Address(RVA = "0x5448610", Offset = "0x5446C10", VA = "0x185448610", Slot = "20")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60004C5")]
		[Cpp2IlInjected.Address(RVA = "0x5447670", Offset = "0x5445C70", VA = "0x185447670", Slot = "21")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000049")]
	public event Action CBAHCMEOEBH
	{
		[Cpp2IlInjected.Token(Token = "0x60004C6")]
		[Cpp2IlInjected.Address(RVA = "0x5448490", Offset = "0x5446A90", VA = "0x185448490", Slot = "22")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60004C7")]
		[Cpp2IlInjected.Address(RVA = "0x5447A50", Offset = "0x5446050", VA = "0x185447A50", Slot = "23")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400004A")]
	public event Action<FFCGIONKJBI> PNGLKBMDHIJ
	{
		[Cpp2IlInjected.Token(Token = "0x60004C8")]
		[Cpp2IlInjected.Address(RVA = "0x5447AF0", Offset = "0x54460F0", VA = "0x185447AF0", Slot = "24")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60004C9")]
		[Cpp2IlInjected.Address(RVA = "0x5446AF0", Offset = "0x54450F0", VA = "0x185446AF0", Slot = "25")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60004CB")]
	[Cpp2IlInjected.Address(RVA = "0x54486B0", Offset = "0x5446CB0", VA = "0x1854486B0")]
	public IBJDNMPHFOA(FFCGIONKJBI FHCKPPNILHO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004CC")]
	[Cpp2IlInjected.Address(RVA = "0x5447120", Offset = "0x5445720", VA = "0x185447120", Slot = "31")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004D1")]
	[Cpp2IlInjected.Address(RVA = "0x5447D40", Offset = "0x5446340", VA = "0x185447D40", Slot = "30")]
	public void OGODNIIEFFB(FFCGIONKJBI EBIGGMLCEAF, bool JAHLDBIKCJI = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004D2")]
	[Cpp2IlInjected.Address(RVA = "0x5447240", Offset = "0x5445840", VA = "0x185447240", Slot = "6")]
	public void FKPIKBICOFJ(FFCGIONKJBI EBNAKIGKECH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004D3")]
	[Cpp2IlInjected.Address(RVA = "0x5446D80", Offset = "0x5445380", VA = "0x185446D80", Slot = "7")]
	public void DCJINOKJEFG(FFCGIONKJBI EBNAKIGKECH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004D4")]
	[Cpp2IlInjected.Address(RVA = "0x54483F0", Offset = "0x54469F0", VA = "0x1854483F0", Slot = "4")]
	public void OPJJCFHECII(FFCGIONKJBI FHCKPPNILHO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004D5")]
	[Cpp2IlInjected.Address(RVA = "0x54469B0", Offset = "0x5444FB0", VA = "0x1854469B0", Slot = "5")]
	public void APJHAKKKPLO(FFCGIONKJBI FHCKPPNILHO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004D6")]
	[Cpp2IlInjected.Address(RVA = "0x54479C0", Offset = "0x5445FC0", VA = "0x1854479C0")]
	private void IIHIMCEPCEK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004D7")]
	[Cpp2IlInjected.Address(RVA = "0x54485D0", Offset = "0x5446BD0", VA = "0x1854485D0")]
	private void PKKLCJELFEI(FFCGIONKJBI EBNAKIGKECH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004D8")]
	[Cpp2IlInjected.Address(RVA = "0x5446B90", Offset = "0x5445190", VA = "0x185446B90")]
	private void CLODPCAPFJO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004D9")]
	[Cpp2IlInjected.Address(RVA = "0x54482C0", Offset = "0x54468C0", VA = "0x1854482C0")]
	private void ONAEFPLNEDD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004DA")]
	[Cpp2IlInjected.Address(RVA = "0x54477B0", Offset = "0x5445DB0", VA = "0x1854477B0")]
	private void IBNBBPLEKPA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004DB")]
	[Cpp2IlInjected.Address(RVA = "0x54478D0", Offset = "0x5445ED0", VA = "0x1854478D0")]
	[CompilerGenerated]
	private object IGNLFDJMMCE()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000050")]
internal static class MPAJCIDCKII
{
	[Cpp2IlInjected.Token(Token = "0x60004DC")]
	[Cpp2IlInjected.Address(RVA = "0x5453E10", Offset = "0x5452410", VA = "0x185453E10")]
	public static LIHGGLMICBO MLMCGKJNBJK(this FFCGIONKJBI BMFGKMDOFCF)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000051")]
internal sealed class COJFJMHBNAL : CDOGOKAHBFC, EBAADMBJLMD
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400009C")]
	private readonly NMHAAMBBHKD FHCKPPNILHO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400009D")]
	private readonly global::MKJFLENGDLA<FFCGIONKJBI> BPPHKLFIGNN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400009E")]
	private bool JKPHCGIHDPJ;

	[Cpp2IlInjected.Token(Token = "0x17000140")]
	public global::MKJFLENGDLA<FFCGIONKJBI> KDBBCEGKHJG
	{
		[Cpp2IlInjected.Token(Token = "0x60004DD")]
		[Cpp2IlInjected.Address(RVA = "0x706850", Offset = "0x704E50", VA = "0x180706850", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000141")]
	public Vector3 GNKPAMJBNBD
	{
		[Cpp2IlInjected.Token(Token = "0x60004DE")]
		[Cpp2IlInjected.Address(RVA = "0x543EAF0", Offset = "0x543D0F0", VA = "0x18543EAF0", Slot = "6")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000142")]
	public Vector3 DECHPPBODKH
	{
		[Cpp2IlInjected.Token(Token = "0x60004DF")]
		[Cpp2IlInjected.Address(RVA = "0x543E920", Offset = "0x543CF20", VA = "0x18543E920", Slot = "7")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000143")]
	private Vector3 OMPLHOFEJAN
	{
		[Cpp2IlInjected.Token(Token = "0x60004E3")]
		[Cpp2IlInjected.Address(RVA = "0x543EB20", Offset = "0x543D120", VA = "0x18543EB20")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000144")]
	public FFCGIONKJBI POKCCLODFLP
	{
		[Cpp2IlInjected.Token(Token = "0x60004E4")]
		[Cpp2IlInjected.Address(RVA = "0x543E870", Offset = "0x543CE70", VA = "0x18543E870", Slot = "5")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60004E0")]
	[Cpp2IlInjected.Address(RVA = "0x543F3C0", Offset = "0x543D9C0", VA = "0x18543F3C0")]
	public COJFJMHBNAL(FFCGIONKJBI FHCKPPNILHO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004E1")]
	[Cpp2IlInjected.Address(RVA = "0x543F350", Offset = "0x543D950", VA = "0x18543F350", Slot = "8")]
	public void KJONOMFBLIP(FFCGIONKJBI LFAIGCEGCPL, object HKLDIENGNNB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004E2")]
	[Cpp2IlInjected.Address(RVA = "0x543EFA0", Offset = "0x543D5A0", VA = "0x18543EFA0", Slot = "9")]
	public void GBBOCMNIAIE(object HKLDIENGNNB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004E5")]
	[Cpp2IlInjected.Address(RVA = "0x543F000", Offset = "0x543D600", VA = "0x18543F000")]
	private Vector3 JCHOIMFBPCP()
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x60004E6")]
	[Cpp2IlInjected.Address(RVA = "0x543EC00", Offset = "0x543D200", VA = "0x18543EC00")]
	private void FGEMKEKLHDE(FFCGIONKJBI KIFBLAKDELP)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000052")]
internal static class GEKLNFGAAGE
{
	[Cpp2IlInjected.Token(Token = "0x60004E7")]
	[Cpp2IlInjected.Address(RVA = "0x5444BD0", Offset = "0x54431D0", VA = "0x185444BD0")]
	public static CDOGOKAHBFC KMOKGEHBCHJ(this FFCGIONKJBI BMFGKMDOFCF)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000053")]
internal sealed class CJCNFKFOMPE : MIHKGHPJGIN, CHBALODMMNE
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000A0")]
	private readonly NMHAAMBBHKD FHCKPPNILHO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000A1")]
	private readonly OverridableVector3 KKHPEDMDNHD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40000A2")]
	private readonly OverridableVector3 HGJNFBEOBMB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x40000A3")]
	private float MNOFKHGJHAL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x44")]
	[Cpp2IlInjected.Token(Token = "0x40000A4")]
	private float BCCFBPPIBNF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x40000A5")]
	private Vector3 KDBLJOCPCPM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x54")]
	[Cpp2IlInjected.Token(Token = "0x40000A6")]
	private Vector3? ILIIJCFJEHJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x64")]
	[Cpp2IlInjected.Token(Token = "0x40000A7")]
	private Quaternion? LKDKKEEAFEJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
	[Cpp2IlInjected.Token(Token = "0x40000A8")]
	private bool IOKFAEIKHAG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x79")]
	[Cpp2IlInjected.Token(Token = "0x40000A9")]
	private bool CLAHCEGDBCO;

	[Cpp2IlInjected.Token(Token = "0x17000145")]
	public Vector3 AAGDOJLDOMM
	{
		[Cpp2IlInjected.Token(Token = "0x60004EA")]
		[Cpp2IlInjected.Address(RVA = "0x1FD1900", Offset = "0x1FCFF00", VA = "0x181FD1900", Slot = "7")]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x60004EB")]
		[Cpp2IlInjected.Address(RVA = "0x543BF00", Offset = "0x543A500", VA = "0x18543BF00", Slot = "8")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000146")]
	public Vector3 DJLPMKOMOHI
	{
		[Cpp2IlInjected.Token(Token = "0x60004EC")]
		[Cpp2IlInjected.Address(RVA = "0x543B1B0", Offset = "0x54397B0", VA = "0x18543B1B0", Slot = "9")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000147")]
	public float MGOEPMCMEHB
	{
		[Cpp2IlInjected.Token(Token = "0x60004ED")]
		[Cpp2IlInjected.Address(RVA = "0x79D0E0", Offset = "0x79B6E0", VA = "0x18079D0E0", Slot = "10")]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x60004EE")]
		[Cpp2IlInjected.Address(RVA = "0x543C3C0", Offset = "0x543A9C0", VA = "0x18543C3C0")]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000148")]
	public float OEDNFOGCCII
	{
		[Cpp2IlInjected.Token(Token = "0x60004EF")]
		[Cpp2IlInjected.Address(RVA = "0x886E10", Offset = "0x885410", VA = "0x180886E10", Slot = "11")]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x60004F0")]
		[Cpp2IlInjected.Address(RVA = "0x543BF20", Offset = "0x543A520", VA = "0x18543BF20", Slot = "12")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000149")]
	public Vector3 KGPDAOIKKOA
	{
		[Cpp2IlInjected.Token(Token = "0x60004F1")]
		[Cpp2IlInjected.Address(RVA = "0x543AE50", Offset = "0x5439450", VA = "0x18543AE50", Slot = "13")]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x60004F2")]
		[Cpp2IlInjected.Address(RVA = "0x543AFC0", Offset = "0x54395C0", VA = "0x18543AFC0", Slot = "14")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700014A")]
	public Quaternion GADCINNEPIK
	{
		[Cpp2IlInjected.Token(Token = "0x60004F3")]
		[Cpp2IlInjected.Address(RVA = "0x543C250", Offset = "0x543A850", VA = "0x18543C250", Slot = "15")]
		get
		{
			return default(Quaternion);
		}
		[Cpp2IlInjected.Token(Token = "0x60004F4")]
		[Cpp2IlInjected.Address(RVA = "0x543BF40", Offset = "0x543A540", VA = "0x18543BF40", Slot = "16")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700014B")]
	private Rigidbody BKIDAKAFFMP
	{
		[Cpp2IlInjected.Token(Token = "0x60004FC")]
		[Cpp2IlInjected.Address(RVA = "0x543B160", Offset = "0x5439760", VA = "0x18543B160")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400004B")]
	public event HOBHPHAMKBD HHGAGCIOJJG
	{
		[Cpp2IlInjected.Token(Token = "0x60004E8")]
		[Cpp2IlInjected.Address(RVA = "0x543D600", Offset = "0x543BC00", VA = "0x18543D600", Slot = "5")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60004E9")]
		[Cpp2IlInjected.Address(RVA = "0x543D480", Offset = "0x543BA80", VA = "0x18543D480", Slot = "6")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60004F5")]
	[Cpp2IlInjected.Address(RVA = "0x543D820", Offset = "0x543BE20", VA = "0x18543D820")]
	public CJCNFKFOMPE(FFCGIONKJBI FHCKPPNILHO, in IMECCMKFBII JIHCLPECHIB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004F6")]
	[Cpp2IlInjected.Address(RVA = "0x543B5E0", Offset = "0x5439BE0", VA = "0x18543B5E0", Slot = "18")]
	public void CAALKOKEPPD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004F7")]
	[Cpp2IlInjected.Address(RVA = "0x543B2B0", Offset = "0x54398B0", VA = "0x18543B2B0", Slot = "17")]
	public void BANKNELMPFP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004F8")]
	[Cpp2IlInjected.Address(RVA = "0x543D520", Offset = "0x543BB20", VA = "0x18543D520", Slot = "20")]
	public void KDPOLAHOOPE(Rigidbody MKOMGOCHBJC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004F9")]
	[Cpp2IlInjected.Address(RVA = "0x543BC60", Offset = "0x543A260", VA = "0x18543BC60", Slot = "21")]
	public void DIDIIBMEDJD(Rigidbody MKOMGOCHBJC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004FA")]
	[Cpp2IlInjected.Address(RVA = "0x543C0E0", Offset = "0x543A6E0", VA = "0x18543C0E0", Slot = "19")]
	public void GAANFDFDMKC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004FB")]
	[Cpp2IlInjected.Address(RVA = "0x543B7A0", Offset = "0x5439DA0", VA = "0x18543B7A0", Slot = "22")]
	public void DFDCFAGILJM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004FD")]
	[Cpp2IlInjected.Address(RVA = "0x543BF00", Offset = "0x543A500", VA = "0x18543BF00")]
	private void EDLHINCKBGC(Vector3 MAKFNMHIJIF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004FE")]
	[Cpp2IlInjected.Address(RVA = "0x543B4F0", Offset = "0x5439AF0", VA = "0x18543B4F0")]
	private Vector3 BKOHCPKDCEP()
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x60004FF")]
	[Cpp2IlInjected.Address(RVA = "0x543C3C0", Offset = "0x543A9C0", VA = "0x18543C3C0")]
	private void NFOOMMJHALN(float MAKFNMHIJIF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000500")]
	[Cpp2IlInjected.Address(RVA = "0x543BF20", Offset = "0x543A520", VA = "0x18543BF20")]
	private void NGBNHFHHKHB(float MAKFNMHIJIF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000501")]
	[Cpp2IlInjected.Address(RVA = "0x543D6A0", Offset = "0x543BCA0", VA = "0x18543D6A0")]
	private Vector3 MHIHKHCHKBK()
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000502")]
	[Cpp2IlInjected.Address(RVA = "0x543AFC0", Offset = "0x54395C0", VA = "0x18543AFC0")]
	private void MEKMDDFDCDF(Vector3 MAKFNMHIJIF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000503")]
	[Cpp2IlInjected.Address(RVA = "0x543B390", Offset = "0x5439990", VA = "0x18543B390")]
	private Quaternion BJFOMIEDANP()
	{
		return default(Quaternion);
	}

	[Cpp2IlInjected.Token(Token = "0x6000504")]
	[Cpp2IlInjected.Address(RVA = "0x543BF40", Offset = "0x543A540", VA = "0x18543BF40")]
	private void NBKELJCOCGM(Quaternion MAKFNMHIJIF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000505")]
	[Cpp2IlInjected.Address(RVA = "0x543D3A0", Offset = "0x543B9A0", VA = "0x18543D3A0")]
	public void JIKMNOJPHEP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000506")]
	[Cpp2IlInjected.Address(RVA = "0x543C4E0", Offset = "0x543AAE0", VA = "0x18543C4E0", Slot = "4")]
	public (float, Vector3) JIKMNOJPHEP(Rigidbody KBIMEMIPFEL)
	{
		return default((float, Vector3));
	}
}
[Cpp2IlInjected.Token(Token = "0x2000054")]
internal static class HBFIMKIJMLB
{
	[Cpp2IlInjected.Token(Token = "0x6000507")]
	[Cpp2IlInjected.Address(RVA = "0x5445CA0", Offset = "0x54442A0", VA = "0x185445CA0")]
	public static MIHKGHPJGIN GEGGBHNBONP(this FFCGIONKJBI BMFGKMDOFCF)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000055")]
internal sealed class BHDNIMBMBIN : CMCPDJMPOKN
{
	[Cpp2IlInjected.Token(Token = "0x40000AA")]
	private const string PDLLOKAFLJL = "INTERP_PAUSE";

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000AB")]
	private readonly NMHAAMBBHKD FHCKPPNILHO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000AC")]
	private readonly ADNKCEEOLDO FFGNEMEMIPN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000AD")]
	private readonly MGONBPIMIEF BKKPLIKBIMJ;

	[Cpp2IlInjected.Token(Token = "0x1700014C")]
	public bool NBDADIFMHHK
	{
		[Cpp2IlInjected.Token(Token = "0x6000508")]
		[Cpp2IlInjected.Address(RVA = "0x2408F60", Offset = "0x2407560", VA = "0x182408F60", Slot = "4")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700014D")]
	public MGONBPIMIEF AIAKBOMPCEL
	{
		[Cpp2IlInjected.Token(Token = "0x6000509")]
		[Cpp2IlInjected.Address(RVA = "0x70F350", Offset = "0x70D950", VA = "0x18070F350", Slot = "5")]
		get
		{
			return default(MGONBPIMIEF);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600050A")]
	[Cpp2IlInjected.Address(RVA = "0x543A020", Offset = "0x5438620", VA = "0x18543A020")]
	public BHDNIMBMBIN(FFCGIONKJBI FHCKPPNILHO, in IMECCMKFBII JIHCLPECHIB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600050B")]
	[Cpp2IlInjected.Address(RVA = "0x5439E20", Offset = "0x5438420", VA = "0x185439E20", Slot = "6")]
	public void NOMIHBFFLNG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600050C")]
	[Cpp2IlInjected.Address(RVA = "0x5439D80", Offset = "0x5438380", VA = "0x185439D80")]
	private bool MLCFJHLPAFK()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600050D")]
	[Cpp2IlInjected.Address(RVA = "0x5439BD0", Offset = "0x54381D0", VA = "0x185439BD0", Slot = "7")]
	public void FCLIOEABILH(object HKLDIENGNNB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600050E")]
	[Cpp2IlInjected.Address(RVA = "0x5439C40", Offset = "0x5438240", VA = "0x185439C40", Slot = "8")]
	public void HFELMDDPCOH(object HKLDIENGNNB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600050F")]
	[Cpp2IlInjected.Address(RVA = "0x5439EF0", Offset = "0x54384F0", VA = "0x185439EF0", Slot = "11")]
	public void OLOGEBHENON()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000510")]
	[Cpp2IlInjected.Address(RVA = "0x5439C70", Offset = "0x5438270", VA = "0x185439C70")]
	private void MDLEKMKMEOD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000511")]
	[Cpp2IlInjected.Address(RVA = "0x5439A10", Offset = "0x5438010", VA = "0x185439A10")]
	private void BLBJEECBPFI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000512")]
	[Cpp2IlInjected.Address(RVA = "0x5439B90", Offset = "0x5438190", VA = "0x185439B90", Slot = "10")]
	public void DAHMBDFDEKP(FFCGIONKJBI FHCKPPNILHO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000513")]
	[Cpp2IlInjected.Address(RVA = "0x5439C00", Offset = "0x5438200", VA = "0x185439C00", Slot = "9")]
	public void GJFLJCFCCKJ(FFCGIONKJBI FHCKPPNILHO)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000056")]
internal sealed class PFDBAPLBKJG : MAMDKJFPNFM
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000AF")]
	private readonly NMHAAMBBHKD FHCKPPNILHO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000B0")]
	private readonly ADNKCEEOLDO FLLFIPFKCGD;

	[Cpp2IlInjected.Token(Token = "0x1700014E")]
	public bool DEHDGKEMKCA
	{
		[Cpp2IlInjected.Token(Token = "0x6000516")]
		[Cpp2IlInjected.Address(RVA = "0x1CB79F0", Offset = "0x1CB5FF0", VA = "0x181CB79F0", Slot = "6")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700014F")]
	public IEnumerable<object> JCMEBGAMNHL
	{
		[Cpp2IlInjected.Token(Token = "0x6000517")]
		[Cpp2IlInjected.Address(RVA = "0x1CB75A0", Offset = "0x1CB5BA0", VA = "0x181CB75A0", Slot = "7")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400004C")]
	public event HOBHPHAMKBD EOJIPPCPFCI
	{
		[Cpp2IlInjected.Token(Token = "0x6000514")]
		[Cpp2IlInjected.Address(RVA = "0x1CB75C0", Offset = "0x1CB5BC0", VA = "0x181CB75C0", Slot = "4")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000515")]
		[Cpp2IlInjected.Address(RVA = "0x1CB78D0", Offset = "0x1CB5ED0", VA = "0x181CB78D0", Slot = "5")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000518")]
	[Cpp2IlInjected.Address(RVA = "0x1CB7A80", Offset = "0x1CB6080", VA = "0x181CB7A80")]
	public PFDBAPLBKJG(FFCGIONKJBI FHCKPPNILHO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000519")]
	[Cpp2IlInjected.Address(RVA = "0x1CB7870", Offset = "0x1CB5E70", VA = "0x181CB7870", Slot = "11")]
	public IDisposable IFKNDGBNBEF()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600051A")]
	[Cpp2IlInjected.Address(RVA = "0x1CB7790", Offset = "0x1CB5D90", VA = "0x181CB7790", Slot = "8")]
	public void FKOFNEMGINM(object HKLDIENGNNB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600051B")]
	[Cpp2IlInjected.Address(RVA = "0x1CB7590", Offset = "0x1CB5B90", VA = "0x181CB7590", Slot = "9")]
	public void BEHGOGKEFEN(object HKLDIENGNNB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600051C")]
	[Cpp2IlInjected.Address(RVA = "0x1CB7690", Offset = "0x1CB5C90", VA = "0x181CB7690", Slot = "10")]
	public void DLBAIGNALBD(object HKLDIENGNNB, bool BKHDMOGADPG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600051D")]
	[Cpp2IlInjected.Address(RVA = "0x1CB7970", Offset = "0x1CB5F70", VA = "0x181CB7970", Slot = "12")]
	public void KDPOLAHOOPE(Rigidbody CCLEKJNADLB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600051E")]
	[Cpp2IlInjected.Address(RVA = "0x1CB7660", Offset = "0x1CB5C60", VA = "0x181CB7660", Slot = "13")]
	public void DIDIIBMEDJD(Rigidbody MKOMGOCHBJC)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000057")]
internal sealed class LFPJLJOFGND : DAEFAEBHLJK, BHMDAAMOACJ, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000B2")]
	private readonly NMHAAMBBHKD FHCKPPNILHO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000B3")]
	private PhotonView GJEOCFNIENJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40000B4")]
	private bool DMGPKKLEFJO;

	[Cpp2IlInjected.Token(Token = "0x17000150")]
	public PhotonView NJAFHGPCJKE
	{
		[Cpp2IlInjected.Token(Token = "0x6000521")]
		[Cpp2IlInjected.Address(RVA = "0x706620", Offset = "0x704C20", VA = "0x180706620", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000151")]
	public bool BKKAMGPIPMG
	{
		[Cpp2IlInjected.Token(Token = "0x6000522")]
		[Cpp2IlInjected.Address(RVA = "0x543DD90", Offset = "0x543C390", VA = "0x18543DD90", Slot = "7")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000152")]
	public bool OFHGFFKKEMJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000523")]
		[Cpp2IlInjected.Address(RVA = "0x84A610", Offset = "0x848C10", VA = "0x18084A610", Slot = "8")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400004D")]
	public event HOBHPHAMKBD IBIGIAONNFK
	{
		[Cpp2IlInjected.Token(Token = "0x600051F")]
		[Cpp2IlInjected.Address(RVA = "0x5452D40", Offset = "0x5451340", VA = "0x185452D40", Slot = "5")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000520")]
		[Cpp2IlInjected.Address(RVA = "0x5452CA0", Offset = "0x54512A0", VA = "0x185452CA0", Slot = "6")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000524")]
	[Cpp2IlInjected.Address(RVA = "0x5453630", Offset = "0x5451C30", VA = "0x185453630")]
	public LFPJLJOFGND(FFCGIONKJBI FHCKPPNILHO, in IMECCMKFBII JIHCLPECHIB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000525")]
	[Cpp2IlInjected.Address(RVA = "0x5453370", Offset = "0x5451970", VA = "0x185453370", Slot = "9")]
	public void NOMIHBFFLNG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000526")]
	[Cpp2IlInjected.Address(RVA = "0x5452B90", Offset = "0x5451190", VA = "0x185452B90", Slot = "12")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000527")]
	[Cpp2IlInjected.Address(RVA = "0x5453060", Offset = "0x5451660", VA = "0x185453060", Slot = "10")]
	public void MELFMEBHFAF(FFCGIONKJBI LFAIGCEGCPL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000528")]
	[Cpp2IlInjected.Address(RVA = "0x5452A00", Offset = "0x5451000", VA = "0x185452A00", Slot = "11")]
	public void BLHLKMFLDGD(FFCGIONKJBI LFAIGCEGCPL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000529")]
	[Cpp2IlInjected.Address(RVA = "0x54531F0", Offset = "0x54517F0", VA = "0x1854531F0")]
	private void NGOCABNBNDE(PhotonView MJGOFLGOOBD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600052A")]
	[Cpp2IlInjected.Address(RVA = "0x54534C0", Offset = "0x5451AC0", VA = "0x1854534C0")]
	private void OHFDKKBKPFB(RigidbodyEx NAKLMJNOFNJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600052B")]
	[Cpp2IlInjected.Address(RVA = "0x5452DE0", Offset = "0x54513E0", VA = "0x185452DE0")]
	private void JOPMEJPILKG(PhotonView PAFPMHNEHHP)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000058")]
internal static class NCIICMKGFLG
{
	[Cpp2IlInjected.Token(Token = "0x600052C")]
	[Cpp2IlInjected.Address(RVA = "0x5453ED0", Offset = "0x54524D0", VA = "0x185453ED0")]
	public static DAEFAEBHLJK BEFAHGEGGKH(this FFCGIONKJBI BMFGKMDOFCF)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000059")]
internal sealed class DDNJOPKCDIK : KPBILAHOHAH
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000B5")]
	private readonly NMHAAMBBHKD FHCKPPNILHO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000B6")]
	private RigidbodyConstraints ILIMCMHHIEN;

	[Cpp2IlInjected.Token(Token = "0x17000153")]
	public bool IELKFNIBHFB
	{
		[Cpp2IlInjected.Token(Token = "0x600052D")]
		[Cpp2IlInjected.Address(RVA = "0x8ADFD0", Offset = "0x8AC5D0", VA = "0x1808ADFD0", Slot = "4")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x600052E")]
		[Cpp2IlInjected.Address(RVA = "0x87D1B0", Offset = "0x87B7B0", VA = "0x18087D1B0", Slot = "5")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000154")]
	public bool FDKFFCJABEN
	{
		[Cpp2IlInjected.Token(Token = "0x600052F")]
		[Cpp2IlInjected.Address(RVA = "0x168AC30", Offset = "0x1689230", VA = "0x18168AC30", Slot = "6")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000530")]
		[Cpp2IlInjected.Address(RVA = "0x168A780", Offset = "0x1688D80", VA = "0x18168A780")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000155")]
	public RigidbodyConstraints AKGJCKADCBH
	{
		[Cpp2IlInjected.Token(Token = "0x6000531")]
		[Cpp2IlInjected.Address(RVA = "0x6BA600", Offset = "0x6B8C00", VA = "0x1806BA600", Slot = "7")]
		get
		{
			return default(RigidbodyConstraints);
		}
		[Cpp2IlInjected.Token(Token = "0x6000532")]
		[Cpp2IlInjected.Address(RVA = "0x5440E80", Offset = "0x543F480", VA = "0x185440E80", Slot = "8")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000533")]
	[Cpp2IlInjected.Address(RVA = "0x5441020", Offset = "0x543F620", VA = "0x185441020")]
	public DDNJOPKCDIK(FFCGIONKJBI FHCKPPNILHO, in IMECCMKFBII JIHCLPECHIB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000534")]
	[Cpp2IlInjected.Address(RVA = "0x5440FF0", Offset = "0x543F5F0", VA = "0x185440FF0", Slot = "9")]
	public void KDPOLAHOOPE(Rigidbody MKOMGOCHBJC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000535")]
	[Cpp2IlInjected.Address(RVA = "0x5440FC0", Offset = "0x543F5C0", VA = "0x185440FC0", Slot = "10")]
	public void DIDIIBMEDJD(Rigidbody MKOMGOCHBJC)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200005A")]
internal sealed class EDBLKIEJLBE : EKNFOOIEIBK
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000B9")]
	private readonly FFCGIONKJBI FHCKPPNILHO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000BA")]
	private float ELGKPJENLOI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
	[Cpp2IlInjected.Token(Token = "0x40000BB")]
	private float CHHDLHAEMBC;

	[Cpp2IlInjected.Token(Token = "0x17000156")]
	public float KDAOPIJAMOB
	{
		[Cpp2IlInjected.Token(Token = "0x6000537")]
		[Cpp2IlInjected.Address(RVA = "0x9F86F0", Offset = "0x9F6CF0", VA = "0x1809F86F0", Slot = "4")]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x6000538")]
		[Cpp2IlInjected.Address(RVA = "0x5442050", Offset = "0x5440650", VA = "0x185442050", Slot = "5")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000157")]
	public float FEGLLEJAJOH
	{
		[Cpp2IlInjected.Token(Token = "0x6000539")]
		[Cpp2IlInjected.Address(RVA = "0xA24840", Offset = "0xA22E40", VA = "0x180A24840", Slot = "6")]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x600053A")]
		[Cpp2IlInjected.Address(RVA = "0x54421C0", Offset = "0x54407C0", VA = "0x1854421C0", Slot = "7")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000536")]
	[Cpp2IlInjected.Address(RVA = "0x54422E0", Offset = "0x54408E0", VA = "0x1854422E0")]
	public EDBLKIEJLBE(FFCGIONKJBI FHCKPPNILHO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600053B")]
	[Cpp2IlInjected.Address(RVA = "0x5442290", Offset = "0x5440890", VA = "0x185442290", Slot = "8")]
	public void KDPOLAHOOPE(Rigidbody MKOMGOCHBJC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600053C")]
	[Cpp2IlInjected.Address(RVA = "0x5442120", Offset = "0x5440720", VA = "0x185442120", Slot = "9")]
	public void DIDIIBMEDJD(Rigidbody MKOMGOCHBJC)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200005B")]
internal sealed class FMDIKMBJBMA : MNHBOEHCOIK
{
	[Cpp2IlInjected.Token(Token = "0x40000BC")]
	private const int KPHOMKKJGAI = 10;

	[Cpp2IlInjected.Token(Token = "0x40000BD")]
	private const float EDBEMPEMOMA = 9E-05f;

	[Cpp2IlInjected.Token(Token = "0x40000BE")]
	private const float GGLNEEMIJHI = 0.0001f;

	[Cpp2IlInjected.Token(Token = "0x40000BF")]
	private const float HJJLBLIFGJP = 5f;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000C1")]
	private readonly NMHAAMBBHKD FHCKPPNILHO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000C2")]
	private bool GDNNLAJJIKO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x21")]
	[Cpp2IlInjected.Token(Token = "0x40000C3")]
	private bool DKNHDCFNOIN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
	[Cpp2IlInjected.Token(Token = "0x40000C4")]
	private int HHNNDCDGJHA;

	[Cpp2IlInjected.Token(Token = "0x17000158")]
	private Rigidbody BKIDAKAFFMP
	{
		[Cpp2IlInjected.Token(Token = "0x600053F")]
		[Cpp2IlInjected.Address(RVA = "0x543B160", Offset = "0x5439760", VA = "0x18543B160")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000159")]
	private bool IALJHIOHBON
	{
		[Cpp2IlInjected.Token(Token = "0x6000540")]
		[Cpp2IlInjected.Address(RVA = "0x54443A0", Offset = "0x54429A0", VA = "0x1854443A0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700015A")]
	private bool CEDDMPPAJDO
	{
		[Cpp2IlInjected.Token(Token = "0x6000541")]
		[Cpp2IlInjected.Address(RVA = "0x54441F0", Offset = "0x54427F0", VA = "0x1854441F0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700015B")]
	private FFCGIONKJBI HDIMMFJBNPK
	{
		[Cpp2IlInjected.Token(Token = "0x6000542")]
		[Cpp2IlInjected.Address(RVA = "0x5443FE0", Offset = "0x54425E0", VA = "0x185443FE0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700015C")]
	private bool CAIEJEMCAII
	{
		[Cpp2IlInjected.Token(Token = "0x6000543")]
		[Cpp2IlInjected.Address(RVA = "0x5444AE0", Offset = "0x54430E0", VA = "0x185444AE0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400004E")]
	public event HOBHPHAMKBD IHIJNHOELAG
	{
		[Cpp2IlInjected.Token(Token = "0x600053D")]
		[Cpp2IlInjected.Address(RVA = "0x5443EA0", Offset = "0x54424A0", VA = "0x185443EA0", Slot = "4")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600053E")]
		[Cpp2IlInjected.Address(RVA = "0x5444A40", Offset = "0x5443040", VA = "0x185444A40", Slot = "5")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000544")]
	[Cpp2IlInjected.Address(RVA = "0x5444B40", Offset = "0x5443140", VA = "0x185444B40")]
	public FMDIKMBJBMA(FFCGIONKJBI FHCKPPNILHO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000545")]
	[Cpp2IlInjected.Address(RVA = "0x54449B0", Offset = "0x5442FB0", VA = "0x1854449B0", Slot = "6")]
	public void NOMIHBFFLNG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000546")]
	[Cpp2IlInjected.Address(RVA = "0x54447B0", Offset = "0x5442DB0", VA = "0x1854447B0", Slot = "8")]
	public void JPLMLMHPLJA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000547")]
	[Cpp2IlInjected.Address(RVA = "0x5444860", Offset = "0x5442E60", VA = "0x185444860", Slot = "7")]
	public bool MNIMMDJAIIP()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000548")]
	[Cpp2IlInjected.Address(RVA = "0x5443F40", Offset = "0x5442540", VA = "0x185443F40", Slot = "9")]
	public void ALKMJGDDHDA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000549")]
	[Cpp2IlInjected.Address(RVA = "0x54447C0", Offset = "0x5442DC0", VA = "0x1854447C0", Slot = "11")]
	public void LEMLLHIPKGE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600054A")]
	[Cpp2IlInjected.Address(RVA = "0x5444440", Offset = "0x5442A40", VA = "0x185444440", Slot = "12")]
	public void HKDHIFCLEOH(bool HBGILCDGAGC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600054B")]
	[Cpp2IlInjected.Address(RVA = "0x5444480", Offset = "0x5442A80", VA = "0x185444480", Slot = "10")]
	public void HOBDPIODPAL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600054C")]
	[Cpp2IlInjected.Address(RVA = "0x5444040", Offset = "0x5442640", VA = "0x185444040")]
	private bool FCFJIFCJPMN()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600054D")]
	[Cpp2IlInjected.Address(RVA = "0x5444210", Offset = "0x5442810", VA = "0x185444210")]
	private void GMGFEAJPFOF()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200005C")]
internal sealed class IBJENOEEHPD : OOPDNBAAJIE
{
	[Cpp2IlInjected.Token(Token = "0x40000C5")]
	private const string NLBEODMOBCK = "RBEX_ANIM";

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000C6")]
	private readonly NMHAAMBBHKD FHCKPPNILHO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000C7")]
	private readonly ADNKCEEOLDO ABCGICGINMF;

	[Cpp2IlInjected.Token(Token = "0x1700015D")]
	public Rigidbody BKIDAKAFFMP
	{
		[Cpp2IlInjected.Token(Token = "0x600054E")]
		[Cpp2IlInjected.Address(RVA = "0x706620", Offset = "0x704C20", VA = "0x180706620", Slot = "4")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600054F")]
		[Cpp2IlInjected.Address(RVA = "0x70DB30", Offset = "0x70C130", VA = "0x18070DB30")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700015E")]
	private bool CAIEJEMCAII
	{
		[Cpp2IlInjected.Token(Token = "0x6000550")]
		[Cpp2IlInjected.Address(RVA = "0x5437180", Offset = "0x5435780", VA = "0x185437180")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000551")]
	[Cpp2IlInjected.Address(RVA = "0x5449750", Offset = "0x5447D50", VA = "0x185449750")]
	public IBJENOEEHPD(FFCGIONKJBI FHCKPPNILHO, in IMECCMKFBII JIHCLPECHIB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000552")]
	[Cpp2IlInjected.Address(RVA = "0x54496A0", Offset = "0x5447CA0", VA = "0x1854496A0", Slot = "5")]
	public void NOMIHBFFLNG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000553")]
	[Cpp2IlInjected.Address(RVA = "0x5449140", Offset = "0x5447740", VA = "0x185449140", Slot = "6")]
	public void HCDCAKONHKH(object HKLDIENGNNB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000554")]
	[Cpp2IlInjected.Address(RVA = "0x5448760", Offset = "0x5446D60", VA = "0x185448760", Slot = "7")]
	public void ANODKIPNKGG(object HKLDIENGNNB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000555")]
	[Cpp2IlInjected.Address(RVA = "0x5448790", Offset = "0x5446D90", VA = "0x185448790", Slot = "8")]
	public void CHKIFMMFIIK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000556")]
	[Cpp2IlInjected.Address(RVA = "0x5449170", Offset = "0x5447770", VA = "0x185449170", Slot = "9")]
	public void JEGLELMGMOF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000557")]
	[Cpp2IlInjected.Address(RVA = "0x5449520", Offset = "0x5447B20", VA = "0x185449520", Slot = "10")]
	public void NFMKBGIADML()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000558")]
	[Cpp2IlInjected.Address(RVA = "0x5448CA0", Offset = "0x54472A0", VA = "0x185448CA0", Slot = "11")]
	public void DHPOOPPINJB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000559")]
	[Cpp2IlInjected.Address(RVA = "0x5448AF0", Offset = "0x54470F0", VA = "0x185448AF0")]
	private void CPKMCFBJNFD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600055A")]
	[Cpp2IlInjected.Address(RVA = "0x5449370", Offset = "0x5447970", VA = "0x185449370")]
	private void NDFBDKFJEON()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200005D")]
internal sealed class IHMHMODNCOJ : GLBLEGFKOKL, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000C9")]
	private readonly NMHAAMBBHKD FHCKPPNILHO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000CA")]
	private readonly ADNKCEEOLDO GDNONOPJFKJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000CB")]
	private float JBGGBKDLDAD;

	[Cpp2IlInjected.Token(Token = "0x1700015F")]
	public IIENCNCJIKK OEBLLEKPOOI
	{
		[Cpp2IlInjected.Token(Token = "0x600055B")]
		[Cpp2IlInjected.Address(RVA = "0x681C00", Offset = "0x680200", VA = "0x180681C00", Slot = "4")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600055C")]
		[Cpp2IlInjected.Address(RVA = "0x77C760", Offset = "0x77AD60", VA = "0x18077C760", Slot = "5")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000160")]
	public JGKAIJBBCDC KPBINMPEPCH
	{
		[Cpp2IlInjected.Token(Token = "0x600055D")]
		[Cpp2IlInjected.Address(RVA = "0x67A0D0", Offset = "0x6786D0", VA = "0x18067A0D0", Slot = "6")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600055E")]
		[Cpp2IlInjected.Address(RVA = "0x7E5D70", Offset = "0x7E4370", VA = "0x1807E5D70", Slot = "7")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000161")]
	public Vector3 OMPLHOFEJAN
	{
		[Cpp2IlInjected.Token(Token = "0x600055F")]
		[Cpp2IlInjected.Address(RVA = "0x544DFA0", Offset = "0x544C5A0", VA = "0x18544DFA0", Slot = "8")]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x6000560")]
		[Cpp2IlInjected.Address(RVA = "0x544E710", Offset = "0x544CD10", VA = "0x18544E710", Slot = "9")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000162")]
	public Vector3 BOJDMEIPMAO
	{
		[Cpp2IlInjected.Token(Token = "0x6000561")]
		[Cpp2IlInjected.Address(RVA = "0x544F060", Offset = "0x544D660", VA = "0x18544F060", Slot = "10")]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x6000562")]
		[Cpp2IlInjected.Address(RVA = "0x544E390", Offset = "0x544C990", VA = "0x18544E390", Slot = "11")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000163")]
	public Vector3 IPICDHHHJOG
	{
		[Cpp2IlInjected.Token(Token = "0x6000563")]
		[Cpp2IlInjected.Address(RVA = "0x544DCF0", Offset = "0x544C2F0", VA = "0x18544DCF0", Slot = "12")]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x6000564")]
		[Cpp2IlInjected.Address(RVA = "0x544EC30", Offset = "0x544D230", VA = "0x18544EC30", Slot = "13")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000164")]
	public Vector3 DALJIIPOFIE
	{
		[Cpp2IlInjected.Token(Token = "0x6000565")]
		[Cpp2IlInjected.Address(RVA = "0x544D240", Offset = "0x544B840", VA = "0x18544D240", Slot = "14")]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x6000566")]
		[Cpp2IlInjected.Address(RVA = "0x544D1A0", Offset = "0x544B7A0", VA = "0x18544D1A0", Slot = "15")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000165")]
	public float KJKDBCBOHIJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000567")]
		[Cpp2IlInjected.Address(RVA = "0x73E3C0", Offset = "0x73C9C0", VA = "0x18073E3C0", Slot = "16")]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x6000568")]
		[Cpp2IlInjected.Address(RVA = "0x544E3C0", Offset = "0x544C9C0", VA = "0x18544E3C0", Slot = "17")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000166")]
	public bool NKPLDABKJCL
	{
		[Cpp2IlInjected.Token(Token = "0x6000569")]
		[Cpp2IlInjected.Address(RVA = "0x2E30A60", Offset = "0x2E2F060", VA = "0x182E30A60", Slot = "18")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000167")]
	private GIGBMEPJFND IPDPPPGBPIC
	{
		[Cpp2IlInjected.Token(Token = "0x600057E")]
		[Cpp2IlInjected.Address(RVA = "0x2CB3860", Offset = "0x2CB1E60", VA = "0x182CB3860")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000168")]
	private bool CEDDMPPAJDO
	{
		[Cpp2IlInjected.Token(Token = "0x600057F")]
		[Cpp2IlInjected.Address(RVA = "0x5434200", Offset = "0x5432800", VA = "0x185434200")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600056A")]
	[Cpp2IlInjected.Address(RVA = "0x544FE90", Offset = "0x544E490", VA = "0x18544FE90")]
	public IHMHMODNCOJ(FFCGIONKJBI FHCKPPNILHO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600056B")]
	[Cpp2IlInjected.Address(RVA = "0x544D1D0", Offset = "0x544B7D0", VA = "0x18544D1D0", Slot = "19")]
	public void NOMIHBFFLNG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600056C")]
	[Cpp2IlInjected.Address(RVA = "0x544DE20", Offset = "0x544C420", VA = "0x18544DE20", Slot = "37")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600056D")]
	[Cpp2IlInjected.Address(RVA = "0x544EB00", Offset = "0x544D100", VA = "0x18544EB00", Slot = "28")]
	public void KDPOLAHOOPE(Rigidbody MKOMGOCHBJC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600056E")]
	[Cpp2IlInjected.Address(RVA = "0x1DCC330", Offset = "0x1DCA930", VA = "0x181DCC330", Slot = "20")]
	public void OGEMIEDCOED(object HKLDIENGNNB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600056F")]
	[Cpp2IlInjected.Address(RVA = "0x1DCBBA0", Offset = "0x1DCA1A0", VA = "0x181DCBBA0", Slot = "31")]
	public void LPJEFBBEPMD(object HKLDIENGNNB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000570")]
	[Cpp2IlInjected.Address(RVA = "0x544F150", Offset = "0x544D750", VA = "0x18544F150", Slot = "36")]
	public Vector3 LKOKGKNLODE(Vector3 JMLACAFKJOF)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000571")]
	[Cpp2IlInjected.Address(RVA = "0x544FBE0", Offset = "0x544E1E0", VA = "0x18544FBE0", Slot = "35")]
	public Vector3 PIFFFCJGHPG(Vector3 OLLLCEPAFHE)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000572")]
	[Cpp2IlInjected.Address(RVA = "0x544D1D0", Offset = "0x544B7D0", VA = "0x18544D1D0", Slot = "27")]
	public void BCKDLBEFMPH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000573")]
	[Cpp2IlInjected.Address(RVA = "0x544FBA0", Offset = "0x544E1A0", VA = "0x18544FBA0", Slot = "25")]
	public void NLLIBPNNBGH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000574")]
	[Cpp2IlInjected.Address(RVA = "0x544FB60", Offset = "0x544E160", VA = "0x18544FB60", Slot = "24")]
	public void NFCJHIFEHGE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000575")]
	[Cpp2IlInjected.Address(RVA = "0x544ECF0", Offset = "0x544D2F0", VA = "0x18544ECF0", Slot = "34")]
	public void KPJAOLBLIEI(Vector3 PFDFFPLAJJP, Vector3 HGIFCPKBAGG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000576")]
	[Cpp2IlInjected.Address(RVA = "0x544DE80", Offset = "0x544C480", VA = "0x18544DE80", Slot = "33")]
	public void EBKBGNAGIOD(Vector3 LOGKBIHCFJD, Vector3 OGPMEJLJLFA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000577")]
	[Cpp2IlInjected.Address(RVA = "0x544DBB0", Offset = "0x544C1B0", VA = "0x18544DBB0", Slot = "32")]
	public void DNAJDFGLENG(Vector3 OANHHGBFKAN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000578")]
	[Cpp2IlInjected.Address(RVA = "0x544D330", Offset = "0x544B930", VA = "0x18544D330", Slot = "22")]
	public void CBHLOBJDACM(CKAOOODELAE IKFPEHIFEPN, Vector3 NMBFBKMEJKN, float FEHHFHACKBK, float IOFMPFNPHNC = 8f, float JKLGNKAKKLG = 1f)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000579")]
	[Cpp2IlInjected.Address(RVA = "0x544F330", Offset = "0x544D930", VA = "0x18544F330", Slot = "21")]
	public void NCIJALPIGCE(MCMFGEDCCGC LMLMHHPMBJO, Vector3 OFLGCJLDNJJ, float IPAPNFBMGEF = float.PositiveInfinity)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600057A")]
	[Cpp2IlInjected.Address(RVA = "0x544E0C0", Offset = "0x544C6C0", VA = "0x18544E0C0", Slot = "23")]
	[Obsolete]
	public void FDJHKHJGOHO(MCMFGEDCCGC LMLMHHPMBJO, Vector3 JGCPJBFFFAC, float NMBEKOOKPJA = 7f, float MFBAPHBIEKM = 1f)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600057B")]
	[Cpp2IlInjected.Address(RVA = "0x544D0E0", Offset = "0x544B6E0", VA = "0x18544D0E0", Slot = "30")]
	public Vector3 AJLBGCPJCKN(Vector3 CPHPLAEKCBK)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x600057C")]
	[Cpp2IlInjected.Address(RVA = "0x544FDA0", Offset = "0x544E3A0", VA = "0x18544FDA0", Slot = "29")]
	public Vector3 PIFNCDNOKAD(Vector3 HOLPFINNOLF)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x600057D")]
	[Cpp2IlInjected.Address(RVA = "0x544EF30", Offset = "0x544D530", VA = "0x18544EF30", Slot = "26")]
	public void LADPNNADDEK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000580")]
	[Cpp2IlInjected.Address(RVA = "0x544E3C0", Offset = "0x544C9C0", VA = "0x18544E3C0")]
	private void GKNBMLJEJOF(float MAKFNMHIJIF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000581")]
	[Cpp2IlInjected.Address(RVA = "0x544E5D0", Offset = "0x544CBD0", VA = "0x18544E5D0")]
	private void JEPNOFCGPGB(Vector3 OFLGCJLDNJJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000582")]
	[Cpp2IlInjected.Address(RVA = "0x544E4E0", Offset = "0x544CAE0", VA = "0x18544E4E0")]
	private Vector3 JAOHNCJGCMP()
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000583")]
	[Cpp2IlInjected.Address(RVA = "0x544E7D0", Offset = "0x544CDD0", VA = "0x18544E7D0")]
	private void JHJGANJBJGJ(Vector3 OLLLCEPAFHE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000584")]
	[Cpp2IlInjected.Address(RVA = "0x544D780", Offset = "0x544BD80", VA = "0x18544D780")]
	private Vector3 CHBOIJCOGNN()
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000585")]
	[Cpp2IlInjected.Address(RVA = "0x544D870", Offset = "0x544BE70", VA = "0x18544D870")]
	private void DEJPPLEHGBP(Vector3 MAKFNMHIJIF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000586")]
	[Cpp2IlInjected.Address(RVA = "0x544F560", Offset = "0x544DB60", VA = "0x18544F560")]
	private void NDFOCMJNPHI(Vector3 OLLLCEPAFHE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000587")]
	[Cpp2IlInjected.Address(RVA = "0x544DEE0", Offset = "0x544C4E0", VA = "0x18544DEE0")]
	private void EIEPCDLOKOO()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200005E")]
public class ONKNKBFAOPG : LGNFMEIAMDG
{
	[Cpp2IlInjected.Token(Token = "0x6000588")]
	[Cpp2IlInjected.Address(RVA = "0x1CB6E90", Offset = "0x1CB5490", VA = "0x181CB6E90", Slot = "4")]
	public IPLGDMEHBOJ JLMEDKOMLPH(FFCGIONKJBI BMFGKMDOFCF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000589")]
	[Cpp2IlInjected.Address(RVA = "0x1CB6C30", Offset = "0x1CB5230", VA = "0x181CB6C30", Slot = "5")]
	public GLBLEGFKOKL FNHIMIMINLC(FFCGIONKJBI BMFGKMDOFCF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600058A")]
	[Cpp2IlInjected.Address(RVA = "0x1CB6E30", Offset = "0x1CB5430", VA = "0x181CB6E30", Slot = "6")]
	public EBAADMBJLMD IIOHLMKEJEJ(FFCGIONKJBI BMFGKMDOFCF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600058B")]
	[Cpp2IlInjected.Address(RVA = "0x1CB6F60", Offset = "0x1CB5560", VA = "0x181CB6F60", Slot = "7")]
	public EKNFOOIEIBK NHGIHLGNLLB(FFCGIONKJBI BMFGKMDOFCF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600058C")]
	[Cpp2IlInjected.Address(RVA = "0x1CB6920", Offset = "0x1CB4F20", VA = "0x181CB6920", Slot = "8")]
	public MNHBOEHCOIK AMEBPOAGMKI(FFCGIONKJBI BMFGKMDOFCF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600058D")]
	[Cpp2IlInjected.Address(RVA = "0x1CB6BD0", Offset = "0x1CB51D0", VA = "0x181CB6BD0", Slot = "9")]
	public CGKAANMHLMI CCKENOLAJIO(FFCGIONKJBI BMFGKMDOFCF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600058E")]
	[Cpp2IlInjected.Address(RVA = "0x1CB6980", Offset = "0x1CB4F80", VA = "0x181CB6980", Slot = "10")]
	public MAMDKJFPNFM AOODCJDCKDB(FFCGIONKJBI BMFGKMDOFCF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600058F")]
	[Cpp2IlInjected.Address(RVA = "0x1CB6DD0", Offset = "0x1CB53D0", VA = "0x181CB6DD0", Slot = "11")]
	public GIGBMEPJFND IIMNBFJLPGA(FFCGIONKJBI BMFGKMDOFCF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000590")]
	[Cpp2IlInjected.Address(RVA = "0x1CB6D00", Offset = "0x1CB5300", VA = "0x181CB6D00", Slot = "12")]
	public MFNEPAJBKBE GLEBFEAEHBH(FFCGIONKJBI BMFGKMDOFCF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000591")]
	[Cpp2IlInjected.Address(RVA = "0x1CB6AB0", Offset = "0x1CB50B0", VA = "0x181CB6AB0", Slot = "13")]
	public JJPLOLDPKDF BBOIPMMNANN(FFCGIONKJBI BMFGKMDOFCF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000592")]
	[Cpp2IlInjected.Address(RVA = "0x1CB6EF0", Offset = "0x1CB54F0", VA = "0x181CB6EF0")]
	public OOPDNBAAJIE LKGBOKHAFIF(FFCGIONKJBI BMFGKMDOFCF, in IMECCMKFBII JIHCLPECHIB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000593")]
	[Cpp2IlInjected.Address(RVA = "0x1CB6D60", Offset = "0x1CB5360", VA = "0x181CB6D60")]
	public BHMDAAMOACJ GLKJADAGIAD(FFCGIONKJBI BMFGKMDOFCF, in IMECCMKFBII JIHCLPECHIB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000594")]
	[Cpp2IlInjected.Address(RVA = "0x1CB6C90", Offset = "0x1CB5290", VA = "0x181CB6C90")]
	public CMCPDJMPOKN FOJJLIDIPCI(FFCGIONKJBI BMFGKMDOFCF, in IMECCMKFBII JIHCLPECHIB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000595")]
	[Cpp2IlInjected.Address(RVA = "0x1CB68B0", Offset = "0x1CB4EB0", VA = "0x181CB68B0")]
	public CHBALODMMNE GLGIJKKAPGN(FFCGIONKJBI BMFGKMDOFCF, in IMECCMKFBII JIHCLPECHIB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000596")]
	[Cpp2IlInjected.Address(RVA = "0x1CB6A40", Offset = "0x1CB5040", VA = "0x181CB6A40")]
	public KPBILAHOHAH ODODIKBAKJK(FFCGIONKJBI BMFGKMDOFCF, in IMECCMKFBII JIHCLPECHIB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000597")]
	[Cpp2IlInjected.Address(RVA = "0x1CB6B20", Offset = "0x1CB5120", VA = "0x181CB6B20", Slot = "19")]
	public FFCGIONKJBI CAKONGBGLCH(RigidbodyEx FHCKPPNILHO, IMECCMKFBII JIHCLPECHIB, MPHIHDCLPDB HKMONJIHHIH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000598")]
	[Cpp2IlInjected.Address(RVA = "0x6A82D0", Offset = "0x6A68D0", VA = "0x1806A82D0")]
	public ONKNKBFAOPG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000599")]
	[Cpp2IlInjected.Address(RVA = "0x1CB6EF0", Offset = "0x1CB54F0", VA = "0x181CB6EF0", Slot = "14")]
	private OOPDNBAAJIE KGODCDCCGDL(FFCGIONKJBI BMFGKMDOFCF, in IMECCMKFBII JIHCLPECHIB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600059A")]
	[Cpp2IlInjected.Address(RVA = "0x1CB6D60", Offset = "0x1CB5360", VA = "0x181CB6D60", Slot = "15")]
	private BHMDAAMOACJ PJPJIFJAEAJ(FFCGIONKJBI BMFGKMDOFCF, in IMECCMKFBII JIHCLPECHIB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600059B")]
	[Cpp2IlInjected.Address(RVA = "0x1CB6C90", Offset = "0x1CB5290", VA = "0x181CB6C90", Slot = "16")]
	private CMCPDJMPOKN IHLIJBJMJOL(FFCGIONKJBI BMFGKMDOFCF, in IMECCMKFBII JIHCLPECHIB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600059C")]
	[Cpp2IlInjected.Address(RVA = "0x1CB68B0", Offset = "0x1CB4EB0", VA = "0x181CB68B0", Slot = "17")]
	private CHBALODMMNE AHPBLOONHKN(FFCGIONKJBI BMFGKMDOFCF, in IMECCMKFBII JIHCLPECHIB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600059D")]
	[Cpp2IlInjected.Address(RVA = "0x1CB6A40", Offset = "0x1CB5040", VA = "0x181CB6A40", Slot = "18")]
	private KPBILAHOHAH APMCPBGPIFH(FFCGIONKJBI BMFGKMDOFCF, in IMECCMKFBII JIHCLPECHIB)
	{
		return null;
	}
}
namespace RRAssemblyIndex.RecRoom.Rbex.Runtime
{
	[Cpp2IlInjected.Token(Token = "0x200005F")]
	[Preserve]
	internal class _RRAssemblyIndex : AHAHNEIKLGP
	{
		[Cpp2IlInjected.Token(Token = "0x600059E")]
		[Cpp2IlInjected.Address(RVA = "0x750020", Offset = "0x74E620", VA = "0x180750020")]
		[Preserve]
		public _RRAssemblyIndex()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600059F")]
		[Cpp2IlInjected.Address(RVA = "0x1CBD550", Offset = "0x1CBBB50", VA = "0x181CBD550", Slot = "6")]
		public sealed override void FHBOKNJGNHA(JGIPCDLBHLE ONHFNOPIIKL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005A0")]
		[Cpp2IlInjected.Address(RVA = "0x1CBD730", Offset = "0x1CBBD30", VA = "0x181CBD730", Slot = "4")]
		public sealed override void GBDHAHIIBFE()
		{
		}
	}
}
[StructLayout((LayoutKind)3, CharSet = CharSet.Auto)]
[Cpp2IlInjected.Token(Token = "0x2000060")]
public class MDBMMECDLKK
{
	[Cpp2IlInjected.Token(Token = "0x40000CE")]
	private static byte[] GADOFMLHAHJ;

	[Cpp2IlInjected.Token(Token = "0x40000CF")]
	private static int HEJKOBPMNOJ;

	[Cpp2IlInjected.Token(Token = "0x40000D0")]
	private static int HLKLMDMLFLE;

	[Cpp2IlInjected.Token(Token = "0x40000D1")]
	private static BigInteger DBAKCFGFCLA;

	[Cpp2IlInjected.Token(Token = "0x60005A1")]
	[Cpp2IlInjected.Address(RVA = "0x6A82D0", Offset = "0x6A68D0", VA = "0x1806A82D0")]
	public MDBMMECDLKK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60005A3")]
	[Cpp2IlInjected.Address(RVA = "0x5453AB0", Offset = "0x54520B0", VA = "0x185453AB0")]
	private static string LLKJKMBGMPE(byte[] LKLEFAIICIC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60005A4")]
	[Cpp2IlInjected.Address(RVA = "0x5453760", Offset = "0x5451D60", VA = "0x185453760")]
	public static string FCKPDHOJNPG(byte[] PPJLGCLGPJE, bool KMFFDGBHCMI)
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

		[Cpp2IlInjected.Token(Token = "0x40000D2")]
		internal static $ArrayType$151 $$field-0;

		[Cpp2IlInjected.Token(Token = "0x60005A5")]
		[Cpp2IlInjected.Address(RVA = "0x6A82D0", Offset = "0x6A68D0", VA = "0x1806A82D0")]
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
