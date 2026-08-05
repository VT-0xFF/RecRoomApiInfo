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
internal class JDABPFBJJHH
{
	[Cpp2IlInjected.Token(Token = "0x4000001")]
	public const string LHLCINEJCPG = "RBEX_DEFAULT";

	[Cpp2IlInjected.Token(Token = "0x4000002")]
	public const float APJDJDJLFCA = 0.001f;

	[Cpp2IlInjected.Token(Token = "0x4000003")]
	public const float KHIKBJBOHNJ = 0f;

	[Cpp2IlInjected.Token(Token = "0x4000004")]
	public const float CMKPEJDGEBG = 0.05f;

	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(RVA = "0x6C8B30", Offset = "0x6C7D30", VA = "0x1806C8B30")]
	public JDABPFBJJHH()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
public delegate void JPOFABMOGOF(RigidbodyEx AFDJGOCNKDF);
[Cpp2IlInjected.Token(Token = "0x2000004")]
public delegate void CBNHIOLMAOO(RigidbodyEx AFDJGOCNKDF, bool LMKLDOOIJAA = false);
[Cpp2IlInjected.Token(Token = "0x2000005")]
public enum CBPMCKPIBHC
{
	[Cpp2IlInjected.Token(Token = "0x4000006")]
	Additive,
	[Cpp2IlInjected.Token(Token = "0x4000007")]
	Override,
	[Cpp2IlInjected.Token(Token = "0x4000008")]
	Reflective
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public enum IIADBIFCBDN
{
	[Cpp2IlInjected.Token(Token = "0x400000A")]
	OnlyForReducedPhysicsRateAndNotParenting,
	[Cpp2IlInjected.Token(Token = "0x400000B")]
	Never,
	[Cpp2IlInjected.Token(Token = "0x400000C")]
	OnEvenWhenParenting
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
public enum BOPFIFMMKBG
{
	[Cpp2IlInjected.Token(Token = "0x400000E")]
	Additive,
	[Cpp2IlInjected.Token(Token = "0x400000F")]
	Override,
	[Cpp2IlInjected.Token(Token = "0x4000010")]
	Reflective
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
public class JGKAJDHFLGF : GNJJFOIGADA
{
	[Cpp2IlInjected.Token(Token = "0x17000001")]
	public int EALBEJPBCLD
	{
		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x6C7040", Offset = "0x6C6240", VA = "0x1806C7040", Slot = "4")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	public int AGNLBCICLAP
	{
		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x6DD790", Offset = "0x6DC990", VA = "0x1806DD790", Slot = "5")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0x6CE170", Offset = "0x6CD370", VA = "0x1806CE170", Slot = "6")]
	public LHLIDFNIOKA ELBEDJHIGFE(float KINGLLIJCOO)
	{
		return default(LHLIDFNIOKA);
	}

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0x6E0EB0", Offset = "0x6E00B0", VA = "0x1806E0EB0", Slot = "7")]
	public void AOHLLDNPMGN(NLJGMJFEGHJ ADHHHFDPAPI, float IOOOOANBPPM, JANFPIDCDOK FHMBIDJAKMP = JANFPIDCDOK.Off)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(RVA = "0x6E0EB0", Offset = "0x6E00B0", VA = "0x1806E0EB0", Slot = "8")]
	public void AOHLLDNPMGN(NLJGMJFEGHJ ADHHHFDPAPI, Transform LKCKBCPKEGI, float IOOOOANBPPM, JANFPIDCDOK FHMBIDJAKMP = JANFPIDCDOK.Off)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(RVA = "0x6E0EB0", Offset = "0x6E00B0", VA = "0x1806E0EB0", Slot = "9")]
	public void JGKKHFDLFAG(NLJGMJFEGHJ ADHHHFDPAPI, [Optional] float? IOOOOANBPPM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(RVA = "0x6E0EB0", Offset = "0x6E00B0", VA = "0x1806E0EB0", Slot = "10")]
	public void BCBAFCFKBLF(NLJGMJFEGHJ BNCCAIGLJMO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(RVA = "0x6CE170", Offset = "0x6CD370", VA = "0x1806CE170", Slot = "11")]
	public LHLIDFNIOKA JJNDGAOIAGC(NLJGMJFEGHJ ADHHHFDPAPI)
	{
		return default(LHLIDFNIOKA);
	}

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(RVA = "0x6E8020", Offset = "0x6E7220", VA = "0x1806E8020", Slot = "12")]
	public bool FOGOPKKNGDH(NLJGMJFEGHJ ADHHHFDPAPI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(RVA = "0x6E0EB0", Offset = "0x6E00B0", VA = "0x1806E0EB0", Slot = "13")]
	public void OALFIIGCDLA(NLJGMJFEGHJ ADHHHFDPAPI, JANFPIDCDOK PHDHCKKFDCD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(RVA = "0x6C8B30", Offset = "0x6C7D30", VA = "0x1806C8B30")]
	public JGKAJDHFLGF()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
[LOJIIDJFKAI(typeof(GNHCFBDDFCE), new string[] { "Ignore", "Mock" })]
public class MGFEDOGNDBL : GNHCFBDDFCE
{
	[Cpp2IlInjected.Token(Token = "0x17000003")]
	public bool BNNACLEEBKN
	{
		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0x6CB250", Offset = "0x6CA450", VA = "0x1806CB250", Slot = "4")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(RVA = "0x6E0EB0", Offset = "0x6E00B0", VA = "0x1806E0EB0", Slot = "5")]
	public void HMDKABCPDKD(string GNLLAOFLEDB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(RVA = "0x6E0EB0", Offset = "0x6E00B0", VA = "0x1806E0EB0", Slot = "6")]
	public void PMLEKKPAIBC(RigidbodyEx LDDCANHDBNB, Action GPNJNMLGIEN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(RVA = "0x6CE170", Offset = "0x6CD370", VA = "0x1806CE170", Slot = "7")]
	public GNJJFOIGADA JJJBOPMPOCL(int BDENIEGMNAP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(RVA = "0x6E0EB0", Offset = "0x6E00B0", VA = "0x1806E0EB0", Slot = "8")]
	public void IPHJOJMEHNN(Vector3 BJJEJPIPLBD, float JANGDGEDDPJ, Color GEDOLEMBLCF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(RVA = "0x6C8B30", Offset = "0x6C7D30", VA = "0x1806C8B30")]
	public MGFEDOGNDBL()
	{
	}
}
namespace RecRoom
{
	[Cpp2IlInjected.Token(Token = "0x200000A")]
	[DisallowMultipleComponent]
	[MBALNPKLAGP(FOFKCKDBIPD.Physics)]
	public sealed class RigidbodyEx : MonoBehaviour
	{
		[Cpp2IlInjected.Token(Token = "0x4000014")]
		private static readonly FADHLPPNOEF ICGADBEDOKK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000015")]
		private bool LCKFEIIEMOL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000016")]
		private PPMDIHPMNCG MNPBGJJKLND;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000017")]
		[SerializeField]
		[LNFKCGBKKAE(BCMNNOMINIG.Self, false, false, false)]
		private Rigidbody unityRigidbody;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000018")]
		[SerializeField]
		[LNFKCGBKKAE(BCMNNOMINIG.SelfAndParent, true, false, false)]
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
		private IIADBIFCBDN physicsInterpolation;

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
		internal PPMDIHPMNCG AJDCHLHALFM
		{
			[Cpp2IlInjected.Token(Token = "0x600001B")]
			[Cpp2IlInjected.Address(RVA = "0x640B9A0", Offset = "0x640ABA0", VA = "0x18640B9A0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000005")]
		public IReadOnlyList<RigidbodyEx> LILCAAEDFCG
		{
			[Cpp2IlInjected.Token(Token = "0x6000031")]
			[Cpp2IlInjected.Address(RVA = "0x6DD770", Offset = "0x6DC970", VA = "0x1806DD770")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000032")]
			[Cpp2IlInjected.Address(RVA = "0x768AB0", Offset = "0x767CB0", VA = "0x180768AB0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000006")]
		public RigidbodyEx NJNINOPBCAN
		{
			[Cpp2IlInjected.Token(Token = "0x6000033")]
			[Cpp2IlInjected.Address(RVA = "0x640D840", Offset = "0x640CA40", VA = "0x18640D840")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000007")]
		public RigidbodyEx MDHMHFAIMJJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000034")]
			[Cpp2IlInjected.Address(RVA = "0x640D7E0", Offset = "0x640C9E0", VA = "0x18640D7E0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000008")]
		public RigidbodyEx GPFONCECPBK
		{
			[Cpp2IlInjected.Token(Token = "0x6000035")]
			[Cpp2IlInjected.Address(RVA = "0x640E3A0", Offset = "0x640D5A0", VA = "0x18640E3A0")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000036")]
			[Cpp2IlInjected.Address(RVA = "0x640FAF0", Offset = "0x640ECF0", VA = "0x18640FAF0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000009")]
		public Transform PDLNBKLCFJO
		{
			[Cpp2IlInjected.Token(Token = "0x6000037")]
			[Cpp2IlInjected.Address(RVA = "0x1122DC0", Offset = "0x1121FC0", VA = "0x181122DC0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000A")]
		public Transform IPOOCBGBBCA
		{
			[Cpp2IlInjected.Token(Token = "0x6000038")]
			[Cpp2IlInjected.Address(RVA = "0x1122DC0", Offset = "0x1121FC0", VA = "0x181122DC0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000B")]
		public JANFPIDCDOK NHFAJHMDKMA
		{
			[Cpp2IlInjected.Token(Token = "0x6000039")]
			[Cpp2IlInjected.Address(RVA = "0x640D540", Offset = "0x640C740", VA = "0x18640D540")]
			get
			{
				return default(JANFPIDCDOK);
			}
			[Cpp2IlInjected.Token(Token = "0x600003A")]
			[Cpp2IlInjected.Address(RVA = "0x640F090", Offset = "0x640E290", VA = "0x18640F090")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000C")]
		public bool PJPIAHDKHLD
		{
			[Cpp2IlInjected.Token(Token = "0x600003B")]
			[Cpp2IlInjected.Address(RVA = "0x640DA50", Offset = "0x640CC50", VA = "0x18640DA50")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000D")]
		public bool EMGPBBGPGIE
		{
			[Cpp2IlInjected.Token(Token = "0x600003C")]
			[Cpp2IlInjected.Address(RVA = "0x640D660", Offset = "0x640C860", VA = "0x18640D660")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000E")]
		public LKKOPIEOHJA OLDOEMJHCAC
		{
			[Cpp2IlInjected.Token(Token = "0x600003D")]
			[Cpp2IlInjected.Address(RVA = "0x640D9F0", Offset = "0x640CBF0", VA = "0x18640D9F0")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600003E")]
			[Cpp2IlInjected.Address(RVA = "0x640F2A0", Offset = "0x640E4A0", VA = "0x18640F2A0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000F")]
		public FDHNJKMJJJG AEPCDANKKNF
		{
			[Cpp2IlInjected.Token(Token = "0x600003F")]
			[Cpp2IlInjected.Address(RVA = "0x640D990", Offset = "0x640CB90", VA = "0x18640D990")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000040")]
			[Cpp2IlInjected.Address(RVA = "0x640F230", Offset = "0x640E430", VA = "0x18640F230")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000010")]
		public bool OIAJDGKIDMB
		{
			[Cpp2IlInjected.Token(Token = "0x6000041")]
			[Cpp2IlInjected.Address(RVA = "0x640D870", Offset = "0x640CA70", VA = "0x18640D870")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000011")]
		public Rigidbody BAPEKECGLDP
		{
			[Cpp2IlInjected.Token(Token = "0x6000042")]
			[Cpp2IlInjected.Address(RVA = "0x640D8D0", Offset = "0x640CAD0", VA = "0x18640D8D0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000012")]
		public bool PJGCDNLPGAK
		{
			[Cpp2IlInjected.Token(Token = "0x6000043")]
			[Cpp2IlInjected.Address(RVA = "0x640D720", Offset = "0x640C920", VA = "0x18640D720")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000044")]
			[Cpp2IlInjected.Address(RVA = "0x640F150", Offset = "0x640E350", VA = "0x18640F150")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000013")]
		public bool LOGIENNOBOE
		{
			[Cpp2IlInjected.Token(Token = "0x6000045")]
			[Cpp2IlInjected.Address(RVA = "0x11113C0", Offset = "0x11105C0", VA = "0x1811113C0")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000046")]
			[Cpp2IlInjected.Address(RVA = "0x1110B80", Offset = "0x110FD80", VA = "0x181110B80")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000014")]
		public float AKCBBGMHDDM
		{
			[Cpp2IlInjected.Token(Token = "0x6000047")]
			[Cpp2IlInjected.Address(RVA = "0x640E340", Offset = "0x640D540", VA = "0x18640E340")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000015")]
		public float AKJJDFEANLD
		{
			[Cpp2IlInjected.Token(Token = "0x6000048")]
			[Cpp2IlInjected.Address(RVA = "0x640E2E0", Offset = "0x640D4E0", VA = "0x18640E2E0")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x6000049")]
			[Cpp2IlInjected.Address(RVA = "0x640FA80", Offset = "0x640EC80", VA = "0x18640FA80")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000016")]
		public float CGCJGLPPNGH
		{
			[Cpp2IlInjected.Token(Token = "0x600004A")]
			[Cpp2IlInjected.Address(RVA = "0x640DCB0", Offset = "0x640CEB0", VA = "0x18640DCB0")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x600004B")]
			[Cpp2IlInjected.Address(RVA = "0x640F540", Offset = "0x640E740", VA = "0x18640F540")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000017")]
		public float PIFJIAIFNLJ
		{
			[Cpp2IlInjected.Token(Token = "0x600004C")]
			[Cpp2IlInjected.Address(RVA = "0x640DAB0", Offset = "0x640CCB0", VA = "0x18640DAB0")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x600004D")]
			[Cpp2IlInjected.Address(RVA = "0x640F310", Offset = "0x640E510", VA = "0x18640F310")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000018")]
		public bool POECKMPMDKM
		{
			[Cpp2IlInjected.Token(Token = "0x600004E")]
			[Cpp2IlInjected.Address(RVA = "0x640E8C0", Offset = "0x640DAC0", VA = "0x18640E8C0")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x600004F")]
			[Cpp2IlInjected.Address(RVA = "0x6410030", Offset = "0x640F230", VA = "0x186410030")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000019")]
		public Vector3 MJDCNCPMNKH
		{
			[Cpp2IlInjected.Token(Token = "0x6000050")]
			[Cpp2IlInjected.Address(RVA = "0x640E0C0", Offset = "0x640D2C0", VA = "0x18640E0C0")]
			get
			{
				return default(Vector3);
			}
			[Cpp2IlInjected.Token(Token = "0x6000051")]
			[Cpp2IlInjected.Address(RVA = "0x640F850", Offset = "0x640EA50", VA = "0x18640F850")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001A")]
		public Vector3 BJJEJPIPLBD
		{
			[Cpp2IlInjected.Token(Token = "0x6000052")]
			[Cpp2IlInjected.Address(RVA = "0x640EA00", Offset = "0x640DC00", VA = "0x18640EA00")]
			get
			{
				return default(Vector3);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001B")]
		public CollisionDetectionMode HPCCBOFOPKH
		{
			[Cpp2IlInjected.Token(Token = "0x6000053")]
			[Cpp2IlInjected.Address(RVA = "0x640DBF0", Offset = "0x640CDF0", VA = "0x18640DBF0")]
			get
			{
				return default(CollisionDetectionMode);
			}
			[Cpp2IlInjected.Token(Token = "0x6000054")]
			[Cpp2IlInjected.Address(RVA = "0x640F460", Offset = "0x640E660", VA = "0x18640F460")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001C")]
		public float ENFIJFJPIPJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000055")]
			[Cpp2IlInjected.Address(RVA = "0x640D780", Offset = "0x640C980", VA = "0x18640D780")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x6000056")]
			[Cpp2IlInjected.Address(RVA = "0x640F1C0", Offset = "0x640E3C0", VA = "0x18640F1C0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001D")]
		public RigidbodyConstraints AGPNLEHNBIO
		{
			[Cpp2IlInjected.Token(Token = "0x6000057")]
			[Cpp2IlInjected.Address(RVA = "0x640DC50", Offset = "0x640CE50", VA = "0x18640DC50")]
			get
			{
				return default(RigidbodyConstraints);
			}
			[Cpp2IlInjected.Token(Token = "0x6000058")]
			[Cpp2IlInjected.Address(RVA = "0x640F4D0", Offset = "0x640E6D0", VA = "0x18640F4D0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001E")]
		public Vector3 ABDEOMCEHMB
		{
			[Cpp2IlInjected.Token(Token = "0x6000059")]
			[Cpp2IlInjected.Address(RVA = "0x640E400", Offset = "0x640D600", VA = "0x18640E400")]
			get
			{
				return default(Vector3);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001F")]
		public Vector3 FLOJHNJCGGP
		{
			[Cpp2IlInjected.Token(Token = "0x600005A")]
			[Cpp2IlInjected.Address(RVA = "0x640E400", Offset = "0x640D600", VA = "0x18640E400")]
			get
			{
				return default(Vector3);
			}
			[Cpp2IlInjected.Token(Token = "0x600005B")]
			[Cpp2IlInjected.Address(RVA = "0x640FE00", Offset = "0x640F000", VA = "0x18640FE00")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000020")]
		public float DLAJIHFLDDN
		{
			[Cpp2IlInjected.Token(Token = "0x600005C")]
			[Cpp2IlInjected.Address(RVA = "0x640E1A0", Offset = "0x640D3A0", VA = "0x18640E1A0")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x600005D")]
			[Cpp2IlInjected.Address(RVA = "0x640F930", Offset = "0x640EB30", VA = "0x18640F930")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000021")]
		public float BBJPLPKDAFJ
		{
			[Cpp2IlInjected.Token(Token = "0x600005E")]
			[Cpp2IlInjected.Address(RVA = "0x640E860", Offset = "0x640DA60", VA = "0x18640E860")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x600005F")]
			[Cpp2IlInjected.Address(RVA = "0x640FFC0", Offset = "0x640F1C0", VA = "0x18640FFC0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000022")]
		public Quaternion BOKMIPEIPMN
		{
			[Cpp2IlInjected.Token(Token = "0x6000060")]
			[Cpp2IlInjected.Address(RVA = "0x640E4E0", Offset = "0x640D6E0", VA = "0x18640E4E0")]
			get
			{
				return default(Quaternion);
			}
			[Cpp2IlInjected.Token(Token = "0x6000061")]
			[Cpp2IlInjected.Address(RVA = "0x640FB60", Offset = "0x640ED60", VA = "0x18640FB60")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000023")]
		public Quaternion CGMHKNFGLML
		{
			[Cpp2IlInjected.Token(Token = "0x6000062")]
			[Cpp2IlInjected.Address(RVA = "0x640E780", Offset = "0x640D980", VA = "0x18640E780")]
			get
			{
				return default(Quaternion);
			}
			[Cpp2IlInjected.Token(Token = "0x6000063")]
			[Cpp2IlInjected.Address(RVA = "0x640FEE0", Offset = "0x640F0E0", VA = "0x18640FEE0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000024")]
		public Vector3 DMEHFDCFLJO
		{
			[Cpp2IlInjected.Token(Token = "0x6000064")]
			[Cpp2IlInjected.Address(RVA = "0x640E5C0", Offset = "0x640D7C0", VA = "0x18640E5C0")]
			get
			{
				return default(Vector3);
			}
			[Cpp2IlInjected.Token(Token = "0x6000065")]
			[Cpp2IlInjected.Address(RVA = "0x640FC40", Offset = "0x640EE40", VA = "0x18640FC40")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000025")]
		public Quaternion JAPKFAIHFPH
		{
			[Cpp2IlInjected.Token(Token = "0x6000066")]
			[Cpp2IlInjected.Address(RVA = "0x640E6A0", Offset = "0x640D8A0", VA = "0x18640E6A0")]
			get
			{
				return default(Quaternion);
			}
			[Cpp2IlInjected.Token(Token = "0x6000067")]
			[Cpp2IlInjected.Address(RVA = "0x640FD20", Offset = "0x640EF20", VA = "0x18640FD20")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000026")]
		public Vector3 BNEEGIEDHBB
		{
			[Cpp2IlInjected.Token(Token = "0x6000068")]
			[Cpp2IlInjected.Address(RVA = "0x640E920", Offset = "0x640DB20", VA = "0x18640E920")]
			get
			{
				return default(Vector3);
			}
			[Cpp2IlInjected.Token(Token = "0x6000069")]
			[Cpp2IlInjected.Address(RVA = "0x64100A0", Offset = "0x640F2A0", VA = "0x1864100A0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000027")]
		public Vector3 DLOMDLEMEJO
		{
			[Cpp2IlInjected.Token(Token = "0x600006A")]
			[Cpp2IlInjected.Address(RVA = "0x640E200", Offset = "0x640D400", VA = "0x18640E200")]
			get
			{
				return default(Vector3);
			}
			[Cpp2IlInjected.Token(Token = "0x600006B")]
			[Cpp2IlInjected.Address(RVA = "0x640F9A0", Offset = "0x640EBA0", VA = "0x18640F9A0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000028")]
		public Vector3 IMJEKHOJGKC
		{
			[Cpp2IlInjected.Token(Token = "0x600006C")]
			[Cpp2IlInjected.Address(RVA = "0x640DB10", Offset = "0x640CD10", VA = "0x18640DB10")]
			get
			{
				return default(Vector3);
			}
			[Cpp2IlInjected.Token(Token = "0x600006D")]
			[Cpp2IlInjected.Address(RVA = "0x640F380", Offset = "0x640E580", VA = "0x18640F380")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000029")]
		public Vector3 NBGIHKDGDID
		{
			[Cpp2IlInjected.Token(Token = "0x600006E")]
			[Cpp2IlInjected.Address(RVA = "0x640DFE0", Offset = "0x640D1E0", VA = "0x18640DFE0")]
			get
			{
				return default(Vector3);
			}
			[Cpp2IlInjected.Token(Token = "0x600006F")]
			[Cpp2IlInjected.Address(RVA = "0x640F770", Offset = "0x640E970", VA = "0x18640F770")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002A")]
		public Vector3 KNIHAMHGBLN
		{
			[Cpp2IlInjected.Token(Token = "0x6000070")]
			[Cpp2IlInjected.Address(RVA = "0x640DEA0", Offset = "0x640D0A0", VA = "0x18640DEA0")]
			get
			{
				return default(Vector3);
			}
			[Cpp2IlInjected.Token(Token = "0x6000071")]
			[Cpp2IlInjected.Address(RVA = "0x640F690", Offset = "0x640E890", VA = "0x18640F690")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002B")]
		public Quaternion OPONCDOPJKK
		{
			[Cpp2IlInjected.Token(Token = "0x6000072")]
			[Cpp2IlInjected.Address(RVA = "0x640DDC0", Offset = "0x640CFC0", VA = "0x18640DDC0")]
			get
			{
				return default(Quaternion);
			}
			[Cpp2IlInjected.Token(Token = "0x6000073")]
			[Cpp2IlInjected.Address(RVA = "0x640F5B0", Offset = "0x640E7B0", VA = "0x18640F5B0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002C")]
		public Vector3 NEODKNJMMAG
		{
			[Cpp2IlInjected.Token(Token = "0x6000074")]
			[Cpp2IlInjected.Address(RVA = "0x640EBC0", Offset = "0x640DDC0", VA = "0x18640EBC0")]
			get
			{
				return default(Vector3);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002D")]
		public Vector3 FOAMPCAGPDL
		{
			[Cpp2IlInjected.Token(Token = "0x6000075")]
			[Cpp2IlInjected.Address(RVA = "0x640EAE0", Offset = "0x640DCE0", VA = "0x18640EAE0")]
			get
			{
				return default(Vector3);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002E")]
		public bool IOEMIKGMLIB
		{
			[Cpp2IlInjected.Token(Token = "0x6000076")]
			[Cpp2IlInjected.Address(RVA = "0x640DF80", Offset = "0x640D180", VA = "0x18640DF80")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002F")]
		public bool NFEEOKFPIGD
		{
			[Cpp2IlInjected.Token(Token = "0x6000077")]
			[Cpp2IlInjected.Address(RVA = "0x640D6C0", Offset = "0x640C8C0", VA = "0x18640D6C0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000030")]
		public bool AMMPJIIANJD
		{
			[Cpp2IlInjected.Token(Token = "0x6000078")]
			[Cpp2IlInjected.Address(RVA = "0x640D600", Offset = "0x640C800", VA = "0x18640D600")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000031")]
		public bool OONHJPFBNAB
		{
			[Cpp2IlInjected.Token(Token = "0x6000079")]
			[Cpp2IlInjected.Address(RVA = "0x640D5A0", Offset = "0x640C7A0", VA = "0x18640D5A0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000032")]
		public bool AKAANNKOEAC
		{
			[Cpp2IlInjected.Token(Token = "0x600007A")]
			[Cpp2IlInjected.Address(RVA = "0x640D4E0", Offset = "0x640C6E0", VA = "0x18640D4E0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000033")]
		public bool CPMFMLDOCMG
		{
			[Cpp2IlInjected.Token(Token = "0x600007B")]
			[Cpp2IlInjected.Address(RVA = "0x640DD10", Offset = "0x640CF10", VA = "0x18640DD10")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000034")]
		public bool EIOIMMEOHBA
		{
			[Cpp2IlInjected.Token(Token = "0x600007C")]
			[Cpp2IlInjected.Address(RVA = "0x75F580", Offset = "0x75E780", VA = "0x18075F580")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000001")]
		public event JPOFABMOGOF PMNOCHELBHE
		{
			[Cpp2IlInjected.Token(Token = "0x600001F")]
			[Cpp2IlInjected.Address(RVA = "0x640D400", Offset = "0x640C600", VA = "0x18640D400")]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000020")]
			[Cpp2IlInjected.Address(RVA = "0x640EFB0", Offset = "0x640E1B0", VA = "0x18640EFB0")]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000002")]
		public event CBNHIOLMAOO CHIALDMLLME
		{
			[Cpp2IlInjected.Token(Token = "0x6000021")]
			[Cpp2IlInjected.Address(RVA = "0x640D390", Offset = "0x640C590", VA = "0x18640D390")]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000022")]
			[Cpp2IlInjected.Address(RVA = "0x640EF40", Offset = "0x640E140", VA = "0x18640EF40")]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000003")]
		public event JPOFABMOGOF KMPDHKDHBNO
		{
			[Cpp2IlInjected.Token(Token = "0x6000023")]
			[Cpp2IlInjected.Address(RVA = "0x640D0F0", Offset = "0x640C2F0", VA = "0x18640D0F0")]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000024")]
			[Cpp2IlInjected.Address(RVA = "0x640ECA0", Offset = "0x640DEA0", VA = "0x18640ECA0")]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000004")]
		public event JPOFABMOGOF FIBPOODLACB
		{
			[Cpp2IlInjected.Token(Token = "0x6000025")]
			[Cpp2IlInjected.Address(RVA = "0x640D160", Offset = "0x640C360", VA = "0x18640D160")]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000026")]
			[Cpp2IlInjected.Address(RVA = "0x640ED10", Offset = "0x640DF10", VA = "0x18640ED10")]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000005")]
		public event JPOFABMOGOF GHPNGDBINKD
		{
			[Cpp2IlInjected.Token(Token = "0x6000027")]
			[Cpp2IlInjected.Address(RVA = "0x640D2B0", Offset = "0x640C4B0", VA = "0x18640D2B0")]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000028")]
			[Cpp2IlInjected.Address(RVA = "0x640EE60", Offset = "0x640E060", VA = "0x18640EE60")]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000006")]
		public event Action<LHLIDFNIOKA, LHLIDFNIOKA> GBMBMPKHBHO
		{
			[Cpp2IlInjected.Token(Token = "0x6000029")]
			[Cpp2IlInjected.Address(RVA = "0x640D240", Offset = "0x640C440", VA = "0x18640D240")]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x600002A")]
			[Cpp2IlInjected.Address(RVA = "0x640EDF0", Offset = "0x640DFF0", VA = "0x18640EDF0")]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000007")]
		public event JPOFABMOGOF FINFHBLPOFK
		{
			[Cpp2IlInjected.Token(Token = "0x600002B")]
			[Cpp2IlInjected.Address(RVA = "0x640D320", Offset = "0x640C520", VA = "0x18640D320")]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x600002C")]
			[Cpp2IlInjected.Address(RVA = "0x640EED0", Offset = "0x640E0D0", VA = "0x18640EED0")]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000008")]
		public event JPOFABMOGOF PDFILLCCOJB
		{
			[Cpp2IlInjected.Token(Token = "0x600002D")]
			[Cpp2IlInjected.Address(RVA = "0x640D470", Offset = "0x640C670", VA = "0x18640D470")]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x600002E")]
			[Cpp2IlInjected.Address(RVA = "0x640F020", Offset = "0x640E220", VA = "0x18640F020")]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000009")]
		public event JPOFABMOGOF FAMCBBOPNHD
		{
			[Cpp2IlInjected.Token(Token = "0x600002F")]
			[Cpp2IlInjected.Address(RVA = "0x640D1D0", Offset = "0x640C3D0", VA = "0x18640D1D0")]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000030")]
			[Cpp2IlInjected.Address(RVA = "0x640ED80", Offset = "0x640DF80", VA = "0x18640ED80")]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(RVA = "0x6C8130", Offset = "0x6C7330", VA = "0x1806C8130")]
		internal void JHOICGAFFJF(PPMDIHPMNCG ONJEPBGIHBB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0x640C040", Offset = "0x640B240", VA = "0x18640C040")]
		internal void IADBLMPCCCL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x640CE40", Offset = "0x640C040", VA = "0x18640CE40")]
		[Conditional("DEBUG_BUILD")]
		[Conditional("UNITY_EDITOR")]
		public void TestOverrideUnityRigidbody(Rigidbody PEAEJAGKHAK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007D")]
		[Cpp2IlInjected.Address(RVA = "0x640B6F0", Offset = "0x640A8F0", VA = "0x18640B6F0")]
		private void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007E")]
		[Cpp2IlInjected.Address(RVA = "0x640B9A0", Offset = "0x640ABA0", VA = "0x18640B9A0")]
		private PPMDIHPMNCG MODNGDOMPEE()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600007F")]
		[Cpp2IlInjected.Address(RVA = "0x640BCB0", Offset = "0x640AEB0", VA = "0x18640BCB0")]
		private void HBGEMGCKMHE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000080")]
		[Cpp2IlInjected.Address(RVA = "0x640C380", Offset = "0x640B580", VA = "0x18640C380")]
		private void OnEnable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000081")]
		[Cpp2IlInjected.Address(RVA = "0x640C310", Offset = "0x640B510", VA = "0x18640C310")]
		private void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000082")]
		[Cpp2IlInjected.Address(RVA = "0x640BA50", Offset = "0x640AC50", VA = "0x18640BA50")]
		private void FixedUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000083")]
		[Cpp2IlInjected.Address(RVA = "0x640C320", Offset = "0x640B520", VA = "0x18640C320")]
		private void OnDrawGizmosSelected()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000084")]
		[Cpp2IlInjected.Address(RVA = "0x640C3E0", Offset = "0x640B5E0", VA = "0x18640C3E0")]
		private void OnValidate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000085")]
		[Cpp2IlInjected.Address(RVA = "0x640AD80", Offset = "0x6409F80", VA = "0x18640AD80")]
		public void AddDoNotResetVelocityOnOwnershipChangeOverride(object AJDBKDIMOHA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000086")]
		[Cpp2IlInjected.Address(RVA = "0x640C450", Offset = "0x640B650", VA = "0x18640C450")]
		public void RemoveDoNotResetVelocityOnOwnershipChangeOverride(object AJDBKDIMOHA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000087")]
		[Cpp2IlInjected.Address(RVA = "0x640B940", Offset = "0x640AB40", VA = "0x18640B940")]
		public void DisableCachedInertialPropertyOverride()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000088")]
		[Cpp2IlInjected.Address(RVA = "0x640C2B0", Offset = "0x640B4B0", VA = "0x18640C2B0")]
		public void MarkCachedInertialParametersDirty()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000089")]
		[Cpp2IlInjected.Address(RVA = "0x640CC40", Offset = "0x640BE40", VA = "0x18640CC40")]
		public void SetParent(RigidbodyEx JFBPNBNBHOE, bool LMKLDOOIJAA = false)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008A")]
		[Cpp2IlInjected.Address(RVA = "0x640C760", Offset = "0x640B960", VA = "0x18640C760")]
		public void ResetLocalCenterOfMassToPrefabDefault()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008B")]
		[Cpp2IlInjected.Address(RVA = "0x640C0D0", Offset = "0x640B2D0", VA = "0x18640C0D0")]
		public bool IsRigidbodyAncestor(RigidbodyEx BIHOLEKLDHK)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600008C")]
		[Cpp2IlInjected.Address(RVA = "0x640C110", Offset = "0x640B310", VA = "0x18640C110")]
		public bool IsRigidbodyDescendant(RigidbodyEx FPKOBEGNFCF)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600008D")]
		[Cpp2IlInjected.Address(RVA = "0x640AFA0", Offset = "0x640A1A0", VA = "0x18640AFA0")]
		public void AddInterpolationRestriction(object AJDBKDIMOHA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008E")]
		[Cpp2IlInjected.Address(RVA = "0x640C4C0", Offset = "0x640B6C0", VA = "0x18640C4C0")]
		public void RemoveInterpolationRestriction(object AJDBKDIMOHA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008F")]
		[Cpp2IlInjected.Address(RVA = "0x640B760", Offset = "0x640A960", VA = "0x18640B760")]
		public IDisposable BeginKinematicScope()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000090")]
		[Cpp2IlInjected.Address(RVA = "0x640B010", Offset = "0x640A210", VA = "0x18640B010")]
		public void AddKinematic(object AJDBKDIMOHA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000091")]
		[Cpp2IlInjected.Address(RVA = "0x640C530", Offset = "0x640B730", VA = "0x18640C530")]
		public void RemoveKinematic(object AJDBKDIMOHA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000092")]
		[Cpp2IlInjected.Address(RVA = "0x640CBC0", Offset = "0x640BDC0", VA = "0x18640CBC0")]
		public void SetKinematic(object AJDBKDIMOHA, bool NMHFDHPJGFL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000093")]
		[Cpp2IlInjected.Address(RVA = "0x640CAC0", Offset = "0x640BCC0", VA = "0x18640CAC0")]
		public void SetDiscontinuousPositionAndRotation(Vector3 LDBCCJOIJOF, Quaternion HPGHCBDEGFJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000094")]
		[Cpp2IlInjected.Address(RVA = "0x640C9C0", Offset = "0x640BBC0", VA = "0x18640C9C0")]
		public void SetDiscontinuousLocalPositionAndLocalRotation(Vector3 JPBAEPJPHFP, Quaternion NHHKEMOEKHO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000095")]
		[Cpp2IlInjected.Address(RVA = "0x640BBB0", Offset = "0x640ADB0", VA = "0x18640BBB0")]
		public Vector3 GetConstrainedVelocity(Vector3 BNEEGIEDHBB)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x6000096")]
		[Cpp2IlInjected.Address(RVA = "0x640BAB0", Offset = "0x640ACB0", VA = "0x18640BAB0")]
		public Vector3 GetConstrainedAngularVelocity(Vector3 IMJEKHOJGKC)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x6000097")]
		[Cpp2IlInjected.Address(RVA = "0x640AF10", Offset = "0x640A110", VA = "0x18640AF10")]
		public void AddForce(Vector3 BIOMHNNIJHG, ForceMode HODPBICIGJM = ForceMode.Force)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000098")]
		[Cpp2IlInjected.Address(RVA = "0x640ADF0", Offset = "0x6409FF0", VA = "0x18640ADF0")]
		public void AddForceAtPosition(Vector3 BIOMHNNIJHG, Vector3 DACBJNCMNFL, ForceMode HODPBICIGJM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000099")]
		[Cpp2IlInjected.Address(RVA = "0x640B110", Offset = "0x640A310", VA = "0x18640B110")]
		public void AddTorque(Vector3 CEBBAPNMMME, ForceMode HODPBICIGJM = ForceMode.Force)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009A")]
		[Cpp2IlInjected.Address(RVA = "0x640B080", Offset = "0x640A280", VA = "0x18640B080")]
		public void AddRelativeTorque(Vector3 CEBBAPNMMME, ForceMode HODPBICIGJM = ForceMode.Force)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009B")]
		[Cpp2IlInjected.Address(RVA = "0x640CF20", Offset = "0x640C120", VA = "0x18640CF20")]
		public Vector3 WorldToLocalVelocity(Vector3 ODPCODBLNJO)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x600009C")]
		[Cpp2IlInjected.Address(RVA = "0x640C1B0", Offset = "0x640B3B0", VA = "0x18640C1B0")]
		public Vector3 LocalToWorldVelocity(Vector3 DLOMDLEMEJO)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x600009D")]
		[Cpp2IlInjected.Address(RVA = "0x640B8E0", Offset = "0x640AAE0", VA = "0x18640B8E0")]
		public void ClearVelocity()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009E")]
		[Cpp2IlInjected.Address(RVA = "0x640B880", Offset = "0x640AA80", VA = "0x18640B880")]
		public void ClearUnityRigidbodyVelocity()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009F")]
		[Cpp2IlInjected.Address(RVA = "0x640B820", Offset = "0x640AA20", VA = "0x18640B820")]
		public void ClearLinearVelocity()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A0")]
		[Cpp2IlInjected.Address(RVA = "0x640B7C0", Offset = "0x640A9C0", VA = "0x18640B7C0")]
		public void ClearAngularVelocity()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A1")]
		[Cpp2IlInjected.Address(RVA = "0x640C8C0", Offset = "0x640BAC0", VA = "0x18640C8C0")]
		public void ResetVelocityWorldSpace(Vector3 PKEOGDHOABC, Vector3 GNHLNIEHAFA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A2")]
		[Cpp2IlInjected.Address(RVA = "0x640C7C0", Offset = "0x640B9C0", VA = "0x18640C7C0")]
		public void ResetVelocityLocalSpace(Vector3 IHHIJIKHHIA, Vector3 NBGIHKDGDID)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A3")]
		[Cpp2IlInjected.Address(RVA = "0x640C680", Offset = "0x640B880", VA = "0x18640C680")]
		public void ResetLinearVelocityLocalSpace(Vector3 IHHIJIKHHIA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A4")]
		[Cpp2IlInjected.Address(RVA = "0x640CD30", Offset = "0x640BF30", VA = "0x18640CD30")]
		public bool SweepTest(Vector3 HHOIMIMHDMP, out RaycastHit CFGLFCONCKN, float KMAOMDJLDEN)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000A5")]
		[Cpp2IlInjected.Address(RVA = "0x640C150", Offset = "0x640B350", VA = "0x18640C150")]
		public bool IsSleeping()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000A6")]
		[Cpp2IlInjected.Address(RVA = "0x640CCD0", Offset = "0x640BED0", VA = "0x18640CCD0")]
		public void Sleep()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A7")]
		[Cpp2IlInjected.Address(RVA = "0x640CEC0", Offset = "0x640C0C0", VA = "0x18640CEC0")]
		public void WakeUp()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A8")]
		[Cpp2IlInjected.Address(RVA = "0x640B1A0", Offset = "0x640A3A0", VA = "0x18640B1A0")]
		public void AddUnityRigidbody(object AJDBKDIMOHA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A9")]
		[Cpp2IlInjected.Address(RVA = "0x640C5A0", Offset = "0x640B7A0", VA = "0x18640C5A0")]
		public void RemoveUnityRigidbody(object AJDBKDIMOHA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AA")]
		[Cpp2IlInjected.Address(RVA = "0x640B4C0", Offset = "0x640A6C0", VA = "0x18640B4C0")]
		public void ApplyForceVelocityChange(CBPMCKPIBHC EIOPEGEMKHP, Vector3 DKCLOLGBADH, float OOKLCGCBAJI, float LLKLELEIBGC = 8f, float AEEFHMKEOAH = 1f)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AB")]
		[Cpp2IlInjected.Address(RVA = "0x640B3C0", Offset = "0x640A5C0", VA = "0x18640B3C0")]
		public void ApplyAngularVelocityChange(BOPFIFMMKBG BPDOBLBNKEN, Vector3 NLFAAHHHDNN, float HHHNHCMFNFA = float.PositiveInfinity)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AC")]
		[Cpp2IlInjected.Address(RVA = "0x640B5E0", Offset = "0x640A7E0", VA = "0x18640B5E0")]
		[Obsolete]
		public void ApplyTorqueAngularVelocityChangeDeprecated(BOPFIFMMKBG BPDOBLBNKEN, Vector3 MCFIHGJCDCP, float BDCHAJELIHL = 7f, float ABPPGEHGCFI = 1f)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AD")]
		[Cpp2IlInjected.Address(RVA = "0x640B300", Offset = "0x640A500", VA = "0x18640B300")]
		public bool AllowedScaleChange(float LCLMOJDNELD)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000AE")]
		[Cpp2IlInjected.Address(RVA = "0x640B210", Offset = "0x640A410", VA = "0x18640B210")]
		public void AddWorldSpaceVelocityInHierarchyParentOverride(RigidbodyEx FONAKEEEKPK, object AJDBKDIMOHA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AF")]
		[Cpp2IlInjected.Address(RVA = "0x640C610", Offset = "0x640B810", VA = "0x18640C610")]
		public void RemoveWorldSpaceVelocityInHierarchyParentOverride(object AJDBKDIMOHA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B0")]
		[Cpp2IlInjected.Address(RVA = "0x640D070", Offset = "0x640C270", VA = "0x18640D070")]
		public RigidbodyEx()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
internal static class PCGHKDLIIBP
{
	[Cpp2IlInjected.Token(Token = "0x60000B5")]
	[Cpp2IlInjected.Address(RVA = "0x5376690", Offset = "0x5375890", VA = "0x185376690")]
	public static PPMDIHPMNCG AJDCHLHALFM(this RigidbodyEx LDDCANHDBNB)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
public struct OALOFNDFAEL
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000022")]
	public Rigidbody AOAFHPHKFMD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000023")]
	public PhotonView CAIDBGJNFEP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000024")]
	public OverridableVector3 PHKDOEMHFGP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000025")]
	public OverridableVector3 EJHFMNHJBDB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000026")]
	public IIADBIFCBDN DDCLGMJNJFL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
	[Cpp2IlInjected.Token(Token = "0x4000027")]
	public bool GIOOHNCONKF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x35")]
	[Cpp2IlInjected.Token(Token = "0x4000028")]
	public bool IMKJKDBAHMH;
}
namespace RecRoom
{
	[Cpp2IlInjected.Token(Token = "0x200000E")]
	[MBALNPKLAGP(FOFKCKDBIPD.Physics)]
	[LOJIIDJFKAI(typeof(CMKMIKBKOHM), new string[] { })]
	public class RigidbodyExManager : CMKMIKBKOHM, DPDCPMNGBKH
	{
		[Cpp2IlInjected.Token(Token = "0x4000029")]
		private static readonly FADHLPPNOEF ICGADBEDOKK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400002A")]
		private AKKPACBLFCH ONMGKKCFHAK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400002B")]
		private GNHCFBDDFCE FGFPMOHFMOM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400002C")]
		private KMBOJHAPLLI HBNLNEKDJID;

		[Cpp2IlInjected.Token(Token = "0x17000035")]
		public bool GAAOJBBKPNA
		{
			[Cpp2IlInjected.Token(Token = "0x60000B6")]
			[Cpp2IlInjected.Address(RVA = "0x640A7C0", Offset = "0x64099C0", VA = "0x18640A7C0", Slot = "6")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000036")]
		public GNHCFBDDFCE DDGABFFCPAP
		{
			[Cpp2IlInjected.Token(Token = "0x60000B7")]
			[Cpp2IlInjected.Address(RVA = "0x6C70C0", Offset = "0x6C62C0", VA = "0x1806C70C0", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000037")]
		public KMBOJHAPLLI AJPHGKGIGMH
		{
			[Cpp2IlInjected.Token(Token = "0x60000B8")]
			[Cpp2IlInjected.Address(RVA = "0x6C8120", Offset = "0x6C7320", VA = "0x1806C8120", Slot = "5")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000B9")]
		[Cpp2IlInjected.Address(RVA = "0x640ACA0", Offset = "0x6409EA0", VA = "0x18640ACA0", Slot = "12")]
		public void PEIMLKLDOFJ(JHLNNPKIFCO KOKEGENGCAH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000BA")]
		[Cpp2IlInjected.Address(RVA = "0x640A8E0", Offset = "0x6409AE0", VA = "0x18640A8E0", Slot = "7")]
		public NFJEDPPAJMK JIOOPANAKNB(RigidbodyEx LDDCANHDBNB)
		{
			return default(NFJEDPPAJMK);
		}

		[Cpp2IlInjected.Token(Token = "0x60000BB")]
		[Cpp2IlInjected.Address(RVA = "0x640A5C0", Offset = "0x64097C0", VA = "0x18640A5C0")]
		private static NFJEDPPAJMK DCDBBDOBJFM(RigidbodyEx LDDCANHDBNB)
		{
			return default(NFJEDPPAJMK);
		}

		[Cpp2IlInjected.Token(Token = "0x60000BC")]
		[Cpp2IlInjected.Address(RVA = "0x640A6B0", Offset = "0x64098B0", VA = "0x18640A6B0", Slot = "8")]
		public PPMDIHPMNCG EHCIKDFINKO(RigidbodyEx LDDCANHDBNB, OALOFNDFAEL ONIBEFDCPGD)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000BD")]
		[Cpp2IlInjected.Address(RVA = "0x640A810", Offset = "0x6409A10", VA = "0x18640A810", Slot = "11")]
		private RigidbodyEx IHKOFEDLIAG(GameObject GODCAKDBDMK, OALOFNDFAEL ONIBEFDCPGD)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000BE")]
		[Cpp2IlInjected.Address(RVA = "0x640ABB0", Offset = "0x6409DB0", VA = "0x18640ABB0", Slot = "9")]
		public void JKAPKEJENHH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000BF")]
		[Cpp2IlInjected.Address(RVA = "0x640A470", Offset = "0x6409670", VA = "0x18640A470", Slot = "10")]
		public void ANMLMAOGGKE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C0")]
		[Cpp2IlInjected.Address(RVA = "0x6C8B30", Offset = "0x6C7D30", VA = "0x1806C8B30")]
		public RigidbodyExManager()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000F")]
	public class PhysicsManager : SingletonMonoBehaviour<PhysicsManager>
	{
		[Cpp2IlInjected.Token(Token = "0x400002D")]
		public static CBKLEJNNKJH UpdateAfterFixedUpdateRan;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400002E")]
		private int LBPNIEKKGIC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x400002F")]
		private int HJMNFLMBKGE;

		[Cpp2IlInjected.Token(Token = "0x60000C2")]
		[Cpp2IlInjected.Address(RVA = "0x6409F50", Offset = "0x6409150", VA = "0x186409F50")]
		protected void FixedUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C3")]
		[Cpp2IlInjected.Address(RVA = "0x6409F90", Offset = "0x6409190", VA = "0x186409F90")]
		protected void Update()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C4")]
		[Cpp2IlInjected.Address(RVA = "0x6409F70", Offset = "0x6409170", VA = "0x186409F70")]
		protected void LateUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C5")]
		[Cpp2IlInjected.Address(RVA = "0x6E0EB0", Offset = "0x6E00B0", VA = "0x1806E0EB0")]
		[Conditional("UNITY_ASSERTIONS")]
		public void AssertLateColliderPositionsNotYetUpdated([Optional] string DENPJAMCNLD, [Optional] UnityEngine.Object MAFDHEKFLMG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C6")]
		[Cpp2IlInjected.Address(RVA = "0x6E0EB0", Offset = "0x6E00B0", VA = "0x1806E0EB0")]
		[Conditional("UNITY_ASSERTIONS")]
		public void AssertLateColliderPositionsAlreadyUpdated([Optional] string DENPJAMCNLD, [Optional] UnityEngine.Object MAFDHEKFLMG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C7")]
		[Cpp2IlInjected.Address(RVA = "0x640A080", Offset = "0x6409280", VA = "0x18640A080")]
		public PhysicsManager()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
public static class APBFFBPJEDL
{
	[Cpp2IlInjected.Token(Token = "0x60000C9")]
	[Cpp2IlInjected.Address(RVA = "0x5356E20", Offset = "0x5356020", VA = "0x185356E20")]
	public static void HPBIJANCPAD(this Rigidbody PEAEJAGKHAK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CA")]
	[Cpp2IlInjected.Address(RVA = "0x5356D10", Offset = "0x5355F10", VA = "0x185356D10")]
	public static void HPBIJANCPAD(this Rigidbody PEAEJAGKHAK, Vector3 KNIHAMHGBLN, Quaternion OPONCDOPJKK, Vector3 KFPBOOHEFMG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CB")]
	[Cpp2IlInjected.Address(RVA = "0x5356F70", Offset = "0x5356170", VA = "0x185356F70")]
	public static void PDJKFOBMLJJ(Vector3 BNEEGIEDHBB, Vector3 EMALJDHGDFM, out Vector3 BAHFGGEIPJI, out Vector3 EMENJABDBLM)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
public static class EPBMELLKFOL
{
	[Cpp2IlInjected.Token(Token = "0x2000012")]
	private class KCMCHFONEEJ : LKKOPIEOHJA, IDisposable
	{
		[Cpp2IlInjected.Token(Token = "0x60000CE")]
		[Cpp2IlInjected.Address(RVA = "0x6E0EB0", Offset = "0x6E00B0", VA = "0x1806E0EB0", Slot = "6")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000CF")]
		[Cpp2IlInjected.Address(RVA = "0x115B020", Offset = "0x115A220", VA = "0x18115B020", Slot = "4")]
		public Vector3 DFHCBEOPIPI()
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x60000D0")]
		[Cpp2IlInjected.Address(RVA = "0x115B020", Offset = "0x115A220", VA = "0x18115B020", Slot = "5")]
		public Vector3 JFACHOANBJO()
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x60000D1")]
		[Cpp2IlInjected.Address(RVA = "0x6C8B30", Offset = "0x6C7D30", VA = "0x1806C8B30")]
		public KCMCHFONEEJ()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000038")]
	public static LKKOPIEOHJA CKBGDNCDKBB
	{
		[Cpp2IlInjected.Token(Token = "0x60000CC")]
		[Cpp2IlInjected.Address(RVA = "0x5364BB0", Offset = "0x5363DB0", VA = "0x185364BB0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000013")]
public interface APGGGIKOMPN
{
	[Cpp2IlInjected.Token(Token = "0x17000039")]
	CollisionDetectionMode CIEEKBNHEBL
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
	void BKOELLNKDDF();

	[Cpp2IlInjected.Token(Token = "0x60000D5")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void NAIFDEINDCM(bool IOEMIKGMLIB);

	[Cpp2IlInjected.Token(Token = "0x60000D6")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void HCJANJMAAPB(bool IOEMIKGMLIB);

	[Cpp2IlInjected.Token(Token = "0x60000D7")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void JPMOLDGLNJO(Rigidbody AOAFHPHKFMD);

	[Cpp2IlInjected.Token(Token = "0x60000D8")]
	[Cpp2IlInjected.Address(Slot = "6")]
	bool CGHFGDDABEK(Vector3 HHOIMIMHDMP, out RaycastHit CFGLFCONCKN, float KMAOMDJLDEN);
}
[Cpp2IlInjected.Token(Token = "0x2000014")]
public interface ODGCKIECBJN : IDisposable, NLJGMJFEGHJ
{
	[Cpp2IlInjected.Token(Token = "0x1700003A")]
	PPGNAFCKNOL NHFAJHMDKMA
	{
		[Cpp2IlInjected.Token(Token = "0x60000DB")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
		[Cpp2IlInjected.Token(Token = "0x60000DC")]
		[Cpp2IlInjected.Address(Slot = "3")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x1400000A")]
	event Action<LHLIDFNIOKA, LHLIDFNIOKA> GBMBMPKHBHO;

	[Cpp2IlInjected.Token(Token = "0x60000DD")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void BKOELLNKDDF();
}
[Cpp2IlInjected.Token(Token = "0x2000015")]
[KFMPJDNIPEO(JHCKAKNDFFP.Application)]
public interface KMBOJHAPLLI
{
	[Cpp2IlInjected.Token(Token = "0x60000DE")]
	[Cpp2IlInjected.Address(Slot = "0")]
	HMOOAGCGLKM MJLNOLDLKOJ(PPMDIHPMNCG ONJEPBGIHBB);

	[Cpp2IlInjected.Token(Token = "0x60000DF")]
	[Cpp2IlInjected.Address(Slot = "1")]
	MPILPIJAHDO MOHHJJFOLBM(PPMDIHPMNCG ONJEPBGIHBB);

	[Cpp2IlInjected.Token(Token = "0x60000E0")]
	[Cpp2IlInjected.Address(Slot = "2")]
	NPFLLLAFPDM IMEKOCFODBG(PPMDIHPMNCG ONJEPBGIHBB);

	[Cpp2IlInjected.Token(Token = "0x60000E1")]
	[Cpp2IlInjected.Address(Slot = "3")]
	KKCAAHMNCAO HEDEOJGLLAC(PPMDIHPMNCG ONJEPBGIHBB);

	[Cpp2IlInjected.Token(Token = "0x60000E2")]
	[Cpp2IlInjected.Address(Slot = "4")]
	BBGIBEMMCOA JNPIPKPJGAO(PPMDIHPMNCG ONJEPBGIHBB);

	[Cpp2IlInjected.Token(Token = "0x60000E3")]
	[Cpp2IlInjected.Address(Slot = "5")]
	ODGCKIECBJN HEMHCEJPPBH(PPMDIHPMNCG ONJEPBGIHBB);

	[Cpp2IlInjected.Token(Token = "0x60000E4")]
	[Cpp2IlInjected.Address(Slot = "6")]
	GAMBABDLKNB GBHLIFIGFGO(PPMDIHPMNCG ONJEPBGIHBB);

	[Cpp2IlInjected.Token(Token = "0x60000E5")]
	[Cpp2IlInjected.Address(Slot = "7")]
	FGHCKEELDLL HDCLGAJOJOG(PPMDIHPMNCG ONJEPBGIHBB);

	[Cpp2IlInjected.Token(Token = "0x60000E6")]
	[Cpp2IlInjected.Address(Slot = "8")]
	APGGGIKOMPN AJBLCMCEIMG(PPMDIHPMNCG ONJEPBGIHBB);

	[Cpp2IlInjected.Token(Token = "0x60000E7")]
	[Cpp2IlInjected.Address(Slot = "9")]
	LMMEICEFKMM JIMOFCMOFGN(PPMDIHPMNCG ONJEPBGIHBB);

	[Cpp2IlInjected.Token(Token = "0x60000E8")]
	[Cpp2IlInjected.Address(Slot = "10")]
	HONAINACCHA EPFJODDPHNJ(PPMDIHPMNCG ONJEPBGIHBB, in OALOFNDFAEL ONIBEFDCPGD);

	[Cpp2IlInjected.Token(Token = "0x60000E9")]
	[Cpp2IlInjected.Address(Slot = "11")]
	LNJFNCEGNCA IMOGAPPPDNI(PPMDIHPMNCG ONJEPBGIHBB, in OALOFNDFAEL ONIBEFDCPGD);

	[Cpp2IlInjected.Token(Token = "0x60000EA")]
	[Cpp2IlInjected.Address(Slot = "12")]
	EBCDLOKEBCP MEDAGDCIAAG(PPMDIHPMNCG ONJEPBGIHBB, in OALOFNDFAEL ONIBEFDCPGD);

	[Cpp2IlInjected.Token(Token = "0x60000EB")]
	[Cpp2IlInjected.Address(Slot = "13")]
	HEFJBMMENIM PIKOPGMPFFO(PPMDIHPMNCG ONJEPBGIHBB, in OALOFNDFAEL ONIBEFDCPGD);

	[Cpp2IlInjected.Token(Token = "0x60000EC")]
	[Cpp2IlInjected.Address(Slot = "14")]
	OIAJBEDDNGM NOELAMDCDMI(PPMDIHPMNCG ONJEPBGIHBB, in OALOFNDFAEL ONIBEFDCPGD);

	[Cpp2IlInjected.Token(Token = "0x60000ED")]
	[Cpp2IlInjected.Address(Slot = "15")]
	PPMDIHPMNCG EHCIKDFINKO(RigidbodyEx LDDCANHDBNB, OALOFNDFAEL ONIBEFDCPGD, CMKMIKBKOHM OBOKKBNADPB);
}
[Cpp2IlInjected.Token(Token = "0x2000016")]
public interface FGHCKEELDLL
{
	[Cpp2IlInjected.Token(Token = "0x60000EE")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void MDAEENKEECK(Vector3 BIOMHNNIJHG, ForceMode HODPBICIGJM = ForceMode.Force);

	[Cpp2IlInjected.Token(Token = "0x60000EF")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void LIGCOMLMAAG(Vector3 BIOMHNNIJHG, Vector3 DACBJNCMNFL, ForceMode HODPBICIGJM);

	[Cpp2IlInjected.Token(Token = "0x60000F0")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void DPFOGKDMEOC(Vector3 CEBBAPNMMME, ForceMode HODPBICIGJM = ForceMode.Force);

	[Cpp2IlInjected.Token(Token = "0x60000F1")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void BFACFHPBMFM(Vector3 CEBBAPNMMME, ForceMode HODPBICIGJM = ForceMode.Force);
}
[Cpp2IlInjected.Token(Token = "0x2000017")]
public interface LMMEICEFKMM
{
	[Cpp2IlInjected.Token(Token = "0x1700003B")]
	bool HLADCICNJBO
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
	void JPMOLDGLNJO(Rigidbody AOAFHPHKFMD);

	[Cpp2IlInjected.Token(Token = "0x60000F5")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void AAGPIEFPDDG(Rigidbody AOAFHPHKFMD);
}
[Cpp2IlInjected.Token(Token = "0x2000018")]
public interface HMOOAGCGLKM : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x1700003C")]
	IReadOnlyList<PPMDIHPMNCG> LILCAAEDFCG
	{
		[Cpp2IlInjected.Token(Token = "0x6000108")]
		[Cpp2IlInjected.Address(Slot = "18")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700003D")]
	PPMDIHPMNCG MDHMHFAIMJJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000109")]
		[Cpp2IlInjected.Address(Slot = "19")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700003E")]
	PPMDIHPMNCG EMIBHNNCMJC
	{
		[Cpp2IlInjected.Token(Token = "0x600010A")]
		[Cpp2IlInjected.Address(Slot = "20")]
		get;
		[Cpp2IlInjected.Token(Token = "0x600010B")]
		[Cpp2IlInjected.Address(Slot = "21")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x1400000B")]
	event JPOFABMOGOF KMPDHKDHBNO;

	[Cpp2IlInjected.Token(Token = "0x1400000C")]
	event JPOFABMOGOF FIBPOODLACB;

	[Cpp2IlInjected.Token(Token = "0x1400000D")]
	event CBNHIOLMAOO LEBPAEACGHM;

	[Cpp2IlInjected.Token(Token = "0x1400000E")]
	event Action FJCAMHJDHPJ;

	[Cpp2IlInjected.Token(Token = "0x1400000F")]
	event Action CJALHGJOGOA;

	[Cpp2IlInjected.Token(Token = "0x14000010")]
	event Action<PPMDIHPMNCG> JIFKALNNAKN;

	[Cpp2IlInjected.Token(Token = "0x14000011")]
	event Action<PPMDIHPMNCG> DACGCLEDAOG;

	[Cpp2IlInjected.Token(Token = "0x14000012")]
	event Action HEMJJFHJOBJ;

	[Cpp2IlInjected.Token(Token = "0x14000013")]
	event Action<PPMDIHPMNCG> NDOMLKAOIDP;

	[Cpp2IlInjected.Token(Token = "0x600010C")]
	[Cpp2IlInjected.Address(Slot = "22")]
	void KKGLFGKJMPP(PPMDIHPMNCG DPPABCPODHG, bool LMKLDOOIJAA = false);
}
[Cpp2IlInjected.Token(Token = "0x2000019")]
public interface NPFLLLAFPDM
{
	[Cpp2IlInjected.Token(Token = "0x1700003F")]
	Vector3 DJHICJGOGJI
	{
		[Cpp2IlInjected.Token(Token = "0x600010D")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000040")]
	Vector3 EOFHLAGNPII
	{
		[Cpp2IlInjected.Token(Token = "0x600010E")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x600010F")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void CNAAFOJMHNK(PPMDIHPMNCG GPFONCECPBK, object AJDBKDIMOHA);

	[Cpp2IlInjected.Token(Token = "0x6000110")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void JOEIIPCOBII(object AJDBKDIMOHA);
}
[Cpp2IlInjected.Token(Token = "0x200001A")]
public interface HEFJBMMENIM
{
	[Cpp2IlInjected.Token(Token = "0x17000041")]
	Vector3 JMIIJDMAMEI
	{
		[Cpp2IlInjected.Token(Token = "0x6000113")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
		[Cpp2IlInjected.Token(Token = "0x6000114")]
		[Cpp2IlInjected.Address(Slot = "3")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000042")]
	Vector3 PMKFGPJNJBI
	{
		[Cpp2IlInjected.Token(Token = "0x6000115")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000043")]
	float KLNDCEHFMBA
	{
		[Cpp2IlInjected.Token(Token = "0x6000116")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000044")]
	float NBJLLACMBLF
	{
		[Cpp2IlInjected.Token(Token = "0x6000117")]
		[Cpp2IlInjected.Address(Slot = "6")]
		get;
		[Cpp2IlInjected.Token(Token = "0x6000118")]
		[Cpp2IlInjected.Address(Slot = "7")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000045")]
	Vector3 OFFHJCCLOEB
	{
		[Cpp2IlInjected.Token(Token = "0x6000119")]
		[Cpp2IlInjected.Address(Slot = "8")]
		get;
		[Cpp2IlInjected.Token(Token = "0x600011A")]
		[Cpp2IlInjected.Address(Slot = "9")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000046")]
	Quaternion MOMBOPJMDMK
	{
		[Cpp2IlInjected.Token(Token = "0x600011B")]
		[Cpp2IlInjected.Address(Slot = "10")]
		get;
		[Cpp2IlInjected.Token(Token = "0x600011C")]
		[Cpp2IlInjected.Address(Slot = "11")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x14000014")]
	event JPOFABMOGOF GOMGJPJMHIM;

	[Cpp2IlInjected.Token(Token = "0x600011D")]
	[Cpp2IlInjected.Address(Slot = "12")]
	void LGMIOPKMACL();

	[Cpp2IlInjected.Token(Token = "0x600011E")]
	[Cpp2IlInjected.Address(Slot = "13")]
	void OCCLJJBDHKH();

	[Cpp2IlInjected.Token(Token = "0x600011F")]
	[Cpp2IlInjected.Address(Slot = "14")]
	void PGLMPJOADGG();

	[Cpp2IlInjected.Token(Token = "0x6000120")]
	[Cpp2IlInjected.Address(Slot = "15")]
	void JPMOLDGLNJO(Rigidbody AOAFHPHKFMD);

	[Cpp2IlInjected.Token(Token = "0x6000121")]
	[Cpp2IlInjected.Address(Slot = "16")]
	void AAGPIEFPDDG(Rigidbody AOAFHPHKFMD);

	[Cpp2IlInjected.Token(Token = "0x6000122")]
	[Cpp2IlInjected.Address(Slot = "17")]
	void KEPOLBAFIFI();
}
[Cpp2IlInjected.Token(Token = "0x200001B")]
public interface EBCDLOKEBCP
{
	[Cpp2IlInjected.Token(Token = "0x17000047")]
	bool FKLEIIKAOJF
	{
		[Cpp2IlInjected.Token(Token = "0x6000123")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000048")]
	GDPCJHNBEPD MDBJGCBLKKA
	{
		[Cpp2IlInjected.Token(Token = "0x6000124")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000125")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void BKOELLNKDDF();

	[Cpp2IlInjected.Token(Token = "0x6000126")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void MPHPJCHHDKL(object AJDBKDIMOHA);

	[Cpp2IlInjected.Token(Token = "0x6000127")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void NEGAEOLBLHL(object AJDBKDIMOHA);

	[Cpp2IlInjected.Token(Token = "0x6000128")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void BKKMBNFHKCE(PPMDIHPMNCG LDDCANHDBNB);

	[Cpp2IlInjected.Token(Token = "0x6000129")]
	[Cpp2IlInjected.Address(Slot = "6")]
	void ONIPMDLLNFC(PPMDIHPMNCG LDDCANHDBNB);

	[Cpp2IlInjected.Token(Token = "0x600012A")]
	[Cpp2IlInjected.Address(Slot = "7")]
	void HIJAJPCLBLB();
}
[Cpp2IlInjected.Token(Token = "0x200001C")]
public interface GAMBABDLKNB
{
	[Cpp2IlInjected.Token(Token = "0x17000049")]
	bool MBEHMAPDJBJ
	{
		[Cpp2IlInjected.Token(Token = "0x600012D")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700004A")]
	IEnumerable<object> EKIDKKGDMDH
	{
		[Cpp2IlInjected.Token(Token = "0x600012E")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x14000015")]
	event JPOFABMOGOF JDAOGMBMFNA;

	[Cpp2IlInjected.Token(Token = "0x600012F")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void IDBKKNHMJCA(object AJDBKDIMOHA);

	[Cpp2IlInjected.Token(Token = "0x6000130")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void BPLEOILKCFF(object AJDBKDIMOHA);

	[Cpp2IlInjected.Token(Token = "0x6000131")]
	[Cpp2IlInjected.Address(Slot = "6")]
	void NHDILIPFEBO(object AJDBKDIMOHA, bool NMHFDHPJGFL);

	[Cpp2IlInjected.Token(Token = "0x6000132")]
	[Cpp2IlInjected.Address(Slot = "7")]
	IDisposable BFJJEOKEAOO();

	[Cpp2IlInjected.Token(Token = "0x6000133")]
	[Cpp2IlInjected.Address(Slot = "8")]
	void JPMOLDGLNJO(Rigidbody IHFIBCKLILB);

	[Cpp2IlInjected.Token(Token = "0x6000134")]
	[Cpp2IlInjected.Address(Slot = "9")]
	void AAGPIEFPDDG(Rigidbody AOAFHPHKFMD);
}
[Cpp2IlInjected.Token(Token = "0x200001D")]
public interface LNJFNCEGNCA : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x1700004B")]
	bool PJPIAHDKHLD
	{
		[Cpp2IlInjected.Token(Token = "0x6000137")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700004C")]
	bool EMGPBBGPGIE
	{
		[Cpp2IlInjected.Token(Token = "0x6000138")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x14000016")]
	event JPOFABMOGOF OFDNMEKJKBP;

	[Cpp2IlInjected.Token(Token = "0x6000139")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void BKOELLNKDDF();

	[Cpp2IlInjected.Token(Token = "0x600013A")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void EDMPHFFCDKG(PPMDIHPMNCG GPFONCECPBK);

	[Cpp2IlInjected.Token(Token = "0x600013B")]
	[Cpp2IlInjected.Address(Slot = "6")]
	void CLFEMCONLMI(PPMDIHPMNCG GPFONCECPBK);
}
[Cpp2IlInjected.Token(Token = "0x200001E")]
public interface OIAJBEDDNGM
{
	[Cpp2IlInjected.Token(Token = "0x1700004D")]
	bool PJGCDNLPGAK
	{
		[Cpp2IlInjected.Token(Token = "0x600013C")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
		[Cpp2IlInjected.Token(Token = "0x600013D")]
		[Cpp2IlInjected.Address(Slot = "1")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x1700004E")]
	bool AGHKJBONNGE
	{
		[Cpp2IlInjected.Token(Token = "0x600013E")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700004F")]
	RigidbodyConstraints BCMJAHAELOH
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
	void JPMOLDGLNJO(Rigidbody AOAFHPHKFMD);

	[Cpp2IlInjected.Token(Token = "0x6000142")]
	[Cpp2IlInjected.Address(Slot = "6")]
	void AAGPIEFPDDG(Rigidbody AOAFHPHKFMD);
}
[Cpp2IlInjected.Token(Token = "0x200001F")]
public interface KKCAAHMNCAO
{
	[Cpp2IlInjected.Token(Token = "0x17000050")]
	float FCGOFCPMIGL
	{
		[Cpp2IlInjected.Token(Token = "0x6000143")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
		[Cpp2IlInjected.Token(Token = "0x6000144")]
		[Cpp2IlInjected.Address(Slot = "1")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000051")]
	float CFMIJLIHCIE
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
	void JPMOLDGLNJO(Rigidbody AOAFHPHKFMD);

	[Cpp2IlInjected.Token(Token = "0x6000148")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void AAGPIEFPDDG(Rigidbody AOAFHPHKFMD);
}
[Cpp2IlInjected.Token(Token = "0x2000020")]
public interface GOFJGELBDJC
{
	[Cpp2IlInjected.Token(Token = "0x6000149")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void OnRootRBEXChanged(RigidbodyEx KJMHEDJIAAJ);
}
[Cpp2IlInjected.Token(Token = "0x2000021")]
public interface BBGIBEMMCOA
{
	[Cpp2IlInjected.Token(Token = "0x14000017")]
	event JPOFABMOGOF MLDKIENLGJG;

	[Cpp2IlInjected.Token(Token = "0x600014C")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void BKOELLNKDDF();

	[Cpp2IlInjected.Token(Token = "0x600014D")]
	[Cpp2IlInjected.Address(Slot = "3")]
	bool JLGKLAGDNBA();

	[Cpp2IlInjected.Token(Token = "0x600014E")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void ABJCFICOBMJ();

	[Cpp2IlInjected.Token(Token = "0x600014F")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void HFOIEEGNPME();

	[Cpp2IlInjected.Token(Token = "0x6000150")]
	[Cpp2IlInjected.Address(Slot = "6")]
	void LHCKEPPOJKM();

	[Cpp2IlInjected.Token(Token = "0x6000151")]
	[Cpp2IlInjected.Address(Slot = "7")]
	void IPODHJMCCPD();

	[Cpp2IlInjected.Token(Token = "0x6000152")]
	[Cpp2IlInjected.Address(Slot = "8")]
	void GCGBBMHMBBI(bool DMEOICFENFA);
}
[Cpp2IlInjected.Token(Token = "0x2000022")]
public interface HONAINACCHA
{
	[Cpp2IlInjected.Token(Token = "0x17000052")]
	Rigidbody BAPEKECGLDP
	{
		[Cpp2IlInjected.Token(Token = "0x6000153")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000154")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void BKOELLNKDDF();

	[Cpp2IlInjected.Token(Token = "0x6000155")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void NMDKIGJCKAP(object AJDBKDIMOHA);

	[Cpp2IlInjected.Token(Token = "0x6000156")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void IGIJDOMADBN(object AJDBKDIMOHA);

	[Cpp2IlInjected.Token(Token = "0x6000157")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void OHCCCGHNBBD();

	[Cpp2IlInjected.Token(Token = "0x6000158")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void GGGGLIFJEPO();

	[Cpp2IlInjected.Token(Token = "0x6000159")]
	[Cpp2IlInjected.Address(Slot = "6")]
	void AELIAEFBMCN();

	[Cpp2IlInjected.Token(Token = "0x600015A")]
	[Cpp2IlInjected.Address(Slot = "7")]
	void JNJCHBBCJEP();
}
[Cpp2IlInjected.Token(Token = "0x2000023")]
public interface MPILPIJAHDO : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x17000053")]
	LKKOPIEOHJA OLDOEMJHCAC
	{
		[Cpp2IlInjected.Token(Token = "0x600015B")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
		[Cpp2IlInjected.Token(Token = "0x600015C")]
		[Cpp2IlInjected.Address(Slot = "1")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000054")]
	FDHNJKMJJJG AEPCDANKKNF
	{
		[Cpp2IlInjected.Token(Token = "0x600015D")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
		[Cpp2IlInjected.Token(Token = "0x600015E")]
		[Cpp2IlInjected.Address(Slot = "3")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000055")]
	Vector3 MHCLHNEGJDD
	{
		[Cpp2IlInjected.Token(Token = "0x600015F")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
		[Cpp2IlInjected.Token(Token = "0x6000160")]
		[Cpp2IlInjected.Address(Slot = "5")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000056")]
	Vector3 JMJCCDADJPC
	{
		[Cpp2IlInjected.Token(Token = "0x6000161")]
		[Cpp2IlInjected.Address(Slot = "6")]
		get;
		[Cpp2IlInjected.Token(Token = "0x6000162")]
		[Cpp2IlInjected.Address(Slot = "7")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000057")]
	Vector3 DLFBGEBKEHJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000163")]
		[Cpp2IlInjected.Address(Slot = "8")]
		get;
		[Cpp2IlInjected.Token(Token = "0x6000164")]
		[Cpp2IlInjected.Address(Slot = "9")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000058")]
	Vector3 KGONIIPAFMK
	{
		[Cpp2IlInjected.Token(Token = "0x6000165")]
		[Cpp2IlInjected.Address(Slot = "10")]
		get;
		[Cpp2IlInjected.Token(Token = "0x6000166")]
		[Cpp2IlInjected.Address(Slot = "11")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000059")]
	float ENFIJFJPIPJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000167")]
		[Cpp2IlInjected.Address(Slot = "12")]
		get;
		[Cpp2IlInjected.Token(Token = "0x6000168")]
		[Cpp2IlInjected.Address(Slot = "13")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x1700005A")]
	bool OIAJDGKIDMB
	{
		[Cpp2IlInjected.Token(Token = "0x6000169")]
		[Cpp2IlInjected.Address(Slot = "14")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x600016A")]
	[Cpp2IlInjected.Address(Slot = "15")]
	void BKOELLNKDDF();

	[Cpp2IlInjected.Token(Token = "0x600016B")]
	[Cpp2IlInjected.Address(Slot = "16")]
	void HHNPBMOKIFP(object AJDBKDIMOHA);

	[Cpp2IlInjected.Token(Token = "0x600016C")]
	[Cpp2IlInjected.Address(Slot = "17")]
	void JLNINMHMEHA(BOPFIFMMKBG BPDOBLBNKEN, Vector3 NLFAAHHHDNN, float HHHNHCMFNFA = float.PositiveInfinity);

	[Cpp2IlInjected.Token(Token = "0x600016D")]
	[Cpp2IlInjected.Address(Slot = "18")]
	void GOHOEPELEBG(CBPMCKPIBHC EIOPEGEMKHP, Vector3 DKCLOLGBADH, float OOKLCGCBAJI, float LLKLELEIBGC = 8f, float AEEFHMKEOAH = 1f);

	[Cpp2IlInjected.Token(Token = "0x600016E")]
	[Cpp2IlInjected.Address(Slot = "19")]
	void ADCBOLCDFHD(BOPFIFMMKBG BPDOBLBNKEN, Vector3 MCFIHGJCDCP, float BDCHAJELIHL = 7f, float ABPPGEHGCFI = 1f);

	[Cpp2IlInjected.Token(Token = "0x600016F")]
	[Cpp2IlInjected.Address(Slot = "20")]
	void IBIENENFOLO();

	[Cpp2IlInjected.Token(Token = "0x6000170")]
	[Cpp2IlInjected.Address(Slot = "21")]
	void DGADOFDPFDE();

	[Cpp2IlInjected.Token(Token = "0x6000171")]
	[Cpp2IlInjected.Address(Slot = "22")]
	void KDDHFACBKGB();

	[Cpp2IlInjected.Token(Token = "0x6000172")]
	[Cpp2IlInjected.Address(Slot = "23")]
	void LNGHCMNGELC();

	[Cpp2IlInjected.Token(Token = "0x6000173")]
	[Cpp2IlInjected.Address(Slot = "24")]
	void JPMOLDGLNJO(Rigidbody AOAFHPHKFMD);

	[Cpp2IlInjected.Token(Token = "0x6000174")]
	[Cpp2IlInjected.Address(Slot = "25")]
	Vector3 FHKEINJELIE(Vector3 IMJEKHOJGKC);

	[Cpp2IlInjected.Token(Token = "0x6000175")]
	[Cpp2IlInjected.Address(Slot = "26")]
	Vector3 KPFDHGBBOFB(Vector3 BNEEGIEDHBB);

	[Cpp2IlInjected.Token(Token = "0x6000176")]
	[Cpp2IlInjected.Address(Slot = "27")]
	void NFNEBKIHHFL(object AJDBKDIMOHA);

	[Cpp2IlInjected.Token(Token = "0x6000177")]
	[Cpp2IlInjected.Address(Slot = "28")]
	void CADMMMANGFL(Vector3 GJKLLEKAGBH);

	[Cpp2IlInjected.Token(Token = "0x6000178")]
	[Cpp2IlInjected.Address(Slot = "29")]
	void BNKAMLPDNDH(Vector3 IHHIJIKHHIA, Vector3 NBGIHKDGDID);

	[Cpp2IlInjected.Token(Token = "0x6000179")]
	[Cpp2IlInjected.Address(Slot = "30")]
	void EEIOJCMLKKL(Vector3 PKEOGDHOABC, Vector3 GNHLNIEHAFA);

	[Cpp2IlInjected.Token(Token = "0x600017A")]
	[Cpp2IlInjected.Address(Slot = "31")]
	Vector3 JGGPKLHDPOC(Vector3 DLOMDLEMEJO);

	[Cpp2IlInjected.Token(Token = "0x600017B")]
	[Cpp2IlInjected.Address(Slot = "32")]
	Vector3 EAJIEBJEBJP(Vector3 ODPCODBLNJO);
}
[Cpp2IlInjected.Token(Token = "0x2000024")]
[KFMPJDNIPEO(JHCKAKNDFFP.Application)]
public interface GNHCFBDDFCE
{
	[Cpp2IlInjected.Token(Token = "0x1700005B")]
	bool BNNACLEEBKN
	{
		[Cpp2IlInjected.Token(Token = "0x600017C")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x600017D")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void HMDKABCPDKD(string GNLLAOFLEDB);

	[Cpp2IlInjected.Token(Token = "0x600017E")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void PMLEKKPAIBC(RigidbodyEx LDDCANHDBNB, Action GPNJNMLGIEN);

	[Cpp2IlInjected.Token(Token = "0x600017F")]
	[Cpp2IlInjected.Address(Slot = "3")]
	GNJJFOIGADA JJJBOPMPOCL(int BDENIEGMNAP);

	[Cpp2IlInjected.Token(Token = "0x6000180")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void IPHJOJMEHNN(Vector3 BJJEJPIPLBD, float JANGDGEDDPJ, Color GEDOLEMBLCF);
}
[Cpp2IlInjected.Token(Token = "0x2000025")]
[KFMPJDNIPEO(JHCKAKNDFFP.Application)]
public interface CMKMIKBKOHM
{
	[Cpp2IlInjected.Token(Token = "0x1700005C")]
	GNHCFBDDFCE DDGABFFCPAP
	{
		[Cpp2IlInjected.Token(Token = "0x6000181")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700005D")]
	KMBOJHAPLLI AJPHGKGIGMH
	{
		[Cpp2IlInjected.Token(Token = "0x6000182")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700005E")]
	bool GAAOJBBKPNA
	{
		[Cpp2IlInjected.Token(Token = "0x6000183")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000184")]
	[Cpp2IlInjected.Address(Slot = "3")]
	NFJEDPPAJMK JIOOPANAKNB(RigidbodyEx LDDCANHDBNB);

	[Cpp2IlInjected.Token(Token = "0x6000185")]
	[Cpp2IlInjected.Address(Slot = "4")]
	PPMDIHPMNCG EHCIKDFINKO(RigidbodyEx LDDCANHDBNB, OALOFNDFAEL ONIBEFDCPGD);

	[Cpp2IlInjected.Token(Token = "0x6000186")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void JKAPKEJENHH();

	[Cpp2IlInjected.Token(Token = "0x6000187")]
	[Cpp2IlInjected.Address(Slot = "6")]
	void ANMLMAOGGKE();

	[Cpp2IlInjected.Token(Token = "0x6000188")]
	[Cpp2IlInjected.Address(Slot = "7")]
	internal RigidbodyEx AMGMAIHKJLG(GameObject GODCAKDBDMK, [Optional] OALOFNDFAEL ONIBEFDCPGD);
}
[Cpp2IlInjected.Token(Token = "0x2000026")]
public interface FDHNJKMJJJG
{
	[Cpp2IlInjected.Token(Token = "0x6000189")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void OCNAJBANMGG(Vector3 HMNIOJGIDOK);

	[Cpp2IlInjected.Token(Token = "0x600018A")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void KPADOHKNGPN(Vector3 IMJEKHOJGKC);

	[Cpp2IlInjected.Token(Token = "0x600018B")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void CCONFCPCPLH(Vector3 HMNIOJGIDOK);

	[Cpp2IlInjected.Token(Token = "0x600018C")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void IBNNPKPFJFE(Vector3 IMJEKHOJGKC);
}
[Cpp2IlInjected.Token(Token = "0x2000027")]
public interface LKKOPIEOHJA : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x600018D")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Vector3 DFHCBEOPIPI();

	[Cpp2IlInjected.Token(Token = "0x600018E")]
	[Cpp2IlInjected.Address(Slot = "1")]
	Vector3 JFACHOANBJO();
}
[Cpp2IlInjected.Token(Token = "0x2000028")]
public interface PPMDIHPMNCG : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x1700005F")]
	Rigidbody BAPEKECGLDP
	{
		[Cpp2IlInjected.Token(Token = "0x600018F")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000060")]
	RigidbodyEx JKIDPKKAFKH
	{
		[Cpp2IlInjected.Token(Token = "0x6000190")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000061")]
	GameObject MNGKPNJJMOC
	{
		[Cpp2IlInjected.Token(Token = "0x6000191")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000062")]
	Transform LNPNGFHHEEL
	{
		[Cpp2IlInjected.Token(Token = "0x6000192")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000063")]
	IEnumerable<object> JNIPNMIKJIN
	{
		[Cpp2IlInjected.Token(Token = "0x6000193")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000064")]
	PPMDIHPMNCG EMIBHNNCMJC
	{
		[Cpp2IlInjected.Token(Token = "0x6000194")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
		[Cpp2IlInjected.Token(Token = "0x6000195")]
		[Cpp2IlInjected.Address(Slot = "6")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000065")]
	IReadOnlyList<PPMDIHPMNCG> LILCAAEDFCG
	{
		[Cpp2IlInjected.Token(Token = "0x6000196")]
		[Cpp2IlInjected.Address(Slot = "7")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000066")]
	PPMDIHPMNCG MDHMHFAIMJJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000197")]
		[Cpp2IlInjected.Address(Slot = "8")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000067")]
	bool DKNFKPAFDPB
	{
		[Cpp2IlInjected.Token(Token = "0x6000198")]
		[Cpp2IlInjected.Address(Slot = "9")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000068")]
	bool PJPIAHDKHLD
	{
		[Cpp2IlInjected.Token(Token = "0x6000199")]
		[Cpp2IlInjected.Address(Slot = "10")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000069")]
	bool EMGPBBGPGIE
	{
		[Cpp2IlInjected.Token(Token = "0x600019A")]
		[Cpp2IlInjected.Address(Slot = "11")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700006A")]
	LKKOPIEOHJA OLDOEMJHCAC
	{
		[Cpp2IlInjected.Token(Token = "0x600019B")]
		[Cpp2IlInjected.Address(Slot = "12")]
		get;
		[Cpp2IlInjected.Token(Token = "0x600019C")]
		[Cpp2IlInjected.Address(Slot = "13")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x1700006B")]
	FDHNJKMJJJG AEPCDANKKNF
	{
		[Cpp2IlInjected.Token(Token = "0x600019D")]
		[Cpp2IlInjected.Address(Slot = "14")]
		get;
		[Cpp2IlInjected.Token(Token = "0x600019E")]
		[Cpp2IlInjected.Address(Slot = "15")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x1700006C")]
	float ENFIJFJPIPJ
	{
		[Cpp2IlInjected.Token(Token = "0x600019F")]
		[Cpp2IlInjected.Address(Slot = "16")]
		get;
		[Cpp2IlInjected.Token(Token = "0x60001A0")]
		[Cpp2IlInjected.Address(Slot = "17")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x1700006D")]
	Vector3 JMJCCDADJPC
	{
		[Cpp2IlInjected.Token(Token = "0x60001A1")]
		[Cpp2IlInjected.Address(Slot = "18")]
		get;
		[Cpp2IlInjected.Token(Token = "0x60001A2")]
		[Cpp2IlInjected.Address(Slot = "19")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x1700006E")]
	Vector3 KGONIIPAFMK
	{
		[Cpp2IlInjected.Token(Token = "0x60001A3")]
		[Cpp2IlInjected.Address(Slot = "20")]
		get;
		[Cpp2IlInjected.Token(Token = "0x60001A4")]
		[Cpp2IlInjected.Address(Slot = "21")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x1700006F")]
	Vector3 MHCLHNEGJDD
	{
		[Cpp2IlInjected.Token(Token = "0x60001A5")]
		[Cpp2IlInjected.Address(Slot = "22")]
		get;
		[Cpp2IlInjected.Token(Token = "0x60001A6")]
		[Cpp2IlInjected.Address(Slot = "23")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000070")]
	Vector3 DLFBGEBKEHJ
	{
		[Cpp2IlInjected.Token(Token = "0x60001A7")]
		[Cpp2IlInjected.Address(Slot = "24")]
		get;
		[Cpp2IlInjected.Token(Token = "0x60001A8")]
		[Cpp2IlInjected.Address(Slot = "25")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000071")]
	bool AMMPJIIANJD
	{
		[Cpp2IlInjected.Token(Token = "0x60001A9")]
		[Cpp2IlInjected.Address(Slot = "26")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000072")]
	bool OONHJPFBNAB
	{
		[Cpp2IlInjected.Token(Token = "0x60001AA")]
		[Cpp2IlInjected.Address(Slot = "27")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000073")]
	bool AKAANNKOEAC
	{
		[Cpp2IlInjected.Token(Token = "0x60001AB")]
		[Cpp2IlInjected.Address(Slot = "28")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000074")]
	bool OIAJDGKIDMB
	{
		[Cpp2IlInjected.Token(Token = "0x60001AC")]
		[Cpp2IlInjected.Address(Slot = "29")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000075")]
	Vector3 DJHICJGOGJI
	{
		[Cpp2IlInjected.Token(Token = "0x60001AD")]
		[Cpp2IlInjected.Address(Slot = "30")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000076")]
	Vector3 EOFHLAGNPII
	{
		[Cpp2IlInjected.Token(Token = "0x60001AE")]
		[Cpp2IlInjected.Address(Slot = "31")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000077")]
	Vector3 JMIIJDMAMEI
	{
		[Cpp2IlInjected.Token(Token = "0x60001AF")]
		[Cpp2IlInjected.Address(Slot = "32")]
		get;
		[Cpp2IlInjected.Token(Token = "0x60001B0")]
		[Cpp2IlInjected.Address(Slot = "33")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000078")]
	Vector3 PMKFGPJNJBI
	{
		[Cpp2IlInjected.Token(Token = "0x60001B1")]
		[Cpp2IlInjected.Address(Slot = "34")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000079")]
	float KLNDCEHFMBA
	{
		[Cpp2IlInjected.Token(Token = "0x60001B2")]
		[Cpp2IlInjected.Address(Slot = "35")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700007A")]
	float NBJLLACMBLF
	{
		[Cpp2IlInjected.Token(Token = "0x60001B3")]
		[Cpp2IlInjected.Address(Slot = "36")]
		get;
		[Cpp2IlInjected.Token(Token = "0x60001B4")]
		[Cpp2IlInjected.Address(Slot = "37")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x1700007B")]
	Vector3 OFFHJCCLOEB
	{
		[Cpp2IlInjected.Token(Token = "0x60001B5")]
		[Cpp2IlInjected.Address(Slot = "38")]
		get;
		[Cpp2IlInjected.Token(Token = "0x60001B6")]
		[Cpp2IlInjected.Address(Slot = "39")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x1700007C")]
	Quaternion MOMBOPJMDMK
	{
		[Cpp2IlInjected.Token(Token = "0x60001B7")]
		[Cpp2IlInjected.Address(Slot = "40")]
		get;
		[Cpp2IlInjected.Token(Token = "0x60001B8")]
		[Cpp2IlInjected.Address(Slot = "41")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x1700007D")]
	float FCGOFCPMIGL
	{
		[Cpp2IlInjected.Token(Token = "0x60001B9")]
		[Cpp2IlInjected.Address(Slot = "42")]
		get;
		[Cpp2IlInjected.Token(Token = "0x60001BA")]
		[Cpp2IlInjected.Address(Slot = "43")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x1700007E")]
	float CFMIJLIHCIE
	{
		[Cpp2IlInjected.Token(Token = "0x60001BB")]
		[Cpp2IlInjected.Address(Slot = "44")]
		get;
		[Cpp2IlInjected.Token(Token = "0x60001BC")]
		[Cpp2IlInjected.Address(Slot = "45")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x1700007F")]
	bool HLADCICNJBO
	{
		[Cpp2IlInjected.Token(Token = "0x60001BD")]
		[Cpp2IlInjected.Address(Slot = "46")]
		get;
		[Cpp2IlInjected.Token(Token = "0x60001BE")]
		[Cpp2IlInjected.Address(Slot = "47")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000080")]
	PPGNAFCKNOL NHFAJHMDKMA
	{
		[Cpp2IlInjected.Token(Token = "0x60001BF")]
		[Cpp2IlInjected.Address(Slot = "48")]
		get;
		[Cpp2IlInjected.Token(Token = "0x60001C0")]
		[Cpp2IlInjected.Address(Slot = "49")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000081")]
	bool MBEHMAPDJBJ
	{
		[Cpp2IlInjected.Token(Token = "0x60001C1")]
		[Cpp2IlInjected.Address(Slot = "50")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000082")]
	Transform PDLNBKLCFJO
	{
		[Cpp2IlInjected.Token(Token = "0x60001C2")]
		[Cpp2IlInjected.Address(Slot = "51")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000083")]
	Transform IPOOCBGBBCA
	{
		[Cpp2IlInjected.Token(Token = "0x60001C3")]
		[Cpp2IlInjected.Address(Slot = "52")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000084")]
	Vector3 GCIAIFNDFJO
	{
		[Cpp2IlInjected.Token(Token = "0x60001C4")]
		[Cpp2IlInjected.Address(Slot = "53")]
		get;
		[Cpp2IlInjected.Token(Token = "0x60001C5")]
		[Cpp2IlInjected.Address(Slot = "54")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000085")]
	float BIJKBCGODIE
	{
		[Cpp2IlInjected.Token(Token = "0x60001C6")]
		[Cpp2IlInjected.Address(Slot = "55")]
		get;
		[Cpp2IlInjected.Token(Token = "0x60001C7")]
		[Cpp2IlInjected.Address(Slot = "56")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000086")]
	float CAEPFBBJBOK
	{
		[Cpp2IlInjected.Token(Token = "0x60001C8")]
		[Cpp2IlInjected.Address(Slot = "57")]
		get;
		[Cpp2IlInjected.Token(Token = "0x60001C9")]
		[Cpp2IlInjected.Address(Slot = "58")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000087")]
	Quaternion LBGIBJJINJH
	{
		[Cpp2IlInjected.Token(Token = "0x60001CA")]
		[Cpp2IlInjected.Address(Slot = "59")]
		get;
		[Cpp2IlInjected.Token(Token = "0x60001CB")]
		[Cpp2IlInjected.Address(Slot = "60")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000088")]
	Vector3 EDNJLBDPNMM
	{
		[Cpp2IlInjected.Token(Token = "0x60001CC")]
		[Cpp2IlInjected.Address(Slot = "61")]
		get;
		[Cpp2IlInjected.Token(Token = "0x60001CD")]
		[Cpp2IlInjected.Address(Slot = "62")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000089")]
	Quaternion DIIIGEGILHP
	{
		[Cpp2IlInjected.Token(Token = "0x60001CE")]
		[Cpp2IlInjected.Address(Slot = "63")]
		get;
		[Cpp2IlInjected.Token(Token = "0x60001CF")]
		[Cpp2IlInjected.Address(Slot = "64")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x1700008A")]
	RigidbodyConstraints BCMJAHAELOH
	{
		[Cpp2IlInjected.Token(Token = "0x60001D0")]
		[Cpp2IlInjected.Address(Slot = "65")]
		get;
		[Cpp2IlInjected.Token(Token = "0x60001D1")]
		[Cpp2IlInjected.Address(Slot = "66")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x1700008B")]
	bool PJGCDNLPGAK
	{
		[Cpp2IlInjected.Token(Token = "0x60001D2")]
		[Cpp2IlInjected.Address(Slot = "67")]
		get;
		[Cpp2IlInjected.Token(Token = "0x60001D3")]
		[Cpp2IlInjected.Address(Slot = "68")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x1700008C")]
	CollisionDetectionMode CIEEKBNHEBL
	{
		[Cpp2IlInjected.Token(Token = "0x60001D4")]
		[Cpp2IlInjected.Address(Slot = "69")]
		get;
		[Cpp2IlInjected.Token(Token = "0x60001D5")]
		[Cpp2IlInjected.Address(Slot = "70")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x1700008D")]
	bool NFEEOKFPIGD
	{
		[Cpp2IlInjected.Token(Token = "0x60001D6")]
		[Cpp2IlInjected.Address(Slot = "71")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x14000018")]
	event JPOFABMOGOF KMPDHKDHBNO;

	[Cpp2IlInjected.Token(Token = "0x14000019")]
	event JPOFABMOGOF FIBPOODLACB;

	[Cpp2IlInjected.Token(Token = "0x1400001A")]
	event CBNHIOLMAOO LEBPAEACGHM;

	[Cpp2IlInjected.Token(Token = "0x1400001B")]
	event JPOFABMOGOF OFDNMEKJKBP;

	[Cpp2IlInjected.Token(Token = "0x1400001C")]
	event JPOFABMOGOF GHPNGDBINKD;

	[Cpp2IlInjected.Token(Token = "0x1400001D")]
	event JPOFABMOGOF MLDKIENLGJG;

	[Cpp2IlInjected.Token(Token = "0x1400001E")]
	event Action<LHLIDFNIOKA, LHLIDFNIOKA> GBMBMPKHBHO;

	[Cpp2IlInjected.Token(Token = "0x1400001F")]
	event JPOFABMOGOF KKHOKOPLGIE;

	[Cpp2IlInjected.Token(Token = "0x14000020")]
	event JPOFABMOGOF FAMCBBOPNHD;

	[Cpp2IlInjected.Token(Token = "0x60001D7")]
	[Cpp2IlInjected.Address(Slot = "72")]
	void BKOELLNKDDF();

	[Cpp2IlInjected.Token(Token = "0x60001D8")]
	[Cpp2IlInjected.Address(Slot = "73")]
	void IDDPIKDPIIE();

	[Cpp2IlInjected.Token(Token = "0x60001D9")]
	[Cpp2IlInjected.Address(Slot = "74")]
	void EDIJBNLFNNB();

	[Cpp2IlInjected.Token(Token = "0x60001DA")]
	[Cpp2IlInjected.Address(Slot = "75")]
	void HFOIEEGNPME();

	[Cpp2IlInjected.Token(Token = "0x60001DB")]
	[Cpp2IlInjected.Address(Slot = "76")]
	void FODBIMBAOBD();

	[Cpp2IlInjected.Token(Token = "0x60001E2")]
	[Cpp2IlInjected.Address(Slot = "83")]
	void KKGLFGKJMPP(PPMDIHPMNCG JFBPNBNBHOE, bool LMKLDOOIJAA = false);

	[Cpp2IlInjected.Token(Token = "0x60001E5")]
	[Cpp2IlInjected.Address(Slot = "86")]
	void CGMPABBBBGH(object AJDBKDIMOHA);

	[Cpp2IlInjected.Token(Token = "0x60001E6")]
	[Cpp2IlInjected.Address(Slot = "87")]
	void AKPJCFEODOB(object AJDBKDIMOHA);

	[Cpp2IlInjected.Token(Token = "0x60001E7")]
	[Cpp2IlInjected.Address(Slot = "88")]
	Vector3 EAJIEBJEBJP(Vector3 ODPCODBLNJO);

	[Cpp2IlInjected.Token(Token = "0x60001E8")]
	[Cpp2IlInjected.Address(Slot = "89")]
	Vector3 JGGPKLHDPOC(Vector3 DLOMDLEMEJO);

	[Cpp2IlInjected.Token(Token = "0x60001E9")]
	[Cpp2IlInjected.Address(Slot = "90")]
	void LNGHCMNGELC();

	[Cpp2IlInjected.Token(Token = "0x60001EA")]
	[Cpp2IlInjected.Address(Slot = "91")]
	void DGADOFDPFDE();

	[Cpp2IlInjected.Token(Token = "0x60001EB")]
	[Cpp2IlInjected.Address(Slot = "92")]
	void IBIENENFOLO();

	[Cpp2IlInjected.Token(Token = "0x60001EC")]
	[Cpp2IlInjected.Address(Slot = "93")]
	void EEIOJCMLKKL(Vector3 PKEOGDHOABC, Vector3 GNHLNIEHAFA);

	[Cpp2IlInjected.Token(Token = "0x60001ED")]
	[Cpp2IlInjected.Address(Slot = "94")]
	void BNKAMLPDNDH(Vector3 IHHIJIKHHIA, Vector3 NBGIHKDGDID);

	[Cpp2IlInjected.Token(Token = "0x60001EE")]
	[Cpp2IlInjected.Address(Slot = "95")]
	void CADMMMANGFL(Vector3 GJKLLEKAGBH);

	[Cpp2IlInjected.Token(Token = "0x60001EF")]
	[Cpp2IlInjected.Address(Slot = "96")]
	void GOHOEPELEBG(CBPMCKPIBHC EIOPEGEMKHP, Vector3 DKCLOLGBADH, float OOKLCGCBAJI, float LLKLELEIBGC = 8f, float AEEFHMKEOAH = 1f);

	[Cpp2IlInjected.Token(Token = "0x60001F0")]
	[Cpp2IlInjected.Address(Slot = "97")]
	void JLNINMHMEHA(BOPFIFMMKBG BPDOBLBNKEN, Vector3 NLFAAHHHDNN, float HHHNHCMFNFA = float.PositiveInfinity);

	[Cpp2IlInjected.Token(Token = "0x60001F1")]
	[Cpp2IlInjected.Address(Slot = "98")]
	void ADCBOLCDFHD(BOPFIFMMKBG BPDOBLBNKEN, Vector3 MCFIHGJCDCP, float BDCHAJELIHL = 7f, float ABPPGEHGCFI = 1f);

	[Cpp2IlInjected.Token(Token = "0x60001F2")]
	[Cpp2IlInjected.Address(Slot = "99")]
	Vector3 KPFDHGBBOFB(Vector3 JFBPNBNBHOE);

	[Cpp2IlInjected.Token(Token = "0x60001F3")]
	[Cpp2IlInjected.Address(Slot = "100")]
	Vector3 FHKEINJELIE(Vector3 JFBPNBNBHOE);

	[Cpp2IlInjected.Token(Token = "0x60001F4")]
	[Cpp2IlInjected.Address(Slot = "101")]
	void KDDHFACBKGB();

	[Cpp2IlInjected.Token(Token = "0x60001F5")]
	[Cpp2IlInjected.Address(Slot = "102")]
	void KFIEFEHILOK(PPMDIHPMNCG FONAKEEEKPK, object AJDBKDIMOHA);

	[Cpp2IlInjected.Token(Token = "0x60001F6")]
	[Cpp2IlInjected.Address(Slot = "103")]
	void MMHJICPHJHL(object AJDBKDIMOHA);

	[Cpp2IlInjected.Token(Token = "0x60001F9")]
	[Cpp2IlInjected.Address(Slot = "106")]
	void OCCLJJBDHKH();

	[Cpp2IlInjected.Token(Token = "0x60001FA")]
	[Cpp2IlInjected.Address(Slot = "107")]
	void LGMIOPKMACL();

	[Cpp2IlInjected.Token(Token = "0x60001FB")]
	[Cpp2IlInjected.Address(Slot = "108")]
	void PGLMPJOADGG();

	[Cpp2IlInjected.Token(Token = "0x60001FE")]
	[Cpp2IlInjected.Address(Slot = "111")]
	bool JLGKLAGDNBA();

	[Cpp2IlInjected.Token(Token = "0x60001FF")]
	[Cpp2IlInjected.Address(Slot = "112")]
	void IPODHJMCCPD();

	[Cpp2IlInjected.Token(Token = "0x6000204")]
	[Cpp2IlInjected.Address(Slot = "117")]
	IDisposable BFJJEOKEAOO();

	[Cpp2IlInjected.Token(Token = "0x6000205")]
	[Cpp2IlInjected.Address(Slot = "118")]
	void IDBKKNHMJCA(object AJDBKDIMOHA);

	[Cpp2IlInjected.Token(Token = "0x6000206")]
	[Cpp2IlInjected.Address(Slot = "119")]
	void BPLEOILKCFF(object AJDBKDIMOHA);

	[Cpp2IlInjected.Token(Token = "0x6000207")]
	[Cpp2IlInjected.Address(Slot = "120")]
	void NHDILIPFEBO(object AJDBKDIMOHA, bool NMHFDHPJGFL);

	[Cpp2IlInjected.Token(Token = "0x600020A")]
	[Cpp2IlInjected.Address(Slot = "123")]
	void BBLLMNKJMFE(Vector3 LDBCCJOIJOF, Quaternion HPGHCBDEGFJ);

	[Cpp2IlInjected.Token(Token = "0x600020B")]
	[Cpp2IlInjected.Address(Slot = "124")]
	void MBJKCDHFBPN(Vector3 JPBAEPJPHFP, Quaternion NHHKEMOEKHO);

	[Cpp2IlInjected.Token(Token = "0x600020C")]
	[Cpp2IlInjected.Address(Slot = "125")]
	bool BHKLDAAMMPP(float LCLMOJDNELD);

	[Cpp2IlInjected.Token(Token = "0x600020D")]
	[Cpp2IlInjected.Address(Slot = "126")]
	void PGKAPIBFPCH(object AJDBKDIMOHA);

	[Cpp2IlInjected.Token(Token = "0x600020E")]
	[Cpp2IlInjected.Address(Slot = "127")]
	void DFLECBDEDLK(object AJDBKDIMOHA);

	[Cpp2IlInjected.Token(Token = "0x600020F")]
	[Cpp2IlInjected.Address(Slot = "128")]
	void NMDKIGJCKAP(object AJDBKDIMOHA);

	[Cpp2IlInjected.Token(Token = "0x6000210")]
	[Cpp2IlInjected.Address(Slot = "129")]
	void IGIJDOMADBN(object AJDBKDIMOHA);

	[Cpp2IlInjected.Token(Token = "0x6000211")]
	[Cpp2IlInjected.Address(Slot = "130")]
	void MDAEENKEECK(Vector3 BIOMHNNIJHG, ForceMode HODPBICIGJM = ForceMode.Force);

	[Cpp2IlInjected.Token(Token = "0x6000212")]
	[Cpp2IlInjected.Address(Slot = "131")]
	void LIGCOMLMAAG(Vector3 BIOMHNNIJHG, Vector3 DACBJNCMNFL, ForceMode HODPBICIGJM);

	[Cpp2IlInjected.Token(Token = "0x6000213")]
	[Cpp2IlInjected.Address(Slot = "132")]
	void DPFOGKDMEOC(Vector3 CEBBAPNMMME, ForceMode HODPBICIGJM = ForceMode.Force);

	[Cpp2IlInjected.Token(Token = "0x6000214")]
	[Cpp2IlInjected.Address(Slot = "133")]
	void BFACFHPBMFM(Vector3 CEBBAPNMMME, ForceMode HODPBICIGJM = ForceMode.Force);

	[Cpp2IlInjected.Token(Token = "0x6000215")]
	[Cpp2IlInjected.Address(Slot = "134")]
	bool CGHFGDDABEK(Vector3 HHOIMIMHDMP, out RaycastHit CFGLFCONCKN, float KMAOMDJLDEN);

	[Cpp2IlInjected.Token(Token = "0x6000216")]
	[Cpp2IlInjected.Address(Slot = "135")]
	void KEPOLBAFIFI();

	[Cpp2IlInjected.Token(Token = "0x6000217")]
	[Cpp2IlInjected.Address(Slot = "136")]
	new string ToString();
}
[Cpp2IlInjected.Token(Token = "0x2000029")]
public class DGHPEMNHGCH : PPMDIHPMNCG, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000031")]
	internal readonly CMKMIKBKOHM OBOKKBNADPB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000032")]
	internal HMOOAGCGLKM FPAHGFEONEG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000033")]
	internal EBCDLOKEBCP ENJCHFAIPBP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000034")]
	internal LNJFNCEGNCA JHGGFPKIOOH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000035")]
	internal MPILPIJAHDO BNEEGIEDHBB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000036")]
	internal NPFLLLAFPDM FDFJFLEGNJI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000037")]
	internal HEFJBMMENIM NLHHIPFAJGC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000038")]
	internal KKCAAHMNCAO HKKDOONMLJK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000039")]
	internal LMMEICEFKMM HPDJLHMDGJL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x400003A")]
	internal BBGIBEMMCOA KAIGHOJFBHN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x400003B")]
	internal ODGCKIECBJN CNGLAECGKOP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x400003C")]
	internal GAMBABDLKNB LCNDBJBJJJH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x400003D")]
	internal FGHCKEELDLL BIOMHNNIJHG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
	[Cpp2IlInjected.Token(Token = "0x400003E")]
	internal OIAJBEDDNGM HPOBMMHJMIO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x400003F")]
	internal HONAINACCHA AOAFHPHKFMD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
	[Cpp2IlInjected.Token(Token = "0x4000040")]
	internal APGGGIKOMPN JIKIBEPCNNP;

	[Cpp2IlInjected.Token(Token = "0x1700008E")]
	public RigidbodyEx JKIDPKKAFKH
	{
		[Cpp2IlInjected.Token(Token = "0x6000218")]
		[Cpp2IlInjected.Address(RVA = "0x6CDE20", Offset = "0x6CD020", VA = "0x1806CDE20", Slot = "5")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000219")]
		[Cpp2IlInjected.Address(RVA = "0x846610", Offset = "0x845810", VA = "0x180846610")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700008F")]
	public GameObject MNGKPNJJMOC
	{
		[Cpp2IlInjected.Token(Token = "0x600021A")]
		[Cpp2IlInjected.Address(RVA = "0x7036A0", Offset = "0x7028A0", VA = "0x1807036A0", Slot = "6")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600021B")]
		[Cpp2IlInjected.Address(RVA = "0x8D1530", Offset = "0x8D0730", VA = "0x1808D1530")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000090")]
	public Transform LNPNGFHHEEL
	{
		[Cpp2IlInjected.Token(Token = "0x600021C")]
		[Cpp2IlInjected.Address(RVA = "0x5359E60", Offset = "0x5359060", VA = "0x185359E60", Slot = "7")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000091")]
	public IEnumerable<object> JNIPNMIKJIN
	{
		[Cpp2IlInjected.Token(Token = "0x600021D")]
		[Cpp2IlInjected.Address(RVA = "0x535DFD0", Offset = "0x535D1D0", VA = "0x18535DFD0", Slot = "8")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000092")]
	public Rigidbody BAPEKECGLDP
	{
		[Cpp2IlInjected.Token(Token = "0x600021E")]
		[Cpp2IlInjected.Address(RVA = "0x535F920", Offset = "0x535EB20", VA = "0x18535F920", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000093")]
	public PPMDIHPMNCG EMIBHNNCMJC
	{
		[Cpp2IlInjected.Token(Token = "0x600022C")]
		[Cpp2IlInjected.Address(RVA = "0x535EF10", Offset = "0x535E110", VA = "0x18535EF10", Slot = "9")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600022D")]
		[Cpp2IlInjected.Address(RVA = "0x535F760", Offset = "0x535E960", VA = "0x18535F760", Slot = "10")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000094")]
	public IReadOnlyList<PPMDIHPMNCG> LILCAAEDFCG
	{
		[Cpp2IlInjected.Token(Token = "0x600022E")]
		[Cpp2IlInjected.Address(RVA = "0x535A750", Offset = "0x5359950", VA = "0x18535A750", Slot = "11")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000095")]
	public PPMDIHPMNCG MDHMHFAIMJJ
	{
		[Cpp2IlInjected.Token(Token = "0x600022F")]
		[Cpp2IlInjected.Address(RVA = "0x535CCA0", Offset = "0x535BEA0", VA = "0x18535CCA0", Slot = "12")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000096")]
	public bool DKNFKPAFDPB
	{
		[Cpp2IlInjected.Token(Token = "0x6000230")]
		[Cpp2IlInjected.Address(RVA = "0x535B470", Offset = "0x535A670", VA = "0x18535B470", Slot = "13")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000097")]
	public bool PJPIAHDKHLD
	{
		[Cpp2IlInjected.Token(Token = "0x6000234")]
		[Cpp2IlInjected.Address(RVA = "0x535B080", Offset = "0x535A280", VA = "0x18535B080", Slot = "14")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000098")]
	public bool EMGPBBGPGIE
	{
		[Cpp2IlInjected.Token(Token = "0x6000235")]
		[Cpp2IlInjected.Address(RVA = "0x535A610", Offset = "0x5359810", VA = "0x18535A610", Slot = "15")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000099")]
	public LKKOPIEOHJA OLDOEMJHCAC
	{
		[Cpp2IlInjected.Token(Token = "0x6000236")]
		[Cpp2IlInjected.Address(RVA = "0x535CAC0", Offset = "0x535BCC0", VA = "0x18535CAC0", Slot = "16")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000237")]
		[Cpp2IlInjected.Address(RVA = "0x535D0F0", Offset = "0x535C2F0", VA = "0x18535D0F0", Slot = "17")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700009A")]
	public FDHNJKMJJJG AEPCDANKKNF
	{
		[Cpp2IlInjected.Token(Token = "0x6000238")]
		[Cpp2IlInjected.Address(RVA = "0x535A480", Offset = "0x5359680", VA = "0x18535A480", Slot = "18")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000239")]
		[Cpp2IlInjected.Address(RVA = "0x535C0D0", Offset = "0x535B2D0", VA = "0x18535C0D0", Slot = "19")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700009B")]
	public float ENFIJFJPIPJ
	{
		[Cpp2IlInjected.Token(Token = "0x600023A")]
		[Cpp2IlInjected.Address(RVA = "0x535F7C0", Offset = "0x535E9C0", VA = "0x18535F7C0", Slot = "20")]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x600023B")]
		[Cpp2IlInjected.Address(RVA = "0x535F970", Offset = "0x535EB70", VA = "0x18535F970", Slot = "21")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700009C")]
	public Vector3 JMJCCDADJPC
	{
		[Cpp2IlInjected.Token(Token = "0x600023C")]
		[Cpp2IlInjected.Address(RVA = "0x535D440", Offset = "0x535C640", VA = "0x18535D440", Slot = "22")]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x600023D")]
		[Cpp2IlInjected.Address(RVA = "0x535D760", Offset = "0x535C960", VA = "0x18535D760", Slot = "23")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700009D")]
	public Vector3 KGONIIPAFMK
	{
		[Cpp2IlInjected.Token(Token = "0x600023E")]
		[Cpp2IlInjected.Address(RVA = "0x535DC70", Offset = "0x535CE70", VA = "0x18535DC70", Slot = "24")]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x600023F")]
		[Cpp2IlInjected.Address(RVA = "0x535BF50", Offset = "0x535B150", VA = "0x18535BF50", Slot = "25")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700009E")]
	public Vector3 MHCLHNEGJDD
	{
		[Cpp2IlInjected.Token(Token = "0x6000240")]
		[Cpp2IlInjected.Address(RVA = "0x535A920", Offset = "0x5359B20", VA = "0x18535A920", Slot = "26")]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x6000241")]
		[Cpp2IlInjected.Address(RVA = "0x535C9A0", Offset = "0x535BBA0", VA = "0x18535C9A0", Slot = "27")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700009F")]
	public Vector3 DLFBGEBKEHJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000242")]
		[Cpp2IlInjected.Address(RVA = "0x535CB10", Offset = "0x535BD10", VA = "0x18535CB10", Slot = "28")]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x6000243")]
		[Cpp2IlInjected.Address(RVA = "0x535DE10", Offset = "0x535D010", VA = "0x18535DE10", Slot = "29")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A0")]
	public bool AMMPJIIANJD
	{
		[Cpp2IlInjected.Token(Token = "0x6000244")]
		[Cpp2IlInjected.Address(RVA = "0x535B1E0", Offset = "0x535A3E0", VA = "0x18535B1E0", Slot = "30")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A1")]
	public bool OONHJPFBNAB
	{
		[Cpp2IlInjected.Token(Token = "0x6000245")]
		[Cpp2IlInjected.Address(RVA = "0x535D090", Offset = "0x535C290", VA = "0x18535D090", Slot = "31")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A2")]
	public bool AKAANNKOEAC
	{
		[Cpp2IlInjected.Token(Token = "0x6000246")]
		[Cpp2IlInjected.Address(RVA = "0x5359AC0", Offset = "0x5358CC0", VA = "0x185359AC0", Slot = "32")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A3")]
	public bool OIAJDGKIDMB
	{
		[Cpp2IlInjected.Token(Token = "0x6000247")]
		[Cpp2IlInjected.Address(RVA = "0x535A8D0", Offset = "0x5359AD0", VA = "0x18535A8D0", Slot = "33")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A4")]
	public Vector3 DJHICJGOGJI
	{
		[Cpp2IlInjected.Token(Token = "0x6000258")]
		[Cpp2IlInjected.Address(RVA = "0x535DA30", Offset = "0x535CC30", VA = "0x18535DA30", Slot = "34")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A5")]
	public Vector3 EOFHLAGNPII
	{
		[Cpp2IlInjected.Token(Token = "0x6000259")]
		[Cpp2IlInjected.Address(RVA = "0x535F520", Offset = "0x535E720", VA = "0x18535F520", Slot = "35")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A6")]
	public Vector3 JMIIJDMAMEI
	{
		[Cpp2IlInjected.Token(Token = "0x600025E")]
		[Cpp2IlInjected.Address(RVA = "0x535D2D0", Offset = "0x535C4D0", VA = "0x18535D2D0", Slot = "36")]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x600025F")]
		[Cpp2IlInjected.Address(RVA = "0x535C800", Offset = "0x535BA00", VA = "0x18535C800", Slot = "37")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A7")]
	public Vector3 PMKFGPJNJBI
	{
		[Cpp2IlInjected.Token(Token = "0x6000260")]
		[Cpp2IlInjected.Address(RVA = "0x535A9F0", Offset = "0x5359BF0", VA = "0x18535A9F0", Slot = "38")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A8")]
	public float KLNDCEHFMBA
	{
		[Cpp2IlInjected.Token(Token = "0x6000261")]
		[Cpp2IlInjected.Address(RVA = "0x535CDF0", Offset = "0x535BFF0", VA = "0x18535CDF0", Slot = "39")]
		get
		{
			return default(float);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A9")]
	public float NBJLLACMBLF
	{
		[Cpp2IlInjected.Token(Token = "0x6000262")]
		[Cpp2IlInjected.Address(RVA = "0x535D3A0", Offset = "0x535C5A0", VA = "0x18535D3A0", Slot = "40")]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x6000263")]
		[Cpp2IlInjected.Address(RVA = "0x535F700", Offset = "0x535E900", VA = "0x18535F700", Slot = "41")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000AA")]
	public Vector3 OFFHJCCLOEB
	{
		[Cpp2IlInjected.Token(Token = "0x6000264")]
		[Cpp2IlInjected.Address(RVA = "0x535B7E0", Offset = "0x535A9E0", VA = "0x18535B7E0", Slot = "42")]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x6000265")]
		[Cpp2IlInjected.Address(RVA = "0x535C500", Offset = "0x535B700", VA = "0x18535C500", Slot = "43")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000AB")]
	public Quaternion MOMBOPJMDMK
	{
		[Cpp2IlInjected.Token(Token = "0x6000266")]
		[Cpp2IlInjected.Address(RVA = "0x535AFB0", Offset = "0x535A1B0", VA = "0x18535AFB0", Slot = "44")]
		get
		{
			return default(Quaternion);
		}
		[Cpp2IlInjected.Token(Token = "0x6000267")]
		[Cpp2IlInjected.Address(RVA = "0x535D150", Offset = "0x535C350", VA = "0x18535D150", Slot = "45")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000AC")]
	public float FCGOFCPMIGL
	{
		[Cpp2IlInjected.Token(Token = "0x600026B")]
		[Cpp2IlInjected.Address(RVA = "0x535A100", Offset = "0x5359300", VA = "0x18535A100", Slot = "46")]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x600026C")]
		[Cpp2IlInjected.Address(RVA = "0x535F810", Offset = "0x535EA10", VA = "0x18535F810", Slot = "47")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000AD")]
	public float CFMIJLIHCIE
	{
		[Cpp2IlInjected.Token(Token = "0x600026D")]
		[Cpp2IlInjected.Address(RVA = "0x535FA30", Offset = "0x535EC30", VA = "0x18535FA30", Slot = "48")]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x600026E")]
		[Cpp2IlInjected.Address(RVA = "0x535F9D0", Offset = "0x535EBD0", VA = "0x18535F9D0", Slot = "49")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000AE")]
	public bool HLADCICNJBO
	{
		[Cpp2IlInjected.Token(Token = "0x600026F")]
		[Cpp2IlInjected.Address(RVA = "0x535A260", Offset = "0x5359460", VA = "0x18535A260", Slot = "50")]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000270")]
		[Cpp2IlInjected.Address(RVA = "0x535BA60", Offset = "0x535AC60", VA = "0x18535BA60", Slot = "51")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000AF")]
	public PPGNAFCKNOL NHFAJHMDKMA
	{
		[Cpp2IlInjected.Token(Token = "0x6000278")]
		[Cpp2IlInjected.Address(RVA = "0x535D830", Offset = "0x535CA30", VA = "0x18535D830", Slot = "52")]
		get
		{
			return default(PPGNAFCKNOL);
		}
		[Cpp2IlInjected.Token(Token = "0x6000279")]
		[Cpp2IlInjected.Address(RVA = "0x535EBC0", Offset = "0x535DDC0", VA = "0x18535EBC0", Slot = "53")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B0")]
	public bool MBEHMAPDJBJ
	{
		[Cpp2IlInjected.Token(Token = "0x600027C")]
		[Cpp2IlInjected.Address(RVA = "0x535B730", Offset = "0x535A930", VA = "0x18535B730", Slot = "54")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B1")]
	public Transform PDLNBKLCFJO
	{
		[Cpp2IlInjected.Token(Token = "0x6000283")]
		[Cpp2IlInjected.Address(RVA = "0x535E120", Offset = "0x535D320", VA = "0x18535E120", Slot = "55")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B2")]
	public Transform IPOOCBGBBCA
	{
		[Cpp2IlInjected.Token(Token = "0x6000284")]
		[Cpp2IlInjected.Address(RVA = "0x535E120", Offset = "0x535D320", VA = "0x18535E120", Slot = "56")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B3")]
	public Vector3 GCIAIFNDFJO
	{
		[Cpp2IlInjected.Token(Token = "0x6000285")]
		[Cpp2IlInjected.Address(RVA = "0x535D220", Offset = "0x535C420", VA = "0x18535D220", Slot = "57")]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x6000286")]
		[Cpp2IlInjected.Address(RVA = "0x535CE40", Offset = "0x535C040", VA = "0x18535CE40", Slot = "58")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B4")]
	public float BIJKBCGODIE
	{
		[Cpp2IlInjected.Token(Token = "0x6000287")]
		[Cpp2IlInjected.Address(RVA = "0x535DDB0", Offset = "0x535CFB0", VA = "0x18535DDB0", Slot = "59")]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x6000288")]
		[Cpp2IlInjected.Address(RVA = "0x535D510", Offset = "0x535C710", VA = "0x18535D510", Slot = "60")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B5")]
	public float CAEPFBBJBOK
	{
		[Cpp2IlInjected.Token(Token = "0x6000289")]
		[Cpp2IlInjected.Address(RVA = "0x535ADF0", Offset = "0x5359FF0", VA = "0x18535ADF0", Slot = "61")]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x600028A")]
		[Cpp2IlInjected.Address(RVA = "0x535B8B0", Offset = "0x535AAB0", VA = "0x18535B8B0", Slot = "62")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B6")]
	public Quaternion LBGIBJJINJH
	{
		[Cpp2IlInjected.Token(Token = "0x600028B")]
		[Cpp2IlInjected.Address(RVA = "0x535AC20", Offset = "0x5359E20", VA = "0x18535AC20", Slot = "63")]
		get
		{
			return default(Quaternion);
		}
		[Cpp2IlInjected.Token(Token = "0x600028C")]
		[Cpp2IlInjected.Address(RVA = "0x535B6A0", Offset = "0x535A8A0", VA = "0x18535B6A0", Slot = "64")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B7")]
	public Vector3 EDNJLBDPNMM
	{
		[Cpp2IlInjected.Token(Token = "0x600028D")]
		[Cpp2IlInjected.Address(RVA = "0x535E5C0", Offset = "0x535D7C0", VA = "0x18535E5C0", Slot = "65")]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x600028E")]
		[Cpp2IlInjected.Address(RVA = "0x535EF60", Offset = "0x535E160", VA = "0x18535EF60", Slot = "66")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B8")]
	public Quaternion DIIIGEGILHP
	{
		[Cpp2IlInjected.Token(Token = "0x600028F")]
		[Cpp2IlInjected.Address(RVA = "0x535ADB0", Offset = "0x5359FB0", VA = "0x18535ADB0", Slot = "67")]
		get
		{
			return default(Quaternion);
		}
		[Cpp2IlInjected.Token(Token = "0x6000290")]
		[Cpp2IlInjected.Address(RVA = "0x5359D60", Offset = "0x5358F60", VA = "0x185359D60", Slot = "68")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B9")]
	public RigidbodyConstraints BCMJAHAELOH
	{
		[Cpp2IlInjected.Token(Token = "0x6000294")]
		[Cpp2IlInjected.Address(RVA = "0x535C450", Offset = "0x535B650", VA = "0x18535C450", Slot = "69")]
		get
		{
			return default(RigidbodyConstraints);
		}
		[Cpp2IlInjected.Token(Token = "0x6000295")]
		[Cpp2IlInjected.Address(RVA = "0x535EE50", Offset = "0x535E050", VA = "0x18535EE50", Slot = "70")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000BA")]
	public bool PJGCDNLPGAK
	{
		[Cpp2IlInjected.Token(Token = "0x6000296")]
		[Cpp2IlInjected.Address(RVA = "0x535E610", Offset = "0x535D810", VA = "0x18535E610", Slot = "71")]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000297")]
		[Cpp2IlInjected.Address(RVA = "0x5359CB0", Offset = "0x5358EB0", VA = "0x185359CB0", Slot = "72")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000BB")]
	public CollisionDetectionMode CIEEKBNHEBL
	{
		[Cpp2IlInjected.Token(Token = "0x60002A0")]
		[Cpp2IlInjected.Address(RVA = "0x5359D10", Offset = "0x5358F10", VA = "0x185359D10", Slot = "73")]
		get
		{
			return default(CollisionDetectionMode);
		}
		[Cpp2IlInjected.Token(Token = "0x60002A1")]
		[Cpp2IlInjected.Address(RVA = "0x535A200", Offset = "0x5359400", VA = "0x18535A200", Slot = "74")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000BC")]
	public bool NFEEOKFPIGD
	{
		[Cpp2IlInjected.Token(Token = "0x60002A3")]
		[Cpp2IlInjected.Address(RVA = "0x535CEF0", Offset = "0x535C0F0", VA = "0x18535CEF0", Slot = "75")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000021")]
	public event JPOFABMOGOF KMPDHKDHBNO
	{
		[Cpp2IlInjected.Token(Token = "0x6000226")]
		[Cpp2IlInjected.Address(RVA = "0x535BB20", Offset = "0x535AD20", VA = "0x18535BB20", Slot = "81")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000227")]
		[Cpp2IlInjected.Address(RVA = "0x535D610", Offset = "0x535C810", VA = "0x18535D610", Slot = "82")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000022")]
	public event JPOFABMOGOF FIBPOODLACB
	{
		[Cpp2IlInjected.Token(Token = "0x6000228")]
		[Cpp2IlInjected.Address(RVA = "0x535EC80", Offset = "0x535DE80", VA = "0x18535EC80", Slot = "83")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000229")]
		[Cpp2IlInjected.Address(RVA = "0x535B0D0", Offset = "0x535A2D0", VA = "0x18535B0D0", Slot = "84")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000023")]
	public event CBNHIOLMAOO LEBPAEACGHM
	{
		[Cpp2IlInjected.Token(Token = "0x600022A")]
		[Cpp2IlInjected.Address(RVA = "0x535D880", Offset = "0x535CA80", VA = "0x18535D880", Slot = "85")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600022B")]
		[Cpp2IlInjected.Address(RVA = "0x535CBE0", Offset = "0x535BDE0", VA = "0x18535CBE0", Slot = "86")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000024")]
	public event JPOFABMOGOF OFDNMEKJKBP
	{
		[Cpp2IlInjected.Token(Token = "0x6000232")]
		[Cpp2IlInjected.Address(RVA = "0x535F450", Offset = "0x535E650", VA = "0x18535F450", Slot = "88")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000233")]
		[Cpp2IlInjected.Address(RVA = "0x535B780", Offset = "0x535A980", VA = "0x18535B780", Slot = "89")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000025")]
	public event JPOFABMOGOF GHPNGDBINKD
	{
		[Cpp2IlInjected.Token(Token = "0x600025C")]
		[Cpp2IlInjected.Address(RVA = "0x535F050", Offset = "0x535E250", VA = "0x18535F050", Slot = "108")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600025D")]
		[Cpp2IlInjected.Address(RVA = "0x535F650", Offset = "0x535E850", VA = "0x18535F650", Slot = "109")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000026")]
	public event JPOFABMOGOF MLDKIENLGJG
	{
		[Cpp2IlInjected.Token(Token = "0x6000271")]
		[Cpp2IlInjected.Address(RVA = "0x535C4A0", Offset = "0x535B6A0", VA = "0x18535C4A0", Slot = "113")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000272")]
		[Cpp2IlInjected.Address(RVA = "0x535AE50", Offset = "0x535A050", VA = "0x18535AE50", Slot = "114")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000027")]
	public event Action<LHLIDFNIOKA, LHLIDFNIOKA> GBMBMPKHBHO
	{
		[Cpp2IlInjected.Token(Token = "0x6000276")]
		[Cpp2IlInjected.Address(RVA = "0x535BAC0", Offset = "0x535ACC0", VA = "0x18535BAC0", Slot = "117")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000277")]
		[Cpp2IlInjected.Address(RVA = "0x535A2B0", Offset = "0x53594B0", VA = "0x18535A2B0", Slot = "118")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000028")]
	public event JPOFABMOGOF KKHOKOPLGIE
	{
		[Cpp2IlInjected.Token(Token = "0x600027A")]
		[Cpp2IlInjected.Address(RVA = "0x535CC40", Offset = "0x535BE40", VA = "0x18535CC40", Slot = "119")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600027B")]
		[Cpp2IlInjected.Address(RVA = "0x5359DA0", Offset = "0x5358FA0", VA = "0x185359DA0", Slot = "120")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000029")]
	public event JPOFABMOGOF FAMCBBOPNHD
	{
		[Cpp2IlInjected.Token(Token = "0x6000281")]
		[Cpp2IlInjected.Address(RVA = "0x535E240", Offset = "0x535D440", VA = "0x18535E240", Slot = "125")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000282")]
		[Cpp2IlInjected.Address(RVA = "0x535EFB0", Offset = "0x535E1B0", VA = "0x18535EFB0", Slot = "126")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600021F")]
	[Cpp2IlInjected.Address(RVA = "0x535FAC0", Offset = "0x535ECC0", VA = "0x18535FAC0")]
	public DGHPEMNHGCH(GameObject OOKBNBHDPPG, RigidbodyEx CFNDHOOGKBI, CMKMIKBKOHM OBOKKBNADPB, in OALOFNDFAEL ONIBEFDCPGD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000220")]
	[Cpp2IlInjected.Address(RVA = "0x535BC70", Offset = "0x535AE70", VA = "0x18535BC70", Slot = "142")]
	protected virtual void FLDAICHOBKG(CMKMIKBKOHM OBOKKBNADPB, OALOFNDFAEL ONIBEFDCPGD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000221")]
	[Cpp2IlInjected.Address(RVA = "0x535B2B0", Offset = "0x535A4B0", VA = "0x18535B2B0", Slot = "143")]
	public virtual void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000222")]
	[Cpp2IlInjected.Address(RVA = "0x535A4D0", Offset = "0x53596D0", VA = "0x18535A4D0", Slot = "76")]
	public void BKOELLNKDDF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000223")]
	[Cpp2IlInjected.Address(RVA = "0x535CDA0", Offset = "0x535BFA0", VA = "0x18535CDA0", Slot = "77")]
	public void IDDPIKDPIIE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000224")]
	[Cpp2IlInjected.Address(RVA = "0x1E6DE10", Offset = "0x1E6D010", VA = "0x181E6DE10", Slot = "78")]
	public void EDIJBNLFNNB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000225")]
	[Cpp2IlInjected.Address(RVA = "0x535C020", Offset = "0x535B220", VA = "0x18535C020", Slot = "144")]
	public virtual void FODBIMBAOBD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000231")]
	[Cpp2IlInjected.Address(RVA = "0x535DD40", Offset = "0x535CF40", VA = "0x18535DD40", Slot = "87")]
	public void KKGLFGKJMPP(PPMDIHPMNCG JFBPNBNBHOE, bool LMKLDOOIJAA = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000248")]
	[Cpp2IlInjected.Address(RVA = "0x535ABC0", Offset = "0x5359DC0", VA = "0x18535ABC0", Slot = "90")]
	public void CGMPABBBBGH(object AJDBKDIMOHA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000249")]
	[Cpp2IlInjected.Address(RVA = "0x5359E00", Offset = "0x5359000", VA = "0x185359E00", Slot = "91")]
	public void AKPJCFEODOB(object AJDBKDIMOHA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600024A")]
	[Cpp2IlInjected.Address(RVA = "0x535B380", Offset = "0x535A580", VA = "0x18535B380", Slot = "92")]
	public Vector3 EAJIEBJEBJP(Vector3 ODPCODBLNJO)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x600024B")]
	[Cpp2IlInjected.Address(RVA = "0x535D670", Offset = "0x535C870", VA = "0x18535D670", Slot = "93")]
	public Vector3 JGGPKLHDPOC(Vector3 DLOMDLEMEJO)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x600024C")]
	[Cpp2IlInjected.Address(RVA = "0x535CDA0", Offset = "0x535BFA0", VA = "0x18535CDA0", Slot = "94")]
	public void LNGHCMNGELC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600024D")]
	[Cpp2IlInjected.Address(RVA = "0x535B190", Offset = "0x535A390", VA = "0x18535B190", Slot = "95")]
	public void DGADOFDPFDE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600024E")]
	[Cpp2IlInjected.Address(RVA = "0x535CCF0", Offset = "0x535BEF0", VA = "0x18535CCF0", Slot = "96")]
	public void IBIENENFOLO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600024F")]
	[Cpp2IlInjected.Address(RVA = "0x535B5B0", Offset = "0x535A7B0", VA = "0x18535B5B0", Slot = "97")]
	public void EEIOJCMLKKL(Vector3 PKEOGDHOABC, Vector3 GNHLNIEHAFA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000250")]
	[Cpp2IlInjected.Address(RVA = "0x535A660", Offset = "0x5359860", VA = "0x18535A660", Slot = "98")]
	public void BNKAMLPDNDH(Vector3 IHHIJIKHHIA, Vector3 NBGIHKDGDID)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000251")]
	[Cpp2IlInjected.Address(RVA = "0x535A800", Offset = "0x5359A00", VA = "0x18535A800", Slot = "99")]
	public void CADMMMANGFL(Vector3 GJKLLEKAGBH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000252")]
	[Cpp2IlInjected.Address(RVA = "0x535C6E0", Offset = "0x535B8E0", VA = "0x18535C6E0", Slot = "100")]
	public void GOHOEPELEBG(CBPMCKPIBHC EIOPEGEMKHP, Vector3 DKCLOLGBADH, float OOKLCGCBAJI, float LLKLELEIBGC = 8f, float AEEFHMKEOAH = 1f)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000253")]
	[Cpp2IlInjected.Address(RVA = "0x535D930", Offset = "0x535CB30", VA = "0x18535D930", Slot = "101")]
	public void JLNINMHMEHA(BOPFIFMMKBG BPDOBLBNKEN, Vector3 NLFAAHHHDNN, float HHHNHCMFNFA = float.PositiveInfinity)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000254")]
	[Cpp2IlInjected.Address(RVA = "0x5359BA0", Offset = "0x5358DA0", VA = "0x185359BA0", Slot = "102")]
	[Obsolete]
	public void ADCBOLCDFHD(BOPFIFMMKBG BPDOBLBNKEN, Vector3 MCFIHGJCDCP, float BDCHAJELIHL = 7f, float ABPPGEHGCFI = 1f)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000255")]
	[Cpp2IlInjected.Address(RVA = "0x535DEE0", Offset = "0x535D0E0", VA = "0x18535DEE0", Slot = "103")]
	public Vector3 KPFDHGBBOFB(Vector3 JFBPNBNBHOE)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000256")]
	[Cpp2IlInjected.Address(RVA = "0x535BB80", Offset = "0x535AD80", VA = "0x18535BB80", Slot = "104")]
	public Vector3 FHKEINJELIE(Vector3 JFBPNBNBHOE)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000257")]
	[Cpp2IlInjected.Address(RVA = "0x535DB00", Offset = "0x535CD00", VA = "0x18535DB00", Slot = "105")]
	public void KDDHFACBKGB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600025A")]
	[Cpp2IlInjected.Address(RVA = "0x535DBA0", Offset = "0x535CDA0", VA = "0x18535DBA0", Slot = "106")]
	public void KFIEFEHILOK(PPMDIHPMNCG FONAKEEEKPK, object AJDBKDIMOHA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600025B")]
	[Cpp2IlInjected.Address(RVA = "0x535EEB0", Offset = "0x535E0B0", VA = "0x18535EEB0", Slot = "107")]
	public void MMHJICPHJHL(object AJDBKDIMOHA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000268")]
	[Cpp2IlInjected.Address(RVA = "0x535F6B0", Offset = "0x535E8B0", VA = "0x18535F6B0", Slot = "110")]
	public void OCCLJJBDHKH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000269")]
	[Cpp2IlInjected.Address(RVA = "0x535E0D0", Offset = "0x535D2D0", VA = "0x18535E0D0", Slot = "111")]
	public void LGMIOPKMACL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600026A")]
	[Cpp2IlInjected.Address(RVA = "0x535F8D0", Offset = "0x535EAD0", VA = "0x18535F8D0", Slot = "112")]
	public void PGLMPJOADGG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000273")]
	[Cpp2IlInjected.Address(RVA = "0x535D8E0", Offset = "0x535CAE0", VA = "0x18535D8E0", Slot = "115")]
	public bool JLGKLAGDNBA()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000274")]
	[Cpp2IlInjected.Address(RVA = "0x535CA70", Offset = "0x535BC70", VA = "0x18535CA70", Slot = "79")]
	public void HFOIEEGNPME()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000275")]
	[Cpp2IlInjected.Address(RVA = "0x535D3F0", Offset = "0x535C5F0", VA = "0x18535D3F0", Slot = "116")]
	public void IPODHJMCCPD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600027D")]
	[Cpp2IlInjected.Address(RVA = "0x535A390", Offset = "0x5359590", VA = "0x18535A390", Slot = "121")]
	public IDisposable BFJJEOKEAOO()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600027E")]
	[Cpp2IlInjected.Address(RVA = "0x535CD40", Offset = "0x535BF40", VA = "0x18535CD40", Slot = "122")]
	public void IDBKKNHMJCA(object AJDBKDIMOHA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600027F")]
	[Cpp2IlInjected.Address(RVA = "0x535A7A0", Offset = "0x53599A0", VA = "0x18535A7A0", Slot = "123")]
	public void BPLEOILKCFF(object AJDBKDIMOHA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000280")]
	[Cpp2IlInjected.Address(RVA = "0x535F4B0", Offset = "0x535E6B0", VA = "0x18535F4B0", Slot = "124")]
	public void NHDILIPFEBO(object AJDBKDIMOHA, bool NMHFDHPJGFL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000291")]
	[Cpp2IlInjected.Address(RVA = "0x5359EF0", Offset = "0x53590F0", VA = "0x185359EF0", Slot = "127")]
	public void BBLLMNKJMFE(Vector3 LDBCCJOIJOF, Quaternion HPGHCBDEGFJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000292")]
	[Cpp2IlInjected.Address(RVA = "0x535E660", Offset = "0x535D860", VA = "0x18535E660", Slot = "128")]
	public void MBJKCDHFBPN(Vector3 JPBAEPJPHFP, Quaternion NHHKEMOEKHO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000293")]
	[Cpp2IlInjected.Address(RVA = "0x535A3E0", Offset = "0x53595E0", VA = "0x18535A3E0", Slot = "129")]
	public bool BHKLDAAMMPP(float LCLMOJDNELD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000298")]
	[Cpp2IlInjected.Address(RVA = "0x535F870", Offset = "0x535EA70", VA = "0x18535F870", Slot = "130")]
	public void PGKAPIBFPCH(object AJDBKDIMOHA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000299")]
	[Cpp2IlInjected.Address(RVA = "0x535B130", Offset = "0x535A330", VA = "0x18535B130", Slot = "131")]
	public void DFLECBDEDLK(object AJDBKDIMOHA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600029A")]
	[Cpp2IlInjected.Address(RVA = "0x535F5F0", Offset = "0x535E7F0", VA = "0x18535F5F0", Slot = "132")]
	public void NMDKIGJCKAP(object AJDBKDIMOHA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600029B")]
	[Cpp2IlInjected.Address(RVA = "0x535D030", Offset = "0x535C230", VA = "0x18535D030", Slot = "133")]
	public void IGIJDOMADBN(object AJDBKDIMOHA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600029C")]
	[Cpp2IlInjected.Address(RVA = "0x535EB40", Offset = "0x535DD40", VA = "0x18535EB40", Slot = "134")]
	public void MDAEENKEECK(Vector3 BIOMHNNIJHG, ForceMode HODPBICIGJM = ForceMode.Force)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600029D")]
	[Cpp2IlInjected.Address(RVA = "0x535E130", Offset = "0x535D330", VA = "0x18535E130", Slot = "135")]
	public void LIGCOMLMAAG(Vector3 BIOMHNNIJHG, Vector3 DACBJNCMNFL, ForceMode HODPBICIGJM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600029E")]
	[Cpp2IlInjected.Address(RVA = "0x535B230", Offset = "0x535A430", VA = "0x18535B230", Slot = "136")]
	public void DPFOGKDMEOC(Vector3 CEBBAPNMMME, ForceMode HODPBICIGJM = ForceMode.Force)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600029F")]
	[Cpp2IlInjected.Address(RVA = "0x535A310", Offset = "0x5359510", VA = "0x18535A310", Slot = "137")]
	public void BFACFHPBMFM(Vector3 CEBBAPNMMME, ForceMode HODPBICIGJM = ForceMode.Force)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002A2")]
	[Cpp2IlInjected.Address(RVA = "0x535AAC0", Offset = "0x5359CC0", VA = "0x18535AAC0", Slot = "138")]
	public bool CGHFGDDABEK(Vector3 HHOIMIMHDMP, out RaycastHit CFGLFCONCKN, float KMAOMDJLDEN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002A4")]
	[Cpp2IlInjected.Address(RVA = "0x535DB50", Offset = "0x535CD50", VA = "0x18535DB50", Slot = "139")]
	public void KEPOLBAFIFI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002A5")]
	[Cpp2IlInjected.Address(RVA = "0x535FA80", Offset = "0x535EC80", VA = "0x18535FA80", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002A6")]
	[Cpp2IlInjected.Address(RVA = "0x535C8D0", Offset = "0x535BAD0", VA = "0x18535C8D0")]
	private void HBHOOKIDFLC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002A7")]
	[Cpp2IlInjected.Address(RVA = "0x535C5D0", Offset = "0x535B7D0", VA = "0x18535C5D0")]
	private void GODMFPJCOIP(PPMDIHPMNCG GPFONCECPBK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002A8")]
	[Cpp2IlInjected.Address(RVA = "0x535C260", Offset = "0x535B460", VA = "0x18535C260")]
	private void GEIPDHMHONB(PPMDIHPMNCG GPFONCECPBK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002A9")]
	[Cpp2IlInjected.Address(RVA = "0x535E020", Offset = "0x535D220", VA = "0x18535E020")]
	private void LCCDGODNNKA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002AA")]
	[Cpp2IlInjected.Address(RVA = "0x535AEB0", Offset = "0x535A0B0", VA = "0x18535AEB0")]
	private void DCFJEDJDJDJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002AB")]
	[Cpp2IlInjected.Address(RVA = "0x535A150", Offset = "0x5359350", VA = "0x18535A150")]
	private void BCMJIIEKDMH(PPMDIHPMNCG KPJMALENPJM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002AC")]
	[Cpp2IlInjected.Address(RVA = "0x535B4D0", Offset = "0x535A6D0", VA = "0x18535B4D0")]
	private void EDMPHFFCDKG(PPMDIHPMNCG GPFONCECPBK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002AD")]
	[Cpp2IlInjected.Address(RVA = "0x535ACD0", Offset = "0x5359ED0", VA = "0x18535ACD0")]
	private void CLFEMCONLMI(PPMDIHPMNCG GPFONCECPBK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002AE")]
	[Cpp2IlInjected.Address(RVA = "0x535ECE0", Offset = "0x535DEE0", VA = "0x18535ECE0")]
	private void MGOLANHOBAG(RigidbodyEx GPFONCECPBK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002AF")]
	[Cpp2IlInjected.Address(RVA = "0x535F0B0", Offset = "0x535E2B0", VA = "0x18535F0B0")]
	private void NGIBBCPNBOA(RigidbodyEx LDDCANHDBNB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002B0")]
	[Cpp2IlInjected.Address(RVA = "0x535C130", Offset = "0x535B330", VA = "0x18535C130")]
	[Conditional("UNITY_EDITOR")]
	private void GBBKFANCPBC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002B1")]
	[Cpp2IlInjected.Address(RVA = "0x535E2E0", Offset = "0x535D4E0", VA = "0x18535E2E0")]
	protected void LJBKGLLIGBJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002B2")]
	[Cpp2IlInjected.Address(RVA = "0x535E810", Offset = "0x535DA10", VA = "0x18535E810")]
	protected void MCFCBPJMHID()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002A")]
internal static class NGJBPFLDFKF
{
	[Cpp2IlInjected.Token(Token = "0x60002B3")]
	[Cpp2IlInjected.Address(RVA = "0x5373E40", Offset = "0x5373040", VA = "0x185373E40")]
	public static PPMDIHPMNCG FHCDDIJMGLI(this PPMDIHPMNCG LDDCANHDBNB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002B4")]
	[Cpp2IlInjected.Address(RVA = "0x5373FD0", Offset = "0x53731D0", VA = "0x185373FD0")]
	public static bool PIOIGPFFMOJ(this PPMDIHPMNCG LDDCANHDBNB, PPMDIHPMNCG BIHOLEKLDHK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002B5")]
	[Cpp2IlInjected.Address(RVA = "0x5373F00", Offset = "0x5373100", VA = "0x185373F00")]
	public static bool GHPPJDKMCLL(this PPMDIHPMNCG LDDCANHDBNB, PPMDIHPMNCG FPKOBEGNFCF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002B6")]
	[Cpp2IlInjected.Address(RVA = "0x5373F80", Offset = "0x5373180", VA = "0x185373F80")]
	public static RigidbodyEx JKIDPKKAFKH(this PPMDIHPMNCG AJDCHLHALFM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002B7")]
	[Cpp2IlInjected.Address(RVA = "0x5373DD0", Offset = "0x5372FD0", VA = "0x185373DD0")]
	public static DGHPEMNHGCH BBKKCEPBGIA(this PPMDIHPMNCG ONJEPBGIHBB)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200002B")]
internal class OHIEJDLAMPD : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000044")]
	private readonly DGHPEMNHGCH LDDCANHDBNB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000045")]
	private bool LKMIDCEHKGL;

	[Cpp2IlInjected.Token(Token = "0x60002B8")]
	[Cpp2IlInjected.Address(RVA = "0x5375E70", Offset = "0x5375070", VA = "0x185375E70")]
	public OHIEJDLAMPD(DGHPEMNHGCH IAJFKOKFPMM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002B9")]
	[Cpp2IlInjected.Address(RVA = "0x5375E10", Offset = "0x5375010", VA = "0x185375E10", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002C")]
internal sealed class AEIOANFBMMA : ABJBDNIKKNI, APGGGIKOMPN
{
	[Cpp2IlInjected.Token(Token = "0x170000BD")]
	private CollisionDetectionMode HEAGEGAAEPE
	{
		[Cpp2IlInjected.Token(Token = "0x60002BB")]
		[Cpp2IlInjected.Address(RVA = "0x534FFF0", Offset = "0x534F1F0", VA = "0x18534FFF0")]
		get
		{
			return default(CollisionDetectionMode);
		}
		[Cpp2IlInjected.Token(Token = "0x60002BC")]
		[Cpp2IlInjected.Address(RVA = "0x534FC60", Offset = "0x534EE60", VA = "0x18534FC60")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000BE")]
	private Rigidbody BAPEKECGLDP
	{
		[Cpp2IlInjected.Token(Token = "0x60002BD")]
		[Cpp2IlInjected.Address(RVA = "0x53500E0", Offset = "0x534F2E0", VA = "0x1853500E0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000BF")]
	public CollisionDetectionMode CIEEKBNHEBL
	{
		[Cpp2IlInjected.Token(Token = "0x60002C0")]
		[Cpp2IlInjected.Address(RVA = "0x534F850", Offset = "0x534EA50", VA = "0x18534F850", Slot = "4")]
		get
		{
			return default(CollisionDetectionMode);
		}
		[Cpp2IlInjected.Token(Token = "0x60002C1")]
		[Cpp2IlInjected.Address(RVA = "0x534F960", Offset = "0x534EB60", VA = "0x18534F960", Slot = "5")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60002BA")]
	[Cpp2IlInjected.Address(RVA = "0x534EA30", Offset = "0x534DC30", VA = "0x18534EA30")]
	public AEIOANFBMMA(PPMDIHPMNCG LDDCANHDBNB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002BE")]
	[Cpp2IlInjected.Address(RVA = "0x534F9E0", Offset = "0x534EBE0", VA = "0x18534F9E0", Slot = "6")]
	public void BKOELLNKDDF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002BF")]
	[Cpp2IlInjected.Address(RVA = "0x534FD60", Offset = "0x534EF60", VA = "0x18534FD60", Slot = "9")]
	public void JPMOLDGLNJO(Rigidbody AOAFHPHKFMD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002C2")]
	[Cpp2IlInjected.Address(RVA = "0x53500D0", Offset = "0x534F2D0", VA = "0x1853500D0", Slot = "7")]
	public void NAIFDEINDCM(bool IOEMIKGMLIB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002C3")]
	[Cpp2IlInjected.Address(RVA = "0x534FD50", Offset = "0x534EF50", VA = "0x18534FD50", Slot = "8")]
	public void HCJANJMAAPB(bool IOEMIKGMLIB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002C4")]
	[Cpp2IlInjected.Address(RVA = "0x534FAF0", Offset = "0x534ECF0", VA = "0x18534FAF0", Slot = "10")]
	public bool CGHFGDDABEK(Vector3 HHOIMIMHDMP, out RaycastHit CFGLFCONCKN, float KMAOMDJLDEN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002C5")]
	[Cpp2IlInjected.Address(RVA = "0x534FDF0", Offset = "0x534EFF0", VA = "0x18534FDF0")]
	private void KAMCMADHFNP(bool IOEMIKGMLIB)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002D")]
internal sealed class PGEBMJCDBGG : ABJBDNIKKNI, ODGCKIECBJN, IDisposable, NLJGMJFEGHJ
{
	[Cpp2IlInjected.Token(Token = "0x170000C0")]
	public PPGNAFCKNOL INFLEOFAPHK
	{
		[Cpp2IlInjected.Token(Token = "0x60002C9")]
		[Cpp2IlInjected.Address(RVA = "0x6409E50", Offset = "0x6409050", VA = "0x186409E50")]
		get
		{
			return default(PPGNAFCKNOL);
		}
		[Cpp2IlInjected.Token(Token = "0x60002CA")]
		[Cpp2IlInjected.Address(RVA = "0x6409AC0", Offset = "0x6408CC0", VA = "0x186409AC0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000C1")]
	public PPGNAFCKNOL NHFAJHMDKMA
	{
		[Cpp2IlInjected.Token(Token = "0x60002CB")]
		[Cpp2IlInjected.Address(RVA = "0x6409C60", Offset = "0x6408E60", VA = "0x186409C60", Slot = "6")]
		get
		{
			return default(PPGNAFCKNOL);
		}
		[Cpp2IlInjected.Token(Token = "0x60002CC")]
		[Cpp2IlInjected.Address(RVA = "0x6409AC0", Offset = "0x6408CC0", VA = "0x186409AC0", Slot = "7")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000C2")]
	private Transform JBPFIGDCPFI
	{
		[Cpp2IlInjected.Token(Token = "0x60002D1")]
		[Cpp2IlInjected.Address(RVA = "0x6CE170", Offset = "0x6CD370", VA = "0x1806CE170", Slot = "10")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400002A")]
	public event Action<LHLIDFNIOKA, LHLIDFNIOKA> GBMBMPKHBHO
	{
		[Cpp2IlInjected.Token(Token = "0x60002C7")]
		[Cpp2IlInjected.Address(RVA = "0x6409BC0", Offset = "0x6408DC0", VA = "0x186409BC0", Slot = "4")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60002C8")]
		[Cpp2IlInjected.Address(RVA = "0x6409A20", Offset = "0x6408C20", VA = "0x186409A20", Slot = "5")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60002C6")]
	[Cpp2IlInjected.Address(RVA = "0x6409F40", Offset = "0x6409140", VA = "0x186409F40")]
	public PGEBMJCDBGG(PPMDIHPMNCG LDDCANHDBNB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002CD")]
	[Cpp2IlInjected.Address(RVA = "0x6409DF0", Offset = "0x6408FF0", VA = "0x186409DF0", Slot = "11")]
	public void OnChangedDistanceBand(LHLIDFNIOKA IAMOONJKNLF, LHLIDFNIOKA AFLEFPKENKF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002CE")]
	[Cpp2IlInjected.Address(RVA = "0x6E0EB0", Offset = "0x6E00B0", VA = "0x1806E0EB0", Slot = "12")]
	public void OnChangedVisibility(bool HFPGMHEIJMF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002CF")]
	[Cpp2IlInjected.Address(RVA = "0x6E0EB0", Offset = "0x6E00B0", VA = "0x1806E0EB0", Slot = "8")]
	public void BKOELLNKDDF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002D0")]
	[Cpp2IlInjected.Address(RVA = "0x6E0EB0", Offset = "0x6E00B0", VA = "0x1806E0EB0", Slot = "9")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002E")]
internal sealed class MIOINHIHDDF : ABJBDNIKKNI, FGHCKEELDLL
{
	[Cpp2IlInjected.Token(Token = "0x170000C3")]
	private Rigidbody BAPEKECGLDP
	{
		[Cpp2IlInjected.Token(Token = "0x60002D3")]
		[Cpp2IlInjected.Address(RVA = "0x53500E0", Offset = "0x534F2E0", VA = "0x1853500E0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000C4")]
	private bool MBEHMAPDJBJ
	{
		[Cpp2IlInjected.Token(Token = "0x60002D4")]
		[Cpp2IlInjected.Address(RVA = "0x5358740", Offset = "0x5357940", VA = "0x185358740")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000C5")]
	private bool DKNFKPAFDPB
	{
		[Cpp2IlInjected.Token(Token = "0x60002D5")]
		[Cpp2IlInjected.Address(RVA = "0x5357480", Offset = "0x5356680", VA = "0x185357480")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000C6")]
	private PPMDIHPMNCG EMIBHNNCMJC
	{
		[Cpp2IlInjected.Token(Token = "0x60002D6")]
		[Cpp2IlInjected.Address(RVA = "0x5373D70", Offset = "0x5372F70", VA = "0x185373D70")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60002D2")]
	[Cpp2IlInjected.Address(RVA = "0x534EA30", Offset = "0x534DC30", VA = "0x18534EA30")]
	public MIOINHIHDDF(PPMDIHPMNCG LDDCANHDBNB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002D7")]
	[Cpp2IlInjected.Address(RVA = "0x5373C10", Offset = "0x5372E10", VA = "0x185373C10", Slot = "4")]
	public void MDAEENKEECK(Vector3 BIOMHNNIJHG, ForceMode HODPBICIGJM = ForceMode.Force)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002D8")]
	[Cpp2IlInjected.Address(RVA = "0x5373310", Offset = "0x5372510", VA = "0x185373310")]
	private void BIAOBHKBAEN(Vector3 BIOMHNNIJHG, ForceMode HODPBICIGJM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002D9")]
	[Cpp2IlInjected.Address(RVA = "0x5373970", Offset = "0x5372B70", VA = "0x185373970", Slot = "5")]
	public void LIGCOMLMAAG(Vector3 BIOMHNNIJHG, Vector3 DACBJNCMNFL, ForceMode HODPBICIGJM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002DA")]
	[Cpp2IlInjected.Address(RVA = "0x5373590", Offset = "0x5372790", VA = "0x185373590", Slot = "6")]
	public void DPFOGKDMEOC(Vector3 CEBBAPNMMME, ForceMode HODPBICIGJM = ForceMode.Force)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002DB")]
	[Cpp2IlInjected.Address(RVA = "0x53736F0", Offset = "0x53728F0", VA = "0x1853736F0")]
	private void KDJCKDGOEKH(Vector3 CEBBAPNMMME, ForceMode HODPBICIGJM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002DC")]
	[Cpp2IlInjected.Address(RVA = "0x5373090", Offset = "0x5372290", VA = "0x185373090", Slot = "7")]
	public void BFACFHPBMFM(Vector3 CEBBAPNMMME, ForceMode HODPBICIGJM = ForceMode.Force)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002F")]
internal sealed class AAMAJGCOMLD : ABJBDNIKKNI, LMMEICEFKMM
{
	[Cpp2IlInjected.Token(Token = "0x170000C7")]
	public bool HLADCICNJBO
	{
		[Cpp2IlInjected.Token(Token = "0x60002DE")]
		[Cpp2IlInjected.Address(RVA = "0x534E670", Offset = "0x534D870", VA = "0x18534E670", Slot = "4")]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x60002DF")]
		[Cpp2IlInjected.Address(RVA = "0x534E750", Offset = "0x534D950", VA = "0x18534E750", Slot = "5")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60002DD")]
	[Cpp2IlInjected.Address(RVA = "0x534EA30", Offset = "0x534DC30", VA = "0x18534EA30")]
	public AAMAJGCOMLD(PPMDIHPMNCG LDDCANHDBNB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002E0")]
	[Cpp2IlInjected.Address(RVA = "0x534E930", Offset = "0x534DB30", VA = "0x18534E930", Slot = "6")]
	public void JPMOLDGLNJO(Rigidbody AOAFHPHKFMD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002E1")]
	[Cpp2IlInjected.Address(RVA = "0x534E600", Offset = "0x534D800", VA = "0x18534E600", Slot = "7")]
	public void AAGPIEFPDDG(Rigidbody AOAFHPHKFMD)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000030")]
internal sealed class LNBCMGCECLM : ABJBDNIKKNI, HMOOAGCGLKM, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x4000050")]
	private readonly OBDJKKFDJOF PLBLCMNMLJO;

	[Cpp2IlInjected.Token(Token = "0x170000C8")]
	private Transform LNPNGFHHEEL
	{
		[Cpp2IlInjected.Token(Token = "0x60002F5")]
		[Cpp2IlInjected.Address(RVA = "0x536CC70", Offset = "0x536BE70", VA = "0x18536CC70")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000C9")]
	public NFJEDPPAJMK JEDNMIFCMOC
	{
		[Cpp2IlInjected.Token(Token = "0x60002F7")]
		[Cpp2IlInjected.Address(RVA = "0x536DDC0", Offset = "0x536CFC0", VA = "0x18536DDC0")]
		get
		{
			return default(NFJEDPPAJMK);
		}
		[Cpp2IlInjected.Token(Token = "0x60002F8")]
		[Cpp2IlInjected.Address(RVA = "0x536EE50", Offset = "0x536E050", VA = "0x18536EE50")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000CA")]
	public PPMDIHPMNCG EMIBHNNCMJC
	{
		[Cpp2IlInjected.Token(Token = "0x60002F9")]
		[Cpp2IlInjected.Address(RVA = "0x536EB60", Offset = "0x536DD60", VA = "0x18536EB60", Slot = "24")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60002FA")]
		[Cpp2IlInjected.Address(RVA = "0x536EDE0", Offset = "0x536DFE0", VA = "0x18536EDE0", Slot = "25")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000CB")]
	public NFJEDPPAJMK DOFKLIOFOPG
	{
		[Cpp2IlInjected.Token(Token = "0x60002FB")]
		[Cpp2IlInjected.Address(RVA = "0x536DEC0", Offset = "0x536D0C0", VA = "0x18536DEC0")]
		get
		{
			return default(NFJEDPPAJMK);
		}
		[Cpp2IlInjected.Token(Token = "0x60002FC")]
		[Cpp2IlInjected.Address(RVA = "0x536E9C0", Offset = "0x536DBC0", VA = "0x18536E9C0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000CC")]
	public PPMDIHPMNCG MDHMHFAIMJJ
	{
		[Cpp2IlInjected.Token(Token = "0x60002FD")]
		[Cpp2IlInjected.Address(RVA = "0x536E200", Offset = "0x536D400", VA = "0x18536E200", Slot = "23")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000CD")]
	public IReadOnlyList<PPMDIHPMNCG> LILCAAEDFCG
	{
		[Cpp2IlInjected.Token(Token = "0x60002FE")]
		[Cpp2IlInjected.Address(RVA = "0x6DD770", Offset = "0x6DC970", VA = "0x1806DD770", Slot = "22")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400002B")]
	public event JPOFABMOGOF KMPDHKDHBNO
	{
		[Cpp2IlInjected.Token(Token = "0x60002E3")]
		[Cpp2IlInjected.Address(RVA = "0x536D370", Offset = "0x536C570", VA = "0x18536D370", Slot = "4")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60002E4")]
		[Cpp2IlInjected.Address(RVA = "0x536E4A0", Offset = "0x536D6A0", VA = "0x18536E4A0", Slot = "5")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400002C")]
	public event JPOFABMOGOF FIBPOODLACB
	{
		[Cpp2IlInjected.Token(Token = "0x60002E5")]
		[Cpp2IlInjected.Address(RVA = "0x536EAC0", Offset = "0x536DCC0", VA = "0x18536EAC0", Slot = "6")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60002E6")]
		[Cpp2IlInjected.Address(RVA = "0x536CFC0", Offset = "0x536C1C0", VA = "0x18536CFC0", Slot = "7")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400002D")]
	public event CBNHIOLMAOO LEBPAEACGHM
	{
		[Cpp2IlInjected.Token(Token = "0x60002E7")]
		[Cpp2IlInjected.Address(RVA = "0x536E5E0", Offset = "0x536D7E0", VA = "0x18536E5E0", Slot = "8")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60002E8")]
		[Cpp2IlInjected.Address(RVA = "0x536E160", Offset = "0x536D360", VA = "0x18536E160", Slot = "9")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400002E")]
	public event Action FJCAMHJDHPJ
	{
		[Cpp2IlInjected.Token(Token = "0x60002E9")]
		[Cpp2IlInjected.Address(RVA = "0x536CCA0", Offset = "0x536BEA0", VA = "0x18536CCA0", Slot = "10")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60002EA")]
		[Cpp2IlInjected.Address(RVA = "0x536CBD0", Offset = "0x536BDD0", VA = "0x18536CBD0", Slot = "11")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400002F")]
	public event Action CJALHGJOGOA
	{
		[Cpp2IlInjected.Token(Token = "0x60002EB")]
		[Cpp2IlInjected.Address(RVA = "0x536F1B0", Offset = "0x536E3B0", VA = "0x18536F1B0", Slot = "12")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60002EC")]
		[Cpp2IlInjected.Address(RVA = "0x536E240", Offset = "0x536D440", VA = "0x18536E240", Slot = "13")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000030")]
	public event Action<PPMDIHPMNCG> JIFKALNNAKN
	{
		[Cpp2IlInjected.Token(Token = "0x60002ED")]
		[Cpp2IlInjected.Address(RVA = "0x536E540", Offset = "0x536D740", VA = "0x18536E540", Slot = "14")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60002EE")]
		[Cpp2IlInjected.Address(RVA = "0x536EF50", Offset = "0x536E150", VA = "0x18536EF50", Slot = "15")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000031")]
	public event Action<PPMDIHPMNCG> DACGCLEDAOG
	{
		[Cpp2IlInjected.Token(Token = "0x60002EF")]
		[Cpp2IlInjected.Address(RVA = "0x536D2D0", Offset = "0x536C4D0", VA = "0x18536D2D0", Slot = "16")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60002F0")]
		[Cpp2IlInjected.Address(RVA = "0x536EBA0", Offset = "0x536DDA0", VA = "0x18536EBA0", Slot = "17")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000032")]
	public event Action HEMJJFHJOBJ
	{
		[Cpp2IlInjected.Token(Token = "0x60002F1")]
		[Cpp2IlInjected.Address(RVA = "0x536CD40", Offset = "0x536BF40", VA = "0x18536CD40", Slot = "18")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60002F2")]
		[Cpp2IlInjected.Address(RVA = "0x536E920", Offset = "0x536DB20", VA = "0x18536E920", Slot = "19")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000033")]
	public event Action<PPMDIHPMNCG> NDOMLKAOIDP
	{
		[Cpp2IlInjected.Token(Token = "0x60002F3")]
		[Cpp2IlInjected.Address(RVA = "0x536ED40", Offset = "0x536DF40", VA = "0x18536ED40", Slot = "20")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60002F4")]
		[Cpp2IlInjected.Address(RVA = "0x536D060", Offset = "0x536C260", VA = "0x18536D060", Slot = "21")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60002E2")]
	[Cpp2IlInjected.Address(RVA = "0x536F250", Offset = "0x536E450", VA = "0x18536F250")]
	public LNBCMGCECLM(PPMDIHPMNCG LDDCANHDBNB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002F6")]
	[Cpp2IlInjected.Address(RVA = "0x536D100", Offset = "0x536C300", VA = "0x18536D100", Slot = "27")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002FF")]
	[Cpp2IlInjected.Address(RVA = "0x536E6F0", Offset = "0x536D8F0", VA = "0x18536E6F0", Slot = "26")]
	public void KKGLFGKJMPP(PPMDIHPMNCG DPPABCPODHG, bool LMKLDOOIJAA = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000300")]
	[Cpp2IlInjected.Address(RVA = "0x536E680", Offset = "0x536D880", VA = "0x18536E680")]
	private void KKGLFGKJMPP(LKOIEBFOHCO DPPABCPODHG, bool LMKLDOOIJAA = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000301")]
	[Cpp2IlInjected.Address(RVA = "0x536D540", Offset = "0x536C740", VA = "0x18536D540")]
	private void FNMCIHFPIAM(LKOIEBFOHCO DPPABCPODHG, bool LMKLDOOIJAA = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000302")]
	[Cpp2IlInjected.Address(RVA = "0x536EFF0", Offset = "0x536E1F0", VA = "0x18536EFF0")]
	private void PLMMLEJPFJC(LKOIEBFOHCO KPJMALENPJM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000303")]
	[Cpp2IlInjected.Address(RVA = "0x536E2E0", Offset = "0x536D4E0", VA = "0x18536E2E0")]
	private void IBABMBDNBHE(LKOIEBFOHCO KPJMALENPJM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000304")]
	[Cpp2IlInjected.Address(RVA = "0x536DFC0", Offset = "0x536D1C0", VA = "0x18536DFC0")]
	private void HFLEBMEBODA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000305")]
	[Cpp2IlInjected.Address(RVA = "0x536E770", Offset = "0x536D970", VA = "0x18536E770")]
	private void KLFLFGBKAAA(LKOIEBFOHCO KPJMALENPJM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000306")]
	[Cpp2IlInjected.Address(RVA = "0x536CF10", Offset = "0x536C110", VA = "0x18536CF10")]
	private void COMAAFBCCFI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000307")]
	[Cpp2IlInjected.Address(RVA = "0x536CDE0", Offset = "0x536BFE0", VA = "0x18536CDE0")]
	private void CMMLKAPMCHH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000308")]
	[Cpp2IlInjected.Address(RVA = "0x536D410", Offset = "0x536C610", VA = "0x18536D410")]
	private void FIMHIJJNHNG(LKOIEBFOHCO LDDCANHDBNB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000309")]
	[Cpp2IlInjected.Address(RVA = "0x536E7F0", Offset = "0x536D9F0", VA = "0x18536E7F0")]
	private void LNGINODJAIF(LKOIEBFOHCO LDDCANHDBNB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600030A")]
	[Cpp2IlInjected.Address(RVA = "0x536EC40", Offset = "0x536DE40", VA = "0x18536EC40")]
	[CompilerGenerated]
	private object NBAEBBOFGBJ()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000031")]
internal static class HJANCICDJND
{
	[Cpp2IlInjected.Token(Token = "0x600030B")]
	[Cpp2IlInjected.Address(RVA = "0x5367720", Offset = "0x5366920", VA = "0x185367720")]
	public static LNBCMGCECLM NCKPBBOBINB(this PPMDIHPMNCG ONJEPBGIHBB)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000032")]
internal sealed class ADKNLKJCAMG : ABJBDNIKKNI, NPFLLLAFPDM
{
	[Cpp2IlInjected.Token(Token = "0x170000CE")]
	public Vector3 DJHICJGOGJI
	{
		[Cpp2IlInjected.Token(Token = "0x600030D")]
		[Cpp2IlInjected.Address(RVA = "0x534EFA0", Offset = "0x534E1A0", VA = "0x18534EFA0", Slot = "4")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000CF")]
	public Vector3 EOFHLAGNPII
	{
		[Cpp2IlInjected.Token(Token = "0x600030E")]
		[Cpp2IlInjected.Address(RVA = "0x534F4B0", Offset = "0x534E6B0", VA = "0x18534F4B0", Slot = "5")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000D0")]
	private Vector3 MHCLHNEGJDD
	{
		[Cpp2IlInjected.Token(Token = "0x6000312")]
		[Cpp2IlInjected.Address(RVA = "0x534EC00", Offset = "0x534DE00", VA = "0x18534EC00")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000D1")]
	private PPMDIHPMNCG MMCLEEKFDKC
	{
		[Cpp2IlInjected.Token(Token = "0x6000313")]
		[Cpp2IlInjected.Address(RVA = "0x534F6F0", Offset = "0x534E8F0", VA = "0x18534F6F0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600030C")]
	[Cpp2IlInjected.Address(RVA = "0x534EA30", Offset = "0x534DC30", VA = "0x18534EA30")]
	public ADKNLKJCAMG(PPMDIHPMNCG LDDCANHDBNB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600030F")]
	[Cpp2IlInjected.Address(RVA = "0x534EE10", Offset = "0x534E010", VA = "0x18534EE10", Slot = "6")]
	public void CNAAFOJMHNK(PPMDIHPMNCG GPFONCECPBK, object AJDBKDIMOHA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000310")]
	[Cpp2IlInjected.Address(RVA = "0x534ECE0", Offset = "0x534DEE0", VA = "0x18534ECE0")]
	private void CNAAFOJMHNK(LKOIEBFOHCO GPFONCECPBK, object AJDBKDIMOHA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000311")]
	[Cpp2IlInjected.Address(RVA = "0x534EFD0", Offset = "0x534E1D0", VA = "0x18534EFD0", Slot = "7")]
	public void JOEIIPCOBII(object AJDBKDIMOHA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000314")]
	[Cpp2IlInjected.Address(RVA = "0x534F0C0", Offset = "0x534E2C0", VA = "0x18534F0C0")]
	private Vector3 MIDPCEDMHPH()
	{
		return default(Vector3);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000033")]
internal static class KELBFOGLOFF
{
	[Cpp2IlInjected.Token(Token = "0x6000315")]
	[Cpp2IlInjected.Address(RVA = "0x536B9E0", Offset = "0x536ABE0", VA = "0x18536B9E0")]
	public static ADKNLKJCAMG BKCOHJDHGKA(this PPMDIHPMNCG ONJEPBGIHBB)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000034")]
internal sealed class MGGEKCMKNIA : ABJBDNIKKNI, HEFJBMMENIM
{
	[Cpp2IlInjected.Token(Token = "0x170000D2")]
	public Vector3 JMIIJDMAMEI
	{
		[Cpp2IlInjected.Token(Token = "0x6000319")]
		[Cpp2IlInjected.Address(RVA = "0x5370560", Offset = "0x536F760", VA = "0x185370560", Slot = "6")]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x600031A")]
		[Cpp2IlInjected.Address(RVA = "0x5370270", Offset = "0x536F470", VA = "0x185370270", Slot = "7")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000D3")]
	public Vector3 PMKFGPJNJBI
	{
		[Cpp2IlInjected.Token(Token = "0x600031B")]
		[Cpp2IlInjected.Address(RVA = "0x536FC90", Offset = "0x536EE90", VA = "0x18536FC90", Slot = "8")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000D4")]
	public float KLNDCEHFMBA
	{
		[Cpp2IlInjected.Token(Token = "0x600031C")]
		[Cpp2IlInjected.Address(RVA = "0x5370450", Offset = "0x536F650", VA = "0x185370450", Slot = "9")]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x600031D")]
		[Cpp2IlInjected.Address(RVA = "0x5370550", Offset = "0x536F750", VA = "0x185370550")]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000D5")]
	public float NBJLLACMBLF
	{
		[Cpp2IlInjected.Token(Token = "0x600031E")]
		[Cpp2IlInjected.Address(RVA = "0x5370690", Offset = "0x536F890", VA = "0x185370690", Slot = "10")]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x600031F")]
		[Cpp2IlInjected.Address(RVA = "0x5371C90", Offset = "0x5370E90", VA = "0x185371C90", Slot = "11")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000D6")]
	public Vector3 OFFHJCCLOEB
	{
		[Cpp2IlInjected.Token(Token = "0x6000320")]
		[Cpp2IlInjected.Address(RVA = "0x536FFB0", Offset = "0x536F1B0", VA = "0x18536FFB0", Slot = "12")]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x6000321")]
		[Cpp2IlInjected.Address(RVA = "0x5370240", Offset = "0x536F440", VA = "0x185370240", Slot = "13")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000D7")]
	public Quaternion MOMBOPJMDMK
	{
		[Cpp2IlInjected.Token(Token = "0x6000322")]
		[Cpp2IlInjected.Address(RVA = "0x536FF80", Offset = "0x536F180", VA = "0x18536FF80", Slot = "14")]
		get
		{
			return default(Quaternion);
		}
		[Cpp2IlInjected.Token(Token = "0x6000323")]
		[Cpp2IlInjected.Address(RVA = "0x5370530", Offset = "0x536F730", VA = "0x185370530", Slot = "15")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000D8")]
	private Rigidbody BAPEKECGLDP
	{
		[Cpp2IlInjected.Token(Token = "0x600032B")]
		[Cpp2IlInjected.Address(RVA = "0x53500E0", Offset = "0x534F2E0", VA = "0x1853500E0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000034")]
	public event JPOFABMOGOF GOMGJPJMHIM
	{
		[Cpp2IlInjected.Token(Token = "0x6000316")]
		[Cpp2IlInjected.Address(RVA = "0x536FFE0", Offset = "0x536F1E0", VA = "0x18536FFE0", Slot = "4")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000317")]
		[Cpp2IlInjected.Address(RVA = "0x53703B0", Offset = "0x536F5B0", VA = "0x1853703B0", Slot = "5")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000318")]
	[Cpp2IlInjected.Address(RVA = "0x5372DD0", Offset = "0x5371FD0", VA = "0x185372DD0")]
	public MGGEKCMKNIA(PPMDIHPMNCG LDDCANHDBNB, in OALOFNDFAEL ONIBEFDCPGD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000324")]
	[Cpp2IlInjected.Address(RVA = "0x5371A80", Offset = "0x5370C80", VA = "0x185371A80", Slot = "17")]
	public void OCCLJJBDHKH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000325")]
	[Cpp2IlInjected.Address(RVA = "0x53712C0", Offset = "0x53704C0", VA = "0x1853712C0", Slot = "16")]
	public void LGMIOPKMACL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000326")]
	[Cpp2IlInjected.Address(RVA = "0x53709A0", Offset = "0x536FBA0", VA = "0x1853709A0", Slot = "19")]
	public void JPMOLDGLNJO(Rigidbody AOAFHPHKFMD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000327")]
	[Cpp2IlInjected.Address(RVA = "0x536F7F0", Offset = "0x536E9F0", VA = "0x18536F7F0", Slot = "20")]
	public void AAGPIEFPDDG(Rigidbody AOAFHPHKFMD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000328")]
	[Cpp2IlInjected.Address(RVA = "0x5371CA0", Offset = "0x5370EA0", VA = "0x185371CA0", Slot = "18")]
	public void PGLMPJOADGG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000329")]
	[Cpp2IlInjected.Address(RVA = "0x5370BC0", Offset = "0x536FDC0", VA = "0x185370BC0", Slot = "21")]
	public void KEPOLBAFIFI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600032A")]
	[Cpp2IlInjected.Address(RVA = "0x5356330", Offset = "0x5355530", VA = "0x185356330")]
	public void LHPJDEELCAK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600032C")]
	[Cpp2IlInjected.Address(RVA = "0x5370270", Offset = "0x536F470", VA = "0x185370270")]
	private void HBJMIFMDHJH(Vector3 JFBPNBNBHOE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600032D")]
	[Cpp2IlInjected.Address(RVA = "0x536FB70", Offset = "0x536ED70", VA = "0x18536FB70")]
	private Vector3 BCKCCAMLFFB()
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x600032E")]
	[Cpp2IlInjected.Address(RVA = "0x536FDB0", Offset = "0x536EFB0", VA = "0x18536FDB0")]
	private void CGGJFFODFCK(float JFBPNBNBHOE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600032F")]
	[Cpp2IlInjected.Address(RVA = "0x5370080", Offset = "0x536F280", VA = "0x185370080")]
	private void FPOBCCILBBI(float JFBPNBNBHOE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000330")]
	[Cpp2IlInjected.Address(RVA = "0x5371640", Offset = "0x5370840", VA = "0x185371640")]
	private Vector3 LIHAPOLOMJO()
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000331")]
	[Cpp2IlInjected.Address(RVA = "0x5370770", Offset = "0x536F970", VA = "0x185370770")]
	private void IPFFPNBFENN(Vector3 JFBPNBNBHOE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000332")]
	[Cpp2IlInjected.Address(RVA = "0x5371870", Offset = "0x5370A70", VA = "0x185371870")]
	private Quaternion MFJCLLLJOKO()
	{
		return default(Quaternion);
	}

	[Cpp2IlInjected.Token(Token = "0x6000333")]
	[Cpp2IlInjected.Address(RVA = "0x53710B0", Offset = "0x53702B0", VA = "0x1853710B0")]
	private void KKICMMPIOEM(Quaternion JFBPNBNBHOE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000334")]
	[Cpp2IlInjected.Address(RVA = "0x5371D80", Offset = "0x5370F80", VA = "0x185371D80")]
	internal (float, Vector3) PJKJFLIKEBB(Rigidbody MJNKCPJACPF)
	{
		return default((float, Vector3));
	}
}
[Cpp2IlInjected.Token(Token = "0x2000035")]
internal static class FCOOIHCEFMG
{
	[Cpp2IlInjected.Token(Token = "0x6000335")]
	[Cpp2IlInjected.Address(RVA = "0x53658C0", Offset = "0x5364AC0", VA = "0x1853658C0")]
	public static MGGEKCMKNIA NDHEADMHLHM(this PPMDIHPMNCG ONJEPBGIHBB)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000036")]
internal sealed class NNDBLHLNAOB : ABJBDNIKKNI, EBCDLOKEBCP
{
	[Cpp2IlInjected.Token(Token = "0x4000052")]
	private const string EMNENHPAIJN = "INTERP_PAUSE";

	[Cpp2IlInjected.Token(Token = "0x170000D9")]
	public bool FKLEIIKAOJF
	{
		[Cpp2IlInjected.Token(Token = "0x6000336")]
		[Cpp2IlInjected.Address(RVA = "0x5375300", Offset = "0x5374500", VA = "0x185375300", Slot = "4")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000DA")]
	public GDPCJHNBEPD MDBJGCBLKKA
	{
		[Cpp2IlInjected.Token(Token = "0x6000337")]
		[Cpp2IlInjected.Address(RVA = "0x5375200", Offset = "0x5374400", VA = "0x185375200", Slot = "5")]
		get
		{
			return default(GDPCJHNBEPD);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000DB")]
	private GDPCJHNBEPD AKFNPMCICJM
	{
		[Cpp2IlInjected.Token(Token = "0x6000339")]
		[Cpp2IlInjected.Address(RVA = "0x5374E80", Offset = "0x5374080", VA = "0x185374E80")]
		get
		{
			return default(GDPCJHNBEPD);
		}
		[Cpp2IlInjected.Token(Token = "0x600033A")]
		[Cpp2IlInjected.Address(RVA = "0x5375110", Offset = "0x5374310", VA = "0x185375110")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000338")]
	[Cpp2IlInjected.Address(RVA = "0x5375770", Offset = "0x5374970", VA = "0x185375770")]
	public NNDBLHLNAOB(PPMDIHPMNCG LDDCANHDBNB, in OALOFNDFAEL ONIBEFDCPGD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600033B")]
	[Cpp2IlInjected.Address(RVA = "0x5374DC0", Offset = "0x5373FC0", VA = "0x185374DC0", Slot = "6")]
	public void BKOELLNKDDF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600033C")]
	[Cpp2IlInjected.Address(RVA = "0x5374F60", Offset = "0x5374160", VA = "0x185374F60")]
	private bool EIPAKAFJFHC()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600033D")]
	[Cpp2IlInjected.Address(RVA = "0x5375530", Offset = "0x5374730", VA = "0x185375530", Slot = "7")]
	public void MPHPJCHHDKL(object AJDBKDIMOHA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600033E")]
	[Cpp2IlInjected.Address(RVA = "0x5375630", Offset = "0x5374830", VA = "0x185375630", Slot = "8")]
	public void NEGAEOLBLHL(object AJDBKDIMOHA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600033F")]
	[Cpp2IlInjected.Address(RVA = "0x5375000", Offset = "0x5374200", VA = "0x185375000", Slot = "11")]
	public void HIJAJPCLBLB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000340")]
	[Cpp2IlInjected.Address(RVA = "0x5375210", Offset = "0x5374410", VA = "0x185375210")]
	private void KDHHGDDDAKA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000341")]
	[Cpp2IlInjected.Address(RVA = "0x53753E0", Offset = "0x53745E0", VA = "0x1853753E0")]
	private void MCILODDNPMG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000342")]
	[Cpp2IlInjected.Address(RVA = "0x5375730", Offset = "0x5374930", VA = "0x185375730", Slot = "10")]
	public void ONIPMDLLNFC(PPMDIHPMNCG LDDCANHDBNB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000343")]
	[Cpp2IlInjected.Address(RVA = "0x5374D80", Offset = "0x5373F80", VA = "0x185374D80", Slot = "9")]
	public void BKKMBNFHKCE(PPMDIHPMNCG LDDCANHDBNB)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000037")]
internal sealed class AHIKCLCKAFC : ABJBDNIKKNI, GAMBABDLKNB
{
	[Cpp2IlInjected.Token(Token = "0x170000DC")]
	public bool MBEHMAPDJBJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000346")]
		[Cpp2IlInjected.Address(RVA = "0x5353D50", Offset = "0x5352F50", VA = "0x185353D50", Slot = "6")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000DD")]
	public IEnumerable<object> EKIDKKGDMDH
	{
		[Cpp2IlInjected.Token(Token = "0x6000347")]
		[Cpp2IlInjected.Address(RVA = "0x5353F30", Offset = "0x5353130", VA = "0x185353F30", Slot = "7")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000DE")]
	private bool HADPPGCCBPA
	{
		[Cpp2IlInjected.Token(Token = "0x6000348")]
		[Cpp2IlInjected.Address(RVA = "0x5353B60", Offset = "0x5352D60", VA = "0x185353B60")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000035")]
	public event JPOFABMOGOF JDAOGMBMFNA
	{
		[Cpp2IlInjected.Token(Token = "0x6000344")]
		[Cpp2IlInjected.Address(RVA = "0x5353E10", Offset = "0x5353010", VA = "0x185353E10", Slot = "4")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000345")]
		[Cpp2IlInjected.Address(RVA = "0x5353CA0", Offset = "0x5352EA0", VA = "0x185353CA0", Slot = "5")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000349")]
	[Cpp2IlInjected.Address(RVA = "0x534EA30", Offset = "0x534DC30", VA = "0x18534EA30")]
	public AHIKCLCKAFC(PPMDIHPMNCG LDDCANHDBNB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600034A")]
	[Cpp2IlInjected.Address(RVA = "0x5353C40", Offset = "0x5352E40", VA = "0x185353C40", Slot = "11")]
	public IDisposable BFJJEOKEAOO()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600034B")]
	[Cpp2IlInjected.Address(RVA = "0x5353EB0", Offset = "0x53530B0", VA = "0x185353EB0", Slot = "8")]
	public void IDBKKNHMJCA(object AJDBKDIMOHA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600034C")]
	[Cpp2IlInjected.Address(RVA = "0x5353D40", Offset = "0x5352F40", VA = "0x185353D40", Slot = "9")]
	public void BPLEOILKCFF(object AJDBKDIMOHA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600034D")]
	[Cpp2IlInjected.Address(RVA = "0x5354010", Offset = "0x5353210", VA = "0x185354010", Slot = "10")]
	public void NHDILIPFEBO(object AJDBKDIMOHA, bool NMHFDHPJGFL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600034E")]
	[Cpp2IlInjected.Address(RVA = "0x5353EC0", Offset = "0x53530C0", VA = "0x185353EC0", Slot = "12")]
	public void JPMOLDGLNJO(Rigidbody IHFIBCKLILB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600034F")]
	[Cpp2IlInjected.Address(RVA = "0x5353B30", Offset = "0x5352D30", VA = "0x185353B30", Slot = "13")]
	public void AAGPIEFPDDG(Rigidbody AOAFHPHKFMD)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000038")]
internal sealed class EKPLBPEKBHJ : ABJBDNIKKNI, LNJFNCEGNCA, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000055")]
	private PhotonView CAIDBGJNFEP;

	[Cpp2IlInjected.Token(Token = "0x170000DF")]
	public bool PJPIAHDKHLD
	{
		[Cpp2IlInjected.Token(Token = "0x6000352")]
		[Cpp2IlInjected.Address(RVA = "0x5360C10", Offset = "0x535FE10", VA = "0x185360C10", Slot = "6")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000E0")]
	public bool EMGPBBGPGIE
	{
		[Cpp2IlInjected.Token(Token = "0x6000353")]
		[Cpp2IlInjected.Address(RVA = "0x53608F0", Offset = "0x535FAF0", VA = "0x1853608F0", Slot = "7")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000036")]
	public event JPOFABMOGOF OFDNMEKJKBP
	{
		[Cpp2IlInjected.Token(Token = "0x6000350")]
		[Cpp2IlInjected.Address(RVA = "0x53615F0", Offset = "0x53607F0", VA = "0x1853615F0", Slot = "4")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000351")]
		[Cpp2IlInjected.Address(RVA = "0x5361200", Offset = "0x5360400", VA = "0x185361200", Slot = "5")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000354")]
	[Cpp2IlInjected.Address(RVA = "0x5361690", Offset = "0x5360890", VA = "0x185361690")]
	public EKPLBPEKBHJ(PPMDIHPMNCG LDDCANHDBNB, in OALOFNDFAEL ONIBEFDCPGD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000355")]
	[Cpp2IlInjected.Address(RVA = "0x53607A0", Offset = "0x535F9A0", VA = "0x1853607A0", Slot = "8")]
	public void BKOELLNKDDF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000356")]
	[Cpp2IlInjected.Address(RVA = "0x5360C30", Offset = "0x535FE30", VA = "0x185360C30", Slot = "11")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000357")]
	[Cpp2IlInjected.Address(RVA = "0x5360FF0", Offset = "0x53601F0", VA = "0x185360FF0", Slot = "9")]
	public void EDMPHFFCDKG(PPMDIHPMNCG GPFONCECPBK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000358")]
	[Cpp2IlInjected.Address(RVA = "0x5360A00", Offset = "0x535FC00", VA = "0x185360A00", Slot = "10")]
	public void CLFEMCONLMI(PPMDIHPMNCG GPFONCECPBK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000359")]
	[Cpp2IlInjected.Address(RVA = "0x5361400", Offset = "0x5360600", VA = "0x185361400")]
	private void JIANJEKONCC(PhotonView MBHHONACMIO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600035A")]
	[Cpp2IlInjected.Address(RVA = "0x53612A0", Offset = "0x53604A0", VA = "0x1853612A0")]
	private void IEJGPNIHMFH(RigidbodyEx KEPNDNMPIMB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600035B")]
	[Cpp2IlInjected.Address(RVA = "0x5360E20", Offset = "0x5360020", VA = "0x185360E20")]
	private void EDLABONOLPP(PhotonView PEDIMHHLKDL)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000039")]
internal static class KJILMACANBH
{
	[Cpp2IlInjected.Token(Token = "0x600035C")]
	[Cpp2IlInjected.Address(RVA = "0x536BA70", Offset = "0x536AC70", VA = "0x18536BA70")]
	public static EKPLBPEKBHJ NBAAFMOGNIN(this DGHPEMNHGCH ONJEPBGIHBB)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200003A")]
internal sealed class IIGDJLFMGDO : ABJBDNIKKNI, OIAJBEDDNGM
{
	[Cpp2IlInjected.Token(Token = "0x170000E1")]
	public bool PJGCDNLPGAK
	{
		[Cpp2IlInjected.Token(Token = "0x600035D")]
		[Cpp2IlInjected.Address(RVA = "0x5368940", Offset = "0x5367B40", VA = "0x185368940", Slot = "4")]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x600035E")]
		[Cpp2IlInjected.Address(RVA = "0x5368580", Offset = "0x5367780", VA = "0x185368580", Slot = "5")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000E2")]
	public bool AGHKJBONNGE
	{
		[Cpp2IlInjected.Token(Token = "0x600035F")]
		[Cpp2IlInjected.Address(RVA = "0x5368A20", Offset = "0x5367C20", VA = "0x185368A20", Slot = "6")]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000360")]
		[Cpp2IlInjected.Address(RVA = "0x5368750", Offset = "0x5367950", VA = "0x185368750")]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000E3")]
	public RigidbodyConstraints BCMJAHAELOH
	{
		[Cpp2IlInjected.Token(Token = "0x6000361")]
		[Cpp2IlInjected.Address(RVA = "0x5368670", Offset = "0x5367870", VA = "0x185368670", Slot = "7")]
		get
		{
			return default(RigidbodyConstraints);
		}
		[Cpp2IlInjected.Token(Token = "0x6000362")]
		[Cpp2IlInjected.Address(RVA = "0x5368B00", Offset = "0x5367D00", VA = "0x185368B00", Slot = "8")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000363")]
	[Cpp2IlInjected.Address(RVA = "0x5368D00", Offset = "0x5367F00", VA = "0x185368D00")]
	public IIGDJLFMGDO(PPMDIHPMNCG LDDCANHDBNB, in OALOFNDFAEL ONIBEFDCPGD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000364")]
	[Cpp2IlInjected.Address(RVA = "0x5368840", Offset = "0x5367A40", VA = "0x185368840", Slot = "9")]
	public void JPMOLDGLNJO(Rigidbody AOAFHPHKFMD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000365")]
	[Cpp2IlInjected.Address(RVA = "0x5368480", Offset = "0x5367680", VA = "0x185368480", Slot = "10")]
	public void AAGPIEFPDDG(Rigidbody AOAFHPHKFMD)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200003B")]
internal sealed class LHHKJMBGNNK : ABJBDNIKKNI, KKCAAHMNCAO
{
	[Cpp2IlInjected.Token(Token = "0x170000E4")]
	public float FCGOFCPMIGL
	{
		[Cpp2IlInjected.Token(Token = "0x6000367")]
		[Cpp2IlInjected.Address(RVA = "0x536BC60", Offset = "0x536AE60", VA = "0x18536BC60", Slot = "4")]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x6000368")]
		[Cpp2IlInjected.Address(RVA = "0x536BF10", Offset = "0x536B110", VA = "0x18536BF10", Slot = "5")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000E5")]
	public float CFMIJLIHCIE
	{
		[Cpp2IlInjected.Token(Token = "0x6000369")]
		[Cpp2IlInjected.Address(RVA = "0x536C2B0", Offset = "0x536B4B0", VA = "0x18536C2B0", Slot = "6")]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x600036A")]
		[Cpp2IlInjected.Address(RVA = "0x536C0E0", Offset = "0x536B2E0", VA = "0x18536C0E0", Slot = "7")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000366")]
	[Cpp2IlInjected.Address(RVA = "0x534EA30", Offset = "0x534DC30", VA = "0x18534EA30")]
	public LHHKJMBGNNK(PPMDIHPMNCG LDDCANHDBNB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600036B")]
	[Cpp2IlInjected.Address(RVA = "0x536BD40", Offset = "0x536AF40", VA = "0x18536BD40", Slot = "8")]
	public void JPMOLDGLNJO(Rigidbody AOAFHPHKFMD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600036C")]
	[Cpp2IlInjected.Address(RVA = "0x536BB90", Offset = "0x536AD90", VA = "0x18536BB90", Slot = "9")]
	public void AAGPIEFPDDG(Rigidbody AOAFHPHKFMD)
	{
	}
}
namespace RecRoom.Rbex.ObjectModel
{
	[Cpp2IlInjected.Token(Token = "0x200003C")]
	[LOJIIDJFKAI(typeof(NNABLGDOJFG), new string[] { })]
	[MBALNPKLAGP(FOFKCKDBIPD.Physics)]
	public sealed class RbexServiceCallbacks : DPDCPMNGBKH, NNABLGDOJFG, IDisposable
	{
		[Cpp2IlInjected.Token(Token = "0x4000056")]
		private static readonly FADHLPPNOEF ICGADBEDOKK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000057")]
		private MCAEHJPOCLP LDDCANHDBNB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000058")]
		private bool LKMIDCEHKGL;

		[Cpp2IlInjected.Token(Token = "0x170000E6")]
		public bool ACLLOIKFPLE
		{
			[Cpp2IlInjected.Token(Token = "0x600036F")]
			[Cpp2IlInjected.Address(RVA = "0x6E18D0", Offset = "0x6E0AD0", VA = "0x1806E18D0", Slot = "5")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600036D")]
		[Cpp2IlInjected.Address(RVA = "0x640A120", Offset = "0x6409320", VA = "0x18640A120", Slot = "4")]
		public void PEIMLKLDOFJ(JHLNNPKIFCO KOKEGENGCAH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600036E")]
		[Cpp2IlInjected.Address(RVA = "0x640A0F0", Offset = "0x64092F0", VA = "0x18640A0F0", Slot = "7")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000370")]
		[Cpp2IlInjected.Address(RVA = "0x640A170", Offset = "0x6409370", VA = "0x18640A170", Slot = "6")]
		public void PJKJFLIKEBB(NFJEDPPAJMK OOGHONKGHEE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000371")]
		[Cpp2IlInjected.Address(RVA = "0x6C8B30", Offset = "0x6C7D30", VA = "0x1806C8B30")]
		public RbexServiceCallbacks()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200003D")]
internal sealed class AMOJDPPGPLO : ABJBDNIKKNI, BBGIBEMMCOA
{
	[Cpp2IlInjected.Token(Token = "0x4000059")]
	public const int GKPFGIIGOEG = 10;

	[Cpp2IlInjected.Token(Token = "0x400005A")]
	public const float AAMHOIOCMGO = 9E-05f;

	[Cpp2IlInjected.Token(Token = "0x400005B")]
	public const float CLBDJGNMOIE = 0.0001f;

	[Cpp2IlInjected.Token(Token = "0x400005C")]
	public const float FBHPIPCOGEF = 5f;

	[Cpp2IlInjected.Token(Token = "0x170000E7")]
	private Rigidbody BAPEKECGLDP
	{
		[Cpp2IlInjected.Token(Token = "0x6000375")]
		[Cpp2IlInjected.Address(RVA = "0x53500E0", Offset = "0x534F2E0", VA = "0x1853500E0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000E8")]
	private bool HCMEHANPHNC
	{
		[Cpp2IlInjected.Token(Token = "0x6000376")]
		[Cpp2IlInjected.Address(RVA = "0x5355F80", Offset = "0x5355180", VA = "0x185355F80")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000E9")]
	private bool NFEEOKFPIGD
	{
		[Cpp2IlInjected.Token(Token = "0x6000377")]
		[Cpp2IlInjected.Address(RVA = "0x5352680", Offset = "0x5351880", VA = "0x185352680")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000EA")]
	private PPMDIHPMNCG EMIBHNNCMJC
	{
		[Cpp2IlInjected.Token(Token = "0x6000378")]
		[Cpp2IlInjected.Address(RVA = "0x53569C0", Offset = "0x5355BC0", VA = "0x1853569C0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000EB")]
	private bool DKNFKPAFDPB
	{
		[Cpp2IlInjected.Token(Token = "0x6000379")]
		[Cpp2IlInjected.Address(RVA = "0x5356020", Offset = "0x5355220", VA = "0x185356020")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000EC")]
	private bool AOFOBFIMBNI
	{
		[Cpp2IlInjected.Token(Token = "0x600037A")]
		[Cpp2IlInjected.Address(RVA = "0x53568E0", Offset = "0x5355AE0", VA = "0x1853568E0")]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x600037B")]
		[Cpp2IlInjected.Address(RVA = "0x5355C40", Offset = "0x5354E40", VA = "0x185355C40")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000ED")]
	private bool KFFHFJIBMOK
	{
		[Cpp2IlInjected.Token(Token = "0x600037C")]
		[Cpp2IlInjected.Address(RVA = "0x5356080", Offset = "0x5355280", VA = "0x185356080")]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x600037D")]
		[Cpp2IlInjected.Address(RVA = "0x5356A20", Offset = "0x5355C20", VA = "0x185356A20")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000EE")]
	private int CGFCAIAMLJN
	{
		[Cpp2IlInjected.Token(Token = "0x600037E")]
		[Cpp2IlInjected.Address(RVA = "0x5356160", Offset = "0x5355360", VA = "0x185356160")]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x600037F")]
		[Cpp2IlInjected.Address(RVA = "0x5356240", Offset = "0x5355440", VA = "0x185356240")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000037")]
	public event JPOFABMOGOF MLDKIENLGJG
	{
		[Cpp2IlInjected.Token(Token = "0x6000373")]
		[Cpp2IlInjected.Address(RVA = "0x5356370", Offset = "0x5355570", VA = "0x185356370", Slot = "4")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000374")]
		[Cpp2IlInjected.Address(RVA = "0x5355D30", Offset = "0x5354F30", VA = "0x185355D30", Slot = "5")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000380")]
	[Cpp2IlInjected.Address(RVA = "0x5356B10", Offset = "0x5355D10", VA = "0x185356B10")]
	public AMOJDPPGPLO(PPMDIHPMNCG LDDCANHDBNB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000381")]
	[Cpp2IlInjected.Address(RVA = "0x5355B90", Offset = "0x5354D90", VA = "0x185355B90", Slot = "6")]
	public void BKOELLNKDDF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000382")]
	[Cpp2IlInjected.Address(RVA = "0x5355B80", Offset = "0x5354D80", VA = "0x185355B80", Slot = "8")]
	public void ABJCFICOBMJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000383")]
	[Cpp2IlInjected.Address(RVA = "0x5356570", Offset = "0x5355770", VA = "0x185356570", Slot = "7")]
	public bool JLGKLAGDNBA()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000384")]
	[Cpp2IlInjected.Address(RVA = "0x5356410", Offset = "0x5355610", VA = "0x185356410", Slot = "9")]
	public void HFOIEEGNPME()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000385")]
	[Cpp2IlInjected.Address(RVA = "0x5356330", Offset = "0x5355530", VA = "0x185356330", Slot = "12")]
	public void GCGBBMHMBBI(bool DMEOICFENFA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000386")]
	[Cpp2IlInjected.Address(RVA = "0x53564C0", Offset = "0x53556C0", VA = "0x1853564C0", Slot = "11")]
	public void IPODHJMCCPD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000387")]
	[Cpp2IlInjected.Address(RVA = "0x6E0EB0", Offset = "0x6E00B0", VA = "0x1806E0EB0", Slot = "10")]
	public void LHCKEPPOJKM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000388")]
	[Cpp2IlInjected.Address(RVA = "0x5355DD0", Offset = "0x5354FD0", VA = "0x185355DD0")]
	private bool DBMAMKHOENP()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000389")]
	[Cpp2IlInjected.Address(RVA = "0x5356790", Offset = "0x5355990", VA = "0x185356790")]
	private void JOHNGPOIGFH()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200003E")]
internal sealed class BAODDNOCKIF : ABJBDNIKKNI, HONAINACCHA
{
	[Cpp2IlInjected.Token(Token = "0x400005E")]
	private const string MEJHJGGIKBM = "RBEX_ANIM";

	[Cpp2IlInjected.Token(Token = "0x170000EF")]
	public Rigidbody BAPEKECGLDP
	{
		[Cpp2IlInjected.Token(Token = "0x600038A")]
		[Cpp2IlInjected.Address(RVA = "0x5357EB0", Offset = "0x53570B0", VA = "0x185357EB0", Slot = "4")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600038B")]
		[Cpp2IlInjected.Address(RVA = "0x5357840", Offset = "0x5356A40", VA = "0x185357840")]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000F0")]
	private bool DKNFKPAFDPB
	{
		[Cpp2IlInjected.Token(Token = "0x600038C")]
		[Cpp2IlInjected.Address(RVA = "0x5357480", Offset = "0x5356680", VA = "0x185357480")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600038D")]
	[Cpp2IlInjected.Address(RVA = "0x5357F90", Offset = "0x5357190", VA = "0x185357F90")]
	public BAODDNOCKIF(PPMDIHPMNCG LDDCANHDBNB, in OALOFNDFAEL ONIBEFDCPGD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600038E")]
	[Cpp2IlInjected.Address(RVA = "0x5357210", Offset = "0x5356410", VA = "0x185357210", Slot = "5")]
	public void BKOELLNKDDF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600038F")]
	[Cpp2IlInjected.Address(RVA = "0x5357AF0", Offset = "0x5356CF0", VA = "0x185357AF0", Slot = "6")]
	public void NMDKIGJCKAP(object AJDBKDIMOHA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000390")]
	[Cpp2IlInjected.Address(RVA = "0x5357740", Offset = "0x5356940", VA = "0x185357740", Slot = "7")]
	public void IGIJDOMADBN(object AJDBKDIMOHA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000391")]
	[Cpp2IlInjected.Address(RVA = "0x5357BF0", Offset = "0x5356DF0", VA = "0x185357BF0", Slot = "8")]
	public void OHCCCGHNBBD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000392")]
	[Cpp2IlInjected.Address(RVA = "0x53574E0", Offset = "0x53566E0", VA = "0x1853574E0", Slot = "9")]
	public void GGGGLIFJEPO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000393")]
	[Cpp2IlInjected.Address(RVA = "0x5357040", Offset = "0x5356240", VA = "0x185357040", Slot = "10")]
	public void AELIAEFBMCN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000394")]
	[Cpp2IlInjected.Address(RVA = "0x6E0EB0", Offset = "0x6E00B0", VA = "0x1806E0EB0", Slot = "11")]
	public void JNJCHBBCJEP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000395")]
	[Cpp2IlInjected.Address(RVA = "0x5357930", Offset = "0x5356B30", VA = "0x185357930")]
	private void LCKBPKDNOGE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000396")]
	[Cpp2IlInjected.Address(RVA = "0x53572C0", Offset = "0x53564C0", VA = "0x1853572C0")]
	private void CHFOKHDGJOD()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200003F")]
internal sealed class AGGMOGOMGDO : ABJBDNIKKNI, MPILPIJAHDO, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x170000F1")]
	public LKKOPIEOHJA OLDOEMJHCAC
	{
		[Cpp2IlInjected.Token(Token = "0x6000397")]
		[Cpp2IlInjected.Address(RVA = "0x5351F90", Offset = "0x5351190", VA = "0x185351F90", Slot = "4")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000398")]
		[Cpp2IlInjected.Address(RVA = "0x53526A0", Offset = "0x53518A0", VA = "0x1853526A0", Slot = "5")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000F2")]
	public FDHNJKMJJJG AEPCDANKKNF
	{
		[Cpp2IlInjected.Token(Token = "0x6000399")]
		[Cpp2IlInjected.Address(RVA = "0x5350400", Offset = "0x534F600", VA = "0x185350400", Slot = "6")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600039A")]
		[Cpp2IlInjected.Address(RVA = "0x5351810", Offset = "0x5350A10", VA = "0x185351810", Slot = "7")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000F3")]
	public Vector3 MHCLHNEGJDD
	{
		[Cpp2IlInjected.Token(Token = "0x600039B")]
		[Cpp2IlInjected.Address(RVA = "0x5350840", Offset = "0x534FA40", VA = "0x185350840", Slot = "8")]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x600039C")]
		[Cpp2IlInjected.Address(RVA = "0x5351ED0", Offset = "0x53510D0", VA = "0x185351ED0", Slot = "9")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000F4")]
	public Vector3 JMJCCDADJPC
	{
		[Cpp2IlInjected.Token(Token = "0x600039D")]
		[Cpp2IlInjected.Address(RVA = "0x5352790", Offset = "0x5351990", VA = "0x185352790", Slot = "10")]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x600039E")]
		[Cpp2IlInjected.Address(RVA = "0x5352B70", Offset = "0x5351D70", VA = "0x185352B70", Slot = "11")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000F5")]
	public Vector3 DLFBGEBKEHJ
	{
		[Cpp2IlInjected.Token(Token = "0x600039F")]
		[Cpp2IlInjected.Address(RVA = "0x53521B0", Offset = "0x53513B0", VA = "0x1853521B0", Slot = "12")]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x60003A0")]
		[Cpp2IlInjected.Address(RVA = "0x5353060", Offset = "0x5352260", VA = "0x185353060", Slot = "13")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000F6")]
	public Vector3 KGONIIPAFMK
	{
		[Cpp2IlInjected.Token(Token = "0x60003A1")]
		[Cpp2IlInjected.Address(RVA = "0x5352F40", Offset = "0x5352140", VA = "0x185352F40", Slot = "14")]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x60003A2")]
		[Cpp2IlInjected.Address(RVA = "0x53517E0", Offset = "0x53509E0", VA = "0x1853517E0", Slot = "15")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000F7")]
	public float ENFIJFJPIPJ
	{
		[Cpp2IlInjected.Token(Token = "0x60003A3")]
		[Cpp2IlInjected.Address(RVA = "0x53536F0", Offset = "0x53528F0", VA = "0x1853536F0", Slot = "16")]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x60003A4")]
		[Cpp2IlInjected.Address(RVA = "0x53538E0", Offset = "0x5352AE0", VA = "0x1853538E0", Slot = "17")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000F8")]
	public bool OIAJDGKIDMB
	{
		[Cpp2IlInjected.Token(Token = "0x60003A6")]
		[Cpp2IlInjected.Address(RVA = "0x5350760", Offset = "0x534F960", VA = "0x185350760", Slot = "18")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000F9")]
	private FGHCKEELDLL MOEIJMAANIJ
	{
		[Cpp2IlInjected.Token(Token = "0x60003BA")]
		[Cpp2IlInjected.Address(RVA = "0x1D6F2F0", Offset = "0x1D6E4F0", VA = "0x181D6F2F0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000FA")]
	private bool NFEEOKFPIGD
	{
		[Cpp2IlInjected.Token(Token = "0x60003BB")]
		[Cpp2IlInjected.Address(RVA = "0x5352680", Offset = "0x5351880", VA = "0x185352680")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60003A5")]
	[Cpp2IlInjected.Address(RVA = "0x534EA30", Offset = "0x534DC30", VA = "0x18534EA30")]
	public AGGMOGOMGDO(PPMDIHPMNCG LDDCANHDBNB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003A7")]
	[Cpp2IlInjected.Address(RVA = "0x53520C0", Offset = "0x53512C0", VA = "0x1853520C0", Slot = "20")]
	public void HHNPBMOKIFP(object AJDBKDIMOHA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003A8")]
	[Cpp2IlInjected.Address(RVA = "0x5353540", Offset = "0x5352740", VA = "0x185353540", Slot = "31")]
	public void NFNEBKIHHFL(object AJDBKDIMOHA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003A9")]
	[Cpp2IlInjected.Address(RVA = "0x5350530", Offset = "0x534F730", VA = "0x185350530", Slot = "19")]
	public void BKOELLNKDDF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003AA")]
	[Cpp2IlInjected.Address(RVA = "0x5350BA0", Offset = "0x534FDA0", VA = "0x185350BA0", Slot = "37")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003AB")]
	[Cpp2IlInjected.Address(RVA = "0x5352DD0", Offset = "0x5351FD0", VA = "0x185352DD0", Slot = "28")]
	public void JPMOLDGLNJO(Rigidbody AOAFHPHKFMD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003AC")]
	[Cpp2IlInjected.Address(RVA = "0x5350CD0", Offset = "0x534FED0", VA = "0x185350CD0", Slot = "36")]
	public Vector3 EAJIEBJEBJP(Vector3 ODPCODBLNJO)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x60003AD")]
	[Cpp2IlInjected.Address(RVA = "0x53529B0", Offset = "0x5351BB0", VA = "0x1853529B0", Slot = "35")]
	public Vector3 JGGPKLHDPOC(Vector3 DLOMDLEMEJO)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x60003AE")]
	[Cpp2IlInjected.Address(RVA = "0x5350530", Offset = "0x534F730", VA = "0x185350530", Slot = "27")]
	public void LNGHCMNGELC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003AF")]
	[Cpp2IlInjected.Address(RVA = "0x5350B60", Offset = "0x534FD60", VA = "0x185350B60", Slot = "25")]
	public void DGADOFDPFDE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003B0")]
	[Cpp2IlInjected.Address(RVA = "0x5352640", Offset = "0x5351840", VA = "0x185352640", Slot = "24")]
	public void IBIENENFOLO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003B1")]
	[Cpp2IlInjected.Address(RVA = "0x5350EB0", Offset = "0x53500B0", VA = "0x185350EB0", Slot = "34")]
	public void EEIOJCMLKKL(Vector3 PKEOGDHOABC, Vector3 GNHLNIEHAFA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003B2")]
	[Cpp2IlInjected.Address(RVA = "0x53505A0", Offset = "0x534F7A0", VA = "0x1853505A0", Slot = "33")]
	public void BNKAMLPDNDH(Vector3 IHHIJIKHHIA, Vector3 NBGIHKDGDID)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003B3")]
	[Cpp2IlInjected.Address(RVA = "0x5350600", Offset = "0x534F800", VA = "0x185350600", Slot = "32")]
	public void CADMMMANGFL(Vector3 GJKLLEKAGBH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003B4")]
	[Cpp2IlInjected.Address(RVA = "0x5351A60", Offset = "0x5350C60", VA = "0x185351A60", Slot = "22")]
	public void GOHOEPELEBG(CBPMCKPIBHC EIOPEGEMKHP, Vector3 DKCLOLGBADH, float OOKLCGCBAJI, float LLKLELEIBGC = 8f, float AEEFHMKEOAH = 1f)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003B5")]
	[Cpp2IlInjected.Address(RVA = "0x5352BA0", Offset = "0x5351DA0", VA = "0x185352BA0", Slot = "21")]
	public void JLNINMHMEHA(BOPFIFMMKBG BPDOBLBNKEN, Vector3 NLFAAHHHDNN, float HHHNHCMFNFA = float.PositiveInfinity)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003B6")]
	[Cpp2IlInjected.Address(RVA = "0x5350130", Offset = "0x534F330", VA = "0x185350130", Slot = "23")]
	[Obsolete]
	public void ADCBOLCDFHD(BOPFIFMMKBG BPDOBLBNKEN, Vector3 MCFIHGJCDCP, float BDCHAJELIHL = 7f, float ABPPGEHGCFI = 1f)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003B7")]
	[Cpp2IlInjected.Address(RVA = "0x5353480", Offset = "0x5352680", VA = "0x185353480", Slot = "30")]
	public Vector3 KPFDHGBBOFB(Vector3 BNEEGIEDHBB)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x60003B8")]
	[Cpp2IlInjected.Address(RVA = "0x53516F0", Offset = "0x53508F0", VA = "0x1853516F0", Slot = "29")]
	public Vector3 FHKEINJELIE(Vector3 IMJEKHOJGKC)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x60003B9")]
	[Cpp2IlInjected.Address(RVA = "0x5352E10", Offset = "0x5352010", VA = "0x185352E10", Slot = "26")]
	public void KDDHFACBKGB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003BC")]
	[Cpp2IlInjected.Address(RVA = "0x5350990", Offset = "0x534FB90", VA = "0x185350990")]
	private void CJOOFKCBJCD(float JFBPNBNBHOE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003BD")]
	[Cpp2IlInjected.Address(RVA = "0x5351900", Offset = "0x5350B00", VA = "0x185351900")]
	private void GEOKOCNAGLK(Vector3 NLFAAHHHDNN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003BE")]
	[Cpp2IlInjected.Address(RVA = "0x53537D0", Offset = "0x53529D0", VA = "0x1853537D0")]
	private Vector3 PAHNCPJEPIJ()
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x60003BF")]
	[Cpp2IlInjected.Address(RVA = "0x5352300", Offset = "0x5351500", VA = "0x185352300")]
	private void HMLBCCHCNID(Vector3 DLOMDLEMEJO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003C0")]
	[Cpp2IlInjected.Address(RVA = "0x53528A0", Offset = "0x5351AA0", VA = "0x1853528A0")]
	private Vector3 JFACHOANBJO()
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x60003C1")]
	[Cpp2IlInjected.Address(RVA = "0x5353120", Offset = "0x5352320", VA = "0x185353120")]
	private void KPADOHKNGPN(Vector3 JFBPNBNBHOE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003C2")]
	[Cpp2IlInjected.Address(RVA = "0x53510F0", Offset = "0x53502F0", VA = "0x1853510F0")]
	private void EFAJHPCILNA(Vector3 DLOMDLEMEJO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003C3")]
	[Cpp2IlInjected.Address(RVA = "0x5353630", Offset = "0x5352830", VA = "0x185353630")]
	private void NGKMKMAACHI()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000040")]
internal class ABJBDNIKKNI
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400005F")]
	protected readonly LKOIEBFOHCO LDDCANHDBNB;

	[Cpp2IlInjected.Token(Token = "0x170000FB")]
	protected MCAEHJPOCLP GMLNDICHODE
	{
		[Cpp2IlInjected.Token(Token = "0x60003C4")]
		[Cpp2IlInjected.Address(RVA = "0xBAC6B0", Offset = "0xBAB8B0", VA = "0x180BAC6B0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000FC")]
	protected NFJEDPPAJMK KPJMLJDCDIG
	{
		[Cpp2IlInjected.Token(Token = "0x60003C5")]
		[Cpp2IlInjected.Address(RVA = "0x534EBD0", Offset = "0x534DDD0", VA = "0x18534EBD0")]
		get
		{
			return default(NFJEDPPAJMK);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60003C6")]
	[Cpp2IlInjected.Address(RVA = "0x534EA30", Offset = "0x534DC30", VA = "0x18534EA30")]
	public ABJBDNIKKNI(PPMDIHPMNCG LDDCANHDBNB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003C7")]
	[Cpp2IlInjected.Address(RVA = "0x534EAB0", Offset = "0x534DCB0", VA = "0x18534EAB0")]
	protected PPMDIHPMNCG GGKEECHPPDD(NFJEDPPAJMK ONBAMHPEIDG)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000041")]
public class CFLCLECANAB : KMBOJHAPLLI
{
	[Cpp2IlInjected.Token(Token = "0x60003C8")]
	[Cpp2IlInjected.Address(RVA = "0x53598B0", Offset = "0x5358AB0", VA = "0x1853598B0", Slot = "4")]
	public HMOOAGCGLKM MJLNOLDLKOJ(PPMDIHPMNCG ONJEPBGIHBB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003C9")]
	[Cpp2IlInjected.Address(RVA = "0x5359A20", Offset = "0x5358C20", VA = "0x185359A20", Slot = "5")]
	public MPILPIJAHDO MOHHJJFOLBM(PPMDIHPMNCG ONJEPBGIHBB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003CA")]
	[Cpp2IlInjected.Address(RVA = "0x53596A0", Offset = "0x53588A0", VA = "0x1853596A0", Slot = "6")]
	public NPFLLLAFPDM IMEKOCFODBG(PPMDIHPMNCG ONJEPBGIHBB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003CB")]
	[Cpp2IlInjected.Address(RVA = "0x53594E0", Offset = "0x53586E0", VA = "0x1853594E0", Slot = "7")]
	public KKCAAHMNCAO HEDEOJGLLAC(PPMDIHPMNCG ONJEPBGIHBB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003CC")]
	[Cpp2IlInjected.Address(RVA = "0x53597E0", Offset = "0x53589E0", VA = "0x1853597E0", Slot = "8")]
	public BBGIBEMMCOA JNPIPKPJGAO(PPMDIHPMNCG ONJEPBGIHBB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003CD")]
	[Cpp2IlInjected.Address(RVA = "0x5359580", Offset = "0x5358780", VA = "0x185359580", Slot = "9")]
	public ODGCKIECBJN HEMHCEJPPBH(PPMDIHPMNCG ONJEPBGIHBB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003CE")]
	[Cpp2IlInjected.Address(RVA = "0x5359330", Offset = "0x5358530", VA = "0x185359330", Slot = "10")]
	public GAMBABDLKNB GBHLIFIGFGO(PPMDIHPMNCG ONJEPBGIHBB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003CF")]
	[Cpp2IlInjected.Address(RVA = "0x5359440", Offset = "0x5358640", VA = "0x185359440", Slot = "11")]
	public FGHCKEELDLL HDCLGAJOJOG(PPMDIHPMNCG ONJEPBGIHBB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003D0")]
	[Cpp2IlInjected.Address(RVA = "0x5358F90", Offset = "0x5358190", VA = "0x185358F90", Slot = "12")]
	public APGGGIKOMPN AJBLCMCEIMG(PPMDIHPMNCG ONJEPBGIHBB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003D1")]
	[Cpp2IlInjected.Address(RVA = "0x5359740", Offset = "0x5358940", VA = "0x185359740", Slot = "13")]
	public LMMEICEFKMM JIMOFCMOFGN(PPMDIHPMNCG ONJEPBGIHBB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003D2")]
	[Cpp2IlInjected.Address(RVA = "0x5359270", Offset = "0x5358470", VA = "0x185359270")]
	public HONAINACCHA EPFJODDPHNJ(PPMDIHPMNCG ONJEPBGIHBB, in OALOFNDFAEL ONIBEFDCPGD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003D3")]
	[Cpp2IlInjected.Address(RVA = "0x53595E0", Offset = "0x53587E0", VA = "0x1853595E0")]
	public LNJFNCEGNCA IMOGAPPPDNI(PPMDIHPMNCG ONJEPBGIHBB, in OALOFNDFAEL ONIBEFDCPGD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003D4")]
	[Cpp2IlInjected.Address(RVA = "0x5359030", Offset = "0x5358230", VA = "0x185359030")]
	public EBCDLOKEBCP MEDAGDCIAAG(PPMDIHPMNCG ONJEPBGIHBB, in OALOFNDFAEL ONIBEFDCPGD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003D5")]
	[Cpp2IlInjected.Address(RVA = "0x5359840", Offset = "0x5358A40", VA = "0x185359840")]
	public HEFJBMMENIM PIKOPGMPFFO(PPMDIHPMNCG ONJEPBGIHBB, in OALOFNDFAEL ONIBEFDCPGD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003D6")]
	[Cpp2IlInjected.Address(RVA = "0x53593D0", Offset = "0x53585D0", VA = "0x1853593D0")]
	public OIAJBEDDNGM NOELAMDCDMI(PPMDIHPMNCG ONJEPBGIHBB, in OALOFNDFAEL ONIBEFDCPGD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003D7")]
	[Cpp2IlInjected.Address(RVA = "0x53591C0", Offset = "0x53583C0", VA = "0x1853591C0", Slot = "19")]
	public PPMDIHPMNCG EHCIKDFINKO(RigidbodyEx LDDCANHDBNB, OALOFNDFAEL ONIBEFDCPGD, CMKMIKBKOHM OBOKKBNADPB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003D8")]
	[Cpp2IlInjected.Address(RVA = "0x6C8B30", Offset = "0x6C7D30", VA = "0x1806C8B30")]
	public CFLCLECANAB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003D9")]
	[Cpp2IlInjected.Address(RVA = "0x5359270", Offset = "0x5358470", VA = "0x185359270", Slot = "14")]
	private HONAINACCHA GIPLMECOEDJ(PPMDIHPMNCG ONJEPBGIHBB, in OALOFNDFAEL ONIBEFDCPGD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003DA")]
	[Cpp2IlInjected.Address(RVA = "0x53595E0", Offset = "0x53587E0", VA = "0x1853595E0", Slot = "15")]
	private LNJFNCEGNCA HOCCJMCGJPK(PPMDIHPMNCG ONJEPBGIHBB, in OALOFNDFAEL ONIBEFDCPGD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003DB")]
	[Cpp2IlInjected.Address(RVA = "0x5359030", Offset = "0x5358230", VA = "0x185359030", Slot = "16")]
	private EBCDLOKEBCP DDDDJCAAJFM(PPMDIHPMNCG ONJEPBGIHBB, in OALOFNDFAEL ONIBEFDCPGD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003DC")]
	[Cpp2IlInjected.Address(RVA = "0x5359840", Offset = "0x5358A40", VA = "0x185359840", Slot = "17")]
	private HEFJBMMENIM KPKGPEKIGJD(PPMDIHPMNCG ONJEPBGIHBB, in OALOFNDFAEL ONIBEFDCPGD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003DD")]
	[Cpp2IlInjected.Address(RVA = "0x53593D0", Offset = "0x53585D0", VA = "0x1853593D0", Slot = "18")]
	private OIAJBEDDNGM GLMHIKFJOJB(PPMDIHPMNCG ONJEPBGIHBB, in OALOFNDFAEL ONIBEFDCPGD)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000042")]
[DefaultMember("Item")]
public sealed class OBDJKKFDJOF : IReadOnlyList<PPMDIHPMNCG>, IEnumerable<PPMDIHPMNCG>, IEnumerable, IReadOnlyCollection<PPMDIHPMNCG>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000060")]
	public readonly NFJEDPPAJMK ONBAMHPEIDG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000061")]
	public readonly MCAEHJPOCLP IAFMOECNDHE;

	[Cpp2IlInjected.Token(Token = "0x170000FD")]
	public int HGPJFHAOHMD
	{
		[Cpp2IlInjected.Token(Token = "0x60003E1")]
		[Cpp2IlInjected.Address(RVA = "0x5375B90", Offset = "0x5374D90", VA = "0x185375B90", Slot = "5")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000FE")]
	public PPMDIHPMNCG OMKECOOHJIM
	{
		[Cpp2IlInjected.Token(Token = "0x60003E2")]
		[Cpp2IlInjected.Address(RVA = "0x5375C60", Offset = "0x5374E60", VA = "0x185375C60", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60003DE")]
	[Cpp2IlInjected.Address(RVA = "0x5375B40", Offset = "0x5374D40", VA = "0x185375B40")]
	public OBDJKKFDJOF(NFJEDPPAJMK ONBAMHPEIDG, MCAEHJPOCLP IAFMOECNDHE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003DF")]
	[Cpp2IlInjected.Address(RVA = "0x53759B0", Offset = "0x5374BB0", VA = "0x1853759B0", Slot = "6")]
	public IEnumerator<PPMDIHPMNCG> GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003E0")]
	[Cpp2IlInjected.Address(RVA = "0x53759B0", Offset = "0x5374BB0", VA = "0x1853759B0", Slot = "7")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003E3")]
	[Cpp2IlInjected.Address(RVA = "0x53759A0", Offset = "0x5374BA0", VA = "0x1853759A0")]
	[CompilerGenerated]
	private PPMDIHPMNCG GLFNJFAEHOO(int BHOLCDOGKAG)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000043")]
[LOJIIDJFKAI(typeof(KMBOJHAPLLI), new string[] { })]
public class AHJLCDEOIEK : KMBOJHAPLLI, DPDCPMNGBKH
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000062")]
	private readonly KMBOJHAPLLI CGMBPAFJDKL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000063")]
	private readonly KMBOJHAPLLI CCPHBLENGBG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000064")]
	private AKKPACBLFCH ONMGKKCFHAK;

	[Cpp2IlInjected.Token(Token = "0x170000FF")]
	private KMBOJHAPLLI AJPHGKGIGMH
	{
		[Cpp2IlInjected.Token(Token = "0x60003E5")]
		[Cpp2IlInjected.Address(RVA = "0x5354960", Offset = "0x5353B60", VA = "0x185354960")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60003E4")]
	[Cpp2IlInjected.Address(RVA = "0x5354CF0", Offset = "0x5353EF0", VA = "0x185354CF0", Slot = "20")]
	public void PEIMLKLDOFJ(JHLNNPKIFCO KOKEGENGCAH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003E6")]
	[Cpp2IlInjected.Address(RVA = "0x5354BB0", Offset = "0x5353DB0", VA = "0x185354BB0", Slot = "4")]
	public HMOOAGCGLKM MJLNOLDLKOJ(PPMDIHPMNCG ONJEPBGIHBB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003E7")]
	[Cpp2IlInjected.Address(RVA = "0x5354C50", Offset = "0x5353E50", VA = "0x185354C50", Slot = "5")]
	public MPILPIJAHDO MOHHJJFOLBM(PPMDIHPMNCG ONJEPBGIHBB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003E8")]
	[Cpp2IlInjected.Address(RVA = "0x53548C0", Offset = "0x5353AC0", VA = "0x1853548C0", Slot = "6")]
	public NPFLLLAFPDM IMEKOCFODBG(PPMDIHPMNCG ONJEPBGIHBB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003E9")]
	[Cpp2IlInjected.Address(RVA = "0x53546D0", Offset = "0x53538D0", VA = "0x1853546D0", Slot = "7")]
	public KKCAAHMNCAO HEDEOJGLLAC(PPMDIHPMNCG ONJEPBGIHBB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003EA")]
	[Cpp2IlInjected.Address(RVA = "0x5354A60", Offset = "0x5353C60", VA = "0x185354A60", Slot = "8")]
	public BBGIBEMMCOA JNPIPKPJGAO(PPMDIHPMNCG ONJEPBGIHBB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003EB")]
	[Cpp2IlInjected.Address(RVA = "0x5354770", Offset = "0x5353970", VA = "0x185354770", Slot = "9")]
	public ODGCKIECBJN HEMHCEJPPBH(PPMDIHPMNCG ONJEPBGIHBB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003EC")]
	[Cpp2IlInjected.Address(RVA = "0x53544E0", Offset = "0x53536E0", VA = "0x1853544E0", Slot = "10")]
	public GAMBABDLKNB GBHLIFIGFGO(PPMDIHPMNCG ONJEPBGIHBB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003ED")]
	[Cpp2IlInjected.Address(RVA = "0x5354630", Offset = "0x5353830", VA = "0x185354630", Slot = "11")]
	public FGHCKEELDLL HDCLGAJOJOG(PPMDIHPMNCG ONJEPBGIHBB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003EE")]
	[Cpp2IlInjected.Address(RVA = "0x5354190", Offset = "0x5353390", VA = "0x185354190", Slot = "12")]
	public APGGGIKOMPN AJBLCMCEIMG(PPMDIHPMNCG ONJEPBGIHBB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003EF")]
	[Cpp2IlInjected.Address(RVA = "0x53549C0", Offset = "0x5353BC0", VA = "0x1853549C0", Slot = "13")]
	public LMMEICEFKMM JIMOFCMOFGN(PPMDIHPMNCG ONJEPBGIHBB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003F0")]
	[Cpp2IlInjected.Address(RVA = "0x5354430", Offset = "0x5353630", VA = "0x185354430")]
	public HONAINACCHA EPFJODDPHNJ(PPMDIHPMNCG ONJEPBGIHBB, in OALOFNDFAEL ONIBEFDCPGD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003F1")]
	[Cpp2IlInjected.Address(RVA = "0x5354810", Offset = "0x5353A10", VA = "0x185354810")]
	public LNJFNCEGNCA IMOGAPPPDNI(PPMDIHPMNCG ONJEPBGIHBB, in OALOFNDFAEL ONIBEFDCPGD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003F2")]
	[Cpp2IlInjected.Address(RVA = "0x5354230", Offset = "0x5353430", VA = "0x185354230")]
	public EBCDLOKEBCP MEDAGDCIAAG(PPMDIHPMNCG ONJEPBGIHBB, in OALOFNDFAEL ONIBEFDCPGD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003F3")]
	[Cpp2IlInjected.Address(RVA = "0x5354B00", Offset = "0x5353D00", VA = "0x185354B00")]
	public HEFJBMMENIM PIKOPGMPFFO(PPMDIHPMNCG ONJEPBGIHBB, in OALOFNDFAEL ONIBEFDCPGD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003F4")]
	[Cpp2IlInjected.Address(RVA = "0x5354580", Offset = "0x5353780", VA = "0x185354580")]
	public OIAJBEDDNGM NOELAMDCDMI(PPMDIHPMNCG ONJEPBGIHBB, in OALOFNDFAEL ONIBEFDCPGD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003F5")]
	[Cpp2IlInjected.Address(RVA = "0x53542E0", Offset = "0x53534E0", VA = "0x1853542E0", Slot = "19")]
	public PPMDIHPMNCG EHCIKDFINKO(RigidbodyEx LDDCANHDBNB, OALOFNDFAEL ONIBEFDCPGD, CMKMIKBKOHM OBOKKBNADPB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003F6")]
	[Cpp2IlInjected.Address(RVA = "0x5354D40", Offset = "0x5353F40", VA = "0x185354D40")]
	public AHJLCDEOIEK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003F7")]
	[Cpp2IlInjected.Address(RVA = "0x5354430", Offset = "0x5353630", VA = "0x185354430", Slot = "14")]
	private HONAINACCHA GIPLMECOEDJ(PPMDIHPMNCG ONJEPBGIHBB, in OALOFNDFAEL ONIBEFDCPGD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003F8")]
	[Cpp2IlInjected.Address(RVA = "0x5354810", Offset = "0x5353A10", VA = "0x185354810", Slot = "15")]
	private LNJFNCEGNCA HOCCJMCGJPK(PPMDIHPMNCG ONJEPBGIHBB, in OALOFNDFAEL ONIBEFDCPGD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003F9")]
	[Cpp2IlInjected.Address(RVA = "0x5354230", Offset = "0x5353430", VA = "0x185354230", Slot = "16")]
	private EBCDLOKEBCP DDDDJCAAJFM(PPMDIHPMNCG ONJEPBGIHBB, in OALOFNDFAEL ONIBEFDCPGD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003FA")]
	[Cpp2IlInjected.Address(RVA = "0x5354B00", Offset = "0x5353D00", VA = "0x185354B00", Slot = "17")]
	private HEFJBMMENIM KPKGPEKIGJD(PPMDIHPMNCG ONJEPBGIHBB, in OALOFNDFAEL ONIBEFDCPGD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003FB")]
	[Cpp2IlInjected.Address(RVA = "0x5354580", Offset = "0x5353780", VA = "0x185354580", Slot = "18")]
	private OIAJBEDDNGM GLMHIKFJOJB(PPMDIHPMNCG ONJEPBGIHBB, in OALOFNDFAEL ONIBEFDCPGD)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000044")]
[Preserve]
public sealed class PEMCFGMEGMC : PPMDIHPMNCG, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x4000065")]
	public static readonly PEMCFGMEGMC HNEIEBONIJN;

	[Cpp2IlInjected.Token(Token = "0x17000100")]
	public Rigidbody BAPEKECGLDP
	{
		[Cpp2IlInjected.Token(Token = "0x600040E")]
		[Cpp2IlInjected.Address(RVA = "0x6C8AC0", Offset = "0x6C7CC0", VA = "0x1806C8AC0", Slot = "4")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000101")]
	public RigidbodyEx JKIDPKKAFKH
	{
		[Cpp2IlInjected.Token(Token = "0x600040F")]
		[Cpp2IlInjected.Address(RVA = "0x6C70C0", Offset = "0x6C62C0", VA = "0x1806C70C0", Slot = "5")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000102")]
	public GameObject MNGKPNJJMOC
	{
		[Cpp2IlInjected.Token(Token = "0x6000410")]
		[Cpp2IlInjected.Address(RVA = "0x6C8120", Offset = "0x6C7320", VA = "0x1806C8120", Slot = "6")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000103")]
	public Transform LNPNGFHHEEL
	{
		[Cpp2IlInjected.Token(Token = "0x6000411")]
		[Cpp2IlInjected.Address(RVA = "0x6E18E0", Offset = "0x6E0AE0", VA = "0x1806E18E0", Slot = "7")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000104")]
	public IEnumerable<object> JNIPNMIKJIN
	{
		[Cpp2IlInjected.Token(Token = "0x6000412")]
		[Cpp2IlInjected.Address(RVA = "0x6DD6F0", Offset = "0x6DC8F0", VA = "0x1806DD6F0", Slot = "8")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000105")]
	public PPMDIHPMNCG EMIBHNNCMJC
	{
		[Cpp2IlInjected.Token(Token = "0x6000413")]
		[Cpp2IlInjected.Address(RVA = "0x6CE570", Offset = "0x6CD770", VA = "0x1806CE570", Slot = "9")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000414")]
		[Cpp2IlInjected.Address(RVA = "0x6CE590", Offset = "0x6CD790", VA = "0x1806CE590", Slot = "10")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000106")]
	public IReadOnlyList<PPMDIHPMNCG> LILCAAEDFCG
	{
		[Cpp2IlInjected.Token(Token = "0x6000415")]
		[Cpp2IlInjected.Address(RVA = "0x6CE580", Offset = "0x6CD780", VA = "0x1806CE580", Slot = "11")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000107")]
	public PPMDIHPMNCG MDHMHFAIMJJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000416")]
		[Cpp2IlInjected.Address(RVA = "0x6C70D0", Offset = "0x6C62D0", VA = "0x1806C70D0", Slot = "12")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000108")]
	public bool DKNFKPAFDPB
	{
		[Cpp2IlInjected.Token(Token = "0x6000417")]
		[Cpp2IlInjected.Address(RVA = "0x1074960", Offset = "0x1073B60", VA = "0x181074960", Slot = "13")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000109")]
	public bool PJPIAHDKHLD
	{
		[Cpp2IlInjected.Token(Token = "0x6000418")]
		[Cpp2IlInjected.Address(RVA = "0x116E260", Offset = "0x116D460", VA = "0x18116E260", Slot = "14")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700010A")]
	public bool EMGPBBGPGIE
	{
		[Cpp2IlInjected.Token(Token = "0x6000419")]
		[Cpp2IlInjected.Address(RVA = "0xB79EA0", Offset = "0xB790A0", VA = "0x180B79EA0", Slot = "15")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700010B")]
	public LKKOPIEOHJA OLDOEMJHCAC
	{
		[Cpp2IlInjected.Token(Token = "0x600041A")]
		[Cpp2IlInjected.Address(RVA = "0x6C70B0", Offset = "0x6C62B0", VA = "0x1806C70B0", Slot = "16")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600041B")]
		[Cpp2IlInjected.Address(RVA = "0x7BF300", Offset = "0x7BE500", VA = "0x1807BF300", Slot = "17")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700010C")]
	public FDHNJKMJJJG AEPCDANKKNF
	{
		[Cpp2IlInjected.Token(Token = "0x600041C")]
		[Cpp2IlInjected.Address(RVA = "0x6DD770", Offset = "0x6DC970", VA = "0x1806DD770", Slot = "18")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600041D")]
		[Cpp2IlInjected.Address(RVA = "0x768AB0", Offset = "0x767CB0", VA = "0x180768AB0", Slot = "19")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700010D")]
	public float ENFIJFJPIPJ
	{
		[Cpp2IlInjected.Token(Token = "0x600041E")]
		[Cpp2IlInjected.Address(RVA = "0x1726DF0", Offset = "0x1725FF0", VA = "0x181726DF0", Slot = "20")]
		[CompilerGenerated]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x600041F")]
		[Cpp2IlInjected.Address(RVA = "0x1C2D420", Offset = "0x1C2C620", VA = "0x181C2D420", Slot = "21")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700010E")]
	public Vector3 JMJCCDADJPC
	{
		[Cpp2IlInjected.Token(Token = "0x6000420")]
		[Cpp2IlInjected.Address(RVA = "0x32E2770", Offset = "0x32E1970", VA = "0x1832E2770", Slot = "22")]
		[CompilerGenerated]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x6000421")]
		[Cpp2IlInjected.Address(RVA = "0x32E56D0", Offset = "0x32E48D0", VA = "0x1832E56D0", Slot = "23")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700010F")]
	public Vector3 KGONIIPAFMK
	{
		[Cpp2IlInjected.Token(Token = "0x6000422")]
		[Cpp2IlInjected.Address(RVA = "0x17D2290", Offset = "0x17D1490", VA = "0x1817D2290", Slot = "24")]
		[CompilerGenerated]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x6000423")]
		[Cpp2IlInjected.Address(RVA = "0x17CD680", Offset = "0x17CC880", VA = "0x1817CD680", Slot = "25")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000110")]
	public Vector3 MHCLHNEGJDD
	{
		[Cpp2IlInjected.Token(Token = "0x6000424")]
		[Cpp2IlInjected.Address(RVA = "0x17D22B0", Offset = "0x17D14B0", VA = "0x1817D22B0", Slot = "26")]
		[CompilerGenerated]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x6000425")]
		[Cpp2IlInjected.Address(RVA = "0x17CEC70", Offset = "0x17CDE70", VA = "0x1817CEC70", Slot = "27")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000111")]
	public Vector3 DLFBGEBKEHJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000426")]
		[Cpp2IlInjected.Address(RVA = "0x1C333C0", Offset = "0x1C325C0", VA = "0x181C333C0", Slot = "28")]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x6000427")]
		[Cpp2IlInjected.Address(RVA = "0x6E0EB0", Offset = "0x6E00B0", VA = "0x1806E0EB0", Slot = "29")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000112")]
	public bool AMMPJIIANJD
	{
		[Cpp2IlInjected.Token(Token = "0x6000428")]
		[Cpp2IlInjected.Address(RVA = "0xBB02E0", Offset = "0xBAF4E0", VA = "0x180BB02E0", Slot = "30")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000113")]
	public bool OONHJPFBNAB
	{
		[Cpp2IlInjected.Token(Token = "0x6000429")]
		[Cpp2IlInjected.Address(RVA = "0xBF4910", Offset = "0xBF3B10", VA = "0x180BF4910", Slot = "31")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000114")]
	public bool AKAANNKOEAC
	{
		[Cpp2IlInjected.Token(Token = "0x600042A")]
		[Cpp2IlInjected.Address(RVA = "0xBF4900", Offset = "0xBF3B00", VA = "0x180BF4900", Slot = "32")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000115")]
	public bool OIAJDGKIDMB
	{
		[Cpp2IlInjected.Token(Token = "0x600042B")]
		[Cpp2IlInjected.Address(RVA = "0xA6FB80", Offset = "0xA6ED80", VA = "0x180A6FB80", Slot = "33")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000116")]
	public Vector3 DJHICJGOGJI
	{
		[Cpp2IlInjected.Token(Token = "0x600042C")]
		[Cpp2IlInjected.Address(RVA = "0x1A8E920", Offset = "0x1A8DB20", VA = "0x181A8E920", Slot = "34")]
		[CompilerGenerated]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000117")]
	public Vector3 EOFHLAGNPII
	{
		[Cpp2IlInjected.Token(Token = "0x600042D")]
		[Cpp2IlInjected.Address(RVA = "0x163D550", Offset = "0x163C750", VA = "0x18163D550", Slot = "35")]
		[CompilerGenerated]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000118")]
	public Vector3 JMIIJDMAMEI
	{
		[Cpp2IlInjected.Token(Token = "0x600042E")]
		[Cpp2IlInjected.Address(RVA = "0x1C333C0", Offset = "0x1C325C0", VA = "0x181C333C0", Slot = "36")]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x600042F")]
		[Cpp2IlInjected.Address(RVA = "0x6E0EB0", Offset = "0x6E00B0", VA = "0x1806E0EB0", Slot = "37")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000119")]
	public Vector3 PMKFGPJNJBI
	{
		[Cpp2IlInjected.Token(Token = "0x6000430")]
		[Cpp2IlInjected.Address(RVA = "0x17D2380", Offset = "0x17D1580", VA = "0x1817D2380", Slot = "38")]
		[CompilerGenerated]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700011A")]
	public float KLNDCEHFMBA
	{
		[Cpp2IlInjected.Token(Token = "0x6000431")]
		[Cpp2IlInjected.Address(RVA = "0x11D4170", Offset = "0x11D3370", VA = "0x1811D4170", Slot = "39")]
		[CompilerGenerated]
		get
		{
			return default(float);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700011B")]
	public float NBJLLACMBLF
	{
		[Cpp2IlInjected.Token(Token = "0x6000432")]
		[Cpp2IlInjected.Address(RVA = "0x1079270", Offset = "0x1078470", VA = "0x181079270", Slot = "40")]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x6000433")]
		[Cpp2IlInjected.Address(RVA = "0x6E0EB0", Offset = "0x6E00B0", VA = "0x1806E0EB0", Slot = "41")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700011C")]
	public Vector3 OFFHJCCLOEB
	{
		[Cpp2IlInjected.Token(Token = "0x6000434")]
		[Cpp2IlInjected.Address(RVA = "0x1C333C0", Offset = "0x1C325C0", VA = "0x181C333C0", Slot = "42")]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x6000435")]
		[Cpp2IlInjected.Address(RVA = "0x6E0EB0", Offset = "0x6E00B0", VA = "0x1806E0EB0", Slot = "43")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700011D")]
	public Quaternion MOMBOPJMDMK
	{
		[Cpp2IlInjected.Token(Token = "0x6000436")]
		[Cpp2IlInjected.Address(RVA = "0x16AAF60", Offset = "0x16AA160", VA = "0x1816AAF60", Slot = "44")]
		get
		{
			return default(Quaternion);
		}
		[Cpp2IlInjected.Token(Token = "0x6000437")]
		[Cpp2IlInjected.Address(RVA = "0x6E0EB0", Offset = "0x6E00B0", VA = "0x1806E0EB0", Slot = "45")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700011E")]
	public float FCGOFCPMIGL
	{
		[Cpp2IlInjected.Token(Token = "0x6000438")]
		[Cpp2IlInjected.Address(RVA = "0x1079270", Offset = "0x1078470", VA = "0x181079270", Slot = "46")]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x6000439")]
		[Cpp2IlInjected.Address(RVA = "0x6E0EB0", Offset = "0x6E00B0", VA = "0x1806E0EB0", Slot = "47")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700011F")]
	public float CFMIJLIHCIE
	{
		[Cpp2IlInjected.Token(Token = "0x600043A")]
		[Cpp2IlInjected.Address(RVA = "0x1079270", Offset = "0x1078470", VA = "0x181079270", Slot = "48")]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x600043B")]
		[Cpp2IlInjected.Address(RVA = "0x6E0EB0", Offset = "0x6E00B0", VA = "0x1806E0EB0", Slot = "49")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000120")]
	public bool HLADCICNJBO
	{
		[Cpp2IlInjected.Token(Token = "0x600043C")]
		[Cpp2IlInjected.Address(RVA = "0x6CAD00", Offset = "0x6C9F00", VA = "0x1806CAD00", Slot = "50")]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x600043D")]
		[Cpp2IlInjected.Address(RVA = "0x6E0EB0", Offset = "0x6E00B0", VA = "0x1806E0EB0", Slot = "51")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000121")]
	public bool GENHOBGEJGK
	{
		[Cpp2IlInjected.Token(Token = "0x600043E")]
		[Cpp2IlInjected.Address(RVA = "0x6CAD00", Offset = "0x6C9F00", VA = "0x1806CAD00")]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x600043F")]
		[Cpp2IlInjected.Address(RVA = "0x6E0EB0", Offset = "0x6E00B0", VA = "0x1806E0EB0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000122")]
	public PPGNAFCKNOL NHFAJHMDKMA
	{
		[Cpp2IlInjected.Token(Token = "0x6000440")]
		[Cpp2IlInjected.Address(RVA = "0x6CAD00", Offset = "0x6C9F00", VA = "0x1806CAD00", Slot = "52")]
		get
		{
			return default(PPGNAFCKNOL);
		}
		[Cpp2IlInjected.Token(Token = "0x6000441")]
		[Cpp2IlInjected.Address(RVA = "0x6E0EB0", Offset = "0x6E00B0", VA = "0x1806E0EB0", Slot = "53")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000123")]
	public bool MBEHMAPDJBJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000442")]
		[Cpp2IlInjected.Address(RVA = "0x2113ED0", Offset = "0x21130D0", VA = "0x182113ED0", Slot = "54")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000124")]
	public Transform PDLNBKLCFJO
	{
		[Cpp2IlInjected.Token(Token = "0x6000443")]
		[Cpp2IlInjected.Address(RVA = "0x7F7820", Offset = "0x7F6A20", VA = "0x1807F7820", Slot = "55")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000125")]
	public Transform IPOOCBGBBCA
	{
		[Cpp2IlInjected.Token(Token = "0x6000444")]
		[Cpp2IlInjected.Address(RVA = "0x77F7A0", Offset = "0x77E9A0", VA = "0x18077F7A0", Slot = "56")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000126")]
	public Vector3 GCIAIFNDFJO
	{
		[Cpp2IlInjected.Token(Token = "0x6000445")]
		[Cpp2IlInjected.Address(RVA = "0x1C333C0", Offset = "0x1C325C0", VA = "0x181C333C0", Slot = "57")]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x6000446")]
		[Cpp2IlInjected.Address(RVA = "0x6E0EB0", Offset = "0x6E00B0", VA = "0x1806E0EB0", Slot = "58")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000127")]
	public float BIJKBCGODIE
	{
		[Cpp2IlInjected.Token(Token = "0x6000447")]
		[Cpp2IlInjected.Address(RVA = "0x1079270", Offset = "0x1078470", VA = "0x181079270", Slot = "59")]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x6000448")]
		[Cpp2IlInjected.Address(RVA = "0x6E0EB0", Offset = "0x6E00B0", VA = "0x1806E0EB0", Slot = "60")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000128")]
	public float CAEPFBBJBOK
	{
		[Cpp2IlInjected.Token(Token = "0x6000449")]
		[Cpp2IlInjected.Address(RVA = "0x1079270", Offset = "0x1078470", VA = "0x181079270", Slot = "61")]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x600044A")]
		[Cpp2IlInjected.Address(RVA = "0x6E0EB0", Offset = "0x6E00B0", VA = "0x1806E0EB0", Slot = "62")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000129")]
	public Quaternion LBGIBJJINJH
	{
		[Cpp2IlInjected.Token(Token = "0x600044B")]
		[Cpp2IlInjected.Address(RVA = "0x156FBD0", Offset = "0x156EDD0", VA = "0x18156FBD0", Slot = "63")]
		get
		{
			return default(Quaternion);
		}
		[Cpp2IlInjected.Token(Token = "0x600044C")]
		[Cpp2IlInjected.Address(RVA = "0x6E0EB0", Offset = "0x6E00B0", VA = "0x1806E0EB0", Slot = "64")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700012A")]
	public Vector3 EDNJLBDPNMM
	{
		[Cpp2IlInjected.Token(Token = "0x600044D")]
		[Cpp2IlInjected.Address(RVA = "0x1C333C0", Offset = "0x1C325C0", VA = "0x181C333C0", Slot = "65")]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x600044E")]
		[Cpp2IlInjected.Address(RVA = "0x6E0EB0", Offset = "0x6E00B0", VA = "0x1806E0EB0", Slot = "66")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700012B")]
	public Quaternion DIIIGEGILHP
	{
		[Cpp2IlInjected.Token(Token = "0x600044F")]
		[Cpp2IlInjected.Address(RVA = "0x156FBD0", Offset = "0x156EDD0", VA = "0x18156FBD0", Slot = "67")]
		get
		{
			return default(Quaternion);
		}
		[Cpp2IlInjected.Token(Token = "0x6000450")]
		[Cpp2IlInjected.Address(RVA = "0x6E0EB0", Offset = "0x6E00B0", VA = "0x1806E0EB0", Slot = "68")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700012C")]
	public RigidbodyConstraints BCMJAHAELOH
	{
		[Cpp2IlInjected.Token(Token = "0x6000451")]
		[Cpp2IlInjected.Address(RVA = "0x6CE170", Offset = "0x6CD370", VA = "0x1806CE170", Slot = "69")]
		get
		{
			return default(RigidbodyConstraints);
		}
		[Cpp2IlInjected.Token(Token = "0x6000452")]
		[Cpp2IlInjected.Address(RVA = "0x6E0EB0", Offset = "0x6E00B0", VA = "0x1806E0EB0", Slot = "70")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700012D")]
	public bool PJGCDNLPGAK
	{
		[Cpp2IlInjected.Token(Token = "0x6000453")]
		[Cpp2IlInjected.Address(RVA = "0x6CAD00", Offset = "0x6C9F00", VA = "0x1806CAD00", Slot = "71")]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000454")]
		[Cpp2IlInjected.Address(RVA = "0x6E0EB0", Offset = "0x6E00B0", VA = "0x1806E0EB0", Slot = "72")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700012E")]
	public CollisionDetectionMode CIEEKBNHEBL
	{
		[Cpp2IlInjected.Token(Token = "0x6000455")]
		[Cpp2IlInjected.Address(RVA = "0x6CE170", Offset = "0x6CD370", VA = "0x1806CE170", Slot = "73")]
		get
		{
			return default(CollisionDetectionMode);
		}
		[Cpp2IlInjected.Token(Token = "0x6000456")]
		[Cpp2IlInjected.Address(RVA = "0x6E0EB0", Offset = "0x6E00B0", VA = "0x1806E0EB0", Slot = "74")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700012F")]
	public bool NFEEOKFPIGD
	{
		[Cpp2IlInjected.Token(Token = "0x6000457")]
		[Cpp2IlInjected.Address(RVA = "0x1256860", Offset = "0x1255A60", VA = "0x181256860", Slot = "75")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000038")]
	public event JPOFABMOGOF KMPDHKDHBNO
	{
		[Cpp2IlInjected.Token(Token = "0x60003FC")]
		[Cpp2IlInjected.Address(RVA = "0x6E0EB0", Offset = "0x6E00B0", VA = "0x1806E0EB0", Slot = "81")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60003FD")]
		[Cpp2IlInjected.Address(RVA = "0x6E0EB0", Offset = "0x6E00B0", VA = "0x1806E0EB0", Slot = "82")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000039")]
	public event JPOFABMOGOF FIBPOODLACB
	{
		[Cpp2IlInjected.Token(Token = "0x60003FE")]
		[Cpp2IlInjected.Address(RVA = "0x6E0EB0", Offset = "0x6E00B0", VA = "0x1806E0EB0", Slot = "83")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60003FF")]
		[Cpp2IlInjected.Address(RVA = "0x6E0EB0", Offset = "0x6E00B0", VA = "0x1806E0EB0", Slot = "84")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400003A")]
	public event CBNHIOLMAOO LEBPAEACGHM
	{
		[Cpp2IlInjected.Token(Token = "0x6000400")]
		[Cpp2IlInjected.Address(RVA = "0x6E0EB0", Offset = "0x6E00B0", VA = "0x1806E0EB0", Slot = "85")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000401")]
		[Cpp2IlInjected.Address(RVA = "0x6E0EB0", Offset = "0x6E00B0", VA = "0x1806E0EB0", Slot = "86")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400003B")]
	public event JPOFABMOGOF OFDNMEKJKBP
	{
		[Cpp2IlInjected.Token(Token = "0x6000402")]
		[Cpp2IlInjected.Address(RVA = "0x6E0EB0", Offset = "0x6E00B0", VA = "0x1806E0EB0", Slot = "88")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000403")]
		[Cpp2IlInjected.Address(RVA = "0x6E0EB0", Offset = "0x6E00B0", VA = "0x1806E0EB0", Slot = "89")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400003C")]
	public event JPOFABMOGOF GHPNGDBINKD
	{
		[Cpp2IlInjected.Token(Token = "0x6000404")]
		[Cpp2IlInjected.Address(RVA = "0x6E0EB0", Offset = "0x6E00B0", VA = "0x1806E0EB0", Slot = "108")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000405")]
		[Cpp2IlInjected.Address(RVA = "0x6E0EB0", Offset = "0x6E00B0", VA = "0x1806E0EB0", Slot = "109")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400003D")]
	public event JPOFABMOGOF MLDKIENLGJG
	{
		[Cpp2IlInjected.Token(Token = "0x6000406")]
		[Cpp2IlInjected.Address(RVA = "0x6E0EB0", Offset = "0x6E00B0", VA = "0x1806E0EB0", Slot = "113")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000407")]
		[Cpp2IlInjected.Address(RVA = "0x6E0EB0", Offset = "0x6E00B0", VA = "0x1806E0EB0", Slot = "114")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400003E")]
	public event Action<LHLIDFNIOKA, LHLIDFNIOKA> GBMBMPKHBHO
	{
		[Cpp2IlInjected.Token(Token = "0x6000408")]
		[Cpp2IlInjected.Address(RVA = "0x6E0EB0", Offset = "0x6E00B0", VA = "0x1806E0EB0", Slot = "117")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000409")]
		[Cpp2IlInjected.Address(RVA = "0x6E0EB0", Offset = "0x6E00B0", VA = "0x1806E0EB0", Slot = "118")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400003F")]
	public event JPOFABMOGOF KKHOKOPLGIE
	{
		[Cpp2IlInjected.Token(Token = "0x600040A")]
		[Cpp2IlInjected.Address(RVA = "0x6E0EB0", Offset = "0x6E00B0", VA = "0x1806E0EB0", Slot = "119")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600040B")]
		[Cpp2IlInjected.Address(RVA = "0x6E0EB0", Offset = "0x6E00B0", VA = "0x1806E0EB0", Slot = "120")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000040")]
	public event JPOFABMOGOF FAMCBBOPNHD
	{
		[Cpp2IlInjected.Token(Token = "0x600040C")]
		[Cpp2IlInjected.Address(RVA = "0x6E0EB0", Offset = "0x6E00B0", VA = "0x1806E0EB0", Slot = "125")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600040D")]
		[Cpp2IlInjected.Address(RVA = "0x6E0EB0", Offset = "0x6E00B0", VA = "0x1806E0EB0", Slot = "126")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000458")]
	[Cpp2IlInjected.Address(RVA = "0x6E0EB0", Offset = "0x6E00B0", VA = "0x1806E0EB0", Slot = "76")]
	public void BKOELLNKDDF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000459")]
	[Cpp2IlInjected.Address(RVA = "0x6E0EB0", Offset = "0x6E00B0", VA = "0x1806E0EB0", Slot = "77")]
	public void IDDPIKDPIIE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600045A")]
	[Cpp2IlInjected.Address(RVA = "0x6E0EB0", Offset = "0x6E00B0", VA = "0x1806E0EB0", Slot = "78")]
	public void EDIJBNLFNNB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600045B")]
	[Cpp2IlInjected.Address(RVA = "0x6E0EB0", Offset = "0x6E00B0", VA = "0x1806E0EB0", Slot = "79")]
	public void HFOIEEGNPME()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600045C")]
	[Cpp2IlInjected.Address(RVA = "0x6E0EB0", Offset = "0x6E00B0", VA = "0x1806E0EB0", Slot = "80")]
	public void FODBIMBAOBD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600045D")]
	[Cpp2IlInjected.Address(RVA = "0x6E0EB0", Offset = "0x6E00B0", VA = "0x1806E0EB0", Slot = "141")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600045E")]
	[Cpp2IlInjected.Address(RVA = "0x6E0EB0", Offset = "0x6E00B0", VA = "0x1806E0EB0", Slot = "87")]
	public void KKGLFGKJMPP(PPMDIHPMNCG JFBPNBNBHOE, bool LMKLDOOIJAA = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600045F")]
	[Cpp2IlInjected.Address(RVA = "0x6E0EB0", Offset = "0x6E00B0", VA = "0x1806E0EB0", Slot = "90")]
	public void CGMPABBBBGH(object AJDBKDIMOHA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000460")]
	[Cpp2IlInjected.Address(RVA = "0x6E0EB0", Offset = "0x6E00B0", VA = "0x1806E0EB0", Slot = "91")]
	public void AKPJCFEODOB(object AJDBKDIMOHA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000461")]
	[Cpp2IlInjected.Address(RVA = "0x1C333C0", Offset = "0x1C325C0", VA = "0x181C333C0", Slot = "92")]
	public Vector3 EAJIEBJEBJP(Vector3 ODPCODBLNJO)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000462")]
	[Cpp2IlInjected.Address(RVA = "0x1C333C0", Offset = "0x1C325C0", VA = "0x181C333C0", Slot = "93")]
	public Vector3 JGGPKLHDPOC(Vector3 DLOMDLEMEJO)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000463")]
	[Cpp2IlInjected.Address(RVA = "0x6E0EB0", Offset = "0x6E00B0", VA = "0x1806E0EB0", Slot = "94")]
	public void LNGHCMNGELC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000464")]
	[Cpp2IlInjected.Address(RVA = "0x6E0EB0", Offset = "0x6E00B0", VA = "0x1806E0EB0", Slot = "95")]
	public void DGADOFDPFDE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000465")]
	[Cpp2IlInjected.Address(RVA = "0x6E0EB0", Offset = "0x6E00B0", VA = "0x1806E0EB0", Slot = "96")]
	public void IBIENENFOLO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000466")]
	[Cpp2IlInjected.Address(RVA = "0x6E0EB0", Offset = "0x6E00B0", VA = "0x1806E0EB0", Slot = "97")]
	public void EEIOJCMLKKL(Vector3 PKEOGDHOABC, Vector3 GNHLNIEHAFA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000467")]
	[Cpp2IlInjected.Address(RVA = "0x6E0EB0", Offset = "0x6E00B0", VA = "0x1806E0EB0", Slot = "98")]
	public void BNKAMLPDNDH(Vector3 IHHIJIKHHIA, Vector3 NBGIHKDGDID)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000468")]
	[Cpp2IlInjected.Address(RVA = "0x6E0EB0", Offset = "0x6E00B0", VA = "0x1806E0EB0", Slot = "99")]
	public void CADMMMANGFL(Vector3 GJKLLEKAGBH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000469")]
	[Cpp2IlInjected.Address(RVA = "0x6E0EB0", Offset = "0x6E00B0", VA = "0x1806E0EB0", Slot = "100")]
	public void GOHOEPELEBG(CBPMCKPIBHC EIOPEGEMKHP, Vector3 DKCLOLGBADH, float OOKLCGCBAJI, float LLKLELEIBGC = 8f, float AEEFHMKEOAH = 1f)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600046A")]
	[Cpp2IlInjected.Address(RVA = "0x6E0EB0", Offset = "0x6E00B0", VA = "0x1806E0EB0", Slot = "101")]
	public void JLNINMHMEHA(BOPFIFMMKBG BPDOBLBNKEN, Vector3 NLFAAHHHDNN, float HHHNHCMFNFA = float.PositiveInfinity)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600046B")]
	[Cpp2IlInjected.Address(RVA = "0x6E0EB0", Offset = "0x6E00B0", VA = "0x1806E0EB0", Slot = "102")]
	public void ADCBOLCDFHD(BOPFIFMMKBG BPDOBLBNKEN, Vector3 MCFIHGJCDCP, float BDCHAJELIHL = 7f, float ABPPGEHGCFI = 1f)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600046C")]
	[Cpp2IlInjected.Address(RVA = "0x1C333C0", Offset = "0x1C325C0", VA = "0x181C333C0", Slot = "103")]
	public Vector3 KPFDHGBBOFB(Vector3 JFBPNBNBHOE)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x600046D")]
	[Cpp2IlInjected.Address(RVA = "0x1C333C0", Offset = "0x1C325C0", VA = "0x181C333C0", Slot = "104")]
	public Vector3 FHKEINJELIE(Vector3 JFBPNBNBHOE)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x600046E")]
	[Cpp2IlInjected.Address(RVA = "0x6E0EB0", Offset = "0x6E00B0", VA = "0x1806E0EB0", Slot = "105")]
	public void KDDHFACBKGB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600046F")]
	[Cpp2IlInjected.Address(RVA = "0x6E0EB0", Offset = "0x6E00B0", VA = "0x1806E0EB0", Slot = "106")]
	public void KFIEFEHILOK(PPMDIHPMNCG FONAKEEEKPK, object AJDBKDIMOHA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000470")]
	[Cpp2IlInjected.Address(RVA = "0x6E0EB0", Offset = "0x6E00B0", VA = "0x1806E0EB0", Slot = "107")]
	public void MMHJICPHJHL(object AJDBKDIMOHA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000471")]
	[Cpp2IlInjected.Address(RVA = "0x6E0EB0", Offset = "0x6E00B0", VA = "0x1806E0EB0", Slot = "110")]
	public void OCCLJJBDHKH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000472")]
	[Cpp2IlInjected.Address(RVA = "0x6E0EB0", Offset = "0x6E00B0", VA = "0x1806E0EB0", Slot = "111")]
	public void LGMIOPKMACL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000473")]
	[Cpp2IlInjected.Address(RVA = "0x6E0EB0", Offset = "0x6E00B0", VA = "0x1806E0EB0", Slot = "112")]
	public void PGLMPJOADGG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000474")]
	[Cpp2IlInjected.Address(RVA = "0x6CAD00", Offset = "0x6C9F00", VA = "0x1806CAD00", Slot = "115")]
	public bool JLGKLAGDNBA()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000475")]
	[Cpp2IlInjected.Address(RVA = "0x6E0EB0", Offset = "0x6E00B0", VA = "0x1806E0EB0", Slot = "116")]
	public void IPODHJMCCPD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000476")]
	[Cpp2IlInjected.Address(RVA = "0x6CE170", Offset = "0x6CD370", VA = "0x1806CE170", Slot = "121")]
	public IDisposable BFJJEOKEAOO()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000477")]
	[Cpp2IlInjected.Address(RVA = "0x6E0EB0", Offset = "0x6E00B0", VA = "0x1806E0EB0", Slot = "122")]
	public void IDBKKNHMJCA(object AJDBKDIMOHA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000478")]
	[Cpp2IlInjected.Address(RVA = "0x6E0EB0", Offset = "0x6E00B0", VA = "0x1806E0EB0", Slot = "123")]
	public void BPLEOILKCFF(object AJDBKDIMOHA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000479")]
	[Cpp2IlInjected.Address(RVA = "0x6E0EB0", Offset = "0x6E00B0", VA = "0x1806E0EB0", Slot = "124")]
	public void NHDILIPFEBO(object AJDBKDIMOHA, bool NMHFDHPJGFL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600047A")]
	[Cpp2IlInjected.Address(RVA = "0x6E0EB0", Offset = "0x6E00B0", VA = "0x1806E0EB0", Slot = "127")]
	public void BBLLMNKJMFE(Vector3 LDBCCJOIJOF, Quaternion HPGHCBDEGFJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600047B")]
	[Cpp2IlInjected.Address(RVA = "0x6E0EB0", Offset = "0x6E00B0", VA = "0x1806E0EB0", Slot = "128")]
	public void MBJKCDHFBPN(Vector3 JPBAEPJPHFP, Quaternion NHHKEMOEKHO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600047C")]
	[Cpp2IlInjected.Address(RVA = "0x6CAD00", Offset = "0x6C9F00", VA = "0x1806CAD00", Slot = "129")]
	public bool BHKLDAAMMPP(float LCLMOJDNELD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600047D")]
	[Cpp2IlInjected.Address(RVA = "0x6E0EB0", Offset = "0x6E00B0", VA = "0x1806E0EB0", Slot = "130")]
	public void PGKAPIBFPCH(object AJDBKDIMOHA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600047E")]
	[Cpp2IlInjected.Address(RVA = "0x6E0EB0", Offset = "0x6E00B0", VA = "0x1806E0EB0", Slot = "131")]
	public void DFLECBDEDLK(object AJDBKDIMOHA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600047F")]
	[Cpp2IlInjected.Address(RVA = "0x6E0EB0", Offset = "0x6E00B0", VA = "0x1806E0EB0", Slot = "132")]
	public void NMDKIGJCKAP(object AJDBKDIMOHA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000480")]
	[Cpp2IlInjected.Address(RVA = "0x6E0EB0", Offset = "0x6E00B0", VA = "0x1806E0EB0", Slot = "133")]
	public void IGIJDOMADBN(object AJDBKDIMOHA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000481")]
	[Cpp2IlInjected.Address(RVA = "0x6E0EB0", Offset = "0x6E00B0", VA = "0x1806E0EB0", Slot = "134")]
	public void MDAEENKEECK(Vector3 BIOMHNNIJHG, ForceMode HODPBICIGJM = ForceMode.Force)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000482")]
	[Cpp2IlInjected.Address(RVA = "0x6E0EB0", Offset = "0x6E00B0", VA = "0x1806E0EB0", Slot = "135")]
	public void LIGCOMLMAAG(Vector3 BIOMHNNIJHG, Vector3 DACBJNCMNFL, ForceMode HODPBICIGJM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000483")]
	[Cpp2IlInjected.Address(RVA = "0x6E0EB0", Offset = "0x6E00B0", VA = "0x1806E0EB0", Slot = "136")]
	public void DPFOGKDMEOC(Vector3 CEBBAPNMMME, ForceMode HODPBICIGJM = ForceMode.Force)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000484")]
	[Cpp2IlInjected.Address(RVA = "0x6E0EB0", Offset = "0x6E00B0", VA = "0x1806E0EB0", Slot = "137")]
	public void BFACFHPBMFM(Vector3 CEBBAPNMMME, ForceMode HODPBICIGJM = ForceMode.Force)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000485")]
	[Cpp2IlInjected.Address(RVA = "0x5376710", Offset = "0x5375910", VA = "0x185376710", Slot = "138")]
	public bool CGHFGDDABEK(Vector3 HHOIMIMHDMP, out RaycastHit CFGLFCONCKN, float KMAOMDJLDEN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000486")]
	[Cpp2IlInjected.Address(RVA = "0x6E0EB0", Offset = "0x6E00B0", VA = "0x1806E0EB0", Slot = "139")]
	public void KEPOLBAFIFI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000487")]
	[Cpp2IlInjected.Address(RVA = "0x6C8B30", Offset = "0x6C7D30", VA = "0x1806C8B30")]
	public PEMCFGMEGMC()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000045")]
public sealed class LKOIEBFOHCO : DGHPEMNHGCH, MGDHAHFMJMO, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
	[Cpp2IlInjected.Token(Token = "0x4000083")]
	internal NFJEDPPAJMK ONBAMHPEIDG;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
	[Cpp2IlInjected.Token(Token = "0x4000084")]
	internal MCAEHJPOCLP ELHDNCHAHJE;

	[Cpp2IlInjected.Token(Token = "0x6000489")]
	[Cpp2IlInjected.Address(RVA = "0x536CBC0", Offset = "0x536BDC0", VA = "0x18536CBC0")]
	public LKOIEBFOHCO(GameObject OOKBNBHDPPG, RigidbodyEx CFNDHOOGKBI, CMKMIKBKOHM OBOKKBNADPB, in OALOFNDFAEL ONIBEFDCPGD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600048A")]
	[Cpp2IlInjected.Address(RVA = "0x536C520", Offset = "0x536B720", VA = "0x18536C520", Slot = "142")]
	protected override void FLDAICHOBKG(CMKMIKBKOHM OBOKKBNADPB, OALOFNDFAEL ONIBEFDCPGD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600048B")]
	[Cpp2IlInjected.Address(RVA = "0x536C390", Offset = "0x536B590", VA = "0x18536C390", Slot = "143")]
	public override void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600048C")]
	[Cpp2IlInjected.Address(RVA = "0x536CA30", Offset = "0x536BC30", VA = "0x18536CA30", Slot = "145")]
	public void OOBEJJLGKHO(LJKHPCCHKIO IAMOONJKNLF, LJKHPCCHKIO AFLEFPKENKF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600048D")]
	[Cpp2IlInjected.Address(RVA = "0x536CB00", Offset = "0x536BD00", VA = "0x18536CB00", Slot = "146")]
	public void PJEANDADBNP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600048E")]
	[Cpp2IlInjected.Address(RVA = "0x536C810", Offset = "0x536BA10", VA = "0x18536C810", Slot = "147")]
	public void IDMNFPEFOEM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600048F")]
	[Cpp2IlInjected.Address(RVA = "0x536C7B0", Offset = "0x536B9B0", VA = "0x18536C7B0", Slot = "148")]
	public void GCGBBMHMBBI(bool DMEOICFENFA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000490")]
	[Cpp2IlInjected.Address(RVA = "0x536C8D0", Offset = "0x536BAD0", VA = "0x18536C8D0", Slot = "149")]
	public bool MMLPMIJMFFO()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000491")]
	[Cpp2IlInjected.Address(RVA = "0x6E0EB0", Offset = "0x6E00B0", VA = "0x1806E0EB0", Slot = "144")]
	public override void FODBIMBAOBD()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000046")]
internal static class MCLADCKIOGP
{
	[Cpp2IlInjected.Token(Token = "0x6000492")]
	[Cpp2IlInjected.Address(RVA = "0x536F390", Offset = "0x536E590", VA = "0x18536F390")]
	public static DGHPEMNHGCH FIHMNOBDLAB(this PPMDIHPMNCG ONJEPBGIHBB)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000047")]
public interface NCOHPAGAOFB : HMOOAGCGLKM, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x6000493")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void FIMHIJJNHNG(PPMDIHPMNCG LDDCANHDBNB);

	[Cpp2IlInjected.Token(Token = "0x6000494")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void LNGINODJAIF(PPMDIHPMNCG LDDCANHDBNB);

	[Cpp2IlInjected.Token(Token = "0x6000495")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void PLMMLEJPFJC(PPMDIHPMNCG KPJMALENPJM);

	[Cpp2IlInjected.Token(Token = "0x6000496")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void IBABMBDNBHE(PPMDIHPMNCG KPJMALENPJM);
}
[Cpp2IlInjected.Token(Token = "0x2000048")]
public interface BEJNCHMIDMJ : NPFLLLAFPDM
{
	[Cpp2IlInjected.Token(Token = "0x17000130")]
	global::NBBJJOCKJND<PPMDIHPMNCG> LDACBKKKFLL
	{
		[Cpp2IlInjected.Token(Token = "0x6000497")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000131")]
	PPMDIHPMNCG MMCLEEKFDKC
	{
		[Cpp2IlInjected.Token(Token = "0x6000498")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000049")]
public interface HMBPIDNECOA : HEFJBMMENIM
{
	[Cpp2IlInjected.Token(Token = "0x6000499")]
	[Cpp2IlInjected.Address(Slot = "0")]
	(float, Vector3) PJKJFLIKEBB(Rigidbody MJNKCPJACPF);
}
[Cpp2IlInjected.Token(Token = "0x200004A")]
public interface CGEGJFCCOBC : LNJFNCEGNCA, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x17000132")]
	PhotonView KKFANKJJONE
	{
		[Cpp2IlInjected.Token(Token = "0x600049A")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x200004B")]
internal sealed class EGNDKGLFNBG : APGGGIKOMPN
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000085")]
	private readonly DGHPEMNHGCH LDDCANHDBNB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000086")]
	private CollisionDetectionMode IOFDDIABPHK;

	[Cpp2IlInjected.Token(Token = "0x17000133")]
	private Rigidbody BAPEKECGLDP
	{
		[Cpp2IlInjected.Token(Token = "0x600049B")]
		[Cpp2IlInjected.Address(RVA = "0x53500E0", Offset = "0x534F2E0", VA = "0x1853500E0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000134")]
	public CollisionDetectionMode CIEEKBNHEBL
	{
		[Cpp2IlInjected.Token(Token = "0x600049F")]
		[Cpp2IlInjected.Address(RVA = "0x53601C0", Offset = "0x535F3C0", VA = "0x1853601C0", Slot = "4")]
		get
		{
			return default(CollisionDetectionMode);
		}
		[Cpp2IlInjected.Token(Token = "0x60004A0")]
		[Cpp2IlInjected.Address(RVA = "0x53602D0", Offset = "0x535F4D0", VA = "0x1853602D0", Slot = "5")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600049C")]
	[Cpp2IlInjected.Address(RVA = "0x5358E70", Offset = "0x5358070", VA = "0x185358E70")]
	public EGNDKGLFNBG(PPMDIHPMNCG LDDCANHDBNB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600049D")]
	[Cpp2IlInjected.Address(RVA = "0x5360340", Offset = "0x535F540", VA = "0x185360340", Slot = "6")]
	public void BKOELLNKDDF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600049E")]
	[Cpp2IlInjected.Address(RVA = "0x53605E0", Offset = "0x535F7E0", VA = "0x1853605E0", Slot = "9")]
	public void JPMOLDGLNJO(Rigidbody AOAFHPHKFMD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004A1")]
	[Cpp2IlInjected.Address(RVA = "0x5360790", Offset = "0x535F990", VA = "0x185360790", Slot = "7")]
	public void NAIFDEINDCM(bool IOEMIKGMLIB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004A2")]
	[Cpp2IlInjected.Address(RVA = "0x53605D0", Offset = "0x535F7D0", VA = "0x1853605D0", Slot = "8")]
	public void HCJANJMAAPB(bool IOEMIKGMLIB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004A3")]
	[Cpp2IlInjected.Address(RVA = "0x5360460", Offset = "0x535F660", VA = "0x185360460", Slot = "10")]
	public bool CGHFGDDABEK(Vector3 HHOIMIMHDMP, out RaycastHit CFGLFCONCKN, float KMAOMDJLDEN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60004A4")]
	[Cpp2IlInjected.Address(RVA = "0x5360660", Offset = "0x535F860", VA = "0x185360660")]
	private void KAMCMADHFNP(bool IOEMIKGMLIB)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200004C")]
public sealed class OOFKHDCLCAK : ODGCKIECBJN, IDisposable, NLJGMJFEGHJ
{
	[Cpp2IlInjected.Token(Token = "0x4000087")]
	public const int DCMCDEDLNJN = 350;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000089")]
	private readonly DGHPEMNHGCH LDDCANHDBNB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400008A")]
	private PPGNAFCKNOL JHPIKONIGNI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400008B")]
	private GNJJFOIGADA OBNDLFADEDH;

	[Cpp2IlInjected.Token(Token = "0x17000135")]
	public PPGNAFCKNOL NHFAJHMDKMA
	{
		[Cpp2IlInjected.Token(Token = "0x60004A7")]
		[Cpp2IlInjected.Address(RVA = "0x53763F0", Offset = "0x53755F0", VA = "0x1853763F0", Slot = "6")]
		get
		{
			return default(PPGNAFCKNOL);
		}
		[Cpp2IlInjected.Token(Token = "0x60004A8")]
		[Cpp2IlInjected.Address(RVA = "0x5376530", Offset = "0x5375730", VA = "0x185376530", Slot = "7")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000136")]
	private Transform JBPFIGDCPFI
	{
		[Cpp2IlInjected.Token(Token = "0x60004A9")]
		[Cpp2IlInjected.Address(RVA = "0x5376370", Offset = "0x5375570", VA = "0x185376370", Slot = "10")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000041")]
	public event Action<LHLIDFNIOKA, LHLIDFNIOKA> GBMBMPKHBHO
	{
		[Cpp2IlInjected.Token(Token = "0x60004A5")]
		[Cpp2IlInjected.Address(RVA = "0x53762D0", Offset = "0x53754D0", VA = "0x1853762D0", Slot = "4")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60004A6")]
		[Cpp2IlInjected.Address(RVA = "0x5375F00", Offset = "0x5375100", VA = "0x185375F00", Slot = "5")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60004AA")]
	[Cpp2IlInjected.Address(RVA = "0x5376600", Offset = "0x5375800", VA = "0x185376600")]
	public OOFKHDCLCAK(PPMDIHPMNCG LDDCANHDBNB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004AB")]
	[Cpp2IlInjected.Address(RVA = "0x5375FA0", Offset = "0x53751A0", VA = "0x185375FA0", Slot = "8")]
	public void BKOELLNKDDF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004AC")]
	[Cpp2IlInjected.Address(RVA = "0x5376280", Offset = "0x5375480", VA = "0x185376280", Slot = "9")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004AD")]
	[Cpp2IlInjected.Address(RVA = "0x5376390", Offset = "0x5375590", VA = "0x185376390", Slot = "11")]
	private void HGFPJHEOKNN(LHLIDFNIOKA ELKALKBOHEP, LHLIDFNIOKA LBONJHPGLEG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004AE")]
	[Cpp2IlInjected.Address(RVA = "0x6E0EB0", Offset = "0x6E00B0", VA = "0x1806E0EB0", Slot = "12")]
	private void ICAEGOHLFCB(bool HFPGMHEIJMF)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200004D")]
internal sealed class BPBKHCGDCGI : FGHCKEELDLL
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400008C")]
	private readonly DGHPEMNHGCH LDDCANHDBNB;

	[Cpp2IlInjected.Token(Token = "0x17000137")]
	private Rigidbody BAPEKECGLDP
	{
		[Cpp2IlInjected.Token(Token = "0x60004AF")]
		[Cpp2IlInjected.Address(RVA = "0x53500E0", Offset = "0x534F2E0", VA = "0x1853500E0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000138")]
	private bool MBEHMAPDJBJ
	{
		[Cpp2IlInjected.Token(Token = "0x60004B0")]
		[Cpp2IlInjected.Address(RVA = "0x5358740", Offset = "0x5357940", VA = "0x185358740")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000139")]
	private bool DKNFKPAFDPB
	{
		[Cpp2IlInjected.Token(Token = "0x60004B1")]
		[Cpp2IlInjected.Address(RVA = "0x5357480", Offset = "0x5356680", VA = "0x185357480")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700013A")]
	private PPMDIHPMNCG EMIBHNNCMJC
	{
		[Cpp2IlInjected.Token(Token = "0x60004B2")]
		[Cpp2IlInjected.Address(RVA = "0x5358E10", Offset = "0x5358010", VA = "0x185358E10")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60004B3")]
	[Cpp2IlInjected.Address(RVA = "0x5358E70", Offset = "0x5358070", VA = "0x185358E70")]
	public BPBKHCGDCGI(PPMDIHPMNCG LDDCANHDBNB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004B4")]
	[Cpp2IlInjected.Address(RVA = "0x5358CB0", Offset = "0x5357EB0", VA = "0x185358CB0", Slot = "4")]
	public void MDAEENKEECK(Vector3 BIOMHNNIJHG, ForceMode HODPBICIGJM = ForceMode.Force)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004B5")]
	[Cpp2IlInjected.Address(RVA = "0x5358360", Offset = "0x5357560", VA = "0x185358360")]
	private void BIAOBHKBAEN(Vector3 BIOMHNNIJHG, ForceMode HODPBICIGJM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004B6")]
	[Cpp2IlInjected.Address(RVA = "0x5358A10", Offset = "0x5357C10", VA = "0x185358A10", Slot = "5")]
	public void LIGCOMLMAAG(Vector3 BIOMHNNIJHG, Vector3 DACBJNCMNFL, ForceMode HODPBICIGJM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004B7")]
	[Cpp2IlInjected.Address(RVA = "0x53585E0", Offset = "0x53577E0", VA = "0x1853585E0", Slot = "6")]
	public void DPFOGKDMEOC(Vector3 CEBBAPNMMME, ForceMode HODPBICIGJM = ForceMode.Force)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004B8")]
	[Cpp2IlInjected.Address(RVA = "0x5358790", Offset = "0x5357990", VA = "0x185358790")]
	private void KDJCKDGOEKH(Vector3 CEBBAPNMMME, ForceMode HODPBICIGJM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004B9")]
	[Cpp2IlInjected.Address(RVA = "0x53580E0", Offset = "0x53572E0", VA = "0x1853580E0", Slot = "7")]
	public void BFACFHPBMFM(Vector3 CEBBAPNMMME, ForceMode HODPBICIGJM = ForceMode.Force)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200004E")]
internal sealed class MDFIOOIOMLH : LMMEICEFKMM
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400008D")]
	private readonly DGHPEMNHGCH LDDCANHDBNB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400008E")]
	private bool POECKMPMDKM;

	[Cpp2IlInjected.Token(Token = "0x1700013B")]
	public bool HLADCICNJBO
	{
		[Cpp2IlInjected.Token(Token = "0x60004BB")]
		[Cpp2IlInjected.Address(RVA = "0x6E18D0", Offset = "0x6E0AD0", VA = "0x1806E18D0", Slot = "4")]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x60004BC")]
		[Cpp2IlInjected.Address(RVA = "0x536F3E0", Offset = "0x536E5E0", VA = "0x18536F3E0", Slot = "5")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60004BA")]
	[Cpp2IlInjected.Address(RVA = "0x5358E70", Offset = "0x5358070", VA = "0x185358E70")]
	public MDFIOOIOMLH(PPMDIHPMNCG LDDCANHDBNB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004BD")]
	[Cpp2IlInjected.Address(RVA = "0x536F4F0", Offset = "0x536E6F0", VA = "0x18536F4F0", Slot = "6")]
	public void JPMOLDGLNJO(Rigidbody AOAFHPHKFMD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004BE")]
	[Cpp2IlInjected.Address(RVA = "0x534E600", Offset = "0x534D800", VA = "0x18534E600", Slot = "7")]
	public void AAGPIEFPDDG(Rigidbody AOAFHPHKFMD)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200004F")]
internal sealed class HHJCEHPAGOM : NCOHPAGAOFB, HMOOAGCGLKM, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x4000098")]
	private readonly PPMDIHPMNCG LDDCANHDBNB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x4000099")]
	private readonly List<PPMDIHPMNCG> PLBLCMNMLJO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x400009A")]
	private PPMDIHPMNCG LBGMPPHBAAC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x400009B")]
	private PPMDIHPMNCG GPFONCECPBK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
	[Cpp2IlInjected.Token(Token = "0x400009C")]
	private Transform HGEGMMMECOK;

	[Cpp2IlInjected.Token(Token = "0x1700013C")]
	private Transform LNPNGFHHEEL
	{
		[Cpp2IlInjected.Token(Token = "0x60004D1")]
		[Cpp2IlInjected.Address(RVA = "0x53659F0", Offset = "0x5364BF0", VA = "0x1853659F0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700013D")]
	public PPMDIHPMNCG EMIBHNNCMJC
	{
		[Cpp2IlInjected.Token(Token = "0x60004D4")]
		[Cpp2IlInjected.Address(RVA = "0x6DD700", Offset = "0x6DC900", VA = "0x1806DD700", Slot = "28")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60004D5")]
		[Cpp2IlInjected.Address(RVA = "0x53672D0", Offset = "0x53664D0", VA = "0x1853672D0", Slot = "29")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700013E")]
	public PPMDIHPMNCG MDHMHFAIMJJ
	{
		[Cpp2IlInjected.Token(Token = "0x60004D6")]
		[Cpp2IlInjected.Address(RVA = "0x6DD780", Offset = "0x6DC980", VA = "0x1806DD780", Slot = "27")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700013F")]
	public IReadOnlyList<PPMDIHPMNCG> LILCAAEDFCG
	{
		[Cpp2IlInjected.Token(Token = "0x60004D7")]
		[Cpp2IlInjected.Address(RVA = "0x6DD770", Offset = "0x6DC970", VA = "0x1806DD770", Slot = "26")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000042")]
	public event JPOFABMOGOF KMPDHKDHBNO
	{
		[Cpp2IlInjected.Token(Token = "0x60004BF")]
		[Cpp2IlInjected.Address(RVA = "0x5366050", Offset = "0x5365250", VA = "0x185366050", Slot = "8")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60004C0")]
		[Cpp2IlInjected.Address(RVA = "0x53666B0", Offset = "0x53658B0", VA = "0x1853666B0", Slot = "9")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000043")]
	public event JPOFABMOGOF FIBPOODLACB
	{
		[Cpp2IlInjected.Token(Token = "0x60004C1")]
		[Cpp2IlInjected.Address(RVA = "0x5366FA0", Offset = "0x53661A0", VA = "0x185366FA0", Slot = "10")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60004C2")]
		[Cpp2IlInjected.Address(RVA = "0x5365DF0", Offset = "0x5364FF0", VA = "0x185365DF0", Slot = "11")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000044")]
	public event CBNHIOLMAOO LEBPAEACGHM
	{
		[Cpp2IlInjected.Token(Token = "0x60004C3")]
		[Cpp2IlInjected.Address(RVA = "0x53667F0", Offset = "0x53659F0", VA = "0x1853667F0", Slot = "12")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60004C4")]
		[Cpp2IlInjected.Address(RVA = "0x5366220", Offset = "0x5365420", VA = "0x185366220", Slot = "13")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000045")]
	public event Action FJCAMHJDHPJ
	{
		[Cpp2IlInjected.Token(Token = "0x60004C5")]
		[Cpp2IlInjected.Address(RVA = "0x5365A50", Offset = "0x5364C50", VA = "0x185365A50", Slot = "14")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60004C6")]
		[Cpp2IlInjected.Address(RVA = "0x5365950", Offset = "0x5364B50", VA = "0x185365950", Slot = "15")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000046")]
	public event Action CJALHGJOGOA
	{
		[Cpp2IlInjected.Token(Token = "0x60004C7")]
		[Cpp2IlInjected.Address(RVA = "0x53675D0", Offset = "0x53667D0", VA = "0x1853675D0", Slot = "16")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60004C8")]
		[Cpp2IlInjected.Address(RVA = "0x53662C0", Offset = "0x53654C0", VA = "0x1853662C0", Slot = "17")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000047")]
	public event Action<PPMDIHPMNCG> JIFKALNNAKN
	{
		[Cpp2IlInjected.Token(Token = "0x60004C9")]
		[Cpp2IlInjected.Address(RVA = "0x5366750", Offset = "0x5365950", VA = "0x185366750", Slot = "18")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60004CA")]
		[Cpp2IlInjected.Address(RVA = "0x53672E0", Offset = "0x53664E0", VA = "0x1853672E0", Slot = "19")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000048")]
	public event Action<PPMDIHPMNCG> DACGCLEDAOG
	{
		[Cpp2IlInjected.Token(Token = "0x60004CB")]
		[Cpp2IlInjected.Address(RVA = "0x5365FB0", Offset = "0x53651B0", VA = "0x185365FB0", Slot = "20")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60004CC")]
		[Cpp2IlInjected.Address(RVA = "0x5367040", Offset = "0x5366240", VA = "0x185367040", Slot = "21")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000049")]
	public event Action HEMJJFHJOBJ
	{
		[Cpp2IlInjected.Token(Token = "0x60004CD")]
		[Cpp2IlInjected.Address(RVA = "0x5365AF0", Offset = "0x5364CF0", VA = "0x185365AF0", Slot = "22")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60004CE")]
		[Cpp2IlInjected.Address(RVA = "0x5366F00", Offset = "0x5366100", VA = "0x185366F00", Slot = "23")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400004A")]
	public event Action<PPMDIHPMNCG> NDOMLKAOIDP
	{
		[Cpp2IlInjected.Token(Token = "0x60004CF")]
		[Cpp2IlInjected.Address(RVA = "0x5367230", Offset = "0x5366430", VA = "0x185367230", Slot = "24")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60004D0")]
		[Cpp2IlInjected.Address(RVA = "0x5365E90", Offset = "0x5365090", VA = "0x185365E90", Slot = "25")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60004D2")]
	[Cpp2IlInjected.Address(RVA = "0x5367670", Offset = "0x5366870", VA = "0x185367670")]
	public HHJCEHPAGOM(PPMDIHPMNCG LDDCANHDBNB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004D3")]
	[Cpp2IlInjected.Address(RVA = "0x5365F30", Offset = "0x5365130", VA = "0x185365F30", Slot = "31")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004D8")]
	[Cpp2IlInjected.Address(RVA = "0x5366890", Offset = "0x5365A90", VA = "0x185366890", Slot = "30")]
	public void KKGLFGKJMPP(PPMDIHPMNCG DPPABCPODHG, bool LMKLDOOIJAA = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004D9")]
	[Cpp2IlInjected.Address(RVA = "0x5367380", Offset = "0x5366580", VA = "0x185367380", Slot = "6")]
	public void PLMMLEJPFJC(PPMDIHPMNCG KPJMALENPJM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004DA")]
	[Cpp2IlInjected.Address(RVA = "0x5366360", Offset = "0x5365560", VA = "0x185366360", Slot = "7")]
	public void IBABMBDNBHE(PPMDIHPMNCG KPJMALENPJM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004DB")]
	[Cpp2IlInjected.Address(RVA = "0x53660F0", Offset = "0x53652F0", VA = "0x1853660F0", Slot = "4")]
	public void FIMHIJJNHNG(PPMDIHPMNCG LDDCANHDBNB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004DC")]
	[Cpp2IlInjected.Address(RVA = "0x5366E60", Offset = "0x5366060", VA = "0x185366E60", Slot = "5")]
	public void LNGINODJAIF(PPMDIHPMNCG LDDCANHDBNB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004DD")]
	[Cpp2IlInjected.Address(RVA = "0x5366190", Offset = "0x5365390", VA = "0x185366190")]
	private void HFLEBMEBODA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004DE")]
	[Cpp2IlInjected.Address(RVA = "0x5366E20", Offset = "0x5366020", VA = "0x185366E20")]
	private void KLFLFGBKAAA(PPMDIHPMNCG KPJMALENPJM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004DF")]
	[Cpp2IlInjected.Address(RVA = "0x53670E0", Offset = "0x53662E0", VA = "0x1853670E0")]
	private void NAPFPOANHMH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004E0")]
	[Cpp2IlInjected.Address(RVA = "0x5365CC0", Offset = "0x5364EC0", VA = "0x185365CC0")]
	private void COMAAFBCCFI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004E1")]
	[Cpp2IlInjected.Address(RVA = "0x5365B90", Offset = "0x5364D90", VA = "0x185365B90")]
	private void CMMLKAPMCHH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004E2")]
	[Cpp2IlInjected.Address(RVA = "0x53665C0", Offset = "0x53657C0", VA = "0x1853665C0")]
	[CompilerGenerated]
	private object IJNBMKEEBDG()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000050")]
internal static class NNOHNCOMOAM
{
	[Cpp2IlInjected.Token(Token = "0x60004E3")]
	[Cpp2IlInjected.Address(RVA = "0x53758E0", Offset = "0x5374AE0", VA = "0x1853758E0")]
	public static NCOHPAGAOFB NCKPBBOBINB(this PPMDIHPMNCG ONJEPBGIHBB)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000051")]
internal sealed class FBAJOCIIEEK : BEJNCHMIDMJ, NPFLLLAFPDM
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400009D")]
	private readonly DGHPEMNHGCH LDDCANHDBNB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400009E")]
	private readonly global::NBBJJOCKJND<PPMDIHPMNCG> AKMPOIOEOKM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400009F")]
	private bool BLKEPHABMHL;

	[Cpp2IlInjected.Token(Token = "0x17000140")]
	public global::NBBJJOCKJND<PPMDIHPMNCG> LDACBKKKFLL
	{
		[Cpp2IlInjected.Token(Token = "0x60004E4")]
		[Cpp2IlInjected.Address(RVA = "0x6C70C0", Offset = "0x6C62C0", VA = "0x1806C70C0", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000141")]
	public Vector3 DJHICJGOGJI
	{
		[Cpp2IlInjected.Token(Token = "0x60004E5")]
		[Cpp2IlInjected.Address(RVA = "0x5365170", Offset = "0x5364370", VA = "0x185365170", Slot = "6")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000142")]
	public Vector3 EOFHLAGNPII
	{
		[Cpp2IlInjected.Token(Token = "0x60004E6")]
		[Cpp2IlInjected.Address(RVA = "0x5365550", Offset = "0x5364750", VA = "0x185365550", Slot = "7")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000143")]
	private Vector3 MHCLHNEGJDD
	{
		[Cpp2IlInjected.Token(Token = "0x60004EA")]
		[Cpp2IlInjected.Address(RVA = "0x5364C80", Offset = "0x5363E80", VA = "0x185364C80")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000144")]
	public PPMDIHPMNCG MMCLEEKFDKC
	{
		[Cpp2IlInjected.Token(Token = "0x60004EB")]
		[Cpp2IlInjected.Address(RVA = "0x5365720", Offset = "0x5364920", VA = "0x185365720", Slot = "5")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60004E7")]
	[Cpp2IlInjected.Address(RVA = "0x53657D0", Offset = "0x53649D0", VA = "0x1853657D0")]
	public FBAJOCIIEEK(PPMDIHPMNCG LDDCANHDBNB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004E8")]
	[Cpp2IlInjected.Address(RVA = "0x5364D60", Offset = "0x5363F60", VA = "0x185364D60", Slot = "8")]
	public void CNAAFOJMHNK(PPMDIHPMNCG GPFONCECPBK, object AJDBKDIMOHA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004E9")]
	[Cpp2IlInjected.Address(RVA = "0x53651A0", Offset = "0x53643A0", VA = "0x1853651A0", Slot = "9")]
	public void JOEIIPCOBII(object AJDBKDIMOHA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004EC")]
	[Cpp2IlInjected.Address(RVA = "0x5365200", Offset = "0x5364400", VA = "0x185365200")]
	private Vector3 MIDPCEDMHPH()
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x60004ED")]
	[Cpp2IlInjected.Address(RVA = "0x5364DD0", Offset = "0x5363FD0", VA = "0x185364DD0")]
	private void GGLGADBIHJO(PPMDIHPMNCG IHBHHLCNEDN)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000052")]
internal static class LECNGFJJHHO
{
	[Cpp2IlInjected.Token(Token = "0x60004EE")]
	[Cpp2IlInjected.Address(RVA = "0x536BAD0", Offset = "0x536ACD0", VA = "0x18536BAD0")]
	public static BEJNCHMIDMJ BKCOHJDHGKA(this PPMDIHPMNCG ONJEPBGIHBB)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000053")]
internal sealed class IPENFEEMJLP : HMBPIDNECOA, HEFJBMMENIM
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000A1")]
	private readonly DGHPEMNHGCH LDDCANHDBNB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000A2")]
	private readonly OverridableVector3 PHKDOEMHFGP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40000A3")]
	private readonly OverridableVector3 EJHFMNHJBDB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x40000A4")]
	private float AKJJDFEANLD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x44")]
	[Cpp2IlInjected.Token(Token = "0x40000A5")]
	private float AKCBBGMHDDM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x40000A6")]
	private Vector3 MJDCNCPMNKH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x54")]
	[Cpp2IlInjected.Token(Token = "0x40000A7")]
	private Vector3? KNIHAMHGBLN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x64")]
	[Cpp2IlInjected.Token(Token = "0x40000A8")]
	private Quaternion? OPONCDOPJKK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
	[Cpp2IlInjected.Token(Token = "0x40000A9")]
	private bool OAEHJNDBHFG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x79")]
	[Cpp2IlInjected.Token(Token = "0x40000AA")]
	private bool GHIIFJIIIEC;

	[Cpp2IlInjected.Token(Token = "0x17000145")]
	public Vector3 JMIIJDMAMEI
	{
		[Cpp2IlInjected.Token(Token = "0x60004F1")]
		[Cpp2IlInjected.Address(RVA = "0x127CAE0", Offset = "0x127BCE0", VA = "0x18127CAE0", Slot = "7")]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x60004F2")]
		[Cpp2IlInjected.Address(RVA = "0x5369A30", Offset = "0x5368C30", VA = "0x185369A30", Slot = "8")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000146")]
	public Vector3 PMKFGPJNJBI
	{
		[Cpp2IlInjected.Token(Token = "0x60004F3")]
		[Cpp2IlInjected.Address(RVA = "0x53692D0", Offset = "0x53684D0", VA = "0x1853692D0", Slot = "9")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000147")]
	public float KLNDCEHFMBA
	{
		[Cpp2IlInjected.Token(Token = "0x60004F4")]
		[Cpp2IlInjected.Address(RVA = "0x1502500", Offset = "0x1501700", VA = "0x181502500", Slot = "10")]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x60004F5")]
		[Cpp2IlInjected.Address(RVA = "0x53693D0", Offset = "0x53685D0", VA = "0x1853693D0")]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000148")]
	public float NBJLLACMBLF
	{
		[Cpp2IlInjected.Token(Token = "0x60004F6")]
		[Cpp2IlInjected.Address(RVA = "0x1186C50", Offset = "0x1185E50", VA = "0x181186C50", Slot = "11")]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x60004F7")]
		[Cpp2IlInjected.Address(RVA = "0x5369870", Offset = "0x5368A70", VA = "0x185369870", Slot = "12")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000149")]
	public Vector3 OFFHJCCLOEB
	{
		[Cpp2IlInjected.Token(Token = "0x60004F8")]
		[Cpp2IlInjected.Address(RVA = "0x5369660", Offset = "0x5368860", VA = "0x185369660", Slot = "13")]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x60004F9")]
		[Cpp2IlInjected.Address(RVA = "0x5369890", Offset = "0x5368A90", VA = "0x185369890", Slot = "14")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700014A")]
	public Quaternion MOMBOPJMDMK
	{
		[Cpp2IlInjected.Token(Token = "0x60004FA")]
		[Cpp2IlInjected.Address(RVA = "0x53694F0", Offset = "0x53686F0", VA = "0x1853694F0", Slot = "15")]
		get
		{
			return default(Quaternion);
		}
		[Cpp2IlInjected.Token(Token = "0x60004FB")]
		[Cpp2IlInjected.Address(RVA = "0x5369AF0", Offset = "0x5368CF0", VA = "0x185369AF0", Slot = "16")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700014B")]
	private Rigidbody BAPEKECGLDP
	{
		[Cpp2IlInjected.Token(Token = "0x6000503")]
		[Cpp2IlInjected.Address(RVA = "0x536B8C0", Offset = "0x536AAC0", VA = "0x18536B8C0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400004B")]
	public event JPOFABMOGOF GOMGJPJMHIM
	{
		[Cpp2IlInjected.Token(Token = "0x60004EF")]
		[Cpp2IlInjected.Address(RVA = "0x53697D0", Offset = "0x53689D0", VA = "0x1853697D0", Slot = "5")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60004F0")]
		[Cpp2IlInjected.Address(RVA = "0x5369A50", Offset = "0x5368C50", VA = "0x185369A50", Slot = "6")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60004FC")]
	[Cpp2IlInjected.Address(RVA = "0x536B910", Offset = "0x536AB10", VA = "0x18536B910")]
	public IPENFEEMJLP(PPMDIHPMNCG LDDCANHDBNB, in OALOFNDFAEL ONIBEFDCPGD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004FD")]
	[Cpp2IlInjected.Address(RVA = "0x536A5F0", Offset = "0x53697F0", VA = "0x18536A5F0", Slot = "18")]
	public void OCCLJJBDHKH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004FE")]
	[Cpp2IlInjected.Address(RVA = "0x536A230", Offset = "0x5369430", VA = "0x18536A230", Slot = "17")]
	public void LGMIOPKMACL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004FF")]
	[Cpp2IlInjected.Address(RVA = "0x5369C90", Offset = "0x5368E90", VA = "0x185369C90", Slot = "20")]
	public void JPMOLDGLNJO(Rigidbody AOAFHPHKFMD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000500")]
	[Cpp2IlInjected.Address(RVA = "0x5368F40", Offset = "0x5368140", VA = "0x185368F40", Slot = "21")]
	public void AAGPIEFPDDG(Rigidbody AOAFHPHKFMD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000501")]
	[Cpp2IlInjected.Address(RVA = "0x536A7B0", Offset = "0x53699B0", VA = "0x18536A7B0", Slot = "19")]
	public void PGLMPJOADGG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000502")]
	[Cpp2IlInjected.Address(RVA = "0x5369D70", Offset = "0x5368F70", VA = "0x185369D70", Slot = "22")]
	public void KEPOLBAFIFI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000504")]
	[Cpp2IlInjected.Address(RVA = "0x5369A30", Offset = "0x5368C30", VA = "0x185369A30")]
	private void HBJMIFMDHJH(Vector3 JFBPNBNBHOE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000505")]
	[Cpp2IlInjected.Address(RVA = "0x53691E0", Offset = "0x53683E0", VA = "0x1853691E0")]
	private Vector3 BCKCCAMLFFB()
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000506")]
	[Cpp2IlInjected.Address(RVA = "0x53693D0", Offset = "0x53685D0", VA = "0x1853693D0")]
	private void CGGJFFODFCK(float JFBPNBNBHOE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000507")]
	[Cpp2IlInjected.Address(RVA = "0x5369870", Offset = "0x5368A70", VA = "0x185369870")]
	private void FPOBCCILBBI(float JFBPNBNBHOE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000508")]
	[Cpp2IlInjected.Address(RVA = "0x536A310", Offset = "0x5369510", VA = "0x18536A310")]
	private Vector3 LIHAPOLOMJO()
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000509")]
	[Cpp2IlInjected.Address(RVA = "0x5369890", Offset = "0x5368A90", VA = "0x185369890")]
	private void IPFFPNBFENN(Vector3 JFBPNBNBHOE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600050A")]
	[Cpp2IlInjected.Address(RVA = "0x536A490", Offset = "0x5369690", VA = "0x18536A490")]
	private Quaternion MFJCLLLJOKO()
	{
		return default(Quaternion);
	}

	[Cpp2IlInjected.Token(Token = "0x600050B")]
	[Cpp2IlInjected.Address(RVA = "0x5369AF0", Offset = "0x5368CF0", VA = "0x185369AF0")]
	private void KKICMMPIOEM(Quaternion JFBPNBNBHOE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600050C")]
	[Cpp2IlInjected.Address(RVA = "0x536A920", Offset = "0x5369B20", VA = "0x18536A920")]
	public void PJKJFLIKEBB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600050D")]
	[Cpp2IlInjected.Address(RVA = "0x536AA00", Offset = "0x5369C00", VA = "0x18536AA00", Slot = "4")]
	public (float, Vector3) PJKJFLIKEBB(Rigidbody MJNKCPJACPF)
	{
		return default((float, Vector3));
	}
}
[Cpp2IlInjected.Token(Token = "0x2000054")]
internal static class BKJDAKJGAIN
{
	[Cpp2IlInjected.Token(Token = "0x600050E")]
	[Cpp2IlInjected.Address(RVA = "0x5358020", Offset = "0x5357220", VA = "0x185358020")]
	public static HMBPIDNECOA NDHEADMHLHM(this PPMDIHPMNCG ONJEPBGIHBB)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000055")]
internal sealed class PFECHJFDADA : EBCDLOKEBCP
{
	[Cpp2IlInjected.Token(Token = "0x40000AB")]
	private const string EMNENHPAIJN = "INTERP_PAUSE";

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000AC")]
	private readonly DGHPEMNHGCH LDDCANHDBNB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000AD")]
	private readonly JMMOMAJEGFM GBHDENEOGJP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000AE")]
	private readonly GDPCJHNBEPD DDCLGMJNJFL;

	[Cpp2IlInjected.Token(Token = "0x1700014C")]
	public bool FKLEIIKAOJF
	{
		[Cpp2IlInjected.Token(Token = "0x600050F")]
		[Cpp2IlInjected.Address(RVA = "0x11D4DD0", Offset = "0x11D3FD0", VA = "0x1811D4DD0", Slot = "4")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700014D")]
	public GDPCJHNBEPD MDBJGCBLKKA
	{
		[Cpp2IlInjected.Token(Token = "0x6000510")]
		[Cpp2IlInjected.Address(RVA = "0x6C7010", Offset = "0x6C6210", VA = "0x1806C7010", Slot = "5")]
		get
		{
			return default(GDPCJHNBEPD);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000511")]
	[Cpp2IlInjected.Address(RVA = "0x6409980", Offset = "0x6408B80", VA = "0x186409980")]
	public PFECHJFDADA(PPMDIHPMNCG LDDCANHDBNB, in OALOFNDFAEL ONIBEFDCPGD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000512")]
	[Cpp2IlInjected.Address(RVA = "0x6409450", Offset = "0x6408650", VA = "0x186409450", Slot = "6")]
	public void BKOELLNKDDF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000513")]
	[Cpp2IlInjected.Address(RVA = "0x6409520", Offset = "0x6408720", VA = "0x186409520")]
	private bool EIPAKAFJFHC()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000514")]
	[Cpp2IlInjected.Address(RVA = "0x64098E0", Offset = "0x6408AE0", VA = "0x1864098E0", Slot = "7")]
	public void MPHPJCHHDKL(object AJDBKDIMOHA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000515")]
	[Cpp2IlInjected.Address(RVA = "0x6409910", Offset = "0x6408B10", VA = "0x186409910", Slot = "8")]
	public void NEGAEOLBLHL(object AJDBKDIMOHA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000516")]
	[Cpp2IlInjected.Address(RVA = "0x64095C0", Offset = "0x64087C0", VA = "0x1864095C0", Slot = "11")]
	public void HIJAJPCLBLB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000517")]
	[Cpp2IlInjected.Address(RVA = "0x64096F0", Offset = "0x64088F0", VA = "0x1864096F0")]
	private void KDHHGDDDAKA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000518")]
	[Cpp2IlInjected.Address(RVA = "0x6409800", Offset = "0x6408A00", VA = "0x186409800")]
	private void MCILODDNPMG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000519")]
	[Cpp2IlInjected.Address(RVA = "0x6409940", Offset = "0x6408B40", VA = "0x186409940", Slot = "10")]
	public void ONIPMDLLNFC(PPMDIHPMNCG LDDCANHDBNB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600051A")]
	[Cpp2IlInjected.Address(RVA = "0x6409410", Offset = "0x6408610", VA = "0x186409410", Slot = "9")]
	public void BKKMBNFHKCE(PPMDIHPMNCG LDDCANHDBNB)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000056")]
internal sealed class ELFMPBBIGAC : GAMBABDLKNB
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000B0")]
	private readonly DGHPEMNHGCH LDDCANHDBNB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000B1")]
	private readonly JMMOMAJEGFM JFAMPJPIJMM;

	[Cpp2IlInjected.Token(Token = "0x1700014E")]
	public bool MBEHMAPDJBJ
	{
		[Cpp2IlInjected.Token(Token = "0x600051D")]
		[Cpp2IlInjected.Address(RVA = "0x5361860", Offset = "0x5360A60", VA = "0x185361860", Slot = "6")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700014F")]
	public IEnumerable<object> EKIDKKGDMDH
	{
		[Cpp2IlInjected.Token(Token = "0x600051E")]
		[Cpp2IlInjected.Address(RVA = "0x5361B20", Offset = "0x5360D20", VA = "0x185361B20", Slot = "7")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400004C")]
	public event JPOFABMOGOF JDAOGMBMFNA
	{
		[Cpp2IlInjected.Token(Token = "0x600051B")]
		[Cpp2IlInjected.Address(RVA = "0x5361920", Offset = "0x5360B20", VA = "0x185361920", Slot = "4")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600051C")]
		[Cpp2IlInjected.Address(RVA = "0x53617B0", Offset = "0x53609B0", VA = "0x1853617B0", Slot = "5")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600051F")]
	[Cpp2IlInjected.Address(RVA = "0x5361C40", Offset = "0x5360E40", VA = "0x185361C40")]
	public ELFMPBBIGAC(PPMDIHPMNCG LDDCANHDBNB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000520")]
	[Cpp2IlInjected.Address(RVA = "0x5361750", Offset = "0x5360950", VA = "0x185361750", Slot = "11")]
	public IDisposable BFJJEOKEAOO()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000521")]
	[Cpp2IlInjected.Address(RVA = "0x53619C0", Offset = "0x5360BC0", VA = "0x1853619C0", Slot = "8")]
	public void IDBKKNHMJCA(object AJDBKDIMOHA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000522")]
	[Cpp2IlInjected.Address(RVA = "0x5361850", Offset = "0x5360A50", VA = "0x185361850", Slot = "9")]
	public void BPLEOILKCFF(object AJDBKDIMOHA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000523")]
	[Cpp2IlInjected.Address(RVA = "0x5361B40", Offset = "0x5360D40", VA = "0x185361B40", Slot = "10")]
	public void NHDILIPFEBO(object AJDBKDIMOHA, bool NMHFDHPJGFL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000524")]
	[Cpp2IlInjected.Address(RVA = "0x5361AA0", Offset = "0x5360CA0", VA = "0x185361AA0", Slot = "12")]
	public void JPMOLDGLNJO(Rigidbody IHFIBCKLILB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000525")]
	[Cpp2IlInjected.Address(RVA = "0x5361720", Offset = "0x5360920", VA = "0x185361720", Slot = "13")]
	public void AAGPIEFPDDG(Rigidbody AOAFHPHKFMD)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000057")]
internal sealed class IDOEAHBJPNN : CGEGJFCCOBC, LNJFNCEGNCA, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000B3")]
	private readonly DGHPEMNHGCH LDDCANHDBNB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000B4")]
	private PhotonView CAIDBGJNFEP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40000B5")]
	private bool PJIOPPPFOBH;

	[Cpp2IlInjected.Token(Token = "0x17000150")]
	public PhotonView KKFANKJJONE
	{
		[Cpp2IlInjected.Token(Token = "0x6000528")]
		[Cpp2IlInjected.Address(RVA = "0x6C8120", Offset = "0x6C7320", VA = "0x1806C8120", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000151")]
	public bool PJPIAHDKHLD
	{
		[Cpp2IlInjected.Token(Token = "0x6000529")]
		[Cpp2IlInjected.Address(RVA = "0x5360C10", Offset = "0x535FE10", VA = "0x185360C10", Slot = "7")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000152")]
	public bool EMGPBBGPGIE
	{
		[Cpp2IlInjected.Token(Token = "0x600052A")]
		[Cpp2IlInjected.Address(RVA = "0x7B7F80", Offset = "0x7B7180", VA = "0x1807B7F80", Slot = "8")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400004D")]
	public event JPOFABMOGOF OFDNMEKJKBP
	{
		[Cpp2IlInjected.Token(Token = "0x6000526")]
		[Cpp2IlInjected.Address(RVA = "0x5368340", Offset = "0x5367540", VA = "0x185368340", Slot = "5")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000527")]
		[Cpp2IlInjected.Address(RVA = "0x5367FB0", Offset = "0x53671B0", VA = "0x185367FB0", Slot = "6")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600052B")]
	[Cpp2IlInjected.Address(RVA = "0x53683E0", Offset = "0x53675E0", VA = "0x1853683E0")]
	public IDOEAHBJPNN(PPMDIHPMNCG LDDCANHDBNB, in OALOFNDFAEL ONIBEFDCPGD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600052C")]
	[Cpp2IlInjected.Address(RVA = "0x53677B0", Offset = "0x53669B0", VA = "0x1853677B0", Slot = "9")]
	public void BKOELLNKDDF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600052D")]
	[Cpp2IlInjected.Address(RVA = "0x5367A90", Offset = "0x5366C90", VA = "0x185367A90", Slot = "12")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600052E")]
	[Cpp2IlInjected.Address(RVA = "0x5367E20", Offset = "0x5367020", VA = "0x185367E20", Slot = "10")]
	public void EDMPHFFCDKG(PPMDIHPMNCG GPFONCECPBK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600052F")]
	[Cpp2IlInjected.Address(RVA = "0x5367900", Offset = "0x5366B00", VA = "0x185367900", Slot = "11")]
	public void CLFEMCONLMI(PPMDIHPMNCG GPFONCECPBK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000530")]
	[Cpp2IlInjected.Address(RVA = "0x53681C0", Offset = "0x53673C0", VA = "0x1853681C0")]
	private void JIANJEKONCC(PhotonView MBHHONACMIO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000531")]
	[Cpp2IlInjected.Address(RVA = "0x5368050", Offset = "0x5367250", VA = "0x185368050")]
	private void IEJGPNIHMFH(RigidbodyEx KEPNDNMPIMB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000532")]
	[Cpp2IlInjected.Address(RVA = "0x5367BA0", Offset = "0x5366DA0", VA = "0x185367BA0")]
	private void EDLABONOLPP(PhotonView PEDIMHHLKDL)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000058")]
internal static class AKMBJBHHOPN
{
	[Cpp2IlInjected.Token(Token = "0x6000533")]
	[Cpp2IlInjected.Address(RVA = "0x5355AC0", Offset = "0x5354CC0", VA = "0x185355AC0")]
	public static CGEGJFCCOBC NBAAFMOGNIN(this PPMDIHPMNCG ONJEPBGIHBB)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000059")]
internal sealed class AGJDEEHBHOA : OIAJBEDDNGM
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000B6")]
	private readonly DGHPEMNHGCH LDDCANHDBNB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000B7")]
	private RigidbodyConstraints AGPNLEHNBIO;

	[Cpp2IlInjected.Token(Token = "0x17000153")]
	public bool PJGCDNLPGAK
	{
		[Cpp2IlInjected.Token(Token = "0x6000534")]
		[Cpp2IlInjected.Address(RVA = "0xA49B90", Offset = "0xA48D90", VA = "0x180A49B90", Slot = "4")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000535")]
		[Cpp2IlInjected.Address(RVA = "0x1D15510", Offset = "0x1D14710", VA = "0x181D15510", Slot = "5")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000154")]
	public bool AGHKJBONNGE
	{
		[Cpp2IlInjected.Token(Token = "0x6000536")]
		[Cpp2IlInjected.Address(RVA = "0x267F900", Offset = "0x267EB00", VA = "0x18267F900", Slot = "6")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000537")]
		[Cpp2IlInjected.Address(RVA = "0x267F8F0", Offset = "0x267EAF0", VA = "0x18267F8F0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000155")]
	public RigidbodyConstraints BCMJAHAELOH
	{
		[Cpp2IlInjected.Token(Token = "0x6000538")]
		[Cpp2IlInjected.Address(RVA = "0x6C8BD0", Offset = "0x6C7DD0", VA = "0x1806C8BD0", Slot = "7")]
		get
		{
			return default(RigidbodyConstraints);
		}
		[Cpp2IlInjected.Token(Token = "0x6000539")]
		[Cpp2IlInjected.Address(RVA = "0x5353950", Offset = "0x5352B50", VA = "0x185353950", Slot = "8")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600053A")]
	[Cpp2IlInjected.Address(RVA = "0x5353A90", Offset = "0x5352C90", VA = "0x185353A90")]
	public AGJDEEHBHOA(PPMDIHPMNCG LDDCANHDBNB, in OALOFNDFAEL ONIBEFDCPGD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600053B")]
	[Cpp2IlInjected.Address(RVA = "0x5353920", Offset = "0x5352B20", VA = "0x185353920", Slot = "9")]
	public void JPMOLDGLNJO(Rigidbody AOAFHPHKFMD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600053C")]
	[Cpp2IlInjected.Address(RVA = "0x53538F0", Offset = "0x5352AF0", VA = "0x1853538F0", Slot = "10")]
	public void AAGPIEFPDDG(Rigidbody AOAFHPHKFMD)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200005A")]
internal sealed class MFHGEJLHHAC : KKCAAHMNCAO
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000BA")]
	private readonly PPMDIHPMNCG LDDCANHDBNB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000BB")]
	private float CGCJGLPPNGH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
	[Cpp2IlInjected.Token(Token = "0x40000BC")]
	private float PIFJIAIFNLJ;

	[Cpp2IlInjected.Token(Token = "0x17000156")]
	public float FCGOFCPMIGL
	{
		[Cpp2IlInjected.Token(Token = "0x600053E")]
		[Cpp2IlInjected.Address(RVA = "0x1281E70", Offset = "0x1281070", VA = "0x181281E70", Slot = "4")]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x600053F")]
		[Cpp2IlInjected.Address(RVA = "0x536F610", Offset = "0x536E810", VA = "0x18536F610", Slot = "5")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000157")]
	public float CFMIJLIHCIE
	{
		[Cpp2IlInjected.Token(Token = "0x6000540")]
		[Cpp2IlInjected.Address(RVA = "0x1281E60", Offset = "0x1281060", VA = "0x181281E60", Slot = "6")]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x6000541")]
		[Cpp2IlInjected.Address(RVA = "0x536F6E0", Offset = "0x536E8E0", VA = "0x18536F6E0", Slot = "7")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600053D")]
	[Cpp2IlInjected.Address(RVA = "0x536F7B0", Offset = "0x536E9B0", VA = "0x18536F7B0")]
	public MFHGEJLHHAC(PPMDIHPMNCG LDDCANHDBNB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000542")]
	[Cpp2IlInjected.Address(RVA = "0x536F5C0", Offset = "0x536E7C0", VA = "0x18536F5C0", Slot = "8")]
	public void JPMOLDGLNJO(Rigidbody AOAFHPHKFMD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000543")]
	[Cpp2IlInjected.Address(RVA = "0x536F520", Offset = "0x536E720", VA = "0x18536F520", Slot = "9")]
	public void AAGPIEFPDDG(Rigidbody AOAFHPHKFMD)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200005B")]
internal sealed class NJCALLHGHJH : BBGIBEMMCOA
{
	[Cpp2IlInjected.Token(Token = "0x40000BD")]
	private const int GKPFGIIGOEG = 10;

	[Cpp2IlInjected.Token(Token = "0x40000BE")]
	private const float AAMHOIOCMGO = 9E-05f;

	[Cpp2IlInjected.Token(Token = "0x40000BF")]
	private const float CLBDJGNMOIE = 0.0001f;

	[Cpp2IlInjected.Token(Token = "0x40000C0")]
	private const float FBHPIPCOGEF = 5f;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000C2")]
	private readonly DGHPEMNHGCH LDDCANHDBNB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000C3")]
	private bool NLJCKFDIEEH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x21")]
	[Cpp2IlInjected.Token(Token = "0x40000C4")]
	private bool OHLFBJIBOLI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
	[Cpp2IlInjected.Token(Token = "0x40000C5")]
	private int JALMONHGNMA;

	[Cpp2IlInjected.Token(Token = "0x17000158")]
	private Rigidbody BAPEKECGLDP
	{
		[Cpp2IlInjected.Token(Token = "0x6000546")]
		[Cpp2IlInjected.Address(RVA = "0x536B8C0", Offset = "0x536AAC0", VA = "0x18536B8C0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000159")]
	private bool HCMEHANPHNC
	{
		[Cpp2IlInjected.Token(Token = "0x6000547")]
		[Cpp2IlInjected.Address(RVA = "0x5374340", Offset = "0x5373540", VA = "0x185374340")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700015A")]
	private bool NFEEOKFPIGD
	{
		[Cpp2IlInjected.Token(Token = "0x6000548")]
		[Cpp2IlInjected.Address(RVA = "0x53745C0", Offset = "0x53737C0", VA = "0x1853745C0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700015B")]
	private PPMDIHPMNCG EMIBHNNCMJC
	{
		[Cpp2IlInjected.Token(Token = "0x6000549")]
		[Cpp2IlInjected.Address(RVA = "0x5374C90", Offset = "0x5373E90", VA = "0x185374C90")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700015C")]
	private bool DKNFKPAFDPB
	{
		[Cpp2IlInjected.Token(Token = "0x600054A")]
		[Cpp2IlInjected.Address(RVA = "0x53743E0", Offset = "0x53735E0", VA = "0x1853743E0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400004E")]
	public event JPOFABMOGOF MLDKIENLGJG
	{
		[Cpp2IlInjected.Token(Token = "0x6000544")]
		[Cpp2IlInjected.Address(RVA = "0x5374480", Offset = "0x5373680", VA = "0x185374480", Slot = "4")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000545")]
		[Cpp2IlInjected.Address(RVA = "0x53740F0", Offset = "0x53732F0", VA = "0x1853740F0", Slot = "5")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600054B")]
	[Cpp2IlInjected.Address(RVA = "0x5374CF0", Offset = "0x5373EF0", VA = "0x185374CF0")]
	public NJCALLHGHJH(PPMDIHPMNCG LDDCANHDBNB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600054C")]
	[Cpp2IlInjected.Address(RVA = "0x5374060", Offset = "0x5373260", VA = "0x185374060", Slot = "6")]
	public void BKOELLNKDDF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600054D")]
	[Cpp2IlInjected.Address(RVA = "0x5374050", Offset = "0x5373250", VA = "0x185374050", Slot = "8")]
	public void ABJCFICOBMJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600054E")]
	[Cpp2IlInjected.Address(RVA = "0x5374680", Offset = "0x5373880", VA = "0x185374680", Slot = "7")]
	public bool JLGKLAGDNBA()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600054F")]
	[Cpp2IlInjected.Address(RVA = "0x5374520", Offset = "0x5373720", VA = "0x185374520", Slot = "9")]
	public void HFOIEEGNPME()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000550")]
	[Cpp2IlInjected.Address(RVA = "0x53745E0", Offset = "0x53737E0", VA = "0x1853745E0", Slot = "11")]
	public void IPODHJMCCPD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000551")]
	[Cpp2IlInjected.Address(RVA = "0x5374440", Offset = "0x5373640", VA = "0x185374440", Slot = "12")]
	public void GCGBBMHMBBI(bool DMEOICFENFA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000552")]
	[Cpp2IlInjected.Address(RVA = "0x5374960", Offset = "0x5373B60", VA = "0x185374960", Slot = "10")]
	public void LHCKEPPOJKM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000553")]
	[Cpp2IlInjected.Address(RVA = "0x5374190", Offset = "0x5373390", VA = "0x185374190")]
	private bool DBMAMKHOENP()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000554")]
	[Cpp2IlInjected.Address(RVA = "0x53747D0", Offset = "0x53739D0", VA = "0x1853747D0")]
	private void JOHNGPOIGFH()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200005C")]
internal sealed class PEMHEEMLFEL : HONAINACCHA
{
	[Cpp2IlInjected.Token(Token = "0x40000C6")]
	private const string MEJHJGGIKBM = "RBEX_ANIM";

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000C7")]
	private readonly DGHPEMNHGCH LDDCANHDBNB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000C8")]
	private readonly JMMOMAJEGFM FBGDDLNIIEO;

	[Cpp2IlInjected.Token(Token = "0x1700015D")]
	public Rigidbody BAPEKECGLDP
	{
		[Cpp2IlInjected.Token(Token = "0x6000555")]
		[Cpp2IlInjected.Address(RVA = "0x6C8120", Offset = "0x6C7320", VA = "0x1806C8120", Slot = "4")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000556")]
		[Cpp2IlInjected.Address(RVA = "0x6C8130", Offset = "0x6C7330", VA = "0x1806C8130")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700015E")]
	private bool DKNFKPAFDPB
	{
		[Cpp2IlInjected.Token(Token = "0x6000557")]
		[Cpp2IlInjected.Address(RVA = "0x5357480", Offset = "0x5356680", VA = "0x185357480")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000558")]
	[Cpp2IlInjected.Address(RVA = "0x5377780", Offset = "0x5376980", VA = "0x185377780")]
	public PEMHEEMLFEL(PPMDIHPMNCG LDDCANHDBNB, in OALOFNDFAEL ONIBEFDCPGD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000559")]
	[Cpp2IlInjected.Address(RVA = "0x5376910", Offset = "0x5375B10", VA = "0x185376910", Slot = "5")]
	public void BKOELLNKDDF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600055A")]
	[Cpp2IlInjected.Address(RVA = "0x53773F0", Offset = "0x53765F0", VA = "0x1853773F0", Slot = "6")]
	public void NMDKIGJCKAP(object AJDBKDIMOHA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600055B")]
	[Cpp2IlInjected.Address(RVA = "0x5376D70", Offset = "0x5375F70", VA = "0x185376D70", Slot = "7")]
	public void IGIJDOMADBN(object AJDBKDIMOHA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600055C")]
	[Cpp2IlInjected.Address(RVA = "0x5377420", Offset = "0x5376620", VA = "0x185377420", Slot = "8")]
	public void OHCCCGHNBBD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600055D")]
	[Cpp2IlInjected.Address(RVA = "0x5376B70", Offset = "0x5375D70", VA = "0x185376B70", Slot = "9")]
	public void GGGGLIFJEPO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600055E")]
	[Cpp2IlInjected.Address(RVA = "0x5376790", Offset = "0x5375990", VA = "0x185376790", Slot = "10")]
	public void AELIAEFBMCN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600055F")]
	[Cpp2IlInjected.Address(RVA = "0x5376DA0", Offset = "0x5375FA0", VA = "0x185376DA0", Slot = "11")]
	public void JNJCHBBCJEP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000560")]
	[Cpp2IlInjected.Address(RVA = "0x5377240", Offset = "0x5376440", VA = "0x185377240")]
	private void LCKBPKDNOGE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000561")]
	[Cpp2IlInjected.Address(RVA = "0x53769C0", Offset = "0x5375BC0", VA = "0x1853769C0")]
	private void CHFOKHDGJOD()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200005D")]
internal sealed class EOCPBOGNKBE : MPILPIJAHDO, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000CA")]
	private readonly DGHPEMNHGCH LDDCANHDBNB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000CB")]
	private readonly JMMOMAJEGFM GCFNKFOFOPM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000CC")]
	private float IPNBPHLAFFC;

	[Cpp2IlInjected.Token(Token = "0x1700015F")]
	public LKKOPIEOHJA OLDOEMJHCAC
	{
		[Cpp2IlInjected.Token(Token = "0x6000562")]
		[Cpp2IlInjected.Address(RVA = "0x6E18E0", Offset = "0x6E0AE0", VA = "0x1806E18E0", Slot = "4")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000563")]
		[Cpp2IlInjected.Address(RVA = "0x7091C0", Offset = "0x7083C0", VA = "0x1807091C0", Slot = "5")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000160")]
	public FDHNJKMJJJG AEPCDANKKNF
	{
		[Cpp2IlInjected.Token(Token = "0x6000564")]
		[Cpp2IlInjected.Address(RVA = "0x6DD6F0", Offset = "0x6DC8F0", VA = "0x1806DD6F0", Slot = "6")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000565")]
		[Cpp2IlInjected.Address(RVA = "0x75FAE0", Offset = "0x75ECE0", VA = "0x18075FAE0", Slot = "7")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000161")]
	public Vector3 MHCLHNEGJDD
	{
		[Cpp2IlInjected.Token(Token = "0x6000566")]
		[Cpp2IlInjected.Address(RVA = "0x5362200", Offset = "0x5361400", VA = "0x185362200", Slot = "8")]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x6000567")]
		[Cpp2IlInjected.Address(RVA = "0x53635B0", Offset = "0x53627B0", VA = "0x1853635B0", Slot = "9")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000162")]
	public Vector3 JMJCCDADJPC
	{
		[Cpp2IlInjected.Token(Token = "0x6000568")]
		[Cpp2IlInjected.Address(RVA = "0x5363B10", Offset = "0x5362D10", VA = "0x185363B10", Slot = "10")]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x6000569")]
		[Cpp2IlInjected.Address(RVA = "0x5363EB0", Offset = "0x53630B0", VA = "0x185363EB0", Slot = "11")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000163")]
	public Vector3 DLFBGEBKEHJ
	{
		[Cpp2IlInjected.Token(Token = "0x600056A")]
		[Cpp2IlInjected.Address(RVA = "0x5363670", Offset = "0x5362870", VA = "0x185363670", Slot = "12")]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x600056B")]
		[Cpp2IlInjected.Address(RVA = "0x5364460", Offset = "0x5363660", VA = "0x185364460", Slot = "13")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000164")]
	public Vector3 KGONIIPAFMK
	{
		[Cpp2IlInjected.Token(Token = "0x600056C")]
		[Cpp2IlInjected.Address(RVA = "0x5364370", Offset = "0x5363570", VA = "0x185364370", Slot = "14")]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x600056D")]
		[Cpp2IlInjected.Address(RVA = "0x5362FF0", Offset = "0x53621F0", VA = "0x185362FF0", Slot = "15")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000165")]
	public float ENFIJFJPIPJ
	{
		[Cpp2IlInjected.Token(Token = "0x600056E")]
		[Cpp2IlInjected.Address(RVA = "0x100A9F0", Offset = "0x1009BF0", VA = "0x18100A9F0", Slot = "16")]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x600056F")]
		[Cpp2IlInjected.Address(RVA = "0x5362320", Offset = "0x5361520", VA = "0x185362320", Slot = "17")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000166")]
	public bool OIAJDGKIDMB
	{
		[Cpp2IlInjected.Token(Token = "0x6000570")]
		[Cpp2IlInjected.Address(RVA = "0x20CEFE0", Offset = "0x20CE1E0", VA = "0x1820CEFE0", Slot = "18")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000167")]
	private FGHCKEELDLL MOEIJMAANIJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000585")]
		[Cpp2IlInjected.Address(RVA = "0x1D6F2F0", Offset = "0x1D6E4F0", VA = "0x181D6F2F0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000168")]
	private bool NFEEOKFPIGD
	{
		[Cpp2IlInjected.Token(Token = "0x6000586")]
		[Cpp2IlInjected.Address(RVA = "0x5352680", Offset = "0x5351880", VA = "0x185352680")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000571")]
	[Cpp2IlInjected.Address(RVA = "0x5364AD0", Offset = "0x5363CD0", VA = "0x185364AD0")]
	public EOCPBOGNKBE(PPMDIHPMNCG LDDCANHDBNB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000572")]
	[Cpp2IlInjected.Address(RVA = "0x5361FF0", Offset = "0x53611F0", VA = "0x185361FF0", Slot = "19")]
	public void BKOELLNKDDF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000573")]
	[Cpp2IlInjected.Address(RVA = "0x5362480", Offset = "0x5361680", VA = "0x185362480", Slot = "37")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000574")]
	[Cpp2IlInjected.Address(RVA = "0x5364110", Offset = "0x5363310", VA = "0x185364110", Slot = "28")]
	public void JPMOLDGLNJO(Rigidbody AOAFHPHKFMD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000575")]
	[Cpp2IlInjected.Address(RVA = "0xF01700", Offset = "0xF00900", VA = "0x180F01700", Slot = "20")]
	public void HHNPBMOKIFP(object AJDBKDIMOHA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000576")]
	[Cpp2IlInjected.Address(RVA = "0xF024C0", Offset = "0xF016C0", VA = "0x180F024C0", Slot = "31")]
	public void NFNEBKIHHFL(object AJDBKDIMOHA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000577")]
	[Cpp2IlInjected.Address(RVA = "0x53624E0", Offset = "0x53616E0", VA = "0x1853624E0", Slot = "36")]
	public Vector3 EAJIEBJEBJP(Vector3 ODPCODBLNJO)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000578")]
	[Cpp2IlInjected.Address(RVA = "0x5363CF0", Offset = "0x5362EF0", VA = "0x185363CF0", Slot = "35")]
	public Vector3 JGGPKLHDPOC(Vector3 DLOMDLEMEJO)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000579")]
	[Cpp2IlInjected.Address(RVA = "0x5361FF0", Offset = "0x53611F0", VA = "0x185361FF0", Slot = "27")]
	public void LNGHCMNGELC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600057A")]
	[Cpp2IlInjected.Address(RVA = "0x5362440", Offset = "0x5361640", VA = "0x185362440", Slot = "25")]
	public void DGADOFDPFDE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600057B")]
	[Cpp2IlInjected.Address(RVA = "0x5363AD0", Offset = "0x5362CD0", VA = "0x185363AD0", Slot = "24")]
	public void IBIENENFOLO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600057C")]
	[Cpp2IlInjected.Address(RVA = "0x53626C0", Offset = "0x53618C0", VA = "0x1853626C0", Slot = "34")]
	public void EEIOJCMLKKL(Vector3 PKEOGDHOABC, Vector3 GNHLNIEHAFA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600057D")]
	[Cpp2IlInjected.Address(RVA = "0x5362060", Offset = "0x5361260", VA = "0x185362060", Slot = "33")]
	public void BNKAMLPDNDH(Vector3 IHHIJIKHHIA, Vector3 NBGIHKDGDID)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600057E")]
	[Cpp2IlInjected.Address(RVA = "0x53620C0", Offset = "0x53612C0", VA = "0x1853620C0", Slot = "32")]
	public void CADMMMANGFL(Vector3 GJKLLEKAGBH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600057F")]
	[Cpp2IlInjected.Address(RVA = "0x5363160", Offset = "0x5362360", VA = "0x185363160", Slot = "22")]
	public void GOHOEPELEBG(CBPMCKPIBHC EIOPEGEMKHP, Vector3 DKCLOLGBADH, float OOKLCGCBAJI, float LLKLELEIBGC = 8f, float AEEFHMKEOAH = 1f)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000580")]
	[Cpp2IlInjected.Address(RVA = "0x5363EE0", Offset = "0x53630E0", VA = "0x185363EE0", Slot = "21")]
	public void JLNINMHMEHA(BOPFIFMMKBG BPDOBLBNKEN, Vector3 NLFAAHHHDNN, float HHHNHCMFNFA = float.PositiveInfinity)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000581")]
	[Cpp2IlInjected.Address(RVA = "0x5361D20", Offset = "0x5360F20", VA = "0x185361D20", Slot = "23")]
	[Obsolete]
	public void ADCBOLCDFHD(BOPFIFMMKBG BPDOBLBNKEN, Vector3 MCFIHGJCDCP, float BDCHAJELIHL = 7f, float ABPPGEHGCFI = 1f)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000582")]
	[Cpp2IlInjected.Address(RVA = "0x5364860", Offset = "0x5363A60", VA = "0x185364860", Slot = "30")]
	public Vector3 KPFDHGBBOFB(Vector3 BNEEGIEDHBB)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000583")]
	[Cpp2IlInjected.Address(RVA = "0x5362F00", Offset = "0x5362100", VA = "0x185362F00", Slot = "29")]
	public Vector3 FHKEINJELIE(Vector3 IMJEKHOJGKC)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000584")]
	[Cpp2IlInjected.Address(RVA = "0x5364240", Offset = "0x5363440", VA = "0x185364240", Slot = "26")]
	public void KDDHFACBKGB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000587")]
	[Cpp2IlInjected.Address(RVA = "0x5362320", Offset = "0x5361520", VA = "0x185362320")]
	private void CJOOFKCBJCD(float JFBPNBNBHOE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000588")]
	[Cpp2IlInjected.Address(RVA = "0x5363020", Offset = "0x5362220", VA = "0x185363020")]
	private void GEOKOCNAGLK(Vector3 NLFAAHHHDNN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000589")]
	[Cpp2IlInjected.Address(RVA = "0x53649E0", Offset = "0x5363BE0", VA = "0x1853649E0")]
	private Vector3 PAHNCPJEPIJ()
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x600058A")]
	[Cpp2IlInjected.Address(RVA = "0x53637A0", Offset = "0x53629A0", VA = "0x1853637A0")]
	private void HMLBCCHCNID(Vector3 DLOMDLEMEJO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600058B")]
	[Cpp2IlInjected.Address(RVA = "0x5363C00", Offset = "0x5362E00", VA = "0x185363C00")]
	private Vector3 JFACHOANBJO()
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x600058C")]
	[Cpp2IlInjected.Address(RVA = "0x5364520", Offset = "0x5363720", VA = "0x185364520")]
	private void KPADOHKNGPN(Vector3 JFBPNBNBHOE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600058D")]
	[Cpp2IlInjected.Address(RVA = "0x5362900", Offset = "0x5361B00", VA = "0x185362900")]
	private void EFAJHPCILNA(Vector3 DLOMDLEMEJO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600058E")]
	[Cpp2IlInjected.Address(RVA = "0x5364920", Offset = "0x5363B20", VA = "0x185364920")]
	private void NGKMKMAACHI()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200005E")]
public class AIGJJMGJHJC : KMBOJHAPLLI
{
	[Cpp2IlInjected.Token(Token = "0x600058F")]
	[Cpp2IlInjected.Address(RVA = "0x53558D0", Offset = "0x5354AD0", VA = "0x1853558D0", Slot = "4")]
	public HMOOAGCGLKM MJLNOLDLKOJ(PPMDIHPMNCG ONJEPBGIHBB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000590")]
	[Cpp2IlInjected.Address(RVA = "0x53559B0", Offset = "0x5354BB0", VA = "0x1853559B0", Slot = "5")]
	public MPILPIJAHDO MOHHJJFOLBM(PPMDIHPMNCG ONJEPBGIHBB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000591")]
	[Cpp2IlInjected.Address(RVA = "0x5355550", Offset = "0x5354750", VA = "0x185355550", Slot = "6")]
	public NPFLLLAFPDM IMEKOCFODBG(PPMDIHPMNCG ONJEPBGIHBB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000592")]
	[Cpp2IlInjected.Address(RVA = "0x5355350", Offset = "0x5354550", VA = "0x185355350", Slot = "7")]
	public KKCAAHMNCAO HEDEOJGLLAC(PPMDIHPMNCG ONJEPBGIHBB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000593")]
	[Cpp2IlInjected.Address(RVA = "0x5355710", Offset = "0x5354910", VA = "0x185355710", Slot = "8")]
	public BBGIBEMMCOA JNPIPKPJGAO(PPMDIHPMNCG ONJEPBGIHBB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000594")]
	[Cpp2IlInjected.Address(RVA = "0x53553C0", Offset = "0x53545C0", VA = "0x1853553C0", Slot = "9")]
	public ODGCKIECBJN HEMHCEJPPBH(PPMDIHPMNCG ONJEPBGIHBB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000595")]
	[Cpp2IlInjected.Address(RVA = "0x53550D0", Offset = "0x53542D0", VA = "0x1853550D0", Slot = "10")]
	public GAMBABDLKNB GBHLIFIGFGO(PPMDIHPMNCG ONJEPBGIHBB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000596")]
	[Cpp2IlInjected.Address(RVA = "0x53552A0", Offset = "0x53544A0", VA = "0x1853552A0", Slot = "11")]
	public FGHCKEELDLL HDCLGAJOJOG(PPMDIHPMNCG ONJEPBGIHBB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000597")]
	[Cpp2IlInjected.Address(RVA = "0x5354DE0", Offset = "0x5353FE0", VA = "0x185354DE0", Slot = "12")]
	public APGGGIKOMPN AJBLCMCEIMG(PPMDIHPMNCG ONJEPBGIHBB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000598")]
	[Cpp2IlInjected.Address(RVA = "0x5355660", Offset = "0x5354860", VA = "0x185355660", Slot = "13")]
	public LMMEICEFKMM JIMOFCMOFGN(PPMDIHPMNCG ONJEPBGIHBB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000599")]
	[Cpp2IlInjected.Address(RVA = "0x5354FB0", Offset = "0x53541B0", VA = "0x185354FB0")]
	public HONAINACCHA EPFJODDPHNJ(PPMDIHPMNCG ONJEPBGIHBB, in OALOFNDFAEL ONIBEFDCPGD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600059A")]
	[Cpp2IlInjected.Address(RVA = "0x5355480", Offset = "0x5354680", VA = "0x185355480")]
	public LNJFNCEGNCA IMOGAPPPDNI(PPMDIHPMNCG ONJEPBGIHBB, in OALOFNDFAEL ONIBEFDCPGD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600059B")]
	[Cpp2IlInjected.Address(RVA = "0x5354E90", Offset = "0x5354090", VA = "0x185354E90")]
	public EBCDLOKEBCP MEDAGDCIAAG(PPMDIHPMNCG ONJEPBGIHBB, in OALOFNDFAEL ONIBEFDCPGD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600059C")]
	[Cpp2IlInjected.Address(RVA = "0x53557D0", Offset = "0x53549D0", VA = "0x1853557D0")]
	public HEFJBMMENIM PIKOPGMPFFO(PPMDIHPMNCG ONJEPBGIHBB, in OALOFNDFAEL ONIBEFDCPGD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600059D")]
	[Cpp2IlInjected.Address(RVA = "0x53551D0", Offset = "0x53543D0", VA = "0x1853551D0")]
	public OIAJBEDDNGM NOELAMDCDMI(PPMDIHPMNCG ONJEPBGIHBB, in OALOFNDFAEL ONIBEFDCPGD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600059E")]
	[Cpp2IlInjected.Address(RVA = "0x5354F00", Offset = "0x5354100", VA = "0x185354F00", Slot = "19")]
	public PPMDIHPMNCG EHCIKDFINKO(RigidbodyEx LDDCANHDBNB, OALOFNDFAEL ONIBEFDCPGD, CMKMIKBKOHM OBOKKBNADPB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600059F")]
	[Cpp2IlInjected.Address(RVA = "0x6C8B30", Offset = "0x6C7D30", VA = "0x1806C8B30")]
	public AIGJJMGJHJC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60005A0")]
	[Cpp2IlInjected.Address(RVA = "0x5354FB0", Offset = "0x53541B0", VA = "0x185354FB0", Slot = "14")]
	private HONAINACCHA GIPLMECOEDJ(PPMDIHPMNCG ONJEPBGIHBB, in OALOFNDFAEL ONIBEFDCPGD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60005A1")]
	[Cpp2IlInjected.Address(RVA = "0x5355480", Offset = "0x5354680", VA = "0x185355480", Slot = "15")]
	private LNJFNCEGNCA HOCCJMCGJPK(PPMDIHPMNCG ONJEPBGIHBB, in OALOFNDFAEL ONIBEFDCPGD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60005A2")]
	[Cpp2IlInjected.Address(RVA = "0x5354E90", Offset = "0x5354090", VA = "0x185354E90", Slot = "16")]
	private EBCDLOKEBCP DDDDJCAAJFM(PPMDIHPMNCG ONJEPBGIHBB, in OALOFNDFAEL ONIBEFDCPGD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60005A3")]
	[Cpp2IlInjected.Address(RVA = "0x53557D0", Offset = "0x53549D0", VA = "0x1853557D0", Slot = "17")]
	private HEFJBMMENIM KPKGPEKIGJD(PPMDIHPMNCG ONJEPBGIHBB, in OALOFNDFAEL ONIBEFDCPGD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60005A4")]
	[Cpp2IlInjected.Address(RVA = "0x53551D0", Offset = "0x53543D0", VA = "0x1853551D0", Slot = "18")]
	private OIAJBEDDNGM GLMHIKFJOJB(PPMDIHPMNCG ONJEPBGIHBB, in OALOFNDFAEL ONIBEFDCPGD)
	{
		return null;
	}
}
namespace RRAssemblyIndex.RecRoom.Rbex.Runtime
{
	[Cpp2IlInjected.Token(Token = "0x200005F")]
	[Preserve]
	internal class _RRAssemblyIndex : IIPLPEOFAPM
	{
		[Cpp2IlInjected.Token(Token = "0x60005A5")]
		[Cpp2IlInjected.Address(RVA = "0x6C8B40", Offset = "0x6C7D40", VA = "0x1806C8B40")]
		[Preserve]
		public _RRAssemblyIndex()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005A6")]
		[Cpp2IlInjected.Address(RVA = "0x64102A0", Offset = "0x640F4A0", VA = "0x1864102A0", Slot = "6")]
		public sealed override void ABDNPPIKLOH(FJJGEPPJBDA IGAMPECHIKO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005A7")]
		[Cpp2IlInjected.Address(RVA = "0x6410480", Offset = "0x640F680", VA = "0x186410480", Slot = "4")]
		public sealed override void FKBDNONAKOB()
		{
		}
	}
}
[StructLayout((LayoutKind)3, CharSet = CharSet.Auto)]
[Cpp2IlInjected.Token(Token = "0x2000060")]
public class EGIIOKJKKGL
{
	[Cpp2IlInjected.Token(Token = "0x40000CF")]
	private static byte[] LAFDEEMEPDM;

	[Cpp2IlInjected.Token(Token = "0x40000D0")]
	private static int AHBPGGLKEKP;

	[Cpp2IlInjected.Token(Token = "0x40000D1")]
	private static int MAHPDNGMMFO;

	[Cpp2IlInjected.Token(Token = "0x40000D2")]
	private static BigInteger NMOJFJKJLEG;

	[Cpp2IlInjected.Token(Token = "0x60005A8")]
	[Cpp2IlInjected.Address(RVA = "0x6C8B30", Offset = "0x6C7D30", VA = "0x1806C8B30")]
	public EGIIOKJKKGL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60005AA")]
	[Cpp2IlInjected.Address(RVA = "0x535FB90", Offset = "0x535ED90", VA = "0x18535FB90")]
	private static string CIEKLEOAFAL(byte[] GPHMIGDKMEO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60005AB")]
	[Cpp2IlInjected.Address(RVA = "0x535FCA0", Offset = "0x535EEA0", VA = "0x18535FCA0")]
	public static string NOFFLEGCGLA(byte[] NPNCGJAPKIL, bool FBFFLNHILGA)
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
		[Cpp2IlInjected.Address(RVA = "0x6C8B30", Offset = "0x6C7D30", VA = "0x1806C8B30")]
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
