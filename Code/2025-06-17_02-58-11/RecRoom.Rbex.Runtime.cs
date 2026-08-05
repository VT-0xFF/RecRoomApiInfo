using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Cpp2IlInjected;
using RecRoom;
using RecRoom.DataLayer.Attributes;
using RecRoom.DataLayer.Registration;
using RecRoom.Logging.Attributes;
using RecRoom.Networking;
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
	public class LogRegistrationIndex : GIIBELOIOJI
	{
		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(RVA = "0x852E9F0", Offset = "0x852D3F0", VA = "0x18852E9F0", Slot = "4")]
		public override void EPIAMCEAEFP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0xA34C70", Offset = "0xA33670", VA = "0x180A34C70")]
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
			[Cpp2IlInjected.Address(RVA = "0xA0A790", Offset = "0xA09190", VA = "0x180A0A790", Slot = "4")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x7F02850", Offset = "0x7F01250", VA = "0x187F02850", Slot = "5")]
		public override void SetServiceCategoryIndices(List<int> globalFromLocalIndices)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x8540D90", Offset = "0x853F790", VA = "0x188540D90")]
		private void LNHKNJMKPNK(IServiceRegistration registry)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x85410A0", Offset = "0x853FAA0", VA = "0x1885410A0", Slot = "6")]
		public override void RegisterServices(IServiceRegistration registry, [In] ServiceBitsetFilter filter)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x8541100", Offset = "0x853FB00", VA = "0x188541100")]
		public _AssemblyIndex()
		{
		}
	}
}
namespace RecRoom
{
	[Cpp2IlInjected.Token(Token = "0x2000004")]
	[DisallowMultipleComponent]
	public sealed class RigidbodyEx : MonoBehaviour, LEOFMIOLMNC, INBJDGLCFFF, ABMABIKDNCI
	{
		[Cpp2IlInjected.Token(Token = "0x4000004")]
		private static readonly COJJKFBGGKB BGBEHIABHEE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000005")]
		private bool MDEMHAMGCHI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000006")]
		private CKPEEOMOJJI OIADCONCFNI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000007")]
		[POCNOCJDEIG(MEAOHOOOBOD.Self, false, false, false)]
		[SerializeField]
		private Rigidbody unityRigidbody;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000008")]
		[SerializeField]
		[POCNOCJDEIG(MEAOHOOOBOD.SelfAndParent, true, false, false)]
		private RRNetworkView rrNetworkView;

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
		private DLKLAKEEKHP physicsInterpolation;

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
		private Transform CMKLAJBMKMI;

		[Cpp2IlInjected.Token(Token = "0x17000002")]
		internal CKPEEOMOJJI IDBKNKJEPDG
		{
			[Cpp2IlInjected.Token(Token = "0x6000008")]
			[Cpp2IlInjected.Address(RVA = "0x853C940", Offset = "0x853B340", VA = "0x18853C940")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000003")]
		private CKPEEOMOJJI GAFCKDJACAE
		{
			[Cpp2IlInjected.Token(Token = "0x6000009")]
			[Cpp2IlInjected.Address(RVA = "0xA0A780", Offset = "0xA09180", VA = "0x180A0A780", Slot = "6")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000004")]
		public int FDCEHJBFHFJ
		{
			[Cpp2IlInjected.Token(Token = "0x600001E")]
			[Cpp2IlInjected.Address(RVA = "0x853E2A0", Offset = "0x853CCA0", VA = "0x18853E2A0")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000005")]
		public RigidbodyEx KLJNDALEIIA
		{
			[Cpp2IlInjected.Token(Token = "0x6000020")]
			[Cpp2IlInjected.Address(RVA = "0x853E600", Offset = "0x853D000", VA = "0x18853E600")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000006")]
		public RigidbodyEx PFOPMMBCMFB
		{
			[Cpp2IlInjected.Token(Token = "0x6000021")]
			[Cpp2IlInjected.Address(RVA = "0x853E540", Offset = "0x853CF40", VA = "0x18853E540")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000007")]
		public RigidbodyEx EAGGHBKHKHF
		{
			[Cpp2IlInjected.Token(Token = "0x6000022")]
			[Cpp2IlInjected.Address(RVA = "0x853F200", Offset = "0x853DC00", VA = "0x18853F200")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000023")]
			[Cpp2IlInjected.Address(RVA = "0x8540700", Offset = "0x853F100", VA = "0x188540700")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000008")]
		public bool JBBKFJFGMPG
		{
			[Cpp2IlInjected.Token(Token = "0x6000024")]
			[Cpp2IlInjected.Address(RVA = "0x816D440", Offset = "0x816BE40", VA = "0x18816D440", Slot = "11")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000025")]
			[Cpp2IlInjected.Address(RVA = "0x816F240", Offset = "0x816DC40", VA = "0x18816F240")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000009")]
		public Transform MNINMACDPEC
		{
			[Cpp2IlInjected.Token(Token = "0x6000026")]
			[Cpp2IlInjected.Address(RVA = "0x237DCA0", Offset = "0x237C6A0", VA = "0x18237DCA0", Slot = "5")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000A")]
		public Transform HPBJPFAMMGO
		{
			[Cpp2IlInjected.Token(Token = "0x6000027")]
			[Cpp2IlInjected.Address(RVA = "0x237DCA0", Offset = "0x237C6A0", VA = "0x18237DCA0", Slot = "14")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000B")]
		public Transform IAACOHLGKNG
		{
			[Cpp2IlInjected.Token(Token = "0x6000028")]
			[Cpp2IlInjected.Address(RVA = "0x237DCA0", Offset = "0x237C6A0", VA = "0x18237DCA0", Slot = "15")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000C")]
		public BJFKEGNANDB DNEPNLLILDF
		{
			[Cpp2IlInjected.Token(Token = "0x6000029")]
			[Cpp2IlInjected.Address(RVA = "0x853E300", Offset = "0x853CD00", VA = "0x18853E300")]
			get
			{
				return default(BJFKEGNANDB);
			}
			[Cpp2IlInjected.Token(Token = "0x600002A")]
			[Cpp2IlInjected.Address(RVA = "0x853FEB0", Offset = "0x853E8B0", VA = "0x18853FEB0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000D")]
		public bool BEOAIADIFDD
		{
			[Cpp2IlInjected.Token(Token = "0x600002B")]
			[Cpp2IlInjected.Address(RVA = "0x853E910", Offset = "0x853D310", VA = "0x18853E910")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000E")]
		public bool DHDBIEJCKNP
		{
			[Cpp2IlInjected.Token(Token = "0x600002C")]
			[Cpp2IlInjected.Address(RVA = "0x853E420", Offset = "0x853CE20", VA = "0x18853E420")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000F")]
		public FJBHJEKKKOJ ALHFICIODDP
		{
			[Cpp2IlInjected.Token(Token = "0x600002D")]
			[Cpp2IlInjected.Address(RVA = "0x853E850", Offset = "0x853D250", VA = "0x18853E850")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600002E")]
			[Cpp2IlInjected.Address(RVA = "0x8540070", Offset = "0x853EA70", VA = "0x188540070")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000010")]
		public MMGNDNMMIBP MMLKKGELJEN
		{
			[Cpp2IlInjected.Token(Token = "0x600002F")]
			[Cpp2IlInjected.Address(RVA = "0x853E7F0", Offset = "0x853D1F0", VA = "0x18853E7F0")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000030")]
			[Cpp2IlInjected.Address(RVA = "0x8540000", Offset = "0x853EA00", VA = "0x188540000")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000011")]
		public bool LNCPBHDEHDJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000031")]
			[Cpp2IlInjected.Address(RVA = "0x853E740", Offset = "0x853D140", VA = "0x18853E740")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000012")]
		public Rigidbody NJDIIBKCONL
		{
			[Cpp2IlInjected.Token(Token = "0x6000032")]
			[Cpp2IlInjected.Address(RVA = "0x853E7A0", Offset = "0x853D1A0", VA = "0x18853E7A0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000013")]
		public bool GMGDAJFJIKK
		{
			[Cpp2IlInjected.Token(Token = "0x6000033")]
			[Cpp2IlInjected.Address(RVA = "0x853E480", Offset = "0x853CE80", VA = "0x18853E480")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000034")]
			[Cpp2IlInjected.Address(RVA = "0x853FF20", Offset = "0x853E920", VA = "0x18853FF20")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000014")]
		public bool IJDOOGJJFKO
		{
			[Cpp2IlInjected.Token(Token = "0x6000035")]
			[Cpp2IlInjected.Address(RVA = "0x816F250", Offset = "0x816DC50", VA = "0x18816F250", Slot = "7")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000015")]
		public float BNIEPIJDCPA
		{
			[Cpp2IlInjected.Token(Token = "0x6000036")]
			[Cpp2IlInjected.Address(RVA = "0x853F1A0", Offset = "0x853DBA0", VA = "0x18853F1A0")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000016")]
		public float GEINHDPPGIL
		{
			[Cpp2IlInjected.Token(Token = "0x6000037")]
			[Cpp2IlInjected.Address(RVA = "0x853F140", Offset = "0x853DB40", VA = "0x18853F140")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x6000038")]
			[Cpp2IlInjected.Address(RVA = "0x8540690", Offset = "0x853F090", VA = "0x188540690")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000017")]
		public float GBIPHNOKDIJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000039")]
			[Cpp2IlInjected.Address(RVA = "0x853EB70", Offset = "0x853D570", VA = "0x18853EB70")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x600003A")]
			[Cpp2IlInjected.Address(RVA = "0x8540310", Offset = "0x853ED10", VA = "0x188540310")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000018")]
		public float FAKMAGJHOJC
		{
			[Cpp2IlInjected.Token(Token = "0x600003B")]
			[Cpp2IlInjected.Address(RVA = "0x853E970", Offset = "0x853D370", VA = "0x18853E970")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x600003C")]
			[Cpp2IlInjected.Address(RVA = "0x85400E0", Offset = "0x853EAE0", VA = "0x1885400E0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000019")]
		public bool OMNBALCEKDE
		{
			[Cpp2IlInjected.Token(Token = "0x600003D")]
			[Cpp2IlInjected.Address(RVA = "0x853F750", Offset = "0x853E150", VA = "0x18853F750")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x600003E")]
			[Cpp2IlInjected.Address(RVA = "0x8540C40", Offset = "0x853F640", VA = "0x188540C40")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001A")]
		public Vector3 DOOLDDCAJJJ
		{
			[Cpp2IlInjected.Token(Token = "0x600003F")]
			[Cpp2IlInjected.Address(RVA = "0x853EF20", Offset = "0x853D920", VA = "0x18853EF20")]
			get
			{
				return default(Vector3);
			}
			[Cpp2IlInjected.Token(Token = "0x6000040")]
			[Cpp2IlInjected.Address(RVA = "0x8540460", Offset = "0x853EE60", VA = "0x188540460")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001B")]
		public Vector3 FEHFLDNKBCE
		{
			[Cpp2IlInjected.Token(Token = "0x6000041")]
			[Cpp2IlInjected.Address(RVA = "0x853F890", Offset = "0x853E290", VA = "0x18853F890")]
			get
			{
				return default(Vector3);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001C")]
		public CollisionDetectionMode KBAFALPBBPN
		{
			[Cpp2IlInjected.Token(Token = "0x6000042")]
			[Cpp2IlInjected.Address(RVA = "0x853EAB0", Offset = "0x853D4B0", VA = "0x18853EAB0")]
			get
			{
				return default(CollisionDetectionMode);
			}
			[Cpp2IlInjected.Token(Token = "0x6000043")]
			[Cpp2IlInjected.Address(RVA = "0x8540230", Offset = "0x853EC30", VA = "0x188540230")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001D")]
		public float MJKJLPBOFLN
		{
			[Cpp2IlInjected.Token(Token = "0x6000044")]
			[Cpp2IlInjected.Address(RVA = "0x853E4E0", Offset = "0x853CEE0", VA = "0x18853E4E0")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x6000045")]
			[Cpp2IlInjected.Address(RVA = "0x853FF90", Offset = "0x853E990", VA = "0x18853FF90")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001E")]
		public RigidbodyConstraints NCCGHLDKGBC
		{
			[Cpp2IlInjected.Token(Token = "0x6000046")]
			[Cpp2IlInjected.Address(RVA = "0x853EB10", Offset = "0x853D510", VA = "0x18853EB10")]
			get
			{
				return default(RigidbodyConstraints);
			}
			[Cpp2IlInjected.Token(Token = "0x6000047")]
			[Cpp2IlInjected.Address(RVA = "0x85402A0", Offset = "0x853ECA0", VA = "0x1885402A0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001F")]
		public Vector3 MGCJADMCPEN
		{
			[Cpp2IlInjected.Token(Token = "0x6000048")]
			[Cpp2IlInjected.Address(RVA = "0x853F2C0", Offset = "0x853DCC0", VA = "0x18853F2C0")]
			get
			{
				return default(Vector3);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000020")]
		public Vector3 IKLPKDEGHEG
		{
			[Cpp2IlInjected.Token(Token = "0x6000049")]
			[Cpp2IlInjected.Address(RVA = "0x853F2C0", Offset = "0x853DCC0", VA = "0x18853F2C0")]
			get
			{
				return default(Vector3);
			}
			[Cpp2IlInjected.Token(Token = "0x600004A")]
			[Cpp2IlInjected.Address(RVA = "0x8540A20", Offset = "0x853F420", VA = "0x188540A20")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000021")]
		public float MHEMELNGBHJ
		{
			[Cpp2IlInjected.Token(Token = "0x600004B")]
			[Cpp2IlInjected.Address(RVA = "0x853F000", Offset = "0x853DA00", VA = "0x18853F000")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x600004C")]
			[Cpp2IlInjected.Address(RVA = "0x8540540", Offset = "0x853EF40", VA = "0x188540540")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000022")]
		public float MAOPHMIFIPF
		{
			[Cpp2IlInjected.Token(Token = "0x600004D")]
			[Cpp2IlInjected.Address(RVA = "0x853F6F0", Offset = "0x853E0F0", VA = "0x18853F6F0")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x600004E")]
			[Cpp2IlInjected.Address(RVA = "0x8540BD0", Offset = "0x853F5D0", VA = "0x188540BD0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000023")]
		public Quaternion MFENCOCALNI
		{
			[Cpp2IlInjected.Token(Token = "0x600004F")]
			[Cpp2IlInjected.Address(RVA = "0x853F3A0", Offset = "0x853DDA0", VA = "0x18853F3A0")]
			get
			{
				return default(Quaternion);
			}
			[Cpp2IlInjected.Token(Token = "0x6000050")]
			[Cpp2IlInjected.Address(RVA = "0x85407A0", Offset = "0x853F1A0", VA = "0x1885407A0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000024")]
		public Quaternion OIPPCFFGNKJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000051")]
			[Cpp2IlInjected.Address(RVA = "0x853F620", Offset = "0x853E020", VA = "0x18853F620")]
			get
			{
				return default(Quaternion);
			}
			[Cpp2IlInjected.Token(Token = "0x6000052")]
			[Cpp2IlInjected.Address(RVA = "0x8540B00", Offset = "0x853F500", VA = "0x188540B00")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000025")]
		public Vector3 CBIADCDMOLG
		{
			[Cpp2IlInjected.Token(Token = "0x6000053")]
			[Cpp2IlInjected.Address(RVA = "0x853F470", Offset = "0x853DE70", VA = "0x18853F470")]
			get
			{
				return default(Vector3);
			}
			[Cpp2IlInjected.Token(Token = "0x6000054")]
			[Cpp2IlInjected.Address(RVA = "0x8540870", Offset = "0x853F270", VA = "0x188540870")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000026")]
		public Quaternion FIEGNKMJGHF
		{
			[Cpp2IlInjected.Token(Token = "0x6000055")]
			[Cpp2IlInjected.Address(RVA = "0x853F550", Offset = "0x853DF50", VA = "0x18853F550")]
			get
			{
				return default(Quaternion);
			}
			[Cpp2IlInjected.Token(Token = "0x6000056")]
			[Cpp2IlInjected.Address(RVA = "0x8540950", Offset = "0x853F350", VA = "0x188540950")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000027")]
		public Vector3 CGGOJBPICAG
		{
			[Cpp2IlInjected.Token(Token = "0x6000057")]
			[Cpp2IlInjected.Address(RVA = "0x853F7B0", Offset = "0x853E1B0", VA = "0x18853F7B0")]
			get
			{
				return default(Vector3);
			}
			[Cpp2IlInjected.Token(Token = "0x6000058")]
			[Cpp2IlInjected.Address(RVA = "0x8540CB0", Offset = "0x853F6B0", VA = "0x188540CB0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000028")]
		public Vector3 CMGKIHAHNKG
		{
			[Cpp2IlInjected.Token(Token = "0x6000059")]
			[Cpp2IlInjected.Address(RVA = "0x853F060", Offset = "0x853DA60", VA = "0x18853F060")]
			get
			{
				return default(Vector3);
			}
			[Cpp2IlInjected.Token(Token = "0x600005A")]
			[Cpp2IlInjected.Address(RVA = "0x85405B0", Offset = "0x853EFB0", VA = "0x1885405B0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000029")]
		public Vector3 DGGOMONDOHM
		{
			[Cpp2IlInjected.Token(Token = "0x600005B")]
			[Cpp2IlInjected.Address(RVA = "0x853E9D0", Offset = "0x853D3D0", VA = "0x18853E9D0")]
			get
			{
				return default(Vector3);
			}
			[Cpp2IlInjected.Token(Token = "0x600005C")]
			[Cpp2IlInjected.Address(RVA = "0x8540150", Offset = "0x853EB50", VA = "0x188540150")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002A")]
		public Vector3 KMMDBEFLDJJ
		{
			[Cpp2IlInjected.Token(Token = "0x600005D")]
			[Cpp2IlInjected.Address(RVA = "0x853EE40", Offset = "0x853D840", VA = "0x18853EE40")]
			get
			{
				return default(Vector3);
			}
			[Cpp2IlInjected.Token(Token = "0x600005E")]
			[Cpp2IlInjected.Address(RVA = "0x8540380", Offset = "0x853ED80", VA = "0x188540380")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002B")]
		public Vector3 OPOGJDDMJEI
		{
			[Cpp2IlInjected.Token(Token = "0x600005F")]
			[Cpp2IlInjected.Address(RVA = "0x853ED00", Offset = "0x853D700", VA = "0x18853ED00")]
			get
			{
				return default(Vector3);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002C")]
		public Quaternion AOLHEEIHCFK
		{
			[Cpp2IlInjected.Token(Token = "0x6000060")]
			[Cpp2IlInjected.Address(RVA = "0x853EC30", Offset = "0x853D630", VA = "0x18853EC30")]
			get
			{
				return default(Quaternion);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002D")]
		public Vector3 IGDELDKKPIH
		{
			[Cpp2IlInjected.Token(Token = "0x6000062")]
			[Cpp2IlInjected.Address(RVA = "0x853FA50", Offset = "0x853E450", VA = "0x18853FA50")]
			get
			{
				return default(Vector3);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002E")]
		public Vector3 KPPCFKPMEDM
		{
			[Cpp2IlInjected.Token(Token = "0x6000063")]
			[Cpp2IlInjected.Address(RVA = "0x853F970", Offset = "0x853E370", VA = "0x18853F970")]
			get
			{
				return default(Vector3);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002F")]
		public bool ILENMKPFHIE
		{
			[Cpp2IlInjected.Token(Token = "0x6000064")]
			[Cpp2IlInjected.Address(RVA = "0x853EDE0", Offset = "0x853D7E0", VA = "0x18853EDE0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000030")]
		public bool CICIBBPAKND
		{
			[Cpp2IlInjected.Token(Token = "0x6000065")]
			[Cpp2IlInjected.Address(RVA = "0x853E8B0", Offset = "0x853D2B0", VA = "0x18853E8B0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000031")]
		public bool JLDPCDKAHFN
		{
			[Cpp2IlInjected.Token(Token = "0x6000066")]
			[Cpp2IlInjected.Address(RVA = "0x853E3C0", Offset = "0x853CDC0", VA = "0x18853E3C0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000032")]
		public bool ONKMJCCBADM
		{
			[Cpp2IlInjected.Token(Token = "0x6000067")]
			[Cpp2IlInjected.Address(RVA = "0x853E360", Offset = "0x853CD60", VA = "0x18853E360")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000033")]
		public bool JCLDBNACAOP
		{
			[Cpp2IlInjected.Token(Token = "0x6000068")]
			[Cpp2IlInjected.Address(RVA = "0x853E240", Offset = "0x853CC40", VA = "0x18853E240")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000034")]
		public bool APPBBIKHMGA
		{
			[Cpp2IlInjected.Token(Token = "0x6000069")]
			[Cpp2IlInjected.Address(RVA = "0x853EBD0", Offset = "0x853D5D0", VA = "0x18853EBD0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000035")]
		public bool ANNFNILDKLH
		{
			[Cpp2IlInjected.Token(Token = "0x600006A")]
			[Cpp2IlInjected.Address(RVA = "0x252DCD0", Offset = "0x252C6D0", VA = "0x18252DCD0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000001")]
		public event FMMFANILCNM INIKKALHCLN
		{
			[Cpp2IlInjected.Token(Token = "0x600000E")]
			[Cpp2IlInjected.Address(RVA = "0x853E160", Offset = "0x853CB60", VA = "0x18853E160")]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x600000F")]
			[Cpp2IlInjected.Address(RVA = "0x853FDD0", Offset = "0x853E7D0", VA = "0x18853FDD0")]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000002")]
		public event KANEOGHNJFB HEDEIKCGPFF
		{
			[Cpp2IlInjected.Token(Token = "0x6000010")]
			[Cpp2IlInjected.Address(RVA = "0x853DED0", Offset = "0x853C8D0", VA = "0x18853DED0")]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000011")]
			[Cpp2IlInjected.Address(RVA = "0x853FB30", Offset = "0x853E530", VA = "0x18853FB30")]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000003")]
		public event KANEOGHNJFB OFIKEGHAAJA
		{
			[Cpp2IlInjected.Token(Token = "0x6000012")]
			[Cpp2IlInjected.Address(RVA = "0x853DF30", Offset = "0x853C930", VA = "0x18853DF30")]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000013")]
			[Cpp2IlInjected.Address(RVA = "0x853FBA0", Offset = "0x853E5A0", VA = "0x18853FBA0")]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000004")]
		public event KANEOGHNJFB OIIABNPPGHG
		{
			[Cpp2IlInjected.Token(Token = "0x6000014")]
			[Cpp2IlInjected.Address(RVA = "0x853E080", Offset = "0x853CA80", VA = "0x18853E080")]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000015")]
			[Cpp2IlInjected.Address(RVA = "0x853FCF0", Offset = "0x853E6F0", VA = "0x18853FCF0")]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000005")]
		public event Action<AMDCJLIPDMO, AMDCJLIPDMO> OOAPNHDFBKM
		{
			[Cpp2IlInjected.Token(Token = "0x6000016")]
			[Cpp2IlInjected.Address(RVA = "0x853E010", Offset = "0x853CA10", VA = "0x18853E010")]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000017")]
			[Cpp2IlInjected.Address(RVA = "0x853FC80", Offset = "0x853E680", VA = "0x18853FC80")]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000006")]
		public event KANEOGHNJFB GFNOKIPHAEA
		{
			[Cpp2IlInjected.Token(Token = "0x6000018")]
			[Cpp2IlInjected.Address(RVA = "0x853E0F0", Offset = "0x853CAF0", VA = "0x18853E0F0")]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000019")]
			[Cpp2IlInjected.Address(RVA = "0x853FD60", Offset = "0x853E760", VA = "0x18853FD60")]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000007")]
		public event KANEOGHNJFB JKHLIGCIDEK
		{
			[Cpp2IlInjected.Token(Token = "0x600001A")]
			[Cpp2IlInjected.Address(RVA = "0x853E1D0", Offset = "0x853CBD0", VA = "0x18853E1D0")]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x600001B")]
			[Cpp2IlInjected.Address(RVA = "0x853FE40", Offset = "0x853E840", VA = "0x18853FE40")]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000008")]
		public event KANEOGHNJFB KPEPBJELKCA
		{
			[Cpp2IlInjected.Token(Token = "0x600001C")]
			[Cpp2IlInjected.Address(RVA = "0x853DFA0", Offset = "0x853C9A0", VA = "0x18853DFA0")]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x600001D")]
			[Cpp2IlInjected.Address(RVA = "0x853FC10", Offset = "0x853E610", VA = "0x18853FC10")]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0xA0A570", Offset = "0xA08F70", VA = "0x180A0A570", Slot = "8")]
		private void OFFEHGELOML(CKPEEOMOJJI LALBBHEFJAE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x853C8A0", Offset = "0x853B2A0", VA = "0x18853C8A0", Slot = "9")]
		public GCMIBKGIHPB GetData()
		{
			return default(GCMIBKGIHPB);
		}

		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x853CF40", Offset = "0x853B940", VA = "0x18853CF40")]
		internal void PKEALMIHGBI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x853DC00", Offset = "0x853C600", VA = "0x18853DC00")]
		[Conditional("DEBUG_BUILD")]
		[Conditional("UNITY_EDITOR")]
		public void TestOverrideUnityRigidbody(Rigidbody PJEAJEOEHPE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x853C5F0", Offset = "0x853AFF0", VA = "0x18853C5F0")]
		public LEOFMIOLMNC GetChild(int MNFHMLCLFEB)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000061")]
		[Cpp2IlInjected.Address(RVA = "0x853D8C0", Offset = "0x853C2C0", VA = "0x18853D8C0")]
		public void SetInertiaTensor((Quaternion rot, Vector3 moments) HMJIJMLCIDN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006B")]
		[Cpp2IlInjected.Address(RVA = "0x853C250", Offset = "0x853AC50", VA = "0x18853C250")]
		private void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006C")]
		[Cpp2IlInjected.Address(RVA = "0x853DB50", Offset = "0x853C550", VA = "0x18853DB50")]
		protected void Start()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006D")]
		[Cpp2IlInjected.Address(RVA = "0x853C940", Offset = "0x853B340", VA = "0x18853C940")]
		private CKPEEOMOJJI KCPKMMBNJGL()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600006E")]
		[Cpp2IlInjected.Address(RVA = "0x853CC50", Offset = "0x853B650", VA = "0x18853CC50")]
		private void JBAOHJPBOCM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006F")]
		[Cpp2IlInjected.Address(RVA = "0x853D090", Offset = "0x853BA90", VA = "0x18853D090")]
		private void OnEnable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000070")]
		[Cpp2IlInjected.Address(RVA = "0x853CFD0", Offset = "0x853B9D0", VA = "0x18853CFD0")]
		public void OnDisable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000071")]
		[Cpp2IlInjected.Address(RVA = "0x853CF40", Offset = "0x853B940", VA = "0x18853CF40")]
		private void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000072")]
		[Cpp2IlInjected.Address(RVA = "0x853D030", Offset = "0x853BA30", VA = "0x18853D030")]
		private void OnDrawGizmosSelected()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000073")]
		[Cpp2IlInjected.Address(RVA = "0x853D0F0", Offset = "0x853BAF0", VA = "0x18853D0F0")]
		private void OnValidate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000074")]
		[Cpp2IlInjected.Address(RVA = "0x853B8A0", Offset = "0x853A2A0", VA = "0x18853B8A0")]
		public void AddDoNotResetVelocityOnOwnershipChangeOverride(object BECBHDDLOHA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000075")]
		[Cpp2IlInjected.Address(RVA = "0x853D150", Offset = "0x853BB50", VA = "0x18853D150")]
		public void RemoveDoNotResetVelocityOnOwnershipChangeOverride(object BECBHDDLOHA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000076")]
		[Cpp2IlInjected.Address(RVA = "0x853C590", Offset = "0x853AF90", VA = "0x18853C590")]
		public void DisableCachedInertialPropertyOverride()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000077")]
		[Cpp2IlInjected.Address(RVA = "0x853CEE0", Offset = "0x853B8E0", VA = "0x18853CEE0")]
		public void MarkCachedInertialParametersDirty()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000078")]
		[Cpp2IlInjected.Address(RVA = "0x853DA20", Offset = "0x853C420", VA = "0x18853DA20")]
		public void SetParent(RigidbodyEx PCDAHJCDHHF, bool MPNHLGBIEGE = false)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000079")]
		[Cpp2IlInjected.Address(RVA = "0x853D460", Offset = "0x853BE60", VA = "0x18853D460")]
		public void ResetLocalCenterOfMassToPrefabDefault()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007A")]
		[Cpp2IlInjected.Address(RVA = "0x853C9F0", Offset = "0x853B3F0", VA = "0x18853C9F0")]
		public bool IsRigidbodyAncestor(RigidbodyEx FAKEOLEIJIO)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600007B")]
		[Cpp2IlInjected.Address(RVA = "0x853CAF0", Offset = "0x853B4F0", VA = "0x18853CAF0")]
		public bool IsRigidbodyDescendant(RigidbodyEx NLBJIDEMDBN)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600007C")]
		[Cpp2IlInjected.Address(RVA = "0x853BB10", Offset = "0x853A510", VA = "0x18853BB10")]
		public void AddInterpolationRestriction(object BECBHDDLOHA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007D")]
		[Cpp2IlInjected.Address(RVA = "0x853D1C0", Offset = "0x853BBC0", VA = "0x18853D1C0")]
		public void RemoveInterpolationRestriction(object BECBHDDLOHA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007E")]
		[Cpp2IlInjected.Address(RVA = "0x853BB80", Offset = "0x853A580", VA = "0x18853BB80")]
		public void AddKinematic(object BECBHDDLOHA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007F")]
		[Cpp2IlInjected.Address(RVA = "0x853D230", Offset = "0x853BC30", VA = "0x18853D230")]
		public void RemoveKinematic(object BECBHDDLOHA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000080")]
		[Cpp2IlInjected.Address(RVA = "0x853D9A0", Offset = "0x853C3A0", VA = "0x18853D9A0")]
		public void SetKinematic(object BECBHDDLOHA, bool PLIDCHGGBAD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000081")]
		[Cpp2IlInjected.Address(RVA = "0x853D7C0", Offset = "0x853C1C0", VA = "0x18853D7C0")]
		public void SetDiscontinuousPositionAndRotation(Vector3 AKALCNGHLHF, Quaternion GKIBONHCOLJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000082")]
		[Cpp2IlInjected.Address(RVA = "0x853D6C0", Offset = "0x853C0C0", VA = "0x18853D6C0")]
		public void SetDiscontinuousLocalPositionAndLocalRotation(Vector3 NIIDLMFIKHH, Quaternion HBPPPKIDAOE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000083")]
		[Cpp2IlInjected.Address(RVA = "0x853C790", Offset = "0x853B190", VA = "0x18853C790")]
		public Vector3 GetConstrainedVelocity(Vector3 CGGOJBPICAG)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x6000084")]
		[Cpp2IlInjected.Address(RVA = "0x853C680", Offset = "0x853B080", VA = "0x18853C680")]
		public Vector3 GetConstrainedAngularVelocity(Vector3 DGGOMONDOHM)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x6000085")]
		[Cpp2IlInjected.Address(RVA = "0x853BA20", Offset = "0x853A420", VA = "0x18853BA20")]
		public void AddForce(Vector3 BOOINJJDCOC, ForceMode OBFDKNANAGO = ForceMode.Force)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000086")]
		[Cpp2IlInjected.Address(RVA = "0x853B910", Offset = "0x853A310", VA = "0x18853B910")]
		public void AddForceAtPosition(Vector3 BOOINJJDCOC, Vector3 JFMEMBGKAOB, ForceMode OBFDKNANAGO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000087")]
		[Cpp2IlInjected.Address(RVA = "0x853BD50", Offset = "0x853A750", VA = "0x18853BD50")]
		public void AddTorque(Vector3 CMHJLKLDGIM, ForceMode OBFDKNANAGO = ForceMode.Force)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000088")]
		[Cpp2IlInjected.Address(RVA = "0x853BBF0", Offset = "0x853A5F0", VA = "0x18853BBF0")]
		public void AddRelativeTorque(Vector3 CMHJLKLDGIM, ForceMode OBFDKNANAGO = ForceMode.Force)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000089")]
		[Cpp2IlInjected.Address(RVA = "0x853DCD0", Offset = "0x853C6D0", VA = "0x18853DCD0")]
		public Vector3 WorldToLocalVelocity(Vector3 BIDFFEOGLBL)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x600008A")]
		[Cpp2IlInjected.Address(RVA = "0x853CDD0", Offset = "0x853B7D0", VA = "0x18853CDD0")]
		public Vector3 LocalToWorldVelocity(Vector3 CMGKIHAHNKG)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x600008B")]
		[Cpp2IlInjected.Address(RVA = "0x853C530", Offset = "0x853AF30", VA = "0x18853C530")]
		public void ClearVelocity()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008C")]
		[Cpp2IlInjected.Address(RVA = "0x853C4D0", Offset = "0x853AED0", VA = "0x18853C4D0")]
		public void ClearUnityRigidbodyVelocity()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008D")]
		[Cpp2IlInjected.Address(RVA = "0x853C470", Offset = "0x853AE70", VA = "0x18853C470")]
		public void ClearLinearVelocity()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008E")]
		[Cpp2IlInjected.Address(RVA = "0x853C410", Offset = "0x853AE10", VA = "0x18853C410")]
		public void ClearAngularVelocity()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008F")]
		[Cpp2IlInjected.Address(RVA = "0x853D5C0", Offset = "0x853BFC0", VA = "0x18853D5C0")]
		public void ResetVelocityWorldSpace(Vector3 KLLLEBHFHNI, Vector3 KKAICPOLEBD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000090")]
		[Cpp2IlInjected.Address(RVA = "0x853D4C0", Offset = "0x853BEC0", VA = "0x18853D4C0")]
		public void ResetVelocityLocalSpace(Vector3 GOGJNILJNEN, Vector3 KMMDBEFLDJJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000091")]
		[Cpp2IlInjected.Address(RVA = "0x853D380", Offset = "0x853BD80", VA = "0x18853D380")]
		public void ResetLinearVelocityLocalSpace(Vector3 GOGJNILJNEN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000092")]
		[Cpp2IlInjected.Address(RVA = "0x853DB60", Offset = "0x853C560", VA = "0x18853DB60")]
		public bool SweepTest(Vector3 HPCBBMBEKNN, [Out] RaycastHit KGJLOFPICLA, float LCMAOMAPNJJ)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000093")]
		[Cpp2IlInjected.Address(RVA = "0x853CBF0", Offset = "0x853B5F0", VA = "0x18853CBF0")]
		public bool IsSleeping()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000094")]
		[Cpp2IlInjected.Address(RVA = "0x853DAF0", Offset = "0x853C4F0", VA = "0x18853DAF0")]
		public void Sleep()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000095")]
		[Cpp2IlInjected.Address(RVA = "0x853DC70", Offset = "0x853C670", VA = "0x18853DC70")]
		public void WakeUp()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000096")]
		[Cpp2IlInjected.Address(RVA = "0x853BCE0", Offset = "0x853A6E0", VA = "0x18853BCE0")]
		public void AddShouldHaveUnityRigidbodyToken(object BECBHDDLOHA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000097")]
		[Cpp2IlInjected.Address(RVA = "0x853D2A0", Offset = "0x853BCA0", VA = "0x18853D2A0")]
		public void RemoveShouldHaveUnityRigidbodyToken(object BECBHDDLOHA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000098")]
		[Cpp2IlInjected.Address(RVA = "0x853C0E0", Offset = "0x853AAE0", VA = "0x18853C0E0")]
		public void ApplyForceVelocityChange(PHFBBBOEHHE EOIBMOKJMCC, Vector3 GNPPKKBDPBJ, float CGEKJMEOLJJ, float GEEMEDNHPAN = 8f, float NAFGNOICJFA = 1f)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000099")]
		[Cpp2IlInjected.Address(RVA = "0x853BFE0", Offset = "0x853A9E0", VA = "0x18853BFE0")]
		public void ApplyAngularVelocityChange(BFLBDPBGGCC IFGLFJKEHHO, Vector3 FDPNNHOKDDC, float HNEJJEILEPA = float.PositiveInfinity)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009A")]
		[Cpp2IlInjected.Address(RVA = "0x853C1A0", Offset = "0x853ABA0", VA = "0x18853C1A0")]
		[Obsolete("Deprecated. Still exists to support deprecated CV2 chips. Use ApplyAngularVelocityChange.")]
		public void ApplyTorqueAngularVelocityChangeDeprecated(BFLBDPBGGCC IFGLFJKEHHO, Vector3 NGPACIMGGNA, float BIKCCBHNJCE = 7f, float NNAMGLPMFOG = 1f)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009B")]
		[Cpp2IlInjected.Address(RVA = "0x853BF10", Offset = "0x853A910", VA = "0x18853BF10")]
		public bool AllowedScaleChange(float EMHHPNBMOLH)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600009C")]
		[Cpp2IlInjected.Address(RVA = "0x853BE40", Offset = "0x853A840", VA = "0x18853BE40")]
		public void AddWorldSpaceVelocityInHierarchyParentOverride(RigidbodyEx JJHMEOPMAEJ, object BECBHDDLOHA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009D")]
		[Cpp2IlInjected.Address(RVA = "0x853D310", Offset = "0x853BD10", VA = "0x18853D310")]
		public void RemoveWorldSpaceVelocityInHierarchyParentOverride(object BECBHDDLOHA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009E")]
		[Cpp2IlInjected.Address(RVA = "0x853C930", Offset = "0x853B330", VA = "0x18853C930", Slot = "13")]
		private void HDIPHGLPMLN(OKBMAOLKCPM GJIMIGJJJKI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009F")]
		[Cpp2IlInjected.Address(RVA = "0x853DE60", Offset = "0x853C860", VA = "0x18853DE60")]
		public RigidbodyEx()
		{
		}

		[SpecialName]
		[Cpp2IlInjected.Token(Token = "0x60000A1")]
		[Cpp2IlInjected.Address(RVA = "0xA9EE50", Offset = "0xA9D850", VA = "0x180A9EE50", Slot = "4")]
		private GameObject GNBNLBLLMDA()
		{
			return null;
		}

		[SpecialName]
		[Cpp2IlInjected.Token(Token = "0x60000A2")]
		[Cpp2IlInjected.Address(RVA = "0xA37E00", Offset = "0xA36800", VA = "0x180A37E00", Slot = "10")]
		private bool KOELFKEGDPC()
		{
			return default(bool);
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
internal static class ENGODKHKBDG
{
	[Cpp2IlInjected.Token(Token = "0x60000A3")]
	[Cpp2IlInjected.Address(RVA = "0x852A370", Offset = "0x8528D70", VA = "0x18852A370")]
	public static CKPEEOMOJJI IDBKNKJEPDG(this RigidbodyEx OGMEFONHICP)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
[RegisterService(typeof(LNPBMAIDKPE), new string[] { })]
public class ICHIKPFDGDJ : LNPBMAIDKPE, BOEGHMMFADM
{
	[Cpp2IlInjected.Token(Token = "0x4000011")]
	private static readonly COJJKFBGGKB PMPMPCJHKKF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000012")]
	private EGFHJDMOPEO FLJMNPJIKOM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000013")]
	private CNOPFBJJJEJ FEFKHBOEBKH;

	[Cpp2IlInjected.Token(Token = "0x17000036")]
	public EGFHJDMOPEO INJOGOILMKA
	{
		[Cpp2IlInjected.Token(Token = "0x60000A4")]
		[Cpp2IlInjected.Address(RVA = "0xA0A560", Offset = "0xA08F60", VA = "0x180A0A560", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000037")]
	public CNOPFBJJJEJ PCJPOGHCIII
	{
		[Cpp2IlInjected.Token(Token = "0x60000A5")]
		[Cpp2IlInjected.Address(RVA = "0xA0A9D0", Offset = "0xA093D0", VA = "0x180A0A9D0", Slot = "5")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000A6")]
	[Cpp2IlInjected.Address(RVA = "0x852DE30", Offset = "0x852C830", VA = "0x18852DE30", Slot = "7")]
	public void InitReferences(FKFJNEKJHIE CCGCAONCGHG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A7")]
	[Cpp2IlInjected.Address(RVA = "0x852DD00", Offset = "0x852C700", VA = "0x18852DD00", Slot = "6")]
	public CKPEEOMOJJI CBOPHCMCJJL(RigidbodyEx OGMEFONHICP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000A8")]
	[Cpp2IlInjected.Address(RVA = "0xA104F0", Offset = "0xA0EEF0", VA = "0x180A104F0")]
	public ICHIKPFDGDJ()
	{
	}
}
namespace RecRoom
{
	[Cpp2IlInjected.Token(Token = "0x2000007")]
	public class PhysicsManager : SingletonMonoBehaviour<PhysicsManager>
	{
		[Cpp2IlInjected.Token(Token = "0x4000014")]
		public static CNBOOGKDGFE UpdateAfterFixedUpdateRan;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000015")]
		private int DGBIHGLMCLL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x4000016")]
		private int ENOPGGCFNFN;

		[Cpp2IlInjected.Token(Token = "0x60000AA")]
		[Cpp2IlInjected.Address(RVA = "0x853B720", Offset = "0x853A120", VA = "0x18853B720")]
		protected void FixedUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AB")]
		[Cpp2IlInjected.Address(RVA = "0x853B760", Offset = "0x853A160", VA = "0x18853B760")]
		protected void Update()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AC")]
		[Cpp2IlInjected.Address(RVA = "0x853B740", Offset = "0x853A140", VA = "0x18853B740")]
		protected void LateUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AD")]
		[Cpp2IlInjected.Address(RVA = "0xA0C4B0", Offset = "0xA0AEB0", VA = "0x180A0C4B0")]
		[Conditional("UNITY_ASSERTIONS")]
		public void AssertLateColliderPositionsNotYetUpdated([Optional] string IJOJGNJMCGP, [Optional] UnityEngine.Object GJIMIGJJJKI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AE")]
		[Cpp2IlInjected.Address(RVA = "0xA0C4B0", Offset = "0xA0AEB0", VA = "0x180A0C4B0")]
		[Conditional("UNITY_ASSERTIONS")]
		public void AssertLateColliderPositionsAlreadyUpdated([Optional] string IJOJGNJMCGP, [Optional] UnityEngine.Object GJIMIGJJJKI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AF")]
		[Cpp2IlInjected.Address(RVA = "0x853B850", Offset = "0x853A250", VA = "0x18853B850")]
		public PhysicsManager()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
public static class NKAJBGNFMJC
{
	[Cpp2IlInjected.Token(Token = "0x2000009")]
	private class MDFONPLMHMF : FJBHJEKKKOJ, IDisposable
	{
		[Cpp2IlInjected.Token(Token = "0x60000B3")]
		[Cpp2IlInjected.Address(RVA = "0xA0C4B0", Offset = "0xA0AEB0", VA = "0x180A0C4B0", Slot = "7")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B4")]
		[Cpp2IlInjected.Address(RVA = "0xA1AB90", Offset = "0xA19590", VA = "0x180A1AB90", Slot = "4")]
		public Vector3 NPLJEAOEEHF()
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x60000B5")]
		[Cpp2IlInjected.Address(RVA = "0xA1AB90", Offset = "0xA19590", VA = "0x180A1AB90", Slot = "5")]
		public Vector3 JBDIHPPALPD()
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x60000B6")]
		[Cpp2IlInjected.Address(RVA = "0xA256B0", Offset = "0xA240B0", VA = "0x180A256B0", Slot = "6")]
		public bool IAEMNJIGKMH(float MELLPFGFAIF, float FDNGHHLDFDM)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000B7")]
		[Cpp2IlInjected.Address(RVA = "0xA104F0", Offset = "0xA0EEF0", VA = "0x180A104F0")]
		public MDFONPLMHMF()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000038")]
	public static FJBHJEKKKOJ EFFEONCCDGA
	{
		[Cpp2IlInjected.Token(Token = "0x60000B1")]
		[Cpp2IlInjected.Address(RVA = "0x85310F0", Offset = "0x852FAF0", VA = "0x1885310F0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
public interface BEEDAICOJJB
{
	[Cpp2IlInjected.Token(Token = "0x17000039")]
	CollisionDetectionMode OPPKJLMOMMG
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
	void FHOCOEECEGJ();

	[Cpp2IlInjected.Token(Token = "0x60000BB")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void HPHKCIMBDDM(bool ILENMKPFHIE);

	[Cpp2IlInjected.Token(Token = "0x60000BC")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void NMDKEKDLENL(bool ILENMKPFHIE);

	[Cpp2IlInjected.Token(Token = "0x60000BD")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void MDKOPLPDGML(Rigidbody DBPDLPLAFJF);

	[Cpp2IlInjected.Token(Token = "0x60000BE")]
	[Cpp2IlInjected.Address(Slot = "6")]
	bool HEOJEJIIFPB(Vector3 HPCBBMBEKNN, [Out] RaycastHit KGJLOFPICLA, float LCMAOMAPNJJ);
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
public interface PDOINCHLDKK : IDisposable, LLOHDJMHBHM
{
	[Cpp2IlInjected.Token(Token = "0x1700003A")]
	BJFKEGNANDB DNEPNLLILDF
	{
		[Cpp2IlInjected.Token(Token = "0x60000C1")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
		[Cpp2IlInjected.Token(Token = "0x60000C2")]
		[Cpp2IlInjected.Address(Slot = "3")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x14000009")]
	event Action<AMDCJLIPDMO, AMDCJLIPDMO> OOAPNHDFBKM;

	[Cpp2IlInjected.Token(Token = "0x60000C3")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void FHOCOEECEGJ();
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
[ServiceLifetime(Lifetime.Application)]
public interface CNOPFBJJJEJ
{
	[Cpp2IlInjected.Token(Token = "0x60000C4")]
	[Cpp2IlInjected.Address(Slot = "0")]
	AIDCNLBLAJA IMNMGFCGAPC(CKPEEOMOJJI LALBBHEFJAE);

	[Cpp2IlInjected.Token(Token = "0x60000C5")]
	[Cpp2IlInjected.Address(Slot = "1")]
	EMIIHOMMAAN LCNHJGJENBG(CKPEEOMOJJI LALBBHEFJAE);

	[Cpp2IlInjected.Token(Token = "0x60000C6")]
	[Cpp2IlInjected.Address(Slot = "2")]
	IONNNKEBPAB GFMHGKCGLOI(CKPEEOMOJJI LALBBHEFJAE);

	[Cpp2IlInjected.Token(Token = "0x60000C7")]
	[Cpp2IlInjected.Address(Slot = "3")]
	EKJGDKIAJDP LHKDDABHFFI(CKPEEOMOJJI LALBBHEFJAE);

	[Cpp2IlInjected.Token(Token = "0x60000C8")]
	[Cpp2IlInjected.Address(Slot = "4")]
	JFNPBCAFDLA HDJKOOOAGEP(CKPEEOMOJJI LALBBHEFJAE);

	[Cpp2IlInjected.Token(Token = "0x60000C9")]
	[Cpp2IlInjected.Address(Slot = "5")]
	PDOINCHLDKK HBJBEBIOMNP(CKPEEOMOJJI LALBBHEFJAE);

	[Cpp2IlInjected.Token(Token = "0x60000CA")]
	[Cpp2IlInjected.Address(Slot = "6")]
	MALJIKLIKOO ODNKMGMGKCH(CKPEEOMOJJI LALBBHEFJAE);

	[Cpp2IlInjected.Token(Token = "0x60000CB")]
	[Cpp2IlInjected.Address(Slot = "7")]
	INIODDOAIFA GINPPBAKNDH(CKPEEOMOJJI LALBBHEFJAE);

	[Cpp2IlInjected.Token(Token = "0x60000CC")]
	[Cpp2IlInjected.Address(Slot = "8")]
	BEEDAICOJJB KMCDPKBHKPN(CKPEEOMOJJI LALBBHEFJAE);

	[Cpp2IlInjected.Token(Token = "0x60000CD")]
	[Cpp2IlInjected.Address(Slot = "9")]
	FBLOLAIMBFH EGHJMOJHENN(CKPEEOMOJJI LALBBHEFJAE);

	[Cpp2IlInjected.Token(Token = "0x60000CE")]
	[Cpp2IlInjected.Address(Slot = "10")]
	LHOMDKGMMEN GBENOHALCJN(CKPEEOMOJJI LALBBHEFJAE, [In] GCMIBKGIHPB HPGIDELCODH);

	[Cpp2IlInjected.Token(Token = "0x60000CF")]
	[Cpp2IlInjected.Address(Slot = "11")]
	NPMBGKJGIHC PDDAEILCPHI(CKPEEOMOJJI LALBBHEFJAE, [In] GCMIBKGIHPB HPGIDELCODH);

	[Cpp2IlInjected.Token(Token = "0x60000D0")]
	[Cpp2IlInjected.Address(Slot = "12")]
	OFKNFCFBFKJ KBKOCNCODNC(CKPEEOMOJJI LALBBHEFJAE, [In] GCMIBKGIHPB HPGIDELCODH);

	[Cpp2IlInjected.Token(Token = "0x60000D1")]
	[Cpp2IlInjected.Address(Slot = "13")]
	MHLJOKBMHID NGHIHLDAAJO(CKPEEOMOJJI LALBBHEFJAE, [In] GCMIBKGIHPB HPGIDELCODH);

	[Cpp2IlInjected.Token(Token = "0x60000D2")]
	[Cpp2IlInjected.Address(Slot = "14")]
	ADEFFAGNNKF FJKKKLJHINL(CKPEEOMOJJI LALBBHEFJAE, [In] GCMIBKGIHPB HPGIDELCODH);

	[Cpp2IlInjected.Token(Token = "0x60000D3")]
	[Cpp2IlInjected.Address(Slot = "15")]
	CKPEEOMOJJI CBOPHCMCJJL(RigidbodyEx OGMEFONHICP, GCMIBKGIHPB HPGIDELCODH, LNPBMAIDKPE BPDOIFAEGPF);
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
public interface INIODDOAIFA
{
	[Cpp2IlInjected.Token(Token = "0x60000D4")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void GNDHMCFEFFI(Vector3 BOOINJJDCOC, ForceMode OBFDKNANAGO = ForceMode.Force);

	[Cpp2IlInjected.Token(Token = "0x60000D5")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void FFLEEFDDKDM(Vector3 BOOINJJDCOC, Vector3 JFMEMBGKAOB, ForceMode OBFDKNANAGO);

	[Cpp2IlInjected.Token(Token = "0x60000D6")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void PEDLDKMBEOD(Vector3 CMHJLKLDGIM, ForceMode OBFDKNANAGO = ForceMode.Force);

	[Cpp2IlInjected.Token(Token = "0x60000D7")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void GCJDDPBLICH(Vector3 CMHJLKLDGIM, ForceMode OBFDKNANAGO = ForceMode.Force);
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
public interface FBLOLAIMBFH
{
	[Cpp2IlInjected.Token(Token = "0x1700003B")]
	bool GCOGCFPFCML
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
	void MDKOPLPDGML(Rigidbody DBPDLPLAFJF);

	[Cpp2IlInjected.Token(Token = "0x60000DB")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void NOHPCMHGJNH(Rigidbody DBPDLPLAFJF);
}
[Cpp2IlInjected.Token(Token = "0x200000F")]
public interface AIDCNLBLAJA : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x1700003C")]
	IReadOnlyList<CKPEEOMOJJI> OBNKPPHMPJE
	{
		[Cpp2IlInjected.Token(Token = "0x60000EE")]
		[Cpp2IlInjected.Address(Slot = "18")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700003D")]
	CKPEEOMOJJI PFOPMMBCMFB
	{
		[Cpp2IlInjected.Token(Token = "0x60000EF")]
		[Cpp2IlInjected.Address(Slot = "19")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700003E")]
	CKPEEOMOJJI IOJNNDJMALL
	{
		[Cpp2IlInjected.Token(Token = "0x60000F0")]
		[Cpp2IlInjected.Address(Slot = "20")]
		get;
		[Cpp2IlInjected.Token(Token = "0x60000F1")]
		[Cpp2IlInjected.Address(Slot = "21")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x1400000A")]
	event KANEOGHNJFB HEDEIKCGPFF;

	[Cpp2IlInjected.Token(Token = "0x1400000B")]
	event KANEOGHNJFB OFIKEGHAAJA;

	[Cpp2IlInjected.Token(Token = "0x1400000C")]
	event FMMFANILCNM HJNHKBJIAMO;

	[Cpp2IlInjected.Token(Token = "0x1400000D")]
	event Action MFLPCIMFLGN;

	[Cpp2IlInjected.Token(Token = "0x1400000E")]
	event Action BLJGAOLGKFL;

	[Cpp2IlInjected.Token(Token = "0x1400000F")]
	event Action<CKPEEOMOJJI> AOOJMBPBOMN;

	[Cpp2IlInjected.Token(Token = "0x14000010")]
	event Action<CKPEEOMOJJI> NCAEPMGOKIA;

	[Cpp2IlInjected.Token(Token = "0x14000011")]
	event Action LJBLPCKPAJL;

	[Cpp2IlInjected.Token(Token = "0x14000012")]
	event Action<CKPEEOMOJJI> PPEJFADBEGE;

	[Cpp2IlInjected.Token(Token = "0x60000F2")]
	[Cpp2IlInjected.Address(Slot = "22")]
	void ODCKPPKNECL(CKPEEOMOJJI FEIPCFECKLD, bool MPNHLGBIEGE = false);
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
public interface IONNNKEBPAB
{
	[Cpp2IlInjected.Token(Token = "0x1700003F")]
	Vector3 BJMHMKHBLHP
	{
		[Cpp2IlInjected.Token(Token = "0x60000F3")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000040")]
	Vector3 CILPBKBJNOD
	{
		[Cpp2IlInjected.Token(Token = "0x60000F4")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x60000F5")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void CFGIELFKPLJ(CKPEEOMOJJI EAGGHBKHKHF, object BECBHDDLOHA);

	[Cpp2IlInjected.Token(Token = "0x60000F6")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void GNNNEHAEDEF(object BECBHDDLOHA);
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
public interface MHLJOKBMHID
{
	[Cpp2IlInjected.Token(Token = "0x17000041")]
	Vector3 CBMDODIHBDD
	{
		[Cpp2IlInjected.Token(Token = "0x60000F9")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
		[Cpp2IlInjected.Token(Token = "0x60000FA")]
		[Cpp2IlInjected.Address(Slot = "3")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000042")]
	Vector3 GNEAMFDMGFL
	{
		[Cpp2IlInjected.Token(Token = "0x60000FB")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000043")]
	float ABAPMFBJMKO
	{
		[Cpp2IlInjected.Token(Token = "0x60000FC")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000044")]
	float LMMEKHANDPM
	{
		[Cpp2IlInjected.Token(Token = "0x60000FD")]
		[Cpp2IlInjected.Address(Slot = "6")]
		get;
		[Cpp2IlInjected.Token(Token = "0x60000FE")]
		[Cpp2IlInjected.Address(Slot = "7")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000045")]
	Vector3 MMDHKNKKPNC
	{
		[Cpp2IlInjected.Token(Token = "0x60000FF")]
		[Cpp2IlInjected.Address(Slot = "8")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000046")]
	Quaternion HECHIIJBGHD
	{
		[Cpp2IlInjected.Token(Token = "0x6000100")]
		[Cpp2IlInjected.Address(Slot = "9")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x14000013")]
	event KANEOGHNJFB BMDHGDMBLPC;

	[Cpp2IlInjected.Token(Token = "0x6000101")]
	[Cpp2IlInjected.Address(Slot = "10")]
	void KDFIPNDDFHG((Quaternion rot, Vector3 moments) HMJIJMLCIDN);

	[Cpp2IlInjected.Token(Token = "0x6000102")]
	[Cpp2IlInjected.Address(Slot = "11")]
	void MINPMAPDKEN();

	[Cpp2IlInjected.Token(Token = "0x6000103")]
	[Cpp2IlInjected.Address(Slot = "12")]
	void ICFMKMGKFPN();

	[Cpp2IlInjected.Token(Token = "0x6000104")]
	[Cpp2IlInjected.Address(Slot = "13")]
	void OEFGFHILMEM();

	[Cpp2IlInjected.Token(Token = "0x6000105")]
	[Cpp2IlInjected.Address(Slot = "14")]
	void MDKOPLPDGML(Rigidbody DBPDLPLAFJF);

	[Cpp2IlInjected.Token(Token = "0x6000106")]
	[Cpp2IlInjected.Address(Slot = "15")]
	void NOHPCMHGJNH(Rigidbody DBPDLPLAFJF);

	[Cpp2IlInjected.Token(Token = "0x6000107")]
	[Cpp2IlInjected.Address(Slot = "16")]
	void KEAMPKLDOJP();
}
[Cpp2IlInjected.Token(Token = "0x2000012")]
public interface OFKNFCFBFKJ
{
	[Cpp2IlInjected.Token(Token = "0x6000108")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void FHOCOEECEGJ();

	[Cpp2IlInjected.Token(Token = "0x6000109")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void IPMACFHIMHE(object BECBHDDLOHA);

	[Cpp2IlInjected.Token(Token = "0x600010A")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void JJNJDAACGGK(object BECBHDDLOHA);

	[Cpp2IlInjected.Token(Token = "0x600010B")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void IHDJDBHJOFC(CKPEEOMOJJI OGMEFONHICP);

	[Cpp2IlInjected.Token(Token = "0x600010C")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void JMPDKJIBKLF(CKPEEOMOJJI OGMEFONHICP);

	[Cpp2IlInjected.Token(Token = "0x600010D")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void GAAJFDMJFHO();
}
[Cpp2IlInjected.Token(Token = "0x2000013")]
public interface MALJIKLIKOO
{
	[Cpp2IlInjected.Token(Token = "0x17000047")]
	bool OOFIBNOFLPB
	{
		[Cpp2IlInjected.Token(Token = "0x6000110")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x14000014")]
	event KANEOGHNJFB NCDNCOALOHG;

	[Cpp2IlInjected.Token(Token = "0x6000111")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void FPDDDLNGNCI(object BECBHDDLOHA);

	[Cpp2IlInjected.Token(Token = "0x6000112")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void LDDOMOEOJNM(object BECBHDDLOHA);

	[Cpp2IlInjected.Token(Token = "0x6000113")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void DJIMFIKFOJP(object BECBHDDLOHA, bool PLIDCHGGBAD);

	[Cpp2IlInjected.Token(Token = "0x6000114")]
	[Cpp2IlInjected.Address(Slot = "6")]
	void MDKOPLPDGML(Rigidbody FADODMKCMLG);

	[Cpp2IlInjected.Token(Token = "0x6000115")]
	[Cpp2IlInjected.Address(Slot = "7")]
	void NOHPCMHGJNH(Rigidbody DBPDLPLAFJF);
}
[Cpp2IlInjected.Token(Token = "0x2000014")]
public interface NPMBGKJGIHC : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x17000048")]
	bool BEOAIADIFDD
	{
		[Cpp2IlInjected.Token(Token = "0x6000118")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000049")]
	bool DHDBIEJCKNP
	{
		[Cpp2IlInjected.Token(Token = "0x6000119")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x14000015")]
	event KANEOGHNJFB AIFDABJDFDJ;

	[Cpp2IlInjected.Token(Token = "0x600011A")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void FHOCOEECEGJ();

	[Cpp2IlInjected.Token(Token = "0x600011B")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void OKGNDLLEDLC(CKPEEOMOJJI EAGGHBKHKHF);

	[Cpp2IlInjected.Token(Token = "0x600011C")]
	[Cpp2IlInjected.Address(Slot = "6")]
	void EAPNLDPEEMK(CKPEEOMOJJI EAGGHBKHKHF);
}
[Cpp2IlInjected.Token(Token = "0x2000015")]
public interface ADEFFAGNNKF
{
	[Cpp2IlInjected.Token(Token = "0x1700004A")]
	bool GMGDAJFJIKK
	{
		[Cpp2IlInjected.Token(Token = "0x600011D")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
		[Cpp2IlInjected.Token(Token = "0x600011E")]
		[Cpp2IlInjected.Address(Slot = "1")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x1700004B")]
	bool DCIGFHADAKG
	{
		[Cpp2IlInjected.Token(Token = "0x600011F")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700004C")]
	RigidbodyConstraints NDAJLCONCBK
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
	void MDKOPLPDGML(Rigidbody DBPDLPLAFJF);

	[Cpp2IlInjected.Token(Token = "0x6000123")]
	[Cpp2IlInjected.Address(Slot = "6")]
	void NOHPCMHGJNH(Rigidbody DBPDLPLAFJF);
}
[Cpp2IlInjected.Token(Token = "0x2000016")]
public interface EKJGDKIAJDP
{
	[Cpp2IlInjected.Token(Token = "0x1700004D")]
	float DPMLBPCNACO
	{
		[Cpp2IlInjected.Token(Token = "0x6000124")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
		[Cpp2IlInjected.Token(Token = "0x6000125")]
		[Cpp2IlInjected.Address(Slot = "1")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x1700004E")]
	float LOFGGINBDGJ
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
	void MDKOPLPDGML(Rigidbody DBPDLPLAFJF);

	[Cpp2IlInjected.Token(Token = "0x6000129")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void NOHPCMHGJNH(Rigidbody DBPDLPLAFJF);
}
[Cpp2IlInjected.Token(Token = "0x2000017")]
public interface JFNPBCAFDLA
{
	[Cpp2IlInjected.Token(Token = "0x4000018")]
	static bool KFPGMOHHGJP;

	[Cpp2IlInjected.Token(Token = "0x14000016")]
	event KANEOGHNJFB NHDMNCBOADE;

	[Cpp2IlInjected.Token(Token = "0x600012C")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void FHOCOEECEGJ();

	[Cpp2IlInjected.Token(Token = "0x600012D")]
	[Cpp2IlInjected.Address(Slot = "3")]
	bool PMHMCBPHCIC();

	[Cpp2IlInjected.Token(Token = "0x600012E")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void OHIDMGAGONP();

	[Cpp2IlInjected.Token(Token = "0x600012F")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void KBIKDALDOIA();

	[Cpp2IlInjected.Token(Token = "0x6000130")]
	[Cpp2IlInjected.Address(Slot = "6")]
	bool LIACIODCJPP();

	[Cpp2IlInjected.Token(Token = "0x6000131")]
	[Cpp2IlInjected.Address(Slot = "7")]
	bool KPNFFEMNEMA();

	[Cpp2IlInjected.Token(Token = "0x6000132")]
	[Cpp2IlInjected.Address(Slot = "8")]
	void BADDFBDBPGF(bool OMNLACPHJAE);

	[Cpp2IlInjected.Token(Token = "0x6000133")]
	[Cpp2IlInjected.Address(Slot = "9")]
	void HHPGCIJHADF();
}
[Cpp2IlInjected.Token(Token = "0x2000018")]
public interface LHOMDKGMMEN
{
	[Cpp2IlInjected.Token(Token = "0x1700004F")]
	Rigidbody NJDIIBKCONL
	{
		[Cpp2IlInjected.Token(Token = "0x6000134")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000050")]
	bool FFDECAEBDIG
	{
		[Cpp2IlInjected.Token(Token = "0x6000136")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000135")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void FHOCOEECEGJ();

	[Cpp2IlInjected.Token(Token = "0x6000137")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void NGENBHLPLCE(object BECBHDDLOHA);

	[Cpp2IlInjected.Token(Token = "0x6000138")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void DCFIAPPHDDC(object BECBHDDLOHA);

	[Cpp2IlInjected.Token(Token = "0x6000139")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void HCHJGPHOLJF();
}
[Cpp2IlInjected.Token(Token = "0x2000019")]
public interface EMIIHOMMAAN : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x17000051")]
	FJBHJEKKKOJ ALHFICIODDP
	{
		[Cpp2IlInjected.Token(Token = "0x600013A")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
		[Cpp2IlInjected.Token(Token = "0x600013B")]
		[Cpp2IlInjected.Address(Slot = "1")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000052")]
	MMGNDNMMIBP MMLKKGELJEN
	{
		[Cpp2IlInjected.Token(Token = "0x600013C")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
		[Cpp2IlInjected.Token(Token = "0x600013D")]
		[Cpp2IlInjected.Address(Slot = "3")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000053")]
	Vector3 JPBKJMJLHIP
	{
		[Cpp2IlInjected.Token(Token = "0x600013E")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
		[Cpp2IlInjected.Token(Token = "0x600013F")]
		[Cpp2IlInjected.Address(Slot = "5")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000054")]
	Vector3 JBHKLEPEGOB
	{
		[Cpp2IlInjected.Token(Token = "0x6000140")]
		[Cpp2IlInjected.Address(Slot = "6")]
		get;
		[Cpp2IlInjected.Token(Token = "0x6000141")]
		[Cpp2IlInjected.Address(Slot = "7")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000055")]
	Vector3 DLGDIJHCFOO
	{
		[Cpp2IlInjected.Token(Token = "0x6000142")]
		[Cpp2IlInjected.Address(Slot = "8")]
		get;
		[Cpp2IlInjected.Token(Token = "0x6000143")]
		[Cpp2IlInjected.Address(Slot = "9")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000056")]
	Vector3 IALNOMAHNIJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000144")]
		[Cpp2IlInjected.Address(Slot = "10")]
		get;
		[Cpp2IlInjected.Token(Token = "0x6000145")]
		[Cpp2IlInjected.Address(Slot = "11")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000057")]
	float MJKJLPBOFLN
	{
		[Cpp2IlInjected.Token(Token = "0x6000146")]
		[Cpp2IlInjected.Address(Slot = "12")]
		get;
		[Cpp2IlInjected.Token(Token = "0x6000147")]
		[Cpp2IlInjected.Address(Slot = "13")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000058")]
	bool LNCPBHDEHDJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000148")]
		[Cpp2IlInjected.Address(Slot = "14")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000149")]
	[Cpp2IlInjected.Address(Slot = "15")]
	void FHOCOEECEGJ();

	[Cpp2IlInjected.Token(Token = "0x600014A")]
	[Cpp2IlInjected.Address(Slot = "16")]
	void BCIKHBDFKLF(object BECBHDDLOHA);

	[Cpp2IlInjected.Token(Token = "0x600014B")]
	[Cpp2IlInjected.Address(Slot = "17")]
	void JABLPCALLAE(BFLBDPBGGCC IFGLFJKEHHO, Vector3 FDPNNHOKDDC, float HNEJJEILEPA = float.PositiveInfinity);

	[Cpp2IlInjected.Token(Token = "0x600014C")]
	[Cpp2IlInjected.Address(Slot = "18")]
	void DMLJDHOMMFJ(PHFBBBOEHHE EOIBMOKJMCC, Vector3 GNPPKKBDPBJ, float CGEKJMEOLJJ, float GEEMEDNHPAN = 8f, float NAFGNOICJFA = 1f);

	[Cpp2IlInjected.Token(Token = "0x600014D")]
	[Cpp2IlInjected.Address(Slot = "19")]
	void KGDNPIGJGLI(BFLBDPBGGCC IFGLFJKEHHO, Vector3 NGPACIMGGNA, float BIKCCBHNJCE = 7f, float NNAMGLPMFOG = 1f);

	[Cpp2IlInjected.Token(Token = "0x600014E")]
	[Cpp2IlInjected.Address(Slot = "20")]
	void LBDAHKDHKHC();

	[Cpp2IlInjected.Token(Token = "0x600014F")]
	[Cpp2IlInjected.Address(Slot = "21")]
	void NGDEHOOAGPF();

	[Cpp2IlInjected.Token(Token = "0x6000150")]
	[Cpp2IlInjected.Address(Slot = "22")]
	void AHJOIIJCHIM();

	[Cpp2IlInjected.Token(Token = "0x6000151")]
	[Cpp2IlInjected.Address(Slot = "23")]
	void EDHPIKJPNMN();

	[Cpp2IlInjected.Token(Token = "0x6000152")]
	[Cpp2IlInjected.Address(Slot = "24")]
	void MDKOPLPDGML(Rigidbody DBPDLPLAFJF);

	[Cpp2IlInjected.Token(Token = "0x6000153")]
	[Cpp2IlInjected.Address(Slot = "25")]
	Vector3 EEBFPFCGOCD(Vector3 CGGOJBPICAG);

	[Cpp2IlInjected.Token(Token = "0x6000154")]
	[Cpp2IlInjected.Address(Slot = "26")]
	void PNIHJMKGADI(object BECBHDDLOHA);

	[Cpp2IlInjected.Token(Token = "0x6000155")]
	[Cpp2IlInjected.Address(Slot = "27")]
	void DHPIKNNCCHL(Vector3 MBFMENKJIAM);

	[Cpp2IlInjected.Token(Token = "0x6000156")]
	[Cpp2IlInjected.Address(Slot = "28")]
	void IEJPNHPPLAB(Vector3 GOGJNILJNEN, Vector3 KMMDBEFLDJJ);

	[Cpp2IlInjected.Token(Token = "0x6000157")]
	[Cpp2IlInjected.Address(Slot = "29")]
	void CEOJMJCIADC(Vector3 KLLLEBHFHNI, Vector3 KKAICPOLEBD);

	[Cpp2IlInjected.Token(Token = "0x6000158")]
	[Cpp2IlInjected.Address(Slot = "30")]
	Vector3 JPBKBCBBAEN(Vector3 CMGKIHAHNKG);

	[Cpp2IlInjected.Token(Token = "0x6000159")]
	[Cpp2IlInjected.Address(Slot = "31")]
	Vector3 KKDMCMANIMD(Vector3 BIDFFEOGLBL);
}
[Cpp2IlInjected.Token(Token = "0x200001A")]
[ServiceLifetime(Lifetime.Application)]
public interface EGFHJDMOPEO
{
	[Cpp2IlInjected.Token(Token = "0x17000059")]
	bool EIMMFILPKJM
	{
		[Cpp2IlInjected.Token(Token = "0x600015A")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x600015B")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void FHOFKLAMGJM(string OLIGKIPGKGK);

	[Cpp2IlInjected.Token(Token = "0x600015C")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void OMPHNJEHAKN(RigidbodyEx OGMEFONHICP, Action KPGBPPBMJJK);

	[Cpp2IlInjected.Token(Token = "0x600015D")]
	[Cpp2IlInjected.Address(Slot = "3")]
	GCANPHFAGBD HCBCKDOOLFM(int HLFICMFFBOA);

	[Cpp2IlInjected.Token(Token = "0x600015E")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void DNKHMMNJPBA(Vector3 FEHFLDNKBCE, float JHJCDHLDFCA, Color JJNDBAIEAAG);
}
[Cpp2IlInjected.Token(Token = "0x200001B")]
[ServiceLifetime(Lifetime.Application)]
public interface LNPBMAIDKPE
{
	[Cpp2IlInjected.Token(Token = "0x1700005A")]
	EGFHJDMOPEO INJOGOILMKA
	{
		[Cpp2IlInjected.Token(Token = "0x600015F")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700005B")]
	CNOPFBJJJEJ PCJPOGHCIII
	{
		[Cpp2IlInjected.Token(Token = "0x6000160")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000161")]
	[Cpp2IlInjected.Address(Slot = "2")]
	CKPEEOMOJJI CBOPHCMCJJL(RigidbodyEx OGMEFONHICP);
}
[Cpp2IlInjected.Token(Token = "0x200001C")]
public class NOOCONMHGMF : CKPEEOMOJJI, IDisposable, IAEAJGLODKC
{
	[Cpp2IlInjected.Token(Token = "0x4000019")]
	public static bool LPIAKJIFAOO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400001A")]
	internal readonly LNPBMAIDKPE BPDOIFAEGPF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400001B")]
	internal AIDCNLBLAJA HFNJMFEEMLC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400001C")]
	internal OFKNFCFBFKJ HFCFNKCFCFA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400001D")]
	internal NPMBGKJGIHC CGCIDAGGPDO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400001E")]
	internal EMIIHOMMAAN CGGOJBPICAG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x400001F")]
	internal IONNNKEBPAB KJMINMIBNLM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000020")]
	internal MHLJOKBMHID FADDFGFKAOK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000021")]
	internal EKJGDKIAJDP OBIAINKDCEE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000022")]
	internal FBLOLAIMBFH ABFINLIAPAJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x4000023")]
	internal JFNPBCAFDLA OKLPNMDFMLH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x4000024")]
	internal PDOINCHLDKK OOHHOCCGFKF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x4000025")]
	internal MALJIKLIKOO JDGLFIHGHKD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x4000026")]
	internal INIODDOAIFA BOOINJJDCOC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
	[Cpp2IlInjected.Token(Token = "0x4000027")]
	internal ADEFFAGNNKF HNHAKMKMFCG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x4000028")]
	internal LHOMDKGMMEN DBPDLPLAFJF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
	[Cpp2IlInjected.Token(Token = "0x4000029")]
	internal BEEDAICOJJB DLEALKOHCBN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
	[Cpp2IlInjected.Token(Token = "0x400002A")]
	internal IDisposable LIJMNKNCOIJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
	[Cpp2IlInjected.Token(Token = "0x400002B")]
	private bool FJKNGEPPPDL;

	[Cpp2IlInjected.Token(Token = "0x1700005C")]
	public ENAPEPFMDAJ IEABHEICCIM
	{
		[Cpp2IlInjected.Token(Token = "0x6000162")]
		[Cpp2IlInjected.Address(RVA = "0xA0C4C0", Offset = "0xA0AEC0", VA = "0x180A0C4C0", Slot = "22")]
		get
		{
			return default(ENAPEPFMDAJ);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700005D")]
	public LEOFMIOLMNC BAGOMHEIFMF
	{
		[Cpp2IlInjected.Token(Token = "0x6000163")]
		[Cpp2IlInjected.Address(RVA = "0xA6E630", Offset = "0xA6D030", VA = "0x180A6E630", Slot = "24")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000164")]
		[Cpp2IlInjected.Address(RVA = "0xA87000", Offset = "0xA85A00", VA = "0x180A87000")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700005E")]
	public GameObject MIGFNEFDENP
	{
		[Cpp2IlInjected.Token(Token = "0x6000165")]
		[Cpp2IlInjected.Address(RVA = "0xA0D3B0", Offset = "0xA0BDB0", VA = "0x180A0D3B0", Slot = "25")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000166")]
		[Cpp2IlInjected.Address(RVA = "0xA0D3C0", Offset = "0xA0BDC0", VA = "0x180A0D3C0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700005F")]
	public Transform OIBPIKEGOHJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000167")]
		[Cpp2IlInjected.Address(RVA = "0xA86FF0", Offset = "0xA859F0", VA = "0x180A86FF0", Slot = "26")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000168")]
		[Cpp2IlInjected.Address(RVA = "0xA871F0", Offset = "0xA85BF0", VA = "0x180A871F0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000060")]
	public Rigidbody NJDIIBKCONL
	{
		[Cpp2IlInjected.Token(Token = "0x6000169")]
		[Cpp2IlInjected.Address(RVA = "0x8536C70", Offset = "0x8535670", VA = "0x188536C70", Slot = "23")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000061")]
	public CKPEEOMOJJI IOJNNDJMALL
	{
		[Cpp2IlInjected.Token(Token = "0x600017A")]
		[Cpp2IlInjected.Address(RVA = "0x8536370", Offset = "0x8534D70", VA = "0x188536370", Slot = "27")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600017B")]
		[Cpp2IlInjected.Address(RVA = "0x85341E0", Offset = "0x8532BE0", VA = "0x1885341E0", Slot = "28")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000062")]
	public int FDCEHJBFHFJ
	{
		[Cpp2IlInjected.Token(Token = "0x600017C")]
		[Cpp2IlInjected.Address(RVA = "0x8534D60", Offset = "0x8533760", VA = "0x188534D60", Slot = "31")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000063")]
	public CKPEEOMOJJI PFOPMMBCMFB
	{
		[Cpp2IlInjected.Token(Token = "0x600017E")]
		[Cpp2IlInjected.Address(RVA = "0x8533650", Offset = "0x8532050", VA = "0x188533650", Slot = "29")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000064")]
	public bool FPFHCIFNHJK
	{
		[Cpp2IlInjected.Token(Token = "0x600017F")]
		[Cpp2IlInjected.Address(RVA = "0x8533EB0", Offset = "0x85328B0", VA = "0x188533EB0", Slot = "32")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000065")]
	public bool BEOAIADIFDD
	{
		[Cpp2IlInjected.Token(Token = "0x6000183")]
		[Cpp2IlInjected.Address(RVA = "0x8532080", Offset = "0x8530A80", VA = "0x188532080", Slot = "33")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000066")]
	public bool DHDBIEJCKNP
	{
		[Cpp2IlInjected.Token(Token = "0x6000184")]
		[Cpp2IlInjected.Address(RVA = "0x85363C0", Offset = "0x8534DC0", VA = "0x1885363C0", Slot = "34")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000067")]
	public FJBHJEKKKOJ ALHFICIODDP
	{
		[Cpp2IlInjected.Token(Token = "0x6000185")]
		[Cpp2IlInjected.Address(RVA = "0x8537060", Offset = "0x8535A60", VA = "0x188537060", Slot = "35")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000186")]
		[Cpp2IlInjected.Address(RVA = "0x8534030", Offset = "0x8532A30", VA = "0x188534030", Slot = "36")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000068")]
	public MMGNDNMMIBP MMLKKGELJEN
	{
		[Cpp2IlInjected.Token(Token = "0x6000187")]
		[Cpp2IlInjected.Address(RVA = "0x85333B0", Offset = "0x8531DB0", VA = "0x1885333B0", Slot = "37")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000188")]
		[Cpp2IlInjected.Address(RVA = "0x8534DE0", Offset = "0x85337E0", VA = "0x188534DE0", Slot = "38")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000069")]
	public float MJKJLPBOFLN
	{
		[Cpp2IlInjected.Token(Token = "0x6000189")]
		[Cpp2IlInjected.Address(RVA = "0x8534240", Offset = "0x8532C40", VA = "0x188534240", Slot = "39")]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x600018A")]
		[Cpp2IlInjected.Address(RVA = "0x85315D0", Offset = "0x852FFD0", VA = "0x1885315D0", Slot = "40")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700006A")]
	public Vector3 JBHKLEPEGOB
	{
		[Cpp2IlInjected.Token(Token = "0x600018B")]
		[Cpp2IlInjected.Address(RVA = "0x85350D0", Offset = "0x8533AD0", VA = "0x1885350D0", Slot = "41")]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x600018C")]
		[Cpp2IlInjected.Address(RVA = "0x8531A70", Offset = "0x8530470", VA = "0x188531A70", Slot = "42")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700006B")]
	public Vector3 IALNOMAHNIJ
	{
		[Cpp2IlInjected.Token(Token = "0x600018D")]
		[Cpp2IlInjected.Address(RVA = "0x8533AE0", Offset = "0x85324E0", VA = "0x188533AE0", Slot = "43")]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x600018E")]
		[Cpp2IlInjected.Address(RVA = "0x8534E40", Offset = "0x8533840", VA = "0x188534E40", Slot = "44")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700006C")]
	public Vector3 JPBKJMJLHIP
	{
		[Cpp2IlInjected.Token(Token = "0x600018F")]
		[Cpp2IlInjected.Address(RVA = "0x85338C0", Offset = "0x85322C0", VA = "0x1885338C0", Slot = "45")]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x6000190")]
		[Cpp2IlInjected.Address(RVA = "0x85321C0", Offset = "0x8530BC0", VA = "0x1885321C0", Slot = "46")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700006D")]
	public Vector3 DLGDIJHCFOO
	{
		[Cpp2IlInjected.Token(Token = "0x6000191")]
		[Cpp2IlInjected.Address(RVA = "0x85370B0", Offset = "0x8535AB0", VA = "0x1885370B0", Slot = "47")]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x6000192")]
		[Cpp2IlInjected.Address(RVA = "0x8536240", Offset = "0x8534C40", VA = "0x188536240", Slot = "48")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700006E")]
	public bool JLDPCDKAHFN
	{
		[Cpp2IlInjected.Token(Token = "0x6000193")]
		[Cpp2IlInjected.Address(RVA = "0x8536600", Offset = "0x8535000", VA = "0x188536600", Slot = "49")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700006F")]
	public bool ONKMJCCBADM
	{
		[Cpp2IlInjected.Token(Token = "0x6000194")]
		[Cpp2IlInjected.Address(RVA = "0x8535BB0", Offset = "0x85345B0", VA = "0x188535BB0", Slot = "50")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000070")]
	public bool JCLDBNACAOP
	{
		[Cpp2IlInjected.Token(Token = "0x6000195")]
		[Cpp2IlInjected.Address(RVA = "0x85337E0", Offset = "0x85321E0", VA = "0x1885337E0", Slot = "51")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000071")]
	public bool LNCPBHDEHDJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000196")]
		[Cpp2IlInjected.Address(RVA = "0x8534190", Offset = "0x8532B90", VA = "0x188534190", Slot = "52")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000072")]
	public Vector3 BJMHMKHBLHP
	{
		[Cpp2IlInjected.Token(Token = "0x60001A7")]
		[Cpp2IlInjected.Address(RVA = "0x8535E80", Offset = "0x8534880", VA = "0x188535E80", Slot = "53")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000073")]
	public Vector3 CILPBKBJNOD
	{
		[Cpp2IlInjected.Token(Token = "0x60001A8")]
		[Cpp2IlInjected.Address(RVA = "0x8536160", Offset = "0x8534B60", VA = "0x188536160", Slot = "54")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000074")]
	public Vector3 CBMDODIHBDD
	{
		[Cpp2IlInjected.Token(Token = "0x60001AD")]
		[Cpp2IlInjected.Address(RVA = "0x8534290", Offset = "0x8532C90", VA = "0x188534290", Slot = "55")]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x60001AE")]
		[Cpp2IlInjected.Address(RVA = "0x8532F20", Offset = "0x8531920", VA = "0x188532F20", Slot = "56")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000075")]
	public Vector3 GNEAMFDMGFL
	{
		[Cpp2IlInjected.Token(Token = "0x60001AF")]
		[Cpp2IlInjected.Address(RVA = "0x85344A0", Offset = "0x8532EA0", VA = "0x1885344A0", Slot = "57")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000076")]
	public float ABAPMFBJMKO
	{
		[Cpp2IlInjected.Token(Token = "0x60001B0")]
		[Cpp2IlInjected.Address(RVA = "0x8532030", Offset = "0x8530A30", VA = "0x188532030", Slot = "58")]
		get
		{
			return default(float);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000077")]
	public float LMMEKHANDPM
	{
		[Cpp2IlInjected.Token(Token = "0x60001B1")]
		[Cpp2IlInjected.Address(RVA = "0x8533D50", Offset = "0x8532750", VA = "0x188533D50", Slot = "59")]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x60001B2")]
		[Cpp2IlInjected.Address(RVA = "0x8534F20", Offset = "0x8533920", VA = "0x188534F20", Slot = "60")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000078")]
	public Vector3 MMDHKNKKPNC
	{
		[Cpp2IlInjected.Token(Token = "0x60001B3")]
		[Cpp2IlInjected.Address(RVA = "0x8536650", Offset = "0x8535050", VA = "0x188536650", Slot = "61")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000079")]
	public Quaternion HECHIIJBGHD
	{
		[Cpp2IlInjected.Token(Token = "0x60001B4")]
		[Cpp2IlInjected.Address(RVA = "0x8537300", Offset = "0x8535D00", VA = "0x188537300", Slot = "62")]
		get
		{
			return default(Quaternion);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700007A")]
	public float DPMLBPCNACO
	{
		[Cpp2IlInjected.Token(Token = "0x60001B9")]
		[Cpp2IlInjected.Address(RVA = "0x8536320", Offset = "0x8534D20", VA = "0x188536320", Slot = "64")]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x60001BA")]
		[Cpp2IlInjected.Address(RVA = "0x8531370", Offset = "0x852FD70", VA = "0x188531370", Slot = "65")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700007B")]
	public float LOFGGINBDGJ
	{
		[Cpp2IlInjected.Token(Token = "0x60001BB")]
		[Cpp2IlInjected.Address(RVA = "0x8536DE0", Offset = "0x85357E0", VA = "0x188536DE0", Slot = "66")]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x60001BC")]
		[Cpp2IlInjected.Address(RVA = "0x8536C10", Offset = "0x8535610", VA = "0x188536C10", Slot = "67")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700007C")]
	public bool GCOGCFPFCML
	{
		[Cpp2IlInjected.Token(Token = "0x60001BD")]
		[Cpp2IlInjected.Address(RVA = "0x8536B10", Offset = "0x8535510", VA = "0x188536B10", Slot = "68")]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x60001BE")]
		[Cpp2IlInjected.Address(RVA = "0x8531A10", Offset = "0x8530410", VA = "0x188531A10", Slot = "69")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700007D")]
	public BJFKEGNANDB DNEPNLLILDF
	{
		[Cpp2IlInjected.Token(Token = "0x60001C6")]
		[Cpp2IlInjected.Address(RVA = "0x8536E30", Offset = "0x8535830", VA = "0x188536E30", Slot = "70")]
		get
		{
			return default(BJFKEGNANDB);
		}
		[Cpp2IlInjected.Token(Token = "0x60001C7")]
		[Cpp2IlInjected.Address(RVA = "0x8533060", Offset = "0x8531A60", VA = "0x188533060", Slot = "71")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700007E")]
	public bool OOFIBNOFLPB
	{
		[Cpp2IlInjected.Token(Token = "0x60001CA")]
		[Cpp2IlInjected.Address(RVA = "0x8534F80", Offset = "0x8533980", VA = "0x188534F80", Slot = "72")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700007F")]
	public Transform IAACOHLGKNG
	{
		[Cpp2IlInjected.Token(Token = "0x60001D0")]
		[Cpp2IlInjected.Address(RVA = "0xA86FF0", Offset = "0xA859F0", VA = "0x180A86FF0", Slot = "73")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000080")]
	public Vector3 EOGIJAHENMC
	{
		[Cpp2IlInjected.Token(Token = "0x60001D1")]
		[Cpp2IlInjected.Address(RVA = "0x8534B50", Offset = "0x8533550", VA = "0x188534B50", Slot = "74")]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x60001D2")]
		[Cpp2IlInjected.Address(RVA = "0x85335A0", Offset = "0x8531FA0", VA = "0x1885335A0", Slot = "75")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000081")]
	public float AOIEPNMLFAF
	{
		[Cpp2IlInjected.Token(Token = "0x60001D3")]
		[Cpp2IlInjected.Address(RVA = "0x8534DD0", Offset = "0x85337D0", VA = "0x188534DD0", Slot = "76")]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x60001D4")]
		[Cpp2IlInjected.Address(RVA = "0x8533DA0", Offset = "0x85327A0", VA = "0x188533DA0", Slot = "77")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000082")]
	public float KJAMDDODCBM
	{
		[Cpp2IlInjected.Token(Token = "0x60001D5")]
		[Cpp2IlInjected.Address(RVA = "0x8531EB0", Offset = "0x85308B0", VA = "0x188531EB0", Slot = "78")]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x60001D6")]
		[Cpp2IlInjected.Address(RVA = "0x8537620", Offset = "0x8536020", VA = "0x188537620", Slot = "79")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000083")]
	public Quaternion CCFEOIPMMIL
	{
		[Cpp2IlInjected.Token(Token = "0x60001D7")]
		[Cpp2IlInjected.Address(RVA = "0x8532D30", Offset = "0x8531730", VA = "0x188532D30", Slot = "80")]
		get
		{
			return default(Quaternion);
		}
		[Cpp2IlInjected.Token(Token = "0x60001D8")]
		[Cpp2IlInjected.Address(RVA = "0x85378A0", Offset = "0x85362A0", VA = "0x1885378A0", Slot = "81")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000084")]
	public Vector3 PLJHMEAKAHG
	{
		[Cpp2IlInjected.Token(Token = "0x60001D9")]
		[Cpp2IlInjected.Address(RVA = "0x8533400", Offset = "0x8531E00", VA = "0x188533400", Slot = "82")]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x60001DA")]
		[Cpp2IlInjected.Address(RVA = "0x8532550", Offset = "0x8530F50", VA = "0x188532550", Slot = "83")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000085")]
	public Quaternion EIPFKNEOAEP
	{
		[Cpp2IlInjected.Token(Token = "0x60001DB")]
		[Cpp2IlInjected.Address(RVA = "0x85316F0", Offset = "0x85300F0", VA = "0x1885316F0", Slot = "84")]
		get
		{
			return default(Quaternion);
		}
		[Cpp2IlInjected.Token(Token = "0x60001DC")]
		[Cpp2IlInjected.Address(RVA = "0x85322A0", Offset = "0x8530CA0", VA = "0x1885322A0", Slot = "85")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000086")]
	public RigidbodyConstraints NDAJLCONCBK
	{
		[Cpp2IlInjected.Token(Token = "0x60001E0")]
		[Cpp2IlInjected.Address(RVA = "0x8533550", Offset = "0x8531F50", VA = "0x188533550", Slot = "86")]
		get
		{
			return default(RigidbodyConstraints);
		}
		[Cpp2IlInjected.Token(Token = "0x60001E1")]
		[Cpp2IlInjected.Address(RVA = "0x8533BC0", Offset = "0x85325C0", VA = "0x188533BC0", Slot = "87")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000087")]
	public bool GMGDAJFJIKK
	{
		[Cpp2IlInjected.Token(Token = "0x60001E2")]
		[Cpp2IlInjected.Address(RVA = "0x85349E0", Offset = "0x85333E0", VA = "0x1885349E0", Slot = "88")]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x60001E3")]
		[Cpp2IlInjected.Address(RVA = "0x85319B0", Offset = "0x85303B0", VA = "0x1885319B0", Slot = "89")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000088")]
	public CollisionDetectionMode OPPKJLMOMMG
	{
		[Cpp2IlInjected.Token(Token = "0x60001EC")]
		[Cpp2IlInjected.Address(RVA = "0x8532420", Offset = "0x8530E20", VA = "0x188532420", Slot = "90")]
		get
		{
			return default(CollisionDetectionMode);
		}
		[Cpp2IlInjected.Token(Token = "0x60001ED")]
		[Cpp2IlInjected.Address(RVA = "0x8534580", Offset = "0x8532F80", VA = "0x188534580", Slot = "91")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000089")]
	public bool LDPCDFPKINP
	{
		[Cpp2IlInjected.Token(Token = "0x60001EF")]
		[Cpp2IlInjected.Address(RVA = "0x85348A0", Offset = "0x85332A0", VA = "0x1885348A0", Slot = "141")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700008A")]
	public bool CICIBBPAKND
	{
		[Cpp2IlInjected.Token(Token = "0x60001F0")]
		[Cpp2IlInjected.Address(RVA = "0x8534720", Offset = "0x8533120", VA = "0x188534720", Slot = "92")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000017")]
	public event KANEOGHNJFB HEDEIKCGPFF
	{
		[Cpp2IlInjected.Token(Token = "0x6000174")]
		[Cpp2IlInjected.Address(RVA = "0x8534AF0", Offset = "0x85334F0", VA = "0x188534AF0", Slot = "4")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000175")]
		[Cpp2IlInjected.Address(RVA = "0x8536460", Offset = "0x8534E60", VA = "0x188536460", Slot = "5")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000018")]
	public event KANEOGHNJFB OFIKEGHAAJA
	{
		[Cpp2IlInjected.Token(Token = "0x6000176")]
		[Cpp2IlInjected.Address(RVA = "0x8534C00", Offset = "0x8533600", VA = "0x188534C00", Slot = "6")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000177")]
		[Cpp2IlInjected.Address(RVA = "0x8534A90", Offset = "0x8533490", VA = "0x188534A90", Slot = "7")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000019")]
	public event FMMFANILCNM HJNHKBJIAMO
	{
		[Cpp2IlInjected.Token(Token = "0x6000178")]
		[Cpp2IlInjected.Address(RVA = "0x8532810", Offset = "0x8531210", VA = "0x188532810", Slot = "18")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000179")]
		[Cpp2IlInjected.Address(RVA = "0x8535390", Offset = "0x8533D90", VA = "0x188535390", Slot = "19")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400001A")]
	public event KANEOGHNJFB AIFDABJDFDJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000181")]
		[Cpp2IlInjected.Address(RVA = "0x8536CC0", Offset = "0x85356C0", VA = "0x188536CC0", Slot = "8")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000182")]
		[Cpp2IlInjected.Address(RVA = "0x8535330", Offset = "0x8533D30", VA = "0x188535330", Slot = "9")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400001B")]
	public event KANEOGHNJFB OIIABNPPGHG
	{
		[Cpp2IlInjected.Token(Token = "0x60001AB")]
		[Cpp2IlInjected.Address(RVA = "0x85373D0", Offset = "0x8535DD0", VA = "0x1885373D0", Slot = "14")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60001AC")]
		[Cpp2IlInjected.Address(RVA = "0x8535C10", Offset = "0x8534610", VA = "0x188535C10", Slot = "15")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400001C")]
	public event KANEOGHNJFB NHDMNCBOADE
	{
		[Cpp2IlInjected.Token(Token = "0x60001BF")]
		[Cpp2IlInjected.Address(RVA = "0x8537980", Offset = "0x8536380", VA = "0x188537980", Slot = "16")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60001C0")]
		[Cpp2IlInjected.Address(RVA = "0x85365A0", Offset = "0x8534FA0", VA = "0x1885365A0", Slot = "17")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400001D")]
	public event Action<AMDCJLIPDMO, AMDCJLIPDMO> OOAPNHDFBKM
	{
		[Cpp2IlInjected.Token(Token = "0x60001C4")]
		[Cpp2IlInjected.Address(RVA = "0x8535B00", Offset = "0x8534500", VA = "0x188535B00", Slot = "20")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60001C5")]
		[Cpp2IlInjected.Address(RVA = "0x8534A30", Offset = "0x8533430", VA = "0x188534A30", Slot = "21")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400001E")]
	public event KANEOGHNJFB NCDNCOALOHG
	{
		[Cpp2IlInjected.Token(Token = "0x60001C8")]
		[Cpp2IlInjected.Address(RVA = "0x85330C0", Offset = "0x8531AC0", VA = "0x1885330C0", Slot = "12")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60001C9")]
		[Cpp2IlInjected.Address(RVA = "0x8536AB0", Offset = "0x85354B0", VA = "0x188536AB0", Slot = "13")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400001F")]
	public event KANEOGHNJFB KPEPBJELKCA
	{
		[Cpp2IlInjected.Token(Token = "0x60001CE")]
		[Cpp2IlInjected.Address(RVA = "0x8537570", Offset = "0x8535F70", VA = "0x188537570", Slot = "10")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60001CF")]
		[Cpp2IlInjected.Address(RVA = "0x85353F0", Offset = "0x8533DF0", VA = "0x1885353F0", Slot = "11")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600016A")]
	[Cpp2IlInjected.Address(RVA = "0x8537A20", Offset = "0x8536420", VA = "0x188537A20")]
	public NOOCONMHGMF(GameObject HNGFDIJGINB, RigidbodyEx PDCPAHOHNBP, LNPBMAIDKPE BPDOIFAEGPF, [In] GCMIBKGIHPB HPGIDELCODH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600016B")]
	[Cpp2IlInjected.Address(RVA = "0x8532970", Offset = "0x8531370", VA = "0x188532970", Slot = "139")]
	protected virtual void EADIMAFGCOK(LNPBMAIDKPE BPDOIFAEGPF, GCMIBKGIHPB HPGIDELCODH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600016C")]
	[Cpp2IlInjected.Address(RVA = "0x8532870", Offset = "0x8531270", VA = "0x188532870", Slot = "140")]
	public virtual void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600016D")]
	[Cpp2IlInjected.Address(RVA = "0x85336A0", Offset = "0x85320A0", VA = "0x1885336A0", Slot = "93")]
	public void FHOCOEECEGJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600016E")]
	[Cpp2IlInjected.Address(RVA = "0x8532390", Offset = "0x8530D90", VA = "0x188532390", Slot = "94")]
	public void DEKCPONMMBI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600016F")]
	[Cpp2IlInjected.Address(RVA = "0x8536E80", Offset = "0x8535880", VA = "0x188536E80", Slot = "95")]
	public void OHPCGLJDAHC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000170")]
	[Cpp2IlInjected.Address(RVA = "0x8535F50", Offset = "0x8534950", VA = "0x188535F50", Slot = "96")]
	public void LKDJELHONKA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000171")]
	[Cpp2IlInjected.Address(RVA = "0x8531730", Offset = "0x8530130", VA = "0x188531730")]
	private void BADDFBDBPGF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000172")]
	[Cpp2IlInjected.Address(RVA = "0x8533F10", Offset = "0x8532910", VA = "0x188533F10")]
	private void HEHLDEMOMLA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000173")]
	[Cpp2IlInjected.Address(RVA = "0x8535AA0", Offset = "0x85344A0", VA = "0x188535AA0")]
	private void KPNFFEMNEMA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600017D")]
	[Cpp2IlInjected.Address(RVA = "0x8533E30", Offset = "0x8532830", VA = "0x188533E30", Slot = "30")]
	public CKPEEOMOJJI HBBGKOKBEPF(int MNFHMLCLFEB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000180")]
	[Cpp2IlInjected.Address(RVA = "0x8536D20", Offset = "0x8535720", VA = "0x188536D20", Slot = "98")]
	public void ODCKPPKNECL(CKPEEOMOJJI PCDAHJCDHHF, bool MPNHLGBIEGE = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000197")]
	[Cpp2IlInjected.Address(RVA = "0x8532330", Offset = "0x8530D30", VA = "0x188532330", Slot = "99")]
	public void DDMBMLMAOKE(object BECBHDDLOHA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000198")]
	[Cpp2IlInjected.Address(RVA = "0x8533000", Offset = "0x8531A00", VA = "0x188533000", Slot = "100")]
	public void EIHKKIIHKIM(object BECBHDDLOHA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000199")]
	[Cpp2IlInjected.Address(RVA = "0x8535550", Offset = "0x8533F50", VA = "0x188535550", Slot = "101")]
	public Vector3 KKDMCMANIMD(Vector3 BIDFFEOGLBL)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x600019A")]
	[Cpp2IlInjected.Address(RVA = "0x8534FD0", Offset = "0x85339D0", VA = "0x188534FD0", Slot = "102")]
	public Vector3 JPBKBCBBAEN(Vector3 CMGKIHAHNKG)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x600019B")]
	[Cpp2IlInjected.Address(RVA = "0x8532DD0", Offset = "0x85317D0", VA = "0x188532DD0", Slot = "103")]
	public void EDHPIKJPNMN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600019C")]
	[Cpp2IlInjected.Address(RVA = "0x8536B60", Offset = "0x8535560", VA = "0x188536B60", Slot = "104")]
	public void NGDEHOOAGPF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600019D")]
	[Cpp2IlInjected.Address(RVA = "0x8535B60", Offset = "0x8534560", VA = "0x188535B60", Slot = "105")]
	public void LBDAHKDHKHC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600019E")]
	[Cpp2IlInjected.Address(RVA = "0x85320D0", Offset = "0x8530AD0", VA = "0x1885320D0", Slot = "106")]
	public void CEOJMJCIADC(Vector3 KLLLEBHFHNI, Vector3 KKAICPOLEBD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600019F")]
	[Cpp2IlInjected.Address(RVA = "0x8534630", Offset = "0x8533030", VA = "0x188534630", Slot = "107")]
	public void IEJPNHPPLAB(Vector3 GOGJNILJNEN, Vector3 KMMDBEFLDJJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001A0")]
	[Cpp2IlInjected.Address(RVA = "0x8532470", Offset = "0x8530E70", VA = "0x188532470", Slot = "108")]
	public void DHPIKNNCCHL(Vector3 MBFMENKJIAM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001A1")]
	[Cpp2IlInjected.Address(RVA = "0x8532600", Offset = "0x8531000", VA = "0x188532600", Slot = "109")]
	public void DMLJDHOMMFJ(PHFBBBOEHHE EOIBMOKJMCC, Vector3 GNPPKKBDPBJ, float CGEKJMEOLJJ, float GEEMEDNHPAN = 8f, float NAFGNOICJFA = 1f)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001A2")]
	[Cpp2IlInjected.Address(RVA = "0x8534C60", Offset = "0x8533660", VA = "0x188534C60", Slot = "110")]
	public void JABLPCALLAE(BFLBDPBGGCC IFGLFJKEHHO, Vector3 FDPNNHOKDDC, float HNEJJEILEPA = float.PositiveInfinity)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001A3")]
	[Cpp2IlInjected.Address(RVA = "0x85354A0", Offset = "0x8533EA0", VA = "0x1885354A0", Slot = "111")]
	[Obsolete("Deprecated. Still exists to support deprecated CV2 chips. Use ApplyAngularVelocityChange.")]
	public void KGDNPIGJGLI(BFLBDPBGGCC IFGLFJKEHHO, Vector3 NGPACIMGGNA, float BIKCCBHNJCE = 7f, float NNAMGLPMFOG = 1f)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001A4")]
	[Cpp2IlInjected.Address(RVA = "0x8532E20", Offset = "0x8531820", VA = "0x188532E20", Slot = "112")]
	public Vector3 EEBFPFCGOCD(Vector3 PCDAHJCDHHF)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x60001A5")]
	[Cpp2IlInjected.Address(RVA = "0x8533250", Offset = "0x8531C50", VA = "0x188533250", Slot = "113")]
	public Vector3 ENPFPDOJAGF(Vector3 PCDAHJCDHHF)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x60001A6")]
	[Cpp2IlInjected.Address(RVA = "0x85316A0", Offset = "0x85300A0", VA = "0x1885316A0", Slot = "114")]
	public void AHJOIIJCHIM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001A9")]
	[Cpp2IlInjected.Address(RVA = "0x8531630", Offset = "0x8530030", VA = "0x188531630", Slot = "115")]
	public void AHFJHFHBMOF(CKPEEOMOJJI JJHMEOPMAEJ, object BECBHDDLOHA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001AA")]
	[Cpp2IlInjected.Address(RVA = "0x8537510", Offset = "0x8535F10", VA = "0x188537510", Slot = "116")]
	public void PGJGNIMLBNG(object BECBHDDLOHA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001B5")]
	[Cpp2IlInjected.Address(RVA = "0x8535200", Offset = "0x8533C00", VA = "0x188535200", Slot = "63")]
	public void KDFIPNDDFHG((Quaternion rot, Vector3 moments) HMJIJMLCIDN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001B6")]
	[Cpp2IlInjected.Address(RVA = "0x85345E0", Offset = "0x8532FE0", VA = "0x1885345E0", Slot = "117")]
	public void ICFMKMGKFPN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001B7")]
	[Cpp2IlInjected.Address(RVA = "0x8536410", Offset = "0x8534E10", VA = "0x188536410", Slot = "118")]
	public void MINPMAPDKEN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001B8")]
	[Cpp2IlInjected.Address(RVA = "0x8536D90", Offset = "0x8535790", VA = "0x188536D90", Slot = "119")]
	public void OEFGFHILMEM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001C1")]
	[Cpp2IlInjected.Address(RVA = "0x8537720", Offset = "0x8536120", VA = "0x188537720", Slot = "120")]
	public bool PMHMCBPHCIC()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001C2")]
	[Cpp2IlInjected.Address(RVA = "0x85351B0", Offset = "0x8533BB0", VA = "0x1885351B0", Slot = "97")]
	public void KBIKDALDOIA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001C3")]
	[Cpp2IlInjected.Address(RVA = "0x8534120", Offset = "0x8532B20", VA = "0x188534120", Slot = "121")]
	public void HHPGCIJHADF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001CB")]
	[Cpp2IlInjected.Address(RVA = "0x85339A0", Offset = "0x85323A0", VA = "0x1885339A0", Slot = "122")]
	public void FPDDDLNGNCI(object BECBHDDLOHA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001CC")]
	[Cpp2IlInjected.Address(RVA = "0x8535C70", Offset = "0x8534670", VA = "0x188535C70", Slot = "123")]
	public void LDDOMOEOJNM(object BECBHDDLOHA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001CD")]
	[Cpp2IlInjected.Address(RVA = "0x8532590", Offset = "0x8530F90", VA = "0x188532590", Slot = "124")]
	public void DJIMFIKFOJP(object BECBHDDLOHA, bool PLIDCHGGBAD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001DD")]
	[Cpp2IlInjected.Address(RVA = "0x85313D0", Offset = "0x852FDD0", VA = "0x1885313D0", Slot = "125")]
	public void AEMNKMKJHEE(Vector3 AKALCNGHLHF, Quaternion GKIBONHCOLJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001DE")]
	[Cpp2IlInjected.Address(RVA = "0x8533120", Offset = "0x8531B20", VA = "0x188533120", Slot = "126")]
	public void ENCHELFBAHD(Vector3 NIIDLMFIKHH, Quaternion HBPPPKIDAOE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001DF")]
	[Cpp2IlInjected.Address(RVA = "0x8533C20", Offset = "0x8532620", VA = "0x188533C20", Slot = "127")]
	public bool GNDEKIGLJOM(float EMHHPNBMOLH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001E4")]
	[Cpp2IlInjected.Address(RVA = "0x8533350", Offset = "0x8531D50", VA = "0x188533350", Slot = "128")]
	public void EONFLKLMHBH(object BECBHDDLOHA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001E5")]
	[Cpp2IlInjected.Address(RVA = "0x85372A0", Offset = "0x8535CA0", VA = "0x1885372A0", Slot = "129")]
	public void OPJKAHIKPBE(object BECBHDDLOHA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001E6")]
	[Cpp2IlInjected.Address(RVA = "0x8536BB0", Offset = "0x85355B0", VA = "0x188536BB0", Slot = "130")]
	public void NGENBHLPLCE(object BECBHDDLOHA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001E7")]
	[Cpp2IlInjected.Address(RVA = "0x85322D0", Offset = "0x8530CD0", VA = "0x1885322D0", Slot = "131")]
	public void DCFIAPPHDDC(object BECBHDDLOHA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001E8")]
	[Cpp2IlInjected.Address(RVA = "0x8533C70", Offset = "0x8532670", VA = "0x188533C70", Slot = "132")]
	public void GNDHMCFEFFI(Vector3 BOOINJJDCOC, ForceMode OBFDKNANAGO = ForceMode.Force)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001E9")]
	[Cpp2IlInjected.Address(RVA = "0x8533440", Offset = "0x8531E40", VA = "0x188533440", Slot = "133")]
	public void FFLEEFDDKDM(Vector3 BOOINJJDCOC, Vector3 JFMEMBGKAOB, ForceMode OBFDKNANAGO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001EA")]
	[Cpp2IlInjected.Address(RVA = "0x8537430", Offset = "0x8535E30", VA = "0x188537430", Slot = "134")]
	public void PEDLDKMBEOD(Vector3 CMHJLKLDGIM, ForceMode OBFDKNANAGO = ForceMode.Force)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001EB")]
	[Cpp2IlInjected.Address(RVA = "0x8533A00", Offset = "0x8532400", VA = "0x188533A00", Slot = "135")]
	public void GCJDDPBLICH(Vector3 CMHJLKLDGIM, ForceMode OBFDKNANAGO = ForceMode.Force)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001EE")]
	[Cpp2IlInjected.Address(RVA = "0x8533F90", Offset = "0x8532990", VA = "0x188533F90", Slot = "136")]
	public bool HEOJEJIIFPB(Vector3 HPCBBMBEKNN, [Out] RaycastHit KGJLOFPICLA, float LCMAOMAPNJJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001F1")]
	[Cpp2IlInjected.Address(RVA = "0x85352E0", Offset = "0x8533CE0", VA = "0x1885352E0", Slot = "137")]
	public void KEAMPKLDOJP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001F2")]
	[Cpp2IlInjected.Address(RVA = "0x85379E0", Offset = "0x85363E0", VA = "0x1885379E0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001F3")]
	[Cpp2IlInjected.Address(RVA = "0x85364C0", Offset = "0x8534EC0", VA = "0x1885364C0")]
	private void MMNNLEMGMLD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001F4")]
	[Cpp2IlInjected.Address(RVA = "0x8537190", Offset = "0x8535B90", VA = "0x188537190")]
	private void OPENJDOGCFI(CKPEEOMOJJI EAGGHBKHKHF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001F5")]
	[Cpp2IlInjected.Address(RVA = "0x8535F70", Offset = "0x8534970", VA = "0x188535F70")]
	private void LKFADBIGCLG(CKPEEOMOJJI EAGGHBKHKHF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001F6")]
	[Cpp2IlInjected.Address(RVA = "0x8536EE0", Offset = "0x85358E0", VA = "0x188536EE0")]
	private void OJOFKKJKCJN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001F7")]
	[Cpp2IlInjected.Address(RVA = "0x8537770", Offset = "0x8536170", VA = "0x188537770")]
	private void PNGMIMEHOHP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001F8")]
	[Cpp2IlInjected.Address(RVA = "0x8535CD0", Offset = "0x85346D0", VA = "0x188535CD0")]
	private void LGDJJDGFHOH(CKPEEOMOJJI PCAJKGLMDAK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001F9")]
	[Cpp2IlInjected.Address(RVA = "0x8536F90", Offset = "0x8535990", VA = "0x188536F90")]
	private void OKGNDLLEDLC(CKPEEOMOJJI EAGGHBKHKHF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001FA")]
	[Cpp2IlInjected.Address(RVA = "0x8532C60", Offset = "0x8531660", VA = "0x188532C60")]
	private void EAPNLDPEEMK(CKPEEOMOJJI EAGGHBKHKHF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001FB")]
	[Cpp2IlInjected.Address(RVA = "0x85326C0", Offset = "0x85310C0", VA = "0x1885326C0")]
	private void DNEKNLOCKKI(LEOFMIOLMNC EAGGHBKHKHF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001FC")]
	[Cpp2IlInjected.Address(RVA = "0x8535650", Offset = "0x8534050", VA = "0x188535650", Slot = "142")]
	protected virtual void KLALHLALLFC(LEOFMIOLMNC OGMEFONHICP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001FD")]
	[Cpp2IlInjected.Address(RVA = "0x8531B50", Offset = "0x8530550", VA = "0x188531B50")]
	protected void BIMLGFFLANA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001FE")]
	[Cpp2IlInjected.Address(RVA = "0x8536730", Offset = "0x8535130", VA = "0x188536730")]
	protected void NCMAJHMAKBP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001FF")]
	[Cpp2IlInjected.Address(RVA = "0x8534370", Offset = "0x8532D70", VA = "0x188534370")]
	private void IAFBNBOBJME()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000200")]
	[Cpp2IlInjected.Address(RVA = "0x8531EC0", Offset = "0x85308C0", VA = "0x188531EC0")]
	private void BMFAJHDHMKA()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001D")]
internal static class CADFCDOEHHM
{
	[Cpp2IlInjected.Token(Token = "0x6000201")]
	[Cpp2IlInjected.Address(RVA = "0x8529410", Offset = "0x8527E10", VA = "0x188529410")]
	public static CKPEEOMOJJI ABEJNDHEMMD(this CKPEEOMOJJI OGMEFONHICP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000202")]
	[Cpp2IlInjected.Address(RVA = "0x85295F0", Offset = "0x8527FF0", VA = "0x1885295F0")]
	public static bool OIGJDHPBLIK(this CKPEEOMOJJI OGMEFONHICP, CKPEEOMOJJI FAKEOLEIJIO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000203")]
	[Cpp2IlInjected.Address(RVA = "0x85294D0", Offset = "0x8527ED0", VA = "0x1885294D0")]
	public static bool BGEDDBFLOLP(this CKPEEOMOJJI OGMEFONHICP, CKPEEOMOJJI NLBJIDEMDBN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000204")]
	[Cpp2IlInjected.Address(RVA = "0x8529690", Offset = "0x8528090", VA = "0x188529690")]
	public static LEOFMIOLMNC OPHHPLJAFOK(this CKPEEOMOJJI LALBBHEFJAE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000205")]
	[Cpp2IlInjected.Address(RVA = "0x8529570", Offset = "0x8527F70", VA = "0x188529570")]
	public static NOOCONMHGMF GEINCIDDCBM(this CKPEEOMOJJI LALBBHEFJAE)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200001E")]
public class LGMOPAOJFPO : CNOPFBJJJEJ
{
	[Cpp2IlInjected.Token(Token = "0x6000206")]
	[Cpp2IlInjected.Address(RVA = "0x852E890", Offset = "0x852D290", VA = "0x18852E890", Slot = "19")]
	public CKPEEOMOJJI CBOPHCMCJJL(RigidbodyEx OGMEFONHICP, GCMIBKGIHPB HPGIDELCODH, LNPBMAIDKPE BPDOIFAEGPF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000207")]
	[Cpp2IlInjected.Address(RVA = "0xA0C4C0", Offset = "0xA0AEC0", VA = "0x180A0C4C0", Slot = "4")]
	public AIDCNLBLAJA IMNMGFCGAPC(CKPEEOMOJJI LALBBHEFJAE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000208")]
	[Cpp2IlInjected.Address(RVA = "0xA0C4C0", Offset = "0xA0AEC0", VA = "0x180A0C4C0", Slot = "5")]
	public EMIIHOMMAAN LCNHJGJENBG(CKPEEOMOJJI LALBBHEFJAE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000209")]
	[Cpp2IlInjected.Address(RVA = "0xA0C4C0", Offset = "0xA0AEC0", VA = "0x180A0C4C0", Slot = "6")]
	public IONNNKEBPAB GFMHGKCGLOI(CKPEEOMOJJI LALBBHEFJAE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600020A")]
	[Cpp2IlInjected.Address(RVA = "0xA0C4C0", Offset = "0xA0AEC0", VA = "0x180A0C4C0", Slot = "7")]
	public EKJGDKIAJDP LHKDDABHFFI(CKPEEOMOJJI LALBBHEFJAE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600020B")]
	[Cpp2IlInjected.Address(RVA = "0xA0C4C0", Offset = "0xA0AEC0", VA = "0x180A0C4C0", Slot = "8")]
	public JFNPBCAFDLA HDJKOOOAGEP(CKPEEOMOJJI LALBBHEFJAE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600020C")]
	[Cpp2IlInjected.Address(RVA = "0xA0C4C0", Offset = "0xA0AEC0", VA = "0x180A0C4C0", Slot = "9")]
	public PDOINCHLDKK HBJBEBIOMNP(CKPEEOMOJJI LALBBHEFJAE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600020D")]
	[Cpp2IlInjected.Address(RVA = "0xA0C4C0", Offset = "0xA0AEC0", VA = "0x180A0C4C0", Slot = "10")]
	public MALJIKLIKOO ODNKMGMGKCH(CKPEEOMOJJI LALBBHEFJAE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600020E")]
	[Cpp2IlInjected.Address(RVA = "0xA0C4C0", Offset = "0xA0AEC0", VA = "0x180A0C4C0", Slot = "11")]
	public INIODDOAIFA GINPPBAKNDH(CKPEEOMOJJI LALBBHEFJAE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600020F")]
	[Cpp2IlInjected.Address(RVA = "0xA0C4C0", Offset = "0xA0AEC0", VA = "0x180A0C4C0", Slot = "12")]
	public BEEDAICOJJB KMCDPKBHKPN(CKPEEOMOJJI LALBBHEFJAE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000210")]
	[Cpp2IlInjected.Address(RVA = "0xA0C4C0", Offset = "0xA0AEC0", VA = "0x180A0C4C0", Slot = "13")]
	public FBLOLAIMBFH EGHJMOJHENN(CKPEEOMOJJI LALBBHEFJAE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000211")]
	[Cpp2IlInjected.Address(RVA = "0xA0C4C0", Offset = "0xA0AEC0", VA = "0x180A0C4C0")]
	public LHOMDKGMMEN GBENOHALCJN(CKPEEOMOJJI LALBBHEFJAE, [In] GCMIBKGIHPB HPGIDELCODH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000212")]
	[Cpp2IlInjected.Address(RVA = "0xA0C4C0", Offset = "0xA0AEC0", VA = "0x180A0C4C0")]
	public NPMBGKJGIHC PDDAEILCPHI(CKPEEOMOJJI LALBBHEFJAE, [In] GCMIBKGIHPB HPGIDELCODH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000213")]
	[Cpp2IlInjected.Address(RVA = "0xA0C4C0", Offset = "0xA0AEC0", VA = "0x180A0C4C0")]
	public OFKNFCFBFKJ KBKOCNCODNC(CKPEEOMOJJI LALBBHEFJAE, [In] GCMIBKGIHPB HPGIDELCODH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000214")]
	[Cpp2IlInjected.Address(RVA = "0xA0C4C0", Offset = "0xA0AEC0", VA = "0x180A0C4C0")]
	public MHLJOKBMHID NGHIHLDAAJO(CKPEEOMOJJI LALBBHEFJAE, [In] GCMIBKGIHPB HPGIDELCODH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000215")]
	[Cpp2IlInjected.Address(RVA = "0xA0C4C0", Offset = "0xA0AEC0", VA = "0x180A0C4C0")]
	public ADEFFAGNNKF FJKKKLJHINL(CKPEEOMOJJI LALBBHEFJAE, [In] GCMIBKGIHPB HPGIDELCODH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000216")]
	[Cpp2IlInjected.Address(RVA = "0xA104F0", Offset = "0xA0EEF0", VA = "0x180A104F0")]
	public LGMOPAOJFPO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000217")]
	[Cpp2IlInjected.Address(RVA = "0xA0C4C0", Offset = "0xA0AEC0", VA = "0x180A0C4C0", Slot = "14")]
	private LHOMDKGMMEN LKIGDMPEJPG(CKPEEOMOJJI LALBBHEFJAE, [In] GCMIBKGIHPB HPGIDELCODH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000218")]
	[Cpp2IlInjected.Address(RVA = "0xA0C4C0", Offset = "0xA0AEC0", VA = "0x180A0C4C0", Slot = "15")]
	private NPMBGKJGIHC OBMEPMPLAOC(CKPEEOMOJJI LALBBHEFJAE, [In] GCMIBKGIHPB HPGIDELCODH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000219")]
	[Cpp2IlInjected.Address(RVA = "0xA0C4C0", Offset = "0xA0AEC0", VA = "0x180A0C4C0", Slot = "16")]
	private OFKNFCFBFKJ HIMCAFBFIAF(CKPEEOMOJJI LALBBHEFJAE, [In] GCMIBKGIHPB HPGIDELCODH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600021A")]
	[Cpp2IlInjected.Address(RVA = "0xA0C4C0", Offset = "0xA0AEC0", VA = "0x180A0C4C0", Slot = "17")]
	private MHLJOKBMHID FFODJCFFGIP(CKPEEOMOJJI LALBBHEFJAE, [In] GCMIBKGIHPB HPGIDELCODH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600021B")]
	[Cpp2IlInjected.Address(RVA = "0xA0C4C0", Offset = "0xA0AEC0", VA = "0x180A0C4C0", Slot = "18")]
	private ADEFFAGNNKF BNJCCFFGLGE(CKPEEOMOJJI LALBBHEFJAE, [In] GCMIBKGIHPB HPGIDELCODH)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200001F")]
[RegisterService(typeof(CNOPFBJJJEJ), new string[] { })]
public class MCPINKIBIJC : CNOPFBJJJEJ, BOEGHMMFADM
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000030")]
	private readonly CNOPFBJJJEJ NDDCIBIGJJN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000031")]
	private readonly CNOPFBJJJEJ LNKEEANFIDI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000032")]
	private POCMHIMFGLC MFJLJCAHHGG;

	[Cpp2IlInjected.Token(Token = "0x1700008B")]
	private CNOPFBJJJEJ PCJPOGHCIII
	{
		[Cpp2IlInjected.Token(Token = "0x600021D")]
		[Cpp2IlInjected.Address(RVA = "0x852F490", Offset = "0x852DE90", VA = "0x18852F490")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600021C")]
	[Cpp2IlInjected.Address(RVA = "0x852F260", Offset = "0x852DC60", VA = "0x18852F260", Slot = "20")]
	public void InitReferences(FKFJNEKJHIE CCGCAONCGHG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600021E")]
	[Cpp2IlInjected.Address(RVA = "0x852F1C0", Offset = "0x852DBC0", VA = "0x18852F1C0", Slot = "4")]
	public AIDCNLBLAJA IMNMGFCGAPC(CKPEEOMOJJI LALBBHEFJAE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600021F")]
	[Cpp2IlInjected.Address(RVA = "0x852F350", Offset = "0x852DD50", VA = "0x18852F350", Slot = "5")]
	public EMIIHOMMAAN LCNHJGJENBG(CKPEEOMOJJI LALBBHEFJAE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000220")]
	[Cpp2IlInjected.Address(RVA = "0x852EE90", Offset = "0x852D890", VA = "0x18852EE90", Slot = "6")]
	public IONNNKEBPAB GFMHGKCGLOI(CKPEEOMOJJI LALBBHEFJAE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000221")]
	[Cpp2IlInjected.Address(RVA = "0x852F3F0", Offset = "0x852DDF0", VA = "0x18852F3F0", Slot = "7")]
	public EKJGDKIAJDP LHKDDABHFFI(CKPEEOMOJJI LALBBHEFJAE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000222")]
	[Cpp2IlInjected.Address(RVA = "0x852F070", Offset = "0x852DA70", VA = "0x18852F070", Slot = "8")]
	public JFNPBCAFDLA HDJKOOOAGEP(CKPEEOMOJJI LALBBHEFJAE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000223")]
	[Cpp2IlInjected.Address(RVA = "0x852EFD0", Offset = "0x852D9D0", VA = "0x18852EFD0", Slot = "9")]
	public PDOINCHLDKK HBJBEBIOMNP(CKPEEOMOJJI LALBBHEFJAE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000224")]
	[Cpp2IlInjected.Address(RVA = "0x852F5A0", Offset = "0x852DFA0", VA = "0x18852F5A0", Slot = "10")]
	public MALJIKLIKOO ODNKMGMGKCH(CKPEEOMOJJI LALBBHEFJAE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000225")]
	[Cpp2IlInjected.Address(RVA = "0x852EF30", Offset = "0x852D930", VA = "0x18852EF30", Slot = "11")]
	public INIODDOAIFA GINPPBAKNDH(CKPEEOMOJJI LALBBHEFJAE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000226")]
	[Cpp2IlInjected.Address(RVA = "0x852F2B0", Offset = "0x852DCB0", VA = "0x18852F2B0", Slot = "12")]
	public BEEDAICOJJB KMCDPKBHKPN(CKPEEOMOJJI LALBBHEFJAE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000227")]
	[Cpp2IlInjected.Address(RVA = "0x852EC90", Offset = "0x852D690", VA = "0x18852EC90", Slot = "13")]
	public FBLOLAIMBFH EGHJMOJHENN(CKPEEOMOJJI LALBBHEFJAE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000228")]
	[Cpp2IlInjected.Address(RVA = "0x852EDE0", Offset = "0x852D7E0", VA = "0x18852EDE0")]
	public LHOMDKGMMEN GBENOHALCJN(CKPEEOMOJJI LALBBHEFJAE, [In] GCMIBKGIHPB HPGIDELCODH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000229")]
	[Cpp2IlInjected.Address(RVA = "0x852F4F0", Offset = "0x852DEF0", VA = "0x18852F4F0")]
	public NPMBGKJGIHC PDDAEILCPHI(CKPEEOMOJJI LALBBHEFJAE, [In] GCMIBKGIHPB HPGIDELCODH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600022A")]
	[Cpp2IlInjected.Address(RVA = "0x852F110", Offset = "0x852DB10", VA = "0x18852F110")]
	public OFKNFCFBFKJ KBKOCNCODNC(CKPEEOMOJJI LALBBHEFJAE, [In] GCMIBKGIHPB HPGIDELCODH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600022B")]
	[Cpp2IlInjected.Address(RVA = "0x852ED30", Offset = "0x852D730", VA = "0x18852ED30")]
	public MHLJOKBMHID NGHIHLDAAJO(CKPEEOMOJJI LALBBHEFJAE, [In] GCMIBKGIHPB HPGIDELCODH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600022C")]
	[Cpp2IlInjected.Address(RVA = "0x852EB00", Offset = "0x852D500", VA = "0x18852EB00")]
	public ADEFFAGNNKF FJKKKLJHINL(CKPEEOMOJJI LALBBHEFJAE, [In] GCMIBKGIHPB HPGIDELCODH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600022D")]
	[Cpp2IlInjected.Address(RVA = "0x852EBB0", Offset = "0x852D5B0", VA = "0x18852EBB0", Slot = "19")]
	public CKPEEOMOJJI CBOPHCMCJJL(RigidbodyEx OGMEFONHICP, GCMIBKGIHPB HPGIDELCODH, LNPBMAIDKPE BPDOIFAEGPF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600022E")]
	[Cpp2IlInjected.Address(RVA = "0x852F640", Offset = "0x852E040", VA = "0x18852F640")]
	public MCPINKIBIJC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600022F")]
	[Cpp2IlInjected.Address(RVA = "0x852EDE0", Offset = "0x852D7E0", VA = "0x18852EDE0", Slot = "14")]
	private LHOMDKGMMEN LKIGDMPEJPG(CKPEEOMOJJI LALBBHEFJAE, [In] GCMIBKGIHPB HPGIDELCODH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000230")]
	[Cpp2IlInjected.Address(RVA = "0x852F4F0", Offset = "0x852DEF0", VA = "0x18852F4F0", Slot = "15")]
	private NPMBGKJGIHC OBMEPMPLAOC(CKPEEOMOJJI LALBBHEFJAE, [In] GCMIBKGIHPB HPGIDELCODH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000231")]
	[Cpp2IlInjected.Address(RVA = "0x852F110", Offset = "0x852DB10", VA = "0x18852F110", Slot = "16")]
	private OFKNFCFBFKJ HIMCAFBFIAF(CKPEEOMOJJI LALBBHEFJAE, [In] GCMIBKGIHPB HPGIDELCODH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000232")]
	[Cpp2IlInjected.Address(RVA = "0x852ED30", Offset = "0x852D730", VA = "0x18852ED30", Slot = "17")]
	private MHLJOKBMHID FFODJCFFGIP(CKPEEOMOJJI LALBBHEFJAE, [In] GCMIBKGIHPB HPGIDELCODH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000233")]
	[Cpp2IlInjected.Address(RVA = "0x852EB00", Offset = "0x852D500", VA = "0x18852EB00", Slot = "18")]
	private ADEFFAGNNKF BNJCCFFGLGE(CKPEEOMOJJI LALBBHEFJAE, [In] GCMIBKGIHPB HPGIDELCODH)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000020")]
public interface BMAMBPBDICL : AIDCNLBLAJA, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x6000234")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void HLEAELBHIOH(CKPEEOMOJJI OGMEFONHICP);

	[Cpp2IlInjected.Token(Token = "0x6000235")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void ECOBBKCDHHK(CKPEEOMOJJI OGMEFONHICP);

	[Cpp2IlInjected.Token(Token = "0x6000236")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void KGOCEALHIEE(CKPEEOMOJJI PCAJKGLMDAK);

	[Cpp2IlInjected.Token(Token = "0x6000237")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void CJNFPMJHFMP(CKPEEOMOJJI PCAJKGLMDAK);
}
[Cpp2IlInjected.Token(Token = "0x2000021")]
public interface EOHDNGBNDGH : IONNNKEBPAB
{
	[Cpp2IlInjected.Token(Token = "0x1700008C")]
	NIGIGJLAPAC<CKPEEOMOJJI> IADLIDPMDBG
	{
		[Cpp2IlInjected.Token(Token = "0x6000238")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700008D")]
	CKPEEOMOJJI IPKPOINPLMK
	{
		[Cpp2IlInjected.Token(Token = "0x6000239")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000022")]
public interface AGCINLJHKEN : MHLJOKBMHID
{
	[Cpp2IlInjected.Token(Token = "0x600023A")]
	[Cpp2IlInjected.Address(Slot = "0")]
	(float, Vector3) KPDMLPOGHBP(Rigidbody EOFONOLIHEC);
}
[Cpp2IlInjected.Token(Token = "0x2000023")]
public interface OOPIFDOHNHF : NPMBGKJGIHC, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x1700008E")]
	RRNetworkView JKJLCAOHGLG
	{
		[Cpp2IlInjected.Token(Token = "0x600023B")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000024")]
internal sealed class OJECBGEHIPM : BEEDAICOJJB
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000033")]
	private readonly NOOCONMHGMF OGMEFONHICP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000034")]
	private CollisionDetectionMode HDHHAEAPENK;

	[Cpp2IlInjected.Token(Token = "0x1700008F")]
	private Rigidbody NJDIIBKCONL
	{
		[Cpp2IlInjected.Token(Token = "0x600023C")]
		[Cpp2IlInjected.Address(RVA = "0x852D170", Offset = "0x852BB70", VA = "0x18852D170")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000090")]
	public CollisionDetectionMode OPPKJLMOMMG
	{
		[Cpp2IlInjected.Token(Token = "0x6000240")]
		[Cpp2IlInjected.Address(RVA = "0x8537B10", Offset = "0x8536510", VA = "0x188537B10", Slot = "4")]
		get
		{
			return default(CollisionDetectionMode);
		}
		[Cpp2IlInjected.Token(Token = "0x6000241")]
		[Cpp2IlInjected.Address(RVA = "0x8537EA0", Offset = "0x85368A0", VA = "0x188537EA0", Slot = "5")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600023D")]
	[Cpp2IlInjected.Address(RVA = "0x852D320", Offset = "0x852BD20", VA = "0x18852D320")]
	public OJECBGEHIPM(CKPEEOMOJJI OGMEFONHICP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600023E")]
	[Cpp2IlInjected.Address(RVA = "0x8537C20", Offset = "0x8536620", VA = "0x188537C20", Slot = "6")]
	public void FHOCOEECEGJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600023F")]
	[Cpp2IlInjected.Address(RVA = "0x8537F10", Offset = "0x8536910", VA = "0x188537F10", Slot = "9")]
	public void MDKOPLPDGML(Rigidbody DBPDLPLAFJF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000242")]
	[Cpp2IlInjected.Address(RVA = "0x8537E90", Offset = "0x8536890", VA = "0x188537E90", Slot = "7")]
	public void HPHKCIMBDDM(bool ILENMKPFHIE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000243")]
	[Cpp2IlInjected.Address(RVA = "0x8537F90", Offset = "0x8536990", VA = "0x188537F90", Slot = "8")]
	public void NMDKEKDLENL(bool ILENMKPFHIE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000244")]
	[Cpp2IlInjected.Address(RVA = "0x8537D30", Offset = "0x8536730", VA = "0x188537D30", Slot = "10")]
	public bool HEOJEJIIFPB(Vector3 HPCBBMBEKNN, [Out] RaycastHit KGJLOFPICLA, float LCMAOMAPNJJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000245")]
	[Cpp2IlInjected.Address(RVA = "0x8537FA0", Offset = "0x85369A0", VA = "0x188537FA0")]
	private void OKBFNKHICCI(bool ILENMKPFHIE)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000025")]
public sealed class CCHMONFJOAB : PDOINCHLDKK, IDisposable, LLOHDJMHBHM
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000036")]
	private readonly NOOCONMHGMF OGMEFONHICP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000037")]
	private BJFKEGNANDB KCKINPBICNK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000038")]
	private GCANPHFAGBD NNJCLJCFILJ;

	[Cpp2IlInjected.Token(Token = "0x17000091")]
	public BJFKEGNANDB DNEPNLLILDF
	{
		[Cpp2IlInjected.Token(Token = "0x6000248")]
		[Cpp2IlInjected.Address(RVA = "0x8529BD0", Offset = "0x85285D0", VA = "0x188529BD0", Slot = "6")]
		get
		{
			return default(BJFKEGNANDB);
		}
		[Cpp2IlInjected.Token(Token = "0x6000249")]
		[Cpp2IlInjected.Address(RVA = "0x8529730", Offset = "0x8528130", VA = "0x188529730", Slot = "7")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000092")]
	private Transform JNGGEKGBBOP
	{
		[Cpp2IlInjected.Token(Token = "0x600024A")]
		[Cpp2IlInjected.Address(RVA = "0xD6A850", Offset = "0xD69250", VA = "0x180D6A850", Slot = "10")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000020")]
	public event Action<AMDCJLIPDMO, AMDCJLIPDMO> OOAPNHDFBKM
	{
		[Cpp2IlInjected.Token(Token = "0x6000246")]
		[Cpp2IlInjected.Address(RVA = "0x8529B20", Offset = "0x8528520", VA = "0x188529B20", Slot = "4")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000247")]
		[Cpp2IlInjected.Address(RVA = "0x8529A70", Offset = "0x8528470", VA = "0x188529A70", Slot = "5")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600024B")]
	[Cpp2IlInjected.Address(RVA = "0x8529D20", Offset = "0x8528720", VA = "0x188529D20")]
	public CCHMONFJOAB(CKPEEOMOJJI OGMEFONHICP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600024C")]
	[Cpp2IlInjected.Address(RVA = "0x8529800", Offset = "0x8528200", VA = "0x188529800", Slot = "8")]
	public void FHOCOEECEGJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600024D")]
	[Cpp2IlInjected.Address(RVA = "0x85296E0", Offset = "0x85280E0", VA = "0x1885296E0", Slot = "9")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600024E")]
	[Cpp2IlInjected.Address(RVA = "0x123AA00", Offset = "0x1239400", VA = "0x18123AA00", Slot = "11")]
	private void LMMLBBILKAE(AMDCJLIPDMO LKNJCDIIPPG, AMDCJLIPDMO IIGJNJIHOEN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600024F")]
	[Cpp2IlInjected.Address(RVA = "0xA0C4B0", Offset = "0xA0AEB0", VA = "0x180A0C4B0", Slot = "12")]
	private void OEEMLBBLJON(bool NKJLCDEGCON)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000026")]
public class ADJAHCOANBO : CNOPFBJJJEJ
{
	[Cpp2IlInjected.Token(Token = "0x6000250")]
	[Cpp2IlInjected.Address(RVA = "0x85253D0", Offset = "0x8523DD0", VA = "0x1885253D0", Slot = "4")]
	public AIDCNLBLAJA IMNMGFCGAPC(CKPEEOMOJJI LALBBHEFJAE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000251")]
	[Cpp2IlInjected.Address(RVA = "0x8525580", Offset = "0x8523F80", VA = "0x188525580", Slot = "5")]
	public EMIIHOMMAAN LCNHJGJENBG(CKPEEOMOJJI LALBBHEFJAE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000252")]
	[Cpp2IlInjected.Address(RVA = "0x8524F10", Offset = "0x8523910", VA = "0x188524F10", Slot = "6")]
	public IONNNKEBPAB GFMHGKCGLOI(CKPEEOMOJJI LALBBHEFJAE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000253")]
	[Cpp2IlInjected.Address(RVA = "0x85256B0", Offset = "0x85240B0", VA = "0x1885256B0", Slot = "7")]
	public EKJGDKIAJDP LHKDDABHFFI(CKPEEOMOJJI LALBBHEFJAE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000254")]
	[Cpp2IlInjected.Address(RVA = "0x85251D0", Offset = "0x8523BD0", VA = "0x1885251D0", Slot = "8")]
	public JFNPBCAFDLA HDJKOOOAGEP(CKPEEOMOJJI LALBBHEFJAE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000255")]
	[Cpp2IlInjected.Address(RVA = "0x8525100", Offset = "0x8523B00", VA = "0x188525100", Slot = "9")]
	public PDOINCHLDKK HBJBEBIOMNP(CKPEEOMOJJI LALBBHEFJAE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000256")]
	[Cpp2IlInjected.Address(RVA = "0x85258C0", Offset = "0x85242C0", VA = "0x1885258C0", Slot = "10")]
	public MALJIKLIKOO ODNKMGMGKCH(CKPEEOMOJJI LALBBHEFJAE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000257")]
	[Cpp2IlInjected.Address(RVA = "0x8525040", Offset = "0x8523A40", VA = "0x188525040", Slot = "11")]
	public INIODDOAIFA GINPPBAKNDH(CKPEEOMOJJI LALBBHEFJAE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000258")]
	[Cpp2IlInjected.Address(RVA = "0x85254C0", Offset = "0x8523EC0", VA = "0x1885254C0", Slot = "12")]
	public BEEDAICOJJB KMCDPKBHKPN(CKPEEOMOJJI LALBBHEFJAE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000259")]
	[Cpp2IlInjected.Address(RVA = "0x8524B80", Offset = "0x8523580", VA = "0x188524B80", Slot = "13")]
	public FBLOLAIMBFH EGHJMOJHENN(CKPEEOMOJJI LALBBHEFJAE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600025A")]
	[Cpp2IlInjected.Address(RVA = "0x8524DD0", Offset = "0x85237D0", VA = "0x188524DD0")]
	public LHOMDKGMMEN GBENOHALCJN(CKPEEOMOJJI LALBBHEFJAE, [In] GCMIBKGIHPB HPGIDELCODH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600025B")]
	[Cpp2IlInjected.Address(RVA = "0x8525730", Offset = "0x8524130", VA = "0x188525730")]
	public NPMBGKJGIHC PDDAEILCPHI(CKPEEOMOJJI LALBBHEFJAE, [In] GCMIBKGIHPB HPGIDELCODH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600025C")]
	[Cpp2IlInjected.Address(RVA = "0x85252A0", Offset = "0x8523CA0", VA = "0x1885252A0")]
	public OFKNFCFBFKJ KBKOCNCODNC(CKPEEOMOJJI LALBBHEFJAE, [In] GCMIBKGIHPB HPGIDELCODH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600025D")]
	[Cpp2IlInjected.Address(RVA = "0x8524C40", Offset = "0x8523640", VA = "0x188524C40")]
	public MHLJOKBMHID NGHIHLDAAJO(CKPEEOMOJJI LALBBHEFJAE, [In] GCMIBKGIHPB HPGIDELCODH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600025E")]
	[Cpp2IlInjected.Address(RVA = "0x8524950", Offset = "0x8523350", VA = "0x188524950")]
	public ADEFFAGNNKF FJKKKLJHINL(CKPEEOMOJJI LALBBHEFJAE, [In] GCMIBKGIHPB HPGIDELCODH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600025F")]
	[Cpp2IlInjected.Address(RVA = "0x8524A30", Offset = "0x8523430", VA = "0x188524A30", Slot = "19")]
	public CKPEEOMOJJI CBOPHCMCJJL(RigidbodyEx OGMEFONHICP, GCMIBKGIHPB HPGIDELCODH, LNPBMAIDKPE BPDOIFAEGPF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000260")]
	[Cpp2IlInjected.Address(RVA = "0xA104F0", Offset = "0xA0EEF0", VA = "0x180A104F0")]
	public ADJAHCOANBO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000261")]
	[Cpp2IlInjected.Address(RVA = "0x8524DD0", Offset = "0x85237D0", VA = "0x188524DD0", Slot = "14")]
	private LHOMDKGMMEN LKIGDMPEJPG(CKPEEOMOJJI LALBBHEFJAE, [In] GCMIBKGIHPB HPGIDELCODH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000262")]
	[Cpp2IlInjected.Address(RVA = "0x8525730", Offset = "0x8524130", VA = "0x188525730", Slot = "15")]
	private NPMBGKJGIHC OBMEPMPLAOC(CKPEEOMOJJI LALBBHEFJAE, [In] GCMIBKGIHPB HPGIDELCODH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000263")]
	[Cpp2IlInjected.Address(RVA = "0x85252A0", Offset = "0x8523CA0", VA = "0x1885252A0", Slot = "16")]
	private OFKNFCFBFKJ HIMCAFBFIAF(CKPEEOMOJJI LALBBHEFJAE, [In] GCMIBKGIHPB HPGIDELCODH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000264")]
	[Cpp2IlInjected.Address(RVA = "0x8524C40", Offset = "0x8523640", VA = "0x188524C40", Slot = "17")]
	private MHLJOKBMHID FFODJCFFGIP(CKPEEOMOJJI LALBBHEFJAE, [In] GCMIBKGIHPB HPGIDELCODH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000265")]
	[Cpp2IlInjected.Address(RVA = "0x8524950", Offset = "0x8523350", VA = "0x188524950", Slot = "18")]
	private ADEFFAGNNKF BNJCCFFGLGE(CKPEEOMOJJI LALBBHEFJAE, [In] GCMIBKGIHPB HPGIDELCODH)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000027")]
internal sealed class GMMGEEBKKJK : INIODDOAIFA
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000039")]
	private readonly NOOCONMHGMF OGMEFONHICP;

	[Cpp2IlInjected.Token(Token = "0x17000093")]
	private Rigidbody NJDIIBKCONL
	{
		[Cpp2IlInjected.Token(Token = "0x6000266")]
		[Cpp2IlInjected.Address(RVA = "0x852D170", Offset = "0x852BB70", VA = "0x18852D170")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000094")]
	private bool OOFIBNOFLPB
	{
		[Cpp2IlInjected.Token(Token = "0x6000267")]
		[Cpp2IlInjected.Address(RVA = "0x852D0C0", Offset = "0x852BAC0", VA = "0x18852D0C0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000095")]
	private bool FPFHCIFNHJK
	{
		[Cpp2IlInjected.Token(Token = "0x6000268")]
		[Cpp2IlInjected.Address(RVA = "0x852D060", Offset = "0x852BA60", VA = "0x18852D060")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000096")]
	private CKPEEOMOJJI IOJNNDJMALL
	{
		[Cpp2IlInjected.Token(Token = "0x6000269")]
		[Cpp2IlInjected.Address(RVA = "0x852D110", Offset = "0x852BB10", VA = "0x18852D110")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600026A")]
	[Cpp2IlInjected.Address(RVA = "0x852D320", Offset = "0x852BD20", VA = "0x18852D320")]
	public GMMGEEBKKJK(CKPEEOMOJJI OGMEFONHICP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600026B")]
	[Cpp2IlInjected.Address(RVA = "0x852CF00", Offset = "0x852B900", VA = "0x18852CF00", Slot = "4")]
	public void GNDHMCFEFFI(Vector3 BOOINJJDCOC, ForceMode OBFDKNANAGO = ForceMode.Force)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600026C")]
	[Cpp2IlInjected.Address(RVA = "0x852CA40", Offset = "0x852B440", VA = "0x18852CA40")]
	private void FNIPHKANCGN(Vector3 BOOINJJDCOC, ForceMode OBFDKNANAGO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600026D")]
	[Cpp2IlInjected.Address(RVA = "0x852C7C0", Offset = "0x852B1C0", VA = "0x18852C7C0", Slot = "5")]
	public void FFLEEFDDKDM(Vector3 BOOINJJDCOC, Vector3 JFMEMBGKAOB, ForceMode OBFDKNANAGO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600026E")]
	[Cpp2IlInjected.Address(RVA = "0x852D1C0", Offset = "0x852BBC0", VA = "0x18852D1C0", Slot = "6")]
	public void PEDLDKMBEOD(Vector3 CMHJLKLDGIM, ForceMode OBFDKNANAGO = ForceMode.Force)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600026F")]
	[Cpp2IlInjected.Address(RVA = "0x852C560", Offset = "0x852AF60", VA = "0x18852C560")]
	private void ABPHABOFLOJ(Vector3 CMHJLKLDGIM, ForceMode OBFDKNANAGO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000270")]
	[Cpp2IlInjected.Address(RVA = "0x852CCA0", Offset = "0x852B6A0", VA = "0x18852CCA0", Slot = "7")]
	public void GCJDDPBLICH(Vector3 CMHJLKLDGIM, ForceMode OBFDKNANAGO = ForceMode.Force)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000028")]
internal sealed class NLNLMONBJCA : FBLOLAIMBFH
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400003A")]
	private readonly NOOCONMHGMF OGMEFONHICP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400003B")]
	private bool OMNBALCEKDE;

	[Cpp2IlInjected.Token(Token = "0x17000097")]
	public bool GCOGCFPFCML
	{
		[Cpp2IlInjected.Token(Token = "0x6000272")]
		[Cpp2IlInjected.Address(RVA = "0xA62AE0", Offset = "0xA614E0", VA = "0x180A62AE0", Slot = "4")]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000273")]
		[Cpp2IlInjected.Address(RVA = "0x85311C0", Offset = "0x852FBC0", VA = "0x1885311C0", Slot = "5")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000271")]
	[Cpp2IlInjected.Address(RVA = "0x852D320", Offset = "0x852BD20", VA = "0x18852D320")]
	public NLNLMONBJCA(CKPEEOMOJJI OGMEFONHICP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000274")]
	[Cpp2IlInjected.Address(RVA = "0x85312D0", Offset = "0x852FCD0", VA = "0x1885312D0", Slot = "6")]
	public void MDKOPLPDGML(Rigidbody DBPDLPLAFJF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000275")]
	[Cpp2IlInjected.Address(RVA = "0x8531300", Offset = "0x852FD00", VA = "0x188531300", Slot = "7")]
	public void NOHPCMHGJNH(Rigidbody DBPDLPLAFJF)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000029")]
internal sealed class GFOPFLMGINB : BMAMBPBDICL, AIDCNLBLAJA, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x4000045")]
	private readonly CKPEEOMOJJI OGMEFONHICP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x4000046")]
	private readonly List<CKPEEOMOJJI> KJGEKOMNNIF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x4000047")]
	private CKPEEOMOJJI ALPBGLGCPNB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x4000048")]
	private CKPEEOMOJJI EAGGHBKHKHF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
	[Cpp2IlInjected.Token(Token = "0x4000049")]
	private Transform LKHOOLLOINI;

	[Cpp2IlInjected.Token(Token = "0x17000098")]
	private Transform OIBPIKEGOHJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000288")]
		[Cpp2IlInjected.Address(RVA = "0x852B200", Offset = "0x8529C00", VA = "0x18852B200")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000099")]
	public CKPEEOMOJJI IOJNNDJMALL
	{
		[Cpp2IlInjected.Token(Token = "0x600028B")]
		[Cpp2IlInjected.Address(RVA = "0xA17C00", Offset = "0xA16600", VA = "0x180A17C00", Slot = "28")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600028C")]
		[Cpp2IlInjected.Address(RVA = "0x852AF20", Offset = "0x8529920", VA = "0x18852AF20", Slot = "29")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700009A")]
	public CKPEEOMOJJI PFOPMMBCMFB
	{
		[Cpp2IlInjected.Token(Token = "0x600028D")]
		[Cpp2IlInjected.Address(RVA = "0xA10530", Offset = "0xA0EF30", VA = "0x180A10530", Slot = "27")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700009B")]
	public IReadOnlyList<CKPEEOMOJJI> OBNKPPHMPJE
	{
		[Cpp2IlInjected.Token(Token = "0x600028E")]
		[Cpp2IlInjected.Address(RVA = "0xA10520", Offset = "0xA0EF20", VA = "0x180A10520", Slot = "26")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000021")]
	public event KANEOGHNJFB HEDEIKCGPFF
	{
		[Cpp2IlInjected.Token(Token = "0x6000276")]
		[Cpp2IlInjected.Address(RVA = "0x852B160", Offset = "0x8529B60", VA = "0x18852B160", Slot = "8")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000277")]
		[Cpp2IlInjected.Address(RVA = "0x852B9E0", Offset = "0x852A3E0", VA = "0x18852B9E0", Slot = "9")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000022")]
	public event KANEOGHNJFB OFIKEGHAAJA
	{
		[Cpp2IlInjected.Token(Token = "0x6000278")]
		[Cpp2IlInjected.Address(RVA = "0x852B260", Offset = "0x8529C60", VA = "0x18852B260", Slot = "10")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000279")]
		[Cpp2IlInjected.Address(RVA = "0x852B0C0", Offset = "0x8529AC0", VA = "0x18852B0C0", Slot = "11")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000023")]
	public event FMMFANILCNM HJNHKBJIAMO
	{
		[Cpp2IlInjected.Token(Token = "0x600027A")]
		[Cpp2IlInjected.Address(RVA = "0x852AA10", Offset = "0x8529410", VA = "0x18852AA10", Slot = "12")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600027B")]
		[Cpp2IlInjected.Address(RVA = "0x852B3A0", Offset = "0x8529DA0", VA = "0x18852B3A0", Slot = "13")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000024")]
	public event Action MFLPCIMFLGN
	{
		[Cpp2IlInjected.Token(Token = "0x600027C")]
		[Cpp2IlInjected.Address(RVA = "0x852B6B0", Offset = "0x852A0B0", VA = "0x18852B6B0", Slot = "14")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600027D")]
		[Cpp2IlInjected.Address(RVA = "0x852ABF0", Offset = "0x85295F0", VA = "0x18852ABF0", Slot = "15")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000025")]
	public event Action BLJGAOLGKFL
	{
		[Cpp2IlInjected.Token(Token = "0x600027E")]
		[Cpp2IlInjected.Address(RVA = "0x852B940", Offset = "0x852A340", VA = "0x18852B940", Slot = "16")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600027F")]
		[Cpp2IlInjected.Address(RVA = "0x852A970", Offset = "0x8529370", VA = "0x18852A970", Slot = "17")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000026")]
	public event Action<CKPEEOMOJJI> AOOJMBPBOMN
	{
		[Cpp2IlInjected.Token(Token = "0x6000280")]
		[Cpp2IlInjected.Address(RVA = "0x852B750", Offset = "0x852A150", VA = "0x18852B750", Slot = "18")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000281")]
		[Cpp2IlInjected.Address(RVA = "0x852AE70", Offset = "0x8529870", VA = "0x18852AE70", Slot = "19")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000027")]
	public event Action<CKPEEOMOJJI> NCAEPMGOKIA
	{
		[Cpp2IlInjected.Token(Token = "0x6000282")]
		[Cpp2IlInjected.Address(RVA = "0x852C2A0", Offset = "0x852ACA0", VA = "0x18852C2A0", Slot = "20")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000283")]
		[Cpp2IlInjected.Address(RVA = "0x852BA80", Offset = "0x852A480", VA = "0x18852BA80", Slot = "21")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000028")]
	public event Action LJBLPCKPAJL
	{
		[Cpp2IlInjected.Token(Token = "0x6000284")]
		[Cpp2IlInjected.Address(RVA = "0x852B300", Offset = "0x8529D00", VA = "0x18852B300", Slot = "22")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000285")]
		[Cpp2IlInjected.Address(RVA = "0x852B020", Offset = "0x8529A20", VA = "0x18852B020", Slot = "23")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000029")]
	public event Action<CKPEEOMOJJI> PPEJFADBEGE
	{
		[Cpp2IlInjected.Token(Token = "0x6000286")]
		[Cpp2IlInjected.Address(RVA = "0x852C350", Offset = "0x852AD50", VA = "0x18852C350", Slot = "24")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000287")]
		[Cpp2IlInjected.Address(RVA = "0x852AC90", Offset = "0x8529690", VA = "0x18852AC90", Slot = "25")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000289")]
	[Cpp2IlInjected.Address(RVA = "0x852C4A0", Offset = "0x852AEA0", VA = "0x18852C4A0")]
	public GFOPFLMGINB(CKPEEOMOJJI OGMEFONHICP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600028A")]
	[Cpp2IlInjected.Address(RVA = "0x852AAB0", Offset = "0x85294B0", VA = "0x18852AAB0", Slot = "31")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600028F")]
	[Cpp2IlInjected.Address(RVA = "0x852BD20", Offset = "0x852A720", VA = "0x18852BD20", Slot = "30")]
	public void ODCKPPKNECL(CKPEEOMOJJI FEIPCFECKLD, bool MPNHLGBIEGE = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000290")]
	[Cpp2IlInjected.Address(RVA = "0x852B440", Offset = "0x8529E40", VA = "0x18852B440", Slot = "6")]
	public void KGOCEALHIEE(CKPEEOMOJJI PCAJKGLMDAK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000291")]
	[Cpp2IlInjected.Address(RVA = "0x852A6F0", Offset = "0x85290F0", VA = "0x18852A6F0", Slot = "7")]
	public void CJNFPMJHFMP(CKPEEOMOJJI PCAJKGLMDAK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000292")]
	[Cpp2IlInjected.Address(RVA = "0x852AF30", Offset = "0x8529930", VA = "0x18852AF30", Slot = "4")]
	public void HLEAELBHIOH(CKPEEOMOJJI OGMEFONHICP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000293")]
	[Cpp2IlInjected.Address(RVA = "0x852AB50", Offset = "0x8529550", VA = "0x18852AB50", Slot = "5")]
	public void ECOBBKCDHHK(CKPEEOMOJJI OGMEFONHICP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000294")]
	[Cpp2IlInjected.Address(RVA = "0x852C400", Offset = "0x852AE00", VA = "0x18852C400")]
	private void PFHEDFBHNGC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000295")]
	[Cpp2IlInjected.Address(RVA = "0x852A6B0", Offset = "0x85290B0", VA = "0x18852A6B0")]
	private void BGAPNNNLHDI(CKPEEOMOJJI PCAJKGLMDAK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000296")]
	[Cpp2IlInjected.Address(RVA = "0x852B800", Offset = "0x852A200", VA = "0x18852B800")]
	private void MEALCIPDPGM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000297")]
	[Cpp2IlInjected.Address(RVA = "0x852BB30", Offset = "0x852A530", VA = "0x18852BB30")]
	private void NGBGKIHEKMB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000298")]
	[Cpp2IlInjected.Address(RVA = "0x852AD40", Offset = "0x8529740", VA = "0x18852AD40")]
	private void FFIKMODBNOC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000299")]
	[Cpp2IlInjected.Address(RVA = "0x852BC60", Offset = "0x852A660", VA = "0x18852BC60")]
	[CompilerGenerated]
	private object NJJNNHEMPFG()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200002A")]
internal static class JKDHNCOGNFA
{
	[Cpp2IlInjected.Token(Token = "0x600029A")]
	[Cpp2IlInjected.Address(RVA = "0x852DF20", Offset = "0x852C920", VA = "0x18852DF20")]
	public static BMAMBPBDICL HJKHAHECDKL(this CKPEEOMOJJI LALBBHEFJAE)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200002B")]
internal sealed class PDFJCLLHOIA : EOHDNGBNDGH, IONNNKEBPAB
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400004A")]
	private readonly NOOCONMHGMF OGMEFONHICP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400004B")]
	private readonly NIGIGJLAPAC<CKPEEOMOJJI> MOJBJEAPCJP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400004C")]
	private bool EKKJNMALKFC;

	[Cpp2IlInjected.Token(Token = "0x1700009C")]
	public NIGIGJLAPAC<CKPEEOMOJJI> IADLIDPMDBG
	{
		[Cpp2IlInjected.Token(Token = "0x600029B")]
		[Cpp2IlInjected.Address(RVA = "0xA0A9D0", Offset = "0xA093D0", VA = "0x180A0A9D0", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700009D")]
	public Vector3 BJMHMKHBLHP
	{
		[Cpp2IlInjected.Token(Token = "0x600029C")]
		[Cpp2IlInjected.Address(RVA = "0x853B2F0", Offset = "0x8539CF0", VA = "0x18853B2F0", Slot = "6")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700009E")]
	public Vector3 CILPBKBJNOD
	{
		[Cpp2IlInjected.Token(Token = "0x600029D")]
		[Cpp2IlInjected.Address(RVA = "0x853B320", Offset = "0x8539D20", VA = "0x18853B320", Slot = "7")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700009F")]
	private Vector3 JPBKJMJLHIP
	{
		[Cpp2IlInjected.Token(Token = "0x60002A1")]
		[Cpp2IlInjected.Address(RVA = "0x853AE10", Offset = "0x8539810", VA = "0x18853AE10")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A0")]
	public CKPEEOMOJJI IPKPOINPLMK
	{
		[Cpp2IlInjected.Token(Token = "0x60002A2")]
		[Cpp2IlInjected.Address(RVA = "0x853A960", Offset = "0x8539360", VA = "0x18853A960", Slot = "5")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600029E")]
	[Cpp2IlInjected.Address(RVA = "0x853B620", Offset = "0x853A020", VA = "0x18853B620")]
	public PDFJCLLHOIA(CKPEEOMOJJI OGMEFONHICP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600029F")]
	[Cpp2IlInjected.Address(RVA = "0x853AA10", Offset = "0x8539410", VA = "0x18853AA10", Slot = "8")]
	public void CFGIELFKPLJ(CKPEEOMOJJI EAGGHBKHKHF, object BECBHDDLOHA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002A0")]
	[Cpp2IlInjected.Address(RVA = "0x853AEF0", Offset = "0x85398F0", VA = "0x18853AEF0", Slot = "9")]
	public void GNNNEHAEDEF(object BECBHDDLOHA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002A3")]
	[Cpp2IlInjected.Address(RVA = "0x853AF50", Offset = "0x8539950", VA = "0x18853AF50")]
	private Vector3 KGIDOBLPJFO()
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x60002A4")]
	[Cpp2IlInjected.Address(RVA = "0x853AA80", Offset = "0x8539480", VA = "0x18853AA80")]
	private void FAPCDEGIDFG(CKPEEOMOJJI HMHLJONAEHJ)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002C")]
internal static class BCNFMOIEBAC
{
	[Cpp2IlInjected.Token(Token = "0x60002A5")]
	[Cpp2IlInjected.Address(RVA = "0x85259E0", Offset = "0x85243E0", VA = "0x1885259E0")]
	public static EOHDNGBNDGH MEKCKHBOLMC(this CKPEEOMOJJI LALBBHEFJAE)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200002D")]
internal sealed class OOCMMOMFFKG : AGCINLJHKEN, MHLJOKBMHID
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400004E")]
	private readonly NOOCONMHGMF OGMEFONHICP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400004F")]
	private readonly OverridableVector3 BCOJONMDENG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000050")]
	private readonly OverridableVector3 JFDJDOPNINB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000051")]
	private float GEINHDPPGIL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x44")]
	[Cpp2IlInjected.Token(Token = "0x4000052")]
	private float BNIEPIJDCPA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000053")]
	private Vector3 DOOLDDCAJJJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x54")]
	[Cpp2IlInjected.Token(Token = "0x4000054")]
	private Vector3? OPOGJDDMJEI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x64")]
	[Cpp2IlInjected.Token(Token = "0x4000055")]
	private Quaternion? AOLHEEIHCFK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
	[Cpp2IlInjected.Token(Token = "0x4000056")]
	private bool PJOEPLFBBAA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x79")]
	[Cpp2IlInjected.Token(Token = "0x4000057")]
	private bool CIPBMMDPOJA;

	[Cpp2IlInjected.Token(Token = "0x170000A1")]
	public Vector3 CBMDODIHBDD
	{
		[Cpp2IlInjected.Token(Token = "0x60002A8")]
		[Cpp2IlInjected.Address(RVA = "0x1765920", Offset = "0x1764320", VA = "0x181765920", Slot = "7")]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x60002A9")]
		[Cpp2IlInjected.Address(RVA = "0x85382C0", Offset = "0x8536CC0", VA = "0x1885382C0", Slot = "8")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A2")]
	public Vector3 GNEAMFDMGFL
	{
		[Cpp2IlInjected.Token(Token = "0x60002AA")]
		[Cpp2IlInjected.Address(RVA = "0x8538410", Offset = "0x8536E10", VA = "0x188538410", Slot = "9")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A3")]
	public float ABAPMFBJMKO
	{
		[Cpp2IlInjected.Token(Token = "0x60002AB")]
		[Cpp2IlInjected.Address(RVA = "0xD8F5F0", Offset = "0xD8DFF0", VA = "0x180D8F5F0", Slot = "10")]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x60002AC")]
		[Cpp2IlInjected.Address(RVA = "0x85380C0", Offset = "0x8536AC0", VA = "0x1885380C0")]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A4")]
	public float LMMEKHANDPM
	{
		[Cpp2IlInjected.Token(Token = "0x60002AD")]
		[Cpp2IlInjected.Address(RVA = "0xC98720", Offset = "0xC97120", VA = "0x180C98720", Slot = "11")]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x60002AE")]
		[Cpp2IlInjected.Address(RVA = "0x8538620", Offset = "0x8537020", VA = "0x188538620", Slot = "12")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A5")]
	public Vector3 MMDHKNKKPNC
	{
		[Cpp2IlInjected.Token(Token = "0x60002AF")]
		[Cpp2IlInjected.Address(RVA = "0x8539FF0", Offset = "0x85389F0", VA = "0x188539FF0", Slot = "13")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A6")]
	public Quaternion HECHIIJBGHD
	{
		[Cpp2IlInjected.Token(Token = "0x60002B0")]
		[Cpp2IlInjected.Address(RVA = "0x853A680", Offset = "0x8539080", VA = "0x18853A680", Slot = "14")]
		get
		{
			return default(Quaternion);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A7")]
	private Rigidbody NJDIIBKCONL
	{
		[Cpp2IlInjected.Token(Token = "0x60002B8")]
		[Cpp2IlInjected.Address(RVA = "0x8530C00", Offset = "0x852F600", VA = "0x188530C00")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400002A")]
	public event KANEOGHNJFB BMDHGDMBLPC
	{
		[Cpp2IlInjected.Token(Token = "0x60002A6")]
		[Cpp2IlInjected.Address(RVA = "0x8538370", Offset = "0x8536D70", VA = "0x188538370", Slot = "5")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60002A7")]
		[Cpp2IlInjected.Address(RVA = "0x8539D90", Offset = "0x8538790", VA = "0x188539D90", Slot = "6")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60002B1")]
	[Cpp2IlInjected.Address(RVA = "0x853A800", Offset = "0x8539200", VA = "0x18853A800")]
	public OOCMMOMFFKG(CKPEEOMOJJI OGMEFONHICP, [In] GCMIBKGIHPB HPGIDELCODH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002B2")]
	[Cpp2IlInjected.Address(RVA = "0x8538500", Offset = "0x8536F00", VA = "0x188538500", Slot = "17")]
	public void ICFMKMGKFPN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002B3")]
	[Cpp2IlInjected.Address(RVA = "0x8539F10", Offset = "0x8538910", VA = "0x188539F10", Slot = "16")]
	public void MINPMAPDKEN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002B4")]
	[Cpp2IlInjected.Address(RVA = "0x8539E30", Offset = "0x8538830", VA = "0x188539E30", Slot = "19")]
	public void MDKOPLPDGML(Rigidbody DBPDLPLAFJF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002B5")]
	[Cpp2IlInjected.Address(RVA = "0x853A180", Offset = "0x8538B80", VA = "0x18853A180", Slot = "20")]
	public void NOHPCMHGJNH(Rigidbody DBPDLPLAFJF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002B6")]
	[Cpp2IlInjected.Address(RVA = "0x853A4E0", Offset = "0x8538EE0", VA = "0x18853A4E0", Slot = "18")]
	public void OEFGFHILMEM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002B7")]
	[Cpp2IlInjected.Address(RVA = "0x8538900", Offset = "0x8537300", VA = "0x188538900", Slot = "21")]
	public void KEAMPKLDOJP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002B9")]
	[Cpp2IlInjected.Address(RVA = "0x85382C0", Offset = "0x8536CC0", VA = "0x1885382C0")]
	private void LLCNKKNDHAB(Vector3 PCDAHJCDHHF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002BA")]
	[Cpp2IlInjected.Address(RVA = "0x85381D0", Offset = "0x8536BD0", VA = "0x1885381D0")]
	[Obsolete("This method is dangerous - the unity rigidbody is updated in a deferred manner and this world position may be stale")]
	private Vector3 BCKKJPOHEFC()
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x60002BB")]
	[Cpp2IlInjected.Address(RVA = "0x85380C0", Offset = "0x8536AC0", VA = "0x1885380C0")]
	private void ALDDBKLHNOB(float PCDAHJCDHHF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002BC")]
	[Cpp2IlInjected.Address(RVA = "0x8538620", Offset = "0x8537020", VA = "0x188538620")]
	private void NIAKDAJMLOI(float PCDAHJCDHHF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002BD")]
	[Cpp2IlInjected.Address(RVA = "0x8539BF0", Offset = "0x85385F0", VA = "0x188539BF0")]
	private Vector3 LMEDFOPKFJE()
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x60002BE")]
	[Cpp2IlInjected.Address(RVA = "0x85386D0", Offset = "0x85370D0", VA = "0x1885386D0", Slot = "15")]
	public void KDFIPNDDFHG((Quaternion rot, Vector3 moments) HMJIJMLCIDN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002BF")]
	[Cpp2IlInjected.Address(RVA = "0x853A360", Offset = "0x8538D60", VA = "0x18853A360")]
	private Quaternion NOJBLAFOEGA()
	{
		return default(Quaternion);
	}

	[Cpp2IlInjected.Token(Token = "0x60002C0")]
	[Cpp2IlInjected.Address(RVA = "0x8538D80", Offset = "0x8537780", VA = "0x188538D80")]
	public void KPDMLPOGHBP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002C1")]
	[Cpp2IlInjected.Address(RVA = "0x8538E50", Offset = "0x8537850", VA = "0x188538E50", Slot = "4")]
	public (float, Vector3) KPDMLPOGHBP(Rigidbody EOFONOLIHEC)
	{
		return default((float, Vector3));
	}
}
[Cpp2IlInjected.Token(Token = "0x200002E")]
internal static class LIFKEBGBPBP
{
	[Cpp2IlInjected.Token(Token = "0x60002C2")]
	[Cpp2IlInjected.Address(RVA = "0x852E930", Offset = "0x852D330", VA = "0x18852E930")]
	public static AGCINLJHKEN MLFMFBGAKDI(this CKPEEOMOJJI LALBBHEFJAE)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200002F")]
internal sealed class HPFCOKNPNLC : OFKNFCFBFKJ
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000058")]
	private readonly NOOCONMHGMF OGMEFONHICP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000059")]
	private readonly MJPGDJKBEEA MAGKMNEJLAK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400005A")]
	private readonly DLKLAKEEKHP GOMCGOABOEM;

	[Cpp2IlInjected.Token(Token = "0x170000A8")]
	public bool CEDJOPFHFAM
	{
		[Cpp2IlInjected.Token(Token = "0x60002C3")]
		[Cpp2IlInjected.Address(RVA = "0x193AF00", Offset = "0x1939900", VA = "0x18193AF00", Slot = "10")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A9")]
	public DLKLAKEEKHP BCKGFBFOIKI
	{
		[Cpp2IlInjected.Token(Token = "0x60002C4")]
		[Cpp2IlInjected.Address(RVA = "0xA58550", Offset = "0xA56F50", VA = "0x180A58550", Slot = "11")]
		get
		{
			return default(DLKLAKEEKHP);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60002C5")]
	[Cpp2IlInjected.Address(RVA = "0x852DC00", Offset = "0x852C600", VA = "0x18852DC00")]
	public HPFCOKNPNLC(CKPEEOMOJJI OGMEFONHICP, [In] GCMIBKGIHPB HPGIDELCODH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002C6")]
	[Cpp2IlInjected.Address(RVA = "0x852D5F0", Offset = "0x852BFF0", VA = "0x18852D5F0", Slot = "4")]
	public void FHOCOEECEGJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002C7")]
	[Cpp2IlInjected.Address(RVA = "0x852DA50", Offset = "0x852C450", VA = "0x18852DA50")]
	private bool LFEJLKFENOG()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002C8")]
	[Cpp2IlInjected.Address(RVA = "0x852D830", Offset = "0x852C230", VA = "0x18852D830", Slot = "5")]
	public void IPMACFHIMHE(object BECBHDDLOHA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002C9")]
	[Cpp2IlInjected.Address(RVA = "0x852D860", Offset = "0x852C260", VA = "0x18852D860", Slot = "6")]
	public void JJNJDAACGGK(object BECBHDDLOHA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002CA")]
	[Cpp2IlInjected.Address(RVA = "0x852D6C0", Offset = "0x852C0C0", VA = "0x18852D6C0", Slot = "9")]
	public void GAAJFDMJFHO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002CB")]
	[Cpp2IlInjected.Address(RVA = "0x852DAF0", Offset = "0x852C4F0", VA = "0x18852DAF0")]
	private void PGJLMNNHAAK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002CC")]
	[Cpp2IlInjected.Address(RVA = "0x852D8D0", Offset = "0x852C2D0", VA = "0x18852D8D0")]
	private void KACJGKLEGCB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002CD")]
	[Cpp2IlInjected.Address(RVA = "0x852D890", Offset = "0x852C290", VA = "0x18852D890", Slot = "8")]
	public void JMPDKJIBKLF(CKPEEOMOJJI OGMEFONHICP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002CE")]
	[Cpp2IlInjected.Address(RVA = "0x852D7F0", Offset = "0x852C1F0", VA = "0x18852D7F0", Slot = "7")]
	public void IHDJDBHJOFC(CKPEEOMOJJI OGMEFONHICP)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000030")]
internal sealed class CDIDCGFAKIH : MALJIKLIKOO
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400005C")]
	private readonly NOOCONMHGMF OGMEFONHICP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400005D")]
	private readonly MJPGDJKBEEA BPDBLBKGMBG;

	[Cpp2IlInjected.Token(Token = "0x170000AA")]
	public bool OOFIBNOFLPB
	{
		[Cpp2IlInjected.Token(Token = "0x60002D1")]
		[Cpp2IlInjected.Address(RVA = "0x8529FB0", Offset = "0x85289B0", VA = "0x188529FB0", Slot = "6")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400002B")]
	public event KANEOGHNJFB NCDNCOALOHG
	{
		[Cpp2IlInjected.Token(Token = "0x60002CF")]
		[Cpp2IlInjected.Address(RVA = "0x8529EC0", Offset = "0x85288C0", VA = "0x188529EC0", Slot = "4")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60002D0")]
		[Cpp2IlInjected.Address(RVA = "0x852A0F0", Offset = "0x8528AF0", VA = "0x18852A0F0", Slot = "5")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60002D2")]
	[Cpp2IlInjected.Address(RVA = "0x852A1C0", Offset = "0x8528BC0", VA = "0x18852A1C0")]
	public CDIDCGFAKIH(CKPEEOMOJJI OGMEFONHICP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002D3")]
	[Cpp2IlInjected.Address(RVA = "0x8529F60", Offset = "0x8528960", VA = "0x188529F60", Slot = "7")]
	public void FPDDDLNGNCI(object BECBHDDLOHA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002D4")]
	[Cpp2IlInjected.Address(RVA = "0x852A060", Offset = "0x8528A60", VA = "0x18852A060", Slot = "8")]
	public void LDDOMOEOJNM(object BECBHDDLOHA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002D5")]
	[Cpp2IlInjected.Address(RVA = "0x8529DB0", Offset = "0x85287B0", VA = "0x188529DB0", Slot = "9")]
	public void DJIMFIKFOJP(object BECBHDDLOHA, bool PLIDCHGGBAD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002D6")]
	[Cpp2IlInjected.Address(RVA = "0x8529F70", Offset = "0x8528970", VA = "0x188529F70", Slot = "12")]
	public void GLNALMOKFBJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002D7")]
	[Cpp2IlInjected.Address(RVA = "0x852A070", Offset = "0x8528A70", VA = "0x18852A070", Slot = "10")]
	public void MDKOPLPDGML(Rigidbody FADODMKCMLG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002D8")]
	[Cpp2IlInjected.Address(RVA = "0x852A190", Offset = "0x8528B90", VA = "0x18852A190", Slot = "11")]
	public void NOHPCMHGJNH(Rigidbody DBPDLPLAFJF)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000031")]
internal sealed class MELBCNLGFNC : OOPIFDOHNHF, NPMBGKJGIHC, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400005F")]
	private readonly NOOCONMHGMF OGMEFONHICP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000060")]
	private RRNetworkView GNNAFAGJBDF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000061")]
	private bool AHOMKAAAIOL;

	[Cpp2IlInjected.Token(Token = "0x170000AB")]
	public RRNetworkView JKJLCAOHGLG
	{
		[Cpp2IlInjected.Token(Token = "0x60002DB")]
		[Cpp2IlInjected.Address(RVA = "0xA0A780", Offset = "0xA09180", VA = "0x180A0A780", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000AC")]
	public bool BEOAIADIFDD
	{
		[Cpp2IlInjected.Token(Token = "0x60002DC")]
		[Cpp2IlInjected.Address(RVA = "0x852F6F0", Offset = "0x852E0F0", VA = "0x18852F6F0", Slot = "7")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000AD")]
	public bool DHDBIEJCKNP
	{
		[Cpp2IlInjected.Token(Token = "0x60002DD")]
		[Cpp2IlInjected.Address(RVA = "0xA6EB70", Offset = "0xA6D570", VA = "0x180A6EB70", Slot = "8")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400002C")]
	public event KANEOGHNJFB AIFDABJDFDJ
	{
		[Cpp2IlInjected.Token(Token = "0x60002D9")]
		[Cpp2IlInjected.Address(RVA = "0x852FF00", Offset = "0x852E900", VA = "0x18852FF00", Slot = "5")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60002DA")]
		[Cpp2IlInjected.Address(RVA = "0x852FAA0", Offset = "0x852E4A0", VA = "0x18852FAA0", Slot = "6")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60002DE")]
	[Cpp2IlInjected.Address(RVA = "0x8530280", Offset = "0x852EC80", VA = "0x188530280")]
	public MELBCNLGFNC(CKPEEOMOJJI OGMEFONHICP, [In] GCMIBKGIHPB HPGIDELCODH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002DF")]
	[Cpp2IlInjected.Address(RVA = "0x852F970", Offset = "0x852E370", VA = "0x18852F970", Slot = "9")]
	public void FHOCOEECEGJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002E0")]
	[Cpp2IlInjected.Address(RVA = "0x852F700", Offset = "0x852E100", VA = "0x18852F700", Slot = "12")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002E1")]
	[Cpp2IlInjected.Address(RVA = "0x852FFA0", Offset = "0x852E9A0", VA = "0x18852FFA0", Slot = "10")]
	public void OKGNDLLEDLC(CKPEEOMOJJI EAGGHBKHKHF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002E2")]
	[Cpp2IlInjected.Address(RVA = "0x852F800", Offset = "0x852E200", VA = "0x18852F800", Slot = "11")]
	public void EAPNLDPEEMK(CKPEEOMOJJI EAGGHBKHKHF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002E3")]
	[Cpp2IlInjected.Address(RVA = "0x8530110", Offset = "0x852EB10", VA = "0x188530110")]
	private void PKGJLLDNCGJ(RRNetworkView CCJDDGCIBEB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002E4")]
	[Cpp2IlInjected.Address(RVA = "0x852FDB0", Offset = "0x852E7B0", VA = "0x18852FDB0")]
	private void MJHEGKJGPLM(LEOFMIOLMNC CHHJELLKIBG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002E5")]
	[Cpp2IlInjected.Address(RVA = "0x852FB40", Offset = "0x852E540", VA = "0x18852FB40")]
	private void MFPEODFPGNI(RRNetworkView IGBHLFMMBBO)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000032")]
internal static class CLCMPMFBOKL
{
	[Cpp2IlInjected.Token(Token = "0x60002E6")]
	[Cpp2IlInjected.Address(RVA = "0x852A2B0", Offset = "0x8528CB0", VA = "0x18852A2B0")]
	public static OOPIFDOHNHF GFAAOAOCFPG(this CKPEEOMOJJI LALBBHEFJAE)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000033")]
internal sealed class HCFFCJLGGPP : ADEFFAGNNKF
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000062")]
	private readonly NOOCONMHGMF OGMEFONHICP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000063")]
	private RigidbodyConstraints NCCGHLDKGBC;

	[Cpp2IlInjected.Token(Token = "0x170000AE")]
	public bool GMGDAJFJIKK
	{
		[Cpp2IlInjected.Token(Token = "0x60002E7")]
		[Cpp2IlInjected.Address(RVA = "0xA99A60", Offset = "0xA98460", VA = "0x180A99A60", Slot = "4")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x60002E8")]
		[Cpp2IlInjected.Address(RVA = "0xDA7C20", Offset = "0xDA6620", VA = "0x180DA7C20", Slot = "5")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000AF")]
	public bool DCIGFHADAKG
	{
		[Cpp2IlInjected.Token(Token = "0x60002E9")]
		[Cpp2IlInjected.Address(RVA = "0xA9A150", Offset = "0xA98B50", VA = "0x180A9A150", Slot = "6")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x60002EA")]
		[Cpp2IlInjected.Address(RVA = "0xDA79F0", Offset = "0xDA63F0", VA = "0x180DA79F0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B0")]
	public RigidbodyConstraints NDAJLCONCBK
	{
		[Cpp2IlInjected.Token(Token = "0x60002EB")]
		[Cpp2IlInjected.Address(RVA = "0xA09240", Offset = "0xA07C40", VA = "0x180A09240", Slot = "7")]
		get
		{
			return default(RigidbodyConstraints);
		}
		[Cpp2IlInjected.Token(Token = "0x60002EC")]
		[Cpp2IlInjected.Address(RVA = "0x852D3B0", Offset = "0x852BDB0", VA = "0x18852D3B0", Slot = "8")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60002ED")]
	[Cpp2IlInjected.Address(RVA = "0x852D540", Offset = "0x852BF40", VA = "0x18852D540")]
	public HCFFCJLGGPP(CKPEEOMOJJI OGMEFONHICP, [In] GCMIBKGIHPB HPGIDELCODH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002EE")]
	[Cpp2IlInjected.Address(RVA = "0x852D4E0", Offset = "0x852BEE0", VA = "0x18852D4E0", Slot = "9")]
	public void MDKOPLPDGML(Rigidbody DBPDLPLAFJF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002EF")]
	[Cpp2IlInjected.Address(RVA = "0x852D510", Offset = "0x852BF10", VA = "0x18852D510", Slot = "10")]
	public void NOHPCMHGJNH(Rigidbody DBPDLPLAFJF)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000034")]
internal sealed class ENMHACKPDGN : EKJGDKIAJDP
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000066")]
	private readonly CKPEEOMOJJI OGMEFONHICP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000067")]
	private float GBIPHNOKDIJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
	[Cpp2IlInjected.Token(Token = "0x4000068")]
	private float FAKMAGJHOJC;

	[Cpp2IlInjected.Token(Token = "0x170000B1")]
	public float DPMLBPCNACO
	{
		[Cpp2IlInjected.Token(Token = "0x60002F1")]
		[Cpp2IlInjected.Address(RVA = "0xA66550", Offset = "0xA64F50", VA = "0x180A66550", Slot = "4")]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x60002F2")]
		[Cpp2IlInjected.Address(RVA = "0x852A3E0", Offset = "0x8528DE0", VA = "0x18852A3E0", Slot = "5")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B2")]
	public float LOFGGINBDGJ
	{
		[Cpp2IlInjected.Token(Token = "0x60002F3")]
		[Cpp2IlInjected.Address(RVA = "0xA66560", Offset = "0xA64F60", VA = "0x180A66560", Slot = "6")]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x60002F4")]
		[Cpp2IlInjected.Address(RVA = "0x852A500", Offset = "0x8528F00", VA = "0x18852A500", Slot = "7")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60002F0")]
	[Cpp2IlInjected.Address(RVA = "0x852A670", Offset = "0x8529070", VA = "0x18852A670")]
	public ENMHACKPDGN(CKPEEOMOJJI OGMEFONHICP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002F5")]
	[Cpp2IlInjected.Address(RVA = "0x852A4B0", Offset = "0x8528EB0", VA = "0x18852A4B0", Slot = "8")]
	public void MDKOPLPDGML(Rigidbody DBPDLPLAFJF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002F6")]
	[Cpp2IlInjected.Address(RVA = "0x852A5D0", Offset = "0x8528FD0", VA = "0x18852A5D0", Slot = "9")]
	public void NOHPCMHGJNH(Rigidbody DBPDLPLAFJF)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000035")]
internal sealed class NBCLKGDNEKD : JFNPBCAFDLA
{
	[Cpp2IlInjected.Token(Token = "0x4000069")]
	private static readonly COJJKFBGGKB NDGJKNNPNCK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400006B")]
	private readonly NOOCONMHGMF OGMEFONHICP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400006C")]
	private bool KDIFPAGFLNM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x21")]
	[Cpp2IlInjected.Token(Token = "0x400006D")]
	private bool DHCODAMCJPA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
	[Cpp2IlInjected.Token(Token = "0x400006E")]
	private int BHAKNOADKEH;

	[Cpp2IlInjected.Token(Token = "0x170000B3")]
	private Rigidbody NJDIIBKCONL
	{
		[Cpp2IlInjected.Token(Token = "0x60002F9")]
		[Cpp2IlInjected.Address(RVA = "0x8530C00", Offset = "0x852F600", VA = "0x188530C00")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B4")]
	private bool LDPCDFPKINP
	{
		[Cpp2IlInjected.Token(Token = "0x60002FA")]
		[Cpp2IlInjected.Address(RVA = "0x8530690", Offset = "0x852F090", VA = "0x188530690")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B5")]
	private CKPEEOMOJJI IOJNNDJMALL
	{
		[Cpp2IlInjected.Token(Token = "0x60002FB")]
		[Cpp2IlInjected.Address(RVA = "0x8530B00", Offset = "0x852F500", VA = "0x188530B00")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B6")]
	private bool FPFHCIFNHJK
	{
		[Cpp2IlInjected.Token(Token = "0x60002FC")]
		[Cpp2IlInjected.Address(RVA = "0x8530590", Offset = "0x852EF90", VA = "0x188530590")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400002D")]
	public event KANEOGHNJFB NHDMNCBOADE
	{
		[Cpp2IlInjected.Token(Token = "0x60002F7")]
		[Cpp2IlInjected.Address(RVA = "0x8530F40", Offset = "0x852F940", VA = "0x188530F40", Slot = "4")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60002F8")]
		[Cpp2IlInjected.Address(RVA = "0x8530B60", Offset = "0x852F560", VA = "0x188530B60", Slot = "5")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60002FD")]
	[Cpp2IlInjected.Address(RVA = "0x8531060", Offset = "0x852FA60", VA = "0x188531060")]
	public NBCLKGDNEKD(CKPEEOMOJJI OGMEFONHICP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002FE")]
	[Cpp2IlInjected.Address(RVA = "0x8530500", Offset = "0x852EF00", VA = "0x188530500", Slot = "6")]
	public void FHOCOEECEGJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002FF")]
	[Cpp2IlInjected.Address(RVA = "0x8530C50", Offset = "0x852F650", VA = "0x188530C50", Slot = "8")]
	public void OHIDMGAGONP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000300")]
	[Cpp2IlInjected.Address(RVA = "0x8530DF0", Offset = "0x852F7F0", VA = "0x188530DF0", Slot = "7")]
	public bool PMHMCBPHCIC()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000301")]
	[Cpp2IlInjected.Address(RVA = "0x8530930", Offset = "0x852F330", VA = "0x188530930", Slot = "9")]
	public void KBIKDALDOIA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000302")]
	[Cpp2IlInjected.Address(RVA = "0x85305F0", Offset = "0x852EFF0", VA = "0x1885305F0", Slot = "13")]
	public void HHPGCIJHADF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000303")]
	[Cpp2IlInjected.Address(RVA = "0x85303E0", Offset = "0x852EDE0", VA = "0x1885303E0", Slot = "12")]
	public void BADDFBDBPGF(bool OMNLACPHJAE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000304")]
	[Cpp2IlInjected.Address(RVA = "0x8530A90", Offset = "0x852F490", VA = "0x188530A90", Slot = "10")]
	public bool LIACIODCJPP()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000305")]
	[Cpp2IlInjected.Address(RVA = "0x85309D0", Offset = "0x852F3D0", VA = "0x1885309D0", Slot = "11")]
	public bool KPNFFEMNEMA()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000306")]
	[Cpp2IlInjected.Address(RVA = "0x85306B0", Offset = "0x852F0B0", VA = "0x1885306B0")]
	private bool JFAJINFCBNL()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000307")]
	[Cpp2IlInjected.Address(RVA = "0x8530C60", Offset = "0x852F660", VA = "0x188530C60")]
	private void OKIILPEOHLE()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000036")]
internal sealed class KJGLDDAJGBH : LHOMDKGMMEN
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400006F")]
	private readonly NOOCONMHGMF OGMEFONHICP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000070")]
	private readonly MJPGDJKBEEA EMELBEEOKPM;

	[Cpp2IlInjected.Token(Token = "0x170000B7")]
	public Rigidbody NJDIIBKCONL
	{
		[Cpp2IlInjected.Token(Token = "0x6000309")]
		[Cpp2IlInjected.Address(RVA = "0xA0A780", Offset = "0xA09180", VA = "0x180A0A780", Slot = "4")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600030A")]
		[Cpp2IlInjected.Address(RVA = "0xA0A570", Offset = "0xA08F70", VA = "0x180A0A570")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B8")]
	private bool FPFHCIFNHJK
	{
		[Cpp2IlInjected.Token(Token = "0x600030B")]
		[Cpp2IlInjected.Address(RVA = "0x852D060", Offset = "0x852BA60", VA = "0x18852D060")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B9")]
	public bool FFDECAEBDIG
	{
		[Cpp2IlInjected.Token(Token = "0x600030E")]
		[Cpp2IlInjected.Address(RVA = "0x193AF00", Offset = "0x1939900", VA = "0x18193AF00", Slot = "6")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600030C")]
	[Cpp2IlInjected.Address(RVA = "0x852E780", Offset = "0x852D180", VA = "0x18852E780")]
	public KJGLDDAJGBH(CKPEEOMOJJI OGMEFONHICP, [In] GCMIBKGIHPB HPGIDELCODH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600030D")]
	[Cpp2IlInjected.Address(RVA = "0x852E010", Offset = "0x852CA10", VA = "0x18852E010", Slot = "5")]
	public void FHOCOEECEGJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600030F")]
	[Cpp2IlInjected.Address(RVA = "0x852E560", Offset = "0x852CF60", VA = "0x18852E560", Slot = "7")]
	public void NGENBHLPLCE(object BECBHDDLOHA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000310")]
	[Cpp2IlInjected.Address(RVA = "0x852DFE0", Offset = "0x852C9E0", VA = "0x18852DFE0", Slot = "8")]
	public void DCFIAPPHDDC(object BECBHDDLOHA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000311")]
	[Cpp2IlInjected.Address(RVA = "0x852E0B0", Offset = "0x852CAB0", VA = "0x18852E0B0", Slot = "9")]
	public void HCHJGPHOLJF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000312")]
	[Cpp2IlInjected.Address(RVA = "0x852E590", Offset = "0x852CF90", VA = "0x18852E590", Slot = "10")]
	public void OOPHMOOGLJD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000313")]
	[Cpp2IlInjected.Address(RVA = "0x852E3E0", Offset = "0x852CDE0", VA = "0x18852E3E0", Slot = "11")]
	public void HNJLPBJGBCH()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000037")]
internal sealed class BKHNHANCMDK : EMIIHOMMAAN, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000072")]
	private readonly NOOCONMHGMF OGMEFONHICP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000073")]
	private readonly MJPGDJKBEEA BKNGMGJAFPD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000074")]
	private float KBEANDGBNDE;

	[Cpp2IlInjected.Token(Token = "0x170000BA")]
	public FJBHJEKKKOJ ALHFICIODDP
	{
		[Cpp2IlInjected.Token(Token = "0x6000314")]
		[Cpp2IlInjected.Address(RVA = "0xA0A790", Offset = "0xA09190", VA = "0x180A0A790", Slot = "4")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000315")]
		[Cpp2IlInjected.Address(RVA = "0xA0A9C0", Offset = "0xA093C0", VA = "0x180A0A9C0", Slot = "5")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000BB")]
	public MMGNDNMMIBP MMLKKGELJEN
	{
		[Cpp2IlInjected.Token(Token = "0x6000316")]
		[Cpp2IlInjected.Address(RVA = "0xA10FC0", Offset = "0xA0F9C0", VA = "0x180A10FC0", Slot = "6")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000317")]
		[Cpp2IlInjected.Address(RVA = "0xA14650", Offset = "0xA13050", VA = "0x180A14650", Slot = "7")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000BC")]
	public Vector3 JPBKJMJLHIP
	{
		[Cpp2IlInjected.Token(Token = "0x6000318")]
		[Cpp2IlInjected.Address(RVA = "0x8527140", Offset = "0x8525B40", VA = "0x188527140", Slot = "8")]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x6000319")]
		[Cpp2IlInjected.Address(RVA = "0x8526130", Offset = "0x8524B30", VA = "0x188526130", Slot = "9")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000BD")]
	public Vector3 JBHKLEPEGOB
	{
		[Cpp2IlInjected.Token(Token = "0x600031A")]
		[Cpp2IlInjected.Address(RVA = "0x8527F80", Offset = "0x8526980", VA = "0x188527F80", Slot = "10")]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x600031B")]
		[Cpp2IlInjected.Address(RVA = "0x8525D40", Offset = "0x8524740", VA = "0x188525D40", Slot = "11")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000BE")]
	public Vector3 DLGDIJHCFOO
	{
		[Cpp2IlInjected.Token(Token = "0x600031C")]
		[Cpp2IlInjected.Address(RVA = "0x8529160", Offset = "0x8527B60", VA = "0x188529160", Slot = "12")]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x600031D")]
		[Cpp2IlInjected.Address(RVA = "0x8528D70", Offset = "0x8527770", VA = "0x188528D70", Slot = "13")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000BF")]
	public Vector3 IALNOMAHNIJ
	{
		[Cpp2IlInjected.Token(Token = "0x600031E")]
		[Cpp2IlInjected.Address(RVA = "0x85272F0", Offset = "0x8525CF0", VA = "0x1885272F0", Slot = "14")]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x600031F")]
		[Cpp2IlInjected.Address(RVA = "0x8527D90", Offset = "0x8526790", VA = "0x188527D90", Slot = "15")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000C0")]
	public float MJKJLPBOFLN
	{
		[Cpp2IlInjected.Token(Token = "0x6000320")]
		[Cpp2IlInjected.Address(RVA = "0xA66540", Offset = "0xA64F40", VA = "0x180A66540", Slot = "16")]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x6000321")]
		[Cpp2IlInjected.Address(RVA = "0x8525AA0", Offset = "0x85244A0", VA = "0x188525AA0", Slot = "17")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000C1")]
	public bool LNCPBHDEHDJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000322")]
		[Cpp2IlInjected.Address(RVA = "0x2377AD0", Offset = "0x23764D0", VA = "0x182377AD0", Slot = "18")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000C2")]
	private INIODDOAIFA HEEDMBFEPEK
	{
		[Cpp2IlInjected.Token(Token = "0x6000337")]
		[Cpp2IlInjected.Address(RVA = "0x7AC63B0", Offset = "0x7AC4DB0", VA = "0x187AC63B0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000C3")]
	private bool LDPCDFPKINP
	{
		[Cpp2IlInjected.Token(Token = "0x6000338")]
		[Cpp2IlInjected.Address(RVA = "0x8527960", Offset = "0x8526360", VA = "0x188527960")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000323")]
	[Cpp2IlInjected.Address(RVA = "0x8529320", Offset = "0x8527D20", VA = "0x188529320")]
	public BKHNHANCMDK(CKPEEOMOJJI OGMEFONHICP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000324")]
	[Cpp2IlInjected.Address(RVA = "0x8526FC0", Offset = "0x85259C0", VA = "0x188526FC0", Slot = "19")]
	public void FHOCOEECEGJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000325")]
	[Cpp2IlInjected.Address(RVA = "0x8526F60", Offset = "0x8525960", VA = "0x188526F60", Slot = "36")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000326")]
	[Cpp2IlInjected.Address(RVA = "0x8528E30", Offset = "0x8527830", VA = "0x188528E30", Slot = "28")]
	public void MDKOPLPDGML(Rigidbody DBPDLPLAFJF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000327")]
	[Cpp2IlInjected.Address(RVA = "0x171E0B0", Offset = "0x171CAB0", VA = "0x18171E0B0", Slot = "20")]
	public void BCIKHBDFKLF(object BECBHDDLOHA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000328")]
	[Cpp2IlInjected.Address(RVA = "0x171D5C0", Offset = "0x171BFC0", VA = "0x18171D5C0", Slot = "30")]
	public void PNIHJMKGADI(object BECBHDDLOHA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000329")]
	[Cpp2IlInjected.Address(RVA = "0x8528580", Offset = "0x8526F80", VA = "0x188528580", Slot = "35")]
	public Vector3 KKDMCMANIMD(Vector3 BIDFFEOGLBL)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x600032A")]
	[Cpp2IlInjected.Address(RVA = "0x8527DC0", Offset = "0x85267C0", VA = "0x188527DC0", Slot = "34")]
	public Vector3 JPBKBCBBAEN(Vector3 CMGKIHAHNKG)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x600032B")]
	[Cpp2IlInjected.Address(RVA = "0x8526FC0", Offset = "0x85259C0", VA = "0x188526FC0", Slot = "27")]
	public void EDHPIKJPNMN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600032C")]
	[Cpp2IlInjected.Address(RVA = "0x8529100", Offset = "0x8527B00", VA = "0x188529100", Slot = "25")]
	public void NGDEHOOAGPF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600032D")]
	[Cpp2IlInjected.Address(RVA = "0x8528D10", Offset = "0x8527710", VA = "0x188528D10", Slot = "24")]
	public void LBDAHKDHKHC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600032E")]
	[Cpp2IlInjected.Address(RVA = "0x8525EF0", Offset = "0x85248F0", VA = "0x188525EF0", Slot = "33")]
	public void CEOJMJCIADC(Vector3 KLLLEBHFHNI, Vector3 KKAICPOLEBD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600032F")]
	[Cpp2IlInjected.Address(RVA = "0x8527900", Offset = "0x8526300", VA = "0x188527900", Slot = "32")]
	public void IEJPNHPPLAB(Vector3 GOGJNILJNEN, Vector3 KMMDBEFLDJJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000330")]
	[Cpp2IlInjected.Address(RVA = "0x8526720", Offset = "0x8525120", VA = "0x188526720", Slot = "31")]
	public void DHPIKNNCCHL(Vector3 MBFMENKJIAM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000331")]
	[Cpp2IlInjected.Address(RVA = "0x85268C0", Offset = "0x85252C0", VA = "0x1885268C0", Slot = "22")]
	public void DMLJDHOMMFJ(PHFBBBOEHHE EOIBMOKJMCC, Vector3 GNPPKKBDPBJ, float CGEKJMEOLJJ, float GEEMEDNHPAN = 8f, float NAFGNOICJFA = 1f)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000332")]
	[Cpp2IlInjected.Address(RVA = "0x8527980", Offset = "0x8526380", VA = "0x188527980", Slot = "21")]
	public void JABLPCALLAE(BFLBDPBGGCC IFGLFJKEHHO, Vector3 FDPNNHOKDDC, float HNEJJEILEPA = float.PositiveInfinity)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000333")]
	[Cpp2IlInjected.Address(RVA = "0x8528100", Offset = "0x8526B00", VA = "0x188528100", Slot = "23")]
	[Obsolete("Deprecated. Still exists to support deprecated CV2 chips. Use ApplyAngularVelocityChange.")]
	public void KGDNPIGJGLI(BFLBDPBGGCC IFGLFJKEHHO, Vector3 NGPACIMGGNA, float BIKCCBHNJCE = 7f, float NNAMGLPMFOG = 1f)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000334")]
	[Cpp2IlInjected.Address(RVA = "0x1839560", Offset = "0x1837F60", VA = "0x181839560")]
	private static void DNIBICGIEHM(Vector3 CGGOJBPICAG, Vector3 ODJALHAEEDH, [Out] Vector3 KIDFMBLAKEE, [Out] Vector3 MNJNIFKICIB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000335")]
	[Cpp2IlInjected.Address(RVA = "0x8527060", Offset = "0x8525A60", VA = "0x188527060", Slot = "29")]
	public Vector3 EEBFPFCGOCD(Vector3 CGGOJBPICAG)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000336")]
	[Cpp2IlInjected.Address(RVA = "0x8525BB0", Offset = "0x85245B0", VA = "0x188525BB0", Slot = "26")]
	public void AHJOIIJCHIM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000339")]
	[Cpp2IlInjected.Address(RVA = "0x8525AA0", Offset = "0x85244A0", VA = "0x188525AA0")]
	private void PHCMNJICAAG(float PCDAHJCDHHF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600033A")]
	[Cpp2IlInjected.Address(RVA = "0x8528F60", Offset = "0x8527960", VA = "0x188528F60")]
	private void NCNKFNCPPMB(Vector3 FDPNNHOKDDC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600033B")]
	[Cpp2IlInjected.Address(RVA = "0x8525D70", Offset = "0x8524770", VA = "0x188525D70")]
	private Vector3 CAEBAJDONIL()
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x600033C")]
	[Cpp2IlInjected.Address(RVA = "0x85261F0", Offset = "0x8524BF0", VA = "0x1885261F0")]
	private void COKDDIMMPNL(Vector3 CMGKIHAHNKG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600033D")]
	[Cpp2IlInjected.Address(RVA = "0x8527C00", Offset = "0x8526600", VA = "0x188527C00")]
	private Vector3 JBDIHPPALPD()
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x600033E")]
	[Cpp2IlInjected.Address(RVA = "0x8527480", Offset = "0x8525E80", VA = "0x188527480")]
	private void GLJFGDOGFCK(Vector3 PCDAHJCDHHF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600033F")]
	[Cpp2IlInjected.Address(RVA = "0x8528760", Offset = "0x8527160", VA = "0x188528760")]
	private void KMEDCOKJOGK(Vector3 CMGKIHAHNKG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000340")]
	[Cpp2IlInjected.Address(RVA = "0x8526670", Offset = "0x8525070", VA = "0x188526670")]
	private void DDOPGBEDMBL()
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
