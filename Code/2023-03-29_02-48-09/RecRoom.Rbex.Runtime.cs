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
internal class KFICALMMODC
{
	[Cpp2IlInjected.Token(Token = "0x4000001")]
	public const string JHGPPKFAKAF = "RBEX_DEFAULT";

	[Cpp2IlInjected.Token(Token = "0x4000002")]
	public const float EGKCEFAALPH = 0.001f;

	[Cpp2IlInjected.Token(Token = "0x4000003")]
	public const float NJCJEMHDLNH = 0f;

	[Cpp2IlInjected.Token(Token = "0x4000004")]
	public const float LMKDDNGCIJK = 0.05f;

	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(RVA = "0x6ECCD0", Offset = "0x6EBAD0", VA = "0x1806ECCD0")]
	public KFICALMMODC()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
public delegate void IJDKLAGCEFG(RigidbodyEx GPOIDCEFKGO);
[Cpp2IlInjected.Token(Token = "0x2000004")]
public delegate void MHEGFHPPLGP(RigidbodyEx GPOIDCEFKGO, bool BNLMFCPNEHF = false);
[Cpp2IlInjected.Token(Token = "0x2000005")]
public enum GOIGKHJPKIL
{
	[Cpp2IlInjected.Token(Token = "0x4000006")]
	Additive,
	[Cpp2IlInjected.Token(Token = "0x4000007")]
	Override,
	[Cpp2IlInjected.Token(Token = "0x4000008")]
	Reflective
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public enum CAMOGAJBAFF
{
	[Cpp2IlInjected.Token(Token = "0x400000A")]
	OnlyForReducedPhysicsRateAndNotParenting,
	[Cpp2IlInjected.Token(Token = "0x400000B")]
	Never,
	[Cpp2IlInjected.Token(Token = "0x400000C")]
	OnEvenWhenParenting
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
public enum OEBNECHHPCF
{
	[Cpp2IlInjected.Token(Token = "0x400000E")]
	Additive,
	[Cpp2IlInjected.Token(Token = "0x400000F")]
	Override,
	[Cpp2IlInjected.Token(Token = "0x4000010")]
	Reflective
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
public class MOMCNLJJDGL : FOGLMEFJINH
{
	[Cpp2IlInjected.Token(Token = "0x17000001")]
	public int EECKKOJIPKE
	{
		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x6DA060", Offset = "0x6D8E60", VA = "0x1806DA060", Slot = "4")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	public int BJKKLPOKJNA
	{
		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x768420", Offset = "0x767220", VA = "0x180768420", Slot = "5")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0x70F8D0", Offset = "0x70E6D0", VA = "0x18070F8D0", Slot = "6")]
	public EHKPJAMPICF LOLMJDBDPBE(float HMDHBIIBBJG)
	{
		return default(EHKPJAMPICF);
	}

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0x6ED320", Offset = "0x6EC120", VA = "0x1806ED320", Slot = "7")]
	public void AHKNMMEAEHA(KJGOLDGANAL BLIKPCIFNNO, float LMNMELDDGEE, PFBDEHOAOJI ILONCAIAOBN = PFBDEHOAOJI.Off)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(RVA = "0x6ED320", Offset = "0x6EC120", VA = "0x1806ED320", Slot = "8")]
	public void AHKNMMEAEHA(KJGOLDGANAL BLIKPCIFNNO, Transform NANPHKJNMMM, float LMNMELDDGEE, PFBDEHOAOJI ILONCAIAOBN = PFBDEHOAOJI.Off)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(RVA = "0x6ED320", Offset = "0x6EC120", VA = "0x1806ED320", Slot = "9")]
	public void IDPNBDBOEHK(KJGOLDGANAL BLIKPCIFNNO, [Optional] float? LMNMELDDGEE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(RVA = "0x6ED320", Offset = "0x6EC120", VA = "0x1806ED320", Slot = "10")]
	public void IHKCCNMHHEB(KJGOLDGANAL CHLFBEGLOKO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(RVA = "0x70F8D0", Offset = "0x70E6D0", VA = "0x18070F8D0", Slot = "11")]
	public EHKPJAMPICF EMILEILHGAN(KJGOLDGANAL BLIKPCIFNNO)
	{
		return default(EHKPJAMPICF);
	}

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(RVA = "0x70F850", Offset = "0x70E650", VA = "0x18070F850", Slot = "12")]
	public bool KBAOKKDEAPL(KJGOLDGANAL BLIKPCIFNNO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(RVA = "0x6ED320", Offset = "0x6EC120", VA = "0x1806ED320", Slot = "13")]
	public void BOFDIKHLAJO(KJGOLDGANAL BLIKPCIFNNO, PFBDEHOAOJI GACJLIBPAEJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(RVA = "0x6ECCD0", Offset = "0x6EBAD0", VA = "0x1806ECCD0")]
	public MOMCNLJJDGL()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
[IHOFDNBJLIN(typeof(GACFLJPDFAI), new string[] { "Ignore", "Mock" })]
public class PHOPLKKOOON : GACFLJPDFAI
{
	[Cpp2IlInjected.Token(Token = "0x17000003")]
	public bool NAICACNFOOJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0x792380", Offset = "0x791180", VA = "0x180792380", Slot = "4")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(RVA = "0x6ED320", Offset = "0x6EC120", VA = "0x1806ED320", Slot = "5")]
	public void CMPCNGBMOAM(string EDMHEICKIIC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(RVA = "0x6ED320", Offset = "0x6EC120", VA = "0x1806ED320", Slot = "6")]
	public void OFKEDHBEAMM(RigidbodyEx FBJBBGAMODK, Action KKJDJCJOLIF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(RVA = "0x70F8D0", Offset = "0x70E6D0", VA = "0x18070F8D0", Slot = "7")]
	public FOGLMEFJINH DGDNJLPPONM(int PEGIOGJIPPE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(RVA = "0x6ED320", Offset = "0x6EC120", VA = "0x1806ED320", Slot = "8")]
	public void GBPLONJCMHJ(Vector3 AIFFLDMOIAE, float IOGBPIFKCNJ, Color HCHGJCCJIHO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(RVA = "0x6ECCD0", Offset = "0x6EBAD0", VA = "0x1806ECCD0")]
	public PHOPLKKOOON()
	{
	}
}
namespace RecRoom
{
	[Cpp2IlInjected.Token(Token = "0x200000A")]
	[DisallowMultipleComponent]
	[IDOCBBAEIFB(JHEANMHFGAO.Physics)]
	public sealed class RigidbodyEx : MonoBehaviour
	{
		[Cpp2IlInjected.Token(Token = "0x4000014")]
		private static readonly JFPIEAPAMJM MCHCOEKKPGN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000015")]
		private bool JDLNAGJIGCB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000016")]
		private DDICDNFJGFA PLFNKOGOLEK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000017")]
		[SerializeField]
		[JKJFAIFGIJJ(PCMMCGDMCAJ.Self, false, false, false)]
		private Rigidbody unityRigidbody;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000018")]
		[SerializeField]
		[JKJFAIFGIJJ(PCMMCGDMCAJ.SelfAndParent, true, false, false)]
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
		private CAMOGAJBAFF physicsInterpolation;

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
		internal DDICDNFJGFA AHBOCLNKFHO
		{
			[Cpp2IlInjected.Token(Token = "0x600001B")]
			[Cpp2IlInjected.Address(RVA = "0x65B47A0", Offset = "0x65B35A0", VA = "0x1865B47A0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000005")]
		public IReadOnlyList<RigidbodyEx> IAJCOJILOEF
		{
			[Cpp2IlInjected.Token(Token = "0x6000031")]
			[Cpp2IlInjected.Address(RVA = "0x7B1C50", Offset = "0x7B0A50", VA = "0x1807B1C50")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000032")]
			[Cpp2IlInjected.Address(RVA = "0x71C290", Offset = "0x71B090", VA = "0x18071C290")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000006")]
		public RigidbodyEx EDNEPPFOLOO
		{
			[Cpp2IlInjected.Token(Token = "0x6000033")]
			[Cpp2IlInjected.Address(RVA = "0x65B68F0", Offset = "0x65B56F0", VA = "0x1865B68F0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000007")]
		public RigidbodyEx CAHHKGJGOJO
		{
			[Cpp2IlInjected.Token(Token = "0x6000034")]
			[Cpp2IlInjected.Address(RVA = "0x65B6890", Offset = "0x65B5690", VA = "0x1865B6890")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000008")]
		public RigidbodyEx AABHIBJPKOH
		{
			[Cpp2IlInjected.Token(Token = "0x6000035")]
			[Cpp2IlInjected.Address(RVA = "0x65B7450", Offset = "0x65B6250", VA = "0x1865B7450")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000036")]
			[Cpp2IlInjected.Address(RVA = "0x65B8BA0", Offset = "0x65B79A0", VA = "0x1865B8BA0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000009")]
		public Transform FJKALEOIOIL
		{
			[Cpp2IlInjected.Token(Token = "0x6000037")]
			[Cpp2IlInjected.Address(RVA = "0xBEBAB0", Offset = "0xBEA8B0", VA = "0x180BEBAB0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000A")]
		public Transform FENNCJKPIPO
		{
			[Cpp2IlInjected.Token(Token = "0x6000038")]
			[Cpp2IlInjected.Address(RVA = "0xBEBAB0", Offset = "0xBEA8B0", VA = "0x180BEBAB0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000B")]
		public PFBDEHOAOJI MEOGMKAMEEP
		{
			[Cpp2IlInjected.Token(Token = "0x6000039")]
			[Cpp2IlInjected.Address(RVA = "0x65B6580", Offset = "0x65B5380", VA = "0x1865B6580")]
			get
			{
				return default(PFBDEHOAOJI);
			}
			[Cpp2IlInjected.Token(Token = "0x600003A")]
			[Cpp2IlInjected.Address(RVA = "0x65B8140", Offset = "0x65B6F40", VA = "0x1865B8140")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000C")]
		public bool HJEPBPJAOBD
		{
			[Cpp2IlInjected.Token(Token = "0x600003B")]
			[Cpp2IlInjected.Address(RVA = "0x65B6B00", Offset = "0x65B5900", VA = "0x1865B6B00")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000D")]
		public bool BCEMFENGFMG
		{
			[Cpp2IlInjected.Token(Token = "0x600003C")]
			[Cpp2IlInjected.Address(RVA = "0x65B6710", Offset = "0x65B5510", VA = "0x1865B6710")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000E")]
		public MDNFIBKLANB NBOHDJLOFIN
		{
			[Cpp2IlInjected.Token(Token = "0x600003D")]
			[Cpp2IlInjected.Address(RVA = "0x65B6AA0", Offset = "0x65B58A0", VA = "0x1865B6AA0")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600003E")]
			[Cpp2IlInjected.Address(RVA = "0x65B8350", Offset = "0x65B7150", VA = "0x1865B8350")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000F")]
		public IGIPPOIEHFL KGJELLKCKGD
		{
			[Cpp2IlInjected.Token(Token = "0x600003F")]
			[Cpp2IlInjected.Address(RVA = "0x65B6A40", Offset = "0x65B5840", VA = "0x1865B6A40")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000040")]
			[Cpp2IlInjected.Address(RVA = "0x65B82E0", Offset = "0x65B70E0", VA = "0x1865B82E0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000010")]
		public bool OGCFEGMFPMP
		{
			[Cpp2IlInjected.Token(Token = "0x6000041")]
			[Cpp2IlInjected.Address(RVA = "0x65B6920", Offset = "0x65B5720", VA = "0x1865B6920")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000011")]
		public Rigidbody AMAINOJCLLB
		{
			[Cpp2IlInjected.Token(Token = "0x6000042")]
			[Cpp2IlInjected.Address(RVA = "0x65B6980", Offset = "0x65B5780", VA = "0x1865B6980")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000012")]
		public bool DKOAFEFPELM
		{
			[Cpp2IlInjected.Token(Token = "0x6000043")]
			[Cpp2IlInjected.Address(RVA = "0x65B67D0", Offset = "0x65B55D0", VA = "0x1865B67D0")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000044")]
			[Cpp2IlInjected.Address(RVA = "0x65B8200", Offset = "0x65B7000", VA = "0x1865B8200")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000013")]
		public bool DCJACAHFENA
		{
			[Cpp2IlInjected.Token(Token = "0x6000045")]
			[Cpp2IlInjected.Address(RVA = "0x19CB840", Offset = "0x19CA640", VA = "0x1819CB840")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000046")]
			[Cpp2IlInjected.Address(RVA = "0x19CA9B0", Offset = "0x19C97B0", VA = "0x1819CA9B0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000014")]
		public float IIPDIFCPFDF
		{
			[Cpp2IlInjected.Token(Token = "0x6000047")]
			[Cpp2IlInjected.Address(RVA = "0x65B73F0", Offset = "0x65B61F0", VA = "0x1865B73F0")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000015")]
		public float KPEOPFPEIDA
		{
			[Cpp2IlInjected.Token(Token = "0x6000048")]
			[Cpp2IlInjected.Address(RVA = "0x65B7390", Offset = "0x65B6190", VA = "0x1865B7390")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x6000049")]
			[Cpp2IlInjected.Address(RVA = "0x65B8B30", Offset = "0x65B7930", VA = "0x1865B8B30")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000016")]
		public float NNMCIFGABFK
		{
			[Cpp2IlInjected.Token(Token = "0x600004A")]
			[Cpp2IlInjected.Address(RVA = "0x65B6D60", Offset = "0x65B5B60", VA = "0x1865B6D60")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x600004B")]
			[Cpp2IlInjected.Address(RVA = "0x65B85F0", Offset = "0x65B73F0", VA = "0x1865B85F0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000017")]
		public float BBCMEKLILBH
		{
			[Cpp2IlInjected.Token(Token = "0x600004C")]
			[Cpp2IlInjected.Address(RVA = "0x65B6B60", Offset = "0x65B5960", VA = "0x1865B6B60")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x600004D")]
			[Cpp2IlInjected.Address(RVA = "0x65B83C0", Offset = "0x65B71C0", VA = "0x1865B83C0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000018")]
		public bool DOCOJPFAHJE
		{
			[Cpp2IlInjected.Token(Token = "0x600004E")]
			[Cpp2IlInjected.Address(RVA = "0x65B7970", Offset = "0x65B6770", VA = "0x1865B7970")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x600004F")]
			[Cpp2IlInjected.Address(RVA = "0x65B90E0", Offset = "0x65B7EE0", VA = "0x1865B90E0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000019")]
		public Vector3 AKKEPDMOLNJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000050")]
			[Cpp2IlInjected.Address(RVA = "0x65B7170", Offset = "0x65B5F70", VA = "0x1865B7170")]
			get
			{
				return default(Vector3);
			}
			[Cpp2IlInjected.Token(Token = "0x6000051")]
			[Cpp2IlInjected.Address(RVA = "0x65B8900", Offset = "0x65B7700", VA = "0x1865B8900")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001A")]
		public Vector3 AIFFLDMOIAE
		{
			[Cpp2IlInjected.Token(Token = "0x6000052")]
			[Cpp2IlInjected.Address(RVA = "0x65B7AB0", Offset = "0x65B68B0", VA = "0x1865B7AB0")]
			get
			{
				return default(Vector3);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001B")]
		public CollisionDetectionMode DLDEDHNLKJN
		{
			[Cpp2IlInjected.Token(Token = "0x6000053")]
			[Cpp2IlInjected.Address(RVA = "0x65B6CA0", Offset = "0x65B5AA0", VA = "0x1865B6CA0")]
			get
			{
				return default(CollisionDetectionMode);
			}
			[Cpp2IlInjected.Token(Token = "0x6000054")]
			[Cpp2IlInjected.Address(RVA = "0x65B8510", Offset = "0x65B7310", VA = "0x1865B8510")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001C")]
		public float ELIKFBMBBPJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000055")]
			[Cpp2IlInjected.Address(RVA = "0x65B6830", Offset = "0x65B5630", VA = "0x1865B6830")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x6000056")]
			[Cpp2IlInjected.Address(RVA = "0x65B8270", Offset = "0x65B7070", VA = "0x1865B8270")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001D")]
		public RigidbodyConstraints FBGFEDKLKMO
		{
			[Cpp2IlInjected.Token(Token = "0x6000057")]
			[Cpp2IlInjected.Address(RVA = "0x65B6D00", Offset = "0x65B5B00", VA = "0x1865B6D00")]
			get
			{
				return default(RigidbodyConstraints);
			}
			[Cpp2IlInjected.Token(Token = "0x6000058")]
			[Cpp2IlInjected.Address(RVA = "0x65B8580", Offset = "0x65B7380", VA = "0x1865B8580")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001E")]
		public Vector3 CMEDKCKHFCB
		{
			[Cpp2IlInjected.Token(Token = "0x6000059")]
			[Cpp2IlInjected.Address(RVA = "0x65B74B0", Offset = "0x65B62B0", VA = "0x1865B74B0")]
			get
			{
				return default(Vector3);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001F")]
		public Vector3 ALKFAAFKNNO
		{
			[Cpp2IlInjected.Token(Token = "0x600005A")]
			[Cpp2IlInjected.Address(RVA = "0x65B74B0", Offset = "0x65B62B0", VA = "0x1865B74B0")]
			get
			{
				return default(Vector3);
			}
			[Cpp2IlInjected.Token(Token = "0x600005B")]
			[Cpp2IlInjected.Address(RVA = "0x65B8EB0", Offset = "0x65B7CB0", VA = "0x1865B8EB0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000020")]
		public float NOCFECJDNEC
		{
			[Cpp2IlInjected.Token(Token = "0x600005C")]
			[Cpp2IlInjected.Address(RVA = "0x65B7250", Offset = "0x65B6050", VA = "0x1865B7250")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x600005D")]
			[Cpp2IlInjected.Address(RVA = "0x65B89E0", Offset = "0x65B77E0", VA = "0x1865B89E0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000021")]
		public float OFNAPBBDMDJ
		{
			[Cpp2IlInjected.Token(Token = "0x600005E")]
			[Cpp2IlInjected.Address(RVA = "0x65B7910", Offset = "0x65B6710", VA = "0x1865B7910")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x600005F")]
			[Cpp2IlInjected.Address(RVA = "0x65B9070", Offset = "0x65B7E70", VA = "0x1865B9070")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000022")]
		public Quaternion LHPDODGKGNJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000060")]
			[Cpp2IlInjected.Address(RVA = "0x65B7590", Offset = "0x65B6390", VA = "0x1865B7590")]
			get
			{
				return default(Quaternion);
			}
			[Cpp2IlInjected.Token(Token = "0x6000061")]
			[Cpp2IlInjected.Address(RVA = "0x65B8C10", Offset = "0x65B7A10", VA = "0x1865B8C10")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000023")]
		public Quaternion DNHKPODDFFH
		{
			[Cpp2IlInjected.Token(Token = "0x6000062")]
			[Cpp2IlInjected.Address(RVA = "0x65B7830", Offset = "0x65B6630", VA = "0x1865B7830")]
			get
			{
				return default(Quaternion);
			}
			[Cpp2IlInjected.Token(Token = "0x6000063")]
			[Cpp2IlInjected.Address(RVA = "0x65B8F90", Offset = "0x65B7D90", VA = "0x1865B8F90")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000024")]
		public Vector3 IIKFDJFIPMD
		{
			[Cpp2IlInjected.Token(Token = "0x6000064")]
			[Cpp2IlInjected.Address(RVA = "0x65B7670", Offset = "0x65B6470", VA = "0x1865B7670")]
			get
			{
				return default(Vector3);
			}
			[Cpp2IlInjected.Token(Token = "0x6000065")]
			[Cpp2IlInjected.Address(RVA = "0x65B8CF0", Offset = "0x65B7AF0", VA = "0x1865B8CF0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000025")]
		public Quaternion HGFCJALMOIN
		{
			[Cpp2IlInjected.Token(Token = "0x6000066")]
			[Cpp2IlInjected.Address(RVA = "0x65B7750", Offset = "0x65B6550", VA = "0x1865B7750")]
			get
			{
				return default(Quaternion);
			}
			[Cpp2IlInjected.Token(Token = "0x6000067")]
			[Cpp2IlInjected.Address(RVA = "0x65B8DD0", Offset = "0x65B7BD0", VA = "0x1865B8DD0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000026")]
		public Vector3 POJKCICHJIK
		{
			[Cpp2IlInjected.Token(Token = "0x6000068")]
			[Cpp2IlInjected.Address(RVA = "0x65B79D0", Offset = "0x65B67D0", VA = "0x1865B79D0")]
			get
			{
				return default(Vector3);
			}
			[Cpp2IlInjected.Token(Token = "0x6000069")]
			[Cpp2IlInjected.Address(RVA = "0x65B9150", Offset = "0x65B7F50", VA = "0x1865B9150")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000027")]
		public Vector3 AFLGANKGICH
		{
			[Cpp2IlInjected.Token(Token = "0x600006A")]
			[Cpp2IlInjected.Address(RVA = "0x65B72B0", Offset = "0x65B60B0", VA = "0x1865B72B0")]
			get
			{
				return default(Vector3);
			}
			[Cpp2IlInjected.Token(Token = "0x600006B")]
			[Cpp2IlInjected.Address(RVA = "0x65B8A50", Offset = "0x65B7850", VA = "0x1865B8A50")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000028")]
		public Vector3 EOPDAFKMAEL
		{
			[Cpp2IlInjected.Token(Token = "0x600006C")]
			[Cpp2IlInjected.Address(RVA = "0x65B6BC0", Offset = "0x65B59C0", VA = "0x1865B6BC0")]
			get
			{
				return default(Vector3);
			}
			[Cpp2IlInjected.Token(Token = "0x600006D")]
			[Cpp2IlInjected.Address(RVA = "0x65B8430", Offset = "0x65B7230", VA = "0x1865B8430")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000029")]
		public Vector3 IDJHMKHCMIA
		{
			[Cpp2IlInjected.Token(Token = "0x600006E")]
			[Cpp2IlInjected.Address(RVA = "0x65B7090", Offset = "0x65B5E90", VA = "0x1865B7090")]
			get
			{
				return default(Vector3);
			}
			[Cpp2IlInjected.Token(Token = "0x600006F")]
			[Cpp2IlInjected.Address(RVA = "0x65B8820", Offset = "0x65B7620", VA = "0x1865B8820")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002A")]
		public Vector3 ICCJLPALJKA
		{
			[Cpp2IlInjected.Token(Token = "0x6000070")]
			[Cpp2IlInjected.Address(RVA = "0x65B6F50", Offset = "0x65B5D50", VA = "0x1865B6F50")]
			get
			{
				return default(Vector3);
			}
			[Cpp2IlInjected.Token(Token = "0x6000071")]
			[Cpp2IlInjected.Address(RVA = "0x65B8740", Offset = "0x65B7540", VA = "0x1865B8740")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002B")]
		public Quaternion PEODBNAIMLE
		{
			[Cpp2IlInjected.Token(Token = "0x6000072")]
			[Cpp2IlInjected.Address(RVA = "0x65B6E70", Offset = "0x65B5C70", VA = "0x1865B6E70")]
			get
			{
				return default(Quaternion);
			}
			[Cpp2IlInjected.Token(Token = "0x6000073")]
			[Cpp2IlInjected.Address(RVA = "0x65B8660", Offset = "0x65B7460", VA = "0x1865B8660")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002C")]
		public Vector3 ODEBKHOFEHE
		{
			[Cpp2IlInjected.Token(Token = "0x6000074")]
			[Cpp2IlInjected.Address(RVA = "0x65B7C70", Offset = "0x65B6A70", VA = "0x1865B7C70")]
			get
			{
				return default(Vector3);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002D")]
		public Vector3 CNGMLKBJACN
		{
			[Cpp2IlInjected.Token(Token = "0x6000075")]
			[Cpp2IlInjected.Address(RVA = "0x65B7B90", Offset = "0x65B6990", VA = "0x1865B7B90")]
			get
			{
				return default(Vector3);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002E")]
		public bool HOMNNPNFFHH
		{
			[Cpp2IlInjected.Token(Token = "0x6000076")]
			[Cpp2IlInjected.Address(RVA = "0x65B7030", Offset = "0x65B5E30", VA = "0x1865B7030")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002F")]
		public bool BIBDGFIAGJM
		{
			[Cpp2IlInjected.Token(Token = "0x6000077")]
			[Cpp2IlInjected.Address(RVA = "0x65B6770", Offset = "0x65B5570", VA = "0x1865B6770")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000030")]
		public bool BHJMJPEEHFL
		{
			[Cpp2IlInjected.Token(Token = "0x6000078")]
			[Cpp2IlInjected.Address(RVA = "0x65B66B0", Offset = "0x65B54B0", VA = "0x1865B66B0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000031")]
		public bool DCDPHNJFFFB
		{
			[Cpp2IlInjected.Token(Token = "0x6000079")]
			[Cpp2IlInjected.Address(RVA = "0x65B6650", Offset = "0x65B5450", VA = "0x1865B6650")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000032")]
		public bool OKEBAKFHKOE
		{
			[Cpp2IlInjected.Token(Token = "0x600007A")]
			[Cpp2IlInjected.Address(RVA = "0x65B6520", Offset = "0x65B5320", VA = "0x1865B6520")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000033")]
		public bool PKODLMCLLLH
		{
			[Cpp2IlInjected.Token(Token = "0x600007B")]
			[Cpp2IlInjected.Address(RVA = "0x65B6DC0", Offset = "0x65B5BC0", VA = "0x1865B6DC0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000034")]
		public bool CKBGNMHNINE
		{
			[Cpp2IlInjected.Token(Token = "0x600007C")]
			[Cpp2IlInjected.Address(RVA = "0x91A770", Offset = "0x919570", VA = "0x18091A770")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000001")]
		public event IJDKLAGCEFG JCEOLNHPEFF
		{
			[Cpp2IlInjected.Token(Token = "0x600001F")]
			[Cpp2IlInjected.Address(RVA = "0x65B6440", Offset = "0x65B5240", VA = "0x1865B6440")]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000020")]
			[Cpp2IlInjected.Address(RVA = "0x65B8060", Offset = "0x65B6E60", VA = "0x1865B8060")]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000002")]
		public event MHEGFHPPLGP DHODHLMPEIL
		{
			[Cpp2IlInjected.Token(Token = "0x6000021")]
			[Cpp2IlInjected.Address(RVA = "0x65B63D0", Offset = "0x65B51D0", VA = "0x1865B63D0")]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000022")]
			[Cpp2IlInjected.Address(RVA = "0x65B7FF0", Offset = "0x65B6DF0", VA = "0x1865B7FF0")]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000003")]
		public event IJDKLAGCEFG PBOBAMPILGB
		{
			[Cpp2IlInjected.Token(Token = "0x6000023")]
			[Cpp2IlInjected.Address(RVA = "0x65B6130", Offset = "0x65B4F30", VA = "0x1865B6130")]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000024")]
			[Cpp2IlInjected.Address(RVA = "0x65B7D50", Offset = "0x65B6B50", VA = "0x1865B7D50")]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000004")]
		public event IJDKLAGCEFG GKGJJLMHDLI
		{
			[Cpp2IlInjected.Token(Token = "0x6000025")]
			[Cpp2IlInjected.Address(RVA = "0x65B61A0", Offset = "0x65B4FA0", VA = "0x1865B61A0")]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000026")]
			[Cpp2IlInjected.Address(RVA = "0x65B7DC0", Offset = "0x65B6BC0", VA = "0x1865B7DC0")]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000005")]
		public event IJDKLAGCEFG NAHKAOPHPKB
		{
			[Cpp2IlInjected.Token(Token = "0x6000027")]
			[Cpp2IlInjected.Address(RVA = "0x65B62F0", Offset = "0x65B50F0", VA = "0x1865B62F0")]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000028")]
			[Cpp2IlInjected.Address(RVA = "0x65B7F10", Offset = "0x65B6D10", VA = "0x1865B7F10")]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000006")]
		public event Action<EHKPJAMPICF, EHKPJAMPICF> JCAEOOCFBGA
		{
			[Cpp2IlInjected.Token(Token = "0x6000029")]
			[Cpp2IlInjected.Address(RVA = "0x65B6280", Offset = "0x65B5080", VA = "0x1865B6280")]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x600002A")]
			[Cpp2IlInjected.Address(RVA = "0x65B7EA0", Offset = "0x65B6CA0", VA = "0x1865B7EA0")]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000007")]
		public event IJDKLAGCEFG PMJFHMKKFJM
		{
			[Cpp2IlInjected.Token(Token = "0x600002B")]
			[Cpp2IlInjected.Address(RVA = "0x65B6360", Offset = "0x65B5160", VA = "0x1865B6360")]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x600002C")]
			[Cpp2IlInjected.Address(RVA = "0x65B7F80", Offset = "0x65B6D80", VA = "0x1865B7F80")]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000008")]
		public event IJDKLAGCEFG MIJCPHCDDDA
		{
			[Cpp2IlInjected.Token(Token = "0x600002D")]
			[Cpp2IlInjected.Address(RVA = "0x65B64B0", Offset = "0x65B52B0", VA = "0x1865B64B0")]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x600002E")]
			[Cpp2IlInjected.Address(RVA = "0x65B80D0", Offset = "0x65B6ED0", VA = "0x1865B80D0")]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000009")]
		public event IJDKLAGCEFG HMNHPLAABPL
		{
			[Cpp2IlInjected.Token(Token = "0x600002F")]
			[Cpp2IlInjected.Address(RVA = "0x65B6210", Offset = "0x65B5010", VA = "0x1865B6210")]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000030")]
			[Cpp2IlInjected.Address(RVA = "0x65B7E30", Offset = "0x65B6C30", VA = "0x1865B7E30")]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(RVA = "0x71C2B0", Offset = "0x71B0B0", VA = "0x18071C2B0")]
		internal void KBOAHEDOLHC(DDICDNFJGFA HLKJMHJNLMO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0x65B4A30", Offset = "0x65B3830", VA = "0x1865B4A30")]
		internal void DNIMGAKEMGF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x65B5E80", Offset = "0x65B4C80", VA = "0x1865B5E80")]
		[Conditional("DEBUG_BUILD")]
		[Conditional("UNITY_EDITOR")]
		public void TestOverrideUnityRigidbody(Rigidbody LOGEMHNKGGE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007D")]
		[Cpp2IlInjected.Address(RVA = "0x65B4730", Offset = "0x65B3530", VA = "0x1865B4730")]
		private void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007E")]
		[Cpp2IlInjected.Address(RVA = "0x65B47A0", Offset = "0x65B35A0", VA = "0x1865B47A0")]
		private DDICDNFJGFA BBMIMPGKJAO()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600007F")]
		[Cpp2IlInjected.Address(RVA = "0x65B4E60", Offset = "0x65B3C60", VA = "0x1865B4E60")]
		private void KKLPLLLGLNM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000080")]
		[Cpp2IlInjected.Address(RVA = "0x65B53C0", Offset = "0x65B41C0", VA = "0x1865B53C0")]
		private void OnEnable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000081")]
		[Cpp2IlInjected.Address(RVA = "0x65B5350", Offset = "0x65B4150", VA = "0x1865B5350")]
		private void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000082")]
		[Cpp2IlInjected.Address(RVA = "0x65B4B20", Offset = "0x65B3920", VA = "0x1865B4B20")]
		private void FixedUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000083")]
		[Cpp2IlInjected.Address(RVA = "0x65B5360", Offset = "0x65B4160", VA = "0x1865B5360")]
		private void OnDrawGizmosSelected()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000084")]
		[Cpp2IlInjected.Address(RVA = "0x65B5420", Offset = "0x65B4220", VA = "0x1865B5420")]
		private void OnValidate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000085")]
		[Cpp2IlInjected.Address(RVA = "0x65B3DC0", Offset = "0x65B2BC0", VA = "0x1865B3DC0")]
		public void AddDoNotResetVelocityOnOwnershipChangeOverride(object INDCJAMMAIN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000086")]
		[Cpp2IlInjected.Address(RVA = "0x65B5490", Offset = "0x65B4290", VA = "0x1865B5490")]
		public void RemoveDoNotResetVelocityOnOwnershipChangeOverride(object INDCJAMMAIN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000087")]
		[Cpp2IlInjected.Address(RVA = "0x65B4AC0", Offset = "0x65B38C0", VA = "0x1865B4AC0")]
		public void DisableCachedInertialPropertyOverride()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000088")]
		[Cpp2IlInjected.Address(RVA = "0x65B52F0", Offset = "0x65B40F0", VA = "0x1865B52F0")]
		public void MarkCachedInertialParametersDirty()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000089")]
		[Cpp2IlInjected.Address(RVA = "0x65B5C80", Offset = "0x65B4A80", VA = "0x1865B5C80")]
		public void SetParent(RigidbodyEx NLHFEJHKLAH, bool BNLMFCPNEHF = false)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008A")]
		[Cpp2IlInjected.Address(RVA = "0x65B57A0", Offset = "0x65B45A0", VA = "0x1865B57A0")]
		public void ResetLocalCenterOfMassToPrefabDefault()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008B")]
		[Cpp2IlInjected.Address(RVA = "0x65B4D80", Offset = "0x65B3B80", VA = "0x1865B4D80")]
		public bool IsRigidbodyAncestor(RigidbodyEx KNCDCFIFNGJ)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600008C")]
		[Cpp2IlInjected.Address(RVA = "0x65B4DC0", Offset = "0x65B3BC0", VA = "0x1865B4DC0")]
		public bool IsRigidbodyDescendant(RigidbodyEx OCELHNBKHHL)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600008D")]
		[Cpp2IlInjected.Address(RVA = "0x65B3FE0", Offset = "0x65B2DE0", VA = "0x1865B3FE0")]
		public void AddInterpolationRestriction(object INDCJAMMAIN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008E")]
		[Cpp2IlInjected.Address(RVA = "0x65B5500", Offset = "0x65B4300", VA = "0x1865B5500")]
		public void RemoveInterpolationRestriction(object INDCJAMMAIN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008F")]
		[Cpp2IlInjected.Address(RVA = "0x65B4850", Offset = "0x65B3650", VA = "0x1865B4850")]
		public IDisposable BeginKinematicScope()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000090")]
		[Cpp2IlInjected.Address(RVA = "0x65B4050", Offset = "0x65B2E50", VA = "0x1865B4050")]
		public void AddKinematic(object INDCJAMMAIN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000091")]
		[Cpp2IlInjected.Address(RVA = "0x65B5570", Offset = "0x65B4370", VA = "0x1865B5570")]
		public void RemoveKinematic(object INDCJAMMAIN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000092")]
		[Cpp2IlInjected.Address(RVA = "0x65B5C00", Offset = "0x65B4A00", VA = "0x1865B5C00")]
		public void SetKinematic(object INDCJAMMAIN, bool NKIGKALHKKG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000093")]
		[Cpp2IlInjected.Address(RVA = "0x65B5B00", Offset = "0x65B4900", VA = "0x1865B5B00")]
		public void SetDiscontinuousPositionAndRotation(Vector3 KPJPKNEEHFJ, Quaternion FFPDKCAEKDA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000094")]
		[Cpp2IlInjected.Address(RVA = "0x65B5A00", Offset = "0x65B4800", VA = "0x1865B5A00")]
		public void SetDiscontinuousLocalPositionAndLocalRotation(Vector3 APJBCHKNCHD, Quaternion LIMMBJPINMP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000095")]
		[Cpp2IlInjected.Address(RVA = "0x65B4C80", Offset = "0x65B3A80", VA = "0x1865B4C80")]
		public Vector3 GetConstrainedVelocity(Vector3 POJKCICHJIK)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x6000096")]
		[Cpp2IlInjected.Address(RVA = "0x65B4B80", Offset = "0x65B3980", VA = "0x1865B4B80")]
		public Vector3 GetConstrainedAngularVelocity(Vector3 EOPDAFKMAEL)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x6000097")]
		[Cpp2IlInjected.Address(RVA = "0x65B3F50", Offset = "0x65B2D50", VA = "0x1865B3F50")]
		public void AddForce(Vector3 AJKJHFCHOAK, ForceMode GMFAKLHMDNN = ForceMode.Force)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000098")]
		[Cpp2IlInjected.Address(RVA = "0x65B3E30", Offset = "0x65B2C30", VA = "0x1865B3E30")]
		public void AddForceAtPosition(Vector3 AJKJHFCHOAK, Vector3 CBAKPHLPCPB, ForceMode GMFAKLHMDNN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000099")]
		[Cpp2IlInjected.Address(RVA = "0x65B4150", Offset = "0x65B2F50", VA = "0x1865B4150")]
		public void AddTorque(Vector3 OJLGOOKKJEA, ForceMode GMFAKLHMDNN = ForceMode.Force)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009A")]
		[Cpp2IlInjected.Address(RVA = "0x65B40C0", Offset = "0x65B2EC0", VA = "0x1865B40C0")]
		public void AddRelativeTorque(Vector3 OJLGOOKKJEA, ForceMode GMFAKLHMDNN = ForceMode.Force)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009B")]
		[Cpp2IlInjected.Address(RVA = "0x65B5F60", Offset = "0x65B4D60", VA = "0x1865B5F60")]
		public Vector3 WorldToLocalVelocity(Vector3 LGHPPABOKOK)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x600009C")]
		[Cpp2IlInjected.Address(RVA = "0x65B51F0", Offset = "0x65B3FF0", VA = "0x1865B51F0")]
		public Vector3 LocalToWorldVelocity(Vector3 AFLGANKGICH)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x600009D")]
		[Cpp2IlInjected.Address(RVA = "0x65B49D0", Offset = "0x65B37D0", VA = "0x1865B49D0")]
		public void ClearVelocity()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009E")]
		[Cpp2IlInjected.Address(RVA = "0x65B4970", Offset = "0x65B3770", VA = "0x1865B4970")]
		public void ClearUnityRigidbodyVelocity()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009F")]
		[Cpp2IlInjected.Address(RVA = "0x65B4910", Offset = "0x65B3710", VA = "0x1865B4910")]
		public void ClearLinearVelocity()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A0")]
		[Cpp2IlInjected.Address(RVA = "0x65B48B0", Offset = "0x65B36B0", VA = "0x1865B48B0")]
		public void ClearAngularVelocity()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A1")]
		[Cpp2IlInjected.Address(RVA = "0x65B5900", Offset = "0x65B4700", VA = "0x1865B5900")]
		public void ResetVelocityWorldSpace(Vector3 IMMOLPOLNBA, Vector3 OGMHJOIPEGI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A2")]
		[Cpp2IlInjected.Address(RVA = "0x65B5800", Offset = "0x65B4600", VA = "0x1865B5800")]
		public void ResetVelocityLocalSpace(Vector3 IAOEEAAKMPP, Vector3 IDJHMKHCMIA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A3")]
		[Cpp2IlInjected.Address(RVA = "0x65B56C0", Offset = "0x65B44C0", VA = "0x1865B56C0")]
		public void ResetLinearVelocityLocalSpace(Vector3 IAOEEAAKMPP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A4")]
		[Cpp2IlInjected.Address(RVA = "0x65B5D70", Offset = "0x65B4B70", VA = "0x1865B5D70")]
		public bool SweepTest(Vector3 HHGBGELADCO, out RaycastHit MFKIKGLHAMN, float EMEIKNNEGHK)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000A5")]
		[Cpp2IlInjected.Address(RVA = "0x65B4E00", Offset = "0x65B3C00", VA = "0x1865B4E00")]
		public bool IsSleeping()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000A6")]
		[Cpp2IlInjected.Address(RVA = "0x65B5D10", Offset = "0x65B4B10", VA = "0x1865B5D10")]
		public void Sleep()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A7")]
		[Cpp2IlInjected.Address(RVA = "0x65B5F00", Offset = "0x65B4D00", VA = "0x1865B5F00")]
		public void WakeUp()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A8")]
		[Cpp2IlInjected.Address(RVA = "0x65B41E0", Offset = "0x65B2FE0", VA = "0x1865B41E0")]
		public void AddUnityRigidbody(object INDCJAMMAIN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A9")]
		[Cpp2IlInjected.Address(RVA = "0x65B55E0", Offset = "0x65B43E0", VA = "0x1865B55E0")]
		public void RemoveUnityRigidbody(object INDCJAMMAIN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AA")]
		[Cpp2IlInjected.Address(RVA = "0x65B4500", Offset = "0x65B3300", VA = "0x1865B4500")]
		public void ApplyForceVelocityChange(GOIGKHJPKIL LKEHIILFBGJ, Vector3 CPJPNJCMJAL, float LJKLGGMAHOJ, float LHJEDBKLJNN = 8f, float PAKBBNDEEJP = 1f)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AB")]
		[Cpp2IlInjected.Address(RVA = "0x65B4400", Offset = "0x65B3200", VA = "0x1865B4400")]
		public void ApplyAngularVelocityChange(OEBNECHHPCF GDDGFGKAHMD, Vector3 BNCCLPFNHEL, float JEMKJHNONPD = float.PositiveInfinity)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AC")]
		[Cpp2IlInjected.Address(RVA = "0x65B4620", Offset = "0x65B3420", VA = "0x1865B4620")]
		[Obsolete]
		public void ApplyTorqueAngularVelocityChangeDeprecated(OEBNECHHPCF GDDGFGKAHMD, Vector3 HKMKNOBAIAN, float NIDEHIHCIBC = 7f, float DLGLDDADCFL = 1f)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AD")]
		[Cpp2IlInjected.Address(RVA = "0x65B4340", Offset = "0x65B3140", VA = "0x1865B4340")]
		public bool AllowedScaleChange(float MHHMHIKNPME)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000AE")]
		[Cpp2IlInjected.Address(RVA = "0x65B4250", Offset = "0x65B3050", VA = "0x1865B4250")]
		public void AddWorldSpaceVelocityInHierarchyParentOverride(RigidbodyEx JCBNEMEEHFF, object INDCJAMMAIN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AF")]
		[Cpp2IlInjected.Address(RVA = "0x65B5650", Offset = "0x65B4450", VA = "0x1865B5650")]
		public void RemoveWorldSpaceVelocityInHierarchyParentOverride(object INDCJAMMAIN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B0")]
		[Cpp2IlInjected.Address(RVA = "0x65B60B0", Offset = "0x65B4EB0", VA = "0x1865B60B0")]
		public RigidbodyEx()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
internal static class GPMGOEFPKFB
{
	[Cpp2IlInjected.Token(Token = "0x60000B5")]
	[Cpp2IlInjected.Address(RVA = "0x5591850", Offset = "0x5590650", VA = "0x185591850")]
	public static DDICDNFJGFA AHBOCLNKFHO(this RigidbodyEx FBJBBGAMODK)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
public struct GPHOCGFKAIA
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000022")]
	public Rigidbody EMPCHDNCBNN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000023")]
	public PhotonView PADBKMIMBKI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000024")]
	public OverridableVector3 ECEDLMGLAPN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000025")]
	public OverridableVector3 IKAGKIDIKJA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000026")]
	public CAMOGAJBAFF EBLAAKCPACB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
	[Cpp2IlInjected.Token(Token = "0x4000027")]
	public bool EEPMOMOHGLP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x35")]
	[Cpp2IlInjected.Token(Token = "0x4000028")]
	public bool LEBADAPGAAL;
}
namespace RecRoom
{
	[Cpp2IlInjected.Token(Token = "0x200000E")]
	[IDOCBBAEIFB(JHEANMHFGAO.Physics)]
	[IHOFDNBJLIN(typeof(BABOKGOAEJI), new string[] { })]
	public class RigidbodyExManager : BABOKGOAEJI, OMEPFIBEFCP
	{
		[Cpp2IlInjected.Token(Token = "0x4000029")]
		private static readonly JFPIEAPAMJM MCHCOEKKPGN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400002A")]
		private NCEPMNGGADP LBJPFNIJFLL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400002B")]
		private GACFLJPDFAI JPLBGCKPACG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400002C")]
		private JBGBBADNNKI FDGPMNJHKBG;

		[Cpp2IlInjected.Token(Token = "0x17000035")]
		public bool CICAHOKMKJJ
		{
			[Cpp2IlInjected.Token(Token = "0x60000B6")]
			[Cpp2IlInjected.Address(RVA = "0x65B3670", Offset = "0x65B2470", VA = "0x1865B3670", Slot = "6")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000036")]
		public GACFLJPDFAI GGGDIHGAIAP
		{
			[Cpp2IlInjected.Token(Token = "0x60000B7")]
			[Cpp2IlInjected.Address(RVA = "0x6FA140", Offset = "0x6F8F40", VA = "0x1806FA140", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000037")]
		public JBGBBADNNKI BLFNNEFBJJD
		{
			[Cpp2IlInjected.Token(Token = "0x60000B8")]
			[Cpp2IlInjected.Address(RVA = "0x6FA130", Offset = "0x6F8F30", VA = "0x1806FA130", Slot = "5")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000B9")]
		[Cpp2IlInjected.Address(RVA = "0x65B3CE0", Offset = "0x65B2AE0", VA = "0x1865B3CE0", Slot = "12")]
		public void PIFNIFBDCBM(AACHPGDKAKL PIMEDEKHCHH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000BA")]
		[Cpp2IlInjected.Address(RVA = "0x65B36C0", Offset = "0x65B24C0", VA = "0x1865B36C0", Slot = "7")]
		public IMKMJFJEHIJ HIAJIEALNAN(RigidbodyEx FBJBBGAMODK)
		{
			return default(IMKMJFJEHIJ);
		}

		[Cpp2IlInjected.Token(Token = "0x60000BB")]
		[Cpp2IlInjected.Address(RVA = "0x65B34B0", Offset = "0x65B22B0", VA = "0x1865B34B0")]
		private static IMKMJFJEHIJ DAJKAHIFCAL(RigidbodyEx FBJBBGAMODK)
		{
			return default(IMKMJFJEHIJ);
		}

		[Cpp2IlInjected.Token(Token = "0x60000BC")]
		[Cpp2IlInjected.Address(RVA = "0x65B3AE0", Offset = "0x65B28E0", VA = "0x1865B3AE0", Slot = "8")]
		public DDICDNFJGFA NJANEGHFIMH(RigidbodyEx FBJBBGAMODK, GPHOCGFKAIA PHAPMEHMHAK)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000BD")]
		[Cpp2IlInjected.Address(RVA = "0x65B35A0", Offset = "0x65B23A0", VA = "0x1865B35A0", Slot = "11")]
		private RigidbodyEx GBJKOGCFGCF(GameObject BEPEHBCCEGM, GPHOCGFKAIA PHAPMEHMHAK)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000BE")]
		[Cpp2IlInjected.Address(RVA = "0x65B3BF0", Offset = "0x65B29F0", VA = "0x1865B3BF0", Slot = "9")]
		public void OBOFDEKFGBD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000BF")]
		[Cpp2IlInjected.Address(RVA = "0x65B3990", Offset = "0x65B2790", VA = "0x1865B3990", Slot = "10")]
		public void ILHBJMBCFCB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C0")]
		[Cpp2IlInjected.Address(RVA = "0x6ECCD0", Offset = "0x6EBAD0", VA = "0x1806ECCD0")]
		public RigidbodyExManager()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000F")]
	public class PhysicsManager : SingletonMonoBehaviour<PhysicsManager>
	{
		[Cpp2IlInjected.Token(Token = "0x400002D")]
		public static CPHLPGCHIIP UpdateAfterFixedUpdateRan;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400002E")]
		private int MGIFADNHNBB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x400002F")]
		private int ELIEPKEJKLC;

		[Cpp2IlInjected.Token(Token = "0x60000C2")]
		[Cpp2IlInjected.Address(RVA = "0x65B2F90", Offset = "0x65B1D90", VA = "0x1865B2F90")]
		protected void FixedUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C3")]
		[Cpp2IlInjected.Address(RVA = "0x65B2FD0", Offset = "0x65B1DD0", VA = "0x1865B2FD0")]
		protected void Update()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C4")]
		[Cpp2IlInjected.Address(RVA = "0x65B2FB0", Offset = "0x65B1DB0", VA = "0x1865B2FB0")]
		protected void LateUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C5")]
		[Cpp2IlInjected.Address(RVA = "0x6ED320", Offset = "0x6EC120", VA = "0x1806ED320")]
		[Conditional("UNITY_ASSERTIONS")]
		public void AssertLateColliderPositionsNotYetUpdated([Optional] string GNDOGDAIOKH, [Optional] UnityEngine.Object KPEPJOHCOMD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C6")]
		[Cpp2IlInjected.Address(RVA = "0x6ED320", Offset = "0x6EC120", VA = "0x1806ED320")]
		[Conditional("UNITY_ASSERTIONS")]
		public void AssertLateColliderPositionsAlreadyUpdated([Optional] string GNDOGDAIOKH, [Optional] UnityEngine.Object KPEPJOHCOMD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C7")]
		[Cpp2IlInjected.Address(RVA = "0x65B30C0", Offset = "0x65B1EC0", VA = "0x1865B30C0")]
		public PhysicsManager()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
public static class HGNDFLPHJAE
{
	[Cpp2IlInjected.Token(Token = "0x60000C9")]
	[Cpp2IlInjected.Address(RVA = "0x55944F0", Offset = "0x55932F0", VA = "0x1855944F0")]
	public static void BIJCKINMCMD(this Rigidbody LOGEMHNKGGE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CA")]
	[Cpp2IlInjected.Address(RVA = "0x55943E0", Offset = "0x55931E0", VA = "0x1855943E0")]
	public static void BIJCKINMCMD(this Rigidbody LOGEMHNKGGE, Vector3 ICCJLPALJKA, Quaternion PEODBNAIMLE, Vector3 AHAAFKKLDCJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CB")]
	[Cpp2IlInjected.Address(RVA = "0x5594640", Offset = "0x5593440", VA = "0x185594640")]
	public static void EKGNNCHJHDC(Vector3 POJKCICHJIK, Vector3 FBLODFOLDGP, out Vector3 NIMGMJIFPPC, out Vector3 BJGBPFGFDOC)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
public static class EEEKIFEGAAD
{
	[Cpp2IlInjected.Token(Token = "0x2000012")]
	private class LIHFFAOPIJO : MDNFIBKLANB, IDisposable
	{
		[Cpp2IlInjected.Token(Token = "0x60000CE")]
		[Cpp2IlInjected.Address(RVA = "0x6ED320", Offset = "0x6EC120", VA = "0x1806ED320", Slot = "6")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000CF")]
		[Cpp2IlInjected.Address(RVA = "0x1838F10", Offset = "0x1837D10", VA = "0x181838F10", Slot = "4")]
		public Vector3 FEJFNFBJKGG()
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x60000D0")]
		[Cpp2IlInjected.Address(RVA = "0x1838F10", Offset = "0x1837D10", VA = "0x181838F10", Slot = "5")]
		public Vector3 JMOPBFHFCID()
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x60000D1")]
		[Cpp2IlInjected.Address(RVA = "0x6ECCD0", Offset = "0x6EBAD0", VA = "0x1806ECCD0")]
		public LIHFFAOPIJO()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000038")]
	public static MDNFIBKLANB DPJOLMGFAPN
	{
		[Cpp2IlInjected.Token(Token = "0x60000CC")]
		[Cpp2IlInjected.Address(RVA = "0x55900F0", Offset = "0x558EEF0", VA = "0x1855900F0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000013")]
public interface HFDAKPEHNOJ
{
	[Cpp2IlInjected.Token(Token = "0x17000039")]
	CollisionDetectionMode FEJFOAGMGJI
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
	void LOAKFOBCBAO();

	[Cpp2IlInjected.Token(Token = "0x60000D5")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void ONLJAMKOMCG(bool HOMNNPNFFHH);

	[Cpp2IlInjected.Token(Token = "0x60000D6")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void GIEFKHILOBN(bool HOMNNPNFFHH);

	[Cpp2IlInjected.Token(Token = "0x60000D7")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void AEBCBAGKFLD(Rigidbody EMPCHDNCBNN);

	[Cpp2IlInjected.Token(Token = "0x60000D8")]
	[Cpp2IlInjected.Address(Slot = "6")]
	bool AFMAEECEEBD(Vector3 HHGBGELADCO, out RaycastHit MFKIKGLHAMN, float EMEIKNNEGHK);
}
[Cpp2IlInjected.Token(Token = "0x2000014")]
public interface OIINLPAMLAF : IDisposable, KJGOLDGANAL
{
	[Cpp2IlInjected.Token(Token = "0x1700003A")]
	PHMDEGBGMEP MEOGMKAMEEP
	{
		[Cpp2IlInjected.Token(Token = "0x60000DB")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
		[Cpp2IlInjected.Token(Token = "0x60000DC")]
		[Cpp2IlInjected.Address(Slot = "3")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x1400000A")]
	event Action<EHKPJAMPICF, EHKPJAMPICF> JCAEOOCFBGA;

	[Cpp2IlInjected.Token(Token = "0x60000DD")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void LOAKFOBCBAO();
}
[Cpp2IlInjected.Token(Token = "0x2000015")]
[KBDLNAGCCOG(DADIFNCKKPF.Application)]
public interface JBGBBADNNKI
{
	[Cpp2IlInjected.Token(Token = "0x60000DE")]
	[Cpp2IlInjected.Address(Slot = "0")]
	HIBPGMCCMFF ODMBDIEIOMA(DDICDNFJGFA HLKJMHJNLMO);

	[Cpp2IlInjected.Token(Token = "0x60000DF")]
	[Cpp2IlInjected.Address(Slot = "1")]
	AOLDALECDIP KNCMDJEDGGK(DDICDNFJGFA HLKJMHJNLMO);

	[Cpp2IlInjected.Token(Token = "0x60000E0")]
	[Cpp2IlInjected.Address(Slot = "2")]
	GAMDKECCFOL AEHFFFLMJDA(DDICDNFJGFA HLKJMHJNLMO);

	[Cpp2IlInjected.Token(Token = "0x60000E1")]
	[Cpp2IlInjected.Address(Slot = "3")]
	CJKBMGEKBFD CJKEFKMGDFF(DDICDNFJGFA HLKJMHJNLMO);

	[Cpp2IlInjected.Token(Token = "0x60000E2")]
	[Cpp2IlInjected.Address(Slot = "4")]
	POBKPFCFBME MIMODMCOGJE(DDICDNFJGFA HLKJMHJNLMO);

	[Cpp2IlInjected.Token(Token = "0x60000E3")]
	[Cpp2IlInjected.Address(Slot = "5")]
	OIINLPAMLAF MNKKINFOOKF(DDICDNFJGFA HLKJMHJNLMO);

	[Cpp2IlInjected.Token(Token = "0x60000E4")]
	[Cpp2IlInjected.Address(Slot = "6")]
	BEAHDHOKNPM EEDOPDIIDJK(DDICDNFJGFA HLKJMHJNLMO);

	[Cpp2IlInjected.Token(Token = "0x60000E5")]
	[Cpp2IlInjected.Address(Slot = "7")]
	CFLNOOGGMLK MCAIGKKPOHN(DDICDNFJGFA HLKJMHJNLMO);

	[Cpp2IlInjected.Token(Token = "0x60000E6")]
	[Cpp2IlInjected.Address(Slot = "8")]
	HFDAKPEHNOJ KNBBHFIPCJE(DDICDNFJGFA HLKJMHJNLMO);

	[Cpp2IlInjected.Token(Token = "0x60000E7")]
	[Cpp2IlInjected.Address(Slot = "9")]
	NHHNBAGKHPP FNMGNBNMLED(DDICDNFJGFA HLKJMHJNLMO);

	[Cpp2IlInjected.Token(Token = "0x60000E8")]
	[Cpp2IlInjected.Address(Slot = "10")]
	AOJBGIGFLEC ACIELHPKKNP(DDICDNFJGFA HLKJMHJNLMO, in GPHOCGFKAIA PHAPMEHMHAK);

	[Cpp2IlInjected.Token(Token = "0x60000E9")]
	[Cpp2IlInjected.Address(Slot = "11")]
	DLGODMNJHEI LNPJJLOGHBC(DDICDNFJGFA HLKJMHJNLMO, in GPHOCGFKAIA PHAPMEHMHAK);

	[Cpp2IlInjected.Token(Token = "0x60000EA")]
	[Cpp2IlInjected.Address(Slot = "12")]
	FNGFIPOFFHP JGEPKOMAJKF(DDICDNFJGFA HLKJMHJNLMO, in GPHOCGFKAIA PHAPMEHMHAK);

	[Cpp2IlInjected.Token(Token = "0x60000EB")]
	[Cpp2IlInjected.Address(Slot = "13")]
	MLLKELEPLJE AIFAIDNENNF(DDICDNFJGFA HLKJMHJNLMO, in GPHOCGFKAIA PHAPMEHMHAK);

	[Cpp2IlInjected.Token(Token = "0x60000EC")]
	[Cpp2IlInjected.Address(Slot = "14")]
	DKCDJJILPGD DODAKANPHCJ(DDICDNFJGFA HLKJMHJNLMO, in GPHOCGFKAIA PHAPMEHMHAK);

	[Cpp2IlInjected.Token(Token = "0x60000ED")]
	[Cpp2IlInjected.Address(Slot = "15")]
	DDICDNFJGFA NJANEGHFIMH(RigidbodyEx FBJBBGAMODK, GPHOCGFKAIA PHAPMEHMHAK, BABOKGOAEJI OBAPIKNALOO);
}
[Cpp2IlInjected.Token(Token = "0x2000016")]
public interface CFLNOOGGMLK
{
	[Cpp2IlInjected.Token(Token = "0x60000EE")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void OHEOAAGAOKK(Vector3 AJKJHFCHOAK, ForceMode GMFAKLHMDNN = ForceMode.Force);

	[Cpp2IlInjected.Token(Token = "0x60000EF")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void DBDNFABFCFD(Vector3 AJKJHFCHOAK, Vector3 CBAKPHLPCPB, ForceMode GMFAKLHMDNN);

	[Cpp2IlInjected.Token(Token = "0x60000F0")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void OKEPOCHCNGP(Vector3 OJLGOOKKJEA, ForceMode GMFAKLHMDNN = ForceMode.Force);

	[Cpp2IlInjected.Token(Token = "0x60000F1")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void KIIOGIGGADP(Vector3 OJLGOOKKJEA, ForceMode GMFAKLHMDNN = ForceMode.Force);
}
[Cpp2IlInjected.Token(Token = "0x2000017")]
public interface NHHNBAGKHPP
{
	[Cpp2IlInjected.Token(Token = "0x1700003B")]
	bool AHEGBAHBLNL
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
	void AEBCBAGKFLD(Rigidbody EMPCHDNCBNN);

	[Cpp2IlInjected.Token(Token = "0x60000F5")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void IEECHEIALJL(Rigidbody EMPCHDNCBNN);
}
[Cpp2IlInjected.Token(Token = "0x2000018")]
public interface HIBPGMCCMFF : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x1700003C")]
	IReadOnlyList<DDICDNFJGFA> IAJCOJILOEF
	{
		[Cpp2IlInjected.Token(Token = "0x6000108")]
		[Cpp2IlInjected.Address(Slot = "18")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700003D")]
	DDICDNFJGFA CAHHKGJGOJO
	{
		[Cpp2IlInjected.Token(Token = "0x6000109")]
		[Cpp2IlInjected.Address(Slot = "19")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700003E")]
	DDICDNFJGFA KFPCMBOLNGI
	{
		[Cpp2IlInjected.Token(Token = "0x600010A")]
		[Cpp2IlInjected.Address(Slot = "20")]
		get;
		[Cpp2IlInjected.Token(Token = "0x600010B")]
		[Cpp2IlInjected.Address(Slot = "21")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x1400000B")]
	event IJDKLAGCEFG PBOBAMPILGB;

	[Cpp2IlInjected.Token(Token = "0x1400000C")]
	event IJDKLAGCEFG GKGJJLMHDLI;

	[Cpp2IlInjected.Token(Token = "0x1400000D")]
	event MHEGFHPPLGP NHDMDBLHBHF;

	[Cpp2IlInjected.Token(Token = "0x1400000E")]
	event Action JJAIAHJNGIG;

	[Cpp2IlInjected.Token(Token = "0x1400000F")]
	event Action IDANOOMLEFH;

	[Cpp2IlInjected.Token(Token = "0x14000010")]
	event Action<DDICDNFJGFA> INPHGDBFJHB;

	[Cpp2IlInjected.Token(Token = "0x14000011")]
	event Action<DDICDNFJGFA> CHMJFGPAGAO;

	[Cpp2IlInjected.Token(Token = "0x14000012")]
	event Action FGJJDPPMNOO;

	[Cpp2IlInjected.Token(Token = "0x14000013")]
	event Action<DDICDNFJGFA> KGIEOHODPBB;

	[Cpp2IlInjected.Token(Token = "0x600010C")]
	[Cpp2IlInjected.Address(Slot = "22")]
	void CNEDMMKBPIO(DDICDNFJGFA BANCJNAJPLD, bool BNLMFCPNEHF = false);
}
[Cpp2IlInjected.Token(Token = "0x2000019")]
public interface GAMDKECCFOL
{
	[Cpp2IlInjected.Token(Token = "0x1700003F")]
	Vector3 DBPFBEOHHOL
	{
		[Cpp2IlInjected.Token(Token = "0x600010D")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000040")]
	Vector3 DCGLBLKOGAP
	{
		[Cpp2IlInjected.Token(Token = "0x600010E")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x600010F")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void EIAOPGGEIPG(DDICDNFJGFA AABHIBJPKOH, object INDCJAMMAIN);

	[Cpp2IlInjected.Token(Token = "0x6000110")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void KKMNIALJMDA(object INDCJAMMAIN);
}
[Cpp2IlInjected.Token(Token = "0x200001A")]
public interface MLLKELEPLJE
{
	[Cpp2IlInjected.Token(Token = "0x17000041")]
	Vector3 CDOEBEFDAIG
	{
		[Cpp2IlInjected.Token(Token = "0x6000113")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
		[Cpp2IlInjected.Token(Token = "0x6000114")]
		[Cpp2IlInjected.Address(Slot = "3")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000042")]
	Vector3 HDLNEGJCDGD
	{
		[Cpp2IlInjected.Token(Token = "0x6000115")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000043")]
	float AANJNIAMGBP
	{
		[Cpp2IlInjected.Token(Token = "0x6000116")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000044")]
	float LJPJENEPPAO
	{
		[Cpp2IlInjected.Token(Token = "0x6000117")]
		[Cpp2IlInjected.Address(Slot = "6")]
		get;
		[Cpp2IlInjected.Token(Token = "0x6000118")]
		[Cpp2IlInjected.Address(Slot = "7")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000045")]
	Vector3 OLHILDGADHC
	{
		[Cpp2IlInjected.Token(Token = "0x6000119")]
		[Cpp2IlInjected.Address(Slot = "8")]
		get;
		[Cpp2IlInjected.Token(Token = "0x600011A")]
		[Cpp2IlInjected.Address(Slot = "9")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000046")]
	Quaternion FPHMFIFGALL
	{
		[Cpp2IlInjected.Token(Token = "0x600011B")]
		[Cpp2IlInjected.Address(Slot = "10")]
		get;
		[Cpp2IlInjected.Token(Token = "0x600011C")]
		[Cpp2IlInjected.Address(Slot = "11")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x14000014")]
	event IJDKLAGCEFG MFGECJGMKFM;

	[Cpp2IlInjected.Token(Token = "0x600011D")]
	[Cpp2IlInjected.Address(Slot = "12")]
	void NFCCEAJGIIH();

	[Cpp2IlInjected.Token(Token = "0x600011E")]
	[Cpp2IlInjected.Address(Slot = "13")]
	void GBIGLFOHPKF();

	[Cpp2IlInjected.Token(Token = "0x600011F")]
	[Cpp2IlInjected.Address(Slot = "14")]
	void DCKPFKGOBFJ();

	[Cpp2IlInjected.Token(Token = "0x6000120")]
	[Cpp2IlInjected.Address(Slot = "15")]
	void AEBCBAGKFLD(Rigidbody EMPCHDNCBNN);

	[Cpp2IlInjected.Token(Token = "0x6000121")]
	[Cpp2IlInjected.Address(Slot = "16")]
	void IEECHEIALJL(Rigidbody EMPCHDNCBNN);

	[Cpp2IlInjected.Token(Token = "0x6000122")]
	[Cpp2IlInjected.Address(Slot = "17")]
	void EGDEMHMFAIF();
}
[Cpp2IlInjected.Token(Token = "0x200001B")]
public interface FNGFIPOFFHP
{
	[Cpp2IlInjected.Token(Token = "0x17000047")]
	bool LLNBAIOGACO
	{
		[Cpp2IlInjected.Token(Token = "0x6000123")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000048")]
	HOMJCDNLJOD ABGIIBAPFBG
	{
		[Cpp2IlInjected.Token(Token = "0x6000124")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000125")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void LOAKFOBCBAO();

	[Cpp2IlInjected.Token(Token = "0x6000126")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void NGJAOFAIFPF(object INDCJAMMAIN);

	[Cpp2IlInjected.Token(Token = "0x6000127")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void IBBAPFLAMBM(object INDCJAMMAIN);

	[Cpp2IlInjected.Token(Token = "0x6000128")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void EBNFJGBDCKK(DDICDNFJGFA FBJBBGAMODK);

	[Cpp2IlInjected.Token(Token = "0x6000129")]
	[Cpp2IlInjected.Address(Slot = "6")]
	void FCMKCNHPIFE(DDICDNFJGFA FBJBBGAMODK);

	[Cpp2IlInjected.Token(Token = "0x600012A")]
	[Cpp2IlInjected.Address(Slot = "7")]
	void BCLJJENKLCM();
}
[Cpp2IlInjected.Token(Token = "0x200001C")]
public interface BEAHDHOKNPM
{
	[Cpp2IlInjected.Token(Token = "0x17000049")]
	bool MJPGFBJBMBL
	{
		[Cpp2IlInjected.Token(Token = "0x600012D")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700004A")]
	IEnumerable<object> OPFBLMNLHBG
	{
		[Cpp2IlInjected.Token(Token = "0x600012E")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x14000015")]
	event IJDKLAGCEFG ALPMDICHCGA;

	[Cpp2IlInjected.Token(Token = "0x600012F")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void MBDADCCBFHH(object INDCJAMMAIN);

	[Cpp2IlInjected.Token(Token = "0x6000130")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void JKKBAAMOMNK(object INDCJAMMAIN);

	[Cpp2IlInjected.Token(Token = "0x6000131")]
	[Cpp2IlInjected.Address(Slot = "6")]
	void DNFBGHHNNHM(object INDCJAMMAIN, bool NKIGKALHKKG);

	[Cpp2IlInjected.Token(Token = "0x6000132")]
	[Cpp2IlInjected.Address(Slot = "7")]
	IDisposable PAOMLEGBIMN();

	[Cpp2IlInjected.Token(Token = "0x6000133")]
	[Cpp2IlInjected.Address(Slot = "8")]
	void AEBCBAGKFLD(Rigidbody EBGNLMABMPJ);

	[Cpp2IlInjected.Token(Token = "0x6000134")]
	[Cpp2IlInjected.Address(Slot = "9")]
	void IEECHEIALJL(Rigidbody EMPCHDNCBNN);
}
[Cpp2IlInjected.Token(Token = "0x200001D")]
public interface DLGODMNJHEI : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x1700004B")]
	bool HJEPBPJAOBD
	{
		[Cpp2IlInjected.Token(Token = "0x6000137")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700004C")]
	bool BCEMFENGFMG
	{
		[Cpp2IlInjected.Token(Token = "0x6000138")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x14000016")]
	event IJDKLAGCEFG OIHJCECPHEI;

	[Cpp2IlInjected.Token(Token = "0x6000139")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void LOAKFOBCBAO();

	[Cpp2IlInjected.Token(Token = "0x600013A")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void LJCPKLHMCNP(DDICDNFJGFA AABHIBJPKOH);

	[Cpp2IlInjected.Token(Token = "0x600013B")]
	[Cpp2IlInjected.Address(Slot = "6")]
	void GNGIENKKJBL(DDICDNFJGFA AABHIBJPKOH);
}
[Cpp2IlInjected.Token(Token = "0x200001E")]
public interface DKCDJJILPGD
{
	[Cpp2IlInjected.Token(Token = "0x1700004D")]
	bool DKOAFEFPELM
	{
		[Cpp2IlInjected.Token(Token = "0x600013C")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
		[Cpp2IlInjected.Token(Token = "0x600013D")]
		[Cpp2IlInjected.Address(Slot = "1")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x1700004E")]
	bool MLGKJIBDAPE
	{
		[Cpp2IlInjected.Token(Token = "0x600013E")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700004F")]
	RigidbodyConstraints PDLJENDCEHJ
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
	void AEBCBAGKFLD(Rigidbody EMPCHDNCBNN);

	[Cpp2IlInjected.Token(Token = "0x6000142")]
	[Cpp2IlInjected.Address(Slot = "6")]
	void IEECHEIALJL(Rigidbody EMPCHDNCBNN);
}
[Cpp2IlInjected.Token(Token = "0x200001F")]
public interface CJKBMGEKBFD
{
	[Cpp2IlInjected.Token(Token = "0x17000050")]
	float EGNLMBHDOFH
	{
		[Cpp2IlInjected.Token(Token = "0x6000143")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
		[Cpp2IlInjected.Token(Token = "0x6000144")]
		[Cpp2IlInjected.Address(Slot = "1")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000051")]
	float NPBKEBDHMEK
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
	void AEBCBAGKFLD(Rigidbody EMPCHDNCBNN);

	[Cpp2IlInjected.Token(Token = "0x6000148")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void IEECHEIALJL(Rigidbody EMPCHDNCBNN);
}
[Cpp2IlInjected.Token(Token = "0x2000020")]
public interface BPGMPJLBGCP
{
	[Cpp2IlInjected.Token(Token = "0x6000149")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void OnRootRBEXChanged(RigidbodyEx FOFCFLCJLPF);
}
[Cpp2IlInjected.Token(Token = "0x2000021")]
public interface POBKPFCFBME
{
	[Cpp2IlInjected.Token(Token = "0x14000017")]
	event IJDKLAGCEFG JLFHAPOODCF;

	[Cpp2IlInjected.Token(Token = "0x600014C")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void LOAKFOBCBAO();

	[Cpp2IlInjected.Token(Token = "0x600014D")]
	[Cpp2IlInjected.Address(Slot = "3")]
	bool OMBGDMJFHEI();

	[Cpp2IlInjected.Token(Token = "0x600014E")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void GNEECPBPGHC();

	[Cpp2IlInjected.Token(Token = "0x600014F")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void MNLNBCJHPMD();

	[Cpp2IlInjected.Token(Token = "0x6000150")]
	[Cpp2IlInjected.Address(Slot = "6")]
	void GGADMLLPLHE();

	[Cpp2IlInjected.Token(Token = "0x6000151")]
	[Cpp2IlInjected.Address(Slot = "7")]
	void EDKDBDBJFEP();

	[Cpp2IlInjected.Token(Token = "0x6000152")]
	[Cpp2IlInjected.Address(Slot = "8")]
	void OKNIAACKICL(bool NOEDBDPFICH);
}
[Cpp2IlInjected.Token(Token = "0x2000022")]
public interface AOJBGIGFLEC
{
	[Cpp2IlInjected.Token(Token = "0x17000052")]
	Rigidbody AMAINOJCLLB
	{
		[Cpp2IlInjected.Token(Token = "0x6000153")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000154")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void LOAKFOBCBAO();

	[Cpp2IlInjected.Token(Token = "0x6000155")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void BGFCCCENBID(object INDCJAMMAIN);

	[Cpp2IlInjected.Token(Token = "0x6000156")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void GPBOKOEIFJD(object INDCJAMMAIN);

	[Cpp2IlInjected.Token(Token = "0x6000157")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void JKEHEGMHNBP();

	[Cpp2IlInjected.Token(Token = "0x6000158")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void FEMJINFCLKB();

	[Cpp2IlInjected.Token(Token = "0x6000159")]
	[Cpp2IlInjected.Address(Slot = "6")]
	void MDGAEMKGBPG();

	[Cpp2IlInjected.Token(Token = "0x600015A")]
	[Cpp2IlInjected.Address(Slot = "7")]
	void OCGHJADDJFG();
}
[Cpp2IlInjected.Token(Token = "0x2000023")]
public interface AOLDALECDIP : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x17000053")]
	MDNFIBKLANB NBOHDJLOFIN
	{
		[Cpp2IlInjected.Token(Token = "0x600015B")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
		[Cpp2IlInjected.Token(Token = "0x600015C")]
		[Cpp2IlInjected.Address(Slot = "1")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000054")]
	IGIPPOIEHFL KGJELLKCKGD
	{
		[Cpp2IlInjected.Token(Token = "0x600015D")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
		[Cpp2IlInjected.Token(Token = "0x600015E")]
		[Cpp2IlInjected.Address(Slot = "3")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000055")]
	Vector3 PJGMOGHAPMH
	{
		[Cpp2IlInjected.Token(Token = "0x600015F")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
		[Cpp2IlInjected.Token(Token = "0x6000160")]
		[Cpp2IlInjected.Address(Slot = "5")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000056")]
	Vector3 PLFFIHHKHOJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000161")]
		[Cpp2IlInjected.Address(Slot = "6")]
		get;
		[Cpp2IlInjected.Token(Token = "0x6000162")]
		[Cpp2IlInjected.Address(Slot = "7")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000057")]
	Vector3 BEOEJBBFCKO
	{
		[Cpp2IlInjected.Token(Token = "0x6000163")]
		[Cpp2IlInjected.Address(Slot = "8")]
		get;
		[Cpp2IlInjected.Token(Token = "0x6000164")]
		[Cpp2IlInjected.Address(Slot = "9")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000058")]
	Vector3 HNKEAHNHOFC
	{
		[Cpp2IlInjected.Token(Token = "0x6000165")]
		[Cpp2IlInjected.Address(Slot = "10")]
		get;
		[Cpp2IlInjected.Token(Token = "0x6000166")]
		[Cpp2IlInjected.Address(Slot = "11")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000059")]
	float ELIKFBMBBPJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000167")]
		[Cpp2IlInjected.Address(Slot = "12")]
		get;
		[Cpp2IlInjected.Token(Token = "0x6000168")]
		[Cpp2IlInjected.Address(Slot = "13")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x1700005A")]
	bool OGCFEGMFPMP
	{
		[Cpp2IlInjected.Token(Token = "0x6000169")]
		[Cpp2IlInjected.Address(Slot = "14")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x600016A")]
	[Cpp2IlInjected.Address(Slot = "15")]
	void LOAKFOBCBAO();

	[Cpp2IlInjected.Token(Token = "0x600016B")]
	[Cpp2IlInjected.Address(Slot = "16")]
	void EILCMEIBKHF(object INDCJAMMAIN);

	[Cpp2IlInjected.Token(Token = "0x600016C")]
	[Cpp2IlInjected.Address(Slot = "17")]
	void LDIFLICNPJP(OEBNECHHPCF GDDGFGKAHMD, Vector3 BNCCLPFNHEL, float JEMKJHNONPD = float.PositiveInfinity);

	[Cpp2IlInjected.Token(Token = "0x600016D")]
	[Cpp2IlInjected.Address(Slot = "18")]
	void DCKBJJIFEAA(GOIGKHJPKIL LKEHIILFBGJ, Vector3 CPJPNJCMJAL, float LJKLGGMAHOJ, float LHJEDBKLJNN = 8f, float PAKBBNDEEJP = 1f);

	[Cpp2IlInjected.Token(Token = "0x600016E")]
	[Cpp2IlInjected.Address(Slot = "19")]
	void MKPHELIMAAE(OEBNECHHPCF GDDGFGKAHMD, Vector3 HKMKNOBAIAN, float NIDEHIHCIBC = 7f, float DLGLDDADCFL = 1f);

	[Cpp2IlInjected.Token(Token = "0x600016F")]
	[Cpp2IlInjected.Address(Slot = "20")]
	void OGCLLIMCEGK();

	[Cpp2IlInjected.Token(Token = "0x6000170")]
	[Cpp2IlInjected.Address(Slot = "21")]
	void FIIAJOAMNGJ();

	[Cpp2IlInjected.Token(Token = "0x6000171")]
	[Cpp2IlInjected.Address(Slot = "22")]
	void FLNLDAANDPM();

	[Cpp2IlInjected.Token(Token = "0x6000172")]
	[Cpp2IlInjected.Address(Slot = "23")]
	void AGCPJAHILEP();

	[Cpp2IlInjected.Token(Token = "0x6000173")]
	[Cpp2IlInjected.Address(Slot = "24")]
	void AEBCBAGKFLD(Rigidbody EMPCHDNCBNN);

	[Cpp2IlInjected.Token(Token = "0x6000174")]
	[Cpp2IlInjected.Address(Slot = "25")]
	Vector3 EIEKMNNPHJM(Vector3 EOPDAFKMAEL);

	[Cpp2IlInjected.Token(Token = "0x6000175")]
	[Cpp2IlInjected.Address(Slot = "26")]
	Vector3 PKBLILEEDPH(Vector3 POJKCICHJIK);

	[Cpp2IlInjected.Token(Token = "0x6000176")]
	[Cpp2IlInjected.Address(Slot = "27")]
	void IKJFANGIDNB(object INDCJAMMAIN);

	[Cpp2IlInjected.Token(Token = "0x6000177")]
	[Cpp2IlInjected.Address(Slot = "28")]
	void GGCHAGHHFEC(Vector3 GKPHCGNAJHA);

	[Cpp2IlInjected.Token(Token = "0x6000178")]
	[Cpp2IlInjected.Address(Slot = "29")]
	void MODKKAHENJA(Vector3 IAOEEAAKMPP, Vector3 IDJHMKHCMIA);

	[Cpp2IlInjected.Token(Token = "0x6000179")]
	[Cpp2IlInjected.Address(Slot = "30")]
	void NFJDLDDEJMF(Vector3 IMMOLPOLNBA, Vector3 OGMHJOIPEGI);

	[Cpp2IlInjected.Token(Token = "0x600017A")]
	[Cpp2IlInjected.Address(Slot = "31")]
	Vector3 EHCFPONMFKA(Vector3 AFLGANKGICH);

	[Cpp2IlInjected.Token(Token = "0x600017B")]
	[Cpp2IlInjected.Address(Slot = "32")]
	Vector3 DKGOLPKDCPG(Vector3 LGHPPABOKOK);
}
[Cpp2IlInjected.Token(Token = "0x2000024")]
[KBDLNAGCCOG(DADIFNCKKPF.Application)]
public interface GACFLJPDFAI
{
	[Cpp2IlInjected.Token(Token = "0x1700005B")]
	bool NAICACNFOOJ
	{
		[Cpp2IlInjected.Token(Token = "0x600017C")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x600017D")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void CMPCNGBMOAM(string EDMHEICKIIC);

	[Cpp2IlInjected.Token(Token = "0x600017E")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void OFKEDHBEAMM(RigidbodyEx FBJBBGAMODK, Action KKJDJCJOLIF);

	[Cpp2IlInjected.Token(Token = "0x600017F")]
	[Cpp2IlInjected.Address(Slot = "3")]
	FOGLMEFJINH DGDNJLPPONM(int PEGIOGJIPPE);

	[Cpp2IlInjected.Token(Token = "0x6000180")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void GBPLONJCMHJ(Vector3 AIFFLDMOIAE, float IOGBPIFKCNJ, Color HCHGJCCJIHO);
}
[Cpp2IlInjected.Token(Token = "0x2000025")]
[KBDLNAGCCOG(DADIFNCKKPF.Application)]
public interface BABOKGOAEJI
{
	[Cpp2IlInjected.Token(Token = "0x1700005C")]
	GACFLJPDFAI GGGDIHGAIAP
	{
		[Cpp2IlInjected.Token(Token = "0x6000181")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700005D")]
	JBGBBADNNKI BLFNNEFBJJD
	{
		[Cpp2IlInjected.Token(Token = "0x6000182")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700005E")]
	bool CICAHOKMKJJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000183")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000184")]
	[Cpp2IlInjected.Address(Slot = "3")]
	IMKMJFJEHIJ HIAJIEALNAN(RigidbodyEx FBJBBGAMODK);

	[Cpp2IlInjected.Token(Token = "0x6000185")]
	[Cpp2IlInjected.Address(Slot = "4")]
	DDICDNFJGFA NJANEGHFIMH(RigidbodyEx FBJBBGAMODK, GPHOCGFKAIA PHAPMEHMHAK);

	[Cpp2IlInjected.Token(Token = "0x6000186")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void OBOFDEKFGBD();

	[Cpp2IlInjected.Token(Token = "0x6000187")]
	[Cpp2IlInjected.Address(Slot = "6")]
	void ILHBJMBCFCB();

	[Cpp2IlInjected.Token(Token = "0x6000188")]
	[Cpp2IlInjected.Address(Slot = "7")]
	internal RigidbodyEx NIFJKOEJHCB(GameObject BEPEHBCCEGM, [Optional] GPHOCGFKAIA PHAPMEHMHAK);
}
[Cpp2IlInjected.Token(Token = "0x2000026")]
public interface IGIPPOIEHFL
{
	[Cpp2IlInjected.Token(Token = "0x6000189")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void PMHBLNJOCME(Vector3 DCOOGOJLEHP);

	[Cpp2IlInjected.Token(Token = "0x600018A")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void POKIOJNPKHO(Vector3 EOPDAFKMAEL);

	[Cpp2IlInjected.Token(Token = "0x600018B")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void EDGNINFIBLO(Vector3 DCOOGOJLEHP);

	[Cpp2IlInjected.Token(Token = "0x600018C")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void KIHKBCLADDM(Vector3 EOPDAFKMAEL);
}
[Cpp2IlInjected.Token(Token = "0x2000027")]
public interface MDNFIBKLANB : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x600018D")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Vector3 FEJFNFBJKGG();

	[Cpp2IlInjected.Token(Token = "0x600018E")]
	[Cpp2IlInjected.Address(Slot = "1")]
	Vector3 JMOPBFHFCID();
}
[Cpp2IlInjected.Token(Token = "0x2000028")]
public interface DDICDNFJGFA : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x1700005F")]
	Rigidbody AMAINOJCLLB
	{
		[Cpp2IlInjected.Token(Token = "0x600018F")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000060")]
	RigidbodyEx DEPNLHOILPJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000190")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000061")]
	GameObject MOOKKKOOHPD
	{
		[Cpp2IlInjected.Token(Token = "0x6000191")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000062")]
	Transform OBACKBELLEI
	{
		[Cpp2IlInjected.Token(Token = "0x6000192")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000063")]
	IEnumerable<object> DBMMLAPEJMC
	{
		[Cpp2IlInjected.Token(Token = "0x6000193")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000064")]
	DDICDNFJGFA KFPCMBOLNGI
	{
		[Cpp2IlInjected.Token(Token = "0x6000194")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
		[Cpp2IlInjected.Token(Token = "0x6000195")]
		[Cpp2IlInjected.Address(Slot = "6")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000065")]
	IReadOnlyList<DDICDNFJGFA> IAJCOJILOEF
	{
		[Cpp2IlInjected.Token(Token = "0x6000196")]
		[Cpp2IlInjected.Address(Slot = "7")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000066")]
	DDICDNFJGFA CAHHKGJGOJO
	{
		[Cpp2IlInjected.Token(Token = "0x6000197")]
		[Cpp2IlInjected.Address(Slot = "8")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000067")]
	bool FGHFGPDIBIE
	{
		[Cpp2IlInjected.Token(Token = "0x6000198")]
		[Cpp2IlInjected.Address(Slot = "9")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000068")]
	bool HJEPBPJAOBD
	{
		[Cpp2IlInjected.Token(Token = "0x6000199")]
		[Cpp2IlInjected.Address(Slot = "10")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000069")]
	bool BCEMFENGFMG
	{
		[Cpp2IlInjected.Token(Token = "0x600019A")]
		[Cpp2IlInjected.Address(Slot = "11")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700006A")]
	MDNFIBKLANB NBOHDJLOFIN
	{
		[Cpp2IlInjected.Token(Token = "0x600019B")]
		[Cpp2IlInjected.Address(Slot = "12")]
		get;
		[Cpp2IlInjected.Token(Token = "0x600019C")]
		[Cpp2IlInjected.Address(Slot = "13")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x1700006B")]
	IGIPPOIEHFL KGJELLKCKGD
	{
		[Cpp2IlInjected.Token(Token = "0x600019D")]
		[Cpp2IlInjected.Address(Slot = "14")]
		get;
		[Cpp2IlInjected.Token(Token = "0x600019E")]
		[Cpp2IlInjected.Address(Slot = "15")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x1700006C")]
	float ELIKFBMBBPJ
	{
		[Cpp2IlInjected.Token(Token = "0x600019F")]
		[Cpp2IlInjected.Address(Slot = "16")]
		get;
		[Cpp2IlInjected.Token(Token = "0x60001A0")]
		[Cpp2IlInjected.Address(Slot = "17")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x1700006D")]
	Vector3 PLFFIHHKHOJ
	{
		[Cpp2IlInjected.Token(Token = "0x60001A1")]
		[Cpp2IlInjected.Address(Slot = "18")]
		get;
		[Cpp2IlInjected.Token(Token = "0x60001A2")]
		[Cpp2IlInjected.Address(Slot = "19")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x1700006E")]
	Vector3 HNKEAHNHOFC
	{
		[Cpp2IlInjected.Token(Token = "0x60001A3")]
		[Cpp2IlInjected.Address(Slot = "20")]
		get;
		[Cpp2IlInjected.Token(Token = "0x60001A4")]
		[Cpp2IlInjected.Address(Slot = "21")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x1700006F")]
	Vector3 PJGMOGHAPMH
	{
		[Cpp2IlInjected.Token(Token = "0x60001A5")]
		[Cpp2IlInjected.Address(Slot = "22")]
		get;
		[Cpp2IlInjected.Token(Token = "0x60001A6")]
		[Cpp2IlInjected.Address(Slot = "23")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000070")]
	Vector3 BEOEJBBFCKO
	{
		[Cpp2IlInjected.Token(Token = "0x60001A7")]
		[Cpp2IlInjected.Address(Slot = "24")]
		get;
		[Cpp2IlInjected.Token(Token = "0x60001A8")]
		[Cpp2IlInjected.Address(Slot = "25")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000071")]
	bool BHJMJPEEHFL
	{
		[Cpp2IlInjected.Token(Token = "0x60001A9")]
		[Cpp2IlInjected.Address(Slot = "26")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000072")]
	bool DCDPHNJFFFB
	{
		[Cpp2IlInjected.Token(Token = "0x60001AA")]
		[Cpp2IlInjected.Address(Slot = "27")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000073")]
	bool OKEBAKFHKOE
	{
		[Cpp2IlInjected.Token(Token = "0x60001AB")]
		[Cpp2IlInjected.Address(Slot = "28")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000074")]
	bool OGCFEGMFPMP
	{
		[Cpp2IlInjected.Token(Token = "0x60001AC")]
		[Cpp2IlInjected.Address(Slot = "29")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000075")]
	Vector3 DBPFBEOHHOL
	{
		[Cpp2IlInjected.Token(Token = "0x60001AD")]
		[Cpp2IlInjected.Address(Slot = "30")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000076")]
	Vector3 DCGLBLKOGAP
	{
		[Cpp2IlInjected.Token(Token = "0x60001AE")]
		[Cpp2IlInjected.Address(Slot = "31")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000077")]
	Vector3 CDOEBEFDAIG
	{
		[Cpp2IlInjected.Token(Token = "0x60001AF")]
		[Cpp2IlInjected.Address(Slot = "32")]
		get;
		[Cpp2IlInjected.Token(Token = "0x60001B0")]
		[Cpp2IlInjected.Address(Slot = "33")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000078")]
	Vector3 HDLNEGJCDGD
	{
		[Cpp2IlInjected.Token(Token = "0x60001B1")]
		[Cpp2IlInjected.Address(Slot = "34")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000079")]
	float AANJNIAMGBP
	{
		[Cpp2IlInjected.Token(Token = "0x60001B2")]
		[Cpp2IlInjected.Address(Slot = "35")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700007A")]
	float LJPJENEPPAO
	{
		[Cpp2IlInjected.Token(Token = "0x60001B3")]
		[Cpp2IlInjected.Address(Slot = "36")]
		get;
		[Cpp2IlInjected.Token(Token = "0x60001B4")]
		[Cpp2IlInjected.Address(Slot = "37")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x1700007B")]
	Vector3 OLHILDGADHC
	{
		[Cpp2IlInjected.Token(Token = "0x60001B5")]
		[Cpp2IlInjected.Address(Slot = "38")]
		get;
		[Cpp2IlInjected.Token(Token = "0x60001B6")]
		[Cpp2IlInjected.Address(Slot = "39")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x1700007C")]
	Quaternion FPHMFIFGALL
	{
		[Cpp2IlInjected.Token(Token = "0x60001B7")]
		[Cpp2IlInjected.Address(Slot = "40")]
		get;
		[Cpp2IlInjected.Token(Token = "0x60001B8")]
		[Cpp2IlInjected.Address(Slot = "41")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x1700007D")]
	float EGNLMBHDOFH
	{
		[Cpp2IlInjected.Token(Token = "0x60001B9")]
		[Cpp2IlInjected.Address(Slot = "42")]
		get;
		[Cpp2IlInjected.Token(Token = "0x60001BA")]
		[Cpp2IlInjected.Address(Slot = "43")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x1700007E")]
	float NPBKEBDHMEK
	{
		[Cpp2IlInjected.Token(Token = "0x60001BB")]
		[Cpp2IlInjected.Address(Slot = "44")]
		get;
		[Cpp2IlInjected.Token(Token = "0x60001BC")]
		[Cpp2IlInjected.Address(Slot = "45")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x1700007F")]
	bool AHEGBAHBLNL
	{
		[Cpp2IlInjected.Token(Token = "0x60001BD")]
		[Cpp2IlInjected.Address(Slot = "46")]
		get;
		[Cpp2IlInjected.Token(Token = "0x60001BE")]
		[Cpp2IlInjected.Address(Slot = "47")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000080")]
	PHMDEGBGMEP MEOGMKAMEEP
	{
		[Cpp2IlInjected.Token(Token = "0x60001BF")]
		[Cpp2IlInjected.Address(Slot = "48")]
		get;
		[Cpp2IlInjected.Token(Token = "0x60001C0")]
		[Cpp2IlInjected.Address(Slot = "49")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000081")]
	bool MJPGFBJBMBL
	{
		[Cpp2IlInjected.Token(Token = "0x60001C1")]
		[Cpp2IlInjected.Address(Slot = "50")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000082")]
	Transform FJKALEOIOIL
	{
		[Cpp2IlInjected.Token(Token = "0x60001C2")]
		[Cpp2IlInjected.Address(Slot = "51")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000083")]
	Transform FENNCJKPIPO
	{
		[Cpp2IlInjected.Token(Token = "0x60001C3")]
		[Cpp2IlInjected.Address(Slot = "52")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000084")]
	Vector3 OCAKMFDJIOJ
	{
		[Cpp2IlInjected.Token(Token = "0x60001C4")]
		[Cpp2IlInjected.Address(Slot = "53")]
		get;
		[Cpp2IlInjected.Token(Token = "0x60001C5")]
		[Cpp2IlInjected.Address(Slot = "54")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000085")]
	float GEIBAJEKMBO
	{
		[Cpp2IlInjected.Token(Token = "0x60001C6")]
		[Cpp2IlInjected.Address(Slot = "55")]
		get;
		[Cpp2IlInjected.Token(Token = "0x60001C7")]
		[Cpp2IlInjected.Address(Slot = "56")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000086")]
	float MOKNEJJCJKK
	{
		[Cpp2IlInjected.Token(Token = "0x60001C8")]
		[Cpp2IlInjected.Address(Slot = "57")]
		get;
		[Cpp2IlInjected.Token(Token = "0x60001C9")]
		[Cpp2IlInjected.Address(Slot = "58")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000087")]
	Quaternion PCGLOPJPLLA
	{
		[Cpp2IlInjected.Token(Token = "0x60001CA")]
		[Cpp2IlInjected.Address(Slot = "59")]
		get;
		[Cpp2IlInjected.Token(Token = "0x60001CB")]
		[Cpp2IlInjected.Address(Slot = "60")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000088")]
	Vector3 OGAPOCAACEE
	{
		[Cpp2IlInjected.Token(Token = "0x60001CC")]
		[Cpp2IlInjected.Address(Slot = "61")]
		get;
		[Cpp2IlInjected.Token(Token = "0x60001CD")]
		[Cpp2IlInjected.Address(Slot = "62")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000089")]
	Quaternion DHDNKCLJBGN
	{
		[Cpp2IlInjected.Token(Token = "0x60001CE")]
		[Cpp2IlInjected.Address(Slot = "63")]
		get;
		[Cpp2IlInjected.Token(Token = "0x60001CF")]
		[Cpp2IlInjected.Address(Slot = "64")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x1700008A")]
	RigidbodyConstraints PDLJENDCEHJ
	{
		[Cpp2IlInjected.Token(Token = "0x60001D0")]
		[Cpp2IlInjected.Address(Slot = "65")]
		get;
		[Cpp2IlInjected.Token(Token = "0x60001D1")]
		[Cpp2IlInjected.Address(Slot = "66")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x1700008B")]
	bool DKOAFEFPELM
	{
		[Cpp2IlInjected.Token(Token = "0x60001D2")]
		[Cpp2IlInjected.Address(Slot = "67")]
		get;
		[Cpp2IlInjected.Token(Token = "0x60001D3")]
		[Cpp2IlInjected.Address(Slot = "68")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x1700008C")]
	CollisionDetectionMode FEJFOAGMGJI
	{
		[Cpp2IlInjected.Token(Token = "0x60001D4")]
		[Cpp2IlInjected.Address(Slot = "69")]
		get;
		[Cpp2IlInjected.Token(Token = "0x60001D5")]
		[Cpp2IlInjected.Address(Slot = "70")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x1700008D")]
	bool BIBDGFIAGJM
	{
		[Cpp2IlInjected.Token(Token = "0x60001D6")]
		[Cpp2IlInjected.Address(Slot = "71")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x14000018")]
	event IJDKLAGCEFG PBOBAMPILGB;

	[Cpp2IlInjected.Token(Token = "0x14000019")]
	event IJDKLAGCEFG GKGJJLMHDLI;

	[Cpp2IlInjected.Token(Token = "0x1400001A")]
	event MHEGFHPPLGP NHDMDBLHBHF;

	[Cpp2IlInjected.Token(Token = "0x1400001B")]
	event IJDKLAGCEFG OIHJCECPHEI;

	[Cpp2IlInjected.Token(Token = "0x1400001C")]
	event IJDKLAGCEFG NAHKAOPHPKB;

	[Cpp2IlInjected.Token(Token = "0x1400001D")]
	event IJDKLAGCEFG JLFHAPOODCF;

	[Cpp2IlInjected.Token(Token = "0x1400001E")]
	event Action<EHKPJAMPICF, EHKPJAMPICF> JCAEOOCFBGA;

	[Cpp2IlInjected.Token(Token = "0x1400001F")]
	event IJDKLAGCEFG LMBBIPHIOEK;

	[Cpp2IlInjected.Token(Token = "0x14000020")]
	event IJDKLAGCEFG HMNHPLAABPL;

	[Cpp2IlInjected.Token(Token = "0x60001D7")]
	[Cpp2IlInjected.Address(Slot = "72")]
	void LOAKFOBCBAO();

	[Cpp2IlInjected.Token(Token = "0x60001D8")]
	[Cpp2IlInjected.Address(Slot = "73")]
	void IGDJODCGKJE();

	[Cpp2IlInjected.Token(Token = "0x60001D9")]
	[Cpp2IlInjected.Address(Slot = "74")]
	void BBLEBJJHLNM();

	[Cpp2IlInjected.Token(Token = "0x60001DA")]
	[Cpp2IlInjected.Address(Slot = "75")]
	void MNLNBCJHPMD();

	[Cpp2IlInjected.Token(Token = "0x60001DB")]
	[Cpp2IlInjected.Address(Slot = "76")]
	void GMONNENGCBC();

	[Cpp2IlInjected.Token(Token = "0x60001E2")]
	[Cpp2IlInjected.Address(Slot = "83")]
	void CNEDMMKBPIO(DDICDNFJGFA NLHFEJHKLAH, bool BNLMFCPNEHF = false);

	[Cpp2IlInjected.Token(Token = "0x60001E5")]
	[Cpp2IlInjected.Address(Slot = "86")]
	void FKHILLLDBNL(object INDCJAMMAIN);

	[Cpp2IlInjected.Token(Token = "0x60001E6")]
	[Cpp2IlInjected.Address(Slot = "87")]
	void HICAJKMKHKJ(object INDCJAMMAIN);

	[Cpp2IlInjected.Token(Token = "0x60001E7")]
	[Cpp2IlInjected.Address(Slot = "88")]
	Vector3 DKGOLPKDCPG(Vector3 LGHPPABOKOK);

	[Cpp2IlInjected.Token(Token = "0x60001E8")]
	[Cpp2IlInjected.Address(Slot = "89")]
	Vector3 EHCFPONMFKA(Vector3 AFLGANKGICH);

	[Cpp2IlInjected.Token(Token = "0x60001E9")]
	[Cpp2IlInjected.Address(Slot = "90")]
	void AGCPJAHILEP();

	[Cpp2IlInjected.Token(Token = "0x60001EA")]
	[Cpp2IlInjected.Address(Slot = "91")]
	void FIIAJOAMNGJ();

	[Cpp2IlInjected.Token(Token = "0x60001EB")]
	[Cpp2IlInjected.Address(Slot = "92")]
	void OGCLLIMCEGK();

	[Cpp2IlInjected.Token(Token = "0x60001EC")]
	[Cpp2IlInjected.Address(Slot = "93")]
	void NFJDLDDEJMF(Vector3 IMMOLPOLNBA, Vector3 OGMHJOIPEGI);

	[Cpp2IlInjected.Token(Token = "0x60001ED")]
	[Cpp2IlInjected.Address(Slot = "94")]
	void MODKKAHENJA(Vector3 IAOEEAAKMPP, Vector3 IDJHMKHCMIA);

	[Cpp2IlInjected.Token(Token = "0x60001EE")]
	[Cpp2IlInjected.Address(Slot = "95")]
	void GGCHAGHHFEC(Vector3 GKPHCGNAJHA);

	[Cpp2IlInjected.Token(Token = "0x60001EF")]
	[Cpp2IlInjected.Address(Slot = "96")]
	void DCKBJJIFEAA(GOIGKHJPKIL LKEHIILFBGJ, Vector3 CPJPNJCMJAL, float LJKLGGMAHOJ, float LHJEDBKLJNN = 8f, float PAKBBNDEEJP = 1f);

	[Cpp2IlInjected.Token(Token = "0x60001F0")]
	[Cpp2IlInjected.Address(Slot = "97")]
	void LDIFLICNPJP(OEBNECHHPCF GDDGFGKAHMD, Vector3 BNCCLPFNHEL, float JEMKJHNONPD = float.PositiveInfinity);

	[Cpp2IlInjected.Token(Token = "0x60001F1")]
	[Cpp2IlInjected.Address(Slot = "98")]
	void MKPHELIMAAE(OEBNECHHPCF GDDGFGKAHMD, Vector3 HKMKNOBAIAN, float NIDEHIHCIBC = 7f, float DLGLDDADCFL = 1f);

	[Cpp2IlInjected.Token(Token = "0x60001F2")]
	[Cpp2IlInjected.Address(Slot = "99")]
	Vector3 PKBLILEEDPH(Vector3 NLHFEJHKLAH);

	[Cpp2IlInjected.Token(Token = "0x60001F3")]
	[Cpp2IlInjected.Address(Slot = "100")]
	Vector3 EIEKMNNPHJM(Vector3 NLHFEJHKLAH);

	[Cpp2IlInjected.Token(Token = "0x60001F4")]
	[Cpp2IlInjected.Address(Slot = "101")]
	void FLNLDAANDPM();

	[Cpp2IlInjected.Token(Token = "0x60001F5")]
	[Cpp2IlInjected.Address(Slot = "102")]
	void EMNIPIHNALC(DDICDNFJGFA JCBNEMEEHFF, object INDCJAMMAIN);

	[Cpp2IlInjected.Token(Token = "0x60001F6")]
	[Cpp2IlInjected.Address(Slot = "103")]
	void FEHAHPDNHDG(object INDCJAMMAIN);

	[Cpp2IlInjected.Token(Token = "0x60001F9")]
	[Cpp2IlInjected.Address(Slot = "106")]
	void GBIGLFOHPKF();

	[Cpp2IlInjected.Token(Token = "0x60001FA")]
	[Cpp2IlInjected.Address(Slot = "107")]
	void NFCCEAJGIIH();

	[Cpp2IlInjected.Token(Token = "0x60001FB")]
	[Cpp2IlInjected.Address(Slot = "108")]
	void DCKPFKGOBFJ();

	[Cpp2IlInjected.Token(Token = "0x60001FE")]
	[Cpp2IlInjected.Address(Slot = "111")]
	bool OMBGDMJFHEI();

	[Cpp2IlInjected.Token(Token = "0x60001FF")]
	[Cpp2IlInjected.Address(Slot = "112")]
	void EDKDBDBJFEP();

	[Cpp2IlInjected.Token(Token = "0x6000204")]
	[Cpp2IlInjected.Address(Slot = "117")]
	IDisposable PAOMLEGBIMN();

	[Cpp2IlInjected.Token(Token = "0x6000205")]
	[Cpp2IlInjected.Address(Slot = "118")]
	void MBDADCCBFHH(object INDCJAMMAIN);

	[Cpp2IlInjected.Token(Token = "0x6000206")]
	[Cpp2IlInjected.Address(Slot = "119")]
	void JKKBAAMOMNK(object INDCJAMMAIN);

	[Cpp2IlInjected.Token(Token = "0x6000207")]
	[Cpp2IlInjected.Address(Slot = "120")]
	void DNFBGHHNNHM(object INDCJAMMAIN, bool NKIGKALHKKG);

	[Cpp2IlInjected.Token(Token = "0x600020A")]
	[Cpp2IlInjected.Address(Slot = "123")]
	void AACJLACMIEO(Vector3 KPJPKNEEHFJ, Quaternion FFPDKCAEKDA);

	[Cpp2IlInjected.Token(Token = "0x600020B")]
	[Cpp2IlInjected.Address(Slot = "124")]
	void JNOALKFAIEH(Vector3 APJBCHKNCHD, Quaternion LIMMBJPINMP);

	[Cpp2IlInjected.Token(Token = "0x600020C")]
	[Cpp2IlInjected.Address(Slot = "125")]
	bool BLMMBEJIFIE(float MHHMHIKNPME);

	[Cpp2IlInjected.Token(Token = "0x600020D")]
	[Cpp2IlInjected.Address(Slot = "126")]
	void GEKJMPIKEBI(object INDCJAMMAIN);

	[Cpp2IlInjected.Token(Token = "0x600020E")]
	[Cpp2IlInjected.Address(Slot = "127")]
	void PBODBJKKJIG(object INDCJAMMAIN);

	[Cpp2IlInjected.Token(Token = "0x600020F")]
	[Cpp2IlInjected.Address(Slot = "128")]
	void BGFCCCENBID(object INDCJAMMAIN);

	[Cpp2IlInjected.Token(Token = "0x6000210")]
	[Cpp2IlInjected.Address(Slot = "129")]
	void GPBOKOEIFJD(object INDCJAMMAIN);

	[Cpp2IlInjected.Token(Token = "0x6000211")]
	[Cpp2IlInjected.Address(Slot = "130")]
	void OHEOAAGAOKK(Vector3 AJKJHFCHOAK, ForceMode GMFAKLHMDNN = ForceMode.Force);

	[Cpp2IlInjected.Token(Token = "0x6000212")]
	[Cpp2IlInjected.Address(Slot = "131")]
	void DBDNFABFCFD(Vector3 AJKJHFCHOAK, Vector3 CBAKPHLPCPB, ForceMode GMFAKLHMDNN);

	[Cpp2IlInjected.Token(Token = "0x6000213")]
	[Cpp2IlInjected.Address(Slot = "132")]
	void OKEPOCHCNGP(Vector3 OJLGOOKKJEA, ForceMode GMFAKLHMDNN = ForceMode.Force);

	[Cpp2IlInjected.Token(Token = "0x6000214")]
	[Cpp2IlInjected.Address(Slot = "133")]
	void KIIOGIGGADP(Vector3 OJLGOOKKJEA, ForceMode GMFAKLHMDNN = ForceMode.Force);

	[Cpp2IlInjected.Token(Token = "0x6000215")]
	[Cpp2IlInjected.Address(Slot = "134")]
	bool AFMAEECEEBD(Vector3 HHGBGELADCO, out RaycastHit MFKIKGLHAMN, float EMEIKNNEGHK);

	[Cpp2IlInjected.Token(Token = "0x6000216")]
	[Cpp2IlInjected.Address(Slot = "135")]
	void EGDEMHMFAIF();

	[Cpp2IlInjected.Token(Token = "0x6000217")]
	[Cpp2IlInjected.Address(Slot = "136")]
	new string ToString();
}
[Cpp2IlInjected.Token(Token = "0x2000029")]
public class LGAGFCAGMMC : DDICDNFJGFA, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000031")]
	internal readonly BABOKGOAEJI OBAPIKNALOO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000032")]
	internal HIBPGMCCMFF DNJLLPNDOBN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000033")]
	internal FNGFIPOFFHP HOEKIKGBJII;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000034")]
	internal DLGODMNJHEI OLBEJFPALDA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000035")]
	internal AOLDALECDIP POJKCICHJIK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000036")]
	internal GAMDKECCFOL LCPAEIHBHHD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000037")]
	internal MLLKELEPLJE MGGLGIEBMEE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000038")]
	internal CJKBMGEKBFD KAGDHMJJLIF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000039")]
	internal NHHNBAGKHPP CPPPKCIBDKP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x400003A")]
	internal POBKPFCFBME PMIKAJOOPEP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x400003B")]
	internal OIINLPAMLAF BFMBGAKFFNL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x400003C")]
	internal BEAHDHOKNPM MIEMDALBOOA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x400003D")]
	internal CFLNOOGGMLK AJKJHFCHOAK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
	[Cpp2IlInjected.Token(Token = "0x400003E")]
	internal DKCDJJILPGD MJEBBJKOCPG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x400003F")]
	internal AOJBGIGFLEC EMPCHDNCBNN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
	[Cpp2IlInjected.Token(Token = "0x4000040")]
	internal HFDAKPEHNOJ PMAJNHIJECC;

	[Cpp2IlInjected.Token(Token = "0x1700008E")]
	public RigidbodyEx DEPNLHOILPJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000218")]
		[Cpp2IlInjected.Address(RVA = "0x771980", Offset = "0x770780", VA = "0x180771980", Slot = "5")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000219")]
		[Cpp2IlInjected.Address(RVA = "0x82B6F0", Offset = "0x82A4F0", VA = "0x18082B6F0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700008F")]
	public GameObject MOOKKKOOHPD
	{
		[Cpp2IlInjected.Token(Token = "0x600021A")]
		[Cpp2IlInjected.Address(RVA = "0x70D1B0", Offset = "0x70BFB0", VA = "0x18070D1B0", Slot = "6")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600021B")]
		[Cpp2IlInjected.Address(RVA = "0x70D270", Offset = "0x70C070", VA = "0x18070D270")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000090")]
	public Transform OBACKBELLEI
	{
		[Cpp2IlInjected.Token(Token = "0x600021C")]
		[Cpp2IlInjected.Address(RVA = "0x55A2E70", Offset = "0x55A1C70", VA = "0x1855A2E70", Slot = "7")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000091")]
	public IEnumerable<object> DBMMLAPEJMC
	{
		[Cpp2IlInjected.Token(Token = "0x600021D")]
		[Cpp2IlInjected.Address(RVA = "0x55A0BD0", Offset = "0x559F9D0", VA = "0x1855A0BD0", Slot = "8")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000092")]
	public Rigidbody AMAINOJCLLB
	{
		[Cpp2IlInjected.Token(Token = "0x600021E")]
		[Cpp2IlInjected.Address(RVA = "0x55A58A0", Offset = "0x55A46A0", VA = "0x1855A58A0", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000093")]
	public DDICDNFJGFA KFPCMBOLNGI
	{
		[Cpp2IlInjected.Token(Token = "0x600022C")]
		[Cpp2IlInjected.Address(RVA = "0x55A3ED0", Offset = "0x55A2CD0", VA = "0x1855A3ED0", Slot = "9")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600022D")]
		[Cpp2IlInjected.Address(RVA = "0x55A1520", Offset = "0x55A0320", VA = "0x1855A1520", Slot = "10")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000094")]
	public IReadOnlyList<DDICDNFJGFA> IAJCOJILOEF
	{
		[Cpp2IlInjected.Token(Token = "0x600022E")]
		[Cpp2IlInjected.Address(RVA = "0x55A5340", Offset = "0x55A4140", VA = "0x1855A5340", Slot = "11")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000095")]
	public DDICDNFJGFA CAHHKGJGOJO
	{
		[Cpp2IlInjected.Token(Token = "0x600022F")]
		[Cpp2IlInjected.Address(RVA = "0x55A3F20", Offset = "0x55A2D20", VA = "0x1855A3F20", Slot = "12")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000096")]
	public bool FGHFGPDIBIE
	{
		[Cpp2IlInjected.Token(Token = "0x6000230")]
		[Cpp2IlInjected.Address(RVA = "0x55A3D20", Offset = "0x55A2B20", VA = "0x1855A3D20", Slot = "13")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000097")]
	public bool HJEPBPJAOBD
	{
		[Cpp2IlInjected.Token(Token = "0x6000234")]
		[Cpp2IlInjected.Address(RVA = "0x55A3770", Offset = "0x55A2570", VA = "0x1855A3770", Slot = "14")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000098")]
	public bool BCEMFENGFMG
	{
		[Cpp2IlInjected.Token(Token = "0x6000235")]
		[Cpp2IlInjected.Address(RVA = "0x55A5510", Offset = "0x55A4310", VA = "0x1855A5510", Slot = "15")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000099")]
	public MDNFIBKLANB NBOHDJLOFIN
	{
		[Cpp2IlInjected.Token(Token = "0x6000236")]
		[Cpp2IlInjected.Address(RVA = "0x55A4060", Offset = "0x55A2E60", VA = "0x1855A4060", Slot = "16")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000237")]
		[Cpp2IlInjected.Address(RVA = "0x55A2C90", Offset = "0x55A1A90", VA = "0x1855A2C90", Slot = "17")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700009A")]
	public IGIPPOIEHFL KGJELLKCKGD
	{
		[Cpp2IlInjected.Token(Token = "0x6000238")]
		[Cpp2IlInjected.Address(RVA = "0x55A5460", Offset = "0x55A4260", VA = "0x1855A5460", Slot = "18")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000239")]
		[Cpp2IlInjected.Address(RVA = "0x55A4B50", Offset = "0x55A3950", VA = "0x1855A4B50", Slot = "19")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700009B")]
	public float ELIKFBMBBPJ
	{
		[Cpp2IlInjected.Token(Token = "0x600023A")]
		[Cpp2IlInjected.Address(RVA = "0x55A6450", Offset = "0x55A5250", VA = "0x1855A6450", Slot = "20")]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x600023B")]
		[Cpp2IlInjected.Address(RVA = "0x55A2760", Offset = "0x55A1560", VA = "0x1855A2760", Slot = "21")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700009C")]
	public Vector3 PLFFIHHKHOJ
	{
		[Cpp2IlInjected.Token(Token = "0x600023C")]
		[Cpp2IlInjected.Address(RVA = "0x55A50D0", Offset = "0x55A3ED0", VA = "0x1855A50D0", Slot = "22")]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x600023D")]
		[Cpp2IlInjected.Address(RVA = "0x55A1450", Offset = "0x55A0250", VA = "0x1855A1450", Slot = "23")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700009D")]
	public Vector3 HNKEAHNHOFC
	{
		[Cpp2IlInjected.Token(Token = "0x600023E")]
		[Cpp2IlInjected.Address(RVA = "0x55A5D60", Offset = "0x55A4B60", VA = "0x1855A5D60", Slot = "24")]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x600023F")]
		[Cpp2IlInjected.Address(RVA = "0x55A5390", Offset = "0x55A4190", VA = "0x1855A5390", Slot = "25")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700009E")]
	public Vector3 PJGMOGHAPMH
	{
		[Cpp2IlInjected.Token(Token = "0x6000240")]
		[Cpp2IlInjected.Address(RVA = "0x55A5F60", Offset = "0x55A4D60", VA = "0x1855A5F60", Slot = "26")]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x6000241")]
		[Cpp2IlInjected.Address(RVA = "0x55A4FB0", Offset = "0x55A3DB0", VA = "0x1855A4FB0", Slot = "27")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700009F")]
	public Vector3 BEOEJBBFCKO
	{
		[Cpp2IlInjected.Token(Token = "0x6000242")]
		[Cpp2IlInjected.Address(RVA = "0x55A2A20", Offset = "0x55A1820", VA = "0x1855A2A20", Slot = "28")]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x6000243")]
		[Cpp2IlInjected.Address(RVA = "0x55A6380", Offset = "0x55A5180", VA = "0x1855A6380", Slot = "29")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A0")]
	public bool BHJMJPEEHFL
	{
		[Cpp2IlInjected.Token(Token = "0x6000244")]
		[Cpp2IlInjected.Address(RVA = "0x55A2CF0", Offset = "0x55A1AF0", VA = "0x1855A2CF0", Slot = "30")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A1")]
	public bool DCDPHNJFFFB
	{
		[Cpp2IlInjected.Token(Token = "0x6000245")]
		[Cpp2IlInjected.Address(RVA = "0x55A5D00", Offset = "0x55A4B00", VA = "0x1855A5D00", Slot = "31")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A2")]
	public bool OKEBAKFHKOE
	{
		[Cpp2IlInjected.Token(Token = "0x6000246")]
		[Cpp2IlInjected.Address(RVA = "0x55A5E30", Offset = "0x55A4C30", VA = "0x1855A5E30", Slot = "32")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A3")]
	public bool OGCFEGMFPMP
	{
		[Cpp2IlInjected.Token(Token = "0x6000247")]
		[Cpp2IlInjected.Address(RVA = "0x55A0C20", Offset = "0x559FA20", VA = "0x1855A0C20", Slot = "33")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A4")]
	public Vector3 DBPFBEOHHOL
	{
		[Cpp2IlInjected.Token(Token = "0x6000258")]
		[Cpp2IlInjected.Address(RVA = "0x55A0890", Offset = "0x559F690", VA = "0x1855A0890", Slot = "34")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A5")]
	public Vector3 DCGLBLKOGAP
	{
		[Cpp2IlInjected.Token(Token = "0x6000259")]
		[Cpp2IlInjected.Address(RVA = "0x55A2D40", Offset = "0x55A1B40", VA = "0x1855A2D40", Slot = "35")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A6")]
	public Vector3 CDOEBEFDAIG
	{
		[Cpp2IlInjected.Token(Token = "0x600025E")]
		[Cpp2IlInjected.Address(RVA = "0x55A1580", Offset = "0x55A0380", VA = "0x1855A1580", Slot = "36")]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x600025F")]
		[Cpp2IlInjected.Address(RVA = "0x55A62B0", Offset = "0x55A50B0", VA = "0x1855A62B0", Slot = "37")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A7")]
	public Vector3 HDLNEGJCDGD
	{
		[Cpp2IlInjected.Token(Token = "0x6000260")]
		[Cpp2IlInjected.Address(RVA = "0x55A4260", Offset = "0x55A3060", VA = "0x1855A4260", Slot = "38")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A8")]
	public float AANJNIAMGBP
	{
		[Cpp2IlInjected.Token(Token = "0x6000261")]
		[Cpp2IlInjected.Address(RVA = "0x55A2B90", Offset = "0x55A1990", VA = "0x1855A2B90", Slot = "39")]
		get
		{
			return default(float);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A9")]
	public float LJPJENEPPAO
	{
		[Cpp2IlInjected.Token(Token = "0x6000262")]
		[Cpp2IlInjected.Address(RVA = "0x55A4330", Offset = "0x55A3130", VA = "0x1855A4330", Slot = "40")]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x6000263")]
		[Cpp2IlInjected.Address(RVA = "0x55A2FD0", Offset = "0x55A1DD0", VA = "0x1855A2FD0", Slot = "41")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000AA")]
	public Vector3 OLHILDGADHC
	{
		[Cpp2IlInjected.Token(Token = "0x6000264")]
		[Cpp2IlInjected.Address(RVA = "0x55A34E0", Offset = "0x55A22E0", VA = "0x1855A34E0", Slot = "42")]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x6000265")]
		[Cpp2IlInjected.Address(RVA = "0x55A5700", Offset = "0x55A4500", VA = "0x1855A5700", Slot = "43")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000AB")]
	public Quaternion FPHMFIFGALL
	{
		[Cpp2IlInjected.Token(Token = "0x6000266")]
		[Cpp2IlInjected.Address(RVA = "0x55A10B0", Offset = "0x559FEB0", VA = "0x1855A10B0", Slot = "44")]
		get
		{
			return default(Quaternion);
		}
		[Cpp2IlInjected.Token(Token = "0x6000267")]
		[Cpp2IlInjected.Address(RVA = "0x55A6180", Offset = "0x55A4F80", VA = "0x1855A6180", Slot = "45")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000AC")]
	public float EGNLMBHDOFH
	{
		[Cpp2IlInjected.Token(Token = "0x600026B")]
		[Cpp2IlInjected.Address(RVA = "0x55A6080", Offset = "0x55A4E80", VA = "0x1855A6080", Slot = "46")]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x600026C")]
		[Cpp2IlInjected.Address(RVA = "0x55A2130", Offset = "0x55A0F30", VA = "0x1855A2130", Slot = "47")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000AD")]
	public float NPBKEBDHMEK
	{
		[Cpp2IlInjected.Token(Token = "0x600026D")]
		[Cpp2IlInjected.Address(RVA = "0x55A3B60", Offset = "0x55A2960", VA = "0x1855A3B60", Slot = "48")]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x600026E")]
		[Cpp2IlInjected.Address(RVA = "0x55A2BE0", Offset = "0x55A19E0", VA = "0x1855A2BE0", Slot = "49")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000AE")]
	public bool AHEGBAHBLNL
	{
		[Cpp2IlInjected.Token(Token = "0x600026F")]
		[Cpp2IlInjected.Address(RVA = "0x55A2AF0", Offset = "0x55A18F0", VA = "0x1855A2AF0", Slot = "50")]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000270")]
		[Cpp2IlInjected.Address(RVA = "0x55A4BB0", Offset = "0x55A39B0", VA = "0x1855A4BB0", Slot = "51")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000AF")]
	public PHMDEGBGMEP MEOGMKAMEEP
	{
		[Cpp2IlInjected.Token(Token = "0x6000278")]
		[Cpp2IlInjected.Address(RVA = "0x55A1AA0", Offset = "0x55A08A0", VA = "0x1855A1AA0", Slot = "52")]
		get
		{
			return default(PHMDEGBGMEP);
		}
		[Cpp2IlInjected.Token(Token = "0x6000279")]
		[Cpp2IlInjected.Address(RVA = "0x55A3BB0", Offset = "0x55A29B0", VA = "0x1855A3BB0", Slot = "53")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B0")]
	public bool MJPGFBJBMBL
	{
		[Cpp2IlInjected.Token(Token = "0x600027C")]
		[Cpp2IlInjected.Address(RVA = "0x55A5F10", Offset = "0x55A4D10", VA = "0x1855A5F10", Slot = "54")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B1")]
	public Transform FJKALEOIOIL
	{
		[Cpp2IlInjected.Token(Token = "0x6000283")]
		[Cpp2IlInjected.Address(RVA = "0x55A19A0", Offset = "0x55A07A0", VA = "0x1855A19A0", Slot = "55")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B2")]
	public Transform FENNCJKPIPO
	{
		[Cpp2IlInjected.Token(Token = "0x6000284")]
		[Cpp2IlInjected.Address(RVA = "0x55A19A0", Offset = "0x55A07A0", VA = "0x1855A19A0", Slot = "56")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B3")]
	public Vector3 OCAKMFDJIOJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000285")]
		[Cpp2IlInjected.Address(RVA = "0x55A3C70", Offset = "0x55A2A70", VA = "0x1855A3C70", Slot = "57")]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x6000286")]
		[Cpp2IlInjected.Address(RVA = "0x55A4AA0", Offset = "0x55A38A0", VA = "0x1855A4AA0", Slot = "58")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B4")]
	public float GEIBAJEKMBO
	{
		[Cpp2IlInjected.Token(Token = "0x6000287")]
		[Cpp2IlInjected.Address(RVA = "0x55A1B60", Offset = "0x55A0960", VA = "0x1855A1B60", Slot = "59")]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x6000288")]
		[Cpp2IlInjected.Address(RVA = "0x55A4380", Offset = "0x55A3180", VA = "0x1855A4380", Slot = "60")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B5")]
	public float MOKNEJJCJKK
	{
		[Cpp2IlInjected.Token(Token = "0x6000289")]
		[Cpp2IlInjected.Address(RVA = "0x55A0B70", Offset = "0x559F970", VA = "0x1855A0B70", Slot = "61")]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x600028A")]
		[Cpp2IlInjected.Address(RVA = "0x55A2810", Offset = "0x55A1610", VA = "0x1855A2810", Slot = "62")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B6")]
	public Quaternion PCGLOPJPLLA
	{
		[Cpp2IlInjected.Token(Token = "0x600028B")]
		[Cpp2IlInjected.Address(RVA = "0x55A1280", Offset = "0x55A0080", VA = "0x1855A1280", Slot = "63")]
		get
		{
			return default(Quaternion);
		}
		[Cpp2IlInjected.Token(Token = "0x600028C")]
		[Cpp2IlInjected.Address(RVA = "0x55A3FD0", Offset = "0x55A2DD0", VA = "0x1855A3FD0", Slot = "64")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B7")]
	public Vector3 OGAPOCAACEE
	{
		[Cpp2IlInjected.Token(Token = "0x600028D")]
		[Cpp2IlInjected.Address(RVA = "0x55A4C10", Offset = "0x55A3A10", VA = "0x1855A4C10", Slot = "65")]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x600028E")]
		[Cpp2IlInjected.Address(RVA = "0x55A6590", Offset = "0x55A5390", VA = "0x1855A6590", Slot = "66")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B8")]
	public Quaternion DHDNKCLJBGN
	{
		[Cpp2IlInjected.Token(Token = "0x600028F")]
		[Cpp2IlInjected.Address(RVA = "0x55A3E30", Offset = "0x55A2C30", VA = "0x1855A3E30", Slot = "67")]
		get
		{
			return default(Quaternion);
		}
		[Cpp2IlInjected.Token(Token = "0x6000290")]
		[Cpp2IlInjected.Address(RVA = "0x55A3310", Offset = "0x55A2110", VA = "0x1855A3310", Slot = "68")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B9")]
	public RigidbodyConstraints PDLJENDCEHJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000294")]
		[Cpp2IlInjected.Address(RVA = "0x55A5080", Offset = "0x55A3E80", VA = "0x1855A5080", Slot = "69")]
		get
		{
			return default(RigidbodyConstraints);
		}
		[Cpp2IlInjected.Token(Token = "0x6000295")]
		[Cpp2IlInjected.Address(RVA = "0x55A0B10", Offset = "0x559F910", VA = "0x1855A0B10", Slot = "70")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000BA")]
	public bool DKOAFEFPELM
	{
		[Cpp2IlInjected.Token(Token = "0x6000296")]
		[Cpp2IlInjected.Address(RVA = "0x55A6130", Offset = "0x55A4F30", VA = "0x1855A6130", Slot = "71")]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000297")]
		[Cpp2IlInjected.Address(RVA = "0x55A1650", Offset = "0x55A0450", VA = "0x1855A1650", Slot = "72")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000BB")]
	public CollisionDetectionMode FEJFOAGMGJI
	{
		[Cpp2IlInjected.Token(Token = "0x60002A0")]
		[Cpp2IlInjected.Address(RVA = "0x55A1060", Offset = "0x559FE60", VA = "0x1855A1060", Slot = "73")]
		get
		{
			return default(CollisionDetectionMode);
		}
		[Cpp2IlInjected.Token(Token = "0x60002A1")]
		[Cpp2IlInjected.Address(RVA = "0x55A6250", Offset = "0x55A5050", VA = "0x1855A6250", Slot = "74")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000BC")]
	public bool BIBDGFIAGJM
	{
		[Cpp2IlInjected.Token(Token = "0x60002A3")]
		[Cpp2IlInjected.Address(RVA = "0x55A55C0", Offset = "0x55A43C0", VA = "0x1855A55C0", Slot = "75")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000021")]
	public event IJDKLAGCEFG PBOBAMPILGB
	{
		[Cpp2IlInjected.Token(Token = "0x6000226")]
		[Cpp2IlInjected.Address(RVA = "0x55A65E0", Offset = "0x55A53E0", VA = "0x1855A65E0", Slot = "81")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000227")]
		[Cpp2IlInjected.Address(RVA = "0x55A5C50", Offset = "0x55A4A50", VA = "0x1855A5C50", Slot = "82")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000022")]
	public event IJDKLAGCEFG GKGJJLMHDLI
	{
		[Cpp2IlInjected.Token(Token = "0x6000228")]
		[Cpp2IlInjected.Address(RVA = "0x55A54B0", Offset = "0x55A42B0", VA = "0x1855A54B0", Slot = "83")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000229")]
		[Cpp2IlInjected.Address(RVA = "0x55A13F0", Offset = "0x55A01F0", VA = "0x1855A13F0", Slot = "84")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000023")]
	public event MHEGFHPPLGP NHDMDBLHBHF
	{
		[Cpp2IlInjected.Token(Token = "0x600022A")]
		[Cpp2IlInjected.Address(RVA = "0x55A1390", Offset = "0x55A0190", VA = "0x1855A1390", Slot = "85")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600022B")]
		[Cpp2IlInjected.Address(RVA = "0x55A2600", Offset = "0x55A1400", VA = "0x1855A2600", Slot = "86")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000024")]
	public event IJDKLAGCEFG OIHJCECPHEI
	{
		[Cpp2IlInjected.Token(Token = "0x6000232")]
		[Cpp2IlInjected.Address(RVA = "0x55A0C70", Offset = "0x559FA70", VA = "0x1855A0C70", Slot = "88")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000233")]
		[Cpp2IlInjected.Address(RVA = "0x55A2350", Offset = "0x55A1150", VA = "0x1855A2350", Slot = "89")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000025")]
	public event IJDKLAGCEFG NAHKAOPHPKB
	{
		[Cpp2IlInjected.Token(Token = "0x600025C")]
		[Cpp2IlInjected.Address(RVA = "0x55A23B0", Offset = "0x55A11B0", VA = "0x1855A23B0", Slot = "108")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600025D")]
		[Cpp2IlInjected.Address(RVA = "0x55A52E0", Offset = "0x55A40E0", VA = "0x1855A52E0", Slot = "109")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000026")]
	public event IJDKLAGCEFG JLFHAPOODCF
	{
		[Cpp2IlInjected.Token(Token = "0x6000271")]
		[Cpp2IlInjected.Address(RVA = "0x55A36B0", Offset = "0x55A24B0", VA = "0x1855A36B0", Slot = "113")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000272")]
		[Cpp2IlInjected.Address(RVA = "0x55A1330", Offset = "0x55A0130", VA = "0x1855A1330", Slot = "114")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000027")]
	public event Action<EHKPJAMPICF, EHKPJAMPICF> JCAEOOCFBGA
	{
		[Cpp2IlInjected.Token(Token = "0x6000276")]
		[Cpp2IlInjected.Address(RVA = "0x55A1220", Offset = "0x55A0020", VA = "0x1855A1220", Slot = "117")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000277")]
		[Cpp2IlInjected.Address(RVA = "0x55A3E70", Offset = "0x55A2C70", VA = "0x1855A3E70", Slot = "118")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000028")]
	public event IJDKLAGCEFG LMBBIPHIOEK
	{
		[Cpp2IlInjected.Token(Token = "0x600027A")]
		[Cpp2IlInjected.Address(RVA = "0x55A5560", Offset = "0x55A4360", VA = "0x1855A5560", Slot = "119")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600027B")]
		[Cpp2IlInjected.Address(RVA = "0x55A0AB0", Offset = "0x559F8B0", VA = "0x1855A0AB0", Slot = "120")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000029")]
	public event IJDKLAGCEFG HMNHPLAABPL
	{
		[Cpp2IlInjected.Token(Token = "0x6000281")]
		[Cpp2IlInjected.Address(RVA = "0x55A2660", Offset = "0x55A1460", VA = "0x1855A2660", Slot = "125")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000282")]
		[Cpp2IlInjected.Address(RVA = "0x55A3610", Offset = "0x55A2410", VA = "0x1855A3610", Slot = "126")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600021F")]
	[Cpp2IlInjected.Address(RVA = "0x55A6680", Offset = "0x55A5480", VA = "0x1855A6680")]
	public LGAGFCAGMMC(GameObject AAMBGNNHMBI, RigidbodyEx OAOOMIBODOP, BABOKGOAEJI OBAPIKNALOO, in GPHOCGFKAIA PHAPMEHMHAK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000220")]
	[Cpp2IlInjected.Address(RVA = "0x55A58F0", Offset = "0x55A46F0", VA = "0x1855A58F0", Slot = "142")]
	protected virtual void OJECLMJDEEI(BABOKGOAEJI OBAPIKNALOO, GPHOCGFKAIA PHAPMEHMHAK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000221")]
	[Cpp2IlInjected.Address(RVA = "0x55A1C90", Offset = "0x55A0A90", VA = "0x1855A1C90", Slot = "143")]
	public virtual void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000222")]
	[Cpp2IlInjected.Address(RVA = "0x55A4900", Offset = "0x55A3700", VA = "0x1855A4900", Slot = "76")]
	public void LOAKFOBCBAO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000223")]
	[Cpp2IlInjected.Address(RVA = "0x55A0A60", Offset = "0x559F860", VA = "0x1855A0A60", Slot = "77")]
	public void IGDJODCGKJE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000224")]
	[Cpp2IlInjected.Address(RVA = "0x1F2F070", Offset = "0x1F2DE70", VA = "0x181F2F070", Slot = "78")]
	public void BBLEBJJHLNM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000225")]
	[Cpp2IlInjected.Address(RVA = "0x55A3350", Offset = "0x55A2150", VA = "0x1855A3350", Slot = "144")]
	public virtual void GMONNENGCBC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000231")]
	[Cpp2IlInjected.Address(RVA = "0x55A16B0", Offset = "0x55A04B0", VA = "0x1855A16B0", Slot = "87")]
	public void CNEDMMKBPIO(DDICDNFJGFA NLHFEJHKLAH, bool BNLMFCPNEHF = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000248")]
	[Cpp2IlInjected.Address(RVA = "0x55A29C0", Offset = "0x55A17C0", VA = "0x1855A29C0", Slot = "90")]
	public void FKHILLLDBNL(object INDCJAMMAIN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000249")]
	[Cpp2IlInjected.Address(RVA = "0x55A3710", Offset = "0x55A2510", VA = "0x1855A3710", Slot = "91")]
	public void HICAJKMKHKJ(object INDCJAMMAIN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600024A")]
	[Cpp2IlInjected.Address(RVA = "0x55A19B0", Offset = "0x55A07B0", VA = "0x1855A19B0", Slot = "92")]
	public Vector3 DKGOLPKDCPG(Vector3 LGHPPABOKOK)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x600024B")]
	[Cpp2IlInjected.Address(RVA = "0x55A2040", Offset = "0x55A0E40", VA = "0x1855A2040", Slot = "93")]
	public Vector3 EHCFPONMFKA(Vector3 AFLGANKGICH)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x600024C")]
	[Cpp2IlInjected.Address(RVA = "0x55A0A60", Offset = "0x559F860", VA = "0x1855A0A60", Slot = "94")]
	public void AGCPJAHILEP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600024D")]
	[Cpp2IlInjected.Address(RVA = "0x55A27C0", Offset = "0x55A15C0", VA = "0x1855A27C0", Slot = "95")]
	public void FIIAJOAMNGJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600024E")]
	[Cpp2IlInjected.Address(RVA = "0x55A57D0", Offset = "0x55A45D0", VA = "0x1855A57D0", Slot = "96")]
	public void OGCLLIMCEGK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600024F")]
	[Cpp2IlInjected.Address(RVA = "0x55A51F0", Offset = "0x55A3FF0", VA = "0x1855A51F0", Slot = "97")]
	public void NFJDLDDEJMF(Vector3 IMMOLPOLNBA, Vector3 OGMHJOIPEGI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000250")]
	[Cpp2IlInjected.Address(RVA = "0x55A4DC0", Offset = "0x55A3BC0", VA = "0x1855A4DC0", Slot = "98")]
	public void MODKKAHENJA(Vector3 IAOEEAAKMPP, Vector3 IDJHMKHCMIA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000251")]
	[Cpp2IlInjected.Address(RVA = "0x55A2F00", Offset = "0x55A1D00", VA = "0x1855A2F00", Slot = "99")]
	public void GGCHAGHHFEC(Vector3 GKPHCGNAJHA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000252")]
	[Cpp2IlInjected.Address(RVA = "0x55A1830", Offset = "0x55A0630", VA = "0x1855A1830", Slot = "100")]
	public void DCKBJJIFEAA(GOIGKHJPKIL LKEHIILFBGJ, Vector3 CPJPNJCMJAL, float LJKLGGMAHOJ, float LHJEDBKLJNN = 8f, float PAKBBNDEEJP = 1f)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000253")]
	[Cpp2IlInjected.Address(RVA = "0x55A4670", Offset = "0x55A3470", VA = "0x1855A4670", Slot = "101")]
	public void LDIFLICNPJP(OEBNECHHPCF GDDGFGKAHMD, Vector3 BNCCLPFNHEL, float JEMKJHNONPD = float.PositiveInfinity)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000254")]
	[Cpp2IlInjected.Address(RVA = "0x55A4C60", Offset = "0x55A3A60", VA = "0x1855A4C60", Slot = "102")]
	[Obsolete]
	public void MKPHELIMAAE(OEBNECHHPCF GDDGFGKAHMD, Vector3 HKMKNOBAIAN, float NIDEHIHCIBC = 7f, float DLGLDDADCFL = 1f)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000255")]
	[Cpp2IlInjected.Address(RVA = "0x55A64A0", Offset = "0x55A52A0", VA = "0x1855A64A0", Slot = "103")]
	public Vector3 PKBLILEEDPH(Vector3 NLHFEJHKLAH)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000256")]
	[Cpp2IlInjected.Address(RVA = "0x55A2190", Offset = "0x55A0F90", VA = "0x1855A2190", Slot = "104")]
	public Vector3 EIEKMNNPHJM(Vector3 NLHFEJHKLAH)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000257")]
	[Cpp2IlInjected.Address(RVA = "0x55A2B40", Offset = "0x55A1940", VA = "0x1855A2B40", Slot = "105")]
	public void FLNLDAANDPM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600025A")]
	[Cpp2IlInjected.Address(RVA = "0x55A2280", Offset = "0x55A1080", VA = "0x1855A2280", Slot = "106")]
	public void EMNIPIHNALC(DDICDNFJGFA JCBNEMEEHFF, object INDCJAMMAIN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600025B")]
	[Cpp2IlInjected.Address(RVA = "0x55A2700", Offset = "0x55A1500", VA = "0x1855A2700", Slot = "107")]
	public void FEHAHPDNHDG(object INDCJAMMAIN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000268")]
	[Cpp2IlInjected.Address(RVA = "0x55A2C40", Offset = "0x55A1A40", VA = "0x1855A2C40", Slot = "110")]
	public void GBIGLFOHPKF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000269")]
	[Cpp2IlInjected.Address(RVA = "0x55A51A0", Offset = "0x55A3FA0", VA = "0x1855A51A0", Slot = "111")]
	public void NFCCEAJGIIH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600026A")]
	[Cpp2IlInjected.Address(RVA = "0x55A1950", Offset = "0x55A0750", VA = "0x1855A1950", Slot = "112")]
	public void DCKPFKGOBFJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000273")]
	[Cpp2IlInjected.Address(RVA = "0x55A5CB0", Offset = "0x55A4AB0", VA = "0x1855A5CB0", Slot = "115")]
	public bool OMBGDMJFHEI()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000274")]
	[Cpp2IlInjected.Address(RVA = "0x55A4D70", Offset = "0x55A3B70", VA = "0x1855A4D70", Slot = "79")]
	public void MNLNBCJHPMD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000275")]
	[Cpp2IlInjected.Address(RVA = "0x55A1E70", Offset = "0x55A0C70", VA = "0x1855A1E70", Slot = "116")]
	public void EDKDBDBJFEP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600027D")]
	[Cpp2IlInjected.Address(RVA = "0x55A6030", Offset = "0x55A4E30", VA = "0x1855A6030", Slot = "121")]
	public IDisposable PAOMLEGBIMN()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600027E")]
	[Cpp2IlInjected.Address(RVA = "0x55A4A40", Offset = "0x55A3840", VA = "0x1855A4A40", Slot = "122")]
	public void MBDADCCBFHH(object INDCJAMMAIN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600027F")]
	[Cpp2IlInjected.Address(RVA = "0x55A3F70", Offset = "0x55A2D70", VA = "0x1855A3F70", Slot = "123")]
	public void JKKBAAMOMNK(object INDCJAMMAIN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000280")]
	[Cpp2IlInjected.Address(RVA = "0x55A1AF0", Offset = "0x55A08F0", VA = "0x1855A1AF0", Slot = "124")]
	public void DNFBGHHNNHM(object INDCJAMMAIN, bool NKIGKALHKKG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000291")]
	[Cpp2IlInjected.Address(RVA = "0x55A0680", Offset = "0x559F480", VA = "0x1855A0680", Slot = "127")]
	public void AACJLACMIEO(Vector3 KPJPKNEEHFJ, Quaternion FFPDKCAEKDA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000292")]
	[Cpp2IlInjected.Address(RVA = "0x55A40B0", Offset = "0x55A2EB0", VA = "0x1855A40B0", Slot = "128")]
	public void JNOALKFAIEH(Vector3 APJBCHKNCHD, Quaternion LIMMBJPINMP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000293")]
	[Cpp2IlInjected.Address(RVA = "0x55A1180", Offset = "0x559FF80", VA = "0x1855A1180", Slot = "129")]
	public bool BLMMBEJIFIE(float MHHMHIKNPME)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000298")]
	[Cpp2IlInjected.Address(RVA = "0x55A2E10", Offset = "0x55A1C10", VA = "0x1855A2E10", Slot = "130")]
	public void GEKJMPIKEBI(object INDCJAMMAIN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000299")]
	[Cpp2IlInjected.Address(RVA = "0x55A60D0", Offset = "0x55A4ED0", VA = "0x1855A60D0", Slot = "131")]
	public void PBODBJKKJIG(object INDCJAMMAIN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600029A")]
	[Cpp2IlInjected.Address(RVA = "0x55A0CD0", Offset = "0x559FAD0", VA = "0x1855A0CD0", Slot = "132")]
	public void BGFCCCENBID(object INDCJAMMAIN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600029B")]
	[Cpp2IlInjected.Address(RVA = "0x55A35B0", Offset = "0x55A23B0", VA = "0x1855A35B0", Slot = "133")]
	public void GPBOKOEIFJD(object INDCJAMMAIN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600029C")]
	[Cpp2IlInjected.Address(RVA = "0x55A5820", Offset = "0x55A4620", VA = "0x1855A5820", Slot = "134")]
	public void OHEOAAGAOKK(Vector3 AJKJHFCHOAK, ForceMode GMFAKLHMDNN = ForceMode.Force)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600029D")]
	[Cpp2IlInjected.Address(RVA = "0x55A1720", Offset = "0x55A0520", VA = "0x1855A1720", Slot = "135")]
	public void DBDNFABFCFD(Vector3 AJKJHFCHOAK, Vector3 CBAKPHLPCPB, ForceMode GMFAKLHMDNN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600029E")]
	[Cpp2IlInjected.Address(RVA = "0x55A5BD0", Offset = "0x55A49D0", VA = "0x1855A5BD0", Slot = "136")]
	public void OKEPOCHCNGP(Vector3 OJLGOOKKJEA, ForceMode GMFAKLHMDNN = ForceMode.Force)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600029F")]
	[Cpp2IlInjected.Address(RVA = "0x55A4480", Offset = "0x55A3280", VA = "0x1855A4480", Slot = "137")]
	public void KIIOGIGGADP(Vector3 OJLGOOKKJEA, ForceMode GMFAKLHMDNN = ForceMode.Force)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002A2")]
	[Cpp2IlInjected.Address(RVA = "0x55A0960", Offset = "0x559F760", VA = "0x1855A0960", Slot = "138")]
	public bool AFMAEECEEBD(Vector3 HHGBGELADCO, out RaycastHit MFKIKGLHAMN, float EMEIKNNEGHK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002A4")]
	[Cpp2IlInjected.Address(RVA = "0x55A1FF0", Offset = "0x55A0DF0", VA = "0x1855A1FF0", Slot = "139")]
	public void EGDEMHMFAIF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002A5")]
	[Cpp2IlInjected.Address(RVA = "0x55A6640", Offset = "0x55A5440", VA = "0x1855A6640", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002A6")]
	[Cpp2IlInjected.Address(RVA = "0x55A1BC0", Offset = "0x55A09C0", VA = "0x1855A1BC0")]
	private void DPONDHMHFMG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002A7")]
	[Cpp2IlInjected.Address(RVA = "0x55A1D60", Offset = "0x55A0B60", VA = "0x1855A1D60")]
	private void EACBMKIOFDN(DDICDNFJGFA AABHIBJPKOH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002A8")]
	[Cpp2IlInjected.Address(RVA = "0x55A2410", Offset = "0x55A1210", VA = "0x1855A2410")]
	private void FADEKNBCKFN(DDICDNFJGFA AABHIBJPKOH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002A9")]
	[Cpp2IlInjected.Address(RVA = "0x55A4770", Offset = "0x55A3570", VA = "0x1855A4770")]
	private void LFFDHJIKNMI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002AA")]
	[Cpp2IlInjected.Address(RVA = "0x55A4EB0", Offset = "0x55A3CB0", VA = "0x1855A4EB0")]
	private void MONEGAMHKMJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002AB")]
	[Cpp2IlInjected.Address(RVA = "0x55A3D80", Offset = "0x55A2B80", VA = "0x1855A3D80")]
	private void IHPPJKOOGLE(DDICDNFJGFA KJJPIPKOFKF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002AC")]
	[Cpp2IlInjected.Address(RVA = "0x55A4820", Offset = "0x55A3620", VA = "0x1855A4820")]
	private void LJCPKLHMCNP(DDICDNFJGFA AABHIBJPKOH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002AD")]
	[Cpp2IlInjected.Address(RVA = "0x55A3400", Offset = "0x55A2200", VA = "0x1855A3400")]
	private void GNGIENKKJBL(DDICDNFJGFA AABHIBJPKOH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002AE")]
	[Cpp2IlInjected.Address(RVA = "0x55A4500", Offset = "0x55A3300", VA = "0x1855A4500")]
	private void KLKKNOFCCON(RigidbodyEx AABHIBJPKOH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002AF")]
	[Cpp2IlInjected.Address(RVA = "0x55A37C0", Offset = "0x55A25C0", VA = "0x1855A37C0")]
	private void HKMICNMIAPE(RigidbodyEx FBJBBGAMODK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002B0")]
	[Cpp2IlInjected.Address(RVA = "0x55A1EC0", Offset = "0x55A0CC0", VA = "0x1855A1EC0")]
	[Conditional("UNITY_EDITOR")]
	private void EDPJHNPFDEL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002B1")]
	[Cpp2IlInjected.Address(RVA = "0x55A3030", Offset = "0x55A1E30", VA = "0x1855A3030")]
	protected void GIGELDACNBF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002B2")]
	[Cpp2IlInjected.Address(RVA = "0x55A0D30", Offset = "0x559FB30", VA = "0x1855A0D30")]
	protected void BIKKPBGAPMG()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002A")]
internal static class GBHHMNGKEJH
{
	[Cpp2IlInjected.Token(Token = "0x60002B3")]
	[Cpp2IlInjected.Address(RVA = "0x5590380", Offset = "0x558F180", VA = "0x185590380")]
	public static DDICDNFJGFA PPDJPMOCJOA(this DDICDNFJGFA FBJBBGAMODK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002B4")]
	[Cpp2IlInjected.Address(RVA = "0x5590290", Offset = "0x558F090", VA = "0x185590290")]
	public static bool FCOOIGGLAGD(this DDICDNFJGFA FBJBBGAMODK, DDICDNFJGFA KNCDCFIFNGJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002B5")]
	[Cpp2IlInjected.Address(RVA = "0x5590210", Offset = "0x558F010", VA = "0x185590210")]
	public static bool DMENDANHKPD(this DDICDNFJGFA FBJBBGAMODK, DDICDNFJGFA OCELHNBKHHL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002B6")]
	[Cpp2IlInjected.Address(RVA = "0x55901C0", Offset = "0x558EFC0", VA = "0x1855901C0")]
	public static RigidbodyEx DEPNLHOILPJ(this DDICDNFJGFA AHBOCLNKFHO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002B7")]
	[Cpp2IlInjected.Address(RVA = "0x5590310", Offset = "0x558F110", VA = "0x185590310")]
	public static LGAGFCAGMMC MMPOEFEPMCN(this DDICDNFJGFA HLKJMHJNLMO)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200002B")]
internal class JLJNKPMPLAL : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000044")]
	private readonly LGAGFCAGMMC FBJBBGAMODK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000045")]
	private bool LKLAHNKMKAI;

	[Cpp2IlInjected.Token(Token = "0x60002B8")]
	[Cpp2IlInjected.Address(RVA = "0x5599E90", Offset = "0x5598C90", VA = "0x185599E90")]
	public JLJNKPMPLAL(LGAGFCAGMMC HHMAGOGHHJO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002B9")]
	[Cpp2IlInjected.Address(RVA = "0x5599E30", Offset = "0x5598C30", VA = "0x185599E30", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002C")]
internal sealed class DNEIGPLIHAP : LDGABKDBCIL, HFDAKPEHNOJ
{
	[Cpp2IlInjected.Token(Token = "0x170000BD")]
	private CollisionDetectionMode FEKLBAOHLJK
	{
		[Cpp2IlInjected.Token(Token = "0x60002BB")]
		[Cpp2IlInjected.Address(RVA = "0x558EC80", Offset = "0x558DA80", VA = "0x18558EC80")]
		get
		{
			return default(CollisionDetectionMode);
		}
		[Cpp2IlInjected.Token(Token = "0x60002BC")]
		[Cpp2IlInjected.Address(RVA = "0x558EF70", Offset = "0x558DD70", VA = "0x18558EF70")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000BE")]
	private Rigidbody AMAINOJCLLB
	{
		[Cpp2IlInjected.Token(Token = "0x60002BD")]
		[Cpp2IlInjected.Address(RVA = "0x558F170", Offset = "0x558DF70", VA = "0x18558F170")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000BF")]
	public CollisionDetectionMode FEJFOAGMGJI
	{
		[Cpp2IlInjected.Token(Token = "0x60002C0")]
		[Cpp2IlInjected.Address(RVA = "0x558EB70", Offset = "0x558D970", VA = "0x18558EB70", Slot = "4")]
		get
		{
			return default(CollisionDetectionMode);
		}
		[Cpp2IlInjected.Token(Token = "0x60002C1")]
		[Cpp2IlInjected.Address(RVA = "0x558F1D0", Offset = "0x558DFD0", VA = "0x18558F1D0", Slot = "5")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60002BA")]
	[Cpp2IlInjected.Address(RVA = "0x558DE30", Offset = "0x558CC30", VA = "0x18558DE30")]
	public DNEIGPLIHAP(DDICDNFJGFA FBJBBGAMODK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002BE")]
	[Cpp2IlInjected.Address(RVA = "0x558F060", Offset = "0x558DE60", VA = "0x18558F060", Slot = "6")]
	public void LOAKFOBCBAO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002BF")]
	[Cpp2IlInjected.Address(RVA = "0x558E970", Offset = "0x558D770", VA = "0x18558E970", Slot = "9")]
	public void AEBCBAGKFLD(Rigidbody EMPCHDNCBNN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002C2")]
	[Cpp2IlInjected.Address(RVA = "0x558F1C0", Offset = "0x558DFC0", VA = "0x18558F1C0", Slot = "7")]
	public void ONLJAMKOMCG(bool HOMNNPNFFHH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002C3")]
	[Cpp2IlInjected.Address(RVA = "0x558EF60", Offset = "0x558DD60", VA = "0x18558EF60", Slot = "8")]
	public void GIEFKHILOBN(bool HOMNNPNFFHH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002C4")]
	[Cpp2IlInjected.Address(RVA = "0x558EA00", Offset = "0x558D800", VA = "0x18558EA00", Slot = "10")]
	public bool AFMAEECEEBD(Vector3 HHGBGELADCO, out RaycastHit MFKIKGLHAMN, float EMEIKNNEGHK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002C5")]
	[Cpp2IlInjected.Address(RVA = "0x558ED60", Offset = "0x558DB60", VA = "0x18558ED60")]
	private void DIIMJKBAEDM(bool HOMNNPNFFHH)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002D")]
internal sealed class PICIKKMEJGI : LDGABKDBCIL, OIINLPAMLAF, IDisposable, KJGOLDGANAL
{
	[Cpp2IlInjected.Token(Token = "0x170000C0")]
	public PHMDEGBGMEP IELHKOBJMAC
	{
		[Cpp2IlInjected.Token(Token = "0x60002C9")]
		[Cpp2IlInjected.Address(RVA = "0x55B10A0", Offset = "0x55AFEA0", VA = "0x1855B10A0")]
		get
		{
			return default(PHMDEGBGMEP);
		}
		[Cpp2IlInjected.Token(Token = "0x60002CA")]
		[Cpp2IlInjected.Address(RVA = "0x55B0F10", Offset = "0x55AFD10", VA = "0x1855B0F10")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000C1")]
	public PHMDEGBGMEP MEOGMKAMEEP
	{
		[Cpp2IlInjected.Token(Token = "0x60002CB")]
		[Cpp2IlInjected.Address(RVA = "0x55B0CF0", Offset = "0x55AFAF0", VA = "0x1855B0CF0", Slot = "6")]
		get
		{
			return default(PHMDEGBGMEP);
		}
		[Cpp2IlInjected.Token(Token = "0x60002CC")]
		[Cpp2IlInjected.Address(RVA = "0x55B0F10", Offset = "0x55AFD10", VA = "0x1855B0F10", Slot = "7")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000C2")]
	private Transform OEIIJAKMCBK
	{
		[Cpp2IlInjected.Token(Token = "0x60002D1")]
		[Cpp2IlInjected.Address(RVA = "0x70F8D0", Offset = "0x70E6D0", VA = "0x18070F8D0", Slot = "10")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400002A")]
	public event Action<EHKPJAMPICF, EHKPJAMPICF> JCAEOOCFBGA
	{
		[Cpp2IlInjected.Token(Token = "0x60002C7")]
		[Cpp2IlInjected.Address(RVA = "0x55B0C50", Offset = "0x55AFA50", VA = "0x1855B0C50", Slot = "4")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60002C8")]
		[Cpp2IlInjected.Address(RVA = "0x55B1000", Offset = "0x55AFE00", VA = "0x1855B1000", Slot = "5")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60002C6")]
	[Cpp2IlInjected.Address(RVA = "0x558DE30", Offset = "0x558CC30", VA = "0x18558DE30")]
	public PICIKKMEJGI(DDICDNFJGFA FBJBBGAMODK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002CD")]
	[Cpp2IlInjected.Address(RVA = "0x55B1180", Offset = "0x55AFF80", VA = "0x1855B1180", Slot = "11")]
	public void OnChangedDistanceBand(EHKPJAMPICF OMHFAAGAIBL, EHKPJAMPICF KMCDOHPNFGD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002CE")]
	[Cpp2IlInjected.Address(RVA = "0x6ED320", Offset = "0x6EC120", VA = "0x1806ED320", Slot = "12")]
	public void OnChangedVisibility(bool CBNEFALBIGO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002CF")]
	[Cpp2IlInjected.Address(RVA = "0x6ED320", Offset = "0x6EC120", VA = "0x1806ED320", Slot = "8")]
	public void LOAKFOBCBAO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002D0")]
	[Cpp2IlInjected.Address(RVA = "0x6ED320", Offset = "0x6EC120", VA = "0x1806ED320", Slot = "9")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002E")]
internal sealed class JOEJADONHKE : LDGABKDBCIL, CFLNOOGGMLK
{
	[Cpp2IlInjected.Token(Token = "0x170000C3")]
	private Rigidbody AMAINOJCLLB
	{
		[Cpp2IlInjected.Token(Token = "0x60002D3")]
		[Cpp2IlInjected.Address(RVA = "0x558F170", Offset = "0x558DF70", VA = "0x18558F170")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000C4")]
	private bool MJPGFBJBMBL
	{
		[Cpp2IlInjected.Token(Token = "0x60002D4")]
		[Cpp2IlInjected.Address(RVA = "0x559B0E0", Offset = "0x5599EE0", VA = "0x18559B0E0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000C5")]
	private bool FGHFGPDIBIE
	{
		[Cpp2IlInjected.Token(Token = "0x60002D5")]
		[Cpp2IlInjected.Address(RVA = "0x55981C0", Offset = "0x5596FC0", VA = "0x1855981C0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000C6")]
	private DDICDNFJGFA KFPCMBOLNGI
	{
		[Cpp2IlInjected.Token(Token = "0x60002D6")]
		[Cpp2IlInjected.Address(RVA = "0x559AB40", Offset = "0x5599940", VA = "0x18559AB40")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60002D2")]
	[Cpp2IlInjected.Address(RVA = "0x558DE30", Offset = "0x558CC30", VA = "0x18558DE30")]
	public JOEJADONHKE(DDICDNFJGFA FBJBBGAMODK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002D7")]
	[Cpp2IlInjected.Address(RVA = "0x559AE20", Offset = "0x5599C20", VA = "0x18559AE20", Slot = "4")]
	public void OHEOAAGAOKK(Vector3 AJKJHFCHOAK, ForceMode GMFAKLHMDNN = ForceMode.Force)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002D8")]
	[Cpp2IlInjected.Address(RVA = "0x559B130", Offset = "0x5599F30", VA = "0x18559B130")]
	private void PAHFFEKNLJP(Vector3 AJKJHFCHOAK, ForceMode GMFAKLHMDNN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002D9")]
	[Cpp2IlInjected.Address(RVA = "0x559A620", Offset = "0x5599420", VA = "0x18559A620", Slot = "5")]
	public void DBDNFABFCFD(Vector3 AJKJHFCHOAK, Vector3 CBAKPHLPCPB, ForceMode GMFAKLHMDNN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002DA")]
	[Cpp2IlInjected.Address(RVA = "0x559AF80", Offset = "0x5599D80", VA = "0x18559AF80", Slot = "6")]
	public void OKEPOCHCNGP(Vector3 OJLGOOKKJEA, ForceMode GMFAKLHMDNN = ForceMode.Force)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002DB")]
	[Cpp2IlInjected.Address(RVA = "0x559A8C0", Offset = "0x55996C0", VA = "0x18559A8C0")]
	private void HAJDDDHGPOO(Vector3 OJLGOOKKJEA, ForceMode GMFAKLHMDNN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002DC")]
	[Cpp2IlInjected.Address(RVA = "0x559ABA0", Offset = "0x55999A0", VA = "0x18559ABA0", Slot = "7")]
	public void KIIOGIGGADP(Vector3 OJLGOOKKJEA, ForceMode GMFAKLHMDNN = ForceMode.Force)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002F")]
internal sealed class DHCHALLKJGD : LDGABKDBCIL, NHHNBAGKHPP
{
	[Cpp2IlInjected.Token(Token = "0x170000C7")]
	public bool AHEGBAHBLNL
	{
		[Cpp2IlInjected.Token(Token = "0x60002DE")]
		[Cpp2IlInjected.Address(RVA = "0x558DB00", Offset = "0x558C900", VA = "0x18558DB00", Slot = "4")]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x60002DF")]
		[Cpp2IlInjected.Address(RVA = "0x558DC50", Offset = "0x558CA50", VA = "0x18558DC50", Slot = "5")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60002DD")]
	[Cpp2IlInjected.Address(RVA = "0x558DE30", Offset = "0x558CC30", VA = "0x18558DE30")]
	public DHCHALLKJGD(DDICDNFJGFA FBJBBGAMODK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002E0")]
	[Cpp2IlInjected.Address(RVA = "0x558DA00", Offset = "0x558C800", VA = "0x18558DA00", Slot = "6")]
	public void AEBCBAGKFLD(Rigidbody EMPCHDNCBNN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002E1")]
	[Cpp2IlInjected.Address(RVA = "0x558DBE0", Offset = "0x558C9E0", VA = "0x18558DBE0", Slot = "7")]
	public void IEECHEIALJL(Rigidbody EMPCHDNCBNN)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000030")]
internal sealed class JPLCBCDLMEH : LDGABKDBCIL, HIBPGMCCMFF, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x4000050")]
	private readonly KPDJCFBPNHB GJFKHPNECKG;

	[Cpp2IlInjected.Token(Token = "0x170000C8")]
	private Transform OBACKBELLEI
	{
		[Cpp2IlInjected.Token(Token = "0x60002F5")]
		[Cpp2IlInjected.Address(RVA = "0x559CD40", Offset = "0x559BB40", VA = "0x18559CD40")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000C9")]
	public IMKMJFJEHIJ AGGHHGLBFCN
	{
		[Cpp2IlInjected.Token(Token = "0x60002F7")]
		[Cpp2IlInjected.Address(RVA = "0x559D140", Offset = "0x559BF40", VA = "0x18559D140")]
		get
		{
			return default(IMKMJFJEHIJ);
		}
		[Cpp2IlInjected.Token(Token = "0x60002F8")]
		[Cpp2IlInjected.Address(RVA = "0x559D320", Offset = "0x559C120", VA = "0x18559D320")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000CA")]
	public DDICDNFJGFA KFPCMBOLNGI
	{
		[Cpp2IlInjected.Token(Token = "0x60002F9")]
		[Cpp2IlInjected.Address(RVA = "0x559D100", Offset = "0x559BF00", VA = "0x18559D100", Slot = "24")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60002FA")]
		[Cpp2IlInjected.Address(RVA = "0x559B760", Offset = "0x559A560", VA = "0x18559B760", Slot = "25")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000CB")]
	public IMKMJFJEHIJ JLPIABOEDKC
	{
		[Cpp2IlInjected.Token(Token = "0x60002FB")]
		[Cpp2IlInjected.Address(RVA = "0x559C4B0", Offset = "0x559B2B0", VA = "0x18559C4B0")]
		get
		{
			return default(IMKMJFJEHIJ);
		}
		[Cpp2IlInjected.Token(Token = "0x60002FC")]
		[Cpp2IlInjected.Address(RVA = "0x559D000", Offset = "0x559BE00", VA = "0x18559D000")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000CC")]
	public DDICDNFJGFA CAHHKGJGOJO
	{
		[Cpp2IlInjected.Token(Token = "0x60002FD")]
		[Cpp2IlInjected.Address(RVA = "0x559D2E0", Offset = "0x559C0E0", VA = "0x18559D2E0", Slot = "23")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000CD")]
	public IReadOnlyList<DDICDNFJGFA> IAJCOJILOEF
	{
		[Cpp2IlInjected.Token(Token = "0x60002FE")]
		[Cpp2IlInjected.Address(RVA = "0x7B1C50", Offset = "0x7B0A50", VA = "0x1807B1C50", Slot = "22")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400002B")]
	public event IJDKLAGCEFG PBOBAMPILGB
	{
		[Cpp2IlInjected.Token(Token = "0x60002E3")]
		[Cpp2IlInjected.Address(RVA = "0x559D990", Offset = "0x559C790", VA = "0x18559D990", Slot = "4")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60002E4")]
		[Cpp2IlInjected.Address(RVA = "0x559D850", Offset = "0x559C650", VA = "0x18559D850", Slot = "5")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400002C")]
	public event IJDKLAGCEFG GKGJJLMHDLI
	{
		[Cpp2IlInjected.Token(Token = "0x60002E5")]
		[Cpp2IlInjected.Address(RVA = "0x559D7B0", Offset = "0x559C5B0", VA = "0x18559D7B0", Slot = "6")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60002E6")]
		[Cpp2IlInjected.Address(RVA = "0x559B620", Offset = "0x559A420", VA = "0x18559B620", Slot = "7")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400002D")]
	public event MHEGFHPPLGP NHDMDBLHBHF
	{
		[Cpp2IlInjected.Token(Token = "0x60002E7")]
		[Cpp2IlInjected.Address(RVA = "0x559B580", Offset = "0x559A380", VA = "0x18559B580", Slot = "8")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60002E8")]
		[Cpp2IlInjected.Address(RVA = "0x559C9E0", Offset = "0x559B7E0", VA = "0x18559C9E0", Slot = "9")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400002E")]
	public event Action JJAIAHJNGIG
	{
		[Cpp2IlInjected.Token(Token = "0x60002E9")]
		[Cpp2IlInjected.Address(RVA = "0x559D8F0", Offset = "0x559C6F0", VA = "0x18559D8F0", Slot = "10")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60002EA")]
		[Cpp2IlInjected.Address(RVA = "0x559CEB0", Offset = "0x559BCB0", VA = "0x18559CEB0", Slot = "11")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400002F")]
	public event Action IDANOOMLEFH
	{
		[Cpp2IlInjected.Token(Token = "0x60002EB")]
		[Cpp2IlInjected.Address(RVA = "0x559CE10", Offset = "0x559BC10", VA = "0x18559CE10", Slot = "12")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60002EC")]
		[Cpp2IlInjected.Address(RVA = "0x559CCA0", Offset = "0x559BAA0", VA = "0x18559CCA0", Slot = "13")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000030")]
	public event Action<DDICDNFJGFA> INPHGDBFJHB
	{
		[Cpp2IlInjected.Token(Token = "0x60002ED")]
		[Cpp2IlInjected.Address(RVA = "0x559B4E0", Offset = "0x559A2E0", VA = "0x18559B4E0", Slot = "14")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60002EE")]
		[Cpp2IlInjected.Address(RVA = "0x559C780", Offset = "0x559B580", VA = "0x18559C780", Slot = "15")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000031")]
	public event Action<DDICDNFJGFA> CHMJFGPAGAO
	{
		[Cpp2IlInjected.Token(Token = "0x60002EF")]
		[Cpp2IlInjected.Address(RVA = "0x559B6C0", Offset = "0x559A4C0", VA = "0x18559B6C0", Slot = "16")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60002F0")]
		[Cpp2IlInjected.Address(RVA = "0x559C140", Offset = "0x559AF40", VA = "0x18559C140", Slot = "17")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000032")]
	public event Action FGJJDPPMNOO
	{
		[Cpp2IlInjected.Token(Token = "0x60002F1")]
		[Cpp2IlInjected.Address(RVA = "0x559CD70", Offset = "0x559BB70", VA = "0x18559CD70", Slot = "18")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60002F2")]
		[Cpp2IlInjected.Address(RVA = "0x559CB00", Offset = "0x559B900", VA = "0x18559CB00", Slot = "19")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000033")]
	public event Action<DDICDNFJGFA> KGIEOHODPBB
	{
		[Cpp2IlInjected.Token(Token = "0x60002F3")]
		[Cpp2IlInjected.Address(RVA = "0x559D240", Offset = "0x559C040", VA = "0x18559D240", Slot = "20")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60002F4")]
		[Cpp2IlInjected.Address(RVA = "0x559D420", Offset = "0x559C220", VA = "0x18559D420", Slot = "21")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60002E2")]
	[Cpp2IlInjected.Address(RVA = "0x559DA30", Offset = "0x559C830", VA = "0x18559DA30")]
	public JPLCBCDLMEH(DDICDNFJGFA FBJBBGAMODK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002F6")]
	[Cpp2IlInjected.Address(RVA = "0x559C5B0", Offset = "0x559B3B0", VA = "0x18559C5B0", Slot = "27")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002FF")]
	[Cpp2IlInjected.Address(RVA = "0x559C050", Offset = "0x559AE50", VA = "0x18559C050", Slot = "26")]
	public void CNEDMMKBPIO(DDICDNFJGFA BANCJNAJPLD, bool BNLMFCPNEHF = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000300")]
	[Cpp2IlInjected.Address(RVA = "0x559C0D0", Offset = "0x559AED0", VA = "0x18559C0D0")]
	private void CNEDMMKBPIO(BCENEGCNGJI BANCJNAJPLD, bool BNLMFCPNEHF = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000301")]
	[Cpp2IlInjected.Address(RVA = "0x559B7D0", Offset = "0x559A5D0", VA = "0x18559B7D0")]
	private void CIKEOJNLONE(BCENEGCNGJI BANCJNAJPLD, bool BNLMFCPNEHF = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000302")]
	[Cpp2IlInjected.Address(RVA = "0x559C820", Offset = "0x559B620", VA = "0x18559C820")]
	private void EKJAOBEDMKJ(BCENEGCNGJI KJJPIPKOFKF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000303")]
	[Cpp2IlInjected.Address(RVA = "0x559D5F0", Offset = "0x559C3F0", VA = "0x18559D5F0")]
	private void NHBEELLHAIH(BCENEGCNGJI KJJPIPKOFKF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000304")]
	[Cpp2IlInjected.Address(RVA = "0x559C310", Offset = "0x559B110", VA = "0x18559C310")]
	private void DNLCEJLCJMJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000305")]
	[Cpp2IlInjected.Address(RVA = "0x559CA80", Offset = "0x559B880", VA = "0x18559CA80")]
	private void FGPEIDKNALP(BCENEGCNGJI KJJPIPKOFKF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000306")]
	[Cpp2IlInjected.Address(RVA = "0x559CF50", Offset = "0x559BD50", VA = "0x18559CF50")]
	private void JCFFDMEDCCE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000307")]
	[Cpp2IlInjected.Address(RVA = "0x559B3B0", Offset = "0x559A1B0", VA = "0x18559B3B0")]
	private void ADLPDPOLJPI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000308")]
	[Cpp2IlInjected.Address(RVA = "0x559C1E0", Offset = "0x559AFE0", VA = "0x18559C1E0")]
	private void DCMJCJJFMCK(BCENEGCNGJI FBJBBGAMODK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000309")]
	[Cpp2IlInjected.Address(RVA = "0x559D4C0", Offset = "0x559C2C0", VA = "0x18559D4C0")]
	private void NFAGHCDLJNP(BCENEGCNGJI FBJBBGAMODK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600030A")]
	[Cpp2IlInjected.Address(RVA = "0x559CBA0", Offset = "0x559B9A0", VA = "0x18559CBA0")]
	[CompilerGenerated]
	private object FLBFOGNPAKK()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000031")]
internal static class MHMDPPGEDAH
{
	[Cpp2IlInjected.Token(Token = "0x600030B")]
	[Cpp2IlInjected.Address(RVA = "0x55A6ED0", Offset = "0x55A5CD0", VA = "0x1855A6ED0")]
	public static JPLCBCDLMEH ACGHEKPJOAH(this DDICDNFJGFA HLKJMHJNLMO)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000032")]
internal sealed class OFFIPDEOIDO : LDGABKDBCIL, GAMDKECCFOL
{
	[Cpp2IlInjected.Token(Token = "0x170000CE")]
	public Vector3 DBPFBEOHHOL
	{
		[Cpp2IlInjected.Token(Token = "0x600030D")]
		[Cpp2IlInjected.Address(RVA = "0x55AD420", Offset = "0x55AC220", VA = "0x1855AD420", Slot = "4")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000CF")]
	public Vector3 DCGLBLKOGAP
	{
		[Cpp2IlInjected.Token(Token = "0x600030E")]
		[Cpp2IlInjected.Address(RVA = "0x55AD710", Offset = "0x55AC510", VA = "0x1855AD710", Slot = "5")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000D0")]
	private Vector3 PJGMOGHAPMH
	{
		[Cpp2IlInjected.Token(Token = "0x6000312")]
		[Cpp2IlInjected.Address(RVA = "0x55ADF90", Offset = "0x55ACD90", VA = "0x1855ADF90")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000D1")]
	private DDICDNFJGFA DNBEEAPENJJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000313")]
		[Cpp2IlInjected.Address(RVA = "0x55ADE30", Offset = "0x55ACC30", VA = "0x1855ADE30")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600030C")]
	[Cpp2IlInjected.Address(RVA = "0x558DE30", Offset = "0x558CC30", VA = "0x18558DE30")]
	public OFFIPDEOIDO(DDICDNFJGFA FBJBBGAMODK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600030F")]
	[Cpp2IlInjected.Address(RVA = "0x55AD450", Offset = "0x55AC250", VA = "0x1855AD450", Slot = "6")]
	public void EIAOPGGEIPG(DDICDNFJGFA AABHIBJPKOH, object INDCJAMMAIN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000310")]
	[Cpp2IlInjected.Address(RVA = "0x55AD5E0", Offset = "0x55AC3E0", VA = "0x1855AD5E0")]
	private void EIAOPGGEIPG(BCENEGCNGJI AABHIBJPKOH, object INDCJAMMAIN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000311")]
	[Cpp2IlInjected.Address(RVA = "0x55AD950", Offset = "0x55AC750", VA = "0x1855AD950", Slot = "7")]
	public void KKMNIALJMDA(object INDCJAMMAIN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000314")]
	[Cpp2IlInjected.Address(RVA = "0x55ADA40", Offset = "0x55AC840", VA = "0x1855ADA40")]
	private Vector3 MADOJPBPDNM()
	{
		return default(Vector3);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000033")]
internal static class LMKDIFGNIJN
{
	[Cpp2IlInjected.Token(Token = "0x6000315")]
	[Cpp2IlInjected.Address(RVA = "0x55A6750", Offset = "0x55A5550", VA = "0x1855A6750")]
	public static OFFIPDEOIDO GCPGGOCMMEB(this DDICDNFJGFA HLKJMHJNLMO)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000034")]
internal sealed class POLCHEMLPFN : LDGABKDBCIL, MLLKELEPLJE
{
	[Cpp2IlInjected.Token(Token = "0x170000D2")]
	public Vector3 CDOEBEFDAIG
	{
		[Cpp2IlInjected.Token(Token = "0x6000319")]
		[Cpp2IlInjected.Address(RVA = "0x55B1E40", Offset = "0x55B0C40", VA = "0x1855B1E40", Slot = "6")]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x600031A")]
		[Cpp2IlInjected.Address(RVA = "0x55B2540", Offset = "0x55B1340", VA = "0x1855B2540", Slot = "7")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000D3")]
	public Vector3 HDLNEGJCDGD
	{
		[Cpp2IlInjected.Token(Token = "0x600031B")]
		[Cpp2IlInjected.Address(RVA = "0x55B35A0", Offset = "0x55B23A0", VA = "0x1855B35A0", Slot = "8")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000D4")]
	public float AANJNIAMGBP
	{
		[Cpp2IlInjected.Token(Token = "0x600031C")]
		[Cpp2IlInjected.Address(RVA = "0x55B2850", Offset = "0x55B1650", VA = "0x1855B2850", Slot = "9")]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x600031D")]
		[Cpp2IlInjected.Address(RVA = "0x55B3960", Offset = "0x55B2760", VA = "0x1855B3960")]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000D5")]
	public float LJPJENEPPAO
	{
		[Cpp2IlInjected.Token(Token = "0x600031E")]
		[Cpp2IlInjected.Address(RVA = "0x55B36C0", Offset = "0x55B24C0", VA = "0x1855B36C0", Slot = "10")]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x600031F")]
		[Cpp2IlInjected.Address(RVA = "0x55B2D50", Offset = "0x55B1B50", VA = "0x1855B2D50", Slot = "11")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000D6")]
	public Vector3 OLHILDGADHC
	{
		[Cpp2IlInjected.Token(Token = "0x6000320")]
		[Cpp2IlInjected.Address(RVA = "0x55B2D60", Offset = "0x55B1B60", VA = "0x1855B2D60", Slot = "12")]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x6000321")]
		[Cpp2IlInjected.Address(RVA = "0x55B4D40", Offset = "0x55B3B40", VA = "0x1855B4D40", Slot = "13")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000D7")]
	public Quaternion FPHMFIFGALL
	{
		[Cpp2IlInjected.Token(Token = "0x6000322")]
		[Cpp2IlInjected.Address(RVA = "0x55B1E10", Offset = "0x55B0C10", VA = "0x1855B1E10", Slot = "14")]
		get
		{
			return default(Quaternion);
		}
		[Cpp2IlInjected.Token(Token = "0x6000323")]
		[Cpp2IlInjected.Address(RVA = "0x55B4D70", Offset = "0x55B3B70", VA = "0x1855B4D70", Slot = "15")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000D8")]
	private Rigidbody AMAINOJCLLB
	{
		[Cpp2IlInjected.Token(Token = "0x600032B")]
		[Cpp2IlInjected.Address(RVA = "0x558F170", Offset = "0x558DF70", VA = "0x18558F170")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000034")]
	public event IJDKLAGCEFG MFGECJGMKFM
	{
		[Cpp2IlInjected.Token(Token = "0x6000316")]
		[Cpp2IlInjected.Address(RVA = "0x55B32D0", Offset = "0x55B20D0", VA = "0x1855B32D0", Slot = "4")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000317")]
		[Cpp2IlInjected.Address(RVA = "0x55B37A0", Offset = "0x55B25A0", VA = "0x1855B37A0", Slot = "5")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000318")]
	[Cpp2IlInjected.Address(RVA = "0x55B4FC0", Offset = "0x55B3DC0", VA = "0x1855B4FC0")]
	public POLCHEMLPFN(DDICDNFJGFA FBJBBGAMODK, in GPHOCGFKAIA PHAPMEHMHAK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000324")]
	[Cpp2IlInjected.Address(RVA = "0x55B2B40", Offset = "0x55B1940", VA = "0x1855B2B40", Slot = "17")]
	public void GBIGLFOHPKF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000325")]
	[Cpp2IlInjected.Address(RVA = "0x55B3970", Offset = "0x55B2770", VA = "0x1855B3970", Slot = "16")]
	public void NFCCEAJGIIH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000326")]
	[Cpp2IlInjected.Address(RVA = "0x55B19E0", Offset = "0x55B07E0", VA = "0x1855B19E0", Slot = "19")]
	public void AEBCBAGKFLD(Rigidbody EMPCHDNCBNN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000327")]
	[Cpp2IlInjected.Address(RVA = "0x55B2F50", Offset = "0x55B1D50", VA = "0x1855B2F50", Slot = "20")]
	public void IEECHEIALJL(Rigidbody EMPCHDNCBNN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000328")]
	[Cpp2IlInjected.Address(RVA = "0x55B1F70", Offset = "0x55B0D70", VA = "0x1855B1F70", Slot = "18")]
	public void DCKPFKGOBFJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000329")]
	[Cpp2IlInjected.Address(RVA = "0x55B2050", Offset = "0x55B0E50", VA = "0x1855B2050", Slot = "21")]
	public void EGDEMHMFAIF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600032A")]
	[Cpp2IlInjected.Address(RVA = "0x559E800", Offset = "0x559D600", VA = "0x18559E800")]
	public void BDNJKNADDAG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600032C")]
	[Cpp2IlInjected.Address(RVA = "0x55B2540", Offset = "0x55B1340", VA = "0x1855B2540")]
	private void EILFHKFGLGP(Vector3 NLHFEJHKLAH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600032D")]
	[Cpp2IlInjected.Address(RVA = "0x55B3840", Offset = "0x55B2640", VA = "0x1855B3840")]
	private Vector3 LIJEPHNNHCF()
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x600032E")]
	[Cpp2IlInjected.Address(RVA = "0x55B2680", Offset = "0x55B1480", VA = "0x1855B2680")]
	private void ENLGJFLNHCE(float NLHFEJHKLAH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600032F")]
	[Cpp2IlInjected.Address(RVA = "0x55B2D90", Offset = "0x55B1B90", VA = "0x1855B2D90")]
	private void GODBLHBGMJM(float NLHFEJHKLAH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000330")]
	[Cpp2IlInjected.Address(RVA = "0x55B4D90", Offset = "0x55B3B90", VA = "0x1855B4D90")]
	private Vector3 PHDHHMMNCJO()
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000331")]
	[Cpp2IlInjected.Address(RVA = "0x55B3370", Offset = "0x55B2170", VA = "0x1855B3370")]
	private void JCKOFPAMPDD(Vector3 NLHFEJHKLAH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000332")]
	[Cpp2IlInjected.Address(RVA = "0x55B2930", Offset = "0x55B1730", VA = "0x1855B2930")]
	private Quaternion FOHIFPKJGHF()
	{
		return default(Quaternion);
	}

	[Cpp2IlInjected.Token(Token = "0x6000333")]
	[Cpp2IlInjected.Address(RVA = "0x55B1C00", Offset = "0x55B0A00", VA = "0x1855B1C00")]
	private void ALHMKJJBOEE(Quaternion NLHFEJHKLAH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000334")]
	[Cpp2IlInjected.Address(RVA = "0x55B3CF0", Offset = "0x55B2AF0", VA = "0x1855B3CF0")]
	internal (float, Vector3) OFDNBGNKKFI(Rigidbody PEDELFDFMBN)
	{
		return default((float, Vector3));
	}
}
[Cpp2IlInjected.Token(Token = "0x2000035")]
internal static class GBJAMCAHDJM
{
	[Cpp2IlInjected.Token(Token = "0x6000335")]
	[Cpp2IlInjected.Address(RVA = "0x5590440", Offset = "0x558F240", VA = "0x185590440")]
	public static POLCHEMLPFN GOMPCBPMAPG(this DDICDNFJGFA HLKJMHJNLMO)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000036")]
internal sealed class BJCDCIBJDGM : LDGABKDBCIL, FNGFIPOFFHP
{
	[Cpp2IlInjected.Token(Token = "0x4000052")]
	private const string LPPGLCIKIAN = "INTERP_PAUSE";

	[Cpp2IlInjected.Token(Token = "0x170000D9")]
	public bool LLNBAIOGACO
	{
		[Cpp2IlInjected.Token(Token = "0x6000336")]
		[Cpp2IlInjected.Address(RVA = "0x558D2E0", Offset = "0x558C0E0", VA = "0x18558D2E0", Slot = "4")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000DA")]
	public HOMJCDNLJOD ABGIIBAPFBG
	{
		[Cpp2IlInjected.Token(Token = "0x6000337")]
		[Cpp2IlInjected.Address(RVA = "0x558CE90", Offset = "0x558BC90", VA = "0x18558CE90", Slot = "5")]
		get
		{
			return default(HOMJCDNLJOD);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000DB")]
	private HOMJCDNLJOD LFLFHCFBEOE
	{
		[Cpp2IlInjected.Token(Token = "0x6000339")]
		[Cpp2IlInjected.Address(RVA = "0x558D040", Offset = "0x558BE40", VA = "0x18558D040")]
		get
		{
			return default(HOMJCDNLJOD);
		}
		[Cpp2IlInjected.Token(Token = "0x600033A")]
		[Cpp2IlInjected.Address(RVA = "0x558CBD0", Offset = "0x558B9D0", VA = "0x18558CBD0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000338")]
	[Cpp2IlInjected.Address(RVA = "0x558D4B0", Offset = "0x558C2B0", VA = "0x18558D4B0")]
	public BJCDCIBJDGM(DDICDNFJGFA FBJBBGAMODK, in GPHOCGFKAIA PHAPMEHMHAK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600033B")]
	[Cpp2IlInjected.Address(RVA = "0x558D120", Offset = "0x558BF20", VA = "0x18558D120", Slot = "6")]
	public void LOAKFOBCBAO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600033C")]
	[Cpp2IlInjected.Address(RVA = "0x558CEA0", Offset = "0x558BCA0", VA = "0x18558CEA0")]
	private bool IAACJGELNIB()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600033D")]
	[Cpp2IlInjected.Address(RVA = "0x558D1E0", Offset = "0x558BFE0", VA = "0x18558D1E0", Slot = "7")]
	public void NGJAOFAIFPF(object INDCJAMMAIN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600033E")]
	[Cpp2IlInjected.Address(RVA = "0x558CF40", Offset = "0x558BD40", VA = "0x18558CF40", Slot = "8")]
	public void IBBAPFLAMBM(object INDCJAMMAIN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600033F")]
	[Cpp2IlInjected.Address(RVA = "0x558CAC0", Offset = "0x558B8C0", VA = "0x18558CAC0", Slot = "11")]
	public void BCLJJENKLCM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000340")]
	[Cpp2IlInjected.Address(RVA = "0x558D3C0", Offset = "0x558C1C0", VA = "0x18558D3C0")]
	private void PCABIMHBCHM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000341")]
	[Cpp2IlInjected.Address(RVA = "0x558CCC0", Offset = "0x558BAC0", VA = "0x18558CCC0")]
	private void DINEDIMJAEA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000342")]
	[Cpp2IlInjected.Address(RVA = "0x558CE50", Offset = "0x558BC50", VA = "0x18558CE50", Slot = "10")]
	public void FCMKCNHPIFE(DDICDNFJGFA FBJBBGAMODK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000343")]
	[Cpp2IlInjected.Address(RVA = "0x558CE10", Offset = "0x558BC10", VA = "0x18558CE10", Slot = "9")]
	public void EBNFJGBDCKK(DDICDNFJGFA FBJBBGAMODK)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000037")]
internal sealed class MAOHAGGPMJE : LDGABKDBCIL, BEAHDHOKNPM
{
	[Cpp2IlInjected.Token(Token = "0x170000DC")]
	public bool MJPGFBJBMBL
	{
		[Cpp2IlInjected.Token(Token = "0x6000346")]
		[Cpp2IlInjected.Address(RVA = "0x55A6D20", Offset = "0x55A5B20", VA = "0x1855A6D20", Slot = "6")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000DD")]
	public IEnumerable<object> OPFBLMNLHBG
	{
		[Cpp2IlInjected.Token(Token = "0x6000347")]
		[Cpp2IlInjected.Address(RVA = "0x55A6A70", Offset = "0x55A5870", VA = "0x1855A6A70", Slot = "7")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000DE")]
	private bool OPDPGHBAEOG
	{
		[Cpp2IlInjected.Token(Token = "0x6000348")]
		[Cpp2IlInjected.Address(RVA = "0x55A6C30", Offset = "0x55A5A30", VA = "0x1855A6C30")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000035")]
	public event IJDKLAGCEFG ALPMDICHCGA
	{
		[Cpp2IlInjected.Token(Token = "0x6000344")]
		[Cpp2IlInjected.Address(RVA = "0x55A6B50", Offset = "0x55A5950", VA = "0x1855A6B50", Slot = "4")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000345")]
		[Cpp2IlInjected.Address(RVA = "0x55A69D0", Offset = "0x55A57D0", VA = "0x1855A69D0", Slot = "5")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000349")]
	[Cpp2IlInjected.Address(RVA = "0x558DE30", Offset = "0x558CC30", VA = "0x18558DE30")]
	public MAOHAGGPMJE(DDICDNFJGFA FBJBBGAMODK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600034A")]
	[Cpp2IlInjected.Address(RVA = "0x55A6DE0", Offset = "0x55A5BE0", VA = "0x1855A6DE0", Slot = "11")]
	public IDisposable PAOMLEGBIMN()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600034B")]
	[Cpp2IlInjected.Address(RVA = "0x55A6D10", Offset = "0x55A5B10", VA = "0x1855A6D10", Slot = "8")]
	public void MBDADCCBFHH(object INDCJAMMAIN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600034C")]
	[Cpp2IlInjected.Address(RVA = "0x55A6C20", Offset = "0x55A5A20", VA = "0x1855A6C20", Slot = "9")]
	public void JKKBAAMOMNK(object INDCJAMMAIN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600034D")]
	[Cpp2IlInjected.Address(RVA = "0x55A6850", Offset = "0x55A5650", VA = "0x1855A6850", Slot = "10")]
	public void DNFBGHHNNHM(object INDCJAMMAIN, bool NKIGKALHKKG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600034E")]
	[Cpp2IlInjected.Address(RVA = "0x55A67E0", Offset = "0x55A55E0", VA = "0x1855A67E0", Slot = "12")]
	public void AEBCBAGKFLD(Rigidbody EBGNLMABMPJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600034F")]
	[Cpp2IlInjected.Address(RVA = "0x55A6BF0", Offset = "0x55A59F0", VA = "0x1855A6BF0", Slot = "13")]
	public void IEECHEIALJL(Rigidbody EMPCHDNCBNN)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000038")]
internal sealed class AKNADNPEJBJ : LDGABKDBCIL, DLGODMNJHEI, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000055")]
	private PhotonView PADBKMIMBKI;

	[Cpp2IlInjected.Token(Token = "0x170000DF")]
	public bool HJEPBPJAOBD
	{
		[Cpp2IlInjected.Token(Token = "0x6000352")]
		[Cpp2IlInjected.Address(RVA = "0x558B840", Offset = "0x558A640", VA = "0x18558B840", Slot = "6")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000E0")]
	public bool BCEMFENGFMG
	{
		[Cpp2IlInjected.Token(Token = "0x6000353")]
		[Cpp2IlInjected.Address(RVA = "0x558C0E0", Offset = "0x558AEE0", VA = "0x18558C0E0", Slot = "7")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000036")]
	public event IJDKLAGCEFG OIHJCECPHEI
	{
		[Cpp2IlInjected.Token(Token = "0x6000350")]
		[Cpp2IlInjected.Address(RVA = "0x558B300", Offset = "0x558A100", VA = "0x18558B300", Slot = "4")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000351")]
		[Cpp2IlInjected.Address(RVA = "0x558B590", Offset = "0x558A390", VA = "0x18558B590", Slot = "5")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000354")]
	[Cpp2IlInjected.Address(RVA = "0x558C1F0", Offset = "0x558AFF0", VA = "0x18558C1F0")]
	public AKNADNPEJBJ(DDICDNFJGFA FBJBBGAMODK, in GPHOCGFKAIA PHAPMEHMHAK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000355")]
	[Cpp2IlInjected.Address(RVA = "0x558BF90", Offset = "0x558AD90", VA = "0x18558BF90", Slot = "8")]
	public void LOAKFOBCBAO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000356")]
	[Cpp2IlInjected.Address(RVA = "0x558B3A0", Offset = "0x558A1A0", VA = "0x18558B3A0", Slot = "11")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000357")]
	[Cpp2IlInjected.Address(RVA = "0x558BD80", Offset = "0x558AB80", VA = "0x18558BD80", Slot = "9")]
	public void LJCPKLHMCNP(DDICDNFJGFA AABHIBJPKOH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000358")]
	[Cpp2IlInjected.Address(RVA = "0x558B630", Offset = "0x558A430", VA = "0x18558B630", Slot = "10")]
	public void GNGIENKKJBL(DDICDNFJGFA AABHIBJPKOH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000359")]
	[Cpp2IlInjected.Address(RVA = "0x558BA30", Offset = "0x558A830", VA = "0x18558BA30")]
	private void KLKNNHDEOCL(PhotonView BOMECHFAFIA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600035A")]
	[Cpp2IlInjected.Address(RVA = "0x558BC20", Offset = "0x558AA20", VA = "0x18558BC20")]
	private void LGPNLNCNAKA(RigidbodyEx HHGLALPDJJA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600035B")]
	[Cpp2IlInjected.Address(RVA = "0x558B860", Offset = "0x558A660", VA = "0x18558B860")]
	private void IFJKCLJGPIH(PhotonView BPDDMBDBBEB)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000039")]
internal static class ICCBKNCIKEC
{
	[Cpp2IlInjected.Token(Token = "0x600035C")]
	[Cpp2IlInjected.Address(RVA = "0x5594710", Offset = "0x5593510", VA = "0x185594710")]
	public static AKNADNPEJBJ DCJCLGPHNIE(this LGAGFCAGMMC HLKJMHJNLMO)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200003A")]
internal sealed class DKBCGJCCDCH : LDGABKDBCIL, DKCDJJILPGD
{
	[Cpp2IlInjected.Token(Token = "0x170000E1")]
	public bool DKOAFEFPELM
	{
		[Cpp2IlInjected.Token(Token = "0x600035D")]
		[Cpp2IlInjected.Address(RVA = "0x558E650", Offset = "0x558D450", VA = "0x18558E650", Slot = "4")]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x600035E")]
		[Cpp2IlInjected.Address(RVA = "0x558E2A0", Offset = "0x558D0A0", VA = "0x18558E2A0", Slot = "5")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000E2")]
	public bool MLGKJIBDAPE
	{
		[Cpp2IlInjected.Token(Token = "0x600035F")]
		[Cpp2IlInjected.Address(RVA = "0x558E490", Offset = "0x558D290", VA = "0x18558E490", Slot = "6")]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000360")]
		[Cpp2IlInjected.Address(RVA = "0x558E1B0", Offset = "0x558CFB0", VA = "0x18558E1B0")]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000E3")]
	public RigidbodyConstraints PDLJENDCEHJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000361")]
		[Cpp2IlInjected.Address(RVA = "0x558E570", Offset = "0x558D370", VA = "0x18558E570", Slot = "7")]
		get
		{
			return default(RigidbodyConstraints);
		}
		[Cpp2IlInjected.Token(Token = "0x6000362")]
		[Cpp2IlInjected.Address(RVA = "0x558DFB0", Offset = "0x558CDB0", VA = "0x18558DFB0", Slot = "8")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000363")]
	[Cpp2IlInjected.Address(RVA = "0x558E730", Offset = "0x558D530", VA = "0x18558E730")]
	public DKBCGJCCDCH(DDICDNFJGFA FBJBBGAMODK, in GPHOCGFKAIA PHAPMEHMHAK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000364")]
	[Cpp2IlInjected.Address(RVA = "0x558DEB0", Offset = "0x558CCB0", VA = "0x18558DEB0", Slot = "9")]
	public void AEBCBAGKFLD(Rigidbody EMPCHDNCBNN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000365")]
	[Cpp2IlInjected.Address(RVA = "0x558E390", Offset = "0x558D190", VA = "0x18558E390", Slot = "10")]
	public void IEECHEIALJL(Rigidbody EMPCHDNCBNN)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200003B")]
internal sealed class PKEHGFADCCH : LDGABKDBCIL, CJKBMGEKBFD
{
	[Cpp2IlInjected.Token(Token = "0x170000E4")]
	public float EGNLMBHDOFH
	{
		[Cpp2IlInjected.Token(Token = "0x6000367")]
		[Cpp2IlInjected.Address(RVA = "0x55B1900", Offset = "0x55B0700", VA = "0x1855B1900", Slot = "4")]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x6000368")]
		[Cpp2IlInjected.Address(RVA = "0x55B13B0", Offset = "0x55B01B0", VA = "0x1855B13B0", Slot = "5")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000E5")]
	public float NPBKEBDHMEK
	{
		[Cpp2IlInjected.Token(Token = "0x6000369")]
		[Cpp2IlInjected.Address(RVA = "0x55B1750", Offset = "0x55B0550", VA = "0x1855B1750", Slot = "6")]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x600036A")]
		[Cpp2IlInjected.Address(RVA = "0x55B1580", Offset = "0x55B0380", VA = "0x1855B1580", Slot = "7")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000366")]
	[Cpp2IlInjected.Address(RVA = "0x558DE30", Offset = "0x558CC30", VA = "0x18558DE30")]
	public PKEHGFADCCH(DDICDNFJGFA FBJBBGAMODK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600036B")]
	[Cpp2IlInjected.Address(RVA = "0x55B11E0", Offset = "0x55AFFE0", VA = "0x1855B11E0", Slot = "8")]
	public void AEBCBAGKFLD(Rigidbody EMPCHDNCBNN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600036C")]
	[Cpp2IlInjected.Address(RVA = "0x55B1830", Offset = "0x55B0630", VA = "0x1855B1830", Slot = "9")]
	public void IEECHEIALJL(Rigidbody EMPCHDNCBNN)
	{
	}
}
namespace RecRoom.Rbex.ObjectModel
{
	[Cpp2IlInjected.Token(Token = "0x200003C")]
	[IHOFDNBJLIN(typeof(ONAHJACNKFM), new string[] { })]
	[IDOCBBAEIFB(JHEANMHFGAO.Physics)]
	public sealed class RbexServiceCallbacks : OMEPFIBEFCP, ONAHJACNKFM, IDisposable
	{
		[Cpp2IlInjected.Token(Token = "0x4000056")]
		private static readonly JFPIEAPAMJM MCHCOEKKPGN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000057")]
		private EKNANNBDCIH FBJBBGAMODK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000058")]
		private bool LKLAHNKMKAI;

		[Cpp2IlInjected.Token(Token = "0x170000E6")]
		public bool NOIGHNNNJBE
		{
			[Cpp2IlInjected.Token(Token = "0x600036F")]
			[Cpp2IlInjected.Address(RVA = "0x76B430", Offset = "0x76A230", VA = "0x18076B430", Slot = "5")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600036D")]
		[Cpp2IlInjected.Address(RVA = "0x65B3410", Offset = "0x65B2210", VA = "0x1865B3410", Slot = "4")]
		public void PIFNIFBDCBM(AACHPGDKAKL PIMEDEKHCHH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600036E")]
		[Cpp2IlInjected.Address(RVA = "0x65B3130", Offset = "0x65B1F30", VA = "0x1865B3130", Slot = "7")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000370")]
		[Cpp2IlInjected.Address(RVA = "0x65B3160", Offset = "0x65B1F60", VA = "0x1865B3160", Slot = "6")]
		public void OFDNBGNKKFI(IMKMJFJEHIJ NAKKFJMFOAE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000371")]
		[Cpp2IlInjected.Address(RVA = "0x6ECCD0", Offset = "0x6EBAD0", VA = "0x1806ECCD0")]
		public RbexServiceCallbacks()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200003D")]
internal sealed class KFBPFDHAIOC : LDGABKDBCIL, POBKPFCFBME
{
	[Cpp2IlInjected.Token(Token = "0x4000059")]
	public const int GPOBOJJCCAO = 10;

	[Cpp2IlInjected.Token(Token = "0x400005A")]
	public const float IFBKGDFGGOH = 9E-05f;

	[Cpp2IlInjected.Token(Token = "0x400005B")]
	public const float PEKOFFEBAOJ = 0.0001f;

	[Cpp2IlInjected.Token(Token = "0x400005C")]
	public const float CGNJMCKHGCP = 5f;

	[Cpp2IlInjected.Token(Token = "0x170000E7")]
	private Rigidbody AMAINOJCLLB
	{
		[Cpp2IlInjected.Token(Token = "0x6000375")]
		[Cpp2IlInjected.Address(RVA = "0x558F170", Offset = "0x558DF70", VA = "0x18558F170")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000E8")]
	private bool PFNGAONDKCN
	{
		[Cpp2IlInjected.Token(Token = "0x6000376")]
		[Cpp2IlInjected.Address(RVA = "0x559EA60", Offset = "0x559D860", VA = "0x18559EA60")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000E9")]
	private bool BIBDGFIAGJM
	{
		[Cpp2IlInjected.Token(Token = "0x6000377")]
		[Cpp2IlInjected.Address(RVA = "0x5596E10", Offset = "0x5595C10", VA = "0x185596E10")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000EA")]
	private DDICDNFJGFA KFPCMBOLNGI
	{
		[Cpp2IlInjected.Token(Token = "0x6000378")]
		[Cpp2IlInjected.Address(RVA = "0x559E460", Offset = "0x559D260", VA = "0x18559E460")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000EB")]
	private bool FGHFGPDIBIE
	{
		[Cpp2IlInjected.Token(Token = "0x6000379")]
		[Cpp2IlInjected.Address(RVA = "0x559E2B0", Offset = "0x559D0B0", VA = "0x18559E2B0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000EC")]
	private bool GHIEKBFJGGP
	{
		[Cpp2IlInjected.Token(Token = "0x600037A")]
		[Cpp2IlInjected.Address(RVA = "0x559E040", Offset = "0x559CE40", VA = "0x18559E040")]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x600037B")]
		[Cpp2IlInjected.Address(RVA = "0x559E710", Offset = "0x559D510", VA = "0x18559E710")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000ED")]
	private bool DFLMGDAEICI
	{
		[Cpp2IlInjected.Token(Token = "0x600037C")]
		[Cpp2IlInjected.Address(RVA = "0x559E1D0", Offset = "0x559CFD0", VA = "0x18559E1D0")]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x600037D")]
		[Cpp2IlInjected.Address(RVA = "0x559DB70", Offset = "0x559C970", VA = "0x18559DB70")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000EE")]
	private int AJOMBDILEDB
	{
		[Cpp2IlInjected.Token(Token = "0x600037E")]
		[Cpp2IlInjected.Address(RVA = "0x559DE10", Offset = "0x559CC10", VA = "0x18559DE10")]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x600037F")]
		[Cpp2IlInjected.Address(RVA = "0x559E4C0", Offset = "0x559D2C0", VA = "0x18559E4C0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000037")]
	public event IJDKLAGCEFG JLFHAPOODCF
	{
		[Cpp2IlInjected.Token(Token = "0x6000373")]
		[Cpp2IlInjected.Address(RVA = "0x559E130", Offset = "0x559CF30", VA = "0x18559E130", Slot = "4")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000374")]
		[Cpp2IlInjected.Address(RVA = "0x559DEF0", Offset = "0x559CCF0", VA = "0x18559DEF0", Slot = "5")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000380")]
	[Cpp2IlInjected.Address(RVA = "0x559EB00", Offset = "0x559D900", VA = "0x18559EB00")]
	public KFBPFDHAIOC(DDICDNFJGFA FBJBBGAMODK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000381")]
	[Cpp2IlInjected.Address(RVA = "0x559E5B0", Offset = "0x559D3B0", VA = "0x18559E5B0", Slot = "6")]
	public void LOAKFOBCBAO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000382")]
	[Cpp2IlInjected.Address(RVA = "0x559E120", Offset = "0x559CF20", VA = "0x18559E120", Slot = "8")]
	public void GNEECPBPGHC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000383")]
	[Cpp2IlInjected.Address(RVA = "0x559E840", Offset = "0x559D640", VA = "0x18559E840", Slot = "7")]
	public bool OMBGDMJFHEI()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000384")]
	[Cpp2IlInjected.Address(RVA = "0x559E660", Offset = "0x559D460", VA = "0x18559E660", Slot = "9")]
	public void MNLNBCJHPMD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000385")]
	[Cpp2IlInjected.Address(RVA = "0x559E800", Offset = "0x559D600", VA = "0x18559E800", Slot = "12")]
	public void OKNIAACKICL(bool NOEDBDPFICH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000386")]
	[Cpp2IlInjected.Address(RVA = "0x559DF90", Offset = "0x559CD90", VA = "0x18559DF90", Slot = "11")]
	public void EDKDBDBJFEP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000387")]
	[Cpp2IlInjected.Address(RVA = "0x6ED320", Offset = "0x6EC120", VA = "0x1806ED320", Slot = "10")]
	public void GGADMLLPLHE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000388")]
	[Cpp2IlInjected.Address(RVA = "0x559DC60", Offset = "0x559CA60", VA = "0x18559DC60")]
	private bool ANHIIFAOGNF()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000389")]
	[Cpp2IlInjected.Address(RVA = "0x559E310", Offset = "0x559D110", VA = "0x18559E310")]
	private void IDKEIDAJDMP()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200003E")]
internal sealed class MHMEJHIJNDP : LDGABKDBCIL, AOJBGIGFLEC
{
	[Cpp2IlInjected.Token(Token = "0x400005E")]
	private const string DJFEDHMLDMM = "RBEX_ANIM";

	[Cpp2IlInjected.Token(Token = "0x170000EF")]
	public Rigidbody AMAINOJCLLB
	{
		[Cpp2IlInjected.Token(Token = "0x600038A")]
		[Cpp2IlInjected.Address(RVA = "0x55A7D70", Offset = "0x55A6B70", VA = "0x1855A7D70", Slot = "4")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600038B")]
		[Cpp2IlInjected.Address(RVA = "0x55A7060", Offset = "0x55A5E60", VA = "0x1855A7060")]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000F0")]
	private bool FGHFGPDIBIE
	{
		[Cpp2IlInjected.Token(Token = "0x600038C")]
		[Cpp2IlInjected.Address(RVA = "0x55981C0", Offset = "0x5596FC0", VA = "0x1855981C0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600038D")]
	[Cpp2IlInjected.Address(RVA = "0x55A7E50", Offset = "0x55A6C50", VA = "0x1855A7E50")]
	public MHMEJHIJNDP(DDICDNFJGFA FBJBBGAMODK, in GPHOCGFKAIA PHAPMEHMHAK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600038E")]
	[Cpp2IlInjected.Address(RVA = "0x55A7AF0", Offset = "0x55A68F0", VA = "0x1855A7AF0", Slot = "5")]
	public void LOAKFOBCBAO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600038F")]
	[Cpp2IlInjected.Address(RVA = "0x55A6F60", Offset = "0x55A5D60", VA = "0x1855A6F60", Slot = "6")]
	public void BGFCCCENBID(object INDCJAMMAIN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000390")]
	[Cpp2IlInjected.Address(RVA = "0x55A73B0", Offset = "0x55A61B0", VA = "0x1855A73B0", Slot = "7")]
	public void GPBOKOEIFJD(object INDCJAMMAIN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000391")]
	[Cpp2IlInjected.Address(RVA = "0x55A7670", Offset = "0x55A6470", VA = "0x1855A7670", Slot = "8")]
	public void JKEHEGMHNBP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000392")]
	[Cpp2IlInjected.Address(RVA = "0x55A7150", Offset = "0x55A5F50", VA = "0x1855A7150", Slot = "9")]
	public void FEMJINFCLKB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000393")]
	[Cpp2IlInjected.Address(RVA = "0x55A7BA0", Offset = "0x55A69A0", VA = "0x1855A7BA0", Slot = "10")]
	public void MDGAEMKGBPG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000394")]
	[Cpp2IlInjected.Address(RVA = "0x6ED320", Offset = "0x6EC120", VA = "0x1806ED320", Slot = "11")]
	public void OCGHJADDJFG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000395")]
	[Cpp2IlInjected.Address(RVA = "0x55A74B0", Offset = "0x55A62B0", VA = "0x1855A74B0")]
	private void HLEOOMPJMMG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000396")]
	[Cpp2IlInjected.Address(RVA = "0x55A7930", Offset = "0x55A6730", VA = "0x1855A7930")]
	private void LHLOOPANHAF()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200003F")]
internal sealed class NDGGMCEOMLF : LDGABKDBCIL, AOLDALECDIP, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x170000F1")]
	public MDNFIBKLANB NBOHDJLOFIN
	{
		[Cpp2IlInjected.Token(Token = "0x6000397")]
		[Cpp2IlInjected.Address(RVA = "0x55AA010", Offset = "0x55A8E10", VA = "0x1855AA010", Slot = "4")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000398")]
		[Cpp2IlInjected.Address(RVA = "0x55A90B0", Offset = "0x55A7EB0", VA = "0x1855A90B0", Slot = "5")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000F2")]
	public IGIPPOIEHFL KGJELLKCKGD
	{
		[Cpp2IlInjected.Token(Token = "0x6000399")]
		[Cpp2IlInjected.Address(RVA = "0x55AACE0", Offset = "0x55A9AE0", VA = "0x1855AACE0", Slot = "6")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600039A")]
		[Cpp2IlInjected.Address(RVA = "0x55AA480", Offset = "0x55A9280", VA = "0x1855AA480", Slot = "7")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000F3")]
	public Vector3 PJGMOGHAPMH
	{
		[Cpp2IlInjected.Token(Token = "0x600039B")]
		[Cpp2IlInjected.Address(RVA = "0x55AAF70", Offset = "0x55A9D70", VA = "0x1855AAF70", Slot = "8")]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x600039C")]
		[Cpp2IlInjected.Address(RVA = "0x55AA8A0", Offset = "0x55A96A0", VA = "0x1855AA8A0", Slot = "9")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000F4")]
	public Vector3 PLFFIHHKHOJ
	{
		[Cpp2IlInjected.Token(Token = "0x600039D")]
		[Cpp2IlInjected.Address(RVA = "0x55AA960", Offset = "0x55A9760", VA = "0x1855AA960", Slot = "10")]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x600039E")]
		[Cpp2IlInjected.Address(RVA = "0x55A8290", Offset = "0x55A7090", VA = "0x1855A8290", Slot = "11")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000F5")]
	public Vector3 BEOEJBBFCKO
	{
		[Cpp2IlInjected.Token(Token = "0x600039F")]
		[Cpp2IlInjected.Address(RVA = "0x55A8E30", Offset = "0x55A7C30", VA = "0x1855A8E30", Slot = "12")]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x60003A0")]
		[Cpp2IlInjected.Address(RVA = "0x55AB0C0", Offset = "0x55A9EC0", VA = "0x1855AB0C0", Slot = "13")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000F6")]
	public Vector3 HNKEAHNHOFC
	{
		[Cpp2IlInjected.Token(Token = "0x60003A1")]
		[Cpp2IlInjected.Address(RVA = "0x55AAE50", Offset = "0x55A9C50", VA = "0x1855AAE50", Slot = "14")]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x60003A2")]
		[Cpp2IlInjected.Address(RVA = "0x55AACB0", Offset = "0x55A9AB0", VA = "0x1855AACB0", Slot = "15")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000F7")]
	public float ELIKFBMBBPJ
	{
		[Cpp2IlInjected.Token(Token = "0x60003A3")]
		[Cpp2IlInjected.Address(RVA = "0x55AB180", Offset = "0x55A9F80", VA = "0x1855AB180", Slot = "16")]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x60003A4")]
		[Cpp2IlInjected.Address(RVA = "0x55A8DE0", Offset = "0x55A7BE0", VA = "0x1855A8DE0", Slot = "17")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000F8")]
	public bool OGCFEGMFPMP
	{
		[Cpp2IlInjected.Token(Token = "0x60003A6")]
		[Cpp2IlInjected.Address(RVA = "0x55A80F0", Offset = "0x55A6EF0", VA = "0x1855A80F0", Slot = "18")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000F9")]
	private CFLNOOGGMLK NNHFHKHABOA
	{
		[Cpp2IlInjected.Token(Token = "0x60003BA")]
		[Cpp2IlInjected.Address(RVA = "0x2082E90", Offset = "0x2081C90", VA = "0x182082E90")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000FA")]
	private bool BIBDGFIAGJM
	{
		[Cpp2IlInjected.Token(Token = "0x60003BB")]
		[Cpp2IlInjected.Address(RVA = "0x5596E10", Offset = "0x5595C10", VA = "0x185596E10")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60003A5")]
	[Cpp2IlInjected.Address(RVA = "0x558DE30", Offset = "0x558CC30", VA = "0x18558DE30")]
	public NDGGMCEOMLF(DDICDNFJGFA FBJBBGAMODK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003A7")]
	[Cpp2IlInjected.Address(RVA = "0x55A8CF0", Offset = "0x55A7AF0", VA = "0x1855A8CF0", Slot = "20")]
	public void EILCMEIBKHF(object INDCJAMMAIN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003A8")]
	[Cpp2IlInjected.Address(RVA = "0x55A9810", Offset = "0x55A8610", VA = "0x1855A9810", Slot = "31")]
	public void IKJFANGIDNB(object INDCJAMMAIN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003A9")]
	[Cpp2IlInjected.Address(RVA = "0x55A7F20", Offset = "0x55A6D20", VA = "0x1855A7F20", Slot = "19")]
	public void LOAKFOBCBAO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003AA")]
	[Cpp2IlInjected.Address(RVA = "0x55A8910", Offset = "0x55A7710", VA = "0x1855A8910", Slot = "37")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003AB")]
	[Cpp2IlInjected.Address(RVA = "0x55A7EE0", Offset = "0x55A6CE0", VA = "0x1855A7EE0", Slot = "28")]
	public void AEBCBAGKFLD(Rigidbody EMPCHDNCBNN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003AC")]
	[Cpp2IlInjected.Address(RVA = "0x55A8730", Offset = "0x55A7530", VA = "0x1855A8730", Slot = "36")]
	public Vector3 DKGOLPKDCPG(Vector3 LGHPPABOKOK)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x60003AD")]
	[Cpp2IlInjected.Address(RVA = "0x55A8A40", Offset = "0x55A7840", VA = "0x1855A8A40", Slot = "35")]
	public Vector3 EHCFPONMFKA(Vector3 AFLGANKGICH)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x60003AE")]
	[Cpp2IlInjected.Address(RVA = "0x55A7F20", Offset = "0x55A6D20", VA = "0x1855A7F20", Slot = "27")]
	public void AGCPJAHILEP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003AF")]
	[Cpp2IlInjected.Address(RVA = "0x55A8DF0", Offset = "0x55A7BF0", VA = "0x1855A8DF0", Slot = "25")]
	public void FIIAJOAMNGJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003B0")]
	[Cpp2IlInjected.Address(RVA = "0x55AAE10", Offset = "0x55A9C10", VA = "0x1855AAE10", Slot = "24")]
	public void OGCLLIMCEGK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003B1")]
	[Cpp2IlInjected.Address(RVA = "0x55AAA70", Offset = "0x55A9870", VA = "0x1855AAA70", Slot = "34")]
	public void NFJDLDDEJMF(Vector3 IMMOLPOLNBA, Vector3 OGMHJOIPEGI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003B2")]
	[Cpp2IlInjected.Address(RVA = "0x55AA840", Offset = "0x55A9640", VA = "0x1855AA840", Slot = "33")]
	public void MODKKAHENJA(Vector3 IAOEEAAKMPP, Vector3 IDJHMKHCMIA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003B3")]
	[Cpp2IlInjected.Address(RVA = "0x55A91A0", Offset = "0x55A7FA0", VA = "0x1855A91A0", Slot = "32")]
	public void GGCHAGHHFEC(Vector3 GKPHCGNAJHA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003B4")]
	[Cpp2IlInjected.Address(RVA = "0x55A82C0", Offset = "0x55A70C0", VA = "0x1855A82C0", Slot = "22")]
	public void DCKBJJIFEAA(GOIGKHJPKIL LKEHIILFBGJ, Vector3 CPJPNJCMJAL, float LJKLGGMAHOJ, float LHJEDBKLJNN = 8f, float PAKBBNDEEJP = 1f)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003B5")]
	[Cpp2IlInjected.Address(RVA = "0x55AA140", Offset = "0x55A8F40", VA = "0x1855AA140", Slot = "21")]
	public void LDIFLICNPJP(OEBNECHHPCF GDDGFGKAHMD, Vector3 BNCCLPFNHEL, float JEMKJHNONPD = float.PositiveInfinity)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003B6")]
	[Cpp2IlInjected.Address(RVA = "0x55AA570", Offset = "0x55A9370", VA = "0x1855AA570", Slot = "23")]
	[Obsolete]
	public void MKPHELIMAAE(OEBNECHHPCF GDDGFGKAHMD, Vector3 HKMKNOBAIAN, float NIDEHIHCIBC = 7f, float DLGLDDADCFL = 1f)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003B7")]
	[Cpp2IlInjected.Address(RVA = "0x55AB260", Offset = "0x55AA060", VA = "0x1855AB260", Slot = "30")]
	public Vector3 PKBLILEEDPH(Vector3 POJKCICHJIK)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x60003B8")]
	[Cpp2IlInjected.Address(RVA = "0x55A8C00", Offset = "0x55A7A00", VA = "0x1855A8C00", Slot = "29")]
	public Vector3 EIEKMNNPHJM(Vector3 EOPDAFKMAEL)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x60003B9")]
	[Cpp2IlInjected.Address(RVA = "0x55A8F80", Offset = "0x55A7D80", VA = "0x1855A8F80", Slot = "26")]
	public void FLNLDAANDPM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003BC")]
	[Cpp2IlInjected.Address(RVA = "0x55A9300", Offset = "0x55A8100", VA = "0x1855A9300")]
	private void HPMLJAFDPLE(float NLHFEJHKLAH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003BD")]
	[Cpp2IlInjected.Address(RVA = "0x55A7F90", Offset = "0x55A6D90", VA = "0x1855A7F90")]
	private void AJHFCOPCJNN(Vector3 BNCCLPFNHEL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003BE")]
	[Cpp2IlInjected.Address(RVA = "0x55AA370", Offset = "0x55A9170", VA = "0x1855AA370")]
	private Vector3 MABFLBDPGAE()
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x60003BF")]
	[Cpp2IlInjected.Address(RVA = "0x55A94D0", Offset = "0x55A82D0", VA = "0x1855A94D0")]
	private void IHLHMKLCJAF(Vector3 AFLGANKGICH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003C0")]
	[Cpp2IlInjected.Address(RVA = "0x55A9F00", Offset = "0x55A8D00", VA = "0x1855A9F00")]
	private Vector3 JMOPBFHFCID()
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x60003C1")]
	[Cpp2IlInjected.Address(RVA = "0x55AB320", Offset = "0x55AA120", VA = "0x1855AB320")]
	private void POKIOJNPKHO(Vector3 NLHFEJHKLAH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003C2")]
	[Cpp2IlInjected.Address(RVA = "0x55A9900", Offset = "0x55A8700", VA = "0x1855A9900")]
	private void JBCKPFMEHFP(Vector3 AFLGANKGICH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003C3")]
	[Cpp2IlInjected.Address(RVA = "0x55A81D0", Offset = "0x55A6FD0", VA = "0x1855A81D0")]
	private void BDJKJNDAGFI()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000040")]
internal class LDGABKDBCIL
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400005F")]
	protected readonly BCENEGCNGJI FBJBBGAMODK;

	[Cpp2IlInjected.Token(Token = "0x170000FB")]
	protected EKNANNBDCIH POPJGGBEHHH
	{
		[Cpp2IlInjected.Token(Token = "0x60003C4")]
		[Cpp2IlInjected.Address(RVA = "0xFBD030", Offset = "0xFBBE30", VA = "0x180FBD030")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000FC")]
	protected IMKMJFJEHIJ HMGKGGLBAPO
	{
		[Cpp2IlInjected.Token(Token = "0x60003C5")]
		[Cpp2IlInjected.Address(RVA = "0x55A0530", Offset = "0x559F330", VA = "0x1855A0530")]
		get
		{
			return default(IMKMJFJEHIJ);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60003C6")]
	[Cpp2IlInjected.Address(RVA = "0x558DE30", Offset = "0x558CC30", VA = "0x18558DE30")]
	public LDGABKDBCIL(DDICDNFJGFA FBJBBGAMODK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003C7")]
	[Cpp2IlInjected.Address(RVA = "0x55A0560", Offset = "0x559F360", VA = "0x1855A0560")]
	protected DDICDNFJGFA LINLOAPBLDO(IMKMJFJEHIJ LNCGECBHMHD)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000041")]
public class NEGHDFCPDCC : JBGBBADNNKI
{
	[Cpp2IlInjected.Token(Token = "0x60003C8")]
	[Cpp2IlInjected.Address(RVA = "0x55AC080", Offset = "0x55AAE80", VA = "0x1855AC080", Slot = "4")]
	public HIBPGMCCMFF ODMBDIEIOMA(DDICDNFJGFA HLKJMHJNLMO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003C9")]
	[Cpp2IlInjected.Address(RVA = "0x55ABD90", Offset = "0x55AAB90", VA = "0x1855ABD90", Slot = "5")]
	public AOLDALECDIP KNCMDJEDGGK(DDICDNFJGFA HLKJMHJNLMO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003CA")]
	[Cpp2IlInjected.Address(RVA = "0x55AB740", Offset = "0x55AA540", VA = "0x1855AB740", Slot = "6")]
	public GAMDKECCFOL AEHFFFLMJDA(DDICDNFJGFA HLKJMHJNLMO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003CB")]
	[Cpp2IlInjected.Address(RVA = "0x55AB850", Offset = "0x55AA650", VA = "0x1855AB850", Slot = "7")]
	public CJKBMGEKBFD CJKEFKMGDFF(DDICDNFJGFA HLKJMHJNLMO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003CC")]
	[Cpp2IlInjected.Address(RVA = "0x55ABED0", Offset = "0x55AACD0", VA = "0x1855ABED0", Slot = "8")]
	public POBKPFCFBME MIMODMCOGJE(DDICDNFJGFA HLKJMHJNLMO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003CD")]
	[Cpp2IlInjected.Address(RVA = "0x55ABF30", Offset = "0x55AAD30", VA = "0x1855ABF30", Slot = "9")]
	public OIINLPAMLAF MNKKINFOOKF(DDICDNFJGFA HLKJMHJNLMO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003CE")]
	[Cpp2IlInjected.Address(RVA = "0x55AB960", Offset = "0x55AA760", VA = "0x1855AB960", Slot = "10")]
	public BEAHDHOKNPM EEDOPDIIDJK(DDICDNFJGFA HLKJMHJNLMO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003CF")]
	[Cpp2IlInjected.Address(RVA = "0x55ABE30", Offset = "0x55AAC30", VA = "0x1855ABE30", Slot = "11")]
	public CFLNOOGGMLK MCAIGKKPOHN(DDICDNFJGFA HLKJMHJNLMO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003D0")]
	[Cpp2IlInjected.Address(RVA = "0x55ABCF0", Offset = "0x55AAAF0", VA = "0x1855ABCF0", Slot = "12")]
	public HFDAKPEHNOJ KNBBHFIPCJE(DDICDNFJGFA HLKJMHJNLMO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003D1")]
	[Cpp2IlInjected.Address(RVA = "0x55ABB90", Offset = "0x55AA990", VA = "0x1855ABB90", Slot = "13")]
	public NHHNBAGKHPP FNMGNBNMLED(DDICDNFJGFA HLKJMHJNLMO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003D2")]
	[Cpp2IlInjected.Address(RVA = "0x55AB680", Offset = "0x55AA480", VA = "0x1855AB680")]
	public AOJBGIGFLEC ACIELHPKKNP(DDICDNFJGFA HLKJMHJNLMO, in GPHOCGFKAIA PHAPMEHMHAK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003D3")]
	[Cpp2IlInjected.Address(RVA = "0x55ABC30", Offset = "0x55AAA30", VA = "0x1855ABC30")]
	public DLGODMNJHEI LNPJJLOGHBC(DDICDNFJGFA HLKJMHJNLMO, in GPHOCGFKAIA PHAPMEHMHAK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003D4")]
	[Cpp2IlInjected.Address(RVA = "0x55ABA00", Offset = "0x55AA800", VA = "0x1855ABA00")]
	public FNGFIPOFFHP JGEPKOMAJKF(DDICDNFJGFA HLKJMHJNLMO, in GPHOCGFKAIA PHAPMEHMHAK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003D5")]
	[Cpp2IlInjected.Address(RVA = "0x55AB7E0", Offset = "0x55AA5E0", VA = "0x1855AB7E0")]
	public MLLKELEPLJE AIFAIDNENNF(DDICDNFJGFA HLKJMHJNLMO, in GPHOCGFKAIA PHAPMEHMHAK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003D6")]
	[Cpp2IlInjected.Address(RVA = "0x55AB8F0", Offset = "0x55AA6F0", VA = "0x1855AB8F0")]
	public DKCDJJILPGD DODAKANPHCJ(DDICDNFJGFA HLKJMHJNLMO, in GPHOCGFKAIA PHAPMEHMHAK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003D7")]
	[Cpp2IlInjected.Address(RVA = "0x55ABFD0", Offset = "0x55AADD0", VA = "0x1855ABFD0", Slot = "19")]
	public DDICDNFJGFA NJANEGHFIMH(RigidbodyEx FBJBBGAMODK, GPHOCGFKAIA PHAPMEHMHAK, BABOKGOAEJI OBAPIKNALOO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003D8")]
	[Cpp2IlInjected.Address(RVA = "0x6ECCD0", Offset = "0x6EBAD0", VA = "0x1806ECCD0")]
	public NEGHDFCPDCC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003D9")]
	[Cpp2IlInjected.Address(RVA = "0x55AB680", Offset = "0x55AA480", VA = "0x1855AB680", Slot = "14")]
	private AOJBGIGFLEC MPFABIOFLCH(DDICDNFJGFA HLKJMHJNLMO, in GPHOCGFKAIA PHAPMEHMHAK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003DA")]
	[Cpp2IlInjected.Address(RVA = "0x55ABC30", Offset = "0x55AAA30", VA = "0x1855ABC30", Slot = "15")]
	private DLGODMNJHEI HGJFHGJOCMM(DDICDNFJGFA HLKJMHJNLMO, in GPHOCGFKAIA PHAPMEHMHAK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003DB")]
	[Cpp2IlInjected.Address(RVA = "0x55ABA00", Offset = "0x55AA800", VA = "0x1855ABA00", Slot = "16")]
	private FNGFIPOFFHP FBFOCLJHIDA(DDICDNFJGFA HLKJMHJNLMO, in GPHOCGFKAIA PHAPMEHMHAK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003DC")]
	[Cpp2IlInjected.Address(RVA = "0x55AB7E0", Offset = "0x55AA5E0", VA = "0x1855AB7E0", Slot = "17")]
	private MLLKELEPLJE DPCLCLENFCB(DDICDNFJGFA HLKJMHJNLMO, in GPHOCGFKAIA PHAPMEHMHAK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003DD")]
	[Cpp2IlInjected.Address(RVA = "0x55AB8F0", Offset = "0x55AA6F0", VA = "0x1855AB8F0", Slot = "18")]
	private DKCDJJILPGD PGPHKHMHHBM(DDICDNFJGFA HLKJMHJNLMO, in GPHOCGFKAIA PHAPMEHMHAK)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000042")]
[DefaultMember("Item")]
public sealed class KPDJCFBPNHB : IReadOnlyList<DDICDNFJGFA>, IEnumerable<DDICDNFJGFA>, IEnumerable, IReadOnlyCollection<DDICDNFJGFA>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000060")]
	public readonly IMKMJFJEHIJ LNCGECBHMHD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000061")]
	public readonly EKNANNBDCIH CAEONEDMKLM;

	[Cpp2IlInjected.Token(Token = "0x170000FD")]
	public int OAHKGMMAIIG
	{
		[Cpp2IlInjected.Token(Token = "0x60003E1")]
		[Cpp2IlInjected.Address(RVA = "0x55A02B0", Offset = "0x559F0B0", VA = "0x1855A02B0", Slot = "5")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000FE")]
	public DDICDNFJGFA MJCFBIMFFNK
	{
		[Cpp2IlInjected.Token(Token = "0x60003E2")]
		[Cpp2IlInjected.Address(RVA = "0x55A0380", Offset = "0x559F180", VA = "0x1855A0380", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60003DE")]
	[Cpp2IlInjected.Address(RVA = "0x55A0260", Offset = "0x559F060", VA = "0x1855A0260")]
	public KPDJCFBPNHB(IMKMJFJEHIJ LNCGECBHMHD, EKNANNBDCIH CAEONEDMKLM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003DF")]
	[Cpp2IlInjected.Address(RVA = "0x55A00D0", Offset = "0x559EED0", VA = "0x1855A00D0", Slot = "6")]
	public IEnumerator<DDICDNFJGFA> GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003E0")]
	[Cpp2IlInjected.Address(RVA = "0x55A00D0", Offset = "0x559EED0", VA = "0x1855A00D0", Slot = "7")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003E3")]
	[Cpp2IlInjected.Address(RVA = "0x55A00C0", Offset = "0x559EEC0", VA = "0x1855A00C0")]
	[CompilerGenerated]
	private DDICDNFJGFA FAJDEBHMJDB(int MHNCIMAMLJL)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000043")]
[IHOFDNBJLIN(typeof(JBGBBADNNKI), new string[] { })]
public class NFOEOADJNAE : JBGBBADNNKI, OMEPFIBEFCP
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000062")]
	private readonly JBGBBADNNKI HMEJOHCAIEP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000063")]
	private readonly JBGBBADNNKI APJIEBMMBFG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000064")]
	private NCEPMNGGADP LBJPFNIJFLL;

	[Cpp2IlInjected.Token(Token = "0x170000FF")]
	private JBGBBADNNKI BLFNNEFBJJD
	{
		[Cpp2IlInjected.Token(Token = "0x60003E5")]
		[Cpp2IlInjected.Address(RVA = "0x55AC3F0", Offset = "0x55AB1F0", VA = "0x1855AC3F0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60003E4")]
	[Cpp2IlInjected.Address(RVA = "0x55ACD50", Offset = "0x55ABB50", VA = "0x1855ACD50", Slot = "20")]
	public void PIFNIFBDCBM(AACHPGDKAKL PIMEDEKHCHH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003E6")]
	[Cpp2IlInjected.Address(RVA = "0x55ACCB0", Offset = "0x55ABAB0", VA = "0x1855ACCB0", Slot = "4")]
	public HIBPGMCCMFF ODMBDIEIOMA(DDICDNFJGFA HLKJMHJNLMO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003E7")]
	[Cpp2IlInjected.Address(RVA = "0x55AC8E0", Offset = "0x55AB6E0", VA = "0x1855AC8E0", Slot = "5")]
	public AOLDALECDIP KNCMDJEDGGK(DDICDNFJGFA HLKJMHJNLMO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003E8")]
	[Cpp2IlInjected.Address(RVA = "0x55AC2A0", Offset = "0x55AB0A0", VA = "0x1855AC2A0", Slot = "6")]
	public GAMDKECCFOL AEHFFFLMJDA(DDICDNFJGFA HLKJMHJNLMO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003E9")]
	[Cpp2IlInjected.Address(RVA = "0x55AC450", Offset = "0x55AB250", VA = "0x1855AC450", Slot = "7")]
	public CJKBMGEKBFD CJKEFKMGDFF(DDICDNFJGFA HLKJMHJNLMO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003EA")]
	[Cpp2IlInjected.Address(RVA = "0x55ACA20", Offset = "0x55AB820", VA = "0x1855ACA20", Slot = "8")]
	public POBKPFCFBME MIMODMCOGJE(DDICDNFJGFA HLKJMHJNLMO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003EB")]
	[Cpp2IlInjected.Address(RVA = "0x55ACAC0", Offset = "0x55AB8C0", VA = "0x1855ACAC0", Slot = "9")]
	public OIINLPAMLAF MNKKINFOOKF(DDICDNFJGFA HLKJMHJNLMO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003EC")]
	[Cpp2IlInjected.Address(RVA = "0x55AC5A0", Offset = "0x55AB3A0", VA = "0x1855AC5A0", Slot = "10")]
	public BEAHDHOKNPM EEDOPDIIDJK(DDICDNFJGFA HLKJMHJNLMO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003ED")]
	[Cpp2IlInjected.Address(RVA = "0x55AC980", Offset = "0x55AB780", VA = "0x1855AC980", Slot = "11")]
	public CFLNOOGGMLK MCAIGKKPOHN(DDICDNFJGFA HLKJMHJNLMO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003EE")]
	[Cpp2IlInjected.Address(RVA = "0x55AC840", Offset = "0x55AB640", VA = "0x1855AC840", Slot = "12")]
	public HFDAKPEHNOJ KNBBHFIPCJE(DDICDNFJGFA HLKJMHJNLMO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003EF")]
	[Cpp2IlInjected.Address(RVA = "0x55AC6F0", Offset = "0x55AB4F0", VA = "0x1855AC6F0", Slot = "13")]
	public NHHNBAGKHPP FNMGNBNMLED(DDICDNFJGFA HLKJMHJNLMO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003F0")]
	[Cpp2IlInjected.Address(RVA = "0x55AC1F0", Offset = "0x55AAFF0", VA = "0x1855AC1F0")]
	public AOJBGIGFLEC ACIELHPKKNP(DDICDNFJGFA HLKJMHJNLMO, in GPHOCGFKAIA PHAPMEHMHAK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003F1")]
	[Cpp2IlInjected.Address(RVA = "0x55AC790", Offset = "0x55AB590", VA = "0x1855AC790")]
	public DLGODMNJHEI LNPJJLOGHBC(DDICDNFJGFA HLKJMHJNLMO, in GPHOCGFKAIA PHAPMEHMHAK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003F2")]
	[Cpp2IlInjected.Address(RVA = "0x55AC640", Offset = "0x55AB440", VA = "0x1855AC640")]
	public FNGFIPOFFHP JGEPKOMAJKF(DDICDNFJGFA HLKJMHJNLMO, in GPHOCGFKAIA PHAPMEHMHAK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003F3")]
	[Cpp2IlInjected.Address(RVA = "0x55AC340", Offset = "0x55AB140", VA = "0x1855AC340")]
	public MLLKELEPLJE AIFAIDNENNF(DDICDNFJGFA HLKJMHJNLMO, in GPHOCGFKAIA PHAPMEHMHAK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003F4")]
	[Cpp2IlInjected.Address(RVA = "0x55AC4F0", Offset = "0x55AB2F0", VA = "0x1855AC4F0")]
	public DKCDJJILPGD DODAKANPHCJ(DDICDNFJGFA HLKJMHJNLMO, in GPHOCGFKAIA PHAPMEHMHAK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003F5")]
	[Cpp2IlInjected.Address(RVA = "0x55ACB60", Offset = "0x55AB960", VA = "0x1855ACB60", Slot = "19")]
	public DDICDNFJGFA NJANEGHFIMH(RigidbodyEx FBJBBGAMODK, GPHOCGFKAIA PHAPMEHMHAK, BABOKGOAEJI OBAPIKNALOO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003F6")]
	[Cpp2IlInjected.Address(RVA = "0x55ACDA0", Offset = "0x55ABBA0", VA = "0x1855ACDA0")]
	public NFOEOADJNAE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003F7")]
	[Cpp2IlInjected.Address(RVA = "0x55AC1F0", Offset = "0x55AAFF0", VA = "0x1855AC1F0", Slot = "14")]
	private AOJBGIGFLEC MPFABIOFLCH(DDICDNFJGFA HLKJMHJNLMO, in GPHOCGFKAIA PHAPMEHMHAK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003F8")]
	[Cpp2IlInjected.Address(RVA = "0x55AC790", Offset = "0x55AB590", VA = "0x1855AC790", Slot = "15")]
	private DLGODMNJHEI HGJFHGJOCMM(DDICDNFJGFA HLKJMHJNLMO, in GPHOCGFKAIA PHAPMEHMHAK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003F9")]
	[Cpp2IlInjected.Address(RVA = "0x55AC640", Offset = "0x55AB440", VA = "0x1855AC640", Slot = "16")]
	private FNGFIPOFFHP FBFOCLJHIDA(DDICDNFJGFA HLKJMHJNLMO, in GPHOCGFKAIA PHAPMEHMHAK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003FA")]
	[Cpp2IlInjected.Address(RVA = "0x55AC340", Offset = "0x55AB140", VA = "0x1855AC340", Slot = "17")]
	private MLLKELEPLJE DPCLCLENFCB(DDICDNFJGFA HLKJMHJNLMO, in GPHOCGFKAIA PHAPMEHMHAK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003FB")]
	[Cpp2IlInjected.Address(RVA = "0x55AC4F0", Offset = "0x55AB2F0", VA = "0x1855AC4F0", Slot = "18")]
	private DKCDJJILPGD PGPHKHMHHBM(DDICDNFJGFA HLKJMHJNLMO, in GPHOCGFKAIA PHAPMEHMHAK)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000044")]
[Preserve]
public sealed class PPJNFGAOMCK : DDICDNFJGFA, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x4000065")]
	public static readonly PPJNFGAOMCK PDNDNIMAPDO;

	[Cpp2IlInjected.Token(Token = "0x17000100")]
	public Rigidbody AMAINOJCLLB
	{
		[Cpp2IlInjected.Token(Token = "0x600040E")]
		[Cpp2IlInjected.Address(RVA = "0x6F7E40", Offset = "0x6F6C40", VA = "0x1806F7E40", Slot = "4")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000101")]
	public RigidbodyEx DEPNLHOILPJ
	{
		[Cpp2IlInjected.Token(Token = "0x600040F")]
		[Cpp2IlInjected.Address(RVA = "0x6FA140", Offset = "0x6F8F40", VA = "0x1806FA140", Slot = "5")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000102")]
	public GameObject MOOKKKOOHPD
	{
		[Cpp2IlInjected.Token(Token = "0x6000410")]
		[Cpp2IlInjected.Address(RVA = "0x6FA130", Offset = "0x6F8F30", VA = "0x1806FA130", Slot = "6")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000103")]
	public Transform OBACKBELLEI
	{
		[Cpp2IlInjected.Token(Token = "0x6000411")]
		[Cpp2IlInjected.Address(RVA = "0x6FA2D0", Offset = "0x6F90D0", VA = "0x1806FA2D0", Slot = "7")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000104")]
	public IEnumerable<object> DBMMLAPEJMC
	{
		[Cpp2IlInjected.Token(Token = "0x6000412")]
		[Cpp2IlInjected.Address(RVA = "0x718560", Offset = "0x717360", VA = "0x180718560", Slot = "8")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000105")]
	public DDICDNFJGFA KFPCMBOLNGI
	{
		[Cpp2IlInjected.Token(Token = "0x6000413")]
		[Cpp2IlInjected.Address(RVA = "0x6F6E70", Offset = "0x6F5C70", VA = "0x1806F6E70", Slot = "9")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000414")]
		[Cpp2IlInjected.Address(RVA = "0x6F7830", Offset = "0x6F6630", VA = "0x1806F7830", Slot = "10")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000106")]
	public IReadOnlyList<DDICDNFJGFA> IAJCOJILOEF
	{
		[Cpp2IlInjected.Token(Token = "0x6000415")]
		[Cpp2IlInjected.Address(RVA = "0x6FA150", Offset = "0x6F8F50", VA = "0x1806FA150", Slot = "11")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000107")]
	public DDICDNFJGFA CAHHKGJGOJO
	{
		[Cpp2IlInjected.Token(Token = "0x6000416")]
		[Cpp2IlInjected.Address(RVA = "0x6FD9C0", Offset = "0x6FC7C0", VA = "0x1806FD9C0", Slot = "12")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000108")]
	public bool FGHFGPDIBIE
	{
		[Cpp2IlInjected.Token(Token = "0x6000417")]
		[Cpp2IlInjected.Address(RVA = "0x7716B0", Offset = "0x7704B0", VA = "0x1807716B0", Slot = "13")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000109")]
	public bool HJEPBPJAOBD
	{
		[Cpp2IlInjected.Token(Token = "0x6000418")]
		[Cpp2IlInjected.Address(RVA = "0xAC4870", Offset = "0xAC3670", VA = "0x180AC4870", Slot = "14")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700010A")]
	public bool BCEMFENGFMG
	{
		[Cpp2IlInjected.Token(Token = "0x6000419")]
		[Cpp2IlInjected.Address(RVA = "0xAC46A0", Offset = "0xAC34A0", VA = "0x180AC46A0", Slot = "15")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700010B")]
	public MDNFIBKLANB NBOHDJLOFIN
	{
		[Cpp2IlInjected.Token(Token = "0x600041A")]
		[Cpp2IlInjected.Address(RVA = "0x7CFA40", Offset = "0x7CE840", VA = "0x1807CFA40", Slot = "16")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600041B")]
		[Cpp2IlInjected.Address(RVA = "0x7D7500", Offset = "0x7D6300", VA = "0x1807D7500", Slot = "17")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700010C")]
	public IGIPPOIEHFL KGJELLKCKGD
	{
		[Cpp2IlInjected.Token(Token = "0x600041C")]
		[Cpp2IlInjected.Address(RVA = "0x7B1C50", Offset = "0x7B0A50", VA = "0x1807B1C50", Slot = "18")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600041D")]
		[Cpp2IlInjected.Address(RVA = "0x71C290", Offset = "0x71B090", VA = "0x18071C290", Slot = "19")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700010D")]
	public float ELIKFBMBBPJ
	{
		[Cpp2IlInjected.Token(Token = "0x600041E")]
		[Cpp2IlInjected.Address(RVA = "0x197EDF0", Offset = "0x197DBF0", VA = "0x18197EDF0", Slot = "20")]
		[CompilerGenerated]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x600041F")]
		[Cpp2IlInjected.Address(RVA = "0xF05760", Offset = "0xF04560", VA = "0x180F05760", Slot = "21")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700010E")]
	public Vector3 PLFFIHHKHOJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000420")]
		[Cpp2IlInjected.Address(RVA = "0x317DB00", Offset = "0x317C900", VA = "0x18317DB00", Slot = "22")]
		[CompilerGenerated]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x6000421")]
		[Cpp2IlInjected.Address(RVA = "0x317DAC0", Offset = "0x317C8C0", VA = "0x18317DAC0", Slot = "23")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700010F")]
	public Vector3 HNKEAHNHOFC
	{
		[Cpp2IlInjected.Token(Token = "0x6000422")]
		[Cpp2IlInjected.Address(RVA = "0x22D4540", Offset = "0x22D3340", VA = "0x1822D4540", Slot = "24")]
		[CompilerGenerated]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x6000423")]
		[Cpp2IlInjected.Address(RVA = "0x22D0C70", Offset = "0x22CFA70", VA = "0x1822D0C70", Slot = "25")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000110")]
	public Vector3 PJGMOGHAPMH
	{
		[Cpp2IlInjected.Token(Token = "0x6000424")]
		[Cpp2IlInjected.Address(RVA = "0x22D4560", Offset = "0x22D3360", VA = "0x1822D4560", Slot = "26")]
		[CompilerGenerated]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x6000425")]
		[Cpp2IlInjected.Address(RVA = "0x22D13B0", Offset = "0x22D01B0", VA = "0x1822D13B0", Slot = "27")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000111")]
	public Vector3 BEOEJBBFCKO
	{
		[Cpp2IlInjected.Token(Token = "0x6000426")]
		[Cpp2IlInjected.Address(RVA = "0x174E3E0", Offset = "0x174D1E0", VA = "0x18174E3E0", Slot = "28")]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x6000427")]
		[Cpp2IlInjected.Address(RVA = "0x6ED320", Offset = "0x6EC120", VA = "0x1806ED320", Slot = "29")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000112")]
	public bool BHJMJPEEHFL
	{
		[Cpp2IlInjected.Token(Token = "0x6000428")]
		[Cpp2IlInjected.Address(RVA = "0xB6C7D0", Offset = "0xB6B5D0", VA = "0x180B6C7D0", Slot = "30")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000113")]
	public bool DCDPHNJFFFB
	{
		[Cpp2IlInjected.Token(Token = "0x6000429")]
		[Cpp2IlInjected.Address(RVA = "0xB6C7E0", Offset = "0xB6B5E0", VA = "0x180B6C7E0", Slot = "31")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000114")]
	public bool OKEBAKFHKOE
	{
		[Cpp2IlInjected.Token(Token = "0x600042A")]
		[Cpp2IlInjected.Address(RVA = "0xB6C7C0", Offset = "0xB6B5C0", VA = "0x180B6C7C0", Slot = "32")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000115")]
	public bool OGCFEGMFPMP
	{
		[Cpp2IlInjected.Token(Token = "0x600042B")]
		[Cpp2IlInjected.Address(RVA = "0xE46990", Offset = "0xE45790", VA = "0x180E46990", Slot = "33")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000116")]
	public Vector3 DBPFBEOHHOL
	{
		[Cpp2IlInjected.Token(Token = "0x600042C")]
		[Cpp2IlInjected.Address(RVA = "0x1B88190", Offset = "0x1B86F90", VA = "0x181B88190", Slot = "34")]
		[CompilerGenerated]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000117")]
	public Vector3 DCGLBLKOGAP
	{
		[Cpp2IlInjected.Token(Token = "0x600042D")]
		[Cpp2IlInjected.Address(RVA = "0x1934400", Offset = "0x1933200", VA = "0x181934400", Slot = "35")]
		[CompilerGenerated]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000118")]
	public Vector3 CDOEBEFDAIG
	{
		[Cpp2IlInjected.Token(Token = "0x600042E")]
		[Cpp2IlInjected.Address(RVA = "0x174E3E0", Offset = "0x174D1E0", VA = "0x18174E3E0", Slot = "36")]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x600042F")]
		[Cpp2IlInjected.Address(RVA = "0x6ED320", Offset = "0x6EC120", VA = "0x1806ED320", Slot = "37")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000119")]
	public Vector3 HDLNEGJCDGD
	{
		[Cpp2IlInjected.Token(Token = "0x6000430")]
		[Cpp2IlInjected.Address(RVA = "0x22D4620", Offset = "0x22D3420", VA = "0x1822D4620", Slot = "38")]
		[CompilerGenerated]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700011A")]
	public float AANJNIAMGBP
	{
		[Cpp2IlInjected.Token(Token = "0x6000431")]
		[Cpp2IlInjected.Address(RVA = "0x9E3800", Offset = "0x9E2600", VA = "0x1809E3800", Slot = "39")]
		[CompilerGenerated]
		get
		{
			return default(float);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700011B")]
	public float LJPJENEPPAO
	{
		[Cpp2IlInjected.Token(Token = "0x6000432")]
		[Cpp2IlInjected.Address(RVA = "0x87DB00", Offset = "0x87C900", VA = "0x18087DB00", Slot = "40")]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x6000433")]
		[Cpp2IlInjected.Address(RVA = "0x6ED320", Offset = "0x6EC120", VA = "0x1806ED320", Slot = "41")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700011C")]
	public Vector3 OLHILDGADHC
	{
		[Cpp2IlInjected.Token(Token = "0x6000434")]
		[Cpp2IlInjected.Address(RVA = "0x174E3E0", Offset = "0x174D1E0", VA = "0x18174E3E0", Slot = "42")]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x6000435")]
		[Cpp2IlInjected.Address(RVA = "0x6ED320", Offset = "0x6EC120", VA = "0x1806ED320", Slot = "43")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700011D")]
	public Quaternion FPHMFIFGALL
	{
		[Cpp2IlInjected.Token(Token = "0x6000436")]
		[Cpp2IlInjected.Address(RVA = "0x765260", Offset = "0x764060", VA = "0x180765260", Slot = "44")]
		get
		{
			return default(Quaternion);
		}
		[Cpp2IlInjected.Token(Token = "0x6000437")]
		[Cpp2IlInjected.Address(RVA = "0x6ED320", Offset = "0x6EC120", VA = "0x1806ED320", Slot = "45")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700011E")]
	public float EGNLMBHDOFH
	{
		[Cpp2IlInjected.Token(Token = "0x6000438")]
		[Cpp2IlInjected.Address(RVA = "0x87DB00", Offset = "0x87C900", VA = "0x18087DB00", Slot = "46")]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x6000439")]
		[Cpp2IlInjected.Address(RVA = "0x6ED320", Offset = "0x6EC120", VA = "0x1806ED320", Slot = "47")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700011F")]
	public float NPBKEBDHMEK
	{
		[Cpp2IlInjected.Token(Token = "0x600043A")]
		[Cpp2IlInjected.Address(RVA = "0x87DB00", Offset = "0x87C900", VA = "0x18087DB00", Slot = "48")]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x600043B")]
		[Cpp2IlInjected.Address(RVA = "0x6ED320", Offset = "0x6EC120", VA = "0x1806ED320", Slot = "49")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000120")]
	public bool AHEGBAHBLNL
	{
		[Cpp2IlInjected.Token(Token = "0x600043C")]
		[Cpp2IlInjected.Address(RVA = "0x70F8E0", Offset = "0x70E6E0", VA = "0x18070F8E0", Slot = "50")]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x600043D")]
		[Cpp2IlInjected.Address(RVA = "0x6ED320", Offset = "0x6EC120", VA = "0x1806ED320", Slot = "51")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000121")]
	public bool BBMBAOPJPCL
	{
		[Cpp2IlInjected.Token(Token = "0x600043E")]
		[Cpp2IlInjected.Address(RVA = "0x70F8E0", Offset = "0x70E6E0", VA = "0x18070F8E0")]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x600043F")]
		[Cpp2IlInjected.Address(RVA = "0x6ED320", Offset = "0x6EC120", VA = "0x1806ED320")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000122")]
	public PHMDEGBGMEP MEOGMKAMEEP
	{
		[Cpp2IlInjected.Token(Token = "0x6000440")]
		[Cpp2IlInjected.Address(RVA = "0x70F8E0", Offset = "0x70E6E0", VA = "0x18070F8E0", Slot = "52")]
		get
		{
			return default(PHMDEGBGMEP);
		}
		[Cpp2IlInjected.Token(Token = "0x6000441")]
		[Cpp2IlInjected.Address(RVA = "0x6ED320", Offset = "0x6EC120", VA = "0x1806ED320", Slot = "53")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000123")]
	public bool MJPGFBJBMBL
	{
		[Cpp2IlInjected.Token(Token = "0x6000442")]
		[Cpp2IlInjected.Address(RVA = "0x2604250", Offset = "0x2603050", VA = "0x182604250", Slot = "54")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000124")]
	public Transform FJKALEOIOIL
	{
		[Cpp2IlInjected.Token(Token = "0x6000443")]
		[Cpp2IlInjected.Address(RVA = "0x718380", Offset = "0x717180", VA = "0x180718380", Slot = "55")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000125")]
	public Transform FENNCJKPIPO
	{
		[Cpp2IlInjected.Token(Token = "0x6000444")]
		[Cpp2IlInjected.Address(RVA = "0x8B6E20", Offset = "0x8B5C20", VA = "0x1808B6E20", Slot = "56")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000126")]
	public Vector3 OCAKMFDJIOJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000445")]
		[Cpp2IlInjected.Address(RVA = "0x174E3E0", Offset = "0x174D1E0", VA = "0x18174E3E0", Slot = "57")]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x6000446")]
		[Cpp2IlInjected.Address(RVA = "0x6ED320", Offset = "0x6EC120", VA = "0x1806ED320", Slot = "58")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000127")]
	public float GEIBAJEKMBO
	{
		[Cpp2IlInjected.Token(Token = "0x6000447")]
		[Cpp2IlInjected.Address(RVA = "0x87DB00", Offset = "0x87C900", VA = "0x18087DB00", Slot = "59")]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x6000448")]
		[Cpp2IlInjected.Address(RVA = "0x6ED320", Offset = "0x6EC120", VA = "0x1806ED320", Slot = "60")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000128")]
	public float MOKNEJJCJKK
	{
		[Cpp2IlInjected.Token(Token = "0x6000449")]
		[Cpp2IlInjected.Address(RVA = "0x87DB00", Offset = "0x87C900", VA = "0x18087DB00", Slot = "61")]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x600044A")]
		[Cpp2IlInjected.Address(RVA = "0x6ED320", Offset = "0x6EC120", VA = "0x1806ED320", Slot = "62")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000129")]
	public Quaternion PCGLOPJPLLA
	{
		[Cpp2IlInjected.Token(Token = "0x600044B")]
		[Cpp2IlInjected.Address(RVA = "0x1505FF0", Offset = "0x1504DF0", VA = "0x181505FF0", Slot = "63")]
		get
		{
			return default(Quaternion);
		}
		[Cpp2IlInjected.Token(Token = "0x600044C")]
		[Cpp2IlInjected.Address(RVA = "0x6ED320", Offset = "0x6EC120", VA = "0x1806ED320", Slot = "64")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700012A")]
	public Vector3 OGAPOCAACEE
	{
		[Cpp2IlInjected.Token(Token = "0x600044D")]
		[Cpp2IlInjected.Address(RVA = "0x174E3E0", Offset = "0x174D1E0", VA = "0x18174E3E0", Slot = "65")]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x600044E")]
		[Cpp2IlInjected.Address(RVA = "0x6ED320", Offset = "0x6EC120", VA = "0x1806ED320", Slot = "66")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700012B")]
	public Quaternion DHDNKCLJBGN
	{
		[Cpp2IlInjected.Token(Token = "0x600044F")]
		[Cpp2IlInjected.Address(RVA = "0x1505FF0", Offset = "0x1504DF0", VA = "0x181505FF0", Slot = "67")]
		get
		{
			return default(Quaternion);
		}
		[Cpp2IlInjected.Token(Token = "0x6000450")]
		[Cpp2IlInjected.Address(RVA = "0x6ED320", Offset = "0x6EC120", VA = "0x1806ED320", Slot = "68")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700012C")]
	public RigidbodyConstraints PDLJENDCEHJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000451")]
		[Cpp2IlInjected.Address(RVA = "0x70F8D0", Offset = "0x70E6D0", VA = "0x18070F8D0", Slot = "69")]
		get
		{
			return default(RigidbodyConstraints);
		}
		[Cpp2IlInjected.Token(Token = "0x6000452")]
		[Cpp2IlInjected.Address(RVA = "0x6ED320", Offset = "0x6EC120", VA = "0x1806ED320", Slot = "70")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700012D")]
	public bool DKOAFEFPELM
	{
		[Cpp2IlInjected.Token(Token = "0x6000453")]
		[Cpp2IlInjected.Address(RVA = "0x70F8E0", Offset = "0x70E6E0", VA = "0x18070F8E0", Slot = "71")]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000454")]
		[Cpp2IlInjected.Address(RVA = "0x6ED320", Offset = "0x6EC120", VA = "0x1806ED320", Slot = "72")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700012E")]
	public CollisionDetectionMode FEJFOAGMGJI
	{
		[Cpp2IlInjected.Token(Token = "0x6000455")]
		[Cpp2IlInjected.Address(RVA = "0x70F8D0", Offset = "0x70E6D0", VA = "0x18070F8D0", Slot = "73")]
		get
		{
			return default(CollisionDetectionMode);
		}
		[Cpp2IlInjected.Token(Token = "0x6000456")]
		[Cpp2IlInjected.Address(RVA = "0x6ED320", Offset = "0x6EC120", VA = "0x1806ED320", Slot = "74")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700012F")]
	public bool BIBDGFIAGJM
	{
		[Cpp2IlInjected.Token(Token = "0x6000457")]
		[Cpp2IlInjected.Address(RVA = "0x13D5510", Offset = "0x13D4310", VA = "0x1813D5510", Slot = "75")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000038")]
	public event IJDKLAGCEFG PBOBAMPILGB
	{
		[Cpp2IlInjected.Token(Token = "0x60003FC")]
		[Cpp2IlInjected.Address(RVA = "0x6ED320", Offset = "0x6EC120", VA = "0x1806ED320", Slot = "81")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60003FD")]
		[Cpp2IlInjected.Address(RVA = "0x6ED320", Offset = "0x6EC120", VA = "0x1806ED320", Slot = "82")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000039")]
	public event IJDKLAGCEFG GKGJJLMHDLI
	{
		[Cpp2IlInjected.Token(Token = "0x60003FE")]
		[Cpp2IlInjected.Address(RVA = "0x6ED320", Offset = "0x6EC120", VA = "0x1806ED320", Slot = "83")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60003FF")]
		[Cpp2IlInjected.Address(RVA = "0x6ED320", Offset = "0x6EC120", VA = "0x1806ED320", Slot = "84")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400003A")]
	public event MHEGFHPPLGP NHDMDBLHBHF
	{
		[Cpp2IlInjected.Token(Token = "0x6000400")]
		[Cpp2IlInjected.Address(RVA = "0x6ED320", Offset = "0x6EC120", VA = "0x1806ED320", Slot = "85")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000401")]
		[Cpp2IlInjected.Address(RVA = "0x6ED320", Offset = "0x6EC120", VA = "0x1806ED320", Slot = "86")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400003B")]
	public event IJDKLAGCEFG OIHJCECPHEI
	{
		[Cpp2IlInjected.Token(Token = "0x6000402")]
		[Cpp2IlInjected.Address(RVA = "0x6ED320", Offset = "0x6EC120", VA = "0x1806ED320", Slot = "88")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000403")]
		[Cpp2IlInjected.Address(RVA = "0x6ED320", Offset = "0x6EC120", VA = "0x1806ED320", Slot = "89")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400003C")]
	public event IJDKLAGCEFG NAHKAOPHPKB
	{
		[Cpp2IlInjected.Token(Token = "0x6000404")]
		[Cpp2IlInjected.Address(RVA = "0x6ED320", Offset = "0x6EC120", VA = "0x1806ED320", Slot = "108")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000405")]
		[Cpp2IlInjected.Address(RVA = "0x6ED320", Offset = "0x6EC120", VA = "0x1806ED320", Slot = "109")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400003D")]
	public event IJDKLAGCEFG JLFHAPOODCF
	{
		[Cpp2IlInjected.Token(Token = "0x6000406")]
		[Cpp2IlInjected.Address(RVA = "0x6ED320", Offset = "0x6EC120", VA = "0x1806ED320", Slot = "113")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000407")]
		[Cpp2IlInjected.Address(RVA = "0x6ED320", Offset = "0x6EC120", VA = "0x1806ED320", Slot = "114")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400003E")]
	public event Action<EHKPJAMPICF, EHKPJAMPICF> JCAEOOCFBGA
	{
		[Cpp2IlInjected.Token(Token = "0x6000408")]
		[Cpp2IlInjected.Address(RVA = "0x6ED320", Offset = "0x6EC120", VA = "0x1806ED320", Slot = "117")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000409")]
		[Cpp2IlInjected.Address(RVA = "0x6ED320", Offset = "0x6EC120", VA = "0x1806ED320", Slot = "118")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400003F")]
	public event IJDKLAGCEFG LMBBIPHIOEK
	{
		[Cpp2IlInjected.Token(Token = "0x600040A")]
		[Cpp2IlInjected.Address(RVA = "0x6ED320", Offset = "0x6EC120", VA = "0x1806ED320", Slot = "119")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600040B")]
		[Cpp2IlInjected.Address(RVA = "0x6ED320", Offset = "0x6EC120", VA = "0x1806ED320", Slot = "120")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000040")]
	public event IJDKLAGCEFG HMNHPLAABPL
	{
		[Cpp2IlInjected.Token(Token = "0x600040C")]
		[Cpp2IlInjected.Address(RVA = "0x6ED320", Offset = "0x6EC120", VA = "0x1806ED320", Slot = "125")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600040D")]
		[Cpp2IlInjected.Address(RVA = "0x6ED320", Offset = "0x6EC120", VA = "0x1806ED320", Slot = "126")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000458")]
	[Cpp2IlInjected.Address(RVA = "0x6ED320", Offset = "0x6EC120", VA = "0x1806ED320", Slot = "76")]
	public void LOAKFOBCBAO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000459")]
	[Cpp2IlInjected.Address(RVA = "0x6ED320", Offset = "0x6EC120", VA = "0x1806ED320", Slot = "77")]
	public void IGDJODCGKJE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600045A")]
	[Cpp2IlInjected.Address(RVA = "0x6ED320", Offset = "0x6EC120", VA = "0x1806ED320", Slot = "78")]
	public void BBLEBJJHLNM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600045B")]
	[Cpp2IlInjected.Address(RVA = "0x6ED320", Offset = "0x6EC120", VA = "0x1806ED320", Slot = "79")]
	public void MNLNBCJHPMD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600045C")]
	[Cpp2IlInjected.Address(RVA = "0x6ED320", Offset = "0x6EC120", VA = "0x1806ED320", Slot = "80")]
	public void GMONNENGCBC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600045D")]
	[Cpp2IlInjected.Address(RVA = "0x6ED320", Offset = "0x6EC120", VA = "0x1806ED320", Slot = "141")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600045E")]
	[Cpp2IlInjected.Address(RVA = "0x6ED320", Offset = "0x6EC120", VA = "0x1806ED320", Slot = "87")]
	public void CNEDMMKBPIO(DDICDNFJGFA NLHFEJHKLAH, bool BNLMFCPNEHF = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600045F")]
	[Cpp2IlInjected.Address(RVA = "0x6ED320", Offset = "0x6EC120", VA = "0x1806ED320", Slot = "90")]
	public void FKHILLLDBNL(object INDCJAMMAIN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000460")]
	[Cpp2IlInjected.Address(RVA = "0x6ED320", Offset = "0x6EC120", VA = "0x1806ED320", Slot = "91")]
	public void HICAJKMKHKJ(object INDCJAMMAIN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000461")]
	[Cpp2IlInjected.Address(RVA = "0x174E3E0", Offset = "0x174D1E0", VA = "0x18174E3E0", Slot = "92")]
	public Vector3 DKGOLPKDCPG(Vector3 LGHPPABOKOK)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000462")]
	[Cpp2IlInjected.Address(RVA = "0x174E3E0", Offset = "0x174D1E0", VA = "0x18174E3E0", Slot = "93")]
	public Vector3 EHCFPONMFKA(Vector3 AFLGANKGICH)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000463")]
	[Cpp2IlInjected.Address(RVA = "0x6ED320", Offset = "0x6EC120", VA = "0x1806ED320", Slot = "94")]
	public void AGCPJAHILEP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000464")]
	[Cpp2IlInjected.Address(RVA = "0x6ED320", Offset = "0x6EC120", VA = "0x1806ED320", Slot = "95")]
	public void FIIAJOAMNGJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000465")]
	[Cpp2IlInjected.Address(RVA = "0x6ED320", Offset = "0x6EC120", VA = "0x1806ED320", Slot = "96")]
	public void OGCLLIMCEGK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000466")]
	[Cpp2IlInjected.Address(RVA = "0x6ED320", Offset = "0x6EC120", VA = "0x1806ED320", Slot = "97")]
	public void NFJDLDDEJMF(Vector3 IMMOLPOLNBA, Vector3 OGMHJOIPEGI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000467")]
	[Cpp2IlInjected.Address(RVA = "0x6ED320", Offset = "0x6EC120", VA = "0x1806ED320", Slot = "98")]
	public void MODKKAHENJA(Vector3 IAOEEAAKMPP, Vector3 IDJHMKHCMIA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000468")]
	[Cpp2IlInjected.Address(RVA = "0x6ED320", Offset = "0x6EC120", VA = "0x1806ED320", Slot = "99")]
	public void GGCHAGHHFEC(Vector3 GKPHCGNAJHA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000469")]
	[Cpp2IlInjected.Address(RVA = "0x6ED320", Offset = "0x6EC120", VA = "0x1806ED320", Slot = "100")]
	public void DCKBJJIFEAA(GOIGKHJPKIL LKEHIILFBGJ, Vector3 CPJPNJCMJAL, float LJKLGGMAHOJ, float LHJEDBKLJNN = 8f, float PAKBBNDEEJP = 1f)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600046A")]
	[Cpp2IlInjected.Address(RVA = "0x6ED320", Offset = "0x6EC120", VA = "0x1806ED320", Slot = "101")]
	public void LDIFLICNPJP(OEBNECHHPCF GDDGFGKAHMD, Vector3 BNCCLPFNHEL, float JEMKJHNONPD = float.PositiveInfinity)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600046B")]
	[Cpp2IlInjected.Address(RVA = "0x6ED320", Offset = "0x6EC120", VA = "0x1806ED320", Slot = "102")]
	public void MKPHELIMAAE(OEBNECHHPCF GDDGFGKAHMD, Vector3 HKMKNOBAIAN, float NIDEHIHCIBC = 7f, float DLGLDDADCFL = 1f)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600046C")]
	[Cpp2IlInjected.Address(RVA = "0x174E3E0", Offset = "0x174D1E0", VA = "0x18174E3E0", Slot = "103")]
	public Vector3 PKBLILEEDPH(Vector3 NLHFEJHKLAH)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x600046D")]
	[Cpp2IlInjected.Address(RVA = "0x174E3E0", Offset = "0x174D1E0", VA = "0x18174E3E0", Slot = "104")]
	public Vector3 EIEKMNNPHJM(Vector3 NLHFEJHKLAH)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x600046E")]
	[Cpp2IlInjected.Address(RVA = "0x6ED320", Offset = "0x6EC120", VA = "0x1806ED320", Slot = "105")]
	public void FLNLDAANDPM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600046F")]
	[Cpp2IlInjected.Address(RVA = "0x6ED320", Offset = "0x6EC120", VA = "0x1806ED320", Slot = "106")]
	public void EMNIPIHNALC(DDICDNFJGFA JCBNEMEEHFF, object INDCJAMMAIN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000470")]
	[Cpp2IlInjected.Address(RVA = "0x6ED320", Offset = "0x6EC120", VA = "0x1806ED320", Slot = "107")]
	public void FEHAHPDNHDG(object INDCJAMMAIN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000471")]
	[Cpp2IlInjected.Address(RVA = "0x6ED320", Offset = "0x6EC120", VA = "0x1806ED320", Slot = "110")]
	public void GBIGLFOHPKF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000472")]
	[Cpp2IlInjected.Address(RVA = "0x6ED320", Offset = "0x6EC120", VA = "0x1806ED320", Slot = "111")]
	public void NFCCEAJGIIH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000473")]
	[Cpp2IlInjected.Address(RVA = "0x6ED320", Offset = "0x6EC120", VA = "0x1806ED320", Slot = "112")]
	public void DCKPFKGOBFJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000474")]
	[Cpp2IlInjected.Address(RVA = "0x70F8E0", Offset = "0x70E6E0", VA = "0x18070F8E0", Slot = "115")]
	public bool OMBGDMJFHEI()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000475")]
	[Cpp2IlInjected.Address(RVA = "0x6ED320", Offset = "0x6EC120", VA = "0x1806ED320", Slot = "116")]
	public void EDKDBDBJFEP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000476")]
	[Cpp2IlInjected.Address(RVA = "0x70F8D0", Offset = "0x70E6D0", VA = "0x18070F8D0", Slot = "121")]
	public IDisposable PAOMLEGBIMN()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000477")]
	[Cpp2IlInjected.Address(RVA = "0x6ED320", Offset = "0x6EC120", VA = "0x1806ED320", Slot = "122")]
	public void MBDADCCBFHH(object INDCJAMMAIN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000478")]
	[Cpp2IlInjected.Address(RVA = "0x6ED320", Offset = "0x6EC120", VA = "0x1806ED320", Slot = "123")]
	public void JKKBAAMOMNK(object INDCJAMMAIN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000479")]
	[Cpp2IlInjected.Address(RVA = "0x6ED320", Offset = "0x6EC120", VA = "0x1806ED320", Slot = "124")]
	public void DNFBGHHNNHM(object INDCJAMMAIN, bool NKIGKALHKKG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600047A")]
	[Cpp2IlInjected.Address(RVA = "0x6ED320", Offset = "0x6EC120", VA = "0x1806ED320", Slot = "127")]
	public void AACJLACMIEO(Vector3 KPJPKNEEHFJ, Quaternion FFPDKCAEKDA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600047B")]
	[Cpp2IlInjected.Address(RVA = "0x6ED320", Offset = "0x6EC120", VA = "0x1806ED320", Slot = "128")]
	public void JNOALKFAIEH(Vector3 APJBCHKNCHD, Quaternion LIMMBJPINMP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600047C")]
	[Cpp2IlInjected.Address(RVA = "0x70F8E0", Offset = "0x70E6E0", VA = "0x18070F8E0", Slot = "129")]
	public bool BLMMBEJIFIE(float MHHMHIKNPME)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600047D")]
	[Cpp2IlInjected.Address(RVA = "0x6ED320", Offset = "0x6EC120", VA = "0x1806ED320", Slot = "130")]
	public void GEKJMPIKEBI(object INDCJAMMAIN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600047E")]
	[Cpp2IlInjected.Address(RVA = "0x6ED320", Offset = "0x6EC120", VA = "0x1806ED320", Slot = "131")]
	public void PBODBJKKJIG(object INDCJAMMAIN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600047F")]
	[Cpp2IlInjected.Address(RVA = "0x6ED320", Offset = "0x6EC120", VA = "0x1806ED320", Slot = "132")]
	public void BGFCCCENBID(object INDCJAMMAIN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000480")]
	[Cpp2IlInjected.Address(RVA = "0x6ED320", Offset = "0x6EC120", VA = "0x1806ED320", Slot = "133")]
	public void GPBOKOEIFJD(object INDCJAMMAIN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000481")]
	[Cpp2IlInjected.Address(RVA = "0x6ED320", Offset = "0x6EC120", VA = "0x1806ED320", Slot = "134")]
	public void OHEOAAGAOKK(Vector3 AJKJHFCHOAK, ForceMode GMFAKLHMDNN = ForceMode.Force)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000482")]
	[Cpp2IlInjected.Address(RVA = "0x6ED320", Offset = "0x6EC120", VA = "0x1806ED320", Slot = "135")]
	public void DBDNFABFCFD(Vector3 AJKJHFCHOAK, Vector3 CBAKPHLPCPB, ForceMode GMFAKLHMDNN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000483")]
	[Cpp2IlInjected.Address(RVA = "0x6ED320", Offset = "0x6EC120", VA = "0x1806ED320", Slot = "136")]
	public void OKEPOCHCNGP(Vector3 OJLGOOKKJEA, ForceMode GMFAKLHMDNN = ForceMode.Force)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000484")]
	[Cpp2IlInjected.Address(RVA = "0x6ED320", Offset = "0x6EC120", VA = "0x1806ED320", Slot = "137")]
	public void KIIOGIGGADP(Vector3 OJLGOOKKJEA, ForceMode GMFAKLHMDNN = ForceMode.Force)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000485")]
	[Cpp2IlInjected.Address(RVA = "0x65B2F10", Offset = "0x65B1D10", VA = "0x1865B2F10", Slot = "138")]
	public bool AFMAEECEEBD(Vector3 HHGBGELADCO, out RaycastHit MFKIKGLHAMN, float EMEIKNNEGHK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000486")]
	[Cpp2IlInjected.Address(RVA = "0x6ED320", Offset = "0x6EC120", VA = "0x1806ED320", Slot = "139")]
	public void EGDEMHMFAIF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000487")]
	[Cpp2IlInjected.Address(RVA = "0x6ECCD0", Offset = "0x6EBAD0", VA = "0x1806ECCD0")]
	public PPJNFGAOMCK()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000045")]
public sealed class BCENEGCNGJI : LGAGFCAGMMC, GJBJJKLJFJI, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
	[Cpp2IlInjected.Token(Token = "0x4000083")]
	internal IMKMJFJEHIJ LNCGECBHMHD;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
	[Cpp2IlInjected.Token(Token = "0x4000084")]
	internal EKNANNBDCIH PNDGBJGMFFL;

	[Cpp2IlInjected.Token(Token = "0x6000489")]
	[Cpp2IlInjected.Address(RVA = "0x558CAB0", Offset = "0x558B8B0", VA = "0x18558CAB0")]
	public BCENEGCNGJI(GameObject AAMBGNNHMBI, RigidbodyEx OAOOMIBODOP, BABOKGOAEJI OBAPIKNALOO, in GPHOCGFKAIA PHAPMEHMHAK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600048A")]
	[Cpp2IlInjected.Address(RVA = "0x558C6F0", Offset = "0x558B4F0", VA = "0x18558C6F0", Slot = "142")]
	protected override void OJECLMJDEEI(BABOKGOAEJI OBAPIKNALOO, GPHOCGFKAIA PHAPMEHMHAK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600048B")]
	[Cpp2IlInjected.Address(RVA = "0x558C560", Offset = "0x558B360", VA = "0x18558C560", Slot = "143")]
	public override void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600048C")]
	[Cpp2IlInjected.Address(RVA = "0x558C9E0", Offset = "0x558B7E0", VA = "0x18558C9E0", Slot = "145")]
	public void OOENEEMMNPO(GHFALBJGKOG OMHFAAGAIBL, GHFALBJGKOG KMCDOHPNFGD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600048D")]
	[Cpp2IlInjected.Address(RVA = "0x558C280", Offset = "0x558B080", VA = "0x18558C280", Slot = "146")]
	public void AHGAPFBMEKE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600048E")]
	[Cpp2IlInjected.Address(RVA = "0x558C4A0", Offset = "0x558B2A0", VA = "0x18558C4A0", Slot = "147")]
	public void CAMOLCLIEFG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600048F")]
	[Cpp2IlInjected.Address(RVA = "0x558C980", Offset = "0x558B780", VA = "0x18558C980", Slot = "148")]
	public void OKNIAACKICL(bool NOEDBDPFICH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000490")]
	[Cpp2IlInjected.Address(RVA = "0x558C340", Offset = "0x558B140", VA = "0x18558C340", Slot = "149")]
	public bool BHHKMFNDABJ()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000491")]
	[Cpp2IlInjected.Address(RVA = "0x6ED320", Offset = "0x6EC120", VA = "0x1806ED320", Slot = "144")]
	public override void GMONNENGCBC()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000046")]
internal static class CMKFIBNKFND
{
	[Cpp2IlInjected.Token(Token = "0x6000492")]
	[Cpp2IlInjected.Address(RVA = "0x558D620", Offset = "0x558C420", VA = "0x18558D620")]
	public static LGAGFCAGMMC BHHOHIAKDEK(this DDICDNFJGFA HLKJMHJNLMO)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000047")]
public interface BKIGKKEKEEB : HIBPGMCCMFF, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x6000493")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void DCMJCJJFMCK(DDICDNFJGFA FBJBBGAMODK);

	[Cpp2IlInjected.Token(Token = "0x6000494")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void NFAGHCDLJNP(DDICDNFJGFA FBJBBGAMODK);

	[Cpp2IlInjected.Token(Token = "0x6000495")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void EKJAOBEDMKJ(DDICDNFJGFA KJJPIPKOFKF);

	[Cpp2IlInjected.Token(Token = "0x6000496")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void NHBEELLHAIH(DDICDNFJGFA KJJPIPKOFKF);
}
[Cpp2IlInjected.Token(Token = "0x2000048")]
public interface FHAPMADIONK : GAMDKECCFOL
{
	[Cpp2IlInjected.Token(Token = "0x17000130")]
	global::ENALOFLIEGA<DDICDNFJGFA> HJIJPLGACBG
	{
		[Cpp2IlInjected.Token(Token = "0x6000497")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000131")]
	DDICDNFJGFA DNBEEAPENJJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000498")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000049")]
public interface BNPPIEJEAIK : MLLKELEPLJE
{
	[Cpp2IlInjected.Token(Token = "0x6000499")]
	[Cpp2IlInjected.Address(Slot = "0")]
	(float, Vector3) OFDNBGNKKFI(Rigidbody PEDELFDFMBN);
}
[Cpp2IlInjected.Token(Token = "0x200004A")]
public interface FCFGELJEDJL : DLGODMNJHEI, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x17000132")]
	PhotonView FBIKDNHOMKO
	{
		[Cpp2IlInjected.Token(Token = "0x600049A")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x200004B")]
internal sealed class OAJIEOCNKIP : HFDAKPEHNOJ
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000085")]
	private readonly LGAGFCAGMMC FBJBBGAMODK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000086")]
	private CollisionDetectionMode LACCJEMIEFP;

	[Cpp2IlInjected.Token(Token = "0x17000133")]
	private Rigidbody AMAINOJCLLB
	{
		[Cpp2IlInjected.Token(Token = "0x600049B")]
		[Cpp2IlInjected.Address(RVA = "0x558F170", Offset = "0x558DF70", VA = "0x18558F170")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000134")]
	public CollisionDetectionMode FEJFOAGMGJI
	{
		[Cpp2IlInjected.Token(Token = "0x600049F")]
		[Cpp2IlInjected.Address(RVA = "0x55AD030", Offset = "0x55ABE30", VA = "0x1855AD030", Slot = "4")]
		get
		{
			return default(CollisionDetectionMode);
		}
		[Cpp2IlInjected.Token(Token = "0x60004A0")]
		[Cpp2IlInjected.Address(RVA = "0x55AD3B0", Offset = "0x55AC1B0", VA = "0x1855AD3B0", Slot = "5")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600049C")]
	[Cpp2IlInjected.Address(RVA = "0x558F390", Offset = "0x558E190", VA = "0x18558F390")]
	public OAJIEOCNKIP(DDICDNFJGFA FBJBBGAMODK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600049D")]
	[Cpp2IlInjected.Address(RVA = "0x55AD280", Offset = "0x55AC080", VA = "0x1855AD280", Slot = "6")]
	public void LOAKFOBCBAO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600049E")]
	[Cpp2IlInjected.Address(RVA = "0x55ACE40", Offset = "0x55ABC40", VA = "0x1855ACE40", Slot = "9")]
	public void AEBCBAGKFLD(Rigidbody EMPCHDNCBNN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004A1")]
	[Cpp2IlInjected.Address(RVA = "0x55AD3A0", Offset = "0x55AC1A0", VA = "0x1855AD3A0", Slot = "7")]
	public void ONLJAMKOMCG(bool HOMNNPNFFHH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004A2")]
	[Cpp2IlInjected.Address(RVA = "0x55AD270", Offset = "0x55AC070", VA = "0x1855AD270", Slot = "8")]
	public void GIEFKHILOBN(bool HOMNNPNFFHH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004A3")]
	[Cpp2IlInjected.Address(RVA = "0x55ACEC0", Offset = "0x55ABCC0", VA = "0x1855ACEC0", Slot = "10")]
	public bool AFMAEECEEBD(Vector3 HHGBGELADCO, out RaycastHit MFKIKGLHAMN, float EMEIKNNEGHK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60004A4")]
	[Cpp2IlInjected.Address(RVA = "0x55AD140", Offset = "0x55ABF40", VA = "0x1855AD140")]
	private void DIIMJKBAEDM(bool HOMNNPNFFHH)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200004C")]
public sealed class IJODMLLPFDP : OIINLPAMLAF, IDisposable, KJGOLDGANAL
{
	[Cpp2IlInjected.Token(Token = "0x4000087")]
	public const int KFIICOMMFDI = 350;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000089")]
	private readonly LGAGFCAGMMC FBJBBGAMODK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400008A")]
	private PHMDEGBGMEP ADNAELPDEEC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400008B")]
	private FOGLMEFJINH ILANHAJICNN;

	[Cpp2IlInjected.Token(Token = "0x17000135")]
	public PHMDEGBGMEP MEOGMKAMEEP
	{
		[Cpp2IlInjected.Token(Token = "0x60004A7")]
		[Cpp2IlInjected.Address(RVA = "0x55976C0", Offset = "0x55964C0", VA = "0x1855976C0", Slot = "6")]
		get
		{
			return default(PHMDEGBGMEP);
		}
		[Cpp2IlInjected.Token(Token = "0x60004A8")]
		[Cpp2IlInjected.Address(RVA = "0x5597850", Offset = "0x5596650", VA = "0x185597850", Slot = "7")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000136")]
	private Transform OEIIJAKMCBK
	{
		[Cpp2IlInjected.Token(Token = "0x60004A9")]
		[Cpp2IlInjected.Address(RVA = "0x55979C0", Offset = "0x55967C0", VA = "0x1855979C0", Slot = "10")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000041")]
	public event Action<EHKPJAMPICF, EHKPJAMPICF> JCAEOOCFBGA
	{
		[Cpp2IlInjected.Token(Token = "0x60004A5")]
		[Cpp2IlInjected.Address(RVA = "0x5597620", Offset = "0x5596420", VA = "0x185597620", Slot = "4")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60004A6")]
		[Cpp2IlInjected.Address(RVA = "0x5597920", Offset = "0x5596720", VA = "0x185597920", Slot = "5")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60004AA")]
	[Cpp2IlInjected.Address(RVA = "0x5597D20", Offset = "0x5596B20", VA = "0x185597D20")]
	public IJODMLLPFDP(DDICDNFJGFA FBJBBGAMODK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004AB")]
	[Cpp2IlInjected.Address(RVA = "0x55979E0", Offset = "0x55967E0", VA = "0x1855979E0", Slot = "8")]
	public void LOAKFOBCBAO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004AC")]
	[Cpp2IlInjected.Address(RVA = "0x5597800", Offset = "0x5596600", VA = "0x185597800", Slot = "9")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004AD")]
	[Cpp2IlInjected.Address(RVA = "0x5597CC0", Offset = "0x5596AC0", VA = "0x185597CC0", Slot = "11")]
	private void LPIOPNKIAKI(EHKPJAMPICF EAIGOHNOLND, EHKPJAMPICF EPFAGMFKNJK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004AE")]
	[Cpp2IlInjected.Address(RVA = "0x6ED320", Offset = "0x6EC120", VA = "0x1806ED320", Slot = "12")]
	private void IMDPLKCFAMH(bool CBNEFALBIGO)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200004D")]
internal sealed class OMGANAGKNLB : CFLNOOGGMLK
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400008C")]
	private readonly LGAGFCAGMMC FBJBBGAMODK;

	[Cpp2IlInjected.Token(Token = "0x17000137")]
	private Rigidbody AMAINOJCLLB
	{
		[Cpp2IlInjected.Token(Token = "0x60004AF")]
		[Cpp2IlInjected.Address(RVA = "0x558F170", Offset = "0x558DF70", VA = "0x18558F170")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000138")]
	private bool MJPGFBJBMBL
	{
		[Cpp2IlInjected.Token(Token = "0x60004B0")]
		[Cpp2IlInjected.Address(RVA = "0x559B0E0", Offset = "0x5599EE0", VA = "0x18559B0E0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000139")]
	private bool FGHFGPDIBIE
	{
		[Cpp2IlInjected.Token(Token = "0x60004B1")]
		[Cpp2IlInjected.Address(RVA = "0x55981C0", Offset = "0x5596FC0", VA = "0x1855981C0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700013A")]
	private DDICDNFJGFA KFPCMBOLNGI
	{
		[Cpp2IlInjected.Token(Token = "0x60004B2")]
		[Cpp2IlInjected.Address(RVA = "0x55AE590", Offset = "0x55AD390", VA = "0x1855AE590")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60004B3")]
	[Cpp2IlInjected.Address(RVA = "0x558F390", Offset = "0x558E190", VA = "0x18558F390")]
	public OMGANAGKNLB(DDICDNFJGFA FBJBBGAMODK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004B4")]
	[Cpp2IlInjected.Address(RVA = "0x55AE870", Offset = "0x55AD670", VA = "0x1855AE870", Slot = "4")]
	public void OHEOAAGAOKK(Vector3 AJKJHFCHOAK, ForceMode GMFAKLHMDNN = ForceMode.Force)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004B5")]
	[Cpp2IlInjected.Address(RVA = "0x55AEB30", Offset = "0x55AD930", VA = "0x1855AEB30")]
	private void PAHFFEKNLJP(Vector3 AJKJHFCHOAK, ForceMode GMFAKLHMDNN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004B6")]
	[Cpp2IlInjected.Address(RVA = "0x55AE070", Offset = "0x55ACE70", VA = "0x1855AE070", Slot = "5")]
	public void DBDNFABFCFD(Vector3 AJKJHFCHOAK, Vector3 CBAKPHLPCPB, ForceMode GMFAKLHMDNN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004B7")]
	[Cpp2IlInjected.Address(RVA = "0x55AE9D0", Offset = "0x55AD7D0", VA = "0x1855AE9D0", Slot = "6")]
	public void OKEPOCHCNGP(Vector3 OJLGOOKKJEA, ForceMode GMFAKLHMDNN = ForceMode.Force)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004B8")]
	[Cpp2IlInjected.Address(RVA = "0x55AE310", Offset = "0x55AD110", VA = "0x1855AE310")]
	private void HAJDDDHGPOO(Vector3 OJLGOOKKJEA, ForceMode GMFAKLHMDNN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004B9")]
	[Cpp2IlInjected.Address(RVA = "0x55AE5F0", Offset = "0x55AD3F0", VA = "0x1855AE5F0", Slot = "7")]
	public void KIIOGIGGADP(Vector3 OJLGOOKKJEA, ForceMode GMFAKLHMDNN = ForceMode.Force)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200004E")]
internal sealed class DPLBNAEPIDG : NHHNBAGKHPP
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400008D")]
	private readonly LGAGFCAGMMC FBJBBGAMODK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400008E")]
	private bool DOCOJPFAHJE;

	[Cpp2IlInjected.Token(Token = "0x1700013B")]
	public bool AHEGBAHBLNL
	{
		[Cpp2IlInjected.Token(Token = "0x60004BB")]
		[Cpp2IlInjected.Address(RVA = "0x76B430", Offset = "0x76A230", VA = "0x18076B430", Slot = "4")]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x60004BC")]
		[Cpp2IlInjected.Address(RVA = "0x558F280", Offset = "0x558E080", VA = "0x18558F280", Slot = "5")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60004BA")]
	[Cpp2IlInjected.Address(RVA = "0x558F390", Offset = "0x558E190", VA = "0x18558F390")]
	public DPLBNAEPIDG(DDICDNFJGFA FBJBBGAMODK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004BD")]
	[Cpp2IlInjected.Address(RVA = "0x558F250", Offset = "0x558E050", VA = "0x18558F250", Slot = "6")]
	public void AEBCBAGKFLD(Rigidbody EMPCHDNCBNN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004BE")]
	[Cpp2IlInjected.Address(RVA = "0x558DBE0", Offset = "0x558C9E0", VA = "0x18558DBE0", Slot = "7")]
	public void IEECHEIALJL(Rigidbody EMPCHDNCBNN)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200004F")]
internal sealed class ONJKOPDMJON : BKIGKKEKEEB, HIBPGMCCMFF, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x4000098")]
	private readonly DDICDNFJGFA FBJBBGAMODK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x4000099")]
	private readonly List<DDICDNFJGFA> GJFKHPNECKG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x400009A")]
	private DDICDNFJGFA DCJJENKGKJB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x400009B")]
	private DDICDNFJGFA AABHIBJPKOH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
	[Cpp2IlInjected.Token(Token = "0x400009C")]
	private Transform CACABNLNLPP;

	[Cpp2IlInjected.Token(Token = "0x1700013C")]
	private Transform OBACKBELLEI
	{
		[Cpp2IlInjected.Token(Token = "0x60004D1")]
		[Cpp2IlInjected.Address(RVA = "0x55AFF60", Offset = "0x55AED60", VA = "0x1855AFF60")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700013D")]
	public DDICDNFJGFA KFPCMBOLNGI
	{
		[Cpp2IlInjected.Token(Token = "0x60004D4")]
		[Cpp2IlInjected.Address(RVA = "0x706B50", Offset = "0x705950", VA = "0x180706B50", Slot = "28")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60004D5")]
		[Cpp2IlInjected.Address(RVA = "0x55AF250", Offset = "0x55AE050", VA = "0x1855AF250", Slot = "29")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700013E")]
	public DDICDNFJGFA CAHHKGJGOJO
	{
		[Cpp2IlInjected.Token(Token = "0x60004D6")]
		[Cpp2IlInjected.Address(RVA = "0x7B1C60", Offset = "0x7B0A60", VA = "0x1807B1C60", Slot = "27")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700013F")]
	public IReadOnlyList<DDICDNFJGFA> IAJCOJILOEF
	{
		[Cpp2IlInjected.Token(Token = "0x60004D7")]
		[Cpp2IlInjected.Address(RVA = "0x7B1C50", Offset = "0x7B0A50", VA = "0x1807B1C50", Slot = "26")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000042")]
	public event IJDKLAGCEFG PBOBAMPILGB
	{
		[Cpp2IlInjected.Token(Token = "0x60004BF")]
		[Cpp2IlInjected.Address(RVA = "0x55B0A40", Offset = "0x55AF840", VA = "0x1855B0A40", Slot = "8")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60004C0")]
		[Cpp2IlInjected.Address(RVA = "0x55B0900", Offset = "0x55AF700", VA = "0x1855B0900", Slot = "9")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000043")]
	public event IJDKLAGCEFG GKGJJLMHDLI
	{
		[Cpp2IlInjected.Token(Token = "0x60004C1")]
		[Cpp2IlInjected.Address(RVA = "0x55B0860", Offset = "0x55AF660", VA = "0x1855B0860", Slot = "10")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60004C2")]
		[Cpp2IlInjected.Address(RVA = "0x55AF110", Offset = "0x55ADF10", VA = "0x1855AF110", Slot = "11")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000044")]
	public event MHEGFHPPLGP NHDMDBLHBHF
	{
		[Cpp2IlInjected.Token(Token = "0x60004C3")]
		[Cpp2IlInjected.Address(RVA = "0x55AF070", Offset = "0x55ADE70", VA = "0x1855AF070", Slot = "12")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60004C4")]
		[Cpp2IlInjected.Address(RVA = "0x55AFD40", Offset = "0x55AEB40", VA = "0x1855AFD40", Slot = "13")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000045")]
	public event Action JJAIAHJNGIG
	{
		[Cpp2IlInjected.Token(Token = "0x60004C5")]
		[Cpp2IlInjected.Address(RVA = "0x55B09A0", Offset = "0x55AF7A0", VA = "0x1855B09A0", Slot = "14")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60004C6")]
		[Cpp2IlInjected.Address(RVA = "0x55B0100", Offset = "0x55AEF00", VA = "0x1855B0100", Slot = "15")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000046")]
	public event Action IDANOOMLEFH
	{
		[Cpp2IlInjected.Token(Token = "0x60004C7")]
		[Cpp2IlInjected.Address(RVA = "0x55B0060", Offset = "0x55AEE60", VA = "0x1855B0060", Slot = "16")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60004C8")]
		[Cpp2IlInjected.Address(RVA = "0x55AFEC0", Offset = "0x55AECC0", VA = "0x1855AFEC0", Slot = "17")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000047")]
	public event Action<DDICDNFJGFA> INPHGDBFJHB
	{
		[Cpp2IlInjected.Token(Token = "0x60004C9")]
		[Cpp2IlInjected.Address(RVA = "0x55AEFD0", Offset = "0x55ADDD0", VA = "0x1855AEFD0", Slot = "18")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60004CA")]
		[Cpp2IlInjected.Address(RVA = "0x55AFA50", Offset = "0x55AE850", VA = "0x1855AFA50", Slot = "19")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000048")]
	public event Action<DDICDNFJGFA> CHMJFGPAGAO
	{
		[Cpp2IlInjected.Token(Token = "0x60004CB")]
		[Cpp2IlInjected.Address(RVA = "0x55AF1B0", Offset = "0x55ADFB0", VA = "0x1855AF1B0", Slot = "20")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60004CC")]
		[Cpp2IlInjected.Address(RVA = "0x55AF800", Offset = "0x55AE600", VA = "0x1855AF800", Slot = "21")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000049")]
	public event Action FGJJDPPMNOO
	{
		[Cpp2IlInjected.Token(Token = "0x60004CD")]
		[Cpp2IlInjected.Address(RVA = "0x55AFFC0", Offset = "0x55AEDC0", VA = "0x1855AFFC0", Slot = "22")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60004CE")]
		[Cpp2IlInjected.Address(RVA = "0x55AFE20", Offset = "0x55AEC20", VA = "0x1855AFE20", Slot = "23")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400004A")]
	public event Action<DDICDNFJGFA> KGIEOHODPBB
	{
		[Cpp2IlInjected.Token(Token = "0x60004CF")]
		[Cpp2IlInjected.Address(RVA = "0x55B02D0", Offset = "0x55AF0D0", VA = "0x1855B02D0", Slot = "24")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60004D0")]
		[Cpp2IlInjected.Address(RVA = "0x55B0370", Offset = "0x55AF170", VA = "0x1855B0370", Slot = "25")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60004D2")]
	[Cpp2IlInjected.Address(RVA = "0x55B0AE0", Offset = "0x55AF8E0", VA = "0x1855B0AE0")]
	public ONJKOPDMJON(DDICDNFJGFA FBJBBGAMODK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004D3")]
	[Cpp2IlInjected.Address(RVA = "0x55AF9D0", Offset = "0x55AE7D0", VA = "0x1855AF9D0", Slot = "31")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004D8")]
	[Cpp2IlInjected.Address(RVA = "0x55AF260", Offset = "0x55AE060", VA = "0x1855AF260", Slot = "30")]
	public void CNEDMMKBPIO(DDICDNFJGFA BANCJNAJPLD, bool BNLMFCPNEHF = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004D9")]
	[Cpp2IlInjected.Address(RVA = "0x55AFAF0", Offset = "0x55AE8F0", VA = "0x1855AFAF0", Slot = "6")]
	public void EKJAOBEDMKJ(DDICDNFJGFA KJJPIPKOFKF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004DA")]
	[Cpp2IlInjected.Address(RVA = "0x55B04B0", Offset = "0x55AF2B0", VA = "0x1855B04B0", Slot = "7")]
	public void NHBEELLHAIH(DDICDNFJGFA KJJPIPKOFKF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004DB")]
	[Cpp2IlInjected.Address(RVA = "0x55AF8A0", Offset = "0x55AE6A0", VA = "0x1855AF8A0", Slot = "4")]
	public void DCMJCJJFMCK(DDICDNFJGFA FBJBBGAMODK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004DC")]
	[Cpp2IlInjected.Address(RVA = "0x55B0410", Offset = "0x55AF210", VA = "0x1855B0410", Slot = "5")]
	public void NFAGHCDLJNP(DDICDNFJGFA FBJBBGAMODK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004DD")]
	[Cpp2IlInjected.Address(RVA = "0x55AF940", Offset = "0x55AE740", VA = "0x1855AF940")]
	private void DNLCEJLCJMJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004DE")]
	[Cpp2IlInjected.Address(RVA = "0x55AFDE0", Offset = "0x55AEBE0", VA = "0x1855AFDE0")]
	private void FGPEIDKNALP(DDICDNFJGFA KJJPIPKOFKF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004DF")]
	[Cpp2IlInjected.Address(RVA = "0x55B0710", Offset = "0x55AF510", VA = "0x1855B0710")]
	private void NLLCBPDDMPC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004E0")]
	[Cpp2IlInjected.Address(RVA = "0x55B01A0", Offset = "0x55AEFA0", VA = "0x1855B01A0")]
	private void JCFFDMEDCCE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004E1")]
	[Cpp2IlInjected.Address(RVA = "0x55AEEA0", Offset = "0x55ADCA0", VA = "0x1855AEEA0")]
	private void ADLPDPOLJPI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004E2")]
	[Cpp2IlInjected.Address(RVA = "0x55AEDB0", Offset = "0x55ADBB0", VA = "0x1855AEDB0")]
	[CompilerGenerated]
	private object ABLEOGANKCJ()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000050")]
internal static class HBMGKHLGMPK
{
	[Cpp2IlInjected.Token(Token = "0x60004E3")]
	[Cpp2IlInjected.Address(RVA = "0x5594320", Offset = "0x5593120", VA = "0x185594320")]
	public static BKIGKKEKEEB ACGHEKPJOAH(this DDICDNFJGFA HLKJMHJNLMO)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000051")]
internal sealed class JFAOOEENHJF : FHAPMADIONK, GAMDKECCFOL
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400009D")]
	private readonly LGAGFCAGMMC FBJBBGAMODK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400009E")]
	private readonly global::ENALOFLIEGA<DDICDNFJGFA> HKIIJJNDPDK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400009F")]
	private bool KAMAAJDHGGG;

	[Cpp2IlInjected.Token(Token = "0x17000140")]
	public global::ENALOFLIEGA<DDICDNFJGFA> HJIJPLGACBG
	{
		[Cpp2IlInjected.Token(Token = "0x60004E4")]
		[Cpp2IlInjected.Address(RVA = "0x6FA140", Offset = "0x6F8F40", VA = "0x1806FA140", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000141")]
	public Vector3 DBPFBEOHHOL
	{
		[Cpp2IlInjected.Token(Token = "0x60004E5")]
		[Cpp2IlInjected.Address(RVA = "0x5598EF0", Offset = "0x5597CF0", VA = "0x185598EF0", Slot = "6")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000142")]
	public Vector3 DCGLBLKOGAP
	{
		[Cpp2IlInjected.Token(Token = "0x60004E6")]
		[Cpp2IlInjected.Address(RVA = "0x5598F90", Offset = "0x5597D90", VA = "0x185598F90", Slot = "7")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000143")]
	private Vector3 PJGMOGHAPMH
	{
		[Cpp2IlInjected.Token(Token = "0x60004EA")]
		[Cpp2IlInjected.Address(RVA = "0x5599960", Offset = "0x5598760", VA = "0x185599960")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000144")]
	public DDICDNFJGFA DNBEEAPENJJ
	{
		[Cpp2IlInjected.Token(Token = "0x60004EB")]
		[Cpp2IlInjected.Address(RVA = "0x55998B0", Offset = "0x55986B0", VA = "0x1855998B0", Slot = "5")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60004E7")]
	[Cpp2IlInjected.Address(RVA = "0x5599A40", Offset = "0x5598840", VA = "0x185599A40")]
	public JFAOOEENHJF(DDICDNFJGFA FBJBBGAMODK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004E8")]
	[Cpp2IlInjected.Address(RVA = "0x5598F20", Offset = "0x5597D20", VA = "0x185598F20", Slot = "8")]
	public void EIAOPGGEIPG(DDICDNFJGFA AABHIBJPKOH, object INDCJAMMAIN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004E9")]
	[Cpp2IlInjected.Address(RVA = "0x5599160", Offset = "0x5597F60", VA = "0x185599160", Slot = "9")]
	public void KKMNIALJMDA(object INDCJAMMAIN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004EC")]
	[Cpp2IlInjected.Address(RVA = "0x55991C0", Offset = "0x5597FC0", VA = "0x1855991C0")]
	private Vector3 MADOJPBPDNM()
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x60004ED")]
	[Cpp2IlInjected.Address(RVA = "0x5599510", Offset = "0x5598310", VA = "0x185599510")]
	private void MECGBNEHLHM(DDICDNFJGFA MJLLFCDPBGH)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000052")]
internal static class DGPPJDCDFOP
{
	[Cpp2IlInjected.Token(Token = "0x60004EE")]
	[Cpp2IlInjected.Address(RVA = "0x558D940", Offset = "0x558C740", VA = "0x18558D940")]
	public static FHAPMADIONK GCPGGOCMMEB(this DDICDNFJGFA HLKJMHJNLMO)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000053")]
internal sealed class HAIJFDHJDFC : BNPPIEJEAIK, MLLKELEPLJE
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000A1")]
	private readonly LGAGFCAGMMC FBJBBGAMODK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000A2")]
	private readonly OverridableVector3 ECEDLMGLAPN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40000A3")]
	private readonly OverridableVector3 IKAGKIDIKJA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x40000A4")]
	private float KPEOPFPEIDA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x44")]
	[Cpp2IlInjected.Token(Token = "0x40000A5")]
	private float IIPDIFCPFDF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x40000A6")]
	private Vector3 AKKEPDMOLNJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x54")]
	[Cpp2IlInjected.Token(Token = "0x40000A7")]
	private Vector3? ICCJLPALJKA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x64")]
	[Cpp2IlInjected.Token(Token = "0x40000A8")]
	private Quaternion? PEODBNAIMLE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
	[Cpp2IlInjected.Token(Token = "0x40000A9")]
	private bool PPPJOGGHOMN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x79")]
	[Cpp2IlInjected.Token(Token = "0x40000AA")]
	private bool JMNOJFNDEHP;

	[Cpp2IlInjected.Token(Token = "0x17000145")]
	public Vector3 CDOEBEFDAIG
	{
		[Cpp2IlInjected.Token(Token = "0x60004F1")]
		[Cpp2IlInjected.Address(RVA = "0x1344080", Offset = "0x1342E80", VA = "0x181344080", Slot = "7")]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x60004F2")]
		[Cpp2IlInjected.Address(RVA = "0x55922F0", Offset = "0x55910F0", VA = "0x1855922F0", Slot = "8")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000146")]
	public Vector3 HDLNEGJCDGD
	{
		[Cpp2IlInjected.Token(Token = "0x60004F3")]
		[Cpp2IlInjected.Address(RVA = "0x5592DC0", Offset = "0x5591BC0", VA = "0x185592DC0", Slot = "9")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000147")]
	public float AANJNIAMGBP
	{
		[Cpp2IlInjected.Token(Token = "0x60004F4")]
		[Cpp2IlInjected.Address(RVA = "0x746100", Offset = "0x744F00", VA = "0x180746100", Slot = "10")]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x60004F5")]
		[Cpp2IlInjected.Address(RVA = "0x5592310", Offset = "0x5591110", VA = "0x185592310")]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000148")]
	public float LJPJENEPPAO
	{
		[Cpp2IlInjected.Token(Token = "0x60004F6")]
		[Cpp2IlInjected.Address(RVA = "0x7B5770", Offset = "0x7B4570", VA = "0x1807B5770", Slot = "11")]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x60004F7")]
		[Cpp2IlInjected.Address(RVA = "0x5592750", Offset = "0x5591550", VA = "0x185592750", Slot = "12")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000149")]
	public Vector3 OLHILDGADHC
	{
		[Cpp2IlInjected.Token(Token = "0x60004F8")]
		[Cpp2IlInjected.Address(RVA = "0x5592770", Offset = "0x5591570", VA = "0x185592770", Slot = "13")]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x60004F9")]
		[Cpp2IlInjected.Address(RVA = "0x5592C20", Offset = "0x5591A20", VA = "0x185592C20", Slot = "14")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700014A")]
	public Quaternion FPHMFIFGALL
	{
		[Cpp2IlInjected.Token(Token = "0x60004FA")]
		[Cpp2IlInjected.Address(RVA = "0x5591B50", Offset = "0x5590950", VA = "0x185591B50", Slot = "15")]
		get
		{
			return default(Quaternion);
		}
		[Cpp2IlInjected.Token(Token = "0x60004FB")]
		[Cpp2IlInjected.Address(RVA = "0x55919B0", Offset = "0x55907B0", VA = "0x1855919B0", Slot = "16")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700014B")]
	private Rigidbody AMAINOJCLLB
	{
		[Cpp2IlInjected.Token(Token = "0x6000503")]
		[Cpp2IlInjected.Address(RVA = "0x5590F40", Offset = "0x558FD40", VA = "0x185590F40")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400004B")]
	public event IJDKLAGCEFG MFGECJGMKFM
	{
		[Cpp2IlInjected.Token(Token = "0x60004EF")]
		[Cpp2IlInjected.Address(RVA = "0x5592B80", Offset = "0x5591980", VA = "0x185592B80", Slot = "5")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60004F0")]
		[Cpp2IlInjected.Address(RVA = "0x5592EC0", Offset = "0x5591CC0", VA = "0x185592EC0", Slot = "6")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60004FC")]
	[Cpp2IlInjected.Address(RVA = "0x5594250", Offset = "0x5593050", VA = "0x185594250")]
	public HAIJFDHJDFC(DDICDNFJGFA FBJBBGAMODK, in GPHOCGFKAIA PHAPMEHMHAK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004FD")]
	[Cpp2IlInjected.Address(RVA = "0x5592590", Offset = "0x5591390", VA = "0x185592590", Slot = "18")]
	public void GBIGLFOHPKF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004FE")]
	[Cpp2IlInjected.Address(RVA = "0x5593050", Offset = "0x5591E50", VA = "0x185593050", Slot = "17")]
	public void NFCCEAJGIIH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004FF")]
	[Cpp2IlInjected.Address(RVA = "0x55918D0", Offset = "0x55906D0", VA = "0x1855918D0", Slot = "20")]
	public void AEBCBAGKFLD(Rigidbody EMPCHDNCBNN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000500")]
	[Cpp2IlInjected.Address(RVA = "0x55928E0", Offset = "0x55916E0", VA = "0x1855928E0", Slot = "21")]
	public void IEECHEIALJL(Rigidbody EMPCHDNCBNN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000501")]
	[Cpp2IlInjected.Address(RVA = "0x5591CC0", Offset = "0x5590AC0", VA = "0x185591CC0", Slot = "19")]
	public void DCKPFKGOBFJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000502")]
	[Cpp2IlInjected.Address(RVA = "0x5591E30", Offset = "0x5590C30", VA = "0x185591E30", Slot = "22")]
	public void EGDEMHMFAIF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000504")]
	[Cpp2IlInjected.Address(RVA = "0x55922F0", Offset = "0x55910F0", VA = "0x1855922F0")]
	private void EILFHKFGLGP(Vector3 NLHFEJHKLAH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000505")]
	[Cpp2IlInjected.Address(RVA = "0x5592F60", Offset = "0x5591D60", VA = "0x185592F60")]
	private Vector3 LIJEPHNNHCF()
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000506")]
	[Cpp2IlInjected.Address(RVA = "0x5592310", Offset = "0x5591110", VA = "0x185592310")]
	private void ENLGJFLNHCE(float NLHFEJHKLAH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000507")]
	[Cpp2IlInjected.Address(RVA = "0x5592750", Offset = "0x5591550", VA = "0x185592750")]
	private void GODBLHBGMJM(float NLHFEJHKLAH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000508")]
	[Cpp2IlInjected.Address(RVA = "0x55940D0", Offset = "0x5592ED0", VA = "0x1855940D0")]
	private Vector3 PHDHHMMNCJO()
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000509")]
	[Cpp2IlInjected.Address(RVA = "0x5592C20", Offset = "0x5591A20", VA = "0x185592C20")]
	private void JCKOFPAMPDD(Vector3 NLHFEJHKLAH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600050A")]
	[Cpp2IlInjected.Address(RVA = "0x5592430", Offset = "0x5591230", VA = "0x185592430")]
	private Quaternion FOHIFPKJGHF()
	{
		return default(Quaternion);
	}

	[Cpp2IlInjected.Token(Token = "0x600050B")]
	[Cpp2IlInjected.Address(RVA = "0x55919B0", Offset = "0x55907B0", VA = "0x1855919B0")]
	private void ALHMKJJBOEE(Quaternion NLHFEJHKLAH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600050C")]
	[Cpp2IlInjected.Address(RVA = "0x5593130", Offset = "0x5591F30", VA = "0x185593130")]
	public void OFDNBGNKKFI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600050D")]
	[Cpp2IlInjected.Address(RVA = "0x5593210", Offset = "0x5592010", VA = "0x185593210", Slot = "4")]
	public (float, Vector3) OFDNBGNKKFI(Rigidbody PEDELFDFMBN)
	{
		return default((float, Vector3));
	}
}
[Cpp2IlInjected.Token(Token = "0x2000054")]
internal static class JKLLEDEBBOL
{
	[Cpp2IlInjected.Token(Token = "0x600050E")]
	[Cpp2IlInjected.Address(RVA = "0x5599D70", Offset = "0x5598B70", VA = "0x185599D70")]
	public static BNPPIEJEAIK GOMPCBPMAPG(this DDICDNFJGFA HLKJMHJNLMO)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000055")]
internal sealed class JNGODGHOFLC : FNGFIPOFFHP
{
	[Cpp2IlInjected.Token(Token = "0x40000AB")]
	private const string LPPGLCIKIAN = "INTERP_PAUSE";

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000AC")]
	private readonly LGAGFCAGMMC FBJBBGAMODK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000AD")]
	private readonly JGIJICGALKO EBHMDAPLEHF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000AE")]
	private readonly HOMJCDNLJOD EBLAAKCPACB;

	[Cpp2IlInjected.Token(Token = "0x1700014C")]
	public bool LLNBAIOGACO
	{
		[Cpp2IlInjected.Token(Token = "0x600050F")]
		[Cpp2IlInjected.Address(RVA = "0x1BD5680", Offset = "0x1BD4480", VA = "0x181BD5680", Slot = "4")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700014D")]
	public HOMJCDNLJOD ABGIIBAPFBG
	{
		[Cpp2IlInjected.Token(Token = "0x6000510")]
		[Cpp2IlInjected.Address(RVA = "0x6F68E0", Offset = "0x6F56E0", VA = "0x1806F68E0", Slot = "5")]
		get
		{
			return default(HOMJCDNLJOD);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000511")]
	[Cpp2IlInjected.Address(RVA = "0x559A530", Offset = "0x5599330", VA = "0x18559A530")]
	public JNGODGHOFLC(DDICDNFJGFA FBJBBGAMODK, in GPHOCGFKAIA PHAPMEHMHAK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000512")]
	[Cpp2IlInjected.Address(RVA = "0x559A320", Offset = "0x5599120", VA = "0x18559A320", Slot = "6")]
	public void LOAKFOBCBAO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000513")]
	[Cpp2IlInjected.Address(RVA = "0x559A250", Offset = "0x5599050", VA = "0x18559A250")]
	private bool IAACJGELNIB()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000514")]
	[Cpp2IlInjected.Address(RVA = "0x559A3F0", Offset = "0x55991F0", VA = "0x18559A3F0", Slot = "7")]
	public void NGJAOFAIFPF(object INDCJAMMAIN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000515")]
	[Cpp2IlInjected.Address(RVA = "0x559A2F0", Offset = "0x55990F0", VA = "0x18559A2F0", Slot = "8")]
	public void IBBAPFLAMBM(object INDCJAMMAIN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000516")]
	[Cpp2IlInjected.Address(RVA = "0x5599F20", Offset = "0x5598D20", VA = "0x185599F20", Slot = "11")]
	public void BCLJJENKLCM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000517")]
	[Cpp2IlInjected.Address(RVA = "0x559A420", Offset = "0x5599220", VA = "0x18559A420")]
	private void PCABIMHBCHM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000518")]
	[Cpp2IlInjected.Address(RVA = "0x559A050", Offset = "0x5598E50", VA = "0x18559A050")]
	private void DINEDIMJAEA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000519")]
	[Cpp2IlInjected.Address(RVA = "0x559A210", Offset = "0x5599010", VA = "0x18559A210", Slot = "10")]
	public void FCMKCNHPIFE(DDICDNFJGFA FBJBBGAMODK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600051A")]
	[Cpp2IlInjected.Address(RVA = "0x559A1D0", Offset = "0x5598FD0", VA = "0x18559A1D0", Slot = "9")]
	public void EBNFJGBDCKK(DDICDNFJGFA FBJBBGAMODK)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000056")]
internal sealed class GFBJHGMMKND : BEAHDHOKNPM
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000B0")]
	private readonly LGAGFCAGMMC FBJBBGAMODK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000B1")]
	private readonly JGIJICGALKO JGFKDLHFAGN;

	[Cpp2IlInjected.Token(Token = "0x1700014E")]
	public bool MJPGFBJBMBL
	{
		[Cpp2IlInjected.Token(Token = "0x600051D")]
		[Cpp2IlInjected.Address(RVA = "0x5591650", Offset = "0x5590450", VA = "0x185591650", Slot = "6")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700014F")]
	public IEnumerable<object> OPFBLMNLHBG
	{
		[Cpp2IlInjected.Token(Token = "0x600051E")]
		[Cpp2IlInjected.Address(RVA = "0x5591470", Offset = "0x5590270", VA = "0x185591470", Slot = "7")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400004C")]
	public event IJDKLAGCEFG ALPMDICHCGA
	{
		[Cpp2IlInjected.Token(Token = "0x600051B")]
		[Cpp2IlInjected.Address(RVA = "0x5591490", Offset = "0x5590290", VA = "0x185591490", Slot = "4")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600051C")]
		[Cpp2IlInjected.Address(RVA = "0x55913D0", Offset = "0x55901D0", VA = "0x1855913D0", Slot = "5")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600051F")]
	[Cpp2IlInjected.Address(RVA = "0x5591770", Offset = "0x5590570", VA = "0x185591770")]
	public GFBJHGMMKND(DDICDNFJGFA FBJBBGAMODK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000520")]
	[Cpp2IlInjected.Address(RVA = "0x5591710", Offset = "0x5590510", VA = "0x185591710", Slot = "11")]
	public IDisposable PAOMLEGBIMN()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000521")]
	[Cpp2IlInjected.Address(RVA = "0x5591570", Offset = "0x5590370", VA = "0x185591570", Slot = "8")]
	public void MBDADCCBFHH(object INDCJAMMAIN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000522")]
	[Cpp2IlInjected.Address(RVA = "0x5591560", Offset = "0x5590360", VA = "0x185591560", Slot = "9")]
	public void JKKBAAMOMNK(object INDCJAMMAIN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000523")]
	[Cpp2IlInjected.Address(RVA = "0x55912D0", Offset = "0x55900D0", VA = "0x1855912D0", Slot = "10")]
	public void DNFBGHHNNHM(object INDCJAMMAIN, bool NKIGKALHKKG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000524")]
	[Cpp2IlInjected.Address(RVA = "0x5591250", Offset = "0x5590050", VA = "0x185591250", Slot = "12")]
	public void AEBCBAGKFLD(Rigidbody EBGNLMABMPJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000525")]
	[Cpp2IlInjected.Address(RVA = "0x5591530", Offset = "0x5590330", VA = "0x185591530", Slot = "13")]
	public void IEECHEIALJL(Rigidbody EMPCHDNCBNN)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000057")]
internal sealed class ECCPEAAAPCE : FCFGELJEDJL, DLGODMNJHEI, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000B3")]
	private readonly LGAGFCAGMMC FBJBBGAMODK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000B4")]
	private PhotonView PADBKMIMBKI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40000B5")]
	private bool ONHKKANNFKE;

	[Cpp2IlInjected.Token(Token = "0x17000150")]
	public PhotonView FBIKDNHOMKO
	{
		[Cpp2IlInjected.Token(Token = "0x6000528")]
		[Cpp2IlInjected.Address(RVA = "0x6FA130", Offset = "0x6F8F30", VA = "0x1806FA130", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000151")]
	public bool HJEPBPJAOBD
	{
		[Cpp2IlInjected.Token(Token = "0x6000529")]
		[Cpp2IlInjected.Address(RVA = "0x558B840", Offset = "0x558A640", VA = "0x18558B840", Slot = "7")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000152")]
	public bool BCEMFENGFMG
	{
		[Cpp2IlInjected.Token(Token = "0x600052A")]
		[Cpp2IlInjected.Address(RVA = "0x82D580", Offset = "0x82C380", VA = "0x18082D580", Slot = "8")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400004D")]
	public event IJDKLAGCEFG OIHJCECPHEI
	{
		[Cpp2IlInjected.Token(Token = "0x6000526")]
		[Cpp2IlInjected.Address(RVA = "0x558F420", Offset = "0x558E220", VA = "0x18558F420", Slot = "5")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000527")]
		[Cpp2IlInjected.Address(RVA = "0x558F5D0", Offset = "0x558E3D0", VA = "0x18558F5D0", Slot = "6")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600052B")]
	[Cpp2IlInjected.Address(RVA = "0x5590050", Offset = "0x558EE50", VA = "0x185590050")]
	public ECCPEAAAPCE(DDICDNFJGFA FBJBBGAMODK, in GPHOCGFKAIA PHAPMEHMHAK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600052C")]
	[Cpp2IlInjected.Address(RVA = "0x558FF00", Offset = "0x558ED00", VA = "0x18558FF00", Slot = "9")]
	public void LOAKFOBCBAO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600052D")]
	[Cpp2IlInjected.Address(RVA = "0x558F4C0", Offset = "0x558E2C0", VA = "0x18558F4C0", Slot = "12")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600052E")]
	[Cpp2IlInjected.Address(RVA = "0x558FD70", Offset = "0x558EB70", VA = "0x18558FD70", Slot = "10")]
	public void LJCPKLHMCNP(DDICDNFJGFA AABHIBJPKOH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600052F")]
	[Cpp2IlInjected.Address(RVA = "0x558F670", Offset = "0x558E470", VA = "0x18558F670", Slot = "11")]
	public void GNGIENKKJBL(DDICDNFJGFA AABHIBJPKOH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000530")]
	[Cpp2IlInjected.Address(RVA = "0x558FA80", Offset = "0x558E880", VA = "0x18558FA80")]
	private void KLKNNHDEOCL(PhotonView BOMECHFAFIA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000531")]
	[Cpp2IlInjected.Address(RVA = "0x558FC00", Offset = "0x558EA00", VA = "0x18558FC00")]
	private void LGPNLNCNAKA(RigidbodyEx HHGLALPDJJA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000532")]
	[Cpp2IlInjected.Address(RVA = "0x558F800", Offset = "0x558E600", VA = "0x18558F800")]
	private void IFJKCLJGPIH(PhotonView BPDDMBDBBEB)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000058")]
internal static class PHKHPKKELCK
{
	[Cpp2IlInjected.Token(Token = "0x6000533")]
	[Cpp2IlInjected.Address(RVA = "0x55B0B90", Offset = "0x55AF990", VA = "0x1855B0B90")]
	public static FCFGELJEDJL DCJCLGPHNIE(this DDICDNFJGFA HLKJMHJNLMO)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000059")]
internal sealed class JKEEGJHKIBM : DKCDJJILPGD
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000B6")]
	private readonly LGAGFCAGMMC FBJBBGAMODK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000B7")]
	private RigidbodyConstraints FBGFEDKLKMO;

	[Cpp2IlInjected.Token(Token = "0x17000153")]
	public bool DKOAFEFPELM
	{
		[Cpp2IlInjected.Token(Token = "0x6000534")]
		[Cpp2IlInjected.Address(RVA = "0x7717B0", Offset = "0x7705B0", VA = "0x1807717B0", Slot = "4")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000535")]
		[Cpp2IlInjected.Address(RVA = "0x7717C0", Offset = "0x7705C0", VA = "0x1807717C0", Slot = "5")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000154")]
	public bool MLGKJIBDAPE
	{
		[Cpp2IlInjected.Token(Token = "0x6000536")]
		[Cpp2IlInjected.Address(RVA = "0x9E0BE0", Offset = "0x9DF9E0", VA = "0x1809E0BE0", Slot = "6")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000537")]
		[Cpp2IlInjected.Address(RVA = "0x9E0ED0", Offset = "0x9DFCD0", VA = "0x1809E0ED0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000155")]
	public RigidbodyConstraints PDLJENDCEHJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000538")]
		[Cpp2IlInjected.Address(RVA = "0x719080", Offset = "0x717E80", VA = "0x180719080", Slot = "7")]
		get
		{
			return default(RigidbodyConstraints);
		}
		[Cpp2IlInjected.Token(Token = "0x6000539")]
		[Cpp2IlInjected.Address(RVA = "0x5599B60", Offset = "0x5598960", VA = "0x185599B60", Slot = "8")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600053A")]
	[Cpp2IlInjected.Address(RVA = "0x5599CD0", Offset = "0x5598AD0", VA = "0x185599CD0")]
	public JKEEGJHKIBM(DDICDNFJGFA FBJBBGAMODK, in GPHOCGFKAIA PHAPMEHMHAK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600053B")]
	[Cpp2IlInjected.Address(RVA = "0x5599B30", Offset = "0x5598930", VA = "0x185599B30", Slot = "9")]
	public void AEBCBAGKFLD(Rigidbody EMPCHDNCBNN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600053C")]
	[Cpp2IlInjected.Address(RVA = "0x5599CA0", Offset = "0x5598AA0", VA = "0x185599CA0", Slot = "10")]
	public void IEECHEIALJL(Rigidbody EMPCHDNCBNN)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200005A")]
internal sealed class DCOAMGAMMOB : CJKBMGEKBFD
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000BA")]
	private readonly DDICDNFJGFA FBJBBGAMODK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000BB")]
	private float NNMCIFGABFK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
	[Cpp2IlInjected.Token(Token = "0x40000BC")]
	private float BBCMEKLILBH;

	[Cpp2IlInjected.Token(Token = "0x17000156")]
	public float EGNLMBHDOFH
	{
		[Cpp2IlInjected.Token(Token = "0x600053E")]
		[Cpp2IlInjected.Address(RVA = "0x87B100", Offset = "0x879F00", VA = "0x18087B100", Slot = "4")]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x600053F")]
		[Cpp2IlInjected.Address(RVA = "0x558D6C0", Offset = "0x558C4C0", VA = "0x18558D6C0", Slot = "5")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000157")]
	public float NPBKEBDHMEK
	{
		[Cpp2IlInjected.Token(Token = "0x6000540")]
		[Cpp2IlInjected.Address(RVA = "0x8A7360", Offset = "0x8A6160", VA = "0x1808A7360", Slot = "6")]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x6000541")]
		[Cpp2IlInjected.Address(RVA = "0x558D790", Offset = "0x558C590", VA = "0x18558D790", Slot = "7")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600053D")]
	[Cpp2IlInjected.Address(RVA = "0x558D900", Offset = "0x558C700", VA = "0x18558D900")]
	public DCOAMGAMMOB(DDICDNFJGFA FBJBBGAMODK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000542")]
	[Cpp2IlInjected.Address(RVA = "0x558D670", Offset = "0x558C470", VA = "0x18558D670", Slot = "8")]
	public void AEBCBAGKFLD(Rigidbody EMPCHDNCBNN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000543")]
	[Cpp2IlInjected.Address(RVA = "0x558D860", Offset = "0x558C660", VA = "0x18558D860", Slot = "9")]
	public void IEECHEIALJL(Rigidbody EMPCHDNCBNN)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200005B")]
internal sealed class GDIBPNDMIAO : POBKPFCFBME
{
	[Cpp2IlInjected.Token(Token = "0x40000BD")]
	private const int GPOBOJJCCAO = 10;

	[Cpp2IlInjected.Token(Token = "0x40000BE")]
	private const float IFBKGDFGGOH = 9E-05f;

	[Cpp2IlInjected.Token(Token = "0x40000BF")]
	private const float PEKOFFEBAOJ = 0.0001f;

	[Cpp2IlInjected.Token(Token = "0x40000C0")]
	private const float CGNJMCKHGCP = 5f;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000C2")]
	private readonly LGAGFCAGMMC FBJBBGAMODK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000C3")]
	private bool AKGIKOKHMNM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x21")]
	[Cpp2IlInjected.Token(Token = "0x40000C4")]
	private bool IHCOABMCKGM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
	[Cpp2IlInjected.Token(Token = "0x40000C5")]
	private int CAJDDDHLMAI;

	[Cpp2IlInjected.Token(Token = "0x17000158")]
	private Rigidbody AMAINOJCLLB
	{
		[Cpp2IlInjected.Token(Token = "0x6000546")]
		[Cpp2IlInjected.Address(RVA = "0x5590F40", Offset = "0x558FD40", VA = "0x185590F40")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000159")]
	private bool PFNGAONDKCN
	{
		[Cpp2IlInjected.Token(Token = "0x6000547")]
		[Cpp2IlInjected.Address(RVA = "0x5591120", Offset = "0x558FF20", VA = "0x185591120")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700015A")]
	private bool BIBDGFIAGJM
	{
		[Cpp2IlInjected.Token(Token = "0x6000548")]
		[Cpp2IlInjected.Address(RVA = "0x5590F20", Offset = "0x558FD20", VA = "0x185590F20")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700015B")]
	private DDICDNFJGFA KFPCMBOLNGI
	{
		[Cpp2IlInjected.Token(Token = "0x6000549")]
		[Cpp2IlInjected.Address(RVA = "0x5590D90", Offset = "0x558FB90", VA = "0x185590D90")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700015C")]
	private bool FGHFGPDIBIE
	{
		[Cpp2IlInjected.Token(Token = "0x600054A")]
		[Cpp2IlInjected.Address(RVA = "0x5590BA0", Offset = "0x558F9A0", VA = "0x185590BA0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400004E")]
	public event IJDKLAGCEFG JLFHAPOODCF
	{
		[Cpp2IlInjected.Token(Token = "0x6000544")]
		[Cpp2IlInjected.Address(RVA = "0x5590B00", Offset = "0x558F900", VA = "0x185590B00", Slot = "4")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000545")]
		[Cpp2IlInjected.Address(RVA = "0x5590680", Offset = "0x558F480", VA = "0x185590680", Slot = "5")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600054B")]
	[Cpp2IlInjected.Address(RVA = "0x55911C0", Offset = "0x558FFC0", VA = "0x1855911C0")]
	public GDIBPNDMIAO(DDICDNFJGFA FBJBBGAMODK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600054C")]
	[Cpp2IlInjected.Address(RVA = "0x5590DF0", Offset = "0x558FBF0", VA = "0x185590DF0", Slot = "6")]
	public void LOAKFOBCBAO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600054D")]
	[Cpp2IlInjected.Address(RVA = "0x5590AF0", Offset = "0x558F8F0", VA = "0x185590AF0", Slot = "8")]
	public void GNEECPBPGHC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600054E")]
	[Cpp2IlInjected.Address(RVA = "0x5590FD0", Offset = "0x558FDD0", VA = "0x185590FD0", Slot = "7")]
	public bool OMBGDMJFHEI()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600054F")]
	[Cpp2IlInjected.Address(RVA = "0x5590E80", Offset = "0x558FC80", VA = "0x185590E80", Slot = "9")]
	public void MNLNBCJHPMD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000550")]
	[Cpp2IlInjected.Address(RVA = "0x5590720", Offset = "0x558F520", VA = "0x185590720", Slot = "11")]
	public void EDKDBDBJFEP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000551")]
	[Cpp2IlInjected.Address(RVA = "0x5590F90", Offset = "0x558FD90", VA = "0x185590F90", Slot = "12")]
	public void OKNIAACKICL(bool NOEDBDPFICH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000552")]
	[Cpp2IlInjected.Address(RVA = "0x55907C0", Offset = "0x558F5C0", VA = "0x1855907C0", Slot = "10")]
	public void GGADMLLPLHE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000553")]
	[Cpp2IlInjected.Address(RVA = "0x55904D0", Offset = "0x558F2D0", VA = "0x1855904D0")]
	private bool ANHIIFAOGNF()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000554")]
	[Cpp2IlInjected.Address(RVA = "0x5590C00", Offset = "0x558FA00", VA = "0x185590C00")]
	private void IDKEIDAJDMP()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200005C")]
internal sealed class JEALKMIGHEG : AOJBGIGFLEC
{
	[Cpp2IlInjected.Token(Token = "0x40000C6")]
	private const string DJFEDHMLDMM = "RBEX_ANIM";

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000C7")]
	private readonly LGAGFCAGMMC FBJBBGAMODK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000C8")]
	private readonly JGIJICGALKO ELMAOBHMFJJ;

	[Cpp2IlInjected.Token(Token = "0x1700015D")]
	public Rigidbody AMAINOJCLLB
	{
		[Cpp2IlInjected.Token(Token = "0x6000555")]
		[Cpp2IlInjected.Address(RVA = "0x6FA130", Offset = "0x6F8F30", VA = "0x1806FA130", Slot = "4")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000556")]
		[Cpp2IlInjected.Address(RVA = "0x71C2B0", Offset = "0x71B0B0", VA = "0x18071C2B0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700015E")]
	private bool FGHFGPDIBIE
	{
		[Cpp2IlInjected.Token(Token = "0x6000557")]
		[Cpp2IlInjected.Address(RVA = "0x55981C0", Offset = "0x5596FC0", VA = "0x1855981C0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000558")]
	[Cpp2IlInjected.Address(RVA = "0x5598E00", Offset = "0x5597C00", VA = "0x185598E00")]
	public JEALKMIGHEG(DDICDNFJGFA FBJBBGAMODK, in GPHOCGFKAIA PHAPMEHMHAK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000559")]
	[Cpp2IlInjected.Address(RVA = "0x5598730", Offset = "0x5597530", VA = "0x185598730", Slot = "5")]
	public void LOAKFOBCBAO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600055A")]
	[Cpp2IlInjected.Address(RVA = "0x5597DB0", Offset = "0x5596BB0", VA = "0x185597DB0", Slot = "6")]
	public void BGFCCCENBID(object INDCJAMMAIN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600055B")]
	[Cpp2IlInjected.Address(RVA = "0x5597FE0", Offset = "0x5596DE0", VA = "0x185597FE0", Slot = "7")]
	public void GPBOKOEIFJD(object INDCJAMMAIN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600055C")]
	[Cpp2IlInjected.Address(RVA = "0x5598220", Offset = "0x5597020", VA = "0x185598220", Slot = "8")]
	public void JKEHEGMHNBP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600055D")]
	[Cpp2IlInjected.Address(RVA = "0x5597DE0", Offset = "0x5596BE0", VA = "0x185597DE0", Slot = "9")]
	public void FEMJINFCLKB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600055E")]
	[Cpp2IlInjected.Address(RVA = "0x55987E0", Offset = "0x55975E0", VA = "0x1855987E0", Slot = "10")]
	public void MDGAEMKGBPG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600055F")]
	[Cpp2IlInjected.Address(RVA = "0x5598960", Offset = "0x5597760", VA = "0x185598960", Slot = "11")]
	public void OCGHJADDJFG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000560")]
	[Cpp2IlInjected.Address(RVA = "0x5598010", Offset = "0x5596E10", VA = "0x185598010")]
	private void HLEOOMPJMMG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000561")]
	[Cpp2IlInjected.Address(RVA = "0x5598580", Offset = "0x5597380", VA = "0x185598580")]
	private void LHLOOPANHAF()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200005D")]
internal sealed class IGDCHCJGJIP : AOLDALECDIP, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000CA")]
	private readonly LGAGFCAGMMC FBJBBGAMODK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000CB")]
	private readonly JGIJICGALKO OAGMOMDIGIK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000CC")]
	private float PABCBKHCJID;

	[Cpp2IlInjected.Token(Token = "0x1700015F")]
	public MDNFIBKLANB NBOHDJLOFIN
	{
		[Cpp2IlInjected.Token(Token = "0x6000562")]
		[Cpp2IlInjected.Address(RVA = "0x6FA2D0", Offset = "0x6F90D0", VA = "0x1806FA2D0", Slot = "4")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000563")]
		[Cpp2IlInjected.Address(RVA = "0x765100", Offset = "0x763F00", VA = "0x180765100", Slot = "5")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000160")]
	public IGIPPOIEHFL KGJELLKCKGD
	{
		[Cpp2IlInjected.Token(Token = "0x6000564")]
		[Cpp2IlInjected.Address(RVA = "0x718560", Offset = "0x717360", VA = "0x180718560", Slot = "6")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000565")]
		[Cpp2IlInjected.Address(RVA = "0x7650F0", Offset = "0x763EF0", VA = "0x1807650F0", Slot = "7")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000161")]
	public Vector3 PJGMOGHAPMH
	{
		[Cpp2IlInjected.Token(Token = "0x6000566")]
		[Cpp2IlInjected.Address(RVA = "0x5596F60", Offset = "0x5595D60", VA = "0x185596F60", Slot = "8")]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x6000567")]
		[Cpp2IlInjected.Address(RVA = "0x55969F0", Offset = "0x55957F0", VA = "0x1855969F0", Slot = "9")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000162")]
	public Vector3 PLFFIHHKHOJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000568")]
		[Cpp2IlInjected.Address(RVA = "0x5596AB0", Offset = "0x55958B0", VA = "0x185596AB0", Slot = "10")]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x6000569")]
		[Cpp2IlInjected.Address(RVA = "0x5594B10", Offset = "0x5593910", VA = "0x185594B10", Slot = "11")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000163")]
	public Vector3 BEOEJBBFCKO
	{
		[Cpp2IlInjected.Token(Token = "0x600056A")]
		[Cpp2IlInjected.Address(RVA = "0x55955E0", Offset = "0x55943E0", VA = "0x1855955E0", Slot = "12")]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x600056B")]
		[Cpp2IlInjected.Address(RVA = "0x5597080", Offset = "0x5595E80", VA = "0x185597080", Slot = "13")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000164")]
	public Vector3 HNKEAHNHOFC
	{
		[Cpp2IlInjected.Token(Token = "0x600056C")]
		[Cpp2IlInjected.Address(RVA = "0x5596E70", Offset = "0x5595C70", VA = "0x185596E70", Slot = "14")]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x600056D")]
		[Cpp2IlInjected.Address(RVA = "0x5596DE0", Offset = "0x5595BE0", VA = "0x185596DE0", Slot = "15")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000165")]
	public float ELIKFBMBBPJ
	{
		[Cpp2IlInjected.Token(Token = "0x600056E")]
		[Cpp2IlInjected.Address(RVA = "0x706AE0", Offset = "0x7058E0", VA = "0x180706AE0", Slot = "16")]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x600056F")]
		[Cpp2IlInjected.Address(RVA = "0x5595480", Offset = "0x5594280", VA = "0x185595480", Slot = "17")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000166")]
	public bool OGCFEGMFPMP
	{
		[Cpp2IlInjected.Token(Token = "0x6000570")]
		[Cpp2IlInjected.Address(RVA = "0x1338E90", Offset = "0x1337C90", VA = "0x181338E90", Slot = "18")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000167")]
	private CFLNOOGGMLK NNHFHKHABOA
	{
		[Cpp2IlInjected.Token(Token = "0x6000585")]
		[Cpp2IlInjected.Address(RVA = "0x2082E90", Offset = "0x2081C90", VA = "0x182082E90")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000168")]
	private bool BIBDGFIAGJM
	{
		[Cpp2IlInjected.Token(Token = "0x6000586")]
		[Cpp2IlInjected.Address(RVA = "0x5596E10", Offset = "0x5595C10", VA = "0x185596E10")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000571")]
	[Cpp2IlInjected.Address(RVA = "0x5597540", Offset = "0x5596340", VA = "0x185597540")]
	public IGDCHCJGJIP(DDICDNFJGFA FBJBBGAMODK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000572")]
	[Cpp2IlInjected.Address(RVA = "0x55948A0", Offset = "0x55936A0", VA = "0x1855948A0", Slot = "19")]
	public void LOAKFOBCBAO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000573")]
	[Cpp2IlInjected.Address(RVA = "0x5595170", Offset = "0x5593F70", VA = "0x185595170", Slot = "37")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000574")]
	[Cpp2IlInjected.Address(RVA = "0x5594770", Offset = "0x5593570", VA = "0x185594770", Slot = "28")]
	public void AEBCBAGKFLD(Rigidbody EMPCHDNCBNN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000575")]
	[Cpp2IlInjected.Address(RVA = "0x1338400", Offset = "0x1337200", VA = "0x181338400", Slot = "20")]
	public void EILCMEIBKHF(object INDCJAMMAIN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000576")]
	[Cpp2IlInjected.Address(RVA = "0x13389C0", Offset = "0x13377C0", VA = "0x1813389C0", Slot = "31")]
	public void IKJFANGIDNB(object INDCJAMMAIN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000577")]
	[Cpp2IlInjected.Address(RVA = "0x5594F90", Offset = "0x5593D90", VA = "0x185594F90", Slot = "36")]
	public Vector3 DKGOLPKDCPG(Vector3 LGHPPABOKOK)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000578")]
	[Cpp2IlInjected.Address(RVA = "0x55951D0", Offset = "0x5593FD0", VA = "0x1855951D0", Slot = "35")]
	public Vector3 EHCFPONMFKA(Vector3 AFLGANKGICH)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000579")]
	[Cpp2IlInjected.Address(RVA = "0x55948A0", Offset = "0x55936A0", VA = "0x1855948A0", Slot = "27")]
	public void AGCPJAHILEP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600057A")]
	[Cpp2IlInjected.Address(RVA = "0x55955A0", Offset = "0x55943A0", VA = "0x1855955A0", Slot = "25")]
	public void FIIAJOAMNGJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600057B")]
	[Cpp2IlInjected.Address(RVA = "0x5596E30", Offset = "0x5595C30", VA = "0x185596E30", Slot = "24")]
	public void OGCLLIMCEGK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600057C")]
	[Cpp2IlInjected.Address(RVA = "0x5596BA0", Offset = "0x55959A0", VA = "0x185596BA0", Slot = "34")]
	public void NFJDLDDEJMF(Vector3 IMMOLPOLNBA, Vector3 OGMHJOIPEGI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600057D")]
	[Cpp2IlInjected.Address(RVA = "0x5596990", Offset = "0x5595790", VA = "0x185596990", Slot = "33")]
	public void MODKKAHENJA(Vector3 IAOEEAAKMPP, Vector3 IDJHMKHCMIA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600057E")]
	[Cpp2IlInjected.Address(RVA = "0x5595840", Offset = "0x5594640", VA = "0x185595840", Slot = "32")]
	public void GGCHAGHHFEC(Vector3 GKPHCGNAJHA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600057F")]
	[Cpp2IlInjected.Address(RVA = "0x5594B40", Offset = "0x5593940", VA = "0x185594B40", Slot = "22")]
	public void DCKBJJIFEAA(GOIGKHJPKIL LKEHIILFBGJ, Vector3 CPJPNJCMJAL, float LJKLGGMAHOJ, float LHJEDBKLJNN = 8f, float PAKBBNDEEJP = 1f)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000580")]
	[Cpp2IlInjected.Address(RVA = "0x55963A0", Offset = "0x55951A0", VA = "0x1855963A0", Slot = "21")]
	public void LDIFLICNPJP(OEBNECHHPCF GDDGFGKAHMD, Vector3 BNCCLPFNHEL, float JEMKJHNONPD = float.PositiveInfinity)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000581")]
	[Cpp2IlInjected.Address(RVA = "0x55966C0", Offset = "0x55954C0", VA = "0x1855966C0", Slot = "23")]
	[Obsolete]
	public void MKPHELIMAAE(OEBNECHHPCF GDDGFGKAHMD, Vector3 HKMKNOBAIAN, float NIDEHIHCIBC = 7f, float DLGLDDADCFL = 1f)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000582")]
	[Cpp2IlInjected.Address(RVA = "0x5597140", Offset = "0x5595F40", VA = "0x185597140", Slot = "30")]
	public Vector3 PKBLILEEDPH(Vector3 POJKCICHJIK)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000583")]
	[Cpp2IlInjected.Address(RVA = "0x5595390", Offset = "0x5594190", VA = "0x185595390", Slot = "29")]
	public Vector3 EIEKMNNPHJM(Vector3 EOPDAFKMAEL)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000584")]
	[Cpp2IlInjected.Address(RVA = "0x5595710", Offset = "0x5594510", VA = "0x185595710", Slot = "26")]
	public void FLNLDAANDPM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000587")]
	[Cpp2IlInjected.Address(RVA = "0x5595480", Offset = "0x5594280", VA = "0x185595480")]
	private void HPMLJAFDPLE(float NLHFEJHKLAH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000588")]
	[Cpp2IlInjected.Address(RVA = "0x5594910", Offset = "0x5593710", VA = "0x185594910")]
	private void AJHFCOPCJNN(Vector3 BNCCLPFNHEL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000589")]
	[Cpp2IlInjected.Address(RVA = "0x55965D0", Offset = "0x55953D0", VA = "0x1855965D0")]
	private Vector3 MABFLBDPGAE()
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x600058A")]
	[Cpp2IlInjected.Address(RVA = "0x5595980", Offset = "0x5594780", VA = "0x185595980")]
	private void IHLHMKLCJAF(Vector3 AFLGANKGICH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600058B")]
	[Cpp2IlInjected.Address(RVA = "0x55962B0", Offset = "0x55950B0", VA = "0x1855962B0")]
	private Vector3 JMOPBFHFCID()
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x600058C")]
	[Cpp2IlInjected.Address(RVA = "0x5597200", Offset = "0x5596000", VA = "0x185597200")]
	private void POKIOJNPKHO(Vector3 NLHFEJHKLAH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600058D")]
	[Cpp2IlInjected.Address(RVA = "0x5595CB0", Offset = "0x5594AB0", VA = "0x185595CB0")]
	private void JBCKPFMEHFP(Vector3 AFLGANKGICH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600058E")]
	[Cpp2IlInjected.Address(RVA = "0x5594A50", Offset = "0x5593850", VA = "0x185594A50")]
	private void BDJKJNDAGFI()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200005E")]
public class KFFMCAKCBDP : JBGBBADNNKI
{
	[Cpp2IlInjected.Token(Token = "0x600058F")]
	[Cpp2IlInjected.Address(RVA = "0x559F9B0", Offset = "0x559E7B0", VA = "0x18559F9B0", Slot = "4")]
	public HIBPGMCCMFF ODMBDIEIOMA(DDICDNFJGFA HLKJMHJNLMO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000590")]
	[Cpp2IlInjected.Address(RVA = "0x559F5C0", Offset = "0x559E3C0", VA = "0x18559F5C0", Slot = "5")]
	public AOLDALECDIP KNCMDJEDGGK(DDICDNFJGFA HLKJMHJNLMO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000591")]
	[Cpp2IlInjected.Address(RVA = "0x559EE20", Offset = "0x559DC20", VA = "0x18559EE20", Slot = "6")]
	public GAMDKECCFOL AEHFFFLMJDA(DDICDNFJGFA HLKJMHJNLMO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000592")]
	[Cpp2IlInjected.Address(RVA = "0x559F030", Offset = "0x559DE30", VA = "0x18559F030", Slot = "7")]
	public CJKBMGEKBFD CJKEFKMGDFF(DDICDNFJGFA HLKJMHJNLMO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000593")]
	[Cpp2IlInjected.Address(RVA = "0x559F780", Offset = "0x559E580", VA = "0x18559F780", Slot = "8")]
	public POBKPFCFBME MIMODMCOGJE(DDICDNFJGFA HLKJMHJNLMO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000594")]
	[Cpp2IlInjected.Address(RVA = "0x559F840", Offset = "0x559E640", VA = "0x18559F840", Slot = "9")]
	public OIINLPAMLAF MNKKINFOOKF(DDICDNFJGFA HLKJMHJNLMO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000595")]
	[Cpp2IlInjected.Address(RVA = "0x559F170", Offset = "0x559DF70", VA = "0x18559F170", Slot = "10")]
	public BEAHDHOKNPM EEDOPDIIDJK(DDICDNFJGFA HLKJMHJNLMO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000596")]
	[Cpp2IlInjected.Address(RVA = "0x559F6D0", Offset = "0x559E4D0", VA = "0x18559F6D0", Slot = "11")]
	public CFLNOOGGMLK MCAIGKKPOHN(DDICDNFJGFA HLKJMHJNLMO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000597")]
	[Cpp2IlInjected.Address(RVA = "0x559F510", Offset = "0x559E310", VA = "0x18559F510", Slot = "12")]
	public HFDAKPEHNOJ KNBBHFIPCJE(DDICDNFJGFA HLKJMHJNLMO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000598")]
	[Cpp2IlInjected.Address(RVA = "0x559F390", Offset = "0x559E190", VA = "0x18559F390", Slot = "13")]
	public NHHNBAGKHPP FNMGNBNMLED(DDICDNFJGFA HLKJMHJNLMO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000599")]
	[Cpp2IlInjected.Address(RVA = "0x559ED00", Offset = "0x559DB00", VA = "0x18559ED00")]
	public AOJBGIGFLEC ACIELHPKKNP(DDICDNFJGFA HLKJMHJNLMO, in GPHOCGFKAIA PHAPMEHMHAK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600059A")]
	[Cpp2IlInjected.Address(RVA = "0x559F440", Offset = "0x559E240", VA = "0x18559F440")]
	public DLGODMNJHEI LNPJJLOGHBC(DDICDNFJGFA HLKJMHJNLMO, in GPHOCGFKAIA PHAPMEHMHAK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600059B")]
	[Cpp2IlInjected.Address(RVA = "0x559F270", Offset = "0x559E070", VA = "0x18559F270")]
	public FNGFIPOFFHP JGEPKOMAJKF(DDICDNFJGFA HLKJMHJNLMO, in GPHOCGFKAIA PHAPMEHMHAK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600059C")]
	[Cpp2IlInjected.Address(RVA = "0x559EF30", Offset = "0x559DD30", VA = "0x18559EF30")]
	public MLLKELEPLJE AIFAIDNENNF(DDICDNFJGFA HLKJMHJNLMO, in GPHOCGFKAIA PHAPMEHMHAK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600059D")]
	[Cpp2IlInjected.Address(RVA = "0x559F0A0", Offset = "0x559DEA0", VA = "0x18559F0A0")]
	public DKCDJJILPGD DODAKANPHCJ(DDICDNFJGFA HLKJMHJNLMO, in GPHOCGFKAIA PHAPMEHMHAK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600059E")]
	[Cpp2IlInjected.Address(RVA = "0x559F900", Offset = "0x559E700", VA = "0x18559F900", Slot = "19")]
	public DDICDNFJGFA NJANEGHFIMH(RigidbodyEx FBJBBGAMODK, GPHOCGFKAIA PHAPMEHMHAK, BABOKGOAEJI OBAPIKNALOO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600059F")]
	[Cpp2IlInjected.Address(RVA = "0x6ECCD0", Offset = "0x6EBAD0", VA = "0x1806ECCD0")]
	public KFFMCAKCBDP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60005A0")]
	[Cpp2IlInjected.Address(RVA = "0x559ED00", Offset = "0x559DB00", VA = "0x18559ED00", Slot = "14")]
	private AOJBGIGFLEC MPFABIOFLCH(DDICDNFJGFA HLKJMHJNLMO, in GPHOCGFKAIA PHAPMEHMHAK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60005A1")]
	[Cpp2IlInjected.Address(RVA = "0x559F440", Offset = "0x559E240", VA = "0x18559F440", Slot = "15")]
	private DLGODMNJHEI HGJFHGJOCMM(DDICDNFJGFA HLKJMHJNLMO, in GPHOCGFKAIA PHAPMEHMHAK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60005A2")]
	[Cpp2IlInjected.Address(RVA = "0x559F270", Offset = "0x559E070", VA = "0x18559F270", Slot = "16")]
	private FNGFIPOFFHP FBFOCLJHIDA(DDICDNFJGFA HLKJMHJNLMO, in GPHOCGFKAIA PHAPMEHMHAK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60005A3")]
	[Cpp2IlInjected.Address(RVA = "0x559EF30", Offset = "0x559DD30", VA = "0x18559EF30", Slot = "17")]
	private MLLKELEPLJE DPCLCLENFCB(DDICDNFJGFA HLKJMHJNLMO, in GPHOCGFKAIA PHAPMEHMHAK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60005A4")]
	[Cpp2IlInjected.Address(RVA = "0x559F0A0", Offset = "0x559DEA0", VA = "0x18559F0A0", Slot = "18")]
	private DKCDJJILPGD PGPHKHMHHBM(DDICDNFJGFA HLKJMHJNLMO, in GPHOCGFKAIA PHAPMEHMHAK)
	{
		return null;
	}
}
namespace RRAssemblyIndex.RecRoom.Rbex.Runtime
{
	[Cpp2IlInjected.Token(Token = "0x200005F")]
	[Preserve]
	internal class _RRAssemblyIndex : GIHBEMJPMJA
	{
		[Cpp2IlInjected.Token(Token = "0x60005A5")]
		[Cpp2IlInjected.Address(RVA = "0x718780", Offset = "0x717580", VA = "0x180718780")]
		[Preserve]
		public _RRAssemblyIndex()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005A6")]
		[Cpp2IlInjected.Address(RVA = "0x65B9350", Offset = "0x65B8150", VA = "0x1865B9350", Slot = "6")]
		public sealed override void HAGKABNBGAM(BFAIPCIBIIK JDLJMIHPPKE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005A7")]
		[Cpp2IlInjected.Address(RVA = "0x65B9530", Offset = "0x65B8330", VA = "0x1865B9530", Slot = "4")]
		public sealed override void HLFKGNEPEFG()
		{
		}
	}
}
[StructLayout((LayoutKind)3, CharSet = CharSet.Auto)]
[Cpp2IlInjected.Token(Token = "0x2000060")]
public class KNPJDABNJNB
{
	[Cpp2IlInjected.Token(Token = "0x40000CF")]
	private static byte[] KJPEJCPNACN;

	[Cpp2IlInjected.Token(Token = "0x40000D0")]
	private static int ENGDLONOMNK;

	[Cpp2IlInjected.Token(Token = "0x40000D1")]
	private static int IBOHBKOLMLK;

	[Cpp2IlInjected.Token(Token = "0x40000D2")]
	private static BigInteger BMOFNNOLMPE;

	[Cpp2IlInjected.Token(Token = "0x60005A8")]
	[Cpp2IlInjected.Address(RVA = "0x6ECCD0", Offset = "0x6EBAD0", VA = "0x1806ECCD0")]
	public KNPJDABNJNB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60005AA")]
	[Cpp2IlInjected.Address(RVA = "0x559FA90", Offset = "0x559E890", VA = "0x18559FA90")]
	private static string NKHPLDDEAIA(byte[] MIECAKFJHNF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60005AB")]
	[Cpp2IlInjected.Address(RVA = "0x559FBA0", Offset = "0x559E9A0", VA = "0x18559FBA0")]
	public static string OEIELDLCBEJ(byte[] NJGGJPEFKKD, bool NCDJBNMKDFA)
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
		[Cpp2IlInjected.Address(RVA = "0x6ECCD0", Offset = "0x6EBAD0", VA = "0x1806ECCD0")]
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
