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
	[Cpp2IlInjected.Address(RVA = "0x6D6CD0", Offset = "0x6D60D0", VA = "0x1806D6CD0")]
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
		[Cpp2IlInjected.Address(RVA = "0x6C4060", Offset = "0x6C3460", VA = "0x1806C4060", Slot = "4")]
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
		[Cpp2IlInjected.Address(RVA = "0x7532A0", Offset = "0x7526A0", VA = "0x1807532A0", Slot = "5")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0x6F98D0", Offset = "0x6F8CD0", VA = "0x1806F98D0", Slot = "6")]
	public LHLIDFNIOKA ELBEDJHIGFE(float KINGLLIJCOO)
	{
		return default(LHLIDFNIOKA);
	}

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0x6D7320", Offset = "0x6D6720", VA = "0x1806D7320", Slot = "7")]
	public void AOHLLDNPMGN(NLJGMJFEGHJ ADHHHFDPAPI, float IOOOOANBPPM, JANFPIDCDOK FHMBIDJAKMP = JANFPIDCDOK.Off)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(RVA = "0x6D7320", Offset = "0x6D6720", VA = "0x1806D7320", Slot = "8")]
	public void AOHLLDNPMGN(NLJGMJFEGHJ ADHHHFDPAPI, Transform LKCKBCPKEGI, float IOOOOANBPPM, JANFPIDCDOK FHMBIDJAKMP = JANFPIDCDOK.Off)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(RVA = "0x6D7320", Offset = "0x6D6720", VA = "0x1806D7320", Slot = "9")]
	public void JGKKHFDLFAG(NLJGMJFEGHJ ADHHHFDPAPI, [Optional] float? IOOOOANBPPM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(RVA = "0x6D7320", Offset = "0x6D6720", VA = "0x1806D7320", Slot = "10")]
	public void BCBAFCFKBLF(NLJGMJFEGHJ BNCCAIGLJMO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(RVA = "0x6F98D0", Offset = "0x6F8CD0", VA = "0x1806F98D0", Slot = "11")]
	public LHLIDFNIOKA JJNDGAOIAGC(NLJGMJFEGHJ ADHHHFDPAPI)
	{
		return default(LHLIDFNIOKA);
	}

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(RVA = "0x6F9850", Offset = "0x6F8C50", VA = "0x1806F9850", Slot = "12")]
	public bool FOGOPKKNGDH(NLJGMJFEGHJ ADHHHFDPAPI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(RVA = "0x6D7320", Offset = "0x6D6720", VA = "0x1806D7320", Slot = "13")]
	public void OALFIIGCDLA(NLJGMJFEGHJ ADHHHFDPAPI, JANFPIDCDOK PHDHCKKFDCD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(RVA = "0x6D6CD0", Offset = "0x6D60D0", VA = "0x1806D6CD0")]
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
		[Cpp2IlInjected.Address(RVA = "0x75DD10", Offset = "0x75D110", VA = "0x18075DD10", Slot = "4")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(RVA = "0x6D7320", Offset = "0x6D6720", VA = "0x1806D7320", Slot = "5")]
	public void HMDKABCPDKD(string GNLLAOFLEDB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(RVA = "0x6D7320", Offset = "0x6D6720", VA = "0x1806D7320", Slot = "6")]
	public void PMLEKKPAIBC(RigidbodyEx LDDCANHDBNB, Action GPNJNMLGIEN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(RVA = "0x6F98D0", Offset = "0x6F8CD0", VA = "0x1806F98D0", Slot = "7")]
	public GNJJFOIGADA JJJBOPMPOCL(int BDENIEGMNAP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(RVA = "0x6D7320", Offset = "0x6D6720", VA = "0x1806D7320", Slot = "8")]
	public void IPHJOJMEHNN(Vector3 BJJEJPIPLBD, float JANGDGEDDPJ, Color GEDOLEMBLCF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(RVA = "0x6D6CD0", Offset = "0x6D60D0", VA = "0x1806D6CD0")]
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
		[SerializeField]
		[HideInInspector]
		private bool hasUnityRigidbodyByDefault;

		[Cpp2IlInjected.Token(Token = "0x17000004")]
		internal PPMDIHPMNCG AJDCHLHALFM
		{
			[Cpp2IlInjected.Token(Token = "0x600001B")]
			[Cpp2IlInjected.Address(RVA = "0x645ECB0", Offset = "0x645E0B0", VA = "0x18645ECB0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000005")]
		public IReadOnlyList<RigidbodyEx> LILCAAEDFCG
		{
			[Cpp2IlInjected.Token(Token = "0x600002F")]
			[Cpp2IlInjected.Address(RVA = "0x77D5F0", Offset = "0x77C9F0", VA = "0x18077D5F0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000030")]
			[Cpp2IlInjected.Address(RVA = "0x706290", Offset = "0x705690", VA = "0x180706290")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000006")]
		public RigidbodyEx NJNINOPBCAN
		{
			[Cpp2IlInjected.Token(Token = "0x6000031")]
			[Cpp2IlInjected.Address(RVA = "0x6460AD0", Offset = "0x645FED0", VA = "0x186460AD0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000007")]
		public RigidbodyEx MDHMHFAIMJJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000032")]
			[Cpp2IlInjected.Address(RVA = "0x6460A70", Offset = "0x645FE70", VA = "0x186460A70")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000008")]
		public RigidbodyEx GPFONCECPBK
		{
			[Cpp2IlInjected.Token(Token = "0x6000033")]
			[Cpp2IlInjected.Address(RVA = "0x6461630", Offset = "0x6460A30", VA = "0x186461630")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000034")]
			[Cpp2IlInjected.Address(RVA = "0x6462D80", Offset = "0x6462180", VA = "0x186462D80")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000009")]
		public Transform PDLNBKLCFJO
		{
			[Cpp2IlInjected.Token(Token = "0x6000035")]
			[Cpp2IlInjected.Address(RVA = "0xD5A650", Offset = "0xD59A50", VA = "0x180D5A650")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000A")]
		public Transform IPOOCBGBBCA
		{
			[Cpp2IlInjected.Token(Token = "0x6000036")]
			[Cpp2IlInjected.Address(RVA = "0xD5A650", Offset = "0xD59A50", VA = "0x180D5A650")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000B")]
		public JANFPIDCDOK NHFAJHMDKMA
		{
			[Cpp2IlInjected.Token(Token = "0x6000037")]
			[Cpp2IlInjected.Address(RVA = "0x64607D0", Offset = "0x645FBD0", VA = "0x1864607D0")]
			get
			{
				return default(JANFPIDCDOK);
			}
			[Cpp2IlInjected.Token(Token = "0x6000038")]
			[Cpp2IlInjected.Address(RVA = "0x6462320", Offset = "0x6461720", VA = "0x186462320")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000C")]
		public bool PJPIAHDKHLD
		{
			[Cpp2IlInjected.Token(Token = "0x6000039")]
			[Cpp2IlInjected.Address(RVA = "0x6460CE0", Offset = "0x64600E0", VA = "0x186460CE0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000D")]
		public bool EMGPBBGPGIE
		{
			[Cpp2IlInjected.Token(Token = "0x600003A")]
			[Cpp2IlInjected.Address(RVA = "0x64608F0", Offset = "0x645FCF0", VA = "0x1864608F0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000E")]
		public LKKOPIEOHJA OLDOEMJHCAC
		{
			[Cpp2IlInjected.Token(Token = "0x600003B")]
			[Cpp2IlInjected.Address(RVA = "0x6460C80", Offset = "0x6460080", VA = "0x186460C80")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600003C")]
			[Cpp2IlInjected.Address(RVA = "0x6462530", Offset = "0x6461930", VA = "0x186462530")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000F")]
		public FDHNJKMJJJG AEPCDANKKNF
		{
			[Cpp2IlInjected.Token(Token = "0x600003D")]
			[Cpp2IlInjected.Address(RVA = "0x6460C20", Offset = "0x6460020", VA = "0x186460C20")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600003E")]
			[Cpp2IlInjected.Address(RVA = "0x64624C0", Offset = "0x64618C0", VA = "0x1864624C0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000010")]
		public bool OIAJDGKIDMB
		{
			[Cpp2IlInjected.Token(Token = "0x600003F")]
			[Cpp2IlInjected.Address(RVA = "0x6460B00", Offset = "0x645FF00", VA = "0x186460B00")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000011")]
		public Rigidbody BAPEKECGLDP
		{
			[Cpp2IlInjected.Token(Token = "0x6000040")]
			[Cpp2IlInjected.Address(RVA = "0x6460B60", Offset = "0x645FF60", VA = "0x186460B60")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000012")]
		public bool PJGCDNLPGAK
		{
			[Cpp2IlInjected.Token(Token = "0x6000041")]
			[Cpp2IlInjected.Address(RVA = "0x64609B0", Offset = "0x645FDB0", VA = "0x1864609B0")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000042")]
			[Cpp2IlInjected.Address(RVA = "0x64623E0", Offset = "0x64617E0", VA = "0x1864623E0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000013")]
		public bool LOGIENNOBOE
		{
			[Cpp2IlInjected.Token(Token = "0x6000043")]
			[Cpp2IlInjected.Address(RVA = "0xD26000", Offset = "0xD25400", VA = "0x180D26000")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000044")]
			[Cpp2IlInjected.Address(RVA = "0x2197A20", Offset = "0x2196E20", VA = "0x182197A20")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000014")]
		public float AKCBBGMHDDM
		{
			[Cpp2IlInjected.Token(Token = "0x6000045")]
			[Cpp2IlInjected.Address(RVA = "0x64615D0", Offset = "0x64609D0", VA = "0x1864615D0")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000015")]
		public float AKJJDFEANLD
		{
			[Cpp2IlInjected.Token(Token = "0x6000046")]
			[Cpp2IlInjected.Address(RVA = "0x6461570", Offset = "0x6460970", VA = "0x186461570")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x6000047")]
			[Cpp2IlInjected.Address(RVA = "0x6462D10", Offset = "0x6462110", VA = "0x186462D10")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000016")]
		public float CGCJGLPPNGH
		{
			[Cpp2IlInjected.Token(Token = "0x6000048")]
			[Cpp2IlInjected.Address(RVA = "0x6460F40", Offset = "0x6460340", VA = "0x186460F40")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x6000049")]
			[Cpp2IlInjected.Address(RVA = "0x64627D0", Offset = "0x6461BD0", VA = "0x1864627D0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000017")]
		public float PIFJIAIFNLJ
		{
			[Cpp2IlInjected.Token(Token = "0x600004A")]
			[Cpp2IlInjected.Address(RVA = "0x6460D40", Offset = "0x6460140", VA = "0x186460D40")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x600004B")]
			[Cpp2IlInjected.Address(RVA = "0x64625A0", Offset = "0x64619A0", VA = "0x1864625A0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000018")]
		public bool POECKMPMDKM
		{
			[Cpp2IlInjected.Token(Token = "0x600004C")]
			[Cpp2IlInjected.Address(RVA = "0x6461B50", Offset = "0x6460F50", VA = "0x186461B50")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x600004D")]
			[Cpp2IlInjected.Address(RVA = "0x64632C0", Offset = "0x64626C0", VA = "0x1864632C0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000019")]
		public Vector3 MJDCNCPMNKH
		{
			[Cpp2IlInjected.Token(Token = "0x600004E")]
			[Cpp2IlInjected.Address(RVA = "0x6461350", Offset = "0x6460750", VA = "0x186461350")]
			get
			{
				return default(Vector3);
			}
			[Cpp2IlInjected.Token(Token = "0x600004F")]
			[Cpp2IlInjected.Address(RVA = "0x6462AE0", Offset = "0x6461EE0", VA = "0x186462AE0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001A")]
		public Vector3 BJJEJPIPLBD
		{
			[Cpp2IlInjected.Token(Token = "0x6000050")]
			[Cpp2IlInjected.Address(RVA = "0x6461C90", Offset = "0x6461090", VA = "0x186461C90")]
			get
			{
				return default(Vector3);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001B")]
		public CollisionDetectionMode HPCCBOFOPKH
		{
			[Cpp2IlInjected.Token(Token = "0x6000051")]
			[Cpp2IlInjected.Address(RVA = "0x6460E80", Offset = "0x6460280", VA = "0x186460E80")]
			get
			{
				return default(CollisionDetectionMode);
			}
			[Cpp2IlInjected.Token(Token = "0x6000052")]
			[Cpp2IlInjected.Address(RVA = "0x64626F0", Offset = "0x6461AF0", VA = "0x1864626F0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001C")]
		public float ENFIJFJPIPJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000053")]
			[Cpp2IlInjected.Address(RVA = "0x6460A10", Offset = "0x645FE10", VA = "0x186460A10")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x6000054")]
			[Cpp2IlInjected.Address(RVA = "0x6462450", Offset = "0x6461850", VA = "0x186462450")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001D")]
		public RigidbodyConstraints AGPNLEHNBIO
		{
			[Cpp2IlInjected.Token(Token = "0x6000055")]
			[Cpp2IlInjected.Address(RVA = "0x6460EE0", Offset = "0x64602E0", VA = "0x186460EE0")]
			get
			{
				return default(RigidbodyConstraints);
			}
			[Cpp2IlInjected.Token(Token = "0x6000056")]
			[Cpp2IlInjected.Address(RVA = "0x6462760", Offset = "0x6461B60", VA = "0x186462760")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001E")]
		public Vector3 ABDEOMCEHMB
		{
			[Cpp2IlInjected.Token(Token = "0x6000057")]
			[Cpp2IlInjected.Address(RVA = "0x6461690", Offset = "0x6460A90", VA = "0x186461690")]
			get
			{
				return default(Vector3);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001F")]
		public Vector3 FLOJHNJCGGP
		{
			[Cpp2IlInjected.Token(Token = "0x6000058")]
			[Cpp2IlInjected.Address(RVA = "0x6461690", Offset = "0x6460A90", VA = "0x186461690")]
			get
			{
				return default(Vector3);
			}
			[Cpp2IlInjected.Token(Token = "0x6000059")]
			[Cpp2IlInjected.Address(RVA = "0x6463090", Offset = "0x6462490", VA = "0x186463090")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000020")]
		public float DLAJIHFLDDN
		{
			[Cpp2IlInjected.Token(Token = "0x600005A")]
			[Cpp2IlInjected.Address(RVA = "0x6461430", Offset = "0x6460830", VA = "0x186461430")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x600005B")]
			[Cpp2IlInjected.Address(RVA = "0x6462BC0", Offset = "0x6461FC0", VA = "0x186462BC0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000021")]
		public float BBJPLPKDAFJ
		{
			[Cpp2IlInjected.Token(Token = "0x600005C")]
			[Cpp2IlInjected.Address(RVA = "0x6461AF0", Offset = "0x6460EF0", VA = "0x186461AF0")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x600005D")]
			[Cpp2IlInjected.Address(RVA = "0x6463250", Offset = "0x6462650", VA = "0x186463250")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000022")]
		public Quaternion BOKMIPEIPMN
		{
			[Cpp2IlInjected.Token(Token = "0x600005E")]
			[Cpp2IlInjected.Address(RVA = "0x6461770", Offset = "0x6460B70", VA = "0x186461770")]
			get
			{
				return default(Quaternion);
			}
			[Cpp2IlInjected.Token(Token = "0x600005F")]
			[Cpp2IlInjected.Address(RVA = "0x6462DF0", Offset = "0x64621F0", VA = "0x186462DF0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000023")]
		public Quaternion CGMHKNFGLML
		{
			[Cpp2IlInjected.Token(Token = "0x6000060")]
			[Cpp2IlInjected.Address(RVA = "0x6461A10", Offset = "0x6460E10", VA = "0x186461A10")]
			get
			{
				return default(Quaternion);
			}
			[Cpp2IlInjected.Token(Token = "0x6000061")]
			[Cpp2IlInjected.Address(RVA = "0x6463170", Offset = "0x6462570", VA = "0x186463170")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000024")]
		public Vector3 DMEHFDCFLJO
		{
			[Cpp2IlInjected.Token(Token = "0x6000062")]
			[Cpp2IlInjected.Address(RVA = "0x6461850", Offset = "0x6460C50", VA = "0x186461850")]
			get
			{
				return default(Vector3);
			}
			[Cpp2IlInjected.Token(Token = "0x6000063")]
			[Cpp2IlInjected.Address(RVA = "0x6462ED0", Offset = "0x64622D0", VA = "0x186462ED0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000025")]
		public Quaternion JAPKFAIHFPH
		{
			[Cpp2IlInjected.Token(Token = "0x6000064")]
			[Cpp2IlInjected.Address(RVA = "0x6461930", Offset = "0x6460D30", VA = "0x186461930")]
			get
			{
				return default(Quaternion);
			}
			[Cpp2IlInjected.Token(Token = "0x6000065")]
			[Cpp2IlInjected.Address(RVA = "0x6462FB0", Offset = "0x64623B0", VA = "0x186462FB0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000026")]
		public Vector3 BNEEGIEDHBB
		{
			[Cpp2IlInjected.Token(Token = "0x6000066")]
			[Cpp2IlInjected.Address(RVA = "0x6461BB0", Offset = "0x6460FB0", VA = "0x186461BB0")]
			get
			{
				return default(Vector3);
			}
			[Cpp2IlInjected.Token(Token = "0x6000067")]
			[Cpp2IlInjected.Address(RVA = "0x6463330", Offset = "0x6462730", VA = "0x186463330")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000027")]
		public Vector3 DLOMDLEMEJO
		{
			[Cpp2IlInjected.Token(Token = "0x6000068")]
			[Cpp2IlInjected.Address(RVA = "0x6461490", Offset = "0x6460890", VA = "0x186461490")]
			get
			{
				return default(Vector3);
			}
			[Cpp2IlInjected.Token(Token = "0x6000069")]
			[Cpp2IlInjected.Address(RVA = "0x6462C30", Offset = "0x6462030", VA = "0x186462C30")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000028")]
		public Vector3 IMJEKHOJGKC
		{
			[Cpp2IlInjected.Token(Token = "0x600006A")]
			[Cpp2IlInjected.Address(RVA = "0x6460DA0", Offset = "0x64601A0", VA = "0x186460DA0")]
			get
			{
				return default(Vector3);
			}
			[Cpp2IlInjected.Token(Token = "0x600006B")]
			[Cpp2IlInjected.Address(RVA = "0x6462610", Offset = "0x6461A10", VA = "0x186462610")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000029")]
		public Vector3 NBGIHKDGDID
		{
			[Cpp2IlInjected.Token(Token = "0x600006C")]
			[Cpp2IlInjected.Address(RVA = "0x6461270", Offset = "0x6460670", VA = "0x186461270")]
			get
			{
				return default(Vector3);
			}
			[Cpp2IlInjected.Token(Token = "0x600006D")]
			[Cpp2IlInjected.Address(RVA = "0x6462A00", Offset = "0x6461E00", VA = "0x186462A00")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002A")]
		public Vector3 KNIHAMHGBLN
		{
			[Cpp2IlInjected.Token(Token = "0x600006E")]
			[Cpp2IlInjected.Address(RVA = "0x6461130", Offset = "0x6460530", VA = "0x186461130")]
			get
			{
				return default(Vector3);
			}
			[Cpp2IlInjected.Token(Token = "0x600006F")]
			[Cpp2IlInjected.Address(RVA = "0x6462920", Offset = "0x6461D20", VA = "0x186462920")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002B")]
		public Quaternion OPONCDOPJKK
		{
			[Cpp2IlInjected.Token(Token = "0x6000070")]
			[Cpp2IlInjected.Address(RVA = "0x6461050", Offset = "0x6460450", VA = "0x186461050")]
			get
			{
				return default(Quaternion);
			}
			[Cpp2IlInjected.Token(Token = "0x6000071")]
			[Cpp2IlInjected.Address(RVA = "0x6462840", Offset = "0x6461C40", VA = "0x186462840")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002C")]
		public Vector3 NEODKNJMMAG
		{
			[Cpp2IlInjected.Token(Token = "0x6000072")]
			[Cpp2IlInjected.Address(RVA = "0x6461E50", Offset = "0x6461250", VA = "0x186461E50")]
			get
			{
				return default(Vector3);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002D")]
		public Vector3 FOAMPCAGPDL
		{
			[Cpp2IlInjected.Token(Token = "0x6000073")]
			[Cpp2IlInjected.Address(RVA = "0x6461D70", Offset = "0x6461170", VA = "0x186461D70")]
			get
			{
				return default(Vector3);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002E")]
		public bool IOEMIKGMLIB
		{
			[Cpp2IlInjected.Token(Token = "0x6000074")]
			[Cpp2IlInjected.Address(RVA = "0x6461210", Offset = "0x6460610", VA = "0x186461210")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002F")]
		public bool NFEEOKFPIGD
		{
			[Cpp2IlInjected.Token(Token = "0x6000075")]
			[Cpp2IlInjected.Address(RVA = "0x6460950", Offset = "0x645FD50", VA = "0x186460950")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000030")]
		public bool AMMPJIIANJD
		{
			[Cpp2IlInjected.Token(Token = "0x6000076")]
			[Cpp2IlInjected.Address(RVA = "0x6460890", Offset = "0x645FC90", VA = "0x186460890")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000031")]
		public bool OONHJPFBNAB
		{
			[Cpp2IlInjected.Token(Token = "0x6000077")]
			[Cpp2IlInjected.Address(RVA = "0x6460830", Offset = "0x645FC30", VA = "0x186460830")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000032")]
		public bool AKAANNKOEAC
		{
			[Cpp2IlInjected.Token(Token = "0x6000078")]
			[Cpp2IlInjected.Address(RVA = "0x6460770", Offset = "0x645FB70", VA = "0x186460770")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000033")]
		public bool CPMFMLDOCMG
		{
			[Cpp2IlInjected.Token(Token = "0x6000079")]
			[Cpp2IlInjected.Address(RVA = "0x6460FA0", Offset = "0x64603A0", VA = "0x186460FA0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000034")]
		public bool EIOIMMEOHBA
		{
			[Cpp2IlInjected.Token(Token = "0x600007A")]
			[Cpp2IlInjected.Address(RVA = "0x8A30A0", Offset = "0x8A24A0", VA = "0x1808A30A0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000001")]
		public event JPOFABMOGOF PMNOCHELBHE
		{
			[Cpp2IlInjected.Token(Token = "0x600001D")]
			[Cpp2IlInjected.Address(RVA = "0x6460690", Offset = "0x645FA90", VA = "0x186460690")]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x600001E")]
			[Cpp2IlInjected.Address(RVA = "0x6462240", Offset = "0x6461640", VA = "0x186462240")]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000002")]
		public event CBNHIOLMAOO CHIALDMLLME
		{
			[Cpp2IlInjected.Token(Token = "0x600001F")]
			[Cpp2IlInjected.Address(RVA = "0x6460620", Offset = "0x645FA20", VA = "0x186460620")]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000020")]
			[Cpp2IlInjected.Address(RVA = "0x64621D0", Offset = "0x64615D0", VA = "0x1864621D0")]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000003")]
		public event JPOFABMOGOF KMPDHKDHBNO
		{
			[Cpp2IlInjected.Token(Token = "0x6000021")]
			[Cpp2IlInjected.Address(RVA = "0x6460380", Offset = "0x645F780", VA = "0x186460380")]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000022")]
			[Cpp2IlInjected.Address(RVA = "0x6461F30", Offset = "0x6461330", VA = "0x186461F30")]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000004")]
		public event JPOFABMOGOF FIBPOODLACB
		{
			[Cpp2IlInjected.Token(Token = "0x6000023")]
			[Cpp2IlInjected.Address(RVA = "0x64603F0", Offset = "0x645F7F0", VA = "0x1864603F0")]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000024")]
			[Cpp2IlInjected.Address(RVA = "0x6461FA0", Offset = "0x64613A0", VA = "0x186461FA0")]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000005")]
		public event JPOFABMOGOF GHPNGDBINKD
		{
			[Cpp2IlInjected.Token(Token = "0x6000025")]
			[Cpp2IlInjected.Address(RVA = "0x6460540", Offset = "0x645F940", VA = "0x186460540")]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000026")]
			[Cpp2IlInjected.Address(RVA = "0x64620F0", Offset = "0x64614F0", VA = "0x1864620F0")]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000006")]
		public event Action<LHLIDFNIOKA, LHLIDFNIOKA> GBMBMPKHBHO
		{
			[Cpp2IlInjected.Token(Token = "0x6000027")]
			[Cpp2IlInjected.Address(RVA = "0x64604D0", Offset = "0x645F8D0", VA = "0x1864604D0")]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000028")]
			[Cpp2IlInjected.Address(RVA = "0x6462080", Offset = "0x6461480", VA = "0x186462080")]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000007")]
		public event JPOFABMOGOF FINFHBLPOFK
		{
			[Cpp2IlInjected.Token(Token = "0x6000029")]
			[Cpp2IlInjected.Address(RVA = "0x64605B0", Offset = "0x645F9B0", VA = "0x1864605B0")]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x600002A")]
			[Cpp2IlInjected.Address(RVA = "0x6462160", Offset = "0x6461560", VA = "0x186462160")]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000008")]
		public event JPOFABMOGOF PDFILLCCOJB
		{
			[Cpp2IlInjected.Token(Token = "0x600002B")]
			[Cpp2IlInjected.Address(RVA = "0x6460700", Offset = "0x645FB00", VA = "0x186460700")]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x600002C")]
			[Cpp2IlInjected.Address(RVA = "0x64622B0", Offset = "0x64616B0", VA = "0x1864622B0")]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000009")]
		public event JPOFABMOGOF FAMCBBOPNHD
		{
			[Cpp2IlInjected.Token(Token = "0x600002D")]
			[Cpp2IlInjected.Address(RVA = "0x6460460", Offset = "0x645F860", VA = "0x186460460")]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x600002E")]
			[Cpp2IlInjected.Address(RVA = "0x6462010", Offset = "0x6461410", VA = "0x186462010")]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(RVA = "0x7062B0", Offset = "0x7056B0", VA = "0x1807062B0")]
		internal void JHOICGAFFJF(PPMDIHPMNCG ONJEPBGIHBB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007B")]
		[Cpp2IlInjected.Address(RVA = "0x645EA00", Offset = "0x645DE00", VA = "0x18645EA00")]
		private void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007C")]
		[Cpp2IlInjected.Address(RVA = "0x645ECB0", Offset = "0x645E0B0", VA = "0x18645ECB0")]
		private PPMDIHPMNCG MODNGDOMPEE()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600007D")]
		[Cpp2IlInjected.Address(RVA = "0x645EFC0", Offset = "0x645E3C0", VA = "0x18645EFC0")]
		private void HBGEMGCKMHE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007E")]
		[Cpp2IlInjected.Address(RVA = "0x645F690", Offset = "0x645EA90", VA = "0x18645F690")]
		private void OnEnable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007F")]
		[Cpp2IlInjected.Address(RVA = "0x645F590", Offset = "0x645E990", VA = "0x18645F590")]
		private void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000080")]
		[Cpp2IlInjected.Address(RVA = "0x645ED60", Offset = "0x645E160", VA = "0x18645ED60")]
		private void FixedUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000081")]
		[Cpp2IlInjected.Address(RVA = "0x645F630", Offset = "0x645EA30", VA = "0x18645F630")]
		private void OnDrawGizmosSelected()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000082")]
		[Cpp2IlInjected.Address(RVA = "0x645F6F0", Offset = "0x645EAF0", VA = "0x18645F6F0")]
		private void OnValidate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000083")]
		[Cpp2IlInjected.Address(RVA = "0x645E090", Offset = "0x645D490", VA = "0x18645E090")]
		public void AddDoNotResetVelocityOnOwnershipChangeOverride(object AJDBKDIMOHA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000084")]
		[Cpp2IlInjected.Address(RVA = "0x645F760", Offset = "0x645EB60", VA = "0x18645F760")]
		public void RemoveDoNotResetVelocityOnOwnershipChangeOverride(object AJDBKDIMOHA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000085")]
		[Cpp2IlInjected.Address(RVA = "0x645EC50", Offset = "0x645E050", VA = "0x18645EC50")]
		public void DisableCachedInertialPropertyOverride()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000086")]
		[Cpp2IlInjected.Address(RVA = "0x645F530", Offset = "0x645E930", VA = "0x18645F530")]
		public void MarkCachedInertialParametersDirty()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000087")]
		[Cpp2IlInjected.Address(RVA = "0x645FF50", Offset = "0x645F350", VA = "0x18645FF50")]
		public void SetParent(RigidbodyEx JFBPNBNBHOE, bool LMKLDOOIJAA = false)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000088")]
		[Cpp2IlInjected.Address(RVA = "0x645FA70", Offset = "0x645EE70", VA = "0x18645FA70")]
		public void ResetLocalCenterOfMassToPrefabDefault()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000089")]
		[Cpp2IlInjected.Address(RVA = "0x645F350", Offset = "0x645E750", VA = "0x18645F350")]
		public bool IsRigidbodyAncestor(RigidbodyEx BIHOLEKLDHK)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600008A")]
		[Cpp2IlInjected.Address(RVA = "0x645F390", Offset = "0x645E790", VA = "0x18645F390")]
		public bool IsRigidbodyDescendant(RigidbodyEx FPKOBEGNFCF)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600008B")]
		[Cpp2IlInjected.Address(RVA = "0x645E2B0", Offset = "0x645D6B0", VA = "0x18645E2B0")]
		public void AddInterpolationRestriction(object AJDBKDIMOHA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008C")]
		[Cpp2IlInjected.Address(RVA = "0x645F7D0", Offset = "0x645EBD0", VA = "0x18645F7D0")]
		public void RemoveInterpolationRestriction(object AJDBKDIMOHA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008D")]
		[Cpp2IlInjected.Address(RVA = "0x645EA70", Offset = "0x645DE70", VA = "0x18645EA70")]
		public IDisposable BeginKinematicScope()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600008E")]
		[Cpp2IlInjected.Address(RVA = "0x645E320", Offset = "0x645D720", VA = "0x18645E320")]
		public void AddKinematic(object AJDBKDIMOHA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008F")]
		[Cpp2IlInjected.Address(RVA = "0x645F840", Offset = "0x645EC40", VA = "0x18645F840")]
		public void RemoveKinematic(object AJDBKDIMOHA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000090")]
		[Cpp2IlInjected.Address(RVA = "0x645FED0", Offset = "0x645F2D0", VA = "0x18645FED0")]
		public void SetKinematic(object AJDBKDIMOHA, bool NMHFDHPJGFL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000091")]
		[Cpp2IlInjected.Address(RVA = "0x645FDD0", Offset = "0x645F1D0", VA = "0x18645FDD0")]
		public void SetDiscontinuousPositionAndRotation(Vector3 LDBCCJOIJOF, Quaternion HPGHCBDEGFJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000092")]
		[Cpp2IlInjected.Address(RVA = "0x645FCD0", Offset = "0x645F0D0", VA = "0x18645FCD0")]
		public void SetDiscontinuousLocalPositionAndLocalRotation(Vector3 JPBAEPJPHFP, Quaternion NHHKEMOEKHO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000093")]
		[Cpp2IlInjected.Address(RVA = "0x645EEC0", Offset = "0x645E2C0", VA = "0x18645EEC0")]
		public Vector3 GetConstrainedVelocity(Vector3 BNEEGIEDHBB)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x6000094")]
		[Cpp2IlInjected.Address(RVA = "0x645EDC0", Offset = "0x645E1C0", VA = "0x18645EDC0")]
		public Vector3 GetConstrainedAngularVelocity(Vector3 IMJEKHOJGKC)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x6000095")]
		[Cpp2IlInjected.Address(RVA = "0x645E220", Offset = "0x645D620", VA = "0x18645E220")]
		public void AddForce(Vector3 BIOMHNNIJHG, ForceMode HODPBICIGJM = ForceMode.Force)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000096")]
		[Cpp2IlInjected.Address(RVA = "0x645E100", Offset = "0x645D500", VA = "0x18645E100")]
		public void AddForceAtPosition(Vector3 BIOMHNNIJHG, Vector3 DACBJNCMNFL, ForceMode HODPBICIGJM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000097")]
		[Cpp2IlInjected.Address(RVA = "0x645E420", Offset = "0x645D820", VA = "0x18645E420")]
		public void AddTorque(Vector3 CEBBAPNMMME, ForceMode HODPBICIGJM = ForceMode.Force)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000098")]
		[Cpp2IlInjected.Address(RVA = "0x645E390", Offset = "0x645D790", VA = "0x18645E390")]
		public void AddRelativeTorque(Vector3 CEBBAPNMMME, ForceMode HODPBICIGJM = ForceMode.Force)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000099")]
		[Cpp2IlInjected.Address(RVA = "0x64601B0", Offset = "0x645F5B0", VA = "0x1864601B0")]
		public Vector3 WorldToLocalVelocity(Vector3 ODPCODBLNJO)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x600009A")]
		[Cpp2IlInjected.Address(RVA = "0x645F430", Offset = "0x645E830", VA = "0x18645F430")]
		public Vector3 LocalToWorldVelocity(Vector3 DLOMDLEMEJO)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x600009B")]
		[Cpp2IlInjected.Address(RVA = "0x645EBF0", Offset = "0x645DFF0", VA = "0x18645EBF0")]
		public void ClearVelocity()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009C")]
		[Cpp2IlInjected.Address(RVA = "0x645EB90", Offset = "0x645DF90", VA = "0x18645EB90")]
		public void ClearUnityRigidbodyVelocity()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009D")]
		[Cpp2IlInjected.Address(RVA = "0x645EB30", Offset = "0x645DF30", VA = "0x18645EB30")]
		public void ClearLinearVelocity()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009E")]
		[Cpp2IlInjected.Address(RVA = "0x645EAD0", Offset = "0x645DED0", VA = "0x18645EAD0")]
		public void ClearAngularVelocity()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009F")]
		[Cpp2IlInjected.Address(RVA = "0x645FBD0", Offset = "0x645EFD0", VA = "0x18645FBD0")]
		public void ResetVelocityWorldSpace(Vector3 PKEOGDHOABC, Vector3 GNHLNIEHAFA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A0")]
		[Cpp2IlInjected.Address(RVA = "0x645FAD0", Offset = "0x645EED0", VA = "0x18645FAD0")]
		public void ResetVelocityLocalSpace(Vector3 IHHIJIKHHIA, Vector3 NBGIHKDGDID)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A1")]
		[Cpp2IlInjected.Address(RVA = "0x645F990", Offset = "0x645ED90", VA = "0x18645F990")]
		public void ResetLinearVelocityLocalSpace(Vector3 IHHIJIKHHIA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A2")]
		[Cpp2IlInjected.Address(RVA = "0x6460040", Offset = "0x645F440", VA = "0x186460040")]
		public bool SweepTest(Vector3 HHOIMIMHDMP, out RaycastHit CFGLFCONCKN, float KMAOMDJLDEN)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000A3")]
		[Cpp2IlInjected.Address(RVA = "0x645F3D0", Offset = "0x645E7D0", VA = "0x18645F3D0")]
		public bool IsSleeping()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000A4")]
		[Cpp2IlInjected.Address(RVA = "0x645FFE0", Offset = "0x645F3E0", VA = "0x18645FFE0")]
		public void Sleep()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A5")]
		[Cpp2IlInjected.Address(RVA = "0x6460150", Offset = "0x645F550", VA = "0x186460150")]
		public void WakeUp()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A6")]
		[Cpp2IlInjected.Address(RVA = "0x645E4B0", Offset = "0x645D8B0", VA = "0x18645E4B0")]
		public void AddUnityRigidbody(object AJDBKDIMOHA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A7")]
		[Cpp2IlInjected.Address(RVA = "0x645F8B0", Offset = "0x645ECB0", VA = "0x18645F8B0")]
		public void RemoveUnityRigidbody(object AJDBKDIMOHA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A8")]
		[Cpp2IlInjected.Address(RVA = "0x645E7D0", Offset = "0x645DBD0", VA = "0x18645E7D0")]
		public void ApplyForceVelocityChange(CBPMCKPIBHC EIOPEGEMKHP, Vector3 DKCLOLGBADH, float OOKLCGCBAJI, float LLKLELEIBGC = 8f, float AEEFHMKEOAH = 1f)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A9")]
		[Cpp2IlInjected.Address(RVA = "0x645E6D0", Offset = "0x645DAD0", VA = "0x18645E6D0")]
		public void ApplyAngularVelocityChange(BOPFIFMMKBG BPDOBLBNKEN, Vector3 NLFAAHHHDNN, float HHHNHCMFNFA = float.PositiveInfinity)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AA")]
		[Cpp2IlInjected.Address(RVA = "0x645E8F0", Offset = "0x645DCF0", VA = "0x18645E8F0")]
		[Obsolete]
		public void ApplyTorqueAngularVelocityChangeDeprecated(BOPFIFMMKBG BPDOBLBNKEN, Vector3 MCFIHGJCDCP, float BDCHAJELIHL = 7f, float ABPPGEHGCFI = 1f)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AB")]
		[Cpp2IlInjected.Address(RVA = "0x645E610", Offset = "0x645DA10", VA = "0x18645E610")]
		public bool AllowedScaleChange(float LCLMOJDNELD)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000AC")]
		[Cpp2IlInjected.Address(RVA = "0x645E520", Offset = "0x645D920", VA = "0x18645E520")]
		public void AddWorldSpaceVelocityInHierarchyParentOverride(RigidbodyEx FONAKEEEKPK, object AJDBKDIMOHA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AD")]
		[Cpp2IlInjected.Address(RVA = "0x645F920", Offset = "0x645ED20", VA = "0x18645F920")]
		public void RemoveWorldSpaceVelocityInHierarchyParentOverride(object AJDBKDIMOHA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AE")]
		[Cpp2IlInjected.Address(RVA = "0x6460300", Offset = "0x645F700", VA = "0x186460300")]
		public RigidbodyEx()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
internal static class PCGHKDLIIBP
{
	[Cpp2IlInjected.Token(Token = "0x60000B3")]
	[Cpp2IlInjected.Address(RVA = "0x54810F0", Offset = "0x54804F0", VA = "0x1854810F0")]
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
[Cpp2IlInjected.Token(Token = "0x200000E")]
[LOJIIDJFKAI(typeof(CMKMIKBKOHM), new string[] { })]
public class CMEJPIKFKNG : CMKMIKBKOHM, DPDCPMNGBKH
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000029")]
	private AKKPACBLFCH ONMGKKCFHAK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400002A")]
	private GNHCFBDDFCE FGFPMOHFMOM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400002B")]
	private KMBOJHAPLLI HBNLNEKDJID;

	[Cpp2IlInjected.Token(Token = "0x17000035")]
	public bool GAAOJBBKPNA
	{
		[Cpp2IlInjected.Token(Token = "0x60000B4")]
		[Cpp2IlInjected.Address(RVA = "0x5464070", Offset = "0x5463470", VA = "0x185464070", Slot = "6")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000036")]
	public GNHCFBDDFCE DDGABFFCPAP
	{
		[Cpp2IlInjected.Token(Token = "0x60000B5")]
		[Cpp2IlInjected.Address(RVA = "0x6E4140", Offset = "0x6E3540", VA = "0x1806E4140", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000037")]
	public KMBOJHAPLLI AJPHGKGIGMH
	{
		[Cpp2IlInjected.Token(Token = "0x60000B6")]
		[Cpp2IlInjected.Address(RVA = "0x6E4130", Offset = "0x6E3530", VA = "0x1806E4130", Slot = "5")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000B7")]
	[Cpp2IlInjected.Address(RVA = "0x5464490", Offset = "0x5463890", VA = "0x185464490", Slot = "10")]
	public void PEIMLKLDOFJ(JHLNNPKIFCO KOKEGENGCAH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B8")]
	[Cpp2IlInjected.Address(RVA = "0x54641F0", Offset = "0x54635F0", VA = "0x1854641F0", Slot = "7")]
	public NFJEDPPAJMK JIOOPANAKNB(RigidbodyEx LDDCANHDBNB)
	{
		return default(NFJEDPPAJMK);
	}

	[Cpp2IlInjected.Token(Token = "0x60000B9")]
	[Cpp2IlInjected.Address(RVA = "0x5463EE0", Offset = "0x54632E0", VA = "0x185463EE0")]
	private static NFJEDPPAJMK DCDBBDOBJFM(RigidbodyEx LDDCANHDBNB)
	{
		return default(NFJEDPPAJMK);
	}

	[Cpp2IlInjected.Token(Token = "0x60000BA")]
	[Cpp2IlInjected.Address(RVA = "0x5463FD0", Offset = "0x54633D0", VA = "0x185463FD0", Slot = "8")]
	public PPMDIHPMNCG EHCIKDFINKO(RigidbodyEx LDDCANHDBNB, OALOFNDFAEL ONIBEFDCPGD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000BB")]
	[Cpp2IlInjected.Address(RVA = "0x54640C0", Offset = "0x54634C0", VA = "0x1854640C0", Slot = "9")]
	private RigidbodyEx IHKOFEDLIAG(GameObject GODCAKDBDMK, OALOFNDFAEL ONIBEFDCPGD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000BC")]
	[Cpp2IlInjected.Address(RVA = "0x6D6CD0", Offset = "0x6D60D0", VA = "0x1806D6CD0")]
	public CMEJPIKFKNG()
	{
	}
}
namespace RecRoom
{
	[Cpp2IlInjected.Token(Token = "0x200000F")]
	public class PhysicsManager : SingletonMonoBehaviour<PhysicsManager>
	{
		[Cpp2IlInjected.Token(Token = "0x400002C")]
		public static CBKLEJNNKJH UpdateAfterFixedUpdateRan;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400002D")]
		private int LBPNIEKKGIC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x400002E")]
		private int HJMNFLMBKGE;

		[Cpp2IlInjected.Token(Token = "0x60000BD")]
		[Cpp2IlInjected.Address(RVA = "0x645DB70", Offset = "0x645CF70", VA = "0x18645DB70")]
		protected void FixedUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000BE")]
		[Cpp2IlInjected.Address(RVA = "0x645DBB0", Offset = "0x645CFB0", VA = "0x18645DBB0")]
		protected void Update()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000BF")]
		[Cpp2IlInjected.Address(RVA = "0x645DB90", Offset = "0x645CF90", VA = "0x18645DB90")]
		protected void LateUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C0")]
		[Cpp2IlInjected.Address(RVA = "0x6D7320", Offset = "0x6D6720", VA = "0x1806D7320")]
		[Conditional("UNITY_ASSERTIONS")]
		public void AssertLateColliderPositionsNotYetUpdated([Optional] string DENPJAMCNLD, [Optional] UnityEngine.Object MAFDHEKFLMG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C1")]
		[Cpp2IlInjected.Address(RVA = "0x6D7320", Offset = "0x6D6720", VA = "0x1806D7320")]
		[Conditional("UNITY_ASSERTIONS")]
		public void AssertLateColliderPositionsAlreadyUpdated([Optional] string DENPJAMCNLD, [Optional] UnityEngine.Object MAFDHEKFLMG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C2")]
		[Cpp2IlInjected.Address(RVA = "0x645DCA0", Offset = "0x645D0A0", VA = "0x18645DCA0")]
		public PhysicsManager()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
public static class APBFFBPJEDL
{
	[Cpp2IlInjected.Token(Token = "0x60000C4")]
	[Cpp2IlInjected.Address(RVA = "0x5461240", Offset = "0x5460640", VA = "0x185461240")]
	public static void HPBIJANCPAD(this Rigidbody PEAEJAGKHAK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C5")]
	[Cpp2IlInjected.Address(RVA = "0x5461130", Offset = "0x5460530", VA = "0x185461130")]
	public static void HPBIJANCPAD(this Rigidbody PEAEJAGKHAK, Vector3 KNIHAMHGBLN, Quaternion OPONCDOPJKK, Vector3 KFPBOOHEFMG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C6")]
	[Cpp2IlInjected.Address(RVA = "0x5461390", Offset = "0x5460790", VA = "0x185461390")]
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
		[Cpp2IlInjected.Token(Token = "0x60000C9")]
		[Cpp2IlInjected.Address(RVA = "0x6D7320", Offset = "0x6D6720", VA = "0x1806D7320", Slot = "6")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000CA")]
		[Cpp2IlInjected.Address(RVA = "0x977D60", Offset = "0x977160", VA = "0x180977D60", Slot = "4")]
		public Vector3 DFHCBEOPIPI()
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x60000CB")]
		[Cpp2IlInjected.Address(RVA = "0x977D60", Offset = "0x977160", VA = "0x180977D60", Slot = "5")]
		public Vector3 JFACHOANBJO()
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x60000CC")]
		[Cpp2IlInjected.Address(RVA = "0x6D6CD0", Offset = "0x6D60D0", VA = "0x1806D6CD0")]
		public KCMCHFONEEJ()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000038")]
	public static LKKOPIEOHJA CKBGDNCDKBB
	{
		[Cpp2IlInjected.Token(Token = "0x60000C7")]
		[Cpp2IlInjected.Address(RVA = "0x546F610", Offset = "0x546EA10", VA = "0x18546F610")]
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
		[Cpp2IlInjected.Token(Token = "0x60000CD")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
		[Cpp2IlInjected.Token(Token = "0x60000CE")]
		[Cpp2IlInjected.Address(Slot = "1")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x60000CF")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void BKOELLNKDDF();

	[Cpp2IlInjected.Token(Token = "0x60000D0")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void NAIFDEINDCM(bool IOEMIKGMLIB);

	[Cpp2IlInjected.Token(Token = "0x60000D1")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void HCJANJMAAPB(bool IOEMIKGMLIB);

	[Cpp2IlInjected.Token(Token = "0x60000D2")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void JPMOLDGLNJO(Rigidbody AOAFHPHKFMD);

	[Cpp2IlInjected.Token(Token = "0x60000D3")]
	[Cpp2IlInjected.Address(Slot = "6")]
	bool CGHFGDDABEK(Vector3 HHOIMIMHDMP, out RaycastHit CFGLFCONCKN, float KMAOMDJLDEN);
}
[Cpp2IlInjected.Token(Token = "0x2000014")]
public interface ODGCKIECBJN : IDisposable, NLJGMJFEGHJ
{
	[Cpp2IlInjected.Token(Token = "0x1700003A")]
	PPGNAFCKNOL NHFAJHMDKMA
	{
		[Cpp2IlInjected.Token(Token = "0x60000D6")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
		[Cpp2IlInjected.Token(Token = "0x60000D7")]
		[Cpp2IlInjected.Address(Slot = "3")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x1400000A")]
	event Action<LHLIDFNIOKA, LHLIDFNIOKA> GBMBMPKHBHO;

	[Cpp2IlInjected.Token(Token = "0x60000D8")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void BKOELLNKDDF();
}
[Cpp2IlInjected.Token(Token = "0x2000015")]
[KFMPJDNIPEO(JHCKAKNDFFP.Application)]
public interface KMBOJHAPLLI
{
	[Cpp2IlInjected.Token(Token = "0x60000D9")]
	[Cpp2IlInjected.Address(Slot = "0")]
	HMOOAGCGLKM MJLNOLDLKOJ(PPMDIHPMNCG ONJEPBGIHBB);

	[Cpp2IlInjected.Token(Token = "0x60000DA")]
	[Cpp2IlInjected.Address(Slot = "1")]
	MPILPIJAHDO MOHHJJFOLBM(PPMDIHPMNCG ONJEPBGIHBB);

	[Cpp2IlInjected.Token(Token = "0x60000DB")]
	[Cpp2IlInjected.Address(Slot = "2")]
	NPFLLLAFPDM IMEKOCFODBG(PPMDIHPMNCG ONJEPBGIHBB);

	[Cpp2IlInjected.Token(Token = "0x60000DC")]
	[Cpp2IlInjected.Address(Slot = "3")]
	KKCAAHMNCAO HEDEOJGLLAC(PPMDIHPMNCG ONJEPBGIHBB);

	[Cpp2IlInjected.Token(Token = "0x60000DD")]
	[Cpp2IlInjected.Address(Slot = "4")]
	BBGIBEMMCOA JNPIPKPJGAO(PPMDIHPMNCG ONJEPBGIHBB);

	[Cpp2IlInjected.Token(Token = "0x60000DE")]
	[Cpp2IlInjected.Address(Slot = "5")]
	ODGCKIECBJN HEMHCEJPPBH(PPMDIHPMNCG ONJEPBGIHBB);

	[Cpp2IlInjected.Token(Token = "0x60000DF")]
	[Cpp2IlInjected.Address(Slot = "6")]
	GAMBABDLKNB GBHLIFIGFGO(PPMDIHPMNCG ONJEPBGIHBB);

	[Cpp2IlInjected.Token(Token = "0x60000E0")]
	[Cpp2IlInjected.Address(Slot = "7")]
	FGHCKEELDLL HDCLGAJOJOG(PPMDIHPMNCG ONJEPBGIHBB);

	[Cpp2IlInjected.Token(Token = "0x60000E1")]
	[Cpp2IlInjected.Address(Slot = "8")]
	APGGGIKOMPN AJBLCMCEIMG(PPMDIHPMNCG ONJEPBGIHBB);

	[Cpp2IlInjected.Token(Token = "0x60000E2")]
	[Cpp2IlInjected.Address(Slot = "9")]
	LMMEICEFKMM JIMOFCMOFGN(PPMDIHPMNCG ONJEPBGIHBB);

	[Cpp2IlInjected.Token(Token = "0x60000E3")]
	[Cpp2IlInjected.Address(Slot = "10")]
	HONAINACCHA EPFJODDPHNJ(PPMDIHPMNCG ONJEPBGIHBB, in OALOFNDFAEL ONIBEFDCPGD);

	[Cpp2IlInjected.Token(Token = "0x60000E4")]
	[Cpp2IlInjected.Address(Slot = "11")]
	LNJFNCEGNCA IMOGAPPPDNI(PPMDIHPMNCG ONJEPBGIHBB, in OALOFNDFAEL ONIBEFDCPGD);

	[Cpp2IlInjected.Token(Token = "0x60000E5")]
	[Cpp2IlInjected.Address(Slot = "12")]
	EBCDLOKEBCP MEDAGDCIAAG(PPMDIHPMNCG ONJEPBGIHBB, in OALOFNDFAEL ONIBEFDCPGD);

	[Cpp2IlInjected.Token(Token = "0x60000E6")]
	[Cpp2IlInjected.Address(Slot = "13")]
	HEFJBMMENIM PIKOPGMPFFO(PPMDIHPMNCG ONJEPBGIHBB, in OALOFNDFAEL ONIBEFDCPGD);

	[Cpp2IlInjected.Token(Token = "0x60000E7")]
	[Cpp2IlInjected.Address(Slot = "14")]
	OIAJBEDDNGM NOELAMDCDMI(PPMDIHPMNCG ONJEPBGIHBB, in OALOFNDFAEL ONIBEFDCPGD);

	[Cpp2IlInjected.Token(Token = "0x60000E8")]
	[Cpp2IlInjected.Address(Slot = "15")]
	PPMDIHPMNCG EHCIKDFINKO(RigidbodyEx LDDCANHDBNB, OALOFNDFAEL ONIBEFDCPGD, CMKMIKBKOHM OBOKKBNADPB);
}
[Cpp2IlInjected.Token(Token = "0x2000016")]
public interface FGHCKEELDLL
{
	[Cpp2IlInjected.Token(Token = "0x60000E9")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void MDAEENKEECK(Vector3 BIOMHNNIJHG, ForceMode HODPBICIGJM = ForceMode.Force);

	[Cpp2IlInjected.Token(Token = "0x60000EA")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void LIGCOMLMAAG(Vector3 BIOMHNNIJHG, Vector3 DACBJNCMNFL, ForceMode HODPBICIGJM);

	[Cpp2IlInjected.Token(Token = "0x60000EB")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void DPFOGKDMEOC(Vector3 CEBBAPNMMME, ForceMode HODPBICIGJM = ForceMode.Force);

	[Cpp2IlInjected.Token(Token = "0x60000EC")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void BFACFHPBMFM(Vector3 CEBBAPNMMME, ForceMode HODPBICIGJM = ForceMode.Force);
}
[Cpp2IlInjected.Token(Token = "0x2000017")]
public interface LMMEICEFKMM
{
	[Cpp2IlInjected.Token(Token = "0x1700003B")]
	bool HLADCICNJBO
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
	void JPMOLDGLNJO(Rigidbody AOAFHPHKFMD);

	[Cpp2IlInjected.Token(Token = "0x60000F0")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void AAGPIEFPDDG(Rigidbody AOAFHPHKFMD);
}
[Cpp2IlInjected.Token(Token = "0x2000018")]
public interface HMOOAGCGLKM : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x1700003C")]
	IReadOnlyList<PPMDIHPMNCG> LILCAAEDFCG
	{
		[Cpp2IlInjected.Token(Token = "0x6000103")]
		[Cpp2IlInjected.Address(Slot = "18")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700003D")]
	PPMDIHPMNCG MDHMHFAIMJJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000104")]
		[Cpp2IlInjected.Address(Slot = "19")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700003E")]
	PPMDIHPMNCG EMIBHNNCMJC
	{
		[Cpp2IlInjected.Token(Token = "0x6000105")]
		[Cpp2IlInjected.Address(Slot = "20")]
		get;
		[Cpp2IlInjected.Token(Token = "0x6000106")]
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

	[Cpp2IlInjected.Token(Token = "0x6000107")]
	[Cpp2IlInjected.Address(Slot = "22")]
	void KKGLFGKJMPP(PPMDIHPMNCG DPPABCPODHG, bool LMKLDOOIJAA = false);
}
[Cpp2IlInjected.Token(Token = "0x2000019")]
public interface NPFLLLAFPDM
{
	[Cpp2IlInjected.Token(Token = "0x1700003F")]
	Vector3 DJHICJGOGJI
	{
		[Cpp2IlInjected.Token(Token = "0x6000108")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000040")]
	Vector3 EOFHLAGNPII
	{
		[Cpp2IlInjected.Token(Token = "0x6000109")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x600010A")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void CNAAFOJMHNK(PPMDIHPMNCG GPFONCECPBK, object AJDBKDIMOHA);

	[Cpp2IlInjected.Token(Token = "0x600010B")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void JOEIIPCOBII(object AJDBKDIMOHA);
}
[Cpp2IlInjected.Token(Token = "0x200001A")]
public interface HEFJBMMENIM
{
	[Cpp2IlInjected.Token(Token = "0x17000041")]
	Vector3 JMIIJDMAMEI
	{
		[Cpp2IlInjected.Token(Token = "0x600010E")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
		[Cpp2IlInjected.Token(Token = "0x600010F")]
		[Cpp2IlInjected.Address(Slot = "3")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000042")]
	Vector3 PMKFGPJNJBI
	{
		[Cpp2IlInjected.Token(Token = "0x6000110")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000043")]
	float KLNDCEHFMBA
	{
		[Cpp2IlInjected.Token(Token = "0x6000111")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000044")]
	float NBJLLACMBLF
	{
		[Cpp2IlInjected.Token(Token = "0x6000112")]
		[Cpp2IlInjected.Address(Slot = "6")]
		get;
		[Cpp2IlInjected.Token(Token = "0x6000113")]
		[Cpp2IlInjected.Address(Slot = "7")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000045")]
	Vector3 OFFHJCCLOEB
	{
		[Cpp2IlInjected.Token(Token = "0x6000114")]
		[Cpp2IlInjected.Address(Slot = "8")]
		get;
		[Cpp2IlInjected.Token(Token = "0x6000115")]
		[Cpp2IlInjected.Address(Slot = "9")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000046")]
	Quaternion MOMBOPJMDMK
	{
		[Cpp2IlInjected.Token(Token = "0x6000116")]
		[Cpp2IlInjected.Address(Slot = "10")]
		get;
		[Cpp2IlInjected.Token(Token = "0x6000117")]
		[Cpp2IlInjected.Address(Slot = "11")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x14000014")]
	event JPOFABMOGOF GOMGJPJMHIM;

	[Cpp2IlInjected.Token(Token = "0x6000118")]
	[Cpp2IlInjected.Address(Slot = "12")]
	void LGMIOPKMACL();

	[Cpp2IlInjected.Token(Token = "0x6000119")]
	[Cpp2IlInjected.Address(Slot = "13")]
	void OCCLJJBDHKH();

	[Cpp2IlInjected.Token(Token = "0x600011A")]
	[Cpp2IlInjected.Address(Slot = "14")]
	void PGLMPJOADGG();

	[Cpp2IlInjected.Token(Token = "0x600011B")]
	[Cpp2IlInjected.Address(Slot = "15")]
	void JPMOLDGLNJO(Rigidbody AOAFHPHKFMD);

	[Cpp2IlInjected.Token(Token = "0x600011C")]
	[Cpp2IlInjected.Address(Slot = "16")]
	void AAGPIEFPDDG(Rigidbody AOAFHPHKFMD);

	[Cpp2IlInjected.Token(Token = "0x600011D")]
	[Cpp2IlInjected.Address(Slot = "17")]
	void KEPOLBAFIFI();
}
[Cpp2IlInjected.Token(Token = "0x200001B")]
public interface EBCDLOKEBCP
{
	[Cpp2IlInjected.Token(Token = "0x17000047")]
	bool FKLEIIKAOJF
	{
		[Cpp2IlInjected.Token(Token = "0x600011E")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000048")]
	GDPCJHNBEPD MDBJGCBLKKA
	{
		[Cpp2IlInjected.Token(Token = "0x600011F")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000120")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void BKOELLNKDDF();

	[Cpp2IlInjected.Token(Token = "0x6000121")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void MPHPJCHHDKL(object AJDBKDIMOHA);

	[Cpp2IlInjected.Token(Token = "0x6000122")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void NEGAEOLBLHL(object AJDBKDIMOHA);

	[Cpp2IlInjected.Token(Token = "0x6000123")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void BKKMBNFHKCE(PPMDIHPMNCG LDDCANHDBNB);

	[Cpp2IlInjected.Token(Token = "0x6000124")]
	[Cpp2IlInjected.Address(Slot = "6")]
	void ONIPMDLLNFC(PPMDIHPMNCG LDDCANHDBNB);

	[Cpp2IlInjected.Token(Token = "0x6000125")]
	[Cpp2IlInjected.Address(Slot = "7")]
	void HIJAJPCLBLB();
}
[Cpp2IlInjected.Token(Token = "0x200001C")]
public interface GAMBABDLKNB
{
	[Cpp2IlInjected.Token(Token = "0x17000049")]
	bool MBEHMAPDJBJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000128")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700004A")]
	IEnumerable<object> EKIDKKGDMDH
	{
		[Cpp2IlInjected.Token(Token = "0x6000129")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x14000015")]
	event JPOFABMOGOF JDAOGMBMFNA;

	[Cpp2IlInjected.Token(Token = "0x600012A")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void IDBKKNHMJCA(object AJDBKDIMOHA);

	[Cpp2IlInjected.Token(Token = "0x600012B")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void BPLEOILKCFF(object AJDBKDIMOHA);

	[Cpp2IlInjected.Token(Token = "0x600012C")]
	[Cpp2IlInjected.Address(Slot = "6")]
	void NHDILIPFEBO(object AJDBKDIMOHA, bool NMHFDHPJGFL);

	[Cpp2IlInjected.Token(Token = "0x600012D")]
	[Cpp2IlInjected.Address(Slot = "7")]
	IDisposable BFJJEOKEAOO();

	[Cpp2IlInjected.Token(Token = "0x600012E")]
	[Cpp2IlInjected.Address(Slot = "8")]
	void JPMOLDGLNJO(Rigidbody IHFIBCKLILB);

	[Cpp2IlInjected.Token(Token = "0x600012F")]
	[Cpp2IlInjected.Address(Slot = "9")]
	void AAGPIEFPDDG(Rigidbody AOAFHPHKFMD);
}
[Cpp2IlInjected.Token(Token = "0x200001D")]
public interface LNJFNCEGNCA : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x1700004B")]
	bool PJPIAHDKHLD
	{
		[Cpp2IlInjected.Token(Token = "0x6000132")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700004C")]
	bool EMGPBBGPGIE
	{
		[Cpp2IlInjected.Token(Token = "0x6000133")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x14000016")]
	event JPOFABMOGOF OFDNMEKJKBP;

	[Cpp2IlInjected.Token(Token = "0x6000134")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void BKOELLNKDDF();

	[Cpp2IlInjected.Token(Token = "0x6000135")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void EDMPHFFCDKG(PPMDIHPMNCG GPFONCECPBK);

	[Cpp2IlInjected.Token(Token = "0x6000136")]
	[Cpp2IlInjected.Address(Slot = "6")]
	void CLFEMCONLMI(PPMDIHPMNCG GPFONCECPBK);
}
[Cpp2IlInjected.Token(Token = "0x200001E")]
public interface OIAJBEDDNGM
{
	[Cpp2IlInjected.Token(Token = "0x1700004D")]
	bool PJGCDNLPGAK
	{
		[Cpp2IlInjected.Token(Token = "0x6000137")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
		[Cpp2IlInjected.Token(Token = "0x6000138")]
		[Cpp2IlInjected.Address(Slot = "1")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x1700004E")]
	bool AGHKJBONNGE
	{
		[Cpp2IlInjected.Token(Token = "0x6000139")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700004F")]
	RigidbodyConstraints BCMJAHAELOH
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
	void JPMOLDGLNJO(Rigidbody AOAFHPHKFMD);

	[Cpp2IlInjected.Token(Token = "0x600013D")]
	[Cpp2IlInjected.Address(Slot = "6")]
	void AAGPIEFPDDG(Rigidbody AOAFHPHKFMD);
}
[Cpp2IlInjected.Token(Token = "0x200001F")]
public interface KKCAAHMNCAO
{
	[Cpp2IlInjected.Token(Token = "0x17000050")]
	float FCGOFCPMIGL
	{
		[Cpp2IlInjected.Token(Token = "0x600013E")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
		[Cpp2IlInjected.Token(Token = "0x600013F")]
		[Cpp2IlInjected.Address(Slot = "1")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000051")]
	float CFMIJLIHCIE
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
	void JPMOLDGLNJO(Rigidbody AOAFHPHKFMD);

	[Cpp2IlInjected.Token(Token = "0x6000143")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void AAGPIEFPDDG(Rigidbody AOAFHPHKFMD);
}
[Cpp2IlInjected.Token(Token = "0x2000020")]
public interface GOFJGELBDJC
{
	[Cpp2IlInjected.Token(Token = "0x6000144")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void OnRootRBEXChanged(RigidbodyEx KJMHEDJIAAJ);
}
[Cpp2IlInjected.Token(Token = "0x2000021")]
public interface BBGIBEMMCOA
{
	[Cpp2IlInjected.Token(Token = "0x14000017")]
	event JPOFABMOGOF MLDKIENLGJG;

	[Cpp2IlInjected.Token(Token = "0x6000147")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void BKOELLNKDDF();

	[Cpp2IlInjected.Token(Token = "0x6000148")]
	[Cpp2IlInjected.Address(Slot = "3")]
	bool JLGKLAGDNBA();

	[Cpp2IlInjected.Token(Token = "0x6000149")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void ABJCFICOBMJ();

	[Cpp2IlInjected.Token(Token = "0x600014A")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void HFOIEEGNPME();

	[Cpp2IlInjected.Token(Token = "0x600014B")]
	[Cpp2IlInjected.Address(Slot = "6")]
	void LHCKEPPOJKM();

	[Cpp2IlInjected.Token(Token = "0x600014C")]
	[Cpp2IlInjected.Address(Slot = "7")]
	void IPODHJMCCPD();

	[Cpp2IlInjected.Token(Token = "0x600014D")]
	[Cpp2IlInjected.Address(Slot = "8")]
	void GCGBBMHMBBI(bool DMEOICFENFA);
}
[Cpp2IlInjected.Token(Token = "0x2000022")]
public interface HONAINACCHA
{
	[Cpp2IlInjected.Token(Token = "0x17000052")]
	Rigidbody BAPEKECGLDP
	{
		[Cpp2IlInjected.Token(Token = "0x600014E")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x600014F")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void BKOELLNKDDF();

	[Cpp2IlInjected.Token(Token = "0x6000150")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void NMDKIGJCKAP(object AJDBKDIMOHA);

	[Cpp2IlInjected.Token(Token = "0x6000151")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void IGIJDOMADBN(object AJDBKDIMOHA);

	[Cpp2IlInjected.Token(Token = "0x6000152")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void OHCCCGHNBBD();

	[Cpp2IlInjected.Token(Token = "0x6000153")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void GGGGLIFJEPO();

	[Cpp2IlInjected.Token(Token = "0x6000154")]
	[Cpp2IlInjected.Address(Slot = "6")]
	void AELIAEFBMCN();

	[Cpp2IlInjected.Token(Token = "0x6000155")]
	[Cpp2IlInjected.Address(Slot = "7")]
	void JNJCHBBCJEP();
}
[Cpp2IlInjected.Token(Token = "0x2000023")]
public interface MPILPIJAHDO : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x17000053")]
	LKKOPIEOHJA OLDOEMJHCAC
	{
		[Cpp2IlInjected.Token(Token = "0x6000156")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
		[Cpp2IlInjected.Token(Token = "0x6000157")]
		[Cpp2IlInjected.Address(Slot = "1")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000054")]
	FDHNJKMJJJG AEPCDANKKNF
	{
		[Cpp2IlInjected.Token(Token = "0x6000158")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
		[Cpp2IlInjected.Token(Token = "0x6000159")]
		[Cpp2IlInjected.Address(Slot = "3")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000055")]
	Vector3 MHCLHNEGJDD
	{
		[Cpp2IlInjected.Token(Token = "0x600015A")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
		[Cpp2IlInjected.Token(Token = "0x600015B")]
		[Cpp2IlInjected.Address(Slot = "5")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000056")]
	Vector3 JMJCCDADJPC
	{
		[Cpp2IlInjected.Token(Token = "0x600015C")]
		[Cpp2IlInjected.Address(Slot = "6")]
		get;
		[Cpp2IlInjected.Token(Token = "0x600015D")]
		[Cpp2IlInjected.Address(Slot = "7")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000057")]
	Vector3 DLFBGEBKEHJ
	{
		[Cpp2IlInjected.Token(Token = "0x600015E")]
		[Cpp2IlInjected.Address(Slot = "8")]
		get;
		[Cpp2IlInjected.Token(Token = "0x600015F")]
		[Cpp2IlInjected.Address(Slot = "9")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000058")]
	Vector3 KGONIIPAFMK
	{
		[Cpp2IlInjected.Token(Token = "0x6000160")]
		[Cpp2IlInjected.Address(Slot = "10")]
		get;
		[Cpp2IlInjected.Token(Token = "0x6000161")]
		[Cpp2IlInjected.Address(Slot = "11")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000059")]
	float ENFIJFJPIPJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000162")]
		[Cpp2IlInjected.Address(Slot = "12")]
		get;
		[Cpp2IlInjected.Token(Token = "0x6000163")]
		[Cpp2IlInjected.Address(Slot = "13")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x1700005A")]
	bool OIAJDGKIDMB
	{
		[Cpp2IlInjected.Token(Token = "0x6000164")]
		[Cpp2IlInjected.Address(Slot = "14")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000165")]
	[Cpp2IlInjected.Address(Slot = "15")]
	void BKOELLNKDDF();

	[Cpp2IlInjected.Token(Token = "0x6000166")]
	[Cpp2IlInjected.Address(Slot = "16")]
	void HHNPBMOKIFP(object AJDBKDIMOHA);

	[Cpp2IlInjected.Token(Token = "0x6000167")]
	[Cpp2IlInjected.Address(Slot = "17")]
	void JLNINMHMEHA(BOPFIFMMKBG BPDOBLBNKEN, Vector3 NLFAAHHHDNN, float HHHNHCMFNFA = float.PositiveInfinity);

	[Cpp2IlInjected.Token(Token = "0x6000168")]
	[Cpp2IlInjected.Address(Slot = "18")]
	void GOHOEPELEBG(CBPMCKPIBHC EIOPEGEMKHP, Vector3 DKCLOLGBADH, float OOKLCGCBAJI, float LLKLELEIBGC = 8f, float AEEFHMKEOAH = 1f);

	[Cpp2IlInjected.Token(Token = "0x6000169")]
	[Cpp2IlInjected.Address(Slot = "19")]
	void ADCBOLCDFHD(BOPFIFMMKBG BPDOBLBNKEN, Vector3 MCFIHGJCDCP, float BDCHAJELIHL = 7f, float ABPPGEHGCFI = 1f);

	[Cpp2IlInjected.Token(Token = "0x600016A")]
	[Cpp2IlInjected.Address(Slot = "20")]
	void IBIENENFOLO();

	[Cpp2IlInjected.Token(Token = "0x600016B")]
	[Cpp2IlInjected.Address(Slot = "21")]
	void DGADOFDPFDE();

	[Cpp2IlInjected.Token(Token = "0x600016C")]
	[Cpp2IlInjected.Address(Slot = "22")]
	void KDDHFACBKGB();

	[Cpp2IlInjected.Token(Token = "0x600016D")]
	[Cpp2IlInjected.Address(Slot = "23")]
	void LNGHCMNGELC();

	[Cpp2IlInjected.Token(Token = "0x600016E")]
	[Cpp2IlInjected.Address(Slot = "24")]
	void JPMOLDGLNJO(Rigidbody AOAFHPHKFMD);

	[Cpp2IlInjected.Token(Token = "0x600016F")]
	[Cpp2IlInjected.Address(Slot = "25")]
	Vector3 FHKEINJELIE(Vector3 IMJEKHOJGKC);

	[Cpp2IlInjected.Token(Token = "0x6000170")]
	[Cpp2IlInjected.Address(Slot = "26")]
	Vector3 KPFDHGBBOFB(Vector3 BNEEGIEDHBB);

	[Cpp2IlInjected.Token(Token = "0x6000171")]
	[Cpp2IlInjected.Address(Slot = "27")]
	void NFNEBKIHHFL(object AJDBKDIMOHA);

	[Cpp2IlInjected.Token(Token = "0x6000172")]
	[Cpp2IlInjected.Address(Slot = "28")]
	void CADMMMANGFL(Vector3 GJKLLEKAGBH);

	[Cpp2IlInjected.Token(Token = "0x6000173")]
	[Cpp2IlInjected.Address(Slot = "29")]
	void BNKAMLPDNDH(Vector3 IHHIJIKHHIA, Vector3 NBGIHKDGDID);

	[Cpp2IlInjected.Token(Token = "0x6000174")]
	[Cpp2IlInjected.Address(Slot = "30")]
	void EEIOJCMLKKL(Vector3 PKEOGDHOABC, Vector3 GNHLNIEHAFA);

	[Cpp2IlInjected.Token(Token = "0x6000175")]
	[Cpp2IlInjected.Address(Slot = "31")]
	Vector3 JGGPKLHDPOC(Vector3 DLOMDLEMEJO);

	[Cpp2IlInjected.Token(Token = "0x6000176")]
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
		[Cpp2IlInjected.Token(Token = "0x6000177")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000178")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void HMDKABCPDKD(string GNLLAOFLEDB);

	[Cpp2IlInjected.Token(Token = "0x6000179")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void PMLEKKPAIBC(RigidbodyEx LDDCANHDBNB, Action GPNJNMLGIEN);

	[Cpp2IlInjected.Token(Token = "0x600017A")]
	[Cpp2IlInjected.Address(Slot = "3")]
	GNJJFOIGADA JJJBOPMPOCL(int BDENIEGMNAP);

	[Cpp2IlInjected.Token(Token = "0x600017B")]
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
		[Cpp2IlInjected.Token(Token = "0x600017C")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700005D")]
	KMBOJHAPLLI AJPHGKGIGMH
	{
		[Cpp2IlInjected.Token(Token = "0x600017D")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700005E")]
	bool GAAOJBBKPNA
	{
		[Cpp2IlInjected.Token(Token = "0x600017E")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x600017F")]
	[Cpp2IlInjected.Address(Slot = "3")]
	NFJEDPPAJMK JIOOPANAKNB(RigidbodyEx LDDCANHDBNB);

	[Cpp2IlInjected.Token(Token = "0x6000180")]
	[Cpp2IlInjected.Address(Slot = "4")]
	PPMDIHPMNCG EHCIKDFINKO(RigidbodyEx LDDCANHDBNB, OALOFNDFAEL ONIBEFDCPGD);

	[Cpp2IlInjected.Token(Token = "0x6000181")]
	[Cpp2IlInjected.Address(Slot = "5")]
	internal RigidbodyEx AMGMAIHKJLG(GameObject GODCAKDBDMK, [Optional] OALOFNDFAEL ONIBEFDCPGD);
}
[Cpp2IlInjected.Token(Token = "0x2000026")]
public interface FDHNJKMJJJG
{
	[Cpp2IlInjected.Token(Token = "0x6000182")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void OCNAJBANMGG(Vector3 HMNIOJGIDOK);

	[Cpp2IlInjected.Token(Token = "0x6000183")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void KPADOHKNGPN(Vector3 IMJEKHOJGKC);

	[Cpp2IlInjected.Token(Token = "0x6000184")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void CCONFCPCPLH(Vector3 HMNIOJGIDOK);

	[Cpp2IlInjected.Token(Token = "0x6000185")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void IBNNPKPFJFE(Vector3 IMJEKHOJGKC);
}
[Cpp2IlInjected.Token(Token = "0x2000027")]
public interface LKKOPIEOHJA : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x6000186")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Vector3 DFHCBEOPIPI();

	[Cpp2IlInjected.Token(Token = "0x6000187")]
	[Cpp2IlInjected.Address(Slot = "1")]
	Vector3 JFACHOANBJO();
}
[Cpp2IlInjected.Token(Token = "0x2000028")]
public interface PPMDIHPMNCG : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x1700005F")]
	Rigidbody BAPEKECGLDP
	{
		[Cpp2IlInjected.Token(Token = "0x6000188")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000060")]
	RigidbodyEx JKIDPKKAFKH
	{
		[Cpp2IlInjected.Token(Token = "0x6000189")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000061")]
	GameObject MNGKPNJJMOC
	{
		[Cpp2IlInjected.Token(Token = "0x600018A")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000062")]
	Transform LNPNGFHHEEL
	{
		[Cpp2IlInjected.Token(Token = "0x600018B")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000063")]
	IEnumerable<object> JNIPNMIKJIN
	{
		[Cpp2IlInjected.Token(Token = "0x600018C")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000064")]
	PPMDIHPMNCG EMIBHNNCMJC
	{
		[Cpp2IlInjected.Token(Token = "0x600018D")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
		[Cpp2IlInjected.Token(Token = "0x600018E")]
		[Cpp2IlInjected.Address(Slot = "6")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000065")]
	IReadOnlyList<PPMDIHPMNCG> LILCAAEDFCG
	{
		[Cpp2IlInjected.Token(Token = "0x600018F")]
		[Cpp2IlInjected.Address(Slot = "7")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000066")]
	PPMDIHPMNCG MDHMHFAIMJJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000190")]
		[Cpp2IlInjected.Address(Slot = "8")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000067")]
	bool DKNFKPAFDPB
	{
		[Cpp2IlInjected.Token(Token = "0x6000191")]
		[Cpp2IlInjected.Address(Slot = "9")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000068")]
	bool PJPIAHDKHLD
	{
		[Cpp2IlInjected.Token(Token = "0x6000192")]
		[Cpp2IlInjected.Address(Slot = "10")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000069")]
	bool EMGPBBGPGIE
	{
		[Cpp2IlInjected.Token(Token = "0x6000193")]
		[Cpp2IlInjected.Address(Slot = "11")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700006A")]
	LKKOPIEOHJA OLDOEMJHCAC
	{
		[Cpp2IlInjected.Token(Token = "0x6000194")]
		[Cpp2IlInjected.Address(Slot = "12")]
		get;
		[Cpp2IlInjected.Token(Token = "0x6000195")]
		[Cpp2IlInjected.Address(Slot = "13")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x1700006B")]
	FDHNJKMJJJG AEPCDANKKNF
	{
		[Cpp2IlInjected.Token(Token = "0x6000196")]
		[Cpp2IlInjected.Address(Slot = "14")]
		get;
		[Cpp2IlInjected.Token(Token = "0x6000197")]
		[Cpp2IlInjected.Address(Slot = "15")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x1700006C")]
	float ENFIJFJPIPJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000198")]
		[Cpp2IlInjected.Address(Slot = "16")]
		get;
		[Cpp2IlInjected.Token(Token = "0x6000199")]
		[Cpp2IlInjected.Address(Slot = "17")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x1700006D")]
	Vector3 JMJCCDADJPC
	{
		[Cpp2IlInjected.Token(Token = "0x600019A")]
		[Cpp2IlInjected.Address(Slot = "18")]
		get;
		[Cpp2IlInjected.Token(Token = "0x600019B")]
		[Cpp2IlInjected.Address(Slot = "19")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x1700006E")]
	Vector3 KGONIIPAFMK
	{
		[Cpp2IlInjected.Token(Token = "0x600019C")]
		[Cpp2IlInjected.Address(Slot = "20")]
		get;
		[Cpp2IlInjected.Token(Token = "0x600019D")]
		[Cpp2IlInjected.Address(Slot = "21")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x1700006F")]
	Vector3 MHCLHNEGJDD
	{
		[Cpp2IlInjected.Token(Token = "0x600019E")]
		[Cpp2IlInjected.Address(Slot = "22")]
		get;
		[Cpp2IlInjected.Token(Token = "0x600019F")]
		[Cpp2IlInjected.Address(Slot = "23")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000070")]
	Vector3 DLFBGEBKEHJ
	{
		[Cpp2IlInjected.Token(Token = "0x60001A0")]
		[Cpp2IlInjected.Address(Slot = "24")]
		get;
		[Cpp2IlInjected.Token(Token = "0x60001A1")]
		[Cpp2IlInjected.Address(Slot = "25")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000071")]
	bool AMMPJIIANJD
	{
		[Cpp2IlInjected.Token(Token = "0x60001A2")]
		[Cpp2IlInjected.Address(Slot = "26")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000072")]
	bool OONHJPFBNAB
	{
		[Cpp2IlInjected.Token(Token = "0x60001A3")]
		[Cpp2IlInjected.Address(Slot = "27")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000073")]
	bool AKAANNKOEAC
	{
		[Cpp2IlInjected.Token(Token = "0x60001A4")]
		[Cpp2IlInjected.Address(Slot = "28")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000074")]
	bool OIAJDGKIDMB
	{
		[Cpp2IlInjected.Token(Token = "0x60001A5")]
		[Cpp2IlInjected.Address(Slot = "29")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000075")]
	Vector3 DJHICJGOGJI
	{
		[Cpp2IlInjected.Token(Token = "0x60001A6")]
		[Cpp2IlInjected.Address(Slot = "30")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000076")]
	Vector3 EOFHLAGNPII
	{
		[Cpp2IlInjected.Token(Token = "0x60001A7")]
		[Cpp2IlInjected.Address(Slot = "31")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000077")]
	Vector3 JMIIJDMAMEI
	{
		[Cpp2IlInjected.Token(Token = "0x60001A8")]
		[Cpp2IlInjected.Address(Slot = "32")]
		get;
		[Cpp2IlInjected.Token(Token = "0x60001A9")]
		[Cpp2IlInjected.Address(Slot = "33")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000078")]
	Vector3 PMKFGPJNJBI
	{
		[Cpp2IlInjected.Token(Token = "0x60001AA")]
		[Cpp2IlInjected.Address(Slot = "34")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000079")]
	float KLNDCEHFMBA
	{
		[Cpp2IlInjected.Token(Token = "0x60001AB")]
		[Cpp2IlInjected.Address(Slot = "35")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700007A")]
	float NBJLLACMBLF
	{
		[Cpp2IlInjected.Token(Token = "0x60001AC")]
		[Cpp2IlInjected.Address(Slot = "36")]
		get;
		[Cpp2IlInjected.Token(Token = "0x60001AD")]
		[Cpp2IlInjected.Address(Slot = "37")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x1700007B")]
	Vector3 OFFHJCCLOEB
	{
		[Cpp2IlInjected.Token(Token = "0x60001AE")]
		[Cpp2IlInjected.Address(Slot = "38")]
		get;
		[Cpp2IlInjected.Token(Token = "0x60001AF")]
		[Cpp2IlInjected.Address(Slot = "39")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x1700007C")]
	Quaternion MOMBOPJMDMK
	{
		[Cpp2IlInjected.Token(Token = "0x60001B0")]
		[Cpp2IlInjected.Address(Slot = "40")]
		get;
		[Cpp2IlInjected.Token(Token = "0x60001B1")]
		[Cpp2IlInjected.Address(Slot = "41")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x1700007D")]
	float FCGOFCPMIGL
	{
		[Cpp2IlInjected.Token(Token = "0x60001B2")]
		[Cpp2IlInjected.Address(Slot = "42")]
		get;
		[Cpp2IlInjected.Token(Token = "0x60001B3")]
		[Cpp2IlInjected.Address(Slot = "43")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x1700007E")]
	float CFMIJLIHCIE
	{
		[Cpp2IlInjected.Token(Token = "0x60001B4")]
		[Cpp2IlInjected.Address(Slot = "44")]
		get;
		[Cpp2IlInjected.Token(Token = "0x60001B5")]
		[Cpp2IlInjected.Address(Slot = "45")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x1700007F")]
	bool HLADCICNJBO
	{
		[Cpp2IlInjected.Token(Token = "0x60001B6")]
		[Cpp2IlInjected.Address(Slot = "46")]
		get;
		[Cpp2IlInjected.Token(Token = "0x60001B7")]
		[Cpp2IlInjected.Address(Slot = "47")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000080")]
	PPGNAFCKNOL NHFAJHMDKMA
	{
		[Cpp2IlInjected.Token(Token = "0x60001B8")]
		[Cpp2IlInjected.Address(Slot = "48")]
		get;
		[Cpp2IlInjected.Token(Token = "0x60001B9")]
		[Cpp2IlInjected.Address(Slot = "49")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000081")]
	bool MBEHMAPDJBJ
	{
		[Cpp2IlInjected.Token(Token = "0x60001BA")]
		[Cpp2IlInjected.Address(Slot = "50")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000082")]
	Transform PDLNBKLCFJO
	{
		[Cpp2IlInjected.Token(Token = "0x60001BB")]
		[Cpp2IlInjected.Address(Slot = "51")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000083")]
	Transform IPOOCBGBBCA
	{
		[Cpp2IlInjected.Token(Token = "0x60001BC")]
		[Cpp2IlInjected.Address(Slot = "52")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000084")]
	Vector3 GCIAIFNDFJO
	{
		[Cpp2IlInjected.Token(Token = "0x60001BD")]
		[Cpp2IlInjected.Address(Slot = "53")]
		get;
		[Cpp2IlInjected.Token(Token = "0x60001BE")]
		[Cpp2IlInjected.Address(Slot = "54")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000085")]
	float BIJKBCGODIE
	{
		[Cpp2IlInjected.Token(Token = "0x60001BF")]
		[Cpp2IlInjected.Address(Slot = "55")]
		get;
		[Cpp2IlInjected.Token(Token = "0x60001C0")]
		[Cpp2IlInjected.Address(Slot = "56")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000086")]
	float CAEPFBBJBOK
	{
		[Cpp2IlInjected.Token(Token = "0x60001C1")]
		[Cpp2IlInjected.Address(Slot = "57")]
		get;
		[Cpp2IlInjected.Token(Token = "0x60001C2")]
		[Cpp2IlInjected.Address(Slot = "58")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000087")]
	Quaternion LBGIBJJINJH
	{
		[Cpp2IlInjected.Token(Token = "0x60001C3")]
		[Cpp2IlInjected.Address(Slot = "59")]
		get;
		[Cpp2IlInjected.Token(Token = "0x60001C4")]
		[Cpp2IlInjected.Address(Slot = "60")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000088")]
	Vector3 EDNJLBDPNMM
	{
		[Cpp2IlInjected.Token(Token = "0x60001C5")]
		[Cpp2IlInjected.Address(Slot = "61")]
		get;
		[Cpp2IlInjected.Token(Token = "0x60001C6")]
		[Cpp2IlInjected.Address(Slot = "62")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000089")]
	Quaternion DIIIGEGILHP
	{
		[Cpp2IlInjected.Token(Token = "0x60001C7")]
		[Cpp2IlInjected.Address(Slot = "63")]
		get;
		[Cpp2IlInjected.Token(Token = "0x60001C8")]
		[Cpp2IlInjected.Address(Slot = "64")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x1700008A")]
	RigidbodyConstraints BCMJAHAELOH
	{
		[Cpp2IlInjected.Token(Token = "0x60001C9")]
		[Cpp2IlInjected.Address(Slot = "65")]
		get;
		[Cpp2IlInjected.Token(Token = "0x60001CA")]
		[Cpp2IlInjected.Address(Slot = "66")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x1700008B")]
	bool PJGCDNLPGAK
	{
		[Cpp2IlInjected.Token(Token = "0x60001CB")]
		[Cpp2IlInjected.Address(Slot = "67")]
		get;
		[Cpp2IlInjected.Token(Token = "0x60001CC")]
		[Cpp2IlInjected.Address(Slot = "68")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x1700008C")]
	CollisionDetectionMode CIEEKBNHEBL
	{
		[Cpp2IlInjected.Token(Token = "0x60001CD")]
		[Cpp2IlInjected.Address(Slot = "69")]
		get;
		[Cpp2IlInjected.Token(Token = "0x60001CE")]
		[Cpp2IlInjected.Address(Slot = "70")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x1700008D")]
	bool NFEEOKFPIGD
	{
		[Cpp2IlInjected.Token(Token = "0x60001CF")]
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

	[Cpp2IlInjected.Token(Token = "0x60001D0")]
	[Cpp2IlInjected.Address(Slot = "72")]
	void BKOELLNKDDF();

	[Cpp2IlInjected.Token(Token = "0x60001D1")]
	[Cpp2IlInjected.Address(Slot = "73")]
	void IDDPIKDPIIE();

	[Cpp2IlInjected.Token(Token = "0x60001D2")]
	[Cpp2IlInjected.Address(Slot = "74")]
	void EDIJBNLFNNB();

	[Cpp2IlInjected.Token(Token = "0x60001D3")]
	[Cpp2IlInjected.Address(Slot = "75")]
	void HFOIEEGNPME();

	[Cpp2IlInjected.Token(Token = "0x60001D4")]
	[Cpp2IlInjected.Address(Slot = "76")]
	void FODBIMBAOBD();

	[Cpp2IlInjected.Token(Token = "0x60001DB")]
	[Cpp2IlInjected.Address(Slot = "83")]
	void KKGLFGKJMPP(PPMDIHPMNCG JFBPNBNBHOE, bool LMKLDOOIJAA = false);

	[Cpp2IlInjected.Token(Token = "0x60001DE")]
	[Cpp2IlInjected.Address(Slot = "86")]
	void CGMPABBBBGH(object AJDBKDIMOHA);

	[Cpp2IlInjected.Token(Token = "0x60001DF")]
	[Cpp2IlInjected.Address(Slot = "87")]
	void AKPJCFEODOB(object AJDBKDIMOHA);

	[Cpp2IlInjected.Token(Token = "0x60001E0")]
	[Cpp2IlInjected.Address(Slot = "88")]
	Vector3 EAJIEBJEBJP(Vector3 ODPCODBLNJO);

	[Cpp2IlInjected.Token(Token = "0x60001E1")]
	[Cpp2IlInjected.Address(Slot = "89")]
	Vector3 JGGPKLHDPOC(Vector3 DLOMDLEMEJO);

	[Cpp2IlInjected.Token(Token = "0x60001E2")]
	[Cpp2IlInjected.Address(Slot = "90")]
	void LNGHCMNGELC();

	[Cpp2IlInjected.Token(Token = "0x60001E3")]
	[Cpp2IlInjected.Address(Slot = "91")]
	void DGADOFDPFDE();

	[Cpp2IlInjected.Token(Token = "0x60001E4")]
	[Cpp2IlInjected.Address(Slot = "92")]
	void IBIENENFOLO();

	[Cpp2IlInjected.Token(Token = "0x60001E5")]
	[Cpp2IlInjected.Address(Slot = "93")]
	void EEIOJCMLKKL(Vector3 PKEOGDHOABC, Vector3 GNHLNIEHAFA);

	[Cpp2IlInjected.Token(Token = "0x60001E6")]
	[Cpp2IlInjected.Address(Slot = "94")]
	void BNKAMLPDNDH(Vector3 IHHIJIKHHIA, Vector3 NBGIHKDGDID);

	[Cpp2IlInjected.Token(Token = "0x60001E7")]
	[Cpp2IlInjected.Address(Slot = "95")]
	void CADMMMANGFL(Vector3 GJKLLEKAGBH);

	[Cpp2IlInjected.Token(Token = "0x60001E8")]
	[Cpp2IlInjected.Address(Slot = "96")]
	void GOHOEPELEBG(CBPMCKPIBHC EIOPEGEMKHP, Vector3 DKCLOLGBADH, float OOKLCGCBAJI, float LLKLELEIBGC = 8f, float AEEFHMKEOAH = 1f);

	[Cpp2IlInjected.Token(Token = "0x60001E9")]
	[Cpp2IlInjected.Address(Slot = "97")]
	void JLNINMHMEHA(BOPFIFMMKBG BPDOBLBNKEN, Vector3 NLFAAHHHDNN, float HHHNHCMFNFA = float.PositiveInfinity);

	[Cpp2IlInjected.Token(Token = "0x60001EA")]
	[Cpp2IlInjected.Address(Slot = "98")]
	void ADCBOLCDFHD(BOPFIFMMKBG BPDOBLBNKEN, Vector3 MCFIHGJCDCP, float BDCHAJELIHL = 7f, float ABPPGEHGCFI = 1f);

	[Cpp2IlInjected.Token(Token = "0x60001EB")]
	[Cpp2IlInjected.Address(Slot = "99")]
	Vector3 KPFDHGBBOFB(Vector3 JFBPNBNBHOE);

	[Cpp2IlInjected.Token(Token = "0x60001EC")]
	[Cpp2IlInjected.Address(Slot = "100")]
	Vector3 FHKEINJELIE(Vector3 JFBPNBNBHOE);

	[Cpp2IlInjected.Token(Token = "0x60001ED")]
	[Cpp2IlInjected.Address(Slot = "101")]
	void KDDHFACBKGB();

	[Cpp2IlInjected.Token(Token = "0x60001EE")]
	[Cpp2IlInjected.Address(Slot = "102")]
	void KFIEFEHILOK(PPMDIHPMNCG FONAKEEEKPK, object AJDBKDIMOHA);

	[Cpp2IlInjected.Token(Token = "0x60001EF")]
	[Cpp2IlInjected.Address(Slot = "103")]
	void MMHJICPHJHL(object AJDBKDIMOHA);

	[Cpp2IlInjected.Token(Token = "0x60001F2")]
	[Cpp2IlInjected.Address(Slot = "106")]
	void OCCLJJBDHKH();

	[Cpp2IlInjected.Token(Token = "0x60001F3")]
	[Cpp2IlInjected.Address(Slot = "107")]
	void LGMIOPKMACL();

	[Cpp2IlInjected.Token(Token = "0x60001F4")]
	[Cpp2IlInjected.Address(Slot = "108")]
	void PGLMPJOADGG();

	[Cpp2IlInjected.Token(Token = "0x60001F7")]
	[Cpp2IlInjected.Address(Slot = "111")]
	bool JLGKLAGDNBA();

	[Cpp2IlInjected.Token(Token = "0x60001F8")]
	[Cpp2IlInjected.Address(Slot = "112")]
	void IPODHJMCCPD();

	[Cpp2IlInjected.Token(Token = "0x60001FD")]
	[Cpp2IlInjected.Address(Slot = "117")]
	IDisposable BFJJEOKEAOO();

	[Cpp2IlInjected.Token(Token = "0x60001FE")]
	[Cpp2IlInjected.Address(Slot = "118")]
	void IDBKKNHMJCA(object AJDBKDIMOHA);

	[Cpp2IlInjected.Token(Token = "0x60001FF")]
	[Cpp2IlInjected.Address(Slot = "119")]
	void BPLEOILKCFF(object AJDBKDIMOHA);

	[Cpp2IlInjected.Token(Token = "0x6000200")]
	[Cpp2IlInjected.Address(Slot = "120")]
	void NHDILIPFEBO(object AJDBKDIMOHA, bool NMHFDHPJGFL);

	[Cpp2IlInjected.Token(Token = "0x6000203")]
	[Cpp2IlInjected.Address(Slot = "123")]
	void BBLLMNKJMFE(Vector3 LDBCCJOIJOF, Quaternion HPGHCBDEGFJ);

	[Cpp2IlInjected.Token(Token = "0x6000204")]
	[Cpp2IlInjected.Address(Slot = "124")]
	void MBJKCDHFBPN(Vector3 JPBAEPJPHFP, Quaternion NHHKEMOEKHO);

	[Cpp2IlInjected.Token(Token = "0x6000205")]
	[Cpp2IlInjected.Address(Slot = "125")]
	bool BHKLDAAMMPP(float LCLMOJDNELD);

	[Cpp2IlInjected.Token(Token = "0x6000206")]
	[Cpp2IlInjected.Address(Slot = "126")]
	void PGKAPIBFPCH(object AJDBKDIMOHA);

	[Cpp2IlInjected.Token(Token = "0x6000207")]
	[Cpp2IlInjected.Address(Slot = "127")]
	void DFLECBDEDLK(object AJDBKDIMOHA);

	[Cpp2IlInjected.Token(Token = "0x6000208")]
	[Cpp2IlInjected.Address(Slot = "128")]
	void NMDKIGJCKAP(object AJDBKDIMOHA);

	[Cpp2IlInjected.Token(Token = "0x6000209")]
	[Cpp2IlInjected.Address(Slot = "129")]
	void IGIJDOMADBN(object AJDBKDIMOHA);

	[Cpp2IlInjected.Token(Token = "0x600020A")]
	[Cpp2IlInjected.Address(Slot = "130")]
	void MDAEENKEECK(Vector3 BIOMHNNIJHG, ForceMode HODPBICIGJM = ForceMode.Force);

	[Cpp2IlInjected.Token(Token = "0x600020B")]
	[Cpp2IlInjected.Address(Slot = "131")]
	void LIGCOMLMAAG(Vector3 BIOMHNNIJHG, Vector3 DACBJNCMNFL, ForceMode HODPBICIGJM);

	[Cpp2IlInjected.Token(Token = "0x600020C")]
	[Cpp2IlInjected.Address(Slot = "132")]
	void DPFOGKDMEOC(Vector3 CEBBAPNMMME, ForceMode HODPBICIGJM = ForceMode.Force);

	[Cpp2IlInjected.Token(Token = "0x600020D")]
	[Cpp2IlInjected.Address(Slot = "133")]
	void BFACFHPBMFM(Vector3 CEBBAPNMMME, ForceMode HODPBICIGJM = ForceMode.Force);

	[Cpp2IlInjected.Token(Token = "0x600020E")]
	[Cpp2IlInjected.Address(Slot = "134")]
	bool CGHFGDDABEK(Vector3 HHOIMIMHDMP, out RaycastHit CFGLFCONCKN, float KMAOMDJLDEN);

	[Cpp2IlInjected.Token(Token = "0x600020F")]
	[Cpp2IlInjected.Address(Slot = "135")]
	void KEPOLBAFIFI();

	[Cpp2IlInjected.Token(Token = "0x6000210")]
	[Cpp2IlInjected.Address(Slot = "136")]
	new string ToString();
}
[Cpp2IlInjected.Token(Token = "0x2000029")]
public class DGHPEMNHGCH : PPMDIHPMNCG, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000030")]
	internal readonly CMKMIKBKOHM OBOKKBNADPB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000031")]
	internal HMOOAGCGLKM FPAHGFEONEG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000032")]
	internal EBCDLOKEBCP ENJCHFAIPBP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000033")]
	internal LNJFNCEGNCA JHGGFPKIOOH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000034")]
	internal MPILPIJAHDO BNEEGIEDHBB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000035")]
	internal NPFLLLAFPDM FDFJFLEGNJI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000036")]
	internal HEFJBMMENIM NLHHIPFAJGC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000037")]
	internal KKCAAHMNCAO HKKDOONMLJK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000038")]
	internal LMMEICEFKMM HPDJLHMDGJL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x4000039")]
	internal BBGIBEMMCOA KAIGHOJFBHN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x400003A")]
	internal ODGCKIECBJN CNGLAECGKOP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x400003B")]
	internal GAMBABDLKNB LCNDBJBJJJH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x400003C")]
	internal FGHCKEELDLL BIOMHNNIJHG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
	[Cpp2IlInjected.Token(Token = "0x400003D")]
	internal OIAJBEDDNGM HPOBMMHJMIO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x400003E")]
	internal HONAINACCHA AOAFHPHKFMD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
	[Cpp2IlInjected.Token(Token = "0x400003F")]
	internal APGGGIKOMPN JIKIBEPCNNP;

	[Cpp2IlInjected.Token(Token = "0x1700008E")]
	public RigidbodyEx JKIDPKKAFKH
	{
		[Cpp2IlInjected.Token(Token = "0x6000211")]
		[Cpp2IlInjected.Address(RVA = "0x786230", Offset = "0x785630", VA = "0x180786230", Slot = "5")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000212")]
		[Cpp2IlInjected.Address(RVA = "0x80E3F0", Offset = "0x80D7F0", VA = "0x18080E3F0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700008F")]
	public GameObject MNGKPNJJMOC
	{
		[Cpp2IlInjected.Token(Token = "0x6000213")]
		[Cpp2IlInjected.Address(RVA = "0x6F71B0", Offset = "0x6F65B0", VA = "0x1806F71B0", Slot = "6")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000214")]
		[Cpp2IlInjected.Address(RVA = "0x6F7270", Offset = "0x6F6670", VA = "0x1806F7270")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000090")]
	public Transform LNPNGFHHEEL
	{
		[Cpp2IlInjected.Token(Token = "0x6000215")]
		[Cpp2IlInjected.Address(RVA = "0x54648C0", Offset = "0x5463CC0", VA = "0x1854648C0", Slot = "7")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000091")]
	public IEnumerable<object> JNIPNMIKJIN
	{
		[Cpp2IlInjected.Token(Token = "0x6000216")]
		[Cpp2IlInjected.Address(RVA = "0x5468A30", Offset = "0x5467E30", VA = "0x185468A30", Slot = "8")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000092")]
	public Rigidbody BAPEKECGLDP
	{
		[Cpp2IlInjected.Token(Token = "0x6000217")]
		[Cpp2IlInjected.Address(RVA = "0x546A380", Offset = "0x5469780", VA = "0x18546A380", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000093")]
	public PPMDIHPMNCG EMIBHNNCMJC
	{
		[Cpp2IlInjected.Token(Token = "0x6000225")]
		[Cpp2IlInjected.Address(RVA = "0x5469970", Offset = "0x5468D70", VA = "0x185469970", Slot = "9")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000226")]
		[Cpp2IlInjected.Address(RVA = "0x546A1C0", Offset = "0x54695C0", VA = "0x18546A1C0", Slot = "10")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000094")]
	public IReadOnlyList<PPMDIHPMNCG> LILCAAEDFCG
	{
		[Cpp2IlInjected.Token(Token = "0x6000227")]
		[Cpp2IlInjected.Address(RVA = "0x54651B0", Offset = "0x54645B0", VA = "0x1854651B0", Slot = "11")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000095")]
	public PPMDIHPMNCG MDHMHFAIMJJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000228")]
		[Cpp2IlInjected.Address(RVA = "0x5467700", Offset = "0x5466B00", VA = "0x185467700", Slot = "12")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000096")]
	public bool DKNFKPAFDPB
	{
		[Cpp2IlInjected.Token(Token = "0x6000229")]
		[Cpp2IlInjected.Address(RVA = "0x5465ED0", Offset = "0x54652D0", VA = "0x185465ED0", Slot = "13")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000097")]
	public bool PJPIAHDKHLD
	{
		[Cpp2IlInjected.Token(Token = "0x600022D")]
		[Cpp2IlInjected.Address(RVA = "0x5465AE0", Offset = "0x5464EE0", VA = "0x185465AE0", Slot = "14")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000098")]
	public bool EMGPBBGPGIE
	{
		[Cpp2IlInjected.Token(Token = "0x600022E")]
		[Cpp2IlInjected.Address(RVA = "0x5465070", Offset = "0x5464470", VA = "0x185465070", Slot = "15")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000099")]
	public LKKOPIEOHJA OLDOEMJHCAC
	{
		[Cpp2IlInjected.Token(Token = "0x600022F")]
		[Cpp2IlInjected.Address(RVA = "0x5467520", Offset = "0x5466920", VA = "0x185467520", Slot = "16")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000230")]
		[Cpp2IlInjected.Address(RVA = "0x5467B50", Offset = "0x5466F50", VA = "0x185467B50", Slot = "17")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700009A")]
	public FDHNJKMJJJG AEPCDANKKNF
	{
		[Cpp2IlInjected.Token(Token = "0x6000231")]
		[Cpp2IlInjected.Address(RVA = "0x5464EE0", Offset = "0x54642E0", VA = "0x185464EE0", Slot = "18")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000232")]
		[Cpp2IlInjected.Address(RVA = "0x5466B30", Offset = "0x5465F30", VA = "0x185466B30", Slot = "19")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700009B")]
	public float ENFIJFJPIPJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000233")]
		[Cpp2IlInjected.Address(RVA = "0x546A220", Offset = "0x5469620", VA = "0x18546A220", Slot = "20")]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x6000234")]
		[Cpp2IlInjected.Address(RVA = "0x546A3D0", Offset = "0x54697D0", VA = "0x18546A3D0", Slot = "21")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700009C")]
	public Vector3 JMJCCDADJPC
	{
		[Cpp2IlInjected.Token(Token = "0x6000235")]
		[Cpp2IlInjected.Address(RVA = "0x5467EA0", Offset = "0x54672A0", VA = "0x185467EA0", Slot = "22")]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x6000236")]
		[Cpp2IlInjected.Address(RVA = "0x54681C0", Offset = "0x54675C0", VA = "0x1854681C0", Slot = "23")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700009D")]
	public Vector3 KGONIIPAFMK
	{
		[Cpp2IlInjected.Token(Token = "0x6000237")]
		[Cpp2IlInjected.Address(RVA = "0x54686D0", Offset = "0x5467AD0", VA = "0x1854686D0", Slot = "24")]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x6000238")]
		[Cpp2IlInjected.Address(RVA = "0x54669B0", Offset = "0x5465DB0", VA = "0x1854669B0", Slot = "25")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700009E")]
	public Vector3 MHCLHNEGJDD
	{
		[Cpp2IlInjected.Token(Token = "0x6000239")]
		[Cpp2IlInjected.Address(RVA = "0x5465380", Offset = "0x5464780", VA = "0x185465380", Slot = "26")]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x600023A")]
		[Cpp2IlInjected.Address(RVA = "0x5467400", Offset = "0x5466800", VA = "0x185467400", Slot = "27")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700009F")]
	public Vector3 DLFBGEBKEHJ
	{
		[Cpp2IlInjected.Token(Token = "0x600023B")]
		[Cpp2IlInjected.Address(RVA = "0x5467570", Offset = "0x5466970", VA = "0x185467570", Slot = "28")]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x600023C")]
		[Cpp2IlInjected.Address(RVA = "0x5468870", Offset = "0x5467C70", VA = "0x185468870", Slot = "29")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A0")]
	public bool AMMPJIIANJD
	{
		[Cpp2IlInjected.Token(Token = "0x600023D")]
		[Cpp2IlInjected.Address(RVA = "0x5465C40", Offset = "0x5465040", VA = "0x185465C40", Slot = "30")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A1")]
	public bool OONHJPFBNAB
	{
		[Cpp2IlInjected.Token(Token = "0x600023E")]
		[Cpp2IlInjected.Address(RVA = "0x5467AF0", Offset = "0x5466EF0", VA = "0x185467AF0", Slot = "31")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A2")]
	public bool AKAANNKOEAC
	{
		[Cpp2IlInjected.Token(Token = "0x600023F")]
		[Cpp2IlInjected.Address(RVA = "0x5464520", Offset = "0x5463920", VA = "0x185464520", Slot = "32")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A3")]
	public bool OIAJDGKIDMB
	{
		[Cpp2IlInjected.Token(Token = "0x6000240")]
		[Cpp2IlInjected.Address(RVA = "0x5465330", Offset = "0x5464730", VA = "0x185465330", Slot = "33")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A4")]
	public Vector3 DJHICJGOGJI
	{
		[Cpp2IlInjected.Token(Token = "0x6000251")]
		[Cpp2IlInjected.Address(RVA = "0x5468490", Offset = "0x5467890", VA = "0x185468490", Slot = "34")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A5")]
	public Vector3 EOFHLAGNPII
	{
		[Cpp2IlInjected.Token(Token = "0x6000252")]
		[Cpp2IlInjected.Address(RVA = "0x5469F80", Offset = "0x5469380", VA = "0x185469F80", Slot = "35")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A6")]
	public Vector3 JMIIJDMAMEI
	{
		[Cpp2IlInjected.Token(Token = "0x6000257")]
		[Cpp2IlInjected.Address(RVA = "0x5467D30", Offset = "0x5467130", VA = "0x185467D30", Slot = "36")]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x6000258")]
		[Cpp2IlInjected.Address(RVA = "0x5467260", Offset = "0x5466660", VA = "0x185467260", Slot = "37")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A7")]
	public Vector3 PMKFGPJNJBI
	{
		[Cpp2IlInjected.Token(Token = "0x6000259")]
		[Cpp2IlInjected.Address(RVA = "0x5465450", Offset = "0x5464850", VA = "0x185465450", Slot = "38")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A8")]
	public float KLNDCEHFMBA
	{
		[Cpp2IlInjected.Token(Token = "0x600025A")]
		[Cpp2IlInjected.Address(RVA = "0x5467850", Offset = "0x5466C50", VA = "0x185467850", Slot = "39")]
		get
		{
			return default(float);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A9")]
	public float NBJLLACMBLF
	{
		[Cpp2IlInjected.Token(Token = "0x600025B")]
		[Cpp2IlInjected.Address(RVA = "0x5467E00", Offset = "0x5467200", VA = "0x185467E00", Slot = "40")]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x600025C")]
		[Cpp2IlInjected.Address(RVA = "0x546A160", Offset = "0x5469560", VA = "0x18546A160", Slot = "41")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000AA")]
	public Vector3 OFFHJCCLOEB
	{
		[Cpp2IlInjected.Token(Token = "0x600025D")]
		[Cpp2IlInjected.Address(RVA = "0x5466240", Offset = "0x5465640", VA = "0x185466240", Slot = "42")]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x600025E")]
		[Cpp2IlInjected.Address(RVA = "0x5466F60", Offset = "0x5466360", VA = "0x185466F60", Slot = "43")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000AB")]
	public Quaternion MOMBOPJMDMK
	{
		[Cpp2IlInjected.Token(Token = "0x600025F")]
		[Cpp2IlInjected.Address(RVA = "0x5465A10", Offset = "0x5464E10", VA = "0x185465A10", Slot = "44")]
		get
		{
			return default(Quaternion);
		}
		[Cpp2IlInjected.Token(Token = "0x6000260")]
		[Cpp2IlInjected.Address(RVA = "0x5467BB0", Offset = "0x5466FB0", VA = "0x185467BB0", Slot = "45")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000AC")]
	public float FCGOFCPMIGL
	{
		[Cpp2IlInjected.Token(Token = "0x6000264")]
		[Cpp2IlInjected.Address(RVA = "0x5464B60", Offset = "0x5463F60", VA = "0x185464B60", Slot = "46")]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x6000265")]
		[Cpp2IlInjected.Address(RVA = "0x546A270", Offset = "0x5469670", VA = "0x18546A270", Slot = "47")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000AD")]
	public float CFMIJLIHCIE
	{
		[Cpp2IlInjected.Token(Token = "0x6000266")]
		[Cpp2IlInjected.Address(RVA = "0x546A490", Offset = "0x5469890", VA = "0x18546A490", Slot = "48")]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x6000267")]
		[Cpp2IlInjected.Address(RVA = "0x546A430", Offset = "0x5469830", VA = "0x18546A430", Slot = "49")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000AE")]
	public bool HLADCICNJBO
	{
		[Cpp2IlInjected.Token(Token = "0x6000268")]
		[Cpp2IlInjected.Address(RVA = "0x5464CC0", Offset = "0x54640C0", VA = "0x185464CC0", Slot = "50")]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000269")]
		[Cpp2IlInjected.Address(RVA = "0x54664C0", Offset = "0x54658C0", VA = "0x1854664C0", Slot = "51")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000AF")]
	public PPGNAFCKNOL NHFAJHMDKMA
	{
		[Cpp2IlInjected.Token(Token = "0x6000271")]
		[Cpp2IlInjected.Address(RVA = "0x5468290", Offset = "0x5467690", VA = "0x185468290", Slot = "52")]
		get
		{
			return default(PPGNAFCKNOL);
		}
		[Cpp2IlInjected.Token(Token = "0x6000272")]
		[Cpp2IlInjected.Address(RVA = "0x5469620", Offset = "0x5468A20", VA = "0x185469620", Slot = "53")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B0")]
	public bool MBEHMAPDJBJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000275")]
		[Cpp2IlInjected.Address(RVA = "0x5466190", Offset = "0x5465590", VA = "0x185466190", Slot = "54")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B1")]
	public Transform PDLNBKLCFJO
	{
		[Cpp2IlInjected.Token(Token = "0x600027C")]
		[Cpp2IlInjected.Address(RVA = "0x5468B80", Offset = "0x5467F80", VA = "0x185468B80", Slot = "55")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B2")]
	public Transform IPOOCBGBBCA
	{
		[Cpp2IlInjected.Token(Token = "0x600027D")]
		[Cpp2IlInjected.Address(RVA = "0x5468B80", Offset = "0x5467F80", VA = "0x185468B80", Slot = "56")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B3")]
	public Vector3 GCIAIFNDFJO
	{
		[Cpp2IlInjected.Token(Token = "0x600027E")]
		[Cpp2IlInjected.Address(RVA = "0x5467C80", Offset = "0x5467080", VA = "0x185467C80", Slot = "57")]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x600027F")]
		[Cpp2IlInjected.Address(RVA = "0x54678A0", Offset = "0x5466CA0", VA = "0x1854678A0", Slot = "58")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B4")]
	public float BIJKBCGODIE
	{
		[Cpp2IlInjected.Token(Token = "0x6000280")]
		[Cpp2IlInjected.Address(RVA = "0x5468810", Offset = "0x5467C10", VA = "0x185468810", Slot = "59")]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x6000281")]
		[Cpp2IlInjected.Address(RVA = "0x5467F70", Offset = "0x5467370", VA = "0x185467F70", Slot = "60")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B5")]
	public float CAEPFBBJBOK
	{
		[Cpp2IlInjected.Token(Token = "0x6000282")]
		[Cpp2IlInjected.Address(RVA = "0x5465850", Offset = "0x5464C50", VA = "0x185465850", Slot = "61")]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x6000283")]
		[Cpp2IlInjected.Address(RVA = "0x5466310", Offset = "0x5465710", VA = "0x185466310", Slot = "62")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B6")]
	public Quaternion LBGIBJJINJH
	{
		[Cpp2IlInjected.Token(Token = "0x6000284")]
		[Cpp2IlInjected.Address(RVA = "0x5465680", Offset = "0x5464A80", VA = "0x185465680", Slot = "63")]
		get
		{
			return default(Quaternion);
		}
		[Cpp2IlInjected.Token(Token = "0x6000285")]
		[Cpp2IlInjected.Address(RVA = "0x5466100", Offset = "0x5465500", VA = "0x185466100", Slot = "64")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B7")]
	public Vector3 EDNJLBDPNMM
	{
		[Cpp2IlInjected.Token(Token = "0x6000286")]
		[Cpp2IlInjected.Address(RVA = "0x5469020", Offset = "0x5468420", VA = "0x185469020", Slot = "65")]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x6000287")]
		[Cpp2IlInjected.Address(RVA = "0x54699C0", Offset = "0x5468DC0", VA = "0x1854699C0", Slot = "66")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B8")]
	public Quaternion DIIIGEGILHP
	{
		[Cpp2IlInjected.Token(Token = "0x6000288")]
		[Cpp2IlInjected.Address(RVA = "0x5465810", Offset = "0x5464C10", VA = "0x185465810", Slot = "67")]
		get
		{
			return default(Quaternion);
		}
		[Cpp2IlInjected.Token(Token = "0x6000289")]
		[Cpp2IlInjected.Address(RVA = "0x54647C0", Offset = "0x5463BC0", VA = "0x1854647C0", Slot = "68")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B9")]
	public RigidbodyConstraints BCMJAHAELOH
	{
		[Cpp2IlInjected.Token(Token = "0x600028D")]
		[Cpp2IlInjected.Address(RVA = "0x5466EB0", Offset = "0x54662B0", VA = "0x185466EB0", Slot = "69")]
		get
		{
			return default(RigidbodyConstraints);
		}
		[Cpp2IlInjected.Token(Token = "0x600028E")]
		[Cpp2IlInjected.Address(RVA = "0x54698B0", Offset = "0x5468CB0", VA = "0x1854698B0", Slot = "70")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000BA")]
	public bool PJGCDNLPGAK
	{
		[Cpp2IlInjected.Token(Token = "0x600028F")]
		[Cpp2IlInjected.Address(RVA = "0x5469070", Offset = "0x5468470", VA = "0x185469070", Slot = "71")]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000290")]
		[Cpp2IlInjected.Address(RVA = "0x5464710", Offset = "0x5463B10", VA = "0x185464710", Slot = "72")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000BB")]
	public CollisionDetectionMode CIEEKBNHEBL
	{
		[Cpp2IlInjected.Token(Token = "0x6000299")]
		[Cpp2IlInjected.Address(RVA = "0x5464770", Offset = "0x5463B70", VA = "0x185464770", Slot = "73")]
		get
		{
			return default(CollisionDetectionMode);
		}
		[Cpp2IlInjected.Token(Token = "0x600029A")]
		[Cpp2IlInjected.Address(RVA = "0x5464C60", Offset = "0x5464060", VA = "0x185464C60", Slot = "74")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000BC")]
	public bool NFEEOKFPIGD
	{
		[Cpp2IlInjected.Token(Token = "0x600029C")]
		[Cpp2IlInjected.Address(RVA = "0x5467950", Offset = "0x5466D50", VA = "0x185467950", Slot = "75")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000021")]
	public event JPOFABMOGOF KMPDHKDHBNO
	{
		[Cpp2IlInjected.Token(Token = "0x600021F")]
		[Cpp2IlInjected.Address(RVA = "0x5466580", Offset = "0x5465980", VA = "0x185466580", Slot = "81")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000220")]
		[Cpp2IlInjected.Address(RVA = "0x5468070", Offset = "0x5467470", VA = "0x185468070", Slot = "82")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000022")]
	public event JPOFABMOGOF FIBPOODLACB
	{
		[Cpp2IlInjected.Token(Token = "0x6000221")]
		[Cpp2IlInjected.Address(RVA = "0x54696E0", Offset = "0x5468AE0", VA = "0x1854696E0", Slot = "83")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000222")]
		[Cpp2IlInjected.Address(RVA = "0x5465B30", Offset = "0x5464F30", VA = "0x185465B30", Slot = "84")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000023")]
	public event CBNHIOLMAOO LEBPAEACGHM
	{
		[Cpp2IlInjected.Token(Token = "0x6000223")]
		[Cpp2IlInjected.Address(RVA = "0x54682E0", Offset = "0x54676E0", VA = "0x1854682E0", Slot = "85")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000224")]
		[Cpp2IlInjected.Address(RVA = "0x5467640", Offset = "0x5466A40", VA = "0x185467640", Slot = "86")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000024")]
	public event JPOFABMOGOF OFDNMEKJKBP
	{
		[Cpp2IlInjected.Token(Token = "0x600022B")]
		[Cpp2IlInjected.Address(RVA = "0x5469EB0", Offset = "0x54692B0", VA = "0x185469EB0", Slot = "88")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600022C")]
		[Cpp2IlInjected.Address(RVA = "0x54661E0", Offset = "0x54655E0", VA = "0x1854661E0", Slot = "89")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000025")]
	public event JPOFABMOGOF GHPNGDBINKD
	{
		[Cpp2IlInjected.Token(Token = "0x6000255")]
		[Cpp2IlInjected.Address(RVA = "0x5469AB0", Offset = "0x5468EB0", VA = "0x185469AB0", Slot = "108")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000256")]
		[Cpp2IlInjected.Address(RVA = "0x546A0B0", Offset = "0x54694B0", VA = "0x18546A0B0", Slot = "109")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000026")]
	public event JPOFABMOGOF MLDKIENLGJG
	{
		[Cpp2IlInjected.Token(Token = "0x600026A")]
		[Cpp2IlInjected.Address(RVA = "0x5466F00", Offset = "0x5466300", VA = "0x185466F00", Slot = "113")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600026B")]
		[Cpp2IlInjected.Address(RVA = "0x54658B0", Offset = "0x5464CB0", VA = "0x1854658B0", Slot = "114")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000027")]
	public event Action<LHLIDFNIOKA, LHLIDFNIOKA> GBMBMPKHBHO
	{
		[Cpp2IlInjected.Token(Token = "0x600026F")]
		[Cpp2IlInjected.Address(RVA = "0x5466520", Offset = "0x5465920", VA = "0x185466520", Slot = "117")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000270")]
		[Cpp2IlInjected.Address(RVA = "0x5464D10", Offset = "0x5464110", VA = "0x185464D10", Slot = "118")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000028")]
	public event JPOFABMOGOF KKHOKOPLGIE
	{
		[Cpp2IlInjected.Token(Token = "0x6000273")]
		[Cpp2IlInjected.Address(RVA = "0x54676A0", Offset = "0x5466AA0", VA = "0x1854676A0", Slot = "119")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000274")]
		[Cpp2IlInjected.Address(RVA = "0x5464800", Offset = "0x5463C00", VA = "0x185464800", Slot = "120")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000029")]
	public event JPOFABMOGOF FAMCBBOPNHD
	{
		[Cpp2IlInjected.Token(Token = "0x600027A")]
		[Cpp2IlInjected.Address(RVA = "0x5468CA0", Offset = "0x54680A0", VA = "0x185468CA0", Slot = "125")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600027B")]
		[Cpp2IlInjected.Address(RVA = "0x5469A10", Offset = "0x5468E10", VA = "0x185469A10", Slot = "126")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000218")]
	[Cpp2IlInjected.Address(RVA = "0x546A520", Offset = "0x5469920", VA = "0x18546A520")]
	public DGHPEMNHGCH(GameObject OOKBNBHDPPG, RigidbodyEx CFNDHOOGKBI, CMKMIKBKOHM OBOKKBNADPB, in OALOFNDFAEL ONIBEFDCPGD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000219")]
	[Cpp2IlInjected.Address(RVA = "0x54666D0", Offset = "0x5465AD0", VA = "0x1854666D0", Slot = "142")]
	protected virtual void FLDAICHOBKG(CMKMIKBKOHM OBOKKBNADPB, OALOFNDFAEL ONIBEFDCPGD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600021A")]
	[Cpp2IlInjected.Address(RVA = "0x5465D10", Offset = "0x5465110", VA = "0x185465D10", Slot = "143")]
	public virtual void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600021B")]
	[Cpp2IlInjected.Address(RVA = "0x5464F30", Offset = "0x5464330", VA = "0x185464F30", Slot = "76")]
	public void BKOELLNKDDF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600021C")]
	[Cpp2IlInjected.Address(RVA = "0x5467800", Offset = "0x5466C00", VA = "0x185467800", Slot = "77")]
	public void IDDPIKDPIIE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600021D")]
	[Cpp2IlInjected.Address(RVA = "0x2AF0DC0", Offset = "0x2AF01C0", VA = "0x182AF0DC0", Slot = "78")]
	public void EDIJBNLFNNB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600021E")]
	[Cpp2IlInjected.Address(RVA = "0x5466A80", Offset = "0x5465E80", VA = "0x185466A80", Slot = "144")]
	public virtual void FODBIMBAOBD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600022A")]
	[Cpp2IlInjected.Address(RVA = "0x54687A0", Offset = "0x5467BA0", VA = "0x1854687A0", Slot = "87")]
	public void KKGLFGKJMPP(PPMDIHPMNCG JFBPNBNBHOE, bool LMKLDOOIJAA = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000241")]
	[Cpp2IlInjected.Address(RVA = "0x5465620", Offset = "0x5464A20", VA = "0x185465620", Slot = "90")]
	public void CGMPABBBBGH(object AJDBKDIMOHA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000242")]
	[Cpp2IlInjected.Address(RVA = "0x5464860", Offset = "0x5463C60", VA = "0x185464860", Slot = "91")]
	public void AKPJCFEODOB(object AJDBKDIMOHA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000243")]
	[Cpp2IlInjected.Address(RVA = "0x5465DE0", Offset = "0x54651E0", VA = "0x185465DE0", Slot = "92")]
	public Vector3 EAJIEBJEBJP(Vector3 ODPCODBLNJO)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000244")]
	[Cpp2IlInjected.Address(RVA = "0x54680D0", Offset = "0x54674D0", VA = "0x1854680D0", Slot = "93")]
	public Vector3 JGGPKLHDPOC(Vector3 DLOMDLEMEJO)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000245")]
	[Cpp2IlInjected.Address(RVA = "0x5467800", Offset = "0x5466C00", VA = "0x185467800", Slot = "94")]
	public void LNGHCMNGELC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000246")]
	[Cpp2IlInjected.Address(RVA = "0x5465BF0", Offset = "0x5464FF0", VA = "0x185465BF0", Slot = "95")]
	public void DGADOFDPFDE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000247")]
	[Cpp2IlInjected.Address(RVA = "0x5467750", Offset = "0x5466B50", VA = "0x185467750", Slot = "96")]
	public void IBIENENFOLO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000248")]
	[Cpp2IlInjected.Address(RVA = "0x5466010", Offset = "0x5465410", VA = "0x185466010", Slot = "97")]
	public void EEIOJCMLKKL(Vector3 PKEOGDHOABC, Vector3 GNHLNIEHAFA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000249")]
	[Cpp2IlInjected.Address(RVA = "0x54650C0", Offset = "0x54644C0", VA = "0x1854650C0", Slot = "98")]
	public void BNKAMLPDNDH(Vector3 IHHIJIKHHIA, Vector3 NBGIHKDGDID)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600024A")]
	[Cpp2IlInjected.Address(RVA = "0x5465260", Offset = "0x5464660", VA = "0x185465260", Slot = "99")]
	public void CADMMMANGFL(Vector3 GJKLLEKAGBH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600024B")]
	[Cpp2IlInjected.Address(RVA = "0x5467140", Offset = "0x5466540", VA = "0x185467140", Slot = "100")]
	public void GOHOEPELEBG(CBPMCKPIBHC EIOPEGEMKHP, Vector3 DKCLOLGBADH, float OOKLCGCBAJI, float LLKLELEIBGC = 8f, float AEEFHMKEOAH = 1f)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600024C")]
	[Cpp2IlInjected.Address(RVA = "0x5468390", Offset = "0x5467790", VA = "0x185468390", Slot = "101")]
	public void JLNINMHMEHA(BOPFIFMMKBG BPDOBLBNKEN, Vector3 NLFAAHHHDNN, float HHHNHCMFNFA = float.PositiveInfinity)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600024D")]
	[Cpp2IlInjected.Address(RVA = "0x5464600", Offset = "0x5463A00", VA = "0x185464600", Slot = "102")]
	[Obsolete]
	public void ADCBOLCDFHD(BOPFIFMMKBG BPDOBLBNKEN, Vector3 MCFIHGJCDCP, float BDCHAJELIHL = 7f, float ABPPGEHGCFI = 1f)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600024E")]
	[Cpp2IlInjected.Address(RVA = "0x5468940", Offset = "0x5467D40", VA = "0x185468940", Slot = "103")]
	public Vector3 KPFDHGBBOFB(Vector3 JFBPNBNBHOE)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x600024F")]
	[Cpp2IlInjected.Address(RVA = "0x54665E0", Offset = "0x54659E0", VA = "0x1854665E0", Slot = "104")]
	public Vector3 FHKEINJELIE(Vector3 JFBPNBNBHOE)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000250")]
	[Cpp2IlInjected.Address(RVA = "0x5468560", Offset = "0x5467960", VA = "0x185468560", Slot = "105")]
	public void KDDHFACBKGB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000253")]
	[Cpp2IlInjected.Address(RVA = "0x5468600", Offset = "0x5467A00", VA = "0x185468600", Slot = "106")]
	public void KFIEFEHILOK(PPMDIHPMNCG FONAKEEEKPK, object AJDBKDIMOHA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000254")]
	[Cpp2IlInjected.Address(RVA = "0x5469910", Offset = "0x5468D10", VA = "0x185469910", Slot = "107")]
	public void MMHJICPHJHL(object AJDBKDIMOHA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000261")]
	[Cpp2IlInjected.Address(RVA = "0x546A110", Offset = "0x5469510", VA = "0x18546A110", Slot = "110")]
	public void OCCLJJBDHKH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000262")]
	[Cpp2IlInjected.Address(RVA = "0x5468B30", Offset = "0x5467F30", VA = "0x185468B30", Slot = "111")]
	public void LGMIOPKMACL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000263")]
	[Cpp2IlInjected.Address(RVA = "0x546A330", Offset = "0x5469730", VA = "0x18546A330", Slot = "112")]
	public void PGLMPJOADGG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600026C")]
	[Cpp2IlInjected.Address(RVA = "0x5468340", Offset = "0x5467740", VA = "0x185468340", Slot = "115")]
	public bool JLGKLAGDNBA()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600026D")]
	[Cpp2IlInjected.Address(RVA = "0x54674D0", Offset = "0x54668D0", VA = "0x1854674D0", Slot = "79")]
	public void HFOIEEGNPME()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600026E")]
	[Cpp2IlInjected.Address(RVA = "0x5467E50", Offset = "0x5467250", VA = "0x185467E50", Slot = "116")]
	public void IPODHJMCCPD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000276")]
	[Cpp2IlInjected.Address(RVA = "0x5464DF0", Offset = "0x54641F0", VA = "0x185464DF0", Slot = "121")]
	public IDisposable BFJJEOKEAOO()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000277")]
	[Cpp2IlInjected.Address(RVA = "0x54677A0", Offset = "0x5466BA0", VA = "0x1854677A0", Slot = "122")]
	public void IDBKKNHMJCA(object AJDBKDIMOHA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000278")]
	[Cpp2IlInjected.Address(RVA = "0x5465200", Offset = "0x5464600", VA = "0x185465200", Slot = "123")]
	public void BPLEOILKCFF(object AJDBKDIMOHA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000279")]
	[Cpp2IlInjected.Address(RVA = "0x5469F10", Offset = "0x5469310", VA = "0x185469F10", Slot = "124")]
	public void NHDILIPFEBO(object AJDBKDIMOHA, bool NMHFDHPJGFL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600028A")]
	[Cpp2IlInjected.Address(RVA = "0x5464950", Offset = "0x5463D50", VA = "0x185464950", Slot = "127")]
	public void BBLLMNKJMFE(Vector3 LDBCCJOIJOF, Quaternion HPGHCBDEGFJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600028B")]
	[Cpp2IlInjected.Address(RVA = "0x54690C0", Offset = "0x54684C0", VA = "0x1854690C0", Slot = "128")]
	public void MBJKCDHFBPN(Vector3 JPBAEPJPHFP, Quaternion NHHKEMOEKHO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600028C")]
	[Cpp2IlInjected.Address(RVA = "0x5464E40", Offset = "0x5464240", VA = "0x185464E40", Slot = "129")]
	public bool BHKLDAAMMPP(float LCLMOJDNELD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000291")]
	[Cpp2IlInjected.Address(RVA = "0x546A2D0", Offset = "0x54696D0", VA = "0x18546A2D0", Slot = "130")]
	public void PGKAPIBFPCH(object AJDBKDIMOHA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000292")]
	[Cpp2IlInjected.Address(RVA = "0x5465B90", Offset = "0x5464F90", VA = "0x185465B90", Slot = "131")]
	public void DFLECBDEDLK(object AJDBKDIMOHA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000293")]
	[Cpp2IlInjected.Address(RVA = "0x546A050", Offset = "0x5469450", VA = "0x18546A050", Slot = "132")]
	public void NMDKIGJCKAP(object AJDBKDIMOHA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000294")]
	[Cpp2IlInjected.Address(RVA = "0x5467A90", Offset = "0x5466E90", VA = "0x185467A90", Slot = "133")]
	public void IGIJDOMADBN(object AJDBKDIMOHA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000295")]
	[Cpp2IlInjected.Address(RVA = "0x54695A0", Offset = "0x54689A0", VA = "0x1854695A0", Slot = "134")]
	public void MDAEENKEECK(Vector3 BIOMHNNIJHG, ForceMode HODPBICIGJM = ForceMode.Force)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000296")]
	[Cpp2IlInjected.Address(RVA = "0x5468B90", Offset = "0x5467F90", VA = "0x185468B90", Slot = "135")]
	public void LIGCOMLMAAG(Vector3 BIOMHNNIJHG, Vector3 DACBJNCMNFL, ForceMode HODPBICIGJM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000297")]
	[Cpp2IlInjected.Address(RVA = "0x5465C90", Offset = "0x5465090", VA = "0x185465C90", Slot = "136")]
	public void DPFOGKDMEOC(Vector3 CEBBAPNMMME, ForceMode HODPBICIGJM = ForceMode.Force)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000298")]
	[Cpp2IlInjected.Address(RVA = "0x5464D70", Offset = "0x5464170", VA = "0x185464D70", Slot = "137")]
	public void BFACFHPBMFM(Vector3 CEBBAPNMMME, ForceMode HODPBICIGJM = ForceMode.Force)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600029B")]
	[Cpp2IlInjected.Address(RVA = "0x5465520", Offset = "0x5464920", VA = "0x185465520", Slot = "138")]
	public bool CGHFGDDABEK(Vector3 HHOIMIMHDMP, out RaycastHit CFGLFCONCKN, float KMAOMDJLDEN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600029D")]
	[Cpp2IlInjected.Address(RVA = "0x54685B0", Offset = "0x54679B0", VA = "0x1854685B0", Slot = "139")]
	public void KEPOLBAFIFI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600029E")]
	[Cpp2IlInjected.Address(RVA = "0x546A4E0", Offset = "0x54698E0", VA = "0x18546A4E0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600029F")]
	[Cpp2IlInjected.Address(RVA = "0x5467330", Offset = "0x5466730", VA = "0x185467330")]
	private void HBHOOKIDFLC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002A0")]
	[Cpp2IlInjected.Address(RVA = "0x5467030", Offset = "0x5466430", VA = "0x185467030")]
	private void GODMFPJCOIP(PPMDIHPMNCG GPFONCECPBK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002A1")]
	[Cpp2IlInjected.Address(RVA = "0x5466CC0", Offset = "0x54660C0", VA = "0x185466CC0")]
	private void GEIPDHMHONB(PPMDIHPMNCG GPFONCECPBK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002A2")]
	[Cpp2IlInjected.Address(RVA = "0x5468A80", Offset = "0x5467E80", VA = "0x185468A80")]
	private void LCCDGODNNKA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002A3")]
	[Cpp2IlInjected.Address(RVA = "0x5465910", Offset = "0x5464D10", VA = "0x185465910")]
	private void DCFJEDJDJDJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002A4")]
	[Cpp2IlInjected.Address(RVA = "0x5464BB0", Offset = "0x5463FB0", VA = "0x185464BB0")]
	private void BCMJIIEKDMH(PPMDIHPMNCG KPJMALENPJM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002A5")]
	[Cpp2IlInjected.Address(RVA = "0x5465F30", Offset = "0x5465330", VA = "0x185465F30")]
	private void EDMPHFFCDKG(PPMDIHPMNCG GPFONCECPBK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002A6")]
	[Cpp2IlInjected.Address(RVA = "0x5465730", Offset = "0x5464B30", VA = "0x185465730")]
	private void CLFEMCONLMI(PPMDIHPMNCG GPFONCECPBK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002A7")]
	[Cpp2IlInjected.Address(RVA = "0x5469740", Offset = "0x5468B40", VA = "0x185469740")]
	private void MGOLANHOBAG(RigidbodyEx GPFONCECPBK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002A8")]
	[Cpp2IlInjected.Address(RVA = "0x5469B10", Offset = "0x5468F10", VA = "0x185469B10")]
	private void NGIBBCPNBOA(RigidbodyEx LDDCANHDBNB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002A9")]
	[Cpp2IlInjected.Address(RVA = "0x5466B90", Offset = "0x5465F90", VA = "0x185466B90")]
	[Conditional("UNITY_EDITOR")]
	private void GBBKFANCPBC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002AA")]
	[Cpp2IlInjected.Address(RVA = "0x5468D40", Offset = "0x5468140", VA = "0x185468D40")]
	protected void LJBKGLLIGBJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002AB")]
	[Cpp2IlInjected.Address(RVA = "0x5469270", Offset = "0x5468670", VA = "0x185469270")]
	protected void MCFCBPJMHID()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002A")]
internal static class NGJBPFLDFKF
{
	[Cpp2IlInjected.Token(Token = "0x60002AC")]
	[Cpp2IlInjected.Address(RVA = "0x547E8A0", Offset = "0x547DCA0", VA = "0x18547E8A0")]
	public static PPMDIHPMNCG FHCDDIJMGLI(this PPMDIHPMNCG LDDCANHDBNB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002AD")]
	[Cpp2IlInjected.Address(RVA = "0x547EA30", Offset = "0x547DE30", VA = "0x18547EA30")]
	public static bool PIOIGPFFMOJ(this PPMDIHPMNCG LDDCANHDBNB, PPMDIHPMNCG BIHOLEKLDHK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002AE")]
	[Cpp2IlInjected.Address(RVA = "0x547E960", Offset = "0x547DD60", VA = "0x18547E960")]
	public static bool GHPPJDKMCLL(this PPMDIHPMNCG LDDCANHDBNB, PPMDIHPMNCG FPKOBEGNFCF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002AF")]
	[Cpp2IlInjected.Address(RVA = "0x547E9E0", Offset = "0x547DDE0", VA = "0x18547E9E0")]
	public static RigidbodyEx JKIDPKKAFKH(this PPMDIHPMNCG AJDCHLHALFM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002B0")]
	[Cpp2IlInjected.Address(RVA = "0x547E830", Offset = "0x547DC30", VA = "0x18547E830")]
	public static DGHPEMNHGCH BBKKCEPBGIA(this PPMDIHPMNCG ONJEPBGIHBB)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200002B")]
internal class OHIEJDLAMPD : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000043")]
	private readonly DGHPEMNHGCH LDDCANHDBNB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000044")]
	private bool LKMIDCEHKGL;

	[Cpp2IlInjected.Token(Token = "0x60002B1")]
	[Cpp2IlInjected.Address(RVA = "0x54808D0", Offset = "0x547FCD0", VA = "0x1854808D0")]
	public OHIEJDLAMPD(DGHPEMNHGCH IAJFKOKFPMM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002B2")]
	[Cpp2IlInjected.Address(RVA = "0x5480870", Offset = "0x547FC70", VA = "0x185480870", Slot = "4")]
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
		[Cpp2IlInjected.Token(Token = "0x60002B4")]
		[Cpp2IlInjected.Address(RVA = "0x545A470", Offset = "0x5459870", VA = "0x18545A470")]
		get
		{
			return default(CollisionDetectionMode);
		}
		[Cpp2IlInjected.Token(Token = "0x60002B5")]
		[Cpp2IlInjected.Address(RVA = "0x545A0E0", Offset = "0x54594E0", VA = "0x18545A0E0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000BE")]
	private Rigidbody BAPEKECGLDP
	{
		[Cpp2IlInjected.Token(Token = "0x60002B6")]
		[Cpp2IlInjected.Address(RVA = "0x545A560", Offset = "0x5459960", VA = "0x18545A560")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000BF")]
	public CollisionDetectionMode CIEEKBNHEBL
	{
		[Cpp2IlInjected.Token(Token = "0x60002B9")]
		[Cpp2IlInjected.Address(RVA = "0x5459CD0", Offset = "0x54590D0", VA = "0x185459CD0", Slot = "4")]
		get
		{
			return default(CollisionDetectionMode);
		}
		[Cpp2IlInjected.Token(Token = "0x60002BA")]
		[Cpp2IlInjected.Address(RVA = "0x5459DE0", Offset = "0x54591E0", VA = "0x185459DE0", Slot = "5")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60002B3")]
	[Cpp2IlInjected.Address(RVA = "0x5458EB0", Offset = "0x54582B0", VA = "0x185458EB0")]
	public AEIOANFBMMA(PPMDIHPMNCG LDDCANHDBNB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002B7")]
	[Cpp2IlInjected.Address(RVA = "0x5459E60", Offset = "0x5459260", VA = "0x185459E60", Slot = "6")]
	public void BKOELLNKDDF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002B8")]
	[Cpp2IlInjected.Address(RVA = "0x545A1E0", Offset = "0x54595E0", VA = "0x18545A1E0", Slot = "9")]
	public void JPMOLDGLNJO(Rigidbody AOAFHPHKFMD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002BB")]
	[Cpp2IlInjected.Address(RVA = "0x545A550", Offset = "0x5459950", VA = "0x18545A550", Slot = "7")]
	public void NAIFDEINDCM(bool IOEMIKGMLIB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002BC")]
	[Cpp2IlInjected.Address(RVA = "0x545A1D0", Offset = "0x54595D0", VA = "0x18545A1D0", Slot = "8")]
	public void HCJANJMAAPB(bool IOEMIKGMLIB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002BD")]
	[Cpp2IlInjected.Address(RVA = "0x5459F70", Offset = "0x5459370", VA = "0x185459F70", Slot = "10")]
	public bool CGHFGDDABEK(Vector3 HHOIMIMHDMP, out RaycastHit CFGLFCONCKN, float KMAOMDJLDEN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002BE")]
	[Cpp2IlInjected.Address(RVA = "0x545A270", Offset = "0x5459670", VA = "0x18545A270")]
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
		[Cpp2IlInjected.Token(Token = "0x60002C2")]
		[Cpp2IlInjected.Address(RVA = "0x645DA70", Offset = "0x645CE70", VA = "0x18645DA70")]
		get
		{
			return default(PPGNAFCKNOL);
		}
		[Cpp2IlInjected.Token(Token = "0x60002C3")]
		[Cpp2IlInjected.Address(RVA = "0x645D6E0", Offset = "0x645CAE0", VA = "0x18645D6E0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000C1")]
	public PPGNAFCKNOL NHFAJHMDKMA
	{
		[Cpp2IlInjected.Token(Token = "0x60002C4")]
		[Cpp2IlInjected.Address(RVA = "0x645D880", Offset = "0x645CC80", VA = "0x18645D880", Slot = "6")]
		get
		{
			return default(PPGNAFCKNOL);
		}
		[Cpp2IlInjected.Token(Token = "0x60002C5")]
		[Cpp2IlInjected.Address(RVA = "0x645D6E0", Offset = "0x645CAE0", VA = "0x18645D6E0", Slot = "7")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000C2")]
	private Transform JBPFIGDCPFI
	{
		[Cpp2IlInjected.Token(Token = "0x60002CA")]
		[Cpp2IlInjected.Address(RVA = "0x6F98D0", Offset = "0x6F8CD0", VA = "0x1806F98D0", Slot = "10")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400002A")]
	public event Action<LHLIDFNIOKA, LHLIDFNIOKA> GBMBMPKHBHO
	{
		[Cpp2IlInjected.Token(Token = "0x60002C0")]
		[Cpp2IlInjected.Address(RVA = "0x645D7E0", Offset = "0x645CBE0", VA = "0x18645D7E0", Slot = "4")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60002C1")]
		[Cpp2IlInjected.Address(RVA = "0x645D640", Offset = "0x645CA40", VA = "0x18645D640", Slot = "5")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60002BF")]
	[Cpp2IlInjected.Address(RVA = "0x645DB60", Offset = "0x645CF60", VA = "0x18645DB60")]
	public PGEBMJCDBGG(PPMDIHPMNCG LDDCANHDBNB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002C6")]
	[Cpp2IlInjected.Address(RVA = "0x645DA10", Offset = "0x645CE10", VA = "0x18645DA10", Slot = "11")]
	public void OnChangedDistanceBand(LHLIDFNIOKA IAMOONJKNLF, LHLIDFNIOKA AFLEFPKENKF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002C7")]
	[Cpp2IlInjected.Address(RVA = "0x6D7320", Offset = "0x6D6720", VA = "0x1806D7320", Slot = "12")]
	public void OnChangedVisibility(bool HFPGMHEIJMF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002C8")]
	[Cpp2IlInjected.Address(RVA = "0x6D7320", Offset = "0x6D6720", VA = "0x1806D7320", Slot = "8")]
	public void BKOELLNKDDF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002C9")]
	[Cpp2IlInjected.Address(RVA = "0x6D7320", Offset = "0x6D6720", VA = "0x1806D7320", Slot = "9")]
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
		[Cpp2IlInjected.Token(Token = "0x60002CC")]
		[Cpp2IlInjected.Address(RVA = "0x545A560", Offset = "0x5459960", VA = "0x18545A560")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000C4")]
	private bool MBEHMAPDJBJ
	{
		[Cpp2IlInjected.Token(Token = "0x60002CD")]
		[Cpp2IlInjected.Address(RVA = "0x5462B60", Offset = "0x5461F60", VA = "0x185462B60")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000C5")]
	private bool DKNFKPAFDPB
	{
		[Cpp2IlInjected.Token(Token = "0x60002CE")]
		[Cpp2IlInjected.Address(RVA = "0x54618A0", Offset = "0x5460CA0", VA = "0x1854618A0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000C6")]
	private PPMDIHPMNCG EMIBHNNCMJC
	{
		[Cpp2IlInjected.Token(Token = "0x60002CF")]
		[Cpp2IlInjected.Address(RVA = "0x547E7D0", Offset = "0x547DBD0", VA = "0x18547E7D0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60002CB")]
	[Cpp2IlInjected.Address(RVA = "0x5458EB0", Offset = "0x54582B0", VA = "0x185458EB0")]
	public MIOINHIHDDF(PPMDIHPMNCG LDDCANHDBNB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002D0")]
	[Cpp2IlInjected.Address(RVA = "0x547E670", Offset = "0x547DA70", VA = "0x18547E670", Slot = "4")]
	public void MDAEENKEECK(Vector3 BIOMHNNIJHG, ForceMode HODPBICIGJM = ForceMode.Force)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002D1")]
	[Cpp2IlInjected.Address(RVA = "0x547DD70", Offset = "0x547D170", VA = "0x18547DD70")]
	private void BIAOBHKBAEN(Vector3 BIOMHNNIJHG, ForceMode HODPBICIGJM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002D2")]
	[Cpp2IlInjected.Address(RVA = "0x547E3D0", Offset = "0x547D7D0", VA = "0x18547E3D0", Slot = "5")]
	public void LIGCOMLMAAG(Vector3 BIOMHNNIJHG, Vector3 DACBJNCMNFL, ForceMode HODPBICIGJM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002D3")]
	[Cpp2IlInjected.Address(RVA = "0x547DFF0", Offset = "0x547D3F0", VA = "0x18547DFF0", Slot = "6")]
	public void DPFOGKDMEOC(Vector3 CEBBAPNMMME, ForceMode HODPBICIGJM = ForceMode.Force)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002D4")]
	[Cpp2IlInjected.Address(RVA = "0x547E150", Offset = "0x547D550", VA = "0x18547E150")]
	private void KDJCKDGOEKH(Vector3 CEBBAPNMMME, ForceMode HODPBICIGJM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002D5")]
	[Cpp2IlInjected.Address(RVA = "0x547DAF0", Offset = "0x547CEF0", VA = "0x18547DAF0", Slot = "7")]
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
		[Cpp2IlInjected.Token(Token = "0x60002D7")]
		[Cpp2IlInjected.Address(RVA = "0x5458AF0", Offset = "0x5457EF0", VA = "0x185458AF0", Slot = "4")]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x60002D8")]
		[Cpp2IlInjected.Address(RVA = "0x5458BD0", Offset = "0x5457FD0", VA = "0x185458BD0", Slot = "5")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60002D6")]
	[Cpp2IlInjected.Address(RVA = "0x5458EB0", Offset = "0x54582B0", VA = "0x185458EB0")]
	public AAMAJGCOMLD(PPMDIHPMNCG LDDCANHDBNB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002D9")]
	[Cpp2IlInjected.Address(RVA = "0x5458DB0", Offset = "0x54581B0", VA = "0x185458DB0", Slot = "6")]
	public void JPMOLDGLNJO(Rigidbody AOAFHPHKFMD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002DA")]
	[Cpp2IlInjected.Address(RVA = "0x5458A80", Offset = "0x5457E80", VA = "0x185458A80", Slot = "7")]
	public void AAGPIEFPDDG(Rigidbody AOAFHPHKFMD)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000030")]
internal sealed class LNBCMGCECLM : ABJBDNIKKNI, HMOOAGCGLKM, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x400004F")]
	private readonly OBDJKKFDJOF PLBLCMNMLJO;

	[Cpp2IlInjected.Token(Token = "0x170000C8")]
	private Transform LNPNGFHHEEL
	{
		[Cpp2IlInjected.Token(Token = "0x60002EE")]
		[Cpp2IlInjected.Address(RVA = "0x54776D0", Offset = "0x5476AD0", VA = "0x1854776D0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000C9")]
	public NFJEDPPAJMK JEDNMIFCMOC
	{
		[Cpp2IlInjected.Token(Token = "0x60002F0")]
		[Cpp2IlInjected.Address(RVA = "0x5478820", Offset = "0x5477C20", VA = "0x185478820")]
		get
		{
			return default(NFJEDPPAJMK);
		}
		[Cpp2IlInjected.Token(Token = "0x60002F1")]
		[Cpp2IlInjected.Address(RVA = "0x54798B0", Offset = "0x5478CB0", VA = "0x1854798B0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000CA")]
	public PPMDIHPMNCG EMIBHNNCMJC
	{
		[Cpp2IlInjected.Token(Token = "0x60002F2")]
		[Cpp2IlInjected.Address(RVA = "0x54795C0", Offset = "0x54789C0", VA = "0x1854795C0", Slot = "24")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60002F3")]
		[Cpp2IlInjected.Address(RVA = "0x5479840", Offset = "0x5478C40", VA = "0x185479840", Slot = "25")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000CB")]
	public NFJEDPPAJMK DOFKLIOFOPG
	{
		[Cpp2IlInjected.Token(Token = "0x60002F4")]
		[Cpp2IlInjected.Address(RVA = "0x5478920", Offset = "0x5477D20", VA = "0x185478920")]
		get
		{
			return default(NFJEDPPAJMK);
		}
		[Cpp2IlInjected.Token(Token = "0x60002F5")]
		[Cpp2IlInjected.Address(RVA = "0x5479420", Offset = "0x5478820", VA = "0x185479420")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000CC")]
	public PPMDIHPMNCG MDHMHFAIMJJ
	{
		[Cpp2IlInjected.Token(Token = "0x60002F6")]
		[Cpp2IlInjected.Address(RVA = "0x5478C60", Offset = "0x5478060", VA = "0x185478C60", Slot = "23")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000CD")]
	public IReadOnlyList<PPMDIHPMNCG> LILCAAEDFCG
	{
		[Cpp2IlInjected.Token(Token = "0x60002F7")]
		[Cpp2IlInjected.Address(RVA = "0x77D5F0", Offset = "0x77C9F0", VA = "0x18077D5F0", Slot = "22")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400002B")]
	public event JPOFABMOGOF KMPDHKDHBNO
	{
		[Cpp2IlInjected.Token(Token = "0x60002DC")]
		[Cpp2IlInjected.Address(RVA = "0x5477DD0", Offset = "0x54771D0", VA = "0x185477DD0", Slot = "4")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60002DD")]
		[Cpp2IlInjected.Address(RVA = "0x5478F00", Offset = "0x5478300", VA = "0x185478F00", Slot = "5")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400002C")]
	public event JPOFABMOGOF FIBPOODLACB
	{
		[Cpp2IlInjected.Token(Token = "0x60002DE")]
		[Cpp2IlInjected.Address(RVA = "0x5479520", Offset = "0x5478920", VA = "0x185479520", Slot = "6")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60002DF")]
		[Cpp2IlInjected.Address(RVA = "0x5477A20", Offset = "0x5476E20", VA = "0x185477A20", Slot = "7")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400002D")]
	public event CBNHIOLMAOO LEBPAEACGHM
	{
		[Cpp2IlInjected.Token(Token = "0x60002E0")]
		[Cpp2IlInjected.Address(RVA = "0x5479040", Offset = "0x5478440", VA = "0x185479040", Slot = "8")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60002E1")]
		[Cpp2IlInjected.Address(RVA = "0x5478BC0", Offset = "0x5477FC0", VA = "0x185478BC0", Slot = "9")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400002E")]
	public event Action FJCAMHJDHPJ
	{
		[Cpp2IlInjected.Token(Token = "0x60002E2")]
		[Cpp2IlInjected.Address(RVA = "0x5477700", Offset = "0x5476B00", VA = "0x185477700", Slot = "10")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60002E3")]
		[Cpp2IlInjected.Address(RVA = "0x5477630", Offset = "0x5476A30", VA = "0x185477630", Slot = "11")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400002F")]
	public event Action CJALHGJOGOA
	{
		[Cpp2IlInjected.Token(Token = "0x60002E4")]
		[Cpp2IlInjected.Address(RVA = "0x5479C10", Offset = "0x5479010", VA = "0x185479C10", Slot = "12")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60002E5")]
		[Cpp2IlInjected.Address(RVA = "0x5478CA0", Offset = "0x54780A0", VA = "0x185478CA0", Slot = "13")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000030")]
	public event Action<PPMDIHPMNCG> JIFKALNNAKN
	{
		[Cpp2IlInjected.Token(Token = "0x60002E6")]
		[Cpp2IlInjected.Address(RVA = "0x5478FA0", Offset = "0x54783A0", VA = "0x185478FA0", Slot = "14")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60002E7")]
		[Cpp2IlInjected.Address(RVA = "0x54799B0", Offset = "0x5478DB0", VA = "0x1854799B0", Slot = "15")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000031")]
	public event Action<PPMDIHPMNCG> DACGCLEDAOG
	{
		[Cpp2IlInjected.Token(Token = "0x60002E8")]
		[Cpp2IlInjected.Address(RVA = "0x5477D30", Offset = "0x5477130", VA = "0x185477D30", Slot = "16")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60002E9")]
		[Cpp2IlInjected.Address(RVA = "0x5479600", Offset = "0x5478A00", VA = "0x185479600", Slot = "17")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000032")]
	public event Action HEMJJFHJOBJ
	{
		[Cpp2IlInjected.Token(Token = "0x60002EA")]
		[Cpp2IlInjected.Address(RVA = "0x54777A0", Offset = "0x5476BA0", VA = "0x1854777A0", Slot = "18")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60002EB")]
		[Cpp2IlInjected.Address(RVA = "0x5479380", Offset = "0x5478780", VA = "0x185479380", Slot = "19")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000033")]
	public event Action<PPMDIHPMNCG> NDOMLKAOIDP
	{
		[Cpp2IlInjected.Token(Token = "0x60002EC")]
		[Cpp2IlInjected.Address(RVA = "0x54797A0", Offset = "0x5478BA0", VA = "0x1854797A0", Slot = "20")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60002ED")]
		[Cpp2IlInjected.Address(RVA = "0x5477AC0", Offset = "0x5476EC0", VA = "0x185477AC0", Slot = "21")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60002DB")]
	[Cpp2IlInjected.Address(RVA = "0x5479CB0", Offset = "0x54790B0", VA = "0x185479CB0")]
	public LNBCMGCECLM(PPMDIHPMNCG LDDCANHDBNB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002EF")]
	[Cpp2IlInjected.Address(RVA = "0x5477B60", Offset = "0x5476F60", VA = "0x185477B60", Slot = "27")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002F8")]
	[Cpp2IlInjected.Address(RVA = "0x5479150", Offset = "0x5478550", VA = "0x185479150", Slot = "26")]
	public void KKGLFGKJMPP(PPMDIHPMNCG DPPABCPODHG, bool LMKLDOOIJAA = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002F9")]
	[Cpp2IlInjected.Address(RVA = "0x54790E0", Offset = "0x54784E0", VA = "0x1854790E0")]
	private void KKGLFGKJMPP(LKOIEBFOHCO DPPABCPODHG, bool LMKLDOOIJAA = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002FA")]
	[Cpp2IlInjected.Address(RVA = "0x5477FA0", Offset = "0x54773A0", VA = "0x185477FA0")]
	private void FNMCIHFPIAM(LKOIEBFOHCO DPPABCPODHG, bool LMKLDOOIJAA = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002FB")]
	[Cpp2IlInjected.Address(RVA = "0x5479A50", Offset = "0x5478E50", VA = "0x185479A50")]
	private void PLMMLEJPFJC(LKOIEBFOHCO KPJMALENPJM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002FC")]
	[Cpp2IlInjected.Address(RVA = "0x5478D40", Offset = "0x5478140", VA = "0x185478D40")]
	private void IBABMBDNBHE(LKOIEBFOHCO KPJMALENPJM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002FD")]
	[Cpp2IlInjected.Address(RVA = "0x5478A20", Offset = "0x5477E20", VA = "0x185478A20")]
	private void HFLEBMEBODA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002FE")]
	[Cpp2IlInjected.Address(RVA = "0x54791D0", Offset = "0x54785D0", VA = "0x1854791D0")]
	private void KLFLFGBKAAA(LKOIEBFOHCO KPJMALENPJM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002FF")]
	[Cpp2IlInjected.Address(RVA = "0x5477970", Offset = "0x5476D70", VA = "0x185477970")]
	private void COMAAFBCCFI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000300")]
	[Cpp2IlInjected.Address(RVA = "0x5477840", Offset = "0x5476C40", VA = "0x185477840")]
	private void CMMLKAPMCHH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000301")]
	[Cpp2IlInjected.Address(RVA = "0x5477E70", Offset = "0x5477270", VA = "0x185477E70")]
	private void FIMHIJJNHNG(LKOIEBFOHCO LDDCANHDBNB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000302")]
	[Cpp2IlInjected.Address(RVA = "0x5479250", Offset = "0x5478650", VA = "0x185479250")]
	private void LNGINODJAIF(LKOIEBFOHCO LDDCANHDBNB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000303")]
	[Cpp2IlInjected.Address(RVA = "0x54796A0", Offset = "0x5478AA0", VA = "0x1854796A0")]
	[CompilerGenerated]
	private object NBAEBBOFGBJ()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000031")]
internal static class HJANCICDJND
{
	[Cpp2IlInjected.Token(Token = "0x6000304")]
	[Cpp2IlInjected.Address(RVA = "0x5472180", Offset = "0x5471580", VA = "0x185472180")]
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
		[Cpp2IlInjected.Token(Token = "0x6000306")]
		[Cpp2IlInjected.Address(RVA = "0x5459420", Offset = "0x5458820", VA = "0x185459420", Slot = "4")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000CF")]
	public Vector3 EOFHLAGNPII
	{
		[Cpp2IlInjected.Token(Token = "0x6000307")]
		[Cpp2IlInjected.Address(RVA = "0x5459930", Offset = "0x5458D30", VA = "0x185459930", Slot = "5")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000D0")]
	private Vector3 MHCLHNEGJDD
	{
		[Cpp2IlInjected.Token(Token = "0x600030B")]
		[Cpp2IlInjected.Address(RVA = "0x5459080", Offset = "0x5458480", VA = "0x185459080")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000D1")]
	private PPMDIHPMNCG MMCLEEKFDKC
	{
		[Cpp2IlInjected.Token(Token = "0x600030C")]
		[Cpp2IlInjected.Address(RVA = "0x5459B70", Offset = "0x5458F70", VA = "0x185459B70")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000305")]
	[Cpp2IlInjected.Address(RVA = "0x5458EB0", Offset = "0x54582B0", VA = "0x185458EB0")]
	public ADKNLKJCAMG(PPMDIHPMNCG LDDCANHDBNB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000308")]
	[Cpp2IlInjected.Address(RVA = "0x5459290", Offset = "0x5458690", VA = "0x185459290", Slot = "6")]
	public void CNAAFOJMHNK(PPMDIHPMNCG GPFONCECPBK, object AJDBKDIMOHA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000309")]
	[Cpp2IlInjected.Address(RVA = "0x5459160", Offset = "0x5458560", VA = "0x185459160")]
	private void CNAAFOJMHNK(LKOIEBFOHCO GPFONCECPBK, object AJDBKDIMOHA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600030A")]
	[Cpp2IlInjected.Address(RVA = "0x5459450", Offset = "0x5458850", VA = "0x185459450", Slot = "7")]
	public void JOEIIPCOBII(object AJDBKDIMOHA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600030D")]
	[Cpp2IlInjected.Address(RVA = "0x5459540", Offset = "0x5458940", VA = "0x185459540")]
	private Vector3 MIDPCEDMHPH()
	{
		return default(Vector3);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000033")]
internal static class KELBFOGLOFF
{
	[Cpp2IlInjected.Token(Token = "0x600030E")]
	[Cpp2IlInjected.Address(RVA = "0x5476440", Offset = "0x5475840", VA = "0x185476440")]
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
		[Cpp2IlInjected.Token(Token = "0x6000312")]
		[Cpp2IlInjected.Address(RVA = "0x547AFC0", Offset = "0x547A3C0", VA = "0x18547AFC0", Slot = "6")]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x6000313")]
		[Cpp2IlInjected.Address(RVA = "0x547ACD0", Offset = "0x547A0D0", VA = "0x18547ACD0", Slot = "7")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000D3")]
	public Vector3 PMKFGPJNJBI
	{
		[Cpp2IlInjected.Token(Token = "0x6000314")]
		[Cpp2IlInjected.Address(RVA = "0x547A6F0", Offset = "0x5479AF0", VA = "0x18547A6F0", Slot = "8")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000D4")]
	public float KLNDCEHFMBA
	{
		[Cpp2IlInjected.Token(Token = "0x6000315")]
		[Cpp2IlInjected.Address(RVA = "0x547AEB0", Offset = "0x547A2B0", VA = "0x18547AEB0", Slot = "9")]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x6000316")]
		[Cpp2IlInjected.Address(RVA = "0x547AFB0", Offset = "0x547A3B0", VA = "0x18547AFB0")]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000D5")]
	public float NBJLLACMBLF
	{
		[Cpp2IlInjected.Token(Token = "0x6000317")]
		[Cpp2IlInjected.Address(RVA = "0x547B0F0", Offset = "0x547A4F0", VA = "0x18547B0F0", Slot = "10")]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x6000318")]
		[Cpp2IlInjected.Address(RVA = "0x547C6F0", Offset = "0x547BAF0", VA = "0x18547C6F0", Slot = "11")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000D6")]
	public Vector3 OFFHJCCLOEB
	{
		[Cpp2IlInjected.Token(Token = "0x6000319")]
		[Cpp2IlInjected.Address(RVA = "0x547AA10", Offset = "0x5479E10", VA = "0x18547AA10", Slot = "12")]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x600031A")]
		[Cpp2IlInjected.Address(RVA = "0x547ACA0", Offset = "0x547A0A0", VA = "0x18547ACA0", Slot = "13")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000D7")]
	public Quaternion MOMBOPJMDMK
	{
		[Cpp2IlInjected.Token(Token = "0x600031B")]
		[Cpp2IlInjected.Address(RVA = "0x547A9E0", Offset = "0x5479DE0", VA = "0x18547A9E0", Slot = "14")]
		get
		{
			return default(Quaternion);
		}
		[Cpp2IlInjected.Token(Token = "0x600031C")]
		[Cpp2IlInjected.Address(RVA = "0x547AF90", Offset = "0x547A390", VA = "0x18547AF90", Slot = "15")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000D8")]
	private Rigidbody BAPEKECGLDP
	{
		[Cpp2IlInjected.Token(Token = "0x6000324")]
		[Cpp2IlInjected.Address(RVA = "0x545A560", Offset = "0x5459960", VA = "0x18545A560")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000034")]
	public event JPOFABMOGOF GOMGJPJMHIM
	{
		[Cpp2IlInjected.Token(Token = "0x600030F")]
		[Cpp2IlInjected.Address(RVA = "0x547AA40", Offset = "0x5479E40", VA = "0x18547AA40", Slot = "4")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000310")]
		[Cpp2IlInjected.Address(RVA = "0x547AE10", Offset = "0x547A210", VA = "0x18547AE10", Slot = "5")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000311")]
	[Cpp2IlInjected.Address(RVA = "0x547D830", Offset = "0x547CC30", VA = "0x18547D830")]
	public MGGEKCMKNIA(PPMDIHPMNCG LDDCANHDBNB, in OALOFNDFAEL ONIBEFDCPGD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600031D")]
	[Cpp2IlInjected.Address(RVA = "0x547C4E0", Offset = "0x547B8E0", VA = "0x18547C4E0", Slot = "17")]
	public void OCCLJJBDHKH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600031E")]
	[Cpp2IlInjected.Address(RVA = "0x547BD20", Offset = "0x547B120", VA = "0x18547BD20", Slot = "16")]
	public void LGMIOPKMACL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600031F")]
	[Cpp2IlInjected.Address(RVA = "0x547B400", Offset = "0x547A800", VA = "0x18547B400", Slot = "19")]
	public void JPMOLDGLNJO(Rigidbody AOAFHPHKFMD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000320")]
	[Cpp2IlInjected.Address(RVA = "0x547A250", Offset = "0x5479650", VA = "0x18547A250", Slot = "20")]
	public void AAGPIEFPDDG(Rigidbody AOAFHPHKFMD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000321")]
	[Cpp2IlInjected.Address(RVA = "0x547C700", Offset = "0x547BB00", VA = "0x18547C700", Slot = "18")]
	public void PGLMPJOADGG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000322")]
	[Cpp2IlInjected.Address(RVA = "0x547B620", Offset = "0x547AA20", VA = "0x18547B620", Slot = "21")]
	public void KEPOLBAFIFI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000323")]
	[Cpp2IlInjected.Address(RVA = "0x5460750", Offset = "0x545FB50", VA = "0x185460750")]
	public void LHPJDEELCAK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000325")]
	[Cpp2IlInjected.Address(RVA = "0x547ACD0", Offset = "0x547A0D0", VA = "0x18547ACD0")]
	private void HBJMIFMDHJH(Vector3 JFBPNBNBHOE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000326")]
	[Cpp2IlInjected.Address(RVA = "0x547A5D0", Offset = "0x54799D0", VA = "0x18547A5D0")]
	private Vector3 BCKCCAMLFFB()
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000327")]
	[Cpp2IlInjected.Address(RVA = "0x547A810", Offset = "0x5479C10", VA = "0x18547A810")]
	private void CGGJFFODFCK(float JFBPNBNBHOE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000328")]
	[Cpp2IlInjected.Address(RVA = "0x547AAE0", Offset = "0x5479EE0", VA = "0x18547AAE0")]
	private void FPOBCCILBBI(float JFBPNBNBHOE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000329")]
	[Cpp2IlInjected.Address(RVA = "0x547C0A0", Offset = "0x547B4A0", VA = "0x18547C0A0")]
	private Vector3 LIHAPOLOMJO()
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x600032A")]
	[Cpp2IlInjected.Address(RVA = "0x547B1D0", Offset = "0x547A5D0", VA = "0x18547B1D0")]
	private void IPFFPNBFENN(Vector3 JFBPNBNBHOE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600032B")]
	[Cpp2IlInjected.Address(RVA = "0x547C2D0", Offset = "0x547B6D0", VA = "0x18547C2D0")]
	private Quaternion MFJCLLLJOKO()
	{
		return default(Quaternion);
	}

	[Cpp2IlInjected.Token(Token = "0x600032C")]
	[Cpp2IlInjected.Address(RVA = "0x547BB10", Offset = "0x547AF10", VA = "0x18547BB10")]
	private void KKICMMPIOEM(Quaternion JFBPNBNBHOE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600032D")]
	[Cpp2IlInjected.Address(RVA = "0x547C7E0", Offset = "0x547BBE0", VA = "0x18547C7E0")]
	internal (float, Vector3) PJKJFLIKEBB(Rigidbody MJNKCPJACPF)
	{
		return default((float, Vector3));
	}
}
[Cpp2IlInjected.Token(Token = "0x2000035")]
internal static class FCOOIHCEFMG
{
	[Cpp2IlInjected.Token(Token = "0x600032E")]
	[Cpp2IlInjected.Address(RVA = "0x5470320", Offset = "0x546F720", VA = "0x185470320")]
	public static MGGEKCMKNIA NDHEADMHLHM(this PPMDIHPMNCG ONJEPBGIHBB)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000036")]
internal sealed class NNDBLHLNAOB : ABJBDNIKKNI, EBCDLOKEBCP
{
	[Cpp2IlInjected.Token(Token = "0x4000051")]
	private const string EMNENHPAIJN = "INTERP_PAUSE";

	[Cpp2IlInjected.Token(Token = "0x170000D9")]
	public bool FKLEIIKAOJF
	{
		[Cpp2IlInjected.Token(Token = "0x600032F")]
		[Cpp2IlInjected.Address(RVA = "0x547FD60", Offset = "0x547F160", VA = "0x18547FD60", Slot = "4")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000DA")]
	public GDPCJHNBEPD MDBJGCBLKKA
	{
		[Cpp2IlInjected.Token(Token = "0x6000330")]
		[Cpp2IlInjected.Address(RVA = "0x547FC60", Offset = "0x547F060", VA = "0x18547FC60", Slot = "5")]
		get
		{
			return default(GDPCJHNBEPD);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000DB")]
	private GDPCJHNBEPD AKFNPMCICJM
	{
		[Cpp2IlInjected.Token(Token = "0x6000332")]
		[Cpp2IlInjected.Address(RVA = "0x547F8E0", Offset = "0x547ECE0", VA = "0x18547F8E0")]
		get
		{
			return default(GDPCJHNBEPD);
		}
		[Cpp2IlInjected.Token(Token = "0x6000333")]
		[Cpp2IlInjected.Address(RVA = "0x547FB70", Offset = "0x547EF70", VA = "0x18547FB70")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000331")]
	[Cpp2IlInjected.Address(RVA = "0x54801D0", Offset = "0x547F5D0", VA = "0x1854801D0")]
	public NNDBLHLNAOB(PPMDIHPMNCG LDDCANHDBNB, in OALOFNDFAEL ONIBEFDCPGD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000334")]
	[Cpp2IlInjected.Address(RVA = "0x547F820", Offset = "0x547EC20", VA = "0x18547F820", Slot = "6")]
	public void BKOELLNKDDF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000335")]
	[Cpp2IlInjected.Address(RVA = "0x547F9C0", Offset = "0x547EDC0", VA = "0x18547F9C0")]
	private bool EIPAKAFJFHC()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000336")]
	[Cpp2IlInjected.Address(RVA = "0x547FF90", Offset = "0x547F390", VA = "0x18547FF90", Slot = "7")]
	public void MPHPJCHHDKL(object AJDBKDIMOHA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000337")]
	[Cpp2IlInjected.Address(RVA = "0x5480090", Offset = "0x547F490", VA = "0x185480090", Slot = "8")]
	public void NEGAEOLBLHL(object AJDBKDIMOHA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000338")]
	[Cpp2IlInjected.Address(RVA = "0x547FA60", Offset = "0x547EE60", VA = "0x18547FA60", Slot = "11")]
	public void HIJAJPCLBLB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000339")]
	[Cpp2IlInjected.Address(RVA = "0x547FC70", Offset = "0x547F070", VA = "0x18547FC70")]
	private void KDHHGDDDAKA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600033A")]
	[Cpp2IlInjected.Address(RVA = "0x547FE40", Offset = "0x547F240", VA = "0x18547FE40")]
	private void MCILODDNPMG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600033B")]
	[Cpp2IlInjected.Address(RVA = "0x5480190", Offset = "0x547F590", VA = "0x185480190", Slot = "10")]
	public void ONIPMDLLNFC(PPMDIHPMNCG LDDCANHDBNB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600033C")]
	[Cpp2IlInjected.Address(RVA = "0x547F7E0", Offset = "0x547EBE0", VA = "0x18547F7E0", Slot = "9")]
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
		[Cpp2IlInjected.Token(Token = "0x600033F")]
		[Cpp2IlInjected.Address(RVA = "0x545E1D0", Offset = "0x545D5D0", VA = "0x18545E1D0", Slot = "6")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000DD")]
	public IEnumerable<object> EKIDKKGDMDH
	{
		[Cpp2IlInjected.Token(Token = "0x6000340")]
		[Cpp2IlInjected.Address(RVA = "0x545E3B0", Offset = "0x545D7B0", VA = "0x18545E3B0", Slot = "7")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000DE")]
	private bool HADPPGCCBPA
	{
		[Cpp2IlInjected.Token(Token = "0x6000341")]
		[Cpp2IlInjected.Address(RVA = "0x545DFE0", Offset = "0x545D3E0", VA = "0x18545DFE0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000035")]
	public event JPOFABMOGOF JDAOGMBMFNA
	{
		[Cpp2IlInjected.Token(Token = "0x600033D")]
		[Cpp2IlInjected.Address(RVA = "0x545E290", Offset = "0x545D690", VA = "0x18545E290", Slot = "4")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600033E")]
		[Cpp2IlInjected.Address(RVA = "0x545E120", Offset = "0x545D520", VA = "0x18545E120", Slot = "5")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000342")]
	[Cpp2IlInjected.Address(RVA = "0x5458EB0", Offset = "0x54582B0", VA = "0x185458EB0")]
	public AHIKCLCKAFC(PPMDIHPMNCG LDDCANHDBNB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000343")]
	[Cpp2IlInjected.Address(RVA = "0x545E0C0", Offset = "0x545D4C0", VA = "0x18545E0C0", Slot = "11")]
	public IDisposable BFJJEOKEAOO()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000344")]
	[Cpp2IlInjected.Address(RVA = "0x545E330", Offset = "0x545D730", VA = "0x18545E330", Slot = "8")]
	public void IDBKKNHMJCA(object AJDBKDIMOHA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000345")]
	[Cpp2IlInjected.Address(RVA = "0x545E1C0", Offset = "0x545D5C0", VA = "0x18545E1C0", Slot = "9")]
	public void BPLEOILKCFF(object AJDBKDIMOHA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000346")]
	[Cpp2IlInjected.Address(RVA = "0x545E490", Offset = "0x545D890", VA = "0x18545E490", Slot = "10")]
	public void NHDILIPFEBO(object AJDBKDIMOHA, bool NMHFDHPJGFL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000347")]
	[Cpp2IlInjected.Address(RVA = "0x545E340", Offset = "0x545D740", VA = "0x18545E340", Slot = "12")]
	public void JPMOLDGLNJO(Rigidbody IHFIBCKLILB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000348")]
	[Cpp2IlInjected.Address(RVA = "0x545DFB0", Offset = "0x545D3B0", VA = "0x18545DFB0", Slot = "13")]
	public void AAGPIEFPDDG(Rigidbody AOAFHPHKFMD)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000038")]
internal sealed class EKPLBPEKBHJ : ABJBDNIKKNI, LNJFNCEGNCA, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000054")]
	private PhotonView CAIDBGJNFEP;

	[Cpp2IlInjected.Token(Token = "0x170000DF")]
	public bool PJPIAHDKHLD
	{
		[Cpp2IlInjected.Token(Token = "0x600034B")]
		[Cpp2IlInjected.Address(RVA = "0x546B670", Offset = "0x546AA70", VA = "0x18546B670", Slot = "6")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000E0")]
	public bool EMGPBBGPGIE
	{
		[Cpp2IlInjected.Token(Token = "0x600034C")]
		[Cpp2IlInjected.Address(RVA = "0x546B350", Offset = "0x546A750", VA = "0x18546B350", Slot = "7")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000036")]
	public event JPOFABMOGOF OFDNMEKJKBP
	{
		[Cpp2IlInjected.Token(Token = "0x6000349")]
		[Cpp2IlInjected.Address(RVA = "0x546C050", Offset = "0x546B450", VA = "0x18546C050", Slot = "4")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600034A")]
		[Cpp2IlInjected.Address(RVA = "0x546BC60", Offset = "0x546B060", VA = "0x18546BC60", Slot = "5")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600034D")]
	[Cpp2IlInjected.Address(RVA = "0x546C0F0", Offset = "0x546B4F0", VA = "0x18546C0F0")]
	public EKPLBPEKBHJ(PPMDIHPMNCG LDDCANHDBNB, in OALOFNDFAEL ONIBEFDCPGD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600034E")]
	[Cpp2IlInjected.Address(RVA = "0x546B200", Offset = "0x546A600", VA = "0x18546B200", Slot = "8")]
	public void BKOELLNKDDF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600034F")]
	[Cpp2IlInjected.Address(RVA = "0x546B690", Offset = "0x546AA90", VA = "0x18546B690", Slot = "11")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000350")]
	[Cpp2IlInjected.Address(RVA = "0x546BA50", Offset = "0x546AE50", VA = "0x18546BA50", Slot = "9")]
	public void EDMPHFFCDKG(PPMDIHPMNCG GPFONCECPBK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000351")]
	[Cpp2IlInjected.Address(RVA = "0x546B460", Offset = "0x546A860", VA = "0x18546B460", Slot = "10")]
	public void CLFEMCONLMI(PPMDIHPMNCG GPFONCECPBK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000352")]
	[Cpp2IlInjected.Address(RVA = "0x546BE60", Offset = "0x546B260", VA = "0x18546BE60")]
	private void JIANJEKONCC(PhotonView MBHHONACMIO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000353")]
	[Cpp2IlInjected.Address(RVA = "0x546BD00", Offset = "0x546B100", VA = "0x18546BD00")]
	private void IEJGPNIHMFH(RigidbodyEx KEPNDNMPIMB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000354")]
	[Cpp2IlInjected.Address(RVA = "0x546B880", Offset = "0x546AC80", VA = "0x18546B880")]
	private void EDLABONOLPP(PhotonView PEDIMHHLKDL)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000039")]
internal static class KJILMACANBH
{
	[Cpp2IlInjected.Token(Token = "0x6000355")]
	[Cpp2IlInjected.Address(RVA = "0x54764D0", Offset = "0x54758D0", VA = "0x1854764D0")]
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
		[Cpp2IlInjected.Token(Token = "0x6000356")]
		[Cpp2IlInjected.Address(RVA = "0x54733A0", Offset = "0x54727A0", VA = "0x1854733A0", Slot = "4")]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000357")]
		[Cpp2IlInjected.Address(RVA = "0x5472FE0", Offset = "0x54723E0", VA = "0x185472FE0", Slot = "5")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000E2")]
	public bool AGHKJBONNGE
	{
		[Cpp2IlInjected.Token(Token = "0x6000358")]
		[Cpp2IlInjected.Address(RVA = "0x5473480", Offset = "0x5472880", VA = "0x185473480", Slot = "6")]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000359")]
		[Cpp2IlInjected.Address(RVA = "0x54731B0", Offset = "0x54725B0", VA = "0x1854731B0")]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000E3")]
	public RigidbodyConstraints BCMJAHAELOH
	{
		[Cpp2IlInjected.Token(Token = "0x600035A")]
		[Cpp2IlInjected.Address(RVA = "0x54730D0", Offset = "0x54724D0", VA = "0x1854730D0", Slot = "7")]
		get
		{
			return default(RigidbodyConstraints);
		}
		[Cpp2IlInjected.Token(Token = "0x600035B")]
		[Cpp2IlInjected.Address(RVA = "0x5473560", Offset = "0x5472960", VA = "0x185473560", Slot = "8")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600035C")]
	[Cpp2IlInjected.Address(RVA = "0x5473760", Offset = "0x5472B60", VA = "0x185473760")]
	public IIGDJLFMGDO(PPMDIHPMNCG LDDCANHDBNB, in OALOFNDFAEL ONIBEFDCPGD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600035D")]
	[Cpp2IlInjected.Address(RVA = "0x54732A0", Offset = "0x54726A0", VA = "0x1854732A0", Slot = "9")]
	public void JPMOLDGLNJO(Rigidbody AOAFHPHKFMD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600035E")]
	[Cpp2IlInjected.Address(RVA = "0x5472EE0", Offset = "0x54722E0", VA = "0x185472EE0", Slot = "10")]
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
		[Cpp2IlInjected.Token(Token = "0x6000360")]
		[Cpp2IlInjected.Address(RVA = "0x54766C0", Offset = "0x5475AC0", VA = "0x1854766C0", Slot = "4")]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x6000361")]
		[Cpp2IlInjected.Address(RVA = "0x5476970", Offset = "0x5475D70", VA = "0x185476970", Slot = "5")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000E5")]
	public float CFMIJLIHCIE
	{
		[Cpp2IlInjected.Token(Token = "0x6000362")]
		[Cpp2IlInjected.Address(RVA = "0x5476D10", Offset = "0x5476110", VA = "0x185476D10", Slot = "6")]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x6000363")]
		[Cpp2IlInjected.Address(RVA = "0x5476B40", Offset = "0x5475F40", VA = "0x185476B40", Slot = "7")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600035F")]
	[Cpp2IlInjected.Address(RVA = "0x5458EB0", Offset = "0x54582B0", VA = "0x185458EB0")]
	public LHHKJMBGNNK(PPMDIHPMNCG LDDCANHDBNB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000364")]
	[Cpp2IlInjected.Address(RVA = "0x54767A0", Offset = "0x5475BA0", VA = "0x1854767A0", Slot = "8")]
	public void JPMOLDGLNJO(Rigidbody AOAFHPHKFMD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000365")]
	[Cpp2IlInjected.Address(RVA = "0x54765F0", Offset = "0x54759F0", VA = "0x1854765F0", Slot = "9")]
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
		[Cpp2IlInjected.Token(Token = "0x4000055")]
		private static readonly FADHLPPNOEF ICGADBEDOKK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000056")]
		private MCAEHJPOCLP LDDCANHDBNB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000057")]
		private bool LKMIDCEHKGL;

		[Cpp2IlInjected.Token(Token = "0x170000E6")]
		public bool ACLLOIKFPLE
		{
			[Cpp2IlInjected.Token(Token = "0x6000368")]
			[Cpp2IlInjected.Address(RVA = "0x7B85D0", Offset = "0x7B79D0", VA = "0x1807B85D0", Slot = "5")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000366")]
		[Cpp2IlInjected.Address(RVA = "0x645DD40", Offset = "0x645D140", VA = "0x18645DD40", Slot = "4")]
		public void PEIMLKLDOFJ(JHLNNPKIFCO KOKEGENGCAH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000367")]
		[Cpp2IlInjected.Address(RVA = "0x645DD10", Offset = "0x645D110", VA = "0x18645DD10", Slot = "7")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000369")]
		[Cpp2IlInjected.Address(RVA = "0x645DD90", Offset = "0x645D190", VA = "0x18645DD90", Slot = "6")]
		public void PJKJFLIKEBB(NFJEDPPAJMK OOGHONKGHEE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600036A")]
		[Cpp2IlInjected.Address(RVA = "0x6D6CD0", Offset = "0x6D60D0", VA = "0x1806D6CD0")]
		public RbexServiceCallbacks()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200003D")]
internal sealed class AMOJDPPGPLO : ABJBDNIKKNI, BBGIBEMMCOA
{
	[Cpp2IlInjected.Token(Token = "0x4000058")]
	public const int GKPFGIIGOEG = 10;

	[Cpp2IlInjected.Token(Token = "0x4000059")]
	public const float AAMHOIOCMGO = 9E-05f;

	[Cpp2IlInjected.Token(Token = "0x400005A")]
	public const float CLBDJGNMOIE = 0.0001f;

	[Cpp2IlInjected.Token(Token = "0x400005B")]
	public const float FBHPIPCOGEF = 5f;

	[Cpp2IlInjected.Token(Token = "0x170000E7")]
	private Rigidbody BAPEKECGLDP
	{
		[Cpp2IlInjected.Token(Token = "0x600036E")]
		[Cpp2IlInjected.Address(RVA = "0x545A560", Offset = "0x5459960", VA = "0x18545A560")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000E8")]
	private bool HCMEHANPHNC
	{
		[Cpp2IlInjected.Token(Token = "0x600036F")]
		[Cpp2IlInjected.Address(RVA = "0x54603A0", Offset = "0x545F7A0", VA = "0x1854603A0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000E9")]
	private bool NFEEOKFPIGD
	{
		[Cpp2IlInjected.Token(Token = "0x6000370")]
		[Cpp2IlInjected.Address(RVA = "0x545CB00", Offset = "0x545BF00", VA = "0x18545CB00")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000EA")]
	private PPMDIHPMNCG EMIBHNNCMJC
	{
		[Cpp2IlInjected.Token(Token = "0x6000371")]
		[Cpp2IlInjected.Address(RVA = "0x5460DE0", Offset = "0x54601E0", VA = "0x185460DE0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000EB")]
	private bool DKNFKPAFDPB
	{
		[Cpp2IlInjected.Token(Token = "0x6000372")]
		[Cpp2IlInjected.Address(RVA = "0x5460440", Offset = "0x545F840", VA = "0x185460440")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000EC")]
	private bool AOFOBFIMBNI
	{
		[Cpp2IlInjected.Token(Token = "0x6000373")]
		[Cpp2IlInjected.Address(RVA = "0x5460D00", Offset = "0x5460100", VA = "0x185460D00")]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000374")]
		[Cpp2IlInjected.Address(RVA = "0x5460060", Offset = "0x545F460", VA = "0x185460060")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000ED")]
	private bool KFFHFJIBMOK
	{
		[Cpp2IlInjected.Token(Token = "0x6000375")]
		[Cpp2IlInjected.Address(RVA = "0x54604A0", Offset = "0x545F8A0", VA = "0x1854604A0")]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000376")]
		[Cpp2IlInjected.Address(RVA = "0x5460E40", Offset = "0x5460240", VA = "0x185460E40")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000EE")]
	private int CGFCAIAMLJN
	{
		[Cpp2IlInjected.Token(Token = "0x6000377")]
		[Cpp2IlInjected.Address(RVA = "0x5460580", Offset = "0x545F980", VA = "0x185460580")]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000378")]
		[Cpp2IlInjected.Address(RVA = "0x5460660", Offset = "0x545FA60", VA = "0x185460660")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000037")]
	public event JPOFABMOGOF MLDKIENLGJG
	{
		[Cpp2IlInjected.Token(Token = "0x600036C")]
		[Cpp2IlInjected.Address(RVA = "0x5460790", Offset = "0x545FB90", VA = "0x185460790", Slot = "4")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600036D")]
		[Cpp2IlInjected.Address(RVA = "0x5460150", Offset = "0x545F550", VA = "0x185460150", Slot = "5")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000379")]
	[Cpp2IlInjected.Address(RVA = "0x5460F30", Offset = "0x5460330", VA = "0x185460F30")]
	public AMOJDPPGPLO(PPMDIHPMNCG LDDCANHDBNB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600037A")]
	[Cpp2IlInjected.Address(RVA = "0x545FFB0", Offset = "0x545F3B0", VA = "0x18545FFB0", Slot = "6")]
	public void BKOELLNKDDF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600037B")]
	[Cpp2IlInjected.Address(RVA = "0x545FFA0", Offset = "0x545F3A0", VA = "0x18545FFA0", Slot = "8")]
	public void ABJCFICOBMJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600037C")]
	[Cpp2IlInjected.Address(RVA = "0x5460990", Offset = "0x545FD90", VA = "0x185460990", Slot = "7")]
	public bool JLGKLAGDNBA()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600037D")]
	[Cpp2IlInjected.Address(RVA = "0x5460830", Offset = "0x545FC30", VA = "0x185460830", Slot = "9")]
	public void HFOIEEGNPME()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600037E")]
	[Cpp2IlInjected.Address(RVA = "0x5460750", Offset = "0x545FB50", VA = "0x185460750", Slot = "12")]
	public void GCGBBMHMBBI(bool DMEOICFENFA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600037F")]
	[Cpp2IlInjected.Address(RVA = "0x54608E0", Offset = "0x545FCE0", VA = "0x1854608E0", Slot = "11")]
	public void IPODHJMCCPD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000380")]
	[Cpp2IlInjected.Address(RVA = "0x6D7320", Offset = "0x6D6720", VA = "0x1806D7320", Slot = "10")]
	public void LHCKEPPOJKM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000381")]
	[Cpp2IlInjected.Address(RVA = "0x54601F0", Offset = "0x545F5F0", VA = "0x1854601F0")]
	private bool DBMAMKHOENP()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000382")]
	[Cpp2IlInjected.Address(RVA = "0x5460BB0", Offset = "0x545FFB0", VA = "0x185460BB0")]
	private void JOHNGPOIGFH()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200003E")]
internal sealed class BAODDNOCKIF : ABJBDNIKKNI, HONAINACCHA
{
	[Cpp2IlInjected.Token(Token = "0x400005D")]
	private const string MEJHJGGIKBM = "RBEX_ANIM";

	[Cpp2IlInjected.Token(Token = "0x170000EF")]
	public Rigidbody BAPEKECGLDP
	{
		[Cpp2IlInjected.Token(Token = "0x6000383")]
		[Cpp2IlInjected.Address(RVA = "0x54622D0", Offset = "0x54616D0", VA = "0x1854622D0", Slot = "4")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000384")]
		[Cpp2IlInjected.Address(RVA = "0x5461C60", Offset = "0x5461060", VA = "0x185461C60")]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000F0")]
	private bool DKNFKPAFDPB
	{
		[Cpp2IlInjected.Token(Token = "0x6000385")]
		[Cpp2IlInjected.Address(RVA = "0x54618A0", Offset = "0x5460CA0", VA = "0x1854618A0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000386")]
	[Cpp2IlInjected.Address(RVA = "0x54623B0", Offset = "0x54617B0", VA = "0x1854623B0")]
	public BAODDNOCKIF(PPMDIHPMNCG LDDCANHDBNB, in OALOFNDFAEL ONIBEFDCPGD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000387")]
	[Cpp2IlInjected.Address(RVA = "0x5461630", Offset = "0x5460A30", VA = "0x185461630", Slot = "5")]
	public void BKOELLNKDDF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000388")]
	[Cpp2IlInjected.Address(RVA = "0x5461F10", Offset = "0x5461310", VA = "0x185461F10", Slot = "6")]
	public void NMDKIGJCKAP(object AJDBKDIMOHA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000389")]
	[Cpp2IlInjected.Address(RVA = "0x5461B60", Offset = "0x5460F60", VA = "0x185461B60", Slot = "7")]
	public void IGIJDOMADBN(object AJDBKDIMOHA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600038A")]
	[Cpp2IlInjected.Address(RVA = "0x5462010", Offset = "0x5461410", VA = "0x185462010", Slot = "8")]
	public void OHCCCGHNBBD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600038B")]
	[Cpp2IlInjected.Address(RVA = "0x5461900", Offset = "0x5460D00", VA = "0x185461900", Slot = "9")]
	public void GGGGLIFJEPO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600038C")]
	[Cpp2IlInjected.Address(RVA = "0x5461460", Offset = "0x5460860", VA = "0x185461460", Slot = "10")]
	public void AELIAEFBMCN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600038D")]
	[Cpp2IlInjected.Address(RVA = "0x6D7320", Offset = "0x6D6720", VA = "0x1806D7320", Slot = "11")]
	public void JNJCHBBCJEP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600038E")]
	[Cpp2IlInjected.Address(RVA = "0x5461D50", Offset = "0x5461150", VA = "0x185461D50")]
	private void LCKBPKDNOGE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600038F")]
	[Cpp2IlInjected.Address(RVA = "0x54616E0", Offset = "0x5460AE0", VA = "0x1854616E0")]
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
		[Cpp2IlInjected.Token(Token = "0x6000390")]
		[Cpp2IlInjected.Address(RVA = "0x545C410", Offset = "0x545B810", VA = "0x18545C410", Slot = "4")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000391")]
		[Cpp2IlInjected.Address(RVA = "0x545CB20", Offset = "0x545BF20", VA = "0x18545CB20", Slot = "5")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000F2")]
	public FDHNJKMJJJG AEPCDANKKNF
	{
		[Cpp2IlInjected.Token(Token = "0x6000392")]
		[Cpp2IlInjected.Address(RVA = "0x545A880", Offset = "0x5459C80", VA = "0x18545A880", Slot = "6")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000393")]
		[Cpp2IlInjected.Address(RVA = "0x545BC90", Offset = "0x545B090", VA = "0x18545BC90", Slot = "7")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000F3")]
	public Vector3 MHCLHNEGJDD
	{
		[Cpp2IlInjected.Token(Token = "0x6000394")]
		[Cpp2IlInjected.Address(RVA = "0x545ACC0", Offset = "0x545A0C0", VA = "0x18545ACC0", Slot = "8")]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x6000395")]
		[Cpp2IlInjected.Address(RVA = "0x545C350", Offset = "0x545B750", VA = "0x18545C350", Slot = "9")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000F4")]
	public Vector3 JMJCCDADJPC
	{
		[Cpp2IlInjected.Token(Token = "0x6000396")]
		[Cpp2IlInjected.Address(RVA = "0x545CC10", Offset = "0x545C010", VA = "0x18545CC10", Slot = "10")]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x6000397")]
		[Cpp2IlInjected.Address(RVA = "0x545CFF0", Offset = "0x545C3F0", VA = "0x18545CFF0", Slot = "11")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000F5")]
	public Vector3 DLFBGEBKEHJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000398")]
		[Cpp2IlInjected.Address(RVA = "0x545C630", Offset = "0x545BA30", VA = "0x18545C630", Slot = "12")]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x6000399")]
		[Cpp2IlInjected.Address(RVA = "0x545D4E0", Offset = "0x545C8E0", VA = "0x18545D4E0", Slot = "13")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000F6")]
	public Vector3 KGONIIPAFMK
	{
		[Cpp2IlInjected.Token(Token = "0x600039A")]
		[Cpp2IlInjected.Address(RVA = "0x545D3C0", Offset = "0x545C7C0", VA = "0x18545D3C0", Slot = "14")]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x600039B")]
		[Cpp2IlInjected.Address(RVA = "0x545BC60", Offset = "0x545B060", VA = "0x18545BC60", Slot = "15")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000F7")]
	public float ENFIJFJPIPJ
	{
		[Cpp2IlInjected.Token(Token = "0x600039C")]
		[Cpp2IlInjected.Address(RVA = "0x545DB70", Offset = "0x545CF70", VA = "0x18545DB70", Slot = "16")]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x600039D")]
		[Cpp2IlInjected.Address(RVA = "0x545DD60", Offset = "0x545D160", VA = "0x18545DD60", Slot = "17")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000F8")]
	public bool OIAJDGKIDMB
	{
		[Cpp2IlInjected.Token(Token = "0x600039F")]
		[Cpp2IlInjected.Address(RVA = "0x545ABE0", Offset = "0x5459FE0", VA = "0x18545ABE0", Slot = "18")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000F9")]
	private FGHCKEELDLL MOEIJMAANIJ
	{
		[Cpp2IlInjected.Token(Token = "0x60003B3")]
		[Cpp2IlInjected.Address(RVA = "0x27F8760", Offset = "0x27F7B60", VA = "0x1827F8760")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000FA")]
	private bool NFEEOKFPIGD
	{
		[Cpp2IlInjected.Token(Token = "0x60003B4")]
		[Cpp2IlInjected.Address(RVA = "0x545CB00", Offset = "0x545BF00", VA = "0x18545CB00")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600039E")]
	[Cpp2IlInjected.Address(RVA = "0x5458EB0", Offset = "0x54582B0", VA = "0x185458EB0")]
	public AGGMOGOMGDO(PPMDIHPMNCG LDDCANHDBNB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003A0")]
	[Cpp2IlInjected.Address(RVA = "0x545C540", Offset = "0x545B940", VA = "0x18545C540", Slot = "20")]
	public void HHNPBMOKIFP(object AJDBKDIMOHA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003A1")]
	[Cpp2IlInjected.Address(RVA = "0x545D9C0", Offset = "0x545CDC0", VA = "0x18545D9C0", Slot = "31")]
	public void NFNEBKIHHFL(object AJDBKDIMOHA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003A2")]
	[Cpp2IlInjected.Address(RVA = "0x545A9B0", Offset = "0x5459DB0", VA = "0x18545A9B0", Slot = "19")]
	public void BKOELLNKDDF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003A3")]
	[Cpp2IlInjected.Address(RVA = "0x545B020", Offset = "0x545A420", VA = "0x18545B020", Slot = "37")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003A4")]
	[Cpp2IlInjected.Address(RVA = "0x545D250", Offset = "0x545C650", VA = "0x18545D250", Slot = "28")]
	public void JPMOLDGLNJO(Rigidbody AOAFHPHKFMD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003A5")]
	[Cpp2IlInjected.Address(RVA = "0x545B150", Offset = "0x545A550", VA = "0x18545B150", Slot = "36")]
	public Vector3 EAJIEBJEBJP(Vector3 ODPCODBLNJO)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x60003A6")]
	[Cpp2IlInjected.Address(RVA = "0x545CE30", Offset = "0x545C230", VA = "0x18545CE30", Slot = "35")]
	public Vector3 JGGPKLHDPOC(Vector3 DLOMDLEMEJO)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x60003A7")]
	[Cpp2IlInjected.Address(RVA = "0x545A9B0", Offset = "0x5459DB0", VA = "0x18545A9B0", Slot = "27")]
	public void LNGHCMNGELC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003A8")]
	[Cpp2IlInjected.Address(RVA = "0x545AFE0", Offset = "0x545A3E0", VA = "0x18545AFE0", Slot = "25")]
	public void DGADOFDPFDE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003A9")]
	[Cpp2IlInjected.Address(RVA = "0x545CAC0", Offset = "0x545BEC0", VA = "0x18545CAC0", Slot = "24")]
	public void IBIENENFOLO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003AA")]
	[Cpp2IlInjected.Address(RVA = "0x545B330", Offset = "0x545A730", VA = "0x18545B330", Slot = "34")]
	public void EEIOJCMLKKL(Vector3 PKEOGDHOABC, Vector3 GNHLNIEHAFA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003AB")]
	[Cpp2IlInjected.Address(RVA = "0x545AA20", Offset = "0x5459E20", VA = "0x18545AA20", Slot = "33")]
	public void BNKAMLPDNDH(Vector3 IHHIJIKHHIA, Vector3 NBGIHKDGDID)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003AC")]
	[Cpp2IlInjected.Address(RVA = "0x545AA80", Offset = "0x5459E80", VA = "0x18545AA80", Slot = "32")]
	public void CADMMMANGFL(Vector3 GJKLLEKAGBH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003AD")]
	[Cpp2IlInjected.Address(RVA = "0x545BEE0", Offset = "0x545B2E0", VA = "0x18545BEE0", Slot = "22")]
	public void GOHOEPELEBG(CBPMCKPIBHC EIOPEGEMKHP, Vector3 DKCLOLGBADH, float OOKLCGCBAJI, float LLKLELEIBGC = 8f, float AEEFHMKEOAH = 1f)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003AE")]
	[Cpp2IlInjected.Address(RVA = "0x545D020", Offset = "0x545C420", VA = "0x18545D020", Slot = "21")]
	public void JLNINMHMEHA(BOPFIFMMKBG BPDOBLBNKEN, Vector3 NLFAAHHHDNN, float HHHNHCMFNFA = float.PositiveInfinity)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003AF")]
	[Cpp2IlInjected.Address(RVA = "0x545A5B0", Offset = "0x54599B0", VA = "0x18545A5B0", Slot = "23")]
	[Obsolete]
	public void ADCBOLCDFHD(BOPFIFMMKBG BPDOBLBNKEN, Vector3 MCFIHGJCDCP, float BDCHAJELIHL = 7f, float ABPPGEHGCFI = 1f)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003B0")]
	[Cpp2IlInjected.Address(RVA = "0x545D900", Offset = "0x545CD00", VA = "0x18545D900", Slot = "30")]
	public Vector3 KPFDHGBBOFB(Vector3 BNEEGIEDHBB)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x60003B1")]
	[Cpp2IlInjected.Address(RVA = "0x545BB70", Offset = "0x545AF70", VA = "0x18545BB70", Slot = "29")]
	public Vector3 FHKEINJELIE(Vector3 IMJEKHOJGKC)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x60003B2")]
	[Cpp2IlInjected.Address(RVA = "0x545D290", Offset = "0x545C690", VA = "0x18545D290", Slot = "26")]
	public void KDDHFACBKGB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003B5")]
	[Cpp2IlInjected.Address(RVA = "0x545AE10", Offset = "0x545A210", VA = "0x18545AE10")]
	private void CJOOFKCBJCD(float JFBPNBNBHOE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003B6")]
	[Cpp2IlInjected.Address(RVA = "0x545BD80", Offset = "0x545B180", VA = "0x18545BD80")]
	private void GEOKOCNAGLK(Vector3 NLFAAHHHDNN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003B7")]
	[Cpp2IlInjected.Address(RVA = "0x545DC50", Offset = "0x545D050", VA = "0x18545DC50")]
	private Vector3 PAHNCPJEPIJ()
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x60003B8")]
	[Cpp2IlInjected.Address(RVA = "0x545C780", Offset = "0x545BB80", VA = "0x18545C780")]
	private void HMLBCCHCNID(Vector3 DLOMDLEMEJO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003B9")]
	[Cpp2IlInjected.Address(RVA = "0x545CD20", Offset = "0x545C120", VA = "0x18545CD20")]
	private Vector3 JFACHOANBJO()
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x60003BA")]
	[Cpp2IlInjected.Address(RVA = "0x545D5A0", Offset = "0x545C9A0", VA = "0x18545D5A0")]
	private void KPADOHKNGPN(Vector3 JFBPNBNBHOE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003BB")]
	[Cpp2IlInjected.Address(RVA = "0x545B570", Offset = "0x545A970", VA = "0x18545B570")]
	private void EFAJHPCILNA(Vector3 DLOMDLEMEJO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003BC")]
	[Cpp2IlInjected.Address(RVA = "0x545DAB0", Offset = "0x545CEB0", VA = "0x18545DAB0")]
	private void NGKMKMAACHI()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000040")]
internal class ABJBDNIKKNI
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400005E")]
	protected readonly LKOIEBFOHCO LDDCANHDBNB;

	[Cpp2IlInjected.Token(Token = "0x170000FB")]
	protected MCAEHJPOCLP GMLNDICHODE
	{
		[Cpp2IlInjected.Token(Token = "0x60003BD")]
		[Cpp2IlInjected.Address(RVA = "0x13D30E0", Offset = "0x13D24E0", VA = "0x1813D30E0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000FC")]
	protected NFJEDPPAJMK KPJMLJDCDIG
	{
		[Cpp2IlInjected.Token(Token = "0x60003BE")]
		[Cpp2IlInjected.Address(RVA = "0x5459050", Offset = "0x5458450", VA = "0x185459050")]
		get
		{
			return default(NFJEDPPAJMK);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60003BF")]
	[Cpp2IlInjected.Address(RVA = "0x5458EB0", Offset = "0x54582B0", VA = "0x185458EB0")]
	public ABJBDNIKKNI(PPMDIHPMNCG LDDCANHDBNB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003C0")]
	[Cpp2IlInjected.Address(RVA = "0x5458F30", Offset = "0x5458330", VA = "0x185458F30")]
	protected PPMDIHPMNCG GGKEECHPPDD(NFJEDPPAJMK ONBAMHPEIDG)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000041")]
public class CFLCLECANAB : KMBOJHAPLLI
{
	[Cpp2IlInjected.Token(Token = "0x60003C1")]
	[Cpp2IlInjected.Address(RVA = "0x5463CD0", Offset = "0x54630D0", VA = "0x185463CD0", Slot = "4")]
	public HMOOAGCGLKM MJLNOLDLKOJ(PPMDIHPMNCG ONJEPBGIHBB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003C2")]
	[Cpp2IlInjected.Address(RVA = "0x5463E40", Offset = "0x5463240", VA = "0x185463E40", Slot = "5")]
	public MPILPIJAHDO MOHHJJFOLBM(PPMDIHPMNCG ONJEPBGIHBB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003C3")]
	[Cpp2IlInjected.Address(RVA = "0x5463AC0", Offset = "0x5462EC0", VA = "0x185463AC0", Slot = "6")]
	public NPFLLLAFPDM IMEKOCFODBG(PPMDIHPMNCG ONJEPBGIHBB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003C4")]
	[Cpp2IlInjected.Address(RVA = "0x5463900", Offset = "0x5462D00", VA = "0x185463900", Slot = "7")]
	public KKCAAHMNCAO HEDEOJGLLAC(PPMDIHPMNCG ONJEPBGIHBB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003C5")]
	[Cpp2IlInjected.Address(RVA = "0x5463C00", Offset = "0x5463000", VA = "0x185463C00", Slot = "8")]
	public BBGIBEMMCOA JNPIPKPJGAO(PPMDIHPMNCG ONJEPBGIHBB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003C6")]
	[Cpp2IlInjected.Address(RVA = "0x54639A0", Offset = "0x5462DA0", VA = "0x1854639A0", Slot = "9")]
	public ODGCKIECBJN HEMHCEJPPBH(PPMDIHPMNCG ONJEPBGIHBB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003C7")]
	[Cpp2IlInjected.Address(RVA = "0x5463750", Offset = "0x5462B50", VA = "0x185463750", Slot = "10")]
	public GAMBABDLKNB GBHLIFIGFGO(PPMDIHPMNCG ONJEPBGIHBB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003C8")]
	[Cpp2IlInjected.Address(RVA = "0x5463860", Offset = "0x5462C60", VA = "0x185463860", Slot = "11")]
	public FGHCKEELDLL HDCLGAJOJOG(PPMDIHPMNCG ONJEPBGIHBB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003C9")]
	[Cpp2IlInjected.Address(RVA = "0x54633B0", Offset = "0x54627B0", VA = "0x1854633B0", Slot = "12")]
	public APGGGIKOMPN AJBLCMCEIMG(PPMDIHPMNCG ONJEPBGIHBB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003CA")]
	[Cpp2IlInjected.Address(RVA = "0x5463B60", Offset = "0x5462F60", VA = "0x185463B60", Slot = "13")]
	public LMMEICEFKMM JIMOFCMOFGN(PPMDIHPMNCG ONJEPBGIHBB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003CB")]
	[Cpp2IlInjected.Address(RVA = "0x5463690", Offset = "0x5462A90", VA = "0x185463690")]
	public HONAINACCHA EPFJODDPHNJ(PPMDIHPMNCG ONJEPBGIHBB, in OALOFNDFAEL ONIBEFDCPGD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003CC")]
	[Cpp2IlInjected.Address(RVA = "0x5463A00", Offset = "0x5462E00", VA = "0x185463A00")]
	public LNJFNCEGNCA IMOGAPPPDNI(PPMDIHPMNCG ONJEPBGIHBB, in OALOFNDFAEL ONIBEFDCPGD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003CD")]
	[Cpp2IlInjected.Address(RVA = "0x5463450", Offset = "0x5462850", VA = "0x185463450")]
	public EBCDLOKEBCP MEDAGDCIAAG(PPMDIHPMNCG ONJEPBGIHBB, in OALOFNDFAEL ONIBEFDCPGD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003CE")]
	[Cpp2IlInjected.Address(RVA = "0x5463C60", Offset = "0x5463060", VA = "0x185463C60")]
	public HEFJBMMENIM PIKOPGMPFFO(PPMDIHPMNCG ONJEPBGIHBB, in OALOFNDFAEL ONIBEFDCPGD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003CF")]
	[Cpp2IlInjected.Address(RVA = "0x54637F0", Offset = "0x5462BF0", VA = "0x1854637F0")]
	public OIAJBEDDNGM NOELAMDCDMI(PPMDIHPMNCG ONJEPBGIHBB, in OALOFNDFAEL ONIBEFDCPGD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003D0")]
	[Cpp2IlInjected.Address(RVA = "0x54635E0", Offset = "0x54629E0", VA = "0x1854635E0", Slot = "19")]
	public PPMDIHPMNCG EHCIKDFINKO(RigidbodyEx LDDCANHDBNB, OALOFNDFAEL ONIBEFDCPGD, CMKMIKBKOHM OBOKKBNADPB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003D1")]
	[Cpp2IlInjected.Address(RVA = "0x6D6CD0", Offset = "0x6D60D0", VA = "0x1806D6CD0")]
	public CFLCLECANAB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003D2")]
	[Cpp2IlInjected.Address(RVA = "0x5463690", Offset = "0x5462A90", VA = "0x185463690", Slot = "14")]
	private HONAINACCHA GIPLMECOEDJ(PPMDIHPMNCG ONJEPBGIHBB, in OALOFNDFAEL ONIBEFDCPGD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003D3")]
	[Cpp2IlInjected.Address(RVA = "0x5463A00", Offset = "0x5462E00", VA = "0x185463A00", Slot = "15")]
	private LNJFNCEGNCA HOCCJMCGJPK(PPMDIHPMNCG ONJEPBGIHBB, in OALOFNDFAEL ONIBEFDCPGD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003D4")]
	[Cpp2IlInjected.Address(RVA = "0x5463450", Offset = "0x5462850", VA = "0x185463450", Slot = "16")]
	private EBCDLOKEBCP DDDDJCAAJFM(PPMDIHPMNCG ONJEPBGIHBB, in OALOFNDFAEL ONIBEFDCPGD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003D5")]
	[Cpp2IlInjected.Address(RVA = "0x5463C60", Offset = "0x5463060", VA = "0x185463C60", Slot = "17")]
	private HEFJBMMENIM KPKGPEKIGJD(PPMDIHPMNCG ONJEPBGIHBB, in OALOFNDFAEL ONIBEFDCPGD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003D6")]
	[Cpp2IlInjected.Address(RVA = "0x54637F0", Offset = "0x5462BF0", VA = "0x1854637F0", Slot = "18")]
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
	[Cpp2IlInjected.Token(Token = "0x400005F")]
	public readonly NFJEDPPAJMK ONBAMHPEIDG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000060")]
	public readonly MCAEHJPOCLP IAFMOECNDHE;

	[Cpp2IlInjected.Token(Token = "0x170000FD")]
	public int HGPJFHAOHMD
	{
		[Cpp2IlInjected.Token(Token = "0x60003DA")]
		[Cpp2IlInjected.Address(RVA = "0x54805F0", Offset = "0x547F9F0", VA = "0x1854805F0", Slot = "5")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000FE")]
	public PPMDIHPMNCG OMKECOOHJIM
	{
		[Cpp2IlInjected.Token(Token = "0x60003DB")]
		[Cpp2IlInjected.Address(RVA = "0x54806C0", Offset = "0x547FAC0", VA = "0x1854806C0", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60003D7")]
	[Cpp2IlInjected.Address(RVA = "0x54805A0", Offset = "0x547F9A0", VA = "0x1854805A0")]
	public OBDJKKFDJOF(NFJEDPPAJMK ONBAMHPEIDG, MCAEHJPOCLP IAFMOECNDHE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003D8")]
	[Cpp2IlInjected.Address(RVA = "0x5480410", Offset = "0x547F810", VA = "0x185480410", Slot = "6")]
	public IEnumerator<PPMDIHPMNCG> GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003D9")]
	[Cpp2IlInjected.Address(RVA = "0x5480410", Offset = "0x547F810", VA = "0x185480410", Slot = "7")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003DC")]
	[Cpp2IlInjected.Address(RVA = "0x5480400", Offset = "0x547F800", VA = "0x185480400")]
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
	[Cpp2IlInjected.Token(Token = "0x4000061")]
	private readonly KMBOJHAPLLI CGMBPAFJDKL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000062")]
	private readonly KMBOJHAPLLI CCPHBLENGBG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000063")]
	private AKKPACBLFCH ONMGKKCFHAK;

	[Cpp2IlInjected.Token(Token = "0x170000FF")]
	private KMBOJHAPLLI AJPHGKGIGMH
	{
		[Cpp2IlInjected.Token(Token = "0x60003DE")]
		[Cpp2IlInjected.Address(RVA = "0x545ED80", Offset = "0x545E180", VA = "0x18545ED80")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60003DD")]
	[Cpp2IlInjected.Address(RVA = "0x545F110", Offset = "0x545E510", VA = "0x18545F110", Slot = "20")]
	public void PEIMLKLDOFJ(JHLNNPKIFCO KOKEGENGCAH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003DF")]
	[Cpp2IlInjected.Address(RVA = "0x545EFD0", Offset = "0x545E3D0", VA = "0x18545EFD0", Slot = "4")]
	public HMOOAGCGLKM MJLNOLDLKOJ(PPMDIHPMNCG ONJEPBGIHBB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003E0")]
	[Cpp2IlInjected.Address(RVA = "0x545F070", Offset = "0x545E470", VA = "0x18545F070", Slot = "5")]
	public MPILPIJAHDO MOHHJJFOLBM(PPMDIHPMNCG ONJEPBGIHBB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003E1")]
	[Cpp2IlInjected.Address(RVA = "0x545ECE0", Offset = "0x545E0E0", VA = "0x18545ECE0", Slot = "6")]
	public NPFLLLAFPDM IMEKOCFODBG(PPMDIHPMNCG ONJEPBGIHBB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003E2")]
	[Cpp2IlInjected.Address(RVA = "0x545EAF0", Offset = "0x545DEF0", VA = "0x18545EAF0", Slot = "7")]
	public KKCAAHMNCAO HEDEOJGLLAC(PPMDIHPMNCG ONJEPBGIHBB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003E3")]
	[Cpp2IlInjected.Address(RVA = "0x545EE80", Offset = "0x545E280", VA = "0x18545EE80", Slot = "8")]
	public BBGIBEMMCOA JNPIPKPJGAO(PPMDIHPMNCG ONJEPBGIHBB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003E4")]
	[Cpp2IlInjected.Address(RVA = "0x545EB90", Offset = "0x545DF90", VA = "0x18545EB90", Slot = "9")]
	public ODGCKIECBJN HEMHCEJPPBH(PPMDIHPMNCG ONJEPBGIHBB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003E5")]
	[Cpp2IlInjected.Address(RVA = "0x545E900", Offset = "0x545DD00", VA = "0x18545E900", Slot = "10")]
	public GAMBABDLKNB GBHLIFIGFGO(PPMDIHPMNCG ONJEPBGIHBB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003E6")]
	[Cpp2IlInjected.Address(RVA = "0x545EA50", Offset = "0x545DE50", VA = "0x18545EA50", Slot = "11")]
	public FGHCKEELDLL HDCLGAJOJOG(PPMDIHPMNCG ONJEPBGIHBB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003E7")]
	[Cpp2IlInjected.Address(RVA = "0x545E610", Offset = "0x545DA10", VA = "0x18545E610", Slot = "12")]
	public APGGGIKOMPN AJBLCMCEIMG(PPMDIHPMNCG ONJEPBGIHBB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003E8")]
	[Cpp2IlInjected.Address(RVA = "0x545EDE0", Offset = "0x545E1E0", VA = "0x18545EDE0", Slot = "13")]
	public LMMEICEFKMM JIMOFCMOFGN(PPMDIHPMNCG ONJEPBGIHBB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003E9")]
	[Cpp2IlInjected.Address(RVA = "0x545E850", Offset = "0x545DC50", VA = "0x18545E850")]
	public HONAINACCHA EPFJODDPHNJ(PPMDIHPMNCG ONJEPBGIHBB, in OALOFNDFAEL ONIBEFDCPGD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003EA")]
	[Cpp2IlInjected.Address(RVA = "0x545EC30", Offset = "0x545E030", VA = "0x18545EC30")]
	public LNJFNCEGNCA IMOGAPPPDNI(PPMDIHPMNCG ONJEPBGIHBB, in OALOFNDFAEL ONIBEFDCPGD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003EB")]
	[Cpp2IlInjected.Address(RVA = "0x545E6B0", Offset = "0x545DAB0", VA = "0x18545E6B0")]
	public EBCDLOKEBCP MEDAGDCIAAG(PPMDIHPMNCG ONJEPBGIHBB, in OALOFNDFAEL ONIBEFDCPGD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003EC")]
	[Cpp2IlInjected.Address(RVA = "0x545EF20", Offset = "0x545E320", VA = "0x18545EF20")]
	public HEFJBMMENIM PIKOPGMPFFO(PPMDIHPMNCG ONJEPBGIHBB, in OALOFNDFAEL ONIBEFDCPGD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003ED")]
	[Cpp2IlInjected.Address(RVA = "0x545E9A0", Offset = "0x545DDA0", VA = "0x18545E9A0")]
	public OIAJBEDDNGM NOELAMDCDMI(PPMDIHPMNCG ONJEPBGIHBB, in OALOFNDFAEL ONIBEFDCPGD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003EE")]
	[Cpp2IlInjected.Address(RVA = "0x545E760", Offset = "0x545DB60", VA = "0x18545E760", Slot = "19")]
	public PPMDIHPMNCG EHCIKDFINKO(RigidbodyEx LDDCANHDBNB, OALOFNDFAEL ONIBEFDCPGD, CMKMIKBKOHM OBOKKBNADPB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003EF")]
	[Cpp2IlInjected.Address(RVA = "0x545F160", Offset = "0x545E560", VA = "0x18545F160")]
	public AHJLCDEOIEK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003F0")]
	[Cpp2IlInjected.Address(RVA = "0x545E850", Offset = "0x545DC50", VA = "0x18545E850", Slot = "14")]
	private HONAINACCHA GIPLMECOEDJ(PPMDIHPMNCG ONJEPBGIHBB, in OALOFNDFAEL ONIBEFDCPGD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003F1")]
	[Cpp2IlInjected.Address(RVA = "0x545EC30", Offset = "0x545E030", VA = "0x18545EC30", Slot = "15")]
	private LNJFNCEGNCA HOCCJMCGJPK(PPMDIHPMNCG ONJEPBGIHBB, in OALOFNDFAEL ONIBEFDCPGD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003F2")]
	[Cpp2IlInjected.Address(RVA = "0x545E6B0", Offset = "0x545DAB0", VA = "0x18545E6B0", Slot = "16")]
	private EBCDLOKEBCP DDDDJCAAJFM(PPMDIHPMNCG ONJEPBGIHBB, in OALOFNDFAEL ONIBEFDCPGD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003F3")]
	[Cpp2IlInjected.Address(RVA = "0x545EF20", Offset = "0x545E320", VA = "0x18545EF20", Slot = "17")]
	private HEFJBMMENIM KPKGPEKIGJD(PPMDIHPMNCG ONJEPBGIHBB, in OALOFNDFAEL ONIBEFDCPGD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003F4")]
	[Cpp2IlInjected.Address(RVA = "0x545E9A0", Offset = "0x545DDA0", VA = "0x18545E9A0", Slot = "18")]
	private OIAJBEDDNGM GLMHIKFJOJB(PPMDIHPMNCG ONJEPBGIHBB, in OALOFNDFAEL ONIBEFDCPGD)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000044")]
[Preserve]
public sealed class PEMCFGMEGMC : PPMDIHPMNCG, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x4000064")]
	public static readonly PEMCFGMEGMC HNEIEBONIJN;

	[Cpp2IlInjected.Token(Token = "0x17000100")]
	public Rigidbody BAPEKECGLDP
	{
		[Cpp2IlInjected.Token(Token = "0x6000407")]
		[Cpp2IlInjected.Address(RVA = "0x6E1E40", Offset = "0x6E1240", VA = "0x1806E1E40", Slot = "4")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000101")]
	public RigidbodyEx JKIDPKKAFKH
	{
		[Cpp2IlInjected.Token(Token = "0x6000408")]
		[Cpp2IlInjected.Address(RVA = "0x6E4140", Offset = "0x6E3540", VA = "0x1806E4140", Slot = "5")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000102")]
	public GameObject MNGKPNJJMOC
	{
		[Cpp2IlInjected.Token(Token = "0x6000409")]
		[Cpp2IlInjected.Address(RVA = "0x6E4130", Offset = "0x6E3530", VA = "0x1806E4130", Slot = "6")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000103")]
	public Transform LNPNGFHHEEL
	{
		[Cpp2IlInjected.Token(Token = "0x600040A")]
		[Cpp2IlInjected.Address(RVA = "0x6E42D0", Offset = "0x6E36D0", VA = "0x1806E42D0", Slot = "7")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000104")]
	public IEnumerable<object> JNIPNMIKJIN
	{
		[Cpp2IlInjected.Token(Token = "0x600040B")]
		[Cpp2IlInjected.Address(RVA = "0x702560", Offset = "0x701960", VA = "0x180702560", Slot = "8")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000105")]
	public PPMDIHPMNCG EMIBHNNCMJC
	{
		[Cpp2IlInjected.Token(Token = "0x600040C")]
		[Cpp2IlInjected.Address(RVA = "0x6E0E70", Offset = "0x6E0270", VA = "0x1806E0E70", Slot = "9")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600040D")]
		[Cpp2IlInjected.Address(RVA = "0x6E1830", Offset = "0x6E0C30", VA = "0x1806E1830", Slot = "10")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000106")]
	public IReadOnlyList<PPMDIHPMNCG> LILCAAEDFCG
	{
		[Cpp2IlInjected.Token(Token = "0x600040E")]
		[Cpp2IlInjected.Address(RVA = "0x6E4150", Offset = "0x6E3550", VA = "0x1806E4150", Slot = "11")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000107")]
	public PPMDIHPMNCG MDHMHFAIMJJ
	{
		[Cpp2IlInjected.Token(Token = "0x600040F")]
		[Cpp2IlInjected.Address(RVA = "0x6E79C0", Offset = "0x6E6DC0", VA = "0x1806E79C0", Slot = "12")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000108")]
	public bool DKNFKPAFDPB
	{
		[Cpp2IlInjected.Token(Token = "0x6000410")]
		[Cpp2IlInjected.Address(RVA = "0x7BE830", Offset = "0x7BDC30", VA = "0x1807BE830", Slot = "13")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000109")]
	public bool PJPIAHDKHLD
	{
		[Cpp2IlInjected.Token(Token = "0x6000411")]
		[Cpp2IlInjected.Address(RVA = "0x1081BE0", Offset = "0x1080FE0", VA = "0x181081BE0", Slot = "14")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700010A")]
	public bool EMGPBBGPGIE
	{
		[Cpp2IlInjected.Token(Token = "0x6000412")]
		[Cpp2IlInjected.Address(RVA = "0xF55D20", Offset = "0xF55120", VA = "0x180F55D20", Slot = "15")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700010B")]
	public LKKOPIEOHJA OLDOEMJHCAC
	{
		[Cpp2IlInjected.Token(Token = "0x6000413")]
		[Cpp2IlInjected.Address(RVA = "0x77F5A0", Offset = "0x77E9A0", VA = "0x18077F5A0", Slot = "16")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000414")]
		[Cpp2IlInjected.Address(RVA = "0x83DD10", Offset = "0x83D110", VA = "0x18083DD10", Slot = "17")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700010C")]
	public FDHNJKMJJJG AEPCDANKKNF
	{
		[Cpp2IlInjected.Token(Token = "0x6000415")]
		[Cpp2IlInjected.Address(RVA = "0x77D5F0", Offset = "0x77C9F0", VA = "0x18077D5F0", Slot = "18")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000416")]
		[Cpp2IlInjected.Address(RVA = "0x706290", Offset = "0x705690", VA = "0x180706290", Slot = "19")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700010D")]
	public float ENFIJFJPIPJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000417")]
		[Cpp2IlInjected.Address(RVA = "0x1AB7060", Offset = "0x1AB6460", VA = "0x181AB7060", Slot = "20")]
		[CompilerGenerated]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x6000418")]
		[Cpp2IlInjected.Address(RVA = "0x14CEB00", Offset = "0x14CDF00", VA = "0x1814CEB00", Slot = "21")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700010E")]
	public Vector3 JMJCCDADJPC
	{
		[Cpp2IlInjected.Token(Token = "0x6000419")]
		[Cpp2IlInjected.Address(RVA = "0x408B550", Offset = "0x408A950", VA = "0x18408B550", Slot = "22")]
		[CompilerGenerated]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x600041A")]
		[Cpp2IlInjected.Address(RVA = "0x408D510", Offset = "0x408C910", VA = "0x18408D510", Slot = "23")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700010F")]
	public Vector3 KGONIIPAFMK
	{
		[Cpp2IlInjected.Token(Token = "0x600041B")]
		[Cpp2IlInjected.Address(RVA = "0x2831720", Offset = "0x2830B20", VA = "0x182831720", Slot = "24")]
		[CompilerGenerated]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x600041C")]
		[Cpp2IlInjected.Address(RVA = "0x282CB90", Offset = "0x282BF90", VA = "0x18282CB90", Slot = "25")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000110")]
	public Vector3 MHCLHNEGJDD
	{
		[Cpp2IlInjected.Token(Token = "0x600041D")]
		[Cpp2IlInjected.Address(RVA = "0x2831740", Offset = "0x2830B40", VA = "0x182831740", Slot = "26")]
		[CompilerGenerated]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x600041E")]
		[Cpp2IlInjected.Address(RVA = "0x282E170", Offset = "0x282D570", VA = "0x18282E170", Slot = "27")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000111")]
	public Vector3 DLFBGEBKEHJ
	{
		[Cpp2IlInjected.Token(Token = "0x600041F")]
		[Cpp2IlInjected.Address(RVA = "0x1456DF0", Offset = "0x14561F0", VA = "0x181456DF0", Slot = "28")]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x6000420")]
		[Cpp2IlInjected.Address(RVA = "0x6D7320", Offset = "0x6D6720", VA = "0x1806D7320", Slot = "29")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000112")]
	public bool AMMPJIIANJD
	{
		[Cpp2IlInjected.Token(Token = "0x6000421")]
		[Cpp2IlInjected.Address(RVA = "0xC7CFD0", Offset = "0xC7C3D0", VA = "0x180C7CFD0", Slot = "30")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000113")]
	public bool OONHJPFBNAB
	{
		[Cpp2IlInjected.Token(Token = "0x6000422")]
		[Cpp2IlInjected.Address(RVA = "0xC7CFE0", Offset = "0xC7C3E0", VA = "0x180C7CFE0", Slot = "31")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000114")]
	public bool AKAANNKOEAC
	{
		[Cpp2IlInjected.Token(Token = "0x6000423")]
		[Cpp2IlInjected.Address(RVA = "0xC7CFC0", Offset = "0xC7C3C0", VA = "0x180C7CFC0", Slot = "32")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000115")]
	public bool OIAJDGKIDMB
	{
		[Cpp2IlInjected.Token(Token = "0x6000424")]
		[Cpp2IlInjected.Address(RVA = "0x1188F10", Offset = "0x1188310", VA = "0x181188F10", Slot = "33")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000116")]
	public Vector3 DJHICJGOGJI
	{
		[Cpp2IlInjected.Token(Token = "0x6000425")]
		[Cpp2IlInjected.Address(RVA = "0x1255000", Offset = "0x1254400", VA = "0x181255000", Slot = "34")]
		[CompilerGenerated]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000117")]
	public Vector3 EOFHLAGNPII
	{
		[Cpp2IlInjected.Token(Token = "0x6000426")]
		[Cpp2IlInjected.Address(RVA = "0x12BB6C0", Offset = "0x12BAAC0", VA = "0x1812BB6C0", Slot = "35")]
		[CompilerGenerated]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000118")]
	public Vector3 JMIIJDMAMEI
	{
		[Cpp2IlInjected.Token(Token = "0x6000427")]
		[Cpp2IlInjected.Address(RVA = "0x1456DF0", Offset = "0x14561F0", VA = "0x181456DF0", Slot = "36")]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x6000428")]
		[Cpp2IlInjected.Address(RVA = "0x6D7320", Offset = "0x6D6720", VA = "0x1806D7320", Slot = "37")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000119")]
	public Vector3 PMKFGPJNJBI
	{
		[Cpp2IlInjected.Token(Token = "0x6000429")]
		[Cpp2IlInjected.Address(RVA = "0x2831800", Offset = "0x2830C00", VA = "0x182831800", Slot = "38")]
		[CompilerGenerated]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700011A")]
	public float KLNDCEHFMBA
	{
		[Cpp2IlInjected.Token(Token = "0x600042A")]
		[Cpp2IlInjected.Address(RVA = "0x3740940", Offset = "0x373FD40", VA = "0x183740940", Slot = "39")]
		[CompilerGenerated]
		get
		{
			return default(float);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700011B")]
	public float NBJLLACMBLF
	{
		[Cpp2IlInjected.Token(Token = "0x600042B")]
		[Cpp2IlInjected.Address(RVA = "0x8A7F90", Offset = "0x8A7390", VA = "0x1808A7F90", Slot = "40")]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x600042C")]
		[Cpp2IlInjected.Address(RVA = "0x6D7320", Offset = "0x6D6720", VA = "0x1806D7320", Slot = "41")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700011C")]
	public Vector3 OFFHJCCLOEB
	{
		[Cpp2IlInjected.Token(Token = "0x600042D")]
		[Cpp2IlInjected.Address(RVA = "0x1456DF0", Offset = "0x14561F0", VA = "0x181456DF0", Slot = "42")]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x600042E")]
		[Cpp2IlInjected.Address(RVA = "0x6D7320", Offset = "0x6D6720", VA = "0x1806D7320", Slot = "43")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700011D")]
	public Quaternion MOMBOPJMDMK
	{
		[Cpp2IlInjected.Token(Token = "0x600042F")]
		[Cpp2IlInjected.Address(RVA = "0x7B2A60", Offset = "0x7B1E60", VA = "0x1807B2A60", Slot = "44")]
		get
		{
			return default(Quaternion);
		}
		[Cpp2IlInjected.Token(Token = "0x6000430")]
		[Cpp2IlInjected.Address(RVA = "0x6D7320", Offset = "0x6D6720", VA = "0x1806D7320", Slot = "45")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700011E")]
	public float FCGOFCPMIGL
	{
		[Cpp2IlInjected.Token(Token = "0x6000431")]
		[Cpp2IlInjected.Address(RVA = "0x8A7F90", Offset = "0x8A7390", VA = "0x1808A7F90", Slot = "46")]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x6000432")]
		[Cpp2IlInjected.Address(RVA = "0x6D7320", Offset = "0x6D6720", VA = "0x1806D7320", Slot = "47")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700011F")]
	public float CFMIJLIHCIE
	{
		[Cpp2IlInjected.Token(Token = "0x6000433")]
		[Cpp2IlInjected.Address(RVA = "0x8A7F90", Offset = "0x8A7390", VA = "0x1808A7F90", Slot = "48")]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x6000434")]
		[Cpp2IlInjected.Address(RVA = "0x6D7320", Offset = "0x6D6720", VA = "0x1806D7320", Slot = "49")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000120")]
	public bool HLADCICNJBO
	{
		[Cpp2IlInjected.Token(Token = "0x6000435")]
		[Cpp2IlInjected.Address(RVA = "0x6F98E0", Offset = "0x6F8CE0", VA = "0x1806F98E0", Slot = "50")]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000436")]
		[Cpp2IlInjected.Address(RVA = "0x6D7320", Offset = "0x6D6720", VA = "0x1806D7320", Slot = "51")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000121")]
	public bool GENHOBGEJGK
	{
		[Cpp2IlInjected.Token(Token = "0x6000437")]
		[Cpp2IlInjected.Address(RVA = "0x6F98E0", Offset = "0x6F8CE0", VA = "0x1806F98E0")]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000438")]
		[Cpp2IlInjected.Address(RVA = "0x6D7320", Offset = "0x6D6720", VA = "0x1806D7320")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000122")]
	public PPGNAFCKNOL NHFAJHMDKMA
	{
		[Cpp2IlInjected.Token(Token = "0x6000439")]
		[Cpp2IlInjected.Address(RVA = "0x6F98E0", Offset = "0x6F8CE0", VA = "0x1806F98E0", Slot = "52")]
		get
		{
			return default(PPGNAFCKNOL);
		}
		[Cpp2IlInjected.Token(Token = "0x600043A")]
		[Cpp2IlInjected.Address(RVA = "0x6D7320", Offset = "0x6D6720", VA = "0x1806D7320", Slot = "53")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000123")]
	public bool MBEHMAPDJBJ
	{
		[Cpp2IlInjected.Token(Token = "0x600043B")]
		[Cpp2IlInjected.Address(RVA = "0x2CA6B30", Offset = "0x2CA5F30", VA = "0x182CA6B30", Slot = "54")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000124")]
	public Transform PDLNBKLCFJO
	{
		[Cpp2IlInjected.Token(Token = "0x600043C")]
		[Cpp2IlInjected.Address(RVA = "0x702380", Offset = "0x701780", VA = "0x180702380", Slot = "55")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000125")]
	public Transform IPOOCBGBBCA
	{
		[Cpp2IlInjected.Token(Token = "0x600043D")]
		[Cpp2IlInjected.Address(RVA = "0x8E1270", Offset = "0x8E0670", VA = "0x1808E1270", Slot = "56")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000126")]
	public Vector3 GCIAIFNDFJO
	{
		[Cpp2IlInjected.Token(Token = "0x600043E")]
		[Cpp2IlInjected.Address(RVA = "0x1456DF0", Offset = "0x14561F0", VA = "0x181456DF0", Slot = "57")]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x600043F")]
		[Cpp2IlInjected.Address(RVA = "0x6D7320", Offset = "0x6D6720", VA = "0x1806D7320", Slot = "58")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000127")]
	public float BIJKBCGODIE
	{
		[Cpp2IlInjected.Token(Token = "0x6000440")]
		[Cpp2IlInjected.Address(RVA = "0x8A7F90", Offset = "0x8A7390", VA = "0x1808A7F90", Slot = "59")]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x6000441")]
		[Cpp2IlInjected.Address(RVA = "0x6D7320", Offset = "0x6D6720", VA = "0x1806D7320", Slot = "60")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000128")]
	public float CAEPFBBJBOK
	{
		[Cpp2IlInjected.Token(Token = "0x6000442")]
		[Cpp2IlInjected.Address(RVA = "0x8A7F90", Offset = "0x8A7390", VA = "0x1808A7F90", Slot = "61")]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x6000443")]
		[Cpp2IlInjected.Address(RVA = "0x6D7320", Offset = "0x6D6720", VA = "0x1806D7320", Slot = "62")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000129")]
	public Quaternion LBGIBJJINJH
	{
		[Cpp2IlInjected.Token(Token = "0x6000444")]
		[Cpp2IlInjected.Address(RVA = "0x1AAF490", Offset = "0x1AAE890", VA = "0x181AAF490", Slot = "63")]
		get
		{
			return default(Quaternion);
		}
		[Cpp2IlInjected.Token(Token = "0x6000445")]
		[Cpp2IlInjected.Address(RVA = "0x6D7320", Offset = "0x6D6720", VA = "0x1806D7320", Slot = "64")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700012A")]
	public Vector3 EDNJLBDPNMM
	{
		[Cpp2IlInjected.Token(Token = "0x6000446")]
		[Cpp2IlInjected.Address(RVA = "0x1456DF0", Offset = "0x14561F0", VA = "0x181456DF0", Slot = "65")]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x6000447")]
		[Cpp2IlInjected.Address(RVA = "0x6D7320", Offset = "0x6D6720", VA = "0x1806D7320", Slot = "66")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700012B")]
	public Quaternion DIIIGEGILHP
	{
		[Cpp2IlInjected.Token(Token = "0x6000448")]
		[Cpp2IlInjected.Address(RVA = "0x1AAF490", Offset = "0x1AAE890", VA = "0x181AAF490", Slot = "67")]
		get
		{
			return default(Quaternion);
		}
		[Cpp2IlInjected.Token(Token = "0x6000449")]
		[Cpp2IlInjected.Address(RVA = "0x6D7320", Offset = "0x6D6720", VA = "0x1806D7320", Slot = "68")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700012C")]
	public RigidbodyConstraints BCMJAHAELOH
	{
		[Cpp2IlInjected.Token(Token = "0x600044A")]
		[Cpp2IlInjected.Address(RVA = "0x6F98D0", Offset = "0x6F8CD0", VA = "0x1806F98D0", Slot = "69")]
		get
		{
			return default(RigidbodyConstraints);
		}
		[Cpp2IlInjected.Token(Token = "0x600044B")]
		[Cpp2IlInjected.Address(RVA = "0x6D7320", Offset = "0x6D6720", VA = "0x1806D7320", Slot = "70")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700012D")]
	public bool PJGCDNLPGAK
	{
		[Cpp2IlInjected.Token(Token = "0x600044C")]
		[Cpp2IlInjected.Address(RVA = "0x6F98E0", Offset = "0x6F8CE0", VA = "0x1806F98E0", Slot = "71")]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x600044D")]
		[Cpp2IlInjected.Address(RVA = "0x6D7320", Offset = "0x6D6720", VA = "0x1806D7320", Slot = "72")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700012E")]
	public CollisionDetectionMode CIEEKBNHEBL
	{
		[Cpp2IlInjected.Token(Token = "0x600044E")]
		[Cpp2IlInjected.Address(RVA = "0x6F98D0", Offset = "0x6F8CD0", VA = "0x1806F98D0", Slot = "73")]
		get
		{
			return default(CollisionDetectionMode);
		}
		[Cpp2IlInjected.Token(Token = "0x600044F")]
		[Cpp2IlInjected.Address(RVA = "0x6D7320", Offset = "0x6D6720", VA = "0x1806D7320", Slot = "74")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700012F")]
	public bool NFEEOKFPIGD
	{
		[Cpp2IlInjected.Token(Token = "0x6000450")]
		[Cpp2IlInjected.Address(RVA = "0x152D570", Offset = "0x152C970", VA = "0x18152D570", Slot = "75")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000038")]
	public event JPOFABMOGOF KMPDHKDHBNO
	{
		[Cpp2IlInjected.Token(Token = "0x60003F5")]
		[Cpp2IlInjected.Address(RVA = "0x6D7320", Offset = "0x6D6720", VA = "0x1806D7320", Slot = "81")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60003F6")]
		[Cpp2IlInjected.Address(RVA = "0x6D7320", Offset = "0x6D6720", VA = "0x1806D7320", Slot = "82")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000039")]
	public event JPOFABMOGOF FIBPOODLACB
	{
		[Cpp2IlInjected.Token(Token = "0x60003F7")]
		[Cpp2IlInjected.Address(RVA = "0x6D7320", Offset = "0x6D6720", VA = "0x1806D7320", Slot = "83")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60003F8")]
		[Cpp2IlInjected.Address(RVA = "0x6D7320", Offset = "0x6D6720", VA = "0x1806D7320", Slot = "84")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400003A")]
	public event CBNHIOLMAOO LEBPAEACGHM
	{
		[Cpp2IlInjected.Token(Token = "0x60003F9")]
		[Cpp2IlInjected.Address(RVA = "0x6D7320", Offset = "0x6D6720", VA = "0x1806D7320", Slot = "85")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60003FA")]
		[Cpp2IlInjected.Address(RVA = "0x6D7320", Offset = "0x6D6720", VA = "0x1806D7320", Slot = "86")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400003B")]
	public event JPOFABMOGOF OFDNMEKJKBP
	{
		[Cpp2IlInjected.Token(Token = "0x60003FB")]
		[Cpp2IlInjected.Address(RVA = "0x6D7320", Offset = "0x6D6720", VA = "0x1806D7320", Slot = "88")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60003FC")]
		[Cpp2IlInjected.Address(RVA = "0x6D7320", Offset = "0x6D6720", VA = "0x1806D7320", Slot = "89")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400003C")]
	public event JPOFABMOGOF GHPNGDBINKD
	{
		[Cpp2IlInjected.Token(Token = "0x60003FD")]
		[Cpp2IlInjected.Address(RVA = "0x6D7320", Offset = "0x6D6720", VA = "0x1806D7320", Slot = "108")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60003FE")]
		[Cpp2IlInjected.Address(RVA = "0x6D7320", Offset = "0x6D6720", VA = "0x1806D7320", Slot = "109")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400003D")]
	public event JPOFABMOGOF MLDKIENLGJG
	{
		[Cpp2IlInjected.Token(Token = "0x60003FF")]
		[Cpp2IlInjected.Address(RVA = "0x6D7320", Offset = "0x6D6720", VA = "0x1806D7320", Slot = "113")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000400")]
		[Cpp2IlInjected.Address(RVA = "0x6D7320", Offset = "0x6D6720", VA = "0x1806D7320", Slot = "114")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400003E")]
	public event Action<LHLIDFNIOKA, LHLIDFNIOKA> GBMBMPKHBHO
	{
		[Cpp2IlInjected.Token(Token = "0x6000401")]
		[Cpp2IlInjected.Address(RVA = "0x6D7320", Offset = "0x6D6720", VA = "0x1806D7320", Slot = "117")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000402")]
		[Cpp2IlInjected.Address(RVA = "0x6D7320", Offset = "0x6D6720", VA = "0x1806D7320", Slot = "118")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400003F")]
	public event JPOFABMOGOF KKHOKOPLGIE
	{
		[Cpp2IlInjected.Token(Token = "0x6000403")]
		[Cpp2IlInjected.Address(RVA = "0x6D7320", Offset = "0x6D6720", VA = "0x1806D7320", Slot = "119")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000404")]
		[Cpp2IlInjected.Address(RVA = "0x6D7320", Offset = "0x6D6720", VA = "0x1806D7320", Slot = "120")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000040")]
	public event JPOFABMOGOF FAMCBBOPNHD
	{
		[Cpp2IlInjected.Token(Token = "0x6000405")]
		[Cpp2IlInjected.Address(RVA = "0x6D7320", Offset = "0x6D6720", VA = "0x1806D7320", Slot = "125")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000406")]
		[Cpp2IlInjected.Address(RVA = "0x6D7320", Offset = "0x6D6720", VA = "0x1806D7320", Slot = "126")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000451")]
	[Cpp2IlInjected.Address(RVA = "0x6D7320", Offset = "0x6D6720", VA = "0x1806D7320", Slot = "76")]
	public void BKOELLNKDDF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000452")]
	[Cpp2IlInjected.Address(RVA = "0x6D7320", Offset = "0x6D6720", VA = "0x1806D7320", Slot = "77")]
	public void IDDPIKDPIIE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000453")]
	[Cpp2IlInjected.Address(RVA = "0x6D7320", Offset = "0x6D6720", VA = "0x1806D7320", Slot = "78")]
	public void EDIJBNLFNNB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000454")]
	[Cpp2IlInjected.Address(RVA = "0x6D7320", Offset = "0x6D6720", VA = "0x1806D7320", Slot = "79")]
	public void HFOIEEGNPME()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000455")]
	[Cpp2IlInjected.Address(RVA = "0x6D7320", Offset = "0x6D6720", VA = "0x1806D7320", Slot = "80")]
	public void FODBIMBAOBD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000456")]
	[Cpp2IlInjected.Address(RVA = "0x6D7320", Offset = "0x6D6720", VA = "0x1806D7320", Slot = "141")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000457")]
	[Cpp2IlInjected.Address(RVA = "0x6D7320", Offset = "0x6D6720", VA = "0x1806D7320", Slot = "87")]
	public void KKGLFGKJMPP(PPMDIHPMNCG JFBPNBNBHOE, bool LMKLDOOIJAA = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000458")]
	[Cpp2IlInjected.Address(RVA = "0x6D7320", Offset = "0x6D6720", VA = "0x1806D7320", Slot = "90")]
	public void CGMPABBBBGH(object AJDBKDIMOHA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000459")]
	[Cpp2IlInjected.Address(RVA = "0x6D7320", Offset = "0x6D6720", VA = "0x1806D7320", Slot = "91")]
	public void AKPJCFEODOB(object AJDBKDIMOHA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600045A")]
	[Cpp2IlInjected.Address(RVA = "0x1456DF0", Offset = "0x14561F0", VA = "0x181456DF0", Slot = "92")]
	public Vector3 EAJIEBJEBJP(Vector3 ODPCODBLNJO)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x600045B")]
	[Cpp2IlInjected.Address(RVA = "0x1456DF0", Offset = "0x14561F0", VA = "0x181456DF0", Slot = "93")]
	public Vector3 JGGPKLHDPOC(Vector3 DLOMDLEMEJO)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x600045C")]
	[Cpp2IlInjected.Address(RVA = "0x6D7320", Offset = "0x6D6720", VA = "0x1806D7320", Slot = "94")]
	public void LNGHCMNGELC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600045D")]
	[Cpp2IlInjected.Address(RVA = "0x6D7320", Offset = "0x6D6720", VA = "0x1806D7320", Slot = "95")]
	public void DGADOFDPFDE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600045E")]
	[Cpp2IlInjected.Address(RVA = "0x6D7320", Offset = "0x6D6720", VA = "0x1806D7320", Slot = "96")]
	public void IBIENENFOLO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600045F")]
	[Cpp2IlInjected.Address(RVA = "0x6D7320", Offset = "0x6D6720", VA = "0x1806D7320", Slot = "97")]
	public void EEIOJCMLKKL(Vector3 PKEOGDHOABC, Vector3 GNHLNIEHAFA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000460")]
	[Cpp2IlInjected.Address(RVA = "0x6D7320", Offset = "0x6D6720", VA = "0x1806D7320", Slot = "98")]
	public void BNKAMLPDNDH(Vector3 IHHIJIKHHIA, Vector3 NBGIHKDGDID)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000461")]
	[Cpp2IlInjected.Address(RVA = "0x6D7320", Offset = "0x6D6720", VA = "0x1806D7320", Slot = "99")]
	public void CADMMMANGFL(Vector3 GJKLLEKAGBH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000462")]
	[Cpp2IlInjected.Address(RVA = "0x6D7320", Offset = "0x6D6720", VA = "0x1806D7320", Slot = "100")]
	public void GOHOEPELEBG(CBPMCKPIBHC EIOPEGEMKHP, Vector3 DKCLOLGBADH, float OOKLCGCBAJI, float LLKLELEIBGC = 8f, float AEEFHMKEOAH = 1f)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000463")]
	[Cpp2IlInjected.Address(RVA = "0x6D7320", Offset = "0x6D6720", VA = "0x1806D7320", Slot = "101")]
	public void JLNINMHMEHA(BOPFIFMMKBG BPDOBLBNKEN, Vector3 NLFAAHHHDNN, float HHHNHCMFNFA = float.PositiveInfinity)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000464")]
	[Cpp2IlInjected.Address(RVA = "0x6D7320", Offset = "0x6D6720", VA = "0x1806D7320", Slot = "102")]
	public void ADCBOLCDFHD(BOPFIFMMKBG BPDOBLBNKEN, Vector3 MCFIHGJCDCP, float BDCHAJELIHL = 7f, float ABPPGEHGCFI = 1f)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000465")]
	[Cpp2IlInjected.Address(RVA = "0x1456DF0", Offset = "0x14561F0", VA = "0x181456DF0", Slot = "103")]
	public Vector3 KPFDHGBBOFB(Vector3 JFBPNBNBHOE)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000466")]
	[Cpp2IlInjected.Address(RVA = "0x1456DF0", Offset = "0x14561F0", VA = "0x181456DF0", Slot = "104")]
	public Vector3 FHKEINJELIE(Vector3 JFBPNBNBHOE)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000467")]
	[Cpp2IlInjected.Address(RVA = "0x6D7320", Offset = "0x6D6720", VA = "0x1806D7320", Slot = "105")]
	public void KDDHFACBKGB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000468")]
	[Cpp2IlInjected.Address(RVA = "0x6D7320", Offset = "0x6D6720", VA = "0x1806D7320", Slot = "106")]
	public void KFIEFEHILOK(PPMDIHPMNCG FONAKEEEKPK, object AJDBKDIMOHA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000469")]
	[Cpp2IlInjected.Address(RVA = "0x6D7320", Offset = "0x6D6720", VA = "0x1806D7320", Slot = "107")]
	public void MMHJICPHJHL(object AJDBKDIMOHA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600046A")]
	[Cpp2IlInjected.Address(RVA = "0x6D7320", Offset = "0x6D6720", VA = "0x1806D7320", Slot = "110")]
	public void OCCLJJBDHKH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600046B")]
	[Cpp2IlInjected.Address(RVA = "0x6D7320", Offset = "0x6D6720", VA = "0x1806D7320", Slot = "111")]
	public void LGMIOPKMACL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600046C")]
	[Cpp2IlInjected.Address(RVA = "0x6D7320", Offset = "0x6D6720", VA = "0x1806D7320", Slot = "112")]
	public void PGLMPJOADGG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600046D")]
	[Cpp2IlInjected.Address(RVA = "0x6F98E0", Offset = "0x6F8CE0", VA = "0x1806F98E0", Slot = "115")]
	public bool JLGKLAGDNBA()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600046E")]
	[Cpp2IlInjected.Address(RVA = "0x6D7320", Offset = "0x6D6720", VA = "0x1806D7320", Slot = "116")]
	public void IPODHJMCCPD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600046F")]
	[Cpp2IlInjected.Address(RVA = "0x6F98D0", Offset = "0x6F8CD0", VA = "0x1806F98D0", Slot = "121")]
	public IDisposable BFJJEOKEAOO()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000470")]
	[Cpp2IlInjected.Address(RVA = "0x6D7320", Offset = "0x6D6720", VA = "0x1806D7320", Slot = "122")]
	public void IDBKKNHMJCA(object AJDBKDIMOHA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000471")]
	[Cpp2IlInjected.Address(RVA = "0x6D7320", Offset = "0x6D6720", VA = "0x1806D7320", Slot = "123")]
	public void BPLEOILKCFF(object AJDBKDIMOHA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000472")]
	[Cpp2IlInjected.Address(RVA = "0x6D7320", Offset = "0x6D6720", VA = "0x1806D7320", Slot = "124")]
	public void NHDILIPFEBO(object AJDBKDIMOHA, bool NMHFDHPJGFL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000473")]
	[Cpp2IlInjected.Address(RVA = "0x6D7320", Offset = "0x6D6720", VA = "0x1806D7320", Slot = "127")]
	public void BBLLMNKJMFE(Vector3 LDBCCJOIJOF, Quaternion HPGHCBDEGFJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000474")]
	[Cpp2IlInjected.Address(RVA = "0x6D7320", Offset = "0x6D6720", VA = "0x1806D7320", Slot = "128")]
	public void MBJKCDHFBPN(Vector3 JPBAEPJPHFP, Quaternion NHHKEMOEKHO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000475")]
	[Cpp2IlInjected.Address(RVA = "0x6F98E0", Offset = "0x6F8CE0", VA = "0x1806F98E0", Slot = "129")]
	public bool BHKLDAAMMPP(float LCLMOJDNELD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000476")]
	[Cpp2IlInjected.Address(RVA = "0x6D7320", Offset = "0x6D6720", VA = "0x1806D7320", Slot = "130")]
	public void PGKAPIBFPCH(object AJDBKDIMOHA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000477")]
	[Cpp2IlInjected.Address(RVA = "0x6D7320", Offset = "0x6D6720", VA = "0x1806D7320", Slot = "131")]
	public void DFLECBDEDLK(object AJDBKDIMOHA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000478")]
	[Cpp2IlInjected.Address(RVA = "0x6D7320", Offset = "0x6D6720", VA = "0x1806D7320", Slot = "132")]
	public void NMDKIGJCKAP(object AJDBKDIMOHA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000479")]
	[Cpp2IlInjected.Address(RVA = "0x6D7320", Offset = "0x6D6720", VA = "0x1806D7320", Slot = "133")]
	public void IGIJDOMADBN(object AJDBKDIMOHA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600047A")]
	[Cpp2IlInjected.Address(RVA = "0x6D7320", Offset = "0x6D6720", VA = "0x1806D7320", Slot = "134")]
	public void MDAEENKEECK(Vector3 BIOMHNNIJHG, ForceMode HODPBICIGJM = ForceMode.Force)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600047B")]
	[Cpp2IlInjected.Address(RVA = "0x6D7320", Offset = "0x6D6720", VA = "0x1806D7320", Slot = "135")]
	public void LIGCOMLMAAG(Vector3 BIOMHNNIJHG, Vector3 DACBJNCMNFL, ForceMode HODPBICIGJM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600047C")]
	[Cpp2IlInjected.Address(RVA = "0x6D7320", Offset = "0x6D6720", VA = "0x1806D7320", Slot = "136")]
	public void DPFOGKDMEOC(Vector3 CEBBAPNMMME, ForceMode HODPBICIGJM = ForceMode.Force)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600047D")]
	[Cpp2IlInjected.Address(RVA = "0x6D7320", Offset = "0x6D6720", VA = "0x1806D7320", Slot = "137")]
	public void BFACFHPBMFM(Vector3 CEBBAPNMMME, ForceMode HODPBICIGJM = ForceMode.Force)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600047E")]
	[Cpp2IlInjected.Address(RVA = "0x5481170", Offset = "0x5480570", VA = "0x185481170", Slot = "138")]
	public bool CGHFGDDABEK(Vector3 HHOIMIMHDMP, out RaycastHit CFGLFCONCKN, float KMAOMDJLDEN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600047F")]
	[Cpp2IlInjected.Address(RVA = "0x6D7320", Offset = "0x6D6720", VA = "0x1806D7320", Slot = "139")]
	public void KEPOLBAFIFI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000480")]
	[Cpp2IlInjected.Address(RVA = "0x6D6CD0", Offset = "0x6D60D0", VA = "0x1806D6CD0")]
	public PEMCFGMEGMC()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000045")]
public sealed class LKOIEBFOHCO : DGHPEMNHGCH, MGDHAHFMJMO, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
	[Cpp2IlInjected.Token(Token = "0x4000082")]
	internal NFJEDPPAJMK ONBAMHPEIDG;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
	[Cpp2IlInjected.Token(Token = "0x4000083")]
	internal MCAEHJPOCLP ELHDNCHAHJE;

	[Cpp2IlInjected.Token(Token = "0x6000482")]
	[Cpp2IlInjected.Address(RVA = "0x5477620", Offset = "0x5476A20", VA = "0x185477620")]
	public LKOIEBFOHCO(GameObject OOKBNBHDPPG, RigidbodyEx CFNDHOOGKBI, CMKMIKBKOHM OBOKKBNADPB, in OALOFNDFAEL ONIBEFDCPGD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000483")]
	[Cpp2IlInjected.Address(RVA = "0x5476F80", Offset = "0x5476380", VA = "0x185476F80", Slot = "142")]
	protected override void FLDAICHOBKG(CMKMIKBKOHM OBOKKBNADPB, OALOFNDFAEL ONIBEFDCPGD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000484")]
	[Cpp2IlInjected.Address(RVA = "0x5476DF0", Offset = "0x54761F0", VA = "0x185476DF0", Slot = "143")]
	public override void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000485")]
	[Cpp2IlInjected.Address(RVA = "0x5477490", Offset = "0x5476890", VA = "0x185477490", Slot = "145")]
	public void OOBEJJLGKHO(LJKHPCCHKIO IAMOONJKNLF, LJKHPCCHKIO AFLEFPKENKF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000486")]
	[Cpp2IlInjected.Address(RVA = "0x5477560", Offset = "0x5476960", VA = "0x185477560", Slot = "146")]
	public void PJEANDADBNP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000487")]
	[Cpp2IlInjected.Address(RVA = "0x5477270", Offset = "0x5476670", VA = "0x185477270", Slot = "147")]
	public void IDMNFPEFOEM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000488")]
	[Cpp2IlInjected.Address(RVA = "0x5477210", Offset = "0x5476610", VA = "0x185477210", Slot = "148")]
	public void GCGBBMHMBBI(bool DMEOICFENFA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000489")]
	[Cpp2IlInjected.Address(RVA = "0x5477330", Offset = "0x5476730", VA = "0x185477330", Slot = "149")]
	public bool MMLPMIJMFFO()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600048A")]
	[Cpp2IlInjected.Address(RVA = "0x6D7320", Offset = "0x6D6720", VA = "0x1806D7320", Slot = "144")]
	public override void FODBIMBAOBD()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000046")]
internal static class MCLADCKIOGP
{
	[Cpp2IlInjected.Token(Token = "0x600048B")]
	[Cpp2IlInjected.Address(RVA = "0x5479DF0", Offset = "0x54791F0", VA = "0x185479DF0")]
	public static DGHPEMNHGCH FIHMNOBDLAB(this PPMDIHPMNCG ONJEPBGIHBB)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000047")]
public interface NCOHPAGAOFB : HMOOAGCGLKM, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x600048C")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void FIMHIJJNHNG(PPMDIHPMNCG LDDCANHDBNB);

	[Cpp2IlInjected.Token(Token = "0x600048D")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void LNGINODJAIF(PPMDIHPMNCG LDDCANHDBNB);

	[Cpp2IlInjected.Token(Token = "0x600048E")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void PLMMLEJPFJC(PPMDIHPMNCG KPJMALENPJM);

	[Cpp2IlInjected.Token(Token = "0x600048F")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void IBABMBDNBHE(PPMDIHPMNCG KPJMALENPJM);
}
[Cpp2IlInjected.Token(Token = "0x2000048")]
public interface BEJNCHMIDMJ : NPFLLLAFPDM
{
	[Cpp2IlInjected.Token(Token = "0x17000130")]
	global::NBBJJOCKJND<PPMDIHPMNCG> LDACBKKKFLL
	{
		[Cpp2IlInjected.Token(Token = "0x6000490")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000131")]
	PPMDIHPMNCG MMCLEEKFDKC
	{
		[Cpp2IlInjected.Token(Token = "0x6000491")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000049")]
public interface HMBPIDNECOA : HEFJBMMENIM
{
	[Cpp2IlInjected.Token(Token = "0x6000492")]
	[Cpp2IlInjected.Address(Slot = "0")]
	(float, Vector3) PJKJFLIKEBB(Rigidbody MJNKCPJACPF);
}
[Cpp2IlInjected.Token(Token = "0x200004A")]
public interface CGEGJFCCOBC : LNJFNCEGNCA, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x17000132")]
	PhotonView KKFANKJJONE
	{
		[Cpp2IlInjected.Token(Token = "0x6000493")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x200004B")]
internal sealed class EGNDKGLFNBG : APGGGIKOMPN
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000084")]
	private readonly DGHPEMNHGCH LDDCANHDBNB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000085")]
	private CollisionDetectionMode IOFDDIABPHK;

	[Cpp2IlInjected.Token(Token = "0x17000133")]
	private Rigidbody BAPEKECGLDP
	{
		[Cpp2IlInjected.Token(Token = "0x6000494")]
		[Cpp2IlInjected.Address(RVA = "0x545A560", Offset = "0x5459960", VA = "0x18545A560")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000134")]
	public CollisionDetectionMode CIEEKBNHEBL
	{
		[Cpp2IlInjected.Token(Token = "0x6000498")]
		[Cpp2IlInjected.Address(RVA = "0x546AC20", Offset = "0x546A020", VA = "0x18546AC20", Slot = "4")]
		get
		{
			return default(CollisionDetectionMode);
		}
		[Cpp2IlInjected.Token(Token = "0x6000499")]
		[Cpp2IlInjected.Address(RVA = "0x546AD30", Offset = "0x546A130", VA = "0x18546AD30", Slot = "5")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000495")]
	[Cpp2IlInjected.Address(RVA = "0x5463290", Offset = "0x5462690", VA = "0x185463290")]
	public EGNDKGLFNBG(PPMDIHPMNCG LDDCANHDBNB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000496")]
	[Cpp2IlInjected.Address(RVA = "0x546ADA0", Offset = "0x546A1A0", VA = "0x18546ADA0", Slot = "6")]
	public void BKOELLNKDDF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000497")]
	[Cpp2IlInjected.Address(RVA = "0x546B040", Offset = "0x546A440", VA = "0x18546B040", Slot = "9")]
	public void JPMOLDGLNJO(Rigidbody AOAFHPHKFMD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600049A")]
	[Cpp2IlInjected.Address(RVA = "0x546B1F0", Offset = "0x546A5F0", VA = "0x18546B1F0", Slot = "7")]
	public void NAIFDEINDCM(bool IOEMIKGMLIB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600049B")]
	[Cpp2IlInjected.Address(RVA = "0x546B030", Offset = "0x546A430", VA = "0x18546B030", Slot = "8")]
	public void HCJANJMAAPB(bool IOEMIKGMLIB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600049C")]
	[Cpp2IlInjected.Address(RVA = "0x546AEC0", Offset = "0x546A2C0", VA = "0x18546AEC0", Slot = "10")]
	public bool CGHFGDDABEK(Vector3 HHOIMIMHDMP, out RaycastHit CFGLFCONCKN, float KMAOMDJLDEN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600049D")]
	[Cpp2IlInjected.Address(RVA = "0x546B0C0", Offset = "0x546A4C0", VA = "0x18546B0C0")]
	private void KAMCMADHFNP(bool IOEMIKGMLIB)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200004C")]
public sealed class OOFKHDCLCAK : ODGCKIECBJN, IDisposable, NLJGMJFEGHJ
{
	[Cpp2IlInjected.Token(Token = "0x4000086")]
	public const int DCMCDEDLNJN = 350;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000088")]
	private readonly DGHPEMNHGCH LDDCANHDBNB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000089")]
	private PPGNAFCKNOL JHPIKONIGNI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400008A")]
	private GNJJFOIGADA OBNDLFADEDH;

	[Cpp2IlInjected.Token(Token = "0x17000135")]
	public PPGNAFCKNOL NHFAJHMDKMA
	{
		[Cpp2IlInjected.Token(Token = "0x60004A0")]
		[Cpp2IlInjected.Address(RVA = "0x5480E50", Offset = "0x5480250", VA = "0x185480E50", Slot = "6")]
		get
		{
			return default(PPGNAFCKNOL);
		}
		[Cpp2IlInjected.Token(Token = "0x60004A1")]
		[Cpp2IlInjected.Address(RVA = "0x5480F90", Offset = "0x5480390", VA = "0x185480F90", Slot = "7")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000136")]
	private Transform JBPFIGDCPFI
	{
		[Cpp2IlInjected.Token(Token = "0x60004A2")]
		[Cpp2IlInjected.Address(RVA = "0x5480DD0", Offset = "0x54801D0", VA = "0x185480DD0", Slot = "10")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000041")]
	public event Action<LHLIDFNIOKA, LHLIDFNIOKA> GBMBMPKHBHO
	{
		[Cpp2IlInjected.Token(Token = "0x600049E")]
		[Cpp2IlInjected.Address(RVA = "0x5480D30", Offset = "0x5480130", VA = "0x185480D30", Slot = "4")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600049F")]
		[Cpp2IlInjected.Address(RVA = "0x5480960", Offset = "0x547FD60", VA = "0x185480960", Slot = "5")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60004A3")]
	[Cpp2IlInjected.Address(RVA = "0x5481060", Offset = "0x5480460", VA = "0x185481060")]
	public OOFKHDCLCAK(PPMDIHPMNCG LDDCANHDBNB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004A4")]
	[Cpp2IlInjected.Address(RVA = "0x5480A00", Offset = "0x547FE00", VA = "0x185480A00", Slot = "8")]
	public void BKOELLNKDDF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004A5")]
	[Cpp2IlInjected.Address(RVA = "0x5480CE0", Offset = "0x54800E0", VA = "0x185480CE0", Slot = "9")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004A6")]
	[Cpp2IlInjected.Address(RVA = "0x5480DF0", Offset = "0x54801F0", VA = "0x185480DF0", Slot = "11")]
	private void HGFPJHEOKNN(LHLIDFNIOKA ELKALKBOHEP, LHLIDFNIOKA LBONJHPGLEG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004A7")]
	[Cpp2IlInjected.Address(RVA = "0x6D7320", Offset = "0x6D6720", VA = "0x1806D7320", Slot = "12")]
	private void ICAEGOHLFCB(bool HFPGMHEIJMF)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200004D")]
internal sealed class BPBKHCGDCGI : FGHCKEELDLL
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400008B")]
	private readonly DGHPEMNHGCH LDDCANHDBNB;

	[Cpp2IlInjected.Token(Token = "0x17000137")]
	private Rigidbody BAPEKECGLDP
	{
		[Cpp2IlInjected.Token(Token = "0x60004A8")]
		[Cpp2IlInjected.Address(RVA = "0x545A560", Offset = "0x5459960", VA = "0x18545A560")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000138")]
	private bool MBEHMAPDJBJ
	{
		[Cpp2IlInjected.Token(Token = "0x60004A9")]
		[Cpp2IlInjected.Address(RVA = "0x5462B60", Offset = "0x5461F60", VA = "0x185462B60")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000139")]
	private bool DKNFKPAFDPB
	{
		[Cpp2IlInjected.Token(Token = "0x60004AA")]
		[Cpp2IlInjected.Address(RVA = "0x54618A0", Offset = "0x5460CA0", VA = "0x1854618A0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700013A")]
	private PPMDIHPMNCG EMIBHNNCMJC
	{
		[Cpp2IlInjected.Token(Token = "0x60004AB")]
		[Cpp2IlInjected.Address(RVA = "0x5463230", Offset = "0x5462630", VA = "0x185463230")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60004AC")]
	[Cpp2IlInjected.Address(RVA = "0x5463290", Offset = "0x5462690", VA = "0x185463290")]
	public BPBKHCGDCGI(PPMDIHPMNCG LDDCANHDBNB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004AD")]
	[Cpp2IlInjected.Address(RVA = "0x54630D0", Offset = "0x54624D0", VA = "0x1854630D0", Slot = "4")]
	public void MDAEENKEECK(Vector3 BIOMHNNIJHG, ForceMode HODPBICIGJM = ForceMode.Force)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004AE")]
	[Cpp2IlInjected.Address(RVA = "0x5462780", Offset = "0x5461B80", VA = "0x185462780")]
	private void BIAOBHKBAEN(Vector3 BIOMHNNIJHG, ForceMode HODPBICIGJM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004AF")]
	[Cpp2IlInjected.Address(RVA = "0x5462E30", Offset = "0x5462230", VA = "0x185462E30", Slot = "5")]
	public void LIGCOMLMAAG(Vector3 BIOMHNNIJHG, Vector3 DACBJNCMNFL, ForceMode HODPBICIGJM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004B0")]
	[Cpp2IlInjected.Address(RVA = "0x5462A00", Offset = "0x5461E00", VA = "0x185462A00", Slot = "6")]
	public void DPFOGKDMEOC(Vector3 CEBBAPNMMME, ForceMode HODPBICIGJM = ForceMode.Force)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004B1")]
	[Cpp2IlInjected.Address(RVA = "0x5462BB0", Offset = "0x5461FB0", VA = "0x185462BB0")]
	private void KDJCKDGOEKH(Vector3 CEBBAPNMMME, ForceMode HODPBICIGJM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004B2")]
	[Cpp2IlInjected.Address(RVA = "0x5462500", Offset = "0x5461900", VA = "0x185462500", Slot = "7")]
	public void BFACFHPBMFM(Vector3 CEBBAPNMMME, ForceMode HODPBICIGJM = ForceMode.Force)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200004E")]
internal sealed class MDFIOOIOMLH : LMMEICEFKMM
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400008C")]
	private readonly DGHPEMNHGCH LDDCANHDBNB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400008D")]
	private bool POECKMPMDKM;

	[Cpp2IlInjected.Token(Token = "0x1700013B")]
	public bool HLADCICNJBO
	{
		[Cpp2IlInjected.Token(Token = "0x60004B4")]
		[Cpp2IlInjected.Address(RVA = "0x7B85D0", Offset = "0x7B79D0", VA = "0x1807B85D0", Slot = "4")]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x60004B5")]
		[Cpp2IlInjected.Address(RVA = "0x5479E40", Offset = "0x5479240", VA = "0x185479E40", Slot = "5")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60004B3")]
	[Cpp2IlInjected.Address(RVA = "0x5463290", Offset = "0x5462690", VA = "0x185463290")]
	public MDFIOOIOMLH(PPMDIHPMNCG LDDCANHDBNB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004B6")]
	[Cpp2IlInjected.Address(RVA = "0x5479F50", Offset = "0x5479350", VA = "0x185479F50", Slot = "6")]
	public void JPMOLDGLNJO(Rigidbody AOAFHPHKFMD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004B7")]
	[Cpp2IlInjected.Address(RVA = "0x5458A80", Offset = "0x5457E80", VA = "0x185458A80", Slot = "7")]
	public void AAGPIEFPDDG(Rigidbody AOAFHPHKFMD)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200004F")]
internal sealed class HHJCEHPAGOM : NCOHPAGAOFB, HMOOAGCGLKM, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x4000097")]
	private readonly PPMDIHPMNCG LDDCANHDBNB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x4000098")]
	private readonly List<PPMDIHPMNCG> PLBLCMNMLJO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x4000099")]
	private PPMDIHPMNCG LBGMPPHBAAC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x400009A")]
	private PPMDIHPMNCG GPFONCECPBK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
	[Cpp2IlInjected.Token(Token = "0x400009B")]
	private Transform HGEGMMMECOK;

	[Cpp2IlInjected.Token(Token = "0x1700013C")]
	private Transform LNPNGFHHEEL
	{
		[Cpp2IlInjected.Token(Token = "0x60004CA")]
		[Cpp2IlInjected.Address(RVA = "0x5470450", Offset = "0x546F850", VA = "0x185470450")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700013D")]
	public PPMDIHPMNCG EMIBHNNCMJC
	{
		[Cpp2IlInjected.Token(Token = "0x60004CD")]
		[Cpp2IlInjected.Address(RVA = "0x6F0B50", Offset = "0x6EFF50", VA = "0x1806F0B50", Slot = "28")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60004CE")]
		[Cpp2IlInjected.Address(RVA = "0x5471D30", Offset = "0x5471130", VA = "0x185471D30", Slot = "29")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700013E")]
	public PPMDIHPMNCG MDHMHFAIMJJ
	{
		[Cpp2IlInjected.Token(Token = "0x60004CF")]
		[Cpp2IlInjected.Address(RVA = "0x77D600", Offset = "0x77CA00", VA = "0x18077D600", Slot = "27")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700013F")]
	public IReadOnlyList<PPMDIHPMNCG> LILCAAEDFCG
	{
		[Cpp2IlInjected.Token(Token = "0x60004D0")]
		[Cpp2IlInjected.Address(RVA = "0x77D5F0", Offset = "0x77C9F0", VA = "0x18077D5F0", Slot = "26")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000042")]
	public event JPOFABMOGOF KMPDHKDHBNO
	{
		[Cpp2IlInjected.Token(Token = "0x60004B8")]
		[Cpp2IlInjected.Address(RVA = "0x5470AB0", Offset = "0x546FEB0", VA = "0x185470AB0", Slot = "8")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60004B9")]
		[Cpp2IlInjected.Address(RVA = "0x5471110", Offset = "0x5470510", VA = "0x185471110", Slot = "9")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000043")]
	public event JPOFABMOGOF FIBPOODLACB
	{
		[Cpp2IlInjected.Token(Token = "0x60004BA")]
		[Cpp2IlInjected.Address(RVA = "0x5471A00", Offset = "0x5470E00", VA = "0x185471A00", Slot = "10")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60004BB")]
		[Cpp2IlInjected.Address(RVA = "0x5470850", Offset = "0x546FC50", VA = "0x185470850", Slot = "11")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000044")]
	public event CBNHIOLMAOO LEBPAEACGHM
	{
		[Cpp2IlInjected.Token(Token = "0x60004BC")]
		[Cpp2IlInjected.Address(RVA = "0x5471250", Offset = "0x5470650", VA = "0x185471250", Slot = "12")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60004BD")]
		[Cpp2IlInjected.Address(RVA = "0x5470C80", Offset = "0x5470080", VA = "0x185470C80", Slot = "13")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000045")]
	public event Action FJCAMHJDHPJ
	{
		[Cpp2IlInjected.Token(Token = "0x60004BE")]
		[Cpp2IlInjected.Address(RVA = "0x54704B0", Offset = "0x546F8B0", VA = "0x1854704B0", Slot = "14")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60004BF")]
		[Cpp2IlInjected.Address(RVA = "0x54703B0", Offset = "0x546F7B0", VA = "0x1854703B0", Slot = "15")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000046")]
	public event Action CJALHGJOGOA
	{
		[Cpp2IlInjected.Token(Token = "0x60004C0")]
		[Cpp2IlInjected.Address(RVA = "0x5472030", Offset = "0x5471430", VA = "0x185472030", Slot = "16")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60004C1")]
		[Cpp2IlInjected.Address(RVA = "0x5470D20", Offset = "0x5470120", VA = "0x185470D20", Slot = "17")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000047")]
	public event Action<PPMDIHPMNCG> JIFKALNNAKN
	{
		[Cpp2IlInjected.Token(Token = "0x60004C2")]
		[Cpp2IlInjected.Address(RVA = "0x54711B0", Offset = "0x54705B0", VA = "0x1854711B0", Slot = "18")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60004C3")]
		[Cpp2IlInjected.Address(RVA = "0x5471D40", Offset = "0x5471140", VA = "0x185471D40", Slot = "19")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000048")]
	public event Action<PPMDIHPMNCG> DACGCLEDAOG
	{
		[Cpp2IlInjected.Token(Token = "0x60004C4")]
		[Cpp2IlInjected.Address(RVA = "0x5470A10", Offset = "0x546FE10", VA = "0x185470A10", Slot = "20")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60004C5")]
		[Cpp2IlInjected.Address(RVA = "0x5471AA0", Offset = "0x5470EA0", VA = "0x185471AA0", Slot = "21")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000049")]
	public event Action HEMJJFHJOBJ
	{
		[Cpp2IlInjected.Token(Token = "0x60004C6")]
		[Cpp2IlInjected.Address(RVA = "0x5470550", Offset = "0x546F950", VA = "0x185470550", Slot = "22")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60004C7")]
		[Cpp2IlInjected.Address(RVA = "0x5471960", Offset = "0x5470D60", VA = "0x185471960", Slot = "23")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400004A")]
	public event Action<PPMDIHPMNCG> NDOMLKAOIDP
	{
		[Cpp2IlInjected.Token(Token = "0x60004C8")]
		[Cpp2IlInjected.Address(RVA = "0x5471C90", Offset = "0x5471090", VA = "0x185471C90", Slot = "24")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60004C9")]
		[Cpp2IlInjected.Address(RVA = "0x54708F0", Offset = "0x546FCF0", VA = "0x1854708F0", Slot = "25")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60004CB")]
	[Cpp2IlInjected.Address(RVA = "0x54720D0", Offset = "0x54714D0", VA = "0x1854720D0")]
	public HHJCEHPAGOM(PPMDIHPMNCG LDDCANHDBNB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004CC")]
	[Cpp2IlInjected.Address(RVA = "0x5470990", Offset = "0x546FD90", VA = "0x185470990", Slot = "31")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004D1")]
	[Cpp2IlInjected.Address(RVA = "0x54712F0", Offset = "0x54706F0", VA = "0x1854712F0", Slot = "30")]
	public void KKGLFGKJMPP(PPMDIHPMNCG DPPABCPODHG, bool LMKLDOOIJAA = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004D2")]
	[Cpp2IlInjected.Address(RVA = "0x5471DE0", Offset = "0x54711E0", VA = "0x185471DE0", Slot = "6")]
	public void PLMMLEJPFJC(PPMDIHPMNCG KPJMALENPJM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004D3")]
	[Cpp2IlInjected.Address(RVA = "0x5470DC0", Offset = "0x54701C0", VA = "0x185470DC0", Slot = "7")]
	public void IBABMBDNBHE(PPMDIHPMNCG KPJMALENPJM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004D4")]
	[Cpp2IlInjected.Address(RVA = "0x5470B50", Offset = "0x546FF50", VA = "0x185470B50", Slot = "4")]
	public void FIMHIJJNHNG(PPMDIHPMNCG LDDCANHDBNB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004D5")]
	[Cpp2IlInjected.Address(RVA = "0x54718C0", Offset = "0x5470CC0", VA = "0x1854718C0", Slot = "5")]
	public void LNGINODJAIF(PPMDIHPMNCG LDDCANHDBNB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004D6")]
	[Cpp2IlInjected.Address(RVA = "0x5470BF0", Offset = "0x546FFF0", VA = "0x185470BF0")]
	private void HFLEBMEBODA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004D7")]
	[Cpp2IlInjected.Address(RVA = "0x5471880", Offset = "0x5470C80", VA = "0x185471880")]
	private void KLFLFGBKAAA(PPMDIHPMNCG KPJMALENPJM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004D8")]
	[Cpp2IlInjected.Address(RVA = "0x5471B40", Offset = "0x5470F40", VA = "0x185471B40")]
	private void NAPFPOANHMH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004D9")]
	[Cpp2IlInjected.Address(RVA = "0x5470720", Offset = "0x546FB20", VA = "0x185470720")]
	private void COMAAFBCCFI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004DA")]
	[Cpp2IlInjected.Address(RVA = "0x54705F0", Offset = "0x546F9F0", VA = "0x1854705F0")]
	private void CMMLKAPMCHH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004DB")]
	[Cpp2IlInjected.Address(RVA = "0x5471020", Offset = "0x5470420", VA = "0x185471020")]
	[CompilerGenerated]
	private object IJNBMKEEBDG()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000050")]
internal static class NNOHNCOMOAM
{
	[Cpp2IlInjected.Token(Token = "0x60004DC")]
	[Cpp2IlInjected.Address(RVA = "0x5480340", Offset = "0x547F740", VA = "0x185480340")]
	public static NCOHPAGAOFB NCKPBBOBINB(this PPMDIHPMNCG ONJEPBGIHBB)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000051")]
internal sealed class FBAJOCIIEEK : BEJNCHMIDMJ, NPFLLLAFPDM
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400009C")]
	private readonly DGHPEMNHGCH LDDCANHDBNB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400009D")]
	private readonly global::NBBJJOCKJND<PPMDIHPMNCG> AKMPOIOEOKM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400009E")]
	private bool BLKEPHABMHL;

	[Cpp2IlInjected.Token(Token = "0x17000140")]
	public global::NBBJJOCKJND<PPMDIHPMNCG> LDACBKKKFLL
	{
		[Cpp2IlInjected.Token(Token = "0x60004DD")]
		[Cpp2IlInjected.Address(RVA = "0x6E4140", Offset = "0x6E3540", VA = "0x1806E4140", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000141")]
	public Vector3 DJHICJGOGJI
	{
		[Cpp2IlInjected.Token(Token = "0x60004DE")]
		[Cpp2IlInjected.Address(RVA = "0x546FBD0", Offset = "0x546EFD0", VA = "0x18546FBD0", Slot = "6")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000142")]
	public Vector3 EOFHLAGNPII
	{
		[Cpp2IlInjected.Token(Token = "0x60004DF")]
		[Cpp2IlInjected.Address(RVA = "0x546FFB0", Offset = "0x546F3B0", VA = "0x18546FFB0", Slot = "7")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000143")]
	private Vector3 MHCLHNEGJDD
	{
		[Cpp2IlInjected.Token(Token = "0x60004E3")]
		[Cpp2IlInjected.Address(RVA = "0x546F6E0", Offset = "0x546EAE0", VA = "0x18546F6E0")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000144")]
	public PPMDIHPMNCG MMCLEEKFDKC
	{
		[Cpp2IlInjected.Token(Token = "0x60004E4")]
		[Cpp2IlInjected.Address(RVA = "0x5470180", Offset = "0x546F580", VA = "0x185470180", Slot = "5")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60004E0")]
	[Cpp2IlInjected.Address(RVA = "0x5470230", Offset = "0x546F630", VA = "0x185470230")]
	public FBAJOCIIEEK(PPMDIHPMNCG LDDCANHDBNB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004E1")]
	[Cpp2IlInjected.Address(RVA = "0x546F7C0", Offset = "0x546EBC0", VA = "0x18546F7C0", Slot = "8")]
	public void CNAAFOJMHNK(PPMDIHPMNCG GPFONCECPBK, object AJDBKDIMOHA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004E2")]
	[Cpp2IlInjected.Address(RVA = "0x546FC00", Offset = "0x546F000", VA = "0x18546FC00", Slot = "9")]
	public void JOEIIPCOBII(object AJDBKDIMOHA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004E5")]
	[Cpp2IlInjected.Address(RVA = "0x546FC60", Offset = "0x546F060", VA = "0x18546FC60")]
	private Vector3 MIDPCEDMHPH()
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x60004E6")]
	[Cpp2IlInjected.Address(RVA = "0x546F830", Offset = "0x546EC30", VA = "0x18546F830")]
	private void GGLGADBIHJO(PPMDIHPMNCG IHBHHLCNEDN)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000052")]
internal static class LECNGFJJHHO
{
	[Cpp2IlInjected.Token(Token = "0x60004E7")]
	[Cpp2IlInjected.Address(RVA = "0x5476530", Offset = "0x5475930", VA = "0x185476530")]
	public static BEJNCHMIDMJ BKCOHJDHGKA(this PPMDIHPMNCG ONJEPBGIHBB)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000053")]
internal sealed class IPENFEEMJLP : HMBPIDNECOA, HEFJBMMENIM
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000A0")]
	private readonly DGHPEMNHGCH LDDCANHDBNB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000A1")]
	private readonly OverridableVector3 PHKDOEMHFGP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40000A2")]
	private readonly OverridableVector3 EJHFMNHJBDB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x40000A3")]
	private float AKJJDFEANLD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x44")]
	[Cpp2IlInjected.Token(Token = "0x40000A4")]
	private float AKCBBGMHDDM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x40000A5")]
	private Vector3 MJDCNCPMNKH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x54")]
	[Cpp2IlInjected.Token(Token = "0x40000A6")]
	private Vector3? KNIHAMHGBLN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x64")]
	[Cpp2IlInjected.Token(Token = "0x40000A7")]
	private Quaternion? OPONCDOPJKK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
	[Cpp2IlInjected.Token(Token = "0x40000A8")]
	private bool OAEHJNDBHFG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x79")]
	[Cpp2IlInjected.Token(Token = "0x40000A9")]
	private bool GHIIFJIIIEC;

	[Cpp2IlInjected.Token(Token = "0x17000145")]
	public Vector3 JMIIJDMAMEI
	{
		[Cpp2IlInjected.Token(Token = "0x60004EA")]
		[Cpp2IlInjected.Address(RVA = "0x1C644F0", Offset = "0x1C638F0", VA = "0x181C644F0", Slot = "7")]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x60004EB")]
		[Cpp2IlInjected.Address(RVA = "0x5474490", Offset = "0x5473890", VA = "0x185474490", Slot = "8")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000146")]
	public Vector3 PMKFGPJNJBI
	{
		[Cpp2IlInjected.Token(Token = "0x60004EC")]
		[Cpp2IlInjected.Address(RVA = "0x5473D30", Offset = "0x5473130", VA = "0x185473D30", Slot = "9")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000147")]
	public float KLNDCEHFMBA
	{
		[Cpp2IlInjected.Token(Token = "0x60004ED")]
		[Cpp2IlInjected.Address(RVA = "0x730100", Offset = "0x72F500", VA = "0x180730100", Slot = "10")]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x60004EE")]
		[Cpp2IlInjected.Address(RVA = "0x5473E30", Offset = "0x5473230", VA = "0x185473E30")]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000148")]
	public float NBJLLACMBLF
	{
		[Cpp2IlInjected.Token(Token = "0x60004EF")]
		[Cpp2IlInjected.Address(RVA = "0x797650", Offset = "0x796A50", VA = "0x180797650", Slot = "11")]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x60004F0")]
		[Cpp2IlInjected.Address(RVA = "0x54742D0", Offset = "0x54736D0", VA = "0x1854742D0", Slot = "12")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000149")]
	public Vector3 OFFHJCCLOEB
	{
		[Cpp2IlInjected.Token(Token = "0x60004F1")]
		[Cpp2IlInjected.Address(RVA = "0x54740C0", Offset = "0x54734C0", VA = "0x1854740C0", Slot = "13")]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x60004F2")]
		[Cpp2IlInjected.Address(RVA = "0x54742F0", Offset = "0x54736F0", VA = "0x1854742F0", Slot = "14")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700014A")]
	public Quaternion MOMBOPJMDMK
	{
		[Cpp2IlInjected.Token(Token = "0x60004F3")]
		[Cpp2IlInjected.Address(RVA = "0x5473F50", Offset = "0x5473350", VA = "0x185473F50", Slot = "15")]
		get
		{
			return default(Quaternion);
		}
		[Cpp2IlInjected.Token(Token = "0x60004F4")]
		[Cpp2IlInjected.Address(RVA = "0x5474550", Offset = "0x5473950", VA = "0x185474550", Slot = "16")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700014B")]
	private Rigidbody BAPEKECGLDP
	{
		[Cpp2IlInjected.Token(Token = "0x60004FC")]
		[Cpp2IlInjected.Address(RVA = "0x5476320", Offset = "0x5475720", VA = "0x185476320")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400004B")]
	public event JPOFABMOGOF GOMGJPJMHIM
	{
		[Cpp2IlInjected.Token(Token = "0x60004E8")]
		[Cpp2IlInjected.Address(RVA = "0x5474230", Offset = "0x5473630", VA = "0x185474230", Slot = "5")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60004E9")]
		[Cpp2IlInjected.Address(RVA = "0x54744B0", Offset = "0x54738B0", VA = "0x1854744B0", Slot = "6")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60004F5")]
	[Cpp2IlInjected.Address(RVA = "0x5476370", Offset = "0x5475770", VA = "0x185476370")]
	public IPENFEEMJLP(PPMDIHPMNCG LDDCANHDBNB, in OALOFNDFAEL ONIBEFDCPGD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004F6")]
	[Cpp2IlInjected.Address(RVA = "0x5475050", Offset = "0x5474450", VA = "0x185475050", Slot = "18")]
	public void OCCLJJBDHKH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004F7")]
	[Cpp2IlInjected.Address(RVA = "0x5474C90", Offset = "0x5474090", VA = "0x185474C90", Slot = "17")]
	public void LGMIOPKMACL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004F8")]
	[Cpp2IlInjected.Address(RVA = "0x54746F0", Offset = "0x5473AF0", VA = "0x1854746F0", Slot = "20")]
	public void JPMOLDGLNJO(Rigidbody AOAFHPHKFMD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004F9")]
	[Cpp2IlInjected.Address(RVA = "0x54739A0", Offset = "0x5472DA0", VA = "0x1854739A0", Slot = "21")]
	public void AAGPIEFPDDG(Rigidbody AOAFHPHKFMD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004FA")]
	[Cpp2IlInjected.Address(RVA = "0x5475210", Offset = "0x5474610", VA = "0x185475210", Slot = "19")]
	public void PGLMPJOADGG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004FB")]
	[Cpp2IlInjected.Address(RVA = "0x54747D0", Offset = "0x5473BD0", VA = "0x1854747D0", Slot = "22")]
	public void KEPOLBAFIFI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004FD")]
	[Cpp2IlInjected.Address(RVA = "0x5474490", Offset = "0x5473890", VA = "0x185474490")]
	private void HBJMIFMDHJH(Vector3 JFBPNBNBHOE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004FE")]
	[Cpp2IlInjected.Address(RVA = "0x5473C40", Offset = "0x5473040", VA = "0x185473C40")]
	private Vector3 BCKCCAMLFFB()
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x60004FF")]
	[Cpp2IlInjected.Address(RVA = "0x5473E30", Offset = "0x5473230", VA = "0x185473E30")]
	private void CGGJFFODFCK(float JFBPNBNBHOE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000500")]
	[Cpp2IlInjected.Address(RVA = "0x54742D0", Offset = "0x54736D0", VA = "0x1854742D0")]
	private void FPOBCCILBBI(float JFBPNBNBHOE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000501")]
	[Cpp2IlInjected.Address(RVA = "0x5474D70", Offset = "0x5474170", VA = "0x185474D70")]
	private Vector3 LIHAPOLOMJO()
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000502")]
	[Cpp2IlInjected.Address(RVA = "0x54742F0", Offset = "0x54736F0", VA = "0x1854742F0")]
	private void IPFFPNBFENN(Vector3 JFBPNBNBHOE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000503")]
	[Cpp2IlInjected.Address(RVA = "0x5474EF0", Offset = "0x54742F0", VA = "0x185474EF0")]
	private Quaternion MFJCLLLJOKO()
	{
		return default(Quaternion);
	}

	[Cpp2IlInjected.Token(Token = "0x6000504")]
	[Cpp2IlInjected.Address(RVA = "0x5474550", Offset = "0x5473950", VA = "0x185474550")]
	private void KKICMMPIOEM(Quaternion JFBPNBNBHOE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000505")]
	[Cpp2IlInjected.Address(RVA = "0x5475380", Offset = "0x5474780", VA = "0x185475380")]
	public void PJKJFLIKEBB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000506")]
	[Cpp2IlInjected.Address(RVA = "0x5475460", Offset = "0x5474860", VA = "0x185475460", Slot = "4")]
	public (float, Vector3) PJKJFLIKEBB(Rigidbody MJNKCPJACPF)
	{
		return default((float, Vector3));
	}
}
[Cpp2IlInjected.Token(Token = "0x2000054")]
internal static class BKJDAKJGAIN
{
	[Cpp2IlInjected.Token(Token = "0x6000507")]
	[Cpp2IlInjected.Address(RVA = "0x5462440", Offset = "0x5461840", VA = "0x185462440")]
	public static HMBPIDNECOA NDHEADMHLHM(this PPMDIHPMNCG ONJEPBGIHBB)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000055")]
internal sealed class PFECHJFDADA : EBCDLOKEBCP
{
	[Cpp2IlInjected.Token(Token = "0x40000AA")]
	private const string EMNENHPAIJN = "INTERP_PAUSE";

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000AB")]
	private readonly DGHPEMNHGCH LDDCANHDBNB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000AC")]
	private readonly JMMOMAJEGFM GBHDENEOGJP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000AD")]
	private readonly GDPCJHNBEPD DDCLGMJNJFL;

	[Cpp2IlInjected.Token(Token = "0x1700014C")]
	public bool FKLEIIKAOJF
	{
		[Cpp2IlInjected.Token(Token = "0x6000508")]
		[Cpp2IlInjected.Address(RVA = "0x1B7D4B0", Offset = "0x1B7C8B0", VA = "0x181B7D4B0", Slot = "4")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700014D")]
	public GDPCJHNBEPD MDBJGCBLKKA
	{
		[Cpp2IlInjected.Token(Token = "0x6000509")]
		[Cpp2IlInjected.Address(RVA = "0x6E08E0", Offset = "0x6DFCE0", VA = "0x1806E08E0", Slot = "5")]
		get
		{
			return default(GDPCJHNBEPD);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600050A")]
	[Cpp2IlInjected.Address(RVA = "0x645D5A0", Offset = "0x645C9A0", VA = "0x18645D5A0")]
	public PFECHJFDADA(PPMDIHPMNCG LDDCANHDBNB, in OALOFNDFAEL ONIBEFDCPGD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600050B")]
	[Cpp2IlInjected.Address(RVA = "0x645D070", Offset = "0x645C470", VA = "0x18645D070", Slot = "6")]
	public void BKOELLNKDDF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600050C")]
	[Cpp2IlInjected.Address(RVA = "0x645D140", Offset = "0x645C540", VA = "0x18645D140")]
	private bool EIPAKAFJFHC()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600050D")]
	[Cpp2IlInjected.Address(RVA = "0x645D500", Offset = "0x645C900", VA = "0x18645D500", Slot = "7")]
	public void MPHPJCHHDKL(object AJDBKDIMOHA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600050E")]
	[Cpp2IlInjected.Address(RVA = "0x645D530", Offset = "0x645C930", VA = "0x18645D530", Slot = "8")]
	public void NEGAEOLBLHL(object AJDBKDIMOHA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600050F")]
	[Cpp2IlInjected.Address(RVA = "0x645D1E0", Offset = "0x645C5E0", VA = "0x18645D1E0", Slot = "11")]
	public void HIJAJPCLBLB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000510")]
	[Cpp2IlInjected.Address(RVA = "0x645D310", Offset = "0x645C710", VA = "0x18645D310")]
	private void KDHHGDDDAKA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000511")]
	[Cpp2IlInjected.Address(RVA = "0x645D420", Offset = "0x645C820", VA = "0x18645D420")]
	private void MCILODDNPMG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000512")]
	[Cpp2IlInjected.Address(RVA = "0x645D560", Offset = "0x645C960", VA = "0x18645D560", Slot = "10")]
	public void ONIPMDLLNFC(PPMDIHPMNCG LDDCANHDBNB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000513")]
	[Cpp2IlInjected.Address(RVA = "0x645D030", Offset = "0x645C430", VA = "0x18645D030", Slot = "9")]
	public void BKKMBNFHKCE(PPMDIHPMNCG LDDCANHDBNB)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000056")]
internal sealed class ELFMPBBIGAC : GAMBABDLKNB
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000AF")]
	private readonly DGHPEMNHGCH LDDCANHDBNB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000B0")]
	private readonly JMMOMAJEGFM JFAMPJPIJMM;

	[Cpp2IlInjected.Token(Token = "0x1700014E")]
	public bool MBEHMAPDJBJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000516")]
		[Cpp2IlInjected.Address(RVA = "0x546C2C0", Offset = "0x546B6C0", VA = "0x18546C2C0", Slot = "6")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700014F")]
	public IEnumerable<object> EKIDKKGDMDH
	{
		[Cpp2IlInjected.Token(Token = "0x6000517")]
		[Cpp2IlInjected.Address(RVA = "0x546C580", Offset = "0x546B980", VA = "0x18546C580", Slot = "7")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400004C")]
	public event JPOFABMOGOF JDAOGMBMFNA
	{
		[Cpp2IlInjected.Token(Token = "0x6000514")]
		[Cpp2IlInjected.Address(RVA = "0x546C380", Offset = "0x546B780", VA = "0x18546C380", Slot = "4")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000515")]
		[Cpp2IlInjected.Address(RVA = "0x546C210", Offset = "0x546B610", VA = "0x18546C210", Slot = "5")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000518")]
	[Cpp2IlInjected.Address(RVA = "0x546C6A0", Offset = "0x546BAA0", VA = "0x18546C6A0")]
	public ELFMPBBIGAC(PPMDIHPMNCG LDDCANHDBNB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000519")]
	[Cpp2IlInjected.Address(RVA = "0x546C1B0", Offset = "0x546B5B0", VA = "0x18546C1B0", Slot = "11")]
	public IDisposable BFJJEOKEAOO()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600051A")]
	[Cpp2IlInjected.Address(RVA = "0x546C420", Offset = "0x546B820", VA = "0x18546C420", Slot = "8")]
	public void IDBKKNHMJCA(object AJDBKDIMOHA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600051B")]
	[Cpp2IlInjected.Address(RVA = "0x546C2B0", Offset = "0x546B6B0", VA = "0x18546C2B0", Slot = "9")]
	public void BPLEOILKCFF(object AJDBKDIMOHA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600051C")]
	[Cpp2IlInjected.Address(RVA = "0x546C5A0", Offset = "0x546B9A0", VA = "0x18546C5A0", Slot = "10")]
	public void NHDILIPFEBO(object AJDBKDIMOHA, bool NMHFDHPJGFL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600051D")]
	[Cpp2IlInjected.Address(RVA = "0x546C500", Offset = "0x546B900", VA = "0x18546C500", Slot = "12")]
	public void JPMOLDGLNJO(Rigidbody IHFIBCKLILB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600051E")]
	[Cpp2IlInjected.Address(RVA = "0x546C180", Offset = "0x546B580", VA = "0x18546C180", Slot = "13")]
	public void AAGPIEFPDDG(Rigidbody AOAFHPHKFMD)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000057")]
internal sealed class IDOEAHBJPNN : CGEGJFCCOBC, LNJFNCEGNCA, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000B2")]
	private readonly DGHPEMNHGCH LDDCANHDBNB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000B3")]
	private PhotonView CAIDBGJNFEP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40000B4")]
	private bool PJIOPPPFOBH;

	[Cpp2IlInjected.Token(Token = "0x17000150")]
	public PhotonView KKFANKJJONE
	{
		[Cpp2IlInjected.Token(Token = "0x6000521")]
		[Cpp2IlInjected.Address(RVA = "0x6E4130", Offset = "0x6E3530", VA = "0x1806E4130", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000151")]
	public bool PJPIAHDKHLD
	{
		[Cpp2IlInjected.Token(Token = "0x6000522")]
		[Cpp2IlInjected.Address(RVA = "0x546B670", Offset = "0x546AA70", VA = "0x18546B670", Slot = "7")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000152")]
	public bool EMGPBBGPGIE
	{
		[Cpp2IlInjected.Token(Token = "0x6000523")]
		[Cpp2IlInjected.Address(RVA = "0x810280", Offset = "0x80F680", VA = "0x180810280", Slot = "8")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400004D")]
	public event JPOFABMOGOF OFDNMEKJKBP
	{
		[Cpp2IlInjected.Token(Token = "0x600051F")]
		[Cpp2IlInjected.Address(RVA = "0x5472DA0", Offset = "0x54721A0", VA = "0x185472DA0", Slot = "5")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000520")]
		[Cpp2IlInjected.Address(RVA = "0x5472A10", Offset = "0x5471E10", VA = "0x185472A10", Slot = "6")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000524")]
	[Cpp2IlInjected.Address(RVA = "0x5472E40", Offset = "0x5472240", VA = "0x185472E40")]
	public IDOEAHBJPNN(PPMDIHPMNCG LDDCANHDBNB, in OALOFNDFAEL ONIBEFDCPGD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000525")]
	[Cpp2IlInjected.Address(RVA = "0x5472210", Offset = "0x5471610", VA = "0x185472210", Slot = "9")]
	public void BKOELLNKDDF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000526")]
	[Cpp2IlInjected.Address(RVA = "0x54724F0", Offset = "0x54718F0", VA = "0x1854724F0", Slot = "12")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000527")]
	[Cpp2IlInjected.Address(RVA = "0x5472880", Offset = "0x5471C80", VA = "0x185472880", Slot = "10")]
	public void EDMPHFFCDKG(PPMDIHPMNCG GPFONCECPBK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000528")]
	[Cpp2IlInjected.Address(RVA = "0x5472360", Offset = "0x5471760", VA = "0x185472360", Slot = "11")]
	public void CLFEMCONLMI(PPMDIHPMNCG GPFONCECPBK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000529")]
	[Cpp2IlInjected.Address(RVA = "0x5472C20", Offset = "0x5472020", VA = "0x185472C20")]
	private void JIANJEKONCC(PhotonView MBHHONACMIO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600052A")]
	[Cpp2IlInjected.Address(RVA = "0x5472AB0", Offset = "0x5471EB0", VA = "0x185472AB0")]
	private void IEJGPNIHMFH(RigidbodyEx KEPNDNMPIMB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600052B")]
	[Cpp2IlInjected.Address(RVA = "0x5472600", Offset = "0x5471A00", VA = "0x185472600")]
	private void EDLABONOLPP(PhotonView PEDIMHHLKDL)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000058")]
internal static class AKMBJBHHOPN
{
	[Cpp2IlInjected.Token(Token = "0x600052C")]
	[Cpp2IlInjected.Address(RVA = "0x545FEE0", Offset = "0x545F2E0", VA = "0x18545FEE0")]
	public static CGEGJFCCOBC NBAAFMOGNIN(this PPMDIHPMNCG ONJEPBGIHBB)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000059")]
internal sealed class AGJDEEHBHOA : OIAJBEDDNGM
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000B5")]
	private readonly DGHPEMNHGCH LDDCANHDBNB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000B6")]
	private RigidbodyConstraints AGPNLEHNBIO;

	[Cpp2IlInjected.Token(Token = "0x17000153")]
	public bool PJGCDNLPGAK
	{
		[Cpp2IlInjected.Token(Token = "0x600052D")]
		[Cpp2IlInjected.Address(RVA = "0x7BE930", Offset = "0x7BDD30", VA = "0x1807BE930", Slot = "4")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x600052E")]
		[Cpp2IlInjected.Address(RVA = "0x7BE940", Offset = "0x7BDD40", VA = "0x1807BE940", Slot = "5")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000154")]
	public bool AGHKJBONNGE
	{
		[Cpp2IlInjected.Token(Token = "0x600052F")]
		[Cpp2IlInjected.Address(RVA = "0x2E47D70", Offset = "0x2E47170", VA = "0x182E47D70", Slot = "6")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000530")]
		[Cpp2IlInjected.Address(RVA = "0x2E47D60", Offset = "0x2E47160", VA = "0x182E47D60")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000155")]
	public RigidbodyConstraints BCMJAHAELOH
	{
		[Cpp2IlInjected.Token(Token = "0x6000531")]
		[Cpp2IlInjected.Address(RVA = "0x703080", Offset = "0x702480", VA = "0x180703080", Slot = "7")]
		get
		{
			return default(RigidbodyConstraints);
		}
		[Cpp2IlInjected.Token(Token = "0x6000532")]
		[Cpp2IlInjected.Address(RVA = "0x545DDD0", Offset = "0x545D1D0", VA = "0x18545DDD0", Slot = "8")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000533")]
	[Cpp2IlInjected.Address(RVA = "0x545DF10", Offset = "0x545D310", VA = "0x18545DF10")]
	public AGJDEEHBHOA(PPMDIHPMNCG LDDCANHDBNB, in OALOFNDFAEL ONIBEFDCPGD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000534")]
	[Cpp2IlInjected.Address(RVA = "0x545DDA0", Offset = "0x545D1A0", VA = "0x18545DDA0", Slot = "9")]
	public void JPMOLDGLNJO(Rigidbody AOAFHPHKFMD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000535")]
	[Cpp2IlInjected.Address(RVA = "0x545DD70", Offset = "0x545D170", VA = "0x18545DD70", Slot = "10")]
	public void AAGPIEFPDDG(Rigidbody AOAFHPHKFMD)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200005A")]
internal sealed class MFHGEJLHHAC : KKCAAHMNCAO
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000B9")]
	private readonly PPMDIHPMNCG LDDCANHDBNB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000BA")]
	private float CGCJGLPPNGH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
	[Cpp2IlInjected.Token(Token = "0x40000BB")]
	private float PIFJIAIFNLJ;

	[Cpp2IlInjected.Token(Token = "0x17000156")]
	public float FCGOFCPMIGL
	{
		[Cpp2IlInjected.Token(Token = "0x6000537")]
		[Cpp2IlInjected.Address(RVA = "0x8A55E0", Offset = "0x8A49E0", VA = "0x1808A55E0", Slot = "4")]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x6000538")]
		[Cpp2IlInjected.Address(RVA = "0x547A070", Offset = "0x5479470", VA = "0x18547A070", Slot = "5")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000157")]
	public float CFMIJLIHCIE
	{
		[Cpp2IlInjected.Token(Token = "0x6000539")]
		[Cpp2IlInjected.Address(RVA = "0x8D17E0", Offset = "0x8D0BE0", VA = "0x1808D17E0", Slot = "6")]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x600053A")]
		[Cpp2IlInjected.Address(RVA = "0x547A140", Offset = "0x5479540", VA = "0x18547A140", Slot = "7")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000536")]
	[Cpp2IlInjected.Address(RVA = "0x547A210", Offset = "0x5479610", VA = "0x18547A210")]
	public MFHGEJLHHAC(PPMDIHPMNCG LDDCANHDBNB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600053B")]
	[Cpp2IlInjected.Address(RVA = "0x547A020", Offset = "0x5479420", VA = "0x18547A020", Slot = "8")]
	public void JPMOLDGLNJO(Rigidbody AOAFHPHKFMD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600053C")]
	[Cpp2IlInjected.Address(RVA = "0x5479F80", Offset = "0x5479380", VA = "0x185479F80", Slot = "9")]
	public void AAGPIEFPDDG(Rigidbody AOAFHPHKFMD)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200005B")]
internal sealed class NJCALLHGHJH : BBGIBEMMCOA
{
	[Cpp2IlInjected.Token(Token = "0x40000BC")]
	private const int GKPFGIIGOEG = 10;

	[Cpp2IlInjected.Token(Token = "0x40000BD")]
	private const float AAMHOIOCMGO = 9E-05f;

	[Cpp2IlInjected.Token(Token = "0x40000BE")]
	private const float CLBDJGNMOIE = 0.0001f;

	[Cpp2IlInjected.Token(Token = "0x40000BF")]
	private const float FBHPIPCOGEF = 5f;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000C1")]
	private readonly DGHPEMNHGCH LDDCANHDBNB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000C2")]
	private bool NLJCKFDIEEH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x21")]
	[Cpp2IlInjected.Token(Token = "0x40000C3")]
	private bool OHLFBJIBOLI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
	[Cpp2IlInjected.Token(Token = "0x40000C4")]
	private int JALMONHGNMA;

	[Cpp2IlInjected.Token(Token = "0x17000158")]
	private Rigidbody BAPEKECGLDP
	{
		[Cpp2IlInjected.Token(Token = "0x600053F")]
		[Cpp2IlInjected.Address(RVA = "0x5476320", Offset = "0x5475720", VA = "0x185476320")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000159")]
	private bool HCMEHANPHNC
	{
		[Cpp2IlInjected.Token(Token = "0x6000540")]
		[Cpp2IlInjected.Address(RVA = "0x547EDA0", Offset = "0x547E1A0", VA = "0x18547EDA0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700015A")]
	private bool NFEEOKFPIGD
	{
		[Cpp2IlInjected.Token(Token = "0x6000541")]
		[Cpp2IlInjected.Address(RVA = "0x547F020", Offset = "0x547E420", VA = "0x18547F020")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700015B")]
	private PPMDIHPMNCG EMIBHNNCMJC
	{
		[Cpp2IlInjected.Token(Token = "0x6000542")]
		[Cpp2IlInjected.Address(RVA = "0x547F6F0", Offset = "0x547EAF0", VA = "0x18547F6F0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700015C")]
	private bool DKNFKPAFDPB
	{
		[Cpp2IlInjected.Token(Token = "0x6000543")]
		[Cpp2IlInjected.Address(RVA = "0x547EE40", Offset = "0x547E240", VA = "0x18547EE40")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400004E")]
	public event JPOFABMOGOF MLDKIENLGJG
	{
		[Cpp2IlInjected.Token(Token = "0x600053D")]
		[Cpp2IlInjected.Address(RVA = "0x547EEE0", Offset = "0x547E2E0", VA = "0x18547EEE0", Slot = "4")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600053E")]
		[Cpp2IlInjected.Address(RVA = "0x547EB50", Offset = "0x547DF50", VA = "0x18547EB50", Slot = "5")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000544")]
	[Cpp2IlInjected.Address(RVA = "0x547F750", Offset = "0x547EB50", VA = "0x18547F750")]
	public NJCALLHGHJH(PPMDIHPMNCG LDDCANHDBNB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000545")]
	[Cpp2IlInjected.Address(RVA = "0x547EAC0", Offset = "0x547DEC0", VA = "0x18547EAC0", Slot = "6")]
	public void BKOELLNKDDF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000546")]
	[Cpp2IlInjected.Address(RVA = "0x547EAB0", Offset = "0x547DEB0", VA = "0x18547EAB0", Slot = "8")]
	public void ABJCFICOBMJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000547")]
	[Cpp2IlInjected.Address(RVA = "0x547F0E0", Offset = "0x547E4E0", VA = "0x18547F0E0", Slot = "7")]
	public bool JLGKLAGDNBA()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000548")]
	[Cpp2IlInjected.Address(RVA = "0x547EF80", Offset = "0x547E380", VA = "0x18547EF80", Slot = "9")]
	public void HFOIEEGNPME()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000549")]
	[Cpp2IlInjected.Address(RVA = "0x547F040", Offset = "0x547E440", VA = "0x18547F040", Slot = "11")]
	public void IPODHJMCCPD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600054A")]
	[Cpp2IlInjected.Address(RVA = "0x547EEA0", Offset = "0x547E2A0", VA = "0x18547EEA0", Slot = "12")]
	public void GCGBBMHMBBI(bool DMEOICFENFA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600054B")]
	[Cpp2IlInjected.Address(RVA = "0x547F3C0", Offset = "0x547E7C0", VA = "0x18547F3C0", Slot = "10")]
	public void LHCKEPPOJKM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600054C")]
	[Cpp2IlInjected.Address(RVA = "0x547EBF0", Offset = "0x547DFF0", VA = "0x18547EBF0")]
	private bool DBMAMKHOENP()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600054D")]
	[Cpp2IlInjected.Address(RVA = "0x547F230", Offset = "0x547E630", VA = "0x18547F230")]
	private void JOHNGPOIGFH()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200005C")]
internal sealed class PEMHEEMLFEL : HONAINACCHA
{
	[Cpp2IlInjected.Token(Token = "0x40000C5")]
	private const string MEJHJGGIKBM = "RBEX_ANIM";

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000C6")]
	private readonly DGHPEMNHGCH LDDCANHDBNB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000C7")]
	private readonly JMMOMAJEGFM FBGDDLNIIEO;

	[Cpp2IlInjected.Token(Token = "0x1700015D")]
	public Rigidbody BAPEKECGLDP
	{
		[Cpp2IlInjected.Token(Token = "0x600054E")]
		[Cpp2IlInjected.Address(RVA = "0x6E4130", Offset = "0x6E3530", VA = "0x1806E4130", Slot = "4")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600054F")]
		[Cpp2IlInjected.Address(RVA = "0x7062B0", Offset = "0x7056B0", VA = "0x1807062B0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700015E")]
	private bool DKNFKPAFDPB
	{
		[Cpp2IlInjected.Token(Token = "0x6000550")]
		[Cpp2IlInjected.Address(RVA = "0x54618A0", Offset = "0x5460CA0", VA = "0x1854618A0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000551")]
	[Cpp2IlInjected.Address(RVA = "0x54821E0", Offset = "0x54815E0", VA = "0x1854821E0")]
	public PEMHEEMLFEL(PPMDIHPMNCG LDDCANHDBNB, in OALOFNDFAEL ONIBEFDCPGD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000552")]
	[Cpp2IlInjected.Address(RVA = "0x5481370", Offset = "0x5480770", VA = "0x185481370", Slot = "5")]
	public void BKOELLNKDDF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000553")]
	[Cpp2IlInjected.Address(RVA = "0x5481E50", Offset = "0x5481250", VA = "0x185481E50", Slot = "6")]
	public void NMDKIGJCKAP(object AJDBKDIMOHA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000554")]
	[Cpp2IlInjected.Address(RVA = "0x54817D0", Offset = "0x5480BD0", VA = "0x1854817D0", Slot = "7")]
	public void IGIJDOMADBN(object AJDBKDIMOHA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000555")]
	[Cpp2IlInjected.Address(RVA = "0x5481E80", Offset = "0x5481280", VA = "0x185481E80", Slot = "8")]
	public void OHCCCGHNBBD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000556")]
	[Cpp2IlInjected.Address(RVA = "0x54815D0", Offset = "0x54809D0", VA = "0x1854815D0", Slot = "9")]
	public void GGGGLIFJEPO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000557")]
	[Cpp2IlInjected.Address(RVA = "0x54811F0", Offset = "0x54805F0", VA = "0x1854811F0", Slot = "10")]
	public void AELIAEFBMCN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000558")]
	[Cpp2IlInjected.Address(RVA = "0x5481800", Offset = "0x5480C00", VA = "0x185481800", Slot = "11")]
	public void JNJCHBBCJEP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000559")]
	[Cpp2IlInjected.Address(RVA = "0x5481CA0", Offset = "0x54810A0", VA = "0x185481CA0")]
	private void LCKBPKDNOGE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600055A")]
	[Cpp2IlInjected.Address(RVA = "0x5481420", Offset = "0x5480820", VA = "0x185481420")]
	private void CHFOKHDGJOD()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200005D")]
internal sealed class EOCPBOGNKBE : MPILPIJAHDO, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000C9")]
	private readonly DGHPEMNHGCH LDDCANHDBNB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000CA")]
	private readonly JMMOMAJEGFM GCFNKFOFOPM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000CB")]
	private float IPNBPHLAFFC;

	[Cpp2IlInjected.Token(Token = "0x1700015F")]
	public LKKOPIEOHJA OLDOEMJHCAC
	{
		[Cpp2IlInjected.Token(Token = "0x600055B")]
		[Cpp2IlInjected.Address(RVA = "0x6E42D0", Offset = "0x6E36D0", VA = "0x1806E42D0", Slot = "4")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600055C")]
		[Cpp2IlInjected.Address(RVA = "0x7B2940", Offset = "0x7B1D40", VA = "0x1807B2940", Slot = "5")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000160")]
	public FDHNJKMJJJG AEPCDANKKNF
	{
		[Cpp2IlInjected.Token(Token = "0x600055D")]
		[Cpp2IlInjected.Address(RVA = "0x702560", Offset = "0x701960", VA = "0x180702560", Slot = "6")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600055E")]
		[Cpp2IlInjected.Address(RVA = "0x7530C0", Offset = "0x7524C0", VA = "0x1807530C0", Slot = "7")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000161")]
	public Vector3 MHCLHNEGJDD
	{
		[Cpp2IlInjected.Token(Token = "0x600055F")]
		[Cpp2IlInjected.Address(RVA = "0x546CC60", Offset = "0x546C060", VA = "0x18546CC60", Slot = "8")]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x6000560")]
		[Cpp2IlInjected.Address(RVA = "0x546E010", Offset = "0x546D410", VA = "0x18546E010", Slot = "9")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000162")]
	public Vector3 JMJCCDADJPC
	{
		[Cpp2IlInjected.Token(Token = "0x6000561")]
		[Cpp2IlInjected.Address(RVA = "0x546E570", Offset = "0x546D970", VA = "0x18546E570", Slot = "10")]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x6000562")]
		[Cpp2IlInjected.Address(RVA = "0x546E910", Offset = "0x546DD10", VA = "0x18546E910", Slot = "11")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000163")]
	public Vector3 DLFBGEBKEHJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000563")]
		[Cpp2IlInjected.Address(RVA = "0x546E0D0", Offset = "0x546D4D0", VA = "0x18546E0D0", Slot = "12")]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x6000564")]
		[Cpp2IlInjected.Address(RVA = "0x546EEC0", Offset = "0x546E2C0", VA = "0x18546EEC0", Slot = "13")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000164")]
	public Vector3 KGONIIPAFMK
	{
		[Cpp2IlInjected.Token(Token = "0x6000565")]
		[Cpp2IlInjected.Address(RVA = "0x546EDD0", Offset = "0x546E1D0", VA = "0x18546EDD0", Slot = "14")]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x6000566")]
		[Cpp2IlInjected.Address(RVA = "0x546DA50", Offset = "0x546CE50", VA = "0x18546DA50", Slot = "15")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000165")]
	public float ENFIJFJPIPJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000567")]
		[Cpp2IlInjected.Address(RVA = "0x6F0AE0", Offset = "0x6EFEE0", VA = "0x1806F0AE0", Slot = "16")]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x6000568")]
		[Cpp2IlInjected.Address(RVA = "0x546CD80", Offset = "0x546C180", VA = "0x18546CD80", Slot = "17")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000166")]
	public bool OIAJDGKIDMB
	{
		[Cpp2IlInjected.Token(Token = "0x6000569")]
		[Cpp2IlInjected.Address(RVA = "0x2A42190", Offset = "0x2A41590", VA = "0x182A42190", Slot = "18")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000167")]
	private FGHCKEELDLL MOEIJMAANIJ
	{
		[Cpp2IlInjected.Token(Token = "0x600057E")]
		[Cpp2IlInjected.Address(RVA = "0x27F8760", Offset = "0x27F7B60", VA = "0x1827F8760")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000168")]
	private bool NFEEOKFPIGD
	{
		[Cpp2IlInjected.Token(Token = "0x600057F")]
		[Cpp2IlInjected.Address(RVA = "0x545CB00", Offset = "0x545BF00", VA = "0x18545CB00")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600056A")]
	[Cpp2IlInjected.Address(RVA = "0x546F530", Offset = "0x546E930", VA = "0x18546F530")]
	public EOCPBOGNKBE(PPMDIHPMNCG LDDCANHDBNB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600056B")]
	[Cpp2IlInjected.Address(RVA = "0x546CA50", Offset = "0x546BE50", VA = "0x18546CA50", Slot = "19")]
	public void BKOELLNKDDF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600056C")]
	[Cpp2IlInjected.Address(RVA = "0x546CEE0", Offset = "0x546C2E0", VA = "0x18546CEE0", Slot = "37")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600056D")]
	[Cpp2IlInjected.Address(RVA = "0x546EB70", Offset = "0x546DF70", VA = "0x18546EB70", Slot = "28")]
	public void JPMOLDGLNJO(Rigidbody AOAFHPHKFMD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600056E")]
	[Cpp2IlInjected.Address(RVA = "0x196A640", Offset = "0x1969A40", VA = "0x18196A640", Slot = "20")]
	public void HHNPBMOKIFP(object AJDBKDIMOHA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600056F")]
	[Cpp2IlInjected.Address(RVA = "0x196B400", Offset = "0x196A800", VA = "0x18196B400", Slot = "31")]
	public void NFNEBKIHHFL(object AJDBKDIMOHA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000570")]
	[Cpp2IlInjected.Address(RVA = "0x546CF40", Offset = "0x546C340", VA = "0x18546CF40", Slot = "36")]
	public Vector3 EAJIEBJEBJP(Vector3 ODPCODBLNJO)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000571")]
	[Cpp2IlInjected.Address(RVA = "0x546E750", Offset = "0x546DB50", VA = "0x18546E750", Slot = "35")]
	public Vector3 JGGPKLHDPOC(Vector3 DLOMDLEMEJO)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000572")]
	[Cpp2IlInjected.Address(RVA = "0x546CA50", Offset = "0x546BE50", VA = "0x18546CA50", Slot = "27")]
	public void LNGHCMNGELC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000573")]
	[Cpp2IlInjected.Address(RVA = "0x546CEA0", Offset = "0x546C2A0", VA = "0x18546CEA0", Slot = "25")]
	public void DGADOFDPFDE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000574")]
	[Cpp2IlInjected.Address(RVA = "0x546E530", Offset = "0x546D930", VA = "0x18546E530", Slot = "24")]
	public void IBIENENFOLO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000575")]
	[Cpp2IlInjected.Address(RVA = "0x546D120", Offset = "0x546C520", VA = "0x18546D120", Slot = "34")]
	public void EEIOJCMLKKL(Vector3 PKEOGDHOABC, Vector3 GNHLNIEHAFA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000576")]
	[Cpp2IlInjected.Address(RVA = "0x546CAC0", Offset = "0x546BEC0", VA = "0x18546CAC0", Slot = "33")]
	public void BNKAMLPDNDH(Vector3 IHHIJIKHHIA, Vector3 NBGIHKDGDID)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000577")]
	[Cpp2IlInjected.Address(RVA = "0x546CB20", Offset = "0x546BF20", VA = "0x18546CB20", Slot = "32")]
	public void CADMMMANGFL(Vector3 GJKLLEKAGBH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000578")]
	[Cpp2IlInjected.Address(RVA = "0x546DBC0", Offset = "0x546CFC0", VA = "0x18546DBC0", Slot = "22")]
	public void GOHOEPELEBG(CBPMCKPIBHC EIOPEGEMKHP, Vector3 DKCLOLGBADH, float OOKLCGCBAJI, float LLKLELEIBGC = 8f, float AEEFHMKEOAH = 1f)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000579")]
	[Cpp2IlInjected.Address(RVA = "0x546E940", Offset = "0x546DD40", VA = "0x18546E940", Slot = "21")]
	public void JLNINMHMEHA(BOPFIFMMKBG BPDOBLBNKEN, Vector3 NLFAAHHHDNN, float HHHNHCMFNFA = float.PositiveInfinity)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600057A")]
	[Cpp2IlInjected.Address(RVA = "0x546C780", Offset = "0x546BB80", VA = "0x18546C780", Slot = "23")]
	[Obsolete]
	public void ADCBOLCDFHD(BOPFIFMMKBG BPDOBLBNKEN, Vector3 MCFIHGJCDCP, float BDCHAJELIHL = 7f, float ABPPGEHGCFI = 1f)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600057B")]
	[Cpp2IlInjected.Address(RVA = "0x546F2C0", Offset = "0x546E6C0", VA = "0x18546F2C0", Slot = "30")]
	public Vector3 KPFDHGBBOFB(Vector3 BNEEGIEDHBB)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x600057C")]
	[Cpp2IlInjected.Address(RVA = "0x546D960", Offset = "0x546CD60", VA = "0x18546D960", Slot = "29")]
	public Vector3 FHKEINJELIE(Vector3 IMJEKHOJGKC)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x600057D")]
	[Cpp2IlInjected.Address(RVA = "0x546ECA0", Offset = "0x546E0A0", VA = "0x18546ECA0", Slot = "26")]
	public void KDDHFACBKGB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000580")]
	[Cpp2IlInjected.Address(RVA = "0x546CD80", Offset = "0x546C180", VA = "0x18546CD80")]
	private void CJOOFKCBJCD(float JFBPNBNBHOE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000581")]
	[Cpp2IlInjected.Address(RVA = "0x546DA80", Offset = "0x546CE80", VA = "0x18546DA80")]
	private void GEOKOCNAGLK(Vector3 NLFAAHHHDNN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000582")]
	[Cpp2IlInjected.Address(RVA = "0x546F440", Offset = "0x546E840", VA = "0x18546F440")]
	private Vector3 PAHNCPJEPIJ()
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000583")]
	[Cpp2IlInjected.Address(RVA = "0x546E200", Offset = "0x546D600", VA = "0x18546E200")]
	private void HMLBCCHCNID(Vector3 DLOMDLEMEJO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000584")]
	[Cpp2IlInjected.Address(RVA = "0x546E660", Offset = "0x546DA60", VA = "0x18546E660")]
	private Vector3 JFACHOANBJO()
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000585")]
	[Cpp2IlInjected.Address(RVA = "0x546EF80", Offset = "0x546E380", VA = "0x18546EF80")]
	private void KPADOHKNGPN(Vector3 JFBPNBNBHOE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000586")]
	[Cpp2IlInjected.Address(RVA = "0x546D360", Offset = "0x546C760", VA = "0x18546D360")]
	private void EFAJHPCILNA(Vector3 DLOMDLEMEJO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000587")]
	[Cpp2IlInjected.Address(RVA = "0x546F380", Offset = "0x546E780", VA = "0x18546F380")]
	private void NGKMKMAACHI()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200005E")]
public class AIGJJMGJHJC : KMBOJHAPLLI
{
	[Cpp2IlInjected.Token(Token = "0x6000588")]
	[Cpp2IlInjected.Address(RVA = "0x545FCF0", Offset = "0x545F0F0", VA = "0x18545FCF0", Slot = "4")]
	public HMOOAGCGLKM MJLNOLDLKOJ(PPMDIHPMNCG ONJEPBGIHBB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000589")]
	[Cpp2IlInjected.Address(RVA = "0x545FDD0", Offset = "0x545F1D0", VA = "0x18545FDD0", Slot = "5")]
	public MPILPIJAHDO MOHHJJFOLBM(PPMDIHPMNCG ONJEPBGIHBB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600058A")]
	[Cpp2IlInjected.Address(RVA = "0x545F970", Offset = "0x545ED70", VA = "0x18545F970", Slot = "6")]
	public NPFLLLAFPDM IMEKOCFODBG(PPMDIHPMNCG ONJEPBGIHBB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600058B")]
	[Cpp2IlInjected.Address(RVA = "0x545F770", Offset = "0x545EB70", VA = "0x18545F770", Slot = "7")]
	public KKCAAHMNCAO HEDEOJGLLAC(PPMDIHPMNCG ONJEPBGIHBB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600058C")]
	[Cpp2IlInjected.Address(RVA = "0x545FB30", Offset = "0x545EF30", VA = "0x18545FB30", Slot = "8")]
	public BBGIBEMMCOA JNPIPKPJGAO(PPMDIHPMNCG ONJEPBGIHBB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600058D")]
	[Cpp2IlInjected.Address(RVA = "0x545F7E0", Offset = "0x545EBE0", VA = "0x18545F7E0", Slot = "9")]
	public ODGCKIECBJN HEMHCEJPPBH(PPMDIHPMNCG ONJEPBGIHBB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600058E")]
	[Cpp2IlInjected.Address(RVA = "0x545F4F0", Offset = "0x545E8F0", VA = "0x18545F4F0", Slot = "10")]
	public GAMBABDLKNB GBHLIFIGFGO(PPMDIHPMNCG ONJEPBGIHBB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600058F")]
	[Cpp2IlInjected.Address(RVA = "0x545F6C0", Offset = "0x545EAC0", VA = "0x18545F6C0", Slot = "11")]
	public FGHCKEELDLL HDCLGAJOJOG(PPMDIHPMNCG ONJEPBGIHBB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000590")]
	[Cpp2IlInjected.Address(RVA = "0x545F200", Offset = "0x545E600", VA = "0x18545F200", Slot = "12")]
	public APGGGIKOMPN AJBLCMCEIMG(PPMDIHPMNCG ONJEPBGIHBB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000591")]
	[Cpp2IlInjected.Address(RVA = "0x545FA80", Offset = "0x545EE80", VA = "0x18545FA80", Slot = "13")]
	public LMMEICEFKMM JIMOFCMOFGN(PPMDIHPMNCG ONJEPBGIHBB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000592")]
	[Cpp2IlInjected.Address(RVA = "0x545F3D0", Offset = "0x545E7D0", VA = "0x18545F3D0")]
	public HONAINACCHA EPFJODDPHNJ(PPMDIHPMNCG ONJEPBGIHBB, in OALOFNDFAEL ONIBEFDCPGD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000593")]
	[Cpp2IlInjected.Address(RVA = "0x545F8A0", Offset = "0x545ECA0", VA = "0x18545F8A0")]
	public LNJFNCEGNCA IMOGAPPPDNI(PPMDIHPMNCG ONJEPBGIHBB, in OALOFNDFAEL ONIBEFDCPGD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000594")]
	[Cpp2IlInjected.Address(RVA = "0x545F2B0", Offset = "0x545E6B0", VA = "0x18545F2B0")]
	public EBCDLOKEBCP MEDAGDCIAAG(PPMDIHPMNCG ONJEPBGIHBB, in OALOFNDFAEL ONIBEFDCPGD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000595")]
	[Cpp2IlInjected.Address(RVA = "0x545FBF0", Offset = "0x545EFF0", VA = "0x18545FBF0")]
	public HEFJBMMENIM PIKOPGMPFFO(PPMDIHPMNCG ONJEPBGIHBB, in OALOFNDFAEL ONIBEFDCPGD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000596")]
	[Cpp2IlInjected.Address(RVA = "0x545F5F0", Offset = "0x545E9F0", VA = "0x18545F5F0")]
	public OIAJBEDDNGM NOELAMDCDMI(PPMDIHPMNCG ONJEPBGIHBB, in OALOFNDFAEL ONIBEFDCPGD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000597")]
	[Cpp2IlInjected.Address(RVA = "0x545F320", Offset = "0x545E720", VA = "0x18545F320", Slot = "19")]
	public PPMDIHPMNCG EHCIKDFINKO(RigidbodyEx LDDCANHDBNB, OALOFNDFAEL ONIBEFDCPGD, CMKMIKBKOHM OBOKKBNADPB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000598")]
	[Cpp2IlInjected.Address(RVA = "0x6D6CD0", Offset = "0x6D60D0", VA = "0x1806D6CD0")]
	public AIGJJMGJHJC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000599")]
	[Cpp2IlInjected.Address(RVA = "0x545F3D0", Offset = "0x545E7D0", VA = "0x18545F3D0", Slot = "14")]
	private HONAINACCHA GIPLMECOEDJ(PPMDIHPMNCG ONJEPBGIHBB, in OALOFNDFAEL ONIBEFDCPGD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600059A")]
	[Cpp2IlInjected.Address(RVA = "0x545F8A0", Offset = "0x545ECA0", VA = "0x18545F8A0", Slot = "15")]
	private LNJFNCEGNCA HOCCJMCGJPK(PPMDIHPMNCG ONJEPBGIHBB, in OALOFNDFAEL ONIBEFDCPGD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600059B")]
	[Cpp2IlInjected.Address(RVA = "0x545F2B0", Offset = "0x545E6B0", VA = "0x18545F2B0", Slot = "16")]
	private EBCDLOKEBCP DDDDJCAAJFM(PPMDIHPMNCG ONJEPBGIHBB, in OALOFNDFAEL ONIBEFDCPGD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600059C")]
	[Cpp2IlInjected.Address(RVA = "0x545FBF0", Offset = "0x545EFF0", VA = "0x18545FBF0", Slot = "17")]
	private HEFJBMMENIM KPKGPEKIGJD(PPMDIHPMNCG ONJEPBGIHBB, in OALOFNDFAEL ONIBEFDCPGD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600059D")]
	[Cpp2IlInjected.Address(RVA = "0x545F5F0", Offset = "0x545E9F0", VA = "0x18545F5F0", Slot = "18")]
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
		[Cpp2IlInjected.Token(Token = "0x600059E")]
		[Cpp2IlInjected.Address(RVA = "0x702780", Offset = "0x701B80", VA = "0x180702780")]
		[Preserve]
		public _RRAssemblyIndex()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600059F")]
		[Cpp2IlInjected.Address(RVA = "0x6463530", Offset = "0x6462930", VA = "0x186463530", Slot = "6")]
		public sealed override void ABDNPPIKLOH(FJJGEPPJBDA IGAMPECHIKO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005A0")]
		[Cpp2IlInjected.Address(RVA = "0x6463710", Offset = "0x6462B10", VA = "0x186463710", Slot = "4")]
		public sealed override void FKBDNONAKOB()
		{
		}
	}
}
[StructLayout((LayoutKind)3, CharSet = CharSet.Auto)]
[Cpp2IlInjected.Token(Token = "0x2000060")]
public class EGIIOKJKKGL
{
	[Cpp2IlInjected.Token(Token = "0x40000CE")]
	private static byte[] LAFDEEMEPDM;

	[Cpp2IlInjected.Token(Token = "0x40000CF")]
	private static int AHBPGGLKEKP;

	[Cpp2IlInjected.Token(Token = "0x40000D0")]
	private static int MAHPDNGMMFO;

	[Cpp2IlInjected.Token(Token = "0x40000D1")]
	private static BigInteger NMOJFJKJLEG;

	[Cpp2IlInjected.Token(Token = "0x60005A1")]
	[Cpp2IlInjected.Address(RVA = "0x6D6CD0", Offset = "0x6D60D0", VA = "0x1806D6CD0")]
	public EGIIOKJKKGL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60005A3")]
	[Cpp2IlInjected.Address(RVA = "0x546A5F0", Offset = "0x54699F0", VA = "0x18546A5F0")]
	private static string CIEKLEOAFAL(byte[] GPHMIGDKMEO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60005A4")]
	[Cpp2IlInjected.Address(RVA = "0x546A700", Offset = "0x5469B00", VA = "0x18546A700")]
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

		[Cpp2IlInjected.Token(Token = "0x40000D2")]
		internal static $ArrayType$151 $$field-0;

		[Cpp2IlInjected.Token(Token = "0x60005A5")]
		[Cpp2IlInjected.Address(RVA = "0x6D6CD0", Offset = "0x6D60D0", VA = "0x1806D6CD0")]
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
