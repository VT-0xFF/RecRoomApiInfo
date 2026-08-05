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
using RecRoom.DataLayer.Registration;
using RecRoom.Logging.Attributes;
using RecRoom.ObjectModel;
using RecRoom.Utils.OverridableFields;
using UnityEngine;
using UnityEngine.Serialization;

[assembly: AssemblyVersion("0.0.0.0")]
namespace _LogRegistration.RecRoom_Rbex_Runtime
{
	[Cpp2IlInjected.Token(Token = "0x2000002")]
	[CompilerGenerated]
	[RecRoom.Logging.Attributes.Preserve]
	public class LogRegistrationIndex : CCAGPMFGEMN
	{
		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(RVA = "0x8066EA0", Offset = "0x80658A0", VA = "0x188066EA0", Slot = "4")]
		public override void BLLBFFICICF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0x9D7E50", Offset = "0x9D6850", VA = "0x1809D7E50")]
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
	public class _AssemblyIndex : AssemblyIndex
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000001")]
		private int[] localIndices0;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000002")]
		private ServiceBitset bitset0;

		[Cpp2IlInjected.Token(Token = "0x17000001")]
		public override string[] ServiceCategories
		{
			[Cpp2IlInjected.Token(Token = "0x6000003")]
			[Cpp2IlInjected.Address(RVA = "0x9AED50", Offset = "0x9AD750", VA = "0x1809AED50", Slot = "4")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x1F7EA40", Offset = "0x1F7D440", VA = "0x181F7EA40", Slot = "5")]
		public override void SetServiceCategoryIndices(List<int> globalFromLocalIndices)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x806D500", Offset = "0x806BF00", VA = "0x18806D500")]
		private void IPCGMJBOKKK(IServiceRegistration registry)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x806D810", Offset = "0x806C210", VA = "0x18806D810", Slot = "6")]
		public override void RegisterServices(IServiceRegistration registry, [In] ServiceBitsetFilter filter)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x806D870", Offset = "0x806C270", VA = "0x18806D870")]
		public _AssemblyIndex()
		{
		}
	}
}
namespace RecRoom
{
	[Cpp2IlInjected.Token(Token = "0x2000004")]
	[DisallowMultipleComponent]
	public sealed class RigidbodyEx : MonoBehaviour, COGOJKBIHHJ, BEPIEELIFLK, FAIPNKEBNEL
	{
		[Cpp2IlInjected.Token(Token = "0x4000004")]
		private static readonly LMPJBEBLCLM EEMICCJEPEB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000005")]
		private bool AEOLPDOABDA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000006")]
		private AEGDBIMJAKG DDDAPFOHBFK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000007")]
		[IFFOMBOELJM(PLKNMOLBJIE.Self, false, false, false)]
		[SerializeField]
		private Rigidbody unityRigidbody;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000008")]
		[SerializeField]
		[IFFOMBOELJM(PLKNMOLBJIE.SelfAndParent, true, false, false)]
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
		private FDEOGDPKFCL physicsInterpolation;

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

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000010")]
		private Transform JHDIDKNNKHE;

		[Cpp2IlInjected.Token(Token = "0x17000002")]
		internal AEGDBIMJAKG BEPMIGHKPMM
		{
			[Cpp2IlInjected.Token(Token = "0x6000008")]
			[Cpp2IlInjected.Address(RVA = "0x80690A0", Offset = "0x8067AA0", VA = "0x1880690A0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000003")]
		private AEGDBIMJAKG HCDDDEEOFND
		{
			[Cpp2IlInjected.Token(Token = "0x6000009")]
			[Cpp2IlInjected.Address(RVA = "0x9B5560", Offset = "0x9B3F60", VA = "0x1809B5560", Slot = "6")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000004")]
		public int BLOGALEBJJB
		{
			[Cpp2IlInjected.Token(Token = "0x600001E")]
			[Cpp2IlInjected.Address(RVA = "0x806AA10", Offset = "0x8069410", VA = "0x18806AA10")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000005")]
		public RigidbodyEx MJAPJDFOIAL
		{
			[Cpp2IlInjected.Token(Token = "0x6000020")]
			[Cpp2IlInjected.Address(RVA = "0x806AD70", Offset = "0x8069770", VA = "0x18806AD70")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000006")]
		public RigidbodyEx LKAEGJLGAIG
		{
			[Cpp2IlInjected.Token(Token = "0x6000021")]
			[Cpp2IlInjected.Address(RVA = "0x806ACB0", Offset = "0x80696B0", VA = "0x18806ACB0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000007")]
		public RigidbodyEx HGBJMKAPAJA
		{
			[Cpp2IlInjected.Token(Token = "0x6000022")]
			[Cpp2IlInjected.Address(RVA = "0x806B970", Offset = "0x806A370", VA = "0x18806B970")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000023")]
			[Cpp2IlInjected.Address(RVA = "0x806CE70", Offset = "0x806B870", VA = "0x18806CE70")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000008")]
		public bool NDDOGAFPPEN
		{
			[Cpp2IlInjected.Token(Token = "0x6000024")]
			[Cpp2IlInjected.Address(RVA = "0x7CDA810", Offset = "0x7CD9210", VA = "0x187CDA810", Slot = "11")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000025")]
			[Cpp2IlInjected.Address(RVA = "0x7CD8C50", Offset = "0x7CD7650", VA = "0x187CD8C50")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000009")]
		public Transform GBIMAJCBFCJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000026")]
			[Cpp2IlInjected.Address(RVA = "0x1DB6370", Offset = "0x1DB4D70", VA = "0x181DB6370", Slot = "5")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000A")]
		public Transform EKMFFNLOLMF
		{
			[Cpp2IlInjected.Token(Token = "0x6000027")]
			[Cpp2IlInjected.Address(RVA = "0x1DB6370", Offset = "0x1DB4D70", VA = "0x181DB6370", Slot = "13")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000B")]
		public Transform OEODHDMIDIH
		{
			[Cpp2IlInjected.Token(Token = "0x6000028")]
			[Cpp2IlInjected.Address(RVA = "0x1DB6370", Offset = "0x1DB4D70", VA = "0x181DB6370", Slot = "14")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000C")]
		public JFFGEHLFDPP HBFBJDHEFMD
		{
			[Cpp2IlInjected.Token(Token = "0x6000029")]
			[Cpp2IlInjected.Address(RVA = "0x806AA70", Offset = "0x8069470", VA = "0x18806AA70")]
			get
			{
				return default(JFFGEHLFDPP);
			}
			[Cpp2IlInjected.Token(Token = "0x600002A")]
			[Cpp2IlInjected.Address(RVA = "0x806C620", Offset = "0x806B020", VA = "0x18806C620")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000D")]
		public bool MLJHDDKNOBB
		{
			[Cpp2IlInjected.Token(Token = "0x600002B")]
			[Cpp2IlInjected.Address(RVA = "0x806B080", Offset = "0x8069A80", VA = "0x18806B080")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000E")]
		public bool NEMCFNAJMJP
		{
			[Cpp2IlInjected.Token(Token = "0x600002C")]
			[Cpp2IlInjected.Address(RVA = "0x806AB90", Offset = "0x8069590", VA = "0x18806AB90")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000F")]
		public EDDAFEHGANJ AIFJKNOJMPM
		{
			[Cpp2IlInjected.Token(Token = "0x600002D")]
			[Cpp2IlInjected.Address(RVA = "0x806AFC0", Offset = "0x80699C0", VA = "0x18806AFC0")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600002E")]
			[Cpp2IlInjected.Address(RVA = "0x806C7E0", Offset = "0x806B1E0", VA = "0x18806C7E0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000010")]
		public PMMOKEJBHFJ OHCMFAEHIHD
		{
			[Cpp2IlInjected.Token(Token = "0x600002F")]
			[Cpp2IlInjected.Address(RVA = "0x806AF60", Offset = "0x8069960", VA = "0x18806AF60")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000030")]
			[Cpp2IlInjected.Address(RVA = "0x806C770", Offset = "0x806B170", VA = "0x18806C770")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000011")]
		public bool MOCHOEMIBEB
		{
			[Cpp2IlInjected.Token(Token = "0x6000031")]
			[Cpp2IlInjected.Address(RVA = "0x806AEB0", Offset = "0x80698B0", VA = "0x18806AEB0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000012")]
		public Rigidbody JADPAFJKPGC
		{
			[Cpp2IlInjected.Token(Token = "0x6000032")]
			[Cpp2IlInjected.Address(RVA = "0x806AF10", Offset = "0x8069910", VA = "0x18806AF10")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000013")]
		public bool PPGCBNJPMIA
		{
			[Cpp2IlInjected.Token(Token = "0x6000033")]
			[Cpp2IlInjected.Address(RVA = "0x806ABF0", Offset = "0x80695F0", VA = "0x18806ABF0")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000034")]
			[Cpp2IlInjected.Address(RVA = "0x806C690", Offset = "0x806B090", VA = "0x18806C690")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000014")]
		public bool FFMEHOBPEIB
		{
			[Cpp2IlInjected.Token(Token = "0x6000035")]
			[Cpp2IlInjected.Address(RVA = "0x14E45E0", Offset = "0x14E2FE0", VA = "0x1814E45E0", Slot = "7")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000015")]
		public float LJJAGKCDFME
		{
			[Cpp2IlInjected.Token(Token = "0x6000036")]
			[Cpp2IlInjected.Address(RVA = "0x806B910", Offset = "0x806A310", VA = "0x18806B910")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000016")]
		public float DJPMGMIBIEI
		{
			[Cpp2IlInjected.Token(Token = "0x6000037")]
			[Cpp2IlInjected.Address(RVA = "0x806B8B0", Offset = "0x806A2B0", VA = "0x18806B8B0")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x6000038")]
			[Cpp2IlInjected.Address(RVA = "0x806CE00", Offset = "0x806B800", VA = "0x18806CE00")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000017")]
		public float DDGFLICCGJD
		{
			[Cpp2IlInjected.Token(Token = "0x6000039")]
			[Cpp2IlInjected.Address(RVA = "0x806B2E0", Offset = "0x8069CE0", VA = "0x18806B2E0")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x600003A")]
			[Cpp2IlInjected.Address(RVA = "0x806CA80", Offset = "0x806B480", VA = "0x18806CA80")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000018")]
		public float CGGNBGNBIIJ
		{
			[Cpp2IlInjected.Token(Token = "0x600003B")]
			[Cpp2IlInjected.Address(RVA = "0x806B0E0", Offset = "0x8069AE0", VA = "0x18806B0E0")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x600003C")]
			[Cpp2IlInjected.Address(RVA = "0x806C850", Offset = "0x806B250", VA = "0x18806C850")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000019")]
		public bool ILIJOEADOAE
		{
			[Cpp2IlInjected.Token(Token = "0x600003D")]
			[Cpp2IlInjected.Address(RVA = "0x806BEC0", Offset = "0x806A8C0", VA = "0x18806BEC0")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x600003E")]
			[Cpp2IlInjected.Address(RVA = "0x806D3B0", Offset = "0x806BDB0", VA = "0x18806D3B0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001A")]
		public Vector3 KFLGGOIFDLK
		{
			[Cpp2IlInjected.Token(Token = "0x600003F")]
			[Cpp2IlInjected.Address(RVA = "0x806B690", Offset = "0x806A090", VA = "0x18806B690")]
			get
			{
				return default(Vector3);
			}
			[Cpp2IlInjected.Token(Token = "0x6000040")]
			[Cpp2IlInjected.Address(RVA = "0x806CBD0", Offset = "0x806B5D0", VA = "0x18806CBD0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001B")]
		public Vector3 KLFGFLOMJGI
		{
			[Cpp2IlInjected.Token(Token = "0x6000041")]
			[Cpp2IlInjected.Address(RVA = "0x806C000", Offset = "0x806AA00", VA = "0x18806C000")]
			get
			{
				return default(Vector3);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001C")]
		public CollisionDetectionMode PIDHINBKBCJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000042")]
			[Cpp2IlInjected.Address(RVA = "0x806B220", Offset = "0x8069C20", VA = "0x18806B220")]
			get
			{
				return default(CollisionDetectionMode);
			}
			[Cpp2IlInjected.Token(Token = "0x6000043")]
			[Cpp2IlInjected.Address(RVA = "0x806C9A0", Offset = "0x806B3A0", VA = "0x18806C9A0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001D")]
		public float PEJGPIMKEKB
		{
			[Cpp2IlInjected.Token(Token = "0x6000044")]
			[Cpp2IlInjected.Address(RVA = "0x806AC50", Offset = "0x8069650", VA = "0x18806AC50")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x6000045")]
			[Cpp2IlInjected.Address(RVA = "0x806C700", Offset = "0x806B100", VA = "0x18806C700")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001E")]
		public RigidbodyConstraints ODACFPDGGJM
		{
			[Cpp2IlInjected.Token(Token = "0x6000046")]
			[Cpp2IlInjected.Address(RVA = "0x806B280", Offset = "0x8069C80", VA = "0x18806B280")]
			get
			{
				return default(RigidbodyConstraints);
			}
			[Cpp2IlInjected.Token(Token = "0x6000047")]
			[Cpp2IlInjected.Address(RVA = "0x806CA10", Offset = "0x806B410", VA = "0x18806CA10")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001F")]
		public Vector3 AAPMAABOKBN
		{
			[Cpp2IlInjected.Token(Token = "0x6000048")]
			[Cpp2IlInjected.Address(RVA = "0x806BA30", Offset = "0x806A430", VA = "0x18806BA30")]
			get
			{
				return default(Vector3);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000020")]
		public Vector3 PFCPEEJBHEP
		{
			[Cpp2IlInjected.Token(Token = "0x6000049")]
			[Cpp2IlInjected.Address(RVA = "0x806BA30", Offset = "0x806A430", VA = "0x18806BA30")]
			get
			{
				return default(Vector3);
			}
			[Cpp2IlInjected.Token(Token = "0x600004A")]
			[Cpp2IlInjected.Address(RVA = "0x806D190", Offset = "0x806BB90", VA = "0x18806D190")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000021")]
		public float EOLODPHLAFO
		{
			[Cpp2IlInjected.Token(Token = "0x600004B")]
			[Cpp2IlInjected.Address(RVA = "0x806B770", Offset = "0x806A170", VA = "0x18806B770")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x600004C")]
			[Cpp2IlInjected.Address(RVA = "0x806CCB0", Offset = "0x806B6B0", VA = "0x18806CCB0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000022")]
		public float MNHHHJCGBIF
		{
			[Cpp2IlInjected.Token(Token = "0x600004D")]
			[Cpp2IlInjected.Address(RVA = "0x806BE60", Offset = "0x806A860", VA = "0x18806BE60")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x600004E")]
			[Cpp2IlInjected.Address(RVA = "0x806D340", Offset = "0x806BD40", VA = "0x18806D340")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000023")]
		public Quaternion BJHLBPCEBAN
		{
			[Cpp2IlInjected.Token(Token = "0x600004F")]
			[Cpp2IlInjected.Address(RVA = "0x806BB10", Offset = "0x806A510", VA = "0x18806BB10")]
			get
			{
				return default(Quaternion);
			}
			[Cpp2IlInjected.Token(Token = "0x6000050")]
			[Cpp2IlInjected.Address(RVA = "0x806CF10", Offset = "0x806B910", VA = "0x18806CF10")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000024")]
		public Quaternion NPDHIIPPEJF
		{
			[Cpp2IlInjected.Token(Token = "0x6000051")]
			[Cpp2IlInjected.Address(RVA = "0x806BD90", Offset = "0x806A790", VA = "0x18806BD90")]
			get
			{
				return default(Quaternion);
			}
			[Cpp2IlInjected.Token(Token = "0x6000052")]
			[Cpp2IlInjected.Address(RVA = "0x806D270", Offset = "0x806BC70", VA = "0x18806D270")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000025")]
		public Vector3 IABAGDFDAPG
		{
			[Cpp2IlInjected.Token(Token = "0x6000053")]
			[Cpp2IlInjected.Address(RVA = "0x806BBE0", Offset = "0x806A5E0", VA = "0x18806BBE0")]
			get
			{
				return default(Vector3);
			}
			[Cpp2IlInjected.Token(Token = "0x6000054")]
			[Cpp2IlInjected.Address(RVA = "0x806CFE0", Offset = "0x806B9E0", VA = "0x18806CFE0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000026")]
		public Quaternion MLPLOPGKONJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000055")]
			[Cpp2IlInjected.Address(RVA = "0x806BCC0", Offset = "0x806A6C0", VA = "0x18806BCC0")]
			get
			{
				return default(Quaternion);
			}
			[Cpp2IlInjected.Token(Token = "0x6000056")]
			[Cpp2IlInjected.Address(RVA = "0x806D0C0", Offset = "0x806BAC0", VA = "0x18806D0C0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000027")]
		public Vector3 FKMLPLAMBLK
		{
			[Cpp2IlInjected.Token(Token = "0x6000057")]
			[Cpp2IlInjected.Address(RVA = "0x806BF20", Offset = "0x806A920", VA = "0x18806BF20")]
			get
			{
				return default(Vector3);
			}
			[Cpp2IlInjected.Token(Token = "0x6000058")]
			[Cpp2IlInjected.Address(RVA = "0x806D420", Offset = "0x806BE20", VA = "0x18806D420")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000028")]
		public Vector3 NJBLGKBFLMG
		{
			[Cpp2IlInjected.Token(Token = "0x6000059")]
			[Cpp2IlInjected.Address(RVA = "0x806B7D0", Offset = "0x806A1D0", VA = "0x18806B7D0")]
			get
			{
				return default(Vector3);
			}
			[Cpp2IlInjected.Token(Token = "0x600005A")]
			[Cpp2IlInjected.Address(RVA = "0x806CD20", Offset = "0x806B720", VA = "0x18806CD20")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000029")]
		public Vector3 AEJKODDIOPN
		{
			[Cpp2IlInjected.Token(Token = "0x600005B")]
			[Cpp2IlInjected.Address(RVA = "0x806B140", Offset = "0x8069B40", VA = "0x18806B140")]
			get
			{
				return default(Vector3);
			}
			[Cpp2IlInjected.Token(Token = "0x600005C")]
			[Cpp2IlInjected.Address(RVA = "0x806C8C0", Offset = "0x806B2C0", VA = "0x18806C8C0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002A")]
		public Vector3 HELMCCBIBJA
		{
			[Cpp2IlInjected.Token(Token = "0x600005D")]
			[Cpp2IlInjected.Address(RVA = "0x806B5B0", Offset = "0x8069FB0", VA = "0x18806B5B0")]
			get
			{
				return default(Vector3);
			}
			[Cpp2IlInjected.Token(Token = "0x600005E")]
			[Cpp2IlInjected.Address(RVA = "0x806CAF0", Offset = "0x806B4F0", VA = "0x18806CAF0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002B")]
		public Vector3 NGPEMHIJION
		{
			[Cpp2IlInjected.Token(Token = "0x600005F")]
			[Cpp2IlInjected.Address(RVA = "0x806B470", Offset = "0x8069E70", VA = "0x18806B470")]
			get
			{
				return default(Vector3);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002C")]
		public Quaternion IFOGOBMIPHM
		{
			[Cpp2IlInjected.Token(Token = "0x6000060")]
			[Cpp2IlInjected.Address(RVA = "0x806B3A0", Offset = "0x8069DA0", VA = "0x18806B3A0")]
			get
			{
				return default(Quaternion);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002D")]
		public Vector3 KIGEANLOGJP
		{
			[Cpp2IlInjected.Token(Token = "0x6000062")]
			[Cpp2IlInjected.Address(RVA = "0x806C1C0", Offset = "0x806ABC0", VA = "0x18806C1C0")]
			get
			{
				return default(Vector3);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002E")]
		public Vector3 NDNAMGBLDPE
		{
			[Cpp2IlInjected.Token(Token = "0x6000063")]
			[Cpp2IlInjected.Address(RVA = "0x806C0E0", Offset = "0x806AAE0", VA = "0x18806C0E0")]
			get
			{
				return default(Vector3);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002F")]
		public bool OJJOMFALNBA
		{
			[Cpp2IlInjected.Token(Token = "0x6000064")]
			[Cpp2IlInjected.Address(RVA = "0x806B550", Offset = "0x8069F50", VA = "0x18806B550")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000030")]
		public bool GBHOGBPJMED
		{
			[Cpp2IlInjected.Token(Token = "0x6000065")]
			[Cpp2IlInjected.Address(RVA = "0x806B020", Offset = "0x8069A20", VA = "0x18806B020")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000031")]
		public bool EABHEGNBDMC
		{
			[Cpp2IlInjected.Token(Token = "0x6000066")]
			[Cpp2IlInjected.Address(RVA = "0x806AB30", Offset = "0x8069530", VA = "0x18806AB30")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000032")]
		public bool DOGEECAEPBA
		{
			[Cpp2IlInjected.Token(Token = "0x6000067")]
			[Cpp2IlInjected.Address(RVA = "0x806AAD0", Offset = "0x80694D0", VA = "0x18806AAD0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000033")]
		public bool FLGAHILHJCD
		{
			[Cpp2IlInjected.Token(Token = "0x6000068")]
			[Cpp2IlInjected.Address(RVA = "0x806A9B0", Offset = "0x80693B0", VA = "0x18806A9B0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000034")]
		public bool IKIAADFMBIL
		{
			[Cpp2IlInjected.Token(Token = "0x6000069")]
			[Cpp2IlInjected.Address(RVA = "0x806B340", Offset = "0x8069D40", VA = "0x18806B340")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000035")]
		public bool BHLAOEGENBL
		{
			[Cpp2IlInjected.Token(Token = "0x600006A")]
			[Cpp2IlInjected.Address(RVA = "0x2274690", Offset = "0x2273090", VA = "0x182274690")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000001")]
		public event AAILGCMHGNK KFLIJODBHEA
		{
			[Cpp2IlInjected.Token(Token = "0x600000E")]
			[Cpp2IlInjected.Address(RVA = "0x806A8D0", Offset = "0x80692D0", VA = "0x18806A8D0")]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x600000F")]
			[Cpp2IlInjected.Address(RVA = "0x806C540", Offset = "0x806AF40", VA = "0x18806C540")]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000002")]
		public event EIMKACMLCOF HPMNGIDAKOL
		{
			[Cpp2IlInjected.Token(Token = "0x6000010")]
			[Cpp2IlInjected.Address(RVA = "0x806A640", Offset = "0x8069040", VA = "0x18806A640")]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000011")]
			[Cpp2IlInjected.Address(RVA = "0x806C2A0", Offset = "0x806ACA0", VA = "0x18806C2A0")]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000003")]
		public event EIMKACMLCOF BEOPJEDGIKK
		{
			[Cpp2IlInjected.Token(Token = "0x6000012")]
			[Cpp2IlInjected.Address(RVA = "0x806A6A0", Offset = "0x80690A0", VA = "0x18806A6A0")]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000013")]
			[Cpp2IlInjected.Address(RVA = "0x806C310", Offset = "0x806AD10", VA = "0x18806C310")]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000004")]
		public event EIMKACMLCOF JJHDIEMPODM
		{
			[Cpp2IlInjected.Token(Token = "0x6000014")]
			[Cpp2IlInjected.Address(RVA = "0x806A7F0", Offset = "0x80691F0", VA = "0x18806A7F0")]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000015")]
			[Cpp2IlInjected.Address(RVA = "0x806C460", Offset = "0x806AE60", VA = "0x18806C460")]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000005")]
		public event Action<HNIGDDENMGF, HNIGDDENMGF> KFNJJBLINJE
		{
			[Cpp2IlInjected.Token(Token = "0x6000016")]
			[Cpp2IlInjected.Address(RVA = "0x806A780", Offset = "0x8069180", VA = "0x18806A780")]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000017")]
			[Cpp2IlInjected.Address(RVA = "0x806C3F0", Offset = "0x806ADF0", VA = "0x18806C3F0")]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000006")]
		public event EIMKACMLCOF DIIJFAJALGG
		{
			[Cpp2IlInjected.Token(Token = "0x6000018")]
			[Cpp2IlInjected.Address(RVA = "0x806A860", Offset = "0x8069260", VA = "0x18806A860")]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000019")]
			[Cpp2IlInjected.Address(RVA = "0x806C4D0", Offset = "0x806AED0", VA = "0x18806C4D0")]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000007")]
		public event EIMKACMLCOF EHNOAILGLBC
		{
			[Cpp2IlInjected.Token(Token = "0x600001A")]
			[Cpp2IlInjected.Address(RVA = "0x806A940", Offset = "0x8069340", VA = "0x18806A940")]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x600001B")]
			[Cpp2IlInjected.Address(RVA = "0x806C5B0", Offset = "0x806AFB0", VA = "0x18806C5B0")]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000008")]
		public event EIMKACMLCOF MJLJPIFOJCD
		{
			[Cpp2IlInjected.Token(Token = "0x600001C")]
			[Cpp2IlInjected.Address(RVA = "0x806A710", Offset = "0x8069110", VA = "0x18806A710")]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x600001D")]
			[Cpp2IlInjected.Address(RVA = "0x806C380", Offset = "0x806AD80", VA = "0x18806C380")]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x9B0460", Offset = "0x9AEE60", VA = "0x1809B0460", Slot = "8")]
		private void FPCIPAKOMPM(AEGDBIMJAKG GBDMJHAPPHC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x8069010", Offset = "0x8067A10", VA = "0x188069010", Slot = "9")]
		public BNAMPFDBALG GetData()
		{
			return default(BNAMPFDBALG);
		}

		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x8069530", Offset = "0x8067F30", VA = "0x188069530")]
		internal void LEPJNGCOCHB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x806A370", Offset = "0x8068D70", VA = "0x18806A370")]
		[Conditional("DEBUG_BUILD")]
		[Conditional("UNITY_EDITOR")]
		public void TestOverrideUnityRigidbody(Rigidbody FCBMDOHAMHL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x8068D60", Offset = "0x8067760", VA = "0x188068D60")]
		public COGOJKBIHHJ GetChild(int DOAKEFBOPIA)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000061")]
		[Cpp2IlInjected.Address(RVA = "0x806A030", Offset = "0x8068A30", VA = "0x18806A030")]
		public void SetInertiaTensor((Quaternion rot, Vector3 moments) BFILMAEAIPL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006B")]
		[Cpp2IlInjected.Address(RVA = "0x80689C0", Offset = "0x80673C0", VA = "0x1880689C0")]
		private void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006C")]
		[Cpp2IlInjected.Address(RVA = "0x806A2C0", Offset = "0x8068CC0", VA = "0x18806A2C0")]
		protected void Start()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006D")]
		[Cpp2IlInjected.Address(RVA = "0x80690A0", Offset = "0x8067AA0", VA = "0x1880690A0")]
		private AEGDBIMJAKG OOEMNMKHNEO()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600006E")]
		[Cpp2IlInjected.Address(RVA = "0x80693B0", Offset = "0x8067DB0", VA = "0x1880693B0")]
		private void JCFABLNPBJM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006F")]
		[Cpp2IlInjected.Address(RVA = "0x8069800", Offset = "0x8068200", VA = "0x188069800")]
		private void OnEnable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000070")]
		[Cpp2IlInjected.Address(RVA = "0x8069740", Offset = "0x8068140", VA = "0x188069740")]
		public void OnDisable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000071")]
		[Cpp2IlInjected.Address(RVA = "0x8069530", Offset = "0x8067F30", VA = "0x188069530")]
		private void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000072")]
		[Cpp2IlInjected.Address(RVA = "0x80697A0", Offset = "0x80681A0", VA = "0x1880697A0")]
		private void OnDrawGizmosSelected()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000073")]
		[Cpp2IlInjected.Address(RVA = "0x8069860", Offset = "0x8068260", VA = "0x188069860")]
		private void OnValidate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000074")]
		[Cpp2IlInjected.Address(RVA = "0x8068010", Offset = "0x8066A10", VA = "0x188068010")]
		public void AddDoNotResetVelocityOnOwnershipChangeOverride(object GNAAILLDOKI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000075")]
		[Cpp2IlInjected.Address(RVA = "0x80698C0", Offset = "0x80682C0", VA = "0x1880698C0")]
		public void RemoveDoNotResetVelocityOnOwnershipChangeOverride(object GNAAILLDOKI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000076")]
		[Cpp2IlInjected.Address(RVA = "0x8068D00", Offset = "0x8067700", VA = "0x188068D00")]
		public void DisableCachedInertialPropertyOverride()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000077")]
		[Cpp2IlInjected.Address(RVA = "0x80696D0", Offset = "0x80680D0", VA = "0x1880696D0")]
		public void MarkCachedInertialParametersDirty()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000078")]
		[Cpp2IlInjected.Address(RVA = "0x806A190", Offset = "0x8068B90", VA = "0x18806A190")]
		public void SetParent(RigidbodyEx PPJFMHBDGNA, bool OFLGEPPEKAD = false)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000079")]
		[Cpp2IlInjected.Address(RVA = "0x8069BD0", Offset = "0x80685D0", VA = "0x188069BD0")]
		public void ResetLocalCenterOfMassToPrefabDefault()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007A")]
		[Cpp2IlInjected.Address(RVA = "0x8069150", Offset = "0x8067B50", VA = "0x188069150")]
		public bool IsRigidbodyAncestor(RigidbodyEx JADKFGHHKCE)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600007B")]
		[Cpp2IlInjected.Address(RVA = "0x8069250", Offset = "0x8067C50", VA = "0x188069250")]
		public bool IsRigidbodyDescendant(RigidbodyEx IAKKICMDHNB)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600007C")]
		[Cpp2IlInjected.Address(RVA = "0x8068280", Offset = "0x8066C80", VA = "0x188068280")]
		public void AddInterpolationRestriction(object GNAAILLDOKI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007D")]
		[Cpp2IlInjected.Address(RVA = "0x8069930", Offset = "0x8068330", VA = "0x188069930")]
		public void RemoveInterpolationRestriction(object GNAAILLDOKI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007E")]
		[Cpp2IlInjected.Address(RVA = "0x80682F0", Offset = "0x8066CF0", VA = "0x1880682F0")]
		public void AddKinematic(object GNAAILLDOKI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007F")]
		[Cpp2IlInjected.Address(RVA = "0x80699A0", Offset = "0x80683A0", VA = "0x1880699A0")]
		public void RemoveKinematic(object GNAAILLDOKI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000080")]
		[Cpp2IlInjected.Address(RVA = "0x806A110", Offset = "0x8068B10", VA = "0x18806A110")]
		public void SetKinematic(object GNAAILLDOKI, bool MLIEPCEKKKM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000081")]
		[Cpp2IlInjected.Address(RVA = "0x8069F30", Offset = "0x8068930", VA = "0x188069F30")]
		public void SetDiscontinuousPositionAndRotation(Vector3 FBLMAAJOADP, Quaternion FIDEGHHFHJK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000082")]
		[Cpp2IlInjected.Address(RVA = "0x8069E30", Offset = "0x8068830", VA = "0x188069E30")]
		public void SetDiscontinuousLocalPositionAndLocalRotation(Vector3 HAMPBLAEJPA, Quaternion OCDILGIKBNM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000083")]
		[Cpp2IlInjected.Address(RVA = "0x8068F00", Offset = "0x8067900", VA = "0x188068F00")]
		public Vector3 GetConstrainedVelocity(Vector3 FKMLPLAMBLK)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x6000084")]
		[Cpp2IlInjected.Address(RVA = "0x8068DF0", Offset = "0x80677F0", VA = "0x188068DF0")]
		public Vector3 GetConstrainedAngularVelocity(Vector3 AEJKODDIOPN)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x6000085")]
		[Cpp2IlInjected.Address(RVA = "0x8068190", Offset = "0x8066B90", VA = "0x188068190")]
		public void AddForce(Vector3 JDEIJIAFEMH, ForceMode MGJAADBPMJD = ForceMode.Force)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000086")]
		[Cpp2IlInjected.Address(RVA = "0x8068080", Offset = "0x8066A80", VA = "0x188068080")]
		public void AddForceAtPosition(Vector3 JDEIJIAFEMH, Vector3 KKIJMCHODGC, ForceMode MGJAADBPMJD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000087")]
		[Cpp2IlInjected.Address(RVA = "0x80684C0", Offset = "0x8066EC0", VA = "0x1880684C0")]
		public void AddTorque(Vector3 DBNLIBDADBA, ForceMode MGJAADBPMJD = ForceMode.Force)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000088")]
		[Cpp2IlInjected.Address(RVA = "0x8068360", Offset = "0x8066D60", VA = "0x188068360")]
		public void AddRelativeTorque(Vector3 DBNLIBDADBA, ForceMode MGJAADBPMJD = ForceMode.Force)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000089")]
		[Cpp2IlInjected.Address(RVA = "0x806A440", Offset = "0x8068E40", VA = "0x18806A440")]
		public Vector3 WorldToLocalVelocity(Vector3 PJJJJDKGMGH)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x600008A")]
		[Cpp2IlInjected.Address(RVA = "0x80695C0", Offset = "0x8067FC0", VA = "0x1880695C0")]
		public Vector3 LocalToWorldVelocity(Vector3 NJBLGKBFLMG)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x600008B")]
		[Cpp2IlInjected.Address(RVA = "0x8068CA0", Offset = "0x80676A0", VA = "0x188068CA0")]
		public void ClearVelocity()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008C")]
		[Cpp2IlInjected.Address(RVA = "0x8068C40", Offset = "0x8067640", VA = "0x188068C40")]
		public void ClearUnityRigidbodyVelocity()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008D")]
		[Cpp2IlInjected.Address(RVA = "0x8068BE0", Offset = "0x80675E0", VA = "0x188068BE0")]
		public void ClearLinearVelocity()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008E")]
		[Cpp2IlInjected.Address(RVA = "0x8068B80", Offset = "0x8067580", VA = "0x188068B80")]
		public void ClearAngularVelocity()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008F")]
		[Cpp2IlInjected.Address(RVA = "0x8069D30", Offset = "0x8068730", VA = "0x188069D30")]
		public void ResetVelocityWorldSpace(Vector3 KKNIJFMODLP, Vector3 HAKGCOPLKEE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000090")]
		[Cpp2IlInjected.Address(RVA = "0x8069C30", Offset = "0x8068630", VA = "0x188069C30")]
		public void ResetVelocityLocalSpace(Vector3 HOJGOCKJLEI, Vector3 HELMCCBIBJA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000091")]
		[Cpp2IlInjected.Address(RVA = "0x8069AF0", Offset = "0x80684F0", VA = "0x188069AF0")]
		public void ResetLinearVelocityLocalSpace(Vector3 HOJGOCKJLEI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000092")]
		[Cpp2IlInjected.Address(RVA = "0x806A2D0", Offset = "0x8068CD0", VA = "0x18806A2D0")]
		public bool SweepTest(Vector3 BJECPMGLFMN, [Out] RaycastHit ILNEPPLCHJL, float FPNKBMPOCJL)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000093")]
		[Cpp2IlInjected.Address(RVA = "0x8069350", Offset = "0x8067D50", VA = "0x188069350")]
		public bool IsSleeping()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000094")]
		[Cpp2IlInjected.Address(RVA = "0x806A260", Offset = "0x8068C60", VA = "0x18806A260")]
		public void Sleep()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000095")]
		[Cpp2IlInjected.Address(RVA = "0x806A3E0", Offset = "0x8068DE0", VA = "0x18806A3E0")]
		public void WakeUp()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000096")]
		[Cpp2IlInjected.Address(RVA = "0x8068450", Offset = "0x8066E50", VA = "0x188068450")]
		public void AddShouldHaveUnityRigidbodyToken(object GNAAILLDOKI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000097")]
		[Cpp2IlInjected.Address(RVA = "0x8069A10", Offset = "0x8068410", VA = "0x188069A10")]
		public void RemoveShouldHaveUnityRigidbodyToken(object GNAAILLDOKI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000098")]
		[Cpp2IlInjected.Address(RVA = "0x8068850", Offset = "0x8067250", VA = "0x188068850")]
		public void ApplyForceVelocityChange(NDBGGMAABME GLDACEOGKOF, Vector3 ICDAHOACGJL, float MFDBDMLHKBO, float CMEMFLLIBBI = 8f, float DMHCNEFBFKH = 1f)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000099")]
		[Cpp2IlInjected.Address(RVA = "0x8068750", Offset = "0x8067150", VA = "0x188068750")]
		public void ApplyAngularVelocityChange(MAHCBKNMHNB PEOJMKLPOGJ, Vector3 JBPODNLOLED, float MJDLKKNIKHJ = float.PositiveInfinity)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009A")]
		[Cpp2IlInjected.Address(RVA = "0x8068910", Offset = "0x8067310", VA = "0x188068910")]
		[Obsolete("Deprecated. Still exists to support deprecated CV2 chips. Use ApplyAngularVelocityChange.")]
		public void ApplyTorqueAngularVelocityChangeDeprecated(MAHCBKNMHNB PEOJMKLPOGJ, Vector3 KONJHPLFEME, float MGFDEACAIGP = 7f, float DLPODANBMAG = 1f)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009B")]
		[Cpp2IlInjected.Address(RVA = "0x8068680", Offset = "0x8067080", VA = "0x188068680")]
		public bool AllowedScaleChange(float DFLDIKKIDLP)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600009C")]
		[Cpp2IlInjected.Address(RVA = "0x80685B0", Offset = "0x8066FB0", VA = "0x1880685B0")]
		public void AddWorldSpaceVelocityInHierarchyParentOverride(RigidbodyEx GOKDJANKNKE, object GNAAILLDOKI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009D")]
		[Cpp2IlInjected.Address(RVA = "0x8069A80", Offset = "0x8068480", VA = "0x188069A80")]
		public void RemoveWorldSpaceVelocityInHierarchyParentOverride(object GNAAILLDOKI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009E")]
		[Cpp2IlInjected.Address(RVA = "0x8069730", Offset = "0x8068130", VA = "0x188069730", Slot = "12")]
		private void OIOFOJJFIDE(IIJAAMAGBPD OJFCDDMGKNP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009F")]
		[Cpp2IlInjected.Address(RVA = "0x806A5D0", Offset = "0x8068FD0", VA = "0x18806A5D0")]
		public RigidbodyEx()
		{
		}

		[SpecialName]
		[Cpp2IlInjected.Token(Token = "0x60000A1")]
		[Cpp2IlInjected.Address(RVA = "0xB2A950", Offset = "0xB29350", VA = "0x180B2A950", Slot = "4")]
		private GameObject DEGFLNDJMOO()
		{
			return null;
		}

		[SpecialName]
		[Cpp2IlInjected.Token(Token = "0x60000A2")]
		[Cpp2IlInjected.Address(RVA = "0x9DAAE0", Offset = "0x9D94E0", VA = "0x1809DAAE0", Slot = "10")]
		private bool PGJKCKIKBII()
		{
			return default(bool);
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
internal static class MEJFKGOKNLA
{
	[Cpp2IlInjected.Token(Token = "0x60000A3")]
	[Cpp2IlInjected.Address(RVA = "0x8066FB0", Offset = "0x80659B0", VA = "0x188066FB0")]
	public static AEGDBIMJAKG BEPMIGHKPMM(this RigidbodyEx JCJHLOEIIFO)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
[RegisterService(typeof(OOJMOMLJPBI), new string[] { })]
public class CAHOPNKEJLL : OOJMOMLJPBI, KFPIMHBKPFA
{
	[Cpp2IlInjected.Token(Token = "0x4000011")]
	private static readonly LMPJBEBLCLM BLAHIKOFFGK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000012")]
	private CAFCKCAPGDN MPDODANMFLG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000013")]
	private MKHGFDOKEMI KDMEMFMCOOJ;

	[Cpp2IlInjected.Token(Token = "0x17000036")]
	public CAFCKCAPGDN MNIGFADEFAD
	{
		[Cpp2IlInjected.Token(Token = "0x60000A4")]
		[Cpp2IlInjected.Address(RVA = "0x9AEFD0", Offset = "0x9AD9D0", VA = "0x1809AEFD0", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000037")]
	public MKHGFDOKEMI IEOBPJCNMBJ
	{
		[Cpp2IlInjected.Token(Token = "0x60000A5")]
		[Cpp2IlInjected.Address(RVA = "0x9ACED0", Offset = "0x9AB8D0", VA = "0x1809ACED0", Slot = "5")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000A6")]
	[Cpp2IlInjected.Address(RVA = "0x80596A0", Offset = "0x80580A0", VA = "0x1880596A0", Slot = "7")]
	public void InitReferences(LBHNIGEPODB GNJMKKKJHPN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A7")]
	[Cpp2IlInjected.Address(RVA = "0x8059570", Offset = "0x8057F70", VA = "0x188059570", Slot = "6")]
	public AEGDBIMJAKG DOFDPJBFNDD(RigidbodyEx JCJHLOEIIFO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000A8")]
	[Cpp2IlInjected.Address(RVA = "0x9B1770", Offset = "0x9B0170", VA = "0x1809B1770")]
	public CAHOPNKEJLL()
	{
	}
}
namespace RecRoom
{
	[Cpp2IlInjected.Token(Token = "0x2000007")]
	public class PhysicsManager : SingletonMonoBehaviour<PhysicsManager>
	{
		[Cpp2IlInjected.Token(Token = "0x4000014")]
		public static COOFKGJALFM UpdateAfterFixedUpdateRan;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000015")]
		private int CMILDHCHKOK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x4000016")]
		private int IKCKBKIBMPF;

		[Cpp2IlInjected.Token(Token = "0x60000AA")]
		[Cpp2IlInjected.Address(RVA = "0x8067E90", Offset = "0x8066890", VA = "0x188067E90")]
		protected void FixedUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AB")]
		[Cpp2IlInjected.Address(RVA = "0x8067ED0", Offset = "0x80668D0", VA = "0x188067ED0")]
		protected void Update()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AC")]
		[Cpp2IlInjected.Address(RVA = "0x8067EB0", Offset = "0x80668B0", VA = "0x188067EB0")]
		protected void LateUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AD")]
		[Cpp2IlInjected.Address(RVA = "0x9AE060", Offset = "0x9ACA60", VA = "0x1809AE060")]
		[Conditional("UNITY_ASSERTIONS")]
		public void AssertLateColliderPositionsNotYetUpdated([Optional] string FLPDJFEEMLN, [Optional] UnityEngine.Object OJFCDDMGKNP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AE")]
		[Cpp2IlInjected.Address(RVA = "0x9AE060", Offset = "0x9ACA60", VA = "0x1809AE060")]
		[Conditional("UNITY_ASSERTIONS")]
		public void AssertLateColliderPositionsAlreadyUpdated([Optional] string FLPDJFEEMLN, [Optional] UnityEngine.Object OJFCDDMGKNP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AF")]
		[Cpp2IlInjected.Address(RVA = "0x8067FC0", Offset = "0x80669C0", VA = "0x188067FC0")]
		public PhysicsManager()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
public static class PPLIBCEKIKA
{
	[Cpp2IlInjected.Token(Token = "0x2000009")]
	private class DPLOFAPKKDN : EDDAFEHGANJ, IDisposable
	{
		[Cpp2IlInjected.Token(Token = "0x60000B3")]
		[Cpp2IlInjected.Address(RVA = "0x9AE060", Offset = "0x9ACA60", VA = "0x1809AE060", Slot = "7")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B4")]
		[Cpp2IlInjected.Address(RVA = "0x9BD860", Offset = "0x9BC260", VA = "0x1809BD860", Slot = "4")]
		public Vector3 GFKKLLINCGJ()
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x60000B5")]
		[Cpp2IlInjected.Address(RVA = "0x9BD860", Offset = "0x9BC260", VA = "0x1809BD860", Slot = "5")]
		public Vector3 OPIAEKEFBJA()
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x60000B6")]
		[Cpp2IlInjected.Address(RVA = "0x9C8410", Offset = "0x9C6E10", VA = "0x1809C8410", Slot = "6")]
		public bool JFEMNIKOECN(float OCJNNFFGCEI, float OOFNJDLCKHG)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000B7")]
		[Cpp2IlInjected.Address(RVA = "0x9B1770", Offset = "0x9B0170", VA = "0x1809B1770")]
		public DPLOFAPKKDN()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000038")]
	public static EDDAFEHGANJ EGAKBPHKOHO
	{
		[Cpp2IlInjected.Token(Token = "0x60000B1")]
		[Cpp2IlInjected.Address(RVA = "0x8067DC0", Offset = "0x80667C0", VA = "0x188067DC0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
public interface ANNBJDFMKOO
{
	[Cpp2IlInjected.Token(Token = "0x17000039")]
	CollisionDetectionMode INCBHDMGFBA
	{
		[Cpp2IlInjected.Token(Token = "0x60000B8")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
		[Cpp2IlInjected.Token(Token = "0x60000B9")]
		[Cpp2IlInjected.Address(Slot = "1")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x60000BA")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void GMJBMKIKLGO();

	[Cpp2IlInjected.Token(Token = "0x60000BB")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void KHHMOMJDGIL(bool OJJOMFALNBA);

	[Cpp2IlInjected.Token(Token = "0x60000BC")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void NIFNKKKMGNG(bool OJJOMFALNBA);

	[Cpp2IlInjected.Token(Token = "0x60000BD")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void CGBEHGCJKJC(Rigidbody LHOBCJGBABO);

	[Cpp2IlInjected.Token(Token = "0x60000BE")]
	[Cpp2IlInjected.Address(Slot = "6")]
	bool OBJEAPCONIP(Vector3 BJECPMGLFMN, [Out] RaycastHit ILNEPPLCHJL, float FPNKBMPOCJL);
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
public interface ODGBGICJCIB : IDisposable, IGCNAGLMNLD
{
	[Cpp2IlInjected.Token(Token = "0x1700003A")]
	JFFGEHLFDPP HBFBJDHEFMD
	{
		[Cpp2IlInjected.Token(Token = "0x60000C1")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
		[Cpp2IlInjected.Token(Token = "0x60000C2")]
		[Cpp2IlInjected.Address(Slot = "3")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x14000009")]
	event Action<HNIGDDENMGF, HNIGDDENMGF> KFNJJBLINJE;

	[Cpp2IlInjected.Token(Token = "0x60000C3")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void GMJBMKIKLGO();
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
[ServiceLifetime(Lifetime.Application)]
public interface MKHGFDOKEMI
{
	[Cpp2IlInjected.Token(Token = "0x60000C4")]
	[Cpp2IlInjected.Address(Slot = "0")]
	HNIPPCIEEBF BBMAKGHMLIJ(AEGDBIMJAKG GBDMJHAPPHC);

	[Cpp2IlInjected.Token(Token = "0x60000C5")]
	[Cpp2IlInjected.Address(Slot = "1")]
	HBGNPJEJHHJ GHAFEHFOIPB(AEGDBIMJAKG GBDMJHAPPHC);

	[Cpp2IlInjected.Token(Token = "0x60000C6")]
	[Cpp2IlInjected.Address(Slot = "2")]
	OMFLDLCMAPK EGCDLAFEICE(AEGDBIMJAKG GBDMJHAPPHC);

	[Cpp2IlInjected.Token(Token = "0x60000C7")]
	[Cpp2IlInjected.Address(Slot = "3")]
	LCPFLPPAHGD BCJNNINFJGK(AEGDBIMJAKG GBDMJHAPPHC);

	[Cpp2IlInjected.Token(Token = "0x60000C8")]
	[Cpp2IlInjected.Address(Slot = "4")]
	FHMKNHCIOOB DDKHEDMLHHJ(AEGDBIMJAKG GBDMJHAPPHC);

	[Cpp2IlInjected.Token(Token = "0x60000C9")]
	[Cpp2IlInjected.Address(Slot = "5")]
	ODGBGICJCIB MLMMPCEHJIN(AEGDBIMJAKG GBDMJHAPPHC);

	[Cpp2IlInjected.Token(Token = "0x60000CA")]
	[Cpp2IlInjected.Address(Slot = "6")]
	DLIEGGPBPJO OPJLNCAEBGB(AEGDBIMJAKG GBDMJHAPPHC);

	[Cpp2IlInjected.Token(Token = "0x60000CB")]
	[Cpp2IlInjected.Address(Slot = "7")]
	BIENKFHPJMP LHGCLLJHBKP(AEGDBIMJAKG GBDMJHAPPHC);

	[Cpp2IlInjected.Token(Token = "0x60000CC")]
	[Cpp2IlInjected.Address(Slot = "8")]
	ANNBJDFMKOO DFOADOALJEM(AEGDBIMJAKG GBDMJHAPPHC);

	[Cpp2IlInjected.Token(Token = "0x60000CD")]
	[Cpp2IlInjected.Address(Slot = "9")]
	CFENPGCEIEG NPNOJGJIJPH(AEGDBIMJAKG GBDMJHAPPHC);

	[Cpp2IlInjected.Token(Token = "0x60000CE")]
	[Cpp2IlInjected.Address(Slot = "10")]
	JFEEDKNMOFN PDNBMJAKGNC(AEGDBIMJAKG GBDMJHAPPHC, [In] BNAMPFDBALG DFPGGEDGGGN);

	[Cpp2IlInjected.Token(Token = "0x60000CF")]
	[Cpp2IlInjected.Address(Slot = "11")]
	ONDFHDJOEBD POJKCPHMBLD(AEGDBIMJAKG GBDMJHAPPHC, [In] BNAMPFDBALG DFPGGEDGGGN);

	[Cpp2IlInjected.Token(Token = "0x60000D0")]
	[Cpp2IlInjected.Address(Slot = "12")]
	KAGCJGFIMHB CAKGCKJADIO(AEGDBIMJAKG GBDMJHAPPHC, [In] BNAMPFDBALG DFPGGEDGGGN);

	[Cpp2IlInjected.Token(Token = "0x60000D1")]
	[Cpp2IlInjected.Address(Slot = "13")]
	JFADAMMEHIM DJKEHAKDBGA(AEGDBIMJAKG GBDMJHAPPHC, [In] BNAMPFDBALG DFPGGEDGGGN);

	[Cpp2IlInjected.Token(Token = "0x60000D2")]
	[Cpp2IlInjected.Address(Slot = "14")]
	BMKDEGFOAMG ECCEIMAPLMI(AEGDBIMJAKG GBDMJHAPPHC, [In] BNAMPFDBALG DFPGGEDGGGN);

	[Cpp2IlInjected.Token(Token = "0x60000D3")]
	[Cpp2IlInjected.Address(Slot = "15")]
	AEGDBIMJAKG DOFDPJBFNDD(RigidbodyEx JCJHLOEIIFO, BNAMPFDBALG DFPGGEDGGGN, OOJMOMLJPBI GIGHOMPCPHH);
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
public interface BIENKFHPJMP
{
	[Cpp2IlInjected.Token(Token = "0x60000D4")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void CCMEJBGHLCK(Vector3 JDEIJIAFEMH, ForceMode MGJAADBPMJD = ForceMode.Force);

	[Cpp2IlInjected.Token(Token = "0x60000D5")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void MLKHEIEEHGI(Vector3 JDEIJIAFEMH, Vector3 KKIJMCHODGC, ForceMode MGJAADBPMJD);

	[Cpp2IlInjected.Token(Token = "0x60000D6")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void CCKICFDOCAP(Vector3 DBNLIBDADBA, ForceMode MGJAADBPMJD = ForceMode.Force);

	[Cpp2IlInjected.Token(Token = "0x60000D7")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void EIJGDGMOIKI(Vector3 DBNLIBDADBA, ForceMode MGJAADBPMJD = ForceMode.Force);
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
public interface CFENPGCEIEG
{
	[Cpp2IlInjected.Token(Token = "0x1700003B")]
	bool LOEEGOLECOO
	{
		[Cpp2IlInjected.Token(Token = "0x60000D8")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
		[Cpp2IlInjected.Token(Token = "0x60000D9")]
		[Cpp2IlInjected.Address(Slot = "1")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x60000DA")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void CGBEHGCJKJC(Rigidbody LHOBCJGBABO);

	[Cpp2IlInjected.Token(Token = "0x60000DB")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void DEEDFLNEMBA(Rigidbody LHOBCJGBABO);
}
[Cpp2IlInjected.Token(Token = "0x200000F")]
public interface HNIPPCIEEBF : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x1700003C")]
	IReadOnlyList<AEGDBIMJAKG> KGEKDELIPPG
	{
		[Cpp2IlInjected.Token(Token = "0x60000EE")]
		[Cpp2IlInjected.Address(Slot = "18")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700003D")]
	AEGDBIMJAKG LKAEGJLGAIG
	{
		[Cpp2IlInjected.Token(Token = "0x60000EF")]
		[Cpp2IlInjected.Address(Slot = "19")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700003E")]
	AEGDBIMJAKG LKNIONJKNBM
	{
		[Cpp2IlInjected.Token(Token = "0x60000F0")]
		[Cpp2IlInjected.Address(Slot = "20")]
		get;
		[Cpp2IlInjected.Token(Token = "0x60000F1")]
		[Cpp2IlInjected.Address(Slot = "21")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x1400000A")]
	event EIMKACMLCOF HPMNGIDAKOL;

	[Cpp2IlInjected.Token(Token = "0x1400000B")]
	event EIMKACMLCOF BEOPJEDGIKK;

	[Cpp2IlInjected.Token(Token = "0x1400000C")]
	event AAILGCMHGNK JICLOCIGEGP;

	[Cpp2IlInjected.Token(Token = "0x1400000D")]
	event Action EAJKMMFBBCJ;

	[Cpp2IlInjected.Token(Token = "0x1400000E")]
	event Action MGPMPGDIKHI;

	[Cpp2IlInjected.Token(Token = "0x1400000F")]
	event Action<AEGDBIMJAKG> EIOJAMPEIPC;

	[Cpp2IlInjected.Token(Token = "0x14000010")]
	event Action<AEGDBIMJAKG> LJHCMKEANIM;

	[Cpp2IlInjected.Token(Token = "0x14000011")]
	event Action NILGKKOEPIC;

	[Cpp2IlInjected.Token(Token = "0x14000012")]
	event Action<AEGDBIMJAKG> OOBFNJLHPJH;

	[Cpp2IlInjected.Token(Token = "0x60000F2")]
	[Cpp2IlInjected.Address(Slot = "22")]
	void GICBAHPKOCO(AEGDBIMJAKG MGKDKKMCMAL, bool OFLGEPPEKAD = false);
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
public interface OMFLDLCMAPK
{
	[Cpp2IlInjected.Token(Token = "0x1700003F")]
	Vector3 DGGLPPHNMBJ
	{
		[Cpp2IlInjected.Token(Token = "0x60000F3")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000040")]
	Vector3 FPBOMHPDKGJ
	{
		[Cpp2IlInjected.Token(Token = "0x60000F4")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x60000F5")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void FMBIGGNKPCL(AEGDBIMJAKG HGBJMKAPAJA, object GNAAILLDOKI);

	[Cpp2IlInjected.Token(Token = "0x60000F6")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void OGIAELLNJCL(object GNAAILLDOKI);
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
public interface JFADAMMEHIM
{
	[Cpp2IlInjected.Token(Token = "0x17000041")]
	Vector3 LEJBCFNAOGD
	{
		[Cpp2IlInjected.Token(Token = "0x60000F9")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
		[Cpp2IlInjected.Token(Token = "0x60000FA")]
		[Cpp2IlInjected.Address(Slot = "3")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000042")]
	Vector3 NFBCHABDNEC
	{
		[Cpp2IlInjected.Token(Token = "0x60000FB")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000043")]
	float DCHGLADGMNH
	{
		[Cpp2IlInjected.Token(Token = "0x60000FC")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000044")]
	float FBDCBPLJJNH
	{
		[Cpp2IlInjected.Token(Token = "0x60000FD")]
		[Cpp2IlInjected.Address(Slot = "6")]
		get;
		[Cpp2IlInjected.Token(Token = "0x60000FE")]
		[Cpp2IlInjected.Address(Slot = "7")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000045")]
	Vector3 BIFJODANNFE
	{
		[Cpp2IlInjected.Token(Token = "0x60000FF")]
		[Cpp2IlInjected.Address(Slot = "8")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000046")]
	Quaternion GDOEFFLGCMO
	{
		[Cpp2IlInjected.Token(Token = "0x6000100")]
		[Cpp2IlInjected.Address(Slot = "9")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x14000013")]
	event EIMKACMLCOF AAEBGEMEHFP;

	[Cpp2IlInjected.Token(Token = "0x6000101")]
	[Cpp2IlInjected.Address(Slot = "10")]
	void JFACDNBLNMA((Quaternion rot, Vector3 moments) BFILMAEAIPL);

	[Cpp2IlInjected.Token(Token = "0x6000102")]
	[Cpp2IlInjected.Address(Slot = "11")]
	void HAFANPILNFO();

	[Cpp2IlInjected.Token(Token = "0x6000103")]
	[Cpp2IlInjected.Address(Slot = "12")]
	void AKMOEEOCJGK();

	[Cpp2IlInjected.Token(Token = "0x6000104")]
	[Cpp2IlInjected.Address(Slot = "13")]
	void ICCOCPPFPIM();

	[Cpp2IlInjected.Token(Token = "0x6000105")]
	[Cpp2IlInjected.Address(Slot = "14")]
	void CGBEHGCJKJC(Rigidbody LHOBCJGBABO);

	[Cpp2IlInjected.Token(Token = "0x6000106")]
	[Cpp2IlInjected.Address(Slot = "15")]
	void DEEDFLNEMBA(Rigidbody LHOBCJGBABO);

	[Cpp2IlInjected.Token(Token = "0x6000107")]
	[Cpp2IlInjected.Address(Slot = "16")]
	void JHBHKMFNBIH();
}
[Cpp2IlInjected.Token(Token = "0x2000012")]
public interface KAGCJGFIMHB
{
	[Cpp2IlInjected.Token(Token = "0x6000108")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void GMJBMKIKLGO();

	[Cpp2IlInjected.Token(Token = "0x6000109")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void OHNINFPNOII(object GNAAILLDOKI);

	[Cpp2IlInjected.Token(Token = "0x600010A")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void IPBAIJFACJH(object GNAAILLDOKI);

	[Cpp2IlInjected.Token(Token = "0x600010B")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void HGKNDEFAOKH(AEGDBIMJAKG JCJHLOEIIFO);

	[Cpp2IlInjected.Token(Token = "0x600010C")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void PGLEDKJCNGI(AEGDBIMJAKG JCJHLOEIIFO);

	[Cpp2IlInjected.Token(Token = "0x600010D")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void OGEOOICBKPD();
}
[Cpp2IlInjected.Token(Token = "0x2000013")]
public interface DLIEGGPBPJO
{
	[Cpp2IlInjected.Token(Token = "0x17000047")]
	bool JCNHMCMDBEI
	{
		[Cpp2IlInjected.Token(Token = "0x6000110")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x14000014")]
	event EIMKACMLCOF EIGIABMIGAC;

	[Cpp2IlInjected.Token(Token = "0x6000111")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void HDEFECDDIFF(object GNAAILLDOKI);

	[Cpp2IlInjected.Token(Token = "0x6000112")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void OPMHODNMBPM(object GNAAILLDOKI);

	[Cpp2IlInjected.Token(Token = "0x6000113")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void CHCLPGMJHFM(object GNAAILLDOKI, bool MLIEPCEKKKM);

	[Cpp2IlInjected.Token(Token = "0x6000114")]
	[Cpp2IlInjected.Address(Slot = "6")]
	void CGBEHGCJKJC(Rigidbody NEPEGLKEMNE);

	[Cpp2IlInjected.Token(Token = "0x6000115")]
	[Cpp2IlInjected.Address(Slot = "7")]
	void DEEDFLNEMBA(Rigidbody LHOBCJGBABO);
}
[Cpp2IlInjected.Token(Token = "0x2000014")]
public interface ONDFHDJOEBD : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x17000048")]
	bool MLJHDDKNOBB
	{
		[Cpp2IlInjected.Token(Token = "0x6000118")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000049")]
	bool NEMCFNAJMJP
	{
		[Cpp2IlInjected.Token(Token = "0x6000119")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x14000015")]
	event EIMKACMLCOF CEHFNLMIEBM;

	[Cpp2IlInjected.Token(Token = "0x600011A")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void GMJBMKIKLGO();

	[Cpp2IlInjected.Token(Token = "0x600011B")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void ELBMGNAHEAP(AEGDBIMJAKG HGBJMKAPAJA);

	[Cpp2IlInjected.Token(Token = "0x600011C")]
	[Cpp2IlInjected.Address(Slot = "6")]
	void GOPNOGMOMJD(AEGDBIMJAKG HGBJMKAPAJA);
}
[Cpp2IlInjected.Token(Token = "0x2000015")]
public interface BMKDEGFOAMG
{
	[Cpp2IlInjected.Token(Token = "0x1700004A")]
	bool PPGCBNJPMIA
	{
		[Cpp2IlInjected.Token(Token = "0x600011D")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
		[Cpp2IlInjected.Token(Token = "0x600011E")]
		[Cpp2IlInjected.Address(Slot = "1")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x1700004B")]
	bool KPLLMJIFLNJ
	{
		[Cpp2IlInjected.Token(Token = "0x600011F")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700004C")]
	RigidbodyConstraints JBABDFEEJCO
	{
		[Cpp2IlInjected.Token(Token = "0x6000120")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
		[Cpp2IlInjected.Token(Token = "0x6000121")]
		[Cpp2IlInjected.Address(Slot = "4")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x6000122")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void CGBEHGCJKJC(Rigidbody LHOBCJGBABO);

	[Cpp2IlInjected.Token(Token = "0x6000123")]
	[Cpp2IlInjected.Address(Slot = "6")]
	void DEEDFLNEMBA(Rigidbody LHOBCJGBABO);
}
[Cpp2IlInjected.Token(Token = "0x2000016")]
public interface LCPFLPPAHGD
{
	[Cpp2IlInjected.Token(Token = "0x1700004D")]
	float OPECJKNFJCK
	{
		[Cpp2IlInjected.Token(Token = "0x6000124")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
		[Cpp2IlInjected.Token(Token = "0x6000125")]
		[Cpp2IlInjected.Address(Slot = "1")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x1700004E")]
	float GHFBDEPLCDA
	{
		[Cpp2IlInjected.Token(Token = "0x6000126")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
		[Cpp2IlInjected.Token(Token = "0x6000127")]
		[Cpp2IlInjected.Address(Slot = "3")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x6000128")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void CGBEHGCJKJC(Rigidbody LHOBCJGBABO);

	[Cpp2IlInjected.Token(Token = "0x6000129")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void DEEDFLNEMBA(Rigidbody LHOBCJGBABO);
}
[Cpp2IlInjected.Token(Token = "0x2000017")]
public interface FHMKNHCIOOB
{
	[Cpp2IlInjected.Token(Token = "0x4000018")]
	static bool DFFNGLJGBNE;

	[Cpp2IlInjected.Token(Token = "0x14000016")]
	event EIMKACMLCOF LKAKPBAKBIE;

	[Cpp2IlInjected.Token(Token = "0x600012C")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void GMJBMKIKLGO();

	[Cpp2IlInjected.Token(Token = "0x600012D")]
	[Cpp2IlInjected.Address(Slot = "3")]
	bool HJMKGFNNCFL();

	[Cpp2IlInjected.Token(Token = "0x600012E")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void POBIIPGJMKK();

	[Cpp2IlInjected.Token(Token = "0x600012F")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void HNBPCPCJAHK();

	[Cpp2IlInjected.Token(Token = "0x6000130")]
	[Cpp2IlInjected.Address(Slot = "6")]
	bool EDPHOIGNEKN();

	[Cpp2IlInjected.Token(Token = "0x6000131")]
	[Cpp2IlInjected.Address(Slot = "7")]
	bool GJMFDPACDLB();

	[Cpp2IlInjected.Token(Token = "0x6000132")]
	[Cpp2IlInjected.Address(Slot = "8")]
	void LJHFLJNGPPE(bool NCEEHDIIPEK);

	[Cpp2IlInjected.Token(Token = "0x6000133")]
	[Cpp2IlInjected.Address(Slot = "9")]
	void KFPHNLHMHHJ();
}
[Cpp2IlInjected.Token(Token = "0x2000018")]
public interface JFEEDKNMOFN
{
	[Cpp2IlInjected.Token(Token = "0x1700004F")]
	Rigidbody JADPAFJKPGC
	{
		[Cpp2IlInjected.Token(Token = "0x6000134")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000050")]
	bool LFEPNDELHKF
	{
		[Cpp2IlInjected.Token(Token = "0x6000136")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000135")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void GMJBMKIKLGO();

	[Cpp2IlInjected.Token(Token = "0x6000137")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void MBNHJKHPNPC(object GNAAILLDOKI);

	[Cpp2IlInjected.Token(Token = "0x6000138")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void MPICDEHACKI(object GNAAILLDOKI);

	[Cpp2IlInjected.Token(Token = "0x6000139")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void GEGGEMKPKED();
}
[Cpp2IlInjected.Token(Token = "0x2000019")]
public interface HBGNPJEJHHJ : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x17000051")]
	EDDAFEHGANJ AIFJKNOJMPM
	{
		[Cpp2IlInjected.Token(Token = "0x600013A")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
		[Cpp2IlInjected.Token(Token = "0x600013B")]
		[Cpp2IlInjected.Address(Slot = "1")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000052")]
	PMMOKEJBHFJ OHCMFAEHIHD
	{
		[Cpp2IlInjected.Token(Token = "0x600013C")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
		[Cpp2IlInjected.Token(Token = "0x600013D")]
		[Cpp2IlInjected.Address(Slot = "3")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000053")]
	Vector3 JBOLMPDFKDF
	{
		[Cpp2IlInjected.Token(Token = "0x600013E")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
		[Cpp2IlInjected.Token(Token = "0x600013F")]
		[Cpp2IlInjected.Address(Slot = "5")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000054")]
	Vector3 GOMGLAPHAHG
	{
		[Cpp2IlInjected.Token(Token = "0x6000140")]
		[Cpp2IlInjected.Address(Slot = "6")]
		get;
		[Cpp2IlInjected.Token(Token = "0x6000141")]
		[Cpp2IlInjected.Address(Slot = "7")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000055")]
	Vector3 EEHIJMCACGH
	{
		[Cpp2IlInjected.Token(Token = "0x6000142")]
		[Cpp2IlInjected.Address(Slot = "8")]
		get;
		[Cpp2IlInjected.Token(Token = "0x6000143")]
		[Cpp2IlInjected.Address(Slot = "9")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000056")]
	Vector3 JFNNBNCGHBP
	{
		[Cpp2IlInjected.Token(Token = "0x6000144")]
		[Cpp2IlInjected.Address(Slot = "10")]
		get;
		[Cpp2IlInjected.Token(Token = "0x6000145")]
		[Cpp2IlInjected.Address(Slot = "11")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000057")]
	float PEJGPIMKEKB
	{
		[Cpp2IlInjected.Token(Token = "0x6000146")]
		[Cpp2IlInjected.Address(Slot = "12")]
		get;
		[Cpp2IlInjected.Token(Token = "0x6000147")]
		[Cpp2IlInjected.Address(Slot = "13")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000058")]
	bool MOCHOEMIBEB
	{
		[Cpp2IlInjected.Token(Token = "0x6000148")]
		[Cpp2IlInjected.Address(Slot = "14")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000149")]
	[Cpp2IlInjected.Address(Slot = "15")]
	void GMJBMKIKLGO();

	[Cpp2IlInjected.Token(Token = "0x600014A")]
	[Cpp2IlInjected.Address(Slot = "16")]
	void BOOFJIMLHGI(object GNAAILLDOKI);

	[Cpp2IlInjected.Token(Token = "0x600014B")]
	[Cpp2IlInjected.Address(Slot = "17")]
	void IINNMDPIFOE(MAHCBKNMHNB PEOJMKLPOGJ, Vector3 JBPODNLOLED, float MJDLKKNIKHJ = float.PositiveInfinity);

	[Cpp2IlInjected.Token(Token = "0x600014C")]
	[Cpp2IlInjected.Address(Slot = "18")]
	void DBPFGEEAFLO(NDBGGMAABME GLDACEOGKOF, Vector3 ICDAHOACGJL, float MFDBDMLHKBO, float CMEMFLLIBBI = 8f, float DMHCNEFBFKH = 1f);

	[Cpp2IlInjected.Token(Token = "0x600014D")]
	[Cpp2IlInjected.Address(Slot = "19")]
	void HEODHCBKGJC(MAHCBKNMHNB PEOJMKLPOGJ, Vector3 KONJHPLFEME, float MGFDEACAIGP = 7f, float DLPODANBMAG = 1f);

	[Cpp2IlInjected.Token(Token = "0x600014E")]
	[Cpp2IlInjected.Address(Slot = "20")]
	void DAJJDIHJIFG();

	[Cpp2IlInjected.Token(Token = "0x600014F")]
	[Cpp2IlInjected.Address(Slot = "21")]
	void NJBILFLLADD();

	[Cpp2IlInjected.Token(Token = "0x6000150")]
	[Cpp2IlInjected.Address(Slot = "22")]
	void OOFMNJCINFK();

	[Cpp2IlInjected.Token(Token = "0x6000151")]
	[Cpp2IlInjected.Address(Slot = "23")]
	void AIMEKICABJJ();

	[Cpp2IlInjected.Token(Token = "0x6000152")]
	[Cpp2IlInjected.Address(Slot = "24")]
	void CGBEHGCJKJC(Rigidbody LHOBCJGBABO);

	[Cpp2IlInjected.Token(Token = "0x6000153")]
	[Cpp2IlInjected.Address(Slot = "25")]
	Vector3 HMJDCLHNDNE(Vector3 FKMLPLAMBLK);

	[Cpp2IlInjected.Token(Token = "0x6000154")]
	[Cpp2IlInjected.Address(Slot = "26")]
	void CIBPDBGMCPN(object GNAAILLDOKI);

	[Cpp2IlInjected.Token(Token = "0x6000155")]
	[Cpp2IlInjected.Address(Slot = "27")]
	void FJAJFJCLDJK(Vector3 KKAPAIFKKGJ);

	[Cpp2IlInjected.Token(Token = "0x6000156")]
	[Cpp2IlInjected.Address(Slot = "28")]
	void PMJEDFAIGPL(Vector3 HOJGOCKJLEI, Vector3 HELMCCBIBJA);

	[Cpp2IlInjected.Token(Token = "0x6000157")]
	[Cpp2IlInjected.Address(Slot = "29")]
	void NDNMFEBPDPJ(Vector3 KKNIJFMODLP, Vector3 HAKGCOPLKEE);

	[Cpp2IlInjected.Token(Token = "0x6000158")]
	[Cpp2IlInjected.Address(Slot = "30")]
	Vector3 IGGJJBLPPKA(Vector3 NJBLGKBFLMG);

	[Cpp2IlInjected.Token(Token = "0x6000159")]
	[Cpp2IlInjected.Address(Slot = "31")]
	Vector3 ABOAMJNOFCD(Vector3 PJJJJDKGMGH);
}
[Cpp2IlInjected.Token(Token = "0x200001A")]
[ServiceLifetime(Lifetime.Application)]
public interface CAFCKCAPGDN
{
	[Cpp2IlInjected.Token(Token = "0x17000059")]
	bool GMACHBGOPCJ
	{
		[Cpp2IlInjected.Token(Token = "0x600015A")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x600015B")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void HGIJGKHAACH(string LPNLOGECJBM);

	[Cpp2IlInjected.Token(Token = "0x600015C")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void IHKJJDCCCNF(RigidbodyEx JCJHLOEIIFO, Action HNDDBOOOBBE);

	[Cpp2IlInjected.Token(Token = "0x600015D")]
	[Cpp2IlInjected.Address(Slot = "3")]
	KMDJIMFKBFI PGIIJKGHHHM(int CAEDMOOMJDO);

	[Cpp2IlInjected.Token(Token = "0x600015E")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void JHMNLKPJMFM(Vector3 KLFGFLOMJGI, float JHEFGHPNHKO, Color IFFOAMBAJEI);
}
[Cpp2IlInjected.Token(Token = "0x200001B")]
[ServiceLifetime(Lifetime.Application)]
public interface OOJMOMLJPBI
{
	[Cpp2IlInjected.Token(Token = "0x1700005A")]
	CAFCKCAPGDN MNIGFADEFAD
	{
		[Cpp2IlInjected.Token(Token = "0x600015F")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700005B")]
	MKHGFDOKEMI IEOBPJCNMBJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000160")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000161")]
	[Cpp2IlInjected.Address(Slot = "2")]
	AEGDBIMJAKG DOFDPJBFNDD(RigidbodyEx JCJHLOEIIFO);
}
[Cpp2IlInjected.Token(Token = "0x200001C")]
public class AFDHKDDEFPL : AEGDBIMJAKG, IDisposable, MBJKPHMMLHB
{
	[Cpp2IlInjected.Token(Token = "0x4000019")]
	public static bool BCOGILMEFMK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400001A")]
	internal readonly OOJMOMLJPBI GIGHOMPCPHH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400001B")]
	internal HNIPPCIEEBF JBPNNEGFBPO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400001C")]
	internal KAGCJGFIMHB DPOHAOKLOOL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400001D")]
	internal ONDFHDJOEBD LIGNHNMILNA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400001E")]
	internal HBGNPJEJHHJ FKMLPLAMBLK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x400001F")]
	internal OMFLDLCMAPK ACHBDCDAFHA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000020")]
	internal JFADAMMEHIM FGHBHMJNCMN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000021")]
	internal LCPFLPPAHGD KBGADBBGHEA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000022")]
	internal CFENPGCEIEG FJPLNJMEMDK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x4000023")]
	internal FHMKNHCIOOB NFJCNCJKHLL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x4000024")]
	internal ODGBGICJCIB EMMOECMMAML;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x4000025")]
	internal DLIEGGPBPJO GALPLBDGKKH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x4000026")]
	internal BIENKFHPJMP JDEIJIAFEMH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
	[Cpp2IlInjected.Token(Token = "0x4000027")]
	internal BMKDEGFOAMG LCGMBNOOMKJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x4000028")]
	internal JFEEDKNMOFN LHOBCJGBABO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
	[Cpp2IlInjected.Token(Token = "0x4000029")]
	internal ANNBJDFMKOO JBCBOFKFNJN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
	[Cpp2IlInjected.Token(Token = "0x400002A")]
	internal IDisposable ICJJGFGGHDA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
	[Cpp2IlInjected.Token(Token = "0x400002B")]
	private bool PKELOJABDNI;

	[Cpp2IlInjected.Token(Token = "0x1700005C")]
	public ECEDHFIPBHO FKCNNLDLMJI
	{
		[Cpp2IlInjected.Token(Token = "0x6000162")]
		[Cpp2IlInjected.Address(RVA = "0x9AE070", Offset = "0x9ACA70", VA = "0x1809AE070", Slot = "22")]
		get
		{
			return default(ECEDHFIPBHO);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700005D")]
	public COGOJKBIHHJ KOPGJJGMPFH
	{
		[Cpp2IlInjected.Token(Token = "0x6000163")]
		[Cpp2IlInjected.Address(RVA = "0xC5B7C0", Offset = "0xC5A1C0", VA = "0x180C5B7C0", Slot = "24")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000164")]
		[Cpp2IlInjected.Address(RVA = "0xDC7F50", Offset = "0xDC6950", VA = "0x180DC7F50")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700005E")]
	public GameObject OJFCLDLGCBC
	{
		[Cpp2IlInjected.Token(Token = "0x6000165")]
		[Cpp2IlInjected.Address(RVA = "0x9B1780", Offset = "0x9B0180", VA = "0x1809B1780", Slot = "25")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000166")]
		[Cpp2IlInjected.Address(RVA = "0x9B17D0", Offset = "0x9B01D0", VA = "0x1809B17D0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700005F")]
	public Transform GKBGOMKDLDP
	{
		[Cpp2IlInjected.Token(Token = "0x6000167")]
		[Cpp2IlInjected.Address(RVA = "0xBA86E0", Offset = "0xBA70E0", VA = "0x180BA86E0", Slot = "26")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000168")]
		[Cpp2IlInjected.Address(RVA = "0xDD5050", Offset = "0xDD3A50", VA = "0x180DD5050")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000060")]
	public Rigidbody JADPAFJKPGC
	{
		[Cpp2IlInjected.Token(Token = "0x6000169")]
		[Cpp2IlInjected.Address(RVA = "0x8057710", Offset = "0x8056110", VA = "0x188057710", Slot = "23")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000061")]
	public AEGDBIMJAKG LKNIONJKNBM
	{
		[Cpp2IlInjected.Token(Token = "0x600017A")]
		[Cpp2IlInjected.Address(RVA = "0x8053480", Offset = "0x8051E80", VA = "0x188053480", Slot = "27")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600017B")]
		[Cpp2IlInjected.Address(RVA = "0x8054390", Offset = "0x8052D90", VA = "0x188054390", Slot = "28")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000062")]
	public int BLOGALEBJJB
	{
		[Cpp2IlInjected.Token(Token = "0x600017C")]
		[Cpp2IlInjected.Address(RVA = "0x8051560", Offset = "0x804FF60", VA = "0x188051560", Slot = "31")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000063")]
	public AEGDBIMJAKG LKAEGJLGAIG
	{
		[Cpp2IlInjected.Token(Token = "0x600017E")]
		[Cpp2IlInjected.Address(RVA = "0x8053720", Offset = "0x8052120", VA = "0x188053720", Slot = "29")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000064")]
	public bool JBBBMCHECPD
	{
		[Cpp2IlInjected.Token(Token = "0x600017F")]
		[Cpp2IlInjected.Address(RVA = "0x8052BD0", Offset = "0x80515D0", VA = "0x188052BD0", Slot = "32")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000065")]
	public bool MLJHDDKNOBB
	{
		[Cpp2IlInjected.Token(Token = "0x6000183")]
		[Cpp2IlInjected.Address(RVA = "0x8055210", Offset = "0x8053C10", VA = "0x188055210", Slot = "33")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000066")]
	public bool NEMCFNAJMJP
	{
		[Cpp2IlInjected.Token(Token = "0x6000184")]
		[Cpp2IlInjected.Address(RVA = "0x8051980", Offset = "0x8050380", VA = "0x188051980", Slot = "34")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000067")]
	public EDDAFEHGANJ AIFJKNOJMPM
	{
		[Cpp2IlInjected.Token(Token = "0x6000185")]
		[Cpp2IlInjected.Address(RVA = "0x8053FB0", Offset = "0x80529B0", VA = "0x188053FB0", Slot = "35")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000186")]
		[Cpp2IlInjected.Address(RVA = "0x8053250", Offset = "0x8051C50", VA = "0x188053250", Slot = "36")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000068")]
	public PMMOKEJBHFJ OHCMFAEHIHD
	{
		[Cpp2IlInjected.Token(Token = "0x6000187")]
		[Cpp2IlInjected.Address(RVA = "0x8051CE0", Offset = "0x80506E0", VA = "0x188051CE0", Slot = "37")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000188")]
		[Cpp2IlInjected.Address(RVA = "0x8055990", Offset = "0x8054390", VA = "0x188055990", Slot = "38")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000069")]
	public float PEJGPIMKEKB
	{
		[Cpp2IlInjected.Token(Token = "0x6000189")]
		[Cpp2IlInjected.Address(RVA = "0x8054820", Offset = "0x8053220", VA = "0x188054820", Slot = "39")]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x600018A")]
		[Cpp2IlInjected.Address(RVA = "0x8052F00", Offset = "0x8051900", VA = "0x188052F00", Slot = "40")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700006A")]
	public Vector3 GOMGLAPHAHG
	{
		[Cpp2IlInjected.Token(Token = "0x600018B")]
		[Cpp2IlInjected.Address(RVA = "0x8055490", Offset = "0x8053E90", VA = "0x188055490", Slot = "41")]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x600018C")]
		[Cpp2IlInjected.Address(RVA = "0x8052E20", Offset = "0x8051820", VA = "0x188052E20", Slot = "42")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700006B")]
	public Vector3 JFNNBNCGHBP
	{
		[Cpp2IlInjected.Token(Token = "0x600018D")]
		[Cpp2IlInjected.Address(RVA = "0x8053170", Offset = "0x8051B70", VA = "0x188053170", Slot = "43")]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x600018E")]
		[Cpp2IlInjected.Address(RVA = "0x8055C70", Offset = "0x8054670", VA = "0x188055C70", Slot = "44")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700006C")]
	public Vector3 JBOLMPDFKDF
	{
		[Cpp2IlInjected.Token(Token = "0x600018F")]
		[Cpp2IlInjected.Address(RVA = "0x8053D20", Offset = "0x8052720", VA = "0x188053D20", Slot = "45")]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x6000190")]
		[Cpp2IlInjected.Address(RVA = "0x8052A90", Offset = "0x8051490", VA = "0x188052A90", Slot = "46")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700006D")]
	public Vector3 EEHIJMCACGH
	{
		[Cpp2IlInjected.Token(Token = "0x6000191")]
		[Cpp2IlInjected.Address(RVA = "0x8057250", Offset = "0x8055C50", VA = "0x188057250", Slot = "47")]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x6000192")]
		[Cpp2IlInjected.Address(RVA = "0x8056FE0", Offset = "0x80559E0", VA = "0x188056FE0", Slot = "48")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700006E")]
	public bool EABHEGNBDMC
	{
		[Cpp2IlInjected.Token(Token = "0x6000193")]
		[Cpp2IlInjected.Address(RVA = "0x8057330", Offset = "0x8055D30", VA = "0x188057330", Slot = "49")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700006F")]
	public bool DOGEECAEPBA
	{
		[Cpp2IlInjected.Token(Token = "0x6000194")]
		[Cpp2IlInjected.Address(RVA = "0x80570C0", Offset = "0x8055AC0", VA = "0x1880570C0", Slot = "50")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000070")]
	public bool FLGAHILHJCD
	{
		[Cpp2IlInjected.Token(Token = "0x6000195")]
		[Cpp2IlInjected.Address(RVA = "0x8055570", Offset = "0x8053F70", VA = "0x188055570", Slot = "51")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000071")]
	public bool MOCHOEMIBEB
	{
		[Cpp2IlInjected.Token(Token = "0x6000196")]
		[Cpp2IlInjected.Address(RVA = "0x8052650", Offset = "0x8051050", VA = "0x188052650", Slot = "52")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000072")]
	public Vector3 DGGLPPHNMBJ
	{
		[Cpp2IlInjected.Token(Token = "0x60001A7")]
		[Cpp2IlInjected.Address(RVA = "0x8055E80", Offset = "0x8054880", VA = "0x188055E80", Slot = "53")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000073")]
	public Vector3 FPBOMHPDKGJ
	{
		[Cpp2IlInjected.Token(Token = "0x60001A8")]
		[Cpp2IlInjected.Address(RVA = "0x8056C30", Offset = "0x8055630", VA = "0x188056C30", Slot = "54")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000074")]
	public Vector3 LEJBCFNAOGD
	{
		[Cpp2IlInjected.Token(Token = "0x60001AD")]
		[Cpp2IlInjected.Address(RVA = "0x8056D60", Offset = "0x8055760", VA = "0x188056D60", Slot = "55")]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x60001AE")]
		[Cpp2IlInjected.Address(RVA = "0x8055F50", Offset = "0x8054950", VA = "0x188055F50", Slot = "56")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000075")]
	public Vector3 NFBCHABDNEC
	{
		[Cpp2IlInjected.Token(Token = "0x60001AF")]
		[Cpp2IlInjected.Address(RVA = "0x8056E40", Offset = "0x8055840", VA = "0x188056E40", Slot = "57")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000076")]
	public float DCHGLADGMNH
	{
		[Cpp2IlInjected.Token(Token = "0x60001B0")]
		[Cpp2IlInjected.Address(RVA = "0x8054C20", Offset = "0x8053620", VA = "0x188054C20", Slot = "58")]
		get
		{
			return default(float);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000077")]
	public float FBDCBPLJJNH
	{
		[Cpp2IlInjected.Token(Token = "0x60001B1")]
		[Cpp2IlInjected.Address(RVA = "0x80526F0", Offset = "0x80510F0", VA = "0x1880526F0", Slot = "59")]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x60001B2")]
		[Cpp2IlInjected.Address(RVA = "0x8052B70", Offset = "0x8051570", VA = "0x188052B70", Slot = "60")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000078")]
	public Vector3 BIFJODANNFE
	{
		[Cpp2IlInjected.Token(Token = "0x60001B3")]
		[Cpp2IlInjected.Address(RVA = "0x80534D0", Offset = "0x8051ED0", VA = "0x1880534D0", Slot = "61")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000079")]
	public Quaternion GDOEFFLGCMO
	{
		[Cpp2IlInjected.Token(Token = "0x60001B4")]
		[Cpp2IlInjected.Address(RVA = "0x8054EC0", Offset = "0x80538C0", VA = "0x188054EC0", Slot = "62")]
		get
		{
			return default(Quaternion);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700007A")]
	public float OPECJKNFJCK
	{
		[Cpp2IlInjected.Token(Token = "0x60001B9")]
		[Cpp2IlInjected.Address(RVA = "0x8057200", Offset = "0x8055C00", VA = "0x188057200", Slot = "64")]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x60001BA")]
		[Cpp2IlInjected.Address(RVA = "0x8052A30", Offset = "0x8051430", VA = "0x188052A30", Slot = "65")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700007B")]
	public float GHFBDEPLCDA
	{
		[Cpp2IlInjected.Token(Token = "0x60001BB")]
		[Cpp2IlInjected.Address(RVA = "0x80536D0", Offset = "0x80520D0", VA = "0x1880536D0", Slot = "66")]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x60001BC")]
		[Cpp2IlInjected.Address(RVA = "0x8052330", Offset = "0x8050D30", VA = "0x188052330", Slot = "67")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700007C")]
	public bool LOEEGOLECOO
	{
		[Cpp2IlInjected.Token(Token = "0x60001BD")]
		[Cpp2IlInjected.Address(RVA = "0x8054E10", Offset = "0x8053810", VA = "0x188054E10", Slot = "68")]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x60001BE")]
		[Cpp2IlInjected.Address(RVA = "0x8053C10", Offset = "0x8052610", VA = "0x188053C10", Slot = "69")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700007D")]
	public JFFGEHLFDPP HBFBJDHEFMD
	{
		[Cpp2IlInjected.Token(Token = "0x60001C6")]
		[Cpp2IlInjected.Address(RVA = "0x80558E0", Offset = "0x80542E0", VA = "0x1880558E0", Slot = "70")]
		get
		{
			return default(JFFGEHLFDPP);
		}
		[Cpp2IlInjected.Token(Token = "0x60001C7")]
		[Cpp2IlInjected.Address(RVA = "0x8056860", Offset = "0x8055260", VA = "0x188056860", Slot = "71")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700007E")]
	public bool JCNHMCMDBEI
	{
		[Cpp2IlInjected.Token(Token = "0x60001CA")]
		[Cpp2IlInjected.Address(RVA = "0x80526A0", Offset = "0x80510A0", VA = "0x1880526A0", Slot = "72")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700007F")]
	public Transform OEODHDMIDIH
	{
		[Cpp2IlInjected.Token(Token = "0x60001D0")]
		[Cpp2IlInjected.Address(RVA = "0xBA86E0", Offset = "0xBA70E0", VA = "0x180BA86E0", Slot = "73")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000080")]
	public Vector3 FKJGNPDLIOJ
	{
		[Cpp2IlInjected.Token(Token = "0x60001D1")]
		[Cpp2IlInjected.Address(RVA = "0x8055BC0", Offset = "0x80545C0", VA = "0x188055BC0", Slot = "74")]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x60001D2")]
		[Cpp2IlInjected.Address(RVA = "0x80525A0", Offset = "0x8050FA0", VA = "0x1880525A0", Slot = "75")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000081")]
	public float POFGGGLCGCJ
	{
		[Cpp2IlInjected.Token(Token = "0x60001D3")]
		[Cpp2IlInjected.Address(RVA = "0x8054130", Offset = "0x8052B30", VA = "0x188054130", Slot = "76")]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x60001D4")]
		[Cpp2IlInjected.Address(RVA = "0x8055E10", Offset = "0x8054810", VA = "0x188055E10", Slot = "77")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000082")]
	public float MMEODJGGKNH
	{
		[Cpp2IlInjected.Token(Token = "0x60001D5")]
		[Cpp2IlInjected.Address(RVA = "0x8057490", Offset = "0x8055E90", VA = "0x188057490", Slot = "78")]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x60001D6")]
		[Cpp2IlInjected.Address(RVA = "0x80557C0", Offset = "0x80541C0", VA = "0x1880557C0", Slot = "79")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000083")]
	public Quaternion LPIDAMMACLJ
	{
		[Cpp2IlInjected.Token(Token = "0x60001D7")]
		[Cpp2IlInjected.Address(RVA = "0x8053770", Offset = "0x8052170", VA = "0x188053770", Slot = "80")]
		get
		{
			return default(Quaternion);
		}
		[Cpp2IlInjected.Token(Token = "0x60001D8")]
		[Cpp2IlInjected.Address(RVA = "0x8052F60", Offset = "0x8051960", VA = "0x188052F60", Slot = "81")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000084")]
	public Vector3 GLJBENMMLGO
	{
		[Cpp2IlInjected.Token(Token = "0x60001D9")]
		[Cpp2IlInjected.Address(RVA = "0x80558A0", Offset = "0x80542A0", VA = "0x1880558A0", Slot = "82")]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x60001DA")]
		[Cpp2IlInjected.Address(RVA = "0x8052840", Offset = "0x8051240", VA = "0x188052840", Slot = "83")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000085")]
	public Quaternion GDFHKBKNAFF
	{
		[Cpp2IlInjected.Token(Token = "0x60001DB")]
		[Cpp2IlInjected.Address(RVA = "0x80543F0", Offset = "0x8052DF0", VA = "0x1880543F0", Slot = "84")]
		get
		{
			return default(Quaternion);
		}
		[Cpp2IlInjected.Token(Token = "0x60001DC")]
		[Cpp2IlInjected.Address(RVA = "0x80576E0", Offset = "0x80560E0", VA = "0x1880576E0", Slot = "85")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000086")]
	public RigidbodyConstraints JBABDFEEJCO
	{
		[Cpp2IlInjected.Token(Token = "0x60001E0")]
		[Cpp2IlInjected.Address(RVA = "0x8056BE0", Offset = "0x80555E0", VA = "0x188056BE0", Slot = "86")]
		get
		{
			return default(RigidbodyConstraints);
		}
		[Cpp2IlInjected.Token(Token = "0x60001E1")]
		[Cpp2IlInjected.Address(RVA = "0x8054E60", Offset = "0x8053860", VA = "0x188054E60", Slot = "87")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000087")]
	public bool PPGCBNJPMIA
	{
		[Cpp2IlInjected.Token(Token = "0x60001E2")]
		[Cpp2IlInjected.Address(RVA = "0x8051670", Offset = "0x8050070", VA = "0x188051670", Slot = "88")]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x60001E3")]
		[Cpp2IlInjected.Address(RVA = "0x80559F0", Offset = "0x80543F0", VA = "0x1880559F0", Slot = "89")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000088")]
	public CollisionDetectionMode INCBHDMGFBA
	{
		[Cpp2IlInjected.Token(Token = "0x60001EC")]
		[Cpp2IlInjected.Address(RVA = "0x8056910", Offset = "0x8055310", VA = "0x188056910", Slot = "90")]
		get
		{
			return default(CollisionDetectionMode);
		}
		[Cpp2IlInjected.Token(Token = "0x60001ED")]
		[Cpp2IlInjected.Address(RVA = "0x8056B80", Offset = "0x8055580", VA = "0x188056B80", Slot = "91")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000089")]
	public bool OIHDLNHKKLG
	{
		[Cpp2IlInjected.Token(Token = "0x60001EF")]
		[Cpp2IlInjected.Address(RVA = "0x8051DA0", Offset = "0x80507A0", VA = "0x188051DA0", Slot = "141")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700008A")]
	public bool GBHOGBPJMED
	{
		[Cpp2IlInjected.Token(Token = "0x60001F0")]
		[Cpp2IlInjected.Address(RVA = "0x8055260", Offset = "0x8053C60", VA = "0x188055260", Slot = "92")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000017")]
	public event EIMKACMLCOF HPMNGIDAKOL
	{
		[Cpp2IlInjected.Token(Token = "0x6000174")]
		[Cpp2IlInjected.Address(RVA = "0x8053110", Offset = "0x8051B10", VA = "0x188053110", Slot = "4")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000175")]
		[Cpp2IlInjected.Address(RVA = "0x8057430", Offset = "0x8055E30", VA = "0x188057430", Slot = "5")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000018")]
	public event EIMKACMLCOF BEOPJEDGIKK
	{
		[Cpp2IlInjected.Token(Token = "0x6000176")]
		[Cpp2IlInjected.Address(RVA = "0x8055B60", Offset = "0x8054560", VA = "0x188055B60", Slot = "6")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000177")]
		[Cpp2IlInjected.Address(RVA = "0x80571A0", Offset = "0x8055BA0", VA = "0x1880571A0", Slot = "7")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000019")]
	public event AAILGCMHGNK JICLOCIGEGP
	{
		[Cpp2IlInjected.Token(Token = "0x6000178")]
		[Cpp2IlInjected.Address(RVA = "0x80574A0", Offset = "0x8055EA0", VA = "0x1880574A0", Slot = "18")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000179")]
		[Cpp2IlInjected.Address(RVA = "0x8056F80", Offset = "0x8055980", VA = "0x188056F80", Slot = "19")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400001A")]
	public event EIMKACMLCOF CEHFNLMIEBM
	{
		[Cpp2IlInjected.Token(Token = "0x6000181")]
		[Cpp2IlInjected.Address(RVA = "0x8056120", Offset = "0x8054B20", VA = "0x188056120", Slot = "8")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000182")]
		[Cpp2IlInjected.Address(RVA = "0x8057680", Offset = "0x8056080", VA = "0x188057680", Slot = "9")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400001B")]
	public event EIMKACMLCOF JJHDIEMPODM
	{
		[Cpp2IlInjected.Token(Token = "0x60001AB")]
		[Cpp2IlInjected.Address(RVA = "0x8053F50", Offset = "0x8052950", VA = "0x188053F50", Slot = "14")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60001AC")]
		[Cpp2IlInjected.Address(RVA = "0x8053CC0", Offset = "0x80526C0", VA = "0x188053CC0", Slot = "15")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400001C")]
	public event EIMKACMLCOF LKAKPBAKBIE
	{
		[Cpp2IlInjected.Token(Token = "0x60001BF")]
		[Cpp2IlInjected.Address(RVA = "0x8052C90", Offset = "0x8051690", VA = "0x188052C90", Slot = "16")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60001C0")]
		[Cpp2IlInjected.Address(RVA = "0x8051390", Offset = "0x804FD90", VA = "0x188051390", Slot = "17")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400001D")]
	public event Action<HNIGDDENMGF, HNIGDDENMGF> KFNJJBLINJE
	{
		[Cpp2IlInjected.Token(Token = "0x60001C4")]
		[Cpp2IlInjected.Address(RVA = "0x80519D0", Offset = "0x80503D0", VA = "0x1880519D0", Slot = "20")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60001C5")]
		[Cpp2IlInjected.Address(RVA = "0x8054C70", Offset = "0x8053670", VA = "0x188054C70", Slot = "21")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400001E")]
	public event EIMKACMLCOF EIGIABMIGAC
	{
		[Cpp2IlInjected.Token(Token = "0x60001C8")]
		[Cpp2IlInjected.Address(RVA = "0x8054490", Offset = "0x8052E90", VA = "0x188054490", Slot = "12")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60001C9")]
		[Cpp2IlInjected.Address(RVA = "0x8054430", Offset = "0x8052E30", VA = "0x188054430", Slot = "13")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400001F")]
	public event EIMKACMLCOF MJLJPIFOJCD
	{
		[Cpp2IlInjected.Token(Token = "0x60001CE")]
		[Cpp2IlInjected.Address(RVA = "0x8057380", Offset = "0x8055D80", VA = "0x188057380", Slot = "10")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60001CF")]
		[Cpp2IlInjected.Address(RVA = "0x8054A20", Offset = "0x8053420", VA = "0x188054A20", Slot = "11")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600016A")]
	[Cpp2IlInjected.Address(RVA = "0x80577A0", Offset = "0x80561A0", VA = "0x1880577A0")]
	public AFDHKDDEFPL(GameObject IHDAMAGFMLN, RigidbodyEx NNJJGBANEDH, OOJMOMLJPBI GIGHOMPCPHH, [In] BNAMPFDBALG DFPGGEDGGGN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600016B")]
	[Cpp2IlInjected.Address(RVA = "0x8053870", Offset = "0x8052270", VA = "0x188053870", Slot = "139")]
	protected virtual void HEIHLMLGAFP(OOJMOMLJPBI GIGHOMPCPHH, BNAMPFDBALG DFPGGEDGGGN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600016C")]
	[Cpp2IlInjected.Address(RVA = "0x8052740", Offset = "0x8051140", VA = "0x188052740", Slot = "140")]
	public virtual void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600016D")]
	[Cpp2IlInjected.Address(RVA = "0x8053340", Offset = "0x8051D40", VA = "0x188053340", Slot = "93")]
	public void GMJBMKIKLGO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600016E")]
	[Cpp2IlInjected.Address(RVA = "0x8051BF0", Offset = "0x80505F0", VA = "0x188051BF0", Slot = "94")]
	public void CCMHLPMEACK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600016F")]
	[Cpp2IlInjected.Address(RVA = "0x8055DB0", Offset = "0x80547B0", VA = "0x188055DB0", Slot = "95")]
	public void NAEDHDKIOFD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000170")]
	[Cpp2IlInjected.Address(RVA = "0x8057500", Offset = "0x8055F00", VA = "0x188057500", Slot = "96")]
	public void PLINLFMHMME()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000171")]
	[Cpp2IlInjected.Address(RVA = "0x8054F90", Offset = "0x8053990", VA = "0x188054F90")]
	private void LJHFLJNGPPE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000172")]
	[Cpp2IlInjected.Address(RVA = "0x80516C0", Offset = "0x80500C0", VA = "0x1880516C0")]
	private void ALFJEKONLCA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000173")]
	[Cpp2IlInjected.Address(RVA = "0x80530B0", Offset = "0x8051AB0", VA = "0x1880530B0")]
	private void GJMFDPACDLB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600017D")]
	[Cpp2IlInjected.Address(RVA = "0x8057120", Offset = "0x8055B20", VA = "0x188057120", Slot = "30")]
	public AEGDBIMJAKG PHKGBJEBKCC(int DOAKEFBOPIA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000180")]
	[Cpp2IlInjected.Address(RVA = "0x8053040", Offset = "0x8051A40", VA = "0x188053040", Slot = "98")]
	public void GICBAHPKOCO(AEGDBIMJAKG PPJFMHBDGNA, bool OFLGEPPEKAD = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000197")]
	[Cpp2IlInjected.Address(RVA = "0x8051C80", Offset = "0x8050680", VA = "0x188051C80", Slot = "99")]
	public void CELCJCJPFBE(object GNAAILLDOKI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000198")]
	[Cpp2IlInjected.Address(RVA = "0x8055930", Offset = "0x8054330", VA = "0x188055930", Slot = "100")]
	public void MGKNBKAMPOB(object GNAAILLDOKI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000199")]
	[Cpp2IlInjected.Address(RVA = "0x8051290", Offset = "0x804FC90", VA = "0x188051290", Slot = "101")]
	public Vector3 ABOAMJNOFCD(Vector3 PJJJJDKGMGH)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x600019A")]
	[Cpp2IlInjected.Address(RVA = "0x8054190", Offset = "0x8052B90", VA = "0x188054190", Slot = "102")]
	public Vector3 IGGJJBLPPKA(Vector3 NJBLGKBFLMG)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x600019B")]
	[Cpp2IlInjected.Address(RVA = "0x80515D0", Offset = "0x804FFD0", VA = "0x1880515D0", Slot = "103")]
	public void AIMEKICABJJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600019C")]
	[Cpp2IlInjected.Address(RVA = "0x80568C0", Offset = "0x80552C0", VA = "0x1880568C0", Slot = "104")]
	public void NJBILFLLADD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600019D")]
	[Cpp2IlInjected.Address(RVA = "0x8052390", Offset = "0x8050D90", VA = "0x188052390", Slot = "105")]
	public void DAJJDIHJIFG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600019E")]
	[Cpp2IlInjected.Address(RVA = "0x8056030", Offset = "0x8054A30", VA = "0x188056030", Slot = "106")]
	public void NDNMFEBPDPJ(Vector3 KKNIJFMODLP, Vector3 HAKGCOPLKEE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600019F")]
	[Cpp2IlInjected.Address(RVA = "0x8057590", Offset = "0x8055F90", VA = "0x188057590", Slot = "107")]
	public void PMJEDFAIGPL(Vector3 HOJGOCKJLEI, Vector3 HELMCCBIBJA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001A0")]
	[Cpp2IlInjected.Address(RVA = "0x8052D40", Offset = "0x8051740", VA = "0x188052D40", Slot = "108")]
	public void FJAJFJCLDJK(Vector3 KKAPAIFKKGJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001A1")]
	[Cpp2IlInjected.Address(RVA = "0x80523E0", Offset = "0x8050DE0", VA = "0x1880523E0", Slot = "109")]
	public void DBPFGEEAFLO(NDBGGMAABME GLDACEOGKOF, Vector3 ICDAHOACGJL, float MFDBDMLHKBO, float CMEMFLLIBBI = 8f, float DMHCNEFBFKH = 1f)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001A2")]
	[Cpp2IlInjected.Address(RVA = "0x8054290", Offset = "0x8052C90", VA = "0x188054290", Slot = "110")]
	public void IINNMDPIFOE(MAHCBKNMHNB PEOJMKLPOGJ, Vector3 JBPODNLOLED, float MJDLKKNIKHJ = float.PositiveInfinity)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001A3")]
	[Cpp2IlInjected.Address(RVA = "0x8053B60", Offset = "0x8052560", VA = "0x188053B60", Slot = "111")]
	[Obsolete("Deprecated. Still exists to support deprecated CV2 chips. Use ApplyAngularVelocityChange.")]
	public void HEODHCBKGJC(MAHCBKNMHNB PEOJMKLPOGJ, Vector3 KONJHPLFEME, float MGFDEACAIGP = 7f, float DLPODANBMAG = 1f)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001A4")]
	[Cpp2IlInjected.Address(RVA = "0x8053E00", Offset = "0x8052800", VA = "0x188053E00", Slot = "112")]
	public Vector3 HMJDCLHNDNE(Vector3 PPJFMHBDGNA)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x60001A5")]
	[Cpp2IlInjected.Address(RVA = "0x80524A0", Offset = "0x8050EA0", VA = "0x1880524A0", Slot = "113")]
	public Vector3 DEBOLEMLKPP(Vector3 PPJFMHBDGNA)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x60001A6")]
	[Cpp2IlInjected.Address(RVA = "0x8056D10", Offset = "0x8055710", VA = "0x188056D10", Slot = "114")]
	public void OOFMNJCINFK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001A9")]
	[Cpp2IlInjected.Address(RVA = "0x8057520", Offset = "0x8055F20", VA = "0x188057520", Slot = "115")]
	public void PLMELKDEAFH(AEGDBIMJAKG GOKDJANKNKE, object GNAAILLDOKI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001AA")]
	[Cpp2IlInjected.Address(RVA = "0x8051740", Offset = "0x8050140", VA = "0x188051740", Slot = "116")]
	public void BEPKDMMKGFO(object GNAAILLDOKI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001B5")]
	[Cpp2IlInjected.Address(RVA = "0x80544F0", Offset = "0x8052EF0", VA = "0x1880544F0", Slot = "63")]
	public void JFACDNBLNMA((Quaternion rot, Vector3 moments) BFILMAEAIPL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001B6")]
	[Cpp2IlInjected.Address(RVA = "0x8051620", Offset = "0x8050020", VA = "0x188051620", Slot = "117")]
	public void AKMOEEOCJGK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001B7")]
	[Cpp2IlInjected.Address(RVA = "0x8053680", Offset = "0x8052080", VA = "0x188053680", Slot = "118")]
	public void HAFANPILNFO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001B8")]
	[Cpp2IlInjected.Address(RVA = "0x8054140", Offset = "0x8052B40", VA = "0x188054140", Slot = "119")]
	public void ICCOCPPFPIM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001C1")]
	[Cpp2IlInjected.Address(RVA = "0x8053C70", Offset = "0x8052670", VA = "0x188053C70", Slot = "120")]
	public bool HJMKGFNNCFL()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001C2")]
	[Cpp2IlInjected.Address(RVA = "0x8053F00", Offset = "0x8052900", VA = "0x188053F00", Slot = "97")]
	public void HNBPCPCJAHK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001C3")]
	[Cpp2IlInjected.Address(RVA = "0x8054CD0", Offset = "0x80536D0", VA = "0x188054CD0", Slot = "121")]
	public void KFPHNLHMHHJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001CB")]
	[Cpp2IlInjected.Address(RVA = "0x8053810", Offset = "0x8052210", VA = "0x188053810", Slot = "122")]
	public void HDEFECDDIFF(object GNAAILLDOKI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001CC")]
	[Cpp2IlInjected.Address(RVA = "0x8056F20", Offset = "0x8055920", VA = "0x188056F20", Slot = "123")]
	public void OPMHODNMBPM(object GNAAILLDOKI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001CD")]
	[Cpp2IlInjected.Address(RVA = "0x8051D30", Offset = "0x8050730", VA = "0x188051D30", Slot = "124")]
	public void CHCLPGMJHFM(object GNAAILLDOKI, bool MLIEPCEKKKM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001DD")]
	[Cpp2IlInjected.Address(RVA = "0x8054620", Offset = "0x8053020", VA = "0x188054620", Slot = "125")]
	public void JMJIBLJDLFB(Vector3 FBLMAAJOADP, Quaternion FIDEGHHFHJK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001DE")]
	[Cpp2IlInjected.Address(RVA = "0x8054000", Offset = "0x8052A00", VA = "0x188054000", Slot = "126")]
	public void IAMDFGGLGMI(Vector3 HAMPBLAEJPA, Quaternion OCDILGIKBNM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001DF")]
	[Cpp2IlInjected.Address(RVA = "0x8052CF0", Offset = "0x80516F0", VA = "0x188052CF0", Slot = "127")]
	public bool FIIMCLPFNID(float DFLDIKKIDLP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001E4")]
	[Cpp2IlInjected.Address(RVA = "0x8052C30", Offset = "0x8051630", VA = "0x188052C30", Slot = "128")]
	public void FDLBLIHCADK(object GNAAILLDOKI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001E5")]
	[Cpp2IlInjected.Address(RVA = "0x8056960", Offset = "0x8055360", VA = "0x188056960", Slot = "129")]
	public void NOHNHBGONNF(object GNAAILLDOKI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001E6")]
	[Cpp2IlInjected.Address(RVA = "0x8055760", Offset = "0x8054160", VA = "0x188055760", Slot = "130")]
	public void MBNHJKHPNPC(object GNAAILLDOKI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001E7")]
	[Cpp2IlInjected.Address(RVA = "0x8055D50", Offset = "0x8054750", VA = "0x188055D50", Slot = "131")]
	public void MPICDEHACKI(object GNAAILLDOKI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001E8")]
	[Cpp2IlInjected.Address(RVA = "0x8051B10", Offset = "0x8050510", VA = "0x188051B10", Slot = "132")]
	public void CCMEJBGHLCK(Vector3 JDEIJIAFEMH, ForceMode MGJAADBPMJD = ForceMode.Force)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001E9")]
	[Cpp2IlInjected.Address(RVA = "0x8055A50", Offset = "0x8054450", VA = "0x188055A50", Slot = "133")]
	public void MLKHEIEEHGI(Vector3 JDEIJIAFEMH, Vector3 KKIJMCHODGC, ForceMode MGJAADBPMJD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001EA")]
	[Cpp2IlInjected.Address(RVA = "0x8051A30", Offset = "0x8050430", VA = "0x188051A30", Slot = "134")]
	public void CCKICFDOCAP(Vector3 DBNLIBDADBA, ForceMode MGJAADBPMJD = ForceMode.Force)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001EB")]
	[Cpp2IlInjected.Address(RVA = "0x8052880", Offset = "0x8051280", VA = "0x188052880", Slot = "135")]
	public void EIJGDGMOIKI(Vector3 DBNLIBDADBA, ForceMode MGJAADBPMJD = ForceMode.Force)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001EE")]
	[Cpp2IlInjected.Address(RVA = "0x8056AE0", Offset = "0x80554E0", VA = "0x188056AE0", Slot = "136")]
	public bool OBJEAPCONIP(Vector3 BJECPMGLFMN, [Out] RaycastHit ILNEPPLCHJL, float FPNKBMPOCJL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001F1")]
	[Cpp2IlInjected.Address(RVA = "0x80545D0", Offset = "0x8052FD0", VA = "0x1880545D0", Slot = "137")]
	public void JHBHKMFNBIH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001F2")]
	[Cpp2IlInjected.Address(RVA = "0x8057760", Offset = "0x8056160", VA = "0x188057760", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001F3")]
	[Cpp2IlInjected.Address(RVA = "0x8054D40", Offset = "0x8053740", VA = "0x188054D40")]
	private void KLNOAAMBIEE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001F4")]
	[Cpp2IlInjected.Address(RVA = "0x8055650", Offset = "0x8054050", VA = "0x188055650")]
	private void LPGMAFDFPLP(AEGDBIMJAKG HGBJMKAPAJA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001F5")]
	[Cpp2IlInjected.Address(RVA = "0x80517A0", Offset = "0x80501A0", VA = "0x1880517A0")]
	private void BGAFCCJMLGB(AEGDBIMJAKG HGBJMKAPAJA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001F6")]
	[Cpp2IlInjected.Address(RVA = "0x80553E0", Offset = "0x8053DE0", VA = "0x1880553E0")]
	private void LNAJMLBMMED()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001F7")]
	[Cpp2IlInjected.Address(RVA = "0x80569C0", Offset = "0x80553C0", VA = "0x1880569C0")]
	private void NPGHGAHNKFC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001F8")]
	[Cpp2IlInjected.Address(RVA = "0x8054870", Offset = "0x8053270", VA = "0x188054870")]
	private void JONEKOJFAAG(AEGDBIMJAKG GEFPNKBJEJD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001F9")]
	[Cpp2IlInjected.Address(RVA = "0x8052960", Offset = "0x8051360", VA = "0x188052960")]
	private void ELBMGNAHEAP(AEGDBIMJAKG HGBJMKAPAJA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001FA")]
	[Cpp2IlInjected.Address(RVA = "0x80535B0", Offset = "0x8051FB0", VA = "0x1880535B0")]
	private void GOPNOGMOMJD(AEGDBIMJAKG HGBJMKAPAJA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001FB")]
	[Cpp2IlInjected.Address(RVA = "0x8054AD0", Offset = "0x80534D0", VA = "0x188054AD0")]
	private void KANCNFKDKLP(COGOJKBIHHJ HGBJMKAPAJA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001FC")]
	[Cpp2IlInjected.Address(RVA = "0x8051EE0", Offset = "0x80508E0", VA = "0x188051EE0", Slot = "142")]
	protected virtual void CMPKFBKCFOH(COGOJKBIHHJ JCJHLOEIIFO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001FD")]
	[Cpp2IlInjected.Address(RVA = "0x8056180", Offset = "0x8054B80", VA = "0x188056180")]
	protected void NECDDGHGACM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001FE")]
	[Cpp2IlInjected.Address(RVA = "0x80564E0", Offset = "0x8054EE0", VA = "0x1880564E0")]
	protected void NEGEMBDFKAL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001FF")]
	[Cpp2IlInjected.Address(RVA = "0x8051160", Offset = "0x804FB60", VA = "0x188051160")]
	private void ABKAPENODAO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000200")]
	[Cpp2IlInjected.Address(RVA = "0x80513F0", Offset = "0x804FDF0", VA = "0x1880513F0")]
	private void AGLOPANOJLM()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001D")]
internal static class EJMKFHPHGBF
{
	[Cpp2IlInjected.Token(Token = "0x6000201")]
	[Cpp2IlInjected.Address(RVA = "0x805A8D0", Offset = "0x80592D0", VA = "0x18805A8D0")]
	public static AEGDBIMJAKG LJGOEBHDCFC(this AEGDBIMJAKG JCJHLOEIIFO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000202")]
	[Cpp2IlInjected.Address(RVA = "0x805A6D0", Offset = "0x80590D0", VA = "0x18805A6D0")]
	public static bool FDIDBCFJHBA(this AEGDBIMJAKG JCJHLOEIIFO, AEGDBIMJAKG JADKFGHHKCE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000203")]
	[Cpp2IlInjected.Address(RVA = "0x805A830", Offset = "0x8059230", VA = "0x18805A830")]
	public static bool LCLLAIGPOPN(this AEGDBIMJAKG JCJHLOEIIFO, AEGDBIMJAKG IAKKICMDHNB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000204")]
	[Cpp2IlInjected.Address(RVA = "0x805A770", Offset = "0x8059170", VA = "0x18805A770")]
	public static COGOJKBIHHJ GFOIPIAMDDD(this AEGDBIMJAKG GBDMJHAPPHC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000205")]
	[Cpp2IlInjected.Address(RVA = "0x805A7C0", Offset = "0x80591C0", VA = "0x18805A7C0")]
	public static AFDHKDDEFPL IJIIPPHAMNP(this AEGDBIMJAKG GBDMJHAPPHC)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200001E")]
public class HILEBIHMPFC : MKHGFDOKEMI
{
	[Cpp2IlInjected.Token(Token = "0x6000206")]
	[Cpp2IlInjected.Address(RVA = "0x805E0A0", Offset = "0x805CAA0", VA = "0x18805E0A0", Slot = "19")]
	public AEGDBIMJAKG DOFDPJBFNDD(RigidbodyEx JCJHLOEIIFO, BNAMPFDBALG DFPGGEDGGGN, OOJMOMLJPBI GIGHOMPCPHH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000207")]
	[Cpp2IlInjected.Address(RVA = "0x9AE070", Offset = "0x9ACA70", VA = "0x1809AE070", Slot = "4")]
	public HNIPPCIEEBF BBMAKGHMLIJ(AEGDBIMJAKG GBDMJHAPPHC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000208")]
	[Cpp2IlInjected.Address(RVA = "0x9AE070", Offset = "0x9ACA70", VA = "0x1809AE070", Slot = "5")]
	public HBGNPJEJHHJ GHAFEHFOIPB(AEGDBIMJAKG GBDMJHAPPHC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000209")]
	[Cpp2IlInjected.Address(RVA = "0x9AE070", Offset = "0x9ACA70", VA = "0x1809AE070", Slot = "6")]
	public OMFLDLCMAPK EGCDLAFEICE(AEGDBIMJAKG GBDMJHAPPHC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600020A")]
	[Cpp2IlInjected.Address(RVA = "0x9AE070", Offset = "0x9ACA70", VA = "0x1809AE070", Slot = "7")]
	public LCPFLPPAHGD BCJNNINFJGK(AEGDBIMJAKG GBDMJHAPPHC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600020B")]
	[Cpp2IlInjected.Address(RVA = "0x9AE070", Offset = "0x9ACA70", VA = "0x1809AE070", Slot = "8")]
	public FHMKNHCIOOB DDKHEDMLHHJ(AEGDBIMJAKG GBDMJHAPPHC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600020C")]
	[Cpp2IlInjected.Address(RVA = "0x9AE070", Offset = "0x9ACA70", VA = "0x1809AE070", Slot = "9")]
	public ODGBGICJCIB MLMMPCEHJIN(AEGDBIMJAKG GBDMJHAPPHC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600020D")]
	[Cpp2IlInjected.Address(RVA = "0x9AE070", Offset = "0x9ACA70", VA = "0x1809AE070", Slot = "10")]
	public DLIEGGPBPJO OPJLNCAEBGB(AEGDBIMJAKG GBDMJHAPPHC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600020E")]
	[Cpp2IlInjected.Address(RVA = "0x9AE070", Offset = "0x9ACA70", VA = "0x1809AE070", Slot = "11")]
	public BIENKFHPJMP LHGCLLJHBKP(AEGDBIMJAKG GBDMJHAPPHC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600020F")]
	[Cpp2IlInjected.Address(RVA = "0x9AE070", Offset = "0x9ACA70", VA = "0x1809AE070", Slot = "12")]
	public ANNBJDFMKOO DFOADOALJEM(AEGDBIMJAKG GBDMJHAPPHC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000210")]
	[Cpp2IlInjected.Address(RVA = "0x9AE070", Offset = "0x9ACA70", VA = "0x1809AE070", Slot = "13")]
	public CFENPGCEIEG NPNOJGJIJPH(AEGDBIMJAKG GBDMJHAPPHC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000211")]
	[Cpp2IlInjected.Address(RVA = "0x9AE070", Offset = "0x9ACA70", VA = "0x1809AE070")]
	public JFEEDKNMOFN PDNBMJAKGNC(AEGDBIMJAKG GBDMJHAPPHC, [In] BNAMPFDBALG DFPGGEDGGGN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000212")]
	[Cpp2IlInjected.Address(RVA = "0x9AE070", Offset = "0x9ACA70", VA = "0x1809AE070")]
	public ONDFHDJOEBD POJKCPHMBLD(AEGDBIMJAKG GBDMJHAPPHC, [In] BNAMPFDBALG DFPGGEDGGGN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000213")]
	[Cpp2IlInjected.Address(RVA = "0x9AE070", Offset = "0x9ACA70", VA = "0x1809AE070")]
	public KAGCJGFIMHB CAKGCKJADIO(AEGDBIMJAKG GBDMJHAPPHC, [In] BNAMPFDBALG DFPGGEDGGGN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000214")]
	[Cpp2IlInjected.Address(RVA = "0x9AE070", Offset = "0x9ACA70", VA = "0x1809AE070")]
	public JFADAMMEHIM DJKEHAKDBGA(AEGDBIMJAKG GBDMJHAPPHC, [In] BNAMPFDBALG DFPGGEDGGGN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000215")]
	[Cpp2IlInjected.Address(RVA = "0x9AE070", Offset = "0x9ACA70", VA = "0x1809AE070")]
	public BMKDEGFOAMG ECCEIMAPLMI(AEGDBIMJAKG GBDMJHAPPHC, [In] BNAMPFDBALG DFPGGEDGGGN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000216")]
	[Cpp2IlInjected.Address(RVA = "0x9B1770", Offset = "0x9B0170", VA = "0x1809B1770")]
	public HILEBIHMPFC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000217")]
	[Cpp2IlInjected.Address(RVA = "0x9AE070", Offset = "0x9ACA70", VA = "0x1809AE070", Slot = "14")]
	private JFEEDKNMOFN JBCCJPLLDPM(AEGDBIMJAKG GBDMJHAPPHC, [In] BNAMPFDBALG DFPGGEDGGGN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000218")]
	[Cpp2IlInjected.Address(RVA = "0x9AE070", Offset = "0x9ACA70", VA = "0x1809AE070", Slot = "15")]
	private ONDFHDJOEBD CAFNILFILMK(AEGDBIMJAKG GBDMJHAPPHC, [In] BNAMPFDBALG DFPGGEDGGGN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000219")]
	[Cpp2IlInjected.Address(RVA = "0x9AE070", Offset = "0x9ACA70", VA = "0x1809AE070", Slot = "16")]
	private KAGCJGFIMHB PAOCFCCDKKD(AEGDBIMJAKG GBDMJHAPPHC, [In] BNAMPFDBALG DFPGGEDGGGN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600021A")]
	[Cpp2IlInjected.Address(RVA = "0x9AE070", Offset = "0x9ACA70", VA = "0x1809AE070", Slot = "17")]
	private JFADAMMEHIM KFCLPICIIAL(AEGDBIMJAKG GBDMJHAPPHC, [In] BNAMPFDBALG DFPGGEDGGGN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600021B")]
	[Cpp2IlInjected.Address(RVA = "0x9AE070", Offset = "0x9ACA70", VA = "0x1809AE070", Slot = "18")]
	private BMKDEGFOAMG MKEAHCNIEBP(AEGDBIMJAKG GBDMJHAPPHC, [In] BNAMPFDBALG DFPGGEDGGGN)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200001F")]
[RegisterService(typeof(MKHGFDOKEMI), new string[] { })]
public class PAPCACJNGIA : MKHGFDOKEMI, KFPIMHBKPFA
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000030")]
	private readonly MKHGFDOKEMI IJLPEPKABFO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000031")]
	private readonly MKHGFDOKEMI ENAAKLLIHIA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000032")]
	private PNHOIBKKDDI BAHAFMNOLOF;

	[Cpp2IlInjected.Token(Token = "0x1700008B")]
	private MKHGFDOKEMI IEOBPJCNMBJ
	{
		[Cpp2IlInjected.Token(Token = "0x600021D")]
		[Cpp2IlInjected.Address(RVA = "0x8067930", Offset = "0x8066330", VA = "0x188067930")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600021C")]
	[Cpp2IlInjected.Address(RVA = "0x8067990", Offset = "0x8066390", VA = "0x188067990", Slot = "20")]
	public void InitReferences(LBHNIGEPODB GNJMKKKJHPN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600021E")]
	[Cpp2IlInjected.Address(RVA = "0x80671D0", Offset = "0x8065BD0", VA = "0x1880671D0", Slot = "4")]
	public HNIPPCIEEBF BBMAKGHMLIJ(AEGDBIMJAKG GBDMJHAPPHC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600021F")]
	[Cpp2IlInjected.Address(RVA = "0x8067890", Offset = "0x8066290", VA = "0x188067890", Slot = "5")]
	public HBGNPJEJHHJ GHAFEHFOIPB(AEGDBIMJAKG GBDMJHAPPHC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000220")]
	[Cpp2IlInjected.Address(RVA = "0x80677F0", Offset = "0x80661F0", VA = "0x1880677F0", Slot = "6")]
	public OMFLDLCMAPK EGCDLAFEICE(AEGDBIMJAKG GBDMJHAPPHC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000221")]
	[Cpp2IlInjected.Address(RVA = "0x8067270", Offset = "0x8065C70", VA = "0x188067270", Slot = "7")]
	public LCPFLPPAHGD BCJNNINFJGK(AEGDBIMJAKG GBDMJHAPPHC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000222")]
	[Cpp2IlInjected.Address(RVA = "0x8067470", Offset = "0x8065E70", VA = "0x188067470", Slot = "8")]
	public FHMKNHCIOOB DDKHEDMLHHJ(AEGDBIMJAKG GBDMJHAPPHC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000223")]
	[Cpp2IlInjected.Address(RVA = "0x8067B30", Offset = "0x8066530", VA = "0x188067B30", Slot = "9")]
	public ODGBGICJCIB MLMMPCEHJIN(AEGDBIMJAKG GBDMJHAPPHC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000224")]
	[Cpp2IlInjected.Address(RVA = "0x8067C70", Offset = "0x8066670", VA = "0x188067C70", Slot = "10")]
	public DLIEGGPBPJO OPJLNCAEBGB(AEGDBIMJAKG GBDMJHAPPHC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000225")]
	[Cpp2IlInjected.Address(RVA = "0x8067A90", Offset = "0x8066490", VA = "0x188067A90", Slot = "11")]
	public BIENKFHPJMP LHGCLLJHBKP(AEGDBIMJAKG GBDMJHAPPHC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000226")]
	[Cpp2IlInjected.Address(RVA = "0x8067510", Offset = "0x8065F10", VA = "0x188067510", Slot = "12")]
	public ANNBJDFMKOO DFOADOALJEM(AEGDBIMJAKG GBDMJHAPPHC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000227")]
	[Cpp2IlInjected.Address(RVA = "0x8067BD0", Offset = "0x80665D0", VA = "0x188067BD0", Slot = "13")]
	public CFENPGCEIEG NPNOJGJIJPH(AEGDBIMJAKG GBDMJHAPPHC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000228")]
	[Cpp2IlInjected.Address(RVA = "0x80679E0", Offset = "0x80663E0", VA = "0x1880679E0")]
	public JFEEDKNMOFN PDNBMJAKGNC(AEGDBIMJAKG GBDMJHAPPHC, [In] BNAMPFDBALG DFPGGEDGGGN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000229")]
	[Cpp2IlInjected.Address(RVA = "0x8067310", Offset = "0x8065D10", VA = "0x188067310")]
	public ONDFHDJOEBD POJKCPHMBLD(AEGDBIMJAKG GBDMJHAPPHC, [In] BNAMPFDBALG DFPGGEDGGGN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600022A")]
	[Cpp2IlInjected.Address(RVA = "0x80673C0", Offset = "0x8065DC0", VA = "0x1880673C0")]
	public KAGCJGFIMHB CAKGCKJADIO(AEGDBIMJAKG GBDMJHAPPHC, [In] BNAMPFDBALG DFPGGEDGGGN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600022B")]
	[Cpp2IlInjected.Address(RVA = "0x80675B0", Offset = "0x8065FB0", VA = "0x1880675B0")]
	public JFADAMMEHIM DJKEHAKDBGA(AEGDBIMJAKG GBDMJHAPPHC, [In] BNAMPFDBALG DFPGGEDGGGN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600022C")]
	[Cpp2IlInjected.Address(RVA = "0x8067740", Offset = "0x8066140", VA = "0x188067740")]
	public BMKDEGFOAMG ECCEIMAPLMI(AEGDBIMJAKG GBDMJHAPPHC, [In] BNAMPFDBALG DFPGGEDGGGN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600022D")]
	[Cpp2IlInjected.Address(RVA = "0x8067660", Offset = "0x8066060", VA = "0x188067660", Slot = "19")]
	public AEGDBIMJAKG DOFDPJBFNDD(RigidbodyEx JCJHLOEIIFO, BNAMPFDBALG DFPGGEDGGGN, OOJMOMLJPBI GIGHOMPCPHH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600022E")]
	[Cpp2IlInjected.Address(RVA = "0x8067D10", Offset = "0x8066710", VA = "0x188067D10")]
	public PAPCACJNGIA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600022F")]
	[Cpp2IlInjected.Address(RVA = "0x80679E0", Offset = "0x80663E0", VA = "0x1880679E0", Slot = "14")]
	private JFEEDKNMOFN JBCCJPLLDPM(AEGDBIMJAKG GBDMJHAPPHC, [In] BNAMPFDBALG DFPGGEDGGGN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000230")]
	[Cpp2IlInjected.Address(RVA = "0x8067310", Offset = "0x8065D10", VA = "0x188067310", Slot = "15")]
	private ONDFHDJOEBD CAFNILFILMK(AEGDBIMJAKG GBDMJHAPPHC, [In] BNAMPFDBALG DFPGGEDGGGN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000231")]
	[Cpp2IlInjected.Address(RVA = "0x80673C0", Offset = "0x8065DC0", VA = "0x1880673C0", Slot = "16")]
	private KAGCJGFIMHB PAOCFCCDKKD(AEGDBIMJAKG GBDMJHAPPHC, [In] BNAMPFDBALG DFPGGEDGGGN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000232")]
	[Cpp2IlInjected.Address(RVA = "0x80675B0", Offset = "0x8065FB0", VA = "0x1880675B0", Slot = "17")]
	private JFADAMMEHIM KFCLPICIIAL(AEGDBIMJAKG GBDMJHAPPHC, [In] BNAMPFDBALG DFPGGEDGGGN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000233")]
	[Cpp2IlInjected.Address(RVA = "0x8067740", Offset = "0x8066140", VA = "0x188067740", Slot = "18")]
	private BMKDEGFOAMG MKEAHCNIEBP(AEGDBIMJAKG GBDMJHAPPHC, [In] BNAMPFDBALG DFPGGEDGGGN)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000020")]
public interface CNJEJNLIKDO : HNIPPCIEEBF, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x6000234")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void JLIGOJPFBFL(AEGDBIMJAKG JCJHLOEIIFO);

	[Cpp2IlInjected.Token(Token = "0x6000235")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void IBGHCPICJGI(AEGDBIMJAKG JCJHLOEIIFO);

	[Cpp2IlInjected.Token(Token = "0x6000236")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void OJBPIIJMFPF(AEGDBIMJAKG GEFPNKBJEJD);

	[Cpp2IlInjected.Token(Token = "0x6000237")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void ABHGNCEBHBL(AEGDBIMJAKG GEFPNKBJEJD);
}
[Cpp2IlInjected.Token(Token = "0x2000021")]
public interface CAIBCGHIODO : OMFLDLCMAPK
{
	[Cpp2IlInjected.Token(Token = "0x1700008C")]
	OLCCGHGGJNO<AEGDBIMJAKG> GKAFLHIBLPN
	{
		[Cpp2IlInjected.Token(Token = "0x6000238")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700008D")]
	AEGDBIMJAKG GBLPGKAOHCF
	{
		[Cpp2IlInjected.Token(Token = "0x6000239")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000022")]
public interface GBGPICOOMOF : JFADAMMEHIM
{
	[Cpp2IlInjected.Token(Token = "0x600023A")]
	[Cpp2IlInjected.Address(Slot = "0")]
	(float, Vector3) CJICCOMINAN(Rigidbody FDHMOCKPBGF);
}
[Cpp2IlInjected.Token(Token = "0x2000023")]
public interface BBBKKDDBEJP : ONDFHDJOEBD, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x1700008E")]
	PhotonView IJBEGIODOFB
	{
		[Cpp2IlInjected.Token(Token = "0x600023B")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000024")]
internal sealed class BPPDEGMFNNB : ANNBJDFMKOO
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000033")]
	private readonly AFDHKDDEFPL JCJHLOEIIFO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000034")]
	private CollisionDetectionMode JOKCKJGMFOB;

	[Cpp2IlInjected.Token(Token = "0x1700008F")]
	private Rigidbody JADPAFJKPGC
	{
		[Cpp2IlInjected.Token(Token = "0x600023C")]
		[Cpp2IlInjected.Address(RVA = "0x8059490", Offset = "0x8057E90", VA = "0x188059490")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000090")]
	public CollisionDetectionMode INCBHDMGFBA
	{
		[Cpp2IlInjected.Token(Token = "0x6000240")]
		[Cpp2IlInjected.Address(RVA = "0x80591B0", Offset = "0x8057BB0", VA = "0x1880591B0", Slot = "4")]
		get
		{
			return default(CollisionDetectionMode);
		}
		[Cpp2IlInjected.Token(Token = "0x6000241")]
		[Cpp2IlInjected.Address(RVA = "0x8059420", Offset = "0x8057E20", VA = "0x188059420", Slot = "5")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600023D")]
	[Cpp2IlInjected.Address(RVA = "0x80594E0", Offset = "0x8057EE0", VA = "0x1880594E0")]
	public BPPDEGMFNNB(AEGDBIMJAKG JCJHLOEIIFO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600023E")]
	[Cpp2IlInjected.Address(RVA = "0x8058F60", Offset = "0x8057960", VA = "0x188058F60", Slot = "6")]
	public void GMJBMKIKLGO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600023F")]
	[Cpp2IlInjected.Address(RVA = "0x8058EE0", Offset = "0x80578E0", VA = "0x188058EE0", Slot = "9")]
	public void CGBEHGCJKJC(Rigidbody LHOBCJGBABO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000242")]
	[Cpp2IlInjected.Address(RVA = "0x8059070", Offset = "0x8057A70", VA = "0x188059070", Slot = "7")]
	public void KHHMOMJDGIL(bool OJJOMFALNBA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000243")]
	[Cpp2IlInjected.Address(RVA = "0x8059080", Offset = "0x8057A80", VA = "0x188059080", Slot = "8")]
	public void NIFNKKKMGNG(bool OJJOMFALNBA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000244")]
	[Cpp2IlInjected.Address(RVA = "0x80592C0", Offset = "0x8057CC0", VA = "0x1880592C0", Slot = "10")]
	public bool OBJEAPCONIP(Vector3 BJECPMGLFMN, [Out] RaycastHit ILNEPPLCHJL, float FPNKBMPOCJL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000245")]
	[Cpp2IlInjected.Address(RVA = "0x8059090", Offset = "0x8057A90", VA = "0x188059090")]
	private void NLIFCHCIPEI(bool OJJOMFALNBA)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000025")]
public sealed class KGIPNOPCOGN : ODGBGICJCIB, IDisposable, IGCNAGLMNLD
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000036")]
	private readonly AFDHKDDEFPL JCJHLOEIIFO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000037")]
	private JFFGEHLFDPP GKMMFKALIMM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000038")]
	private KMDJIMFKBFI PKLNBFJFJNE;

	[Cpp2IlInjected.Token(Token = "0x17000091")]
	public JFFGEHLFDPP HBFBJDHEFMD
	{
		[Cpp2IlInjected.Token(Token = "0x6000248")]
		[Cpp2IlInjected.Address(RVA = "0x80658B0", Offset = "0x80642B0", VA = "0x1880658B0", Slot = "6")]
		get
		{
			return default(JFFGEHLFDPP);
		}
		[Cpp2IlInjected.Token(Token = "0x6000249")]
		[Cpp2IlInjected.Address(RVA = "0x80659F0", Offset = "0x80643F0", VA = "0x1880659F0", Slot = "7")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000092")]
	private Transform KAPDFJKKJMD
	{
		[Cpp2IlInjected.Token(Token = "0x600024A")]
		[Cpp2IlInjected.Address(RVA = "0xC43F90", Offset = "0xC42990", VA = "0x180C43F90", Slot = "10")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000020")]
	public event Action<HNIGDDENMGF, HNIGDDENMGF> KFNJJBLINJE
	{
		[Cpp2IlInjected.Token(Token = "0x6000246")]
		[Cpp2IlInjected.Address(RVA = "0x8065490", Offset = "0x8063E90", VA = "0x188065490", Slot = "4")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000247")]
		[Cpp2IlInjected.Address(RVA = "0x8065800", Offset = "0x8064200", VA = "0x188065800", Slot = "5")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600024B")]
	[Cpp2IlInjected.Address(RVA = "0x8065AC0", Offset = "0x80644C0", VA = "0x188065AC0")]
	public KGIPNOPCOGN(AEGDBIMJAKG JCJHLOEIIFO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600024C")]
	[Cpp2IlInjected.Address(RVA = "0x8065590", Offset = "0x8063F90", VA = "0x188065590", Slot = "8")]
	public void GMJBMKIKLGO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600024D")]
	[Cpp2IlInjected.Address(RVA = "0x8065540", Offset = "0x8063F40", VA = "0x188065540", Slot = "9")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600024E")]
	[Cpp2IlInjected.Address(RVA = "0x10E4040", Offset = "0x10E2A40", VA = "0x1810E4040", Slot = "11")]
	private void NHJPMNACPGL(HNIGDDENMGF MEFBKDGPDKJ, HNIGDDENMGF FBHGGEBAIBM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600024F")]
	[Cpp2IlInjected.Address(RVA = "0x9AE060", Offset = "0x9ACA60", VA = "0x1809AE060", Slot = "12")]
	private void NKELOPFPLKL(bool BJNPGOKOJIA)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000026")]
public class KHFNFNDNLCJ : MKHGFDOKEMI
{
	[Cpp2IlInjected.Token(Token = "0x6000250")]
	[Cpp2IlInjected.Address(RVA = "0x8065B50", Offset = "0x8064550", VA = "0x188065B50", Slot = "4")]
	public HNIPPCIEEBF BBMAKGHMLIJ(AEGDBIMJAKG GBDMJHAPPHC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000251")]
	[Cpp2IlInjected.Address(RVA = "0x8066600", Offset = "0x8065000", VA = "0x188066600", Slot = "5")]
	public HBGNPJEJHHJ GHAFEHFOIPB(AEGDBIMJAKG GBDMJHAPPHC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000252")]
	[Cpp2IlInjected.Address(RVA = "0x80664D0", Offset = "0x8064ED0", VA = "0x1880664D0", Slot = "6")]
	public OMFLDLCMAPK EGCDLAFEICE(AEGDBIMJAKG GBDMJHAPPHC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000253")]
	[Cpp2IlInjected.Address(RVA = "0x8065C40", Offset = "0x8064640", VA = "0x188065C40", Slot = "7")]
	public LCPFLPPAHGD BCJNNINFJGK(AEGDBIMJAKG GBDMJHAPPHC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000254")]
	[Cpp2IlInjected.Address(RVA = "0x8065F80", Offset = "0x8064980", VA = "0x188065F80", Slot = "8")]
	public FHMKNHCIOOB DDKHEDMLHHJ(AEGDBIMJAKG GBDMJHAPPHC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000255")]
	[Cpp2IlInjected.Address(RVA = "0x8066920", Offset = "0x8065320", VA = "0x188066920", Slot = "9")]
	public ODGBGICJCIB MLMMPCEHJIN(AEGDBIMJAKG GBDMJHAPPHC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000256")]
	[Cpp2IlInjected.Address(RVA = "0x8066AB0", Offset = "0x80654B0", VA = "0x188066AB0", Slot = "10")]
	public DLIEGGPBPJO OPJLNCAEBGB(AEGDBIMJAKG GBDMJHAPPHC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000257")]
	[Cpp2IlInjected.Address(RVA = "0x8066860", Offset = "0x8065260", VA = "0x188066860", Slot = "11")]
	public BIENKFHPJMP LHGCLLJHBKP(AEGDBIMJAKG GBDMJHAPPHC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000258")]
	[Cpp2IlInjected.Address(RVA = "0x8066050", Offset = "0x8064A50", VA = "0x188066050", Slot = "12")]
	public ANNBJDFMKOO DFOADOALJEM(AEGDBIMJAKG GBDMJHAPPHC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000259")]
	[Cpp2IlInjected.Address(RVA = "0x80669F0", Offset = "0x80653F0", VA = "0x1880669F0", Slot = "13")]
	public CFENPGCEIEG NPNOJGJIJPH(AEGDBIMJAKG GBDMJHAPPHC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600025A")]
	[Cpp2IlInjected.Address(RVA = "0x8066720", Offset = "0x8065120", VA = "0x188066720")]
	public JFEEDKNMOFN PDNBMJAKGNC(AEGDBIMJAKG GBDMJHAPPHC, [In] BNAMPFDBALG DFPGGEDGGGN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600025B")]
	[Cpp2IlInjected.Address(RVA = "0x8065CC0", Offset = "0x80646C0", VA = "0x188065CC0")]
	public ONDFHDJOEBD POJKCPHMBLD(AEGDBIMJAKG GBDMJHAPPHC, [In] BNAMPFDBALG DFPGGEDGGGN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600025C")]
	[Cpp2IlInjected.Address(RVA = "0x8065E50", Offset = "0x8064850", VA = "0x188065E50")]
	public KAGCJGFIMHB CAKGCKJADIO(AEGDBIMJAKG GBDMJHAPPHC, [In] BNAMPFDBALG DFPGGEDGGGN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600025D")]
	[Cpp2IlInjected.Address(RVA = "0x8066110", Offset = "0x8064B10", VA = "0x188066110")]
	public JFADAMMEHIM DJKEHAKDBGA(AEGDBIMJAKG GBDMJHAPPHC, [In] BNAMPFDBALG DFPGGEDGGGN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600025E")]
	[Cpp2IlInjected.Address(RVA = "0x80663F0", Offset = "0x8064DF0", VA = "0x1880663F0")]
	public BMKDEGFOAMG ECCEIMAPLMI(AEGDBIMJAKG GBDMJHAPPHC, [In] BNAMPFDBALG DFPGGEDGGGN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600025F")]
	[Cpp2IlInjected.Address(RVA = "0x80662A0", Offset = "0x8064CA0", VA = "0x1880662A0", Slot = "19")]
	public AEGDBIMJAKG DOFDPJBFNDD(RigidbodyEx JCJHLOEIIFO, BNAMPFDBALG DFPGGEDGGGN, OOJMOMLJPBI GIGHOMPCPHH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000260")]
	[Cpp2IlInjected.Address(RVA = "0x9B1770", Offset = "0x9B0170", VA = "0x1809B1770")]
	public KHFNFNDNLCJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000261")]
	[Cpp2IlInjected.Address(RVA = "0x8066720", Offset = "0x8065120", VA = "0x188066720", Slot = "14")]
	private JFEEDKNMOFN JBCCJPLLDPM(AEGDBIMJAKG GBDMJHAPPHC, [In] BNAMPFDBALG DFPGGEDGGGN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000262")]
	[Cpp2IlInjected.Address(RVA = "0x8065CC0", Offset = "0x80646C0", VA = "0x188065CC0", Slot = "15")]
	private ONDFHDJOEBD CAFNILFILMK(AEGDBIMJAKG GBDMJHAPPHC, [In] BNAMPFDBALG DFPGGEDGGGN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000263")]
	[Cpp2IlInjected.Address(RVA = "0x8065E50", Offset = "0x8064850", VA = "0x188065E50", Slot = "16")]
	private KAGCJGFIMHB PAOCFCCDKKD(AEGDBIMJAKG GBDMJHAPPHC, [In] BNAMPFDBALG DFPGGEDGGGN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000264")]
	[Cpp2IlInjected.Address(RVA = "0x8066110", Offset = "0x8064B10", VA = "0x188066110", Slot = "17")]
	private JFADAMMEHIM KFCLPICIIAL(AEGDBIMJAKG GBDMJHAPPHC, [In] BNAMPFDBALG DFPGGEDGGGN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000265")]
	[Cpp2IlInjected.Address(RVA = "0x80663F0", Offset = "0x8064DF0", VA = "0x1880663F0", Slot = "18")]
	private BMKDEGFOAMG MKEAHCNIEBP(AEGDBIMJAKG GBDMJHAPPHC, [In] BNAMPFDBALG DFPGGEDGGGN)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000027")]
internal sealed class IDIPHCLDJHA : BIENKFHPJMP
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000039")]
	private readonly AFDHKDDEFPL JCJHLOEIIFO;

	[Cpp2IlInjected.Token(Token = "0x17000093")]
	private Rigidbody JADPAFJKPGC
	{
		[Cpp2IlInjected.Token(Token = "0x6000266")]
		[Cpp2IlInjected.Address(RVA = "0x8059490", Offset = "0x8057E90", VA = "0x188059490")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000094")]
	private bool JCNHMCMDBEI
	{
		[Cpp2IlInjected.Token(Token = "0x6000267")]
		[Cpp2IlInjected.Address(RVA = "0x80610E0", Offset = "0x805FAE0", VA = "0x1880610E0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000095")]
	private bool JBBBMCHECPD
	{
		[Cpp2IlInjected.Token(Token = "0x6000268")]
		[Cpp2IlInjected.Address(RVA = "0x8060700", Offset = "0x805F100", VA = "0x188060700")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000096")]
	private AEGDBIMJAKG LKNIONJKNBM
	{
		[Cpp2IlInjected.Token(Token = "0x6000269")]
		[Cpp2IlInjected.Address(RVA = "0x8061390", Offset = "0x805FD90", VA = "0x188061390")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600026A")]
	[Cpp2IlInjected.Address(RVA = "0x80594E0", Offset = "0x8057EE0", VA = "0x1880594E0")]
	public IDIPHCLDJHA(AEGDBIMJAKG JCJHLOEIIFO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600026B")]
	[Cpp2IlInjected.Address(RVA = "0x8060F80", Offset = "0x805F980", VA = "0x188060F80", Slot = "4")]
	public void CCMEJBGHLCK(Vector3 JDEIJIAFEMH, ForceMode MGJAADBPMJD = ForceMode.Force)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600026C")]
	[Cpp2IlInjected.Address(RVA = "0x80613F0", Offset = "0x805FDF0", VA = "0x1880613F0")]
	private void KGAHLONKLEG(Vector3 JDEIJIAFEMH, ForceMode MGJAADBPMJD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600026D")]
	[Cpp2IlInjected.Address(RVA = "0x80618B0", Offset = "0x80602B0", VA = "0x1880618B0", Slot = "5")]
	public void MLKHEIEEHGI(Vector3 JDEIJIAFEMH, Vector3 KKIJMCHODGC, ForceMode MGJAADBPMJD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600026E")]
	[Cpp2IlInjected.Address(RVA = "0x8060E20", Offset = "0x805F820", VA = "0x188060E20", Slot = "6")]
	public void CCKICFDOCAP(Vector3 DBNLIBDADBA, ForceMode MGJAADBPMJD = ForceMode.Force)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600026F")]
	[Cpp2IlInjected.Address(RVA = "0x8061650", Offset = "0x8060050", VA = "0x188061650")]
	private void LDLPBOEHKDP(Vector3 DBNLIBDADBA, ForceMode MGJAADBPMJD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000270")]
	[Cpp2IlInjected.Address(RVA = "0x8061130", Offset = "0x805FB30", VA = "0x188061130", Slot = "7")]
	public void EIJGDGMOIKI(Vector3 DBNLIBDADBA, ForceMode MGJAADBPMJD = ForceMode.Force)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000028")]
internal sealed class OINBCLIFDNM : CFENPGCEIEG
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400003A")]
	private readonly AFDHKDDEFPL JCJHLOEIIFO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400003B")]
	private bool ILIJOEADOAE;

	[Cpp2IlInjected.Token(Token = "0x17000097")]
	public bool LOEEGOLECOO
	{
		[Cpp2IlInjected.Token(Token = "0x6000272")]
		[Cpp2IlInjected.Address(RVA = "0xA45A60", Offset = "0xA44460", VA = "0x180A45A60", Slot = "4")]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000273")]
		[Cpp2IlInjected.Address(RVA = "0x80670C0", Offset = "0x8065AC0", VA = "0x1880670C0", Slot = "5")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000271")]
	[Cpp2IlInjected.Address(RVA = "0x80594E0", Offset = "0x8057EE0", VA = "0x1880594E0")]
	public OINBCLIFDNM(AEGDBIMJAKG JCJHLOEIIFO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000274")]
	[Cpp2IlInjected.Address(RVA = "0x8067020", Offset = "0x8065A20", VA = "0x188067020", Slot = "6")]
	public void CGBEHGCJKJC(Rigidbody LHOBCJGBABO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000275")]
	[Cpp2IlInjected.Address(RVA = "0x8067050", Offset = "0x8065A50", VA = "0x188067050", Slot = "7")]
	public void DEEDFLNEMBA(Rigidbody LHOBCJGBABO)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000029")]
internal sealed class HPHJBFNOFAC : CNJEJNLIKDO, HNIPPCIEEBF, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x4000045")]
	private readonly AEGDBIMJAKG JCJHLOEIIFO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x4000046")]
	private readonly List<AEGDBIMJAKG> PIBJCGKKEMI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x4000047")]
	private AEGDBIMJAKG MHHKOMDGDID;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x4000048")]
	private AEGDBIMJAKG HGBJMKAPAJA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
	[Cpp2IlInjected.Token(Token = "0x4000049")]
	private Transform EOGOFHKLFKJ;

	[Cpp2IlInjected.Token(Token = "0x17000098")]
	private Transform GKBGOMKDLDP
	{
		[Cpp2IlInjected.Token(Token = "0x6000288")]
		[Cpp2IlInjected.Address(RVA = "0x805F770", Offset = "0x805E170", VA = "0x18805F770")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000099")]
	public AEGDBIMJAKG LKNIONJKNBM
	{
		[Cpp2IlInjected.Token(Token = "0x600028B")]
		[Cpp2IlInjected.Address(RVA = "0x9AC4A0", Offset = "0x9AAEA0", VA = "0x1809AC4A0", Slot = "28")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600028C")]
		[Cpp2IlInjected.Address(RVA = "0x805F920", Offset = "0x805E320", VA = "0x18805F920", Slot = "29")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700009A")]
	public AEGDBIMJAKG LKAEGJLGAIG
	{
		[Cpp2IlInjected.Token(Token = "0x600028D")]
		[Cpp2IlInjected.Address(RVA = "0x9AC4C0", Offset = "0x9AAEC0", VA = "0x1809AC4C0", Slot = "27")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700009B")]
	public IReadOnlyList<AEGDBIMJAKG> KGEKDELIPPG
	{
		[Cpp2IlInjected.Token(Token = "0x600028E")]
		[Cpp2IlInjected.Address(RVA = "0x9AC510", Offset = "0x9AAF10", VA = "0x1809AC510", Slot = "26")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000021")]
	public event EIMKACMLCOF HPMNGIDAKOL
	{
		[Cpp2IlInjected.Token(Token = "0x6000276")]
		[Cpp2IlInjected.Address(RVA = "0x805F460", Offset = "0x805DE60", VA = "0x18805F460", Slot = "8")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000277")]
		[Cpp2IlInjected.Address(RVA = "0x8060310", Offset = "0x805ED10", VA = "0x188060310", Slot = "9")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000022")]
	public event EIMKACMLCOF BEOPJEDGIKK
	{
		[Cpp2IlInjected.Token(Token = "0x6000278")]
		[Cpp2IlInjected.Address(RVA = "0x805FD50", Offset = "0x805E750", VA = "0x18805FD50", Slot = "10")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000279")]
		[Cpp2IlInjected.Address(RVA = "0x8060270", Offset = "0x805EC70", VA = "0x188060270", Slot = "11")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000023")]
	public event AAILGCMHGNK JICLOCIGEGP
	{
		[Cpp2IlInjected.Token(Token = "0x600027A")]
		[Cpp2IlInjected.Address(RVA = "0x80603B0", Offset = "0x805EDB0", VA = "0x1880603B0", Slot = "12")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600027B")]
		[Cpp2IlInjected.Address(RVA = "0x8060110", Offset = "0x805EB10", VA = "0x188060110", Slot = "13")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000024")]
	public event Action EAJKMMFBBCJ
	{
		[Cpp2IlInjected.Token(Token = "0x600027C")]
		[Cpp2IlInjected.Address(RVA = "0x805E960", Offset = "0x805D360", VA = "0x18805E960", Slot = "14")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600027D")]
		[Cpp2IlInjected.Address(RVA = "0x805F930", Offset = "0x805E330", VA = "0x18805F930", Slot = "15")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000025")]
	public event Action MGPMPGDIKHI
	{
		[Cpp2IlInjected.Token(Token = "0x600027E")]
		[Cpp2IlInjected.Address(RVA = "0x805FCB0", Offset = "0x805E6B0", VA = "0x18805FCB0", Slot = "16")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600027F")]
		[Cpp2IlInjected.Address(RVA = "0x805E8C0", Offset = "0x805D2C0", VA = "0x18805E8C0", Slot = "17")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000026")]
	public event Action<AEGDBIMJAKG> EIOJAMPEIPC
	{
		[Cpp2IlInjected.Token(Token = "0x6000280")]
		[Cpp2IlInjected.Address(RVA = "0x805F3B0", Offset = "0x805DDB0", VA = "0x18805F3B0", Slot = "18")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000281")]
		[Cpp2IlInjected.Address(RVA = "0x805FDF0", Offset = "0x805E7F0", VA = "0x18805FDF0", Slot = "19")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000027")]
	public event Action<AEGDBIMJAKG> LJHCMKEANIM
	{
		[Cpp2IlInjected.Token(Token = "0x6000282")]
		[Cpp2IlInjected.Address(RVA = "0x805EAB0", Offset = "0x805D4B0", VA = "0x18805EAB0", Slot = "20")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000283")]
		[Cpp2IlInjected.Address(RVA = "0x805EA00", Offset = "0x805D400", VA = "0x18805EA00", Slot = "21")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000028")]
	public event Action NILGKKOEPIC
	{
		[Cpp2IlInjected.Token(Token = "0x6000284")]
		[Cpp2IlInjected.Address(RVA = "0x805ED50", Offset = "0x805D750", VA = "0x18805ED50", Slot = "22")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000285")]
		[Cpp2IlInjected.Address(RVA = "0x805ECB0", Offset = "0x805D6B0", VA = "0x18805ECB0", Slot = "23")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000029")]
	public event Action<AEGDBIMJAKG> OOBFNJLHPJH
	{
		[Cpp2IlInjected.Token(Token = "0x6000286")]
		[Cpp2IlInjected.Address(RVA = "0x805EB60", Offset = "0x805D560", VA = "0x18805EB60", Slot = "24")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000287")]
		[Cpp2IlInjected.Address(RVA = "0x805F7D0", Offset = "0x805E1D0", VA = "0x18805F7D0", Slot = "25")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000289")]
	[Cpp2IlInjected.Address(RVA = "0x8060450", Offset = "0x805EE50", VA = "0x188060450")]
	public HPHJBFNOFAC(AEGDBIMJAKG JCJHLOEIIFO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600028A")]
	[Cpp2IlInjected.Address(RVA = "0x805EC10", Offset = "0x805D610", VA = "0x18805EC10", Slot = "31")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600028F")]
	[Cpp2IlInjected.Address(RVA = "0x805EE30", Offset = "0x805D830", VA = "0x18805EE30", Slot = "30")]
	public void GICBAHPKOCO(AEGDBIMJAKG MGKDKKMCMAL, bool OFLGEPPEKAD = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000290")]
	[Cpp2IlInjected.Address(RVA = "0x805FEA0", Offset = "0x805E8A0", VA = "0x18805FEA0", Slot = "6")]
	public void OJBPIIJMFPF(AEGDBIMJAKG GEFPNKBJEJD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000291")]
	[Cpp2IlInjected.Address(RVA = "0x805E640", Offset = "0x805D040", VA = "0x18805E640", Slot = "7")]
	public void ABHGNCEBHBL(AEGDBIMJAKG GEFPNKBJEJD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000292")]
	[Cpp2IlInjected.Address(RVA = "0x805FB00", Offset = "0x805E500", VA = "0x18805FB00", Slot = "4")]
	public void JLIGOJPFBFL(AEGDBIMJAKG JCJHLOEIIFO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000293")]
	[Cpp2IlInjected.Address(RVA = "0x805F880", Offset = "0x805E280", VA = "0x18805F880", Slot = "5")]
	public void IBGHCPICJGI(AEGDBIMJAKG JCJHLOEIIFO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000294")]
	[Cpp2IlInjected.Address(RVA = "0x805FC10", Offset = "0x805E610", VA = "0x18805FC10")]
	private void JNMKMCANBKC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000295")]
	[Cpp2IlInjected.Address(RVA = "0x805EDF0", Offset = "0x805D7F0", VA = "0x18805EDF0")]
	private void GHGFIELFJLK(AEGDBIMJAKG GEFPNKBJEJD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000296")]
	[Cpp2IlInjected.Address(RVA = "0x805F630", Offset = "0x805E030", VA = "0x18805F630")]
	private void HEMKJCFKOGL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000297")]
	[Cpp2IlInjected.Address(RVA = "0x805F9D0", Offset = "0x805E3D0", VA = "0x18805F9D0")]
	private void JKMFBMICCLD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000298")]
	[Cpp2IlInjected.Address(RVA = "0x805F500", Offset = "0x805DF00", VA = "0x18805F500")]
	private void HDIGCNLJFLB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000299")]
	[Cpp2IlInjected.Address(RVA = "0x80601B0", Offset = "0x805EBB0", VA = "0x1880601B0")]
	[CompilerGenerated]
	private object PHHJLCOPINM()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200002A")]
internal static class HGENEFHBJKL
{
	[Cpp2IlInjected.Token(Token = "0x600029A")]
	[Cpp2IlInjected.Address(RVA = "0x805DFE0", Offset = "0x805C9E0", VA = "0x18805DFE0")]
	public static CNJEJNLIKDO HAGLCCJCPEA(this AEGDBIMJAKG GBDMJHAPPHC)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200002B")]
internal sealed class BNDENDCKIIF : CAIBCGHIODO, OMFLDLCMAPK
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400004A")]
	private readonly AFDHKDDEFPL JCJHLOEIIFO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400004B")]
	private readonly OLCCGHGGJNO<AEGDBIMJAKG> CKNAJIKPJDN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400004C")]
	private bool ENOOPCALAGM;

	[Cpp2IlInjected.Token(Token = "0x1700009C")]
	public OLCCGHGGJNO<AEGDBIMJAKG> GKAFLHIBLPN
	{
		[Cpp2IlInjected.Token(Token = "0x600029B")]
		[Cpp2IlInjected.Address(RVA = "0x9ACED0", Offset = "0x9AB8D0", VA = "0x1809ACED0", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700009D")]
	public Vector3 DGGLPPHNMBJ
	{
		[Cpp2IlInjected.Token(Token = "0x600029C")]
		[Cpp2IlInjected.Address(RVA = "0x8058280", Offset = "0x8056C80", VA = "0x188058280", Slot = "6")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700009E")]
	public Vector3 FPBOMHPDKGJ
	{
		[Cpp2IlInjected.Token(Token = "0x600029D")]
		[Cpp2IlInjected.Address(RVA = "0x8058310", Offset = "0x8056D10", VA = "0x188058310", Slot = "7")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700009F")]
	private Vector3 JBOLMPDFKDF
	{
		[Cpp2IlInjected.Token(Token = "0x60002A1")]
		[Cpp2IlInjected.Address(RVA = "0x8057E00", Offset = "0x8056800", VA = "0x188057E00")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A0")]
	public AEGDBIMJAKG GBLPGKAOHCF
	{
		[Cpp2IlInjected.Token(Token = "0x60002A2")]
		[Cpp2IlInjected.Address(RVA = "0x8057D50", Offset = "0x8056750", VA = "0x188057D50", Slot = "5")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600029E")]
	[Cpp2IlInjected.Address(RVA = "0x8058610", Offset = "0x8057010", VA = "0x188058610")]
	public BNDENDCKIIF(AEGDBIMJAKG JCJHLOEIIFO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600029F")]
	[Cpp2IlInjected.Address(RVA = "0x8057CE0", Offset = "0x80566E0", VA = "0x188057CE0", Slot = "8")]
	public void FMBIGGNKPCL(AEGDBIMJAKG HGBJMKAPAJA, object GNAAILLDOKI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002A0")]
	[Cpp2IlInjected.Address(RVA = "0x80582B0", Offset = "0x8056CB0", VA = "0x1880582B0", Slot = "9")]
	public void OGIAELLNJCL(object GNAAILLDOKI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002A3")]
	[Cpp2IlInjected.Address(RVA = "0x8057EE0", Offset = "0x80568E0", VA = "0x188057EE0")]
	private Vector3 LHLFPFHPIMA()
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x60002A4")]
	[Cpp2IlInjected.Address(RVA = "0x8057950", Offset = "0x8056350", VA = "0x188057950")]
	private void CPGJACFEAIG(AEGDBIMJAKG ELKNBBKDDHB)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002C")]
internal static class BANJAOGBEMF
{
	[Cpp2IlInjected.Token(Token = "0x60002A5")]
	[Cpp2IlInjected.Address(RVA = "0x8057890", Offset = "0x8056290", VA = "0x188057890")]
	public static CAIBCGHIODO EFAJKBJIJAG(this AEGDBIMJAKG GBDMJHAPPHC)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200002D")]
internal sealed class GGGFAJCKGAA : GBGPICOOMOF, JFADAMMEHIM
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400004E")]
	private readonly AFDHKDDEFPL JCJHLOEIIFO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400004F")]
	private readonly OverridableVector3 LFKEIMJCIAF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000050")]
	private readonly OverridableVector3 LMGDLPKFLBF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000051")]
	private float DJPMGMIBIEI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x44")]
	[Cpp2IlInjected.Token(Token = "0x4000052")]
	private float LJJAGKCDFME;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000053")]
	private Vector3 KFLGGOIFDLK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x54")]
	[Cpp2IlInjected.Token(Token = "0x4000054")]
	private Vector3? NGPEMHIJION;

	[Cpp2IlInjected.FieldOffset(Offset = "0x64")]
	[Cpp2IlInjected.Token(Token = "0x4000055")]
	private Quaternion? IFOGOBMIPHM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
	[Cpp2IlInjected.Token(Token = "0x4000056")]
	private bool GJHDKDJMBHG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x79")]
	[Cpp2IlInjected.Token(Token = "0x4000057")]
	private bool FAODDHABKMJ;

	[Cpp2IlInjected.Token(Token = "0x170000A1")]
	public Vector3 LEJBCFNAOGD
	{
		[Cpp2IlInjected.Token(Token = "0x60002A8")]
		[Cpp2IlInjected.Address(RVA = "0x151E2E0", Offset = "0x151CCE0", VA = "0x18151E2E0", Slot = "7")]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x60002A9")]
		[Cpp2IlInjected.Address(RVA = "0x805C8C0", Offset = "0x805B2C0", VA = "0x18805C8C0", Slot = "8")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A2")]
	public Vector3 NFBCHABDNEC
	{
		[Cpp2IlInjected.Token(Token = "0x60002AA")]
		[Cpp2IlInjected.Address(RVA = "0x805DCA0", Offset = "0x805C6A0", VA = "0x18805DCA0", Slot = "9")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A3")]
	public float DCHGLADGMNH
	{
		[Cpp2IlInjected.Token(Token = "0x60002AB")]
		[Cpp2IlInjected.Address(RVA = "0xC6A550", Offset = "0xC68F50", VA = "0x180C6A550", Slot = "10")]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x60002AC")]
		[Cpp2IlInjected.Address(RVA = "0x805B860", Offset = "0x805A260", VA = "0x18805B860")]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A4")]
	public float FBDCBPLJJNH
	{
		[Cpp2IlInjected.Token(Token = "0x60002AD")]
		[Cpp2IlInjected.Address(RVA = "0xB917B0", Offset = "0xB901B0", VA = "0x180B917B0", Slot = "11")]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x60002AE")]
		[Cpp2IlInjected.Address(RVA = "0x805CBF0", Offset = "0x805B5F0", VA = "0x18805CBF0", Slot = "12")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A5")]
	public Vector3 BIFJODANNFE
	{
		[Cpp2IlInjected.Token(Token = "0x60002AF")]
		[Cpp2IlInjected.Address(RVA = "0x805CCA0", Offset = "0x805B6A0", VA = "0x18805CCA0", Slot = "13")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A6")]
	public Quaternion GDOEFFLGCMO
	{
		[Cpp2IlInjected.Token(Token = "0x60002B0")]
		[Cpp2IlInjected.Address(RVA = "0x805D8E0", Offset = "0x805C2E0", VA = "0x18805D8E0", Slot = "14")]
		get
		{
			return default(Quaternion);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A7")]
	private Rigidbody JADPAFJKPGC
	{
		[Cpp2IlInjected.Token(Token = "0x60002B8")]
		[Cpp2IlInjected.Address(RVA = "0x805A570", Offset = "0x8058F70", VA = "0x18805A570")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400002A")]
	public event EIMKACMLCOF AAEBGEMEHFP
	{
		[Cpp2IlInjected.Token(Token = "0x60002A6")]
		[Cpp2IlInjected.Address(RVA = "0x805DA60", Offset = "0x805C460", VA = "0x18805DA60", Slot = "5")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60002A7")]
		[Cpp2IlInjected.Address(RVA = "0x805CB50", Offset = "0x805B550", VA = "0x18805CB50", Slot = "6")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60002B1")]
	[Cpp2IlInjected.Address(RVA = "0x805DE80", Offset = "0x805C880", VA = "0x18805DE80")]
	public GGGFAJCKGAA(AEGDBIMJAKG JCJHLOEIIFO, [In] BNAMPFDBALG DFPGGEDGGGN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002B2")]
	[Cpp2IlInjected.Address(RVA = "0x805B740", Offset = "0x805A140", VA = "0x18805B740", Slot = "17")]
	public void AKMOEEOCJGK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002B3")]
	[Cpp2IlInjected.Address(RVA = "0x805CE30", Offset = "0x805B830", VA = "0x18805CE30", Slot = "16")]
	public void HAFANPILNFO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002B4")]
	[Cpp2IlInjected.Address(RVA = "0x805B970", Offset = "0x805A370", VA = "0x18805B970", Slot = "19")]
	public void CGBEHGCJKJC(Rigidbody LHOBCJGBABO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002B5")]
	[Cpp2IlInjected.Address(RVA = "0x805C970", Offset = "0x805B370", VA = "0x18805C970", Slot = "20")]
	public void DEEDFLNEMBA(Rigidbody LHOBCJGBABO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002B6")]
	[Cpp2IlInjected.Address(RVA = "0x805CF10", Offset = "0x805B910", VA = "0x18805CF10", Slot = "18")]
	public void ICCOCPPFPIM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002B7")]
	[Cpp2IlInjected.Address(RVA = "0x805D2E0", Offset = "0x805BCE0", VA = "0x18805D2E0", Slot = "21")]
	public void JHBHKMFNBIH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002B9")]
	[Cpp2IlInjected.Address(RVA = "0x805C8C0", Offset = "0x805B2C0", VA = "0x18805C8C0")]
	private void CPBHHFMHFMK(Vector3 PPJFMHBDGNA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002BA")]
	[Cpp2IlInjected.Address(RVA = "0x805DD90", Offset = "0x805C790", VA = "0x18805DD90")]
	[Obsolete("This method is dangerous - the unity rigidbody is updated in a deferred manner and this world position may be stale")]
	private Vector3 PGAPJDPGDCO()
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x60002BB")]
	[Cpp2IlInjected.Address(RVA = "0x805B860", Offset = "0x805A260", VA = "0x18805B860")]
	private void CDECJEGACAD(float PPJFMHBDGNA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002BC")]
	[Cpp2IlInjected.Address(RVA = "0x805CBF0", Offset = "0x805B5F0", VA = "0x18805CBF0")]
	private void NNPJCNAPKBD(float PPJFMHBDGNA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002BD")]
	[Cpp2IlInjected.Address(RVA = "0x805DB00", Offset = "0x805C500", VA = "0x18805DB00")]
	private Vector3 NLLGMFHMBAK()
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x60002BE")]
	[Cpp2IlInjected.Address(RVA = "0x805D0B0", Offset = "0x805BAB0", VA = "0x18805D0B0", Slot = "15")]
	public void JFACDNBLNMA((Quaternion rot, Vector3 moments) BFILMAEAIPL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002BF")]
	[Cpp2IlInjected.Address(RVA = "0x805D760", Offset = "0x805C160", VA = "0x18805D760")]
	private Quaternion KJKAIJCPGEP()
	{
		return default(Quaternion);
	}

	[Cpp2IlInjected.Token(Token = "0x60002C0")]
	[Cpp2IlInjected.Address(RVA = "0x805BA50", Offset = "0x805A450", VA = "0x18805BA50")]
	public void CJICCOMINAN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002C1")]
	[Cpp2IlInjected.Address(RVA = "0x805BB20", Offset = "0x805A520", VA = "0x18805BB20", Slot = "4")]
	public (float, Vector3) CJICCOMINAN(Rigidbody FDHMOCKPBGF)
	{
		return default((float, Vector3));
	}
}
[Cpp2IlInjected.Token(Token = "0x200002E")]
internal static class FMPJIIOOBHC
{
	[Cpp2IlInjected.Token(Token = "0x60002C2")]
	[Cpp2IlInjected.Address(RVA = "0x805B680", Offset = "0x805A080", VA = "0x18805B680")]
	public static GBGPICOOMOF PCIEBEDKPEO(this AEGDBIMJAKG GBDMJHAPPHC)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200002F")]
internal sealed class BNDLOKHGFFC : KAGCJGFIMHB
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000058")]
	private readonly AFDHKDDEFPL JCJHLOEIIFO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000059")]
	private readonly OPHEEGEKGGC DPKPPAMIBAO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400005A")]
	private readonly FDEOGDPKFCL HAJKLCOCJOA;

	[Cpp2IlInjected.Token(Token = "0x170000A8")]
	public bool DBPPINLOBGG
	{
		[Cpp2IlInjected.Token(Token = "0x60002C3")]
		[Cpp2IlInjected.Address(RVA = "0x16D9A40", Offset = "0x16D8440", VA = "0x1816D9A40", Slot = "10")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A9")]
	public FDEOGDPKFCL FCKDCNLJJCB
	{
		[Cpp2IlInjected.Token(Token = "0x60002C4")]
		[Cpp2IlInjected.Address(RVA = "0xB86090", Offset = "0xB84A90", VA = "0x180B86090", Slot = "11")]
		get
		{
			return default(FDEOGDPKFCL);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60002C5")]
	[Cpp2IlInjected.Address(RVA = "0x8058D20", Offset = "0x8057720", VA = "0x188058D20")]
	public BNDLOKHGFFC(AEGDBIMJAKG JCJHLOEIIFO, [In] BNAMPFDBALG DFPGGEDGGGN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002C6")]
	[Cpp2IlInjected.Address(RVA = "0x80587B0", Offset = "0x80571B0", VA = "0x1880587B0", Slot = "4")]
	public void GMJBMKIKLGO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002C7")]
	[Cpp2IlInjected.Address(RVA = "0x8058710", Offset = "0x8057110", VA = "0x188058710")]
	private bool FDLMFBANCLP()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002C8")]
	[Cpp2IlInjected.Address(RVA = "0x8058CB0", Offset = "0x80576B0", VA = "0x188058CB0", Slot = "5")]
	public void OHNINFPNOII(object GNAAILLDOKI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002C9")]
	[Cpp2IlInjected.Address(RVA = "0x80588C0", Offset = "0x80572C0", VA = "0x1880588C0", Slot = "6")]
	public void IPBAIJFACJH(object GNAAILLDOKI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002CA")]
	[Cpp2IlInjected.Address(RVA = "0x8058B80", Offset = "0x8057580", VA = "0x188058B80", Slot = "9")]
	public void OGEOOICBKPD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002CB")]
	[Cpp2IlInjected.Address(RVA = "0x8058A70", Offset = "0x8057470", VA = "0x188058A70")]
	private void LKAKIHLLHCN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002CC")]
	[Cpp2IlInjected.Address(RVA = "0x80588F0", Offset = "0x80572F0", VA = "0x1880588F0")]
	private void KKGMNLOMHFA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002CD")]
	[Cpp2IlInjected.Address(RVA = "0x8058CE0", Offset = "0x80576E0", VA = "0x188058CE0", Slot = "8")]
	public void PGLEDKJCNGI(AEGDBIMJAKG JCJHLOEIIFO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002CE")]
	[Cpp2IlInjected.Address(RVA = "0x8058880", Offset = "0x8057280", VA = "0x188058880", Slot = "7")]
	public void HGKNDEFAOKH(AEGDBIMJAKG JCJHLOEIIFO)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000030")]
internal sealed class HJDOHNFPMAA : DLIEGGPBPJO
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400005C")]
	private readonly AFDHKDDEFPL JCJHLOEIIFO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400005D")]
	private readonly OPHEEGEKGGC HBMJBMNGGOK;

	[Cpp2IlInjected.Token(Token = "0x170000AA")]
	public bool JCNHMCMDBEI
	{
		[Cpp2IlInjected.Token(Token = "0x60002D1")]
		[Cpp2IlInjected.Address(RVA = "0x805E300", Offset = "0x805CD00", VA = "0x18805E300", Slot = "6")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400002B")]
	public event EIMKACMLCOF EIGIABMIGAC
	{
		[Cpp2IlInjected.Token(Token = "0x60002CF")]
		[Cpp2IlInjected.Address(RVA = "0x805E4A0", Offset = "0x805CEA0", VA = "0x18805E4A0", Slot = "4")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60002D0")]
		[Cpp2IlInjected.Address(RVA = "0x805E400", Offset = "0x805CE00", VA = "0x18805E400", Slot = "5")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60002D2")]
	[Cpp2IlInjected.Address(RVA = "0x805E550", Offset = "0x805CF50", VA = "0x18805E550")]
	public HJDOHNFPMAA(AEGDBIMJAKG JCJHLOEIIFO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002D3")]
	[Cpp2IlInjected.Address(RVA = "0x805E3F0", Offset = "0x805CDF0", VA = "0x18805E3F0", Slot = "7")]
	public void HDEFECDDIFF(object GNAAILLDOKI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002D4")]
	[Cpp2IlInjected.Address(RVA = "0x805E540", Offset = "0x805CF40", VA = "0x18805E540", Slot = "8")]
	public void OPMHODNMBPM(object GNAAILLDOKI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002D5")]
	[Cpp2IlInjected.Address(RVA = "0x805E1C0", Offset = "0x805CBC0", VA = "0x18805E1C0", Slot = "9")]
	public void CHCLPGMJHFM(object GNAAILLDOKI, bool MLIEPCEKKKM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002D6")]
	[Cpp2IlInjected.Address(RVA = "0x805E3B0", Offset = "0x805CDB0", VA = "0x18805E3B0", Slot = "12")]
	public void FJPMJNDCAEJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002D7")]
	[Cpp2IlInjected.Address(RVA = "0x805E140", Offset = "0x805CB40", VA = "0x18805E140", Slot = "10")]
	public void CGBEHGCJKJC(Rigidbody NEPEGLKEMNE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002D8")]
	[Cpp2IlInjected.Address(RVA = "0x805E2D0", Offset = "0x805CCD0", VA = "0x18805E2D0", Slot = "11")]
	public void DEEDFLNEMBA(Rigidbody LHOBCJGBABO)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000031")]
internal sealed class FFEBAJCJDNF : BBBKKDDBEJP, ONDFHDJOEBD, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400005F")]
	private readonly AFDHKDDEFPL JCJHLOEIIFO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000060")]
	private PhotonView BHOIPEJOEEF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000061")]
	private bool MJBDEHABEED;

	[Cpp2IlInjected.Token(Token = "0x170000AB")]
	public PhotonView IJBEGIODOFB
	{
		[Cpp2IlInjected.Token(Token = "0x60002DB")]
		[Cpp2IlInjected.Address(RVA = "0x9B5560", Offset = "0x9B3F60", VA = "0x1809B5560", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000AC")]
	public bool MLJHDDKNOBB
	{
		[Cpp2IlInjected.Token(Token = "0x60002DC")]
		[Cpp2IlInjected.Address(RVA = "0x805B010", Offset = "0x8059A10", VA = "0x18805B010", Slot = "7")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000AD")]
	public bool NEMCFNAJMJP
	{
		[Cpp2IlInjected.Token(Token = "0x60002DD")]
		[Cpp2IlInjected.Address(RVA = "0xD34A50", Offset = "0xD33450", VA = "0x180D34A50", Slot = "8")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400002C")]
	public event EIMKACMLCOF CEHFNLMIEBM
	{
		[Cpp2IlInjected.Token(Token = "0x60002D9")]
		[Cpp2IlInjected.Address(RVA = "0x805B030", Offset = "0x8059A30", VA = "0x18805B030", Slot = "5")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60002DA")]
		[Cpp2IlInjected.Address(RVA = "0x805B490", Offset = "0x8059E90", VA = "0x18805B490", Slot = "6")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60002DE")]
	[Cpp2IlInjected.Address(RVA = "0x805B530", Offset = "0x8059F30", VA = "0x18805B530")]
	public FFEBAJCJDNF(AEGDBIMJAKG JCJHLOEIIFO, [In] BNAMPFDBALG DFPGGEDGGGN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002DF")]
	[Cpp2IlInjected.Address(RVA = "0x805AC00", Offset = "0x8059600", VA = "0x18805AC00", Slot = "9")]
	public void GMJBMKIKLGO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002E0")]
	[Cpp2IlInjected.Address(RVA = "0x805A990", Offset = "0x8059390", VA = "0x18805A990", Slot = "12")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002E1")]
	[Cpp2IlInjected.Address(RVA = "0x805AA90", Offset = "0x8059490", VA = "0x18805AA90", Slot = "10")]
	public void ELBMGNAHEAP(AEGDBIMJAKG HGBJMKAPAJA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002E2")]
	[Cpp2IlInjected.Address(RVA = "0x805AEA0", Offset = "0x80598A0", VA = "0x18805AEA0", Slot = "11")]
	public void GOPNOGMOMJD(AEGDBIMJAKG HGBJMKAPAJA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002E3")]
	[Cpp2IlInjected.Address(RVA = "0x805AD30", Offset = "0x8059730", VA = "0x18805AD30")]
	private void GOBIAGBFPON(PhotonView ILMOOELGPEO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002E4")]
	[Cpp2IlInjected.Address(RVA = "0x805B0D0", Offset = "0x8059AD0", VA = "0x18805B0D0")]
	private void NMHMDNHCGIM(COGOJKBIHHJ IHELKHKNMFO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002E5")]
	[Cpp2IlInjected.Address(RVA = "0x805B220", Offset = "0x8059C20", VA = "0x18805B220")]
	private void PANALDKOKNB(PhotonView KEOBCDMNPCL)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000032")]
internal static class BOFNDLANCOL
{
	[Cpp2IlInjected.Token(Token = "0x60002E6")]
	[Cpp2IlInjected.Address(RVA = "0x8058E20", Offset = "0x8057820", VA = "0x188058E20")]
	public static BBBKKDDBEJP ABAAAEKKFFN(this AEGDBIMJAKG GBDMJHAPPHC)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000033")]
internal sealed class DMFHKCEMIBM : BMKDEGFOAMG
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000062")]
	private readonly AFDHKDDEFPL JCJHLOEIIFO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000063")]
	private RigidbodyConstraints ODACFPDGGJM;

	[Cpp2IlInjected.Token(Token = "0x170000AE")]
	public bool PPGCBNJPMIA
	{
		[Cpp2IlInjected.Token(Token = "0x60002E7")]
		[Cpp2IlInjected.Address(RVA = "0xA0B320", Offset = "0xA09D20", VA = "0x180A0B320", Slot = "4")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x60002E8")]
		[Cpp2IlInjected.Address(RVA = "0xC9EBB0", Offset = "0xC9D5B0", VA = "0x180C9EBB0", Slot = "5")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000AF")]
	public bool KPLLMJIFLNJ
	{
		[Cpp2IlInjected.Token(Token = "0x60002E9")]
		[Cpp2IlInjected.Address(RVA = "0xC9E4C0", Offset = "0xC9CEC0", VA = "0x180C9E4C0", Slot = "6")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x60002EA")]
		[Cpp2IlInjected.Address(RVA = "0xC9E840", Offset = "0xC9D240", VA = "0x180C9E840")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B0")]
	public RigidbodyConstraints JBABDFEEJCO
	{
		[Cpp2IlInjected.Token(Token = "0x60002EB")]
		[Cpp2IlInjected.Address(RVA = "0x9B5570", Offset = "0x9B3F70", VA = "0x1809B5570", Slot = "7")]
		get
		{
			return default(RigidbodyConstraints);
		}
		[Cpp2IlInjected.Token(Token = "0x60002EC")]
		[Cpp2IlInjected.Address(RVA = "0x80597F0", Offset = "0x80581F0", VA = "0x1880597F0", Slot = "8")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60002ED")]
	[Cpp2IlInjected.Address(RVA = "0x8059920", Offset = "0x8058320", VA = "0x188059920")]
	public DMFHKCEMIBM(AEGDBIMJAKG JCJHLOEIIFO, [In] BNAMPFDBALG DFPGGEDGGGN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002EE")]
	[Cpp2IlInjected.Address(RVA = "0x8059790", Offset = "0x8058190", VA = "0x188059790", Slot = "9")]
	public void CGBEHGCJKJC(Rigidbody LHOBCJGBABO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002EF")]
	[Cpp2IlInjected.Address(RVA = "0x80597C0", Offset = "0x80581C0", VA = "0x1880597C0", Slot = "10")]
	public void DEEDFLNEMBA(Rigidbody LHOBCJGBABO)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000034")]
internal sealed class KPEEPAGMOFC : LCPFLPPAHGD
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000066")]
	private readonly AEGDBIMJAKG JCJHLOEIIFO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000067")]
	private float DDGFLICCGJD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
	[Cpp2IlInjected.Token(Token = "0x4000068")]
	private float CGGNBGNBIIJ;

	[Cpp2IlInjected.Token(Token = "0x170000B1")]
	public float OPECJKNFJCK
	{
		[Cpp2IlInjected.Token(Token = "0x60002F1")]
		[Cpp2IlInjected.Address(RVA = "0xE5FD30", Offset = "0xE5E730", VA = "0x180E5FD30", Slot = "4")]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x60002F2")]
		[Cpp2IlInjected.Address(RVA = "0x8066D90", Offset = "0x8065790", VA = "0x188066D90", Slot = "5")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B2")]
	public float GHFBDEPLCDA
	{
		[Cpp2IlInjected.Token(Token = "0x60002F3")]
		[Cpp2IlInjected.Address(RVA = "0xCB3DA0", Offset = "0xCB27A0", VA = "0x180CB3DA0", Slot = "6")]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x60002F4")]
		[Cpp2IlInjected.Address(RVA = "0x8066C20", Offset = "0x8065620", VA = "0x188066C20", Slot = "7")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60002F0")]
	[Cpp2IlInjected.Address(RVA = "0x8066E60", Offset = "0x8065860", VA = "0x188066E60")]
	public KPEEPAGMOFC(AEGDBIMJAKG JCJHLOEIIFO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002F5")]
	[Cpp2IlInjected.Address(RVA = "0x8066BD0", Offset = "0x80655D0", VA = "0x188066BD0", Slot = "8")]
	public void CGBEHGCJKJC(Rigidbody LHOBCJGBABO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002F6")]
	[Cpp2IlInjected.Address(RVA = "0x8066CF0", Offset = "0x80656F0", VA = "0x188066CF0", Slot = "9")]
	public void DEEDFLNEMBA(Rigidbody LHOBCJGBABO)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000035")]
internal sealed class EHEGMANMPMD : FHMKNHCIOOB
{
	[Cpp2IlInjected.Token(Token = "0x4000069")]
	private static readonly LMPJBEBLCLM KOEJENGJDMJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400006B")]
	private readonly AFDHKDDEFPL JCJHLOEIIFO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400006C")]
	private bool AHBNHJNMMDK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x21")]
	[Cpp2IlInjected.Token(Token = "0x400006D")]
	private bool ELOJCOIMHIN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
	[Cpp2IlInjected.Token(Token = "0x400006E")]
	private int IHHGNIEJKKA;

	[Cpp2IlInjected.Token(Token = "0x170000B3")]
	private Rigidbody JADPAFJKPGC
	{
		[Cpp2IlInjected.Token(Token = "0x60002F9")]
		[Cpp2IlInjected.Address(RVA = "0x805A570", Offset = "0x8058F70", VA = "0x18805A570")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B4")]
	private bool OIHDLNHKKLG
	{
		[Cpp2IlInjected.Token(Token = "0x60002FA")]
		[Cpp2IlInjected.Address(RVA = "0x8059CE0", Offset = "0x80586E0", VA = "0x188059CE0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B5")]
	private AEGDBIMJAKG LKNIONJKNBM
	{
		[Cpp2IlInjected.Token(Token = "0x60002FB")]
		[Cpp2IlInjected.Address(RVA = "0x8059FC0", Offset = "0x80589C0", VA = "0x188059FC0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B6")]
	private bool JBBBMCHECPD
	{
		[Cpp2IlInjected.Token(Token = "0x60002FC")]
		[Cpp2IlInjected.Address(RVA = "0x8059D70", Offset = "0x8058770", VA = "0x188059D70")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400002D")]
	public event EIMKACMLCOF LKAKPBAKBIE
	{
		[Cpp2IlInjected.Token(Token = "0x60002F7")]
		[Cpp2IlInjected.Address(RVA = "0x8059DD0", Offset = "0x80587D0", VA = "0x188059DD0", Slot = "4")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60002F8")]
		[Cpp2IlInjected.Address(RVA = "0x80599C0", Offset = "0x80583C0", VA = "0x1880599C0", Slot = "5")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60002FD")]
	[Cpp2IlInjected.Address(RVA = "0x805A640", Offset = "0x8059040", VA = "0x18805A640")]
	public EHEGMANMPMD(AEGDBIMJAKG JCJHLOEIIFO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002FE")]
	[Cpp2IlInjected.Address(RVA = "0x8059F30", Offset = "0x8058930", VA = "0x188059F30", Slot = "6")]
	public void GMJBMKIKLGO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002FF")]
	[Cpp2IlInjected.Address(RVA = "0x805A560", Offset = "0x8058F60", VA = "0x18805A560", Slot = "8")]
	public void POBIIPGJMKK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000300")]
	[Cpp2IlInjected.Address(RVA = "0x805A020", Offset = "0x8058A20", VA = "0x18805A020", Slot = "7")]
	public bool HJMKGFNNCFL()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000301")]
	[Cpp2IlInjected.Address(RVA = "0x805A170", Offset = "0x8058B70", VA = "0x18805A170", Slot = "9")]
	public void HNBPCPCJAHK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000302")]
	[Cpp2IlInjected.Address(RVA = "0x805A3A0", Offset = "0x8058DA0", VA = "0x18805A3A0", Slot = "13")]
	public void KFPHNLHMHHJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000303")]
	[Cpp2IlInjected.Address(RVA = "0x805A440", Offset = "0x8058E40", VA = "0x18805A440", Slot = "12")]
	public void LJHFLJNGPPE(bool NCEEHDIIPEK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000304")]
	[Cpp2IlInjected.Address(RVA = "0x8059D00", Offset = "0x8058700", VA = "0x188059D00", Slot = "10")]
	public bool EDPHOIGNEKN()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000305")]
	[Cpp2IlInjected.Address(RVA = "0x8059E70", Offset = "0x8058870", VA = "0x188059E70", Slot = "11")]
	public bool GJMFDPACDLB()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000306")]
	[Cpp2IlInjected.Address(RVA = "0x8059A60", Offset = "0x8058460", VA = "0x188059A60")]
	private bool CDKPMBBLEIC()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000307")]
	[Cpp2IlInjected.Address(RVA = "0x805A210", Offset = "0x8058C10", VA = "0x18805A210")]
	private void IKFEFDHIBOC()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000036")]
internal sealed class IBHAHEPLEOE : JFEEDKNMOFN
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400006F")]
	private readonly AFDHKDDEFPL JCJHLOEIIFO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000070")]
	private readonly OPHEEGEKGGC GHGDFBCAOOG;

	[Cpp2IlInjected.Token(Token = "0x170000B7")]
	public Rigidbody JADPAFJKPGC
	{
		[Cpp2IlInjected.Token(Token = "0x6000309")]
		[Cpp2IlInjected.Address(RVA = "0x9B5560", Offset = "0x9B3F60", VA = "0x1809B5560", Slot = "4")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600030A")]
		[Cpp2IlInjected.Address(RVA = "0x9B0460", Offset = "0x9AEE60", VA = "0x1809B0460")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B8")]
	private bool JBBBMCHECPD
	{
		[Cpp2IlInjected.Token(Token = "0x600030B")]
		[Cpp2IlInjected.Address(RVA = "0x8060700", Offset = "0x805F100", VA = "0x188060700")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B9")]
	public bool LFEPNDELHKF
	{
		[Cpp2IlInjected.Token(Token = "0x600030E")]
		[Cpp2IlInjected.Address(RVA = "0x16D9A40", Offset = "0x16D8440", VA = "0x1816D9A40", Slot = "6")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600030C")]
	[Cpp2IlInjected.Address(RVA = "0x8060D10", Offset = "0x805F710", VA = "0x188060D10")]
	public IBHAHEPLEOE(AEGDBIMJAKG JCJHLOEIIFO, [In] BNAMPFDBALG DFPGGEDGGGN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600030D")]
	[Cpp2IlInjected.Address(RVA = "0x8060A90", Offset = "0x805F490", VA = "0x188060A90", Slot = "5")]
	public void GMJBMKIKLGO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600030F")]
	[Cpp2IlInjected.Address(RVA = "0x8060CB0", Offset = "0x805F6B0", VA = "0x188060CB0", Slot = "7")]
	public void MBNHJKHPNPC(object GNAAILLDOKI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000310")]
	[Cpp2IlInjected.Address(RVA = "0x8060CE0", Offset = "0x805F6E0", VA = "0x188060CE0", Slot = "8")]
	public void MPICDEHACKI(object GNAAILLDOKI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000311")]
	[Cpp2IlInjected.Address(RVA = "0x8060760", Offset = "0x805F160", VA = "0x188060760", Slot = "9")]
	public void GEGGEMKPKED()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000312")]
	[Cpp2IlInjected.Address(RVA = "0x8060510", Offset = "0x805EF10", VA = "0x188060510", Slot = "10")]
	public void DEEOOJBPGJN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000313")]
	[Cpp2IlInjected.Address(RVA = "0x8060B30", Offset = "0x805F530", VA = "0x188060B30", Slot = "11")]
	public void LPDKGDHFDOP()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000037")]
internal sealed class IOGBPMBDOCN : HBGNPJEJHHJ, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000072")]
	private readonly AFDHKDDEFPL JCJHLOEIIFO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000073")]
	private readonly OPHEEGEKGGC DFGIOIKCNPI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000074")]
	private float PDIIMOBPILN;

	[Cpp2IlInjected.Token(Token = "0x170000BA")]
	public EDDAFEHGANJ AIFJKNOJMPM
	{
		[Cpp2IlInjected.Token(Token = "0x6000314")]
		[Cpp2IlInjected.Address(RVA = "0x9AED50", Offset = "0x9AD750", VA = "0x1809AED50", Slot = "4")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000315")]
		[Cpp2IlInjected.Address(RVA = "0x9B6FD0", Offset = "0x9B59D0", VA = "0x1809B6FD0", Slot = "5")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000BB")]
	public PMMOKEJBHFJ OHCMFAEHIHD
	{
		[Cpp2IlInjected.Token(Token = "0x6000316")]
		[Cpp2IlInjected.Address(RVA = "0x9AEFC0", Offset = "0x9AD9C0", VA = "0x1809AEFC0", Slot = "6")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000317")]
		[Cpp2IlInjected.Address(RVA = "0x9B5530", Offset = "0x9B3F30", VA = "0x1809B5530", Slot = "7")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000BC")]
	public Vector3 JBOLMPDFKDF
	{
		[Cpp2IlInjected.Token(Token = "0x6000318")]
		[Cpp2IlInjected.Address(RVA = "0x8063C80", Offset = "0x8062680", VA = "0x188063C80", Slot = "8")]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x6000319")]
		[Cpp2IlInjected.Address(RVA = "0x8062DA0", Offset = "0x80617A0", VA = "0x188062DA0", Slot = "9")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000BD")]
	public Vector3 GOMGLAPHAHG
	{
		[Cpp2IlInjected.Token(Token = "0x600031A")]
		[Cpp2IlInjected.Address(RVA = "0x8064950", Offset = "0x8063350", VA = "0x188064950", Slot = "10")]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x600031B")]
		[Cpp2IlInjected.Address(RVA = "0x8063000", Offset = "0x8061A00", VA = "0x188063000", Slot = "11")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000BE")]
	public Vector3 EEHIJMCACGH
	{
		[Cpp2IlInjected.Token(Token = "0x600031C")]
		[Cpp2IlInjected.Address(RVA = "0x8065180", Offset = "0x8063B80", VA = "0x188065180", Slot = "12")]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x600031D")]
		[Cpp2IlInjected.Address(RVA = "0x80650C0", Offset = "0x8063AC0", VA = "0x1880650C0", Slot = "13")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000BF")]
	public Vector3 JFNNBNCGHBP
	{
		[Cpp2IlInjected.Token(Token = "0x600031E")]
		[Cpp2IlInjected.Address(RVA = "0x8063140", Offset = "0x8061B40", VA = "0x188063140", Slot = "14")]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x600031F")]
		[Cpp2IlInjected.Address(RVA = "0x8064AD0", Offset = "0x80634D0", VA = "0x188064AD0", Slot = "15")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000C0")]
	public float PEJGPIMKEKB
	{
		[Cpp2IlInjected.Token(Token = "0x6000320")]
		[Cpp2IlInjected.Address(RVA = "0xE68BF0", Offset = "0xE675F0", VA = "0x180E68BF0", Slot = "16")]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x6000321")]
		[Cpp2IlInjected.Address(RVA = "0x8063030", Offset = "0x8061A30", VA = "0x188063030", Slot = "17")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000C1")]
	public bool MOCHOEMIBEB
	{
		[Cpp2IlInjected.Token(Token = "0x6000322")]
		[Cpp2IlInjected.Address(RVA = "0x200A3E0", Offset = "0x2008DE0", VA = "0x18200A3E0", Slot = "18")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000C2")]
	private BIENKFHPJMP DILINOLHNBO
	{
		[Cpp2IlInjected.Token(Token = "0x6000337")]
		[Cpp2IlInjected.Address(RVA = "0x76BA800", Offset = "0x76B9200", VA = "0x1876BA800")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000C3")]
	private bool OIHDLNHKKLG
	{
		[Cpp2IlInjected.Token(Token = "0x6000338")]
		[Cpp2IlInjected.Address(RVA = "0x8062480", Offset = "0x8060E80", VA = "0x188062480")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000323")]
	[Cpp2IlInjected.Address(RVA = "0x80653A0", Offset = "0x8063DA0", VA = "0x1880653A0")]
	public IOGBPMBDOCN(AEGDBIMJAKG JCJHLOEIIFO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000324")]
	[Cpp2IlInjected.Address(RVA = "0x8061D10", Offset = "0x8060710", VA = "0x188061D10", Slot = "19")]
	public void GMJBMKIKLGO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000325")]
	[Cpp2IlInjected.Address(RVA = "0x8062D40", Offset = "0x8061740", VA = "0x188062D40", Slot = "36")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000326")]
	[Cpp2IlInjected.Address(RVA = "0x8062350", Offset = "0x8060D50", VA = "0x188062350", Slot = "28")]
	public void CGBEHGCJKJC(Rigidbody LHOBCJGBABO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000327")]
	[Cpp2IlInjected.Address(RVA = "0x14E3160", Offset = "0x14E1B60", VA = "0x1814E3160", Slot = "20")]
	public void BOOFJIMLHGI(object GNAAILLDOKI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000328")]
	[Cpp2IlInjected.Address(RVA = "0x14E24C0", Offset = "0x14E0EC0", VA = "0x1814E24C0", Slot = "30")]
	public void CIBPDBGMCPN(object GNAAILLDOKI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000329")]
	[Cpp2IlInjected.Address(RVA = "0x8061B30", Offset = "0x8060530", VA = "0x188061B30", Slot = "35")]
	public Vector3 ABOAMJNOFCD(Vector3 PJJJJDKGMGH)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x600032A")]
	[Cpp2IlInjected.Address(RVA = "0x8063F10", Offset = "0x8062910", VA = "0x188063F10", Slot = "34")]
	public Vector3 IGGJJBLPPKA(Vector3 NJBLGKBFLMG)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x600032B")]
	[Cpp2IlInjected.Address(RVA = "0x8061D10", Offset = "0x8060710", VA = "0x188061D10", Slot = "27")]
	public void AIMEKICABJJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600032C")]
	[Cpp2IlInjected.Address(RVA = "0x8064D40", Offset = "0x8063740", VA = "0x188064D40", Slot = "25")]
	public void NJBILFLLADD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600032D")]
	[Cpp2IlInjected.Address(RVA = "0x80624A0", Offset = "0x8060EA0", VA = "0x1880624A0", Slot = "24")]
	public void DAJJDIHJIFG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600032E")]
	[Cpp2IlInjected.Address(RVA = "0x8064B00", Offset = "0x8063500", VA = "0x188064B00", Slot = "33")]
	public void NDNMFEBPDPJ(Vector3 KKNIJFMODLP, Vector3 HAKGCOPLKEE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600032F")]
	[Cpp2IlInjected.Address(RVA = "0x8065340", Offset = "0x8063D40", VA = "0x188065340", Slot = "32")]
	public void PMJEDFAIGPL(Vector3 HOJGOCKJLEI, Vector3 HELMCCBIBJA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000330")]
	[Cpp2IlInjected.Address(RVA = "0x8062E60", Offset = "0x8061860", VA = "0x188062E60", Slot = "31")]
	public void FJAJFJCLDJK(Vector3 KKAPAIFKKGJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000331")]
	[Cpp2IlInjected.Address(RVA = "0x8062500", Offset = "0x8060F00", VA = "0x188062500", Slot = "22")]
	public void DBPFGEEAFLO(NDBGGMAABME GLDACEOGKOF, Vector3 ICDAHOACGJL, float MFDBDMLHKBO, float CMEMFLLIBBI = 8f, float DMHCNEFBFKH = 1f)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000332")]
	[Cpp2IlInjected.Address(RVA = "0x80640D0", Offset = "0x8062AD0", VA = "0x1880640D0", Slot = "21")]
	public void IINNMDPIFOE(MAHCBKNMHNB PEOJMKLPOGJ, Vector3 JBPODNLOLED, float MJDLKKNIKHJ = float.PositiveInfinity)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000333")]
	[Cpp2IlInjected.Address(RVA = "0x8063800", Offset = "0x8062200", VA = "0x188063800", Slot = "23")]
	[Obsolete("Deprecated. Still exists to support deprecated CV2 chips. Use ApplyAngularVelocityChange.")]
	public void HEODHCBKGJC(MAHCBKNMHNB PEOJMKLPOGJ, Vector3 KONJHPLFEME, float MGFDEACAIGP = 7f, float DLPODANBMAG = 1f)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000334")]
	[Cpp2IlInjected.Address(RVA = "0x1612670", Offset = "0x1611070", VA = "0x181612670")]
	private static void IHFCAPLFLBG(Vector3 FKMLPLAMBLK, Vector3 MDIKGGEOGCO, [Out] Vector3 PFKKAJLIFGC, [Out] Vector3 MMIPCJDCMCL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000335")]
	[Cpp2IlInjected.Address(RVA = "0x8063E30", Offset = "0x8062830", VA = "0x188063E30", Slot = "29")]
	public Vector3 HMJDCLHNDNE(Vector3 FKMLPLAMBLK)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000336")]
	[Cpp2IlInjected.Address(RVA = "0x8064DA0", Offset = "0x80637A0", VA = "0x188064DA0", Slot = "26")]
	public void OOFMNJCINFK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000339")]
	[Cpp2IlInjected.Address(RVA = "0x8063030", Offset = "0x8061A30", VA = "0x188063030")]
	private void LGDMDKJKLGP(float PPJFMHBDGNA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600033A")]
	[Cpp2IlInjected.Address(RVA = "0x8062BA0", Offset = "0x80615A0", VA = "0x188062BA0")]
	private void DOKHLBKGNAB(Vector3 JBPODNLOLED)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600033B")]
	[Cpp2IlInjected.Address(RVA = "0x80647D0", Offset = "0x80631D0", VA = "0x1880647D0")]
	private Vector3 KDHGDHCGOAF()
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x600033C")]
	[Cpp2IlInjected.Address(RVA = "0x8064350", Offset = "0x8062D50", VA = "0x188064350")]
	private void JFIMHCPCKEC(Vector3 NJBLGKBFLMG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600033D")]
	[Cpp2IlInjected.Address(RVA = "0x8064F30", Offset = "0x8063930", VA = "0x188064F30")]
	private Vector3 OPIAEKEFBJA()
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x600033E")]
	[Cpp2IlInjected.Address(RVA = "0x80632D0", Offset = "0x8061CD0", VA = "0x1880632D0")]
	private void HADIIKCJKJH(Vector3 PPJFMHBDGNA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600033F")]
	[Cpp2IlInjected.Address(RVA = "0x8061DB0", Offset = "0x80607B0", VA = "0x188061DB0")]
	private void CFCCPPBOCLH(Vector3 NJBLGKBFLMG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000340")]
	[Cpp2IlInjected.Address(RVA = "0x8063750", Offset = "0x8062150", VA = "0x188063750")]
	private void HBOJJAFEGGP()
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
