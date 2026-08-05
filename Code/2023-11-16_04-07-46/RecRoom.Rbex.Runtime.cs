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
public delegate void ODMKMIKDLDH(RigidbodyEx GBKPHGGGAAA);
[Cpp2IlInjected.Token(Token = "0x2000003")]
public delegate void LNHELIADCNA(RigidbodyEx GBKPHGGGAAA, bool FMNAIIPBFHC = false);
[Cpp2IlInjected.Token(Token = "0x2000004")]
public enum BOLJBMMECOE
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
public enum EHMLABBKEAD
{
	[Cpp2IlInjected.Token(Token = "0x4000007")]
	OnlyForReducedPhysicsRateAndNotParenting,
	[Cpp2IlInjected.Token(Token = "0x4000008")]
	Never,
	[Cpp2IlInjected.Token(Token = "0x4000009")]
	OnEvenWhenParenting
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public enum LGPMEMPGHMC
{
	[Cpp2IlInjected.Token(Token = "0x400000B")]
	Additive,
	[Cpp2IlInjected.Token(Token = "0x400000C")]
	Override,
	[Cpp2IlInjected.Token(Token = "0x400000D")]
	Reflective
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
[IOECDJGDPJM(typeof(OJGPFPNPOJP), new string[] { "Ignore", "Mock" })]
public class OHDIAJJPAIP : OJGPFPNPOJP
{
	[Cpp2IlInjected.Token(Token = "0x17000001")]
	public bool GJHNIDPGLGP
	{
		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x7C4710", Offset = "0x7C3710", VA = "0x1807C4710", Slot = "4")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0x770CB0", Offset = "0x76FCB0", VA = "0x180770CB0", Slot = "5")]
	public void HOLALHGAGPP(string KHEFJOIGNAL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x770CB0", Offset = "0x76FCB0", VA = "0x180770CB0", Slot = "6")]
	public void BEPIOJMLEAM(RigidbodyEx ECLMPMCOOIA, Action NFDFJOBAEPD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x770CC0", Offset = "0x76FCC0", VA = "0x180770CC0", Slot = "7")]
	public KKDEOGMNLDN DFCOMAEMJBL(int DIPELGILLDE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x770CB0", Offset = "0x76FCB0", VA = "0x180770CB0", Slot = "8")]
	public void DNCNACJKGME(Vector3 MEBEBMKNLIG, float FELOFNPGJNG, Color NGFEKFKHCIJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x7734B0", Offset = "0x7724B0", VA = "0x1807734B0")]
	public OHDIAJJPAIP()
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
		private static readonly IMFBLHALHMN IBKNCIGCHHK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000010")]
		private bool DJIHLPMHLJE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000011")]
		private EHCMNHLPJBM JPFFIECPLOL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000012")]
		[SerializeField]
		[HMKLANDBGHO(CDNIJDNCOPP.Self, false, false, false)]
		private Rigidbody unityRigidbody;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000013")]
		[HMKLANDBGHO(CDNIJDNCOPP.SelfAndParent, true, false, false)]
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
		private EHMLABBKEAD physicsInterpolation;

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
		internal EHCMNHLPJBM FHKOMFPHENB
		{
			[Cpp2IlInjected.Token(Token = "0x600000B")]
			[Cpp2IlInjected.Address(RVA = "0x6395CE0", Offset = "0x6394CE0", VA = "0x186395CE0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000003")]
		public IReadOnlyList<RigidbodyEx> FACLIONGBII
		{
			[Cpp2IlInjected.Token(Token = "0x6000021")]
			[Cpp2IlInjected.Address(RVA = "0x773900", Offset = "0x772900", VA = "0x180773900")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000022")]
			[Cpp2IlInjected.Address(RVA = "0x7738D0", Offset = "0x7728D0", VA = "0x1807738D0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000004")]
		public RigidbodyEx OEDOKGHBLPI
		{
			[Cpp2IlInjected.Token(Token = "0x6000023")]
			[Cpp2IlInjected.Address(RVA = "0x6397560", Offset = "0x6396560", VA = "0x186397560")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000005")]
		public RigidbodyEx FMAEDMDFLJE
		{
			[Cpp2IlInjected.Token(Token = "0x6000024")]
			[Cpp2IlInjected.Address(RVA = "0x63974C0", Offset = "0x63964C0", VA = "0x1863974C0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000006")]
		public RigidbodyEx IGPIMCJILMM
		{
			[Cpp2IlInjected.Token(Token = "0x6000025")]
			[Cpp2IlInjected.Address(RVA = "0x6398180", Offset = "0x6397180", VA = "0x186398180")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000026")]
			[Cpp2IlInjected.Address(RVA = "0x6399700", Offset = "0x6398700", VA = "0x186399700")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000007")]
		public Transform CMIPOFIJGHH
		{
			[Cpp2IlInjected.Token(Token = "0x6000027")]
			[Cpp2IlInjected.Address(RVA = "0x799920", Offset = "0x798920", VA = "0x180799920")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000008")]
		public Transform GCGFCFBOGAL
		{
			[Cpp2IlInjected.Token(Token = "0x6000028")]
			[Cpp2IlInjected.Address(RVA = "0x799920", Offset = "0x798920", VA = "0x180799920")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000009")]
		public NGEMNFJFDIP HJLBEPGNACN
		{
			[Cpp2IlInjected.Token(Token = "0x6000029")]
			[Cpp2IlInjected.Address(RVA = "0x6397280", Offset = "0x6396280", VA = "0x186397280")]
			get
			{
				return default(NGEMNFJFDIP);
			}
			[Cpp2IlInjected.Token(Token = "0x600002A")]
			[Cpp2IlInjected.Address(RVA = "0x6398EB0", Offset = "0x6397EB0", VA = "0x186398EB0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000A")]
		public bool GCPNKEIHNJF
		{
			[Cpp2IlInjected.Token(Token = "0x600002B")]
			[Cpp2IlInjected.Address(RVA = "0x6397810", Offset = "0x6396810", VA = "0x186397810")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000B")]
		public bool FLDOPHCHFPM
		{
			[Cpp2IlInjected.Token(Token = "0x600002C")]
			[Cpp2IlInjected.Address(RVA = "0x63973A0", Offset = "0x63963A0", VA = "0x1863973A0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000C")]
		public AFBJPJGOHAH PAKEEKMBNJI
		{
			[Cpp2IlInjected.Token(Token = "0x600002D")]
			[Cpp2IlInjected.Address(RVA = "0x6397750", Offset = "0x6396750", VA = "0x186397750")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600002E")]
			[Cpp2IlInjected.Address(RVA = "0x6399070", Offset = "0x6398070", VA = "0x186399070")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000D")]
		public GAMCJHNBHDA CONGFAJKAFK
		{
			[Cpp2IlInjected.Token(Token = "0x600002F")]
			[Cpp2IlInjected.Address(RVA = "0x63976F0", Offset = "0x63966F0", VA = "0x1863976F0")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000030")]
			[Cpp2IlInjected.Address(RVA = "0x6399000", Offset = "0x6398000", VA = "0x186399000")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000E")]
		public bool CNPBCJLHPAJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000031")]
			[Cpp2IlInjected.Address(RVA = "0x6397640", Offset = "0x6396640", VA = "0x186397640")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000F")]
		public Rigidbody JLNHKFKKICK
		{
			[Cpp2IlInjected.Token(Token = "0x6000032")]
			[Cpp2IlInjected.Address(RVA = "0x63976A0", Offset = "0x63966A0", VA = "0x1863976A0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000010")]
		public bool MIOAIPJJMGG
		{
			[Cpp2IlInjected.Token(Token = "0x6000033")]
			[Cpp2IlInjected.Address(RVA = "0x6397400", Offset = "0x6396400", VA = "0x186397400")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000034")]
			[Cpp2IlInjected.Address(RVA = "0x6398F20", Offset = "0x6397F20", VA = "0x186398F20")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000011")]
		public bool GLNENHFMGGC
		{
			[Cpp2IlInjected.Token(Token = "0x6000035")]
			[Cpp2IlInjected.Address(RVA = "0x1AE3980", Offset = "0x1AE2980", VA = "0x181AE3980")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000036")]
			[Cpp2IlInjected.Address(RVA = "0x5BDFC10", Offset = "0x5BDEC10", VA = "0x185BDFC10")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000012")]
		public float EPAALMILAGA
		{
			[Cpp2IlInjected.Token(Token = "0x6000037")]
			[Cpp2IlInjected.Address(RVA = "0x6398120", Offset = "0x6397120", VA = "0x186398120")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000013")]
		public float KFNCLGBNBOD
		{
			[Cpp2IlInjected.Token(Token = "0x6000038")]
			[Cpp2IlInjected.Address(RVA = "0x63980C0", Offset = "0x63970C0", VA = "0x1863980C0")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x6000039")]
			[Cpp2IlInjected.Address(RVA = "0x6399690", Offset = "0x6398690", VA = "0x186399690")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000014")]
		public float GPDPAMOGICI
		{
			[Cpp2IlInjected.Token(Token = "0x600003A")]
			[Cpp2IlInjected.Address(RVA = "0x6397A70", Offset = "0x6396A70", VA = "0x186397A70")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x600003B")]
			[Cpp2IlInjected.Address(RVA = "0x6399310", Offset = "0x6398310", VA = "0x186399310")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000015")]
		public float GOICHLNLLIC
		{
			[Cpp2IlInjected.Token(Token = "0x600003C")]
			[Cpp2IlInjected.Address(RVA = "0x6397870", Offset = "0x6396870", VA = "0x186397870")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x600003D")]
			[Cpp2IlInjected.Address(RVA = "0x63990E0", Offset = "0x63980E0", VA = "0x1863990E0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000016")]
		public bool BLJLGNEIKBN
		{
			[Cpp2IlInjected.Token(Token = "0x600003E")]
			[Cpp2IlInjected.Address(RVA = "0x63986E0", Offset = "0x63976E0", VA = "0x1863986E0")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x600003F")]
			[Cpp2IlInjected.Address(RVA = "0x6399C60", Offset = "0x6398C60", VA = "0x186399C60")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000017")]
		public Vector3 OJIADJOKMGD
		{
			[Cpp2IlInjected.Token(Token = "0x6000040")]
			[Cpp2IlInjected.Address(RVA = "0x6397EA0", Offset = "0x6396EA0", VA = "0x186397EA0")]
			get
			{
				return default(Vector3);
			}
			[Cpp2IlInjected.Token(Token = "0x6000041")]
			[Cpp2IlInjected.Address(RVA = "0x6399460", Offset = "0x6398460", VA = "0x186399460")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000018")]
		public Vector3 MEBEBMKNLIG
		{
			[Cpp2IlInjected.Token(Token = "0x6000042")]
			[Cpp2IlInjected.Address(RVA = "0x6398820", Offset = "0x6397820", VA = "0x186398820")]
			get
			{
				return default(Vector3);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000019")]
		public CollisionDetectionMode DCNDNANGKFB
		{
			[Cpp2IlInjected.Token(Token = "0x6000043")]
			[Cpp2IlInjected.Address(RVA = "0x63979B0", Offset = "0x63969B0", VA = "0x1863979B0")]
			get
			{
				return default(CollisionDetectionMode);
			}
			[Cpp2IlInjected.Token(Token = "0x6000044")]
			[Cpp2IlInjected.Address(RVA = "0x6399230", Offset = "0x6398230", VA = "0x186399230")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001A")]
		public float CEJDFPIKKNH
		{
			[Cpp2IlInjected.Token(Token = "0x6000045")]
			[Cpp2IlInjected.Address(RVA = "0x6397460", Offset = "0x6396460", VA = "0x186397460")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x6000046")]
			[Cpp2IlInjected.Address(RVA = "0x6398F90", Offset = "0x6397F90", VA = "0x186398F90")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001B")]
		public RigidbodyConstraints NAKNPLKLHCP
		{
			[Cpp2IlInjected.Token(Token = "0x6000047")]
			[Cpp2IlInjected.Address(RVA = "0x6397A10", Offset = "0x6396A10", VA = "0x186397A10")]
			get
			{
				return default(RigidbodyConstraints);
			}
			[Cpp2IlInjected.Token(Token = "0x6000048")]
			[Cpp2IlInjected.Address(RVA = "0x63992A0", Offset = "0x63982A0", VA = "0x1863992A0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001C")]
		public Vector3 IHEHKJMPLIB
		{
			[Cpp2IlInjected.Token(Token = "0x6000049")]
			[Cpp2IlInjected.Address(RVA = "0x6398220", Offset = "0x6397220", VA = "0x186398220")]
			get
			{
				return default(Vector3);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001D")]
		public Vector3 AMLBKMFOEOP
		{
			[Cpp2IlInjected.Token(Token = "0x600004A")]
			[Cpp2IlInjected.Address(RVA = "0x6398220", Offset = "0x6397220", VA = "0x186398220")]
			get
			{
				return default(Vector3);
			}
			[Cpp2IlInjected.Token(Token = "0x600004B")]
			[Cpp2IlInjected.Address(RVA = "0x6399A40", Offset = "0x6398A40", VA = "0x186399A40")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001E")]
		public float LCAFNBOHFDC
		{
			[Cpp2IlInjected.Token(Token = "0x600004C")]
			[Cpp2IlInjected.Address(RVA = "0x6397F80", Offset = "0x6396F80", VA = "0x186397F80")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x600004D")]
			[Cpp2IlInjected.Address(RVA = "0x6399540", Offset = "0x6398540", VA = "0x186399540")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001F")]
		public float EKOCKGNEAON
		{
			[Cpp2IlInjected.Token(Token = "0x600004E")]
			[Cpp2IlInjected.Address(RVA = "0x6398680", Offset = "0x6397680", VA = "0x186398680")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x600004F")]
			[Cpp2IlInjected.Address(RVA = "0x6399BF0", Offset = "0x6398BF0", VA = "0x186399BF0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000020")]
		public Quaternion DPOMADPCJGD
		{
			[Cpp2IlInjected.Token(Token = "0x6000050")]
			[Cpp2IlInjected.Address(RVA = "0x6398300", Offset = "0x6397300", VA = "0x186398300")]
			get
			{
				return default(Quaternion);
			}
			[Cpp2IlInjected.Token(Token = "0x6000051")]
			[Cpp2IlInjected.Address(RVA = "0x63997C0", Offset = "0x63987C0", VA = "0x1863997C0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000021")]
		public Quaternion DEEPDBFJCIB
		{
			[Cpp2IlInjected.Token(Token = "0x6000052")]
			[Cpp2IlInjected.Address(RVA = "0x63985A0", Offset = "0x63975A0", VA = "0x1863985A0")]
			get
			{
				return default(Quaternion);
			}
			[Cpp2IlInjected.Token(Token = "0x6000053")]
			[Cpp2IlInjected.Address(RVA = "0x6399B20", Offset = "0x6398B20", VA = "0x186399B20")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000022")]
		public Vector3 LOIJHIJJMHL
		{
			[Cpp2IlInjected.Token(Token = "0x6000054")]
			[Cpp2IlInjected.Address(RVA = "0x63983E0", Offset = "0x63973E0", VA = "0x1863983E0")]
			get
			{
				return default(Vector3);
			}
			[Cpp2IlInjected.Token(Token = "0x6000055")]
			[Cpp2IlInjected.Address(RVA = "0x6399890", Offset = "0x6398890", VA = "0x186399890")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000023")]
		public Quaternion OLIFLEAGPHE
		{
			[Cpp2IlInjected.Token(Token = "0x6000056")]
			[Cpp2IlInjected.Address(RVA = "0x63984C0", Offset = "0x63974C0", VA = "0x1863984C0")]
			get
			{
				return default(Quaternion);
			}
			[Cpp2IlInjected.Token(Token = "0x6000057")]
			[Cpp2IlInjected.Address(RVA = "0x6399970", Offset = "0x6398970", VA = "0x186399970")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000024")]
		public Vector3 OBNDDJFFKOO
		{
			[Cpp2IlInjected.Token(Token = "0x6000058")]
			[Cpp2IlInjected.Address(RVA = "0x6398740", Offset = "0x6397740", VA = "0x186398740")]
			get
			{
				return default(Vector3);
			}
			[Cpp2IlInjected.Token(Token = "0x6000059")]
			[Cpp2IlInjected.Address(RVA = "0x6399CD0", Offset = "0x6398CD0", VA = "0x186399CD0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000025")]
		public Vector3 GMLDNFHDNJP
		{
			[Cpp2IlInjected.Token(Token = "0x600005A")]
			[Cpp2IlInjected.Address(RVA = "0x6397FE0", Offset = "0x6396FE0", VA = "0x186397FE0")]
			get
			{
				return default(Vector3);
			}
			[Cpp2IlInjected.Token(Token = "0x600005B")]
			[Cpp2IlInjected.Address(RVA = "0x63995B0", Offset = "0x63985B0", VA = "0x1863995B0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000026")]
		public Vector3 DHDAKHKKKMH
		{
			[Cpp2IlInjected.Token(Token = "0x600005C")]
			[Cpp2IlInjected.Address(RVA = "0x63978D0", Offset = "0x63968D0", VA = "0x1863978D0")]
			get
			{
				return default(Vector3);
			}
			[Cpp2IlInjected.Token(Token = "0x600005D")]
			[Cpp2IlInjected.Address(RVA = "0x6399150", Offset = "0x6398150", VA = "0x186399150")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000027")]
		public Vector3 PLLAPIPLOBE
		{
			[Cpp2IlInjected.Token(Token = "0x600005E")]
			[Cpp2IlInjected.Address(RVA = "0x6397DC0", Offset = "0x6396DC0", VA = "0x186397DC0")]
			get
			{
				return default(Vector3);
			}
			[Cpp2IlInjected.Token(Token = "0x600005F")]
			[Cpp2IlInjected.Address(RVA = "0x6399380", Offset = "0x6398380", VA = "0x186399380")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000028")]
		public Vector3 DKDKNIAGBLF
		{
			[Cpp2IlInjected.Token(Token = "0x6000060")]
			[Cpp2IlInjected.Address(RVA = "0x6397C80", Offset = "0x6396C80", VA = "0x186397C80")]
			get
			{
				return default(Vector3);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000029")]
		public Quaternion BKGKJEEAOPJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000061")]
			[Cpp2IlInjected.Address(RVA = "0x6397BA0", Offset = "0x6396BA0", VA = "0x186397BA0")]
			get
			{
				return default(Quaternion);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002A")]
		public Vector3 NPCAKOAOPHO
		{
			[Cpp2IlInjected.Token(Token = "0x6000063")]
			[Cpp2IlInjected.Address(RVA = "0x63989E0", Offset = "0x63979E0", VA = "0x1863989E0")]
			get
			{
				return default(Vector3);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002B")]
		public Vector3 KJMFINMBAJM
		{
			[Cpp2IlInjected.Token(Token = "0x6000064")]
			[Cpp2IlInjected.Address(RVA = "0x6398900", Offset = "0x6397900", VA = "0x186398900")]
			get
			{
				return default(Vector3);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002C")]
		public bool NGGMOCIINFJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000065")]
			[Cpp2IlInjected.Address(RVA = "0x6397D60", Offset = "0x6396D60", VA = "0x186397D60")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002D")]
		public bool JEPMPAKBHKE
		{
			[Cpp2IlInjected.Token(Token = "0x6000066")]
			[Cpp2IlInjected.Address(RVA = "0x63977B0", Offset = "0x63967B0", VA = "0x1863977B0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002E")]
		public bool APIOHOECOHN
		{
			[Cpp2IlInjected.Token(Token = "0x6000067")]
			[Cpp2IlInjected.Address(RVA = "0x6397340", Offset = "0x6396340", VA = "0x186397340")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002F")]
		public bool CPKNHGNOJKA
		{
			[Cpp2IlInjected.Token(Token = "0x6000068")]
			[Cpp2IlInjected.Address(RVA = "0x63972E0", Offset = "0x63962E0", VA = "0x1863972E0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000030")]
		public bool OPNOHLFFIJB
		{
			[Cpp2IlInjected.Token(Token = "0x6000069")]
			[Cpp2IlInjected.Address(RVA = "0x6397220", Offset = "0x6396220", VA = "0x186397220")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000031")]
		public bool IEKCKCPMCED
		{
			[Cpp2IlInjected.Token(Token = "0x600006A")]
			[Cpp2IlInjected.Address(RVA = "0x6397AD0", Offset = "0x6396AD0", VA = "0x186397AD0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000032")]
		public bool NPPHNPBCGHD
		{
			[Cpp2IlInjected.Token(Token = "0x600006B")]
			[Cpp2IlInjected.Address(RVA = "0x4FAB640", Offset = "0x4FAA640", VA = "0x184FAB640")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000001")]
		public event ODMKMIKDLDH DKGKACJPKCH
		{
			[Cpp2IlInjected.Token(Token = "0x600000F")]
			[Cpp2IlInjected.Address(RVA = "0x6397140", Offset = "0x6396140", VA = "0x186397140")]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000010")]
			[Cpp2IlInjected.Address(RVA = "0x6398DD0", Offset = "0x6397DD0", VA = "0x186398DD0")]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000002")]
		public event LNHELIADCNA IMHLGBGAMLB
		{
			[Cpp2IlInjected.Token(Token = "0x6000011")]
			[Cpp2IlInjected.Address(RVA = "0x63970D0", Offset = "0x63960D0", VA = "0x1863970D0")]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000012")]
			[Cpp2IlInjected.Address(RVA = "0x6398D60", Offset = "0x6397D60", VA = "0x186398D60")]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000003")]
		public event ODMKMIKDLDH HNIODPCALEE
		{
			[Cpp2IlInjected.Token(Token = "0x6000013")]
			[Cpp2IlInjected.Address(RVA = "0x6396E30", Offset = "0x6395E30", VA = "0x186396E30")]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000014")]
			[Cpp2IlInjected.Address(RVA = "0x6398AC0", Offset = "0x6397AC0", VA = "0x186398AC0")]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000004")]
		public event ODMKMIKDLDH ICDJPNDLGPD
		{
			[Cpp2IlInjected.Token(Token = "0x6000015")]
			[Cpp2IlInjected.Address(RVA = "0x6396EA0", Offset = "0x6395EA0", VA = "0x186396EA0")]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000016")]
			[Cpp2IlInjected.Address(RVA = "0x6398B30", Offset = "0x6397B30", VA = "0x186398B30")]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000005")]
		public event ODMKMIKDLDH GFDLDDIJKHF
		{
			[Cpp2IlInjected.Token(Token = "0x6000017")]
			[Cpp2IlInjected.Address(RVA = "0x6396FF0", Offset = "0x6395FF0", VA = "0x186396FF0")]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000018")]
			[Cpp2IlInjected.Address(RVA = "0x6398C80", Offset = "0x6397C80", VA = "0x186398C80")]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000006")]
		public event Action<FDHMLINJMLJ, FDHMLINJMLJ> IOALOLNJHBM
		{
			[Cpp2IlInjected.Token(Token = "0x6000019")]
			[Cpp2IlInjected.Address(RVA = "0x6396F80", Offset = "0x6395F80", VA = "0x186396F80")]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x600001A")]
			[Cpp2IlInjected.Address(RVA = "0x6398C10", Offset = "0x6397C10", VA = "0x186398C10")]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000007")]
		public event ODMKMIKDLDH IOIFGKBDICH
		{
			[Cpp2IlInjected.Token(Token = "0x600001B")]
			[Cpp2IlInjected.Address(RVA = "0x6397060", Offset = "0x6396060", VA = "0x186397060")]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x600001C")]
			[Cpp2IlInjected.Address(RVA = "0x6398CF0", Offset = "0x6397CF0", VA = "0x186398CF0")]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000008")]
		public event ODMKMIKDLDH JHBDFDGODOF
		{
			[Cpp2IlInjected.Token(Token = "0x600001D")]
			[Cpp2IlInjected.Address(RVA = "0x63971B0", Offset = "0x63961B0", VA = "0x1863971B0")]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x600001E")]
			[Cpp2IlInjected.Address(RVA = "0x6398E40", Offset = "0x6397E40", VA = "0x186398E40")]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000009")]
		public event ODMKMIKDLDH EKOMCGBKAOG
		{
			[Cpp2IlInjected.Token(Token = "0x600001F")]
			[Cpp2IlInjected.Address(RVA = "0x6396F10", Offset = "0x6395F10", VA = "0x186396F10")]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000020")]
			[Cpp2IlInjected.Address(RVA = "0x6398BA0", Offset = "0x6397BA0", VA = "0x186398BA0")]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x76F1E0", Offset = "0x76E1E0", VA = "0x18076F1E0")]
		internal void APNHENKPMBE(EHCMNHLPJBM KKOFNCEIKDA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x6395EA0", Offset = "0x6394EA0", VA = "0x186395EA0")]
		internal void MGDPNHOCDHB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x6396B50", Offset = "0x6395B50", VA = "0x186396B50")]
		[Conditional("DEBUG_BUILD")]
		[Conditional("UNITY_EDITOR")]
		public void TestOverrideUnityRigidbody(Rigidbody CJFMHPILPMK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000062")]
		[Cpp2IlInjected.Address(RVA = "0x6396820", Offset = "0x6395820", VA = "0x186396820")]
		public void SetInertiaTensor((Quaternion rot, Vector3 moments) IJPGGILEIIN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006C")]
		[Cpp2IlInjected.Address(RVA = "0x6395260", Offset = "0x6394260", VA = "0x186395260")]
		private void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006D")]
		[Cpp2IlInjected.Address(RVA = "0x6395CE0", Offset = "0x6394CE0", VA = "0x186395CE0")]
		private EHCMNHLPJBM KLIDPKDPNAM()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600006E")]
		[Cpp2IlInjected.Address(RVA = "0x6395330", Offset = "0x6394330", VA = "0x186395330")]
		private void CAFOKCFCPFO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006F")]
		[Cpp2IlInjected.Address(RVA = "0x6395FF0", Offset = "0x6394FF0", VA = "0x186395FF0")]
		private void OnEnable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000070")]
		[Cpp2IlInjected.Address(RVA = "0x770CB0", Offset = "0x76FCB0", VA = "0x180770CB0")]
		public void OnDisable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000071")]
		[Cpp2IlInjected.Address(RVA = "0x6395EA0", Offset = "0x6394EA0", VA = "0x186395EA0")]
		private void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000072")]
		[Cpp2IlInjected.Address(RVA = "0x6395F90", Offset = "0x6394F90", VA = "0x186395F90")]
		private void OnDrawGizmosSelected()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000073")]
		[Cpp2IlInjected.Address(RVA = "0x6396050", Offset = "0x6395050", VA = "0x186396050")]
		private void OnValidate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000074")]
		[Cpp2IlInjected.Address(RVA = "0x6394910", Offset = "0x6393910", VA = "0x186394910")]
		public void AddDoNotResetVelocityOnOwnershipChangeOverride(object PDIBILKHEBM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000075")]
		[Cpp2IlInjected.Address(RVA = "0x63960B0", Offset = "0x63950B0", VA = "0x1863960B0")]
		public void RemoveDoNotResetVelocityOnOwnershipChangeOverride(object PDIBILKHEBM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000076")]
		[Cpp2IlInjected.Address(RVA = "0x6395840", Offset = "0x6394840", VA = "0x186395840")]
		public void DisableCachedInertialPropertyOverride()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000077")]
		[Cpp2IlInjected.Address(RVA = "0x6395F30", Offset = "0x6394F30", VA = "0x186395F30")]
		public void MarkCachedInertialParametersDirty()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000078")]
		[Cpp2IlInjected.Address(RVA = "0x6396980", Offset = "0x6395980", VA = "0x186396980")]
		public void SetParent(RigidbodyEx APPJEOKOGAK, bool FMNAIIPBFHC = false)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000079")]
		[Cpp2IlInjected.Address(RVA = "0x63963C0", Offset = "0x63953C0", VA = "0x1863963C0")]
		public void ResetLocalCenterOfMassToPrefabDefault()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007A")]
		[Cpp2IlInjected.Address(RVA = "0x6395AC0", Offset = "0x6394AC0", VA = "0x186395AC0")]
		public bool IsRigidbodyAncestor(RigidbodyEx BAFBAAPFNBC)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600007B")]
		[Cpp2IlInjected.Address(RVA = "0x6395BA0", Offset = "0x6394BA0", VA = "0x186395BA0")]
		public bool IsRigidbodyDescendant(RigidbodyEx IPFACJGLCKI)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600007C")]
		[Cpp2IlInjected.Address(RVA = "0x6394B80", Offset = "0x6393B80", VA = "0x186394B80")]
		public void AddInterpolationRestriction(object PDIBILKHEBM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007D")]
		[Cpp2IlInjected.Address(RVA = "0x6396120", Offset = "0x6395120", VA = "0x186396120")]
		public void RemoveInterpolationRestriction(object PDIBILKHEBM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007E")]
		[Cpp2IlInjected.Address(RVA = "0x63952D0", Offset = "0x63942D0", VA = "0x1863952D0")]
		public IDisposable BeginKinematicScope()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600007F")]
		[Cpp2IlInjected.Address(RVA = "0x6394BF0", Offset = "0x6393BF0", VA = "0x186394BF0")]
		public void AddKinematic(object PDIBILKHEBM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000080")]
		[Cpp2IlInjected.Address(RVA = "0x6396190", Offset = "0x6395190", VA = "0x186396190")]
		public void RemoveKinematic(object PDIBILKHEBM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000081")]
		[Cpp2IlInjected.Address(RVA = "0x6396900", Offset = "0x6395900", VA = "0x186396900")]
		public void SetKinematic(object PDIBILKHEBM, bool GKHMPKCJGHP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000082")]
		[Cpp2IlInjected.Address(RVA = "0x6396720", Offset = "0x6395720", VA = "0x186396720")]
		public void SetDiscontinuousPositionAndRotation(Vector3 LMCNGGBBGAK, Quaternion LJGGLNEHBNN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000083")]
		[Cpp2IlInjected.Address(RVA = "0x6396620", Offset = "0x6395620", VA = "0x186396620")]
		public void SetDiscontinuousLocalPositionAndLocalRotation(Vector3 AGFHJEELBOM, Quaternion DBJKCMEGHMK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000084")]
		[Cpp2IlInjected.Address(RVA = "0x63959B0", Offset = "0x63949B0", VA = "0x1863959B0")]
		public Vector3 GetConstrainedVelocity(Vector3 OBNDDJFFKOO)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x6000085")]
		[Cpp2IlInjected.Address(RVA = "0x63958A0", Offset = "0x63948A0", VA = "0x1863958A0")]
		public Vector3 GetConstrainedAngularVelocity(Vector3 DHDAKHKKKMH)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x6000086")]
		[Cpp2IlInjected.Address(RVA = "0x6394A90", Offset = "0x6393A90", VA = "0x186394A90")]
		public void AddForce(Vector3 OFOIDDLLFEI, ForceMode OJEDHHILKEL = ForceMode.Force)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000087")]
		[Cpp2IlInjected.Address(RVA = "0x6394980", Offset = "0x6393980", VA = "0x186394980")]
		public void AddForceAtPosition(Vector3 OFOIDDLLFEI, Vector3 LPGLCEHEHMC, ForceMode OJEDHHILKEL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000088")]
		[Cpp2IlInjected.Address(RVA = "0x6394DC0", Offset = "0x6393DC0", VA = "0x186394DC0")]
		public void AddTorque(Vector3 LGKLDHJLFFC, ForceMode OJEDHHILKEL = ForceMode.Force)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000089")]
		[Cpp2IlInjected.Address(RVA = "0x6394C60", Offset = "0x6393C60", VA = "0x186394C60")]
		public void AddRelativeTorque(Vector3 LGKLDHJLFFC, ForceMode OJEDHHILKEL = ForceMode.Force)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008A")]
		[Cpp2IlInjected.Address(RVA = "0x6396C20", Offset = "0x6395C20", VA = "0x186396C20")]
		public Vector3 WorldToLocalVelocity(Vector3 IACNFCFIIOM)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x600008B")]
		[Cpp2IlInjected.Address(RVA = "0x6395D90", Offset = "0x6394D90", VA = "0x186395D90")]
		public Vector3 LocalToWorldVelocity(Vector3 GMLDNFHDNJP)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x600008C")]
		[Cpp2IlInjected.Address(RVA = "0x63957E0", Offset = "0x63947E0", VA = "0x1863957E0")]
		public void ClearVelocity()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008D")]
		[Cpp2IlInjected.Address(RVA = "0x6395780", Offset = "0x6394780", VA = "0x186395780")]
		public void ClearUnityRigidbodyVelocity()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008E")]
		[Cpp2IlInjected.Address(RVA = "0x6395720", Offset = "0x6394720", VA = "0x186395720")]
		public void ClearLinearVelocity()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008F")]
		[Cpp2IlInjected.Address(RVA = "0x63956C0", Offset = "0x63946C0", VA = "0x1863956C0")]
		public void ClearAngularVelocity()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000090")]
		[Cpp2IlInjected.Address(RVA = "0x6396520", Offset = "0x6395520", VA = "0x186396520")]
		public void ResetVelocityWorldSpace(Vector3 PFBOCMNHECB, Vector3 EGGKDKAICGO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000091")]
		[Cpp2IlInjected.Address(RVA = "0x6396420", Offset = "0x6395420", VA = "0x186396420")]
		public void ResetVelocityLocalSpace(Vector3 ACIPBFHCAAA, Vector3 PLLAPIPLOBE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000092")]
		[Cpp2IlInjected.Address(RVA = "0x63962E0", Offset = "0x63952E0", VA = "0x1863962E0")]
		public void ResetLinearVelocityLocalSpace(Vector3 ACIPBFHCAAA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000093")]
		[Cpp2IlInjected.Address(RVA = "0x6396AB0", Offset = "0x6395AB0", VA = "0x186396AB0")]
		public bool SweepTest(Vector3 AKNDOLIKNGM, [Out] RaycastHit MGAKEPJNIDG, float IBOJBDBEJBJ)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000094")]
		[Cpp2IlInjected.Address(RVA = "0x6395C80", Offset = "0x6394C80", VA = "0x186395C80")]
		public bool IsSleeping()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000095")]
		[Cpp2IlInjected.Address(RVA = "0x6396A50", Offset = "0x6395A50", VA = "0x186396A50")]
		public void Sleep()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000096")]
		[Cpp2IlInjected.Address(RVA = "0x6396BC0", Offset = "0x6395BC0", VA = "0x186396BC0")]
		public void WakeUp()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000097")]
		[Cpp2IlInjected.Address(RVA = "0x6394D50", Offset = "0x6393D50", VA = "0x186394D50")]
		public void AddShouldHaveUnityRigidbodyToken(object PDIBILKHEBM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000098")]
		[Cpp2IlInjected.Address(RVA = "0x6396200", Offset = "0x6395200", VA = "0x186396200")]
		public void RemoveShouldHaveUnityRigidbodyToken(object PDIBILKHEBM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000099")]
		[Cpp2IlInjected.Address(RVA = "0x63950F0", Offset = "0x63940F0", VA = "0x1863950F0")]
		public void ApplyForceVelocityChange(BOLJBMMECOE DBGBHNOCNJE, Vector3 HGEDCNMOIAN, float NBBOEEPKJMP, float MFOFCNBGOEE = 8f, float JKNAHEBOBHM = 1f)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009A")]
		[Cpp2IlInjected.Address(RVA = "0x6395050", Offset = "0x6394050", VA = "0x186395050")]
		public void ApplyAngularVelocityChange(LGPMEMPGHMC CFIODOIHFKI, Vector3 POKFEHNNFOH, float NLCECILHIIF = float.PositiveInfinity)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009B")]
		[Cpp2IlInjected.Address(RVA = "0x63951B0", Offset = "0x63941B0", VA = "0x1863951B0")]
		[Obsolete("Deprecated. Still exists to support deprecated CV2 chips. Use ApplyAngularVelocityChange.")]
		public void ApplyTorqueAngularVelocityChangeDeprecated(LGPMEMPGHMC CFIODOIHFKI, Vector3 LGOFCBEILGM, float DPKKDMEAKFE = 7f, float DLNPOBOGDPN = 1f)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009C")]
		[Cpp2IlInjected.Address(RVA = "0x6394F80", Offset = "0x6393F80", VA = "0x186394F80")]
		public bool AllowedScaleChange(float MGEAGKCABGB)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600009D")]
		[Cpp2IlInjected.Address(RVA = "0x6394EB0", Offset = "0x6393EB0", VA = "0x186394EB0")]
		public void AddWorldSpaceVelocityInHierarchyParentOverride(RigidbodyEx OHPBKIJPBEH, object PDIBILKHEBM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009E")]
		[Cpp2IlInjected.Address(RVA = "0x6396270", Offset = "0x6395270", VA = "0x186396270")]
		public void RemoveWorldSpaceVelocityInHierarchyParentOverride(object PDIBILKHEBM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009F")]
		[Cpp2IlInjected.Address(RVA = "0x6396DC0", Offset = "0x6395DC0", VA = "0x186396DC0")]
		public RigidbodyEx()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
internal static class MLAEOKKKLLI
{
	[Cpp2IlInjected.Token(Token = "0x60000A4")]
	[Cpp2IlInjected.Address(RVA = "0x638D3F0", Offset = "0x638C3F0", VA = "0x18638D3F0")]
	public static EHCMNHLPJBM FHKOMFPHENB(this RigidbodyEx ECLMPMCOOIA)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
public struct OJNOICCBOJO
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001D")]
	public Rigidbody IOJJIGGDNPN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x400001E")]
	public PhotonView EEKACCEEHIJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400001F")]
	public OverridableVector3 CHELGPEFPDH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000020")]
	public OverridableVector3 JJBJOBIPOGE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000021")]
	public EHMLABBKEAD MEJOPMNLIME;

	[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
	[Cpp2IlInjected.Token(Token = "0x4000022")]
	public bool LCOAOBBJDKL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x35")]
	[Cpp2IlInjected.Token(Token = "0x4000023")]
	public bool NFDJACHBMEE;
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
[IOECDJGDPJM(typeof(IDMHNKCBNME), new string[] { })]
public class DJNOAOCJFJC : IDMHNKCBNME, LFEOMOKILLA
{
	[Cpp2IlInjected.Token(Token = "0x4000024")]
	private static readonly IMFBLHALHMN DJHKLFMABMI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000025")]
	private GKPBFOGMNNB CPKPNGNNIFI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000026")]
	private OJGPFPNPOJP ICCKKADELMP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000027")]
	private CKFHDMFFLAC KJDENPKCIMD;

	[Cpp2IlInjected.Token(Token = "0x17000033")]
	public OJGPFPNPOJP DAKHMKMAHKD
	{
		[Cpp2IlInjected.Token(Token = "0x60000A5")]
		[Cpp2IlInjected.Address(RVA = "0x76F210", Offset = "0x76E210", VA = "0x18076F210", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000034")]
	public CKFHDMFFLAC MIMDCAHINPD
	{
		[Cpp2IlInjected.Token(Token = "0x60000A6")]
		[Cpp2IlInjected.Address(RVA = "0x76F1F0", Offset = "0x76E1F0", VA = "0x18076F1F0", Slot = "5")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000A7")]
	[Cpp2IlInjected.Address(RVA = "0x6373E80", Offset = "0x6372E80", VA = "0x186373E80", Slot = "8")]
	public void InitReferences(MKDBPFPJIJD HCKKNCPHDMK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A8")]
	[Cpp2IlInjected.Address(RVA = "0x6373BD0", Offset = "0x6372BD0", VA = "0x186373BD0", Slot = "6")]
	public DALFLBHIMAN INIIPBADBIF(RigidbodyEx ECLMPMCOOIA)
	{
		return default(DALFLBHIMAN);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A9")]
	[Cpp2IlInjected.Address(RVA = "0x6373B00", Offset = "0x6372B00", VA = "0x186373B00")]
	private static DALFLBHIMAN FFLGMCPKKIN(RigidbodyEx ECLMPMCOOIA)
	{
		return default(DALFLBHIMAN);
	}

	[Cpp2IlInjected.Token(Token = "0x60000AA")]
	[Cpp2IlInjected.Address(RVA = "0x6373F10", Offset = "0x6372F10", VA = "0x186373F10", Slot = "7")]
	public EHCMNHLPJBM LGLNIFFDNHL(RigidbodyEx ECLMPMCOOIA, OJNOICCBOJO FCLEEDACIMH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000AB")]
	[Cpp2IlInjected.Address(RVA = "0x7734B0", Offset = "0x7724B0", VA = "0x1807734B0")]
	public DJNOAOCJFJC()
	{
	}
}
namespace RecRoom
{
	[Cpp2IlInjected.Token(Token = "0x200000D")]
	public class PhysicsManager : SingletonMonoBehaviour<PhysicsManager>
	{
		[Cpp2IlInjected.Token(Token = "0x4000028")]
		public static DNHICBJBOMM UpdateAfterFixedUpdateRan;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000029")]
		private int BPEAPBJBMCG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x400002A")]
		private int PCENLLONEJG;

		[Cpp2IlInjected.Token(Token = "0x60000AD")]
		[Cpp2IlInjected.Address(RVA = "0x6394770", Offset = "0x6393770", VA = "0x186394770")]
		protected void FixedUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AE")]
		[Cpp2IlInjected.Address(RVA = "0x63947B0", Offset = "0x63937B0", VA = "0x1863947B0")]
		protected void Update()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AF")]
		[Cpp2IlInjected.Address(RVA = "0x6394790", Offset = "0x6393790", VA = "0x186394790")]
		protected void LateUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B0")]
		[Cpp2IlInjected.Address(RVA = "0x770CB0", Offset = "0x76FCB0", VA = "0x180770CB0")]
		[Conditional("UNITY_ASSERTIONS")]
		public void AssertLateColliderPositionsNotYetUpdated([Optional] string NCBOINMNCHO, [Optional] UnityEngine.Object ACJODAOHIHK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B1")]
		[Cpp2IlInjected.Address(RVA = "0x770CB0", Offset = "0x76FCB0", VA = "0x180770CB0")]
		[Conditional("UNITY_ASSERTIONS")]
		public void AssertLateColliderPositionsAlreadyUpdated([Optional] string NCBOINMNCHO, [Optional] UnityEngine.Object ACJODAOHIHK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B2")]
		[Cpp2IlInjected.Address(RVA = "0x63948C0", Offset = "0x63938C0", VA = "0x1863948C0")]
		public PhysicsManager()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
public static class HBFPOCAFOCC
{
	[Cpp2IlInjected.Token(Token = "0x60000B4")]
	[Cpp2IlInjected.Address(RVA = "0x637E9C0", Offset = "0x637D9C0", VA = "0x18637E9C0")]
	public static void CGFOLFKIEIP(this Rigidbody CJFMHPILPMK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B5")]
	[Cpp2IlInjected.Address(RVA = "0x637EB50", Offset = "0x637DB50", VA = "0x18637EB50")]
	public static void CGFOLFKIEIP(this Rigidbody CJFMHPILPMK, Vector3 KGNFMIHKPHP, Quaternion BKGKJEEAOPJ, Vector3 DLAIBCLDGGM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B6")]
	[Cpp2IlInjected.Address(RVA = "0xBAD8E0", Offset = "0xBAC8E0", VA = "0x180BAD8E0")]
	public static void OJJPINOKJJC(Vector3 OBNDDJFFKOO, Vector3 IPOPAPIAACP, [Out] Vector3 IPJEOGHNJKA, [Out] Vector3 CCPNOOEGLIN)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000F")]
public static class GPJOFDLNBHE
{
	[Cpp2IlInjected.Token(Token = "0x2000010")]
	private class IFBAEBFMCPI : AFBJPJGOHAH, IDisposable
	{
		[Cpp2IlInjected.Token(Token = "0x60000B9")]
		[Cpp2IlInjected.Address(RVA = "0x770CB0", Offset = "0x76FCB0", VA = "0x180770CB0", Slot = "6")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000BA")]
		[Cpp2IlInjected.Address(RVA = "0x780990", Offset = "0x77F990", VA = "0x180780990", Slot = "4")]
		public Vector3 BBCOFJMDGGI()
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x60000BB")]
		[Cpp2IlInjected.Address(RVA = "0x780990", Offset = "0x77F990", VA = "0x180780990", Slot = "5")]
		public Vector3 OGOHBLJNEHM()
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x60000BC")]
		[Cpp2IlInjected.Address(RVA = "0x7734B0", Offset = "0x7724B0", VA = "0x1807734B0")]
		public IFBAEBFMCPI()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000035")]
	public static AFBJPJGOHAH BAPLHGKNOGE
	{
		[Cpp2IlInjected.Token(Token = "0x60000B7")]
		[Cpp2IlInjected.Address(RVA = "0x637E6B0", Offset = "0x637D6B0", VA = "0x18637E6B0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
public interface AOENHBHLFIE
{
	[Cpp2IlInjected.Token(Token = "0x17000036")]
	CollisionDetectionMode MHGBGHOHCOK
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
	void NPFDHKEDPBK();

	[Cpp2IlInjected.Token(Token = "0x60000C0")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void ABGJLAGAKOI(bool NGGMOCIINFJ);

	[Cpp2IlInjected.Token(Token = "0x60000C1")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void HDDNNCNNJMB(bool NGGMOCIINFJ);

	[Cpp2IlInjected.Token(Token = "0x60000C2")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void KHNKJFJMFFM(Rigidbody IOJJIGGDNPN);

	[Cpp2IlInjected.Token(Token = "0x60000C3")]
	[Cpp2IlInjected.Address(Slot = "6")]
	bool BDBHIBJMAFO(Vector3 AKNDOLIKNGM, [Out] RaycastHit MGAKEPJNIDG, float IBOJBDBEJBJ);
}
[Cpp2IlInjected.Token(Token = "0x2000012")]
public interface HFPBFKAEHJM : IDisposable, NAMDOKCHCKG
{
	[Cpp2IlInjected.Token(Token = "0x17000037")]
	BAGHKPJGLEA HJLBEPGNACN
	{
		[Cpp2IlInjected.Token(Token = "0x60000C6")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
		[Cpp2IlInjected.Token(Token = "0x60000C7")]
		[Cpp2IlInjected.Address(Slot = "3")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x1400000A")]
	event Action<FDHMLINJMLJ, FDHMLINJMLJ> IOALOLNJHBM;

	[Cpp2IlInjected.Token(Token = "0x60000C8")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void NPFDHKEDPBK();
}
[Cpp2IlInjected.Token(Token = "0x2000013")]
[APMFBPCIIGG(NDFLJIICBJB.Application)]
public interface CKFHDMFFLAC
{
	[Cpp2IlInjected.Token(Token = "0x60000C9")]
	[Cpp2IlInjected.Address(Slot = "0")]
	AEHPKHIMIDL LOJAHIJFBGD(EHCMNHLPJBM KKOFNCEIKDA);

	[Cpp2IlInjected.Token(Token = "0x60000CA")]
	[Cpp2IlInjected.Address(Slot = "1")]
	EGNMEGPNLGB HNHMABEMGJI(EHCMNHLPJBM KKOFNCEIKDA);

	[Cpp2IlInjected.Token(Token = "0x60000CB")]
	[Cpp2IlInjected.Address(Slot = "2")]
	CLEHINCHHDE OFKGIFIMGFJ(EHCMNHLPJBM KKOFNCEIKDA);

	[Cpp2IlInjected.Token(Token = "0x60000CC")]
	[Cpp2IlInjected.Address(Slot = "3")]
	HNFHIEOAONP DIFFELNBIFI(EHCMNHLPJBM KKOFNCEIKDA);

	[Cpp2IlInjected.Token(Token = "0x60000CD")]
	[Cpp2IlInjected.Address(Slot = "4")]
	EKKHALEFJMB KGANCFEAPKO(EHCMNHLPJBM KKOFNCEIKDA);

	[Cpp2IlInjected.Token(Token = "0x60000CE")]
	[Cpp2IlInjected.Address(Slot = "5")]
	HFPBFKAEHJM NIGBNCBFBJJ(EHCMNHLPJBM KKOFNCEIKDA);

	[Cpp2IlInjected.Token(Token = "0x60000CF")]
	[Cpp2IlInjected.Address(Slot = "6")]
	AGCCBIKJDAK MMKICHJCCKP(EHCMNHLPJBM KKOFNCEIKDA);

	[Cpp2IlInjected.Token(Token = "0x60000D0")]
	[Cpp2IlInjected.Address(Slot = "7")]
	HEOOOHDIHMG JGJKHNJFOJD(EHCMNHLPJBM KKOFNCEIKDA);

	[Cpp2IlInjected.Token(Token = "0x60000D1")]
	[Cpp2IlInjected.Address(Slot = "8")]
	AOENHBHLFIE OIJEPIONEHP(EHCMNHLPJBM KKOFNCEIKDA);

	[Cpp2IlInjected.Token(Token = "0x60000D2")]
	[Cpp2IlInjected.Address(Slot = "9")]
	HIIFMKKGLIL BMEBOLGICDA(EHCMNHLPJBM KKOFNCEIKDA);

	[Cpp2IlInjected.Token(Token = "0x60000D3")]
	[Cpp2IlInjected.Address(Slot = "10")]
	BJKCOGNFHAA NOLNAKDKDAI(EHCMNHLPJBM KKOFNCEIKDA, [In] OJNOICCBOJO FCLEEDACIMH);

	[Cpp2IlInjected.Token(Token = "0x60000D4")]
	[Cpp2IlInjected.Address(Slot = "11")]
	FHAABOAKHEB MLANGGFGHIF(EHCMNHLPJBM KKOFNCEIKDA, [In] OJNOICCBOJO FCLEEDACIMH);

	[Cpp2IlInjected.Token(Token = "0x60000D5")]
	[Cpp2IlInjected.Address(Slot = "12")]
	HFBOJOOMHLA AJEBNHHBCOM(EHCMNHLPJBM KKOFNCEIKDA, [In] OJNOICCBOJO FCLEEDACIMH);

	[Cpp2IlInjected.Token(Token = "0x60000D6")]
	[Cpp2IlInjected.Address(Slot = "13")]
	KACNHFAPOGE PLHBGLLLBCK(EHCMNHLPJBM KKOFNCEIKDA, [In] OJNOICCBOJO FCLEEDACIMH);

	[Cpp2IlInjected.Token(Token = "0x60000D7")]
	[Cpp2IlInjected.Address(Slot = "14")]
	ADPECGILELO LMGICMACJAC(EHCMNHLPJBM KKOFNCEIKDA, [In] OJNOICCBOJO FCLEEDACIMH);

	[Cpp2IlInjected.Token(Token = "0x60000D8")]
	[Cpp2IlInjected.Address(Slot = "15")]
	EHCMNHLPJBM LGLNIFFDNHL(RigidbodyEx ECLMPMCOOIA, OJNOICCBOJO FCLEEDACIMH, IDMHNKCBNME PPJFGCMLNID);
}
[Cpp2IlInjected.Token(Token = "0x2000014")]
public interface HEOOOHDIHMG
{
	[Cpp2IlInjected.Token(Token = "0x60000D9")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void IJKJHGBBCEG(Vector3 OFOIDDLLFEI, ForceMode OJEDHHILKEL = ForceMode.Force);

	[Cpp2IlInjected.Token(Token = "0x60000DA")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void HIDBDPPDDNG(Vector3 OFOIDDLLFEI, Vector3 LPGLCEHEHMC, ForceMode OJEDHHILKEL);

	[Cpp2IlInjected.Token(Token = "0x60000DB")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void FEDPGNOKGDK(Vector3 LGKLDHJLFFC, ForceMode OJEDHHILKEL = ForceMode.Force);

	[Cpp2IlInjected.Token(Token = "0x60000DC")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void KBMMINBNLNN(Vector3 LGKLDHJLFFC, ForceMode OJEDHHILKEL = ForceMode.Force);
}
[Cpp2IlInjected.Token(Token = "0x2000015")]
public interface HIIFMKKGLIL
{
	[Cpp2IlInjected.Token(Token = "0x17000038")]
	bool BJICAJLOKDG
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
	void KHNKJFJMFFM(Rigidbody IOJJIGGDNPN);

	[Cpp2IlInjected.Token(Token = "0x60000E0")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void FBJMEJIJMGC(Rigidbody IOJJIGGDNPN);
}
[Cpp2IlInjected.Token(Token = "0x2000016")]
public interface AEHPKHIMIDL : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x17000039")]
	IReadOnlyList<EHCMNHLPJBM> NKNGGFCLKKC
	{
		[Cpp2IlInjected.Token(Token = "0x60000F3")]
		[Cpp2IlInjected.Address(Slot = "18")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700003A")]
	EHCMNHLPJBM FMAEDMDFLJE
	{
		[Cpp2IlInjected.Token(Token = "0x60000F4")]
		[Cpp2IlInjected.Address(Slot = "19")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700003B")]
	EHCMNHLPJBM CPGMADILNAD
	{
		[Cpp2IlInjected.Token(Token = "0x60000F5")]
		[Cpp2IlInjected.Address(Slot = "20")]
		get;
		[Cpp2IlInjected.Token(Token = "0x60000F6")]
		[Cpp2IlInjected.Address(Slot = "21")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x1400000B")]
	event ODMKMIKDLDH HNIODPCALEE;

	[Cpp2IlInjected.Token(Token = "0x1400000C")]
	event ODMKMIKDLDH ICDJPNDLGPD;

	[Cpp2IlInjected.Token(Token = "0x1400000D")]
	event LNHELIADCNA JAPGMOHDICK;

	[Cpp2IlInjected.Token(Token = "0x1400000E")]
	event Action AFIOFAKDOHM;

	[Cpp2IlInjected.Token(Token = "0x1400000F")]
	event Action LDAFEJALAGM;

	[Cpp2IlInjected.Token(Token = "0x14000010")]
	event Action<EHCMNHLPJBM> IHHOLKIEDLI;

	[Cpp2IlInjected.Token(Token = "0x14000011")]
	event Action<EHCMNHLPJBM> GFEGPGHKFIA;

	[Cpp2IlInjected.Token(Token = "0x14000012")]
	event Action HHBKPHPDLNL;

	[Cpp2IlInjected.Token(Token = "0x14000013")]
	event Action<EHCMNHLPJBM> NOBNHCGFCBM;

	[Cpp2IlInjected.Token(Token = "0x60000F7")]
	[Cpp2IlInjected.Address(Slot = "22")]
	void GLKDGJFHDGI(EHCMNHLPJBM GLMIFAAAHGN, bool FMNAIIPBFHC = false);
}
[Cpp2IlInjected.Token(Token = "0x2000017")]
public interface CLEHINCHHDE
{
	[Cpp2IlInjected.Token(Token = "0x1700003C")]
	Vector3 BGJFIEJBIJF
	{
		[Cpp2IlInjected.Token(Token = "0x60000F8")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700003D")]
	Vector3 FLCGLBNKKAA
	{
		[Cpp2IlInjected.Token(Token = "0x60000F9")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x60000FA")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void PKGKHPOJDBI(EHCMNHLPJBM IGPIMCJILMM, object PDIBILKHEBM);

	[Cpp2IlInjected.Token(Token = "0x60000FB")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void PIAIJDLNGDE(object PDIBILKHEBM);
}
[Cpp2IlInjected.Token(Token = "0x2000018")]
public interface KACNHFAPOGE
{
	[Cpp2IlInjected.Token(Token = "0x1700003E")]
	Vector3 LADKEMIALFK
	{
		[Cpp2IlInjected.Token(Token = "0x60000FE")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
		[Cpp2IlInjected.Token(Token = "0x60000FF")]
		[Cpp2IlInjected.Address(Slot = "3")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x1700003F")]
	Vector3 PIICNOJNCPP
	{
		[Cpp2IlInjected.Token(Token = "0x6000100")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000040")]
	float DGAGBHADGJN
	{
		[Cpp2IlInjected.Token(Token = "0x6000101")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000041")]
	float LLNDLOGDDIG
	{
		[Cpp2IlInjected.Token(Token = "0x6000102")]
		[Cpp2IlInjected.Address(Slot = "6")]
		get;
		[Cpp2IlInjected.Token(Token = "0x6000103")]
		[Cpp2IlInjected.Address(Slot = "7")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000042")]
	Vector3 HNOLHOHLFKJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000104")]
		[Cpp2IlInjected.Address(Slot = "8")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000043")]
	Quaternion LONFIJLGBOG
	{
		[Cpp2IlInjected.Token(Token = "0x6000105")]
		[Cpp2IlInjected.Address(Slot = "9")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x14000014")]
	event ODMKMIKDLDH ECMDDEJIIMB;

	[Cpp2IlInjected.Token(Token = "0x6000106")]
	[Cpp2IlInjected.Address(Slot = "10")]
	void PECPHAKBJCG((Quaternion rot, Vector3 moments) IJPGGILEIIN);

	[Cpp2IlInjected.Token(Token = "0x6000107")]
	[Cpp2IlInjected.Address(Slot = "11")]
	void NKANMLKMEBG();

	[Cpp2IlInjected.Token(Token = "0x6000108")]
	[Cpp2IlInjected.Address(Slot = "12")]
	void EMOEILKEJBE();

	[Cpp2IlInjected.Token(Token = "0x6000109")]
	[Cpp2IlInjected.Address(Slot = "13")]
	void FAMCOJOMDOD();

	[Cpp2IlInjected.Token(Token = "0x600010A")]
	[Cpp2IlInjected.Address(Slot = "14")]
	void KHNKJFJMFFM(Rigidbody IOJJIGGDNPN);

	[Cpp2IlInjected.Token(Token = "0x600010B")]
	[Cpp2IlInjected.Address(Slot = "15")]
	void FBJMEJIJMGC(Rigidbody IOJJIGGDNPN);

	[Cpp2IlInjected.Token(Token = "0x600010C")]
	[Cpp2IlInjected.Address(Slot = "16")]
	void BLJKMNBKPBO();
}
[Cpp2IlInjected.Token(Token = "0x2000019")]
public interface HFBOJOOMHLA
{
	[Cpp2IlInjected.Token(Token = "0x600010D")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void NPFDHKEDPBK();

	[Cpp2IlInjected.Token(Token = "0x600010E")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void HLKPOIGCEAG(object PDIBILKHEBM);

	[Cpp2IlInjected.Token(Token = "0x600010F")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void IIAIKOCKHGA(object PDIBILKHEBM);

	[Cpp2IlInjected.Token(Token = "0x6000110")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void GCCKNIMCPIP(EHCMNHLPJBM ECLMPMCOOIA);

	[Cpp2IlInjected.Token(Token = "0x6000111")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void AMOOCLCHOID(EHCMNHLPJBM ECLMPMCOOIA);

	[Cpp2IlInjected.Token(Token = "0x6000112")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void FIJMFJHPGEE();
}
[Cpp2IlInjected.Token(Token = "0x200001A")]
public interface AGCCBIKJDAK
{
	[Cpp2IlInjected.Token(Token = "0x17000044")]
	bool KFMBBJLEAJK
	{
		[Cpp2IlInjected.Token(Token = "0x6000116")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x14000015")]
	event ODMKMIKDLDH IJHOLLBGJPD;

	[Cpp2IlInjected.Token(Token = "0x6000115")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void BJFJHCOMKNK();

	[Cpp2IlInjected.Token(Token = "0x6000117")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void JPFGFDECHOJ(object PDIBILKHEBM);

	[Cpp2IlInjected.Token(Token = "0x6000118")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void KAPPGEIEJKO(object PDIBILKHEBM);

	[Cpp2IlInjected.Token(Token = "0x6000119")]
	[Cpp2IlInjected.Address(Slot = "6")]
	void GJJAJKOMBNJ(object PDIBILKHEBM, bool GKHMPKCJGHP);

	[Cpp2IlInjected.Token(Token = "0x600011A")]
	[Cpp2IlInjected.Address(Slot = "7")]
	IDisposable HLJKBPAJOBH();

	[Cpp2IlInjected.Token(Token = "0x600011B")]
	[Cpp2IlInjected.Address(Slot = "8")]
	void KHNKJFJMFFM(Rigidbody JFBLILNAOMM);

	[Cpp2IlInjected.Token(Token = "0x600011C")]
	[Cpp2IlInjected.Address(Slot = "9")]
	void FBJMEJIJMGC(Rigidbody IOJJIGGDNPN);
}
[Cpp2IlInjected.Token(Token = "0x200001B")]
public interface FHAABOAKHEB : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x17000045")]
	bool GCPNKEIHNJF
	{
		[Cpp2IlInjected.Token(Token = "0x600011F")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000046")]
	bool FLDOPHCHFPM
	{
		[Cpp2IlInjected.Token(Token = "0x6000120")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x14000016")]
	event ODMKMIKDLDH GIADDJGCKPO;

	[Cpp2IlInjected.Token(Token = "0x6000121")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void NPFDHKEDPBK();

	[Cpp2IlInjected.Token(Token = "0x6000122")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void MFCPKNBIHKM(EHCMNHLPJBM IGPIMCJILMM);

	[Cpp2IlInjected.Token(Token = "0x6000123")]
	[Cpp2IlInjected.Address(Slot = "6")]
	void KBIEHHBCMLI(EHCMNHLPJBM IGPIMCJILMM);
}
[Cpp2IlInjected.Token(Token = "0x200001C")]
public interface ADPECGILELO
{
	[Cpp2IlInjected.Token(Token = "0x17000047")]
	bool MIOAIPJJMGG
	{
		[Cpp2IlInjected.Token(Token = "0x6000124")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
		[Cpp2IlInjected.Token(Token = "0x6000125")]
		[Cpp2IlInjected.Address(Slot = "1")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000048")]
	bool FOAJEHMGIDA
	{
		[Cpp2IlInjected.Token(Token = "0x6000126")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000049")]
	RigidbodyConstraints NPGAMCBNMHD
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
	void KHNKJFJMFFM(Rigidbody IOJJIGGDNPN);

	[Cpp2IlInjected.Token(Token = "0x600012A")]
	[Cpp2IlInjected.Address(Slot = "6")]
	void FBJMEJIJMGC(Rigidbody IOJJIGGDNPN);
}
[Cpp2IlInjected.Token(Token = "0x200001D")]
public interface HNFHIEOAONP
{
	[Cpp2IlInjected.Token(Token = "0x1700004A")]
	float EBALBFJEABI
	{
		[Cpp2IlInjected.Token(Token = "0x600012B")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
		[Cpp2IlInjected.Token(Token = "0x600012C")]
		[Cpp2IlInjected.Address(Slot = "1")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x1700004B")]
	float FBKHGEIFEEL
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
	void KHNKJFJMFFM(Rigidbody IOJJIGGDNPN);

	[Cpp2IlInjected.Token(Token = "0x6000130")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void FBJMEJIJMGC(Rigidbody IOJJIGGDNPN);
}
[Cpp2IlInjected.Token(Token = "0x200001E")]
public interface OBDGHEKHMLE
{
	[Cpp2IlInjected.Token(Token = "0x6000131")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void OnRootRBEXChanged(RigidbodyEx GMAGNINPDJC);
}
[Cpp2IlInjected.Token(Token = "0x200001F")]
public interface EKKHALEFJMB
{
	[Cpp2IlInjected.Token(Token = "0x14000017")]
	event ODMKMIKDLDH AGBEMFNHAAD;

	[Cpp2IlInjected.Token(Token = "0x6000134")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void NPFDHKEDPBK();

	[Cpp2IlInjected.Token(Token = "0x6000135")]
	[Cpp2IlInjected.Address(Slot = "3")]
	bool NKFKNEFDAFK();

	[Cpp2IlInjected.Token(Token = "0x6000136")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void FAHFAEABFGP();

	[Cpp2IlInjected.Token(Token = "0x6000137")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void EIHNIBFOFFJ();

	[Cpp2IlInjected.Token(Token = "0x6000138")]
	[Cpp2IlInjected.Address(Slot = "6")]
	void DBEJFEPONEK();

	[Cpp2IlInjected.Token(Token = "0x6000139")]
	[Cpp2IlInjected.Address(Slot = "7")]
	void JPMGMMIEBBB();

	[Cpp2IlInjected.Token(Token = "0x600013A")]
	[Cpp2IlInjected.Address(Slot = "8")]
	void OMMJOFBDFBB(bool JIPBGPFOHIP);
}
[Cpp2IlInjected.Token(Token = "0x2000020")]
public interface BJKCOGNFHAA
{
	[Cpp2IlInjected.Token(Token = "0x1700004C")]
	Rigidbody JLNHKFKKICK
	{
		[Cpp2IlInjected.Token(Token = "0x600013B")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700004D")]
	bool LFGLHLLGJDN
	{
		[Cpp2IlInjected.Token(Token = "0x600013D")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x600013C")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void NPFDHKEDPBK();

	[Cpp2IlInjected.Token(Token = "0x600013E")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void JEJJNCIBMKD(object PDIBILKHEBM);

	[Cpp2IlInjected.Token(Token = "0x600013F")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void MPNABKADOLD(object PDIBILKHEBM);

	[Cpp2IlInjected.Token(Token = "0x6000140")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void IDCEKLJCOAF();

	[Cpp2IlInjected.Token(Token = "0x6000141")]
	[Cpp2IlInjected.Address(Slot = "6")]
	void NMDAPEFEOIC();
}
[Cpp2IlInjected.Token(Token = "0x2000021")]
public interface EGNMEGPNLGB : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x1700004E")]
	AFBJPJGOHAH PAKEEKMBNJI
	{
		[Cpp2IlInjected.Token(Token = "0x6000142")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
		[Cpp2IlInjected.Token(Token = "0x6000143")]
		[Cpp2IlInjected.Address(Slot = "1")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x1700004F")]
	GAMCJHNBHDA CONGFAJKAFK
	{
		[Cpp2IlInjected.Token(Token = "0x6000144")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
		[Cpp2IlInjected.Token(Token = "0x6000145")]
		[Cpp2IlInjected.Address(Slot = "3")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000050")]
	Vector3 JLKBIOAHEKE
	{
		[Cpp2IlInjected.Token(Token = "0x6000146")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
		[Cpp2IlInjected.Token(Token = "0x6000147")]
		[Cpp2IlInjected.Address(Slot = "5")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000051")]
	Vector3 ONCBIGPFDBG
	{
		[Cpp2IlInjected.Token(Token = "0x6000148")]
		[Cpp2IlInjected.Address(Slot = "6")]
		get;
		[Cpp2IlInjected.Token(Token = "0x6000149")]
		[Cpp2IlInjected.Address(Slot = "7")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000052")]
	Vector3 ILEPAAIOGPH
	{
		[Cpp2IlInjected.Token(Token = "0x600014A")]
		[Cpp2IlInjected.Address(Slot = "8")]
		get;
		[Cpp2IlInjected.Token(Token = "0x600014B")]
		[Cpp2IlInjected.Address(Slot = "9")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000053")]
	Vector3 DINKBHOHIJN
	{
		[Cpp2IlInjected.Token(Token = "0x600014C")]
		[Cpp2IlInjected.Address(Slot = "10")]
		get;
		[Cpp2IlInjected.Token(Token = "0x600014D")]
		[Cpp2IlInjected.Address(Slot = "11")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000054")]
	float CEJDFPIKKNH
	{
		[Cpp2IlInjected.Token(Token = "0x600014E")]
		[Cpp2IlInjected.Address(Slot = "12")]
		get;
		[Cpp2IlInjected.Token(Token = "0x600014F")]
		[Cpp2IlInjected.Address(Slot = "13")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000055")]
	bool CNPBCJLHPAJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000150")]
		[Cpp2IlInjected.Address(Slot = "14")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000151")]
	[Cpp2IlInjected.Address(Slot = "15")]
	void NPFDHKEDPBK();

	[Cpp2IlInjected.Token(Token = "0x6000152")]
	[Cpp2IlInjected.Address(Slot = "16")]
	void EJAMNEGFJEM(object PDIBILKHEBM);

	[Cpp2IlInjected.Token(Token = "0x6000153")]
	[Cpp2IlInjected.Address(Slot = "17")]
	void EHCOAACKECM(LGPMEMPGHMC CFIODOIHFKI, Vector3 POKFEHNNFOH, float NLCECILHIIF = float.PositiveInfinity);

	[Cpp2IlInjected.Token(Token = "0x6000154")]
	[Cpp2IlInjected.Address(Slot = "18")]
	void IHIBCDABGEA(BOLJBMMECOE DBGBHNOCNJE, Vector3 HGEDCNMOIAN, float NBBOEEPKJMP, float MFOFCNBGOEE = 8f, float JKNAHEBOBHM = 1f);

	[Cpp2IlInjected.Token(Token = "0x6000155")]
	[Cpp2IlInjected.Address(Slot = "19")]
	void IAGIBKOHJDJ(LGPMEMPGHMC CFIODOIHFKI, Vector3 LGOFCBEILGM, float DPKKDMEAKFE = 7f, float DLNPOBOGDPN = 1f);

	[Cpp2IlInjected.Token(Token = "0x6000156")]
	[Cpp2IlInjected.Address(Slot = "20")]
	void BCBGBGNDMKE();

	[Cpp2IlInjected.Token(Token = "0x6000157")]
	[Cpp2IlInjected.Address(Slot = "21")]
	void GAMMNKDKDMP();

	[Cpp2IlInjected.Token(Token = "0x6000158")]
	[Cpp2IlInjected.Address(Slot = "22")]
	void DACCEJMCHOM();

	[Cpp2IlInjected.Token(Token = "0x6000159")]
	[Cpp2IlInjected.Address(Slot = "23")]
	void MBDGEAIJODJ();

	[Cpp2IlInjected.Token(Token = "0x600015A")]
	[Cpp2IlInjected.Address(Slot = "24")]
	void KHNKJFJMFFM(Rigidbody IOJJIGGDNPN);

	[Cpp2IlInjected.Token(Token = "0x600015B")]
	[Cpp2IlInjected.Address(Slot = "25")]
	Vector3 NKFAKMKMGLK(Vector3 OBNDDJFFKOO);

	[Cpp2IlInjected.Token(Token = "0x600015C")]
	[Cpp2IlInjected.Address(Slot = "26")]
	void FGKEAHEDAEC(object PDIBILKHEBM);

	[Cpp2IlInjected.Token(Token = "0x600015D")]
	[Cpp2IlInjected.Address(Slot = "27")]
	void KEIBJNKFFKK(Vector3 BCLKICLJPAP);

	[Cpp2IlInjected.Token(Token = "0x600015E")]
	[Cpp2IlInjected.Address(Slot = "28")]
	void NADJGLGOMJF(Vector3 ACIPBFHCAAA, Vector3 PLLAPIPLOBE);

	[Cpp2IlInjected.Token(Token = "0x600015F")]
	[Cpp2IlInjected.Address(Slot = "29")]
	void MLEAMOMCHPM(Vector3 PFBOCMNHECB, Vector3 EGGKDKAICGO);

	[Cpp2IlInjected.Token(Token = "0x6000160")]
	[Cpp2IlInjected.Address(Slot = "30")]
	Vector3 FNKNMFKCFHO(Vector3 GMLDNFHDNJP);

	[Cpp2IlInjected.Token(Token = "0x6000161")]
	[Cpp2IlInjected.Address(Slot = "31")]
	Vector3 ECOHLCBCAIO(Vector3 IACNFCFIIOM);
}
[Cpp2IlInjected.Token(Token = "0x2000022")]
[APMFBPCIIGG(NDFLJIICBJB.Application)]
public interface OJGPFPNPOJP
{
	[Cpp2IlInjected.Token(Token = "0x17000056")]
	bool GJHNIDPGLGP
	{
		[Cpp2IlInjected.Token(Token = "0x6000162")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000163")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void HOLALHGAGPP(string KHEFJOIGNAL);

	[Cpp2IlInjected.Token(Token = "0x6000164")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void BEPIOJMLEAM(RigidbodyEx ECLMPMCOOIA, Action NFDFJOBAEPD);

	[Cpp2IlInjected.Token(Token = "0x6000165")]
	[Cpp2IlInjected.Address(Slot = "3")]
	KKDEOGMNLDN DFCOMAEMJBL(int DIPELGILLDE);

	[Cpp2IlInjected.Token(Token = "0x6000166")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void DNCNACJKGME(Vector3 MEBEBMKNLIG, float FELOFNPGJNG, Color NGFEKFKHCIJ);
}
[Cpp2IlInjected.Token(Token = "0x2000023")]
[APMFBPCIIGG(NDFLJIICBJB.Application)]
public interface IDMHNKCBNME
{
	[Cpp2IlInjected.Token(Token = "0x17000057")]
	OJGPFPNPOJP DAKHMKMAHKD
	{
		[Cpp2IlInjected.Token(Token = "0x6000167")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000058")]
	CKFHDMFFLAC MIMDCAHINPD
	{
		[Cpp2IlInjected.Token(Token = "0x6000168")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000169")]
	[Cpp2IlInjected.Address(Slot = "2")]
	DALFLBHIMAN INIIPBADBIF(RigidbodyEx ECLMPMCOOIA);

	[Cpp2IlInjected.Token(Token = "0x600016A")]
	[Cpp2IlInjected.Address(Slot = "3")]
	EHCMNHLPJBM LGLNIFFDNHL(RigidbodyEx ECLMPMCOOIA, OJNOICCBOJO FCLEEDACIMH);
}
[Cpp2IlInjected.Token(Token = "0x2000024")]
public interface GAMCJHNBHDA
{
	[Cpp2IlInjected.Token(Token = "0x600016B")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void AGKLOFKOKAI(Vector3 DGCBGKOONLN);

	[Cpp2IlInjected.Token(Token = "0x600016C")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void NLOEJKCIIKH(Vector3 DHDAKHKKKMH);

	[Cpp2IlInjected.Token(Token = "0x600016D")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void AMPOOFNCAAA(Vector3 DGCBGKOONLN);

	[Cpp2IlInjected.Token(Token = "0x600016E")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void HCEOPDFDLDC(Vector3 DHDAKHKKKMH);
}
[Cpp2IlInjected.Token(Token = "0x2000025")]
public interface AFBJPJGOHAH : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x600016F")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Vector3 BBCOFJMDGGI();

	[Cpp2IlInjected.Token(Token = "0x6000170")]
	[Cpp2IlInjected.Address(Slot = "1")]
	Vector3 OGOHBLJNEHM();
}
[Cpp2IlInjected.Token(Token = "0x2000026")]
public interface EHCMNHLPJBM : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x17000059")]
	Rigidbody JLNHKFKKICK
	{
		[Cpp2IlInjected.Token(Token = "0x6000171")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700005A")]
	RigidbodyEx PBDBDKAJEPD
	{
		[Cpp2IlInjected.Token(Token = "0x6000172")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700005B")]
	GameObject PHKAEJEKHIF
	{
		[Cpp2IlInjected.Token(Token = "0x6000173")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700005C")]
	Transform FHHLKDMADLC
	{
		[Cpp2IlInjected.Token(Token = "0x6000174")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700005D")]
	EHCMNHLPJBM CPGMADILNAD
	{
		[Cpp2IlInjected.Token(Token = "0x6000175")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
		[Cpp2IlInjected.Token(Token = "0x6000176")]
		[Cpp2IlInjected.Address(Slot = "5")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x1700005E")]
	IReadOnlyList<EHCMNHLPJBM> NKNGGFCLKKC
	{
		[Cpp2IlInjected.Token(Token = "0x6000177")]
		[Cpp2IlInjected.Address(Slot = "6")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700005F")]
	EHCMNHLPJBM FMAEDMDFLJE
	{
		[Cpp2IlInjected.Token(Token = "0x6000178")]
		[Cpp2IlInjected.Address(Slot = "7")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000060")]
	bool GCPNKEIHNJF
	{
		[Cpp2IlInjected.Token(Token = "0x6000179")]
		[Cpp2IlInjected.Address(Slot = "8")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000061")]
	bool FLDOPHCHFPM
	{
		[Cpp2IlInjected.Token(Token = "0x600017A")]
		[Cpp2IlInjected.Address(Slot = "9")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000062")]
	AFBJPJGOHAH PAKEEKMBNJI
	{
		[Cpp2IlInjected.Token(Token = "0x600017B")]
		[Cpp2IlInjected.Address(Slot = "10")]
		get;
		[Cpp2IlInjected.Token(Token = "0x600017C")]
		[Cpp2IlInjected.Address(Slot = "11")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000063")]
	GAMCJHNBHDA CONGFAJKAFK
	{
		[Cpp2IlInjected.Token(Token = "0x600017D")]
		[Cpp2IlInjected.Address(Slot = "12")]
		get;
		[Cpp2IlInjected.Token(Token = "0x600017E")]
		[Cpp2IlInjected.Address(Slot = "13")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000064")]
	float CEJDFPIKKNH
	{
		[Cpp2IlInjected.Token(Token = "0x600017F")]
		[Cpp2IlInjected.Address(Slot = "14")]
		get;
		[Cpp2IlInjected.Token(Token = "0x6000180")]
		[Cpp2IlInjected.Address(Slot = "15")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000065")]
	Vector3 ONCBIGPFDBG
	{
		[Cpp2IlInjected.Token(Token = "0x6000181")]
		[Cpp2IlInjected.Address(Slot = "16")]
		get;
		[Cpp2IlInjected.Token(Token = "0x6000182")]
		[Cpp2IlInjected.Address(Slot = "17")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000066")]
	Vector3 DINKBHOHIJN
	{
		[Cpp2IlInjected.Token(Token = "0x6000183")]
		[Cpp2IlInjected.Address(Slot = "18")]
		get;
		[Cpp2IlInjected.Token(Token = "0x6000184")]
		[Cpp2IlInjected.Address(Slot = "19")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000067")]
	Vector3 JLKBIOAHEKE
	{
		[Cpp2IlInjected.Token(Token = "0x6000185")]
		[Cpp2IlInjected.Address(Slot = "20")]
		get;
		[Cpp2IlInjected.Token(Token = "0x6000186")]
		[Cpp2IlInjected.Address(Slot = "21")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000068")]
	Vector3 ILEPAAIOGPH
	{
		[Cpp2IlInjected.Token(Token = "0x6000187")]
		[Cpp2IlInjected.Address(Slot = "22")]
		get;
		[Cpp2IlInjected.Token(Token = "0x6000188")]
		[Cpp2IlInjected.Address(Slot = "23")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000069")]
	bool CPKNHGNOJKA
	{
		[Cpp2IlInjected.Token(Token = "0x6000189")]
		[Cpp2IlInjected.Address(Slot = "24")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700006A")]
	bool OPNOHLFFIJB
	{
		[Cpp2IlInjected.Token(Token = "0x600018A")]
		[Cpp2IlInjected.Address(Slot = "25")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700006B")]
	bool CNPBCJLHPAJ
	{
		[Cpp2IlInjected.Token(Token = "0x600018B")]
		[Cpp2IlInjected.Address(Slot = "26")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700006C")]
	Vector3 BGJFIEJBIJF
	{
		[Cpp2IlInjected.Token(Token = "0x600018C")]
		[Cpp2IlInjected.Address(Slot = "27")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700006D")]
	Vector3 FLCGLBNKKAA
	{
		[Cpp2IlInjected.Token(Token = "0x600018D")]
		[Cpp2IlInjected.Address(Slot = "28")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700006E")]
	Vector3 LADKEMIALFK
	{
		[Cpp2IlInjected.Token(Token = "0x600018E")]
		[Cpp2IlInjected.Address(Slot = "29")]
		get;
		[Cpp2IlInjected.Token(Token = "0x600018F")]
		[Cpp2IlInjected.Address(Slot = "30")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x1700006F")]
	Vector3 PIICNOJNCPP
	{
		[Cpp2IlInjected.Token(Token = "0x6000190")]
		[Cpp2IlInjected.Address(Slot = "31")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000070")]
	float DGAGBHADGJN
	{
		[Cpp2IlInjected.Token(Token = "0x6000191")]
		[Cpp2IlInjected.Address(Slot = "32")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000071")]
	float LLNDLOGDDIG
	{
		[Cpp2IlInjected.Token(Token = "0x6000192")]
		[Cpp2IlInjected.Address(Slot = "33")]
		get;
		[Cpp2IlInjected.Token(Token = "0x6000193")]
		[Cpp2IlInjected.Address(Slot = "34")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000072")]
	Vector3 HNOLHOHLFKJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000194")]
		[Cpp2IlInjected.Address(Slot = "35")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000073")]
	Quaternion LONFIJLGBOG
	{
		[Cpp2IlInjected.Token(Token = "0x6000195")]
		[Cpp2IlInjected.Address(Slot = "36")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000074")]
	float EBALBFJEABI
	{
		[Cpp2IlInjected.Token(Token = "0x6000197")]
		[Cpp2IlInjected.Address(Slot = "38")]
		get;
		[Cpp2IlInjected.Token(Token = "0x6000198")]
		[Cpp2IlInjected.Address(Slot = "39")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000075")]
	float FBKHGEIFEEL
	{
		[Cpp2IlInjected.Token(Token = "0x6000199")]
		[Cpp2IlInjected.Address(Slot = "40")]
		get;
		[Cpp2IlInjected.Token(Token = "0x600019A")]
		[Cpp2IlInjected.Address(Slot = "41")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000076")]
	bool BJICAJLOKDG
	{
		[Cpp2IlInjected.Token(Token = "0x600019B")]
		[Cpp2IlInjected.Address(Slot = "42")]
		get;
		[Cpp2IlInjected.Token(Token = "0x600019C")]
		[Cpp2IlInjected.Address(Slot = "43")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000077")]
	BAGHKPJGLEA HJLBEPGNACN
	{
		[Cpp2IlInjected.Token(Token = "0x600019D")]
		[Cpp2IlInjected.Address(Slot = "44")]
		get;
		[Cpp2IlInjected.Token(Token = "0x600019E")]
		[Cpp2IlInjected.Address(Slot = "45")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000078")]
	bool KFMBBJLEAJK
	{
		[Cpp2IlInjected.Token(Token = "0x600019F")]
		[Cpp2IlInjected.Address(Slot = "46")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000079")]
	Transform GCGFCFBOGAL
	{
		[Cpp2IlInjected.Token(Token = "0x60001A0")]
		[Cpp2IlInjected.Address(Slot = "47")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700007A")]
	Vector3 LAFFMBPMCBK
	{
		[Cpp2IlInjected.Token(Token = "0x60001A1")]
		[Cpp2IlInjected.Address(Slot = "48")]
		get;
		[Cpp2IlInjected.Token(Token = "0x60001A2")]
		[Cpp2IlInjected.Address(Slot = "49")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x1700007B")]
	float ABAAKHNHDME
	{
		[Cpp2IlInjected.Token(Token = "0x60001A3")]
		[Cpp2IlInjected.Address(Slot = "50")]
		get;
		[Cpp2IlInjected.Token(Token = "0x60001A4")]
		[Cpp2IlInjected.Address(Slot = "51")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x1700007C")]
	float JFAHGDFBNGK
	{
		[Cpp2IlInjected.Token(Token = "0x60001A5")]
		[Cpp2IlInjected.Address(Slot = "52")]
		get;
		[Cpp2IlInjected.Token(Token = "0x60001A6")]
		[Cpp2IlInjected.Address(Slot = "53")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x1700007D")]
	Quaternion NBMJCMLBMDE
	{
		[Cpp2IlInjected.Token(Token = "0x60001A7")]
		[Cpp2IlInjected.Address(Slot = "54")]
		get;
		[Cpp2IlInjected.Token(Token = "0x60001A8")]
		[Cpp2IlInjected.Address(Slot = "55")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x1700007E")]
	Vector3 LGOPKPGLOLL
	{
		[Cpp2IlInjected.Token(Token = "0x60001A9")]
		[Cpp2IlInjected.Address(Slot = "56")]
		get;
		[Cpp2IlInjected.Token(Token = "0x60001AA")]
		[Cpp2IlInjected.Address(Slot = "57")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x1700007F")]
	Quaternion JGPPPKPPDBC
	{
		[Cpp2IlInjected.Token(Token = "0x60001AB")]
		[Cpp2IlInjected.Address(Slot = "58")]
		get;
		[Cpp2IlInjected.Token(Token = "0x60001AC")]
		[Cpp2IlInjected.Address(Slot = "59")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000080")]
	RigidbodyConstraints NPGAMCBNMHD
	{
		[Cpp2IlInjected.Token(Token = "0x60001AD")]
		[Cpp2IlInjected.Address(Slot = "60")]
		get;
		[Cpp2IlInjected.Token(Token = "0x60001AE")]
		[Cpp2IlInjected.Address(Slot = "61")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000081")]
	bool MIOAIPJJMGG
	{
		[Cpp2IlInjected.Token(Token = "0x60001AF")]
		[Cpp2IlInjected.Address(Slot = "62")]
		get;
		[Cpp2IlInjected.Token(Token = "0x60001B0")]
		[Cpp2IlInjected.Address(Slot = "63")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000082")]
	CollisionDetectionMode MHGBGHOHCOK
	{
		[Cpp2IlInjected.Token(Token = "0x60001B1")]
		[Cpp2IlInjected.Address(Slot = "64")]
		get;
		[Cpp2IlInjected.Token(Token = "0x60001B2")]
		[Cpp2IlInjected.Address(Slot = "65")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000083")]
	bool JEPMPAKBHKE
	{
		[Cpp2IlInjected.Token(Token = "0x60001B3")]
		[Cpp2IlInjected.Address(Slot = "66")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x14000018")]
	event ODMKMIKDLDH HNIODPCALEE;

	[Cpp2IlInjected.Token(Token = "0x14000019")]
	event ODMKMIKDLDH ICDJPNDLGPD;

	[Cpp2IlInjected.Token(Token = "0x1400001A")]
	event LNHELIADCNA JAPGMOHDICK;

	[Cpp2IlInjected.Token(Token = "0x1400001B")]
	event ODMKMIKDLDH GIADDJGCKPO;

	[Cpp2IlInjected.Token(Token = "0x1400001C")]
	event ODMKMIKDLDH GFDLDDIJKHF;

	[Cpp2IlInjected.Token(Token = "0x1400001D")]
	event ODMKMIKDLDH AGBEMFNHAAD;

	[Cpp2IlInjected.Token(Token = "0x1400001E")]
	event Action<FDHMLINJMLJ, FDHMLINJMLJ> IOALOLNJHBM;

	[Cpp2IlInjected.Token(Token = "0x1400001F")]
	event ODMKMIKDLDH IJHOLLBGJPD;

	[Cpp2IlInjected.Token(Token = "0x14000020")]
	event ODMKMIKDLDH EKOMCGBKAOG;

	[Cpp2IlInjected.Token(Token = "0x6000196")]
	[Cpp2IlInjected.Address(Slot = "37")]
	void PECPHAKBJCG((Quaternion rot, Vector3 moments) IJPGGILEIIN);

	[Cpp2IlInjected.Token(Token = "0x60001B4")]
	[Cpp2IlInjected.Address(Slot = "67")]
	void NPFDHKEDPBK();

	[Cpp2IlInjected.Token(Token = "0x60001B5")]
	[Cpp2IlInjected.Address(Slot = "68")]
	void DHFPKEPDKMD();

	[Cpp2IlInjected.Token(Token = "0x60001B6")]
	[Cpp2IlInjected.Address(Slot = "69")]
	void ACFAANOHPBB();

	[Cpp2IlInjected.Token(Token = "0x60001B7")]
	[Cpp2IlInjected.Address(Slot = "70")]
	void EIHNIBFOFFJ();

	[Cpp2IlInjected.Token(Token = "0x60001BE")]
	[Cpp2IlInjected.Address(Slot = "77")]
	void GLKDGJFHDGI(EHCMNHLPJBM APPJEOKOGAK, bool FMNAIIPBFHC = false);

	[Cpp2IlInjected.Token(Token = "0x60001C1")]
	[Cpp2IlInjected.Address(Slot = "80")]
	void PLEAHDIMCIE(object PDIBILKHEBM);

	[Cpp2IlInjected.Token(Token = "0x60001C2")]
	[Cpp2IlInjected.Address(Slot = "81")]
	void JJAALHAEDJD(object PDIBILKHEBM);

	[Cpp2IlInjected.Token(Token = "0x60001C3")]
	[Cpp2IlInjected.Address(Slot = "82")]
	Vector3 ECOHLCBCAIO(Vector3 IACNFCFIIOM);

	[Cpp2IlInjected.Token(Token = "0x60001C4")]
	[Cpp2IlInjected.Address(Slot = "83")]
	Vector3 FNKNMFKCFHO(Vector3 GMLDNFHDNJP);

	[Cpp2IlInjected.Token(Token = "0x60001C5")]
	[Cpp2IlInjected.Address(Slot = "84")]
	void MBDGEAIJODJ();

	[Cpp2IlInjected.Token(Token = "0x60001C6")]
	[Cpp2IlInjected.Address(Slot = "85")]
	void GAMMNKDKDMP();

	[Cpp2IlInjected.Token(Token = "0x60001C7")]
	[Cpp2IlInjected.Address(Slot = "86")]
	void BCBGBGNDMKE();

	[Cpp2IlInjected.Token(Token = "0x60001C8")]
	[Cpp2IlInjected.Address(Slot = "87")]
	void MLEAMOMCHPM(Vector3 PFBOCMNHECB, Vector3 EGGKDKAICGO);

	[Cpp2IlInjected.Token(Token = "0x60001C9")]
	[Cpp2IlInjected.Address(Slot = "88")]
	void NADJGLGOMJF(Vector3 ACIPBFHCAAA, Vector3 PLLAPIPLOBE);

	[Cpp2IlInjected.Token(Token = "0x60001CA")]
	[Cpp2IlInjected.Address(Slot = "89")]
	void KEIBJNKFFKK(Vector3 BCLKICLJPAP);

	[Cpp2IlInjected.Token(Token = "0x60001CB")]
	[Cpp2IlInjected.Address(Slot = "90")]
	void IHIBCDABGEA(BOLJBMMECOE DBGBHNOCNJE, Vector3 HGEDCNMOIAN, float NBBOEEPKJMP, float MFOFCNBGOEE = 8f, float JKNAHEBOBHM = 1f);

	[Cpp2IlInjected.Token(Token = "0x60001CC")]
	[Cpp2IlInjected.Address(Slot = "91")]
	void EHCOAACKECM(LGPMEMPGHMC CFIODOIHFKI, Vector3 POKFEHNNFOH, float NLCECILHIIF = float.PositiveInfinity);

	[Cpp2IlInjected.Token(Token = "0x60001CD")]
	[Cpp2IlInjected.Address(Slot = "92")]
	void IAGIBKOHJDJ(LGPMEMPGHMC CFIODOIHFKI, Vector3 LGOFCBEILGM, float DPKKDMEAKFE = 7f, float DLNPOBOGDPN = 1f);

	[Cpp2IlInjected.Token(Token = "0x60001CE")]
	[Cpp2IlInjected.Address(Slot = "93")]
	Vector3 NKFAKMKMGLK(Vector3 APPJEOKOGAK);

	[Cpp2IlInjected.Token(Token = "0x60001CF")]
	[Cpp2IlInjected.Address(Slot = "94")]
	Vector3 MHKJOCEAOOK(Vector3 APPJEOKOGAK);

	[Cpp2IlInjected.Token(Token = "0x60001D0")]
	[Cpp2IlInjected.Address(Slot = "95")]
	void DACCEJMCHOM();

	[Cpp2IlInjected.Token(Token = "0x60001D1")]
	[Cpp2IlInjected.Address(Slot = "96")]
	void LIMAGEHFCDJ(EHCMNHLPJBM OHPBKIJPBEH, object PDIBILKHEBM);

	[Cpp2IlInjected.Token(Token = "0x60001D2")]
	[Cpp2IlInjected.Address(Slot = "97")]
	void MHICMANCFJE(object PDIBILKHEBM);

	[Cpp2IlInjected.Token(Token = "0x60001D5")]
	[Cpp2IlInjected.Address(Slot = "100")]
	void EMOEILKEJBE();

	[Cpp2IlInjected.Token(Token = "0x60001D6")]
	[Cpp2IlInjected.Address(Slot = "101")]
	void NKANMLKMEBG();

	[Cpp2IlInjected.Token(Token = "0x60001D7")]
	[Cpp2IlInjected.Address(Slot = "102")]
	void FAMCOJOMDOD();

	[Cpp2IlInjected.Token(Token = "0x60001DA")]
	[Cpp2IlInjected.Address(Slot = "105")]
	bool NKFKNEFDAFK();

	[Cpp2IlInjected.Token(Token = "0x60001DB")]
	[Cpp2IlInjected.Address(Slot = "106")]
	void JPMGMMIEBBB();

	[Cpp2IlInjected.Token(Token = "0x60001E0")]
	[Cpp2IlInjected.Address(Slot = "111")]
	IDisposable HLJKBPAJOBH();

	[Cpp2IlInjected.Token(Token = "0x60001E1")]
	[Cpp2IlInjected.Address(Slot = "112")]
	void JPFGFDECHOJ(object PDIBILKHEBM);

	[Cpp2IlInjected.Token(Token = "0x60001E2")]
	[Cpp2IlInjected.Address(Slot = "113")]
	void KAPPGEIEJKO(object PDIBILKHEBM);

	[Cpp2IlInjected.Token(Token = "0x60001E3")]
	[Cpp2IlInjected.Address(Slot = "114")]
	void GJJAJKOMBNJ(object PDIBILKHEBM, bool GKHMPKCJGHP);

	[Cpp2IlInjected.Token(Token = "0x60001E6")]
	[Cpp2IlInjected.Address(Slot = "117")]
	void EBAFIDPJBLL(Vector3 LMCNGGBBGAK, Quaternion LJGGLNEHBNN);

	[Cpp2IlInjected.Token(Token = "0x60001E7")]
	[Cpp2IlInjected.Address(Slot = "118")]
	void PMLIDMGNBMJ(Vector3 AGFHJEELBOM, Quaternion DBJKCMEGHMK);

	[Cpp2IlInjected.Token(Token = "0x60001E8")]
	[Cpp2IlInjected.Address(Slot = "119")]
	bool LKLNFACJBJF(float MGEAGKCABGB);

	[Cpp2IlInjected.Token(Token = "0x60001E9")]
	[Cpp2IlInjected.Address(Slot = "120")]
	void KMEFLHLDIKM(object PDIBILKHEBM);

	[Cpp2IlInjected.Token(Token = "0x60001EA")]
	[Cpp2IlInjected.Address(Slot = "121")]
	void BKKCKHAEOCM(object PDIBILKHEBM);

	[Cpp2IlInjected.Token(Token = "0x60001EB")]
	[Cpp2IlInjected.Address(Slot = "122")]
	void JEJJNCIBMKD(object PDIBILKHEBM);

	[Cpp2IlInjected.Token(Token = "0x60001EC")]
	[Cpp2IlInjected.Address(Slot = "123")]
	void MPNABKADOLD(object PDIBILKHEBM);

	[Cpp2IlInjected.Token(Token = "0x60001ED")]
	[Cpp2IlInjected.Address(Slot = "124")]
	void IJKJHGBBCEG(Vector3 OFOIDDLLFEI, ForceMode OJEDHHILKEL = ForceMode.Force);

	[Cpp2IlInjected.Token(Token = "0x60001EE")]
	[Cpp2IlInjected.Address(Slot = "125")]
	void HIDBDPPDDNG(Vector3 OFOIDDLLFEI, Vector3 LPGLCEHEHMC, ForceMode OJEDHHILKEL);

	[Cpp2IlInjected.Token(Token = "0x60001EF")]
	[Cpp2IlInjected.Address(Slot = "126")]
	void FEDPGNOKGDK(Vector3 LGKLDHJLFFC, ForceMode OJEDHHILKEL = ForceMode.Force);

	[Cpp2IlInjected.Token(Token = "0x60001F0")]
	[Cpp2IlInjected.Address(Slot = "127")]
	void KBMMINBNLNN(Vector3 LGKLDHJLFFC, ForceMode OJEDHHILKEL = ForceMode.Force);

	[Cpp2IlInjected.Token(Token = "0x60001F1")]
	[Cpp2IlInjected.Address(Slot = "128")]
	bool BDBHIBJMAFO(Vector3 AKNDOLIKNGM, [Out] RaycastHit MGAKEPJNIDG, float IBOJBDBEJBJ);

	[Cpp2IlInjected.Token(Token = "0x60001F2")]
	[Cpp2IlInjected.Address(Slot = "129")]
	void BLJKMNBKPBO();
}
[Cpp2IlInjected.Token(Token = "0x2000027")]
public class FGCABOJBJBA : EHCMNHLPJBM, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400002C")]
	internal readonly IDMHNKCBNME PPJFGCMLNID;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400002D")]
	internal AEHPKHIMIDL KDBKOEIHBJM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400002E")]
	internal HFBOJOOMHLA IGJOIFGNKGG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400002F")]
	internal FHAABOAKHEB BAPALPGLNNA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000030")]
	internal EGNMEGPNLGB OBNDDJFFKOO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000031")]
	internal CLEHINCHHDE LJNAPAILPPB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000032")]
	internal KACNHFAPOGE EFGODHKHELK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000033")]
	internal HNFHIEOAONP OGNCIDPIBHP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000034")]
	internal HIIFMKKGLIL EDCPLEGFOPD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x4000035")]
	internal EKKHALEFJMB LBNCDIMCGME;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x4000036")]
	internal HFPBFKAEHJM KJLKAIKKMDA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x4000037")]
	internal AGCCBIKJDAK GNNPCEAHKGC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x4000038")]
	internal HEOOOHDIHMG OFOIDDLLFEI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
	[Cpp2IlInjected.Token(Token = "0x4000039")]
	internal ADPECGILELO LFJNNIHALPG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x400003A")]
	internal BJKCOGNFHAA IOJJIGGDNPN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
	[Cpp2IlInjected.Token(Token = "0x400003B")]
	internal AOENHBHLFIE DGPCIBHPCPF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
	[Cpp2IlInjected.Token(Token = "0x400003C")]
	internal IDisposable EHHEGAGKDPO;

	[Cpp2IlInjected.Token(Token = "0x17000084")]
	public RigidbodyEx PBDBDKAJEPD
	{
		[Cpp2IlInjected.Token(Token = "0x60001F3")]
		[Cpp2IlInjected.Address(RVA = "0x775E40", Offset = "0x774E40", VA = "0x180775E40", Slot = "5")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60001F4")]
		[Cpp2IlInjected.Address(RVA = "0x775EA0", Offset = "0x774EA0", VA = "0x180775EA0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000085")]
	public GameObject PHKAEJEKHIF
	{
		[Cpp2IlInjected.Token(Token = "0x60001F5")]
		[Cpp2IlInjected.Address(RVA = "0x806B90", Offset = "0x805B90", VA = "0x180806B90", Slot = "6")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60001F6")]
		[Cpp2IlInjected.Address(RVA = "0x806B70", Offset = "0x805B70", VA = "0x180806B70")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000086")]
	public Transform FHHLKDMADLC
	{
		[Cpp2IlInjected.Token(Token = "0x60001F7")]
		[Cpp2IlInjected.Address(RVA = "0x6375A50", Offset = "0x6374A50", VA = "0x186375A50", Slot = "7")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000087")]
	public Rigidbody JLNHKFKKICK
	{
		[Cpp2IlInjected.Token(Token = "0x60001F8")]
		[Cpp2IlInjected.Address(RVA = "0x6379760", Offset = "0x6378760", VA = "0x186379760", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000088")]
	public EHCMNHLPJBM CPGMADILNAD
	{
		[Cpp2IlInjected.Token(Token = "0x6000206")]
		[Cpp2IlInjected.Address(RVA = "0x63796B0", Offset = "0x63786B0", VA = "0x1863796B0", Slot = "8")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000207")]
		[Cpp2IlInjected.Address(RVA = "0x6376440", Offset = "0x6375440", VA = "0x186376440", Slot = "9")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000089")]
	public IReadOnlyList<EHCMNHLPJBM> NKNGGFCLKKC
	{
		[Cpp2IlInjected.Token(Token = "0x6000208")]
		[Cpp2IlInjected.Address(RVA = "0x6379810", Offset = "0x6378810", VA = "0x186379810", Slot = "10")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700008A")]
	public EHCMNHLPJBM FMAEDMDFLJE
	{
		[Cpp2IlInjected.Token(Token = "0x6000209")]
		[Cpp2IlInjected.Address(RVA = "0x6379AE0", Offset = "0x6378AE0", VA = "0x186379AE0", Slot = "11")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700008B")]
	public bool LAHBJHCBLCC
	{
		[Cpp2IlInjected.Token(Token = "0x600020A")]
		[Cpp2IlInjected.Address(RVA = "0x63785F0", Offset = "0x63775F0", VA = "0x1863785F0", Slot = "137")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700008C")]
	public bool GCPNKEIHNJF
	{
		[Cpp2IlInjected.Token(Token = "0x600020E")]
		[Cpp2IlInjected.Address(RVA = "0x637A310", Offset = "0x6379310", VA = "0x18637A310", Slot = "12")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700008D")]
	public bool FLDOPHCHFPM
	{
		[Cpp2IlInjected.Token(Token = "0x600020F")]
		[Cpp2IlInjected.Address(RVA = "0x6374B00", Offset = "0x6373B00", VA = "0x186374B00", Slot = "13")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700008E")]
	public AFBJPJGOHAH PAKEEKMBNJI
	{
		[Cpp2IlInjected.Token(Token = "0x6000210")]
		[Cpp2IlInjected.Address(RVA = "0x6377AF0", Offset = "0x6376AF0", VA = "0x186377AF0", Slot = "14")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000211")]
		[Cpp2IlInjected.Address(RVA = "0x6375670", Offset = "0x6374670", VA = "0x186375670", Slot = "15")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700008F")]
	public GAMCJHNBHDA CONGFAJKAFK
	{
		[Cpp2IlInjected.Token(Token = "0x6000212")]
		[Cpp2IlInjected.Address(RVA = "0x6377AA0", Offset = "0x6376AA0", VA = "0x186377AA0", Slot = "16")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000213")]
		[Cpp2IlInjected.Address(RVA = "0x637A830", Offset = "0x6379830", VA = "0x18637A830", Slot = "17")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000090")]
	public float CEJDFPIKKNH
	{
		[Cpp2IlInjected.Token(Token = "0x6000214")]
		[Cpp2IlInjected.Address(RVA = "0x6377610", Offset = "0x6376610", VA = "0x186377610", Slot = "18")]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x6000215")]
		[Cpp2IlInjected.Address(RVA = "0x63773F0", Offset = "0x63763F0", VA = "0x1863773F0", Slot = "19")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000091")]
	public Vector3 ONCBIGPFDBG
	{
		[Cpp2IlInjected.Token(Token = "0x6000216")]
		[Cpp2IlInjected.Address(RVA = "0x6378210", Offset = "0x6377210", VA = "0x186378210", Slot = "20")]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x6000217")]
		[Cpp2IlInjected.Address(RVA = "0x6377DC0", Offset = "0x6376DC0", VA = "0x186377DC0", Slot = "21")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000092")]
	public Vector3 DINKBHOHIJN
	{
		[Cpp2IlInjected.Token(Token = "0x6000218")]
		[Cpp2IlInjected.Address(RVA = "0x6379860", Offset = "0x6378860", VA = "0x186379860", Slot = "22")]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x6000219")]
		[Cpp2IlInjected.Address(RVA = "0x6377050", Offset = "0x6376050", VA = "0x186377050", Slot = "23")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000093")]
	public Vector3 JLKBIOAHEKE
	{
		[Cpp2IlInjected.Token(Token = "0x600021A")]
		[Cpp2IlInjected.Address(RVA = "0x6375770", Offset = "0x6374770", VA = "0x186375770", Slot = "24")]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x600021B")]
		[Cpp2IlInjected.Address(RVA = "0x6375C70", Offset = "0x6374C70", VA = "0x186375C70", Slot = "25")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000094")]
	public Vector3 ILEPAAIOGPH
	{
		[Cpp2IlInjected.Token(Token = "0x600021C")]
		[Cpp2IlInjected.Address(RVA = "0x6376BB0", Offset = "0x6375BB0", VA = "0x186376BB0", Slot = "26")]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x600021D")]
		[Cpp2IlInjected.Address(RVA = "0x6376970", Offset = "0x6375970", VA = "0x186376970", Slot = "27")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000095")]
	public bool APIOHOECOHN
	{
		[Cpp2IlInjected.Token(Token = "0x600021E")]
		[Cpp2IlInjected.Address(RVA = "0x6374AB0", Offset = "0x6373AB0", VA = "0x186374AB0", Slot = "138")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000096")]
	public bool CPKNHGNOJKA
	{
		[Cpp2IlInjected.Token(Token = "0x600021F")]
		[Cpp2IlInjected.Address(RVA = "0x6378740", Offset = "0x6377740", VA = "0x186378740", Slot = "28")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000097")]
	public bool OPNOHLFFIJB
	{
		[Cpp2IlInjected.Token(Token = "0x6000220")]
		[Cpp2IlInjected.Address(RVA = "0x6379260", Offset = "0x6378260", VA = "0x186379260", Slot = "29")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000098")]
	public bool CNPBCJLHPAJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000221")]
		[Cpp2IlInjected.Address(RVA = "0x6377450", Offset = "0x6376450", VA = "0x186377450", Slot = "30")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000099")]
	public Vector3 BGJFIEJBIJF
	{
		[Cpp2IlInjected.Token(Token = "0x6000232")]
		[Cpp2IlInjected.Address(RVA = "0x6378900", Offset = "0x6377900", VA = "0x186378900", Slot = "31")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700009A")]
	public Vector3 FLCGLBNKKAA
	{
		[Cpp2IlInjected.Token(Token = "0x6000233")]
		[Cpp2IlInjected.Address(RVA = "0x6375400", Offset = "0x6374400", VA = "0x186375400", Slot = "32")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700009B")]
	public Vector3 LADKEMIALFK
	{
		[Cpp2IlInjected.Token(Token = "0x6000238")]
		[Cpp2IlInjected.Address(RVA = "0x6378E60", Offset = "0x6377E60", VA = "0x186378E60", Slot = "33")]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x6000239")]
		[Cpp2IlInjected.Address(RVA = "0x63754E0", Offset = "0x63744E0", VA = "0x1863754E0", Slot = "34")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700009C")]
	public Vector3 PIICNOJNCPP
	{
		[Cpp2IlInjected.Token(Token = "0x600023A")]
		[Cpp2IlInjected.Address(RVA = "0x6375F40", Offset = "0x6374F40", VA = "0x186375F40", Slot = "35")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700009D")]
	public float DGAGBHADGJN
	{
		[Cpp2IlInjected.Token(Token = "0x600023B")]
		[Cpp2IlInjected.Address(RVA = "0x6376640", Offset = "0x6375640", VA = "0x186376640", Slot = "36")]
		get
		{
			return default(float);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700009E")]
	public float LLNDLOGDDIG
	{
		[Cpp2IlInjected.Token(Token = "0x600023C")]
		[Cpp2IlInjected.Address(RVA = "0x6377D70", Offset = "0x6376D70", VA = "0x186377D70", Slot = "37")]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x600023D")]
		[Cpp2IlInjected.Address(RVA = "0x6376CE0", Offset = "0x6375CE0", VA = "0x186376CE0", Slot = "38")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700009F")]
	public Vector3 HNOLHOHLFKJ
	{
		[Cpp2IlInjected.Token(Token = "0x600023E")]
		[Cpp2IlInjected.Address(RVA = "0x6374B50", Offset = "0x6373B50", VA = "0x186374B50", Slot = "39")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A0")]
	public Quaternion LONFIJLGBOG
	{
		[Cpp2IlInjected.Token(Token = "0x600023F")]
		[Cpp2IlInjected.Address(RVA = "0x6376E60", Offset = "0x6375E60", VA = "0x186376E60", Slot = "40")]
		get
		{
			return default(Quaternion);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A1")]
	public float EBALBFJEABI
	{
		[Cpp2IlInjected.Token(Token = "0x6000244")]
		[Cpp2IlInjected.Address(RVA = "0x6378E10", Offset = "0x6377E10", VA = "0x186378E10", Slot = "42")]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x6000245")]
		[Cpp2IlInjected.Address(RVA = "0x63772E0", Offset = "0x63762E0", VA = "0x1863772E0", Slot = "43")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A2")]
	public float FBKHGEIFEEL
	{
		[Cpp2IlInjected.Token(Token = "0x6000246")]
		[Cpp2IlInjected.Address(RVA = "0x63763F0", Offset = "0x63753F0", VA = "0x1863763F0", Slot = "44")]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x6000247")]
		[Cpp2IlInjected.Address(RVA = "0x63774A0", Offset = "0x63764A0", VA = "0x1863774A0", Slot = "45")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A3")]
	public bool BJICAJLOKDG
	{
		[Cpp2IlInjected.Token(Token = "0x6000248")]
		[Cpp2IlInjected.Address(RVA = "0x63756D0", Offset = "0x63746D0", VA = "0x1863756D0", Slot = "46")]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000249")]
		[Cpp2IlInjected.Address(RVA = "0x63766E0", Offset = "0x63756E0", VA = "0x1863766E0", Slot = "47")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A4")]
	public BAGHKPJGLEA HJLBEPGNACN
	{
		[Cpp2IlInjected.Token(Token = "0x6000251")]
		[Cpp2IlInjected.Address(RVA = "0x63789D0", Offset = "0x63779D0", VA = "0x1863789D0", Slot = "48")]
		get
		{
			return default(BAGHKPJGLEA);
		}
		[Cpp2IlInjected.Token(Token = "0x6000252")]
		[Cpp2IlInjected.Address(RVA = "0x6377340", Offset = "0x6376340", VA = "0x186377340", Slot = "49")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A5")]
	public bool KFMBBJLEAJK
	{
		[Cpp2IlInjected.Token(Token = "0x6000255")]
		[Cpp2IlInjected.Address(RVA = "0x6375620", Offset = "0x6374620", VA = "0x186375620", Slot = "50")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A6")]
	public Transform GCGFCFBOGAL
	{
		[Cpp2IlInjected.Token(Token = "0x600025C")]
		[Cpp2IlInjected.Address(RVA = "0x63785E0", Offset = "0x63775E0", VA = "0x1863785E0", Slot = "51")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A7")]
	public Vector3 LAFFMBPMCBK
	{
		[Cpp2IlInjected.Token(Token = "0x600025D")]
		[Cpp2IlInjected.Address(RVA = "0x6379C70", Offset = "0x6378C70", VA = "0x186379C70", Slot = "52")]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x600025E")]
		[Cpp2IlInjected.Address(RVA = "0x6377B40", Offset = "0x6376B40", VA = "0x186377B40", Slot = "53")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A8")]
	public float ABAAKHNHDME
	{
		[Cpp2IlInjected.Token(Token = "0x600025F")]
		[Cpp2IlInjected.Address(RVA = "0x637A5C0", Offset = "0x63795C0", VA = "0x18637A5C0", Slot = "54")]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x6000260")]
		[Cpp2IlInjected.Address(RVA = "0x63790A0", Offset = "0x63780A0", VA = "0x1863790A0", Slot = "55")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A9")]
	public float JFAHGDFBNGK
	{
		[Cpp2IlInjected.Token(Token = "0x6000261")]
		[Cpp2IlInjected.Address(RVA = "0x6378720", Offset = "0x6377720", VA = "0x186378720", Slot = "56")]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x6000262")]
		[Cpp2IlInjected.Address(RVA = "0x6375850", Offset = "0x6374850", VA = "0x186375850", Slot = "57")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000AA")]
	public Quaternion NBMJCMLBMDE
	{
		[Cpp2IlInjected.Token(Token = "0x6000263")]
		[Cpp2IlInjected.Address(RVA = "0x6376FA0", Offset = "0x6375FA0", VA = "0x186376FA0", Slot = "58")]
		get
		{
			return default(Quaternion);
		}
		[Cpp2IlInjected.Token(Token = "0x6000264")]
		[Cpp2IlInjected.Address(RVA = "0x6374DA0", Offset = "0x6373DA0", VA = "0x186374DA0", Slot = "59")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000AB")]
	public Vector3 LGOPKPGLOLL
	{
		[Cpp2IlInjected.Token(Token = "0x6000265")]
		[Cpp2IlInjected.Address(RVA = "0x63787A0", Offset = "0x63777A0", VA = "0x1863787A0", Slot = "60")]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x6000266")]
		[Cpp2IlInjected.Address(RVA = "0x6376E10", Offset = "0x6375E10", VA = "0x186376E10", Slot = "61")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000AC")]
	public Quaternion JGPPPKPPDBC
	{
		[Cpp2IlInjected.Token(Token = "0x6000267")]
		[Cpp2IlInjected.Address(RVA = "0x6377130", Offset = "0x6376130", VA = "0x186377130", Slot = "62")]
		get
		{
			return default(Quaternion);
		}
		[Cpp2IlInjected.Token(Token = "0x6000268")]
		[Cpp2IlInjected.Address(RVA = "0x6379670", Offset = "0x6378670", VA = "0x186379670", Slot = "63")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000AD")]
	public RigidbodyConstraints NPGAMCBNMHD
	{
		[Cpp2IlInjected.Token(Token = "0x600026C")]
		[Cpp2IlInjected.Address(RVA = "0x63783D0", Offset = "0x63773D0", VA = "0x1863783D0", Slot = "64")]
		get
		{
			return default(RigidbodyConstraints);
		}
		[Cpp2IlInjected.Token(Token = "0x600026D")]
		[Cpp2IlInjected.Address(RVA = "0x6374E90", Offset = "0x6373E90", VA = "0x186374E90", Slot = "65")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000AE")]
	public bool MIOAIPJJMGG
	{
		[Cpp2IlInjected.Token(Token = "0x600026E")]
		[Cpp2IlInjected.Address(RVA = "0x6377D20", Offset = "0x6376D20", VA = "0x186377D20", Slot = "66")]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x600026F")]
		[Cpp2IlInjected.Address(RVA = "0x6377280", Offset = "0x6376280", VA = "0x186377280", Slot = "67")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000AF")]
	public CollisionDetectionMode MHGBGHOHCOK
	{
		[Cpp2IlInjected.Token(Token = "0x6000278")]
		[Cpp2IlInjected.Address(RVA = "0x637A890", Offset = "0x6379890", VA = "0x18637A890", Slot = "68")]
		get
		{
			return default(CollisionDetectionMode);
		}
		[Cpp2IlInjected.Token(Token = "0x6000279")]
		[Cpp2IlInjected.Address(RVA = "0x6379700", Offset = "0x6378700", VA = "0x186379700", Slot = "69")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B0")]
	public bool ECAGBOEDCGJ
	{
		[Cpp2IlInjected.Token(Token = "0x600027B")]
		[Cpp2IlInjected.Address(RVA = "0x637A1D0", Offset = "0x63791D0", VA = "0x18637A1D0", Slot = "139")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B1")]
	public bool JEPMPAKBHKE
	{
		[Cpp2IlInjected.Token(Token = "0x600027C")]
		[Cpp2IlInjected.Address(RVA = "0x63793A0", Offset = "0x63783A0", VA = "0x1863793A0", Slot = "70")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B2")]
	public bool KKOLMFNJMJF
	{
		[Cpp2IlInjected.Token(Token = "0x600027D")]
		[Cpp2IlInjected.Address(RVA = "0x63768D0", Offset = "0x63758D0", VA = "0x1863768D0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B3")]
	public bool CPEPNLBHFFM
	{
		[Cpp2IlInjected.Token(Token = "0x600027E")]
		[Cpp2IlInjected.Address(RVA = "0x6374A60", Offset = "0x6373A60", VA = "0x186374A60")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000021")]
	public event ODMKMIKDLDH HNIODPCALEE
	{
		[Cpp2IlInjected.Token(Token = "0x6000200")]
		[Cpp2IlInjected.Address(RVA = "0x6379110", Offset = "0x6378110", VA = "0x186379110", Slot = "75")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000201")]
		[Cpp2IlInjected.Address(RVA = "0x6377660", Offset = "0x6376660", VA = "0x186377660", Slot = "76")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000022")]
	public event ODMKMIKDLDH ICDJPNDLGPD
	{
		[Cpp2IlInjected.Token(Token = "0x6000202")]
		[Cpp2IlInjected.Address(RVA = "0x6377500", Offset = "0x6376500", VA = "0x186377500", Slot = "77")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000203")]
		[Cpp2IlInjected.Address(RVA = "0x6376DB0", Offset = "0x6375DB0", VA = "0x186376DB0", Slot = "78")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000023")]
	public event LNHELIADCNA JAPGMOHDICK
	{
		[Cpp2IlInjected.Token(Token = "0x6000204")]
		[Cpp2IlInjected.Address(RVA = "0x637A440", Offset = "0x6379440", VA = "0x18637A440", Slot = "79")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000205")]
		[Cpp2IlInjected.Address(RVA = "0x63797B0", Offset = "0x63787B0", VA = "0x1863797B0", Slot = "80")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000024")]
	public event ODMKMIKDLDH GIADDJGCKPO
	{
		[Cpp2IlInjected.Token(Token = "0x600020C")]
		[Cpp2IlInjected.Address(RVA = "0x6376A50", Offset = "0x6375A50", VA = "0x186376A50", Slot = "82")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600020D")]
		[Cpp2IlInjected.Address(RVA = "0x637A4A0", Offset = "0x63794A0", VA = "0x18637A4A0", Slot = "83")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000025")]
	public event ODMKMIKDLDH GFDLDDIJKHF
	{
		[Cpp2IlInjected.Token(Token = "0x6000236")]
		[Cpp2IlInjected.Address(RVA = "0x637A500", Offset = "0x6379500", VA = "0x18637A500", Slot = "102")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000237")]
		[Cpp2IlInjected.Address(RVA = "0x63765E0", Offset = "0x63755E0", VA = "0x1863765E0", Slot = "103")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000026")]
	public event ODMKMIKDLDH AGBEMFNHAAD
	{
		[Cpp2IlInjected.Token(Token = "0x600024A")]
		[Cpp2IlInjected.Address(RVA = "0x63755C0", Offset = "0x63745C0", VA = "0x1863755C0", Slot = "107")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600024B")]
		[Cpp2IlInjected.Address(RVA = "0x6377C60", Offset = "0x6376C60", VA = "0x186377C60", Slot = "108")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000027")]
	public event Action<FDHMLINJMLJ, FDHMLINJMLJ> IOALOLNJHBM
	{
		[Cpp2IlInjected.Token(Token = "0x600024F")]
		[Cpp2IlInjected.Address(RVA = "0x6379340", Offset = "0x6378340", VA = "0x186379340", Slot = "111")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000250")]
		[Cpp2IlInjected.Address(RVA = "0x63776C0", Offset = "0x63766C0", VA = "0x1863776C0", Slot = "112")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000028")]
	public event ODMKMIKDLDH IJHOLLBGJPD
	{
		[Cpp2IlInjected.Token(Token = "0x6000253")]
		[Cpp2IlInjected.Address(RVA = "0x6375C10", Offset = "0x6374C10", VA = "0x186375C10", Slot = "113")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000254")]
		[Cpp2IlInjected.Address(RVA = "0x637A560", Offset = "0x6379560", VA = "0x18637A560", Slot = "114")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000029")]
	public event ODMKMIKDLDH EKOMCGBKAOG
	{
		[Cpp2IlInjected.Token(Token = "0x600025A")]
		[Cpp2IlInjected.Address(RVA = "0x6378530", Offset = "0x6377530", VA = "0x186378530", Slot = "119")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600025B")]
		[Cpp2IlInjected.Address(RVA = "0x6378480", Offset = "0x6377480", VA = "0x186378480", Slot = "120")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001F9")]
	[Cpp2IlInjected.Address(RVA = "0x637A920", Offset = "0x6379920", VA = "0x18637A920")]
	public FGCABOJBJBA(GameObject GFBHJHHLEFD, RigidbodyEx PFIDAIAGHJK, IDMHNKCBNME PPJFGCMLNID, [In] OJNOICCBOJO FCLEEDACIMH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001FA")]
	[Cpp2IlInjected.Address(RVA = "0x6379EE0", Offset = "0x6378EE0", VA = "0x186379EE0", Slot = "135")]
	protected virtual void ODEHOFGDECA(IDMHNKCBNME PPJFGCMLNID, OJNOICCBOJO FCLEEDACIMH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001FB")]
	[Cpp2IlInjected.Address(RVA = "0x6376020", Offset = "0x6375020", VA = "0x186376020", Slot = "136")]
	public virtual void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001FC")]
	[Cpp2IlInjected.Address(RVA = "0x6379B30", Offset = "0x6378B30", VA = "0x186379B30", Slot = "71")]
	public void NPFDHKEDPBK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001FD")]
	[Cpp2IlInjected.Address(RVA = "0x6375AE0", Offset = "0x6374AE0", VA = "0x186375AE0", Slot = "72")]
	public void DHFPKEPDKMD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001FE")]
	[Cpp2IlInjected.Address(RVA = "0x6374A90", Offset = "0x6373A90", VA = "0x186374A90", Slot = "73")]
	public void ACFAANOHPBB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001FF")]
	[Cpp2IlInjected.Address(RVA = "0x6376820", Offset = "0x6375820", VA = "0x186376820")]
	private void FLBMAAPGJBA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600020B")]
	[Cpp2IlInjected.Address(RVA = "0x6376F30", Offset = "0x6375F30", VA = "0x186376F30", Slot = "81")]
	public void GLKDGJFHDGI(EHCMNHLPJBM APPJEOKOGAK, bool FMNAIIPBFHC = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000222")]
	[Cpp2IlInjected.Address(RVA = "0x637A5E0", Offset = "0x63795E0", VA = "0x18637A5E0", Slot = "84")]
	public void PLEAHDIMCIE(object PDIBILKHEBM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000223")]
	[Cpp2IlInjected.Address(RVA = "0x6377CC0", Offset = "0x6376CC0", VA = "0x186377CC0", Slot = "85")]
	public void JJAALHAEDJD(object PDIBILKHEBM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000224")]
	[Cpp2IlInjected.Address(RVA = "0x63762F0", Offset = "0x63752F0", VA = "0x1863762F0", Slot = "86")]
	public Vector3 ECOHLCBCAIO(Vector3 IACNFCFIIOM)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000225")]
	[Cpp2IlInjected.Address(RVA = "0x6376AB0", Offset = "0x6375AB0", VA = "0x186376AB0", Slot = "87")]
	public Vector3 FNKNMFKCFHO(Vector3 GMLDNFHDNJP)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000226")]
	[Cpp2IlInjected.Address(RVA = "0x6375AE0", Offset = "0x6374AE0", VA = "0x186375AE0", Slot = "88")]
	public void MBDGEAIJODJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000227")]
	[Cpp2IlInjected.Address(RVA = "0x6376C90", Offset = "0x6375C90", VA = "0x186376C90", Slot = "89")]
	public void GAMMNKDKDMP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000228")]
	[Cpp2IlInjected.Address(RVA = "0x6374EF0", Offset = "0x6373EF0", VA = "0x186374EF0", Slot = "90")]
	public void BCBGBGNDMKE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000229")]
	[Cpp2IlInjected.Address(RVA = "0x6379170", Offset = "0x6378170", VA = "0x186379170", Slot = "91")]
	public void MLEAMOMCHPM(Vector3 PFBOCMNHECB, Vector3 EGGKDKAICGO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600022A")]
	[Cpp2IlInjected.Address(RVA = "0x6379580", Offset = "0x6378580", VA = "0x186379580", Slot = "92")]
	public void NADJGLGOMJF(Vector3 ACIPBFHCAAA, Vector3 PLLAPIPLOBE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600022B")]
	[Cpp2IlInjected.Address(RVA = "0x63782F0", Offset = "0x63772F0", VA = "0x1863782F0", Slot = "93")]
	public void KEIBJNKFFKK(Vector3 BCLKICLJPAP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600022C")]
	[Cpp2IlInjected.Address(RVA = "0x6377900", Offset = "0x6376900", VA = "0x186377900", Slot = "94")]
	public void IHIBCDABGEA(BOLJBMMECOE DBGBHNOCNJE, Vector3 HGEDCNMOIAN, float NBBOEEPKJMP, float MFOFCNBGOEE = 8f, float JKNAHEBOBHM = 1f)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600022D")]
	[Cpp2IlInjected.Address(RVA = "0x63764A0", Offset = "0x63754A0", VA = "0x1863764A0", Slot = "95")]
	public void EHCOAACKECM(LGPMEMPGHMC CFIODOIHFKI, Vector3 POKFEHNNFOH, float NLCECILHIIF = float.PositiveInfinity)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600022E")]
	[Cpp2IlInjected.Address(RVA = "0x6377560", Offset = "0x6376560", VA = "0x186377560", Slot = "96")]
	[Obsolete("Deprecated. Still exists to support deprecated CV2 chips. Use ApplyAngularVelocityChange.")]
	public void IAGIBKOHJDJ(LGPMEMPGHMC CFIODOIHFKI, Vector3 LGOFCBEILGM, float DPKKDMEAKFE = 7f, float DLNPOBOGDPN = 1f)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600022F")]
	[Cpp2IlInjected.Address(RVA = "0x6379990", Offset = "0x6378990", VA = "0x186379990", Slot = "97")]
	public Vector3 NKFAKMKMGLK(Vector3 APPJEOKOGAK)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000230")]
	[Cpp2IlInjected.Address(RVA = "0x6378FA0", Offset = "0x6377FA0", VA = "0x186378FA0", Slot = "98")]
	public Vector3 MHKJOCEAOOK(Vector3 APPJEOKOGAK)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000231")]
	[Cpp2IlInjected.Address(RVA = "0x6375720", Offset = "0x6374720", VA = "0x186375720", Slot = "99")]
	public void DACCEJMCHOM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000234")]
	[Cpp2IlInjected.Address(RVA = "0x6378650", Offset = "0x6377650", VA = "0x186378650", Slot = "100")]
	public void LIMAGEHFCDJ(EHCMNHLPJBM OHPBKIJPBEH, object PDIBILKHEBM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000235")]
	[Cpp2IlInjected.Address(RVA = "0x6378F40", Offset = "0x6377F40", VA = "0x186378F40", Slot = "101")]
	public void MHICMANCFJE(object PDIBILKHEBM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000240")]
	[Cpp2IlInjected.Address(RVA = "0x637A360", Offset = "0x6379360", VA = "0x18637A360", Slot = "41")]
	public void PECPHAKBJCG((Quaternion rot, Vector3 moments) IJPGGILEIIN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000241")]
	[Cpp2IlInjected.Address(RVA = "0x6376590", Offset = "0x6375590", VA = "0x186376590", Slot = "104")]
	public void EMOEILKEJBE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000242")]
	[Cpp2IlInjected.Address(RVA = "0x6379940", Offset = "0x6378940", VA = "0x186379940", Slot = "105")]
	public void NKANMLKMEBG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000243")]
	[Cpp2IlInjected.Address(RVA = "0x6376690", Offset = "0x6375690", VA = "0x186376690", Slot = "106")]
	public void FAMCOJOMDOD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600024C")]
	[Cpp2IlInjected.Address(RVA = "0x6379A90", Offset = "0x6378A90", VA = "0x186379A90", Slot = "109")]
	public bool NKFKNEFDAFK()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600024D")]
	[Cpp2IlInjected.Address(RVA = "0x6376540", Offset = "0x6375540", VA = "0x186376540", Slot = "74")]
	public void EIHNIBFOFFJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600024E")]
	[Cpp2IlInjected.Address(RVA = "0x6377FB0", Offset = "0x6376FB0", VA = "0x186377FB0", Slot = "110")]
	public void JPMGMMIEBBB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000256")]
	[Cpp2IlInjected.Address(RVA = "0x63773A0", Offset = "0x63763A0", VA = "0x1863773A0", Slot = "115")]
	public IDisposable HLJKBPAJOBH()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000257")]
	[Cpp2IlInjected.Address(RVA = "0x6377F50", Offset = "0x6376F50", VA = "0x186377F50", Slot = "116")]
	public void JPFGFDECHOJ(object PDIBILKHEBM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000258")]
	[Cpp2IlInjected.Address(RVA = "0x6378000", Offset = "0x6377000", VA = "0x186378000", Slot = "117")]
	public void KAPPGEIEJKO(object PDIBILKHEBM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000259")]
	[Cpp2IlInjected.Address(RVA = "0x6376D40", Offset = "0x6375D40", VA = "0x186376D40", Slot = "118")]
	public void GJJAJKOMBNJ(object PDIBILKHEBM, bool GKHMPKCJGHP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000269")]
	[Cpp2IlInjected.Address(RVA = "0x63760F0", Offset = "0x63750F0", VA = "0x1863760F0", Slot = "121")]
	public void EBAFIDPJBLL(Vector3 LMCNGGBBGAK, Quaternion LJGGLNEHBNN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600026A")]
	[Cpp2IlInjected.Address(RVA = "0x637A6E0", Offset = "0x63796E0", VA = "0x18637A6E0", Slot = "122")]
	public void PMLIDMGNBMJ(Vector3 AGFHJEELBOM, Quaternion DBJKCMEGHMK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600026B")]
	[Cpp2IlInjected.Address(RVA = "0x63786C0", Offset = "0x63776C0", VA = "0x1863786C0", Slot = "123")]
	public bool LKLNFACJBJF(float MGEAGKCABGB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000270")]
	[Cpp2IlInjected.Address(RVA = "0x6378420", Offset = "0x6377420", VA = "0x186378420", Slot = "124")]
	public void KMEFLHLDIKM(object PDIBILKHEBM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000271")]
	[Cpp2IlInjected.Address(RVA = "0x6375350", Offset = "0x6374350", VA = "0x186375350", Slot = "125")]
	public void BKKCKHAEOCM(object PDIBILKHEBM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000272")]
	[Cpp2IlInjected.Address(RVA = "0x6377C00", Offset = "0x6376C00", VA = "0x186377C00", Slot = "126")]
	public void JEJJNCIBMKD(object PDIBILKHEBM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000273")]
	[Cpp2IlInjected.Address(RVA = "0x6379520", Offset = "0x6378520", VA = "0x186379520", Slot = "127")]
	public void MPNABKADOLD(object PDIBILKHEBM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000274")]
	[Cpp2IlInjected.Address(RVA = "0x63779C0", Offset = "0x63769C0", VA = "0x1863779C0", Slot = "128")]
	public void IJKJHGBBCEG(Vector3 OFOIDDLLFEI, ForceMode OJEDHHILKEL = ForceMode.Force)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000275")]
	[Cpp2IlInjected.Address(RVA = "0x6377170", Offset = "0x6376170", VA = "0x186377170", Slot = "129")]
	public void HIDBDPPDDNG(Vector3 OFOIDDLLFEI, Vector3 LPGLCEHEHMC, ForceMode OJEDHHILKEL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000276")]
	[Cpp2IlInjected.Address(RVA = "0x6376740", Offset = "0x6375740", VA = "0x186376740", Slot = "130")]
	public void FEDPGNOKGDK(Vector3 LGKLDHJLFFC, ForceMode OJEDHHILKEL = ForceMode.Force)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000277")]
	[Cpp2IlInjected.Address(RVA = "0x6378130", Offset = "0x6377130", VA = "0x186378130", Slot = "131")]
	public void KBMMINBNLNN(Vector3 LGKLDHJLFFC, ForceMode OJEDHHILKEL = ForceMode.Force)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600027A")]
	[Cpp2IlInjected.Address(RVA = "0x6374F40", Offset = "0x6373F40", VA = "0x186374F40", Slot = "132")]
	public bool BDBHIBJMAFO(Vector3 AKNDOLIKNGM, [Out] RaycastHit MGAKEPJNIDG, float IBOJBDBEJBJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600027F")]
	[Cpp2IlInjected.Address(RVA = "0x63753B0", Offset = "0x63743B0", VA = "0x1863753B0", Slot = "133")]
	public void BLJKMNBKPBO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000280")]
	[Cpp2IlInjected.Address(RVA = "0x637A8E0", Offset = "0x63798E0", VA = "0x18637A8E0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000281")]
	[Cpp2IlInjected.Address(RVA = "0x6375B30", Offset = "0x6374B30", VA = "0x186375B30")]
	private void DHOADIFLDEO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000282")]
	[Cpp2IlInjected.Address(RVA = "0x63787F0", Offset = "0x63777F0", VA = "0x1863787F0")]
	private void MADPEAAFNHO(EHCMNHLPJBM IGPIMCJILMM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000283")]
	[Cpp2IlInjected.Address(RVA = "0x6375D50", Offset = "0x6374D50", VA = "0x186375D50")]
	private void DMINBOCIGCE(EHCMNHLPJBM IGPIMCJILMM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000284")]
	[Cpp2IlInjected.Address(RVA = "0x6377EA0", Offset = "0x6376EA0", VA = "0x186377EA0")]
	private void JNLDAKNPCKG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000285")]
	[Cpp2IlInjected.Address(RVA = "0x6375950", Offset = "0x6374950", VA = "0x186375950")]
	private void DEPIIBIOJNL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000286")]
	[Cpp2IlInjected.Address(RVA = "0x6377720", Offset = "0x6376720", VA = "0x186377720")]
	private void IHBLDDHPLFG(EHCMNHLPJBM NLMONBKCPDM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000287")]
	[Cpp2IlInjected.Address(RVA = "0x6378D40", Offset = "0x6377D40", VA = "0x186378D40")]
	private void MFCPKNBIHKM(EHCMNHLPJBM IGPIMCJILMM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000288")]
	[Cpp2IlInjected.Address(RVA = "0x6378060", Offset = "0x6377060", VA = "0x186378060")]
	private void KBIEHHBCMLI(EHCMNHLPJBM IGPIMCJILMM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000289")]
	[Cpp2IlInjected.Address(RVA = "0x6374C30", Offset = "0x6373C30", VA = "0x186374C30")]
	private void AJPKJMLGPMN(RigidbodyEx IGPIMCJILMM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600028A")]
	[Cpp2IlInjected.Address(RVA = "0x6379D20", Offset = "0x6378D20", VA = "0x186379D20", Slot = "140")]
	protected virtual void OBEHIOJJCBD(RigidbodyEx ECLMPMCOOIA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600028B")]
	[Cpp2IlInjected.Address(RVA = "0x6378A20", Offset = "0x6377A20", VA = "0x186378A20")]
	protected void MEOEDMPEADI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600028C")]
	[Cpp2IlInjected.Address(RVA = "0x6374FE0", Offset = "0x6373FE0", VA = "0x186374FE0")]
	protected void BGOLAHMBNEB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600028D")]
	[Cpp2IlInjected.Address(RVA = "0x637A640", Offset = "0x6379640", VA = "0x18637A640", Slot = "141")]
	protected virtual IDisposable PLIPGHDOALO()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000028")]
internal static class BBJCJKFHCAP
{
	[Cpp2IlInjected.Token(Token = "0x600028E")]
	[Cpp2IlInjected.Address(RVA = "0x6371420", Offset = "0x6370420", VA = "0x186371420")]
	public static EHCMNHLPJBM AAIIAFIMHKH(this EHCMNHLPJBM ECLMPMCOOIA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600028F")]
	[Cpp2IlInjected.Address(RVA = "0x63715D0", Offset = "0x63705D0", VA = "0x1863715D0")]
	public static bool NEABLKFDNJM(this EHCMNHLPJBM ECLMPMCOOIA, EHCMNHLPJBM BAFBAAPFNBC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000290")]
	[Cpp2IlInjected.Address(RVA = "0x6371550", Offset = "0x6370550", VA = "0x186371550")]
	public static bool GOIPILHGFIL(this EHCMNHLPJBM ECLMPMCOOIA, EHCMNHLPJBM IPFACJGLCKI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000291")]
	[Cpp2IlInjected.Address(RVA = "0x6371650", Offset = "0x6370650", VA = "0x186371650")]
	public static RigidbodyEx PBDBDKAJEPD(this EHCMNHLPJBM FHKOMFPHENB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000292")]
	[Cpp2IlInjected.Address(RVA = "0x63714D0", Offset = "0x63704D0", VA = "0x1863714D0")]
	public static FGCABOJBJBA CFPHFCEKCPJ(this EHCMNHLPJBM KKOFNCEIKDA)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000029")]
internal class PEAGPOFNCDL : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000040")]
	private readonly FGCABOJBJBA ECLMPMCOOIA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000041")]
	private bool BKIGCJKEOGE;

	[Cpp2IlInjected.Token(Token = "0x6000293")]
	[Cpp2IlInjected.Address(RVA = "0x63946F0", Offset = "0x63936F0", VA = "0x1863946F0")]
	public PEAGPOFNCDL(FGCABOJBJBA MGOBBEHMAHK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000294")]
	[Cpp2IlInjected.Address(RVA = "0x6394690", Offset = "0x6393690", VA = "0x186394690", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002A")]
internal sealed class JOCDEFMJNJH : MCAGBJFDKAD, AOENHBHLFIE
{
	[Cpp2IlInjected.Token(Token = "0x170000B4")]
	private CollisionDetectionMode OOHLJDCMCEL
	{
		[Cpp2IlInjected.Token(Token = "0x6000296")]
		[Cpp2IlInjected.Address(RVA = "0x6381C70", Offset = "0x6380C70", VA = "0x186381C70")]
		get
		{
			return default(CollisionDetectionMode);
		}
		[Cpp2IlInjected.Token(Token = "0x6000297")]
		[Cpp2IlInjected.Address(RVA = "0x6381790", Offset = "0x6380790", VA = "0x186381790")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B5")]
	private Rigidbody JLNHKFKKICK
	{
		[Cpp2IlInjected.Token(Token = "0x6000298")]
		[Cpp2IlInjected.Address(RVA = "0x6371000", Offset = "0x6370000", VA = "0x186371000")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B6")]
	public CollisionDetectionMode MHGBGHOHCOK
	{
		[Cpp2IlInjected.Token(Token = "0x600029B")]
		[Cpp2IlInjected.Address(RVA = "0x6381CD0", Offset = "0x6380CD0", VA = "0x186381CD0", Slot = "4")]
		get
		{
			return default(CollisionDetectionMode);
		}
		[Cpp2IlInjected.Token(Token = "0x600029C")]
		[Cpp2IlInjected.Address(RVA = "0x6381A60", Offset = "0x6380A60", VA = "0x186381A60", Slot = "5")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000295")]
	[Cpp2IlInjected.Address(RVA = "0x637B210", Offset = "0x637A210", VA = "0x18637B210")]
	public JOCDEFMJNJH(EHCMNHLPJBM ECLMPMCOOIA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000299")]
	[Cpp2IlInjected.Address(RVA = "0x6381B20", Offset = "0x6380B20", VA = "0x186381B20", Slot = "6")]
	public void NPFDHKEDPBK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600029A")]
	[Cpp2IlInjected.Address(RVA = "0x6381810", Offset = "0x6380810", VA = "0x186381810", Slot = "9")]
	public void KHNKJFJMFFM(Rigidbody IOJJIGGDNPN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600029D")]
	[Cpp2IlInjected.Address(RVA = "0x6381620", Offset = "0x6380620", VA = "0x186381620", Slot = "7")]
	public void ABGJLAGAKOI(bool NGGMOCIINFJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600029E")]
	[Cpp2IlInjected.Address(RVA = "0x6381800", Offset = "0x6380800", VA = "0x186381800", Slot = "8")]
	public void HDDNNCNNJMB(bool NGGMOCIINFJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600029F")]
	[Cpp2IlInjected.Address(RVA = "0x6381630", Offset = "0x6380630", VA = "0x186381630", Slot = "10")]
	public bool BDBHIBJMAFO(Vector3 AKNDOLIKNGM, [Out] RaycastHit MGAKEPJNIDG, float IBOJBDBEJBJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002A0")]
	[Cpp2IlInjected.Address(RVA = "0x63818F0", Offset = "0x63808F0", VA = "0x1863818F0")]
	private void LFDLDGCOCKL(bool NGGMOCIINFJ)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002B")]
internal sealed class GFHHAOONJIF : MCAGBJFDKAD, HFPBFKAEHJM, IDisposable, NAMDOKCHCKG
{
	[Cpp2IlInjected.Token(Token = "0x170000B7")]
	public BAGHKPJGLEA PMOMPOFEIKB
	{
		[Cpp2IlInjected.Token(Token = "0x60002A4")]
		[Cpp2IlInjected.Address(RVA = "0x637BDA0", Offset = "0x637ADA0", VA = "0x18637BDA0")]
		get
		{
			return default(BAGHKPJGLEA);
		}
		[Cpp2IlInjected.Token(Token = "0x60002A5")]
		[Cpp2IlInjected.Address(RVA = "0x637BE80", Offset = "0x637AE80", VA = "0x18637BE80")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B8")]
	public BAGHKPJGLEA HJLBEPGNACN
	{
		[Cpp2IlInjected.Token(Token = "0x60002A6")]
		[Cpp2IlInjected.Address(RVA = "0x637C020", Offset = "0x637B020", VA = "0x18637C020", Slot = "6")]
		get
		{
			return default(BAGHKPJGLEA);
		}
		[Cpp2IlInjected.Token(Token = "0x60002A7")]
		[Cpp2IlInjected.Address(RVA = "0x637BE80", Offset = "0x637AE80", VA = "0x18637BE80", Slot = "7")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B9")]
	private Transform DNBECLOOEFA
	{
		[Cpp2IlInjected.Token(Token = "0x60002AC")]
		[Cpp2IlInjected.Address(RVA = "0x770CC0", Offset = "0x76FCC0", VA = "0x180770CC0", Slot = "10")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400002A")]
	public event Action<FDHMLINJMLJ, FDHMLINJMLJ> IOALOLNJHBM
	{
		[Cpp2IlInjected.Token(Token = "0x60002A2")]
		[Cpp2IlInjected.Address(RVA = "0x637C220", Offset = "0x637B220", VA = "0x18637C220", Slot = "4")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60002A3")]
		[Cpp2IlInjected.Address(RVA = "0x637BF70", Offset = "0x637AF70", VA = "0x18637BF70", Slot = "5")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60002A1")]
	[Cpp2IlInjected.Address(RVA = "0x637B210", Offset = "0x637A210", VA = "0x18637B210")]
	public GFHHAOONJIF(EHCMNHLPJBM ECLMPMCOOIA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002A8")]
	[Cpp2IlInjected.Address(RVA = "0x637C2D0", Offset = "0x637B2D0", VA = "0x18637C2D0", Slot = "11")]
	public void OnChangedDistanceBand(FDHMLINJMLJ MJGALODGAME, FDHMLINJMLJ NMFMKGLEEKB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002A9")]
	[Cpp2IlInjected.Address(RVA = "0x770CB0", Offset = "0x76FCB0", VA = "0x180770CB0", Slot = "12")]
	public void OnChangedVisibility(bool NKBJCONEJKF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002AA")]
	[Cpp2IlInjected.Address(RVA = "0x770CB0", Offset = "0x76FCB0", VA = "0x180770CB0", Slot = "8")]
	public void NPFDHKEDPBK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002AB")]
	[Cpp2IlInjected.Address(RVA = "0x770CB0", Offset = "0x76FCB0", VA = "0x180770CB0", Slot = "9")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002C")]
internal sealed class GIHMOGNONIK : MCAGBJFDKAD, HEOOOHDIHMG
{
	[Cpp2IlInjected.Token(Token = "0x170000BA")]
	private Rigidbody JLNHKFKKICK
	{
		[Cpp2IlInjected.Token(Token = "0x60002AE")]
		[Cpp2IlInjected.Address(RVA = "0x6371000", Offset = "0x6370000", VA = "0x186371000")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000BB")]
	private bool KFMBBJLEAJK
	{
		[Cpp2IlInjected.Token(Token = "0x60002AF")]
		[Cpp2IlInjected.Address(RVA = "0x637C2F0", Offset = "0x637B2F0", VA = "0x18637C2F0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000BC")]
	private bool LAHBJHCBLCC
	{
		[Cpp2IlInjected.Token(Token = "0x60002B0")]
		[Cpp2IlInjected.Address(RVA = "0x6370230", Offset = "0x636F230", VA = "0x186370230")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000BD")]
	private EHCMNHLPJBM CPGMADILNAD
	{
		[Cpp2IlInjected.Token(Token = "0x60002B1")]
		[Cpp2IlInjected.Address(RVA = "0x637CD40", Offset = "0x637BD40", VA = "0x18637CD40")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60002AD")]
	[Cpp2IlInjected.Address(RVA = "0x637B210", Offset = "0x637A210", VA = "0x18637B210")]
	public GIHMOGNONIK(EHCMNHLPJBM ECLMPMCOOIA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002B2")]
	[Cpp2IlInjected.Address(RVA = "0x637C980", Offset = "0x637B980", VA = "0x18637C980", Slot = "4")]
	public void IJKJHGBBCEG(Vector3 OFOIDDLLFEI, ForceMode OJEDHHILKEL = ForceMode.Force)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002B3")]
	[Cpp2IlInjected.Address(RVA = "0x637CE80", Offset = "0x637BE80", VA = "0x18637CE80")]
	private void PDICPEOKBHA(Vector3 OFOIDDLLFEI, ForceMode OJEDHHILKEL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002B4")]
	[Cpp2IlInjected.Address(RVA = "0x637C700", Offset = "0x637B700", VA = "0x18637C700", Slot = "5")]
	public void HIDBDPPDDNG(Vector3 OFOIDDLLFEI, Vector3 LPGLCEHEHMC, ForceMode OJEDHHILKEL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002B5")]
	[Cpp2IlInjected.Address(RVA = "0x637C340", Offset = "0x637B340", VA = "0x18637C340", Slot = "6")]
	public void FEDPGNOKGDK(Vector3 LGKLDHJLFFC, ForceMode OJEDHHILKEL = ForceMode.Force)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002B6")]
	[Cpp2IlInjected.Address(RVA = "0x637C4A0", Offset = "0x637B4A0", VA = "0x18637C4A0")]
	private void HGCCKLJFDJC(Vector3 LGKLDHJLFFC, ForceMode OJEDHHILKEL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002B7")]
	[Cpp2IlInjected.Address(RVA = "0x637CAE0", Offset = "0x637BAE0", VA = "0x18637CAE0", Slot = "7")]
	public void KBMMINBNLNN(Vector3 LGKLDHJLFFC, ForceMode OJEDHHILKEL = ForceMode.Force)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002B8")]
	[Cpp2IlInjected.Address(RVA = "0x637CDA0", Offset = "0x637BDA0", VA = "0x18637CDA0")]
	private void PAOJJBFOCDP(string NCBOINMNCHO, UnityEngine.Object ACJODAOHIHK)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002D")]
internal sealed class FKIPMBOGDDK : MCAGBJFDKAD, HIIFMKKGLIL
{
	[Cpp2IlInjected.Token(Token = "0x170000BE")]
	public bool BJICAJLOKDG
	{
		[Cpp2IlInjected.Token(Token = "0x60002BA")]
		[Cpp2IlInjected.Address(RVA = "0x637AF60", Offset = "0x6379F60", VA = "0x18637AF60", Slot = "4")]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x60002BB")]
		[Cpp2IlInjected.Address(RVA = "0x637B030", Offset = "0x637A030", VA = "0x18637B030", Slot = "5")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60002B9")]
	[Cpp2IlInjected.Address(RVA = "0x637B210", Offset = "0x637A210", VA = "0x18637B210")]
	public FKIPMBOGDDK(EHCMNHLPJBM ECLMPMCOOIA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002BC")]
	[Cpp2IlInjected.Address(RVA = "0x637B180", Offset = "0x637A180", VA = "0x18637B180", Slot = "6")]
	public void KHNKJFJMFFM(Rigidbody IOJJIGGDNPN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002BD")]
	[Cpp2IlInjected.Address(RVA = "0x637AFC0", Offset = "0x6379FC0", VA = "0x18637AFC0", Slot = "7")]
	public void FBJMEJIJMGC(Rigidbody IOJJIGGDNPN)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002E")]
internal sealed class KOEKAOLIPGG : MCAGBJFDKAD, AEHPKHIMIDL, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x4000043")]
	private static readonly IMFBLHALHMN BPGDEBCEMMI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x400004D")]
	private readonly MNDJJDHPPPL NKOCPLJPBOO;

	[Cpp2IlInjected.Token(Token = "0x170000BF")]
	private Transform FHHLKDMADLC
	{
		[Cpp2IlInjected.Token(Token = "0x60002D1")]
		[Cpp2IlInjected.Address(RVA = "0x6383DF0", Offset = "0x6382DF0", VA = "0x186383DF0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000C0")]
	public DALFLBHIMAN CNJHAHEEAPI
	{
		[Cpp2IlInjected.Token(Token = "0x60002D3")]
		[Cpp2IlInjected.Address(RVA = "0x6384310", Offset = "0x6383310", VA = "0x186384310")]
		get
		{
			return default(DALFLBHIMAN);
		}
		[Cpp2IlInjected.Token(Token = "0x60002D4")]
		[Cpp2IlInjected.Address(RVA = "0x6385010", Offset = "0x6384010", VA = "0x186385010")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000C1")]
	public EHCMNHLPJBM CPGMADILNAD
	{
		[Cpp2IlInjected.Token(Token = "0x60002D5")]
		[Cpp2IlInjected.Address(RVA = "0x6385080", Offset = "0x6384080", VA = "0x186385080", Slot = "24")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60002D6")]
		[Cpp2IlInjected.Address(RVA = "0x6384090", Offset = "0x6383090", VA = "0x186384090", Slot = "25")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000C2")]
	public DALFLBHIMAN JAIEABGLLOO
	{
		[Cpp2IlInjected.Token(Token = "0x60002D7")]
		[Cpp2IlInjected.Address(RVA = "0x6383780", Offset = "0x6382780", VA = "0x186383780")]
		get
		{
			return default(DALFLBHIMAN);
		}
		[Cpp2IlInjected.Token(Token = "0x60002D8")]
		[Cpp2IlInjected.Address(RVA = "0x63839E0", Offset = "0x63829E0", VA = "0x1863839E0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000C3")]
	public EHCMNHLPJBM FMAEDMDFLJE
	{
		[Cpp2IlInjected.Token(Token = "0x60002D9")]
		[Cpp2IlInjected.Address(RVA = "0x6385190", Offset = "0x6384190", VA = "0x186385190", Slot = "23")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000C4")]
	public IReadOnlyList<EHCMNHLPJBM> NKNGGFCLKKC
	{
		[Cpp2IlInjected.Token(Token = "0x60002DA")]
		[Cpp2IlInjected.Address(RVA = "0x773900", Offset = "0x772900", VA = "0x180773900", Slot = "22")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400002B")]
	public event ODMKMIKDLDH HNIODPCALEE
	{
		[Cpp2IlInjected.Token(Token = "0x60002BF")]
		[Cpp2IlInjected.Address(RVA = "0x6384EC0", Offset = "0x6383EC0", VA = "0x186384EC0", Slot = "4")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60002C0")]
		[Cpp2IlInjected.Address(RVA = "0x6384650", Offset = "0x6383650", VA = "0x186384650", Slot = "5")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400002C")]
	public event ODMKMIKDLDH ICDJPNDLGPD
	{
		[Cpp2IlInjected.Token(Token = "0x60002C1")]
		[Cpp2IlInjected.Address(RVA = "0x63845B0", Offset = "0x63835B0", VA = "0x1863845B0", Slot = "6")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60002C2")]
		[Cpp2IlInjected.Address(RVA = "0x6384100", Offset = "0x6383100", VA = "0x186384100", Slot = "7")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400002D")]
	public event LNHELIADCNA JAPGMOHDICK
	{
		[Cpp2IlInjected.Token(Token = "0x60002C3")]
		[Cpp2IlInjected.Address(RVA = "0x6385490", Offset = "0x6384490", VA = "0x186385490", Slot = "8")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60002C4")]
		[Cpp2IlInjected.Address(RVA = "0x63850F0", Offset = "0x63840F0", VA = "0x1863850F0", Slot = "9")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400002E")]
	public event Action AFIOFAKDOHM
	{
		[Cpp2IlInjected.Token(Token = "0x60002C5")]
		[Cpp2IlInjected.Address(RVA = "0x6383F50", Offset = "0x6382F50", VA = "0x186383F50", Slot = "10")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60002C6")]
		[Cpp2IlInjected.Address(RVA = "0x6384370", Offset = "0x6383370", VA = "0x186384370", Slot = "11")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400002F")]
	public event Action LDAFEJALAGM
	{
		[Cpp2IlInjected.Token(Token = "0x60002C7")]
		[Cpp2IlInjected.Address(RVA = "0x6384CD0", Offset = "0x6383CD0", VA = "0x186384CD0", Slot = "12")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60002C8")]
		[Cpp2IlInjected.Address(RVA = "0x6383A50", Offset = "0x6382A50", VA = "0x186383A50", Slot = "13")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000030")]
	public event Action<EHCMNHLPJBM> IHHOLKIEDLI
	{
		[Cpp2IlInjected.Token(Token = "0x60002C9")]
		[Cpp2IlInjected.Address(RVA = "0x6384410", Offset = "0x6383410", VA = "0x186384410", Slot = "14")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60002CA")]
		[Cpp2IlInjected.Address(RVA = "0x6384B70", Offset = "0x6383B70", VA = "0x186384B70", Slot = "15")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000031")]
	public event Action<EHCMNHLPJBM> GFEGPGHKFIA
	{
		[Cpp2IlInjected.Token(Token = "0x60002CB")]
		[Cpp2IlInjected.Address(RVA = "0x6384D70", Offset = "0x6383D70", VA = "0x186384D70", Slot = "16")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60002CC")]
		[Cpp2IlInjected.Address(RVA = "0x6384F60", Offset = "0x6383F60", VA = "0x186384F60", Slot = "17")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000032")]
	public event Action HHBKPHPDLNL
	{
		[Cpp2IlInjected.Token(Token = "0x60002CD")]
		[Cpp2IlInjected.Address(RVA = "0x6383FF0", Offset = "0x6382FF0", VA = "0x186383FF0", Slot = "18")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60002CE")]
		[Cpp2IlInjected.Address(RVA = "0x6384E20", Offset = "0x6383E20", VA = "0x186384E20", Slot = "19")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000033")]
	public event Action<EHCMNHLPJBM> NOBNHCGFCBM
	{
		[Cpp2IlInjected.Token(Token = "0x60002CF")]
		[Cpp2IlInjected.Address(RVA = "0x6383D40", Offset = "0x6382D40", VA = "0x186383D40", Slot = "20")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60002D0")]
		[Cpp2IlInjected.Address(RVA = "0x6385200", Offset = "0x6384200", VA = "0x186385200", Slot = "21")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60002BE")]
	[Cpp2IlInjected.Address(RVA = "0x63855C0", Offset = "0x63845C0", VA = "0x1863855C0")]
	public KOEKAOLIPGG(EHCMNHLPJBM ECLMPMCOOIA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002D2")]
	[Cpp2IlInjected.Address(RVA = "0x6383E20", Offset = "0x6382E20", VA = "0x186383E20", Slot = "27")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002DB")]
	[Cpp2IlInjected.Address(RVA = "0x63841F0", Offset = "0x63831F0", VA = "0x1863841F0", Slot = "26")]
	public void GLKDGJFHDGI(EHCMNHLPJBM GLMIFAAAHGN, bool FMNAIIPBFHC = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002DC")]
	[Cpp2IlInjected.Address(RVA = "0x63841A0", Offset = "0x63831A0", VA = "0x1863841A0")]
	private void GLKDGJFHDGI(NCLMDAABOOP GLMIFAAAHGN, bool FMNAIIPBFHC = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002DD")]
	[Cpp2IlInjected.Address(RVA = "0x63846F0", Offset = "0x63836F0", VA = "0x1863846F0")]
	private void IHMNEDLCAPM(NCLMDAABOOP GLMIFAAAHGN, bool FMNAIIPBFHC = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002DE")]
	[Cpp2IlInjected.Address(RVA = "0x6383AF0", Offset = "0x6382AF0", VA = "0x186383AF0")]
	private void DABHHHAAOME(NCLMDAABOOP NLMONBKCPDM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002DF")]
	[Cpp2IlInjected.Address(RVA = "0x63837E0", Offset = "0x63827E0", VA = "0x1863837E0")]
	private void BHLMHEOGKBI(NCLMDAABOOP NLMONBKCPDM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002E0")]
	[Cpp2IlInjected.Address(RVA = "0x63852B0", Offset = "0x63842B0", VA = "0x1863852B0")]
	private void OKHFMKECLEB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002E1")]
	[Cpp2IlInjected.Address(RVA = "0x6384C20", Offset = "0x6383C20", VA = "0x186384C20")]
	private void JLBNKAPNJFA(NCLMDAABOOP NLMONBKCPDM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002E2")]
	[Cpp2IlInjected.Address(RVA = "0x63844C0", Offset = "0x63834C0", VA = "0x1863844C0")]
	private void HNCHPLHADNP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002E3")]
	[Cpp2IlInjected.Address(RVA = "0x63836E0", Offset = "0x63826E0", VA = "0x1863836E0")]
	private void AFEGLLIBHOI(NCLMDAABOOP ECLMPMCOOIA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002E4")]
	[Cpp2IlInjected.Address(RVA = "0x6384270", Offset = "0x6383270", VA = "0x186384270")]
	private void HACPIENJING(NCLMDAABOOP ECLMPMCOOIA)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002F")]
internal static class LIKGPNHBDDH
{
	[Cpp2IlInjected.Token(Token = "0x60002E6")]
	[Cpp2IlInjected.Address(RVA = "0x638A3D0", Offset = "0x63893D0", VA = "0x18638A3D0")]
	public static KOEKAOLIPGG PENHCFMGGJH(this EHCMNHLPJBM KKOFNCEIKDA)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000030")]
internal sealed class HNDIKJHHIKL : MCAGBJFDKAD, CLEHINCHHDE
{
	[Cpp2IlInjected.Token(Token = "0x170000C5")]
	public Vector3 BGJFIEJBIJF
	{
		[Cpp2IlInjected.Token(Token = "0x60002E8")]
		[Cpp2IlInjected.Address(RVA = "0x6380FC0", Offset = "0x637FFC0", VA = "0x186380FC0", Slot = "4")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000C6")]
	public Vector3 FLCGLBNKKAA
	{
		[Cpp2IlInjected.Token(Token = "0x60002E9")]
		[Cpp2IlInjected.Address(RVA = "0x6380890", Offset = "0x637F890", VA = "0x186380890", Slot = "5")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000C7")]
	private Vector3 JLKBIOAHEKE
	{
		[Cpp2IlInjected.Token(Token = "0x60002ED")]
		[Cpp2IlInjected.Address(RVA = "0x6380AC0", Offset = "0x637FAC0", VA = "0x186380AC0")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000C8")]
	private EHCMNHLPJBM DEMKBLBDOIF
	{
		[Cpp2IlInjected.Token(Token = "0x60002EE")]
		[Cpp2IlInjected.Address(RVA = "0x63812C0", Offset = "0x63802C0", VA = "0x1863812C0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60002E7")]
	[Cpp2IlInjected.Address(RVA = "0x637B210", Offset = "0x637A210", VA = "0x18637B210")]
	public HNDIKJHHIKL(EHCMNHLPJBM ECLMPMCOOIA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002EA")]
	[Cpp2IlInjected.Address(RVA = "0x6381170", Offset = "0x6380170", VA = "0x186381170", Slot = "6")]
	public void PKGKHPOJDBI(EHCMNHLPJBM IGPIMCJILMM, object PDIBILKHEBM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002EB")]
	[Cpp2IlInjected.Address(RVA = "0x6381060", Offset = "0x6380060", VA = "0x186381060")]
	private void PKGKHPOJDBI(NCLMDAABOOP IGPIMCJILMM, object PDIBILKHEBM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002EC")]
	[Cpp2IlInjected.Address(RVA = "0x6380FF0", Offset = "0x637FFF0", VA = "0x186380FF0", Slot = "7")]
	public void PIAIJDLNGDE(object PDIBILKHEBM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002EF")]
	[Cpp2IlInjected.Address(RVA = "0x6380BB0", Offset = "0x637FBB0", VA = "0x186380BB0")]
	private Vector3 HOJJKEBMKFH()
	{
		return default(Vector3);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000031")]
internal static class GPGBKHKEMFB
{
	[Cpp2IlInjected.Token(Token = "0x60002F0")]
	[Cpp2IlInjected.Address(RVA = "0x637E620", Offset = "0x637D620", VA = "0x18637E620")]
	public static HNDIKJHHIKL PIINHDAAFHL(this EHCMNHLPJBM KKOFNCEIKDA)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000032")]
internal sealed class NGCINKNJFLE : MCAGBJFDKAD, KACNHFAPOGE
{
	[Cpp2IlInjected.Token(Token = "0x170000C9")]
	[Obsolete("Use LocalCenterOfMassOfSelf or LocalCenterOfMassOfHierarchy, as LocalCenterOfMass changes based on context")]
	public Vector3 LADKEMIALFK
	{
		[Cpp2IlInjected.Token(Token = "0x60002F4")]
		[Cpp2IlInjected.Address(RVA = "0x6391450", Offset = "0x6390450", VA = "0x186391450", Slot = "6")]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x60002F5")]
		[Cpp2IlInjected.Address(RVA = "0x638EFB0", Offset = "0x638DFB0", VA = "0x18638EFB0", Slot = "7")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000CA")]
	public Vector3 GJKNJALELPP
	{
		[Cpp2IlInjected.Token(Token = "0x60002F6")]
		[Cpp2IlInjected.Address(RVA = "0x638FE10", Offset = "0x638EE10", VA = "0x18638FE10")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000CB")]
	public Vector3 EBLKCKDOJMC
	{
		[Cpp2IlInjected.Token(Token = "0x60002F8")]
		[Cpp2IlInjected.Address(RVA = "0x6391500", Offset = "0x6390500", VA = "0x186391500")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000CC")]
	[Obsolete("Use TryGetWorldCenterOfMassOfHierarchy() or GetWorldCenterOfMassOfSelf()")]
	public Vector3 PIICNOJNCPP
	{
		[Cpp2IlInjected.Token(Token = "0x60002F9")]
		[Cpp2IlInjected.Address(RVA = "0x638F130", Offset = "0x638E130", VA = "0x18638F130", Slot = "8")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000CD")]
	[Obsolete("Use MassOfSelf or TryGetMassOfHierarchy instead")]
	public float DGAGBHADGJN
	{
		[Cpp2IlInjected.Token(Token = "0x60002FA")]
		[Cpp2IlInjected.Address(RVA = "0x638F590", Offset = "0x638E590", VA = "0x18638F590", Slot = "9")]
		get
		{
			return default(float);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000CE")]
	public float JPOGIDJMNCJ
	{
		[Cpp2IlInjected.Token(Token = "0x60002FB")]
		[Cpp2IlInjected.Address(RVA = "0x638F320", Offset = "0x638E320", VA = "0x18638F320")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000CF")]
	public float LLNDLOGDDIG
	{
		[Cpp2IlInjected.Token(Token = "0x60002FC")]
		[Cpp2IlInjected.Address(RVA = "0x638FDB0", Offset = "0x638EDB0", VA = "0x18638FDB0", Slot = "10")]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x60002FD")]
		[Cpp2IlInjected.Address(RVA = "0x638FA40", Offset = "0x638EA40", VA = "0x18638FA40", Slot = "11")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000D0")]
	public Vector3 HNOLHOHLFKJ
	{
		[Cpp2IlInjected.Token(Token = "0x60002FE")]
		[Cpp2IlInjected.Address(RVA = "0x638E8E0", Offset = "0x638D8E0", VA = "0x18638E8E0", Slot = "12")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000D1")]
	public Quaternion LONFIJLGBOG
	{
		[Cpp2IlInjected.Token(Token = "0x60002FF")]
		[Cpp2IlInjected.Address(RVA = "0x638FB00", Offset = "0x638EB00", VA = "0x18638FB00", Slot = "13")]
		get
		{
			return default(Quaternion);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000D2")]
	private Rigidbody JLNHKFKKICK
	{
		[Cpp2IlInjected.Token(Token = "0x6000308")]
		[Cpp2IlInjected.Address(RVA = "0x6371000", Offset = "0x6370000", VA = "0x186371000")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000034")]
	public event ODMKMIKDLDH ECMDDEJIIMB
	{
		[Cpp2IlInjected.Token(Token = "0x60002F1")]
		[Cpp2IlInjected.Address(RVA = "0x638E910", Offset = "0x638D910", VA = "0x18638E910", Slot = "4")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60002F2")]
		[Cpp2IlInjected.Address(RVA = "0x638FB30", Offset = "0x638EB30", VA = "0x18638FB30", Slot = "5")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60002F3")]
	[Cpp2IlInjected.Address(RVA = "0x6391F70", Offset = "0x6390F70", VA = "0x186391F70")]
	public NGCINKNJFLE(EHCMNHLPJBM ECLMPMCOOIA, [In] OJNOICCBOJO FCLEEDACIMH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002F7")]
	[Cpp2IlInjected.Address(RVA = "0x6391980", Offset = "0x6390980", VA = "0x186391980")]
	public float3 OOIDMIKANMJ()
	{
		return default(float3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000300")]
	[Cpp2IlInjected.Address(RVA = "0x6391AA0", Offset = "0x6390AA0", VA = "0x186391AA0", Slot = "14")]
	public void PECPHAKBJCG((Quaternion rot, Vector3 moments) IJPGGILEIIN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000301")]
	[Cpp2IlInjected.Address(RVA = "0x638F3A0", Offset = "0x638E3A0", VA = "0x18638F3A0", Slot = "16")]
	public void EMOEILKEJBE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000302")]
	[Cpp2IlInjected.Address(RVA = "0x6391630", Offset = "0x6390630", VA = "0x186391630", Slot = "15")]
	public void NKANMLKMEBG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000303")]
	[Cpp2IlInjected.Address(RVA = "0x638FEC0", Offset = "0x638EEC0", VA = "0x18638FEC0", Slot = "18")]
	public void KHNKJFJMFFM(Rigidbody IOJJIGGDNPN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000304")]
	[Cpp2IlInjected.Address(RVA = "0x638F650", Offset = "0x638E650", VA = "0x18638F650", Slot = "19")]
	public void FBJMEJIJMGC(Rigidbody IOJJIGGDNPN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000305")]
	[Cpp2IlInjected.Address(RVA = "0x638F5F0", Offset = "0x638E5F0", VA = "0x18638F5F0", Slot = "17")]
	public void FAMCOJOMDOD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000306")]
	[Cpp2IlInjected.Address(RVA = "0x638E9B0", Offset = "0x638D9B0", VA = "0x18638E9B0", Slot = "20")]
	public void BLJKMNBKPBO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000307")]
	[Cpp2IlInjected.Address(RVA = "0x637F680", Offset = "0x637E680", VA = "0x18637F680")]
	public void BDOMLPPKCBI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000309")]
	[Cpp2IlInjected.Address(RVA = "0x638EFB0", Offset = "0x638DFB0", VA = "0x18638EFB0")]
	private void DAHOEINPDHO(Vector3 APPJEOKOGAK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600030A")]
	[Cpp2IlInjected.Address(RVA = "0x638FBD0", Offset = "0x638EBD0", VA = "0x18638FBD0")]
	[Obsolete("Changes based on context.  the unity rigidbody center of mass has a different scale as well")]
	private Vector3 IKGNOBECKHO()
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x600030B")]
	[Cpp2IlInjected.Address(RVA = "0x638FA40", Offset = "0x638EA40", VA = "0x18638FA40")]
	private void LLPECCFKBEI(float APPJEOKOGAK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600030C")]
	[Cpp2IlInjected.Address(RVA = "0x63911F0", Offset = "0x63901F0", VA = "0x1863911F0")]
	private Vector3 MECLOALLOBH()
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x600030D")]
	[Cpp2IlInjected.Address(RVA = "0x6391D30", Offset = "0x6390D30", VA = "0x186391D30")]
	private Quaternion PPLICDEEJPK()
	{
		return default(Quaternion);
	}

	[Cpp2IlInjected.Token(Token = "0x600030E")]
	[Cpp2IlInjected.Address(RVA = "0x638FF90", Offset = "0x638EF90", VA = "0x18638FF90")]
	internal (float, Vector3) LEIPMCEFFPA(Rigidbody ODIOPOFEILG)
	{
		return default((float, Vector3));
	}
}
[Cpp2IlInjected.Token(Token = "0x2000033")]
internal static class CIBGJCDOPOF
{
	[Cpp2IlInjected.Token(Token = "0x600030F")]
	[Cpp2IlInjected.Address(RVA = "0x6372E70", Offset = "0x6371E70", VA = "0x186372E70")]
	public static NGCINKNJFLE AGKJLIDILBI(this EHCMNHLPJBM KKOFNCEIKDA)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000034")]
internal sealed class DNIMLKGNNJM : MCAGBJFDKAD, HFBOJOOMHLA
{
	[Cpp2IlInjected.Token(Token = "0x170000D3")]
	public bool IJNKBENECFE
	{
		[Cpp2IlInjected.Token(Token = "0x6000310")]
		[Cpp2IlInjected.Address(RVA = "0x6374120", Offset = "0x6373120", VA = "0x186374120", Slot = "10")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000D4")]
	public HJJEIONKHEK CGFMLGHKMOK
	{
		[Cpp2IlInjected.Token(Token = "0x6000311")]
		[Cpp2IlInjected.Address(RVA = "0x63740C0", Offset = "0x63730C0", VA = "0x1863740C0", Slot = "11")]
		get
		{
			return default(HJJEIONKHEK);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000D5")]
	private HJJEIONKHEK LGDBLBKCMHL
	{
		[Cpp2IlInjected.Token(Token = "0x6000313")]
		[Cpp2IlInjected.Address(RVA = "0x63740C0", Offset = "0x63730C0", VA = "0x1863740C0")]
		get
		{
			return default(HJJEIONKHEK);
		}
		[Cpp2IlInjected.Token(Token = "0x6000314")]
		[Cpp2IlInjected.Address(RVA = "0x6374460", Offset = "0x6373460", VA = "0x186374460")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000312")]
	[Cpp2IlInjected.Address(RVA = "0x6374950", Offset = "0x6373950", VA = "0x186374950")]
	public DNIMLKGNNJM(EHCMNHLPJBM ECLMPMCOOIA, [In] OJNOICCBOJO FCLEEDACIMH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000315")]
	[Cpp2IlInjected.Address(RVA = "0x6374850", Offset = "0x6373850", VA = "0x186374850", Slot = "4")]
	public void NPFDHKEDPBK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000316")]
	[Cpp2IlInjected.Address(RVA = "0x63745D0", Offset = "0x63735D0", VA = "0x1863745D0")]
	private bool MCIAKMKEBPH()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000317")]
	[Cpp2IlInjected.Address(RVA = "0x63744D0", Offset = "0x63734D0", VA = "0x1863744D0", Slot = "5")]
	public void HLKPOIGCEAG(object PDIBILKHEBM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000318")]
	[Cpp2IlInjected.Address(RVA = "0x6374550", Offset = "0x6373550", VA = "0x186374550", Slot = "6")]
	public void IIAIKOCKHGA(object PDIBILKHEBM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000319")]
	[Cpp2IlInjected.Address(RVA = "0x6374180", Offset = "0x6373180", VA = "0x186374180", Slot = "9")]
	public void FIJMFJHPGEE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600031A")]
	[Cpp2IlInjected.Address(RVA = "0x63742E0", Offset = "0x63732E0", VA = "0x1863742E0")]
	private void FJBDMCCOHOD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600031B")]
	[Cpp2IlInjected.Address(RVA = "0x63746B0", Offset = "0x63736B0", VA = "0x1863746B0")]
	private void NHNEEAGKDCB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600031C")]
	[Cpp2IlInjected.Address(RVA = "0x6374040", Offset = "0x6373040", VA = "0x186374040", Slot = "8")]
	public void AMOOCLCHOID(EHCMNHLPJBM ECLMPMCOOIA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600031D")]
	[Cpp2IlInjected.Address(RVA = "0x63743E0", Offset = "0x63733E0", VA = "0x1863743E0", Slot = "7")]
	public void GCCKNIMCPIP(EHCMNHLPJBM ECLMPMCOOIA)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000035")]
internal sealed class NPNICIOELFE : MCAGBJFDKAD, AGCCBIKJDAK
{
	[Cpp2IlInjected.Token(Token = "0x170000D6")]
	public bool KFMBBJLEAJK
	{
		[Cpp2IlInjected.Token(Token = "0x6000320")]
		[Cpp2IlInjected.Address(RVA = "0x6394140", Offset = "0x6393140", VA = "0x186394140", Slot = "7")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000D7")]
	private bool GJCICFBJABC
	{
		[Cpp2IlInjected.Token(Token = "0x6000321")]
		[Cpp2IlInjected.Address(RVA = "0x63941A0", Offset = "0x63931A0", VA = "0x1863941A0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000035")]
	public event ODMKMIKDLDH IJHOLLBGJPD
	{
		[Cpp2IlInjected.Token(Token = "0x600031E")]
		[Cpp2IlInjected.Address(RVA = "0x6394200", Offset = "0x6393200", VA = "0x186394200", Slot = "4")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600031F")]
		[Cpp2IlInjected.Address(RVA = "0x63945F0", Offset = "0x63935F0", VA = "0x1863945F0", Slot = "5")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000322")]
	[Cpp2IlInjected.Address(RVA = "0x637B210", Offset = "0x637A210", VA = "0x18637B210")]
	public NPNICIOELFE(EHCMNHLPJBM ECLMPMCOOIA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000323")]
	[Cpp2IlInjected.Address(RVA = "0x6394480", Offset = "0x6393480", VA = "0x186394480", Slot = "11")]
	public IDisposable HLJKBPAJOBH()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000324")]
	[Cpp2IlInjected.Address(RVA = "0x63944F0", Offset = "0x63934F0", VA = "0x1863944F0", Slot = "8")]
	public void JPFGFDECHOJ(object PDIBILKHEBM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000325")]
	[Cpp2IlInjected.Address(RVA = "0x6394500", Offset = "0x6393500", VA = "0x186394500", Slot = "9")]
	public void KAPPGEIEJKO(object PDIBILKHEBM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000326")]
	[Cpp2IlInjected.Address(RVA = "0x6394380", Offset = "0x6393380", VA = "0x186394380", Slot = "10")]
	public void GJJAJKOMBNJ(object PDIBILKHEBM, bool GKHMPKCJGHP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000327")]
	[Cpp2IlInjected.Address(RVA = "0x6394510", Offset = "0x6393510", VA = "0x186394510", Slot = "12")]
	public void KHNKJFJMFFM(Rigidbody JFBLILNAOMM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000328")]
	[Cpp2IlInjected.Address(RVA = "0x63942A0", Offset = "0x63932A0", VA = "0x1863942A0", Slot = "13")]
	public void FBJMEJIJMGC(Rigidbody IOJJIGGDNPN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000329")]
	[Cpp2IlInjected.Address(RVA = "0x637F680", Offset = "0x637E680", VA = "0x18637F680", Slot = "6")]
	public void BJFJHCOMKNK()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000036")]
internal sealed class BCBDPIDFHJD : MCAGBJFDKAD, FHAABOAKHEB, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000051")]
	private PhotonView EEKACCEEHIJ;

	[Cpp2IlInjected.Token(Token = "0x170000D8")]
	public bool GCPNKEIHNJF
	{
		[Cpp2IlInjected.Token(Token = "0x600032C")]
		[Cpp2IlInjected.Address(RVA = "0x6372350", Offset = "0x6371350", VA = "0x186372350", Slot = "6")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000D9")]
	public bool FLDOPHCHFPM
	{
		[Cpp2IlInjected.Token(Token = "0x600032D")]
		[Cpp2IlInjected.Address(RVA = "0x63716A0", Offset = "0x63706A0", VA = "0x1863716A0", Slot = "7")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000036")]
	public event ODMKMIKDLDH GIADDJGCKPO
	{
		[Cpp2IlInjected.Token(Token = "0x600032A")]
		[Cpp2IlInjected.Address(RVA = "0x6371BA0", Offset = "0x6370BA0", VA = "0x186371BA0", Slot = "4")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600032B")]
		[Cpp2IlInjected.Address(RVA = "0x6372370", Offset = "0x6371370", VA = "0x186372370", Slot = "5")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600032E")]
	[Cpp2IlInjected.Address(RVA = "0x6372410", Offset = "0x6371410", VA = "0x186372410")]
	public BCBDPIDFHJD(EHCMNHLPJBM ECLMPMCOOIA, [In] OJNOICCBOJO FCLEEDACIMH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600032F")]
	[Cpp2IlInjected.Address(RVA = "0x6372040", Offset = "0x6371040", VA = "0x186372040", Slot = "8")]
	public void NPFDHKEDPBK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000330")]
	[Cpp2IlInjected.Address(RVA = "0x6371A40", Offset = "0x6370A40", VA = "0x186371A40", Slot = "11")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000331")]
	[Cpp2IlInjected.Address(RVA = "0x6371E40", Offset = "0x6370E40", VA = "0x186371E40", Slot = "9")]
	public void MFCPKNBIHKM(EHCMNHLPJBM IGPIMCJILMM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000332")]
	[Cpp2IlInjected.Address(RVA = "0x6371C40", Offset = "0x6370C40", VA = "0x186371C40", Slot = "10")]
	public void KBIEHHBCMLI(EHCMNHLPJBM IGPIMCJILMM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000333")]
	[Cpp2IlInjected.Address(RVA = "0x6372170", Offset = "0x6371170", VA = "0x186372170")]
	private void ONOOMEJCIBG(PhotonView EENGMELAOON)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000334")]
	[Cpp2IlInjected.Address(RVA = "0x63718F0", Offset = "0x63708F0", VA = "0x1863718F0")]
	private void CBKDCHJFCCE(RigidbodyEx GMJFIDEOPEB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000335")]
	[Cpp2IlInjected.Address(RVA = "0x6371730", Offset = "0x6370730", VA = "0x186371730")]
	private void AMHBGOCKIJM(PhotonView DNAPJIIGHPI)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000037")]
internal static class BBDJJODDFCN
{
	[Cpp2IlInjected.Token(Token = "0x6000336")]
	[Cpp2IlInjected.Address(RVA = "0x63713C0", Offset = "0x63703C0", VA = "0x1863713C0")]
	public static BCBDPIDFHJD DHMLPICNKEB(this FGCABOJBJBA KKOFNCEIKDA)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000038")]
internal sealed class AGFHPJMELNJ : MCAGBJFDKAD, ADPECGILELO
{
	[Cpp2IlInjected.Token(Token = "0x170000DA")]
	public bool MIOAIPJJMGG
	{
		[Cpp2IlInjected.Token(Token = "0x6000337")]
		[Cpp2IlInjected.Address(RVA = "0x636F850", Offset = "0x636E850", VA = "0x18636F850", Slot = "4")]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000338")]
		[Cpp2IlInjected.Address(RVA = "0x636F770", Offset = "0x636E770", VA = "0x18636F770", Slot = "5")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000DB")]
	public bool FOAJEHMGIDA
	{
		[Cpp2IlInjected.Token(Token = "0x6000339")]
		[Cpp2IlInjected.Address(RVA = "0x636F9A0", Offset = "0x636E9A0", VA = "0x18636F9A0", Slot = "6")]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x600033A")]
		[Cpp2IlInjected.Address(RVA = "0x636F7E0", Offset = "0x636E7E0", VA = "0x18636F7E0")]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000DC")]
	public RigidbodyConstraints NPGAMCBNMHD
	{
		[Cpp2IlInjected.Token(Token = "0x600033B")]
		[Cpp2IlInjected.Address(RVA = "0x636F8B0", Offset = "0x636E8B0", VA = "0x18636F8B0", Slot = "7")]
		get
		{
			return default(RigidbodyConstraints);
		}
		[Cpp2IlInjected.Token(Token = "0x600033C")]
		[Cpp2IlInjected.Address(RVA = "0x636F570", Offset = "0x636E570", VA = "0x18636F570", Slot = "8")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600033D")]
	[Cpp2IlInjected.Address(RVA = "0x636FA00", Offset = "0x636EA00", VA = "0x18636FA00")]
	public AGFHPJMELNJ(EHCMNHLPJBM ECLMPMCOOIA, [In] OJNOICCBOJO FCLEEDACIMH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600033E")]
	[Cpp2IlInjected.Address(RVA = "0x636F910", Offset = "0x636E910", VA = "0x18636F910", Slot = "9")]
	public void KHNKJFJMFFM(Rigidbody IOJJIGGDNPN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600033F")]
	[Cpp2IlInjected.Address(RVA = "0x636F6F0", Offset = "0x636E6F0", VA = "0x18636F6F0", Slot = "10")]
	public void FBJMEJIJMGC(Rigidbody IOJJIGGDNPN)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000039")]
internal sealed class KPBGCJFFLCJ : MCAGBJFDKAD, HNFHIEOAONP
{
	[Cpp2IlInjected.Token(Token = "0x170000DD")]
	public float EBALBFJEABI
	{
		[Cpp2IlInjected.Token(Token = "0x6000341")]
		[Cpp2IlInjected.Address(RVA = "0x6385C60", Offset = "0x6384C60", VA = "0x186385C60", Slot = "4")]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x6000342")]
		[Cpp2IlInjected.Address(RVA = "0x63858D0", Offset = "0x63848D0", VA = "0x1863858D0", Slot = "5")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000DE")]
	public float FBKHGEIFEEL
	{
		[Cpp2IlInjected.Token(Token = "0x6000343")]
		[Cpp2IlInjected.Address(RVA = "0x63857A0", Offset = "0x63847A0", VA = "0x1863857A0", Slot = "6")]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x6000344")]
		[Cpp2IlInjected.Address(RVA = "0x6385A20", Offset = "0x6384A20", VA = "0x186385A20", Slot = "7")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000340")]
	[Cpp2IlInjected.Address(RVA = "0x637B210", Offset = "0x637A210", VA = "0x18637B210")]
	public KPBGCJFFLCJ(EHCMNHLPJBM ECLMPMCOOIA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000345")]
	[Cpp2IlInjected.Address(RVA = "0x6385B70", Offset = "0x6384B70", VA = "0x186385B70", Slot = "8")]
	public void KHNKJFJMFFM(Rigidbody IOJJIGGDNPN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000346")]
	[Cpp2IlInjected.Address(RVA = "0x6385800", Offset = "0x6384800", VA = "0x186385800", Slot = "9")]
	public void FBJMEJIJMGC(Rigidbody IOJJIGGDNPN)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200003A")]
[IOECDJGDPJM(typeof(JMOMKGEHEMD), new string[] { })]
public sealed class BNLGCLHJEFI : LFEOMOKILLA, JMOMKGEHEMD, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000052")]
	[EADALOFEHFB]
	private DLCIOIDPKIF ECLMPMCOOIA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000053")]
	private bool BKIGCJKEOGE;

	[Cpp2IlInjected.Token(Token = "0x170000DF")]
	public bool OAFFKLKKCNG
	{
		[Cpp2IlInjected.Token(Token = "0x6000349")]
		[Cpp2IlInjected.Address(RVA = "0x81EBB0", Offset = "0x81DBB0", VA = "0x18081EBB0", Slot = "5")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000347")]
	[Cpp2IlInjected.Address(RVA = "0x63728B0", Offset = "0x63718B0", VA = "0x1863728B0", Slot = "4")]
	public void InitReferences(MKDBPFPJIJD HCKKNCPHDMK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000348")]
	[Cpp2IlInjected.Address(RVA = "0x63726D0", Offset = "0x63716D0", VA = "0x1863726D0", Slot = "10")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600034A")]
	[Cpp2IlInjected.Address(RVA = "0x6372D50", Offset = "0x6371D50", VA = "0x186372D50", Slot = "6")]
	public void LEIPMCEFFPA(DALFLBHIMAN BOEFBOGINDB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600034B")]
	[Cpp2IlInjected.Address(RVA = "0x6372A40", Offset = "0x6371A40", VA = "0x186372A40", Slot = "7")]
	public void KFDOPBMCIEK(DALFLBHIMAN BOEFBOGINDB, bool EEMJKKFDLGP, bool PLDDLPICFNN, bool IFDMKLECEJA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600034C")]
	[Cpp2IlInjected.Address(RVA = "0x6372900", Offset = "0x6371900", VA = "0x186372900", Slot = "8")]
	public void JMOPADFKBAI(DALFLBHIMAN BOEFBOGINDB, float3 GMLDNFHDNJP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600034D")]
	[Cpp2IlInjected.Address(RVA = "0x6372590", Offset = "0x6371590", VA = "0x186372590", Slot = "9")]
	public void DBJEDFMIINF(DALFLBHIMAN BOEFBOGINDB, float3 PLLAPIPLOBE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600034E")]
	[Cpp2IlInjected.Address(RVA = "0x6372700", Offset = "0x6371700", VA = "0x186372700")]
	private bool FLIFCBLELIB(DALFLBHIMAN BOEFBOGINDB, [Out] NCLMDAABOOP KKOFNCEIKDA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600034F")]
	[Cpp2IlInjected.Address(RVA = "0x6372C60", Offset = "0x6371C60", VA = "0x186372C60")]
	private bool KHONNNLMPMB(DALFLBHIMAN BOEFBOGINDB, [Out] NGCINKNJFLE KCKMKHKPCFM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000350")]
	[Cpp2IlInjected.Address(RVA = "0x63727C0", Offset = "0x63717C0", VA = "0x1863727C0")]
	private bool INKAHFCEACG(DALFLBHIMAN BOEFBOGINDB, [Out] LGBGBOBCJFC BDDBJHAFGCB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000351")]
	[Cpp2IlInjected.Address(RVA = "0x7734B0", Offset = "0x7724B0", VA = "0x1807734B0")]
	public BNLGCLHJEFI()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200003B")]
internal sealed class HFLPAGLGINB : MCAGBJFDKAD, EKKHALEFJMB
{
	[Cpp2IlInjected.Token(Token = "0x170000E0")]
	private Rigidbody JLNHKFKKICK
	{
		[Cpp2IlInjected.Token(Token = "0x6000354")]
		[Cpp2IlInjected.Address(RVA = "0x6371000", Offset = "0x6370000", VA = "0x186371000")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000E1")]
	private bool ECAGBOEDCGJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000355")]
		[Cpp2IlInjected.Address(RVA = "0x637F660", Offset = "0x637E660", VA = "0x18637F660")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000E2")]
	private EHCMNHLPJBM CPGMADILNAD
	{
		[Cpp2IlInjected.Token(Token = "0x6000356")]
		[Cpp2IlInjected.Address(RVA = "0x637F3B0", Offset = "0x637E3B0", VA = "0x18637F3B0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000E3")]
	private bool LAHBJHCBLCC
	{
		[Cpp2IlInjected.Token(Token = "0x6000357")]
		[Cpp2IlInjected.Address(RVA = "0x637F350", Offset = "0x637E350", VA = "0x18637F350")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000E4")]
	private bool NHGHMKDMLMD
	{
		[Cpp2IlInjected.Token(Token = "0x6000358")]
		[Cpp2IlInjected.Address(RVA = "0x637EC80", Offset = "0x637DC80", VA = "0x18637EC80")]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000359")]
		[Cpp2IlInjected.Address(RVA = "0x637ECE0", Offset = "0x637DCE0", VA = "0x18637ECE0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000E5")]
	private bool ONLBMLBOBHM
	{
		[Cpp2IlInjected.Token(Token = "0x600035A")]
		[Cpp2IlInjected.Address(RVA = "0x637F2F0", Offset = "0x637E2F0", VA = "0x18637F2F0")]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x600035B")]
		[Cpp2IlInjected.Address(RVA = "0x637EE60", Offset = "0x637DE60", VA = "0x18637EE60")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000E6")]
	private int PGNIPOKMECB
	{
		[Cpp2IlInjected.Token(Token = "0x600035C")]
		[Cpp2IlInjected.Address(RVA = "0x637EDF0", Offset = "0x637DDF0", VA = "0x18637EDF0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000037")]
	public event ODMKMIKDLDH AGBEMFNHAAD
	{
		[Cpp2IlInjected.Token(Token = "0x6000352")]
		[Cpp2IlInjected.Address(RVA = "0x637ED50", Offset = "0x637DD50", VA = "0x18637ED50", Slot = "4")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000353")]
		[Cpp2IlInjected.Address(RVA = "0x637F110", Offset = "0x637E110", VA = "0x18637F110", Slot = "5")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600035D")]
	[Cpp2IlInjected.Address(RVA = "0x637F6C0", Offset = "0x637E6C0", VA = "0x18637F6C0")]
	public HFLPAGLGINB(EHCMNHLPJBM ECLMPMCOOIA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600035E")]
	[Cpp2IlInjected.Address(RVA = "0x637F5B0", Offset = "0x637E5B0", VA = "0x18637F5B0", Slot = "6")]
	public void NPFDHKEDPBK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600035F")]
	[Cpp2IlInjected.Address(RVA = "0x637EFC0", Offset = "0x637DFC0", VA = "0x18637EFC0", Slot = "8")]
	public void FAHFAEABFGP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000360")]
	[Cpp2IlInjected.Address(RVA = "0x637F410", Offset = "0x637E410", VA = "0x18637F410", Slot = "7")]
	public bool NKFKNEFDAFK()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000361")]
	[Cpp2IlInjected.Address(RVA = "0x637EED0", Offset = "0x637DED0", VA = "0x18637EED0", Slot = "9")]
	public void EIHNIBFOFFJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000362")]
	[Cpp2IlInjected.Address(RVA = "0x637F680", Offset = "0x637E680", VA = "0x18637F680", Slot = "12")]
	public void OMMJOFBDFBB(bool JIPBGPFOHIP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000363")]
	[Cpp2IlInjected.Address(RVA = "0x637F1B0", Offset = "0x637E1B0", VA = "0x18637F1B0", Slot = "11")]
	public void JPMGMMIEBBB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000364")]
	[Cpp2IlInjected.Address(RVA = "0x770CB0", Offset = "0x76FCB0", VA = "0x180770CB0", Slot = "10")]
	public void DBEJFEPONEK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000365")]
	[Cpp2IlInjected.Address(RVA = "0x637F030", Offset = "0x637E030", VA = "0x18637F030")]
	private void IFONICPCDIG()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200003C")]
internal sealed class FNDNCEGGFKM : MCAGBJFDKAD, BJKCOGNFHAA
{
	[Cpp2IlInjected.Token(Token = "0x170000E7")]
	public Rigidbody JLNHKFKKICK
	{
		[Cpp2IlInjected.Token(Token = "0x6000366")]
		[Cpp2IlInjected.Address(RVA = "0x637B8F0", Offset = "0x637A8F0", VA = "0x18637B8F0", Slot = "4")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000367")]
		[Cpp2IlInjected.Address(RVA = "0x637B2B0", Offset = "0x637A2B0", VA = "0x18637B2B0")]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000E8")]
	private bool LAHBJHCBLCC
	{
		[Cpp2IlInjected.Token(Token = "0x6000368")]
		[Cpp2IlInjected.Address(RVA = "0x6370230", Offset = "0x636F230", VA = "0x186370230")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000E9")]
	public bool LFGLHLLGJDN
	{
		[Cpp2IlInjected.Token(Token = "0x600036B")]
		[Cpp2IlInjected.Address(RVA = "0x637B3A0", Offset = "0x637A3A0", VA = "0x18637B3A0", Slot = "6")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000369")]
	[Cpp2IlInjected.Address(RVA = "0x637BCE0", Offset = "0x637ACE0", VA = "0x18637BCE0")]
	public FNDNCEGGFKM(EHCMNHLPJBM ECLMPMCOOIA, [In] OJNOICCBOJO FCLEEDACIMH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600036A")]
	[Cpp2IlInjected.Address(RVA = "0x637BC30", Offset = "0x637AC30", VA = "0x18637BC30", Slot = "5")]
	public void NPFDHKEDPBK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600036C")]
	[Cpp2IlInjected.Address(RVA = "0x637B620", Offset = "0x637A620", VA = "0x18637B620", Slot = "7")]
	public void JEJJNCIBMKD(object PDIBILKHEBM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600036D")]
	[Cpp2IlInjected.Address(RVA = "0x637B870", Offset = "0x637A870", VA = "0x18637B870", Slot = "8")]
	public void MPNABKADOLD(object PDIBILKHEBM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600036E")]
	[Cpp2IlInjected.Address(RVA = "0x637B400", Offset = "0x637A400", VA = "0x18637B400", Slot = "9")]
	public void IDCEKLJCOAF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600036F")]
	[Cpp2IlInjected.Address(RVA = "0x637B9D0", Offset = "0x637A9D0", VA = "0x18637B9D0", Slot = "11")]
	public void NMEDAFKNELN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000370")]
	[Cpp2IlInjected.Address(RVA = "0x637B6A0", Offset = "0x637A6A0", VA = "0x18637B6A0", Slot = "12")]
	public void MEFNPMCJONJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000371")]
	[Cpp2IlInjected.Address(RVA = "0x770CB0", Offset = "0x76FCB0", VA = "0x180770CB0", Slot = "10")]
	public void NMDAPEFEOIC()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200003D")]
internal sealed class LGBGBOBCJFC : MCAGBJFDKAD, EGNMEGPNLGB, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x170000EA")]
	public AFBJPJGOHAH PAKEEKMBNJI
	{
		[Cpp2IlInjected.Token(Token = "0x6000372")]
		[Cpp2IlInjected.Address(RVA = "0x6388CF0", Offset = "0x6387CF0", VA = "0x186388CF0", Slot = "4")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000373")]
		[Cpp2IlInjected.Address(RVA = "0x6386E40", Offset = "0x6385E40", VA = "0x186386E40", Slot = "5")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000EB")]
	public GAMCJHNBHDA CONGFAJKAFK
	{
		[Cpp2IlInjected.Token(Token = "0x6000374")]
		[Cpp2IlInjected.Address(RVA = "0x6388C40", Offset = "0x6387C40", VA = "0x186388C40", Slot = "6")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000375")]
		[Cpp2IlInjected.Address(RVA = "0x638A360", Offset = "0x6389360", VA = "0x18638A360", Slot = "7")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000EC")]
	public Vector3 JLKBIOAHEKE
	{
		[Cpp2IlInjected.Token(Token = "0x6000376")]
		[Cpp2IlInjected.Address(RVA = "0x6387040", Offset = "0x6386040", VA = "0x186387040", Slot = "8")]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x6000377")]
		[Cpp2IlInjected.Address(RVA = "0x63870A0", Offset = "0x63860A0", VA = "0x1863870A0", Slot = "9")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000ED")]
	public Vector3 ONCBIGPFDBG
	{
		[Cpp2IlInjected.Token(Token = "0x6000378")]
		[Cpp2IlInjected.Address(RVA = "0x63890B0", Offset = "0x63880B0", VA = "0x1863890B0", Slot = "10")]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x6000379")]
		[Cpp2IlInjected.Address(RVA = "0x6388E00", Offset = "0x6387E00", VA = "0x186388E00", Slot = "11")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000EE")]
	public Vector3 ILEPAAIOGPH
	{
		[Cpp2IlInjected.Token(Token = "0x600037A")]
		[Cpp2IlInjected.Address(RVA = "0x6387FC0", Offset = "0x6386FC0", VA = "0x186387FC0", Slot = "12")]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x600037B")]
		[Cpp2IlInjected.Address(RVA = "0x6387D40", Offset = "0x6386D40", VA = "0x186387D40", Slot = "13")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000EF")]
	public Vector3 DINKBHOHIJN
	{
		[Cpp2IlInjected.Token(Token = "0x600037C")]
		[Cpp2IlInjected.Address(RVA = "0x6389940", Offset = "0x6388940", VA = "0x186389940", Slot = "14")]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x600037D")]
		[Cpp2IlInjected.Address(RVA = "0x6388080", Offset = "0x6387080", VA = "0x186388080", Slot = "15")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000F0")]
	public float CEJDFPIKKNH
	{
		[Cpp2IlInjected.Token(Token = "0x600037E")]
		[Cpp2IlInjected.Address(RVA = "0x6388670", Offset = "0x6387670", VA = "0x186388670", Slot = "16")]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x600037F")]
		[Cpp2IlInjected.Address(RVA = "0x63880B0", Offset = "0x63870B0", VA = "0x1863880B0", Slot = "17")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000F1")]
	public bool CNPBCJLHPAJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000381")]
		[Cpp2IlInjected.Address(RVA = "0x6388200", Offset = "0x6387200", VA = "0x186388200", Slot = "18")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000F2")]
	private HEOOOHDIHMG PDGEDPJKNNK
	{
		[Cpp2IlInjected.Token(Token = "0x6000394")]
		[Cpp2IlInjected.Address(RVA = "0x1CA8360", Offset = "0x1CA7360", VA = "0x181CA8360")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000F3")]
	private bool ECAGBOEDCGJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000395")]
		[Cpp2IlInjected.Address(RVA = "0x637F660", Offset = "0x637E660", VA = "0x18637F660")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000380")]
	[Cpp2IlInjected.Address(RVA = "0x637B210", Offset = "0x637A210", VA = "0x18637B210")]
	public LGBGBOBCJFC(EHCMNHLPJBM ECLMPMCOOIA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000382")]
	[Cpp2IlInjected.Address(RVA = "0x63876B0", Offset = "0x63866B0", VA = "0x1863876B0", Slot = "20")]
	public void EJAMNEGFJEM(object PDIBILKHEBM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000383")]
	[Cpp2IlInjected.Address(RVA = "0x6387CD0", Offset = "0x6386CD0", VA = "0x186387CD0", Slot = "30")]
	public void FGKEAHEDAEC(object PDIBILKHEBM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000384")]
	[Cpp2IlInjected.Address(RVA = "0x6389420", Offset = "0x6388420", VA = "0x186389420", Slot = "19")]
	public void NPFDHKEDPBK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000385")]
	[Cpp2IlInjected.Address(RVA = "0x6387160", Offset = "0x6386160", VA = "0x186387160", Slot = "36")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000386")]
	[Cpp2IlInjected.Address(RVA = "0x63892B0", Offset = "0x63882B0", VA = "0x1863892B0", Slot = "28")]
	public void KHNKJFJMFFM(Rigidbody IOJJIGGDNPN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000387")]
	[Cpp2IlInjected.Address(RVA = "0x6387220", Offset = "0x6386220", VA = "0x186387220", Slot = "35")]
	public Vector3 ECOHLCBCAIO(Vector3 IACNFCFIIOM)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000388")]
	[Cpp2IlInjected.Address(RVA = "0x6387E00", Offset = "0x6386E00", VA = "0x186387E00", Slot = "34")]
	public Vector3 FNKNMFKCFHO(Vector3 GMLDNFHDNJP)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000389")]
	[Cpp2IlInjected.Address(RVA = "0x6389420", Offset = "0x6388420", VA = "0x186389420", Slot = "27")]
	public void MBDGEAIJODJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600038A")]
	[Cpp2IlInjected.Address(RVA = "0x6388020", Offset = "0x6387020", VA = "0x186388020", Slot = "25")]
	public void GAMMNKDKDMP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600038B")]
	[Cpp2IlInjected.Address(RVA = "0x6386860", Offset = "0x6385860", VA = "0x186386860", Slot = "24")]
	public void BCBGBGNDMKE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600038C")]
	[Cpp2IlInjected.Address(RVA = "0x63894D0", Offset = "0x63884D0", VA = "0x1863894D0", Slot = "33")]
	public void MLEAMOMCHPM(Vector3 PFBOCMNHECB, Vector3 EGGKDKAICGO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600038D")]
	[Cpp2IlInjected.Address(RVA = "0x6389710", Offset = "0x6388710", VA = "0x186389710", Slot = "32")]
	public void NADJGLGOMJF(Vector3 ACIPBFHCAAA, Vector3 PLLAPIPLOBE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600038E")]
	[Cpp2IlInjected.Address(RVA = "0x63890E0", Offset = "0x63880E0", VA = "0x1863890E0", Slot = "31")]
	public void KEIBJNKFFKK(Vector3 BCLKICLJPAP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600038F")]
	[Cpp2IlInjected.Address(RVA = "0x63886D0", Offset = "0x63876D0", VA = "0x1863886D0", Slot = "22")]
	public void IHIBCDABGEA(BOLJBMMECOE DBGBHNOCNJE, Vector3 HGEDCNMOIAN, float NBBOEEPKJMP, float MFOFCNBGOEE = 8f, float JKNAHEBOBHM = 1f)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000390")]
	[Cpp2IlInjected.Address(RVA = "0x6387400", Offset = "0x6386400", VA = "0x186387400", Slot = "21")]
	public void EHCOAACKECM(LGPMEMPGHMC CFIODOIHFKI, Vector3 POKFEHNNFOH, float NLCECILHIIF = float.PositiveInfinity)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000391")]
	[Cpp2IlInjected.Address(RVA = "0x6388260", Offset = "0x6387260", VA = "0x186388260", Slot = "23")]
	[Obsolete("Deprecated. Still exists to support deprecated CV2 chips. Use ApplyAngularVelocityChange.")]
	public void IAGIBKOHJDJ(LGPMEMPGHMC CFIODOIHFKI, Vector3 LGOFCBEILGM, float DPKKDMEAKFE = 7f, float DLNPOBOGDPN = 1f)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000392")]
	[Cpp2IlInjected.Address(RVA = "0x6389970", Offset = "0x6388970", VA = "0x186389970", Slot = "29")]
	public Vector3 NKFAKMKMGLK(Vector3 OBNDDJFFKOO)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000393")]
	[Cpp2IlInjected.Address(RVA = "0x6386EB0", Offset = "0x6385EB0", VA = "0x186386EB0", Slot = "26")]
	public void DACCEJMCHOM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000396")]
	[Cpp2IlInjected.Address(RVA = "0x63880B0", Offset = "0x63870B0", VA = "0x1863880B0")]
	private void ONLOEHKHDFL(float APPJEOKOGAK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000397")]
	[Cpp2IlInjected.Address(RVA = "0x6389770", Offset = "0x6388770", VA = "0x186389770")]
	private void NGIEHIIJDJE(Vector3 POKFEHNNFOH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000398")]
	[Cpp2IlInjected.Address(RVA = "0x6388E30", Offset = "0x6387E30", VA = "0x186388E30")]
	private Vector3 KABAGJGGPBM()
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000399")]
	[Cpp2IlInjected.Address(RVA = "0x63868C0", Offset = "0x63858C0", VA = "0x1863868C0")]
	private void BDHFKDMBFBL(Vector3 GMLDNFHDNJP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600039A")]
	[Cpp2IlInjected.Address(RVA = "0x6389FC0", Offset = "0x6388FC0", VA = "0x186389FC0")]
	private Vector3 OGOHBLJNEHM()
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x600039B")]
	[Cpp2IlInjected.Address(RVA = "0x6389A50", Offset = "0x6388A50", VA = "0x186389A50")]
	private void NLOEJKCIIKH(Vector3 APPJEOKOGAK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600039C")]
	[Cpp2IlInjected.Address(RVA = "0x6388DA0", Offset = "0x6387DA0", VA = "0x186388DA0")]
	private void JEFNMPKMHLO(Vector3 OBNDDJFFKOO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600039D")]
	[Cpp2IlInjected.Address(RVA = "0x638A300", Offset = "0x6389300", VA = "0x18638A300")]
	private void OJNBDECIENF(Vector3 DHDAKHKKKMH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600039E")]
	[Cpp2IlInjected.Address(RVA = "0x6387720", Offset = "0x6386720", VA = "0x186387720")]
	private void EMNCKIFCCKI(string GONABJOPEAK, Vector3 APPJEOKOGAK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600039F")]
	[Cpp2IlInjected.Address(RVA = "0x638A250", Offset = "0x6389250", VA = "0x18638A250")]
	private void OIDEMOIHGHE()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200003E")]
internal class MCAGBJFDKAD
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000055")]
	protected readonly NCLMDAABOOP ECLMPMCOOIA;

	[Cpp2IlInjected.Token(Token = "0x170000F4")]
	protected DLCIOIDPKIF PINNDCCGKGP
	{
		[Cpp2IlInjected.Token(Token = "0x60003A0")]
		[Cpp2IlInjected.Address(RVA = "0x54FC400", Offset = "0x54FB400", VA = "0x1854FC400")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000F5")]
	protected DALFLBHIMAN HJKBNPPGGLN
	{
		[Cpp2IlInjected.Token(Token = "0x60003A1")]
		[Cpp2IlInjected.Address(RVA = "0x54FC440", Offset = "0x54FB440", VA = "0x1854FC440")]
		get
		{
			return default(DALFLBHIMAN);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60003A2")]
	[Cpp2IlInjected.Address(RVA = "0x637B210", Offset = "0x637A210", VA = "0x18637B210")]
	public MCAGBJFDKAD(EHCMNHLPJBM ECLMPMCOOIA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003A3")]
	[Cpp2IlInjected.Address(RVA = "0x638D350", Offset = "0x638C350", VA = "0x18638D350")]
	protected EHCMNHLPJBM LCJNBGDKCHG(DALFLBHIMAN KFGJIMGDDPH)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200003F")]
public class HLGPLPDALNL : CKFHDMFFLAC
{
	[Cpp2IlInjected.Token(Token = "0x60003A4")]
	[Cpp2IlInjected.Address(RVA = "0x63804A0", Offset = "0x637F4A0", VA = "0x1863804A0", Slot = "4")]
	public AEHPKHIMIDL LOJAHIJFBGD(EHCMNHLPJBM KKOFNCEIKDA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003A5")]
	[Cpp2IlInjected.Address(RVA = "0x637FD30", Offset = "0x637ED30", VA = "0x18637FD30", Slot = "5")]
	public EGNMEGPNLGB HNHMABEMGJI(EHCMNHLPJBM KKOFNCEIKDA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003A6")]
	[Cpp2IlInjected.Address(RVA = "0x63806D0", Offset = "0x637F6D0", VA = "0x1863806D0", Slot = "6")]
	public CLEHINCHHDE OFKGIFIMGFJ(EHCMNHLPJBM KKOFNCEIKDA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003A7")]
	[Cpp2IlInjected.Address(RVA = "0x637FC50", Offset = "0x637EC50", VA = "0x18637FC50", Slot = "7")]
	public HNFHIEOAONP DIFFELNBIFI(EHCMNHLPJBM KKOFNCEIKDA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003A8")]
	[Cpp2IlInjected.Address(RVA = "0x6380060", Offset = "0x637F060", VA = "0x186380060", Slot = "8")]
	public EKKHALEFJMB KGANCFEAPKO(EHCMNHLPJBM KKOFNCEIKDA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003A9")]
	[Cpp2IlInjected.Address(RVA = "0x63805F0", Offset = "0x637F5F0", VA = "0x1863805F0", Slot = "9")]
	public HFPBFKAEHJM NIGBNCBFBJJ(EHCMNHLPJBM KKOFNCEIKDA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003AA")]
	[Cpp2IlInjected.Address(RVA = "0x6380500", Offset = "0x637F500", VA = "0x186380500", Slot = "10")]
	public AGCCBIKJDAK MMKICHJCCKP(EHCMNHLPJBM KKOFNCEIKDA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003AB")]
	[Cpp2IlInjected.Address(RVA = "0x637FF80", Offset = "0x637EF80", VA = "0x18637FF80", Slot = "11")]
	public HEOOOHDIHMG JGJKHNJFOJD(EHCMNHLPJBM KKOFNCEIKDA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003AC")]
	[Cpp2IlInjected.Address(RVA = "0x63807B0", Offset = "0x637F7B0", VA = "0x1863807B0", Slot = "12")]
	public AOENHBHLFIE OIJEPIONEHP(EHCMNHLPJBM KKOFNCEIKDA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003AD")]
	[Cpp2IlInjected.Address(RVA = "0x637FB70", Offset = "0x637EB70", VA = "0x18637FB70", Slot = "13")]
	public HIIFMKKGLIL BMEBOLGICDA(EHCMNHLPJBM KKOFNCEIKDA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003AE")]
	[Cpp2IlInjected.Address(RVA = "0x637FE10", Offset = "0x637EE10", VA = "0x18637FE10")]
	public BJKCOGNFHAA NOLNAKDKDAI(EHCMNHLPJBM KKOFNCEIKDA, [In] OJNOICCBOJO FCLEEDACIMH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003AF")]
	[Cpp2IlInjected.Address(RVA = "0x637FA70", Offset = "0x637EA70", VA = "0x18637FA70")]
	public FHAABOAKHEB MLANGGFGHIF(EHCMNHLPJBM KKOFNCEIKDA, [In] OJNOICCBOJO FCLEEDACIMH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003B0")]
	[Cpp2IlInjected.Address(RVA = "0x637F930", Offset = "0x637E930", VA = "0x18637F930")]
	public HFBOJOOMHLA AJEBNHHBCOM(EHCMNHLPJBM KKOFNCEIKDA, [In] OJNOICCBOJO FCLEEDACIMH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003B1")]
	[Cpp2IlInjected.Address(RVA = "0x637FF10", Offset = "0x637EF10", VA = "0x18637FF10")]
	public KACNHFAPOGE PLHBGLLLBCK(EHCMNHLPJBM KKOFNCEIKDA, [In] OJNOICCBOJO FCLEEDACIMH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003B2")]
	[Cpp2IlInjected.Address(RVA = "0x6380300", Offset = "0x637F300", VA = "0x186380300")]
	public ADPECGILELO LMGICMACJAC(EHCMNHLPJBM KKOFNCEIKDA, [In] OJNOICCBOJO FCLEEDACIMH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003B3")]
	[Cpp2IlInjected.Address(RVA = "0x63801D0", Offset = "0x637F1D0", VA = "0x1863801D0", Slot = "19")]
	public EHCMNHLPJBM LGLNIFFDNHL(RigidbodyEx ECLMPMCOOIA, OJNOICCBOJO FCLEEDACIMH, IDMHNKCBNME PPJFGCMLNID)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003B4")]
	[Cpp2IlInjected.Address(RVA = "0x7734B0", Offset = "0x7724B0", VA = "0x1807734B0")]
	public HLGPLPDALNL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003B5")]
	[Cpp2IlInjected.Address(RVA = "0x637FE10", Offset = "0x637EE10", VA = "0x18637FE10", Slot = "14")]
	private BJKCOGNFHAA IELGODAMALE(EHCMNHLPJBM KKOFNCEIKDA, [In] OJNOICCBOJO FCLEEDACIMH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003B6")]
	[Cpp2IlInjected.Address(RVA = "0x637FA70", Offset = "0x637EA70", VA = "0x18637FA70", Slot = "15")]
	private FHAABOAKHEB BHJMNBNIEMG(EHCMNHLPJBM KKOFNCEIKDA, [In] OJNOICCBOJO FCLEEDACIMH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003B7")]
	[Cpp2IlInjected.Address(RVA = "0x637F930", Offset = "0x637E930", VA = "0x18637F930", Slot = "16")]
	private HFBOJOOMHLA KIOLGKLEKBC(EHCMNHLPJBM KKOFNCEIKDA, [In] OJNOICCBOJO FCLEEDACIMH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003B8")]
	[Cpp2IlInjected.Address(RVA = "0x637FF10", Offset = "0x637EF10", VA = "0x18637FF10", Slot = "17")]
	private KACNHFAPOGE JGCJOLJKIMG(EHCMNHLPJBM KKOFNCEIKDA, [In] OJNOICCBOJO FCLEEDACIMH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003B9")]
	[Cpp2IlInjected.Address(RVA = "0x63805E0", Offset = "0x637F5E0", VA = "0x1863805E0", Slot = "18")]
	private ADPECGILELO MOLGPANBAAF(EHCMNHLPJBM KKOFNCEIKDA, [In] OJNOICCBOJO FCLEEDACIMH)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000040")]
[DefaultMember("Item")]
public sealed class MNDJJDHPPPL : IReadOnlyList<EHCMNHLPJBM>, IEnumerable<EHCMNHLPJBM>, IEnumerable, IReadOnlyCollection<EHCMNHLPJBM>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000056")]
	public readonly DALFLBHIMAN KFGJIMGDDPH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000057")]
	public readonly DLCIOIDPKIF PJFMIMNFEDC;

	[Cpp2IlInjected.Token(Token = "0x170000F6")]
	public int PLKFCNLILAN
	{
		[Cpp2IlInjected.Token(Token = "0x60003BD")]
		[Cpp2IlInjected.Address(RVA = "0x638D6C0", Offset = "0x638C6C0", VA = "0x18638D6C0", Slot = "5")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000F7")]
	public EHCMNHLPJBM KHIKFGEKFJI
	{
		[Cpp2IlInjected.Token(Token = "0x60003BE")]
		[Cpp2IlInjected.Address(RVA = "0x638D570", Offset = "0x638C570", VA = "0x18638D570", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60003BA")]
	[Cpp2IlInjected.Address(RVA = "0x3E116F0", Offset = "0x3E106F0", VA = "0x183E116F0")]
	public MNDJJDHPPPL(DALFLBHIMAN KFGJIMGDDPH, DLCIOIDPKIF PJFMIMNFEDC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003BB")]
	[Cpp2IlInjected.Address(RVA = "0x638D460", Offset = "0x638C460", VA = "0x18638D460", Slot = "6")]
	public IEnumerator<EHCMNHLPJBM> GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003BC")]
	[Cpp2IlInjected.Address(RVA = "0x638D460", Offset = "0x638C460", VA = "0x18638D460", Slot = "7")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003BF")]
	[Cpp2IlInjected.Address(RVA = "0x638D570", Offset = "0x638C570", VA = "0x18638D570")]
	[CompilerGenerated]
	private EHCMNHLPJBM OMDNBJOFOGO(int LNBKADIBNBM)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000041")]
[IOECDJGDPJM(typeof(CKFHDMFFLAC), new string[] { })]
public class DENPKBEHCEG : CKFHDMFFLAC, LFEOMOKILLA
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000058")]
	private readonly CKFHDMFFLAC CLKIHOIJCEL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000059")]
	private readonly CKFHDMFFLAC AJHKCKHDFBG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400005A")]
	private GKPBFOGMNNB CPKPNGNNIFI;

	[Cpp2IlInjected.Token(Token = "0x170000F8")]
	private CKFHDMFFLAC MIMDCAHINPD
	{
		[Cpp2IlInjected.Token(Token = "0x60003C1")]
		[Cpp2IlInjected.Address(RVA = "0x6373530", Offset = "0x6372530", VA = "0x186373530")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60003C0")]
	[Cpp2IlInjected.Address(RVA = "0x63732F0", Offset = "0x63722F0", VA = "0x1863732F0", Slot = "20")]
	public void InitReferences(MKDBPFPJIJD HCKKNCPHDMK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003C2")]
	[Cpp2IlInjected.Address(RVA = "0x6373730", Offset = "0x6372730", VA = "0x186373730", Slot = "4")]
	public AEHPKHIMIDL LOJAHIJFBGD(EHCMNHLPJBM KKOFNCEIKDA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003C3")]
	[Cpp2IlInjected.Address(RVA = "0x63731A0", Offset = "0x63721A0", VA = "0x1863731A0", Slot = "5")]
	public EGNMEGPNLGB HNHMABEMGJI(EHCMNHLPJBM KKOFNCEIKDA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003C4")]
	[Cpp2IlInjected.Address(RVA = "0x6373910", Offset = "0x6372910", VA = "0x186373910", Slot = "6")]
	public CLEHINCHHDE OFKGIFIMGFJ(EHCMNHLPJBM KKOFNCEIKDA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003C5")]
	[Cpp2IlInjected.Address(RVA = "0x6373100", Offset = "0x6372100", VA = "0x186373100", Slot = "7")]
	public HNFHIEOAONP DIFFELNBIFI(EHCMNHLPJBM KKOFNCEIKDA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003C6")]
	[Cpp2IlInjected.Address(RVA = "0x6373490", Offset = "0x6372490", VA = "0x186373490", Slot = "8")]
	public EKKHALEFJMB KGANCFEAPKO(EHCMNHLPJBM KKOFNCEIKDA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003C7")]
	[Cpp2IlInjected.Address(RVA = "0x6373870", Offset = "0x6372870", VA = "0x186373870", Slot = "9")]
	public HFPBFKAEHJM NIGBNCBFBJJ(EHCMNHLPJBM KKOFNCEIKDA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003C8")]
	[Cpp2IlInjected.Address(RVA = "0x63737D0", Offset = "0x63727D0", VA = "0x1863737D0", Slot = "10")]
	public AGCCBIKJDAK MMKICHJCCKP(EHCMNHLPJBM KKOFNCEIKDA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003C9")]
	[Cpp2IlInjected.Address(RVA = "0x63733F0", Offset = "0x63723F0", VA = "0x1863733F0", Slot = "11")]
	public HEOOOHDIHMG JGJKHNJFOJD(EHCMNHLPJBM KKOFNCEIKDA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003CA")]
	[Cpp2IlInjected.Address(RVA = "0x63739B0", Offset = "0x63729B0", VA = "0x1863739B0", Slot = "12")]
	public AOENHBHLFIE OIJEPIONEHP(EHCMNHLPJBM KKOFNCEIKDA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003CB")]
	[Cpp2IlInjected.Address(RVA = "0x6373060", Offset = "0x6372060", VA = "0x186373060", Slot = "13")]
	public HIIFMKKGLIL BMEBOLGICDA(EHCMNHLPJBM KKOFNCEIKDA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003CC")]
	[Cpp2IlInjected.Address(RVA = "0x6373240", Offset = "0x6372240", VA = "0x186373240")]
	public BJKCOGNFHAA NOLNAKDKDAI(EHCMNHLPJBM KKOFNCEIKDA, [In] OJNOICCBOJO FCLEEDACIMH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003CD")]
	[Cpp2IlInjected.Address(RVA = "0x6372FB0", Offset = "0x6371FB0", VA = "0x186372FB0")]
	public FHAABOAKHEB MLANGGFGHIF(EHCMNHLPJBM KKOFNCEIKDA, [In] OJNOICCBOJO FCLEEDACIMH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003CE")]
	[Cpp2IlInjected.Address(RVA = "0x6372F00", Offset = "0x6371F00", VA = "0x186372F00")]
	public HFBOJOOMHLA AJEBNHHBCOM(EHCMNHLPJBM KKOFNCEIKDA, [In] OJNOICCBOJO FCLEEDACIMH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003CF")]
	[Cpp2IlInjected.Address(RVA = "0x6373340", Offset = "0x6372340", VA = "0x186373340")]
	public KACNHFAPOGE PLHBGLLLBCK(EHCMNHLPJBM KKOFNCEIKDA, [In] OJNOICCBOJO FCLEEDACIMH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003D0")]
	[Cpp2IlInjected.Address(RVA = "0x6373680", Offset = "0x6372680", VA = "0x186373680")]
	public ADPECGILELO LMGICMACJAC(EHCMNHLPJBM KKOFNCEIKDA, [In] OJNOICCBOJO FCLEEDACIMH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003D1")]
	[Cpp2IlInjected.Address(RVA = "0x6373590", Offset = "0x6372590", VA = "0x186373590", Slot = "19")]
	public EHCMNHLPJBM LGLNIFFDNHL(RigidbodyEx ECLMPMCOOIA, OJNOICCBOJO FCLEEDACIMH, IDMHNKCBNME PPJFGCMLNID)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003D2")]
	[Cpp2IlInjected.Address(RVA = "0x6373A50", Offset = "0x6372A50", VA = "0x186373A50")]
	public DENPKBEHCEG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003D3")]
	[Cpp2IlInjected.Address(RVA = "0x6373240", Offset = "0x6372240", VA = "0x186373240", Slot = "14")]
	private BJKCOGNFHAA IELGODAMALE(EHCMNHLPJBM KKOFNCEIKDA, [In] OJNOICCBOJO FCLEEDACIMH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003D4")]
	[Cpp2IlInjected.Address(RVA = "0x6372FB0", Offset = "0x6371FB0", VA = "0x186372FB0", Slot = "15")]
	private FHAABOAKHEB BHJMNBNIEMG(EHCMNHLPJBM KKOFNCEIKDA, [In] OJNOICCBOJO FCLEEDACIMH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003D5")]
	[Cpp2IlInjected.Address(RVA = "0x6372F00", Offset = "0x6371F00", VA = "0x186372F00", Slot = "16")]
	private HFBOJOOMHLA KIOLGKLEKBC(EHCMNHLPJBM KKOFNCEIKDA, [In] OJNOICCBOJO FCLEEDACIMH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003D6")]
	[Cpp2IlInjected.Address(RVA = "0x6373340", Offset = "0x6372340", VA = "0x186373340", Slot = "17")]
	private KACNHFAPOGE JGCJOLJKIMG(EHCMNHLPJBM KKOFNCEIKDA, [In] OJNOICCBOJO FCLEEDACIMH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003D7")]
	[Cpp2IlInjected.Address(RVA = "0x6373680", Offset = "0x6372680", VA = "0x186373680", Slot = "18")]
	private ADPECGILELO MOLGPANBAAF(EHCMNHLPJBM KKOFNCEIKDA, [In] OJNOICCBOJO FCLEEDACIMH)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000042")]
[UnityEngine.Scripting.Preserve]
public sealed class HOLEAGPDGAL : EHCMNHLPJBM, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x400005B")]
	public static readonly HOLEAGPDGAL NKFKDADGOPA;

	[Cpp2IlInjected.Token(Token = "0x170000F9")]
	public Rigidbody JLNHKFKKICK
	{
		[Cpp2IlInjected.Token(Token = "0x60003EA")]
		[Cpp2IlInjected.Address(RVA = "0x76F200", Offset = "0x76E200", VA = "0x18076F200", Slot = "4")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000FA")]
	public RigidbodyEx PBDBDKAJEPD
	{
		[Cpp2IlInjected.Token(Token = "0x60003EB")]
		[Cpp2IlInjected.Address(RVA = "0x76F210", Offset = "0x76E210", VA = "0x18076F210", Slot = "5")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000FB")]
	public GameObject PHKAEJEKHIF
	{
		[Cpp2IlInjected.Token(Token = "0x60003EC")]
		[Cpp2IlInjected.Address(RVA = "0x76F1F0", Offset = "0x76E1F0", VA = "0x18076F1F0", Slot = "6")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000FC")]
	public Transform FHHLKDMADLC
	{
		[Cpp2IlInjected.Token(Token = "0x60003ED")]
		[Cpp2IlInjected.Address(RVA = "0x76F1C0", Offset = "0x76E1C0", VA = "0x18076F1C0", Slot = "7")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000FD")]
	public EHCMNHLPJBM CPGMADILNAD
	{
		[Cpp2IlInjected.Token(Token = "0x60003EE")]
		[Cpp2IlInjected.Address(RVA = "0x76F1D0", Offset = "0x76E1D0", VA = "0x18076F1D0", Slot = "8")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60003EF")]
		[Cpp2IlInjected.Address(RVA = "0x76F220", Offset = "0x76E220", VA = "0x18076F220", Slot = "9")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000FE")]
	public IReadOnlyList<EHCMNHLPJBM> NKNGGFCLKKC
	{
		[Cpp2IlInjected.Token(Token = "0x60003F0")]
		[Cpp2IlInjected.Address(RVA = "0x774F60", Offset = "0x773F60", VA = "0x180774F60", Slot = "10")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000FF")]
	public EHCMNHLPJBM FMAEDMDFLJE
	{
		[Cpp2IlInjected.Token(Token = "0x60003F1")]
		[Cpp2IlInjected.Address(RVA = "0x779C40", Offset = "0x778C40", VA = "0x180779C40", Slot = "11")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000100")]
	public bool GCPNKEIHNJF
	{
		[Cpp2IlInjected.Token(Token = "0x60003F2")]
		[Cpp2IlInjected.Address(RVA = "0x7F9460", Offset = "0x7F8460", VA = "0x1807F9460", Slot = "12")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000101")]
	public bool FLDOPHCHFPM
	{
		[Cpp2IlInjected.Token(Token = "0x60003F3")]
		[Cpp2IlInjected.Address(RVA = "0xCEC4D0", Offset = "0xCEB4D0", VA = "0x180CEC4D0", Slot = "13")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000102")]
	public AFBJPJGOHAH PAKEEKMBNJI
	{
		[Cpp2IlInjected.Token(Token = "0x60003F4")]
		[Cpp2IlInjected.Address(RVA = "0x7738C0", Offset = "0x7728C0", VA = "0x1807738C0", Slot = "14")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60003F5")]
		[Cpp2IlInjected.Address(RVA = "0x7738F0", Offset = "0x7728F0", VA = "0x1807738F0", Slot = "15")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000103")]
	public GAMCJHNBHDA CONGFAJKAFK
	{
		[Cpp2IlInjected.Token(Token = "0x60003F6")]
		[Cpp2IlInjected.Address(RVA = "0x7738E0", Offset = "0x7728E0", VA = "0x1807738E0", Slot = "16")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60003F7")]
		[Cpp2IlInjected.Address(RVA = "0x773910", Offset = "0x772910", VA = "0x180773910", Slot = "17")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000104")]
	public float CEJDFPIKKNH
	{
		[Cpp2IlInjected.Token(Token = "0x60003F8")]
		[Cpp2IlInjected.Address(RVA = "0x97D640", Offset = "0x97C640", VA = "0x18097D640", Slot = "18")]
		[CompilerGenerated]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x60003F9")]
		[Cpp2IlInjected.Address(RVA = "0x83C9B0", Offset = "0x83B9B0", VA = "0x18083C9B0", Slot = "19")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000105")]
	public Vector3 ONCBIGPFDBG
	{
		[Cpp2IlInjected.Token(Token = "0x60003FA")]
		[Cpp2IlInjected.Address(RVA = "0x1A90130", Offset = "0x1A8F130", VA = "0x181A90130", Slot = "20")]
		[CompilerGenerated]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x60003FB")]
		[Cpp2IlInjected.Address(RVA = "0x351E420", Offset = "0x351D420", VA = "0x18351E420", Slot = "21")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000106")]
	public Vector3 DINKBHOHIJN
	{
		[Cpp2IlInjected.Token(Token = "0x60003FC")]
		[Cpp2IlInjected.Address(RVA = "0x6381470", Offset = "0x6380470", VA = "0x186381470", Slot = "22")]
		[CompilerGenerated]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x60003FD")]
		[Cpp2IlInjected.Address(RVA = "0x6381460", Offset = "0x6380460", VA = "0x186381460", Slot = "23")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000107")]
	public Vector3 JLKBIOAHEKE
	{
		[Cpp2IlInjected.Token(Token = "0x60003FE")]
		[Cpp2IlInjected.Address(RVA = "0x4575920", Offset = "0x4574920", VA = "0x184575920", Slot = "24")]
		[CompilerGenerated]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x60003FF")]
		[Cpp2IlInjected.Address(RVA = "0x19BC010", Offset = "0x19BB010", VA = "0x1819BC010", Slot = "25")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000108")]
	public Vector3 ILEPAAIOGPH
	{
		[Cpp2IlInjected.Token(Token = "0x6000400")]
		[Cpp2IlInjected.Address(RVA = "0xAB62A0", Offset = "0xAB52A0", VA = "0x180AB62A0", Slot = "26")]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x6000401")]
		[Cpp2IlInjected.Address(RVA = "0x770CB0", Offset = "0x76FCB0", VA = "0x180770CB0", Slot = "27")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000109")]
	public bool CPKNHGNOJKA
	{
		[Cpp2IlInjected.Token(Token = "0x6000402")]
		[Cpp2IlInjected.Address(RVA = "0x8BD1B0", Offset = "0x8BC1B0", VA = "0x1808BD1B0", Slot = "28")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700010A")]
	public bool OPNOHLFFIJB
	{
		[Cpp2IlInjected.Token(Token = "0x6000403")]
		[Cpp2IlInjected.Address(RVA = "0x16DDF40", Offset = "0x16DCF40", VA = "0x1816DDF40", Slot = "29")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700010B")]
	public bool CNPBCJLHPAJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000404")]
		[Cpp2IlInjected.Address(RVA = "0x5C667E0", Offset = "0x5C657E0", VA = "0x185C667E0", Slot = "30")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700010C")]
	public Vector3 BGJFIEJBIJF
	{
		[Cpp2IlInjected.Token(Token = "0x6000405")]
		[Cpp2IlInjected.Address(RVA = "0x4579200", Offset = "0x4578200", VA = "0x184579200", Slot = "31")]
		[CompilerGenerated]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700010D")]
	public Vector3 FLCGLBNKKAA
	{
		[Cpp2IlInjected.Token(Token = "0x6000406")]
		[Cpp2IlInjected.Address(RVA = "0x92D970", Offset = "0x92C970", VA = "0x18092D970", Slot = "32")]
		[CompilerGenerated]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700010E")]
	public Vector3 LADKEMIALFK
	{
		[Cpp2IlInjected.Token(Token = "0x6000407")]
		[Cpp2IlInjected.Address(RVA = "0xAB62A0", Offset = "0xAB52A0", VA = "0x180AB62A0", Slot = "33")]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x6000408")]
		[Cpp2IlInjected.Address(RVA = "0x770CB0", Offset = "0x76FCB0", VA = "0x180770CB0", Slot = "34")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700010F")]
	public Vector3 PIICNOJNCPP
	{
		[Cpp2IlInjected.Token(Token = "0x6000409")]
		[Cpp2IlInjected.Address(RVA = "0x6381440", Offset = "0x6380440", VA = "0x186381440", Slot = "35")]
		[CompilerGenerated]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000110")]
	public float DGAGBHADGJN
	{
		[Cpp2IlInjected.Token(Token = "0x600040A")]
		[Cpp2IlInjected.Address(RVA = "0x5419E20", Offset = "0x5418E20", VA = "0x185419E20", Slot = "36")]
		[CompilerGenerated]
		get
		{
			return default(float);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000111")]
	public float LLNDLOGDDIG
	{
		[Cpp2IlInjected.Token(Token = "0x600040B")]
		[Cpp2IlInjected.Address(RVA = "0x7C5FE0", Offset = "0x7C4FE0", VA = "0x1807C5FE0", Slot = "37")]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x600040C")]
		[Cpp2IlInjected.Address(RVA = "0x770CB0", Offset = "0x76FCB0", VA = "0x180770CB0", Slot = "38")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000112")]
	public Vector3 HNOLHOHLFKJ
	{
		[Cpp2IlInjected.Token(Token = "0x600040D")]
		[Cpp2IlInjected.Address(RVA = "0xAB62A0", Offset = "0xAB52A0", VA = "0x180AB62A0", Slot = "39")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000113")]
	public Quaternion LONFIJLGBOG
	{
		[Cpp2IlInjected.Token(Token = "0x600040E")]
		[Cpp2IlInjected.Address(RVA = "0x7C4660", Offset = "0x7C3660", VA = "0x1807C4660", Slot = "40")]
		get
		{
			return default(Quaternion);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000114")]
	public float EBALBFJEABI
	{
		[Cpp2IlInjected.Token(Token = "0x6000410")]
		[Cpp2IlInjected.Address(RVA = "0x7C5FE0", Offset = "0x7C4FE0", VA = "0x1807C5FE0", Slot = "42")]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x6000411")]
		[Cpp2IlInjected.Address(RVA = "0x770CB0", Offset = "0x76FCB0", VA = "0x180770CB0", Slot = "43")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000115")]
	public float FBKHGEIFEEL
	{
		[Cpp2IlInjected.Token(Token = "0x6000412")]
		[Cpp2IlInjected.Address(RVA = "0x7C5FE0", Offset = "0x7C4FE0", VA = "0x1807C5FE0", Slot = "44")]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x6000413")]
		[Cpp2IlInjected.Address(RVA = "0x770CB0", Offset = "0x76FCB0", VA = "0x180770CB0", Slot = "45")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000116")]
	public bool BJICAJLOKDG
	{
		[Cpp2IlInjected.Token(Token = "0x6000414")]
		[Cpp2IlInjected.Address(RVA = "0x7BA2E0", Offset = "0x7B92E0", VA = "0x1807BA2E0", Slot = "46")]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000415")]
		[Cpp2IlInjected.Address(RVA = "0x770CB0", Offset = "0x76FCB0", VA = "0x180770CB0", Slot = "47")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000117")]
	public BAGHKPJGLEA HJLBEPGNACN
	{
		[Cpp2IlInjected.Token(Token = "0x6000416")]
		[Cpp2IlInjected.Address(RVA = "0x7BA2E0", Offset = "0x7B92E0", VA = "0x1807BA2E0", Slot = "48")]
		get
		{
			return default(BAGHKPJGLEA);
		}
		[Cpp2IlInjected.Token(Token = "0x6000417")]
		[Cpp2IlInjected.Address(RVA = "0x770CB0", Offset = "0x76FCB0", VA = "0x180770CB0", Slot = "49")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000118")]
	public bool KFMBBJLEAJK
	{
		[Cpp2IlInjected.Token(Token = "0x6000418")]
		[Cpp2IlInjected.Address(RVA = "0x114D370", Offset = "0x114C370", VA = "0x18114D370", Slot = "50")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000119")]
	public Transform GCGFCFBOGAL
	{
		[Cpp2IlInjected.Token(Token = "0x6000419")]
		[Cpp2IlInjected.Address(RVA = "0x88E830", Offset = "0x88D830", VA = "0x18088E830", Slot = "51")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700011A")]
	public Vector3 LAFFMBPMCBK
	{
		[Cpp2IlInjected.Token(Token = "0x600041A")]
		[Cpp2IlInjected.Address(RVA = "0xAB62A0", Offset = "0xAB52A0", VA = "0x180AB62A0", Slot = "52")]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x600041B")]
		[Cpp2IlInjected.Address(RVA = "0x770CB0", Offset = "0x76FCB0", VA = "0x180770CB0", Slot = "53")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700011B")]
	public float ABAAKHNHDME
	{
		[Cpp2IlInjected.Token(Token = "0x600041C")]
		[Cpp2IlInjected.Address(RVA = "0x7C5FE0", Offset = "0x7C4FE0", VA = "0x1807C5FE0", Slot = "54")]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x600041D")]
		[Cpp2IlInjected.Address(RVA = "0x770CB0", Offset = "0x76FCB0", VA = "0x180770CB0", Slot = "55")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700011C")]
	public float JFAHGDFBNGK
	{
		[Cpp2IlInjected.Token(Token = "0x600041E")]
		[Cpp2IlInjected.Address(RVA = "0x7C5FE0", Offset = "0x7C4FE0", VA = "0x1807C5FE0", Slot = "56")]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x600041F")]
		[Cpp2IlInjected.Address(RVA = "0x770CB0", Offset = "0x76FCB0", VA = "0x180770CB0", Slot = "57")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700011D")]
	public Quaternion NBMJCMLBMDE
	{
		[Cpp2IlInjected.Token(Token = "0x6000420")]
		[Cpp2IlInjected.Address(RVA = "0x8F5E70", Offset = "0x8F4E70", VA = "0x1808F5E70", Slot = "58")]
		get
		{
			return default(Quaternion);
		}
		[Cpp2IlInjected.Token(Token = "0x6000421")]
		[Cpp2IlInjected.Address(RVA = "0x770CB0", Offset = "0x76FCB0", VA = "0x180770CB0", Slot = "59")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700011E")]
	public Vector3 LGOPKPGLOLL
	{
		[Cpp2IlInjected.Token(Token = "0x6000422")]
		[Cpp2IlInjected.Address(RVA = "0xAB62A0", Offset = "0xAB52A0", VA = "0x180AB62A0", Slot = "60")]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x6000423")]
		[Cpp2IlInjected.Address(RVA = "0x770CB0", Offset = "0x76FCB0", VA = "0x180770CB0", Slot = "61")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700011F")]
	public Quaternion JGPPPKPPDBC
	{
		[Cpp2IlInjected.Token(Token = "0x6000424")]
		[Cpp2IlInjected.Address(RVA = "0x8F5E70", Offset = "0x8F4E70", VA = "0x1808F5E70", Slot = "62")]
		get
		{
			return default(Quaternion);
		}
		[Cpp2IlInjected.Token(Token = "0x6000425")]
		[Cpp2IlInjected.Address(RVA = "0x770CB0", Offset = "0x76FCB0", VA = "0x180770CB0", Slot = "63")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000120")]
	public RigidbodyConstraints NPGAMCBNMHD
	{
		[Cpp2IlInjected.Token(Token = "0x6000426")]
		[Cpp2IlInjected.Address(RVA = "0x770CC0", Offset = "0x76FCC0", VA = "0x180770CC0", Slot = "64")]
		get
		{
			return default(RigidbodyConstraints);
		}
		[Cpp2IlInjected.Token(Token = "0x6000427")]
		[Cpp2IlInjected.Address(RVA = "0x770CB0", Offset = "0x76FCB0", VA = "0x180770CB0", Slot = "65")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000121")]
	public bool MIOAIPJJMGG
	{
		[Cpp2IlInjected.Token(Token = "0x6000428")]
		[Cpp2IlInjected.Address(RVA = "0x7BA2E0", Offset = "0x7B92E0", VA = "0x1807BA2E0", Slot = "66")]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000429")]
		[Cpp2IlInjected.Address(RVA = "0x770CB0", Offset = "0x76FCB0", VA = "0x180770CB0", Slot = "67")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000122")]
	public CollisionDetectionMode MHGBGHOHCOK
	{
		[Cpp2IlInjected.Token(Token = "0x600042A")]
		[Cpp2IlInjected.Address(RVA = "0x770CC0", Offset = "0x76FCC0", VA = "0x180770CC0", Slot = "68")]
		get
		{
			return default(CollisionDetectionMode);
		}
		[Cpp2IlInjected.Token(Token = "0x600042B")]
		[Cpp2IlInjected.Address(RVA = "0x770CB0", Offset = "0x76FCB0", VA = "0x180770CB0", Slot = "69")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000123")]
	public bool JEPMPAKBHKE
	{
		[Cpp2IlInjected.Token(Token = "0x600042C")]
		[Cpp2IlInjected.Address(RVA = "0x84B830", Offset = "0x84A830", VA = "0x18084B830", Slot = "70")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000038")]
	public event ODMKMIKDLDH HNIODPCALEE
	{
		[Cpp2IlInjected.Token(Token = "0x60003D8")]
		[Cpp2IlInjected.Address(RVA = "0x770CB0", Offset = "0x76FCB0", VA = "0x180770CB0", Slot = "75")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60003D9")]
		[Cpp2IlInjected.Address(RVA = "0x770CB0", Offset = "0x76FCB0", VA = "0x180770CB0", Slot = "76")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000039")]
	public event ODMKMIKDLDH ICDJPNDLGPD
	{
		[Cpp2IlInjected.Token(Token = "0x60003DA")]
		[Cpp2IlInjected.Address(RVA = "0x770CB0", Offset = "0x76FCB0", VA = "0x180770CB0", Slot = "77")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60003DB")]
		[Cpp2IlInjected.Address(RVA = "0x770CB0", Offset = "0x76FCB0", VA = "0x180770CB0", Slot = "78")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400003A")]
	public event LNHELIADCNA JAPGMOHDICK
	{
		[Cpp2IlInjected.Token(Token = "0x60003DC")]
		[Cpp2IlInjected.Address(RVA = "0x770CB0", Offset = "0x76FCB0", VA = "0x180770CB0", Slot = "79")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60003DD")]
		[Cpp2IlInjected.Address(RVA = "0x770CB0", Offset = "0x76FCB0", VA = "0x180770CB0", Slot = "80")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400003B")]
	public event ODMKMIKDLDH GIADDJGCKPO
	{
		[Cpp2IlInjected.Token(Token = "0x60003DE")]
		[Cpp2IlInjected.Address(RVA = "0x770CB0", Offset = "0x76FCB0", VA = "0x180770CB0", Slot = "82")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60003DF")]
		[Cpp2IlInjected.Address(RVA = "0x770CB0", Offset = "0x76FCB0", VA = "0x180770CB0", Slot = "83")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400003C")]
	public event ODMKMIKDLDH GFDLDDIJKHF
	{
		[Cpp2IlInjected.Token(Token = "0x60003E0")]
		[Cpp2IlInjected.Address(RVA = "0x770CB0", Offset = "0x76FCB0", VA = "0x180770CB0", Slot = "102")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60003E1")]
		[Cpp2IlInjected.Address(RVA = "0x770CB0", Offset = "0x76FCB0", VA = "0x180770CB0", Slot = "103")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400003D")]
	public event ODMKMIKDLDH AGBEMFNHAAD
	{
		[Cpp2IlInjected.Token(Token = "0x60003E2")]
		[Cpp2IlInjected.Address(RVA = "0x770CB0", Offset = "0x76FCB0", VA = "0x180770CB0", Slot = "107")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60003E3")]
		[Cpp2IlInjected.Address(RVA = "0x770CB0", Offset = "0x76FCB0", VA = "0x180770CB0", Slot = "108")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400003E")]
	public event Action<FDHMLINJMLJ, FDHMLINJMLJ> IOALOLNJHBM
	{
		[Cpp2IlInjected.Token(Token = "0x60003E4")]
		[Cpp2IlInjected.Address(RVA = "0x770CB0", Offset = "0x76FCB0", VA = "0x180770CB0", Slot = "111")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60003E5")]
		[Cpp2IlInjected.Address(RVA = "0x770CB0", Offset = "0x76FCB0", VA = "0x180770CB0", Slot = "112")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400003F")]
	public event ODMKMIKDLDH IJHOLLBGJPD
	{
		[Cpp2IlInjected.Token(Token = "0x60003E6")]
		[Cpp2IlInjected.Address(RVA = "0x770CB0", Offset = "0x76FCB0", VA = "0x180770CB0", Slot = "113")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60003E7")]
		[Cpp2IlInjected.Address(RVA = "0x770CB0", Offset = "0x76FCB0", VA = "0x180770CB0", Slot = "114")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000040")]
	public event ODMKMIKDLDH EKOMCGBKAOG
	{
		[Cpp2IlInjected.Token(Token = "0x60003E8")]
		[Cpp2IlInjected.Address(RVA = "0x770CB0", Offset = "0x76FCB0", VA = "0x180770CB0", Slot = "119")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60003E9")]
		[Cpp2IlInjected.Address(RVA = "0x770CB0", Offset = "0x76FCB0", VA = "0x180770CB0", Slot = "120")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600040F")]
	[Cpp2IlInjected.Address(RVA = "0x770CB0", Offset = "0x76FCB0", VA = "0x180770CB0", Slot = "41")]
	public void PECPHAKBJCG((Quaternion rot, Vector3 moments) IJPGGILEIIN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600042D")]
	[Cpp2IlInjected.Address(RVA = "0x770CB0", Offset = "0x76FCB0", VA = "0x180770CB0", Slot = "71")]
	public void NPFDHKEDPBK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600042E")]
	[Cpp2IlInjected.Address(RVA = "0x770CB0", Offset = "0x76FCB0", VA = "0x180770CB0", Slot = "72")]
	public void DHFPKEPDKMD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600042F")]
	[Cpp2IlInjected.Address(RVA = "0x770CB0", Offset = "0x76FCB0", VA = "0x180770CB0", Slot = "73")]
	public void ACFAANOHPBB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000430")]
	[Cpp2IlInjected.Address(RVA = "0x770CB0", Offset = "0x76FCB0", VA = "0x180770CB0", Slot = "74")]
	public void EIHNIBFOFFJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000431")]
	[Cpp2IlInjected.Address(RVA = "0x770CB0", Offset = "0x76FCB0", VA = "0x180770CB0", Slot = "134")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000432")]
	[Cpp2IlInjected.Address(RVA = "0x770CB0", Offset = "0x76FCB0", VA = "0x180770CB0", Slot = "81")]
	public void GLKDGJFHDGI(EHCMNHLPJBM APPJEOKOGAK, bool FMNAIIPBFHC = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000433")]
	[Cpp2IlInjected.Address(RVA = "0x770CB0", Offset = "0x76FCB0", VA = "0x180770CB0", Slot = "84")]
	public void PLEAHDIMCIE(object PDIBILKHEBM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000434")]
	[Cpp2IlInjected.Address(RVA = "0x770CB0", Offset = "0x76FCB0", VA = "0x180770CB0", Slot = "85")]
	public void JJAALHAEDJD(object PDIBILKHEBM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000435")]
	[Cpp2IlInjected.Address(RVA = "0xAB62A0", Offset = "0xAB52A0", VA = "0x180AB62A0", Slot = "86")]
	public Vector3 ECOHLCBCAIO(Vector3 IACNFCFIIOM)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000436")]
	[Cpp2IlInjected.Address(RVA = "0xAB62A0", Offset = "0xAB52A0", VA = "0x180AB62A0", Slot = "87")]
	public Vector3 FNKNMFKCFHO(Vector3 GMLDNFHDNJP)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000437")]
	[Cpp2IlInjected.Address(RVA = "0x770CB0", Offset = "0x76FCB0", VA = "0x180770CB0", Slot = "88")]
	public void MBDGEAIJODJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000438")]
	[Cpp2IlInjected.Address(RVA = "0x770CB0", Offset = "0x76FCB0", VA = "0x180770CB0", Slot = "89")]
	public void GAMMNKDKDMP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000439")]
	[Cpp2IlInjected.Address(RVA = "0x770CB0", Offset = "0x76FCB0", VA = "0x180770CB0", Slot = "90")]
	public void BCBGBGNDMKE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600043A")]
	[Cpp2IlInjected.Address(RVA = "0x770CB0", Offset = "0x76FCB0", VA = "0x180770CB0", Slot = "91")]
	public void MLEAMOMCHPM(Vector3 PFBOCMNHECB, Vector3 EGGKDKAICGO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600043B")]
	[Cpp2IlInjected.Address(RVA = "0x770CB0", Offset = "0x76FCB0", VA = "0x180770CB0", Slot = "92")]
	public void NADJGLGOMJF(Vector3 ACIPBFHCAAA, Vector3 PLLAPIPLOBE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600043C")]
	[Cpp2IlInjected.Address(RVA = "0x770CB0", Offset = "0x76FCB0", VA = "0x180770CB0", Slot = "93")]
	public void KEIBJNKFFKK(Vector3 BCLKICLJPAP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600043D")]
	[Cpp2IlInjected.Address(RVA = "0x770CB0", Offset = "0x76FCB0", VA = "0x180770CB0", Slot = "94")]
	public void IHIBCDABGEA(BOLJBMMECOE DBGBHNOCNJE, Vector3 HGEDCNMOIAN, float NBBOEEPKJMP, float MFOFCNBGOEE = 8f, float JKNAHEBOBHM = 1f)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600043E")]
	[Cpp2IlInjected.Address(RVA = "0x770CB0", Offset = "0x76FCB0", VA = "0x180770CB0", Slot = "95")]
	public void EHCOAACKECM(LGPMEMPGHMC CFIODOIHFKI, Vector3 POKFEHNNFOH, float NLCECILHIIF = float.PositiveInfinity)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600043F")]
	[Cpp2IlInjected.Address(RVA = "0x770CB0", Offset = "0x76FCB0", VA = "0x180770CB0", Slot = "96")]
	public void IAGIBKOHJDJ(LGPMEMPGHMC CFIODOIHFKI, Vector3 LGOFCBEILGM, float DPKKDMEAKFE = 7f, float DLNPOBOGDPN = 1f)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000440")]
	[Cpp2IlInjected.Address(RVA = "0xAB62A0", Offset = "0xAB52A0", VA = "0x180AB62A0", Slot = "97")]
	public Vector3 NKFAKMKMGLK(Vector3 APPJEOKOGAK)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000441")]
	[Cpp2IlInjected.Address(RVA = "0xAB62A0", Offset = "0xAB52A0", VA = "0x180AB62A0", Slot = "98")]
	public Vector3 MHKJOCEAOOK(Vector3 APPJEOKOGAK)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000442")]
	[Cpp2IlInjected.Address(RVA = "0x770CB0", Offset = "0x76FCB0", VA = "0x180770CB0", Slot = "99")]
	public void DACCEJMCHOM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000443")]
	[Cpp2IlInjected.Address(RVA = "0x770CB0", Offset = "0x76FCB0", VA = "0x180770CB0", Slot = "100")]
	public void LIMAGEHFCDJ(EHCMNHLPJBM OHPBKIJPBEH, object PDIBILKHEBM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000444")]
	[Cpp2IlInjected.Address(RVA = "0x770CB0", Offset = "0x76FCB0", VA = "0x180770CB0", Slot = "101")]
	public void MHICMANCFJE(object PDIBILKHEBM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000445")]
	[Cpp2IlInjected.Address(RVA = "0x770CB0", Offset = "0x76FCB0", VA = "0x180770CB0", Slot = "104")]
	public void EMOEILKEJBE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000446")]
	[Cpp2IlInjected.Address(RVA = "0x770CB0", Offset = "0x76FCB0", VA = "0x180770CB0", Slot = "105")]
	public void NKANMLKMEBG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000447")]
	[Cpp2IlInjected.Address(RVA = "0x770CB0", Offset = "0x76FCB0", VA = "0x180770CB0", Slot = "106")]
	public void FAMCOJOMDOD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000448")]
	[Cpp2IlInjected.Address(RVA = "0x7BA2E0", Offset = "0x7B92E0", VA = "0x1807BA2E0", Slot = "109")]
	public bool NKFKNEFDAFK()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000449")]
	[Cpp2IlInjected.Address(RVA = "0x770CB0", Offset = "0x76FCB0", VA = "0x180770CB0", Slot = "110")]
	public void JPMGMMIEBBB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600044A")]
	[Cpp2IlInjected.Address(RVA = "0x770CC0", Offset = "0x76FCC0", VA = "0x180770CC0", Slot = "115")]
	public IDisposable HLJKBPAJOBH()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600044B")]
	[Cpp2IlInjected.Address(RVA = "0x770CB0", Offset = "0x76FCB0", VA = "0x180770CB0", Slot = "116")]
	public void JPFGFDECHOJ(object PDIBILKHEBM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600044C")]
	[Cpp2IlInjected.Address(RVA = "0x770CB0", Offset = "0x76FCB0", VA = "0x180770CB0", Slot = "117")]
	public void KAPPGEIEJKO(object PDIBILKHEBM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600044D")]
	[Cpp2IlInjected.Address(RVA = "0x770CB0", Offset = "0x76FCB0", VA = "0x180770CB0", Slot = "118")]
	public void GJJAJKOMBNJ(object PDIBILKHEBM, bool GKHMPKCJGHP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600044E")]
	[Cpp2IlInjected.Address(RVA = "0x770CB0", Offset = "0x76FCB0", VA = "0x180770CB0", Slot = "121")]
	public void EBAFIDPJBLL(Vector3 LMCNGGBBGAK, Quaternion LJGGLNEHBNN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600044F")]
	[Cpp2IlInjected.Address(RVA = "0x770CB0", Offset = "0x76FCB0", VA = "0x180770CB0", Slot = "122")]
	public void PMLIDMGNBMJ(Vector3 AGFHJEELBOM, Quaternion DBJKCMEGHMK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000450")]
	[Cpp2IlInjected.Address(RVA = "0x7BA2E0", Offset = "0x7B92E0", VA = "0x1807BA2E0", Slot = "123")]
	public bool LKLNFACJBJF(float MGEAGKCABGB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000451")]
	[Cpp2IlInjected.Address(RVA = "0x770CB0", Offset = "0x76FCB0", VA = "0x180770CB0", Slot = "124")]
	public void KMEFLHLDIKM(object PDIBILKHEBM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000452")]
	[Cpp2IlInjected.Address(RVA = "0x770CB0", Offset = "0x76FCB0", VA = "0x180770CB0", Slot = "125")]
	public void BKKCKHAEOCM(object PDIBILKHEBM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000453")]
	[Cpp2IlInjected.Address(RVA = "0x770CB0", Offset = "0x76FCB0", VA = "0x180770CB0", Slot = "126")]
	public void JEJJNCIBMKD(object PDIBILKHEBM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000454")]
	[Cpp2IlInjected.Address(RVA = "0x770CB0", Offset = "0x76FCB0", VA = "0x180770CB0", Slot = "127")]
	public void MPNABKADOLD(object PDIBILKHEBM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000455")]
	[Cpp2IlInjected.Address(RVA = "0x770CB0", Offset = "0x76FCB0", VA = "0x180770CB0", Slot = "128")]
	public void IJKJHGBBCEG(Vector3 OFOIDDLLFEI, ForceMode OJEDHHILKEL = ForceMode.Force)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000456")]
	[Cpp2IlInjected.Address(RVA = "0x770CB0", Offset = "0x76FCB0", VA = "0x180770CB0", Slot = "129")]
	public void HIDBDPPDDNG(Vector3 OFOIDDLLFEI, Vector3 LPGLCEHEHMC, ForceMode OJEDHHILKEL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000457")]
	[Cpp2IlInjected.Address(RVA = "0x770CB0", Offset = "0x76FCB0", VA = "0x180770CB0", Slot = "130")]
	public void FEDPGNOKGDK(Vector3 LGKLDHJLFFC, ForceMode OJEDHHILKEL = ForceMode.Force)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000458")]
	[Cpp2IlInjected.Address(RVA = "0x770CB0", Offset = "0x76FCB0", VA = "0x180770CB0", Slot = "131")]
	public void KBMMINBNLNN(Vector3 LGKLDHJLFFC, ForceMode OJEDHHILKEL = ForceMode.Force)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000459")]
	[Cpp2IlInjected.Address(RVA = "0x6381420", Offset = "0x6380420", VA = "0x186381420", Slot = "132")]
	public bool BDBHIBJMAFO(Vector3 AKNDOLIKNGM, [Out] RaycastHit MGAKEPJNIDG, float IBOJBDBEJBJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600045A")]
	[Cpp2IlInjected.Address(RVA = "0x770CB0", Offset = "0x76FCB0", VA = "0x180770CB0", Slot = "133")]
	public void BLJKMNBKPBO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600045B")]
	[Cpp2IlInjected.Address(RVA = "0x7734B0", Offset = "0x7724B0", VA = "0x1807734B0")]
	public HOLEAGPDGAL()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000043")]
public sealed class NCLMDAABOOP : FGCABOJBJBA, CBBNHNONOOK, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
	[Cpp2IlInjected.Token(Token = "0x4000075")]
	internal DALFLBHIMAN KFGJIMGDDPH;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
	[Cpp2IlInjected.Token(Token = "0x4000076")]
	internal DLCIOIDPKIF AOKDDCFNPJI;

	[Cpp2IlInjected.Token(Token = "0x600045D")]
	[Cpp2IlInjected.Address(RVA = "0x637A920", Offset = "0x6379920", VA = "0x18637A920")]
	public NCLMDAABOOP(GameObject GFBHJHHLEFD, RigidbodyEx PFIDAIAGHJK, IDMHNKCBNME PPJFGCMLNID, [In] OJNOICCBOJO FCLEEDACIMH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600045E")]
	[Cpp2IlInjected.Address(RVA = "0x638E610", Offset = "0x638D610", VA = "0x18638E610", Slot = "135")]
	protected override void ODEHOFGDECA(IDMHNKCBNME PPJFGCMLNID, OJNOICCBOJO FCLEEDACIMH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600045F")]
	[Cpp2IlInjected.Address(RVA = "0x770CC0", Offset = "0x76FCC0", VA = "0x180770CC0", Slot = "141")]
	protected override IDisposable PLIPGHDOALO()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000460")]
	[Cpp2IlInjected.Address(RVA = "0x638DE30", Offset = "0x638CE30", VA = "0x18638DE30", Slot = "136")]
	public override void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000461")]
	[Cpp2IlInjected.Address(RVA = "0x638E540", Offset = "0x638D540", VA = "0x18638E540", Slot = "142")]
	public void MIBFJFIDBJN(PAFBKJKOEMO MJGALODGAME, PAFBKJKOEMO NMFMKGLEEKB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000462")]
	[Cpp2IlInjected.Address(RVA = "0x638DFA0", Offset = "0x638CFA0", VA = "0x18638DFA0", Slot = "143")]
	public void EEKCNBMHPNL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000463")]
	[Cpp2IlInjected.Address(RVA = "0x638E060", Offset = "0x638D060", VA = "0x18638E060", Slot = "144")]
	public void EOLKNCFLMDO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000464")]
	[Cpp2IlInjected.Address(RVA = "0x638E880", Offset = "0x638D880", VA = "0x18638E880", Slot = "145")]
	public void OMMJOFBDFBB(bool JIPBGPFOHIP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000465")]
	[Cpp2IlInjected.Address(RVA = "0x638E120", Offset = "0x638D120", VA = "0x18638E120", Slot = "146")]
	public bool GPPDMENNEDJ()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000466")]
	[Cpp2IlInjected.Address(RVA = "0x638E2B0", Offset = "0x638D2B0", VA = "0x18638E2B0", Slot = "147")]
	public void KCBFCEHGCKM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000467")]
	[Cpp2IlInjected.Address(RVA = "0x770CB0", Offset = "0x76FCB0", VA = "0x180770CB0", Slot = "140")]
	protected override void OBEHIOJJCBD(RigidbodyEx GDKIMOIKOFD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000468")]
	[Cpp2IlInjected.Address(RVA = "0x638E310", Offset = "0x638D310", VA = "0x18638E310")]
	private void LLPPALOECGO()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000044")]
internal static class IAOMFPEPPEC
{
	[Cpp2IlInjected.Token(Token = "0x6000469")]
	[Cpp2IlInjected.Address(RVA = "0x6381510", Offset = "0x6380510", VA = "0x186381510")]
	public static FGCABOJBJBA BDPJHOELJOD(this EHCMNHLPJBM KKOFNCEIKDA)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000045")]
public interface EHOBGOHHOMI : AEHPKHIMIDL, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x600046A")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void AFEGLLIBHOI(EHCMNHLPJBM ECLMPMCOOIA);

	[Cpp2IlInjected.Token(Token = "0x600046B")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void HACPIENJING(EHCMNHLPJBM ECLMPMCOOIA);

	[Cpp2IlInjected.Token(Token = "0x600046C")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void DABHHHAAOME(EHCMNHLPJBM NLMONBKCPDM);

	[Cpp2IlInjected.Token(Token = "0x600046D")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void BHLMHEOGKBI(EHCMNHLPJBM NLMONBKCPDM);
}
[Cpp2IlInjected.Token(Token = "0x2000046")]
public interface EPHGCAGMHDB : CLEHINCHHDE
{
	[Cpp2IlInjected.Token(Token = "0x17000124")]
	ICHGNBFAFCD<EHCMNHLPJBM> JIHANHIKLEP
	{
		[Cpp2IlInjected.Token(Token = "0x600046E")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000125")]
	EHCMNHLPJBM DEMKBLBDOIF
	{
		[Cpp2IlInjected.Token(Token = "0x600046F")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000047")]
public interface NPFNHIBGCFO : KACNHFAPOGE
{
	[Cpp2IlInjected.Token(Token = "0x6000470")]
	[Cpp2IlInjected.Address(Slot = "0")]
	(float, Vector3) LEIPMCEFFPA(Rigidbody ODIOPOFEILG);
}
[Cpp2IlInjected.Token(Token = "0x2000048")]
public interface BCIDNNJHCLE : FHAABOAKHEB, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x17000126")]
	PhotonView DFMNDCKFFFJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000471")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000049")]
internal sealed class AKKIFOHMBLF : AOENHBHLFIE
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000077")]
	private readonly FGCABOJBJBA ECLMPMCOOIA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000078")]
	private CollisionDetectionMode EBGFEDFBILN;

	[Cpp2IlInjected.Token(Token = "0x17000127")]
	private Rigidbody JLNHKFKKICK
	{
		[Cpp2IlInjected.Token(Token = "0x6000472")]
		[Cpp2IlInjected.Address(RVA = "0x6371000", Offset = "0x6370000", VA = "0x186371000")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000128")]
	public CollisionDetectionMode MHGBGHOHCOK
	{
		[Cpp2IlInjected.Token(Token = "0x6000476")]
		[Cpp2IlInjected.Address(RVA = "0x6371160", Offset = "0x6370160", VA = "0x186371160", Slot = "4")]
		get
		{
			return default(CollisionDetectionMode);
		}
		[Cpp2IlInjected.Token(Token = "0x6000477")]
		[Cpp2IlInjected.Address(RVA = "0x6370F90", Offset = "0x636FF90", VA = "0x186370F90", Slot = "5")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000473")]
	[Cpp2IlInjected.Address(RVA = "0x6371270", Offset = "0x6370270", VA = "0x186371270")]
	public AKKIFOHMBLF(EHCMNHLPJBM ECLMPMCOOIA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000474")]
	[Cpp2IlInjected.Address(RVA = "0x6371050", Offset = "0x6370050", VA = "0x186371050", Slot = "6")]
	public void NPFDHKEDPBK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000475")]
	[Cpp2IlInjected.Address(RVA = "0x6370DF0", Offset = "0x636FDF0", VA = "0x186370DF0", Slot = "9")]
	public void KHNKJFJMFFM(Rigidbody IOJJIGGDNPN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000478")]
	[Cpp2IlInjected.Address(RVA = "0x6370C70", Offset = "0x636FC70", VA = "0x186370C70", Slot = "7")]
	public void ABGJLAGAKOI(bool NGGMOCIINFJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000479")]
	[Cpp2IlInjected.Address(RVA = "0x6370DE0", Offset = "0x636FDE0", VA = "0x186370DE0", Slot = "8")]
	public void HDDNNCNNJMB(bool NGGMOCIINFJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600047A")]
	[Cpp2IlInjected.Address(RVA = "0x6370C80", Offset = "0x636FC80", VA = "0x186370C80", Slot = "10")]
	public bool BDBHIBJMAFO(Vector3 AKNDOLIKNGM, [Out] RaycastHit MGAKEPJNIDG, float IBOJBDBEJBJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600047B")]
	[Cpp2IlInjected.Address(RVA = "0x6370E70", Offset = "0x636FE70", VA = "0x186370E70")]
	private void LFDLDGCOCKL(bool NGGMOCIINFJ)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200004A")]
public sealed class GLJLONGDIIN : HFPBFKAEHJM, IDisposable, NAMDOKCHCKG
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400007A")]
	private readonly FGCABOJBJBA ECLMPMCOOIA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400007B")]
	private BAGHKPJGLEA JOCPKGMEDNL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400007C")]
	private KKDEOGMNLDN OJBADPMOFHJ;

	[Cpp2IlInjected.Token(Token = "0x17000129")]
	public BAGHKPJGLEA HJLBEPGNACN
	{
		[Cpp2IlInjected.Token(Token = "0x600047E")]
		[Cpp2IlInjected.Address(RVA = "0x637D410", Offset = "0x637C410", VA = "0x18637D410", Slot = "6")]
		get
		{
			return default(BAGHKPJGLEA);
		}
		[Cpp2IlInjected.Token(Token = "0x600047F")]
		[Cpp2IlInjected.Address(RVA = "0x637D290", Offset = "0x637C290", VA = "0x18637D290", Slot = "7")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700012A")]
	private Transform DNBECLOOEFA
	{
		[Cpp2IlInjected.Token(Token = "0x6000480")]
		[Cpp2IlInjected.Address(RVA = "0x637D270", Offset = "0x637C270", VA = "0x18637D270", Slot = "10")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000041")]
	public event Action<FDHMLINJMLJ, FDHMLINJMLJ> IOALOLNJHBM
	{
		[Cpp2IlInjected.Token(Token = "0x600047C")]
		[Cpp2IlInjected.Address(RVA = "0x637D560", Offset = "0x637C560", VA = "0x18637D560", Slot = "4")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600047D")]
		[Cpp2IlInjected.Address(RVA = "0x637D360", Offset = "0x637C360", VA = "0x18637D360", Slot = "5")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000481")]
	[Cpp2IlInjected.Address(RVA = "0x637D910", Offset = "0x637C910", VA = "0x18637D910")]
	public GLJLONGDIIN(EHCMNHLPJBM ECLMPMCOOIA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000482")]
	[Cpp2IlInjected.Address(RVA = "0x637D610", Offset = "0x637C610", VA = "0x18637D610", Slot = "8")]
	public void NPFDHKEDPBK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000483")]
	[Cpp2IlInjected.Address(RVA = "0x637D220", Offset = "0x637C220", VA = "0x18637D220", Slot = "9")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000484")]
	[Cpp2IlInjected.Address(RVA = "0x1B27610", Offset = "0x1B26610", VA = "0x181B27610", Slot = "11")]
	private void PAHEMMCECLG(FDHMLINJMLJ JHHHBJMAAKM, FDHMLINJMLJ NMBEDMIFDIA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000485")]
	[Cpp2IlInjected.Address(RVA = "0x770CB0", Offset = "0x76FCB0", VA = "0x180770CB0", Slot = "12")]
	private void FBAKAGKFKOH(bool NKBJCONEJKF)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200004B")]
internal sealed class KAAJNDOOBFF : HEOOOHDIHMG
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400007D")]
	private readonly FGCABOJBJBA ECLMPMCOOIA;

	[Cpp2IlInjected.Token(Token = "0x1700012B")]
	private Rigidbody JLNHKFKKICK
	{
		[Cpp2IlInjected.Token(Token = "0x6000486")]
		[Cpp2IlInjected.Address(RVA = "0x6371000", Offset = "0x6370000", VA = "0x186371000")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700012C")]
	private bool KFMBBJLEAJK
	{
		[Cpp2IlInjected.Token(Token = "0x6000487")]
		[Cpp2IlInjected.Address(RVA = "0x637C2F0", Offset = "0x637B2F0", VA = "0x18637C2F0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700012D")]
	private bool LAHBJHCBLCC
	{
		[Cpp2IlInjected.Token(Token = "0x6000488")]
		[Cpp2IlInjected.Address(RVA = "0x6370230", Offset = "0x636F230", VA = "0x186370230")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700012E")]
	private EHCMNHLPJBM CPGMADILNAD
	{
		[Cpp2IlInjected.Token(Token = "0x6000489")]
		[Cpp2IlInjected.Address(RVA = "0x63827E0", Offset = "0x63817E0", VA = "0x1863827E0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600048A")]
	[Cpp2IlInjected.Address(RVA = "0x6371270", Offset = "0x6370270", VA = "0x186371270")]
	public KAAJNDOOBFF(EHCMNHLPJBM ECLMPMCOOIA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600048B")]
	[Cpp2IlInjected.Address(RVA = "0x6382420", Offset = "0x6381420", VA = "0x186382420", Slot = "4")]
	public void IJKJHGBBCEG(Vector3 OFOIDDLLFEI, ForceMode OJEDHHILKEL = ForceMode.Force)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600048C")]
	[Cpp2IlInjected.Address(RVA = "0x6382840", Offset = "0x6381840", VA = "0x186382840")]
	private void PDICPEOKBHA(Vector3 OFOIDDLLFEI, ForceMode OJEDHHILKEL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600048D")]
	[Cpp2IlInjected.Address(RVA = "0x63821A0", Offset = "0x63811A0", VA = "0x1863821A0", Slot = "5")]
	public void HIDBDPPDDNG(Vector3 OFOIDDLLFEI, Vector3 LPGLCEHEHMC, ForceMode OJEDHHILKEL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600048E")]
	[Cpp2IlInjected.Address(RVA = "0x6381DE0", Offset = "0x6380DE0", VA = "0x186381DE0", Slot = "6")]
	public void FEDPGNOKGDK(Vector3 LGKLDHJLFFC, ForceMode OJEDHHILKEL = ForceMode.Force)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600048F")]
	[Cpp2IlInjected.Address(RVA = "0x6381F40", Offset = "0x6380F40", VA = "0x186381F40")]
	private void HGCCKLJFDJC(Vector3 LGKLDHJLFFC, ForceMode OJEDHHILKEL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000490")]
	[Cpp2IlInjected.Address(RVA = "0x6382580", Offset = "0x6381580", VA = "0x186382580", Slot = "7")]
	public void KBMMINBNLNN(Vector3 LGKLDHJLFFC, ForceMode OJEDHHILKEL = ForceMode.Force)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200004C")]
internal sealed class HLGILHJOLHB : HIIFMKKGLIL
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400007E")]
	private readonly FGCABOJBJBA ECLMPMCOOIA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400007F")]
	private bool BLJLGNEIKBN;

	[Cpp2IlInjected.Token(Token = "0x1700012F")]
	public bool BJICAJLOKDG
	{
		[Cpp2IlInjected.Token(Token = "0x6000492")]
		[Cpp2IlInjected.Address(RVA = "0x81EBB0", Offset = "0x81DBB0", VA = "0x18081EBB0", Slot = "4")]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000493")]
		[Cpp2IlInjected.Address(RVA = "0x637F7F0", Offset = "0x637E7F0", VA = "0x18637F7F0", Slot = "5")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000491")]
	[Cpp2IlInjected.Address(RVA = "0x6371270", Offset = "0x6370270", VA = "0x186371270")]
	public HLGILHJOLHB(EHCMNHLPJBM ECLMPMCOOIA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000494")]
	[Cpp2IlInjected.Address(RVA = "0x637F900", Offset = "0x637E900", VA = "0x18637F900", Slot = "6")]
	public void KHNKJFJMFFM(Rigidbody IOJJIGGDNPN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000495")]
	[Cpp2IlInjected.Address(RVA = "0x637AFC0", Offset = "0x6379FC0", VA = "0x18637AFC0", Slot = "7")]
	public void FBJMEJIJMGC(Rigidbody IOJJIGGDNPN)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200004D")]
internal sealed class NJKJAOMPLNG : EHOBGOHHOMI, AEHPKHIMIDL, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x4000089")]
	private readonly EHCMNHLPJBM ECLMPMCOOIA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x400008A")]
	private readonly List<EHCMNHLPJBM> MBJINPOMGGB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x400008B")]
	private EHCMNHLPJBM GLACNLFCFNI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x400008C")]
	private EHCMNHLPJBM IGPIMCJILMM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
	[Cpp2IlInjected.Token(Token = "0x400008D")]
	private Transform LNMHFBIJLGB;

	[Cpp2IlInjected.Token(Token = "0x17000130")]
	private Transform FHHLKDMADLC
	{
		[Cpp2IlInjected.Token(Token = "0x60004A8")]
		[Cpp2IlInjected.Address(RVA = "0x6392BC0", Offset = "0x6391BC0", VA = "0x186392BC0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000131")]
	public EHCMNHLPJBM CPGMADILNAD
	{
		[Cpp2IlInjected.Token(Token = "0x60004AB")]
		[Cpp2IlInjected.Address(RVA = "0x7793B0", Offset = "0x7783B0", VA = "0x1807793B0", Slot = "28")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60004AC")]
		[Cpp2IlInjected.Address(RVA = "0x6392E00", Offset = "0x6391E00", VA = "0x186392E00", Slot = "29")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000132")]
	public EHCMNHLPJBM FMAEDMDFLJE
	{
		[Cpp2IlInjected.Token(Token = "0x60004AD")]
		[Cpp2IlInjected.Address(RVA = "0x7738A0", Offset = "0x7728A0", VA = "0x1807738A0", Slot = "27")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000133")]
	public IReadOnlyList<EHCMNHLPJBM> NKNGGFCLKKC
	{
		[Cpp2IlInjected.Token(Token = "0x60004AE")]
		[Cpp2IlInjected.Address(RVA = "0x773900", Offset = "0x772900", VA = "0x180773900", Slot = "26")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000042")]
	public event ODMKMIKDLDH HNIODPCALEE
	{
		[Cpp2IlInjected.Token(Token = "0x6000496")]
		[Cpp2IlInjected.Address(RVA = "0x6393CA0", Offset = "0x6392CA0", VA = "0x186393CA0", Slot = "8")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000497")]
		[Cpp2IlInjected.Address(RVA = "0x6393920", Offset = "0x6392920", VA = "0x186393920", Slot = "9")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000043")]
	public event ODMKMIKDLDH ICDJPNDLGPD
	{
		[Cpp2IlInjected.Token(Token = "0x6000498")]
		[Cpp2IlInjected.Address(RVA = "0x6393880", Offset = "0x6392880", VA = "0x186393880", Slot = "10")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000499")]
		[Cpp2IlInjected.Address(RVA = "0x6392F40", Offset = "0x6391F40", VA = "0x186392F40", Slot = "11")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000044")]
	public event LNHELIADCNA JAPGMOHDICK
	{
		[Cpp2IlInjected.Token(Token = "0x600049A")]
		[Cpp2IlInjected.Address(RVA = "0x6393FE0", Offset = "0x6392FE0", VA = "0x186393FE0", Slot = "12")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600049B")]
		[Cpp2IlInjected.Address(RVA = "0x6393DF0", Offset = "0x6392DF0", VA = "0x186393DF0", Slot = "13")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000045")]
	public event Action AFIOFAKDOHM
	{
		[Cpp2IlInjected.Token(Token = "0x600049C")]
		[Cpp2IlInjected.Address(RVA = "0x6392CC0", Offset = "0x6391CC0", VA = "0x186392CC0", Slot = "14")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600049D")]
		[Cpp2IlInjected.Address(RVA = "0x6393600", Offset = "0x6392600", VA = "0x186393600", Slot = "15")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000046")]
	public event Action LDAFEJALAGM
	{
		[Cpp2IlInjected.Token(Token = "0x600049E")]
		[Cpp2IlInjected.Address(RVA = "0x6393AB0", Offset = "0x6392AB0", VA = "0x186393AB0", Slot = "16")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600049F")]
		[Cpp2IlInjected.Address(RVA = "0x6392800", Offset = "0x6391800", VA = "0x186392800", Slot = "17")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000047")]
	public event Action<EHCMNHLPJBM> IHHOLKIEDLI
	{
		[Cpp2IlInjected.Token(Token = "0x60004A0")]
		[Cpp2IlInjected.Address(RVA = "0x63936A0", Offset = "0x63926A0", VA = "0x1863936A0", Slot = "18")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60004A1")]
		[Cpp2IlInjected.Address(RVA = "0x63939C0", Offset = "0x63929C0", VA = "0x1863939C0", Slot = "19")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000048")]
	public event Action<EHCMNHLPJBM> GFEGPGHKFIA
	{
		[Cpp2IlInjected.Token(Token = "0x60004A2")]
		[Cpp2IlInjected.Address(RVA = "0x6393B50", Offset = "0x6392B50", VA = "0x186393B50", Slot = "20")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60004A3")]
		[Cpp2IlInjected.Address(RVA = "0x6393D40", Offset = "0x6392D40", VA = "0x186393D40", Slot = "21")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000049")]
	public event Action HHBKPHPDLNL
	{
		[Cpp2IlInjected.Token(Token = "0x60004A4")]
		[Cpp2IlInjected.Address(RVA = "0x6392D60", Offset = "0x6391D60", VA = "0x186392D60", Slot = "22")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60004A5")]
		[Cpp2IlInjected.Address(RVA = "0x6393C00", Offset = "0x6392C00", VA = "0x186393C00", Slot = "23")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400004A")]
	public event Action<EHCMNHLPJBM> NOBNHCGFCBM
	{
		[Cpp2IlInjected.Token(Token = "0x60004A6")]
		[Cpp2IlInjected.Address(RVA = "0x6392B10", Offset = "0x6391B10", VA = "0x186392B10", Slot = "24")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60004A7")]
		[Cpp2IlInjected.Address(RVA = "0x6393E90", Offset = "0x6392E90", VA = "0x186393E90", Slot = "25")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60004A9")]
	[Cpp2IlInjected.Address(RVA = "0x6394080", Offset = "0x6393080", VA = "0x186394080")]
	public NJKJAOMPLNG(EHCMNHLPJBM ECLMPMCOOIA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004AA")]
	[Cpp2IlInjected.Address(RVA = "0x6392C20", Offset = "0x6391C20", VA = "0x186392C20", Slot = "31")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004AF")]
	[Cpp2IlInjected.Address(RVA = "0x6392FE0", Offset = "0x6391FE0", VA = "0x186392FE0", Slot = "30")]
	public void GLKDGJFHDGI(EHCMNHLPJBM GLMIFAAAHGN, bool FMNAIIPBFHC = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004B0")]
	[Cpp2IlInjected.Address(RVA = "0x63928A0", Offset = "0x63918A0", VA = "0x1863928A0", Slot = "6")]
	public void DABHHHAAOME(EHCMNHLPJBM NLMONBKCPDM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004B1")]
	[Cpp2IlInjected.Address(RVA = "0x6392580", Offset = "0x6391580", VA = "0x186392580", Slot = "7")]
	public void BHLMHEOGKBI(EHCMNHLPJBM NLMONBKCPDM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004B2")]
	[Cpp2IlInjected.Address(RVA = "0x6392260", Offset = "0x6391260", VA = "0x186392260", Slot = "4")]
	public void AFEGLLIBHOI(EHCMNHLPJBM ECLMPMCOOIA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004B3")]
	[Cpp2IlInjected.Address(RVA = "0x6393560", Offset = "0x6392560", VA = "0x186393560", Slot = "5")]
	public void HACPIENJING(EHCMNHLPJBM ECLMPMCOOIA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004B4")]
	[Cpp2IlInjected.Address(RVA = "0x6393F40", Offset = "0x6392F40", VA = "0x186393F40")]
	private void OKHFMKECLEB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004B5")]
	[Cpp2IlInjected.Address(RVA = "0x6393A70", Offset = "0x6392A70", VA = "0x186393A70")]
	private void JLBNKAPNJFA(EHCMNHLPJBM NLMONBKCPDM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004B6")]
	[Cpp2IlInjected.Address(RVA = "0x6392350", Offset = "0x6391350", VA = "0x186392350")]
	private void AKHDDGJHIBL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004B7")]
	[Cpp2IlInjected.Address(RVA = "0x6393750", Offset = "0x6392750", VA = "0x186393750")]
	private void HNCHPLHADNP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004B8")]
	[Cpp2IlInjected.Address(RVA = "0x6392E10", Offset = "0x6391E10", VA = "0x186392E10")]
	private void GAPJMLFGOHJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004B9")]
	[Cpp2IlInjected.Address(RVA = "0x6392490", Offset = "0x6391490", VA = "0x186392490")]
	[CompilerGenerated]
	private object AMDBHIGHMAE()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200004E")]
internal static class GJECEGKJJEP
{
	[Cpp2IlInjected.Token(Token = "0x60004BA")]
	[Cpp2IlInjected.Address(RVA = "0x637D160", Offset = "0x637C160", VA = "0x18637D160")]
	public static EHOBGOHHOMI PENHCFMGGJH(this EHCMNHLPJBM KKOFNCEIKDA)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200004F")]
internal sealed class GOPIBOGEEKI : EPHGCAGMHDB, CLEHINCHHDE
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400008E")]
	private readonly FGCABOJBJBA ECLMPMCOOIA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400008F")]
	private readonly ICHGNBFAFCD<EHCMNHLPJBM> PEHEDOOADDC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000090")]
	private bool OPLEHLDEOEA;

	[Cpp2IlInjected.Token(Token = "0x17000134")]
	public ICHGNBFAFCD<EHCMNHLPJBM> JIHANHIKLEP
	{
		[Cpp2IlInjected.Token(Token = "0x60004BB")]
		[Cpp2IlInjected.Address(RVA = "0x76F210", Offset = "0x76E210", VA = "0x18076F210", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000135")]
	public Vector3 BGJFIEJBIJF
	{
		[Cpp2IlInjected.Token(Token = "0x60004BC")]
		[Cpp2IlInjected.Address(RVA = "0x637E370", Offset = "0x637D370", VA = "0x18637E370", Slot = "6")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000136")]
	public Vector3 FLCGLBNKKAA
	{
		[Cpp2IlInjected.Token(Token = "0x60004BD")]
		[Cpp2IlInjected.Address(RVA = "0x637D9A0", Offset = "0x637C9A0", VA = "0x18637D9A0", Slot = "7")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000137")]
	private Vector3 JLKBIOAHEKE
	{
		[Cpp2IlInjected.Token(Token = "0x60004C1")]
		[Cpp2IlInjected.Address(RVA = "0x637DB60", Offset = "0x637CB60", VA = "0x18637DB60")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000138")]
	public EHCMNHLPJBM DEMKBLBDOIF
	{
		[Cpp2IlInjected.Token(Token = "0x60004C2")]
		[Cpp2IlInjected.Address(RVA = "0x637E470", Offset = "0x637D470", VA = "0x18637E470", Slot = "5")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60004BE")]
	[Cpp2IlInjected.Address(RVA = "0x637E520", Offset = "0x637D520", VA = "0x18637E520")]
	public GOPIBOGEEKI(EHCMNHLPJBM ECLMPMCOOIA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004BF")]
	[Cpp2IlInjected.Address(RVA = "0x637E400", Offset = "0x637D400", VA = "0x18637E400", Slot = "8")]
	public void PKGKHPOJDBI(EHCMNHLPJBM IGPIMCJILMM, object PDIBILKHEBM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004C0")]
	[Cpp2IlInjected.Address(RVA = "0x637E3A0", Offset = "0x637D3A0", VA = "0x18637E3A0", Slot = "9")]
	public void PIAIJDLNGDE(object PDIBILKHEBM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004C3")]
	[Cpp2IlInjected.Address(RVA = "0x637DC50", Offset = "0x637CC50", VA = "0x18637DC50")]
	private Vector3 HOJJKEBMKFH()
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x60004C4")]
	[Cpp2IlInjected.Address(RVA = "0x637DFE0", Offset = "0x637CFE0", VA = "0x18637DFE0")]
	private void LJPFEKBAOHN(EHCMNHLPJBM FLGGGBJHGID)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000050")]
internal static class AOONNDLKGCI
{
	[Cpp2IlInjected.Token(Token = "0x60004C5")]
	[Cpp2IlInjected.Address(RVA = "0x6371300", Offset = "0x6370300", VA = "0x186371300")]
	public static EPHGCAGMHDB PIINHDAAFHL(this EHCMNHLPJBM KKOFNCEIKDA)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000051")]
internal sealed class LJBCCPBCBAL : NPFNHIBGCFO, KACNHFAPOGE
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000092")]
	private readonly FGCABOJBJBA ECLMPMCOOIA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000093")]
	private readonly OverridableVector3 CHELGPEFPDH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000094")]
	private readonly OverridableVector3 JJBJOBIPOGE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000095")]
	private float KFNCLGBNBOD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x44")]
	[Cpp2IlInjected.Token(Token = "0x4000096")]
	private float EPAALMILAGA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000097")]
	private Vector3 OJIADJOKMGD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x54")]
	[Cpp2IlInjected.Token(Token = "0x4000098")]
	private Vector3? DKDKNIAGBLF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x64")]
	[Cpp2IlInjected.Token(Token = "0x4000099")]
	private Quaternion? BKGKJEEAOPJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
	[Cpp2IlInjected.Token(Token = "0x400009A")]
	private bool LMFHDJMHHOP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x79")]
	[Cpp2IlInjected.Token(Token = "0x400009B")]
	private bool BHLGHFOAEHA;

	[Cpp2IlInjected.Token(Token = "0x17000139")]
	public Vector3 LADKEMIALFK
	{
		[Cpp2IlInjected.Token(Token = "0x60004C8")]
		[Cpp2IlInjected.Address(RVA = "0xFDDC40", Offset = "0xFDCC40", VA = "0x180FDDC40", Slot = "7")]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x60004C9")]
		[Cpp2IlInjected.Address(RVA = "0x638AB30", Offset = "0x6389B30", VA = "0x18638AB30", Slot = "8")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700013A")]
	public Vector3 PIICNOJNCPP
	{
		[Cpp2IlInjected.Token(Token = "0x60004CA")]
		[Cpp2IlInjected.Address(RVA = "0x638ABE0", Offset = "0x6389BE0", VA = "0x18638ABE0", Slot = "9")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700013B")]
	public float DGAGBHADGJN
	{
		[Cpp2IlInjected.Token(Token = "0x60004CB")]
		[Cpp2IlInjected.Address(RVA = "0x10C2D20", Offset = "0x10C1D20", VA = "0x1810C2D20", Slot = "10")]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x60004CC")]
		[Cpp2IlInjected.Address(RVA = "0x638B730", Offset = "0x638A730", VA = "0x18638B730")]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700013C")]
	public float LLNDLOGDDIG
	{
		[Cpp2IlInjected.Token(Token = "0x60004CD")]
		[Cpp2IlInjected.Address(RVA = "0xB43740", Offset = "0xB42740", VA = "0x180B43740", Slot = "11")]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x60004CE")]
		[Cpp2IlInjected.Address(RVA = "0x638B290", Offset = "0x638A290", VA = "0x18638B290", Slot = "12")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700013D")]
	public Vector3 HNOLHOHLFKJ
	{
		[Cpp2IlInjected.Token(Token = "0x60004CF")]
		[Cpp2IlInjected.Address(RVA = "0x638A460", Offset = "0x6389460", VA = "0x18638A460", Slot = "13")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700013E")]
	public Quaternion LONFIJLGBOG
	{
		[Cpp2IlInjected.Token(Token = "0x60004D0")]
		[Cpp2IlInjected.Address(RVA = "0x638B340", Offset = "0x638A340", VA = "0x18638B340", Slot = "14")]
		get
		{
			return default(Quaternion);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700013F")]
	private Rigidbody JLNHKFKKICK
	{
		[Cpp2IlInjected.Token(Token = "0x60004D8")]
		[Cpp2IlInjected.Address(RVA = "0x6386350", Offset = "0x6385350", VA = "0x186386350")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400004B")]
	public event ODMKMIKDLDH ECMDDEJIIMB
	{
		[Cpp2IlInjected.Token(Token = "0x60004C6")]
		[Cpp2IlInjected.Address(RVA = "0x638A5F0", Offset = "0x63895F0", VA = "0x18638A5F0", Slot = "5")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60004C7")]
		[Cpp2IlInjected.Address(RVA = "0x638B4C0", Offset = "0x638A4C0", VA = "0x18638B4C0", Slot = "6")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60004D1")]
	[Cpp2IlInjected.Address(RVA = "0x638CE90", Offset = "0x638BE90", VA = "0x18638CE90")]
	public LJBCCPBCBAL(EHCMNHLPJBM ECLMPMCOOIA, [In] OJNOICCBOJO FCLEEDACIMH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004D2")]
	[Cpp2IlInjected.Address(RVA = "0x638ACE0", Offset = "0x6389CE0", VA = "0x18638ACE0", Slot = "17")]
	public void EMOEILKEJBE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004D3")]
	[Cpp2IlInjected.Address(RVA = "0x638CA00", Offset = "0x638BA00", VA = "0x18638CA00", Slot = "16")]
	public void NKANMLKMEBG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004D4")]
	[Cpp2IlInjected.Address(RVA = "0x638B650", Offset = "0x638A650", VA = "0x18638B650", Slot = "19")]
	public void KHNKJFJMFFM(Rigidbody IOJJIGGDNPN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004D5")]
	[Cpp2IlInjected.Address(RVA = "0x638B000", Offset = "0x638A000", VA = "0x18638B000", Slot = "20")]
	public void FBJMEJIJMGC(Rigidbody IOJJIGGDNPN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004D6")]
	[Cpp2IlInjected.Address(RVA = "0x638AE90", Offset = "0x6389E90", VA = "0x18638AE90", Slot = "18")]
	public void FAMCOJOMDOD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004D7")]
	[Cpp2IlInjected.Address(RVA = "0x638A690", Offset = "0x6389690", VA = "0x18638A690", Slot = "21")]
	public void BLJKMNBKPBO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004D9")]
	[Cpp2IlInjected.Address(RVA = "0x638AB30", Offset = "0x6389B30", VA = "0x18638AB30")]
	private void PDLJCOGKMIM(Vector3 APPJEOKOGAK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004DA")]
	[Cpp2IlInjected.Address(RVA = "0x638B560", Offset = "0x638A560", VA = "0x18638B560")]
	[Obsolete("This method is dangerous - the unity rigidbody is updated in a deferred manner and this world position may be stale")]
	private Vector3 IKGNOBECKHO()
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x60004DB")]
	[Cpp2IlInjected.Address(RVA = "0x638B730", Offset = "0x638A730", VA = "0x18638B730")]
	private void KODABACFJDL(float APPJEOKOGAK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004DC")]
	[Cpp2IlInjected.Address(RVA = "0x638B290", Offset = "0x638A290", VA = "0x18638B290")]
	private void LLPECCFKBEI(float APPJEOKOGAK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004DD")]
	[Cpp2IlInjected.Address(RVA = "0x638C860", Offset = "0x638B860", VA = "0x18638C860")]
	private Vector3 MECLOALLOBH()
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x60004DE")]
	[Cpp2IlInjected.Address(RVA = "0x638CAE0", Offset = "0x638BAE0", VA = "0x18638CAE0", Slot = "15")]
	public void PECPHAKBJCG((Quaternion rot, Vector3 moments) IJPGGILEIIN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004DF")]
	[Cpp2IlInjected.Address(RVA = "0x638CD10", Offset = "0x638BD10", VA = "0x18638CD10")]
	private Quaternion PPLICDEEJPK()
	{
		return default(Quaternion);
	}

	[Cpp2IlInjected.Token(Token = "0x60004E0")]
	[Cpp2IlInjected.Address(RVA = "0x638B840", Offset = "0x638A840", VA = "0x18638B840")]
	public void LEIPMCEFFPA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004E1")]
	[Cpp2IlInjected.Address(RVA = "0x638B910", Offset = "0x638A910", VA = "0x18638B910", Slot = "4")]
	public (float, Vector3) LEIPMCEFFPA(Rigidbody ODIOPOFEILG)
	{
		return default((float, Vector3));
	}
}
[Cpp2IlInjected.Token(Token = "0x2000052")]
internal static class BJGEEMEPHFF
{
	[Cpp2IlInjected.Token(Token = "0x60004E2")]
	[Cpp2IlInjected.Address(RVA = "0x63724D0", Offset = "0x63714D0", VA = "0x1863724D0")]
	public static NPFNHIBGCFO AGKJLIDILBI(this EHCMNHLPJBM KKOFNCEIKDA)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000053")]
internal sealed class NCJNAJMHNFO : HFBOJOOMHLA
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400009C")]
	private readonly FGCABOJBJBA ECLMPMCOOIA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400009D")]
	private readonly KFKHIDKOEKA GHKOIFMPGPC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400009E")]
	private readonly HJJEIONKHEK MEJOPMNLIME;

	[Cpp2IlInjected.Token(Token = "0x17000140")]
	public bool IJNKBENECFE
	{
		[Cpp2IlInjected.Token(Token = "0x60004E3")]
		[Cpp2IlInjected.Address(RVA = "0xC73E90", Offset = "0xC72E90", VA = "0x180C73E90", Slot = "10")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000141")]
	public HJJEIONKHEK CGFMLGHKMOK
	{
		[Cpp2IlInjected.Token(Token = "0x60004E4")]
		[Cpp2IlInjected.Address(RVA = "0x8620A0", Offset = "0x8610A0", VA = "0x1808620A0", Slot = "11")]
		get
		{
			return default(HJJEIONKHEK);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60004E5")]
	[Cpp2IlInjected.Address(RVA = "0x638DD30", Offset = "0x638CD30", VA = "0x18638DD30")]
	public NCJNAJMHNFO(EHCMNHLPJBM ECLMPMCOOIA, [In] OJNOICCBOJO FCLEEDACIMH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004E6")]
	[Cpp2IlInjected.Address(RVA = "0x638DC60", Offset = "0x638CC60", VA = "0x18638DC60", Slot = "4")]
	public void NPFDHKEDPBK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004E7")]
	[Cpp2IlInjected.Address(RVA = "0x638DA50", Offset = "0x638CA50", VA = "0x18638DA50")]
	private bool MCIAKMKEBPH()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60004E8")]
	[Cpp2IlInjected.Address(RVA = "0x638D9F0", Offset = "0x638C9F0", VA = "0x18638D9F0", Slot = "5")]
	public void HLKPOIGCEAG(object PDIBILKHEBM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004E9")]
	[Cpp2IlInjected.Address(RVA = "0x638DA20", Offset = "0x638CA20", VA = "0x18638DA20", Slot = "6")]
	public void IIAIKOCKHGA(object PDIBILKHEBM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004EA")]
	[Cpp2IlInjected.Address(RVA = "0x638D750", Offset = "0x638C750", VA = "0x18638D750", Slot = "9")]
	public void FIJMFJHPGEE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004EB")]
	[Cpp2IlInjected.Address(RVA = "0x638D890", Offset = "0x638C890", VA = "0x18638D890")]
	private void FJBDMCCOHOD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004EC")]
	[Cpp2IlInjected.Address(RVA = "0x638DAF0", Offset = "0x638CAF0", VA = "0x18638DAF0")]
	private void NHNEEAGKDCB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004ED")]
	[Cpp2IlInjected.Address(RVA = "0x638D710", Offset = "0x638C710", VA = "0x18638D710", Slot = "8")]
	public void AMOOCLCHOID(EHCMNHLPJBM ECLMPMCOOIA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004EE")]
	[Cpp2IlInjected.Address(RVA = "0x638D9B0", Offset = "0x638C9B0", VA = "0x18638D9B0", Slot = "7")]
	public void GCCKNIMCPIP(EHCMNHLPJBM ECLMPMCOOIA)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000054")]
internal sealed class FGEMJOONNEO : AGCCBIKJDAK
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000A0")]
	private readonly FGCABOJBJBA ECLMPMCOOIA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000A1")]
	private readonly KFKHIDKOEKA CLDKFBAMBJO;

	[Cpp2IlInjected.Token(Token = "0x17000142")]
	public bool KFMBBJLEAJK
	{
		[Cpp2IlInjected.Token(Token = "0x60004F1")]
		[Cpp2IlInjected.Address(RVA = "0x637AA30", Offset = "0x6379A30", VA = "0x18637AA30", Slot = "7")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400004C")]
	public event ODMKMIKDLDH IJHOLLBGJPD
	{
		[Cpp2IlInjected.Token(Token = "0x60004EF")]
		[Cpp2IlInjected.Address(RVA = "0x637AAE0", Offset = "0x6379AE0", VA = "0x18637AAE0", Slot = "4")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60004F0")]
		[Cpp2IlInjected.Address(RVA = "0x637ADD0", Offset = "0x6379DD0", VA = "0x18637ADD0", Slot = "5")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60004F2")]
	[Cpp2IlInjected.Address(RVA = "0x637AE70", Offset = "0x6379E70", VA = "0x18637AE70")]
	public FGEMJOONNEO(EHCMNHLPJBM ECLMPMCOOIA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004F3")]
	[Cpp2IlInjected.Address(RVA = "0x637ACC0", Offset = "0x6379CC0", VA = "0x18637ACC0", Slot = "11")]
	public IDisposable HLJKBPAJOBH()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004F4")]
	[Cpp2IlInjected.Address(RVA = "0x637AD30", Offset = "0x6379D30", VA = "0x18637AD30", Slot = "8")]
	public void JPFGFDECHOJ(object PDIBILKHEBM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004F5")]
	[Cpp2IlInjected.Address(RVA = "0x637AD40", Offset = "0x6379D40", VA = "0x18637AD40", Slot = "9")]
	public void KAPPGEIEJKO(object PDIBILKHEBM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004F6")]
	[Cpp2IlInjected.Address(RVA = "0x637ABB0", Offset = "0x6379BB0", VA = "0x18637ABB0", Slot = "10")]
	public void GJJAJKOMBNJ(object PDIBILKHEBM, bool GKHMPKCJGHP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004F7")]
	[Cpp2IlInjected.Address(RVA = "0x637A9F0", Offset = "0x63799F0", VA = "0x18637A9F0", Slot = "6")]
	public void BJFJHCOMKNK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004F8")]
	[Cpp2IlInjected.Address(RVA = "0x637AD50", Offset = "0x6379D50", VA = "0x18637AD50", Slot = "12")]
	public void KHNKJFJMFFM(Rigidbody JFBLILNAOMM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004F9")]
	[Cpp2IlInjected.Address(RVA = "0x637AB80", Offset = "0x6379B80", VA = "0x18637AB80", Slot = "13")]
	public void FBJMEJIJMGC(Rigidbody IOJJIGGDNPN)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000055")]
internal sealed class KGIMBHKLIDO : BCIDNNJHCLE, FHAABOAKHEB, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000A3")]
	private readonly FGCABOJBJBA ECLMPMCOOIA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000A4")]
	private PhotonView EEKACCEEHIJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40000A5")]
	private bool FAMOOMLELLA;

	[Cpp2IlInjected.Token(Token = "0x17000143")]
	public PhotonView DFMNDCKFFFJ
	{
		[Cpp2IlInjected.Token(Token = "0x60004FC")]
		[Cpp2IlInjected.Address(RVA = "0x76F1F0", Offset = "0x76E1F0", VA = "0x18076F1F0", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000144")]
	public bool GCPNKEIHNJF
	{
		[Cpp2IlInjected.Token(Token = "0x60004FD")]
		[Cpp2IlInjected.Address(RVA = "0x6372350", Offset = "0x6371350", VA = "0x186372350", Slot = "7")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000145")]
	public bool FLDOPHCHFPM
	{
		[Cpp2IlInjected.Token(Token = "0x60004FE")]
		[Cpp2IlInjected.Address(RVA = "0x81F7E0", Offset = "0x81E7E0", VA = "0x18081F7E0", Slot = "8")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400004D")]
	public event ODMKMIKDLDH GIADDJGCKPO
	{
		[Cpp2IlInjected.Token(Token = "0x60004FA")]
		[Cpp2IlInjected.Address(RVA = "0x6382F70", Offset = "0x6381F70", VA = "0x186382F70", Slot = "5")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60004FB")]
		[Cpp2IlInjected.Address(RVA = "0x6383590", Offset = "0x6382590", VA = "0x186383590", Slot = "6")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60004FF")]
	[Cpp2IlInjected.Address(RVA = "0x6383630", Offset = "0x6382630", VA = "0x186383630")]
	public KGIMBHKLIDO(EHCMNHLPJBM ECLMPMCOOIA, [In] OJNOICCBOJO FCLEEDACIMH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000500")]
	[Cpp2IlInjected.Address(RVA = "0x63832F0", Offset = "0x63822F0", VA = "0x1863832F0", Slot = "9")]
	public void NPFDHKEDPBK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000501")]
	[Cpp2IlInjected.Address(RVA = "0x6382E70", Offset = "0x6381E70", VA = "0x186382E70", Slot = "12")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000502")]
	[Cpp2IlInjected.Address(RVA = "0x6383180", Offset = "0x6382180", VA = "0x186383180", Slot = "10")]
	public void MFCPKNBIHKM(EHCMNHLPJBM IGPIMCJILMM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000503")]
	[Cpp2IlInjected.Address(RVA = "0x6383010", Offset = "0x6382010", VA = "0x186383010", Slot = "11")]
	public void KBIEHHBCMLI(EHCMNHLPJBM IGPIMCJILMM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000504")]
	[Cpp2IlInjected.Address(RVA = "0x6383420", Offset = "0x6382420", VA = "0x186383420")]
	private void ONOOMEJCIBG(PhotonView EENGMELAOON)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000505")]
	[Cpp2IlInjected.Address(RVA = "0x6382D10", Offset = "0x6381D10", VA = "0x186382D10")]
	private void CBKDCHJFCCE(RigidbodyEx GMJFIDEOPEB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000506")]
	[Cpp2IlInjected.Address(RVA = "0x6382AA0", Offset = "0x6381AA0", VA = "0x186382AA0")]
	private void AMHBGOCKIJM(PhotonView DNAPJIIGHPI)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000056")]
internal static class IKLGCPMJEHG
{
	[Cpp2IlInjected.Token(Token = "0x6000507")]
	[Cpp2IlInjected.Address(RVA = "0x6381560", Offset = "0x6380560", VA = "0x186381560")]
	public static BCIDNNJHCLE DHMLPICNKEB(this EHCMNHLPJBM KKOFNCEIKDA)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000057")]
internal sealed class HAEPGHDMGPF : ADPECGILELO
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000A6")]
	private readonly FGCABOJBJBA ECLMPMCOOIA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000A7")]
	private RigidbodyConstraints NAKNPLKLHCP;

	[Cpp2IlInjected.Token(Token = "0x17000146")]
	public bool MIOAIPJJMGG
	{
		[Cpp2IlInjected.Token(Token = "0x6000508")]
		[Cpp2IlInjected.Address(RVA = "0xA8F450", Offset = "0xA8E450", VA = "0x180A8F450", Slot = "4")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000509")]
		[Cpp2IlInjected.Address(RVA = "0x3CF9EC0", Offset = "0x3CF8EC0", VA = "0x183CF9EC0", Slot = "5")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000147")]
	public bool FOAJEHMGIDA
	{
		[Cpp2IlInjected.Token(Token = "0x600050A")]
		[Cpp2IlInjected.Address(RVA = "0x1A7B390", Offset = "0x1A7A390", VA = "0x181A7B390", Slot = "6")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x600050B")]
		[Cpp2IlInjected.Address(RVA = "0x3CF9ED0", Offset = "0x3CF8ED0", VA = "0x183CF9ED0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000148")]
	public RigidbodyConstraints NPGAMCBNMHD
	{
		[Cpp2IlInjected.Token(Token = "0x600050C")]
		[Cpp2IlInjected.Address(RVA = "0x775DA0", Offset = "0x774DA0", VA = "0x180775DA0", Slot = "7")]
		get
		{
			return default(RigidbodyConstraints);
		}
		[Cpp2IlInjected.Token(Token = "0x600050D")]
		[Cpp2IlInjected.Address(RVA = "0x637E780", Offset = "0x637D780", VA = "0x18637E780", Slot = "8")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600050E")]
	[Cpp2IlInjected.Address(RVA = "0x637E910", Offset = "0x637D910", VA = "0x18637E910")]
	public HAEPGHDMGPF(EHCMNHLPJBM ECLMPMCOOIA, [In] OJNOICCBOJO FCLEEDACIMH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600050F")]
	[Cpp2IlInjected.Address(RVA = "0x637E8E0", Offset = "0x637D8E0", VA = "0x18637E8E0", Slot = "9")]
	public void KHNKJFJMFFM(Rigidbody IOJJIGGDNPN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000510")]
	[Cpp2IlInjected.Address(RVA = "0x637E8B0", Offset = "0x637D8B0", VA = "0x18637E8B0", Slot = "10")]
	public void FBJMEJIJMGC(Rigidbody IOJJIGGDNPN)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000058")]
internal sealed class MABCOFKMCFA : HNFHIEOAONP
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000AA")]
	private readonly EHCMNHLPJBM ECLMPMCOOIA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000AB")]
	private float GPDPAMOGICI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
	[Cpp2IlInjected.Token(Token = "0x40000AC")]
	private float GOICHLNLLIC;

	[Cpp2IlInjected.Token(Token = "0x17000149")]
	public float EBALBFJEABI
	{
		[Cpp2IlInjected.Token(Token = "0x6000512")]
		[Cpp2IlInjected.Address(RVA = "0x83CEA0", Offset = "0x83BEA0", VA = "0x18083CEA0", Slot = "4")]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x6000513")]
		[Cpp2IlInjected.Address(RVA = "0x638D120", Offset = "0x638C120", VA = "0x18638D120", Slot = "5")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700014A")]
	public float FBKHGEIFEEL
	{
		[Cpp2IlInjected.Token(Token = "0x6000514")]
		[Cpp2IlInjected.Address(RVA = "0x8E0080", Offset = "0x8DF080", VA = "0x1808E0080", Slot = "6")]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x6000515")]
		[Cpp2IlInjected.Address(RVA = "0x638D1F0", Offset = "0x638C1F0", VA = "0x18638D1F0", Slot = "7")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000511")]
	[Cpp2IlInjected.Address(RVA = "0x638D310", Offset = "0x638C310", VA = "0x18638D310")]
	public MABCOFKMCFA(EHCMNHLPJBM ECLMPMCOOIA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000516")]
	[Cpp2IlInjected.Address(RVA = "0x638D2C0", Offset = "0x638C2C0", VA = "0x18638D2C0", Slot = "8")]
	public void KHNKJFJMFFM(Rigidbody IOJJIGGDNPN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000517")]
	[Cpp2IlInjected.Address(RVA = "0x638D080", Offset = "0x638C080", VA = "0x18638D080", Slot = "9")]
	public void FBJMEJIJMGC(Rigidbody IOJJIGGDNPN)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000059")]
internal sealed class LFDNNBBJGCG : EKKHALEFJMB
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000AE")]
	private readonly FGCABOJBJBA ECLMPMCOOIA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000AF")]
	private bool IHHNEGOFONE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x21")]
	[Cpp2IlInjected.Token(Token = "0x40000B0")]
	private bool ADABGFFDBBA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
	[Cpp2IlInjected.Token(Token = "0x40000B1")]
	private int KGJKKNLCEBP;

	[Cpp2IlInjected.Token(Token = "0x1700014B")]
	private Rigidbody JLNHKFKKICK
	{
		[Cpp2IlInjected.Token(Token = "0x600051A")]
		[Cpp2IlInjected.Address(RVA = "0x6386350", Offset = "0x6385350", VA = "0x186386350")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700014C")]
	private bool ECAGBOEDCGJ
	{
		[Cpp2IlInjected.Token(Token = "0x600051B")]
		[Cpp2IlInjected.Address(RVA = "0x6386760", Offset = "0x6385760", VA = "0x186386760")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700014D")]
	private EHCMNHLPJBM CPGMADILNAD
	{
		[Cpp2IlInjected.Token(Token = "0x600051C")]
		[Cpp2IlInjected.Address(RVA = "0x63862F0", Offset = "0x63852F0", VA = "0x1863862F0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700014E")]
	private bool LAHBJHCBLCC
	{
		[Cpp2IlInjected.Token(Token = "0x600051D")]
		[Cpp2IlInjected.Address(RVA = "0x6386290", Offset = "0x6385290", VA = "0x186386290")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400004E")]
	public event ODMKMIKDLDH AGBEMFNHAAD
	{
		[Cpp2IlInjected.Token(Token = "0x6000518")]
		[Cpp2IlInjected.Address(RVA = "0x6385CC0", Offset = "0x6384CC0", VA = "0x186385CC0", Slot = "4")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000519")]
		[Cpp2IlInjected.Address(RVA = "0x6386150", Offset = "0x6385150", VA = "0x186386150", Slot = "5")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600051E")]
	[Cpp2IlInjected.Address(RVA = "0x63867D0", Offset = "0x63857D0", VA = "0x1863867D0")]
	public LFDNNBBJGCG(EHCMNHLPJBM ECLMPMCOOIA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600051F")]
	[Cpp2IlInjected.Address(RVA = "0x63864F0", Offset = "0x63854F0", VA = "0x1863864F0", Slot = "6")]
	public void NPFDHKEDPBK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000520")]
	[Cpp2IlInjected.Address(RVA = "0x6385FB0", Offset = "0x6384FB0", VA = "0x186385FB0", Slot = "8")]
	public void FAHFAEABFGP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000521")]
	[Cpp2IlInjected.Address(RVA = "0x63863A0", Offset = "0x63853A0", VA = "0x1863863A0", Slot = "7")]
	public bool NKFKNEFDAFK()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000522")]
	[Cpp2IlInjected.Address(RVA = "0x6385F10", Offset = "0x6384F10", VA = "0x186385F10", Slot = "9")]
	public void EIHNIBFOFFJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000523")]
	[Cpp2IlInjected.Address(RVA = "0x63861F0", Offset = "0x63851F0", VA = "0x1863861F0", Slot = "11")]
	public void JPMGMMIEBBB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000524")]
	[Cpp2IlInjected.Address(RVA = "0x6386780", Offset = "0x6385780", VA = "0x186386780", Slot = "12")]
	public void OMMJOFBDFBB(bool JIPBGPFOHIP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000525")]
	[Cpp2IlInjected.Address(RVA = "0x6385D60", Offset = "0x6384D60", VA = "0x186385D60", Slot = "10")]
	public void DBEJFEPONEK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000526")]
	[Cpp2IlInjected.Address(RVA = "0x6386580", Offset = "0x6385580", VA = "0x186386580")]
	private bool OCGNOKOFLLC()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000527")]
	[Cpp2IlInjected.Address(RVA = "0x6385FC0", Offset = "0x6384FC0", VA = "0x186385FC0")]
	private void IFONICPCDIG()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200005A")]
internal sealed class AHBEMPPGABF : BJKCOGNFHAA
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000B2")]
	private readonly FGCABOJBJBA ECLMPMCOOIA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000B3")]
	private readonly KFKHIDKOEKA AKJAPLJIJCJ;

	[Cpp2IlInjected.Token(Token = "0x1700014F")]
	public Rigidbody JLNHKFKKICK
	{
		[Cpp2IlInjected.Token(Token = "0x6000528")]
		[Cpp2IlInjected.Address(RVA = "0x76F1F0", Offset = "0x76E1F0", VA = "0x18076F1F0", Slot = "4")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000529")]
		[Cpp2IlInjected.Address(RVA = "0x76F1E0", Offset = "0x76E1E0", VA = "0x18076F1E0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000150")]
	private bool LAHBJHCBLCC
	{
		[Cpp2IlInjected.Token(Token = "0x600052A")]
		[Cpp2IlInjected.Address(RVA = "0x6370230", Offset = "0x636F230", VA = "0x186370230")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000151")]
	public bool LFGLHLLGJDN
	{
		[Cpp2IlInjected.Token(Token = "0x600052D")]
		[Cpp2IlInjected.Address(RVA = "0xC73E90", Offset = "0xC72E90", VA = "0x180C73E90", Slot = "6")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600052B")]
	[Cpp2IlInjected.Address(RVA = "0x6370B60", Offset = "0x636FB60", VA = "0x186370B60")]
	public AHBEMPPGABF(EHCMNHLPJBM ECLMPMCOOIA, [In] OJNOICCBOJO FCLEEDACIMH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600052C")]
	[Cpp2IlInjected.Address(RVA = "0x6370AC0", Offset = "0x636FAC0", VA = "0x186370AC0", Slot = "5")]
	public void NPFDHKEDPBK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600052E")]
	[Cpp2IlInjected.Address(RVA = "0x6370200", Offset = "0x636F200", VA = "0x186370200", Slot = "7")]
	public void JEJJNCIBMKD(object PDIBILKHEBM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600052F")]
	[Cpp2IlInjected.Address(RVA = "0x6370410", Offset = "0x636F410", VA = "0x186370410", Slot = "8")]
	public void MPNABKADOLD(object PDIBILKHEBM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000530")]
	[Cpp2IlInjected.Address(RVA = "0x636FD20", Offset = "0x636ED20", VA = "0x18636FD20", Slot = "9")]
	public void IDCEKLJCOAF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000531")]
	[Cpp2IlInjected.Address(RVA = "0x63708D0", Offset = "0x636F8D0", VA = "0x1863708D0", Slot = "11")]
	public void NMEDAFKNELN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000532")]
	[Cpp2IlInjected.Address(RVA = "0x6370290", Offset = "0x636F290", VA = "0x186370290", Slot = "12")]
	public void MEFNPMCJONJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000533")]
	[Cpp2IlInjected.Address(RVA = "0x6370440", Offset = "0x636F440", VA = "0x186370440", Slot = "10")]
	public void NMDAPEFEOIC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000534")]
	[Cpp2IlInjected.Address(RVA = "0x636FB70", Offset = "0x636EB70", VA = "0x18636FB70")]
	private void AIPKPJDDFMB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000535")]
	[Cpp2IlInjected.Address(RVA = "0x6370050", Offset = "0x636F050", VA = "0x186370050")]
	private void IGFNNGHCGOM()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200005B")]
internal sealed class FKCKPMEAPNG : EGNMEGPNLGB, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000B5")]
	private readonly FGCABOJBJBA ECLMPMCOOIA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000B6")]
	private readonly KFKHIDKOEKA EFPALNMMNPB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000B7")]
	private float JGBHAJAINJC;

	[Cpp2IlInjected.Token(Token = "0x17000152")]
	public AFBJPJGOHAH PAKEEKMBNJI
	{
		[Cpp2IlInjected.Token(Token = "0x6000536")]
		[Cpp2IlInjected.Address(RVA = "0x76F1C0", Offset = "0x76E1C0", VA = "0x18076F1C0", Slot = "4")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000537")]
		[Cpp2IlInjected.Address(RVA = "0x76F190", Offset = "0x76E190", VA = "0x18076F190", Slot = "5")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000153")]
	public GAMCJHNBHDA CONGFAJKAFK
	{
		[Cpp2IlInjected.Token(Token = "0x6000538")]
		[Cpp2IlInjected.Address(RVA = "0x76F1D0", Offset = "0x76E1D0", VA = "0x18076F1D0", Slot = "6")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000539")]
		[Cpp2IlInjected.Address(RVA = "0x76F220", Offset = "0x76E220", VA = "0x18076F220", Slot = "7")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000154")]
	public Vector3 JLKBIOAHEKE
	{
		[Cpp2IlInjected.Token(Token = "0x600053A")]
		[Cpp2IlInjected.Address(RVA = "0x639A470", Offset = "0x6399470", VA = "0x18639A470", Slot = "8")]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x600053B")]
		[Cpp2IlInjected.Address(RVA = "0x639A590", Offset = "0x6399590", VA = "0x18639A590", Slot = "9")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000155")]
	public Vector3 ONCBIGPFDBG
	{
		[Cpp2IlInjected.Token(Token = "0x600053C")]
		[Cpp2IlInjected.Address(RVA = "0x639BF00", Offset = "0x639AF00", VA = "0x18639BF00", Slot = "10")]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x600053D")]
		[Cpp2IlInjected.Address(RVA = "0x639BDF0", Offset = "0x639ADF0", VA = "0x18639BDF0", Slot = "11")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000156")]
	public Vector3 ILEPAAIOGPH
	{
		[Cpp2IlInjected.Token(Token = "0x600053E")]
		[Cpp2IlInjected.Address(RVA = "0x639AD30", Offset = "0x6399D30", VA = "0x18639AD30", Slot = "12")]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x600053F")]
		[Cpp2IlInjected.Address(RVA = "0x639AB20", Offset = "0x6399B20", VA = "0x18639AB20", Slot = "13")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000157")]
	public Vector3 DINKBHOHIJN
	{
		[Cpp2IlInjected.Token(Token = "0x6000540")]
		[Cpp2IlInjected.Address(RVA = "0x639C650", Offset = "0x639B650", VA = "0x18639C650", Slot = "14")]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x6000541")]
		[Cpp2IlInjected.Address(RVA = "0x639AEB0", Offset = "0x6399EB0", VA = "0x18639AEB0", Slot = "15")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000158")]
	public float CEJDFPIKKNH
	{
		[Cpp2IlInjected.Token(Token = "0x6000542")]
		[Cpp2IlInjected.Address(RVA = "0x7BF290", Offset = "0x7BE290", VA = "0x1807BF290", Slot = "16")]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x6000543")]
		[Cpp2IlInjected.Address(RVA = "0x639AEE0", Offset = "0x6399EE0", VA = "0x18639AEE0", Slot = "17")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000159")]
	public bool CNPBCJLHPAJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000544")]
		[Cpp2IlInjected.Address(RVA = "0x1609A20", Offset = "0x1608A20", VA = "0x181609A20", Slot = "18")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700015A")]
	private HEOOOHDIHMG PDGEDPJKNNK
	{
		[Cpp2IlInjected.Token(Token = "0x6000558")]
		[Cpp2IlInjected.Address(RVA = "0x1CA8360", Offset = "0x1CA7360", VA = "0x181CA8360")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700015B")]
	private bool ECAGBOEDCGJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000559")]
		[Cpp2IlInjected.Address(RVA = "0x637F660", Offset = "0x637E660", VA = "0x18637F660")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000545")]
	[Cpp2IlInjected.Address(RVA = "0x639CE70", Offset = "0x639BE70", VA = "0x18639CE70")]
	public FKCKPMEAPNG(EHCMNHLPJBM ECLMPMCOOIA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000546")]
	[Cpp2IlInjected.Address(RVA = "0x639C230", Offset = "0x639B230", VA = "0x18639C230", Slot = "19")]
	public void NPFDHKEDPBK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000547")]
	[Cpp2IlInjected.Address(RVA = "0x639A650", Offset = "0x6399650", VA = "0x18639A650", Slot = "36")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000548")]
	[Cpp2IlInjected.Address(RVA = "0x639C160", Offset = "0x639B160", VA = "0x18639C160", Slot = "28")]
	public void KHNKJFJMFFM(Rigidbody IOJJIGGDNPN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000549")]
	[Cpp2IlInjected.Address(RVA = "0xAAC0C0", Offset = "0xAAB0C0", VA = "0x180AAC0C0", Slot = "20")]
	public void EJAMNEGFJEM(object PDIBILKHEBM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600054A")]
	[Cpp2IlInjected.Address(RVA = "0xAAB860", Offset = "0xAAA860", VA = "0x180AAB860", Slot = "30")]
	public void FGKEAHEDAEC(object PDIBILKHEBM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600054B")]
	[Cpp2IlInjected.Address(RVA = "0x639A720", Offset = "0x6399720", VA = "0x18639A720", Slot = "35")]
	public Vector3 ECOHLCBCAIO(Vector3 IACNFCFIIOM)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x600054C")]
	[Cpp2IlInjected.Address(RVA = "0x639ABE0", Offset = "0x6399BE0", VA = "0x18639ABE0", Slot = "34")]
	public Vector3 FNKNMFKCFHO(Vector3 GMLDNFHDNJP)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x600054D")]
	[Cpp2IlInjected.Address(RVA = "0x639C230", Offset = "0x639B230", VA = "0x18639C230", Slot = "27")]
	public void MBDGEAIJODJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600054E")]
	[Cpp2IlInjected.Address(RVA = "0x639AE50", Offset = "0x6399E50", VA = "0x18639AE50", Slot = "25")]
	public void GAMMNKDKDMP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600054F")]
	[Cpp2IlInjected.Address(RVA = "0x6399E80", Offset = "0x6398E80", VA = "0x186399E80", Slot = "24")]
	public void BCBGBGNDMKE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000550")]
	[Cpp2IlInjected.Address(RVA = "0x639C2E0", Offset = "0x639B2E0", VA = "0x18639C2E0", Slot = "33")]
	public void MLEAMOMCHPM(Vector3 PFBOCMNHECB, Vector3 EGGKDKAICGO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000551")]
	[Cpp2IlInjected.Address(RVA = "0x639C480", Offset = "0x639B480", VA = "0x18639C480", Slot = "32")]
	public void NADJGLGOMJF(Vector3 ACIPBFHCAAA, Vector3 PLLAPIPLOBE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000552")]
	[Cpp2IlInjected.Address(RVA = "0x639BFF0", Offset = "0x639AFF0", VA = "0x18639BFF0", Slot = "31")]
	public void KEIBJNKFFKK(Vector3 BCLKICLJPAP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000553")]
	[Cpp2IlInjected.Address(RVA = "0x639B330", Offset = "0x639A330", VA = "0x18639B330", Slot = "22")]
	public void IHIBCDABGEA(BOLJBMMECOE DBGBHNOCNJE, Vector3 HGEDCNMOIAN, float NBBOEEPKJMP, float MFOFCNBGOEE = 8f, float JKNAHEBOBHM = 1f)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000554")]
	[Cpp2IlInjected.Address(RVA = "0x639A890", Offset = "0x6399890", VA = "0x18639A890", Slot = "21")]
	public void EHCOAACKECM(LGPMEMPGHMC CFIODOIHFKI, Vector3 POKFEHNNFOH, float NLCECILHIIF = float.PositiveInfinity)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000555")]
	[Cpp2IlInjected.Address(RVA = "0x639AF90", Offset = "0x6399F90", VA = "0x18639AF90", Slot = "23")]
	[Obsolete("Deprecated. Still exists to support deprecated CV2 chips. Use ApplyAngularVelocityChange.")]
	public void IAGIBKOHJDJ(LGPMEMPGHMC CFIODOIHFKI, Vector3 LGOFCBEILGM, float DPKKDMEAKFE = 7f, float DLNPOBOGDPN = 1f)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000556")]
	[Cpp2IlInjected.Address(RVA = "0x639C740", Offset = "0x639B740", VA = "0x18639C740", Slot = "29")]
	public Vector3 NKFAKMKMGLK(Vector3 OBNDDJFFKOO)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000557")]
	[Cpp2IlInjected.Address(RVA = "0x639A340", Offset = "0x6399340", VA = "0x18639A340", Slot = "26")]
	public void DACCEJMCHOM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600055A")]
	[Cpp2IlInjected.Address(RVA = "0x639AEE0", Offset = "0x6399EE0", VA = "0x18639AEE0")]
	private void ONLOEHKHDFL(float APPJEOKOGAK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600055B")]
	[Cpp2IlInjected.Address(RVA = "0x639C4E0", Offset = "0x639B4E0", VA = "0x18639C4E0")]
	private void NGIEHIIJDJE(Vector3 POKFEHNNFOH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600055C")]
	[Cpp2IlInjected.Address(RVA = "0x639BE20", Offset = "0x639AE20", VA = "0x18639BE20")]
	private Vector3 KABAGJGGPBM()
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x600055D")]
	[Cpp2IlInjected.Address(RVA = "0x6399EE0", Offset = "0x6398EE0", VA = "0x186399EE0")]
	private void BDHFKDMBFBL(Vector3 GMLDNFHDNJP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600055E")]
	[Cpp2IlInjected.Address(RVA = "0x639CCE0", Offset = "0x639BCE0", VA = "0x18639CCE0")]
	private Vector3 OGOHBLJNEHM()
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x600055F")]
	[Cpp2IlInjected.Address(RVA = "0x639C8A0", Offset = "0x639B8A0", VA = "0x18639C8A0")]
	private void NLOEJKCIIKH(Vector3 APPJEOKOGAK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000560")]
	[Cpp2IlInjected.Address(RVA = "0x639B960", Offset = "0x639A960", VA = "0x18639B960")]
	private void JEFNMPKMHLO(Vector3 GMLDNFHDNJP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000561")]
	[Cpp2IlInjected.Address(RVA = "0x639CDC0", Offset = "0x639BDC0", VA = "0x18639CDC0")]
	private void OIDEMOIHGHE()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200005C")]
public class HKFHJPELICN : CKFHDMFFLAC
{
	[Cpp2IlInjected.Token(Token = "0x6000562")]
	[Cpp2IlInjected.Address(RVA = "0x639D450", Offset = "0x639C450", VA = "0x18639D450", Slot = "4")]
	public AEHPKHIMIDL LOJAHIJFBGD(EHCMNHLPJBM KKOFNCEIKDA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000563")]
	[Cpp2IlInjected.Address(RVA = "0x639D0B0", Offset = "0x639C0B0", VA = "0x18639D0B0", Slot = "5")]
	public EGNMEGPNLGB HNHMABEMGJI(EHCMNHLPJBM KKOFNCEIKDA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000564")]
	[Cpp2IlInjected.Address(RVA = "0x639D570", Offset = "0x639C570", VA = "0x18639D570", Slot = "6")]
	public CLEHINCHHDE OFKGIFIMGFJ(EHCMNHLPJBM KKOFNCEIKDA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000565")]
	[Cpp2IlInjected.Address(RVA = "0x639D050", Offset = "0x639C050", VA = "0x18639D050", Slot = "7")]
	public HNFHIEOAONP DIFFELNBIFI(EHCMNHLPJBM KKOFNCEIKDA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000566")]
	[Cpp2IlInjected.Address(RVA = "0x639D2D0", Offset = "0x639C2D0", VA = "0x18639D2D0", Slot = "8")]
	public EKKHALEFJMB KGANCFEAPKO(EHCMNHLPJBM KKOFNCEIKDA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000567")]
	[Cpp2IlInjected.Address(RVA = "0x639D510", Offset = "0x639C510", VA = "0x18639D510", Slot = "9")]
	public HFPBFKAEHJM NIGBNCBFBJJ(EHCMNHLPJBM KKOFNCEIKDA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000568")]
	[Cpp2IlInjected.Address(RVA = "0x639D4B0", Offset = "0x639C4B0", VA = "0x18639D4B0", Slot = "10")]
	public AGCCBIKJDAK MMKICHJCCKP(EHCMNHLPJBM KKOFNCEIKDA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000569")]
	[Cpp2IlInjected.Address(RVA = "0x639D270", Offset = "0x639C270", VA = "0x18639D270", Slot = "11")]
	public HEOOOHDIHMG JGJKHNJFOJD(EHCMNHLPJBM KKOFNCEIKDA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600056A")]
	[Cpp2IlInjected.Address(RVA = "0x639D5D0", Offset = "0x639C5D0", VA = "0x18639D5D0", Slot = "12")]
	public AOENHBHLFIE OIJEPIONEHP(EHCMNHLPJBM KKOFNCEIKDA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600056B")]
	[Cpp2IlInjected.Address(RVA = "0x639CFF0", Offset = "0x639BFF0", VA = "0x18639CFF0", Slot = "13")]
	public HIIFMKKGLIL BMEBOLGICDA(EHCMNHLPJBM KKOFNCEIKDA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600056C")]
	[Cpp2IlInjected.Address(RVA = "0x639D190", Offset = "0x639C190", VA = "0x18639D190")]
	public BJKCOGNFHAA NOLNAKDKDAI(EHCMNHLPJBM KKOFNCEIKDA, [In] OJNOICCBOJO FCLEEDACIMH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600056D")]
	[Cpp2IlInjected.Address(RVA = "0x639CF80", Offset = "0x639BF80", VA = "0x18639CF80")]
	public FHAABOAKHEB MLANGGFGHIF(EHCMNHLPJBM KKOFNCEIKDA, [In] OJNOICCBOJO FCLEEDACIMH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600056E")]
	[Cpp2IlInjected.Address(RVA = "0x639CF10", Offset = "0x639BF10", VA = "0x18639CF10")]
	public HFBOJOOMHLA AJEBNHHBCOM(EHCMNHLPJBM KKOFNCEIKDA, [In] OJNOICCBOJO FCLEEDACIMH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600056F")]
	[Cpp2IlInjected.Address(RVA = "0x639D200", Offset = "0x639C200", VA = "0x18639D200")]
	public KACNHFAPOGE PLHBGLLLBCK(EHCMNHLPJBM KKOFNCEIKDA, [In] OJNOICCBOJO FCLEEDACIMH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000570")]
	[Cpp2IlInjected.Address(RVA = "0x639D3E0", Offset = "0x639C3E0", VA = "0x18639D3E0")]
	public ADPECGILELO LMGICMACJAC(EHCMNHLPJBM KKOFNCEIKDA, [In] OJNOICCBOJO FCLEEDACIMH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000571")]
	[Cpp2IlInjected.Address(RVA = "0x639D330", Offset = "0x639C330", VA = "0x18639D330", Slot = "19")]
	public EHCMNHLPJBM LGLNIFFDNHL(RigidbodyEx ECLMPMCOOIA, OJNOICCBOJO FCLEEDACIMH, IDMHNKCBNME PPJFGCMLNID)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000572")]
	[Cpp2IlInjected.Address(RVA = "0x7734B0", Offset = "0x7724B0", VA = "0x1807734B0")]
	public HKFHJPELICN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000573")]
	[Cpp2IlInjected.Address(RVA = "0x639D190", Offset = "0x639C190", VA = "0x18639D190", Slot = "14")]
	private BJKCOGNFHAA IELGODAMALE(EHCMNHLPJBM KKOFNCEIKDA, [In] OJNOICCBOJO FCLEEDACIMH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000574")]
	[Cpp2IlInjected.Address(RVA = "0x639CF80", Offset = "0x639BF80", VA = "0x18639CF80", Slot = "15")]
	private FHAABOAKHEB BHJMNBNIEMG(EHCMNHLPJBM KKOFNCEIKDA, [In] OJNOICCBOJO FCLEEDACIMH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000575")]
	[Cpp2IlInjected.Address(RVA = "0x639CF10", Offset = "0x639BF10", VA = "0x18639CF10", Slot = "16")]
	private HFBOJOOMHLA KIOLGKLEKBC(EHCMNHLPJBM KKOFNCEIKDA, [In] OJNOICCBOJO FCLEEDACIMH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000576")]
	[Cpp2IlInjected.Address(RVA = "0x639D200", Offset = "0x639C200", VA = "0x18639D200", Slot = "17")]
	private KACNHFAPOGE JGCJOLJKIMG(EHCMNHLPJBM KKOFNCEIKDA, [In] OJNOICCBOJO FCLEEDACIMH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000577")]
	[Cpp2IlInjected.Address(RVA = "0x639D3E0", Offset = "0x639C3E0", VA = "0x18639D3E0", Slot = "18")]
	private ADPECGILELO MOLGPANBAAF(EHCMNHLPJBM KKOFNCEIKDA, [In] OJNOICCBOJO FCLEEDACIMH)
	{
		return null;
	}
}
namespace RRAssemblyIndex.RecRoom.Rbex.Runtime
{
	[Cpp2IlInjected.Token(Token = "0x200005D")]
	[global::RecRoom.CodeGen.Attributes.Preserve]
	internal class _RRAssemblyIndex : MEDPHPOAELF
	{
		[Cpp2IlInjected.Token(Token = "0x6000578")]
		[Cpp2IlInjected.Address(RVA = "0x79A600", Offset = "0x799600", VA = "0x18079A600")]
		[global::RecRoom.CodeGen.Attributes.Preserve]
		public _RRAssemblyIndex()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000579")]
		[Cpp2IlInjected.Address(RVA = "0x639D630", Offset = "0x639C630", VA = "0x18639D630", Slot = "6")]
		public sealed override void HHEFIFLAAMN(MHHKPCCLDJH CAEGDBPOJIB)
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
