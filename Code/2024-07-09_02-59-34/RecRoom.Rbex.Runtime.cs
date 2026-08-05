using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Cpp2IlInjected;
using Photon.Pun;
using RecRoom;
using RecRoom.DataLayer.Attributes;
using RecRoom.Logging.Attributes;
using RecRoom.Utils.OverridableFields;
using UnityEngine;
using UnityEngine.Serialization;

[assembly: AssemblyVersion("0.0.0.0")]
namespace _LogRegistration.RecRoom_Rbex_Runtime
{
	[Cpp2IlInjected.Token(Token = "0x2000002")]
	[CompilerGenerated]
	[RecRoom.Logging.Attributes.Preserve]
	public class LogRegistrationIndex : NNAGAKKCAAK
	{
		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(RVA = "0x7022F90", Offset = "0x7021B90", VA = "0x187022F90", Slot = "4")]
		public override void NGMFPPEDCJG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0x890220", Offset = "0x88EE20", VA = "0x180890220")]
		public LogRegistrationIndex()
		{
		}
	}
}
namespace _AssemblyRegistry.RecRoom_Rbex_Runtime
{
	[Cpp2IlInjected.Token(Token = "0x2000003")]
	[CompilerGenerated]
	[RecRoom.DataLayer.Attributes.Preserve]
	public class _AssemblyIndex : ONOOFAIPBBL
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000001")]
		private int[] localIndices0;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000002")]
		private ONBDNECECOJ bitset0;

		[Cpp2IlInjected.Token(Token = "0x17000001")]
		public override string[] ServiceCategories
		{
			[Cpp2IlInjected.Token(Token = "0x6000003")]
			[Cpp2IlInjected.Address(RVA = "0x86A480", Offset = "0x869080", VA = "0x18086A480", Slot = "4")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x14FE720", Offset = "0x14FD320", VA = "0x1814FE720", Slot = "5")]
		public override void BHGDKCJGGBI(List<int> globalFromLocalIndices)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x70305A0", Offset = "0x702F1A0", VA = "0x1870305A0")]
		private void EANELCJBNDN(JEHHCNKPELJ registry)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x70308A0", Offset = "0x702F4A0", VA = "0x1870308A0", Slot = "6")]
		public override void OAKDOBJINDP(JEHHCNKPELJ registry, [In] GKHDMGJMEGL filter)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x866B20", Offset = "0x865720", VA = "0x180866B20", Slot = "8")]
		public override void HAJCGDOEHIM(DNMIJDJJJKD registry)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x7030900", Offset = "0x702F500", VA = "0x187030900")]
		public _AssemblyIndex()
		{
		}
	}
}
namespace RecRoom
{
	[Cpp2IlInjected.Token(Token = "0x2000004")]
	[DisallowMultipleComponent]
	public sealed class RigidbodyEx : MonoBehaviour, NIJCOMOFOFB
	{
		[Cpp2IlInjected.Token(Token = "0x4000004")]
		private static readonly EEGEMFOKJOP PCIDDNELHMD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000005")]
		private bool NNEIDKBDNBE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000006")]
		private EGNFIBKBHKP MEEPFLLHJMM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000007")]
		[SerializeField]
		[JIPFFEAJEBK(OBLJNCJJPID.Self, false, false, false)]
		private Rigidbody unityRigidbody;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000008")]
		[SerializeField]
		[JIPFFEAJEBK(OBLJNCJJPID.SelfAndParent, true, false, false)]
		private PhotonView photonView;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000009")]
		[SerializeField]
		private OverridableVector3 precomputedCenterOfMass;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400000A")]
		[SerializeField]
		private OverridableVector3 customCenterOfMass;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x400000B")]
		[SerializeField]
		[FormerlySerializedAs("forceNoInterpolation")]
		private GPOLNCCKNBK physicsInterpolation;

		[Cpp2IlInjected.FieldOffset(Offset = "0x5C")]
		[Cpp2IlInjected.Token(Token = "0x400000C")]
		[SerializeField]
		[Tooltip("If checked, this object's Unity Rigidbody will not be stripped when parenting the object to another RigidbodyEx. Only check this on objects that have a Unity Rigidbody by default and who need access to Unity physics events like OnTriggerEnter, OnCollisionEnter, etc. This is sometimes set via script instead of this flag.")]
		private bool keepUnityRigidbodyWhileParented;

		[Cpp2IlInjected.FieldOffset(Offset = "0x5D")]
		[Cpp2IlInjected.Token(Token = "0x400000D")]
		[SerializeField]
		[Tooltip("If the RigidbodyEx has a parent that is being destroyed, this flag allows this RigidbodyEx to keep the parent set. The default behavior is thatthe parent property is set to null, resetting/clearing the existing parent when it is being destroyed.")]
		private bool keepParentOnParentDestroy;

		[Cpp2IlInjected.FieldOffset(Offset = "0x5E")]
		[Cpp2IlInjected.Token(Token = "0x400000E")]
		[SerializeField]
		[HideInInspector]
		private bool hasUnityRigidbodyByDefault;

		[Cpp2IlInjected.Token(Token = "0x17000002")]
		internal EGNFIBKBHKP IALPLOJEIIA
		{
			[Cpp2IlInjected.Token(Token = "0x6000009")]
			[Cpp2IlInjected.Address(RVA = "0x702BC60", Offset = "0x702A860", VA = "0x18702BC60")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000003")]
		private EGNFIBKBHKP NOHIHJHENKA
		{
			[Cpp2IlInjected.Token(Token = "0x600000A")]
			[Cpp2IlInjected.Address(RVA = "0x867590", Offset = "0x866190", VA = "0x180867590", Slot = "6")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000004")]
		public int FOOFFHHPMDI
		{
			[Cpp2IlInjected.Token(Token = "0x600001E")]
			[Cpp2IlInjected.Address(RVA = "0x702DA10", Offset = "0x702C610", VA = "0x18702DA10")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000005")]
		public RigidbodyEx FPAEKGEBJGL
		{
			[Cpp2IlInjected.Token(Token = "0x6000020")]
			[Cpp2IlInjected.Address(RVA = "0x702DD70", Offset = "0x702C970", VA = "0x18702DD70")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000006")]
		public RigidbodyEx LIOIAHEPIFM
		{
			[Cpp2IlInjected.Token(Token = "0x6000021")]
			[Cpp2IlInjected.Address(RVA = "0x702DCB0", Offset = "0x702C8B0", VA = "0x18702DCB0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000007")]
		public RigidbodyEx DELFIACNBGK
		{
			[Cpp2IlInjected.Token(Token = "0x6000022")]
			[Cpp2IlInjected.Address(RVA = "0x702EA10", Offset = "0x702D610", VA = "0x18702EA10")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000023")]
			[Cpp2IlInjected.Address(RVA = "0x702FF10", Offset = "0x702EB10", VA = "0x18702FF10")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000008")]
		public Transform IHAFHOPMHJI
		{
			[Cpp2IlInjected.Token(Token = "0x6000024")]
			[Cpp2IlInjected.Address(RVA = "0x88F6F0", Offset = "0x88E2F0", VA = "0x18088F6F0", Slot = "9")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000009")]
		public Transform JBNNMFNNNAO
		{
			[Cpp2IlInjected.Token(Token = "0x6000025")]
			[Cpp2IlInjected.Address(RVA = "0x88F6F0", Offset = "0x88E2F0", VA = "0x18088F6F0", Slot = "10")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000A")]
		public LHFCBMFLLBG FFPPBFFPFKN
		{
			[Cpp2IlInjected.Token(Token = "0x6000026")]
			[Cpp2IlInjected.Address(RVA = "0x702DA70", Offset = "0x702C670", VA = "0x18702DA70")]
			get
			{
				return default(LHFCBMFLLBG);
			}
			[Cpp2IlInjected.Token(Token = "0x6000027")]
			[Cpp2IlInjected.Address(RVA = "0x702F6C0", Offset = "0x702E2C0", VA = "0x18702F6C0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000B")]
		public bool OCAHNLHHELK
		{
			[Cpp2IlInjected.Token(Token = "0x6000028")]
			[Cpp2IlInjected.Address(RVA = "0x702E080", Offset = "0x702CC80", VA = "0x18702E080")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000C")]
		public bool EEPDKLKKOLN
		{
			[Cpp2IlInjected.Token(Token = "0x6000029")]
			[Cpp2IlInjected.Address(RVA = "0x702DB90", Offset = "0x702C790", VA = "0x18702DB90")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000D")]
		public INHEMIHIBFP DFIDBGCEBII
		{
			[Cpp2IlInjected.Token(Token = "0x600002A")]
			[Cpp2IlInjected.Address(RVA = "0x702DFC0", Offset = "0x702CBC0", VA = "0x18702DFC0")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600002B")]
			[Cpp2IlInjected.Address(RVA = "0x702F880", Offset = "0x702E480", VA = "0x18702F880")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000E")]
		public EDACBNCGKFK LIODHEOELNH
		{
			[Cpp2IlInjected.Token(Token = "0x600002C")]
			[Cpp2IlInjected.Address(RVA = "0x702DF60", Offset = "0x702CB60", VA = "0x18702DF60")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600002D")]
			[Cpp2IlInjected.Address(RVA = "0x702F810", Offset = "0x702E410", VA = "0x18702F810")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000F")]
		public bool GHBJLIODJHF
		{
			[Cpp2IlInjected.Token(Token = "0x600002E")]
			[Cpp2IlInjected.Address(RVA = "0x702DEB0", Offset = "0x702CAB0", VA = "0x18702DEB0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000010")]
		public Rigidbody CKFDKNLJFBH
		{
			[Cpp2IlInjected.Token(Token = "0x600002F")]
			[Cpp2IlInjected.Address(RVA = "0x702DF10", Offset = "0x702CB10", VA = "0x18702DF10")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000011")]
		public bool FAFDAGIIDHL
		{
			[Cpp2IlInjected.Token(Token = "0x6000030")]
			[Cpp2IlInjected.Address(RVA = "0x702DBF0", Offset = "0x702C7F0", VA = "0x18702DBF0")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000031")]
			[Cpp2IlInjected.Address(RVA = "0x702F730", Offset = "0x702E330", VA = "0x18702F730")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000012")]
		public bool ADNJINLDBGD
		{
			[Cpp2IlInjected.Token(Token = "0x6000032")]
			[Cpp2IlInjected.Address(RVA = "0x6CFD620", Offset = "0x6CFC220", VA = "0x186CFD620", Slot = "7")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000013")]
		public float OOIILPOIPPH
		{
			[Cpp2IlInjected.Token(Token = "0x6000033")]
			[Cpp2IlInjected.Address(RVA = "0x702E9B0", Offset = "0x702D5B0", VA = "0x18702E9B0")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000014")]
		public float JNHGPIJJLML
		{
			[Cpp2IlInjected.Token(Token = "0x6000034")]
			[Cpp2IlInjected.Address(RVA = "0x702E950", Offset = "0x702D550", VA = "0x18702E950")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x6000035")]
			[Cpp2IlInjected.Address(RVA = "0x702FEA0", Offset = "0x702EAA0", VA = "0x18702FEA0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000015")]
		public float EPCPCMHEJBJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000036")]
			[Cpp2IlInjected.Address(RVA = "0x702E2E0", Offset = "0x702CEE0", VA = "0x18702E2E0")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x6000037")]
			[Cpp2IlInjected.Address(RVA = "0x702FB20", Offset = "0x702E720", VA = "0x18702FB20")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000016")]
		public float EGGDIMEEDGF
		{
			[Cpp2IlInjected.Token(Token = "0x6000038")]
			[Cpp2IlInjected.Address(RVA = "0x702E0E0", Offset = "0x702CCE0", VA = "0x18702E0E0")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x6000039")]
			[Cpp2IlInjected.Address(RVA = "0x702F8F0", Offset = "0x702E4F0", VA = "0x18702F8F0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000017")]
		public bool HCEBNGKNMOE
		{
			[Cpp2IlInjected.Token(Token = "0x600003A")]
			[Cpp2IlInjected.Address(RVA = "0x702EF60", Offset = "0x702DB60", VA = "0x18702EF60")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x600003B")]
			[Cpp2IlInjected.Address(RVA = "0x7030450", Offset = "0x702F050", VA = "0x187030450")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000018")]
		public Vector3 GCMOCKDPCEC
		{
			[Cpp2IlInjected.Token(Token = "0x600003C")]
			[Cpp2IlInjected.Address(RVA = "0x702E730", Offset = "0x702D330", VA = "0x18702E730")]
			get
			{
				return default(Vector3);
			}
			[Cpp2IlInjected.Token(Token = "0x600003D")]
			[Cpp2IlInjected.Address(RVA = "0x702FC70", Offset = "0x702E870", VA = "0x18702FC70")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000019")]
		public Vector3 MLBOIPOGHLG
		{
			[Cpp2IlInjected.Token(Token = "0x600003E")]
			[Cpp2IlInjected.Address(RVA = "0x702F0A0", Offset = "0x702DCA0", VA = "0x18702F0A0")]
			get
			{
				return default(Vector3);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001A")]
		public CollisionDetectionMode HHOELFFEJBN
		{
			[Cpp2IlInjected.Token(Token = "0x600003F")]
			[Cpp2IlInjected.Address(RVA = "0x702E220", Offset = "0x702CE20", VA = "0x18702E220")]
			get
			{
				return default(CollisionDetectionMode);
			}
			[Cpp2IlInjected.Token(Token = "0x6000040")]
			[Cpp2IlInjected.Address(RVA = "0x702FA40", Offset = "0x702E640", VA = "0x18702FA40")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001B")]
		public float MOPMJLHOCCI
		{
			[Cpp2IlInjected.Token(Token = "0x6000041")]
			[Cpp2IlInjected.Address(RVA = "0x702DC50", Offset = "0x702C850", VA = "0x18702DC50")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x6000042")]
			[Cpp2IlInjected.Address(RVA = "0x702F7A0", Offset = "0x702E3A0", VA = "0x18702F7A0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001C")]
		public RigidbodyConstraints BONEEFDMJEH
		{
			[Cpp2IlInjected.Token(Token = "0x6000043")]
			[Cpp2IlInjected.Address(RVA = "0x702E280", Offset = "0x702CE80", VA = "0x18702E280")]
			get
			{
				return default(RigidbodyConstraints);
			}
			[Cpp2IlInjected.Token(Token = "0x6000044")]
			[Cpp2IlInjected.Address(RVA = "0x702FAB0", Offset = "0x702E6B0", VA = "0x18702FAB0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001D")]
		public Vector3 DEPDFBCNEPI
		{
			[Cpp2IlInjected.Token(Token = "0x6000045")]
			[Cpp2IlInjected.Address(RVA = "0x702EAD0", Offset = "0x702D6D0", VA = "0x18702EAD0")]
			get
			{
				return default(Vector3);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001E")]
		public Vector3 EIPKIKEIJNF
		{
			[Cpp2IlInjected.Token(Token = "0x6000046")]
			[Cpp2IlInjected.Address(RVA = "0x702EAD0", Offset = "0x702D6D0", VA = "0x18702EAD0")]
			get
			{
				return default(Vector3);
			}
			[Cpp2IlInjected.Token(Token = "0x6000047")]
			[Cpp2IlInjected.Address(RVA = "0x7030230", Offset = "0x702EE30", VA = "0x187030230")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001F")]
		public float FIPJKJHLJML
		{
			[Cpp2IlInjected.Token(Token = "0x6000048")]
			[Cpp2IlInjected.Address(RVA = "0x702E810", Offset = "0x702D410", VA = "0x18702E810")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x6000049")]
			[Cpp2IlInjected.Address(RVA = "0x702FD50", Offset = "0x702E950", VA = "0x18702FD50")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000020")]
		public float BLLABJPKACO
		{
			[Cpp2IlInjected.Token(Token = "0x600004A")]
			[Cpp2IlInjected.Address(RVA = "0x702EF00", Offset = "0x702DB00", VA = "0x18702EF00")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x600004B")]
			[Cpp2IlInjected.Address(RVA = "0x70303E0", Offset = "0x702EFE0", VA = "0x1870303E0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000021")]
		public Quaternion GNMGOJEKGHN
		{
			[Cpp2IlInjected.Token(Token = "0x600004C")]
			[Cpp2IlInjected.Address(RVA = "0x702EBB0", Offset = "0x702D7B0", VA = "0x18702EBB0")]
			get
			{
				return default(Quaternion);
			}
			[Cpp2IlInjected.Token(Token = "0x600004D")]
			[Cpp2IlInjected.Address(RVA = "0x702FFB0", Offset = "0x702EBB0", VA = "0x18702FFB0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000022")]
		public Quaternion ELLKBNBKBOH
		{
			[Cpp2IlInjected.Token(Token = "0x600004E")]
			[Cpp2IlInjected.Address(RVA = "0x702EE30", Offset = "0x702DA30", VA = "0x18702EE30")]
			get
			{
				return default(Quaternion);
			}
			[Cpp2IlInjected.Token(Token = "0x600004F")]
			[Cpp2IlInjected.Address(RVA = "0x7030310", Offset = "0x702EF10", VA = "0x187030310")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000023")]
		public Vector3 FJJHNPMFJOA
		{
			[Cpp2IlInjected.Token(Token = "0x6000050")]
			[Cpp2IlInjected.Address(RVA = "0x702EC80", Offset = "0x702D880", VA = "0x18702EC80")]
			get
			{
				return default(Vector3);
			}
			[Cpp2IlInjected.Token(Token = "0x6000051")]
			[Cpp2IlInjected.Address(RVA = "0x7030080", Offset = "0x702EC80", VA = "0x187030080")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000024")]
		public Quaternion KEIEBCDELCO
		{
			[Cpp2IlInjected.Token(Token = "0x6000052")]
			[Cpp2IlInjected.Address(RVA = "0x702ED60", Offset = "0x702D960", VA = "0x18702ED60")]
			get
			{
				return default(Quaternion);
			}
			[Cpp2IlInjected.Token(Token = "0x6000053")]
			[Cpp2IlInjected.Address(RVA = "0x7030160", Offset = "0x702ED60", VA = "0x187030160")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000025")]
		public Vector3 IFAKEJMGKPK
		{
			[Cpp2IlInjected.Token(Token = "0x6000054")]
			[Cpp2IlInjected.Address(RVA = "0x702EFC0", Offset = "0x702DBC0", VA = "0x18702EFC0")]
			get
			{
				return default(Vector3);
			}
			[Cpp2IlInjected.Token(Token = "0x6000055")]
			[Cpp2IlInjected.Address(RVA = "0x70304C0", Offset = "0x702F0C0", VA = "0x1870304C0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000026")]
		public Vector3 AANPGIPGGCD
		{
			[Cpp2IlInjected.Token(Token = "0x6000056")]
			[Cpp2IlInjected.Address(RVA = "0x702E870", Offset = "0x702D470", VA = "0x18702E870")]
			get
			{
				return default(Vector3);
			}
			[Cpp2IlInjected.Token(Token = "0x6000057")]
			[Cpp2IlInjected.Address(RVA = "0x702FDC0", Offset = "0x702E9C0", VA = "0x18702FDC0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000027")]
		public Vector3 EGKIANADJEO
		{
			[Cpp2IlInjected.Token(Token = "0x6000058")]
			[Cpp2IlInjected.Address(RVA = "0x702E140", Offset = "0x702CD40", VA = "0x18702E140")]
			get
			{
				return default(Vector3);
			}
			[Cpp2IlInjected.Token(Token = "0x6000059")]
			[Cpp2IlInjected.Address(RVA = "0x702F960", Offset = "0x702E560", VA = "0x18702F960")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000028")]
		public Vector3 EGODONBGLKF
		{
			[Cpp2IlInjected.Token(Token = "0x600005A")]
			[Cpp2IlInjected.Address(RVA = "0x702E650", Offset = "0x702D250", VA = "0x18702E650")]
			get
			{
				return default(Vector3);
			}
			[Cpp2IlInjected.Token(Token = "0x600005B")]
			[Cpp2IlInjected.Address(RVA = "0x702FB90", Offset = "0x702E790", VA = "0x18702FB90")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000029")]
		public Vector3 MKMNCAFCPDO
		{
			[Cpp2IlInjected.Token(Token = "0x600005C")]
			[Cpp2IlInjected.Address(RVA = "0x702E510", Offset = "0x702D110", VA = "0x18702E510")]
			get
			{
				return default(Vector3);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002A")]
		public Quaternion IPIMGOCDKPL
		{
			[Cpp2IlInjected.Token(Token = "0x600005D")]
			[Cpp2IlInjected.Address(RVA = "0x702E440", Offset = "0x702D040", VA = "0x18702E440")]
			get
			{
				return default(Quaternion);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002B")]
		public Vector3 GFKIFPAMJLI
		{
			[Cpp2IlInjected.Token(Token = "0x600005F")]
			[Cpp2IlInjected.Address(RVA = "0x702F260", Offset = "0x702DE60", VA = "0x18702F260")]
			get
			{
				return default(Vector3);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002C")]
		public Vector3 KCHFPFGBLOD
		{
			[Cpp2IlInjected.Token(Token = "0x6000060")]
			[Cpp2IlInjected.Address(RVA = "0x702F180", Offset = "0x702DD80", VA = "0x18702F180")]
			get
			{
				return default(Vector3);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002D")]
		public bool LODEHKIEEJN
		{
			[Cpp2IlInjected.Token(Token = "0x6000061")]
			[Cpp2IlInjected.Address(RVA = "0x702E5F0", Offset = "0x702D1F0", VA = "0x18702E5F0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002E")]
		public bool LAPFFGJNIKK
		{
			[Cpp2IlInjected.Token(Token = "0x6000062")]
			[Cpp2IlInjected.Address(RVA = "0x702E020", Offset = "0x702CC20", VA = "0x18702E020")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002F")]
		public bool DPBKMEPJJFG
		{
			[Cpp2IlInjected.Token(Token = "0x6000063")]
			[Cpp2IlInjected.Address(RVA = "0x702DB30", Offset = "0x702C730", VA = "0x18702DB30")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000030")]
		public bool GILGEOCHDBD
		{
			[Cpp2IlInjected.Token(Token = "0x6000064")]
			[Cpp2IlInjected.Address(RVA = "0x702DAD0", Offset = "0x702C6D0", VA = "0x18702DAD0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000031")]
		public bool MLLHNOBJLDC
		{
			[Cpp2IlInjected.Token(Token = "0x6000065")]
			[Cpp2IlInjected.Address(RVA = "0x702D9B0", Offset = "0x702C5B0", VA = "0x18702D9B0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000032")]
		public bool MPDCCOLPLEJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000066")]
			[Cpp2IlInjected.Address(RVA = "0x702E340", Offset = "0x702CF40", VA = "0x18702E340")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000033")]
		public bool FIIEBMHFBKD
		{
			[Cpp2IlInjected.Token(Token = "0x6000067")]
			[Cpp2IlInjected.Address(RVA = "0x5A33C90", Offset = "0x5A32890", VA = "0x185A33C90")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000001")]
		public event PNHJLHINCOF JBGGDGHENJB
		{
			[Cpp2IlInjected.Token(Token = "0x600000E")]
			[Cpp2IlInjected.Address(RVA = "0x702D8D0", Offset = "0x702C4D0", VA = "0x18702D8D0")]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x600000F")]
			[Cpp2IlInjected.Address(RVA = "0x702F5E0", Offset = "0x702E1E0", VA = "0x18702F5E0")]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000002")]
		public event PADECADCPBE CFHLFFFLALO
		{
			[Cpp2IlInjected.Token(Token = "0x6000010")]
			[Cpp2IlInjected.Address(RVA = "0x702D640", Offset = "0x702C240", VA = "0x18702D640")]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000011")]
			[Cpp2IlInjected.Address(RVA = "0x702F340", Offset = "0x702DF40", VA = "0x18702F340")]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000003")]
		public event PADECADCPBE PDHLFFDEEJB
		{
			[Cpp2IlInjected.Token(Token = "0x6000012")]
			[Cpp2IlInjected.Address(RVA = "0x702D6A0", Offset = "0x702C2A0", VA = "0x18702D6A0")]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000013")]
			[Cpp2IlInjected.Address(RVA = "0x702F3B0", Offset = "0x702DFB0", VA = "0x18702F3B0")]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000004")]
		public event PADECADCPBE EKMLDGKMBHD
		{
			[Cpp2IlInjected.Token(Token = "0x6000014")]
			[Cpp2IlInjected.Address(RVA = "0x702D7F0", Offset = "0x702C3F0", VA = "0x18702D7F0")]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000015")]
			[Cpp2IlInjected.Address(RVA = "0x702F500", Offset = "0x702E100", VA = "0x18702F500")]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000005")]
		public event Action<IABFIAOBIIB, IABFIAOBIIB> HNJNIGNEAPH
		{
			[Cpp2IlInjected.Token(Token = "0x6000016")]
			[Cpp2IlInjected.Address(RVA = "0x702D780", Offset = "0x702C380", VA = "0x18702D780")]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000017")]
			[Cpp2IlInjected.Address(RVA = "0x702F490", Offset = "0x702E090", VA = "0x18702F490")]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000006")]
		public event PADECADCPBE JHJMBOHMBNB
		{
			[Cpp2IlInjected.Token(Token = "0x6000018")]
			[Cpp2IlInjected.Address(RVA = "0x702D860", Offset = "0x702C460", VA = "0x18702D860")]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000019")]
			[Cpp2IlInjected.Address(RVA = "0x702F570", Offset = "0x702E170", VA = "0x18702F570")]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000007")]
		public event PADECADCPBE JAKMDGDGIJN
		{
			[Cpp2IlInjected.Token(Token = "0x600001A")]
			[Cpp2IlInjected.Address(RVA = "0x702D940", Offset = "0x702C540", VA = "0x18702D940")]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x600001B")]
			[Cpp2IlInjected.Address(RVA = "0x702F650", Offset = "0x702E250", VA = "0x18702F650")]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000008")]
		public event PADECADCPBE MBJBDJEOMPC
		{
			[Cpp2IlInjected.Token(Token = "0x600001C")]
			[Cpp2IlInjected.Address(RVA = "0x702D710", Offset = "0x702C310", VA = "0x18702D710")]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x600001D")]
			[Cpp2IlInjected.Address(RVA = "0x702F420", Offset = "0x702E020", VA = "0x18702F420")]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x867D20", Offset = "0x866920", VA = "0x180867D20", Slot = "8")]
		private void JKDNLMAGKGL(EGNFIBKBHKP JPJGGLNFIBC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x702B150", Offset = "0x7029D50", VA = "0x18702B150")]
		internal void AJHCILHIEEH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x702D360", Offset = "0x702BF60", VA = "0x18702D360")]
		[Conditional("UNITY_EDITOR")]
		[Conditional("DEBUG_BUILD")]
		public void TestOverrideUnityRigidbody(Rigidbody NCKHCJDOKCD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x702BEF0", Offset = "0x702AAF0", VA = "0x18702BEF0")]
		public NIJCOMOFOFB GetChild(int BAEBMIBABAE)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600005E")]
		[Cpp2IlInjected.Address(RVA = "0x702CFD0", Offset = "0x702BBD0", VA = "0x18702CFD0")]
		public void SetInertiaTensor((Quaternion rot, Vector3 moments) DAKHJKLEMDA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000068")]
		[Cpp2IlInjected.Address(RVA = "0x702BBF0", Offset = "0x702A7F0", VA = "0x18702BBF0")]
		private void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000069")]
		[Cpp2IlInjected.Address(RVA = "0x702BC60", Offset = "0x702A860", VA = "0x18702BC60")]
		private EGNFIBKBHKP HLIFDBAOGOO()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600006A")]
		[Cpp2IlInjected.Address(RVA = "0x702C3C0", Offset = "0x702AFC0", VA = "0x18702C3C0")]
		private void KCBMKHLALEF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006B")]
		[Cpp2IlInjected.Address(RVA = "0x702C7A0", Offset = "0x702B3A0", VA = "0x18702C7A0")]
		private void OnEnable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006C")]
		[Cpp2IlInjected.Address(RVA = "0x702B150", Offset = "0x7029D50", VA = "0x18702B150")]
		private void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006D")]
		[Cpp2IlInjected.Address(RVA = "0x702C740", Offset = "0x702B340", VA = "0x18702C740")]
		private void OnDrawGizmosSelected()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006E")]
		[Cpp2IlInjected.Address(RVA = "0x702C800", Offset = "0x702B400", VA = "0x18702C800")]
		private void OnValidate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006F")]
		[Cpp2IlInjected.Address(RVA = "0x702B1E0", Offset = "0x7029DE0", VA = "0x18702B1E0")]
		public void AddDoNotResetVelocityOnOwnershipChangeOverride(object GBENACPKFNA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000070")]
		[Cpp2IlInjected.Address(RVA = "0x702C860", Offset = "0x702B460", VA = "0x18702C860")]
		public void RemoveDoNotResetVelocityOnOwnershipChangeOverride(object GBENACPKFNA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000071")]
		[Cpp2IlInjected.Address(RVA = "0x702BE90", Offset = "0x702AA90", VA = "0x18702BE90")]
		public void DisableCachedInertialPropertyOverride()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000072")]
		[Cpp2IlInjected.Address(RVA = "0x702C6E0", Offset = "0x702B2E0", VA = "0x18702C6E0")]
		public void MarkCachedInertialParametersDirty()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000073")]
		[Cpp2IlInjected.Address(RVA = "0x702D130", Offset = "0x702BD30", VA = "0x18702D130")]
		public void SetParent(RigidbodyEx IIPLJLPCLBC, bool NOFJHFMCCCG = false)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000074")]
		[Cpp2IlInjected.Address(RVA = "0x702CB70", Offset = "0x702B770", VA = "0x18702CB70")]
		public void ResetLocalCenterOfMassToPrefabDefault()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000075")]
		[Cpp2IlInjected.Address(RVA = "0x702C1A0", Offset = "0x702ADA0", VA = "0x18702C1A0")]
		public bool IsRigidbodyAncestor(RigidbodyEx IEMOLANIJKF)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000076")]
		[Cpp2IlInjected.Address(RVA = "0x702C280", Offset = "0x702AE80", VA = "0x18702C280")]
		public bool IsRigidbodyDescendant(RigidbodyEx KGIDMKMGAJN)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000077")]
		[Cpp2IlInjected.Address(RVA = "0x702B450", Offset = "0x702A050", VA = "0x18702B450")]
		public void AddInterpolationRestriction(object GBENACPKFNA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000078")]
		[Cpp2IlInjected.Address(RVA = "0x702C8D0", Offset = "0x702B4D0", VA = "0x18702C8D0")]
		public void RemoveInterpolationRestriction(object GBENACPKFNA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000079")]
		[Cpp2IlInjected.Address(RVA = "0x702B4C0", Offset = "0x702A0C0", VA = "0x18702B4C0")]
		public void AddKinematic(object GBENACPKFNA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007A")]
		[Cpp2IlInjected.Address(RVA = "0x702C940", Offset = "0x702B540", VA = "0x18702C940")]
		public void RemoveKinematic(object GBENACPKFNA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007B")]
		[Cpp2IlInjected.Address(RVA = "0x702D0B0", Offset = "0x702BCB0", VA = "0x18702D0B0")]
		public void SetKinematic(object GBENACPKFNA, bool KBFDDAHABNO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007C")]
		[Cpp2IlInjected.Address(RVA = "0x702CED0", Offset = "0x702BAD0", VA = "0x18702CED0")]
		public void SetDiscontinuousPositionAndRotation(Vector3 CIBLJNHHDEI, Quaternion MEKOHPCFOEN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007D")]
		[Cpp2IlInjected.Address(RVA = "0x702CDD0", Offset = "0x702B9D0", VA = "0x18702CDD0")]
		public void SetDiscontinuousLocalPositionAndLocalRotation(Vector3 OODGCMHJCPI, Quaternion BBBLGHPGBJP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007E")]
		[Cpp2IlInjected.Address(RVA = "0x702C090", Offset = "0x702AC90", VA = "0x18702C090")]
		public Vector3 GetConstrainedVelocity(Vector3 IFAKEJMGKPK)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x600007F")]
		[Cpp2IlInjected.Address(RVA = "0x702BF80", Offset = "0x702AB80", VA = "0x18702BF80")]
		public Vector3 GetConstrainedAngularVelocity(Vector3 EGKIANADJEO)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x6000080")]
		[Cpp2IlInjected.Address(RVA = "0x702B360", Offset = "0x7029F60", VA = "0x18702B360")]
		public void AddForce(Vector3 FPPHGAIAECP, ForceMode FAJECLKJHJB = ForceMode.Force)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000081")]
		[Cpp2IlInjected.Address(RVA = "0x702B250", Offset = "0x7029E50", VA = "0x18702B250")]
		public void AddForceAtPosition(Vector3 FPPHGAIAECP, Vector3 DCDKACDAEIJ, ForceMode FAJECLKJHJB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000082")]
		[Cpp2IlInjected.Address(RVA = "0x702B690", Offset = "0x702A290", VA = "0x18702B690")]
		public void AddTorque(Vector3 FJDBDBPDFJB, ForceMode FAJECLKJHJB = ForceMode.Force)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000083")]
		[Cpp2IlInjected.Address(RVA = "0x702B530", Offset = "0x702A130", VA = "0x18702B530")]
		public void AddRelativeTorque(Vector3 FJDBDBPDFJB, ForceMode FAJECLKJHJB = ForceMode.Force)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000084")]
		[Cpp2IlInjected.Address(RVA = "0x702D430", Offset = "0x702C030", VA = "0x18702D430")]
		public Vector3 WorldToLocalVelocity(Vector3 HPLCNCFNOCB)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x6000085")]
		[Cpp2IlInjected.Address(RVA = "0x702C5D0", Offset = "0x702B1D0", VA = "0x18702C5D0")]
		public Vector3 LocalToWorldVelocity(Vector3 AANPGIPGGCD)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x6000086")]
		[Cpp2IlInjected.Address(RVA = "0x702BE30", Offset = "0x702AA30", VA = "0x18702BE30")]
		public void ClearVelocity()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000087")]
		[Cpp2IlInjected.Address(RVA = "0x702BDD0", Offset = "0x702A9D0", VA = "0x18702BDD0")]
		public void ClearUnityRigidbodyVelocity()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000088")]
		[Cpp2IlInjected.Address(RVA = "0x702BD70", Offset = "0x702A970", VA = "0x18702BD70")]
		public void ClearLinearVelocity()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000089")]
		[Cpp2IlInjected.Address(RVA = "0x702BD10", Offset = "0x702A910", VA = "0x18702BD10")]
		public void ClearAngularVelocity()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008A")]
		[Cpp2IlInjected.Address(RVA = "0x702CCD0", Offset = "0x702B8D0", VA = "0x18702CCD0")]
		public void ResetVelocityWorldSpace(Vector3 AJDEPJADDIH, Vector3 MAEPOHBIICK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008B")]
		[Cpp2IlInjected.Address(RVA = "0x702CBD0", Offset = "0x702B7D0", VA = "0x18702CBD0")]
		public void ResetVelocityLocalSpace(Vector3 PAHGAPJJGCH, Vector3 EGODONBGLKF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008C")]
		[Cpp2IlInjected.Address(RVA = "0x702CA90", Offset = "0x702B690", VA = "0x18702CA90")]
		public void ResetLinearVelocityLocalSpace(Vector3 PAHGAPJJGCH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008D")]
		[Cpp2IlInjected.Address(RVA = "0x702D260", Offset = "0x702BE60", VA = "0x18702D260")]
		public bool SweepTest(Vector3 MLCEOGMBLFG, [Out] RaycastHit IEALFPDCKEB, float DIPNJIGHAJA)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600008E")]
		[Cpp2IlInjected.Address(RVA = "0x702C360", Offset = "0x702AF60", VA = "0x18702C360")]
		public bool IsSleeping()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600008F")]
		[Cpp2IlInjected.Address(RVA = "0x702D200", Offset = "0x702BE00", VA = "0x18702D200")]
		public void Sleep()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000090")]
		[Cpp2IlInjected.Address(RVA = "0x702D3D0", Offset = "0x702BFD0", VA = "0x18702D3D0")]
		public void WakeUp()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000091")]
		[Cpp2IlInjected.Address(RVA = "0x702B620", Offset = "0x702A220", VA = "0x18702B620")]
		public void AddShouldHaveUnityRigidbodyToken(object GBENACPKFNA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000092")]
		[Cpp2IlInjected.Address(RVA = "0x702C9B0", Offset = "0x702B5B0", VA = "0x18702C9B0")]
		public void RemoveShouldHaveUnityRigidbodyToken(object GBENACPKFNA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000093")]
		[Cpp2IlInjected.Address(RVA = "0x702BA20", Offset = "0x702A620", VA = "0x18702BA20")]
		public void ApplyForceVelocityChange(JDPIALONKJP JIPJBNBKBLG, Vector3 NKHOFGAANEK, float EDHDLGGJOCE, float PKDMCAHEPPF = 8f, float FFHCMFMNDIM = 1f)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000094")]
		[Cpp2IlInjected.Address(RVA = "0x702B920", Offset = "0x702A520", VA = "0x18702B920")]
		public void ApplyAngularVelocityChange(OKFMPDPEOKJ HHBPGGPPJEP, Vector3 BGIPBKEALAM, float FDECAJPPJOA = float.PositiveInfinity)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000095")]
		[Cpp2IlInjected.Address(RVA = "0x702BAE0", Offset = "0x702A6E0", VA = "0x18702BAE0")]
		[Obsolete("Deprecated. Still exists to support deprecated CV2 chips. Use ApplyAngularVelocityChange.")]
		public void ApplyTorqueAngularVelocityChangeDeprecated(OKFMPDPEOKJ HHBPGGPPJEP, Vector3 GPEICHFGELO, float HLFLCONGPIA = 7f, float EKICCDEOMKG = 1f)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000096")]
		[Cpp2IlInjected.Address(RVA = "0x702B850", Offset = "0x702A450", VA = "0x18702B850")]
		public bool AllowedScaleChange(float GMIJCBEMLNL)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000097")]
		[Cpp2IlInjected.Address(RVA = "0x702B780", Offset = "0x702A380", VA = "0x18702B780")]
		public void AddWorldSpaceVelocityInHierarchyParentOverride(RigidbodyEx OBNADBOMLBC, object GBENACPKFNA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000098")]
		[Cpp2IlInjected.Address(RVA = "0x702CA20", Offset = "0x702B620", VA = "0x18702CA20")]
		public void RemoveWorldSpaceVelocityInHierarchyParentOverride(object GBENACPKFNA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000099")]
		[Cpp2IlInjected.Address(RVA = "0x702D5D0", Offset = "0x702C1D0", VA = "0x18702D5D0")]
		public RigidbodyEx()
		{
		}

		[SpecialName]
		[Cpp2IlInjected.Token(Token = "0x600009B")]
		[Cpp2IlInjected.Address(RVA = "0x959A50", Offset = "0x958650", VA = "0x180959A50", Slot = "4")]
		private GameObject GEILFJCEGAN()
		{
			return null;
		}

		[SpecialName]
		[Cpp2IlInjected.Token(Token = "0x600009C")]
		[Cpp2IlInjected.Address(RVA = "0x88F6F0", Offset = "0x88E2F0", VA = "0x18088F6F0", Slot = "5")]
		private Transform PFFEOCDGENF()
		{
			return null;
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
internal static class HHAFBENPAEB
{
	[Cpp2IlInjected.Token(Token = "0x600009D")]
	[Cpp2IlInjected.Address(RVA = "0x701E470", Offset = "0x701D070", VA = "0x18701E470")]
	public static EGNFIBKBHKP IALPLOJEIIA(this RigidbodyEx JMMPGPEMBEI)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
[PJPINLCJEGC(typeof(NPICBIONHHC), new string[] { })]
public class BAOIGFGAHCE : NPICBIONHHC, PNBJBHKBIBJ
{
	[Cpp2IlInjected.Token(Token = "0x400000F")]
	private static readonly EEGEMFOKJOP IGMINGONOGN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000010")]
	private DBENOAJDGJG JPPJBALBCNC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000011")]
	private BMCNAFPJCOL JMKPKEHPNLL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000012")]
	private FJIMMJIOKCJ FPEJFPOJONG;

	[Cpp2IlInjected.Token(Token = "0x17000034")]
	public BMCNAFPJCOL PMNBJNPINMP
	{
		[Cpp2IlInjected.Token(Token = "0x600009E")]
		[Cpp2IlInjected.Address(RVA = "0x865990", Offset = "0x864590", VA = "0x180865990", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000035")]
	public FJIMMJIOKCJ NKLBMKHAGBK
	{
		[Cpp2IlInjected.Token(Token = "0x600009F")]
		[Cpp2IlInjected.Address(RVA = "0x867590", Offset = "0x866190", VA = "0x180867590", Slot = "5")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000A0")]
	[Cpp2IlInjected.Address(RVA = "0x70153A0", Offset = "0x7013FA0", VA = "0x1870153A0", Slot = "7")]
	public void InitReferences(IELNGKFCIIK HCJHLONKJLK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A1")]
	[Cpp2IlInjected.Address(RVA = "0x70152A0", Offset = "0x7013EA0", VA = "0x1870152A0", Slot = "6")]
	public EGNFIBKBHKP GDNNBJHAMFI(RigidbodyEx JMMPGPEMBEI, CCGIPMCDDGA JGFKFMMOAJO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000A2")]
	[Cpp2IlInjected.Address(RVA = "0x86FB10", Offset = "0x86E710", VA = "0x18086FB10")]
	public BAOIGFGAHCE()
	{
	}
}
namespace RecRoom
{
	[Cpp2IlInjected.Token(Token = "0x2000007")]
	public class PhysicsManager : SingletonMonoBehaviour<PhysicsManager>
	{
		[Cpp2IlInjected.Token(Token = "0x4000013")]
		public static MMAIJBDFGNK UpdateAfterFixedUpdateRan;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000014")]
		private int LPGJDHEGKIH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x4000015")]
		private int PBELLCBGKDL;

		[Cpp2IlInjected.Token(Token = "0x60000A4")]
		[Cpp2IlInjected.Address(RVA = "0x702AFB0", Offset = "0x7029BB0", VA = "0x18702AFB0")]
		protected void FixedUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A5")]
		[Cpp2IlInjected.Address(RVA = "0x702AFF0", Offset = "0x7029BF0", VA = "0x18702AFF0")]
		protected void Update()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A6")]
		[Cpp2IlInjected.Address(RVA = "0x702AFD0", Offset = "0x7029BD0", VA = "0x18702AFD0")]
		protected void LateUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A7")]
		[Cpp2IlInjected.Address(RVA = "0x866B20", Offset = "0x865720", VA = "0x180866B20")]
		[Conditional("UNITY_ASSERTIONS")]
		public void AssertLateColliderPositionsNotYetUpdated([Optional] string NKAJDDICLFH, [Optional] UnityEngine.Object NGDLPEOFMHL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A8")]
		[Cpp2IlInjected.Address(RVA = "0x866B20", Offset = "0x865720", VA = "0x180866B20")]
		[Conditional("UNITY_ASSERTIONS")]
		public void AssertLateColliderPositionsAlreadyUpdated([Optional] string NKAJDDICLFH, [Optional] UnityEngine.Object NGDLPEOFMHL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A9")]
		[Cpp2IlInjected.Address(RVA = "0x702B100", Offset = "0x7029D00", VA = "0x18702B100")]
		public PhysicsManager()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
public static class ANFHOLLHGEI
{
	[Cpp2IlInjected.Token(Token = "0x2000009")]
	private class PBICOFKNKEE : INHEMIHIBFP, IDisposable
	{
		[Cpp2IlInjected.Token(Token = "0x60000AD")]
		[Cpp2IlInjected.Address(RVA = "0x866B20", Offset = "0x865720", VA = "0x180866B20", Slot = "6")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AE")]
		[Cpp2IlInjected.Address(RVA = "0x875CE0", Offset = "0x8748E0", VA = "0x180875CE0", Slot = "4")]
		public Vector3 CFKODBLBHJI()
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x60000AF")]
		[Cpp2IlInjected.Address(RVA = "0x875CE0", Offset = "0x8748E0", VA = "0x180875CE0", Slot = "5")]
		public Vector3 KHDGCHKELJI()
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x60000B0")]
		[Cpp2IlInjected.Address(RVA = "0x86FB10", Offset = "0x86E710", VA = "0x18086FB10")]
		public PBICOFKNKEE()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000036")]
	public static INHEMIHIBFP HOODGAAFECM
	{
		[Cpp2IlInjected.Token(Token = "0x60000AB")]
		[Cpp2IlInjected.Address(RVA = "0x70151D0", Offset = "0x7013DD0", VA = "0x1870151D0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
public interface FDBIKGBKFEF
{
	[Cpp2IlInjected.Token(Token = "0x17000037")]
	CollisionDetectionMode CJKJNHCCBNE
	{
		[Cpp2IlInjected.Token(Token = "0x60000B1")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
		[Cpp2IlInjected.Token(Token = "0x60000B2")]
		[Cpp2IlInjected.Address(Slot = "1")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x60000B3")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void BCJIBCPCLJO();

	[Cpp2IlInjected.Token(Token = "0x60000B4")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void DKKIABEEHHJ(bool LODEHKIEEJN);

	[Cpp2IlInjected.Token(Token = "0x60000B5")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void JHOGHBHPDHM(bool LODEHKIEEJN);

	[Cpp2IlInjected.Token(Token = "0x60000B6")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void PMJCKMMFMFM(Rigidbody JJDGGMNFHIL);

	[Cpp2IlInjected.Token(Token = "0x60000B7")]
	[Cpp2IlInjected.Address(Slot = "6")]
	bool LMDHKAMDKDE(Vector3 MLCEOGMBLFG, [Out] RaycastHit IEALFPDCKEB, float DIPNJIGHAJA);
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
public interface CCCKAHDOEDH : IDisposable, NECDNJPEKJG
{
	[Cpp2IlInjected.Token(Token = "0x17000038")]
	LHFCBMFLLBG FFPPBFFPFKN
	{
		[Cpp2IlInjected.Token(Token = "0x60000BA")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
		[Cpp2IlInjected.Token(Token = "0x60000BB")]
		[Cpp2IlInjected.Address(Slot = "3")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x14000009")]
	event Action<IABFIAOBIIB, IABFIAOBIIB> HNJNIGNEAPH;

	[Cpp2IlInjected.Token(Token = "0x60000BC")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void BCJIBCPCLJO();
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
[KHCGLFKHKLK(MNBOKCFMODA.Application)]
public interface FJIMMJIOKCJ
{
	[Cpp2IlInjected.Token(Token = "0x60000BD")]
	[Cpp2IlInjected.Address(Slot = "0")]
	LFBFGPDKIHF MFANHIPCANH(EGNFIBKBHKP JPJGGLNFIBC);

	[Cpp2IlInjected.Token(Token = "0x60000BE")]
	[Cpp2IlInjected.Address(Slot = "1")]
	PKGFJJHHDNP EDOLMDBKLPD(EGNFIBKBHKP JPJGGLNFIBC);

	[Cpp2IlInjected.Token(Token = "0x60000BF")]
	[Cpp2IlInjected.Address(Slot = "2")]
	CKOKBJLNIGM PAOOBPAKOBB(EGNFIBKBHKP JPJGGLNFIBC);

	[Cpp2IlInjected.Token(Token = "0x60000C0")]
	[Cpp2IlInjected.Address(Slot = "3")]
	OFABJBGMCEJ MKDIICBMIKK(EGNFIBKBHKP JPJGGLNFIBC);

	[Cpp2IlInjected.Token(Token = "0x60000C1")]
	[Cpp2IlInjected.Address(Slot = "4")]
	OOPCMGEAGDH POHIHJEEJOM(EGNFIBKBHKP JPJGGLNFIBC);

	[Cpp2IlInjected.Token(Token = "0x60000C2")]
	[Cpp2IlInjected.Address(Slot = "5")]
	CCCKAHDOEDH EFBGOOCMOJE(EGNFIBKBHKP JPJGGLNFIBC);

	[Cpp2IlInjected.Token(Token = "0x60000C3")]
	[Cpp2IlInjected.Address(Slot = "6")]
	BFAJBPGIDNL MCJGBIEFEIH(EGNFIBKBHKP JPJGGLNFIBC);

	[Cpp2IlInjected.Token(Token = "0x60000C4")]
	[Cpp2IlInjected.Address(Slot = "7")]
	AIIECHHMHKF KKLKGLFJFIA(EGNFIBKBHKP JPJGGLNFIBC);

	[Cpp2IlInjected.Token(Token = "0x60000C5")]
	[Cpp2IlInjected.Address(Slot = "8")]
	FDBIKGBKFEF ANKJIFCAPGM(EGNFIBKBHKP JPJGGLNFIBC);

	[Cpp2IlInjected.Token(Token = "0x60000C6")]
	[Cpp2IlInjected.Address(Slot = "9")]
	EOFGEIBMJGB OKDEBCHPHGA(EGNFIBKBHKP JPJGGLNFIBC);

	[Cpp2IlInjected.Token(Token = "0x60000C7")]
	[Cpp2IlInjected.Address(Slot = "10")]
	ACOGMOKAGMB KJJAEHOOFDO(EGNFIBKBHKP JPJGGLNFIBC, [In] CCGIPMCDDGA JGFKFMMOAJO);

	[Cpp2IlInjected.Token(Token = "0x60000C8")]
	[Cpp2IlInjected.Address(Slot = "11")]
	IPKAFMFLAHB NAKMOENFAHL(EGNFIBKBHKP JPJGGLNFIBC, [In] CCGIPMCDDGA JGFKFMMOAJO);

	[Cpp2IlInjected.Token(Token = "0x60000C9")]
	[Cpp2IlInjected.Address(Slot = "12")]
	CJNOICOENPF JKCGFDAEIHI(EGNFIBKBHKP JPJGGLNFIBC, [In] CCGIPMCDDGA JGFKFMMOAJO);

	[Cpp2IlInjected.Token(Token = "0x60000CA")]
	[Cpp2IlInjected.Address(Slot = "13")]
	ADDPLOFLCBC DJBOOBNMODB(EGNFIBKBHKP JPJGGLNFIBC, [In] CCGIPMCDDGA JGFKFMMOAJO);

	[Cpp2IlInjected.Token(Token = "0x60000CB")]
	[Cpp2IlInjected.Address(Slot = "14")]
	IDNMICNIEEM EFCELJPCHKG(EGNFIBKBHKP JPJGGLNFIBC, [In] CCGIPMCDDGA JGFKFMMOAJO);

	[Cpp2IlInjected.Token(Token = "0x60000CC")]
	[Cpp2IlInjected.Address(Slot = "15")]
	EGNFIBKBHKP GDNNBJHAMFI(RigidbodyEx JMMPGPEMBEI, CCGIPMCDDGA JGFKFMMOAJO, NPICBIONHHC DMMHPLIIKDJ);
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
public interface AIIECHHMHKF
{
	[Cpp2IlInjected.Token(Token = "0x60000CD")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void BABMAEABEIM(Vector3 FPPHGAIAECP, ForceMode FAJECLKJHJB = ForceMode.Force);

	[Cpp2IlInjected.Token(Token = "0x60000CE")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void ICKGEAJCKAG(Vector3 FPPHGAIAECP, Vector3 DCDKACDAEIJ, ForceMode FAJECLKJHJB);

	[Cpp2IlInjected.Token(Token = "0x60000CF")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void ALPGIIFOJJD(Vector3 FJDBDBPDFJB, ForceMode FAJECLKJHJB = ForceMode.Force);

	[Cpp2IlInjected.Token(Token = "0x60000D0")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void NFMDMFEEENC(Vector3 FJDBDBPDFJB, ForceMode FAJECLKJHJB = ForceMode.Force);
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
public interface EOFGEIBMJGB
{
	[Cpp2IlInjected.Token(Token = "0x17000039")]
	bool FPHBHOGHBMJ
	{
		[Cpp2IlInjected.Token(Token = "0x60000D1")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
		[Cpp2IlInjected.Token(Token = "0x60000D2")]
		[Cpp2IlInjected.Address(Slot = "1")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x60000D3")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void PMJCKMMFMFM(Rigidbody JJDGGMNFHIL);

	[Cpp2IlInjected.Token(Token = "0x60000D4")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void IECHDHOIHFH(Rigidbody JJDGGMNFHIL);
}
[Cpp2IlInjected.Token(Token = "0x200000F")]
public interface LFBFGPDKIHF : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x1700003A")]
	IReadOnlyList<EGNFIBKBHKP> JAIPPCINDPE
	{
		[Cpp2IlInjected.Token(Token = "0x60000E7")]
		[Cpp2IlInjected.Address(Slot = "18")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700003B")]
	EGNFIBKBHKP LIOIAHEPIFM
	{
		[Cpp2IlInjected.Token(Token = "0x60000E8")]
		[Cpp2IlInjected.Address(Slot = "19")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700003C")]
	EGNFIBKBHKP BBKNDFHDFHL
	{
		[Cpp2IlInjected.Token(Token = "0x60000E9")]
		[Cpp2IlInjected.Address(Slot = "20")]
		get;
		[Cpp2IlInjected.Token(Token = "0x60000EA")]
		[Cpp2IlInjected.Address(Slot = "21")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x1400000A")]
	event PADECADCPBE CFHLFFFLALO;

	[Cpp2IlInjected.Token(Token = "0x1400000B")]
	event PADECADCPBE PDHLFFDEEJB;

	[Cpp2IlInjected.Token(Token = "0x1400000C")]
	event PNHJLHINCOF IGAOMNPMGGA;

	[Cpp2IlInjected.Token(Token = "0x1400000D")]
	event Action BGACKAGMGAH;

	[Cpp2IlInjected.Token(Token = "0x1400000E")]
	event Action JNFLCHJLPNN;

	[Cpp2IlInjected.Token(Token = "0x1400000F")]
	event Action<EGNFIBKBHKP> OILOLCMMGFB;

	[Cpp2IlInjected.Token(Token = "0x14000010")]
	event Action<EGNFIBKBHKP> CEJNGGHDFMA;

	[Cpp2IlInjected.Token(Token = "0x14000011")]
	event Action IDPABJPGLKN;

	[Cpp2IlInjected.Token(Token = "0x14000012")]
	event Action<EGNFIBKBHKP> NEPDBDGFAJF;

	[Cpp2IlInjected.Token(Token = "0x60000EB")]
	[Cpp2IlInjected.Address(Slot = "22")]
	void PNCCPJNBDLO(EGNFIBKBHKP EGKBIIFMAKK, bool NOFJHFMCCCG = false);
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
public interface CKOKBJLNIGM
{
	[Cpp2IlInjected.Token(Token = "0x1700003D")]
	Vector3 KHKHPEILLBD
	{
		[Cpp2IlInjected.Token(Token = "0x60000EC")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700003E")]
	Vector3 BPONHOGLMCE
	{
		[Cpp2IlInjected.Token(Token = "0x60000ED")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x60000EE")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void KACOKNOCLCB(EGNFIBKBHKP DELFIACNBGK, object GBENACPKFNA);

	[Cpp2IlInjected.Token(Token = "0x60000EF")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void LKHNBOGOFBE(object GBENACPKFNA);
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
public interface ADDPLOFLCBC
{
	[Cpp2IlInjected.Token(Token = "0x1700003F")]
	Vector3 LMNBHBJAJFM
	{
		[Cpp2IlInjected.Token(Token = "0x60000F2")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
		[Cpp2IlInjected.Token(Token = "0x60000F3")]
		[Cpp2IlInjected.Address(Slot = "3")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000040")]
	Vector3 HAIHKHGGPPP
	{
		[Cpp2IlInjected.Token(Token = "0x60000F4")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000041")]
	float ECJECJPONJA
	{
		[Cpp2IlInjected.Token(Token = "0x60000F5")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000042")]
	float GOBLNFAJJOD
	{
		[Cpp2IlInjected.Token(Token = "0x60000F6")]
		[Cpp2IlInjected.Address(Slot = "6")]
		get;
		[Cpp2IlInjected.Token(Token = "0x60000F7")]
		[Cpp2IlInjected.Address(Slot = "7")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000043")]
	Vector3 PNJPKBMKLJM
	{
		[Cpp2IlInjected.Token(Token = "0x60000F8")]
		[Cpp2IlInjected.Address(Slot = "8")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000044")]
	Quaternion NEDIJPEDJGG
	{
		[Cpp2IlInjected.Token(Token = "0x60000F9")]
		[Cpp2IlInjected.Address(Slot = "9")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x14000013")]
	event PADECADCPBE HAJOBMONHGF;

	[Cpp2IlInjected.Token(Token = "0x60000FA")]
	[Cpp2IlInjected.Address(Slot = "10")]
	void DIODJNGDMDD((Quaternion rot, Vector3 moments) DAKHJKLEMDA);

	[Cpp2IlInjected.Token(Token = "0x60000FB")]
	[Cpp2IlInjected.Address(Slot = "11")]
	void BOFJEGKPIDK();

	[Cpp2IlInjected.Token(Token = "0x60000FC")]
	[Cpp2IlInjected.Address(Slot = "12")]
	void OLGGIMDAFGE();

	[Cpp2IlInjected.Token(Token = "0x60000FD")]
	[Cpp2IlInjected.Address(Slot = "13")]
	void KGOEDDJICMA();

	[Cpp2IlInjected.Token(Token = "0x60000FE")]
	[Cpp2IlInjected.Address(Slot = "14")]
	void PMJCKMMFMFM(Rigidbody JJDGGMNFHIL);

	[Cpp2IlInjected.Token(Token = "0x60000FF")]
	[Cpp2IlInjected.Address(Slot = "15")]
	void IECHDHOIHFH(Rigidbody JJDGGMNFHIL);

	[Cpp2IlInjected.Token(Token = "0x6000100")]
	[Cpp2IlInjected.Address(Slot = "16")]
	void FIAFIGKJINB();
}
[Cpp2IlInjected.Token(Token = "0x2000012")]
public interface CJNOICOENPF
{
	[Cpp2IlInjected.Token(Token = "0x6000101")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void BCJIBCPCLJO();

	[Cpp2IlInjected.Token(Token = "0x6000102")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void GBHOPLHFBHM(object GBENACPKFNA);

	[Cpp2IlInjected.Token(Token = "0x6000103")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void MGGLHFPPBGN(object GBENACPKFNA);

	[Cpp2IlInjected.Token(Token = "0x6000104")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void BDEHACNBHEN(EGNFIBKBHKP JMMPGPEMBEI);

	[Cpp2IlInjected.Token(Token = "0x6000105")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void COCEOOPPNJP(EGNFIBKBHKP JMMPGPEMBEI);

	[Cpp2IlInjected.Token(Token = "0x6000106")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void BDDNLKOPENA();
}
[Cpp2IlInjected.Token(Token = "0x2000013")]
public interface BFAJBPGIDNL
{
	[Cpp2IlInjected.Token(Token = "0x17000045")]
	bool PHMLJIAJDCC
	{
		[Cpp2IlInjected.Token(Token = "0x6000109")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x14000014")]
	event PADECADCPBE JPCEHDELPPJ;

	[Cpp2IlInjected.Token(Token = "0x600010A")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void AEGKOCEMEGJ(object GBENACPKFNA);

	[Cpp2IlInjected.Token(Token = "0x600010B")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void PEFODCFIPOM(object GBENACPKFNA);

	[Cpp2IlInjected.Token(Token = "0x600010C")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void OPGIAECBLAE(object GBENACPKFNA, bool KBFDDAHABNO);

	[Cpp2IlInjected.Token(Token = "0x600010D")]
	[Cpp2IlInjected.Address(Slot = "6")]
	void PMJCKMMFMFM(Rigidbody IGFNCGLOHFM);

	[Cpp2IlInjected.Token(Token = "0x600010E")]
	[Cpp2IlInjected.Address(Slot = "7")]
	void IECHDHOIHFH(Rigidbody JJDGGMNFHIL);
}
[Cpp2IlInjected.Token(Token = "0x2000014")]
public interface IPKAFMFLAHB : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x17000046")]
	bool OCAHNLHHELK
	{
		[Cpp2IlInjected.Token(Token = "0x6000111")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000047")]
	bool EEPDKLKKOLN
	{
		[Cpp2IlInjected.Token(Token = "0x6000112")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x14000015")]
	event PADECADCPBE JPIIIJEFFCH;

	[Cpp2IlInjected.Token(Token = "0x6000113")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void BCJIBCPCLJO();

	[Cpp2IlInjected.Token(Token = "0x6000114")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void KGPEPBNPCNL(EGNFIBKBHKP DELFIACNBGK);

	[Cpp2IlInjected.Token(Token = "0x6000115")]
	[Cpp2IlInjected.Address(Slot = "6")]
	void JOCHOOBKGCN(EGNFIBKBHKP DELFIACNBGK);
}
[Cpp2IlInjected.Token(Token = "0x2000015")]
public interface IDNMICNIEEM
{
	[Cpp2IlInjected.Token(Token = "0x17000048")]
	bool FAFDAGIIDHL
	{
		[Cpp2IlInjected.Token(Token = "0x6000116")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
		[Cpp2IlInjected.Token(Token = "0x6000117")]
		[Cpp2IlInjected.Address(Slot = "1")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000049")]
	bool MOAJDDFOCJO
	{
		[Cpp2IlInjected.Token(Token = "0x6000118")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700004A")]
	RigidbodyConstraints LAFPPCHIKBM
	{
		[Cpp2IlInjected.Token(Token = "0x6000119")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
		[Cpp2IlInjected.Token(Token = "0x600011A")]
		[Cpp2IlInjected.Address(Slot = "4")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x600011B")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void PMJCKMMFMFM(Rigidbody JJDGGMNFHIL);

	[Cpp2IlInjected.Token(Token = "0x600011C")]
	[Cpp2IlInjected.Address(Slot = "6")]
	void IECHDHOIHFH(Rigidbody JJDGGMNFHIL);
}
[Cpp2IlInjected.Token(Token = "0x2000016")]
public interface OFABJBGMCEJ
{
	[Cpp2IlInjected.Token(Token = "0x1700004B")]
	float EEJCJOIJJON
	{
		[Cpp2IlInjected.Token(Token = "0x600011D")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
		[Cpp2IlInjected.Token(Token = "0x600011E")]
		[Cpp2IlInjected.Address(Slot = "1")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x1700004C")]
	float HHODGMIMJEL
	{
		[Cpp2IlInjected.Token(Token = "0x600011F")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
		[Cpp2IlInjected.Token(Token = "0x6000120")]
		[Cpp2IlInjected.Address(Slot = "3")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x6000121")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void PMJCKMMFMFM(Rigidbody JJDGGMNFHIL);

	[Cpp2IlInjected.Token(Token = "0x6000122")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void IECHDHOIHFH(Rigidbody JJDGGMNFHIL);
}
[Cpp2IlInjected.Token(Token = "0x2000017")]
public interface OOPCMGEAGDH
{
	[Cpp2IlInjected.Token(Token = "0x14000016")]
	event PADECADCPBE KLHGFHNHGEH;

	[Cpp2IlInjected.Token(Token = "0x6000125")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void BCJIBCPCLJO();

	[Cpp2IlInjected.Token(Token = "0x6000126")]
	[Cpp2IlInjected.Address(Slot = "3")]
	bool FGICBOJAMPD();

	[Cpp2IlInjected.Token(Token = "0x6000127")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void PGPCJECNCAA();

	[Cpp2IlInjected.Token(Token = "0x6000128")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void PHFOJALJMOJ();

	[Cpp2IlInjected.Token(Token = "0x6000129")]
	[Cpp2IlInjected.Address(Slot = "6")]
	void KAJPAKHEONK();

	[Cpp2IlInjected.Token(Token = "0x600012A")]
	[Cpp2IlInjected.Address(Slot = "7")]
	void FCLCNJHCFEK();
}
[Cpp2IlInjected.Token(Token = "0x2000018")]
public interface ACOGMOKAGMB
{
	[Cpp2IlInjected.Token(Token = "0x1700004D")]
	Rigidbody CKFDKNLJFBH
	{
		[Cpp2IlInjected.Token(Token = "0x600012B")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700004E")]
	bool JAOOJFDIBIH
	{
		[Cpp2IlInjected.Token(Token = "0x600012D")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x600012C")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void BCJIBCPCLJO();

	[Cpp2IlInjected.Token(Token = "0x600012E")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void ILHOGPAMLOI(object GBENACPKFNA);

	[Cpp2IlInjected.Token(Token = "0x600012F")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void DFNPFAMILKL(object GBENACPKFNA);

	[Cpp2IlInjected.Token(Token = "0x6000130")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void NCBMDPJNOND();
}
[Cpp2IlInjected.Token(Token = "0x2000019")]
public interface PKGFJJHHDNP : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x1700004F")]
	INHEMIHIBFP DFIDBGCEBII
	{
		[Cpp2IlInjected.Token(Token = "0x6000131")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
		[Cpp2IlInjected.Token(Token = "0x6000132")]
		[Cpp2IlInjected.Address(Slot = "1")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000050")]
	EDACBNCGKFK LIODHEOELNH
	{
		[Cpp2IlInjected.Token(Token = "0x6000133")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
		[Cpp2IlInjected.Token(Token = "0x6000134")]
		[Cpp2IlInjected.Address(Slot = "3")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000051")]
	Vector3 CDMANJEHLKL
	{
		[Cpp2IlInjected.Token(Token = "0x6000135")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
		[Cpp2IlInjected.Token(Token = "0x6000136")]
		[Cpp2IlInjected.Address(Slot = "5")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000052")]
	Vector3 JPMEJPLLBEO
	{
		[Cpp2IlInjected.Token(Token = "0x6000137")]
		[Cpp2IlInjected.Address(Slot = "6")]
		get;
		[Cpp2IlInjected.Token(Token = "0x6000138")]
		[Cpp2IlInjected.Address(Slot = "7")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000053")]
	Vector3 JEAEJDIOEML
	{
		[Cpp2IlInjected.Token(Token = "0x6000139")]
		[Cpp2IlInjected.Address(Slot = "8")]
		get;
		[Cpp2IlInjected.Token(Token = "0x600013A")]
		[Cpp2IlInjected.Address(Slot = "9")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000054")]
	Vector3 FDBDBELGLPB
	{
		[Cpp2IlInjected.Token(Token = "0x600013B")]
		[Cpp2IlInjected.Address(Slot = "10")]
		get;
		[Cpp2IlInjected.Token(Token = "0x600013C")]
		[Cpp2IlInjected.Address(Slot = "11")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000055")]
	float MOPMJLHOCCI
	{
		[Cpp2IlInjected.Token(Token = "0x600013D")]
		[Cpp2IlInjected.Address(Slot = "12")]
		get;
		[Cpp2IlInjected.Token(Token = "0x600013E")]
		[Cpp2IlInjected.Address(Slot = "13")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000056")]
	bool GHBJLIODJHF
	{
		[Cpp2IlInjected.Token(Token = "0x600013F")]
		[Cpp2IlInjected.Address(Slot = "14")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000140")]
	[Cpp2IlInjected.Address(Slot = "15")]
	void BCJIBCPCLJO();

	[Cpp2IlInjected.Token(Token = "0x6000141")]
	[Cpp2IlInjected.Address(Slot = "16")]
	void EMIJCINLNHK(object GBENACPKFNA);

	[Cpp2IlInjected.Token(Token = "0x6000142")]
	[Cpp2IlInjected.Address(Slot = "17")]
	void PPAAECDKFNC(OKFMPDPEOKJ HHBPGGPPJEP, Vector3 BGIPBKEALAM, float FDECAJPPJOA = float.PositiveInfinity);

	[Cpp2IlInjected.Token(Token = "0x6000143")]
	[Cpp2IlInjected.Address(Slot = "18")]
	void DPKPHGABCLN(JDPIALONKJP JIPJBNBKBLG, Vector3 NKHOFGAANEK, float EDHDLGGJOCE, float PKDMCAHEPPF = 8f, float FFHCMFMNDIM = 1f);

	[Cpp2IlInjected.Token(Token = "0x6000144")]
	[Cpp2IlInjected.Address(Slot = "19")]
	void ABEANEABNLI(OKFMPDPEOKJ HHBPGGPPJEP, Vector3 GPEICHFGELO, float HLFLCONGPIA = 7f, float EKICCDEOMKG = 1f);

	[Cpp2IlInjected.Token(Token = "0x6000145")]
	[Cpp2IlInjected.Address(Slot = "20")]
	void MLHLKKDAIEE();

	[Cpp2IlInjected.Token(Token = "0x6000146")]
	[Cpp2IlInjected.Address(Slot = "21")]
	void AJABIOHJCJL();

	[Cpp2IlInjected.Token(Token = "0x6000147")]
	[Cpp2IlInjected.Address(Slot = "22")]
	void NMMBIONOOKB();

	[Cpp2IlInjected.Token(Token = "0x6000148")]
	[Cpp2IlInjected.Address(Slot = "23")]
	void GBOMHIENMBH();

	[Cpp2IlInjected.Token(Token = "0x6000149")]
	[Cpp2IlInjected.Address(Slot = "24")]
	void PMJCKMMFMFM(Rigidbody JJDGGMNFHIL);

	[Cpp2IlInjected.Token(Token = "0x600014A")]
	[Cpp2IlInjected.Address(Slot = "25")]
	Vector3 HEHLNGGHFJC(Vector3 IFAKEJMGKPK);

	[Cpp2IlInjected.Token(Token = "0x600014B")]
	[Cpp2IlInjected.Address(Slot = "26")]
	void JOJHBDPLGHL(object GBENACPKFNA);

	[Cpp2IlInjected.Token(Token = "0x600014C")]
	[Cpp2IlInjected.Address(Slot = "27")]
	void NBOHEJKAJEC(Vector3 MFMBALHFABC);

	[Cpp2IlInjected.Token(Token = "0x600014D")]
	[Cpp2IlInjected.Address(Slot = "28")]
	void FEIELGKMBHN(Vector3 PAHGAPJJGCH, Vector3 EGODONBGLKF);

	[Cpp2IlInjected.Token(Token = "0x600014E")]
	[Cpp2IlInjected.Address(Slot = "29")]
	void HMNHDGDMDAE(Vector3 AJDEPJADDIH, Vector3 MAEPOHBIICK);

	[Cpp2IlInjected.Token(Token = "0x600014F")]
	[Cpp2IlInjected.Address(Slot = "30")]
	Vector3 BOLPKKOBOEM(Vector3 AANPGIPGGCD);

	[Cpp2IlInjected.Token(Token = "0x6000150")]
	[Cpp2IlInjected.Address(Slot = "31")]
	Vector3 PHAPDKMGHBI(Vector3 HPLCNCFNOCB);
}
[Cpp2IlInjected.Token(Token = "0x200001A")]
[KHCGLFKHKLK(MNBOKCFMODA.Application)]
public interface BMCNAFPJCOL
{
	[Cpp2IlInjected.Token(Token = "0x17000057")]
	bool FPBMIGABMNN
	{
		[Cpp2IlInjected.Token(Token = "0x6000151")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000152")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void EGBKMDEHMNA(string JMMBJIBOIFP);

	[Cpp2IlInjected.Token(Token = "0x6000153")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void BJIPPFCGOEL(RigidbodyEx JMMPGPEMBEI, Action OBNFAOABLKL);

	[Cpp2IlInjected.Token(Token = "0x6000154")]
	[Cpp2IlInjected.Address(Slot = "3")]
	MLOEMGPHEAG DJPDJCKMNEH(int PKNACEJBJKI);

	[Cpp2IlInjected.Token(Token = "0x6000155")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void NLODCJLDJLA(Vector3 MLBOIPOGHLG, float LECHDNLBDJM, Color NMMFNOOBBFO);
}
[Cpp2IlInjected.Token(Token = "0x200001B")]
[KHCGLFKHKLK(MNBOKCFMODA.Application)]
public interface NPICBIONHHC
{
	[Cpp2IlInjected.Token(Token = "0x17000058")]
	BMCNAFPJCOL PMNBJNPINMP
	{
		[Cpp2IlInjected.Token(Token = "0x6000156")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000059")]
	FJIMMJIOKCJ NKLBMKHAGBK
	{
		[Cpp2IlInjected.Token(Token = "0x6000157")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000158")]
	[Cpp2IlInjected.Address(Slot = "2")]
	EGNFIBKBHKP GDNNBJHAMFI(RigidbodyEx JMMPGPEMBEI, CCGIPMCDDGA JGFKFMMOAJO);
}
[Cpp2IlInjected.Token(Token = "0x200001C")]
public class MDHDELBPMHJ : EGNFIBKBHKP, IDisposable, KLGOMKEBKDC
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000017")]
	internal readonly NPICBIONHHC DMMHPLIIKDJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000018")]
	internal LFBFGPDKIHF DHCLBOOHAIF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000019")]
	internal CJNOICOENPF OLIKPDKAIED;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400001A")]
	internal IPKAFMFLAHB JKGKEFMMNGK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400001B")]
	internal PKGFJJHHDNP IFAKEJMGKPK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x400001C")]
	internal CKOKBJLNIGM HKPLHHIIHLG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x400001D")]
	internal ADDPLOFLCBC EMIAJGBBIFN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x400001E")]
	internal OFABJBGMCEJ FPGOANGGLLG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x400001F")]
	internal EOFGEIBMJGB BFILHPCLIIN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x4000020")]
	internal OOPCMGEAGDH EKNCCJAPDIE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x4000021")]
	internal CCCKAHDOEDH NMHEKMBCFOB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x4000022")]
	internal BFAJBPGIDNL PHIMILLLBME;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x4000023")]
	internal AIIECHHMHKF FPPHGAIAECP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
	[Cpp2IlInjected.Token(Token = "0x4000024")]
	internal IDNMICNIEEM BMKFEODJAPG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x4000025")]
	internal ACOGMOKAGMB JJDGGMNFHIL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
	[Cpp2IlInjected.Token(Token = "0x4000026")]
	internal FDBIKGBKFEF NKGBBAHJFMI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
	[Cpp2IlInjected.Token(Token = "0x4000027")]
	internal IDisposable DCHLFJBIMGJ;

	[Cpp2IlInjected.Token(Token = "0x1700005A")]
	public PEAFMKHEGLL IJOLNEBJNPG
	{
		[Cpp2IlInjected.Token(Token = "0x6000159")]
		[Cpp2IlInjected.Address(RVA = "0x866B30", Offset = "0x865730", VA = "0x180866B30", Slot = "22")]
		get
		{
			return default(PEAFMKHEGLL);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700005B")]
	public NIJCOMOFOFB HOOMNGJJCBJ
	{
		[Cpp2IlInjected.Token(Token = "0x600015A")]
		[Cpp2IlInjected.Address(RVA = "0x872380", Offset = "0x870F80", VA = "0x180872380", Slot = "24")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600015B")]
		[Cpp2IlInjected.Address(RVA = "0x8724D0", Offset = "0x8710D0", VA = "0x1808724D0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700005C")]
	public GameObject CPHJNMFHAIB
	{
		[Cpp2IlInjected.Token(Token = "0x600015C")]
		[Cpp2IlInjected.Address(RVA = "0x9F9A50", Offset = "0x9F8650", VA = "0x1809F9A50", Slot = "25")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600015D")]
		[Cpp2IlInjected.Address(RVA = "0x9D84C0", Offset = "0x9D70C0", VA = "0x1809D84C0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700005D")]
	public Transform LHELEJKIFMG
	{
		[Cpp2IlInjected.Token(Token = "0x600015E")]
		[Cpp2IlInjected.Address(RVA = "0x7023170", Offset = "0x7021D70", VA = "0x187023170", Slot = "26")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700005E")]
	public Rigidbody CKFDKNLJFBH
	{
		[Cpp2IlInjected.Token(Token = "0x600015F")]
		[Cpp2IlInjected.Address(RVA = "0x7028A90", Offset = "0x7027690", VA = "0x187028A90", Slot = "23")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700005F")]
	public EGNFIBKBHKP BBKNDFHDFHL
	{
		[Cpp2IlInjected.Token(Token = "0x600016D")]
		[Cpp2IlInjected.Address(RVA = "0x7029050", Offset = "0x7027C50", VA = "0x187029050", Slot = "27")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600016E")]
		[Cpp2IlInjected.Address(RVA = "0x70233E0", Offset = "0x7021FE0", VA = "0x1870233E0", Slot = "28")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000060")]
	public int FOOFFHHPMDI
	{
		[Cpp2IlInjected.Token(Token = "0x600016F")]
		[Cpp2IlInjected.Address(RVA = "0x7023570", Offset = "0x7022170", VA = "0x187023570", Slot = "31")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000061")]
	public EGNFIBKBHKP LIOIAHEPIFM
	{
		[Cpp2IlInjected.Token(Token = "0x6000171")]
		[Cpp2IlInjected.Address(RVA = "0x7025560", Offset = "0x7024160", VA = "0x187025560", Slot = "29")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000062")]
	public bool IGBHMJICOCE
	{
		[Cpp2IlInjected.Token(Token = "0x6000172")]
		[Cpp2IlInjected.Address(RVA = "0x7023CA0", Offset = "0x70228A0", VA = "0x187023CA0", Slot = "138")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000063")]
	public bool OCAHNLHHELK
	{
		[Cpp2IlInjected.Token(Token = "0x6000176")]
		[Cpp2IlInjected.Address(RVA = "0x7028B50", Offset = "0x7027750", VA = "0x187028B50", Slot = "32")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000064")]
	public bool EEPDKLKKOLN
	{
		[Cpp2IlInjected.Token(Token = "0x6000177")]
		[Cpp2IlInjected.Address(RVA = "0x7026F40", Offset = "0x7025B40", VA = "0x187026F40", Slot = "33")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000065")]
	public INHEMIHIBFP DFIDBGCEBII
	{
		[Cpp2IlInjected.Token(Token = "0x6000178")]
		[Cpp2IlInjected.Address(RVA = "0x70253D0", Offset = "0x7023FD0", VA = "0x1870253D0", Slot = "34")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000179")]
		[Cpp2IlInjected.Address(RVA = "0x7023C40", Offset = "0x7022840", VA = "0x187023C40", Slot = "35")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000066")]
	public EDACBNCGKFK LIODHEOELNH
	{
		[Cpp2IlInjected.Token(Token = "0x600017A")]
		[Cpp2IlInjected.Address(RVA = "0x7025380", Offset = "0x7023F80", VA = "0x187025380", Slot = "36")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600017B")]
		[Cpp2IlInjected.Address(RVA = "0x7025F80", Offset = "0x7024B80", VA = "0x187025F80", Slot = "37")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000067")]
	public float MOPMJLHOCCI
	{
		[Cpp2IlInjected.Token(Token = "0x600017C")]
		[Cpp2IlInjected.Address(RVA = "0x70251A0", Offset = "0x7023DA0", VA = "0x1870251A0", Slot = "38")]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x600017D")]
		[Cpp2IlInjected.Address(RVA = "0x7023D80", Offset = "0x7022980", VA = "0x187023D80", Slot = "39")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000068")]
	public Vector3 JPMEJPLLBEO
	{
		[Cpp2IlInjected.Token(Token = "0x600017E")]
		[Cpp2IlInjected.Address(RVA = "0x70276B0", Offset = "0x70262B0", VA = "0x1870276B0", Slot = "40")]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x600017F")]
		[Cpp2IlInjected.Address(RVA = "0x7024B80", Offset = "0x7023780", VA = "0x187024B80", Slot = "41")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000069")]
	public Vector3 FDBDBELGLPB
	{
		[Cpp2IlInjected.Token(Token = "0x6000180")]
		[Cpp2IlInjected.Address(RVA = "0x7026C90", Offset = "0x7025890", VA = "0x187026C90", Slot = "42")]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x6000181")]
		[Cpp2IlInjected.Address(RVA = "0x7025D80", Offset = "0x7024980", VA = "0x187025D80", Slot = "43")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700006A")]
	public Vector3 CDMANJEHLKL
	{
		[Cpp2IlInjected.Token(Token = "0x6000182")]
		[Cpp2IlInjected.Address(RVA = "0x70270E0", Offset = "0x7025CE0", VA = "0x1870270E0", Slot = "44")]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x6000183")]
		[Cpp2IlInjected.Address(RVA = "0x7023DE0", Offset = "0x70229E0", VA = "0x187023DE0", Slot = "45")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700006B")]
	public Vector3 JEAEJDIOEML
	{
		[Cpp2IlInjected.Token(Token = "0x6000184")]
		[Cpp2IlInjected.Address(RVA = "0x7026BB0", Offset = "0x70257B0", VA = "0x187026BB0", Slot = "46")]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x6000185")]
		[Cpp2IlInjected.Address(RVA = "0x7025250", Offset = "0x7023E50", VA = "0x187025250", Slot = "47")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700006C")]
	public bool DPBKMEPJJFG
	{
		[Cpp2IlInjected.Token(Token = "0x6000186")]
		[Cpp2IlInjected.Address(RVA = "0x7027610", Offset = "0x7026210", VA = "0x187027610", Slot = "139")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700006D")]
	public bool GILGEOCHDBD
	{
		[Cpp2IlInjected.Token(Token = "0x6000187")]
		[Cpp2IlInjected.Address(RVA = "0x7027550", Offset = "0x7026150", VA = "0x187027550", Slot = "48")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700006E")]
	public bool MLLHNOBJLDC
	{
		[Cpp2IlInjected.Token(Token = "0x6000188")]
		[Cpp2IlInjected.Address(RVA = "0x7024E90", Offset = "0x7023A90", VA = "0x187024E90", Slot = "49")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700006F")]
	public bool GHBJLIODJHF
	{
		[Cpp2IlInjected.Token(Token = "0x6000189")]
		[Cpp2IlInjected.Address(RVA = "0x70257B0", Offset = "0x70243B0", VA = "0x1870257B0", Slot = "50")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000070")]
	public Vector3 KHKHPEILLBD
	{
		[Cpp2IlInjected.Token(Token = "0x600019A")]
		[Cpp2IlInjected.Address(RVA = "0x7025FE0", Offset = "0x7024BE0", VA = "0x187025FE0", Slot = "51")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000071")]
	public Vector3 BPONHOGLMCE
	{
		[Cpp2IlInjected.Token(Token = "0x600019B")]
		[Cpp2IlInjected.Address(RVA = "0x7023800", Offset = "0x7022400", VA = "0x187023800", Slot = "52")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000072")]
	public Vector3 LMNBHBJAJFM
	{
		[Cpp2IlInjected.Token(Token = "0x60001A0")]
		[Cpp2IlInjected.Address(RVA = "0x7024D50", Offset = "0x7023950", VA = "0x187024D50", Slot = "53")]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x60001A1")]
		[Cpp2IlInjected.Address(RVA = "0x7025010", Offset = "0x7023C10", VA = "0x187025010", Slot = "54")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000073")]
	public Vector3 HAIHKHGGPPP
	{
		[Cpp2IlInjected.Token(Token = "0x60001A2")]
		[Cpp2IlInjected.Address(RVA = "0x7026100", Offset = "0x7024D00", VA = "0x187026100", Slot = "55")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000074")]
	public float ECJECJPONJA
	{
		[Cpp2IlInjected.Token(Token = "0x60001A3")]
		[Cpp2IlInjected.Address(RVA = "0x7027090", Offset = "0x7025C90", VA = "0x187027090", Slot = "56")]
		get
		{
			return default(float);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000075")]
	public float GOBLNFAJJOD
	{
		[Cpp2IlInjected.Token(Token = "0x60001A4")]
		[Cpp2IlInjected.Address(RVA = "0x7026DD0", Offset = "0x70259D0", VA = "0x187026DD0", Slot = "57")]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x60001A5")]
		[Cpp2IlInjected.Address(RVA = "0x7025D20", Offset = "0x7024920", VA = "0x187025D20", Slot = "58")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000076")]
	public Vector3 PNJPKBMKLJM
	{
		[Cpp2IlInjected.Token(Token = "0x60001A6")]
		[Cpp2IlInjected.Address(RVA = "0x70255B0", Offset = "0x70241B0", VA = "0x1870255B0", Slot = "59")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000077")]
	public Quaternion NEDIJPEDJGG
	{
		[Cpp2IlInjected.Token(Token = "0x60001A7")]
		[Cpp2IlInjected.Address(RVA = "0x7027280", Offset = "0x7025E80", VA = "0x187027280", Slot = "60")]
		get
		{
			return default(Quaternion);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000078")]
	public float EEJCJOIJJON
	{
		[Cpp2IlInjected.Token(Token = "0x60001AC")]
		[Cpp2IlInjected.Address(RVA = "0x7023BF0", Offset = "0x70227F0", VA = "0x187023BF0", Slot = "62")]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x60001AD")]
		[Cpp2IlInjected.Address(RVA = "0x7024840", Offset = "0x7023440", VA = "0x187024840", Slot = "63")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000079")]
	public float HHODGMIMJEL
	{
		[Cpp2IlInjected.Token(Token = "0x60001AE")]
		[Cpp2IlInjected.Address(RVA = "0x7025330", Offset = "0x7023F30", VA = "0x187025330", Slot = "64")]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x60001AF")]
		[Cpp2IlInjected.Address(RVA = "0x7023EC0", Offset = "0x7022AC0", VA = "0x187023EC0", Slot = "65")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700007A")]
	public bool FPHBHOGHBMJ
	{
		[Cpp2IlInjected.Token(Token = "0x60001B0")]
		[Cpp2IlInjected.Address(RVA = "0x7027790", Offset = "0x7026390", VA = "0x187027790", Slot = "66")]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x60001B1")]
		[Cpp2IlInjected.Address(RVA = "0x7026D70", Offset = "0x7025970", VA = "0x187026D70", Slot = "67")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700007B")]
	public LHFCBMFLLBG FFPPBFFPFKN
	{
		[Cpp2IlInjected.Token(Token = "0x60001B9")]
		[Cpp2IlInjected.Address(RVA = "0x70260B0", Offset = "0x7024CB0", VA = "0x1870260B0", Slot = "68")]
		get
		{
			return default(LHFCBMFLLBG);
		}
		[Cpp2IlInjected.Token(Token = "0x60001BA")]
		[Cpp2IlInjected.Address(RVA = "0x7023D00", Offset = "0x7022900", VA = "0x187023D00", Slot = "69")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700007C")]
	public bool PHMLJIAJDCC
	{
		[Cpp2IlInjected.Token(Token = "0x60001BD")]
		[Cpp2IlInjected.Address(RVA = "0x7027500", Offset = "0x7026100", VA = "0x187027500", Slot = "70")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700007D")]
	public Transform JBNNMFNNNAO
	{
		[Cpp2IlInjected.Token(Token = "0x60001C3")]
		[Cpp2IlInjected.Address(RVA = "0x7028AE0", Offset = "0x70276E0", VA = "0x187028AE0", Slot = "71")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700007E")]
	public Vector3 HOGGFEAJLCE
	{
		[Cpp2IlInjected.Token(Token = "0x60001C4")]
		[Cpp2IlInjected.Address(RVA = "0x70285F0", Offset = "0x70271F0", VA = "0x1870285F0", Slot = "72")]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x60001C5")]
		[Cpp2IlInjected.Address(RVA = "0x7025800", Offset = "0x7024400", VA = "0x187025800", Slot = "73")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700007F")]
	public float GPJBNIKGDMP
	{
		[Cpp2IlInjected.Token(Token = "0x60001C6")]
		[Cpp2IlInjected.Address(RVA = "0x7023D60", Offset = "0x7022960", VA = "0x187023D60", Slot = "74")]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x60001C7")]
		[Cpp2IlInjected.Address(RVA = "0x7023310", Offset = "0x7021F10", VA = "0x187023310", Slot = "75")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000080")]
	public float MMGMJPBKMDK
	{
		[Cpp2IlInjected.Token(Token = "0x60001C8")]
		[Cpp2IlInjected.Address(RVA = "0x7028E60", Offset = "0x7027A60", VA = "0x187028E60", Slot = "76")]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x60001C9")]
		[Cpp2IlInjected.Address(RVA = "0x70256B0", Offset = "0x70242B0", VA = "0x1870256B0", Slot = "77")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000081")]
	public Quaternion ODHCJDCMGHC
	{
		[Cpp2IlInjected.Token(Token = "0x60001CA")]
		[Cpp2IlInjected.Address(RVA = "0x70264D0", Offset = "0x70250D0", VA = "0x1870264D0", Slot = "78")]
		get
		{
			return default(Quaternion);
		}
		[Cpp2IlInjected.Token(Token = "0x60001CB")]
		[Cpp2IlInjected.Address(RVA = "0x7027B80", Offset = "0x7026780", VA = "0x187027B80", Slot = "79")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000082")]
	public Vector3 BOKOHHFILBG
	{
		[Cpp2IlInjected.Token(Token = "0x60001CC")]
		[Cpp2IlInjected.Address(RVA = "0x7023520", Offset = "0x7022120", VA = "0x187023520", Slot = "80")]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x60001CD")]
		[Cpp2IlInjected.Address(RVA = "0x7026420", Offset = "0x7025020", VA = "0x187026420", Slot = "81")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000083")]
	public Quaternion CKGMEBIHNIC
	{
		[Cpp2IlInjected.Token(Token = "0x60001CE")]
		[Cpp2IlInjected.Address(RVA = "0x70290A0", Offset = "0x7027CA0", VA = "0x1870290A0", Slot = "82")]
		get
		{
			return default(Quaternion);
		}
		[Cpp2IlInjected.Token(Token = "0x60001CF")]
		[Cpp2IlInjected.Address(RVA = "0x7027F90", Offset = "0x7026B90", VA = "0x187027F90", Slot = "83")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000084")]
	public RigidbodyConstraints LAFPPCHIKBM
	{
		[Cpp2IlInjected.Token(Token = "0x60001D3")]
		[Cpp2IlInjected.Address(RVA = "0x7024AE0", Offset = "0x70236E0", VA = "0x187024AE0", Slot = "84")]
		get
		{
			return default(RigidbodyConstraints);
		}
		[Cpp2IlInjected.Token(Token = "0x60001D4")]
		[Cpp2IlInjected.Address(RVA = "0x7026470", Offset = "0x7025070", VA = "0x187026470", Slot = "85")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000085")]
	public bool FAFDAGIIDHL
	{
		[Cpp2IlInjected.Token(Token = "0x60001D5")]
		[Cpp2IlInjected.Address(RVA = "0x7028150", Offset = "0x7026D50", VA = "0x187028150", Slot = "86")]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x60001D6")]
		[Cpp2IlInjected.Address(RVA = "0x7027350", Offset = "0x7025F50", VA = "0x187027350", Slot = "87")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000086")]
	public CollisionDetectionMode CJKJNHCCBNE
	{
		[Cpp2IlInjected.Token(Token = "0x60001DF")]
		[Cpp2IlInjected.Address(RVA = "0x7026580", Offset = "0x7025180", VA = "0x187026580", Slot = "88")]
		get
		{
			return default(CollisionDetectionMode);
		}
		[Cpp2IlInjected.Token(Token = "0x60001E0")]
		[Cpp2IlInjected.Address(RVA = "0x7027A70", Offset = "0x7026670", VA = "0x187027A70", Slot = "89")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000087")]
	public bool KBCHKLPJOIB
	{
		[Cpp2IlInjected.Token(Token = "0x60001E2")]
		[Cpp2IlInjected.Address(RVA = "0x7025420", Offset = "0x7024020", VA = "0x187025420", Slot = "140")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000088")]
	public bool LAPFFGJNIKK
	{
		[Cpp2IlInjected.Token(Token = "0x60001E3")]
		[Cpp2IlInjected.Address(RVA = "0x7024900", Offset = "0x7023500", VA = "0x187024900", Slot = "90")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000017")]
	public event PADECADCPBE CFHLFFFLALO
	{
		[Cpp2IlInjected.Token(Token = "0x6000167")]
		[Cpp2IlInjected.Address(RVA = "0x7023380", Offset = "0x7021F80", VA = "0x187023380", Slot = "4")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000168")]
		[Cpp2IlInjected.Address(RVA = "0x70286A0", Offset = "0x70272A0", VA = "0x1870286A0", Slot = "5")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000018")]
	public event PADECADCPBE PDHLFFDEEJB
	{
		[Cpp2IlInjected.Token(Token = "0x6000169")]
		[Cpp2IlInjected.Address(RVA = "0x70275B0", Offset = "0x70261B0", VA = "0x1870275B0", Slot = "6")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600016A")]
		[Cpp2IlInjected.Address(RVA = "0x70251F0", Offset = "0x7023DF0", VA = "0x1870251F0", Slot = "7")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000019")]
	public event PNHJLHINCOF IGAOMNPMGGA
	{
		[Cpp2IlInjected.Token(Token = "0x600016B")]
		[Cpp2IlInjected.Address(RVA = "0x7028E80", Offset = "0x7027A80", VA = "0x187028E80", Slot = "18")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600016C")]
		[Cpp2IlInjected.Address(RVA = "0x7026E20", Offset = "0x7025A20", VA = "0x187026E20", Slot = "19")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400001A")]
	public event PADECADCPBE JPIIIJEFFCH
	{
		[Cpp2IlInjected.Token(Token = "0x6000174")]
		[Cpp2IlInjected.Address(RVA = "0x7026EE0", Offset = "0x7025AE0", VA = "0x187026EE0", Slot = "8")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000175")]
		[Cpp2IlInjected.Address(RVA = "0x7023B90", Offset = "0x7022790", VA = "0x187023B90", Slot = "9")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400001B")]
	public event PADECADCPBE EKMLDGKMBHD
	{
		[Cpp2IlInjected.Token(Token = "0x600019E")]
		[Cpp2IlInjected.Address(RVA = "0x7027AD0", Offset = "0x70266D0", VA = "0x187027AD0", Slot = "14")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600019F")]
		[Cpp2IlInjected.Address(RVA = "0x7024E30", Offset = "0x7023A30", VA = "0x187024E30", Slot = "15")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400001C")]
	public event PADECADCPBE KLHGFHNHGEH
	{
		[Cpp2IlInjected.Token(Token = "0x60001B2")]
		[Cpp2IlInjected.Address(RVA = "0x7026290", Offset = "0x7024E90", VA = "0x187026290", Slot = "16")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60001B3")]
		[Cpp2IlInjected.Address(RVA = "0x7025EC0", Offset = "0x7024AC0", VA = "0x187025EC0", Slot = "17")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400001D")]
	public event Action<IABFIAOBIIB, IABFIAOBIIB> HNJNIGNEAPH
	{
		[Cpp2IlInjected.Token(Token = "0x60001B7")]
		[Cpp2IlInjected.Address(RVA = "0x7023260", Offset = "0x7021E60", VA = "0x187023260", Slot = "20")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60001B8")]
		[Cpp2IlInjected.Address(RVA = "0x7028220", Offset = "0x7026E20", VA = "0x187028220", Slot = "21")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400001E")]
	public event PADECADCPBE JPCEHDELPPJ
	{
		[Cpp2IlInjected.Token(Token = "0x60001BB")]
		[Cpp2IlInjected.Address(RVA = "0x70259C0", Offset = "0x70245C0", VA = "0x1870259C0", Slot = "12")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60001BC")]
		[Cpp2IlInjected.Address(RVA = "0x70278C0", Offset = "0x70264C0", VA = "0x1870278C0", Slot = "13")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400001F")]
	public event PADECADCPBE MBJBDJEOMPC
	{
		[Cpp2IlInjected.Token(Token = "0x60001C1")]
		[Cpp2IlInjected.Address(RVA = "0x70269E0", Offset = "0x70255E0", VA = "0x1870269E0", Slot = "10")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60001C2")]
		[Cpp2IlInjected.Address(RVA = "0x70250F0", Offset = "0x7023CF0", VA = "0x1870250F0", Slot = "11")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000160")]
	[Cpp2IlInjected.Address(RVA = "0x7029120", Offset = "0x7027D20", VA = "0x187029120")]
	public MDHDELBPMHJ(GameObject OJCNPGOLEHK, RigidbodyEx FGNCGFIJIHK, NPICBIONHHC DMMHPLIIKDJ, [In] CCGIPMCDDGA JGFKFMMOAJO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000161")]
	[Cpp2IlInjected.Address(RVA = "0x7024160", Offset = "0x7022D60", VA = "0x187024160", Slot = "136")]
	protected virtual void DLMDBONJLEO(NPICBIONHHC DMMHPLIIKDJ, CCGIPMCDDGA JGFKFMMOAJO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000162")]
	[Cpp2IlInjected.Address(RVA = "0x70246F0", Offset = "0x70232F0", VA = "0x1870246F0", Slot = "137")]
	public virtual void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000163")]
	[Cpp2IlInjected.Address(RVA = "0x70236C0", Offset = "0x70222C0", VA = "0x1870236C0", Slot = "91")]
	public void BCJIBCPCLJO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000164")]
	[Cpp2IlInjected.Address(RVA = "0x70238E0", Offset = "0x70224E0", VA = "0x1870238E0", Slot = "92")]
	public void BNHPIAHLGPC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000165")]
	[Cpp2IlInjected.Address(RVA = "0x7025690", Offset = "0x7024290", VA = "0x187025690", Slot = "93")]
	public void GJIAHAHPEPP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000166")]
	[Cpp2IlInjected.Address(RVA = "0x70281A0", Offset = "0x7026DA0", VA = "0x1870281A0")]
	private void ODKIHACCDAD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000170")]
	[Cpp2IlInjected.Address(RVA = "0x70247C0", Offset = "0x70233C0", VA = "0x1870247C0", Slot = "30")]
	public EGNFIBKBHKP EBNFKEFJACB(int BAEBMIBABAE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000173")]
	[Cpp2IlInjected.Address(RVA = "0x7028EE0", Offset = "0x7027AE0", VA = "0x187028EE0", Slot = "95")]
	public void PNCCPJNBDLO(EGNFIBKBHKP IIPLJLPCLBC, bool NOFJHFMCCCG = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600018A")]
	[Cpp2IlInjected.Address(RVA = "0x7026980", Offset = "0x7025580", VA = "0x187026980", Slot = "96")]
	public void KDAPIPLKMJC(object GBENACPKFNA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600018B")]
	[Cpp2IlInjected.Address(RVA = "0x7025E60", Offset = "0x7024A60", VA = "0x187025E60", Slot = "97")]
	public void IHCDJFFHDDG(object GBENACPKFNA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600018C")]
	[Cpp2IlInjected.Address(RVA = "0x7028BA0", Offset = "0x70277A0", VA = "0x187028BA0", Slot = "98")]
	public Vector3 PHAPDKMGHBI(Vector3 HPLCNCFNOCB)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x600018D")]
	[Cpp2IlInjected.Address(RVA = "0x7023A90", Offset = "0x7022690", VA = "0x187023A90", Slot = "99")]
	public Vector3 BOLPKKOBOEM(Vector3 AANPGIPGGCD)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x600018E")]
	[Cpp2IlInjected.Address(RVA = "0x70238E0", Offset = "0x70224E0", VA = "0x1870238E0", Slot = "100")]
	public void GBOMHIENMBH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600018F")]
	[Cpp2IlInjected.Address(RVA = "0x70232C0", Offset = "0x7021EC0", VA = "0x1870232C0", Slot = "101")]
	public void AJABIOHJCJL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000190")]
	[Cpp2IlInjected.Address(RVA = "0x7027660", Offset = "0x7026260", VA = "0x187027660", Slot = "102")]
	public void MLHLKKDAIEE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000191")]
	[Cpp2IlInjected.Address(RVA = "0x7025A20", Offset = "0x7024620", VA = "0x187025A20", Slot = "103")]
	public void HMNHDGDMDAE(Vector3 AJDEPJADDIH, Vector3 MAEPOHBIICK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000192")]
	[Cpp2IlInjected.Address(RVA = "0x7024C60", Offset = "0x7023860", VA = "0x187024C60", Slot = "104")]
	public void FEIELGKMBHN(Vector3 PAHGAPJJGCH, Vector3 EGODONBGLKF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000193")]
	[Cpp2IlInjected.Address(RVA = "0x70277E0", Offset = "0x70263E0", VA = "0x1870277E0", Slot = "105")]
	public void NBOHEJKAJEC(Vector3 MFMBALHFABC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000194")]
	[Cpp2IlInjected.Address(RVA = "0x7024630", Offset = "0x7023230", VA = "0x187024630", Slot = "106")]
	public void DPKPHGABCLN(JDPIALONKJP JIPJBNBKBLG, Vector3 NKHOFGAANEK, float EDHDLGGJOCE, float PKDMCAHEPPF = 8f, float FFHCMFMNDIM = 1f)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000195")]
	[Cpp2IlInjected.Address(RVA = "0x7028F50", Offset = "0x7027B50", VA = "0x187028F50", Slot = "107")]
	public void PPAAECDKFNC(OKFMPDPEOKJ HHBPGGPPJEP, Vector3 BGIPBKEALAM, float FDECAJPPJOA = float.PositiveInfinity)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000196")]
	[Cpp2IlInjected.Address(RVA = "0x7023060", Offset = "0x7021C60", VA = "0x187023060", Slot = "108")]
	[Obsolete("Deprecated. Still exists to support deprecated CV2 chips. Use ApplyAngularVelocityChange.")]
	public void ABEANEABNLI(OKFMPDPEOKJ HHBPGGPPJEP, Vector3 GPEICHFGELO, float HLFLCONGPIA = 7f, float EKICCDEOMKG = 1f)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000197")]
	[Cpp2IlInjected.Address(RVA = "0x70258C0", Offset = "0x70244C0", VA = "0x1870258C0", Slot = "109")]
	public Vector3 HEHLNGGHFJC(Vector3 IIPLJLPCLBC)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000198")]
	[Cpp2IlInjected.Address(RVA = "0x7024060", Offset = "0x7022C60", VA = "0x187024060", Slot = "110")]
	public Vector3 DKLGFMNBFPD(Vector3 IIPLJLPCLBC)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000199")]
	[Cpp2IlInjected.Address(RVA = "0x7027B30", Offset = "0x7026730", VA = "0x187027B30", Slot = "111")]
	public void NMMBIONOOKB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600019C")]
	[Cpp2IlInjected.Address(RVA = "0x7027A00", Offset = "0x7026600", VA = "0x187027A00", Slot = "112")]
	public void NKBLFOLFIMI(EGNFIBKBHKP OBNADBOMLBC, object GBENACPKFNA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600019D")]
	[Cpp2IlInjected.Address(RVA = "0x70263C0", Offset = "0x7024FC0", VA = "0x1870263C0", Slot = "113")]
	public void JOLHGJNGMAO(object GBENACPKFNA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001A8")]
	[Cpp2IlInjected.Address(RVA = "0x7023F80", Offset = "0x7022B80", VA = "0x187023F80", Slot = "61")]
	public void DIODJNGDMDD((Quaternion rot, Vector3 moments) DAKHJKLEMDA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001A9")]
	[Cpp2IlInjected.Address(RVA = "0x7028700", Offset = "0x7027300", VA = "0x187028700", Slot = "114")]
	public void OLGGIMDAFGE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001AA")]
	[Cpp2IlInjected.Address(RVA = "0x7023A40", Offset = "0x7022640", VA = "0x187023A40", Slot = "115")]
	public void BOFJEGKPIDK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001AB")]
	[Cpp2IlInjected.Address(RVA = "0x7026A90", Offset = "0x7025690", VA = "0x187026A90", Slot = "116")]
	public void KGOEDDJICMA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001B4")]
	[Cpp2IlInjected.Address(RVA = "0x7024F70", Offset = "0x7023B70", VA = "0x187024F70", Slot = "117")]
	public bool FGICBOJAMPD()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001B5")]
	[Cpp2IlInjected.Address(RVA = "0x7028CA0", Offset = "0x70278A0", VA = "0x187028CA0", Slot = "94")]
	public void PHFOJALJMOJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001B6")]
	[Cpp2IlInjected.Address(RVA = "0x7024B30", Offset = "0x7023730", VA = "0x187024B30", Slot = "118")]
	public void FCLCNJHCFEK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001BE")]
	[Cpp2IlInjected.Address(RVA = "0x7023200", Offset = "0x7021E00", VA = "0x187023200", Slot = "119")]
	public void AEGKOCEMEGJ(object GBENACPKFNA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001BF")]
	[Cpp2IlInjected.Address(RVA = "0x7028AF0", Offset = "0x70276F0", VA = "0x187028AF0", Slot = "120")]
	public void PEFODCFIPOM(object GBENACPKFNA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001C0")]
	[Cpp2IlInjected.Address(RVA = "0x7028820", Offset = "0x7027420", VA = "0x187028820", Slot = "121")]
	public void OPGIAECBLAE(object GBENACPKFNA, bool KBFDDAHABNO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001D0")]
	[Cpp2IlInjected.Address(RVA = "0x7028890", Offset = "0x7027490", VA = "0x187028890", Slot = "122")]
	public void PANNMNBPPPO(Vector3 CIBLJNHHDEI, Quaternion MEKOHPCFOEN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001D1")]
	[Cpp2IlInjected.Address(RVA = "0x70273B0", Offset = "0x7025FB0", VA = "0x1870273B0", Slot = "123")]
	public void MGGLAHFGLCF(Vector3 OODGCMHJCPI, Quaternion BBBLGHPGBJP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001D2")]
	[Cpp2IlInjected.Address(RVA = "0x70248A0", Offset = "0x70234A0", VA = "0x1870248A0", Slot = "124")]
	public bool EHMBHIMNJMI(float GMIJCBEMLNL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001D7")]
	[Cpp2IlInjected.Address(RVA = "0x7024A80", Offset = "0x7023680", VA = "0x187024A80", Slot = "125")]
	public void EMHMEOEEPHK(object GBENACPKFNA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001D8")]
	[Cpp2IlInjected.Address(RVA = "0x7026E80", Offset = "0x7025A80", VA = "0x187026E80", Slot = "126")]
	public void LDJNNFMGEDJ(object GBENACPKFNA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001D9")]
	[Cpp2IlInjected.Address(RVA = "0x7025F20", Offset = "0x7024B20", VA = "0x187025F20", Slot = "127")]
	public void ILHOGPAMLOI(object GBENACPKFNA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001DA")]
	[Cpp2IlInjected.Address(RVA = "0x7023F20", Offset = "0x7022B20", VA = "0x187023F20", Slot = "128")]
	public void DFNPFAMILKL(object GBENACPKFNA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001DB")]
	[Cpp2IlInjected.Address(RVA = "0x70235E0", Offset = "0x70221E0", VA = "0x1870235E0", Slot = "129")]
	public void BABMAEABEIM(Vector3 FPPHGAIAECP, ForceMode FAJECLKJHJB = ForceMode.Force)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001DC")]
	[Cpp2IlInjected.Address(RVA = "0x7025C10", Offset = "0x7024810", VA = "0x187025C10", Slot = "130")]
	public void ICKGEAJCKAG(Vector3 FPPHGAIAECP, Vector3 DCDKACDAEIJ, ForceMode FAJECLKJHJB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001DD")]
	[Cpp2IlInjected.Address(RVA = "0x7023440", Offset = "0x7022040", VA = "0x187023440", Slot = "131")]
	public void ALPGIIFOJJD(Vector3 FJDBDBPDFJB, ForceMode FAJECLKJHJB = ForceMode.Force)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001DE")]
	[Cpp2IlInjected.Address(RVA = "0x7027920", Offset = "0x7026520", VA = "0x187027920", Slot = "132")]
	public void NFMDMFEEENC(Vector3 FJDBDBPDFJB, ForceMode FAJECLKJHJB = ForceMode.Force)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001E1")]
	[Cpp2IlInjected.Address(RVA = "0x7026F90", Offset = "0x7025B90", VA = "0x187026F90", Slot = "133")]
	public bool LMDHKAMDKDE(Vector3 MLCEOGMBLFG, [Out] RaycastHit IEALFPDCKEB, float DIPNJIGHAJA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001E4")]
	[Cpp2IlInjected.Address(RVA = "0x7024FC0", Offset = "0x7023BC0", VA = "0x187024FC0", Slot = "134")]
	public void FIAFIGKJINB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001E5")]
	[Cpp2IlInjected.Address(RVA = "0x70290E0", Offset = "0x7027CE0", VA = "0x1870290E0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001E6")]
	[Cpp2IlInjected.Address(RVA = "0x7028750", Offset = "0x7027350", VA = "0x187028750")]
	private void OOOJKCEJFDG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001E7")]
	[Cpp2IlInjected.Address(RVA = "0x7023930", Offset = "0x7022530", VA = "0x187023930")]
	private void BODFEMJGFHG(EGNFIBKBHKP DELFIACNBGK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001E8")]
	[Cpp2IlInjected.Address(RVA = "0x7024450", Offset = "0x7023050", VA = "0x187024450")]
	private void DOBPKIHKHDI(EGNFIBKBHKP DELFIACNBGK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001E9")]
	[Cpp2IlInjected.Address(RVA = "0x70261E0", Offset = "0x7024DE0", VA = "0x1870261E0")]
	private void JMELDLNJCOE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001EA")]
	[Cpp2IlInjected.Address(RVA = "0x7025B10", Offset = "0x7024710", VA = "0x187025B10")]
	private void HNJBJNHPENP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001EB")]
	[Cpp2IlInjected.Address(RVA = "0x7027FD0", Offset = "0x7026BD0", VA = "0x187027FD0")]
	private void OBGLAOODEKH(EGNFIBKBHKP JGJEMIAJOCC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001EC")]
	[Cpp2IlInjected.Address(RVA = "0x7026AE0", Offset = "0x70256E0", VA = "0x187026AE0")]
	private void KGPEPBNPCNL(EGNFIBKBHKP DELFIACNBGK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001ED")]
	[Cpp2IlInjected.Address(RVA = "0x70262F0", Offset = "0x7024EF0", VA = "0x1870262F0")]
	private void JOCHOOBKGCN(EGNFIBKBHKP DELFIACNBGK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001EE")]
	[Cpp2IlInjected.Address(RVA = "0x7028CF0", Offset = "0x70278F0", VA = "0x187028CF0")]
	private void PJPOGDGENOP(NIJCOMOFOFB DELFIACNBGK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001EF")]
	[Cpp2IlInjected.Address(RVA = "0x70265D0", Offset = "0x70251D0", VA = "0x1870265D0", Slot = "141")]
	protected virtual void KCEBEPNBLFO(NIJCOMOFOFB JMMPGPEMBEI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001F0")]
	[Cpp2IlInjected.Address(RVA = "0x7027C70", Offset = "0x7026870", VA = "0x187027C70")]
	protected void NPMLEKGIGDH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001F1")]
	[Cpp2IlInjected.Address(RVA = "0x7028280", Offset = "0x7026E80", VA = "0x187028280")]
	protected void OGCKKOFDOLK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001F2")]
	[Cpp2IlInjected.Address(RVA = "0x70271C0", Offset = "0x7025DC0", VA = "0x1870271C0", Slot = "142")]
	protected virtual IDisposable LPNBAOINJBH()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200001D")]
internal static class MLEFDLMKBNM
{
	[Cpp2IlInjected.Token(Token = "0x60001F3")]
	[Cpp2IlInjected.Address(RVA = "0x70292F0", Offset = "0x7027EF0", VA = "0x1870292F0")]
	public static EGNFIBKBHKP JGOAPMEBADG(this EGNFIBKBHKP JMMPGPEMBEI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001F4")]
	[Cpp2IlInjected.Address(RVA = "0x7029270", Offset = "0x7027E70", VA = "0x187029270")]
	public static bool FJPKKKCHAED(this EGNFIBKBHKP JMMPGPEMBEI, EGNFIBKBHKP IEMOLANIJKF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001F5")]
	[Cpp2IlInjected.Address(RVA = "0x70291F0", Offset = "0x7027DF0", VA = "0x1870291F0")]
	public static bool ACODGEOFDFA(this EGNFIBKBHKP JMMPGPEMBEI, EGNFIBKBHKP KGIDMKMGAJN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001F6")]
	[Cpp2IlInjected.Address(RVA = "0x7029420", Offset = "0x7028020", VA = "0x187029420")]
	public static NIJCOMOFOFB POMFMDHGAJI(this EGNFIBKBHKP JPJGGLNFIBC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001F7")]
	[Cpp2IlInjected.Address(RVA = "0x70293B0", Offset = "0x7027FB0", VA = "0x1870293B0")]
	public static MDHDELBPMHJ PMEAMJFPNIN(this EGNFIBKBHKP JPJGGLNFIBC)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200001E")]
public class LFPLIAJPGBK : FJIMMJIOKCJ
{
	[Cpp2IlInjected.Token(Token = "0x60001F8")]
	[Cpp2IlInjected.Address(RVA = "0x701FA30", Offset = "0x701E630", VA = "0x18701FA30", Slot = "19")]
	public EGNFIBKBHKP GDNNBJHAMFI(RigidbodyEx JMMPGPEMBEI, CCGIPMCDDGA JGFKFMMOAJO, NPICBIONHHC DMMHPLIIKDJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001F9")]
	[Cpp2IlInjected.Address(RVA = "0x866B30", Offset = "0x865730", VA = "0x180866B30", Slot = "4")]
	public LFBFGPDKIHF MFANHIPCANH(EGNFIBKBHKP JPJGGLNFIBC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001FA")]
	[Cpp2IlInjected.Address(RVA = "0x866B30", Offset = "0x865730", VA = "0x180866B30", Slot = "5")]
	public PKGFJJHHDNP EDOLMDBKLPD(EGNFIBKBHKP JPJGGLNFIBC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001FB")]
	[Cpp2IlInjected.Address(RVA = "0x866B30", Offset = "0x865730", VA = "0x180866B30", Slot = "6")]
	public CKOKBJLNIGM PAOOBPAKOBB(EGNFIBKBHKP JPJGGLNFIBC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001FC")]
	[Cpp2IlInjected.Address(RVA = "0x866B30", Offset = "0x865730", VA = "0x180866B30", Slot = "7")]
	public OFABJBGMCEJ MKDIICBMIKK(EGNFIBKBHKP JPJGGLNFIBC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001FD")]
	[Cpp2IlInjected.Address(RVA = "0x866B30", Offset = "0x865730", VA = "0x180866B30", Slot = "8")]
	public OOPCMGEAGDH POHIHJEEJOM(EGNFIBKBHKP JPJGGLNFIBC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001FE")]
	[Cpp2IlInjected.Address(RVA = "0x866B30", Offset = "0x865730", VA = "0x180866B30", Slot = "9")]
	public CCCKAHDOEDH EFBGOOCMOJE(EGNFIBKBHKP JPJGGLNFIBC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001FF")]
	[Cpp2IlInjected.Address(RVA = "0x866B30", Offset = "0x865730", VA = "0x180866B30", Slot = "10")]
	public BFAJBPGIDNL MCJGBIEFEIH(EGNFIBKBHKP JPJGGLNFIBC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000200")]
	[Cpp2IlInjected.Address(RVA = "0x866B30", Offset = "0x865730", VA = "0x180866B30", Slot = "11")]
	public AIIECHHMHKF KKLKGLFJFIA(EGNFIBKBHKP JPJGGLNFIBC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000201")]
	[Cpp2IlInjected.Address(RVA = "0x866B30", Offset = "0x865730", VA = "0x180866B30", Slot = "12")]
	public FDBIKGBKFEF ANKJIFCAPGM(EGNFIBKBHKP JPJGGLNFIBC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000202")]
	[Cpp2IlInjected.Address(RVA = "0x866B30", Offset = "0x865730", VA = "0x180866B30", Slot = "13")]
	public EOFGEIBMJGB OKDEBCHPHGA(EGNFIBKBHKP JPJGGLNFIBC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000203")]
	[Cpp2IlInjected.Address(RVA = "0x866B30", Offset = "0x865730", VA = "0x180866B30")]
	public ACOGMOKAGMB KJJAEHOOFDO(EGNFIBKBHKP JPJGGLNFIBC, [In] CCGIPMCDDGA JGFKFMMOAJO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000204")]
	[Cpp2IlInjected.Address(RVA = "0x866B30", Offset = "0x865730", VA = "0x180866B30")]
	public IPKAFMFLAHB NAKMOENFAHL(EGNFIBKBHKP JPJGGLNFIBC, [In] CCGIPMCDDGA JGFKFMMOAJO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000205")]
	[Cpp2IlInjected.Address(RVA = "0x866B30", Offset = "0x865730", VA = "0x180866B30")]
	public CJNOICOENPF JKCGFDAEIHI(EGNFIBKBHKP JPJGGLNFIBC, [In] CCGIPMCDDGA JGFKFMMOAJO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000206")]
	[Cpp2IlInjected.Address(RVA = "0x866B30", Offset = "0x865730", VA = "0x180866B30")]
	public ADDPLOFLCBC DJBOOBNMODB(EGNFIBKBHKP JPJGGLNFIBC, [In] CCGIPMCDDGA JGFKFMMOAJO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000207")]
	[Cpp2IlInjected.Address(RVA = "0x866B30", Offset = "0x865730", VA = "0x180866B30")]
	public IDNMICNIEEM EFCELJPCHKG(EGNFIBKBHKP JPJGGLNFIBC, [In] CCGIPMCDDGA JGFKFMMOAJO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000208")]
	[Cpp2IlInjected.Address(RVA = "0x86FB10", Offset = "0x86E710", VA = "0x18086FB10")]
	public LFPLIAJPGBK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000209")]
	[Cpp2IlInjected.Address(RVA = "0x866B30", Offset = "0x865730", VA = "0x180866B30", Slot = "14")]
	private ACOGMOKAGMB PPAOIHJPCKE(EGNFIBKBHKP JPJGGLNFIBC, [In] CCGIPMCDDGA JGFKFMMOAJO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600020A")]
	[Cpp2IlInjected.Address(RVA = "0x866B30", Offset = "0x865730", VA = "0x180866B30", Slot = "15")]
	private IPKAFMFLAHB FBCLJAHOBPJ(EGNFIBKBHKP JPJGGLNFIBC, [In] CCGIPMCDDGA JGFKFMMOAJO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600020B")]
	[Cpp2IlInjected.Address(RVA = "0x866B30", Offset = "0x865730", VA = "0x180866B30", Slot = "16")]
	private CJNOICOENPF CNFOHPNAPNJ(EGNFIBKBHKP JPJGGLNFIBC, [In] CCGIPMCDDGA JGFKFMMOAJO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600020C")]
	[Cpp2IlInjected.Address(RVA = "0x866B30", Offset = "0x865730", VA = "0x180866B30", Slot = "17")]
	private ADDPLOFLCBC COPMPJDEFAO(EGNFIBKBHKP JPJGGLNFIBC, [In] CCGIPMCDDGA JGFKFMMOAJO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600020D")]
	[Cpp2IlInjected.Address(RVA = "0x866B30", Offset = "0x865730", VA = "0x180866B30", Slot = "18")]
	private IDNMICNIEEM ILAEDMGKADO(EGNFIBKBHKP JPJGGLNFIBC, [In] CCGIPMCDDGA JGFKFMMOAJO)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200001F")]
[PJPINLCJEGC(typeof(FJIMMJIOKCJ), new string[] { })]
public class CNEENBPJNKB : FJIMMJIOKCJ, PNBJBHKBIBJ
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400002B")]
	private readonly FJIMMJIOKCJ ELDLHIOGHNI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400002C")]
	private readonly FJIMMJIOKCJ AIDCGLBEAPF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400002D")]
	private DBENOAJDGJG JPPJBALBCNC;

	[Cpp2IlInjected.Token(Token = "0x17000089")]
	private FJIMMJIOKCJ NKLBMKHAGBK
	{
		[Cpp2IlInjected.Token(Token = "0x600020F")]
		[Cpp2IlInjected.Address(RVA = "0x7018720", Offset = "0x7017320", VA = "0x187018720")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600020E")]
	[Cpp2IlInjected.Address(RVA = "0x7018580", Offset = "0x7017180", VA = "0x187018580", Slot = "20")]
	public void InitReferences(IELNGKFCIIK HCJHLONKJLK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000210")]
	[Cpp2IlInjected.Address(RVA = "0x7018820", Offset = "0x7017420", VA = "0x187018820", Slot = "4")]
	public LFBFGPDKIHF MFANHIPCANH(EGNFIBKBHKP JPJGGLNFIBC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000211")]
	[Cpp2IlInjected.Address(RVA = "0x7018190", Offset = "0x7016D90", VA = "0x187018190", Slot = "5")]
	public PKGFJJHHDNP EDOLMDBKLPD(EGNFIBKBHKP JPJGGLNFIBC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000212")]
	[Cpp2IlInjected.Address(RVA = "0x7018A00", Offset = "0x7017600", VA = "0x187018A00", Slot = "6")]
	public CKOKBJLNIGM PAOOBPAKOBB(EGNFIBKBHKP JPJGGLNFIBC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000213")]
	[Cpp2IlInjected.Address(RVA = "0x70188C0", Offset = "0x70174C0", VA = "0x1870188C0", Slot = "7")]
	public OFABJBGMCEJ MKDIICBMIKK(EGNFIBKBHKP JPJGGLNFIBC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000214")]
	[Cpp2IlInjected.Address(RVA = "0x7018AA0", Offset = "0x70176A0", VA = "0x187018AA0", Slot = "8")]
	public OOPCMGEAGDH POHIHJEEJOM(EGNFIBKBHKP JPJGGLNFIBC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000215")]
	[Cpp2IlInjected.Address(RVA = "0x7018230", Offset = "0x7016E30", VA = "0x187018230", Slot = "9")]
	public CCCKAHDOEDH EFBGOOCMOJE(EGNFIBKBHKP JPJGGLNFIBC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000216")]
	[Cpp2IlInjected.Address(RVA = "0x7018780", Offset = "0x7017380", VA = "0x187018780", Slot = "10")]
	public BFAJBPGIDNL MCJGBIEFEIH(EGNFIBKBHKP JPJGGLNFIBC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000217")]
	[Cpp2IlInjected.Address(RVA = "0x7018680", Offset = "0x7017280", VA = "0x187018680", Slot = "11")]
	public AIIECHHMHKF KKLKGLFJFIA(EGNFIBKBHKP JPJGGLNFIBC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000218")]
	[Cpp2IlInjected.Address(RVA = "0x7017F90", Offset = "0x7016B90", VA = "0x187017F90", Slot = "12")]
	public FDBIKGBKFEF ANKJIFCAPGM(EGNFIBKBHKP JPJGGLNFIBC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000219")]
	[Cpp2IlInjected.Address(RVA = "0x7018960", Offset = "0x7017560", VA = "0x187018960", Slot = "13")]
	public EOFGEIBMJGB OKDEBCHPHGA(EGNFIBKBHKP JPJGGLNFIBC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600021A")]
	[Cpp2IlInjected.Address(RVA = "0x70185D0", Offset = "0x70171D0", VA = "0x1870185D0")]
	public ACOGMOKAGMB KJJAEHOOFDO(EGNFIBKBHKP JPJGGLNFIBC, [In] CCGIPMCDDGA JGFKFMMOAJO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600021B")]
	[Cpp2IlInjected.Address(RVA = "0x7018380", Offset = "0x7016F80", VA = "0x187018380")]
	public IPKAFMFLAHB NAKMOENFAHL(EGNFIBKBHKP JPJGGLNFIBC, [In] CCGIPMCDDGA JGFKFMMOAJO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600021C")]
	[Cpp2IlInjected.Address(RVA = "0x7018030", Offset = "0x7016C30", VA = "0x187018030")]
	public CJNOICOENPF JKCGFDAEIHI(EGNFIBKBHKP JPJGGLNFIBC, [In] CCGIPMCDDGA JGFKFMMOAJO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600021D")]
	[Cpp2IlInjected.Address(RVA = "0x70180E0", Offset = "0x7016CE0", VA = "0x1870180E0")]
	public ADDPLOFLCBC DJBOOBNMODB(EGNFIBKBHKP JPJGGLNFIBC, [In] CCGIPMCDDGA JGFKFMMOAJO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600021E")]
	[Cpp2IlInjected.Address(RVA = "0x70182D0", Offset = "0x7016ED0", VA = "0x1870182D0")]
	public IDNMICNIEEM EFCELJPCHKG(EGNFIBKBHKP JPJGGLNFIBC, [In] CCGIPMCDDGA JGFKFMMOAJO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600021F")]
	[Cpp2IlInjected.Address(RVA = "0x7018430", Offset = "0x7017030", VA = "0x187018430", Slot = "19")]
	public EGNFIBKBHKP GDNNBJHAMFI(RigidbodyEx JMMPGPEMBEI, CCGIPMCDDGA JGFKFMMOAJO, NPICBIONHHC DMMHPLIIKDJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000220")]
	[Cpp2IlInjected.Address(RVA = "0x7018B40", Offset = "0x7017740", VA = "0x187018B40")]
	public CNEENBPJNKB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000221")]
	[Cpp2IlInjected.Address(RVA = "0x70185D0", Offset = "0x70171D0", VA = "0x1870185D0", Slot = "14")]
	private ACOGMOKAGMB PPAOIHJPCKE(EGNFIBKBHKP JPJGGLNFIBC, [In] CCGIPMCDDGA JGFKFMMOAJO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000222")]
	[Cpp2IlInjected.Address(RVA = "0x7018380", Offset = "0x7016F80", VA = "0x187018380", Slot = "15")]
	private IPKAFMFLAHB FBCLJAHOBPJ(EGNFIBKBHKP JPJGGLNFIBC, [In] CCGIPMCDDGA JGFKFMMOAJO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000223")]
	[Cpp2IlInjected.Address(RVA = "0x7018030", Offset = "0x7016C30", VA = "0x187018030", Slot = "16")]
	private CJNOICOENPF CNFOHPNAPNJ(EGNFIBKBHKP JPJGGLNFIBC, [In] CCGIPMCDDGA JGFKFMMOAJO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000224")]
	[Cpp2IlInjected.Address(RVA = "0x70180E0", Offset = "0x7016CE0", VA = "0x1870180E0", Slot = "17")]
	private ADDPLOFLCBC COPMPJDEFAO(EGNFIBKBHKP JPJGGLNFIBC, [In] CCGIPMCDDGA JGFKFMMOAJO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000225")]
	[Cpp2IlInjected.Address(RVA = "0x70182D0", Offset = "0x7016ED0", VA = "0x1870182D0", Slot = "18")]
	private IDNMICNIEEM ILAEDMGKADO(EGNFIBKBHKP JPJGGLNFIBC, [In] CCGIPMCDDGA JGFKFMMOAJO)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000020")]
public interface MHNCKMPCLKL : LFBFGPDKIHF, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x6000226")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void HEHNFNCPIPE(EGNFIBKBHKP JMMPGPEMBEI);

	[Cpp2IlInjected.Token(Token = "0x6000227")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void BHFKIMOCFLD(EGNFIBKBHKP JMMPGPEMBEI);

	[Cpp2IlInjected.Token(Token = "0x6000228")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void ALBBMPLIGNA(EGNFIBKBHKP JGJEMIAJOCC);

	[Cpp2IlInjected.Token(Token = "0x6000229")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void GIGHJMFOELG(EGNFIBKBHKP JGJEMIAJOCC);
}
[Cpp2IlInjected.Token(Token = "0x2000021")]
public interface HKNHJFOIGLD : CKOKBJLNIGM
{
	[Cpp2IlInjected.Token(Token = "0x1700008A")]
	DEHOPLDGAFI<EGNFIBKBHKP> MCEPHLBCNOM
	{
		[Cpp2IlInjected.Token(Token = "0x600022A")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700008B")]
	EGNFIBKBHKP DIGGGKJGKNG
	{
		[Cpp2IlInjected.Token(Token = "0x600022B")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000022")]
public interface JLKOPJHNFKI : ADDPLOFLCBC
{
	[Cpp2IlInjected.Token(Token = "0x600022C")]
	[Cpp2IlInjected.Address(Slot = "0")]
	(float, Vector3) MMEADAKNGAM(Rigidbody NKNEDKFEPKM);
}
[Cpp2IlInjected.Token(Token = "0x2000023")]
public interface ICANFEEPONI : IPKAFMFLAHB, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x1700008C")]
	PhotonView MDPLCMMAAIE
	{
		[Cpp2IlInjected.Token(Token = "0x600022D")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000024")]
internal sealed class NAJHPDAMOEF : FDBIKGBKFEF
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400002E")]
	private readonly MDHDELBPMHJ JMMPGPEMBEI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400002F")]
	private CollisionDetectionMode IPJDNPGACPK;

	[Cpp2IlInjected.Token(Token = "0x1700008D")]
	private Rigidbody CKFDKNLJFBH
	{
		[Cpp2IlInjected.Token(Token = "0x600022E")]
		[Cpp2IlInjected.Address(RVA = "0x701D640", Offset = "0x701C240", VA = "0x18701D640")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700008E")]
	public CollisionDetectionMode CJKJNHCCBNE
	{
		[Cpp2IlInjected.Token(Token = "0x6000232")]
		[Cpp2IlInjected.Address(RVA = "0x70296C0", Offset = "0x70282C0", VA = "0x1870296C0", Slot = "4")]
		get
		{
			return default(CollisionDetectionMode);
		}
		[Cpp2IlInjected.Token(Token = "0x6000233")]
		[Cpp2IlInjected.Address(RVA = "0x7029930", Offset = "0x7028530", VA = "0x187029930", Slot = "5")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600022F")]
	[Cpp2IlInjected.Address(RVA = "0x701D6F0", Offset = "0x701C2F0", VA = "0x18701D6F0")]
	public NAJHPDAMOEF(EGNFIBKBHKP JMMPGPEMBEI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000230")]
	[Cpp2IlInjected.Address(RVA = "0x7029470", Offset = "0x7028070", VA = "0x187029470", Slot = "6")]
	public void BCJIBCPCLJO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000231")]
	[Cpp2IlInjected.Address(RVA = "0x70299A0", Offset = "0x70285A0", VA = "0x1870299A0", Slot = "9")]
	public void PMJCKMMFMFM(Rigidbody JJDGGMNFHIL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000234")]
	[Cpp2IlInjected.Address(RVA = "0x7029580", Offset = "0x7028180", VA = "0x187029580", Slot = "7")]
	public void DKKIABEEHHJ(bool LODEHKIEEJN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000235")]
	[Cpp2IlInjected.Address(RVA = "0x70296B0", Offset = "0x70282B0", VA = "0x1870296B0", Slot = "8")]
	public void JHOGHBHPDHM(bool LODEHKIEEJN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000236")]
	[Cpp2IlInjected.Address(RVA = "0x70297D0", Offset = "0x70283D0", VA = "0x1870297D0", Slot = "10")]
	public bool LMDHKAMDKDE(Vector3 MLCEOGMBLFG, [Out] RaycastHit IEALFPDCKEB, float DIPNJIGHAJA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000237")]
	[Cpp2IlInjected.Address(RVA = "0x7029590", Offset = "0x7028190", VA = "0x187029590")]
	private void IGFKNMKANFO(bool LODEHKIEEJN)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000025")]
public sealed class INBGPDADOKI : CCCKAHDOEDH, IDisposable, NECDNJPEKJG
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000031")]
	private readonly MDHDELBPMHJ JMMPGPEMBEI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000032")]
	private LHFCBMFLLBG LBNGDOEOHHC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000033")]
	private MLOEMGPHEAG JEOHGPDBGPL;

	[Cpp2IlInjected.Token(Token = "0x1700008F")]
	public LHFCBMFLLBG FFPPBFFPFKN
	{
		[Cpp2IlInjected.Token(Token = "0x600023A")]
		[Cpp2IlInjected.Address(RVA = "0x701F7B0", Offset = "0x701E3B0", VA = "0x18701F7B0", Slot = "6")]
		get
		{
			return default(LHFCBMFLLBG);
		}
		[Cpp2IlInjected.Token(Token = "0x600023B")]
		[Cpp2IlInjected.Address(RVA = "0x701F670", Offset = "0x701E270", VA = "0x18701F670", Slot = "7")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000090")]
	private Transform BJHHLINNGKN
	{
		[Cpp2IlInjected.Token(Token = "0x600023C")]
		[Cpp2IlInjected.Address(RVA = "0x701F790", Offset = "0x701E390", VA = "0x18701F790", Slot = "10")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000020")]
	public event Action<IABFIAOBIIB, IABFIAOBIIB> HNJNIGNEAPH
	{
		[Cpp2IlInjected.Token(Token = "0x6000238")]
		[Cpp2IlInjected.Address(RVA = "0x701F350", Offset = "0x701DF50", VA = "0x18701F350", Slot = "4")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000239")]
		[Cpp2IlInjected.Address(RVA = "0x701F8F0", Offset = "0x701E4F0", VA = "0x18701F8F0", Slot = "5")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600023D")]
	[Cpp2IlInjected.Address(RVA = "0x701F9A0", Offset = "0x701E5A0", VA = "0x18701F9A0")]
	public INBGPDADOKI(EGNFIBKBHKP JMMPGPEMBEI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600023E")]
	[Cpp2IlInjected.Address(RVA = "0x701F400", Offset = "0x701E000", VA = "0x18701F400", Slot = "8")]
	public void BCJIBCPCLJO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600023F")]
	[Cpp2IlInjected.Address(RVA = "0x701F740", Offset = "0x701E340", VA = "0x18701F740", Slot = "9")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000240")]
	[Cpp2IlInjected.Address(RVA = "0x999F00", Offset = "0x998B00", VA = "0x180999F00", Slot = "11")]
	private void DMCFOKAOMAP(IABFIAOBIIB AKLFKNMIKPD, IABFIAOBIIB FIJPEPLJMMO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000241")]
	[Cpp2IlInjected.Address(RVA = "0x866B20", Offset = "0x865720", VA = "0x180866B20", Slot = "12")]
	private void FOLNCJBAIPK(bool DLFBAKFHOFN)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000026")]
public class OAGIJBGNNPB : FJIMMJIOKCJ
{
	[Cpp2IlInjected.Token(Token = "0x6000242")]
	[Cpp2IlInjected.Address(RVA = "0x702A640", Offset = "0x7029240", VA = "0x18702A640", Slot = "4")]
	public LFBFGPDKIHF MFANHIPCANH(EGNFIBKBHKP JPJGGLNFIBC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000243")]
	[Cpp2IlInjected.Address(RVA = "0x7029DA0", Offset = "0x70289A0", VA = "0x187029DA0", Slot = "5")]
	public PKGFJJHHDNP EDOLMDBKLPD(EGNFIBKBHKP JPJGGLNFIBC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000244")]
	[Cpp2IlInjected.Address(RVA = "0x702A870", Offset = "0x7029470", VA = "0x18702A870", Slot = "6")]
	public CKOKBJLNIGM PAOOBPAKOBB(EGNFIBKBHKP JPJGGLNFIBC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000245")]
	[Cpp2IlInjected.Address(RVA = "0x702A730", Offset = "0x7029330", VA = "0x18702A730", Slot = "7")]
	public OFABJBGMCEJ MKDIICBMIKK(EGNFIBKBHKP JPJGGLNFIBC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000246")]
	[Cpp2IlInjected.Address(RVA = "0x702A9A0", Offset = "0x70295A0", VA = "0x18702A9A0", Slot = "8")]
	public OOPCMGEAGDH POHIHJEEJOM(EGNFIBKBHKP JPJGGLNFIBC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000247")]
	[Cpp2IlInjected.Address(RVA = "0x7029EC0", Offset = "0x7028AC0", VA = "0x187029EC0", Slot = "9")]
	public CCCKAHDOEDH EFBGOOCMOJE(EGNFIBKBHKP JPJGGLNFIBC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000248")]
	[Cpp2IlInjected.Address(RVA = "0x702A520", Offset = "0x7029120", VA = "0x18702A520", Slot = "10")]
	public BFAJBPGIDNL MCJGBIEFEIH(EGNFIBKBHKP JPJGGLNFIBC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000249")]
	[Cpp2IlInjected.Address(RVA = "0x702A460", Offset = "0x7029060", VA = "0x18702A460", Slot = "11")]
	public AIIECHHMHKF KKLKGLFJFIA(EGNFIBKBHKP JPJGGLNFIBC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600024A")]
	[Cpp2IlInjected.Address(RVA = "0x7029A20", Offset = "0x7028620", VA = "0x187029A20", Slot = "12")]
	public FDBIKGBKFEF ANKJIFCAPGM(EGNFIBKBHKP JPJGGLNFIBC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600024B")]
	[Cpp2IlInjected.Address(RVA = "0x702A7B0", Offset = "0x70293B0", VA = "0x18702A7B0", Slot = "13")]
	public EOFGEIBMJGB OKDEBCHPHGA(EGNFIBKBHKP JPJGGLNFIBC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600024C")]
	[Cpp2IlInjected.Address(RVA = "0x702A320", Offset = "0x7028F20", VA = "0x18702A320")]
	public ACOGMOKAGMB KJJAEHOOFDO(EGNFIBKBHKP JPJGGLNFIBC, [In] CCGIPMCDDGA JGFKFMMOAJO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600024D")]
	[Cpp2IlInjected.Address(RVA = "0x702A070", Offset = "0x7028C70", VA = "0x18702A070")]
	public IPKAFMFLAHB NAKMOENFAHL(EGNFIBKBHKP JPJGGLNFIBC, [In] CCGIPMCDDGA JGFKFMMOAJO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600024E")]
	[Cpp2IlInjected.Address(RVA = "0x7029AE0", Offset = "0x70286E0", VA = "0x187029AE0")]
	public CJNOICOENPF JKCGFDAEIHI(EGNFIBKBHKP JPJGGLNFIBC, [In] CCGIPMCDDGA JGFKFMMOAJO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600024F")]
	[Cpp2IlInjected.Address(RVA = "0x7029C10", Offset = "0x7028810", VA = "0x187029C10")]
	public ADDPLOFLCBC DJBOOBNMODB(EGNFIBKBHKP JPJGGLNFIBC, [In] CCGIPMCDDGA JGFKFMMOAJO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000250")]
	[Cpp2IlInjected.Address(RVA = "0x7029F90", Offset = "0x7028B90", VA = "0x187029F90")]
	public IDNMICNIEEM EFCELJPCHKG(EGNFIBKBHKP JPJGGLNFIBC, [In] CCGIPMCDDGA JGFKFMMOAJO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000251")]
	[Cpp2IlInjected.Address(RVA = "0x702A200", Offset = "0x7028E00", VA = "0x18702A200", Slot = "19")]
	public EGNFIBKBHKP GDNNBJHAMFI(RigidbodyEx JMMPGPEMBEI, CCGIPMCDDGA JGFKFMMOAJO, NPICBIONHHC DMMHPLIIKDJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000252")]
	[Cpp2IlInjected.Address(RVA = "0x86FB10", Offset = "0x86E710", VA = "0x18086FB10")]
	public OAGIJBGNNPB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000253")]
	[Cpp2IlInjected.Address(RVA = "0x702A320", Offset = "0x7028F20", VA = "0x18702A320", Slot = "14")]
	private ACOGMOKAGMB PPAOIHJPCKE(EGNFIBKBHKP JPJGGLNFIBC, [In] CCGIPMCDDGA JGFKFMMOAJO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000254")]
	[Cpp2IlInjected.Address(RVA = "0x702A070", Offset = "0x7028C70", VA = "0x18702A070", Slot = "15")]
	private IPKAFMFLAHB FBCLJAHOBPJ(EGNFIBKBHKP JPJGGLNFIBC, [In] CCGIPMCDDGA JGFKFMMOAJO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000255")]
	[Cpp2IlInjected.Address(RVA = "0x7029AE0", Offset = "0x70286E0", VA = "0x187029AE0", Slot = "16")]
	private CJNOICOENPF CNFOHPNAPNJ(EGNFIBKBHKP JPJGGLNFIBC, [In] CCGIPMCDDGA JGFKFMMOAJO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000256")]
	[Cpp2IlInjected.Address(RVA = "0x7029C10", Offset = "0x7028810", VA = "0x187029C10", Slot = "17")]
	private ADDPLOFLCBC COPMPJDEFAO(EGNFIBKBHKP JPJGGLNFIBC, [In] CCGIPMCDDGA JGFKFMMOAJO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000257")]
	[Cpp2IlInjected.Address(RVA = "0x7029F90", Offset = "0x7028B90", VA = "0x187029F90", Slot = "18")]
	private IDNMICNIEEM ILAEDMGKADO(EGNFIBKBHKP JPJGGLNFIBC, [In] CCGIPMCDDGA JGFKFMMOAJO)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000027")]
internal sealed class GMEPMLCBJLI : AIIECHHMHKF
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000034")]
	private readonly MDHDELBPMHJ JMMPGPEMBEI;

	[Cpp2IlInjected.Token(Token = "0x17000091")]
	private Rigidbody CKFDKNLJFBH
	{
		[Cpp2IlInjected.Token(Token = "0x6000258")]
		[Cpp2IlInjected.Address(RVA = "0x701D640", Offset = "0x701C240", VA = "0x18701D640")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000092")]
	private bool PHMLJIAJDCC
	{
		[Cpp2IlInjected.Token(Token = "0x6000259")]
		[Cpp2IlInjected.Address(RVA = "0x701CED0", Offset = "0x701BAD0", VA = "0x18701CED0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000093")]
	private bool IGBHMJICOCE
	{
		[Cpp2IlInjected.Token(Token = "0x600025A")]
		[Cpp2IlInjected.Address(RVA = "0x7015790", Offset = "0x7014390", VA = "0x187015790")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000094")]
	private EGNFIBKBHKP BBKNDFHDFHL
	{
		[Cpp2IlInjected.Token(Token = "0x600025B")]
		[Cpp2IlInjected.Address(RVA = "0x701D690", Offset = "0x701C290", VA = "0x18701D690")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600025C")]
	[Cpp2IlInjected.Address(RVA = "0x701D6F0", Offset = "0x701C2F0", VA = "0x18701D6F0")]
	public GMEPMLCBJLI(EGNFIBKBHKP JMMPGPEMBEI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600025D")]
	[Cpp2IlInjected.Address(RVA = "0x701CAF0", Offset = "0x701B6F0", VA = "0x18701CAF0", Slot = "4")]
	public void BABMAEABEIM(Vector3 FPPHGAIAECP, ForceMode FAJECLKJHJB = ForceMode.Force)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600025E")]
	[Cpp2IlInjected.Address(RVA = "0x701D3E0", Offset = "0x701BFE0", VA = "0x18701D3E0")]
	private void NKJFFBKNIEL(Vector3 FPPHGAIAECP, ForceMode FAJECLKJHJB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600025F")]
	[Cpp2IlInjected.Address(RVA = "0x701CC50", Offset = "0x701B850", VA = "0x18701CC50", Slot = "5")]
	public void ICKGEAJCKAG(Vector3 FPPHGAIAECP, Vector3 DCDKACDAEIJ, ForceMode FAJECLKJHJB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000260")]
	[Cpp2IlInjected.Address(RVA = "0x701C990", Offset = "0x701B590", VA = "0x18701C990", Slot = "6")]
	public void ALPGIIFOJJD(Vector3 FJDBDBPDFJB, ForceMode FAJECLKJHJB = ForceMode.Force)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000261")]
	[Cpp2IlInjected.Address(RVA = "0x701CF20", Offset = "0x701BB20", VA = "0x18701CF20")]
	private void NELEFFGOONM(Vector3 FJDBDBPDFJB, ForceMode FAJECLKJHJB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000262")]
	[Cpp2IlInjected.Address(RVA = "0x701D180", Offset = "0x701BD80", VA = "0x18701D180", Slot = "7")]
	public void NFMDMFEEENC(Vector3 FJDBDBPDFJB, ForceMode FAJECLKJHJB = ForceMode.Force)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000028")]
internal sealed class PODHIGJAIFE : EOFGEIBMJGB
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000035")]
	private readonly MDHDELBPMHJ JMMPGPEMBEI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000036")]
	private bool HCEBNGKNMOE;

	[Cpp2IlInjected.Token(Token = "0x17000095")]
	public bool FPHBHOGHBMJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000264")]
		[Cpp2IlInjected.Address(RVA = "0x933850", Offset = "0x932450", VA = "0x180933850", Slot = "4")]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000265")]
		[Cpp2IlInjected.Address(RVA = "0x702AE70", Offset = "0x7029A70", VA = "0x18702AE70", Slot = "5")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000263")]
	[Cpp2IlInjected.Address(RVA = "0x701D6F0", Offset = "0x701C2F0", VA = "0x18701D6F0")]
	public PODHIGJAIFE(EGNFIBKBHKP JMMPGPEMBEI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000266")]
	[Cpp2IlInjected.Address(RVA = "0x702AF80", Offset = "0x7029B80", VA = "0x18702AF80", Slot = "6")]
	public void PMJCKMMFMFM(Rigidbody JJDGGMNFHIL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000267")]
	[Cpp2IlInjected.Address(RVA = "0x702AE00", Offset = "0x7029A00", VA = "0x18702AE00", Slot = "7")]
	public void IECHDHOIHFH(Rigidbody JJDGGMNFHIL)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000029")]
internal sealed class CJBLPPELHFI : MHNCKMPCLKL, LFBFGPDKIHF, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x4000040")]
	private readonly EGNFIBKBHKP JMMPGPEMBEI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x4000041")]
	private readonly List<EGNFIBKBHKP> MIKAPLECDNL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x4000042")]
	private EGNFIBKBHKP LNPGMAMPBAC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x4000043")]
	private EGNFIBKBHKP DELFIACNBGK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
	[Cpp2IlInjected.Token(Token = "0x4000044")]
	private Transform BIEGKONEHEL;

	[Cpp2IlInjected.Token(Token = "0x17000096")]
	private Transform LHELEJKIFMG
	{
		[Cpp2IlInjected.Token(Token = "0x600027A")]
		[Cpp2IlInjected.Address(RVA = "0x7016000", Offset = "0x7014C00", VA = "0x187016000")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000097")]
	public EGNFIBKBHKP BBKNDFHDFHL
	{
		[Cpp2IlInjected.Token(Token = "0x600027D")]
		[Cpp2IlInjected.Address(RVA = "0x86DF40", Offset = "0x86CB40", VA = "0x18086DF40", Slot = "28")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600027E")]
		[Cpp2IlInjected.Address(RVA = "0x70161A0", Offset = "0x7014DA0", VA = "0x1870161A0", Slot = "29")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000098")]
	public EGNFIBKBHKP LIOIAHEPIFM
	{
		[Cpp2IlInjected.Token(Token = "0x600027F")]
		[Cpp2IlInjected.Address(RVA = "0x86B520", Offset = "0x86A120", VA = "0x18086B520", Slot = "27")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000099")]
	public IReadOnlyList<EGNFIBKBHKP> JAIPPCINDPE
	{
		[Cpp2IlInjected.Token(Token = "0x6000280")]
		[Cpp2IlInjected.Address(RVA = "0x86B540", Offset = "0x86A140", VA = "0x18086B540", Slot = "26")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000021")]
	public event PADECADCPBE CFHLFFFLALO
	{
		[Cpp2IlInjected.Token(Token = "0x6000268")]
		[Cpp2IlInjected.Address(RVA = "0x7016100", Offset = "0x7014D00", VA = "0x187016100", Slot = "8")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000269")]
		[Cpp2IlInjected.Address(RVA = "0x70176B0", Offset = "0x70162B0", VA = "0x1870176B0", Slot = "9")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000022")]
	public event PADECADCPBE PDHLFFDEEJB
	{
		[Cpp2IlInjected.Token(Token = "0x600026A")]
		[Cpp2IlInjected.Address(RVA = "0x70172B0", Offset = "0x7015EB0", VA = "0x1870172B0", Slot = "10")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600026B")]
		[Cpp2IlInjected.Address(RVA = "0x7016AB0", Offset = "0x70156B0", VA = "0x187016AB0", Slot = "11")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000023")]
	public event PNHJLHINCOF IGAOMNPMGGA
	{
		[Cpp2IlInjected.Token(Token = "0x600026C")]
		[Cpp2IlInjected.Address(RVA = "0x7017750", Offset = "0x7016350", VA = "0x187017750", Slot = "12")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600026D")]
		[Cpp2IlInjected.Address(RVA = "0x7017170", Offset = "0x7015D70", VA = "0x187017170", Slot = "13")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000024")]
	public event Action BGACKAGMGAH
	{
		[Cpp2IlInjected.Token(Token = "0x600026E")]
		[Cpp2IlInjected.Address(RVA = "0x7016F80", Offset = "0x7015B80", VA = "0x187016F80", Slot = "14")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600026F")]
		[Cpp2IlInjected.Address(RVA = "0x7016570", Offset = "0x7015170", VA = "0x187016570", Slot = "15")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000025")]
	public event Action JNFLCHJLPNN
	{
		[Cpp2IlInjected.Token(Token = "0x6000270")]
		[Cpp2IlInjected.Address(RVA = "0x7017D70", Offset = "0x7016970", VA = "0x187017D70", Slot = "16")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000271")]
		[Cpp2IlInjected.Address(RVA = "0x7017210", Offset = "0x7015E10", VA = "0x187017210", Slot = "17")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000026")]
	public event Action<EGNFIBKBHKP> OILOLCMMGFB
	{
		[Cpp2IlInjected.Token(Token = "0x6000272")]
		[Cpp2IlInjected.Address(RVA = "0x7017480", Offset = "0x7016080", VA = "0x187017480", Slot = "18")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000273")]
		[Cpp2IlInjected.Address(RVA = "0x70168B0", Offset = "0x70154B0", VA = "0x1870168B0", Slot = "19")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000027")]
	public event Action<EGNFIBKBHKP> CEJNGGHDFMA
	{
		[Cpp2IlInjected.Token(Token = "0x6000274")]
		[Cpp2IlInjected.Address(RVA = "0x70166D0", Offset = "0x70152D0", VA = "0x1870166D0", Slot = "20")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000275")]
		[Cpp2IlInjected.Address(RVA = "0x70170C0", Offset = "0x7015CC0", VA = "0x1870170C0", Slot = "21")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000028")]
	public event Action IDPABJPGLKN
	{
		[Cpp2IlInjected.Token(Token = "0x6000276")]
		[Cpp2IlInjected.Address(RVA = "0x7017020", Offset = "0x7015C20", VA = "0x187017020", Slot = "22")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000277")]
		[Cpp2IlInjected.Address(RVA = "0x7016EE0", Offset = "0x7015AE0", VA = "0x187016EE0", Slot = "23")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000029")]
	public event Action<EGNFIBKBHKP> NEPDBDGFAJF
	{
		[Cpp2IlInjected.Token(Token = "0x6000278")]
		[Cpp2IlInjected.Address(RVA = "0x70161B0", Offset = "0x7014DB0", VA = "0x1870161B0", Slot = "24")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000279")]
		[Cpp2IlInjected.Address(RVA = "0x7016960", Offset = "0x7015560", VA = "0x187016960", Slot = "25")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600027B")]
	[Cpp2IlInjected.Address(RVA = "0x7017E10", Offset = "0x7016A10", VA = "0x187017E10")]
	public CJBLPPELHFI(EGNFIBKBHKP JMMPGPEMBEI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600027C")]
	[Cpp2IlInjected.Address(RVA = "0x7016A10", Offset = "0x7015610", VA = "0x187016A10", Slot = "31")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000281")]
	[Cpp2IlInjected.Address(RVA = "0x70177F0", Offset = "0x70163F0", VA = "0x1870177F0", Slot = "30")]
	public void PNCCPJNBDLO(EGNFIBKBHKP EGKBIIFMAKK, bool NOFJHFMCCCG = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000282")]
	[Cpp2IlInjected.Address(RVA = "0x7016260", Offset = "0x7014E60", VA = "0x187016260", Slot = "6")]
	public void ALBBMPLIGNA(EGNFIBKBHKP JGJEMIAJOCC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000283")]
	[Cpp2IlInjected.Address(RVA = "0x7016B50", Offset = "0x7015750", VA = "0x187016B50", Slot = "7")]
	public void GIGHJMFOELG(EGNFIBKBHKP JGJEMIAJOCC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000284")]
	[Cpp2IlInjected.Address(RVA = "0x7016DD0", Offset = "0x70159D0", VA = "0x187016DD0", Slot = "4")]
	public void HEHNFNCPIPE(EGNFIBKBHKP JMMPGPEMBEI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000285")]
	[Cpp2IlInjected.Address(RVA = "0x70164D0", Offset = "0x70150D0", VA = "0x1870164D0", Slot = "5")]
	public void BHFKIMOCFLD(EGNFIBKBHKP JMMPGPEMBEI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000286")]
	[Cpp2IlInjected.Address(RVA = "0x7016060", Offset = "0x7014C60", VA = "0x187016060")]
	private void AHDHPKCMEEH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000287")]
	[Cpp2IlInjected.Address(RVA = "0x7017670", Offset = "0x7016270", VA = "0x187017670")]
	private void OFMDFMBDIGK(EGNFIBKBHKP JGJEMIAJOCC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000288")]
	[Cpp2IlInjected.Address(RVA = "0x7017530", Offset = "0x7016130", VA = "0x187017530")]
	private void NLBBIOIPPKK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000289")]
	[Cpp2IlInjected.Address(RVA = "0x7016780", Offset = "0x7015380", VA = "0x187016780")]
	private void CLJHGLACKLH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600028A")]
	[Cpp2IlInjected.Address(RVA = "0x7017350", Offset = "0x7015F50", VA = "0x187017350")]
	private void MMGEHLMEPHP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600028B")]
	[Cpp2IlInjected.Address(RVA = "0x7016610", Offset = "0x7015210", VA = "0x187016610")]
	[CompilerGenerated]
	private object BJCIPBGPCFP()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200002A")]
internal static class OJCBGGNLJDD
{
	[Cpp2IlInjected.Token(Token = "0x600028C")]
	[Cpp2IlInjected.Address(RVA = "0x702AA70", Offset = "0x7029670", VA = "0x18702AA70")]
	public static MHNCKMPCLKL ELABCBFKGBN(this EGNFIBKBHKP JPJGGLNFIBC)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200002B")]
internal sealed class IEHBMEIGLBB : HKNHJFOIGLD, CKOKBJLNIGM
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000045")]
	private readonly MDHDELBPMHJ JMMPGPEMBEI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000046")]
	private readonly DEHOPLDGAFI<EGNFIBKBHKP> DILGDIDIFDI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000047")]
	private bool KGPCNGCFPBP;

	[Cpp2IlInjected.Token(Token = "0x1700009A")]
	public DEHOPLDGAFI<EGNFIBKBHKP> MCEPHLBCNOM
	{
		[Cpp2IlInjected.Token(Token = "0x600028D")]
		[Cpp2IlInjected.Address(RVA = "0x865990", Offset = "0x864590", VA = "0x180865990", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700009B")]
	public Vector3 KHKHPEILLBD
	{
		[Cpp2IlInjected.Token(Token = "0x600028E")]
		[Cpp2IlInjected.Address(RVA = "0x701EB70", Offset = "0x701D770", VA = "0x18701EB70", Slot = "6")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700009C")]
	public Vector3 BPONHOGLMCE
	{
		[Cpp2IlInjected.Token(Token = "0x600028F")]
		[Cpp2IlInjected.Address(RVA = "0x701E4E0", Offset = "0x701D0E0", VA = "0x18701E4E0", Slot = "7")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700009D")]
	private Vector3 CDMANJEHLKL
	{
		[Cpp2IlInjected.Token(Token = "0x6000293")]
		[Cpp2IlInjected.Address(RVA = "0x701ED20", Offset = "0x701D920", VA = "0x18701ED20")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700009E")]
	public EGNFIBKBHKP DIGGGKJGKNG
	{
		[Cpp2IlInjected.Token(Token = "0x6000294")]
		[Cpp2IlInjected.Address(RVA = "0x701EC10", Offset = "0x701D810", VA = "0x18701EC10", Slot = "5")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000290")]
	[Cpp2IlInjected.Address(RVA = "0x701F190", Offset = "0x701DD90", VA = "0x18701F190")]
	public IEHBMEIGLBB(EGNFIBKBHKP JMMPGPEMBEI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000291")]
	[Cpp2IlInjected.Address(RVA = "0x701EBA0", Offset = "0x701D7A0", VA = "0x18701EBA0", Slot = "8")]
	public void KACOKNOCLCB(EGNFIBKBHKP DELFIACNBGK, object GBENACPKFNA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000292")]
	[Cpp2IlInjected.Address(RVA = "0x701ECC0", Offset = "0x701D8C0", VA = "0x18701ECC0", Slot = "9")]
	public void LKHNBOGOFBE(object GBENACPKFNA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000295")]
	[Cpp2IlInjected.Address(RVA = "0x701E7E0", Offset = "0x701D3E0", VA = "0x18701E7E0")]
	private Vector3 EPLGKFNNGFH()
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000296")]
	[Cpp2IlInjected.Address(RVA = "0x701EE00", Offset = "0x701DA00", VA = "0x18701EE00")]
	private void PCLCNMEACJJ(EGNFIBKBHKP CDOLNFGKGPP)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002C")]
internal static class IKKIDGEIBBA
{
	[Cpp2IlInjected.Token(Token = "0x6000297")]
	[Cpp2IlInjected.Address(RVA = "0x701F290", Offset = "0x701DE90", VA = "0x18701F290")]
	public static HKNHJFOIGLD AHAAEPNPPBM(this EGNFIBKBHKP JPJGGLNFIBC)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200002D")]
internal sealed class LINAIHBKJHJ : JLKOPJHNFKI, ADDPLOFLCBC
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000049")]
	private readonly MDHDELBPMHJ JMMPGPEMBEI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400004A")]
	private readonly OverridableVector3 LPLGLMOGFIG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400004B")]
	private readonly OverridableVector3 ABEPCGMOPPD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x400004C")]
	private float JNHGPIJJLML;

	[Cpp2IlInjected.FieldOffset(Offset = "0x44")]
	[Cpp2IlInjected.Token(Token = "0x400004D")]
	private float OOIILPOIPPH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x400004E")]
	private Vector3 GCMOCKDPCEC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x54")]
	[Cpp2IlInjected.Token(Token = "0x400004F")]
	private Vector3? MKMNCAFCPDO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x64")]
	[Cpp2IlInjected.Token(Token = "0x4000050")]
	private Quaternion? IPIMGOCDKPL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
	[Cpp2IlInjected.Token(Token = "0x4000051")]
	private bool CAKFCCDDJLA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x79")]
	[Cpp2IlInjected.Token(Token = "0x4000052")]
	private bool LFJILLGJCOJ;

	[Cpp2IlInjected.Token(Token = "0x1700009F")]
	public Vector3 LMNBHBJAJFM
	{
		[Cpp2IlInjected.Token(Token = "0x600029A")]
		[Cpp2IlInjected.Address(RVA = "0xD7D4C0", Offset = "0xD7C0C0", VA = "0x180D7D4C0", Slot = "7")]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x600029B")]
		[Cpp2IlInjected.Address(RVA = "0x701FDE0", Offset = "0x701E9E0", VA = "0x18701FDE0", Slot = "8")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A0")]
	public Vector3 HAIHKHGGPPP
	{
		[Cpp2IlInjected.Token(Token = "0x600029C")]
		[Cpp2IlInjected.Address(RVA = "0x7020AF0", Offset = "0x701F6F0", VA = "0x187020AF0", Slot = "9")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A1")]
	public float ECJECJPONJA
	{
		[Cpp2IlInjected.Token(Token = "0x600029D")]
		[Cpp2IlInjected.Address(RVA = "0x8D1440", Offset = "0x8D0040", VA = "0x1808D1440", Slot = "10")]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x600029E")]
		[Cpp2IlInjected.Address(RVA = "0x70205A0", Offset = "0x701F1A0", VA = "0x1870205A0")]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A2")]
	public float GOBLNFAJJOD
	{
		[Cpp2IlInjected.Token(Token = "0x600029F")]
		[Cpp2IlInjected.Address(RVA = "0x8D1550", Offset = "0x8D0150", VA = "0x1808D1550", Slot = "11")]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x60002A0")]
		[Cpp2IlInjected.Address(RVA = "0x70206B0", Offset = "0x701F2B0", VA = "0x1870206B0", Slot = "12")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A3")]
	public Vector3 PNJPKBMKLJM
	{
		[Cpp2IlInjected.Token(Token = "0x60002A1")]
		[Cpp2IlInjected.Address(RVA = "0x7020410", Offset = "0x701F010", VA = "0x187020410", Slot = "13")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A4")]
	public Quaternion NEDIJPEDJGG
	{
		[Cpp2IlInjected.Token(Token = "0x60002A2")]
		[Cpp2IlInjected.Address(RVA = "0x7020F10", Offset = "0x701FB10", VA = "0x187020F10", Slot = "14")]
		get
		{
			return default(Quaternion);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A5")]
	private Rigidbody CKFDKNLJFBH
	{
		[Cpp2IlInjected.Token(Token = "0x60002AA")]
		[Cpp2IlInjected.Address(RVA = "0x7022200", Offset = "0x7020E00", VA = "0x187022200")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400002A")]
	public event PADECADCPBE HAJOBMONHGF
	{
		[Cpp2IlInjected.Token(Token = "0x6000298")]
		[Cpp2IlInjected.Address(RVA = "0x7022160", Offset = "0x7020D60", VA = "0x187022160", Slot = "5")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000299")]
		[Cpp2IlInjected.Address(RVA = "0x7021F10", Offset = "0x7020B10", VA = "0x187021F10", Slot = "6")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60002A3")]
	[Cpp2IlInjected.Address(RVA = "0x7022330", Offset = "0x7020F30", VA = "0x187022330")]
	public LINAIHBKJHJ(EGNFIBKBHKP JMMPGPEMBEI, [In] CCGIPMCDDGA JGFKFMMOAJO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002A4")]
	[Cpp2IlInjected.Address(RVA = "0x7021FB0", Offset = "0x7020BB0", VA = "0x187021FB0", Slot = "17")]
	public void OLGGIMDAFGE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002A5")]
	[Cpp2IlInjected.Address(RVA = "0x701FAD0", Offset = "0x701E6D0", VA = "0x18701FAD0", Slot = "16")]
	public void BOFJEGKPIDK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002A6")]
	[Cpp2IlInjected.Address(RVA = "0x7022250", Offset = "0x7020E50", VA = "0x187022250", Slot = "19")]
	public void PMJCKMMFMFM(Rigidbody JJDGGMNFHIL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002A7")]
	[Cpp2IlInjected.Address(RVA = "0x7020760", Offset = "0x701F360", VA = "0x187020760", Slot = "20")]
	public void IECHDHOIHFH(Rigidbody JJDGGMNFHIL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002A8")]
	[Cpp2IlInjected.Address(RVA = "0x7020BF0", Offset = "0x701F7F0", VA = "0x187020BF0", Slot = "18")]
	public void KGOEDDJICMA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002A9")]
	[Cpp2IlInjected.Address(RVA = "0x701FF80", Offset = "0x701EB80", VA = "0x18701FF80", Slot = "21")]
	public void FIAFIGKJINB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002AB")]
	[Cpp2IlInjected.Address(RVA = "0x701FDE0", Offset = "0x701E9E0", VA = "0x18701FDE0")]
	private void EBLGAELLPOK(Vector3 IIPLJLPCLBC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002AC")]
	[Cpp2IlInjected.Address(RVA = "0x701FE90", Offset = "0x701EA90", VA = "0x18701FE90")]
	[Obsolete("This method is dangerous - the unity rigidbody is updated in a deferred manner and this world position may be stale")]
	private Vector3 EIJBOFHFLGK()
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x60002AD")]
	[Cpp2IlInjected.Address(RVA = "0x70205A0", Offset = "0x701F1A0", VA = "0x1870205A0")]
	private void HGGPGOFCCND(float IIPLJLPCLBC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002AE")]
	[Cpp2IlInjected.Address(RVA = "0x70206B0", Offset = "0x701F2B0", VA = "0x1870206B0")]
	private void HJPKGHLIFFG(float IIPLJLPCLBC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002AF")]
	[Cpp2IlInjected.Address(RVA = "0x7020950", Offset = "0x701F550", VA = "0x187020950")]
	private Vector3 JDILIHFCNEI()
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x60002B0")]
	[Cpp2IlInjected.Address(RVA = "0x701FBB0", Offset = "0x701E7B0", VA = "0x18701FBB0", Slot = "15")]
	public void DIODJNGDMDD((Quaternion rot, Vector3 moments) DAKHJKLEMDA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002B1")]
	[Cpp2IlInjected.Address(RVA = "0x7020D90", Offset = "0x701F990", VA = "0x187020D90")]
	private Quaternion LHDCBNNOCLO()
	{
		return default(Quaternion);
	}

	[Cpp2IlInjected.Token(Token = "0x60002B2")]
	[Cpp2IlInjected.Address(RVA = "0x7021E40", Offset = "0x7020A40", VA = "0x187021E40")]
	public void MMEADAKNGAM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002B3")]
	[Cpp2IlInjected.Address(RVA = "0x7021090", Offset = "0x701FC90", VA = "0x187021090", Slot = "4")]
	public (float, Vector3) MMEADAKNGAM(Rigidbody NKNEDKFEPKM)
	{
		return default((float, Vector3));
	}
}
[Cpp2IlInjected.Token(Token = "0x200002E")]
internal static class FNFGBGPMANE
{
	[Cpp2IlInjected.Token(Token = "0x60002B4")]
	[Cpp2IlInjected.Address(RVA = "0x70190F0", Offset = "0x7017CF0", VA = "0x1870190F0")]
	public static JLKOPJHNFKI OFLPDMMJFAF(this EGNFIBKBHKP JPJGGLNFIBC)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200002F")]
internal sealed class AMLICLGOBKB : CJNOICOENPF
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000053")]
	private readonly MDHDELBPMHJ JMMPGPEMBEI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000054")]
	private readonly IHJBDENMBEB NJMAOGGHCOD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000055")]
	private readonly GPOLNCCKNBK NKHEJILBBLG;

	[Cpp2IlInjected.Token(Token = "0x170000A6")]
	public bool LGGFIJLLFCM
	{
		[Cpp2IlInjected.Token(Token = "0x60002B5")]
		[Cpp2IlInjected.Address(RVA = "0xF08810", Offset = "0xF07410", VA = "0x180F08810", Slot = "10")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A7")]
	public GPOLNCCKNBK LJNIKPKCBKO
	{
		[Cpp2IlInjected.Token(Token = "0x60002B6")]
		[Cpp2IlInjected.Address(RVA = "0x8E1AD0", Offset = "0x8E06D0", VA = "0x1808E1AD0", Slot = "11")]
		get
		{
			return default(GPOLNCCKNBK);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60002B7")]
	[Cpp2IlInjected.Address(RVA = "0x70150D0", Offset = "0x7013CD0", VA = "0x1870150D0")]
	public AMLICLGOBKB(EGNFIBKBHKP JMMPGPEMBEI, [In] CCGIPMCDDGA JGFKFMMOAJO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002B8")]
	[Cpp2IlInjected.Address(RVA = "0x7014AB0", Offset = "0x70136B0", VA = "0x187014AB0", Slot = "4")]
	public void BCJIBCPCLJO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002B9")]
	[Cpp2IlInjected.Address(RVA = "0x7015030", Offset = "0x7013C30", VA = "0x187015030")]
	private bool PGGPLEOPBGP()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002BA")]
	[Cpp2IlInjected.Address(RVA = "0x7014D40", Offset = "0x7013940", VA = "0x187014D40", Slot = "5")]
	public void GBHOPLHFBHM(object GBENACPKFNA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002BB")]
	[Cpp2IlInjected.Address(RVA = "0x7015000", Offset = "0x7013C00", VA = "0x187015000", Slot = "6")]
	public void MGGLHFPPBGN(object GBENACPKFNA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002BC")]
	[Cpp2IlInjected.Address(RVA = "0x7014B80", Offset = "0x7013780", VA = "0x187014B80", Slot = "9")]
	public void BDDNLKOPENA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002BD")]
	[Cpp2IlInjected.Address(RVA = "0x7014D70", Offset = "0x7013970", VA = "0x187014D70")]
	private void IHJHDGNPKPB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002BE")]
	[Cpp2IlInjected.Address(RVA = "0x7014E90", Offset = "0x7013A90", VA = "0x187014E90")]
	private void MBAIKEGLMCN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002BF")]
	[Cpp2IlInjected.Address(RVA = "0x7014D00", Offset = "0x7013900", VA = "0x187014D00", Slot = "8")]
	public void COCEOOPPNJP(EGNFIBKBHKP JMMPGPEMBEI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002C0")]
	[Cpp2IlInjected.Address(RVA = "0x7014CC0", Offset = "0x70138C0", VA = "0x187014CC0", Slot = "7")]
	public void BDEHACNBHEN(EGNFIBKBHKP JMMPGPEMBEI)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000030")]
internal sealed class DOCJLEAKKMK : BFAJBPGIDNL
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000057")]
	private readonly MDHDELBPMHJ JMMPGPEMBEI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000058")]
	private readonly IHJBDENMBEB EDNCIPCNIJA;

	[Cpp2IlInjected.Token(Token = "0x170000A8")]
	public bool PHMLJIAJDCC
	{
		[Cpp2IlInjected.Token(Token = "0x60002C3")]
		[Cpp2IlInjected.Address(RVA = "0x7018D10", Offset = "0x7017910", VA = "0x187018D10", Slot = "6")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400002B")]
	public event PADECADCPBE JPCEHDELPPJ
	{
		[Cpp2IlInjected.Token(Token = "0x60002C1")]
		[Cpp2IlInjected.Address(RVA = "0x7018C00", Offset = "0x7017800", VA = "0x187018C00", Slot = "4")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60002C2")]
		[Cpp2IlInjected.Address(RVA = "0x7018DC0", Offset = "0x70179C0", VA = "0x187018DC0", Slot = "5")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60002C4")]
	[Cpp2IlInjected.Address(RVA = "0x7019000", Offset = "0x7017C00", VA = "0x187019000")]
	public DOCJLEAKKMK(EGNFIBKBHKP JMMPGPEMBEI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002C5")]
	[Cpp2IlInjected.Address(RVA = "0x7018BF0", Offset = "0x70177F0", VA = "0x187018BF0", Slot = "7")]
	public void AEGKOCEMEGJ(object GBENACPKFNA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002C6")]
	[Cpp2IlInjected.Address(RVA = "0x7018F70", Offset = "0x7017B70", VA = "0x187018F70", Slot = "8")]
	public void PEFODCFIPOM(object GBENACPKFNA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002C7")]
	[Cpp2IlInjected.Address(RVA = "0x7018E60", Offset = "0x7017A60", VA = "0x187018E60", Slot = "9")]
	public void OPGIAECBLAE(object GBENACPKFNA, bool KBFDDAHABNO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002C8")]
	[Cpp2IlInjected.Address(RVA = "0x7018CD0", Offset = "0x70178D0", VA = "0x187018CD0", Slot = "12")]
	public void IELDODJOEHA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002C9")]
	[Cpp2IlInjected.Address(RVA = "0x7018F80", Offset = "0x7017B80", VA = "0x187018F80", Slot = "10")]
	public void PMJCKMMFMFM(Rigidbody IGFNCGLOHFM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002CA")]
	[Cpp2IlInjected.Address(RVA = "0x7018CA0", Offset = "0x70178A0", VA = "0x187018CA0", Slot = "11")]
	public void IECHDHOIHFH(Rigidbody JJDGGMNFHIL)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000031")]
internal sealed class HAIFLDBNDBK : ICANFEEPONI, IPKAFMFLAHB, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400005A")]
	private readonly MDHDELBPMHJ JMMPGPEMBEI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400005B")]
	private PhotonView EFEMGJMOAOE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400005C")]
	private bool KGCNKMOJLFA;

	[Cpp2IlInjected.Token(Token = "0x170000A9")]
	public PhotonView MDPLCMMAAIE
	{
		[Cpp2IlInjected.Token(Token = "0x60002CD")]
		[Cpp2IlInjected.Address(RVA = "0x867590", Offset = "0x866190", VA = "0x180867590", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000AA")]
	public bool OCAHNLHHELK
	{
		[Cpp2IlInjected.Token(Token = "0x60002CE")]
		[Cpp2IlInjected.Address(RVA = "0x701E300", Offset = "0x701CF00", VA = "0x18701E300", Slot = "7")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000AB")]
	public bool EEPDKLKKOLN
	{
		[Cpp2IlInjected.Token(Token = "0x60002CF")]
		[Cpp2IlInjected.Address(RVA = "0xA7EAB0", Offset = "0xA7D6B0", VA = "0x180A7EAB0", Slot = "8")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400002C")]
	public event PADECADCPBE JPIIIJEFFCH
	{
		[Cpp2IlInjected.Token(Token = "0x60002CB")]
		[Cpp2IlInjected.Address(RVA = "0x701E0F0", Offset = "0x701CCF0", VA = "0x18701E0F0", Slot = "5")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60002CC")]
		[Cpp2IlInjected.Address(RVA = "0x701D8B0", Offset = "0x701C4B0", VA = "0x18701D8B0", Slot = "6")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60002D0")]
	[Cpp2IlInjected.Address(RVA = "0x701E320", Offset = "0x701CF20", VA = "0x18701E320")]
	public HAIFLDBNDBK(EGNFIBKBHKP JMMPGPEMBEI, [In] CCGIPMCDDGA JGFKFMMOAJO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002D1")]
	[Cpp2IlInjected.Address(RVA = "0x701D780", Offset = "0x701C380", VA = "0x18701D780", Slot = "9")]
	public void BCJIBCPCLJO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002D2")]
	[Cpp2IlInjected.Address(RVA = "0x701DAA0", Offset = "0x701C6A0", VA = "0x18701DAA0", Slot = "12")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002D3")]
	[Cpp2IlInjected.Address(RVA = "0x701DD10", Offset = "0x701C910", VA = "0x18701DD10", Slot = "10")]
	public void KGPEPBNPCNL(EGNFIBKBHKP DELFIACNBGK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002D4")]
	[Cpp2IlInjected.Address(RVA = "0x701DBA0", Offset = "0x701C7A0", VA = "0x18701DBA0", Slot = "11")]
	public void JOCHOOBKGCN(EGNFIBKBHKP DELFIACNBGK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002D5")]
	[Cpp2IlInjected.Address(RVA = "0x701E190", Offset = "0x701CD90", VA = "0x18701E190")]
	private void NOHHKCCDCMM(PhotonView FELIODCOEEI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002D6")]
	[Cpp2IlInjected.Address(RVA = "0x701D950", Offset = "0x701C550", VA = "0x18701D950")]
	private void CIHOKKEHNLN(NIJCOMOFOFB NCEHDJIBJJE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002D7")]
	[Cpp2IlInjected.Address(RVA = "0x701DE80", Offset = "0x701CA80", VA = "0x18701DE80")]
	private void KNIGINOEFKE(PhotonView CIJLFENOIHG)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000032")]
internal static class CJHJAHPEOPK
{
	[Cpp2IlInjected.Token(Token = "0x60002D8")]
	[Cpp2IlInjected.Address(RVA = "0x7017ED0", Offset = "0x7016AD0", VA = "0x187017ED0")]
	public static ICANFEEPONI HAKBDKOPLAD(this EGNFIBKBHKP JPJGGLNFIBC)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000033")]
internal sealed class BGGGGOILGAF : IDNMICNIEEM
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400005D")]
	private readonly MDHDELBPMHJ JMMPGPEMBEI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400005E")]
	private RigidbodyConstraints BONEEFDMJEH;

	[Cpp2IlInjected.Token(Token = "0x170000AC")]
	public bool FAFDAGIIDHL
	{
		[Cpp2IlInjected.Token(Token = "0x60002D9")]
		[Cpp2IlInjected.Address(RVA = "0xD04530", Offset = "0xD03130", VA = "0x180D04530", Slot = "4")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x60002DA")]
		[Cpp2IlInjected.Address(RVA = "0x44D2D00", Offset = "0x44D1900", VA = "0x1844D2D00", Slot = "5")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000AD")]
	public bool MOAJDDFOCJO
	{
		[Cpp2IlInjected.Token(Token = "0x60002DB")]
		[Cpp2IlInjected.Address(RVA = "0xF5A540", Offset = "0xF59140", VA = "0x180F5A540", Slot = "6")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x60002DC")]
		[Cpp2IlInjected.Address(RVA = "0x44D2CF0", Offset = "0x44D18F0", VA = "0x1844D2CF0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000AE")]
	public RigidbodyConstraints LAFPPCHIKBM
	{
		[Cpp2IlInjected.Token(Token = "0x60002DD")]
		[Cpp2IlInjected.Address(RVA = "0x867580", Offset = "0x866180", VA = "0x180867580", Slot = "7")]
		get
		{
			return default(RigidbodyConstraints);
		}
		[Cpp2IlInjected.Token(Token = "0x60002DE")]
		[Cpp2IlInjected.Address(RVA = "0x70154F0", Offset = "0x70140F0", VA = "0x1870154F0", Slot = "8")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60002DF")]
	[Cpp2IlInjected.Address(RVA = "0x7015650", Offset = "0x7014250", VA = "0x187015650")]
	public BGGGGOILGAF(EGNFIBKBHKP JMMPGPEMBEI, [In] CCGIPMCDDGA JGFKFMMOAJO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002E0")]
	[Cpp2IlInjected.Address(RVA = "0x7015620", Offset = "0x7014220", VA = "0x187015620", Slot = "9")]
	public void PMJCKMMFMFM(Rigidbody JJDGGMNFHIL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002E1")]
	[Cpp2IlInjected.Address(RVA = "0x70154C0", Offset = "0x70140C0", VA = "0x1870154C0", Slot = "10")]
	public void IECHDHOIHFH(Rigidbody JJDGGMNFHIL)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000034")]
internal sealed class PKACKLMJPKJ : OFABJBGMCEJ
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000061")]
	private readonly EGNFIBKBHKP JMMPGPEMBEI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000062")]
	private float EPCPCMHEJBJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
	[Cpp2IlInjected.Token(Token = "0x4000063")]
	private float EGGDIMEEDGF;

	[Cpp2IlInjected.Token(Token = "0x170000AF")]
	public float EEJCJOIJJON
	{
		[Cpp2IlInjected.Token(Token = "0x60002E3")]
		[Cpp2IlInjected.Address(RVA = "0x8D15D0", Offset = "0x8D01D0", VA = "0x1808D15D0", Slot = "4")]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x60002E4")]
		[Cpp2IlInjected.Address(RVA = "0x702AC00", Offset = "0x7029800", VA = "0x18702AC00", Slot = "5")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B0")]
	public float HHODGMIMJEL
	{
		[Cpp2IlInjected.Token(Token = "0x60002E5")]
		[Cpp2IlInjected.Address(RVA = "0x8D1590", Offset = "0x8D0190", VA = "0x1808D1590", Slot = "6")]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x60002E6")]
		[Cpp2IlInjected.Address(RVA = "0x702AB30", Offset = "0x7029730", VA = "0x18702AB30", Slot = "7")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60002E2")]
	[Cpp2IlInjected.Address(RVA = "0x702ADC0", Offset = "0x70299C0", VA = "0x18702ADC0")]
	public PKACKLMJPKJ(EGNFIBKBHKP JMMPGPEMBEI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002E7")]
	[Cpp2IlInjected.Address(RVA = "0x702AD70", Offset = "0x7029970", VA = "0x18702AD70", Slot = "8")]
	public void PMJCKMMFMFM(Rigidbody JJDGGMNFHIL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002E8")]
	[Cpp2IlInjected.Address(RVA = "0x702ACD0", Offset = "0x70298D0", VA = "0x18702ACD0", Slot = "9")]
	public void IECHDHOIHFH(Rigidbody JJDGGMNFHIL)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000035")]
internal sealed class LOOJMPNMLCI : OOPCMGEAGDH
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000065")]
	private readonly MDHDELBPMHJ JMMPGPEMBEI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000066")]
	private bool PAIPOIOAPPE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x21")]
	[Cpp2IlInjected.Token(Token = "0x4000067")]
	private bool FBFMLOIHCHP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
	[Cpp2IlInjected.Token(Token = "0x4000068")]
	private int KDFFBEFBPLK;

	[Cpp2IlInjected.Token(Token = "0x170000B1")]
	private Rigidbody CKFDKNLJFBH
	{
		[Cpp2IlInjected.Token(Token = "0x60002EB")]
		[Cpp2IlInjected.Address(RVA = "0x7022200", Offset = "0x7020E00", VA = "0x187022200")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B2")]
	private bool KBCHKLPJOIB
	{
		[Cpp2IlInjected.Token(Token = "0x60002EC")]
		[Cpp2IlInjected.Address(RVA = "0x7022900", Offset = "0x7021500", VA = "0x187022900")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B3")]
	private EGNFIBKBHKP BBKNDFHDFHL
	{
		[Cpp2IlInjected.Token(Token = "0x60002ED")]
		[Cpp2IlInjected.Address(RVA = "0x7022EA0", Offset = "0x7021AA0", VA = "0x187022EA0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B4")]
	private bool IGBHMJICOCE
	{
		[Cpp2IlInjected.Token(Token = "0x60002EE")]
		[Cpp2IlInjected.Address(RVA = "0x70226B0", Offset = "0x70212B0", VA = "0x1870226B0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400002D")]
	public event PADECADCPBE KLHGFHNHGEH
	{
		[Cpp2IlInjected.Token(Token = "0x60002E9")]
		[Cpp2IlInjected.Address(RVA = "0x70229C0", Offset = "0x70215C0", VA = "0x1870229C0", Slot = "4")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60002EA")]
		[Cpp2IlInjected.Address(RVA = "0x7022920", Offset = "0x7021520", VA = "0x187022920", Slot = "5")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60002EF")]
	[Cpp2IlInjected.Address(RVA = "0x7022F00", Offset = "0x7021B00", VA = "0x187022F00")]
	public LOOJMPNMLCI(EGNFIBKBHKP JMMPGPEMBEI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002F0")]
	[Cpp2IlInjected.Address(RVA = "0x7022620", Offset = "0x7021220", VA = "0x187022620", Slot = "6")]
	public void BCJIBCPCLJO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002F1")]
	[Cpp2IlInjected.Address(RVA = "0x7022DF0", Offset = "0x70219F0", VA = "0x187022DF0", Slot = "8")]
	public void PGPCJECNCAA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002F2")]
	[Cpp2IlInjected.Address(RVA = "0x70227B0", Offset = "0x70213B0", VA = "0x1870227B0", Slot = "7")]
	public bool FGICBOJAMPD()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002F3")]
	[Cpp2IlInjected.Address(RVA = "0x7022E00", Offset = "0x7021A00", VA = "0x187022E00", Slot = "9")]
	public void PHFOJALJMOJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002F4")]
	[Cpp2IlInjected.Address(RVA = "0x7022710", Offset = "0x7021310", VA = "0x187022710", Slot = "11")]
	public void FCLCNJHCFEK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002F5")]
	[Cpp2IlInjected.Address(RVA = "0x7022A60", Offset = "0x7021660", VA = "0x187022A60", Slot = "10")]
	public void KAJPAKHEONK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002F6")]
	[Cpp2IlInjected.Address(RVA = "0x7022C10", Offset = "0x7021810", VA = "0x187022C10")]
	private bool KBACLBIOJHM()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002F7")]
	[Cpp2IlInjected.Address(RVA = "0x7022490", Offset = "0x7021090", VA = "0x187022490")]
	private void ANENEDDIDCG()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000036")]
internal sealed class BPGGAPHEMKP : ACOGMOKAGMB
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000069")]
	private readonly MDHDELBPMHJ JMMPGPEMBEI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400006A")]
	private readonly IHJBDENMBEB KGBEFHPGLEF;

	[Cpp2IlInjected.Token(Token = "0x170000B5")]
	public Rigidbody CKFDKNLJFBH
	{
		[Cpp2IlInjected.Token(Token = "0x60002F8")]
		[Cpp2IlInjected.Address(RVA = "0x867590", Offset = "0x866190", VA = "0x180867590", Slot = "4")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60002F9")]
		[Cpp2IlInjected.Address(RVA = "0x867D20", Offset = "0x866920", VA = "0x180867D20")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B6")]
	private bool IGBHMJICOCE
	{
		[Cpp2IlInjected.Token(Token = "0x60002FA")]
		[Cpp2IlInjected.Address(RVA = "0x7015790", Offset = "0x7014390", VA = "0x187015790")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B7")]
	public bool JAOOJFDIBIH
	{
		[Cpp2IlInjected.Token(Token = "0x60002FD")]
		[Cpp2IlInjected.Address(RVA = "0xF08810", Offset = "0xF07410", VA = "0x180F08810", Slot = "6")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60002FB")]
	[Cpp2IlInjected.Address(RVA = "0x7015EF0", Offset = "0x7014AF0", VA = "0x187015EF0")]
	public BPGGAPHEMKP(EGNFIBKBHKP JMMPGPEMBEI, [In] CCGIPMCDDGA JGFKFMMOAJO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002FC")]
	[Cpp2IlInjected.Address(RVA = "0x70156F0", Offset = "0x70142F0", VA = "0x1870156F0", Slot = "5")]
	public void BCJIBCPCLJO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002FE")]
	[Cpp2IlInjected.Address(RVA = "0x70159A0", Offset = "0x70145A0", VA = "0x1870159A0", Slot = "7")]
	public void ILHOGPAMLOI(object GBENACPKFNA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002FF")]
	[Cpp2IlInjected.Address(RVA = "0x70157F0", Offset = "0x70143F0", VA = "0x1870157F0", Slot = "8")]
	public void DFNPFAMILKL(object GBENACPKFNA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000300")]
	[Cpp2IlInjected.Address(RVA = "0x7015BC0", Offset = "0x70147C0", VA = "0x187015BC0", Slot = "9")]
	public void NCBMDPJNOND()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000301")]
	[Cpp2IlInjected.Address(RVA = "0x70159D0", Offset = "0x70145D0", VA = "0x1870159D0", Slot = "10")]
	public void KKJAOBOCDJB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000302")]
	[Cpp2IlInjected.Address(RVA = "0x7015820", Offset = "0x7014420", VA = "0x187015820", Slot = "11")]
	public void EKPAEIHJCIH()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000037")]
internal sealed class FPHMCICOHMC : PKGFJJHHDNP, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400006C")]
	private readonly MDHDELBPMHJ JMMPGPEMBEI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400006D")]
	private readonly IHJBDENMBEB HJPEAJPPHNK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400006E")]
	private float GHFICBPGDAF;

	[Cpp2IlInjected.Token(Token = "0x170000B8")]
	public INHEMIHIBFP DFIDBGCEBII
	{
		[Cpp2IlInjected.Token(Token = "0x6000303")]
		[Cpp2IlInjected.Address(RVA = "0x86A480", Offset = "0x869080", VA = "0x18086A480", Slot = "4")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000304")]
		[Cpp2IlInjected.Address(RVA = "0x869EF0", Offset = "0x868AF0", VA = "0x180869EF0", Slot = "5")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B9")]
	public EDACBNCGKFK LIODHEOELNH
	{
		[Cpp2IlInjected.Token(Token = "0x6000305")]
		[Cpp2IlInjected.Address(RVA = "0x867CF0", Offset = "0x8668F0", VA = "0x180867CF0", Slot = "6")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000306")]
		[Cpp2IlInjected.Address(RVA = "0x867CC0", Offset = "0x8668C0", VA = "0x180867CC0", Slot = "7")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000BA")]
	public Vector3 CDMANJEHLKL
	{
		[Cpp2IlInjected.Token(Token = "0x6000307")]
		[Cpp2IlInjected.Address(RVA = "0x701B1F0", Offset = "0x7019DF0", VA = "0x18701B1F0", Slot = "8")]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x6000308")]
		[Cpp2IlInjected.Address(RVA = "0x7019B20", Offset = "0x7018720", VA = "0x187019B20", Slot = "9")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000BB")]
	public Vector3 JPMEJPLLBEO
	{
		[Cpp2IlInjected.Token(Token = "0x6000309")]
		[Cpp2IlInjected.Address(RVA = "0x701B410", Offset = "0x701A010", VA = "0x18701B410", Slot = "10")]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x600030A")]
		[Cpp2IlInjected.Address(RVA = "0x701A190", Offset = "0x7018D90", VA = "0x18701A190", Slot = "11")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000BC")]
	public Vector3 JEAEJDIOEML
	{
		[Cpp2IlInjected.Token(Token = "0x600030B")]
		[Cpp2IlInjected.Address(RVA = "0x701AD00", Offset = "0x7019900", VA = "0x18701AD00", Slot = "12")]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x600030C")]
		[Cpp2IlInjected.Address(RVA = "0x701A220", Offset = "0x7018E20", VA = "0x18701A220", Slot = "13")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000BD")]
	public Vector3 FDBDBELGLPB
	{
		[Cpp2IlInjected.Token(Token = "0x600030D")]
		[Cpp2IlInjected.Address(RVA = "0x701B060", Offset = "0x7019C60", VA = "0x18701B060", Slot = "14")]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x600030E")]
		[Cpp2IlInjected.Address(RVA = "0x701ACD0", Offset = "0x70198D0", VA = "0x18701ACD0", Slot = "15")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000BE")]
	public float MOPMJLHOCCI
	{
		[Cpp2IlInjected.Token(Token = "0x600030F")]
		[Cpp2IlInjected.Address(RVA = "0x8D14B0", Offset = "0x8D00B0", VA = "0x1808D14B0", Slot = "16")]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x6000310")]
		[Cpp2IlInjected.Address(RVA = "0x7019A10", Offset = "0x7018610", VA = "0x187019A10", Slot = "17")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000BF")]
	public bool GHBJLIODJHF
	{
		[Cpp2IlInjected.Token(Token = "0x6000311")]
		[Cpp2IlInjected.Address(RVA = "0x18D7D40", Offset = "0x18D6940", VA = "0x1818D7D40", Slot = "18")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000C0")]
	private AIIECHHMHKF HFPLEGMLBIL
	{
		[Cpp2IlInjected.Token(Token = "0x6000326")]
		[Cpp2IlInjected.Address(RVA = "0x684C5B0", Offset = "0x684B1B0", VA = "0x18684C5B0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000C1")]
	private bool KBCHKLPJOIB
	{
		[Cpp2IlInjected.Token(Token = "0x6000327")]
		[Cpp2IlInjected.Address(RVA = "0x701A2E0", Offset = "0x7018EE0", VA = "0x18701A2E0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000312")]
	[Cpp2IlInjected.Address(RVA = "0x701C8A0", Offset = "0x701B4A0", VA = "0x18701C8A0")]
	public FPHMCICOHMC(EGNFIBKBHKP JMMPGPEMBEI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000313")]
	[Cpp2IlInjected.Address(RVA = "0x70197A0", Offset = "0x70183A0", VA = "0x1870197A0", Slot = "19")]
	public void BCJIBCPCLJO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000314")]
	[Cpp2IlInjected.Address(RVA = "0x701A130", Offset = "0x7018D30", VA = "0x18701A130", Slot = "36")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000315")]
	[Cpp2IlInjected.Address(RVA = "0x701C4E0", Offset = "0x701B0E0", VA = "0x18701C4E0", Slot = "28")]
	public void PMJCKMMFMFM(Rigidbody JJDGGMNFHIL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000316")]
	[Cpp2IlInjected.Address(RVA = "0xD3EBE0", Offset = "0xD3D7E0", VA = "0x180D3EBE0", Slot = "20")]
	public void EMIJCINLNHK(object GBENACPKFNA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000317")]
	[Cpp2IlInjected.Address(RVA = "0xD3E700", Offset = "0xD3D300", VA = "0x180D3E700", Slot = "30")]
	public void JOJHBDPLGHL(object GBENACPKFNA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000318")]
	[Cpp2IlInjected.Address(RVA = "0x701C300", Offset = "0x701AF00", VA = "0x18701C300", Slot = "35")]
	public Vector3 PHAPDKMGHBI(Vector3 HPLCNCFNOCB)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000319")]
	[Cpp2IlInjected.Address(RVA = "0x7019850", Offset = "0x7018450", VA = "0x187019850", Slot = "34")]
	public Vector3 BOLPKKOBOEM(Vector3 AANPGIPGGCD)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x600031A")]
	[Cpp2IlInjected.Address(RVA = "0x70197A0", Offset = "0x70183A0", VA = "0x1870197A0", Slot = "27")]
	public void GBOMHIENMBH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600031B")]
	[Cpp2IlInjected.Address(RVA = "0x70195A0", Offset = "0x70181A0", VA = "0x1870195A0", Slot = "25")]
	public void AJABIOHJCJL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600031C")]
	[Cpp2IlInjected.Address(RVA = "0x701B3B0", Offset = "0x7019FB0", VA = "0x18701B3B0", Slot = "24")]
	public void MLHLKKDAIEE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600031D")]
	[Cpp2IlInjected.Address(RVA = "0x701AA90", Offset = "0x7019690", VA = "0x18701AA90", Slot = "33")]
	public void HMNHDGDMDAE(Vector3 AJDEPJADDIH, Vector3 MAEPOHBIICK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600031E")]
	[Cpp2IlInjected.Address(RVA = "0x701A1C0", Offset = "0x7018DC0", VA = "0x18701A1C0", Slot = "32")]
	public void FEIELGKMBHN(Vector3 PAHGAPJJGCH, Vector3 EGODONBGLKF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600031F")]
	[Cpp2IlInjected.Address(RVA = "0x701BB50", Offset = "0x701A750", VA = "0x18701BB50", Slot = "31")]
	public void NBOHEJKAJEC(Vector3 MFMBALHFABC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000320")]
	[Cpp2IlInjected.Address(RVA = "0x7019BE0", Offset = "0x70187E0", VA = "0x187019BE0", Slot = "22")]
	public void DPKPHGABCLN(JDPIALONKJP JIPJBNBKBLG, Vector3 NKHOFGAANEK, float EDHDLGGJOCE, float PKDMCAHEPPF = 8f, float FFHCMFMNDIM = 1f)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000321")]
	[Cpp2IlInjected.Address(RVA = "0x701C610", Offset = "0x701B210", VA = "0x18701C610", Slot = "21")]
	public void PPAAECDKFNC(OKFMPDPEOKJ HHBPGGPPJEP, Vector3 BGIPBKEALAM, float FDECAJPPJOA = float.PositiveInfinity)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000322")]
	[Cpp2IlInjected.Address(RVA = "0x70191B0", Offset = "0x7017DB0", VA = "0x1870191B0", Slot = "23")]
	[Obsolete("Deprecated. Still exists to support deprecated CV2 chips. Use ApplyAngularVelocityChange.")]
	public void ABEANEABNLI(OKFMPDPEOKJ HHBPGGPPJEP, Vector3 GPEICHFGELO, float HLFLCONGPIA = 7f, float EKICCDEOMKG = 1f)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000323")]
	[Cpp2IlInjected.Address(RVA = "0xE507E0", Offset = "0xE4F3E0", VA = "0x180E507E0")]
	private static void NGEHBFFJAEP(Vector3 IFAKEJMGKPK, Vector3 BCLJLGDCOIN, [Out] Vector3 KDKNDKNLHIP, [Out] Vector3 KEODOPLKFDN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000324")]
	[Cpp2IlInjected.Address(RVA = "0x701A300", Offset = "0x7018F00", VA = "0x18701A300", Slot = "29")]
	public Vector3 HEHLNGGHFJC(Vector3 IFAKEJMGKPK)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000325")]
	[Cpp2IlInjected.Address(RVA = "0x701BCF0", Offset = "0x701A8F0", VA = "0x18701BCF0", Slot = "26")]
	public void NMMBIONOOKB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000328")]
	[Cpp2IlInjected.Address(RVA = "0x7019A10", Offset = "0x7018610", VA = "0x187019A10")]
	private void EGCNPGKMDDN(float IIPLJLPCLBC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000329")]
	[Cpp2IlInjected.Address(RVA = "0x7019600", Offset = "0x7018200", VA = "0x187019600")]
	private void BBKNMBGFFNI(Vector3 BGIPBKEALAM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600032A")]
	[Cpp2IlInjected.Address(RVA = "0x701A860", Offset = "0x7019460", VA = "0x18701A860")]
	private Vector3 HKIOEFBIPLM()
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x600032B")]
	[Cpp2IlInjected.Address(RVA = "0x701A3E0", Offset = "0x7018FE0", VA = "0x18701A3E0")]
	private void HKHANEAMIOF(Vector3 AANPGIPGGCD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600032C")]
	[Cpp2IlInjected.Address(RVA = "0x701AED0", Offset = "0x7019AD0", VA = "0x18701AED0")]
	private Vector3 KHDGCHKELJI()
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x600032D")]
	[Cpp2IlInjected.Address(RVA = "0x701BE80", Offset = "0x701AA80", VA = "0x18701BE80")]
	private void OHKAEECHHAE(Vector3 IIPLJLPCLBC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600032E")]
	[Cpp2IlInjected.Address(RVA = "0x701B5A0", Offset = "0x701A1A0", VA = "0x18701B5A0")]
	private void NANBNOCFDAL(Vector3 AANPGIPGGCD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600032F")]
	[Cpp2IlInjected.Address(RVA = "0x701A9E0", Offset = "0x70195E0", VA = "0x18701A9E0")]
	private void HLONOGODJAN()
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
