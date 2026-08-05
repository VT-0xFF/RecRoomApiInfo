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
	public class LogRegistrationIndex : LGGBAGMLBKB
	{
		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(RVA = "0x7D40710", Offset = "0x7D3F910", VA = "0x187D40710", Slot = "4")]
		public override void COGNOIDNGPM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0x98C9C0", Offset = "0x98BBC0", VA = "0x18098C9C0")]
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
			[Cpp2IlInjected.Address(RVA = "0x964CD0", Offset = "0x963ED0", VA = "0x180964CD0", Slot = "4")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x1E90770", Offset = "0x1E8F970", VA = "0x181E90770", Slot = "5")]
		public override void SetServiceCategoryIndices(List<int> globalFromLocalIndices)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x7D4D750", Offset = "0x7D4C950", VA = "0x187D4D750")]
		private void BCKFAMNGJJN(IServiceRegistration registry)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x7D4DA50", Offset = "0x7D4CC50", VA = "0x187D4DA50", Slot = "6")]
		public override void RegisterServices(IServiceRegistration registry, [In] ServiceBitsetFilter filter)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x7D4DAB0", Offset = "0x7D4CCB0", VA = "0x187D4DAB0")]
		public _AssemblyIndex()
		{
		}
	}
}
namespace RecRoom
{
	[Cpp2IlInjected.Token(Token = "0x2000004")]
	[DisallowMultipleComponent]
	public sealed class RigidbodyEx : MonoBehaviour, KCAMGMHDEDF, LCCLDLHOIOG, FPEEDACMMGB
	{
		[Cpp2IlInjected.Token(Token = "0x4000004")]
		private static readonly PBBCGFNIILA FEGDCIHCPMN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000005")]
		private bool ADDIEPFHGMH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000006")]
		private CKJMPDKLOMB GGLDLKCKPAH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000007")]
		[CLMHABBIPJG(ADOEJJMOABO.Self, false, false, false)]
		[SerializeField]
		private Rigidbody unityRigidbody;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000008")]
		[SerializeField]
		[CLMHABBIPJG(ADOEJJMOABO.SelfAndParent, true, false, false)]
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
		private LEFFBPINKCP physicsInterpolation;

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
		private Transform LHGJGHDDNFA;

		[Cpp2IlInjected.Token(Token = "0x17000002")]
		internal CKJMPDKLOMB EBNLHMCGGDN
		{
			[Cpp2IlInjected.Token(Token = "0x6000008")]
			[Cpp2IlInjected.Address(RVA = "0x7D48190", Offset = "0x7D47390", VA = "0x187D48190")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000003")]
		private CKJMPDKLOMB NGLCHKFOMKO
		{
			[Cpp2IlInjected.Token(Token = "0x6000009")]
			[Cpp2IlInjected.Address(RVA = "0x968CD0", Offset = "0x967ED0", VA = "0x180968CD0", Slot = "6")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000004")]
		public int AFHKCJNFMKC
		{
			[Cpp2IlInjected.Token(Token = "0x600001E")]
			[Cpp2IlInjected.Address(RVA = "0x7D4AC60", Offset = "0x7D49E60", VA = "0x187D4AC60")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000005")]
		public RigidbodyEx FOOFDOBGPBJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000020")]
			[Cpp2IlInjected.Address(RVA = "0x7D4AFC0", Offset = "0x7D4A1C0", VA = "0x187D4AFC0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000006")]
		public RigidbodyEx GMOCPPMLGKK
		{
			[Cpp2IlInjected.Token(Token = "0x6000021")]
			[Cpp2IlInjected.Address(RVA = "0x7D4AF00", Offset = "0x7D4A100", VA = "0x187D4AF00")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000007")]
		public RigidbodyEx JNGEIJHHFEP
		{
			[Cpp2IlInjected.Token(Token = "0x6000022")]
			[Cpp2IlInjected.Address(RVA = "0x7D4BBC0", Offset = "0x7D4ADC0", VA = "0x187D4BBC0")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000023")]
			[Cpp2IlInjected.Address(RVA = "0x7D4D0C0", Offset = "0x7D4C2C0", VA = "0x187D4D0C0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000008")]
		public bool HJKOOPCMMKN
		{
			[Cpp2IlInjected.Token(Token = "0x6000024")]
			[Cpp2IlInjected.Address(RVA = "0x79BC8C0", Offset = "0x79BBAC0", VA = "0x1879BC8C0", Slot = "11")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000025")]
			[Cpp2IlInjected.Address(RVA = "0x79BD590", Offset = "0x79BC790", VA = "0x1879BD590")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000009")]
		public Transform LBAHEDDLOKA
		{
			[Cpp2IlInjected.Token(Token = "0x6000026")]
			[Cpp2IlInjected.Address(RVA = "0x1CCACE0", Offset = "0x1CC9EE0", VA = "0x181CCACE0", Slot = "5")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000A")]
		public Transform JIJHGKPJFFO
		{
			[Cpp2IlInjected.Token(Token = "0x6000027")]
			[Cpp2IlInjected.Address(RVA = "0x1CCACE0", Offset = "0x1CC9EE0", VA = "0x181CCACE0", Slot = "13")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000B")]
		public Transform AEAEPMOPBOK
		{
			[Cpp2IlInjected.Token(Token = "0x6000028")]
			[Cpp2IlInjected.Address(RVA = "0x1CCACE0", Offset = "0x1CC9EE0", VA = "0x181CCACE0", Slot = "14")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000C")]
		public DFMIAGBKIML FOPOMNMNGMP
		{
			[Cpp2IlInjected.Token(Token = "0x6000029")]
			[Cpp2IlInjected.Address(RVA = "0x7D4ACC0", Offset = "0x7D49EC0", VA = "0x187D4ACC0")]
			get
			{
				return default(DFMIAGBKIML);
			}
			[Cpp2IlInjected.Token(Token = "0x600002A")]
			[Cpp2IlInjected.Address(RVA = "0x7D4C870", Offset = "0x7D4BA70", VA = "0x187D4C870")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000D")]
		public bool BLIMOKGJPKC
		{
			[Cpp2IlInjected.Token(Token = "0x600002B")]
			[Cpp2IlInjected.Address(RVA = "0x7D4B2D0", Offset = "0x7D4A4D0", VA = "0x187D4B2D0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000E")]
		public bool FNOOOLDGFGB
		{
			[Cpp2IlInjected.Token(Token = "0x600002C")]
			[Cpp2IlInjected.Address(RVA = "0x7D4ADE0", Offset = "0x7D49FE0", VA = "0x187D4ADE0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000F")]
		public BFHLICCPHMB AOEDIBNPEPP
		{
			[Cpp2IlInjected.Token(Token = "0x600002D")]
			[Cpp2IlInjected.Address(RVA = "0x7D4B210", Offset = "0x7D4A410", VA = "0x187D4B210")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600002E")]
			[Cpp2IlInjected.Address(RVA = "0x7D4CA30", Offset = "0x7D4BC30", VA = "0x187D4CA30")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000010")]
		public CBFNNFFIFKO AFFAHABPJCD
		{
			[Cpp2IlInjected.Token(Token = "0x600002F")]
			[Cpp2IlInjected.Address(RVA = "0x7D4B1B0", Offset = "0x7D4A3B0", VA = "0x187D4B1B0")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000030")]
			[Cpp2IlInjected.Address(RVA = "0x7D4C9C0", Offset = "0x7D4BBC0", VA = "0x187D4C9C0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000011")]
		public bool HFBNJKFPMNO
		{
			[Cpp2IlInjected.Token(Token = "0x6000031")]
			[Cpp2IlInjected.Address(RVA = "0x7D4B100", Offset = "0x7D4A300", VA = "0x187D4B100")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000012")]
		public Rigidbody KEAOKJKIGHN
		{
			[Cpp2IlInjected.Token(Token = "0x6000032")]
			[Cpp2IlInjected.Address(RVA = "0x7D4B160", Offset = "0x7D4A360", VA = "0x187D4B160")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000013")]
		public bool MFEJOIIBKHM
		{
			[Cpp2IlInjected.Token(Token = "0x6000033")]
			[Cpp2IlInjected.Address(RVA = "0x7D4AE40", Offset = "0x7D4A040", VA = "0x187D4AE40")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000034")]
			[Cpp2IlInjected.Address(RVA = "0x7D4C8E0", Offset = "0x7D4BAE0", VA = "0x187D4C8E0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000014")]
		public bool CKJMLKFINLD
		{
			[Cpp2IlInjected.Token(Token = "0x6000035")]
			[Cpp2IlInjected.Address(RVA = "0x1404790", Offset = "0x1403990", VA = "0x181404790", Slot = "7")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000015")]
		public float IFJOFKGNPEC
		{
			[Cpp2IlInjected.Token(Token = "0x6000036")]
			[Cpp2IlInjected.Address(RVA = "0x7D4BB60", Offset = "0x7D4AD60", VA = "0x187D4BB60")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000016")]
		public float FAMHEECINGG
		{
			[Cpp2IlInjected.Token(Token = "0x6000037")]
			[Cpp2IlInjected.Address(RVA = "0x7D4BB00", Offset = "0x7D4AD00", VA = "0x187D4BB00")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x6000038")]
			[Cpp2IlInjected.Address(RVA = "0x7D4D050", Offset = "0x7D4C250", VA = "0x187D4D050")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000017")]
		public float MCIFMMODLGH
		{
			[Cpp2IlInjected.Token(Token = "0x6000039")]
			[Cpp2IlInjected.Address(RVA = "0x7D4B530", Offset = "0x7D4A730", VA = "0x187D4B530")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x600003A")]
			[Cpp2IlInjected.Address(RVA = "0x7D4CCD0", Offset = "0x7D4BED0", VA = "0x187D4CCD0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000018")]
		public float FICKOBECBPI
		{
			[Cpp2IlInjected.Token(Token = "0x600003B")]
			[Cpp2IlInjected.Address(RVA = "0x7D4B330", Offset = "0x7D4A530", VA = "0x187D4B330")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x600003C")]
			[Cpp2IlInjected.Address(RVA = "0x7D4CAA0", Offset = "0x7D4BCA0", VA = "0x187D4CAA0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000019")]
		public bool LLEJFBHCNCJ
		{
			[Cpp2IlInjected.Token(Token = "0x600003D")]
			[Cpp2IlInjected.Address(RVA = "0x7D4C110", Offset = "0x7D4B310", VA = "0x187D4C110")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x600003E")]
			[Cpp2IlInjected.Address(RVA = "0x7D4D600", Offset = "0x7D4C800", VA = "0x187D4D600")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001A")]
		public Vector3 GAPNLIHKHLP
		{
			[Cpp2IlInjected.Token(Token = "0x600003F")]
			[Cpp2IlInjected.Address(RVA = "0x7D4B8E0", Offset = "0x7D4AAE0", VA = "0x187D4B8E0")]
			get
			{
				return default(Vector3);
			}
			[Cpp2IlInjected.Token(Token = "0x6000040")]
			[Cpp2IlInjected.Address(RVA = "0x7D4CE20", Offset = "0x7D4C020", VA = "0x187D4CE20")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001B")]
		public Vector3 CKDJOLBFNOG
		{
			[Cpp2IlInjected.Token(Token = "0x6000041")]
			[Cpp2IlInjected.Address(RVA = "0x7D4C250", Offset = "0x7D4B450", VA = "0x187D4C250")]
			get
			{
				return default(Vector3);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001C")]
		public CollisionDetectionMode DLMEKHMKMJL
		{
			[Cpp2IlInjected.Token(Token = "0x6000042")]
			[Cpp2IlInjected.Address(RVA = "0x7D4B470", Offset = "0x7D4A670", VA = "0x187D4B470")]
			get
			{
				return default(CollisionDetectionMode);
			}
			[Cpp2IlInjected.Token(Token = "0x6000043")]
			[Cpp2IlInjected.Address(RVA = "0x7D4CBF0", Offset = "0x7D4BDF0", VA = "0x187D4CBF0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001D")]
		public float NBJCJLCNJOA
		{
			[Cpp2IlInjected.Token(Token = "0x6000044")]
			[Cpp2IlInjected.Address(RVA = "0x7D4AEA0", Offset = "0x7D4A0A0", VA = "0x187D4AEA0")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x6000045")]
			[Cpp2IlInjected.Address(RVA = "0x7D4C950", Offset = "0x7D4BB50", VA = "0x187D4C950")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001E")]
		public RigidbodyConstraints PNGJLDCFDLM
		{
			[Cpp2IlInjected.Token(Token = "0x6000046")]
			[Cpp2IlInjected.Address(RVA = "0x7D4B4D0", Offset = "0x7D4A6D0", VA = "0x187D4B4D0")]
			get
			{
				return default(RigidbodyConstraints);
			}
			[Cpp2IlInjected.Token(Token = "0x6000047")]
			[Cpp2IlInjected.Address(RVA = "0x7D4CC60", Offset = "0x7D4BE60", VA = "0x187D4CC60")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001F")]
		public Vector3 KGKHEFONHED
		{
			[Cpp2IlInjected.Token(Token = "0x6000048")]
			[Cpp2IlInjected.Address(RVA = "0x7D4BC80", Offset = "0x7D4AE80", VA = "0x187D4BC80")]
			get
			{
				return default(Vector3);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000020")]
		public Vector3 PPFOOJPKCND
		{
			[Cpp2IlInjected.Token(Token = "0x6000049")]
			[Cpp2IlInjected.Address(RVA = "0x7D4BC80", Offset = "0x7D4AE80", VA = "0x187D4BC80")]
			get
			{
				return default(Vector3);
			}
			[Cpp2IlInjected.Token(Token = "0x600004A")]
			[Cpp2IlInjected.Address(RVA = "0x7D4D3E0", Offset = "0x7D4C5E0", VA = "0x187D4D3E0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000021")]
		public float IKKLIBHMPKI
		{
			[Cpp2IlInjected.Token(Token = "0x600004B")]
			[Cpp2IlInjected.Address(RVA = "0x7D4B9C0", Offset = "0x7D4ABC0", VA = "0x187D4B9C0")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x600004C")]
			[Cpp2IlInjected.Address(RVA = "0x7D4CF00", Offset = "0x7D4C100", VA = "0x187D4CF00")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000022")]
		public float KPEBDFOIABO
		{
			[Cpp2IlInjected.Token(Token = "0x600004D")]
			[Cpp2IlInjected.Address(RVA = "0x7D4C0B0", Offset = "0x7D4B2B0", VA = "0x187D4C0B0")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x600004E")]
			[Cpp2IlInjected.Address(RVA = "0x7D4D590", Offset = "0x7D4C790", VA = "0x187D4D590")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000023")]
		public Quaternion NJHOHNCIKIF
		{
			[Cpp2IlInjected.Token(Token = "0x600004F")]
			[Cpp2IlInjected.Address(RVA = "0x7D4BD60", Offset = "0x7D4AF60", VA = "0x187D4BD60")]
			get
			{
				return default(Quaternion);
			}
			[Cpp2IlInjected.Token(Token = "0x6000050")]
			[Cpp2IlInjected.Address(RVA = "0x7D4D160", Offset = "0x7D4C360", VA = "0x187D4D160")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000024")]
		public Quaternion JKJGPLJFONK
		{
			[Cpp2IlInjected.Token(Token = "0x6000051")]
			[Cpp2IlInjected.Address(RVA = "0x7D4BFE0", Offset = "0x7D4B1E0", VA = "0x187D4BFE0")]
			get
			{
				return default(Quaternion);
			}
			[Cpp2IlInjected.Token(Token = "0x6000052")]
			[Cpp2IlInjected.Address(RVA = "0x7D4D4C0", Offset = "0x7D4C6C0", VA = "0x187D4D4C0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000025")]
		public Vector3 CNCGDLGCHDG
		{
			[Cpp2IlInjected.Token(Token = "0x6000053")]
			[Cpp2IlInjected.Address(RVA = "0x7D4BE30", Offset = "0x7D4B030", VA = "0x187D4BE30")]
			get
			{
				return default(Vector3);
			}
			[Cpp2IlInjected.Token(Token = "0x6000054")]
			[Cpp2IlInjected.Address(RVA = "0x7D4D230", Offset = "0x7D4C430", VA = "0x187D4D230")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000026")]
		public Quaternion NEADPOLHNOM
		{
			[Cpp2IlInjected.Token(Token = "0x6000055")]
			[Cpp2IlInjected.Address(RVA = "0x7D4BF10", Offset = "0x7D4B110", VA = "0x187D4BF10")]
			get
			{
				return default(Quaternion);
			}
			[Cpp2IlInjected.Token(Token = "0x6000056")]
			[Cpp2IlInjected.Address(RVA = "0x7D4D310", Offset = "0x7D4C510", VA = "0x187D4D310")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000027")]
		public Vector3 DMAMLJEEFCB
		{
			[Cpp2IlInjected.Token(Token = "0x6000057")]
			[Cpp2IlInjected.Address(RVA = "0x7D4C170", Offset = "0x7D4B370", VA = "0x187D4C170")]
			get
			{
				return default(Vector3);
			}
			[Cpp2IlInjected.Token(Token = "0x6000058")]
			[Cpp2IlInjected.Address(RVA = "0x7D4D670", Offset = "0x7D4C870", VA = "0x187D4D670")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000028")]
		public Vector3 BFOLNOABHKB
		{
			[Cpp2IlInjected.Token(Token = "0x6000059")]
			[Cpp2IlInjected.Address(RVA = "0x7D4BA20", Offset = "0x7D4AC20", VA = "0x187D4BA20")]
			get
			{
				return default(Vector3);
			}
			[Cpp2IlInjected.Token(Token = "0x600005A")]
			[Cpp2IlInjected.Address(RVA = "0x7D4CF70", Offset = "0x7D4C170", VA = "0x187D4CF70")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000029")]
		public Vector3 KPBNIKDIOKJ
		{
			[Cpp2IlInjected.Token(Token = "0x600005B")]
			[Cpp2IlInjected.Address(RVA = "0x7D4B390", Offset = "0x7D4A590", VA = "0x187D4B390")]
			get
			{
				return default(Vector3);
			}
			[Cpp2IlInjected.Token(Token = "0x600005C")]
			[Cpp2IlInjected.Address(RVA = "0x7D4CB10", Offset = "0x7D4BD10", VA = "0x187D4CB10")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002A")]
		public Vector3 GGKILDCFAHO
		{
			[Cpp2IlInjected.Token(Token = "0x600005D")]
			[Cpp2IlInjected.Address(RVA = "0x7D4B800", Offset = "0x7D4AA00", VA = "0x187D4B800")]
			get
			{
				return default(Vector3);
			}
			[Cpp2IlInjected.Token(Token = "0x600005E")]
			[Cpp2IlInjected.Address(RVA = "0x7D4CD40", Offset = "0x7D4BF40", VA = "0x187D4CD40")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002B")]
		public Vector3 JJJBLBAHNIE
		{
			[Cpp2IlInjected.Token(Token = "0x600005F")]
			[Cpp2IlInjected.Address(RVA = "0x7D4B6C0", Offset = "0x7D4A8C0", VA = "0x187D4B6C0")]
			get
			{
				return default(Vector3);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002C")]
		public Quaternion LLJKIMDELJD
		{
			[Cpp2IlInjected.Token(Token = "0x6000060")]
			[Cpp2IlInjected.Address(RVA = "0x7D4B5F0", Offset = "0x7D4A7F0", VA = "0x187D4B5F0")]
			get
			{
				return default(Quaternion);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002D")]
		public Vector3 BCFLGMKNCBA
		{
			[Cpp2IlInjected.Token(Token = "0x6000062")]
			[Cpp2IlInjected.Address(RVA = "0x7D4C410", Offset = "0x7D4B610", VA = "0x187D4C410")]
			get
			{
				return default(Vector3);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002E")]
		public Vector3 FACBDGNBPJM
		{
			[Cpp2IlInjected.Token(Token = "0x6000063")]
			[Cpp2IlInjected.Address(RVA = "0x7D4C330", Offset = "0x7D4B530", VA = "0x187D4C330")]
			get
			{
				return default(Vector3);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002F")]
		public bool ICCHEKBPFEH
		{
			[Cpp2IlInjected.Token(Token = "0x6000064")]
			[Cpp2IlInjected.Address(RVA = "0x7D4B7A0", Offset = "0x7D4A9A0", VA = "0x187D4B7A0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000030")]
		public bool AAOCALBJHGO
		{
			[Cpp2IlInjected.Token(Token = "0x6000065")]
			[Cpp2IlInjected.Address(RVA = "0x7D4B270", Offset = "0x7D4A470", VA = "0x187D4B270")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000031")]
		public bool LMIFKMAOKFO
		{
			[Cpp2IlInjected.Token(Token = "0x6000066")]
			[Cpp2IlInjected.Address(RVA = "0x7D4AD80", Offset = "0x7D49F80", VA = "0x187D4AD80")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000032")]
		public bool AOMALKBHLKP
		{
			[Cpp2IlInjected.Token(Token = "0x6000067")]
			[Cpp2IlInjected.Address(RVA = "0x7D4AD20", Offset = "0x7D49F20", VA = "0x187D4AD20")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000033")]
		public bool AEGJCCDGFDO
		{
			[Cpp2IlInjected.Token(Token = "0x6000068")]
			[Cpp2IlInjected.Address(RVA = "0x7D4AC00", Offset = "0x7D49E00", VA = "0x187D4AC00")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000034")]
		public bool JFLHLJOHCPG
		{
			[Cpp2IlInjected.Token(Token = "0x6000069")]
			[Cpp2IlInjected.Address(RVA = "0x7D4B590", Offset = "0x7D4A790", VA = "0x187D4B590")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000035")]
		public bool OBBODMNOFFK
		{
			[Cpp2IlInjected.Token(Token = "0x600006A")]
			[Cpp2IlInjected.Address(RVA = "0x2166F70", Offset = "0x2166170", VA = "0x182166F70")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000001")]
		public event FIIDLLPBBKB HBIBMGMNHPL
		{
			[Cpp2IlInjected.Token(Token = "0x600000E")]
			[Cpp2IlInjected.Address(RVA = "0x7D4AB20", Offset = "0x7D49D20", VA = "0x187D4AB20")]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x600000F")]
			[Cpp2IlInjected.Address(RVA = "0x7D4C790", Offset = "0x7D4B990", VA = "0x187D4C790")]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000002")]
		public event ANFIDMOOJCO FDIAOCEAMBE
		{
			[Cpp2IlInjected.Token(Token = "0x6000010")]
			[Cpp2IlInjected.Address(RVA = "0x7D4A890", Offset = "0x7D49A90", VA = "0x187D4A890")]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000011")]
			[Cpp2IlInjected.Address(RVA = "0x7D4C4F0", Offset = "0x7D4B6F0", VA = "0x187D4C4F0")]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000003")]
		public event ANFIDMOOJCO OOCMNBBKMLH
		{
			[Cpp2IlInjected.Token(Token = "0x6000012")]
			[Cpp2IlInjected.Address(RVA = "0x7D4A8F0", Offset = "0x7D49AF0", VA = "0x187D4A8F0")]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000013")]
			[Cpp2IlInjected.Address(RVA = "0x7D4C560", Offset = "0x7D4B760", VA = "0x187D4C560")]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000004")]
		public event ANFIDMOOJCO KKJNNGOFBNO
		{
			[Cpp2IlInjected.Token(Token = "0x6000014")]
			[Cpp2IlInjected.Address(RVA = "0x7D4AA40", Offset = "0x7D49C40", VA = "0x187D4AA40")]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000015")]
			[Cpp2IlInjected.Address(RVA = "0x7D4C6B0", Offset = "0x7D4B8B0", VA = "0x187D4C6B0")]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000005")]
		public event Action<OJGJEEMDGCF, OJGJEEMDGCF> DJHFCDIFLGM
		{
			[Cpp2IlInjected.Token(Token = "0x6000016")]
			[Cpp2IlInjected.Address(RVA = "0x7D4A9D0", Offset = "0x7D49BD0", VA = "0x187D4A9D0")]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000017")]
			[Cpp2IlInjected.Address(RVA = "0x7D4C640", Offset = "0x7D4B840", VA = "0x187D4C640")]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000006")]
		public event ANFIDMOOJCO KAGFFJIDOCL
		{
			[Cpp2IlInjected.Token(Token = "0x6000018")]
			[Cpp2IlInjected.Address(RVA = "0x7D4AAB0", Offset = "0x7D49CB0", VA = "0x187D4AAB0")]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000019")]
			[Cpp2IlInjected.Address(RVA = "0x7D4C720", Offset = "0x7D4B920", VA = "0x187D4C720")]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000007")]
		public event ANFIDMOOJCO OJAHGIGOLDE
		{
			[Cpp2IlInjected.Token(Token = "0x600001A")]
			[Cpp2IlInjected.Address(RVA = "0x7D4AB90", Offset = "0x7D49D90", VA = "0x187D4AB90")]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x600001B")]
			[Cpp2IlInjected.Address(RVA = "0x7D4C800", Offset = "0x7D4BA00", VA = "0x187D4C800")]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000008")]
		public event ANFIDMOOJCO HCHGGAOBBCN
		{
			[Cpp2IlInjected.Token(Token = "0x600001C")]
			[Cpp2IlInjected.Address(RVA = "0x7D4A960", Offset = "0x7D49B60", VA = "0x187D4A960")]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x600001D")]
			[Cpp2IlInjected.Address(RVA = "0x7D4C5D0", Offset = "0x7D4B7D0", VA = "0x187D4C5D0")]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x9642B0", Offset = "0x9634B0", VA = "0x1809642B0", Slot = "8")]
		private void PHIIAPDFMLC(CKJMPDKLOMB PIJKIPKKMLF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x7D49440", Offset = "0x7D48640", VA = "0x187D49440", Slot = "9")]
		public DGPLBFHBGKJ GetData()
		{
			return default(DGPLBFHBGKJ);
		}

		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x7D498A0", Offset = "0x7D48AA0", VA = "0x187D498A0")]
		internal void NGDNJEPBJMF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x7D4A5C0", Offset = "0x7D497C0", VA = "0x187D4A5C0")]
		[Conditional("DEBUG_BUILD")]
		[Conditional("UNITY_EDITOR")]
		public void TestOverrideUnityRigidbody(Rigidbody KNCAMCKBICI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x7D49190", Offset = "0x7D48390", VA = "0x187D49190")]
		public KCAMGMHDEDF GetChild(int KOOLKCPAFBB)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000061")]
		[Cpp2IlInjected.Address(RVA = "0x7D4A220", Offset = "0x7D49420", VA = "0x187D4A220")]
		public void SetInertiaTensor((Quaternion rot, Vector3 moments) KHCHKJFGKPL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006B")]
		[Cpp2IlInjected.Address(RVA = "0x7D48C50", Offset = "0x7D47E50", VA = "0x187D48C50")]
		private void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006C")]
		[Cpp2IlInjected.Address(RVA = "0x7D4A4B0", Offset = "0x7D496B0", VA = "0x187D4A4B0")]
		protected void Start()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006D")]
		[Cpp2IlInjected.Address(RVA = "0x7D48190", Offset = "0x7D47390", VA = "0x187D48190")]
		private CKJMPDKLOMB HPJPKEHGMAJ()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600006E")]
		[Cpp2IlInjected.Address(RVA = "0x7D49000", Offset = "0x7D48200", VA = "0x187D49000")]
		private void EMBIHAFPMPJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006F")]
		[Cpp2IlInjected.Address(RVA = "0x7D499F0", Offset = "0x7D48BF0", VA = "0x187D499F0")]
		private void OnEnable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000070")]
		[Cpp2IlInjected.Address(RVA = "0x7D49930", Offset = "0x7D48B30", VA = "0x187D49930")]
		public void OnDisable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000071")]
		[Cpp2IlInjected.Address(RVA = "0x7D498A0", Offset = "0x7D48AA0", VA = "0x187D498A0")]
		private void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000072")]
		[Cpp2IlInjected.Address(RVA = "0x7D49990", Offset = "0x7D48B90", VA = "0x187D49990")]
		private void OnDrawGizmosSelected()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000073")]
		[Cpp2IlInjected.Address(RVA = "0x7D49A50", Offset = "0x7D48C50", VA = "0x187D49A50")]
		private void OnValidate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000074")]
		[Cpp2IlInjected.Address(RVA = "0x7D48240", Offset = "0x7D47440", VA = "0x187D48240")]
		public void AddDoNotResetVelocityOnOwnershipChangeOverride(object GIIKHLJPAKH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000075")]
		[Cpp2IlInjected.Address(RVA = "0x7D49AB0", Offset = "0x7D48CB0", VA = "0x187D49AB0")]
		public void RemoveDoNotResetVelocityOnOwnershipChangeOverride(object GIIKHLJPAKH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000076")]
		[Cpp2IlInjected.Address(RVA = "0x7D48FA0", Offset = "0x7D481A0", VA = "0x187D48FA0")]
		public void DisableCachedInertialPropertyOverride()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000077")]
		[Cpp2IlInjected.Address(RVA = "0x7D49840", Offset = "0x7D48A40", VA = "0x187D49840")]
		public void MarkCachedInertialParametersDirty()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000078")]
		[Cpp2IlInjected.Address(RVA = "0x7D4A380", Offset = "0x7D49580", VA = "0x187D4A380")]
		public void SetParent(RigidbodyEx OMFJNFBDJCA, bool IEBFLJEOPJP = false)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000079")]
		[Cpp2IlInjected.Address(RVA = "0x7D49DC0", Offset = "0x7D48FC0", VA = "0x187D49DC0")]
		public void ResetLocalCenterOfMassToPrefabDefault()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007A")]
		[Cpp2IlInjected.Address(RVA = "0x7D494D0", Offset = "0x7D486D0", VA = "0x187D494D0")]
		public bool IsRigidbodyAncestor(RigidbodyEx AIGHPDBLLME)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600007B")]
		[Cpp2IlInjected.Address(RVA = "0x7D495D0", Offset = "0x7D487D0", VA = "0x187D495D0")]
		public bool IsRigidbodyDescendant(RigidbodyEx PLLBFPIPMLE)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600007C")]
		[Cpp2IlInjected.Address(RVA = "0x7D484B0", Offset = "0x7D476B0", VA = "0x187D484B0")]
		public void AddInterpolationRestriction(object GIIKHLJPAKH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007D")]
		[Cpp2IlInjected.Address(RVA = "0x7D49B20", Offset = "0x7D48D20", VA = "0x187D49B20")]
		public void RemoveInterpolationRestriction(object GIIKHLJPAKH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007E")]
		[Cpp2IlInjected.Address(RVA = "0x7D48520", Offset = "0x7D47720", VA = "0x187D48520")]
		public void AddKinematic(object GIIKHLJPAKH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007F")]
		[Cpp2IlInjected.Address(RVA = "0x7D49B90", Offset = "0x7D48D90", VA = "0x187D49B90")]
		public void RemoveKinematic(object GIIKHLJPAKH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000080")]
		[Cpp2IlInjected.Address(RVA = "0x7D4A300", Offset = "0x7D49500", VA = "0x187D4A300")]
		public void SetKinematic(object GIIKHLJPAKH, bool JLKOFADJBOL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000081")]
		[Cpp2IlInjected.Address(RVA = "0x7D4A120", Offset = "0x7D49320", VA = "0x187D4A120")]
		public void SetDiscontinuousPositionAndRotation(Vector3 OOFANODCEOI, Quaternion NIBKNBINJBA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000082")]
		[Cpp2IlInjected.Address(RVA = "0x7D4A020", Offset = "0x7D49220", VA = "0x187D4A020")]
		public void SetDiscontinuousLocalPositionAndLocalRotation(Vector3 OEPJNEMPDFD, Quaternion JDICBINFHHJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000083")]
		[Cpp2IlInjected.Address(RVA = "0x7D49330", Offset = "0x7D48530", VA = "0x187D49330")]
		public Vector3 GetConstrainedVelocity(Vector3 DMAMLJEEFCB)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x6000084")]
		[Cpp2IlInjected.Address(RVA = "0x7D49220", Offset = "0x7D48420", VA = "0x187D49220")]
		public Vector3 GetConstrainedAngularVelocity(Vector3 KPBNIKDIOKJ)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x6000085")]
		[Cpp2IlInjected.Address(RVA = "0x7D483C0", Offset = "0x7D475C0", VA = "0x187D483C0")]
		public void AddForce(Vector3 CPGNGBBHKKK, ForceMode FPGHJBHLKCH = ForceMode.Force)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000086")]
		[Cpp2IlInjected.Address(RVA = "0x7D482B0", Offset = "0x7D474B0", VA = "0x187D482B0")]
		public void AddForceAtPosition(Vector3 CPGNGBBHKKK, Vector3 LBPAIJGCICL, ForceMode FPGHJBHLKCH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000087")]
		[Cpp2IlInjected.Address(RVA = "0x7D486F0", Offset = "0x7D478F0", VA = "0x187D486F0")]
		public void AddTorque(Vector3 CDGJIJJBKDO, ForceMode FPGHJBHLKCH = ForceMode.Force)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000088")]
		[Cpp2IlInjected.Address(RVA = "0x7D48590", Offset = "0x7D47790", VA = "0x187D48590")]
		public void AddRelativeTorque(Vector3 CDGJIJJBKDO, ForceMode FPGHJBHLKCH = ForceMode.Force)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000089")]
		[Cpp2IlInjected.Address(RVA = "0x7D4A690", Offset = "0x7D49890", VA = "0x187D4A690")]
		public Vector3 WorldToLocalVelocity(Vector3 AAKCIEGFLNF)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x600008A")]
		[Cpp2IlInjected.Address(RVA = "0x7D49730", Offset = "0x7D48930", VA = "0x187D49730")]
		public Vector3 LocalToWorldVelocity(Vector3 BFOLNOABHKB)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x600008B")]
		[Cpp2IlInjected.Address(RVA = "0x7D48F40", Offset = "0x7D48140", VA = "0x187D48F40")]
		public void ClearVelocity()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008C")]
		[Cpp2IlInjected.Address(RVA = "0x7D48EE0", Offset = "0x7D480E0", VA = "0x187D48EE0")]
		public void ClearUnityRigidbodyVelocity()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008D")]
		[Cpp2IlInjected.Address(RVA = "0x7D48E80", Offset = "0x7D48080", VA = "0x187D48E80")]
		public void ClearLinearVelocity()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008E")]
		[Cpp2IlInjected.Address(RVA = "0x7D48E20", Offset = "0x7D48020", VA = "0x187D48E20")]
		public void ClearAngularVelocity()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008F")]
		[Cpp2IlInjected.Address(RVA = "0x7D49F20", Offset = "0x7D49120", VA = "0x187D49F20")]
		public void ResetVelocityWorldSpace(Vector3 GPBKAKMKHHM, Vector3 CJJEMCCDFKF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000090")]
		[Cpp2IlInjected.Address(RVA = "0x7D49E20", Offset = "0x7D49020", VA = "0x187D49E20")]
		public void ResetVelocityLocalSpace(Vector3 EHHEGNBIEBF, Vector3 GGKILDCFAHO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000091")]
		[Cpp2IlInjected.Address(RVA = "0x7D49CE0", Offset = "0x7D48EE0", VA = "0x187D49CE0")]
		public void ResetLinearVelocityLocalSpace(Vector3 EHHEGNBIEBF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000092")]
		[Cpp2IlInjected.Address(RVA = "0x7D4A4C0", Offset = "0x7D496C0", VA = "0x187D4A4C0")]
		public bool SweepTest(Vector3 FOKNLDGGKBN, [Out] RaycastHit AMJOELMPNMA, float DLABDKKOOMK)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000093")]
		[Cpp2IlInjected.Address(RVA = "0x7D496D0", Offset = "0x7D488D0", VA = "0x187D496D0")]
		public bool IsSleeping()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000094")]
		[Cpp2IlInjected.Address(RVA = "0x7D4A450", Offset = "0x7D49650", VA = "0x187D4A450")]
		public void Sleep()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000095")]
		[Cpp2IlInjected.Address(RVA = "0x7D4A630", Offset = "0x7D49830", VA = "0x187D4A630")]
		public void WakeUp()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000096")]
		[Cpp2IlInjected.Address(RVA = "0x7D48680", Offset = "0x7D47880", VA = "0x187D48680")]
		public void AddShouldHaveUnityRigidbodyToken(object GIIKHLJPAKH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000097")]
		[Cpp2IlInjected.Address(RVA = "0x7D49C00", Offset = "0x7D48E00", VA = "0x187D49C00")]
		public void RemoveShouldHaveUnityRigidbodyToken(object GIIKHLJPAKH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000098")]
		[Cpp2IlInjected.Address(RVA = "0x7D48A80", Offset = "0x7D47C80", VA = "0x187D48A80")]
		public void ApplyForceVelocityChange(HPMAFJLKFHL DLNHIMPFAMK, Vector3 HOBENLNNBJG, float LOFOCKIMDHE, float ECNCFDJFMHJ = 8f, float LLFECLGOEJE = 1f)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000099")]
		[Cpp2IlInjected.Address(RVA = "0x7D48980", Offset = "0x7D47B80", VA = "0x187D48980")]
		public void ApplyAngularVelocityChange(GOPIKNGHAGE GAEKIHMGGAN, Vector3 EBGAHGHEICN, float EINHNGGOAIG = float.PositiveInfinity)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009A")]
		[Cpp2IlInjected.Address(RVA = "0x7D48B40", Offset = "0x7D47D40", VA = "0x187D48B40")]
		[Obsolete("Deprecated. Still exists to support deprecated CV2 chips. Use ApplyAngularVelocityChange.")]
		public void ApplyTorqueAngularVelocityChangeDeprecated(GOPIKNGHAGE GAEKIHMGGAN, Vector3 GLMEOLPKLCA, float EAFFEBJLAEN = 7f, float GJPEDKJKDLO = 1f)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009B")]
		[Cpp2IlInjected.Address(RVA = "0x7D488B0", Offset = "0x7D47AB0", VA = "0x187D488B0")]
		public bool AllowedScaleChange(float EDDIMDPGGDG)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600009C")]
		[Cpp2IlInjected.Address(RVA = "0x7D487E0", Offset = "0x7D479E0", VA = "0x187D487E0")]
		public void AddWorldSpaceVelocityInHierarchyParentOverride(RigidbodyEx PKEHBJJEGCK, object GIIKHLJPAKH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009D")]
		[Cpp2IlInjected.Address(RVA = "0x7D49C70", Offset = "0x7D48E70", VA = "0x187D49C70")]
		public void RemoveWorldSpaceVelocityInHierarchyParentOverride(object GIIKHLJPAKH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009E")]
		[Cpp2IlInjected.Address(RVA = "0x7D49180", Offset = "0x7D48380", VA = "0x187D49180", Slot = "12")]
		private void GLPHEILPJEK(EMNJGJMKAFD IBLIOEFMDMM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009F")]
		[Cpp2IlInjected.Address(RVA = "0x7D4A820", Offset = "0x7D49A20", VA = "0x187D4A820")]
		public RigidbodyEx()
		{
		}

		[SpecialName]
		[Cpp2IlInjected.Token(Token = "0x60000A1")]
		[Cpp2IlInjected.Address(RVA = "0xABDDB0", Offset = "0xABCFB0", VA = "0x180ABDDB0", Slot = "4")]
		private GameObject IAHKNMKGAED()
		{
			return null;
		}

		[SpecialName]
		[Cpp2IlInjected.Token(Token = "0x60000A2")]
		[Cpp2IlInjected.Address(RVA = "0x98F840", Offset = "0x98EA40", VA = "0x18098F840", Slot = "10")]
		private bool CMAJBKMNFCF()
		{
			return default(bool);
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
internal static class EDBIDMOPHHL
{
	[Cpp2IlInjected.Token(Token = "0x60000A3")]
	[Cpp2IlInjected.Address(RVA = "0x7D33E00", Offset = "0x7D33000", VA = "0x187D33E00")]
	public static CKJMPDKLOMB EBNLHMCGGDN(this RigidbodyEx DNNDAOFODNI)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
[RegisterService(typeof(KKIPIEOLCEA), new string[] { })]
public class OMBOPMDCOCG : KKIPIEOLCEA, ANAKBJKCMDF
{
	[Cpp2IlInjected.Token(Token = "0x4000011")]
	private static readonly PBBCGFNIILA NPAEAIAJLAP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000012")]
	private KOEMAGOFPCA EKJOCLHFECK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000013")]
	private BDMDMKHLKIB FLBECOBBMFH;

	[Cpp2IlInjected.Token(Token = "0x17000036")]
	public KOEMAGOFPCA GMCBKFOCPJE
	{
		[Cpp2IlInjected.Token(Token = "0x60000A4")]
		[Cpp2IlInjected.Address(RVA = "0x964520", Offset = "0x963720", VA = "0x180964520", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000037")]
	public BDMDMKHLKIB LDLDFJPMHGP
	{
		[Cpp2IlInjected.Token(Token = "0x60000A5")]
		[Cpp2IlInjected.Address(RVA = "0x963A50", Offset = "0x962C50", VA = "0x180963A50", Slot = "5")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000A6")]
	[Cpp2IlInjected.Address(RVA = "0x7D453D0", Offset = "0x7D445D0", VA = "0x187D453D0", Slot = "7")]
	public void InitReferences(DBCOBCEEMIL LGCLECJNKAM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A7")]
	[Cpp2IlInjected.Address(RVA = "0x7D45440", Offset = "0x7D44640", VA = "0x187D45440", Slot = "6")]
	public CKJMPDKLOMB PGGDMDPBMHO(RigidbodyEx DNNDAOFODNI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000A8")]
	[Cpp2IlInjected.Address(RVA = "0x9684B0", Offset = "0x9676B0", VA = "0x1809684B0")]
	public OMBOPMDCOCG()
	{
	}
}
namespace RecRoom
{
	[Cpp2IlInjected.Token(Token = "0x2000007")]
	public class PhysicsManager : SingletonMonoBehaviour<PhysicsManager>
	{
		[Cpp2IlInjected.Token(Token = "0x4000014")]
		public static MIOEGIOIKAG UpdateAfterFixedUpdateRan;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000015")]
		private int KMBFOMEJIKK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x4000016")]
		private int KLPMNBPMENO;

		[Cpp2IlInjected.Token(Token = "0x60000AA")]
		[Cpp2IlInjected.Address(RVA = "0x7D48010", Offset = "0x7D47210", VA = "0x187D48010")]
		protected void FixedUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AB")]
		[Cpp2IlInjected.Address(RVA = "0x7D48050", Offset = "0x7D47250", VA = "0x187D48050")]
		protected void Update()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AC")]
		[Cpp2IlInjected.Address(RVA = "0x7D48030", Offset = "0x7D47230", VA = "0x187D48030")]
		protected void LateUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AD")]
		[Cpp2IlInjected.Address(RVA = "0x962E00", Offset = "0x962000", VA = "0x180962E00")]
		[Conditional("UNITY_ASSERTIONS")]
		public void AssertLateColliderPositionsNotYetUpdated([Optional] string DCEACFEGBDC, [Optional] UnityEngine.Object IBLIOEFMDMM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AE")]
		[Cpp2IlInjected.Address(RVA = "0x962E00", Offset = "0x962000", VA = "0x180962E00")]
		[Conditional("UNITY_ASSERTIONS")]
		public void AssertLateColliderPositionsAlreadyUpdated([Optional] string DCEACFEGBDC, [Optional] UnityEngine.Object IBLIOEFMDMM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AF")]
		[Cpp2IlInjected.Address(RVA = "0x7D48140", Offset = "0x7D47340", VA = "0x187D48140")]
		public PhysicsManager()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
public static class ENLACLIBJBK
{
	[Cpp2IlInjected.Token(Token = "0x2000009")]
	private class ENIEEKDCPII : BFHLICCPHMB, IDisposable
	{
		[Cpp2IlInjected.Token(Token = "0x60000B3")]
		[Cpp2IlInjected.Address(RVA = "0x962E00", Offset = "0x962000", VA = "0x180962E00", Slot = "7")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B4")]
		[Cpp2IlInjected.Address(RVA = "0x9729E0", Offset = "0x971BE0", VA = "0x1809729E0", Slot = "4")]
		public Vector3 ADMOKOPLCMI()
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x60000B5")]
		[Cpp2IlInjected.Address(RVA = "0x9729E0", Offset = "0x971BE0", VA = "0x1809729E0", Slot = "5")]
		public Vector3 DJCLAOEEIOL()
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x60000B6")]
		[Cpp2IlInjected.Address(RVA = "0x97D6F0", Offset = "0x97C8F0", VA = "0x18097D6F0", Slot = "6")]
		public bool JEAIDBJOIGL(float FFENJGIDLPD, float EAGKBECDIJH)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000B7")]
		[Cpp2IlInjected.Address(RVA = "0x9684B0", Offset = "0x9676B0", VA = "0x1809684B0")]
		public ENIEEKDCPII()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000038")]
	public static BFHLICCPHMB EOFPFMOAEDO
	{
		[Cpp2IlInjected.Token(Token = "0x60000B1")]
		[Cpp2IlInjected.Address(RVA = "0x7D33E70", Offset = "0x7D33070", VA = "0x187D33E70")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
public interface OEFJJJDHJFE
{
	[Cpp2IlInjected.Token(Token = "0x17000039")]
	CollisionDetectionMode NODGPJHFHCP
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
	void FDAGCHPOHKC();

	[Cpp2IlInjected.Token(Token = "0x60000BB")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void GIKCBOGPGEG(bool ICCHEKBPFEH);

	[Cpp2IlInjected.Token(Token = "0x60000BC")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void MBAKMCGMLMJ(bool ICCHEKBPFEH);

	[Cpp2IlInjected.Token(Token = "0x60000BD")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void BLMKHJFKJDL(Rigidbody BACLJFFEIHG);

	[Cpp2IlInjected.Token(Token = "0x60000BE")]
	[Cpp2IlInjected.Address(Slot = "6")]
	bool NBGPIKGAPJE(Vector3 FOKNLDGGKBN, [Out] RaycastHit AMJOELMPNMA, float DLABDKKOOMK);
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
public interface GDPPJEENGFK : IDisposable, EALHLPODMHD
{
	[Cpp2IlInjected.Token(Token = "0x1700003A")]
	DFMIAGBKIML FOPOMNMNGMP
	{
		[Cpp2IlInjected.Token(Token = "0x60000C1")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
		[Cpp2IlInjected.Token(Token = "0x60000C2")]
		[Cpp2IlInjected.Address(Slot = "3")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x14000009")]
	event Action<OJGJEEMDGCF, OJGJEEMDGCF> DJHFCDIFLGM;

	[Cpp2IlInjected.Token(Token = "0x60000C3")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void FDAGCHPOHKC();
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
[ServiceLifetime(Lifetime.Application)]
public interface BDMDMKHLKIB
{
	[Cpp2IlInjected.Token(Token = "0x60000C4")]
	[Cpp2IlInjected.Address(Slot = "0")]
	BIEIDLPCNCD CFLFMNPENIO(CKJMPDKLOMB PIJKIPKKMLF);

	[Cpp2IlInjected.Token(Token = "0x60000C5")]
	[Cpp2IlInjected.Address(Slot = "1")]
	IGMBHHEALAJ FGHNOBFBJLI(CKJMPDKLOMB PIJKIPKKMLF);

	[Cpp2IlInjected.Token(Token = "0x60000C6")]
	[Cpp2IlInjected.Address(Slot = "2")]
	OIOMDMFGGKD AADJDFHLHJJ(CKJMPDKLOMB PIJKIPKKMLF);

	[Cpp2IlInjected.Token(Token = "0x60000C7")]
	[Cpp2IlInjected.Address(Slot = "3")]
	ADHJHKNEOEF NDNONMCLDOI(CKJMPDKLOMB PIJKIPKKMLF);

	[Cpp2IlInjected.Token(Token = "0x60000C8")]
	[Cpp2IlInjected.Address(Slot = "4")]
	BPMNKEMAIHH EHCDODEHIPI(CKJMPDKLOMB PIJKIPKKMLF);

	[Cpp2IlInjected.Token(Token = "0x60000C9")]
	[Cpp2IlInjected.Address(Slot = "5")]
	GDPPJEENGFK MEGNGFDLNNB(CKJMPDKLOMB PIJKIPKKMLF);

	[Cpp2IlInjected.Token(Token = "0x60000CA")]
	[Cpp2IlInjected.Address(Slot = "6")]
	JFEOOGHCIHI IIPLFJOCAGL(CKJMPDKLOMB PIJKIPKKMLF);

	[Cpp2IlInjected.Token(Token = "0x60000CB")]
	[Cpp2IlInjected.Address(Slot = "7")]
	OGJJKEJPFIP OGDGGAHKFGB(CKJMPDKLOMB PIJKIPKKMLF);

	[Cpp2IlInjected.Token(Token = "0x60000CC")]
	[Cpp2IlInjected.Address(Slot = "8")]
	OEFJJJDHJFE OHIILNKFCCE(CKJMPDKLOMB PIJKIPKKMLF);

	[Cpp2IlInjected.Token(Token = "0x60000CD")]
	[Cpp2IlInjected.Address(Slot = "9")]
	HKNNGBMEMFN PLDADPEGIFF(CKJMPDKLOMB PIJKIPKKMLF);

	[Cpp2IlInjected.Token(Token = "0x60000CE")]
	[Cpp2IlInjected.Address(Slot = "10")]
	EJHGNIPCIFI PNOEEEOLKHC(CKJMPDKLOMB PIJKIPKKMLF, [In] DGPLBFHBGKJ LJELDKAOCJM);

	[Cpp2IlInjected.Token(Token = "0x60000CF")]
	[Cpp2IlInjected.Address(Slot = "11")]
	POLKOCNOBCL PCOCDOHEONG(CKJMPDKLOMB PIJKIPKKMLF, [In] DGPLBFHBGKJ LJELDKAOCJM);

	[Cpp2IlInjected.Token(Token = "0x60000D0")]
	[Cpp2IlInjected.Address(Slot = "12")]
	IBFNAGNBCEC FAEBKHPJIIF(CKJMPDKLOMB PIJKIPKKMLF, [In] DGPLBFHBGKJ LJELDKAOCJM);

	[Cpp2IlInjected.Token(Token = "0x60000D1")]
	[Cpp2IlInjected.Address(Slot = "13")]
	HMAJPKCIBPJ KLPBHOPAGDP(CKJMPDKLOMB PIJKIPKKMLF, [In] DGPLBFHBGKJ LJELDKAOCJM);

	[Cpp2IlInjected.Token(Token = "0x60000D2")]
	[Cpp2IlInjected.Address(Slot = "14")]
	GEMAAJCHLNE PKAPACLHDLN(CKJMPDKLOMB PIJKIPKKMLF, [In] DGPLBFHBGKJ LJELDKAOCJM);

	[Cpp2IlInjected.Token(Token = "0x60000D3")]
	[Cpp2IlInjected.Address(Slot = "15")]
	CKJMPDKLOMB PGGDMDPBMHO(RigidbodyEx DNNDAOFODNI, DGPLBFHBGKJ LJELDKAOCJM, KKIPIEOLCEA CKLPHBNMNHA);
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
public interface OGJJKEJPFIP
{
	[Cpp2IlInjected.Token(Token = "0x60000D4")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void NJGGIBIFFNJ(Vector3 CPGNGBBHKKK, ForceMode FPGHJBHLKCH = ForceMode.Force);

	[Cpp2IlInjected.Token(Token = "0x60000D5")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void NPDHFCDBCLK(Vector3 CPGNGBBHKKK, Vector3 LBPAIJGCICL, ForceMode FPGHJBHLKCH);

	[Cpp2IlInjected.Token(Token = "0x60000D6")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void DHAMHFKOCDP(Vector3 CDGJIJJBKDO, ForceMode FPGHJBHLKCH = ForceMode.Force);

	[Cpp2IlInjected.Token(Token = "0x60000D7")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void AHGNCJAHBHK(Vector3 CDGJIJJBKDO, ForceMode FPGHJBHLKCH = ForceMode.Force);
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
public interface HKNNGBMEMFN
{
	[Cpp2IlInjected.Token(Token = "0x1700003B")]
	bool NEJMOBEANOE
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
	void BLMKHJFKJDL(Rigidbody BACLJFFEIHG);

	[Cpp2IlInjected.Token(Token = "0x60000DB")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void EFMMJPIOIHC(Rigidbody BACLJFFEIHG);
}
[Cpp2IlInjected.Token(Token = "0x200000F")]
public interface BIEIDLPCNCD : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x1700003C")]
	IReadOnlyList<CKJMPDKLOMB> FALOJGLJHKJ
	{
		[Cpp2IlInjected.Token(Token = "0x60000EE")]
		[Cpp2IlInjected.Address(Slot = "18")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700003D")]
	CKJMPDKLOMB GMOCPPMLGKK
	{
		[Cpp2IlInjected.Token(Token = "0x60000EF")]
		[Cpp2IlInjected.Address(Slot = "19")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700003E")]
	CKJMPDKLOMB JCHDMDCGBIH
	{
		[Cpp2IlInjected.Token(Token = "0x60000F0")]
		[Cpp2IlInjected.Address(Slot = "20")]
		get;
		[Cpp2IlInjected.Token(Token = "0x60000F1")]
		[Cpp2IlInjected.Address(Slot = "21")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x1400000A")]
	event ANFIDMOOJCO FDIAOCEAMBE;

	[Cpp2IlInjected.Token(Token = "0x1400000B")]
	event ANFIDMOOJCO OOCMNBBKMLH;

	[Cpp2IlInjected.Token(Token = "0x1400000C")]
	event FIIDLLPBBKB KPLNNKLAKFG;

	[Cpp2IlInjected.Token(Token = "0x1400000D")]
	event Action KMDFMCJOGBC;

	[Cpp2IlInjected.Token(Token = "0x1400000E")]
	event Action EMFNNCGCEPI;

	[Cpp2IlInjected.Token(Token = "0x1400000F")]
	event Action<CKJMPDKLOMB> EIKLDMEOLAG;

	[Cpp2IlInjected.Token(Token = "0x14000010")]
	event Action<CKJMPDKLOMB> EBNPIMMJMBB;

	[Cpp2IlInjected.Token(Token = "0x14000011")]
	event Action PGNAOPBKEJL;

	[Cpp2IlInjected.Token(Token = "0x14000012")]
	event Action<CKJMPDKLOMB> EEGKIOLBDEJ;

	[Cpp2IlInjected.Token(Token = "0x60000F2")]
	[Cpp2IlInjected.Address(Slot = "22")]
	void JGMGHHENICE(CKJMPDKLOMB NAAOBFPOHHG, bool IEBFLJEOPJP = false);
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
public interface OIOMDMFGGKD
{
	[Cpp2IlInjected.Token(Token = "0x1700003F")]
	Vector3 NGONCLLCEOD
	{
		[Cpp2IlInjected.Token(Token = "0x60000F3")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000040")]
	Vector3 HFAAGKLHHCE
	{
		[Cpp2IlInjected.Token(Token = "0x60000F4")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x60000F5")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void KOFJKFHKDDB(CKJMPDKLOMB JNGEIJHHFEP, object GIIKHLJPAKH);

	[Cpp2IlInjected.Token(Token = "0x60000F6")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void PAEDECCCJGM(object GIIKHLJPAKH);
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
public interface HMAJPKCIBPJ
{
	[Cpp2IlInjected.Token(Token = "0x17000041")]
	Vector3 NEOCHLLLADD
	{
		[Cpp2IlInjected.Token(Token = "0x60000F9")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
		[Cpp2IlInjected.Token(Token = "0x60000FA")]
		[Cpp2IlInjected.Address(Slot = "3")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000042")]
	Vector3 LFCBHFAIPLK
	{
		[Cpp2IlInjected.Token(Token = "0x60000FB")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000043")]
	float GCKJPMGDNLH
	{
		[Cpp2IlInjected.Token(Token = "0x60000FC")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000044")]
	float IFIJBNAHOEN
	{
		[Cpp2IlInjected.Token(Token = "0x60000FD")]
		[Cpp2IlInjected.Address(Slot = "6")]
		get;
		[Cpp2IlInjected.Token(Token = "0x60000FE")]
		[Cpp2IlInjected.Address(Slot = "7")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000045")]
	Vector3 JNJDCEPOOMF
	{
		[Cpp2IlInjected.Token(Token = "0x60000FF")]
		[Cpp2IlInjected.Address(Slot = "8")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000046")]
	Quaternion LMFNPKFPCOA
	{
		[Cpp2IlInjected.Token(Token = "0x6000100")]
		[Cpp2IlInjected.Address(Slot = "9")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x14000013")]
	event ANFIDMOOJCO MDAOGBIGIGC;

	[Cpp2IlInjected.Token(Token = "0x6000101")]
	[Cpp2IlInjected.Address(Slot = "10")]
	void FHGDKLHKFOG((Quaternion rot, Vector3 moments) KHCHKJFGKPL);

	[Cpp2IlInjected.Token(Token = "0x6000102")]
	[Cpp2IlInjected.Address(Slot = "11")]
	void JBKLOLOHMPC();

	[Cpp2IlInjected.Token(Token = "0x6000103")]
	[Cpp2IlInjected.Address(Slot = "12")]
	void NGJLEKLJCAB();

	[Cpp2IlInjected.Token(Token = "0x6000104")]
	[Cpp2IlInjected.Address(Slot = "13")]
	void LIODDGOFGOM();

	[Cpp2IlInjected.Token(Token = "0x6000105")]
	[Cpp2IlInjected.Address(Slot = "14")]
	void BLMKHJFKJDL(Rigidbody BACLJFFEIHG);

	[Cpp2IlInjected.Token(Token = "0x6000106")]
	[Cpp2IlInjected.Address(Slot = "15")]
	void EFMMJPIOIHC(Rigidbody BACLJFFEIHG);

	[Cpp2IlInjected.Token(Token = "0x6000107")]
	[Cpp2IlInjected.Address(Slot = "16")]
	void NIDFGLAOFPL();
}
[Cpp2IlInjected.Token(Token = "0x2000012")]
public interface IBFNAGNBCEC
{
	[Cpp2IlInjected.Token(Token = "0x6000108")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void FDAGCHPOHKC();

	[Cpp2IlInjected.Token(Token = "0x6000109")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void KPMBEOMNOIA(object GIIKHLJPAKH);

	[Cpp2IlInjected.Token(Token = "0x600010A")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void AGCHPCIEIEC(object GIIKHLJPAKH);

	[Cpp2IlInjected.Token(Token = "0x600010B")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void KKLJEJCCIBB(CKJMPDKLOMB DNNDAOFODNI);

	[Cpp2IlInjected.Token(Token = "0x600010C")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void KEPBPBJKDHG(CKJMPDKLOMB DNNDAOFODNI);

	[Cpp2IlInjected.Token(Token = "0x600010D")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void OCLHAINEBJE();
}
[Cpp2IlInjected.Token(Token = "0x2000013")]
public interface JFEOOGHCIHI
{
	[Cpp2IlInjected.Token(Token = "0x17000047")]
	bool LKEJANPOONK
	{
		[Cpp2IlInjected.Token(Token = "0x6000110")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x14000014")]
	event ANFIDMOOJCO NEFPDKPJOAL;

	[Cpp2IlInjected.Token(Token = "0x6000111")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void FMPPAEIAHHO(object GIIKHLJPAKH);

	[Cpp2IlInjected.Token(Token = "0x6000112")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void LKIMICFGPLL(object GIIKHLJPAKH);

	[Cpp2IlInjected.Token(Token = "0x6000113")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void DLOLCHGHDEA(object GIIKHLJPAKH, bool JLKOFADJBOL);

	[Cpp2IlInjected.Token(Token = "0x6000114")]
	[Cpp2IlInjected.Address(Slot = "6")]
	void BLMKHJFKJDL(Rigidbody JOEOLIHHIPL);

	[Cpp2IlInjected.Token(Token = "0x6000115")]
	[Cpp2IlInjected.Address(Slot = "7")]
	void EFMMJPIOIHC(Rigidbody BACLJFFEIHG);
}
[Cpp2IlInjected.Token(Token = "0x2000014")]
public interface POLKOCNOBCL : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x17000048")]
	bool BLIMOKGJPKC
	{
		[Cpp2IlInjected.Token(Token = "0x6000118")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000049")]
	bool FNOOOLDGFGB
	{
		[Cpp2IlInjected.Token(Token = "0x6000119")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x14000015")]
	event ANFIDMOOJCO AIGMAFDIONK;

	[Cpp2IlInjected.Token(Token = "0x600011A")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void FDAGCHPOHKC();

	[Cpp2IlInjected.Token(Token = "0x600011B")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void JEPMDLHFCME(CKJMPDKLOMB JNGEIJHHFEP);

	[Cpp2IlInjected.Token(Token = "0x600011C")]
	[Cpp2IlInjected.Address(Slot = "6")]
	void NLAHPALAEDE(CKJMPDKLOMB JNGEIJHHFEP);
}
[Cpp2IlInjected.Token(Token = "0x2000015")]
public interface GEMAAJCHLNE
{
	[Cpp2IlInjected.Token(Token = "0x1700004A")]
	bool MFEJOIIBKHM
	{
		[Cpp2IlInjected.Token(Token = "0x600011D")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
		[Cpp2IlInjected.Token(Token = "0x600011E")]
		[Cpp2IlInjected.Address(Slot = "1")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x1700004B")]
	bool GCIONGIHOKF
	{
		[Cpp2IlInjected.Token(Token = "0x600011F")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700004C")]
	RigidbodyConstraints KCNPLOGDIDF
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
	void BLMKHJFKJDL(Rigidbody BACLJFFEIHG);

	[Cpp2IlInjected.Token(Token = "0x6000123")]
	[Cpp2IlInjected.Address(Slot = "6")]
	void EFMMJPIOIHC(Rigidbody BACLJFFEIHG);
}
[Cpp2IlInjected.Token(Token = "0x2000016")]
public interface ADHJHKNEOEF
{
	[Cpp2IlInjected.Token(Token = "0x1700004D")]
	float BAOFHKJJLLL
	{
		[Cpp2IlInjected.Token(Token = "0x6000124")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
		[Cpp2IlInjected.Token(Token = "0x6000125")]
		[Cpp2IlInjected.Address(Slot = "1")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x1700004E")]
	float PJDENCJDHGI
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
	void BLMKHJFKJDL(Rigidbody BACLJFFEIHG);

	[Cpp2IlInjected.Token(Token = "0x6000129")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void EFMMJPIOIHC(Rigidbody BACLJFFEIHG);
}
[Cpp2IlInjected.Token(Token = "0x2000017")]
public interface BPMNKEMAIHH
{
	[Cpp2IlInjected.Token(Token = "0x4000018")]
	static bool AKNNNFBPHED;

	[Cpp2IlInjected.Token(Token = "0x14000016")]
	event ANFIDMOOJCO APJENHCGJLH;

	[Cpp2IlInjected.Token(Token = "0x600012C")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void FDAGCHPOHKC();

	[Cpp2IlInjected.Token(Token = "0x600012D")]
	[Cpp2IlInjected.Address(Slot = "3")]
	bool DCDDBIEDDNG();

	[Cpp2IlInjected.Token(Token = "0x600012E")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void FHAEAPPLIDM();

	[Cpp2IlInjected.Token(Token = "0x600012F")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void AFFNBFKGAPM();

	[Cpp2IlInjected.Token(Token = "0x6000130")]
	[Cpp2IlInjected.Address(Slot = "6")]
	bool LODEJKKCAFE();

	[Cpp2IlInjected.Token(Token = "0x6000131")]
	[Cpp2IlInjected.Address(Slot = "7")]
	bool NIBLJJDOGFD();

	[Cpp2IlInjected.Token(Token = "0x6000132")]
	[Cpp2IlInjected.Address(Slot = "8")]
	void IFBEIMHGLKG(bool ENJLDNELDJJ);

	[Cpp2IlInjected.Token(Token = "0x6000133")]
	[Cpp2IlInjected.Address(Slot = "9")]
	void EDLHJIOFNMN();
}
[Cpp2IlInjected.Token(Token = "0x2000018")]
public interface EJHGNIPCIFI
{
	[Cpp2IlInjected.Token(Token = "0x1700004F")]
	Rigidbody KEAOKJKIGHN
	{
		[Cpp2IlInjected.Token(Token = "0x6000134")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000050")]
	bool APIHOHPOAGF
	{
		[Cpp2IlInjected.Token(Token = "0x6000136")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000135")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void FDAGCHPOHKC();

	[Cpp2IlInjected.Token(Token = "0x6000137")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void DEHNLJMHHPM(object GIIKHLJPAKH);

	[Cpp2IlInjected.Token(Token = "0x6000138")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void CAIPKAIMHNB(object GIIKHLJPAKH);

	[Cpp2IlInjected.Token(Token = "0x6000139")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void FILEJHDMKAE();
}
[Cpp2IlInjected.Token(Token = "0x2000019")]
public interface IGMBHHEALAJ : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x17000051")]
	BFHLICCPHMB AOEDIBNPEPP
	{
		[Cpp2IlInjected.Token(Token = "0x600013A")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
		[Cpp2IlInjected.Token(Token = "0x600013B")]
		[Cpp2IlInjected.Address(Slot = "1")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000052")]
	CBFNNFFIFKO AFFAHABPJCD
	{
		[Cpp2IlInjected.Token(Token = "0x600013C")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
		[Cpp2IlInjected.Token(Token = "0x600013D")]
		[Cpp2IlInjected.Address(Slot = "3")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000053")]
	Vector3 MGLKIJIEAAJ
	{
		[Cpp2IlInjected.Token(Token = "0x600013E")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
		[Cpp2IlInjected.Token(Token = "0x600013F")]
		[Cpp2IlInjected.Address(Slot = "5")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000054")]
	Vector3 NNMOGOHKDHI
	{
		[Cpp2IlInjected.Token(Token = "0x6000140")]
		[Cpp2IlInjected.Address(Slot = "6")]
		get;
		[Cpp2IlInjected.Token(Token = "0x6000141")]
		[Cpp2IlInjected.Address(Slot = "7")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000055")]
	Vector3 LINIIKOHKID
	{
		[Cpp2IlInjected.Token(Token = "0x6000142")]
		[Cpp2IlInjected.Address(Slot = "8")]
		get;
		[Cpp2IlInjected.Token(Token = "0x6000143")]
		[Cpp2IlInjected.Address(Slot = "9")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000056")]
	Vector3 LNPMAIDJHPD
	{
		[Cpp2IlInjected.Token(Token = "0x6000144")]
		[Cpp2IlInjected.Address(Slot = "10")]
		get;
		[Cpp2IlInjected.Token(Token = "0x6000145")]
		[Cpp2IlInjected.Address(Slot = "11")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000057")]
	float NBJCJLCNJOA
	{
		[Cpp2IlInjected.Token(Token = "0x6000146")]
		[Cpp2IlInjected.Address(Slot = "12")]
		get;
		[Cpp2IlInjected.Token(Token = "0x6000147")]
		[Cpp2IlInjected.Address(Slot = "13")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000058")]
	bool HFBNJKFPMNO
	{
		[Cpp2IlInjected.Token(Token = "0x6000148")]
		[Cpp2IlInjected.Address(Slot = "14")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000149")]
	[Cpp2IlInjected.Address(Slot = "15")]
	void FDAGCHPOHKC();

	[Cpp2IlInjected.Token(Token = "0x600014A")]
	[Cpp2IlInjected.Address(Slot = "16")]
	void PCEHOGBLKOL(object GIIKHLJPAKH);

	[Cpp2IlInjected.Token(Token = "0x600014B")]
	[Cpp2IlInjected.Address(Slot = "17")]
	void LKMPMGIBDNM(GOPIKNGHAGE GAEKIHMGGAN, Vector3 EBGAHGHEICN, float EINHNGGOAIG = float.PositiveInfinity);

	[Cpp2IlInjected.Token(Token = "0x600014C")]
	[Cpp2IlInjected.Address(Slot = "18")]
	void HKCDEAAELIK(HPMAFJLKFHL DLNHIMPFAMK, Vector3 HOBENLNNBJG, float LOFOCKIMDHE, float ECNCFDJFMHJ = 8f, float LLFECLGOEJE = 1f);

	[Cpp2IlInjected.Token(Token = "0x600014D")]
	[Cpp2IlInjected.Address(Slot = "19")]
	void OIHHHPKKKKF(GOPIKNGHAGE GAEKIHMGGAN, Vector3 GLMEOLPKLCA, float EAFFEBJLAEN = 7f, float GJPEDKJKDLO = 1f);

	[Cpp2IlInjected.Token(Token = "0x600014E")]
	[Cpp2IlInjected.Address(Slot = "20")]
	void OHIOFHIMLDG();

	[Cpp2IlInjected.Token(Token = "0x600014F")]
	[Cpp2IlInjected.Address(Slot = "21")]
	void OLKLJJKHDOH();

	[Cpp2IlInjected.Token(Token = "0x6000150")]
	[Cpp2IlInjected.Address(Slot = "22")]
	void MKAELLFKLCE();

	[Cpp2IlInjected.Token(Token = "0x6000151")]
	[Cpp2IlInjected.Address(Slot = "23")]
	void ICKLMBKHLNB();

	[Cpp2IlInjected.Token(Token = "0x6000152")]
	[Cpp2IlInjected.Address(Slot = "24")]
	void BLMKHJFKJDL(Rigidbody BACLJFFEIHG);

	[Cpp2IlInjected.Token(Token = "0x6000153")]
	[Cpp2IlInjected.Address(Slot = "25")]
	Vector3 IMKIACFAHNG(Vector3 DMAMLJEEFCB);

	[Cpp2IlInjected.Token(Token = "0x6000154")]
	[Cpp2IlInjected.Address(Slot = "26")]
	void GJBPCDOOGMP(object GIIKHLJPAKH);

	[Cpp2IlInjected.Token(Token = "0x6000155")]
	[Cpp2IlInjected.Address(Slot = "27")]
	void FNBNJEBEFOJ(Vector3 LGFGPHBEJIO);

	[Cpp2IlInjected.Token(Token = "0x6000156")]
	[Cpp2IlInjected.Address(Slot = "28")]
	void IHODMGNEJAO(Vector3 EHHEGNBIEBF, Vector3 GGKILDCFAHO);

	[Cpp2IlInjected.Token(Token = "0x6000157")]
	[Cpp2IlInjected.Address(Slot = "29")]
	void DEFHNFILHJC(Vector3 GPBKAKMKHHM, Vector3 CJJEMCCDFKF);

	[Cpp2IlInjected.Token(Token = "0x6000158")]
	[Cpp2IlInjected.Address(Slot = "30")]
	Vector3 FELFDHGKHDD(Vector3 BFOLNOABHKB);

	[Cpp2IlInjected.Token(Token = "0x6000159")]
	[Cpp2IlInjected.Address(Slot = "31")]
	Vector3 JKHBDNCKEGL(Vector3 AAKCIEGFLNF);
}
[Cpp2IlInjected.Token(Token = "0x200001A")]
[ServiceLifetime(Lifetime.Application)]
public interface KOEMAGOFPCA
{
	[Cpp2IlInjected.Token(Token = "0x17000059")]
	bool FJAGJIAHAAF
	{
		[Cpp2IlInjected.Token(Token = "0x600015A")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x600015B")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void FNGDDFLIKLI(string HHOJHACJLGI);

	[Cpp2IlInjected.Token(Token = "0x600015C")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void BLONIKNKLPF(RigidbodyEx DNNDAOFODNI, Action GJDAMJHNAPC);

	[Cpp2IlInjected.Token(Token = "0x600015D")]
	[Cpp2IlInjected.Address(Slot = "3")]
	FKOBCEMDEIN OLOLIAFFEKO(int OAAGGILDLOG);

	[Cpp2IlInjected.Token(Token = "0x600015E")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void PFEBGMGMFGM(Vector3 CKDJOLBFNOG, float NECHLLODDBO, Color JLNFDAODDKP);
}
[Cpp2IlInjected.Token(Token = "0x200001B")]
[ServiceLifetime(Lifetime.Application)]
public interface KKIPIEOLCEA
{
	[Cpp2IlInjected.Token(Token = "0x1700005A")]
	KOEMAGOFPCA GMCBKFOCPJE
	{
		[Cpp2IlInjected.Token(Token = "0x600015F")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700005B")]
	BDMDMKHLKIB LDLDFJPMHGP
	{
		[Cpp2IlInjected.Token(Token = "0x6000160")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000161")]
	[Cpp2IlInjected.Address(Slot = "2")]
	CKJMPDKLOMB PGGDMDPBMHO(RigidbodyEx DNNDAOFODNI);
}
[Cpp2IlInjected.Token(Token = "0x200001C")]
public class KAECFEIKDHO : CKJMPDKLOMB, IDisposable, KCAANEGOABE
{
	[Cpp2IlInjected.Token(Token = "0x4000019")]
	public static bool JFGFDFHLDNM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400001A")]
	internal readonly KKIPIEOLCEA CKLPHBNMNHA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400001B")]
	internal BIEIDLPCNCD PCFNMJHFPCI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400001C")]
	internal IBFNAGNBCEC LHGHGHCCIDD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400001D")]
	internal POLKOCNOBCL CPAEJDHCMHK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400001E")]
	internal IGMBHHEALAJ DMAMLJEEFCB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x400001F")]
	internal OIOMDMFGGKD BDLIEOOEHIO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000020")]
	internal HMAJPKCIBPJ CBEKMMBJBKP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000021")]
	internal ADHJHKNEOEF DPJAKDGEDFJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000022")]
	internal HKNNGBMEMFN FGHKODCMCCH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x4000023")]
	internal BPMNKEMAIHH IGOBJDNCJJF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x4000024")]
	internal GDPPJEENGFK JBMKOAKHKIM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x4000025")]
	internal JFEOOGHCIHI LMEEMFHOBCK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x4000026")]
	internal OGJJKEJPFIP CPGNGBBHKKK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
	[Cpp2IlInjected.Token(Token = "0x4000027")]
	internal GEMAAJCHLNE ECLLEMCGIMP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x4000028")]
	internal EJHGNIPCIFI BACLJFFEIHG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
	[Cpp2IlInjected.Token(Token = "0x4000029")]
	internal OEFJJJDHJFE IDJBAPFNLKJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
	[Cpp2IlInjected.Token(Token = "0x400002A")]
	internal IDisposable KBMLAOEPJGB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
	[Cpp2IlInjected.Token(Token = "0x400002B")]
	private bool FJJMADPDFFB;

	[Cpp2IlInjected.Token(Token = "0x1700005C")]
	public EOFNBBMGHCB HHLIHCNGEHC
	{
		[Cpp2IlInjected.Token(Token = "0x6000162")]
		[Cpp2IlInjected.Address(RVA = "0x962E10", Offset = "0x962010", VA = "0x180962E10", Slot = "22")]
		get
		{
			return default(EOFNBBMGHCB);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700005D")]
	public KCAMGMHDEDF EKBAMNCJMKL
	{
		[Cpp2IlInjected.Token(Token = "0x6000163")]
		[Cpp2IlInjected.Address(RVA = "0xBDB360", Offset = "0xBDA560", VA = "0x180BDB360", Slot = "24")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000164")]
		[Cpp2IlInjected.Address(RVA = "0xD5E830", Offset = "0xD5DA30", VA = "0x180D5E830")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700005E")]
	public GameObject FOFJJMEPKPD
	{
		[Cpp2IlInjected.Token(Token = "0x6000165")]
		[Cpp2IlInjected.Address(RVA = "0x969760", Offset = "0x968960", VA = "0x180969760", Slot = "25")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000166")]
		[Cpp2IlInjected.Address(RVA = "0x969740", Offset = "0x968940", VA = "0x180969740")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700005F")]
	public Transform FFFKHKBLIED
	{
		[Cpp2IlInjected.Token(Token = "0x6000167")]
		[Cpp2IlInjected.Address(RVA = "0xB13A30", Offset = "0xB12C30", VA = "0x180B13A30", Slot = "26")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000168")]
		[Cpp2IlInjected.Address(RVA = "0xD33230", Offset = "0xD32430", VA = "0x180D33230")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000060")]
	public Rigidbody KEAOKJKIGHN
	{
		[Cpp2IlInjected.Token(Token = "0x6000169")]
		[Cpp2IlInjected.Address(RVA = "0x7D38F20", Offset = "0x7D38120", VA = "0x187D38F20", Slot = "23")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000061")]
	public CKJMPDKLOMB JCHDMDCGBIH
	{
		[Cpp2IlInjected.Token(Token = "0x600017A")]
		[Cpp2IlInjected.Address(RVA = "0x7D3DA30", Offset = "0x7D3CC30", VA = "0x187D3DA30", Slot = "27")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600017B")]
		[Cpp2IlInjected.Address(RVA = "0x7D3EA60", Offset = "0x7D3DC60", VA = "0x187D3EA60", Slot = "28")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000062")]
	public int AFHKCJNFMKC
	{
		[Cpp2IlInjected.Token(Token = "0x600017C")]
		[Cpp2IlInjected.Address(RVA = "0x7D3D8E0", Offset = "0x7D3CAE0", VA = "0x187D3D8E0", Slot = "31")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000063")]
	public CKJMPDKLOMB GMOCPPMLGKK
	{
		[Cpp2IlInjected.Token(Token = "0x600017E")]
		[Cpp2IlInjected.Address(RVA = "0x7D3AD10", Offset = "0x7D39F10", VA = "0x187D3AD10", Slot = "29")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000064")]
	public bool JBNFKMDMFCO
	{
		[Cpp2IlInjected.Token(Token = "0x600017F")]
		[Cpp2IlInjected.Address(RVA = "0x7D3BE40", Offset = "0x7D3B040", VA = "0x187D3BE40", Slot = "32")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000065")]
	public bool BLIMOKGJPKC
	{
		[Cpp2IlInjected.Token(Token = "0x6000183")]
		[Cpp2IlInjected.Address(RVA = "0x7D3B980", Offset = "0x7D3AB80", VA = "0x187D3B980", Slot = "33")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000066")]
	public bool FNOOOLDGFGB
	{
		[Cpp2IlInjected.Token(Token = "0x6000184")]
		[Cpp2IlInjected.Address(RVA = "0x7D391A0", Offset = "0x7D383A0", VA = "0x187D391A0", Slot = "34")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000067")]
	public BFHLICCPHMB AOEDIBNPEPP
	{
		[Cpp2IlInjected.Token(Token = "0x6000185")]
		[Cpp2IlInjected.Address(RVA = "0x7D3E800", Offset = "0x7D3DA00", VA = "0x187D3E800", Slot = "35")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000186")]
		[Cpp2IlInjected.Address(RVA = "0x7D3BC30", Offset = "0x7D3AE30", VA = "0x187D3BC30", Slot = "36")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000068")]
	public CBFNNFFIFKO AFFAHABPJCD
	{
		[Cpp2IlInjected.Token(Token = "0x6000187")]
		[Cpp2IlInjected.Address(RVA = "0x7D3ED70", Offset = "0x7D3DF70", VA = "0x187D3ED70", Slot = "37")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000188")]
		[Cpp2IlInjected.Address(RVA = "0x7D3A870", Offset = "0x7D39A70", VA = "0x187D3A870", Slot = "38")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000069")]
	public float NBJCJLCNJOA
	{
		[Cpp2IlInjected.Token(Token = "0x6000189")]
		[Cpp2IlInjected.Address(RVA = "0x7D3BB80", Offset = "0x7D3AD80", VA = "0x187D3BB80", Slot = "39")]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x600018A")]
		[Cpp2IlInjected.Address(RVA = "0x7D3EDC0", Offset = "0x7D3DFC0", VA = "0x187D3EDC0", Slot = "40")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700006A")]
	public Vector3 NNMOGOHKDHI
	{
		[Cpp2IlInjected.Token(Token = "0x600018B")]
		[Cpp2IlInjected.Address(RVA = "0x7D3E150", Offset = "0x7D3D350", VA = "0x187D3E150", Slot = "41")]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x600018C")]
		[Cpp2IlInjected.Address(RVA = "0x7D3B840", Offset = "0x7D3AA40", VA = "0x187D3B840", Slot = "42")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700006B")]
	public Vector3 LNPMAIDJHPD
	{
		[Cpp2IlInjected.Token(Token = "0x600018D")]
		[Cpp2IlInjected.Address(RVA = "0x7D3AE10", Offset = "0x7D3A010", VA = "0x187D3AE10", Slot = "43")]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x600018E")]
		[Cpp2IlInjected.Address(RVA = "0x7D3AC30", Offset = "0x7D39E30", VA = "0x187D3AC30", Slot = "44")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700006C")]
	public Vector3 MGLKIJIEAAJ
	{
		[Cpp2IlInjected.Token(Token = "0x600018F")]
		[Cpp2IlInjected.Address(RVA = "0x7D3E290", Offset = "0x7D3D490", VA = "0x187D3E290", Slot = "45")]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x6000190")]
		[Cpp2IlInjected.Address(RVA = "0x7D3A500", Offset = "0x7D39700", VA = "0x187D3A500", Slot = "46")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700006D")]
	public Vector3 LINIIKOHKID
	{
		[Cpp2IlInjected.Token(Token = "0x6000191")]
		[Cpp2IlInjected.Address(RVA = "0x7D3D250", Offset = "0x7D3C450", VA = "0x187D3D250", Slot = "47")]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x6000192")]
		[Cpp2IlInjected.Address(RVA = "0x7D3D950", Offset = "0x7D3CB50", VA = "0x187D3D950", Slot = "48")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700006E")]
	public bool LMIFKMAOKFO
	{
		[Cpp2IlInjected.Token(Token = "0x6000193")]
		[Cpp2IlInjected.Address(RVA = "0x7D3AF50", Offset = "0x7D3A150", VA = "0x187D3AF50", Slot = "49")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700006F")]
	public bool AOMALKBHLKP
	{
		[Cpp2IlInjected.Token(Token = "0x6000194")]
		[Cpp2IlInjected.Address(RVA = "0x7D3DC60", Offset = "0x7D3CE60", VA = "0x187D3DC60", Slot = "50")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000070")]
	public bool AEGJCCDGFDO
	{
		[Cpp2IlInjected.Token(Token = "0x6000195")]
		[Cpp2IlInjected.Address(RVA = "0x7D3D170", Offset = "0x7D3C370", VA = "0x187D3D170", Slot = "51")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000071")]
	public bool HFBNJKFPMNO
	{
		[Cpp2IlInjected.Token(Token = "0x6000196")]
		[Cpp2IlInjected.Address(RVA = "0x7D3C290", Offset = "0x7D3B490", VA = "0x187D3C290", Slot = "52")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000072")]
	public Vector3 NGONCLLCEOD
	{
		[Cpp2IlInjected.Token(Token = "0x60001A7")]
		[Cpp2IlInjected.Address(RVA = "0x7D3D330", Offset = "0x7D3C530", VA = "0x187D3D330", Slot = "53")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000073")]
	public Vector3 HFAAGKLHHCE
	{
		[Cpp2IlInjected.Token(Token = "0x60001A8")]
		[Cpp2IlInjected.Address(RVA = "0x7D3B760", Offset = "0x7D3A960", VA = "0x187D3B760", Slot = "54")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000074")]
	public Vector3 NEOCHLLLADD
	{
		[Cpp2IlInjected.Token(Token = "0x60001AD")]
		[Cpp2IlInjected.Address(RVA = "0x7D39250", Offset = "0x7D38450", VA = "0x187D39250", Slot = "55")]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x60001AE")]
		[Cpp2IlInjected.Address(RVA = "0x7D39060", Offset = "0x7D38260", VA = "0x187D39060", Slot = "56")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000075")]
	public Vector3 LFCBHFAIPLK
	{
		[Cpp2IlInjected.Token(Token = "0x60001AF")]
		[Cpp2IlInjected.Address(RVA = "0x7D3EC30", Offset = "0x7D3DE30", VA = "0x187D3EC30", Slot = "57")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000076")]
	public float GCKJPMGDNLH
	{
		[Cpp2IlInjected.Token(Token = "0x60001B0")]
		[Cpp2IlInjected.Address(RVA = "0x7D3CE50", Offset = "0x7D3C050", VA = "0x187D3CE50", Slot = "58")]
		get
		{
			return default(float);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000077")]
	public float IFIJBNAHOEN
	{
		[Cpp2IlInjected.Token(Token = "0x60001B1")]
		[Cpp2IlInjected.Address(RVA = "0x7D3CC80", Offset = "0x7D3BE80", VA = "0x187D3CC80", Slot = "59")]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x60001B2")]
		[Cpp2IlInjected.Address(RVA = "0x7D3EF40", Offset = "0x7D3E140", VA = "0x187D3EF40", Slot = "60")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000078")]
	public Vector3 JNJDCEPOOMF
	{
		[Cpp2IlInjected.Token(Token = "0x60001B3")]
		[Cpp2IlInjected.Address(RVA = "0x7D3A730", Offset = "0x7D39930", VA = "0x187D3A730", Slot = "61")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000079")]
	public Quaternion LMFNPKFPCOA
	{
		[Cpp2IlInjected.Token(Token = "0x60001B4")]
		[Cpp2IlInjected.Address(RVA = "0x7D3E620", Offset = "0x7D3D820", VA = "0x187D3E620", Slot = "62")]
		get
		{
			return default(Quaternion);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700007A")]
	public float BAOFHKJJLLL
	{
		[Cpp2IlInjected.Token(Token = "0x60001B9")]
		[Cpp2IlInjected.Address(RVA = "0x7D3C5E0", Offset = "0x7D3B7E0", VA = "0x187D3C5E0", Slot = "64")]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x60001BA")]
		[Cpp2IlInjected.Address(RVA = "0x7D3C630", Offset = "0x7D3B830", VA = "0x187D3C630", Slot = "65")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700007B")]
	public float PJDENCJDHGI
	{
		[Cpp2IlInjected.Token(Token = "0x60001BB")]
		[Cpp2IlInjected.Address(RVA = "0x7D3CC30", Offset = "0x7D3BE30", VA = "0x187D3CC30", Slot = "66")]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x60001BC")]
		[Cpp2IlInjected.Address(RVA = "0x7D38EC0", Offset = "0x7D380C0", VA = "0x187D38EC0", Slot = "67")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700007C")]
	public bool NEJMOBEANOE
	{
		[Cpp2IlInjected.Token(Token = "0x60001BD")]
		[Cpp2IlInjected.Address(RVA = "0x7D3DBC0", Offset = "0x7D3CDC0", VA = "0x187D3DBC0", Slot = "68")]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x60001BE")]
		[Cpp2IlInjected.Address(RVA = "0x7D3EAC0", Offset = "0x7D3DCC0", VA = "0x187D3EAC0", Slot = "69")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700007D")]
	public DFMIAGBKIML FOPOMNMNGMP
	{
		[Cpp2IlInjected.Token(Token = "0x60001C6")]
		[Cpp2IlInjected.Address(RVA = "0x7D3D6E0", Offset = "0x7D3C8E0", VA = "0x187D3D6E0", Slot = "70")]
		get
		{
			return default(DFMIAGBKIML);
		}
		[Cpp2IlInjected.Token(Token = "0x60001C7")]
		[Cpp2IlInjected.Address(RVA = "0x7D39000", Offset = "0x7D38200", VA = "0x187D39000", Slot = "71")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700007E")]
	public bool LKEJANPOONK
	{
		[Cpp2IlInjected.Token(Token = "0x60001CA")]
		[Cpp2IlInjected.Address(RVA = "0x7D3B6B0", Offset = "0x7D3A8B0", VA = "0x187D3B6B0", Slot = "72")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700007F")]
	public Transform AEAEPMOPBOK
	{
		[Cpp2IlInjected.Token(Token = "0x60001D0")]
		[Cpp2IlInjected.Address(RVA = "0xB13A30", Offset = "0xB12C30", VA = "0x180B13A30", Slot = "73")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000080")]
	public Vector3 IDHLNMPCLLN
	{
		[Cpp2IlInjected.Token(Token = "0x60001D1")]
		[Cpp2IlInjected.Address(RVA = "0x7D3E850", Offset = "0x7D3DA50", VA = "0x187D3E850", Slot = "74")]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x60001D2")]
		[Cpp2IlInjected.Address(RVA = "0x7D3DDA0", Offset = "0x7D3CFA0", VA = "0x187D3DDA0", Slot = "75")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000081")]
	public float GBHEHIAFDPH
	{
		[Cpp2IlInjected.Token(Token = "0x60001D3")]
		[Cpp2IlInjected.Address(RVA = "0x7D3AA40", Offset = "0x7D39C40", VA = "0x187D3AA40", Slot = "76")]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x60001D4")]
		[Cpp2IlInjected.Address(RVA = "0x7D39A60", Offset = "0x7D38C60", VA = "0x187D39A60", Slot = "77")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000082")]
	public float PLIBDAPJKME
	{
		[Cpp2IlInjected.Token(Token = "0x60001D5")]
		[Cpp2IlInjected.Address(RVA = "0x7D39E50", Offset = "0x7D39050", VA = "0x187D39E50", Slot = "78")]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x60001D6")]
		[Cpp2IlInjected.Address(RVA = "0x7D3C3D0", Offset = "0x7D3B5D0", VA = "0x187D3C3D0", Slot = "79")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000083")]
	public Quaternion CGNDLMDBNDJ
	{
		[Cpp2IlInjected.Token(Token = "0x60001D7")]
		[Cpp2IlInjected.Address(RVA = "0x7D3F270", Offset = "0x7D3E470", VA = "0x187D3F270", Slot = "80")]
		get
		{
			return default(Quaternion);
		}
		[Cpp2IlInjected.Token(Token = "0x60001D8")]
		[Cpp2IlInjected.Address(RVA = "0x7D3CB50", Offset = "0x7D3BD50", VA = "0x187D3CB50", Slot = "81")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000084")]
	public Vector3 JLOEFHABMLO
	{
		[Cpp2IlInjected.Token(Token = "0x60001D9")]
		[Cpp2IlInjected.Address(RVA = "0x7D3B450", Offset = "0x7D3A650", VA = "0x187D3B450", Slot = "82")]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x60001DA")]
		[Cpp2IlInjected.Address(RVA = "0x7D3D070", Offset = "0x7D3C270", VA = "0x187D3D070", Slot = "83")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000085")]
	public Quaternion DNDIEJBKBAG
	{
		[Cpp2IlInjected.Token(Token = "0x60001DB")]
		[Cpp2IlInjected.Address(RVA = "0x7D38FC0", Offset = "0x7D381C0", VA = "0x187D38FC0", Slot = "84")]
		get
		{
			return default(Quaternion);
		}
		[Cpp2IlInjected.Token(Token = "0x60001DC")]
		[Cpp2IlInjected.Address(RVA = "0x7D3A380", Offset = "0x7D39580", VA = "0x187D3A380", Slot = "85")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000086")]
	public RigidbodyConstraints KCNPLOGDIDF
	{
		[Cpp2IlInjected.Token(Token = "0x60001E0")]
		[Cpp2IlInjected.Address(RVA = "0x7D38C60", Offset = "0x7D37E60", VA = "0x187D38C60", Slot = "86")]
		get
		{
			return default(RigidbodyConstraints);
		}
		[Cpp2IlInjected.Token(Token = "0x60001E1")]
		[Cpp2IlInjected.Address(RVA = "0x7D39F70", Offset = "0x7D39170", VA = "0x187D39F70", Slot = "87")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000087")]
	public bool MFEJOIIBKHM
	{
		[Cpp2IlInjected.Token(Token = "0x60001E2")]
		[Cpp2IlInjected.Address(RVA = "0x7D39330", Offset = "0x7D38530", VA = "0x187D39330", Slot = "88")]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x60001E3")]
		[Cpp2IlInjected.Address(RVA = "0x7D3EB20", Offset = "0x7D3DD20", VA = "0x187D3EB20", Slot = "89")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000088")]
	public CollisionDetectionMode NODGPJHFHCP
	{
		[Cpp2IlInjected.Token(Token = "0x60001EC")]
		[Cpp2IlInjected.Address(RVA = "0x7D3EFA0", Offset = "0x7D3E1A0", VA = "0x187D3EFA0", Slot = "90")]
		get
		{
			return default(CollisionDetectionMode);
		}
		[Cpp2IlInjected.Token(Token = "0x60001ED")]
		[Cpp2IlInjected.Address(RVA = "0x7D3CD20", Offset = "0x7D3BF20", VA = "0x187D3CD20", Slot = "91")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000089")]
	public bool NPKFIIPKOFH
	{
		[Cpp2IlInjected.Token(Token = "0x60001EF")]
		[Cpp2IlInjected.Address(RVA = "0x7D3DA80", Offset = "0x7D3CC80", VA = "0x187D3DA80", Slot = "141")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700008A")]
	public bool AAOCALBJHGO
	{
		[Cpp2IlInjected.Token(Token = "0x60001F0")]
		[Cpp2IlInjected.Address(RVA = "0x7D39380", Offset = "0x7D38580", VA = "0x187D39380", Slot = "92")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000017")]
	public event ANFIDMOOJCO FDIAOCEAMBE
	{
		[Cpp2IlInjected.Token(Token = "0x6000174")]
		[Cpp2IlInjected.Address(RVA = "0x7D3BBD0", Offset = "0x7D3ADD0", VA = "0x187D3BBD0", Slot = "4")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000175")]
		[Cpp2IlInjected.Address(RVA = "0x7D3B700", Offset = "0x7D3A900", VA = "0x187D3B700", Slot = "5")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000018")]
	public event ANFIDMOOJCO OOCMNBBKMLH
	{
		[Cpp2IlInjected.Token(Token = "0x6000176")]
		[Cpp2IlInjected.Address(RVA = "0x7D3EBD0", Offset = "0x7D3DDD0", VA = "0x187D3EBD0", Slot = "6")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000177")]
		[Cpp2IlInjected.Address(RVA = "0x7D3D400", Offset = "0x7D3C600", VA = "0x187D3D400", Slot = "7")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000019")]
	public event FIIDLLPBBKB KPLNNKLAKFG
	{
		[Cpp2IlInjected.Token(Token = "0x6000178")]
		[Cpp2IlInjected.Address(RVA = "0x7D3F0A0", Offset = "0x7D3E2A0", VA = "0x187D3F0A0", Slot = "18")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000179")]
		[Cpp2IlInjected.Address(RVA = "0x7D38E60", Offset = "0x7D38060", VA = "0x187D38E60", Slot = "19")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400001A")]
	public event ANFIDMOOJCO AIGMAFDIONK
	{
		[Cpp2IlInjected.Token(Token = "0x6000181")]
		[Cpp2IlInjected.Address(RVA = "0x7D3D460", Offset = "0x7D3C660", VA = "0x187D3D460", Slot = "8")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000182")]
		[Cpp2IlInjected.Address(RVA = "0x7D391F0", Offset = "0x7D383F0", VA = "0x187D391F0", Slot = "9")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400001B")]
	public event ANFIDMOOJCO KKJNNGOFBNO
	{
		[Cpp2IlInjected.Token(Token = "0x60001AB")]
		[Cpp2IlInjected.Address(RVA = "0x7D3D110", Offset = "0x7D3C310", VA = "0x187D3D110", Slot = "14")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60001AC")]
		[Cpp2IlInjected.Address(RVA = "0x7D39140", Offset = "0x7D38340", VA = "0x187D39140", Slot = "15")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400001C")]
	public event ANFIDMOOJCO APJENHCGJLH
	{
		[Cpp2IlInjected.Token(Token = "0x60001BF")]
		[Cpp2IlInjected.Address(RVA = "0x7D3B920", Offset = "0x7D3AB20", VA = "0x187D3B920", Slot = "16")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60001C0")]
		[Cpp2IlInjected.Address(RVA = "0x7D3CF10", Offset = "0x7D3C110", VA = "0x187D3CF10", Slot = "17")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400001D")]
	public event Action<OJGJEEMDGCF, OJGJEEMDGCF> DJHFCDIFLGM
	{
		[Cpp2IlInjected.Token(Token = "0x60001C4")]
		[Cpp2IlInjected.Address(RVA = "0x7D3D0B0", Offset = "0x7D3C2B0", VA = "0x187D3D0B0", Slot = "20")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60001C5")]
		[Cpp2IlInjected.Address(RVA = "0x7D3DD40", Offset = "0x7D3CF40", VA = "0x187D3DD40", Slot = "21")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400001E")]
	public event ANFIDMOOJCO NEFPDKPJOAL
	{
		[Cpp2IlInjected.Token(Token = "0x60001C8")]
		[Cpp2IlInjected.Address(RVA = "0x7D39A00", Offset = "0x7D38C00", VA = "0x187D39A00", Slot = "12")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60001C9")]
		[Cpp2IlInjected.Address(RVA = "0x7D3ED10", Offset = "0x7D3DF10", VA = "0x187D3ED10", Slot = "13")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400001F")]
	public event ANFIDMOOJCO HCHGGAOBBCN
	{
		[Cpp2IlInjected.Token(Token = "0x60001CE")]
		[Cpp2IlInjected.Address(RVA = "0x7D3EFF0", Offset = "0x7D3E1F0", VA = "0x187D3EFF0", Slot = "10")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60001CF")]
		[Cpp2IlInjected.Address(RVA = "0x7D3AD60", Offset = "0x7D39F60", VA = "0x187D3AD60", Slot = "11")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600016A")]
	[Cpp2IlInjected.Address(RVA = "0x7D3F350", Offset = "0x7D3E550", VA = "0x187D3F350")]
	public KAECFEIKDHO(GameObject LNIONOAAAEO, RigidbodyEx FAEAAGHGADI, KKIPIEOLCEA CKLPHBNMNHA, [In] DGPLBFHBGKJ LJELDKAOCJM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600016B")]
	[Cpp2IlInjected.Address(RVA = "0x7D3C690", Offset = "0x7D3B890", VA = "0x187D3C690", Slot = "139")]
	protected virtual void ILDGAHOIHPJ(KKIPIEOLCEA CKLPHBNMNHA, DGPLBFHBGKJ LJELDKAOCJM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600016C")]
	[Cpp2IlInjected.Address(RVA = "0x7D3A8D0", Offset = "0x7D39AD0", VA = "0x187D3A8D0", Slot = "140")]
	public virtual void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600016D")]
	[Cpp2IlInjected.Address(RVA = "0x7D3B160", Offset = "0x7D3A360", VA = "0x187D3B160", Slot = "93")]
	public void FDAGCHPOHKC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600016E")]
	[Cpp2IlInjected.Address(RVA = "0x7D3B0D0", Offset = "0x7D3A2D0", VA = "0x187D3B0D0", Slot = "94")]
	public void FCMOOEKHBCA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600016F")]
	[Cpp2IlInjected.Address(RVA = "0x7D3A810", Offset = "0x7D39A10", VA = "0x187D3A810", Slot = "95")]
	public void DPIOMIOOGDI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000170")]
	[Cpp2IlInjected.Address(RVA = "0x7D3EF20", Offset = "0x7D3E120", VA = "0x187D3EF20", Slot = "96")]
	public void PGBMDHJJHBJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000171")]
	[Cpp2IlInjected.Address(RVA = "0x7D3C010", Offset = "0x7D3B210", VA = "0x187D3C010")]
	private void IFBEIMHGLKG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000172")]
	[Cpp2IlInjected.Address(RVA = "0x7D38CB0", Offset = "0x7D37EB0", VA = "0x187D38CB0")]
	private void ADHEGJKLFBM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000173")]
	[Cpp2IlInjected.Address(RVA = "0x7D3E3C0", Offset = "0x7D3D5C0", VA = "0x187D3E3C0")]
	private void NIBLJJDOGFD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600017D")]
	[Cpp2IlInjected.Address(RVA = "0x7D3DCC0", Offset = "0x7D3CEC0", VA = "0x187D3DCC0", Slot = "30")]
	public CKJMPDKLOMB NAAJMCGLLKO(int KOOLKCPAFBB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000180")]
	[Cpp2IlInjected.Address(RVA = "0x7D3CEA0", Offset = "0x7D3C0A0", VA = "0x187D3CEA0", Slot = "98")]
	public void JGMGHHENICE(CKJMPDKLOMB OMFJNFBDJCA, bool IEBFLJEOPJP = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000197")]
	[Cpp2IlInjected.Address(RVA = "0x7D3E230", Offset = "0x7D3D430", VA = "0x187D3E230", Slot = "99")]
	public void NDJNLJKBPPC(object GIIKHLJPAKH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000198")]
	[Cpp2IlInjected.Address(RVA = "0x7D3BF60", Offset = "0x7D3B160", VA = "0x187D3BF60", Slot = "100")]
	public void HKNNGLNPBFJ(object GIIKHLJPAKH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000199")]
	[Cpp2IlInjected.Address(RVA = "0x7D3CF70", Offset = "0x7D3C170", VA = "0x187D3CF70", Slot = "101")]
	public Vector3 JKHBDNCKEGL(Vector3 AAKCIEGFLNF)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x600019A")]
	[Cpp2IlInjected.Address(RVA = "0x7D3B350", Offset = "0x7D3A550", VA = "0x187D3B350", Slot = "102")]
	public Vector3 FELFDHGKHDD(Vector3 BFOLNOABHKB)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x600019B")]
	[Cpp2IlInjected.Address(RVA = "0x7D3BFC0", Offset = "0x7D3B1C0", VA = "0x187D3BFC0", Slot = "103")]
	public void ICKLMBKHLNB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600019C")]
	[Cpp2IlInjected.Address(RVA = "0x7D3EB80", Offset = "0x7D3DD80", VA = "0x187D3EB80", Slot = "104")]
	public void OLKLJJKHDOH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600019D")]
	[Cpp2IlInjected.Address(RVA = "0x7D3E900", Offset = "0x7D3DB00", VA = "0x187D3E900", Slot = "105")]
	public void OHIOFHIMLDG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600019E")]
	[Cpp2IlInjected.Address(RVA = "0x7D3A3B0", Offset = "0x7D395B0", VA = "0x187D3A3B0", Slot = "106")]
	public void DEFHNFILHJC(Vector3 GPBKAKMKHHM, Vector3 CJJEMCCDFKF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600019F")]
	[Cpp2IlInjected.Address(RVA = "0x7D3C2E0", Offset = "0x7D3B4E0", VA = "0x187D3C2E0", Slot = "107")]
	public void IHODMGNEJAO(Vector3 EHHEGNBIEBF, Vector3 GGKILDCFAHO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001A0")]
	[Cpp2IlInjected.Address(RVA = "0x7D3B5D0", Offset = "0x7D3A7D0", VA = "0x187D3B5D0", Slot = "108")]
	public void FNBNJEBEFOJ(Vector3 LGFGPHBEJIO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001A1")]
	[Cpp2IlInjected.Address(RVA = "0x7D3BEA0", Offset = "0x7D3B0A0", VA = "0x187D3BEA0", Slot = "109")]
	public void HKCDEAAELIK(HPMAFJLKFHL DLNHIMPFAMK, Vector3 HOBENLNNBJG, float LOFOCKIMDHE, float ECNCFDJFMHJ = 8f, float LLFECLGOEJE = 1f)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001A2")]
	[Cpp2IlInjected.Address(RVA = "0x7D3D7E0", Offset = "0x7D3C9E0", VA = "0x187D3D7E0", Slot = "110")]
	public void LKMPMGIBDNM(GOPIKNGHAGE GAEKIHMGGAN, Vector3 EBGAHGHEICN, float EINHNGGOAIG = float.PositiveInfinity)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001A3")]
	[Cpp2IlInjected.Address(RVA = "0x7D3E950", Offset = "0x7D3DB50", VA = "0x187D3E950", Slot = "111")]
	[Obsolete("Deprecated. Still exists to support deprecated CV2 chips. Use ApplyAngularVelocityChange.")]
	public void OIHHHPKKKKF(GOPIKNGHAGE GAEKIHMGGAN, Vector3 GLMEOLPKLCA, float EAFFEBJLAEN = 7f, float GJPEDKJKDLO = 1f)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001A4")]
	[Cpp2IlInjected.Address(RVA = "0x7D3CA50", Offset = "0x7D3BC50", VA = "0x187D3CA50", Slot = "112")]
	public Vector3 IMKIACFAHNG(Vector3 OMFJNFBDJCA)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x60001A5")]
	[Cpp2IlInjected.Address(RVA = "0x7D3EE20", Offset = "0x7D3E020", VA = "0x187D3EE20", Slot = "113")]
	public Vector3 PEKLBGGFOLJ(Vector3 OMFJNFBDJCA)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x60001A6")]
	[Cpp2IlInjected.Address(RVA = "0x7D3DC10", Offset = "0x7D3CE10", VA = "0x187D3DC10", Slot = "114")]
	public void MKAELLFKLCE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001A9")]
	[Cpp2IlInjected.Address(RVA = "0x7D3D670", Offset = "0x7D3C870", VA = "0x187D3D670", Slot = "115")]
	public void LAGPKIHKAGH(CKJMPDKLOMB PKEHBJJEGCK, object GIIKHLJPAKH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001AA")]
	[Cpp2IlInjected.Address(RVA = "0x7D3D4C0", Offset = "0x7D3C6C0", VA = "0x187D3D4C0", Slot = "116")]
	public void KONHPJAEEEB(object GIIKHLJPAKH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001B5")]
	[Cpp2IlInjected.Address(RVA = "0x7D3B490", Offset = "0x7D3A690", VA = "0x187D3B490", Slot = "63")]
	public void FHGDKLHKFOG((Quaternion rot, Vector3 moments) KHCHKJFGKPL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001B6")]
	[Cpp2IlInjected.Address(RVA = "0x7D3E370", Offset = "0x7D3D570", VA = "0x187D3E370", Slot = "117")]
	public void NGJLEKLJCAB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001B7")]
	[Cpp2IlInjected.Address(RVA = "0x7D3CCD0", Offset = "0x7D3BED0", VA = "0x187D3CCD0", Slot = "118")]
	public void JBKLOLOHMPC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001B8")]
	[Cpp2IlInjected.Address(RVA = "0x7D3D730", Offset = "0x7D3C930", VA = "0x187D3D730", Slot = "119")]
	public void LIODDGOFGOM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001C1")]
	[Cpp2IlInjected.Address(RVA = "0x7D39FD0", Offset = "0x7D391D0", VA = "0x187D39FD0", Slot = "120")]
	public bool DCDDBIEDDNG()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001C2")]
	[Cpp2IlInjected.Address(RVA = "0x7D38D30", Offset = "0x7D37F30", VA = "0x187D38D30", Slot = "97")]
	public void AFFNBFKGAPM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001C3")]
	[Cpp2IlInjected.Address(RVA = "0x7D3A9D0", Offset = "0x7D39BD0", VA = "0x187D3A9D0", Slot = "121")]
	public void EDLHJIOFNMN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001CB")]
	[Cpp2IlInjected.Address(RVA = "0x7D3B570", Offset = "0x7D3A770", VA = "0x187D3B570", Slot = "122")]
	public void FMPPAEIAHHO(object GIIKHLJPAKH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001CC")]
	[Cpp2IlInjected.Address(RVA = "0x7D3D780", Offset = "0x7D3C980", VA = "0x187D3D780", Slot = "123")]
	public void LKIMICFGPLL(object GIIKHLJPAKH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001CD")]
	[Cpp2IlInjected.Address(RVA = "0x7D3A6C0", Offset = "0x7D398C0", VA = "0x187D3A6C0", Slot = "124")]
	public void DLOLCHGHDEA(object GIIKHLJPAKH, bool JLKOFADJBOL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001DD")]
	[Cpp2IlInjected.Address(RVA = "0x7D3DF50", Offset = "0x7D3D150", VA = "0x187D3DF50", Slot = "125")]
	public void NBPBKHBDDND(Vector3 OOFANODCEOI, Quaternion NIBKNBINJBA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001DE")]
	[Cpp2IlInjected.Address(RVA = "0x7D3C4B0", Offset = "0x7D3B6B0", VA = "0x187D3C4B0", Slot = "126")]
	public void IILHAAFMECF(Vector3 OEPJNEMPDFD, Quaternion JDICBINFHHJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001DF")]
	[Cpp2IlInjected.Address(RVA = "0x7D38F70", Offset = "0x7D38170", VA = "0x187D38F70", Slot = "127")]
	public bool BAPANEFNDAC(float EDDIMDPGGDG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001E4")]
	[Cpp2IlInjected.Address(RVA = "0x7D399A0", Offset = "0x7D38BA0", VA = "0x187D399A0", Slot = "128")]
	public void CBMDGODLHHF(object GIIKHLJPAKH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001E5")]
	[Cpp2IlInjected.Address(RVA = "0x7D3AEF0", Offset = "0x7D3A0F0", VA = "0x187D3AEF0", Slot = "129")]
	public void FAABAHAPIIB(object GIIKHLJPAKH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001E6")]
	[Cpp2IlInjected.Address(RVA = "0x7D3A4A0", Offset = "0x7D396A0", VA = "0x187D3A4A0", Slot = "130")]
	public void DEHNLJMHHPM(object GIIKHLJPAKH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001E7")]
	[Cpp2IlInjected.Address(RVA = "0x7D39940", Offset = "0x7D38B40", VA = "0x187D39940", Slot = "131")]
	public void CAIPKAIMHNB(object GIIKHLJPAKH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001E8")]
	[Cpp2IlInjected.Address(RVA = "0x7D3E470", Offset = "0x7D3D670", VA = "0x187D3E470", Slot = "132")]
	public void NJGGIBIFFNJ(Vector3 CPGNGBBHKKK, ForceMode FPGHJBHLKCH = ForceMode.Force)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001E9")]
	[Cpp2IlInjected.Address(RVA = "0x7D3E6F0", Offset = "0x7D3D8F0", VA = "0x187D3E6F0", Slot = "133")]
	public void NPDHFCDBCLK(Vector3 CPGNGBBHKKK, Vector3 LBPAIJGCICL, ForceMode FPGHJBHLKCH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001EA")]
	[Cpp2IlInjected.Address(RVA = "0x7D3A5E0", Offset = "0x7D397E0", VA = "0x187D3A5E0", Slot = "134")]
	public void DHAMHFKOCDP(Vector3 CDGJIJJBKDO, ForceMode FPGHJBHLKCH = ForceMode.Force)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001EB")]
	[Cpp2IlInjected.Address(RVA = "0x7D38D80", Offset = "0x7D37F80", VA = "0x187D38D80", Slot = "135")]
	public void AHGNCJAHBHK(Vector3 CDGJIJJBKDO, ForceMode FPGHJBHLKCH = ForceMode.Force)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001EE")]
	[Cpp2IlInjected.Address(RVA = "0x7D3DE50", Offset = "0x7D3D050", VA = "0x187D3DE50", Slot = "136")]
	public bool NBGPIKGAPJE(Vector3 FOKNLDGGKBN, [Out] RaycastHit AMJOELMPNMA, float DLABDKKOOMK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001F1")]
	[Cpp2IlInjected.Address(RVA = "0x7D3E420", Offset = "0x7D3D620", VA = "0x187D3E420", Slot = "137")]
	public void NIDFGLAOFPL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001F2")]
	[Cpp2IlInjected.Address(RVA = "0x7D3F310", Offset = "0x7D3E510", VA = "0x187D3F310", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001F3")]
	[Cpp2IlInjected.Address(RVA = "0x7D3C980", Offset = "0x7D3BB80", VA = "0x187D3C980")]
	private void ILDJBFIHIOF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001F4")]
	[Cpp2IlInjected.Address(RVA = "0x7D39E60", Offset = "0x7D39060", VA = "0x187D39E60")]
	private void CONFMNJJHNB(CKJMPDKLOMB JNGEIJHHFEP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001F5")]
	[Cpp2IlInjected.Address(RVA = "0x7D3AA50", Offset = "0x7D39C50", VA = "0x187D3AA50")]
	private void EJECGFCAMLH(CKJMPDKLOMB JNGEIJHHFEP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001F6")]
	[Cpp2IlInjected.Address(RVA = "0x7D3B2A0", Offset = "0x7D3A4A0", VA = "0x187D3B2A0")]
	private void FDHLJNMKLFH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001F7")]
	[Cpp2IlInjected.Address(RVA = "0x7D3BD20", Offset = "0x7D3AF20", VA = "0x187D3BD20")]
	private void HHFMPBOKMED()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001F8")]
	[Cpp2IlInjected.Address(RVA = "0x7D3B9D0", Offset = "0x7D3ABD0", VA = "0x187D3B9D0")]
	private void GNIGAFBOPDM(CKJMPDKLOMB FEBGLNHMPCI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001F9")]
	[Cpp2IlInjected.Address(RVA = "0x7D3CD80", Offset = "0x7D3BF80", VA = "0x187D3CD80")]
	private void JEPMDLHFCME(CKJMPDKLOMB JNGEIJHHFEP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001FA")]
	[Cpp2IlInjected.Address(RVA = "0x7D3E550", Offset = "0x7D3D750", VA = "0x187D3E550")]
	private void NLAHPALAEDE(CKJMPDKLOMB JNGEIJHHFEP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001FB")]
	[Cpp2IlInjected.Address(RVA = "0x7D3D520", Offset = "0x7D3C720", VA = "0x187D3D520")]
	private void KPNEIGAPLHH(KCAMGMHDEDF JNGEIJHHFEP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001FC")]
	[Cpp2IlInjected.Address(RVA = "0x7D39500", Offset = "0x7D38700", VA = "0x187D39500", Slot = "142")]
	protected virtual void BMOKGJDHBMC(KCAMGMHDEDF DNNDAOFODNI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001FD")]
	[Cpp2IlInjected.Address(RVA = "0x7D3A020", Offset = "0x7D39220", VA = "0x187D3A020")]
	protected void DDEOKBKAOCF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001FE")]
	[Cpp2IlInjected.Address(RVA = "0x7D39AD0", Offset = "0x7D38CD0", VA = "0x187D39AD0")]
	protected void CHCEJDLLLPE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001FF")]
	[Cpp2IlInjected.Address(RVA = "0x7D3AFA0", Offset = "0x7D3A1A0", VA = "0x187D3AFA0")]
	private void FBFGAMEHFAL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000200")]
	[Cpp2IlInjected.Address(RVA = "0x7D3F100", Offset = "0x7D3E300", VA = "0x187D3F100")]
	private void PNILLGPLABC()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001D")]
internal static class ENMHNLDGBFN
{
	[Cpp2IlInjected.Token(Token = "0x6000201")]
	[Cpp2IlInjected.Address(RVA = "0x7D34140", Offset = "0x7D33340", VA = "0x187D34140")]
	public static CKJMPDKLOMB NIBONCNLMFC(this CKJMPDKLOMB DNNDAOFODNI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000202")]
	[Cpp2IlInjected.Address(RVA = "0x7D340A0", Offset = "0x7D332A0", VA = "0x187D340A0")]
	public static bool NELHAJKDCDG(this CKJMPDKLOMB DNNDAOFODNI, CKJMPDKLOMB AIGHPDBLLME)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000203")]
	[Cpp2IlInjected.Address(RVA = "0x7D33FB0", Offset = "0x7D331B0", VA = "0x187D33FB0")]
	public static bool CECFGLABNHA(this CKJMPDKLOMB DNNDAOFODNI, CKJMPDKLOMB PLLBFPIPMLE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000204")]
	[Cpp2IlInjected.Address(RVA = "0x7D34050", Offset = "0x7D33250", VA = "0x187D34050")]
	public static KCAMGMHDEDF JDJPNEOPIOB(this CKJMPDKLOMB PIJKIPKKMLF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000205")]
	[Cpp2IlInjected.Address(RVA = "0x7D33F40", Offset = "0x7D33140", VA = "0x187D33F40")]
	public static KAECFEIKDHO AMJNHIMMJKP(this CKJMPDKLOMB PIJKIPKKMLF)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200001E")]
public class DPKIPHMFIEL : BDMDMKHLKIB
{
	[Cpp2IlInjected.Token(Token = "0x6000206")]
	[Cpp2IlInjected.Address(RVA = "0x7D336D0", Offset = "0x7D328D0", VA = "0x187D336D0", Slot = "19")]
	public CKJMPDKLOMB PGGDMDPBMHO(RigidbodyEx DNNDAOFODNI, DGPLBFHBGKJ LJELDKAOCJM, KKIPIEOLCEA CKLPHBNMNHA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000207")]
	[Cpp2IlInjected.Address(RVA = "0x962E10", Offset = "0x962010", VA = "0x180962E10", Slot = "4")]
	public BIEIDLPCNCD CFLFMNPENIO(CKJMPDKLOMB PIJKIPKKMLF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000208")]
	[Cpp2IlInjected.Address(RVA = "0x962E10", Offset = "0x962010", VA = "0x180962E10", Slot = "5")]
	public IGMBHHEALAJ FGHNOBFBJLI(CKJMPDKLOMB PIJKIPKKMLF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000209")]
	[Cpp2IlInjected.Address(RVA = "0x962E10", Offset = "0x962010", VA = "0x180962E10", Slot = "6")]
	public OIOMDMFGGKD AADJDFHLHJJ(CKJMPDKLOMB PIJKIPKKMLF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600020A")]
	[Cpp2IlInjected.Address(RVA = "0x962E10", Offset = "0x962010", VA = "0x180962E10", Slot = "7")]
	public ADHJHKNEOEF NDNONMCLDOI(CKJMPDKLOMB PIJKIPKKMLF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600020B")]
	[Cpp2IlInjected.Address(RVA = "0x962E10", Offset = "0x962010", VA = "0x180962E10", Slot = "8")]
	public BPMNKEMAIHH EHCDODEHIPI(CKJMPDKLOMB PIJKIPKKMLF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600020C")]
	[Cpp2IlInjected.Address(RVA = "0x962E10", Offset = "0x962010", VA = "0x180962E10", Slot = "9")]
	public GDPPJEENGFK MEGNGFDLNNB(CKJMPDKLOMB PIJKIPKKMLF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600020D")]
	[Cpp2IlInjected.Address(RVA = "0x962E10", Offset = "0x962010", VA = "0x180962E10", Slot = "10")]
	public JFEOOGHCIHI IIPLFJOCAGL(CKJMPDKLOMB PIJKIPKKMLF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600020E")]
	[Cpp2IlInjected.Address(RVA = "0x962E10", Offset = "0x962010", VA = "0x180962E10", Slot = "11")]
	public OGJJKEJPFIP OGDGGAHKFGB(CKJMPDKLOMB PIJKIPKKMLF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600020F")]
	[Cpp2IlInjected.Address(RVA = "0x962E10", Offset = "0x962010", VA = "0x180962E10", Slot = "12")]
	public OEFJJJDHJFE OHIILNKFCCE(CKJMPDKLOMB PIJKIPKKMLF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000210")]
	[Cpp2IlInjected.Address(RVA = "0x962E10", Offset = "0x962010", VA = "0x180962E10", Slot = "13")]
	public HKNNGBMEMFN PLDADPEGIFF(CKJMPDKLOMB PIJKIPKKMLF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000211")]
	[Cpp2IlInjected.Address(RVA = "0x962E10", Offset = "0x962010", VA = "0x180962E10")]
	public EJHGNIPCIFI PNOEEEOLKHC(CKJMPDKLOMB PIJKIPKKMLF, [In] DGPLBFHBGKJ LJELDKAOCJM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000212")]
	[Cpp2IlInjected.Address(RVA = "0x962E10", Offset = "0x962010", VA = "0x180962E10")]
	public POLKOCNOBCL PCOCDOHEONG(CKJMPDKLOMB PIJKIPKKMLF, [In] DGPLBFHBGKJ LJELDKAOCJM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000213")]
	[Cpp2IlInjected.Address(RVA = "0x962E10", Offset = "0x962010", VA = "0x180962E10")]
	public IBFNAGNBCEC FAEBKHPJIIF(CKJMPDKLOMB PIJKIPKKMLF, [In] DGPLBFHBGKJ LJELDKAOCJM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000214")]
	[Cpp2IlInjected.Address(RVA = "0x962E10", Offset = "0x962010", VA = "0x180962E10")]
	public HMAJPKCIBPJ KLPBHOPAGDP(CKJMPDKLOMB PIJKIPKKMLF, [In] DGPLBFHBGKJ LJELDKAOCJM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000215")]
	[Cpp2IlInjected.Address(RVA = "0x962E10", Offset = "0x962010", VA = "0x180962E10")]
	public GEMAAJCHLNE PKAPACLHDLN(CKJMPDKLOMB PIJKIPKKMLF, [In] DGPLBFHBGKJ LJELDKAOCJM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000216")]
	[Cpp2IlInjected.Address(RVA = "0x9684B0", Offset = "0x9676B0", VA = "0x1809684B0")]
	public DPKIPHMFIEL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000217")]
	[Cpp2IlInjected.Address(RVA = "0x962E10", Offset = "0x962010", VA = "0x180962E10", Slot = "14")]
	private EJHGNIPCIFI AOJJBKNEBLE(CKJMPDKLOMB PIJKIPKKMLF, [In] DGPLBFHBGKJ LJELDKAOCJM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000218")]
	[Cpp2IlInjected.Address(RVA = "0x962E10", Offset = "0x962010", VA = "0x180962E10", Slot = "15")]
	private POLKOCNOBCL KEHOGIANBCO(CKJMPDKLOMB PIJKIPKKMLF, [In] DGPLBFHBGKJ LJELDKAOCJM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000219")]
	[Cpp2IlInjected.Address(RVA = "0x962E10", Offset = "0x962010", VA = "0x180962E10", Slot = "16")]
	private IBFNAGNBCEC IHJOLOIJBLO(CKJMPDKLOMB PIJKIPKKMLF, [In] DGPLBFHBGKJ LJELDKAOCJM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600021A")]
	[Cpp2IlInjected.Address(RVA = "0x962E10", Offset = "0x962010", VA = "0x180962E10", Slot = "17")]
	private HMAJPKCIBPJ CKIEIDPDGPJ(CKJMPDKLOMB PIJKIPKKMLF, [In] DGPLBFHBGKJ LJELDKAOCJM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600021B")]
	[Cpp2IlInjected.Address(RVA = "0x962E10", Offset = "0x962010", VA = "0x180962E10", Slot = "18")]
	private GEMAAJCHLNE IBLFGIEGNDK(CKJMPDKLOMB PIJKIPKKMLF, [In] DGPLBFHBGKJ LJELDKAOCJM)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200001F")]
[RegisterService(typeof(BDMDMKHLKIB), new string[] { })]
public class ODPPEHJBEJA : BDMDMKHLKIB, ANAKBJKCMDF
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000030")]
	private readonly BDMDMKHLKIB CHOHEKENKIG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000031")]
	private readonly BDMDMKHLKIB CEIBKNCHMAP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000032")]
	private OGHLAOPHHHL KMCGMDFMHGD;

	[Cpp2IlInjected.Token(Token = "0x1700008B")]
	private BDMDMKHLKIB LDLDFJPMHGP
	{
		[Cpp2IlInjected.Token(Token = "0x600021D")]
		[Cpp2IlInjected.Address(RVA = "0x7D450D0", Offset = "0x7D442D0", VA = "0x187D450D0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600021C")]
	[Cpp2IlInjected.Address(RVA = "0x7D44D50", Offset = "0x7D43F50", VA = "0x187D44D50", Slot = "20")]
	public void InitReferences(DBCOBCEEMIL LGCLECJNKAM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600021E")]
	[Cpp2IlInjected.Address(RVA = "0x7D448C0", Offset = "0x7D43AC0", VA = "0x187D448C0", Slot = "4")]
	public BIEIDLPCNCD CFLFMNPENIO(CKJMPDKLOMB PIJKIPKKMLF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600021F")]
	[Cpp2IlInjected.Address(RVA = "0x7D44B60", Offset = "0x7D43D60", VA = "0x187D44B60", Slot = "5")]
	public IGMBHHEALAJ FGHNOBFBJLI(CKJMPDKLOMB PIJKIPKKMLF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000220")]
	[Cpp2IlInjected.Address(RVA = "0x7D44770", Offset = "0x7D43970", VA = "0x187D44770", Slot = "6")]
	public OIOMDMFGGKD AADJDFHLHJJ(CKJMPDKLOMB PIJKIPKKMLF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000221")]
	[Cpp2IlInjected.Address(RVA = "0x7D44EF0", Offset = "0x7D440F0", VA = "0x187D44EF0", Slot = "7")]
	public ADHJHKNEOEF NDNONMCLDOI(CKJMPDKLOMB PIJKIPKKMLF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000222")]
	[Cpp2IlInjected.Address(RVA = "0x7D44A10", Offset = "0x7D43C10", VA = "0x187D44A10", Slot = "8")]
	public BPMNKEMAIHH EHCDODEHIPI(CKJMPDKLOMB PIJKIPKKMLF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000223")]
	[Cpp2IlInjected.Address(RVA = "0x7D44E50", Offset = "0x7D44050", VA = "0x187D44E50", Slot = "9")]
	public GDPPJEENGFK MEGNGFDLNNB(CKJMPDKLOMB PIJKIPKKMLF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000224")]
	[Cpp2IlInjected.Address(RVA = "0x7D44CB0", Offset = "0x7D43EB0", VA = "0x187D44CB0", Slot = "10")]
	public JFEOOGHCIHI IIPLFJOCAGL(CKJMPDKLOMB PIJKIPKKMLF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000225")]
	[Cpp2IlInjected.Address(RVA = "0x7D44F90", Offset = "0x7D44190", VA = "0x187D44F90", Slot = "11")]
	public OGJJKEJPFIP OGDGGAHKFGB(CKJMPDKLOMB PIJKIPKKMLF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000226")]
	[Cpp2IlInjected.Address(RVA = "0x7D45030", Offset = "0x7D44230", VA = "0x187D45030", Slot = "12")]
	public OEFJJJDHJFE OHIILNKFCCE(CKJMPDKLOMB PIJKIPKKMLF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000227")]
	[Cpp2IlInjected.Address(RVA = "0x7D45280", Offset = "0x7D44480", VA = "0x187D45280", Slot = "13")]
	public HKNNGBMEMFN PLDADPEGIFF(CKJMPDKLOMB PIJKIPKKMLF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000228")]
	[Cpp2IlInjected.Address(RVA = "0x7D44810", Offset = "0x7D43A10", VA = "0x187D44810")]
	public EJHGNIPCIFI PNOEEEOLKHC(CKJMPDKLOMB PIJKIPKKMLF, [In] DGPLBFHBGKJ LJELDKAOCJM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000229")]
	[Cpp2IlInjected.Address(RVA = "0x7D44DA0", Offset = "0x7D43FA0", VA = "0x187D44DA0")]
	public POLKOCNOBCL PCOCDOHEONG(CKJMPDKLOMB PIJKIPKKMLF, [In] DGPLBFHBGKJ LJELDKAOCJM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600022A")]
	[Cpp2IlInjected.Address(RVA = "0x7D44AB0", Offset = "0x7D43CB0", VA = "0x187D44AB0")]
	public IBFNAGNBCEC FAEBKHPJIIF(CKJMPDKLOMB PIJKIPKKMLF, [In] DGPLBFHBGKJ LJELDKAOCJM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600022B")]
	[Cpp2IlInjected.Address(RVA = "0x7D44960", Offset = "0x7D43B60", VA = "0x187D44960")]
	public HMAJPKCIBPJ KLPBHOPAGDP(CKJMPDKLOMB PIJKIPKKMLF, [In] DGPLBFHBGKJ LJELDKAOCJM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600022C")]
	[Cpp2IlInjected.Address(RVA = "0x7D44C00", Offset = "0x7D43E00", VA = "0x187D44C00")]
	public GEMAAJCHLNE PKAPACLHDLN(CKJMPDKLOMB PIJKIPKKMLF, [In] DGPLBFHBGKJ LJELDKAOCJM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600022D")]
	[Cpp2IlInjected.Address(RVA = "0x7D45130", Offset = "0x7D44330", VA = "0x187D45130", Slot = "19")]
	public CKJMPDKLOMB PGGDMDPBMHO(RigidbodyEx DNNDAOFODNI, DGPLBFHBGKJ LJELDKAOCJM, KKIPIEOLCEA CKLPHBNMNHA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600022E")]
	[Cpp2IlInjected.Address(RVA = "0x7D45320", Offset = "0x7D44520", VA = "0x187D45320")]
	public ODPPEHJBEJA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600022F")]
	[Cpp2IlInjected.Address(RVA = "0x7D44810", Offset = "0x7D43A10", VA = "0x187D44810", Slot = "14")]
	private EJHGNIPCIFI AOJJBKNEBLE(CKJMPDKLOMB PIJKIPKKMLF, [In] DGPLBFHBGKJ LJELDKAOCJM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000230")]
	[Cpp2IlInjected.Address(RVA = "0x7D44DA0", Offset = "0x7D43FA0", VA = "0x187D44DA0", Slot = "15")]
	private POLKOCNOBCL KEHOGIANBCO(CKJMPDKLOMB PIJKIPKKMLF, [In] DGPLBFHBGKJ LJELDKAOCJM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000231")]
	[Cpp2IlInjected.Address(RVA = "0x7D44AB0", Offset = "0x7D43CB0", VA = "0x187D44AB0", Slot = "16")]
	private IBFNAGNBCEC IHJOLOIJBLO(CKJMPDKLOMB PIJKIPKKMLF, [In] DGPLBFHBGKJ LJELDKAOCJM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000232")]
	[Cpp2IlInjected.Address(RVA = "0x7D44960", Offset = "0x7D43B60", VA = "0x187D44960", Slot = "17")]
	private HMAJPKCIBPJ CKIEIDPDGPJ(CKJMPDKLOMB PIJKIPKKMLF, [In] DGPLBFHBGKJ LJELDKAOCJM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000233")]
	[Cpp2IlInjected.Address(RVA = "0x7D44C00", Offset = "0x7D43E00", VA = "0x187D44C00", Slot = "18")]
	private GEMAAJCHLNE IBLFGIEGNDK(CKJMPDKLOMB PIJKIPKKMLF, [In] DGPLBFHBGKJ LJELDKAOCJM)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000020")]
public interface MMLDNKHAOCO : BIEIDLPCNCD, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x6000234")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void DLFMCGODDHH(CKJMPDKLOMB DNNDAOFODNI);

	[Cpp2IlInjected.Token(Token = "0x6000235")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void ICNGNHCFCPJ(CKJMPDKLOMB DNNDAOFODNI);

	[Cpp2IlInjected.Token(Token = "0x6000236")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void ODKHKEKMIDH(CKJMPDKLOMB FEBGLNHMPCI);

	[Cpp2IlInjected.Token(Token = "0x6000237")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void FMEBDIKKMHI(CKJMPDKLOMB FEBGLNHMPCI);
}
[Cpp2IlInjected.Token(Token = "0x2000021")]
public interface IFNMBNLGEDK : OIOMDMFGGKD
{
	[Cpp2IlInjected.Token(Token = "0x1700008C")]
	DCGDIAMFCNJ<CKJMPDKLOMB> HPOLMDALNAI
	{
		[Cpp2IlInjected.Token(Token = "0x6000238")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700008D")]
	CKJMPDKLOMB LKCCKGGAJFA
	{
		[Cpp2IlInjected.Token(Token = "0x6000239")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000022")]
public interface EIMBMOJILIC : HMAJPKCIBPJ
{
	[Cpp2IlInjected.Token(Token = "0x600023A")]
	[Cpp2IlInjected.Address(Slot = "0")]
	(float, Vector3) FDADCDMFHHP(Rigidbody CKOBDBBDLOM);
}
[Cpp2IlInjected.Token(Token = "0x2000023")]
public interface CDNGCDPKICN : POLKOCNOBCL, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x1700008E")]
	PhotonView DNNHDCAMIPH
	{
		[Cpp2IlInjected.Token(Token = "0x600023B")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000024")]
internal sealed class EBJOOJOPCKN : OEFJJJDHJFE
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000033")]
	private readonly KAECFEIKDHO DNNDAOFODNI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000034")]
	private CollisionDetectionMode BPDKLAHHLAG;

	[Cpp2IlInjected.Token(Token = "0x1700008F")]
	private Rigidbody KEAOKJKIGHN
	{
		[Cpp2IlInjected.Token(Token = "0x600023C")]
		[Cpp2IlInjected.Address(RVA = "0x7D33770", Offset = "0x7D32970", VA = "0x187D33770")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000090")]
	public CollisionDetectionMode NODGPJHFHCP
	{
		[Cpp2IlInjected.Token(Token = "0x6000240")]
		[Cpp2IlInjected.Address(RVA = "0x7D33C60", Offset = "0x7D32E60", VA = "0x187D33C60", Slot = "4")]
		get
		{
			return default(CollisionDetectionMode);
		}
		[Cpp2IlInjected.Token(Token = "0x6000241")]
		[Cpp2IlInjected.Address(RVA = "0x7D33960", Offset = "0x7D32B60", VA = "0x187D33960", Slot = "5")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600023D")]
	[Cpp2IlInjected.Address(RVA = "0x7D33D70", Offset = "0x7D32F70", VA = "0x187D33D70")]
	public EBJOOJOPCKN(CKJMPDKLOMB DNNDAOFODNI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600023E")]
	[Cpp2IlInjected.Address(RVA = "0x7D33840", Offset = "0x7D32A40", VA = "0x187D33840", Slot = "6")]
	public void FDAGCHPOHKC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600023F")]
	[Cpp2IlInjected.Address(RVA = "0x7D337C0", Offset = "0x7D329C0", VA = "0x187D337C0", Slot = "9")]
	public void BLMKHJFKJDL(Rigidbody BACLJFFEIHG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000242")]
	[Cpp2IlInjected.Address(RVA = "0x7D33950", Offset = "0x7D32B50", VA = "0x187D33950", Slot = "7")]
	public void GIKCBOGPGEG(bool ICCHEKBPFEH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000243")]
	[Cpp2IlInjected.Address(RVA = "0x7D33AF0", Offset = "0x7D32CF0", VA = "0x187D33AF0", Slot = "8")]
	public void MBAKMCGMLMJ(bool ICCHEKBPFEH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000244")]
	[Cpp2IlInjected.Address(RVA = "0x7D33B00", Offset = "0x7D32D00", VA = "0x187D33B00", Slot = "10")]
	public bool NBGPIKGAPJE(Vector3 FOKNLDGGKBN, [Out] RaycastHit AMJOELMPNMA, float DLABDKKOOMK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000245")]
	[Cpp2IlInjected.Address(RVA = "0x7D339D0", Offset = "0x7D32BD0", VA = "0x187D339D0")]
	private void KJJDFGFGIGD(bool ICCHEKBPFEH)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000025")]
public sealed class BBONNBEKLEA : GDPPJEENGFK, IDisposable, EALHLPODMHD
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000036")]
	private readonly KAECFEIKDHO DNNDAOFODNI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000037")]
	private DFMIAGBKIML DOAOJBLJCJJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000038")]
	private FKOBCEMDEIN CGIDACDDFJI;

	[Cpp2IlInjected.Token(Token = "0x17000091")]
	public DFMIAGBKIML FOPOMNMNGMP
	{
		[Cpp2IlInjected.Token(Token = "0x6000248")]
		[Cpp2IlInjected.Address(RVA = "0x7D31930", Offset = "0x7D30B30", VA = "0x187D31930", Slot = "6")]
		get
		{
			return default(DFMIAGBKIML);
		}
		[Cpp2IlInjected.Token(Token = "0x6000249")]
		[Cpp2IlInjected.Address(RVA = "0x7D314F0", Offset = "0x7D306F0", VA = "0x187D314F0", Slot = "7")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000092")]
	private Transform KDMBMLBGGHF
	{
		[Cpp2IlInjected.Token(Token = "0x600024A")]
		[Cpp2IlInjected.Address(RVA = "0xBC3C30", Offset = "0xBC2E30", VA = "0x180BC3C30", Slot = "10")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000020")]
	public event Action<OJGJEEMDGCF, OJGJEEMDGCF> DJHFCDIFLGM
	{
		[Cpp2IlInjected.Token(Token = "0x6000246")]
		[Cpp2IlInjected.Address(RVA = "0x7D31880", Offset = "0x7D30A80", VA = "0x187D31880", Slot = "4")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000247")]
		[Cpp2IlInjected.Address(RVA = "0x7D31A70", Offset = "0x7D30C70", VA = "0x187D31A70", Slot = "5")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600024B")]
	[Cpp2IlInjected.Address(RVA = "0x7D31B20", Offset = "0x7D30D20", VA = "0x187D31B20")]
	public BBONNBEKLEA(CKJMPDKLOMB DNNDAOFODNI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600024C")]
	[Cpp2IlInjected.Address(RVA = "0x7D31610", Offset = "0x7D30810", VA = "0x187D31610", Slot = "8")]
	public void FDAGCHPOHKC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600024D")]
	[Cpp2IlInjected.Address(RVA = "0x7D315C0", Offset = "0x7D307C0", VA = "0x187D315C0", Slot = "9")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600024E")]
	[Cpp2IlInjected.Address(RVA = "0x102D530", Offset = "0x102C730", VA = "0x18102D530", Slot = "11")]
	private void OHGICBMKLCO(OJGJEEMDGCF HLCBPMGFKGN, OJGJEEMDGCF FGKKDPKFMGI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600024F")]
	[Cpp2IlInjected.Address(RVA = "0x962E00", Offset = "0x962000", VA = "0x180962E00", Slot = "12")]
	private void MJFAOMNCNGG(bool BICMOCINKIA)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000026")]
public class DAONHOPEMPC : BDMDMKHLKIB
{
	[Cpp2IlInjected.Token(Token = "0x6000250")]
	[Cpp2IlInjected.Address(RVA = "0x7D325F0", Offset = "0x7D317F0", VA = "0x187D325F0", Slot = "4")]
	public BIEIDLPCNCD CFLFMNPENIO(CKJMPDKLOMB PIJKIPKKMLF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000251")]
	[Cpp2IlInjected.Address(RVA = "0x7D32A70", Offset = "0x7D31C70", VA = "0x187D32A70", Slot = "5")]
	public IGMBHHEALAJ FGHNOBFBJLI(CKJMPDKLOMB PIJKIPKKMLF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000252")]
	[Cpp2IlInjected.Address(RVA = "0x7D32380", Offset = "0x7D31580", VA = "0x187D32380", Slot = "6")]
	public OIOMDMFGGKD AADJDFHLHJJ(CKJMPDKLOMB PIJKIPKKMLF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000253")]
	[Cpp2IlInjected.Address(RVA = "0x7D32FF0", Offset = "0x7D321F0", VA = "0x187D32FF0", Slot = "7")]
	public ADHJHKNEOEF NDNONMCLDOI(CKJMPDKLOMB PIJKIPKKMLF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000254")]
	[Cpp2IlInjected.Address(RVA = "0x7D32870", Offset = "0x7D31A70", VA = "0x187D32870", Slot = "8")]
	public BPMNKEMAIHH EHCDODEHIPI(CKJMPDKLOMB PIJKIPKKMLF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000255")]
	[Cpp2IlInjected.Address(RVA = "0x7D32F20", Offset = "0x7D32120", VA = "0x187D32F20", Slot = "9")]
	public GDPPJEENGFK MEGNGFDLNNB(CKJMPDKLOMB PIJKIPKKMLF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000256")]
	[Cpp2IlInjected.Address(RVA = "0x7D32C70", Offset = "0x7D31E70", VA = "0x187D32C70", Slot = "10")]
	public JFEOOGHCIHI IIPLFJOCAGL(CKJMPDKLOMB PIJKIPKKMLF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000257")]
	[Cpp2IlInjected.Address(RVA = "0x7D33070", Offset = "0x7D32270", VA = "0x187D33070", Slot = "11")]
	public OGJJKEJPFIP OGDGGAHKFGB(CKJMPDKLOMB PIJKIPKKMLF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000258")]
	[Cpp2IlInjected.Address(RVA = "0x7D33130", Offset = "0x7D32330", VA = "0x187D33130", Slot = "12")]
	public OEFJJJDHJFE OHIILNKFCCE(CKJMPDKLOMB PIJKIPKKMLF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000259")]
	[Cpp2IlInjected.Address(RVA = "0x7D33340", Offset = "0x7D32540", VA = "0x187D33340", Slot = "13")]
	public HKNNGBMEMFN PLDADPEGIFF(CKJMPDKLOMB PIJKIPKKMLF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600025A")]
	[Cpp2IlInjected.Address(RVA = "0x7D324B0", Offset = "0x7D316B0", VA = "0x187D324B0")]
	public EJHGNIPCIFI PNOEEEOLKHC(CKJMPDKLOMB PIJKIPKKMLF, [In] DGPLBFHBGKJ LJELDKAOCJM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600025B")]
	[Cpp2IlInjected.Address(RVA = "0x7D32D90", Offset = "0x7D31F90", VA = "0x187D32D90")]
	public POLKOCNOBCL PCOCDOHEONG(CKJMPDKLOMB PIJKIPKKMLF, [In] DGPLBFHBGKJ LJELDKAOCJM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600025C")]
	[Cpp2IlInjected.Address(RVA = "0x7D32940", Offset = "0x7D31B40", VA = "0x187D32940")]
	public IBFNAGNBCEC FAEBKHPJIIF(CKJMPDKLOMB PIJKIPKKMLF, [In] DGPLBFHBGKJ LJELDKAOCJM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600025D")]
	[Cpp2IlInjected.Address(RVA = "0x7D326E0", Offset = "0x7D318E0", VA = "0x187D326E0")]
	public HMAJPKCIBPJ KLPBHOPAGDP(CKJMPDKLOMB PIJKIPKKMLF, [In] DGPLBFHBGKJ LJELDKAOCJM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600025E")]
	[Cpp2IlInjected.Address(RVA = "0x7D32B90", Offset = "0x7D31D90", VA = "0x187D32B90")]
	public GEMAAJCHLNE PKAPACLHDLN(CKJMPDKLOMB PIJKIPKKMLF, [In] DGPLBFHBGKJ LJELDKAOCJM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600025F")]
	[Cpp2IlInjected.Address(RVA = "0x7D331F0", Offset = "0x7D323F0", VA = "0x187D331F0", Slot = "19")]
	public CKJMPDKLOMB PGGDMDPBMHO(RigidbodyEx DNNDAOFODNI, DGPLBFHBGKJ LJELDKAOCJM, KKIPIEOLCEA CKLPHBNMNHA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000260")]
	[Cpp2IlInjected.Address(RVA = "0x9684B0", Offset = "0x9676B0", VA = "0x1809684B0")]
	public DAONHOPEMPC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000261")]
	[Cpp2IlInjected.Address(RVA = "0x7D324B0", Offset = "0x7D316B0", VA = "0x187D324B0", Slot = "14")]
	private EJHGNIPCIFI AOJJBKNEBLE(CKJMPDKLOMB PIJKIPKKMLF, [In] DGPLBFHBGKJ LJELDKAOCJM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000262")]
	[Cpp2IlInjected.Address(RVA = "0x7D32D90", Offset = "0x7D31F90", VA = "0x187D32D90", Slot = "15")]
	private POLKOCNOBCL KEHOGIANBCO(CKJMPDKLOMB PIJKIPKKMLF, [In] DGPLBFHBGKJ LJELDKAOCJM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000263")]
	[Cpp2IlInjected.Address(RVA = "0x7D32940", Offset = "0x7D31B40", VA = "0x187D32940", Slot = "16")]
	private IBFNAGNBCEC IHJOLOIJBLO(CKJMPDKLOMB PIJKIPKKMLF, [In] DGPLBFHBGKJ LJELDKAOCJM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000264")]
	[Cpp2IlInjected.Address(RVA = "0x7D326E0", Offset = "0x7D318E0", VA = "0x187D326E0", Slot = "17")]
	private HMAJPKCIBPJ CKIEIDPDGPJ(CKJMPDKLOMB PIJKIPKKMLF, [In] DGPLBFHBGKJ LJELDKAOCJM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000265")]
	[Cpp2IlInjected.Address(RVA = "0x7D32B90", Offset = "0x7D31D90", VA = "0x187D32B90", Slot = "18")]
	private GEMAAJCHLNE IBLFGIEGNDK(CKJMPDKLOMB PIJKIPKKMLF, [In] DGPLBFHBGKJ LJELDKAOCJM)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000027")]
internal sealed class JFFPIBLBANL : OGJJKEJPFIP
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000039")]
	private readonly KAECFEIKDHO DNNDAOFODNI;

	[Cpp2IlInjected.Token(Token = "0x17000093")]
	private Rigidbody KEAOKJKIGHN
	{
		[Cpp2IlInjected.Token(Token = "0x6000266")]
		[Cpp2IlInjected.Address(RVA = "0x7D33770", Offset = "0x7D32970", VA = "0x187D33770")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000094")]
	private bool LKEJANPOONK
	{
		[Cpp2IlInjected.Token(Token = "0x6000267")]
		[Cpp2IlInjected.Address(RVA = "0x7D354C0", Offset = "0x7D346C0", VA = "0x187D354C0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000095")]
	private bool JBNFKMDMFCO
	{
		[Cpp2IlInjected.Token(Token = "0x6000268")]
		[Cpp2IlInjected.Address(RVA = "0x7D35510", Offset = "0x7D34710", VA = "0x187D35510")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000096")]
	private CKJMPDKLOMB JCHDMDCGBIH
	{
		[Cpp2IlInjected.Token(Token = "0x6000269")]
		[Cpp2IlInjected.Address(RVA = "0x7D35A30", Offset = "0x7D34C30", VA = "0x187D35A30")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600026A")]
	[Cpp2IlInjected.Address(RVA = "0x7D33D70", Offset = "0x7D32F70", VA = "0x187D33D70")]
	public JFFPIBLBANL(CKJMPDKLOMB DNNDAOFODNI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600026B")]
	[Cpp2IlInjected.Address(RVA = "0x7D35A90", Offset = "0x7D34C90", VA = "0x187D35A90", Slot = "4")]
	public void NJGGIBIFFNJ(Vector3 CPGNGBBHKKK, ForceMode FPGHJBHLKCH = ForceMode.Force)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600026C")]
	[Cpp2IlInjected.Address(RVA = "0x7D357D0", Offset = "0x7D349D0", VA = "0x187D357D0")]
	private void JLFOOCIANFF(Vector3 CPGNGBBHKKK, ForceMode FPGHJBHLKCH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600026D")]
	[Cpp2IlInjected.Address(RVA = "0x7D35BF0", Offset = "0x7D34DF0", VA = "0x187D35BF0", Slot = "5")]
	public void NPDHFCDBCLK(Vector3 CPGNGBBHKKK, Vector3 LBPAIJGCICL, ForceMode FPGHJBHLKCH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600026E")]
	[Cpp2IlInjected.Address(RVA = "0x7D35360", Offset = "0x7D34560", VA = "0x187D35360", Slot = "6")]
	public void DHAMHFKOCDP(Vector3 CDGJIJJBKDO, ForceMode FPGHJBHLKCH = ForceMode.Force)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600026F")]
	[Cpp2IlInjected.Address(RVA = "0x7D35570", Offset = "0x7D34770", VA = "0x187D35570")]
	private void HNCHDNKKGAO(Vector3 CDGJIJJBKDO, ForceMode FPGHJBHLKCH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000270")]
	[Cpp2IlInjected.Address(RVA = "0x7D35100", Offset = "0x7D34300", VA = "0x187D35100", Slot = "7")]
	public void AHGNCJAHBHK(Vector3 CDGJIJJBKDO, ForceMode FPGHJBHLKCH = ForceMode.Force)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000028")]
internal sealed class FNPEAMGLCHI : HKNNGBMEMFN
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400003A")]
	private readonly KAECFEIKDHO DNNDAOFODNI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400003B")]
	private bool LLEJFBHCNCJ;

	[Cpp2IlInjected.Token(Token = "0x17000097")]
	public bool NEJMOBEANOE
	{
		[Cpp2IlInjected.Token(Token = "0x6000272")]
		[Cpp2IlInjected.Address(RVA = "0xC04650", Offset = "0xC03850", VA = "0x180C04650", Slot = "4")]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000273")]
		[Cpp2IlInjected.Address(RVA = "0x7D34F30", Offset = "0x7D34130", VA = "0x187D34F30", Slot = "5")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000271")]
	[Cpp2IlInjected.Address(RVA = "0x7D33D70", Offset = "0x7D32F70", VA = "0x187D33D70")]
	public FNPEAMGLCHI(CKJMPDKLOMB DNNDAOFODNI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000274")]
	[Cpp2IlInjected.Address(RVA = "0x7D34E90", Offset = "0x7D34090", VA = "0x187D34E90", Slot = "6")]
	public void BLMKHJFKJDL(Rigidbody BACLJFFEIHG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000275")]
	[Cpp2IlInjected.Address(RVA = "0x7D34EC0", Offset = "0x7D340C0", VA = "0x187D34EC0", Slot = "7")]
	public void EFMMJPIOIHC(Rigidbody BACLJFFEIHG)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000029")]
internal sealed class JPAJNDHDGLC : MMLDNKHAOCO, BIEIDLPCNCD, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x4000045")]
	private readonly CKJMPDKLOMB DNNDAOFODNI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x4000046")]
	private readonly List<CKJMPDKLOMB> CGONFGIBINL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x4000047")]
	private CKJMPDKLOMB BFPPPKIAFBG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x4000048")]
	private CKJMPDKLOMB JNGEIJHHFEP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
	[Cpp2IlInjected.Token(Token = "0x4000049")]
	private Transform FBDIODDHINC;

	[Cpp2IlInjected.Token(Token = "0x17000098")]
	private Transform FFFKHKBLIED
	{
		[Cpp2IlInjected.Token(Token = "0x6000288")]
		[Cpp2IlInjected.Address(RVA = "0x7D376B0", Offset = "0x7D368B0", VA = "0x187D376B0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000099")]
	public CKJMPDKLOMB JCHDMDCGBIH
	{
		[Cpp2IlInjected.Token(Token = "0x600028B")]
		[Cpp2IlInjected.Address(RVA = "0x966D60", Offset = "0x965F60", VA = "0x180966D60", Slot = "28")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600028C")]
		[Cpp2IlInjected.Address(RVA = "0x7D38740", Offset = "0x7D37940", VA = "0x187D38740", Slot = "29")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700009A")]
	public CKJMPDKLOMB GMOCPPMLGKK
	{
		[Cpp2IlInjected.Token(Token = "0x600028D")]
		[Cpp2IlInjected.Address(RVA = "0x961670", Offset = "0x960870", VA = "0x180961670", Slot = "27")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700009B")]
	public IReadOnlyList<CKJMPDKLOMB> FALOJGLJHKJ
	{
		[Cpp2IlInjected.Token(Token = "0x600028E")]
		[Cpp2IlInjected.Address(RVA = "0x961600", Offset = "0x960800", VA = "0x180961600", Slot = "26")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000021")]
	public event ANFIDMOOJCO FDIAOCEAMBE
	{
		[Cpp2IlInjected.Token(Token = "0x6000276")]
		[Cpp2IlInjected.Address(RVA = "0x7D377C0", Offset = "0x7D369C0", VA = "0x187D377C0", Slot = "8")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000277")]
		[Cpp2IlInjected.Address(RVA = "0x7D37610", Offset = "0x7D36810", VA = "0x187D37610", Slot = "9")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000022")]
	public event ANFIDMOOJCO OOCMNBBKMLH
	{
		[Cpp2IlInjected.Token(Token = "0x6000278")]
		[Cpp2IlInjected.Address(RVA = "0x7D38750", Offset = "0x7D37950", VA = "0x187D38750", Slot = "10")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000279")]
		[Cpp2IlInjected.Address(RVA = "0x7D38100", Offset = "0x7D37300", VA = "0x187D38100", Slot = "11")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000023")]
	public event FIIDLLPBBKB KPLNNKLAKFG
	{
		[Cpp2IlInjected.Token(Token = "0x600027A")]
		[Cpp2IlInjected.Address(RVA = "0x7D388D0", Offset = "0x7D37AD0", VA = "0x187D388D0", Slot = "12")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600027B")]
		[Cpp2IlInjected.Address(RVA = "0x7D36B60", Offset = "0x7D35D60", VA = "0x187D36B60", Slot = "13")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000024")]
	public event Action KMDFMCJOGBC
	{
		[Cpp2IlInjected.Token(Token = "0x600027C")]
		[Cpp2IlInjected.Address(RVA = "0x7D38830", Offset = "0x7D37A30", VA = "0x187D38830", Slot = "14")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600027D")]
		[Cpp2IlInjected.Address(RVA = "0x7D38300", Offset = "0x7D37500", VA = "0x187D38300", Slot = "15")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000025")]
	public event Action EMFNNCGCEPI
	{
		[Cpp2IlInjected.Token(Token = "0x600027E")]
		[Cpp2IlInjected.Address(RVA = "0x7D36EC0", Offset = "0x7D360C0", VA = "0x187D36EC0", Slot = "16")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600027F")]
		[Cpp2IlInjected.Address(RVA = "0x7D36F60", Offset = "0x7D36160", VA = "0x187D36F60", Slot = "17")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000026")]
	public event Action<CKJMPDKLOMB> EIKLDMEOLAG
	{
		[Cpp2IlInjected.Token(Token = "0x6000280")]
		[Cpp2IlInjected.Address(RVA = "0x7D36E10", Offset = "0x7D36010", VA = "0x187D36E10", Slot = "18")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000281")]
		[Cpp2IlInjected.Address(RVA = "0x7D36C00", Offset = "0x7D35E00", VA = "0x187D36C00", Slot = "19")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000027")]
	public event Action<CKJMPDKLOMB> EBNPIMMJMBB
	{
		[Cpp2IlInjected.Token(Token = "0x6000282")]
		[Cpp2IlInjected.Address(RVA = "0x7D372E0", Offset = "0x7D364E0", VA = "0x187D372E0", Slot = "20")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000283")]
		[Cpp2IlInjected.Address(RVA = "0x7D381A0", Offset = "0x7D373A0", VA = "0x187D381A0", Slot = "21")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000028")]
	public event Action PGNAOPBKEJL
	{
		[Cpp2IlInjected.Token(Token = "0x6000284")]
		[Cpp2IlInjected.Address(RVA = "0x7D36CB0", Offset = "0x7D35EB0", VA = "0x187D36CB0", Slot = "22")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000285")]
		[Cpp2IlInjected.Address(RVA = "0x7D37860", Offset = "0x7D36A60", VA = "0x187D37860", Slot = "23")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000029")]
	public event Action<CKJMPDKLOMB> EEGKIOLBDEJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000286")]
		[Cpp2IlInjected.Address(RVA = "0x7D37710", Offset = "0x7D36910", VA = "0x187D37710", Slot = "24")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000287")]
		[Cpp2IlInjected.Address(RVA = "0x7D38250", Offset = "0x7D37450", VA = "0x187D38250", Slot = "25")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000289")]
	[Cpp2IlInjected.Address(RVA = "0x7D38970", Offset = "0x7D37B70", VA = "0x187D38970")]
	public JPAJNDHDGLC(CKJMPDKLOMB DNNDAOFODNI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600028A")]
	[Cpp2IlInjected.Address(RVA = "0x7D37110", Offset = "0x7D36310", VA = "0x187D37110", Slot = "31")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600028F")]
	[Cpp2IlInjected.Address(RVA = "0x7D37AE0", Offset = "0x7D36CE0", VA = "0x187D37AE0", Slot = "30")]
	public void JGMGHHENICE(CKJMPDKLOMB NAAOBFPOHHG, bool IEBFLJEOPJP = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000290")]
	[Cpp2IlInjected.Address(RVA = "0x7D384D0", Offset = "0x7D376D0", VA = "0x187D384D0", Slot = "6")]
	public void ODKHKEKMIDH(CKJMPDKLOMB FEBGLNHMPCI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000291")]
	[Cpp2IlInjected.Address(RVA = "0x7D37390", Offset = "0x7D36590", VA = "0x187D37390", Slot = "7")]
	public void FMEBDIKKMHI(CKJMPDKLOMB FEBGLNHMPCI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000292")]
	[Cpp2IlInjected.Address(RVA = "0x7D37000", Offset = "0x7D36200", VA = "0x187D37000", Slot = "4")]
	public void DLFMCGODDHH(CKJMPDKLOMB DNNDAOFODNI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000293")]
	[Cpp2IlInjected.Address(RVA = "0x7D37900", Offset = "0x7D36B00", VA = "0x187D37900", Slot = "5")]
	public void ICNGNHCFCPJ(CKJMPDKLOMB DNNDAOFODNI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000294")]
	[Cpp2IlInjected.Address(RVA = "0x7D38060", Offset = "0x7D37260", VA = "0x187D38060")]
	private void JJCJNEOEFMF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000295")]
	[Cpp2IlInjected.Address(RVA = "0x7D387F0", Offset = "0x7D379F0", VA = "0x187D387F0")]
	private void PCJGNBMCLOJ(CKJMPDKLOMB FEBGLNHMPCI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000296")]
	[Cpp2IlInjected.Address(RVA = "0x7D379A0", Offset = "0x7D36BA0", VA = "0x187D379A0")]
	private void IMOAKCENBGN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000297")]
	[Cpp2IlInjected.Address(RVA = "0x7D383A0", Offset = "0x7D375A0", VA = "0x187D383A0")]
	private void MPAOFOMOKPL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000298")]
	[Cpp2IlInjected.Address(RVA = "0x7D371B0", Offset = "0x7D363B0", VA = "0x187D371B0")]
	private void EFMGLNMDLDH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000299")]
	[Cpp2IlInjected.Address(RVA = "0x7D36D50", Offset = "0x7D35F50", VA = "0x187D36D50")]
	[CompilerGenerated]
	private object BAGJNKHDMFP()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200002A")]
internal static class BDIDBDHEGKD
{
	[Cpp2IlInjected.Token(Token = "0x600029A")]
	[Cpp2IlInjected.Address(RVA = "0x7D31BB0", Offset = "0x7D30DB0", VA = "0x187D31BB0")]
	public static MMLDNKHAOCO LFHJNLHDEPB(this CKJMPDKLOMB PIJKIPKKMLF)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200002B")]
internal sealed class EOEJMLCGCDN : IFNMBNLGEDK, OIOMDMFGGKD
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400004A")]
	private readonly KAECFEIKDHO DNNDAOFODNI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400004B")]
	private readonly DCGDIAMFCNJ<CKJMPDKLOMB> JLLALNDNFPF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400004C")]
	private bool AEJILIJKJCK;

	[Cpp2IlInjected.Token(Token = "0x1700009C")]
	public DCGDIAMFCNJ<CKJMPDKLOMB> HPOLMDALNAI
	{
		[Cpp2IlInjected.Token(Token = "0x600029B")]
		[Cpp2IlInjected.Address(RVA = "0x963A50", Offset = "0x962C50", VA = "0x180963A50", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700009D")]
	public Vector3 NGONCLLCEOD
	{
		[Cpp2IlInjected.Token(Token = "0x600029C")]
		[Cpp2IlInjected.Address(RVA = "0x7D34AF0", Offset = "0x7D33CF0", VA = "0x187D34AF0", Slot = "6")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700009E")]
	public Vector3 HFAAGKLHHCE
	{
		[Cpp2IlInjected.Token(Token = "0x600029D")]
		[Cpp2IlInjected.Address(RVA = "0x7D34930", Offset = "0x7D33B30", VA = "0x187D34930", Slot = "7")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700009F")]
	private Vector3 MGLKIJIEAAJ
	{
		[Cpp2IlInjected.Token(Token = "0x60002A1")]
		[Cpp2IlInjected.Address(RVA = "0x7D34C40", Offset = "0x7D33E40", VA = "0x187D34C40")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A0")]
	public CKJMPDKLOMB LKCCKGGAJFA
	{
		[Cpp2IlInjected.Token(Token = "0x60002A2")]
		[Cpp2IlInjected.Address(RVA = "0x7D34B90", Offset = "0x7D33D90", VA = "0x187D34B90", Slot = "5")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600029E")]
	[Cpp2IlInjected.Address(RVA = "0x7D34D90", Offset = "0x7D33F90", VA = "0x187D34D90")]
	public EOEJMLCGCDN(CKJMPDKLOMB DNNDAOFODNI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600029F")]
	[Cpp2IlInjected.Address(RVA = "0x7D34B20", Offset = "0x7D33D20", VA = "0x187D34B20", Slot = "8")]
	public void KOFJKFHKDDB(CKJMPDKLOMB JNGEIJHHFEP, object GIIKHLJPAKH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002A0")]
	[Cpp2IlInjected.Address(RVA = "0x7D34D30", Offset = "0x7D33F30", VA = "0x187D34D30", Slot = "9")]
	public void PAEDECCCJGM(object GIIKHLJPAKH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002A3")]
	[Cpp2IlInjected.Address(RVA = "0x7D34200", Offset = "0x7D33400", VA = "0x187D34200")]
	private Vector3 DDNIDPOPCHC()
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x60002A4")]
	[Cpp2IlInjected.Address(RVA = "0x7D345A0", Offset = "0x7D337A0", VA = "0x187D345A0")]
	private void GBFOKDACLGK(CKJMPDKLOMB KGOIDDLHMJO)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002C")]
internal static class PHCFKKOMNHH
{
	[Cpp2IlInjected.Token(Token = "0x60002A5")]
	[Cpp2IlInjected.Address(RVA = "0x7D45690", Offset = "0x7D44890", VA = "0x187D45690")]
	public static IFNMBNLGEDK BIPJMCKHNHC(this CKJMPDKLOMB PIJKIPKKMLF)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200002D")]
internal sealed class PJDBNEEHLHM : EIMBMOJILIC, HMAJPKCIBPJ
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400004E")]
	private readonly KAECFEIKDHO DNNDAOFODNI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400004F")]
	private readonly OverridableVector3 KMIDEFGABNB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000050")]
	private readonly OverridableVector3 MENNJEABNLH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000051")]
	private float FAMHEECINGG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x44")]
	[Cpp2IlInjected.Token(Token = "0x4000052")]
	private float IFJOFKGNPEC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000053")]
	private Vector3 GAPNLIHKHLP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x54")]
	[Cpp2IlInjected.Token(Token = "0x4000054")]
	private Vector3? JJJBLBAHNIE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x64")]
	[Cpp2IlInjected.Token(Token = "0x4000055")]
	private Quaternion? LLJKIMDELJD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
	[Cpp2IlInjected.Token(Token = "0x4000056")]
	private bool FHCFHJDEENJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x79")]
	[Cpp2IlInjected.Token(Token = "0x4000057")]
	private bool NNNPDPEFHBE;

	[Cpp2IlInjected.Token(Token = "0x170000A1")]
	public Vector3 NEOCHLLLADD
	{
		[Cpp2IlInjected.Token(Token = "0x60002A8")]
		[Cpp2IlInjected.Address(RVA = "0x144E8E0", Offset = "0x144DAE0", VA = "0x18144E8E0", Slot = "7")]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x60002A9")]
		[Cpp2IlInjected.Address(RVA = "0x7D45750", Offset = "0x7D44950", VA = "0x187D45750", Slot = "8")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A2")]
	public Vector3 LFCBHFAIPLK
	{
		[Cpp2IlInjected.Token(Token = "0x60002AA")]
		[Cpp2IlInjected.Address(RVA = "0x7D47DC0", Offset = "0x7D46FC0", VA = "0x187D47DC0", Slot = "9")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A3")]
	public float GCKJPMGDNLH
	{
		[Cpp2IlInjected.Token(Token = "0x60002AB")]
		[Cpp2IlInjected.Address(RVA = "0xBE8F00", Offset = "0xBE8100", VA = "0x180BE8F00", Slot = "10")]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x60002AC")]
		[Cpp2IlInjected.Address(RVA = "0x7D458E0", Offset = "0x7D44AE0", VA = "0x187D458E0")]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A4")]
	public float IFIJBNAHOEN
	{
		[Cpp2IlInjected.Token(Token = "0x60002AD")]
		[Cpp2IlInjected.Address(RVA = "0xAE4140", Offset = "0xAE3340", VA = "0x180AE4140", Slot = "11")]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x60002AE")]
		[Cpp2IlInjected.Address(RVA = "0x7D46E00", Offset = "0x7D46000", VA = "0x187D46E00", Slot = "12")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A5")]
	public Vector3 JNJDCEPOOMF
	{
		[Cpp2IlInjected.Token(Token = "0x60002AF")]
		[Cpp2IlInjected.Address(RVA = "0x7D459F0", Offset = "0x7D44BF0", VA = "0x187D459F0", Slot = "13")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A6")]
	public Quaternion LMFNPKFPCOA
	{
		[Cpp2IlInjected.Token(Token = "0x60002B0")]
		[Cpp2IlInjected.Address(RVA = "0x7D47AA0", Offset = "0x7D46CA0", VA = "0x187D47AA0", Slot = "14")]
		get
		{
			return default(Quaternion);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A7")]
	private Rigidbody KEAOKJKIGHN
	{
		[Cpp2IlInjected.Token(Token = "0x60002B8")]
		[Cpp2IlInjected.Address(RVA = "0x7D3F5A0", Offset = "0x7D3E7A0", VA = "0x187D3F5A0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400002A")]
	public event ANFIDMOOJCO MDAOGBIGIGC
	{
		[Cpp2IlInjected.Token(Token = "0x60002A6")]
		[Cpp2IlInjected.Address(RVA = "0x7D47080", Offset = "0x7D46280", VA = "0x187D47080", Slot = "5")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60002A7")]
		[Cpp2IlInjected.Address(RVA = "0x7D47120", Offset = "0x7D46320", VA = "0x187D47120", Slot = "6")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60002B1")]
	[Cpp2IlInjected.Address(RVA = "0x7D47EB0", Offset = "0x7D470B0", VA = "0x187D47EB0")]
	public PJDBNEEHLHM(CKJMPDKLOMB DNNDAOFODNI, [In] DGPLBFHBGKJ LJELDKAOCJM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002B2")]
	[Cpp2IlInjected.Address(RVA = "0x7D474F0", Offset = "0x7D466F0", VA = "0x187D474F0", Slot = "17")]
	public void NGJLEKLJCAB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002B3")]
	[Cpp2IlInjected.Address(RVA = "0x7D46FA0", Offset = "0x7D461A0", VA = "0x187D46FA0", Slot = "16")]
	public void JBKLOLOHMPC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002B4")]
	[Cpp2IlInjected.Address(RVA = "0x7D45800", Offset = "0x7D44A00", VA = "0x187D45800", Slot = "19")]
	public void BLMKHJFKJDL(Rigidbody BACLJFFEIHG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002B5")]
	[Cpp2IlInjected.Address(RVA = "0x7D45B80", Offset = "0x7D44D80", VA = "0x187D45B80", Slot = "20")]
	public void EFMMJPIOIHC(Rigidbody BACLJFFEIHG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002B6")]
	[Cpp2IlInjected.Address(RVA = "0x7D471C0", Offset = "0x7D463C0", VA = "0x187D471C0", Slot = "18")]
	public void LIODDGOFGOM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002B7")]
	[Cpp2IlInjected.Address(RVA = "0x7D47610", Offset = "0x7D46810", VA = "0x187D47610", Slot = "21")]
	public void NIDFGLAOFPL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002B9")]
	[Cpp2IlInjected.Address(RVA = "0x7D45750", Offset = "0x7D44950", VA = "0x187D45750")]
	private void JPOENLMIOOM(Vector3 OMFJNFBDJCA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002BA")]
	[Cpp2IlInjected.Address(RVA = "0x7D46EB0", Offset = "0x7D460B0", VA = "0x187D46EB0")]
	[Obsolete("This method is dangerous - the unity rigidbody is updated in a deferred manner and this world position may be stale")]
	private Vector3 JAAMACFNJMD()
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x60002BB")]
	[Cpp2IlInjected.Address(RVA = "0x7D458E0", Offset = "0x7D44AE0", VA = "0x187D458E0")]
	private void CPKCLDMAOFM(float OMFJNFBDJCA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002BC")]
	[Cpp2IlInjected.Address(RVA = "0x7D46E00", Offset = "0x7D46000", VA = "0x187D46E00")]
	private void GGPMNGPDIMG(float OMFJNFBDJCA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002BD")]
	[Cpp2IlInjected.Address(RVA = "0x7D47C20", Offset = "0x7D46E20", VA = "0x187D47C20")]
	private Vector3 NPFJDKHEONG()
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x60002BE")]
	[Cpp2IlInjected.Address(RVA = "0x7D46BD0", Offset = "0x7D45DD0", VA = "0x187D46BD0", Slot = "15")]
	public void FHGDKLHKFOG((Quaternion rot, Vector3 moments) KHCHKJFGKPL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002BF")]
	[Cpp2IlInjected.Address(RVA = "0x7D47370", Offset = "0x7D46570", VA = "0x187D47370")]
	private Quaternion MLEKGBMJCJH()
	{
		return default(Quaternion);
	}

	[Cpp2IlInjected.Token(Token = "0x60002C0")]
	[Cpp2IlInjected.Address(RVA = "0x7D45D60", Offset = "0x7D44F60", VA = "0x187D45D60")]
	public void FDADCDMFHHP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002C1")]
	[Cpp2IlInjected.Address(RVA = "0x7D45E30", Offset = "0x7D45030", VA = "0x187D45E30", Slot = "4")]
	public (float, Vector3) FDADCDMFHHP(Rigidbody CKOBDBBDLOM)
	{
		return default((float, Vector3));
	}
}
[Cpp2IlInjected.Token(Token = "0x200002E")]
internal static class KPBCKLHNCDH
{
	[Cpp2IlInjected.Token(Token = "0x60002C2")]
	[Cpp2IlInjected.Address(RVA = "0x7D3F440", Offset = "0x7D3E640", VA = "0x187D3F440")]
	public static EIMBMOJILIC BGPLNBOIALA(this CKJMPDKLOMB PIJKIPKKMLF)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200002F")]
internal sealed class BMLAHADCKMC : IBFNAGNBCEC
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000058")]
	private readonly KAECFEIKDHO DNNDAOFODNI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000059")]
	private readonly JIKBJNLDAIP GAGMPMDGOEP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400005A")]
	private readonly LEFFBPINKCP LJHEANDAHHF;

	[Cpp2IlInjected.Token(Token = "0x170000A8")]
	public bool EDCJGCDMDKH
	{
		[Cpp2IlInjected.Token(Token = "0x60002C3")]
		[Cpp2IlInjected.Address(RVA = "0x15EFB00", Offset = "0x15EED00", VA = "0x1815EFB00", Slot = "10")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A9")]
	public LEFFBPINKCP LFMDHLHEJLG
	{
		[Cpp2IlInjected.Token(Token = "0x60002C4")]
		[Cpp2IlInjected.Address(RVA = "0xAE2F30", Offset = "0xAE2130", VA = "0x180AE2F30", Slot = "11")]
		get
		{
			return default(LEFFBPINKCP);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60002C5")]
	[Cpp2IlInjected.Address(RVA = "0x7D32280", Offset = "0x7D31480", VA = "0x187D32280")]
	public BMLAHADCKMC(CKJMPDKLOMB DNNDAOFODNI, [In] DGPLBFHBGKJ LJELDKAOCJM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002C6")]
	[Cpp2IlInjected.Address(RVA = "0x7D31F30", Offset = "0x7D31130", VA = "0x187D31F30", Slot = "4")]
	public void FDAGCHPOHKC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002C7")]
	[Cpp2IlInjected.Address(RVA = "0x7D32000", Offset = "0x7D31200", VA = "0x187D32000")]
	private bool IHNNLOAHJMH()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002C8")]
	[Cpp2IlInjected.Address(RVA = "0x7D32120", Offset = "0x7D31320", VA = "0x187D32120", Slot = "5")]
	public void KPMBEOMNOIA(object GIIKHLJPAKH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002C9")]
	[Cpp2IlInjected.Address(RVA = "0x7D31D80", Offset = "0x7D30F80", VA = "0x187D31D80", Slot = "6")]
	public void AGCHPCIEIEC(object GIIKHLJPAKH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002CA")]
	[Cpp2IlInjected.Address(RVA = "0x7D32150", Offset = "0x7D31350", VA = "0x187D32150", Slot = "9")]
	public void OCLHAINEBJE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002CB")]
	[Cpp2IlInjected.Address(RVA = "0x7D31C70", Offset = "0x7D30E70", VA = "0x187D31C70")]
	private void AEPNIGNHEPM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002CC")]
	[Cpp2IlInjected.Address(RVA = "0x7D31DB0", Offset = "0x7D30FB0", VA = "0x187D31DB0")]
	private void BKDLGIMMNNO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002CD")]
	[Cpp2IlInjected.Address(RVA = "0x7D320A0", Offset = "0x7D312A0", VA = "0x187D320A0", Slot = "8")]
	public void KEPBPBJKDHG(CKJMPDKLOMB DNNDAOFODNI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002CE")]
	[Cpp2IlInjected.Address(RVA = "0x7D320E0", Offset = "0x7D312E0", VA = "0x187D320E0", Slot = "7")]
	public void KKLJEJCCIBB(CKJMPDKLOMB DNNDAOFODNI)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000030")]
internal sealed class LNONNAGECNF : JFEOOGHCIHI
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400005C")]
	private readonly KAECFEIKDHO DNNDAOFODNI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400005D")]
	private readonly JIKBJNLDAIP GBNBCGJNDLE;

	[Cpp2IlInjected.Token(Token = "0x170000AA")]
	public bool LKEJANPOONK
	{
		[Cpp2IlInjected.Token(Token = "0x60002D1")]
		[Cpp2IlInjected.Address(RVA = "0x7D40480", Offset = "0x7D3F680", VA = "0x187D40480", Slot = "6")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400002B")]
	public event ANFIDMOOJCO NEFPDKPJOAL
	{
		[Cpp2IlInjected.Token(Token = "0x60002CF")]
		[Cpp2IlInjected.Address(RVA = "0x7D40290", Offset = "0x7D3F490", VA = "0x187D40290", Slot = "4")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60002D0")]
		[Cpp2IlInjected.Address(RVA = "0x7D40580", Offset = "0x7D3F780", VA = "0x187D40580", Slot = "5")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60002D2")]
	[Cpp2IlInjected.Address(RVA = "0x7D40620", Offset = "0x7D3F820", VA = "0x187D40620")]
	public LNONNAGECNF(CKJMPDKLOMB DNNDAOFODNI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002D3")]
	[Cpp2IlInjected.Address(RVA = "0x7D40470", Offset = "0x7D3F670", VA = "0x187D40470", Slot = "7")]
	public void FMPPAEIAHHO(object GIIKHLJPAKH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002D4")]
	[Cpp2IlInjected.Address(RVA = "0x7D40570", Offset = "0x7D3F770", VA = "0x187D40570", Slot = "8")]
	public void LKIMICFGPLL(object GIIKHLJPAKH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002D5")]
	[Cpp2IlInjected.Address(RVA = "0x7D40330", Offset = "0x7D3F530", VA = "0x187D40330", Slot = "9")]
	public void DLOLCHGHDEA(object GIIKHLJPAKH, bool JLKOFADJBOL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002D6")]
	[Cpp2IlInjected.Address(RVA = "0x7D40530", Offset = "0x7D3F730", VA = "0x187D40530", Slot = "12")]
	public void IDALGDAFBCL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002D7")]
	[Cpp2IlInjected.Address(RVA = "0x7D40210", Offset = "0x7D3F410", VA = "0x187D40210", Slot = "10")]
	public void BLMKHJFKJDL(Rigidbody JOEOLIHHIPL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002D8")]
	[Cpp2IlInjected.Address(RVA = "0x7D40440", Offset = "0x7D3F640", VA = "0x187D40440", Slot = "11")]
	public void EFMMJPIOIHC(Rigidbody BACLJFFEIHG)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000031")]
internal sealed class JIKJDENPFNA : CDNGCDPKICN, POLKOCNOBCL, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400005F")]
	private readonly KAECFEIKDHO DNNDAOFODNI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000060")]
	private PhotonView PLMNOBPOJGD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000061")]
	private bool NAAGHFMKOBD;

	[Cpp2IlInjected.Token(Token = "0x170000AB")]
	public PhotonView DNNHDCAMIPH
	{
		[Cpp2IlInjected.Token(Token = "0x60002DB")]
		[Cpp2IlInjected.Address(RVA = "0x968CD0", Offset = "0x967ED0", VA = "0x180968CD0", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000AC")]
	public bool BLIMOKGJPKC
	{
		[Cpp2IlInjected.Token(Token = "0x60002DC")]
		[Cpp2IlInjected.Address(RVA = "0x7D36140", Offset = "0x7D35340", VA = "0x187D36140", Slot = "7")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000AD")]
	public bool FNOOOLDGFGB
	{
		[Cpp2IlInjected.Token(Token = "0x60002DD")]
		[Cpp2IlInjected.Address(RVA = "0xCE51A0", Offset = "0xCE43A0", VA = "0x180CE51A0", Slot = "8")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400002C")]
	public event ANFIDMOOJCO AIGMAFDIONK
	{
		[Cpp2IlInjected.Token(Token = "0x60002D9")]
		[Cpp2IlInjected.Address(RVA = "0x7D36420", Offset = "0x7D35620", VA = "0x187D36420", Slot = "5")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60002DA")]
		[Cpp2IlInjected.Address(RVA = "0x7D35E70", Offset = "0x7D35070", VA = "0x187D35E70", Slot = "6")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60002DE")]
	[Cpp2IlInjected.Address(RVA = "0x7D36A10", Offset = "0x7D35C10", VA = "0x187D36A10")]
	public JIKJDENPFNA(CKJMPDKLOMB DNNDAOFODNI, [In] DGPLBFHBGKJ LJELDKAOCJM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002DF")]
	[Cpp2IlInjected.Address(RVA = "0x7D36010", Offset = "0x7D35210", VA = "0x187D36010", Slot = "9")]
	public void FDAGCHPOHKC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002E0")]
	[Cpp2IlInjected.Address(RVA = "0x7D35F10", Offset = "0x7D35110", VA = "0x187D35F10", Slot = "12")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002E1")]
	[Cpp2IlInjected.Address(RVA = "0x7D36160", Offset = "0x7D35360", VA = "0x187D36160", Slot = "10")]
	public void JEPMDLHFCME(CKJMPDKLOMB JNGEIJHHFEP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002E2")]
	[Cpp2IlInjected.Address(RVA = "0x7D368A0", Offset = "0x7D35AA0", VA = "0x187D368A0", Slot = "11")]
	public void NLAHPALAEDE(CKJMPDKLOMB JNGEIJHHFEP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002E3")]
	[Cpp2IlInjected.Address(RVA = "0x7D36730", Offset = "0x7D35930", VA = "0x187D36730")]
	private void NHIGAMBELNN(PhotonView FFDDPEAADJH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002E4")]
	[Cpp2IlInjected.Address(RVA = "0x7D362D0", Offset = "0x7D354D0", VA = "0x187D362D0")]
	private void JMIOKMIAGPI(KCAMGMHDEDF PAENMOBEMOA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002E5")]
	[Cpp2IlInjected.Address(RVA = "0x7D364C0", Offset = "0x7D356C0", VA = "0x187D364C0")]
	private void MCPGCOFKKIP(PhotonView JCOEMOHMHDH)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000032")]
internal static class ILNFOGFCKCP
{
	[Cpp2IlInjected.Token(Token = "0x60002E6")]
	[Cpp2IlInjected.Address(RVA = "0x7D35040", Offset = "0x7D34240", VA = "0x187D35040")]
	public static CDNGCDPKICN GBIFDMBFEDE(this CKJMPDKLOMB PIJKIPKKMLF)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000033")]
internal sealed class JPNAGFELHJK : GEMAAJCHLNE
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000062")]
	private readonly KAECFEIKDHO DNNDAOFODNI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000063")]
	private RigidbodyConstraints PNGJLDCFDLM;

	[Cpp2IlInjected.Token(Token = "0x170000AE")]
	public bool MFEJOIIBKHM
	{
		[Cpp2IlInjected.Token(Token = "0x60002E7")]
		[Cpp2IlInjected.Address(RVA = "0x9BF700", Offset = "0x9BE900", VA = "0x1809BF700", Slot = "4")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x60002E8")]
		[Cpp2IlInjected.Address(RVA = "0xC00B70", Offset = "0xBFFD70", VA = "0x180C00B70", Slot = "5")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000AF")]
	public bool GCIONGIHOKF
	{
		[Cpp2IlInjected.Token(Token = "0x60002E9")]
		[Cpp2IlInjected.Address(RVA = "0xC00470", Offset = "0xBFF670", VA = "0x180C00470", Slot = "6")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x60002EA")]
		[Cpp2IlInjected.Address(RVA = "0xC00820", Offset = "0xBFFA20", VA = "0x180C00820")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B0")]
	public RigidbodyConstraints KCNPLOGDIDF
	{
		[Cpp2IlInjected.Token(Token = "0x60002EB")]
		[Cpp2IlInjected.Address(RVA = "0x96C090", Offset = "0x96B290", VA = "0x18096C090", Slot = "7")]
		get
		{
			return default(RigidbodyConstraints);
		}
		[Cpp2IlInjected.Token(Token = "0x60002EC")]
		[Cpp2IlInjected.Address(RVA = "0x7D38A60", Offset = "0x7D37C60", VA = "0x187D38A60", Slot = "8")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60002ED")]
	[Cpp2IlInjected.Address(RVA = "0x7D38BC0", Offset = "0x7D37DC0", VA = "0x187D38BC0")]
	public JPNAGFELHJK(CKJMPDKLOMB DNNDAOFODNI, [In] DGPLBFHBGKJ LJELDKAOCJM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002EE")]
	[Cpp2IlInjected.Address(RVA = "0x7D38A30", Offset = "0x7D37C30", VA = "0x187D38A30", Slot = "9")]
	public void BLMKHJFKJDL(Rigidbody BACLJFFEIHG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002EF")]
	[Cpp2IlInjected.Address(RVA = "0x7D38B90", Offset = "0x7D37D90", VA = "0x187D38B90", Slot = "10")]
	public void EFMMJPIOIHC(Rigidbody BACLJFFEIHG)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000034")]
internal sealed class DKKNJKDAPBB : ADHJHKNEOEF
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000066")]
	private readonly CKJMPDKLOMB DNNDAOFODNI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000067")]
	private float MCIFMMODLGH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
	[Cpp2IlInjected.Token(Token = "0x4000068")]
	private float FICKOBECBPI;

	[Cpp2IlInjected.Token(Token = "0x170000B1")]
	public float BAOFHKJJLLL
	{
		[Cpp2IlInjected.Token(Token = "0x60002F1")]
		[Cpp2IlInjected.Address(RVA = "0xDE8360", Offset = "0xDE7560", VA = "0x180DE8360", Slot = "4")]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x60002F2")]
		[Cpp2IlInjected.Address(RVA = "0x7D335C0", Offset = "0x7D327C0", VA = "0x187D335C0", Slot = "5")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B2")]
	public float PJDENCJDHGI
	{
		[Cpp2IlInjected.Token(Token = "0x60002F3")]
		[Cpp2IlInjected.Address(RVA = "0xC30C00", Offset = "0xC2FE00", VA = "0x180C30C00", Slot = "6")]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x60002F4")]
		[Cpp2IlInjected.Address(RVA = "0x7D33400", Offset = "0x7D32600", VA = "0x187D33400", Slot = "7")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60002F0")]
	[Cpp2IlInjected.Address(RVA = "0x7D33690", Offset = "0x7D32890", VA = "0x187D33690")]
	public DKKNJKDAPBB(CKJMPDKLOMB DNNDAOFODNI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002F5")]
	[Cpp2IlInjected.Address(RVA = "0x7D334D0", Offset = "0x7D326D0", VA = "0x187D334D0", Slot = "8")]
	public void BLMKHJFKJDL(Rigidbody BACLJFFEIHG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002F6")]
	[Cpp2IlInjected.Address(RVA = "0x7D33520", Offset = "0x7D32720", VA = "0x187D33520", Slot = "9")]
	public void EFMMJPIOIHC(Rigidbody BACLJFFEIHG)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000035")]
internal sealed class LGOOPGJLBHB : BPMNKEMAIHH
{
	[Cpp2IlInjected.Token(Token = "0x4000069")]
	private static readonly PBBCGFNIILA CFNEGJKHFCA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400006B")]
	private readonly KAECFEIKDHO DNNDAOFODNI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400006C")]
	private bool ICJBCCGAEIN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x21")]
	[Cpp2IlInjected.Token(Token = "0x400006D")]
	private bool JOKAEEEOFNF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
	[Cpp2IlInjected.Token(Token = "0x400006E")]
	private int MNGLDPMDNMC;

	[Cpp2IlInjected.Token(Token = "0x170000B3")]
	private Rigidbody KEAOKJKIGHN
	{
		[Cpp2IlInjected.Token(Token = "0x60002F9")]
		[Cpp2IlInjected.Address(RVA = "0x7D3F5A0", Offset = "0x7D3E7A0", VA = "0x187D3F5A0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B4")]
	private bool NPKFIIPKOFH
	{
		[Cpp2IlInjected.Token(Token = "0x60002FA")]
		[Cpp2IlInjected.Address(RVA = "0x7D40020", Offset = "0x7D3F220", VA = "0x187D40020")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B5")]
	private CKJMPDKLOMB JCHDMDCGBIH
	{
		[Cpp2IlInjected.Token(Token = "0x60002FB")]
		[Cpp2IlInjected.Address(RVA = "0x7D3FFC0", Offset = "0x7D3F1C0", VA = "0x187D3FFC0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B6")]
	private bool JBNFKMDMFCO
	{
		[Cpp2IlInjected.Token(Token = "0x60002FC")]
		[Cpp2IlInjected.Address(RVA = "0x7D3FBA0", Offset = "0x7D3EDA0", VA = "0x187D3FBA0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400002D")]
	public event ANFIDMOOJCO APJENHCGJLH
	{
		[Cpp2IlInjected.Token(Token = "0x60002F7")]
		[Cpp2IlInjected.Address(RVA = "0x7D3FB00", Offset = "0x7D3ED00", VA = "0x187D3FB00", Slot = "4")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60002F8")]
		[Cpp2IlInjected.Address(RVA = "0x7D3FD20", Offset = "0x7D3EF20", VA = "0x187D3FD20", Slot = "5")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60002FD")]
	[Cpp2IlInjected.Address(RVA = "0x7D40180", Offset = "0x7D3F380", VA = "0x187D40180")]
	public LGOOPGJLBHB(CKJMPDKLOMB DNNDAOFODNI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002FE")]
	[Cpp2IlInjected.Address(RVA = "0x7D3FA60", Offset = "0x7D3EC60", VA = "0x187D3FA60", Slot = "6")]
	public void FDAGCHPOHKC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002FF")]
	[Cpp2IlInjected.Address(RVA = "0x7D3FAF0", Offset = "0x7D3ECF0", VA = "0x187D3FAF0", Slot = "8")]
	public void FHAEAPPLIDM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000300")]
	[Cpp2IlInjected.Address(RVA = "0x7D3F870", Offset = "0x7D3EA70", VA = "0x187D3F870", Slot = "7")]
	public bool DCDDBIEDDNG()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000301")]
	[Cpp2IlInjected.Address(RVA = "0x7D3F500", Offset = "0x7D3E700", VA = "0x187D3F500", Slot = "9")]
	public void AFFNBFKGAPM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000302")]
	[Cpp2IlInjected.Address(RVA = "0x7D3F9C0", Offset = "0x7D3EBC0", VA = "0x187D3F9C0", Slot = "13")]
	public void EDLHJIOFNMN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000303")]
	[Cpp2IlInjected.Address(RVA = "0x7D3FC00", Offset = "0x7D3EE00", VA = "0x187D3FC00", Slot = "12")]
	public void IFBEIMHGLKG(bool ENJLDNELDJJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000304")]
	[Cpp2IlInjected.Address(RVA = "0x7D3FF50", Offset = "0x7D3F150", VA = "0x187D3FF50", Slot = "10")]
	public bool LODEJKKCAFE()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000305")]
	[Cpp2IlInjected.Address(RVA = "0x7D40040", Offset = "0x7D3F240", VA = "0x187D40040", Slot = "11")]
	public bool NIBLJJDOGFD()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000306")]
	[Cpp2IlInjected.Address(RVA = "0x7D3F5F0", Offset = "0x7D3E7F0", VA = "0x187D3F5F0")]
	private bool BBKJGCCNEBB()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000307")]
	[Cpp2IlInjected.Address(RVA = "0x7D3FDC0", Offset = "0x7D3EFC0", VA = "0x187D3FDC0")]
	private void LBPJCLLCAJP()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000036")]
internal sealed class NFKBLNEEHMM : EJHGNIPCIFI
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400006F")]
	private readonly KAECFEIKDHO DNNDAOFODNI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000070")]
	private readonly JIKBJNLDAIP BFAPDFLFLNF;

	[Cpp2IlInjected.Token(Token = "0x170000B7")]
	public Rigidbody KEAOKJKIGHN
	{
		[Cpp2IlInjected.Token(Token = "0x6000309")]
		[Cpp2IlInjected.Address(RVA = "0x968CD0", Offset = "0x967ED0", VA = "0x180968CD0", Slot = "4")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600030A")]
		[Cpp2IlInjected.Address(RVA = "0x9642B0", Offset = "0x9634B0", VA = "0x1809642B0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B8")]
	private bool JBNFKMDMFCO
	{
		[Cpp2IlInjected.Token(Token = "0x600030B")]
		[Cpp2IlInjected.Address(RVA = "0x7D35510", Offset = "0x7D34710", VA = "0x187D35510")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B9")]
	public bool APIHOHPOAGF
	{
		[Cpp2IlInjected.Token(Token = "0x600030E")]
		[Cpp2IlInjected.Address(RVA = "0x15EFB00", Offset = "0x15EED00", VA = "0x1815EFB00", Slot = "6")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600030C")]
	[Cpp2IlInjected.Address(RVA = "0x7D44660", Offset = "0x7D43860", VA = "0x187D44660")]
	public NFKBLNEEHMM(CKJMPDKLOMB DNNDAOFODNI, [In] DGPLBFHBGKJ LJELDKAOCJM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600030D")]
	[Cpp2IlInjected.Address(RVA = "0x7D440A0", Offset = "0x7D432A0", VA = "0x187D440A0", Slot = "5")]
	public void FDAGCHPOHKC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600030F")]
	[Cpp2IlInjected.Address(RVA = "0x7D44070", Offset = "0x7D43270", VA = "0x187D44070", Slot = "7")]
	public void DEHNLJMHHPM(object GIIKHLJPAKH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000310")]
	[Cpp2IlInjected.Address(RVA = "0x7D43EC0", Offset = "0x7D430C0", VA = "0x187D43EC0", Slot = "8")]
	public void CAIPKAIMHNB(object GIIKHLJPAKH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000311")]
	[Cpp2IlInjected.Address(RVA = "0x7D44140", Offset = "0x7D43340", VA = "0x187D44140", Slot = "9")]
	public void FILEJHDMKAE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000312")]
	[Cpp2IlInjected.Address(RVA = "0x7D44470", Offset = "0x7D43670", VA = "0x187D44470", Slot = "10")]
	public void HGDNPKEJMMP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000313")]
	[Cpp2IlInjected.Address(RVA = "0x7D43EF0", Offset = "0x7D430F0", VA = "0x187D43EF0", Slot = "11")]
	public void DAPFFHDPNEK()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000037")]
internal sealed class NCMNBGDNCPL : IGMBHHEALAJ, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000072")]
	private readonly KAECFEIKDHO DNNDAOFODNI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000073")]
	private readonly JIKBJNLDAIP FDIMIGBEHLG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000074")]
	private float PKAPLPGPEAP;

	[Cpp2IlInjected.Token(Token = "0x170000BA")]
	public BFHLICCPHMB AOEDIBNPEPP
	{
		[Cpp2IlInjected.Token(Token = "0x6000314")]
		[Cpp2IlInjected.Address(RVA = "0x964CD0", Offset = "0x963ED0", VA = "0x180964CD0", Slot = "4")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000315")]
		[Cpp2IlInjected.Address(RVA = "0x968CF0", Offset = "0x967EF0", VA = "0x180968CF0", Slot = "5")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000BB")]
	public CBFNNFFIFKO AFFAHABPJCD
	{
		[Cpp2IlInjected.Token(Token = "0x6000316")]
		[Cpp2IlInjected.Address(RVA = "0x964EC0", Offset = "0x9640C0", VA = "0x180964EC0", Slot = "6")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000317")]
		[Cpp2IlInjected.Address(RVA = "0x968CE0", Offset = "0x967EE0", VA = "0x180968CE0", Slot = "7")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000BC")]
	public Vector3 MGLKIJIEAAJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000318")]
		[Cpp2IlInjected.Address(RVA = "0x7D43630", Offset = "0x7D42830", VA = "0x187D43630", Slot = "8")]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x6000319")]
		[Cpp2IlInjected.Address(RVA = "0x7D40D50", Offset = "0x7D3FF50", VA = "0x187D40D50", Slot = "9")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000BD")]
	public Vector3 NNMOGOHKDHI
	{
		[Cpp2IlInjected.Token(Token = "0x600031A")]
		[Cpp2IlInjected.Address(RVA = "0x7D43510", Offset = "0x7D42710", VA = "0x187D43510", Slot = "10")]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x600031B")]
		[Cpp2IlInjected.Address(RVA = "0x7D41960", Offset = "0x7D40B60", VA = "0x187D41960", Slot = "11")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000BE")]
	public Vector3 LINIIKOHKID
	{
		[Cpp2IlInjected.Token(Token = "0x600031C")]
		[Cpp2IlInjected.Address(RVA = "0x7D428B0", Offset = "0x7D41AB0", VA = "0x187D428B0", Slot = "12")]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x600031D")]
		[Cpp2IlInjected.Address(RVA = "0x7D432A0", Offset = "0x7D424A0", VA = "0x187D432A0", Slot = "13")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000BF")]
	public Vector3 LNPMAIDJHPD
	{
		[Cpp2IlInjected.Token(Token = "0x600031E")]
		[Cpp2IlInjected.Address(RVA = "0x7D40FC0", Offset = "0x7D401C0", VA = "0x187D40FC0", Slot = "14")]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x600031F")]
		[Cpp2IlInjected.Address(RVA = "0x7D40F90", Offset = "0x7D40190", VA = "0x187D40F90", Slot = "15")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000C0")]
	public float NBJCJLCNJOA
	{
		[Cpp2IlInjected.Token(Token = "0x6000320")]
		[Cpp2IlInjected.Address(RVA = "0xEFE650", Offset = "0xEFD850", VA = "0x180EFE650", Slot = "16")]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x6000321")]
		[Cpp2IlInjected.Address(RVA = "0x7D43CC0", Offset = "0x7D42EC0", VA = "0x187D43CC0", Slot = "17")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000C1")]
	public bool HFBNJKFPMNO
	{
		[Cpp2IlInjected.Token(Token = "0x6000322")]
		[Cpp2IlInjected.Address(RVA = "0x1F21780", Offset = "0x1F20980", VA = "0x181F21780", Slot = "18")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000C2")]
	private OGJJKEJPFIP PEALAOAEOKG
	{
		[Cpp2IlInjected.Token(Token = "0x6000337")]
		[Cpp2IlInjected.Address(RVA = "0x73BD830", Offset = "0x73BCA30", VA = "0x1873BD830")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000C3")]
	private bool NPKFIIPKOFH
	{
		[Cpp2IlInjected.Token(Token = "0x6000338")]
		[Cpp2IlInjected.Address(RVA = "0x7D43360", Offset = "0x7D42560", VA = "0x187D43360")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000323")]
	[Cpp2IlInjected.Address(RVA = "0x7D43DD0", Offset = "0x7D42FD0", VA = "0x187D43DD0")]
	public NCMNBGDNCPL(CKJMPDKLOMB DNNDAOFODNI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000324")]
	[Cpp2IlInjected.Address(RVA = "0x7D410E0", Offset = "0x7D402E0", VA = "0x187D410E0", Slot = "19")]
	public void FDAGCHPOHKC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000325")]
	[Cpp2IlInjected.Address(RVA = "0x7D40F30", Offset = "0x7D40130", VA = "0x187D40F30", Slot = "36")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000326")]
	[Cpp2IlInjected.Address(RVA = "0x7D408D0", Offset = "0x7D3FAD0", VA = "0x187D408D0", Slot = "28")]
	public void BLMKHJFKJDL(Rigidbody BACLJFFEIHG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000327")]
	[Cpp2IlInjected.Address(RVA = "0x140F830", Offset = "0x140EA30", VA = "0x18140F830", Slot = "20")]
	public void PCEHOGBLKOL(object GIIKHLJPAKH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000328")]
	[Cpp2IlInjected.Address(RVA = "0x140FFF0", Offset = "0x140F1F0", VA = "0x18140FFF0", Slot = "30")]
	public void GJBPCDOOGMP(object GIIKHLJPAKH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000329")]
	[Cpp2IlInjected.Address(RVA = "0x7D426D0", Offset = "0x7D418D0", VA = "0x187D426D0", Slot = "35")]
	public Vector3 JKHBDNCKEGL(Vector3 AAKCIEGFLNF)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x600032A")]
	[Cpp2IlInjected.Address(RVA = "0x7D41180", Offset = "0x7D40380", VA = "0x187D41180", Slot = "34")]
	public Vector3 FELFDHGKHDD(Vector3 BFOLNOABHKB)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x600032B")]
	[Cpp2IlInjected.Address(RVA = "0x7D410E0", Offset = "0x7D402E0", VA = "0x187D410E0", Slot = "27")]
	public void ICKLMBKHLNB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600032C")]
	[Cpp2IlInjected.Address(RVA = "0x7D43C60", Offset = "0x7D42E60", VA = "0x187D43C60", Slot = "25")]
	public void OLKLJJKHDOH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600032D")]
	[Cpp2IlInjected.Address(RVA = "0x7D43780", Offset = "0x7D42980", VA = "0x187D43780", Slot = "24")]
	public void OHIOFHIMLDG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600032E")]
	[Cpp2IlInjected.Address(RVA = "0x7D40B10", Offset = "0x7D3FD10", VA = "0x187D40B10", Slot = "33")]
	public void DEFHNFILHJC(Vector3 GPBKAKMKHHM, Vector3 CJJEMCCDFKF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600032F")]
	[Cpp2IlInjected.Address(RVA = "0x7D42590", Offset = "0x7D41790", VA = "0x187D42590", Slot = "32")]
	public void IHODMGNEJAO(Vector3 EHHEGNBIEBF, Vector3 GGKILDCFAHO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000330")]
	[Cpp2IlInjected.Address(RVA = "0x7D417C0", Offset = "0x7D409C0", VA = "0x187D417C0", Slot = "31")]
	public void FNBNJEBEFOJ(Vector3 LGFGPHBEJIO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000331")]
	[Cpp2IlInjected.Address(RVA = "0x7D41F40", Offset = "0x7D41140", VA = "0x187D41F40", Slot = "22")]
	public void HKCDEAAELIK(HPMAFJLKFHL DLNHIMPFAMK, Vector3 HOBENLNNBJG, float LOFOCKIMDHE, float ECNCFDJFMHJ = 8f, float LLFECLGOEJE = 1f)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000332")]
	[Cpp2IlInjected.Address(RVA = "0x7D43020", Offset = "0x7D42220", VA = "0x187D43020", Slot = "21")]
	public void LKMPMGIBDNM(GOPIKNGHAGE GAEKIHMGGAN, Vector3 EBGAHGHEICN, float EINHNGGOAIG = float.PositiveInfinity)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000333")]
	[Cpp2IlInjected.Address(RVA = "0x7D437E0", Offset = "0x7D429E0", VA = "0x187D437E0", Slot = "23")]
	[Obsolete("Deprecated. Still exists to support deprecated CV2 chips. Use ApplyAngularVelocityChange.")]
	public void OIHHHPKKKKF(GOPIKNGHAGE GAEKIHMGGAN, Vector3 GLMEOLPKLCA, float EAFFEBJLAEN = 7f, float GJPEDKJKDLO = 1f)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000334")]
	[Cpp2IlInjected.Address(RVA = "0x1546950", Offset = "0x1545B50", VA = "0x181546950")]
	private static void MKFFBNDEELP(Vector3 DMAMLJEEFCB, Vector3 HFFGEMAKAAC, [Out] Vector3 MGIJLLGPFBK, [Out] Vector3 DAEFLMCMLLO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000335")]
	[Cpp2IlInjected.Address(RVA = "0x7D425F0", Offset = "0x7D417F0", VA = "0x187D425F0", Slot = "29")]
	public Vector3 IMKIACFAHNG(Vector3 DMAMLJEEFCB)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000336")]
	[Cpp2IlInjected.Address(RVA = "0x7D43380", Offset = "0x7D42580", VA = "0x187D43380", Slot = "26")]
	public void MKAELLFKLCE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000339")]
	[Cpp2IlInjected.Address(RVA = "0x7D43CC0", Offset = "0x7D42EC0", VA = "0x187D43CC0")]
	private void PIBCFCDGMPG(float OMFJNFBDJCA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600033A")]
	[Cpp2IlInjected.Address(RVA = "0x7D42A00", Offset = "0x7D41C00", VA = "0x187D42A00")]
	private void KOMKDLCIKIK(Vector3 EBGAHGHEICN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600033B")]
	[Cpp2IlInjected.Address(RVA = "0x7D40A00", Offset = "0x7D3FC00", VA = "0x187D40A00")]
	private Vector3 DAGINJEDFCI()
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x600033C")]
	[Cpp2IlInjected.Address(RVA = "0x7D41340", Offset = "0x7D40540", VA = "0x187D41340")]
	private void FGMFFDKCPAJ(Vector3 BFOLNOABHKB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600033D")]
	[Cpp2IlInjected.Address(RVA = "0x7D40E10", Offset = "0x7D40010", VA = "0x187D40E10")]
	private Vector3 DJCLAOEEIOL()
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x600033E")]
	[Cpp2IlInjected.Address(RVA = "0x7D42BA0", Offset = "0x7D41DA0", VA = "0x187D42BA0")]
	private void LFEOHNENEKB(Vector3 OMFJNFBDJCA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600033F")]
	[Cpp2IlInjected.Address(RVA = "0x7D41990", Offset = "0x7D40B90", VA = "0x187D41990")]
	private void HDJPBKAPKGJ(Vector3 BFOLNOABHKB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000340")]
	[Cpp2IlInjected.Address(RVA = "0x7D40820", Offset = "0x7D3FA20", VA = "0x187D40820")]
	private void ANNDLOKNLOF()
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
