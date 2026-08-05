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
	public class LogRegistrationIndex : JOPFPPBONLK
	{
		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(RVA = "0x7210B80", Offset = "0x720F580", VA = "0x187210B80", Slot = "4")]
		public override void HEDMFNKAECO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0x8AE600", Offset = "0x8AD000", VA = "0x1808AE600")]
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
	public class _AssemblyIndex : MGJKNLCKGOP
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000001")]
		private int[] localIndices0;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000002")]
		private HMNPLGMOJLM bitset0;

		[Cpp2IlInjected.Token(Token = "0x17000001")]
		public override string[] ServiceCategories
		{
			[Cpp2IlInjected.Token(Token = "0x6000003")]
			[Cpp2IlInjected.Address(RVA = "0x886D60", Offset = "0x885760", VA = "0x180886D60", Slot = "4")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x16F11B0", Offset = "0x16EFBB0", VA = "0x1816F11B0", Slot = "5")]
		public override void EDAHFLECJAF(List<int> globalFromLocalIndices)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x7228060", Offset = "0x7226A60", VA = "0x187228060")]
		private void KDKAKIOJDCM(HBJPOMPKANO registry)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x7228000", Offset = "0x7226A00", VA = "0x187228000", Slot = "6")]
		public override void BHDPLFDBHFO(HBJPOMPKANO registry, [In] MMFLKLEGHJO filter)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x7228360", Offset = "0x7226D60", VA = "0x187228360")]
		public _AssemblyIndex()
		{
		}
	}
}
namespace RecRoom
{
	[Cpp2IlInjected.Token(Token = "0x2000004")]
	[DisallowMultipleComponent]
	public sealed class RigidbodyEx : MonoBehaviour, FJDKJBAPALO
	{
		[Cpp2IlInjected.Token(Token = "0x4000004")]
		private static readonly ANDGIEDMMDP DPLMODMLIGO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000005")]
		private bool LIKHJPHFKDK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000006")]
		private HJICKIEKHCB APBPBLEEACE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000007")]
		[SerializeField]
		[HIPIAIBDPPP(BILCJMODHFE.Self, false, false, false)]
		private Rigidbody unityRigidbody;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000008")]
		[SerializeField]
		[HIPIAIBDPPP(BILCJMODHFE.SelfAndParent, true, false, false)]
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
		[FormerlySerializedAs("forceNoInterpolation")]
		[SerializeField]
		private MFAANDACBHL physicsInterpolation;

		[Cpp2IlInjected.FieldOffset(Offset = "0x5C")]
		[Cpp2IlInjected.Token(Token = "0x400000C")]
		[SerializeField]
		[Tooltip("If checked, this object's Unity Rigidbody will not be stripped when parenting the object to another RigidbodyEx. Only check this on objects that have a Unity Rigidbody by default and who need access to Unity physics events like OnTriggerEnter, OnCollisionEnter, etc. This is sometimes set via script instead of this flag.")]
		private bool keepUnityRigidbodyWhileParented;

		[Cpp2IlInjected.FieldOffset(Offset = "0x5D")]
		[Cpp2IlInjected.Token(Token = "0x400000D")]
		[Tooltip("If the RigidbodyEx has a parent that is being destroyed, this flag allows this RigidbodyEx to keep the parent set. The default behavior is thatthe parent property is set to null, resetting/clearing the existing parent when it is being destroyed.")]
		[SerializeField]
		private bool keepParentOnParentDestroy;

		[Cpp2IlInjected.FieldOffset(Offset = "0x5E")]
		[Cpp2IlInjected.Token(Token = "0x400000E")]
		[SerializeField]
		[HideInInspector]
		private bool hasUnityRigidbodyByDefault;

		[Cpp2IlInjected.Token(Token = "0x17000002")]
		internal HJICKIEKHCB DBLNPODEKIK
		{
			[Cpp2IlInjected.Token(Token = "0x6000008")]
			[Cpp2IlInjected.Address(RVA = "0x72237B0", Offset = "0x72221B0", VA = "0x1872237B0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000003")]
		private HJICKIEKHCB HHLJOHMBLFJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000009")]
			[Cpp2IlInjected.Address(RVA = "0x8869A0", Offset = "0x8853A0", VA = "0x1808869A0", Slot = "6")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000004")]
		public int FHEGHFENGAH
		{
			[Cpp2IlInjected.Token(Token = "0x600001D")]
			[Cpp2IlInjected.Address(RVA = "0x7225470", Offset = "0x7223E70", VA = "0x187225470")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000005")]
		public RigidbodyEx BBJOJGBABEJ
		{
			[Cpp2IlInjected.Token(Token = "0x600001F")]
			[Cpp2IlInjected.Address(RVA = "0x72257D0", Offset = "0x72241D0", VA = "0x1872257D0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000006")]
		public RigidbodyEx AAHAADHCHKF
		{
			[Cpp2IlInjected.Token(Token = "0x6000020")]
			[Cpp2IlInjected.Address(RVA = "0x7225710", Offset = "0x7224110", VA = "0x187225710")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000007")]
		public RigidbodyEx DLPGBMPJIIG
		{
			[Cpp2IlInjected.Token(Token = "0x6000021")]
			[Cpp2IlInjected.Address(RVA = "0x7226470", Offset = "0x7224E70", VA = "0x187226470")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000022")]
			[Cpp2IlInjected.Address(RVA = "0x7227970", Offset = "0x7226370", VA = "0x187227970")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000008")]
		public Transform CBOPPMCLNLL
		{
			[Cpp2IlInjected.Token(Token = "0x6000023")]
			[Cpp2IlInjected.Address(RVA = "0x8ADB00", Offset = "0x8AC500", VA = "0x1808ADB00", Slot = "9")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000009")]
		public Transform MBHDHJFCPOP
		{
			[Cpp2IlInjected.Token(Token = "0x6000024")]
			[Cpp2IlInjected.Address(RVA = "0x8ADB00", Offset = "0x8AC500", VA = "0x1808ADB00", Slot = "10")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000A")]
		public NFCFPCIBOBP ILGDOANNLMK
		{
			[Cpp2IlInjected.Token(Token = "0x6000025")]
			[Cpp2IlInjected.Address(RVA = "0x72254D0", Offset = "0x7223ED0", VA = "0x1872254D0")]
			get
			{
				return default(NFCFPCIBOBP);
			}
			[Cpp2IlInjected.Token(Token = "0x6000026")]
			[Cpp2IlInjected.Address(RVA = "0x7227120", Offset = "0x7225B20", VA = "0x187227120")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000B")]
		public bool OPJGDKAGBJB
		{
			[Cpp2IlInjected.Token(Token = "0x6000027")]
			[Cpp2IlInjected.Address(RVA = "0x7225AE0", Offset = "0x72244E0", VA = "0x187225AE0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000C")]
		public bool HADEFDBIEKJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000028")]
			[Cpp2IlInjected.Address(RVA = "0x72255F0", Offset = "0x7223FF0", VA = "0x1872255F0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000D")]
		public MOINMCBEJEM ODBJPAPAGHJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000029")]
			[Cpp2IlInjected.Address(RVA = "0x7225A20", Offset = "0x7224420", VA = "0x187225A20")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600002A")]
			[Cpp2IlInjected.Address(RVA = "0x72272E0", Offset = "0x7225CE0", VA = "0x1872272E0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000E")]
		public BNOGFHPHCAG HCKNGOOJLMN
		{
			[Cpp2IlInjected.Token(Token = "0x600002B")]
			[Cpp2IlInjected.Address(RVA = "0x72259C0", Offset = "0x72243C0", VA = "0x1872259C0")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600002C")]
			[Cpp2IlInjected.Address(RVA = "0x7227270", Offset = "0x7225C70", VA = "0x187227270")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000F")]
		public bool MAPNACMJLIJ
		{
			[Cpp2IlInjected.Token(Token = "0x600002D")]
			[Cpp2IlInjected.Address(RVA = "0x7225910", Offset = "0x7224310", VA = "0x187225910")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000010")]
		public Rigidbody ENJGFFKJICM
		{
			[Cpp2IlInjected.Token(Token = "0x600002E")]
			[Cpp2IlInjected.Address(RVA = "0x7225970", Offset = "0x7224370", VA = "0x187225970")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000011")]
		public bool FMNKECDKHIA
		{
			[Cpp2IlInjected.Token(Token = "0x600002F")]
			[Cpp2IlInjected.Address(RVA = "0x7225650", Offset = "0x7224050", VA = "0x187225650")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000030")]
			[Cpp2IlInjected.Address(RVA = "0x7227190", Offset = "0x7225B90", VA = "0x187227190")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000012")]
		public bool BBBEOAHNFNO
		{
			[Cpp2IlInjected.Token(Token = "0x6000031")]
			[Cpp2IlInjected.Address(RVA = "0x6EF1270", Offset = "0x6EEFC70", VA = "0x186EF1270", Slot = "7")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000013")]
		public float NAPLACBEKCI
		{
			[Cpp2IlInjected.Token(Token = "0x6000032")]
			[Cpp2IlInjected.Address(RVA = "0x7226410", Offset = "0x7224E10", VA = "0x187226410")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000014")]
		public float GANMDNFMAEB
		{
			[Cpp2IlInjected.Token(Token = "0x6000033")]
			[Cpp2IlInjected.Address(RVA = "0x72263B0", Offset = "0x7224DB0", VA = "0x1872263B0")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x6000034")]
			[Cpp2IlInjected.Address(RVA = "0x7227900", Offset = "0x7226300", VA = "0x187227900")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000015")]
		public float POHEHLDHGBN
		{
			[Cpp2IlInjected.Token(Token = "0x6000035")]
			[Cpp2IlInjected.Address(RVA = "0x7225D40", Offset = "0x7224740", VA = "0x187225D40")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x6000036")]
			[Cpp2IlInjected.Address(RVA = "0x7227580", Offset = "0x7225F80", VA = "0x187227580")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000016")]
		public float IILHOJFNPBM
		{
			[Cpp2IlInjected.Token(Token = "0x6000037")]
			[Cpp2IlInjected.Address(RVA = "0x7225B40", Offset = "0x7224540", VA = "0x187225B40")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x6000038")]
			[Cpp2IlInjected.Address(RVA = "0x7227350", Offset = "0x7225D50", VA = "0x187227350")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000017")]
		public bool HJDCFOPFGFM
		{
			[Cpp2IlInjected.Token(Token = "0x6000039")]
			[Cpp2IlInjected.Address(RVA = "0x72269C0", Offset = "0x72253C0", VA = "0x1872269C0")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x600003A")]
			[Cpp2IlInjected.Address(RVA = "0x7227EB0", Offset = "0x72268B0", VA = "0x187227EB0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000018")]
		public Vector3 ODBCKPGKOOG
		{
			[Cpp2IlInjected.Token(Token = "0x600003B")]
			[Cpp2IlInjected.Address(RVA = "0x7226190", Offset = "0x7224B90", VA = "0x187226190")]
			get
			{
				return default(Vector3);
			}
			[Cpp2IlInjected.Token(Token = "0x600003C")]
			[Cpp2IlInjected.Address(RVA = "0x72276D0", Offset = "0x72260D0", VA = "0x1872276D0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000019")]
		public Vector3 IHLCJMKCNCF
		{
			[Cpp2IlInjected.Token(Token = "0x600003D")]
			[Cpp2IlInjected.Address(RVA = "0x7226B00", Offset = "0x7225500", VA = "0x187226B00")]
			get
			{
				return default(Vector3);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001A")]
		public CollisionDetectionMode LHIGPDKBHLJ
		{
			[Cpp2IlInjected.Token(Token = "0x600003E")]
			[Cpp2IlInjected.Address(RVA = "0x7225C80", Offset = "0x7224680", VA = "0x187225C80")]
			get
			{
				return default(CollisionDetectionMode);
			}
			[Cpp2IlInjected.Token(Token = "0x600003F")]
			[Cpp2IlInjected.Address(RVA = "0x72274A0", Offset = "0x7225EA0", VA = "0x1872274A0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001B")]
		public float ADIOGPKDCDC
		{
			[Cpp2IlInjected.Token(Token = "0x6000040")]
			[Cpp2IlInjected.Address(RVA = "0x72256B0", Offset = "0x72240B0", VA = "0x1872256B0")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x6000041")]
			[Cpp2IlInjected.Address(RVA = "0x7227200", Offset = "0x7225C00", VA = "0x187227200")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001C")]
		public RigidbodyConstraints AADIACFNDHD
		{
			[Cpp2IlInjected.Token(Token = "0x6000042")]
			[Cpp2IlInjected.Address(RVA = "0x7225CE0", Offset = "0x72246E0", VA = "0x187225CE0")]
			get
			{
				return default(RigidbodyConstraints);
			}
			[Cpp2IlInjected.Token(Token = "0x6000043")]
			[Cpp2IlInjected.Address(RVA = "0x7227510", Offset = "0x7225F10", VA = "0x187227510")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001D")]
		public Vector3 EFOFLMPMEBC
		{
			[Cpp2IlInjected.Token(Token = "0x6000044")]
			[Cpp2IlInjected.Address(RVA = "0x7226530", Offset = "0x7224F30", VA = "0x187226530")]
			get
			{
				return default(Vector3);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001E")]
		public Vector3 PHMFBMJCFMF
		{
			[Cpp2IlInjected.Token(Token = "0x6000045")]
			[Cpp2IlInjected.Address(RVA = "0x7226530", Offset = "0x7224F30", VA = "0x187226530")]
			get
			{
				return default(Vector3);
			}
			[Cpp2IlInjected.Token(Token = "0x6000046")]
			[Cpp2IlInjected.Address(RVA = "0x7227C90", Offset = "0x7226690", VA = "0x187227C90")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001F")]
		public float MAFDCDMMPAH
		{
			[Cpp2IlInjected.Token(Token = "0x6000047")]
			[Cpp2IlInjected.Address(RVA = "0x7226270", Offset = "0x7224C70", VA = "0x187226270")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x6000048")]
			[Cpp2IlInjected.Address(RVA = "0x72277B0", Offset = "0x72261B0", VA = "0x1872277B0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000020")]
		public float BHMLHIHMNMC
		{
			[Cpp2IlInjected.Token(Token = "0x6000049")]
			[Cpp2IlInjected.Address(RVA = "0x7226960", Offset = "0x7225360", VA = "0x187226960")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x600004A")]
			[Cpp2IlInjected.Address(RVA = "0x7227E40", Offset = "0x7226840", VA = "0x187227E40")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000021")]
		public Quaternion HGGMFOOPOLM
		{
			[Cpp2IlInjected.Token(Token = "0x600004B")]
			[Cpp2IlInjected.Address(RVA = "0x7226610", Offset = "0x7225010", VA = "0x187226610")]
			get
			{
				return default(Quaternion);
			}
			[Cpp2IlInjected.Token(Token = "0x600004C")]
			[Cpp2IlInjected.Address(RVA = "0x7227A10", Offset = "0x7226410", VA = "0x187227A10")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000022")]
		public Quaternion DEEEKODDHGP
		{
			[Cpp2IlInjected.Token(Token = "0x600004D")]
			[Cpp2IlInjected.Address(RVA = "0x7226890", Offset = "0x7225290", VA = "0x187226890")]
			get
			{
				return default(Quaternion);
			}
			[Cpp2IlInjected.Token(Token = "0x600004E")]
			[Cpp2IlInjected.Address(RVA = "0x7227D70", Offset = "0x7226770", VA = "0x187227D70")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000023")]
		public Vector3 DLGGAMKGPMG
		{
			[Cpp2IlInjected.Token(Token = "0x600004F")]
			[Cpp2IlInjected.Address(RVA = "0x72266E0", Offset = "0x72250E0", VA = "0x1872266E0")]
			get
			{
				return default(Vector3);
			}
			[Cpp2IlInjected.Token(Token = "0x6000050")]
			[Cpp2IlInjected.Address(RVA = "0x7227AE0", Offset = "0x72264E0", VA = "0x187227AE0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000024")]
		public Quaternion MJLKKMJKBHB
		{
			[Cpp2IlInjected.Token(Token = "0x6000051")]
			[Cpp2IlInjected.Address(RVA = "0x72267C0", Offset = "0x72251C0", VA = "0x1872267C0")]
			get
			{
				return default(Quaternion);
			}
			[Cpp2IlInjected.Token(Token = "0x6000052")]
			[Cpp2IlInjected.Address(RVA = "0x7227BC0", Offset = "0x72265C0", VA = "0x187227BC0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000025")]
		public Vector3 NJFMAFAPHLI
		{
			[Cpp2IlInjected.Token(Token = "0x6000053")]
			[Cpp2IlInjected.Address(RVA = "0x7226A20", Offset = "0x7225420", VA = "0x187226A20")]
			get
			{
				return default(Vector3);
			}
			[Cpp2IlInjected.Token(Token = "0x6000054")]
			[Cpp2IlInjected.Address(RVA = "0x7227F20", Offset = "0x7226920", VA = "0x187227F20")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000026")]
		public Vector3 OHJOFKNMAIN
		{
			[Cpp2IlInjected.Token(Token = "0x6000055")]
			[Cpp2IlInjected.Address(RVA = "0x72262D0", Offset = "0x7224CD0", VA = "0x1872262D0")]
			get
			{
				return default(Vector3);
			}
			[Cpp2IlInjected.Token(Token = "0x6000056")]
			[Cpp2IlInjected.Address(RVA = "0x7227820", Offset = "0x7226220", VA = "0x187227820")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000027")]
		public Vector3 DJJLOCLIPLL
		{
			[Cpp2IlInjected.Token(Token = "0x6000057")]
			[Cpp2IlInjected.Address(RVA = "0x7225BA0", Offset = "0x72245A0", VA = "0x187225BA0")]
			get
			{
				return default(Vector3);
			}
			[Cpp2IlInjected.Token(Token = "0x6000058")]
			[Cpp2IlInjected.Address(RVA = "0x72273C0", Offset = "0x7225DC0", VA = "0x1872273C0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000028")]
		public Vector3 AGNGOBCJFND
		{
			[Cpp2IlInjected.Token(Token = "0x6000059")]
			[Cpp2IlInjected.Address(RVA = "0x72260B0", Offset = "0x7224AB0", VA = "0x1872260B0")]
			get
			{
				return default(Vector3);
			}
			[Cpp2IlInjected.Token(Token = "0x600005A")]
			[Cpp2IlInjected.Address(RVA = "0x72275F0", Offset = "0x7225FF0", VA = "0x1872275F0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000029")]
		public Vector3 ENCBDNIANFH
		{
			[Cpp2IlInjected.Token(Token = "0x600005B")]
			[Cpp2IlInjected.Address(RVA = "0x7225F70", Offset = "0x7224970", VA = "0x187225F70")]
			get
			{
				return default(Vector3);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002A")]
		public Quaternion AHEJDGJEAEC
		{
			[Cpp2IlInjected.Token(Token = "0x600005C")]
			[Cpp2IlInjected.Address(RVA = "0x7225EA0", Offset = "0x72248A0", VA = "0x187225EA0")]
			get
			{
				return default(Quaternion);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002B")]
		public Vector3 PGMBOHFELHA
		{
			[Cpp2IlInjected.Token(Token = "0x600005E")]
			[Cpp2IlInjected.Address(RVA = "0x7226CC0", Offset = "0x72256C0", VA = "0x187226CC0")]
			get
			{
				return default(Vector3);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002C")]
		public Vector3 NCKCLBDKBHN
		{
			[Cpp2IlInjected.Token(Token = "0x600005F")]
			[Cpp2IlInjected.Address(RVA = "0x7226BE0", Offset = "0x72255E0", VA = "0x187226BE0")]
			get
			{
				return default(Vector3);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002D")]
		public bool BPGMIOFNKDI
		{
			[Cpp2IlInjected.Token(Token = "0x6000060")]
			[Cpp2IlInjected.Address(RVA = "0x7226050", Offset = "0x7224A50", VA = "0x187226050")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002E")]
		public bool JKINAMKOAAB
		{
			[Cpp2IlInjected.Token(Token = "0x6000061")]
			[Cpp2IlInjected.Address(RVA = "0x7225A80", Offset = "0x7224480", VA = "0x187225A80")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002F")]
		public bool NGIDNAPEOEC
		{
			[Cpp2IlInjected.Token(Token = "0x6000062")]
			[Cpp2IlInjected.Address(RVA = "0x7225590", Offset = "0x7223F90", VA = "0x187225590")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000030")]
		public bool LPDJMMMOHBI
		{
			[Cpp2IlInjected.Token(Token = "0x6000063")]
			[Cpp2IlInjected.Address(RVA = "0x7225530", Offset = "0x7223F30", VA = "0x187225530")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000031")]
		public bool DJPEMFPPIEO
		{
			[Cpp2IlInjected.Token(Token = "0x6000064")]
			[Cpp2IlInjected.Address(RVA = "0x7225410", Offset = "0x7223E10", VA = "0x187225410")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000032")]
		public bool BFOCIENMGIH
		{
			[Cpp2IlInjected.Token(Token = "0x6000065")]
			[Cpp2IlInjected.Address(RVA = "0x7225DA0", Offset = "0x72247A0", VA = "0x187225DA0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000033")]
		public bool PAJCHKNMDKC
		{
			[Cpp2IlInjected.Token(Token = "0x6000066")]
			[Cpp2IlInjected.Address(RVA = "0x197ACE0", Offset = "0x19796E0", VA = "0x18197ACE0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000001")]
		public event OOHMNMHPFKK OBIKAKCMHEK
		{
			[Cpp2IlInjected.Token(Token = "0x600000D")]
			[Cpp2IlInjected.Address(RVA = "0x7225330", Offset = "0x7223D30", VA = "0x187225330")]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x600000E")]
			[Cpp2IlInjected.Address(RVA = "0x7227040", Offset = "0x7225A40", VA = "0x187227040")]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000002")]
		public event NKPGNCNJBFD IEDGJIENIIM
		{
			[Cpp2IlInjected.Token(Token = "0x600000F")]
			[Cpp2IlInjected.Address(RVA = "0x72250A0", Offset = "0x7223AA0", VA = "0x1872250A0")]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000010")]
			[Cpp2IlInjected.Address(RVA = "0x7226DA0", Offset = "0x72257A0", VA = "0x187226DA0")]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000003")]
		public event NKPGNCNJBFD PNCCADFDAHC
		{
			[Cpp2IlInjected.Token(Token = "0x6000011")]
			[Cpp2IlInjected.Address(RVA = "0x7225100", Offset = "0x7223B00", VA = "0x187225100")]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000012")]
			[Cpp2IlInjected.Address(RVA = "0x7226E10", Offset = "0x7225810", VA = "0x187226E10")]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000004")]
		public event NKPGNCNJBFD KKPBBMAJJGO
		{
			[Cpp2IlInjected.Token(Token = "0x6000013")]
			[Cpp2IlInjected.Address(RVA = "0x7225250", Offset = "0x7223C50", VA = "0x187225250")]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000014")]
			[Cpp2IlInjected.Address(RVA = "0x7226F60", Offset = "0x7225960", VA = "0x187226F60")]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000005")]
		public event Action<JNKKEIFENFB, JNKKEIFENFB> AEJNOMLLHBM
		{
			[Cpp2IlInjected.Token(Token = "0x6000015")]
			[Cpp2IlInjected.Address(RVA = "0x72251E0", Offset = "0x7223BE0", VA = "0x1872251E0")]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000016")]
			[Cpp2IlInjected.Address(RVA = "0x7226EF0", Offset = "0x72258F0", VA = "0x187226EF0")]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000006")]
		public event NKPGNCNJBFD FHFHIENNBHJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000017")]
			[Cpp2IlInjected.Address(RVA = "0x72252C0", Offset = "0x7223CC0", VA = "0x1872252C0")]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000018")]
			[Cpp2IlInjected.Address(RVA = "0x7226FD0", Offset = "0x72259D0", VA = "0x187226FD0")]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000007")]
		public event NKPGNCNJBFD LFGLMKOPOPM
		{
			[Cpp2IlInjected.Token(Token = "0x6000019")]
			[Cpp2IlInjected.Address(RVA = "0x72253A0", Offset = "0x7223DA0", VA = "0x1872253A0")]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x600001A")]
			[Cpp2IlInjected.Address(RVA = "0x72270B0", Offset = "0x7225AB0", VA = "0x1872270B0")]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000008")]
		public event NKPGNCNJBFD NBIFIJICLGO
		{
			[Cpp2IlInjected.Token(Token = "0x600001B")]
			[Cpp2IlInjected.Address(RVA = "0x7225170", Offset = "0x7223B70", VA = "0x187225170")]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x600001C")]
			[Cpp2IlInjected.Address(RVA = "0x7226E80", Offset = "0x7225880", VA = "0x187226E80")]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x885AF0", Offset = "0x8844F0", VA = "0x180885AF0", Slot = "8")]
		private void GMBOAMFBDNH(HJICKIEKHCB BMCAAIIMEIN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x7224120", Offset = "0x7222B20", VA = "0x187224120")]
		internal void NCINAKJGLFO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x7224DD0", Offset = "0x72237D0", VA = "0x187224DD0")]
		[Conditional("DEBUG_BUILD")]
		[Conditional("UNITY_EDITOR")]
		public void TestOverrideUnityRigidbody(Rigidbody CFFLIADABBC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x7223AE0", Offset = "0x72224E0", VA = "0x187223AE0")]
		public FJDKJBAPALO GetChild(int EBDDHAPIAHH)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600005D")]
		[Cpp2IlInjected.Address(RVA = "0x7224A40", Offset = "0x7223440", VA = "0x187224A40")]
		public void SetInertiaTensor((Quaternion rot, Vector3 moments) FLBDCMBPIHC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000067")]
		[Cpp2IlInjected.Address(RVA = "0x72235C0", Offset = "0x7221FC0", VA = "0x1872235C0")]
		private void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000068")]
		[Cpp2IlInjected.Address(RVA = "0x72237B0", Offset = "0x72221B0", VA = "0x1872237B0")]
		private HJICKIEKHCB DNCJIBJJLJI()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000069")]
		[Cpp2IlInjected.Address(RVA = "0x72238C0", Offset = "0x72222C0", VA = "0x1872238C0")]
		private void FKBEJNBPEHL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006A")]
		[Cpp2IlInjected.Address(RVA = "0x7224210", Offset = "0x7222C10", VA = "0x187224210")]
		private void OnEnable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006B")]
		[Cpp2IlInjected.Address(RVA = "0x7224120", Offset = "0x7222B20", VA = "0x187224120")]
		private void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006C")]
		[Cpp2IlInjected.Address(RVA = "0x72241B0", Offset = "0x7222BB0", VA = "0x1872241B0")]
		private void OnDrawGizmosSelected()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006D")]
		[Cpp2IlInjected.Address(RVA = "0x7224270", Offset = "0x7222C70", VA = "0x187224270")]
		private void OnValidate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006E")]
		[Cpp2IlInjected.Address(RVA = "0x7222BB0", Offset = "0x72215B0", VA = "0x187222BB0")]
		public void AddDoNotResetVelocityOnOwnershipChangeOverride(object KLGLJKMNAIM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006F")]
		[Cpp2IlInjected.Address(RVA = "0x72242D0", Offset = "0x7222CD0", VA = "0x1872242D0")]
		public void RemoveDoNotResetVelocityOnOwnershipChangeOverride(object KLGLJKMNAIM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000070")]
		[Cpp2IlInjected.Address(RVA = "0x7223860", Offset = "0x7222260", VA = "0x187223860")]
		public void DisableCachedInertialPropertyOverride()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000071")]
		[Cpp2IlInjected.Address(RVA = "0x72240C0", Offset = "0x7222AC0", VA = "0x1872240C0")]
		public void MarkCachedInertialParametersDirty()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000072")]
		[Cpp2IlInjected.Address(RVA = "0x7224BA0", Offset = "0x72235A0", VA = "0x187224BA0")]
		public void SetParent(RigidbodyEx CLMKDBDPNNH, bool LHJNJOHGEIJ = false)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000073")]
		[Cpp2IlInjected.Address(RVA = "0x72245E0", Offset = "0x7222FE0", VA = "0x1872245E0")]
		public void ResetLocalCenterOfMassToPrefabDefault()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000074")]
		[Cpp2IlInjected.Address(RVA = "0x7223D90", Offset = "0x7222790", VA = "0x187223D90")]
		public bool IsRigidbodyAncestor(RigidbodyEx IBBAAMOKGCI)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000075")]
		[Cpp2IlInjected.Address(RVA = "0x7223E70", Offset = "0x7222870", VA = "0x187223E70")]
		public bool IsRigidbodyDescendant(RigidbodyEx OBIMHFIMJFE)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000076")]
		[Cpp2IlInjected.Address(RVA = "0x7222E20", Offset = "0x7221820", VA = "0x187222E20")]
		public void AddInterpolationRestriction(object KLGLJKMNAIM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000077")]
		[Cpp2IlInjected.Address(RVA = "0x7224340", Offset = "0x7222D40", VA = "0x187224340")]
		public void RemoveInterpolationRestriction(object KLGLJKMNAIM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000078")]
		[Cpp2IlInjected.Address(RVA = "0x7222E90", Offset = "0x7221890", VA = "0x187222E90")]
		public void AddKinematic(object KLGLJKMNAIM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000079")]
		[Cpp2IlInjected.Address(RVA = "0x72243B0", Offset = "0x7222DB0", VA = "0x1872243B0")]
		public void RemoveKinematic(object KLGLJKMNAIM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007A")]
		[Cpp2IlInjected.Address(RVA = "0x7224B20", Offset = "0x7223520", VA = "0x187224B20")]
		public void SetKinematic(object KLGLJKMNAIM, bool IMIKPNPKFPA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007B")]
		[Cpp2IlInjected.Address(RVA = "0x7224940", Offset = "0x7223340", VA = "0x187224940")]
		public void SetDiscontinuousPositionAndRotation(Vector3 ILNFMJCEOCO, Quaternion LDGNMLEDOMN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007C")]
		[Cpp2IlInjected.Address(RVA = "0x7224840", Offset = "0x7223240", VA = "0x187224840")]
		public void SetDiscontinuousLocalPositionAndLocalRotation(Vector3 PEEBPBGNOFG, Quaternion BLGCEGNAMEE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007D")]
		[Cpp2IlInjected.Address(RVA = "0x7223C80", Offset = "0x7222680", VA = "0x187223C80")]
		public Vector3 GetConstrainedVelocity(Vector3 NJFMAFAPHLI)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x600007E")]
		[Cpp2IlInjected.Address(RVA = "0x7223B70", Offset = "0x7222570", VA = "0x187223B70")]
		public Vector3 GetConstrainedAngularVelocity(Vector3 DJJLOCLIPLL)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x600007F")]
		[Cpp2IlInjected.Address(RVA = "0x7222D30", Offset = "0x7221730", VA = "0x187222D30")]
		public void AddForce(Vector3 MOFNDFHCJJC, ForceMode JFFPEBEJOGP = ForceMode.Force)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000080")]
		[Cpp2IlInjected.Address(RVA = "0x7222C20", Offset = "0x7221620", VA = "0x187222C20")]
		public void AddForceAtPosition(Vector3 MOFNDFHCJJC, Vector3 BJDHDJCINFH, ForceMode JFFPEBEJOGP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000081")]
		[Cpp2IlInjected.Address(RVA = "0x7223060", Offset = "0x7221A60", VA = "0x187223060")]
		public void AddTorque(Vector3 LGFOKCMDDNH, ForceMode JFFPEBEJOGP = ForceMode.Force)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000082")]
		[Cpp2IlInjected.Address(RVA = "0x7222F00", Offset = "0x7221900", VA = "0x187222F00")]
		public void AddRelativeTorque(Vector3 LGFOKCMDDNH, ForceMode JFFPEBEJOGP = ForceMode.Force)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000083")]
		[Cpp2IlInjected.Address(RVA = "0x7224EA0", Offset = "0x72238A0", VA = "0x187224EA0")]
		public Vector3 WorldToLocalVelocity(Vector3 IACJOJBIIMH)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x6000084")]
		[Cpp2IlInjected.Address(RVA = "0x7223FB0", Offset = "0x72229B0", VA = "0x187223FB0")]
		public Vector3 LocalToWorldVelocity(Vector3 OHJOFKNMAIN)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x6000085")]
		[Cpp2IlInjected.Address(RVA = "0x7223750", Offset = "0x7222150", VA = "0x187223750")]
		public void ClearVelocity()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000086")]
		[Cpp2IlInjected.Address(RVA = "0x72236F0", Offset = "0x72220F0", VA = "0x1872236F0")]
		public void ClearUnityRigidbodyVelocity()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000087")]
		[Cpp2IlInjected.Address(RVA = "0x7223690", Offset = "0x7222090", VA = "0x187223690")]
		public void ClearLinearVelocity()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000088")]
		[Cpp2IlInjected.Address(RVA = "0x7223630", Offset = "0x7222030", VA = "0x187223630")]
		public void ClearAngularVelocity()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000089")]
		[Cpp2IlInjected.Address(RVA = "0x7224740", Offset = "0x7223140", VA = "0x187224740")]
		public void ResetVelocityWorldSpace(Vector3 EMGHCEJLGLC, Vector3 KJKLMOGLNDO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008A")]
		[Cpp2IlInjected.Address(RVA = "0x7224640", Offset = "0x7223040", VA = "0x187224640")]
		public void ResetVelocityLocalSpace(Vector3 HPJCGHLPDFH, Vector3 AGNGOBCJFND)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008B")]
		[Cpp2IlInjected.Address(RVA = "0x7224500", Offset = "0x7222F00", VA = "0x187224500")]
		public void ResetLinearVelocityLocalSpace(Vector3 HPJCGHLPDFH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008C")]
		[Cpp2IlInjected.Address(RVA = "0x7224CD0", Offset = "0x72236D0", VA = "0x187224CD0")]
		public bool SweepTest(Vector3 IMGPFEFAFKM, [Out] RaycastHit OEEPALGMIPF, float NGBAMCDGGDI)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600008D")]
		[Cpp2IlInjected.Address(RVA = "0x7223F50", Offset = "0x7222950", VA = "0x187223F50")]
		public bool IsSleeping()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600008E")]
		[Cpp2IlInjected.Address(RVA = "0x7224C70", Offset = "0x7223670", VA = "0x187224C70")]
		public void Sleep()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008F")]
		[Cpp2IlInjected.Address(RVA = "0x7224E40", Offset = "0x7223840", VA = "0x187224E40")]
		public void WakeUp()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000090")]
		[Cpp2IlInjected.Address(RVA = "0x7222FF0", Offset = "0x72219F0", VA = "0x187222FF0")]
		public void AddShouldHaveUnityRigidbodyToken(object KLGLJKMNAIM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000091")]
		[Cpp2IlInjected.Address(RVA = "0x7224420", Offset = "0x7222E20", VA = "0x187224420")]
		public void RemoveShouldHaveUnityRigidbodyToken(object KLGLJKMNAIM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000092")]
		[Cpp2IlInjected.Address(RVA = "0x72233F0", Offset = "0x7221DF0", VA = "0x1872233F0")]
		public void ApplyForceVelocityChange(HBBOOGIPJMD FFJEGHOFDPM, Vector3 EMGGJFAEADN, float CPAMMGNNLIK, float FANFOKDGIAB = 8f, float CDKGJFKHGOO = 1f)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000093")]
		[Cpp2IlInjected.Address(RVA = "0x72232F0", Offset = "0x7221CF0", VA = "0x1872232F0")]
		public void ApplyAngularVelocityChange(JENDIECHPBG EDKHDNCHGOP, Vector3 BNLBDJCNEIC, float OBBKOHIDJFD = float.PositiveInfinity)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000094")]
		[Cpp2IlInjected.Address(RVA = "0x72234B0", Offset = "0x7221EB0", VA = "0x1872234B0")]
		[Obsolete("Deprecated. Still exists to support deprecated CV2 chips. Use ApplyAngularVelocityChange.")]
		public void ApplyTorqueAngularVelocityChangeDeprecated(JENDIECHPBG EDKHDNCHGOP, Vector3 FJFNLINEAKI, float ELILELMDMOP = 7f, float NHPMFBAHPKH = 1f)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000095")]
		[Cpp2IlInjected.Address(RVA = "0x7223220", Offset = "0x7221C20", VA = "0x187223220")]
		public bool AllowedScaleChange(float EHGIEAAFJMP)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000096")]
		[Cpp2IlInjected.Address(RVA = "0x7223150", Offset = "0x7221B50", VA = "0x187223150")]
		public void AddWorldSpaceVelocityInHierarchyParentOverride(RigidbodyEx FHNLPGNOJOF, object KLGLJKMNAIM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000097")]
		[Cpp2IlInjected.Address(RVA = "0x7224490", Offset = "0x7222E90", VA = "0x187224490")]
		public void RemoveWorldSpaceVelocityInHierarchyParentOverride(object KLGLJKMNAIM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000098")]
		[Cpp2IlInjected.Address(RVA = "0x7225030", Offset = "0x7223A30", VA = "0x187225030")]
		public RigidbodyEx()
		{
		}

		[SpecialName]
		[Cpp2IlInjected.Token(Token = "0x600009A")]
		[Cpp2IlInjected.Address(RVA = "0xB6CC30", Offset = "0xB6B630", VA = "0x180B6CC30", Slot = "4")]
		private GameObject CLBFFKMNHEN()
		{
			return null;
		}

		[SpecialName]
		[Cpp2IlInjected.Token(Token = "0x600009B")]
		[Cpp2IlInjected.Address(RVA = "0x8ADB00", Offset = "0x8AC500", VA = "0x1808ADB00", Slot = "5")]
		private Transform HPFBCIGNCDE()
		{
			return null;
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
internal static class EDODFJLIFKE
{
	[Cpp2IlInjected.Token(Token = "0x600009C")]
	[Cpp2IlInjected.Address(RVA = "0x720F070", Offset = "0x720DA70", VA = "0x18720F070")]
	public static HJICKIEKHCB DBLNPODEKIK(this RigidbodyEx PPHDEPKLLOK)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
[DCFNIFAPBBP(typeof(BNEKFFELJGI), new string[] { })]
public class HAJGEJHDICF : BNEKFFELJGI, BINHHNGJBOP
{
	[Cpp2IlInjected.Token(Token = "0x400000F")]
	private static readonly ANDGIEDMMDP AGICKJCJECJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000010")]
	private BOBFKIFHEGL KCJPACILNMJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000011")]
	private IPLICLCFIHJ NAAJCHKOOEC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000012")]
	private MANGKBMACHI EEFNBJAPHOL;

	[Cpp2IlInjected.Token(Token = "0x17000034")]
	public IPLICLCFIHJ FPIPIFICAFL
	{
		[Cpp2IlInjected.Token(Token = "0x600009D")]
		[Cpp2IlInjected.Address(RVA = "0x886780", Offset = "0x885180", VA = "0x180886780", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000035")]
	public MANGKBMACHI JNFAHHIPBCC
	{
		[Cpp2IlInjected.Token(Token = "0x600009E")]
		[Cpp2IlInjected.Address(RVA = "0x8869A0", Offset = "0x8853A0", VA = "0x1808869A0", Slot = "5")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600009F")]
	[Cpp2IlInjected.Address(RVA = "0x7210230", Offset = "0x720EC30", VA = "0x187210230", Slot = "7")]
	public void InitReferences(KFBOEJEEJNO NOGJIGADMKJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A0")]
	[Cpp2IlInjected.Address(RVA = "0x72102C0", Offset = "0x720ECC0", VA = "0x1872102C0", Slot = "6")]
	public HJICKIEKHCB OBLJOBJDBCF(RigidbodyEx PPHDEPKLLOK, BBDIDLADECH OIGMDCDEKEG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000A1")]
	[Cpp2IlInjected.Address(RVA = "0x883870", Offset = "0x882270", VA = "0x180883870")]
	public HAJGEJHDICF()
	{
	}
}
namespace RecRoom
{
	[Cpp2IlInjected.Token(Token = "0x2000007")]
	public class PhysicsManager : SingletonMonoBehaviour<PhysicsManager>
	{
		[Cpp2IlInjected.Token(Token = "0x4000013")]
		public static PLAJPLAPENK UpdateAfterFixedUpdateRan;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000014")]
		private int FAADJCCBPDA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x4000015")]
		private int BGHBFCMCIDJ;

		[Cpp2IlInjected.Token(Token = "0x60000A3")]
		[Cpp2IlInjected.Address(RVA = "0x7222A30", Offset = "0x7221430", VA = "0x187222A30")]
		protected void FixedUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A4")]
		[Cpp2IlInjected.Address(RVA = "0x7222A70", Offset = "0x7221470", VA = "0x187222A70")]
		protected void Update()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A5")]
		[Cpp2IlInjected.Address(RVA = "0x7222A50", Offset = "0x7221450", VA = "0x187222A50")]
		protected void LateUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A6")]
		[Cpp2IlInjected.Address(RVA = "0x883230", Offset = "0x881C30", VA = "0x180883230")]
		[Conditional("UNITY_ASSERTIONS")]
		public void AssertLateColliderPositionsNotYetUpdated([Optional] string MEBLNPKEJMN, [Optional] UnityEngine.Object GJGBLLHIOAC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A7")]
		[Cpp2IlInjected.Address(RVA = "0x883230", Offset = "0x881C30", VA = "0x180883230")]
		[Conditional("UNITY_ASSERTIONS")]
		public void AssertLateColliderPositionsAlreadyUpdated([Optional] string MEBLNPKEJMN, [Optional] UnityEngine.Object GJGBLLHIOAC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A8")]
		[Cpp2IlInjected.Address(RVA = "0x7222B60", Offset = "0x7221560", VA = "0x187222B60")]
		public PhysicsManager()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
public static class MDPAOIGAJAP
{
	[Cpp2IlInjected.Token(Token = "0x2000009")]
	private class BFKLCILLLKB : MOINMCBEJEM, IDisposable
	{
		[Cpp2IlInjected.Token(Token = "0x60000AC")]
		[Cpp2IlInjected.Address(RVA = "0x883230", Offset = "0x881C30", VA = "0x180883230", Slot = "6")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AD")]
		[Cpp2IlInjected.Address(RVA = "0x893E00", Offset = "0x892800", VA = "0x180893E00", Slot = "4")]
		public Vector3 HNLJDHBDHPN()
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x60000AE")]
		[Cpp2IlInjected.Address(RVA = "0x893E00", Offset = "0x892800", VA = "0x180893E00", Slot = "5")]
		public Vector3 LIINOOCIIKD()
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x60000AF")]
		[Cpp2IlInjected.Address(RVA = "0x883870", Offset = "0x882270", VA = "0x180883870")]
		public BFKLCILLLKB()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000036")]
	public static MOINMCBEJEM DJOBJONIHKC
	{
		[Cpp2IlInjected.Token(Token = "0x60000AA")]
		[Cpp2IlInjected.Address(RVA = "0x7214330", Offset = "0x7212D30", VA = "0x187214330")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
public interface EKCNEAFKJAH
{
	[Cpp2IlInjected.Token(Token = "0x17000037")]
	CollisionDetectionMode MMFMGKDFGGO
	{
		[Cpp2IlInjected.Token(Token = "0x60000B0")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
		[Cpp2IlInjected.Token(Token = "0x60000B1")]
		[Cpp2IlInjected.Address(Slot = "1")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x60000B2")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void IMJENBPCPEE();

	[Cpp2IlInjected.Token(Token = "0x60000B3")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void JJPCIBKOCBB(bool BPGMIOFNKDI);

	[Cpp2IlInjected.Token(Token = "0x60000B4")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void JPMGNEOGEPM(bool BPGMIOFNKDI);

	[Cpp2IlInjected.Token(Token = "0x60000B5")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void GENJEMJACDM(Rigidbody BBHGIADMCFO);

	[Cpp2IlInjected.Token(Token = "0x60000B6")]
	[Cpp2IlInjected.Address(Slot = "6")]
	bool KELNKHMGIFP(Vector3 IMGPFEFAFKM, [Out] RaycastHit OEEPALGMIPF, float NGBAMCDGGDI);
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
public interface IJLFCEHECEB : IDisposable, KJMHNCGJAFK
{
	[Cpp2IlInjected.Token(Token = "0x17000038")]
	NFCFPCIBOBP ILGDOANNLMK
	{
		[Cpp2IlInjected.Token(Token = "0x60000B9")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
		[Cpp2IlInjected.Token(Token = "0x60000BA")]
		[Cpp2IlInjected.Address(Slot = "3")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x14000009")]
	event Action<JNKKEIFENFB, JNKKEIFENFB> AEJNOMLLHBM;

	[Cpp2IlInjected.Token(Token = "0x60000BB")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void IMJENBPCPEE();
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
[FACHKNACJCC(KCCBMFNNLJD.Application)]
public interface MANGKBMACHI
{
	[Cpp2IlInjected.Token(Token = "0x60000BC")]
	[Cpp2IlInjected.Address(Slot = "0")]
	KDLCFDJHOCK NCDAEDPHLNE(HJICKIEKHCB BMCAAIIMEIN);

	[Cpp2IlInjected.Token(Token = "0x60000BD")]
	[Cpp2IlInjected.Address(Slot = "1")]
	LJPNFDLEOFJ KOEEMIHEAAK(HJICKIEKHCB BMCAAIIMEIN);

	[Cpp2IlInjected.Token(Token = "0x60000BE")]
	[Cpp2IlInjected.Address(Slot = "2")]
	LJFHHIGODHB GDBAFLBNLFA(HJICKIEKHCB BMCAAIIMEIN);

	[Cpp2IlInjected.Token(Token = "0x60000BF")]
	[Cpp2IlInjected.Address(Slot = "3")]
	INLJEOCBMAL IGCENJABKPM(HJICKIEKHCB BMCAAIIMEIN);

	[Cpp2IlInjected.Token(Token = "0x60000C0")]
	[Cpp2IlInjected.Address(Slot = "4")]
	MAKONEBMAFE ENKHCBIPNEF(HJICKIEKHCB BMCAAIIMEIN);

	[Cpp2IlInjected.Token(Token = "0x60000C1")]
	[Cpp2IlInjected.Address(Slot = "5")]
	IJLFCEHECEB AJIJBPHNKJG(HJICKIEKHCB BMCAAIIMEIN);

	[Cpp2IlInjected.Token(Token = "0x60000C2")]
	[Cpp2IlInjected.Address(Slot = "6")]
	GIPEFGCNFNA BBKHGLMFDAI(HJICKIEKHCB BMCAAIIMEIN);

	[Cpp2IlInjected.Token(Token = "0x60000C3")]
	[Cpp2IlInjected.Address(Slot = "7")]
	HLBPPEDLPKE MFNMGKPODKP(HJICKIEKHCB BMCAAIIMEIN);

	[Cpp2IlInjected.Token(Token = "0x60000C4")]
	[Cpp2IlInjected.Address(Slot = "8")]
	EKCNEAFKJAH MMJAJGALNDA(HJICKIEKHCB BMCAAIIMEIN);

	[Cpp2IlInjected.Token(Token = "0x60000C5")]
	[Cpp2IlInjected.Address(Slot = "9")]
	GHALEEJPMBF GBMJBKOBCBG(HJICKIEKHCB BMCAAIIMEIN);

	[Cpp2IlInjected.Token(Token = "0x60000C6")]
	[Cpp2IlInjected.Address(Slot = "10")]
	KMBNIKHFJIH OKMNPKFPHFK(HJICKIEKHCB BMCAAIIMEIN, [In] BBDIDLADECH OIGMDCDEKEG);

	[Cpp2IlInjected.Token(Token = "0x60000C7")]
	[Cpp2IlInjected.Address(Slot = "11")]
	MIENFEDMCGN LCAMNNIFFLO(HJICKIEKHCB BMCAAIIMEIN, [In] BBDIDLADECH OIGMDCDEKEG);

	[Cpp2IlInjected.Token(Token = "0x60000C8")]
	[Cpp2IlInjected.Address(Slot = "12")]
	BBNKKAENLJM MIKDLDOCIPJ(HJICKIEKHCB BMCAAIIMEIN, [In] BBDIDLADECH OIGMDCDEKEG);

	[Cpp2IlInjected.Token(Token = "0x60000C9")]
	[Cpp2IlInjected.Address(Slot = "13")]
	MMIDFPGIFAJ DMLKFFHBBGA(HJICKIEKHCB BMCAAIIMEIN, [In] BBDIDLADECH OIGMDCDEKEG);

	[Cpp2IlInjected.Token(Token = "0x60000CA")]
	[Cpp2IlInjected.Address(Slot = "14")]
	PMEFGMFBPKH CBDDKBBOPLG(HJICKIEKHCB BMCAAIIMEIN, [In] BBDIDLADECH OIGMDCDEKEG);

	[Cpp2IlInjected.Token(Token = "0x60000CB")]
	[Cpp2IlInjected.Address(Slot = "15")]
	HJICKIEKHCB OBLJOBJDBCF(RigidbodyEx PPHDEPKLLOK, BBDIDLADECH OIGMDCDEKEG, BNEKFFELJGI CMHMDBNCGCO);
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
public interface HLBPPEDLPKE
{
	[Cpp2IlInjected.Token(Token = "0x60000CC")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void LAANHEMGOCB(Vector3 MOFNDFHCJJC, ForceMode JFFPEBEJOGP = ForceMode.Force);

	[Cpp2IlInjected.Token(Token = "0x60000CD")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void PHKJEADNHIM(Vector3 MOFNDFHCJJC, Vector3 BJDHDJCINFH, ForceMode JFFPEBEJOGP);

	[Cpp2IlInjected.Token(Token = "0x60000CE")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void CECHKGFJLEI(Vector3 LGFOKCMDDNH, ForceMode JFFPEBEJOGP = ForceMode.Force);

	[Cpp2IlInjected.Token(Token = "0x60000CF")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void BJODMGMPAJI(Vector3 LGFOKCMDDNH, ForceMode JFFPEBEJOGP = ForceMode.Force);
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
public interface GHALEEJPMBF
{
	[Cpp2IlInjected.Token(Token = "0x17000039")]
	bool BNJPFDOMFGG
	{
		[Cpp2IlInjected.Token(Token = "0x60000D0")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
		[Cpp2IlInjected.Token(Token = "0x60000D1")]
		[Cpp2IlInjected.Address(Slot = "1")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x60000D2")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void GENJEMJACDM(Rigidbody BBHGIADMCFO);

	[Cpp2IlInjected.Token(Token = "0x60000D3")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void EDMPKHGJJCA(Rigidbody BBHGIADMCFO);
}
[Cpp2IlInjected.Token(Token = "0x200000F")]
public interface KDLCFDJHOCK : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x1700003A")]
	IReadOnlyList<HJICKIEKHCB> KFEIJPJILHE
	{
		[Cpp2IlInjected.Token(Token = "0x60000E6")]
		[Cpp2IlInjected.Address(Slot = "18")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700003B")]
	HJICKIEKHCB AAHAADHCHKF
	{
		[Cpp2IlInjected.Token(Token = "0x60000E7")]
		[Cpp2IlInjected.Address(Slot = "19")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700003C")]
	HJICKIEKHCB GCDGMCMKOIG
	{
		[Cpp2IlInjected.Token(Token = "0x60000E8")]
		[Cpp2IlInjected.Address(Slot = "20")]
		get;
		[Cpp2IlInjected.Token(Token = "0x60000E9")]
		[Cpp2IlInjected.Address(Slot = "21")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x1400000A")]
	event NKPGNCNJBFD IEDGJIENIIM;

	[Cpp2IlInjected.Token(Token = "0x1400000B")]
	event NKPGNCNJBFD PNCCADFDAHC;

	[Cpp2IlInjected.Token(Token = "0x1400000C")]
	event OOHMNMHPFKK EPOBKDBHIGE;

	[Cpp2IlInjected.Token(Token = "0x1400000D")]
	event Action ECMNNFNDHDP;

	[Cpp2IlInjected.Token(Token = "0x1400000E")]
	event Action ONMJAOMCAMP;

	[Cpp2IlInjected.Token(Token = "0x1400000F")]
	event Action<HJICKIEKHCB> DMBPCCPDHCE;

	[Cpp2IlInjected.Token(Token = "0x14000010")]
	event Action<HJICKIEKHCB> LBMNGOMBCHB;

	[Cpp2IlInjected.Token(Token = "0x14000011")]
	event Action EELEEDIMKJJ;

	[Cpp2IlInjected.Token(Token = "0x14000012")]
	event Action<HJICKIEKHCB> PIDIIKIMBMI;

	[Cpp2IlInjected.Token(Token = "0x60000EA")]
	[Cpp2IlInjected.Address(Slot = "22")]
	void FPIHKLEMIHN(HJICKIEKHCB GOOHADCPCIA, bool LHJNJOHGEIJ = false);
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
public interface LJFHHIGODHB
{
	[Cpp2IlInjected.Token(Token = "0x1700003D")]
	Vector3 DEFFNLNMPNO
	{
		[Cpp2IlInjected.Token(Token = "0x60000EB")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700003E")]
	Vector3 KAAHBKEPLBC
	{
		[Cpp2IlInjected.Token(Token = "0x60000EC")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x60000ED")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void DIIIMNGPGAE(HJICKIEKHCB DLPGBMPJIIG, object KLGLJKMNAIM);

	[Cpp2IlInjected.Token(Token = "0x60000EE")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void BNGOCECIKED(object KLGLJKMNAIM);
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
public interface MMIDFPGIFAJ
{
	[Cpp2IlInjected.Token(Token = "0x1700003F")]
	Vector3 KCEKPJILAJA
	{
		[Cpp2IlInjected.Token(Token = "0x60000F1")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
		[Cpp2IlInjected.Token(Token = "0x60000F2")]
		[Cpp2IlInjected.Address(Slot = "3")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000040")]
	Vector3 FPCHOLPNOPI
	{
		[Cpp2IlInjected.Token(Token = "0x60000F3")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000041")]
	float KDHFLDGHHAG
	{
		[Cpp2IlInjected.Token(Token = "0x60000F4")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000042")]
	float MIGGNCCCNIJ
	{
		[Cpp2IlInjected.Token(Token = "0x60000F5")]
		[Cpp2IlInjected.Address(Slot = "6")]
		get;
		[Cpp2IlInjected.Token(Token = "0x60000F6")]
		[Cpp2IlInjected.Address(Slot = "7")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000043")]
	Vector3 BCKABBMCBMI
	{
		[Cpp2IlInjected.Token(Token = "0x60000F7")]
		[Cpp2IlInjected.Address(Slot = "8")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000044")]
	Quaternion POPAGHEFHJP
	{
		[Cpp2IlInjected.Token(Token = "0x60000F8")]
		[Cpp2IlInjected.Address(Slot = "9")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x14000013")]
	event NKPGNCNJBFD FKGDODEHBGP;

	[Cpp2IlInjected.Token(Token = "0x60000F9")]
	[Cpp2IlInjected.Address(Slot = "10")]
	void AEDGDCGJMKG((Quaternion rot, Vector3 moments) FLBDCMBPIHC);

	[Cpp2IlInjected.Token(Token = "0x60000FA")]
	[Cpp2IlInjected.Address(Slot = "11")]
	void NFLANFFNEKE();

	[Cpp2IlInjected.Token(Token = "0x60000FB")]
	[Cpp2IlInjected.Address(Slot = "12")]
	void JILPDFLGOIA();

	[Cpp2IlInjected.Token(Token = "0x60000FC")]
	[Cpp2IlInjected.Address(Slot = "13")]
	void LJDOILDGGFC();

	[Cpp2IlInjected.Token(Token = "0x60000FD")]
	[Cpp2IlInjected.Address(Slot = "14")]
	void GENJEMJACDM(Rigidbody BBHGIADMCFO);

	[Cpp2IlInjected.Token(Token = "0x60000FE")]
	[Cpp2IlInjected.Address(Slot = "15")]
	void EDMPKHGJJCA(Rigidbody BBHGIADMCFO);

	[Cpp2IlInjected.Token(Token = "0x60000FF")]
	[Cpp2IlInjected.Address(Slot = "16")]
	void NLPLHAJCENC();
}
[Cpp2IlInjected.Token(Token = "0x2000012")]
public interface BBNKKAENLJM
{
	[Cpp2IlInjected.Token(Token = "0x6000100")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void IMJENBPCPEE();

	[Cpp2IlInjected.Token(Token = "0x6000101")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void NDHAJAENBKD(object KLGLJKMNAIM);

	[Cpp2IlInjected.Token(Token = "0x6000102")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void LKFEFDPHHJB(object KLGLJKMNAIM);

	[Cpp2IlInjected.Token(Token = "0x6000103")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void EPGEDDMPBIA(HJICKIEKHCB PPHDEPKLLOK);

	[Cpp2IlInjected.Token(Token = "0x6000104")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void LKIGGABLFNN(HJICKIEKHCB PPHDEPKLLOK);

	[Cpp2IlInjected.Token(Token = "0x6000105")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void KNBGDELBMKC();
}
[Cpp2IlInjected.Token(Token = "0x2000013")]
public interface GIPEFGCNFNA
{
	[Cpp2IlInjected.Token(Token = "0x17000045")]
	bool ECACFOIGDLA
	{
		[Cpp2IlInjected.Token(Token = "0x6000108")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x14000014")]
	event NKPGNCNJBFD DNICKMKOHNE;

	[Cpp2IlInjected.Token(Token = "0x6000109")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void EKLHHEPCCKC(object KLGLJKMNAIM);

	[Cpp2IlInjected.Token(Token = "0x600010A")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void OKGNMFPINPB(object KLGLJKMNAIM);

	[Cpp2IlInjected.Token(Token = "0x600010B")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void PIFPFDAHBCB(object KLGLJKMNAIM, bool IMIKPNPKFPA);

	[Cpp2IlInjected.Token(Token = "0x600010C")]
	[Cpp2IlInjected.Address(Slot = "6")]
	void GENJEMJACDM(Rigidbody BHBGFFIGMHB);

	[Cpp2IlInjected.Token(Token = "0x600010D")]
	[Cpp2IlInjected.Address(Slot = "7")]
	void EDMPKHGJJCA(Rigidbody BBHGIADMCFO);
}
[Cpp2IlInjected.Token(Token = "0x2000014")]
public interface MIENFEDMCGN : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x17000046")]
	bool OPJGDKAGBJB
	{
		[Cpp2IlInjected.Token(Token = "0x6000110")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000047")]
	bool HADEFDBIEKJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000111")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x14000015")]
	event NKPGNCNJBFD ODFMBBFOAKF;

	[Cpp2IlInjected.Token(Token = "0x6000112")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void IMJENBPCPEE();

	[Cpp2IlInjected.Token(Token = "0x6000113")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void GBEAELEIDIP(HJICKIEKHCB DLPGBMPJIIG);

	[Cpp2IlInjected.Token(Token = "0x6000114")]
	[Cpp2IlInjected.Address(Slot = "6")]
	void AMPKMLOKOCI(HJICKIEKHCB DLPGBMPJIIG);
}
[Cpp2IlInjected.Token(Token = "0x2000015")]
public interface PMEFGMFBPKH
{
	[Cpp2IlInjected.Token(Token = "0x17000048")]
	bool FMNKECDKHIA
	{
		[Cpp2IlInjected.Token(Token = "0x6000115")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
		[Cpp2IlInjected.Token(Token = "0x6000116")]
		[Cpp2IlInjected.Address(Slot = "1")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000049")]
	bool EIGODHNMFII
	{
		[Cpp2IlInjected.Token(Token = "0x6000117")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700004A")]
	RigidbodyConstraints ENALJCPNLCD
	{
		[Cpp2IlInjected.Token(Token = "0x6000118")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
		[Cpp2IlInjected.Token(Token = "0x6000119")]
		[Cpp2IlInjected.Address(Slot = "4")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x600011A")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void GENJEMJACDM(Rigidbody BBHGIADMCFO);

	[Cpp2IlInjected.Token(Token = "0x600011B")]
	[Cpp2IlInjected.Address(Slot = "6")]
	void EDMPKHGJJCA(Rigidbody BBHGIADMCFO);
}
[Cpp2IlInjected.Token(Token = "0x2000016")]
public interface INLJEOCBMAL
{
	[Cpp2IlInjected.Token(Token = "0x1700004B")]
	float HPHNEEEKANI
	{
		[Cpp2IlInjected.Token(Token = "0x600011C")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
		[Cpp2IlInjected.Token(Token = "0x600011D")]
		[Cpp2IlInjected.Address(Slot = "1")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x1700004C")]
	float EPCMFHDALND
	{
		[Cpp2IlInjected.Token(Token = "0x600011E")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
		[Cpp2IlInjected.Token(Token = "0x600011F")]
		[Cpp2IlInjected.Address(Slot = "3")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x6000120")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void GENJEMJACDM(Rigidbody BBHGIADMCFO);

	[Cpp2IlInjected.Token(Token = "0x6000121")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void EDMPKHGJJCA(Rigidbody BBHGIADMCFO);
}
[Cpp2IlInjected.Token(Token = "0x2000017")]
public interface MAKONEBMAFE
{
	[Cpp2IlInjected.Token(Token = "0x14000016")]
	event NKPGNCNJBFD AJLHECBDMME;

	[Cpp2IlInjected.Token(Token = "0x6000124")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void IMJENBPCPEE();

	[Cpp2IlInjected.Token(Token = "0x6000125")]
	[Cpp2IlInjected.Address(Slot = "3")]
	bool DAGFFDAJHPA();

	[Cpp2IlInjected.Token(Token = "0x6000126")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void OMFLDHEBKBD();

	[Cpp2IlInjected.Token(Token = "0x6000127")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void IEDGDDEBKFI();

	[Cpp2IlInjected.Token(Token = "0x6000128")]
	[Cpp2IlInjected.Address(Slot = "6")]
	void PLJALHCLOGL();

	[Cpp2IlInjected.Token(Token = "0x6000129")]
	[Cpp2IlInjected.Address(Slot = "7")]
	void PADIIMONECN();
}
[Cpp2IlInjected.Token(Token = "0x2000018")]
public interface KMBNIKHFJIH
{
	[Cpp2IlInjected.Token(Token = "0x1700004D")]
	Rigidbody ENJGFFKJICM
	{
		[Cpp2IlInjected.Token(Token = "0x600012A")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700004E")]
	bool JHBDJFOBIOM
	{
		[Cpp2IlInjected.Token(Token = "0x600012C")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x600012B")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void IMJENBPCPEE();

	[Cpp2IlInjected.Token(Token = "0x600012D")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void MIICELNANPB(object KLGLJKMNAIM);

	[Cpp2IlInjected.Token(Token = "0x600012E")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void GIILIPCFCKI(object KLGLJKMNAIM);

	[Cpp2IlInjected.Token(Token = "0x600012F")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void LGNHONJLKNM();
}
[Cpp2IlInjected.Token(Token = "0x2000019")]
public interface LJPNFDLEOFJ : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x1700004F")]
	MOINMCBEJEM ODBJPAPAGHJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000130")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
		[Cpp2IlInjected.Token(Token = "0x6000131")]
		[Cpp2IlInjected.Address(Slot = "1")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000050")]
	BNOGFHPHCAG HCKNGOOJLMN
	{
		[Cpp2IlInjected.Token(Token = "0x6000132")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
		[Cpp2IlInjected.Token(Token = "0x6000133")]
		[Cpp2IlInjected.Address(Slot = "3")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000051")]
	Vector3 FAAJKJFJEPO
	{
		[Cpp2IlInjected.Token(Token = "0x6000134")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
		[Cpp2IlInjected.Token(Token = "0x6000135")]
		[Cpp2IlInjected.Address(Slot = "5")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000052")]
	Vector3 LPFOLNGLBAM
	{
		[Cpp2IlInjected.Token(Token = "0x6000136")]
		[Cpp2IlInjected.Address(Slot = "6")]
		get;
		[Cpp2IlInjected.Token(Token = "0x6000137")]
		[Cpp2IlInjected.Address(Slot = "7")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000053")]
	Vector3 MBFKAFHGKDN
	{
		[Cpp2IlInjected.Token(Token = "0x6000138")]
		[Cpp2IlInjected.Address(Slot = "8")]
		get;
		[Cpp2IlInjected.Token(Token = "0x6000139")]
		[Cpp2IlInjected.Address(Slot = "9")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000054")]
	Vector3 ECIDGPFBLAC
	{
		[Cpp2IlInjected.Token(Token = "0x600013A")]
		[Cpp2IlInjected.Address(Slot = "10")]
		get;
		[Cpp2IlInjected.Token(Token = "0x600013B")]
		[Cpp2IlInjected.Address(Slot = "11")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000055")]
	float ADIOGPKDCDC
	{
		[Cpp2IlInjected.Token(Token = "0x600013C")]
		[Cpp2IlInjected.Address(Slot = "12")]
		get;
		[Cpp2IlInjected.Token(Token = "0x600013D")]
		[Cpp2IlInjected.Address(Slot = "13")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000056")]
	bool MAPNACMJLIJ
	{
		[Cpp2IlInjected.Token(Token = "0x600013E")]
		[Cpp2IlInjected.Address(Slot = "14")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x600013F")]
	[Cpp2IlInjected.Address(Slot = "15")]
	void IMJENBPCPEE();

	[Cpp2IlInjected.Token(Token = "0x6000140")]
	[Cpp2IlInjected.Address(Slot = "16")]
	void COFDPCCFMHM(object KLGLJKMNAIM);

	[Cpp2IlInjected.Token(Token = "0x6000141")]
	[Cpp2IlInjected.Address(Slot = "17")]
	void NFEHHOPLBFI(JENDIECHPBG EDKHDNCHGOP, Vector3 BNLBDJCNEIC, float OBBKOHIDJFD = float.PositiveInfinity);

	[Cpp2IlInjected.Token(Token = "0x6000142")]
	[Cpp2IlInjected.Address(Slot = "18")]
	void IOIBEGCCJIK(HBBOOGIPJMD FFJEGHOFDPM, Vector3 EMGGJFAEADN, float CPAMMGNNLIK, float FANFOKDGIAB = 8f, float CDKGJFKHGOO = 1f);

	[Cpp2IlInjected.Token(Token = "0x6000143")]
	[Cpp2IlInjected.Address(Slot = "19")]
	void DFNDJDNAENI(JENDIECHPBG EDKHDNCHGOP, Vector3 FJFNLINEAKI, float ELILELMDMOP = 7f, float NHPMFBAHPKH = 1f);

	[Cpp2IlInjected.Token(Token = "0x6000144")]
	[Cpp2IlInjected.Address(Slot = "20")]
	void JEBKIEAIHCJ();

	[Cpp2IlInjected.Token(Token = "0x6000145")]
	[Cpp2IlInjected.Address(Slot = "21")]
	void DEPFEIPKFNH();

	[Cpp2IlInjected.Token(Token = "0x6000146")]
	[Cpp2IlInjected.Address(Slot = "22")]
	void OCFNMMFLADB();

	[Cpp2IlInjected.Token(Token = "0x6000147")]
	[Cpp2IlInjected.Address(Slot = "23")]
	void PDDPELNLBLF();

	[Cpp2IlInjected.Token(Token = "0x6000148")]
	[Cpp2IlInjected.Address(Slot = "24")]
	void GENJEMJACDM(Rigidbody BBHGIADMCFO);

	[Cpp2IlInjected.Token(Token = "0x6000149")]
	[Cpp2IlInjected.Address(Slot = "25")]
	Vector3 MDNPJINCMNB(Vector3 NJFMAFAPHLI);

	[Cpp2IlInjected.Token(Token = "0x600014A")]
	[Cpp2IlInjected.Address(Slot = "26")]
	void NMLFPIBCHPM(object KLGLJKMNAIM);

	[Cpp2IlInjected.Token(Token = "0x600014B")]
	[Cpp2IlInjected.Address(Slot = "27")]
	void LFJNIAENKID(Vector3 LFFDCABHEON);

	[Cpp2IlInjected.Token(Token = "0x600014C")]
	[Cpp2IlInjected.Address(Slot = "28")]
	void ELGBIIGBNKJ(Vector3 HPJCGHLPDFH, Vector3 AGNGOBCJFND);

	[Cpp2IlInjected.Token(Token = "0x600014D")]
	[Cpp2IlInjected.Address(Slot = "29")]
	void AJAFIDJFFLO(Vector3 EMGHCEJLGLC, Vector3 KJKLMOGLNDO);

	[Cpp2IlInjected.Token(Token = "0x600014E")]
	[Cpp2IlInjected.Address(Slot = "30")]
	Vector3 LMNMAMIHNPF(Vector3 OHJOFKNMAIN);

	[Cpp2IlInjected.Token(Token = "0x600014F")]
	[Cpp2IlInjected.Address(Slot = "31")]
	Vector3 JHNNDLBNDDF(Vector3 IACJOJBIIMH);
}
[Cpp2IlInjected.Token(Token = "0x200001A")]
[FACHKNACJCC(KCCBMFNNLJD.Application)]
public interface IPLICLCFIHJ
{
	[Cpp2IlInjected.Token(Token = "0x17000057")]
	bool MOHNFIMGKIC
	{
		[Cpp2IlInjected.Token(Token = "0x6000150")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000151")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void ACOBBKBODBP(string DMBOCOKFCJF);

	[Cpp2IlInjected.Token(Token = "0x6000152")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void ICKDFGABCGO(RigidbodyEx PPHDEPKLLOK, Action ENNGIICFMFD);

	[Cpp2IlInjected.Token(Token = "0x6000153")]
	[Cpp2IlInjected.Address(Slot = "3")]
	MKJPKEEDEAC IKECHMJAFGI(int IOBGKKHNNEA);

	[Cpp2IlInjected.Token(Token = "0x6000154")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void KACKOAGHIHH(Vector3 IHLCJMKCNCF, float MDMLKLOLPNE, Color BLBBBKOLGJG);
}
[Cpp2IlInjected.Token(Token = "0x200001B")]
[FACHKNACJCC(KCCBMFNNLJD.Application)]
public interface BNEKFFELJGI
{
	[Cpp2IlInjected.Token(Token = "0x17000058")]
	IPLICLCFIHJ FPIPIFICAFL
	{
		[Cpp2IlInjected.Token(Token = "0x6000155")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000059")]
	MANGKBMACHI JNFAHHIPBCC
	{
		[Cpp2IlInjected.Token(Token = "0x6000156")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000157")]
	[Cpp2IlInjected.Address(Slot = "2")]
	HJICKIEKHCB OBLJOBJDBCF(RigidbodyEx PPHDEPKLLOK, BBDIDLADECH OIGMDCDEKEG);
}
[Cpp2IlInjected.Token(Token = "0x200001C")]
public class PHNJBAMDJFC : HJICKIEKHCB, IDisposable, LIOIBCMNIEO
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000017")]
	internal readonly BNEKFFELJGI CMHMDBNCGCO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000018")]
	internal KDLCFDJHOCK ECOCBLHIEBE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000019")]
	internal BBNKKAENLJM ECMOIFKNHJC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400001A")]
	internal MIENFEDMCGN DJBGCNHEKJN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400001B")]
	internal LJPNFDLEOFJ NJFMAFAPHLI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x400001C")]
	internal LJFHHIGODHB EDHACEFDFBE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x400001D")]
	internal MMIDFPGIFAJ PAEPHEFCNOE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x400001E")]
	internal INLJEOCBMAL BLKHEEKPLIO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x400001F")]
	internal GHALEEJPMBF OACNFMPFAAG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x4000020")]
	internal MAKONEBMAFE BLGCNMMJKAK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x4000021")]
	internal IJLFCEHECEB HJCCBJANPMM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x4000022")]
	internal GIPEFGCNFNA NNAOPIEHJEL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x4000023")]
	internal HLBPPEDLPKE MOFNDFHCJJC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
	[Cpp2IlInjected.Token(Token = "0x4000024")]
	internal PMEFGMFBPKH FFMBEPOMOEA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x4000025")]
	internal KMBNIKHFJIH BBHGIADMCFO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
	[Cpp2IlInjected.Token(Token = "0x4000026")]
	internal EKCNEAFKJAH MMBCKIMFEBB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
	[Cpp2IlInjected.Token(Token = "0x4000027")]
	internal IDisposable ABKANMCHFKH;

	[Cpp2IlInjected.Token(Token = "0x1700005A")]
	public HNLGJNFDBGG HMLBDKHBFAJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000158")]
		[Cpp2IlInjected.Address(RVA = "0x883220", Offset = "0x881C20", VA = "0x180883220", Slot = "22")]
		get
		{
			return default(HNLGJNFDBGG);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700005B")]
	public FJDKJBAPALO LLPIPPFGNIK
	{
		[Cpp2IlInjected.Token(Token = "0x6000159")]
		[Cpp2IlInjected.Address(RVA = "0x88C8E0", Offset = "0x88B2E0", VA = "0x18088C8E0", Slot = "24")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600015A")]
		[Cpp2IlInjected.Address(RVA = "0x88C8C0", Offset = "0x88B2C0", VA = "0x18088C8C0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700005C")]
	public GameObject FIDFGJFJLOA
	{
		[Cpp2IlInjected.Token(Token = "0x600015B")]
		[Cpp2IlInjected.Address(RVA = "0x93A510", Offset = "0x938F10", VA = "0x18093A510", Slot = "25")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600015C")]
		[Cpp2IlInjected.Address(RVA = "0xB7A020", Offset = "0xB78A20", VA = "0x180B7A020")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700005D")]
	public Transform DHHBNJAMIOF
	{
		[Cpp2IlInjected.Token(Token = "0x600015D")]
		[Cpp2IlInjected.Address(RVA = "0x888340", Offset = "0x886D40", VA = "0x180888340", Slot = "26")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600015E")]
		[Cpp2IlInjected.Address(RVA = "0x8882D0", Offset = "0x886CD0", VA = "0x1808882D0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700005E")]
	public Rigidbody ENJGFFKJICM
	{
		[Cpp2IlInjected.Token(Token = "0x600015F")]
		[Cpp2IlInjected.Address(RVA = "0x7221F40", Offset = "0x7220940", VA = "0x187221F40", Slot = "23")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700005F")]
	public HJICKIEKHCB GCDGMCMKOIG
	{
		[Cpp2IlInjected.Token(Token = "0x600016D")]
		[Cpp2IlInjected.Address(RVA = "0x721E900", Offset = "0x721D300", VA = "0x18721E900", Slot = "27")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600016E")]
		[Cpp2IlInjected.Address(RVA = "0x721E5D0", Offset = "0x721CFD0", VA = "0x18721E5D0", Slot = "28")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000060")]
	public int FHEGHFENGAH
	{
		[Cpp2IlInjected.Token(Token = "0x600016F")]
		[Cpp2IlInjected.Address(RVA = "0x7221ED0", Offset = "0x72208D0", VA = "0x187221ED0", Slot = "31")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000061")]
	public HJICKIEKHCB AAHAADHCHKF
	{
		[Cpp2IlInjected.Token(Token = "0x6000171")]
		[Cpp2IlInjected.Address(RVA = "0x7220210", Offset = "0x721EC10", VA = "0x187220210", Slot = "29")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000062")]
	public bool PFBBECKGEAK
	{
		[Cpp2IlInjected.Token(Token = "0x6000172")]
		[Cpp2IlInjected.Address(RVA = "0x721E310", Offset = "0x721CD10", VA = "0x18721E310", Slot = "138")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000063")]
	public bool OPJGDKAGBJB
	{
		[Cpp2IlInjected.Token(Token = "0x6000176")]
		[Cpp2IlInjected.Address(RVA = "0x721D870", Offset = "0x721C270", VA = "0x18721D870", Slot = "32")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000064")]
	public bool HADEFDBIEKJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000177")]
		[Cpp2IlInjected.Address(RVA = "0x721E770", Offset = "0x721D170", VA = "0x18721E770", Slot = "33")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000065")]
	public MOINMCBEJEM ODBJPAPAGHJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000178")]
		[Cpp2IlInjected.Address(RVA = "0x721D030", Offset = "0x721BA30", VA = "0x18721D030", Slot = "34")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000179")]
		[Cpp2IlInjected.Address(RVA = "0x721F230", Offset = "0x721DC30", VA = "0x18721F230", Slot = "35")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000066")]
	public BNOGFHPHCAG HCKNGOOJLMN
	{
		[Cpp2IlInjected.Token(Token = "0x600017A")]
		[Cpp2IlInjected.Address(RVA = "0x721D1A0", Offset = "0x721BBA0", VA = "0x18721D1A0", Slot = "36")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600017B")]
		[Cpp2IlInjected.Address(RVA = "0x721E100", Offset = "0x721CB00", VA = "0x18721E100", Slot = "37")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000067")]
	public float ADIOGPKDCDC
	{
		[Cpp2IlInjected.Token(Token = "0x600017C")]
		[Cpp2IlInjected.Address(RVA = "0x721DCC0", Offset = "0x721C6C0", VA = "0x18721DCC0", Slot = "38")]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x600017D")]
		[Cpp2IlInjected.Address(RVA = "0x721D680", Offset = "0x721C080", VA = "0x18721D680", Slot = "39")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000068")]
	public Vector3 LPFOLNGLBAM
	{
		[Cpp2IlInjected.Token(Token = "0x600017E")]
		[Cpp2IlInjected.Address(RVA = "0x72215A0", Offset = "0x721FFA0", VA = "0x1872215A0", Slot = "40")]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x600017F")]
		[Cpp2IlInjected.Address(RVA = "0x7221FE0", Offset = "0x72209E0", VA = "0x187221FE0", Slot = "41")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000069")]
	public Vector3 ECIDGPFBLAC
	{
		[Cpp2IlInjected.Token(Token = "0x6000180")]
		[Cpp2IlInjected.Address(RVA = "0x721EAA0", Offset = "0x721D4A0", VA = "0x18721EAA0", Slot = "42")]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x6000181")]
		[Cpp2IlInjected.Address(RVA = "0x721F770", Offset = "0x721E170", VA = "0x18721F770", Slot = "43")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700006A")]
	public Vector3 FAAJKJFJEPO
	{
		[Cpp2IlInjected.Token(Token = "0x6000182")]
		[Cpp2IlInjected.Address(RVA = "0x721E430", Offset = "0x721CE30", VA = "0x18721E430", Slot = "44")]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x6000183")]
		[Cpp2IlInjected.Address(RVA = "0x7220130", Offset = "0x721EB30", VA = "0x187220130", Slot = "45")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700006B")]
	public Vector3 MBFKAFHGKDN
	{
		[Cpp2IlInjected.Token(Token = "0x6000184")]
		[Cpp2IlInjected.Address(RVA = "0x721E630", Offset = "0x721D030", VA = "0x18721E630", Slot = "46")]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x6000185")]
		[Cpp2IlInjected.Address(RVA = "0x721D1F0", Offset = "0x721BBF0", VA = "0x18721D1F0", Slot = "47")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700006C")]
	public bool NGIDNAPEOEC
	{
		[Cpp2IlInjected.Token(Token = "0x6000186")]
		[Cpp2IlInjected.Address(RVA = "0x7221CA0", Offset = "0x72206A0", VA = "0x187221CA0", Slot = "139")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700006D")]
	public bool LPDJMMMOHBI
	{
		[Cpp2IlInjected.Token(Token = "0x6000187")]
		[Cpp2IlInjected.Address(RVA = "0x721CC90", Offset = "0x721B690", VA = "0x18721CC90", Slot = "48")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700006E")]
	public bool DJPEMFPPIEO
	{
		[Cpp2IlInjected.Token(Token = "0x6000188")]
		[Cpp2IlInjected.Address(RVA = "0x7221DA0", Offset = "0x72207A0", VA = "0x187221DA0", Slot = "49")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700006F")]
	public bool MAPNACMJLIJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000189")]
		[Cpp2IlInjected.Address(RVA = "0x72205F0", Offset = "0x721EFF0", VA = "0x1872205F0", Slot = "50")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000070")]
	public Vector3 DEFFNLNMPNO
	{
		[Cpp2IlInjected.Token(Token = "0x600019A")]
		[Cpp2IlInjected.Address(RVA = "0x72220C0", Offset = "0x7220AC0", VA = "0x1872220C0", Slot = "51")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000071")]
	public Vector3 KAAHBKEPLBC
	{
		[Cpp2IlInjected.Token(Token = "0x600019B")]
		[Cpp2IlInjected.Address(RVA = "0x721D460", Offset = "0x721BE60", VA = "0x18721D460", Slot = "52")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000072")]
	public Vector3 KCEKPJILAJA
	{
		[Cpp2IlInjected.Token(Token = "0x60001A0")]
		[Cpp2IlInjected.Address(RVA = "0x721D320", Offset = "0x721BD20", VA = "0x18721D320", Slot = "53")]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x60001A1")]
		[Cpp2IlInjected.Address(RVA = "0x721E820", Offset = "0x721D220", VA = "0x18721E820", Slot = "54")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000073")]
	public Vector3 FPCHOLPNOPI
	{
		[Cpp2IlInjected.Token(Token = "0x60001A2")]
		[Cpp2IlInjected.Address(RVA = "0x7220390", Offset = "0x721ED90", VA = "0x187220390", Slot = "55")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000074")]
	public float KDHFLDGHHAG
	{
		[Cpp2IlInjected.Token(Token = "0x60001A3")]
		[Cpp2IlInjected.Address(RVA = "0x721CDE0", Offset = "0x721B7E0", VA = "0x18721CDE0", Slot = "56")]
		get
		{
			return default(float);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000075")]
	public float MIGGNCCCNIJ
	{
		[Cpp2IlInjected.Token(Token = "0x60001A4")]
		[Cpp2IlInjected.Address(RVA = "0x721DC70", Offset = "0x721C670", VA = "0x18721DC70", Slot = "57")]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x60001A5")]
		[Cpp2IlInjected.Address(RVA = "0x721E3D0", Offset = "0x721CDD0", VA = "0x18721E3D0", Slot = "58")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000076")]
	public Vector3 BCKABBMCBMI
	{
		[Cpp2IlInjected.Token(Token = "0x60001A6")]
		[Cpp2IlInjected.Address(RVA = "0x721CAD0", Offset = "0x721B4D0", VA = "0x18721CAD0", Slot = "59")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000077")]
	public Quaternion POPAGHEFHJP
	{
		[Cpp2IlInjected.Token(Token = "0x60001A7")]
		[Cpp2IlInjected.Address(RVA = "0x7222600", Offset = "0x7221000", VA = "0x187222600", Slot = "60")]
		get
		{
			return default(Quaternion);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000078")]
	public float HPHNEEEKANI
	{
		[Cpp2IlInjected.Token(Token = "0x60001AC")]
		[Cpp2IlInjected.Address(RVA = "0x721D2D0", Offset = "0x721BCD0", VA = "0x18721D2D0", Slot = "62")]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x60001AD")]
		[Cpp2IlInjected.Address(RVA = "0x7221680", Offset = "0x7220080", VA = "0x187221680", Slot = "63")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000079")]
	public float EPCMFHDALND
	{
		[Cpp2IlInjected.Token(Token = "0x60001AE")]
		[Cpp2IlInjected.Address(RVA = "0x721F660", Offset = "0x721E060", VA = "0x18721F660", Slot = "64")]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x60001AF")]
		[Cpp2IlInjected.Address(RVA = "0x721E710", Offset = "0x721D110", VA = "0x18721E710", Slot = "65")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700007A")]
	public bool BNJPFDOMFGG
	{
		[Cpp2IlInjected.Token(Token = "0x60001B0")]
		[Cpp2IlInjected.Address(RVA = "0x7220B10", Offset = "0x721F510", VA = "0x187220B10", Slot = "66")]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x60001B1")]
		[Cpp2IlInjected.Address(RVA = "0x721D810", Offset = "0x721C210", VA = "0x18721D810", Slot = "67")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700007B")]
	public NFCFPCIBOBP ILGDOANNLMK
	{
		[Cpp2IlInjected.Token(Token = "0x60001B9")]
		[Cpp2IlInjected.Address(RVA = "0x721DC20", Offset = "0x721C620", VA = "0x18721DC20", Slot = "68")]
		get
		{
			return default(NFCFPCIBOBP);
		}
		[Cpp2IlInjected.Token(Token = "0x60001BA")]
		[Cpp2IlInjected.Address(RVA = "0x721E250", Offset = "0x721CC50", VA = "0x18721E250", Slot = "69")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700007C")]
	public bool ECACFOIGDLA
	{
		[Cpp2IlInjected.Token(Token = "0x60001BD")]
		[Cpp2IlInjected.Address(RVA = "0x7221E80", Offset = "0x7220880", VA = "0x187221E80", Slot = "70")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700007D")]
	public Transform MBHDHJFCPOP
	{
		[Cpp2IlInjected.Token(Token = "0x60001C3")]
		[Cpp2IlInjected.Address(RVA = "0x888340", Offset = "0x886D40", VA = "0x180888340", Slot = "71")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700007E")]
	public Vector3 KACBAACBPPD
	{
		[Cpp2IlInjected.Token(Token = "0x60001C4")]
		[Cpp2IlInjected.Address(RVA = "0x721DFF0", Offset = "0x721C9F0", VA = "0x18721DFF0", Slot = "72")]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x60001C5")]
		[Cpp2IlInjected.Address(RVA = "0x721EFA0", Offset = "0x721D9A0", VA = "0x18721EFA0", Slot = "73")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700007F")]
	public float LKDEHMDCGLA
	{
		[Cpp2IlInjected.Token(Token = "0x60001C6")]
		[Cpp2IlInjected.Address(RVA = "0x7220710", Offset = "0x721F110", VA = "0x187220710", Slot = "74")]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x60001C7")]
		[Cpp2IlInjected.Address(RVA = "0x72211F0", Offset = "0x721FBF0", VA = "0x1872211F0", Slot = "75")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000080")]
	public float NBGFHJOBHBF
	{
		[Cpp2IlInjected.Token(Token = "0x60001C8")]
		[Cpp2IlInjected.Address(RVA = "0x721F2F0", Offset = "0x721DCF0", VA = "0x18721F2F0", Slot = "76")]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x60001C9")]
		[Cpp2IlInjected.Address(RVA = "0x721E950", Offset = "0x721D350", VA = "0x18721E950", Slot = "77")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000081")]
	public Quaternion LEKKDBMJIJL
	{
		[Cpp2IlInjected.Token(Token = "0x60001CA")]
		[Cpp2IlInjected.Address(RVA = "0x7220A10", Offset = "0x721F410", VA = "0x187220A10", Slot = "78")]
		get
		{
			return default(Quaternion);
		}
		[Cpp2IlInjected.Token(Token = "0x60001CB")]
		[Cpp2IlInjected.Address(RVA = "0x72216E0", Offset = "0x72200E0", VA = "0x1872216E0", Slot = "79")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000082")]
	public Vector3 MHEDOFLPKMM
	{
		[Cpp2IlInjected.Token(Token = "0x60001CC")]
		[Cpp2IlInjected.Address(RVA = "0x721D160", Offset = "0x721BB60", VA = "0x18721D160", Slot = "80")]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x60001CD")]
		[Cpp2IlInjected.Address(RVA = "0x7221C60", Offset = "0x7220660", VA = "0x187221C60", Slot = "81")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000083")]
	public Quaternion MGLMKDCNIOB
	{
		[Cpp2IlInjected.Token(Token = "0x60001CE")]
		[Cpp2IlInjected.Address(RVA = "0x721DB30", Offset = "0x721C530", VA = "0x18721DB30", Slot = "82")]
		get
		{
			return default(Quaternion);
		}
		[Cpp2IlInjected.Token(Token = "0x60001CF")]
		[Cpp2IlInjected.Address(RVA = "0x72206E0", Offset = "0x721F0E0", VA = "0x1872206E0", Slot = "83")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000084")]
	public RigidbodyConstraints ENALJCPNLCD
	{
		[Cpp2IlInjected.Token(Token = "0x60001D3")]
		[Cpp2IlInjected.Address(RVA = "0x7220780", Offset = "0x721F180", VA = "0x187220780", Slot = "84")]
		get
		{
			return default(RigidbodyConstraints);
		}
		[Cpp2IlInjected.Token(Token = "0x60001D4")]
		[Cpp2IlInjected.Address(RVA = "0x721F6B0", Offset = "0x721E0B0", VA = "0x18721F6B0", Slot = "85")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000085")]
	public bool FMNKECDKHIA
	{
		[Cpp2IlInjected.Token(Token = "0x60001D5")]
		[Cpp2IlInjected.Address(RVA = "0x721DFA0", Offset = "0x721C9A0", VA = "0x18721DFA0", Slot = "86")]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x60001D6")]
		[Cpp2IlInjected.Address(RVA = "0x721E7C0", Offset = "0x721D1C0", VA = "0x18721E7C0", Slot = "87")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000086")]
	public CollisionDetectionMode MMFMGKDFGGO
	{
		[Cpp2IlInjected.Token(Token = "0x60001DF")]
		[Cpp2IlInjected.Address(RVA = "0x7221260", Offset = "0x721FC60", VA = "0x187221260", Slot = "88")]
		get
		{
			return default(CollisionDetectionMode);
		}
		[Cpp2IlInjected.Token(Token = "0x60001E0")]
		[Cpp2IlInjected.Address(RVA = "0x721CF00", Offset = "0x721B900", VA = "0x18721CF00", Slot = "89")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000087")]
	public bool HCGHFFMIFAI
	{
		[Cpp2IlInjected.Token(Token = "0x60001E2")]
		[Cpp2IlInjected.Address(RVA = "0x72207D0", Offset = "0x721F1D0", VA = "0x1872207D0", Slot = "140")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000088")]
	public bool JKINAMKOAAB
	{
		[Cpp2IlInjected.Token(Token = "0x60001E3")]
		[Cpp2IlInjected.Address(RVA = "0x7220CA0", Offset = "0x721F6A0", VA = "0x187220CA0", Slot = "90")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000017")]
	public event NKPGNCNJBFD IEDGJIENIIM
	{
		[Cpp2IlInjected.Token(Token = "0x6000167")]
		[Cpp2IlInjected.Address(RVA = "0x7221AB0", Offset = "0x72204B0", VA = "0x187221AB0", Slot = "4")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000168")]
		[Cpp2IlInjected.Address(RVA = "0x72217E0", Offset = "0x72201E0", VA = "0x1872217E0", Slot = "5")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000018")]
	public event NKPGNCNJBFD PNCCADFDAHC
	{
		[Cpp2IlInjected.Token(Token = "0x6000169")]
		[Cpp2IlInjected.Address(RVA = "0x721F290", Offset = "0x721DC90", VA = "0x18721F290", Slot = "6")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600016A")]
		[Cpp2IlInjected.Address(RVA = "0x721D400", Offset = "0x721BE00", VA = "0x18721D400", Slot = "7")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000019")]
	public event OOHMNMHPFKK EPOBKDBHIGE
	{
		[Cpp2IlInjected.Token(Token = "0x600016B")]
		[Cpp2IlInjected.Address(RVA = "0x721E370", Offset = "0x721CD70", VA = "0x18721E370", Slot = "18")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600016C")]
		[Cpp2IlInjected.Address(RVA = "0x721E570", Offset = "0x721CF70", VA = "0x18721E570", Slot = "19")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400001A")]
	public event NKPGNCNJBFD ODFMBBFOAKF
	{
		[Cpp2IlInjected.Token(Token = "0x6000174")]
		[Cpp2IlInjected.Address(RVA = "0x7221D40", Offset = "0x7220740", VA = "0x187221D40", Slot = "8")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000175")]
		[Cpp2IlInjected.Address(RVA = "0x721D970", Offset = "0x721C370", VA = "0x18721D970", Slot = "9")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400001B")]
	public event NKPGNCNJBFD KKPBBMAJJGO
	{
		[Cpp2IlInjected.Token(Token = "0x600019E")]
		[Cpp2IlInjected.Address(RVA = "0x7220C40", Offset = "0x721F640", VA = "0x187220C40", Slot = "14")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600019F")]
		[Cpp2IlInjected.Address(RVA = "0x721D620", Offset = "0x721C020", VA = "0x18721D620", Slot = "15")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400001C")]
	public event NKPGNCNJBFD AJLHECBDMME
	{
		[Cpp2IlInjected.Token(Token = "0x60001B2")]
		[Cpp2IlInjected.Address(RVA = "0x72219A0", Offset = "0x72203A0", VA = "0x1872219A0", Slot = "16")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60001B3")]
		[Cpp2IlInjected.Address(RVA = "0x721E510", Offset = "0x721CF10", VA = "0x18721E510", Slot = "17")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400001D")]
	public event Action<JNKKEIFENFB, JNKKEIFENFB> AEJNOMLLHBM
	{
		[Cpp2IlInjected.Token(Token = "0x60001B7")]
		[Cpp2IlInjected.Address(RVA = "0x721D910", Offset = "0x721C310", VA = "0x18721D910", Slot = "20")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60001B8")]
		[Cpp2IlInjected.Address(RVA = "0x721F710", Offset = "0x721E110", VA = "0x18721F710", Slot = "21")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400001E")]
	public event NKPGNCNJBFD DNICKMKOHNE
	{
		[Cpp2IlInjected.Token(Token = "0x60001BB")]
		[Cpp2IlInjected.Address(RVA = "0x7220AB0", Offset = "0x721F4B0", VA = "0x187220AB0", Slot = "12")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60001BC")]
		[Cpp2IlInjected.Address(RVA = "0x721ED50", Offset = "0x721D750", VA = "0x18721ED50", Slot = "13")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400001F")]
	public event NKPGNCNJBFD NBIFIJICLGO
	{
		[Cpp2IlInjected.Token(Token = "0x60001C1")]
		[Cpp2IlInjected.Address(RVA = "0x72226D0", Offset = "0x72210D0", VA = "0x1872226D0", Slot = "10")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60001C2")]
		[Cpp2IlInjected.Address(RVA = "0x7221A00", Offset = "0x7220400", VA = "0x187221A00", Slot = "11")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000160")]
	[Cpp2IlInjected.Address(RVA = "0x7222940", Offset = "0x7221340", VA = "0x187222940")]
	public PHNJBAMDJFC(GameObject EABKFLBGOGN, RigidbodyEx LJGJEDKOKIP, BNEKFFELJGI CMHMDBNCGCO, [In] BBDIDLADECH OIGMDCDEKEG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000161")]
	[Cpp2IlInjected.Address(RVA = "0x7220E20", Offset = "0x721F820", VA = "0x187220E20", Slot = "136")]
	protected virtual void LFHMIFLOBFE(BNEKFFELJGI CMHMDBNCGCO, BBDIDLADECH OIGMDCDEKEG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000162")]
	[Cpp2IlInjected.Address(RVA = "0x721DD10", Offset = "0x721C710", VA = "0x18721DD10", Slot = "137")]
	public virtual void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000163")]
	[Cpp2IlInjected.Address(RVA = "0x721FC10", Offset = "0x721E610", VA = "0x18721FC10", Slot = "91")]
	public void IMJENBPCPEE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000164")]
	[Cpp2IlInjected.Address(RVA = "0x721D7C0", Offset = "0x721C1C0", VA = "0x18721D7C0", Slot = "92")]
	public void CIPKIFJBFLJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000165")]
	[Cpp2IlInjected.Address(RVA = "0x72217C0", Offset = "0x72201C0", VA = "0x1872217C0", Slot = "93")]
	public void MDKDIMOAJHH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000166")]
	[Cpp2IlInjected.Address(RVA = "0x72202B0", Offset = "0x721ECB0", VA = "0x1872202B0")]
	private void JFBBDMFFMMB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000170")]
	[Cpp2IlInjected.Address(RVA = "0x7220570", Offset = "0x721EF70", VA = "0x187220570", Slot = "30")]
	public HJICKIEKHCB JIBDJHPGHGL(int EBDDHAPIAHH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000173")]
	[Cpp2IlInjected.Address(RVA = "0x721EA30", Offset = "0x721D430", VA = "0x18721EA30", Slot = "95")]
	public void FPIHKLEMIHN(HJICKIEKHCB CLMKDBDPNNH, bool LHJNJOHGEIJ = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600018A")]
	[Cpp2IlInjected.Address(RVA = "0x7220330", Offset = "0x721ED30", VA = "0x187220330", Slot = "96")]
	public void JFLCHOFPOKB(object KLGLJKMNAIM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600018B")]
	[Cpp2IlInjected.Address(RVA = "0x72212B0", Offset = "0x721FCB0", VA = "0x1872212B0", Slot = "97")]
	public void LHDFADACBMI(object KLGLJKMNAIM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600018C")]
	[Cpp2IlInjected.Address(RVA = "0x7220470", Offset = "0x721EE70", VA = "0x187220470", Slot = "98")]
	public Vector3 JHNNDLBNDDF(Vector3 IACJOJBIIMH)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x600018D")]
	[Cpp2IlInjected.Address(RVA = "0x72214A0", Offset = "0x721FEA0", VA = "0x1872214A0", Slot = "99")]
	public Vector3 LMNMAMIHNPF(Vector3 OHJOFKNMAIN)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x600018E")]
	[Cpp2IlInjected.Address(RVA = "0x721D7C0", Offset = "0x721C1C0", VA = "0x18721D7C0", Slot = "100")]
	public void PDDPELNLBLF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600018F")]
	[Cpp2IlInjected.Address(RVA = "0x721D9D0", Offset = "0x721C3D0", VA = "0x18721D9D0", Slot = "101")]
	public void DEPFEIPKFNH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000190")]
	[Cpp2IlInjected.Address(RVA = "0x7220260", Offset = "0x721EC60", VA = "0x187220260", Slot = "102")]
	public void JEBKIEAIHCJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000191")]
	[Cpp2IlInjected.Address(RVA = "0x721CCF0", Offset = "0x721B6F0", VA = "0x18721CCF0", Slot = "103")]
	public void AJAFIDJFFLO(Vector3 EMGHCEJLGLC, Vector3 KJKLMOGLNDO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000192")]
	[Cpp2IlInjected.Address(RVA = "0x721E160", Offset = "0x721CB60", VA = "0x18721E160", Slot = "104")]
	public void ELGBIIGBNKJ(Vector3 HPJCGHLPDFH, Vector3 AGNGOBCJFND)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000193")]
	[Cpp2IlInjected.Address(RVA = "0x7221110", Offset = "0x721FB10", VA = "0x187221110", Slot = "105")]
	public void LFJNIAENKID(Vector3 LFFDCABHEON)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000194")]
	[Cpp2IlInjected.Address(RVA = "0x721FD50", Offset = "0x721E750", VA = "0x18721FD50", Slot = "106")]
	public void IOIBEGCCJIK(HBBOOGIPJMD FFJEGHOFDPM, Vector3 EMGGJFAEADN, float CPAMMGNNLIK, float FANFOKDGIAB = 8f, float CDKGJFKHGOO = 1f)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000195")]
	[Cpp2IlInjected.Address(RVA = "0x7221B10", Offset = "0x7220510", VA = "0x187221B10", Slot = "107")]
	public void NFEHHOPLBFI(JENDIECHPBG EDKHDNCHGOP, Vector3 BNLBDJCNEIC, float OBBKOHIDJFD = float.PositiveInfinity)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000196")]
	[Cpp2IlInjected.Address(RVA = "0x721DA20", Offset = "0x721C420", VA = "0x18721DA20", Slot = "108")]
	[Obsolete("Deprecated. Still exists to support deprecated CV2 chips. Use ApplyAngularVelocityChange.")]
	public void DFNDJDNAENI(JENDIECHPBG EDKHDNCHGOP, Vector3 FJFNLINEAKI, float ELILELMDMOP = 7f, float NHPMFBAHPKH = 1f)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000197")]
	[Cpp2IlInjected.Address(RVA = "0x7221840", Offset = "0x7220240", VA = "0x187221840", Slot = "109")]
	public Vector3 MDNPJINCMNB(Vector3 CLMKDBDPNNH)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000198")]
	[Cpp2IlInjected.Address(RVA = "0x721EC50", Offset = "0x721D650", VA = "0x18721EC50", Slot = "110")]
	public Vector3 GEOJDKKDNBE(Vector3 CLMKDBDPNNH)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000199")]
	[Cpp2IlInjected.Address(RVA = "0x7221F90", Offset = "0x7220990", VA = "0x187221F90", Slot = "111")]
	public void OCFNMMFLADB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600019C")]
	[Cpp2IlInjected.Address(RVA = "0x721CF60", Offset = "0x721B960", VA = "0x18721CF60", Slot = "112")]
	public void APDICGGOONA(HJICKIEKHCB FHNLPGNOJOF, object KLGLJKMNAIM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600019D")]
	[Cpp2IlInjected.Address(RVA = "0x7220720", Offset = "0x721F120", VA = "0x187220720", Slot = "113")]
	public void JMLHMFGHOHO(object KLGLJKMNAIM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001A8")]
	[Cpp2IlInjected.Address(RVA = "0x721CBB0", Offset = "0x721B5B0", VA = "0x18721CBB0", Slot = "61")]
	public void AEDGDCGJMKG((Quaternion rot, Vector3 moments) FLBDCMBPIHC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001A9")]
	[Cpp2IlInjected.Address(RVA = "0x7220640", Offset = "0x721F040", VA = "0x187220640", Slot = "114")]
	public void JILPDFLGOIA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001AA")]
	[Cpp2IlInjected.Address(RVA = "0x7221C10", Offset = "0x7220610", VA = "0x187221C10", Slot = "115")]
	public void NFLANFFNEKE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001AB")]
	[Cpp2IlInjected.Address(RVA = "0x7221450", Offset = "0x721FE50", VA = "0x187221450", Slot = "116")]
	public void LJDOILDGGFC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001B4")]
	[Cpp2IlInjected.Address(RVA = "0x721D8C0", Offset = "0x721C2C0", VA = "0x18721D8C0", Slot = "117")]
	public bool DAGFFDAJHPA()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001B5")]
	[Cpp2IlInjected.Address(RVA = "0x721F850", Offset = "0x721E250", VA = "0x18721F850", Slot = "94")]
	public void IEDGDDEBKFI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001B6")]
	[Cpp2IlInjected.Address(RVA = "0x72225B0", Offset = "0x7220FB0", VA = "0x1872225B0", Slot = "118")]
	public void PADIIMONECN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001BE")]
	[Cpp2IlInjected.Address(RVA = "0x721E0A0", Offset = "0x721CAA0", VA = "0x18721E0A0", Slot = "119")]
	public void EKLHHEPCCKC(object KLGLJKMNAIM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001BF")]
	[Cpp2IlInjected.Address(RVA = "0x7222190", Offset = "0x7220B90", VA = "0x187222190", Slot = "120")]
	public void OKGNMFPINPB(object KLGLJKMNAIM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001C0")]
	[Cpp2IlInjected.Address(RVA = "0x7222890", Offset = "0x7221290", VA = "0x187222890", Slot = "121")]
	public void PIFPFDAHBCB(object KLGLJKMNAIM, bool IMIKPNPKFPA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001D0")]
	[Cpp2IlInjected.Address(RVA = "0x721F460", Offset = "0x721DE60", VA = "0x18721F460", Slot = "122")]
	public void HLFGHGFJBHK(Vector3 ILNFMJCEOCO, Quaternion LDGNMLEDOMN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001D1")]
	[Cpp2IlInjected.Address(RVA = "0x7221310", Offset = "0x721FD10", VA = "0x187221310", Slot = "123")]
	public void LHLGGAMELBI(Vector3 PEEBPBGNOFG, Quaternion BLGCEGNAMEE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001D2")]
	[Cpp2IlInjected.Address(RVA = "0x7220690", Offset = "0x721F090", VA = "0x187220690", Slot = "124")]
	public bool JKJDBLPFKHK(float EHGIEAAFJMP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001D7")]
	[Cpp2IlInjected.Address(RVA = "0x721CFD0", Offset = "0x721B9D0", VA = "0x18721CFD0", Slot = "125")]
	public void BCMOECEMPCD(object KLGLJKMNAIM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001D8")]
	[Cpp2IlInjected.Address(RVA = "0x721E2B0", Offset = "0x721CCB0", VA = "0x18721E2B0", Slot = "126")]
	public void FAKHJILNJKI(object KLGLJKMNAIM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001D9")]
	[Cpp2IlInjected.Address(RVA = "0x7221940", Offset = "0x7220340", VA = "0x187221940", Slot = "127")]
	public void MIICELNANPB(object KLGLJKMNAIM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001DA")]
	[Cpp2IlInjected.Address(RVA = "0x721F1D0", Offset = "0x721DBD0", VA = "0x18721F1D0", Slot = "128")]
	public void GIILIPCFCKI(object KLGLJKMNAIM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001DB")]
	[Cpp2IlInjected.Address(RVA = "0x7220B60", Offset = "0x721F560", VA = "0x187220B60", Slot = "129")]
	public void LAANHEMGOCB(Vector3 MOFNDFHCJJC, ForceMode JFFPEBEJOGP = ForceMode.Force)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001DC")]
	[Cpp2IlInjected.Address(RVA = "0x7222780", Offset = "0x7221180", VA = "0x187222780", Slot = "130")]
	public void PHKJEADNHIM(Vector3 MOFNDFHCJJC, Vector3 BJDHDJCINFH, ForceMode JFFPEBEJOGP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001DD")]
	[Cpp2IlInjected.Address(RVA = "0x721D540", Offset = "0x721BF40", VA = "0x18721D540", Slot = "131")]
	public void CECHKGFJLEI(Vector3 LGFOKCMDDNH, ForceMode JFFPEBEJOGP = ForceMode.Force)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001DE")]
	[Cpp2IlInjected.Address(RVA = "0x721D080", Offset = "0x721BA80", VA = "0x18721D080", Slot = "132")]
	public void BJODMGMPAJI(Vector3 LGFOKCMDDNH, ForceMode JFFPEBEJOGP = ForceMode.Force)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001E1")]
	[Cpp2IlInjected.Address(RVA = "0x7220910", Offset = "0x721F310", VA = "0x187220910", Slot = "133")]
	public bool KELNKHMGIFP(Vector3 IMGPFEFAFKM, [Out] RaycastHit OEEPALGMIPF, float NGBAMCDGGDI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001E4")]
	[Cpp2IlInjected.Address(RVA = "0x7221CF0", Offset = "0x72206F0", VA = "0x187221CF0", Slot = "134")]
	public void NLPLHAJCENC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001E5")]
	[Cpp2IlInjected.Address(RVA = "0x7222900", Offset = "0x7221300", VA = "0x187222900", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001E6")]
	[Cpp2IlInjected.Address(RVA = "0x721D6E0", Offset = "0x721C0E0", VA = "0x18721D6E0")]
	private void CGMHJCILBLP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001E7")]
	[Cpp2IlInjected.Address(RVA = "0x721C9C0", Offset = "0x721B3C0", VA = "0x18721C9C0")]
	private void AAGDAACLLEI(HJICKIEKHCB DLPGBMPJIIG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001E8")]
	[Cpp2IlInjected.Address(RVA = "0x721EDB0", Offset = "0x721D7B0", VA = "0x18721EDB0")]
	private void GFKPBBCINEN(HJICKIEKHCB DLPGBMPJIIG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001E9")]
	[Cpp2IlInjected.Address(RVA = "0x721DB70", Offset = "0x721C570", VA = "0x18721DB70")]
	private void DIPMBGAJFOJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001EA")]
	[Cpp2IlInjected.Address(RVA = "0x721DDE0", Offset = "0x721C7E0", VA = "0x18721DDE0")]
	private void EAANKJAGIPJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001EB")]
	[Cpp2IlInjected.Address(RVA = "0x721F050", Offset = "0x721DA50", VA = "0x18721F050")]
	private void GIGDKAEBALH(HJICKIEKHCB IGEBDKLCICC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001EC")]
	[Cpp2IlInjected.Address(RVA = "0x721EB80", Offset = "0x721D580", VA = "0x18721EB80")]
	private void GBEAELEIDIP(HJICKIEKHCB DLPGBMPJIIG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001ED")]
	[Cpp2IlInjected.Address(RVA = "0x721CE30", Offset = "0x721B830", VA = "0x18721CE30")]
	private void AMPKMLOKOCI(HJICKIEKHCB DLPGBMPJIIG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001EE")]
	[Cpp2IlInjected.Address(RVA = "0x721F300", Offset = "0x721DD00", VA = "0x18721F300")]
	private void HBOEAEOGONI(FJDKJBAPALO DLPGBMPJIIG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001EF")]
	[Cpp2IlInjected.Address(RVA = "0x72221F0", Offset = "0x7220BF0", VA = "0x1872221F0", Slot = "141")]
	protected virtual void OPADGBJBNMG(FJDKJBAPALO PPHDEPKLLOK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001F0")]
	[Cpp2IlInjected.Address(RVA = "0x721FE10", Offset = "0x721E810", VA = "0x18721FE10")]
	protected void IOOIGHNEFHF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001F1")]
	[Cpp2IlInjected.Address(RVA = "0x721F8A0", Offset = "0x721E2A0", VA = "0x18721F8A0")]
	protected void IKIOKKPLLNA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001F2")]
	[Cpp2IlInjected.Address(RVA = "0x721DEE0", Offset = "0x721C8E0", VA = "0x18721DEE0", Slot = "142")]
	protected virtual IDisposable ECKFHAALIMC()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200001D")]
internal static class ONKBJMKFEOK
{
	[Cpp2IlInjected.Token(Token = "0x60001F3")]
	[Cpp2IlInjected.Address(RVA = "0x721B5D0", Offset = "0x7219FD0", VA = "0x18721B5D0")]
	public static HJICKIEKHCB LNLEJDLNOEO(this HJICKIEKHCB PPHDEPKLLOK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001F4")]
	[Cpp2IlInjected.Address(RVA = "0x721B550", Offset = "0x7219F50", VA = "0x18721B550")]
	public static bool LCKLOENKDOG(this HJICKIEKHCB PPHDEPKLLOK, HJICKIEKHCB IBBAAMOKGCI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001F5")]
	[Cpp2IlInjected.Address(RVA = "0x721B710", Offset = "0x721A110", VA = "0x18721B710")]
	public static bool NNKLOHKJJJK(this HJICKIEKHCB PPHDEPKLLOK, HJICKIEKHCB OBIMHFIMJFE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001F6")]
	[Cpp2IlInjected.Address(RVA = "0x721B500", Offset = "0x7219F00", VA = "0x18721B500")]
	public static FJDKJBAPALO JHJJLJODPME(this HJICKIEKHCB BMCAAIIMEIN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001F7")]
	[Cpp2IlInjected.Address(RVA = "0x721B690", Offset = "0x721A090", VA = "0x18721B690")]
	public static PHNJBAMDJFC NMCFCDOBGGF(this HJICKIEKHCB BMCAAIIMEIN)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200001E")]
public class JGJIHLOFDBN : MANGKBMACHI
{
	[Cpp2IlInjected.Token(Token = "0x60001F8")]
	[Cpp2IlInjected.Address(RVA = "0x7210690", Offset = "0x720F090", VA = "0x187210690", Slot = "19")]
	public HJICKIEKHCB OBLJOBJDBCF(RigidbodyEx PPHDEPKLLOK, BBDIDLADECH OIGMDCDEKEG, BNEKFFELJGI CMHMDBNCGCO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001F9")]
	[Cpp2IlInjected.Address(RVA = "0x883220", Offset = "0x881C20", VA = "0x180883220", Slot = "4")]
	public KDLCFDJHOCK NCDAEDPHLNE(HJICKIEKHCB BMCAAIIMEIN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001FA")]
	[Cpp2IlInjected.Address(RVA = "0x883220", Offset = "0x881C20", VA = "0x180883220", Slot = "5")]
	public LJPNFDLEOFJ KOEEMIHEAAK(HJICKIEKHCB BMCAAIIMEIN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001FB")]
	[Cpp2IlInjected.Address(RVA = "0x883220", Offset = "0x881C20", VA = "0x180883220", Slot = "6")]
	public LJFHHIGODHB GDBAFLBNLFA(HJICKIEKHCB BMCAAIIMEIN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001FC")]
	[Cpp2IlInjected.Address(RVA = "0x883220", Offset = "0x881C20", VA = "0x180883220", Slot = "7")]
	public INLJEOCBMAL IGCENJABKPM(HJICKIEKHCB BMCAAIIMEIN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001FD")]
	[Cpp2IlInjected.Address(RVA = "0x883220", Offset = "0x881C20", VA = "0x180883220", Slot = "8")]
	public MAKONEBMAFE ENKHCBIPNEF(HJICKIEKHCB BMCAAIIMEIN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001FE")]
	[Cpp2IlInjected.Address(RVA = "0x883220", Offset = "0x881C20", VA = "0x180883220", Slot = "9")]
	public IJLFCEHECEB AJIJBPHNKJG(HJICKIEKHCB BMCAAIIMEIN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001FF")]
	[Cpp2IlInjected.Address(RVA = "0x883220", Offset = "0x881C20", VA = "0x180883220", Slot = "10")]
	public GIPEFGCNFNA BBKHGLMFDAI(HJICKIEKHCB BMCAAIIMEIN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000200")]
	[Cpp2IlInjected.Address(RVA = "0x883220", Offset = "0x881C20", VA = "0x180883220", Slot = "11")]
	public HLBPPEDLPKE MFNMGKPODKP(HJICKIEKHCB BMCAAIIMEIN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000201")]
	[Cpp2IlInjected.Address(RVA = "0x883220", Offset = "0x881C20", VA = "0x180883220", Slot = "12")]
	public EKCNEAFKJAH MMJAJGALNDA(HJICKIEKHCB BMCAAIIMEIN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000202")]
	[Cpp2IlInjected.Address(RVA = "0x883220", Offset = "0x881C20", VA = "0x180883220", Slot = "13")]
	public GHALEEJPMBF GBMJBKOBCBG(HJICKIEKHCB BMCAAIIMEIN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000203")]
	[Cpp2IlInjected.Address(RVA = "0x883220", Offset = "0x881C20", VA = "0x180883220")]
	public KMBNIKHFJIH OKMNPKFPHFK(HJICKIEKHCB BMCAAIIMEIN, [In] BBDIDLADECH OIGMDCDEKEG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000204")]
	[Cpp2IlInjected.Address(RVA = "0x883220", Offset = "0x881C20", VA = "0x180883220")]
	public MIENFEDMCGN LCAMNNIFFLO(HJICKIEKHCB BMCAAIIMEIN, [In] BBDIDLADECH OIGMDCDEKEG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000205")]
	[Cpp2IlInjected.Address(RVA = "0x883220", Offset = "0x881C20", VA = "0x180883220")]
	public BBNKKAENLJM MIKDLDOCIPJ(HJICKIEKHCB BMCAAIIMEIN, [In] BBDIDLADECH OIGMDCDEKEG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000206")]
	[Cpp2IlInjected.Address(RVA = "0x883220", Offset = "0x881C20", VA = "0x180883220")]
	public MMIDFPGIFAJ DMLKFFHBBGA(HJICKIEKHCB BMCAAIIMEIN, [In] BBDIDLADECH OIGMDCDEKEG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000207")]
	[Cpp2IlInjected.Address(RVA = "0x883220", Offset = "0x881C20", VA = "0x180883220")]
	public PMEFGMFBPKH CBDDKBBOPLG(HJICKIEKHCB BMCAAIIMEIN, [In] BBDIDLADECH OIGMDCDEKEG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000208")]
	[Cpp2IlInjected.Address(RVA = "0x883870", Offset = "0x882270", VA = "0x180883870")]
	public JGJIHLOFDBN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000209")]
	[Cpp2IlInjected.Address(RVA = "0x883220", Offset = "0x881C20", VA = "0x180883220", Slot = "14")]
	private KMBNIKHFJIH BBPKKLIFKFL(HJICKIEKHCB BMCAAIIMEIN, [In] BBDIDLADECH OIGMDCDEKEG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600020A")]
	[Cpp2IlInjected.Address(RVA = "0x883220", Offset = "0x881C20", VA = "0x180883220", Slot = "15")]
	private MIENFEDMCGN JFOHJLMKACP(HJICKIEKHCB BMCAAIIMEIN, [In] BBDIDLADECH OIGMDCDEKEG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600020B")]
	[Cpp2IlInjected.Address(RVA = "0x883220", Offset = "0x881C20", VA = "0x180883220", Slot = "16")]
	private BBNKKAENLJM KNACIAHAACA(HJICKIEKHCB BMCAAIIMEIN, [In] BBDIDLADECH OIGMDCDEKEG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600020C")]
	[Cpp2IlInjected.Address(RVA = "0x883220", Offset = "0x881C20", VA = "0x180883220", Slot = "17")]
	private MMIDFPGIFAJ ELCOGBDPLCE(HJICKIEKHCB BMCAAIIMEIN, [In] BBDIDLADECH OIGMDCDEKEG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600020D")]
	[Cpp2IlInjected.Address(RVA = "0x883220", Offset = "0x881C20", VA = "0x180883220", Slot = "18")]
	private PMEFGMFBPKH EIBIOONADJN(HJICKIEKHCB BMCAAIIMEIN, [In] BBDIDLADECH OIGMDCDEKEG)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200001F")]
[DCFNIFAPBBP(typeof(MANGKBMACHI), new string[] { })]
public class EAJEDPDKCEI : MANGKBMACHI, BINHHNGJBOP
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400002C")]
	private readonly MANGKBMACHI MLNJEIKAJDJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400002D")]
	private readonly MANGKBMACHI FHIPHDJBKEC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400002E")]
	private BOBFKIFHEGL KCJPACILNMJ;

	[Cpp2IlInjected.Token(Token = "0x17000089")]
	private MANGKBMACHI JNFAHHIPBCC
	{
		[Cpp2IlInjected.Token(Token = "0x600020F")]
		[Cpp2IlInjected.Address(RVA = "0x720E940", Offset = "0x720D340", VA = "0x18720E940")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600020E")]
	[Cpp2IlInjected.Address(RVA = "0x720EA40", Offset = "0x720D440", VA = "0x18720EA40", Slot = "20")]
	public void InitReferences(KFBOEJEEJNO NOGJIGADMKJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000210")]
	[Cpp2IlInjected.Address(RVA = "0x720EDD0", Offset = "0x720D7D0", VA = "0x18720EDD0", Slot = "4")]
	public KDLCFDJHOCK NCDAEDPHLNE(HJICKIEKHCB BMCAAIIMEIN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000211")]
	[Cpp2IlInjected.Address(RVA = "0x720EBF0", Offset = "0x720D5F0", VA = "0x18720EBF0", Slot = "5")]
	public LJPNFDLEOFJ KOEEMIHEAAK(HJICKIEKHCB BMCAAIIMEIN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000212")]
	[Cpp2IlInjected.Address(RVA = "0x720E8A0", Offset = "0x720D2A0", VA = "0x18720E8A0", Slot = "6")]
	public LJFHHIGODHB GDBAFLBNLFA(HJICKIEKHCB BMCAAIIMEIN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000213")]
	[Cpp2IlInjected.Address(RVA = "0x720E9A0", Offset = "0x720D3A0", VA = "0x18720E9A0", Slot = "7")]
	public INLJEOCBMAL IGCENJABKPM(HJICKIEKHCB BMCAAIIMEIN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000214")]
	[Cpp2IlInjected.Address(RVA = "0x720E760", Offset = "0x720D160", VA = "0x18720E760", Slot = "8")]
	public MAKONEBMAFE ENKHCBIPNEF(HJICKIEKHCB BMCAAIIMEIN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000215")]
	[Cpp2IlInjected.Address(RVA = "0x720E410", Offset = "0x720CE10", VA = "0x18720E410", Slot = "9")]
	public IJLFCEHECEB AJIJBPHNKJG(HJICKIEKHCB BMCAAIIMEIN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000216")]
	[Cpp2IlInjected.Address(RVA = "0x720E4B0", Offset = "0x720CEB0", VA = "0x18720E4B0", Slot = "10")]
	public GIPEFGCNFNA BBKHGLMFDAI(HJICKIEKHCB BMCAAIIMEIN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000217")]
	[Cpp2IlInjected.Address(RVA = "0x720EC90", Offset = "0x720D690", VA = "0x18720EC90", Slot = "11")]
	public HLBPPEDLPKE MFNMGKPODKP(HJICKIEKHCB BMCAAIIMEIN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000218")]
	[Cpp2IlInjected.Address(RVA = "0x720ED30", Offset = "0x720D730", VA = "0x18720ED30", Slot = "12")]
	public EKCNEAFKJAH MMJAJGALNDA(HJICKIEKHCB BMCAAIIMEIN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000219")]
	[Cpp2IlInjected.Address(RVA = "0x720E800", Offset = "0x720D200", VA = "0x18720E800", Slot = "13")]
	public GHALEEJPMBF GBMJBKOBCBG(HJICKIEKHCB BMCAAIIMEIN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600021A")]
	[Cpp2IlInjected.Address(RVA = "0x720E550", Offset = "0x720CF50", VA = "0x18720E550")]
	public KMBNIKHFJIH OKMNPKFPHFK(HJICKIEKHCB BMCAAIIMEIN, [In] BBDIDLADECH OIGMDCDEKEG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600021B")]
	[Cpp2IlInjected.Address(RVA = "0x720EA90", Offset = "0x720D490", VA = "0x18720EA90")]
	public MIENFEDMCGN LCAMNNIFFLO(HJICKIEKHCB BMCAAIIMEIN, [In] BBDIDLADECH OIGMDCDEKEG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600021C")]
	[Cpp2IlInjected.Address(RVA = "0x720EB40", Offset = "0x720D540", VA = "0x18720EB40")]
	public BBNKKAENLJM MIKDLDOCIPJ(HJICKIEKHCB BMCAAIIMEIN, [In] BBDIDLADECH OIGMDCDEKEG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600021D")]
	[Cpp2IlInjected.Address(RVA = "0x720E6B0", Offset = "0x720D0B0", VA = "0x18720E6B0")]
	public MMIDFPGIFAJ DMLKFFHBBGA(HJICKIEKHCB BMCAAIIMEIN, [In] BBDIDLADECH OIGMDCDEKEG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600021E")]
	[Cpp2IlInjected.Address(RVA = "0x720E600", Offset = "0x720D000", VA = "0x18720E600")]
	public PMEFGMFBPKH CBDDKBBOPLG(HJICKIEKHCB BMCAAIIMEIN, [In] BBDIDLADECH OIGMDCDEKEG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600021F")]
	[Cpp2IlInjected.Address(RVA = "0x720EE70", Offset = "0x720D870", VA = "0x18720EE70", Slot = "19")]
	public HJICKIEKHCB OBLJOBJDBCF(RigidbodyEx PPHDEPKLLOK, BBDIDLADECH OIGMDCDEKEG, BNEKFFELJGI CMHMDBNCGCO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000220")]
	[Cpp2IlInjected.Address(RVA = "0x720EFC0", Offset = "0x720D9C0", VA = "0x18720EFC0")]
	public EAJEDPDKCEI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000221")]
	[Cpp2IlInjected.Address(RVA = "0x720E550", Offset = "0x720CF50", VA = "0x18720E550", Slot = "14")]
	private KMBNIKHFJIH BBPKKLIFKFL(HJICKIEKHCB BMCAAIIMEIN, [In] BBDIDLADECH OIGMDCDEKEG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000222")]
	[Cpp2IlInjected.Address(RVA = "0x720EA90", Offset = "0x720D490", VA = "0x18720EA90", Slot = "15")]
	private MIENFEDMCGN JFOHJLMKACP(HJICKIEKHCB BMCAAIIMEIN, [In] BBDIDLADECH OIGMDCDEKEG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000223")]
	[Cpp2IlInjected.Address(RVA = "0x720EB40", Offset = "0x720D540", VA = "0x18720EB40", Slot = "16")]
	private BBNKKAENLJM KNACIAHAACA(HJICKIEKHCB BMCAAIIMEIN, [In] BBDIDLADECH OIGMDCDEKEG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000224")]
	[Cpp2IlInjected.Address(RVA = "0x720E6B0", Offset = "0x720D0B0", VA = "0x18720E6B0", Slot = "17")]
	private MMIDFPGIFAJ ELCOGBDPLCE(HJICKIEKHCB BMCAAIIMEIN, [In] BBDIDLADECH OIGMDCDEKEG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000225")]
	[Cpp2IlInjected.Address(RVA = "0x720E600", Offset = "0x720D000", VA = "0x18720E600", Slot = "18")]
	private PMEFGMFBPKH EIBIOONADJN(HJICKIEKHCB BMCAAIIMEIN, [In] BBDIDLADECH OIGMDCDEKEG)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000020")]
public interface BOCENFMPHOI : KDLCFDJHOCK, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x6000226")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void FEKGBLJAANA(HJICKIEKHCB PPHDEPKLLOK);

	[Cpp2IlInjected.Token(Token = "0x6000227")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void HNNBFGOKLCI(HJICKIEKHCB PPHDEPKLLOK);

	[Cpp2IlInjected.Token(Token = "0x6000228")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void AEFCDMLKGPC(HJICKIEKHCB IGEBDKLCICC);

	[Cpp2IlInjected.Token(Token = "0x6000229")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void PHPBJHCJOMJ(HJICKIEKHCB IGEBDKLCICC);
}
[Cpp2IlInjected.Token(Token = "0x2000021")]
public interface LDHEDMMAPLM : LJFHHIGODHB
{
	[Cpp2IlInjected.Token(Token = "0x1700008A")]
	JMHPEICLALM<HJICKIEKHCB> MEBPKENDANJ
	{
		[Cpp2IlInjected.Token(Token = "0x600022A")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700008B")]
	HJICKIEKHCB EMAGMPFGFHJ
	{
		[Cpp2IlInjected.Token(Token = "0x600022B")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000022")]
public interface JAKOMMPNLOK : MMIDFPGIFAJ
{
	[Cpp2IlInjected.Token(Token = "0x600022C")]
	[Cpp2IlInjected.Address(Slot = "0")]
	(float, Vector3) HMOGFEDMEFJ(Rigidbody JDEIAFKHPLD);
}
[Cpp2IlInjected.Token(Token = "0x2000023")]
public interface LKDAOAFPPCG : MIENFEDMCGN, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x1700008C")]
	PhotonView KKCEFJGKOFI
	{
		[Cpp2IlInjected.Token(Token = "0x600022D")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000024")]
internal sealed class PDDNMHBOBMK : EKCNEAFKJAH
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400002F")]
	private readonly PHNJBAMDJFC PPHDEPKLLOK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000030")]
	private CollisionDetectionMode MOILANHLOEA;

	[Cpp2IlInjected.Token(Token = "0x1700008D")]
	private Rigidbody ENJGFFKJICM
	{
		[Cpp2IlInjected.Token(Token = "0x600022E")]
		[Cpp2IlInjected.Address(RVA = "0x7219370", Offset = "0x7217D70", VA = "0x187219370")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700008E")]
	public CollisionDetectionMode MMFMGKDFGGO
	{
		[Cpp2IlInjected.Token(Token = "0x6000232")]
		[Cpp2IlInjected.Address(RVA = "0x721BB10", Offset = "0x721A510", VA = "0x18721BB10", Slot = "4")]
		get
		{
			return default(CollisionDetectionMode);
		}
		[Cpp2IlInjected.Token(Token = "0x6000233")]
		[Cpp2IlInjected.Address(RVA = "0x721B790", Offset = "0x721A190", VA = "0x18721B790", Slot = "5")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600022F")]
	[Cpp2IlInjected.Address(RVA = "0x7214CB0", Offset = "0x72136B0", VA = "0x187214CB0")]
	public PDDNMHBOBMK(HJICKIEKHCB PPHDEPKLLOK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000230")]
	[Cpp2IlInjected.Address(RVA = "0x721B880", Offset = "0x721A280", VA = "0x18721B880", Slot = "6")]
	public void IMJENBPCPEE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000231")]
	[Cpp2IlInjected.Address(RVA = "0x721B800", Offset = "0x721A200", VA = "0x18721B800", Slot = "9")]
	public void GENJEMJACDM(Rigidbody BBHGIADMCFO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000234")]
	[Cpp2IlInjected.Address(RVA = "0x721B990", Offset = "0x721A390", VA = "0x18721B990", Slot = "7")]
	public void JJPCIBKOCBB(bool BPGMIOFNKDI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000235")]
	[Cpp2IlInjected.Address(RVA = "0x721B9A0", Offset = "0x721A3A0", VA = "0x18721B9A0", Slot = "8")]
	public void JPMGNEOGEPM(bool BPGMIOFNKDI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000236")]
	[Cpp2IlInjected.Address(RVA = "0x721B9B0", Offset = "0x721A3B0", VA = "0x18721B9B0", Slot = "10")]
	public bool KELNKHMGIFP(Vector3 IMGPFEFAFKM, [Out] RaycastHit OEEPALGMIPF, float NGBAMCDGGDI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000237")]
	[Cpp2IlInjected.Address(RVA = "0x721BC20", Offset = "0x721A620", VA = "0x18721BC20")]
	private void NHMECBBIDHP(bool BPGMIOFNKDI)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000025")]
public sealed class OHPGFHHIAAF : IJLFCEHECEB, IDisposable, KJMHNCGJAFK
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000032")]
	private readonly PHNJBAMDJFC PPHDEPKLLOK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000033")]
	private NFCFPCIBOBP OFNPICLCLGO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000034")]
	private MKJPKEEDEAC NFMLELEHLNG;

	[Cpp2IlInjected.Token(Token = "0x1700008F")]
	public NFCFPCIBOBP ILGDOANNLMK
	{
		[Cpp2IlInjected.Token(Token = "0x600023A")]
		[Cpp2IlInjected.Address(RVA = "0x7218290", Offset = "0x7216C90", VA = "0x187218290", Slot = "6")]
		get
		{
			return default(NFCFPCIBOBP);
		}
		[Cpp2IlInjected.Token(Token = "0x600023B")]
		[Cpp2IlInjected.Address(RVA = "0x7218430", Offset = "0x7216E30", VA = "0x187218430", Slot = "7")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000090")]
	private Transform KJIENOILHEK
	{
		[Cpp2IlInjected.Token(Token = "0x600023C")]
		[Cpp2IlInjected.Address(RVA = "0x7218830", Offset = "0x7217230", VA = "0x187218830", Slot = "10")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000020")]
	public event Action<JNKKEIFENFB, JNKKEIFENFB> AEJNOMLLHBM
	{
		[Cpp2IlInjected.Token(Token = "0x6000238")]
		[Cpp2IlInjected.Address(RVA = "0x72181E0", Offset = "0x7216BE0", VA = "0x1872181E0", Slot = "4")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000239")]
		[Cpp2IlInjected.Address(RVA = "0x7218500", Offset = "0x7216F00", VA = "0x187218500", Slot = "5")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600023D")]
	[Cpp2IlInjected.Address(RVA = "0x7218850", Offset = "0x7217250", VA = "0x187218850")]
	public OHPGFHHIAAF(HJICKIEKHCB PPHDEPKLLOK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600023E")]
	[Cpp2IlInjected.Address(RVA = "0x72185B0", Offset = "0x7216FB0", VA = "0x1872185B0", Slot = "8")]
	public void IMJENBPCPEE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600023F")]
	[Cpp2IlInjected.Address(RVA = "0x72183E0", Offset = "0x7216DE0", VA = "0x1872183E0", Slot = "9")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000240")]
	[Cpp2IlInjected.Address(RVA = "0xB2C090", Offset = "0xB2AA90", VA = "0x180B2C090", Slot = "11")]
	private void FFMFMKBGAHE(JNKKEIFENFB HEFFODHPBJF, JNKKEIFENFB CBKEBANDDJE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000241")]
	[Cpp2IlInjected.Address(RVA = "0x883230", Offset = "0x881C30", VA = "0x180883230", Slot = "12")]
	private void EBNAFAGLEJA(bool ADIHFCNFDBL)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000026")]
public class EOGMNINIPBM : MANGKBMACHI
{
	[Cpp2IlInjected.Token(Token = "0x6000242")]
	[Cpp2IlInjected.Address(RVA = "0x720FF30", Offset = "0x720E930", VA = "0x18720FF30", Slot = "4")]
	public KDLCFDJHOCK NCDAEDPHLNE(HJICKIEKHCB BMCAAIIMEIN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000243")]
	[Cpp2IlInjected.Address(RVA = "0x720FC80", Offset = "0x720E680", VA = "0x18720FC80", Slot = "5")]
	public LJPNFDLEOFJ KOEEMIHEAAK(HJICKIEKHCB BMCAAIIMEIN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000244")]
	[Cpp2IlInjected.Address(RVA = "0x720F810", Offset = "0x720E210", VA = "0x18720F810", Slot = "6")]
	public LJFHHIGODHB GDBAFLBNLFA(HJICKIEKHCB BMCAAIIMEIN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000245")]
	[Cpp2IlInjected.Address(RVA = "0x720F940", Offset = "0x720E340", VA = "0x18720F940", Slot = "7")]
	public INLJEOCBMAL IGCENJABKPM(HJICKIEKHCB BMCAAIIMEIN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000246")]
	[Cpp2IlInjected.Address(RVA = "0x720F680", Offset = "0x720E080", VA = "0x18720F680", Slot = "8")]
	public MAKONEBMAFE ENKHCBIPNEF(HJICKIEKHCB BMCAAIIMEIN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000247")]
	[Cpp2IlInjected.Address(RVA = "0x720F0E0", Offset = "0x720DAE0", VA = "0x18720F0E0", Slot = "9")]
	public IJLFCEHECEB AJIJBPHNKJG(HJICKIEKHCB BMCAAIIMEIN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000248")]
	[Cpp2IlInjected.Address(RVA = "0x720F1B0", Offset = "0x720DBB0", VA = "0x18720F1B0", Slot = "10")]
	public GIPEFGCNFNA BBKHGLMFDAI(HJICKIEKHCB BMCAAIIMEIN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000249")]
	[Cpp2IlInjected.Address(RVA = "0x720FDB0", Offset = "0x720E7B0", VA = "0x18720FDB0", Slot = "11")]
	public HLBPPEDLPKE MFNMGKPODKP(HJICKIEKHCB BMCAAIIMEIN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600024A")]
	[Cpp2IlInjected.Address(RVA = "0x720FE70", Offset = "0x720E870", VA = "0x18720FE70", Slot = "12")]
	public EKCNEAFKJAH MMJAJGALNDA(HJICKIEKHCB BMCAAIIMEIN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600024B")]
	[Cpp2IlInjected.Address(RVA = "0x720F750", Offset = "0x720E150", VA = "0x18720F750", Slot = "13")]
	public GHALEEJPMBF GBMJBKOBCBG(HJICKIEKHCB BMCAAIIMEIN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600024C")]
	[Cpp2IlInjected.Address(RVA = "0x720F2D0", Offset = "0x720DCD0", VA = "0x18720F2D0")]
	public KMBNIKHFJIH OKMNPKFPHFK(HJICKIEKHCB BMCAAIIMEIN, [In] BBDIDLADECH OIGMDCDEKEG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600024D")]
	[Cpp2IlInjected.Address(RVA = "0x720F9C0", Offset = "0x720E3C0", VA = "0x18720F9C0")]
	public MIENFEDMCGN LCAMNNIFFLO(HJICKIEKHCB BMCAAIIMEIN, [In] BBDIDLADECH OIGMDCDEKEG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600024E")]
	[Cpp2IlInjected.Address(RVA = "0x720FB50", Offset = "0x720E550", VA = "0x18720FB50")]
	public BBNKKAENLJM MIKDLDOCIPJ(HJICKIEKHCB BMCAAIIMEIN, [In] BBDIDLADECH OIGMDCDEKEG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600024F")]
	[Cpp2IlInjected.Address(RVA = "0x720F4F0", Offset = "0x720DEF0", VA = "0x18720F4F0")]
	public MMIDFPGIFAJ DMLKFFHBBGA(HJICKIEKHCB BMCAAIIMEIN, [In] BBDIDLADECH OIGMDCDEKEG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000250")]
	[Cpp2IlInjected.Address(RVA = "0x720F410", Offset = "0x720DE10", VA = "0x18720F410")]
	public PMEFGMFBPKH CBDDKBBOPLG(HJICKIEKHCB BMCAAIIMEIN, [In] BBDIDLADECH OIGMDCDEKEG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000251")]
	[Cpp2IlInjected.Address(RVA = "0x7210020", Offset = "0x720EA20", VA = "0x187210020", Slot = "19")]
	public HJICKIEKHCB OBLJOBJDBCF(RigidbodyEx PPHDEPKLLOK, BBDIDLADECH OIGMDCDEKEG, BNEKFFELJGI CMHMDBNCGCO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000252")]
	[Cpp2IlInjected.Address(RVA = "0x883870", Offset = "0x882270", VA = "0x180883870")]
	public EOGMNINIPBM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000253")]
	[Cpp2IlInjected.Address(RVA = "0x720F2D0", Offset = "0x720DCD0", VA = "0x18720F2D0", Slot = "14")]
	private KMBNIKHFJIH BBPKKLIFKFL(HJICKIEKHCB BMCAAIIMEIN, [In] BBDIDLADECH OIGMDCDEKEG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000254")]
	[Cpp2IlInjected.Address(RVA = "0x720F9C0", Offset = "0x720E3C0", VA = "0x18720F9C0", Slot = "15")]
	private MIENFEDMCGN JFOHJLMKACP(HJICKIEKHCB BMCAAIIMEIN, [In] BBDIDLADECH OIGMDCDEKEG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000255")]
	[Cpp2IlInjected.Address(RVA = "0x720FB50", Offset = "0x720E550", VA = "0x18720FB50", Slot = "16")]
	private BBNKKAENLJM KNACIAHAACA(HJICKIEKHCB BMCAAIIMEIN, [In] BBDIDLADECH OIGMDCDEKEG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000256")]
	[Cpp2IlInjected.Address(RVA = "0x720F4F0", Offset = "0x720DEF0", VA = "0x18720F4F0", Slot = "17")]
	private MMIDFPGIFAJ ELCOGBDPLCE(HJICKIEKHCB BMCAAIIMEIN, [In] BBDIDLADECH OIGMDCDEKEG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000257")]
	[Cpp2IlInjected.Address(RVA = "0x720F410", Offset = "0x720DE10", VA = "0x18720F410", Slot = "18")]
	private PMEFGMFBPKH EIBIOONADJN(HJICKIEKHCB BMCAAIIMEIN, [In] BBDIDLADECH OIGMDCDEKEG)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000027")]
internal sealed class OLEGIMPEGPF : HLBPPEDLPKE
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000035")]
	private readonly PHNJBAMDJFC PPHDEPKLLOK;

	[Cpp2IlInjected.Token(Token = "0x17000091")]
	private Rigidbody ENJGFFKJICM
	{
		[Cpp2IlInjected.Token(Token = "0x6000258")]
		[Cpp2IlInjected.Address(RVA = "0x7219370", Offset = "0x7217D70", VA = "0x187219370")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000092")]
	private bool ECACFOIGDLA
	{
		[Cpp2IlInjected.Token(Token = "0x6000259")]
		[Cpp2IlInjected.Address(RVA = "0x7219320", Offset = "0x7217D20", VA = "0x187219320")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000093")]
	private bool PFBBECKGEAK
	{
		[Cpp2IlInjected.Token(Token = "0x600025A")]
		[Cpp2IlInjected.Address(RVA = "0x720DB00", Offset = "0x720C500", VA = "0x18720DB00")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000094")]
	private HJICKIEKHCB GCDGMCMKOIG
	{
		[Cpp2IlInjected.Token(Token = "0x600025B")]
		[Cpp2IlInjected.Address(RVA = "0x7218F00", Offset = "0x7217900", VA = "0x187218F00")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600025C")]
	[Cpp2IlInjected.Address(RVA = "0x7214CB0", Offset = "0x72136B0", VA = "0x187214CB0")]
	public OLEGIMPEGPF(HJICKIEKHCB PPHDEPKLLOK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600025D")]
	[Cpp2IlInjected.Address(RVA = "0x72191C0", Offset = "0x7217BC0", VA = "0x1872191C0", Slot = "4")]
	public void LAANHEMGOCB(Vector3 MOFNDFHCJJC, ForceMode JFFPEBEJOGP = ForceMode.Force)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600025E")]
	[Cpp2IlInjected.Address(RVA = "0x7218F60", Offset = "0x7217960", VA = "0x187218F60")]
	private void GKPCNKDEIBM(Vector3 MOFNDFHCJJC, ForceMode JFFPEBEJOGP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600025F")]
	[Cpp2IlInjected.Address(RVA = "0x72193C0", Offset = "0x7217DC0", VA = "0x1872193C0", Slot = "5")]
	public void PHKJEADNHIM(Vector3 MOFNDFHCJJC, Vector3 BJDHDJCINFH, ForceMode JFFPEBEJOGP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000260")]
	[Cpp2IlInjected.Address(RVA = "0x7218B40", Offset = "0x7217540", VA = "0x187218B40", Slot = "6")]
	public void CECHKGFJLEI(Vector3 LGFOKCMDDNH, ForceMode JFFPEBEJOGP = ForceMode.Force)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000261")]
	[Cpp2IlInjected.Address(RVA = "0x7218CA0", Offset = "0x72176A0", VA = "0x187218CA0")]
	private void EKONGNMIFDB(Vector3 LGFOKCMDDNH, ForceMode JFFPEBEJOGP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000262")]
	[Cpp2IlInjected.Address(RVA = "0x72188E0", Offset = "0x72172E0", VA = "0x1872188E0", Slot = "7")]
	public void BJODMGMPAJI(Vector3 LGFOKCMDDNH, ForceMode JFFPEBEJOGP = ForceMode.Force)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000028")]
internal sealed class MLNLDCEIJBG : GHALEEJPMBF
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000036")]
	private readonly PHNJBAMDJFC PPHDEPKLLOK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000037")]
	private bool HJDCFOPFGFM;

	[Cpp2IlInjected.Token(Token = "0x17000095")]
	public bool BNJPFDOMFGG
	{
		[Cpp2IlInjected.Token(Token = "0x6000264")]
		[Cpp2IlInjected.Address(RVA = "0x9ECD20", Offset = "0x9EB720", VA = "0x1809ECD20", Slot = "4")]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000265")]
		[Cpp2IlInjected.Address(RVA = "0x7214B00", Offset = "0x7213500", VA = "0x187214B00", Slot = "5")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000263")]
	[Cpp2IlInjected.Address(RVA = "0x7214CB0", Offset = "0x72136B0", VA = "0x187214CB0")]
	public MLNLDCEIJBG(HJICKIEKHCB PPHDEPKLLOK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000266")]
	[Cpp2IlInjected.Address(RVA = "0x7214C80", Offset = "0x7213680", VA = "0x187214C80", Slot = "6")]
	public void GENJEMJACDM(Rigidbody BBHGIADMCFO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000267")]
	[Cpp2IlInjected.Address(RVA = "0x7214C10", Offset = "0x7213610", VA = "0x187214C10", Slot = "7")]
	public void EDMPKHGJJCA(Rigidbody BBHGIADMCFO)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000029")]
internal sealed class OMAAMMNOOJF : BOCENFMPHOI, KDLCFDJHOCK, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x4000041")]
	private readonly HJICKIEKHCB PPHDEPKLLOK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x4000042")]
	private readonly List<HJICKIEKHCB> ILODEJKNGEO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x4000043")]
	private HJICKIEKHCB MGPJOGDJPHA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x4000044")]
	private HJICKIEKHCB DLPGBMPJIIG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
	[Cpp2IlInjected.Token(Token = "0x4000045")]
	private Transform NEJHHIFEIJE;

	[Cpp2IlInjected.Token(Token = "0x17000096")]
	private Transform DHHBNJAMIOF
	{
		[Cpp2IlInjected.Token(Token = "0x600027A")]
		[Cpp2IlInjected.Address(RVA = "0x721AEF0", Offset = "0x72198F0", VA = "0x18721AEF0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000097")]
	public HJICKIEKHCB GCDGMCMKOIG
	{
		[Cpp2IlInjected.Token(Token = "0x600027D")]
		[Cpp2IlInjected.Address(RVA = "0x88E810", Offset = "0x88D210", VA = "0x18088E810", Slot = "28")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600027E")]
		[Cpp2IlInjected.Address(RVA = "0x7219EE0", Offset = "0x72188E0", VA = "0x187219EE0", Slot = "29")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000098")]
	public HJICKIEKHCB AAHAADHCHKF
	{
		[Cpp2IlInjected.Token(Token = "0x600027F")]
		[Cpp2IlInjected.Address(RVA = "0x886020", Offset = "0x884A20", VA = "0x180886020", Slot = "27")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000099")]
	public IReadOnlyList<HJICKIEKHCB> KFEIJPJILHE
	{
		[Cpp2IlInjected.Token(Token = "0x6000280")]
		[Cpp2IlInjected.Address(RVA = "0x885FE0", Offset = "0x8849E0", VA = "0x180885FE0", Slot = "26")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000021")]
	public event NKPGNCNJBFD IEDGJIENIIM
	{
		[Cpp2IlInjected.Token(Token = "0x6000268")]
		[Cpp2IlInjected.Address(RVA = "0x721AD90", Offset = "0x7219790", VA = "0x18721AD90", Slot = "8")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000269")]
		[Cpp2IlInjected.Address(RVA = "0x721AC10", Offset = "0x7219610", VA = "0x18721AC10", Slot = "9")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000022")]
	public event NKPGNCNJBFD PNCCADFDAHC
	{
		[Cpp2IlInjected.Token(Token = "0x600026A")]
		[Cpp2IlInjected.Address(RVA = "0x721A520", Offset = "0x7218F20", VA = "0x18721A520", Slot = "10")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600026B")]
		[Cpp2IlInjected.Address(RVA = "0x7219950", Offset = "0x7218350", VA = "0x187219950", Slot = "11")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000023")]
	public event OOHMNMHPFKK EPOBKDBHIGE
	{
		[Cpp2IlInjected.Token(Token = "0x600026C")]
		[Cpp2IlInjected.Address(RVA = "0x7219C90", Offset = "0x7218690", VA = "0x187219C90", Slot = "12")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600026D")]
		[Cpp2IlInjected.Address(RVA = "0x7219E40", Offset = "0x7218840", VA = "0x187219E40", Slot = "13")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000024")]
	public event Action ECMNNFNDHDP
	{
		[Cpp2IlInjected.Token(Token = "0x600026E")]
		[Cpp2IlInjected.Address(RVA = "0x721AAD0", Offset = "0x72194D0", VA = "0x18721AAD0", Slot = "14")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600026F")]
		[Cpp2IlInjected.Address(RVA = "0x721A660", Offset = "0x7219060", VA = "0x18721A660", Slot = "15")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000025")]
	public event Action ONMJAOMCAMP
	{
		[Cpp2IlInjected.Token(Token = "0x6000270")]
		[Cpp2IlInjected.Address(RVA = "0x7219BF0", Offset = "0x72185F0", VA = "0x187219BF0", Slot = "16")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000271")]
		[Cpp2IlInjected.Address(RVA = "0x721AB70", Offset = "0x7219570", VA = "0x18721AB70", Slot = "17")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000026")]
	public event Action<HJICKIEKHCB> DMBPCCPDHCE
	{
		[Cpp2IlInjected.Token(Token = "0x6000272")]
		[Cpp2IlInjected.Address(RVA = "0x72199F0", Offset = "0x72183F0", VA = "0x1872199F0", Slot = "18")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000273")]
		[Cpp2IlInjected.Address(RVA = "0x721A470", Offset = "0x7218E70", VA = "0x18721A470", Slot = "19")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000027")]
	public event Action<HJICKIEKHCB> LBMNGOMBCHB
	{
		[Cpp2IlInjected.Token(Token = "0x6000274")]
		[Cpp2IlInjected.Address(RVA = "0x721A8E0", Offset = "0x72192E0", VA = "0x18721A8E0", Slot = "20")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000275")]
		[Cpp2IlInjected.Address(RVA = "0x7219AA0", Offset = "0x72184A0", VA = "0x187219AA0", Slot = "21")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000028")]
	public event Action EELEEDIMKJJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000276")]
		[Cpp2IlInjected.Address(RVA = "0x721B000", Offset = "0x7219A00", VA = "0x18721B000", Slot = "22")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000277")]
		[Cpp2IlInjected.Address(RVA = "0x721ACB0", Offset = "0x72196B0", VA = "0x18721ACB0", Slot = "23")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000029")]
	public event Action<HJICKIEKHCB> PIDIIKIMBMI
	{
		[Cpp2IlInjected.Token(Token = "0x6000278")]
		[Cpp2IlInjected.Address(RVA = "0x721AF50", Offset = "0x7219950", VA = "0x18721AF50", Slot = "24")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000279")]
		[Cpp2IlInjected.Address(RVA = "0x721A700", Offset = "0x7219100", VA = "0x18721A700", Slot = "25")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600027B")]
	[Cpp2IlInjected.Address(RVA = "0x721B440", Offset = "0x7219E40", VA = "0x18721B440")]
	public OMAAMMNOOJF(HJICKIEKHCB PPHDEPKLLOK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600027C")]
	[Cpp2IlInjected.Address(RVA = "0x7219B50", Offset = "0x7218550", VA = "0x187219B50", Slot = "31")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000281")]
	[Cpp2IlInjected.Address(RVA = "0x7219EF0", Offset = "0x72188F0", VA = "0x187219EF0", Slot = "30")]
	public void FPIHKLEMIHN(HJICKIEKHCB GOOHADCPCIA, bool LHJNJOHGEIJ = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000282")]
	[Cpp2IlInjected.Address(RVA = "0x7219640", Offset = "0x7218040", VA = "0x187219640", Slot = "6")]
	public void AEFCDMLKGPC(HJICKIEKHCB IGEBDKLCICC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000283")]
	[Cpp2IlInjected.Address(RVA = "0x721B1C0", Offset = "0x7219BC0", VA = "0x18721B1C0", Slot = "7")]
	public void PHPBJHCJOMJ(HJICKIEKHCB IGEBDKLCICC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000284")]
	[Cpp2IlInjected.Address(RVA = "0x7219D30", Offset = "0x7218730", VA = "0x187219D30", Slot = "4")]
	public void FEKGBLJAANA(HJICKIEKHCB PPHDEPKLLOK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000285")]
	[Cpp2IlInjected.Address(RVA = "0x721A5C0", Offset = "0x7218FC0", VA = "0x18721A5C0", Slot = "5")]
	public void HNNBFGOKLCI(HJICKIEKHCB PPHDEPKLLOK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000286")]
	[Cpp2IlInjected.Address(RVA = "0x72198B0", Offset = "0x72182B0", VA = "0x1872198B0")]
	private void BKHLCINMMEI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000287")]
	[Cpp2IlInjected.Address(RVA = "0x721AD50", Offset = "0x7219750", VA = "0x18721AD50")]
	private void NBAEKEBEJDH(HJICKIEKHCB IGEBDKLCICC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000288")]
	[Cpp2IlInjected.Address(RVA = "0x721A990", Offset = "0x7219390", VA = "0x18721A990")]
	private void LCEKEFCDBDM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000289")]
	[Cpp2IlInjected.Address(RVA = "0x721A7B0", Offset = "0x72191B0", VA = "0x18721A7B0")]
	private void KLGIMMNOLDI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600028A")]
	[Cpp2IlInjected.Address(RVA = "0x721B0A0", Offset = "0x7219AA0", VA = "0x18721B0A0")]
	private void PHEJOLIENGO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600028B")]
	[Cpp2IlInjected.Address(RVA = "0x721AE30", Offset = "0x7219830", VA = "0x18721AE30")]
	[CompilerGenerated]
	private object NECDIBOFLFF()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200002A")]
internal static class FPDBMGOGNKO
{
	[Cpp2IlInjected.Token(Token = "0x600028C")]
	[Cpp2IlInjected.Address(RVA = "0x7210170", Offset = "0x720EB70", VA = "0x187210170")]
	public static BOCENFMPHOI LIFEFNNCMJG(this HJICKIEKHCB BMCAAIIMEIN)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200002B")]
internal sealed class PHAOMKEKCBG : LDHEDMMAPLM, LJFHHIGODHB
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000046")]
	private readonly PHNJBAMDJFC PPHDEPKLLOK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000047")]
	private readonly JMHPEICLALM<HJICKIEKHCB> EELJDNFHMEA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000048")]
	private bool LGBFEJJBPKE;

	[Cpp2IlInjected.Token(Token = "0x1700009A")]
	public JMHPEICLALM<HJICKIEKHCB> MEBPKENDANJ
	{
		[Cpp2IlInjected.Token(Token = "0x600028D")]
		[Cpp2IlInjected.Address(RVA = "0x886780", Offset = "0x885180", VA = "0x180886780", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700009B")]
	public Vector3 DEFFNLNMPNO
	{
		[Cpp2IlInjected.Token(Token = "0x600028E")]
		[Cpp2IlInjected.Address(RVA = "0x721C890", Offset = "0x721B290", VA = "0x18721C890", Slot = "6")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700009C")]
	public Vector3 KAAHBKEPLBC
	{
		[Cpp2IlInjected.Token(Token = "0x600028F")]
		[Cpp2IlInjected.Address(RVA = "0x721BDA0", Offset = "0x721A7A0", VA = "0x18721BDA0", Slot = "7")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700009D")]
	private Vector3 FAAJKJFJEPO
	{
		[Cpp2IlInjected.Token(Token = "0x6000293")]
		[Cpp2IlInjected.Address(RVA = "0x721BFD0", Offset = "0x721A9D0", VA = "0x18721BFD0")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700009E")]
	public HJICKIEKHCB EMAGMPFGFHJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000294")]
		[Cpp2IlInjected.Address(RVA = "0x721C7E0", Offset = "0x721B1E0", VA = "0x18721C7E0", Slot = "5")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000290")]
	[Cpp2IlInjected.Address(RVA = "0x721C8C0", Offset = "0x721B2C0", VA = "0x18721C8C0")]
	public PHAOMKEKCBG(HJICKIEKHCB PPHDEPKLLOK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000291")]
	[Cpp2IlInjected.Address(RVA = "0x721BF60", Offset = "0x721A960", VA = "0x18721BF60", Slot = "8")]
	public void DIIIMNGPGAE(HJICKIEKHCB DLPGBMPJIIG, object KLGLJKMNAIM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000292")]
	[Cpp2IlInjected.Address(RVA = "0x721BD40", Offset = "0x721A740", VA = "0x18721BD40", Slot = "9")]
	public void BNGOCECIKED(object KLGLJKMNAIM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000295")]
	[Cpp2IlInjected.Address(RVA = "0x721C0C0", Offset = "0x721AAC0", VA = "0x18721C0C0")]
	private Vector3 HJGNLPLJFLC()
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000296")]
	[Cpp2IlInjected.Address(RVA = "0x721C450", Offset = "0x721AE50", VA = "0x18721C450")]
	private void INJNBPLEAHK(HJICKIEKHCB INIHNMABGPH)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002C")]
internal static class LJOOKGFNMBO
{
	[Cpp2IlInjected.Token(Token = "0x6000297")]
	[Cpp2IlInjected.Address(RVA = "0x7210AC0", Offset = "0x720F4C0", VA = "0x187210AC0")]
	public static LDHEDMMAPLM BAOPPCLICOJ(this HJICKIEKHCB BMCAAIIMEIN)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200002D")]
internal sealed class NBBHFOFOEIP : JAKOMMPNLOK, MMIDFPGIFAJ
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400004A")]
	private readonly PHNJBAMDJFC PPHDEPKLLOK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400004B")]
	private readonly OverridableVector3 AKEOELCGFPM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400004C")]
	private readonly OverridableVector3 NNGNAJJPAAD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x400004D")]
	private float GANMDNFMAEB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x44")]
	[Cpp2IlInjected.Token(Token = "0x400004E")]
	private float NAPLACBEKCI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x400004F")]
	private Vector3 ODBCKPGKOOG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x54")]
	[Cpp2IlInjected.Token(Token = "0x4000050")]
	private Vector3? ENCBDNIANFH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x64")]
	[Cpp2IlInjected.Token(Token = "0x4000051")]
	private Quaternion? AHEJDGJEAEC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
	[Cpp2IlInjected.Token(Token = "0x4000052")]
	private bool JKHPNDKDFPP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x79")]
	[Cpp2IlInjected.Token(Token = "0x4000053")]
	private bool MAGOFHFMFAB;

	[Cpp2IlInjected.Token(Token = "0x1700009F")]
	public Vector3 KCEKPJILAJA
	{
		[Cpp2IlInjected.Token(Token = "0x600029A")]
		[Cpp2IlInjected.Address(RVA = "0xF08670", Offset = "0xF07070", VA = "0x180F08670", Slot = "7")]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x600029B")]
		[Cpp2IlInjected.Address(RVA = "0x72158B0", Offset = "0x72142B0", VA = "0x1872158B0", Slot = "8")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A0")]
	public Vector3 FPCHOLPNOPI
	{
		[Cpp2IlInjected.Token(Token = "0x600029C")]
		[Cpp2IlInjected.Address(RVA = "0x72169E0", Offset = "0x72153E0", VA = "0x1872169E0", Slot = "9")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A1")]
	public float KDHFLDGHHAG
	{
		[Cpp2IlInjected.Token(Token = "0x600029D")]
		[Cpp2IlInjected.Address(RVA = "0x9ECD40", Offset = "0x9EB740", VA = "0x1809ECD40", Slot = "10")]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x600029E")]
		[Cpp2IlInjected.Address(RVA = "0x72152A0", Offset = "0x7213CA0", VA = "0x1872152A0")]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A2")]
	public float MIGGNCCCNIJ
	{
		[Cpp2IlInjected.Token(Token = "0x600029F")]
		[Cpp2IlInjected.Address(RVA = "0x9ECD30", Offset = "0x9EB730", VA = "0x1809ECD30", Slot = "11")]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x60002A0")]
		[Cpp2IlInjected.Address(RVA = "0x7215620", Offset = "0x7214020", VA = "0x187215620", Slot = "12")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A3")]
	public Vector3 BCKABBMCBMI
	{
		[Cpp2IlInjected.Token(Token = "0x60002A1")]
		[Cpp2IlInjected.Address(RVA = "0x7214D40", Offset = "0x7213740", VA = "0x187214D40", Slot = "13")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A4")]
	public Quaternion POPAGHEFHJP
	{
		[Cpp2IlInjected.Token(Token = "0x60002A2")]
		[Cpp2IlInjected.Address(RVA = "0x7217400", Offset = "0x7215E00", VA = "0x187217400", Slot = "14")]
		get
		{
			return default(Quaternion);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A5")]
	private Rigidbody ENJGFFKJICM
	{
		[Cpp2IlInjected.Token(Token = "0x60002AA")]
		[Cpp2IlInjected.Address(RVA = "0x72173B0", Offset = "0x7215DB0", VA = "0x1872173B0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400002A")]
	public event NKPGNCNJBFD FKGDODEHBGP
	{
		[Cpp2IlInjected.Token(Token = "0x6000298")]
		[Cpp2IlInjected.Address(RVA = "0x7216940", Offset = "0x7215340", VA = "0x187216940", Slot = "5")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000299")]
		[Cpp2IlInjected.Address(RVA = "0x7215A40", Offset = "0x7214440", VA = "0x187215A40", Slot = "6")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60002A3")]
	[Cpp2IlInjected.Address(RVA = "0x7217580", Offset = "0x7215F80", VA = "0x187217580")]
	public NBBHFOFOEIP(HJICKIEKHCB PPHDEPKLLOK, [In] BBDIDLADECH OIGMDCDEKEG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002A4")]
	[Cpp2IlInjected.Address(RVA = "0x7216AD0", Offset = "0x72154D0", VA = "0x187216AD0", Slot = "17")]
	public void JILPDFLGOIA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002A5")]
	[Cpp2IlInjected.Address(RVA = "0x7216E30", Offset = "0x7215830", VA = "0x187216E30", Slot = "16")]
	public void NFLANFFNEKE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002A6")]
	[Cpp2IlInjected.Address(RVA = "0x7215960", Offset = "0x7214360", VA = "0x187215960", Slot = "19")]
	public void GENJEMJACDM(Rigidbody BBHGIADMCFO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002A7")]
	[Cpp2IlInjected.Address(RVA = "0x72156D0", Offset = "0x72140D0", VA = "0x1872156D0", Slot = "20")]
	public void EDMPKHGJJCA(Rigidbody BBHGIADMCFO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002A8")]
	[Cpp2IlInjected.Address(RVA = "0x7216C80", Offset = "0x7215680", VA = "0x187216C80", Slot = "18")]
	public void LJDOILDGGFC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002A9")]
	[Cpp2IlInjected.Address(RVA = "0x7216F10", Offset = "0x7215910", VA = "0x187216F10", Slot = "21")]
	public void NLPLHAJCENC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002AB")]
	[Cpp2IlInjected.Address(RVA = "0x72158B0", Offset = "0x72142B0", VA = "0x1872158B0")]
	private void FFHEGMGGFCK(Vector3 CLMKDBDPNNH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002AC")]
	[Cpp2IlInjected.Address(RVA = "0x7215530", Offset = "0x7213F30", VA = "0x187215530")]
	[Obsolete("This method is dangerous - the unity rigidbody is updated in a deferred manner and this world position may be stale")]
	private Vector3 AMMDDMPNMOJ()
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x60002AD")]
	[Cpp2IlInjected.Address(RVA = "0x72152A0", Offset = "0x7213CA0", VA = "0x1872152A0")]
	private void AFMCHBLPGMC(float CLMKDBDPNNH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002AE")]
	[Cpp2IlInjected.Address(RVA = "0x7215620", Offset = "0x7214020", VA = "0x187215620")]
	private void DOCFMIOIEHE(float CLMKDBDPNNH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002AF")]
	[Cpp2IlInjected.Address(RVA = "0x7215100", Offset = "0x7213B00", VA = "0x187215100")]
	private Vector3 AFBDHLNBHKD()
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x60002B0")]
	[Cpp2IlInjected.Address(RVA = "0x7214ED0", Offset = "0x72138D0", VA = "0x187214ED0", Slot = "15")]
	public void AEDGDCGJMKG((Quaternion rot, Vector3 moments) FLBDCMBPIHC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002B1")]
	[Cpp2IlInjected.Address(RVA = "0x72153B0", Offset = "0x7213DB0", VA = "0x1872153B0")]
	private Quaternion AIKLABHEBNN()
	{
		return default(Quaternion);
	}

	[Cpp2IlInjected.Token(Token = "0x60002B2")]
	[Cpp2IlInjected.Address(RVA = "0x7216870", Offset = "0x7215270", VA = "0x187216870")]
	public void HMOGFEDMEFJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002B3")]
	[Cpp2IlInjected.Address(RVA = "0x7215AE0", Offset = "0x72144E0", VA = "0x187215AE0", Slot = "4")]
	public (float, Vector3) HMOGFEDMEFJ(Rigidbody JDEIAFKHPLD)
	{
		return default((float, Vector3));
	}
}
[Cpp2IlInjected.Token(Token = "0x200002E")]
internal static class LHDGEEGFMKC
{
	[Cpp2IlInjected.Token(Token = "0x60002B4")]
	[Cpp2IlInjected.Address(RVA = "0x7210730", Offset = "0x720F130", VA = "0x187210730")]
	public static JAKOMMPNLOK AENGPMPMCFB(this HJICKIEKHCB BMCAAIIMEIN)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200002F")]
internal sealed class MLFMKLLKHCE : BBNKKAENLJM
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000054")]
	private readonly PHNJBAMDJFC PPHDEPKLLOK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000055")]
	private readonly NMGCDKAGAKF PFHENMCAPLI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000056")]
	private readonly MFAANDACBHL LJMICMJLNPK;

	[Cpp2IlInjected.Token(Token = "0x170000A6")]
	public bool BLACMBKEKKK
	{
		[Cpp2IlInjected.Token(Token = "0x60002B5")]
		[Cpp2IlInjected.Address(RVA = "0x1099A70", Offset = "0x1098470", VA = "0x181099A70", Slot = "10")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A7")]
	public MFAANDACBHL IMJGMMEIMOF
	{
		[Cpp2IlInjected.Token(Token = "0x60002B6")]
		[Cpp2IlInjected.Address(RVA = "0x8F2EF0", Offset = "0x8F18F0", VA = "0x1808F2EF0", Slot = "11")]
		get
		{
			return default(MFAANDACBHL);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60002B7")]
	[Cpp2IlInjected.Address(RVA = "0x7214A00", Offset = "0x7213400", VA = "0x187214A00")]
	public MLFMKLLKHCE(HJICKIEKHCB PPHDEPKLLOK, [In] BBDIDLADECH OIGMDCDEKEG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002B8")]
	[Cpp2IlInjected.Address(RVA = "0x7214440", Offset = "0x7212E40", VA = "0x187214440", Slot = "4")]
	public void IMJENBPCPEE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002B9")]
	[Cpp2IlInjected.Address(RVA = "0x72146B0", Offset = "0x72130B0", VA = "0x1872146B0")]
	private bool MDACJHNNBAE()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002BA")]
	[Cpp2IlInjected.Address(RVA = "0x7214750", Offset = "0x7213150", VA = "0x187214750", Slot = "5")]
	public void NDHAJAENBKD(object KLGLJKMNAIM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002BB")]
	[Cpp2IlInjected.Address(RVA = "0x7214640", Offset = "0x7213040", VA = "0x187214640", Slot = "6")]
	public void LKFEFDPHHJB(object KLGLJKMNAIM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002BC")]
	[Cpp2IlInjected.Address(RVA = "0x7214510", Offset = "0x7212F10", VA = "0x187214510", Slot = "9")]
	public void KNBGDELBMKC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002BD")]
	[Cpp2IlInjected.Address(RVA = "0x72148F0", Offset = "0x72132F0", VA = "0x1872148F0")]
	private void OLJKAIFMKHK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002BE")]
	[Cpp2IlInjected.Address(RVA = "0x7214780", Offset = "0x7213180", VA = "0x187214780")]
	private void NKLKBAEDKEJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002BF")]
	[Cpp2IlInjected.Address(RVA = "0x7214670", Offset = "0x7213070", VA = "0x187214670", Slot = "8")]
	public void LKIGGABLFNN(HJICKIEKHCB PPHDEPKLLOK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002C0")]
	[Cpp2IlInjected.Address(RVA = "0x7214400", Offset = "0x7212E00", VA = "0x187214400", Slot = "7")]
	public void EPGEDDMPBIA(HJICKIEKHCB PPHDEPKLLOK)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000030")]
internal sealed class CEOPIJLFPMM : GIPEFGCNFNA
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000058")]
	private readonly PHNJBAMDJFC PPHDEPKLLOK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000059")]
	private readonly NMGCDKAGAKF DGLJOLIJDEF;

	[Cpp2IlInjected.Token(Token = "0x170000A8")]
	public bool ECACFOIGDLA
	{
		[Cpp2IlInjected.Token(Token = "0x60002C3")]
		[Cpp2IlInjected.Address(RVA = "0x720D840", Offset = "0x720C240", VA = "0x18720D840", Slot = "6")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400002B")]
	public event NKPGNCNJBFD DNICKMKOHNE
	{
		[Cpp2IlInjected.Token(Token = "0x60002C1")]
		[Cpp2IlInjected.Address(RVA = "0x720D7A0", Offset = "0x720C1A0", VA = "0x18720D7A0", Slot = "4")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60002C2")]
		[Cpp2IlInjected.Address(RVA = "0x720D700", Offset = "0x720C100", VA = "0x18720D700", Slot = "5")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60002C4")]
	[Cpp2IlInjected.Address(RVA = "0x720DA10", Offset = "0x720C410", VA = "0x18720DA10")]
	public CEOPIJLFPMM(HJICKIEKHCB PPHDEPKLLOK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002C5")]
	[Cpp2IlInjected.Address(RVA = "0x720D670", Offset = "0x720C070", VA = "0x18720D670", Slot = "7")]
	public void EKLHHEPCCKC(object KLGLJKMNAIM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002C6")]
	[Cpp2IlInjected.Address(RVA = "0x720D8F0", Offset = "0x720C2F0", VA = "0x18720D8F0", Slot = "8")]
	public void OKGNMFPINPB(object KLGLJKMNAIM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002C7")]
	[Cpp2IlInjected.Address(RVA = "0x720D900", Offset = "0x720C300", VA = "0x18720D900", Slot = "9")]
	public void PIFPFDAHBCB(object KLGLJKMNAIM, bool IMIKPNPKFPA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002C8")]
	[Cpp2IlInjected.Address(RVA = "0x720D600", Offset = "0x720C000", VA = "0x18720D600", Slot = "12")]
	public void DCNFAAGACEE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002C9")]
	[Cpp2IlInjected.Address(RVA = "0x720D680", Offset = "0x720C080", VA = "0x18720D680", Slot = "10")]
	public void GENJEMJACDM(Rigidbody BHBGFFIGMHB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002CA")]
	[Cpp2IlInjected.Address(RVA = "0x720D640", Offset = "0x720C040", VA = "0x18720D640", Slot = "11")]
	public void EDMPKHGJJCA(Rigidbody BBHGIADMCFO)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000031")]
internal sealed class CBECCNKMKCH : LKDAOAFPPCG, MIENFEDMCGN, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400005B")]
	private readonly PHNJBAMDJFC PPHDEPKLLOK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400005C")]
	private PhotonView AMBHKHDIIIA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400005D")]
	private bool LGJNELFOEIA;

	[Cpp2IlInjected.Token(Token = "0x170000A9")]
	public PhotonView KKCEFJGKOFI
	{
		[Cpp2IlInjected.Token(Token = "0x60002CD")]
		[Cpp2IlInjected.Address(RVA = "0x8869A0", Offset = "0x8853A0", VA = "0x1808869A0", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000AA")]
	public bool OPJGDKAGBJB
	{
		[Cpp2IlInjected.Token(Token = "0x60002CE")]
		[Cpp2IlInjected.Address(RVA = "0x720CCE0", Offset = "0x720B6E0", VA = "0x18720CCE0", Slot = "7")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000AB")]
	public bool HADEFDBIEKJ
	{
		[Cpp2IlInjected.Token(Token = "0x60002CF")]
		[Cpp2IlInjected.Address(RVA = "0x8FEDF0", Offset = "0x8FD7F0", VA = "0x1808FEDF0", Slot = "8")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400002C")]
	public event NKPGNCNJBFD ODFMBBFOAKF
	{
		[Cpp2IlInjected.Token(Token = "0x60002CB")]
		[Cpp2IlInjected.Address(RVA = "0x720D290", Offset = "0x720BC90", VA = "0x18720D290", Slot = "5")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60002CC")]
		[Cpp2IlInjected.Address(RVA = "0x720CD00", Offset = "0x720B700", VA = "0x18720CD00", Slot = "6")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60002D0")]
	[Cpp2IlInjected.Address(RVA = "0x720D4A0", Offset = "0x720BEA0", VA = "0x18720D4A0")]
	public CBECCNKMKCH(HJICKIEKHCB PPHDEPKLLOK, [In] BBDIDLADECH OIGMDCDEKEG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002D1")]
	[Cpp2IlInjected.Address(RVA = "0x720D010", Offset = "0x720BA10", VA = "0x18720D010", Slot = "9")]
	public void IMJENBPCPEE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002D2")]
	[Cpp2IlInjected.Address(RVA = "0x720CDA0", Offset = "0x720B7A0", VA = "0x18720CDA0", Slot = "12")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002D3")]
	[Cpp2IlInjected.Address(RVA = "0x720CEA0", Offset = "0x720B8A0", VA = "0x18720CEA0", Slot = "10")]
	public void GBEAELEIDIP(HJICKIEKHCB DLPGBMPJIIG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002D4")]
	[Cpp2IlInjected.Address(RVA = "0x720CB70", Offset = "0x720B570", VA = "0x18720CB70", Slot = "11")]
	public void AMPKMLOKOCI(HJICKIEKHCB DLPGBMPJIIG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002D5")]
	[Cpp2IlInjected.Address(RVA = "0x720D330", Offset = "0x720BD30", VA = "0x18720D330")]
	private void PPCAALPKNAB(PhotonView ALFOGJOLLLI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002D6")]
	[Cpp2IlInjected.Address(RVA = "0x720D140", Offset = "0x720BB40", VA = "0x18720D140")]
	private void JKOIDEMKPMH(FJDKJBAPALO ONMHIAEGIAL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002D7")]
	[Cpp2IlInjected.Address(RVA = "0x720C900", Offset = "0x720B300", VA = "0x18720C900")]
	private void AFGPMLJKDLH(PhotonView OBBBLLOFPLM)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000032")]
internal static class BNMJNNCJALG
{
	[Cpp2IlInjected.Token(Token = "0x60002D8")]
	[Cpp2IlInjected.Address(RVA = "0x720C840", Offset = "0x720B240", VA = "0x18720C840")]
	public static LKDAOAFPPCG OKKNIDHNKKF(this HJICKIEKHCB BMCAAIIMEIN)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000033")]
internal sealed class IHBCFCCOGDL : PMEFGMFBPKH
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400005E")]
	private readonly PHNJBAMDJFC PPHDEPKLLOK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400005F")]
	private RigidbodyConstraints AADIACFNDHD;

	[Cpp2IlInjected.Token(Token = "0x170000AC")]
	public bool FMNKECDKHIA
	{
		[Cpp2IlInjected.Token(Token = "0x60002D9")]
		[Cpp2IlInjected.Address(RVA = "0x8D1180", Offset = "0x8CFB80", VA = "0x1808D1180", Slot = "4")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x60002DA")]
		[Cpp2IlInjected.Address(RVA = "0x4687F70", Offset = "0x4686970", VA = "0x184687F70", Slot = "5")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000AD")]
	public bool EIGODHNMFII
	{
		[Cpp2IlInjected.Token(Token = "0x60002DB")]
		[Cpp2IlInjected.Address(RVA = "0x9ECCD0", Offset = "0x9EB6D0", VA = "0x1809ECCD0", Slot = "6")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x60002DC")]
		[Cpp2IlInjected.Address(RVA = "0x4687F60", Offset = "0x4686960", VA = "0x184687F60")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000AE")]
	public RigidbodyConstraints ENALJCPNLCD
	{
		[Cpp2IlInjected.Token(Token = "0x60002DD")]
		[Cpp2IlInjected.Address(RVA = "0x889410", Offset = "0x887E10", VA = "0x180889410", Slot = "7")]
		get
		{
			return default(RigidbodyConstraints);
		}
		[Cpp2IlInjected.Token(Token = "0x60002DE")]
		[Cpp2IlInjected.Address(RVA = "0x72104B0", Offset = "0x720EEB0", VA = "0x1872104B0", Slot = "8")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60002DF")]
	[Cpp2IlInjected.Address(RVA = "0x72105E0", Offset = "0x720EFE0", VA = "0x1872105E0")]
	public IHBCFCCOGDL(HJICKIEKHCB PPHDEPKLLOK, [In] BBDIDLADECH OIGMDCDEKEG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002E0")]
	[Cpp2IlInjected.Address(RVA = "0x7210480", Offset = "0x720EE80", VA = "0x187210480", Slot = "9")]
	public void GENJEMJACDM(Rigidbody BBHGIADMCFO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002E1")]
	[Cpp2IlInjected.Address(RVA = "0x7210450", Offset = "0x720EE50", VA = "0x187210450", Slot = "10")]
	public void EDMPKHGJJCA(Rigidbody BBHGIADMCFO)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000034")]
internal sealed class LJJJPKNOCGI : INLJEOCBMAL
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000062")]
	private readonly HJICKIEKHCB PPHDEPKLLOK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000063")]
	private float POHEHLDHGBN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
	[Cpp2IlInjected.Token(Token = "0x4000064")]
	private float IILHOJFNPBM;

	[Cpp2IlInjected.Token(Token = "0x170000AF")]
	public float HPHNEEEKANI
	{
		[Cpp2IlInjected.Token(Token = "0x60002E3")]
		[Cpp2IlInjected.Address(RVA = "0x91E840", Offset = "0x91D240", VA = "0x18091E840", Slot = "4")]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x60002E4")]
		[Cpp2IlInjected.Address(RVA = "0x72109B0", Offset = "0x720F3B0", VA = "0x1872109B0", Slot = "5")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B0")]
	public float EPCMFHDALND
	{
		[Cpp2IlInjected.Token(Token = "0x60002E5")]
		[Cpp2IlInjected.Address(RVA = "0xA35360", Offset = "0xA33D60", VA = "0x180A35360", Slot = "6")]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x60002E6")]
		[Cpp2IlInjected.Address(RVA = "0x7210890", Offset = "0x720F290", VA = "0x187210890", Slot = "7")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60002E2")]
	[Cpp2IlInjected.Address(RVA = "0x7210A80", Offset = "0x720F480", VA = "0x187210A80")]
	public LJJJPKNOCGI(HJICKIEKHCB PPHDEPKLLOK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002E7")]
	[Cpp2IlInjected.Address(RVA = "0x7210960", Offset = "0x720F360", VA = "0x187210960", Slot = "8")]
	public void GENJEMJACDM(Rigidbody BBHGIADMCFO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002E8")]
	[Cpp2IlInjected.Address(RVA = "0x72107F0", Offset = "0x720F1F0", VA = "0x1872107F0", Slot = "9")]
	public void EDMPKHGJJCA(Rigidbody BBHGIADMCFO)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000035")]
internal sealed class OCBJIMJCMGM : MAKONEBMAFE
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000066")]
	private readonly PHNJBAMDJFC PPHDEPKLLOK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000067")]
	private bool OMBBFHPADPD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x21")]
	[Cpp2IlInjected.Token(Token = "0x4000068")]
	private bool ALEPFDMLALD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
	[Cpp2IlInjected.Token(Token = "0x4000069")]
	private int IHGJMABLDCH;

	[Cpp2IlInjected.Token(Token = "0x170000B1")]
	private Rigidbody ENJGFFKJICM
	{
		[Cpp2IlInjected.Token(Token = "0x60002EB")]
		[Cpp2IlInjected.Address(RVA = "0x72173B0", Offset = "0x7215DB0", VA = "0x1872173B0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B2")]
	private bool HCGHFFMIFAI
	{
		[Cpp2IlInjected.Token(Token = "0x60002EC")]
		[Cpp2IlInjected.Address(RVA = "0x7217AC0", Offset = "0x72164C0", VA = "0x187217AC0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B3")]
	private HJICKIEKHCB GCDGMCMKOIG
	{
		[Cpp2IlInjected.Token(Token = "0x60002ED")]
		[Cpp2IlInjected.Address(RVA = "0x7217930", Offset = "0x7216330", VA = "0x187217930")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B4")]
	private bool PFBBECKGEAK
	{
		[Cpp2IlInjected.Token(Token = "0x60002EE")]
		[Cpp2IlInjected.Address(RVA = "0x7217830", Offset = "0x7216230", VA = "0x187217830")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400002D")]
	public event NKPGNCNJBFD AJLHECBDMME
	{
		[Cpp2IlInjected.Token(Token = "0x60002E9")]
		[Cpp2IlInjected.Address(RVA = "0x7217AE0", Offset = "0x72164E0", VA = "0x187217AE0", Slot = "4")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60002EA")]
		[Cpp2IlInjected.Address(RVA = "0x7217890", Offset = "0x7216290", VA = "0x187217890", Slot = "5")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60002EF")]
	[Cpp2IlInjected.Address(RVA = "0x7218150", Offset = "0x7216B50", VA = "0x187218150")]
	public OCBJIMJCMGM(HJICKIEKHCB PPHDEPKLLOK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002F0")]
	[Cpp2IlInjected.Address(RVA = "0x7217A30", Offset = "0x7216430", VA = "0x187217A30", Slot = "6")]
	public void IMJENBPCPEE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002F1")]
	[Cpp2IlInjected.Address(RVA = "0x7217EF0", Offset = "0x72168F0", VA = "0x187217EF0", Slot = "8")]
	public void OMFLDHEBKBD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002F2")]
	[Cpp2IlInjected.Address(RVA = "0x72176E0", Offset = "0x72160E0", VA = "0x1872176E0", Slot = "7")]
	public bool DAGFFDAJHPA()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002F3")]
	[Cpp2IlInjected.Address(RVA = "0x7217990", Offset = "0x7216390", VA = "0x187217990", Slot = "9")]
	public void IEDGDDEBKFI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002F4")]
	[Cpp2IlInjected.Address(RVA = "0x7217F00", Offset = "0x7216900", VA = "0x187217F00", Slot = "11")]
	public void PADIIMONECN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002F5")]
	[Cpp2IlInjected.Address(RVA = "0x7217FA0", Offset = "0x72169A0", VA = "0x187217FA0", Slot = "10")]
	public void PLJALHCLOGL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002F6")]
	[Cpp2IlInjected.Address(RVA = "0x7217B80", Offset = "0x7216580", VA = "0x187217B80")]
	private bool MNJAGOJNFKN()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002F7")]
	[Cpp2IlInjected.Address(RVA = "0x7217D60", Offset = "0x7216760", VA = "0x187217D60")]
	private void NLOJDALBGPF()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000036")]
internal sealed class CHIAOHBAGIN : KMBNIKHFJIH
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400006A")]
	private readonly PHNJBAMDJFC PPHDEPKLLOK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400006B")]
	private readonly NMGCDKAGAKF NBIONKECPLF;

	[Cpp2IlInjected.Token(Token = "0x170000B5")]
	public Rigidbody ENJGFFKJICM
	{
		[Cpp2IlInjected.Token(Token = "0x60002F8")]
		[Cpp2IlInjected.Address(RVA = "0x8869A0", Offset = "0x8853A0", VA = "0x1808869A0", Slot = "4")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60002F9")]
		[Cpp2IlInjected.Address(RVA = "0x885AF0", Offset = "0x8844F0", VA = "0x180885AF0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B6")]
	private bool PFBBECKGEAK
	{
		[Cpp2IlInjected.Token(Token = "0x60002FA")]
		[Cpp2IlInjected.Address(RVA = "0x720DB00", Offset = "0x720C500", VA = "0x18720DB00")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B7")]
	public bool JHBDJFOBIOM
	{
		[Cpp2IlInjected.Token(Token = "0x60002FD")]
		[Cpp2IlInjected.Address(RVA = "0x1099A70", Offset = "0x1098470", VA = "0x181099A70", Slot = "6")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60002FB")]
	[Cpp2IlInjected.Address(RVA = "0x720E300", Offset = "0x720CD00", VA = "0x18720E300")]
	public CHIAOHBAGIN(HJICKIEKHCB PPHDEPKLLOK, [In] BBDIDLADECH OIGMDCDEKEG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002FC")]
	[Cpp2IlInjected.Address(RVA = "0x720DD80", Offset = "0x720C780", VA = "0x18720DD80", Slot = "5")]
	public void IMJENBPCPEE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002FE")]
	[Cpp2IlInjected.Address(RVA = "0x720E2D0", Offset = "0x720CCD0", VA = "0x18720E2D0", Slot = "7")]
	public void MIICELNANPB(object KLGLJKMNAIM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002FF")]
	[Cpp2IlInjected.Address(RVA = "0x720DB60", Offset = "0x720C560", VA = "0x18720DB60", Slot = "8")]
	public void GIILIPCFCKI(object KLGLJKMNAIM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000300")]
	[Cpp2IlInjected.Address(RVA = "0x720DFA0", Offset = "0x720C9A0", VA = "0x18720DFA0", Slot = "9")]
	public void LGNHONJLKNM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000301")]
	[Cpp2IlInjected.Address(RVA = "0x720DB90", Offset = "0x720C590", VA = "0x18720DB90", Slot = "10")]
	public void GLOBNCOONOF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000302")]
	[Cpp2IlInjected.Address(RVA = "0x720DE20", Offset = "0x720C820", VA = "0x18720DE20", Slot = "11")]
	public void JOAGGIEGBJC()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000037")]
internal sealed class MCHPBOJPJLM : LJPNFDLEOFJ, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400006D")]
	private readonly PHNJBAMDJFC PPHDEPKLLOK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400006E")]
	private readonly NMGCDKAGAKF MLFFJLNNIFC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400006F")]
	private float AGMLJGLHOIN;

	[Cpp2IlInjected.Token(Token = "0x170000B8")]
	public MOINMCBEJEM ODBJPAPAGHJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000303")]
		[Cpp2IlInjected.Address(RVA = "0x886D60", Offset = "0x885760", VA = "0x180886D60", Slot = "4")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000304")]
		[Cpp2IlInjected.Address(RVA = "0x886770", Offset = "0x885170", VA = "0x180886770", Slot = "5")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B9")]
	public BNOGFHPHCAG HCKNGOOJLMN
	{
		[Cpp2IlInjected.Token(Token = "0x6000305")]
		[Cpp2IlInjected.Address(RVA = "0x8893E0", Offset = "0x887DE0", VA = "0x1808893E0", Slot = "6")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000306")]
		[Cpp2IlInjected.Address(RVA = "0x8893D0", Offset = "0x887DD0", VA = "0x1808893D0", Slot = "7")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000BA")]
	public Vector3 FAAJKJFJEPO
	{
		[Cpp2IlInjected.Token(Token = "0x6000307")]
		[Cpp2IlInjected.Address(RVA = "0x7211D50", Offset = "0x7210750", VA = "0x187211D50", Slot = "8")]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x6000308")]
		[Cpp2IlInjected.Address(RVA = "0x7212990", Offset = "0x7211390", VA = "0x187212990", Slot = "9")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000BB")]
	public Vector3 LPFOLNGLBAM
	{
		[Cpp2IlInjected.Token(Token = "0x6000309")]
		[Cpp2IlInjected.Address(RVA = "0x72135B0", Offset = "0x7211FB0", VA = "0x1872135B0", Slot = "10")]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x600030A")]
		[Cpp2IlInjected.Address(RVA = "0x7213D90", Offset = "0x7212790", VA = "0x187213D90", Slot = "11")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000BC")]
	public Vector3 MBFKAFHGKDN
	{
		[Cpp2IlInjected.Token(Token = "0x600030B")]
		[Cpp2IlInjected.Address(RVA = "0x7211EB0", Offset = "0x72108B0", VA = "0x187211EB0", Slot = "12")]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x600030C")]
		[Cpp2IlInjected.Address(RVA = "0x7211440", Offset = "0x720FE40", VA = "0x187211440", Slot = "13")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000BD")]
	public Vector3 ECIDGPFBLAC
	{
		[Cpp2IlInjected.Token(Token = "0x600030D")]
		[Cpp2IlInjected.Address(RVA = "0x7212010", Offset = "0x7210A10", VA = "0x187212010", Slot = "14")]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x600030E")]
		[Cpp2IlInjected.Address(RVA = "0x7212270", Offset = "0x7210C70", VA = "0x187212270", Slot = "15")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000BE")]
	public float ADIOGPKDCDC
	{
		[Cpp2IlInjected.Token(Token = "0x600030F")]
		[Cpp2IlInjected.Address(RVA = "0x9ECD50", Offset = "0x9EB750", VA = "0x1809ECD50", Slot = "16")]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x6000310")]
		[Cpp2IlInjected.Address(RVA = "0x7211500", Offset = "0x720FF00", VA = "0x187211500", Slot = "17")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000BF")]
	public bool MAPNACMJLIJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000311")]
		[Cpp2IlInjected.Address(RVA = "0x1A33A70", Offset = "0x1A32470", VA = "0x181A33A70", Slot = "18")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000C0")]
	private HLBPPEDLPKE JOCHECABLBO
	{
		[Cpp2IlInjected.Token(Token = "0x6000326")]
		[Cpp2IlInjected.Address(RVA = "0x6A22000", Offset = "0x6A20A00", VA = "0x186A22000")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000C1")]
	private bool HCGHFFMIFAI
	{
		[Cpp2IlInjected.Token(Token = "0x6000327")]
		[Cpp2IlInjected.Address(RVA = "0x7212C90", Offset = "0x7211690", VA = "0x187212C90")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000312")]
	[Cpp2IlInjected.Address(RVA = "0x7214240", Offset = "0x7212C40", VA = "0x187214240")]
	public MCHPBOJPJLM(HJICKIEKHCB PPHDEPKLLOK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000313")]
	[Cpp2IlInjected.Address(RVA = "0x72122A0", Offset = "0x7210CA0", VA = "0x1872122A0", Slot = "19")]
	public void IMJENBPCPEE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000314")]
	[Cpp2IlInjected.Address(RVA = "0x7211AF0", Offset = "0x72104F0", VA = "0x187211AF0", Slot = "36")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000315")]
	[Cpp2IlInjected.Address(RVA = "0x7212140", Offset = "0x7210B40", VA = "0x187212140", Slot = "28")]
	public void GENJEMJACDM(Rigidbody BBHGIADMCFO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000316")]
	[Cpp2IlInjected.Address(RVA = "0xEC9240", Offset = "0xEC7C40", VA = "0x180EC9240", Slot = "20")]
	public void COFDPCCFMHM(object KLGLJKMNAIM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000317")]
	[Cpp2IlInjected.Address(RVA = "0xEC7D60", Offset = "0xEC6760", VA = "0x180EC7D60", Slot = "30")]
	public void NMLFPIBCHPM(object KLGLJKMNAIM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000318")]
	[Cpp2IlInjected.Address(RVA = "0x7212AB0", Offset = "0x72114B0", VA = "0x187212AB0", Slot = "35")]
	public Vector3 JHNNDLBNDDF(Vector3 IACJOJBIIMH)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000319")]
	[Cpp2IlInjected.Address(RVA = "0x72133F0", Offset = "0x7211DF0", VA = "0x1872133F0", Slot = "34")]
	public Vector3 LMNMAMIHNPF(Vector3 OHJOFKNMAIN)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x600031A")]
	[Cpp2IlInjected.Address(RVA = "0x72122A0", Offset = "0x7210CA0", VA = "0x1872122A0", Slot = "27")]
	public void PDDPELNLBLF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600031B")]
	[Cpp2IlInjected.Address(RVA = "0x7211610", Offset = "0x7210010", VA = "0x187211610", Slot = "25")]
	public void DEPFEIPKFNH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600031C")]
	[Cpp2IlInjected.Address(RVA = "0x7212A50", Offset = "0x7211450", VA = "0x187212A50", Slot = "24")]
	public void JEBKIEAIHCJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600031D")]
	[Cpp2IlInjected.Address(RVA = "0x7210C50", Offset = "0x720F650", VA = "0x187210C50", Slot = "33")]
	public void AJAFIDJFFLO(Vector3 EMGHCEJLGLC, Vector3 KJKLMOGLNDO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600031E")]
	[Cpp2IlInjected.Address(RVA = "0x7211B50", Offset = "0x7210550", VA = "0x187211B50", Slot = "32")]
	public void ELGBIIGBNKJ(Vector3 HPJCGHLPDFH, Vector3 AGNGOBCJFND)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600031F")]
	[Cpp2IlInjected.Address(RVA = "0x7213130", Offset = "0x7211B30", VA = "0x187213130", Slot = "31")]
	public void LFJNIAENKID(Vector3 LFFDCABHEON)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000320")]
	[Cpp2IlInjected.Address(RVA = "0x7212340", Offset = "0x7210D40", VA = "0x187212340", Slot = "22")]
	public void IOIBEGCCJIK(HBBOOGIPJMD FFJEGHOFDPM, Vector3 EMGGJFAEADN, float CPAMMGNNLIK, float FANFOKDGIAB = 8f, float CDKGJFKHGOO = 1f)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000321")]
	[Cpp2IlInjected.Address(RVA = "0x72138C0", Offset = "0x72122C0", VA = "0x1872138C0", Slot = "21")]
	public void NFEHHOPLBFI(JENDIECHPBG EDKHDNCHGOP, Vector3 BNLBDJCNEIC, float OBBKOHIDJFD = float.PositiveInfinity)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000322")]
	[Cpp2IlInjected.Address(RVA = "0x7211670", Offset = "0x7210070", VA = "0x187211670", Slot = "23")]
	[Obsolete("Deprecated. Still exists to support deprecated CV2 chips. Use ApplyAngularVelocityChange.")]
	public void DFNDJDNAENI(JENDIECHPBG EDKHDNCHGOP, Vector3 FJFNLINEAKI, float ELILELMDMOP = 7f, float NHPMFBAHPKH = 1f)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000323")]
	[Cpp2IlInjected.Address(RVA = "0xFBE6C0", Offset = "0xFBD0C0", VA = "0x180FBE6C0")]
	private static void IPOPIAMAEGO(Vector3 NJFMAFAPHLI, Vector3 BELBOBCMBGH, [Out] Vector3 NFOBDABEEAI, [Out] Vector3 HLBKODLHLII)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000324")]
	[Cpp2IlInjected.Address(RVA = "0x72136D0", Offset = "0x72120D0", VA = "0x1872136D0", Slot = "29")]
	public Vector3 MDNPJINCMNB(Vector3 NJFMAFAPHLI)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000325")]
	[Cpp2IlInjected.Address(RVA = "0x7213C00", Offset = "0x7212600", VA = "0x187213C00", Slot = "26")]
	public void OCFNMMFLADB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000328")]
	[Cpp2IlInjected.Address(RVA = "0x7211500", Offset = "0x720FF00", VA = "0x187211500")]
	private void LADGAFLDHKH(float CLMKDBDPNNH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000329")]
	[Cpp2IlInjected.Address(RVA = "0x7211BB0", Offset = "0x72105B0", VA = "0x187211BB0")]
	private void EPPHAFICHBJ(Vector3 BNLBDJCNEIC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600032A")]
	[Cpp2IlInjected.Address(RVA = "0x72137B0", Offset = "0x72121B0", VA = "0x1872137B0")]
	private Vector3 MFICPIDNALL()
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x600032B")]
	[Cpp2IlInjected.Address(RVA = "0x7213DC0", Offset = "0x72127C0", VA = "0x187213DC0")]
	private void OJLAANOFMBO(Vector3 OHJOFKNMAIN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600032C")]
	[Cpp2IlInjected.Address(RVA = "0x72132D0", Offset = "0x7211CD0", VA = "0x1872132D0")]
	private Vector3 LIINOOCIIKD()
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x600032D")]
	[Cpp2IlInjected.Address(RVA = "0x7212CB0", Offset = "0x72116B0", VA = "0x187212CB0")]
	private void KMHICJLHCFB(Vector3 CLMKDBDPNNH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600032E")]
	[Cpp2IlInjected.Address(RVA = "0x7210E90", Offset = "0x720F890", VA = "0x187210E90")]
	private void BCJMGBMKJMJ(Vector3 OHJOFKNMAIN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600032F")]
	[Cpp2IlInjected.Address(RVA = "0x7213B50", Offset = "0x7212550", VA = "0x187213B50")]
	private void OAALJFCKMJH()
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
