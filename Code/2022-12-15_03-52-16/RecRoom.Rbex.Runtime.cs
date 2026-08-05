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
	[Cpp2IlInjected.Address(RVA = "0x678B30", Offset = "0x677530", VA = "0x180678B30")]
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
		[Cpp2IlInjected.Address(RVA = "0x677040", Offset = "0x675A40", VA = "0x180677040", Slot = "4")]
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
		[Cpp2IlInjected.Address(RVA = "0x68D790", Offset = "0x68C190", VA = "0x18068D790", Slot = "5")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0x67E170", Offset = "0x67CB70", VA = "0x18067E170", Slot = "6")]
	public CEAPFNKIAFO HNHHADBNINI(float JDMNPNJKCII)
	{
		return default(CEAPFNKIAFO);
	}

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0x690EB0", Offset = "0x68F8B0", VA = "0x180690EB0", Slot = "7")]
	public void MFMCNFFMIAP(KCLAPJNLDEK LGKNNMGLNIA, float FFODLHNKOLL, CECCAGGGBNA BFKJAGEEEEO = CECCAGGGBNA.Off)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(RVA = "0x690EB0", Offset = "0x68F8B0", VA = "0x180690EB0", Slot = "8")]
	public void MFMCNFFMIAP(KCLAPJNLDEK LGKNNMGLNIA, Transform BLBOCBHMNFG, float FFODLHNKOLL, CECCAGGGBNA BFKJAGEEEEO = CECCAGGGBNA.Off)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(RVA = "0x690EB0", Offset = "0x68F8B0", VA = "0x180690EB0", Slot = "9")]
	public void LECMNFFELEH(KCLAPJNLDEK LGKNNMGLNIA, [Optional] float? FFODLHNKOLL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(RVA = "0x690EB0", Offset = "0x68F8B0", VA = "0x180690EB0", Slot = "10")]
	public void EMIFMEAGDDE(KCLAPJNLDEK MADBLMMGOPC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(RVA = "0x67E170", Offset = "0x67CB70", VA = "0x18067E170", Slot = "11")]
	public CEAPFNKIAFO DKPBJIEGAPJ(KCLAPJNLDEK LGKNNMGLNIA)
	{
		return default(CEAPFNKIAFO);
	}

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(RVA = "0x698020", Offset = "0x696A20", VA = "0x180698020", Slot = "12")]
	public bool OEBKBHCCBKH(KCLAPJNLDEK LGKNNMGLNIA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(RVA = "0x690EB0", Offset = "0x68F8B0", VA = "0x180690EB0", Slot = "13")]
	public void CJOGBMHCIKK(KCLAPJNLDEK LGKNNMGLNIA, CECCAGGGBNA NENHIJHKOLI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(RVA = "0x678B30", Offset = "0x677530", VA = "0x180678B30")]
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
		[Cpp2IlInjected.Address(RVA = "0x67B250", Offset = "0x679C50", VA = "0x18067B250", Slot = "4")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(RVA = "0x690EB0", Offset = "0x68F8B0", VA = "0x180690EB0", Slot = "5")]
	public void CJLBEJJPLHJ(string OOMNIJBIFDC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(RVA = "0x690EB0", Offset = "0x68F8B0", VA = "0x180690EB0", Slot = "6")]
	public void CCBKFKILGIF(RigidbodyEx FHCKPPNILHO, Action PBOHOIMMGFG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(RVA = "0x67E170", Offset = "0x67CB70", VA = "0x18067E170", Slot = "7")]
	public IPLAPPDCGPJ AIPGIJNOLBD(int GIHMJHPHLNL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(RVA = "0x690EB0", Offset = "0x68F8B0", VA = "0x180690EB0", Slot = "8")]
	public void FKCBIGGCCPD(Vector3 NOJGOAEBGFN, float DONJHLJNIDL, Color GCBELIJEOPF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(RVA = "0x678B30", Offset = "0x677530", VA = "0x180678B30")]
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
			[Cpp2IlInjected.Address(RVA = "0x6022370", Offset = "0x6020D70", VA = "0x186022370")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000005")]
		public IReadOnlyList<RigidbodyEx> KEPEEEPLAGJ
		{
			[Cpp2IlInjected.Token(Token = "0x600002F")]
			[Cpp2IlInjected.Address(RVA = "0x68D770", Offset = "0x68C170", VA = "0x18068D770")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000030")]
			[Cpp2IlInjected.Address(RVA = "0x718AB0", Offset = "0x7174B0", VA = "0x180718AB0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000006")]
		public RigidbodyEx FNKEKCEGNCI
		{
			[Cpp2IlInjected.Token(Token = "0x6000031")]
			[Cpp2IlInjected.Address(RVA = "0x6023A30", Offset = "0x6022430", VA = "0x186023A30")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000007")]
		public RigidbodyEx AMKPOIHFDKH
		{
			[Cpp2IlInjected.Token(Token = "0x6000032")]
			[Cpp2IlInjected.Address(RVA = "0x60239D0", Offset = "0x60223D0", VA = "0x1860239D0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000008")]
		public RigidbodyEx LFAIGCEGCPL
		{
			[Cpp2IlInjected.Token(Token = "0x6000033")]
			[Cpp2IlInjected.Address(RVA = "0x6024590", Offset = "0x6022F90", VA = "0x186024590")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000034")]
			[Cpp2IlInjected.Address(RVA = "0x6025CE0", Offset = "0x60246E0", VA = "0x186025CE0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000009")]
		public Transform DPCGIDOBNGL
		{
			[Cpp2IlInjected.Token(Token = "0x6000035")]
			[Cpp2IlInjected.Address(RVA = "0xFB6EB0", Offset = "0xFB58B0", VA = "0x180FB6EB0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000A")]
		public Transform EAILDMMFMIE
		{
			[Cpp2IlInjected.Token(Token = "0x6000036")]
			[Cpp2IlInjected.Address(RVA = "0xFB6EB0", Offset = "0xFB58B0", VA = "0x180FB6EB0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000B")]
		public CECCAGGGBNA GGJLBGDDKGJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000037")]
			[Cpp2IlInjected.Address(RVA = "0x60236C0", Offset = "0x60220C0", VA = "0x1860236C0")]
			get
			{
				return default(CECCAGGGBNA);
			}
			[Cpp2IlInjected.Token(Token = "0x6000038")]
			[Cpp2IlInjected.Address(RVA = "0x6025280", Offset = "0x6023C80", VA = "0x186025280")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000C")]
		public bool BKKAMGPIPMG
		{
			[Cpp2IlInjected.Token(Token = "0x6000039")]
			[Cpp2IlInjected.Address(RVA = "0x6023C40", Offset = "0x6022640", VA = "0x186023C40")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000D")]
		public bool OFHGFFKKEMJ
		{
			[Cpp2IlInjected.Token(Token = "0x600003A")]
			[Cpp2IlInjected.Address(RVA = "0x6023850", Offset = "0x6022250", VA = "0x186023850")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000E")]
		public IIENCNCJIKK OEBLLEKPOOI
		{
			[Cpp2IlInjected.Token(Token = "0x600003B")]
			[Cpp2IlInjected.Address(RVA = "0x6023BE0", Offset = "0x60225E0", VA = "0x186023BE0")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600003C")]
			[Cpp2IlInjected.Address(RVA = "0x6025490", Offset = "0x6023E90", VA = "0x186025490")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000F")]
		public JGKAIJBBCDC KPBINMPEPCH
		{
			[Cpp2IlInjected.Token(Token = "0x600003D")]
			[Cpp2IlInjected.Address(RVA = "0x6023B80", Offset = "0x6022580", VA = "0x186023B80")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600003E")]
			[Cpp2IlInjected.Address(RVA = "0x6025420", Offset = "0x6023E20", VA = "0x186025420")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000010")]
		public bool NKPLDABKJCL
		{
			[Cpp2IlInjected.Token(Token = "0x600003F")]
			[Cpp2IlInjected.Address(RVA = "0x6023A60", Offset = "0x6022460", VA = "0x186023A60")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000011")]
		public Rigidbody BKIDAKAFFMP
		{
			[Cpp2IlInjected.Token(Token = "0x6000040")]
			[Cpp2IlInjected.Address(RVA = "0x6023AC0", Offset = "0x60224C0", VA = "0x186023AC0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000012")]
		public bool IELKFNIBHFB
		{
			[Cpp2IlInjected.Token(Token = "0x6000041")]
			[Cpp2IlInjected.Address(RVA = "0x6023910", Offset = "0x6022310", VA = "0x186023910")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000042")]
			[Cpp2IlInjected.Address(RVA = "0x6025340", Offset = "0x6023D40", VA = "0x186025340")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000013")]
		public bool PLOENPNIDDH
		{
			[Cpp2IlInjected.Token(Token = "0x6000043")]
			[Cpp2IlInjected.Address(RVA = "0xFA1EF0", Offset = "0xFA08F0", VA = "0x180FA1EF0")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000044")]
			[Cpp2IlInjected.Address(RVA = "0xFA1360", Offset = "0xF9FD60", VA = "0x180FA1360")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000014")]
		public float BCCFBPPIBNF
		{
			[Cpp2IlInjected.Token(Token = "0x6000045")]
			[Cpp2IlInjected.Address(RVA = "0x6024530", Offset = "0x6022F30", VA = "0x186024530")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000015")]
		public float MNOFKHGJHAL
		{
			[Cpp2IlInjected.Token(Token = "0x6000046")]
			[Cpp2IlInjected.Address(RVA = "0x60244D0", Offset = "0x6022ED0", VA = "0x1860244D0")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x6000047")]
			[Cpp2IlInjected.Address(RVA = "0x6025C70", Offset = "0x6024670", VA = "0x186025C70")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000016")]
		public float ELGKPJENLOI
		{
			[Cpp2IlInjected.Token(Token = "0x6000048")]
			[Cpp2IlInjected.Address(RVA = "0x6023EA0", Offset = "0x60228A0", VA = "0x186023EA0")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x6000049")]
			[Cpp2IlInjected.Address(RVA = "0x6025730", Offset = "0x6024130", VA = "0x186025730")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000017")]
		public float CHHDLHAEMBC
		{
			[Cpp2IlInjected.Token(Token = "0x600004A")]
			[Cpp2IlInjected.Address(RVA = "0x6023CA0", Offset = "0x60226A0", VA = "0x186023CA0")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x600004B")]
			[Cpp2IlInjected.Address(RVA = "0x6025500", Offset = "0x6023F00", VA = "0x186025500")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000018")]
		public bool DAIBFNHELEC
		{
			[Cpp2IlInjected.Token(Token = "0x600004C")]
			[Cpp2IlInjected.Address(RVA = "0x6024AB0", Offset = "0x60234B0", VA = "0x186024AB0")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x600004D")]
			[Cpp2IlInjected.Address(RVA = "0x6026220", Offset = "0x6024C20", VA = "0x186026220")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000019")]
		public Vector3 KDBLJOCPCPM
		{
			[Cpp2IlInjected.Token(Token = "0x600004E")]
			[Cpp2IlInjected.Address(RVA = "0x60242B0", Offset = "0x6022CB0", VA = "0x1860242B0")]
			get
			{
				return default(Vector3);
			}
			[Cpp2IlInjected.Token(Token = "0x600004F")]
			[Cpp2IlInjected.Address(RVA = "0x6025A40", Offset = "0x6024440", VA = "0x186025A40")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001A")]
		public Vector3 NOJGOAEBGFN
		{
			[Cpp2IlInjected.Token(Token = "0x6000050")]
			[Cpp2IlInjected.Address(RVA = "0x6024BF0", Offset = "0x60235F0", VA = "0x186024BF0")]
			get
			{
				return default(Vector3);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001B")]
		public CollisionDetectionMode GAPECEDJFOA
		{
			[Cpp2IlInjected.Token(Token = "0x6000051")]
			[Cpp2IlInjected.Address(RVA = "0x6023DE0", Offset = "0x60227E0", VA = "0x186023DE0")]
			get
			{
				return default(CollisionDetectionMode);
			}
			[Cpp2IlInjected.Token(Token = "0x6000052")]
			[Cpp2IlInjected.Address(RVA = "0x6025650", Offset = "0x6024050", VA = "0x186025650")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001C")]
		public float KJKDBCBOHIJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000053")]
			[Cpp2IlInjected.Address(RVA = "0x6023970", Offset = "0x6022370", VA = "0x186023970")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x6000054")]
			[Cpp2IlInjected.Address(RVA = "0x60253B0", Offset = "0x6023DB0", VA = "0x1860253B0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001D")]
		public RigidbodyConstraints ILIMCMHHIEN
		{
			[Cpp2IlInjected.Token(Token = "0x6000055")]
			[Cpp2IlInjected.Address(RVA = "0x6023E40", Offset = "0x6022840", VA = "0x186023E40")]
			get
			{
				return default(RigidbodyConstraints);
			}
			[Cpp2IlInjected.Token(Token = "0x6000056")]
			[Cpp2IlInjected.Address(RVA = "0x60256C0", Offset = "0x60240C0", VA = "0x1860256C0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001E")]
		public Vector3 JIHNPHLJCMM
		{
			[Cpp2IlInjected.Token(Token = "0x6000057")]
			[Cpp2IlInjected.Address(RVA = "0x60245F0", Offset = "0x6022FF0", VA = "0x1860245F0")]
			get
			{
				return default(Vector3);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001F")]
		public Vector3 AANPNCAOFJC
		{
			[Cpp2IlInjected.Token(Token = "0x6000058")]
			[Cpp2IlInjected.Address(RVA = "0x60245F0", Offset = "0x6022FF0", VA = "0x1860245F0")]
			get
			{
				return default(Vector3);
			}
			[Cpp2IlInjected.Token(Token = "0x6000059")]
			[Cpp2IlInjected.Address(RVA = "0x6025FF0", Offset = "0x60249F0", VA = "0x186025FF0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000020")]
		public float HGBKAJOPNCH
		{
			[Cpp2IlInjected.Token(Token = "0x600005A")]
			[Cpp2IlInjected.Address(RVA = "0x6024390", Offset = "0x6022D90", VA = "0x186024390")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x600005B")]
			[Cpp2IlInjected.Address(RVA = "0x6025B20", Offset = "0x6024520", VA = "0x186025B20")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000021")]
		public float NMPAKEMAEHA
		{
			[Cpp2IlInjected.Token(Token = "0x600005C")]
			[Cpp2IlInjected.Address(RVA = "0x6024A50", Offset = "0x6023450", VA = "0x186024A50")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x600005D")]
			[Cpp2IlInjected.Address(RVA = "0x60261B0", Offset = "0x6024BB0", VA = "0x1860261B0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000022")]
		public Quaternion DFIHKNCOEJM
		{
			[Cpp2IlInjected.Token(Token = "0x600005E")]
			[Cpp2IlInjected.Address(RVA = "0x60246D0", Offset = "0x60230D0", VA = "0x1860246D0")]
			get
			{
				return default(Quaternion);
			}
			[Cpp2IlInjected.Token(Token = "0x600005F")]
			[Cpp2IlInjected.Address(RVA = "0x6025D50", Offset = "0x6024750", VA = "0x186025D50")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000023")]
		public Quaternion AGPDEBCIBKN
		{
			[Cpp2IlInjected.Token(Token = "0x6000060")]
			[Cpp2IlInjected.Address(RVA = "0x6024970", Offset = "0x6023370", VA = "0x186024970")]
			get
			{
				return default(Quaternion);
			}
			[Cpp2IlInjected.Token(Token = "0x6000061")]
			[Cpp2IlInjected.Address(RVA = "0x60260D0", Offset = "0x6024AD0", VA = "0x1860260D0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000024")]
		public Vector3 JAOLFALPFED
		{
			[Cpp2IlInjected.Token(Token = "0x6000062")]
			[Cpp2IlInjected.Address(RVA = "0x60247B0", Offset = "0x60231B0", VA = "0x1860247B0")]
			get
			{
				return default(Vector3);
			}
			[Cpp2IlInjected.Token(Token = "0x6000063")]
			[Cpp2IlInjected.Address(RVA = "0x6025E30", Offset = "0x6024830", VA = "0x186025E30")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000025")]
		public Quaternion KLBBPOKDLCL
		{
			[Cpp2IlInjected.Token(Token = "0x6000064")]
			[Cpp2IlInjected.Address(RVA = "0x6024890", Offset = "0x6023290", VA = "0x186024890")]
			get
			{
				return default(Quaternion);
			}
			[Cpp2IlInjected.Token(Token = "0x6000065")]
			[Cpp2IlInjected.Address(RVA = "0x6025F10", Offset = "0x6024910", VA = "0x186025F10")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000026")]
		public Vector3 CPHPLAEKCBK
		{
			[Cpp2IlInjected.Token(Token = "0x6000066")]
			[Cpp2IlInjected.Address(RVA = "0x6024B10", Offset = "0x6023510", VA = "0x186024B10")]
			get
			{
				return default(Vector3);
			}
			[Cpp2IlInjected.Token(Token = "0x6000067")]
			[Cpp2IlInjected.Address(RVA = "0x6026290", Offset = "0x6024C90", VA = "0x186026290")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000027")]
		public Vector3 OLLLCEPAFHE
		{
			[Cpp2IlInjected.Token(Token = "0x6000068")]
			[Cpp2IlInjected.Address(RVA = "0x60243F0", Offset = "0x6022DF0", VA = "0x1860243F0")]
			get
			{
				return default(Vector3);
			}
			[Cpp2IlInjected.Token(Token = "0x6000069")]
			[Cpp2IlInjected.Address(RVA = "0x6025B90", Offset = "0x6024590", VA = "0x186025B90")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000028")]
		public Vector3 HOLPFINNOLF
		{
			[Cpp2IlInjected.Token(Token = "0x600006A")]
			[Cpp2IlInjected.Address(RVA = "0x6023D00", Offset = "0x6022700", VA = "0x186023D00")]
			get
			{
				return default(Vector3);
			}
			[Cpp2IlInjected.Token(Token = "0x600006B")]
			[Cpp2IlInjected.Address(RVA = "0x6025570", Offset = "0x6023F70", VA = "0x186025570")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000029")]
		public Vector3 OGPMEJLJLFA
		{
			[Cpp2IlInjected.Token(Token = "0x600006C")]
			[Cpp2IlInjected.Address(RVA = "0x60241D0", Offset = "0x6022BD0", VA = "0x1860241D0")]
			get
			{
				return default(Vector3);
			}
			[Cpp2IlInjected.Token(Token = "0x600006D")]
			[Cpp2IlInjected.Address(RVA = "0x6025960", Offset = "0x6024360", VA = "0x186025960")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002A")]
		public Vector3 ILIIJCFJEHJ
		{
			[Cpp2IlInjected.Token(Token = "0x600006E")]
			[Cpp2IlInjected.Address(RVA = "0x6024090", Offset = "0x6022A90", VA = "0x186024090")]
			get
			{
				return default(Vector3);
			}
			[Cpp2IlInjected.Token(Token = "0x600006F")]
			[Cpp2IlInjected.Address(RVA = "0x6025880", Offset = "0x6024280", VA = "0x186025880")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002B")]
		public Quaternion LKDKKEEAFEJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000070")]
			[Cpp2IlInjected.Address(RVA = "0x6023FB0", Offset = "0x60229B0", VA = "0x186023FB0")]
			get
			{
				return default(Quaternion);
			}
			[Cpp2IlInjected.Token(Token = "0x6000071")]
			[Cpp2IlInjected.Address(RVA = "0x60257A0", Offset = "0x60241A0", VA = "0x1860257A0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002C")]
		public Vector3 DILEEABKBCF
		{
			[Cpp2IlInjected.Token(Token = "0x6000072")]
			[Cpp2IlInjected.Address(RVA = "0x6024DB0", Offset = "0x60237B0", VA = "0x186024DB0")]
			get
			{
				return default(Vector3);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002D")]
		public Vector3 DOGPJJMFEDI
		{
			[Cpp2IlInjected.Token(Token = "0x6000073")]
			[Cpp2IlInjected.Address(RVA = "0x6024CD0", Offset = "0x60236D0", VA = "0x186024CD0")]
			get
			{
				return default(Vector3);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002E")]
		public bool IGMFHMLOGDC
		{
			[Cpp2IlInjected.Token(Token = "0x6000074")]
			[Cpp2IlInjected.Address(RVA = "0x6024170", Offset = "0x6022B70", VA = "0x186024170")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002F")]
		public bool CEDDMPPAJDO
		{
			[Cpp2IlInjected.Token(Token = "0x6000075")]
			[Cpp2IlInjected.Address(RVA = "0x60238B0", Offset = "0x60222B0", VA = "0x1860238B0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000030")]
		public bool KENDHOCAHBA
		{
			[Cpp2IlInjected.Token(Token = "0x6000076")]
			[Cpp2IlInjected.Address(RVA = "0x60237F0", Offset = "0x60221F0", VA = "0x1860237F0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000031")]
		public bool EHJFPLNBAAH
		{
			[Cpp2IlInjected.Token(Token = "0x6000077")]
			[Cpp2IlInjected.Address(RVA = "0x6023790", Offset = "0x6022190", VA = "0x186023790")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000032")]
		public bool PLHBBEKOBGN
		{
			[Cpp2IlInjected.Token(Token = "0x6000078")]
			[Cpp2IlInjected.Address(RVA = "0x6023660", Offset = "0x6022060", VA = "0x186023660")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000033")]
		public bool KIGGBNOJLJJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000079")]
			[Cpp2IlInjected.Address(RVA = "0x6023F00", Offset = "0x6022900", VA = "0x186023F00")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000034")]
		public bool MGEAADBCNEJ
		{
			[Cpp2IlInjected.Token(Token = "0x600007A")]
			[Cpp2IlInjected.Address(RVA = "0x70F580", Offset = "0x70DF80", VA = "0x18070F580")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000001")]
		public event HOBHPHAMKBD COOHJIJKDEA
		{
			[Cpp2IlInjected.Token(Token = "0x600001D")]
			[Cpp2IlInjected.Address(RVA = "0x6023580", Offset = "0x6021F80", VA = "0x186023580")]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x600001E")]
			[Cpp2IlInjected.Address(RVA = "0x60251A0", Offset = "0x6023BA0", VA = "0x1860251A0")]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000002")]
		public event ABBLHFOFAPM GIHKCKOLIHJ
		{
			[Cpp2IlInjected.Token(Token = "0x600001F")]
			[Cpp2IlInjected.Address(RVA = "0x6023510", Offset = "0x6021F10", VA = "0x186023510")]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000020")]
			[Cpp2IlInjected.Address(RVA = "0x6025130", Offset = "0x6023B30", VA = "0x186025130")]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000003")]
		public event HOBHPHAMKBD IAOFFICNEFM
		{
			[Cpp2IlInjected.Token(Token = "0x6000021")]
			[Cpp2IlInjected.Address(RVA = "0x6023270", Offset = "0x6021C70", VA = "0x186023270")]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000022")]
			[Cpp2IlInjected.Address(RVA = "0x6024E90", Offset = "0x6023890", VA = "0x186024E90")]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000004")]
		public event HOBHPHAMKBD BPJGPOJJOIC
		{
			[Cpp2IlInjected.Token(Token = "0x6000023")]
			[Cpp2IlInjected.Address(RVA = "0x60232E0", Offset = "0x6021CE0", VA = "0x1860232E0")]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000024")]
			[Cpp2IlInjected.Address(RVA = "0x6024F00", Offset = "0x6023900", VA = "0x186024F00")]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000005")]
		public event HOBHPHAMKBD MPMMHJCOBJO
		{
			[Cpp2IlInjected.Token(Token = "0x6000025")]
			[Cpp2IlInjected.Address(RVA = "0x6023430", Offset = "0x6021E30", VA = "0x186023430")]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000026")]
			[Cpp2IlInjected.Address(RVA = "0x6025050", Offset = "0x6023A50", VA = "0x186025050")]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000006")]
		public event Action<CEAPFNKIAFO, CEAPFNKIAFO> GAJNIIPFKOP
		{
			[Cpp2IlInjected.Token(Token = "0x6000027")]
			[Cpp2IlInjected.Address(RVA = "0x60233C0", Offset = "0x6021DC0", VA = "0x1860233C0")]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000028")]
			[Cpp2IlInjected.Address(RVA = "0x6024FE0", Offset = "0x60239E0", VA = "0x186024FE0")]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000007")]
		public event HOBHPHAMKBD BAGPPKHMIEK
		{
			[Cpp2IlInjected.Token(Token = "0x6000029")]
			[Cpp2IlInjected.Address(RVA = "0x60234A0", Offset = "0x6021EA0", VA = "0x1860234A0")]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x600002A")]
			[Cpp2IlInjected.Address(RVA = "0x60250C0", Offset = "0x6023AC0", VA = "0x1860250C0")]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000008")]
		public event HOBHPHAMKBD AHGHHKNNOOF
		{
			[Cpp2IlInjected.Token(Token = "0x600002B")]
			[Cpp2IlInjected.Address(RVA = "0x60235F0", Offset = "0x6021FF0", VA = "0x1860235F0")]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x600002C")]
			[Cpp2IlInjected.Address(RVA = "0x6025210", Offset = "0x6023C10", VA = "0x186025210")]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000009")]
		public event HOBHPHAMKBD JDPDGOHICPK
		{
			[Cpp2IlInjected.Token(Token = "0x600002D")]
			[Cpp2IlInjected.Address(RVA = "0x6023350", Offset = "0x6021D50", VA = "0x186023350")]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x600002E")]
			[Cpp2IlInjected.Address(RVA = "0x6024F70", Offset = "0x6023970", VA = "0x186024F70")]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(RVA = "0x678130", Offset = "0x676B30", VA = "0x180678130")]
		internal void EKCHCBGJJIL(FFCGIONKJBI BMFGKMDOFCF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007B")]
		[Cpp2IlInjected.Address(RVA = "0x60218F0", Offset = "0x60202F0", VA = "0x1860218F0")]
		private void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007C")]
		[Cpp2IlInjected.Address(RVA = "0x6022370", Offset = "0x6020D70", VA = "0x186022370")]
		private FFCGIONKJBI MDDDKMBLKCN()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600007D")]
		[Cpp2IlInjected.Address(RVA = "0x6021E00", Offset = "0x6020800", VA = "0x186021E00")]
		private void IFEPEMKMGAF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007E")]
		[Cpp2IlInjected.Address(RVA = "0x6022580", Offset = "0x6020F80", VA = "0x186022580")]
		private void OnEnable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007F")]
		[Cpp2IlInjected.Address(RVA = "0x6022480", Offset = "0x6020E80", VA = "0x186022480")]
		private void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000080")]
		[Cpp2IlInjected.Address(RVA = "0x6021BA0", Offset = "0x60205A0", VA = "0x186021BA0")]
		private void FixedUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000081")]
		[Cpp2IlInjected.Address(RVA = "0x6022520", Offset = "0x6020F20", VA = "0x186022520")]
		private void OnDrawGizmosSelected()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000082")]
		[Cpp2IlInjected.Address(RVA = "0x60225E0", Offset = "0x6020FE0", VA = "0x1860225E0")]
		private void OnValidate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000083")]
		[Cpp2IlInjected.Address(RVA = "0x6020F80", Offset = "0x601F980", VA = "0x186020F80")]
		public void AddDoNotResetVelocityOnOwnershipChangeOverride(object HKLDIENGNNB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000084")]
		[Cpp2IlInjected.Address(RVA = "0x6022650", Offset = "0x6021050", VA = "0x186022650")]
		public void RemoveDoNotResetVelocityOnOwnershipChangeOverride(object HKLDIENGNNB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000085")]
		[Cpp2IlInjected.Address(RVA = "0x6021B40", Offset = "0x6020540", VA = "0x186021B40")]
		public void DisableCachedInertialPropertyOverride()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000086")]
		[Cpp2IlInjected.Address(RVA = "0x6022420", Offset = "0x6020E20", VA = "0x186022420")]
		public void MarkCachedInertialParametersDirty()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000087")]
		[Cpp2IlInjected.Address(RVA = "0x6022E40", Offset = "0x6021840", VA = "0x186022E40")]
		public void SetParent(RigidbodyEx MAKFNMHIJIF, bool JAHLDBIKCJI = false)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000088")]
		[Cpp2IlInjected.Address(RVA = "0x6022960", Offset = "0x6021360", VA = "0x186022960")]
		public void ResetLocalCenterOfMassToPrefabDefault()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000089")]
		[Cpp2IlInjected.Address(RVA = "0x6022190", Offset = "0x6020B90", VA = "0x186022190")]
		public bool IsRigidbodyAncestor(RigidbodyEx EPDAFINDPJC)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600008A")]
		[Cpp2IlInjected.Address(RVA = "0x60221D0", Offset = "0x6020BD0", VA = "0x1860221D0")]
		public bool IsRigidbodyDescendant(RigidbodyEx PPMNPHOOLCH)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600008B")]
		[Cpp2IlInjected.Address(RVA = "0x60211A0", Offset = "0x601FBA0", VA = "0x1860211A0")]
		public void AddInterpolationRestriction(object HKLDIENGNNB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008C")]
		[Cpp2IlInjected.Address(RVA = "0x60226C0", Offset = "0x60210C0", VA = "0x1860226C0")]
		public void RemoveInterpolationRestriction(object HKLDIENGNNB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008D")]
		[Cpp2IlInjected.Address(RVA = "0x6021960", Offset = "0x6020360", VA = "0x186021960")]
		public IDisposable BeginKinematicScope()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600008E")]
		[Cpp2IlInjected.Address(RVA = "0x6021210", Offset = "0x601FC10", VA = "0x186021210")]
		public void AddKinematic(object HKLDIENGNNB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008F")]
		[Cpp2IlInjected.Address(RVA = "0x6022730", Offset = "0x6021130", VA = "0x186022730")]
		public void RemoveKinematic(object HKLDIENGNNB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000090")]
		[Cpp2IlInjected.Address(RVA = "0x6022DC0", Offset = "0x60217C0", VA = "0x186022DC0")]
		public void SetKinematic(object HKLDIENGNNB, bool BKHDMOGADPG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000091")]
		[Cpp2IlInjected.Address(RVA = "0x6022CC0", Offset = "0x60216C0", VA = "0x186022CC0")]
		public void SetDiscontinuousPositionAndRotation(Vector3 AFHANPMAJON, Quaternion MGLHGJDPDPO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000092")]
		[Cpp2IlInjected.Address(RVA = "0x6022BC0", Offset = "0x60215C0", VA = "0x186022BC0")]
		public void SetDiscontinuousLocalPositionAndLocalRotation(Vector3 JGOFLNCMNEF, Quaternion HHGDJGKIPDH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000093")]
		[Cpp2IlInjected.Address(RVA = "0x6021D00", Offset = "0x6020700", VA = "0x186021D00")]
		public Vector3 GetConstrainedVelocity(Vector3 CPHPLAEKCBK)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x6000094")]
		[Cpp2IlInjected.Address(RVA = "0x6021C00", Offset = "0x6020600", VA = "0x186021C00")]
		public Vector3 GetConstrainedAngularVelocity(Vector3 HOLPFINNOLF)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x6000095")]
		[Cpp2IlInjected.Address(RVA = "0x6021110", Offset = "0x601FB10", VA = "0x186021110")]
		public void AddForce(Vector3 CBEIFKNKIIE, ForceMode OEBHACLNMCB = ForceMode.Force)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000096")]
		[Cpp2IlInjected.Address(RVA = "0x6020FF0", Offset = "0x601F9F0", VA = "0x186020FF0")]
		public void AddForceAtPosition(Vector3 CBEIFKNKIIE, Vector3 EINGNKDKDHC, ForceMode OEBHACLNMCB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000097")]
		[Cpp2IlInjected.Address(RVA = "0x6021310", Offset = "0x601FD10", VA = "0x186021310")]
		public void AddTorque(Vector3 DEMLAEGANDJ, ForceMode OEBHACLNMCB = ForceMode.Force)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000098")]
		[Cpp2IlInjected.Address(RVA = "0x6021280", Offset = "0x601FC80", VA = "0x186021280")]
		public void AddRelativeTorque(Vector3 DEMLAEGANDJ, ForceMode OEBHACLNMCB = ForceMode.Force)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000099")]
		[Cpp2IlInjected.Address(RVA = "0x60230A0", Offset = "0x6021AA0", VA = "0x1860230A0")]
		public Vector3 WorldToLocalVelocity(Vector3 JMLACAFKJOF)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x600009A")]
		[Cpp2IlInjected.Address(RVA = "0x6022270", Offset = "0x6020C70", VA = "0x186022270")]
		public Vector3 LocalToWorldVelocity(Vector3 OLLLCEPAFHE)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x600009B")]
		[Cpp2IlInjected.Address(RVA = "0x6021AE0", Offset = "0x60204E0", VA = "0x186021AE0")]
		public void ClearVelocity()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009C")]
		[Cpp2IlInjected.Address(RVA = "0x6021A80", Offset = "0x6020480", VA = "0x186021A80")]
		public void ClearUnityRigidbodyVelocity()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009D")]
		[Cpp2IlInjected.Address(RVA = "0x6021A20", Offset = "0x6020420", VA = "0x186021A20")]
		public void ClearLinearVelocity()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009E")]
		[Cpp2IlInjected.Address(RVA = "0x60219C0", Offset = "0x60203C0", VA = "0x1860219C0")]
		public void ClearAngularVelocity()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009F")]
		[Cpp2IlInjected.Address(RVA = "0x6022AC0", Offset = "0x60214C0", VA = "0x186022AC0")]
		public void ResetVelocityWorldSpace(Vector3 PFDFFPLAJJP, Vector3 HGIFCPKBAGG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A0")]
		[Cpp2IlInjected.Address(RVA = "0x60229C0", Offset = "0x60213C0", VA = "0x1860229C0")]
		public void ResetVelocityLocalSpace(Vector3 LOGKBIHCFJD, Vector3 OGPMEJLJLFA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A1")]
		[Cpp2IlInjected.Address(RVA = "0x6022880", Offset = "0x6021280", VA = "0x186022880")]
		public void ResetLinearVelocityLocalSpace(Vector3 LOGKBIHCFJD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A2")]
		[Cpp2IlInjected.Address(RVA = "0x6022F30", Offset = "0x6021930", VA = "0x186022F30")]
		public bool SweepTest(Vector3 FOGEFLLJLFJ, out RaycastHit LOOJGACDMOC, float IDHCBHDHMCK)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000A3")]
		[Cpp2IlInjected.Address(RVA = "0x6022210", Offset = "0x6020C10", VA = "0x186022210")]
		public bool IsSleeping()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000A4")]
		[Cpp2IlInjected.Address(RVA = "0x6022ED0", Offset = "0x60218D0", VA = "0x186022ED0")]
		public void Sleep()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A5")]
		[Cpp2IlInjected.Address(RVA = "0x6023040", Offset = "0x6021A40", VA = "0x186023040")]
		public void WakeUp()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A6")]
		[Cpp2IlInjected.Address(RVA = "0x60213A0", Offset = "0x601FDA0", VA = "0x1860213A0")]
		public void AddUnityRigidbody(object HKLDIENGNNB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A7")]
		[Cpp2IlInjected.Address(RVA = "0x60227A0", Offset = "0x60211A0", VA = "0x1860227A0")]
		public void RemoveUnityRigidbody(object HKLDIENGNNB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A8")]
		[Cpp2IlInjected.Address(RVA = "0x60216C0", Offset = "0x60200C0", VA = "0x1860216C0")]
		public void ApplyForceVelocityChange(CKAOOODELAE IKFPEHIFEPN, Vector3 NMBFBKMEJKN, float FEHHFHACKBK, float IOFMPFNPHNC = 8f, float JKLGNKAKKLG = 1f)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A9")]
		[Cpp2IlInjected.Address(RVA = "0x60215C0", Offset = "0x601FFC0", VA = "0x1860215C0")]
		public void ApplyAngularVelocityChange(MCMFGEDCCGC LMLMHHPMBJO, Vector3 OFLGCJLDNJJ, float IPAPNFBMGEF = float.PositiveInfinity)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AA")]
		[Cpp2IlInjected.Address(RVA = "0x60217E0", Offset = "0x60201E0", VA = "0x1860217E0")]
		[Obsolete]
		public void ApplyTorqueAngularVelocityChangeDeprecated(MCMFGEDCCGC LMLMHHPMBJO, Vector3 JGCPJBFFFAC, float NMBEKOOKPJA = 7f, float MFBAPHBIEKM = 1f)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AB")]
		[Cpp2IlInjected.Address(RVA = "0x6021500", Offset = "0x601FF00", VA = "0x186021500")]
		public bool AllowedScaleChange(float CJJGIOGGJMO)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000AC")]
		[Cpp2IlInjected.Address(RVA = "0x6021410", Offset = "0x601FE10", VA = "0x186021410")]
		public void AddWorldSpaceVelocityInHierarchyParentOverride(RigidbodyEx HJFPEPOCKIC, object HKLDIENGNNB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AD")]
		[Cpp2IlInjected.Address(RVA = "0x6022810", Offset = "0x6021210", VA = "0x186022810")]
		public void RemoveWorldSpaceVelocityInHierarchyParentOverride(object HKLDIENGNNB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AE")]
		[Cpp2IlInjected.Address(RVA = "0x60231F0", Offset = "0x6021BF0", VA = "0x1860231F0")]
		public RigidbodyEx()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
internal static class LBJKOHGMCPE
{
	[Cpp2IlInjected.Token(Token = "0x60000B3")]
	[Cpp2IlInjected.Address(RVA = "0x5167310", Offset = "0x5165D10", VA = "0x185167310")]
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
		[Cpp2IlInjected.Address(RVA = "0x51710E0", Offset = "0x516FAE0", VA = "0x1851710E0", Slot = "6")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000036")]
	public ILPLCBJNHLG KEPKLMOMNIE
	{
		[Cpp2IlInjected.Token(Token = "0x60000B5")]
		[Cpp2IlInjected.Address(RVA = "0x6770C0", Offset = "0x675AC0", VA = "0x1806770C0", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000037")]
	public LGNFMEIAMDG AAIBAGIBCOG
	{
		[Cpp2IlInjected.Token(Token = "0x60000B6")]
		[Cpp2IlInjected.Address(RVA = "0x678120", Offset = "0x676B20", VA = "0x180678120", Slot = "5")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000B7")]
	[Cpp2IlInjected.Address(RVA = "0x5170F60", Offset = "0x516F960", VA = "0x185170F60", Slot = "10")]
	public void NDFJIGFEFMN(PFKGIHKPIGG GOCENLCAMDB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B8")]
	[Cpp2IlInjected.Address(RVA = "0x5170B90", Offset = "0x516F590", VA = "0x185170B90", Slot = "7")]
	public NIALADIPDNC DJNCPPLECDP(RigidbodyEx FHCKPPNILHO)
	{
		return default(NIALADIPDNC);
	}

	[Cpp2IlInjected.Token(Token = "0x60000B9")]
	[Cpp2IlInjected.Address(RVA = "0x5170FF0", Offset = "0x516F9F0", VA = "0x185170FF0")]
	private static NIALADIPDNC PDLLBGNJLCN(RigidbodyEx FHCKPPNILHO)
	{
		return default(NIALADIPDNC);
	}

	[Cpp2IlInjected.Token(Token = "0x60000BA")]
	[Cpp2IlInjected.Address(RVA = "0x5170AF0", Offset = "0x516F4F0", VA = "0x185170AF0", Slot = "8")]
	public FFCGIONKJBI CAKONGBGLCH(RigidbodyEx FHCKPPNILHO, IMECCMKFBII JIHCLPECHIB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000BB")]
	[Cpp2IlInjected.Address(RVA = "0x5170E30", Offset = "0x516F830", VA = "0x185170E30", Slot = "9")]
	private RigidbodyEx EKIBPBAJBJF(GameObject POFNLMLLLOA, IMECCMKFBII JIHCLPECHIB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000BC")]
	[Cpp2IlInjected.Address(RVA = "0x678B30", Offset = "0x677530", VA = "0x180678B30")]
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
		[Cpp2IlInjected.Address(RVA = "0x6020A60", Offset = "0x601F460", VA = "0x186020A60")]
		protected void FixedUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000BE")]
		[Cpp2IlInjected.Address(RVA = "0x6020AA0", Offset = "0x601F4A0", VA = "0x186020AA0")]
		protected void Update()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000BF")]
		[Cpp2IlInjected.Address(RVA = "0x6020A80", Offset = "0x601F480", VA = "0x186020A80")]
		protected void LateUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C0")]
		[Cpp2IlInjected.Address(RVA = "0x690EB0", Offset = "0x68F8B0", VA = "0x180690EB0")]
		[Conditional("UNITY_ASSERTIONS")]
		public void AssertLateColliderPositionsNotYetUpdated([Optional] string DIDMFBHHIEC, [Optional] UnityEngine.Object JOOJGLPIMBB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C1")]
		[Cpp2IlInjected.Address(RVA = "0x690EB0", Offset = "0x68F8B0", VA = "0x180690EB0")]
		[Conditional("UNITY_ASSERTIONS")]
		public void AssertLateColliderPositionsAlreadyUpdated([Optional] string DIDMFBHHIEC, [Optional] UnityEngine.Object JOOJGLPIMBB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C2")]
		[Cpp2IlInjected.Address(RVA = "0x6020B90", Offset = "0x601F590", VA = "0x186020B90")]
		public PhysicsManager()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
public static class ACKNGOIHNIM
{
	[Cpp2IlInjected.Token(Token = "0x60000C4")]
	[Cpp2IlInjected.Address(RVA = "0x5148DB0", Offset = "0x51477B0", VA = "0x185148DB0")]
	public static void AKMPDFHDMEE(this Rigidbody OIGIAECEHDG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C5")]
	[Cpp2IlInjected.Address(RVA = "0x5148CA0", Offset = "0x51476A0", VA = "0x185148CA0")]
	public static void AKMPDFHDMEE(this Rigidbody OIGIAECEHDG, Vector3 ILIIJCFJEHJ, Quaternion LKDKKEEAFEJ, Vector3 CMPHOGNEMFN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C6")]
	[Cpp2IlInjected.Address(RVA = "0x5148F00", Offset = "0x5147900", VA = "0x185148F00")]
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
		[Cpp2IlInjected.Address(RVA = "0x690EB0", Offset = "0x68F8B0", VA = "0x180690EB0", Slot = "6")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000CA")]
		[Cpp2IlInjected.Address(RVA = "0x137B370", Offset = "0x1379D70", VA = "0x18137B370", Slot = "4")]
		public Vector3 NMMDPBJGGGJ()
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x60000CB")]
		[Cpp2IlInjected.Address(RVA = "0x137B370", Offset = "0x1379D70", VA = "0x18137B370", Slot = "5")]
		public Vector3 CHBOIJCOGNN()
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x60000CC")]
		[Cpp2IlInjected.Address(RVA = "0x678B30", Offset = "0x677530", VA = "0x180678B30")]
		public GKKNALCIODH()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000038")]
	public static IIENCNCJIKK GBPPBMLHFNG
	{
		[Cpp2IlInjected.Token(Token = "0x60000C7")]
		[Cpp2IlInjected.Address(RVA = "0x5148BD0", Offset = "0x51475D0", VA = "0x185148BD0")]
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
		[Cpp2IlInjected.Address(RVA = "0x67DE20", Offset = "0x67C820", VA = "0x18067DE20", Slot = "5")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000212")]
		[Cpp2IlInjected.Address(RVA = "0x7F69F0", Offset = "0x7F53F0", VA = "0x1807F69F0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700008F")]
	public GameObject LPLGJEFNKNH
	{
		[Cpp2IlInjected.Token(Token = "0x6000213")]
		[Cpp2IlInjected.Address(RVA = "0x6B36A0", Offset = "0x6B20A0", VA = "0x1806B36A0", Slot = "6")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000214")]
		[Cpp2IlInjected.Address(RVA = "0x913EA0", Offset = "0x9128A0", VA = "0x180913EA0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000090")]
	public Transform DACDPJCIAKE
	{
		[Cpp2IlInjected.Token(Token = "0x6000215")]
		[Cpp2IlInjected.Address(RVA = "0x516EC60", Offset = "0x516D660", VA = "0x18516EC60", Slot = "7")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000091")]
	public IEnumerable<object> CMDPIDMOANK
	{
		[Cpp2IlInjected.Token(Token = "0x6000216")]
		[Cpp2IlInjected.Address(RVA = "0x516EC10", Offset = "0x516D610", VA = "0x18516EC10", Slot = "8")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000092")]
	public Rigidbody BKIDAKAFFMP
	{
		[Cpp2IlInjected.Token(Token = "0x6000217")]
		[Cpp2IlInjected.Address(RVA = "0x516A950", Offset = "0x5169350", VA = "0x18516A950", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000093")]
	public FFCGIONKJBI HDIMMFJBNPK
	{
		[Cpp2IlInjected.Token(Token = "0x6000225")]
		[Cpp2IlInjected.Address(RVA = "0x516B2A0", Offset = "0x5169CA0", VA = "0x18516B2A0", Slot = "9")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000226")]
		[Cpp2IlInjected.Address(RVA = "0x516E9D0", Offset = "0x516D3D0", VA = "0x18516E9D0", Slot = "10")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000094")]
	public IReadOnlyList<FFCGIONKJBI> KEPEEEPLAGJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000227")]
		[Cpp2IlInjected.Address(RVA = "0x516AF50", Offset = "0x5169950", VA = "0x18516AF50", Slot = "11")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000095")]
	public FFCGIONKJBI AMKPOIHFDKH
	{
		[Cpp2IlInjected.Token(Token = "0x6000228")]
		[Cpp2IlInjected.Address(RVA = "0x516E690", Offset = "0x516D090", VA = "0x18516E690", Slot = "12")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000096")]
	public bool CAIEJEMCAII
	{
		[Cpp2IlInjected.Token(Token = "0x6000229")]
		[Cpp2IlInjected.Address(RVA = "0x5170160", Offset = "0x516EB60", VA = "0x185170160", Slot = "13")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000097")]
	public bool BKKAMGPIPMG
	{
		[Cpp2IlInjected.Token(Token = "0x600022D")]
		[Cpp2IlInjected.Address(RVA = "0x516D820", Offset = "0x516C220", VA = "0x18516D820", Slot = "14")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000098")]
	public bool OFHGFFKKEMJ
	{
		[Cpp2IlInjected.Token(Token = "0x600022E")]
		[Cpp2IlInjected.Address(RVA = "0x516E4B0", Offset = "0x516CEB0", VA = "0x18516E4B0", Slot = "15")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000099")]
	public IIENCNCJIKK OEBLLEKPOOI
	{
		[Cpp2IlInjected.Token(Token = "0x600022F")]
		[Cpp2IlInjected.Address(RVA = "0x516C130", Offset = "0x516AB30", VA = "0x18516C130", Slot = "16")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000230")]
		[Cpp2IlInjected.Address(RVA = "0x516C6B0", Offset = "0x516B0B0", VA = "0x18516C6B0", Slot = "17")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700009A")]
	public JGKAIJBBCDC KPBINMPEPCH
	{
		[Cpp2IlInjected.Token(Token = "0x6000231")]
		[Cpp2IlInjected.Address(RVA = "0x516EB70", Offset = "0x516D570", VA = "0x18516EB70", Slot = "18")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000232")]
		[Cpp2IlInjected.Address(RVA = "0x516FEA0", Offset = "0x516E8A0", VA = "0x18516FEA0", Slot = "19")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700009B")]
	public float KJKDBCBOHIJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000233")]
		[Cpp2IlInjected.Address(RVA = "0x516A7C0", Offset = "0x51691C0", VA = "0x18516A7C0", Slot = "20")]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x6000234")]
		[Cpp2IlInjected.Address(RVA = "0x516FA80", Offset = "0x516E480", VA = "0x18516FA80", Slot = "21")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700009C")]
	public Vector3 BOJDMEIPMAO
	{
		[Cpp2IlInjected.Token(Token = "0x6000235")]
		[Cpp2IlInjected.Address(RVA = "0x516EDC0", Offset = "0x516D7C0", VA = "0x18516EDC0", Slot = "22")]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x6000236")]
		[Cpp2IlInjected.Address(RVA = "0x516C7D0", Offset = "0x516B1D0", VA = "0x18516C7D0", Slot = "23")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700009D")]
	public Vector3 DALJIIPOFIE
	{
		[Cpp2IlInjected.Token(Token = "0x6000237")]
		[Cpp2IlInjected.Address(RVA = "0x516AE80", Offset = "0x5169880", VA = "0x18516AE80", Slot = "24")]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x6000238")]
		[Cpp2IlInjected.Address(RVA = "0x516AB20", Offset = "0x5169520", VA = "0x18516AB20", Slot = "25")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700009E")]
	public Vector3 OMPLHOFEJAN
	{
		[Cpp2IlInjected.Token(Token = "0x6000239")]
		[Cpp2IlInjected.Address(RVA = "0x516C400", Offset = "0x516AE00", VA = "0x18516C400", Slot = "26")]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x600023A")]
		[Cpp2IlInjected.Address(RVA = "0x516E500", Offset = "0x516CF00", VA = "0x18516E500", Slot = "27")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700009F")]
	public Vector3 IPICDHHHJOG
	{
		[Cpp2IlInjected.Token(Token = "0x600023B")]
		[Cpp2IlInjected.Address(RVA = "0x516B890", Offset = "0x516A290", VA = "0x18516B890", Slot = "28")]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x600023C")]
		[Cpp2IlInjected.Address(RVA = "0x516E900", Offset = "0x516D300", VA = "0x18516E900", Slot = "29")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A0")]
	public bool KENDHOCAHBA
	{
		[Cpp2IlInjected.Token(Token = "0x600023D")]
		[Cpp2IlInjected.Address(RVA = "0x516C0E0", Offset = "0x516AAE0", VA = "0x18516C0E0", Slot = "30")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A1")]
	public bool EHJFPLNBAAH
	{
		[Cpp2IlInjected.Token(Token = "0x600023E")]
		[Cpp2IlInjected.Address(RVA = "0x516A690", Offset = "0x5169090", VA = "0x18516A690", Slot = "31")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A2")]
	public bool PLHBBEKOBGN
	{
		[Cpp2IlInjected.Token(Token = "0x600023F")]
		[Cpp2IlInjected.Address(RVA = "0x516F500", Offset = "0x516DF00", VA = "0x18516F500", Slot = "32")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A3")]
	public bool NKPLDABKJCL
	{
		[Cpp2IlInjected.Token(Token = "0x6000240")]
		[Cpp2IlInjected.Address(RVA = "0x516DD10", Offset = "0x516C710", VA = "0x18516DD10", Slot = "33")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A4")]
	public Vector3 GNKPAMJBNBD
	{
		[Cpp2IlInjected.Token(Token = "0x6000251")]
		[Cpp2IlInjected.Address(RVA = "0x516C330", Offset = "0x516AD30", VA = "0x18516C330", Slot = "34")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A5")]
	public Vector3 DECHPPBODKH
	{
		[Cpp2IlInjected.Token(Token = "0x6000252")]
		[Cpp2IlInjected.Address(RVA = "0x516C260", Offset = "0x516AC60", VA = "0x18516C260", Slot = "35")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A6")]
	public Vector3 AAGDOJLDOMM
	{
		[Cpp2IlInjected.Token(Token = "0x6000257")]
		[Cpp2IlInjected.Address(RVA = "0x5170400", Offset = "0x516EE00", VA = "0x185170400", Slot = "36")]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x6000258")]
		[Cpp2IlInjected.Address(RVA = "0x516F9B0", Offset = "0x516E3B0", VA = "0x18516F9B0", Slot = "37")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A7")]
	public Vector3 DJLPMKOMOHI
	{
		[Cpp2IlInjected.Token(Token = "0x6000259")]
		[Cpp2IlInjected.Address(RVA = "0x516AA00", Offset = "0x5169400", VA = "0x18516AA00", Slot = "38")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A8")]
	public float MGOEPMCMEHB
	{
		[Cpp2IlInjected.Token(Token = "0x600025A")]
		[Cpp2IlInjected.Address(RVA = "0x516B1F0", Offset = "0x5169BF0", VA = "0x18516B1F0", Slot = "39")]
		get
		{
			return default(float);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A9")]
	public float OEDNFOGCCII
	{
		[Cpp2IlInjected.Token(Token = "0x600025B")]
		[Cpp2IlInjected.Address(RVA = "0x516D180", Offset = "0x516BB80", VA = "0x18516D180", Slot = "40")]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x600025C")]
		[Cpp2IlInjected.Address(RVA = "0x516C180", Offset = "0x516AB80", VA = "0x18516C180", Slot = "41")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000AA")]
	public Vector3 KGPDAOIKKOA
	{
		[Cpp2IlInjected.Token(Token = "0x600025D")]
		[Cpp2IlInjected.Address(RVA = "0x516A510", Offset = "0x5168F10", VA = "0x18516A510", Slot = "42")]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x600025E")]
		[Cpp2IlInjected.Address(RVA = "0x516A6F0", Offset = "0x51690F0", VA = "0x18516A6F0", Slot = "43")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000AB")]
	public Quaternion GADCINNEPIK
	{
		[Cpp2IlInjected.Token(Token = "0x600025F")]
		[Cpp2IlInjected.Address(RVA = "0x516CFF0", Offset = "0x516B9F0", VA = "0x18516CFF0", Slot = "44")]
		get
		{
			return default(Quaternion);
		}
		[Cpp2IlInjected.Token(Token = "0x6000260")]
		[Cpp2IlInjected.Address(RVA = "0x516CA10", Offset = "0x516B410", VA = "0x18516CA10", Slot = "45")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000AC")]
	public float KDAOPIJAMOB
	{
		[Cpp2IlInjected.Token(Token = "0x6000264")]
		[Cpp2IlInjected.Address(RVA = "0x516B4F0", Offset = "0x5169EF0", VA = "0x18516B4F0", Slot = "46")]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x6000265")]
		[Cpp2IlInjected.Address(RVA = "0x516B6F0", Offset = "0x516A0F0", VA = "0x18516B6F0", Slot = "47")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000AD")]
	public float FEGLLEJAJOH
	{
		[Cpp2IlInjected.Token(Token = "0x6000266")]
		[Cpp2IlInjected.Address(RVA = "0x516F1C0", Offset = "0x516DBC0", VA = "0x18516F1C0", Slot = "48")]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x6000267")]
		[Cpp2IlInjected.Address(RVA = "0x516C080", Offset = "0x516AA80", VA = "0x18516C080", Slot = "49")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000AE")]
	public bool HGEMBEONDNJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000268")]
		[Cpp2IlInjected.Address(RVA = "0x516EFC0", Offset = "0x516D9C0", VA = "0x18516EFC0", Slot = "50")]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000269")]
		[Cpp2IlInjected.Address(RVA = "0x516AC40", Offset = "0x5169640", VA = "0x18516AC40", Slot = "51")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000AF")]
	public CKHEJONCKGK GGJLBGDDKGJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000271")]
		[Cpp2IlInjected.Address(RVA = "0x516CC20", Offset = "0x516B620", VA = "0x18516CC20", Slot = "52")]
		get
		{
			return default(CKHEJONCKGK);
		}
		[Cpp2IlInjected.Token(Token = "0x6000272")]
		[Cpp2IlInjected.Address(RVA = "0x516E5D0", Offset = "0x516CFD0", VA = "0x18516E5D0", Slot = "53")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B0")]
	public bool DEHDGKEMKCA
	{
		[Cpp2IlInjected.Token(Token = "0x6000275")]
		[Cpp2IlInjected.Address(RVA = "0x516F2F0", Offset = "0x516DCF0", VA = "0x18516F2F0", Slot = "54")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B1")]
	public Transform DPCGIDOBNGL
	{
		[Cpp2IlInjected.Token(Token = "0x600027C")]
		[Cpp2IlInjected.Address(RVA = "0x516DF50", Offset = "0x516C950", VA = "0x18516DF50", Slot = "55")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B2")]
	public Transform EAILDMMFMIE
	{
		[Cpp2IlInjected.Token(Token = "0x600027D")]
		[Cpp2IlInjected.Address(RVA = "0x516DF50", Offset = "0x516C950", VA = "0x18516DF50", Slot = "56")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B3")]
	public Vector3 HAPPDNNLGPN
	{
		[Cpp2IlInjected.Token(Token = "0x600027E")]
		[Cpp2IlInjected.Address(RVA = "0x5170350", Offset = "0x516ED50", VA = "0x185170350", Slot = "57")]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x600027F")]
		[Cpp2IlInjected.Address(RVA = "0x516F3A0", Offset = "0x516DDA0", VA = "0x18516F3A0", Slot = "58")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B4")]
	public float MAFJLHAELCE
	{
		[Cpp2IlInjected.Token(Token = "0x6000280")]
		[Cpp2IlInjected.Address(RVA = "0x516C900", Offset = "0x516B300", VA = "0x18516C900", Slot = "59")]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x6000281")]
		[Cpp2IlInjected.Address(RVA = "0x516CEF0", Offset = "0x516B8F0", VA = "0x18516CEF0", Slot = "60")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B5")]
	public float EEAGMHLGCPI
	{
		[Cpp2IlInjected.Token(Token = "0x6000282")]
		[Cpp2IlInjected.Address(RVA = "0x516F900", Offset = "0x516E300", VA = "0x18516F900", Slot = "61")]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x6000283")]
		[Cpp2IlInjected.Address(RVA = "0x516F010", Offset = "0x516DA10", VA = "0x18516F010", Slot = "62")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B6")]
	public Quaternion BDIPPGABHED
	{
		[Cpp2IlInjected.Token(Token = "0x6000284")]
		[Cpp2IlInjected.Address(RVA = "0x516C960", Offset = "0x516B360", VA = "0x18516C960", Slot = "63")]
		get
		{
			return default(Quaternion);
		}
		[Cpp2IlInjected.Token(Token = "0x6000285")]
		[Cpp2IlInjected.Address(RVA = "0x516C5E0", Offset = "0x516AFE0", VA = "0x18516C5E0", Slot = "64")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B7")]
	public Vector3 MLJGHHMBALO
	{
		[Cpp2IlInjected.Token(Token = "0x6000286")]
		[Cpp2IlInjected.Address(RVA = "0x516A5E0", Offset = "0x5168FE0", VA = "0x18516A5E0", Slot = "65")]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x6000287")]
		[Cpp2IlInjected.Address(RVA = "0x516E6E0", Offset = "0x516D0E0", VA = "0x18516E6E0", Slot = "66")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B8")]
	public Quaternion ADAPJGEEEOL
	{
		[Cpp2IlInjected.Token(Token = "0x6000288")]
		[Cpp2IlInjected.Address(RVA = "0x516EE90", Offset = "0x516D890", VA = "0x18516EE90", Slot = "67")]
		get
		{
			return default(Quaternion);
		}
		[Cpp2IlInjected.Token(Token = "0x6000289")]
		[Cpp2IlInjected.Address(RVA = "0x516C670", Offset = "0x516B070", VA = "0x18516C670", Slot = "68")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B9")]
	public RigidbodyConstraints AKGJCKADCBH
	{
		[Cpp2IlInjected.Token(Token = "0x600028D")]
		[Cpp2IlInjected.Address(RVA = "0x516DCC0", Offset = "0x516C6C0", VA = "0x18516DCC0", Slot = "69")]
		get
		{
			return default(RigidbodyConstraints);
		}
		[Cpp2IlInjected.Token(Token = "0x600028E")]
		[Cpp2IlInjected.Address(RVA = "0x516B240", Offset = "0x5169C40", VA = "0x18516B240", Slot = "70")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000BA")]
	public bool IELKFNIBHFB
	{
		[Cpp2IlInjected.Token(Token = "0x600028F")]
		[Cpp2IlInjected.Address(RVA = "0x516B2F0", Offset = "0x5169CF0", VA = "0x18516B2F0", Slot = "71")]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000290")]
		[Cpp2IlInjected.Address(RVA = "0x516DF60", Offset = "0x516C960", VA = "0x18516DF60", Slot = "72")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000BB")]
	public CollisionDetectionMode GDCFMCCNNGL
	{
		[Cpp2IlInjected.Token(Token = "0x6000299")]
		[Cpp2IlInjected.Address(RVA = "0x516ABF0", Offset = "0x51695F0", VA = "0x18516ABF0", Slot = "73")]
		get
		{
			return default(CollisionDetectionMode);
		}
		[Cpp2IlInjected.Token(Token = "0x600029A")]
		[Cpp2IlInjected.Address(RVA = "0x516F5E0", Offset = "0x516DFE0", VA = "0x18516F5E0", Slot = "74")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000BC")]
	public bool CEDDMPPAJDO
	{
		[Cpp2IlInjected.Token(Token = "0x600029C")]
		[Cpp2IlInjected.Address(RVA = "0x516CAE0", Offset = "0x516B4E0", VA = "0x18516CAE0", Slot = "75")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000021")]
	public event HOBHPHAMKBD IAOFFICNEFM
	{
		[Cpp2IlInjected.Token(Token = "0x600021F")]
		[Cpp2IlInjected.Address(RVA = "0x516BF60", Offset = "0x516A960", VA = "0x18516BF60", Slot = "81")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000220")]
		[Cpp2IlInjected.Address(RVA = "0x516BA00", Offset = "0x516A400", VA = "0x18516BA00", Slot = "82")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000022")]
	public event HOBHPHAMKBD BPJGPOJJOIC
	{
		[Cpp2IlInjected.Token(Token = "0x6000221")]
		[Cpp2IlInjected.Address(RVA = "0x516B640", Offset = "0x516A040", VA = "0x18516B640", Slot = "83")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000222")]
		[Cpp2IlInjected.Address(RVA = "0x516F690", Offset = "0x516E090", VA = "0x18516F690", Slot = "84")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000023")]
	public event ABBLHFOFAPM IANJCDBCFAJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000223")]
		[Cpp2IlInjected.Address(RVA = "0x5170240", Offset = "0x516EC40", VA = "0x185170240", Slot = "85")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000224")]
		[Cpp2IlInjected.Address(RVA = "0x516C8A0", Offset = "0x516B2A0", VA = "0x18516C8A0", Slot = "86")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000024")]
	public event HOBHPHAMKBD IBIGIAONNFK
	{
		[Cpp2IlInjected.Token(Token = "0x600022B")]
		[Cpp2IlInjected.Address(RVA = "0x516DC10", Offset = "0x516C610", VA = "0x18516DC10", Slot = "88")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600022C")]
		[Cpp2IlInjected.Address(RVA = "0x516C020", Offset = "0x516AA20", VA = "0x18516C020", Slot = "89")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000025")]
	public event HOBHPHAMKBD MPMMHJCOBJO
	{
		[Cpp2IlInjected.Token(Token = "0x6000255")]
		[Cpp2IlInjected.Address(RVA = "0x516F8A0", Offset = "0x516E2A0", VA = "0x18516F8A0", Slot = "108")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000256")]
		[Cpp2IlInjected.Address(RVA = "0x516F7F0", Offset = "0x516E1F0", VA = "0x18516F7F0", Slot = "109")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000026")]
	public event HOBHPHAMKBD IHIJNHOELAG
	{
		[Cpp2IlInjected.Token(Token = "0x600026A")]
		[Cpp2IlInjected.Address(RVA = "0x516A630", Offset = "0x5169030", VA = "0x18516A630", Slot = "113")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600026B")]
		[Cpp2IlInjected.Address(RVA = "0x516FC90", Offset = "0x516E690", VA = "0x18516FC90", Slot = "114")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000027")]
	public event Action<CEAPFNKIAFO, CEAPFNKIAFO> GAJNIIPFKOP
	{
		[Cpp2IlInjected.Token(Token = "0x600026F")]
		[Cpp2IlInjected.Address(RVA = "0x516CD20", Offset = "0x516B720", VA = "0x18516CD20", Slot = "117")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000270")]
		[Cpp2IlInjected.Address(RVA = "0x516D0C0", Offset = "0x516BAC0", VA = "0x18516D0C0", Slot = "118")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000028")]
	public event HOBHPHAMKBD PJPDOAADALA
	{
		[Cpp2IlInjected.Token(Token = "0x6000273")]
		[Cpp2IlInjected.Address(RVA = "0x516F340", Offset = "0x516DD40", VA = "0x18516F340", Slot = "119")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000274")]
		[Cpp2IlInjected.Address(RVA = "0x516D610", Offset = "0x516C010", VA = "0x18516D610", Slot = "120")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000029")]
	public event HOBHPHAMKBD JDPDGOHICPK
	{
		[Cpp2IlInjected.Token(Token = "0x600027A")]
		[Cpp2IlInjected.Address(RVA = "0x516D780", Offset = "0x516C180", VA = "0x18516D780", Slot = "125")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600027B")]
		[Cpp2IlInjected.Address(RVA = "0x516B960", Offset = "0x516A360", VA = "0x18516B960", Slot = "126")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000218")]
	[Cpp2IlInjected.Address(RVA = "0x515A260", Offset = "0x5158C60", VA = "0x18515A260")]
	public NMHAAMBBHKD(GameObject EHEABJNEALG, RigidbodyEx LMKJNNOGFLA, MPHIHDCLPDB HKMONJIHHIH, in IMECCMKFBII JIHCLPECHIB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000219")]
	[Cpp2IlInjected.Address(RVA = "0x516BC80", Offset = "0x516A680", VA = "0x18516BC80", Slot = "142")]
	protected virtual void EBMDLPECLDP(MPHIHDCLPDB HKMONJIHHIH, IMECCMKFBII JIHCLPECHIB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600021A")]
	[Cpp2IlInjected.Address(RVA = "0x516BAC0", Offset = "0x516A4C0", VA = "0x18516BAC0", Slot = "143")]
	public virtual void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600021B")]
	[Cpp2IlInjected.Address(RVA = "0x516FAE0", Offset = "0x516E4E0", VA = "0x18516FAE0", Slot = "76")]
	public void NOMIHBFFLNG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600021C")]
	[Cpp2IlInjected.Address(RVA = "0x516ACA0", Offset = "0x51696A0", VA = "0x18516ACA0", Slot = "77")]
	public void EFPEPNDIDBP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600021D")]
	[Cpp2IlInjected.Address(RVA = "0xFA66A0", Offset = "0xFA50A0", VA = "0x180FA66A0", Slot = "78")]
	public void AHFFBOOJKLD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600021E")]
	[Cpp2IlInjected.Address(RVA = "0x516F450", Offset = "0x516DE50", VA = "0x18516F450", Slot = "144")]
	public virtual void MKJLJFAPFNF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600022A")]
	[Cpp2IlInjected.Address(RVA = "0x516FC20", Offset = "0x516E620", VA = "0x18516FC20", Slot = "87")]
	public void OGODNIIEFFB(FFCGIONKJBI MAKFNMHIJIF, bool JAHLDBIKCJI = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000241")]
	[Cpp2IlInjected.Address(RVA = "0x516BA60", Offset = "0x516A460", VA = "0x18516BA60", Slot = "90")]
	public void DPOKFGFKBCC(object HKLDIENGNNB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000242")]
	[Cpp2IlInjected.Address(RVA = "0x516BFC0", Offset = "0x516A9C0", VA = "0x18516BFC0", Slot = "91")]
	public void EEPLGJOEHDM(object HKLDIENGNNB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000243")]
	[Cpp2IlInjected.Address(RVA = "0x516EED0", Offset = "0x516D8D0", VA = "0x18516EED0", Slot = "92")]
	public Vector3 LKOKGKNLODE(Vector3 JMLACAFKJOF)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000244")]
	[Cpp2IlInjected.Address(RVA = "0x516FF80", Offset = "0x516E980", VA = "0x18516FF80", Slot = "93")]
	public Vector3 PIFFFCJGHPG(Vector3 OLLLCEPAFHE)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000245")]
	[Cpp2IlInjected.Address(RVA = "0x516ACA0", Offset = "0x51696A0", VA = "0x18516ACA0", Slot = "94")]
	public void BCKDLBEFMPH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000246")]
	[Cpp2IlInjected.Address(RVA = "0x516F960", Offset = "0x516E360", VA = "0x18516F960", Slot = "95")]
	public void NLLIBPNNBGH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000247")]
	[Cpp2IlInjected.Address(RVA = "0x516F850", Offset = "0x516E250", VA = "0x18516F850", Slot = "96")]
	public void NFCJHIFEHGE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000248")]
	[Cpp2IlInjected.Address(RVA = "0x516EA30", Offset = "0x516D430", VA = "0x18516EA30", Slot = "97")]
	public void KPJAOLBLIEI(Vector3 PFDFFPLAJJP, Vector3 HGIFCPKBAGG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000249")]
	[Cpp2IlInjected.Address(RVA = "0x516BB90", Offset = "0x516A590", VA = "0x18516BB90", Slot = "98")]
	public void EBKBGNAGIOD(Vector3 LOGKBIHCFJD, Vector3 OGPMEJLJLFA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600024A")]
	[Cpp2IlInjected.Address(RVA = "0x516B7C0", Offset = "0x516A1C0", VA = "0x18516B7C0", Slot = "99")]
	public void DNAJDFGLENG(Vector3 OANHHGBFKAN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600024B")]
	[Cpp2IlInjected.Address(RVA = "0x516B0D0", Offset = "0x5169AD0", VA = "0x18516B0D0", Slot = "100")]
	public void CBHLOBJDACM(CKAOOODELAE IKFPEHIFEPN, Vector3 NMBFBKMEJKN, float FEHHFHACKBK, float IOFMPFNPHNC = 8f, float JKLGNKAKKLG = 1f)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600024C")]
	[Cpp2IlInjected.Address(RVA = "0x516F6F0", Offset = "0x516E0F0", VA = "0x18516F6F0", Slot = "101")]
	public void NCIJALPIGCE(MCMFGEDCCGC LMLMHHPMBJO, Vector3 OFLGCJLDNJJ, float IPAPNFBMGEF = float.PositiveInfinity)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600024D")]
	[Cpp2IlInjected.Address(RVA = "0x516C4D0", Offset = "0x516AED0", VA = "0x18516C4D0", Slot = "102")]
	[Obsolete]
	public void FDJHKHJGOHO(MCMFGEDCCGC LMLMHHPMBJO, Vector3 JGCPJBFFFAC, float NMBEKOOKPJA = 7f, float MFBAPHBIEKM = 1f)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600024E")]
	[Cpp2IlInjected.Address(RVA = "0x516A810", Offset = "0x5169210", VA = "0x18516A810", Slot = "103")]
	public Vector3 AJLBGCPJCKN(Vector3 MAKFNMHIJIF)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x600024F")]
	[Cpp2IlInjected.Address(RVA = "0x5170070", Offset = "0x516EA70", VA = "0x185170070", Slot = "104")]
	public Vector3 PIFNCDNOKAD(Vector3 MAKFNMHIJIF)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000250")]
	[Cpp2IlInjected.Address(RVA = "0x516EB20", Offset = "0x516D520", VA = "0x18516EB20", Slot = "105")]
	public void LADPNNADDEK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000253")]
	[Cpp2IlInjected.Address(RVA = "0x516ECF0", Offset = "0x516D6F0", VA = "0x18516ECF0", Slot = "106")]
	public void LJGPKEPDMFN(FFCGIONKJBI HJFPEPOCKIC, object HKLDIENGNNB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000254")]
	[Cpp2IlInjected.Address(RVA = "0x516CCC0", Offset = "0x516B6C0", VA = "0x18516CCC0", Slot = "107")]
	public void GBMKLKMCAMC(object HKLDIENGNNB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000261")]
	[Cpp2IlInjected.Address(RVA = "0x516B080", Offset = "0x5169A80", VA = "0x18516B080", Slot = "110")]
	public void CAALKOKEPPD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000262")]
	[Cpp2IlInjected.Address(RVA = "0x516AAD0", Offset = "0x51694D0", VA = "0x18516AAD0", Slot = "111")]
	public void BANKNELMPFP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000263")]
	[Cpp2IlInjected.Address(RVA = "0x516CC70", Offset = "0x516B670", VA = "0x18516CC70", Slot = "112")]
	public void GAANFDFDMKC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600026C")]
	[Cpp2IlInjected.Address(RVA = "0x516F640", Offset = "0x516E040", VA = "0x18516F640", Slot = "115")]
	public bool MNIMMDJAIIP()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600026D")]
	[Cpp2IlInjected.Address(RVA = "0x516A900", Offset = "0x5169300", VA = "0x18516A900", Slot = "79")]
	public void ALKMJGDDHDA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600026E")]
	[Cpp2IlInjected.Address(RVA = "0x516EBC0", Offset = "0x516D5C0", VA = "0x18516EBC0", Slot = "116")]
	public void LEMLLHIPKGE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000276")]
	[Cpp2IlInjected.Address(RVA = "0x516DC70", Offset = "0x516C670", VA = "0x18516DC70", Slot = "121")]
	public IDisposable IFKNDGBNBEF()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000277")]
	[Cpp2IlInjected.Address(RVA = "0x516C710", Offset = "0x516B110", VA = "0x18516C710", Slot = "122")]
	public void FKOFNEMGINM(object HKLDIENGNNB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000278")]
	[Cpp2IlInjected.Address(RVA = "0x516ACF0", Offset = "0x51696F0", VA = "0x18516ACF0", Slot = "123")]
	public void BEHGOGKEFEN(object HKLDIENGNNB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000279")]
	[Cpp2IlInjected.Address(RVA = "0x516B750", Offset = "0x516A150", VA = "0x18516B750", Slot = "124")]
	public void DLBAIGNALBD(object HKLDIENGNNB, bool BKHDMOGADPG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600028A")]
	[Cpp2IlInjected.Address(RVA = "0x516E2A0", Offset = "0x516CCA0", VA = "0x18516E2A0", Slot = "127")]
	public void JEBPKKGFEDL(Vector3 AFHANPMAJON, Quaternion MGLHGJDPDPO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600028B")]
	[Cpp2IlInjected.Address(RVA = "0x516B340", Offset = "0x5169D40", VA = "0x18516B340", Slot = "128")]
	public void CIOEFCEIHBP(Vector3 JGOFLNCMNEF, Quaternion HHGDJGKIPDH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600028C")]
	[Cpp2IlInjected.Address(RVA = "0x516FCF0", Offset = "0x516E6F0", VA = "0x18516FCF0", Slot = "129")]
	public bool OJPJAEOKAPC(float CJJGIOGGJMO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000291")]
	[Cpp2IlInjected.Address(RVA = "0x516C770", Offset = "0x516B170", VA = "0x18516C770", Slot = "130")]
	public void FLGEALADFAB(object HKLDIENGNNB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000292")]
	[Cpp2IlInjected.Address(RVA = "0x516D120", Offset = "0x516BB20", VA = "0x18516D120", Slot = "131")]
	public void GOLJJNAJJDK(object HKLDIENGNNB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000293")]
	[Cpp2IlInjected.Address(RVA = "0x516D1D0", Offset = "0x516BBD0", VA = "0x18516D1D0", Slot = "132")]
	public void HCDCAKONHKH(object HKLDIENGNNB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000294")]
	[Cpp2IlInjected.Address(RVA = "0x516A9A0", Offset = "0x51693A0", VA = "0x18516A9A0", Slot = "133")]
	public void ANODKIPNKGG(object HKLDIENGNNB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000295")]
	[Cpp2IlInjected.Address(RVA = "0x516FF00", Offset = "0x516E900", VA = "0x18516FF00", Slot = "134")]
	public void PADGBNKEIIJ(Vector3 CBEIFKNKIIE, ForceMode OEBHACLNMCB = ForceMode.Force)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000296")]
	[Cpp2IlInjected.Address(RVA = "0x516D670", Offset = "0x516C070", VA = "0x18516D670", Slot = "135")]
	public void HKDCNICIFFL(Vector3 CBEIFKNKIIE, Vector3 EINGNKDKDHC, ForceMode OEBHACLNMCB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000297")]
	[Cpp2IlInjected.Address(RVA = "0x516C1E0", Offset = "0x516ABE0", VA = "0x18516C1E0", Slot = "136")]
	public void EPMGKEGNALO(Vector3 DEMLAEGANDJ, ForceMode OEBHACLNMCB = ForceMode.Force)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000298")]
	[Cpp2IlInjected.Address(RVA = "0x51701C0", Offset = "0x516EBC0", VA = "0x1851701C0", Slot = "137")]
	public void PINFLFOIKOH(Vector3 DEMLAEGANDJ, ForceMode OEBHACLNMCB = ForceMode.Force)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600029B")]
	[Cpp2IlInjected.Address(RVA = "0x516B540", Offset = "0x5169F40", VA = "0x18516B540", Slot = "138")]
	public bool COKAFBGHKMH(Vector3 FOGEFLLJLFJ, out RaycastHit LOOJGACDMOC, float IDHCBHDHMCK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600029D")]
	[Cpp2IlInjected.Address(RVA = "0x516B6A0", Offset = "0x516A0A0", VA = "0x18516B6A0", Slot = "139")]
	public void DFDCFAGILJM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600029E")]
	[Cpp2IlInjected.Address(RVA = "0x51704D0", Offset = "0x516EED0", VA = "0x1851704D0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600029F")]
	[Cpp2IlInjected.Address(RVA = "0x516E730", Offset = "0x516D130", VA = "0x18516E730")]
	private void KLDMCFHBMON()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002A0")]
	[Cpp2IlInjected.Address(RVA = "0x516FD90", Offset = "0x516E790", VA = "0x18516FD90")]
	private void OKOCHAGMMEH(FFCGIONKJBI LFAIGCEGCPL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002A1")]
	[Cpp2IlInjected.Address(RVA = "0x516DD60", Offset = "0x516C760", VA = "0x18516DD60")]
	private void ILOIOLJPCJK(FFCGIONKJBI LFAIGCEGCPL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002A2")]
	[Cpp2IlInjected.Address(RVA = "0x516D560", Offset = "0x516BF60", VA = "0x18516D560")]
	private void HEKIMGDLLBA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002A3")]
	[Cpp2IlInjected.Address(RVA = "0x516E800", Offset = "0x516D200", VA = "0x18516E800")]
	private void KLNLDCHFHKA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002A4")]
	[Cpp2IlInjected.Address(RVA = "0x51702A0", Offset = "0x516ECA0", VA = "0x1851702A0")]
	private void PNEHJDGDGIB(FFCGIONKJBI EBNAKIGKECH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002A5")]
	[Cpp2IlInjected.Address(RVA = "0x516F210", Offset = "0x516DC10", VA = "0x18516F210")]
	private void MELFMEBHFAF(FFCGIONKJBI LFAIGCEGCPL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002A6")]
	[Cpp2IlInjected.Address(RVA = "0x516AFA0", Offset = "0x51699A0", VA = "0x18516AFA0")]
	private void BLHLKMFLDGD(FFCGIONKJBI LFAIGCEGCPL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002A7")]
	[Cpp2IlInjected.Address(RVA = "0x516CD80", Offset = "0x516B780", VA = "0x18516CD80")]
	private void GIDDHIIKING(RigidbodyEx LFAIGCEGCPL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002A8")]
	[Cpp2IlInjected.Address(RVA = "0x516D870", Offset = "0x516C270", VA = "0x18516D870")]
	private void IDAHAJGPEBI(RigidbodyEx FHCKPPNILHO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002A9")]
	[Cpp2IlInjected.Address(RVA = "0x516AD50", Offset = "0x5169750", VA = "0x18516AD50")]
	[Conditional("UNITY_EDITOR")]
	private void BFCFJGIMHOP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002AA")]
	[Cpp2IlInjected.Address(RVA = "0x516DFC0", Offset = "0x516C9C0", VA = "0x18516DFC0")]
	protected void JBCBJFDKAKF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002AB")]
	[Cpp2IlInjected.Address(RVA = "0x516D230", Offset = "0x516BC30", VA = "0x18516D230")]
	protected void HCLPGFICBAA()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002A")]
internal static class CEKIFKHKOKD
{
	[Cpp2IlInjected.Token(Token = "0x60002AC")]
	[Cpp2IlInjected.Address(RVA = "0x5151150", Offset = "0x514FB50", VA = "0x185151150")]
	public static FFCGIONKJBI DDJFGNKMBJL(this FFCGIONKJBI FHCKPPNILHO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002AD")]
	[Cpp2IlInjected.Address(RVA = "0x5151290", Offset = "0x514FC90", VA = "0x185151290")]
	public static bool FIKNKJFNOKF(this FFCGIONKJBI FHCKPPNILHO, FFCGIONKJBI EPDAFINDPJC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002AE")]
	[Cpp2IlInjected.Address(RVA = "0x5151210", Offset = "0x514FC10", VA = "0x185151210")]
	public static bool FDEMDGEAPGF(this FFCGIONKJBI FHCKPPNILHO, FFCGIONKJBI PPMNPHOOLCH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002AF")]
	[Cpp2IlInjected.Address(RVA = "0x5151380", Offset = "0x514FD80", VA = "0x185151380")]
	public static RigidbodyEx MDFBJOGOGGI(this FFCGIONKJBI JHGMMLCOACP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002B0")]
	[Cpp2IlInjected.Address(RVA = "0x5151310", Offset = "0x514FD10", VA = "0x185151310")]
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
	[Cpp2IlInjected.Address(RVA = "0x515A390", Offset = "0x5158D90", VA = "0x18515A390")]
	public FBOFBKLHDPE(NMHAAMBBHKD KNIJILCEPPI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002B2")]
	[Cpp2IlInjected.Address(RVA = "0x515A330", Offset = "0x5158D30", VA = "0x18515A330", Slot = "4")]
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
		[Cpp2IlInjected.Address(RVA = "0x5168B10", Offset = "0x5167510", VA = "0x185168B10")]
		get
		{
			return default(CollisionDetectionMode);
		}
		[Cpp2IlInjected.Token(Token = "0x60002B5")]
		[Cpp2IlInjected.Address(RVA = "0x5168990", Offset = "0x5167390", VA = "0x185168990")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000BE")]
	private Rigidbody BKIDAKAFFMP
	{
		[Cpp2IlInjected.Token(Token = "0x60002B6")]
		[Cpp2IlInjected.Address(RVA = "0x5156590", Offset = "0x5154F90", VA = "0x185156590")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000BF")]
	public CollisionDetectionMode GDCFMCCNNGL
	{
		[Cpp2IlInjected.Token(Token = "0x60002B9")]
		[Cpp2IlInjected.Address(RVA = "0x51686F0", Offset = "0x51670F0", VA = "0x1851686F0", Slot = "4")]
		get
		{
			return default(CollisionDetectionMode);
		}
		[Cpp2IlInjected.Token(Token = "0x60002BA")]
		[Cpp2IlInjected.Address(RVA = "0x5168BF0", Offset = "0x51675F0", VA = "0x185168BF0", Slot = "5")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60002B3")]
	[Cpp2IlInjected.Address(RVA = "0x514C790", Offset = "0x514B190", VA = "0x18514C790")]
	public LFJKEMJKDPC(FFCGIONKJBI FHCKPPNILHO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002B7")]
	[Cpp2IlInjected.Address(RVA = "0x5168C70", Offset = "0x5167670", VA = "0x185168C70", Slot = "6")]
	public void NOMIHBFFLNG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002B8")]
	[Cpp2IlInjected.Address(RVA = "0x5168A80", Offset = "0x5167480", VA = "0x185168A80", Slot = "9")]
	public void KDPOLAHOOPE(Rigidbody MKOMGOCHBJC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002BB")]
	[Cpp2IlInjected.Address(RVA = "0x5168970", Offset = "0x5167370", VA = "0x185168970", Slot = "7")]
	public void FICELACKBCB(bool IGMFHMLOGDC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002BC")]
	[Cpp2IlInjected.Address(RVA = "0x5168980", Offset = "0x5167380", VA = "0x185168980", Slot = "8")]
	public void GDPJJGMKJBP(bool IGMFHMLOGDC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002BD")]
	[Cpp2IlInjected.Address(RVA = "0x5168800", Offset = "0x5167200", VA = "0x185168800", Slot = "10")]
	public bool COKAFBGHKMH(Vector3 FOGEFLLJLFJ, out RaycastHit LOOJGACDMOC, float IDHCBHDHMCK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002BE")]
	[Cpp2IlInjected.Address(RVA = "0x5168D80", Offset = "0x5167780", VA = "0x185168D80")]
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
		[Cpp2IlInjected.Address(RVA = "0x5168610", Offset = "0x5167010", VA = "0x185168610")]
		get
		{
			return default(CKHEJONCKGK);
		}
		[Cpp2IlInjected.Token(Token = "0x60002C3")]
		[Cpp2IlInjected.Address(RVA = "0x51684C0", Offset = "0x5166EC0", VA = "0x1851684C0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000C1")]
	public CKHEJONCKGK GGJLBGDDKGJ
	{
		[Cpp2IlInjected.Token(Token = "0x60002C4")]
		[Cpp2IlInjected.Address(RVA = "0x5168160", Offset = "0x5166B60", VA = "0x185168160", Slot = "6")]
		get
		{
			return default(CKHEJONCKGK);
		}
		[Cpp2IlInjected.Token(Token = "0x60002C5")]
		[Cpp2IlInjected.Address(RVA = "0x51684C0", Offset = "0x5166EC0", VA = "0x1851684C0", Slot = "7")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000C2")]
	private Transform PDEMFIDJPNF
	{
		[Cpp2IlInjected.Token(Token = "0x60002CA")]
		[Cpp2IlInjected.Address(RVA = "0x67E170", Offset = "0x67CB70", VA = "0x18067E170", Slot = "10")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400002A")]
	public event Action<CEAPFNKIAFO, CEAPFNKIAFO> GAJNIIPFKOP
	{
		[Cpp2IlInjected.Token(Token = "0x60002C0")]
		[Cpp2IlInjected.Address(RVA = "0x5168380", Offset = "0x5166D80", VA = "0x185168380", Slot = "4")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60002C1")]
		[Cpp2IlInjected.Address(RVA = "0x5168420", Offset = "0x5166E20", VA = "0x185168420", Slot = "5")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60002BF")]
	[Cpp2IlInjected.Address(RVA = "0x514C790", Offset = "0x514B190", VA = "0x18514C790")]
	public LFGDFNGNDPM(FFCGIONKJBI FHCKPPNILHO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002C6")]
	[Cpp2IlInjected.Address(RVA = "0x51685B0", Offset = "0x5166FB0", VA = "0x1851685B0", Slot = "11")]
	public void OnChangedDistanceBand(CEAPFNKIAFO GLJCMMBCBOC, CEAPFNKIAFO PNPBNOELPMC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002C7")]
	[Cpp2IlInjected.Address(RVA = "0x690EB0", Offset = "0x68F8B0", VA = "0x180690EB0", Slot = "12")]
	public void OnChangedVisibility(bool MDMFNFBFLBD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002C8")]
	[Cpp2IlInjected.Address(RVA = "0x690EB0", Offset = "0x68F8B0", VA = "0x180690EB0", Slot = "8")]
	public void NOMIHBFFLNG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002C9")]
	[Cpp2IlInjected.Address(RVA = "0x690EB0", Offset = "0x68F8B0", VA = "0x180690EB0", Slot = "9")]
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
		[Cpp2IlInjected.Address(RVA = "0x5156590", Offset = "0x5154F90", VA = "0x185156590")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000C4")]
	private bool DEHDGKEMKCA
	{
		[Cpp2IlInjected.Token(Token = "0x60002CD")]
		[Cpp2IlInjected.Address(RVA = "0x5156CC0", Offset = "0x51556C0", VA = "0x185156CC0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000C5")]
	private bool CAIEJEMCAII
	{
		[Cpp2IlInjected.Token(Token = "0x60002CE")]
		[Cpp2IlInjected.Address(RVA = "0x514D700", Offset = "0x514C100", VA = "0x18514D700")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000C6")]
	private FFCGIONKJBI HDIMMFJBNPK
	{
		[Cpp2IlInjected.Token(Token = "0x60002CF")]
		[Cpp2IlInjected.Address(RVA = "0x5156860", Offset = "0x5155260", VA = "0x185156860")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60002CB")]
	[Cpp2IlInjected.Address(RVA = "0x514C790", Offset = "0x514B190", VA = "0x18514C790")]
	public DCODNFJFBCO(FFCGIONKJBI FHCKPPNILHO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002D0")]
	[Cpp2IlInjected.Address(RVA = "0x5156F90", Offset = "0x5155990", VA = "0x185156F90", Slot = "4")]
	public void PADGBNKEIIJ(Vector3 CBEIFKNKIIE, ForceMode OEBHACLNMCB = ForceMode.Force)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002D1")]
	[Cpp2IlInjected.Address(RVA = "0x5156D10", Offset = "0x5155710", VA = "0x185156D10")]
	private void OFMHFHDJNMM(Vector3 CBEIFKNKIIE, ForceMode OEBHACLNMCB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002D2")]
	[Cpp2IlInjected.Address(RVA = "0x5156A20", Offset = "0x5155420", VA = "0x185156A20", Slot = "5")]
	public void HKDCNICIFFL(Vector3 CBEIFKNKIIE, Vector3 EINGNKDKDHC, ForceMode OEBHACLNMCB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002D3")]
	[Cpp2IlInjected.Address(RVA = "0x51568C0", Offset = "0x51552C0", VA = "0x1851568C0", Slot = "6")]
	public void EPMGKEGNALO(Vector3 DEMLAEGANDJ, ForceMode OEBHACLNMCB = ForceMode.Force)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002D4")]
	[Cpp2IlInjected.Address(RVA = "0x51565E0", Offset = "0x5154FE0", VA = "0x1851565E0")]
	private void AOALFPILCPL(Vector3 DEMLAEGANDJ, ForceMode OEBHACLNMCB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002D5")]
	[Cpp2IlInjected.Address(RVA = "0x51570F0", Offset = "0x5155AF0", VA = "0x1851570F0", Slot = "7")]
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
		[Cpp2IlInjected.Address(RVA = "0x515C140", Offset = "0x515AB40", VA = "0x18515C140", Slot = "4")]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x60002D8")]
		[Cpp2IlInjected.Address(RVA = "0x515BDF0", Offset = "0x515A7F0", VA = "0x18515BDF0", Slot = "5")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60002D6")]
	[Cpp2IlInjected.Address(RVA = "0x514C790", Offset = "0x514B190", VA = "0x18514C790")]
	public HBCABALLLDO(FFCGIONKJBI FHCKPPNILHO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002D9")]
	[Cpp2IlInjected.Address(RVA = "0x515C040", Offset = "0x515AA40", VA = "0x18515C040", Slot = "6")]
	public void KDPOLAHOOPE(Rigidbody MKOMGOCHBJC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002DA")]
	[Cpp2IlInjected.Address(RVA = "0x515BFD0", Offset = "0x515A9D0", VA = "0x18515BFD0", Slot = "7")]
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
		[Cpp2IlInjected.Address(RVA = "0x514F760", Offset = "0x514E160", VA = "0x18514F760")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000C9")]
	public NIALADIPDNC OBOIDIJMIJI
	{
		[Cpp2IlInjected.Token(Token = "0x60002F0")]
		[Cpp2IlInjected.Address(RVA = "0x514DB20", Offset = "0x514C520", VA = "0x18514DB20")]
		get
		{
			return default(NIALADIPDNC);
		}
		[Cpp2IlInjected.Token(Token = "0x60002F1")]
		[Cpp2IlInjected.Address(RVA = "0x514FC40", Offset = "0x514E640", VA = "0x18514FC40")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000CA")]
	public FFCGIONKJBI HDIMMFJBNPK
	{
		[Cpp2IlInjected.Token(Token = "0x60002F2")]
		[Cpp2IlInjected.Address(RVA = "0x514DE60", Offset = "0x514C860", VA = "0x18514DE60", Slot = "24")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60002F3")]
		[Cpp2IlInjected.Address(RVA = "0x514F650", Offset = "0x514E050", VA = "0x18514F650", Slot = "25")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000CB")]
	public NIALADIPDNC PPLLNBIKJPO
	{
		[Cpp2IlInjected.Token(Token = "0x60002F4")]
		[Cpp2IlInjected.Address(RVA = "0x514DC20", Offset = "0x514C620", VA = "0x18514DC20")]
		get
		{
			return default(NIALADIPDNC);
		}
		[Cpp2IlInjected.Token(Token = "0x60002F5")]
		[Cpp2IlInjected.Address(RVA = "0x514D8F0", Offset = "0x514C2F0", VA = "0x18514D8F0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000CC")]
	public FFCGIONKJBI AMKPOIHFDKH
	{
		[Cpp2IlInjected.Token(Token = "0x60002F6")]
		[Cpp2IlInjected.Address(RVA = "0x514ECF0", Offset = "0x514D6F0", VA = "0x18514ECF0", Slot = "23")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000CD")]
	public IReadOnlyList<FFCGIONKJBI> KEPEEEPLAGJ
	{
		[Cpp2IlInjected.Token(Token = "0x60002F7")]
		[Cpp2IlInjected.Address(RVA = "0x68D770", Offset = "0x68C170", VA = "0x18068D770", Slot = "22")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400002B")]
	public event HOBHPHAMKBD IAOFFICNEFM
	{
		[Cpp2IlInjected.Token(Token = "0x60002DC")]
		[Cpp2IlInjected.Address(RVA = "0x514E410", Offset = "0x514CE10", VA = "0x18514E410", Slot = "4")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60002DD")]
		[Cpp2IlInjected.Address(RVA = "0x514E1A0", Offset = "0x514CBA0", VA = "0x18514E1A0", Slot = "5")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400002C")]
	public event HOBHPHAMKBD BPJGPOJJOIC
	{
		[Cpp2IlInjected.Token(Token = "0x60002DE")]
		[Cpp2IlInjected.Address(RVA = "0x514DEA0", Offset = "0x514C8A0", VA = "0x18514DEA0", Slot = "6")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60002DF")]
		[Cpp2IlInjected.Address(RVA = "0x514F790", Offset = "0x514E190", VA = "0x18514F790", Slot = "7")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400002D")]
	public event ABBLHFOFAPM IANJCDBCFAJ
	{
		[Cpp2IlInjected.Token(Token = "0x60002E0")]
		[Cpp2IlInjected.Address(RVA = "0x514FBA0", Offset = "0x514E5A0", VA = "0x18514FBA0", Slot = "8")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60002E1")]
		[Cpp2IlInjected.Address(RVA = "0x514E670", Offset = "0x514D070", VA = "0x18514E670", Slot = "9")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400002E")]
	public event Action HGFICMNEKPD
	{
		[Cpp2IlInjected.Token(Token = "0x60002E2")]
		[Cpp2IlInjected.Address(RVA = "0x514E710", Offset = "0x514D110", VA = "0x18514E710", Slot = "10")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60002E3")]
		[Cpp2IlInjected.Address(RVA = "0x514E8F0", Offset = "0x514D2F0", VA = "0x18514E8F0", Slot = "11")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400002F")]
	public event Action AOLPOEKDAPB
	{
		[Cpp2IlInjected.Token(Token = "0x60002E4")]
		[Cpp2IlInjected.Address(RVA = "0x514E7B0", Offset = "0x514D1B0", VA = "0x18514E7B0", Slot = "12")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60002E5")]
		[Cpp2IlInjected.Address(RVA = "0x514F6C0", Offset = "0x514E0C0", VA = "0x18514F6C0", Slot = "13")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000030")]
	public event Action<FFCGIONKJBI> MIDFDOJCFED
	{
		[Cpp2IlInjected.Token(Token = "0x60002E6")]
		[Cpp2IlInjected.Address(RVA = "0x514E100", Offset = "0x514CB00", VA = "0x18514E100", Slot = "14")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60002E7")]
		[Cpp2IlInjected.Address(RVA = "0x514DD20", Offset = "0x514C720", VA = "0x18514DD20", Slot = "15")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000031")]
	public event Action<FFCGIONKJBI> ENHLMFMKKOI
	{
		[Cpp2IlInjected.Token(Token = "0x60002E8")]
		[Cpp2IlInjected.Address(RVA = "0x514FDC0", Offset = "0x514E7C0", VA = "0x18514FDC0", Slot = "16")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60002E9")]
		[Cpp2IlInjected.Address(RVA = "0x514E850", Offset = "0x514D250", VA = "0x18514E850", Slot = "17")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000032")]
	public event Action CBAHCMEOEBH
	{
		[Cpp2IlInjected.Token(Token = "0x60002EA")]
		[Cpp2IlInjected.Address(RVA = "0x514FB00", Offset = "0x514E500", VA = "0x18514FB00", Slot = "18")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60002EB")]
		[Cpp2IlInjected.Address(RVA = "0x514EC50", Offset = "0x514D650", VA = "0x18514EC50", Slot = "19")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000033")]
	public event Action<FFCGIONKJBI> PNGLKBMDHIJ
	{
		[Cpp2IlInjected.Token(Token = "0x60002EC")]
		[Cpp2IlInjected.Address(RVA = "0x514ED30", Offset = "0x514D730", VA = "0x18514ED30", Slot = "20")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60002ED")]
		[Cpp2IlInjected.Address(RVA = "0x514DDC0", Offset = "0x514C7C0", VA = "0x18514DDC0", Slot = "21")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60002DB")]
	[Cpp2IlInjected.Address(RVA = "0x514FE60", Offset = "0x514E860", VA = "0x18514FE60")]
	public BEAHBKMBHFL(FFCGIONKJBI FHCKPPNILHO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002EF")]
	[Cpp2IlInjected.Address(RVA = "0x514E240", Offset = "0x514CC40", VA = "0x18514E240", Slot = "27")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002F8")]
	[Cpp2IlInjected.Address(RVA = "0x514F830", Offset = "0x514E230", VA = "0x18514F830", Slot = "26")]
	public void OGODNIIEFFB(FFCGIONKJBI EBIGGMLCEAF, bool JAHLDBIKCJI = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002F9")]
	[Cpp2IlInjected.Address(RVA = "0x514F8B0", Offset = "0x514E2B0", VA = "0x18514F8B0")]
	private void OGODNIIEFFB(FAEFMAFLNLK EBIGGMLCEAF, bool JAHLDBIKCJI = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002FA")]
	[Cpp2IlInjected.Address(RVA = "0x514EDD0", Offset = "0x514D7D0", VA = "0x18514EDD0")]
	private void KJJDIBPOPCP(FAEFMAFLNLK EBIGGMLCEAF, bool JAHLDBIKCJI = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002FB")]
	[Cpp2IlInjected.Address(RVA = "0x514E4B0", Offset = "0x514CEB0", VA = "0x18514E4B0")]
	private void FKPIKBICOFJ(FAEFMAFLNLK EBNAKIGKECH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002FC")]
	[Cpp2IlInjected.Address(RVA = "0x514DF40", Offset = "0x514C940", VA = "0x18514DF40")]
	private void DCJINOKJEFG(FAEFMAFLNLK EBNAKIGKECH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002FD")]
	[Cpp2IlInjected.Address(RVA = "0x514EAB0", Offset = "0x514D4B0", VA = "0x18514EAB0")]
	private void IIHIMCEPCEK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002FE")]
	[Cpp2IlInjected.Address(RVA = "0x514FD40", Offset = "0x514E740", VA = "0x18514FD40")]
	private void PKKLCJELFEI(FAEFMAFLNLK EBNAKIGKECH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002FF")]
	[Cpp2IlInjected.Address(RVA = "0x514F920", Offset = "0x514E320", VA = "0x18514F920")]
	private void ONAEFPLNEDD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000300")]
	[Cpp2IlInjected.Address(RVA = "0x514E990", Offset = "0x514D390", VA = "0x18514E990")]
	private void IBNBBPLEKPA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000301")]
	[Cpp2IlInjected.Address(RVA = "0x514F9D0", Offset = "0x514E3D0", VA = "0x18514F9D0")]
	private void OPJJCFHECII(FAEFMAFLNLK FHCKPPNILHO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000302")]
	[Cpp2IlInjected.Address(RVA = "0x514D9F0", Offset = "0x514C3F0", VA = "0x18514D9F0")]
	private void APJHAKKKPLO(FAEFMAFLNLK FHCKPPNILHO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000303")]
	[Cpp2IlInjected.Address(RVA = "0x514D7F0", Offset = "0x514C1F0", VA = "0x18514D7F0")]
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
	[Cpp2IlInjected.Address(RVA = "0x5169C50", Offset = "0x5168650", VA = "0x185169C50")]
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
		[Cpp2IlInjected.Address(RVA = "0x515C680", Offset = "0x515B080", VA = "0x18515C680", Slot = "4")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000CF")]
	public Vector3 DECHPPBODKH
	{
		[Cpp2IlInjected.Token(Token = "0x6000307")]
		[Cpp2IlInjected.Address(RVA = "0x515C440", Offset = "0x515AE40", VA = "0x18515C440", Slot = "5")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000D0")]
	private Vector3 OMPLHOFEJAN
	{
		[Cpp2IlInjected.Token(Token = "0x600030B")]
		[Cpp2IlInjected.Address(RVA = "0x515C6B0", Offset = "0x515B0B0", VA = "0x18515C6B0")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000D1")]
	private FFCGIONKJBI POKCCLODFLP
	{
		[Cpp2IlInjected.Token(Token = "0x600030C")]
		[Cpp2IlInjected.Address(RVA = "0x515C2E0", Offset = "0x515ACE0", VA = "0x18515C2E0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000305")]
	[Cpp2IlInjected.Address(RVA = "0x514C790", Offset = "0x514B190", VA = "0x18514C790")]
	public HMENFJMBNPD(FFCGIONKJBI FHCKPPNILHO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000308")]
	[Cpp2IlInjected.Address(RVA = "0x515CC70", Offset = "0x515B670", VA = "0x18515CC70", Slot = "6")]
	public void KJONOMFBLIP(FFCGIONKJBI LFAIGCEGCPL, object HKLDIENGNNB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000309")]
	[Cpp2IlInjected.Address(RVA = "0x515CE00", Offset = "0x515B800", VA = "0x18515CE00")]
	private void KJONOMFBLIP(FAEFMAFLNLK LFAIGCEGCPL, object HKLDIENGNNB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600030A")]
	[Cpp2IlInjected.Address(RVA = "0x515C790", Offset = "0x515B190", VA = "0x18515C790", Slot = "7")]
	public void GBBOCMNIAIE(object HKLDIENGNNB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600030D")]
	[Cpp2IlInjected.Address(RVA = "0x515C880", Offset = "0x515B280", VA = "0x18515C880")]
	private Vector3 JCHOIMFBPCP()
	{
		return default(Vector3);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000033")]
internal static class KEJNAKAPHBH
{
	[Cpp2IlInjected.Token(Token = "0x600030E")]
	[Cpp2IlInjected.Address(RVA = "0x5167230", Offset = "0x5165C30", VA = "0x185167230")]
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
		[Cpp2IlInjected.Address(RVA = "0x5163270", Offset = "0x5161C70", VA = "0x185163270", Slot = "6")]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x6000313")]
		[Cpp2IlInjected.Address(RVA = "0x5161150", Offset = "0x515FB50", VA = "0x185161150", Slot = "7")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000D3")]
	public Vector3 DJLPMKOMOHI
	{
		[Cpp2IlInjected.Token(Token = "0x6000314")]
		[Cpp2IlInjected.Address(RVA = "0x515FE20", Offset = "0x515E820", VA = "0x18515FE20", Slot = "8")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000D4")]
	public float MGOEPMCMEHB
	{
		[Cpp2IlInjected.Token(Token = "0x6000315")]
		[Cpp2IlInjected.Address(RVA = "0x5160800", Offset = "0x515F200", VA = "0x185160800", Slot = "9")]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x6000316")]
		[Cpp2IlInjected.Address(RVA = "0x51614B0", Offset = "0x515FEB0", VA = "0x1851614B0")]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000D5")]
	public float OEDNFOGCCII
	{
		[Cpp2IlInjected.Token(Token = "0x6000317")]
		[Cpp2IlInjected.Address(RVA = "0x51613D0", Offset = "0x515FDD0", VA = "0x1851613D0", Slot = "10")]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x6000318")]
		[Cpp2IlInjected.Address(RVA = "0x5161290", Offset = "0x515FC90", VA = "0x185161290", Slot = "11")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000D6")]
	public Vector3 KGPDAOIKKOA
	{
		[Cpp2IlInjected.Token(Token = "0x6000319")]
		[Cpp2IlInjected.Address(RVA = "0x515FDC0", Offset = "0x515E7C0", VA = "0x18515FDC0", Slot = "12")]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x600031A")]
		[Cpp2IlInjected.Address(RVA = "0x515FDF0", Offset = "0x515E7F0", VA = "0x18515FDF0", Slot = "13")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000D7")]
	public Quaternion GADCINNEPIK
	{
		[Cpp2IlInjected.Token(Token = "0x600031B")]
		[Cpp2IlInjected.Address(RVA = "0x51613A0", Offset = "0x515FDA0", VA = "0x1851613A0", Slot = "14")]
		get
		{
			return default(Quaternion);
		}
		[Cpp2IlInjected.Token(Token = "0x600031C")]
		[Cpp2IlInjected.Address(RVA = "0x51612A0", Offset = "0x515FCA0", VA = "0x1851612A0", Slot = "15")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000D8")]
	private Rigidbody BKIDAKAFFMP
	{
		[Cpp2IlInjected.Token(Token = "0x6000324")]
		[Cpp2IlInjected.Address(RVA = "0x5156590", Offset = "0x5154F90", VA = "0x185156590")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000034")]
	public event HOBHPHAMKBD HHGAGCIOJJG
	{
		[Cpp2IlInjected.Token(Token = "0x600030F")]
		[Cpp2IlInjected.Address(RVA = "0x51627D0", Offset = "0x51611D0", VA = "0x1851627D0", Slot = "4")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000310")]
		[Cpp2IlInjected.Address(RVA = "0x5162510", Offset = "0x5160F10", VA = "0x185162510", Slot = "5")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000311")]
	[Cpp2IlInjected.Address(RVA = "0x51633A0", Offset = "0x5161DA0", VA = "0x1851633A0")]
	public ICCILKHGIAP(FFCGIONKJBI FHCKPPNILHO, in IMECCMKFBII JIHCLPECHIB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600031D")]
	[Cpp2IlInjected.Address(RVA = "0x51605F0", Offset = "0x515EFF0", VA = "0x1851605F0", Slot = "17")]
	public void CAALKOKEPPD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600031E")]
	[Cpp2IlInjected.Address(RVA = "0x515FF40", Offset = "0x515E940", VA = "0x18515FF40", Slot = "16")]
	public void BANKNELMPFP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600031F")]
	[Cpp2IlInjected.Address(RVA = "0x51625B0", Offset = "0x5160FB0", VA = "0x1851625B0", Slot = "19")]
	public void KDPOLAHOOPE(Rigidbody MKOMGOCHBJC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000320")]
	[Cpp2IlInjected.Address(RVA = "0x5160DD0", Offset = "0x515F7D0", VA = "0x185160DD0", Slot = "20")]
	public void DIDIIBMEDJD(Rigidbody MKOMGOCHBJC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000321")]
	[Cpp2IlInjected.Address(RVA = "0x51612C0", Offset = "0x515FCC0", VA = "0x1851612C0", Slot = "18")]
	public void GAANFDFDMKC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000322")]
	[Cpp2IlInjected.Address(RVA = "0x51608E0", Offset = "0x515F2E0", VA = "0x1851608E0", Slot = "21")]
	public void DFDCFAGILJM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000323")]
	[Cpp2IlInjected.Address(RVA = "0x5158FC0", Offset = "0x51579C0", VA = "0x185158FC0")]
	public void GHILHKNDAJA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000325")]
	[Cpp2IlInjected.Address(RVA = "0x5161150", Offset = "0x515FB50", VA = "0x185161150")]
	private void EDLHINCKBGC(Vector3 MAKFNMHIJIF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000326")]
	[Cpp2IlInjected.Address(RVA = "0x51604D0", Offset = "0x515EED0", VA = "0x1851604D0")]
	private Vector3 BKOHCPKDCEP()
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000327")]
	[Cpp2IlInjected.Address(RVA = "0x5162EE0", Offset = "0x51618E0", VA = "0x185162EE0")]
	private void NFOOMMJHALN(float MAKFNMHIJIF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000328")]
	[Cpp2IlInjected.Address(RVA = "0x51630B0", Offset = "0x5161AB0", VA = "0x1851630B0")]
	private void NGBNHFHHKHB(float MAKFNMHIJIF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000329")]
	[Cpp2IlInjected.Address(RVA = "0x5162AA0", Offset = "0x51614A0", VA = "0x185162AA0")]
	private Vector3 MHIHKHCHKBK()
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x600032A")]
	[Cpp2IlInjected.Address(RVA = "0x5162870", Offset = "0x5161270", VA = "0x185162870")]
	private void MEKMDDFDCDF(Vector3 MAKFNMHIJIF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600032B")]
	[Cpp2IlInjected.Address(RVA = "0x51602C0", Offset = "0x515ECC0", VA = "0x1851602C0")]
	private Quaternion BJFOMIEDANP()
	{
		return default(Quaternion);
	}

	[Cpp2IlInjected.Token(Token = "0x600032C")]
	[Cpp2IlInjected.Address(RVA = "0x5162CD0", Offset = "0x51616D0", VA = "0x185162CD0")]
	private void NBKELJCOCGM(Quaternion MAKFNMHIJIF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600032D")]
	[Cpp2IlInjected.Address(RVA = "0x51614C0", Offset = "0x515FEC0", VA = "0x1851614C0")]
	internal (float, Vector3) JIKMNOJPHEP(Rigidbody KBIMEMIPFEL)
	{
		return default((float, Vector3));
	}
}
[Cpp2IlInjected.Token(Token = "0x2000035")]
internal static class DDHDAKDHKEI
{
	[Cpp2IlInjected.Token(Token = "0x600032E")]
	[Cpp2IlInjected.Address(RVA = "0x5157370", Offset = "0x5155D70", VA = "0x185157370")]
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
		[Cpp2IlInjected.Address(RVA = "0x5155E00", Offset = "0x5154800", VA = "0x185155E00", Slot = "4")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000DA")]
	public MGONBPIMIEF AIAKBOMPCEL
	{
		[Cpp2IlInjected.Token(Token = "0x6000330")]
		[Cpp2IlInjected.Address(RVA = "0x5155FC0", Offset = "0x51549C0", VA = "0x185155FC0", Slot = "5")]
		get
		{
			return default(MGONBPIMIEF);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000DB")]
	private MGONBPIMIEF NMCGDNPMDNG
	{
		[Cpp2IlInjected.Token(Token = "0x6000332")]
		[Cpp2IlInjected.Address(RVA = "0x5155EE0", Offset = "0x51548E0", VA = "0x185155EE0")]
		get
		{
			return default(MGONBPIMIEF);
		}
		[Cpp2IlInjected.Token(Token = "0x6000333")]
		[Cpp2IlInjected.Address(RVA = "0x5156160", Offset = "0x5154B60", VA = "0x185156160")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000331")]
	[Cpp2IlInjected.Address(RVA = "0x5156420", Offset = "0x5154E20", VA = "0x185156420")]
	public CPFELHILEBO(FFCGIONKJBI FHCKPPNILHO, in IMECCMKFBII JIHCLPECHIB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000334")]
	[Cpp2IlInjected.Address(RVA = "0x5156250", Offset = "0x5154C50", VA = "0x185156250", Slot = "6")]
	public void NOMIHBFFLNG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000335")]
	[Cpp2IlInjected.Address(RVA = "0x51560C0", Offset = "0x5154AC0", VA = "0x1851560C0")]
	private bool MLCFJHLPAFK()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000336")]
	[Cpp2IlInjected.Address(RVA = "0x5155BC0", Offset = "0x51545C0", VA = "0x185155BC0", Slot = "7")]
	public void FCLIOEABILH(object HKLDIENGNNB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000337")]
	[Cpp2IlInjected.Address(RVA = "0x5155D00", Offset = "0x5154700", VA = "0x185155D00", Slot = "8")]
	public void HFELMDDPCOH(object HKLDIENGNNB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000338")]
	[Cpp2IlInjected.Address(RVA = "0x5156310", Offset = "0x5154D10", VA = "0x185156310", Slot = "11")]
	public void OLOGEBHENON()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000339")]
	[Cpp2IlInjected.Address(RVA = "0x5155FD0", Offset = "0x51549D0", VA = "0x185155FD0")]
	private void MDLEKMKMEOD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600033A")]
	[Cpp2IlInjected.Address(RVA = "0x5155A30", Offset = "0x5154430", VA = "0x185155A30")]
	private void BLBJEECBPFI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600033B")]
	[Cpp2IlInjected.Address(RVA = "0x5155B80", Offset = "0x5154580", VA = "0x185155B80", Slot = "10")]
	public void DAHMBDFDEKP(FFCGIONKJBI FHCKPPNILHO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600033C")]
	[Cpp2IlInjected.Address(RVA = "0x5155CC0", Offset = "0x51546C0", VA = "0x185155CC0", Slot = "9")]
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
		[Cpp2IlInjected.Address(RVA = "0x601F670", Offset = "0x601E070", VA = "0x18601F670", Slot = "6")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000DD")]
	public IEnumerable<object> JCMEBGAMNHL
	{
		[Cpp2IlInjected.Token(Token = "0x6000340")]
		[Cpp2IlInjected.Address(RVA = "0x601F1A0", Offset = "0x601DBA0", VA = "0x18601F1A0", Slot = "7")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000DE")]
	private bool EPJKDKDIKNE
	{
		[Cpp2IlInjected.Token(Token = "0x6000341")]
		[Cpp2IlInjected.Address(RVA = "0x601F700", Offset = "0x601E100", VA = "0x18601F700")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000035")]
	public event HOBHPHAMKBD EOJIPPCPFCI
	{
		[Cpp2IlInjected.Token(Token = "0x600033D")]
		[Cpp2IlInjected.Address(RVA = "0x601F290", Offset = "0x601DC90", VA = "0x18601F290", Slot = "4")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600033E")]
		[Cpp2IlInjected.Address(RVA = "0x601F560", Offset = "0x601DF60", VA = "0x18601F560", Slot = "5")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000342")]
	[Cpp2IlInjected.Address(RVA = "0x601F7F0", Offset = "0x601E1F0", VA = "0x18601F7F0")]
	public OKDICOADNMH(FFCGIONKJBI FHCKPPNILHO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000343")]
	[Cpp2IlInjected.Address(RVA = "0x601F500", Offset = "0x601DF00", VA = "0x18601F500", Slot = "11")]
	public IDisposable IFKNDGBNBEF()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000344")]
	[Cpp2IlInjected.Address(RVA = "0x601F4F0", Offset = "0x601DEF0", VA = "0x18601F4F0", Slot = "8")]
	public void FKOFNEMGINM(object HKLDIENGNNB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000345")]
	[Cpp2IlInjected.Address(RVA = "0x601F190", Offset = "0x601DB90", VA = "0x18601F190", Slot = "9")]
	public void BEHGOGKEFEN(object HKLDIENGNNB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000346")]
	[Cpp2IlInjected.Address(RVA = "0x601F360", Offset = "0x601DD60", VA = "0x18601F360", Slot = "10")]
	public void DLBAIGNALBD(object HKLDIENGNNB, bool BKHDMOGADPG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000347")]
	[Cpp2IlInjected.Address(RVA = "0x601F600", Offset = "0x601E000", VA = "0x18601F600", Slot = "12")]
	public void KDPOLAHOOPE(Rigidbody CCLEKJNADLB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000348")]
	[Cpp2IlInjected.Address(RVA = "0x601F330", Offset = "0x601DD30", VA = "0x18601F330", Slot = "13")]
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
		[Cpp2IlInjected.Address(RVA = "0x5154310", Offset = "0x5152D10", VA = "0x185154310", Slot = "6")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000E0")]
	public bool OFHGFFKKEMJ
	{
		[Cpp2IlInjected.Token(Token = "0x600034C")]
		[Cpp2IlInjected.Address(RVA = "0x51543D0", Offset = "0x5152DD0", VA = "0x1851543D0", Slot = "7")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000036")]
	public event HOBHPHAMKBD IBIGIAONNFK
	{
		[Cpp2IlInjected.Token(Token = "0x6000349")]
		[Cpp2IlInjected.Address(RVA = "0x5154330", Offset = "0x5152D30", VA = "0x185154330", Slot = "4")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600034A")]
		[Cpp2IlInjected.Address(RVA = "0x5154270", Offset = "0x5152C70", VA = "0x185154270", Slot = "5")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600034D")]
	[Cpp2IlInjected.Address(RVA = "0x5154D60", Offset = "0x5153760", VA = "0x185154D60")]
	public CLOGHEEOGJN(FFCGIONKJBI FHCKPPNILHO, in IMECCMKFBII JIHCLPECHIB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600034E")]
	[Cpp2IlInjected.Address(RVA = "0x5154AB0", Offset = "0x51534B0", VA = "0x185154AB0", Slot = "8")]
	public void NOMIHBFFLNG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600034F")]
	[Cpp2IlInjected.Address(RVA = "0x5154080", Offset = "0x5152A80", VA = "0x185154080", Slot = "11")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000350")]
	[Cpp2IlInjected.Address(RVA = "0x51546B0", Offset = "0x51530B0", VA = "0x1851546B0", Slot = "9")]
	public void MELFMEBHFAF(FFCGIONKJBI LFAIGCEGCPL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000351")]
	[Cpp2IlInjected.Address(RVA = "0x5153E70", Offset = "0x5152870", VA = "0x185153E70", Slot = "10")]
	public void BLHLKMFLDGD(FFCGIONKJBI LFAIGCEGCPL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000352")]
	[Cpp2IlInjected.Address(RVA = "0x51548C0", Offset = "0x51532C0", VA = "0x1851548C0")]
	private void NGOCABNBNDE(PhotonView MJGOFLGOOBD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000353")]
	[Cpp2IlInjected.Address(RVA = "0x5154C00", Offset = "0x5153600", VA = "0x185154C00")]
	private void OHFDKKBKPFB(RigidbodyEx NAKLMJNOFNJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000354")]
	[Cpp2IlInjected.Address(RVA = "0x51544E0", Offset = "0x5152EE0", VA = "0x1851544E0")]
	private void JOPMEJPILKG(PhotonView PAFPMHNEHHP)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000039")]
internal static class GGEMMNDABGL
{
	[Cpp2IlInjected.Token(Token = "0x6000355")]
	[Cpp2IlInjected.Address(RVA = "0x515B210", Offset = "0x5159C10", VA = "0x18515B210")]
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
		[Cpp2IlInjected.Address(RVA = "0x5150890", Offset = "0x514F290", VA = "0x185150890", Slot = "4")]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000357")]
		[Cpp2IlInjected.Address(RVA = "0x5150B50", Offset = "0x514F550", VA = "0x185150B50", Slot = "5")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000E2")]
	public bool FDKFFCJABEN
	{
		[Cpp2IlInjected.Token(Token = "0x6000358")]
		[Cpp2IlInjected.Address(RVA = "0x5150D40", Offset = "0x514F740", VA = "0x185150D40", Slot = "6")]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000359")]
		[Cpp2IlInjected.Address(RVA = "0x5150E20", Offset = "0x514F820", VA = "0x185150E20")]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000E3")]
	public RigidbodyConstraints AKGJCKADCBH
	{
		[Cpp2IlInjected.Token(Token = "0x600035A")]
		[Cpp2IlInjected.Address(RVA = "0x5150A70", Offset = "0x514F470", VA = "0x185150A70", Slot = "7")]
		get
		{
			return default(RigidbodyConstraints);
		}
		[Cpp2IlInjected.Token(Token = "0x600035B")]
		[Cpp2IlInjected.Address(RVA = "0x5150690", Offset = "0x514F090", VA = "0x185150690", Slot = "8")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600035C")]
	[Cpp2IlInjected.Address(RVA = "0x5150F10", Offset = "0x514F910", VA = "0x185150F10")]
	public CCLHEEOJOIK(FFCGIONKJBI FHCKPPNILHO, in IMECCMKFBII JIHCLPECHIB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600035D")]
	[Cpp2IlInjected.Address(RVA = "0x5150C40", Offset = "0x514F640", VA = "0x185150C40", Slot = "9")]
	public void KDPOLAHOOPE(Rigidbody MKOMGOCHBJC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600035E")]
	[Cpp2IlInjected.Address(RVA = "0x5150970", Offset = "0x514F370", VA = "0x185150970", Slot = "10")]
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
		[Cpp2IlInjected.Address(RVA = "0x5157640", Offset = "0x5156040", VA = "0x185157640", Slot = "4")]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x6000361")]
		[Cpp2IlInjected.Address(RVA = "0x5157720", Offset = "0x5156120", VA = "0x185157720", Slot = "5")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000E5")]
	public float FEGLLEJAJOH
	{
		[Cpp2IlInjected.Token(Token = "0x6000362")]
		[Cpp2IlInjected.Address(RVA = "0x5157D60", Offset = "0x5156760", VA = "0x185157D60", Slot = "6")]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x6000363")]
		[Cpp2IlInjected.Address(RVA = "0x51579C0", Offset = "0x51563C0", VA = "0x1851579C0", Slot = "7")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600035F")]
	[Cpp2IlInjected.Address(RVA = "0x514C790", Offset = "0x514B190", VA = "0x18514C790")]
	public DDPOLBEBBIP(FFCGIONKJBI FHCKPPNILHO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000364")]
	[Cpp2IlInjected.Address(RVA = "0x5157B90", Offset = "0x5156590", VA = "0x185157B90", Slot = "8")]
	public void KDPOLAHOOPE(Rigidbody MKOMGOCHBJC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000365")]
	[Cpp2IlInjected.Address(RVA = "0x51578F0", Offset = "0x51562F0", VA = "0x1851578F0", Slot = "9")]
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
			[Cpp2IlInjected.Address(RVA = "0x6918D0", Offset = "0x6902D0", VA = "0x1806918D0", Slot = "5")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000366")]
		[Cpp2IlInjected.Address(RVA = "0x6020EE0", Offset = "0x601F8E0", VA = "0x186020EE0", Slot = "4")]
		public void NDFJIGFEFMN(PFKGIHKPIGG GOCENLCAMDB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000367")]
		[Cpp2IlInjected.Address(RVA = "0x6020C00", Offset = "0x601F600", VA = "0x186020C00", Slot = "7")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000369")]
		[Cpp2IlInjected.Address(RVA = "0x6020C30", Offset = "0x601F630", VA = "0x186020C30", Slot = "6")]
		public void JIKMNOJPHEP(NIALADIPDNC KLCGNDEDAPD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600036A")]
		[Cpp2IlInjected.Address(RVA = "0x678B30", Offset = "0x677530", VA = "0x180678B30")]
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
		[Cpp2IlInjected.Address(RVA = "0x5156590", Offset = "0x5154F90", VA = "0x185156590")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000E8")]
	private bool IALJHIOHBON
	{
		[Cpp2IlInjected.Token(Token = "0x600036F")]
		[Cpp2IlInjected.Address(RVA = "0x5158F20", Offset = "0x5157920", VA = "0x185158F20")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000E9")]
	private bool CEDDMPPAJDO
	{
		[Cpp2IlInjected.Token(Token = "0x6000370")]
		[Cpp2IlInjected.Address(RVA = "0x514A780", Offset = "0x5149180", VA = "0x18514A780")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000EA")]
	private FFCGIONKJBI HDIMMFJBNPK
	{
		[Cpp2IlInjected.Token(Token = "0x6000371")]
		[Cpp2IlInjected.Address(RVA = "0x51589F0", Offset = "0x51573F0", VA = "0x1851589F0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000EB")]
	private bool CAIEJEMCAII
	{
		[Cpp2IlInjected.Token(Token = "0x6000372")]
		[Cpp2IlInjected.Address(RVA = "0x51597D0", Offset = "0x51581D0", VA = "0x1851597D0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000EC")]
	private bool ICIOBCKDGCC
	{
		[Cpp2IlInjected.Token(Token = "0x6000373")]
		[Cpp2IlInjected.Address(RVA = "0x5159000", Offset = "0x5157A00", VA = "0x185159000")]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000374")]
		[Cpp2IlInjected.Address(RVA = "0x5158A50", Offset = "0x5157450", VA = "0x185158A50")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000ED")]
	private bool LGCJELGHLMM
	{
		[Cpp2IlInjected.Token(Token = "0x6000375")]
		[Cpp2IlInjected.Address(RVA = "0x5158B40", Offset = "0x5157540", VA = "0x185158B40")]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000376")]
		[Cpp2IlInjected.Address(RVA = "0x51590F0", Offset = "0x5157AF0", VA = "0x1851590F0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000EE")]
	private int JMJIFDDFDLJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000377")]
		[Cpp2IlInjected.Address(RVA = "0x51594B0", Offset = "0x5157EB0", VA = "0x1851594B0")]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000378")]
		[Cpp2IlInjected.Address(RVA = "0x5159590", Offset = "0x5157F90", VA = "0x185159590")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000037")]
	public event HOBHPHAMKBD IHIJNHOELAG
	{
		[Cpp2IlInjected.Token(Token = "0x600036C")]
		[Cpp2IlInjected.Address(RVA = "0x51588A0", Offset = "0x51572A0", VA = "0x1851588A0", Slot = "4")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600036D")]
		[Cpp2IlInjected.Address(RVA = "0x5159730", Offset = "0x5158130", VA = "0x185159730", Slot = "5")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000379")]
	[Cpp2IlInjected.Address(RVA = "0x5159830", Offset = "0x5158230", VA = "0x185159830")]
	public EMHKLOKAGMK(FFCGIONKJBI FHCKPPNILHO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600037A")]
	[Cpp2IlInjected.Address(RVA = "0x5159680", Offset = "0x5158080", VA = "0x185159680", Slot = "6")]
	public void NOMIHBFFLNG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600037B")]
	[Cpp2IlInjected.Address(RVA = "0x51590E0", Offset = "0x5157AE0", VA = "0x1851590E0", Slot = "8")]
	public void JPLMLMHPLJA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600037C")]
	[Cpp2IlInjected.Address(RVA = "0x5159290", Offset = "0x5157C90", VA = "0x185159290", Slot = "7")]
	public bool MNIMMDJAIIP()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600037D")]
	[Cpp2IlInjected.Address(RVA = "0x5158940", Offset = "0x5157340", VA = "0x185158940", Slot = "9")]
	public void ALKMJGDDHDA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600037E")]
	[Cpp2IlInjected.Address(RVA = "0x5158FC0", Offset = "0x51579C0", VA = "0x185158FC0", Slot = "12")]
	public void HKDHIFCLEOH(bool HBGILCDGAGC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600037F")]
	[Cpp2IlInjected.Address(RVA = "0x51591E0", Offset = "0x5157BE0", VA = "0x1851591E0", Slot = "11")]
	public void LEMLLHIPKGE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000380")]
	[Cpp2IlInjected.Address(RVA = "0x690EB0", Offset = "0x68F8B0", VA = "0x180690EB0", Slot = "10")]
	public void HOBDPIODPAL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000381")]
	[Cpp2IlInjected.Address(RVA = "0x5158C20", Offset = "0x5157620", VA = "0x185158C20")]
	private bool FCFJIFCJPMN()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000382")]
	[Cpp2IlInjected.Address(RVA = "0x5158DD0", Offset = "0x51577D0", VA = "0x185158DD0")]
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
		[Cpp2IlInjected.Address(RVA = "0x514C810", Offset = "0x514B210", VA = "0x18514C810", Slot = "4")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000384")]
		[Cpp2IlInjected.Address(RVA = "0x514CE70", Offset = "0x514B870", VA = "0x18514CE70")]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000F0")]
	private bool CAIEJEMCAII
	{
		[Cpp2IlInjected.Token(Token = "0x6000385")]
		[Cpp2IlInjected.Address(RVA = "0x514D700", Offset = "0x514C100", VA = "0x18514D700")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000386")]
	[Cpp2IlInjected.Address(RVA = "0x514D760", Offset = "0x514C160", VA = "0x18514D760")]
	public BDPJCILGMIH(FFCGIONKJBI FHCKPPNILHO, in IMECCMKFBII JIHCLPECHIB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000387")]
	[Cpp2IlInjected.Address(RVA = "0x514D650", Offset = "0x514C050", VA = "0x18514D650", Slot = "5")]
	public void NOMIHBFFLNG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000388")]
	[Cpp2IlInjected.Address(RVA = "0x514CF60", Offset = "0x514B960", VA = "0x18514CF60", Slot = "6")]
	public void HCDCAKONHKH(object HKLDIENGNNB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000389")]
	[Cpp2IlInjected.Address(RVA = "0x514C8F0", Offset = "0x514B2F0", VA = "0x18514C8F0", Slot = "7")]
	public void ANODKIPNKGG(object HKLDIENGNNB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600038A")]
	[Cpp2IlInjected.Address(RVA = "0x514C9F0", Offset = "0x514B3F0", VA = "0x18514C9F0", Slot = "8")]
	public void CHKIFMMFIIK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600038B")]
	[Cpp2IlInjected.Address(RVA = "0x514D060", Offset = "0x514BA60", VA = "0x18514D060", Slot = "9")]
	public void JEGLELMGMOF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600038C")]
	[Cpp2IlInjected.Address(RVA = "0x514D480", Offset = "0x514BE80", VA = "0x18514D480", Slot = "10")]
	public void NFMKBGIADML()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600038D")]
	[Cpp2IlInjected.Address(RVA = "0x690EB0", Offset = "0x68F8B0", VA = "0x180690EB0", Slot = "11")]
	public void DHPOOPPINJB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600038E")]
	[Cpp2IlInjected.Address(RVA = "0x514CCB0", Offset = "0x514B6B0", VA = "0x18514CCB0")]
	private void CPKMCFBJNFD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600038F")]
	[Cpp2IlInjected.Address(RVA = "0x514D2C0", Offset = "0x514BCC0", VA = "0x18514D2C0")]
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
		[Cpp2IlInjected.Address(RVA = "0x514A110", Offset = "0x5148B10", VA = "0x18514A110", Slot = "4")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000391")]
		[Cpp2IlInjected.Address(RVA = "0x514A660", Offset = "0x5149060", VA = "0x18514A660", Slot = "5")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000F2")]
	public JGKAIJBBCDC KPBINMPEPCH
	{
		[Cpp2IlInjected.Token(Token = "0x6000392")]
		[Cpp2IlInjected.Address(RVA = "0x514B530", Offset = "0x5149F30", VA = "0x18514B530", Slot = "6")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000393")]
		[Cpp2IlInjected.Address(RVA = "0x514C3F0", Offset = "0x514ADF0", VA = "0x18514C3F0", Slot = "7")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000F3")]
	public Vector3 OMPLHOFEJAN
	{
		[Cpp2IlInjected.Token(Token = "0x6000394")]
		[Cpp2IlInjected.Address(RVA = "0x514A240", Offset = "0x5148C40", VA = "0x18514A240", Slot = "8")]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x6000395")]
		[Cpp2IlInjected.Address(RVA = "0x514ACC0", Offset = "0x51496C0", VA = "0x18514ACC0", Slot = "9")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000F4")]
	public Vector3 BOJDMEIPMAO
	{
		[Cpp2IlInjected.Token(Token = "0x6000396")]
		[Cpp2IlInjected.Address(RVA = "0x514B660", Offset = "0x514A060", VA = "0x18514B660", Slot = "10")]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x6000397")]
		[Cpp2IlInjected.Address(RVA = "0x514A750", Offset = "0x5149150", VA = "0x18514A750", Slot = "11")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000F5")]
	public Vector3 IPICDHHHJOG
	{
		[Cpp2IlInjected.Token(Token = "0x6000398")]
		[Cpp2IlInjected.Address(RVA = "0x5149D70", Offset = "0x5148770", VA = "0x185149D70", Slot = "12")]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x6000399")]
		[Cpp2IlInjected.Address(RVA = "0x514B100", Offset = "0x5149B00", VA = "0x18514B100", Slot = "13")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000F6")]
	public Vector3 DALJIIPOFIE
	{
		[Cpp2IlInjected.Token(Token = "0x600039A")]
		[Cpp2IlInjected.Address(RVA = "0x5149210", Offset = "0x5147C10", VA = "0x185149210", Slot = "14")]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x600039B")]
		[Cpp2IlInjected.Address(RVA = "0x5149170", Offset = "0x5147B70", VA = "0x185149170", Slot = "15")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000F7")]
	public float KJKDBCBOHIJ
	{
		[Cpp2IlInjected.Token(Token = "0x600039C")]
		[Cpp2IlInjected.Address(RVA = "0x5148FD0", Offset = "0x51479D0", VA = "0x185148FD0", Slot = "16")]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x600039D")]
		[Cpp2IlInjected.Address(RVA = "0x514C2F0", Offset = "0x514ACF0", VA = "0x18514C2F0", Slot = "17")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000F8")]
	public bool NKPLDABKJCL
	{
		[Cpp2IlInjected.Token(Token = "0x600039F")]
		[Cpp2IlInjected.Address(RVA = "0x514A970", Offset = "0x5149370", VA = "0x18514A970", Slot = "18")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000F9")]
	private GIGBMEPJFND IPDPPPGBPIC
	{
		[Cpp2IlInjected.Token(Token = "0x60003B3")]
		[Cpp2IlInjected.Address(RVA = "0x1EC3B90", Offset = "0x1EC2590", VA = "0x181EC3B90")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000FA")]
	private bool CEDDMPPAJDO
	{
		[Cpp2IlInjected.Token(Token = "0x60003B4")]
		[Cpp2IlInjected.Address(RVA = "0x514A780", Offset = "0x5149180", VA = "0x18514A780")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600039E")]
	[Cpp2IlInjected.Address(RVA = "0x514C790", Offset = "0x514B190", VA = "0x18514C790")]
	public ACPDPJKCAGM(FFCGIONKJBI FHCKPPNILHO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003A0")]
	[Cpp2IlInjected.Address(RVA = "0x514C300", Offset = "0x514AD00", VA = "0x18514C300", Slot = "20")]
	public void OGEMIEDCOED(object HKLDIENGNNB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003A1")]
	[Cpp2IlInjected.Address(RVA = "0x514B950", Offset = "0x514A350", VA = "0x18514B950", Slot = "31")]
	public void LPJEFBBEPMD(object HKLDIENGNNB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003A2")]
	[Cpp2IlInjected.Address(RVA = "0x51491A0", Offset = "0x5147BA0", VA = "0x1851491A0", Slot = "19")]
	public void NOMIHBFFLNG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003A3")]
	[Cpp2IlInjected.Address(RVA = "0x5149EC0", Offset = "0x51488C0", VA = "0x185149EC0", Slot = "37")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003A4")]
	[Cpp2IlInjected.Address(RVA = "0x514B0C0", Offset = "0x5149AC0", VA = "0x18514B0C0", Slot = "28")]
	public void KDPOLAHOOPE(Rigidbody MKOMGOCHBJC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003A5")]
	[Cpp2IlInjected.Address(RVA = "0x514B770", Offset = "0x514A170", VA = "0x18514B770", Slot = "36")]
	public Vector3 LKOKGKNLODE(Vector3 JMLACAFKJOF)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x60003A6")]
	[Cpp2IlInjected.Address(RVA = "0x514C4E0", Offset = "0x514AEE0", VA = "0x18514C4E0", Slot = "35")]
	public Vector3 PIFFFCJGHPG(Vector3 OLLLCEPAFHE)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x60003A7")]
	[Cpp2IlInjected.Address(RVA = "0x51491A0", Offset = "0x5147BA0", VA = "0x1851491A0", Slot = "27")]
	public void BCKDLBEFMPH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003A8")]
	[Cpp2IlInjected.Address(RVA = "0x514C2B0", Offset = "0x514ACB0", VA = "0x18514C2B0", Slot = "25")]
	public void NLLIBPNNBGH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003A9")]
	[Cpp2IlInjected.Address(RVA = "0x514C270", Offset = "0x514AC70", VA = "0x18514C270", Slot = "24")]
	public void NFCJHIFEHGE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003AA")]
	[Cpp2IlInjected.Address(RVA = "0x514B1C0", Offset = "0x5149BC0", VA = "0x18514B1C0", Slot = "34")]
	public void KPJAOLBLIEI(Vector3 PFDFFPLAJJP, Vector3 HGIFCPKBAGG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003AB")]
	[Cpp2IlInjected.Address(RVA = "0x5149FF0", Offset = "0x51489F0", VA = "0x185149FF0", Slot = "33")]
	public void EBKBGNAGIOD(Vector3 LOGKBIHCFJD, Vector3 OGPMEJLJLFA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003AC")]
	[Cpp2IlInjected.Address(RVA = "0x5149C10", Offset = "0x5148610", VA = "0x185149C10", Slot = "32")]
	public void DNAJDFGLENG(Vector3 OANHHGBFKAN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003AD")]
	[Cpp2IlInjected.Address(RVA = "0x5149330", Offset = "0x5147D30", VA = "0x185149330", Slot = "22")]
	public void CBHLOBJDACM(CKAOOODELAE IKFPEHIFEPN, Vector3 NMBFBKMEJKN, float FEHHFHACKBK, float IOFMPFNPHNC = 8f, float JKLGNKAKKLG = 1f)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003AE")]
	[Cpp2IlInjected.Address(RVA = "0x514BA40", Offset = "0x514A440", VA = "0x18514BA40", Slot = "21")]
	public void NCIJALPIGCE(MCMFGEDCCGC LMLMHHPMBJO, Vector3 OFLGCJLDNJJ, float IPAPNFBMGEF = float.PositiveInfinity)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003AF")]
	[Cpp2IlInjected.Address(RVA = "0x514A390", Offset = "0x5148D90", VA = "0x18514A390", Slot = "23")]
	[Obsolete]
	public void FDJHKHJGOHO(MCMFGEDCCGC LMLMHHPMBJO, Vector3 JGCPJBFFFAC, float NMBEKOOKPJA = 7f, float MFBAPHBIEKM = 1f)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003B0")]
	[Cpp2IlInjected.Address(RVA = "0x51490B0", Offset = "0x5147AB0", VA = "0x1851490B0", Slot = "30")]
	public Vector3 AJLBGCPJCKN(Vector3 CPHPLAEKCBK)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x60003B1")]
	[Cpp2IlInjected.Address(RVA = "0x514C6A0", Offset = "0x514B0A0", VA = "0x18514C6A0", Slot = "29")]
	public Vector3 PIFNCDNOKAD(Vector3 HOLPFINNOLF)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x60003B2")]
	[Cpp2IlInjected.Address(RVA = "0x514B400", Offset = "0x5149E00", VA = "0x18514B400", Slot = "26")]
	public void LADPNNADDEK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003B5")]
	[Cpp2IlInjected.Address(RVA = "0x514A7A0", Offset = "0x51491A0", VA = "0x18514A7A0")]
	private void GKNBMLJEJOF(float MAKFNMHIJIF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003B6")]
	[Cpp2IlInjected.Address(RVA = "0x514AB60", Offset = "0x5149560", VA = "0x18514AB60")]
	private void JEPNOFCGPGB(Vector3 OFLGCJLDNJJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003B7")]
	[Cpp2IlInjected.Address(RVA = "0x514AA50", Offset = "0x5149450", VA = "0x18514AA50")]
	private Vector3 JAOHNCJGCMP()
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x60003B8")]
	[Cpp2IlInjected.Address(RVA = "0x514AD80", Offset = "0x5149780", VA = "0x18514AD80")]
	private void JHJGANJBJGJ(Vector3 OLLLCEPAFHE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003B9")]
	[Cpp2IlInjected.Address(RVA = "0x51497A0", Offset = "0x51481A0", VA = "0x1851497A0")]
	private Vector3 CHBOIJCOGNN()
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x60003BA")]
	[Cpp2IlInjected.Address(RVA = "0x51498B0", Offset = "0x51482B0", VA = "0x1851498B0")]
	private void DEJPPLEHGBP(Vector3 MAKFNMHIJIF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003BB")]
	[Cpp2IlInjected.Address(RVA = "0x514BC70", Offset = "0x514A670", VA = "0x18514BC70")]
	private void NDFOCMJNPHI(Vector3 OLLLCEPAFHE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003BC")]
	[Cpp2IlInjected.Address(RVA = "0x514A050", Offset = "0x5148A50", VA = "0x18514A050")]
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
		[Cpp2IlInjected.Address(RVA = "0xC2AC60", Offset = "0xC29660", VA = "0x180C2AC60")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000FC")]
	protected NIALADIPDNC CDCHGJINIFC
	{
		[Cpp2IlInjected.Token(Token = "0x60003BE")]
		[Cpp2IlInjected.Address(RVA = "0x5167200", Offset = "0x5165C00", VA = "0x185167200")]
		get
		{
			return default(NIALADIPDNC);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60003BF")]
	[Cpp2IlInjected.Address(RVA = "0x514C790", Offset = "0x514B190", VA = "0x18514C790")]
	public KCCPFAJLCEJ(FFCGIONKJBI FHCKPPNILHO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003C0")]
	[Cpp2IlInjected.Address(RVA = "0x51670E0", Offset = "0x5165AE0", VA = "0x1851670E0")]
	protected FFCGIONKJBI FBJEIPCCEHK(NIALADIPDNC EHLCJHMJBBP)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000041")]
public class GONMKKHBNCK : LGNFMEIAMDG
{
	[Cpp2IlInjected.Token(Token = "0x60003C1")]
	[Cpp2IlInjected.Address(RVA = "0x515BB40", Offset = "0x515A540", VA = "0x18515BB40", Slot = "4")]
	public IPLGDMEHBOJ JLMEDKOMLPH(FFCGIONKJBI BMFGKMDOFCF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003C2")]
	[Cpp2IlInjected.Address(RVA = "0x515B670", Offset = "0x515A070", VA = "0x18515B670", Slot = "5")]
	public GLBLEGFKOKL FNHIMIMINLC(FFCGIONKJBI BMFGKMDOFCF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003C3")]
	[Cpp2IlInjected.Address(RVA = "0x515BAA0", Offset = "0x515A4A0", VA = "0x18515BAA0", Slot = "6")]
	public EBAADMBJLMD IIOHLMKEJEJ(FFCGIONKJBI BMFGKMDOFCF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003C4")]
	[Cpp2IlInjected.Address(RVA = "0x515BD50", Offset = "0x515A750", VA = "0x18515BD50", Slot = "7")]
	public EKNFOOIEIBK NHGIHLGNLLB(FFCGIONKJBI BMFGKMDOFCF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003C5")]
	[Cpp2IlInjected.Address(RVA = "0x515B2E0", Offset = "0x5159CE0", VA = "0x18515B2E0", Slot = "8")]
	public MNHBOEHCOIK AMEBPOAGMKI(FFCGIONKJBI BMFGKMDOFCF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003C6")]
	[Cpp2IlInjected.Address(RVA = "0x515B5D0", Offset = "0x5159FD0", VA = "0x18515B5D0", Slot = "9")]
	public CGKAANMHLMI CCKENOLAJIO(FFCGIONKJBI BMFGKMDOFCF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003C7")]
	[Cpp2IlInjected.Address(RVA = "0x515B340", Offset = "0x5159D40", VA = "0x18515B340", Slot = "10")]
	public MAMDKJFPNFM AOODCJDCKDB(FFCGIONKJBI BMFGKMDOFCF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003C8")]
	[Cpp2IlInjected.Address(RVA = "0x515BA00", Offset = "0x515A400", VA = "0x18515BA00", Slot = "11")]
	public GIGBMEPJFND IIMNBFJLPGA(FFCGIONKJBI BMFGKMDOFCF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003C9")]
	[Cpp2IlInjected.Address(RVA = "0x515B8A0", Offset = "0x515A2A0", VA = "0x18515B8A0", Slot = "12")]
	public MFNEPAJBKBE GLEBFEAEHBH(FFCGIONKJBI BMFGKMDOFCF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003CA")]
	[Cpp2IlInjected.Address(RVA = "0x515B410", Offset = "0x5159E10", VA = "0x18515B410", Slot = "13")]
	public JJPLOLDPKDF BBOIPMMNANN(FFCGIONKJBI BMFGKMDOFCF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003CB")]
	[Cpp2IlInjected.Address(RVA = "0x515BC90", Offset = "0x515A690", VA = "0x18515BC90")]
	public OOPDNBAAJIE LKGBOKHAFIF(FFCGIONKJBI BMFGKMDOFCF, in IMECCMKFBII JIHCLPECHIB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003CC")]
	[Cpp2IlInjected.Address(RVA = "0x515B940", Offset = "0x515A340", VA = "0x18515B940")]
	public BHMDAAMOACJ GLKJADAGIAD(FFCGIONKJBI BMFGKMDOFCF, in IMECCMKFBII JIHCLPECHIB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003CD")]
	[Cpp2IlInjected.Address(RVA = "0x515B710", Offset = "0x515A110", VA = "0x18515B710")]
	public CMCPDJMPOKN FOJJLIDIPCI(FFCGIONKJBI BMFGKMDOFCF, in IMECCMKFBII JIHCLPECHIB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003CE")]
	[Cpp2IlInjected.Address(RVA = "0x515B270", Offset = "0x5159C70", VA = "0x18515B270")]
	public CHBALODMMNE GLGIJKKAPGN(FFCGIONKJBI BMFGKMDOFCF, in IMECCMKFBII JIHCLPECHIB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003CF")]
	[Cpp2IlInjected.Address(RVA = "0x515B3A0", Offset = "0x5159DA0", VA = "0x18515B3A0")]
	public KPBILAHOHAH ODODIKBAKJK(FFCGIONKJBI BMFGKMDOFCF, in IMECCMKFBII JIHCLPECHIB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003D0")]
	[Cpp2IlInjected.Address(RVA = "0x515B4B0", Offset = "0x5159EB0", VA = "0x18515B4B0", Slot = "19")]
	public FFCGIONKJBI CAKONGBGLCH(RigidbodyEx FHCKPPNILHO, IMECCMKFBII JIHCLPECHIB, MPHIHDCLPDB HKMONJIHHIH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003D1")]
	[Cpp2IlInjected.Address(RVA = "0x678B30", Offset = "0x677530", VA = "0x180678B30")]
	public GONMKKHBNCK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003D2")]
	[Cpp2IlInjected.Address(RVA = "0x515BC90", Offset = "0x515A690", VA = "0x18515BC90", Slot = "14")]
	private OOPDNBAAJIE KGODCDCCGDL(FFCGIONKJBI BMFGKMDOFCF, in IMECCMKFBII JIHCLPECHIB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003D3")]
	[Cpp2IlInjected.Address(RVA = "0x515B940", Offset = "0x515A340", VA = "0x18515B940", Slot = "15")]
	private BHMDAAMOACJ PJPJIFJAEAJ(FFCGIONKJBI BMFGKMDOFCF, in IMECCMKFBII JIHCLPECHIB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003D4")]
	[Cpp2IlInjected.Address(RVA = "0x515B710", Offset = "0x515A110", VA = "0x18515B710", Slot = "16")]
	private CMCPDJMPOKN IHLIJBJMJOL(FFCGIONKJBI BMFGKMDOFCF, in IMECCMKFBII JIHCLPECHIB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003D5")]
	[Cpp2IlInjected.Address(RVA = "0x515B270", Offset = "0x5159C70", VA = "0x18515B270", Slot = "17")]
	private CHBALODMMNE AHPBLOONHKN(FFCGIONKJBI BMFGKMDOFCF, in IMECCMKFBII JIHCLPECHIB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003D6")]
	[Cpp2IlInjected.Address(RVA = "0x515B3A0", Offset = "0x5159DA0", VA = "0x18515B3A0", Slot = "18")]
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
		[Cpp2IlInjected.Address(RVA = "0x6020260", Offset = "0x601EC60", VA = "0x186020260", Slot = "5")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000FE")]
	public FFCGIONKJBI EAAIOELEIIM
	{
		[Cpp2IlInjected.Token(Token = "0x60003DB")]
		[Cpp2IlInjected.Address(RVA = "0x6020330", Offset = "0x601ED30", VA = "0x186020330", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60003D7")]
	[Cpp2IlInjected.Address(RVA = "0x6020210", Offset = "0x601EC10", VA = "0x186020210")]
	public PBMBFCMPFNE(NIALADIPDNC EHLCJHMJBBP, PJCBAJNDEOE AGMOENMHCDB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003D8")]
	[Cpp2IlInjected.Address(RVA = "0x6020080", Offset = "0x601EA80", VA = "0x186020080", Slot = "6")]
	public IEnumerator<FFCGIONKJBI> GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003D9")]
	[Cpp2IlInjected.Address(RVA = "0x6020080", Offset = "0x601EA80", VA = "0x186020080", Slot = "7")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003DC")]
	[Cpp2IlInjected.Address(RVA = "0x6020070", Offset = "0x601EA70", VA = "0x186020070")]
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
		[Cpp2IlInjected.Address(RVA = "0x5166DA0", Offset = "0x51657A0", VA = "0x185166DA0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60003DD")]
	[Cpp2IlInjected.Address(RVA = "0x5166F50", Offset = "0x5165950", VA = "0x185166F50", Slot = "20")]
	public void NDFJIGFEFMN(PFKGIHKPIGG GOCENLCAMDB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003DF")]
	[Cpp2IlInjected.Address(RVA = "0x5166E00", Offset = "0x5165800", VA = "0x185166E00", Slot = "4")]
	public IPLGDMEHBOJ JLMEDKOMLPH(FFCGIONKJBI BMFGKMDOFCF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003E0")]
	[Cpp2IlInjected.Address(RVA = "0x51669C0", Offset = "0x51653C0", VA = "0x1851669C0", Slot = "5")]
	public GLBLEGFKOKL FNHIMIMINLC(FFCGIONKJBI BMFGKMDOFCF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003E1")]
	[Cpp2IlInjected.Address(RVA = "0x5166D00", Offset = "0x5165700", VA = "0x185166D00", Slot = "6")]
	public EBAADMBJLMD IIOHLMKEJEJ(FFCGIONKJBI BMFGKMDOFCF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003E2")]
	[Cpp2IlInjected.Address(RVA = "0x5166FA0", Offset = "0x51659A0", VA = "0x185166FA0", Slot = "7")]
	public EKNFOOIEIBK NHGIHLGNLLB(FFCGIONKJBI BMFGKMDOFCF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003E3")]
	[Cpp2IlInjected.Address(RVA = "0x51665A0", Offset = "0x5164FA0", VA = "0x1851665A0", Slot = "8")]
	public MNHBOEHCOIK AMEBPOAGMKI(FFCGIONKJBI BMFGKMDOFCF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003E4")]
	[Cpp2IlInjected.Address(RVA = "0x5166920", Offset = "0x5165320", VA = "0x185166920", Slot = "9")]
	public CGKAANMHLMI CCKENOLAJIO(FFCGIONKJBI BMFGKMDOFCF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003E5")]
	[Cpp2IlInjected.Address(RVA = "0x5166640", Offset = "0x5165040", VA = "0x185166640", Slot = "10")]
	public MAMDKJFPNFM AOODCJDCKDB(FFCGIONKJBI BMFGKMDOFCF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003E6")]
	[Cpp2IlInjected.Address(RVA = "0x5166C60", Offset = "0x5165660", VA = "0x185166C60", Slot = "11")]
	public GIGBMEPJFND IIMNBFJLPGA(FFCGIONKJBI BMFGKMDOFCF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003E7")]
	[Cpp2IlInjected.Address(RVA = "0x5166B10", Offset = "0x5165510", VA = "0x185166B10", Slot = "12")]
	public MFNEPAJBKBE GLEBFEAEHBH(FFCGIONKJBI BMFGKMDOFCF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003E8")]
	[Cpp2IlInjected.Address(RVA = "0x5166790", Offset = "0x5165190", VA = "0x185166790", Slot = "13")]
	public JJPLOLDPKDF BBOIPMMNANN(FFCGIONKJBI BMFGKMDOFCF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003E9")]
	[Cpp2IlInjected.Address(RVA = "0x5166EA0", Offset = "0x51658A0", VA = "0x185166EA0")]
	public OOPDNBAAJIE LKGBOKHAFIF(FFCGIONKJBI BMFGKMDOFCF, in IMECCMKFBII JIHCLPECHIB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003EA")]
	[Cpp2IlInjected.Address(RVA = "0x5166BB0", Offset = "0x51655B0", VA = "0x185166BB0")]
	public BHMDAAMOACJ GLKJADAGIAD(FFCGIONKJBI BMFGKMDOFCF, in IMECCMKFBII JIHCLPECHIB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003EB")]
	[Cpp2IlInjected.Address(RVA = "0x5166A60", Offset = "0x5165460", VA = "0x185166A60")]
	public CMCPDJMPOKN FOJJLIDIPCI(FFCGIONKJBI BMFGKMDOFCF, in IMECCMKFBII JIHCLPECHIB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003EC")]
	[Cpp2IlInjected.Address(RVA = "0x51664F0", Offset = "0x5164EF0", VA = "0x1851664F0")]
	public CHBALODMMNE GLGIJKKAPGN(FFCGIONKJBI BMFGKMDOFCF, in IMECCMKFBII JIHCLPECHIB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003ED")]
	[Cpp2IlInjected.Address(RVA = "0x51666E0", Offset = "0x51650E0", VA = "0x1851666E0")]
	public KPBILAHOHAH ODODIKBAKJK(FFCGIONKJBI BMFGKMDOFCF, in IMECCMKFBII JIHCLPECHIB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003EE")]
	[Cpp2IlInjected.Address(RVA = "0x5166830", Offset = "0x5165230", VA = "0x185166830", Slot = "19")]
	public FFCGIONKJBI CAKONGBGLCH(RigidbodyEx FHCKPPNILHO, IMECCMKFBII JIHCLPECHIB, MPHIHDCLPDB HKMONJIHHIH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003EF")]
	[Cpp2IlInjected.Address(RVA = "0x5167040", Offset = "0x5165A40", VA = "0x185167040")]
	public JGHLLDIPGHD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003F0")]
	[Cpp2IlInjected.Address(RVA = "0x5166EA0", Offset = "0x51658A0", VA = "0x185166EA0", Slot = "14")]
	private OOPDNBAAJIE KGODCDCCGDL(FFCGIONKJBI BMFGKMDOFCF, in IMECCMKFBII JIHCLPECHIB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003F1")]
	[Cpp2IlInjected.Address(RVA = "0x5166BB0", Offset = "0x51655B0", VA = "0x185166BB0", Slot = "15")]
	private BHMDAAMOACJ PJPJIFJAEAJ(FFCGIONKJBI BMFGKMDOFCF, in IMECCMKFBII JIHCLPECHIB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003F2")]
	[Cpp2IlInjected.Address(RVA = "0x5166A60", Offset = "0x5165460", VA = "0x185166A60", Slot = "16")]
	private CMCPDJMPOKN IHLIJBJMJOL(FFCGIONKJBI BMFGKMDOFCF, in IMECCMKFBII JIHCLPECHIB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003F3")]
	[Cpp2IlInjected.Address(RVA = "0x51664F0", Offset = "0x5164EF0", VA = "0x1851664F0", Slot = "17")]
	private CHBALODMMNE AHPBLOONHKN(FFCGIONKJBI BMFGKMDOFCF, in IMECCMKFBII JIHCLPECHIB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003F4")]
	[Cpp2IlInjected.Address(RVA = "0x51666E0", Offset = "0x51650E0", VA = "0x1851666E0", Slot = "18")]
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
		[Cpp2IlInjected.Address(RVA = "0x678AC0", Offset = "0x6774C0", VA = "0x180678AC0", Slot = "4")]
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
		[Cpp2IlInjected.Address(RVA = "0x6770C0", Offset = "0x675AC0", VA = "0x1806770C0", Slot = "5")]
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
		[Cpp2IlInjected.Address(RVA = "0x678120", Offset = "0x676B20", VA = "0x180678120", Slot = "6")]
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
		[Cpp2IlInjected.Address(RVA = "0x6918E0", Offset = "0x6902E0", VA = "0x1806918E0", Slot = "7")]
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
		[Cpp2IlInjected.Address(RVA = "0x68D6F0", Offset = "0x68C0F0", VA = "0x18068D6F0", Slot = "8")]
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
		[Cpp2IlInjected.Address(RVA = "0x67E570", Offset = "0x67CF70", VA = "0x18067E570", Slot = "9")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600040D")]
		[Cpp2IlInjected.Address(RVA = "0x67E590", Offset = "0x67CF90", VA = "0x18067E590", Slot = "10")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000106")]
	public IReadOnlyList<FFCGIONKJBI> KEPEEEPLAGJ
	{
		[Cpp2IlInjected.Token(Token = "0x600040E")]
		[Cpp2IlInjected.Address(RVA = "0x67E580", Offset = "0x67CF80", VA = "0x18067E580", Slot = "11")]
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
		[Cpp2IlInjected.Address(RVA = "0x6770D0", Offset = "0x675AD0", VA = "0x1806770D0", Slot = "12")]
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
		[Cpp2IlInjected.Address(RVA = "0x9F7B40", Offset = "0x9F6540", VA = "0x1809F7B40", Slot = "13")]
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
		[Cpp2IlInjected.Address(RVA = "0x1165700", Offset = "0x1164100", VA = "0x181165700", Slot = "14")]
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
		[Cpp2IlInjected.Address(RVA = "0xBF8470", Offset = "0xBF6E70", VA = "0x180BF8470", Slot = "15")]
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
		[Cpp2IlInjected.Address(RVA = "0x6770B0", Offset = "0x675AB0", VA = "0x1806770B0", Slot = "16")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000414")]
		[Cpp2IlInjected.Address(RVA = "0x76F300", Offset = "0x76DD00", VA = "0x18076F300", Slot = "17")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700010C")]
	public JGKAIJBBCDC KPBINMPEPCH
	{
		[Cpp2IlInjected.Token(Token = "0x6000415")]
		[Cpp2IlInjected.Address(RVA = "0x68D770", Offset = "0x68C170", VA = "0x18068D770", Slot = "18")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000416")]
		[Cpp2IlInjected.Address(RVA = "0x718AB0", Offset = "0x7174B0", VA = "0x180718AB0", Slot = "19")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700010D")]
	public float KJKDBCBOHIJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000417")]
		[Cpp2IlInjected.Address(RVA = "0x158B9E0", Offset = "0x158A3E0", VA = "0x18158B9E0", Slot = "20")]
		[CompilerGenerated]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x6000418")]
		[Cpp2IlInjected.Address(RVA = "0xE91440", Offset = "0xE8FE40", VA = "0x180E91440", Slot = "21")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700010E")]
	public Vector3 BOJDMEIPMAO
	{
		[Cpp2IlInjected.Token(Token = "0x6000419")]
		[Cpp2IlInjected.Address(RVA = "0x38A9F40", Offset = "0x38A8940", VA = "0x1838A9F40", Slot = "22")]
		[CompilerGenerated]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x600041A")]
		[Cpp2IlInjected.Address(RVA = "0x38A9E50", Offset = "0x38A8850", VA = "0x1838A9E50", Slot = "23")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700010F")]
	public Vector3 DALJIIPOFIE
	{
		[Cpp2IlInjected.Token(Token = "0x600041B")]
		[Cpp2IlInjected.Address(RVA = "0x19EC340", Offset = "0x19EAD40", VA = "0x1819EC340", Slot = "24")]
		[CompilerGenerated]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x600041C")]
		[Cpp2IlInjected.Address(RVA = "0x19E95D0", Offset = "0x19E7FD0", VA = "0x1819E95D0", Slot = "25")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000110")]
	public Vector3 OMPLHOFEJAN
	{
		[Cpp2IlInjected.Token(Token = "0x600041D")]
		[Cpp2IlInjected.Address(RVA = "0x19EC360", Offset = "0x19EAD60", VA = "0x1819EC360", Slot = "26")]
		[CompilerGenerated]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x600041E")]
		[Cpp2IlInjected.Address(RVA = "0x19EAFF0", Offset = "0x19E99F0", VA = "0x1819EAFF0", Slot = "27")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000111")]
	public Vector3 IPICDHHHJOG
	{
		[Cpp2IlInjected.Token(Token = "0x600041F")]
		[Cpp2IlInjected.Address(RVA = "0x104BCF0", Offset = "0x104A6F0", VA = "0x18104BCF0", Slot = "28")]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x6000420")]
		[Cpp2IlInjected.Address(RVA = "0x690EB0", Offset = "0x68F8B0", VA = "0x180690EB0", Slot = "29")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000112")]
	public bool KENDHOCAHBA
	{
		[Cpp2IlInjected.Token(Token = "0x6000421")]
		[Cpp2IlInjected.Address(RVA = "0xC2E890", Offset = "0xC2D290", VA = "0x180C2E890", Slot = "30")]
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
		[Cpp2IlInjected.Address(RVA = "0xC92C80", Offset = "0xC91680", VA = "0x180C92C80", Slot = "31")]
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
		[Cpp2IlInjected.Address(RVA = "0xC92C70", Offset = "0xC91670", VA = "0x180C92C70", Slot = "32")]
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
		[Cpp2IlInjected.Address(RVA = "0xAD5A70", Offset = "0xAD4470", VA = "0x180AD5A70", Slot = "33")]
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
		[Cpp2IlInjected.Address(RVA = "0x1443770", Offset = "0x1442170", VA = "0x181443770", Slot = "34")]
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
		[Cpp2IlInjected.Address(RVA = "0x1983590", Offset = "0x1981F90", VA = "0x181983590", Slot = "35")]
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
		[Cpp2IlInjected.Address(RVA = "0x104BCF0", Offset = "0x104A6F0", VA = "0x18104BCF0", Slot = "36")]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x6000428")]
		[Cpp2IlInjected.Address(RVA = "0x690EB0", Offset = "0x68F8B0", VA = "0x180690EB0", Slot = "37")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000119")]
	public Vector3 DJLPMKOMOHI
	{
		[Cpp2IlInjected.Token(Token = "0x6000429")]
		[Cpp2IlInjected.Address(RVA = "0x19EC420", Offset = "0x19EAE20", VA = "0x1819EC420", Slot = "38")]
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
		[Cpp2IlInjected.Address(RVA = "0x221B7F0", Offset = "0x221A1F0", VA = "0x18221B7F0", Slot = "39")]
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
		[Cpp2IlInjected.Address(RVA = "0x12DC850", Offset = "0x12DB250", VA = "0x1812DC850", Slot = "40")]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x600042C")]
		[Cpp2IlInjected.Address(RVA = "0x690EB0", Offset = "0x68F8B0", VA = "0x180690EB0", Slot = "41")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700011C")]
	public Vector3 KGPDAOIKKOA
	{
		[Cpp2IlInjected.Token(Token = "0x600042D")]
		[Cpp2IlInjected.Address(RVA = "0x104BCF0", Offset = "0x104A6F0", VA = "0x18104BCF0", Slot = "42")]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x600042E")]
		[Cpp2IlInjected.Address(RVA = "0x690EB0", Offset = "0x68F8B0", VA = "0x180690EB0", Slot = "43")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700011D")]
	public Quaternion GADCINNEPIK
	{
		[Cpp2IlInjected.Token(Token = "0x600042F")]
		[Cpp2IlInjected.Address(RVA = "0x1B51020", Offset = "0x1B4FA20", VA = "0x181B51020", Slot = "44")]
		get
		{
			return default(Quaternion);
		}
		[Cpp2IlInjected.Token(Token = "0x6000430")]
		[Cpp2IlInjected.Address(RVA = "0x690EB0", Offset = "0x68F8B0", VA = "0x180690EB0", Slot = "45")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700011E")]
	public float KDAOPIJAMOB
	{
		[Cpp2IlInjected.Token(Token = "0x6000431")]
		[Cpp2IlInjected.Address(RVA = "0x12DC850", Offset = "0x12DB250", VA = "0x1812DC850", Slot = "46")]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x6000432")]
		[Cpp2IlInjected.Address(RVA = "0x690EB0", Offset = "0x68F8B0", VA = "0x180690EB0", Slot = "47")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700011F")]
	public float FEGLLEJAJOH
	{
		[Cpp2IlInjected.Token(Token = "0x6000433")]
		[Cpp2IlInjected.Address(RVA = "0x12DC850", Offset = "0x12DB250", VA = "0x1812DC850", Slot = "48")]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x6000434")]
		[Cpp2IlInjected.Address(RVA = "0x690EB0", Offset = "0x68F8B0", VA = "0x180690EB0", Slot = "49")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000120")]
	public bool HGEMBEONDNJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000435")]
		[Cpp2IlInjected.Address(RVA = "0x67AD00", Offset = "0x679700", VA = "0x18067AD00", Slot = "50")]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000436")]
		[Cpp2IlInjected.Address(RVA = "0x690EB0", Offset = "0x68F8B0", VA = "0x180690EB0", Slot = "51")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000121")]
	public bool JMKHFLEOLCK
	{
		[Cpp2IlInjected.Token(Token = "0x6000437")]
		[Cpp2IlInjected.Address(RVA = "0x67AD00", Offset = "0x679700", VA = "0x18067AD00")]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000438")]
		[Cpp2IlInjected.Address(RVA = "0x690EB0", Offset = "0x68F8B0", VA = "0x180690EB0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000122")]
	public CKHEJONCKGK GGJLBGDDKGJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000439")]
		[Cpp2IlInjected.Address(RVA = "0x67AD00", Offset = "0x679700", VA = "0x18067AD00", Slot = "52")]
		get
		{
			return default(CKHEJONCKGK);
		}
		[Cpp2IlInjected.Token(Token = "0x600043A")]
		[Cpp2IlInjected.Address(RVA = "0x690EB0", Offset = "0x68F8B0", VA = "0x180690EB0", Slot = "53")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000123")]
	public bool DEHDGKEMKCA
	{
		[Cpp2IlInjected.Token(Token = "0x600043B")]
		[Cpp2IlInjected.Address(RVA = "0x1970EC0", Offset = "0x196F8C0", VA = "0x181970EC0", Slot = "54")]
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
		[Cpp2IlInjected.Address(RVA = "0x7A7C00", Offset = "0x7A6600", VA = "0x1807A7C00", Slot = "55")]
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
		[Cpp2IlInjected.Address(RVA = "0x72F7A0", Offset = "0x72E1A0", VA = "0x18072F7A0", Slot = "56")]
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
		[Cpp2IlInjected.Address(RVA = "0x104BCF0", Offset = "0x104A6F0", VA = "0x18104BCF0", Slot = "57")]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x600043F")]
		[Cpp2IlInjected.Address(RVA = "0x690EB0", Offset = "0x68F8B0", VA = "0x180690EB0", Slot = "58")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000127")]
	public float MAFJLHAELCE
	{
		[Cpp2IlInjected.Token(Token = "0x6000440")]
		[Cpp2IlInjected.Address(RVA = "0x12DC850", Offset = "0x12DB250", VA = "0x1812DC850", Slot = "59")]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x6000441")]
		[Cpp2IlInjected.Address(RVA = "0x690EB0", Offset = "0x68F8B0", VA = "0x180690EB0", Slot = "60")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000128")]
	public float EEAGMHLGCPI
	{
		[Cpp2IlInjected.Token(Token = "0x6000442")]
		[Cpp2IlInjected.Address(RVA = "0x12DC850", Offset = "0x12DB250", VA = "0x1812DC850", Slot = "61")]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x6000443")]
		[Cpp2IlInjected.Address(RVA = "0x690EB0", Offset = "0x68F8B0", VA = "0x180690EB0", Slot = "62")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000129")]
	public Quaternion BDIPPGABHED
	{
		[Cpp2IlInjected.Token(Token = "0x6000444")]
		[Cpp2IlInjected.Address(RVA = "0x11A6EC0", Offset = "0x11A58C0", VA = "0x1811A6EC0", Slot = "63")]
		get
		{
			return default(Quaternion);
		}
		[Cpp2IlInjected.Token(Token = "0x6000445")]
		[Cpp2IlInjected.Address(RVA = "0x690EB0", Offset = "0x68F8B0", VA = "0x180690EB0", Slot = "64")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700012A")]
	public Vector3 MLJGHHMBALO
	{
		[Cpp2IlInjected.Token(Token = "0x6000446")]
		[Cpp2IlInjected.Address(RVA = "0x104BCF0", Offset = "0x104A6F0", VA = "0x18104BCF0", Slot = "65")]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x6000447")]
		[Cpp2IlInjected.Address(RVA = "0x690EB0", Offset = "0x68F8B0", VA = "0x180690EB0", Slot = "66")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700012B")]
	public Quaternion ADAPJGEEEOL
	{
		[Cpp2IlInjected.Token(Token = "0x6000448")]
		[Cpp2IlInjected.Address(RVA = "0x11A6EC0", Offset = "0x11A58C0", VA = "0x1811A6EC0", Slot = "67")]
		get
		{
			return default(Quaternion);
		}
		[Cpp2IlInjected.Token(Token = "0x6000449")]
		[Cpp2IlInjected.Address(RVA = "0x690EB0", Offset = "0x68F8B0", VA = "0x180690EB0", Slot = "68")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700012C")]
	public RigidbodyConstraints AKGJCKADCBH
	{
		[Cpp2IlInjected.Token(Token = "0x600044A")]
		[Cpp2IlInjected.Address(RVA = "0x67E170", Offset = "0x67CB70", VA = "0x18067E170", Slot = "69")]
		get
		{
			return default(RigidbodyConstraints);
		}
		[Cpp2IlInjected.Token(Token = "0x600044B")]
		[Cpp2IlInjected.Address(RVA = "0x690EB0", Offset = "0x68F8B0", VA = "0x180690EB0", Slot = "70")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700012D")]
	public bool IELKFNIBHFB
	{
		[Cpp2IlInjected.Token(Token = "0x600044C")]
		[Cpp2IlInjected.Address(RVA = "0x67AD00", Offset = "0x679700", VA = "0x18067AD00", Slot = "71")]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x600044D")]
		[Cpp2IlInjected.Address(RVA = "0x690EB0", Offset = "0x68F8B0", VA = "0x180690EB0", Slot = "72")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700012E")]
	public CollisionDetectionMode GDCFMCCNNGL
	{
		[Cpp2IlInjected.Token(Token = "0x600044E")]
		[Cpp2IlInjected.Address(RVA = "0x67E170", Offset = "0x67CB70", VA = "0x18067E170", Slot = "73")]
		get
		{
			return default(CollisionDetectionMode);
		}
		[Cpp2IlInjected.Token(Token = "0x600044F")]
		[Cpp2IlInjected.Address(RVA = "0x690EB0", Offset = "0x68F8B0", VA = "0x180690EB0", Slot = "74")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700012F")]
	public bool CEDDMPPAJDO
	{
		[Cpp2IlInjected.Token(Token = "0x6000450")]
		[Cpp2IlInjected.Address(RVA = "0x11400E0", Offset = "0x113EAE0", VA = "0x1811400E0", Slot = "75")]
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
		[Cpp2IlInjected.Address(RVA = "0x690EB0", Offset = "0x68F8B0", VA = "0x180690EB0", Slot = "81")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60003F6")]
		[Cpp2IlInjected.Address(RVA = "0x690EB0", Offset = "0x68F8B0", VA = "0x180690EB0", Slot = "82")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000039")]
	public event HOBHPHAMKBD BPJGPOJJOIC
	{
		[Cpp2IlInjected.Token(Token = "0x60003F7")]
		[Cpp2IlInjected.Address(RVA = "0x690EB0", Offset = "0x68F8B0", VA = "0x180690EB0", Slot = "83")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60003F8")]
		[Cpp2IlInjected.Address(RVA = "0x690EB0", Offset = "0x68F8B0", VA = "0x180690EB0", Slot = "84")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400003A")]
	public event ABBLHFOFAPM IANJCDBCFAJ
	{
		[Cpp2IlInjected.Token(Token = "0x60003F9")]
		[Cpp2IlInjected.Address(RVA = "0x690EB0", Offset = "0x68F8B0", VA = "0x180690EB0", Slot = "85")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60003FA")]
		[Cpp2IlInjected.Address(RVA = "0x690EB0", Offset = "0x68F8B0", VA = "0x180690EB0", Slot = "86")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400003B")]
	public event HOBHPHAMKBD IBIGIAONNFK
	{
		[Cpp2IlInjected.Token(Token = "0x60003FB")]
		[Cpp2IlInjected.Address(RVA = "0x690EB0", Offset = "0x68F8B0", VA = "0x180690EB0", Slot = "88")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60003FC")]
		[Cpp2IlInjected.Address(RVA = "0x690EB0", Offset = "0x68F8B0", VA = "0x180690EB0", Slot = "89")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400003C")]
	public event HOBHPHAMKBD MPMMHJCOBJO
	{
		[Cpp2IlInjected.Token(Token = "0x60003FD")]
		[Cpp2IlInjected.Address(RVA = "0x690EB0", Offset = "0x68F8B0", VA = "0x180690EB0", Slot = "108")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60003FE")]
		[Cpp2IlInjected.Address(RVA = "0x690EB0", Offset = "0x68F8B0", VA = "0x180690EB0", Slot = "109")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400003D")]
	public event HOBHPHAMKBD IHIJNHOELAG
	{
		[Cpp2IlInjected.Token(Token = "0x60003FF")]
		[Cpp2IlInjected.Address(RVA = "0x690EB0", Offset = "0x68F8B0", VA = "0x180690EB0", Slot = "113")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000400")]
		[Cpp2IlInjected.Address(RVA = "0x690EB0", Offset = "0x68F8B0", VA = "0x180690EB0", Slot = "114")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400003E")]
	public event Action<CEAPFNKIAFO, CEAPFNKIAFO> GAJNIIPFKOP
	{
		[Cpp2IlInjected.Token(Token = "0x6000401")]
		[Cpp2IlInjected.Address(RVA = "0x690EB0", Offset = "0x68F8B0", VA = "0x180690EB0", Slot = "117")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000402")]
		[Cpp2IlInjected.Address(RVA = "0x690EB0", Offset = "0x68F8B0", VA = "0x180690EB0", Slot = "118")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400003F")]
	public event HOBHPHAMKBD PJPDOAADALA
	{
		[Cpp2IlInjected.Token(Token = "0x6000403")]
		[Cpp2IlInjected.Address(RVA = "0x690EB0", Offset = "0x68F8B0", VA = "0x180690EB0", Slot = "119")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000404")]
		[Cpp2IlInjected.Address(RVA = "0x690EB0", Offset = "0x68F8B0", VA = "0x180690EB0", Slot = "120")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000040")]
	public event HOBHPHAMKBD JDPDGOHICPK
	{
		[Cpp2IlInjected.Token(Token = "0x6000405")]
		[Cpp2IlInjected.Address(RVA = "0x690EB0", Offset = "0x68F8B0", VA = "0x180690EB0", Slot = "125")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000406")]
		[Cpp2IlInjected.Address(RVA = "0x690EB0", Offset = "0x68F8B0", VA = "0x180690EB0", Slot = "126")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000451")]
	[Cpp2IlInjected.Address(RVA = "0x690EB0", Offset = "0x68F8B0", VA = "0x180690EB0", Slot = "76")]
	public void NOMIHBFFLNG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000452")]
	[Cpp2IlInjected.Address(RVA = "0x690EB0", Offset = "0x68F8B0", VA = "0x180690EB0", Slot = "77")]
	public void EFPEPNDIDBP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000453")]
	[Cpp2IlInjected.Address(RVA = "0x690EB0", Offset = "0x68F8B0", VA = "0x180690EB0", Slot = "78")]
	public void AHFFBOOJKLD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000454")]
	[Cpp2IlInjected.Address(RVA = "0x690EB0", Offset = "0x68F8B0", VA = "0x180690EB0", Slot = "79")]
	public void ALKMJGDDHDA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000455")]
	[Cpp2IlInjected.Address(RVA = "0x690EB0", Offset = "0x68F8B0", VA = "0x180690EB0", Slot = "80")]
	public void MKJLJFAPFNF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000456")]
	[Cpp2IlInjected.Address(RVA = "0x690EB0", Offset = "0x68F8B0", VA = "0x180690EB0", Slot = "141")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000457")]
	[Cpp2IlInjected.Address(RVA = "0x690EB0", Offset = "0x68F8B0", VA = "0x180690EB0", Slot = "87")]
	public void OGODNIIEFFB(FFCGIONKJBI MAKFNMHIJIF, bool JAHLDBIKCJI = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000458")]
	[Cpp2IlInjected.Address(RVA = "0x690EB0", Offset = "0x68F8B0", VA = "0x180690EB0", Slot = "90")]
	public void DPOKFGFKBCC(object HKLDIENGNNB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000459")]
	[Cpp2IlInjected.Address(RVA = "0x690EB0", Offset = "0x68F8B0", VA = "0x180690EB0", Slot = "91")]
	public void EEPLGJOEHDM(object HKLDIENGNNB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600045A")]
	[Cpp2IlInjected.Address(RVA = "0x104BCF0", Offset = "0x104A6F0", VA = "0x18104BCF0", Slot = "92")]
	public Vector3 LKOKGKNLODE(Vector3 JMLACAFKJOF)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x600045B")]
	[Cpp2IlInjected.Address(RVA = "0x104BCF0", Offset = "0x104A6F0", VA = "0x18104BCF0", Slot = "93")]
	public Vector3 PIFFFCJGHPG(Vector3 OLLLCEPAFHE)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x600045C")]
	[Cpp2IlInjected.Address(RVA = "0x690EB0", Offset = "0x68F8B0", VA = "0x180690EB0", Slot = "94")]
	public void BCKDLBEFMPH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600045D")]
	[Cpp2IlInjected.Address(RVA = "0x690EB0", Offset = "0x68F8B0", VA = "0x180690EB0", Slot = "95")]
	public void NLLIBPNNBGH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600045E")]
	[Cpp2IlInjected.Address(RVA = "0x690EB0", Offset = "0x68F8B0", VA = "0x180690EB0", Slot = "96")]
	public void NFCJHIFEHGE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600045F")]
	[Cpp2IlInjected.Address(RVA = "0x690EB0", Offset = "0x68F8B0", VA = "0x180690EB0", Slot = "97")]
	public void KPJAOLBLIEI(Vector3 PFDFFPLAJJP, Vector3 HGIFCPKBAGG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000460")]
	[Cpp2IlInjected.Address(RVA = "0x690EB0", Offset = "0x68F8B0", VA = "0x180690EB0", Slot = "98")]
	public void EBKBGNAGIOD(Vector3 LOGKBIHCFJD, Vector3 OGPMEJLJLFA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000461")]
	[Cpp2IlInjected.Address(RVA = "0x690EB0", Offset = "0x68F8B0", VA = "0x180690EB0", Slot = "99")]
	public void DNAJDFGLENG(Vector3 OANHHGBFKAN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000462")]
	[Cpp2IlInjected.Address(RVA = "0x690EB0", Offset = "0x68F8B0", VA = "0x180690EB0", Slot = "100")]
	public void CBHLOBJDACM(CKAOOODELAE IKFPEHIFEPN, Vector3 NMBFBKMEJKN, float FEHHFHACKBK, float IOFMPFNPHNC = 8f, float JKLGNKAKKLG = 1f)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000463")]
	[Cpp2IlInjected.Address(RVA = "0x690EB0", Offset = "0x68F8B0", VA = "0x180690EB0", Slot = "101")]
	public void NCIJALPIGCE(MCMFGEDCCGC LMLMHHPMBJO, Vector3 OFLGCJLDNJJ, float IPAPNFBMGEF = float.PositiveInfinity)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000464")]
	[Cpp2IlInjected.Address(RVA = "0x690EB0", Offset = "0x68F8B0", VA = "0x180690EB0", Slot = "102")]
	public void FDJHKHJGOHO(MCMFGEDCCGC LMLMHHPMBJO, Vector3 JGCPJBFFFAC, float NMBEKOOKPJA = 7f, float MFBAPHBIEKM = 1f)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000465")]
	[Cpp2IlInjected.Address(RVA = "0x104BCF0", Offset = "0x104A6F0", VA = "0x18104BCF0", Slot = "103")]
	public Vector3 AJLBGCPJCKN(Vector3 MAKFNMHIJIF)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000466")]
	[Cpp2IlInjected.Address(RVA = "0x104BCF0", Offset = "0x104A6F0", VA = "0x18104BCF0", Slot = "104")]
	public Vector3 PIFNCDNOKAD(Vector3 MAKFNMHIJIF)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000467")]
	[Cpp2IlInjected.Address(RVA = "0x690EB0", Offset = "0x68F8B0", VA = "0x180690EB0", Slot = "105")]
	public void LADPNNADDEK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000468")]
	[Cpp2IlInjected.Address(RVA = "0x690EB0", Offset = "0x68F8B0", VA = "0x180690EB0", Slot = "106")]
	public void LJGPKEPDMFN(FFCGIONKJBI HJFPEPOCKIC, object HKLDIENGNNB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000469")]
	[Cpp2IlInjected.Address(RVA = "0x690EB0", Offset = "0x68F8B0", VA = "0x180690EB0", Slot = "107")]
	public void GBMKLKMCAMC(object HKLDIENGNNB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600046A")]
	[Cpp2IlInjected.Address(RVA = "0x690EB0", Offset = "0x68F8B0", VA = "0x180690EB0", Slot = "110")]
	public void CAALKOKEPPD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600046B")]
	[Cpp2IlInjected.Address(RVA = "0x690EB0", Offset = "0x68F8B0", VA = "0x180690EB0", Slot = "111")]
	public void BANKNELMPFP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600046C")]
	[Cpp2IlInjected.Address(RVA = "0x690EB0", Offset = "0x68F8B0", VA = "0x180690EB0", Slot = "112")]
	public void GAANFDFDMKC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600046D")]
	[Cpp2IlInjected.Address(RVA = "0x67AD00", Offset = "0x679700", VA = "0x18067AD00", Slot = "115")]
	public bool MNIMMDJAIIP()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600046E")]
	[Cpp2IlInjected.Address(RVA = "0x690EB0", Offset = "0x68F8B0", VA = "0x180690EB0", Slot = "116")]
	public void LEMLLHIPKGE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600046F")]
	[Cpp2IlInjected.Address(RVA = "0x67E170", Offset = "0x67CB70", VA = "0x18067E170", Slot = "121")]
	public IDisposable IFKNDGBNBEF()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000470")]
	[Cpp2IlInjected.Address(RVA = "0x690EB0", Offset = "0x68F8B0", VA = "0x180690EB0", Slot = "122")]
	public void FKOFNEMGINM(object HKLDIENGNNB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000471")]
	[Cpp2IlInjected.Address(RVA = "0x690EB0", Offset = "0x68F8B0", VA = "0x180690EB0", Slot = "123")]
	public void BEHGOGKEFEN(object HKLDIENGNNB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000472")]
	[Cpp2IlInjected.Address(RVA = "0x690EB0", Offset = "0x68F8B0", VA = "0x180690EB0", Slot = "124")]
	public void DLBAIGNALBD(object HKLDIENGNNB, bool BKHDMOGADPG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000473")]
	[Cpp2IlInjected.Address(RVA = "0x690EB0", Offset = "0x68F8B0", VA = "0x180690EB0", Slot = "127")]
	public void JEBPKKGFEDL(Vector3 AFHANPMAJON, Quaternion MGLHGJDPDPO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000474")]
	[Cpp2IlInjected.Address(RVA = "0x690EB0", Offset = "0x68F8B0", VA = "0x180690EB0", Slot = "128")]
	public void CIOEFCEIHBP(Vector3 JGOFLNCMNEF, Quaternion HHGDJGKIPDH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000475")]
	[Cpp2IlInjected.Address(RVA = "0x67AD00", Offset = "0x679700", VA = "0x18067AD00", Slot = "129")]
	public bool OJPJAEOKAPC(float CJJGIOGGJMO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000476")]
	[Cpp2IlInjected.Address(RVA = "0x690EB0", Offset = "0x68F8B0", VA = "0x180690EB0", Slot = "130")]
	public void FLGEALADFAB(object HKLDIENGNNB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000477")]
	[Cpp2IlInjected.Address(RVA = "0x690EB0", Offset = "0x68F8B0", VA = "0x180690EB0", Slot = "131")]
	public void GOLJJNAJJDK(object HKLDIENGNNB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000478")]
	[Cpp2IlInjected.Address(RVA = "0x690EB0", Offset = "0x68F8B0", VA = "0x180690EB0", Slot = "132")]
	public void HCDCAKONHKH(object HKLDIENGNNB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000479")]
	[Cpp2IlInjected.Address(RVA = "0x690EB0", Offset = "0x68F8B0", VA = "0x180690EB0", Slot = "133")]
	public void ANODKIPNKGG(object HKLDIENGNNB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600047A")]
	[Cpp2IlInjected.Address(RVA = "0x690EB0", Offset = "0x68F8B0", VA = "0x180690EB0", Slot = "134")]
	public void PADGBNKEIIJ(Vector3 CBEIFKNKIIE, ForceMode OEBHACLNMCB = ForceMode.Force)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600047B")]
	[Cpp2IlInjected.Address(RVA = "0x690EB0", Offset = "0x68F8B0", VA = "0x180690EB0", Slot = "135")]
	public void HKDCNICIFFL(Vector3 CBEIFKNKIIE, Vector3 EINGNKDKDHC, ForceMode OEBHACLNMCB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600047C")]
	[Cpp2IlInjected.Address(RVA = "0x690EB0", Offset = "0x68F8B0", VA = "0x180690EB0", Slot = "136")]
	public void EPMGKEGNALO(Vector3 DEMLAEGANDJ, ForceMode OEBHACLNMCB = ForceMode.Force)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600047D")]
	[Cpp2IlInjected.Address(RVA = "0x690EB0", Offset = "0x68F8B0", VA = "0x180690EB0", Slot = "137")]
	public void PINFLFOIKOH(Vector3 DEMLAEGANDJ, ForceMode OEBHACLNMCB = ForceMode.Force)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600047E")]
	[Cpp2IlInjected.Address(RVA = "0x516A310", Offset = "0x5168D10", VA = "0x18516A310", Slot = "138")]
	public bool COKAFBGHKMH(Vector3 FOGEFLLJLFJ, out RaycastHit LOOJGACDMOC, float IDHCBHDHMCK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600047F")]
	[Cpp2IlInjected.Address(RVA = "0x690EB0", Offset = "0x68F8B0", VA = "0x180690EB0", Slot = "139")]
	public void DFDCFAGILJM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000480")]
	[Cpp2IlInjected.Address(RVA = "0x678B30", Offset = "0x677530", VA = "0x180678B30")]
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
	[Cpp2IlInjected.Address(RVA = "0x515A260", Offset = "0x5158C60", VA = "0x18515A260")]
	public FAEFMAFLNLK(GameObject EHEABJNEALG, RigidbodyEx LMKJNNOGFLA, MPHIHDCLPDB HKMONJIHHIH, in IMECCMKFBII JIHCLPECHIB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000483")]
	[Cpp2IlInjected.Address(RVA = "0x5159D50", Offset = "0x5158750", VA = "0x185159D50", Slot = "142")]
	protected override void EBMDLPECLDP(MPHIHDCLPDB HKMONJIHHIH, IMECCMKFBII JIHCLPECHIB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000484")]
	[Cpp2IlInjected.Address(RVA = "0x5159BC0", Offset = "0x51585C0", VA = "0x185159BC0", Slot = "143")]
	public override void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000485")]
	[Cpp2IlInjected.Address(RVA = "0x5159A30", Offset = "0x5158430", VA = "0x185159A30", Slot = "145")]
	public void ADGNAFGAAEA(CEFLALGDCIE GLJCMMBCBOC, CEFLALGDCIE PNPBNOELPMC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000486")]
	[Cpp2IlInjected.Address(RVA = "0x5159B00", Offset = "0x5158500", VA = "0x185159B00", Slot = "146")]
	public void DNKIHCFNJJA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000487")]
	[Cpp2IlInjected.Address(RVA = "0x515A1A0", Offset = "0x5158BA0", VA = "0x18515A1A0", Slot = "147")]
	public void JKINNNDBIAE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000488")]
	[Cpp2IlInjected.Address(RVA = "0x515A140", Offset = "0x5158B40", VA = "0x18515A140", Slot = "148")]
	public void HKDHIFCLEOH(bool HBGILCDGAGC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000489")]
	[Cpp2IlInjected.Address(RVA = "0x5159FE0", Offset = "0x51589E0", VA = "0x185159FE0", Slot = "149")]
	public bool FAKDMJMODLG()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600048A")]
	[Cpp2IlInjected.Address(RVA = "0x690EB0", Offset = "0x68F8B0", VA = "0x180690EB0", Slot = "144")]
	public override void MKJLJFAPFNF()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000046")]
internal static class KGEGGDHDLCI
{
	[Cpp2IlInjected.Token(Token = "0x600048B")]
	[Cpp2IlInjected.Address(RVA = "0x51672C0", Offset = "0x5165CC0", VA = "0x1851672C0")]
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
		[Cpp2IlInjected.Address(RVA = "0x5156590", Offset = "0x5154F90", VA = "0x185156590")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000134")]
	public CollisionDetectionMode GDCFMCCNNGL
	{
		[Cpp2IlInjected.Token(Token = "0x6000498")]
		[Cpp2IlInjected.Address(RVA = "0x5170510", Offset = "0x516EF10", VA = "0x185170510", Slot = "4")]
		get
		{
			return default(CollisionDetectionMode);
		}
		[Cpp2IlInjected.Token(Token = "0x6000499")]
		[Cpp2IlInjected.Address(RVA = "0x5170830", Offset = "0x516F230", VA = "0x185170830", Slot = "5")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000495")]
	[Cpp2IlInjected.Address(RVA = "0x51680D0", Offset = "0x5166AD0", VA = "0x1851680D0")]
	public NOLNDJIHAGN(FFCGIONKJBI FHCKPPNILHO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000496")]
	[Cpp2IlInjected.Address(RVA = "0x51708A0", Offset = "0x516F2A0", VA = "0x1851708A0", Slot = "6")]
	public void NOMIHBFFLNG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000497")]
	[Cpp2IlInjected.Address(RVA = "0x51707B0", Offset = "0x516F1B0", VA = "0x1851707B0", Slot = "9")]
	public void KDPOLAHOOPE(Rigidbody MKOMGOCHBJC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600049A")]
	[Cpp2IlInjected.Address(RVA = "0x5170790", Offset = "0x516F190", VA = "0x185170790", Slot = "7")]
	public void FICELACKBCB(bool IGMFHMLOGDC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600049B")]
	[Cpp2IlInjected.Address(RVA = "0x51707A0", Offset = "0x516F1A0", VA = "0x1851707A0", Slot = "8")]
	public void GDPJJGMKJBP(bool IGMFHMLOGDC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600049C")]
	[Cpp2IlInjected.Address(RVA = "0x5170620", Offset = "0x516F020", VA = "0x185170620", Slot = "10")]
	public bool COKAFBGHKMH(Vector3 FOGEFLLJLFJ, out RaycastHit LOOJGACDMOC, float IDHCBHDHMCK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600049D")]
	[Cpp2IlInjected.Address(RVA = "0x51709C0", Offset = "0x516F3C0", VA = "0x1851709C0")]
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
		[Cpp2IlInjected.Address(RVA = "0x5157EF0", Offset = "0x51568F0", VA = "0x185157EF0", Slot = "6")]
		get
		{
			return default(CKHEJONCKGK);
		}
		[Cpp2IlInjected.Token(Token = "0x60004A1")]
		[Cpp2IlInjected.Address(RVA = "0x5158170", Offset = "0x5156B70", VA = "0x185158170", Slot = "7")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000136")]
	private Transform PDEMFIDJPNF
	{
		[Cpp2IlInjected.Token(Token = "0x60004A2")]
		[Cpp2IlInjected.Address(RVA = "0x5158240", Offset = "0x5156C40", VA = "0x185158240", Slot = "10")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000041")]
	public event Action<CEAPFNKIAFO, CEAPFNKIAFO> GAJNIIPFKOP
	{
		[Cpp2IlInjected.Token(Token = "0x600049E")]
		[Cpp2IlInjected.Address(RVA = "0x5158030", Offset = "0x5156A30", VA = "0x185158030", Slot = "4")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600049F")]
		[Cpp2IlInjected.Address(RVA = "0x51580D0", Offset = "0x5156AD0", VA = "0x1851580D0", Slot = "5")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60004A3")]
	[Cpp2IlInjected.Address(RVA = "0x5158540", Offset = "0x5156F40", VA = "0x185158540")]
	public DFCEDAGNFJI(FFCGIONKJBI FHCKPPNILHO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004A4")]
	[Cpp2IlInjected.Address(RVA = "0x5158260", Offset = "0x5156C60", VA = "0x185158260", Slot = "8")]
	public void NOMIHBFFLNG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004A5")]
	[Cpp2IlInjected.Address(RVA = "0x5157E40", Offset = "0x5156840", VA = "0x185157E40", Slot = "9")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004A6")]
	[Cpp2IlInjected.Address(RVA = "0x5157E90", Offset = "0x5156890", VA = "0x185157E90", Slot = "11")]
	private void ELOHKMMAIIJ(CEAPFNKIAFO HPKJNHPLCPI, CEAPFNKIAFO FBLLAOEFGAF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004A7")]
	[Cpp2IlInjected.Address(RVA = "0x690EB0", Offset = "0x68F8B0", VA = "0x180690EB0", Slot = "12")]
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
		[Cpp2IlInjected.Address(RVA = "0x5156590", Offset = "0x5154F90", VA = "0x185156590")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000138")]
	private bool DEHDGKEMKCA
	{
		[Cpp2IlInjected.Token(Token = "0x60004A9")]
		[Cpp2IlInjected.Address(RVA = "0x5156CC0", Offset = "0x51556C0", VA = "0x185156CC0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000139")]
	private bool CAIEJEMCAII
	{
		[Cpp2IlInjected.Token(Token = "0x60004AA")]
		[Cpp2IlInjected.Address(RVA = "0x514D700", Offset = "0x514C100", VA = "0x18514D700")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700013A")]
	private FFCGIONKJBI HDIMMFJBNPK
	{
		[Cpp2IlInjected.Token(Token = "0x60004AB")]
		[Cpp2IlInjected.Address(RVA = "0x5167610", Offset = "0x5166010", VA = "0x185167610")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60004AC")]
	[Cpp2IlInjected.Address(RVA = "0x51680D0", Offset = "0x5166AD0", VA = "0x1851680D0")]
	public LCGAJDOHAGD(FFCGIONKJBI FHCKPPNILHO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004AD")]
	[Cpp2IlInjected.Address(RVA = "0x5167CF0", Offset = "0x51666F0", VA = "0x185167CF0", Slot = "4")]
	public void PADGBNKEIIJ(Vector3 CBEIFKNKIIE, ForceMode OEBHACLNMCB = ForceMode.Force)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004AE")]
	[Cpp2IlInjected.Address(RVA = "0x5167A70", Offset = "0x5166470", VA = "0x185167A70")]
	private void OFMHFHDJNMM(Vector3 CBEIFKNKIIE, ForceMode OEBHACLNMCB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004AF")]
	[Cpp2IlInjected.Address(RVA = "0x51677D0", Offset = "0x51661D0", VA = "0x1851677D0", Slot = "5")]
	public void HKDCNICIFFL(Vector3 CBEIFKNKIIE, Vector3 EINGNKDKDHC, ForceMode OEBHACLNMCB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004B0")]
	[Cpp2IlInjected.Address(RVA = "0x5167670", Offset = "0x5166070", VA = "0x185167670", Slot = "6")]
	public void EPMGKEGNALO(Vector3 DEMLAEGANDJ, ForceMode OEBHACLNMCB = ForceMode.Force)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004B1")]
	[Cpp2IlInjected.Address(RVA = "0x5167390", Offset = "0x5165D90", VA = "0x185167390")]
	private void AOALFPILCPL(Vector3 DEMLAEGANDJ, ForceMode OEBHACLNMCB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004B2")]
	[Cpp2IlInjected.Address(RVA = "0x5167E50", Offset = "0x5166850", VA = "0x185167E50", Slot = "7")]
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
		[Cpp2IlInjected.Address(RVA = "0x6918D0", Offset = "0x6902D0", VA = "0x1806918D0", Slot = "4")]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x60004B5")]
		[Cpp2IlInjected.Address(RVA = "0x601FF10", Offset = "0x601E910", VA = "0x18601FF10", Slot = "5")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60004B3")]
	[Cpp2IlInjected.Address(RVA = "0x6020030", Offset = "0x601EA30", VA = "0x186020030")]
	public ONONMKHEBAI(FFCGIONKJBI FHCKPPNILHO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004B6")]
	[Cpp2IlInjected.Address(RVA = "0x6020000", Offset = "0x601EA00", VA = "0x186020000", Slot = "6")]
	public void KDPOLAHOOPE(Rigidbody MKOMGOCHBJC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004B7")]
	[Cpp2IlInjected.Address(RVA = "0x601FFC0", Offset = "0x601E9C0", VA = "0x18601FFC0", Slot = "7")]
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
		[Cpp2IlInjected.Address(RVA = "0x515E1C0", Offset = "0x515CBC0", VA = "0x18515E1C0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700013D")]
	public FFCGIONKJBI HDIMMFJBNPK
	{
		[Cpp2IlInjected.Token(Token = "0x60004CD")]
		[Cpp2IlInjected.Address(RVA = "0x68D700", Offset = "0x68C100", VA = "0x18068D700", Slot = "28")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60004CE")]
		[Cpp2IlInjected.Address(RVA = "0x515E110", Offset = "0x515CB10", VA = "0x18515E110", Slot = "29")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700013E")]
	public FFCGIONKJBI AMKPOIHFDKH
	{
		[Cpp2IlInjected.Token(Token = "0x60004CF")]
		[Cpp2IlInjected.Address(RVA = "0x68D780", Offset = "0x68C180", VA = "0x18068D780", Slot = "27")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700013F")]
	public IReadOnlyList<FFCGIONKJBI> KEPEEEPLAGJ
	{
		[Cpp2IlInjected.Token(Token = "0x60004D0")]
		[Cpp2IlInjected.Address(RVA = "0x68D770", Offset = "0x68C170", VA = "0x18068D770", Slot = "26")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000042")]
	public event HOBHPHAMKBD IAOFFICNEFM
	{
		[Cpp2IlInjected.Token(Token = "0x60004B8")]
		[Cpp2IlInjected.Address(RVA = "0x515D720", Offset = "0x515C120", VA = "0x18515D720", Slot = "8")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60004B9")]
		[Cpp2IlInjected.Address(RVA = "0x515D600", Offset = "0x515C000", VA = "0x18515D600", Slot = "9")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000043")]
	public event HOBHPHAMKBD BPJGPOJJOIC
	{
		[Cpp2IlInjected.Token(Token = "0x60004BA")]
		[Cpp2IlInjected.Address(RVA = "0x515D260", Offset = "0x515BC60", VA = "0x18515D260", Slot = "10")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60004BB")]
		[Cpp2IlInjected.Address(RVA = "0x515E220", Offset = "0x515CC20", VA = "0x18515E220", Slot = "11")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000044")]
	public event ABBLHFOFAPM IANJCDBCFAJ
	{
		[Cpp2IlInjected.Token(Token = "0x60004BC")]
		[Cpp2IlInjected.Address(RVA = "0x515EAB0", Offset = "0x515D4B0", VA = "0x18515EAB0", Slot = "12")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60004BD")]
		[Cpp2IlInjected.Address(RVA = "0x515DA10", Offset = "0x515C410", VA = "0x18515DA10", Slot = "13")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000045")]
	public event Action HGFICMNEKPD
	{
		[Cpp2IlInjected.Token(Token = "0x60004BE")]
		[Cpp2IlInjected.Address(RVA = "0x515DAB0", Offset = "0x515C4B0", VA = "0x18515DAB0", Slot = "14")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60004BF")]
		[Cpp2IlInjected.Address(RVA = "0x515DC90", Offset = "0x515C690", VA = "0x18515DC90", Slot = "15")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000046")]
	public event Action AOLPOEKDAPB
	{
		[Cpp2IlInjected.Token(Token = "0x60004C0")]
		[Cpp2IlInjected.Address(RVA = "0x515DB50", Offset = "0x515C550", VA = "0x18515DB50", Slot = "16")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60004C1")]
		[Cpp2IlInjected.Address(RVA = "0x515E120", Offset = "0x515CB20", VA = "0x18515E120", Slot = "17")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000047")]
	public event Action<FFCGIONKJBI> MIDFDOJCFED
	{
		[Cpp2IlInjected.Token(Token = "0x60004C2")]
		[Cpp2IlInjected.Address(RVA = "0x515D560", Offset = "0x515BF60", VA = "0x18515D560", Slot = "18")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60004C3")]
		[Cpp2IlInjected.Address(RVA = "0x515CFD0", Offset = "0x515B9D0", VA = "0x18515CFD0", Slot = "19")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000048")]
	public event Action<FFCGIONKJBI> ENHLMFMKKOI
	{
		[Cpp2IlInjected.Token(Token = "0x60004C4")]
		[Cpp2IlInjected.Address(RVA = "0x515EB90", Offset = "0x515D590", VA = "0x18515EB90", Slot = "20")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60004C5")]
		[Cpp2IlInjected.Address(RVA = "0x515DBF0", Offset = "0x515C5F0", VA = "0x18515DBF0", Slot = "21")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000049")]
	public event Action CBAHCMEOEBH
	{
		[Cpp2IlInjected.Token(Token = "0x60004C6")]
		[Cpp2IlInjected.Address(RVA = "0x515EA10", Offset = "0x515D410", VA = "0x18515EA10", Slot = "22")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60004C7")]
		[Cpp2IlInjected.Address(RVA = "0x515DFD0", Offset = "0x515C9D0", VA = "0x18515DFD0", Slot = "23")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400004A")]
	public event Action<FFCGIONKJBI> PNGLKBMDHIJ
	{
		[Cpp2IlInjected.Token(Token = "0x60004C8")]
		[Cpp2IlInjected.Address(RVA = "0x515E070", Offset = "0x515CA70", VA = "0x18515E070", Slot = "24")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60004C9")]
		[Cpp2IlInjected.Address(RVA = "0x515D070", Offset = "0x515BA70", VA = "0x18515D070", Slot = "25")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60004CB")]
	[Cpp2IlInjected.Address(RVA = "0x515EC30", Offset = "0x515D630", VA = "0x18515EC30")]
	public IBJDNMPHFOA(FFCGIONKJBI FHCKPPNILHO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004CC")]
	[Cpp2IlInjected.Address(RVA = "0x515D6A0", Offset = "0x515C0A0", VA = "0x18515D6A0", Slot = "31")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004D1")]
	[Cpp2IlInjected.Address(RVA = "0x515E2C0", Offset = "0x515CCC0", VA = "0x18515E2C0", Slot = "30")]
	public void OGODNIIEFFB(FFCGIONKJBI EBIGGMLCEAF, bool JAHLDBIKCJI = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004D2")]
	[Cpp2IlInjected.Address(RVA = "0x515D7C0", Offset = "0x515C1C0", VA = "0x18515D7C0", Slot = "6")]
	public void FKPIKBICOFJ(FFCGIONKJBI EBNAKIGKECH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004D3")]
	[Cpp2IlInjected.Address(RVA = "0x515D300", Offset = "0x515BD00", VA = "0x18515D300", Slot = "7")]
	public void DCJINOKJEFG(FFCGIONKJBI EBNAKIGKECH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004D4")]
	[Cpp2IlInjected.Address(RVA = "0x515E970", Offset = "0x515D370", VA = "0x18515E970", Slot = "4")]
	public void OPJJCFHECII(FFCGIONKJBI FHCKPPNILHO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004D5")]
	[Cpp2IlInjected.Address(RVA = "0x515CF30", Offset = "0x515B930", VA = "0x18515CF30", Slot = "5")]
	public void APJHAKKKPLO(FFCGIONKJBI FHCKPPNILHO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004D6")]
	[Cpp2IlInjected.Address(RVA = "0x515DF40", Offset = "0x515C940", VA = "0x18515DF40")]
	private void IIHIMCEPCEK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004D7")]
	[Cpp2IlInjected.Address(RVA = "0x515EB50", Offset = "0x515D550", VA = "0x18515EB50")]
	private void PKKLCJELFEI(FFCGIONKJBI EBNAKIGKECH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004D8")]
	[Cpp2IlInjected.Address(RVA = "0x515D110", Offset = "0x515BB10", VA = "0x18515D110")]
	private void CLODPCAPFJO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004D9")]
	[Cpp2IlInjected.Address(RVA = "0x515E840", Offset = "0x515D240", VA = "0x18515E840")]
	private void ONAEFPLNEDD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004DA")]
	[Cpp2IlInjected.Address(RVA = "0x515DD30", Offset = "0x515C730", VA = "0x18515DD30")]
	private void IBNBBPLEKPA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004DB")]
	[Cpp2IlInjected.Address(RVA = "0x515DE50", Offset = "0x515C850", VA = "0x18515DE50")]
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
	[Cpp2IlInjected.Address(RVA = "0x516A390", Offset = "0x5168D90", VA = "0x18516A390")]
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
		[Cpp2IlInjected.Address(RVA = "0x6770C0", Offset = "0x675AC0", VA = "0x1806770C0", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000141")]
	public Vector3 GNKPAMJBNBD
	{
		[Cpp2IlInjected.Token(Token = "0x60004DE")]
		[Cpp2IlInjected.Address(RVA = "0x5155070", Offset = "0x5153A70", VA = "0x185155070", Slot = "6")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000142")]
	public Vector3 DECHPPBODKH
	{
		[Cpp2IlInjected.Token(Token = "0x60004DF")]
		[Cpp2IlInjected.Address(RVA = "0x5154EA0", Offset = "0x51538A0", VA = "0x185154EA0", Slot = "7")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000143")]
	private Vector3 OMPLHOFEJAN
	{
		[Cpp2IlInjected.Token(Token = "0x60004E3")]
		[Cpp2IlInjected.Address(RVA = "0x51550A0", Offset = "0x5153AA0", VA = "0x1851550A0")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000144")]
	public FFCGIONKJBI POKCCLODFLP
	{
		[Cpp2IlInjected.Token(Token = "0x60004E4")]
		[Cpp2IlInjected.Address(RVA = "0x5154DF0", Offset = "0x51537F0", VA = "0x185154DF0", Slot = "5")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60004E0")]
	[Cpp2IlInjected.Address(RVA = "0x5155940", Offset = "0x5154340", VA = "0x185155940")]
	public COJFJMHBNAL(FFCGIONKJBI FHCKPPNILHO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004E1")]
	[Cpp2IlInjected.Address(RVA = "0x51558D0", Offset = "0x51542D0", VA = "0x1851558D0", Slot = "8")]
	public void KJONOMFBLIP(FFCGIONKJBI LFAIGCEGCPL, object HKLDIENGNNB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004E2")]
	[Cpp2IlInjected.Address(RVA = "0x5155520", Offset = "0x5153F20", VA = "0x185155520", Slot = "9")]
	public void GBBOCMNIAIE(object HKLDIENGNNB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004E5")]
	[Cpp2IlInjected.Address(RVA = "0x5155580", Offset = "0x5153F80", VA = "0x185155580")]
	private Vector3 JCHOIMFBPCP()
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x60004E6")]
	[Cpp2IlInjected.Address(RVA = "0x5155180", Offset = "0x5153B80", VA = "0x185155180")]
	private void FGEMKEKLHDE(FFCGIONKJBI KIFBLAKDELP)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000052")]
internal static class GEKLNFGAAGE
{
	[Cpp2IlInjected.Token(Token = "0x60004E7")]
	[Cpp2IlInjected.Address(RVA = "0x515B150", Offset = "0x5159B50", VA = "0x18515B150")]
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
		[Cpp2IlInjected.Address(RVA = "0x11DC2F0", Offset = "0x11DACF0", VA = "0x1811DC2F0", Slot = "7")]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x60004EB")]
		[Cpp2IlInjected.Address(RVA = "0x5152480", Offset = "0x5150E80", VA = "0x185152480", Slot = "8")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000146")]
	public Vector3 DJLPMKOMOHI
	{
		[Cpp2IlInjected.Token(Token = "0x60004EC")]
		[Cpp2IlInjected.Address(RVA = "0x5151730", Offset = "0x5150130", VA = "0x185151730", Slot = "9")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000147")]
	public float MGOEPMCMEHB
	{
		[Cpp2IlInjected.Token(Token = "0x60004ED")]
		[Cpp2IlInjected.Address(RVA = "0x15C7610", Offset = "0x15C6010", VA = "0x1815C7610", Slot = "10")]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x60004EE")]
		[Cpp2IlInjected.Address(RVA = "0x5152940", Offset = "0x5151340", VA = "0x185152940")]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000148")]
	public float OEDNFOGCCII
	{
		[Cpp2IlInjected.Token(Token = "0x60004EF")]
		[Cpp2IlInjected.Address(RVA = "0x107D080", Offset = "0x107BA80", VA = "0x18107D080", Slot = "11")]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x60004F0")]
		[Cpp2IlInjected.Address(RVA = "0x51524A0", Offset = "0x5150EA0", VA = "0x1851524A0", Slot = "12")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000149")]
	public Vector3 KGPDAOIKKOA
	{
		[Cpp2IlInjected.Token(Token = "0x60004F1")]
		[Cpp2IlInjected.Address(RVA = "0x51513D0", Offset = "0x514FDD0", VA = "0x1851513D0", Slot = "13")]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x60004F2")]
		[Cpp2IlInjected.Address(RVA = "0x5151540", Offset = "0x514FF40", VA = "0x185151540", Slot = "14")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700014A")]
	public Quaternion GADCINNEPIK
	{
		[Cpp2IlInjected.Token(Token = "0x60004F3")]
		[Cpp2IlInjected.Address(RVA = "0x51527D0", Offset = "0x51511D0", VA = "0x1851527D0", Slot = "15")]
		get
		{
			return default(Quaternion);
		}
		[Cpp2IlInjected.Token(Token = "0x60004F4")]
		[Cpp2IlInjected.Address(RVA = "0x51524C0", Offset = "0x5150EC0", VA = "0x1851524C0", Slot = "16")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700014B")]
	private Rigidbody BKIDAKAFFMP
	{
		[Cpp2IlInjected.Token(Token = "0x60004FC")]
		[Cpp2IlInjected.Address(RVA = "0x51516E0", Offset = "0x51500E0", VA = "0x1851516E0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400004B")]
	public event HOBHPHAMKBD HHGAGCIOJJG
	{
		[Cpp2IlInjected.Token(Token = "0x60004E8")]
		[Cpp2IlInjected.Address(RVA = "0x5153B80", Offset = "0x5152580", VA = "0x185153B80", Slot = "5")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60004E9")]
		[Cpp2IlInjected.Address(RVA = "0x5153A00", Offset = "0x5152400", VA = "0x185153A00", Slot = "6")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60004F5")]
	[Cpp2IlInjected.Address(RVA = "0x5153DA0", Offset = "0x51527A0", VA = "0x185153DA0")]
	public CJCNFKFOMPE(FFCGIONKJBI FHCKPPNILHO, in IMECCMKFBII JIHCLPECHIB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004F6")]
	[Cpp2IlInjected.Address(RVA = "0x5151B60", Offset = "0x5150560", VA = "0x185151B60", Slot = "18")]
	public void CAALKOKEPPD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004F7")]
	[Cpp2IlInjected.Address(RVA = "0x5151830", Offset = "0x5150230", VA = "0x185151830", Slot = "17")]
	public void BANKNELMPFP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004F8")]
	[Cpp2IlInjected.Address(RVA = "0x5153AA0", Offset = "0x51524A0", VA = "0x185153AA0", Slot = "20")]
	public void KDPOLAHOOPE(Rigidbody MKOMGOCHBJC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004F9")]
	[Cpp2IlInjected.Address(RVA = "0x51521E0", Offset = "0x5150BE0", VA = "0x1851521E0", Slot = "21")]
	public void DIDIIBMEDJD(Rigidbody MKOMGOCHBJC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004FA")]
	[Cpp2IlInjected.Address(RVA = "0x5152660", Offset = "0x5151060", VA = "0x185152660", Slot = "19")]
	public void GAANFDFDMKC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004FB")]
	[Cpp2IlInjected.Address(RVA = "0x5151D20", Offset = "0x5150720", VA = "0x185151D20", Slot = "22")]
	public void DFDCFAGILJM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004FD")]
	[Cpp2IlInjected.Address(RVA = "0x5152480", Offset = "0x5150E80", VA = "0x185152480")]
	private void EDLHINCKBGC(Vector3 MAKFNMHIJIF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004FE")]
	[Cpp2IlInjected.Address(RVA = "0x5151A70", Offset = "0x5150470", VA = "0x185151A70")]
	private Vector3 BKOHCPKDCEP()
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x60004FF")]
	[Cpp2IlInjected.Address(RVA = "0x5152940", Offset = "0x5151340", VA = "0x185152940")]
	private void NFOOMMJHALN(float MAKFNMHIJIF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000500")]
	[Cpp2IlInjected.Address(RVA = "0x51524A0", Offset = "0x5150EA0", VA = "0x1851524A0")]
	private void NGBNHFHHKHB(float MAKFNMHIJIF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000501")]
	[Cpp2IlInjected.Address(RVA = "0x5153C20", Offset = "0x5152620", VA = "0x185153C20")]
	private Vector3 MHIHKHCHKBK()
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000502")]
	[Cpp2IlInjected.Address(RVA = "0x5151540", Offset = "0x514FF40", VA = "0x185151540")]
	private void MEKMDDFDCDF(Vector3 MAKFNMHIJIF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000503")]
	[Cpp2IlInjected.Address(RVA = "0x5151910", Offset = "0x5150310", VA = "0x185151910")]
	private Quaternion BJFOMIEDANP()
	{
		return default(Quaternion);
	}

	[Cpp2IlInjected.Token(Token = "0x6000504")]
	[Cpp2IlInjected.Address(RVA = "0x51524C0", Offset = "0x5150EC0", VA = "0x1851524C0")]
	private void NBKELJCOCGM(Quaternion MAKFNMHIJIF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000505")]
	[Cpp2IlInjected.Address(RVA = "0x5153920", Offset = "0x5152320", VA = "0x185153920")]
	public void JIKMNOJPHEP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000506")]
	[Cpp2IlInjected.Address(RVA = "0x5152A60", Offset = "0x5151460", VA = "0x185152A60", Slot = "4")]
	public (float, Vector3) JIKMNOJPHEP(Rigidbody KBIMEMIPFEL)
	{
		return default((float, Vector3));
	}
}
[Cpp2IlInjected.Token(Token = "0x2000054")]
internal static class HBFIMKIJMLB
{
	[Cpp2IlInjected.Token(Token = "0x6000507")]
	[Cpp2IlInjected.Address(RVA = "0x515C220", Offset = "0x515AC20", VA = "0x18515C220")]
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
		[Cpp2IlInjected.Address(RVA = "0x1616D10", Offset = "0x1615710", VA = "0x181616D10", Slot = "4")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700014D")]
	public MGONBPIMIEF AIAKBOMPCEL
	{
		[Cpp2IlInjected.Token(Token = "0x6000509")]
		[Cpp2IlInjected.Address(RVA = "0x677010", Offset = "0x675A10", VA = "0x180677010", Slot = "5")]
		get
		{
			return default(MGONBPIMIEF);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600050A")]
	[Cpp2IlInjected.Address(RVA = "0x51505A0", Offset = "0x514EFA0", VA = "0x1851505A0")]
	public BHDNIMBMBIN(FFCGIONKJBI FHCKPPNILHO, in IMECCMKFBII JIHCLPECHIB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600050B")]
	[Cpp2IlInjected.Address(RVA = "0x51503A0", Offset = "0x514EDA0", VA = "0x1851503A0", Slot = "6")]
	public void NOMIHBFFLNG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600050C")]
	[Cpp2IlInjected.Address(RVA = "0x5150300", Offset = "0x514ED00", VA = "0x185150300")]
	private bool MLCFJHLPAFK()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600050D")]
	[Cpp2IlInjected.Address(RVA = "0x5150150", Offset = "0x514EB50", VA = "0x185150150", Slot = "7")]
	public void FCLIOEABILH(object HKLDIENGNNB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600050E")]
	[Cpp2IlInjected.Address(RVA = "0x51501C0", Offset = "0x514EBC0", VA = "0x1851501C0", Slot = "8")]
	public void HFELMDDPCOH(object HKLDIENGNNB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600050F")]
	[Cpp2IlInjected.Address(RVA = "0x5150470", Offset = "0x514EE70", VA = "0x185150470", Slot = "11")]
	public void OLOGEBHENON()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000510")]
	[Cpp2IlInjected.Address(RVA = "0x51501F0", Offset = "0x514EBF0", VA = "0x1851501F0")]
	private void MDLEKMKMEOD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000511")]
	[Cpp2IlInjected.Address(RVA = "0x514FF90", Offset = "0x514E990", VA = "0x18514FF90")]
	private void BLBJEECBPFI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000512")]
	[Cpp2IlInjected.Address(RVA = "0x5150110", Offset = "0x514EB10", VA = "0x185150110", Slot = "10")]
	public void DAHMBDFDEKP(FFCGIONKJBI FHCKPPNILHO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000513")]
	[Cpp2IlInjected.Address(RVA = "0x5150180", Offset = "0x514EB80", VA = "0x185150180", Slot = "9")]
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
		[Cpp2IlInjected.Address(RVA = "0x6020940", Offset = "0x601F340", VA = "0x186020940", Slot = "6")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700014F")]
	public IEnumerable<object> JCMEBGAMNHL
	{
		[Cpp2IlInjected.Token(Token = "0x6000517")]
		[Cpp2IlInjected.Address(RVA = "0x60204F0", Offset = "0x601EEF0", VA = "0x1860204F0", Slot = "7")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400004C")]
	public event HOBHPHAMKBD EOJIPPCPFCI
	{
		[Cpp2IlInjected.Token(Token = "0x6000514")]
		[Cpp2IlInjected.Address(RVA = "0x6020510", Offset = "0x601EF10", VA = "0x186020510", Slot = "4")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000515")]
		[Cpp2IlInjected.Address(RVA = "0x6020820", Offset = "0x601F220", VA = "0x186020820", Slot = "5")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000518")]
	[Cpp2IlInjected.Address(RVA = "0x60209D0", Offset = "0x601F3D0", VA = "0x1860209D0")]
	public PFDBAPLBKJG(FFCGIONKJBI FHCKPPNILHO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000519")]
	[Cpp2IlInjected.Address(RVA = "0x60207C0", Offset = "0x601F1C0", VA = "0x1860207C0", Slot = "11")]
	public IDisposable IFKNDGBNBEF()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600051A")]
	[Cpp2IlInjected.Address(RVA = "0x60206E0", Offset = "0x601F0E0", VA = "0x1860206E0", Slot = "8")]
	public void FKOFNEMGINM(object HKLDIENGNNB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600051B")]
	[Cpp2IlInjected.Address(RVA = "0x60204E0", Offset = "0x601EEE0", VA = "0x1860204E0", Slot = "9")]
	public void BEHGOGKEFEN(object HKLDIENGNNB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600051C")]
	[Cpp2IlInjected.Address(RVA = "0x60205E0", Offset = "0x601EFE0", VA = "0x1860205E0", Slot = "10")]
	public void DLBAIGNALBD(object HKLDIENGNNB, bool BKHDMOGADPG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600051D")]
	[Cpp2IlInjected.Address(RVA = "0x60208C0", Offset = "0x601F2C0", VA = "0x1860208C0", Slot = "12")]
	public void KDPOLAHOOPE(Rigidbody CCLEKJNADLB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600051E")]
	[Cpp2IlInjected.Address(RVA = "0x60205B0", Offset = "0x601EFB0", VA = "0x1860205B0", Slot = "13")]
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
		[Cpp2IlInjected.Address(RVA = "0x678120", Offset = "0x676B20", VA = "0x180678120", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000151")]
	public bool BKKAMGPIPMG
	{
		[Cpp2IlInjected.Token(Token = "0x6000522")]
		[Cpp2IlInjected.Address(RVA = "0x5154310", Offset = "0x5152D10", VA = "0x185154310", Slot = "7")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000152")]
	public bool OFHGFFKKEMJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000523")]
		[Cpp2IlInjected.Address(RVA = "0x767F80", Offset = "0x766980", VA = "0x180767F80", Slot = "8")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400004D")]
	public event HOBHPHAMKBD IBIGIAONNFK
	{
		[Cpp2IlInjected.Token(Token = "0x600051F")]
		[Cpp2IlInjected.Address(RVA = "0x51692C0", Offset = "0x5167CC0", VA = "0x1851692C0", Slot = "5")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000520")]
		[Cpp2IlInjected.Address(RVA = "0x5169220", Offset = "0x5167C20", VA = "0x185169220", Slot = "6")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000524")]
	[Cpp2IlInjected.Address(RVA = "0x5169BB0", Offset = "0x51685B0", VA = "0x185169BB0")]
	public LFPJLJOFGND(FFCGIONKJBI FHCKPPNILHO, in IMECCMKFBII JIHCLPECHIB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000525")]
	[Cpp2IlInjected.Address(RVA = "0x51698F0", Offset = "0x51682F0", VA = "0x1851698F0", Slot = "9")]
	public void NOMIHBFFLNG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000526")]
	[Cpp2IlInjected.Address(RVA = "0x5169110", Offset = "0x5167B10", VA = "0x185169110", Slot = "12")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000527")]
	[Cpp2IlInjected.Address(RVA = "0x51695E0", Offset = "0x5167FE0", VA = "0x1851695E0", Slot = "10")]
	public void MELFMEBHFAF(FFCGIONKJBI LFAIGCEGCPL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000528")]
	[Cpp2IlInjected.Address(RVA = "0x5168F80", Offset = "0x5167980", VA = "0x185168F80", Slot = "11")]
	public void BLHLKMFLDGD(FFCGIONKJBI LFAIGCEGCPL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000529")]
	[Cpp2IlInjected.Address(RVA = "0x5169770", Offset = "0x5168170", VA = "0x185169770")]
	private void NGOCABNBNDE(PhotonView MJGOFLGOOBD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600052A")]
	[Cpp2IlInjected.Address(RVA = "0x5169A40", Offset = "0x5168440", VA = "0x185169A40")]
	private void OHFDKKBKPFB(RigidbodyEx NAKLMJNOFNJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600052B")]
	[Cpp2IlInjected.Address(RVA = "0x5169360", Offset = "0x5167D60", VA = "0x185169360")]
	private void JOPMEJPILKG(PhotonView PAFPMHNEHHP)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000058")]
internal static class NCIICMKGFLG
{
	[Cpp2IlInjected.Token(Token = "0x600052C")]
	[Cpp2IlInjected.Address(RVA = "0x516A450", Offset = "0x5168E50", VA = "0x18516A450")]
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
		[Cpp2IlInjected.Address(RVA = "0xAAFAE0", Offset = "0xAAE4E0", VA = "0x180AAFAE0", Slot = "4")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x600052E")]
		[Cpp2IlInjected.Address(RVA = "0x22C5360", Offset = "0x22C3D60", VA = "0x1822C5360", Slot = "5")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000154")]
	public bool FDKFFCJABEN
	{
		[Cpp2IlInjected.Token(Token = "0x600052F")]
		[Cpp2IlInjected.Address(RVA = "0x22C5370", Offset = "0x22C3D70", VA = "0x1822C5370", Slot = "6")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000530")]
		[Cpp2IlInjected.Address(RVA = "0x22C53A0", Offset = "0x22C3DA0", VA = "0x1822C53A0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000155")]
	public RigidbodyConstraints AKGJCKADCBH
	{
		[Cpp2IlInjected.Token(Token = "0x6000531")]
		[Cpp2IlInjected.Address(RVA = "0x678BD0", Offset = "0x6775D0", VA = "0x180678BD0", Slot = "7")]
		get
		{
			return default(RigidbodyConstraints);
		}
		[Cpp2IlInjected.Token(Token = "0x6000532")]
		[Cpp2IlInjected.Address(RVA = "0x5157400", Offset = "0x5155E00", VA = "0x185157400", Slot = "8")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000533")]
	[Cpp2IlInjected.Address(RVA = "0x51575A0", Offset = "0x5155FA0", VA = "0x1851575A0")]
	public DDNJOPKCDIK(FFCGIONKJBI FHCKPPNILHO, in IMECCMKFBII JIHCLPECHIB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000534")]
	[Cpp2IlInjected.Address(RVA = "0x5157570", Offset = "0x5155F70", VA = "0x185157570", Slot = "9")]
	public void KDPOLAHOOPE(Rigidbody MKOMGOCHBJC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000535")]
	[Cpp2IlInjected.Address(RVA = "0x5157540", Offset = "0x5155F40", VA = "0x185157540", Slot = "10")]
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
		[Cpp2IlInjected.Address(RVA = "0x10A3330", Offset = "0x10A1D30", VA = "0x1810A3330", Slot = "4")]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x6000538")]
		[Cpp2IlInjected.Address(RVA = "0x51585D0", Offset = "0x5156FD0", VA = "0x1851585D0", Slot = "5")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000157")]
	public float FEGLLEJAJOH
	{
		[Cpp2IlInjected.Token(Token = "0x6000539")]
		[Cpp2IlInjected.Address(RVA = "0x1022E60", Offset = "0x1021860", VA = "0x181022E60", Slot = "6")]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x600053A")]
		[Cpp2IlInjected.Address(RVA = "0x5158740", Offset = "0x5157140", VA = "0x185158740", Slot = "7")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000536")]
	[Cpp2IlInjected.Address(RVA = "0x5158860", Offset = "0x5157260", VA = "0x185158860")]
	public EDBLKIEJLBE(FFCGIONKJBI FHCKPPNILHO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600053B")]
	[Cpp2IlInjected.Address(RVA = "0x5158810", Offset = "0x5157210", VA = "0x185158810", Slot = "8")]
	public void KDPOLAHOOPE(Rigidbody MKOMGOCHBJC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600053C")]
	[Cpp2IlInjected.Address(RVA = "0x51586A0", Offset = "0x51570A0", VA = "0x1851586A0", Slot = "9")]
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
		[Cpp2IlInjected.Address(RVA = "0x51516E0", Offset = "0x51500E0", VA = "0x1851516E0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000159")]
	private bool IALJHIOHBON
	{
		[Cpp2IlInjected.Token(Token = "0x6000540")]
		[Cpp2IlInjected.Address(RVA = "0x515A920", Offset = "0x5159320", VA = "0x18515A920")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700015A")]
	private bool CEDDMPPAJDO
	{
		[Cpp2IlInjected.Token(Token = "0x6000541")]
		[Cpp2IlInjected.Address(RVA = "0x515A770", Offset = "0x5159170", VA = "0x18515A770")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700015B")]
	private FFCGIONKJBI HDIMMFJBNPK
	{
		[Cpp2IlInjected.Token(Token = "0x6000542")]
		[Cpp2IlInjected.Address(RVA = "0x515A560", Offset = "0x5158F60", VA = "0x18515A560")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700015C")]
	private bool CAIEJEMCAII
	{
		[Cpp2IlInjected.Token(Token = "0x6000543")]
		[Cpp2IlInjected.Address(RVA = "0x515B060", Offset = "0x5159A60", VA = "0x18515B060")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400004E")]
	public event HOBHPHAMKBD IHIJNHOELAG
	{
		[Cpp2IlInjected.Token(Token = "0x600053D")]
		[Cpp2IlInjected.Address(RVA = "0x515A420", Offset = "0x5158E20", VA = "0x18515A420", Slot = "4")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600053E")]
		[Cpp2IlInjected.Address(RVA = "0x515AFC0", Offset = "0x51599C0", VA = "0x18515AFC0", Slot = "5")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000544")]
	[Cpp2IlInjected.Address(RVA = "0x515B0C0", Offset = "0x5159AC0", VA = "0x18515B0C0")]
	public FMDIKMBJBMA(FFCGIONKJBI FHCKPPNILHO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000545")]
	[Cpp2IlInjected.Address(RVA = "0x515AF30", Offset = "0x5159930", VA = "0x18515AF30", Slot = "6")]
	public void NOMIHBFFLNG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000546")]
	[Cpp2IlInjected.Address(RVA = "0x515AD30", Offset = "0x5159730", VA = "0x18515AD30", Slot = "8")]
	public void JPLMLMHPLJA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000547")]
	[Cpp2IlInjected.Address(RVA = "0x515ADE0", Offset = "0x51597E0", VA = "0x18515ADE0", Slot = "7")]
	public bool MNIMMDJAIIP()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000548")]
	[Cpp2IlInjected.Address(RVA = "0x515A4C0", Offset = "0x5158EC0", VA = "0x18515A4C0", Slot = "9")]
	public void ALKMJGDDHDA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000549")]
	[Cpp2IlInjected.Address(RVA = "0x515AD40", Offset = "0x5159740", VA = "0x18515AD40", Slot = "11")]
	public void LEMLLHIPKGE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600054A")]
	[Cpp2IlInjected.Address(RVA = "0x515A9C0", Offset = "0x51593C0", VA = "0x18515A9C0", Slot = "12")]
	public void HKDHIFCLEOH(bool HBGILCDGAGC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600054B")]
	[Cpp2IlInjected.Address(RVA = "0x515AA00", Offset = "0x5159400", VA = "0x18515AA00", Slot = "10")]
	public void HOBDPIODPAL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600054C")]
	[Cpp2IlInjected.Address(RVA = "0x515A5C0", Offset = "0x5158FC0", VA = "0x18515A5C0")]
	private bool FCFJIFCJPMN()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600054D")]
	[Cpp2IlInjected.Address(RVA = "0x515A790", Offset = "0x5159190", VA = "0x18515A790")]
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
		[Cpp2IlInjected.Address(RVA = "0x678120", Offset = "0x676B20", VA = "0x180678120", Slot = "4")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600054F")]
		[Cpp2IlInjected.Address(RVA = "0x678130", Offset = "0x676B30", VA = "0x180678130")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700015E")]
	private bool CAIEJEMCAII
	{
		[Cpp2IlInjected.Token(Token = "0x6000550")]
		[Cpp2IlInjected.Address(RVA = "0x514D700", Offset = "0x514C100", VA = "0x18514D700")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000551")]
	[Cpp2IlInjected.Address(RVA = "0x515FCD0", Offset = "0x515E6D0", VA = "0x18515FCD0")]
	public IBJENOEEHPD(FFCGIONKJBI FHCKPPNILHO, in IMECCMKFBII JIHCLPECHIB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000552")]
	[Cpp2IlInjected.Address(RVA = "0x515FC20", Offset = "0x515E620", VA = "0x18515FC20", Slot = "5")]
	public void NOMIHBFFLNG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000553")]
	[Cpp2IlInjected.Address(RVA = "0x515F6C0", Offset = "0x515E0C0", VA = "0x18515F6C0", Slot = "6")]
	public void HCDCAKONHKH(object HKLDIENGNNB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000554")]
	[Cpp2IlInjected.Address(RVA = "0x515ECE0", Offset = "0x515D6E0", VA = "0x18515ECE0", Slot = "7")]
	public void ANODKIPNKGG(object HKLDIENGNNB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000555")]
	[Cpp2IlInjected.Address(RVA = "0x515ED10", Offset = "0x515D710", VA = "0x18515ED10", Slot = "8")]
	public void CHKIFMMFIIK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000556")]
	[Cpp2IlInjected.Address(RVA = "0x515F6F0", Offset = "0x515E0F0", VA = "0x18515F6F0", Slot = "9")]
	public void JEGLELMGMOF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000557")]
	[Cpp2IlInjected.Address(RVA = "0x515FAA0", Offset = "0x515E4A0", VA = "0x18515FAA0", Slot = "10")]
	public void NFMKBGIADML()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000558")]
	[Cpp2IlInjected.Address(RVA = "0x515F220", Offset = "0x515DC20", VA = "0x18515F220", Slot = "11")]
	public void DHPOOPPINJB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000559")]
	[Cpp2IlInjected.Address(RVA = "0x515F070", Offset = "0x515DA70", VA = "0x18515F070")]
	private void CPKMCFBJNFD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600055A")]
	[Cpp2IlInjected.Address(RVA = "0x515F8F0", Offset = "0x515E2F0", VA = "0x18515F8F0")]
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
		[Cpp2IlInjected.Address(RVA = "0x6918E0", Offset = "0x6902E0", VA = "0x1806918E0", Slot = "4")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600055C")]
		[Cpp2IlInjected.Address(RVA = "0x6B91C0", Offset = "0x6B7BC0", VA = "0x1806B91C0", Slot = "5")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000160")]
	public JGKAIJBBCDC KPBINMPEPCH
	{
		[Cpp2IlInjected.Token(Token = "0x600055D")]
		[Cpp2IlInjected.Address(RVA = "0x68D6F0", Offset = "0x68C0F0", VA = "0x18068D6F0", Slot = "6")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600055E")]
		[Cpp2IlInjected.Address(RVA = "0x70FAE0", Offset = "0x70E4E0", VA = "0x18070FAE0", Slot = "7")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000161")]
	public Vector3 OMPLHOFEJAN
	{
		[Cpp2IlInjected.Token(Token = "0x600055F")]
		[Cpp2IlInjected.Address(RVA = "0x5164520", Offset = "0x5162F20", VA = "0x185164520", Slot = "8")]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x6000560")]
		[Cpp2IlInjected.Address(RVA = "0x5164C90", Offset = "0x5163690", VA = "0x185164C90", Slot = "9")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000162")]
	public Vector3 BOJDMEIPMAO
	{
		[Cpp2IlInjected.Token(Token = "0x6000561")]
		[Cpp2IlInjected.Address(RVA = "0x51655E0", Offset = "0x5163FE0", VA = "0x1851655E0", Slot = "10")]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x6000562")]
		[Cpp2IlInjected.Address(RVA = "0x5164910", Offset = "0x5163310", VA = "0x185164910", Slot = "11")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000163")]
	public Vector3 IPICDHHHJOG
	{
		[Cpp2IlInjected.Token(Token = "0x6000563")]
		[Cpp2IlInjected.Address(RVA = "0x5164270", Offset = "0x5162C70", VA = "0x185164270", Slot = "12")]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x6000564")]
		[Cpp2IlInjected.Address(RVA = "0x51651B0", Offset = "0x5163BB0", VA = "0x1851651B0", Slot = "13")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000164")]
	public Vector3 DALJIIPOFIE
	{
		[Cpp2IlInjected.Token(Token = "0x6000565")]
		[Cpp2IlInjected.Address(RVA = "0x51637C0", Offset = "0x51621C0", VA = "0x1851637C0", Slot = "14")]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x6000566")]
		[Cpp2IlInjected.Address(RVA = "0x5163720", Offset = "0x5162120", VA = "0x185163720", Slot = "15")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000165")]
	public float KJKDBCBOHIJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000567")]
		[Cpp2IlInjected.Address(RVA = "0x1100860", Offset = "0x10FF260", VA = "0x181100860", Slot = "16")]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x6000568")]
		[Cpp2IlInjected.Address(RVA = "0x5164940", Offset = "0x5163340", VA = "0x185164940", Slot = "17")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000166")]
	public bool NKPLDABKJCL
	{
		[Cpp2IlInjected.Token(Token = "0x6000569")]
		[Cpp2IlInjected.Address(RVA = "0x2041380", Offset = "0x203FD80", VA = "0x182041380", Slot = "18")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000167")]
	private GIGBMEPJFND IPDPPPGBPIC
	{
		[Cpp2IlInjected.Token(Token = "0x600057E")]
		[Cpp2IlInjected.Address(RVA = "0x1EC3B90", Offset = "0x1EC2590", VA = "0x181EC3B90")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000168")]
	private bool CEDDMPPAJDO
	{
		[Cpp2IlInjected.Token(Token = "0x600057F")]
		[Cpp2IlInjected.Address(RVA = "0x514A780", Offset = "0x5149180", VA = "0x18514A780")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600056A")]
	[Cpp2IlInjected.Address(RVA = "0x5166410", Offset = "0x5164E10", VA = "0x185166410")]
	public IHMHMODNCOJ(FFCGIONKJBI FHCKPPNILHO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600056B")]
	[Cpp2IlInjected.Address(RVA = "0x5163750", Offset = "0x5162150", VA = "0x185163750", Slot = "19")]
	public void NOMIHBFFLNG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600056C")]
	[Cpp2IlInjected.Address(RVA = "0x51643A0", Offset = "0x5162DA0", VA = "0x1851643A0", Slot = "37")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600056D")]
	[Cpp2IlInjected.Address(RVA = "0x5165080", Offset = "0x5163A80", VA = "0x185165080", Slot = "28")]
	public void KDPOLAHOOPE(Rigidbody MKOMGOCHBJC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600056E")]
	[Cpp2IlInjected.Address(RVA = "0xFD5A80", Offset = "0xFD4480", VA = "0x180FD5A80", Slot = "20")]
	public void OGEMIEDCOED(object HKLDIENGNNB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600056F")]
	[Cpp2IlInjected.Address(RVA = "0xFD52F0", Offset = "0xFD3CF0", VA = "0x180FD52F0", Slot = "31")]
	public void LPJEFBBEPMD(object HKLDIENGNNB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000570")]
	[Cpp2IlInjected.Address(RVA = "0x51656D0", Offset = "0x51640D0", VA = "0x1851656D0", Slot = "36")]
	public Vector3 LKOKGKNLODE(Vector3 JMLACAFKJOF)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000571")]
	[Cpp2IlInjected.Address(RVA = "0x5166160", Offset = "0x5164B60", VA = "0x185166160", Slot = "35")]
	public Vector3 PIFFFCJGHPG(Vector3 OLLLCEPAFHE)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000572")]
	[Cpp2IlInjected.Address(RVA = "0x5163750", Offset = "0x5162150", VA = "0x185163750", Slot = "27")]
	public void BCKDLBEFMPH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000573")]
	[Cpp2IlInjected.Address(RVA = "0x5166120", Offset = "0x5164B20", VA = "0x185166120", Slot = "25")]
	public void NLLIBPNNBGH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000574")]
	[Cpp2IlInjected.Address(RVA = "0x51660E0", Offset = "0x5164AE0", VA = "0x1851660E0", Slot = "24")]
	public void NFCJHIFEHGE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000575")]
	[Cpp2IlInjected.Address(RVA = "0x5165270", Offset = "0x5163C70", VA = "0x185165270", Slot = "34")]
	public void KPJAOLBLIEI(Vector3 PFDFFPLAJJP, Vector3 HGIFCPKBAGG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000576")]
	[Cpp2IlInjected.Address(RVA = "0x5164400", Offset = "0x5162E00", VA = "0x185164400", Slot = "33")]
	public void EBKBGNAGIOD(Vector3 LOGKBIHCFJD, Vector3 OGPMEJLJLFA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000577")]
	[Cpp2IlInjected.Address(RVA = "0x5164130", Offset = "0x5162B30", VA = "0x185164130", Slot = "32")]
	public void DNAJDFGLENG(Vector3 OANHHGBFKAN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000578")]
	[Cpp2IlInjected.Address(RVA = "0x51638B0", Offset = "0x51622B0", VA = "0x1851638B0", Slot = "22")]
	public void CBHLOBJDACM(CKAOOODELAE IKFPEHIFEPN, Vector3 NMBFBKMEJKN, float FEHHFHACKBK, float IOFMPFNPHNC = 8f, float JKLGNKAKKLG = 1f)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000579")]
	[Cpp2IlInjected.Address(RVA = "0x51658B0", Offset = "0x51642B0", VA = "0x1851658B0", Slot = "21")]
	public void NCIJALPIGCE(MCMFGEDCCGC LMLMHHPMBJO, Vector3 OFLGCJLDNJJ, float IPAPNFBMGEF = float.PositiveInfinity)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600057A")]
	[Cpp2IlInjected.Address(RVA = "0x5164640", Offset = "0x5163040", VA = "0x185164640", Slot = "23")]
	[Obsolete]
	public void FDJHKHJGOHO(MCMFGEDCCGC LMLMHHPMBJO, Vector3 JGCPJBFFFAC, float NMBEKOOKPJA = 7f, float MFBAPHBIEKM = 1f)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600057B")]
	[Cpp2IlInjected.Address(RVA = "0x5163660", Offset = "0x5162060", VA = "0x185163660", Slot = "30")]
	public Vector3 AJLBGCPJCKN(Vector3 CPHPLAEKCBK)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x600057C")]
	[Cpp2IlInjected.Address(RVA = "0x5166320", Offset = "0x5164D20", VA = "0x185166320", Slot = "29")]
	public Vector3 PIFNCDNOKAD(Vector3 HOLPFINNOLF)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x600057D")]
	[Cpp2IlInjected.Address(RVA = "0x51654B0", Offset = "0x5163EB0", VA = "0x1851654B0", Slot = "26")]
	public void LADPNNADDEK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000580")]
	[Cpp2IlInjected.Address(RVA = "0x5164940", Offset = "0x5163340", VA = "0x185164940")]
	private void GKNBMLJEJOF(float MAKFNMHIJIF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000581")]
	[Cpp2IlInjected.Address(RVA = "0x5164B50", Offset = "0x5163550", VA = "0x185164B50")]
	private void JEPNOFCGPGB(Vector3 OFLGCJLDNJJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000582")]
	[Cpp2IlInjected.Address(RVA = "0x5164A60", Offset = "0x5163460", VA = "0x185164A60")]
	private Vector3 JAOHNCJGCMP()
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000583")]
	[Cpp2IlInjected.Address(RVA = "0x5164D50", Offset = "0x5163750", VA = "0x185164D50")]
	private void JHJGANJBJGJ(Vector3 OLLLCEPAFHE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000584")]
	[Cpp2IlInjected.Address(RVA = "0x5163D00", Offset = "0x5162700", VA = "0x185163D00")]
	private Vector3 CHBOIJCOGNN()
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000585")]
	[Cpp2IlInjected.Address(RVA = "0x5163DF0", Offset = "0x51627F0", VA = "0x185163DF0")]
	private void DEJPPLEHGBP(Vector3 MAKFNMHIJIF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000586")]
	[Cpp2IlInjected.Address(RVA = "0x5165AE0", Offset = "0x51644E0", VA = "0x185165AE0")]
	private void NDFOCMJNPHI(Vector3 OLLLCEPAFHE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000587")]
	[Cpp2IlInjected.Address(RVA = "0x5164460", Offset = "0x5162E60", VA = "0x185164460")]
	private void EIEPCDLOKOO()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200005E")]
public class ONKNKBFAOPG : LGNFMEIAMDG
{
	[Cpp2IlInjected.Token(Token = "0x6000588")]
	[Cpp2IlInjected.Address(RVA = "0x601FDE0", Offset = "0x601E7E0", VA = "0x18601FDE0", Slot = "4")]
	public IPLGDMEHBOJ JLMEDKOMLPH(FFCGIONKJBI BMFGKMDOFCF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000589")]
	[Cpp2IlInjected.Address(RVA = "0x601FB80", Offset = "0x601E580", VA = "0x18601FB80", Slot = "5")]
	public GLBLEGFKOKL FNHIMIMINLC(FFCGIONKJBI BMFGKMDOFCF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600058A")]
	[Cpp2IlInjected.Address(RVA = "0x601FD80", Offset = "0x601E780", VA = "0x18601FD80", Slot = "6")]
	public EBAADMBJLMD IIOHLMKEJEJ(FFCGIONKJBI BMFGKMDOFCF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600058B")]
	[Cpp2IlInjected.Address(RVA = "0x601FEB0", Offset = "0x601E8B0", VA = "0x18601FEB0", Slot = "7")]
	public EKNFOOIEIBK NHGIHLGNLLB(FFCGIONKJBI BMFGKMDOFCF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600058C")]
	[Cpp2IlInjected.Address(RVA = "0x601F870", Offset = "0x601E270", VA = "0x18601F870", Slot = "8")]
	public MNHBOEHCOIK AMEBPOAGMKI(FFCGIONKJBI BMFGKMDOFCF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600058D")]
	[Cpp2IlInjected.Address(RVA = "0x601FB20", Offset = "0x601E520", VA = "0x18601FB20", Slot = "9")]
	public CGKAANMHLMI CCKENOLAJIO(FFCGIONKJBI BMFGKMDOFCF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600058E")]
	[Cpp2IlInjected.Address(RVA = "0x601F8D0", Offset = "0x601E2D0", VA = "0x18601F8D0", Slot = "10")]
	public MAMDKJFPNFM AOODCJDCKDB(FFCGIONKJBI BMFGKMDOFCF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600058F")]
	[Cpp2IlInjected.Address(RVA = "0x601FD20", Offset = "0x601E720", VA = "0x18601FD20", Slot = "11")]
	public GIGBMEPJFND IIMNBFJLPGA(FFCGIONKJBI BMFGKMDOFCF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000590")]
	[Cpp2IlInjected.Address(RVA = "0x601FC50", Offset = "0x601E650", VA = "0x18601FC50", Slot = "12")]
	public MFNEPAJBKBE GLEBFEAEHBH(FFCGIONKJBI BMFGKMDOFCF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000591")]
	[Cpp2IlInjected.Address(RVA = "0x601FA00", Offset = "0x601E400", VA = "0x18601FA00", Slot = "13")]
	public JJPLOLDPKDF BBOIPMMNANN(FFCGIONKJBI BMFGKMDOFCF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000592")]
	[Cpp2IlInjected.Address(RVA = "0x601FE40", Offset = "0x601E840", VA = "0x18601FE40")]
	public OOPDNBAAJIE LKGBOKHAFIF(FFCGIONKJBI BMFGKMDOFCF, in IMECCMKFBII JIHCLPECHIB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000593")]
	[Cpp2IlInjected.Address(RVA = "0x601FCB0", Offset = "0x601E6B0", VA = "0x18601FCB0")]
	public BHMDAAMOACJ GLKJADAGIAD(FFCGIONKJBI BMFGKMDOFCF, in IMECCMKFBII JIHCLPECHIB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000594")]
	[Cpp2IlInjected.Address(RVA = "0x601FBE0", Offset = "0x601E5E0", VA = "0x18601FBE0")]
	public CMCPDJMPOKN FOJJLIDIPCI(FFCGIONKJBI BMFGKMDOFCF, in IMECCMKFBII JIHCLPECHIB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000595")]
	[Cpp2IlInjected.Address(RVA = "0x601F800", Offset = "0x601E200", VA = "0x18601F800")]
	public CHBALODMMNE GLGIJKKAPGN(FFCGIONKJBI BMFGKMDOFCF, in IMECCMKFBII JIHCLPECHIB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000596")]
	[Cpp2IlInjected.Address(RVA = "0x601F990", Offset = "0x601E390", VA = "0x18601F990")]
	public KPBILAHOHAH ODODIKBAKJK(FFCGIONKJBI BMFGKMDOFCF, in IMECCMKFBII JIHCLPECHIB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000597")]
	[Cpp2IlInjected.Address(RVA = "0x601FA70", Offset = "0x601E470", VA = "0x18601FA70", Slot = "19")]
	public FFCGIONKJBI CAKONGBGLCH(RigidbodyEx FHCKPPNILHO, IMECCMKFBII JIHCLPECHIB, MPHIHDCLPDB HKMONJIHHIH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000598")]
	[Cpp2IlInjected.Address(RVA = "0x678B30", Offset = "0x677530", VA = "0x180678B30")]
	public ONKNKBFAOPG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000599")]
	[Cpp2IlInjected.Address(RVA = "0x601FE40", Offset = "0x601E840", VA = "0x18601FE40", Slot = "14")]
	private OOPDNBAAJIE KGODCDCCGDL(FFCGIONKJBI BMFGKMDOFCF, in IMECCMKFBII JIHCLPECHIB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600059A")]
	[Cpp2IlInjected.Address(RVA = "0x601FCB0", Offset = "0x601E6B0", VA = "0x18601FCB0", Slot = "15")]
	private BHMDAAMOACJ PJPJIFJAEAJ(FFCGIONKJBI BMFGKMDOFCF, in IMECCMKFBII JIHCLPECHIB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600059B")]
	[Cpp2IlInjected.Address(RVA = "0x601FBE0", Offset = "0x601E5E0", VA = "0x18601FBE0", Slot = "16")]
	private CMCPDJMPOKN IHLIJBJMJOL(FFCGIONKJBI BMFGKMDOFCF, in IMECCMKFBII JIHCLPECHIB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600059C")]
	[Cpp2IlInjected.Address(RVA = "0x601F800", Offset = "0x601E200", VA = "0x18601F800", Slot = "17")]
	private CHBALODMMNE AHPBLOONHKN(FFCGIONKJBI BMFGKMDOFCF, in IMECCMKFBII JIHCLPECHIB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600059D")]
	[Cpp2IlInjected.Address(RVA = "0x601F990", Offset = "0x601E390", VA = "0x18601F990", Slot = "18")]
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
		[Cpp2IlInjected.Address(RVA = "0x678B40", Offset = "0x677540", VA = "0x180678B40")]
		[Preserve]
		public _RRAssemblyIndex()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600059F")]
		[Cpp2IlInjected.Address(RVA = "0x6026490", Offset = "0x6024E90", VA = "0x186026490", Slot = "6")]
		public sealed override void FHBOKNJGNHA(JGIPCDLBHLE ONHFNOPIIKL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005A0")]
		[Cpp2IlInjected.Address(RVA = "0x6026670", Offset = "0x6025070", VA = "0x186026670", Slot = "4")]
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
	[Cpp2IlInjected.Address(RVA = "0x678B30", Offset = "0x677530", VA = "0x180678B30")]
	public MDBMMECDLKK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60005A3")]
	[Cpp2IlInjected.Address(RVA = "0x516A030", Offset = "0x5168A30", VA = "0x18516A030")]
	private static string LLKJKMBGMPE(byte[] LKLEFAIICIC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60005A4")]
	[Cpp2IlInjected.Address(RVA = "0x5169CE0", Offset = "0x51686E0", VA = "0x185169CE0")]
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
		[Cpp2IlInjected.Address(RVA = "0x678B30", Offset = "0x677530", VA = "0x180678B30")]
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
