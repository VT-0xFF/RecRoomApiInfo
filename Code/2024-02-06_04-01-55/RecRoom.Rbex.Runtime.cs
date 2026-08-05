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
public delegate void FLEHDNMKJOM(RigidbodyEx KPAEDKKOMNN);
[Cpp2IlInjected.Token(Token = "0x2000003")]
public delegate void GANGMHHLDKO(RigidbodyEx KPAEDKKOMNN, bool OHOCKJLAANC = false);
[Cpp2IlInjected.Token(Token = "0x2000004")]
public enum IOIMFMPPEPK
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
public enum GHGNNLJEAHN
{
	[Cpp2IlInjected.Token(Token = "0x4000007")]
	OnlyForReducedPhysicsRateAndNotParenting,
	[Cpp2IlInjected.Token(Token = "0x4000008")]
	Never,
	[Cpp2IlInjected.Token(Token = "0x4000009")]
	OnEvenWhenParenting
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public enum HGAFDACKLPM
{
	[Cpp2IlInjected.Token(Token = "0x400000B")]
	Additive,
	[Cpp2IlInjected.Token(Token = "0x400000C")]
	Override,
	[Cpp2IlInjected.Token(Token = "0x400000D")]
	Reflective
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
[LHLDKFCBMDL(typeof(CMOEJONPKIA), new string[] { "Ignore", "Mock" })]
public class BMJLHIOJKIH : CMOEJONPKIA
{
	[Cpp2IlInjected.Token(Token = "0x17000001")]
	public bool GBGKAJPCFND
	{
		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x7EC020", Offset = "0x7EB420", VA = "0x1807EC020", Slot = "4")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0x7A0900", Offset = "0x79FD00", VA = "0x1807A0900", Slot = "5")]
	public void IGLPNMNLPJC(string FHHKCHCDKKO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x7A0900", Offset = "0x79FD00", VA = "0x1807A0900", Slot = "6")]
	public void EHDFJEJDJEM(RigidbodyEx ICFAMCDBCJP, Action HKJBPIINLDG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x7A0910", Offset = "0x79FD10", VA = "0x1807A0910", Slot = "7")]
	public AIPACPAGJIN DDBOJODNHAJ(int IPHGNNKNFPD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x7A0900", Offset = "0x79FD00", VA = "0x1807A0900", Slot = "8")]
	public void KBEGLEDCANA(Vector3 LFFCENAOLNI, float MMAJDLPMGJB, Color MNHFMCFPMMK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x7A2570", Offset = "0x7A1970", VA = "0x1807A2570")]
	public BMJLHIOJKIH()
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
		private static readonly OKECMMGLCGL NKBEPFMDDIN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000010")]
		private bool CGLEHPADCGO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000011")]
		private JCOFHJBGHJA KPIJBGCPIPH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000012")]
		[SerializeField]
		[DGHLDFIAAAN(PBLEKPGDGOG.Self, false, false, false)]
		private Rigidbody unityRigidbody;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000013")]
		[DGHLDFIAAAN(PBLEKPGDGOG.SelfAndParent, true, false, false)]
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
		private GHGNNLJEAHN physicsInterpolation;

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
		internal JCOFHJBGHJA PBEAHKDNFOA
		{
			[Cpp2IlInjected.Token(Token = "0x600000B")]
			[Cpp2IlInjected.Address(RVA = "0x6655890", Offset = "0x6654C90", VA = "0x186655890")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000003")]
		public IReadOnlyList<RigidbodyEx> BDNCPDNOGEM
		{
			[Cpp2IlInjected.Token(Token = "0x6000021")]
			[Cpp2IlInjected.Address(RVA = "0x7A6820", Offset = "0x7A5C20", VA = "0x1807A6820")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000022")]
			[Cpp2IlInjected.Address(RVA = "0x7A67E0", Offset = "0x7A5BE0", VA = "0x1807A67E0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000004")]
		public RigidbodyEx LAEAHOHNPHI
		{
			[Cpp2IlInjected.Token(Token = "0x6000023")]
			[Cpp2IlInjected.Address(RVA = "0x66572A0", Offset = "0x66566A0", VA = "0x1866572A0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000005")]
		public RigidbodyEx OPHGKOLAGBH
		{
			[Cpp2IlInjected.Token(Token = "0x6000024")]
			[Cpp2IlInjected.Address(RVA = "0x6657200", Offset = "0x6656600", VA = "0x186657200")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000006")]
		public RigidbodyEx EMDODFFCGEF
		{
			[Cpp2IlInjected.Token(Token = "0x6000025")]
			[Cpp2IlInjected.Address(RVA = "0x6657EC0", Offset = "0x66572C0", VA = "0x186657EC0")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000026")]
			[Cpp2IlInjected.Address(RVA = "0x6659440", Offset = "0x6658840", VA = "0x186659440")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000007")]
		public Transform IFEGDDKALIL
		{
			[Cpp2IlInjected.Token(Token = "0x6000027")]
			[Cpp2IlInjected.Address(RVA = "0x7C8540", Offset = "0x7C7940", VA = "0x1807C8540")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000008")]
		public Transform BCEDFGPKPCG
		{
			[Cpp2IlInjected.Token(Token = "0x6000028")]
			[Cpp2IlInjected.Address(RVA = "0x7C8540", Offset = "0x7C7940", VA = "0x1807C8540")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000009")]
		public JFOJKLKDMBJ OKHKDAGKHIN
		{
			[Cpp2IlInjected.Token(Token = "0x6000029")]
			[Cpp2IlInjected.Address(RVA = "0x6656FC0", Offset = "0x66563C0", VA = "0x186656FC0")]
			get
			{
				return default(JFOJKLKDMBJ);
			}
			[Cpp2IlInjected.Token(Token = "0x600002A")]
			[Cpp2IlInjected.Address(RVA = "0x6658BF0", Offset = "0x6657FF0", VA = "0x186658BF0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000A")]
		public bool FFPFCCCKGMP
		{
			[Cpp2IlInjected.Token(Token = "0x600002B")]
			[Cpp2IlInjected.Address(RVA = "0x6657550", Offset = "0x6656950", VA = "0x186657550")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000B")]
		public bool PDPGPNLHDKB
		{
			[Cpp2IlInjected.Token(Token = "0x600002C")]
			[Cpp2IlInjected.Address(RVA = "0x66570E0", Offset = "0x66564E0", VA = "0x1866570E0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000C")]
		public EBGPLIADLBP NPCFNCCEAJO
		{
			[Cpp2IlInjected.Token(Token = "0x600002D")]
			[Cpp2IlInjected.Address(RVA = "0x6657490", Offset = "0x6656890", VA = "0x186657490")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600002E")]
			[Cpp2IlInjected.Address(RVA = "0x6658DB0", Offset = "0x66581B0", VA = "0x186658DB0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000D")]
		public OEEPKCKPLEL LAOMDEGHJLM
		{
			[Cpp2IlInjected.Token(Token = "0x600002F")]
			[Cpp2IlInjected.Address(RVA = "0x6657430", Offset = "0x6656830", VA = "0x186657430")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000030")]
			[Cpp2IlInjected.Address(RVA = "0x6658D40", Offset = "0x6658140", VA = "0x186658D40")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000E")]
		public bool OPLHKLPKLIH
		{
			[Cpp2IlInjected.Token(Token = "0x6000031")]
			[Cpp2IlInjected.Address(RVA = "0x6657380", Offset = "0x6656780", VA = "0x186657380")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000F")]
		public Rigidbody OHEHDKEKPMJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000032")]
			[Cpp2IlInjected.Address(RVA = "0x66573E0", Offset = "0x66567E0", VA = "0x1866573E0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000010")]
		public bool KGIFFCDEOAE
		{
			[Cpp2IlInjected.Token(Token = "0x6000033")]
			[Cpp2IlInjected.Address(RVA = "0x6657140", Offset = "0x6656540", VA = "0x186657140")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000034")]
			[Cpp2IlInjected.Address(RVA = "0x6658C60", Offset = "0x6658060", VA = "0x186658C60")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000011")]
		public bool ACIOPGIAKJL
		{
			[Cpp2IlInjected.Token(Token = "0x6000035")]
			[Cpp2IlInjected.Address(RVA = "0x5E279C0", Offset = "0x5E26DC0", VA = "0x185E279C0")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000036")]
			[Cpp2IlInjected.Address(RVA = "0x5E27E40", Offset = "0x5E27240", VA = "0x185E27E40")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000012")]
		public float JMPLEBOLKFE
		{
			[Cpp2IlInjected.Token(Token = "0x6000037")]
			[Cpp2IlInjected.Address(RVA = "0x6657E60", Offset = "0x6657260", VA = "0x186657E60")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000013")]
		public float FIBNFPBKLOB
		{
			[Cpp2IlInjected.Token(Token = "0x6000038")]
			[Cpp2IlInjected.Address(RVA = "0x6657E00", Offset = "0x6657200", VA = "0x186657E00")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x6000039")]
			[Cpp2IlInjected.Address(RVA = "0x66593D0", Offset = "0x66587D0", VA = "0x1866593D0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000014")]
		public float GKFPPGKMBKH
		{
			[Cpp2IlInjected.Token(Token = "0x600003A")]
			[Cpp2IlInjected.Address(RVA = "0x66577B0", Offset = "0x6656BB0", VA = "0x1866577B0")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x600003B")]
			[Cpp2IlInjected.Address(RVA = "0x6659050", Offset = "0x6658450", VA = "0x186659050")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000015")]
		public float CFIGLOMJFEO
		{
			[Cpp2IlInjected.Token(Token = "0x600003C")]
			[Cpp2IlInjected.Address(RVA = "0x66575B0", Offset = "0x66569B0", VA = "0x1866575B0")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x600003D")]
			[Cpp2IlInjected.Address(RVA = "0x6658E20", Offset = "0x6658220", VA = "0x186658E20")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000016")]
		public bool LCHNEHLIHKO
		{
			[Cpp2IlInjected.Token(Token = "0x600003E")]
			[Cpp2IlInjected.Address(RVA = "0x6658420", Offset = "0x6657820", VA = "0x186658420")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x600003F")]
			[Cpp2IlInjected.Address(RVA = "0x66599A0", Offset = "0x6658DA0", VA = "0x1866599A0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000017")]
		public Vector3 DPEHKDMOCLJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000040")]
			[Cpp2IlInjected.Address(RVA = "0x6657BE0", Offset = "0x6656FE0", VA = "0x186657BE0")]
			get
			{
				return default(Vector3);
			}
			[Cpp2IlInjected.Token(Token = "0x6000041")]
			[Cpp2IlInjected.Address(RVA = "0x66591A0", Offset = "0x66585A0", VA = "0x1866591A0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000018")]
		public Vector3 LFFCENAOLNI
		{
			[Cpp2IlInjected.Token(Token = "0x6000042")]
			[Cpp2IlInjected.Address(RVA = "0x6658560", Offset = "0x6657960", VA = "0x186658560")]
			get
			{
				return default(Vector3);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000019")]
		public CollisionDetectionMode JPNKCLNHOHC
		{
			[Cpp2IlInjected.Token(Token = "0x6000043")]
			[Cpp2IlInjected.Address(RVA = "0x66576F0", Offset = "0x6656AF0", VA = "0x1866576F0")]
			get
			{
				return default(CollisionDetectionMode);
			}
			[Cpp2IlInjected.Token(Token = "0x6000044")]
			[Cpp2IlInjected.Address(RVA = "0x6658F70", Offset = "0x6658370", VA = "0x186658F70")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001A")]
		public float ILJFFAPOBNP
		{
			[Cpp2IlInjected.Token(Token = "0x6000045")]
			[Cpp2IlInjected.Address(RVA = "0x66571A0", Offset = "0x66565A0", VA = "0x1866571A0")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x6000046")]
			[Cpp2IlInjected.Address(RVA = "0x6658CD0", Offset = "0x66580D0", VA = "0x186658CD0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001B")]
		public RigidbodyConstraints PBJBHPLLHKA
		{
			[Cpp2IlInjected.Token(Token = "0x6000047")]
			[Cpp2IlInjected.Address(RVA = "0x6657750", Offset = "0x6656B50", VA = "0x186657750")]
			get
			{
				return default(RigidbodyConstraints);
			}
			[Cpp2IlInjected.Token(Token = "0x6000048")]
			[Cpp2IlInjected.Address(RVA = "0x6658FE0", Offset = "0x66583E0", VA = "0x186658FE0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001C")]
		public Vector3 ONAAMKHHKJO
		{
			[Cpp2IlInjected.Token(Token = "0x6000049")]
			[Cpp2IlInjected.Address(RVA = "0x6657F60", Offset = "0x6657360", VA = "0x186657F60")]
			get
			{
				return default(Vector3);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001D")]
		public Vector3 OOEEJCFEGFG
		{
			[Cpp2IlInjected.Token(Token = "0x600004A")]
			[Cpp2IlInjected.Address(RVA = "0x6657F60", Offset = "0x6657360", VA = "0x186657F60")]
			get
			{
				return default(Vector3);
			}
			[Cpp2IlInjected.Token(Token = "0x600004B")]
			[Cpp2IlInjected.Address(RVA = "0x6659780", Offset = "0x6658B80", VA = "0x186659780")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001E")]
		public float EIGJFJNPCGJ
		{
			[Cpp2IlInjected.Token(Token = "0x600004C")]
			[Cpp2IlInjected.Address(RVA = "0x6657CC0", Offset = "0x66570C0", VA = "0x186657CC0")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x600004D")]
			[Cpp2IlInjected.Address(RVA = "0x6659280", Offset = "0x6658680", VA = "0x186659280")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001F")]
		public float LEAODIIKCIJ
		{
			[Cpp2IlInjected.Token(Token = "0x600004E")]
			[Cpp2IlInjected.Address(RVA = "0x66583C0", Offset = "0x66577C0", VA = "0x1866583C0")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x600004F")]
			[Cpp2IlInjected.Address(RVA = "0x6659930", Offset = "0x6658D30", VA = "0x186659930")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000020")]
		public Quaternion EEKPDDNFFHD
		{
			[Cpp2IlInjected.Token(Token = "0x6000050")]
			[Cpp2IlInjected.Address(RVA = "0x6658040", Offset = "0x6657440", VA = "0x186658040")]
			get
			{
				return default(Quaternion);
			}
			[Cpp2IlInjected.Token(Token = "0x6000051")]
			[Cpp2IlInjected.Address(RVA = "0x6659500", Offset = "0x6658900", VA = "0x186659500")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000021")]
		public Quaternion LPIOAHFAGLJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000052")]
			[Cpp2IlInjected.Address(RVA = "0x66582E0", Offset = "0x66576E0", VA = "0x1866582E0")]
			get
			{
				return default(Quaternion);
			}
			[Cpp2IlInjected.Token(Token = "0x6000053")]
			[Cpp2IlInjected.Address(RVA = "0x6659860", Offset = "0x6658C60", VA = "0x186659860")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000022")]
		public Vector3 PPKMCEPDJHI
		{
			[Cpp2IlInjected.Token(Token = "0x6000054")]
			[Cpp2IlInjected.Address(RVA = "0x6658120", Offset = "0x6657520", VA = "0x186658120")]
			get
			{
				return default(Vector3);
			}
			[Cpp2IlInjected.Token(Token = "0x6000055")]
			[Cpp2IlInjected.Address(RVA = "0x66595D0", Offset = "0x66589D0", VA = "0x1866595D0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000023")]
		public Quaternion CACJPFANIHD
		{
			[Cpp2IlInjected.Token(Token = "0x6000056")]
			[Cpp2IlInjected.Address(RVA = "0x6658200", Offset = "0x6657600", VA = "0x186658200")]
			get
			{
				return default(Quaternion);
			}
			[Cpp2IlInjected.Token(Token = "0x6000057")]
			[Cpp2IlInjected.Address(RVA = "0x66596B0", Offset = "0x6658AB0", VA = "0x1866596B0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000024")]
		public Vector3 KDGFADJDBBB
		{
			[Cpp2IlInjected.Token(Token = "0x6000058")]
			[Cpp2IlInjected.Address(RVA = "0x6658480", Offset = "0x6657880", VA = "0x186658480")]
			get
			{
				return default(Vector3);
			}
			[Cpp2IlInjected.Token(Token = "0x6000059")]
			[Cpp2IlInjected.Address(RVA = "0x6659A10", Offset = "0x6658E10", VA = "0x186659A10")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000025")]
		public Vector3 BNBPPNLIKAM
		{
			[Cpp2IlInjected.Token(Token = "0x600005A")]
			[Cpp2IlInjected.Address(RVA = "0x6657D20", Offset = "0x6657120", VA = "0x186657D20")]
			get
			{
				return default(Vector3);
			}
			[Cpp2IlInjected.Token(Token = "0x600005B")]
			[Cpp2IlInjected.Address(RVA = "0x66592F0", Offset = "0x66586F0", VA = "0x1866592F0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000026")]
		public Vector3 HIEIGGIPFIC
		{
			[Cpp2IlInjected.Token(Token = "0x600005C")]
			[Cpp2IlInjected.Address(RVA = "0x6657610", Offset = "0x6656A10", VA = "0x186657610")]
			get
			{
				return default(Vector3);
			}
			[Cpp2IlInjected.Token(Token = "0x600005D")]
			[Cpp2IlInjected.Address(RVA = "0x6658E90", Offset = "0x6658290", VA = "0x186658E90")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000027")]
		public Vector3 BFLGOPEGDDM
		{
			[Cpp2IlInjected.Token(Token = "0x600005E")]
			[Cpp2IlInjected.Address(RVA = "0x6657B00", Offset = "0x6656F00", VA = "0x186657B00")]
			get
			{
				return default(Vector3);
			}
			[Cpp2IlInjected.Token(Token = "0x600005F")]
			[Cpp2IlInjected.Address(RVA = "0x66590C0", Offset = "0x66584C0", VA = "0x1866590C0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000028")]
		public Vector3 PDEPNANBMPF
		{
			[Cpp2IlInjected.Token(Token = "0x6000060")]
			[Cpp2IlInjected.Address(RVA = "0x66579C0", Offset = "0x6656DC0", VA = "0x1866579C0")]
			get
			{
				return default(Vector3);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000029")]
		public Quaternion KPMPHEDFDBE
		{
			[Cpp2IlInjected.Token(Token = "0x6000061")]
			[Cpp2IlInjected.Address(RVA = "0x66578E0", Offset = "0x6656CE0", VA = "0x1866578E0")]
			get
			{
				return default(Quaternion);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002A")]
		public Vector3 LOMFOFGKPDL
		{
			[Cpp2IlInjected.Token(Token = "0x6000063")]
			[Cpp2IlInjected.Address(RVA = "0x6658720", Offset = "0x6657B20", VA = "0x186658720")]
			get
			{
				return default(Vector3);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002B")]
		public Vector3 OPBNPHGOEDO
		{
			[Cpp2IlInjected.Token(Token = "0x6000064")]
			[Cpp2IlInjected.Address(RVA = "0x6658640", Offset = "0x6657A40", VA = "0x186658640")]
			get
			{
				return default(Vector3);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002C")]
		public bool JEELKKFJOMD
		{
			[Cpp2IlInjected.Token(Token = "0x6000065")]
			[Cpp2IlInjected.Address(RVA = "0x6657AA0", Offset = "0x6656EA0", VA = "0x186657AA0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002D")]
		public bool ALACEGOHBBC
		{
			[Cpp2IlInjected.Token(Token = "0x6000066")]
			[Cpp2IlInjected.Address(RVA = "0x66574F0", Offset = "0x66568F0", VA = "0x1866574F0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002E")]
		public bool BLAOGEILBPI
		{
			[Cpp2IlInjected.Token(Token = "0x6000067")]
			[Cpp2IlInjected.Address(RVA = "0x6657080", Offset = "0x6656480", VA = "0x186657080")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002F")]
		public bool IENLPMCJMAL
		{
			[Cpp2IlInjected.Token(Token = "0x6000068")]
			[Cpp2IlInjected.Address(RVA = "0x6657020", Offset = "0x6656420", VA = "0x186657020")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000030")]
		public bool ALJGPBCFAJC
		{
			[Cpp2IlInjected.Token(Token = "0x6000069")]
			[Cpp2IlInjected.Address(RVA = "0x6656F60", Offset = "0x6656360", VA = "0x186656F60")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000031")]
		public bool ECBEIGOMGMI
		{
			[Cpp2IlInjected.Token(Token = "0x600006A")]
			[Cpp2IlInjected.Address(RVA = "0x6657810", Offset = "0x6656C10", VA = "0x186657810")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000032")]
		public bool HGMIANMMKMJ
		{
			[Cpp2IlInjected.Token(Token = "0x600006B")]
			[Cpp2IlInjected.Address(RVA = "0x51CEA90", Offset = "0x51CDE90", VA = "0x1851CEA90")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000001")]
		public event FLEHDNMKJOM MFHACBEFEFD
		{
			[Cpp2IlInjected.Token(Token = "0x600000F")]
			[Cpp2IlInjected.Address(RVA = "0x6656E80", Offset = "0x6656280", VA = "0x186656E80")]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000010")]
			[Cpp2IlInjected.Address(RVA = "0x6658B10", Offset = "0x6657F10", VA = "0x186658B10")]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000002")]
		public event GANGMHHLDKO GOBNAIPNFGA
		{
			[Cpp2IlInjected.Token(Token = "0x6000011")]
			[Cpp2IlInjected.Address(RVA = "0x6656E10", Offset = "0x6656210", VA = "0x186656E10")]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000012")]
			[Cpp2IlInjected.Address(RVA = "0x6658AA0", Offset = "0x6657EA0", VA = "0x186658AA0")]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000003")]
		public event FLEHDNMKJOM DGFHCDMPNOC
		{
			[Cpp2IlInjected.Token(Token = "0x6000013")]
			[Cpp2IlInjected.Address(RVA = "0x6656B70", Offset = "0x6655F70", VA = "0x186656B70")]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000014")]
			[Cpp2IlInjected.Address(RVA = "0x6658800", Offset = "0x6657C00", VA = "0x186658800")]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000004")]
		public event FLEHDNMKJOM AJNJNDIOIEI
		{
			[Cpp2IlInjected.Token(Token = "0x6000015")]
			[Cpp2IlInjected.Address(RVA = "0x6656BE0", Offset = "0x6655FE0", VA = "0x186656BE0")]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000016")]
			[Cpp2IlInjected.Address(RVA = "0x6658870", Offset = "0x6657C70", VA = "0x186658870")]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000005")]
		public event FLEHDNMKJOM OMOJLBAAJNO
		{
			[Cpp2IlInjected.Token(Token = "0x6000017")]
			[Cpp2IlInjected.Address(RVA = "0x6656D30", Offset = "0x6656130", VA = "0x186656D30")]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000018")]
			[Cpp2IlInjected.Address(RVA = "0x66589C0", Offset = "0x6657DC0", VA = "0x1866589C0")]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000006")]
		public event Action<MMMOHCNLPFL, MMMOHCNLPFL> KKLFFLFCKKL
		{
			[Cpp2IlInjected.Token(Token = "0x6000019")]
			[Cpp2IlInjected.Address(RVA = "0x6656CC0", Offset = "0x66560C0", VA = "0x186656CC0")]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x600001A")]
			[Cpp2IlInjected.Address(RVA = "0x6658950", Offset = "0x6657D50", VA = "0x186658950")]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000007")]
		public event FLEHDNMKJOM KGOLFPKMIIB
		{
			[Cpp2IlInjected.Token(Token = "0x600001B")]
			[Cpp2IlInjected.Address(RVA = "0x6656DA0", Offset = "0x66561A0", VA = "0x186656DA0")]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x600001C")]
			[Cpp2IlInjected.Address(RVA = "0x6658A30", Offset = "0x6657E30", VA = "0x186658A30")]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000008")]
		public event FLEHDNMKJOM EPPLGEAJOGI
		{
			[Cpp2IlInjected.Token(Token = "0x600001D")]
			[Cpp2IlInjected.Address(RVA = "0x6656EF0", Offset = "0x66562F0", VA = "0x186656EF0")]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x600001E")]
			[Cpp2IlInjected.Address(RVA = "0x6658B80", Offset = "0x6657F80", VA = "0x186658B80")]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000009")]
		public event FLEHDNMKJOM PHEOCLOKCBC
		{
			[Cpp2IlInjected.Token(Token = "0x600001F")]
			[Cpp2IlInjected.Address(RVA = "0x6656C50", Offset = "0x6656050", VA = "0x186656C50")]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000020")]
			[Cpp2IlInjected.Address(RVA = "0x66588E0", Offset = "0x6657CE0", VA = "0x1866588E0")]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x7A2710", Offset = "0x7A1B10", VA = "0x1807A2710")]
		internal void AOCOFNJELDA(JCOFHJBGHJA FBIBFNALIEI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x6654650", Offset = "0x6653A50", VA = "0x186654650")]
		internal void AINILNFGDCN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x6656890", Offset = "0x6655C90", VA = "0x186656890")]
		[Conditional("DEBUG_BUILD")]
		[Conditional("UNITY_EDITOR")]
		public void TestOverrideUnityRigidbody(Rigidbody GGPJGAEHLKL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000062")]
		[Cpp2IlInjected.Address(RVA = "0x6656560", Offset = "0x6655960", VA = "0x186656560")]
		public void SetInertiaTensor((Quaternion rot, Vector3 moments) EELLIIPGCJG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006C")]
		[Cpp2IlInjected.Address(RVA = "0x6655030", Offset = "0x6654430", VA = "0x186655030")]
		private void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006D")]
		[Cpp2IlInjected.Address(RVA = "0x6655890", Offset = "0x6654C90", VA = "0x186655890")]
		private JCOFHJBGHJA HLLGBAPKIPA()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600006E")]
		[Cpp2IlInjected.Address(RVA = "0x6655280", Offset = "0x6654680", VA = "0x186655280")]
		private void DLFOKGLGICG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006F")]
		[Cpp2IlInjected.Address(RVA = "0x6655D30", Offset = "0x6655130", VA = "0x186655D30")]
		private void OnEnable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000070")]
		[Cpp2IlInjected.Address(RVA = "0x7A0900", Offset = "0x79FD00", VA = "0x1807A0900")]
		public void OnDisable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000071")]
		[Cpp2IlInjected.Address(RVA = "0x6654650", Offset = "0x6653A50", VA = "0x186654650")]
		private void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000072")]
		[Cpp2IlInjected.Address(RVA = "0x6655CD0", Offset = "0x66550D0", VA = "0x186655CD0")]
		private void OnDrawGizmosSelected()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000073")]
		[Cpp2IlInjected.Address(RVA = "0x6655D90", Offset = "0x6655190", VA = "0x186655D90")]
		private void OnValidate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000074")]
		[Cpp2IlInjected.Address(RVA = "0x66546E0", Offset = "0x6653AE0", VA = "0x1866546E0")]
		public void AddDoNotResetVelocityOnOwnershipChangeOverride(object BDHKJODLPCL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000075")]
		[Cpp2IlInjected.Address(RVA = "0x6655DF0", Offset = "0x66551F0", VA = "0x186655DF0")]
		public void RemoveDoNotResetVelocityOnOwnershipChangeOverride(object BDHKJODLPCL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000076")]
		[Cpp2IlInjected.Address(RVA = "0x6655610", Offset = "0x6654A10", VA = "0x186655610")]
		public void DisableCachedInertialPropertyOverride()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000077")]
		[Cpp2IlInjected.Address(RVA = "0x6655C70", Offset = "0x6655070", VA = "0x186655C70")]
		public void MarkCachedInertialParametersDirty()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000078")]
		[Cpp2IlInjected.Address(RVA = "0x66566C0", Offset = "0x6655AC0", VA = "0x1866566C0")]
		public void SetParent(RigidbodyEx ANJCCKHBJJO, bool OHOCKJLAANC = false)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000079")]
		[Cpp2IlInjected.Address(RVA = "0x6656100", Offset = "0x6655500", VA = "0x186656100")]
		public void ResetLocalCenterOfMassToPrefabDefault()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007A")]
		[Cpp2IlInjected.Address(RVA = "0x6655940", Offset = "0x6654D40", VA = "0x186655940")]
		public bool IsRigidbodyAncestor(RigidbodyEx DHIPEOBMPEO)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600007B")]
		[Cpp2IlInjected.Address(RVA = "0x6655A20", Offset = "0x6654E20", VA = "0x186655A20")]
		public bool IsRigidbodyDescendant(RigidbodyEx OBBAPIPGKBM)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600007C")]
		[Cpp2IlInjected.Address(RVA = "0x6654950", Offset = "0x6653D50", VA = "0x186654950")]
		public void AddInterpolationRestriction(object BDHKJODLPCL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007D")]
		[Cpp2IlInjected.Address(RVA = "0x6655E60", Offset = "0x6655260", VA = "0x186655E60")]
		public void RemoveInterpolationRestriction(object BDHKJODLPCL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007E")]
		[Cpp2IlInjected.Address(RVA = "0x66550A0", Offset = "0x66544A0", VA = "0x1866550A0")]
		public IDisposable BeginKinematicScope()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600007F")]
		[Cpp2IlInjected.Address(RVA = "0x66549C0", Offset = "0x6653DC0", VA = "0x1866549C0")]
		public void AddKinematic(object BDHKJODLPCL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000080")]
		[Cpp2IlInjected.Address(RVA = "0x6655ED0", Offset = "0x66552D0", VA = "0x186655ED0")]
		public void RemoveKinematic(object BDHKJODLPCL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000081")]
		[Cpp2IlInjected.Address(RVA = "0x6656640", Offset = "0x6655A40", VA = "0x186656640")]
		public void SetKinematic(object BDHKJODLPCL, bool JEKJDJALDPH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000082")]
		[Cpp2IlInjected.Address(RVA = "0x6656460", Offset = "0x6655860", VA = "0x186656460")]
		public void SetDiscontinuousPositionAndRotation(Vector3 IFADGICOBNM, Quaternion JJGEHCBPHJF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000083")]
		[Cpp2IlInjected.Address(RVA = "0x6656360", Offset = "0x6655760", VA = "0x186656360")]
		public void SetDiscontinuousLocalPositionAndLocalRotation(Vector3 HJMGIFNAIIP, Quaternion PDEPBHFDPFN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000084")]
		[Cpp2IlInjected.Address(RVA = "0x6655780", Offset = "0x6654B80", VA = "0x186655780")]
		public Vector3 GetConstrainedVelocity(Vector3 KDGFADJDBBB)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x6000085")]
		[Cpp2IlInjected.Address(RVA = "0x6655670", Offset = "0x6654A70", VA = "0x186655670")]
		public Vector3 GetConstrainedAngularVelocity(Vector3 HIEIGGIPFIC)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x6000086")]
		[Cpp2IlInjected.Address(RVA = "0x6654860", Offset = "0x6653C60", VA = "0x186654860")]
		public void AddForce(Vector3 BICEHKAFMDO, ForceMode NIBLDDDDGAO = ForceMode.Force)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000087")]
		[Cpp2IlInjected.Address(RVA = "0x6654750", Offset = "0x6653B50", VA = "0x186654750")]
		public void AddForceAtPosition(Vector3 BICEHKAFMDO, Vector3 BEBKKMFGLCG, ForceMode NIBLDDDDGAO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000088")]
		[Cpp2IlInjected.Address(RVA = "0x6654B90", Offset = "0x6653F90", VA = "0x186654B90")]
		public void AddTorque(Vector3 IMFJIBNAPMK, ForceMode NIBLDDDDGAO = ForceMode.Force)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000089")]
		[Cpp2IlInjected.Address(RVA = "0x6654A30", Offset = "0x6653E30", VA = "0x186654A30")]
		public void AddRelativeTorque(Vector3 IMFJIBNAPMK, ForceMode NIBLDDDDGAO = ForceMode.Force)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008A")]
		[Cpp2IlInjected.Address(RVA = "0x6656960", Offset = "0x6655D60", VA = "0x186656960")]
		public Vector3 WorldToLocalVelocity(Vector3 ANEKCENIKFN)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x600008B")]
		[Cpp2IlInjected.Address(RVA = "0x6655B60", Offset = "0x6654F60", VA = "0x186655B60")]
		public Vector3 LocalToWorldVelocity(Vector3 BNBPPNLIKAM)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x600008C")]
		[Cpp2IlInjected.Address(RVA = "0x6655220", Offset = "0x6654620", VA = "0x186655220")]
		public void ClearVelocity()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008D")]
		[Cpp2IlInjected.Address(RVA = "0x66551C0", Offset = "0x66545C0", VA = "0x1866551C0")]
		public void ClearUnityRigidbodyVelocity()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008E")]
		[Cpp2IlInjected.Address(RVA = "0x6655160", Offset = "0x6654560", VA = "0x186655160")]
		public void ClearLinearVelocity()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008F")]
		[Cpp2IlInjected.Address(RVA = "0x6655100", Offset = "0x6654500", VA = "0x186655100")]
		public void ClearAngularVelocity()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000090")]
		[Cpp2IlInjected.Address(RVA = "0x6656260", Offset = "0x6655660", VA = "0x186656260")]
		public void ResetVelocityWorldSpace(Vector3 FHLIJFCHIPI, Vector3 NEMLBHKHIJF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000091")]
		[Cpp2IlInjected.Address(RVA = "0x6656160", Offset = "0x6655560", VA = "0x186656160")]
		public void ResetVelocityLocalSpace(Vector3 KAAALJHMPDH, Vector3 BFLGOPEGDDM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000092")]
		[Cpp2IlInjected.Address(RVA = "0x6656020", Offset = "0x6655420", VA = "0x186656020")]
		public void ResetLinearVelocityLocalSpace(Vector3 KAAALJHMPDH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000093")]
		[Cpp2IlInjected.Address(RVA = "0x66567F0", Offset = "0x6655BF0", VA = "0x1866567F0")]
		public bool SweepTest(Vector3 PNADBCDBNOL, [Out] RaycastHit FDAHIHAIBKD, float FIOIECEGGAH)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000094")]
		[Cpp2IlInjected.Address(RVA = "0x6655B00", Offset = "0x6654F00", VA = "0x186655B00")]
		public bool IsSleeping()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000095")]
		[Cpp2IlInjected.Address(RVA = "0x6656790", Offset = "0x6655B90", VA = "0x186656790")]
		public void Sleep()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000096")]
		[Cpp2IlInjected.Address(RVA = "0x6656900", Offset = "0x6655D00", VA = "0x186656900")]
		public void WakeUp()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000097")]
		[Cpp2IlInjected.Address(RVA = "0x6654B20", Offset = "0x6653F20", VA = "0x186654B20")]
		public void AddShouldHaveUnityRigidbodyToken(object BDHKJODLPCL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000098")]
		[Cpp2IlInjected.Address(RVA = "0x6655F40", Offset = "0x6655340", VA = "0x186655F40")]
		public void RemoveShouldHaveUnityRigidbodyToken(object BDHKJODLPCL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000099")]
		[Cpp2IlInjected.Address(RVA = "0x6654EC0", Offset = "0x66542C0", VA = "0x186654EC0")]
		public void ApplyForceVelocityChange(IOIMFMPPEPK JJCOMEIHIFG, Vector3 LOPBIAGCJBL, float DJHFDGIPKCO, float GJGOKKJEDGM = 8f, float KHKMMDAMJPL = 1f)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009A")]
		[Cpp2IlInjected.Address(RVA = "0x6654E20", Offset = "0x6654220", VA = "0x186654E20")]
		public void ApplyAngularVelocityChange(HGAFDACKLPM ALPAKFKNNFG, Vector3 JMPMBOKBENO, float MGEJKMAAPFM = float.PositiveInfinity)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009B")]
		[Cpp2IlInjected.Address(RVA = "0x6654F80", Offset = "0x6654380", VA = "0x186654F80")]
		[Obsolete("Deprecated. Still exists to support deprecated CV2 chips. Use ApplyAngularVelocityChange.")]
		public void ApplyTorqueAngularVelocityChangeDeprecated(HGAFDACKLPM ALPAKFKNNFG, Vector3 IKFFGJBHBIC, float KIDOONEEGII = 7f, float HDJMHGGGNBA = 1f)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009C")]
		[Cpp2IlInjected.Address(RVA = "0x6654D50", Offset = "0x6654150", VA = "0x186654D50")]
		public bool AllowedScaleChange(float COMNKNINMAC)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600009D")]
		[Cpp2IlInjected.Address(RVA = "0x6654C80", Offset = "0x6654080", VA = "0x186654C80")]
		public void AddWorldSpaceVelocityInHierarchyParentOverride(RigidbodyEx OFCMPLLCIEA, object BDHKJODLPCL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009E")]
		[Cpp2IlInjected.Address(RVA = "0x6655FB0", Offset = "0x66553B0", VA = "0x186655FB0")]
		public void RemoveWorldSpaceVelocityInHierarchyParentOverride(object BDHKJODLPCL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009F")]
		[Cpp2IlInjected.Address(RVA = "0x6656B00", Offset = "0x6655F00", VA = "0x186656B00")]
		public RigidbodyEx()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
internal static class NNHNOHNEMGF
{
	[Cpp2IlInjected.Token(Token = "0x60000A4")]
	[Cpp2IlInjected.Address(RVA = "0x664EFD0", Offset = "0x664E3D0", VA = "0x18664EFD0")]
	public static JCOFHJBGHJA PBEAHKDNFOA(this RigidbodyEx ICFAMCDBCJP)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
public struct OEDKMOJJJDN
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001D")]
	public Rigidbody ADEHOEHEFLF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x400001E")]
	public PhotonView DPHNICNACME;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400001F")]
	public OverridableVector3 CGLGBHHNCJG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000020")]
	public OverridableVector3 DLHCFNKIEFE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000021")]
	public GHGNNLJEAHN DEAMFKGMENA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
	[Cpp2IlInjected.Token(Token = "0x4000022")]
	public bool JLMLMPLJCCM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x35")]
	[Cpp2IlInjected.Token(Token = "0x4000023")]
	public bool BNOCJCJJEBB;
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
[LHLDKFCBMDL(typeof(FCIHFBGEFGG), new string[] { })]
public class OOELGBPNDMF : FCIHFBGEFGG, MPDHAHPLHCI
{
	[Cpp2IlInjected.Token(Token = "0x4000024")]
	private static readonly OKECMMGLCGL ECHPFBNKINH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000025")]
	private FKEJGOFEJBL LFIJAELPCCM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000026")]
	private CMOEJONPKIA LBELJDFAMCF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000027")]
	private IJKJBKAFLOD HDJMFBLNBCP;

	[Cpp2IlInjected.Token(Token = "0x17000033")]
	public CMOEJONPKIA ANIHPGDPKNA
	{
		[Cpp2IlInjected.Token(Token = "0x60000A5")]
		[Cpp2IlInjected.Address(RVA = "0x7A2690", Offset = "0x7A1A90", VA = "0x1807A2690", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000034")]
	public IJKJBKAFLOD DCFKMHLPLHE
	{
		[Cpp2IlInjected.Token(Token = "0x60000A6")]
		[Cpp2IlInjected.Address(RVA = "0x7A2680", Offset = "0x7A1A80", VA = "0x1807A2680", Slot = "5")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000A7")]
	[Cpp2IlInjected.Address(RVA = "0x6651880", Offset = "0x6650C80", VA = "0x186651880", Slot = "8")]
	public void InitReferences(DOHCFJAHLBK DKKCBCANDII)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A8")]
	[Cpp2IlInjected.Address(RVA = "0x6651910", Offset = "0x6650D10", VA = "0x186651910", Slot = "6")]
	public FNONGLLGKNI JKHOPNONHBO(RigidbodyEx ICFAMCDBCJP)
	{
		return default(FNONGLLGKNI);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A9")]
	[Cpp2IlInjected.Address(RVA = "0x66517B0", Offset = "0x6650BB0", VA = "0x1866517B0")]
	private static FNONGLLGKNI EFDLDHNPHGL(RigidbodyEx ICFAMCDBCJP)
	{
		return default(FNONGLLGKNI);
	}

	[Cpp2IlInjected.Token(Token = "0x60000AA")]
	[Cpp2IlInjected.Address(RVA = "0x6651710", Offset = "0x6650B10", VA = "0x186651710", Slot = "7")]
	public JCOFHJBGHJA DJNICONLOON(RigidbodyEx ICFAMCDBCJP, OEDKMOJJJDN ALPLHOOHPEL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000AB")]
	[Cpp2IlInjected.Address(RVA = "0x7A2570", Offset = "0x7A1970", VA = "0x1807A2570")]
	public OOELGBPNDMF()
	{
	}
}
namespace RecRoom
{
	[Cpp2IlInjected.Token(Token = "0x200000D")]
	public class PhysicsManager : SingletonMonoBehaviour<PhysicsManager>
	{
		[Cpp2IlInjected.Token(Token = "0x4000028")]
		public static DICJLHNIKOO UpdateAfterFixedUpdateRan;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000029")]
		private int GHNJJOOOPNC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x400002A")]
		private int HAINFAKEIEJ;

		[Cpp2IlInjected.Token(Token = "0x60000AD")]
		[Cpp2IlInjected.Address(RVA = "0x66544B0", Offset = "0x66538B0", VA = "0x1866544B0")]
		protected void FixedUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AE")]
		[Cpp2IlInjected.Address(RVA = "0x66544F0", Offset = "0x66538F0", VA = "0x1866544F0")]
		protected void Update()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AF")]
		[Cpp2IlInjected.Address(RVA = "0x66544D0", Offset = "0x66538D0", VA = "0x1866544D0")]
		protected void LateUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B0")]
		[Cpp2IlInjected.Address(RVA = "0x7A0900", Offset = "0x79FD00", VA = "0x1807A0900")]
		[Conditional("UNITY_ASSERTIONS")]
		public void AssertLateColliderPositionsNotYetUpdated([Optional] string CAIOIMEOMNJ, [Optional] UnityEngine.Object HFPPGLCONIA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B1")]
		[Cpp2IlInjected.Address(RVA = "0x7A0900", Offset = "0x79FD00", VA = "0x1807A0900")]
		[Conditional("UNITY_ASSERTIONS")]
		public void AssertLateColliderPositionsAlreadyUpdated([Optional] string CAIOIMEOMNJ, [Optional] UnityEngine.Object HFPPGLCONIA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B2")]
		[Cpp2IlInjected.Address(RVA = "0x6654600", Offset = "0x6653A00", VA = "0x186654600")]
		public PhysicsManager()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
public static class NAFLPBCDIBD
{
	[Cpp2IlInjected.Token(Token = "0x60000B4")]
	[Cpp2IlInjected.Address(RVA = "0x664E840", Offset = "0x664DC40", VA = "0x18664E840")]
	public static void GLEFDLFCECI(this Rigidbody GGPJGAEHLKL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B5")]
	[Cpp2IlInjected.Address(RVA = "0x664E710", Offset = "0x664DB10", VA = "0x18664E710")]
	public static void GLEFDLFCECI(this Rigidbody GGPJGAEHLKL, Vector3 GGMDNBONCAA, Quaternion KPMPHEDFDBE, Vector3 GEELLLPFIAM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B6")]
	[Cpp2IlInjected.Address(RVA = "0xC3A310", Offset = "0xC39710", VA = "0x180C3A310")]
	public static void HOGMFKMHMDO(Vector3 KDGFADJDBBB, Vector3 PKPPJECMOIC, [Out] Vector3 DDMCHEGCPAA, [Out] Vector3 ANJIGBLPMPI)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000F")]
public static class ENEBMKFAIEE
{
	[Cpp2IlInjected.Token(Token = "0x2000010")]
	private class OKFFKJCBAGH : EBGPLIADLBP, IDisposable
	{
		[Cpp2IlInjected.Token(Token = "0x60000B9")]
		[Cpp2IlInjected.Address(RVA = "0x7A0900", Offset = "0x79FD00", VA = "0x1807A0900", Slot = "6")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000BA")]
		[Cpp2IlInjected.Address(RVA = "0x7AF990", Offset = "0x7AED90", VA = "0x1807AF990", Slot = "4")]
		public Vector3 CGAPCGBJFJN()
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x60000BB")]
		[Cpp2IlInjected.Address(RVA = "0x7AF990", Offset = "0x7AED90", VA = "0x1807AF990", Slot = "5")]
		public Vector3 KPHJPJGFJHA()
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x60000BC")]
		[Cpp2IlInjected.Address(RVA = "0x7A2570", Offset = "0x7A1970", VA = "0x1807A2570")]
		public OKFFKJCBAGH()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000035")]
	public static EBGPLIADLBP NAKPDDMMNAN
	{
		[Cpp2IlInjected.Token(Token = "0x60000B7")]
		[Cpp2IlInjected.Address(RVA = "0x66438B0", Offset = "0x6642CB0", VA = "0x1866438B0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
public interface NDECPKLCGPL
{
	[Cpp2IlInjected.Token(Token = "0x17000036")]
	CollisionDetectionMode BMACCDICLGG
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
	void AHALPFGPHOF();

	[Cpp2IlInjected.Token(Token = "0x60000C0")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void GCEKOKLNFKE(bool JEELKKFJOMD);

	[Cpp2IlInjected.Token(Token = "0x60000C1")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void FCIGBFFNGFJ(bool JEELKKFJOMD);

	[Cpp2IlInjected.Token(Token = "0x60000C2")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void AEMAJDMNPCO(Rigidbody ADEHOEHEFLF);

	[Cpp2IlInjected.Token(Token = "0x60000C3")]
	[Cpp2IlInjected.Address(Slot = "6")]
	bool HMFCJNOKJNG(Vector3 PNADBCDBNOL, [Out] RaycastHit FDAHIHAIBKD, float FIOIECEGGAH);
}
[Cpp2IlInjected.Token(Token = "0x2000012")]
public interface NHEBLBOICHI : IDisposable, AMAGPLIHPFI
{
	[Cpp2IlInjected.Token(Token = "0x17000037")]
	GOOCPGCLLJK OKHKDAGKHIN
	{
		[Cpp2IlInjected.Token(Token = "0x60000C6")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
		[Cpp2IlInjected.Token(Token = "0x60000C7")]
		[Cpp2IlInjected.Address(Slot = "3")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x1400000A")]
	event Action<MMMOHCNLPFL, MMMOHCNLPFL> KKLFFLFCKKL;

	[Cpp2IlInjected.Token(Token = "0x60000C8")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void AHALPFGPHOF();
}
[Cpp2IlInjected.Token(Token = "0x2000013")]
[DKGHNNODKMB(NKCLGJJOGJC.Application)]
public interface IJKJBKAFLOD
{
	[Cpp2IlInjected.Token(Token = "0x60000C9")]
	[Cpp2IlInjected.Address(Slot = "0")]
	DFEBEBBPEII EBNPOOMGDOG(JCOFHJBGHJA FBIBFNALIEI);

	[Cpp2IlInjected.Token(Token = "0x60000CA")]
	[Cpp2IlInjected.Address(Slot = "1")]
	LNECPEEFLAO NPKBHLDACOA(JCOFHJBGHJA FBIBFNALIEI);

	[Cpp2IlInjected.Token(Token = "0x60000CB")]
	[Cpp2IlInjected.Address(Slot = "2")]
	JJMHLHBDECD MOBLLBNBCPK(JCOFHJBGHJA FBIBFNALIEI);

	[Cpp2IlInjected.Token(Token = "0x60000CC")]
	[Cpp2IlInjected.Address(Slot = "3")]
	LHIPGJNPCPA OMIEKPOLDKI(JCOFHJBGHJA FBIBFNALIEI);

	[Cpp2IlInjected.Token(Token = "0x60000CD")]
	[Cpp2IlInjected.Address(Slot = "4")]
	OCGFIHDLMDE FNKDNGDEIEK(JCOFHJBGHJA FBIBFNALIEI);

	[Cpp2IlInjected.Token(Token = "0x60000CE")]
	[Cpp2IlInjected.Address(Slot = "5")]
	NHEBLBOICHI MPKPENFLCNG(JCOFHJBGHJA FBIBFNALIEI);

	[Cpp2IlInjected.Token(Token = "0x60000CF")]
	[Cpp2IlInjected.Address(Slot = "6")]
	FPLEKLLPLHN IMMJNPIHOJJ(JCOFHJBGHJA FBIBFNALIEI);

	[Cpp2IlInjected.Token(Token = "0x60000D0")]
	[Cpp2IlInjected.Address(Slot = "7")]
	PNBKJNMIIDD IBPBDCABMKN(JCOFHJBGHJA FBIBFNALIEI);

	[Cpp2IlInjected.Token(Token = "0x60000D1")]
	[Cpp2IlInjected.Address(Slot = "8")]
	NDECPKLCGPL BPKOFLMIBEG(JCOFHJBGHJA FBIBFNALIEI);

	[Cpp2IlInjected.Token(Token = "0x60000D2")]
	[Cpp2IlInjected.Address(Slot = "9")]
	APDCPHMDBJE EDEKKNKAMCK(JCOFHJBGHJA FBIBFNALIEI);

	[Cpp2IlInjected.Token(Token = "0x60000D3")]
	[Cpp2IlInjected.Address(Slot = "10")]
	BOKFNFEEHEN IEEKJCJAPCM(JCOFHJBGHJA FBIBFNALIEI, [In] OEDKMOJJJDN ALPLHOOHPEL);

	[Cpp2IlInjected.Token(Token = "0x60000D4")]
	[Cpp2IlInjected.Address(Slot = "11")]
	NMOCGBHDPAJ OAPJLHDNABE(JCOFHJBGHJA FBIBFNALIEI, [In] OEDKMOJJJDN ALPLHOOHPEL);

	[Cpp2IlInjected.Token(Token = "0x60000D5")]
	[Cpp2IlInjected.Address(Slot = "12")]
	BECBDCABJBI PJCBMPIGMMK(JCOFHJBGHJA FBIBFNALIEI, [In] OEDKMOJJJDN ALPLHOOHPEL);

	[Cpp2IlInjected.Token(Token = "0x60000D6")]
	[Cpp2IlInjected.Address(Slot = "13")]
	KPKDIHHLHAL NPPPBIHCIGI(JCOFHJBGHJA FBIBFNALIEI, [In] OEDKMOJJJDN ALPLHOOHPEL);

	[Cpp2IlInjected.Token(Token = "0x60000D7")]
	[Cpp2IlInjected.Address(Slot = "14")]
	KMAFPEDBELG OCNEKCODBFB(JCOFHJBGHJA FBIBFNALIEI, [In] OEDKMOJJJDN ALPLHOOHPEL);

	[Cpp2IlInjected.Token(Token = "0x60000D8")]
	[Cpp2IlInjected.Address(Slot = "15")]
	JCOFHJBGHJA DJNICONLOON(RigidbodyEx ICFAMCDBCJP, OEDKMOJJJDN ALPLHOOHPEL, FCIHFBGEFGG IALOIPDIIAG);
}
[Cpp2IlInjected.Token(Token = "0x2000014")]
public interface PNBKJNMIIDD
{
	[Cpp2IlInjected.Token(Token = "0x60000D9")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void EOGJEEPJDGB(Vector3 BICEHKAFMDO, ForceMode NIBLDDDDGAO = ForceMode.Force);

	[Cpp2IlInjected.Token(Token = "0x60000DA")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void EGMCEHGBFBK(Vector3 BICEHKAFMDO, Vector3 BEBKKMFGLCG, ForceMode NIBLDDDDGAO);

	[Cpp2IlInjected.Token(Token = "0x60000DB")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void DACJEFDGIGP(Vector3 IMFJIBNAPMK, ForceMode NIBLDDDDGAO = ForceMode.Force);

	[Cpp2IlInjected.Token(Token = "0x60000DC")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void JCCBIGPFMFC(Vector3 IMFJIBNAPMK, ForceMode NIBLDDDDGAO = ForceMode.Force);
}
[Cpp2IlInjected.Token(Token = "0x2000015")]
public interface APDCPHMDBJE
{
	[Cpp2IlInjected.Token(Token = "0x17000038")]
	bool PPOPHDEHNNA
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
	void AEMAJDMNPCO(Rigidbody ADEHOEHEFLF);

	[Cpp2IlInjected.Token(Token = "0x60000E0")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void OLACCOJPAIO(Rigidbody ADEHOEHEFLF);
}
[Cpp2IlInjected.Token(Token = "0x2000016")]
public interface DFEBEBBPEII : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x17000039")]
	IReadOnlyList<JCOFHJBGHJA> OPIGCLHIKGM
	{
		[Cpp2IlInjected.Token(Token = "0x60000F3")]
		[Cpp2IlInjected.Address(Slot = "18")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700003A")]
	JCOFHJBGHJA OPHGKOLAGBH
	{
		[Cpp2IlInjected.Token(Token = "0x60000F4")]
		[Cpp2IlInjected.Address(Slot = "19")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700003B")]
	JCOFHJBGHJA EOGAOJCDEEE
	{
		[Cpp2IlInjected.Token(Token = "0x60000F5")]
		[Cpp2IlInjected.Address(Slot = "20")]
		get;
		[Cpp2IlInjected.Token(Token = "0x60000F6")]
		[Cpp2IlInjected.Address(Slot = "21")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x1400000B")]
	event FLEHDNMKJOM DGFHCDMPNOC;

	[Cpp2IlInjected.Token(Token = "0x1400000C")]
	event FLEHDNMKJOM AJNJNDIOIEI;

	[Cpp2IlInjected.Token(Token = "0x1400000D")]
	event GANGMHHLDKO EAAJADAMIEB;

	[Cpp2IlInjected.Token(Token = "0x1400000E")]
	event Action HGBAPGIEKIL;

	[Cpp2IlInjected.Token(Token = "0x1400000F")]
	event Action PJNMCFKMOFA;

	[Cpp2IlInjected.Token(Token = "0x14000010")]
	event Action<JCOFHJBGHJA> FLGHEEMILPM;

	[Cpp2IlInjected.Token(Token = "0x14000011")]
	event Action<JCOFHJBGHJA> HCIHFOBNDID;

	[Cpp2IlInjected.Token(Token = "0x14000012")]
	event Action MNPKJEPOBON;

	[Cpp2IlInjected.Token(Token = "0x14000013")]
	event Action<JCOFHJBGHJA> OFPCHFBMHAN;

	[Cpp2IlInjected.Token(Token = "0x60000F7")]
	[Cpp2IlInjected.Address(Slot = "22")]
	void IPJNFPFPNEM(JCOFHJBGHJA FOONBHGCLLE, bool OHOCKJLAANC = false);
}
[Cpp2IlInjected.Token(Token = "0x2000017")]
public interface JJMHLHBDECD
{
	[Cpp2IlInjected.Token(Token = "0x1700003C")]
	Vector3 JAEHHIFFHAO
	{
		[Cpp2IlInjected.Token(Token = "0x60000F8")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700003D")]
	Vector3 DBENDJKNCLA
	{
		[Cpp2IlInjected.Token(Token = "0x60000F9")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x60000FA")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void PPDBDEBJGCD(JCOFHJBGHJA EMDODFFCGEF, object BDHKJODLPCL);

	[Cpp2IlInjected.Token(Token = "0x60000FB")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void DJBONJGLIDM(object BDHKJODLPCL);
}
[Cpp2IlInjected.Token(Token = "0x2000018")]
public interface KPKDIHHLHAL
{
	[Cpp2IlInjected.Token(Token = "0x1700003E")]
	Vector3 DKCKPGONLCO
	{
		[Cpp2IlInjected.Token(Token = "0x60000FE")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
		[Cpp2IlInjected.Token(Token = "0x60000FF")]
		[Cpp2IlInjected.Address(Slot = "3")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x1700003F")]
	Vector3 EAIFIKDGKFD
	{
		[Cpp2IlInjected.Token(Token = "0x6000100")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000040")]
	float LOOBEDBGKGP
	{
		[Cpp2IlInjected.Token(Token = "0x6000101")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000041")]
	float LLPPBNBJAIJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000102")]
		[Cpp2IlInjected.Address(Slot = "6")]
		get;
		[Cpp2IlInjected.Token(Token = "0x6000103")]
		[Cpp2IlInjected.Address(Slot = "7")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000042")]
	Vector3 GPBCJEBAHGH
	{
		[Cpp2IlInjected.Token(Token = "0x6000104")]
		[Cpp2IlInjected.Address(Slot = "8")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000043")]
	Quaternion PNNPLKIEMEL
	{
		[Cpp2IlInjected.Token(Token = "0x6000105")]
		[Cpp2IlInjected.Address(Slot = "9")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x14000014")]
	event FLEHDNMKJOM JAEBJNGECMP;

	[Cpp2IlInjected.Token(Token = "0x6000106")]
	[Cpp2IlInjected.Address(Slot = "10")]
	void PFEPHKNMKPF((Quaternion rot, Vector3 moments) EELLIIPGCJG);

	[Cpp2IlInjected.Token(Token = "0x6000107")]
	[Cpp2IlInjected.Address(Slot = "11")]
	void KNGNMHHLNOJ();

	[Cpp2IlInjected.Token(Token = "0x6000108")]
	[Cpp2IlInjected.Address(Slot = "12")]
	void MDMELEJAEMJ();

	[Cpp2IlInjected.Token(Token = "0x6000109")]
	[Cpp2IlInjected.Address(Slot = "13")]
	void KJCFNJNJCNO();

	[Cpp2IlInjected.Token(Token = "0x600010A")]
	[Cpp2IlInjected.Address(Slot = "14")]
	void AEMAJDMNPCO(Rigidbody ADEHOEHEFLF);

	[Cpp2IlInjected.Token(Token = "0x600010B")]
	[Cpp2IlInjected.Address(Slot = "15")]
	void OLACCOJPAIO(Rigidbody ADEHOEHEFLF);

	[Cpp2IlInjected.Token(Token = "0x600010C")]
	[Cpp2IlInjected.Address(Slot = "16")]
	void FFOPCPPNJNP();
}
[Cpp2IlInjected.Token(Token = "0x2000019")]
public interface BECBDCABJBI
{
	[Cpp2IlInjected.Token(Token = "0x600010D")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void AHALPFGPHOF();

	[Cpp2IlInjected.Token(Token = "0x600010E")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void INJILPOGJHK(object BDHKJODLPCL);

	[Cpp2IlInjected.Token(Token = "0x600010F")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void MHGGBOGIOEK(object BDHKJODLPCL);

	[Cpp2IlInjected.Token(Token = "0x6000110")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void ADFLBOFFGPH(JCOFHJBGHJA ICFAMCDBCJP);

	[Cpp2IlInjected.Token(Token = "0x6000111")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void FNFPCLJNIPI(JCOFHJBGHJA ICFAMCDBCJP);

	[Cpp2IlInjected.Token(Token = "0x6000112")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void CMJJMIMJMJA();
}
[Cpp2IlInjected.Token(Token = "0x200001A")]
public interface FPLEKLLPLHN
{
	[Cpp2IlInjected.Token(Token = "0x17000044")]
	bool LBJIFIJGLFG
	{
		[Cpp2IlInjected.Token(Token = "0x6000116")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x14000015")]
	event FLEHDNMKJOM DMOBFCJFCHG;

	[Cpp2IlInjected.Token(Token = "0x6000115")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void LPJBNOGJIJA();

	[Cpp2IlInjected.Token(Token = "0x6000117")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void OCIECADEFBE(object BDHKJODLPCL);

	[Cpp2IlInjected.Token(Token = "0x6000118")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void BDHFACKMPAM(object BDHKJODLPCL);

	[Cpp2IlInjected.Token(Token = "0x6000119")]
	[Cpp2IlInjected.Address(Slot = "6")]
	void JMJCHOCCJDP(object BDHKJODLPCL, bool JEKJDJALDPH);

	[Cpp2IlInjected.Token(Token = "0x600011A")]
	[Cpp2IlInjected.Address(Slot = "7")]
	IDisposable OHLNCDKJKKB();

	[Cpp2IlInjected.Token(Token = "0x600011B")]
	[Cpp2IlInjected.Address(Slot = "8")]
	void AEMAJDMNPCO(Rigidbody APJBIKHBABA);

	[Cpp2IlInjected.Token(Token = "0x600011C")]
	[Cpp2IlInjected.Address(Slot = "9")]
	void OLACCOJPAIO(Rigidbody ADEHOEHEFLF);
}
[Cpp2IlInjected.Token(Token = "0x200001B")]
public interface NMOCGBHDPAJ : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x17000045")]
	bool FFPFCCCKGMP
	{
		[Cpp2IlInjected.Token(Token = "0x600011F")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000046")]
	bool PDPGPNLHDKB
	{
		[Cpp2IlInjected.Token(Token = "0x6000120")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x14000016")]
	event FLEHDNMKJOM HLHMNNKNCHD;

	[Cpp2IlInjected.Token(Token = "0x6000121")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void AHALPFGPHOF();

	[Cpp2IlInjected.Token(Token = "0x6000122")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void BKKACFBKLDE(JCOFHJBGHJA EMDODFFCGEF);

	[Cpp2IlInjected.Token(Token = "0x6000123")]
	[Cpp2IlInjected.Address(Slot = "6")]
	void PGLFNOHKLFE(JCOFHJBGHJA EMDODFFCGEF);
}
[Cpp2IlInjected.Token(Token = "0x200001C")]
public interface KMAFPEDBELG
{
	[Cpp2IlInjected.Token(Token = "0x17000047")]
	bool KGIFFCDEOAE
	{
		[Cpp2IlInjected.Token(Token = "0x6000124")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
		[Cpp2IlInjected.Token(Token = "0x6000125")]
		[Cpp2IlInjected.Address(Slot = "1")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000048")]
	bool AHEOPCHGDPG
	{
		[Cpp2IlInjected.Token(Token = "0x6000126")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000049")]
	RigidbodyConstraints LFMJJPGKPGH
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
	void AEMAJDMNPCO(Rigidbody ADEHOEHEFLF);

	[Cpp2IlInjected.Token(Token = "0x600012A")]
	[Cpp2IlInjected.Address(Slot = "6")]
	void OLACCOJPAIO(Rigidbody ADEHOEHEFLF);
}
[Cpp2IlInjected.Token(Token = "0x200001D")]
public interface LHIPGJNPCPA
{
	[Cpp2IlInjected.Token(Token = "0x1700004A")]
	float PDJELALCJNL
	{
		[Cpp2IlInjected.Token(Token = "0x600012B")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
		[Cpp2IlInjected.Token(Token = "0x600012C")]
		[Cpp2IlInjected.Address(Slot = "1")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x1700004B")]
	float LHECHOENGNG
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
	void AEMAJDMNPCO(Rigidbody ADEHOEHEFLF);

	[Cpp2IlInjected.Token(Token = "0x6000130")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void OLACCOJPAIO(Rigidbody ADEHOEHEFLF);
}
[Cpp2IlInjected.Token(Token = "0x200001E")]
public interface DEBHNEEFMCN
{
	[Cpp2IlInjected.Token(Token = "0x6000131")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void OnRootRBEXChanged(RigidbodyEx LINOCBMLOAB);
}
[Cpp2IlInjected.Token(Token = "0x200001F")]
public interface OCGFIHDLMDE
{
	[Cpp2IlInjected.Token(Token = "0x14000017")]
	event FLEHDNMKJOM JOPHGGEPEGF;

	[Cpp2IlInjected.Token(Token = "0x6000134")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void AHALPFGPHOF();

	[Cpp2IlInjected.Token(Token = "0x6000135")]
	[Cpp2IlInjected.Address(Slot = "3")]
	bool HIMNDBELLFC();

	[Cpp2IlInjected.Token(Token = "0x6000136")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void KOECFGPAONM();

	[Cpp2IlInjected.Token(Token = "0x6000137")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void FHCIIFMIADL();

	[Cpp2IlInjected.Token(Token = "0x6000138")]
	[Cpp2IlInjected.Address(Slot = "6")]
	void FHOPNJINOBL();

	[Cpp2IlInjected.Token(Token = "0x6000139")]
	[Cpp2IlInjected.Address(Slot = "7")]
	void LGECILGBLOD();

	[Cpp2IlInjected.Token(Token = "0x600013A")]
	[Cpp2IlInjected.Address(Slot = "8")]
	void HFBIOGKFJLO(bool CPAENGEGPEJ);
}
[Cpp2IlInjected.Token(Token = "0x2000020")]
public interface BOKFNFEEHEN
{
	[Cpp2IlInjected.Token(Token = "0x1700004C")]
	Rigidbody OHEHDKEKPMJ
	{
		[Cpp2IlInjected.Token(Token = "0x600013B")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700004D")]
	bool CKHKFDAEDBM
	{
		[Cpp2IlInjected.Token(Token = "0x600013D")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x600013C")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void AHALPFGPHOF();

	[Cpp2IlInjected.Token(Token = "0x600013E")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void IFAGMNAOPKH(object BDHKJODLPCL);

	[Cpp2IlInjected.Token(Token = "0x600013F")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void ONPKKIOKJND(object BDHKJODLPCL);

	[Cpp2IlInjected.Token(Token = "0x6000140")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void APMEFFJEKGL();

	[Cpp2IlInjected.Token(Token = "0x6000141")]
	[Cpp2IlInjected.Address(Slot = "6")]
	void KCCBENMOEDJ();
}
[Cpp2IlInjected.Token(Token = "0x2000021")]
public interface LNECPEEFLAO : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x1700004E")]
	EBGPLIADLBP NPCFNCCEAJO
	{
		[Cpp2IlInjected.Token(Token = "0x6000142")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
		[Cpp2IlInjected.Token(Token = "0x6000143")]
		[Cpp2IlInjected.Address(Slot = "1")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x1700004F")]
	OEEPKCKPLEL LAOMDEGHJLM
	{
		[Cpp2IlInjected.Token(Token = "0x6000144")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
		[Cpp2IlInjected.Token(Token = "0x6000145")]
		[Cpp2IlInjected.Address(Slot = "3")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000050")]
	Vector3 BPGONCPMPON
	{
		[Cpp2IlInjected.Token(Token = "0x6000146")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
		[Cpp2IlInjected.Token(Token = "0x6000147")]
		[Cpp2IlInjected.Address(Slot = "5")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000051")]
	Vector3 CDFFMHAADHJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000148")]
		[Cpp2IlInjected.Address(Slot = "6")]
		get;
		[Cpp2IlInjected.Token(Token = "0x6000149")]
		[Cpp2IlInjected.Address(Slot = "7")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000052")]
	Vector3 PPHKEOLJADG
	{
		[Cpp2IlInjected.Token(Token = "0x600014A")]
		[Cpp2IlInjected.Address(Slot = "8")]
		get;
		[Cpp2IlInjected.Token(Token = "0x600014B")]
		[Cpp2IlInjected.Address(Slot = "9")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000053")]
	Vector3 ELLKJABMPJB
	{
		[Cpp2IlInjected.Token(Token = "0x600014C")]
		[Cpp2IlInjected.Address(Slot = "10")]
		get;
		[Cpp2IlInjected.Token(Token = "0x600014D")]
		[Cpp2IlInjected.Address(Slot = "11")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000054")]
	float ILJFFAPOBNP
	{
		[Cpp2IlInjected.Token(Token = "0x600014E")]
		[Cpp2IlInjected.Address(Slot = "12")]
		get;
		[Cpp2IlInjected.Token(Token = "0x600014F")]
		[Cpp2IlInjected.Address(Slot = "13")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000055")]
	bool OPLHKLPKLIH
	{
		[Cpp2IlInjected.Token(Token = "0x6000150")]
		[Cpp2IlInjected.Address(Slot = "14")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000151")]
	[Cpp2IlInjected.Address(Slot = "15")]
	void AHALPFGPHOF();

	[Cpp2IlInjected.Token(Token = "0x6000152")]
	[Cpp2IlInjected.Address(Slot = "16")]
	void JCILIICGCJL(object BDHKJODLPCL);

	[Cpp2IlInjected.Token(Token = "0x6000153")]
	[Cpp2IlInjected.Address(Slot = "17")]
	void FIGBACLJNDD(HGAFDACKLPM ALPAKFKNNFG, Vector3 JMPMBOKBENO, float MGEJKMAAPFM = float.PositiveInfinity);

	[Cpp2IlInjected.Token(Token = "0x6000154")]
	[Cpp2IlInjected.Address(Slot = "18")]
	void DLGALJLLKBC(IOIMFMPPEPK JJCOMEIHIFG, Vector3 LOPBIAGCJBL, float DJHFDGIPKCO, float GJGOKKJEDGM = 8f, float KHKMMDAMJPL = 1f);

	[Cpp2IlInjected.Token(Token = "0x6000155")]
	[Cpp2IlInjected.Address(Slot = "19")]
	void IFNPBEKLMHH(HGAFDACKLPM ALPAKFKNNFG, Vector3 IKFFGJBHBIC, float KIDOONEEGII = 7f, float HDJMHGGGNBA = 1f);

	[Cpp2IlInjected.Token(Token = "0x6000156")]
	[Cpp2IlInjected.Address(Slot = "20")]
	void PNFNNMMCLFE();

	[Cpp2IlInjected.Token(Token = "0x6000157")]
	[Cpp2IlInjected.Address(Slot = "21")]
	void DJHDKBHIGDN();

	[Cpp2IlInjected.Token(Token = "0x6000158")]
	[Cpp2IlInjected.Address(Slot = "22")]
	void KJCKGCGOJBM();

	[Cpp2IlInjected.Token(Token = "0x6000159")]
	[Cpp2IlInjected.Address(Slot = "23")]
	void MEMDFIBKEPP();

	[Cpp2IlInjected.Token(Token = "0x600015A")]
	[Cpp2IlInjected.Address(Slot = "24")]
	void AEMAJDMNPCO(Rigidbody ADEHOEHEFLF);

	[Cpp2IlInjected.Token(Token = "0x600015B")]
	[Cpp2IlInjected.Address(Slot = "25")]
	Vector3 IEPIAOMDAAG(Vector3 KDGFADJDBBB);

	[Cpp2IlInjected.Token(Token = "0x600015C")]
	[Cpp2IlInjected.Address(Slot = "26")]
	void MPOMOMABFCM(object BDHKJODLPCL);

	[Cpp2IlInjected.Token(Token = "0x600015D")]
	[Cpp2IlInjected.Address(Slot = "27")]
	void MPFFKLHFEMH(Vector3 HBEOKBDKAPI);

	[Cpp2IlInjected.Token(Token = "0x600015E")]
	[Cpp2IlInjected.Address(Slot = "28")]
	void ENOBLMIPEAC(Vector3 KAAALJHMPDH, Vector3 BFLGOPEGDDM);

	[Cpp2IlInjected.Token(Token = "0x600015F")]
	[Cpp2IlInjected.Address(Slot = "29")]
	void DENAIEDOENP(Vector3 FHLIJFCHIPI, Vector3 NEMLBHKHIJF);

	[Cpp2IlInjected.Token(Token = "0x6000160")]
	[Cpp2IlInjected.Address(Slot = "30")]
	Vector3 CIMNPDLMMNF(Vector3 BNBPPNLIKAM);

	[Cpp2IlInjected.Token(Token = "0x6000161")]
	[Cpp2IlInjected.Address(Slot = "31")]
	Vector3 FAMKNNGPJGI(Vector3 ANEKCENIKFN);
}
[Cpp2IlInjected.Token(Token = "0x2000022")]
[DKGHNNODKMB(NKCLGJJOGJC.Application)]
public interface CMOEJONPKIA
{
	[Cpp2IlInjected.Token(Token = "0x17000056")]
	bool GBGKAJPCFND
	{
		[Cpp2IlInjected.Token(Token = "0x6000162")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000163")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void IGLPNMNLPJC(string FHHKCHCDKKO);

	[Cpp2IlInjected.Token(Token = "0x6000164")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void EHDFJEJDJEM(RigidbodyEx ICFAMCDBCJP, Action HKJBPIINLDG);

	[Cpp2IlInjected.Token(Token = "0x6000165")]
	[Cpp2IlInjected.Address(Slot = "3")]
	AIPACPAGJIN DDBOJODNHAJ(int IPHGNNKNFPD);

	[Cpp2IlInjected.Token(Token = "0x6000166")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void KBEGLEDCANA(Vector3 LFFCENAOLNI, float MMAJDLPMGJB, Color MNHFMCFPMMK);
}
[Cpp2IlInjected.Token(Token = "0x2000023")]
[DKGHNNODKMB(NKCLGJJOGJC.Application)]
public interface FCIHFBGEFGG
{
	[Cpp2IlInjected.Token(Token = "0x17000057")]
	CMOEJONPKIA ANIHPGDPKNA
	{
		[Cpp2IlInjected.Token(Token = "0x6000167")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000058")]
	IJKJBKAFLOD DCFKMHLPLHE
	{
		[Cpp2IlInjected.Token(Token = "0x6000168")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000169")]
	[Cpp2IlInjected.Address(Slot = "2")]
	FNONGLLGKNI JKHOPNONHBO(RigidbodyEx ICFAMCDBCJP);

	[Cpp2IlInjected.Token(Token = "0x600016A")]
	[Cpp2IlInjected.Address(Slot = "3")]
	JCOFHJBGHJA DJNICONLOON(RigidbodyEx ICFAMCDBCJP, OEDKMOJJJDN ALPLHOOHPEL);
}
[Cpp2IlInjected.Token(Token = "0x2000024")]
public interface OEEPKCKPLEL
{
	[Cpp2IlInjected.Token(Token = "0x600016B")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void LGKPNFKACGP(Vector3 BOIKAGCHDNA);

	[Cpp2IlInjected.Token(Token = "0x600016C")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void ENONAEOFDCM(Vector3 HIEIGGIPFIC);

	[Cpp2IlInjected.Token(Token = "0x600016D")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void FLOBBOBMHOM(Vector3 BOIKAGCHDNA);

	[Cpp2IlInjected.Token(Token = "0x600016E")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void DIPJDKMIIAA(Vector3 HIEIGGIPFIC);
}
[Cpp2IlInjected.Token(Token = "0x2000025")]
public interface EBGPLIADLBP : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x600016F")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Vector3 CGAPCGBJFJN();

	[Cpp2IlInjected.Token(Token = "0x6000170")]
	[Cpp2IlInjected.Address(Slot = "1")]
	Vector3 KPHJPJGFJHA();
}
[Cpp2IlInjected.Token(Token = "0x2000026")]
public interface JCOFHJBGHJA : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x17000059")]
	Rigidbody OHEHDKEKPMJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000171")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700005A")]
	RigidbodyEx FNPOFPMCEAK
	{
		[Cpp2IlInjected.Token(Token = "0x6000172")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700005B")]
	GameObject LDBFPEKLENK
	{
		[Cpp2IlInjected.Token(Token = "0x6000173")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700005C")]
	Transform ODAEKBBDPFC
	{
		[Cpp2IlInjected.Token(Token = "0x6000174")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700005D")]
	JCOFHJBGHJA EOGAOJCDEEE
	{
		[Cpp2IlInjected.Token(Token = "0x6000175")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
		[Cpp2IlInjected.Token(Token = "0x6000176")]
		[Cpp2IlInjected.Address(Slot = "5")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x1700005E")]
	IReadOnlyList<JCOFHJBGHJA> OPIGCLHIKGM
	{
		[Cpp2IlInjected.Token(Token = "0x6000177")]
		[Cpp2IlInjected.Address(Slot = "6")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700005F")]
	JCOFHJBGHJA OPHGKOLAGBH
	{
		[Cpp2IlInjected.Token(Token = "0x6000178")]
		[Cpp2IlInjected.Address(Slot = "7")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000060")]
	bool FFPFCCCKGMP
	{
		[Cpp2IlInjected.Token(Token = "0x6000179")]
		[Cpp2IlInjected.Address(Slot = "8")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000061")]
	bool PDPGPNLHDKB
	{
		[Cpp2IlInjected.Token(Token = "0x600017A")]
		[Cpp2IlInjected.Address(Slot = "9")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000062")]
	EBGPLIADLBP NPCFNCCEAJO
	{
		[Cpp2IlInjected.Token(Token = "0x600017B")]
		[Cpp2IlInjected.Address(Slot = "10")]
		get;
		[Cpp2IlInjected.Token(Token = "0x600017C")]
		[Cpp2IlInjected.Address(Slot = "11")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000063")]
	OEEPKCKPLEL LAOMDEGHJLM
	{
		[Cpp2IlInjected.Token(Token = "0x600017D")]
		[Cpp2IlInjected.Address(Slot = "12")]
		get;
		[Cpp2IlInjected.Token(Token = "0x600017E")]
		[Cpp2IlInjected.Address(Slot = "13")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000064")]
	float ILJFFAPOBNP
	{
		[Cpp2IlInjected.Token(Token = "0x600017F")]
		[Cpp2IlInjected.Address(Slot = "14")]
		get;
		[Cpp2IlInjected.Token(Token = "0x6000180")]
		[Cpp2IlInjected.Address(Slot = "15")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000065")]
	Vector3 CDFFMHAADHJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000181")]
		[Cpp2IlInjected.Address(Slot = "16")]
		get;
		[Cpp2IlInjected.Token(Token = "0x6000182")]
		[Cpp2IlInjected.Address(Slot = "17")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000066")]
	Vector3 ELLKJABMPJB
	{
		[Cpp2IlInjected.Token(Token = "0x6000183")]
		[Cpp2IlInjected.Address(Slot = "18")]
		get;
		[Cpp2IlInjected.Token(Token = "0x6000184")]
		[Cpp2IlInjected.Address(Slot = "19")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000067")]
	Vector3 BPGONCPMPON
	{
		[Cpp2IlInjected.Token(Token = "0x6000185")]
		[Cpp2IlInjected.Address(Slot = "20")]
		get;
		[Cpp2IlInjected.Token(Token = "0x6000186")]
		[Cpp2IlInjected.Address(Slot = "21")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000068")]
	Vector3 PPHKEOLJADG
	{
		[Cpp2IlInjected.Token(Token = "0x6000187")]
		[Cpp2IlInjected.Address(Slot = "22")]
		get;
		[Cpp2IlInjected.Token(Token = "0x6000188")]
		[Cpp2IlInjected.Address(Slot = "23")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000069")]
	bool IENLPMCJMAL
	{
		[Cpp2IlInjected.Token(Token = "0x6000189")]
		[Cpp2IlInjected.Address(Slot = "24")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700006A")]
	bool ALJGPBCFAJC
	{
		[Cpp2IlInjected.Token(Token = "0x600018A")]
		[Cpp2IlInjected.Address(Slot = "25")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700006B")]
	bool OPLHKLPKLIH
	{
		[Cpp2IlInjected.Token(Token = "0x600018B")]
		[Cpp2IlInjected.Address(Slot = "26")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700006C")]
	Vector3 JAEHHIFFHAO
	{
		[Cpp2IlInjected.Token(Token = "0x600018C")]
		[Cpp2IlInjected.Address(Slot = "27")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700006D")]
	Vector3 DBENDJKNCLA
	{
		[Cpp2IlInjected.Token(Token = "0x600018D")]
		[Cpp2IlInjected.Address(Slot = "28")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700006E")]
	Vector3 DKCKPGONLCO
	{
		[Cpp2IlInjected.Token(Token = "0x600018E")]
		[Cpp2IlInjected.Address(Slot = "29")]
		get;
		[Cpp2IlInjected.Token(Token = "0x600018F")]
		[Cpp2IlInjected.Address(Slot = "30")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x1700006F")]
	Vector3 EAIFIKDGKFD
	{
		[Cpp2IlInjected.Token(Token = "0x6000190")]
		[Cpp2IlInjected.Address(Slot = "31")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000070")]
	float LOOBEDBGKGP
	{
		[Cpp2IlInjected.Token(Token = "0x6000191")]
		[Cpp2IlInjected.Address(Slot = "32")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000071")]
	float LLPPBNBJAIJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000192")]
		[Cpp2IlInjected.Address(Slot = "33")]
		get;
		[Cpp2IlInjected.Token(Token = "0x6000193")]
		[Cpp2IlInjected.Address(Slot = "34")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000072")]
	Vector3 GPBCJEBAHGH
	{
		[Cpp2IlInjected.Token(Token = "0x6000194")]
		[Cpp2IlInjected.Address(Slot = "35")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000073")]
	Quaternion PNNPLKIEMEL
	{
		[Cpp2IlInjected.Token(Token = "0x6000195")]
		[Cpp2IlInjected.Address(Slot = "36")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000074")]
	float PDJELALCJNL
	{
		[Cpp2IlInjected.Token(Token = "0x6000197")]
		[Cpp2IlInjected.Address(Slot = "38")]
		get;
		[Cpp2IlInjected.Token(Token = "0x6000198")]
		[Cpp2IlInjected.Address(Slot = "39")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000075")]
	float LHECHOENGNG
	{
		[Cpp2IlInjected.Token(Token = "0x6000199")]
		[Cpp2IlInjected.Address(Slot = "40")]
		get;
		[Cpp2IlInjected.Token(Token = "0x600019A")]
		[Cpp2IlInjected.Address(Slot = "41")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000076")]
	bool PPOPHDEHNNA
	{
		[Cpp2IlInjected.Token(Token = "0x600019B")]
		[Cpp2IlInjected.Address(Slot = "42")]
		get;
		[Cpp2IlInjected.Token(Token = "0x600019C")]
		[Cpp2IlInjected.Address(Slot = "43")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000077")]
	GOOCPGCLLJK OKHKDAGKHIN
	{
		[Cpp2IlInjected.Token(Token = "0x600019D")]
		[Cpp2IlInjected.Address(Slot = "44")]
		get;
		[Cpp2IlInjected.Token(Token = "0x600019E")]
		[Cpp2IlInjected.Address(Slot = "45")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000078")]
	bool LBJIFIJGLFG
	{
		[Cpp2IlInjected.Token(Token = "0x600019F")]
		[Cpp2IlInjected.Address(Slot = "46")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000079")]
	Transform BCEDFGPKPCG
	{
		[Cpp2IlInjected.Token(Token = "0x60001A0")]
		[Cpp2IlInjected.Address(Slot = "47")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700007A")]
	Vector3 IMJAMINFNFO
	{
		[Cpp2IlInjected.Token(Token = "0x60001A1")]
		[Cpp2IlInjected.Address(Slot = "48")]
		get;
		[Cpp2IlInjected.Token(Token = "0x60001A2")]
		[Cpp2IlInjected.Address(Slot = "49")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x1700007B")]
	float AOLGPBNKCKH
	{
		[Cpp2IlInjected.Token(Token = "0x60001A3")]
		[Cpp2IlInjected.Address(Slot = "50")]
		get;
		[Cpp2IlInjected.Token(Token = "0x60001A4")]
		[Cpp2IlInjected.Address(Slot = "51")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x1700007C")]
	float GDAJCJKIBLE
	{
		[Cpp2IlInjected.Token(Token = "0x60001A5")]
		[Cpp2IlInjected.Address(Slot = "52")]
		get;
		[Cpp2IlInjected.Token(Token = "0x60001A6")]
		[Cpp2IlInjected.Address(Slot = "53")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x1700007D")]
	Quaternion OIJGDFEHDPK
	{
		[Cpp2IlInjected.Token(Token = "0x60001A7")]
		[Cpp2IlInjected.Address(Slot = "54")]
		get;
		[Cpp2IlInjected.Token(Token = "0x60001A8")]
		[Cpp2IlInjected.Address(Slot = "55")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x1700007E")]
	Vector3 PEDCHEEBCKD
	{
		[Cpp2IlInjected.Token(Token = "0x60001A9")]
		[Cpp2IlInjected.Address(Slot = "56")]
		get;
		[Cpp2IlInjected.Token(Token = "0x60001AA")]
		[Cpp2IlInjected.Address(Slot = "57")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x1700007F")]
	Quaternion IFBEDGFGEHN
	{
		[Cpp2IlInjected.Token(Token = "0x60001AB")]
		[Cpp2IlInjected.Address(Slot = "58")]
		get;
		[Cpp2IlInjected.Token(Token = "0x60001AC")]
		[Cpp2IlInjected.Address(Slot = "59")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000080")]
	RigidbodyConstraints LFMJJPGKPGH
	{
		[Cpp2IlInjected.Token(Token = "0x60001AD")]
		[Cpp2IlInjected.Address(Slot = "60")]
		get;
		[Cpp2IlInjected.Token(Token = "0x60001AE")]
		[Cpp2IlInjected.Address(Slot = "61")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000081")]
	bool KGIFFCDEOAE
	{
		[Cpp2IlInjected.Token(Token = "0x60001AF")]
		[Cpp2IlInjected.Address(Slot = "62")]
		get;
		[Cpp2IlInjected.Token(Token = "0x60001B0")]
		[Cpp2IlInjected.Address(Slot = "63")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000082")]
	CollisionDetectionMode BMACCDICLGG
	{
		[Cpp2IlInjected.Token(Token = "0x60001B1")]
		[Cpp2IlInjected.Address(Slot = "64")]
		get;
		[Cpp2IlInjected.Token(Token = "0x60001B2")]
		[Cpp2IlInjected.Address(Slot = "65")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000083")]
	bool ALACEGOHBBC
	{
		[Cpp2IlInjected.Token(Token = "0x60001B3")]
		[Cpp2IlInjected.Address(Slot = "66")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x14000018")]
	event FLEHDNMKJOM DGFHCDMPNOC;

	[Cpp2IlInjected.Token(Token = "0x14000019")]
	event FLEHDNMKJOM AJNJNDIOIEI;

	[Cpp2IlInjected.Token(Token = "0x1400001A")]
	event GANGMHHLDKO EAAJADAMIEB;

	[Cpp2IlInjected.Token(Token = "0x1400001B")]
	event FLEHDNMKJOM HLHMNNKNCHD;

	[Cpp2IlInjected.Token(Token = "0x1400001C")]
	event FLEHDNMKJOM OMOJLBAAJNO;

	[Cpp2IlInjected.Token(Token = "0x1400001D")]
	event FLEHDNMKJOM JOPHGGEPEGF;

	[Cpp2IlInjected.Token(Token = "0x1400001E")]
	event Action<MMMOHCNLPFL, MMMOHCNLPFL> KKLFFLFCKKL;

	[Cpp2IlInjected.Token(Token = "0x1400001F")]
	event FLEHDNMKJOM DMOBFCJFCHG;

	[Cpp2IlInjected.Token(Token = "0x14000020")]
	event FLEHDNMKJOM PHEOCLOKCBC;

	[Cpp2IlInjected.Token(Token = "0x6000196")]
	[Cpp2IlInjected.Address(Slot = "37")]
	void PFEPHKNMKPF((Quaternion rot, Vector3 moments) EELLIIPGCJG);

	[Cpp2IlInjected.Token(Token = "0x60001B4")]
	[Cpp2IlInjected.Address(Slot = "67")]
	void AHALPFGPHOF();

	[Cpp2IlInjected.Token(Token = "0x60001B5")]
	[Cpp2IlInjected.Address(Slot = "68")]
	void FONLJBNDHEB();

	[Cpp2IlInjected.Token(Token = "0x60001B6")]
	[Cpp2IlInjected.Address(Slot = "69")]
	void MJIHENGPCML();

	[Cpp2IlInjected.Token(Token = "0x60001B7")]
	[Cpp2IlInjected.Address(Slot = "70")]
	void FHCIIFMIADL();

	[Cpp2IlInjected.Token(Token = "0x60001BE")]
	[Cpp2IlInjected.Address(Slot = "77")]
	void IPJNFPFPNEM(JCOFHJBGHJA ANJCCKHBJJO, bool OHOCKJLAANC = false);

	[Cpp2IlInjected.Token(Token = "0x60001C1")]
	[Cpp2IlInjected.Address(Slot = "80")]
	void OFJHCOCGNAD(object BDHKJODLPCL);

	[Cpp2IlInjected.Token(Token = "0x60001C2")]
	[Cpp2IlInjected.Address(Slot = "81")]
	void LAFHMMIGNHI(object BDHKJODLPCL);

	[Cpp2IlInjected.Token(Token = "0x60001C3")]
	[Cpp2IlInjected.Address(Slot = "82")]
	Vector3 FAMKNNGPJGI(Vector3 ANEKCENIKFN);

	[Cpp2IlInjected.Token(Token = "0x60001C4")]
	[Cpp2IlInjected.Address(Slot = "83")]
	Vector3 CIMNPDLMMNF(Vector3 BNBPPNLIKAM);

	[Cpp2IlInjected.Token(Token = "0x60001C5")]
	[Cpp2IlInjected.Address(Slot = "84")]
	void MEMDFIBKEPP();

	[Cpp2IlInjected.Token(Token = "0x60001C6")]
	[Cpp2IlInjected.Address(Slot = "85")]
	void DJHDKBHIGDN();

	[Cpp2IlInjected.Token(Token = "0x60001C7")]
	[Cpp2IlInjected.Address(Slot = "86")]
	void PNFNNMMCLFE();

	[Cpp2IlInjected.Token(Token = "0x60001C8")]
	[Cpp2IlInjected.Address(Slot = "87")]
	void DENAIEDOENP(Vector3 FHLIJFCHIPI, Vector3 NEMLBHKHIJF);

	[Cpp2IlInjected.Token(Token = "0x60001C9")]
	[Cpp2IlInjected.Address(Slot = "88")]
	void ENOBLMIPEAC(Vector3 KAAALJHMPDH, Vector3 BFLGOPEGDDM);

	[Cpp2IlInjected.Token(Token = "0x60001CA")]
	[Cpp2IlInjected.Address(Slot = "89")]
	void MPFFKLHFEMH(Vector3 HBEOKBDKAPI);

	[Cpp2IlInjected.Token(Token = "0x60001CB")]
	[Cpp2IlInjected.Address(Slot = "90")]
	void DLGALJLLKBC(IOIMFMPPEPK JJCOMEIHIFG, Vector3 LOPBIAGCJBL, float DJHFDGIPKCO, float GJGOKKJEDGM = 8f, float KHKMMDAMJPL = 1f);

	[Cpp2IlInjected.Token(Token = "0x60001CC")]
	[Cpp2IlInjected.Address(Slot = "91")]
	void FIGBACLJNDD(HGAFDACKLPM ALPAKFKNNFG, Vector3 JMPMBOKBENO, float MGEJKMAAPFM = float.PositiveInfinity);

	[Cpp2IlInjected.Token(Token = "0x60001CD")]
	[Cpp2IlInjected.Address(Slot = "92")]
	void IFNPBEKLMHH(HGAFDACKLPM ALPAKFKNNFG, Vector3 IKFFGJBHBIC, float KIDOONEEGII = 7f, float HDJMHGGGNBA = 1f);

	[Cpp2IlInjected.Token(Token = "0x60001CE")]
	[Cpp2IlInjected.Address(Slot = "93")]
	Vector3 IEPIAOMDAAG(Vector3 ANJCCKHBJJO);

	[Cpp2IlInjected.Token(Token = "0x60001CF")]
	[Cpp2IlInjected.Address(Slot = "94")]
	Vector3 GMNEMANIPAE(Vector3 ANJCCKHBJJO);

	[Cpp2IlInjected.Token(Token = "0x60001D0")]
	[Cpp2IlInjected.Address(Slot = "95")]
	void KJCKGCGOJBM();

	[Cpp2IlInjected.Token(Token = "0x60001D1")]
	[Cpp2IlInjected.Address(Slot = "96")]
	void BMMKPJKFCJN(JCOFHJBGHJA OFCMPLLCIEA, object BDHKJODLPCL);

	[Cpp2IlInjected.Token(Token = "0x60001D2")]
	[Cpp2IlInjected.Address(Slot = "97")]
	void KFKPPNFPJGE(object BDHKJODLPCL);

	[Cpp2IlInjected.Token(Token = "0x60001D5")]
	[Cpp2IlInjected.Address(Slot = "100")]
	void MDMELEJAEMJ();

	[Cpp2IlInjected.Token(Token = "0x60001D6")]
	[Cpp2IlInjected.Address(Slot = "101")]
	void KNGNMHHLNOJ();

	[Cpp2IlInjected.Token(Token = "0x60001D7")]
	[Cpp2IlInjected.Address(Slot = "102")]
	void KJCFNJNJCNO();

	[Cpp2IlInjected.Token(Token = "0x60001DA")]
	[Cpp2IlInjected.Address(Slot = "105")]
	bool HIMNDBELLFC();

	[Cpp2IlInjected.Token(Token = "0x60001DB")]
	[Cpp2IlInjected.Address(Slot = "106")]
	void LGECILGBLOD();

	[Cpp2IlInjected.Token(Token = "0x60001E0")]
	[Cpp2IlInjected.Address(Slot = "111")]
	IDisposable OHLNCDKJKKB();

	[Cpp2IlInjected.Token(Token = "0x60001E1")]
	[Cpp2IlInjected.Address(Slot = "112")]
	void OCIECADEFBE(object BDHKJODLPCL);

	[Cpp2IlInjected.Token(Token = "0x60001E2")]
	[Cpp2IlInjected.Address(Slot = "113")]
	void BDHFACKMPAM(object BDHKJODLPCL);

	[Cpp2IlInjected.Token(Token = "0x60001E3")]
	[Cpp2IlInjected.Address(Slot = "114")]
	void JMJCHOCCJDP(object BDHKJODLPCL, bool JEKJDJALDPH);

	[Cpp2IlInjected.Token(Token = "0x60001E6")]
	[Cpp2IlInjected.Address(Slot = "117")]
	void CNNKKJLCHHA(Vector3 IFADGICOBNM, Quaternion JJGEHCBPHJF);

	[Cpp2IlInjected.Token(Token = "0x60001E7")]
	[Cpp2IlInjected.Address(Slot = "118")]
	void AAOBGLOJCHA(Vector3 HJMGIFNAIIP, Quaternion PDEPBHFDPFN);

	[Cpp2IlInjected.Token(Token = "0x60001E8")]
	[Cpp2IlInjected.Address(Slot = "119")]
	bool BFMEEBCMBCE(float COMNKNINMAC);

	[Cpp2IlInjected.Token(Token = "0x60001E9")]
	[Cpp2IlInjected.Address(Slot = "120")]
	void ILKIHBCBCPP(object BDHKJODLPCL);

	[Cpp2IlInjected.Token(Token = "0x60001EA")]
	[Cpp2IlInjected.Address(Slot = "121")]
	void NBAIFBIDOJA(object BDHKJODLPCL);

	[Cpp2IlInjected.Token(Token = "0x60001EB")]
	[Cpp2IlInjected.Address(Slot = "122")]
	void IFAGMNAOPKH(object BDHKJODLPCL);

	[Cpp2IlInjected.Token(Token = "0x60001EC")]
	[Cpp2IlInjected.Address(Slot = "123")]
	void ONPKKIOKJND(object BDHKJODLPCL);

	[Cpp2IlInjected.Token(Token = "0x60001ED")]
	[Cpp2IlInjected.Address(Slot = "124")]
	void EOGJEEPJDGB(Vector3 BICEHKAFMDO, ForceMode NIBLDDDDGAO = ForceMode.Force);

	[Cpp2IlInjected.Token(Token = "0x60001EE")]
	[Cpp2IlInjected.Address(Slot = "125")]
	void EGMCEHGBFBK(Vector3 BICEHKAFMDO, Vector3 BEBKKMFGLCG, ForceMode NIBLDDDDGAO);

	[Cpp2IlInjected.Token(Token = "0x60001EF")]
	[Cpp2IlInjected.Address(Slot = "126")]
	void DACJEFDGIGP(Vector3 IMFJIBNAPMK, ForceMode NIBLDDDDGAO = ForceMode.Force);

	[Cpp2IlInjected.Token(Token = "0x60001F0")]
	[Cpp2IlInjected.Address(Slot = "127")]
	void JCCBIGPFMFC(Vector3 IMFJIBNAPMK, ForceMode NIBLDDDDGAO = ForceMode.Force);

	[Cpp2IlInjected.Token(Token = "0x60001F1")]
	[Cpp2IlInjected.Address(Slot = "128")]
	bool HMFCJNOKJNG(Vector3 PNADBCDBNOL, [Out] RaycastHit FDAHIHAIBKD, float FIOIECEGGAH);

	[Cpp2IlInjected.Token(Token = "0x60001F2")]
	[Cpp2IlInjected.Address(Slot = "129")]
	void FFOPCPPNJNP();
}
[Cpp2IlInjected.Token(Token = "0x2000027")]
public class AABMNPMKJNK : JCOFHJBGHJA, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400002C")]
	internal readonly FCIHFBGEFGG IALOIPDIIAG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400002D")]
	internal DFEBEBBPEII AANFIOBCLIB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400002E")]
	internal BECBDCABJBI HBEFPNJMBDN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400002F")]
	internal NMOCGBHDPAJ BMNIIHDNHLM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000030")]
	internal LNECPEEFLAO KDGFADJDBBB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000031")]
	internal JJMHLHBDECD MBECDHCJFHO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000032")]
	internal KPKDIHHLHAL IEGNPIGOJBN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000033")]
	internal LHIPGJNPCPA HAAANONOIFL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000034")]
	internal APDCPHMDBJE PHOBBJBMBIH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x4000035")]
	internal OCGFIHDLMDE GFCDLEGFLPC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x4000036")]
	internal NHEBLBOICHI FEFCBMEKALC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x4000037")]
	internal FPLEKLLPLHN LDDILFGLAOJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x4000038")]
	internal PNBKJNMIIDD BICEHKAFMDO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
	[Cpp2IlInjected.Token(Token = "0x4000039")]
	internal KMAFPEDBELG CDBOEJILJAG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x400003A")]
	internal BOKFNFEEHEN ADEHOEHEFLF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
	[Cpp2IlInjected.Token(Token = "0x400003B")]
	internal NDECPKLCGPL EGLHGDIBAGE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
	[Cpp2IlInjected.Token(Token = "0x400003C")]
	internal IDisposable MJKJHKGMCCP;

	[Cpp2IlInjected.Token(Token = "0x17000084")]
	public RigidbodyEx FNPOFPMCEAK
	{
		[Cpp2IlInjected.Token(Token = "0x60001F3")]
		[Cpp2IlInjected.Address(RVA = "0x79E710", Offset = "0x79DB10", VA = "0x18079E710", Slot = "5")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60001F4")]
		[Cpp2IlInjected.Address(RVA = "0x79E730", Offset = "0x79DB30", VA = "0x18079E730")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000085")]
	public GameObject LDBFPEKLENK
	{
		[Cpp2IlInjected.Token(Token = "0x60001F5")]
		[Cpp2IlInjected.Address(RVA = "0x859C10", Offset = "0x859010", VA = "0x180859C10", Slot = "6")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60001F6")]
		[Cpp2IlInjected.Address(RVA = "0x859E20", Offset = "0x859220", VA = "0x180859E20")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000086")]
	public Transform ODAEKBBDPFC
	{
		[Cpp2IlInjected.Token(Token = "0x60001F7")]
		[Cpp2IlInjected.Address(RVA = "0x6633330", Offset = "0x6632730", VA = "0x186633330", Slot = "7")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000087")]
	public Rigidbody OHEHDKEKPMJ
	{
		[Cpp2IlInjected.Token(Token = "0x60001F8")]
		[Cpp2IlInjected.Address(RVA = "0x6631EC0", Offset = "0x66312C0", VA = "0x186631EC0", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000088")]
	public JCOFHJBGHJA EOGAOJCDEEE
	{
		[Cpp2IlInjected.Token(Token = "0x6000206")]
		[Cpp2IlInjected.Address(RVA = "0x662F840", Offset = "0x662EC40", VA = "0x18662F840", Slot = "8")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000207")]
		[Cpp2IlInjected.Address(RVA = "0x6633410", Offset = "0x6632810", VA = "0x186633410", Slot = "9")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000089")]
	public IReadOnlyList<JCOFHJBGHJA> OPIGCLHIKGM
	{
		[Cpp2IlInjected.Token(Token = "0x6000208")]
		[Cpp2IlInjected.Address(RVA = "0x6631CB0", Offset = "0x66310B0", VA = "0x186631CB0", Slot = "10")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700008A")]
	public JCOFHJBGHJA OPHGKOLAGBH
	{
		[Cpp2IlInjected.Token(Token = "0x6000209")]
		[Cpp2IlInjected.Address(RVA = "0x6634100", Offset = "0x6633500", VA = "0x186634100", Slot = "11")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700008B")]
	public bool PJOOMDNDEDM
	{
		[Cpp2IlInjected.Token(Token = "0x600020A")]
		[Cpp2IlInjected.Address(RVA = "0x6631110", Offset = "0x6630510", VA = "0x186631110", Slot = "137")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700008C")]
	public bool FFPFCCCKGMP
	{
		[Cpp2IlInjected.Token(Token = "0x600020E")]
		[Cpp2IlInjected.Address(RVA = "0x66340B0", Offset = "0x66334B0", VA = "0x1866340B0", Slot = "12")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700008D")]
	public bool PDPGPNLHDKB
	{
		[Cpp2IlInjected.Token(Token = "0x600020F")]
		[Cpp2IlInjected.Address(RVA = "0x66336E0", Offset = "0x6632AE0", VA = "0x1866336E0", Slot = "13")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700008E")]
	public EBGPLIADLBP NPCFNCCEAJO
	{
		[Cpp2IlInjected.Token(Token = "0x6000210")]
		[Cpp2IlInjected.Address(RVA = "0x6632ED0", Offset = "0x66322D0", VA = "0x186632ED0", Slot = "14")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000211")]
		[Cpp2IlInjected.Address(RVA = "0x6631B20", Offset = "0x6630F20", VA = "0x186631B20", Slot = "15")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700008F")]
	public OEEPKCKPLEL LAOMDEGHJLM
	{
		[Cpp2IlInjected.Token(Token = "0x6000212")]
		[Cpp2IlInjected.Address(RVA = "0x662FE70", Offset = "0x662F270", VA = "0x18662FE70", Slot = "16")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000213")]
		[Cpp2IlInjected.Address(RVA = "0x662FB80", Offset = "0x662EF80", VA = "0x18662FB80", Slot = "17")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000090")]
	public float ILJFFAPOBNP
	{
		[Cpp2IlInjected.Token(Token = "0x6000214")]
		[Cpp2IlInjected.Address(RVA = "0x66305E0", Offset = "0x662F9E0", VA = "0x1866305E0", Slot = "18")]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x6000215")]
		[Cpp2IlInjected.Address(RVA = "0x6632260", Offset = "0x6631660", VA = "0x186632260", Slot = "19")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000091")]
	public Vector3 CDFFMHAADHJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000216")]
		[Cpp2IlInjected.Address(RVA = "0x66330D0", Offset = "0x66324D0", VA = "0x1866330D0", Slot = "20")]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x6000217")]
		[Cpp2IlInjected.Address(RVA = "0x6634D70", Offset = "0x6634170", VA = "0x186634D70", Slot = "21")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000092")]
	public Vector3 ELLKJABMPJB
	{
		[Cpp2IlInjected.Token(Token = "0x6000218")]
		[Cpp2IlInjected.Address(RVA = "0x662F540", Offset = "0x662E940", VA = "0x18662F540", Slot = "22")]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x6000219")]
		[Cpp2IlInjected.Address(RVA = "0x66312E0", Offset = "0x66306E0", VA = "0x1866312E0", Slot = "23")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000093")]
	public Vector3 BPGONCPMPON
	{
		[Cpp2IlInjected.Token(Token = "0x600021A")]
		[Cpp2IlInjected.Address(RVA = "0x66303C0", Offset = "0x662F7C0", VA = "0x1866303C0", Slot = "24")]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x600021B")]
		[Cpp2IlInjected.Address(RVA = "0x6633910", Offset = "0x6632D10", VA = "0x186633910", Slot = "25")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000094")]
	public Vector3 PPHKEOLJADG
	{
		[Cpp2IlInjected.Token(Token = "0x600021C")]
		[Cpp2IlInjected.Address(RVA = "0x66346A0", Offset = "0x6633AA0", VA = "0x1866346A0", Slot = "26")]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x600021D")]
		[Cpp2IlInjected.Address(RVA = "0x6630EC0", Offset = "0x66302C0", VA = "0x186630EC0", Slot = "27")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000095")]
	public bool BLAOGEILBPI
	{
		[Cpp2IlInjected.Token(Token = "0x600021E")]
		[Cpp2IlInjected.Address(RVA = "0x6631930", Offset = "0x6630D30", VA = "0x186631930", Slot = "138")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000096")]
	public bool IENLPMCJMAL
	{
		[Cpp2IlInjected.Token(Token = "0x600021F")]
		[Cpp2IlInjected.Address(RVA = "0x6632200", Offset = "0x6631600", VA = "0x186632200", Slot = "28")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000097")]
	public bool ALJGPBCFAJC
	{
		[Cpp2IlInjected.Token(Token = "0x6000220")]
		[Cpp2IlInjected.Address(RVA = "0x6631610", Offset = "0x6630A10", VA = "0x186631610", Slot = "29")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000098")]
	public bool OPLHKLPKLIH
	{
		[Cpp2IlInjected.Token(Token = "0x6000221")]
		[Cpp2IlInjected.Address(RVA = "0x6633780", Offset = "0x6632B80", VA = "0x186633780", Slot = "30")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000099")]
	public Vector3 JAEHHIFFHAO
	{
		[Cpp2IlInjected.Token(Token = "0x6000232")]
		[Cpp2IlInjected.Address(RVA = "0x6633B90", Offset = "0x6632F90", VA = "0x186633B90", Slot = "31")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700009A")]
	public Vector3 DBENDJKNCLA
	{
		[Cpp2IlInjected.Token(Token = "0x6000233")]
		[Cpp2IlInjected.Address(RVA = "0x66337D0", Offset = "0x6632BD0", VA = "0x1866337D0", Slot = "32")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700009B")]
	public Vector3 DKCKPGONLCO
	{
		[Cpp2IlInjected.Token(Token = "0x6000238")]
		[Cpp2IlInjected.Address(RVA = "0x66319F0", Offset = "0x6630DF0", VA = "0x1866319F0", Slot = "33")]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x6000239")]
		[Cpp2IlInjected.Address(RVA = "0x6634890", Offset = "0x6633C90", VA = "0x186634890", Slot = "34")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700009C")]
	public Vector3 EAIFIKDGKFD
	{
		[Cpp2IlInjected.Token(Token = "0x600023A")]
		[Cpp2IlInjected.Address(RVA = "0x6633C60", Offset = "0x6633060", VA = "0x186633C60", Slot = "35")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700009D")]
	public float LOOBEDBGKGP
	{
		[Cpp2IlInjected.Token(Token = "0x600023B")]
		[Cpp2IlInjected.Address(RVA = "0x66339F0", Offset = "0x6632DF0", VA = "0x1866339F0", Slot = "36")]
		get
		{
			return default(float);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700009E")]
	public float LLPPBNBJAIJ
	{
		[Cpp2IlInjected.Token(Token = "0x600023C")]
		[Cpp2IlInjected.Address(RVA = "0x662FBE0", Offset = "0x662EFE0", VA = "0x18662FBE0", Slot = "37")]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x600023D")]
		[Cpp2IlInjected.Address(RVA = "0x6634170", Offset = "0x6633570", VA = "0x186634170", Slot = "38")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700009F")]
	public Vector3 GPBCJEBAHGH
	{
		[Cpp2IlInjected.Token(Token = "0x600023E")]
		[Cpp2IlInjected.Address(RVA = "0x6632F20", Offset = "0x6632320", VA = "0x186632F20", Slot = "39")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A0")]
	public Quaternion PNNPLKIEMEL
	{
		[Cpp2IlInjected.Token(Token = "0x600023F")]
		[Cpp2IlInjected.Address(RVA = "0x6631FD0", Offset = "0x66313D0", VA = "0x186631FD0", Slot = "40")]
		get
		{
			return default(Quaternion);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A1")]
	public float PDJELALCJNL
	{
		[Cpp2IlInjected.Token(Token = "0x6000244")]
		[Cpp2IlInjected.Address(RVA = "0x6630A40", Offset = "0x662FE40", VA = "0x186630A40", Slot = "42")]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x6000245")]
		[Cpp2IlInjected.Address(RVA = "0x6633000", Offset = "0x6632400", VA = "0x186633000", Slot = "43")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A2")]
	public float LHECHOENGNG
	{
		[Cpp2IlInjected.Token(Token = "0x6000246")]
		[Cpp2IlInjected.Address(RVA = "0x66344F0", Offset = "0x66338F0", VA = "0x1866344F0", Slot = "44")]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x6000247")]
		[Cpp2IlInjected.Address(RVA = "0x6634830", Offset = "0x6633C30", VA = "0x186634830", Slot = "45")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A3")]
	public bool PPOPHDEHNNA
	{
		[Cpp2IlInjected.Token(Token = "0x6000248")]
		[Cpp2IlInjected.Address(RVA = "0x66333C0", Offset = "0x66327C0", VA = "0x1866333C0", Slot = "46")]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000249")]
		[Cpp2IlInjected.Address(RVA = "0x662F7E0", Offset = "0x662EBE0", VA = "0x18662F7E0", Slot = "47")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A4")]
	public GOOCPGCLLJK OKHKDAGKHIN
	{
		[Cpp2IlInjected.Token(Token = "0x6000251")]
		[Cpp2IlInjected.Address(RVA = "0x6631170", Offset = "0x6630570", VA = "0x186631170", Slot = "48")]
		get
		{
			return default(GOOCPGCLLJK);
		}
		[Cpp2IlInjected.Token(Token = "0x6000252")]
		[Cpp2IlInjected.Address(RVA = "0x6634490", Offset = "0x6633890", VA = "0x186634490", Slot = "49")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A5")]
	public bool LBJIFIJGLFG
	{
		[Cpp2IlInjected.Token(Token = "0x6000255")]
		[Cpp2IlInjected.Address(RVA = "0x6633A90", Offset = "0x6632E90", VA = "0x186633A90", Slot = "50")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A6")]
	public Transform BCEDFGPKPCG
	{
		[Cpp2IlInjected.Token(Token = "0x600025C")]
		[Cpp2IlInjected.Address(RVA = "0x66313C0", Offset = "0x66307C0", VA = "0x1866313C0", Slot = "51")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A7")]
	public Vector3 IMJAMINFNFO
	{
		[Cpp2IlInjected.Token(Token = "0x600025D")]
		[Cpp2IlInjected.Address(RVA = "0x6634590", Offset = "0x6633990", VA = "0x186634590", Slot = "52")]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x600025E")]
		[Cpp2IlInjected.Address(RVA = "0x6630980", Offset = "0x662FD80", VA = "0x186630980", Slot = "53")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A8")]
	public float AOLGPBNKCKH
	{
		[Cpp2IlInjected.Token(Token = "0x600025F")]
		[Cpp2IlInjected.Address(RVA = "0x66304A0", Offset = "0x662F8A0", VA = "0x1866304A0", Slot = "54")]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x6000260")]
		[Cpp2IlInjected.Address(RVA = "0x662FC30", Offset = "0x662F030", VA = "0x18662FC30", Slot = "55")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A9")]
	public float GDAJCJKIBLE
	{
		[Cpp2IlInjected.Token(Token = "0x6000261")]
		[Cpp2IlInjected.Address(RVA = "0x6631980", Offset = "0x6630D80", VA = "0x186631980", Slot = "56")]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x6000262")]
		[Cpp2IlInjected.Address(RVA = "0x6632B10", Offset = "0x6631F10", VA = "0x186632B10", Slot = "57")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000AA")]
	public Quaternion OIJGDFEHDPK
	{
		[Cpp2IlInjected.Token(Token = "0x6000263")]
		[Cpp2IlInjected.Address(RVA = "0x662F340", Offset = "0x662E740", VA = "0x18662F340", Slot = "58")]
		get
		{
			return default(Quaternion);
		}
		[Cpp2IlInjected.Token(Token = "0x6000264")]
		[Cpp2IlInjected.Address(RVA = "0x6632910", Offset = "0x6631D10", VA = "0x186632910", Slot = "59")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000AB")]
	public Vector3 PEDCHEEBCKD
	{
		[Cpp2IlInjected.Token(Token = "0x6000265")]
		[Cpp2IlInjected.Address(RVA = "0x6631290", Offset = "0x6630690", VA = "0x186631290", Slot = "60")]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x6000266")]
		[Cpp2IlInjected.Address(RVA = "0x6634540", Offset = "0x6633940", VA = "0x186634540", Slot = "61")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000AC")]
	public Quaternion IFBEDGFGEHN
	{
		[Cpp2IlInjected.Token(Token = "0x6000267")]
		[Cpp2IlInjected.Address(RVA = "0x66314E0", Offset = "0x66308E0", VA = "0x1866314E0", Slot = "62")]
		get
		{
			return default(Quaternion);
		}
		[Cpp2IlInjected.Token(Token = "0x6000268")]
		[Cpp2IlInjected.Address(RVA = "0x6632A60", Offset = "0x6631E60", VA = "0x186632A60", Slot = "63")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000AD")]
	public RigidbodyConstraints LFMJJPGKPGH
	{
		[Cpp2IlInjected.Token(Token = "0x600026C")]
		[Cpp2IlInjected.Address(RVA = "0x6634780", Offset = "0x6633B80", VA = "0x186634780", Slot = "64")]
		get
		{
			return default(RigidbodyConstraints);
		}
		[Cpp2IlInjected.Token(Token = "0x600026D")]
		[Cpp2IlInjected.Address(RVA = "0x662FDB0", Offset = "0x662F1B0", VA = "0x18662FDB0", Slot = "65")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000AE")]
	public bool KGIFFCDEOAE
	{
		[Cpp2IlInjected.Token(Token = "0x600026E")]
		[Cpp2IlInjected.Address(RVA = "0x66328C0", Offset = "0x6631CC0", VA = "0x1866328C0", Slot = "66")]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x600026F")]
		[Cpp2IlInjected.Address(RVA = "0x66335E0", Offset = "0x66329E0", VA = "0x1866335E0", Slot = "67")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000AF")]
	public CollisionDetectionMode BMACCDICLGG
	{
		[Cpp2IlInjected.Token(Token = "0x6000278")]
		[Cpp2IlInjected.Address(RVA = "0x66350C0", Offset = "0x66344C0", VA = "0x1866350C0", Slot = "68")]
		get
		{
			return default(CollisionDetectionMode);
		}
		[Cpp2IlInjected.Token(Token = "0x6000279")]
		[Cpp2IlInjected.Address(RVA = "0x6630D70", Offset = "0x6630170", VA = "0x186630D70", Slot = "69")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B0")]
	public bool FKKBJAAELGK
	{
		[Cpp2IlInjected.Token(Token = "0x600027B")]
		[Cpp2IlInjected.Address(RVA = "0x66322C0", Offset = "0x66316C0", VA = "0x1866322C0", Slot = "139")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B1")]
	public bool ALACEGOHBBC
	{
		[Cpp2IlInjected.Token(Token = "0x600027C")]
		[Cpp2IlInjected.Address(RVA = "0x66331B0", Offset = "0x66325B0", VA = "0x1866331B0", Slot = "70")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B2")]
	public bool COCOIKCCHKG
	{
		[Cpp2IlInjected.Token(Token = "0x600027D")]
		[Cpp2IlInjected.Address(RVA = "0x662F9A0", Offset = "0x662EDA0", VA = "0x18662F9A0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B3")]
	public bool MCMFALOPKBA
	{
		[Cpp2IlInjected.Token(Token = "0x600027E")]
		[Cpp2IlInjected.Address(RVA = "0x6631C80", Offset = "0x6631080", VA = "0x186631C80")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000021")]
	public event FLEHDNMKJOM DGFHCDMPNOC
	{
		[Cpp2IlInjected.Token(Token = "0x6000200")]
		[Cpp2IlInjected.Address(RVA = "0x6630FA0", Offset = "0x66303A0", VA = "0x186630FA0", Slot = "75")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000201")]
		[Cpp2IlInjected.Address(RVA = "0x6634EB0", Offset = "0x66342B0", VA = "0x186634EB0", Slot = "76")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000022")]
	public event FLEHDNMKJOM AJNJNDIOIEI
	{
		[Cpp2IlInjected.Token(Token = "0x6000202")]
		[Cpp2IlInjected.Address(RVA = "0x662FCA0", Offset = "0x662F0A0", VA = "0x18662FCA0", Slot = "77")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000203")]
		[Cpp2IlInjected.Address(RVA = "0x6632500", Offset = "0x6631900", VA = "0x186632500", Slot = "78")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000023")]
	public event GANGMHHLDKO EAAJADAMIEB
	{
		[Cpp2IlInjected.Token(Token = "0x6000204")]
		[Cpp2IlInjected.Address(RVA = "0x6634640", Offset = "0x6633A40", VA = "0x186634640", Slot = "79")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000205")]
		[Cpp2IlInjected.Address(RVA = "0x6631C20", Offset = "0x6631020", VA = "0x186631C20", Slot = "80")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000024")]
	public event FLEHDNMKJOM HLHMNNKNCHD
	{
		[Cpp2IlInjected.Token(Token = "0x600020C")]
		[Cpp2IlInjected.Address(RVA = "0x6630290", Offset = "0x662F690", VA = "0x186630290", Slot = "82")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600020D")]
		[Cpp2IlInjected.Address(RVA = "0x6630920", Offset = "0x662FD20", VA = "0x186630920", Slot = "83")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000025")]
	public event FLEHDNMKJOM OMOJLBAAJNO
	{
		[Cpp2IlInjected.Token(Token = "0x6000236")]
		[Cpp2IlInjected.Address(RVA = "0x6631F10", Offset = "0x6631310", VA = "0x186631F10", Slot = "102")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000237")]
		[Cpp2IlInjected.Address(RVA = "0x6631F70", Offset = "0x6631370", VA = "0x186631F70", Slot = "103")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000026")]
	public event FLEHDNMKJOM JOPHGGEPEGF
	{
		[Cpp2IlInjected.Token(Token = "0x600024A")]
		[Cpp2IlInjected.Address(RVA = "0x662F2E0", Offset = "0x662E6E0", VA = "0x18662F2E0", Slot = "107")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600024B")]
		[Cpp2IlInjected.Address(RVA = "0x66347D0", Offset = "0x6633BD0", VA = "0x1866347D0", Slot = "108")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000027")]
	public event Action<MMMOHCNLPFL, MMMOHCNLPFL> KKLFFLFCKKL
	{
		[Cpp2IlInjected.Token(Token = "0x600024F")]
		[Cpp2IlInjected.Address(RVA = "0x66325B0", Offset = "0x66319B0", VA = "0x1866325B0", Slot = "111")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000250")]
		[Cpp2IlInjected.Address(RVA = "0x66320A0", Offset = "0x66314A0", VA = "0x1866320A0", Slot = "112")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000028")]
	public event FLEHDNMKJOM DMOBFCJFCHG
	{
		[Cpp2IlInjected.Token(Token = "0x6000253")]
		[Cpp2IlInjected.Address(RVA = "0x662F890", Offset = "0x662EC90", VA = "0x18662F890", Slot = "113")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000254")]
		[Cpp2IlInjected.Address(RVA = "0x66317D0", Offset = "0x6630BD0", VA = "0x1866317D0", Slot = "114")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000029")]
	public event FLEHDNMKJOM PHEOCLOKCBC
	{
		[Cpp2IlInjected.Token(Token = "0x600025A")]
		[Cpp2IlInjected.Address(RVA = "0x662FD00", Offset = "0x662F100", VA = "0x18662FD00", Slot = "119")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600025B")]
		[Cpp2IlInjected.Address(RVA = "0x6630530", Offset = "0x662F930", VA = "0x186630530", Slot = "120")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001F9")]
	[Cpp2IlInjected.Address(RVA = "0x66351A0", Offset = "0x66345A0", VA = "0x1866351A0")]
	public AABMNPMKJNK(GameObject ILLDLCGIGNA, RigidbodyEx LLKNPEHAHCE, FCIHFBGEFGG IALOIPDIIAG, [In] OEDKMOJJJDN ALPLHOOHPEL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001FA")]
	[Cpp2IlInjected.Address(RVA = "0x66349D0", Offset = "0x6633DD0", VA = "0x1866349D0", Slot = "135")]
	protected virtual void OEHKNGNBPKP(FCIHFBGEFGG IALOIPDIIAG, OEDKMOJJJDN ALPLHOOHPEL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001FB")]
	[Cpp2IlInjected.Address(RVA = "0x66311C0", Offset = "0x66305C0", VA = "0x1866311C0", Slot = "136")]
	public virtual void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001FC")]
	[Cpp2IlInjected.Address(RVA = "0x662FA40", Offset = "0x662EE40", VA = "0x18662FA40", Slot = "71")]
	public void AHALPFGPHOF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001FD")]
	[Cpp2IlInjected.Address(RVA = "0x6631D00", Offset = "0x6631100", VA = "0x186631D00", Slot = "72")]
	public void FONLJBNDHEB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001FE")]
	[Cpp2IlInjected.Address(RVA = "0x6634150", Offset = "0x6633550", VA = "0x186634150", Slot = "73")]
	public void MJIHENGPCML()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001FF")]
	[Cpp2IlInjected.Address(RVA = "0x6633AE0", Offset = "0x6632EE0", VA = "0x186633AE0")]
	private void MBFELDBDGBB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600020B")]
	[Cpp2IlInjected.Address(RVA = "0x6632AA0", Offset = "0x6631EA0", VA = "0x186632AA0", Slot = "81")]
	public void IPJNFPFPNEM(JCOFHJBGHJA ANJCCKHBJJO, bool OHOCKJLAANC = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000222")]
	[Cpp2IlInjected.Address(RVA = "0x6634CC0", Offset = "0x66340C0", VA = "0x186634CC0", Slot = "84")]
	public void OFJHCOCGNAD(object BDHKJODLPCL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000223")]
	[Cpp2IlInjected.Address(RVA = "0x66338B0", Offset = "0x6632CB0", VA = "0x1866338B0", Slot = "85")]
	public void LAFHMMIGNHI(object BDHKJODLPCL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000224")]
	[Cpp2IlInjected.Address(RVA = "0x6631830", Offset = "0x6630C30", VA = "0x186631830", Slot = "86")]
	public Vector3 FAMKNNGPJGI(Vector3 ANEKCENIKFN)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000225")]
	[Cpp2IlInjected.Address(RVA = "0x6630820", Offset = "0x662FC20", VA = "0x186630820", Slot = "87")]
	public Vector3 CIMNPDLMMNF(Vector3 BNBPPNLIKAM)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000226")]
	[Cpp2IlInjected.Address(RVA = "0x6631D00", Offset = "0x6631100", VA = "0x186631D00", Slot = "88")]
	public void MEMDFIBKEPP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000227")]
	[Cpp2IlInjected.Address(RVA = "0x6631000", Offset = "0x6630400", VA = "0x186631000", Slot = "89")]
	public void DJHDKBHIGDN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000228")]
	[Cpp2IlInjected.Address(RVA = "0x6635110", Offset = "0x6634510", VA = "0x186635110", Slot = "90")]
	public void PNFNNMMCLFE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000229")]
	[Cpp2IlInjected.Address(RVA = "0x6630DD0", Offset = "0x66301D0", VA = "0x186630DD0", Slot = "91")]
	public void DENAIEDOENP(Vector3 FHLIJFCHIPI, Vector3 NEMLBHKHIJF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600022A")]
	[Cpp2IlInjected.Address(RVA = "0x6631520", Offset = "0x6630920", VA = "0x186631520", Slot = "92")]
	public void ENOBLMIPEAC(Vector3 KAAALJHMPDH, Vector3 BFLGOPEGDDM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600022B")]
	[Cpp2IlInjected.Address(RVA = "0x66341D0", Offset = "0x66335D0", VA = "0x1866341D0", Slot = "93")]
	public void MPFFKLHFEMH(Vector3 HBEOKBDKAPI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600022C")]
	[Cpp2IlInjected.Address(RVA = "0x6631050", Offset = "0x6630450", VA = "0x186631050", Slot = "94")]
	public void DLGALJLLKBC(IOIMFMPPEPK JJCOMEIHIFG, Vector3 LOPBIAGCJBL, float DJHFDGIPKCO, float GJGOKKJEDGM = 8f, float KHKMMDAMJPL = 1f)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600022D")]
	[Cpp2IlInjected.Address(RVA = "0x6631B80", Offset = "0x6630F80", VA = "0x186631B80", Slot = "95")]
	public void FIGBACLJNDD(HGAFDACKLPM ALPAKFKNNFG, Vector3 JMPMBOKBENO, float MGEJKMAAPFM = float.PositiveInfinity)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600022E")]
	[Cpp2IlInjected.Address(RVA = "0x6632810", Offset = "0x6631C10", VA = "0x186632810", Slot = "96")]
	[Obsolete("Deprecated. Still exists to support deprecated CV2 chips. Use ApplyAngularVelocityChange.")]
	public void IFNPBEKLMHH(HGAFDACKLPM ALPAKFKNNFG, Vector3 IKFFGJBHBIC, float KIDOONEEGII = 7f, float HDJMHGGGNBA = 1f)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600022F")]
	[Cpp2IlInjected.Address(RVA = "0x66326B0", Offset = "0x6631AB0", VA = "0x1866326B0", Slot = "97")]
	public Vector3 IEPIAOMDAAG(Vector3 ANJCCKHBJJO)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000230")]
	[Cpp2IlInjected.Address(RVA = "0x6632100", Offset = "0x6631500", VA = "0x186632100", Slot = "98")]
	public Vector3 GMNEMANIPAE(Vector3 ANJCCKHBJJO)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000231")]
	[Cpp2IlInjected.Address(RVA = "0x6633690", Offset = "0x6632A90", VA = "0x186633690", Slot = "99")]
	public void KJCKGCGOJBM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000234")]
	[Cpp2IlInjected.Address(RVA = "0x66304C0", Offset = "0x662F8C0", VA = "0x1866304C0", Slot = "100")]
	public void BMMKPJKFCJN(JCOFHJBGHJA OFCMPLLCIEA, object BDHKJODLPCL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000235")]
	[Cpp2IlInjected.Address(RVA = "0x6633470", Offset = "0x6632870", VA = "0x186633470", Slot = "101")]
	public void KFKPPNFPJGE(object BDHKJODLPCL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000240")]
	[Cpp2IlInjected.Address(RVA = "0x6634F10", Offset = "0x6634310", VA = "0x186634F10", Slot = "41")]
	public void PFEPHKNMKPF((Quaternion rot, Vector3 moments) EELLIIPGCJG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000241")]
	[Cpp2IlInjected.Address(RVA = "0x6634060", Offset = "0x6633460", VA = "0x186634060", Slot = "104")]
	public void MDMELEJAEMJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000242")]
	[Cpp2IlInjected.Address(RVA = "0x6633730", Offset = "0x6632B30", VA = "0x186633730", Slot = "105")]
	public void KNGNMHHLNOJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000243")]
	[Cpp2IlInjected.Address(RVA = "0x6633640", Offset = "0x6632A40", VA = "0x186633640", Slot = "106")]
	public void KJCFNJNJCNO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600024C")]
	[Cpp2IlInjected.Address(RVA = "0x6632560", Offset = "0x6631960", VA = "0x186632560", Slot = "109")]
	public bool HIMNDBELLFC()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600024D")]
	[Cpp2IlInjected.Address(RVA = "0x6631AD0", Offset = "0x6630ED0", VA = "0x186631AD0", Slot = "74")]
	public void FHCIIFMIADL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600024E")]
	[Cpp2IlInjected.Address(RVA = "0x6633A40", Offset = "0x6632E40", VA = "0x186633A40", Slot = "110")]
	public void LGECILGBLOD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000256")]
	[Cpp2IlInjected.Address(RVA = "0x6634D20", Offset = "0x6634120", VA = "0x186634D20", Slot = "115")]
	public IDisposable OHLNCDKJKKB()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000257")]
	[Cpp2IlInjected.Address(RVA = "0x6634970", Offset = "0x6633D70", VA = "0x186634970", Slot = "116")]
	public void OCIECADEFBE(object BDHKJODLPCL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000258")]
	[Cpp2IlInjected.Address(RVA = "0x662FE10", Offset = "0x662F210", VA = "0x18662FE10", Slot = "117")]
	public void BDHFACKMPAM(object BDHKJODLPCL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000259")]
	[Cpp2IlInjected.Address(RVA = "0x6633060", Offset = "0x6632460", VA = "0x186633060", Slot = "118")]
	public void JMJCHOCCJDP(object BDHKJODLPCL, bool JEKJDJALDPH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000269")]
	[Cpp2IlInjected.Address(RVA = "0x6630A90", Offset = "0x662FE90", VA = "0x186630A90", Slot = "121")]
	public void CNNKKJLCHHA(Vector3 IFADGICOBNM, Quaternion JJGEHCBPHJF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600026A")]
	[Cpp2IlInjected.Address(RVA = "0x662F3F0", Offset = "0x662E7F0", VA = "0x18662F3F0", Slot = "122")]
	public void AAOBGLOJCHA(Vector3 HJMGIFNAIIP, Quaternion PDEPBHFDPFN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600026B")]
	[Cpp2IlInjected.Address(RVA = "0x6630230", Offset = "0x662F630", VA = "0x186630230", Slot = "123")]
	public bool BFMEEBCMBCE(float COMNKNINMAC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000270")]
	[Cpp2IlInjected.Address(RVA = "0x6632A00", Offset = "0x6631E00", VA = "0x186632A00", Slot = "124")]
	public void ILKIHBCBCPP(object BDHKJODLPCL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000271")]
	[Cpp2IlInjected.Address(RVA = "0x6634350", Offset = "0x6633750", VA = "0x186634350", Slot = "125")]
	public void NBAIFBIDOJA(object BDHKJODLPCL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000272")]
	[Cpp2IlInjected.Address(RVA = "0x66327B0", Offset = "0x6631BB0", VA = "0x1866327B0", Slot = "126")]
	public void IFAGMNAOPKH(object BDHKJODLPCL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000273")]
	[Cpp2IlInjected.Address(RVA = "0x6634E50", Offset = "0x6634250", VA = "0x186634E50", Slot = "127")]
	public void ONPKKIOKJND(object BDHKJODLPCL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000274")]
	[Cpp2IlInjected.Address(RVA = "0x66316F0", Offset = "0x6630AF0", VA = "0x1866316F0", Slot = "128")]
	public void EOGJEEPJDGB(Vector3 BICEHKAFMDO, ForceMode NIBLDDDDGAO = ForceMode.Force)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000275")]
	[Cpp2IlInjected.Address(RVA = "0x66313D0", Offset = "0x66307D0", VA = "0x1866313D0", Slot = "129")]
	public void EGMCEHGBFBK(Vector3 BICEHKAFMDO, Vector3 BEBKKMFGLCG, ForceMode NIBLDDDDGAO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000276")]
	[Cpp2IlInjected.Address(RVA = "0x6630C90", Offset = "0x6630090", VA = "0x186630C90", Slot = "130")]
	public void DACJEFDGIGP(Vector3 IMFJIBNAPMK, ForceMode NIBLDDDDGAO = ForceMode.Force)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000277")]
	[Cpp2IlInjected.Address(RVA = "0x6632C10", Offset = "0x6632010", VA = "0x186632C10", Slot = "131")]
	public void JCCBIGPFMFC(Vector3 IMFJIBNAPMK, ForceMode NIBLDDDDGAO = ForceMode.Force)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600027A")]
	[Cpp2IlInjected.Address(RVA = "0x6632610", Offset = "0x6631A10", VA = "0x186632610", Slot = "132")]
	public bool HMFCJNOKJNG(Vector3 PNADBCDBNOL, [Out] RaycastHit FDAHIHAIBKD, float FIOIECEGGAH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600027F")]
	[Cpp2IlInjected.Address(RVA = "0x66319A0", Offset = "0x6630DA0", VA = "0x1866319A0", Slot = "133")]
	public void FFOPCPPNJNP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000280")]
	[Cpp2IlInjected.Address(RVA = "0x6635160", Offset = "0x6634560", VA = "0x186635160", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000281")]
	[Cpp2IlInjected.Address(RVA = "0x66343B0", Offset = "0x66337B0", VA = "0x1866343B0")]
	private void NBDCNFKNPHH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000282")]
	[Cpp2IlInjected.Address(RVA = "0x66334D0", Offset = "0x66328D0", VA = "0x1866334D0")]
	private void KICNBNKHMHI(JCOFHJBGHJA EMDODFFCGEF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000283")]
	[Cpp2IlInjected.Address(RVA = "0x6630630", Offset = "0x662FA30", VA = "0x186630630")]
	private void CBPECALIJIC(JCOFHJBGHJA EMDODFFCGEF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000284")]
	[Cpp2IlInjected.Address(RVA = "0x662F8F0", Offset = "0x662ECF0", VA = "0x18662F8F0")]
	private void AFBFEHCBDPP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000285")]
	[Cpp2IlInjected.Address(RVA = "0x6632400", Offset = "0x6631800", VA = "0x186632400")]
	private void HGOGJDJKDGA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000286")]
	[Cpp2IlInjected.Address(RVA = "0x6632CF0", Offset = "0x66320F0", VA = "0x186632CF0")]
	private void JCFDKCPGALK(JCOFHJBGHJA KBNLAPAAIPK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000287")]
	[Cpp2IlInjected.Address(RVA = "0x66302F0", Offset = "0x662F6F0", VA = "0x1866302F0")]
	private void BKKACFBKLDE(JCOFHJBGHJA EMDODFFCGEF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000288")]
	[Cpp2IlInjected.Address(RVA = "0x6634FF0", Offset = "0x66343F0", VA = "0x186634FF0")]
	private void PGLFNOHKLFE(JCOFHJBGHJA EMDODFFCGEF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000289")]
	[Cpp2IlInjected.Address(RVA = "0x6631D50", Offset = "0x6631150", VA = "0x186631D50")]
	private void FPBKMLEKEJI(RigidbodyEx EMDODFFCGEF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600028A")]
	[Cpp2IlInjected.Address(RVA = "0x662F620", Offset = "0x662EA20", VA = "0x18662F620", Slot = "140")]
	protected virtual void ACEOCLPJPIH(RigidbodyEx ICFAMCDBCJP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600028B")]
	[Cpp2IlInjected.Address(RVA = "0x6633D40", Offset = "0x6633140", VA = "0x186633D40")]
	protected void MCNAPHEDDAH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600028C")]
	[Cpp2IlInjected.Address(RVA = "0x662FEC0", Offset = "0x662F2C0", VA = "0x18662FEC0")]
	protected void BFEBJJFGGPN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600028D")]
	[Cpp2IlInjected.Address(RVA = "0x66342B0", Offset = "0x66336B0", VA = "0x1866342B0", Slot = "141")]
	protected virtual IDisposable NAJNBEFJBHC()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000028")]
internal static class MNNHDFCEMEH
{
	[Cpp2IlInjected.Token(Token = "0x600028E")]
	[Cpp2IlInjected.Address(RVA = "0x664E660", Offset = "0x664DA60", VA = "0x18664E660")]
	public static JCOFHJBGHJA OFEGMEPOCHK(this JCOFHJBGHJA ICFAMCDBCJP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600028F")]
	[Cpp2IlInjected.Address(RVA = "0x664E510", Offset = "0x664D910", VA = "0x18664E510")]
	public static bool FBBJAEAKAAC(this JCOFHJBGHJA ICFAMCDBCJP, JCOFHJBGHJA DHIPEOBMPEO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000290")]
	[Cpp2IlInjected.Address(RVA = "0x664E490", Offset = "0x664D890", VA = "0x18664E490")]
	public static bool DEELCPOIEFM(this JCOFHJBGHJA ICFAMCDBCJP, JCOFHJBGHJA OBBAPIPGKBM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000291")]
	[Cpp2IlInjected.Address(RVA = "0x664E590", Offset = "0x664D990", VA = "0x18664E590")]
	public static RigidbodyEx FNPOFPMCEAK(this JCOFHJBGHJA PBEAHKDNFOA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000292")]
	[Cpp2IlInjected.Address(RVA = "0x664E5E0", Offset = "0x664D9E0", VA = "0x18664E5E0")]
	public static AABMNPMKJNK NKPCFLEGDEH(this JCOFHJBGHJA FBIBFNALIEI)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000029")]
internal class EMAKAHDDLFH : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000040")]
	private readonly AABMNPMKJNK ICFAMCDBCJP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000041")]
	private bool KAJILOPLFHP;

	[Cpp2IlInjected.Token(Token = "0x6000293")]
	[Cpp2IlInjected.Address(RVA = "0x6643830", Offset = "0x6642C30", VA = "0x186643830")]
	public EMAKAHDDLFH(AABMNPMKJNK DMMNOJMKOEO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000294")]
	[Cpp2IlInjected.Address(RVA = "0x66437D0", Offset = "0x6642BD0", VA = "0x1866437D0", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002A")]
internal sealed class GOBIHJAFFID : DELIINBMKOF, NDECPKLCGPL
{
	[Cpp2IlInjected.Token(Token = "0x170000B4")]
	private CollisionDetectionMode EHGHCNBGIMB
	{
		[Cpp2IlInjected.Token(Token = "0x6000296")]
		[Cpp2IlInjected.Address(RVA = "0x6647C10", Offset = "0x6647010", VA = "0x186647C10")]
		get
		{
			return default(CollisionDetectionMode);
		}
		[Cpp2IlInjected.Token(Token = "0x6000297")]
		[Cpp2IlInjected.Address(RVA = "0x6647C70", Offset = "0x6647070", VA = "0x186647C70")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B5")]
	private Rigidbody OHEHDKEKPMJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000298")]
		[Cpp2IlInjected.Address(RVA = "0x663E570", Offset = "0x663D970", VA = "0x18663E570")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B6")]
	public CollisionDetectionMode BMACCDICLGG
	{
		[Cpp2IlInjected.Token(Token = "0x600029B")]
		[Cpp2IlInjected.Address(RVA = "0x6647CE0", Offset = "0x66470E0", VA = "0x186647CE0", Slot = "4")]
		get
		{
			return default(CollisionDetectionMode);
		}
		[Cpp2IlInjected.Token(Token = "0x600029C")]
		[Cpp2IlInjected.Address(RVA = "0x6647860", Offset = "0x6646C60", VA = "0x186647860", Slot = "5")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000295")]
	[Cpp2IlInjected.Address(RVA = "0x663C2A0", Offset = "0x663B6A0", VA = "0x18663C2A0")]
	public GOBIHJAFFID(JCOFHJBGHJA ICFAMCDBCJP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000299")]
	[Cpp2IlInjected.Address(RVA = "0x6647710", Offset = "0x6646B10", VA = "0x186647710", Slot = "6")]
	public void AHALPFGPHOF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600029A")]
	[Cpp2IlInjected.Address(RVA = "0x6647630", Offset = "0x6646A30", VA = "0x186647630", Slot = "9")]
	public void AEMAJDMNPCO(Rigidbody ADEHOEHEFLF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600029D")]
	[Cpp2IlInjected.Address(RVA = "0x6647AA0", Offset = "0x6646EA0", VA = "0x186647AA0", Slot = "7")]
	public void GCEKOKLNFKE(bool JEELKKFJOMD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600029E")]
	[Cpp2IlInjected.Address(RVA = "0x6647A90", Offset = "0x6646E90", VA = "0x186647A90", Slot = "8")]
	public void FCIGBFFNGFJ(bool JEELKKFJOMD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600029F")]
	[Cpp2IlInjected.Address(RVA = "0x6647AB0", Offset = "0x6646EB0", VA = "0x186647AB0", Slot = "10")]
	public bool HMFCJNOKJNG(Vector3 PNADBCDBNOL, [Out] RaycastHit FDAHIHAIBKD, float FIOIECEGGAH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002A0")]
	[Cpp2IlInjected.Address(RVA = "0x6647920", Offset = "0x6646D20", VA = "0x186647920")]
	private void DFOKKEPDKAK(bool JEELKKFJOMD)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002B")]
internal sealed class HLPBPNOGPLM : DELIINBMKOF, NHEBLBOICHI, IDisposable, AMAGPLIHPFI
{
	[Cpp2IlInjected.Token(Token = "0x170000B7")]
	public GOOCPGCLLJK BOCECGJCJKB
	{
		[Cpp2IlInjected.Token(Token = "0x60002A4")]
		[Cpp2IlInjected.Address(RVA = "0x6648140", Offset = "0x6647540", VA = "0x186648140")]
		get
		{
			return default(GOOCPGCLLJK);
		}
		[Cpp2IlInjected.Token(Token = "0x60002A5")]
		[Cpp2IlInjected.Address(RVA = "0x6648380", Offset = "0x6647780", VA = "0x186648380")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B8")]
	public GOOCPGCLLJK OKHKDAGKHIN
	{
		[Cpp2IlInjected.Token(Token = "0x60002A6")]
		[Cpp2IlInjected.Address(RVA = "0x6647F40", Offset = "0x6647340", VA = "0x186647F40", Slot = "6")]
		get
		{
			return default(GOOCPGCLLJK);
		}
		[Cpp2IlInjected.Token(Token = "0x60002A7")]
		[Cpp2IlInjected.Address(RVA = "0x6648380", Offset = "0x6647780", VA = "0x186648380", Slot = "7")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B9")]
	private Transform HNOHFJILGJJ
	{
		[Cpp2IlInjected.Token(Token = "0x60002AC")]
		[Cpp2IlInjected.Address(RVA = "0x7A0910", Offset = "0x79FD10", VA = "0x1807A0910", Slot = "10")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400002A")]
	public event Action<MMMOHCNLPFL, MMMOHCNLPFL> KKLFFLFCKKL
	{
		[Cpp2IlInjected.Token(Token = "0x60002A2")]
		[Cpp2IlInjected.Address(RVA = "0x66482D0", Offset = "0x66476D0", VA = "0x1866482D0", Slot = "4")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60002A3")]
		[Cpp2IlInjected.Address(RVA = "0x6648220", Offset = "0x6647620", VA = "0x186648220", Slot = "5")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60002A1")]
	[Cpp2IlInjected.Address(RVA = "0x663C2A0", Offset = "0x663B6A0", VA = "0x18663C2A0")]
	public HLPBPNOGPLM(JCOFHJBGHJA ICFAMCDBCJP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002A8")]
	[Cpp2IlInjected.Address(RVA = "0x6648470", Offset = "0x6647870", VA = "0x186648470", Slot = "11")]
	public void OnChangedDistanceBand(MMMOHCNLPFL BIHDJPFDCHH, MMMOHCNLPFL MLMOJGJLJGF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002A9")]
	[Cpp2IlInjected.Address(RVA = "0x7A0900", Offset = "0x79FD00", VA = "0x1807A0900", Slot = "12")]
	public void OnChangedVisibility(bool MPCCPHNCACM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002AA")]
	[Cpp2IlInjected.Address(RVA = "0x7A0900", Offset = "0x79FD00", VA = "0x1807A0900", Slot = "8")]
	public void AHALPFGPHOF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002AB")]
	[Cpp2IlInjected.Address(RVA = "0x7A0900", Offset = "0x79FD00", VA = "0x1807A0900", Slot = "9")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002C")]
internal sealed class IFEOGJBLPDO : DELIINBMKOF, PNBKJNMIIDD
{
	[Cpp2IlInjected.Token(Token = "0x170000BA")]
	private Rigidbody OHEHDKEKPMJ
	{
		[Cpp2IlInjected.Token(Token = "0x60002AE")]
		[Cpp2IlInjected.Address(RVA = "0x663E570", Offset = "0x663D970", VA = "0x18663E570")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000BB")]
	private bool LBJIFIJGLFG
	{
		[Cpp2IlInjected.Token(Token = "0x60002AF")]
		[Cpp2IlInjected.Address(RVA = "0x664A340", Offset = "0x6649740", VA = "0x18664A340")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000BC")]
	private bool PJOOMDNDEDM
	{
		[Cpp2IlInjected.Token(Token = "0x60002B0")]
		[Cpp2IlInjected.Address(RVA = "0x6649680", Offset = "0x6648A80", VA = "0x186649680")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000BD")]
	private JCOFHJBGHJA EOGAOJCDEEE
	{
		[Cpp2IlInjected.Token(Token = "0x60002B1")]
		[Cpp2IlInjected.Address(RVA = "0x66494C0", Offset = "0x66488C0", VA = "0x1866494C0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60002AD")]
	[Cpp2IlInjected.Address(RVA = "0x663C2A0", Offset = "0x663B6A0", VA = "0x18663C2A0")]
	public IFEOGJBLPDO(JCOFHJBGHJA ICFAMCDBCJP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002B2")]
	[Cpp2IlInjected.Address(RVA = "0x6649960", Offset = "0x6648D60", VA = "0x186649960", Slot = "4")]
	public void EOGJEEPJDGB(Vector3 BICEHKAFMDO, ForceMode NIBLDDDDGAO = ForceMode.Force)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002B3")]
	[Cpp2IlInjected.Address(RVA = "0x6649D20", Offset = "0x6649120", VA = "0x186649D20")]
	private void HILLBBNNHKO(Vector3 BICEHKAFMDO, ForceMode NIBLDDDDGAO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002B4")]
	[Cpp2IlInjected.Address(RVA = "0x66496E0", Offset = "0x6648AE0", VA = "0x1866496E0", Slot = "5")]
	public void EGMCEHGBFBK(Vector3 BICEHKAFMDO, Vector3 BEBKKMFGLCG, ForceMode NIBLDDDDGAO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002B5")]
	[Cpp2IlInjected.Address(RVA = "0x6649520", Offset = "0x6648920", VA = "0x186649520", Slot = "6")]
	public void DACJEFDGIGP(Vector3 IMFJIBNAPMK, ForceMode NIBLDDDDGAO = ForceMode.Force)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002B6")]
	[Cpp2IlInjected.Address(RVA = "0x6649AC0", Offset = "0x6648EC0", VA = "0x186649AC0")]
	private void GMPNGHGLLAN(Vector3 IMFJIBNAPMK, ForceMode NIBLDDDDGAO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002B7")]
	[Cpp2IlInjected.Address(RVA = "0x664A0E0", Offset = "0x66494E0", VA = "0x18664A0E0", Slot = "7")]
	public void JCCBIGPFMFC(Vector3 IMFJIBNAPMK, ForceMode NIBLDDDDGAO = ForceMode.Force)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002B8")]
	[Cpp2IlInjected.Address(RVA = "0x664A000", Offset = "0x6649400", VA = "0x18664A000")]
	private void JBOJMAMBIHB(string CAIOIMEOMNJ, UnityEngine.Object HFPPGLCONIA)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002D")]
internal sealed class OLBOFCEAHBF : DELIINBMKOF, APDCPHMDBJE
{
	[Cpp2IlInjected.Token(Token = "0x170000BE")]
	public bool PPOPHDEHNNA
	{
		[Cpp2IlInjected.Token(Token = "0x60002BA")]
		[Cpp2IlInjected.Address(RVA = "0x66516B0", Offset = "0x6650AB0", VA = "0x1866516B0", Slot = "4")]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x60002BB")]
		[Cpp2IlInjected.Address(RVA = "0x66514D0", Offset = "0x66508D0", VA = "0x1866514D0", Slot = "5")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60002B9")]
	[Cpp2IlInjected.Address(RVA = "0x663C2A0", Offset = "0x663B6A0", VA = "0x18663C2A0")]
	public OLBOFCEAHBF(JCOFHJBGHJA ICFAMCDBCJP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002BC")]
	[Cpp2IlInjected.Address(RVA = "0x6651620", Offset = "0x6650A20", VA = "0x186651620", Slot = "6")]
	public void AEMAJDMNPCO(Rigidbody ADEHOEHEFLF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002BD")]
	[Cpp2IlInjected.Address(RVA = "0x66353B0", Offset = "0x66347B0", VA = "0x1866353B0", Slot = "7")]
	public void OLACCOJPAIO(Rigidbody ADEHOEHEFLF)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002E")]
internal sealed class CMJFAHFCIOA : DELIINBMKOF, DFEBEBBPEII, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x4000043")]
	private static readonly OKECMMGLCGL ECDFMFAMKLE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x400004D")]
	private readonly JAEIBBHLDFF EIIHCFMKBHO;

	[Cpp2IlInjected.Token(Token = "0x170000BF")]
	private Transform ODAEKBBDPFC
	{
		[Cpp2IlInjected.Token(Token = "0x60002D1")]
		[Cpp2IlInjected.Address(RVA = "0x6637C00", Offset = "0x6637000", VA = "0x186637C00")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000C0")]
	public FNONGLLGKNI LEAOLOGLNHL
	{
		[Cpp2IlInjected.Token(Token = "0x60002D3")]
		[Cpp2IlInjected.Address(RVA = "0x6636760", Offset = "0x6635B60", VA = "0x186636760")]
		get
		{
			return default(FNONGLLGKNI);
		}
		[Cpp2IlInjected.Token(Token = "0x60002D4")]
		[Cpp2IlInjected.Address(RVA = "0x6636F10", Offset = "0x6636310", VA = "0x186636F10")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000C1")]
	public JCOFHJBGHJA EOGAOJCDEEE
	{
		[Cpp2IlInjected.Token(Token = "0x60002D5")]
		[Cpp2IlInjected.Address(RVA = "0x66366F0", Offset = "0x6635AF0", VA = "0x1866366F0", Slot = "24")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60002D6")]
		[Cpp2IlInjected.Address(RVA = "0x6637C30", Offset = "0x6637030", VA = "0x186637C30", Slot = "25")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000C2")]
	public FNONGLLGKNI AGOAMLFDJIB
	{
		[Cpp2IlInjected.Token(Token = "0x60002D7")]
		[Cpp2IlInjected.Address(RVA = "0x66379C0", Offset = "0x6636DC0", VA = "0x1866379C0")]
		get
		{
			return default(FNONGLLGKNI);
		}
		[Cpp2IlInjected.Token(Token = "0x60002D8")]
		[Cpp2IlInjected.Address(RVA = "0x6637AF0", Offset = "0x6636EF0", VA = "0x186637AF0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000C3")]
	public JCOFHJBGHJA OPHGKOLAGBH
	{
		[Cpp2IlInjected.Token(Token = "0x60002D9")]
		[Cpp2IlInjected.Address(RVA = "0x6637D40", Offset = "0x6637140", VA = "0x186637D40", Slot = "23")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000C4")]
	public IReadOnlyList<JCOFHJBGHJA> OPIGCLHIKGM
	{
		[Cpp2IlInjected.Token(Token = "0x60002DA")]
		[Cpp2IlInjected.Address(RVA = "0x7A6820", Offset = "0x7A5C20", VA = "0x1807A6820", Slot = "22")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400002B")]
	public event FLEHDNMKJOM DGFHCDMPNOC
	{
		[Cpp2IlInjected.Token(Token = "0x60002BF")]
		[Cpp2IlInjected.Address(RVA = "0x6637030", Offset = "0x6636430", VA = "0x186637030", Slot = "4")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60002C0")]
		[Cpp2IlInjected.Address(RVA = "0x6638350", Offset = "0x6637750", VA = "0x186638350", Slot = "5")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400002C")]
	public event FLEHDNMKJOM AJNJNDIOIEI
	{
		[Cpp2IlInjected.Token(Token = "0x60002C1")]
		[Cpp2IlInjected.Address(RVA = "0x6636860", Offset = "0x6635C60", VA = "0x186636860", Slot = "6")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60002C2")]
		[Cpp2IlInjected.Address(RVA = "0x66377E0", Offset = "0x6636BE0", VA = "0x1866377E0", Slot = "7")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400002D")]
	public event GANGMHHLDKO EAAJADAMIEB
	{
		[Cpp2IlInjected.Token(Token = "0x60002C3")]
		[Cpp2IlInjected.Address(RVA = "0x6637E60", Offset = "0x6637260", VA = "0x186637E60", Slot = "8")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60002C4")]
		[Cpp2IlInjected.Address(RVA = "0x6637490", Offset = "0x6636890", VA = "0x186637490", Slot = "9")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400002E")]
	public event Action HGBAPGIEKIL
	{
		[Cpp2IlInjected.Token(Token = "0x60002C5")]
		[Cpp2IlInjected.Address(RVA = "0x6637CA0", Offset = "0x66370A0", VA = "0x186637CA0", Slot = "10")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60002C6")]
		[Cpp2IlInjected.Address(RVA = "0x6637880", Offset = "0x6636C80", VA = "0x186637880", Slot = "11")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400002F")]
	public event Action PJNMCFKMOFA
	{
		[Cpp2IlInjected.Token(Token = "0x60002C7")]
		[Cpp2IlInjected.Address(RVA = "0x6638200", Offset = "0x6637600", VA = "0x186638200", Slot = "12")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60002C8")]
		[Cpp2IlInjected.Address(RVA = "0x6637B60", Offset = "0x6636F60", VA = "0x186637B60", Slot = "13")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000030")]
	public event Action<JCOFHJBGHJA> FLGHEEMILPM
	{
		[Cpp2IlInjected.Token(Token = "0x60002C9")]
		[Cpp2IlInjected.Address(RVA = "0x6637DB0", Offset = "0x66371B0", VA = "0x186637DB0", Slot = "14")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60002CA")]
		[Cpp2IlInjected.Address(RVA = "0x6636F80", Offset = "0x6636380", VA = "0x186636F80", Slot = "15")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000031")]
	public event Action<JCOFHJBGHJA> HCIHFOBNDID
	{
		[Cpp2IlInjected.Token(Token = "0x60002CB")]
		[Cpp2IlInjected.Address(RVA = "0x6637F00", Offset = "0x6637300", VA = "0x186637F00", Slot = "16")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60002CC")]
		[Cpp2IlInjected.Address(RVA = "0x6637730", Offset = "0x6636B30", VA = "0x186637730", Slot = "17")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000032")]
	public event Action MNPKJEPOBON
	{
		[Cpp2IlInjected.Token(Token = "0x60002CD")]
		[Cpp2IlInjected.Address(RVA = "0x66367C0", Offset = "0x6635BC0", VA = "0x1866367C0", Slot = "18")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60002CE")]
		[Cpp2IlInjected.Address(RVA = "0x6636650", Offset = "0x6635A50", VA = "0x186636650", Slot = "19")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000033")]
	public event Action<JCOFHJBGHJA> OFPCHFBMHAN
	{
		[Cpp2IlInjected.Token(Token = "0x60002CF")]
		[Cpp2IlInjected.Address(RVA = "0x66382A0", Offset = "0x66376A0", VA = "0x1866382A0", Slot = "20")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60002D0")]
		[Cpp2IlInjected.Address(RVA = "0x66383F0", Offset = "0x66377F0", VA = "0x1866383F0", Slot = "21")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60002BE")]
	[Cpp2IlInjected.Address(RVA = "0x6638530", Offset = "0x6637930", VA = "0x186638530")]
	public CMJFAHFCIOA(JCOFHJBGHJA ICFAMCDBCJP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002D2")]
	[Cpp2IlInjected.Address(RVA = "0x66370D0", Offset = "0x66364D0", VA = "0x1866370D0", Slot = "27")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002DB")]
	[Cpp2IlInjected.Address(RVA = "0x6637A20", Offset = "0x6636E20", VA = "0x186637A20", Slot = "26")]
	public void IPJNFPFPNEM(JCOFHJBGHJA FOONBHGCLLE, bool OHOCKJLAANC = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002DC")]
	[Cpp2IlInjected.Address(RVA = "0x6637AA0", Offset = "0x6636EA0", VA = "0x186637AA0")]
	private void IPJNFPFPNEM(POGPNNCOCBE FOONBHGCLLE, bool OHOCKJLAANC = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002DD")]
	[Cpp2IlInjected.Address(RVA = "0x6636A90", Offset = "0x6635E90", VA = "0x186636A90")]
	private void CLIEIKJGBBL(POGPNNCOCBE FOONBHGCLLE, bool OHOCKJLAANC = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002DE")]
	[Cpp2IlInjected.Address(RVA = "0x6637FB0", Offset = "0x66373B0", VA = "0x186637FB0")]
	private void OIELMHGCNDB(POGPNNCOCBE KBNLAPAAIPK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002DF")]
	[Cpp2IlInjected.Address(RVA = "0x6637530", Offset = "0x6636930", VA = "0x186637530")]
	private void GECFDCOPMHK(POGPNNCOCBE KBNLAPAAIPK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002E0")]
	[Cpp2IlInjected.Address(RVA = "0x6637200", Offset = "0x6636600", VA = "0x186637200")]
	private void EFCAODNGOOF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002E1")]
	[Cpp2IlInjected.Address(RVA = "0x66373E0", Offset = "0x66367E0", VA = "0x1866373E0")]
	private void FHJDEHJPPBB(POGPNNCOCBE KBNLAPAAIPK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002E2")]
	[Cpp2IlInjected.Address(RVA = "0x66369A0", Offset = "0x6635DA0", VA = "0x1866369A0")]
	private void CHHNIKJCLMM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002E3")]
	[Cpp2IlInjected.Address(RVA = "0x6636900", Offset = "0x6635D00", VA = "0x186636900")]
	private void CBNJEMBLCPC(POGPNNCOCBE ICFAMCDBCJP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002E4")]
	[Cpp2IlInjected.Address(RVA = "0x6637920", Offset = "0x6636D20", VA = "0x186637920")]
	private void IALHOMHICOG(POGPNNCOCBE ICFAMCDBCJP)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002F")]
internal static class PPADHDLIIMG
{
	[Cpp2IlInjected.Token(Token = "0x60002E6")]
	[Cpp2IlInjected.Address(RVA = "0x6654420", Offset = "0x6653820", VA = "0x186654420")]
	public static CMJFAHFCIOA LHMFADBCBJJ(this JCOFHJBGHJA FBIBFNALIEI)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000030")]
internal sealed class OHDNNGOLGFF : DELIINBMKOF, JJMHLHBDECD
{
	[Cpp2IlInjected.Token(Token = "0x170000C5")]
	public Vector3 JAEHHIFFHAO
	{
		[Cpp2IlInjected.Token(Token = "0x60002E8")]
		[Cpp2IlInjected.Address(RVA = "0x664F940", Offset = "0x664ED40", VA = "0x18664F940", Slot = "4")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000C6")]
	public Vector3 DBENDJKNCLA
	{
		[Cpp2IlInjected.Token(Token = "0x60002E9")]
		[Cpp2IlInjected.Address(RVA = "0x664F5B0", Offset = "0x664E9B0", VA = "0x18664F5B0", Slot = "5")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000C7")]
	private Vector3 BPGONCPMPON
	{
		[Cpp2IlInjected.Token(Token = "0x60002ED")]
		[Cpp2IlInjected.Address(RVA = "0x664F040", Offset = "0x664E440", VA = "0x18664F040")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000C8")]
	private JCOFHJBGHJA FGJHCPAEPDL
	{
		[Cpp2IlInjected.Token(Token = "0x60002EE")]
		[Cpp2IlInjected.Address(RVA = "0x664F7E0", Offset = "0x664EBE0", VA = "0x18664F7E0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60002E7")]
	[Cpp2IlInjected.Address(RVA = "0x663C2A0", Offset = "0x663B6A0", VA = "0x18663C2A0")]
	public OHDNNGOLGFF(JCOFHJBGHJA ICFAMCDBCJP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002EA")]
	[Cpp2IlInjected.Address(RVA = "0x664F970", Offset = "0x664ED70", VA = "0x18664F970", Slot = "6")]
	public void PPDBDEBJGCD(JCOFHJBGHJA EMDODFFCGEF, object BDHKJODLPCL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002EB")]
	[Cpp2IlInjected.Address(RVA = "0x664FAC0", Offset = "0x664EEC0", VA = "0x18664FAC0")]
	private void PPDBDEBJGCD(POGPNNCOCBE EMDODFFCGEF, object BDHKJODLPCL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002EC")]
	[Cpp2IlInjected.Address(RVA = "0x664F130", Offset = "0x664E530", VA = "0x18664F130", Slot = "7")]
	public void DJBONJGLIDM(object BDHKJODLPCL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002EF")]
	[Cpp2IlInjected.Address(RVA = "0x664F1A0", Offset = "0x664E5A0", VA = "0x18664F1A0")]
	private Vector3 KHJOPIOPCPO()
	{
		return default(Vector3);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000031")]
internal static class GPPIHMLEMDF
{
	[Cpp2IlInjected.Token(Token = "0x60002F0")]
	[Cpp2IlInjected.Address(RVA = "0x6647DF0", Offset = "0x66471F0", VA = "0x186647DF0")]
	public static OHDNNGOLGFF OJPCPGGGPDD(this JCOFHJBGHJA FBIBFNALIEI)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000032")]
internal sealed class CPJGCCJFFIG : DELIINBMKOF, KPKDIHHLHAL
{
	[Cpp2IlInjected.Token(Token = "0x170000C9")]
	[Obsolete("Use LocalCenterOfMassOfSelf or LocalCenterOfMassOfHierarchy, as LocalCenterOfMass changes based on context")]
	public Vector3 DKCKPGONLCO
	{
		[Cpp2IlInjected.Token(Token = "0x60002F4")]
		[Cpp2IlInjected.Address(RVA = "0x663E280", Offset = "0x663D680", VA = "0x18663E280", Slot = "6")]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x60002F5")]
		[Cpp2IlInjected.Address(RVA = "0x663E790", Offset = "0x663DB90", VA = "0x18663E790", Slot = "7")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000CA")]
	public Vector3 JLAGGIIKMDB
	{
		[Cpp2IlInjected.Token(Token = "0x60002F6")]
		[Cpp2IlInjected.Address(RVA = "0x663DBD0", Offset = "0x663CFD0", VA = "0x18663DBD0")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000CB")]
	public Vector3 KHMCNBJDGOL
	{
		[Cpp2IlInjected.Token(Token = "0x60002F8")]
		[Cpp2IlInjected.Address(RVA = "0x663E940", Offset = "0x663DD40", VA = "0x18663E940")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000CC")]
	[Obsolete("Use TryGetWorldCenterOfMassOfHierarchy() or GetWorldCenterOfMassOfSelf()")]
	public Vector3 EAIFIKDGKFD
	{
		[Cpp2IlInjected.Token(Token = "0x60002F9")]
		[Cpp2IlInjected.Address(RVA = "0x663EF20", Offset = "0x663E320", VA = "0x18663EF20", Slot = "8")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000CD")]
	[Obsolete("Use MassOfSelf or TryGetMassOfHierarchy instead")]
	public float LOOBEDBGKGP
	{
		[Cpp2IlInjected.Token(Token = "0x60002FA")]
		[Cpp2IlInjected.Address(RVA = "0x663EEC0", Offset = "0x663E2C0", VA = "0x18663EEC0", Slot = "9")]
		get
		{
			return default(float);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000CE")]
	public float ANHLDALIHBL
	{
		[Cpp2IlInjected.Token(Token = "0x60002FB")]
		[Cpp2IlInjected.Address(RVA = "0x663E5F0", Offset = "0x663D9F0", VA = "0x18663E5F0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000CF")]
	public float LLPPBNBJAIJ
	{
		[Cpp2IlInjected.Token(Token = "0x60002FC")]
		[Cpp2IlInjected.Address(RVA = "0x663C4D0", Offset = "0x663B8D0", VA = "0x18663C4D0", Slot = "10")]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x60002FD")]
		[Cpp2IlInjected.Address(RVA = "0x663C410", Offset = "0x663B810", VA = "0x18663C410", Slot = "11")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000D0")]
	public Vector3 GPBCJEBAHGH
	{
		[Cpp2IlInjected.Token(Token = "0x60002FE")]
		[Cpp2IlInjected.Address(RVA = "0x663E910", Offset = "0x663DD10", VA = "0x18663E910", Slot = "12")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000D1")]
	public Quaternion PNNPLKIEMEL
	{
		[Cpp2IlInjected.Token(Token = "0x60002FF")]
		[Cpp2IlInjected.Address(RVA = "0x663E5C0", Offset = "0x663D9C0", VA = "0x18663E5C0", Slot = "13")]
		get
		{
			return default(Quaternion);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000D2")]
	private Rigidbody OHEHDKEKPMJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000308")]
		[Cpp2IlInjected.Address(RVA = "0x663E570", Offset = "0x663D970", VA = "0x18663E570")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000034")]
	public event FLEHDNMKJOM JAEBJNGECMP
	{
		[Cpp2IlInjected.Token(Token = "0x60002F1")]
		[Cpp2IlInjected.Address(RVA = "0x663F730", Offset = "0x663EB30", VA = "0x18663F730", Slot = "4")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60002F2")]
		[Cpp2IlInjected.Address(RVA = "0x663EA70", Offset = "0x663DE70", VA = "0x18663EA70", Slot = "5")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60002F3")]
	[Cpp2IlInjected.Address(RVA = "0x663FA60", Offset = "0x663EE60", VA = "0x18663FA60")]
	public CPJGCCJFFIG(JCOFHJBGHJA ICFAMCDBCJP, [In] OEDKMOJJJDN ALPLHOOHPEL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002F7")]
	[Cpp2IlInjected.Address(RVA = "0x663E670", Offset = "0x663DA70", VA = "0x18663E670")]
	public float3 HHMFNNMELPA()
	{
		return default(float3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000300")]
	[Cpp2IlInjected.Address(RVA = "0x663F7D0", Offset = "0x663EBD0", VA = "0x18663F7D0", Slot = "14")]
	public void PFEPHKNMKPF((Quaternion rot, Vector3 moments) EELLIIPGCJG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000301")]
	[Cpp2IlInjected.Address(RVA = "0x663F110", Offset = "0x663E510", VA = "0x18663F110", Slot = "16")]
	public void MDMELEJAEMJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000302")]
	[Cpp2IlInjected.Address(RVA = "0x663EB70", Offset = "0x663DF70", VA = "0x18663EB70", Slot = "15")]
	public void KNGNMHHLNOJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000303")]
	[Cpp2IlInjected.Address(RVA = "0x663C340", Offset = "0x663B740", VA = "0x18663C340", Slot = "18")]
	public void AEMAJDMNPCO(Rigidbody ADEHOEHEFLF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000304")]
	[Cpp2IlInjected.Address(RVA = "0x663F340", Offset = "0x663E740", VA = "0x18663F340", Slot = "19")]
	public void OLACCOJPAIO(Rigidbody ADEHOEHEFLF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000305")]
	[Cpp2IlInjected.Address(RVA = "0x663EB10", Offset = "0x663DF10", VA = "0x18663EB10", Slot = "17")]
	public void KJCFNJNJCNO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000306")]
	[Cpp2IlInjected.Address(RVA = "0x663DC80", Offset = "0x663D080", VA = "0x18663DC80", Slot = "20")]
	public void FFOPCPPNJNP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000307")]
	[Cpp2IlInjected.Address(RVA = "0x663F300", Offset = "0x663E700", VA = "0x18663F300")]
	public void OJJLHFENOOB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000309")]
	[Cpp2IlInjected.Address(RVA = "0x663E790", Offset = "0x663DB90", VA = "0x18663E790")]
	private void JFJMBHLBLPD(Vector3 ANJCCKHBJJO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600030A")]
	[Cpp2IlInjected.Address(RVA = "0x663D790", Offset = "0x663CB90", VA = "0x18663D790")]
	[Obsolete("Changes based on context.  the unity rigidbody center of mass has a different scale as well")]
	private Vector3 EBBGJLJOOEP()
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x600030B")]
	[Cpp2IlInjected.Address(RVA = "0x663C410", Offset = "0x663B810", VA = "0x18663C410")]
	private void ALCPMLGJMCJ(float ANJCCKHBJJO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600030C")]
	[Cpp2IlInjected.Address(RVA = "0x663D970", Offset = "0x663CD70", VA = "0x18663D970")]
	private Vector3 EBOGGBBFPDF()
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x600030D")]
	[Cpp2IlInjected.Address(RVA = "0x663E330", Offset = "0x663D730", VA = "0x18663E330")]
	private Quaternion FOPADKPKLKC()
	{
		return default(Quaternion);
	}

	[Cpp2IlInjected.Token(Token = "0x600030E")]
	[Cpp2IlInjected.Address(RVA = "0x663C530", Offset = "0x663B930", VA = "0x18663C530")]
	internal (float, Vector3) DNCJOPAIPEH(Rigidbody NFNENKNHHDF)
	{
		return default((float, Vector3));
	}
}
[Cpp2IlInjected.Token(Token = "0x2000033")]
internal static class NGDNLFJIPNO
{
	[Cpp2IlInjected.Token(Token = "0x600030F")]
	[Cpp2IlInjected.Address(RVA = "0x664E9D0", Offset = "0x664DDD0", VA = "0x18664E9D0")]
	public static CPJGCCJFFIG OAPIGKAMCBA(this JCOFHJBGHJA FBIBFNALIEI)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000034")]
internal sealed class DBAINOOAIEM : DELIINBMKOF, BECBDCABJBI
{
	[Cpp2IlInjected.Token(Token = "0x170000D3")]
	public bool DKKKFBPHJMJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000310")]
		[Cpp2IlInjected.Address(RVA = "0x6640030", Offset = "0x663F430", VA = "0x186640030", Slot = "10")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000D4")]
	public PKGDKKKFHAD DDHMLFAGHDB
	{
		[Cpp2IlInjected.Token(Token = "0x6000311")]
		[Cpp2IlInjected.Address(RVA = "0x6640090", Offset = "0x663F490", VA = "0x186640090", Slot = "11")]
		get
		{
			return default(PKGDKKKFHAD);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000D5")]
	private PKGDKKKFHAD MNIMJNCCKFK
	{
		[Cpp2IlInjected.Token(Token = "0x6000313")]
		[Cpp2IlInjected.Address(RVA = "0x6640090", Offset = "0x663F490", VA = "0x186640090")]
		get
		{
			return default(PKGDKKKFHAD);
		}
		[Cpp2IlInjected.Token(Token = "0x6000314")]
		[Cpp2IlInjected.Address(RVA = "0x6640170", Offset = "0x663F570", VA = "0x186640170")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000312")]
	[Cpp2IlInjected.Address(RVA = "0x6640660", Offset = "0x663FA60", VA = "0x186640660")]
	public DBAINOOAIEM(JCOFHJBGHJA ICFAMCDBCJP, [In] OEDKMOJJJDN ALPLHOOHPEL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000315")]
	[Cpp2IlInjected.Address(RVA = "0x663FDD0", Offset = "0x663F1D0", VA = "0x18663FDD0", Slot = "4")]
	public void AHALPFGPHOF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000316")]
	[Cpp2IlInjected.Address(RVA = "0x6640580", Offset = "0x663F980", VA = "0x186640580")]
	private bool PAFHLHENBKE()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000317")]
	[Cpp2IlInjected.Address(RVA = "0x6640480", Offset = "0x663F880", VA = "0x186640480", Slot = "5")]
	public void INJILPOGJHK(object BDHKJODLPCL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000318")]
	[Cpp2IlInjected.Address(RVA = "0x6640500", Offset = "0x663F900", VA = "0x186640500", Slot = "6")]
	public void MHGGBOGIOEK(object BDHKJODLPCL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000319")]
	[Cpp2IlInjected.Address(RVA = "0x663FED0", Offset = "0x663F2D0", VA = "0x18663FED0", Slot = "9")]
	public void CMJJMIMJMJA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600031A")]
	[Cpp2IlInjected.Address(RVA = "0x66401E0", Offset = "0x663F5E0", VA = "0x1866401E0")]
	private void GPPFBOKFNAN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600031B")]
	[Cpp2IlInjected.Address(RVA = "0x66402E0", Offset = "0x663F6E0", VA = "0x1866402E0")]
	private void HFHDDLKKIEH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600031C")]
	[Cpp2IlInjected.Address(RVA = "0x66400F0", Offset = "0x663F4F0", VA = "0x1866400F0", Slot = "8")]
	public void FNFPCLJNIPI(JCOFHJBGHJA ICFAMCDBCJP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600031D")]
	[Cpp2IlInjected.Address(RVA = "0x663FD50", Offset = "0x663F150", VA = "0x18663FD50", Slot = "7")]
	public void ADFLBOFFGPH(JCOFHJBGHJA ICFAMCDBCJP)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000035")]
internal sealed class PMIBFDLDBLO : DELIINBMKOF, FPLEKLLPLHN
{
	[Cpp2IlInjected.Token(Token = "0x170000D6")]
	public bool LBJIFIJGLFG
	{
		[Cpp2IlInjected.Token(Token = "0x6000320")]
		[Cpp2IlInjected.Address(RVA = "0x6653750", Offset = "0x6652B50", VA = "0x186653750", Slot = "7")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000D7")]
	private bool LGDFMNPFIJC
	{
		[Cpp2IlInjected.Token(Token = "0x6000321")]
		[Cpp2IlInjected.Address(RVA = "0x66537B0", Offset = "0x6652BB0", VA = "0x1866537B0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000035")]
	public event FLEHDNMKJOM DMOBFCJFCHG
	{
		[Cpp2IlInjected.Token(Token = "0x600031E")]
		[Cpp2IlInjected.Address(RVA = "0x6653420", Offset = "0x6652820", VA = "0x186653420", Slot = "4")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600031F")]
		[Cpp2IlInjected.Address(RVA = "0x66535B0", Offset = "0x66529B0", VA = "0x1866535B0", Slot = "5")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000322")]
	[Cpp2IlInjected.Address(RVA = "0x663C2A0", Offset = "0x663B6A0", VA = "0x18663C2A0")]
	public PMIBFDLDBLO(JCOFHJBGHJA ICFAMCDBCJP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000323")]
	[Cpp2IlInjected.Address(RVA = "0x6653820", Offset = "0x6652C20", VA = "0x186653820", Slot = "11")]
	public IDisposable OHLNCDKJKKB()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000324")]
	[Cpp2IlInjected.Address(RVA = "0x6653810", Offset = "0x6652C10", VA = "0x186653810", Slot = "8")]
	public void OCIECADEFBE(object BDHKJODLPCL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000325")]
	[Cpp2IlInjected.Address(RVA = "0x66535A0", Offset = "0x66529A0", VA = "0x1866535A0", Slot = "9")]
	public void BDHFACKMPAM(object BDHKJODLPCL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000326")]
	[Cpp2IlInjected.Address(RVA = "0x6653650", Offset = "0x6652A50", VA = "0x186653650", Slot = "10")]
	public void JMJCHOCCJDP(object BDHKJODLPCL, bool JEKJDJALDPH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000327")]
	[Cpp2IlInjected.Address(RVA = "0x66534C0", Offset = "0x66528C0", VA = "0x1866534C0", Slot = "12")]
	public void AEMAJDMNPCO(Rigidbody APJBIKHBABA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000328")]
	[Cpp2IlInjected.Address(RVA = "0x6653890", Offset = "0x6652C90", VA = "0x186653890", Slot = "13")]
	public void OLACCOJPAIO(Rigidbody ADEHOEHEFLF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000329")]
	[Cpp2IlInjected.Address(RVA = "0x663F300", Offset = "0x663E700", VA = "0x18663F300", Slot = "6")]
	public void LPJBNOGJIJA()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000036")]
internal sealed class EPJHHKGIPKD : DELIINBMKOF, NMOCGBHDPAJ, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000051")]
	private PhotonView DPHNICNACME;

	[Cpp2IlInjected.Token(Token = "0x170000D8")]
	public bool FFPFCCCKGMP
	{
		[Cpp2IlInjected.Token(Token = "0x600032C")]
		[Cpp2IlInjected.Address(RVA = "0x66443E0", Offset = "0x66437E0", VA = "0x1866443E0", Slot = "6")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000D9")]
	public bool PDPGPNLHDKB
	{
		[Cpp2IlInjected.Token(Token = "0x600032D")]
		[Cpp2IlInjected.Address(RVA = "0x6644350", Offset = "0x6643750", VA = "0x186644350", Slot = "7")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000036")]
	public event FLEHDNMKJOM HLHMNNKNCHD
	{
		[Cpp2IlInjected.Token(Token = "0x600032A")]
		[Cpp2IlInjected.Address(RVA = "0x6643B10", Offset = "0x6642F10", VA = "0x186643B10", Slot = "4")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600032B")]
		[Cpp2IlInjected.Address(RVA = "0x6643DB0", Offset = "0x66431B0", VA = "0x186643DB0", Slot = "5")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600032E")]
	[Cpp2IlInjected.Address(RVA = "0x6644750", Offset = "0x6643B50", VA = "0x186644750")]
	public EPJHHKGIPKD(JCOFHJBGHJA ICFAMCDBCJP, [In] OEDKMOJJJDN ALPLHOOHPEL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600032F")]
	[Cpp2IlInjected.Address(RVA = "0x66439E0", Offset = "0x6642DE0", VA = "0x1866439E0", Slot = "8")]
	public void AHALPFGPHOF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000330")]
	[Cpp2IlInjected.Address(RVA = "0x6643E50", Offset = "0x6643250", VA = "0x186643E50", Slot = "11")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000331")]
	[Cpp2IlInjected.Address(RVA = "0x6643BB0", Offset = "0x6642FB0", VA = "0x186643BB0", Slot = "9")]
	public void BKKACFBKLDE(JCOFHJBGHJA EMDODFFCGEF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000332")]
	[Cpp2IlInjected.Address(RVA = "0x6644550", Offset = "0x6643950", VA = "0x186644550", Slot = "10")]
	public void PGLFNOHKLFE(JCOFHJBGHJA EMDODFFCGEF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000333")]
	[Cpp2IlInjected.Address(RVA = "0x6643FB0", Offset = "0x66433B0", VA = "0x186643FB0")]
	private void GGNGJBOHGCF(PhotonView APDMADLFGNA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000334")]
	[Cpp2IlInjected.Address(RVA = "0x6644400", Offset = "0x6643800", VA = "0x186644400")]
	private void MGBHOBLAAOG(RigidbodyEx COACDEBPLBI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000335")]
	[Cpp2IlInjected.Address(RVA = "0x6644190", Offset = "0x6643590", VA = "0x186644190")]
	private void HNPDGFKDNBI(PhotonView HAKBMGLMELD)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000037")]
internal static class ENJIBLLFFJF
{
	[Cpp2IlInjected.Token(Token = "0x6000336")]
	[Cpp2IlInjected.Address(RVA = "0x6643980", Offset = "0x6642D80", VA = "0x186643980")]
	public static EPJHHKGIPKD OIIOCALBIKH(this AABMNPMKJNK FBIBFNALIEI)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000038")]
internal sealed class GHEJLKEDKCC : DELIINBMKOF, KMAFPEDBELG
{
	[Cpp2IlInjected.Token(Token = "0x170000DA")]
	public bool KGIFFCDEOAE
	{
		[Cpp2IlInjected.Token(Token = "0x6000337")]
		[Cpp2IlInjected.Address(RVA = "0x6647310", Offset = "0x6646710", VA = "0x186647310", Slot = "4")]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000338")]
		[Cpp2IlInjected.Address(RVA = "0x6647370", Offset = "0x6646770", VA = "0x186647370", Slot = "5")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000DB")]
	public bool AHEOPCHGDPG
	{
		[Cpp2IlInjected.Token(Token = "0x6000339")]
		[Cpp2IlInjected.Address(RVA = "0x66472B0", Offset = "0x66466B0", VA = "0x1866472B0", Slot = "6")]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x600033A")]
		[Cpp2IlInjected.Address(RVA = "0x6647240", Offset = "0x6646640", VA = "0x186647240")]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000DC")]
	public RigidbodyConstraints LFMJJPGKPGH
	{
		[Cpp2IlInjected.Token(Token = "0x600033B")]
		[Cpp2IlInjected.Address(RVA = "0x66473E0", Offset = "0x66467E0", VA = "0x1866473E0", Slot = "7")]
		get
		{
			return default(RigidbodyConstraints);
		}
		[Cpp2IlInjected.Token(Token = "0x600033C")]
		[Cpp2IlInjected.Address(RVA = "0x66470C0", Offset = "0x66464C0", VA = "0x1866470C0", Slot = "8")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600033D")]
	[Cpp2IlInjected.Address(RVA = "0x66474C0", Offset = "0x66468C0", VA = "0x1866474C0")]
	public GHEJLKEDKCC(JCOFHJBGHJA ICFAMCDBCJP, [In] OEDKMOJJJDN ALPLHOOHPEL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600033E")]
	[Cpp2IlInjected.Address(RVA = "0x6647030", Offset = "0x6646430", VA = "0x186647030", Slot = "9")]
	public void AEMAJDMNPCO(Rigidbody ADEHOEHEFLF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600033F")]
	[Cpp2IlInjected.Address(RVA = "0x6647440", Offset = "0x6646840", VA = "0x186647440", Slot = "10")]
	public void OLACCOJPAIO(Rigidbody ADEHOEHEFLF)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000039")]
internal sealed class IDJHOLLDPCC : DELIINBMKOF, LHIPGJNPCPA
{
	[Cpp2IlInjected.Token(Token = "0x170000DD")]
	public float PDJELALCJNL
	{
		[Cpp2IlInjected.Token(Token = "0x6000341")]
		[Cpp2IlInjected.Address(RVA = "0x6649090", Offset = "0x6648490", VA = "0x186649090", Slot = "4")]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x6000342")]
		[Cpp2IlInjected.Address(RVA = "0x66490F0", Offset = "0x66484F0", VA = "0x1866490F0", Slot = "5")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000DE")]
	public float LHECHOENGNG
	{
		[Cpp2IlInjected.Token(Token = "0x6000343")]
		[Cpp2IlInjected.Address(RVA = "0x6649240", Offset = "0x6648640", VA = "0x186649240", Slot = "6")]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x6000344")]
		[Cpp2IlInjected.Address(RVA = "0x66492A0", Offset = "0x66486A0", VA = "0x1866492A0", Slot = "7")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000340")]
	[Cpp2IlInjected.Address(RVA = "0x663C2A0", Offset = "0x663B6A0", VA = "0x18663C2A0")]
	public IDJHOLLDPCC(JCOFHJBGHJA ICFAMCDBCJP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000345")]
	[Cpp2IlInjected.Address(RVA = "0x6648FA0", Offset = "0x66483A0", VA = "0x186648FA0", Slot = "8")]
	public void AEMAJDMNPCO(Rigidbody ADEHOEHEFLF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000346")]
	[Cpp2IlInjected.Address(RVA = "0x66493F0", Offset = "0x66487F0", VA = "0x1866493F0", Slot = "9")]
	public void OLACCOJPAIO(Rigidbody ADEHOEHEFLF)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200003A")]
[LHLDKFCBMDL(typeof(MCBMILBCKIF), new string[] { })]
public sealed class KCOMGHOJAJJ : MPDHAHPLHCI, MCBMILBCKIF, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000052")]
	[KLEIFKIOFEF]
	private MNHOJKKMHCG ICFAMCDBCJP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000053")]
	private bool KAJILOPLFHP;

	[Cpp2IlInjected.Token(Token = "0x170000DF")]
	public bool FMCKFONPAAG
	{
		[Cpp2IlInjected.Token(Token = "0x6000349")]
		[Cpp2IlInjected.Address(RVA = "0x817E40", Offset = "0x817240", VA = "0x180817E40", Slot = "5")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000347")]
	[Cpp2IlInjected.Address(RVA = "0x664BB90", Offset = "0x664AF90", VA = "0x18664BB90", Slot = "4")]
	public void InitReferences(DOHCFJAHLBK DKKCBCANDII)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000348")]
	[Cpp2IlInjected.Address(RVA = "0x664BB60", Offset = "0x664AF60", VA = "0x18664BB60", Slot = "10")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600034A")]
	[Cpp2IlInjected.Address(RVA = "0x664BA40", Offset = "0x664AE40", VA = "0x18664BA40", Slot = "6")]
	public void DNCJOPAIPEH(FNONGLLGKNI KKLABGAMOPP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600034B")]
	[Cpp2IlInjected.Address(RVA = "0x664BD20", Offset = "0x664B120", VA = "0x18664BD20", Slot = "7")]
	public void NGGLADBIMLL(FNONGLLGKNI KKLABGAMOPP, bool AMKFLCNFGFN, bool MKOPIDPHAFP, bool JDEPFPLLMON)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600034C")]
	[Cpp2IlInjected.Address(RVA = "0x664BBE0", Offset = "0x664AFE0", VA = "0x18664BBE0", Slot = "8")]
	public void KHOLBDAIFFF(FNONGLLGKNI KKLABGAMOPP, float3 BNBPPNLIKAM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600034D")]
	[Cpp2IlInjected.Address(RVA = "0x664BF40", Offset = "0x664B340", VA = "0x18664BF40", Slot = "9")]
	public void PPPNDANFPFC(FNONGLLGKNI KKLABGAMOPP, float3 BFLGOPEGDDM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600034E")]
	[Cpp2IlInjected.Address(RVA = "0x664B7A0", Offset = "0x664ABA0", VA = "0x18664B7A0")]
	private bool BHGMMEPHLJE(FNONGLLGKNI KKLABGAMOPP, [Out] POGPNNCOCBE FBIBFNALIEI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600034F")]
	[Cpp2IlInjected.Address(RVA = "0x664B950", Offset = "0x664AD50", VA = "0x18664B950")]
	private bool DNAJBKCBNHB(FNONGLLGKNI KKLABGAMOPP, [Out] CPJGCCJFFIG BDNDGODIJIH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000350")]
	[Cpp2IlInjected.Address(RVA = "0x664B860", Offset = "0x664AC60", VA = "0x18664B860")]
	private bool DFLLKGMJLBO(FNONGLLGKNI KKLABGAMOPP, [Out] CNCMKNHJEPI BKLMGGMIGCF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000351")]
	[Cpp2IlInjected.Address(RVA = "0x7A2570", Offset = "0x7A1970", VA = "0x1807A2570")]
	public KCOMGHOJAJJ()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200003B")]
internal sealed class HNPMMOAPAIB : DELIINBMKOF, OCGFIHDLMDE
{
	[Cpp2IlInjected.Token(Token = "0x170000E0")]
	private Rigidbody OHEHDKEKPMJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000354")]
		[Cpp2IlInjected.Address(RVA = "0x663E570", Offset = "0x663D970", VA = "0x18663E570")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000E1")]
	private bool FKKBJAAELGK
	{
		[Cpp2IlInjected.Token(Token = "0x6000355")]
		[Cpp2IlInjected.Address(RVA = "0x663AAE0", Offset = "0x6639EE0", VA = "0x18663AAE0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000E2")]
	private JCOFHJBGHJA EOGAOJCDEEE
	{
		[Cpp2IlInjected.Token(Token = "0x6000356")]
		[Cpp2IlInjected.Address(RVA = "0x6648530", Offset = "0x6647930", VA = "0x186648530")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000E3")]
	private bool PJOOMDNDEDM
	{
		[Cpp2IlInjected.Token(Token = "0x6000357")]
		[Cpp2IlInjected.Address(RVA = "0x66486B0", Offset = "0x6647AB0", VA = "0x1866486B0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000E4")]
	private bool EKMBEFCOBGI
	{
		[Cpp2IlInjected.Token(Token = "0x6000358")]
		[Cpp2IlInjected.Address(RVA = "0x6648AF0", Offset = "0x6647EF0", VA = "0x186648AF0")]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000359")]
		[Cpp2IlInjected.Address(RVA = "0x66488E0", Offset = "0x6647CE0", VA = "0x1866488E0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000E5")]
	private bool HBAILJHDPNN
	{
		[Cpp2IlInjected.Token(Token = "0x600035A")]
		[Cpp2IlInjected.Address(RVA = "0x6648B50", Offset = "0x6647F50", VA = "0x186648B50")]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x600035B")]
		[Cpp2IlInjected.Address(RVA = "0x6648D60", Offset = "0x6648160", VA = "0x186648D60")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000E6")]
	private int AKMCCIGPBLB
	{
		[Cpp2IlInjected.Token(Token = "0x600035C")]
		[Cpp2IlInjected.Address(RVA = "0x6648640", Offset = "0x6647A40", VA = "0x186648640")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000037")]
	public event FLEHDNMKJOM JOPHGGEPEGF
	{
		[Cpp2IlInjected.Token(Token = "0x6000352")]
		[Cpp2IlInjected.Address(RVA = "0x6648490", Offset = "0x6647890", VA = "0x186648490", Slot = "4")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000353")]
		[Cpp2IlInjected.Address(RVA = "0x6648DD0", Offset = "0x66481D0", VA = "0x186648DD0", Slot = "5")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600035D")]
	[Cpp2IlInjected.Address(RVA = "0x6648E70", Offset = "0x6648270", VA = "0x186648E70")]
	public HNPMMOAPAIB(JCOFHJBGHJA ICFAMCDBCJP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600035E")]
	[Cpp2IlInjected.Address(RVA = "0x6648590", Offset = "0x6647990", VA = "0x186648590", Slot = "6")]
	public void AHALPFGPHOF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600035F")]
	[Cpp2IlInjected.Address(RVA = "0x6648BB0", Offset = "0x6647FB0", VA = "0x186648BB0", Slot = "8")]
	public void KOECFGPAONM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000360")]
	[Cpp2IlInjected.Address(RVA = "0x6648950", Offset = "0x6647D50", VA = "0x186648950", Slot = "7")]
	public bool HIMNDBELLFC()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000361")]
	[Cpp2IlInjected.Address(RVA = "0x6648710", Offset = "0x6647B10", VA = "0x186648710", Slot = "9")]
	public void FHCIIFMIADL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000362")]
	[Cpp2IlInjected.Address(RVA = "0x663F300", Offset = "0x663E700", VA = "0x18663F300", Slot = "12")]
	public void HFBIOGKFJLO(bool CPAENGEGPEJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000363")]
	[Cpp2IlInjected.Address(RVA = "0x6648C20", Offset = "0x6648020", VA = "0x186648C20", Slot = "11")]
	public void LGECILGBLOD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000364")]
	[Cpp2IlInjected.Address(RVA = "0x7A0900", Offset = "0x79FD00", VA = "0x1807A0900", Slot = "10")]
	public void FHOPNJINOBL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000365")]
	[Cpp2IlInjected.Address(RVA = "0x6648800", Offset = "0x6647C00", VA = "0x186648800")]
	private void GKILCEEOGED()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200003C")]
internal sealed class KMHLNIFIHCH : DELIINBMKOF, BOKFNFEEHEN
{
	[Cpp2IlInjected.Token(Token = "0x170000E7")]
	public Rigidbody OHEHDKEKPMJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000366")]
		[Cpp2IlInjected.Address(RVA = "0x664CD80", Offset = "0x664C180", VA = "0x18664CD80", Slot = "4")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000367")]
		[Cpp2IlInjected.Address(RVA = "0x664CAC0", Offset = "0x664BEC0", VA = "0x18664CAC0")]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000E8")]
	private bool PJOOMDNDEDM
	{
		[Cpp2IlInjected.Token(Token = "0x6000368")]
		[Cpp2IlInjected.Address(RVA = "0x6649680", Offset = "0x6648A80", VA = "0x186649680")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000E9")]
	public bool CKHKFDAEDBM
	{
		[Cpp2IlInjected.Token(Token = "0x600036B")]
		[Cpp2IlInjected.Address(RVA = "0x664CEE0", Offset = "0x664C2E0", VA = "0x18664CEE0", Slot = "6")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000369")]
	[Cpp2IlInjected.Address(RVA = "0x664D220", Offset = "0x664C620", VA = "0x18664D220")]
	public KMHLNIFIHCH(JCOFHJBGHJA ICFAMCDBCJP, [In] OEDKMOJJJDN ALPLHOOHPEL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600036A")]
	[Cpp2IlInjected.Address(RVA = "0x664C7F0", Offset = "0x664BBF0", VA = "0x18664C7F0", Slot = "5")]
	public void AHALPFGPHOF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600036C")]
	[Cpp2IlInjected.Address(RVA = "0x664CE60", Offset = "0x664C260", VA = "0x18664CE60", Slot = "7")]
	public void IFAGMNAOPKH(object BDHKJODLPCL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600036D")]
	[Cpp2IlInjected.Address(RVA = "0x664D1A0", Offset = "0x664C5A0", VA = "0x18664D1A0", Slot = "8")]
	public void ONPKKIOKJND(object BDHKJODLPCL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600036E")]
	[Cpp2IlInjected.Address(RVA = "0x664C8A0", Offset = "0x664BCA0", VA = "0x18664C8A0", Slot = "9")]
	public void APMEFFJEKGL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600036F")]
	[Cpp2IlInjected.Address(RVA = "0x664CF40", Offset = "0x664C340", VA = "0x18664CF40", Slot = "11")]
	public void NDJBJJBJHGC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000370")]
	[Cpp2IlInjected.Address(RVA = "0x664CBB0", Offset = "0x664BFB0", VA = "0x18664CBB0", Slot = "12")]
	public void DBLPGDCIAIB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000371")]
	[Cpp2IlInjected.Address(RVA = "0x7A0900", Offset = "0x79FD00", VA = "0x1807A0900", Slot = "10")]
	public void KCCBENMOEDJ()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200003D")]
internal sealed class CNCMKNHJEPI : DELIINBMKOF, LNECPEEFLAO, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x170000EA")]
	public EBGPLIADLBP NPCFNCCEAJO
	{
		[Cpp2IlInjected.Token(Token = "0x6000372")]
		[Cpp2IlInjected.Address(RVA = "0x663B060", Offset = "0x663A460", VA = "0x18663B060", Slot = "4")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000373")]
		[Cpp2IlInjected.Address(RVA = "0x663A7C0", Offset = "0x6639BC0", VA = "0x18663A7C0", Slot = "5")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000EB")]
	public OEEPKCKPLEL LAOMDEGHJLM
	{
		[Cpp2IlInjected.Token(Token = "0x6000374")]
		[Cpp2IlInjected.Address(RVA = "0x66389D0", Offset = "0x6637DD0", VA = "0x1866389D0", Slot = "6")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000375")]
		[Cpp2IlInjected.Address(RVA = "0x6638960", Offset = "0x6637D60", VA = "0x186638960", Slot = "7")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000EC")]
	public Vector3 BPGONCPMPON
	{
		[Cpp2IlInjected.Token(Token = "0x6000376")]
		[Cpp2IlInjected.Address(RVA = "0x6638D00", Offset = "0x6638100", VA = "0x186638D00", Slot = "8")]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x6000377")]
		[Cpp2IlInjected.Address(RVA = "0x663BD40", Offset = "0x663B140", VA = "0x18663BD40", Slot = "9")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000ED")]
	public Vector3 CDFFMHAADHJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000378")]
		[Cpp2IlInjected.Address(RVA = "0x663B110", Offset = "0x663A510", VA = "0x18663B110", Slot = "10")]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x6000379")]
		[Cpp2IlInjected.Address(RVA = "0x663C210", Offset = "0x663B610", VA = "0x18663C210", Slot = "11")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000EE")]
	public Vector3 PPHKEOLJADG
	{
		[Cpp2IlInjected.Token(Token = "0x600037A")]
		[Cpp2IlInjected.Address(RVA = "0x663C100", Offset = "0x663B500", VA = "0x18663C100", Slot = "12")]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x600037B")]
		[Cpp2IlInjected.Address(RVA = "0x66391C0", Offset = "0x66385C0", VA = "0x1866391C0", Slot = "13")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000EF")]
	public Vector3 ELLKJABMPJB
	{
		[Cpp2IlInjected.Token(Token = "0x600037C")]
		[Cpp2IlInjected.Address(RVA = "0x6638710", Offset = "0x6637B10", VA = "0x186638710", Slot = "14")]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x600037D")]
		[Cpp2IlInjected.Address(RVA = "0x6639910", Offset = "0x6638D10", VA = "0x186639910", Slot = "15")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000F0")]
	public float ILJFFAPOBNP
	{
		[Cpp2IlInjected.Token(Token = "0x600037E")]
		[Cpp2IlInjected.Address(RVA = "0x6638D60", Offset = "0x6638160", VA = "0x186638D60", Slot = "16")]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x600037F")]
		[Cpp2IlInjected.Address(RVA = "0x663A670", Offset = "0x6639A70", VA = "0x18663A670", Slot = "17")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000F1")]
	public bool OPLHKLPKLIH
	{
		[Cpp2IlInjected.Token(Token = "0x6000381")]
		[Cpp2IlInjected.Address(RVA = "0x663BA50", Offset = "0x663AE50", VA = "0x18663BA50", Slot = "18")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000F2")]
	private PNBKJNMIIDD GEAICDGBGCN
	{
		[Cpp2IlInjected.Token(Token = "0x6000394")]
		[Cpp2IlInjected.Address(RVA = "0x1EB20F0", Offset = "0x1EB14F0", VA = "0x181EB20F0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000F3")]
	private bool FKKBJAAELGK
	{
		[Cpp2IlInjected.Token(Token = "0x6000395")]
		[Cpp2IlInjected.Address(RVA = "0x663AAE0", Offset = "0x6639EE0", VA = "0x18663AAE0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000380")]
	[Cpp2IlInjected.Address(RVA = "0x663C2A0", Offset = "0x663B6A0", VA = "0x18663C2A0")]
	public CNCMKNHJEPI(JCOFHJBGHJA ICFAMCDBCJP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000382")]
	[Cpp2IlInjected.Address(RVA = "0x663AFF0", Offset = "0x663A3F0", VA = "0x18663AFF0", Slot = "20")]
	public void JCILIICGCJL(object BDHKJODLPCL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000383")]
	[Cpp2IlInjected.Address(RVA = "0x663C090", Offset = "0x663B490", VA = "0x18663C090", Slot = "30")]
	public void MPOMOMABFCM(object BDHKJODLPCL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000384")]
	[Cpp2IlInjected.Address(RVA = "0x66388B0", Offset = "0x6637CB0", VA = "0x1866388B0", Slot = "19")]
	public void AHALPFGPHOF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000385")]
	[Cpp2IlInjected.Address(RVA = "0x6639850", Offset = "0x6638C50", VA = "0x186639850", Slot = "36")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000386")]
	[Cpp2IlInjected.Address(RVA = "0x6638740", Offset = "0x6637B40", VA = "0x186638740", Slot = "28")]
	public void AEMAJDMNPCO(Rigidbody ADEHOEHEFLF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000387")]
	[Cpp2IlInjected.Address(RVA = "0x6639F10", Offset = "0x6639310", VA = "0x186639F10", Slot = "35")]
	public Vector3 FAMKNNGPJGI(Vector3 ANEKCENIKFN)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000388")]
	[Cpp2IlInjected.Address(RVA = "0x6638DC0", Offset = "0x66381C0", VA = "0x186638DC0", Slot = "34")]
	public Vector3 CIMNPDLMMNF(Vector3 BNBPPNLIKAM)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000389")]
	[Cpp2IlInjected.Address(RVA = "0x66388B0", Offset = "0x6637CB0", VA = "0x1866388B0", Slot = "27")]
	public void MEMDFIBKEPP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600038A")]
	[Cpp2IlInjected.Address(RVA = "0x6639280", Offset = "0x6638680", VA = "0x186639280", Slot = "25")]
	public void DJHDKBHIGDN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600038B")]
	[Cpp2IlInjected.Address(RVA = "0x663C240", Offset = "0x663B640", VA = "0x18663C240", Slot = "24")]
	public void PNFNNMMCLFE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600038C")]
	[Cpp2IlInjected.Address(RVA = "0x6638F80", Offset = "0x6638380", VA = "0x186638F80", Slot = "33")]
	public void DENAIEDOENP(Vector3 FHLIJFCHIPI, Vector3 NEMLBHKHIJF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600038D")]
	[Cpp2IlInjected.Address(RVA = "0x6639940", Offset = "0x6638D40", VA = "0x186639940", Slot = "32")]
	public void ENOBLMIPEAC(Vector3 KAAALJHMPDH, Vector3 BFLGOPEGDDM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600038E")]
	[Cpp2IlInjected.Address(RVA = "0x663BEC0", Offset = "0x663B2C0", VA = "0x18663BEC0", Slot = "31")]
	public void MPFFKLHFEMH(Vector3 HBEOKBDKAPI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600038F")]
	[Cpp2IlInjected.Address(RVA = "0x66392E0", Offset = "0x66386E0", VA = "0x1866392E0", Slot = "22")]
	public void DLGALJLLKBC(IOIMFMPPEPK JJCOMEIHIFG, Vector3 LOPBIAGCJBL, float DJHFDGIPKCO, float GJGOKKJEDGM = 8f, float KHKMMDAMJPL = 1f)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000390")]
	[Cpp2IlInjected.Address(RVA = "0x663A830", Offset = "0x6639C30", VA = "0x18663A830", Slot = "21")]
	public void FIGBACLJNDD(HGAFDACKLPM ALPAKFKNNFG, Vector3 JMPMBOKBENO, float MGEJKMAAPFM = float.PositiveInfinity)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000391")]
	[Cpp2IlInjected.Address(RVA = "0x663ABE0", Offset = "0x6639FE0", VA = "0x18663ABE0", Slot = "23")]
	[Obsolete("Deprecated. Still exists to support deprecated CV2 chips. Use ApplyAngularVelocityChange.")]
	public void IFNPBEKLMHH(HGAFDACKLPM ALPAKFKNNFG, Vector3 IKFFGJBHBIC, float KIDOONEEGII = 7f, float HDJMHGGGNBA = 1f)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000392")]
	[Cpp2IlInjected.Address(RVA = "0x663AB00", Offset = "0x6639F00", VA = "0x18663AB00", Slot = "29")]
	public Vector3 IEPIAOMDAAG(Vector3 KDGFADJDBBB)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000393")]
	[Cpp2IlInjected.Address(RVA = "0x663B8C0", Offset = "0x663ACC0", VA = "0x18663B8C0", Slot = "26")]
	public void KJCKGCGOJBM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000396")]
	[Cpp2IlInjected.Address(RVA = "0x663A670", Offset = "0x6639A70", VA = "0x18663A670")]
	private void FFCMOHMCFGD(float ANJCCKHBJJO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000397")]
	[Cpp2IlInjected.Address(RVA = "0x663B6F0", Offset = "0x663AAF0", VA = "0x18663B6F0")]
	private void KFOEODIJCBJ(Vector3 JMPMBOKBENO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000398")]
	[Cpp2IlInjected.Address(RVA = "0x6638A80", Offset = "0x6637E80", VA = "0x186638A80")]
	private Vector3 BKHKELLMDAL()
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000399")]
	[Cpp2IlInjected.Address(RVA = "0x663A0F0", Offset = "0x66394F0", VA = "0x18663A0F0")]
	private void FCDMJMLLJII(Vector3 BNBPPNLIKAM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600039A")]
	[Cpp2IlInjected.Address(RVA = "0x663BAB0", Offset = "0x663AEB0", VA = "0x18663BAB0")]
	private Vector3 KPHJPJGFJHA()
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x600039B")]
	[Cpp2IlInjected.Address(RVA = "0x66399A0", Offset = "0x6638DA0", VA = "0x1866399A0")]
	private void ENONAEOFDCM(Vector3 ANJCCKHBJJO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600039C")]
	[Cpp2IlInjected.Address(RVA = "0x663BE00", Offset = "0x663B200", VA = "0x18663BE00")]
	private void LMCDMCOFMLJ(Vector3 KDGFADJDBBB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600039D")]
	[Cpp2IlInjected.Address(RVA = "0x663BE60", Offset = "0x663B260", VA = "0x18663BE60")]
	private void MIPPHJAMJOE(Vector3 HIEIGGIPFIC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600039E")]
	[Cpp2IlInjected.Address(RVA = "0x663B140", Offset = "0x663A540", VA = "0x18663B140")]
	private void JNPNJHENHGF(string BLEKAAPAOJJ, Vector3 ANJCCKHBJJO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600039F")]
	[Cpp2IlInjected.Address(RVA = "0x663C160", Offset = "0x663B560", VA = "0x18663C160")]
	private void OCJMCFKJGBK()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200003E")]
internal class DELIINBMKOF
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000055")]
	protected readonly POGPNNCOCBE ICFAMCDBCJP;

	[Cpp2IlInjected.Token(Token = "0x170000F4")]
	protected MNHOJKKMHCG DBKDECJJLLG
	{
		[Cpp2IlInjected.Token(Token = "0x60003A0")]
		[Cpp2IlInjected.Address(RVA = "0x571BFE0", Offset = "0x571B3E0", VA = "0x18571BFE0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000F5")]
	protected FNONGLLGKNI KFCEIPDGLIM
	{
		[Cpp2IlInjected.Token(Token = "0x60003A1")]
		[Cpp2IlInjected.Address(RVA = "0x571C020", Offset = "0x571B420", VA = "0x18571C020")]
		get
		{
			return default(FNONGLLGKNI);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60003A2")]
	[Cpp2IlInjected.Address(RVA = "0x663C2A0", Offset = "0x663B6A0", VA = "0x18663C2A0")]
	public DELIINBMKOF(JCOFHJBGHJA ICFAMCDBCJP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003A3")]
	[Cpp2IlInjected.Address(RVA = "0x66432E0", Offset = "0x66426E0", VA = "0x1866432E0")]
	protected JCOFHJBGHJA LLPAAFAAGMK(FNONGLLGKNI CMIPJIFIMCO)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200003F")]
public class BJHOHLGLHFN : IJKJBKAFLOD
{
	[Cpp2IlInjected.Token(Token = "0x60003A4")]
	[Cpp2IlInjected.Address(RVA = "0x6635800", Offset = "0x6634C00", VA = "0x186635800", Slot = "4")]
	public DFEBEBBPEII EBNPOOMGDOG(JCOFHJBGHJA FBIBFNALIEI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003A5")]
	[Cpp2IlInjected.Address(RVA = "0x6635FA0", Offset = "0x66353A0", VA = "0x186635FA0", Slot = "5")]
	public LNECPEEFLAO NPKBHLDACOA(JCOFHJBGHJA FBIBFNALIEI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003A6")]
	[Cpp2IlInjected.Address(RVA = "0x6635DE0", Offset = "0x66351E0", VA = "0x186635DE0", Slot = "6")]
	public JJMHLHBDECD MOBLLBNBCPK(JCOFHJBGHJA FBIBFNALIEI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003A7")]
	[Cpp2IlInjected.Address(RVA = "0x6636330", Offset = "0x6635730", VA = "0x186636330", Slot = "7")]
	public LHIPGJNPCPA OMIEKPOLDKI(JCOFHJBGHJA FBIBFNALIEI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003A8")]
	[Cpp2IlInjected.Address(RVA = "0x6635940", Offset = "0x6634D40", VA = "0x186635940", Slot = "8")]
	public OCGFIHDLMDE FNKDNGDEIEK(JCOFHJBGHJA FBIBFNALIEI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003A9")]
	[Cpp2IlInjected.Address(RVA = "0x6635EC0", Offset = "0x66352C0", VA = "0x186635EC0", Slot = "9")]
	public NHEBLBOICHI MPKPENFLCNG(JCOFHJBGHJA FBIBFNALIEI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003AA")]
	[Cpp2IlInjected.Address(RVA = "0x6635D00", Offset = "0x6635100", VA = "0x186635D00", Slot = "10")]
	public FPLEKLLPLHN IMMJNPIHOJJ(JCOFHJBGHJA FBIBFNALIEI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003AB")]
	[Cpp2IlInjected.Address(RVA = "0x6635BB0", Offset = "0x6634FB0", VA = "0x186635BB0", Slot = "11")]
	public PNBKJNMIIDD IBPBDCABMKN(JCOFHJBGHJA FBIBFNALIEI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003AC")]
	[Cpp2IlInjected.Address(RVA = "0x66354B0", Offset = "0x66348B0", VA = "0x1866354B0", Slot = "12")]
	public NDECPKLCGPL BPKOFLMIBEG(JCOFHJBGHJA FBIBFNALIEI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003AD")]
	[Cpp2IlInjected.Address(RVA = "0x6635860", Offset = "0x6634C60", VA = "0x186635860", Slot = "13")]
	public APDCPHMDBJE EDEKKNKAMCK(JCOFHJBGHJA FBIBFNALIEI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003AE")]
	[Cpp2IlInjected.Address(RVA = "0x6635AB0", Offset = "0x6634EB0", VA = "0x186635AB0")]
	public BOKFNFEEHEN IEEKJCJAPCM(JCOFHJBGHJA FBIBFNALIEI, [In] OEDKMOJJJDN ALPLHOOHPEL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003AF")]
	[Cpp2IlInjected.Address(RVA = "0x6636080", Offset = "0x6635480", VA = "0x186636080")]
	public NMOCGBHDPAJ OAPJLHDNABE(JCOFHJBGHJA FBIBFNALIEI, [In] OEDKMOJJJDN ALPLHOOHPEL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003B0")]
	[Cpp2IlInjected.Address(RVA = "0x6635590", Offset = "0x6634990", VA = "0x186635590")]
	public BECBDCABJBI PJCBMPIGMMK(JCOFHJBGHJA FBIBFNALIEI, [In] OEDKMOJJJDN ALPLHOOHPEL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003B1")]
	[Cpp2IlInjected.Address(RVA = "0x6635C90", Offset = "0x6635090", VA = "0x186635C90")]
	public KPKDIHHLHAL NPPPBIHCIGI(JCOFHJBGHJA FBIBFNALIEI, [In] OEDKMOJJJDN ALPLHOOHPEL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003B2")]
	[Cpp2IlInjected.Address(RVA = "0x6636180", Offset = "0x6635580", VA = "0x186636180")]
	public KMAFPEDBELG OCNEKCODBFB(JCOFHJBGHJA FBIBFNALIEI, [In] OEDKMOJJJDN ALPLHOOHPEL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003B3")]
	[Cpp2IlInjected.Address(RVA = "0x66356D0", Offset = "0x6634AD0", VA = "0x1866356D0", Slot = "19")]
	public JCOFHJBGHJA DJNICONLOON(RigidbodyEx ICFAMCDBCJP, OEDKMOJJJDN ALPLHOOHPEL, FCIHFBGEFGG IALOIPDIIAG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003B4")]
	[Cpp2IlInjected.Address(RVA = "0x7A2570", Offset = "0x7A1970", VA = "0x1807A2570")]
	public BJHOHLGLHFN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003B5")]
	[Cpp2IlInjected.Address(RVA = "0x6635AB0", Offset = "0x6634EB0", VA = "0x186635AB0", Slot = "14")]
	private BOKFNFEEHEN HGPCOBDALIC(JCOFHJBGHJA FBIBFNALIEI, [In] OEDKMOJJJDN ALPLHOOHPEL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003B6")]
	[Cpp2IlInjected.Address(RVA = "0x6636080", Offset = "0x6635480", VA = "0x186636080", Slot = "15")]
	private NMOCGBHDPAJ OIOILHLBFOK(JCOFHJBGHJA FBIBFNALIEI, [In] OEDKMOJJJDN ALPLHOOHPEL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003B7")]
	[Cpp2IlInjected.Address(RVA = "0x6635590", Offset = "0x6634990", VA = "0x186635590", Slot = "16")]
	private BECBDCABJBI CEEFJGCJJGK(JCOFHJBGHJA FBIBFNALIEI, [In] OEDKMOJJJDN ALPLHOOHPEL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003B8")]
	[Cpp2IlInjected.Address(RVA = "0x6635C90", Offset = "0x6635090", VA = "0x186635C90", Slot = "17")]
	private KPKDIHHLHAL ICJFKMGPFAM(JCOFHJBGHJA FBIBFNALIEI, [In] OEDKMOJJJDN ALPLHOOHPEL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003B9")]
	[Cpp2IlInjected.Address(RVA = "0x6636320", Offset = "0x6635720", VA = "0x186636320", Slot = "18")]
	private KMAFPEDBELG ODOPOLJODFD(JCOFHJBGHJA FBIBFNALIEI, [In] OEDKMOJJJDN ALPLHOOHPEL)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000040")]
[DefaultMember("Item")]
public sealed class JAEIBBHLDFF : IReadOnlyList<JCOFHJBGHJA>, IEnumerable<JCOFHJBGHJA>, IEnumerable, IReadOnlyCollection<JCOFHJBGHJA>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000056")]
	public readonly FNONGLLGKNI CMIPJIFIMCO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000057")]
	public readonly MNHOJKKMHCG JDDNEABEJAK;

	[Cpp2IlInjected.Token(Token = "0x170000F6")]
	public int EKCLJKKLOHJ
	{
		[Cpp2IlInjected.Token(Token = "0x60003BD")]
		[Cpp2IlInjected.Address(RVA = "0x664A5F0", Offset = "0x66499F0", VA = "0x18664A5F0", Slot = "5")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000F7")]
	public JCOFHJBGHJA LANLGIDAOPG
	{
		[Cpp2IlInjected.Token(Token = "0x60003BE")]
		[Cpp2IlInjected.Address(RVA = "0x664A390", Offset = "0x6649790", VA = "0x18664A390", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60003BA")]
	[Cpp2IlInjected.Address(RVA = "0x33E4E20", Offset = "0x33E4220", VA = "0x1833E4E20")]
	public JAEIBBHLDFF(FNONGLLGKNI CMIPJIFIMCO, MNHOJKKMHCG JDDNEABEJAK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003BB")]
	[Cpp2IlInjected.Address(RVA = "0x664A4E0", Offset = "0x66498E0", VA = "0x18664A4E0", Slot = "6")]
	public IEnumerator<JCOFHJBGHJA> GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003BC")]
	[Cpp2IlInjected.Address(RVA = "0x664A4E0", Offset = "0x66498E0", VA = "0x18664A4E0", Slot = "7")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003BF")]
	[Cpp2IlInjected.Address(RVA = "0x664A390", Offset = "0x6649790", VA = "0x18664A390")]
	[CompilerGenerated]
	private JCOFHJBGHJA FDBOJLDPIEO(int FPJGJJLGENP)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000041")]
[LHLDKFCBMDL(typeof(IJKJBKAFLOD), new string[] { })]
public class MEIACHKMNME : IJKJBKAFLOD, MPDHAHPLHCI
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000058")]
	private readonly IJKJBKAFLOD KGKHMCHNDIK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000059")]
	private readonly IJKJBKAFLOD OAKCPJJHBIB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400005A")]
	private FKEJGOFEJBL LFIJAELPCCM;

	[Cpp2IlInjected.Token(Token = "0x170000F8")]
	private IJKJBKAFLOD DCFKMHLPLHE
	{
		[Cpp2IlInjected.Token(Token = "0x60003C1")]
		[Cpp2IlInjected.Address(RVA = "0x664DD60", Offset = "0x664D160", VA = "0x18664DD60")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60003C0")]
	[Cpp2IlInjected.Address(RVA = "0x664DFB0", Offset = "0x664D3B0", VA = "0x18664DFB0", Slot = "20")]
	public void InitReferences(DOHCFJAHLBK DKKCBCANDII)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003C2")]
	[Cpp2IlInjected.Address(RVA = "0x664DAD0", Offset = "0x664CED0", VA = "0x18664DAD0", Slot = "4")]
	public DFEBEBBPEII EBNPOOMGDOG(JCOFHJBGHJA FBIBFNALIEI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003C3")]
	[Cpp2IlInjected.Address(RVA = "0x664E140", Offset = "0x664D540", VA = "0x18664E140", Slot = "5")]
	public LNECPEEFLAO NPKBHLDACOA(JCOFHJBGHJA FBIBFNALIEI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003C4")]
	[Cpp2IlInjected.Address(RVA = "0x664E000", Offset = "0x664D400", VA = "0x18664E000", Slot = "6")]
	public JJMHLHBDECD MOBLLBNBCPK(JCOFHJBGHJA FBIBFNALIEI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003C5")]
	[Cpp2IlInjected.Address(RVA = "0x664E340", Offset = "0x664D740", VA = "0x18664E340", Slot = "7")]
	public LHIPGJNPCPA OMIEKPOLDKI(JCOFHJBGHJA FBIBFNALIEI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003C6")]
	[Cpp2IlInjected.Address(RVA = "0x664DC10", Offset = "0x664D010", VA = "0x18664DC10", Slot = "8")]
	public OCGFIHDLMDE FNKDNGDEIEK(JCOFHJBGHJA FBIBFNALIEI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003C7")]
	[Cpp2IlInjected.Address(RVA = "0x664E0A0", Offset = "0x664D4A0", VA = "0x18664E0A0", Slot = "9")]
	public NHEBLBOICHI MPKPENFLCNG(JCOFHJBGHJA FBIBFNALIEI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003C8")]
	[Cpp2IlInjected.Address(RVA = "0x664DF10", Offset = "0x664D310", VA = "0x18664DF10", Slot = "10")]
	public FPLEKLLPLHN IMMJNPIHOJJ(JCOFHJBGHJA FBIBFNALIEI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003C9")]
	[Cpp2IlInjected.Address(RVA = "0x664DDC0", Offset = "0x664D1C0", VA = "0x18664DDC0", Slot = "11")]
	public PNBKJNMIIDD IBPBDCABMKN(JCOFHJBGHJA FBIBFNALIEI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003CA")]
	[Cpp2IlInjected.Address(RVA = "0x664D890", Offset = "0x664CC90", VA = "0x18664D890", Slot = "12")]
	public NDECPKLCGPL BPKOFLMIBEG(JCOFHJBGHJA FBIBFNALIEI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003CB")]
	[Cpp2IlInjected.Address(RVA = "0x664DB70", Offset = "0x664CF70", VA = "0x18664DB70", Slot = "13")]
	public APDCPHMDBJE EDEKKNKAMCK(JCOFHJBGHJA FBIBFNALIEI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003CC")]
	[Cpp2IlInjected.Address(RVA = "0x664DCB0", Offset = "0x664D0B0", VA = "0x18664DCB0")]
	public BOKFNFEEHEN IEEKJCJAPCM(JCOFHJBGHJA FBIBFNALIEI, [In] OEDKMOJJJDN ALPLHOOHPEL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003CD")]
	[Cpp2IlInjected.Address(RVA = "0x664E1E0", Offset = "0x664D5E0", VA = "0x18664E1E0")]
	public NMOCGBHDPAJ OAPJLHDNABE(JCOFHJBGHJA FBIBFNALIEI, [In] OEDKMOJJJDN ALPLHOOHPEL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003CE")]
	[Cpp2IlInjected.Address(RVA = "0x664D930", Offset = "0x664CD30", VA = "0x18664D930")]
	public BECBDCABJBI PJCBMPIGMMK(JCOFHJBGHJA FBIBFNALIEI, [In] OEDKMOJJJDN ALPLHOOHPEL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003CF")]
	[Cpp2IlInjected.Address(RVA = "0x664DE60", Offset = "0x664D260", VA = "0x18664DE60")]
	public KPKDIHHLHAL NPPPBIHCIGI(JCOFHJBGHJA FBIBFNALIEI, [In] OEDKMOJJJDN ALPLHOOHPEL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003D0")]
	[Cpp2IlInjected.Address(RVA = "0x664E290", Offset = "0x664D690", VA = "0x18664E290")]
	public KMAFPEDBELG OCNEKCODBFB(JCOFHJBGHJA FBIBFNALIEI, [In] OEDKMOJJJDN ALPLHOOHPEL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003D1")]
	[Cpp2IlInjected.Address(RVA = "0x664D9E0", Offset = "0x664CDE0", VA = "0x18664D9E0", Slot = "19")]
	public JCOFHJBGHJA DJNICONLOON(RigidbodyEx ICFAMCDBCJP, OEDKMOJJJDN ALPLHOOHPEL, FCIHFBGEFGG IALOIPDIIAG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003D2")]
	[Cpp2IlInjected.Address(RVA = "0x664E3E0", Offset = "0x664D7E0", VA = "0x18664E3E0")]
	public MEIACHKMNME()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003D3")]
	[Cpp2IlInjected.Address(RVA = "0x664DCB0", Offset = "0x664D0B0", VA = "0x18664DCB0", Slot = "14")]
	private BOKFNFEEHEN HGPCOBDALIC(JCOFHJBGHJA FBIBFNALIEI, [In] OEDKMOJJJDN ALPLHOOHPEL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003D4")]
	[Cpp2IlInjected.Address(RVA = "0x664E1E0", Offset = "0x664D5E0", VA = "0x18664E1E0", Slot = "15")]
	private NMOCGBHDPAJ OIOILHLBFOK(JCOFHJBGHJA FBIBFNALIEI, [In] OEDKMOJJJDN ALPLHOOHPEL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003D5")]
	[Cpp2IlInjected.Address(RVA = "0x664D930", Offset = "0x664CD30", VA = "0x18664D930", Slot = "16")]
	private BECBDCABJBI CEEFJGCJJGK(JCOFHJBGHJA FBIBFNALIEI, [In] OEDKMOJJJDN ALPLHOOHPEL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003D6")]
	[Cpp2IlInjected.Address(RVA = "0x664DE60", Offset = "0x664D260", VA = "0x18664DE60", Slot = "17")]
	private KPKDIHHLHAL ICJFKMGPFAM(JCOFHJBGHJA FBIBFNALIEI, [In] OEDKMOJJJDN ALPLHOOHPEL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003D7")]
	[Cpp2IlInjected.Address(RVA = "0x664E290", Offset = "0x664D690", VA = "0x18664E290", Slot = "18")]
	private KMAFPEDBELG ODOPOLJODFD(JCOFHJBGHJA FBIBFNALIEI, [In] OEDKMOJJJDN ALPLHOOHPEL)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000042")]
[UnityEngine.Scripting.Preserve]
public sealed class FGODNGNJEOL : JCOFHJBGHJA, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x400005B")]
	public static readonly FGODNGNJEOL GHDJCOLHINO;

	[Cpp2IlInjected.Token(Token = "0x170000F9")]
	public Rigidbody OHEHDKEKPMJ
	{
		[Cpp2IlInjected.Token(Token = "0x60003EA")]
		[Cpp2IlInjected.Address(RVA = "0x7A26D0", Offset = "0x7A1AD0", VA = "0x1807A26D0", Slot = "4")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000FA")]
	public RigidbodyEx FNPOFPMCEAK
	{
		[Cpp2IlInjected.Token(Token = "0x60003EB")]
		[Cpp2IlInjected.Address(RVA = "0x7A2690", Offset = "0x7A1A90", VA = "0x1807A2690", Slot = "5")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000FB")]
	public GameObject LDBFPEKLENK
	{
		[Cpp2IlInjected.Token(Token = "0x60003EC")]
		[Cpp2IlInjected.Address(RVA = "0x7A2680", Offset = "0x7A1A80", VA = "0x1807A2680", Slot = "6")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000FC")]
	public Transform ODAEKBBDPFC
	{
		[Cpp2IlInjected.Token(Token = "0x60003ED")]
		[Cpp2IlInjected.Address(RVA = "0x7A26F0", Offset = "0x7A1AF0", VA = "0x1807A26F0", Slot = "7")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000FD")]
	public JCOFHJBGHJA EOGAOJCDEEE
	{
		[Cpp2IlInjected.Token(Token = "0x60003EE")]
		[Cpp2IlInjected.Address(RVA = "0x7A26C0", Offset = "0x7A1AC0", VA = "0x1807A26C0", Slot = "8")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60003EF")]
		[Cpp2IlInjected.Address(RVA = "0x7A26B0", Offset = "0x7A1AB0", VA = "0x1807A26B0", Slot = "9")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000FE")]
	public IReadOnlyList<JCOFHJBGHJA> OPIGCLHIKGM
	{
		[Cpp2IlInjected.Token(Token = "0x60003F0")]
		[Cpp2IlInjected.Address(RVA = "0x7A4970", Offset = "0x7A3D70", VA = "0x1807A4970", Slot = "10")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000FF")]
	public JCOFHJBGHJA OPHGKOLAGBH
	{
		[Cpp2IlInjected.Token(Token = "0x60003F1")]
		[Cpp2IlInjected.Address(RVA = "0x7A47A0", Offset = "0x7A3BA0", VA = "0x1807A47A0", Slot = "11")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000100")]
	public bool FFPFCCCKGMP
	{
		[Cpp2IlInjected.Token(Token = "0x60003F2")]
		[Cpp2IlInjected.Address(RVA = "0x80E990", Offset = "0x80DD90", VA = "0x18080E990", Slot = "12")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000101")]
	public bool PDPGPNLHDKB
	{
		[Cpp2IlInjected.Token(Token = "0x60003F3")]
		[Cpp2IlInjected.Address(RVA = "0x7EA290", Offset = "0x7E9690", VA = "0x1807EA290", Slot = "13")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000102")]
	public EBGPLIADLBP NPCFNCCEAJO
	{
		[Cpp2IlInjected.Token(Token = "0x60003F4")]
		[Cpp2IlInjected.Address(RVA = "0x7A6790", Offset = "0x7A5B90", VA = "0x1807A6790", Slot = "14")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60003F5")]
		[Cpp2IlInjected.Address(RVA = "0x7A67C0", Offset = "0x7A5BC0", VA = "0x1807A67C0", Slot = "15")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000103")]
	public OEEPKCKPLEL LAOMDEGHJLM
	{
		[Cpp2IlInjected.Token(Token = "0x60003F6")]
		[Cpp2IlInjected.Address(RVA = "0x7A67D0", Offset = "0x7A5BD0", VA = "0x1807A67D0", Slot = "16")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60003F7")]
		[Cpp2IlInjected.Address(RVA = "0x7A6810", Offset = "0x7A5C10", VA = "0x1807A6810", Slot = "17")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000104")]
	public float ILJFFAPOBNP
	{
		[Cpp2IlInjected.Token(Token = "0x60003F8")]
		[Cpp2IlInjected.Address(RVA = "0x9EEE60", Offset = "0x9EE260", VA = "0x1809EEE60", Slot = "18")]
		[CompilerGenerated]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x60003F9")]
		[Cpp2IlInjected.Address(RVA = "0x8BC980", Offset = "0x8BBD80", VA = "0x1808BC980", Slot = "19")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000105")]
	public Vector3 CDFFMHAADHJ
	{
		[Cpp2IlInjected.Token(Token = "0x60003FA")]
		[Cpp2IlInjected.Address(RVA = "0x1B40730", Offset = "0x1B3FB30", VA = "0x181B40730", Slot = "20")]
		[CompilerGenerated]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x60003FB")]
		[Cpp2IlInjected.Address(RVA = "0x5020960", Offset = "0x501FD60", VA = "0x185020960", Slot = "21")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000106")]
	public Vector3 ELLKJABMPJB
	{
		[Cpp2IlInjected.Token(Token = "0x60003FC")]
		[Cpp2IlInjected.Address(RVA = "0x476E6D0", Offset = "0x476DAD0", VA = "0x18476E6D0", Slot = "22")]
		[CompilerGenerated]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x60003FD")]
		[Cpp2IlInjected.Address(RVA = "0x476C000", Offset = "0x476B400", VA = "0x18476C000", Slot = "23")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000107")]
	public Vector3 BPGONCPMPON
	{
		[Cpp2IlInjected.Token(Token = "0x60003FE")]
		[Cpp2IlInjected.Address(RVA = "0x47491E0", Offset = "0x47485E0", VA = "0x1847491E0", Slot = "24")]
		[CompilerGenerated]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x60003FF")]
		[Cpp2IlInjected.Address(RVA = "0x47491C0", Offset = "0x47485C0", VA = "0x1847491C0", Slot = "25")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000108")]
	public Vector3 PPHKEOLJADG
	{
		[Cpp2IlInjected.Token(Token = "0x6000400")]
		[Cpp2IlInjected.Address(RVA = "0xB19D20", Offset = "0xB19120", VA = "0x180B19D20", Slot = "26")]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x6000401")]
		[Cpp2IlInjected.Address(RVA = "0x7A0900", Offset = "0x79FD00", VA = "0x1807A0900", Slot = "27")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000109")]
	public bool IENLPMCJMAL
	{
		[Cpp2IlInjected.Token(Token = "0x6000402")]
		[Cpp2IlInjected.Address(RVA = "0x9332D0", Offset = "0x9326D0", VA = "0x1809332D0", Slot = "28")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700010A")]
	public bool ALJGPBCFAJC
	{
		[Cpp2IlInjected.Token(Token = "0x6000403")]
		[Cpp2IlInjected.Address(RVA = "0x17588C0", Offset = "0x1757CC0", VA = "0x1817588C0", Slot = "29")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700010B")]
	public bool OPLHKLPKLIH
	{
		[Cpp2IlInjected.Token(Token = "0x6000404")]
		[Cpp2IlInjected.Address(RVA = "0x5EB04D0", Offset = "0x5EAF8D0", VA = "0x185EB04D0", Slot = "30")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700010C")]
	public Vector3 JAEHHIFFHAO
	{
		[Cpp2IlInjected.Token(Token = "0x6000405")]
		[Cpp2IlInjected.Address(RVA = "0x475DBB0", Offset = "0x475CFB0", VA = "0x18475DBB0", Slot = "31")]
		[CompilerGenerated]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700010D")]
	public Vector3 DBENDJKNCLA
	{
		[Cpp2IlInjected.Token(Token = "0x6000406")]
		[Cpp2IlInjected.Address(RVA = "0x960DB0", Offset = "0x9601B0", VA = "0x180960DB0", Slot = "32")]
		[CompilerGenerated]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700010E")]
	public Vector3 DKCKPGONLCO
	{
		[Cpp2IlInjected.Token(Token = "0x6000407")]
		[Cpp2IlInjected.Address(RVA = "0xB19D20", Offset = "0xB19120", VA = "0x180B19D20", Slot = "33")]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x6000408")]
		[Cpp2IlInjected.Address(RVA = "0x7A0900", Offset = "0x79FD00", VA = "0x1807A0900", Slot = "34")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700010F")]
	public Vector3 EAIFIKDGKFD
	{
		[Cpp2IlInjected.Token(Token = "0x6000409")]
		[Cpp2IlInjected.Address(RVA = "0x6646710", Offset = "0x6645B10", VA = "0x186646710", Slot = "35")]
		[CompilerGenerated]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000110")]
	public float LOOBEDBGKGP
	{
		[Cpp2IlInjected.Token(Token = "0x600040A")]
		[Cpp2IlInjected.Address(RVA = "0x1A44B20", Offset = "0x1A43F20", VA = "0x181A44B20", Slot = "36")]
		[CompilerGenerated]
		get
		{
			return default(float);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000111")]
	public float LLPPBNBJAIJ
	{
		[Cpp2IlInjected.Token(Token = "0x600040B")]
		[Cpp2IlInjected.Address(RVA = "0x7EE630", Offset = "0x7EDA30", VA = "0x1807EE630", Slot = "37")]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x600040C")]
		[Cpp2IlInjected.Address(RVA = "0x7A0900", Offset = "0x79FD00", VA = "0x1807A0900", Slot = "38")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000112")]
	public Vector3 GPBCJEBAHGH
	{
		[Cpp2IlInjected.Token(Token = "0x600040D")]
		[Cpp2IlInjected.Address(RVA = "0xB19D20", Offset = "0xB19120", VA = "0x180B19D20", Slot = "39")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000113")]
	public Quaternion PNNPLKIEMEL
	{
		[Cpp2IlInjected.Token(Token = "0x600040E")]
		[Cpp2IlInjected.Address(RVA = "0x8EE390", Offset = "0x8ED790", VA = "0x1808EE390", Slot = "40")]
		get
		{
			return default(Quaternion);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000114")]
	public float PDJELALCJNL
	{
		[Cpp2IlInjected.Token(Token = "0x6000410")]
		[Cpp2IlInjected.Address(RVA = "0x7EE630", Offset = "0x7EDA30", VA = "0x1807EE630", Slot = "42")]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x6000411")]
		[Cpp2IlInjected.Address(RVA = "0x7A0900", Offset = "0x79FD00", VA = "0x1807A0900", Slot = "43")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000115")]
	public float LHECHOENGNG
	{
		[Cpp2IlInjected.Token(Token = "0x6000412")]
		[Cpp2IlInjected.Address(RVA = "0x7EE630", Offset = "0x7EDA30", VA = "0x1807EE630", Slot = "44")]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x6000413")]
		[Cpp2IlInjected.Address(RVA = "0x7A0900", Offset = "0x79FD00", VA = "0x1807A0900", Slot = "45")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000116")]
	public bool PPOPHDEHNNA
	{
		[Cpp2IlInjected.Token(Token = "0x6000414")]
		[Cpp2IlInjected.Address(RVA = "0x7E7780", Offset = "0x7E6B80", VA = "0x1807E7780", Slot = "46")]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000415")]
		[Cpp2IlInjected.Address(RVA = "0x7A0900", Offset = "0x79FD00", VA = "0x1807A0900", Slot = "47")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000117")]
	public GOOCPGCLLJK OKHKDAGKHIN
	{
		[Cpp2IlInjected.Token(Token = "0x6000416")]
		[Cpp2IlInjected.Address(RVA = "0x7E7780", Offset = "0x7E6B80", VA = "0x1807E7780", Slot = "48")]
		get
		{
			return default(GOOCPGCLLJK);
		}
		[Cpp2IlInjected.Token(Token = "0x6000417")]
		[Cpp2IlInjected.Address(RVA = "0x7A0900", Offset = "0x79FD00", VA = "0x1807A0900", Slot = "49")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000118")]
	public bool LBJIFIJGLFG
	{
		[Cpp2IlInjected.Token(Token = "0x6000418")]
		[Cpp2IlInjected.Address(RVA = "0xCD3960", Offset = "0xCD2D60", VA = "0x180CD3960", Slot = "50")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000119")]
	public Transform BCEDFGPKPCG
	{
		[Cpp2IlInjected.Token(Token = "0x6000419")]
		[Cpp2IlInjected.Address(RVA = "0x9A3830", Offset = "0x9A2C30", VA = "0x1809A3830", Slot = "51")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700011A")]
	public Vector3 IMJAMINFNFO
	{
		[Cpp2IlInjected.Token(Token = "0x600041A")]
		[Cpp2IlInjected.Address(RVA = "0xB19D20", Offset = "0xB19120", VA = "0x180B19D20", Slot = "52")]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x600041B")]
		[Cpp2IlInjected.Address(RVA = "0x7A0900", Offset = "0x79FD00", VA = "0x1807A0900", Slot = "53")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700011B")]
	public float AOLGPBNKCKH
	{
		[Cpp2IlInjected.Token(Token = "0x600041C")]
		[Cpp2IlInjected.Address(RVA = "0x7EE630", Offset = "0x7EDA30", VA = "0x1807EE630", Slot = "54")]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x600041D")]
		[Cpp2IlInjected.Address(RVA = "0x7A0900", Offset = "0x79FD00", VA = "0x1807A0900", Slot = "55")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700011C")]
	public float GDAJCJKIBLE
	{
		[Cpp2IlInjected.Token(Token = "0x600041E")]
		[Cpp2IlInjected.Address(RVA = "0x7EE630", Offset = "0x7EDA30", VA = "0x1807EE630", Slot = "56")]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x600041F")]
		[Cpp2IlInjected.Address(RVA = "0x7A0900", Offset = "0x79FD00", VA = "0x1807A0900", Slot = "57")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700011D")]
	public Quaternion OIJGDFEHDPK
	{
		[Cpp2IlInjected.Token(Token = "0x6000420")]
		[Cpp2IlInjected.Address(RVA = "0x993A20", Offset = "0x992E20", VA = "0x180993A20", Slot = "58")]
		get
		{
			return default(Quaternion);
		}
		[Cpp2IlInjected.Token(Token = "0x6000421")]
		[Cpp2IlInjected.Address(RVA = "0x7A0900", Offset = "0x79FD00", VA = "0x1807A0900", Slot = "59")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700011E")]
	public Vector3 PEDCHEEBCKD
	{
		[Cpp2IlInjected.Token(Token = "0x6000422")]
		[Cpp2IlInjected.Address(RVA = "0xB19D20", Offset = "0xB19120", VA = "0x180B19D20", Slot = "60")]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x6000423")]
		[Cpp2IlInjected.Address(RVA = "0x7A0900", Offset = "0x79FD00", VA = "0x1807A0900", Slot = "61")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700011F")]
	public Quaternion IFBEDGFGEHN
	{
		[Cpp2IlInjected.Token(Token = "0x6000424")]
		[Cpp2IlInjected.Address(RVA = "0x993A20", Offset = "0x992E20", VA = "0x180993A20", Slot = "62")]
		get
		{
			return default(Quaternion);
		}
		[Cpp2IlInjected.Token(Token = "0x6000425")]
		[Cpp2IlInjected.Address(RVA = "0x7A0900", Offset = "0x79FD00", VA = "0x1807A0900", Slot = "63")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000120")]
	public RigidbodyConstraints LFMJJPGKPGH
	{
		[Cpp2IlInjected.Token(Token = "0x6000426")]
		[Cpp2IlInjected.Address(RVA = "0x7A0910", Offset = "0x79FD10", VA = "0x1807A0910", Slot = "64")]
		get
		{
			return default(RigidbodyConstraints);
		}
		[Cpp2IlInjected.Token(Token = "0x6000427")]
		[Cpp2IlInjected.Address(RVA = "0x7A0900", Offset = "0x79FD00", VA = "0x1807A0900", Slot = "65")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000121")]
	public bool KGIFFCDEOAE
	{
		[Cpp2IlInjected.Token(Token = "0x6000428")]
		[Cpp2IlInjected.Address(RVA = "0x7E7780", Offset = "0x7E6B80", VA = "0x1807E7780", Slot = "66")]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000429")]
		[Cpp2IlInjected.Address(RVA = "0x7A0900", Offset = "0x79FD00", VA = "0x1807A0900", Slot = "67")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000122")]
	public CollisionDetectionMode BMACCDICLGG
	{
		[Cpp2IlInjected.Token(Token = "0x600042A")]
		[Cpp2IlInjected.Address(RVA = "0x7A0910", Offset = "0x79FD10", VA = "0x1807A0910", Slot = "68")]
		get
		{
			return default(CollisionDetectionMode);
		}
		[Cpp2IlInjected.Token(Token = "0x600042B")]
		[Cpp2IlInjected.Address(RVA = "0x7A0900", Offset = "0x79FD00", VA = "0x1807A0900", Slot = "69")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000123")]
	public bool ALACEGOHBBC
	{
		[Cpp2IlInjected.Token(Token = "0x600042C")]
		[Cpp2IlInjected.Address(RVA = "0x8C9D70", Offset = "0x8C9170", VA = "0x1808C9D70", Slot = "70")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000038")]
	public event FLEHDNMKJOM DGFHCDMPNOC
	{
		[Cpp2IlInjected.Token(Token = "0x60003D8")]
		[Cpp2IlInjected.Address(RVA = "0x7A0900", Offset = "0x79FD00", VA = "0x1807A0900", Slot = "75")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60003D9")]
		[Cpp2IlInjected.Address(RVA = "0x7A0900", Offset = "0x79FD00", VA = "0x1807A0900", Slot = "76")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000039")]
	public event FLEHDNMKJOM AJNJNDIOIEI
	{
		[Cpp2IlInjected.Token(Token = "0x60003DA")]
		[Cpp2IlInjected.Address(RVA = "0x7A0900", Offset = "0x79FD00", VA = "0x1807A0900", Slot = "77")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60003DB")]
		[Cpp2IlInjected.Address(RVA = "0x7A0900", Offset = "0x79FD00", VA = "0x1807A0900", Slot = "78")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400003A")]
	public event GANGMHHLDKO EAAJADAMIEB
	{
		[Cpp2IlInjected.Token(Token = "0x60003DC")]
		[Cpp2IlInjected.Address(RVA = "0x7A0900", Offset = "0x79FD00", VA = "0x1807A0900", Slot = "79")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60003DD")]
		[Cpp2IlInjected.Address(RVA = "0x7A0900", Offset = "0x79FD00", VA = "0x1807A0900", Slot = "80")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400003B")]
	public event FLEHDNMKJOM HLHMNNKNCHD
	{
		[Cpp2IlInjected.Token(Token = "0x60003DE")]
		[Cpp2IlInjected.Address(RVA = "0x7A0900", Offset = "0x79FD00", VA = "0x1807A0900", Slot = "82")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60003DF")]
		[Cpp2IlInjected.Address(RVA = "0x7A0900", Offset = "0x79FD00", VA = "0x1807A0900", Slot = "83")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400003C")]
	public event FLEHDNMKJOM OMOJLBAAJNO
	{
		[Cpp2IlInjected.Token(Token = "0x60003E0")]
		[Cpp2IlInjected.Address(RVA = "0x7A0900", Offset = "0x79FD00", VA = "0x1807A0900", Slot = "102")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60003E1")]
		[Cpp2IlInjected.Address(RVA = "0x7A0900", Offset = "0x79FD00", VA = "0x1807A0900", Slot = "103")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400003D")]
	public event FLEHDNMKJOM JOPHGGEPEGF
	{
		[Cpp2IlInjected.Token(Token = "0x60003E2")]
		[Cpp2IlInjected.Address(RVA = "0x7A0900", Offset = "0x79FD00", VA = "0x1807A0900", Slot = "107")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60003E3")]
		[Cpp2IlInjected.Address(RVA = "0x7A0900", Offset = "0x79FD00", VA = "0x1807A0900", Slot = "108")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400003E")]
	public event Action<MMMOHCNLPFL, MMMOHCNLPFL> KKLFFLFCKKL
	{
		[Cpp2IlInjected.Token(Token = "0x60003E4")]
		[Cpp2IlInjected.Address(RVA = "0x7A0900", Offset = "0x79FD00", VA = "0x1807A0900", Slot = "111")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60003E5")]
		[Cpp2IlInjected.Address(RVA = "0x7A0900", Offset = "0x79FD00", VA = "0x1807A0900", Slot = "112")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400003F")]
	public event FLEHDNMKJOM DMOBFCJFCHG
	{
		[Cpp2IlInjected.Token(Token = "0x60003E6")]
		[Cpp2IlInjected.Address(RVA = "0x7A0900", Offset = "0x79FD00", VA = "0x1807A0900", Slot = "113")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60003E7")]
		[Cpp2IlInjected.Address(RVA = "0x7A0900", Offset = "0x79FD00", VA = "0x1807A0900", Slot = "114")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000040")]
	public event FLEHDNMKJOM PHEOCLOKCBC
	{
		[Cpp2IlInjected.Token(Token = "0x60003E8")]
		[Cpp2IlInjected.Address(RVA = "0x7A0900", Offset = "0x79FD00", VA = "0x1807A0900", Slot = "119")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60003E9")]
		[Cpp2IlInjected.Address(RVA = "0x7A0900", Offset = "0x79FD00", VA = "0x1807A0900", Slot = "120")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600040F")]
	[Cpp2IlInjected.Address(RVA = "0x7A0900", Offset = "0x79FD00", VA = "0x1807A0900", Slot = "41")]
	public void PFEPHKNMKPF((Quaternion rot, Vector3 moments) EELLIIPGCJG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600042D")]
	[Cpp2IlInjected.Address(RVA = "0x7A0900", Offset = "0x79FD00", VA = "0x1807A0900", Slot = "71")]
	public void AHALPFGPHOF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600042E")]
	[Cpp2IlInjected.Address(RVA = "0x7A0900", Offset = "0x79FD00", VA = "0x1807A0900", Slot = "72")]
	public void FONLJBNDHEB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600042F")]
	[Cpp2IlInjected.Address(RVA = "0x7A0900", Offset = "0x79FD00", VA = "0x1807A0900", Slot = "73")]
	public void MJIHENGPCML()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000430")]
	[Cpp2IlInjected.Address(RVA = "0x7A0900", Offset = "0x79FD00", VA = "0x1807A0900", Slot = "74")]
	public void FHCIIFMIADL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000431")]
	[Cpp2IlInjected.Address(RVA = "0x7A0900", Offset = "0x79FD00", VA = "0x1807A0900", Slot = "134")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000432")]
	[Cpp2IlInjected.Address(RVA = "0x7A0900", Offset = "0x79FD00", VA = "0x1807A0900", Slot = "81")]
	public void IPJNFPFPNEM(JCOFHJBGHJA ANJCCKHBJJO, bool OHOCKJLAANC = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000433")]
	[Cpp2IlInjected.Address(RVA = "0x7A0900", Offset = "0x79FD00", VA = "0x1807A0900", Slot = "84")]
	public void OFJHCOCGNAD(object BDHKJODLPCL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000434")]
	[Cpp2IlInjected.Address(RVA = "0x7A0900", Offset = "0x79FD00", VA = "0x1807A0900", Slot = "85")]
	public void LAFHMMIGNHI(object BDHKJODLPCL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000435")]
	[Cpp2IlInjected.Address(RVA = "0xB19D20", Offset = "0xB19120", VA = "0x180B19D20", Slot = "86")]
	public Vector3 FAMKNNGPJGI(Vector3 ANEKCENIKFN)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000436")]
	[Cpp2IlInjected.Address(RVA = "0xB19D20", Offset = "0xB19120", VA = "0x180B19D20", Slot = "87")]
	public Vector3 CIMNPDLMMNF(Vector3 BNBPPNLIKAM)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000437")]
	[Cpp2IlInjected.Address(RVA = "0x7A0900", Offset = "0x79FD00", VA = "0x1807A0900", Slot = "88")]
	public void MEMDFIBKEPP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000438")]
	[Cpp2IlInjected.Address(RVA = "0x7A0900", Offset = "0x79FD00", VA = "0x1807A0900", Slot = "89")]
	public void DJHDKBHIGDN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000439")]
	[Cpp2IlInjected.Address(RVA = "0x7A0900", Offset = "0x79FD00", VA = "0x1807A0900", Slot = "90")]
	public void PNFNNMMCLFE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600043A")]
	[Cpp2IlInjected.Address(RVA = "0x7A0900", Offset = "0x79FD00", VA = "0x1807A0900", Slot = "91")]
	public void DENAIEDOENP(Vector3 FHLIJFCHIPI, Vector3 NEMLBHKHIJF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600043B")]
	[Cpp2IlInjected.Address(RVA = "0x7A0900", Offset = "0x79FD00", VA = "0x1807A0900", Slot = "92")]
	public void ENOBLMIPEAC(Vector3 KAAALJHMPDH, Vector3 BFLGOPEGDDM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600043C")]
	[Cpp2IlInjected.Address(RVA = "0x7A0900", Offset = "0x79FD00", VA = "0x1807A0900", Slot = "93")]
	public void MPFFKLHFEMH(Vector3 HBEOKBDKAPI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600043D")]
	[Cpp2IlInjected.Address(RVA = "0x7A0900", Offset = "0x79FD00", VA = "0x1807A0900", Slot = "94")]
	public void DLGALJLLKBC(IOIMFMPPEPK JJCOMEIHIFG, Vector3 LOPBIAGCJBL, float DJHFDGIPKCO, float GJGOKKJEDGM = 8f, float KHKMMDAMJPL = 1f)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600043E")]
	[Cpp2IlInjected.Address(RVA = "0x7A0900", Offset = "0x79FD00", VA = "0x1807A0900", Slot = "95")]
	public void FIGBACLJNDD(HGAFDACKLPM ALPAKFKNNFG, Vector3 JMPMBOKBENO, float MGEJKMAAPFM = float.PositiveInfinity)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600043F")]
	[Cpp2IlInjected.Address(RVA = "0x7A0900", Offset = "0x79FD00", VA = "0x1807A0900", Slot = "96")]
	public void IFNPBEKLMHH(HGAFDACKLPM ALPAKFKNNFG, Vector3 IKFFGJBHBIC, float KIDOONEEGII = 7f, float HDJMHGGGNBA = 1f)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000440")]
	[Cpp2IlInjected.Address(RVA = "0xB19D20", Offset = "0xB19120", VA = "0x180B19D20", Slot = "97")]
	public Vector3 IEPIAOMDAAG(Vector3 ANJCCKHBJJO)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000441")]
	[Cpp2IlInjected.Address(RVA = "0xB19D20", Offset = "0xB19120", VA = "0x180B19D20", Slot = "98")]
	public Vector3 GMNEMANIPAE(Vector3 ANJCCKHBJJO)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000442")]
	[Cpp2IlInjected.Address(RVA = "0x7A0900", Offset = "0x79FD00", VA = "0x1807A0900", Slot = "99")]
	public void KJCKGCGOJBM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000443")]
	[Cpp2IlInjected.Address(RVA = "0x7A0900", Offset = "0x79FD00", VA = "0x1807A0900", Slot = "100")]
	public void BMMKPJKFCJN(JCOFHJBGHJA OFCMPLLCIEA, object BDHKJODLPCL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000444")]
	[Cpp2IlInjected.Address(RVA = "0x7A0900", Offset = "0x79FD00", VA = "0x1807A0900", Slot = "101")]
	public void KFKPPNFPJGE(object BDHKJODLPCL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000445")]
	[Cpp2IlInjected.Address(RVA = "0x7A0900", Offset = "0x79FD00", VA = "0x1807A0900", Slot = "104")]
	public void MDMELEJAEMJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000446")]
	[Cpp2IlInjected.Address(RVA = "0x7A0900", Offset = "0x79FD00", VA = "0x1807A0900", Slot = "105")]
	public void KNGNMHHLNOJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000447")]
	[Cpp2IlInjected.Address(RVA = "0x7A0900", Offset = "0x79FD00", VA = "0x1807A0900", Slot = "106")]
	public void KJCFNJNJCNO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000448")]
	[Cpp2IlInjected.Address(RVA = "0x7E7780", Offset = "0x7E6B80", VA = "0x1807E7780", Slot = "109")]
	public bool HIMNDBELLFC()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000449")]
	[Cpp2IlInjected.Address(RVA = "0x7A0900", Offset = "0x79FD00", VA = "0x1807A0900", Slot = "110")]
	public void LGECILGBLOD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600044A")]
	[Cpp2IlInjected.Address(RVA = "0x7A0910", Offset = "0x79FD10", VA = "0x1807A0910", Slot = "115")]
	public IDisposable OHLNCDKJKKB()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600044B")]
	[Cpp2IlInjected.Address(RVA = "0x7A0900", Offset = "0x79FD00", VA = "0x1807A0900", Slot = "116")]
	public void OCIECADEFBE(object BDHKJODLPCL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600044C")]
	[Cpp2IlInjected.Address(RVA = "0x7A0900", Offset = "0x79FD00", VA = "0x1807A0900", Slot = "117")]
	public void BDHFACKMPAM(object BDHKJODLPCL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600044D")]
	[Cpp2IlInjected.Address(RVA = "0x7A0900", Offset = "0x79FD00", VA = "0x1807A0900", Slot = "118")]
	public void JMJCHOCCJDP(object BDHKJODLPCL, bool JEKJDJALDPH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600044E")]
	[Cpp2IlInjected.Address(RVA = "0x7A0900", Offset = "0x79FD00", VA = "0x1807A0900", Slot = "121")]
	public void CNNKKJLCHHA(Vector3 IFADGICOBNM, Quaternion JJGEHCBPHJF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600044F")]
	[Cpp2IlInjected.Address(RVA = "0x7A0900", Offset = "0x79FD00", VA = "0x1807A0900", Slot = "122")]
	public void AAOBGLOJCHA(Vector3 HJMGIFNAIIP, Quaternion PDEPBHFDPFN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000450")]
	[Cpp2IlInjected.Address(RVA = "0x7E7780", Offset = "0x7E6B80", VA = "0x1807E7780", Slot = "123")]
	public bool BFMEEBCMBCE(float COMNKNINMAC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000451")]
	[Cpp2IlInjected.Address(RVA = "0x7A0900", Offset = "0x79FD00", VA = "0x1807A0900", Slot = "124")]
	public void ILKIHBCBCPP(object BDHKJODLPCL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000452")]
	[Cpp2IlInjected.Address(RVA = "0x7A0900", Offset = "0x79FD00", VA = "0x1807A0900", Slot = "125")]
	public void NBAIFBIDOJA(object BDHKJODLPCL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000453")]
	[Cpp2IlInjected.Address(RVA = "0x7A0900", Offset = "0x79FD00", VA = "0x1807A0900", Slot = "126")]
	public void IFAGMNAOPKH(object BDHKJODLPCL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000454")]
	[Cpp2IlInjected.Address(RVA = "0x7A0900", Offset = "0x79FD00", VA = "0x1807A0900", Slot = "127")]
	public void ONPKKIOKJND(object BDHKJODLPCL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000455")]
	[Cpp2IlInjected.Address(RVA = "0x7A0900", Offset = "0x79FD00", VA = "0x1807A0900", Slot = "128")]
	public void EOGJEEPJDGB(Vector3 BICEHKAFMDO, ForceMode NIBLDDDDGAO = ForceMode.Force)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000456")]
	[Cpp2IlInjected.Address(RVA = "0x7A0900", Offset = "0x79FD00", VA = "0x1807A0900", Slot = "129")]
	public void EGMCEHGBFBK(Vector3 BICEHKAFMDO, Vector3 BEBKKMFGLCG, ForceMode NIBLDDDDGAO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000457")]
	[Cpp2IlInjected.Address(RVA = "0x7A0900", Offset = "0x79FD00", VA = "0x1807A0900", Slot = "130")]
	public void DACJEFDGIGP(Vector3 IMFJIBNAPMK, ForceMode NIBLDDDDGAO = ForceMode.Force)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000458")]
	[Cpp2IlInjected.Address(RVA = "0x7A0900", Offset = "0x79FD00", VA = "0x1807A0900", Slot = "131")]
	public void JCCBIGPFMFC(Vector3 IMFJIBNAPMK, ForceMode NIBLDDDDGAO = ForceMode.Force)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000459")]
	[Cpp2IlInjected.Address(RVA = "0x66466F0", Offset = "0x6645AF0", VA = "0x1866466F0", Slot = "132")]
	public bool HMFCJNOKJNG(Vector3 PNADBCDBNOL, [Out] RaycastHit FDAHIHAIBKD, float FIOIECEGGAH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600045A")]
	[Cpp2IlInjected.Address(RVA = "0x7A0900", Offset = "0x79FD00", VA = "0x1807A0900", Slot = "133")]
	public void FFOPCPPNJNP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600045B")]
	[Cpp2IlInjected.Address(RVA = "0x7A2570", Offset = "0x7A1970", VA = "0x1807A2570")]
	public FGODNGNJEOL()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000043")]
public sealed class POGPNNCOCBE : AABMNPMKJNK, FNEPNDPKACM, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
	[Cpp2IlInjected.Token(Token = "0x4000075")]
	internal FNONGLLGKNI CMIPJIFIMCO;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
	[Cpp2IlInjected.Token(Token = "0x4000076")]
	internal MNHOJKKMHCG GIIDMCJEBCO;

	[Cpp2IlInjected.Token(Token = "0x600045D")]
	[Cpp2IlInjected.Address(RVA = "0x66351A0", Offset = "0x66345A0", VA = "0x1866351A0")]
	public POGPNNCOCBE(GameObject ILLDLCGIGNA, RigidbodyEx LLKNPEHAHCE, FCIHFBGEFGG IALOIPDIIAG, [In] OEDKMOJJJDN ALPLHOOHPEL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600045E")]
	[Cpp2IlInjected.Address(RVA = "0x66541B0", Offset = "0x66535B0", VA = "0x1866541B0", Slot = "135")]
	protected override void OEHKNGNBPKP(FCIHFBGEFGG IALOIPDIIAG, OEDKMOJJJDN ALPLHOOHPEL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600045F")]
	[Cpp2IlInjected.Address(RVA = "0x7A0910", Offset = "0x79FD10", VA = "0x1807A0910", Slot = "141")]
	protected override IDisposable NAJNBEFJBHC()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000460")]
	[Cpp2IlInjected.Address(RVA = "0x6653CD0", Offset = "0x66530D0", VA = "0x186653CD0", Slot = "136")]
	public override void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000461")]
	[Cpp2IlInjected.Address(RVA = "0x66539D0", Offset = "0x6652DD0", VA = "0x1866539D0", Slot = "142")]
	public void CGLLDENDAAM(DLKBDHLDNGO BIHDJPFDCHH, DLKBDHLDNGO MLMOJGJLJGF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000462")]
	[Cpp2IlInjected.Address(RVA = "0x6653F60", Offset = "0x6653360", VA = "0x186653F60", Slot = "143")]
	public void MFCNNBCJCFO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000463")]
	[Cpp2IlInjected.Address(RVA = "0x6653EA0", Offset = "0x66532A0", VA = "0x186653EA0", Slot = "144")]
	public void IBHDAEBEHDI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000464")]
	[Cpp2IlInjected.Address(RVA = "0x6653E40", Offset = "0x6653240", VA = "0x186653E40", Slot = "145")]
	public void HFBIOGKFJLO(bool CPAENGEGPEJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000465")]
	[Cpp2IlInjected.Address(RVA = "0x6654020", Offset = "0x6653420", VA = "0x186654020", Slot = "146")]
	public bool MFOJLCOFOPE()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000466")]
	[Cpp2IlInjected.Address(RVA = "0x6653970", Offset = "0x6652D70", VA = "0x186653970", Slot = "147")]
	public void AFNNPCMAEMF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000467")]
	[Cpp2IlInjected.Address(RVA = "0x7A0900", Offset = "0x79FD00", VA = "0x1807A0900", Slot = "140")]
	protected override void ACEOCLPJPIH(RigidbodyEx OIGNJCHPDMC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000468")]
	[Cpp2IlInjected.Address(RVA = "0x6653AA0", Offset = "0x6652EA0", VA = "0x186653AA0")]
	private void DBPLJHLGNEC()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000044")]
internal static class KFPAIFJMIOE
{
	[Cpp2IlInjected.Token(Token = "0x6000469")]
	[Cpp2IlInjected.Address(RVA = "0x664C7A0", Offset = "0x664BBA0", VA = "0x18664C7A0")]
	public static AABMNPMKJNK HEOKAOADOCM(this JCOFHJBGHJA FBIBFNALIEI)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000045")]
public interface HMIMCOGAAIJ : DFEBEBBPEII, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x600046A")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void CBNJEMBLCPC(JCOFHJBGHJA ICFAMCDBCJP);

	[Cpp2IlInjected.Token(Token = "0x600046B")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void IALHOMHICOG(JCOFHJBGHJA ICFAMCDBCJP);

	[Cpp2IlInjected.Token(Token = "0x600046C")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void OIELMHGCNDB(JCOFHJBGHJA KBNLAPAAIPK);

	[Cpp2IlInjected.Token(Token = "0x600046D")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void GECFDCOPMHK(JCOFHJBGHJA KBNLAPAAIPK);
}
[Cpp2IlInjected.Token(Token = "0x2000046")]
public interface LKNPHANGIFI : JJMHLHBDECD
{
	[Cpp2IlInjected.Token(Token = "0x17000124")]
	GFMJKNFJHKM<JCOFHJBGHJA> JJKDJJNAONA
	{
		[Cpp2IlInjected.Token(Token = "0x600046E")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000125")]
	JCOFHJBGHJA FGJHCPAEPDL
	{
		[Cpp2IlInjected.Token(Token = "0x600046F")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000047")]
public interface IIHKNALEOMC : KPKDIHHLHAL
{
	[Cpp2IlInjected.Token(Token = "0x6000470")]
	[Cpp2IlInjected.Address(Slot = "0")]
	(float, Vector3) DNCJOPAIPEH(Rigidbody NFNENKNHHDF);
}
[Cpp2IlInjected.Token(Token = "0x2000048")]
public interface GJCNHINDMJF : NMOCGBHDPAJ, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x17000126")]
	PhotonView MJMEFFOHJCC
	{
		[Cpp2IlInjected.Token(Token = "0x6000471")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000049")]
internal sealed class LADFOMGKPBL : NDECPKLCGPL
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000077")]
	private readonly AABMNPMKJNK ICFAMCDBCJP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000078")]
	private CollisionDetectionMode FHOKCJADINN;

	[Cpp2IlInjected.Token(Token = "0x17000127")]
	private Rigidbody OHEHDKEKPMJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000472")]
		[Cpp2IlInjected.Address(RVA = "0x663E570", Offset = "0x663D970", VA = "0x18663E570")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000128")]
	public CollisionDetectionMode BMACCDICLGG
	{
		[Cpp2IlInjected.Token(Token = "0x6000476")]
		[Cpp2IlInjected.Address(RVA = "0x664D780", Offset = "0x664CB80", VA = "0x18664D780", Slot = "4")]
		get
		{
			return default(CollisionDetectionMode);
		}
		[Cpp2IlInjected.Token(Token = "0x6000477")]
		[Cpp2IlInjected.Address(RVA = "0x664D470", Offset = "0x664C870", VA = "0x18664D470", Slot = "5")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000473")]
	[Cpp2IlInjected.Address(RVA = "0x6635420", Offset = "0x6634820", VA = "0x186635420")]
	public LADFOMGKPBL(JCOFHJBGHJA ICFAMCDBCJP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000474")]
	[Cpp2IlInjected.Address(RVA = "0x664D360", Offset = "0x664C760", VA = "0x18664D360", Slot = "6")]
	public void AHALPFGPHOF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000475")]
	[Cpp2IlInjected.Address(RVA = "0x664D2E0", Offset = "0x664C6E0", VA = "0x18664D2E0", Slot = "9")]
	public void AEMAJDMNPCO(Rigidbody ADEHOEHEFLF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000478")]
	[Cpp2IlInjected.Address(RVA = "0x664D610", Offset = "0x664CA10", VA = "0x18664D610", Slot = "7")]
	public void GCEKOKLNFKE(bool JEELKKFJOMD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000479")]
	[Cpp2IlInjected.Address(RVA = "0x664D600", Offset = "0x664CA00", VA = "0x18664D600", Slot = "8")]
	public void FCIGBFFNGFJ(bool JEELKKFJOMD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600047A")]
	[Cpp2IlInjected.Address(RVA = "0x664D620", Offset = "0x664CA20", VA = "0x18664D620", Slot = "10")]
	public bool HMFCJNOKJNG(Vector3 PNADBCDBNOL, [Out] RaycastHit FDAHIHAIBKD, float FIOIECEGGAH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600047B")]
	[Cpp2IlInjected.Address(RVA = "0x664D4E0", Offset = "0x664C8E0", VA = "0x18664D4E0")]
	private void DFOKKEPDKAK(bool JEELKKFJOMD)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200004A")]
public sealed class FPJOMLCPHGL : NHEBLBOICHI, IDisposable, AMAGPLIHPFI
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400007A")]
	private readonly AABMNPMKJNK ICFAMCDBCJP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400007B")]
	private GOOCPGCLLJK GCOIECPIOEC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400007C")]
	private AIPACPAGJIN ODFLCHKNDBA;

	[Cpp2IlInjected.Token(Token = "0x17000129")]
	public GOOCPGCLLJK OKHKDAGKHIN
	{
		[Cpp2IlInjected.Token(Token = "0x600047E")]
		[Cpp2IlInjected.Address(RVA = "0x6646AB0", Offset = "0x6645EB0", VA = "0x186646AB0", Slot = "6")]
		get
		{
			return default(GOOCPGCLLJK);
		}
		[Cpp2IlInjected.Token(Token = "0x600047F")]
		[Cpp2IlInjected.Address(RVA = "0x6646DD0", Offset = "0x66461D0", VA = "0x186646DD0", Slot = "7")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700012A")]
	private Transform HNOHFJILGJJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000480")]
		[Cpp2IlInjected.Address(RVA = "0x6646D00", Offset = "0x6646100", VA = "0x186646D00", Slot = "10")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000041")]
	public event Action<MMMOHCNLPFL, MMMOHCNLPFL> KKLFFLFCKKL
	{
		[Cpp2IlInjected.Token(Token = "0x600047C")]
		[Cpp2IlInjected.Address(RVA = "0x6646D20", Offset = "0x6646120", VA = "0x186646D20", Slot = "4")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600047D")]
		[Cpp2IlInjected.Address(RVA = "0x6646C50", Offset = "0x6646050", VA = "0x186646C50", Slot = "5")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000481")]
	[Cpp2IlInjected.Address(RVA = "0x6646EA0", Offset = "0x66462A0", VA = "0x186646EA0")]
	public FPJOMLCPHGL(JCOFHJBGHJA ICFAMCDBCJP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000482")]
	[Cpp2IlInjected.Address(RVA = "0x66467B0", Offset = "0x6645BB0", VA = "0x1866467B0", Slot = "8")]
	public void AHALPFGPHOF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000483")]
	[Cpp2IlInjected.Address(RVA = "0x6646C00", Offset = "0x6646000", VA = "0x186646C00", Slot = "9")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000484")]
	[Cpp2IlInjected.Address(RVA = "0x1BCD4F0", Offset = "0x1BCC8F0", VA = "0x181BCD4F0", Slot = "11")]
	private void BPHBCCGNMNG(MMMOHCNLPFL HCGCEJELFOB, MMMOHCNLPFL HDDDKPPGHOG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000485")]
	[Cpp2IlInjected.Address(RVA = "0x7A0900", Offset = "0x79FD00", VA = "0x1807A0900", Slot = "12")]
	private void HIKLIOEJPMP(bool MPCCPHNCACM)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200004B")]
internal sealed class OHKLGHCCELG : PNBKJNMIIDD
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400007D")]
	private readonly AABMNPMKJNK ICFAMCDBCJP;

	[Cpp2IlInjected.Token(Token = "0x1700012B")]
	private Rigidbody OHEHDKEKPMJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000486")]
		[Cpp2IlInjected.Address(RVA = "0x663E570", Offset = "0x663D970", VA = "0x18663E570")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700012C")]
	private bool LBJIFIJGLFG
	{
		[Cpp2IlInjected.Token(Token = "0x6000487")]
		[Cpp2IlInjected.Address(RVA = "0x664A340", Offset = "0x6649740", VA = "0x18664A340")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700012D")]
	private bool PJOOMDNDEDM
	{
		[Cpp2IlInjected.Token(Token = "0x6000488")]
		[Cpp2IlInjected.Address(RVA = "0x6649680", Offset = "0x6648A80", VA = "0x186649680")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700012E")]
	private JCOFHJBGHJA EOGAOJCDEEE
	{
		[Cpp2IlInjected.Token(Token = "0x6000489")]
		[Cpp2IlInjected.Address(RVA = "0x664FBD0", Offset = "0x664EFD0", VA = "0x18664FBD0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600048A")]
	[Cpp2IlInjected.Address(RVA = "0x6635420", Offset = "0x6634820", VA = "0x186635420")]
	public OHKLGHCCELG(JCOFHJBGHJA ICFAMCDBCJP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600048B")]
	[Cpp2IlInjected.Address(RVA = "0x6650010", Offset = "0x664F410", VA = "0x186650010", Slot = "4")]
	public void EOGJEEPJDGB(Vector3 BICEHKAFMDO, ForceMode NIBLDDDDGAO = ForceMode.Force)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600048C")]
	[Cpp2IlInjected.Address(RVA = "0x66503D0", Offset = "0x664F7D0", VA = "0x1866503D0")]
	private void HILLBBNNHKO(Vector3 BICEHKAFMDO, ForceMode NIBLDDDDGAO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600048D")]
	[Cpp2IlInjected.Address(RVA = "0x664FD90", Offset = "0x664F190", VA = "0x18664FD90", Slot = "5")]
	public void EGMCEHGBFBK(Vector3 BICEHKAFMDO, Vector3 BEBKKMFGLCG, ForceMode NIBLDDDDGAO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600048E")]
	[Cpp2IlInjected.Address(RVA = "0x664FC30", Offset = "0x664F030", VA = "0x18664FC30", Slot = "6")]
	public void DACJEFDGIGP(Vector3 IMFJIBNAPMK, ForceMode NIBLDDDDGAO = ForceMode.Force)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600048F")]
	[Cpp2IlInjected.Address(RVA = "0x6650170", Offset = "0x664F570", VA = "0x186650170")]
	private void GMPNGHGLLAN(Vector3 IMFJIBNAPMK, ForceMode NIBLDDDDGAO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000490")]
	[Cpp2IlInjected.Address(RVA = "0x6650630", Offset = "0x664FA30", VA = "0x186650630", Slot = "7")]
	public void JCCBIGPFMFC(Vector3 IMFJIBNAPMK, ForceMode NIBLDDDDGAO = ForceMode.Force)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200004C")]
internal sealed class AOLIEFPNEAI : APDCPHMDBJE
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400007E")]
	private readonly AABMNPMKJNK ICFAMCDBCJP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400007F")]
	private bool LCHNEHLIHKO;

	[Cpp2IlInjected.Token(Token = "0x1700012F")]
	public bool PPOPHDEHNNA
	{
		[Cpp2IlInjected.Token(Token = "0x6000492")]
		[Cpp2IlInjected.Address(RVA = "0x817E40", Offset = "0x817240", VA = "0x180817E40", Slot = "4")]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000493")]
		[Cpp2IlInjected.Address(RVA = "0x6635270", Offset = "0x6634670", VA = "0x186635270", Slot = "5")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000491")]
	[Cpp2IlInjected.Address(RVA = "0x6635420", Offset = "0x6634820", VA = "0x186635420")]
	public AOLIEFPNEAI(JCOFHJBGHJA ICFAMCDBCJP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000494")]
	[Cpp2IlInjected.Address(RVA = "0x6635380", Offset = "0x6634780", VA = "0x186635380", Slot = "6")]
	public void AEMAJDMNPCO(Rigidbody ADEHOEHEFLF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000495")]
	[Cpp2IlInjected.Address(RVA = "0x66353B0", Offset = "0x66347B0", VA = "0x1866353B0", Slot = "7")]
	public void OLACCOJPAIO(Rigidbody ADEHOEHEFLF)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200004D")]
internal sealed class FEAIGLMFCIH : HMIMCOGAAIJ, DFEBEBBPEII, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x4000089")]
	private readonly JCOFHJBGHJA ICFAMCDBCJP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x400008A")]
	private readonly List<JCOFHJBGHJA> JLBHHENIDHH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x400008B")]
	private JCOFHJBGHJA DHHBNGOGOPD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x400008C")]
	private JCOFHJBGHJA EMDODFFCGEF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
	[Cpp2IlInjected.Token(Token = "0x400008D")]
	private Transform ABOOJHFHILF;

	[Cpp2IlInjected.Token(Token = "0x17000130")]
	private Transform ODAEKBBDPFC
	{
		[Cpp2IlInjected.Token(Token = "0x60004A8")]
		[Cpp2IlInjected.Address(RVA = "0x6645BA0", Offset = "0x6644FA0", VA = "0x186645BA0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000131")]
	public JCOFHJBGHJA EOGAOJCDEEE
	{
		[Cpp2IlInjected.Token(Token = "0x60004AB")]
		[Cpp2IlInjected.Address(RVA = "0x7A67F0", Offset = "0x7A5BF0", VA = "0x1807A67F0", Slot = "28")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60004AC")]
		[Cpp2IlInjected.Address(RVA = "0x6645C00", Offset = "0x6645000", VA = "0x186645C00", Slot = "29")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000132")]
	public JCOFHJBGHJA OPHGKOLAGBH
	{
		[Cpp2IlInjected.Token(Token = "0x60004AD")]
		[Cpp2IlInjected.Address(RVA = "0x7A67A0", Offset = "0x7A5BA0", VA = "0x1807A67A0", Slot = "27")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000133")]
	public IReadOnlyList<JCOFHJBGHJA> OPIGCLHIKGM
	{
		[Cpp2IlInjected.Token(Token = "0x60004AE")]
		[Cpp2IlInjected.Address(RVA = "0x7A6820", Offset = "0x7A5C20", VA = "0x1807A6820", Slot = "26")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000042")]
	public event FLEHDNMKJOM DGFHCDMPNOC
	{
		[Cpp2IlInjected.Token(Token = "0x6000496")]
		[Cpp2IlInjected.Address(RVA = "0x6644DB0", Offset = "0x66441B0", VA = "0x186644DB0", Slot = "8")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000497")]
		[Cpp2IlInjected.Address(RVA = "0x66463B0", Offset = "0x66457B0", VA = "0x1866463B0", Slot = "9")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000043")]
	public event FLEHDNMKJOM AJNJNDIOIEI
	{
		[Cpp2IlInjected.Token(Token = "0x6000498")]
		[Cpp2IlInjected.Address(RVA = "0x6644A40", Offset = "0x6643E40", VA = "0x186644A40", Slot = "10")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000499")]
		[Cpp2IlInjected.Address(RVA = "0x66453A0", Offset = "0x66447A0", VA = "0x1866453A0", Slot = "11")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000044")]
	public event GANGMHHLDKO EAAJADAMIEB
	{
		[Cpp2IlInjected.Token(Token = "0x600049A")]
		[Cpp2IlInjected.Address(RVA = "0x6645EA0", Offset = "0x66452A0", VA = "0x186645EA0", Slot = "12")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600049B")]
		[Cpp2IlInjected.Address(RVA = "0x6644FD0", Offset = "0x66443D0", VA = "0x186644FD0", Slot = "13")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000045")]
	public event Action HGBAPGIEKIL
	{
		[Cpp2IlInjected.Token(Token = "0x600049C")]
		[Cpp2IlInjected.Address(RVA = "0x6645D50", Offset = "0x6645150", VA = "0x186645D50", Slot = "14")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600049D")]
		[Cpp2IlInjected.Address(RVA = "0x6645440", Offset = "0x6644840", VA = "0x186645440", Slot = "15")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000046")]
	public event Action PJNMCFKMOFA
	{
		[Cpp2IlInjected.Token(Token = "0x600049E")]
		[Cpp2IlInjected.Address(RVA = "0x6646260", Offset = "0x6645660", VA = "0x186646260", Slot = "16")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600049F")]
		[Cpp2IlInjected.Address(RVA = "0x6645B00", Offset = "0x6644F00", VA = "0x186645B00", Slot = "17")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000047")]
	public event Action<JCOFHJBGHJA> FLGHEEMILPM
	{
		[Cpp2IlInjected.Token(Token = "0x60004A0")]
		[Cpp2IlInjected.Address(RVA = "0x6645DF0", Offset = "0x66451F0", VA = "0x186645DF0", Slot = "18")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60004A1")]
		[Cpp2IlInjected.Address(RVA = "0x6644D00", Offset = "0x6644100", VA = "0x186644D00", Slot = "19")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000048")]
	public event Action<JCOFHJBGHJA> HCIHFOBNDID
	{
		[Cpp2IlInjected.Token(Token = "0x60004A2")]
		[Cpp2IlInjected.Address(RVA = "0x6645F40", Offset = "0x6645340", VA = "0x186645F40", Slot = "20")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60004A3")]
		[Cpp2IlInjected.Address(RVA = "0x66452F0", Offset = "0x66446F0", VA = "0x1866452F0", Slot = "21")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000049")]
	public event Action MNPKJEPOBON
	{
		[Cpp2IlInjected.Token(Token = "0x60004A4")]
		[Cpp2IlInjected.Address(RVA = "0x66449A0", Offset = "0x6643DA0", VA = "0x1866449A0", Slot = "22")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60004A5")]
		[Cpp2IlInjected.Address(RVA = "0x6644810", Offset = "0x6643C10", VA = "0x186644810", Slot = "23")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400004A")]
	public event Action<JCOFHJBGHJA> OFPCHFBMHAN
	{
		[Cpp2IlInjected.Token(Token = "0x60004A6")]
		[Cpp2IlInjected.Address(RVA = "0x6646300", Offset = "0x6645700", VA = "0x186646300", Slot = "24")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60004A7")]
		[Cpp2IlInjected.Address(RVA = "0x6646580", Offset = "0x6645980", VA = "0x186646580", Slot = "25")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60004A9")]
	[Cpp2IlInjected.Address(RVA = "0x6646630", Offset = "0x6645A30", VA = "0x186646630")]
	public FEAIGLMFCIH(JCOFHJBGHJA ICFAMCDBCJP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004AA")]
	[Cpp2IlInjected.Address(RVA = "0x6644E50", Offset = "0x6644250", VA = "0x186644E50", Slot = "31")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004AF")]
	[Cpp2IlInjected.Address(RVA = "0x6645580", Offset = "0x6644980", VA = "0x186645580", Slot = "30")]
	public void IPJNFPFPNEM(JCOFHJBGHJA FOONBHGCLLE, bool OHOCKJLAANC = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004B0")]
	[Cpp2IlInjected.Address(RVA = "0x6645FF0", Offset = "0x66453F0", VA = "0x186645FF0", Slot = "6")]
	public void OIELMHGCNDB(JCOFHJBGHJA KBNLAPAAIPK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004B1")]
	[Cpp2IlInjected.Address(RVA = "0x6645070", Offset = "0x6644470", VA = "0x186645070", Slot = "7")]
	public void GECFDCOPMHK(JCOFHJBGHJA KBNLAPAAIPK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004B2")]
	[Cpp2IlInjected.Address(RVA = "0x6644AE0", Offset = "0x6643EE0", VA = "0x186644AE0", Slot = "4")]
	public void CBNJEMBLCPC(JCOFHJBGHJA ICFAMCDBCJP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004B3")]
	[Cpp2IlInjected.Address(RVA = "0x66454E0", Offset = "0x66448E0", VA = "0x1866454E0", Slot = "5")]
	public void IALHOMHICOG(JCOFHJBGHJA ICFAMCDBCJP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004B4")]
	[Cpp2IlInjected.Address(RVA = "0x6644EF0", Offset = "0x66442F0", VA = "0x186644EF0")]
	private void EFCAODNGOOF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004B5")]
	[Cpp2IlInjected.Address(RVA = "0x6644F90", Offset = "0x6644390", VA = "0x186644F90")]
	private void FHJDEHJPPBB(JCOFHJBGHJA KBNLAPAAIPK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004B6")]
	[Cpp2IlInjected.Address(RVA = "0x6645C10", Offset = "0x6645010", VA = "0x186645C10")]
	private void KHDINOCBEAF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004B7")]
	[Cpp2IlInjected.Address(RVA = "0x6644BD0", Offset = "0x6643FD0", VA = "0x186644BD0")]
	private void CHHNIKJCLMM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004B8")]
	[Cpp2IlInjected.Address(RVA = "0x6646450", Offset = "0x6645850", VA = "0x186646450")]
	private void PFKCLJMHNOJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004B9")]
	[Cpp2IlInjected.Address(RVA = "0x66448B0", Offset = "0x6643CB0", VA = "0x1866448B0")]
	[CompilerGenerated]
	private object BCFNBNOCNAN()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200004E")]
internal static class EHEDKBGJEAB
{
	[Cpp2IlInjected.Token(Token = "0x60004BA")]
	[Cpp2IlInjected.Address(RVA = "0x6643710", Offset = "0x6642B10", VA = "0x186643710")]
	public static HMIMCOGAAIJ LHMFADBCBJJ(this JCOFHJBGHJA FBIBFNALIEI)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200004F")]
internal sealed class PDEAOILFLFP : LKNPHANGIFI, JJMHLHBDECD
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400008E")]
	private readonly AABMNPMKJNK ICFAMCDBCJP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400008F")]
	private readonly GFMJKNFJHKM<JCOFHJBGHJA> KCFJFLJANIJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000090")]
	private bool KMPCIILKDAF;

	[Cpp2IlInjected.Token(Token = "0x17000134")]
	public GFMJKNFJHKM<JCOFHJBGHJA> JJKDJJNAONA
	{
		[Cpp2IlInjected.Token(Token = "0x60004BB")]
		[Cpp2IlInjected.Address(RVA = "0x7A2690", Offset = "0x7A1A90", VA = "0x1807A2690", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000135")]
	public Vector3 JAEHHIFFHAO
	{
		[Cpp2IlInjected.Token(Token = "0x60004BC")]
		[Cpp2IlInjected.Address(RVA = "0x66523A0", Offset = "0x66517A0", VA = "0x1866523A0", Slot = "6")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000136")]
	public Vector3 DBENDJKNCLA
	{
		[Cpp2IlInjected.Token(Token = "0x60004BD")]
		[Cpp2IlInjected.Address(RVA = "0x6652130", Offset = "0x6651530", VA = "0x186652130", Slot = "7")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000137")]
	private Vector3 BPGONCPMPON
	{
		[Cpp2IlInjected.Token(Token = "0x60004C1")]
		[Cpp2IlInjected.Address(RVA = "0x6651C50", Offset = "0x6651050", VA = "0x186651C50")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000138")]
	public JCOFHJBGHJA FGJHCPAEPDL
	{
		[Cpp2IlInjected.Token(Token = "0x60004C2")]
		[Cpp2IlInjected.Address(RVA = "0x66522F0", Offset = "0x66516F0", VA = "0x1866522F0", Slot = "5")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60004BE")]
	[Cpp2IlInjected.Address(RVA = "0x66527D0", Offset = "0x6651BD0", VA = "0x1866527D0")]
	public PDEAOILFLFP(JCOFHJBGHJA ICFAMCDBCJP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004BF")]
	[Cpp2IlInjected.Address(RVA = "0x6652760", Offset = "0x6651B60", VA = "0x186652760", Slot = "8")]
	public void PPDBDEBJGCD(JCOFHJBGHJA EMDODFFCGEF, object BDHKJODLPCL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004C0")]
	[Cpp2IlInjected.Address(RVA = "0x6651D40", Offset = "0x6651140", VA = "0x186651D40", Slot = "9")]
	public void DJBONJGLIDM(object BDHKJODLPCL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004C3")]
	[Cpp2IlInjected.Address(RVA = "0x6651DA0", Offset = "0x66511A0", VA = "0x186651DA0")]
	private Vector3 KHJOPIOPCPO()
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x60004C4")]
	[Cpp2IlInjected.Address(RVA = "0x66523D0", Offset = "0x66517D0", VA = "0x1866523D0")]
	private void MMHFCPDCKMJ(JCOFHJBGHJA ILEIMJKEDGA)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000050")]
internal static class KCDBLNANGEP
{
	[Cpp2IlInjected.Token(Token = "0x60004C5")]
	[Cpp2IlInjected.Address(RVA = "0x664B6E0", Offset = "0x664AAE0", VA = "0x18664B6E0")]
	public static LKNPHANGIFI OJPCPGGGPDD(this JCOFHJBGHJA FBIBFNALIEI)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000051")]
internal sealed class DBDOEIDKDAN : IIHKNALEOMC, KPKDIHHLHAL
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000092")]
	private readonly AABMNPMKJNK ICFAMCDBCJP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000093")]
	private readonly OverridableVector3 CGLGBHHNCJG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000094")]
	private readonly OverridableVector3 DLHCFNKIEFE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000095")]
	private float FIBNFPBKLOB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x44")]
	[Cpp2IlInjected.Token(Token = "0x4000096")]
	private float JMPLEBOLKFE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000097")]
	private Vector3 DPEHKDMOCLJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x54")]
	[Cpp2IlInjected.Token(Token = "0x4000098")]
	private Vector3? PDEPNANBMPF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x64")]
	[Cpp2IlInjected.Token(Token = "0x4000099")]
	private Quaternion? KPMPHEDFDBE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
	[Cpp2IlInjected.Token(Token = "0x400009A")]
	private bool FHODKELOHNF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x79")]
	[Cpp2IlInjected.Token(Token = "0x400009B")]
	private bool OALGDDAJDIF;

	[Cpp2IlInjected.Token(Token = "0x17000139")]
	public Vector3 DKCKPGONLCO
	{
		[Cpp2IlInjected.Token(Token = "0x60004C8")]
		[Cpp2IlInjected.Address(RVA = "0x1079B30", Offset = "0x1078F30", VA = "0x181079B30", Slot = "7")]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x60004C9")]
		[Cpp2IlInjected.Address(RVA = "0x6640900", Offset = "0x663FD00", VA = "0x186640900", Slot = "8")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700013A")]
	public Vector3 EAIFIKDGKFD
	{
		[Cpp2IlInjected.Token(Token = "0x60004CA")]
		[Cpp2IlInjected.Address(RVA = "0x66429E0", Offset = "0x6641DE0", VA = "0x1866429E0", Slot = "9")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700013B")]
	public float LOOBEDBGKGP
	{
		[Cpp2IlInjected.Token(Token = "0x60004CB")]
		[Cpp2IlInjected.Address(RVA = "0x1112FA0", Offset = "0x11123A0", VA = "0x181112FA0", Slot = "10")]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x60004CC")]
		[Cpp2IlInjected.Address(RVA = "0x66419D0", Offset = "0x6640DD0", VA = "0x1866419D0")]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700013C")]
	public float LLPPBNBJAIJ
	{
		[Cpp2IlInjected.Token(Token = "0x60004CD")]
		[Cpp2IlInjected.Address(RVA = "0xBA4FF0", Offset = "0xBA43F0", VA = "0x180BA4FF0", Slot = "11")]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x60004CE")]
		[Cpp2IlInjected.Address(RVA = "0x6640850", Offset = "0x663FC50", VA = "0x186640850", Slot = "12")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700013D")]
	public Vector3 GPBCJEBAHGH
	{
		[Cpp2IlInjected.Token(Token = "0x60004CF")]
		[Cpp2IlInjected.Address(RVA = "0x6642560", Offset = "0x6641960", VA = "0x186642560", Slot = "13")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700013E")]
	public Quaternion PNNPLKIEMEL
	{
		[Cpp2IlInjected.Token(Token = "0x60004D0")]
		[Cpp2IlInjected.Address(RVA = "0x66423E0", Offset = "0x66417E0", VA = "0x1866423E0", Slot = "14")]
		get
		{
			return default(Quaternion);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700013F")]
	private Rigidbody OHEHDKEKPMJ
	{
		[Cpp2IlInjected.Token(Token = "0x60004D8")]
		[Cpp2IlInjected.Address(RVA = "0x6642390", Offset = "0x6641790", VA = "0x186642390")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400004B")]
	public event FLEHDNMKJOM JAEBJNGECMP
	{
		[Cpp2IlInjected.Token(Token = "0x60004C6")]
		[Cpp2IlInjected.Address(RVA = "0x6642F20", Offset = "0x6642320", VA = "0x186642F20", Slot = "5")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60004C7")]
		[Cpp2IlInjected.Address(RVA = "0x66426F0", Offset = "0x6641AF0", VA = "0x1866426F0", Slot = "6")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60004D1")]
	[Cpp2IlInjected.Address(RVA = "0x66431F0", Offset = "0x66425F0", VA = "0x1866431F0")]
	public DBDOEIDKDAN(JCOFHJBGHJA ICFAMCDBCJP, [In] OEDKMOJJJDN ALPLHOOHPEL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004D2")]
	[Cpp2IlInjected.Address(RVA = "0x6642AE0", Offset = "0x6641EE0", VA = "0x186642AE0", Slot = "17")]
	public void MDMELEJAEMJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004D3")]
	[Cpp2IlInjected.Address(RVA = "0x6642900", Offset = "0x6641D00", VA = "0x186642900", Slot = "16")]
	public void KNGNMHHLNOJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004D4")]
	[Cpp2IlInjected.Address(RVA = "0x6640770", Offset = "0x663FB70", VA = "0x186640770", Slot = "19")]
	public void AEMAJDMNPCO(Rigidbody ADEHOEHEFLF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004D5")]
	[Cpp2IlInjected.Address(RVA = "0x6642C90", Offset = "0x6642090", VA = "0x186642C90", Slot = "20")]
	public void OLACCOJPAIO(Rigidbody ADEHOEHEFLF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004D6")]
	[Cpp2IlInjected.Address(RVA = "0x6642790", Offset = "0x6641B90", VA = "0x186642790", Slot = "18")]
	public void KJCFNJNJCNO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004D7")]
	[Cpp2IlInjected.Address(RVA = "0x6641D70", Offset = "0x6641170", VA = "0x186641D70", Slot = "21")]
	public void FFOPCPPNJNP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004D9")]
	[Cpp2IlInjected.Address(RVA = "0x6640900", Offset = "0x663FD00", VA = "0x186640900")]
	private void BLFHFFFLIHL(Vector3 ANJCCKHBJJO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004DA")]
	[Cpp2IlInjected.Address(RVA = "0x6641AE0", Offset = "0x6640EE0", VA = "0x186641AE0")]
	[Obsolete("This method is dangerous - the unity rigidbody is updated in a deferred manner and this world position may be stale")]
	private Vector3 EBBGJLJOOEP()
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x60004DB")]
	[Cpp2IlInjected.Address(RVA = "0x66419D0", Offset = "0x6640DD0", VA = "0x1866419D0")]
	private void DOLACLCFFLB(float ANJCCKHBJJO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004DC")]
	[Cpp2IlInjected.Address(RVA = "0x6640850", Offset = "0x663FC50", VA = "0x186640850")]
	private void ALCPMLGJMCJ(float ANJCCKHBJJO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004DD")]
	[Cpp2IlInjected.Address(RVA = "0x6641BD0", Offset = "0x6640FD0", VA = "0x186641BD0")]
	private Vector3 EBOGGBBFPDF()
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x60004DE")]
	[Cpp2IlInjected.Address(RVA = "0x6642FC0", Offset = "0x66423C0", VA = "0x186642FC0", Slot = "15")]
	public void PFEPHKNMKPF((Quaternion rot, Vector3 moments) EELLIIPGCJG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004DF")]
	[Cpp2IlInjected.Address(RVA = "0x6642210", Offset = "0x6641610", VA = "0x186642210")]
	private Quaternion FOPADKPKLKC()
	{
		return default(Quaternion);
	}

	[Cpp2IlInjected.Token(Token = "0x60004E0")]
	[Cpp2IlInjected.Address(RVA = "0x66409B0", Offset = "0x663FDB0", VA = "0x1866409B0")]
	public void DNCJOPAIPEH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004E1")]
	[Cpp2IlInjected.Address(RVA = "0x6640A80", Offset = "0x663FE80", VA = "0x186640A80", Slot = "4")]
	public (float, Vector3) DNCJOPAIPEH(Rigidbody NFNENKNHHDF)
	{
		return default((float, Vector3));
	}
}
[Cpp2IlInjected.Token(Token = "0x2000052")]
internal static class DHCKDNLNFNF
{
	[Cpp2IlInjected.Token(Token = "0x60004E2")]
	[Cpp2IlInjected.Address(RVA = "0x6643380", Offset = "0x6642780", VA = "0x186643380")]
	public static IIHKNALEOMC OAPIGKAMCBA(this JCOFHJBGHJA FBIBFNALIEI)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000053")]
internal sealed class KELJOJEMIAI : BECBDCABJBI
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400009C")]
	private readonly AABMNPMKJNK ICFAMCDBCJP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400009D")]
	private readonly JLFBFMMGKPJ GEKKKEHLHMJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400009E")]
	private readonly PKGDKKKFHAD DEAMFKGMENA;

	[Cpp2IlInjected.Token(Token = "0x17000140")]
	public bool DKKKFBPHJMJ
	{
		[Cpp2IlInjected.Token(Token = "0x60004E3")]
		[Cpp2IlInjected.Address(RVA = "0xCEC6D0", Offset = "0xCEBAD0", VA = "0x180CEC6D0", Slot = "10")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000141")]
	public PKGDKKKFHAD DDHMLFAGHDB
	{
		[Cpp2IlInjected.Token(Token = "0x60004E4")]
		[Cpp2IlInjected.Address(RVA = "0x8BDD90", Offset = "0x8BD190", VA = "0x1808BDD90", Slot = "11")]
		get
		{
			return default(PKGDKKKFHAD);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60004E5")]
	[Cpp2IlInjected.Address(RVA = "0x664C6A0", Offset = "0x664BAA0", VA = "0x18664C6A0")]
	public KELJOJEMIAI(JCOFHJBGHJA ICFAMCDBCJP, [In] OEDKMOJJJDN ALPLHOOHPEL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004E6")]
	[Cpp2IlInjected.Address(RVA = "0x664C0C0", Offset = "0x664B4C0", VA = "0x18664C0C0", Slot = "4")]
	public void AHALPFGPHOF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004E7")]
	[Cpp2IlInjected.Address(RVA = "0x664C600", Offset = "0x664BA00", VA = "0x18664C600")]
	private bool PAFHLHENBKE()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60004E8")]
	[Cpp2IlInjected.Address(RVA = "0x664C5A0", Offset = "0x664B9A0", VA = "0x18664C5A0", Slot = "5")]
	public void INJILPOGJHK(object BDHKJODLPCL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004E9")]
	[Cpp2IlInjected.Address(RVA = "0x664C5D0", Offset = "0x664B9D0", VA = "0x18664C5D0", Slot = "6")]
	public void MHGGBOGIOEK(object BDHKJODLPCL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004EA")]
	[Cpp2IlInjected.Address(RVA = "0x664C190", Offset = "0x664B590", VA = "0x18664C190", Slot = "9")]
	public void CMJJMIMJMJA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004EB")]
	[Cpp2IlInjected.Address(RVA = "0x664C310", Offset = "0x664B710", VA = "0x18664C310")]
	private void GPPFBOKFNAN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004EC")]
	[Cpp2IlInjected.Address(RVA = "0x664C430", Offset = "0x664B830", VA = "0x18664C430")]
	private void HFHDDLKKIEH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004ED")]
	[Cpp2IlInjected.Address(RVA = "0x664C2D0", Offset = "0x664B6D0", VA = "0x18664C2D0", Slot = "8")]
	public void FNFPCLJNIPI(JCOFHJBGHJA ICFAMCDBCJP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004EE")]
	[Cpp2IlInjected.Address(RVA = "0x664C080", Offset = "0x664B480", VA = "0x18664C080", Slot = "7")]
	public void ADFLBOFFGPH(JCOFHJBGHJA ICFAMCDBCJP)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000054")]
internal sealed class NHCBILBDMLL : FPLEKLLPLHN
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000A0")]
	private readonly AABMNPMKJNK ICFAMCDBCJP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000A1")]
	private readonly JLFBFMMGKPJ FLPEHBKKPID;

	[Cpp2IlInjected.Token(Token = "0x17000142")]
	public bool LBJIFIJGLFG
	{
		[Cpp2IlInjected.Token(Token = "0x60004F1")]
		[Cpp2IlInjected.Address(RVA = "0x664ED40", Offset = "0x664E140", VA = "0x18664ED40", Slot = "7")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400004C")]
	public event FLEHDNMKJOM DMOBFCJFCHG
	{
		[Cpp2IlInjected.Token(Token = "0x60004EF")]
		[Cpp2IlInjected.Address(RVA = "0x664EA60", Offset = "0x664DE60", VA = "0x18664EA60", Slot = "4")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60004F0")]
		[Cpp2IlInjected.Address(RVA = "0x664EB90", Offset = "0x664DF90", VA = "0x18664EB90", Slot = "5")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60004F2")]
	[Cpp2IlInjected.Address(RVA = "0x664EEE0", Offset = "0x664E2E0", VA = "0x18664EEE0")]
	public NHCBILBDMLL(JCOFHJBGHJA ICFAMCDBCJP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004F3")]
	[Cpp2IlInjected.Address(RVA = "0x664EE40", Offset = "0x664E240", VA = "0x18664EE40", Slot = "11")]
	public IDisposable OHLNCDKJKKB()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004F4")]
	[Cpp2IlInjected.Address(RVA = "0x664EE30", Offset = "0x664E230", VA = "0x18664EE30", Slot = "8")]
	public void OCIECADEFBE(object BDHKJODLPCL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004F5")]
	[Cpp2IlInjected.Address(RVA = "0x664EB80", Offset = "0x664DF80", VA = "0x18664EB80", Slot = "9")]
	public void BDHFACKMPAM(object BDHKJODLPCL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004F6")]
	[Cpp2IlInjected.Address(RVA = "0x664EC30", Offset = "0x664E030", VA = "0x18664EC30", Slot = "10")]
	public void JMJCHOCCJDP(object BDHKJODLPCL, bool JEKJDJALDPH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004F7")]
	[Cpp2IlInjected.Address(RVA = "0x664EDF0", Offset = "0x664E1F0", VA = "0x18664EDF0", Slot = "6")]
	public void LPJBNOGJIJA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004F8")]
	[Cpp2IlInjected.Address(RVA = "0x664EB00", Offset = "0x664DF00", VA = "0x18664EB00", Slot = "12")]
	public void AEMAJDMNPCO(Rigidbody APJBIKHBABA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004F9")]
	[Cpp2IlInjected.Address(RVA = "0x664EEB0", Offset = "0x664E2B0", VA = "0x18664EEB0", Slot = "13")]
	public void OLACCOJPAIO(Rigidbody ADEHOEHEFLF)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000055")]
internal sealed class OICEGLDJCFO : GJCNHINDMJF, NMOCGBHDPAJ, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000A3")]
	private readonly AABMNPMKJNK ICFAMCDBCJP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000A4")]
	private PhotonView DPHNICNACME;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40000A5")]
	private bool CGJFODBCOBG;

	[Cpp2IlInjected.Token(Token = "0x17000143")]
	public PhotonView MJMEFFOHJCC
	{
		[Cpp2IlInjected.Token(Token = "0x60004FC")]
		[Cpp2IlInjected.Address(RVA = "0x7A2680", Offset = "0x7A1A80", VA = "0x1807A2680", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000144")]
	public bool FFPFCCCKGMP
	{
		[Cpp2IlInjected.Token(Token = "0x60004FD")]
		[Cpp2IlInjected.Address(RVA = "0x66443E0", Offset = "0x66437E0", VA = "0x1866443E0", Slot = "7")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000145")]
	public bool PDPGPNLHDKB
	{
		[Cpp2IlInjected.Token(Token = "0x60004FE")]
		[Cpp2IlInjected.Address(RVA = "0x87DA20", Offset = "0x87CE20", VA = "0x18087DA20", Slot = "8")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400004D")]
	public event FLEHDNMKJOM HLHMNNKNCHD
	{
		[Cpp2IlInjected.Token(Token = "0x60004FA")]
		[Cpp2IlInjected.Address(RVA = "0x66509C0", Offset = "0x664FDC0", VA = "0x1866509C0", Slot = "5")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60004FB")]
		[Cpp2IlInjected.Address(RVA = "0x6650BD0", Offset = "0x664FFD0", VA = "0x186650BD0", Slot = "6")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60004FF")]
	[Cpp2IlInjected.Address(RVA = "0x6651420", Offset = "0x6650820", VA = "0x186651420")]
	public OICEGLDJCFO(JCOFHJBGHJA ICFAMCDBCJP, [In] OEDKMOJJJDN ALPLHOOHPEL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000500")]
	[Cpp2IlInjected.Address(RVA = "0x6650890", Offset = "0x664FC90", VA = "0x186650890", Slot = "9")]
	public void AHALPFGPHOF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000501")]
	[Cpp2IlInjected.Address(RVA = "0x6650C70", Offset = "0x6650070", VA = "0x186650C70", Slot = "12")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000502")]
	[Cpp2IlInjected.Address(RVA = "0x6650A60", Offset = "0x664FE60", VA = "0x186650A60", Slot = "10")]
	public void BKKACFBKLDE(JCOFHJBGHJA EMDODFFCGEF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000503")]
	[Cpp2IlInjected.Address(RVA = "0x66512B0", Offset = "0x66506B0", VA = "0x1866512B0", Slot = "11")]
	public void PGLFNOHKLFE(JCOFHJBGHJA EMDODFFCGEF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000504")]
	[Cpp2IlInjected.Address(RVA = "0x6650D70", Offset = "0x6650170", VA = "0x186650D70")]
	private void GGNGJBOHGCF(PhotonView APDMADLFGNA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000505")]
	[Cpp2IlInjected.Address(RVA = "0x6651150", Offset = "0x6650550", VA = "0x186651150")]
	private void MGBHOBLAAOG(RigidbodyEx COACDEBPLBI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000506")]
	[Cpp2IlInjected.Address(RVA = "0x6650EE0", Offset = "0x66502E0", VA = "0x186650EE0")]
	private void HNPDGFKDNBI(PhotonView HAKBMGLMELD)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000056")]
internal static class HEMEDBFOBJC
{
	[Cpp2IlInjected.Token(Token = "0x6000507")]
	[Cpp2IlInjected.Address(RVA = "0x6647E80", Offset = "0x6647280", VA = "0x186647E80")]
	public static GJCNHINDMJF OIIOCALBIKH(this JCOFHJBGHJA FBIBFNALIEI)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000057")]
internal sealed class CAKGFKCEAIP : KMAFPEDBELG
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000A6")]
	private readonly AABMNPMKJNK ICFAMCDBCJP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000A7")]
	private RigidbodyConstraints PBJBHPLLHKA;

	[Cpp2IlInjected.Token(Token = "0x17000146")]
	public bool KGIFFCDEOAE
	{
		[Cpp2IlInjected.Token(Token = "0x6000508")]
		[Cpp2IlInjected.Address(RVA = "0xAF5970", Offset = "0xAF4D70", VA = "0x180AF5970", Slot = "4")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000509")]
		[Cpp2IlInjected.Address(RVA = "0x3E74730", Offset = "0x3E73B30", VA = "0x183E74730", Slot = "5")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000147")]
	public bool AHEOPCHGDPG
	{
		[Cpp2IlInjected.Token(Token = "0x600050A")]
		[Cpp2IlInjected.Address(RVA = "0xD37BA0", Offset = "0xD36FA0", VA = "0x180D37BA0", Slot = "6")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x600050B")]
		[Cpp2IlInjected.Address(RVA = "0x3E74720", Offset = "0x3E73B20", VA = "0x183E74720")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000148")]
	public RigidbodyConstraints LFMJJPGKPGH
	{
		[Cpp2IlInjected.Token(Token = "0x600050C")]
		[Cpp2IlInjected.Address(RVA = "0x79E7B0", Offset = "0x79DBB0", VA = "0x18079E7B0", Slot = "7")]
		get
		{
			return default(RigidbodyConstraints);
		}
		[Cpp2IlInjected.Token(Token = "0x600050D")]
		[Cpp2IlInjected.Address(RVA = "0x6636440", Offset = "0x6635840", VA = "0x186636440", Slot = "8")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600050E")]
	[Cpp2IlInjected.Address(RVA = "0x66365A0", Offset = "0x66359A0", VA = "0x1866365A0")]
	public CAKGFKCEAIP(JCOFHJBGHJA ICFAMCDBCJP, [In] OEDKMOJJJDN ALPLHOOHPEL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600050F")]
	[Cpp2IlInjected.Address(RVA = "0x6636410", Offset = "0x6635810", VA = "0x186636410", Slot = "9")]
	public void AEMAJDMNPCO(Rigidbody ADEHOEHEFLF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000510")]
	[Cpp2IlInjected.Address(RVA = "0x6636570", Offset = "0x6635970", VA = "0x186636570", Slot = "10")]
	public void OLACCOJPAIO(Rigidbody ADEHOEHEFLF)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000058")]
internal sealed class DHMNOBEHJHF : LHIPGJNPCPA
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000AA")]
	private readonly JCOFHJBGHJA ICFAMCDBCJP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000AB")]
	private float GKFPPGKMBKH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
	[Cpp2IlInjected.Token(Token = "0x40000AC")]
	private float CFIGLOMJFEO;

	[Cpp2IlInjected.Token(Token = "0x17000149")]
	public float PDJELALCJNL
	{
		[Cpp2IlInjected.Token(Token = "0x6000512")]
		[Cpp2IlInjected.Address(RVA = "0x8BCF60", Offset = "0x8BC360", VA = "0x1808BCF60", Slot = "4")]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x6000513")]
		[Cpp2IlInjected.Address(RVA = "0x6643490", Offset = "0x6642890", VA = "0x186643490", Slot = "5")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700014A")]
	public float LHECHOENGNG
	{
		[Cpp2IlInjected.Token(Token = "0x6000514")]
		[Cpp2IlInjected.Address(RVA = "0x939570", Offset = "0x938970", VA = "0x180939570", Slot = "6")]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x6000515")]
		[Cpp2IlInjected.Address(RVA = "0x6643560", Offset = "0x6642960", VA = "0x186643560", Slot = "7")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000511")]
	[Cpp2IlInjected.Address(RVA = "0x66436D0", Offset = "0x6642AD0", VA = "0x1866436D0")]
	public DHMNOBEHJHF(JCOFHJBGHJA ICFAMCDBCJP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000516")]
	[Cpp2IlInjected.Address(RVA = "0x6643440", Offset = "0x6642840", VA = "0x186643440", Slot = "8")]
	public void AEMAJDMNPCO(Rigidbody ADEHOEHEFLF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000517")]
	[Cpp2IlInjected.Address(RVA = "0x6643630", Offset = "0x6642A30", VA = "0x186643630", Slot = "9")]
	public void OLACCOJPAIO(Rigidbody ADEHOEHEFLF)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000059")]
internal sealed class PEKGBCCEHEK : OCGFIHDLMDE
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000AE")]
	private readonly AABMNPMKJNK ICFAMCDBCJP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000AF")]
	private bool GJCFMMHDPBJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x21")]
	[Cpp2IlInjected.Token(Token = "0x40000B0")]
	private bool EIHHCFJNHPO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
	[Cpp2IlInjected.Token(Token = "0x40000B1")]
	private int HPLPIDOFMCA;

	[Cpp2IlInjected.Token(Token = "0x1700014B")]
	private Rigidbody OHEHDKEKPMJ
	{
		[Cpp2IlInjected.Token(Token = "0x600051A")]
		[Cpp2IlInjected.Address(RVA = "0x6642390", Offset = "0x6641790", VA = "0x186642390")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700014C")]
	private bool FKKBJAAELGK
	{
		[Cpp2IlInjected.Token(Token = "0x600051B")]
		[Cpp2IlInjected.Address(RVA = "0x6653080", Offset = "0x6652480", VA = "0x186653080")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700014D")]
	private JCOFHJBGHJA EOGAOJCDEEE
	{
		[Cpp2IlInjected.Token(Token = "0x600051C")]
		[Cpp2IlInjected.Address(RVA = "0x6652970", Offset = "0x6651D70", VA = "0x186652970")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700014E")]
	private bool PJOOMDNDEDM
	{
		[Cpp2IlInjected.Token(Token = "0x600051D")]
		[Cpp2IlInjected.Address(RVA = "0x6652C40", Offset = "0x6652040", VA = "0x186652C40")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400004E")]
	public event FLEHDNMKJOM JOPHGGEPEGF
	{
		[Cpp2IlInjected.Token(Token = "0x6000518")]
		[Cpp2IlInjected.Address(RVA = "0x66528D0", Offset = "0x6651CD0", VA = "0x1866528D0", Slot = "4")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000519")]
		[Cpp2IlInjected.Address(RVA = "0x66532F0", Offset = "0x66526F0", VA = "0x1866532F0", Slot = "5")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600051E")]
	[Cpp2IlInjected.Address(RVA = "0x6653390", Offset = "0x6652790", VA = "0x186653390")]
	public PEKGBCCEHEK(JCOFHJBGHJA ICFAMCDBCJP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600051F")]
	[Cpp2IlInjected.Address(RVA = "0x66529D0", Offset = "0x6651DD0", VA = "0x1866529D0", Slot = "6")]
	public void AHALPFGPHOF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000520")]
	[Cpp2IlInjected.Address(RVA = "0x6653240", Offset = "0x6652640", VA = "0x186653240", Slot = "8")]
	public void KOECFGPAONM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000521")]
	[Cpp2IlInjected.Address(RVA = "0x66530F0", Offset = "0x66524F0", VA = "0x1866530F0", Slot = "7")]
	public bool HIMNDBELLFC()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000522")]
	[Cpp2IlInjected.Address(RVA = "0x6652CA0", Offset = "0x66520A0", VA = "0x186652CA0", Slot = "9")]
	public void FHCIIFMIADL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000523")]
	[Cpp2IlInjected.Address(RVA = "0x6653250", Offset = "0x6652650", VA = "0x186653250", Slot = "11")]
	public void LGECILGBLOD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000524")]
	[Cpp2IlInjected.Address(RVA = "0x66530A0", Offset = "0x66524A0", VA = "0x1866530A0", Slot = "12")]
	public void HFBIOGKFJLO(bool CPAENGEGPEJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000525")]
	[Cpp2IlInjected.Address(RVA = "0x6652D40", Offset = "0x6652140", VA = "0x186652D40", Slot = "10")]
	public void FHOPNJINOBL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000526")]
	[Cpp2IlInjected.Address(RVA = "0x6652A60", Offset = "0x6651E60", VA = "0x186652A60")]
	private bool DDOOOOFDBID()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000527")]
	[Cpp2IlInjected.Address(RVA = "0x6652EF0", Offset = "0x66522F0", VA = "0x186652EF0")]
	private void GKILCEEOGED()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200005A")]
internal sealed class JLMLGGAEIAA : BOKFNFEEHEN
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000B2")]
	private readonly AABMNPMKJNK ICFAMCDBCJP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000B3")]
	private readonly JLFBFMMGKPJ GCAFGPNAJMC;

	[Cpp2IlInjected.Token(Token = "0x1700014F")]
	public Rigidbody OHEHDKEKPMJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000528")]
		[Cpp2IlInjected.Address(RVA = "0x7A2680", Offset = "0x7A1A80", VA = "0x1807A2680", Slot = "4")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000529")]
		[Cpp2IlInjected.Address(RVA = "0x7A2710", Offset = "0x7A1B10", VA = "0x1807A2710")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000150")]
	private bool PJOOMDNDEDM
	{
		[Cpp2IlInjected.Token(Token = "0x600052A")]
		[Cpp2IlInjected.Address(RVA = "0x6649680", Offset = "0x6648A80", VA = "0x186649680")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000151")]
	public bool CKHKFDAEDBM
	{
		[Cpp2IlInjected.Token(Token = "0x600052D")]
		[Cpp2IlInjected.Address(RVA = "0xCEC6D0", Offset = "0xCEBAD0", VA = "0x180CEC6D0", Slot = "6")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600052B")]
	[Cpp2IlInjected.Address(RVA = "0x664B5D0", Offset = "0x664A9D0", VA = "0x18664B5D0")]
	public JLMLGGAEIAA(JCOFHJBGHJA ICFAMCDBCJP, [In] OEDKMOJJJDN ALPLHOOHPEL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600052C")]
	[Cpp2IlInjected.Address(RVA = "0x664A640", Offset = "0x6649A40", VA = "0x18664A640", Slot = "5")]
	public void AHALPFGPHOF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600052E")]
	[Cpp2IlInjected.Address(RVA = "0x664AEF0", Offset = "0x664A2F0", VA = "0x18664AEF0", Slot = "7")]
	public void IFAGMNAOPKH(object BDHKJODLPCL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600052F")]
	[Cpp2IlInjected.Address(RVA = "0x664B5A0", Offset = "0x664A9A0", VA = "0x18664B5A0", Slot = "8")]
	public void ONPKKIOKJND(object BDHKJODLPCL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000530")]
	[Cpp2IlInjected.Address(RVA = "0x664A6E0", Offset = "0x6649AE0", VA = "0x18664A6E0", Slot = "9")]
	public void APMEFFJEKGL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000531")]
	[Cpp2IlInjected.Address(RVA = "0x664B3B0", Offset = "0x664A7B0", VA = "0x18664B3B0", Slot = "11")]
	public void NDJBJJBJHGC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000532")]
	[Cpp2IlInjected.Address(RVA = "0x664AA10", Offset = "0x6649E10", VA = "0x18664AA10", Slot = "12")]
	public void DBLPGDCIAIB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000533")]
	[Cpp2IlInjected.Address(RVA = "0x664AF20", Offset = "0x664A320", VA = "0x18664AF20", Slot = "10")]
	public void KCCBENMOEDJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000534")]
	[Cpp2IlInjected.Address(RVA = "0x664AD40", Offset = "0x664A140", VA = "0x18664AD40")]
	private void ELGFLDGDINF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000535")]
	[Cpp2IlInjected.Address(RVA = "0x664AB90", Offset = "0x6649F90", VA = "0x18664AB90")]
	private void ECKFMGAHGEG()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200005B")]
internal sealed class LKBCNFCBLJE : LNECPEEFLAO, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000B5")]
	private readonly AABMNPMKJNK ICFAMCDBCJP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000B6")]
	private readonly JLFBFMMGKPJ GPJKJPOMAGC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000B7")]
	private float DDLAOJAMPLO;

	[Cpp2IlInjected.Token(Token = "0x17000152")]
	public EBGPLIADLBP NPCFNCCEAJO
	{
		[Cpp2IlInjected.Token(Token = "0x6000536")]
		[Cpp2IlInjected.Address(RVA = "0x7A26F0", Offset = "0x7A1AF0", VA = "0x1807A26F0", Slot = "4")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000537")]
		[Cpp2IlInjected.Address(RVA = "0x7A26A0", Offset = "0x7A1AA0", VA = "0x1807A26A0", Slot = "5")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000153")]
	public OEEPKCKPLEL LAOMDEGHJLM
	{
		[Cpp2IlInjected.Token(Token = "0x6000538")]
		[Cpp2IlInjected.Address(RVA = "0x7A26C0", Offset = "0x7A1AC0", VA = "0x1807A26C0", Slot = "6")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000539")]
		[Cpp2IlInjected.Address(RVA = "0x7A26B0", Offset = "0x7A1AB0", VA = "0x1807A26B0", Slot = "7")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000154")]
	public Vector3 BPGONCPMPON
	{
		[Cpp2IlInjected.Token(Token = "0x600053A")]
		[Cpp2IlInjected.Address(RVA = "0x6659F10", Offset = "0x6659310", VA = "0x186659F10", Slot = "8")]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x600053B")]
		[Cpp2IlInjected.Address(RVA = "0x665C290", Offset = "0x665B690", VA = "0x18665C290", Slot = "9")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000155")]
	public Vector3 CDFFMHAADHJ
	{
		[Cpp2IlInjected.Token(Token = "0x600053C")]
		[Cpp2IlInjected.Address(RVA = "0x665BE20", Offset = "0x665B220", VA = "0x18665BE20", Slot = "10")]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x600053D")]
		[Cpp2IlInjected.Address(RVA = "0x665CB20", Offset = "0x665BF20", VA = "0x18665CB20", Slot = "11")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000156")]
	public Vector3 PPHKEOLJADG
	{
		[Cpp2IlInjected.Token(Token = "0x600053E")]
		[Cpp2IlInjected.Address(RVA = "0x665C950", Offset = "0x665BD50", VA = "0x18665C950", Slot = "12")]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x600053F")]
		[Cpp2IlInjected.Address(RVA = "0x665A320", Offset = "0x6659720", VA = "0x18665A320", Slot = "13")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000157")]
	public Vector3 ELLKJABMPJB
	{
		[Cpp2IlInjected.Token(Token = "0x6000540")]
		[Cpp2IlInjected.Address(RVA = "0x6659BC0", Offset = "0x6658FC0", VA = "0x186659BC0", Slot = "14")]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x6000541")]
		[Cpp2IlInjected.Address(RVA = "0x665AB40", Offset = "0x6659F40", VA = "0x18665AB40", Slot = "15")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000158")]
	public float ILJFFAPOBNP
	{
		[Cpp2IlInjected.Token(Token = "0x6000542")]
		[Cpp2IlInjected.Address(RVA = "0x7EC710", Offset = "0x7EBB10", VA = "0x1807EC710", Slot = "16")]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x6000543")]
		[Cpp2IlInjected.Address(RVA = "0x665B5E0", Offset = "0x665A9E0", VA = "0x18665B5E0", Slot = "17")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000159")]
	public bool OPLHKLPKLIH
	{
		[Cpp2IlInjected.Token(Token = "0x6000544")]
		[Cpp2IlInjected.Address(RVA = "0x167C930", Offset = "0x167BD30", VA = "0x18167C930", Slot = "18")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700015A")]
	private PNBKJNMIIDD GEAICDGBGCN
	{
		[Cpp2IlInjected.Token(Token = "0x6000558")]
		[Cpp2IlInjected.Address(RVA = "0x1EB20F0", Offset = "0x1EB14F0", VA = "0x181EB20F0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700015B")]
	private bool FKKBJAAELGK
	{
		[Cpp2IlInjected.Token(Token = "0x6000559")]
		[Cpp2IlInjected.Address(RVA = "0x663AAE0", Offset = "0x6639EE0", VA = "0x18663AAE0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000545")]
	[Cpp2IlInjected.Address(RVA = "0x665CBB0", Offset = "0x665BFB0", VA = "0x18665CBB0")]
	public LKBCNFCBLJE(JCOFHJBGHJA ICFAMCDBCJP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000546")]
	[Cpp2IlInjected.Address(RVA = "0x6659D80", Offset = "0x6659180", VA = "0x186659D80", Slot = "19")]
	public void AHALPFGPHOF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000547")]
	[Cpp2IlInjected.Address(RVA = "0x665AA70", Offset = "0x6659E70", VA = "0x18665AA70", Slot = "36")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000548")]
	[Cpp2IlInjected.Address(RVA = "0x6659CB0", Offset = "0x66590B0", VA = "0x186659CB0", Slot = "28")]
	public void AEMAJDMNPCO(Rigidbody ADEHOEHEFLF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000549")]
	[Cpp2IlInjected.Address(RVA = "0xB232B0", Offset = "0xB226B0", VA = "0x180B232B0", Slot = "20")]
	public void JCILIICGCJL(object BDHKJODLPCL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600054A")]
	[Cpp2IlInjected.Address(RVA = "0xB22EA0", Offset = "0xB222A0", VA = "0x180B22EA0", Slot = "30")]
	public void MPOMOMABFCM(object BDHKJODLPCL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600054B")]
	[Cpp2IlInjected.Address(RVA = "0x665B010", Offset = "0x665A410", VA = "0x18665B010", Slot = "35")]
	public Vector3 FAMKNNGPJGI(Vector3 ANEKCENIKFN)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x600054C")]
	[Cpp2IlInjected.Address(RVA = "0x665A030", Offset = "0x6659430", VA = "0x18665A030", Slot = "34")]
	public Vector3 CIMNPDLMMNF(Vector3 BNBPPNLIKAM)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x600054D")]
	[Cpp2IlInjected.Address(RVA = "0x6659D80", Offset = "0x6659180", VA = "0x186659D80", Slot = "27")]
	public void MEMDFIBKEPP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600054E")]
	[Cpp2IlInjected.Address(RVA = "0x665A3E0", Offset = "0x66597E0", VA = "0x18665A3E0", Slot = "25")]
	public void DJHDKBHIGDN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600054F")]
	[Cpp2IlInjected.Address(RVA = "0x665CB50", Offset = "0x665BF50", VA = "0x18665CB50", Slot = "24")]
	public void PNFNNMMCLFE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000550")]
	[Cpp2IlInjected.Address(RVA = "0x665A180", Offset = "0x6659580", VA = "0x18665A180", Slot = "33")]
	public void DENAIEDOENP(Vector3 FHLIJFCHIPI, Vector3 NEMLBHKHIJF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000551")]
	[Cpp2IlInjected.Address(RVA = "0x665AB70", Offset = "0x6659F70", VA = "0x18665AB70", Slot = "32")]
	public void ENOBLMIPEAC(Vector3 KAAALJHMPDH, Vector3 BFLGOPEGDDM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000552")]
	[Cpp2IlInjected.Address(RVA = "0x665C7E0", Offset = "0x665BBE0", VA = "0x18665C7E0", Slot = "31")]
	public void MPFFKLHFEMH(Vector3 HBEOKBDKAPI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000553")]
	[Cpp2IlInjected.Address(RVA = "0x665A440", Offset = "0x6659840", VA = "0x18665A440", Slot = "22")]
	public void DLGALJLLKBC(IOIMFMPPEPK JJCOMEIHIFG, Vector3 LOPBIAGCJBL, float DJHFDGIPKCO, float GJGOKKJEDGM = 8f, float KHKMMDAMJPL = 1f)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000554")]
	[Cpp2IlInjected.Address(RVA = "0x665B690", Offset = "0x665AA90", VA = "0x18665B690", Slot = "21")]
	public void FIGBACLJNDD(HGAFDACKLPM ALPAKFKNNFG, Vector3 JMPMBOKBENO, float MGEJKMAAPFM = float.PositiveInfinity)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000555")]
	[Cpp2IlInjected.Address(RVA = "0x665BA80", Offset = "0x665AE80", VA = "0x18665BA80", Slot = "23")]
	[Obsolete("Deprecated. Still exists to support deprecated CV2 chips. Use ApplyAngularVelocityChange.")]
	public void IFNPBEKLMHH(HGAFDACKLPM ALPAKFKNNFG, Vector3 IKFFGJBHBIC, float KIDOONEEGII = 7f, float HDJMHGGGNBA = 1f)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000556")]
	[Cpp2IlInjected.Address(RVA = "0x665B920", Offset = "0x665AD20", VA = "0x18665B920", Slot = "29")]
	public Vector3 IEPIAOMDAAG(Vector3 KDGFADJDBBB)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000557")]
	[Cpp2IlInjected.Address(RVA = "0x665C080", Offset = "0x665B480", VA = "0x18665C080", Slot = "26")]
	public void KJCKGCGOJBM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600055A")]
	[Cpp2IlInjected.Address(RVA = "0x665B5E0", Offset = "0x665A9E0", VA = "0x18665B5E0")]
	private void FFCMOHMCFGD(float ANJCCKHBJJO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600055B")]
	[Cpp2IlInjected.Address(RVA = "0x665BF10", Offset = "0x665B310", VA = "0x18665BF10")]
	private void KFOEODIJCBJ(Vector3 JMPMBOKBENO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600055C")]
	[Cpp2IlInjected.Address(RVA = "0x6659E30", Offset = "0x6659230", VA = "0x186659E30")]
	private Vector3 BKHKELLMDAL()
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x600055D")]
	[Cpp2IlInjected.Address(RVA = "0x665B180", Offset = "0x665A580", VA = "0x18665B180")]
	private void FCDMJMLLJII(Vector3 BNBPPNLIKAM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600055E")]
	[Cpp2IlInjected.Address(RVA = "0x665C1B0", Offset = "0x665B5B0", VA = "0x18665C1B0")]
	private Vector3 KPHJPJGFJHA()
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x600055F")]
	[Cpp2IlInjected.Address(RVA = "0x665ABD0", Offset = "0x6659FD0", VA = "0x18665ABD0")]
	private void ENONAEOFDCM(Vector3 ANJCCKHBJJO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000560")]
	[Cpp2IlInjected.Address(RVA = "0x665C350", Offset = "0x665B750", VA = "0x18665C350")]
	private void LMCDMCOFMLJ(Vector3 BNBPPNLIKAM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000561")]
	[Cpp2IlInjected.Address(RVA = "0x665CA70", Offset = "0x665BE70", VA = "0x18665CA70")]
	private void OCJMCFKJGBK()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200005C")]
public class MPAKHEBJFGH : IJKJBKAFLOD
{
	[Cpp2IlInjected.Token(Token = "0x6000562")]
	[Cpp2IlInjected.Address(RVA = "0x665CDD0", Offset = "0x665C1D0", VA = "0x18665CDD0", Slot = "4")]
	public DFEBEBBPEII EBNPOOMGDOG(JCOFHJBGHJA FBIBFNALIEI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000563")]
	[Cpp2IlInjected.Address(RVA = "0x665D150", Offset = "0x665C550", VA = "0x18665D150", Slot = "5")]
	public LNECPEEFLAO NPKBHLDACOA(JCOFHJBGHJA FBIBFNALIEI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000564")]
	[Cpp2IlInjected.Address(RVA = "0x665D090", Offset = "0x665C490", VA = "0x18665D090", Slot = "6")]
	public JJMHLHBDECD MOBLLBNBCPK(JCOFHJBGHJA FBIBFNALIEI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000565")]
	[Cpp2IlInjected.Address(RVA = "0x665D310", Offset = "0x665C710", VA = "0x18665D310", Slot = "7")]
	public LHIPGJNPCPA OMIEKPOLDKI(JCOFHJBGHJA FBIBFNALIEI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000566")]
	[Cpp2IlInjected.Address(RVA = "0x665CE90", Offset = "0x665C290", VA = "0x18665CE90", Slot = "8")]
	public OCGFIHDLMDE FNKDNGDEIEK(JCOFHJBGHJA FBIBFNALIEI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000567")]
	[Cpp2IlInjected.Address(RVA = "0x665D0F0", Offset = "0x665C4F0", VA = "0x18665D0F0", Slot = "9")]
	public NHEBLBOICHI MPKPENFLCNG(JCOFHJBGHJA FBIBFNALIEI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000568")]
	[Cpp2IlInjected.Address(RVA = "0x665D030", Offset = "0x665C430", VA = "0x18665D030", Slot = "10")]
	public FPLEKLLPLHN IMMJNPIHOJJ(JCOFHJBGHJA FBIBFNALIEI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000569")]
	[Cpp2IlInjected.Address(RVA = "0x665CF60", Offset = "0x665C360", VA = "0x18665CF60", Slot = "11")]
	public PNBKJNMIIDD IBPBDCABMKN(JCOFHJBGHJA FBIBFNALIEI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600056A")]
	[Cpp2IlInjected.Address(RVA = "0x665CC50", Offset = "0x665C050", VA = "0x18665CC50", Slot = "12")]
	public NDECPKLCGPL BPKOFLMIBEG(JCOFHJBGHJA FBIBFNALIEI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600056B")]
	[Cpp2IlInjected.Address(RVA = "0x665CE30", Offset = "0x665C230", VA = "0x18665CE30", Slot = "13")]
	public APDCPHMDBJE EDEKKNKAMCK(JCOFHJBGHJA FBIBFNALIEI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600056C")]
	[Cpp2IlInjected.Address(RVA = "0x665CEF0", Offset = "0x665C2F0", VA = "0x18665CEF0")]
	public BOKFNFEEHEN IEEKJCJAPCM(JCOFHJBGHJA FBIBFNALIEI, [In] OEDKMOJJJDN ALPLHOOHPEL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600056D")]
	[Cpp2IlInjected.Address(RVA = "0x665D230", Offset = "0x665C630", VA = "0x18665D230")]
	public NMOCGBHDPAJ OAPJLHDNABE(JCOFHJBGHJA FBIBFNALIEI, [In] OEDKMOJJJDN ALPLHOOHPEL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600056E")]
	[Cpp2IlInjected.Address(RVA = "0x665CCB0", Offset = "0x665C0B0", VA = "0x18665CCB0")]
	public BECBDCABJBI PJCBMPIGMMK(JCOFHJBGHJA FBIBFNALIEI, [In] OEDKMOJJJDN ALPLHOOHPEL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600056F")]
	[Cpp2IlInjected.Address(RVA = "0x665CFC0", Offset = "0x665C3C0", VA = "0x18665CFC0")]
	public KPKDIHHLHAL NPPPBIHCIGI(JCOFHJBGHJA FBIBFNALIEI, [In] OEDKMOJJJDN ALPLHOOHPEL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000570")]
	[Cpp2IlInjected.Address(RVA = "0x665D2A0", Offset = "0x665C6A0", VA = "0x18665D2A0")]
	public KMAFPEDBELG OCNEKCODBFB(JCOFHJBGHJA FBIBFNALIEI, [In] OEDKMOJJJDN ALPLHOOHPEL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000571")]
	[Cpp2IlInjected.Address(RVA = "0x665CD20", Offset = "0x665C120", VA = "0x18665CD20", Slot = "19")]
	public JCOFHJBGHJA DJNICONLOON(RigidbodyEx ICFAMCDBCJP, OEDKMOJJJDN ALPLHOOHPEL, FCIHFBGEFGG IALOIPDIIAG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000572")]
	[Cpp2IlInjected.Address(RVA = "0x7A2570", Offset = "0x7A1970", VA = "0x1807A2570")]
	public MPAKHEBJFGH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000573")]
	[Cpp2IlInjected.Address(RVA = "0x665CEF0", Offset = "0x665C2F0", VA = "0x18665CEF0", Slot = "14")]
	private BOKFNFEEHEN HGPCOBDALIC(JCOFHJBGHJA FBIBFNALIEI, [In] OEDKMOJJJDN ALPLHOOHPEL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000574")]
	[Cpp2IlInjected.Address(RVA = "0x665D230", Offset = "0x665C630", VA = "0x18665D230", Slot = "15")]
	private NMOCGBHDPAJ OIOILHLBFOK(JCOFHJBGHJA FBIBFNALIEI, [In] OEDKMOJJJDN ALPLHOOHPEL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000575")]
	[Cpp2IlInjected.Address(RVA = "0x665CCB0", Offset = "0x665C0B0", VA = "0x18665CCB0", Slot = "16")]
	private BECBDCABJBI CEEFJGCJJGK(JCOFHJBGHJA FBIBFNALIEI, [In] OEDKMOJJJDN ALPLHOOHPEL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000576")]
	[Cpp2IlInjected.Address(RVA = "0x665CFC0", Offset = "0x665C3C0", VA = "0x18665CFC0", Slot = "17")]
	private KPKDIHHLHAL ICJFKMGPFAM(JCOFHJBGHJA FBIBFNALIEI, [In] OEDKMOJJJDN ALPLHOOHPEL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000577")]
	[Cpp2IlInjected.Address(RVA = "0x665D2A0", Offset = "0x665C6A0", VA = "0x18665D2A0", Slot = "18")]
	private KMAFPEDBELG ODOPOLJODFD(JCOFHJBGHJA FBIBFNALIEI, [In] OEDKMOJJJDN ALPLHOOHPEL)
	{
		return null;
	}
}
namespace RRAssemblyIndex.RecRoom.Rbex.Runtime
{
	[Cpp2IlInjected.Token(Token = "0x200005D")]
	[global::RecRoom.CodeGen.Attributes.Preserve]
	internal class _RRAssemblyIndex : DMCHAMHPJDI
	{
		[Cpp2IlInjected.Token(Token = "0x6000578")]
		[Cpp2IlInjected.Address(RVA = "0x7C9520", Offset = "0x7C8920", VA = "0x1807C9520")]
		[global::RecRoom.CodeGen.Attributes.Preserve]
		public _RRAssemblyIndex()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000579")]
		[Cpp2IlInjected.Address(RVA = "0x665D370", Offset = "0x665C770", VA = "0x18665D370", Slot = "6")]
		public sealed override void MKONPADAFEN(JHICGHNGFCN KNDPECEGMIA)
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
