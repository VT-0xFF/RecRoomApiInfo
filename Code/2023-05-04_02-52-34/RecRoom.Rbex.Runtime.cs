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
internal class CGKLGLBEDEH
{
	[Cpp2IlInjected.Token(Token = "0x4000001")]
	public const string KNAGCOJIEDC = "RBEX_DEFAULT";

	[Cpp2IlInjected.Token(Token = "0x4000002")]
	public const float JFEIMDCKMLF = 0.001f;

	[Cpp2IlInjected.Token(Token = "0x4000003")]
	public const float JMDPLMHLGKM = 0f;

	[Cpp2IlInjected.Token(Token = "0x4000004")]
	public const float GHCABINHHBB = 0.05f;

	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(RVA = "0x72E810", Offset = "0x72DC10", VA = "0x18072E810")]
	public CGKLGLBEDEH()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
public delegate void DGAAFHCPHEH(RigidbodyEx EJMCJKCJMNM);
[Cpp2IlInjected.Token(Token = "0x2000004")]
public delegate void MKKJLKCGEAC(RigidbodyEx EJMCJKCJMNM, bool OMIKAFGHIFK = false);
[Cpp2IlInjected.Token(Token = "0x2000005")]
public enum EECECFKKEJP
{
	[Cpp2IlInjected.Token(Token = "0x4000006")]
	Additive,
	[Cpp2IlInjected.Token(Token = "0x4000007")]
	Override,
	[Cpp2IlInjected.Token(Token = "0x4000008")]
	Reflective
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public enum GHELGGICJHJ
{
	[Cpp2IlInjected.Token(Token = "0x400000A")]
	OnlyForReducedPhysicsRateAndNotParenting,
	[Cpp2IlInjected.Token(Token = "0x400000B")]
	Never,
	[Cpp2IlInjected.Token(Token = "0x400000C")]
	OnEvenWhenParenting
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
public enum JDHBHPOMECG
{
	[Cpp2IlInjected.Token(Token = "0x400000E")]
	Additive,
	[Cpp2IlInjected.Token(Token = "0x400000F")]
	Override,
	[Cpp2IlInjected.Token(Token = "0x4000010")]
	Reflective
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
public class IPOIOPLAADG : KKMENLLDAPN
{
	[Cpp2IlInjected.Token(Token = "0x17000001")]
	public int MEHIPKALLPB
	{
		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x72B020", Offset = "0x72A420", VA = "0x18072B020", Slot = "4")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	public int DMEAPIODOKJ
	{
		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x72B0E0", Offset = "0x72A4E0", VA = "0x18072B0E0", Slot = "5")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0x72F5A0", Offset = "0x72E9A0", VA = "0x18072F5A0", Slot = "6")]
	public FCDCKNBKJML NGPFGLFICJL(float FLFEPFNINBJ)
	{
		return default(FCDCKNBKJML);
	}

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0x72E830", Offset = "0x72DC30", VA = "0x18072E830", Slot = "7")]
	public void AGMLDLCGDGN(FLCKAICBODN NBNOMDAKOCG, float KHPBNPIIPMK, FJJLEAMIEBC GFECCLMJIJB = FJJLEAMIEBC.Off)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(RVA = "0x72E830", Offset = "0x72DC30", VA = "0x18072E830", Slot = "8")]
	public void AGMLDLCGDGN(FLCKAICBODN NBNOMDAKOCG, Transform NNNEKOPBKOD, float KHPBNPIIPMK, FJJLEAMIEBC GFECCLMJIJB = FJJLEAMIEBC.Off)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(RVA = "0x72E830", Offset = "0x72DC30", VA = "0x18072E830", Slot = "9")]
	public void BKNMIOLEDCJ(FLCKAICBODN NBNOMDAKOCG, [Optional] float? KHPBNPIIPMK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(RVA = "0x72E830", Offset = "0x72DC30", VA = "0x18072E830", Slot = "10")]
	public void FJEBMLODAAK(FLCKAICBODN LILGPDENNHI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(RVA = "0x72F5A0", Offset = "0x72E9A0", VA = "0x18072F5A0", Slot = "11")]
	public FCDCKNBKJML BBCJDADENAF(FLCKAICBODN NBNOMDAKOCG)
	{
		return default(FCDCKNBKJML);
	}

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(RVA = "0x7359E0", Offset = "0x734DE0", VA = "0x1807359E0", Slot = "12")]
	public bool FJJDFBCKGOK(FLCKAICBODN NBNOMDAKOCG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(RVA = "0x72E830", Offset = "0x72DC30", VA = "0x18072E830", Slot = "13")]
	public void LJMKICNDLAI(FLCKAICBODN NBNOMDAKOCG, FJJLEAMIEBC GEIMPLCDGIJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(RVA = "0x72E810", Offset = "0x72DC10", VA = "0x18072E810")]
	public IPOIOPLAADG()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
[HAMPPOKOPOP(typeof(IGHAJODIIKL), new string[] { "Ignore", "Mock" })]
public class PMJPOIOGLBC : IGHAJODIIKL
{
	[Cpp2IlInjected.Token(Token = "0x17000003")]
	public bool BIAKKCIGCGA
	{
		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0x7B1910", Offset = "0x7B0D10", VA = "0x1807B1910", Slot = "4")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(RVA = "0x72E830", Offset = "0x72DC30", VA = "0x18072E830", Slot = "5")]
	public void IKKAAMCDFCC(string NOGDNAGMMCO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(RVA = "0x72E830", Offset = "0x72DC30", VA = "0x18072E830", Slot = "6")]
	public void FHNGJIOABHC(RigidbodyEx IILFNNEDNCJ, Action DAAMKALKLMO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(RVA = "0x72F5A0", Offset = "0x72E9A0", VA = "0x18072F5A0", Slot = "7")]
	public KKMENLLDAPN GNGDKHBAKPP(int IBKOPKJJILA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(RVA = "0x72E830", Offset = "0x72DC30", VA = "0x18072E830", Slot = "8")]
	public void CFFENDALNLG(Vector3 HNGOLMBMNBC, float PLDCHDPKEGB, Color HAFGGBNGKBN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(RVA = "0x72E810", Offset = "0x72DC10", VA = "0x18072E810")]
	public PMJPOIOGLBC()
	{
	}
}
namespace RecRoom
{
	[Cpp2IlInjected.Token(Token = "0x200000A")]
	[DisallowMultipleComponent]
	[JEGJCCBDMOE(OLCAJGBKOGB.Physics)]
	public sealed class RigidbodyEx : MonoBehaviour
	{
		[Cpp2IlInjected.Token(Token = "0x4000014")]
		private static readonly KLBHBMBPLOA JFFPIFJCILI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000015")]
		private bool IIBFOCPMDPC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000016")]
		private NCOEFPHLCKK DEJCFCAINJG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000017")]
		[SerializeField]
		[DOHNIIAADJA(DIMAPHHKBON.Self, false, false, false)]
		private Rigidbody unityRigidbody;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000018")]
		[SerializeField]
		[DOHNIIAADJA(DIMAPHHKBON.SelfAndParent, true, false, false)]
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
		private GHELGGICJHJ physicsInterpolation;

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
		internal NCOEFPHLCKK EOOOGHAIOAE
		{
			[Cpp2IlInjected.Token(Token = "0x600001B")]
			[Cpp2IlInjected.Address(RVA = "0x69A58F0", Offset = "0x69A4CF0", VA = "0x1869A58F0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000005")]
		public IReadOnlyList<RigidbodyEx> PHPDFDJEEEA
		{
			[Cpp2IlInjected.Token(Token = "0x6000031")]
			[Cpp2IlInjected.Address(RVA = "0x72B0B0", Offset = "0x72A4B0", VA = "0x18072B0B0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000032")]
			[Cpp2IlInjected.Address(RVA = "0x7DF050", Offset = "0x7DE450", VA = "0x1807DF050")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000006")]
		public RigidbodyEx GNACMJCGFII
		{
			[Cpp2IlInjected.Token(Token = "0x6000033")]
			[Cpp2IlInjected.Address(RVA = "0x69A7180", Offset = "0x69A6580", VA = "0x1869A7180")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000007")]
		public RigidbodyEx CMJKBCMDGHN
		{
			[Cpp2IlInjected.Token(Token = "0x6000034")]
			[Cpp2IlInjected.Address(RVA = "0x69A7120", Offset = "0x69A6520", VA = "0x1869A7120")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000008")]
		public RigidbodyEx GGEKFPEBLKN
		{
			[Cpp2IlInjected.Token(Token = "0x6000035")]
			[Cpp2IlInjected.Address(RVA = "0x69A7CE0", Offset = "0x69A70E0", VA = "0x1869A7CE0")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000036")]
			[Cpp2IlInjected.Address(RVA = "0x69A9430", Offset = "0x69A8830", VA = "0x1869A9430")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000009")]
		public Transform KMDNPAAIEIK
		{
			[Cpp2IlInjected.Token(Token = "0x6000037")]
			[Cpp2IlInjected.Address(RVA = "0x1076DF0", Offset = "0x10761F0", VA = "0x181076DF0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000A")]
		public Transform FNPJMEGGLFM
		{
			[Cpp2IlInjected.Token(Token = "0x6000038")]
			[Cpp2IlInjected.Address(RVA = "0x1076DF0", Offset = "0x10761F0", VA = "0x181076DF0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000B")]
		public FJJLEAMIEBC LEKOFMMMFBB
		{
			[Cpp2IlInjected.Token(Token = "0x6000039")]
			[Cpp2IlInjected.Address(RVA = "0x69A6E10", Offset = "0x69A6210", VA = "0x1869A6E10")]
			get
			{
				return default(FJJLEAMIEBC);
			}
			[Cpp2IlInjected.Token(Token = "0x600003A")]
			[Cpp2IlInjected.Address(RVA = "0x69A89D0", Offset = "0x69A7DD0", VA = "0x1869A89D0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000C")]
		public bool BBHAHOHMEPG
		{
			[Cpp2IlInjected.Token(Token = "0x600003B")]
			[Cpp2IlInjected.Address(RVA = "0x69A7390", Offset = "0x69A6790", VA = "0x1869A7390")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000D")]
		public bool MPDIPBBGKKB
		{
			[Cpp2IlInjected.Token(Token = "0x600003C")]
			[Cpp2IlInjected.Address(RVA = "0x69A6FA0", Offset = "0x69A63A0", VA = "0x1869A6FA0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000E")]
		public EKLLOLLHLDP LNMCPLFHCHG
		{
			[Cpp2IlInjected.Token(Token = "0x600003D")]
			[Cpp2IlInjected.Address(RVA = "0x69A7330", Offset = "0x69A6730", VA = "0x1869A7330")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600003E")]
			[Cpp2IlInjected.Address(RVA = "0x69A8BE0", Offset = "0x69A7FE0", VA = "0x1869A8BE0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000F")]
		public CHACNCJIDJM GJHPEGFOAME
		{
			[Cpp2IlInjected.Token(Token = "0x600003F")]
			[Cpp2IlInjected.Address(RVA = "0x69A72D0", Offset = "0x69A66D0", VA = "0x1869A72D0")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000040")]
			[Cpp2IlInjected.Address(RVA = "0x69A8B70", Offset = "0x69A7F70", VA = "0x1869A8B70")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000010")]
		public bool LIGEJEKODFL
		{
			[Cpp2IlInjected.Token(Token = "0x6000041")]
			[Cpp2IlInjected.Address(RVA = "0x69A71B0", Offset = "0x69A65B0", VA = "0x1869A71B0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000011")]
		public Rigidbody LNMDHFKNJIH
		{
			[Cpp2IlInjected.Token(Token = "0x6000042")]
			[Cpp2IlInjected.Address(RVA = "0x69A7210", Offset = "0x69A6610", VA = "0x1869A7210")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000012")]
		public bool KHDKIPLIJCN
		{
			[Cpp2IlInjected.Token(Token = "0x6000043")]
			[Cpp2IlInjected.Address(RVA = "0x69A7060", Offset = "0x69A6460", VA = "0x1869A7060")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000044")]
			[Cpp2IlInjected.Address(RVA = "0x69A8A90", Offset = "0x69A7E90", VA = "0x1869A8A90")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000013")]
		public bool GFGJJPEPNGP
		{
			[Cpp2IlInjected.Token(Token = "0x6000045")]
			[Cpp2IlInjected.Address(RVA = "0x3197CA0", Offset = "0x31970A0", VA = "0x183197CA0")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000046")]
			[Cpp2IlInjected.Address(RVA = "0x3197CB0", Offset = "0x31970B0", VA = "0x183197CB0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000014")]
		public float NJAPMMIKJGK
		{
			[Cpp2IlInjected.Token(Token = "0x6000047")]
			[Cpp2IlInjected.Address(RVA = "0x69A7C80", Offset = "0x69A7080", VA = "0x1869A7C80")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000015")]
		public float BJEKPKOHOHD
		{
			[Cpp2IlInjected.Token(Token = "0x6000048")]
			[Cpp2IlInjected.Address(RVA = "0x69A7C20", Offset = "0x69A7020", VA = "0x1869A7C20")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x6000049")]
			[Cpp2IlInjected.Address(RVA = "0x69A93C0", Offset = "0x69A87C0", VA = "0x1869A93C0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000016")]
		public float NKICPJKJIPG
		{
			[Cpp2IlInjected.Token(Token = "0x600004A")]
			[Cpp2IlInjected.Address(RVA = "0x69A75F0", Offset = "0x69A69F0", VA = "0x1869A75F0")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x600004B")]
			[Cpp2IlInjected.Address(RVA = "0x69A8E80", Offset = "0x69A8280", VA = "0x1869A8E80")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000017")]
		public float KJIENHELDBA
		{
			[Cpp2IlInjected.Token(Token = "0x600004C")]
			[Cpp2IlInjected.Address(RVA = "0x69A73F0", Offset = "0x69A67F0", VA = "0x1869A73F0")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x600004D")]
			[Cpp2IlInjected.Address(RVA = "0x69A8C50", Offset = "0x69A8050", VA = "0x1869A8C50")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000018")]
		public bool ECEFGAGMMPK
		{
			[Cpp2IlInjected.Token(Token = "0x600004E")]
			[Cpp2IlInjected.Address(RVA = "0x69A8200", Offset = "0x69A7600", VA = "0x1869A8200")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x600004F")]
			[Cpp2IlInjected.Address(RVA = "0x69A9970", Offset = "0x69A8D70", VA = "0x1869A9970")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000019")]
		public Vector3 GMBCHMBJMEK
		{
			[Cpp2IlInjected.Token(Token = "0x6000050")]
			[Cpp2IlInjected.Address(RVA = "0x69A7A00", Offset = "0x69A6E00", VA = "0x1869A7A00")]
			get
			{
				return default(Vector3);
			}
			[Cpp2IlInjected.Token(Token = "0x6000051")]
			[Cpp2IlInjected.Address(RVA = "0x69A9190", Offset = "0x69A8590", VA = "0x1869A9190")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001A")]
		public Vector3 HNGOLMBMNBC
		{
			[Cpp2IlInjected.Token(Token = "0x6000052")]
			[Cpp2IlInjected.Address(RVA = "0x69A8340", Offset = "0x69A7740", VA = "0x1869A8340")]
			get
			{
				return default(Vector3);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001B")]
		public CollisionDetectionMode ABODELJNHAP
		{
			[Cpp2IlInjected.Token(Token = "0x6000053")]
			[Cpp2IlInjected.Address(RVA = "0x69A7530", Offset = "0x69A6930", VA = "0x1869A7530")]
			get
			{
				return default(CollisionDetectionMode);
			}
			[Cpp2IlInjected.Token(Token = "0x6000054")]
			[Cpp2IlInjected.Address(RVA = "0x69A8DA0", Offset = "0x69A81A0", VA = "0x1869A8DA0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001C")]
		public float KKALKPOINCB
		{
			[Cpp2IlInjected.Token(Token = "0x6000055")]
			[Cpp2IlInjected.Address(RVA = "0x69A70C0", Offset = "0x69A64C0", VA = "0x1869A70C0")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x6000056")]
			[Cpp2IlInjected.Address(RVA = "0x69A8B00", Offset = "0x69A7F00", VA = "0x1869A8B00")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001D")]
		public RigidbodyConstraints JBGLIGODAKH
		{
			[Cpp2IlInjected.Token(Token = "0x6000057")]
			[Cpp2IlInjected.Address(RVA = "0x69A7590", Offset = "0x69A6990", VA = "0x1869A7590")]
			get
			{
				return default(RigidbodyConstraints);
			}
			[Cpp2IlInjected.Token(Token = "0x6000058")]
			[Cpp2IlInjected.Address(RVA = "0x69A8E10", Offset = "0x69A8210", VA = "0x1869A8E10")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001E")]
		public Vector3 FPBCPCJIICN
		{
			[Cpp2IlInjected.Token(Token = "0x6000059")]
			[Cpp2IlInjected.Address(RVA = "0x69A7D40", Offset = "0x69A7140", VA = "0x1869A7D40")]
			get
			{
				return default(Vector3);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001F")]
		public Vector3 LJOBCKOOBEG
		{
			[Cpp2IlInjected.Token(Token = "0x600005A")]
			[Cpp2IlInjected.Address(RVA = "0x69A7D40", Offset = "0x69A7140", VA = "0x1869A7D40")]
			get
			{
				return default(Vector3);
			}
			[Cpp2IlInjected.Token(Token = "0x600005B")]
			[Cpp2IlInjected.Address(RVA = "0x69A9740", Offset = "0x69A8B40", VA = "0x1869A9740")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000020")]
		public float KAKBMDMPBAD
		{
			[Cpp2IlInjected.Token(Token = "0x600005C")]
			[Cpp2IlInjected.Address(RVA = "0x69A7AE0", Offset = "0x69A6EE0", VA = "0x1869A7AE0")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x600005D")]
			[Cpp2IlInjected.Address(RVA = "0x69A9270", Offset = "0x69A8670", VA = "0x1869A9270")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000021")]
		public float NKEPFBEFOJJ
		{
			[Cpp2IlInjected.Token(Token = "0x600005E")]
			[Cpp2IlInjected.Address(RVA = "0x69A81A0", Offset = "0x69A75A0", VA = "0x1869A81A0")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x600005F")]
			[Cpp2IlInjected.Address(RVA = "0x69A9900", Offset = "0x69A8D00", VA = "0x1869A9900")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000022")]
		public Quaternion LBCAFAOMOKH
		{
			[Cpp2IlInjected.Token(Token = "0x6000060")]
			[Cpp2IlInjected.Address(RVA = "0x69A7E20", Offset = "0x69A7220", VA = "0x1869A7E20")]
			get
			{
				return default(Quaternion);
			}
			[Cpp2IlInjected.Token(Token = "0x6000061")]
			[Cpp2IlInjected.Address(RVA = "0x69A94A0", Offset = "0x69A88A0", VA = "0x1869A94A0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000023")]
		public Quaternion JNAFAGHBKBL
		{
			[Cpp2IlInjected.Token(Token = "0x6000062")]
			[Cpp2IlInjected.Address(RVA = "0x69A80C0", Offset = "0x69A74C0", VA = "0x1869A80C0")]
			get
			{
				return default(Quaternion);
			}
			[Cpp2IlInjected.Token(Token = "0x6000063")]
			[Cpp2IlInjected.Address(RVA = "0x69A9820", Offset = "0x69A8C20", VA = "0x1869A9820")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000024")]
		public Vector3 CJJCECBKAHH
		{
			[Cpp2IlInjected.Token(Token = "0x6000064")]
			[Cpp2IlInjected.Address(RVA = "0x69A7F00", Offset = "0x69A7300", VA = "0x1869A7F00")]
			get
			{
				return default(Vector3);
			}
			[Cpp2IlInjected.Token(Token = "0x6000065")]
			[Cpp2IlInjected.Address(RVA = "0x69A9580", Offset = "0x69A8980", VA = "0x1869A9580")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000025")]
		public Quaternion EMABLKCADLA
		{
			[Cpp2IlInjected.Token(Token = "0x6000066")]
			[Cpp2IlInjected.Address(RVA = "0x69A7FE0", Offset = "0x69A73E0", VA = "0x1869A7FE0")]
			get
			{
				return default(Quaternion);
			}
			[Cpp2IlInjected.Token(Token = "0x6000067")]
			[Cpp2IlInjected.Address(RVA = "0x69A9660", Offset = "0x69A8A60", VA = "0x1869A9660")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000026")]
		public Vector3 GCAABCBBBAL
		{
			[Cpp2IlInjected.Token(Token = "0x6000068")]
			[Cpp2IlInjected.Address(RVA = "0x69A8260", Offset = "0x69A7660", VA = "0x1869A8260")]
			get
			{
				return default(Vector3);
			}
			[Cpp2IlInjected.Token(Token = "0x6000069")]
			[Cpp2IlInjected.Address(RVA = "0x69A99E0", Offset = "0x69A8DE0", VA = "0x1869A99E0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000027")]
		public Vector3 HMPFDEAFPND
		{
			[Cpp2IlInjected.Token(Token = "0x600006A")]
			[Cpp2IlInjected.Address(RVA = "0x69A7B40", Offset = "0x69A6F40", VA = "0x1869A7B40")]
			get
			{
				return default(Vector3);
			}
			[Cpp2IlInjected.Token(Token = "0x600006B")]
			[Cpp2IlInjected.Address(RVA = "0x69A92E0", Offset = "0x69A86E0", VA = "0x1869A92E0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000028")]
		public Vector3 DIIFLOBFBLO
		{
			[Cpp2IlInjected.Token(Token = "0x600006C")]
			[Cpp2IlInjected.Address(RVA = "0x69A7450", Offset = "0x69A6850", VA = "0x1869A7450")]
			get
			{
				return default(Vector3);
			}
			[Cpp2IlInjected.Token(Token = "0x600006D")]
			[Cpp2IlInjected.Address(RVA = "0x69A8CC0", Offset = "0x69A80C0", VA = "0x1869A8CC0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000029")]
		public Vector3 FHFHNDANMPN
		{
			[Cpp2IlInjected.Token(Token = "0x600006E")]
			[Cpp2IlInjected.Address(RVA = "0x69A7920", Offset = "0x69A6D20", VA = "0x1869A7920")]
			get
			{
				return default(Vector3);
			}
			[Cpp2IlInjected.Token(Token = "0x600006F")]
			[Cpp2IlInjected.Address(RVA = "0x69A90B0", Offset = "0x69A84B0", VA = "0x1869A90B0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002A")]
		public Vector3 OLICLKGPABG
		{
			[Cpp2IlInjected.Token(Token = "0x6000070")]
			[Cpp2IlInjected.Address(RVA = "0x69A77E0", Offset = "0x69A6BE0", VA = "0x1869A77E0")]
			get
			{
				return default(Vector3);
			}
			[Cpp2IlInjected.Token(Token = "0x6000071")]
			[Cpp2IlInjected.Address(RVA = "0x69A8FD0", Offset = "0x69A83D0", VA = "0x1869A8FD0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002B")]
		public Quaternion AIDBIHPFFIK
		{
			[Cpp2IlInjected.Token(Token = "0x6000072")]
			[Cpp2IlInjected.Address(RVA = "0x69A7700", Offset = "0x69A6B00", VA = "0x1869A7700")]
			get
			{
				return default(Quaternion);
			}
			[Cpp2IlInjected.Token(Token = "0x6000073")]
			[Cpp2IlInjected.Address(RVA = "0x69A8EF0", Offset = "0x69A82F0", VA = "0x1869A8EF0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002C")]
		public Vector3 EPBCMIAGOAE
		{
			[Cpp2IlInjected.Token(Token = "0x6000074")]
			[Cpp2IlInjected.Address(RVA = "0x69A8500", Offset = "0x69A7900", VA = "0x1869A8500")]
			get
			{
				return default(Vector3);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002D")]
		public Vector3 POPFEKPNEIJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000075")]
			[Cpp2IlInjected.Address(RVA = "0x69A8420", Offset = "0x69A7820", VA = "0x1869A8420")]
			get
			{
				return default(Vector3);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002E")]
		public bool OJNHEHLGDGI
		{
			[Cpp2IlInjected.Token(Token = "0x6000076")]
			[Cpp2IlInjected.Address(RVA = "0x69A78C0", Offset = "0x69A6CC0", VA = "0x1869A78C0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002F")]
		public bool LFGDELENJCM
		{
			[Cpp2IlInjected.Token(Token = "0x6000077")]
			[Cpp2IlInjected.Address(RVA = "0x69A7000", Offset = "0x69A6400", VA = "0x1869A7000")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000030")]
		public bool NHCAAMEDKKB
		{
			[Cpp2IlInjected.Token(Token = "0x6000078")]
			[Cpp2IlInjected.Address(RVA = "0x69A6F40", Offset = "0x69A6340", VA = "0x1869A6F40")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000031")]
		public bool GDCCIECOAEF
		{
			[Cpp2IlInjected.Token(Token = "0x6000079")]
			[Cpp2IlInjected.Address(RVA = "0x69A6EE0", Offset = "0x69A62E0", VA = "0x1869A6EE0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000032")]
		public bool ABAINBEINAC
		{
			[Cpp2IlInjected.Token(Token = "0x600007A")]
			[Cpp2IlInjected.Address(RVA = "0x69A6DB0", Offset = "0x69A61B0", VA = "0x1869A6DB0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000033")]
		public bool PEMBAGILPPO
		{
			[Cpp2IlInjected.Token(Token = "0x600007B")]
			[Cpp2IlInjected.Address(RVA = "0x69A7650", Offset = "0x69A6A50", VA = "0x1869A7650")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000034")]
		public bool CDOMMGFPCNB
		{
			[Cpp2IlInjected.Token(Token = "0x600007C")]
			[Cpp2IlInjected.Address(RVA = "0x777CF0", Offset = "0x7770F0", VA = "0x180777CF0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000001")]
		public event DGAAFHCPHEH LAFMHICCNNB
		{
			[Cpp2IlInjected.Token(Token = "0x600001F")]
			[Cpp2IlInjected.Address(RVA = "0x69A6CD0", Offset = "0x69A60D0", VA = "0x1869A6CD0")]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000020")]
			[Cpp2IlInjected.Address(RVA = "0x69A88F0", Offset = "0x69A7CF0", VA = "0x1869A88F0")]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000002")]
		public event MKKJLKCGEAC NPFLEBOEALL
		{
			[Cpp2IlInjected.Token(Token = "0x6000021")]
			[Cpp2IlInjected.Address(RVA = "0x69A6C60", Offset = "0x69A6060", VA = "0x1869A6C60")]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000022")]
			[Cpp2IlInjected.Address(RVA = "0x69A8880", Offset = "0x69A7C80", VA = "0x1869A8880")]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000003")]
		public event DGAAFHCPHEH NJJHHELIHIP
		{
			[Cpp2IlInjected.Token(Token = "0x6000023")]
			[Cpp2IlInjected.Address(RVA = "0x69A69C0", Offset = "0x69A5DC0", VA = "0x1869A69C0")]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000024")]
			[Cpp2IlInjected.Address(RVA = "0x69A85E0", Offset = "0x69A79E0", VA = "0x1869A85E0")]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000004")]
		public event DGAAFHCPHEH EPBNCIPAFDB
		{
			[Cpp2IlInjected.Token(Token = "0x6000025")]
			[Cpp2IlInjected.Address(RVA = "0x69A6A30", Offset = "0x69A5E30", VA = "0x1869A6A30")]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000026")]
			[Cpp2IlInjected.Address(RVA = "0x69A8650", Offset = "0x69A7A50", VA = "0x1869A8650")]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000005")]
		public event DGAAFHCPHEH DHIFCNEILML
		{
			[Cpp2IlInjected.Token(Token = "0x6000027")]
			[Cpp2IlInjected.Address(RVA = "0x69A6B80", Offset = "0x69A5F80", VA = "0x1869A6B80")]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000028")]
			[Cpp2IlInjected.Address(RVA = "0x69A87A0", Offset = "0x69A7BA0", VA = "0x1869A87A0")]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000006")]
		public event Action<FCDCKNBKJML, FCDCKNBKJML> DLLBDKMMJIP
		{
			[Cpp2IlInjected.Token(Token = "0x6000029")]
			[Cpp2IlInjected.Address(RVA = "0x69A6B10", Offset = "0x69A5F10", VA = "0x1869A6B10")]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x600002A")]
			[Cpp2IlInjected.Address(RVA = "0x69A8730", Offset = "0x69A7B30", VA = "0x1869A8730")]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000007")]
		public event DGAAFHCPHEH CJGCBPJLDJA
		{
			[Cpp2IlInjected.Token(Token = "0x600002B")]
			[Cpp2IlInjected.Address(RVA = "0x69A6BF0", Offset = "0x69A5FF0", VA = "0x1869A6BF0")]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x600002C")]
			[Cpp2IlInjected.Address(RVA = "0x69A8810", Offset = "0x69A7C10", VA = "0x1869A8810")]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000008")]
		public event DGAAFHCPHEH OPFMBHBCCBN
		{
			[Cpp2IlInjected.Token(Token = "0x600002D")]
			[Cpp2IlInjected.Address(RVA = "0x69A6D40", Offset = "0x69A6140", VA = "0x1869A6D40")]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x600002E")]
			[Cpp2IlInjected.Address(RVA = "0x69A8960", Offset = "0x69A7D60", VA = "0x1869A8960")]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000009")]
		public event DGAAFHCPHEH MGPMCLDJCJA
		{
			[Cpp2IlInjected.Token(Token = "0x600002F")]
			[Cpp2IlInjected.Address(RVA = "0x69A6AA0", Offset = "0x69A5EA0", VA = "0x1869A6AA0")]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000030")]
			[Cpp2IlInjected.Address(RVA = "0x69A86C0", Offset = "0x69A7AC0", VA = "0x1869A86C0")]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(RVA = "0x7A04D0", Offset = "0x79F8D0", VA = "0x1807A04D0")]
		internal void HCALOHKNMHJ(NCOEFPHLCKK NLKDOMNEDBE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0x69A5860", Offset = "0x69A4C60", VA = "0x1869A5860")]
		internal void IAGILEKBKIE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x69A6710", Offset = "0x69A5B10", VA = "0x1869A6710")]
		[Conditional("DEBUG_BUILD")]
		[Conditional("UNITY_EDITOR")]
		public void TestOverrideUnityRigidbody(Rigidbody EGFCGGBAJBP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007D")]
		[Cpp2IlInjected.Address(RVA = "0x69A4FC0", Offset = "0x69A43C0", VA = "0x1869A4FC0")]
		private void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007E")]
		[Cpp2IlInjected.Address(RVA = "0x69A58F0", Offset = "0x69A4CF0", VA = "0x1869A58F0")]
		private NCOEFPHLCKK KBFEBNIJONE()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600007F")]
		[Cpp2IlInjected.Address(RVA = "0x69A52D0", Offset = "0x69A46D0", VA = "0x1869A52D0")]
		private void GJPLHHGHDFM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000080")]
		[Cpp2IlInjected.Address(RVA = "0x69A5C50", Offset = "0x69A5050", VA = "0x1869A5C50")]
		private void OnEnable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000081")]
		[Cpp2IlInjected.Address(RVA = "0x69A5BE0", Offset = "0x69A4FE0", VA = "0x1869A5BE0")]
		private void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000082")]
		[Cpp2IlInjected.Address(RVA = "0x69A5270", Offset = "0x69A4670", VA = "0x1869A5270")]
		private void FixedUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000083")]
		[Cpp2IlInjected.Address(RVA = "0x69A5BF0", Offset = "0x69A4FF0", VA = "0x1869A5BF0")]
		private void OnDrawGizmosSelected()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000084")]
		[Cpp2IlInjected.Address(RVA = "0x69A5CB0", Offset = "0x69A50B0", VA = "0x1869A5CB0")]
		private void OnValidate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000085")]
		[Cpp2IlInjected.Address(RVA = "0x69A4650", Offset = "0x69A3A50", VA = "0x1869A4650")]
		public void AddDoNotResetVelocityOnOwnershipChangeOverride(object MIFCLBEAOPM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000086")]
		[Cpp2IlInjected.Address(RVA = "0x69A5D20", Offset = "0x69A5120", VA = "0x1869A5D20")]
		public void RemoveDoNotResetVelocityOnOwnershipChangeOverride(object MIFCLBEAOPM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000087")]
		[Cpp2IlInjected.Address(RVA = "0x69A5210", Offset = "0x69A4610", VA = "0x1869A5210")]
		public void DisableCachedInertialPropertyOverride()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000088")]
		[Cpp2IlInjected.Address(RVA = "0x69A5B80", Offset = "0x69A4F80", VA = "0x1869A5B80")]
		public void MarkCachedInertialParametersDirty()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000089")]
		[Cpp2IlInjected.Address(RVA = "0x69A6510", Offset = "0x69A5910", VA = "0x1869A6510")]
		public void SetParent(RigidbodyEx LPJDDLMPNCG, bool OMIKAFGHIFK = false)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008A")]
		[Cpp2IlInjected.Address(RVA = "0x69A6030", Offset = "0x69A5430", VA = "0x1869A6030")]
		public void ResetLocalCenterOfMassToPrefabDefault()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008B")]
		[Cpp2IlInjected.Address(RVA = "0x69A59A0", Offset = "0x69A4DA0", VA = "0x1869A59A0")]
		public bool IsRigidbodyAncestor(RigidbodyEx FMPADABIBEJ)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600008C")]
		[Cpp2IlInjected.Address(RVA = "0x69A59E0", Offset = "0x69A4DE0", VA = "0x1869A59E0")]
		public bool IsRigidbodyDescendant(RigidbodyEx BOAHBOBCIFK)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600008D")]
		[Cpp2IlInjected.Address(RVA = "0x69A4870", Offset = "0x69A3C70", VA = "0x1869A4870")]
		public void AddInterpolationRestriction(object MIFCLBEAOPM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008E")]
		[Cpp2IlInjected.Address(RVA = "0x69A5D90", Offset = "0x69A5190", VA = "0x1869A5D90")]
		public void RemoveInterpolationRestriction(object MIFCLBEAOPM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008F")]
		[Cpp2IlInjected.Address(RVA = "0x69A5030", Offset = "0x69A4430", VA = "0x1869A5030")]
		public IDisposable BeginKinematicScope()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000090")]
		[Cpp2IlInjected.Address(RVA = "0x69A48E0", Offset = "0x69A3CE0", VA = "0x1869A48E0")]
		public void AddKinematic(object MIFCLBEAOPM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000091")]
		[Cpp2IlInjected.Address(RVA = "0x69A5E00", Offset = "0x69A5200", VA = "0x1869A5E00")]
		public void RemoveKinematic(object MIFCLBEAOPM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000092")]
		[Cpp2IlInjected.Address(RVA = "0x69A6490", Offset = "0x69A5890", VA = "0x1869A6490")]
		public void SetKinematic(object MIFCLBEAOPM, bool KLMBPMINIHN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000093")]
		[Cpp2IlInjected.Address(RVA = "0x69A6390", Offset = "0x69A5790", VA = "0x1869A6390")]
		public void SetDiscontinuousPositionAndRotation(Vector3 PGJOODJOMAI, Quaternion OMJBPOHHBNI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000094")]
		[Cpp2IlInjected.Address(RVA = "0x69A6290", Offset = "0x69A5690", VA = "0x1869A6290")]
		public void SetDiscontinuousLocalPositionAndLocalRotation(Vector3 PPNOLBKPBJH, Quaternion KAHANPFONLJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000095")]
		[Cpp2IlInjected.Address(RVA = "0x69A5760", Offset = "0x69A4B60", VA = "0x1869A5760")]
		public Vector3 GetConstrainedVelocity(Vector3 GCAABCBBBAL)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x6000096")]
		[Cpp2IlInjected.Address(RVA = "0x69A5660", Offset = "0x69A4A60", VA = "0x1869A5660")]
		public Vector3 GetConstrainedAngularVelocity(Vector3 DIIFLOBFBLO)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x6000097")]
		[Cpp2IlInjected.Address(RVA = "0x69A47E0", Offset = "0x69A3BE0", VA = "0x1869A47E0")]
		public void AddForce(Vector3 HKPPDHFDHMN, ForceMode MPMGBCACKOF = ForceMode.Force)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000098")]
		[Cpp2IlInjected.Address(RVA = "0x69A46C0", Offset = "0x69A3AC0", VA = "0x1869A46C0")]
		public void AddForceAtPosition(Vector3 HKPPDHFDHMN, Vector3 PICDPPHNNLH, ForceMode MPMGBCACKOF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000099")]
		[Cpp2IlInjected.Address(RVA = "0x69A49E0", Offset = "0x69A3DE0", VA = "0x1869A49E0")]
		public void AddTorque(Vector3 MBBMKANKKGB, ForceMode MPMGBCACKOF = ForceMode.Force)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009A")]
		[Cpp2IlInjected.Address(RVA = "0x69A4950", Offset = "0x69A3D50", VA = "0x1869A4950")]
		public void AddRelativeTorque(Vector3 MBBMKANKKGB, ForceMode MPMGBCACKOF = ForceMode.Force)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009B")]
		[Cpp2IlInjected.Address(RVA = "0x69A67F0", Offset = "0x69A5BF0", VA = "0x1869A67F0")]
		public Vector3 WorldToLocalVelocity(Vector3 JOJEMOKKGPP)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x600009C")]
		[Cpp2IlInjected.Address(RVA = "0x69A5A80", Offset = "0x69A4E80", VA = "0x1869A5A80")]
		public Vector3 LocalToWorldVelocity(Vector3 HMPFDEAFPND)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x600009D")]
		[Cpp2IlInjected.Address(RVA = "0x69A51B0", Offset = "0x69A45B0", VA = "0x1869A51B0")]
		public void ClearVelocity()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009E")]
		[Cpp2IlInjected.Address(RVA = "0x69A5150", Offset = "0x69A4550", VA = "0x1869A5150")]
		public void ClearUnityRigidbodyVelocity()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009F")]
		[Cpp2IlInjected.Address(RVA = "0x69A50F0", Offset = "0x69A44F0", VA = "0x1869A50F0")]
		public void ClearLinearVelocity()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A0")]
		[Cpp2IlInjected.Address(RVA = "0x69A5090", Offset = "0x69A4490", VA = "0x1869A5090")]
		public void ClearAngularVelocity()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A1")]
		[Cpp2IlInjected.Address(RVA = "0x69A6190", Offset = "0x69A5590", VA = "0x1869A6190")]
		public void ResetVelocityWorldSpace(Vector3 GKKEEHNMPBL, Vector3 NFGPCLPNMJK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A2")]
		[Cpp2IlInjected.Address(RVA = "0x69A6090", Offset = "0x69A5490", VA = "0x1869A6090")]
		public void ResetVelocityLocalSpace(Vector3 FHKLDEIKECB, Vector3 FHFHNDANMPN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A3")]
		[Cpp2IlInjected.Address(RVA = "0x69A5F50", Offset = "0x69A5350", VA = "0x1869A5F50")]
		public void ResetLinearVelocityLocalSpace(Vector3 FHKLDEIKECB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A4")]
		[Cpp2IlInjected.Address(RVA = "0x69A6600", Offset = "0x69A5A00", VA = "0x1869A6600")]
		public bool SweepTest(Vector3 MFKKMPGAJFI, out RaycastHit ONOMCDOFLKH, float CBFODBDKBEK)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000A5")]
		[Cpp2IlInjected.Address(RVA = "0x69A5A20", Offset = "0x69A4E20", VA = "0x1869A5A20")]
		public bool IsSleeping()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000A6")]
		[Cpp2IlInjected.Address(RVA = "0x69A65A0", Offset = "0x69A59A0", VA = "0x1869A65A0")]
		public void Sleep()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A7")]
		[Cpp2IlInjected.Address(RVA = "0x69A6790", Offset = "0x69A5B90", VA = "0x1869A6790")]
		public void WakeUp()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A8")]
		[Cpp2IlInjected.Address(RVA = "0x69A4A70", Offset = "0x69A3E70", VA = "0x1869A4A70")]
		public void AddUnityRigidbody(object MIFCLBEAOPM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A9")]
		[Cpp2IlInjected.Address(RVA = "0x69A5E70", Offset = "0x69A5270", VA = "0x1869A5E70")]
		public void RemoveUnityRigidbody(object MIFCLBEAOPM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AA")]
		[Cpp2IlInjected.Address(RVA = "0x69A4D90", Offset = "0x69A4190", VA = "0x1869A4D90")]
		public void ApplyForceVelocityChange(EECECFKKEJP KMDODPJBKLE, Vector3 CFLMAEMNHKL, float ABGPHLFIFAO, float OPCFMELHIKJ = 8f, float ECOHALOPPDN = 1f)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AB")]
		[Cpp2IlInjected.Address(RVA = "0x69A4C90", Offset = "0x69A4090", VA = "0x1869A4C90")]
		public void ApplyAngularVelocityChange(JDHBHPOMECG EFAKAOJPAJJ, Vector3 PKAJMBKNJIL, float KBLOKDLNEPD = float.PositiveInfinity)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AC")]
		[Cpp2IlInjected.Address(RVA = "0x69A4EB0", Offset = "0x69A42B0", VA = "0x1869A4EB0")]
		[Obsolete]
		public void ApplyTorqueAngularVelocityChangeDeprecated(JDHBHPOMECG EFAKAOJPAJJ, Vector3 IHCJBCJFELL, float MEJPNNANPLH = 7f, float CKIIILKMBKK = 1f)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AD")]
		[Cpp2IlInjected.Address(RVA = "0x69A4BD0", Offset = "0x69A3FD0", VA = "0x1869A4BD0")]
		public bool AllowedScaleChange(float ANPGDIDDDCB)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000AE")]
		[Cpp2IlInjected.Address(RVA = "0x69A4AE0", Offset = "0x69A3EE0", VA = "0x1869A4AE0")]
		public void AddWorldSpaceVelocityInHierarchyParentOverride(RigidbodyEx BKGBHBNCDJA, object MIFCLBEAOPM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AF")]
		[Cpp2IlInjected.Address(RVA = "0x69A5EE0", Offset = "0x69A52E0", VA = "0x1869A5EE0")]
		public void RemoveWorldSpaceVelocityInHierarchyParentOverride(object MIFCLBEAOPM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B0")]
		[Cpp2IlInjected.Address(RVA = "0x69A6940", Offset = "0x69A5D40", VA = "0x1869A6940")]
		public RigidbodyEx()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
internal static class BBBFCONGDJG
{
	[Cpp2IlInjected.Token(Token = "0x60000B5")]
	[Cpp2IlInjected.Address(RVA = "0x57AAB60", Offset = "0x57A9F60", VA = "0x1857AAB60")]
	public static NCOEFPHLCKK EOOOGHAIOAE(this RigidbodyEx IILFNNEDNCJ)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
public struct JCAJMGPJNDN
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000022")]
	public Rigidbody GHAGIOLHPMN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000023")]
	public PhotonView NIHEFIPHFDI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000024")]
	public OverridableVector3 OCCIBCJMCMD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000025")]
	public OverridableVector3 DDBDFGDEJNG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000026")]
	public GHELGGICJHJ FAACPMLGAIL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
	[Cpp2IlInjected.Token(Token = "0x4000027")]
	public bool DDHEKPKMKMJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x35")]
	[Cpp2IlInjected.Token(Token = "0x4000028")]
	public bool LAHEKDPLCHD;
}
namespace RecRoom
{
	[Cpp2IlInjected.Token(Token = "0x200000E")]
	[JEGJCCBDMOE(OLCAJGBKOGB.Physics)]
	[HAMPPOKOPOP(typeof(BKDMDHLJAEJ), new string[] { })]
	public class RigidbodyExManager : BKDMDHLJAEJ, GBCNOEIKEOL
	{
		[Cpp2IlInjected.Token(Token = "0x4000029")]
		private static readonly KLBHBMBPLOA JFFPIFJCILI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400002A")]
		private LPHNFCPFJBF KHKOGBBOGKO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400002B")]
		private IGHAJODIIKL NOHGMFJPJKL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400002C")]
		private CCKADDACLBD OHBNFBFIMDH;

		[Cpp2IlInjected.Token(Token = "0x17000035")]
		public bool FNDECKOCKHC
		{
			[Cpp2IlInjected.Token(Token = "0x60000B6")]
			[Cpp2IlInjected.Address(RVA = "0x69A4120", Offset = "0x69A3520", VA = "0x1869A4120", Slot = "6")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000036")]
		public IGHAJODIIKL CLPKFOJNNAA
		{
			[Cpp2IlInjected.Token(Token = "0x60000B7")]
			[Cpp2IlInjected.Address(RVA = "0x72B030", Offset = "0x72A430", VA = "0x18072B030", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000037")]
		public CCKADDACLBD BLIAEGBHDHG
		{
			[Cpp2IlInjected.Token(Token = "0x60000B8")]
			[Cpp2IlInjected.Address(RVA = "0x72F250", Offset = "0x72E650", VA = "0x18072F250", Slot = "5")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000B9")]
		[Cpp2IlInjected.Address(RVA = "0x69A4170", Offset = "0x69A3570", VA = "0x1869A4170", Slot = "12")]
		public void FLFPICJOFML(FJEOEPCCLME JGMMDACFJLC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000BA")]
		[Cpp2IlInjected.Address(RVA = "0x69A3E50", Offset = "0x69A3250", VA = "0x1869A3E50", Slot = "7")]
		public MBEDCJLMHEO EGHEGCMJHNL(RigidbodyEx IILFNNEDNCJ)
		{
			return default(MBEDCJLMHEO);
		}

		[Cpp2IlInjected.Token(Token = "0x60000BB")]
		[Cpp2IlInjected.Address(RVA = "0x69A43C0", Offset = "0x69A37C0", VA = "0x1869A43C0")]
		private static MBEDCJLMHEO KGBJFPMJCDH(RigidbodyEx IILFNNEDNCJ)
		{
			return default(MBEDCJLMHEO);
		}

		[Cpp2IlInjected.Token(Token = "0x60000BC")]
		[Cpp2IlInjected.Address(RVA = "0x69A3D40", Offset = "0x69A3140", VA = "0x1869A3D40", Slot = "8")]
		public NCOEFPHLCKK APMJEHJBGBJ(RigidbodyEx IILFNNEDNCJ, JCAJMGPJNDN HIDEHJGLNHO)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000BD")]
		[Cpp2IlInjected.Address(RVA = "0x69A42F0", Offset = "0x69A36F0", VA = "0x1869A42F0", Slot = "11")]
		private RigidbodyEx JMJIAGGMHNE(GameObject JNONJGMFMNE, JCAJMGPJNDN HIDEHJGLNHO)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000BE")]
		[Cpp2IlInjected.Address(RVA = "0x69A4200", Offset = "0x69A3600", VA = "0x1869A4200", Slot = "9")]
		public void HHEKJCFELLD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000BF")]
		[Cpp2IlInjected.Address(RVA = "0x69A44B0", Offset = "0x69A38B0", VA = "0x1869A44B0", Slot = "10")]
		public void KLDDNNLENKE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C0")]
		[Cpp2IlInjected.Address(RVA = "0x72E810", Offset = "0x72DC10", VA = "0x18072E810")]
		public RigidbodyExManager()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000F")]
	public class PhysicsManager : SingletonMonoBehaviour<PhysicsManager>
	{
		[Cpp2IlInjected.Token(Token = "0x400002D")]
		public static FNCKCCFNKKK UpdateAfterFixedUpdateRan;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400002E")]
		private int OOPAFJLGBGF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x400002F")]
		private int OIIFCLJENMH;

		[Cpp2IlInjected.Token(Token = "0x60000C2")]
		[Cpp2IlInjected.Address(RVA = "0x69A3820", Offset = "0x69A2C20", VA = "0x1869A3820")]
		protected void FixedUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C3")]
		[Cpp2IlInjected.Address(RVA = "0x69A3860", Offset = "0x69A2C60", VA = "0x1869A3860")]
		protected void Update()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C4")]
		[Cpp2IlInjected.Address(RVA = "0x69A3840", Offset = "0x69A2C40", VA = "0x1869A3840")]
		protected void LateUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C5")]
		[Cpp2IlInjected.Address(RVA = "0x72E830", Offset = "0x72DC30", VA = "0x18072E830")]
		[Conditional("UNITY_ASSERTIONS")]
		public void AssertLateColliderPositionsNotYetUpdated([Optional] string BALNMHDNCIN, [Optional] UnityEngine.Object PKDAKJPDDGD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C6")]
		[Cpp2IlInjected.Address(RVA = "0x72E830", Offset = "0x72DC30", VA = "0x18072E830")]
		[Conditional("UNITY_ASSERTIONS")]
		public void AssertLateColliderPositionsAlreadyUpdated([Optional] string BALNMHDNCIN, [Optional] UnityEngine.Object PKDAKJPDDGD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C7")]
		[Cpp2IlInjected.Address(RVA = "0x69A3950", Offset = "0x69A2D50", VA = "0x1869A3950")]
		public PhysicsManager()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
public static class PHMLDHNALOO
{
	[Cpp2IlInjected.Token(Token = "0x60000C9")]
	[Cpp2IlInjected.Address(RVA = "0x57CB3E0", Offset = "0x57CA7E0", VA = "0x1857CB3E0")]
	public static void BCLGFNINKDD(this Rigidbody EGFCGGBAJBP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CA")]
	[Cpp2IlInjected.Address(RVA = "0x57CB530", Offset = "0x57CA930", VA = "0x1857CB530")]
	public static void BCLGFNINKDD(this Rigidbody EGFCGGBAJBP, Vector3 OLICLKGPABG, Quaternion AIDBIHPFFIK, Vector3 HLNEMANOIEG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CB")]
	[Cpp2IlInjected.Address(RVA = "0x57CB640", Offset = "0x57CAA40", VA = "0x1857CB640")]
	public static void OKDHENJIFKE(Vector3 GCAABCBBBAL, Vector3 GCGCIPKJGGG, out Vector3 KIIINPINNOD, out Vector3 CJCBDLFPJNL)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
public static class MMMNNNGIGIF
{
	[Cpp2IlInjected.Token(Token = "0x2000012")]
	private class NCFKAKBGHGE : EKLLOLLHLDP, IDisposable
	{
		[Cpp2IlInjected.Token(Token = "0x60000CE")]
		[Cpp2IlInjected.Address(RVA = "0x72E830", Offset = "0x72DC30", VA = "0x18072E830", Slot = "6")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000CF")]
		[Cpp2IlInjected.Address(RVA = "0x108ABC0", Offset = "0x1089FC0", VA = "0x18108ABC0", Slot = "4")]
		public Vector3 BOHCGEJKGNK()
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x60000D0")]
		[Cpp2IlInjected.Address(RVA = "0x108ABC0", Offset = "0x1089FC0", VA = "0x18108ABC0", Slot = "5")]
		public Vector3 BGJJOBCDBBC()
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x60000D1")]
		[Cpp2IlInjected.Address(RVA = "0x72E810", Offset = "0x72DC10", VA = "0x18072E810")]
		public NCFKAKBGHGE()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000038")]
	public static EKLLOLLHLDP PGFHPADKEGH
	{
		[Cpp2IlInjected.Token(Token = "0x60000CC")]
		[Cpp2IlInjected.Address(RVA = "0x57C4AC0", Offset = "0x57C3EC0", VA = "0x1857C4AC0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000013")]
public interface AIOOGANOGPH
{
	[Cpp2IlInjected.Token(Token = "0x17000039")]
	CollisionDetectionMode PAOOKBBFCLK
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
	void PBJONABJOBO();

	[Cpp2IlInjected.Token(Token = "0x60000D5")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void DLGGDMCBIHM(bool OJNHEHLGDGI);

	[Cpp2IlInjected.Token(Token = "0x60000D6")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void FICHJHCOBIG(bool OJNHEHLGDGI);

	[Cpp2IlInjected.Token(Token = "0x60000D7")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void BOFMJFDPNBF(Rigidbody GHAGIOLHPMN);

	[Cpp2IlInjected.Token(Token = "0x60000D8")]
	[Cpp2IlInjected.Address(Slot = "6")]
	bool OFDKFHJBLOJ(Vector3 MFKKMPGAJFI, out RaycastHit ONOMCDOFLKH, float CBFODBDKBEK);
}
[Cpp2IlInjected.Token(Token = "0x2000014")]
public interface JBCOLILENLD : IDisposable, FLCKAICBODN
{
	[Cpp2IlInjected.Token(Token = "0x1700003A")]
	GGPABLKNBJB LEKOFMMMFBB
	{
		[Cpp2IlInjected.Token(Token = "0x60000DB")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
		[Cpp2IlInjected.Token(Token = "0x60000DC")]
		[Cpp2IlInjected.Address(Slot = "3")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x1400000A")]
	event Action<FCDCKNBKJML, FCDCKNBKJML> DLLBDKMMJIP;

	[Cpp2IlInjected.Token(Token = "0x60000DD")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void PBJONABJOBO();
}
[Cpp2IlInjected.Token(Token = "0x2000015")]
[DCBDIJCKLAD(IKIGKMLBEFF.Application)]
public interface CCKADDACLBD
{
	[Cpp2IlInjected.Token(Token = "0x60000DE")]
	[Cpp2IlInjected.Address(Slot = "0")]
	PLDJMDIFCKE HPIEMLILMFL(NCOEFPHLCKK NLKDOMNEDBE);

	[Cpp2IlInjected.Token(Token = "0x60000DF")]
	[Cpp2IlInjected.Address(Slot = "1")]
	ODMDEDICELM IINCPPFHAME(NCOEFPHLCKK NLKDOMNEDBE);

	[Cpp2IlInjected.Token(Token = "0x60000E0")]
	[Cpp2IlInjected.Address(Slot = "2")]
	IMBEMHENMNJ MOJGNMKJFLF(NCOEFPHLCKK NLKDOMNEDBE);

	[Cpp2IlInjected.Token(Token = "0x60000E1")]
	[Cpp2IlInjected.Address(Slot = "3")]
	CAONNBLCKEG ILCPDNKDAKJ(NCOEFPHLCKK NLKDOMNEDBE);

	[Cpp2IlInjected.Token(Token = "0x60000E2")]
	[Cpp2IlInjected.Address(Slot = "4")]
	EIMJIHNCMHI KJNNEGNLPCG(NCOEFPHLCKK NLKDOMNEDBE);

	[Cpp2IlInjected.Token(Token = "0x60000E3")]
	[Cpp2IlInjected.Address(Slot = "5")]
	JBCOLILENLD JDEHAKBEPFB(NCOEFPHLCKK NLKDOMNEDBE);

	[Cpp2IlInjected.Token(Token = "0x60000E4")]
	[Cpp2IlInjected.Address(Slot = "6")]
	KGDABPANOEG CLMAKHLOHMN(NCOEFPHLCKK NLKDOMNEDBE);

	[Cpp2IlInjected.Token(Token = "0x60000E5")]
	[Cpp2IlInjected.Address(Slot = "7")]
	BDJOPHNNEJG LAGKMHIIGOF(NCOEFPHLCKK NLKDOMNEDBE);

	[Cpp2IlInjected.Token(Token = "0x60000E6")]
	[Cpp2IlInjected.Address(Slot = "8")]
	AIOOGANOGPH JNMPFOJECMI(NCOEFPHLCKK NLKDOMNEDBE);

	[Cpp2IlInjected.Token(Token = "0x60000E7")]
	[Cpp2IlInjected.Address(Slot = "9")]
	BBGAPPNBFLO DPGNNNONAOD(NCOEFPHLCKK NLKDOMNEDBE);

	[Cpp2IlInjected.Token(Token = "0x60000E8")]
	[Cpp2IlInjected.Address(Slot = "10")]
	IPANMLAMAAD MNBKDOEPCLE(NCOEFPHLCKK NLKDOMNEDBE, in JCAJMGPJNDN HIDEHJGLNHO);

	[Cpp2IlInjected.Token(Token = "0x60000E9")]
	[Cpp2IlInjected.Address(Slot = "11")]
	INNKCACPKLA HPGHLDDNEHH(NCOEFPHLCKK NLKDOMNEDBE, in JCAJMGPJNDN HIDEHJGLNHO);

	[Cpp2IlInjected.Token(Token = "0x60000EA")]
	[Cpp2IlInjected.Address(Slot = "12")]
	LBPABMNHAKF OCGJAPKHCOA(NCOEFPHLCKK NLKDOMNEDBE, in JCAJMGPJNDN HIDEHJGLNHO);

	[Cpp2IlInjected.Token(Token = "0x60000EB")]
	[Cpp2IlInjected.Address(Slot = "13")]
	OGBLFJOOHEI BMJLAHFILLO(NCOEFPHLCKK NLKDOMNEDBE, in JCAJMGPJNDN HIDEHJGLNHO);

	[Cpp2IlInjected.Token(Token = "0x60000EC")]
	[Cpp2IlInjected.Address(Slot = "14")]
	IKFALNBDADN KIKLIMOCIDB(NCOEFPHLCKK NLKDOMNEDBE, in JCAJMGPJNDN HIDEHJGLNHO);

	[Cpp2IlInjected.Token(Token = "0x60000ED")]
	[Cpp2IlInjected.Address(Slot = "15")]
	NCOEFPHLCKK APMJEHJBGBJ(RigidbodyEx IILFNNEDNCJ, JCAJMGPJNDN HIDEHJGLNHO, BKDMDHLJAEJ CMIHNHHBGOO);
}
[Cpp2IlInjected.Token(Token = "0x2000016")]
public interface BDJOPHNNEJG
{
	[Cpp2IlInjected.Token(Token = "0x60000EE")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void BEJNHGKJNLM(Vector3 HKPPDHFDHMN, ForceMode MPMGBCACKOF = ForceMode.Force);

	[Cpp2IlInjected.Token(Token = "0x60000EF")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void CBMEMNKKLDE(Vector3 HKPPDHFDHMN, Vector3 PICDPPHNNLH, ForceMode MPMGBCACKOF);

	[Cpp2IlInjected.Token(Token = "0x60000F0")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void OHNHDPGFLAC(Vector3 MBBMKANKKGB, ForceMode MPMGBCACKOF = ForceMode.Force);

	[Cpp2IlInjected.Token(Token = "0x60000F1")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void PPDGHDJCFAP(Vector3 MBBMKANKKGB, ForceMode MPMGBCACKOF = ForceMode.Force);
}
[Cpp2IlInjected.Token(Token = "0x2000017")]
public interface BBGAPPNBFLO
{
	[Cpp2IlInjected.Token(Token = "0x1700003B")]
	bool OGIIANAEIFL
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
	void BOFMJFDPNBF(Rigidbody GHAGIOLHPMN);

	[Cpp2IlInjected.Token(Token = "0x60000F5")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void PKFCGBCFJGD(Rigidbody GHAGIOLHPMN);
}
[Cpp2IlInjected.Token(Token = "0x2000018")]
public interface PLDJMDIFCKE : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x1700003C")]
	IReadOnlyList<NCOEFPHLCKK> PHPDFDJEEEA
	{
		[Cpp2IlInjected.Token(Token = "0x6000108")]
		[Cpp2IlInjected.Address(Slot = "18")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700003D")]
	NCOEFPHLCKK CMJKBCMDGHN
	{
		[Cpp2IlInjected.Token(Token = "0x6000109")]
		[Cpp2IlInjected.Address(Slot = "19")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700003E")]
	NCOEFPHLCKK GKEMABFNEME
	{
		[Cpp2IlInjected.Token(Token = "0x600010A")]
		[Cpp2IlInjected.Address(Slot = "20")]
		get;
		[Cpp2IlInjected.Token(Token = "0x600010B")]
		[Cpp2IlInjected.Address(Slot = "21")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x1400000B")]
	event DGAAFHCPHEH NJJHHELIHIP;

	[Cpp2IlInjected.Token(Token = "0x1400000C")]
	event DGAAFHCPHEH EPBNCIPAFDB;

	[Cpp2IlInjected.Token(Token = "0x1400000D")]
	event MKKJLKCGEAC EIBHEHIGCNB;

	[Cpp2IlInjected.Token(Token = "0x1400000E")]
	event Action PFANGAANPGN;

	[Cpp2IlInjected.Token(Token = "0x1400000F")]
	event Action NJGCKLJKCAG;

	[Cpp2IlInjected.Token(Token = "0x14000010")]
	event Action<NCOEFPHLCKK> NFDMKCEEBKO;

	[Cpp2IlInjected.Token(Token = "0x14000011")]
	event Action<NCOEFPHLCKK> AMBCDPFGEAJ;

	[Cpp2IlInjected.Token(Token = "0x14000012")]
	event Action KKKJMJHLIKB;

	[Cpp2IlInjected.Token(Token = "0x14000013")]
	event Action<NCOEFPHLCKK> PFJIOBMDLAL;

	[Cpp2IlInjected.Token(Token = "0x600010C")]
	[Cpp2IlInjected.Address(Slot = "22")]
	void DEIBNNOCJKC(NCOEFPHLCKK BJNIPOLNMLD, bool OMIKAFGHIFK = false);
}
[Cpp2IlInjected.Token(Token = "0x2000019")]
public interface IMBEMHENMNJ
{
	[Cpp2IlInjected.Token(Token = "0x1700003F")]
	Vector3 BFENAJAEKJN
	{
		[Cpp2IlInjected.Token(Token = "0x600010D")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000040")]
	Vector3 LECHPMMLACE
	{
		[Cpp2IlInjected.Token(Token = "0x600010E")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x600010F")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void IOHAPAEGEFD(NCOEFPHLCKK GGEKFPEBLKN, object MIFCLBEAOPM);

	[Cpp2IlInjected.Token(Token = "0x6000110")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void DNECHJALIBL(object MIFCLBEAOPM);
}
[Cpp2IlInjected.Token(Token = "0x200001A")]
public interface OGBLFJOOHEI
{
	[Cpp2IlInjected.Token(Token = "0x17000041")]
	Vector3 BMNHHGGIMHD
	{
		[Cpp2IlInjected.Token(Token = "0x6000113")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
		[Cpp2IlInjected.Token(Token = "0x6000114")]
		[Cpp2IlInjected.Address(Slot = "3")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000042")]
	Vector3 ICDJEGJHDEE
	{
		[Cpp2IlInjected.Token(Token = "0x6000115")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000043")]
	float AHNCJOKPCCM
	{
		[Cpp2IlInjected.Token(Token = "0x6000116")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000044")]
	float JAHICELIBID
	{
		[Cpp2IlInjected.Token(Token = "0x6000117")]
		[Cpp2IlInjected.Address(Slot = "6")]
		get;
		[Cpp2IlInjected.Token(Token = "0x6000118")]
		[Cpp2IlInjected.Address(Slot = "7")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000045")]
	Vector3 JLIOGCPKLOL
	{
		[Cpp2IlInjected.Token(Token = "0x6000119")]
		[Cpp2IlInjected.Address(Slot = "8")]
		get;
		[Cpp2IlInjected.Token(Token = "0x600011A")]
		[Cpp2IlInjected.Address(Slot = "9")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000046")]
	Quaternion OCGLMIOIKKA
	{
		[Cpp2IlInjected.Token(Token = "0x600011B")]
		[Cpp2IlInjected.Address(Slot = "10")]
		get;
		[Cpp2IlInjected.Token(Token = "0x600011C")]
		[Cpp2IlInjected.Address(Slot = "11")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x14000014")]
	event DGAAFHCPHEH IBFMPJKFDEA;

	[Cpp2IlInjected.Token(Token = "0x600011D")]
	[Cpp2IlInjected.Address(Slot = "12")]
	void AEAABDHDFFI();

	[Cpp2IlInjected.Token(Token = "0x600011E")]
	[Cpp2IlInjected.Address(Slot = "13")]
	void FCDPOIHJAAG();

	[Cpp2IlInjected.Token(Token = "0x600011F")]
	[Cpp2IlInjected.Address(Slot = "14")]
	void IEIECPGHPLP();

	[Cpp2IlInjected.Token(Token = "0x6000120")]
	[Cpp2IlInjected.Address(Slot = "15")]
	void BOFMJFDPNBF(Rigidbody GHAGIOLHPMN);

	[Cpp2IlInjected.Token(Token = "0x6000121")]
	[Cpp2IlInjected.Address(Slot = "16")]
	void PKFCGBCFJGD(Rigidbody GHAGIOLHPMN);

	[Cpp2IlInjected.Token(Token = "0x6000122")]
	[Cpp2IlInjected.Address(Slot = "17")]
	void AMJHKJLPLNB();
}
[Cpp2IlInjected.Token(Token = "0x200001B")]
public interface LBPABMNHAKF
{
	[Cpp2IlInjected.Token(Token = "0x17000047")]
	bool OJDFKEJHLKC
	{
		[Cpp2IlInjected.Token(Token = "0x6000123")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000048")]
	JGBCGHMDEIJ PAEMELMEBEE
	{
		[Cpp2IlInjected.Token(Token = "0x6000124")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000125")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void PBJONABJOBO();

	[Cpp2IlInjected.Token(Token = "0x6000126")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void BBPFDNFCENP(object MIFCLBEAOPM);

	[Cpp2IlInjected.Token(Token = "0x6000127")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void JDDFJPPACKN(object MIFCLBEAOPM);

	[Cpp2IlInjected.Token(Token = "0x6000128")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void OKPPPAGPECC(NCOEFPHLCKK IILFNNEDNCJ);

	[Cpp2IlInjected.Token(Token = "0x6000129")]
	[Cpp2IlInjected.Address(Slot = "6")]
	void KONHDGEMJBN(NCOEFPHLCKK IILFNNEDNCJ);

	[Cpp2IlInjected.Token(Token = "0x600012A")]
	[Cpp2IlInjected.Address(Slot = "7")]
	void EKFOLENAMJE();
}
[Cpp2IlInjected.Token(Token = "0x200001C")]
public interface KGDABPANOEG
{
	[Cpp2IlInjected.Token(Token = "0x17000049")]
	bool FAJNDFDCOGA
	{
		[Cpp2IlInjected.Token(Token = "0x600012D")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700004A")]
	IEnumerable<object> OPBNFDMBOBA
	{
		[Cpp2IlInjected.Token(Token = "0x600012E")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x14000015")]
	event DGAAFHCPHEH KOKLFFIBABB;

	[Cpp2IlInjected.Token(Token = "0x600012F")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void LDMPNKDCNKH(object MIFCLBEAOPM);

	[Cpp2IlInjected.Token(Token = "0x6000130")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void FGAHJAEMBHA(object MIFCLBEAOPM);

	[Cpp2IlInjected.Token(Token = "0x6000131")]
	[Cpp2IlInjected.Address(Slot = "6")]
	void PNGKMLMJNAK(object MIFCLBEAOPM, bool KLMBPMINIHN);

	[Cpp2IlInjected.Token(Token = "0x6000132")]
	[Cpp2IlInjected.Address(Slot = "7")]
	IDisposable EBMGEFKJGJE();

	[Cpp2IlInjected.Token(Token = "0x6000133")]
	[Cpp2IlInjected.Address(Slot = "8")]
	void BOFMJFDPNBF(Rigidbody HKPNCKPHHLB);

	[Cpp2IlInjected.Token(Token = "0x6000134")]
	[Cpp2IlInjected.Address(Slot = "9")]
	void PKFCGBCFJGD(Rigidbody GHAGIOLHPMN);
}
[Cpp2IlInjected.Token(Token = "0x200001D")]
public interface INNKCACPKLA : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x1700004B")]
	bool BBHAHOHMEPG
	{
		[Cpp2IlInjected.Token(Token = "0x6000137")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700004C")]
	bool MPDIPBBGKKB
	{
		[Cpp2IlInjected.Token(Token = "0x6000138")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x14000016")]
	event DGAAFHCPHEH DELNFHCFIKO;

	[Cpp2IlInjected.Token(Token = "0x6000139")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void PBJONABJOBO();

	[Cpp2IlInjected.Token(Token = "0x600013A")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void FPAGIJPELCJ(NCOEFPHLCKK GGEKFPEBLKN);

	[Cpp2IlInjected.Token(Token = "0x600013B")]
	[Cpp2IlInjected.Address(Slot = "6")]
	void EDIJKBDKKBN(NCOEFPHLCKK GGEKFPEBLKN);
}
[Cpp2IlInjected.Token(Token = "0x200001E")]
public interface IKFALNBDADN
{
	[Cpp2IlInjected.Token(Token = "0x1700004D")]
	bool KHDKIPLIJCN
	{
		[Cpp2IlInjected.Token(Token = "0x600013C")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
		[Cpp2IlInjected.Token(Token = "0x600013D")]
		[Cpp2IlInjected.Address(Slot = "1")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x1700004E")]
	bool ILHHOPCAOME
	{
		[Cpp2IlInjected.Token(Token = "0x600013E")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700004F")]
	RigidbodyConstraints AOEOJAJAPKL
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
	void BOFMJFDPNBF(Rigidbody GHAGIOLHPMN);

	[Cpp2IlInjected.Token(Token = "0x6000142")]
	[Cpp2IlInjected.Address(Slot = "6")]
	void PKFCGBCFJGD(Rigidbody GHAGIOLHPMN);
}
[Cpp2IlInjected.Token(Token = "0x200001F")]
public interface CAONNBLCKEG
{
	[Cpp2IlInjected.Token(Token = "0x17000050")]
	float PGABAKFPNBB
	{
		[Cpp2IlInjected.Token(Token = "0x6000143")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
		[Cpp2IlInjected.Token(Token = "0x6000144")]
		[Cpp2IlInjected.Address(Slot = "1")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000051")]
	float DCNFDLOMNCM
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
	void BOFMJFDPNBF(Rigidbody GHAGIOLHPMN);

	[Cpp2IlInjected.Token(Token = "0x6000148")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void PKFCGBCFJGD(Rigidbody GHAGIOLHPMN);
}
[Cpp2IlInjected.Token(Token = "0x2000020")]
public interface JALFLILHBPD
{
	[Cpp2IlInjected.Token(Token = "0x6000149")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void OnRootRBEXChanged(RigidbodyEx JHFKNMGKLNH);
}
[Cpp2IlInjected.Token(Token = "0x2000021")]
public interface EIMJIHNCMHI
{
	[Cpp2IlInjected.Token(Token = "0x14000017")]
	event DGAAFHCPHEH BGFDOMIHHPL;

	[Cpp2IlInjected.Token(Token = "0x600014C")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void PBJONABJOBO();

	[Cpp2IlInjected.Token(Token = "0x600014D")]
	[Cpp2IlInjected.Address(Slot = "3")]
	bool NEPEFPHIELC();

	[Cpp2IlInjected.Token(Token = "0x600014E")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void NKFCECIGMAG();

	[Cpp2IlInjected.Token(Token = "0x600014F")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void PKFLOCAHJCK();

	[Cpp2IlInjected.Token(Token = "0x6000150")]
	[Cpp2IlInjected.Address(Slot = "6")]
	void LMCNKOCFNJH();

	[Cpp2IlInjected.Token(Token = "0x6000151")]
	[Cpp2IlInjected.Address(Slot = "7")]
	void PFPLFILECPI();

	[Cpp2IlInjected.Token(Token = "0x6000152")]
	[Cpp2IlInjected.Address(Slot = "8")]
	void PHLPAOAPADB(bool DFLJHGHEKJD);
}
[Cpp2IlInjected.Token(Token = "0x2000022")]
public interface IPANMLAMAAD
{
	[Cpp2IlInjected.Token(Token = "0x17000052")]
	Rigidbody LNMDHFKNJIH
	{
		[Cpp2IlInjected.Token(Token = "0x6000153")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000154")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void PBJONABJOBO();

	[Cpp2IlInjected.Token(Token = "0x6000155")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void KPOLANLNJJI(object MIFCLBEAOPM);

	[Cpp2IlInjected.Token(Token = "0x6000156")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void HIBCGDMOODJ(object MIFCLBEAOPM);

	[Cpp2IlInjected.Token(Token = "0x6000157")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void EDEILOABNOJ();

	[Cpp2IlInjected.Token(Token = "0x6000158")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void EONBBMLLGPB();

	[Cpp2IlInjected.Token(Token = "0x6000159")]
	[Cpp2IlInjected.Address(Slot = "6")]
	void FDIDMCANFME();

	[Cpp2IlInjected.Token(Token = "0x600015A")]
	[Cpp2IlInjected.Address(Slot = "7")]
	void IKMAJMOKAJI();
}
[Cpp2IlInjected.Token(Token = "0x2000023")]
public interface ODMDEDICELM : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x17000053")]
	EKLLOLLHLDP LNMCPLFHCHG
	{
		[Cpp2IlInjected.Token(Token = "0x600015B")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
		[Cpp2IlInjected.Token(Token = "0x600015C")]
		[Cpp2IlInjected.Address(Slot = "1")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000054")]
	CHACNCJIDJM GJHPEGFOAME
	{
		[Cpp2IlInjected.Token(Token = "0x600015D")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
		[Cpp2IlInjected.Token(Token = "0x600015E")]
		[Cpp2IlInjected.Address(Slot = "3")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000055")]
	Vector3 LGEGEJPPDAD
	{
		[Cpp2IlInjected.Token(Token = "0x600015F")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
		[Cpp2IlInjected.Token(Token = "0x6000160")]
		[Cpp2IlInjected.Address(Slot = "5")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000056")]
	Vector3 JBHIDAJMGMM
	{
		[Cpp2IlInjected.Token(Token = "0x6000161")]
		[Cpp2IlInjected.Address(Slot = "6")]
		get;
		[Cpp2IlInjected.Token(Token = "0x6000162")]
		[Cpp2IlInjected.Address(Slot = "7")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000057")]
	Vector3 LJMFIEJCGLD
	{
		[Cpp2IlInjected.Token(Token = "0x6000163")]
		[Cpp2IlInjected.Address(Slot = "8")]
		get;
		[Cpp2IlInjected.Token(Token = "0x6000164")]
		[Cpp2IlInjected.Address(Slot = "9")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000058")]
	Vector3 ICEKJCBHJBH
	{
		[Cpp2IlInjected.Token(Token = "0x6000165")]
		[Cpp2IlInjected.Address(Slot = "10")]
		get;
		[Cpp2IlInjected.Token(Token = "0x6000166")]
		[Cpp2IlInjected.Address(Slot = "11")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000059")]
	float KKALKPOINCB
	{
		[Cpp2IlInjected.Token(Token = "0x6000167")]
		[Cpp2IlInjected.Address(Slot = "12")]
		get;
		[Cpp2IlInjected.Token(Token = "0x6000168")]
		[Cpp2IlInjected.Address(Slot = "13")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x1700005A")]
	bool LIGEJEKODFL
	{
		[Cpp2IlInjected.Token(Token = "0x6000169")]
		[Cpp2IlInjected.Address(Slot = "14")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x600016A")]
	[Cpp2IlInjected.Address(Slot = "15")]
	void PBJONABJOBO();

	[Cpp2IlInjected.Token(Token = "0x600016B")]
	[Cpp2IlInjected.Address(Slot = "16")]
	void KNFJENEFGIE(object MIFCLBEAOPM);

	[Cpp2IlInjected.Token(Token = "0x600016C")]
	[Cpp2IlInjected.Address(Slot = "17")]
	void HHLJBCNAEPM(JDHBHPOMECG EFAKAOJPAJJ, Vector3 PKAJMBKNJIL, float KBLOKDLNEPD = float.PositiveInfinity);

	[Cpp2IlInjected.Token(Token = "0x600016D")]
	[Cpp2IlInjected.Address(Slot = "18")]
	void HHAFJJGJPFB(EECECFKKEJP KMDODPJBKLE, Vector3 CFLMAEMNHKL, float ABGPHLFIFAO, float OPCFMELHIKJ = 8f, float ECOHALOPPDN = 1f);

	[Cpp2IlInjected.Token(Token = "0x600016E")]
	[Cpp2IlInjected.Address(Slot = "19")]
	void IALNLOAFGMK(JDHBHPOMECG EFAKAOJPAJJ, Vector3 IHCJBCJFELL, float MEJPNNANPLH = 7f, float CKIIILKMBKK = 1f);

	[Cpp2IlInjected.Token(Token = "0x600016F")]
	[Cpp2IlInjected.Address(Slot = "20")]
	void IFMLGPGPJDO();

	[Cpp2IlInjected.Token(Token = "0x6000170")]
	[Cpp2IlInjected.Address(Slot = "21")]
	void BHDNAPGFIPJ();

	[Cpp2IlInjected.Token(Token = "0x6000171")]
	[Cpp2IlInjected.Address(Slot = "22")]
	void EPOKPKAANHO();

	[Cpp2IlInjected.Token(Token = "0x6000172")]
	[Cpp2IlInjected.Address(Slot = "23")]
	void INLPOAEPJGG();

	[Cpp2IlInjected.Token(Token = "0x6000173")]
	[Cpp2IlInjected.Address(Slot = "24")]
	void BOFMJFDPNBF(Rigidbody GHAGIOLHPMN);

	[Cpp2IlInjected.Token(Token = "0x6000174")]
	[Cpp2IlInjected.Address(Slot = "25")]
	Vector3 GJAHBCCOAII(Vector3 DIIFLOBFBLO);

	[Cpp2IlInjected.Token(Token = "0x6000175")]
	[Cpp2IlInjected.Address(Slot = "26")]
	Vector3 DNICIBAAMCG(Vector3 GCAABCBBBAL);

	[Cpp2IlInjected.Token(Token = "0x6000176")]
	[Cpp2IlInjected.Address(Slot = "27")]
	void NEMGEGCJOPN(object MIFCLBEAOPM);

	[Cpp2IlInjected.Token(Token = "0x6000177")]
	[Cpp2IlInjected.Address(Slot = "28")]
	void KIIDBBLBANB(Vector3 JDDALKKDLNA);

	[Cpp2IlInjected.Token(Token = "0x6000178")]
	[Cpp2IlInjected.Address(Slot = "29")]
	void JLDEEBLCKGA(Vector3 FHKLDEIKECB, Vector3 FHFHNDANMPN);

	[Cpp2IlInjected.Token(Token = "0x6000179")]
	[Cpp2IlInjected.Address(Slot = "30")]
	void NGFKLMPAGOE(Vector3 GKKEEHNMPBL, Vector3 NFGPCLPNMJK);

	[Cpp2IlInjected.Token(Token = "0x600017A")]
	[Cpp2IlInjected.Address(Slot = "31")]
	Vector3 KIKKEDPKAKK(Vector3 HMPFDEAFPND);

	[Cpp2IlInjected.Token(Token = "0x600017B")]
	[Cpp2IlInjected.Address(Slot = "32")]
	Vector3 AFFCJBHNNJL(Vector3 JOJEMOKKGPP);
}
[Cpp2IlInjected.Token(Token = "0x2000024")]
[DCBDIJCKLAD(IKIGKMLBEFF.Application)]
public interface IGHAJODIIKL
{
	[Cpp2IlInjected.Token(Token = "0x1700005B")]
	bool BIAKKCIGCGA
	{
		[Cpp2IlInjected.Token(Token = "0x600017C")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x600017D")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void IKKAAMCDFCC(string NOGDNAGMMCO);

	[Cpp2IlInjected.Token(Token = "0x600017E")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void FHNGJIOABHC(RigidbodyEx IILFNNEDNCJ, Action DAAMKALKLMO);

	[Cpp2IlInjected.Token(Token = "0x600017F")]
	[Cpp2IlInjected.Address(Slot = "3")]
	KKMENLLDAPN GNGDKHBAKPP(int IBKOPKJJILA);

	[Cpp2IlInjected.Token(Token = "0x6000180")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void CFFENDALNLG(Vector3 HNGOLMBMNBC, float PLDCHDPKEGB, Color HAFGGBNGKBN);
}
[Cpp2IlInjected.Token(Token = "0x2000025")]
[DCBDIJCKLAD(IKIGKMLBEFF.Application)]
public interface BKDMDHLJAEJ
{
	[Cpp2IlInjected.Token(Token = "0x1700005C")]
	IGHAJODIIKL CLPKFOJNNAA
	{
		[Cpp2IlInjected.Token(Token = "0x6000181")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700005D")]
	CCKADDACLBD BLIAEGBHDHG
	{
		[Cpp2IlInjected.Token(Token = "0x6000182")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700005E")]
	bool FNDECKOCKHC
	{
		[Cpp2IlInjected.Token(Token = "0x6000183")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000184")]
	[Cpp2IlInjected.Address(Slot = "3")]
	MBEDCJLMHEO EGHEGCMJHNL(RigidbodyEx IILFNNEDNCJ);

	[Cpp2IlInjected.Token(Token = "0x6000185")]
	[Cpp2IlInjected.Address(Slot = "4")]
	NCOEFPHLCKK APMJEHJBGBJ(RigidbodyEx IILFNNEDNCJ, JCAJMGPJNDN HIDEHJGLNHO);

	[Cpp2IlInjected.Token(Token = "0x6000186")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void HHEKJCFELLD();

	[Cpp2IlInjected.Token(Token = "0x6000187")]
	[Cpp2IlInjected.Address(Slot = "6")]
	void KLDDNNLENKE();

	[Cpp2IlInjected.Token(Token = "0x6000188")]
	[Cpp2IlInjected.Address(Slot = "7")]
	internal RigidbodyEx GIFJOELLPHL(GameObject JNONJGMFMNE, [Optional] JCAJMGPJNDN HIDEHJGLNHO);
}
[Cpp2IlInjected.Token(Token = "0x2000026")]
public interface CHACNCJIDJM
{
	[Cpp2IlInjected.Token(Token = "0x6000189")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void BJIHEAFMKCO(Vector3 NBPFLBOCGJL);

	[Cpp2IlInjected.Token(Token = "0x600018A")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void HOGMIBAAANA(Vector3 DIIFLOBFBLO);

	[Cpp2IlInjected.Token(Token = "0x600018B")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void NHCDCOOMJKI(Vector3 NBPFLBOCGJL);

	[Cpp2IlInjected.Token(Token = "0x600018C")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void KKMBOHHCKDH(Vector3 DIIFLOBFBLO);
}
[Cpp2IlInjected.Token(Token = "0x2000027")]
public interface EKLLOLLHLDP : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x600018D")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Vector3 BOHCGEJKGNK();

	[Cpp2IlInjected.Token(Token = "0x600018E")]
	[Cpp2IlInjected.Address(Slot = "1")]
	Vector3 BGJJOBCDBBC();
}
[Cpp2IlInjected.Token(Token = "0x2000028")]
public interface NCOEFPHLCKK : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x1700005F")]
	Rigidbody LNMDHFKNJIH
	{
		[Cpp2IlInjected.Token(Token = "0x600018F")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000060")]
	RigidbodyEx OEOEKIBFEMO
	{
		[Cpp2IlInjected.Token(Token = "0x6000190")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000061")]
	GameObject MILHHPLGFOL
	{
		[Cpp2IlInjected.Token(Token = "0x6000191")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000062")]
	Transform LHEBMCHBDEI
	{
		[Cpp2IlInjected.Token(Token = "0x6000192")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000063")]
	IEnumerable<object> IMECMIODOMG
	{
		[Cpp2IlInjected.Token(Token = "0x6000193")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000064")]
	NCOEFPHLCKK GKEMABFNEME
	{
		[Cpp2IlInjected.Token(Token = "0x6000194")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
		[Cpp2IlInjected.Token(Token = "0x6000195")]
		[Cpp2IlInjected.Address(Slot = "6")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000065")]
	IReadOnlyList<NCOEFPHLCKK> PHPDFDJEEEA
	{
		[Cpp2IlInjected.Token(Token = "0x6000196")]
		[Cpp2IlInjected.Address(Slot = "7")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000066")]
	NCOEFPHLCKK CMJKBCMDGHN
	{
		[Cpp2IlInjected.Token(Token = "0x6000197")]
		[Cpp2IlInjected.Address(Slot = "8")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000067")]
	bool KMDIPAOGGGF
	{
		[Cpp2IlInjected.Token(Token = "0x6000198")]
		[Cpp2IlInjected.Address(Slot = "9")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000068")]
	bool BBHAHOHMEPG
	{
		[Cpp2IlInjected.Token(Token = "0x6000199")]
		[Cpp2IlInjected.Address(Slot = "10")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000069")]
	bool MPDIPBBGKKB
	{
		[Cpp2IlInjected.Token(Token = "0x600019A")]
		[Cpp2IlInjected.Address(Slot = "11")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700006A")]
	EKLLOLLHLDP LNMCPLFHCHG
	{
		[Cpp2IlInjected.Token(Token = "0x600019B")]
		[Cpp2IlInjected.Address(Slot = "12")]
		get;
		[Cpp2IlInjected.Token(Token = "0x600019C")]
		[Cpp2IlInjected.Address(Slot = "13")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x1700006B")]
	CHACNCJIDJM GJHPEGFOAME
	{
		[Cpp2IlInjected.Token(Token = "0x600019D")]
		[Cpp2IlInjected.Address(Slot = "14")]
		get;
		[Cpp2IlInjected.Token(Token = "0x600019E")]
		[Cpp2IlInjected.Address(Slot = "15")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x1700006C")]
	float KKALKPOINCB
	{
		[Cpp2IlInjected.Token(Token = "0x600019F")]
		[Cpp2IlInjected.Address(Slot = "16")]
		get;
		[Cpp2IlInjected.Token(Token = "0x60001A0")]
		[Cpp2IlInjected.Address(Slot = "17")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x1700006D")]
	Vector3 JBHIDAJMGMM
	{
		[Cpp2IlInjected.Token(Token = "0x60001A1")]
		[Cpp2IlInjected.Address(Slot = "18")]
		get;
		[Cpp2IlInjected.Token(Token = "0x60001A2")]
		[Cpp2IlInjected.Address(Slot = "19")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x1700006E")]
	Vector3 ICEKJCBHJBH
	{
		[Cpp2IlInjected.Token(Token = "0x60001A3")]
		[Cpp2IlInjected.Address(Slot = "20")]
		get;
		[Cpp2IlInjected.Token(Token = "0x60001A4")]
		[Cpp2IlInjected.Address(Slot = "21")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x1700006F")]
	Vector3 LGEGEJPPDAD
	{
		[Cpp2IlInjected.Token(Token = "0x60001A5")]
		[Cpp2IlInjected.Address(Slot = "22")]
		get;
		[Cpp2IlInjected.Token(Token = "0x60001A6")]
		[Cpp2IlInjected.Address(Slot = "23")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000070")]
	Vector3 LJMFIEJCGLD
	{
		[Cpp2IlInjected.Token(Token = "0x60001A7")]
		[Cpp2IlInjected.Address(Slot = "24")]
		get;
		[Cpp2IlInjected.Token(Token = "0x60001A8")]
		[Cpp2IlInjected.Address(Slot = "25")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000071")]
	bool NHCAAMEDKKB
	{
		[Cpp2IlInjected.Token(Token = "0x60001A9")]
		[Cpp2IlInjected.Address(Slot = "26")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000072")]
	bool GDCCIECOAEF
	{
		[Cpp2IlInjected.Token(Token = "0x60001AA")]
		[Cpp2IlInjected.Address(Slot = "27")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000073")]
	bool ABAINBEINAC
	{
		[Cpp2IlInjected.Token(Token = "0x60001AB")]
		[Cpp2IlInjected.Address(Slot = "28")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000074")]
	bool LIGEJEKODFL
	{
		[Cpp2IlInjected.Token(Token = "0x60001AC")]
		[Cpp2IlInjected.Address(Slot = "29")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000075")]
	Vector3 BFENAJAEKJN
	{
		[Cpp2IlInjected.Token(Token = "0x60001AD")]
		[Cpp2IlInjected.Address(Slot = "30")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000076")]
	Vector3 LECHPMMLACE
	{
		[Cpp2IlInjected.Token(Token = "0x60001AE")]
		[Cpp2IlInjected.Address(Slot = "31")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000077")]
	Vector3 BMNHHGGIMHD
	{
		[Cpp2IlInjected.Token(Token = "0x60001AF")]
		[Cpp2IlInjected.Address(Slot = "32")]
		get;
		[Cpp2IlInjected.Token(Token = "0x60001B0")]
		[Cpp2IlInjected.Address(Slot = "33")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000078")]
	Vector3 ICDJEGJHDEE
	{
		[Cpp2IlInjected.Token(Token = "0x60001B1")]
		[Cpp2IlInjected.Address(Slot = "34")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000079")]
	float AHNCJOKPCCM
	{
		[Cpp2IlInjected.Token(Token = "0x60001B2")]
		[Cpp2IlInjected.Address(Slot = "35")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700007A")]
	float JAHICELIBID
	{
		[Cpp2IlInjected.Token(Token = "0x60001B3")]
		[Cpp2IlInjected.Address(Slot = "36")]
		get;
		[Cpp2IlInjected.Token(Token = "0x60001B4")]
		[Cpp2IlInjected.Address(Slot = "37")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x1700007B")]
	Vector3 JLIOGCPKLOL
	{
		[Cpp2IlInjected.Token(Token = "0x60001B5")]
		[Cpp2IlInjected.Address(Slot = "38")]
		get;
		[Cpp2IlInjected.Token(Token = "0x60001B6")]
		[Cpp2IlInjected.Address(Slot = "39")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x1700007C")]
	Quaternion OCGLMIOIKKA
	{
		[Cpp2IlInjected.Token(Token = "0x60001B7")]
		[Cpp2IlInjected.Address(Slot = "40")]
		get;
		[Cpp2IlInjected.Token(Token = "0x60001B8")]
		[Cpp2IlInjected.Address(Slot = "41")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x1700007D")]
	float PGABAKFPNBB
	{
		[Cpp2IlInjected.Token(Token = "0x60001B9")]
		[Cpp2IlInjected.Address(Slot = "42")]
		get;
		[Cpp2IlInjected.Token(Token = "0x60001BA")]
		[Cpp2IlInjected.Address(Slot = "43")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x1700007E")]
	float DCNFDLOMNCM
	{
		[Cpp2IlInjected.Token(Token = "0x60001BB")]
		[Cpp2IlInjected.Address(Slot = "44")]
		get;
		[Cpp2IlInjected.Token(Token = "0x60001BC")]
		[Cpp2IlInjected.Address(Slot = "45")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x1700007F")]
	bool OGIIANAEIFL
	{
		[Cpp2IlInjected.Token(Token = "0x60001BD")]
		[Cpp2IlInjected.Address(Slot = "46")]
		get;
		[Cpp2IlInjected.Token(Token = "0x60001BE")]
		[Cpp2IlInjected.Address(Slot = "47")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000080")]
	GGPABLKNBJB LEKOFMMMFBB
	{
		[Cpp2IlInjected.Token(Token = "0x60001BF")]
		[Cpp2IlInjected.Address(Slot = "48")]
		get;
		[Cpp2IlInjected.Token(Token = "0x60001C0")]
		[Cpp2IlInjected.Address(Slot = "49")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000081")]
	bool FAJNDFDCOGA
	{
		[Cpp2IlInjected.Token(Token = "0x60001C1")]
		[Cpp2IlInjected.Address(Slot = "50")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000082")]
	Transform KMDNPAAIEIK
	{
		[Cpp2IlInjected.Token(Token = "0x60001C2")]
		[Cpp2IlInjected.Address(Slot = "51")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000083")]
	Transform FNPJMEGGLFM
	{
		[Cpp2IlInjected.Token(Token = "0x60001C3")]
		[Cpp2IlInjected.Address(Slot = "52")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000084")]
	Vector3 BLGJDGKFELJ
	{
		[Cpp2IlInjected.Token(Token = "0x60001C4")]
		[Cpp2IlInjected.Address(Slot = "53")]
		get;
		[Cpp2IlInjected.Token(Token = "0x60001C5")]
		[Cpp2IlInjected.Address(Slot = "54")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000085")]
	float CLIPDFNDOOC
	{
		[Cpp2IlInjected.Token(Token = "0x60001C6")]
		[Cpp2IlInjected.Address(Slot = "55")]
		get;
		[Cpp2IlInjected.Token(Token = "0x60001C7")]
		[Cpp2IlInjected.Address(Slot = "56")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000086")]
	float JHDBNDJGACG
	{
		[Cpp2IlInjected.Token(Token = "0x60001C8")]
		[Cpp2IlInjected.Address(Slot = "57")]
		get;
		[Cpp2IlInjected.Token(Token = "0x60001C9")]
		[Cpp2IlInjected.Address(Slot = "58")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000087")]
	Quaternion INFAOAKNLJC
	{
		[Cpp2IlInjected.Token(Token = "0x60001CA")]
		[Cpp2IlInjected.Address(Slot = "59")]
		get;
		[Cpp2IlInjected.Token(Token = "0x60001CB")]
		[Cpp2IlInjected.Address(Slot = "60")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000088")]
	Vector3 NAILLMLOGGK
	{
		[Cpp2IlInjected.Token(Token = "0x60001CC")]
		[Cpp2IlInjected.Address(Slot = "61")]
		get;
		[Cpp2IlInjected.Token(Token = "0x60001CD")]
		[Cpp2IlInjected.Address(Slot = "62")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000089")]
	Quaternion FBMHBHAGGPI
	{
		[Cpp2IlInjected.Token(Token = "0x60001CE")]
		[Cpp2IlInjected.Address(Slot = "63")]
		get;
		[Cpp2IlInjected.Token(Token = "0x60001CF")]
		[Cpp2IlInjected.Address(Slot = "64")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x1700008A")]
	RigidbodyConstraints AOEOJAJAPKL
	{
		[Cpp2IlInjected.Token(Token = "0x60001D0")]
		[Cpp2IlInjected.Address(Slot = "65")]
		get;
		[Cpp2IlInjected.Token(Token = "0x60001D1")]
		[Cpp2IlInjected.Address(Slot = "66")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x1700008B")]
	bool KHDKIPLIJCN
	{
		[Cpp2IlInjected.Token(Token = "0x60001D2")]
		[Cpp2IlInjected.Address(Slot = "67")]
		get;
		[Cpp2IlInjected.Token(Token = "0x60001D3")]
		[Cpp2IlInjected.Address(Slot = "68")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x1700008C")]
	CollisionDetectionMode PAOOKBBFCLK
	{
		[Cpp2IlInjected.Token(Token = "0x60001D4")]
		[Cpp2IlInjected.Address(Slot = "69")]
		get;
		[Cpp2IlInjected.Token(Token = "0x60001D5")]
		[Cpp2IlInjected.Address(Slot = "70")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x1700008D")]
	bool LFGDELENJCM
	{
		[Cpp2IlInjected.Token(Token = "0x60001D6")]
		[Cpp2IlInjected.Address(Slot = "71")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x14000018")]
	event DGAAFHCPHEH NJJHHELIHIP;

	[Cpp2IlInjected.Token(Token = "0x14000019")]
	event DGAAFHCPHEH EPBNCIPAFDB;

	[Cpp2IlInjected.Token(Token = "0x1400001A")]
	event MKKJLKCGEAC EIBHEHIGCNB;

	[Cpp2IlInjected.Token(Token = "0x1400001B")]
	event DGAAFHCPHEH DELNFHCFIKO;

	[Cpp2IlInjected.Token(Token = "0x1400001C")]
	event DGAAFHCPHEH DHIFCNEILML;

	[Cpp2IlInjected.Token(Token = "0x1400001D")]
	event DGAAFHCPHEH BGFDOMIHHPL;

	[Cpp2IlInjected.Token(Token = "0x1400001E")]
	event Action<FCDCKNBKJML, FCDCKNBKJML> DLLBDKMMJIP;

	[Cpp2IlInjected.Token(Token = "0x1400001F")]
	event DGAAFHCPHEH FCJJAJLCBGC;

	[Cpp2IlInjected.Token(Token = "0x14000020")]
	event DGAAFHCPHEH MGPMCLDJCJA;

	[Cpp2IlInjected.Token(Token = "0x60001D7")]
	[Cpp2IlInjected.Address(Slot = "72")]
	void PBJONABJOBO();

	[Cpp2IlInjected.Token(Token = "0x60001D8")]
	[Cpp2IlInjected.Address(Slot = "73")]
	void AOLBABCADFF();

	[Cpp2IlInjected.Token(Token = "0x60001D9")]
	[Cpp2IlInjected.Address(Slot = "74")]
	void NKMAPFPPLGO();

	[Cpp2IlInjected.Token(Token = "0x60001DA")]
	[Cpp2IlInjected.Address(Slot = "75")]
	void PKFLOCAHJCK();

	[Cpp2IlInjected.Token(Token = "0x60001DB")]
	[Cpp2IlInjected.Address(Slot = "76")]
	void MCKPAKFDOPH();

	[Cpp2IlInjected.Token(Token = "0x60001E2")]
	[Cpp2IlInjected.Address(Slot = "83")]
	void DEIBNNOCJKC(NCOEFPHLCKK LPJDDLMPNCG, bool OMIKAFGHIFK = false);

	[Cpp2IlInjected.Token(Token = "0x60001E5")]
	[Cpp2IlInjected.Address(Slot = "86")]
	void KMKIMCBMAFA(object MIFCLBEAOPM);

	[Cpp2IlInjected.Token(Token = "0x60001E6")]
	[Cpp2IlInjected.Address(Slot = "87")]
	void JCGBFLMHKCG(object MIFCLBEAOPM);

	[Cpp2IlInjected.Token(Token = "0x60001E7")]
	[Cpp2IlInjected.Address(Slot = "88")]
	Vector3 AFFCJBHNNJL(Vector3 JOJEMOKKGPP);

	[Cpp2IlInjected.Token(Token = "0x60001E8")]
	[Cpp2IlInjected.Address(Slot = "89")]
	Vector3 KIKKEDPKAKK(Vector3 HMPFDEAFPND);

	[Cpp2IlInjected.Token(Token = "0x60001E9")]
	[Cpp2IlInjected.Address(Slot = "90")]
	void INLPOAEPJGG();

	[Cpp2IlInjected.Token(Token = "0x60001EA")]
	[Cpp2IlInjected.Address(Slot = "91")]
	void BHDNAPGFIPJ();

	[Cpp2IlInjected.Token(Token = "0x60001EB")]
	[Cpp2IlInjected.Address(Slot = "92")]
	void IFMLGPGPJDO();

	[Cpp2IlInjected.Token(Token = "0x60001EC")]
	[Cpp2IlInjected.Address(Slot = "93")]
	void NGFKLMPAGOE(Vector3 GKKEEHNMPBL, Vector3 NFGPCLPNMJK);

	[Cpp2IlInjected.Token(Token = "0x60001ED")]
	[Cpp2IlInjected.Address(Slot = "94")]
	void JLDEEBLCKGA(Vector3 FHKLDEIKECB, Vector3 FHFHNDANMPN);

	[Cpp2IlInjected.Token(Token = "0x60001EE")]
	[Cpp2IlInjected.Address(Slot = "95")]
	void KIIDBBLBANB(Vector3 JDDALKKDLNA);

	[Cpp2IlInjected.Token(Token = "0x60001EF")]
	[Cpp2IlInjected.Address(Slot = "96")]
	void HHAFJJGJPFB(EECECFKKEJP KMDODPJBKLE, Vector3 CFLMAEMNHKL, float ABGPHLFIFAO, float OPCFMELHIKJ = 8f, float ECOHALOPPDN = 1f);

	[Cpp2IlInjected.Token(Token = "0x60001F0")]
	[Cpp2IlInjected.Address(Slot = "97")]
	void HHLJBCNAEPM(JDHBHPOMECG EFAKAOJPAJJ, Vector3 PKAJMBKNJIL, float KBLOKDLNEPD = float.PositiveInfinity);

	[Cpp2IlInjected.Token(Token = "0x60001F1")]
	[Cpp2IlInjected.Address(Slot = "98")]
	void IALNLOAFGMK(JDHBHPOMECG EFAKAOJPAJJ, Vector3 IHCJBCJFELL, float MEJPNNANPLH = 7f, float CKIIILKMBKK = 1f);

	[Cpp2IlInjected.Token(Token = "0x60001F2")]
	[Cpp2IlInjected.Address(Slot = "99")]
	Vector3 DNICIBAAMCG(Vector3 LPJDDLMPNCG);

	[Cpp2IlInjected.Token(Token = "0x60001F3")]
	[Cpp2IlInjected.Address(Slot = "100")]
	Vector3 GJAHBCCOAII(Vector3 LPJDDLMPNCG);

	[Cpp2IlInjected.Token(Token = "0x60001F4")]
	[Cpp2IlInjected.Address(Slot = "101")]
	void EPOKPKAANHO();

	[Cpp2IlInjected.Token(Token = "0x60001F5")]
	[Cpp2IlInjected.Address(Slot = "102")]
	void OIHMDCKKBFA(NCOEFPHLCKK BKGBHBNCDJA, object MIFCLBEAOPM);

	[Cpp2IlInjected.Token(Token = "0x60001F6")]
	[Cpp2IlInjected.Address(Slot = "103")]
	void ELAHEJFDAHO(object MIFCLBEAOPM);

	[Cpp2IlInjected.Token(Token = "0x60001F9")]
	[Cpp2IlInjected.Address(Slot = "106")]
	void FCDPOIHJAAG();

	[Cpp2IlInjected.Token(Token = "0x60001FA")]
	[Cpp2IlInjected.Address(Slot = "107")]
	void AEAABDHDFFI();

	[Cpp2IlInjected.Token(Token = "0x60001FB")]
	[Cpp2IlInjected.Address(Slot = "108")]
	void IEIECPGHPLP();

	[Cpp2IlInjected.Token(Token = "0x60001FE")]
	[Cpp2IlInjected.Address(Slot = "111")]
	bool NEPEFPHIELC();

	[Cpp2IlInjected.Token(Token = "0x60001FF")]
	[Cpp2IlInjected.Address(Slot = "112")]
	void PFPLFILECPI();

	[Cpp2IlInjected.Token(Token = "0x6000204")]
	[Cpp2IlInjected.Address(Slot = "117")]
	IDisposable EBMGEFKJGJE();

	[Cpp2IlInjected.Token(Token = "0x6000205")]
	[Cpp2IlInjected.Address(Slot = "118")]
	void LDMPNKDCNKH(object MIFCLBEAOPM);

	[Cpp2IlInjected.Token(Token = "0x6000206")]
	[Cpp2IlInjected.Address(Slot = "119")]
	void FGAHJAEMBHA(object MIFCLBEAOPM);

	[Cpp2IlInjected.Token(Token = "0x6000207")]
	[Cpp2IlInjected.Address(Slot = "120")]
	void PNGKMLMJNAK(object MIFCLBEAOPM, bool KLMBPMINIHN);

	[Cpp2IlInjected.Token(Token = "0x600020A")]
	[Cpp2IlInjected.Address(Slot = "123")]
	void LOKMBIPHOGK(Vector3 PGJOODJOMAI, Quaternion OMJBPOHHBNI);

	[Cpp2IlInjected.Token(Token = "0x600020B")]
	[Cpp2IlInjected.Address(Slot = "124")]
	void OFCCCKGCAPP(Vector3 PPNOLBKPBJH, Quaternion KAHANPFONLJ);

	[Cpp2IlInjected.Token(Token = "0x600020C")]
	[Cpp2IlInjected.Address(Slot = "125")]
	bool AMLDEGGHKAD(float ANPGDIDDDCB);

	[Cpp2IlInjected.Token(Token = "0x600020D")]
	[Cpp2IlInjected.Address(Slot = "126")]
	void HMHFMGOKMHP(object MIFCLBEAOPM);

	[Cpp2IlInjected.Token(Token = "0x600020E")]
	[Cpp2IlInjected.Address(Slot = "127")]
	void KNMLFLHNFDJ(object MIFCLBEAOPM);

	[Cpp2IlInjected.Token(Token = "0x600020F")]
	[Cpp2IlInjected.Address(Slot = "128")]
	void KPOLANLNJJI(object MIFCLBEAOPM);

	[Cpp2IlInjected.Token(Token = "0x6000210")]
	[Cpp2IlInjected.Address(Slot = "129")]
	void HIBCGDMOODJ(object MIFCLBEAOPM);

	[Cpp2IlInjected.Token(Token = "0x6000211")]
	[Cpp2IlInjected.Address(Slot = "130")]
	void BEJNHGKJNLM(Vector3 HKPPDHFDHMN, ForceMode MPMGBCACKOF = ForceMode.Force);

	[Cpp2IlInjected.Token(Token = "0x6000212")]
	[Cpp2IlInjected.Address(Slot = "131")]
	void CBMEMNKKLDE(Vector3 HKPPDHFDHMN, Vector3 PICDPPHNNLH, ForceMode MPMGBCACKOF);

	[Cpp2IlInjected.Token(Token = "0x6000213")]
	[Cpp2IlInjected.Address(Slot = "132")]
	void OHNHDPGFLAC(Vector3 MBBMKANKKGB, ForceMode MPMGBCACKOF = ForceMode.Force);

	[Cpp2IlInjected.Token(Token = "0x6000214")]
	[Cpp2IlInjected.Address(Slot = "133")]
	void PPDGHDJCFAP(Vector3 MBBMKANKKGB, ForceMode MPMGBCACKOF = ForceMode.Force);

	[Cpp2IlInjected.Token(Token = "0x6000215")]
	[Cpp2IlInjected.Address(Slot = "134")]
	bool OFDKFHJBLOJ(Vector3 MFKKMPGAJFI, out RaycastHit ONOMCDOFLKH, float CBFODBDKBEK);

	[Cpp2IlInjected.Token(Token = "0x6000216")]
	[Cpp2IlInjected.Address(Slot = "135")]
	void AMJHKJLPLNB();

	[Cpp2IlInjected.Token(Token = "0x6000217")]
	[Cpp2IlInjected.Address(Slot = "136")]
	new string ToString();
}
[Cpp2IlInjected.Token(Token = "0x2000029")]
public class PLOEBEDJGLE : NCOEFPHLCKK, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000031")]
	internal readonly BKDMDHLJAEJ CMIHNHHBGOO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000032")]
	internal PLDJMDIFCKE BKOBOKBHBIK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000033")]
	internal LBPABMNHAKF BJPFGGIMOHN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000034")]
	internal INNKCACPKLA LCMHIEKJLJH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000035")]
	internal ODMDEDICELM GCAABCBBBAL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000036")]
	internal IMBEMHENMNJ NBMNJAEIEGM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000037")]
	internal OGBLFJOOHEI DDHOGLKMBGF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000038")]
	internal CAONNBLCKEG ODLGAEJDKLL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000039")]
	internal BBGAPPNBFLO PGCKHKHCPEK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x400003A")]
	internal EIMJIHNCMHI INAPIHIPHNN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x400003B")]
	internal JBCOLILENLD HCIMMAHILLK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x400003C")]
	internal KGDABPANOEG KOEGAAAEINF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x400003D")]
	internal BDJOPHNNEJG HKPPDHFDHMN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
	[Cpp2IlInjected.Token(Token = "0x400003E")]
	internal IKFALNBDADN LHIILEMPCMH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x400003F")]
	internal IPANMLAMAAD GHAGIOLHPMN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
	[Cpp2IlInjected.Token(Token = "0x4000040")]
	internal AIOOGANOGPH COPBAHMMIPO;

	[Cpp2IlInjected.Token(Token = "0x1700008E")]
	public RigidbodyEx OEOEKIBFEMO
	{
		[Cpp2IlInjected.Token(Token = "0x6000218")]
		[Cpp2IlInjected.Address(RVA = "0x765AF0", Offset = "0x764EF0", VA = "0x180765AF0", Slot = "5")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000219")]
		[Cpp2IlInjected.Address(RVA = "0x84FDF0", Offset = "0x84F1F0", VA = "0x18084FDF0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700008F")]
	public GameObject MILHHPLGFOL
	{
		[Cpp2IlInjected.Token(Token = "0x600021A")]
		[Cpp2IlInjected.Address(RVA = "0x803640", Offset = "0x802A40", VA = "0x180803640", Slot = "6")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600021B")]
		[Cpp2IlInjected.Address(RVA = "0x8C8250", Offset = "0x8C7650", VA = "0x1808C8250")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000090")]
	public Transform LHEBMCHBDEI
	{
		[Cpp2IlInjected.Token(Token = "0x600021C")]
		[Cpp2IlInjected.Address(RVA = "0x57CD7B0", Offset = "0x57CCBB0", VA = "0x1857CD7B0", Slot = "7")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000091")]
	public IEnumerable<object> IMECMIODOMG
	{
		[Cpp2IlInjected.Token(Token = "0x600021D")]
		[Cpp2IlInjected.Address(RVA = "0x57CBA50", Offset = "0x57CAE50", VA = "0x1857CBA50", Slot = "8")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000092")]
	public Rigidbody LNMDHFKNJIH
	{
		[Cpp2IlInjected.Token(Token = "0x600021E")]
		[Cpp2IlInjected.Address(RVA = "0x57CD930", Offset = "0x57CCD30", VA = "0x1857CD930", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000093")]
	public NCOEFPHLCKK GKEMABFNEME
	{
		[Cpp2IlInjected.Token(Token = "0x600022C")]
		[Cpp2IlInjected.Address(RVA = "0x57D0230", Offset = "0x57CF630", VA = "0x1857D0230", Slot = "9")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600022D")]
		[Cpp2IlInjected.Address(RVA = "0x57CB710", Offset = "0x57CAB10", VA = "0x1857CB710", Slot = "10")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000094")]
	public IReadOnlyList<NCOEFPHLCKK> PHPDFDJEEEA
	{
		[Cpp2IlInjected.Token(Token = "0x600022E")]
		[Cpp2IlInjected.Address(RVA = "0x57CD9D0", Offset = "0x57CCDD0", VA = "0x1857CD9D0", Slot = "11")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000095")]
	public NCOEFPHLCKK CMJKBCMDGHN
	{
		[Cpp2IlInjected.Token(Token = "0x600022F")]
		[Cpp2IlInjected.Address(RVA = "0x57CC750", Offset = "0x57CBB50", VA = "0x1857CC750", Slot = "12")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000096")]
	public bool KMDIPAOGGGF
	{
		[Cpp2IlInjected.Token(Token = "0x6000230")]
		[Cpp2IlInjected.Address(RVA = "0x57CFF10", Offset = "0x57CF310", VA = "0x1857CFF10", Slot = "13")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000097")]
	public bool BBHAHOHMEPG
	{
		[Cpp2IlInjected.Token(Token = "0x6000234")]
		[Cpp2IlInjected.Address(RVA = "0x57CC610", Offset = "0x57CBA10", VA = "0x1857CC610", Slot = "14")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000098")]
	public bool MPDIPBBGKKB
	{
		[Cpp2IlInjected.Token(Token = "0x6000235")]
		[Cpp2IlInjected.Address(RVA = "0x57CD980", Offset = "0x57CCD80", VA = "0x1857CD980", Slot = "15")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000099")]
	public EKLLOLLHLDP LNMCPLFHCHG
	{
		[Cpp2IlInjected.Token(Token = "0x6000236")]
		[Cpp2IlInjected.Address(RVA = "0x57D14A0", Offset = "0x57D08A0", VA = "0x1857D14A0", Slot = "16")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000237")]
		[Cpp2IlInjected.Address(RVA = "0x57CC200", Offset = "0x57CB600", VA = "0x1857CC200", Slot = "17")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700009A")]
	public CHACNCJIDJM GJHPEGFOAME
	{
		[Cpp2IlInjected.Token(Token = "0x6000238")]
		[Cpp2IlInjected.Address(RVA = "0x57CBF70", Offset = "0x57CB370", VA = "0x1857CBF70", Slot = "18")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000239")]
		[Cpp2IlInjected.Address(RVA = "0x57CDFF0", Offset = "0x57CD3F0", VA = "0x1857CDFF0", Slot = "19")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700009B")]
	public float KKALKPOINCB
	{
		[Cpp2IlInjected.Token(Token = "0x600023A")]
		[Cpp2IlInjected.Address(RVA = "0x57CC700", Offset = "0x57CBB00", VA = "0x1857CC700", Slot = "20")]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x600023B")]
		[Cpp2IlInjected.Address(RVA = "0x57CCA90", Offset = "0x57CBE90", VA = "0x1857CCA90", Slot = "21")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700009C")]
	public Vector3 JBHIDAJMGMM
	{
		[Cpp2IlInjected.Token(Token = "0x600023C")]
		[Cpp2IlInjected.Address(RVA = "0x57CE3B0", Offset = "0x57CD7B0", VA = "0x1857CE3B0", Slot = "22")]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x600023D")]
		[Cpp2IlInjected.Address(RVA = "0x57CD040", Offset = "0x57CC440", VA = "0x1857CD040", Slot = "23")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700009D")]
	public Vector3 ICEKJCBHJBH
	{
		[Cpp2IlInjected.Token(Token = "0x600023E")]
		[Cpp2IlInjected.Address(RVA = "0x57CE920", Offset = "0x57CDD20", VA = "0x1857CE920", Slot = "24")]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x600023F")]
		[Cpp2IlInjected.Address(RVA = "0x57CE850", Offset = "0x57CDC50", VA = "0x1857CE850", Slot = "25")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700009E")]
	public Vector3 LGEGEJPPDAD
	{
		[Cpp2IlInjected.Token(Token = "0x6000240")]
		[Cpp2IlInjected.Address(RVA = "0x57CB980", Offset = "0x57CAD80", VA = "0x1857CB980", Slot = "26")]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x6000241")]
		[Cpp2IlInjected.Address(RVA = "0x57CC440", Offset = "0x57CB840", VA = "0x1857CC440", Slot = "27")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700009F")]
	public Vector3 LJMFIEJCGLD
	{
		[Cpp2IlInjected.Token(Token = "0x6000242")]
		[Cpp2IlInjected.Address(RVA = "0x57CC370", Offset = "0x57CB770", VA = "0x1857CC370", Slot = "28")]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x6000243")]
		[Cpp2IlInjected.Address(RVA = "0x57CBCB0", Offset = "0x57CB0B0", VA = "0x1857CBCB0", Slot = "29")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A0")]
	public bool NHCAAMEDKKB
	{
		[Cpp2IlInjected.Token(Token = "0x6000244")]
		[Cpp2IlInjected.Address(RVA = "0x57CC660", Offset = "0x57CBA60", VA = "0x1857CC660", Slot = "30")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A1")]
	public bool GDCCIECOAEF
	{
		[Cpp2IlInjected.Token(Token = "0x6000245")]
		[Cpp2IlInjected.Address(RVA = "0x57CC510", Offset = "0x57CB910", VA = "0x1857CC510", Slot = "31")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A2")]
	public bool ABAINBEINAC
	{
		[Cpp2IlInjected.Token(Token = "0x6000246")]
		[Cpp2IlInjected.Address(RVA = "0x57CDE40", Offset = "0x57CD240", VA = "0x1857CDE40", Slot = "32")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A3")]
	public bool LIGEJEKODFL
	{
		[Cpp2IlInjected.Token(Token = "0x6000247")]
		[Cpp2IlInjected.Address(RVA = "0x57CE7A0", Offset = "0x57CDBA0", VA = "0x1857CE7A0", Slot = "33")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A4")]
	public Vector3 BFENAJAEKJN
	{
		[Cpp2IlInjected.Token(Token = "0x6000258")]
		[Cpp2IlInjected.Address(RVA = "0x57D00C0", Offset = "0x57CF4C0", VA = "0x1857D00C0", Slot = "34")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A5")]
	public Vector3 LECHPMMLACE
	{
		[Cpp2IlInjected.Token(Token = "0x6000259")]
		[Cpp2IlInjected.Address(RVA = "0x57CDF20", Offset = "0x57CD320", VA = "0x1857CDF20", Slot = "35")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A6")]
	public Vector3 BMNHHGGIMHD
	{
		[Cpp2IlInjected.Token(Token = "0x600025E")]
		[Cpp2IlInjected.Address(RVA = "0x57CBBE0", Offset = "0x57CAFE0", VA = "0x1857CBBE0", Slot = "36")]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x600025F")]
		[Cpp2IlInjected.Address(RVA = "0x57CC0D0", Offset = "0x57CB4D0", VA = "0x1857CC0D0", Slot = "37")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A7")]
	public Vector3 ICDJEGJHDEE
	{
		[Cpp2IlInjected.Token(Token = "0x6000260")]
		[Cpp2IlInjected.Address(RVA = "0x57CE0B0", Offset = "0x57CD4B0", VA = "0x1857CE0B0", Slot = "38")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A8")]
	public float AHNCJOKPCCM
	{
		[Cpp2IlInjected.Token(Token = "0x6000261")]
		[Cpp2IlInjected.Address(RVA = "0x57CD110", Offset = "0x57CC510", VA = "0x1857CD110", Slot = "39")]
		get
		{
			return default(float);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A9")]
	public float JAHICELIBID
	{
		[Cpp2IlInjected.Token(Token = "0x6000262")]
		[Cpp2IlInjected.Address(RVA = "0x57CC6B0", Offset = "0x57CBAB0", VA = "0x1857CC6B0", Slot = "40")]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x6000263")]
		[Cpp2IlInjected.Address(RVA = "0x57D15B0", Offset = "0x57D09B0", VA = "0x1857D15B0", Slot = "41")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000AA")]
	public Vector3 JLIOGCPKLOL
	{
		[Cpp2IlInjected.Token(Token = "0x6000264")]
		[Cpp2IlInjected.Address(RVA = "0x57CB770", Offset = "0x57CAB70", VA = "0x1857CB770", Slot = "42")]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x6000265")]
		[Cpp2IlInjected.Address(RVA = "0x57CE480", Offset = "0x57CD880", VA = "0x1857CE480", Slot = "43")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000AB")]
	public Quaternion OCGLMIOIKKA
	{
		[Cpp2IlInjected.Token(Token = "0x6000266")]
		[Cpp2IlInjected.Address(RVA = "0x57CD160", Offset = "0x57CC560", VA = "0x1857CD160", Slot = "44")]
		get
		{
			return default(Quaternion);
		}
		[Cpp2IlInjected.Token(Token = "0x6000267")]
		[Cpp2IlInjected.Address(RVA = "0x57D0E50", Offset = "0x57D0250", VA = "0x1857D0E50", Slot = "45")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000AC")]
	public float PGABAKFPNBB
	{
		[Cpp2IlInjected.Token(Token = "0x600026B")]
		[Cpp2IlInjected.Address(RVA = "0x57D0020", Offset = "0x57CF420", VA = "0x1857D0020", Slot = "46")]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x600026C")]
		[Cpp2IlInjected.Address(RVA = "0x57CE180", Offset = "0x57CD580", VA = "0x1857CE180", Slot = "47")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000AD")]
	public float DCNFDLOMNCM
	{
		[Cpp2IlInjected.Token(Token = "0x600026D")]
		[Cpp2IlInjected.Address(RVA = "0x57D0F70", Offset = "0x57D0370", VA = "0x1857D0F70", Slot = "48")]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x600026E")]
		[Cpp2IlInjected.Address(RVA = "0x57CF990", Offset = "0x57CED90", VA = "0x1857CF990", Slot = "49")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000AE")]
	public bool OGIIANAEIFL
	{
		[Cpp2IlInjected.Token(Token = "0x600026F")]
		[Cpp2IlInjected.Address(RVA = "0x57D0190", Offset = "0x57CF590", VA = "0x1857D0190", Slot = "50")]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000270")]
		[Cpp2IlInjected.Address(RVA = "0x57CC810", Offset = "0x57CBC10", VA = "0x1857CC810", Slot = "51")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000AF")]
	public GGPABLKNBJB LEKOFMMMFBB
	{
		[Cpp2IlInjected.Token(Token = "0x6000278")]
		[Cpp2IlInjected.Address(RVA = "0x57CE650", Offset = "0x57CDA50", VA = "0x1857CE650", Slot = "52")]
		get
		{
			return default(GGPABLKNBJB);
		}
		[Cpp2IlInjected.Token(Token = "0x6000279")]
		[Cpp2IlInjected.Address(RVA = "0x57CCC60", Offset = "0x57CC060", VA = "0x1857CCC60", Slot = "53")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B0")]
	public bool FAJNDFDCOGA
	{
		[Cpp2IlInjected.Token(Token = "0x600027C")]
		[Cpp2IlInjected.Address(RVA = "0x57D0070", Offset = "0x57CF470", VA = "0x1857D0070", Slot = "54")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B1")]
	public Transform KMDNPAAIEIK
	{
		[Cpp2IlInjected.Token(Token = "0x6000283")]
		[Cpp2IlInjected.Address(RVA = "0x57CCD20", Offset = "0x57CC120", VA = "0x1857CCD20", Slot = "55")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B2")]
	public Transform FNPJMEGGLFM
	{
		[Cpp2IlInjected.Token(Token = "0x6000284")]
		[Cpp2IlInjected.Address(RVA = "0x57CCD20", Offset = "0x57CC120", VA = "0x1857CCD20", Slot = "56")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B3")]
	public Vector3 BLGJDGKFELJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000285")]
		[Cpp2IlInjected.Address(RVA = "0x57CD230", Offset = "0x57CC630", VA = "0x1857CD230", Slot = "57")]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x6000286")]
		[Cpp2IlInjected.Address(RVA = "0x57CD700", Offset = "0x57CCB00", VA = "0x1857CD700", Slot = "58")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B4")]
	public float CLIPDFNDOOC
	{
		[Cpp2IlInjected.Token(Token = "0x6000287")]
		[Cpp2IlInjected.Address(RVA = "0x57CC1A0", Offset = "0x57CB5A0", VA = "0x1857CC1A0", Slot = "59")]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x6000288")]
		[Cpp2IlInjected.Address(RVA = "0x57CDAC0", Offset = "0x57CCEC0", VA = "0x1857CDAC0", Slot = "60")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B5")]
	public float JHDBNDJGACG
	{
		[Cpp2IlInjected.Token(Token = "0x6000289")]
		[Cpp2IlInjected.Address(RVA = "0x57CC010", Offset = "0x57CB410", VA = "0x1857CC010", Slot = "61")]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x600028A")]
		[Cpp2IlInjected.Address(RVA = "0x57CEA50", Offset = "0x57CDE50", VA = "0x1857CEA50", Slot = "62")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B6")]
	public Quaternion INFAOAKNLJC
	{
		[Cpp2IlInjected.Token(Token = "0x600028B")]
		[Cpp2IlInjected.Address(RVA = "0x57CF8E0", Offset = "0x57CECE0", VA = "0x1857CF8E0", Slot = "63")]
		get
		{
			return default(Quaternion);
		}
		[Cpp2IlInjected.Token(Token = "0x600028C")]
		[Cpp2IlInjected.Address(RVA = "0x57D0C70", Offset = "0x57D0070", VA = "0x1857D0C70", Slot = "64")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B7")]
	public Vector3 NAILLMLOGGK
	{
		[Cpp2IlInjected.Token(Token = "0x600028D")]
		[Cpp2IlInjected.Address(RVA = "0x57CDA70", Offset = "0x57CCE70", VA = "0x1857CDA70", Slot = "65")]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x600028E")]
		[Cpp2IlInjected.Address(RVA = "0x57CFAA0", Offset = "0x57CEEA0", VA = "0x1857CFAA0", Slot = "66")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B8")]
	public Quaternion FBMHBHAGGPI
	{
		[Cpp2IlInjected.Token(Token = "0x600028F")]
		[Cpp2IlInjected.Address(RVA = "0x57CCDF0", Offset = "0x57CC1F0", VA = "0x1857CCDF0", Slot = "67")]
		get
		{
			return default(Quaternion);
		}
		[Cpp2IlInjected.Token(Token = "0x6000290")]
		[Cpp2IlInjected.Address(RVA = "0x57CCC20", Offset = "0x57CC020", VA = "0x1857CCC20", Slot = "68")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B9")]
	public RigidbodyConstraints AOEOJAJAPKL
	{
		[Cpp2IlInjected.Token(Token = "0x6000294")]
		[Cpp2IlInjected.Address(RVA = "0x57CDA20", Offset = "0x57CCE20", VA = "0x1857CDA20", Slot = "69")]
		get
		{
			return default(RigidbodyConstraints);
		}
		[Cpp2IlInjected.Token(Token = "0x6000295")]
		[Cpp2IlInjected.Address(RVA = "0x57D1690", Offset = "0x57D0A90", VA = "0x1857D1690", Slot = "70")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000BA")]
	public bool KHDKIPLIJCN
	{
		[Cpp2IlInjected.Token(Token = "0x6000296")]
		[Cpp2IlInjected.Address(RVA = "0x57D1560", Offset = "0x57D0960", VA = "0x1857D1560", Slot = "71")]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000297")]
		[Cpp2IlInjected.Address(RVA = "0x57CF360", Offset = "0x57CE760", VA = "0x1857CF360", Slot = "72")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000BB")]
	public CollisionDetectionMode PAOOKBBFCLK
	{
		[Cpp2IlInjected.Token(Token = "0x60002A0")]
		[Cpp2IlInjected.Address(RVA = "0x57D0F20", Offset = "0x57D0320", VA = "0x1857D0F20", Slot = "73")]
		get
		{
			return default(CollisionDetectionMode);
		}
		[Cpp2IlInjected.Token(Token = "0x60002A1")]
		[Cpp2IlInjected.Address(RVA = "0x57D0440", Offset = "0x57CF840", VA = "0x1857D0440", Slot = "74")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000BC")]
	public bool LFGDELENJCM
	{
		[Cpp2IlInjected.Token(Token = "0x60002A3")]
		[Cpp2IlInjected.Address(RVA = "0x57CFDD0", Offset = "0x57CF1D0", VA = "0x1857CFDD0", Slot = "75")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000021")]
	public event DGAAFHCPHEH NJJHHELIHIP
	{
		[Cpp2IlInjected.Token(Token = "0x6000226")]
		[Cpp2IlInjected.Address(RVA = "0x57CED50", Offset = "0x57CE150", VA = "0x1857CED50", Slot = "81")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000227")]
		[Cpp2IlInjected.Address(RVA = "0x57CF480", Offset = "0x57CE880", VA = "0x1857CF480", Slot = "82")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000022")]
	public event DGAAFHCPHEH EPBNCIPAFDB
	{
		[Cpp2IlInjected.Token(Token = "0x6000228")]
		[Cpp2IlInjected.Address(RVA = "0x57CE5A0", Offset = "0x57CD9A0", VA = "0x1857CE5A0", Slot = "83")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000229")]
		[Cpp2IlInjected.Address(RVA = "0x57CE1E0", Offset = "0x57CD5E0", VA = "0x1857CE1E0", Slot = "84")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000023")]
	public event MKKJLKCGEAC EIBHEHIGCNB
	{
		[Cpp2IlInjected.Token(Token = "0x600022A")]
		[Cpp2IlInjected.Address(RVA = "0x57CE240", Offset = "0x57CD640", VA = "0x1857CE240", Slot = "85")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600022B")]
		[Cpp2IlInjected.Address(RVA = "0x57CE9F0", Offset = "0x57CDDF0", VA = "0x1857CE9F0", Slot = "86")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000024")]
	public event DGAAFHCPHEH DELNFHCFIKO
	{
		[Cpp2IlInjected.Token(Token = "0x6000232")]
		[Cpp2IlInjected.Address(RVA = "0x57CE7F0", Offset = "0x57CDBF0", VA = "0x1857CE7F0", Slot = "88")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000233")]
		[Cpp2IlInjected.Address(RVA = "0x57CC070", Offset = "0x57CB470", VA = "0x1857CC070", Slot = "89")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000025")]
	public event DGAAFHCPHEH DHIFCNEILML
	{
		[Cpp2IlInjected.Token(Token = "0x600025C")]
		[Cpp2IlInjected.Address(RVA = "0x57CD6A0", Offset = "0x57CCAA0", VA = "0x1857CD6A0", Slot = "108")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600025D")]
		[Cpp2IlInjected.Address(RVA = "0x57CCF80", Offset = "0x57CC380", VA = "0x1857CCF80", Slot = "109")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000026")]
	public event DGAAFHCPHEH BGFDOMIHHPL
	{
		[Cpp2IlInjected.Token(Token = "0x6000271")]
		[Cpp2IlInjected.Address(RVA = "0x57D04C0", Offset = "0x57CF8C0", VA = "0x1857D04C0", Slot = "113")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000272")]
		[Cpp2IlInjected.Address(RVA = "0x57CC960", Offset = "0x57CBD60", VA = "0x1857CC960", Slot = "114")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000027")]
	public event Action<FCDCKNBKJML, FCDCKNBKJML> DLLBDKMMJIP
	{
		[Cpp2IlInjected.Token(Token = "0x6000276")]
		[Cpp2IlInjected.Address(RVA = "0x57CBD80", Offset = "0x57CB180", VA = "0x1857CBD80", Slot = "117")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000277")]
		[Cpp2IlInjected.Address(RVA = "0x57D0FC0", Offset = "0x57D03C0", VA = "0x1857D0FC0", Slot = "118")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000028")]
	public event DGAAFHCPHEH FCJJAJLCBGC
	{
		[Cpp2IlInjected.Token(Token = "0x600027A")]
		[Cpp2IlInjected.Address(RVA = "0x57D0B10", Offset = "0x57CFF10", VA = "0x1857D0B10", Slot = "119")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600027B")]
		[Cpp2IlInjected.Address(RVA = "0x57CCD90", Offset = "0x57CC190", VA = "0x1857CCD90", Slot = "120")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000029")]
	public event DGAAFHCPHEH MGPMCLDJCJA
	{
		[Cpp2IlInjected.Token(Token = "0x6000281")]
		[Cpp2IlInjected.Address(RVA = "0x57D08C0", Offset = "0x57CFCC0", VA = "0x1857D08C0", Slot = "125")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000282")]
		[Cpp2IlInjected.Address(RVA = "0x57CC570", Offset = "0x57CB970", VA = "0x1857CC570", Slot = "126")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600021F")]
	[Cpp2IlInjected.Address(RVA = "0x57D1730", Offset = "0x57D0B30", VA = "0x1857D1730")]
	public PLOEBEDJGLE(GameObject DLNMCGFEPOP, RigidbodyEx MCLIFNMABNA, BKDMDHLJAEJ CMIHNHHBGOO, in JCAJMGPJNDN HIDEHJGLNHO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000220")]
	[Cpp2IlInjected.Address(RVA = "0x57CD2E0", Offset = "0x57CC6E0", VA = "0x1857CD2E0", Slot = "142")]
	protected virtual void FOIMKAENAPH(BKDMDHLJAEJ CMIHNHHBGOO, JCAJMGPJNDN HIDEHJGLNHO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000221")]
	[Cpp2IlInjected.Address(RVA = "0x57CC9C0", Offset = "0x57CBDC0", VA = "0x1857CC9C0", Slot = "143")]
	public virtual void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000222")]
	[Cpp2IlInjected.Address(RVA = "0x57D1020", Offset = "0x57D0420", VA = "0x1857D1020", Slot = "76")]
	public void PBJONABJOBO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000223")]
	[Cpp2IlInjected.Address(RVA = "0x57CBB90", Offset = "0x57CAF90", VA = "0x1857CBB90", Slot = "77")]
	public void AOLBABCADFF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000224")]
	[Cpp2IlInjected.Address(RVA = "0x57D04A0", Offset = "0x57CF8A0", VA = "0x1857D04A0", Slot = "78")]
	public void NKMAPFPPLGO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000225")]
	[Cpp2IlInjected.Address(RVA = "0x57CF9F0", Offset = "0x57CEDF0", VA = "0x1857CF9F0", Slot = "144")]
	public virtual void MCKPAKFDOPH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000231")]
	[Cpp2IlInjected.Address(RVA = "0x57CC7A0", Offset = "0x57CBBA0", VA = "0x1857CC7A0", Slot = "87")]
	public void DEIBNNOCJKC(NCOEFPHLCKK LPJDDLMPNCG, bool OMIKAFGHIFK = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000248")]
	[Cpp2IlInjected.Address(RVA = "0x57CF2A0", Offset = "0x57CE6A0", VA = "0x1857CF2A0", Slot = "90")]
	public void KMKIMCBMAFA(object MIFCLBEAOPM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000249")]
	[Cpp2IlInjected.Address(RVA = "0x57CEC00", Offset = "0x57CE000", VA = "0x1857CEC00", Slot = "91")]
	public void JCGBFLMHKCG(object MIFCLBEAOPM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600024A")]
	[Cpp2IlInjected.Address(RVA = "0x57CB890", Offset = "0x57CAC90", VA = "0x1857CB890", Slot = "92")]
	public Vector3 AFFCJBHNNJL(Vector3 JOJEMOKKGPP)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x600024B")]
	[Cpp2IlInjected.Address(RVA = "0x57CEE80", Offset = "0x57CE280", VA = "0x1857CEE80", Slot = "93")]
	public Vector3 KIKKEDPKAKK(Vector3 HMPFDEAFPND)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x600024C")]
	[Cpp2IlInjected.Address(RVA = "0x57CBB90", Offset = "0x57CAF90", VA = "0x1857CBB90", Slot = "94")]
	public void INLPOAEPJGG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600024D")]
	[Cpp2IlInjected.Address(RVA = "0x57CBFC0", Offset = "0x57CB3C0", VA = "0x1857CBFC0", Slot = "95")]
	public void BHDNAPGFIPJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600024E")]
	[Cpp2IlInjected.Address(RVA = "0x57CE600", Offset = "0x57CDA00", VA = "0x1857CE600", Slot = "96")]
	public void IFMLGPGPJDO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600024F")]
	[Cpp2IlInjected.Address(RVA = "0x57D0280", Offset = "0x57CF680", VA = "0x1857D0280", Slot = "97")]
	public void NGFKLMPAGOE(Vector3 GKKEEHNMPBL, Vector3 NFGPCLPNMJK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000250")]
	[Cpp2IlInjected.Address(RVA = "0x57CEC60", Offset = "0x57CE060", VA = "0x1857CEC60", Slot = "98")]
	public void JLDEEBLCKGA(Vector3 FHKLDEIKECB, Vector3 FHFHNDANMPN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000251")]
	[Cpp2IlInjected.Address(RVA = "0x57CEDB0", Offset = "0x57CE1B0", VA = "0x1857CEDB0", Slot = "99")]
	public void KIIDBBLBANB(Vector3 JDDALKKDLNA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000252")]
	[Cpp2IlInjected.Address(RVA = "0x57CDBC0", Offset = "0x57CCFC0", VA = "0x1857CDBC0", Slot = "100")]
	public void HHAFJJGJPFB(EECECFKKEJP KMDODPJBKLE, Vector3 CFLMAEMNHKL, float ABGPHLFIFAO, float OPCFMELHIKJ = 8f, float ECOHALOPPDN = 1f)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000253")]
	[Cpp2IlInjected.Address(RVA = "0x57CDCE0", Offset = "0x57CD0E0", VA = "0x1857CDCE0", Slot = "101")]
	public void HHLJBCNAEPM(JDHBHPOMECG EFAKAOJPAJJ, Vector3 PKAJMBKNJIL, float KBLOKDLNEPD = float.PositiveInfinity)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000254")]
	[Cpp2IlInjected.Address(RVA = "0x57CE2A0", Offset = "0x57CD6A0", VA = "0x1857CE2A0", Slot = "102")]
	[Obsolete]
	public void IALNLOAFGMK(JDHBHPOMECG EFAKAOJPAJJ, Vector3 IHCJBCJFELL, float MEJPNNANPLH = 7f, float CKIIILKMBKK = 1f)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000255")]
	[Cpp2IlInjected.Address(RVA = "0x57CC870", Offset = "0x57CBC70", VA = "0x1857CC870", Slot = "103")]
	public Vector3 DNICIBAAMCG(Vector3 LPJDDLMPNCG)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000256")]
	[Cpp2IlInjected.Address(RVA = "0x57CD840", Offset = "0x57CCC40", VA = "0x1857CD840", Slot = "104")]
	public Vector3 GJAHBCCOAII(Vector3 LPJDDLMPNCG)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000257")]
	[Cpp2IlInjected.Address(RVA = "0x57CCE30", Offset = "0x57CC230", VA = "0x1857CCE30", Slot = "105")]
	public void EPOKPKAANHO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600025A")]
	[Cpp2IlInjected.Address(RVA = "0x57D0D80", Offset = "0x57D0180", VA = "0x1857D0D80", Slot = "106")]
	public void OIHMDCKKBFA(NCOEFPHLCKK BKGBHBNCDJA, object MIFCLBEAOPM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600025B")]
	[Cpp2IlInjected.Address(RVA = "0x57CCD30", Offset = "0x57CC130", VA = "0x1857CCD30", Slot = "107")]
	public void ELAHEJFDAHO(object MIFCLBEAOPM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000268")]
	[Cpp2IlInjected.Address(RVA = "0x57CCF30", Offset = "0x57CC330", VA = "0x1857CCF30", Slot = "110")]
	public void FCDPOIHJAAG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000269")]
	[Cpp2IlInjected.Address(RVA = "0x57CB840", Offset = "0x57CAC40", VA = "0x1857CB840", Slot = "111")]
	public void AEAABDHDFFI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600026A")]
	[Cpp2IlInjected.Address(RVA = "0x57CE550", Offset = "0x57CD950", VA = "0x1857CE550", Slot = "112")]
	public void IEIECPGHPLP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000273")]
	[Cpp2IlInjected.Address(RVA = "0x57D01E0", Offset = "0x57CF5E0", VA = "0x1857D01E0", Slot = "115")]
	public bool NEPEFPHIELC()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000274")]
	[Cpp2IlInjected.Address(RVA = "0x57D1450", Offset = "0x57D0850", VA = "0x1857D1450", Slot = "79")]
	public void PKFLOCAHJCK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000275")]
	[Cpp2IlInjected.Address(RVA = "0x57D12D0", Offset = "0x57D06D0", VA = "0x1857D12D0", Slot = "116")]
	public void PFPLFILECPI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600027D")]
	[Cpp2IlInjected.Address(RVA = "0x57CCAF0", Offset = "0x57CBEF0", VA = "0x1857CCAF0", Slot = "121")]
	public IDisposable EBMGEFKJGJE()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600027E")]
	[Cpp2IlInjected.Address(RVA = "0x57CF420", Offset = "0x57CE820", VA = "0x1857CF420", Slot = "122")]
	public void LDMPNKDCNKH(object MIFCLBEAOPM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600027F")]
	[Cpp2IlInjected.Address(RVA = "0x57CCFE0", Offset = "0x57CC3E0", VA = "0x1857CCFE0", Slot = "123")]
	public void FGAHJAEMBHA(object MIFCLBEAOPM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000280")]
	[Cpp2IlInjected.Address(RVA = "0x57D14F0", Offset = "0x57D08F0", VA = "0x1857D14F0", Slot = "124")]
	public void PNGKMLMJNAK(object MIFCLBEAOPM, bool KLMBPMINIHN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000291")]
	[Cpp2IlInjected.Address(RVA = "0x57CF6D0", Offset = "0x57CEAD0", VA = "0x1857CF6D0", Slot = "127")]
	public void LOKMBIPHOGK(Vector3 PGJOODJOMAI, Quaternion OMJBPOHHBNI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000292")]
	[Cpp2IlInjected.Address(RVA = "0x57D0960", Offset = "0x57CFD60", VA = "0x1857D0960", Slot = "128")]
	public void OFCCCKGCAPP(Vector3 PPNOLBKPBJH, Quaternion KAHANPFONLJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000293")]
	[Cpp2IlInjected.Address(RVA = "0x57CBAF0", Offset = "0x57CAEF0", VA = "0x1857CBAF0", Slot = "129")]
	public bool AMLDEGGHKAD(float ANPGDIDDDCB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000298")]
	[Cpp2IlInjected.Address(RVA = "0x57CE050", Offset = "0x57CD450", VA = "0x1857CE050", Slot = "130")]
	public void HMHFMGOKMHP(object MIFCLBEAOPM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000299")]
	[Cpp2IlInjected.Address(RVA = "0x57CF300", Offset = "0x57CE700", VA = "0x1857CF300", Slot = "131")]
	public void KNMLFLHNFDJ(object MIFCLBEAOPM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600029A")]
	[Cpp2IlInjected.Address(RVA = "0x57CF3C0", Offset = "0x57CE7C0", VA = "0x1857CF3C0", Slot = "132")]
	public void KPOLANLNJJI(object MIFCLBEAOPM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600029B")]
	[Cpp2IlInjected.Address(RVA = "0x57CDDE0", Offset = "0x57CD1E0", VA = "0x1857CDDE0", Slot = "133")]
	public void HIBCGDMOODJ(object MIFCLBEAOPM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600029C")]
	[Cpp2IlInjected.Address(RVA = "0x57CBEF0", Offset = "0x57CB2F0", VA = "0x1857CBEF0", Slot = "134")]
	public void BEJNHGKJNLM(Vector3 HKPPDHFDHMN, ForceMode MPMGBCACKOF = ForceMode.Force)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600029D")]
	[Cpp2IlInjected.Address(RVA = "0x57CC260", Offset = "0x57CB660", VA = "0x1857CC260", Slot = "135")]
	public void CBMEMNKKLDE(Vector3 HKPPDHFDHMN, Vector3 PICDPPHNNLH, ForceMode MPMGBCACKOF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600029E")]
	[Cpp2IlInjected.Address(RVA = "0x57D0D00", Offset = "0x57D0100", VA = "0x1857D0D00", Slot = "136")]
	public void OHNHDPGFLAC(Vector3 MBBMKANKKGB, ForceMode MPMGBCACKOF = ForceMode.Force)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600029F")]
	[Cpp2IlInjected.Address(RVA = "0x57D1610", Offset = "0x57D0A10", VA = "0x1857D1610", Slot = "137")]
	public void PPDGHDJCFAP(Vector3 MBBMKANKKGB, ForceMode MPMGBCACKOF = ForceMode.Force)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002A2")]
	[Cpp2IlInjected.Address(RVA = "0x57D0B70", Offset = "0x57CFF70", VA = "0x1857D0B70", Slot = "138")]
	public bool OFDKFHJBLOJ(Vector3 MFKKMPGAJFI, out RaycastHit ONOMCDOFLKH, float CBFODBDKBEK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002A4")]
	[Cpp2IlInjected.Address(RVA = "0x57CBAA0", Offset = "0x57CAEA0", VA = "0x1857CBAA0", Slot = "139")]
	public void AMJHKJLPLNB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002A5")]
	[Cpp2IlInjected.Address(RVA = "0x57D16F0", Offset = "0x57D0AF0", VA = "0x1857D16F0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002A6")]
	[Cpp2IlInjected.Address(RVA = "0x57D0370", Offset = "0x57CF770", VA = "0x1857D0370")]
	private void NICOHLOHFBG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002A7")]
	[Cpp2IlInjected.Address(RVA = "0x57CBDE0", Offset = "0x57CB1E0", VA = "0x1857CBDE0")]
	private void BDNBLBFFHHC(NCOEFPHLCKK GGEKFPEBLKN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002A8")]
	[Cpp2IlInjected.Address(RVA = "0x57CF4E0", Offset = "0x57CE8E0", VA = "0x1857CF4E0")]
	private void LMNJJEPMEEO(NCOEFPHLCKK GGEKFPEBLKN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002A9")]
	[Cpp2IlInjected.Address(RVA = "0x57CFF70", Offset = "0x57CF370", VA = "0x1857CFF70")]
	private void MKEPJNOMJBD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002AA")]
	[Cpp2IlInjected.Address(RVA = "0x57CE6A0", Offset = "0x57CDAA0", VA = "0x1857CE6A0")]
	private void IGJFIAMCHNP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002AB")]
	[Cpp2IlInjected.Address(RVA = "0x57CCE80", Offset = "0x57CC280", VA = "0x1857CCE80")]
	private void FAJPHEAJODP(NCOEFPHLCKK EMJBGADPLOE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002AC")]
	[Cpp2IlInjected.Address(RVA = "0x57CD5C0", Offset = "0x57CC9C0", VA = "0x1857CD5C0")]
	private void FPAGIJPELCJ(NCOEFPHLCKK GGEKFPEBLKN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002AD")]
	[Cpp2IlInjected.Address(RVA = "0x57CCB40", Offset = "0x57CBF40", VA = "0x1857CCB40")]
	private void EDIJKBDKKBN(NCOEFPHLCKK GGEKFPEBLKN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002AE")]
	[Cpp2IlInjected.Address(RVA = "0x57D1160", Offset = "0x57D0560", VA = "0x1857D1160")]
	private void PDGKMGMBAKE(RigidbodyEx GGEKFPEBLKN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002AF")]
	[Cpp2IlInjected.Address(RVA = "0x57D0520", Offset = "0x57CF920", VA = "0x1857D0520")]
	private void NMKMBEIECNB(RigidbodyEx IILFNNEDNCJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002B0")]
	[Cpp2IlInjected.Address(RVA = "0x57D1320", Offset = "0x57D0720", VA = "0x1857D1320")]
	[Conditional("UNITY_EDITOR")]
	private void PGPNDFCEJPI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002B1")]
	[Cpp2IlInjected.Address(RVA = "0x57CFAF0", Offset = "0x57CEEF0", VA = "0x1857CFAF0")]
	protected void MIDJGBOHFJN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002B2")]
	[Cpp2IlInjected.Address(RVA = "0x57CEF70", Offset = "0x57CE370", VA = "0x1857CEF70")]
	protected void KJAKLLMPFGN()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002A")]
internal static class FBAAOANGPOH
{
	[Cpp2IlInjected.Token(Token = "0x60002B3")]
	[Cpp2IlInjected.Address(RVA = "0x57B0AC0", Offset = "0x57AFEC0", VA = "0x1857B0AC0")]
	public static NCOEFPHLCKK LHDELKCHFDH(this NCOEFPHLCKK IILFNNEDNCJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002B4")]
	[Cpp2IlInjected.Address(RVA = "0x57B0950", Offset = "0x57AFD50", VA = "0x1857B0950")]
	public static bool DNONFCCKBCL(this NCOEFPHLCKK IILFNNEDNCJ, NCOEFPHLCKK FMPADABIBEJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002B5")]
	[Cpp2IlInjected.Address(RVA = "0x57B0A40", Offset = "0x57AFE40", VA = "0x1857B0A40")]
	public static bool JMKFKNLDDPE(this NCOEFPHLCKK IILFNNEDNCJ, NCOEFPHLCKK BOAHBOBCIFK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002B6")]
	[Cpp2IlInjected.Address(RVA = "0x57B0B80", Offset = "0x57AFF80", VA = "0x1857B0B80")]
	public static RigidbodyEx OEOEKIBFEMO(this NCOEFPHLCKK EOOOGHAIOAE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002B7")]
	[Cpp2IlInjected.Address(RVA = "0x57B09D0", Offset = "0x57AFDD0", VA = "0x1857B09D0")]
	public static PLOEBEDJGLE FBBPFDMGFIE(this NCOEFPHLCKK NLKDOMNEDBE)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200002B")]
internal class OFHEAMJAHEA : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000044")]
	private readonly PLOEBEDJGLE IILFNNEDNCJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000045")]
	private bool FCPODLMHINC;

	[Cpp2IlInjected.Token(Token = "0x60002B8")]
	[Cpp2IlInjected.Address(RVA = "0x57CAFD0", Offset = "0x57CA3D0", VA = "0x1857CAFD0")]
	public OFHEAMJAHEA(PLOEBEDJGLE NFAMBOPBCLL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002B9")]
	[Cpp2IlInjected.Address(RVA = "0x57CAF70", Offset = "0x57CA370", VA = "0x1857CAF70", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002C")]
internal sealed class KKKKDAHHJPA : LPHFOFKHCNE, AIOOGANOGPH
{
	[Cpp2IlInjected.Token(Token = "0x170000BD")]
	private CollisionDetectionMode MAJGBEOMFEJ
	{
		[Cpp2IlInjected.Token(Token = "0x60002BB")]
		[Cpp2IlInjected.Address(RVA = "0x57C1640", Offset = "0x57C0A40", VA = "0x1857C1640")]
		get
		{
			return default(CollisionDetectionMode);
		}
		[Cpp2IlInjected.Token(Token = "0x60002BC")]
		[Cpp2IlInjected.Address(RVA = "0x57C1140", Offset = "0x57C0540", VA = "0x1857C1140")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000BE")]
	private Rigidbody LNMDHFKNJIH
	{
		[Cpp2IlInjected.Token(Token = "0x60002BD")]
		[Cpp2IlInjected.Address(RVA = "0x57AB800", Offset = "0x57AAC00", VA = "0x1857AB800")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000BF")]
	public CollisionDetectionMode PAOOKBBFCLK
	{
		[Cpp2IlInjected.Token(Token = "0x60002C0")]
		[Cpp2IlInjected.Address(RVA = "0x57C1420", Offset = "0x57C0820", VA = "0x1857C1420", Slot = "4")]
		get
		{
			return default(CollisionDetectionMode);
		}
		[Cpp2IlInjected.Token(Token = "0x60002C1")]
		[Cpp2IlInjected.Address(RVA = "0x57C1230", Offset = "0x57C0630", VA = "0x1857C1230", Slot = "5")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60002BA")]
	[Cpp2IlInjected.Address(RVA = "0x57AC240", Offset = "0x57AB640", VA = "0x1857AC240")]
	public KKKKDAHHJPA(NCOEFPHLCKK IILFNNEDNCJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002BE")]
	[Cpp2IlInjected.Address(RVA = "0x57C1530", Offset = "0x57C0930", VA = "0x1857C1530", Slot = "6")]
	public void PBJONABJOBO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002BF")]
	[Cpp2IlInjected.Address(RVA = "0x57C0E90", Offset = "0x57C0290", VA = "0x1857C0E90", Slot = "9")]
	public void BOFMJFDPNBF(Rigidbody GHAGIOLHPMN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002C2")]
	[Cpp2IlInjected.Address(RVA = "0x57C1120", Offset = "0x57C0520", VA = "0x1857C1120", Slot = "7")]
	public void DLGGDMCBIHM(bool OJNHEHLGDGI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002C3")]
	[Cpp2IlInjected.Address(RVA = "0x57C1130", Offset = "0x57C0530", VA = "0x1857C1130", Slot = "8")]
	public void FICHJHCOBIG(bool OJNHEHLGDGI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002C4")]
	[Cpp2IlInjected.Address(RVA = "0x57C12B0", Offset = "0x57C06B0", VA = "0x1857C12B0", Slot = "10")]
	public bool OFDKFHJBLOJ(Vector3 MFKKMPGAJFI, out RaycastHit ONOMCDOFLKH, float CBFODBDKBEK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002C5")]
	[Cpp2IlInjected.Address(RVA = "0x57C0F20", Offset = "0x57C0320", VA = "0x1857C0F20")]
	private void DAOOMGFPAAE(bool OJNHEHLGDGI)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002D")]
internal sealed class JFJILAEEHEP : LPHFOFKHCNE, JBCOLILENLD, IDisposable, FLCKAICBODN
{
	[Cpp2IlInjected.Token(Token = "0x170000C0")]
	public GGPABLKNBJB EMHBGABGONE
	{
		[Cpp2IlInjected.Token(Token = "0x60002C9")]
		[Cpp2IlInjected.Address(RVA = "0x57BD840", Offset = "0x57BCC40", VA = "0x1857BD840")]
		get
		{
			return default(GGPABLKNBJB);
		}
		[Cpp2IlInjected.Token(Token = "0x60002CA")]
		[Cpp2IlInjected.Address(RVA = "0x57BD530", Offset = "0x57BC930", VA = "0x1857BD530")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000C1")]
	public GGPABLKNBJB LEKOFMMMFBB
	{
		[Cpp2IlInjected.Token(Token = "0x60002CB")]
		[Cpp2IlInjected.Address(RVA = "0x57BD620", Offset = "0x57BCA20", VA = "0x1857BD620", Slot = "6")]
		get
		{
			return default(GGPABLKNBJB);
		}
		[Cpp2IlInjected.Token(Token = "0x60002CC")]
		[Cpp2IlInjected.Address(RVA = "0x57BD530", Offset = "0x57BC930", VA = "0x1857BD530", Slot = "7")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000C2")]
	private Transform OACKHJKFCIO
	{
		[Cpp2IlInjected.Token(Token = "0x60002D1")]
		[Cpp2IlInjected.Address(RVA = "0x72F5A0", Offset = "0x72E9A0", VA = "0x18072F5A0", Slot = "10")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400002A")]
	public event Action<FCDCKNBKJML, FCDCKNBKJML> DLLBDKMMJIP
	{
		[Cpp2IlInjected.Token(Token = "0x60002C7")]
		[Cpp2IlInjected.Address(RVA = "0x57BD490", Offset = "0x57BC890", VA = "0x1857BD490", Slot = "4")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60002C8")]
		[Cpp2IlInjected.Address(RVA = "0x57BD980", Offset = "0x57BCD80", VA = "0x1857BD980", Slot = "5")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60002C6")]
	[Cpp2IlInjected.Address(RVA = "0x57AC240", Offset = "0x57AB640", VA = "0x1857AC240")]
	public JFJILAEEHEP(NCOEFPHLCKK IILFNNEDNCJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002CD")]
	[Cpp2IlInjected.Address(RVA = "0x57BD920", Offset = "0x57BCD20", VA = "0x1857BD920", Slot = "11")]
	public void OnChangedDistanceBand(FCDCKNBKJML DKOFAPECACL, FCDCKNBKJML JFNADPGFOAB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002CE")]
	[Cpp2IlInjected.Address(RVA = "0x72E830", Offset = "0x72DC30", VA = "0x18072E830", Slot = "12")]
	public void OnChangedVisibility(bool FHFGDHHLCHJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002CF")]
	[Cpp2IlInjected.Address(RVA = "0x72E830", Offset = "0x72DC30", VA = "0x18072E830", Slot = "8")]
	public void PBJONABJOBO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002D0")]
	[Cpp2IlInjected.Address(RVA = "0x72E830", Offset = "0x72DC30", VA = "0x18072E830", Slot = "9")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002E")]
internal sealed class DGILPDFDKEJ : LPHFOFKHCNE, BDJOPHNNEJG
{
	[Cpp2IlInjected.Token(Token = "0x170000C3")]
	private Rigidbody LNMDHFKNJIH
	{
		[Cpp2IlInjected.Token(Token = "0x60002D3")]
		[Cpp2IlInjected.Address(RVA = "0x57AB800", Offset = "0x57AAC00", VA = "0x1857AB800")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000C4")]
	private bool FAJNDFDCOGA
	{
		[Cpp2IlInjected.Token(Token = "0x60002D4")]
		[Cpp2IlInjected.Address(RVA = "0x57ABDB0", Offset = "0x57AB1B0", VA = "0x1857ABDB0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000C5")]
	private bool KMDIPAOGGGF
	{
		[Cpp2IlInjected.Token(Token = "0x60002D5")]
		[Cpp2IlInjected.Address(RVA = "0x57ABD50", Offset = "0x57AB150", VA = "0x1857ABD50")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000C6")]
	private NCOEFPHLCKK GKEMABFNEME
	{
		[Cpp2IlInjected.Token(Token = "0x60002D6")]
		[Cpp2IlInjected.Address(RVA = "0x57ABE00", Offset = "0x57AB200", VA = "0x1857ABE00")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60002D2")]
	[Cpp2IlInjected.Address(RVA = "0x57AC240", Offset = "0x57AB640", VA = "0x1857AC240")]
	public DGILPDFDKEJ(NCOEFPHLCKK IILFNNEDNCJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002D7")]
	[Cpp2IlInjected.Address(RVA = "0x57AB400", Offset = "0x57AA800", VA = "0x1857AB400", Slot = "4")]
	public void BEJNHGKJNLM(Vector3 HKPPDHFDHMN, ForceMode MPMGBCACKOF = ForceMode.Force)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002D8")]
	[Cpp2IlInjected.Address(RVA = "0x57AB850", Offset = "0x57AAC50", VA = "0x1857AB850")]
	private void GNLGGMKPOAG(Vector3 HKPPDHFDHMN, ForceMode MPMGBCACKOF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002D9")]
	[Cpp2IlInjected.Address(RVA = "0x57AB560", Offset = "0x57AA960", VA = "0x1857AB560", Slot = "5")]
	public void CBMEMNKKLDE(Vector3 HKPPDHFDHMN, Vector3 PICDPPHNNLH, ForceMode MPMGBCACKOF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002DA")]
	[Cpp2IlInjected.Address(RVA = "0x57ABE60", Offset = "0x57AB260", VA = "0x1857ABE60", Slot = "6")]
	public void OHNHDPGFLAC(Vector3 MBBMKANKKGB, ForceMode MPMGBCACKOF = ForceMode.Force)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002DB")]
	[Cpp2IlInjected.Address(RVA = "0x57ABAD0", Offset = "0x57AAED0", VA = "0x1857ABAD0")]
	private void HDEEJGEFJJL(Vector3 MBBMKANKKGB, ForceMode MPMGBCACKOF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002DC")]
	[Cpp2IlInjected.Address(RVA = "0x57ABFC0", Offset = "0x57AB3C0", VA = "0x1857ABFC0", Slot = "7")]
	public void PPDGHDJCFAP(Vector3 MBBMKANKKGB, ForceMode MPMGBCACKOF = ForceMode.Force)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002F")]
internal sealed class MGNEKJDGJKC : LPHFOFKHCNE, BBGAPPNBFLO
{
	[Cpp2IlInjected.Token(Token = "0x170000C7")]
	public bool OGIIANAEIFL
	{
		[Cpp2IlInjected.Token(Token = "0x60002DE")]
		[Cpp2IlInjected.Address(RVA = "0x57C41E0", Offset = "0x57C35E0", VA = "0x1857C41E0", Slot = "4")]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x60002DF")]
		[Cpp2IlInjected.Address(RVA = "0x57C4000", Offset = "0x57C3400", VA = "0x1857C4000", Slot = "5")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60002DD")]
	[Cpp2IlInjected.Address(RVA = "0x57AC240", Offset = "0x57AB640", VA = "0x1857AC240")]
	public MGNEKJDGJKC(NCOEFPHLCKK IILFNNEDNCJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002E0")]
	[Cpp2IlInjected.Address(RVA = "0x57C3F00", Offset = "0x57C3300", VA = "0x1857C3F00", Slot = "6")]
	public void BOFMJFDPNBF(Rigidbody GHAGIOLHPMN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002E1")]
	[Cpp2IlInjected.Address(RVA = "0x57C42C0", Offset = "0x57C36C0", VA = "0x1857C42C0", Slot = "7")]
	public void PKFCGBCFJGD(Rigidbody GHAGIOLHPMN)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000030")]
internal sealed class MPAFELNNHEE : LPHFOFKHCNE, PLDJMDIFCKE, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x4000050")]
	private readonly GMOJEAHHPKO BOGHIFKGACA;

	[Cpp2IlInjected.Token(Token = "0x170000C8")]
	private Transform LHEBMCHBDEI
	{
		[Cpp2IlInjected.Token(Token = "0x60002F5")]
		[Cpp2IlInjected.Address(RVA = "0x57C6040", Offset = "0x57C5440", VA = "0x1857C6040")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000C9")]
	public MBEDCJLMHEO NIBHAOFECEF
	{
		[Cpp2IlInjected.Token(Token = "0x60002F7")]
		[Cpp2IlInjected.Address(RVA = "0x57C6F70", Offset = "0x57C6370", VA = "0x1857C6F70")]
		get
		{
			return default(MBEDCJLMHEO);
		}
		[Cpp2IlInjected.Token(Token = "0x60002F8")]
		[Cpp2IlInjected.Address(RVA = "0x57C4CA0", Offset = "0x57C40A0", VA = "0x1857C4CA0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000CA")]
	public NCOEFPHLCKK GKEMABFNEME
	{
		[Cpp2IlInjected.Token(Token = "0x60002F9")]
		[Cpp2IlInjected.Address(RVA = "0x57C6C70", Offset = "0x57C6070", VA = "0x1857C6C70", Slot = "24")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60002FA")]
		[Cpp2IlInjected.Address(RVA = "0x57C4B90", Offset = "0x57C3F90", VA = "0x1857C4B90", Slot = "25")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000CB")]
	public MBEDCJLMHEO IAPCCNJLHLM
	{
		[Cpp2IlInjected.Token(Token = "0x60002FB")]
		[Cpp2IlInjected.Address(RVA = "0x57C62F0", Offset = "0x57C56F0", VA = "0x1857C62F0")]
		get
		{
			return default(MBEDCJLMHEO);
		}
		[Cpp2IlInjected.Token(Token = "0x60002FC")]
		[Cpp2IlInjected.Address(RVA = "0x57C7110", Offset = "0x57C6510", VA = "0x1857C7110")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000CC")]
	public NCOEFPHLCKK CMJKBCMDGHN
	{
		[Cpp2IlInjected.Token(Token = "0x60002FD")]
		[Cpp2IlInjected.Address(RVA = "0x57C5740", Offset = "0x57C4B40", VA = "0x1857C5740", Slot = "23")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000CD")]
	public IReadOnlyList<NCOEFPHLCKK> PHPDFDJEEEA
	{
		[Cpp2IlInjected.Token(Token = "0x60002FE")]
		[Cpp2IlInjected.Address(RVA = "0x72B0B0", Offset = "0x72A4B0", VA = "0x18072B0B0", Slot = "22")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400002B")]
	public event DGAAFHCPHEH NJJHHELIHIP
	{
		[Cpp2IlInjected.Token(Token = "0x60002E3")]
		[Cpp2IlInjected.Address(RVA = "0x57C6670", Offset = "0x57C5A70", VA = "0x1857C6670", Slot = "4")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60002E4")]
		[Cpp2IlInjected.Address(RVA = "0x57C6840", Offset = "0x57C5C40", VA = "0x1857C6840", Slot = "5")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400002C")]
	public event DGAAFHCPHEH EPBNCIPAFDB
	{
		[Cpp2IlInjected.Token(Token = "0x60002E5")]
		[Cpp2IlInjected.Address(RVA = "0x57C6490", Offset = "0x57C5890", VA = "0x1857C6490", Slot = "6")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60002E6")]
		[Cpp2IlInjected.Address(RVA = "0x57C6250", Offset = "0x57C5650", VA = "0x1857C6250", Slot = "7")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400002D")]
	public event MKKJLKCGEAC EIBHEHIGCNB
	{
		[Cpp2IlInjected.Token(Token = "0x60002E7")]
		[Cpp2IlInjected.Address(RVA = "0x57C63F0", Offset = "0x57C57F0", VA = "0x1857C63F0", Slot = "8")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60002E8")]
		[Cpp2IlInjected.Address(RVA = "0x57C6530", Offset = "0x57C5930", VA = "0x1857C6530", Slot = "9")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400002E")]
	public event Action PFANGAANPGN
	{
		[Cpp2IlInjected.Token(Token = "0x60002E9")]
		[Cpp2IlInjected.Address(RVA = "0x57C65D0", Offset = "0x57C59D0", VA = "0x1857C65D0", Slot = "10")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60002EA")]
		[Cpp2IlInjected.Address(RVA = "0x57C6B20", Offset = "0x57C5F20", VA = "0x1857C6B20", Slot = "11")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400002F")]
	public event Action NJGCKLJKCAG
	{
		[Cpp2IlInjected.Token(Token = "0x60002EB")]
		[Cpp2IlInjected.Address(RVA = "0x57C61B0", Offset = "0x57C55B0", VA = "0x1857C61B0", Slot = "12")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60002EC")]
		[Cpp2IlInjected.Address(RVA = "0x57C56A0", Offset = "0x57C4AA0", VA = "0x1857C56A0", Slot = "13")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000030")]
	public event Action<NCOEFPHLCKK> NFDMKCEEBKO
	{
		[Cpp2IlInjected.Token(Token = "0x60002ED")]
		[Cpp2IlInjected.Address(RVA = "0x57C7070", Offset = "0x57C6470", VA = "0x1857C7070", Slot = "14")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60002EE")]
		[Cpp2IlInjected.Address(RVA = "0x57C6070", Offset = "0x57C5470", VA = "0x1857C6070", Slot = "15")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000031")]
	public event Action<NCOEFPHLCKK> AMBCDPFGEAJ
	{
		[Cpp2IlInjected.Token(Token = "0x60002EF")]
		[Cpp2IlInjected.Address(RVA = "0x57C6110", Offset = "0x57C5510", VA = "0x1857C6110", Slot = "16")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60002F0")]
		[Cpp2IlInjected.Address(RVA = "0x57C5E70", Offset = "0x57C5270", VA = "0x1857C5E70", Slot = "17")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000032")]
	public event Action KKKJMJHLIKB
	{
		[Cpp2IlInjected.Token(Token = "0x60002F1")]
		[Cpp2IlInjected.Address(RVA = "0x57C5A40", Offset = "0x57C4E40", VA = "0x1857C5A40", Slot = "18")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60002F2")]
		[Cpp2IlInjected.Address(RVA = "0x57C4C00", Offset = "0x57C4000", VA = "0x1857C4C00", Slot = "19")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000033")]
	public event Action<NCOEFPHLCKK> PFJIOBMDLAL
	{
		[Cpp2IlInjected.Token(Token = "0x60002F3")]
		[Cpp2IlInjected.Address(RVA = "0x57C5DD0", Offset = "0x57C51D0", VA = "0x1857C5DD0", Slot = "20")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60002F4")]
		[Cpp2IlInjected.Address(RVA = "0x57C6A80", Offset = "0x57C5E80", VA = "0x1857C6A80", Slot = "21")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60002E2")]
	[Cpp2IlInjected.Address(RVA = "0x57C7210", Offset = "0x57C6610", VA = "0x1857C7210")]
	public MPAFELNNHEE(NCOEFPHLCKK IILFNNEDNCJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002F6")]
	[Cpp2IlInjected.Address(RVA = "0x57C5870", Offset = "0x57C4C70", VA = "0x1857C5870", Slot = "27")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002FF")]
	[Cpp2IlInjected.Address(RVA = "0x57C5780", Offset = "0x57C4B80", VA = "0x1857C5780", Slot = "26")]
	public void DEIBNNOCJKC(NCOEFPHLCKK BJNIPOLNMLD, bool OMIKAFGHIFK = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000300")]
	[Cpp2IlInjected.Address(RVA = "0x57C5800", Offset = "0x57C4C00", VA = "0x1857C5800")]
	private void DEIBNNOCJKC(KNGEGNFMEDP BJNIPOLNMLD, bool OMIKAFGHIFK = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000301")]
	[Cpp2IlInjected.Address(RVA = "0x57C4DA0", Offset = "0x57C41A0", VA = "0x1857C4DA0")]
	private void BJMKIEJKNJF(KNGEGNFMEDP BJNIPOLNMLD, bool OMIKAFGHIFK = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000302")]
	[Cpp2IlInjected.Address(RVA = "0x57C6CB0", Offset = "0x57C60B0", VA = "0x1857C6CB0")]
	private void OAJEEOBFKGI(KNGEGNFMEDP EMJBGADPLOE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000303")]
	[Cpp2IlInjected.Address(RVA = "0x57C5AE0", Offset = "0x57C4EE0", VA = "0x1857C5AE0")]
	private void FEBKLPDLGMF(KNGEGNFMEDP EMJBGADPLOE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000304")]
	[Cpp2IlInjected.Address(RVA = "0x57C68E0", Offset = "0x57C5CE0", VA = "0x1857C68E0")]
	private void MAFJOMEFHJN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000305")]
	[Cpp2IlInjected.Address(RVA = "0x57C5620", Offset = "0x57C4A20", VA = "0x1857C5620")]
	private void CIAELCNFLBC(KNGEGNFMEDP EMJBGADPLOE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000306")]
	[Cpp2IlInjected.Address(RVA = "0x57C6BC0", Offset = "0x57C5FC0", VA = "0x1857C6BC0")]
	private void MJFKBFMOHPL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000307")]
	[Cpp2IlInjected.Address(RVA = "0x57C5F10", Offset = "0x57C5310", VA = "0x1857C5F10")]
	private void GCCACPFBAFO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000308")]
	[Cpp2IlInjected.Address(RVA = "0x57C6710", Offset = "0x57C5B10", VA = "0x1857C6710")]
	private void LBIPGKKJCGE(KNGEGNFMEDP IILFNNEDNCJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000309")]
	[Cpp2IlInjected.Address(RVA = "0x57C5CA0", Offset = "0x57C50A0", VA = "0x1857C5CA0")]
	private void FHJPDJCNJIO(KNGEGNFMEDP IILFNNEDNCJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600030A")]
	[Cpp2IlInjected.Address(RVA = "0x57C6E70", Offset = "0x57C6270", VA = "0x1857C6E70")]
	[CompilerGenerated]
	private object OHPPPDIIACM()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000031")]
internal static class JMPJPOHIBBG
{
	[Cpp2IlInjected.Token(Token = "0x600030B")]
	[Cpp2IlInjected.Address(RVA = "0x57BE120", Offset = "0x57BD520", VA = "0x1857BE120")]
	public static MPAFELNNHEE EHJMHIENHGI(this NCOEFPHLCKK NLKDOMNEDBE)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000032")]
internal sealed class PPELHKHJNDB : LPHFOFKHCNE, IMBEMHENMNJ
{
	[Cpp2IlInjected.Token(Token = "0x170000CE")]
	public Vector3 BFENAJAEKJN
	{
		[Cpp2IlInjected.Token(Token = "0x600030D")]
		[Cpp2IlInjected.Address(RVA = "0x69A37E0", Offset = "0x69A2BE0", VA = "0x1869A37E0", Slot = "4")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000CF")]
	public Vector3 LECHPMMLACE
	{
		[Cpp2IlInjected.Token(Token = "0x600030E")]
		[Cpp2IlInjected.Address(RVA = "0x69A3370", Offset = "0x69A2770", VA = "0x1869A3370", Slot = "5")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000D0")]
	private Vector3 LGEGEJPPDAD
	{
		[Cpp2IlInjected.Token(Token = "0x6000312")]
		[Cpp2IlInjected.Address(RVA = "0x69A2D20", Offset = "0x69A2120", VA = "0x1869A2D20")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000D1")]
	private NCOEFPHLCKK KJCAOKIHBIK
	{
		[Cpp2IlInjected.Token(Token = "0x6000313")]
		[Cpp2IlInjected.Address(RVA = "0x69A3140", Offset = "0x69A2540", VA = "0x1869A3140")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600030C")]
	[Cpp2IlInjected.Address(RVA = "0x69A3810", Offset = "0x69A2C10", VA = "0x1869A3810")]
	public PPELHKHJNDB(NCOEFPHLCKK IILFNNEDNCJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600030F")]
	[Cpp2IlInjected.Address(RVA = "0x69A3500", Offset = "0x69A2900", VA = "0x1869A3500", Slot = "6")]
	public void IOHAPAEGEFD(NCOEFPHLCKK GGEKFPEBLKN, object MIFCLBEAOPM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000310")]
	[Cpp2IlInjected.Address(RVA = "0x69A36A0", Offset = "0x69A2AA0", VA = "0x1869A36A0")]
	private void IOHAPAEGEFD(KNGEGNFMEDP GGEKFPEBLKN, object MIFCLBEAOPM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000311")]
	[Cpp2IlInjected.Address(RVA = "0x69A3270", Offset = "0x69A2670", VA = "0x1869A3270", Slot = "7")]
	public void DNECHJALIBL(object MIFCLBEAOPM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000314")]
	[Cpp2IlInjected.Address(RVA = "0x69A2E00", Offset = "0x69A2200", VA = "0x1869A2E00")]
	private Vector3 BIHFLNGABAB()
	{
		return default(Vector3);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000033")]
internal static class CFFBFMHJJFN
{
	[Cpp2IlInjected.Token(Token = "0x6000315")]
	[Cpp2IlInjected.Address(RVA = "0x57AABE0", Offset = "0x57A9FE0", VA = "0x1857AABE0")]
	public static PPELHKHJNDB FCOMDNGDAPJ(this NCOEFPHLCKK NLKDOMNEDBE)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000034")]
internal sealed class IHCNHADGBCB : LPHFOFKHCNE, OGBLFJOOHEI
{
	[Cpp2IlInjected.Token(Token = "0x170000D2")]
	public Vector3 BMNHHGGIMHD
	{
		[Cpp2IlInjected.Token(Token = "0x6000319")]
		[Cpp2IlInjected.Address(RVA = "0x57B9960", Offset = "0x57B8D60", VA = "0x1857B9960", Slot = "6")]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x600031A")]
		[Cpp2IlInjected.Address(RVA = "0x57B9A90", Offset = "0x57B8E90", VA = "0x1857B9A90", Slot = "7")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000D3")]
	public Vector3 ICDJEGJHDEE
	{
		[Cpp2IlInjected.Token(Token = "0x600031B")]
		[Cpp2IlInjected.Address(RVA = "0x57BB510", Offset = "0x57BA910", VA = "0x1857BB510", Slot = "8")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000D4")]
	public float AHNCJOKPCCM
	{
		[Cpp2IlInjected.Token(Token = "0x600031C")]
		[Cpp2IlInjected.Address(RVA = "0x57BA3B0", Offset = "0x57B97B0", VA = "0x1857BA3B0", Slot = "9")]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x600031D")]
		[Cpp2IlInjected.Address(RVA = "0x57BB900", Offset = "0x57BAD00", VA = "0x1857BB900")]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000D5")]
	public float JAHICELIBID
	{
		[Cpp2IlInjected.Token(Token = "0x600031E")]
		[Cpp2IlInjected.Address(RVA = "0x57B9DF0", Offset = "0x57B91F0", VA = "0x1857B9DF0", Slot = "10")]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x600031F")]
		[Cpp2IlInjected.Address(RVA = "0x57BC480", Offset = "0x57BB880", VA = "0x1857BC480", Slot = "11")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000D6")]
	public Vector3 JLIOGCPKLOL
	{
		[Cpp2IlInjected.Token(Token = "0x6000320")]
		[Cpp2IlInjected.Address(RVA = "0x57B8EB0", Offset = "0x57B82B0", VA = "0x1857B8EB0", Slot = "12")]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x6000321")]
		[Cpp2IlInjected.Address(RVA = "0x57BB7F0", Offset = "0x57BABF0", VA = "0x1857BB7F0", Slot = "13")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000D7")]
	public Quaternion OCGLMIOIKKA
	{
		[Cpp2IlInjected.Token(Token = "0x6000322")]
		[Cpp2IlInjected.Address(RVA = "0x57BA490", Offset = "0x57B9890", VA = "0x1857BA490", Slot = "14")]
		get
		{
			return default(Quaternion);
		}
		[Cpp2IlInjected.Token(Token = "0x6000323")]
		[Cpp2IlInjected.Address(RVA = "0x57BBB80", Offset = "0x57BAF80", VA = "0x1857BBB80", Slot = "15")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000D8")]
	private Rigidbody LNMDHFKNJIH
	{
		[Cpp2IlInjected.Token(Token = "0x600032B")]
		[Cpp2IlInjected.Address(RVA = "0x57AB800", Offset = "0x57AAC00", VA = "0x1857AB800")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000034")]
	public event DGAAFHCPHEH IBFMPJKFDEA
	{
		[Cpp2IlInjected.Token(Token = "0x6000316")]
		[Cpp2IlInjected.Address(RVA = "0x57BB910", Offset = "0x57BAD10", VA = "0x1857BB910", Slot = "4")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000317")]
		[Cpp2IlInjected.Address(RVA = "0x57B9ED0", Offset = "0x57B92D0", VA = "0x1857B9ED0", Slot = "5")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000318")]
	[Cpp2IlInjected.Address(RVA = "0x57BC490", Offset = "0x57BB890", VA = "0x1857BC490")]
	public IHCNHADGBCB(NCOEFPHLCKK IILFNNEDNCJ, in JCAJMGPJNDN HIDEHJGLNHO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000324")]
	[Cpp2IlInjected.Address(RVA = "0x57BA1A0", Offset = "0x57B95A0", VA = "0x1857BA1A0", Slot = "17")]
	public void FCDPOIHJAAG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000325")]
	[Cpp2IlInjected.Address(RVA = "0x57B8EE0", Offset = "0x57B82E0", VA = "0x1857B8EE0", Slot = "16")]
	public void AEAABDHDFFI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000326")]
	[Cpp2IlInjected.Address(RVA = "0x57B9BD0", Offset = "0x57B8FD0", VA = "0x1857B9BD0", Slot = "19")]
	public void BOFMJFDPNBF(Rigidbody GHAGIOLHPMN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000327")]
	[Cpp2IlInjected.Address(RVA = "0x57BBEF0", Offset = "0x57BB2F0", VA = "0x1857BBEF0", Slot = "20")]
	public void PKFCGBCFJGD(Rigidbody GHAGIOLHPMN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000328")]
	[Cpp2IlInjected.Address(RVA = "0x57BB820", Offset = "0x57BAC20", VA = "0x1857BB820", Slot = "18")]
	public void IEIECPGHPLP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000329")]
	[Cpp2IlInjected.Address(RVA = "0x57B9260", Offset = "0x57B8660", VA = "0x1857B9260", Slot = "21")]
	public void AMJHKJLPLNB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600032A")]
	[Cpp2IlInjected.Address(RVA = "0x57B1A70", Offset = "0x57B0E70", VA = "0x1857B1A70")]
	public void AFBLDODBAMH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600032C")]
	[Cpp2IlInjected.Address(RVA = "0x57B9A90", Offset = "0x57B8E90", VA = "0x1857B9A90")]
	private void PNBIFKFCFEF(Vector3 LPJDDLMPNCG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600032D")]
	[Cpp2IlInjected.Address(RVA = "0x57BBBA0", Offset = "0x57BAFA0", VA = "0x1857BBBA0")]
	private Vector3 OMGBOJNFENG()
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x600032E")]
	[Cpp2IlInjected.Address(RVA = "0x57BB9B0", Offset = "0x57BADB0", VA = "0x1857BB9B0")]
	private void MMGDLCDAMEC(float LPJDDLMPNCG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600032F")]
	[Cpp2IlInjected.Address(RVA = "0x57BB630", Offset = "0x57BAA30", VA = "0x1857BB630")]
	private void IAOOGBCNABD(float LPJDDLMPNCG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000330")]
	[Cpp2IlInjected.Address(RVA = "0x57B9F70", Offset = "0x57B9370", VA = "0x1857B9F70")]
	private Vector3 EMNKCDOKIJP()
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000331")]
	[Cpp2IlInjected.Address(RVA = "0x57BBCC0", Offset = "0x57BB0C0", VA = "0x1857BBCC0")]
	private void PBMBMDIIBMG(Vector3 LPJDDLMPNCG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000332")]
	[Cpp2IlInjected.Address(RVA = "0x57B9750", Offset = "0x57B8B50", VA = "0x1857B9750")]
	private Quaternion ANKHAKNDHKM()
	{
		return default(Quaternion);
	}

	[Cpp2IlInjected.Token(Token = "0x6000333")]
	[Cpp2IlInjected.Address(RVA = "0x57BC270", Offset = "0x57BB670", VA = "0x1857BC270")]
	private void PMCIAKDJBLM(Quaternion LPJDDLMPNCG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000334")]
	[Cpp2IlInjected.Address(RVA = "0x57BA4C0", Offset = "0x57B98C0", VA = "0x1857BA4C0")]
	internal (float, Vector3) HCPEECAOGOM(Rigidbody BMDOKJBOKPE)
	{
		return default((float, Vector3));
	}
}
[Cpp2IlInjected.Token(Token = "0x2000035")]
internal static class JPHFHBIKMAL
{
	[Cpp2IlInjected.Token(Token = "0x6000335")]
	[Cpp2IlInjected.Address(RVA = "0x57BF130", Offset = "0x57BE530", VA = "0x1857BF130")]
	public static IHCNHADGBCB JIDBPFDBCJM(this NCOEFPHLCKK NLKDOMNEDBE)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000036")]
internal sealed class ACPOBIBHKIB : LPHFOFKHCNE, LBPABMNHAKF
{
	[Cpp2IlInjected.Token(Token = "0x4000052")]
	private const string DKCLIMFPCAB = "INTERP_PAUSE";

	[Cpp2IlInjected.Token(Token = "0x170000D9")]
	public bool OJDFKEJHLKC
	{
		[Cpp2IlInjected.Token(Token = "0x6000336")]
		[Cpp2IlInjected.Address(RVA = "0x57A9430", Offset = "0x57A8830", VA = "0x1857A9430", Slot = "4")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000DA")]
	public JGBCGHMDEIJ PAEMELMEBEE
	{
		[Cpp2IlInjected.Token(Token = "0x6000337")]
		[Cpp2IlInjected.Address(RVA = "0x57A9420", Offset = "0x57A8820", VA = "0x1857A9420", Slot = "5")]
		get
		{
			return default(JGBCGHMDEIJ);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000DB")]
	private JGBCGHMDEIJ PFLJCKLKGND
	{
		[Cpp2IlInjected.Token(Token = "0x6000339")]
		[Cpp2IlInjected.Address(RVA = "0x57A9620", Offset = "0x57A8A20", VA = "0x1857A9620")]
		get
		{
			return default(JGBCGHMDEIJ);
		}
		[Cpp2IlInjected.Token(Token = "0x600033A")]
		[Cpp2IlInjected.Address(RVA = "0x57A9800", Offset = "0x57A8C00", VA = "0x1857A9800")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000338")]
	[Cpp2IlInjected.Address(RVA = "0x57A9C70", Offset = "0x57A9070", VA = "0x1857A9C70")]
	public ACPOBIBHKIB(NCOEFPHLCKK IILFNNEDNCJ, in JCAJMGPJNDN HIDEHJGLNHO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600033B")]
	[Cpp2IlInjected.Address(RVA = "0x57A9BB0", Offset = "0x57A8FB0", VA = "0x1857A9BB0", Slot = "6")]
	public void PBJONABJOBO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600033C")]
	[Cpp2IlInjected.Address(RVA = "0x57A9380", Offset = "0x57A8780", VA = "0x1857A9380")]
	private bool BPCPFBNLLLH()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600033D")]
	[Cpp2IlInjected.Address(RVA = "0x57A9280", Offset = "0x57A8680", VA = "0x1857A9280", Slot = "7")]
	public void BBPFDNFCENP(object MIFCLBEAOPM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600033E")]
	[Cpp2IlInjected.Address(RVA = "0x57A9700", Offset = "0x57A8B00", VA = "0x1857A9700", Slot = "8")]
	public void JDDFJPPACKN(object MIFCLBEAOPM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600033F")]
	[Cpp2IlInjected.Address(RVA = "0x57A9510", Offset = "0x57A8910", VA = "0x1857A9510", Slot = "11")]
	public void EKFOLENAMJE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000340")]
	[Cpp2IlInjected.Address(RVA = "0x57A9A80", Offset = "0x57A8E80", VA = "0x1857A9A80")]
	private void NLCICEBEBHM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000341")]
	[Cpp2IlInjected.Address(RVA = "0x57A9930", Offset = "0x57A8D30", VA = "0x1857A9930")]
	private void LPEGKOLKNAO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000342")]
	[Cpp2IlInjected.Address(RVA = "0x57A98F0", Offset = "0x57A8CF0", VA = "0x1857A98F0", Slot = "10")]
	public void KONHDGEMJBN(NCOEFPHLCKK IILFNNEDNCJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000343")]
	[Cpp2IlInjected.Address(RVA = "0x57A9B70", Offset = "0x57A8F70", VA = "0x1857A9B70", Slot = "9")]
	public void OKPPPAGPECC(NCOEFPHLCKK IILFNNEDNCJ)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000037")]
internal sealed class HOCAEFIHPFJ : LPHFOFKHCNE, KGDABPANOEG
{
	[Cpp2IlInjected.Token(Token = "0x170000DC")]
	public bool FAJNDFDCOGA
	{
		[Cpp2IlInjected.Token(Token = "0x6000346")]
		[Cpp2IlInjected.Address(RVA = "0x57B6C40", Offset = "0x57B6040", VA = "0x1857B6C40", Slot = "6")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000DD")]
	public IEnumerable<object> OPBNFDMBOBA
	{
		[Cpp2IlInjected.Token(Token = "0x6000347")]
		[Cpp2IlInjected.Address(RVA = "0x57B6A00", Offset = "0x57B5E00", VA = "0x1857B6A00", Slot = "7")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000DE")]
	private bool JAGHPILGEHA
	{
		[Cpp2IlInjected.Token(Token = "0x6000348")]
		[Cpp2IlInjected.Address(RVA = "0x57B6D00", Offset = "0x57B6100", VA = "0x1857B6D00")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000035")]
	public event DGAAFHCPHEH KOKLFFIBABB
	{
		[Cpp2IlInjected.Token(Token = "0x6000344")]
		[Cpp2IlInjected.Address(RVA = "0x57B6AF0", Offset = "0x57B5EF0", VA = "0x1857B6AF0", Slot = "4")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000345")]
		[Cpp2IlInjected.Address(RVA = "0x57B6BA0", Offset = "0x57B5FA0", VA = "0x1857B6BA0", Slot = "5")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000349")]
	[Cpp2IlInjected.Address(RVA = "0x57AC240", Offset = "0x57AB640", VA = "0x1857AC240")]
	public HOCAEFIHPFJ(NCOEFPHLCKK IILFNNEDNCJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600034A")]
	[Cpp2IlInjected.Address(RVA = "0x57B69A0", Offset = "0x57B5DA0", VA = "0x1857B69A0", Slot = "11")]
	public IDisposable EBMGEFKJGJE()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600034B")]
	[Cpp2IlInjected.Address(RVA = "0x57B6B90", Offset = "0x57B5F90", VA = "0x1857B6B90", Slot = "8")]
	public void LDMPNKDCNKH(object MIFCLBEAOPM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600034C")]
	[Cpp2IlInjected.Address(RVA = "0x57B6AE0", Offset = "0x57B5EE0", VA = "0x1857B6AE0", Slot = "9")]
	public void FGAHJAEMBHA(object MIFCLBEAOPM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600034D")]
	[Cpp2IlInjected.Address(RVA = "0x57B6E10", Offset = "0x57B6210", VA = "0x1857B6E10", Slot = "10")]
	public void PNGKMLMJNAK(object MIFCLBEAOPM, bool KLMBPMINIHN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600034E")]
	[Cpp2IlInjected.Address(RVA = "0x57B6930", Offset = "0x57B5D30", VA = "0x1857B6930", Slot = "12")]
	public void BOFMJFDPNBF(Rigidbody HKPNCKPHHLB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600034F")]
	[Cpp2IlInjected.Address(RVA = "0x57B6DE0", Offset = "0x57B61E0", VA = "0x1857B6DE0", Slot = "13")]
	public void PKFCGBCFJGD(Rigidbody GHAGIOLHPMN)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000038")]
internal sealed class HJIMEIEFNLL : LPHFOFKHCNE, INNKCACPKLA, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000055")]
	private PhotonView NIHEFIPHFDI;

	[Cpp2IlInjected.Token(Token = "0x170000DF")]
	public bool BBHAHOHMEPG
	{
		[Cpp2IlInjected.Token(Token = "0x6000352")]
		[Cpp2IlInjected.Address(RVA = "0x57B4D80", Offset = "0x57B4180", VA = "0x1857B4D80", Slot = "6")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000E0")]
	public bool MPDIPBBGKKB
	{
		[Cpp2IlInjected.Token(Token = "0x6000353")]
		[Cpp2IlInjected.Address(RVA = "0x57B55A0", Offset = "0x57B49A0", VA = "0x1857B55A0", Slot = "7")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000036")]
	public event DGAAFHCPHEH DELNFHCFIKO
	{
		[Cpp2IlInjected.Token(Token = "0x6000350")]
		[Cpp2IlInjected.Address(RVA = "0x57B56B0", Offset = "0x57B4AB0", VA = "0x1857B56B0", Slot = "4")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000351")]
		[Cpp2IlInjected.Address(RVA = "0x57B4CE0", Offset = "0x57B40E0", VA = "0x1857B4CE0", Slot = "5")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000354")]
	[Cpp2IlInjected.Address(RVA = "0x57B5BD0", Offset = "0x57B4FD0", VA = "0x1857B5BD0")]
	public HJIMEIEFNLL(NCOEFPHLCKK IILFNNEDNCJ, in JCAJMGPJNDN HIDEHJGLNHO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000355")]
	[Cpp2IlInjected.Address(RVA = "0x57B58B0", Offset = "0x57B4CB0", VA = "0x1857B58B0", Slot = "8")]
	public void PBJONABJOBO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000356")]
	[Cpp2IlInjected.Address(RVA = "0x57B4DA0", Offset = "0x57B41A0", VA = "0x1857B4DA0", Slot = "11")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000357")]
	[Cpp2IlInjected.Address(RVA = "0x57B5390", Offset = "0x57B4790", VA = "0x1857B5390", Slot = "9")]
	public void FPAGIJPELCJ(NCOEFPHLCKK GGEKFPEBLKN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000358")]
	[Cpp2IlInjected.Address(RVA = "0x57B4F90", Offset = "0x57B4390", VA = "0x1857B4F90", Slot = "10")]
	public void EDIJKBDKKBN(NCOEFPHLCKK GGEKFPEBLKN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000359")]
	[Cpp2IlInjected.Address(RVA = "0x57B51A0", Offset = "0x57B45A0", VA = "0x1857B51A0")]
	private void FHAIJPNFBDJ(PhotonView CCKCOJFPKNL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600035A")]
	[Cpp2IlInjected.Address(RVA = "0x57B5750", Offset = "0x57B4B50", VA = "0x1857B5750")]
	private void NMOCGHMFIDJ(RigidbodyEx HLCKNLLPKKO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600035B")]
	[Cpp2IlInjected.Address(RVA = "0x57B5A00", Offset = "0x57B4E00", VA = "0x1857B5A00")]
	private void PDFJNKCICEB(PhotonView FGIJLKAFKLI)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000039")]
internal static class EIPKGBFBKEI
{
	[Cpp2IlInjected.Token(Token = "0x600035C")]
	[Cpp2IlInjected.Address(RVA = "0x57B00F0", Offset = "0x57AF4F0", VA = "0x1857B00F0")]
	public static HJIMEIEFNLL PFFJAHDNLIN(this PLOEBEDJGLE NLKDOMNEDBE)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200003A")]
internal sealed class MFPJGFBMPCG : LPHFOFKHCNE, IKFALNBDADN
{
	[Cpp2IlInjected.Token(Token = "0x170000E1")]
	public bool KHDKIPLIJCN
	{
		[Cpp2IlInjected.Token(Token = "0x600035D")]
		[Cpp2IlInjected.Address(RVA = "0x57C39E0", Offset = "0x57C2DE0", VA = "0x1857C39E0", Slot = "4")]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x600035E")]
		[Cpp2IlInjected.Address(RVA = "0x57C37F0", Offset = "0x57C2BF0", VA = "0x1857C37F0", Slot = "5")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000E2")]
	public bool ILHHOPCAOME
	{
		[Cpp2IlInjected.Token(Token = "0x600035F")]
		[Cpp2IlInjected.Address(RVA = "0x57C3630", Offset = "0x57C2A30", VA = "0x1857C3630", Slot = "6")]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000360")]
		[Cpp2IlInjected.Address(RVA = "0x57C3540", Offset = "0x57C2940", VA = "0x1857C3540")]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000E3")]
	public RigidbodyConstraints AOEOJAJAPKL
	{
		[Cpp2IlInjected.Token(Token = "0x6000361")]
		[Cpp2IlInjected.Address(RVA = "0x57C3710", Offset = "0x57C2B10", VA = "0x1857C3710", Slot = "7")]
		get
		{
			return default(RigidbodyConstraints);
		}
		[Cpp2IlInjected.Token(Token = "0x6000362")]
		[Cpp2IlInjected.Address(RVA = "0x57C3AC0", Offset = "0x57C2EC0", VA = "0x1857C3AC0", Slot = "8")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000363")]
	[Cpp2IlInjected.Address(RVA = "0x57C3CC0", Offset = "0x57C30C0", VA = "0x1857C3CC0")]
	public MFPJGFBMPCG(NCOEFPHLCKK IILFNNEDNCJ, in JCAJMGPJNDN HIDEHJGLNHO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000364")]
	[Cpp2IlInjected.Address(RVA = "0x57C3440", Offset = "0x57C2840", VA = "0x1857C3440", Slot = "9")]
	public void BOFMJFDPNBF(Rigidbody GHAGIOLHPMN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000365")]
	[Cpp2IlInjected.Address(RVA = "0x57C38E0", Offset = "0x57C2CE0", VA = "0x1857C38E0", Slot = "10")]
	public void PKFCGBCFJGD(Rigidbody GHAGIOLHPMN)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200003B")]
internal sealed class EODIHAMODMJ : LPHFOFKHCNE, CAONNBLCKEG
{
	[Cpp2IlInjected.Token(Token = "0x170000E4")]
	public float PGABAKFPNBB
	{
		[Cpp2IlInjected.Token(Token = "0x6000367")]
		[Cpp2IlInjected.Address(RVA = "0x57B06C0", Offset = "0x57AFAC0", VA = "0x1857B06C0", Slot = "4")]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x6000368")]
		[Cpp2IlInjected.Address(RVA = "0x57B0320", Offset = "0x57AF720", VA = "0x1857B0320", Slot = "5")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000E5")]
	public float DCNFDLOMNCM
	{
		[Cpp2IlInjected.Token(Token = "0x6000369")]
		[Cpp2IlInjected.Address(RVA = "0x57B07A0", Offset = "0x57AFBA0", VA = "0x1857B07A0", Slot = "6")]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x600036A")]
		[Cpp2IlInjected.Address(RVA = "0x57B04F0", Offset = "0x57AF8F0", VA = "0x1857B04F0", Slot = "7")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000366")]
	[Cpp2IlInjected.Address(RVA = "0x57AC240", Offset = "0x57AB640", VA = "0x1857AC240")]
	public EODIHAMODMJ(NCOEFPHLCKK IILFNNEDNCJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600036B")]
	[Cpp2IlInjected.Address(RVA = "0x57B0150", Offset = "0x57AF550", VA = "0x1857B0150", Slot = "8")]
	public void BOFMJFDPNBF(Rigidbody GHAGIOLHPMN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600036C")]
	[Cpp2IlInjected.Address(RVA = "0x57B0880", Offset = "0x57AFC80", VA = "0x1857B0880", Slot = "9")]
	public void PKFCGBCFJGD(Rigidbody GHAGIOLHPMN)
	{
	}
}
namespace RecRoom.Rbex.ObjectModel
{
	[Cpp2IlInjected.Token(Token = "0x200003C")]
	[HAMPPOKOPOP(typeof(NKLBMAPECJD), new string[] { })]
	[JEGJCCBDMOE(OLCAJGBKOGB.Physics)]
	public sealed class RbexServiceCallbacks : GBCNOEIKEOL, NKLBMAPECJD, IDisposable
	{
		[Cpp2IlInjected.Token(Token = "0x4000056")]
		private static readonly KLBHBMBPLOA JFFPIFJCILI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000057")]
		private ABGDBOLFPHD IILFNNEDNCJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000058")]
		private bool FCPODLMHINC;

		[Cpp2IlInjected.Token(Token = "0x170000E6")]
		public bool AMOPNJPCIDE
		{
			[Cpp2IlInjected.Token(Token = "0x600036F")]
			[Cpp2IlInjected.Address(RVA = "0x72F260", Offset = "0x72E660", VA = "0x18072F260", Slot = "5")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600036D")]
		[Cpp2IlInjected.Address(RVA = "0x69A39F0", Offset = "0x69A2DF0", VA = "0x1869A39F0", Slot = "4")]
		public void FLFPICJOFML(FJEOEPCCLME JGMMDACFJLC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600036E")]
		[Cpp2IlInjected.Address(RVA = "0x69A39C0", Offset = "0x69A2DC0", VA = "0x1869A39C0", Slot = "7")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000370")]
		[Cpp2IlInjected.Address(RVA = "0x69A3A40", Offset = "0x69A2E40", VA = "0x1869A3A40", Slot = "6")]
		public void HCPEECAOGOM(MBEDCJLMHEO LKHNLAILFFL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000371")]
		[Cpp2IlInjected.Address(RVA = "0x72E810", Offset = "0x72DC10", VA = "0x18072E810")]
		public RbexServiceCallbacks()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200003D")]
internal sealed class GJAKHGNMFAD : LPHFOFKHCNE, EIMJIHNCMHI
{
	[Cpp2IlInjected.Token(Token = "0x4000059")]
	public const int BODIPJBOABD = 10;

	[Cpp2IlInjected.Token(Token = "0x400005A")]
	public const float LEOMFFLEOJP = 9E-05f;

	[Cpp2IlInjected.Token(Token = "0x400005B")]
	public const float GJBNLKILOFJ = 0.0001f;

	[Cpp2IlInjected.Token(Token = "0x400005C")]
	public const float MDELHFJODGE = 5f;

	[Cpp2IlInjected.Token(Token = "0x170000E7")]
	private Rigidbody LNMDHFKNJIH
	{
		[Cpp2IlInjected.Token(Token = "0x6000375")]
		[Cpp2IlInjected.Address(RVA = "0x57AB800", Offset = "0x57AAC00", VA = "0x1857AB800")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000E8")]
	private bool HBCBGANJMHF
	{
		[Cpp2IlInjected.Token(Token = "0x6000376")]
		[Cpp2IlInjected.Address(RVA = "0x57B1400", Offset = "0x57B0800", VA = "0x1857B1400")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000E9")]
	private bool LFGDELENJCM
	{
		[Cpp2IlInjected.Token(Token = "0x6000377")]
		[Cpp2IlInjected.Address(RVA = "0x57AF160", Offset = "0x57AE560", VA = "0x1857AF160")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000EA")]
	private NCOEFPHLCKK GKEMABFNEME
	{
		[Cpp2IlInjected.Token(Token = "0x6000378")]
		[Cpp2IlInjected.Address(RVA = "0x57B1800", Offset = "0x57B0C00", VA = "0x1857B1800")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000EB")]
	private bool KMDIPAOGGGF
	{
		[Cpp2IlInjected.Token(Token = "0x6000379")]
		[Cpp2IlInjected.Address(RVA = "0x57B1580", Offset = "0x57B0980", VA = "0x1857B1580")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000EC")]
	private bool FHNFDKLFDEC
	{
		[Cpp2IlInjected.Token(Token = "0x600037A")]
		[Cpp2IlInjected.Address(RVA = "0x57B14A0", Offset = "0x57B08A0", VA = "0x1857B14A0")]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x600037B")]
		[Cpp2IlInjected.Address(RVA = "0x57B0BD0", Offset = "0x57AFFD0", VA = "0x1857B0BD0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000ED")]
	private bool OBAKHFEALOJ
	{
		[Cpp2IlInjected.Token(Token = "0x600037C")]
		[Cpp2IlInjected.Address(RVA = "0x57B0CC0", Offset = "0x57B00C0", VA = "0x1857B0CC0")]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x600037D")]
		[Cpp2IlInjected.Address(RVA = "0x57B1310", Offset = "0x57B0710", VA = "0x1857B1310")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000EE")]
	private int BIDOOJBIHGP
	{
		[Cpp2IlInjected.Token(Token = "0x600037E")]
		[Cpp2IlInjected.Address(RVA = "0x57B1230", Offset = "0x57B0630", VA = "0x1857B1230")]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x600037F")]
		[Cpp2IlInjected.Address(RVA = "0x57B0F50", Offset = "0x57B0350", VA = "0x1857B0F50")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000037")]
	public event DGAAFHCPHEH BGFDOMIHHPL
	{
		[Cpp2IlInjected.Token(Token = "0x6000373")]
		[Cpp2IlInjected.Address(RVA = "0x57B1870", Offset = "0x57B0C70", VA = "0x1857B1870", Slot = "4")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000374")]
		[Cpp2IlInjected.Address(RVA = "0x57B1040", Offset = "0x57B0440", VA = "0x1857B1040", Slot = "5")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000380")]
	[Cpp2IlInjected.Address(RVA = "0x57B1B60", Offset = "0x57B0F60", VA = "0x1857B1B60")]
	public GJAKHGNMFAD(NCOEFPHLCKK IILFNNEDNCJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000381")]
	[Cpp2IlInjected.Address(RVA = "0x57B1910", Offset = "0x57B0D10", VA = "0x1857B1910", Slot = "6")]
	public void PBJONABJOBO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000382")]
	[Cpp2IlInjected.Address(RVA = "0x57B1860", Offset = "0x57B0C60", VA = "0x1857B1860", Slot = "8")]
	public void NKFCECIGMAG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000383")]
	[Cpp2IlInjected.Address(RVA = "0x57B15E0", Offset = "0x57B09E0", VA = "0x1857B15E0", Slot = "7")]
	public bool NEPEFPHIELC()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000384")]
	[Cpp2IlInjected.Address(RVA = "0x57B1AB0", Offset = "0x57B0EB0", VA = "0x1857B1AB0", Slot = "9")]
	public void PKFLOCAHJCK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000385")]
	[Cpp2IlInjected.Address(RVA = "0x57B1A70", Offset = "0x57B0E70", VA = "0x1857B1A70", Slot = "12")]
	public void PHLPAOAPADB(bool DFLJHGHEKJD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000386")]
	[Cpp2IlInjected.Address(RVA = "0x57B19C0", Offset = "0x57B0DC0", VA = "0x1857B19C0", Slot = "11")]
	public void PFPLFILECPI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000387")]
	[Cpp2IlInjected.Address(RVA = "0x72E830", Offset = "0x72DC30", VA = "0x18072E830", Slot = "10")]
	public void LMCNKOCFNJH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000388")]
	[Cpp2IlInjected.Address(RVA = "0x57B0DA0", Offset = "0x57B01A0", VA = "0x1857B0DA0")]
	private bool BEIPPJFGNKI()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000389")]
	[Cpp2IlInjected.Address(RVA = "0x57B10E0", Offset = "0x57B04E0", VA = "0x1857B10E0")]
	private void GKLPFICFPDE()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200003E")]
internal sealed class JOCMIJIKNOI : LPHFOFKHCNE, IPANMLAMAAD
{
	[Cpp2IlInjected.Token(Token = "0x400005E")]
	private const string EKLCKOGJHLL = "RBEX_ANIM";

	[Cpp2IlInjected.Token(Token = "0x170000EF")]
	public Rigidbody LNMDHFKNJIH
	{
		[Cpp2IlInjected.Token(Token = "0x600038A")]
		[Cpp2IlInjected.Address(RVA = "0x57BEA60", Offset = "0x57BDE60", VA = "0x1857BEA60", Slot = "4")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600038B")]
		[Cpp2IlInjected.Address(RVA = "0x57BEE00", Offset = "0x57BE200", VA = "0x1857BEE00")]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000F0")]
	private bool KMDIPAOGGGF
	{
		[Cpp2IlInjected.Token(Token = "0x600038C")]
		[Cpp2IlInjected.Address(RVA = "0x57ABD50", Offset = "0x57AB150", VA = "0x1857ABD50")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600038D")]
	[Cpp2IlInjected.Address(RVA = "0x57BF0A0", Offset = "0x57BE4A0", VA = "0x1857BF0A0")]
	public JOCMIJIKNOI(NCOEFPHLCKK IILFNNEDNCJ, in JCAJMGPJNDN HIDEHJGLNHO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600038E")]
	[Cpp2IlInjected.Address(RVA = "0x57BEFF0", Offset = "0x57BE3F0", VA = "0x1857BEFF0", Slot = "5")]
	public void PBJONABJOBO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600038F")]
	[Cpp2IlInjected.Address(RVA = "0x57BEEF0", Offset = "0x57BE2F0", VA = "0x1857BEEF0", Slot = "6")]
	public void KPOLANLNJJI(object MIFCLBEAOPM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000390")]
	[Cpp2IlInjected.Address(RVA = "0x57BEB40", Offset = "0x57BDF40", VA = "0x1857BEB40", Slot = "7")]
	public void HIBCGDMOODJ(object MIFCLBEAOPM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000391")]
	[Cpp2IlInjected.Address(RVA = "0x57BE1B0", Offset = "0x57BD5B0", VA = "0x1857BE1B0", Slot = "8")]
	public void EDEILOABNOJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000392")]
	[Cpp2IlInjected.Address(RVA = "0x57BE630", Offset = "0x57BDA30", VA = "0x1857BE630", Slot = "9")]
	public void EONBBMLLGPB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000393")]
	[Cpp2IlInjected.Address(RVA = "0x57BE890", Offset = "0x57BDC90", VA = "0x1857BE890", Slot = "10")]
	public void FDIDMCANFME()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000394")]
	[Cpp2IlInjected.Address(RVA = "0x72E830", Offset = "0x72DC30", VA = "0x18072E830", Slot = "11")]
	public void IKMAJMOKAJI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000395")]
	[Cpp2IlInjected.Address(RVA = "0x57BE470", Offset = "0x57BD870", VA = "0x1857BE470")]
	private void EOLCGNDNPBO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000396")]
	[Cpp2IlInjected.Address(RVA = "0x57BEC40", Offset = "0x57BE040", VA = "0x1857BEC40")]
	private void KAMMGDNLJDL()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200003F")]
internal sealed class DJFIPOGEBKP : LPHFOFKHCNE, ODMDEDICELM, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x170000F1")]
	public EKLLOLLHLDP LNMCPLFHCHG
	{
		[Cpp2IlInjected.Token(Token = "0x6000397")]
		[Cpp2IlInjected.Address(RVA = "0x57AFDF0", Offset = "0x57AF1F0", VA = "0x1857AFDF0", Slot = "4")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000398")]
		[Cpp2IlInjected.Address(RVA = "0x57AD0F0", Offset = "0x57AC4F0", VA = "0x1857AD0F0", Slot = "5")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000F2")]
	public CHACNCJIDJM GJHPEGFOAME
	{
		[Cpp2IlInjected.Token(Token = "0x6000399")]
		[Cpp2IlInjected.Address(RVA = "0x57ACE30", Offset = "0x57AC230", VA = "0x1857ACE30", Slot = "6")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600039A")]
		[Cpp2IlInjected.Address(RVA = "0x57AE1E0", Offset = "0x57AD5E0", VA = "0x1857AE1E0", Slot = "7")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000F3")]
	public Vector3 LGEGEJPPDAD
	{
		[Cpp2IlInjected.Token(Token = "0x600039B")]
		[Cpp2IlInjected.Address(RVA = "0x57ACB10", Offset = "0x57ABF10", VA = "0x1857ACB10", Slot = "8")]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x600039C")]
		[Cpp2IlInjected.Address(RVA = "0x57AD330", Offset = "0x57AC730", VA = "0x1857AD330", Slot = "9")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000F4")]
	public Vector3 JBHIDAJMGMM
	{
		[Cpp2IlInjected.Token(Token = "0x600039D")]
		[Cpp2IlInjected.Address(RVA = "0x57AE900", Offset = "0x57ADD00", VA = "0x1857AE900", Slot = "10")]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x600039E")]
		[Cpp2IlInjected.Address(RVA = "0x57ADA20", Offset = "0x57ACE20", VA = "0x1857ADA20", Slot = "11")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000F5")]
	public Vector3 LJMFIEJCGLD
	{
		[Cpp2IlInjected.Token(Token = "0x600039F")]
		[Cpp2IlInjected.Address(RVA = "0x57AD1E0", Offset = "0x57AC5E0", VA = "0x1857AD1E0", Slot = "12")]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x60003A0")]
		[Cpp2IlInjected.Address(RVA = "0x57ACD70", Offset = "0x57AC170", VA = "0x1857ACD70", Slot = "13")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000F6")]
	public Vector3 ICEKJCBHJBH
	{
		[Cpp2IlInjected.Token(Token = "0x60003A1")]
		[Cpp2IlInjected.Address(RVA = "0x57AEBD0", Offset = "0x57ADFD0", VA = "0x1857AEBD0", Slot = "14")]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x60003A2")]
		[Cpp2IlInjected.Address(RVA = "0x57AEB30", Offset = "0x57ADF30", VA = "0x1857AEB30", Slot = "15")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000F7")]
	public float KKALKPOINCB
	{
		[Cpp2IlInjected.Token(Token = "0x60003A3")]
		[Cpp2IlInjected.Address(RVA = "0x57AD3F0", Offset = "0x57AC7F0", VA = "0x1857AD3F0", Slot = "16")]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x60003A4")]
		[Cpp2IlInjected.Address(RVA = "0x57AD820", Offset = "0x57ACC20", VA = "0x1857AD820", Slot = "17")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000F8")]
	public bool LIGEJEKODFL
	{
		[Cpp2IlInjected.Token(Token = "0x60003A6")]
		[Cpp2IlInjected.Address(RVA = "0x57AEA50", Offset = "0x57ADE50", VA = "0x1857AEA50", Slot = "18")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000F9")]
	private BDJOPHNNEJG AODMDOCLCLA
	{
		[Cpp2IlInjected.Token(Token = "0x60003BA")]
		[Cpp2IlInjected.Address(RVA = "0x1C55DF0", Offset = "0x1C551F0", VA = "0x181C55DF0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000FA")]
	private bool LFGDELENJCM
	{
		[Cpp2IlInjected.Token(Token = "0x60003BB")]
		[Cpp2IlInjected.Address(RVA = "0x57AF160", Offset = "0x57AE560", VA = "0x1857AF160")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60003A5")]
	[Cpp2IlInjected.Address(RVA = "0x57AC240", Offset = "0x57AB640", VA = "0x1857AC240")]
	public DJFIPOGEBKP(NCOEFPHLCKK IILFNNEDNCJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003A7")]
	[Cpp2IlInjected.Address(RVA = "0x57AF070", Offset = "0x57AE470", VA = "0x1857AF070", Slot = "20")]
	public void KNFJENEFGIE(object MIFCLBEAOPM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003A8")]
	[Cpp2IlInjected.Address(RVA = "0x57AF180", Offset = "0x57AE580", VA = "0x1857AF180", Slot = "31")]
	public void NEMGEGCJOPN(object MIFCLBEAOPM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003A9")]
	[Cpp2IlInjected.Address(RVA = "0x57AEB60", Offset = "0x57ADF60", VA = "0x1857AEB60", Slot = "19")]
	public void PBJONABJOBO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003AA")]
	[Cpp2IlInjected.Address(RVA = "0x57AD6F0", Offset = "0x57ACAF0", VA = "0x1857AD6F0", Slot = "37")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003AB")]
	[Cpp2IlInjected.Address(RVA = "0x57AD0B0", Offset = "0x57AC4B0", VA = "0x1857AD0B0", Slot = "28")]
	public void BOFMJFDPNBF(Rigidbody GHAGIOLHPMN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003AC")]
	[Cpp2IlInjected.Address(RVA = "0x57AC930", Offset = "0x57ABD30", VA = "0x1857AC930", Slot = "36")]
	public Vector3 AFFCJBHNNJL(Vector3 JOJEMOKKGPP)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x60003AD")]
	[Cpp2IlInjected.Address(RVA = "0x57AEEB0", Offset = "0x57AE2B0", VA = "0x1857AEEB0", Slot = "35")]
	public Vector3 KIKKEDPKAKK(Vector3 HMPFDEAFPND)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x60003AE")]
	[Cpp2IlInjected.Address(RVA = "0x57AEB60", Offset = "0x57ADF60", VA = "0x1857AEB60", Slot = "27")]
	public void INLPOAEPJGG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003AF")]
	[Cpp2IlInjected.Address(RVA = "0x57AD070", Offset = "0x57AC470", VA = "0x1857AD070", Slot = "25")]
	public void BHDNAPGFIPJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003B0")]
	[Cpp2IlInjected.Address(RVA = "0x57AEA10", Offset = "0x57ADE10", VA = "0x1857AEA10", Slot = "24")]
	public void IFMLGPGPJDO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003B1")]
	[Cpp2IlInjected.Address(RVA = "0x57AF270", Offset = "0x57AE670", VA = "0x1857AF270", Slot = "34")]
	public void NGFKLMPAGOE(Vector3 GKKEEHNMPBL, Vector3 NFGPCLPNMJK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003B2")]
	[Cpp2IlInjected.Address(RVA = "0x57AECF0", Offset = "0x57AE0F0", VA = "0x1857AECF0", Slot = "33")]
	public void JLDEEBLCKGA(Vector3 FHKLDEIKECB, Vector3 FHFHNDANMPN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003B3")]
	[Cpp2IlInjected.Address(RVA = "0x57AED50", Offset = "0x57AE150", VA = "0x1857AED50", Slot = "32")]
	public void KIIDBBLBANB(Vector3 JDDALKKDLNA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003B4")]
	[Cpp2IlInjected.Address(RVA = "0x57ADB40", Offset = "0x57ACF40", VA = "0x1857ADB40", Slot = "22")]
	public void HHAFJJGJPFB(EECECFKKEJP KMDODPJBKLE, Vector3 CFLMAEMNHKL, float ABGPHLFIFAO, float OPCFMELHIKJ = 8f, float ECOHALOPPDN = 1f)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003B5")]
	[Cpp2IlInjected.Address(RVA = "0x57ADFB0", Offset = "0x57AD3B0", VA = "0x1857ADFB0", Slot = "21")]
	public void HHLJBCNAEPM(JDHBHPOMECG EFAKAOJPAJJ, Vector3 PKAJMBKNJIL, float KBLOKDLNEPD = float.PositiveInfinity)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003B6")]
	[Cpp2IlInjected.Address(RVA = "0x57AE630", Offset = "0x57ADA30", VA = "0x1857AE630", Slot = "23")]
	[Obsolete]
	public void IALNLOAFGMK(JDHBHPOMECG EFAKAOJPAJJ, Vector3 IHCJBCJFELL, float MEJPNNANPLH = 7f, float CKIIILKMBKK = 1f)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003B7")]
	[Cpp2IlInjected.Address(RVA = "0x57AD630", Offset = "0x57ACA30", VA = "0x1857AD630", Slot = "30")]
	public Vector3 DNICIBAAMCG(Vector3 GCAABCBBBAL)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x60003B8")]
	[Cpp2IlInjected.Address(RVA = "0x57ADA50", Offset = "0x57ACE50", VA = "0x1857ADA50", Slot = "29")]
	public Vector3 GJAHBCCOAII(Vector3 DIIFLOBFBLO)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x60003B9")]
	[Cpp2IlInjected.Address(RVA = "0x57AD8F0", Offset = "0x57ACCF0", VA = "0x1857AD8F0", Slot = "26")]
	public void EPOKPKAANHO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003BC")]
	[Cpp2IlInjected.Address(RVA = "0x57AFF20", Offset = "0x57AF320", VA = "0x1857AFF20")]
	private void PPEMJOPAMJI(float LPJDDLMPNCG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003BD")]
	[Cpp2IlInjected.Address(RVA = "0x57AD4D0", Offset = "0x57AC8D0", VA = "0x1857AD4D0")]
	private void DKLBMGLGABJ(Vector3 PKAJMBKNJIL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003BE")]
	[Cpp2IlInjected.Address(RVA = "0x57ACC60", Offset = "0x57AC060", VA = "0x1857ACC60")]
	private Vector3 AIPGGJCOIBK()
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x60003BF")]
	[Cpp2IlInjected.Address(RVA = "0x57AF4B0", Offset = "0x57AE8B0", VA = "0x1857AF4B0")]
	private void OIMGBAHMGOG(Vector3 HMPFDEAFPND)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003C0")]
	[Cpp2IlInjected.Address(RVA = "0x57ACF60", Offset = "0x57AC360", VA = "0x1857ACF60")]
	private Vector3 BGJJOBCDBBC()
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x60003C1")]
	[Cpp2IlInjected.Address(RVA = "0x57AE2D0", Offset = "0x57AD6D0", VA = "0x1857AE2D0")]
	private void HOGMIBAAANA(Vector3 LPJDDLMPNCG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003C2")]
	[Cpp2IlInjected.Address(RVA = "0x57AF7F0", Offset = "0x57AEBF0", VA = "0x1857AF7F0")]
	private void OPKJDBGLKOE(Vector3 HMPFDEAFPND)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003C3")]
	[Cpp2IlInjected.Address(RVA = "0x57AD830", Offset = "0x57ACC30", VA = "0x1857AD830")]
	private void EKIKIKBLFAP()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000040")]
internal class LPHFOFKHCNE
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400005F")]
	protected readonly KNGEGNFMEDP IILFNNEDNCJ;

	[Cpp2IlInjected.Token(Token = "0x170000FB")]
	protected ABGDBOLFPHD IGNBGAICHNF
	{
		[Cpp2IlInjected.Token(Token = "0x60003C4")]
		[Cpp2IlInjected.Address(RVA = "0x56E6600", Offset = "0x56E5A00", VA = "0x1856E6600")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000FC")]
	protected MBEDCJLMHEO BEFNGGLNHMI
	{
		[Cpp2IlInjected.Token(Token = "0x60003C5")]
		[Cpp2IlInjected.Address(RVA = "0x57C3300", Offset = "0x57C2700", VA = "0x1857C3300")]
		get
		{
			return default(MBEDCJLMHEO);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60003C6")]
	[Cpp2IlInjected.Address(RVA = "0x57AC240", Offset = "0x57AB640", VA = "0x1857AC240")]
	public LPHFOFKHCNE(NCOEFPHLCKK IILFNNEDNCJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003C7")]
	[Cpp2IlInjected.Address(RVA = "0x57C31E0", Offset = "0x57C25E0", VA = "0x1857C31E0")]
	protected NCOEFPHLCKK AEPMGFDGAMM(MBEDCJLMHEO LMLBLIDPKCN)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000041")]
public class KCDDPFPGDON : CCKADDACLBD
{
	[Cpp2IlInjected.Token(Token = "0x60003C8")]
	[Cpp2IlInjected.Address(RVA = "0x57C0680", Offset = "0x57BFA80", VA = "0x1857C0680", Slot = "4")]
	public PLDJMDIFCKE HPIEMLILMFL(NCOEFPHLCKK NLKDOMNEDBE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003C9")]
	[Cpp2IlInjected.Address(RVA = "0x57C07F0", Offset = "0x57BFBF0", VA = "0x1857C07F0", Slot = "5")]
	public ODMDEDICELM IINCPPFHAME(NCOEFPHLCKK NLKDOMNEDBE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003CA")]
	[Cpp2IlInjected.Address(RVA = "0x57C0D70", Offset = "0x57C0170", VA = "0x1857C0D70", Slot = "6")]
	public IMBEMHENMNJ MOJGNMKJFLF(NCOEFPHLCKK NLKDOMNEDBE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003CB")]
	[Cpp2IlInjected.Address(RVA = "0x57C0890", Offset = "0x57BFC90", VA = "0x1857C0890", Slot = "7")]
	public CAONNBLCKEG ILCPDNKDAKJ(NCOEFPHLCKK NLKDOMNEDBE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003CC")]
	[Cpp2IlInjected.Address(RVA = "0x57C0AE0", Offset = "0x57BFEE0", VA = "0x1857C0AE0", Slot = "8")]
	public EIMJIHNCMHI KJNNEGNLPCG(NCOEFPHLCKK NLKDOMNEDBE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003CD")]
	[Cpp2IlInjected.Address(RVA = "0x57C09A0", Offset = "0x57BFDA0", VA = "0x1857C09A0", Slot = "9")]
	public JBCOLILENLD JDEHAKBEPFB(NCOEFPHLCKK NLKDOMNEDBE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003CE")]
	[Cpp2IlInjected.Address(RVA = "0x57C03C0", Offset = "0x57BF7C0", VA = "0x1857C03C0", Slot = "10")]
	public KGDABPANOEG CLMAKHLOHMN(NCOEFPHLCKK NLKDOMNEDBE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003CF")]
	[Cpp2IlInjected.Address(RVA = "0x57C0B40", Offset = "0x57BFF40", VA = "0x1857C0B40", Slot = "11")]
	public BDJOPHNNEJG LAGKMHIIGOF(NCOEFPHLCKK NLKDOMNEDBE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003D0")]
	[Cpp2IlInjected.Address(RVA = "0x57C0A40", Offset = "0x57BFE40", VA = "0x1857C0A40", Slot = "12")]
	public AIOOGANOGPH JNMPFOJECMI(NCOEFPHLCKK NLKDOMNEDBE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003D1")]
	[Cpp2IlInjected.Address(RVA = "0x57C0520", Offset = "0x57BF920", VA = "0x1857C0520", Slot = "13")]
	public BBGAPPNBFLO DPGNNNONAOD(NCOEFPHLCKK NLKDOMNEDBE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003D2")]
	[Cpp2IlInjected.Address(RVA = "0x57C0460", Offset = "0x57BF860", VA = "0x1857C0460")]
	public IPANMLAMAAD MNBKDOEPCLE(NCOEFPHLCKK NLKDOMNEDBE, in JCAJMGPJNDN HIDEHJGLNHO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003D3")]
	[Cpp2IlInjected.Address(RVA = "0x57C05C0", Offset = "0x57BF9C0", VA = "0x1857C05C0")]
	public INNKCACPKLA HPGHLDDNEHH(NCOEFPHLCKK NLKDOMNEDBE, in JCAJMGPJNDN HIDEHJGLNHO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003D4")]
	[Cpp2IlInjected.Address(RVA = "0x57C0BE0", Offset = "0x57BFFE0", VA = "0x1857C0BE0")]
	public LBPABMNHAKF OCGJAPKHCOA(NCOEFPHLCKK NLKDOMNEDBE, in JCAJMGPJNDN HIDEHJGLNHO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003D5")]
	[Cpp2IlInjected.Address(RVA = "0x57C02A0", Offset = "0x57BF6A0", VA = "0x1857C02A0")]
	public OGBLFJOOHEI BMJLAHFILLO(NCOEFPHLCKK NLKDOMNEDBE, in JCAJMGPJNDN HIDEHJGLNHO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003D6")]
	[Cpp2IlInjected.Address(RVA = "0x57C0930", Offset = "0x57BFD30", VA = "0x1857C0930")]
	public IKFALNBDADN KIKLIMOCIDB(NCOEFPHLCKK NLKDOMNEDBE, in JCAJMGPJNDN HIDEHJGLNHO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003D7")]
	[Cpp2IlInjected.Address(RVA = "0x57C0310", Offset = "0x57BF710", VA = "0x1857C0310", Slot = "19")]
	public NCOEFPHLCKK APMJEHJBGBJ(RigidbodyEx IILFNNEDNCJ, JCAJMGPJNDN HIDEHJGLNHO, BKDMDHLJAEJ CMIHNHHBGOO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003D8")]
	[Cpp2IlInjected.Address(RVA = "0x72E810", Offset = "0x72DC10", VA = "0x18072E810")]
	public KCDDPFPGDON()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003D9")]
	[Cpp2IlInjected.Address(RVA = "0x57C0460", Offset = "0x57BF860", VA = "0x1857C0460", Slot = "14")]
	private IPANMLAMAAD DBBGHPHPGNC(NCOEFPHLCKK NLKDOMNEDBE, in JCAJMGPJNDN HIDEHJGLNHO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003DA")]
	[Cpp2IlInjected.Address(RVA = "0x57C05C0", Offset = "0x57BF9C0", VA = "0x1857C05C0", Slot = "15")]
	private INNKCACPKLA IACLMNOIKMC(NCOEFPHLCKK NLKDOMNEDBE, in JCAJMGPJNDN HIDEHJGLNHO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003DB")]
	[Cpp2IlInjected.Address(RVA = "0x57C0BE0", Offset = "0x57BFFE0", VA = "0x1857C0BE0", Slot = "16")]
	private LBPABMNHAKF MFFOKDJHDOK(NCOEFPHLCKK NLKDOMNEDBE, in JCAJMGPJNDN HIDEHJGLNHO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003DC")]
	[Cpp2IlInjected.Address(RVA = "0x57C02A0", Offset = "0x57BF6A0", VA = "0x1857C02A0", Slot = "17")]
	private OGBLFJOOHEI AFFGIKNDDLN(NCOEFPHLCKK NLKDOMNEDBE, in JCAJMGPJNDN HIDEHJGLNHO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003DD")]
	[Cpp2IlInjected.Address(RVA = "0x57C0930", Offset = "0x57BFD30", VA = "0x1857C0930", Slot = "18")]
	private IKFALNBDADN ILNOMKKJMMB(NCOEFPHLCKK NLKDOMNEDBE, in JCAJMGPJNDN HIDEHJGLNHO)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000042")]
[DefaultMember("Item")]
public sealed class GMOJEAHHPKO : IReadOnlyList<NCOEFPHLCKK>, IEnumerable<NCOEFPHLCKK>, IEnumerable, IReadOnlyCollection<NCOEFPHLCKK>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000060")]
	public readonly MBEDCJLMHEO LMLBLIDPKCN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000061")]
	public readonly ABGDBOLFPHD LHDJJEMNOIF;

	[Cpp2IlInjected.Token(Token = "0x170000FD")]
	public int JAMIBFCLJNH
	{
		[Cpp2IlInjected.Token(Token = "0x60003E1")]
		[Cpp2IlInjected.Address(RVA = "0x57B49A0", Offset = "0x57B3DA0", VA = "0x1857B49A0", Slot = "5")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000FE")]
	public NCOEFPHLCKK JNKMHBEEDBP
	{
		[Cpp2IlInjected.Token(Token = "0x60003E2")]
		[Cpp2IlInjected.Address(RVA = "0x57B4A70", Offset = "0x57B3E70", VA = "0x1857B4A70", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60003DE")]
	[Cpp2IlInjected.Address(RVA = "0x57B4950", Offset = "0x57B3D50", VA = "0x1857B4950")]
	public GMOJEAHHPKO(MBEDCJLMHEO LMLBLIDPKCN, ABGDBOLFPHD LHDJJEMNOIF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003DF")]
	[Cpp2IlInjected.Address(RVA = "0x57B47B0", Offset = "0x57B3BB0", VA = "0x1857B47B0", Slot = "6")]
	public IEnumerator<NCOEFPHLCKK> GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003E0")]
	[Cpp2IlInjected.Address(RVA = "0x57B47B0", Offset = "0x57B3BB0", VA = "0x1857B47B0", Slot = "7")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003E3")]
	[Cpp2IlInjected.Address(RVA = "0x57B4940", Offset = "0x57B3D40", VA = "0x1857B4940")]
	[CompilerGenerated]
	private NCOEFPHLCKK LMNEAPADJMJ(int FMPGMDDDGFN)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000043")]
[HAMPPOKOPOP(typeof(CCKADDACLBD), new string[] { })]
public class LJABFKEOBMH : CCKADDACLBD, GBCNOEIKEOL
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000062")]
	private readonly CCKADDACLBD IOLLFKFHGMO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000063")]
	private readonly CCKADDACLBD EGACOJLEBML;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000064")]
	private LPHNFCPFJBF KHKOGBBOGKO;

	[Cpp2IlInjected.Token(Token = "0x170000FF")]
	private CCKADDACLBD BLIAEGBHDHG
	{
		[Cpp2IlInjected.Token(Token = "0x60003E5")]
		[Cpp2IlInjected.Address(RVA = "0x57C30E0", Offset = "0x57C24E0", VA = "0x1857C30E0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60003E4")]
	[Cpp2IlInjected.Address(RVA = "0x57C2980", Offset = "0x57C1D80", VA = "0x1857C2980", Slot = "20")]
	public void FLFPICJOFML(FJEOEPCCLME JGMMDACFJLC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003E6")]
	[Cpp2IlInjected.Address(RVA = "0x57C2A80", Offset = "0x57C1E80", VA = "0x1857C2A80", Slot = "4")]
	public PLDJMDIFCKE HPIEMLILMFL(NCOEFPHLCKK NLKDOMNEDBE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003E7")]
	[Cpp2IlInjected.Address(RVA = "0x57C2B20", Offset = "0x57C1F20", VA = "0x1857C2B20", Slot = "5")]
	public ODMDEDICELM IINCPPFHAME(NCOEFPHLCKK NLKDOMNEDBE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003E8")]
	[Cpp2IlInjected.Address(RVA = "0x57C3040", Offset = "0x57C2440", VA = "0x1857C3040", Slot = "6")]
	public IMBEMHENMNJ MOJGNMKJFLF(NCOEFPHLCKK NLKDOMNEDBE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003E9")]
	[Cpp2IlInjected.Address(RVA = "0x57C2BC0", Offset = "0x57C1FC0", VA = "0x1857C2BC0", Slot = "7")]
	public CAONNBLCKEG ILCPDNKDAKJ(NCOEFPHLCKK NLKDOMNEDBE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003EA")]
	[Cpp2IlInjected.Address(RVA = "0x57C2E50", Offset = "0x57C2250", VA = "0x1857C2E50", Slot = "8")]
	public EIMJIHNCMHI KJNNEGNLPCG(NCOEFPHLCKK NLKDOMNEDBE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003EB")]
	[Cpp2IlInjected.Address(RVA = "0x57C2D10", Offset = "0x57C2110", VA = "0x1857C2D10", Slot = "9")]
	public JBCOLILENLD JDEHAKBEPFB(NCOEFPHLCKK NLKDOMNEDBE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003EC")]
	[Cpp2IlInjected.Address(RVA = "0x57C2790", Offset = "0x57C1B90", VA = "0x1857C2790", Slot = "10")]
	public KGDABPANOEG CLMAKHLOHMN(NCOEFPHLCKK NLKDOMNEDBE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003ED")]
	[Cpp2IlInjected.Address(RVA = "0x57C2EF0", Offset = "0x57C22F0", VA = "0x1857C2EF0", Slot = "11")]
	public BDJOPHNNEJG LAGKMHIIGOF(NCOEFPHLCKK NLKDOMNEDBE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003EE")]
	[Cpp2IlInjected.Address(RVA = "0x57C2DB0", Offset = "0x57C21B0", VA = "0x1857C2DB0", Slot = "12")]
	public AIOOGANOGPH JNMPFOJECMI(NCOEFPHLCKK NLKDOMNEDBE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003EF")]
	[Cpp2IlInjected.Address(RVA = "0x57C28E0", Offset = "0x57C1CE0", VA = "0x1857C28E0", Slot = "13")]
	public BBGAPPNBFLO DPGNNNONAOD(NCOEFPHLCKK NLKDOMNEDBE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003F0")]
	[Cpp2IlInjected.Address(RVA = "0x57C2830", Offset = "0x57C1C30", VA = "0x1857C2830")]
	public IPANMLAMAAD MNBKDOEPCLE(NCOEFPHLCKK NLKDOMNEDBE, in JCAJMGPJNDN HIDEHJGLNHO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003F1")]
	[Cpp2IlInjected.Address(RVA = "0x57C29D0", Offset = "0x57C1DD0", VA = "0x1857C29D0")]
	public INNKCACPKLA HPGHLDDNEHH(NCOEFPHLCKK NLKDOMNEDBE, in JCAJMGPJNDN HIDEHJGLNHO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003F2")]
	[Cpp2IlInjected.Address(RVA = "0x57C2F90", Offset = "0x57C2390", VA = "0x1857C2F90")]
	public LBPABMNHAKF OCGJAPKHCOA(NCOEFPHLCKK NLKDOMNEDBE, in JCAJMGPJNDN HIDEHJGLNHO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003F3")]
	[Cpp2IlInjected.Address(RVA = "0x57C2590", Offset = "0x57C1990", VA = "0x1857C2590")]
	public OGBLFJOOHEI BMJLAHFILLO(NCOEFPHLCKK NLKDOMNEDBE, in JCAJMGPJNDN HIDEHJGLNHO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003F4")]
	[Cpp2IlInjected.Address(RVA = "0x57C2C60", Offset = "0x57C2060", VA = "0x1857C2C60")]
	public IKFALNBDADN KIKLIMOCIDB(NCOEFPHLCKK NLKDOMNEDBE, in JCAJMGPJNDN HIDEHJGLNHO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003F5")]
	[Cpp2IlInjected.Address(RVA = "0x57C2640", Offset = "0x57C1A40", VA = "0x1857C2640", Slot = "19")]
	public NCOEFPHLCKK APMJEHJBGBJ(RigidbodyEx IILFNNEDNCJ, JCAJMGPJNDN HIDEHJGLNHO, BKDMDHLJAEJ CMIHNHHBGOO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003F6")]
	[Cpp2IlInjected.Address(RVA = "0x57C3140", Offset = "0x57C2540", VA = "0x1857C3140")]
	public LJABFKEOBMH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003F7")]
	[Cpp2IlInjected.Address(RVA = "0x57C2830", Offset = "0x57C1C30", VA = "0x1857C2830", Slot = "14")]
	private IPANMLAMAAD DBBGHPHPGNC(NCOEFPHLCKK NLKDOMNEDBE, in JCAJMGPJNDN HIDEHJGLNHO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003F8")]
	[Cpp2IlInjected.Address(RVA = "0x57C29D0", Offset = "0x57C1DD0", VA = "0x1857C29D0", Slot = "15")]
	private INNKCACPKLA IACLMNOIKMC(NCOEFPHLCKK NLKDOMNEDBE, in JCAJMGPJNDN HIDEHJGLNHO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003F9")]
	[Cpp2IlInjected.Address(RVA = "0x57C2F90", Offset = "0x57C2390", VA = "0x1857C2F90", Slot = "16")]
	private LBPABMNHAKF MFFOKDJHDOK(NCOEFPHLCKK NLKDOMNEDBE, in JCAJMGPJNDN HIDEHJGLNHO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003FA")]
	[Cpp2IlInjected.Address(RVA = "0x57C2590", Offset = "0x57C1990", VA = "0x1857C2590", Slot = "17")]
	private OGBLFJOOHEI AFFGIKNDDLN(NCOEFPHLCKK NLKDOMNEDBE, in JCAJMGPJNDN HIDEHJGLNHO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003FB")]
	[Cpp2IlInjected.Address(RVA = "0x57C2C60", Offset = "0x57C2060", VA = "0x1857C2C60", Slot = "18")]
	private IKFALNBDADN ILNOMKKJMMB(NCOEFPHLCKK NLKDOMNEDBE, in JCAJMGPJNDN HIDEHJGLNHO)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000044")]
[Preserve]
public sealed class IBKOCLOMPFN : NCOEFPHLCKK, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x4000065")]
	public static readonly IBKOCLOMPFN AGBLMGNNIDO;

	[Cpp2IlInjected.Token(Token = "0x17000100")]
	public Rigidbody LNMDHFKNJIH
	{
		[Cpp2IlInjected.Token(Token = "0x600040E")]
		[Cpp2IlInjected.Address(RVA = "0x72B010", Offset = "0x72A410", VA = "0x18072B010", Slot = "4")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000101")]
	public RigidbodyEx OEOEKIBFEMO
	{
		[Cpp2IlInjected.Token(Token = "0x600040F")]
		[Cpp2IlInjected.Address(RVA = "0x72B030", Offset = "0x72A430", VA = "0x18072B030", Slot = "5")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000102")]
	public GameObject MILHHPLGFOL
	{
		[Cpp2IlInjected.Token(Token = "0x6000410")]
		[Cpp2IlInjected.Address(RVA = "0x72F250", Offset = "0x72E650", VA = "0x18072F250", Slot = "6")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000103")]
	public Transform LHEBMCHBDEI
	{
		[Cpp2IlInjected.Token(Token = "0x6000411")]
		[Cpp2IlInjected.Address(RVA = "0x72F270", Offset = "0x72E670", VA = "0x18072F270", Slot = "7")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000104")]
	public IEnumerable<object> IMECMIODOMG
	{
		[Cpp2IlInjected.Token(Token = "0x6000412")]
		[Cpp2IlInjected.Address(RVA = "0x72B000", Offset = "0x72A400", VA = "0x18072B000", Slot = "8")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000105")]
	public NCOEFPHLCKK GKEMABFNEME
	{
		[Cpp2IlInjected.Token(Token = "0x6000413")]
		[Cpp2IlInjected.Address(RVA = "0x735A10", Offset = "0x734E10", VA = "0x180735A10", Slot = "9")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000414")]
		[Cpp2IlInjected.Address(RVA = "0x735A20", Offset = "0x734E20", VA = "0x180735A20", Slot = "10")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000106")]
	public IReadOnlyList<NCOEFPHLCKK> PHPDFDJEEEA
	{
		[Cpp2IlInjected.Token(Token = "0x6000415")]
		[Cpp2IlInjected.Address(RVA = "0x77E9A0", Offset = "0x77DDA0", VA = "0x18077E9A0", Slot = "11")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000107")]
	public NCOEFPHLCKK CMJKBCMDGHN
	{
		[Cpp2IlInjected.Token(Token = "0x6000416")]
		[Cpp2IlInjected.Address(RVA = "0x72B0F0", Offset = "0x72A4F0", VA = "0x18072B0F0", Slot = "12")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000108")]
	public bool KMDIPAOGGGF
	{
		[Cpp2IlInjected.Token(Token = "0x6000417")]
		[Cpp2IlInjected.Address(RVA = "0x13E3880", Offset = "0x13E2C80", VA = "0x1813E3880", Slot = "13")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000109")]
	public bool BBHAHOHMEPG
	{
		[Cpp2IlInjected.Token(Token = "0x6000418")]
		[Cpp2IlInjected.Address(RVA = "0x102E050", Offset = "0x102D450", VA = "0x18102E050", Slot = "14")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700010A")]
	public bool MPDIPBBGKKB
	{
		[Cpp2IlInjected.Token(Token = "0x6000419")]
		[Cpp2IlInjected.Address(RVA = "0xABDB80", Offset = "0xABCF80", VA = "0x180ABDB80", Slot = "15")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700010B")]
	public EKLLOLLHLDP LNMCPLFHCHG
	{
		[Cpp2IlInjected.Token(Token = "0x600041A")]
		[Cpp2IlInjected.Address(RVA = "0x72B0D0", Offset = "0x72A4D0", VA = "0x18072B0D0", Slot = "16")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600041B")]
		[Cpp2IlInjected.Address(RVA = "0x7DF040", Offset = "0x7DE440", VA = "0x1807DF040", Slot = "17")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700010C")]
	public CHACNCJIDJM GJHPEGFOAME
	{
		[Cpp2IlInjected.Token(Token = "0x600041C")]
		[Cpp2IlInjected.Address(RVA = "0x72B0B0", Offset = "0x72A4B0", VA = "0x18072B0B0", Slot = "18")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600041D")]
		[Cpp2IlInjected.Address(RVA = "0x7DF050", Offset = "0x7DE450", VA = "0x1807DF050", Slot = "19")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700010D")]
	public float KKALKPOINCB
	{
		[Cpp2IlInjected.Token(Token = "0x600041E")]
		[Cpp2IlInjected.Address(RVA = "0x15F6300", Offset = "0x15F5700", VA = "0x1815F6300", Slot = "20")]
		[CompilerGenerated]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x600041F")]
		[Cpp2IlInjected.Address(RVA = "0xBFB4E0", Offset = "0xBFA8E0", VA = "0x180BFB4E0", Slot = "21")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700010E")]
	public Vector3 JBHIDAJMGMM
	{
		[Cpp2IlInjected.Token(Token = "0x6000420")]
		[Cpp2IlInjected.Address(RVA = "0x312BDB0", Offset = "0x312B1B0", VA = "0x18312BDB0", Slot = "22")]
		[CompilerGenerated]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x6000421")]
		[Cpp2IlInjected.Address(RVA = "0x3127E80", Offset = "0x3127280", VA = "0x183127E80", Slot = "23")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700010F")]
	public Vector3 ICEKJCBHJBH
	{
		[Cpp2IlInjected.Token(Token = "0x6000422")]
		[Cpp2IlInjected.Address(RVA = "0x13AC900", Offset = "0x13ABD00", VA = "0x1813AC900", Slot = "24")]
		[CompilerGenerated]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x6000423")]
		[Cpp2IlInjected.Address(RVA = "0x13A8790", Offset = "0x13A7B90", VA = "0x1813A8790", Slot = "25")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000110")]
	public Vector3 LGEGEJPPDAD
	{
		[Cpp2IlInjected.Token(Token = "0x6000424")]
		[Cpp2IlInjected.Address(RVA = "0x13AC920", Offset = "0x13ABD20", VA = "0x1813AC920", Slot = "26")]
		[CompilerGenerated]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x6000425")]
		[Cpp2IlInjected.Address(RVA = "0x13AA4E0", Offset = "0x13A98E0", VA = "0x1813AA4E0", Slot = "27")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000111")]
	public Vector3 LJMFIEJCGLD
	{
		[Cpp2IlInjected.Token(Token = "0x6000426")]
		[Cpp2IlInjected.Address(RVA = "0xF3EC90", Offset = "0xF3E090", VA = "0x180F3EC90", Slot = "28")]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x6000427")]
		[Cpp2IlInjected.Address(RVA = "0x72E830", Offset = "0x72DC30", VA = "0x18072E830", Slot = "29")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000112")]
	public bool NHCAAMEDKKB
	{
		[Cpp2IlInjected.Token(Token = "0x6000428")]
		[Cpp2IlInjected.Address(RVA = "0xB00210", Offset = "0xAFF610", VA = "0x180B00210", Slot = "30")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000113")]
	public bool GDCCIECOAEF
	{
		[Cpp2IlInjected.Token(Token = "0x6000429")]
		[Cpp2IlInjected.Address(RVA = "0xB00170", Offset = "0xAFF570", VA = "0x180B00170", Slot = "31")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000114")]
	public bool ABAINBEINAC
	{
		[Cpp2IlInjected.Token(Token = "0x600042A")]
		[Cpp2IlInjected.Address(RVA = "0xB00160", Offset = "0xAFF560", VA = "0x180B00160", Slot = "32")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000115")]
	public bool LIGEJEKODFL
	{
		[Cpp2IlInjected.Token(Token = "0x600042B")]
		[Cpp2IlInjected.Address(RVA = "0xB00180", Offset = "0xAFF580", VA = "0x180B00180", Slot = "33")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000116")]
	public Vector3 BFENAJAEKJN
	{
		[Cpp2IlInjected.Token(Token = "0x600042C")]
		[Cpp2IlInjected.Address(RVA = "0x167D7F0", Offset = "0x167CBF0", VA = "0x18167D7F0", Slot = "34")]
		[CompilerGenerated]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000117")]
	public Vector3 LECHPMMLACE
	{
		[Cpp2IlInjected.Token(Token = "0x600042D")]
		[Cpp2IlInjected.Address(RVA = "0x125E330", Offset = "0x125D730", VA = "0x18125E330", Slot = "35")]
		[CompilerGenerated]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000118")]
	public Vector3 BMNHHGGIMHD
	{
		[Cpp2IlInjected.Token(Token = "0x600042E")]
		[Cpp2IlInjected.Address(RVA = "0xF3EC90", Offset = "0xF3E090", VA = "0x180F3EC90", Slot = "36")]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x600042F")]
		[Cpp2IlInjected.Address(RVA = "0x72E830", Offset = "0x72DC30", VA = "0x18072E830", Slot = "37")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000119")]
	public Vector3 ICDJEGJHDEE
	{
		[Cpp2IlInjected.Token(Token = "0x6000430")]
		[Cpp2IlInjected.Address(RVA = "0x13AC9F0", Offset = "0x13ABDF0", VA = "0x1813AC9F0", Slot = "38")]
		[CompilerGenerated]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700011A")]
	public float AHNCJOKPCCM
	{
		[Cpp2IlInjected.Token(Token = "0x6000431")]
		[Cpp2IlInjected.Address(RVA = "0x2077920", Offset = "0x2076D20", VA = "0x182077920", Slot = "39")]
		[CompilerGenerated]
		get
		{
			return default(float);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700011B")]
	public float JAHICELIBID
	{
		[Cpp2IlInjected.Token(Token = "0x6000432")]
		[Cpp2IlInjected.Address(RVA = "0x1133200", Offset = "0x1132600", VA = "0x181133200", Slot = "40")]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x6000433")]
		[Cpp2IlInjected.Address(RVA = "0x72E830", Offset = "0x72DC30", VA = "0x18072E830", Slot = "41")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700011C")]
	public Vector3 JLIOGCPKLOL
	{
		[Cpp2IlInjected.Token(Token = "0x6000434")]
		[Cpp2IlInjected.Address(RVA = "0xF3EC90", Offset = "0xF3E090", VA = "0x180F3EC90", Slot = "42")]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x6000435")]
		[Cpp2IlInjected.Address(RVA = "0x72E830", Offset = "0x72DC30", VA = "0x18072E830", Slot = "43")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700011D")]
	public Quaternion OCGLMIOIKKA
	{
		[Cpp2IlInjected.Token(Token = "0x6000436")]
		[Cpp2IlInjected.Address(RVA = "0x108A300", Offset = "0x1089700", VA = "0x18108A300", Slot = "44")]
		get
		{
			return default(Quaternion);
		}
		[Cpp2IlInjected.Token(Token = "0x6000437")]
		[Cpp2IlInjected.Address(RVA = "0x72E830", Offset = "0x72DC30", VA = "0x18072E830", Slot = "45")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700011E")]
	public float PGABAKFPNBB
	{
		[Cpp2IlInjected.Token(Token = "0x6000438")]
		[Cpp2IlInjected.Address(RVA = "0x1133200", Offset = "0x1132600", VA = "0x181133200", Slot = "46")]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x6000439")]
		[Cpp2IlInjected.Address(RVA = "0x72E830", Offset = "0x72DC30", VA = "0x18072E830", Slot = "47")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700011F")]
	public float DCNFDLOMNCM
	{
		[Cpp2IlInjected.Token(Token = "0x600043A")]
		[Cpp2IlInjected.Address(RVA = "0x1133200", Offset = "0x1132600", VA = "0x181133200", Slot = "48")]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x600043B")]
		[Cpp2IlInjected.Address(RVA = "0x72E830", Offset = "0x72DC30", VA = "0x18072E830", Slot = "49")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000120")]
	public bool OGIIANAEIFL
	{
		[Cpp2IlInjected.Token(Token = "0x600043C")]
		[Cpp2IlInjected.Address(RVA = "0x72E820", Offset = "0x72DC20", VA = "0x18072E820", Slot = "50")]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x600043D")]
		[Cpp2IlInjected.Address(RVA = "0x72E830", Offset = "0x72DC30", VA = "0x18072E830", Slot = "51")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000121")]
	public bool ODGKAIJIABE
	{
		[Cpp2IlInjected.Token(Token = "0x600043E")]
		[Cpp2IlInjected.Address(RVA = "0x72E820", Offset = "0x72DC20", VA = "0x18072E820")]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x600043F")]
		[Cpp2IlInjected.Address(RVA = "0x72E830", Offset = "0x72DC30", VA = "0x18072E830")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000122")]
	public GGPABLKNBJB LEKOFMMMFBB
	{
		[Cpp2IlInjected.Token(Token = "0x6000440")]
		[Cpp2IlInjected.Address(RVA = "0x72E820", Offset = "0x72DC20", VA = "0x18072E820", Slot = "52")]
		get
		{
			return default(GGPABLKNBJB);
		}
		[Cpp2IlInjected.Token(Token = "0x6000441")]
		[Cpp2IlInjected.Address(RVA = "0x72E830", Offset = "0x72DC30", VA = "0x18072E830", Slot = "53")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000123")]
	public bool FAJNDFDCOGA
	{
		[Cpp2IlInjected.Token(Token = "0x6000442")]
		[Cpp2IlInjected.Address(RVA = "0x20CDFC0", Offset = "0x20CD3C0", VA = "0x1820CDFC0", Slot = "54")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000124")]
	public Transform KMDNPAAIEIK
	{
		[Cpp2IlInjected.Token(Token = "0x6000443")]
		[Cpp2IlInjected.Address(RVA = "0x800FF0", Offset = "0x8003F0", VA = "0x180800FF0", Slot = "55")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000125")]
	public Transform FNPJMEGGLFM
	{
		[Cpp2IlInjected.Token(Token = "0x6000444")]
		[Cpp2IlInjected.Address(RVA = "0x79EB50", Offset = "0x79DF50", VA = "0x18079EB50", Slot = "56")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000126")]
	public Vector3 BLGJDGKFELJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000445")]
		[Cpp2IlInjected.Address(RVA = "0xF3EC90", Offset = "0xF3E090", VA = "0x180F3EC90", Slot = "57")]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x6000446")]
		[Cpp2IlInjected.Address(RVA = "0x72E830", Offset = "0x72DC30", VA = "0x18072E830", Slot = "58")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000127")]
	public float CLIPDFNDOOC
	{
		[Cpp2IlInjected.Token(Token = "0x6000447")]
		[Cpp2IlInjected.Address(RVA = "0x1133200", Offset = "0x1132600", VA = "0x181133200", Slot = "59")]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x6000448")]
		[Cpp2IlInjected.Address(RVA = "0x72E830", Offset = "0x72DC30", VA = "0x18072E830", Slot = "60")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000128")]
	public float JHDBNDJGACG
	{
		[Cpp2IlInjected.Token(Token = "0x6000449")]
		[Cpp2IlInjected.Address(RVA = "0x1133200", Offset = "0x1132600", VA = "0x181133200", Slot = "61")]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x600044A")]
		[Cpp2IlInjected.Address(RVA = "0x72E830", Offset = "0x72DC30", VA = "0x18072E830", Slot = "62")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000129")]
	public Quaternion INFAOAKNLJC
	{
		[Cpp2IlInjected.Token(Token = "0x600044B")]
		[Cpp2IlInjected.Address(RVA = "0x121DC40", Offset = "0x121D040", VA = "0x18121DC40", Slot = "63")]
		get
		{
			return default(Quaternion);
		}
		[Cpp2IlInjected.Token(Token = "0x600044C")]
		[Cpp2IlInjected.Address(RVA = "0x72E830", Offset = "0x72DC30", VA = "0x18072E830", Slot = "64")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700012A")]
	public Vector3 NAILLMLOGGK
	{
		[Cpp2IlInjected.Token(Token = "0x600044D")]
		[Cpp2IlInjected.Address(RVA = "0xF3EC90", Offset = "0xF3E090", VA = "0x180F3EC90", Slot = "65")]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x600044E")]
		[Cpp2IlInjected.Address(RVA = "0x72E830", Offset = "0x72DC30", VA = "0x18072E830", Slot = "66")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700012B")]
	public Quaternion FBMHBHAGGPI
	{
		[Cpp2IlInjected.Token(Token = "0x600044F")]
		[Cpp2IlInjected.Address(RVA = "0x121DC40", Offset = "0x121D040", VA = "0x18121DC40", Slot = "67")]
		get
		{
			return default(Quaternion);
		}
		[Cpp2IlInjected.Token(Token = "0x6000450")]
		[Cpp2IlInjected.Address(RVA = "0x72E830", Offset = "0x72DC30", VA = "0x18072E830", Slot = "68")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700012C")]
	public RigidbodyConstraints AOEOJAJAPKL
	{
		[Cpp2IlInjected.Token(Token = "0x6000451")]
		[Cpp2IlInjected.Address(RVA = "0x72F5A0", Offset = "0x72E9A0", VA = "0x18072F5A0", Slot = "69")]
		get
		{
			return default(RigidbodyConstraints);
		}
		[Cpp2IlInjected.Token(Token = "0x6000452")]
		[Cpp2IlInjected.Address(RVA = "0x72E830", Offset = "0x72DC30", VA = "0x18072E830", Slot = "70")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700012D")]
	public bool KHDKIPLIJCN
	{
		[Cpp2IlInjected.Token(Token = "0x6000453")]
		[Cpp2IlInjected.Address(RVA = "0x72E820", Offset = "0x72DC20", VA = "0x18072E820", Slot = "71")]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000454")]
		[Cpp2IlInjected.Address(RVA = "0x72E830", Offset = "0x72DC30", VA = "0x18072E830", Slot = "72")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700012E")]
	public CollisionDetectionMode PAOOKBBFCLK
	{
		[Cpp2IlInjected.Token(Token = "0x6000455")]
		[Cpp2IlInjected.Address(RVA = "0x72F5A0", Offset = "0x72E9A0", VA = "0x18072F5A0", Slot = "73")]
		get
		{
			return default(CollisionDetectionMode);
		}
		[Cpp2IlInjected.Token(Token = "0x6000456")]
		[Cpp2IlInjected.Address(RVA = "0x72E830", Offset = "0x72DC30", VA = "0x18072E830", Slot = "74")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700012F")]
	public bool LFGDELENJCM
	{
		[Cpp2IlInjected.Token(Token = "0x6000457")]
		[Cpp2IlInjected.Address(RVA = "0x10E9E70", Offset = "0x10E9270", VA = "0x1810E9E70", Slot = "75")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000038")]
	public event DGAAFHCPHEH NJJHHELIHIP
	{
		[Cpp2IlInjected.Token(Token = "0x60003FC")]
		[Cpp2IlInjected.Address(RVA = "0x72E830", Offset = "0x72DC30", VA = "0x18072E830", Slot = "81")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60003FD")]
		[Cpp2IlInjected.Address(RVA = "0x72E830", Offset = "0x72DC30", VA = "0x18072E830", Slot = "82")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000039")]
	public event DGAAFHCPHEH EPBNCIPAFDB
	{
		[Cpp2IlInjected.Token(Token = "0x60003FE")]
		[Cpp2IlInjected.Address(RVA = "0x72E830", Offset = "0x72DC30", VA = "0x18072E830", Slot = "83")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60003FF")]
		[Cpp2IlInjected.Address(RVA = "0x72E830", Offset = "0x72DC30", VA = "0x18072E830", Slot = "84")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400003A")]
	public event MKKJLKCGEAC EIBHEHIGCNB
	{
		[Cpp2IlInjected.Token(Token = "0x6000400")]
		[Cpp2IlInjected.Address(RVA = "0x72E830", Offset = "0x72DC30", VA = "0x18072E830", Slot = "85")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000401")]
		[Cpp2IlInjected.Address(RVA = "0x72E830", Offset = "0x72DC30", VA = "0x18072E830", Slot = "86")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400003B")]
	public event DGAAFHCPHEH DELNFHCFIKO
	{
		[Cpp2IlInjected.Token(Token = "0x6000402")]
		[Cpp2IlInjected.Address(RVA = "0x72E830", Offset = "0x72DC30", VA = "0x18072E830", Slot = "88")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000403")]
		[Cpp2IlInjected.Address(RVA = "0x72E830", Offset = "0x72DC30", VA = "0x18072E830", Slot = "89")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400003C")]
	public event DGAAFHCPHEH DHIFCNEILML
	{
		[Cpp2IlInjected.Token(Token = "0x6000404")]
		[Cpp2IlInjected.Address(RVA = "0x72E830", Offset = "0x72DC30", VA = "0x18072E830", Slot = "108")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000405")]
		[Cpp2IlInjected.Address(RVA = "0x72E830", Offset = "0x72DC30", VA = "0x18072E830", Slot = "109")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400003D")]
	public event DGAAFHCPHEH BGFDOMIHHPL
	{
		[Cpp2IlInjected.Token(Token = "0x6000406")]
		[Cpp2IlInjected.Address(RVA = "0x72E830", Offset = "0x72DC30", VA = "0x18072E830", Slot = "113")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000407")]
		[Cpp2IlInjected.Address(RVA = "0x72E830", Offset = "0x72DC30", VA = "0x18072E830", Slot = "114")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400003E")]
	public event Action<FCDCKNBKJML, FCDCKNBKJML> DLLBDKMMJIP
	{
		[Cpp2IlInjected.Token(Token = "0x6000408")]
		[Cpp2IlInjected.Address(RVA = "0x72E830", Offset = "0x72DC30", VA = "0x18072E830", Slot = "117")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000409")]
		[Cpp2IlInjected.Address(RVA = "0x72E830", Offset = "0x72DC30", VA = "0x18072E830", Slot = "118")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400003F")]
	public event DGAAFHCPHEH FCJJAJLCBGC
	{
		[Cpp2IlInjected.Token(Token = "0x600040A")]
		[Cpp2IlInjected.Address(RVA = "0x72E830", Offset = "0x72DC30", VA = "0x18072E830", Slot = "119")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600040B")]
		[Cpp2IlInjected.Address(RVA = "0x72E830", Offset = "0x72DC30", VA = "0x18072E830", Slot = "120")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000040")]
	public event DGAAFHCPHEH MGPMCLDJCJA
	{
		[Cpp2IlInjected.Token(Token = "0x600040C")]
		[Cpp2IlInjected.Address(RVA = "0x72E830", Offset = "0x72DC30", VA = "0x18072E830", Slot = "125")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600040D")]
		[Cpp2IlInjected.Address(RVA = "0x72E830", Offset = "0x72DC30", VA = "0x18072E830", Slot = "126")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000458")]
	[Cpp2IlInjected.Address(RVA = "0x72E830", Offset = "0x72DC30", VA = "0x18072E830", Slot = "76")]
	public void PBJONABJOBO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000459")]
	[Cpp2IlInjected.Address(RVA = "0x72E830", Offset = "0x72DC30", VA = "0x18072E830", Slot = "77")]
	public void AOLBABCADFF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600045A")]
	[Cpp2IlInjected.Address(RVA = "0x72E830", Offset = "0x72DC30", VA = "0x18072E830", Slot = "78")]
	public void NKMAPFPPLGO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600045B")]
	[Cpp2IlInjected.Address(RVA = "0x72E830", Offset = "0x72DC30", VA = "0x18072E830", Slot = "79")]
	public void PKFLOCAHJCK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600045C")]
	[Cpp2IlInjected.Address(RVA = "0x72E830", Offset = "0x72DC30", VA = "0x18072E830", Slot = "80")]
	public void MCKPAKFDOPH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600045D")]
	[Cpp2IlInjected.Address(RVA = "0x72E830", Offset = "0x72DC30", VA = "0x18072E830", Slot = "141")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600045E")]
	[Cpp2IlInjected.Address(RVA = "0x72E830", Offset = "0x72DC30", VA = "0x18072E830", Slot = "87")]
	public void DEIBNNOCJKC(NCOEFPHLCKK LPJDDLMPNCG, bool OMIKAFGHIFK = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600045F")]
	[Cpp2IlInjected.Address(RVA = "0x72E830", Offset = "0x72DC30", VA = "0x18072E830", Slot = "90")]
	public void KMKIMCBMAFA(object MIFCLBEAOPM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000460")]
	[Cpp2IlInjected.Address(RVA = "0x72E830", Offset = "0x72DC30", VA = "0x18072E830", Slot = "91")]
	public void JCGBFLMHKCG(object MIFCLBEAOPM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000461")]
	[Cpp2IlInjected.Address(RVA = "0xF3EC90", Offset = "0xF3E090", VA = "0x180F3EC90", Slot = "92")]
	public Vector3 AFFCJBHNNJL(Vector3 JOJEMOKKGPP)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000462")]
	[Cpp2IlInjected.Address(RVA = "0xF3EC90", Offset = "0xF3E090", VA = "0x180F3EC90", Slot = "93")]
	public Vector3 KIKKEDPKAKK(Vector3 HMPFDEAFPND)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000463")]
	[Cpp2IlInjected.Address(RVA = "0x72E830", Offset = "0x72DC30", VA = "0x18072E830", Slot = "94")]
	public void INLPOAEPJGG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000464")]
	[Cpp2IlInjected.Address(RVA = "0x72E830", Offset = "0x72DC30", VA = "0x18072E830", Slot = "95")]
	public void BHDNAPGFIPJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000465")]
	[Cpp2IlInjected.Address(RVA = "0x72E830", Offset = "0x72DC30", VA = "0x18072E830", Slot = "96")]
	public void IFMLGPGPJDO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000466")]
	[Cpp2IlInjected.Address(RVA = "0x72E830", Offset = "0x72DC30", VA = "0x18072E830", Slot = "97")]
	public void NGFKLMPAGOE(Vector3 GKKEEHNMPBL, Vector3 NFGPCLPNMJK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000467")]
	[Cpp2IlInjected.Address(RVA = "0x72E830", Offset = "0x72DC30", VA = "0x18072E830", Slot = "98")]
	public void JLDEEBLCKGA(Vector3 FHKLDEIKECB, Vector3 FHFHNDANMPN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000468")]
	[Cpp2IlInjected.Address(RVA = "0x72E830", Offset = "0x72DC30", VA = "0x18072E830", Slot = "99")]
	public void KIIDBBLBANB(Vector3 JDDALKKDLNA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000469")]
	[Cpp2IlInjected.Address(RVA = "0x72E830", Offset = "0x72DC30", VA = "0x18072E830", Slot = "100")]
	public void HHAFJJGJPFB(EECECFKKEJP KMDODPJBKLE, Vector3 CFLMAEMNHKL, float ABGPHLFIFAO, float OPCFMELHIKJ = 8f, float ECOHALOPPDN = 1f)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600046A")]
	[Cpp2IlInjected.Address(RVA = "0x72E830", Offset = "0x72DC30", VA = "0x18072E830", Slot = "101")]
	public void HHLJBCNAEPM(JDHBHPOMECG EFAKAOJPAJJ, Vector3 PKAJMBKNJIL, float KBLOKDLNEPD = float.PositiveInfinity)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600046B")]
	[Cpp2IlInjected.Address(RVA = "0x72E830", Offset = "0x72DC30", VA = "0x18072E830", Slot = "102")]
	public void IALNLOAFGMK(JDHBHPOMECG EFAKAOJPAJJ, Vector3 IHCJBCJFELL, float MEJPNNANPLH = 7f, float CKIIILKMBKK = 1f)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600046C")]
	[Cpp2IlInjected.Address(RVA = "0xF3EC90", Offset = "0xF3E090", VA = "0x180F3EC90", Slot = "103")]
	public Vector3 DNICIBAAMCG(Vector3 LPJDDLMPNCG)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x600046D")]
	[Cpp2IlInjected.Address(RVA = "0xF3EC90", Offset = "0xF3E090", VA = "0x180F3EC90", Slot = "104")]
	public Vector3 GJAHBCCOAII(Vector3 LPJDDLMPNCG)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x600046E")]
	[Cpp2IlInjected.Address(RVA = "0x72E830", Offset = "0x72DC30", VA = "0x18072E830", Slot = "105")]
	public void EPOKPKAANHO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600046F")]
	[Cpp2IlInjected.Address(RVA = "0x72E830", Offset = "0x72DC30", VA = "0x18072E830", Slot = "106")]
	public void OIHMDCKKBFA(NCOEFPHLCKK BKGBHBNCDJA, object MIFCLBEAOPM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000470")]
	[Cpp2IlInjected.Address(RVA = "0x72E830", Offset = "0x72DC30", VA = "0x18072E830", Slot = "107")]
	public void ELAHEJFDAHO(object MIFCLBEAOPM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000471")]
	[Cpp2IlInjected.Address(RVA = "0x72E830", Offset = "0x72DC30", VA = "0x18072E830", Slot = "110")]
	public void FCDPOIHJAAG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000472")]
	[Cpp2IlInjected.Address(RVA = "0x72E830", Offset = "0x72DC30", VA = "0x18072E830", Slot = "111")]
	public void AEAABDHDFFI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000473")]
	[Cpp2IlInjected.Address(RVA = "0x72E830", Offset = "0x72DC30", VA = "0x18072E830", Slot = "112")]
	public void IEIECPGHPLP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000474")]
	[Cpp2IlInjected.Address(RVA = "0x72E820", Offset = "0x72DC20", VA = "0x18072E820", Slot = "115")]
	public bool NEPEFPHIELC()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000475")]
	[Cpp2IlInjected.Address(RVA = "0x72E830", Offset = "0x72DC30", VA = "0x18072E830", Slot = "116")]
	public void PFPLFILECPI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000476")]
	[Cpp2IlInjected.Address(RVA = "0x72F5A0", Offset = "0x72E9A0", VA = "0x18072F5A0", Slot = "121")]
	public IDisposable EBMGEFKJGJE()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000477")]
	[Cpp2IlInjected.Address(RVA = "0x72E830", Offset = "0x72DC30", VA = "0x18072E830", Slot = "122")]
	public void LDMPNKDCNKH(object MIFCLBEAOPM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000478")]
	[Cpp2IlInjected.Address(RVA = "0x72E830", Offset = "0x72DC30", VA = "0x18072E830", Slot = "123")]
	public void FGAHJAEMBHA(object MIFCLBEAOPM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000479")]
	[Cpp2IlInjected.Address(RVA = "0x72E830", Offset = "0x72DC30", VA = "0x18072E830", Slot = "124")]
	public void PNGKMLMJNAK(object MIFCLBEAOPM, bool KLMBPMINIHN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600047A")]
	[Cpp2IlInjected.Address(RVA = "0x72E830", Offset = "0x72DC30", VA = "0x18072E830", Slot = "127")]
	public void LOKMBIPHOGK(Vector3 PGJOODJOMAI, Quaternion OMJBPOHHBNI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600047B")]
	[Cpp2IlInjected.Address(RVA = "0x72E830", Offset = "0x72DC30", VA = "0x18072E830", Slot = "128")]
	public void OFCCCKGCAPP(Vector3 PPNOLBKPBJH, Quaternion KAHANPFONLJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600047C")]
	[Cpp2IlInjected.Address(RVA = "0x72E820", Offset = "0x72DC20", VA = "0x18072E820", Slot = "129")]
	public bool AMLDEGGHKAD(float ANPGDIDDDCB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600047D")]
	[Cpp2IlInjected.Address(RVA = "0x72E830", Offset = "0x72DC30", VA = "0x18072E830", Slot = "130")]
	public void HMHFMGOKMHP(object MIFCLBEAOPM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600047E")]
	[Cpp2IlInjected.Address(RVA = "0x72E830", Offset = "0x72DC30", VA = "0x18072E830", Slot = "131")]
	public void KNMLFLHNFDJ(object MIFCLBEAOPM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600047F")]
	[Cpp2IlInjected.Address(RVA = "0x72E830", Offset = "0x72DC30", VA = "0x18072E830", Slot = "132")]
	public void KPOLANLNJJI(object MIFCLBEAOPM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000480")]
	[Cpp2IlInjected.Address(RVA = "0x72E830", Offset = "0x72DC30", VA = "0x18072E830", Slot = "133")]
	public void HIBCGDMOODJ(object MIFCLBEAOPM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000481")]
	[Cpp2IlInjected.Address(RVA = "0x72E830", Offset = "0x72DC30", VA = "0x18072E830", Slot = "134")]
	public void BEJNHGKJNLM(Vector3 HKPPDHFDHMN, ForceMode MPMGBCACKOF = ForceMode.Force)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000482")]
	[Cpp2IlInjected.Address(RVA = "0x72E830", Offset = "0x72DC30", VA = "0x18072E830", Slot = "135")]
	public void CBMEMNKKLDE(Vector3 HKPPDHFDHMN, Vector3 PICDPPHNNLH, ForceMode MPMGBCACKOF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000483")]
	[Cpp2IlInjected.Address(RVA = "0x72E830", Offset = "0x72DC30", VA = "0x18072E830", Slot = "136")]
	public void OHNHDPGFLAC(Vector3 MBBMKANKKGB, ForceMode MPMGBCACKOF = ForceMode.Force)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000484")]
	[Cpp2IlInjected.Address(RVA = "0x72E830", Offset = "0x72DC30", VA = "0x18072E830", Slot = "137")]
	public void PPDGHDJCFAP(Vector3 MBBMKANKKGB, ForceMode MPMGBCACKOF = ForceMode.Force)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000485")]
	[Cpp2IlInjected.Address(RVA = "0x57B8D70", Offset = "0x57B8170", VA = "0x1857B8D70", Slot = "138")]
	public bool OFDKFHJBLOJ(Vector3 MFKKMPGAJFI, out RaycastHit ONOMCDOFLKH, float CBFODBDKBEK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000486")]
	[Cpp2IlInjected.Address(RVA = "0x72E830", Offset = "0x72DC30", VA = "0x18072E830", Slot = "139")]
	public void AMJHKJLPLNB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000487")]
	[Cpp2IlInjected.Address(RVA = "0x72E810", Offset = "0x72DC10", VA = "0x18072E810")]
	public IBKOCLOMPFN()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000045")]
public sealed class KNGEGNFMEDP : PLOEBEDJGLE, KDBGLABEDCA, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
	[Cpp2IlInjected.Token(Token = "0x4000083")]
	internal MBEDCJLMHEO LMLBLIDPKCN;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
	[Cpp2IlInjected.Token(Token = "0x4000084")]
	internal ABGDBOLFPHD ENDDCBHJOLK;

	[Cpp2IlInjected.Token(Token = "0x6000489")]
	[Cpp2IlInjected.Address(RVA = "0x57C2580", Offset = "0x57C1980", VA = "0x1857C2580")]
	public KNGEGNFMEDP(GameObject DLNMCGFEPOP, RigidbodyEx MCLIFNMABNA, BKDMDHLJAEJ CMIHNHHBGOO, in JCAJMGPJNDN HIDEHJGLNHO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600048A")]
	[Cpp2IlInjected.Address(RVA = "0x57C2070", Offset = "0x57C1470", VA = "0x1857C2070", Slot = "142")]
	protected override void FOIMKAENAPH(BKDMDHLJAEJ CMIHNHHBGOO, JCAJMGPJNDN HIDEHJGLNHO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600048B")]
	[Cpp2IlInjected.Address(RVA = "0x57C1D50", Offset = "0x57C1150", VA = "0x1857C1D50", Slot = "143")]
	public override void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600048C")]
	[Cpp2IlInjected.Address(RVA = "0x57C1FA0", Offset = "0x57C13A0", VA = "0x1857C1FA0", Slot = "145")]
	public void FFNAHMJFGNN(PHOCPPOEDBC DKOFAPECACL, PHOCPPOEDBC JFNADPGFOAB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600048D")]
	[Cpp2IlInjected.Address(RVA = "0x57C1EE0", Offset = "0x57C12E0", VA = "0x1857C1EE0", Slot = "146")]
	public void EBCHKCMKFFL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600048E")]
	[Cpp2IlInjected.Address(RVA = "0x57C2460", Offset = "0x57C1860", VA = "0x1857C2460", Slot = "147")]
	public void LECPOGDAAEN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600048F")]
	[Cpp2IlInjected.Address(RVA = "0x57C2520", Offset = "0x57C1920", VA = "0x1857C2520", Slot = "148")]
	public void PHLPAOAPADB(bool DFLJHGHEKJD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000490")]
	[Cpp2IlInjected.Address(RVA = "0x57C2300", Offset = "0x57C1700", VA = "0x1857C2300", Slot = "149")]
	public bool KOAJJHHAGFJ()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000491")]
	[Cpp2IlInjected.Address(RVA = "0x72E830", Offset = "0x72DC30", VA = "0x18072E830", Slot = "144")]
	public override void MCKPAKFDOPH()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000046")]
internal static class LPLLHKKDBOF
{
	[Cpp2IlInjected.Token(Token = "0x6000492")]
	[Cpp2IlInjected.Address(RVA = "0x57C3330", Offset = "0x57C2730", VA = "0x1857C3330")]
	public static PLOEBEDJGLE GCBNHDAINOK(this NCOEFPHLCKK NLKDOMNEDBE)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000047")]
public interface BAOLOJAHLLA : PLDJMDIFCKE, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x6000493")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void LBIPGKKJCGE(NCOEFPHLCKK IILFNNEDNCJ);

	[Cpp2IlInjected.Token(Token = "0x6000494")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void FHJPDJCNJIO(NCOEFPHLCKK IILFNNEDNCJ);

	[Cpp2IlInjected.Token(Token = "0x6000495")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void OAJEEOBFKGI(NCOEFPHLCKK EMJBGADPLOE);

	[Cpp2IlInjected.Token(Token = "0x6000496")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void FEBKLPDLGMF(NCOEFPHLCKK EMJBGADPLOE);
}
[Cpp2IlInjected.Token(Token = "0x2000048")]
public interface HOBENBLCEGH : IMBEMHENMNJ
{
	[Cpp2IlInjected.Token(Token = "0x17000130")]
	global::NFFFIELCCID<NCOEFPHLCKK> PCADFNIAGAD
	{
		[Cpp2IlInjected.Token(Token = "0x6000497")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000131")]
	NCOEFPHLCKK KJCAOKIHBIK
	{
		[Cpp2IlInjected.Token(Token = "0x6000498")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000049")]
public interface EJLCPNDNOPA : OGBLFJOOHEI
{
	[Cpp2IlInjected.Token(Token = "0x6000499")]
	[Cpp2IlInjected.Address(Slot = "0")]
	(float, Vector3) HCPEECAOGOM(Rigidbody BMDOKJBOKPE);
}
[Cpp2IlInjected.Token(Token = "0x200004A")]
public interface KJOHJJNNODA : INNKCACPKLA, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x17000132")]
	PhotonView PPFKDGBOMAG
	{
		[Cpp2IlInjected.Token(Token = "0x600049A")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x200004B")]
internal sealed class DHCELJMCPKJ : AIOOGANOGPH
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000085")]
	private readonly PLOEBEDJGLE IILFNNEDNCJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000086")]
	private CollisionDetectionMode ODBBONENPLE;

	[Cpp2IlInjected.Token(Token = "0x17000133")]
	private Rigidbody LNMDHFKNJIH
	{
		[Cpp2IlInjected.Token(Token = "0x600049B")]
		[Cpp2IlInjected.Address(RVA = "0x57AB800", Offset = "0x57AAC00", VA = "0x1857AB800")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000134")]
	public CollisionDetectionMode PAOOKBBFCLK
	{
		[Cpp2IlInjected.Token(Token = "0x600049F")]
		[Cpp2IlInjected.Address(RVA = "0x57AC670", Offset = "0x57ABA70", VA = "0x1857AC670", Slot = "4")]
		get
		{
			return default(CollisionDetectionMode);
		}
		[Cpp2IlInjected.Token(Token = "0x60004A0")]
		[Cpp2IlInjected.Address(RVA = "0x57AC490", Offset = "0x57AB890", VA = "0x1857AC490", Slot = "5")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600049C")]
	[Cpp2IlInjected.Address(RVA = "0x57AC8A0", Offset = "0x57ABCA0", VA = "0x1857AC8A0")]
	public DHCELJMCPKJ(NCOEFPHLCKK IILFNNEDNCJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600049D")]
	[Cpp2IlInjected.Address(RVA = "0x57AC780", Offset = "0x57ABB80", VA = "0x1857AC780", Slot = "6")]
	public void PBJONABJOBO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600049E")]
	[Cpp2IlInjected.Address(RVA = "0x57AC2C0", Offset = "0x57AB6C0", VA = "0x1857AC2C0", Slot = "9")]
	public void BOFMJFDPNBF(Rigidbody GHAGIOLHPMN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004A1")]
	[Cpp2IlInjected.Address(RVA = "0x57AC470", Offset = "0x57AB870", VA = "0x1857AC470", Slot = "7")]
	public void DLGGDMCBIHM(bool OJNHEHLGDGI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004A2")]
	[Cpp2IlInjected.Address(RVA = "0x57AC480", Offset = "0x57AB880", VA = "0x1857AC480", Slot = "8")]
	public void FICHJHCOBIG(bool OJNHEHLGDGI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004A3")]
	[Cpp2IlInjected.Address(RVA = "0x57AC500", Offset = "0x57AB900", VA = "0x1857AC500", Slot = "10")]
	public bool OFDKFHJBLOJ(Vector3 MFKKMPGAJFI, out RaycastHit ONOMCDOFLKH, float CBFODBDKBEK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60004A4")]
	[Cpp2IlInjected.Address(RVA = "0x57AC340", Offset = "0x57AB740", VA = "0x1857AC340")]
	private void DAOOMGFPAAE(bool OJNHEHLGDGI)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200004C")]
public sealed class DFEIONJIKJB : JBCOLILENLD, IDisposable, FLCKAICBODN
{
	[Cpp2IlInjected.Token(Token = "0x4000087")]
	public const int ANLGCFMELOM = 350;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000089")]
	private readonly PLOEBEDJGLE IILFNNEDNCJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400008A")]
	private GGPABLKNBJB IOBNLGDAEOH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400008B")]
	private KKMENLLDAPN EJCAONAAFLL;

	[Cpp2IlInjected.Token(Token = "0x17000135")]
	public GGPABLKNBJB LEKOFMMMFBB
	{
		[Cpp2IlInjected.Token(Token = "0x60004A7")]
		[Cpp2IlInjected.Address(RVA = "0x57AAEB0", Offset = "0x57AA2B0", VA = "0x1857AAEB0", Slot = "6")]
		get
		{
			return default(GGPABLKNBJB);
		}
		[Cpp2IlInjected.Token(Token = "0x60004A8")]
		[Cpp2IlInjected.Address(RVA = "0x57AAD60", Offset = "0x57AA160", VA = "0x1857AAD60", Slot = "7")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000136")]
	private Transform OACKHJKFCIO
	{
		[Cpp2IlInjected.Token(Token = "0x60004A9")]
		[Cpp2IlInjected.Address(RVA = "0x57AAE90", Offset = "0x57AA290", VA = "0x1857AAE90", Slot = "10")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000041")]
	public event Action<FCDCKNBKJML, FCDCKNBKJML> DLLBDKMMJIP
	{
		[Cpp2IlInjected.Token(Token = "0x60004A5")]
		[Cpp2IlInjected.Address(RVA = "0x57AAC70", Offset = "0x57AA070", VA = "0x1857AAC70", Slot = "4")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60004A6")]
		[Cpp2IlInjected.Address(RVA = "0x57AAFF0", Offset = "0x57AA3F0", VA = "0x1857AAFF0", Slot = "5")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60004AA")]
	[Cpp2IlInjected.Address(RVA = "0x57AB370", Offset = "0x57AA770", VA = "0x1857AB370")]
	public DFEIONJIKJB(NCOEFPHLCKK IILFNNEDNCJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004AB")]
	[Cpp2IlInjected.Address(RVA = "0x57AB090", Offset = "0x57AA490", VA = "0x1857AB090", Slot = "8")]
	public void PBJONABJOBO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004AC")]
	[Cpp2IlInjected.Address(RVA = "0x57AAD10", Offset = "0x57AA110", VA = "0x1857AAD10", Slot = "9")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004AD")]
	[Cpp2IlInjected.Address(RVA = "0x57AAE30", Offset = "0x57AA230", VA = "0x1857AAE30", Slot = "11")]
	private void FFJAMPMFIBH(FCDCKNBKJML NBPFLJDNNCH, FCDCKNBKJML ABBGLPJCAMC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004AE")]
	[Cpp2IlInjected.Address(RVA = "0x72E830", Offset = "0x72DC30", VA = "0x18072E830", Slot = "12")]
	private void CDNBHJPFKMB(bool FHFGDHHLCHJ)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200004D")]
internal sealed class IIFHDLPGBCO : BDJOPHNNEJG
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400008C")]
	private readonly PLOEBEDJGLE IILFNNEDNCJ;

	[Cpp2IlInjected.Token(Token = "0x17000137")]
	private Rigidbody LNMDHFKNJIH
	{
		[Cpp2IlInjected.Token(Token = "0x60004AF")]
		[Cpp2IlInjected.Address(RVA = "0x57AB800", Offset = "0x57AAC00", VA = "0x1857AB800")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000138")]
	private bool FAJNDFDCOGA
	{
		[Cpp2IlInjected.Token(Token = "0x60004B0")]
		[Cpp2IlInjected.Address(RVA = "0x57ABDB0", Offset = "0x57AB1B0", VA = "0x1857ABDB0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000139")]
	private bool KMDIPAOGGGF
	{
		[Cpp2IlInjected.Token(Token = "0x60004B1")]
		[Cpp2IlInjected.Address(RVA = "0x57ABD50", Offset = "0x57AB150", VA = "0x1857ABD50")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700013A")]
	private NCOEFPHLCKK GKEMABFNEME
	{
		[Cpp2IlInjected.Token(Token = "0x60004B2")]
		[Cpp2IlInjected.Address(RVA = "0x57BD050", Offset = "0x57BC450", VA = "0x1857BD050")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60004B3")]
	[Cpp2IlInjected.Address(RVA = "0x57AC8A0", Offset = "0x57ABCA0", VA = "0x1857AC8A0")]
	public IIFHDLPGBCO(NCOEFPHLCKK IILFNNEDNCJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004B4")]
	[Cpp2IlInjected.Address(RVA = "0x57BC750", Offset = "0x57BBB50", VA = "0x1857BC750", Slot = "4")]
	public void BEJNHGKJNLM(Vector3 HKPPDHFDHMN, ForceMode MPMGBCACKOF = ForceMode.Force)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004B5")]
	[Cpp2IlInjected.Address(RVA = "0x57BCB50", Offset = "0x57BBF50", VA = "0x1857BCB50")]
	private void GNLGGMKPOAG(Vector3 HKPPDHFDHMN, ForceMode MPMGBCACKOF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004B6")]
	[Cpp2IlInjected.Address(RVA = "0x57BC8B0", Offset = "0x57BBCB0", VA = "0x1857BC8B0", Slot = "5")]
	public void CBMEMNKKLDE(Vector3 HKPPDHFDHMN, Vector3 PICDPPHNNLH, ForceMode MPMGBCACKOF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004B7")]
	[Cpp2IlInjected.Address(RVA = "0x57BD0B0", Offset = "0x57BC4B0", VA = "0x1857BD0B0", Slot = "6")]
	public void OHNHDPGFLAC(Vector3 MBBMKANKKGB, ForceMode MPMGBCACKOF = ForceMode.Force)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004B8")]
	[Cpp2IlInjected.Address(RVA = "0x57BCDD0", Offset = "0x57BC1D0", VA = "0x1857BCDD0")]
	private void HDEEJGEFJJL(Vector3 MBBMKANKKGB, ForceMode MPMGBCACKOF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004B9")]
	[Cpp2IlInjected.Address(RVA = "0x57BD210", Offset = "0x57BC610", VA = "0x1857BD210", Slot = "7")]
	public void PPDGHDJCFAP(Vector3 MBBMKANKKGB, ForceMode MPMGBCACKOF = ForceMode.Force)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200004E")]
internal sealed class PGOGIEBHIFE : BBGAPPNBFLO
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400008D")]
	private readonly PLOEBEDJGLE IILFNNEDNCJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400008E")]
	private bool ECEFGAGMMPK;

	[Cpp2IlInjected.Token(Token = "0x1700013B")]
	public bool OGIIANAEIFL
	{
		[Cpp2IlInjected.Token(Token = "0x60004BB")]
		[Cpp2IlInjected.Address(RVA = "0x72F260", Offset = "0x72E660", VA = "0x18072F260", Slot = "4")]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x60004BC")]
		[Cpp2IlInjected.Address(RVA = "0x57CB090", Offset = "0x57CA490", VA = "0x1857CB090", Slot = "5")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60004BA")]
	[Cpp2IlInjected.Address(RVA = "0x57AC8A0", Offset = "0x57ABCA0", VA = "0x1857AC8A0")]
	public PGOGIEBHIFE(NCOEFPHLCKK IILFNNEDNCJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004BD")]
	[Cpp2IlInjected.Address(RVA = "0x57CB060", Offset = "0x57CA460", VA = "0x1857CB060", Slot = "6")]
	public void BOFMJFDPNBF(Rigidbody GHAGIOLHPMN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004BE")]
	[Cpp2IlInjected.Address(RVA = "0x57C42C0", Offset = "0x57C36C0", VA = "0x1857C42C0", Slot = "7")]
	public void PKFCGBCFJGD(Rigidbody GHAGIOLHPMN)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200004F")]
internal sealed class IBJNOEFNELA : BAOLOJAHLLA, PLDJMDIFCKE, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x4000098")]
	private readonly NCOEFPHLCKK IILFNNEDNCJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x4000099")]
	private readonly List<NCOEFPHLCKK> BOGHIFKGACA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x400009A")]
	private NCOEFPHLCKK EAGPPNPHOBG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x400009B")]
	private NCOEFPHLCKK GGEKFPEBLKN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
	[Cpp2IlInjected.Token(Token = "0x400009C")]
	private Transform LNOINKFMENB;

	[Cpp2IlInjected.Token(Token = "0x1700013C")]
	private Transform LHEBMCHBDEI
	{
		[Cpp2IlInjected.Token(Token = "0x60004D1")]
		[Cpp2IlInjected.Address(RVA = "0x57B7D50", Offset = "0x57B7150", VA = "0x1857B7D50")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700013D")]
	public NCOEFPHLCKK GKEMABFNEME
	{
		[Cpp2IlInjected.Token(Token = "0x60004D4")]
		[Cpp2IlInjected.Address(RVA = "0x72B040", Offset = "0x72A440", VA = "0x18072B040", Slot = "28")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60004D5")]
		[Cpp2IlInjected.Address(RVA = "0x57B6F90", Offset = "0x57B6390", VA = "0x1857B6F90", Slot = "29")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700013E")]
	public NCOEFPHLCKK CMJKBCMDGHN
	{
		[Cpp2IlInjected.Token(Token = "0x60004D6")]
		[Cpp2IlInjected.Address(RVA = "0x72B0C0", Offset = "0x72A4C0", VA = "0x18072B0C0", Slot = "27")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700013F")]
	public IReadOnlyList<NCOEFPHLCKK> PHPDFDJEEEA
	{
		[Cpp2IlInjected.Token(Token = "0x60004D7")]
		[Cpp2IlInjected.Address(RVA = "0x72B0B0", Offset = "0x72A4B0", VA = "0x18072B0B0", Slot = "26")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000042")]
	public event DGAAFHCPHEH NJJHHELIHIP
	{
		[Cpp2IlInjected.Token(Token = "0x60004BF")]
		[Cpp2IlInjected.Address(RVA = "0x57B83A0", Offset = "0x57B77A0", VA = "0x1857B83A0", Slot = "8")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60004C0")]
		[Cpp2IlInjected.Address(RVA = "0x57B84E0", Offset = "0x57B78E0", VA = "0x1857B84E0", Slot = "9")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000043")]
	public event DGAAFHCPHEH EPBNCIPAFDB
	{
		[Cpp2IlInjected.Token(Token = "0x60004C1")]
		[Cpp2IlInjected.Address(RVA = "0x57B80D0", Offset = "0x57B74D0", VA = "0x1857B80D0", Slot = "10")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60004C2")]
		[Cpp2IlInjected.Address(RVA = "0x57B7F90", Offset = "0x57B7390", VA = "0x1857B7F90", Slot = "11")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000044")]
	public event MKKJLKCGEAC EIBHEHIGCNB
	{
		[Cpp2IlInjected.Token(Token = "0x60004C3")]
		[Cpp2IlInjected.Address(RVA = "0x57B8030", Offset = "0x57B7430", VA = "0x1857B8030", Slot = "12")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60004C4")]
		[Cpp2IlInjected.Address(RVA = "0x57B8170", Offset = "0x57B7570", VA = "0x1857B8170", Slot = "13")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000045")]
	public event Action PFANGAANPGN
	{
		[Cpp2IlInjected.Token(Token = "0x60004C5")]
		[Cpp2IlInjected.Address(RVA = "0x57B8210", Offset = "0x57B7610", VA = "0x1857B8210", Slot = "14")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60004C6")]
		[Cpp2IlInjected.Address(RVA = "0x57B86B0", Offset = "0x57B7AB0", VA = "0x1857B86B0", Slot = "15")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000046")]
	public event Action NJGCKLJKCAG
	{
		[Cpp2IlInjected.Token(Token = "0x60004C7")]
		[Cpp2IlInjected.Address(RVA = "0x57B7EF0", Offset = "0x57B72F0", VA = "0x1857B7EF0", Slot = "16")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60004C8")]
		[Cpp2IlInjected.Address(RVA = "0x57B7080", Offset = "0x57B6480", VA = "0x1857B7080", Slot = "17")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000047")]
	public event Action<NCOEFPHLCKK> NFDMKCEEBKO
	{
		[Cpp2IlInjected.Token(Token = "0x60004C9")]
		[Cpp2IlInjected.Address(RVA = "0x57B8AD0", Offset = "0x57B7ED0", VA = "0x1857B8AD0", Slot = "18")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60004CA")]
		[Cpp2IlInjected.Address(RVA = "0x57B7DB0", Offset = "0x57B71B0", VA = "0x1857B7DB0", Slot = "19")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000048")]
	public event Action<NCOEFPHLCKK> AMBCDPFGEAJ
	{
		[Cpp2IlInjected.Token(Token = "0x60004CB")]
		[Cpp2IlInjected.Address(RVA = "0x57B7E50", Offset = "0x57B7250", VA = "0x1857B7E50", Slot = "20")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60004CC")]
		[Cpp2IlInjected.Address(RVA = "0x57B7B80", Offset = "0x57B6F80", VA = "0x1857B7B80", Slot = "21")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000049")]
	public event Action KKKJMJHLIKB
	{
		[Cpp2IlInjected.Token(Token = "0x60004CD")]
		[Cpp2IlInjected.Address(RVA = "0x57B7740", Offset = "0x57B6B40", VA = "0x1857B7740", Slot = "22")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60004CE")]
		[Cpp2IlInjected.Address(RVA = "0x57B6FA0", Offset = "0x57B63A0", VA = "0x1857B6FA0", Slot = "23")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400004A")]
	public event Action<NCOEFPHLCKK> PFJIOBMDLAL
	{
		[Cpp2IlInjected.Token(Token = "0x60004CF")]
		[Cpp2IlInjected.Address(RVA = "0x57B7AE0", Offset = "0x57B6EE0", VA = "0x1857B7AE0", Slot = "24")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60004D0")]
		[Cpp2IlInjected.Address(RVA = "0x57B8610", Offset = "0x57B7A10", VA = "0x1857B8610", Slot = "25")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60004D2")]
	[Cpp2IlInjected.Address(RVA = "0x57B8CC0", Offset = "0x57B80C0", VA = "0x1857B8CC0")]
	public IBJNOEFNELA(NCOEFPHLCKK IILFNNEDNCJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004D3")]
	[Cpp2IlInjected.Address(RVA = "0x57B76C0", Offset = "0x57B6AC0", VA = "0x1857B76C0", Slot = "31")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004D8")]
	[Cpp2IlInjected.Address(RVA = "0x57B7120", Offset = "0x57B6520", VA = "0x1857B7120", Slot = "30")]
	public void DEIBNNOCJKC(NCOEFPHLCKK BJNIPOLNMLD, bool OMIKAFGHIFK = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004D9")]
	[Cpp2IlInjected.Address(RVA = "0x57B8880", Offset = "0x57B7C80", VA = "0x1857B8880", Slot = "6")]
	public void OAJEEOBFKGI(NCOEFPHLCKK EMJBGADPLOE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004DA")]
	[Cpp2IlInjected.Address(RVA = "0x57B77E0", Offset = "0x57B6BE0", VA = "0x1857B77E0", Slot = "7")]
	public void FEBKLPDLGMF(NCOEFPHLCKK EMJBGADPLOE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004DB")]
	[Cpp2IlInjected.Address(RVA = "0x57B8440", Offset = "0x57B7840", VA = "0x1857B8440", Slot = "4")]
	public void LBIPGKKJCGE(NCOEFPHLCKK IILFNNEDNCJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004DC")]
	[Cpp2IlInjected.Address(RVA = "0x57B7A40", Offset = "0x57B6E40", VA = "0x1857B7A40", Slot = "5")]
	public void FHJPDJCNJIO(NCOEFPHLCKK IILFNNEDNCJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004DD")]
	[Cpp2IlInjected.Address(RVA = "0x57B8580", Offset = "0x57B7980", VA = "0x1857B8580")]
	private void MAFJOMEFHJN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004DE")]
	[Cpp2IlInjected.Address(RVA = "0x57B7040", Offset = "0x57B6440", VA = "0x1857B7040")]
	private void CIAELCNFLBC(NCOEFPHLCKK EMJBGADPLOE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004DF")]
	[Cpp2IlInjected.Address(RVA = "0x57B8B70", Offset = "0x57B7F70", VA = "0x1857B8B70")]
	private void PPAJNJCEOJP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004E0")]
	[Cpp2IlInjected.Address(RVA = "0x57B8750", Offset = "0x57B7B50", VA = "0x1857B8750")]
	private void MJFKBFMOHPL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004E1")]
	[Cpp2IlInjected.Address(RVA = "0x57B7C20", Offset = "0x57B7020", VA = "0x1857B7C20")]
	private void GCCACPFBAFO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004E2")]
	[Cpp2IlInjected.Address(RVA = "0x57B82B0", Offset = "0x57B76B0", VA = "0x1857B82B0")]
	[CompilerGenerated]
	private object JPNEAMCDIFO()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000050")]
internal static class MECBMGLNGLE
{
	[Cpp2IlInjected.Token(Token = "0x60004E3")]
	[Cpp2IlInjected.Address(RVA = "0x57C3380", Offset = "0x57C2780", VA = "0x1857C3380")]
	public static BAOLOJAHLLA EHJMHIENHGI(this NCOEFPHLCKK NLKDOMNEDBE)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000051")]
internal sealed class AAMJEFJMFFB : HOBENBLCEGH, IMBEMHENMNJ
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400009D")]
	private readonly PLOEBEDJGLE IILFNNEDNCJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400009E")]
	private readonly global::NFFFIELCCID<NCOEFPHLCKK> MINDKHLMMEA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400009F")]
	private bool AHJHOHPBMLN;

	[Cpp2IlInjected.Token(Token = "0x17000140")]
	public global::NFFFIELCCID<NCOEFPHLCKK> PCADFNIAGAD
	{
		[Cpp2IlInjected.Token(Token = "0x60004E4")]
		[Cpp2IlInjected.Address(RVA = "0x72B030", Offset = "0x72A430", VA = "0x18072B030", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000141")]
	public Vector3 BFENAJAEKJN
	{
		[Cpp2IlInjected.Token(Token = "0x60004E5")]
		[Cpp2IlInjected.Address(RVA = "0x57A8B60", Offset = "0x57A7F60", VA = "0x1857A8B60", Slot = "6")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000142")]
	public Vector3 LECHPMMLACE
	{
		[Cpp2IlInjected.Token(Token = "0x60004E6")]
		[Cpp2IlInjected.Address(RVA = "0x57A8580", Offset = "0x57A7980", VA = "0x1857A8580", Slot = "7")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000143")]
	private Vector3 LGEGEJPPDAD
	{
		[Cpp2IlInjected.Token(Token = "0x60004EA")]
		[Cpp2IlInjected.Address(RVA = "0x57A8040", Offset = "0x57A7440", VA = "0x1857A8040")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000144")]
	public NCOEFPHLCKK KJCAOKIHBIK
	{
		[Cpp2IlInjected.Token(Token = "0x60004EB")]
		[Cpp2IlInjected.Address(RVA = "0x57A8470", Offset = "0x57A7870", VA = "0x1857A8470", Slot = "5")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60004E7")]
	[Cpp2IlInjected.Address(RVA = "0x57A8B90", Offset = "0x57A7F90", VA = "0x1857A8B90")]
	public AAMJEFJMFFB(NCOEFPHLCKK IILFNNEDNCJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004E8")]
	[Cpp2IlInjected.Address(RVA = "0x57A8750", Offset = "0x57A7B50", VA = "0x1857A8750", Slot = "8")]
	public void IOHAPAEGEFD(NCOEFPHLCKK GGEKFPEBLKN, object MIFCLBEAOPM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004E9")]
	[Cpp2IlInjected.Address(RVA = "0x57A8520", Offset = "0x57A7920", VA = "0x1857A8520", Slot = "9")]
	public void DNECHJALIBL(object MIFCLBEAOPM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004EC")]
	[Cpp2IlInjected.Address(RVA = "0x57A8120", Offset = "0x57A7520", VA = "0x1857A8120")]
	private Vector3 BIHFLNGABAB()
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x60004ED")]
	[Cpp2IlInjected.Address(RVA = "0x57A87C0", Offset = "0x57A7BC0", VA = "0x1857A87C0")]
	private void LMCLHJOPLFN(NCOEFPHLCKK ICONGCOMDAB)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000052")]
internal static class KDBNNAEOBEC
{
	[Cpp2IlInjected.Token(Token = "0x60004EE")]
	[Cpp2IlInjected.Address(RVA = "0x57C0DD0", Offset = "0x57C01D0", VA = "0x1857C0DD0")]
	public static HOBENBLCEGH FCOMDNGDAPJ(this NCOEFPHLCKK NLKDOMNEDBE)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000053")]
internal sealed class GKILPNGPKKF : EJLCPNDNOPA, OGBLFJOOHEI
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000A1")]
	private readonly PLOEBEDJGLE IILFNNEDNCJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000A2")]
	private readonly OverridableVector3 OCCIBCJMCMD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40000A3")]
	private readonly OverridableVector3 DDBDFGDEJNG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x40000A4")]
	private float BJEKPKOHOHD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x44")]
	[Cpp2IlInjected.Token(Token = "0x40000A5")]
	private float NJAPMMIKJGK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x40000A6")]
	private Vector3 GMBCHMBJMEK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x54")]
	[Cpp2IlInjected.Token(Token = "0x40000A7")]
	private Vector3? OLICLKGPABG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x64")]
	[Cpp2IlInjected.Token(Token = "0x40000A8")]
	private Quaternion? AIDBIHPFFIK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
	[Cpp2IlInjected.Token(Token = "0x40000A9")]
	private bool ICBJHGNDPNH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x79")]
	[Cpp2IlInjected.Token(Token = "0x40000AA")]
	private bool FFNAKAHNLAF;

	[Cpp2IlInjected.Token(Token = "0x17000145")]
	public Vector3 BMNHHGGIMHD
	{
		[Cpp2IlInjected.Token(Token = "0x60004F1")]
		[Cpp2IlInjected.Address(RVA = "0xDD2390", Offset = "0xDD1790", VA = "0x180DD2390", Slot = "7")]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x60004F2")]
		[Cpp2IlInjected.Address(RVA = "0x57B25D0", Offset = "0x57B19D0", VA = "0x1857B25D0", Slot = "8")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000146")]
	public Vector3 ICDJEGJHDEE
	{
		[Cpp2IlInjected.Token(Token = "0x60004F3")]
		[Cpp2IlInjected.Address(RVA = "0x57B3BC0", Offset = "0x57B2FC0", VA = "0x1857B3BC0", Slot = "9")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000147")]
	public float AHNCJOKPCCM
	{
		[Cpp2IlInjected.Token(Token = "0x60004F4")]
		[Cpp2IlInjected.Address(RVA = "0xF19A50", Offset = "0xF18E50", VA = "0x180F19A50", Slot = "10")]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x60004F5")]
		[Cpp2IlInjected.Address(RVA = "0x57B3FF0", Offset = "0x57B33F0", VA = "0x1857B3FF0")]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000148")]
	public float JAHICELIBID
	{
		[Cpp2IlInjected.Token(Token = "0x60004F6")]
		[Cpp2IlInjected.Address(RVA = "0xF09170", Offset = "0xF08570", VA = "0x180F09170", Slot = "11")]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x60004F7")]
		[Cpp2IlInjected.Address(RVA = "0x57B3CC0", Offset = "0x57B30C0", VA = "0x1857B3CC0", Slot = "12")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000149")]
	public Vector3 JLIOGCPKLOL
	{
		[Cpp2IlInjected.Token(Token = "0x60004F8")]
		[Cpp2IlInjected.Address(RVA = "0x57B1D60", Offset = "0x57B1160", VA = "0x1857B1D60", Slot = "13")]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x60004F9")]
		[Cpp2IlInjected.Address(RVA = "0x57B3CE0", Offset = "0x57B30E0", VA = "0x1857B3CE0", Slot = "14")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700014A")]
	public Quaternion OCGLMIOIKKA
	{
		[Cpp2IlInjected.Token(Token = "0x60004FA")]
		[Cpp2IlInjected.Address(RVA = "0x57B2AB0", Offset = "0x57B1EB0", VA = "0x1857B2AB0", Slot = "15")]
		get
		{
			return default(Quaternion);
		}
		[Cpp2IlInjected.Token(Token = "0x60004FB")]
		[Cpp2IlInjected.Address(RVA = "0x57B41B0", Offset = "0x57B35B0", VA = "0x1857B41B0", Slot = "16")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700014B")]
	private Rigidbody LNMDHFKNJIH
	{
		[Cpp2IlInjected.Token(Token = "0x6000503")]
		[Cpp2IlInjected.Address(RVA = "0x57AA030", Offset = "0x57A9430", VA = "0x1857AA030")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400004B")]
	public event DGAAFHCPHEH IBFMPJKFDEA
	{
		[Cpp2IlInjected.Token(Token = "0x60004EF")]
		[Cpp2IlInjected.Address(RVA = "0x57B4110", Offset = "0x57B3510", VA = "0x1857B4110", Slot = "5")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60004F0")]
		[Cpp2IlInjected.Address(RVA = "0x57B26D0", Offset = "0x57B1AD0", VA = "0x1857B26D0", Slot = "6")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60004FC")]
	[Cpp2IlInjected.Address(RVA = "0x57B46E0", Offset = "0x57B3AE0", VA = "0x1857B46E0")]
	public GKILPNGPKKF(NCOEFPHLCKK IILFNNEDNCJ, in JCAJMGPJNDN HIDEHJGLNHO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004FD")]
	[Cpp2IlInjected.Address(RVA = "0x57B28F0", Offset = "0x57B1CF0", VA = "0x1857B28F0", Slot = "18")]
	public void FCDPOIHJAAG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004FE")]
	[Cpp2IlInjected.Address(RVA = "0x57B1ED0", Offset = "0x57B12D0", VA = "0x1857B1ED0", Slot = "17")]
	public void AEAABDHDFFI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004FF")]
	[Cpp2IlInjected.Address(RVA = "0x57B25F0", Offset = "0x57B19F0", VA = "0x1857B25F0", Slot = "20")]
	public void BOFMJFDPNBF(Rigidbody GHAGIOLHPMN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000500")]
	[Cpp2IlInjected.Address(RVA = "0x57B4440", Offset = "0x57B3840", VA = "0x1857B4440", Slot = "21")]
	public void PKFCGBCFJGD(Rigidbody GHAGIOLHPMN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000501")]
	[Cpp2IlInjected.Address(RVA = "0x57B3E80", Offset = "0x57B3280", VA = "0x1857B3E80", Slot = "19")]
	public void IEIECPGHPLP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000502")]
	[Cpp2IlInjected.Address(RVA = "0x57B1FB0", Offset = "0x57B13B0", VA = "0x1857B1FB0", Slot = "22")]
	public void AMJHKJLPLNB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000504")]
	[Cpp2IlInjected.Address(RVA = "0x57B25D0", Offset = "0x57B19D0", VA = "0x1857B25D0")]
	private void PNBIFKFCFEF(Vector3 LPJDDLMPNCG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000505")]
	[Cpp2IlInjected.Address(RVA = "0x57B4350", Offset = "0x57B3750", VA = "0x1857B4350")]
	private Vector3 OMGBOJNFENG()
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000506")]
	[Cpp2IlInjected.Address(RVA = "0x57B3FF0", Offset = "0x57B33F0", VA = "0x1857B3FF0")]
	private void MMGDLCDAMEC(float LPJDDLMPNCG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000507")]
	[Cpp2IlInjected.Address(RVA = "0x57B3CC0", Offset = "0x57B30C0", VA = "0x1857B3CC0")]
	private void IAOOGBCNABD(float LPJDDLMPNCG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000508")]
	[Cpp2IlInjected.Address(RVA = "0x57B2770", Offset = "0x57B1B70", VA = "0x1857B2770")]
	private Vector3 EMNKCDOKIJP()
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000509")]
	[Cpp2IlInjected.Address(RVA = "0x57B3CE0", Offset = "0x57B30E0", VA = "0x1857B3CE0")]
	private void PBMBMDIIBMG(Vector3 LPJDDLMPNCG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600050A")]
	[Cpp2IlInjected.Address(RVA = "0x57B2470", Offset = "0x57B1870", VA = "0x1857B2470")]
	private Quaternion ANKHAKNDHKM()
	{
		return default(Quaternion);
	}

	[Cpp2IlInjected.Token(Token = "0x600050B")]
	[Cpp2IlInjected.Address(RVA = "0x57B41B0", Offset = "0x57B35B0", VA = "0x1857B41B0")]
	private void PMCIAKDJBLM(Quaternion LPJDDLMPNCG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600050C")]
	[Cpp2IlInjected.Address(RVA = "0x57B2C20", Offset = "0x57B2020", VA = "0x1857B2C20")]
	public void HCPEECAOGOM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600050D")]
	[Cpp2IlInjected.Address(RVA = "0x57B2D00", Offset = "0x57B2100", VA = "0x1857B2D00", Slot = "4")]
	public (float, Vector3) HCPEECAOGOM(Rigidbody BMDOKJBOKPE)
	{
		return default((float, Vector3));
	}
}
[Cpp2IlInjected.Token(Token = "0x2000054")]
internal static class HHOJEEAPIPJ
{
	[Cpp2IlInjected.Token(Token = "0x600050E")]
	[Cpp2IlInjected.Address(RVA = "0x57B4C20", Offset = "0x57B4020", VA = "0x1857B4C20")]
	public static EJLCPNDNOPA JIDBPFDBCJM(this NCOEFPHLCKK NLKDOMNEDBE)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000055")]
internal sealed class JIFLPFKICCE : LBPABMNHAKF
{
	[Cpp2IlInjected.Token(Token = "0x40000AB")]
	private const string DKCLIMFPCAB = "INTERP_PAUSE";

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000AC")]
	private readonly PLOEBEDJGLE IILFNNEDNCJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000AD")]
	private readonly BHECNCBBLMC NIFKNKCEHBL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000AE")]
	private readonly JGBCGHMDEIJ FAACPMLGAIL;

	[Cpp2IlInjected.Token(Token = "0x1700014C")]
	public bool OJDFKEJHLKC
	{
		[Cpp2IlInjected.Token(Token = "0x600050F")]
		[Cpp2IlInjected.Address(RVA = "0x11AB9A0", Offset = "0x11AADA0", VA = "0x1811AB9A0", Slot = "4")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700014D")]
	public JGBCGHMDEIJ PAEMELMEBEE
	{
		[Cpp2IlInjected.Token(Token = "0x6000510")]
		[Cpp2IlInjected.Address(RVA = "0x735750", Offset = "0x734B50", VA = "0x180735750", Slot = "5")]
		get
		{
			return default(JGBCGHMDEIJ);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000511")]
	[Cpp2IlInjected.Address(RVA = "0x57BE030", Offset = "0x57BD430", VA = "0x1857BE030")]
	public JIFLPFKICCE(NCOEFPHLCKK IILFNNEDNCJ, in JCAJMGPJNDN HIDEHJGLNHO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000512")]
	[Cpp2IlInjected.Address(RVA = "0x57BDF60", Offset = "0x57BD360", VA = "0x1857BDF60", Slot = "6")]
	public void PBJONABJOBO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000513")]
	[Cpp2IlInjected.Address(RVA = "0x57BDA50", Offset = "0x57BCE50", VA = "0x1857BDA50")]
	private bool BPCPFBNLLLH()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000514")]
	[Cpp2IlInjected.Address(RVA = "0x57BDA20", Offset = "0x57BCE20", VA = "0x1857BDA20", Slot = "7")]
	public void BBPFDNFCENP(object MIFCLBEAOPM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000515")]
	[Cpp2IlInjected.Address(RVA = "0x57BDC20", Offset = "0x57BD020", VA = "0x1857BDC20", Slot = "8")]
	public void JDDFJPPACKN(object MIFCLBEAOPM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000516")]
	[Cpp2IlInjected.Address(RVA = "0x57BDAF0", Offset = "0x57BCEF0", VA = "0x1857BDAF0", Slot = "11")]
	public void EKFOLENAMJE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000517")]
	[Cpp2IlInjected.Address(RVA = "0x57BDE10", Offset = "0x57BD210", VA = "0x1857BDE10")]
	private void NLCICEBEBHM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000518")]
	[Cpp2IlInjected.Address(RVA = "0x57BDC90", Offset = "0x57BD090", VA = "0x1857BDC90")]
	private void LPEGKOLKNAO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000519")]
	[Cpp2IlInjected.Address(RVA = "0x57BDC50", Offset = "0x57BD050", VA = "0x1857BDC50", Slot = "10")]
	public void KONHDGEMJBN(NCOEFPHLCKK IILFNNEDNCJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600051A")]
	[Cpp2IlInjected.Address(RVA = "0x57BDF20", Offset = "0x57BD320", VA = "0x1857BDF20", Slot = "9")]
	public void OKPPPAGPECC(NCOEFPHLCKK IILFNNEDNCJ)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000056")]
internal sealed class ABEGKLMCNKN : KGDABPANOEG
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000B0")]
	private readonly PLOEBEDJGLE IILFNNEDNCJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000B1")]
	private readonly BHECNCBBLMC GMNCOFMDGAF;

	[Cpp2IlInjected.Token(Token = "0x1700014E")]
	public bool FAJNDFDCOGA
	{
		[Cpp2IlInjected.Token(Token = "0x600051D")]
		[Cpp2IlInjected.Address(RVA = "0x57A8FB0", Offset = "0x57A83B0", VA = "0x1857A8FB0", Slot = "6")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700014F")]
	public IEnumerable<object> OPBNFDMBOBA
	{
		[Cpp2IlInjected.Token(Token = "0x600051E")]
		[Cpp2IlInjected.Address(RVA = "0x57A8D60", Offset = "0x57A8160", VA = "0x1857A8D60", Slot = "7")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400004C")]
	public event DGAAFHCPHEH KOKLFFIBABB
	{
		[Cpp2IlInjected.Token(Token = "0x600051B")]
		[Cpp2IlInjected.Address(RVA = "0x57A8D90", Offset = "0x57A8190", VA = "0x1857A8D90", Slot = "4")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600051C")]
		[Cpp2IlInjected.Address(RVA = "0x57A8F10", Offset = "0x57A8310", VA = "0x1857A8F10", Slot = "5")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600051F")]
	[Cpp2IlInjected.Address(RVA = "0x57A91A0", Offset = "0x57A85A0", VA = "0x1857A91A0")]
	public ABEGKLMCNKN(NCOEFPHLCKK IILFNNEDNCJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000520")]
	[Cpp2IlInjected.Address(RVA = "0x57A8D00", Offset = "0x57A8100", VA = "0x1857A8D00", Slot = "11")]
	public IDisposable EBMGEFKJGJE()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000521")]
	[Cpp2IlInjected.Address(RVA = "0x57A8E30", Offset = "0x57A8230", VA = "0x1857A8E30", Slot = "8")]
	public void LDMPNKDCNKH(object MIFCLBEAOPM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000522")]
	[Cpp2IlInjected.Address(RVA = "0x57A8D80", Offset = "0x57A8180", VA = "0x1857A8D80", Slot = "9")]
	public void FGAHJAEMBHA(object MIFCLBEAOPM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000523")]
	[Cpp2IlInjected.Address(RVA = "0x57A90A0", Offset = "0x57A84A0", VA = "0x1857A90A0", Slot = "10")]
	public void PNGKMLMJNAK(object MIFCLBEAOPM, bool KLMBPMINIHN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000524")]
	[Cpp2IlInjected.Address(RVA = "0x57A8C80", Offset = "0x57A8080", VA = "0x1857A8C80", Slot = "12")]
	public void BOFMJFDPNBF(Rigidbody HKPNCKPHHLB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000525")]
	[Cpp2IlInjected.Address(RVA = "0x57A9070", Offset = "0x57A8470", VA = "0x1857A9070", Slot = "13")]
	public void PKFCGBCFJGD(Rigidbody GHAGIOLHPMN)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000057")]
internal sealed class HNCLLPKFEBH : KJOHJJNNODA, INNKCACPKLA, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000B3")]
	private readonly PLOEBEDJGLE IILFNNEDNCJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000B4")]
	private PhotonView NIHEFIPHFDI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40000B5")]
	private bool MDPAFOENDPA;

	[Cpp2IlInjected.Token(Token = "0x17000150")]
	public PhotonView PPFKDGBOMAG
	{
		[Cpp2IlInjected.Token(Token = "0x6000528")]
		[Cpp2IlInjected.Address(RVA = "0x72F250", Offset = "0x72E650", VA = "0x18072F250", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000151")]
	public bool BBHAHOHMEPG
	{
		[Cpp2IlInjected.Token(Token = "0x6000529")]
		[Cpp2IlInjected.Address(RVA = "0x57B4D80", Offset = "0x57B4180", VA = "0x1857B4D80", Slot = "7")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000152")]
	public bool MPDIPBBGKKB
	{
		[Cpp2IlInjected.Token(Token = "0x600052A")]
		[Cpp2IlInjected.Address(RVA = "0x754680", Offset = "0x753A80", VA = "0x180754680", Slot = "8")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400004D")]
	public event DGAAFHCPHEH DELNFHCFIKO
	{
		[Cpp2IlInjected.Token(Token = "0x6000526")]
		[Cpp2IlInjected.Address(RVA = "0x57B62B0", Offset = "0x57B56B0", VA = "0x1857B62B0", Slot = "5")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000527")]
		[Cpp2IlInjected.Address(RVA = "0x57B5C60", Offset = "0x57B5060", VA = "0x1857B5C60", Slot = "6")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600052B")]
	[Cpp2IlInjected.Address(RVA = "0x57B6890", Offset = "0x57B5C90", VA = "0x1857B6890")]
	public HNCLLPKFEBH(NCOEFPHLCKK IILFNNEDNCJ, in JCAJMGPJNDN HIDEHJGLNHO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600052C")]
	[Cpp2IlInjected.Address(RVA = "0x57B64C0", Offset = "0x57B58C0", VA = "0x1857B64C0", Slot = "9")]
	public void PBJONABJOBO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600052D")]
	[Cpp2IlInjected.Address(RVA = "0x57B5D00", Offset = "0x57B5100", VA = "0x1857B5D00", Slot = "12")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600052E")]
	[Cpp2IlInjected.Address(RVA = "0x57B6120", Offset = "0x57B5520", VA = "0x1857B6120", Slot = "10")]
	public void FPAGIJPELCJ(NCOEFPHLCKK GGEKFPEBLKN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600052F")]
	[Cpp2IlInjected.Address(RVA = "0x57B5E10", Offset = "0x57B5210", VA = "0x1857B5E10", Slot = "11")]
	public void EDIJKBDKKBN(NCOEFPHLCKK GGEKFPEBLKN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000530")]
	[Cpp2IlInjected.Address(RVA = "0x57B5FA0", Offset = "0x57B53A0", VA = "0x1857B5FA0")]
	private void FHAIJPNFBDJ(PhotonView CCKCOJFPKNL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000531")]
	[Cpp2IlInjected.Address(RVA = "0x57B6350", Offset = "0x57B5750", VA = "0x1857B6350")]
	private void NMOCGHMFIDJ(RigidbodyEx HLCKNLLPKKO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000532")]
	[Cpp2IlInjected.Address(RVA = "0x57B6610", Offset = "0x57B5A10", VA = "0x1857B6610")]
	private void PDFJNKCICEB(PhotonView FGIJLKAFKLI)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000058")]
internal static class IGNOBFOLHOG
{
	[Cpp2IlInjected.Token(Token = "0x6000533")]
	[Cpp2IlInjected.Address(RVA = "0x57B8DF0", Offset = "0x57B81F0", VA = "0x1857B8DF0")]
	public static KJOHJJNNODA PFFJAHDNLIN(this NCOEFPHLCKK NLKDOMNEDBE)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000059")]
internal sealed class PHBJFGPFKIB : IKFALNBDADN
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000B6")]
	private readonly PLOEBEDJGLE IILFNNEDNCJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000B7")]
	private RigidbodyConstraints JBGLIGODAKH;

	[Cpp2IlInjected.Token(Token = "0x17000153")]
	public bool KHDKIPLIJCN
	{
		[Cpp2IlInjected.Token(Token = "0x6000534")]
		[Cpp2IlInjected.Address(RVA = "0x9A66D0", Offset = "0x9A5AD0", VA = "0x1809A66D0", Slot = "4")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000535")]
		[Cpp2IlInjected.Address(RVA = "0x21F9450", Offset = "0x21F8850", VA = "0x1821F9450", Slot = "5")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000154")]
	public bool ILHHOPCAOME
	{
		[Cpp2IlInjected.Token(Token = "0x6000536")]
		[Cpp2IlInjected.Address(RVA = "0x21F9460", Offset = "0x21F8860", VA = "0x1821F9460", Slot = "6")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000537")]
		[Cpp2IlInjected.Address(RVA = "0x21F9440", Offset = "0x21F8840", VA = "0x1821F9440")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000155")]
	public RigidbodyConstraints AOEOJAJAPKL
	{
		[Cpp2IlInjected.Token(Token = "0x6000538")]
		[Cpp2IlInjected.Address(RVA = "0x788950", Offset = "0x787D50", VA = "0x180788950", Slot = "7")]
		get
		{
			return default(RigidbodyConstraints);
		}
		[Cpp2IlInjected.Token(Token = "0x6000539")]
		[Cpp2IlInjected.Address(RVA = "0x57CB200", Offset = "0x57CA600", VA = "0x1857CB200", Slot = "8")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600053A")]
	[Cpp2IlInjected.Address(RVA = "0x57CB340", Offset = "0x57CA740", VA = "0x1857CB340")]
	public PHBJFGPFKIB(NCOEFPHLCKK IILFNNEDNCJ, in JCAJMGPJNDN HIDEHJGLNHO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600053B")]
	[Cpp2IlInjected.Address(RVA = "0x57CB1A0", Offset = "0x57CA5A0", VA = "0x1857CB1A0", Slot = "9")]
	public void BOFMJFDPNBF(Rigidbody GHAGIOLHPMN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600053C")]
	[Cpp2IlInjected.Address(RVA = "0x57CB1D0", Offset = "0x57CA5D0", VA = "0x1857CB1D0", Slot = "10")]
	public void PKFCGBCFJGD(Rigidbody GHAGIOLHPMN)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200005A")]
internal sealed class MLLAIDEGMGG : CAONNBLCKEG
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000BA")]
	private readonly NCOEFPHLCKK IILFNNEDNCJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000BB")]
	private float NKICPJKJIPG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
	[Cpp2IlInjected.Token(Token = "0x40000BC")]
	private float KJIENHELDBA;

	[Cpp2IlInjected.Token(Token = "0x17000156")]
	public float PGABAKFPNBB
	{
		[Cpp2IlInjected.Token(Token = "0x600053E")]
		[Cpp2IlInjected.Address(RVA = "0xCDDBB0", Offset = "0xCDCFB0", VA = "0x180CDDBB0", Slot = "4")]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x600053F")]
		[Cpp2IlInjected.Address(RVA = "0x57C4840", Offset = "0x57C3C40", VA = "0x1857C4840", Slot = "5")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000157")]
	public float DCNFDLOMNCM
	{
		[Cpp2IlInjected.Token(Token = "0x6000540")]
		[Cpp2IlInjected.Address(RVA = "0xDD7780", Offset = "0xDD6B80", VA = "0x180DD7780", Slot = "6")]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x6000541")]
		[Cpp2IlInjected.Address(RVA = "0x57C4910", Offset = "0x57C3D10", VA = "0x1857C4910", Slot = "7")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600053D")]
	[Cpp2IlInjected.Address(RVA = "0x57C4A80", Offset = "0x57C3E80", VA = "0x1857C4A80")]
	public MLLAIDEGMGG(NCOEFPHLCKK IILFNNEDNCJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000542")]
	[Cpp2IlInjected.Address(RVA = "0x57C47F0", Offset = "0x57C3BF0", VA = "0x1857C47F0", Slot = "8")]
	public void BOFMJFDPNBF(Rigidbody GHAGIOLHPMN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000543")]
	[Cpp2IlInjected.Address(RVA = "0x57C49E0", Offset = "0x57C3DE0", VA = "0x1857C49E0", Slot = "9")]
	public void PKFCGBCFJGD(Rigidbody GHAGIOLHPMN)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200005B")]
internal sealed class ALGNGADHBMC : EIMJIHNCMHI
{
	[Cpp2IlInjected.Token(Token = "0x40000BD")]
	private const int BODIPJBOABD = 10;

	[Cpp2IlInjected.Token(Token = "0x40000BE")]
	private const float LEOMFFLEOJP = 9E-05f;

	[Cpp2IlInjected.Token(Token = "0x40000BF")]
	private const float GJBNLKILOFJ = 0.0001f;

	[Cpp2IlInjected.Token(Token = "0x40000C0")]
	private const float MDELHFJODGE = 5f;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000C2")]
	private readonly PLOEBEDJGLE IILFNNEDNCJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000C3")]
	private bool BGFIBJGJHFP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x21")]
	[Cpp2IlInjected.Token(Token = "0x40000C4")]
	private bool CKBFPADPCAD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
	[Cpp2IlInjected.Token(Token = "0x40000C5")]
	private int IICOFCPBOJK;

	[Cpp2IlInjected.Token(Token = "0x17000158")]
	private Rigidbody LNMDHFKNJIH
	{
		[Cpp2IlInjected.Token(Token = "0x6000546")]
		[Cpp2IlInjected.Address(RVA = "0x57AA030", Offset = "0x57A9430", VA = "0x1857AA030")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000159")]
	private bool HBCBGANJMHF
	{
		[Cpp2IlInjected.Token(Token = "0x6000547")]
		[Cpp2IlInjected.Address(RVA = "0x57AA210", Offset = "0x57A9610", VA = "0x1857AA210")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700015A")]
	private bool LFGDELENJCM
	{
		[Cpp2IlInjected.Token(Token = "0x6000548")]
		[Cpp2IlInjected.Address(RVA = "0x57AA5E0", Offset = "0x57A99E0", VA = "0x1857AA5E0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700015B")]
	private NCOEFPHLCKK GKEMABFNEME
	{
		[Cpp2IlInjected.Token(Token = "0x6000549")]
		[Cpp2IlInjected.Address(RVA = "0x57AA7B0", Offset = "0x57A9BB0", VA = "0x1857AA7B0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700015C")]
	private bool KMDIPAOGGGF
	{
		[Cpp2IlInjected.Token(Token = "0x600054A")]
		[Cpp2IlInjected.Address(RVA = "0x57AA600", Offset = "0x57A9A00", VA = "0x1857AA600")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400004E")]
	public event DGAAFHCPHEH BGFDOMIHHPL
	{
		[Cpp2IlInjected.Token(Token = "0x6000544")]
		[Cpp2IlInjected.Address(RVA = "0x57AA820", Offset = "0x57A9C20", VA = "0x1857AA820", Slot = "4")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000545")]
		[Cpp2IlInjected.Address(RVA = "0x57A9F90", Offset = "0x57A9390", VA = "0x1857A9F90", Slot = "5")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600054B")]
	[Cpp2IlInjected.Address(RVA = "0x57AAAD0", Offset = "0x57A9ED0", VA = "0x1857AAAD0")]
	public ALGNGADHBMC(NCOEFPHLCKK IILFNNEDNCJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600054C")]
	[Cpp2IlInjected.Address(RVA = "0x57AA8C0", Offset = "0x57A9CC0", VA = "0x1857AA8C0", Slot = "6")]
	public void PBJONABJOBO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600054D")]
	[Cpp2IlInjected.Address(RVA = "0x57AA810", Offset = "0x57A9C10", VA = "0x1857AA810", Slot = "8")]
	public void NKFCECIGMAG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600054E")]
	[Cpp2IlInjected.Address(RVA = "0x57AA660", Offset = "0x57A9A60", VA = "0x1857AA660", Slot = "7")]
	public bool NEPEFPHIELC()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600054F")]
	[Cpp2IlInjected.Address(RVA = "0x57AAA30", Offset = "0x57A9E30", VA = "0x1857AAA30", Slot = "9")]
	public void PKFLOCAHJCK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000550")]
	[Cpp2IlInjected.Address(RVA = "0x57AA950", Offset = "0x57A9D50", VA = "0x1857AA950", Slot = "11")]
	public void PFPLFILECPI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000551")]
	[Cpp2IlInjected.Address(RVA = "0x57AA9F0", Offset = "0x57A9DF0", VA = "0x1857AA9F0", Slot = "12")]
	public void PHLPAOAPADB(bool DFLJHGHEKJD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000552")]
	[Cpp2IlInjected.Address(RVA = "0x57AA2B0", Offset = "0x57A96B0", VA = "0x1857AA2B0", Slot = "10")]
	public void LMCNKOCFNJH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000553")]
	[Cpp2IlInjected.Address(RVA = "0x57A9DE0", Offset = "0x57A91E0", VA = "0x1857A9DE0")]
	private bool BEIPPJFGNKI()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000554")]
	[Cpp2IlInjected.Address(RVA = "0x57AA080", Offset = "0x57A9480", VA = "0x1857AA080")]
	private void GKLPFICFPDE()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200005C")]
internal sealed class KBBDHDIMKDH : IPANMLAMAAD
{
	[Cpp2IlInjected.Token(Token = "0x40000C6")]
	private const string EKLCKOGJHLL = "RBEX_ANIM";

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000C7")]
	private readonly PLOEBEDJGLE IILFNNEDNCJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000C8")]
	private readonly BHECNCBBLMC KGFFEMLFKLI;

	[Cpp2IlInjected.Token(Token = "0x1700015D")]
	public Rigidbody LNMDHFKNJIH
	{
		[Cpp2IlInjected.Token(Token = "0x6000555")]
		[Cpp2IlInjected.Address(RVA = "0x72F250", Offset = "0x72E650", VA = "0x18072F250", Slot = "4")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000556")]
		[Cpp2IlInjected.Address(RVA = "0x7A04D0", Offset = "0x79F8D0", VA = "0x1807A04D0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700015E")]
	private bool KMDIPAOGGGF
	{
		[Cpp2IlInjected.Token(Token = "0x6000557")]
		[Cpp2IlInjected.Address(RVA = "0x57ABD50", Offset = "0x57AB150", VA = "0x1857ABD50")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000558")]
	[Cpp2IlInjected.Address(RVA = "0x57C01B0", Offset = "0x57BF5B0", VA = "0x1857C01B0")]
	public KBBDHDIMKDH(NCOEFPHLCKK IILFNNEDNCJ, in JCAJMGPJNDN HIDEHJGLNHO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000559")]
	[Cpp2IlInjected.Address(RVA = "0x57C0100", Offset = "0x57BF500", VA = "0x1857C0100", Slot = "5")]
	public void PBJONABJOBO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600055A")]
	[Cpp2IlInjected.Address(RVA = "0x57C00D0", Offset = "0x57BF4D0", VA = "0x1857C00D0", Slot = "6")]
	public void KPOLANLNJJI(object MIFCLBEAOPM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600055B")]
	[Cpp2IlInjected.Address(RVA = "0x57BFA50", Offset = "0x57BEE50", VA = "0x1857BFA50", Slot = "7")]
	public void HIBCGDMOODJ(object MIFCLBEAOPM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600055C")]
	[Cpp2IlInjected.Address(RVA = "0x57BF1C0", Offset = "0x57BE5C0", VA = "0x1857BF1C0", Slot = "8")]
	public void EDEILOABNOJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600055D")]
	[Cpp2IlInjected.Address(RVA = "0x57BF6D0", Offset = "0x57BEAD0", VA = "0x1857BF6D0", Slot = "9")]
	public void EONBBMLLGPB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600055E")]
	[Cpp2IlInjected.Address(RVA = "0x57BF8D0", Offset = "0x57BECD0", VA = "0x1857BF8D0", Slot = "10")]
	public void FDIDMCANFME()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600055F")]
	[Cpp2IlInjected.Address(RVA = "0x57BFA80", Offset = "0x57BEE80", VA = "0x1857BFA80", Slot = "11")]
	public void IKMAJMOKAJI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000560")]
	[Cpp2IlInjected.Address(RVA = "0x57BF520", Offset = "0x57BE920", VA = "0x1857BF520")]
	private void EOLCGNDNPBO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000561")]
	[Cpp2IlInjected.Address(RVA = "0x57BFF20", Offset = "0x57BF320", VA = "0x1857BFF20")]
	private void KAMMGDNLJDL()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200005D")]
internal sealed class NHKHPDIEFMI : ODMDEDICELM, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000CA")]
	private readonly PLOEBEDJGLE IILFNNEDNCJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000CB")]
	private readonly BHECNCBBLMC JLNIAAJPPJI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000CC")]
	private float GHBILKANCFB;

	[Cpp2IlInjected.Token(Token = "0x1700015F")]
	public EKLLOLLHLDP LNMCPLFHCHG
	{
		[Cpp2IlInjected.Token(Token = "0x6000562")]
		[Cpp2IlInjected.Address(RVA = "0x72F270", Offset = "0x72E670", VA = "0x18072F270", Slot = "4")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000563")]
		[Cpp2IlInjected.Address(RVA = "0x7B1920", Offset = "0x7B0D20", VA = "0x1807B1920", Slot = "5")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000160")]
	public CHACNCJIDJM GJHPEGFOAME
	{
		[Cpp2IlInjected.Token(Token = "0x6000564")]
		[Cpp2IlInjected.Address(RVA = "0x72B000", Offset = "0x72A400", VA = "0x18072B000", Slot = "6")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000565")]
		[Cpp2IlInjected.Address(RVA = "0x7B1930", Offset = "0x7B0D30", VA = "0x1807B1930", Slot = "7")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000161")]
	public Vector3 LGEGEJPPDAD
	{
		[Cpp2IlInjected.Token(Token = "0x6000566")]
		[Cpp2IlInjected.Address(RVA = "0x57C82C0", Offset = "0x57C76C0", VA = "0x1857C82C0", Slot = "8")]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x6000567")]
		[Cpp2IlInjected.Address(RVA = "0x57C8920", Offset = "0x57C7D20", VA = "0x1857C8920", Slot = "9")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000162")]
	public Vector3 JBHIDAJMGMM
	{
		[Cpp2IlInjected.Token(Token = "0x6000568")]
		[Cpp2IlInjected.Address(RVA = "0x57C9D00", Offset = "0x57C9100", VA = "0x1857C9D00", Slot = "10")]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x6000569")]
		[Cpp2IlInjected.Address(RVA = "0x57C8F50", Offset = "0x57C8350", VA = "0x1857C8F50", Slot = "11")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000163")]
	public Vector3 LJMFIEJCGLD
	{
		[Cpp2IlInjected.Token(Token = "0x600056A")]
		[Cpp2IlInjected.Address(RVA = "0x57C87F0", Offset = "0x57C7BF0", VA = "0x1857C87F0", Slot = "12")]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x600056B")]
		[Cpp2IlInjected.Address(RVA = "0x57C84D0", Offset = "0x57C78D0", VA = "0x1857C84D0", Slot = "13")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000164")]
	public Vector3 ICEKJCBHJBH
	{
		[Cpp2IlInjected.Token(Token = "0x600056C")]
		[Cpp2IlInjected.Address(RVA = "0x57C9ED0", Offset = "0x57C92D0", VA = "0x1857C9ED0", Slot = "14")]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x600056D")]
		[Cpp2IlInjected.Address(RVA = "0x57C9E30", Offset = "0x57C9230", VA = "0x1857C9E30", Slot = "15")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000165")]
	public float KKALKPOINCB
	{
		[Cpp2IlInjected.Token(Token = "0x600056E")]
		[Cpp2IlInjected.Address(RVA = "0xDF9570", Offset = "0xDF8970", VA = "0x180DF9570", Slot = "16")]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x600056F")]
		[Cpp2IlInjected.Address(RVA = "0x57C8C40", Offset = "0x57C8040", VA = "0x1857C8C40", Slot = "17")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000166")]
	public bool LIGEJEKODFL
	{
		[Cpp2IlInjected.Token(Token = "0x6000570")]
		[Cpp2IlInjected.Address(RVA = "0xDC7160", Offset = "0xDC6560", VA = "0x180DC7160", Slot = "18")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000167")]
	private BDJOPHNNEJG AODMDOCLCLA
	{
		[Cpp2IlInjected.Token(Token = "0x6000585")]
		[Cpp2IlInjected.Address(RVA = "0x1C55DF0", Offset = "0x1C551F0", VA = "0x181C55DF0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000168")]
	private bool LFGDELENJCM
	{
		[Cpp2IlInjected.Token(Token = "0x6000586")]
		[Cpp2IlInjected.Address(RVA = "0x57AF160", Offset = "0x57AE560", VA = "0x1857AF160")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000571")]
	[Cpp2IlInjected.Address(RVA = "0x57CAE90", Offset = "0x57CA290", VA = "0x1857CAE90")]
	public NHKHPDIEFMI(NCOEFPHLCKK IILFNNEDNCJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000572")]
	[Cpp2IlInjected.Address(RVA = "0x57C9E60", Offset = "0x57C9260", VA = "0x1857C9E60", Slot = "19")]
	public void PBJONABJOBO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000573")]
	[Cpp2IlInjected.Address(RVA = "0x57C8BE0", Offset = "0x57C7FE0", VA = "0x1857C8BE0", Slot = "37")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000574")]
	[Cpp2IlInjected.Address(RVA = "0x57C86C0", Offset = "0x57C7AC0", VA = "0x1857C86C0", Slot = "28")]
	public void BOFMJFDPNBF(Rigidbody GHAGIOLHPMN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000575")]
	[Cpp2IlInjected.Address(RVA = "0xDC6BF0", Offset = "0xDC5FF0", VA = "0x180DC6BF0", Slot = "20")]
	public void KNFJENEFGIE(object MIFCLBEAOPM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000576")]
	[Cpp2IlInjected.Address(RVA = "0xDC65F0", Offset = "0xDC59F0", VA = "0x180DC65F0", Slot = "31")]
	public void NEMGEGCJOPN(object MIFCLBEAOPM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000577")]
	[Cpp2IlInjected.Address(RVA = "0x57C80E0", Offset = "0x57C74E0", VA = "0x1857C80E0", Slot = "36")]
	public Vector3 AFFCJBHNNJL(Vector3 JOJEMOKKGPP)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000578")]
	[Cpp2IlInjected.Address(RVA = "0x57CA160", Offset = "0x57C9560", VA = "0x1857CA160", Slot = "35")]
	public Vector3 KIKKEDPKAKK(Vector3 HMPFDEAFPND)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000579")]
	[Cpp2IlInjected.Address(RVA = "0x57C9E60", Offset = "0x57C9260", VA = "0x1857C9E60", Slot = "27")]
	public void INLPOAEPJGG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600057A")]
	[Cpp2IlInjected.Address(RVA = "0x57C8680", Offset = "0x57C7A80", VA = "0x1857C8680", Slot = "25")]
	public void BHDNAPGFIPJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600057B")]
	[Cpp2IlInjected.Address(RVA = "0x57C9DF0", Offset = "0x57C91F0", VA = "0x1857C9DF0", Slot = "24")]
	public void IFMLGPGPJDO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600057C")]
	[Cpp2IlInjected.Address(RVA = "0x57CA320", Offset = "0x57C9720", VA = "0x1857CA320", Slot = "34")]
	public void NGFKLMPAGOE(Vector3 GKKEEHNMPBL, Vector3 NFGPCLPNMJK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600057D")]
	[Cpp2IlInjected.Address(RVA = "0x57C9FC0", Offset = "0x57C93C0", VA = "0x1857C9FC0", Slot = "33")]
	public void JLDEEBLCKGA(Vector3 FHKLDEIKECB, Vector3 FHFHNDANMPN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600057E")]
	[Cpp2IlInjected.Address(RVA = "0x57CA020", Offset = "0x57C9420", VA = "0x1857CA020", Slot = "32")]
	public void KIIDBBLBANB(Vector3 JDDALKKDLNA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600057F")]
	[Cpp2IlInjected.Address(RVA = "0x57C9070", Offset = "0x57C8470", VA = "0x1857C9070", Slot = "22")]
	public void HHAFJJGJPFB(EECECFKKEJP KMDODPJBKLE, Vector3 CFLMAEMNHKL, float ABGPHLFIFAO, float OPCFMELHIKJ = 8f, float ECOHALOPPDN = 1f)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000580")]
	[Cpp2IlInjected.Address(RVA = "0x57C94C0", Offset = "0x57C88C0", VA = "0x1857C94C0", Slot = "21")]
	public void HHLJBCNAEPM(JDHBHPOMECG EFAKAOJPAJJ, Vector3 PKAJMBKNJIL, float KBLOKDLNEPD = float.PositiveInfinity)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000581")]
	[Cpp2IlInjected.Address(RVA = "0x57C9A30", Offset = "0x57C8E30", VA = "0x1857C9A30", Slot = "23")]
	[Obsolete]
	public void IALNLOAFGMK(JDHBHPOMECG EFAKAOJPAJJ, Vector3 IHCJBCJFELL, float MEJPNNANPLH = 7f, float CKIIILKMBKK = 1f)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000582")]
	[Cpp2IlInjected.Address(RVA = "0x57C8B20", Offset = "0x57C7F20", VA = "0x1857C8B20", Slot = "30")]
	public Vector3 DNICIBAAMCG(Vector3 GCAABCBBBAL)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000583")]
	[Cpp2IlInjected.Address(RVA = "0x57C8F80", Offset = "0x57C8380", VA = "0x1857C8F80", Slot = "29")]
	public Vector3 GJAHBCCOAII(Vector3 DIIFLOBFBLO)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000584")]
	[Cpp2IlInjected.Address(RVA = "0x57C8E20", Offset = "0x57C8220", VA = "0x1857C8E20", Slot = "26")]
	public void EPOKPKAANHO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000587")]
	[Cpp2IlInjected.Address(RVA = "0x57C8C40", Offset = "0x57C8040", VA = "0x1857C8C40")]
	private void PPEMJOPAMJI(float LPJDDLMPNCG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000588")]
	[Cpp2IlInjected.Address(RVA = "0x57C89E0", Offset = "0x57C7DE0", VA = "0x1857C89E0")]
	private void DKLBMGLGABJ(Vector3 PKAJMBKNJIL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000589")]
	[Cpp2IlInjected.Address(RVA = "0x57C83E0", Offset = "0x57C77E0", VA = "0x1857C83E0")]
	private Vector3 AIPGGJCOIBK()
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x600058A")]
	[Cpp2IlInjected.Address(RVA = "0x57CA560", Offset = "0x57C9960", VA = "0x1857CA560")]
	private void OIMGBAHMGOG(Vector3 HMPFDEAFPND)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600058B")]
	[Cpp2IlInjected.Address(RVA = "0x57C8590", Offset = "0x57C7990", VA = "0x1857C8590")]
	private Vector3 BGJJOBCDBBC()
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x600058C")]
	[Cpp2IlInjected.Address(RVA = "0x57C96F0", Offset = "0x57C8AF0", VA = "0x1857C96F0")]
	private void HOGMIBAAANA(Vector3 LPJDDLMPNCG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600058D")]
	[Cpp2IlInjected.Address(RVA = "0x57CA890", Offset = "0x57C9C90", VA = "0x1857CA890")]
	private void OPKJDBGLKOE(Vector3 HMPFDEAFPND)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600058E")]
	[Cpp2IlInjected.Address(RVA = "0x57C8D60", Offset = "0x57C8160", VA = "0x1857C8D60")]
	private void EKIKIKBLFAP()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200005E")]
public class NHDJMCGDAEJ : CCKADDACLBD
{
	[Cpp2IlInjected.Token(Token = "0x600058F")]
	[Cpp2IlInjected.Address(RVA = "0x57C78A0", Offset = "0x57C6CA0", VA = "0x1857C78A0", Slot = "4")]
	public PLDJMDIFCKE HPIEMLILMFL(NCOEFPHLCKK NLKDOMNEDBE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000590")]
	[Cpp2IlInjected.Address(RVA = "0x57C7980", Offset = "0x57C6D80", VA = "0x1857C7980", Slot = "5")]
	public ODMDEDICELM IINCPPFHAME(NCOEFPHLCKK NLKDOMNEDBE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000591")]
	[Cpp2IlInjected.Address(RVA = "0x57C7FD0", Offset = "0x57C73D0", VA = "0x1857C7FD0", Slot = "6")]
	public IMBEMHENMNJ MOJGNMKJFLF(NCOEFPHLCKK NLKDOMNEDBE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000592")]
	[Cpp2IlInjected.Address(RVA = "0x57C7A90", Offset = "0x57C6E90", VA = "0x1857C7A90", Slot = "7")]
	public CAONNBLCKEG ILCPDNKDAKJ(NCOEFPHLCKK NLKDOMNEDBE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000593")]
	[Cpp2IlInjected.Address(RVA = "0x57C7D40", Offset = "0x57C7140", VA = "0x1857C7D40", Slot = "8")]
	public EIMJIHNCMHI KJNNEGNLPCG(NCOEFPHLCKK NLKDOMNEDBE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000594")]
	[Cpp2IlInjected.Address(RVA = "0x57C7BD0", Offset = "0x57C6FD0", VA = "0x1857C7BD0", Slot = "9")]
	public JBCOLILENLD JDEHAKBEPFB(NCOEFPHLCKK NLKDOMNEDBE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000595")]
	[Cpp2IlInjected.Address(RVA = "0x57C7500", Offset = "0x57C6900", VA = "0x1857C7500", Slot = "10")]
	public KGDABPANOEG CLMAKHLOHMN(NCOEFPHLCKK NLKDOMNEDBE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000596")]
	[Cpp2IlInjected.Address(RVA = "0x57C7E00", Offset = "0x57C7200", VA = "0x1857C7E00", Slot = "11")]
	public BDJOPHNNEJG LAGKMHIIGOF(NCOEFPHLCKK NLKDOMNEDBE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000597")]
	[Cpp2IlInjected.Address(RVA = "0x57C7C90", Offset = "0x57C7090", VA = "0x1857C7C90", Slot = "12")]
	public AIOOGANOGPH JNMPFOJECMI(NCOEFPHLCKK NLKDOMNEDBE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000598")]
	[Cpp2IlInjected.Address(RVA = "0x57C7720", Offset = "0x57C6B20", VA = "0x1857C7720", Slot = "13")]
	public BBGAPPNBFLO DPGNNNONAOD(NCOEFPHLCKK NLKDOMNEDBE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000599")]
	[Cpp2IlInjected.Address(RVA = "0x57C7600", Offset = "0x57C6A00", VA = "0x1857C7600")]
	public IPANMLAMAAD MNBKDOEPCLE(NCOEFPHLCKK NLKDOMNEDBE, in JCAJMGPJNDN HIDEHJGLNHO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600059A")]
	[Cpp2IlInjected.Address(RVA = "0x57C77D0", Offset = "0x57C6BD0", VA = "0x1857C77D0")]
	public INNKCACPKLA HPGHLDDNEHH(NCOEFPHLCKK NLKDOMNEDBE, in JCAJMGPJNDN HIDEHJGLNHO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600059B")]
	[Cpp2IlInjected.Address(RVA = "0x57C7EB0", Offset = "0x57C72B0", VA = "0x1857C7EB0")]
	public LBPABMNHAKF OCGJAPKHCOA(NCOEFPHLCKK NLKDOMNEDBE, in JCAJMGPJNDN HIDEHJGLNHO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600059C")]
	[Cpp2IlInjected.Address(RVA = "0x57C7350", Offset = "0x57C6750", VA = "0x1857C7350")]
	public OGBLFJOOHEI BMJLAHFILLO(NCOEFPHLCKK NLKDOMNEDBE, in JCAJMGPJNDN HIDEHJGLNHO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600059D")]
	[Cpp2IlInjected.Address(RVA = "0x57C7B00", Offset = "0x57C6F00", VA = "0x1857C7B00")]
	public IKFALNBDADN KIKLIMOCIDB(NCOEFPHLCKK NLKDOMNEDBE, in JCAJMGPJNDN HIDEHJGLNHO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600059E")]
	[Cpp2IlInjected.Address(RVA = "0x57C7450", Offset = "0x57C6850", VA = "0x1857C7450", Slot = "19")]
	public NCOEFPHLCKK APMJEHJBGBJ(RigidbodyEx IILFNNEDNCJ, JCAJMGPJNDN HIDEHJGLNHO, BKDMDHLJAEJ CMIHNHHBGOO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600059F")]
	[Cpp2IlInjected.Address(RVA = "0x72E810", Offset = "0x72DC10", VA = "0x18072E810")]
	public NHDJMCGDAEJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60005A0")]
	[Cpp2IlInjected.Address(RVA = "0x57C7600", Offset = "0x57C6A00", VA = "0x1857C7600", Slot = "14")]
	private IPANMLAMAAD DBBGHPHPGNC(NCOEFPHLCKK NLKDOMNEDBE, in JCAJMGPJNDN HIDEHJGLNHO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60005A1")]
	[Cpp2IlInjected.Address(RVA = "0x57C77D0", Offset = "0x57C6BD0", VA = "0x1857C77D0", Slot = "15")]
	private INNKCACPKLA IACLMNOIKMC(NCOEFPHLCKK NLKDOMNEDBE, in JCAJMGPJNDN HIDEHJGLNHO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60005A2")]
	[Cpp2IlInjected.Address(RVA = "0x57C7EB0", Offset = "0x57C72B0", VA = "0x1857C7EB0", Slot = "16")]
	private LBPABMNHAKF MFFOKDJHDOK(NCOEFPHLCKK NLKDOMNEDBE, in JCAJMGPJNDN HIDEHJGLNHO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60005A3")]
	[Cpp2IlInjected.Address(RVA = "0x57C7350", Offset = "0x57C6750", VA = "0x1857C7350", Slot = "17")]
	private OGBLFJOOHEI AFFGIKNDDLN(NCOEFPHLCKK NLKDOMNEDBE, in JCAJMGPJNDN HIDEHJGLNHO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60005A4")]
	[Cpp2IlInjected.Address(RVA = "0x57C7B00", Offset = "0x57C6F00", VA = "0x1857C7B00", Slot = "18")]
	private IKFALNBDADN ILNOMKKJMMB(NCOEFPHLCKK NLKDOMNEDBE, in JCAJMGPJNDN HIDEHJGLNHO)
	{
		return null;
	}
}
namespace RRAssemblyIndex.RecRoom.Rbex.Runtime
{
	[Cpp2IlInjected.Token(Token = "0x200005F")]
	[Preserve]
	internal class _RRAssemblyIndex : AAHOHGIJHFI
	{
		[Cpp2IlInjected.Token(Token = "0x60005A5")]
		[Cpp2IlInjected.Address(RVA = "0x734AD0", Offset = "0x733ED0", VA = "0x180734AD0")]
		[Preserve]
		public _RRAssemblyIndex()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005A6")]
		[Cpp2IlInjected.Address(RVA = "0x69A9C70", Offset = "0x69A9070", VA = "0x1869A9C70", Slot = "6")]
		public sealed override void MNNDBLCHNEL(CKMMIMLGKKB MIKGEIBIMCG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005A7")]
		[Cpp2IlInjected.Address(RVA = "0x69A9BE0", Offset = "0x69A8FE0", VA = "0x1869A9BE0", Slot = "4")]
		public sealed override void KLMOEJEAKPE()
		{
		}
	}
}
[StructLayout((LayoutKind)3, CharSet = CharSet.Auto)]
[Cpp2IlInjected.Token(Token = "0x2000060")]
public class KKMDFNBFHNC
{
	[Cpp2IlInjected.Token(Token = "0x40000CF")]
	private static byte[] BKNPCMHFKCN;

	[Cpp2IlInjected.Token(Token = "0x40000D0")]
	private static int KPMJKGHHDMP;

	[Cpp2IlInjected.Token(Token = "0x40000D1")]
	private static int JFAKBFOPBGJ;

	[Cpp2IlInjected.Token(Token = "0x40000D2")]
	private static BigInteger JMHPFPLGCJL;

	[Cpp2IlInjected.Token(Token = "0x60005A8")]
	[Cpp2IlInjected.Address(RVA = "0x72E810", Offset = "0x72DC10", VA = "0x18072E810")]
	public KKMDFNBFHNC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60005AA")]
	[Cpp2IlInjected.Address(RVA = "0x57C1A70", Offset = "0x57C0E70", VA = "0x1857C1A70")]
	private static string JOPJDHMEFPC(byte[] GFCGIJPPCBN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60005AB")]
	[Cpp2IlInjected.Address(RVA = "0x57C1720", Offset = "0x57C0B20", VA = "0x1857C1720")]
	public static string GLIIACIKPKK(byte[] EMIAMELGKNF, bool LLPOIDPCGKE)
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
		[Cpp2IlInjected.Address(RVA = "0x72E810", Offset = "0x72DC10", VA = "0x18072E810")]
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
