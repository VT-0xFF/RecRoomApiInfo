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
	public class LogRegistrationIndex : MHGCIIOBNMD
	{
		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(RVA = "0x6FFC3B0", Offset = "0x6FFA9B0", VA = "0x186FFC3B0", Slot = "4")]
		public override void OOMCOBOGONK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0x8878E0", Offset = "0x885EE0", VA = "0x1808878E0")]
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
	public class _AssemblyIndex : KHELACBDANM
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000001")]
		private int[] localIndices0;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000002")]
		private DDEOLOLNDJP bitset0;

		[Cpp2IlInjected.Token(Token = "0x17000001")]
		public override string[] ServiceCategories
		{
			[Cpp2IlInjected.Token(Token = "0x6000003")]
			[Cpp2IlInjected.Address(RVA = "0x860D20", Offset = "0x85F320", VA = "0x180860D20", Slot = "4")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x15D4770", Offset = "0x15D2D70", VA = "0x1815D4770", Slot = "5")]
		public override void ENKMMKDBHKM(List<int> globalFromLocalIndices)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x70051E0", Offset = "0x70037E0", VA = "0x1870051E0")]
		private void COCKNKCMPAG(AOOOFDNBGDI registry)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x70054F0", Offset = "0x7003AF0", VA = "0x1870054F0", Slot = "6")]
		public override void MGOLIABDFGJ(AOOOFDNBGDI registry, [In] ADBFLCOCMBA filter)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x85E9E0", Offset = "0x85CFE0", VA = "0x18085E9E0", Slot = "8")]
		public override void PEGDOCGMNBF(FEIKJFAIAHC registry)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x7005550", Offset = "0x7003B50", VA = "0x187005550")]
		public _AssemblyIndex()
		{
		}
	}
}
namespace RecRoom
{
	[Cpp2IlInjected.Token(Token = "0x2000004")]
	[DisallowMultipleComponent]
	public sealed class RigidbodyEx : MonoBehaviour, ANCEECHCKHO
	{
		[Cpp2IlInjected.Token(Token = "0x4000004")]
		private static readonly CHNLCLDOCNE IGGOALLIJJF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000005")]
		private bool JOCHMLCGCJJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000006")]
		private BDAEKEEHGON KFPNPFEKAIL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000007")]
		[SerializeField]
		[CBGPCMFFECF(NABHOIFJJJN.Self, false, false, false)]
		private Rigidbody unityRigidbody;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000008")]
		[SerializeField]
		[CBGPCMFFECF(NABHOIFJJJN.SelfAndParent, true, false, false)]
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
		private HOEMCLDCGOB physicsInterpolation;

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
		internal BDAEKEEHGON MBBFMFILBML
		{
			[Cpp2IlInjected.Token(Token = "0x6000009")]
			[Cpp2IlInjected.Address(RVA = "0x7000910", Offset = "0x6FFEF10", VA = "0x187000910")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000003")]
		private BDAEKEEHGON NDLFOMPHOHC
		{
			[Cpp2IlInjected.Token(Token = "0x600000A")]
			[Cpp2IlInjected.Address(RVA = "0x85F450", Offset = "0x85DA50", VA = "0x18085F450", Slot = "6")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000004")]
		public int PLPMCDFJDOD
		{
			[Cpp2IlInjected.Token(Token = "0x600001E")]
			[Cpp2IlInjected.Address(RVA = "0x7002650", Offset = "0x7000C50", VA = "0x187002650")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000005")]
		public RigidbodyEx JCOJNLBJODC
		{
			[Cpp2IlInjected.Token(Token = "0x6000020")]
			[Cpp2IlInjected.Address(RVA = "0x70029B0", Offset = "0x7000FB0", VA = "0x1870029B0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000006")]
		public RigidbodyEx OCNEBKEFEDB
		{
			[Cpp2IlInjected.Token(Token = "0x6000021")]
			[Cpp2IlInjected.Address(RVA = "0x70028F0", Offset = "0x7000EF0", VA = "0x1870028F0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000007")]
		public RigidbodyEx LPFOFJIMHOE
		{
			[Cpp2IlInjected.Token(Token = "0x6000022")]
			[Cpp2IlInjected.Address(RVA = "0x7003650", Offset = "0x7001C50", VA = "0x187003650")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000023")]
			[Cpp2IlInjected.Address(RVA = "0x7004B50", Offset = "0x7003150", VA = "0x187004B50")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000008")]
		public Transform LIKDFIBLFOD
		{
			[Cpp2IlInjected.Token(Token = "0x6000024")]
			[Cpp2IlInjected.Address(RVA = "0x886A40", Offset = "0x885040", VA = "0x180886A40", Slot = "9")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000009")]
		public Transform HGAMEGLJOKJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000025")]
			[Cpp2IlInjected.Address(RVA = "0x886A40", Offset = "0x885040", VA = "0x180886A40", Slot = "10")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000A")]
		public MDEPBKMBPJG DGIDMBPBBIB
		{
			[Cpp2IlInjected.Token(Token = "0x6000026")]
			[Cpp2IlInjected.Address(RVA = "0x70026B0", Offset = "0x7000CB0", VA = "0x1870026B0")]
			get
			{
				return default(MDEPBKMBPJG);
			}
			[Cpp2IlInjected.Token(Token = "0x6000027")]
			[Cpp2IlInjected.Address(RVA = "0x7004300", Offset = "0x7002900", VA = "0x187004300")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000B")]
		public bool EHDKHGMLCIH
		{
			[Cpp2IlInjected.Token(Token = "0x6000028")]
			[Cpp2IlInjected.Address(RVA = "0x7002CC0", Offset = "0x70012C0", VA = "0x187002CC0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000C")]
		public bool GLELLFOFKJP
		{
			[Cpp2IlInjected.Token(Token = "0x6000029")]
			[Cpp2IlInjected.Address(RVA = "0x70027D0", Offset = "0x7000DD0", VA = "0x1870027D0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000D")]
		public JJIBDEODFOK GMKEMPMJJEG
		{
			[Cpp2IlInjected.Token(Token = "0x600002A")]
			[Cpp2IlInjected.Address(RVA = "0x7002C00", Offset = "0x7001200", VA = "0x187002C00")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600002B")]
			[Cpp2IlInjected.Address(RVA = "0x70044C0", Offset = "0x7002AC0", VA = "0x1870044C0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000E")]
		public FPCFKNJLJNF MEECOILDIGD
		{
			[Cpp2IlInjected.Token(Token = "0x600002C")]
			[Cpp2IlInjected.Address(RVA = "0x7002BA0", Offset = "0x70011A0", VA = "0x187002BA0")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600002D")]
			[Cpp2IlInjected.Address(RVA = "0x7004450", Offset = "0x7002A50", VA = "0x187004450")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000F")]
		public bool DMKJEPELOOK
		{
			[Cpp2IlInjected.Token(Token = "0x600002E")]
			[Cpp2IlInjected.Address(RVA = "0x7002AF0", Offset = "0x70010F0", VA = "0x187002AF0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000010")]
		public Rigidbody HMDFBMEBLAA
		{
			[Cpp2IlInjected.Token(Token = "0x600002F")]
			[Cpp2IlInjected.Address(RVA = "0x7002B50", Offset = "0x7001150", VA = "0x187002B50")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000011")]
		public bool AGLKOCOGMJP
		{
			[Cpp2IlInjected.Token(Token = "0x6000030")]
			[Cpp2IlInjected.Address(RVA = "0x7002830", Offset = "0x7000E30", VA = "0x187002830")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000031")]
			[Cpp2IlInjected.Address(RVA = "0x7004370", Offset = "0x7002970", VA = "0x187004370")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000012")]
		public bool AFBKMPKAOFE
		{
			[Cpp2IlInjected.Token(Token = "0x6000032")]
			[Cpp2IlInjected.Address(RVA = "0x6CD9350", Offset = "0x6CD7950", VA = "0x186CD9350", Slot = "7")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000013")]
		public float HLNMHMOBALL
		{
			[Cpp2IlInjected.Token(Token = "0x6000033")]
			[Cpp2IlInjected.Address(RVA = "0x70035F0", Offset = "0x7001BF0", VA = "0x1870035F0")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000014")]
		public float PKMEAMKOGOD
		{
			[Cpp2IlInjected.Token(Token = "0x6000034")]
			[Cpp2IlInjected.Address(RVA = "0x7003590", Offset = "0x7001B90", VA = "0x187003590")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x6000035")]
			[Cpp2IlInjected.Address(RVA = "0x7004AE0", Offset = "0x70030E0", VA = "0x187004AE0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000015")]
		public float MCJJGNAOPFB
		{
			[Cpp2IlInjected.Token(Token = "0x6000036")]
			[Cpp2IlInjected.Address(RVA = "0x7002F20", Offset = "0x7001520", VA = "0x187002F20")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x6000037")]
			[Cpp2IlInjected.Address(RVA = "0x7004760", Offset = "0x7002D60", VA = "0x187004760")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000016")]
		public float OLLDGKMLIHF
		{
			[Cpp2IlInjected.Token(Token = "0x6000038")]
			[Cpp2IlInjected.Address(RVA = "0x7002D20", Offset = "0x7001320", VA = "0x187002D20")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x6000039")]
			[Cpp2IlInjected.Address(RVA = "0x7004530", Offset = "0x7002B30", VA = "0x187004530")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000017")]
		public bool HOHNFOAFBJM
		{
			[Cpp2IlInjected.Token(Token = "0x600003A")]
			[Cpp2IlInjected.Address(RVA = "0x7003BA0", Offset = "0x70021A0", VA = "0x187003BA0")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x600003B")]
			[Cpp2IlInjected.Address(RVA = "0x7005090", Offset = "0x7003690", VA = "0x187005090")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000018")]
		public Vector3 BJBGMHCPJJH
		{
			[Cpp2IlInjected.Token(Token = "0x600003C")]
			[Cpp2IlInjected.Address(RVA = "0x7003370", Offset = "0x7001970", VA = "0x187003370")]
			get
			{
				return default(Vector3);
			}
			[Cpp2IlInjected.Token(Token = "0x600003D")]
			[Cpp2IlInjected.Address(RVA = "0x70048B0", Offset = "0x7002EB0", VA = "0x1870048B0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000019")]
		public Vector3 PGHCLMADGPJ
		{
			[Cpp2IlInjected.Token(Token = "0x600003E")]
			[Cpp2IlInjected.Address(RVA = "0x7003CE0", Offset = "0x70022E0", VA = "0x187003CE0")]
			get
			{
				return default(Vector3);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001A")]
		public CollisionDetectionMode DDAMOJPONMK
		{
			[Cpp2IlInjected.Token(Token = "0x600003F")]
			[Cpp2IlInjected.Address(RVA = "0x7002E60", Offset = "0x7001460", VA = "0x187002E60")]
			get
			{
				return default(CollisionDetectionMode);
			}
			[Cpp2IlInjected.Token(Token = "0x6000040")]
			[Cpp2IlInjected.Address(RVA = "0x7004680", Offset = "0x7002C80", VA = "0x187004680")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001B")]
		public float HLEAJEMEJIJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000041")]
			[Cpp2IlInjected.Address(RVA = "0x7002890", Offset = "0x7000E90", VA = "0x187002890")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x6000042")]
			[Cpp2IlInjected.Address(RVA = "0x70043E0", Offset = "0x70029E0", VA = "0x1870043E0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001C")]
		public RigidbodyConstraints MCCMJELOOAG
		{
			[Cpp2IlInjected.Token(Token = "0x6000043")]
			[Cpp2IlInjected.Address(RVA = "0x7002EC0", Offset = "0x70014C0", VA = "0x187002EC0")]
			get
			{
				return default(RigidbodyConstraints);
			}
			[Cpp2IlInjected.Token(Token = "0x6000044")]
			[Cpp2IlInjected.Address(RVA = "0x70046F0", Offset = "0x7002CF0", VA = "0x1870046F0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001D")]
		public Vector3 IOPLIOBEEGI
		{
			[Cpp2IlInjected.Token(Token = "0x6000045")]
			[Cpp2IlInjected.Address(RVA = "0x7003710", Offset = "0x7001D10", VA = "0x187003710")]
			get
			{
				return default(Vector3);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001E")]
		public Vector3 IKDEBEOBMHJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000046")]
			[Cpp2IlInjected.Address(RVA = "0x7003710", Offset = "0x7001D10", VA = "0x187003710")]
			get
			{
				return default(Vector3);
			}
			[Cpp2IlInjected.Token(Token = "0x6000047")]
			[Cpp2IlInjected.Address(RVA = "0x7004E70", Offset = "0x7003470", VA = "0x187004E70")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001F")]
		public float HOECGDLPKFB
		{
			[Cpp2IlInjected.Token(Token = "0x6000048")]
			[Cpp2IlInjected.Address(RVA = "0x7003450", Offset = "0x7001A50", VA = "0x187003450")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x6000049")]
			[Cpp2IlInjected.Address(RVA = "0x7004990", Offset = "0x7002F90", VA = "0x187004990")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000020")]
		public float KPCMOMEKPNL
		{
			[Cpp2IlInjected.Token(Token = "0x600004A")]
			[Cpp2IlInjected.Address(RVA = "0x7003B40", Offset = "0x7002140", VA = "0x187003B40")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x600004B")]
			[Cpp2IlInjected.Address(RVA = "0x7005020", Offset = "0x7003620", VA = "0x187005020")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000021")]
		public Quaternion LCNOBLPKFMI
		{
			[Cpp2IlInjected.Token(Token = "0x600004C")]
			[Cpp2IlInjected.Address(RVA = "0x70037F0", Offset = "0x7001DF0", VA = "0x1870037F0")]
			get
			{
				return default(Quaternion);
			}
			[Cpp2IlInjected.Token(Token = "0x600004D")]
			[Cpp2IlInjected.Address(RVA = "0x7004BF0", Offset = "0x70031F0", VA = "0x187004BF0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000022")]
		public Quaternion KNKMDIONIIB
		{
			[Cpp2IlInjected.Token(Token = "0x600004E")]
			[Cpp2IlInjected.Address(RVA = "0x7003A70", Offset = "0x7002070", VA = "0x187003A70")]
			get
			{
				return default(Quaternion);
			}
			[Cpp2IlInjected.Token(Token = "0x600004F")]
			[Cpp2IlInjected.Address(RVA = "0x7004F50", Offset = "0x7003550", VA = "0x187004F50")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000023")]
		public Vector3 CPOCJJHHDJO
		{
			[Cpp2IlInjected.Token(Token = "0x6000050")]
			[Cpp2IlInjected.Address(RVA = "0x70038C0", Offset = "0x7001EC0", VA = "0x1870038C0")]
			get
			{
				return default(Vector3);
			}
			[Cpp2IlInjected.Token(Token = "0x6000051")]
			[Cpp2IlInjected.Address(RVA = "0x7004CC0", Offset = "0x70032C0", VA = "0x187004CC0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000024")]
		public Quaternion IDIJCNJOKNE
		{
			[Cpp2IlInjected.Token(Token = "0x6000052")]
			[Cpp2IlInjected.Address(RVA = "0x70039A0", Offset = "0x7001FA0", VA = "0x1870039A0")]
			get
			{
				return default(Quaternion);
			}
			[Cpp2IlInjected.Token(Token = "0x6000053")]
			[Cpp2IlInjected.Address(RVA = "0x7004DA0", Offset = "0x70033A0", VA = "0x187004DA0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000025")]
		public Vector3 FPMFPAANFEC
		{
			[Cpp2IlInjected.Token(Token = "0x6000054")]
			[Cpp2IlInjected.Address(RVA = "0x7003C00", Offset = "0x7002200", VA = "0x187003C00")]
			get
			{
				return default(Vector3);
			}
			[Cpp2IlInjected.Token(Token = "0x6000055")]
			[Cpp2IlInjected.Address(RVA = "0x7005100", Offset = "0x7003700", VA = "0x187005100")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000026")]
		public Vector3 DOEHELKGDBK
		{
			[Cpp2IlInjected.Token(Token = "0x6000056")]
			[Cpp2IlInjected.Address(RVA = "0x70034B0", Offset = "0x7001AB0", VA = "0x1870034B0")]
			get
			{
				return default(Vector3);
			}
			[Cpp2IlInjected.Token(Token = "0x6000057")]
			[Cpp2IlInjected.Address(RVA = "0x7004A00", Offset = "0x7003000", VA = "0x187004A00")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000027")]
		public Vector3 LMLHIBOJPPE
		{
			[Cpp2IlInjected.Token(Token = "0x6000058")]
			[Cpp2IlInjected.Address(RVA = "0x7002D80", Offset = "0x7001380", VA = "0x187002D80")]
			get
			{
				return default(Vector3);
			}
			[Cpp2IlInjected.Token(Token = "0x6000059")]
			[Cpp2IlInjected.Address(RVA = "0x70045A0", Offset = "0x7002BA0", VA = "0x1870045A0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000028")]
		public Vector3 AAPEKCHOAIG
		{
			[Cpp2IlInjected.Token(Token = "0x600005A")]
			[Cpp2IlInjected.Address(RVA = "0x7003290", Offset = "0x7001890", VA = "0x187003290")]
			get
			{
				return default(Vector3);
			}
			[Cpp2IlInjected.Token(Token = "0x600005B")]
			[Cpp2IlInjected.Address(RVA = "0x70047D0", Offset = "0x7002DD0", VA = "0x1870047D0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000029")]
		public Vector3 BNCGIMNGHFM
		{
			[Cpp2IlInjected.Token(Token = "0x600005C")]
			[Cpp2IlInjected.Address(RVA = "0x7003150", Offset = "0x7001750", VA = "0x187003150")]
			get
			{
				return default(Vector3);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002A")]
		public Quaternion DOAAEBNGDCF
		{
			[Cpp2IlInjected.Token(Token = "0x600005D")]
			[Cpp2IlInjected.Address(RVA = "0x7003080", Offset = "0x7001680", VA = "0x187003080")]
			get
			{
				return default(Quaternion);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002B")]
		public Vector3 BADGFBKANPC
		{
			[Cpp2IlInjected.Token(Token = "0x600005F")]
			[Cpp2IlInjected.Address(RVA = "0x7003EA0", Offset = "0x70024A0", VA = "0x187003EA0")]
			get
			{
				return default(Vector3);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002C")]
		public Vector3 LDAFIBPDEHD
		{
			[Cpp2IlInjected.Token(Token = "0x6000060")]
			[Cpp2IlInjected.Address(RVA = "0x7003DC0", Offset = "0x70023C0", VA = "0x187003DC0")]
			get
			{
				return default(Vector3);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002D")]
		public bool DMPOCDBICIM
		{
			[Cpp2IlInjected.Token(Token = "0x6000061")]
			[Cpp2IlInjected.Address(RVA = "0x7003230", Offset = "0x7001830", VA = "0x187003230")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002E")]
		public bool MPLEAFKELNL
		{
			[Cpp2IlInjected.Token(Token = "0x6000062")]
			[Cpp2IlInjected.Address(RVA = "0x7002C60", Offset = "0x7001260", VA = "0x187002C60")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002F")]
		public bool GECNJNGMDAL
		{
			[Cpp2IlInjected.Token(Token = "0x6000063")]
			[Cpp2IlInjected.Address(RVA = "0x7002770", Offset = "0x7000D70", VA = "0x187002770")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000030")]
		public bool DPLEPDCPCGJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000064")]
			[Cpp2IlInjected.Address(RVA = "0x7002710", Offset = "0x7000D10", VA = "0x187002710")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000031")]
		public bool OOJJHNGGBPC
		{
			[Cpp2IlInjected.Token(Token = "0x6000065")]
			[Cpp2IlInjected.Address(RVA = "0x70025F0", Offset = "0x7000BF0", VA = "0x1870025F0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000032")]
		public bool PAGDEHFGOMJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000066")]
			[Cpp2IlInjected.Address(RVA = "0x7002F80", Offset = "0x7001580", VA = "0x187002F80")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000033")]
		public bool JJGAJOKOGGL
		{
			[Cpp2IlInjected.Token(Token = "0x6000067")]
			[Cpp2IlInjected.Address(RVA = "0x1849660", Offset = "0x1847C60", VA = "0x181849660")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000001")]
		public event HFEPOIKNCFH KHOMHPPDFAL
		{
			[Cpp2IlInjected.Token(Token = "0x600000E")]
			[Cpp2IlInjected.Address(RVA = "0x7002510", Offset = "0x7000B10", VA = "0x187002510")]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x600000F")]
			[Cpp2IlInjected.Address(RVA = "0x7004220", Offset = "0x7002820", VA = "0x187004220")]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000002")]
		public event MNDKPJKMNOG ACOCHEILPHM
		{
			[Cpp2IlInjected.Token(Token = "0x6000010")]
			[Cpp2IlInjected.Address(RVA = "0x7002280", Offset = "0x7000880", VA = "0x187002280")]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000011")]
			[Cpp2IlInjected.Address(RVA = "0x7003F80", Offset = "0x7002580", VA = "0x187003F80")]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000003")]
		public event MNDKPJKMNOG BIJKDBLOKGF
		{
			[Cpp2IlInjected.Token(Token = "0x6000012")]
			[Cpp2IlInjected.Address(RVA = "0x70022E0", Offset = "0x70008E0", VA = "0x1870022E0")]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000013")]
			[Cpp2IlInjected.Address(RVA = "0x7003FF0", Offset = "0x70025F0", VA = "0x187003FF0")]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000004")]
		public event MNDKPJKMNOG GPBIOKEPNGO
		{
			[Cpp2IlInjected.Token(Token = "0x6000014")]
			[Cpp2IlInjected.Address(RVA = "0x7002430", Offset = "0x7000A30", VA = "0x187002430")]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000015")]
			[Cpp2IlInjected.Address(RVA = "0x7004140", Offset = "0x7002740", VA = "0x187004140")]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000005")]
		public event Action<GHLGGPNNOMD, GHLGGPNNOMD> JNNGKLBDCAB
		{
			[Cpp2IlInjected.Token(Token = "0x6000016")]
			[Cpp2IlInjected.Address(RVA = "0x70023C0", Offset = "0x70009C0", VA = "0x1870023C0")]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000017")]
			[Cpp2IlInjected.Address(RVA = "0x70040D0", Offset = "0x70026D0", VA = "0x1870040D0")]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000006")]
		public event MNDKPJKMNOG EIEAAPPDBAO
		{
			[Cpp2IlInjected.Token(Token = "0x6000018")]
			[Cpp2IlInjected.Address(RVA = "0x70024A0", Offset = "0x7000AA0", VA = "0x1870024A0")]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000019")]
			[Cpp2IlInjected.Address(RVA = "0x70041B0", Offset = "0x70027B0", VA = "0x1870041B0")]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000007")]
		public event MNDKPJKMNOG APECLJABCLK
		{
			[Cpp2IlInjected.Token(Token = "0x600001A")]
			[Cpp2IlInjected.Address(RVA = "0x7002580", Offset = "0x7000B80", VA = "0x187002580")]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x600001B")]
			[Cpp2IlInjected.Address(RVA = "0x7004290", Offset = "0x7002890", VA = "0x187004290")]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000008")]
		public event MNDKPJKMNOG CNBAGDCHLAB
		{
			[Cpp2IlInjected.Token(Token = "0x600001C")]
			[Cpp2IlInjected.Address(RVA = "0x7002350", Offset = "0x7000950", VA = "0x187002350")]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x600001D")]
			[Cpp2IlInjected.Address(RVA = "0x7004060", Offset = "0x7002660", VA = "0x187004060")]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x85F460", Offset = "0x85DA60", VA = "0x18085F460", Slot = "8")]
		private void PPMEGLEHNEJ(BDAEKEEHGON ADLOKNICHMI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x6FFFE60", Offset = "0x6FFE460", VA = "0x186FFFE60")]
		internal void AKKJBEHLHDB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x7001FB0", Offset = "0x70005B0", VA = "0x187001FB0")]
		[Conditional("UNITY_EDITOR")]
		[Conditional("DEBUG_BUILD")]
		public void TestOverrideUnityRigidbody(Rigidbody OCKDCCCLIOA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x7000BA0", Offset = "0x6FFF1A0", VA = "0x187000BA0")]
		public ANCEECHCKHO GetChild(int EBDMAJMOJLN)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600005E")]
		[Cpp2IlInjected.Address(RVA = "0x7001C80", Offset = "0x7000280", VA = "0x187001C80")]
		public void SetInertiaTensor((Quaternion rot, Vector3 moments) JEIDJBGOPFO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000068")]
		[Cpp2IlInjected.Address(RVA = "0x70008A0", Offset = "0x6FFEEA0", VA = "0x1870008A0")]
		private void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000069")]
		[Cpp2IlInjected.Address(RVA = "0x7000910", Offset = "0x6FFEF10", VA = "0x187000910")]
		private BDAEKEEHGON BAKLJPCPLHK()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600006A")]
		[Cpp2IlInjected.Address(RVA = "0x7000E50", Offset = "0x6FFF450", VA = "0x187000E50")]
		private void HACFLNNNDIG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006B")]
		[Cpp2IlInjected.Address(RVA = "0x7001450", Offset = "0x6FFFA50", VA = "0x187001450")]
		private void OnEnable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006C")]
		[Cpp2IlInjected.Address(RVA = "0x6FFFE60", Offset = "0x6FFE460", VA = "0x186FFFE60")]
		private void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006D")]
		[Cpp2IlInjected.Address(RVA = "0x70013F0", Offset = "0x6FFF9F0", VA = "0x1870013F0")]
		private void OnDrawGizmosSelected()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006E")]
		[Cpp2IlInjected.Address(RVA = "0x70014B0", Offset = "0x6FFFAB0", VA = "0x1870014B0")]
		private void OnValidate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006F")]
		[Cpp2IlInjected.Address(RVA = "0x6FFFEF0", Offset = "0x6FFE4F0", VA = "0x186FFFEF0")]
		public void AddDoNotResetVelocityOnOwnershipChangeOverride(object PNPIGCGKNPI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000070")]
		[Cpp2IlInjected.Address(RVA = "0x7001510", Offset = "0x6FFFB10", VA = "0x187001510")]
		public void RemoveDoNotResetVelocityOnOwnershipChangeOverride(object PNPIGCGKNPI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000071")]
		[Cpp2IlInjected.Address(RVA = "0x7000B40", Offset = "0x6FFF140", VA = "0x187000B40")]
		public void DisableCachedInertialPropertyOverride()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000072")]
		[Cpp2IlInjected.Address(RVA = "0x7001390", Offset = "0x6FFF990", VA = "0x187001390")]
		public void MarkCachedInertialParametersDirty()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000073")]
		[Cpp2IlInjected.Address(RVA = "0x7001DE0", Offset = "0x70003E0", VA = "0x187001DE0")]
		public void SetParent(RigidbodyEx FEBGGALLBNN, bool JBFNJGDBMCB = false)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000074")]
		[Cpp2IlInjected.Address(RVA = "0x7001820", Offset = "0x6FFFE20", VA = "0x187001820")]
		public void ResetLocalCenterOfMassToPrefabDefault()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000075")]
		[Cpp2IlInjected.Address(RVA = "0x7001060", Offset = "0x6FFF660", VA = "0x187001060")]
		public bool IsRigidbodyAncestor(RigidbodyEx FHIAACOGJEA)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000076")]
		[Cpp2IlInjected.Address(RVA = "0x7001140", Offset = "0x6FFF740", VA = "0x187001140")]
		public bool IsRigidbodyDescendant(RigidbodyEx MDFKJKGONGF)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000077")]
		[Cpp2IlInjected.Address(RVA = "0x7000160", Offset = "0x6FFE760", VA = "0x187000160")]
		public void AddInterpolationRestriction(object PNPIGCGKNPI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000078")]
		[Cpp2IlInjected.Address(RVA = "0x7001580", Offset = "0x6FFFB80", VA = "0x187001580")]
		public void RemoveInterpolationRestriction(object PNPIGCGKNPI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000079")]
		[Cpp2IlInjected.Address(RVA = "0x70001D0", Offset = "0x6FFE7D0", VA = "0x1870001D0")]
		public void AddKinematic(object PNPIGCGKNPI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007A")]
		[Cpp2IlInjected.Address(RVA = "0x70015F0", Offset = "0x6FFFBF0", VA = "0x1870015F0")]
		public void RemoveKinematic(object PNPIGCGKNPI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007B")]
		[Cpp2IlInjected.Address(RVA = "0x7001D60", Offset = "0x7000360", VA = "0x187001D60")]
		public void SetKinematic(object PNPIGCGKNPI, bool JIJGAKFGIEE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007C")]
		[Cpp2IlInjected.Address(RVA = "0x7001B80", Offset = "0x7000180", VA = "0x187001B80")]
		public void SetDiscontinuousPositionAndRotation(Vector3 FAJCABGFGFI, Quaternion ANPHIIHKJAC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007D")]
		[Cpp2IlInjected.Address(RVA = "0x7001A80", Offset = "0x7000080", VA = "0x187001A80")]
		public void SetDiscontinuousLocalPositionAndLocalRotation(Vector3 PHFIAHNNOJK, Quaternion FONGLNADHHP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007E")]
		[Cpp2IlInjected.Address(RVA = "0x7000D40", Offset = "0x6FFF340", VA = "0x187000D40")]
		public Vector3 GetConstrainedVelocity(Vector3 FPMFPAANFEC)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x600007F")]
		[Cpp2IlInjected.Address(RVA = "0x7000C30", Offset = "0x6FFF230", VA = "0x187000C30")]
		public Vector3 GetConstrainedAngularVelocity(Vector3 LMLHIBOJPPE)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x6000080")]
		[Cpp2IlInjected.Address(RVA = "0x7000070", Offset = "0x6FFE670", VA = "0x187000070")]
		public void AddForce(Vector3 EFJJGJMLHPN, ForceMode CDGNLODPNML = ForceMode.Force)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000081")]
		[Cpp2IlInjected.Address(RVA = "0x6FFFF60", Offset = "0x6FFE560", VA = "0x186FFFF60")]
		public void AddForceAtPosition(Vector3 EFJJGJMLHPN, Vector3 LPBGBJBIAOJ, ForceMode CDGNLODPNML)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000082")]
		[Cpp2IlInjected.Address(RVA = "0x70003A0", Offset = "0x6FFE9A0", VA = "0x1870003A0")]
		public void AddTorque(Vector3 MJDDAPLCJDP, ForceMode CDGNLODPNML = ForceMode.Force)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000083")]
		[Cpp2IlInjected.Address(RVA = "0x7000240", Offset = "0x6FFE840", VA = "0x187000240")]
		public void AddRelativeTorque(Vector3 MJDDAPLCJDP, ForceMode CDGNLODPNML = ForceMode.Force)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000084")]
		[Cpp2IlInjected.Address(RVA = "0x7002080", Offset = "0x7000680", VA = "0x187002080")]
		public Vector3 WorldToLocalVelocity(Vector3 FGAFOHDCFPB)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x6000085")]
		[Cpp2IlInjected.Address(RVA = "0x7001280", Offset = "0x6FFF880", VA = "0x187001280")]
		public Vector3 LocalToWorldVelocity(Vector3 DOEHELKGDBK)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x6000086")]
		[Cpp2IlInjected.Address(RVA = "0x7000AE0", Offset = "0x6FFF0E0", VA = "0x187000AE0")]
		public void ClearVelocity()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000087")]
		[Cpp2IlInjected.Address(RVA = "0x7000A80", Offset = "0x6FFF080", VA = "0x187000A80")]
		public void ClearUnityRigidbodyVelocity()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000088")]
		[Cpp2IlInjected.Address(RVA = "0x7000A20", Offset = "0x6FFF020", VA = "0x187000A20")]
		public void ClearLinearVelocity()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000089")]
		[Cpp2IlInjected.Address(RVA = "0x70009C0", Offset = "0x6FFEFC0", VA = "0x1870009C0")]
		public void ClearAngularVelocity()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008A")]
		[Cpp2IlInjected.Address(RVA = "0x7001980", Offset = "0x6FFFF80", VA = "0x187001980")]
		public void ResetVelocityWorldSpace(Vector3 CAJPCDAIFIP, Vector3 CHILFEFILCK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008B")]
		[Cpp2IlInjected.Address(RVA = "0x7001880", Offset = "0x6FFFE80", VA = "0x187001880")]
		public void ResetVelocityLocalSpace(Vector3 HLJCNLEDNPM, Vector3 AAPEKCHOAIG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008C")]
		[Cpp2IlInjected.Address(RVA = "0x7001740", Offset = "0x6FFFD40", VA = "0x187001740")]
		public void ResetLinearVelocityLocalSpace(Vector3 HLJCNLEDNPM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008D")]
		[Cpp2IlInjected.Address(RVA = "0x7001F10", Offset = "0x7000510", VA = "0x187001F10")]
		public bool SweepTest(Vector3 MJBOPHFMANN, [Out] RaycastHit NKJBDBKJJDK, float FJJNLOMPHKA)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600008E")]
		[Cpp2IlInjected.Address(RVA = "0x7001220", Offset = "0x6FFF820", VA = "0x187001220")]
		public bool IsSleeping()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600008F")]
		[Cpp2IlInjected.Address(RVA = "0x7001EB0", Offset = "0x70004B0", VA = "0x187001EB0")]
		public void Sleep()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000090")]
		[Cpp2IlInjected.Address(RVA = "0x7002020", Offset = "0x7000620", VA = "0x187002020")]
		public void WakeUp()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000091")]
		[Cpp2IlInjected.Address(RVA = "0x7000330", Offset = "0x6FFE930", VA = "0x187000330")]
		public void AddShouldHaveUnityRigidbodyToken(object PNPIGCGKNPI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000092")]
		[Cpp2IlInjected.Address(RVA = "0x7001660", Offset = "0x6FFFC60", VA = "0x187001660")]
		public void RemoveShouldHaveUnityRigidbodyToken(object PNPIGCGKNPI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000093")]
		[Cpp2IlInjected.Address(RVA = "0x7000730", Offset = "0x6FFED30", VA = "0x187000730")]
		public void ApplyForceVelocityChange(ICCPFOEOBPC NHNBBPPCADG, Vector3 NIHMGKDKFLI, float GFCGIPHILDG, float AMJDFLLFOGG = 8f, float NMPDDKIDGKC = 1f)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000094")]
		[Cpp2IlInjected.Address(RVA = "0x7000630", Offset = "0x6FFEC30", VA = "0x187000630")]
		public void ApplyAngularVelocityChange(IBINHLJGAJL EDEBFCKHCOB, Vector3 BDOGOHDDNFF, float PGHAPCLIBGC = float.PositiveInfinity)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000095")]
		[Cpp2IlInjected.Address(RVA = "0x70007F0", Offset = "0x6FFEDF0", VA = "0x1870007F0")]
		[Obsolete("Deprecated. Still exists to support deprecated CV2 chips. Use ApplyAngularVelocityChange.")]
		public void ApplyTorqueAngularVelocityChangeDeprecated(IBINHLJGAJL EDEBFCKHCOB, Vector3 CNNBBFFJNHM, float JNOOKKEDJLJ = 7f, float GPKBFHCKJJI = 1f)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000096")]
		[Cpp2IlInjected.Address(RVA = "0x7000560", Offset = "0x6FFEB60", VA = "0x187000560")]
		public bool AllowedScaleChange(float PMPLECFBFFL)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000097")]
		[Cpp2IlInjected.Address(RVA = "0x7000490", Offset = "0x6FFEA90", VA = "0x187000490")]
		public void AddWorldSpaceVelocityInHierarchyParentOverride(RigidbodyEx HPIMGJKGFPO, object PNPIGCGKNPI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000098")]
		[Cpp2IlInjected.Address(RVA = "0x70016D0", Offset = "0x6FFFCD0", VA = "0x1870016D0")]
		public void RemoveWorldSpaceVelocityInHierarchyParentOverride(object PNPIGCGKNPI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000099")]
		[Cpp2IlInjected.Address(RVA = "0x7002210", Offset = "0x7000810", VA = "0x187002210")]
		public RigidbodyEx()
		{
		}

		[SpecialName]
		[Cpp2IlInjected.Token(Token = "0x600009B")]
		[Cpp2IlInjected.Address(RVA = "0xA2BBF0", Offset = "0xA2A1F0", VA = "0x180A2BBF0", Slot = "4")]
		private GameObject ONKBBFEDKBB()
		{
			return null;
		}

		[SpecialName]
		[Cpp2IlInjected.Token(Token = "0x600009C")]
		[Cpp2IlInjected.Address(RVA = "0x886A40", Offset = "0x885040", VA = "0x180886A40", Slot = "5")]
		private Transform LKCNODNECJD()
		{
			return null;
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
internal static class EEJNHLABCIH
{
	[Cpp2IlInjected.Token(Token = "0x600009D")]
	[Cpp2IlInjected.Address(RVA = "0x6FF4650", Offset = "0x6FF2C50", VA = "0x186FF4650")]
	public static BDAEKEEHGON MBBFMFILBML(this RigidbodyEx KOPJPDIAFKF)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
[EGEIKMOFAOL(typeof(MNKFGLGCPDN), new string[] { })]
public class GPOOKFENIGM : MNKFGLGCPDN, CPCIADPOEEL
{
	[Cpp2IlInjected.Token(Token = "0x400000F")]
	private static readonly CHNLCLDOCNE CNCAEGCNGHI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000010")]
	private HCMBBKNLLDK JDNFGCIGAOK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000011")]
	private OIKJBDAOBMF FGMBCEGOCBB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000012")]
	private HIACBNIDNKB CDGBAHFNDFG;

	[Cpp2IlInjected.Token(Token = "0x17000034")]
	public OIKJBDAOBMF NMJFDBBPKEI
	{
		[Cpp2IlInjected.Token(Token = "0x600009E")]
		[Cpp2IlInjected.Address(RVA = "0x85F4F0", Offset = "0x85DAF0", VA = "0x18085F4F0", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000035")]
	public HIACBNIDNKB DMMMHPOIONN
	{
		[Cpp2IlInjected.Token(Token = "0x600009F")]
		[Cpp2IlInjected.Address(RVA = "0x85F450", Offset = "0x85DA50", VA = "0x18085F450", Slot = "5")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000A0")]
	[Cpp2IlInjected.Address(RVA = "0x6FF7C90", Offset = "0x6FF6290", VA = "0x186FF7C90", Slot = "7")]
	public void InitReferences(CBLPEPBNIEA DIJICJLLCHO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A1")]
	[Cpp2IlInjected.Address(RVA = "0x6FF7C00", Offset = "0x6FF6200", VA = "0x186FF7C00", Slot = "6")]
	public BDAEKEEHGON CDLFPPCMJPP(RigidbodyEx KOPJPDIAFKF, AHJPEDECEFI JHLEMCFOEMF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000A2")]
	[Cpp2IlInjected.Address(RVA = "0x8692F0", Offset = "0x8678F0", VA = "0x1808692F0")]
	public GPOOKFENIGM()
	{
	}
}
namespace RecRoom
{
	[Cpp2IlInjected.Token(Token = "0x2000007")]
	public class PhysicsManager : SingletonMonoBehaviour<PhysicsManager>
	{
		[Cpp2IlInjected.Token(Token = "0x4000013")]
		public static CLOBMDANPDK UpdateAfterFixedUpdateRan;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000014")]
		private int CMMKBJKODIM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x4000015")]
		private int KJJOIDEBADA;

		[Cpp2IlInjected.Token(Token = "0x60000A4")]
		[Cpp2IlInjected.Address(RVA = "0x6FFFCE0", Offset = "0x6FFE2E0", VA = "0x186FFFCE0")]
		protected void FixedUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A5")]
		[Cpp2IlInjected.Address(RVA = "0x6FFFD20", Offset = "0x6FFE320", VA = "0x186FFFD20")]
		protected void Update()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A6")]
		[Cpp2IlInjected.Address(RVA = "0x6FFFD00", Offset = "0x6FFE300", VA = "0x186FFFD00")]
		protected void LateUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A7")]
		[Cpp2IlInjected.Address(RVA = "0x85E9E0", Offset = "0x85CFE0", VA = "0x18085E9E0")]
		[Conditional("UNITY_ASSERTIONS")]
		public void AssertLateColliderPositionsNotYetUpdated([Optional] string DICMABMCPKO, [Optional] UnityEngine.Object MGIHCPMKPNG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A8")]
		[Cpp2IlInjected.Address(RVA = "0x85E9E0", Offset = "0x85CFE0", VA = "0x18085E9E0")]
		[Conditional("UNITY_ASSERTIONS")]
		public void AssertLateColliderPositionsAlreadyUpdated([Optional] string DICMABMCPKO, [Optional] UnityEngine.Object MGIHCPMKPNG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A9")]
		[Cpp2IlInjected.Address(RVA = "0x6FFFE10", Offset = "0x6FFE410", VA = "0x186FFFE10")]
		public PhysicsManager()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
public static class JDAEALGFKBO
{
	[Cpp2IlInjected.Token(Token = "0x2000009")]
	private class ANFDDHCMFOG : JJIBDEODFOK, IDisposable
	{
		[Cpp2IlInjected.Token(Token = "0x60000AD")]
		[Cpp2IlInjected.Address(RVA = "0x85E9E0", Offset = "0x85CFE0", VA = "0x18085E9E0", Slot = "6")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AE")]
		[Cpp2IlInjected.Address(RVA = "0x86DB80", Offset = "0x86C180", VA = "0x18086DB80", Slot = "4")]
		public Vector3 FOMECJMECIJ()
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x60000AF")]
		[Cpp2IlInjected.Address(RVA = "0x86DB80", Offset = "0x86C180", VA = "0x18086DB80", Slot = "5")]
		public Vector3 BGJOGMDFAOJ()
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x60000B0")]
		[Cpp2IlInjected.Address(RVA = "0x8692F0", Offset = "0x8678F0", VA = "0x1808692F0")]
		public ANFDDHCMFOG()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000036")]
	public static JJIBDEODFOK FAJEJIPBOMK
	{
		[Cpp2IlInjected.Token(Token = "0x60000AB")]
		[Cpp2IlInjected.Address(RVA = "0x6FFAEF0", Offset = "0x6FF94F0", VA = "0x186FFAEF0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
public interface BBHIJCOHKBE
{
	[Cpp2IlInjected.Token(Token = "0x17000037")]
	CollisionDetectionMode LMNBDKLEKHE
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
	void BMDHDEMLIBC();

	[Cpp2IlInjected.Token(Token = "0x60000B4")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void BGAGCJAIAEP(bool DMPOCDBICIM);

	[Cpp2IlInjected.Token(Token = "0x60000B5")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void GADJCALBALL(bool DMPOCDBICIM);

	[Cpp2IlInjected.Token(Token = "0x60000B6")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void OJJJHIEHGGE(Rigidbody NNDHPDBLJFB);

	[Cpp2IlInjected.Token(Token = "0x60000B7")]
	[Cpp2IlInjected.Address(Slot = "6")]
	bool LMCIDJHMOFI(Vector3 MJBOPHFMANN, [Out] RaycastHit NKJBDBKJJDK, float FJJNLOMPHKA);
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
public interface DBHCAHODFGJ : IDisposable, FKONIPBKDNE
{
	[Cpp2IlInjected.Token(Token = "0x17000038")]
	MDEPBKMBPJG DGIDMBPBBIB
	{
		[Cpp2IlInjected.Token(Token = "0x60000BA")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
		[Cpp2IlInjected.Token(Token = "0x60000BB")]
		[Cpp2IlInjected.Address(Slot = "3")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x14000009")]
	event Action<GHLGGPNNOMD, GHLGGPNNOMD> JNNGKLBDCAB;

	[Cpp2IlInjected.Token(Token = "0x60000BC")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void BMDHDEMLIBC();
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
[KOJHAGOLJDJ(EEHOEHJJGBB.Application)]
public interface HIACBNIDNKB
{
	[Cpp2IlInjected.Token(Token = "0x60000BD")]
	[Cpp2IlInjected.Address(Slot = "0")]
	GMDDLFLGAPG DHMBCBMDMGO(BDAEKEEHGON ADLOKNICHMI);

	[Cpp2IlInjected.Token(Token = "0x60000BE")]
	[Cpp2IlInjected.Address(Slot = "1")]
	EHMADKKELDA GFCNECICBKO(BDAEKEEHGON ADLOKNICHMI);

	[Cpp2IlInjected.Token(Token = "0x60000BF")]
	[Cpp2IlInjected.Address(Slot = "2")]
	FBEBDGAEMPK NACJCMPJFOE(BDAEKEEHGON ADLOKNICHMI);

	[Cpp2IlInjected.Token(Token = "0x60000C0")]
	[Cpp2IlInjected.Address(Slot = "3")]
	MJNCCHHAJHB MINNKMLNGFN(BDAEKEEHGON ADLOKNICHMI);

	[Cpp2IlInjected.Token(Token = "0x60000C1")]
	[Cpp2IlInjected.Address(Slot = "4")]
	CEKFDCFDGNB IMKLFCHBDHP(BDAEKEEHGON ADLOKNICHMI);

	[Cpp2IlInjected.Token(Token = "0x60000C2")]
	[Cpp2IlInjected.Address(Slot = "5")]
	DBHCAHODFGJ PPEMDIBIOBD(BDAEKEEHGON ADLOKNICHMI);

	[Cpp2IlInjected.Token(Token = "0x60000C3")]
	[Cpp2IlInjected.Address(Slot = "6")]
	PKBHNJMBMCL ELIEDKLFJOF(BDAEKEEHGON ADLOKNICHMI);

	[Cpp2IlInjected.Token(Token = "0x60000C4")]
	[Cpp2IlInjected.Address(Slot = "7")]
	EICNHMNGDHM DHJMPJJBCDH(BDAEKEEHGON ADLOKNICHMI);

	[Cpp2IlInjected.Token(Token = "0x60000C5")]
	[Cpp2IlInjected.Address(Slot = "8")]
	BBHIJCOHKBE KGFPGIKGIKA(BDAEKEEHGON ADLOKNICHMI);

	[Cpp2IlInjected.Token(Token = "0x60000C6")]
	[Cpp2IlInjected.Address(Slot = "9")]
	GNHKGALPOEN CEFAANOIGCG(BDAEKEEHGON ADLOKNICHMI);

	[Cpp2IlInjected.Token(Token = "0x60000C7")]
	[Cpp2IlInjected.Address(Slot = "10")]
	CHEAFKNGDNE KDLPLJFJGPB(BDAEKEEHGON ADLOKNICHMI, [In] AHJPEDECEFI JHLEMCFOEMF);

	[Cpp2IlInjected.Token(Token = "0x60000C8")]
	[Cpp2IlInjected.Address(Slot = "11")]
	HCMIIMNCCNN HOPJADMEONB(BDAEKEEHGON ADLOKNICHMI, [In] AHJPEDECEFI JHLEMCFOEMF);

	[Cpp2IlInjected.Token(Token = "0x60000C9")]
	[Cpp2IlInjected.Address(Slot = "12")]
	KILAKAEDOED HOMIKMJODAI(BDAEKEEHGON ADLOKNICHMI, [In] AHJPEDECEFI JHLEMCFOEMF);

	[Cpp2IlInjected.Token(Token = "0x60000CA")]
	[Cpp2IlInjected.Address(Slot = "13")]
	ALGPKHEMHDL LPGLMGJKDBI(BDAEKEEHGON ADLOKNICHMI, [In] AHJPEDECEFI JHLEMCFOEMF);

	[Cpp2IlInjected.Token(Token = "0x60000CB")]
	[Cpp2IlInjected.Address(Slot = "14")]
	FNAIMHFAGCI MDKILNCHICP(BDAEKEEHGON ADLOKNICHMI, [In] AHJPEDECEFI JHLEMCFOEMF);

	[Cpp2IlInjected.Token(Token = "0x60000CC")]
	[Cpp2IlInjected.Address(Slot = "15")]
	BDAEKEEHGON CDLFPPCMJPP(RigidbodyEx KOPJPDIAFKF, AHJPEDECEFI JHLEMCFOEMF, MNKFGLGCPDN FHLJNPENEDC);
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
public interface EICNHMNGDHM
{
	[Cpp2IlInjected.Token(Token = "0x60000CD")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void KJHEFIHDMOK(Vector3 EFJJGJMLHPN, ForceMode CDGNLODPNML = ForceMode.Force);

	[Cpp2IlInjected.Token(Token = "0x60000CE")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void HGEALHKPEMK(Vector3 EFJJGJMLHPN, Vector3 LPBGBJBIAOJ, ForceMode CDGNLODPNML);

	[Cpp2IlInjected.Token(Token = "0x60000CF")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void GAALLOJPDLM(Vector3 MJDDAPLCJDP, ForceMode CDGNLODPNML = ForceMode.Force);

	[Cpp2IlInjected.Token(Token = "0x60000D0")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void FKDKHMNINIC(Vector3 MJDDAPLCJDP, ForceMode CDGNLODPNML = ForceMode.Force);
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
public interface GNHKGALPOEN
{
	[Cpp2IlInjected.Token(Token = "0x17000039")]
	bool KNDBLJIACGF
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
	void OJJJHIEHGGE(Rigidbody NNDHPDBLJFB);

	[Cpp2IlInjected.Token(Token = "0x60000D4")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void LFIMDILEDOP(Rigidbody NNDHPDBLJFB);
}
[Cpp2IlInjected.Token(Token = "0x200000F")]
public interface GMDDLFLGAPG : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x1700003A")]
	IReadOnlyList<BDAEKEEHGON> FMKBBFGPKPL
	{
		[Cpp2IlInjected.Token(Token = "0x60000E7")]
		[Cpp2IlInjected.Address(Slot = "18")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700003B")]
	BDAEKEEHGON OCNEBKEFEDB
	{
		[Cpp2IlInjected.Token(Token = "0x60000E8")]
		[Cpp2IlInjected.Address(Slot = "19")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700003C")]
	BDAEKEEHGON LFKOPKGONIM
	{
		[Cpp2IlInjected.Token(Token = "0x60000E9")]
		[Cpp2IlInjected.Address(Slot = "20")]
		get;
		[Cpp2IlInjected.Token(Token = "0x60000EA")]
		[Cpp2IlInjected.Address(Slot = "21")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x1400000A")]
	event MNDKPJKMNOG ACOCHEILPHM;

	[Cpp2IlInjected.Token(Token = "0x1400000B")]
	event MNDKPJKMNOG BIJKDBLOKGF;

	[Cpp2IlInjected.Token(Token = "0x1400000C")]
	event HFEPOIKNCFH NGCAAJLOGBI;

	[Cpp2IlInjected.Token(Token = "0x1400000D")]
	event Action CLGCKNHBPHG;

	[Cpp2IlInjected.Token(Token = "0x1400000E")]
	event Action PNELJAKBMCL;

	[Cpp2IlInjected.Token(Token = "0x1400000F")]
	event Action<BDAEKEEHGON> GIKJBKFPFMC;

	[Cpp2IlInjected.Token(Token = "0x14000010")]
	event Action<BDAEKEEHGON> HOJBEIODCKM;

	[Cpp2IlInjected.Token(Token = "0x14000011")]
	event Action MGDPNGCLNJN;

	[Cpp2IlInjected.Token(Token = "0x14000012")]
	event Action<BDAEKEEHGON> OJKPCFGGKGP;

	[Cpp2IlInjected.Token(Token = "0x60000EB")]
	[Cpp2IlInjected.Address(Slot = "22")]
	void PPDMAPLEIEK(BDAEKEEHGON MFKKDCMMKOI, bool JBFNJGDBMCB = false);
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
public interface FBEBDGAEMPK
{
	[Cpp2IlInjected.Token(Token = "0x1700003D")]
	Vector3 MBNEMFLDGLF
	{
		[Cpp2IlInjected.Token(Token = "0x60000EC")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700003E")]
	Vector3 JIDNBMIAHAL
	{
		[Cpp2IlInjected.Token(Token = "0x60000ED")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x60000EE")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void PFEFGJCPNIN(BDAEKEEHGON LPFOFJIMHOE, object PNPIGCGKNPI);

	[Cpp2IlInjected.Token(Token = "0x60000EF")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void KDIFJCGLFHF(object PNPIGCGKNPI);
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
public interface ALGPKHEMHDL
{
	[Cpp2IlInjected.Token(Token = "0x1700003F")]
	Vector3 DKFJOMAEDCO
	{
		[Cpp2IlInjected.Token(Token = "0x60000F2")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
		[Cpp2IlInjected.Token(Token = "0x60000F3")]
		[Cpp2IlInjected.Address(Slot = "3")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000040")]
	Vector3 NNPFPFLIHDA
	{
		[Cpp2IlInjected.Token(Token = "0x60000F4")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000041")]
	float FAFJBOGBGHI
	{
		[Cpp2IlInjected.Token(Token = "0x60000F5")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000042")]
	float DJJBDPNNBOM
	{
		[Cpp2IlInjected.Token(Token = "0x60000F6")]
		[Cpp2IlInjected.Address(Slot = "6")]
		get;
		[Cpp2IlInjected.Token(Token = "0x60000F7")]
		[Cpp2IlInjected.Address(Slot = "7")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000043")]
	Vector3 OHGBKDNCJHD
	{
		[Cpp2IlInjected.Token(Token = "0x60000F8")]
		[Cpp2IlInjected.Address(Slot = "8")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000044")]
	Quaternion ICNCCFLKKGO
	{
		[Cpp2IlInjected.Token(Token = "0x60000F9")]
		[Cpp2IlInjected.Address(Slot = "9")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x14000013")]
	event MNDKPJKMNOG BCAMIMJCLBJ;

	[Cpp2IlInjected.Token(Token = "0x60000FA")]
	[Cpp2IlInjected.Address(Slot = "10")]
	void OJOCLKHEPKG((Quaternion rot, Vector3 moments) JEIDJBGOPFO);

	[Cpp2IlInjected.Token(Token = "0x60000FB")]
	[Cpp2IlInjected.Address(Slot = "11")]
	void CEGIPIKKAML();

	[Cpp2IlInjected.Token(Token = "0x60000FC")]
	[Cpp2IlInjected.Address(Slot = "12")]
	void MANHEMLKMJP();

	[Cpp2IlInjected.Token(Token = "0x60000FD")]
	[Cpp2IlInjected.Address(Slot = "13")]
	void PKPJPBHGIOD();

	[Cpp2IlInjected.Token(Token = "0x60000FE")]
	[Cpp2IlInjected.Address(Slot = "14")]
	void OJJJHIEHGGE(Rigidbody NNDHPDBLJFB);

	[Cpp2IlInjected.Token(Token = "0x60000FF")]
	[Cpp2IlInjected.Address(Slot = "15")]
	void LFIMDILEDOP(Rigidbody NNDHPDBLJFB);

	[Cpp2IlInjected.Token(Token = "0x6000100")]
	[Cpp2IlInjected.Address(Slot = "16")]
	void KGKHPNFCOID();
}
[Cpp2IlInjected.Token(Token = "0x2000012")]
public interface KILAKAEDOED
{
	[Cpp2IlInjected.Token(Token = "0x6000101")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void BMDHDEMLIBC();

	[Cpp2IlInjected.Token(Token = "0x6000102")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void MJAFCHMPHGA(object PNPIGCGKNPI);

	[Cpp2IlInjected.Token(Token = "0x6000103")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void EFBIFBGHHAM(object PNPIGCGKNPI);

	[Cpp2IlInjected.Token(Token = "0x6000104")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void KLJIPHLEHAH(BDAEKEEHGON KOPJPDIAFKF);

	[Cpp2IlInjected.Token(Token = "0x6000105")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void BIGDEABKMLM(BDAEKEEHGON KOPJPDIAFKF);

	[Cpp2IlInjected.Token(Token = "0x6000106")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void CFEKKLAOCJH();
}
[Cpp2IlInjected.Token(Token = "0x2000013")]
public interface PKBHNJMBMCL
{
	[Cpp2IlInjected.Token(Token = "0x17000045")]
	bool NJMGKDGEJKC
	{
		[Cpp2IlInjected.Token(Token = "0x6000109")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x14000014")]
	event MNDKPJKMNOG ONOLPJLNMOJ;

	[Cpp2IlInjected.Token(Token = "0x600010A")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void DHONMCJFNPK(object PNPIGCGKNPI);

	[Cpp2IlInjected.Token(Token = "0x600010B")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void IFPKGBJENPI(object PNPIGCGKNPI);

	[Cpp2IlInjected.Token(Token = "0x600010C")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void PAEILMBBFPG(object PNPIGCGKNPI, bool JIJGAKFGIEE);

	[Cpp2IlInjected.Token(Token = "0x600010D")]
	[Cpp2IlInjected.Address(Slot = "6")]
	void OJJJHIEHGGE(Rigidbody KJDLJANECIL);

	[Cpp2IlInjected.Token(Token = "0x600010E")]
	[Cpp2IlInjected.Address(Slot = "7")]
	void LFIMDILEDOP(Rigidbody NNDHPDBLJFB);
}
[Cpp2IlInjected.Token(Token = "0x2000014")]
public interface HCMIIMNCCNN : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x17000046")]
	bool EHDKHGMLCIH
	{
		[Cpp2IlInjected.Token(Token = "0x6000111")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000047")]
	bool GLELLFOFKJP
	{
		[Cpp2IlInjected.Token(Token = "0x6000112")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x14000015")]
	event MNDKPJKMNOG JKJMDMPHJFN;

	[Cpp2IlInjected.Token(Token = "0x6000113")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void BMDHDEMLIBC();

	[Cpp2IlInjected.Token(Token = "0x6000114")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void AAICGDBFFIE(BDAEKEEHGON LPFOFJIMHOE);

	[Cpp2IlInjected.Token(Token = "0x6000115")]
	[Cpp2IlInjected.Address(Slot = "6")]
	void MKHPKMIJDKB(BDAEKEEHGON LPFOFJIMHOE);
}
[Cpp2IlInjected.Token(Token = "0x2000015")]
public interface FNAIMHFAGCI
{
	[Cpp2IlInjected.Token(Token = "0x17000048")]
	bool AGLKOCOGMJP
	{
		[Cpp2IlInjected.Token(Token = "0x6000116")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
		[Cpp2IlInjected.Token(Token = "0x6000117")]
		[Cpp2IlInjected.Address(Slot = "1")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000049")]
	bool OAPGJCKDFMM
	{
		[Cpp2IlInjected.Token(Token = "0x6000118")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700004A")]
	RigidbodyConstraints ENAJGFPFLFD
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
	void OJJJHIEHGGE(Rigidbody NNDHPDBLJFB);

	[Cpp2IlInjected.Token(Token = "0x600011C")]
	[Cpp2IlInjected.Address(Slot = "6")]
	void LFIMDILEDOP(Rigidbody NNDHPDBLJFB);
}
[Cpp2IlInjected.Token(Token = "0x2000016")]
public interface MJNCCHHAJHB
{
	[Cpp2IlInjected.Token(Token = "0x1700004B")]
	float EELOHFPMINJ
	{
		[Cpp2IlInjected.Token(Token = "0x600011D")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
		[Cpp2IlInjected.Token(Token = "0x600011E")]
		[Cpp2IlInjected.Address(Slot = "1")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x1700004C")]
	float EMANFDKKNOA
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
	void OJJJHIEHGGE(Rigidbody NNDHPDBLJFB);

	[Cpp2IlInjected.Token(Token = "0x6000122")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void LFIMDILEDOP(Rigidbody NNDHPDBLJFB);
}
[Cpp2IlInjected.Token(Token = "0x2000017")]
public interface CEKFDCFDGNB
{
	[Cpp2IlInjected.Token(Token = "0x14000016")]
	event MNDKPJKMNOG AFEKEEPHDEO;

	[Cpp2IlInjected.Token(Token = "0x6000125")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void BMDHDEMLIBC();

	[Cpp2IlInjected.Token(Token = "0x6000126")]
	[Cpp2IlInjected.Address(Slot = "3")]
	bool AOCFCKBPOGJ();

	[Cpp2IlInjected.Token(Token = "0x6000127")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void HONDKPAAEJK();

	[Cpp2IlInjected.Token(Token = "0x6000128")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void CAJEOIOLNEH();

	[Cpp2IlInjected.Token(Token = "0x6000129")]
	[Cpp2IlInjected.Address(Slot = "6")]
	void HLLLNIILIDL();

	[Cpp2IlInjected.Token(Token = "0x600012A")]
	[Cpp2IlInjected.Address(Slot = "7")]
	void KKPNCKGMGKM();
}
[Cpp2IlInjected.Token(Token = "0x2000018")]
public interface CHEAFKNGDNE
{
	[Cpp2IlInjected.Token(Token = "0x1700004D")]
	Rigidbody HMDFBMEBLAA
	{
		[Cpp2IlInjected.Token(Token = "0x600012B")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700004E")]
	bool NDPAFPHFDOG
	{
		[Cpp2IlInjected.Token(Token = "0x600012D")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x600012C")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void BMDHDEMLIBC();

	[Cpp2IlInjected.Token(Token = "0x600012E")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void LFGHNJFKEON(object PNPIGCGKNPI);

	[Cpp2IlInjected.Token(Token = "0x600012F")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void DPEPKDOFMAH(object PNPIGCGKNPI);

	[Cpp2IlInjected.Token(Token = "0x6000130")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void CAFLGPLMEIO();
}
[Cpp2IlInjected.Token(Token = "0x2000019")]
public interface EHMADKKELDA : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x1700004F")]
	JJIBDEODFOK GMKEMPMJJEG
	{
		[Cpp2IlInjected.Token(Token = "0x6000131")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
		[Cpp2IlInjected.Token(Token = "0x6000132")]
		[Cpp2IlInjected.Address(Slot = "1")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000050")]
	FPCFKNJLJNF MEECOILDIGD
	{
		[Cpp2IlInjected.Token(Token = "0x6000133")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
		[Cpp2IlInjected.Token(Token = "0x6000134")]
		[Cpp2IlInjected.Address(Slot = "3")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000051")]
	Vector3 BADJMEGCDHI
	{
		[Cpp2IlInjected.Token(Token = "0x6000135")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
		[Cpp2IlInjected.Token(Token = "0x6000136")]
		[Cpp2IlInjected.Address(Slot = "5")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000052")]
	Vector3 PICKJKOADLG
	{
		[Cpp2IlInjected.Token(Token = "0x6000137")]
		[Cpp2IlInjected.Address(Slot = "6")]
		get;
		[Cpp2IlInjected.Token(Token = "0x6000138")]
		[Cpp2IlInjected.Address(Slot = "7")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000053")]
	Vector3 LKOMBEBAIAN
	{
		[Cpp2IlInjected.Token(Token = "0x6000139")]
		[Cpp2IlInjected.Address(Slot = "8")]
		get;
		[Cpp2IlInjected.Token(Token = "0x600013A")]
		[Cpp2IlInjected.Address(Slot = "9")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000054")]
	Vector3 ABDFNNIMIHN
	{
		[Cpp2IlInjected.Token(Token = "0x600013B")]
		[Cpp2IlInjected.Address(Slot = "10")]
		get;
		[Cpp2IlInjected.Token(Token = "0x600013C")]
		[Cpp2IlInjected.Address(Slot = "11")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000055")]
	float HLEAJEMEJIJ
	{
		[Cpp2IlInjected.Token(Token = "0x600013D")]
		[Cpp2IlInjected.Address(Slot = "12")]
		get;
		[Cpp2IlInjected.Token(Token = "0x600013E")]
		[Cpp2IlInjected.Address(Slot = "13")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000056")]
	bool DMKJEPELOOK
	{
		[Cpp2IlInjected.Token(Token = "0x600013F")]
		[Cpp2IlInjected.Address(Slot = "14")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000140")]
	[Cpp2IlInjected.Address(Slot = "15")]
	void BMDHDEMLIBC();

	[Cpp2IlInjected.Token(Token = "0x6000141")]
	[Cpp2IlInjected.Address(Slot = "16")]
	void LAIONIMADAA(object PNPIGCGKNPI);

	[Cpp2IlInjected.Token(Token = "0x6000142")]
	[Cpp2IlInjected.Address(Slot = "17")]
	void IIDCCGIKHJM(IBINHLJGAJL EDEBFCKHCOB, Vector3 BDOGOHDDNFF, float PGHAPCLIBGC = float.PositiveInfinity);

	[Cpp2IlInjected.Token(Token = "0x6000143")]
	[Cpp2IlInjected.Address(Slot = "18")]
	void OHGAIHKHGIM(ICCPFOEOBPC NHNBBPPCADG, Vector3 NIHMGKDKFLI, float GFCGIPHILDG, float AMJDFLLFOGG = 8f, float NMPDDKIDGKC = 1f);

	[Cpp2IlInjected.Token(Token = "0x6000144")]
	[Cpp2IlInjected.Address(Slot = "19")]
	void GIJGAEIJIBG(IBINHLJGAJL EDEBFCKHCOB, Vector3 CNNBBFFJNHM, float JNOOKKEDJLJ = 7f, float GPKBFHCKJJI = 1f);

	[Cpp2IlInjected.Token(Token = "0x6000145")]
	[Cpp2IlInjected.Address(Slot = "20")]
	void JOIAPFKMNHH();

	[Cpp2IlInjected.Token(Token = "0x6000146")]
	[Cpp2IlInjected.Address(Slot = "21")]
	void FAHHCFFEONM();

	[Cpp2IlInjected.Token(Token = "0x6000147")]
	[Cpp2IlInjected.Address(Slot = "22")]
	void KOECGAKFNDD();

	[Cpp2IlInjected.Token(Token = "0x6000148")]
	[Cpp2IlInjected.Address(Slot = "23")]
	void OADDMHBKMMD();

	[Cpp2IlInjected.Token(Token = "0x6000149")]
	[Cpp2IlInjected.Address(Slot = "24")]
	void OJJJHIEHGGE(Rigidbody NNDHPDBLJFB);

	[Cpp2IlInjected.Token(Token = "0x600014A")]
	[Cpp2IlInjected.Address(Slot = "25")]
	Vector3 FONKOLKJNID(Vector3 FPMFPAANFEC);

	[Cpp2IlInjected.Token(Token = "0x600014B")]
	[Cpp2IlInjected.Address(Slot = "26")]
	void FNKAHOCOHKF(object PNPIGCGKNPI);

	[Cpp2IlInjected.Token(Token = "0x600014C")]
	[Cpp2IlInjected.Address(Slot = "27")]
	void KFJEPNEFPMA(Vector3 LNOIGBIBALG);

	[Cpp2IlInjected.Token(Token = "0x600014D")]
	[Cpp2IlInjected.Address(Slot = "28")]
	void IHKEKHHCCOO(Vector3 HLJCNLEDNPM, Vector3 AAPEKCHOAIG);

	[Cpp2IlInjected.Token(Token = "0x600014E")]
	[Cpp2IlInjected.Address(Slot = "29")]
	void ABBFOCFOCGJ(Vector3 CAJPCDAIFIP, Vector3 CHILFEFILCK);

	[Cpp2IlInjected.Token(Token = "0x600014F")]
	[Cpp2IlInjected.Address(Slot = "30")]
	Vector3 EILJJNPMFLF(Vector3 DOEHELKGDBK);

	[Cpp2IlInjected.Token(Token = "0x6000150")]
	[Cpp2IlInjected.Address(Slot = "31")]
	Vector3 OCHFKMGFHBD(Vector3 FGAFOHDCFPB);
}
[Cpp2IlInjected.Token(Token = "0x200001A")]
[KOJHAGOLJDJ(EEHOEHJJGBB.Application)]
public interface OIKJBDAOBMF
{
	[Cpp2IlInjected.Token(Token = "0x17000057")]
	bool FHKBOIJBFDE
	{
		[Cpp2IlInjected.Token(Token = "0x6000151")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000152")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void EPKDGNAKFDF(string BDGJCBKBDPI);

	[Cpp2IlInjected.Token(Token = "0x6000153")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void BAIBCJGODFG(RigidbodyEx KOPJPDIAFKF, Action IJDJHMGAIOM);

	[Cpp2IlInjected.Token(Token = "0x6000154")]
	[Cpp2IlInjected.Address(Slot = "3")]
	PIPECKGFBCF PGJHJLLIPID(int JJEBMIFHADL);

	[Cpp2IlInjected.Token(Token = "0x6000155")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void GBBLEANFMHN(Vector3 PGHCLMADGPJ, float GEAHJFMBJLC, Color KOEHPNBNNJJ);
}
[Cpp2IlInjected.Token(Token = "0x200001B")]
[KOJHAGOLJDJ(EEHOEHJJGBB.Application)]
public interface MNKFGLGCPDN
{
	[Cpp2IlInjected.Token(Token = "0x17000058")]
	OIKJBDAOBMF NMJFDBBPKEI
	{
		[Cpp2IlInjected.Token(Token = "0x6000156")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000059")]
	HIACBNIDNKB DMMMHPOIONN
	{
		[Cpp2IlInjected.Token(Token = "0x6000157")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000158")]
	[Cpp2IlInjected.Address(Slot = "2")]
	BDAEKEEHGON CDLFPPCMJPP(RigidbodyEx KOPJPDIAFKF, AHJPEDECEFI JHLEMCFOEMF);
}
[Cpp2IlInjected.Token(Token = "0x200001C")]
public class BHBLNBBNMEK : BDAEKEEHGON, IDisposable, KIMGMNFHPKC
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000017")]
	internal readonly MNKFGLGCPDN FHLJNPENEDC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000018")]
	internal GMDDLFLGAPG KHANDAEEOHM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000019")]
	internal KILAKAEDOED GJGKJAADKEF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400001A")]
	internal HCMIIMNCCNN MIMAPNPEGFK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400001B")]
	internal EHMADKKELDA FPMFPAANFEC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x400001C")]
	internal FBEBDGAEMPK JEPCBGFPPLC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x400001D")]
	internal ALGPKHEMHDL MGLHNHBDDKO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x400001E")]
	internal MJNCCHHAJHB EGKEBHDECAL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x400001F")]
	internal GNHKGALPOEN BKGFBGPHKFE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x4000020")]
	internal CEKFDCFDGNB FNEODAJMIFO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x4000021")]
	internal DBHCAHODFGJ CCHLCBAFELE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x4000022")]
	internal PKBHNJMBMCL KLEBMIGNEPH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x4000023")]
	internal EICNHMNGDHM EFJJGJMLHPN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
	[Cpp2IlInjected.Token(Token = "0x4000024")]
	internal FNAIMHFAGCI LOGOOIAMDDK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x4000025")]
	internal CHEAFKNGDNE NNDHPDBLJFB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
	[Cpp2IlInjected.Token(Token = "0x4000026")]
	internal BBHIJCOHKBE GLFCJBGABHB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
	[Cpp2IlInjected.Token(Token = "0x4000027")]
	internal IDisposable BFGAFLEBILL;

	[Cpp2IlInjected.Token(Token = "0x1700005A")]
	public GDINMDENPGG KCJNNFNPNPC
	{
		[Cpp2IlInjected.Token(Token = "0x6000159")]
		[Cpp2IlInjected.Address(RVA = "0x85E9F0", Offset = "0x85CFF0", VA = "0x18085E9F0", Slot = "22")]
		get
		{
			return default(GDINMDENPGG);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700005B")]
	public ANCEECHCKHO LCKACLIPLDI
	{
		[Cpp2IlInjected.Token(Token = "0x600015A")]
		[Cpp2IlInjected.Address(RVA = "0x861DB0", Offset = "0x8603B0", VA = "0x180861DB0", Slot = "24")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600015B")]
		[Cpp2IlInjected.Address(RVA = "0x861DC0", Offset = "0x8603C0", VA = "0x180861DC0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700005C")]
	public GameObject POPIEPFKLGG
	{
		[Cpp2IlInjected.Token(Token = "0x600015C")]
		[Cpp2IlInjected.Address(RVA = "0xB2BCF0", Offset = "0xB2A2F0", VA = "0x180B2BCF0", Slot = "25")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600015D")]
		[Cpp2IlInjected.Address(RVA = "0xAC6350", Offset = "0xAC4950", VA = "0x180AC6350")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700005D")]
	public Transform BFKELEPPJNO
	{
		[Cpp2IlInjected.Token(Token = "0x600015E")]
		[Cpp2IlInjected.Address(RVA = "0x6FEFC70", Offset = "0x6FEE270", VA = "0x186FEFC70", Slot = "26")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700005E")]
	public Rigidbody HMDFBMEBLAA
	{
		[Cpp2IlInjected.Token(Token = "0x600015F")]
		[Cpp2IlInjected.Address(RVA = "0x6FF1100", Offset = "0x6FEF700", VA = "0x186FF1100", Slot = "23")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700005F")]
	public BDAEKEEHGON LFKOPKGONIM
	{
		[Cpp2IlInjected.Token(Token = "0x600016D")]
		[Cpp2IlInjected.Address(RVA = "0x6FF2C30", Offset = "0x6FF1230", VA = "0x186FF2C30", Slot = "27")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600016E")]
		[Cpp2IlInjected.Address(RVA = "0x6FED970", Offset = "0x6FEBF70", VA = "0x186FED970", Slot = "28")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000060")]
	public int PLPMCDFJDOD
	{
		[Cpp2IlInjected.Token(Token = "0x600016F")]
		[Cpp2IlInjected.Address(RVA = "0x6FF3000", Offset = "0x6FF1600", VA = "0x186FF3000", Slot = "31")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000061")]
	public BDAEKEEHGON OCNEBKEFEDB
	{
		[Cpp2IlInjected.Token(Token = "0x6000171")]
		[Cpp2IlInjected.Address(RVA = "0x6FF2A90", Offset = "0x6FF1090", VA = "0x186FF2A90", Slot = "29")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000062")]
	public bool AOKPMFEJIHO
	{
		[Cpp2IlInjected.Token(Token = "0x6000172")]
		[Cpp2IlInjected.Address(RVA = "0x6FEEA50", Offset = "0x6FED050", VA = "0x186FEEA50", Slot = "138")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000063")]
	public bool EHDKHGMLCIH
	{
		[Cpp2IlInjected.Token(Token = "0x6000176")]
		[Cpp2IlInjected.Address(RVA = "0x6FF21D0", Offset = "0x6FF07D0", VA = "0x186FF21D0", Slot = "32")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000064")]
	public bool GLELLFOFKJP
	{
		[Cpp2IlInjected.Token(Token = "0x6000177")]
		[Cpp2IlInjected.Address(RVA = "0x6FF0F70", Offset = "0x6FEF570", VA = "0x186FF0F70", Slot = "33")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000065")]
	public JJIBDEODFOK GMKEMPMJJEG
	{
		[Cpp2IlInjected.Token(Token = "0x6000178")]
		[Cpp2IlInjected.Address(RVA = "0x6FF2AE0", Offset = "0x6FF10E0", VA = "0x186FF2AE0", Slot = "34")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000179")]
		[Cpp2IlInjected.Address(RVA = "0x6FF0F10", Offset = "0x6FEF510", VA = "0x186FF0F10", Slot = "35")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000066")]
	public FPCFKNJLJNF MEECOILDIGD
	{
		[Cpp2IlInjected.Token(Token = "0x600017A")]
		[Cpp2IlInjected.Address(RVA = "0x6FEE520", Offset = "0x6FECB20", VA = "0x186FEE520", Slot = "36")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600017B")]
		[Cpp2IlInjected.Address(RVA = "0x6FEE990", Offset = "0x6FECF90", VA = "0x186FEE990", Slot = "37")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000067")]
	public float HLEAJEMEJIJ
	{
		[Cpp2IlInjected.Token(Token = "0x600017C")]
		[Cpp2IlInjected.Address(RVA = "0x6FEF830", Offset = "0x6FEDE30", VA = "0x186FEF830", Slot = "38")]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x600017D")]
		[Cpp2IlInjected.Address(RVA = "0x6FF0FC0", Offset = "0x6FEF5C0", VA = "0x186FF0FC0", Slot = "39")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000068")]
	public Vector3 PICKJKOADLG
	{
		[Cpp2IlInjected.Token(Token = "0x600017E")]
		[Cpp2IlInjected.Address(RVA = "0x6FEE440", Offset = "0x6FECA40", VA = "0x186FEE440", Slot = "40")]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x600017F")]
		[Cpp2IlInjected.Address(RVA = "0x6FF1FD0", Offset = "0x6FF05D0", VA = "0x186FF1FD0", Slot = "41")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000069")]
	public Vector3 ABDFNNIMIHN
	{
		[Cpp2IlInjected.Token(Token = "0x6000180")]
		[Cpp2IlInjected.Address(RVA = "0x6FEF190", Offset = "0x6FED790", VA = "0x186FEF190", Slot = "42")]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x6000181")]
		[Cpp2IlInjected.Address(RVA = "0x6FEDF70", Offset = "0x6FEC570", VA = "0x186FEDF70", Slot = "43")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700006A")]
	public Vector3 BADJMEGCDHI
	{
		[Cpp2IlInjected.Token(Token = "0x6000182")]
		[Cpp2IlInjected.Address(RVA = "0x6FF0470", Offset = "0x6FEEA70", VA = "0x186FF0470", Slot = "44")]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x6000183")]
		[Cpp2IlInjected.Address(RVA = "0x6FF22C0", Offset = "0x6FF08C0", VA = "0x186FF22C0", Slot = "45")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700006B")]
	public Vector3 LKOMBEBAIAN
	{
		[Cpp2IlInjected.Token(Token = "0x6000184")]
		[Cpp2IlInjected.Address(RVA = "0x6FF29B0", Offset = "0x6FF0FB0", VA = "0x186FF29B0", Slot = "46")]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x6000185")]
		[Cpp2IlInjected.Address(RVA = "0x6FF1020", Offset = "0x6FEF620", VA = "0x186FF1020", Slot = "47")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700006C")]
	public bool GECNJNGMDAL
	{
		[Cpp2IlInjected.Token(Token = "0x6000186")]
		[Cpp2IlInjected.Address(RVA = "0x6FF1850", Offset = "0x6FEFE50", VA = "0x186FF1850", Slot = "139")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700006D")]
	public bool DPLEPDCPCGJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000187")]
		[Cpp2IlInjected.Address(RVA = "0x6FEF7D0", Offset = "0x6FEDDD0", VA = "0x186FEF7D0", Slot = "48")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700006E")]
	public bool OOJJHNGGBPC
	{
		[Cpp2IlInjected.Token(Token = "0x6000188")]
		[Cpp2IlInjected.Address(RVA = "0x6FF0330", Offset = "0x6FEE930", VA = "0x186FF0330", Slot = "49")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700006F")]
	public bool DMKJEPELOOK
	{
		[Cpp2IlInjected.Token(Token = "0x6000189")]
		[Cpp2IlInjected.Address(RVA = "0x6FF0C00", Offset = "0x6FEF200", VA = "0x186FF0C00", Slot = "50")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000070")]
	public Vector3 MBNEMFLDGLF
	{
		[Cpp2IlInjected.Token(Token = "0x600019A")]
		[Cpp2IlInjected.Address(RVA = "0x6FED9D0", Offset = "0x6FEBFD0", VA = "0x186FED9D0", Slot = "51")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000071")]
	public Vector3 JIDNBMIAHAL
	{
		[Cpp2IlInjected.Token(Token = "0x600019B")]
		[Cpp2IlInjected.Address(RVA = "0x6FF1EF0", Offset = "0x6FF04F0", VA = "0x186FF1EF0", Slot = "52")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000072")]
	public Vector3 DKFJOMAEDCO
	{
		[Cpp2IlInjected.Token(Token = "0x60001A0")]
		[Cpp2IlInjected.Address(RVA = "0x6FF2400", Offset = "0x6FF0A00", VA = "0x186FF2400", Slot = "53")]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x60001A1")]
		[Cpp2IlInjected.Address(RVA = "0x6FEE730", Offset = "0x6FECD30", VA = "0x186FEE730", Slot = "54")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000073")]
	public Vector3 NNPFPFLIHDA
	{
		[Cpp2IlInjected.Token(Token = "0x60001A2")]
		[Cpp2IlInjected.Address(RVA = "0x6FF2870", Offset = "0x6FF0E70", VA = "0x186FF2870", Slot = "55")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000074")]
	public float FAFJBOGBGHI
	{
		[Cpp2IlInjected.Token(Token = "0x60001A3")]
		[Cpp2IlInjected.Address(RVA = "0x6FF2180", Offset = "0x6FF0780", VA = "0x186FF2180", Slot = "56")]
		get
		{
			return default(float);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000075")]
	public float DJJBDPNNBOM
	{
		[Cpp2IlInjected.Token(Token = "0x60001A4")]
		[Cpp2IlInjected.Address(RVA = "0x6FEE5D0", Offset = "0x6FECBD0", VA = "0x186FEE5D0", Slot = "57")]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x60001A5")]
		[Cpp2IlInjected.Address(RVA = "0x6FF13D0", Offset = "0x6FEF9D0", VA = "0x186FF13D0", Slot = "58")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000076")]
	public Vector3 OHGBKDNCJHD
	{
		[Cpp2IlInjected.Token(Token = "0x60001A6")]
		[Cpp2IlInjected.Address(RVA = "0x6FF12A0", Offset = "0x6FEF8A0", VA = "0x186FF12A0", Slot = "59")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000077")]
	public Quaternion ICNCCFLKKGO
	{
		[Cpp2IlInjected.Token(Token = "0x60001A7")]
		[Cpp2IlInjected.Address(RVA = "0x6FF01A0", Offset = "0x6FEE7A0", VA = "0x186FF01A0", Slot = "60")]
		get
		{
			return default(Quaternion);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000078")]
	public float EELOHFPMINJ
	{
		[Cpp2IlInjected.Token(Token = "0x60001AC")]
		[Cpp2IlInjected.Address(RVA = "0x6FEF330", Offset = "0x6FED930", VA = "0x186FEF330", Slot = "62")]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x60001AD")]
		[Cpp2IlInjected.Address(RVA = "0x6FF23A0", Offset = "0x6FF09A0", VA = "0x186FF23A0", Slot = "63")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000079")]
	public float EMANFDKKNOA
	{
		[Cpp2IlInjected.Token(Token = "0x60001AE")]
		[Cpp2IlInjected.Address(RVA = "0x6FF1670", Offset = "0x6FEFC70", VA = "0x186FF1670", Slot = "64")]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x60001AF")]
		[Cpp2IlInjected.Address(RVA = "0x6FF2730", Offset = "0x6FF0D30", VA = "0x186FF2730", Slot = "65")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700007A")]
	public bool KNDBLJIACGF
	{
		[Cpp2IlInjected.Token(Token = "0x60001B0")]
		[Cpp2IlInjected.Address(RVA = "0x6FED4E0", Offset = "0x6FEBAE0", VA = "0x186FED4E0", Slot = "66")]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x60001B1")]
		[Cpp2IlInjected.Address(RVA = "0x6FED260", Offset = "0x6FEB860", VA = "0x186FED260", Slot = "67")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700007B")]
	public MDEPBKMBPJG DGIDMBPBBIB
	{
		[Cpp2IlInjected.Token(Token = "0x60001B9")]
		[Cpp2IlInjected.Address(RVA = "0x6FF1430", Offset = "0x6FEFA30", VA = "0x186FF1430", Slot = "68")]
		get
		{
			return default(MDEPBKMBPJG);
		}
		[Cpp2IlInjected.Token(Token = "0x60001BA")]
		[Cpp2IlInjected.Address(RVA = "0x6FF17A0", Offset = "0x6FEFDA0", VA = "0x186FF17A0", Slot = "69")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700007C")]
	public bool NJMGKDGEJKC
	{
		[Cpp2IlInjected.Token(Token = "0x60001BD")]
		[Cpp2IlInjected.Address(RVA = "0x6FF0BB0", Offset = "0x6FEF1B0", VA = "0x186FF0BB0", Slot = "70")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700007D")]
	public Transform HGAMEGLJOKJ
	{
		[Cpp2IlInjected.Token(Token = "0x60001C3")]
		[Cpp2IlInjected.Address(RVA = "0x6FEE050", Offset = "0x6FEC650", VA = "0x186FEE050", Slot = "71")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700007E")]
	public Vector3 MGAHFNPKCPK
	{
		[Cpp2IlInjected.Token(Token = "0x60001C4")]
		[Cpp2IlInjected.Address(RVA = "0x6FEE320", Offset = "0x6FEC920", VA = "0x186FEE320", Slot = "72")]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x60001C5")]
		[Cpp2IlInjected.Address(RVA = "0x6FEFD00", Offset = "0x6FEE300", VA = "0x186FEFD00", Slot = "73")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700007F")]
	public float LBBEJBKLJOG
	{
		[Cpp2IlInjected.Token(Token = "0x60001C6")]
		[Cpp2IlInjected.Address(RVA = "0x6FEE3D0", Offset = "0x6FEC9D0", VA = "0x186FEE3D0", Slot = "74")]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x60001C7")]
		[Cpp2IlInjected.Address(RVA = "0x6FEE920", Offset = "0x6FECF20", VA = "0x186FEE920", Slot = "75")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000080")]
	public float GHACPLMPLJB
	{
		[Cpp2IlInjected.Token(Token = "0x60001C8")]
		[Cpp2IlInjected.Address(RVA = "0x6FF1650", Offset = "0x6FEFC50", VA = "0x186FF1650", Slot = "76")]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x60001C9")]
		[Cpp2IlInjected.Address(RVA = "0x6FEF6D0", Offset = "0x6FEDCD0", VA = "0x186FEF6D0", Slot = "77")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000081")]
	public Quaternion FHCKJIIJEFP
	{
		[Cpp2IlInjected.Token(Token = "0x60001CA")]
		[Cpp2IlInjected.Address(RVA = "0x6FEF540", Offset = "0x6FEDB40", VA = "0x186FEF540", Slot = "78")]
		get
		{
			return default(Quaternion);
		}
		[Cpp2IlInjected.Token(Token = "0x60001CB")]
		[Cpp2IlInjected.Address(RVA = "0x6FF3070", Offset = "0x6FF1670", VA = "0x186FF3070", Slot = "79")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000082")]
	public Vector3 MCKPEAAMDKI
	{
		[Cpp2IlInjected.Token(Token = "0x60001CC")]
		[Cpp2IlInjected.Address(RVA = "0x6FEECD0", Offset = "0x6FED2D0", VA = "0x186FEECD0", Slot = "80")]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x60001CD")]
		[Cpp2IlInjected.Address(RVA = "0x6FEE3F0", Offset = "0x6FEC9F0", VA = "0x186FEE3F0", Slot = "81")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000083")]
	public Quaternion DFOFOGHOHDC
	{
		[Cpp2IlInjected.Token(Token = "0x60001CE")]
		[Cpp2IlInjected.Address(RVA = "0x6FF0160", Offset = "0x6FEE760", VA = "0x186FF0160", Slot = "82")]
		get
		{
			return default(Quaternion);
		}
		[Cpp2IlInjected.Token(Token = "0x60001CF")]
		[Cpp2IlInjected.Address(RVA = "0x6FEFC30", Offset = "0x6FEE230", VA = "0x186FEFC30", Slot = "83")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000084")]
	public RigidbodyConstraints ENAJGFPFLFD
	{
		[Cpp2IlInjected.Token(Token = "0x60001D3")]
		[Cpp2IlInjected.Address(RVA = "0x6FEF880", Offset = "0x6FEDE80", VA = "0x186FEF880", Slot = "84")]
		get
		{
			return default(RigidbodyConstraints);
		}
		[Cpp2IlInjected.Token(Token = "0x60001D4")]
		[Cpp2IlInjected.Address(RVA = "0x6FF0410", Offset = "0x6FEEA10", VA = "0x186FF0410", Slot = "85")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000085")]
	public bool AGLKOCOGMJP
	{
		[Cpp2IlInjected.Token(Token = "0x60001D5")]
		[Cpp2IlInjected.Address(RVA = "0x6FF2530", Offset = "0x6FF0B30", VA = "0x186FF2530", Slot = "86")]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x60001D6")]
		[Cpp2IlInjected.Address(RVA = "0x6FEF270", Offset = "0x6FED870", VA = "0x186FEF270", Slot = "87")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000086")]
	public CollisionDetectionMode LMNBDKLEKHE
	{
		[Cpp2IlInjected.Token(Token = "0x60001DF")]
		[Cpp2IlInjected.Address(RVA = "0x6FF1480", Offset = "0x6FEFA80", VA = "0x186FF1480", Slot = "88")]
		get
		{
			return default(CollisionDetectionMode);
		}
		[Cpp2IlInjected.Token(Token = "0x60001E0")]
		[Cpp2IlInjected.Address(RVA = "0x6FED480", Offset = "0x6FEBA80", VA = "0x186FED480", Slot = "89")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000087")]
	public bool MIIHMFPAKOK
	{
		[Cpp2IlInjected.Token(Token = "0x60001E2")]
		[Cpp2IlInjected.Address(RVA = "0x6FF0CB0", Offset = "0x6FEF2B0", VA = "0x186FF0CB0", Slot = "140")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000088")]
	public bool MPLEAFKELNL
	{
		[Cpp2IlInjected.Token(Token = "0x60001E3")]
		[Cpp2IlInjected.Address(RVA = "0x6FEFAB0", Offset = "0x6FEE0B0", VA = "0x186FEFAB0", Slot = "90")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000017")]
	public event MNDKPJKMNOG ACOCHEILPHM
	{
		[Cpp2IlInjected.Token(Token = "0x6000167")]
		[Cpp2IlInjected.Address(RVA = "0x6FF18A0", Offset = "0x6FEFEA0", VA = "0x186FF18A0", Slot = "4")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000168")]
		[Cpp2IlInjected.Address(RVA = "0x6FF1E30", Offset = "0x6FF0430", VA = "0x186FF1E30", Slot = "5")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000018")]
	public event MNDKPJKMNOG BIJKDBLOKGF
	{
		[Cpp2IlInjected.Token(Token = "0x6000169")]
		[Cpp2IlInjected.Address(RVA = "0x6FF0900", Offset = "0x6FEEF00", VA = "0x186FF0900", Slot = "6")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600016A")]
		[Cpp2IlInjected.Address(RVA = "0x6FF0DF0", Offset = "0x6FEF3F0", VA = "0x186FF0DF0", Slot = "7")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000019")]
	public event HFEPOIKNCFH NGCAAJLOGBI
	{
		[Cpp2IlInjected.Token(Token = "0x600016B")]
		[Cpp2IlInjected.Address(RVA = "0x6FF2670", Offset = "0x6FF0C70", VA = "0x186FF2670", Slot = "18")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600016C")]
		[Cpp2IlInjected.Address(RVA = "0x6FF2ED0", Offset = "0x6FF14D0", VA = "0x186FF2ED0", Slot = "19")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400001A")]
	public event MNDKPJKMNOG JKJMDMPHJFN
	{
		[Cpp2IlInjected.Token(Token = "0x6000174")]
		[Cpp2IlInjected.Address(RVA = "0x6FF0730", Offset = "0x6FEED30", VA = "0x186FF0730", Slot = "8")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000175")]
		[Cpp2IlInjected.Address(RVA = "0x6FEDDF0", Offset = "0x6FEC3F0", VA = "0x186FEDDF0", Slot = "9")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400001B")]
	public event MNDKPJKMNOG GPBIOKEPNGO
	{
		[Cpp2IlInjected.Token(Token = "0x600019E")]
		[Cpp2IlInjected.Address(RVA = "0x6FF2F30", Offset = "0x6FF1530", VA = "0x186FF2F30", Slot = "14")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600019F")]
		[Cpp2IlInjected.Address(RVA = "0x6FED910", Offset = "0x6FEBF10", VA = "0x186FED910", Slot = "15")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400001C")]
	public event MNDKPJKMNOG AFEKEEPHDEO
	{
		[Cpp2IlInjected.Token(Token = "0x60001B2")]
		[Cpp2IlInjected.Address(RVA = "0x6FED8B0", Offset = "0x6FEBEB0", VA = "0x186FED8B0", Slot = "16")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60001B3")]
		[Cpp2IlInjected.Address(RVA = "0x6FF2950", Offset = "0x6FF0F50", VA = "0x186FF2950", Slot = "17")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400001D")]
	public event Action<GHLGGPNNOMD, GHLGGPNNOMD> JNNGKLBDCAB
	{
		[Cpp2IlInjected.Token(Token = "0x60001B7")]
		[Cpp2IlInjected.Address(RVA = "0x6FF0C50", Offset = "0x6FEF250", VA = "0x186FF0C50", Slot = "20")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60001B8")]
		[Cpp2IlInjected.Address(RVA = "0x6FF0EB0", Offset = "0x6FEF4B0", VA = "0x186FF0EB0", Slot = "21")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400001E")]
	public event MNDKPJKMNOG ONOLPJLNMOJ
	{
		[Cpp2IlInjected.Token(Token = "0x60001BB")]
		[Cpp2IlInjected.Address(RVA = "0x6FF08A0", Offset = "0x6FEEEA0", VA = "0x186FF08A0", Slot = "12")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60001BC")]
		[Cpp2IlInjected.Address(RVA = "0x6FEE570", Offset = "0x6FECB70", VA = "0x186FEE570", Slot = "13")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400001F")]
	public event MNDKPJKMNOG CNBAGDCHLAB
	{
		[Cpp2IlInjected.Token(Token = "0x60001C1")]
		[Cpp2IlInjected.Address(RVA = "0x6FEE680", Offset = "0x6FECC80", VA = "0x186FEE680", Slot = "10")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60001C2")]
		[Cpp2IlInjected.Address(RVA = "0x6FF2C80", Offset = "0x6FF1280", VA = "0x186FF2C80", Slot = "11")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000160")]
	[Cpp2IlInjected.Address(RVA = "0x6FF3260", Offset = "0x6FF1860", VA = "0x186FF3260")]
	public BHBLNBBNMEK(GameObject BBKKNFIIKNJ, RigidbodyEx NMDKKHIJGJJ, MNKFGLGCPDN FHLJNPENEDC, [In] AHJPEDECEFI JHLEMCFOEMF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000161")]
	[Cpp2IlInjected.Address(RVA = "0x6FEFDC0", Offset = "0x6FEE3C0", VA = "0x186FEFDC0", Slot = "136")]
	protected virtual void GICOPIEMPDL(MNKFGLGCPDN FHLJNPENEDC, AHJPEDECEFI JHLEMCFOEMF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000162")]
	[Cpp2IlInjected.Address(RVA = "0x6FEEAB0", Offset = "0x6FED0B0", VA = "0x186FEEAB0", Slot = "137")]
	public virtual void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000163")]
	[Cpp2IlInjected.Address(RVA = "0x6FEE0C0", Offset = "0x6FEC6C0", VA = "0x186FEE0C0", Slot = "91")]
	public void BMDHDEMLIBC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000164")]
	[Cpp2IlInjected.Address(RVA = "0x6FEEC80", Offset = "0x6FED280", VA = "0x186FEEC80", Slot = "92")]
	public void ECPJLKCIFLN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000165")]
	[Cpp2IlInjected.Address(RVA = "0x6FF2650", Offset = "0x6FF0C50", VA = "0x186FF2650", Slot = "93")]
	public void MLENDIHHCDF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000166")]
	[Cpp2IlInjected.Address(RVA = "0x6FF2790", Offset = "0x6FF0D90", VA = "0x186FF2790")]
	private void MPCNGICJMFF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000170")]
	[Cpp2IlInjected.Address(RVA = "0x6FEE2A0", Offset = "0x6FEC8A0", VA = "0x186FEE2A0", Slot = "30")]
	public BDAEKEEHGON CENCKEAOOMD(int EBDMAJMOJLN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000173")]
	[Cpp2IlInjected.Address(RVA = "0x6FF31B0", Offset = "0x6FF17B0", VA = "0x186FF31B0", Slot = "95")]
	public void PPDMAPLEIEK(BDAEKEEHGON FEBGGALLBNN, bool JBFNJGDBMCB = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600018A")]
	[Cpp2IlInjected.Address(RVA = "0x6FF26D0", Offset = "0x6FF0CD0", VA = "0x186FF26D0", Slot = "96")]
	public void MOKANAKKEPA(object PNPIGCGKNPI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600018B")]
	[Cpp2IlInjected.Address(RVA = "0x6FED530", Offset = "0x6FEBB30", VA = "0x186FED530", Slot = "97")]
	public void AEIILGHHOHM(object PNPIGCGKNPI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600018C")]
	[Cpp2IlInjected.Address(RVA = "0x6FF2B30", Offset = "0x6FF1130", VA = "0x186FF2B30", Slot = "98")]
	public Vector3 OCHFKMGFHBD(Vector3 FGAFOHDCFPB)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x600018D")]
	[Cpp2IlInjected.Address(RVA = "0x6FEF090", Offset = "0x6FED690", VA = "0x186FEF090", Slot = "99")]
	public Vector3 EILJJNPMFLF(Vector3 DOEHELKGDBK)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x600018E")]
	[Cpp2IlInjected.Address(RVA = "0x6FEEC80", Offset = "0x6FED280", VA = "0x186FEEC80", Slot = "100")]
	public void OADDMHBKMMD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600018F")]
	[Cpp2IlInjected.Address(RVA = "0x6FEF4F0", Offset = "0x6FEDAF0", VA = "0x186FEF4F0", Slot = "101")]
	public void FAHHCFFEONM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000190")]
	[Cpp2IlInjected.Address(RVA = "0x6FF1380", Offset = "0x6FEF980", VA = "0x186FF1380", Slot = "102")]
	public void JOIAPFKMNHH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000191")]
	[Cpp2IlInjected.Address(RVA = "0x6FED390", Offset = "0x6FEB990", VA = "0x186FED390", Slot = "103")]
	public void ABBFOCFOCGJ(Vector3 CAJPCDAIFIP, Vector3 CHILFEFILCK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000192")]
	[Cpp2IlInjected.Address(RVA = "0x6FF09C0", Offset = "0x6FEEFC0", VA = "0x186FF09C0", Slot = "104")]
	public void IHKEKHHCCOO(Vector3 HLJCNLEDNPM, Vector3 AAPEKCHOAIG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000193")]
	[Cpp2IlInjected.Address(RVA = "0x6FF16C0", Offset = "0x6FEFCC0", VA = "0x186FF16C0", Slot = "105")]
	public void KFJEPNEFPMA(Vector3 LNOIGBIBALG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000194")]
	[Cpp2IlInjected.Address(RVA = "0x6FF2D30", Offset = "0x6FF1330", VA = "0x186FF2D30", Slot = "106")]
	public void OHGAIHKHGIM(ICCPFOEOBPC NHNBBPPCADG, Vector3 NIHMGKDKFLI, float GFCGIPHILDG, float AMJDFLLFOGG = 8f, float NMPDDKIDGKC = 1f)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000195")]
	[Cpp2IlInjected.Address(RVA = "0x6FF0AB0", Offset = "0x6FEF0B0", VA = "0x186FF0AB0", Slot = "107")]
	public void IIDCCGIKHJM(IBINHLJGAJL EDEBFCKHCOB, Vector3 BDOGOHDDNFF, float PGHAPCLIBGC = float.PositiveInfinity)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000196")]
	[Cpp2IlInjected.Address(RVA = "0x6FF00B0", Offset = "0x6FEE6B0", VA = "0x186FF00B0", Slot = "108")]
	[Obsolete("Deprecated. Still exists to support deprecated CV2 chips. Use ApplyAngularVelocityChange.")]
	public void GIJGAEIJIBG(IBINHLJGAJL EDEBFCKHCOB, Vector3 CNNBBFFJNHM, float JNOOKKEDJLJ = 7f, float GPKBFHCKJJI = 1f)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000197")]
	[Cpp2IlInjected.Address(RVA = "0x6FEF8D0", Offset = "0x6FEDED0", VA = "0x186FEF8D0", Slot = "109")]
	public Vector3 FONKOLKJNID(Vector3 FEBGGALLBNN)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000198")]
	[Cpp2IlInjected.Address(RVA = "0x6FEDCA0", Offset = "0x6FEC2A0", VA = "0x186FEDCA0", Slot = "110")]
	public Vector3 AKJNKINBOKK(Vector3 FEBGGALLBNN)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000199")]
	[Cpp2IlInjected.Address(RVA = "0x6FF1A30", Offset = "0x6FF0030", VA = "0x186FF1A30", Slot = "111")]
	public void KOECGAKFNDD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600019C")]
	[Cpp2IlInjected.Address(RVA = "0x6FEDF00", Offset = "0x6FEC500", VA = "0x186FEDF00", Slot = "112")]
	public void BFNFNKAIFLJ(BDAEKEEHGON HPIMGJKGFPO, object PNPIGCGKNPI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600019D")]
	[Cpp2IlInjected.Address(RVA = "0x6FEF2D0", Offset = "0x6FED8D0", VA = "0x186FEF2D0", Slot = "113")]
	public void EPCMKCFCPLC(object PNPIGCGKNPI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001A8")]
	[Cpp2IlInjected.Address(RVA = "0x6FF2DF0", Offset = "0x6FF13F0", VA = "0x186FF2DF0", Slot = "61")]
	public void OJOCLKHEPKG((Quaternion rot, Vector3 moments) JEIDJBGOPFO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001A9")]
	[Cpp2IlInjected.Address(RVA = "0x6FF24E0", Offset = "0x6FF0AE0", VA = "0x186FF24E0", Slot = "114")]
	public void MANHEMLKMJP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001AA")]
	[Cpp2IlInjected.Address(RVA = "0x6FEE250", Offset = "0x6FEC850", VA = "0x186FEE250", Slot = "115")]
	public void CEGIPIKKAML()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001AB")]
	[Cpp2IlInjected.Address(RVA = "0x6FF3160", Offset = "0x6FF1760", VA = "0x186FF3160", Slot = "116")]
	public void PKPJPBHGIOD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001B4")]
	[Cpp2IlInjected.Address(RVA = "0x6FEDDA0", Offset = "0x6FEC3A0", VA = "0x186FEDDA0", Slot = "117")]
	public bool AOCFCKBPOGJ()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001B5")]
	[Cpp2IlInjected.Address(RVA = "0x6FEE200", Offset = "0x6FEC800", VA = "0x186FEE200", Slot = "94")]
	public void CAJEOIOLNEH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001B6")]
	[Cpp2IlInjected.Address(RVA = "0x6FF19E0", Offset = "0x6FEFFE0", VA = "0x186FF19E0", Slot = "118")]
	public void KKPNCKGMGKM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001BE")]
	[Cpp2IlInjected.Address(RVA = "0x6FEE620", Offset = "0x6FECC20", VA = "0x186FEE620", Slot = "119")]
	public void DHONMCJFNPK(object PNPIGCGKNPI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001BF")]
	[Cpp2IlInjected.Address(RVA = "0x6FF0960", Offset = "0x6FEEF60", VA = "0x186FF0960", Slot = "120")]
	public void IFPKGBJENPI(object PNPIGCGKNPI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001C0")]
	[Cpp2IlInjected.Address(RVA = "0x6FF2F90", Offset = "0x6FF1590", VA = "0x186FF2F90", Slot = "121")]
	public void PAEILMBBFPG(object PNPIGCGKNPI, bool JIJGAKFGIEE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001D0")]
	[Cpp2IlInjected.Address(RVA = "0x6FEDAA0", Offset = "0x6FEC0A0", VA = "0x186FEDAA0", Slot = "122")]
	public void AKIAIEIILIL(Vector3 FAJCABGFGFI, Quaternion ANPHIIHKJAC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001D1")]
	[Cpp2IlInjected.Address(RVA = "0x6FF1150", Offset = "0x6FEF750", VA = "0x186FF1150", Slot = "123")]
	public void JLBIDBDBAMO(Vector3 PHFIAHNNOJK, Quaternion FONGLNADHHP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001D2")]
	[Cpp2IlInjected.Address(RVA = "0x6FF0E50", Offset = "0x6FEF450", VA = "0x186FF0E50", Slot = "124")]
	public bool JAIJDEACKLB(float PMPLECFBFFL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001D7")]
	[Cpp2IlInjected.Address(RVA = "0x6FF2810", Offset = "0x6FF0E10", VA = "0x186FF2810", Slot = "125")]
	public void NGNDFNBOMLO(object PNPIGCGKNPI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001D8")]
	[Cpp2IlInjected.Address(RVA = "0x6FEE060", Offset = "0x6FEC660", VA = "0x186FEE060", Slot = "126")]
	public void BLPGLEEALBG(object PNPIGCGKNPI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001D9")]
	[Cpp2IlInjected.Address(RVA = "0x6FF1E90", Offset = "0x6FF0490", VA = "0x186FF1E90", Slot = "127")]
	public void LFGHNJFKEON(object PNPIGCGKNPI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001DA")]
	[Cpp2IlInjected.Address(RVA = "0x6FEE9F0", Offset = "0x6FECFF0", VA = "0x186FEE9F0", Slot = "128")]
	public void DPEPKDOFMAH(object PNPIGCGKNPI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001DB")]
	[Cpp2IlInjected.Address(RVA = "0x6FF1900", Offset = "0x6FEFF00", VA = "0x186FF1900", Slot = "129")]
	public void KJHEFIHDMOK(Vector3 EFJJGJMLHPN, ForceMode CDGNLODPNML = ForceMode.Force)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001DC")]
	[Cpp2IlInjected.Address(RVA = "0x6FF0790", Offset = "0x6FEED90", VA = "0x186FF0790", Slot = "130")]
	public void HGEALHKPEMK(Vector3 EFJJGJMLHPN, Vector3 LPBGBJBIAOJ, ForceMode CDGNLODPNML)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001DD")]
	[Cpp2IlInjected.Address(RVA = "0x6FEF9D0", Offset = "0x6FEDFD0", VA = "0x186FEF9D0", Slot = "131")]
	public void GAALLOJPDLM(Vector3 MJDDAPLCJDP, ForceMode CDGNLODPNML = ForceMode.Force)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001DE")]
	[Cpp2IlInjected.Address(RVA = "0x6FEF5F0", Offset = "0x6FEDBF0", VA = "0x186FEF5F0", Slot = "132")]
	public void FKDKHMNINIC(Vector3 MJDDAPLCJDP, ForceMode CDGNLODPNML = ForceMode.Force)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001E1")]
	[Cpp2IlInjected.Address(RVA = "0x6FF2220", Offset = "0x6FF0820", VA = "0x186FF2220", Slot = "133")]
	public bool LMCIDJHMOFI(Vector3 MJBOPHFMANN, [Out] RaycastHit NKJBDBKJJDK, float FJJNLOMPHKA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001E4")]
	[Cpp2IlInjected.Address(RVA = "0x6FF1800", Offset = "0x6FEFE00", VA = "0x186FF1800", Slot = "134")]
	public void KGKHPNFCOID()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001E5")]
	[Cpp2IlInjected.Address(RVA = "0x6FF3220", Offset = "0x6FF1820", VA = "0x186FF3220", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001E6")]
	[Cpp2IlInjected.Address(RVA = "0x6FF20B0", Offset = "0x6FF06B0", VA = "0x186FF20B0")]
	private void LGMELMMDOOM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001E7")]
	[Cpp2IlInjected.Address(RVA = "0x6FEE810", Offset = "0x6FECE10", VA = "0x186FEE810")]
	private void DMBEEFDHNBF(BDAEKEEHGON LPFOFJIMHOE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001E8")]
	[Cpp2IlInjected.Address(RVA = "0x6FF0550", Offset = "0x6FEEB50", VA = "0x186FF0550")]
	private void HDGCIOCJIJC(BDAEKEEHGON LPFOFJIMHOE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001E9")]
	[Cpp2IlInjected.Address(RVA = "0x6FEDE50", Offset = "0x6FEC450", VA = "0x186FEDE50")]
	private void BDGMOBAHBDJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001EA")]
	[Cpp2IlInjected.Address(RVA = "0x6FEEB80", Offset = "0x6FED180", VA = "0x186FEEB80")]
	private void EBEANBNENKA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001EB")]
	[Cpp2IlInjected.Address(RVA = "0x6FF14D0", Offset = "0x6FEFAD0", VA = "0x186FF14D0")]
	private void KECAHIFDMHF(BDAEKEEHGON NDEGEBOFKHD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001EC")]
	[Cpp2IlInjected.Address(RVA = "0x6FED2C0", Offset = "0x6FEB8C0", VA = "0x186FED2C0")]
	private void AAICGDBFFIE(BDAEKEEHGON LPFOFJIMHOE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001ED")]
	[Cpp2IlInjected.Address(RVA = "0x6FF2580", Offset = "0x6FF0B80", VA = "0x186FF2580")]
	private void MKHPKMIJDKB(BDAEKEEHGON LPFOFJIMHOE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001EE")]
	[Cpp2IlInjected.Address(RVA = "0x6FEF380", Offset = "0x6FED980", VA = "0x186FEF380")]
	private void FABDKGFIMDO(ANCEECHCKHO LPFOFJIMHOE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001EF")]
	[Cpp2IlInjected.Address(RVA = "0x6FF1A80", Offset = "0x6FF0080", VA = "0x186FF1A80", Slot = "141")]
	protected virtual void LDJGNOHGJFP(ANCEECHCKHO KOPJPDIAFKF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001F0")]
	[Cpp2IlInjected.Address(RVA = "0x6FED590", Offset = "0x6FEBB90", VA = "0x186FED590")]
	protected void AEOKDIFOPMO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001F1")]
	[Cpp2IlInjected.Address(RVA = "0x6FEED20", Offset = "0x6FED320", VA = "0x186FEED20")]
	protected void EFBMBAHIHGP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001F2")]
	[Cpp2IlInjected.Address(RVA = "0x6FF0270", Offset = "0x6FEE870", VA = "0x186FF0270", Slot = "142")]
	protected virtual IDisposable GMADGMHFOJB()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200001D")]
internal static class FDGDNHIOMLJ
{
	[Cpp2IlInjected.Token(Token = "0x60001F3")]
	[Cpp2IlInjected.Address(RVA = "0x6FF4940", Offset = "0x6FF2F40", VA = "0x186FF4940")]
	public static BDAEKEEHGON GLPKBOONIKF(this BDAEKEEHGON KOPJPDIAFKF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001F4")]
	[Cpp2IlInjected.Address(RVA = "0x6FF4870", Offset = "0x6FF2E70", VA = "0x186FF4870")]
	public static bool FNBJPMKDOKL(this BDAEKEEHGON KOPJPDIAFKF, BDAEKEEHGON FHIAACOGJEA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001F5")]
	[Cpp2IlInjected.Address(RVA = "0x6FF47F0", Offset = "0x6FF2DF0", VA = "0x186FF47F0")]
	public static bool FKKAAONKILM(this BDAEKEEHGON KOPJPDIAFKF, BDAEKEEHGON MDFKJKGONGF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001F6")]
	[Cpp2IlInjected.Address(RVA = "0x6FF48F0", Offset = "0x6FF2EF0", VA = "0x186FF48F0")]
	public static ANCEECHCKHO GIKCJBJCLLJ(this BDAEKEEHGON ADLOKNICHMI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001F7")]
	[Cpp2IlInjected.Address(RVA = "0x6FF4780", Offset = "0x6FF2D80", VA = "0x186FF4780")]
	public static BHBLNBBNMEK FGKBJPFGCBF(this BDAEKEEHGON ADLOKNICHMI)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200001E")]
public class FFMGADAJJHC : HIACBNIDNKB
{
	[Cpp2IlInjected.Token(Token = "0x60001F8")]
	[Cpp2IlInjected.Address(RVA = "0x6FF4A00", Offset = "0x6FF3000", VA = "0x186FF4A00", Slot = "19")]
	public BDAEKEEHGON CDLFPPCMJPP(RigidbodyEx KOPJPDIAFKF, AHJPEDECEFI JHLEMCFOEMF, MNKFGLGCPDN FHLJNPENEDC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001F9")]
	[Cpp2IlInjected.Address(RVA = "0x85E9F0", Offset = "0x85CFF0", VA = "0x18085E9F0", Slot = "4")]
	public GMDDLFLGAPG DHMBCBMDMGO(BDAEKEEHGON ADLOKNICHMI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001FA")]
	[Cpp2IlInjected.Address(RVA = "0x85E9F0", Offset = "0x85CFF0", VA = "0x18085E9F0", Slot = "5")]
	public EHMADKKELDA GFCNECICBKO(BDAEKEEHGON ADLOKNICHMI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001FB")]
	[Cpp2IlInjected.Address(RVA = "0x85E9F0", Offset = "0x85CFF0", VA = "0x18085E9F0", Slot = "6")]
	public FBEBDGAEMPK NACJCMPJFOE(BDAEKEEHGON ADLOKNICHMI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001FC")]
	[Cpp2IlInjected.Address(RVA = "0x85E9F0", Offset = "0x85CFF0", VA = "0x18085E9F0", Slot = "7")]
	public MJNCCHHAJHB MINNKMLNGFN(BDAEKEEHGON ADLOKNICHMI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001FD")]
	[Cpp2IlInjected.Address(RVA = "0x85E9F0", Offset = "0x85CFF0", VA = "0x18085E9F0", Slot = "8")]
	public CEKFDCFDGNB IMKLFCHBDHP(BDAEKEEHGON ADLOKNICHMI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001FE")]
	[Cpp2IlInjected.Address(RVA = "0x85E9F0", Offset = "0x85CFF0", VA = "0x18085E9F0", Slot = "9")]
	public DBHCAHODFGJ PPEMDIBIOBD(BDAEKEEHGON ADLOKNICHMI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001FF")]
	[Cpp2IlInjected.Address(RVA = "0x85E9F0", Offset = "0x85CFF0", VA = "0x18085E9F0", Slot = "10")]
	public PKBHNJMBMCL ELIEDKLFJOF(BDAEKEEHGON ADLOKNICHMI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000200")]
	[Cpp2IlInjected.Address(RVA = "0x85E9F0", Offset = "0x85CFF0", VA = "0x18085E9F0", Slot = "11")]
	public EICNHMNGDHM DHJMPJJBCDH(BDAEKEEHGON ADLOKNICHMI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000201")]
	[Cpp2IlInjected.Address(RVA = "0x85E9F0", Offset = "0x85CFF0", VA = "0x18085E9F0", Slot = "12")]
	public BBHIJCOHKBE KGFPGIKGIKA(BDAEKEEHGON ADLOKNICHMI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000202")]
	[Cpp2IlInjected.Address(RVA = "0x85E9F0", Offset = "0x85CFF0", VA = "0x18085E9F0", Slot = "13")]
	public GNHKGALPOEN CEFAANOIGCG(BDAEKEEHGON ADLOKNICHMI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000203")]
	[Cpp2IlInjected.Address(RVA = "0x85E9F0", Offset = "0x85CFF0", VA = "0x18085E9F0")]
	public CHEAFKNGDNE KDLPLJFJGPB(BDAEKEEHGON ADLOKNICHMI, [In] AHJPEDECEFI JHLEMCFOEMF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000204")]
	[Cpp2IlInjected.Address(RVA = "0x85E9F0", Offset = "0x85CFF0", VA = "0x18085E9F0")]
	public HCMIIMNCCNN HOPJADMEONB(BDAEKEEHGON ADLOKNICHMI, [In] AHJPEDECEFI JHLEMCFOEMF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000205")]
	[Cpp2IlInjected.Address(RVA = "0x85E9F0", Offset = "0x85CFF0", VA = "0x18085E9F0")]
	public KILAKAEDOED HOMIKMJODAI(BDAEKEEHGON ADLOKNICHMI, [In] AHJPEDECEFI JHLEMCFOEMF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000206")]
	[Cpp2IlInjected.Address(RVA = "0x85E9F0", Offset = "0x85CFF0", VA = "0x18085E9F0")]
	public ALGPKHEMHDL LPGLMGJKDBI(BDAEKEEHGON ADLOKNICHMI, [In] AHJPEDECEFI JHLEMCFOEMF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000207")]
	[Cpp2IlInjected.Address(RVA = "0x85E9F0", Offset = "0x85CFF0", VA = "0x18085E9F0")]
	public FNAIMHFAGCI MDKILNCHICP(BDAEKEEHGON ADLOKNICHMI, [In] AHJPEDECEFI JHLEMCFOEMF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000208")]
	[Cpp2IlInjected.Address(RVA = "0x8692F0", Offset = "0x8678F0", VA = "0x1808692F0")]
	public FFMGADAJJHC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000209")]
	[Cpp2IlInjected.Address(RVA = "0x85E9F0", Offset = "0x85CFF0", VA = "0x18085E9F0", Slot = "14")]
	private CHEAFKNGDNE DOBHAECEOMM(BDAEKEEHGON ADLOKNICHMI, [In] AHJPEDECEFI JHLEMCFOEMF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600020A")]
	[Cpp2IlInjected.Address(RVA = "0x85E9F0", Offset = "0x85CFF0", VA = "0x18085E9F0", Slot = "15")]
	private HCMIIMNCCNN JEGOIHEIKOM(BDAEKEEHGON ADLOKNICHMI, [In] AHJPEDECEFI JHLEMCFOEMF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600020B")]
	[Cpp2IlInjected.Address(RVA = "0x85E9F0", Offset = "0x85CFF0", VA = "0x18085E9F0", Slot = "16")]
	private KILAKAEDOED AMDMGJOINKG(BDAEKEEHGON ADLOKNICHMI, [In] AHJPEDECEFI JHLEMCFOEMF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600020C")]
	[Cpp2IlInjected.Address(RVA = "0x85E9F0", Offset = "0x85CFF0", VA = "0x18085E9F0", Slot = "17")]
	private ALGPKHEMHDL ADEFBPOLFFP(BDAEKEEHGON ADLOKNICHMI, [In] AHJPEDECEFI JHLEMCFOEMF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600020D")]
	[Cpp2IlInjected.Address(RVA = "0x85E9F0", Offset = "0x85CFF0", VA = "0x18085E9F0", Slot = "18")]
	private FNAIMHFAGCI DLKLIHIGCBH(BDAEKEEHGON ADLOKNICHMI, [In] AHJPEDECEFI JHLEMCFOEMF)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200001F")]
[EGEIKMOFAOL(typeof(HIACBNIDNKB), new string[] { })]
public class PAOICHGOLHD : HIACBNIDNKB, CPCIADPOEEL
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400002B")]
	private readonly HIACBNIDNKB AMNAKBOAKBD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400002C")]
	private readonly HIACBNIDNKB FMCPANALKEC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400002D")]
	private HCMBBKNLLDK JDNFGCIGAOK;

	[Cpp2IlInjected.Token(Token = "0x17000089")]
	private HIACBNIDNKB DMMMHPOIONN
	{
		[Cpp2IlInjected.Token(Token = "0x600020F")]
		[Cpp2IlInjected.Address(RVA = "0x6FFEEF0", Offset = "0x6FFD4F0", VA = "0x186FFEEF0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600020E")]
	[Cpp2IlInjected.Address(RVA = "0x6FFEE00", Offset = "0x6FFD400", VA = "0x186FFEE00", Slot = "20")]
	public void InitReferences(CBLPEPBNIEA DIJICJLLCHO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000210")]
	[Cpp2IlInjected.Address(RVA = "0x6FFE970", Offset = "0x6FFCF70", VA = "0x186FFE970", Slot = "4")]
	public GMDDLFLGAPG DHMBCBMDMGO(BDAEKEEHGON ADLOKNICHMI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000211")]
	[Cpp2IlInjected.Address(RVA = "0x6FFEC10", Offset = "0x6FFD210", VA = "0x186FFEC10", Slot = "5")]
	public EHMADKKELDA GFCNECICBKO(BDAEKEEHGON ADLOKNICHMI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000212")]
	[Cpp2IlInjected.Address(RVA = "0x6FFEFF0", Offset = "0x6FFD5F0", VA = "0x186FFEFF0", Slot = "6")]
	public FBEBDGAEMPK NACJCMPJFOE(BDAEKEEHGON ADLOKNICHMI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000213")]
	[Cpp2IlInjected.Address(RVA = "0x6FFEF50", Offset = "0x6FFD550", VA = "0x186FFEF50", Slot = "7")]
	public MJNCCHHAJHB MINNKMLNGFN(BDAEKEEHGON ADLOKNICHMI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000214")]
	[Cpp2IlInjected.Address(RVA = "0x6FFED60", Offset = "0x6FFD360", VA = "0x186FFED60", Slot = "8")]
	public CEKFDCFDGNB IMKLFCHBDHP(BDAEKEEHGON ADLOKNICHMI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000215")]
	[Cpp2IlInjected.Address(RVA = "0x6FFF090", Offset = "0x6FFD690", VA = "0x186FFF090", Slot = "9")]
	public DBHCAHODFGJ PPEMDIBIOBD(BDAEKEEHGON ADLOKNICHMI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000216")]
	[Cpp2IlInjected.Address(RVA = "0x6FFEB70", Offset = "0x6FFD170", VA = "0x186FFEB70", Slot = "10")]
	public PKBHNJMBMCL ELIEDKLFJOF(BDAEKEEHGON ADLOKNICHMI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000217")]
	[Cpp2IlInjected.Address(RVA = "0x6FFE8D0", Offset = "0x6FFCED0", VA = "0x186FFE8D0", Slot = "11")]
	public EICNHMNGDHM DHJMPJJBCDH(BDAEKEEHGON ADLOKNICHMI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000218")]
	[Cpp2IlInjected.Address(RVA = "0x6FFEE50", Offset = "0x6FFD450", VA = "0x186FFEE50", Slot = "12")]
	public BBHIJCOHKBE KGFPGIKGIKA(BDAEKEEHGON ADLOKNICHMI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000219")]
	[Cpp2IlInjected.Address(RVA = "0x6FFE830", Offset = "0x6FFCE30", VA = "0x186FFE830", Slot = "13")]
	public GNHKGALPOEN CEFAANOIGCG(BDAEKEEHGON ADLOKNICHMI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600021A")]
	[Cpp2IlInjected.Address(RVA = "0x6FFEAC0", Offset = "0x6FFD0C0", VA = "0x186FFEAC0")]
	public CHEAFKNGDNE KDLPLJFJGPB(BDAEKEEHGON ADLOKNICHMI, [In] AHJPEDECEFI JHLEMCFOEMF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600021B")]
	[Cpp2IlInjected.Address(RVA = "0x6FFECB0", Offset = "0x6FFD2B0", VA = "0x186FFECB0")]
	public HCMIIMNCCNN HOPJADMEONB(BDAEKEEHGON ADLOKNICHMI, [In] AHJPEDECEFI JHLEMCFOEMF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600021C")]
	[Cpp2IlInjected.Address(RVA = "0x6FFE6A0", Offset = "0x6FFCCA0", VA = "0x186FFE6A0")]
	public KILAKAEDOED HOMIKMJODAI(BDAEKEEHGON ADLOKNICHMI, [In] AHJPEDECEFI JHLEMCFOEMF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600021D")]
	[Cpp2IlInjected.Address(RVA = "0x6FFE5F0", Offset = "0x6FFCBF0", VA = "0x186FFE5F0")]
	public ALGPKHEMHDL LPGLMGJKDBI(BDAEKEEHGON ADLOKNICHMI, [In] AHJPEDECEFI JHLEMCFOEMF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600021E")]
	[Cpp2IlInjected.Address(RVA = "0x6FFEA10", Offset = "0x6FFD010", VA = "0x186FFEA10")]
	public FNAIMHFAGCI MDKILNCHICP(BDAEKEEHGON ADLOKNICHMI, [In] AHJPEDECEFI JHLEMCFOEMF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600021F")]
	[Cpp2IlInjected.Address(RVA = "0x6FFE750", Offset = "0x6FFCD50", VA = "0x186FFE750", Slot = "19")]
	public BDAEKEEHGON CDLFPPCMJPP(RigidbodyEx KOPJPDIAFKF, AHJPEDECEFI JHLEMCFOEMF, MNKFGLGCPDN FHLJNPENEDC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000220")]
	[Cpp2IlInjected.Address(RVA = "0x6FFF130", Offset = "0x6FFD730", VA = "0x186FFF130")]
	public PAOICHGOLHD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000221")]
	[Cpp2IlInjected.Address(RVA = "0x6FFEAC0", Offset = "0x6FFD0C0", VA = "0x186FFEAC0", Slot = "14")]
	private CHEAFKNGDNE DOBHAECEOMM(BDAEKEEHGON ADLOKNICHMI, [In] AHJPEDECEFI JHLEMCFOEMF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000222")]
	[Cpp2IlInjected.Address(RVA = "0x6FFECB0", Offset = "0x6FFD2B0", VA = "0x186FFECB0", Slot = "15")]
	private HCMIIMNCCNN JEGOIHEIKOM(BDAEKEEHGON ADLOKNICHMI, [In] AHJPEDECEFI JHLEMCFOEMF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000223")]
	[Cpp2IlInjected.Address(RVA = "0x6FFE6A0", Offset = "0x6FFCCA0", VA = "0x186FFE6A0", Slot = "16")]
	private KILAKAEDOED AMDMGJOINKG(BDAEKEEHGON ADLOKNICHMI, [In] AHJPEDECEFI JHLEMCFOEMF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000224")]
	[Cpp2IlInjected.Address(RVA = "0x6FFE5F0", Offset = "0x6FFCBF0", VA = "0x186FFE5F0", Slot = "17")]
	private ALGPKHEMHDL ADEFBPOLFFP(BDAEKEEHGON ADLOKNICHMI, [In] AHJPEDECEFI JHLEMCFOEMF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000225")]
	[Cpp2IlInjected.Address(RVA = "0x6FFEA10", Offset = "0x6FFD010", VA = "0x186FFEA10", Slot = "18")]
	private FNAIMHFAGCI DLKLIHIGCBH(BDAEKEEHGON ADLOKNICHMI, [In] AHJPEDECEFI JHLEMCFOEMF)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000020")]
public interface AFHIPHENKNM : GMDDLFLGAPG, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x6000226")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void MOGHPDEAFIL(BDAEKEEHGON KOPJPDIAFKF);

	[Cpp2IlInjected.Token(Token = "0x6000227")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void PNPLADLDJCC(BDAEKEEHGON KOPJPDIAFKF);

	[Cpp2IlInjected.Token(Token = "0x6000228")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void BEHGJHHILKJ(BDAEKEEHGON NDEGEBOFKHD);

	[Cpp2IlInjected.Token(Token = "0x6000229")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void OPIIHENCGFB(BDAEKEEHGON NDEGEBOFKHD);
}
[Cpp2IlInjected.Token(Token = "0x2000021")]
public interface JONFPJCELDI : FBEBDGAEMPK
{
	[Cpp2IlInjected.Token(Token = "0x1700008A")]
	OLEKGJHHEJD<BDAEKEEHGON> FGHJHAMBGLL
	{
		[Cpp2IlInjected.Token(Token = "0x600022A")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700008B")]
	BDAEKEEHGON EKGKLAMEDPC
	{
		[Cpp2IlInjected.Token(Token = "0x600022B")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000022")]
public interface MDMMLMOKKAM : ALGPKHEMHDL
{
	[Cpp2IlInjected.Token(Token = "0x600022C")]
	[Cpp2IlInjected.Address(Slot = "0")]
	(float, Vector3) DLMIDNAADBL(Rigidbody KLEHOCGNLEP);
}
[Cpp2IlInjected.Token(Token = "0x2000023")]
public interface ALCLGDPPEIA : HCMIIMNCCNN, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x1700008C")]
	PhotonView AKMDDPBHFFI
	{
		[Cpp2IlInjected.Token(Token = "0x600022D")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000024")]
internal sealed class IOIIIHKKNGD : BBHIJCOHKBE
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400002E")]
	private readonly BHBLNBBNMEK KOPJPDIAFKF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400002F")]
	private CollisionDetectionMode HHFMMJEGJMJ;

	[Cpp2IlInjected.Token(Token = "0x1700008D")]
	private Rigidbody HMDFBMEBLAA
	{
		[Cpp2IlInjected.Token(Token = "0x600022E")]
		[Cpp2IlInjected.Address(RVA = "0x6FFAA00", Offset = "0x6FF9000", VA = "0x186FFAA00")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700008E")]
	public CollisionDetectionMode LMNBDKLEKHE
	{
		[Cpp2IlInjected.Token(Token = "0x6000232")]
		[Cpp2IlInjected.Address(RVA = "0x6FFAB70", Offset = "0x6FF9170", VA = "0x186FFAB70", Slot = "4")]
		get
		{
			return default(CollisionDetectionMode);
		}
		[Cpp2IlInjected.Token(Token = "0x6000233")]
		[Cpp2IlInjected.Address(RVA = "0x6FFA860", Offset = "0x6FF8E60", VA = "0x186FFA860", Slot = "5")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600022F")]
	[Cpp2IlInjected.Address(RVA = "0x6FFAE60", Offset = "0x6FF9460", VA = "0x186FFAE60")]
	public IOIIIHKKNGD(BDAEKEEHGON KOPJPDIAFKF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000230")]
	[Cpp2IlInjected.Address(RVA = "0x6FFA8E0", Offset = "0x6FF8EE0", VA = "0x186FFA8E0", Slot = "6")]
	public void BMDHDEMLIBC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000231")]
	[Cpp2IlInjected.Address(RVA = "0x6FFADE0", Offset = "0x6FF93E0", VA = "0x186FFADE0", Slot = "9")]
	public void OJJJHIEHGGE(Rigidbody NNDHPDBLJFB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000234")]
	[Cpp2IlInjected.Address(RVA = "0x6FFA8D0", Offset = "0x6FF8ED0", VA = "0x186FFA8D0", Slot = "7")]
	public void BGAGCJAIAEP(bool DMPOCDBICIM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000235")]
	[Cpp2IlInjected.Address(RVA = "0x6FFA9F0", Offset = "0x6FF8FF0", VA = "0x186FFA9F0", Slot = "8")]
	public void GADJCALBALL(bool DMPOCDBICIM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000236")]
	[Cpp2IlInjected.Address(RVA = "0x6FFAC80", Offset = "0x6FF9280", VA = "0x186FFAC80", Slot = "10")]
	public bool LMCIDJHMOFI(Vector3 MJBOPHFMANN, [Out] RaycastHit NKJBDBKJJDK, float FJJNLOMPHKA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000237")]
	[Cpp2IlInjected.Address(RVA = "0x6FFAA50", Offset = "0x6FF9050", VA = "0x186FFAA50")]
	private void JMACFMGAKCA(bool DMPOCDBICIM)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000025")]
public sealed class FHKEBCJAAIO : DBHCAHODFGJ, IDisposable, FKONIPBKDNE
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000031")]
	private readonly BHBLNBBNMEK KOPJPDIAFKF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000032")]
	private MDEPBKMBPJG HCKMGLPPMJL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000033")]
	private PIPECKGFBCF JLIJBGJKIKN;

	[Cpp2IlInjected.Token(Token = "0x1700008F")]
	public MDEPBKMBPJG DGIDMBPBBIB
	{
		[Cpp2IlInjected.Token(Token = "0x600023A")]
		[Cpp2IlInjected.Address(RVA = "0x6FF4EC0", Offset = "0x6FF34C0", VA = "0x186FF4EC0", Slot = "6")]
		get
		{
			return default(MDEPBKMBPJG);
		}
		[Cpp2IlInjected.Token(Token = "0x600023B")]
		[Cpp2IlInjected.Address(RVA = "0x6FF5000", Offset = "0x6FF3600", VA = "0x186FF5000", Slot = "7")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000090")]
	private Transform JGEPHMGOAIJ
	{
		[Cpp2IlInjected.Token(Token = "0x600023C")]
		[Cpp2IlInjected.Address(RVA = "0x6FF50D0", Offset = "0x6FF36D0", VA = "0x186FF50D0", Slot = "10")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000020")]
	public event Action<GHLGGPNNOMD, GHLGGPNNOMD> JNNGKLBDCAB
	{
		[Cpp2IlInjected.Token(Token = "0x6000238")]
		[Cpp2IlInjected.Address(RVA = "0x6FF4D60", Offset = "0x6FF3360", VA = "0x186FF4D60", Slot = "4")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000239")]
		[Cpp2IlInjected.Address(RVA = "0x6FF4E10", Offset = "0x6FF3410", VA = "0x186FF4E10", Slot = "5")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600023D")]
	[Cpp2IlInjected.Address(RVA = "0x6FF50F0", Offset = "0x6FF36F0", VA = "0x186FF50F0")]
	public FHKEBCJAAIO(BDAEKEEHGON KOPJPDIAFKF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600023E")]
	[Cpp2IlInjected.Address(RVA = "0x6FF4AA0", Offset = "0x6FF30A0", VA = "0x186FF4AA0", Slot = "8")]
	public void BMDHDEMLIBC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600023F")]
	[Cpp2IlInjected.Address(RVA = "0x6FF4D10", Offset = "0x6FF3310", VA = "0x186FF4D10", Slot = "9")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000240")]
	[Cpp2IlInjected.Address(RVA = "0xA50860", Offset = "0xA4EE60", VA = "0x180A50860", Slot = "11")]
	private void FGNNEHBPNPH(GHLGGPNNOMD GFMIJGOEIBC, GHLGGPNNOMD LMCCPICICCC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000241")]
	[Cpp2IlInjected.Address(RVA = "0x85E9E0", Offset = "0x85CFE0", VA = "0x18085E9E0", Slot = "12")]
	private void MGDEGNBFACP(bool LCHODMNLLCG)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000026")]
public class DAPLKEBPIMI : HIACBNIDNKB
{
	[Cpp2IlInjected.Token(Token = "0x6000242")]
	[Cpp2IlInjected.Address(RVA = "0x6FF3890", Offset = "0x6FF1E90", VA = "0x186FF3890", Slot = "4")]
	public GMDDLFLGAPG DHMBCBMDMGO(BDAEKEEHGON ADLOKNICHMI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000243")]
	[Cpp2IlInjected.Address(RVA = "0x6FF3CC0", Offset = "0x6FF22C0", VA = "0x186FF3CC0", Slot = "5")]
	public EHMADKKELDA GFCNECICBKO(BDAEKEEHGON ADLOKNICHMI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000244")]
	[Cpp2IlInjected.Address(RVA = "0x6FF4180", Offset = "0x6FF2780", VA = "0x186FF4180", Slot = "6")]
	public FBEBDGAEMPK NACJCMPJFOE(BDAEKEEHGON ADLOKNICHMI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000245")]
	[Cpp2IlInjected.Address(RVA = "0x6FF4100", Offset = "0x6FF2700", VA = "0x186FF4100", Slot = "7")]
	public MJNCCHHAJHB MINNKMLNGFN(BDAEKEEHGON ADLOKNICHMI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000246")]
	[Cpp2IlInjected.Address(RVA = "0x6FF3F70", Offset = "0x6FF2570", VA = "0x186FF3F70", Slot = "8")]
	public CEKFDCFDGNB IMKLFCHBDHP(BDAEKEEHGON ADLOKNICHMI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000247")]
	[Cpp2IlInjected.Address(RVA = "0x6FF42B0", Offset = "0x6FF28B0", VA = "0x186FF42B0", Slot = "9")]
	public DBHCAHODFGJ PPEMDIBIOBD(BDAEKEEHGON ADLOKNICHMI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000248")]
	[Cpp2IlInjected.Address(RVA = "0x6FF3BA0", Offset = "0x6FF21A0", VA = "0x186FF3BA0", Slot = "10")]
	public PKBHNJMBMCL ELIEDKLFJOF(BDAEKEEHGON ADLOKNICHMI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000249")]
	[Cpp2IlInjected.Address(RVA = "0x6FF37D0", Offset = "0x6FF1DD0", VA = "0x186FF37D0", Slot = "11")]
	public EICNHMNGDHM DHJMPJJBCDH(BDAEKEEHGON ADLOKNICHMI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600024A")]
	[Cpp2IlInjected.Address(RVA = "0x6FF4040", Offset = "0x6FF2640", VA = "0x186FF4040", Slot = "12")]
	public BBHIJCOHKBE KGFPGIKGIKA(BDAEKEEHGON ADLOKNICHMI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600024B")]
	[Cpp2IlInjected.Address(RVA = "0x6FF3710", Offset = "0x6FF1D10", VA = "0x186FF3710", Slot = "13")]
	public GNHKGALPOEN CEFAANOIGCG(BDAEKEEHGON ADLOKNICHMI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600024C")]
	[Cpp2IlInjected.Address(RVA = "0x6FF3A60", Offset = "0x6FF2060", VA = "0x186FF3A60")]
	public CHEAFKNGDNE KDLPLJFJGPB(BDAEKEEHGON ADLOKNICHMI, [In] AHJPEDECEFI JHLEMCFOEMF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600024D")]
	[Cpp2IlInjected.Address(RVA = "0x6FF3DE0", Offset = "0x6FF23E0", VA = "0x186FF3DE0")]
	public HCMIIMNCCNN HOPJADMEONB(BDAEKEEHGON ADLOKNICHMI, [In] AHJPEDECEFI JHLEMCFOEMF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600024E")]
	[Cpp2IlInjected.Address(RVA = "0x6FF34C0", Offset = "0x6FF1AC0", VA = "0x186FF34C0")]
	public KILAKAEDOED HOMIKMJODAI(BDAEKEEHGON ADLOKNICHMI, [In] AHJPEDECEFI JHLEMCFOEMF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600024F")]
	[Cpp2IlInjected.Address(RVA = "0x6FF3330", Offset = "0x6FF1930", VA = "0x186FF3330")]
	public ALGPKHEMHDL LPGLMGJKDBI(BDAEKEEHGON ADLOKNICHMI, [In] AHJPEDECEFI JHLEMCFOEMF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000250")]
	[Cpp2IlInjected.Address(RVA = "0x6FF3980", Offset = "0x6FF1F80", VA = "0x186FF3980")]
	public FNAIMHFAGCI MDKILNCHICP(BDAEKEEHGON ADLOKNICHMI, [In] AHJPEDECEFI JHLEMCFOEMF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000251")]
	[Cpp2IlInjected.Address(RVA = "0x6FF35F0", Offset = "0x6FF1BF0", VA = "0x186FF35F0", Slot = "19")]
	public BDAEKEEHGON CDLFPPCMJPP(RigidbodyEx KOPJPDIAFKF, AHJPEDECEFI JHLEMCFOEMF, MNKFGLGCPDN FHLJNPENEDC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000252")]
	[Cpp2IlInjected.Address(RVA = "0x8692F0", Offset = "0x8678F0", VA = "0x1808692F0")]
	public DAPLKEBPIMI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000253")]
	[Cpp2IlInjected.Address(RVA = "0x6FF3A60", Offset = "0x6FF2060", VA = "0x186FF3A60", Slot = "14")]
	private CHEAFKNGDNE DOBHAECEOMM(BDAEKEEHGON ADLOKNICHMI, [In] AHJPEDECEFI JHLEMCFOEMF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000254")]
	[Cpp2IlInjected.Address(RVA = "0x6FF3DE0", Offset = "0x6FF23E0", VA = "0x186FF3DE0", Slot = "15")]
	private HCMIIMNCCNN JEGOIHEIKOM(BDAEKEEHGON ADLOKNICHMI, [In] AHJPEDECEFI JHLEMCFOEMF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000255")]
	[Cpp2IlInjected.Address(RVA = "0x6FF34C0", Offset = "0x6FF1AC0", VA = "0x186FF34C0", Slot = "16")]
	private KILAKAEDOED AMDMGJOINKG(BDAEKEEHGON ADLOKNICHMI, [In] AHJPEDECEFI JHLEMCFOEMF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000256")]
	[Cpp2IlInjected.Address(RVA = "0x6FF3330", Offset = "0x6FF1930", VA = "0x186FF3330", Slot = "17")]
	private ALGPKHEMHDL ADEFBPOLFFP(BDAEKEEHGON ADLOKNICHMI, [In] AHJPEDECEFI JHLEMCFOEMF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000257")]
	[Cpp2IlInjected.Address(RVA = "0x6FF3980", Offset = "0x6FF1F80", VA = "0x186FF3980", Slot = "18")]
	private FNAIMHFAGCI DLKLIHIGCBH(BDAEKEEHGON ADLOKNICHMI, [In] AHJPEDECEFI JHLEMCFOEMF)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000027")]
internal sealed class OKFKFDNMPGD : EICNHMNGDHM
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000034")]
	private readonly BHBLNBBNMEK KOPJPDIAFKF;

	[Cpp2IlInjected.Token(Token = "0x17000091")]
	private Rigidbody HMDFBMEBLAA
	{
		[Cpp2IlInjected.Token(Token = "0x6000258")]
		[Cpp2IlInjected.Address(RVA = "0x6FFAA00", Offset = "0x6FF9000", VA = "0x186FFAA00")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000092")]
	private bool NJMGKDGEJKC
	{
		[Cpp2IlInjected.Token(Token = "0x6000259")]
		[Cpp2IlInjected.Address(RVA = "0x6FFE180", Offset = "0x6FFC780", VA = "0x186FFE180")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000093")]
	private bool AOKPMFEJIHO
	{
		[Cpp2IlInjected.Token(Token = "0x600025A")]
		[Cpp2IlInjected.Address(RVA = "0x6FFA350", Offset = "0x6FF8950", VA = "0x186FFA350")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000094")]
	private BDAEKEEHGON LFKOPKGONIM
	{
		[Cpp2IlInjected.Token(Token = "0x600025B")]
		[Cpp2IlInjected.Address(RVA = "0x6FFE590", Offset = "0x6FFCB90", VA = "0x186FFE590")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600025C")]
	[Cpp2IlInjected.Address(RVA = "0x6FFAE60", Offset = "0x6FF9460", VA = "0x186FFAE60")]
	public OKFKFDNMPGD(BDAEKEEHGON KOPJPDIAFKF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600025D")]
	[Cpp2IlInjected.Address(RVA = "0x6FFE430", Offset = "0x6FFCA30", VA = "0x186FFE430", Slot = "4")]
	public void KJHEFIHDMOK(Vector3 EFJJGJMLHPN, ForceMode CDGNLODPNML = ForceMode.Force)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600025E")]
	[Cpp2IlInjected.Address(RVA = "0x6FFDCA0", Offset = "0x6FFC2A0", VA = "0x186FFDCA0")]
	private void HCILDLEKBHB(Vector3 EFJJGJMLHPN, ForceMode CDGNLODPNML)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600025F")]
	[Cpp2IlInjected.Address(RVA = "0x6FFDF00", Offset = "0x6FFC500", VA = "0x186FFDF00", Slot = "5")]
	public void HGEALHKPEMK(Vector3 EFJJGJMLHPN, Vector3 LPBGBJBIAOJ, ForceMode CDGNLODPNML)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000260")]
	[Cpp2IlInjected.Address(RVA = "0x6FFDB40", Offset = "0x6FFC140", VA = "0x186FFDB40", Slot = "6")]
	public void GAALLOJPDLM(Vector3 MJDDAPLCJDP, ForceMode CDGNLODPNML = ForceMode.Force)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000261")]
	[Cpp2IlInjected.Address(RVA = "0x6FFE1D0", Offset = "0x6FFC7D0", VA = "0x186FFE1D0")]
	private void KHJJFMKFJNB(Vector3 MJDDAPLCJDP, ForceMode CDGNLODPNML)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000262")]
	[Cpp2IlInjected.Address(RVA = "0x6FFD8E0", Offset = "0x6FFBEE0", VA = "0x186FFD8E0", Slot = "7")]
	public void FKDKHMNINIC(Vector3 MJDDAPLCJDP, ForceMode CDGNLODPNML = ForceMode.Force)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000028")]
internal sealed class ODKJGHKIOPA : GNHKGALPOEN
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000035")]
	private readonly BHBLNBBNMEK KOPJPDIAFKF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000036")]
	private bool HOHNFOAFBJM;

	[Cpp2IlInjected.Token(Token = "0x17000095")]
	public bool KNDBLJIACGF
	{
		[Cpp2IlInjected.Token(Token = "0x6000264")]
		[Cpp2IlInjected.Address(RVA = "0x96BEB0", Offset = "0x96A4B0", VA = "0x18096BEB0", Slot = "4")]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000265")]
		[Cpp2IlInjected.Address(RVA = "0x6FFD730", Offset = "0x6FFBD30", VA = "0x186FFD730", Slot = "5")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000263")]
	[Cpp2IlInjected.Address(RVA = "0x6FFAE60", Offset = "0x6FF9460", VA = "0x186FFAE60")]
	public ODKJGHKIOPA(BDAEKEEHGON KOPJPDIAFKF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000266")]
	[Cpp2IlInjected.Address(RVA = "0x6FFD8B0", Offset = "0x6FFBEB0", VA = "0x186FFD8B0", Slot = "6")]
	public void OJJJHIEHGGE(Rigidbody NNDHPDBLJFB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000267")]
	[Cpp2IlInjected.Address(RVA = "0x6FFD840", Offset = "0x6FFBE40", VA = "0x186FFD840", Slot = "7")]
	public void LFIMDILEDOP(Rigidbody NNDHPDBLJFB)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000029")]
internal sealed class HEOENCIAOBP : AFHIPHENKNM, GMDDLFLGAPG, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x4000040")]
	private readonly BDAEKEEHGON KOPJPDIAFKF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x4000041")]
	private readonly List<BDAEKEEHGON> AHIHNHAPOJJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x4000042")]
	private BDAEKEEHGON GOKNAIEAOEG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x4000043")]
	private BDAEKEEHGON LPFOFJIMHOE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
	[Cpp2IlInjected.Token(Token = "0x4000044")]
	private Transform NNKHJELOIHC;

	[Cpp2IlInjected.Token(Token = "0x17000096")]
	private Transform BFKELEPPJNO
	{
		[Cpp2IlInjected.Token(Token = "0x600027A")]
		[Cpp2IlInjected.Address(RVA = "0x6FF85E0", Offset = "0x6FF6BE0", VA = "0x186FF85E0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000097")]
	public BDAEKEEHGON LFKOPKGONIM
	{
		[Cpp2IlInjected.Token(Token = "0x600027D")]
		[Cpp2IlInjected.Address(RVA = "0x8656F0", Offset = "0x863CF0", VA = "0x1808656F0", Slot = "28")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600027E")]
		[Cpp2IlInjected.Address(RVA = "0x6FF7E40", Offset = "0x6FF6440", VA = "0x186FF7E40", Slot = "29")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000098")]
	public BDAEKEEHGON OCNEBKEFEDB
	{
		[Cpp2IlInjected.Token(Token = "0x600027F")]
		[Cpp2IlInjected.Address(RVA = "0x865680", Offset = "0x863C80", VA = "0x180865680", Slot = "27")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000099")]
	public IReadOnlyList<BDAEKEEHGON> FMKBBFGPKPL
	{
		[Cpp2IlInjected.Token(Token = "0x6000280")]
		[Cpp2IlInjected.Address(RVA = "0x861760", Offset = "0x85FD60", VA = "0x180861760", Slot = "26")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000021")]
	public event MNDKPJKMNOG ACOCHEILPHM
	{
		[Cpp2IlInjected.Token(Token = "0x6000268")]
		[Cpp2IlInjected.Address(RVA = "0x6FF8990", Offset = "0x6FF6F90", VA = "0x186FF8990", Slot = "8")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000269")]
		[Cpp2IlInjected.Address(RVA = "0x6FF8AE0", Offset = "0x6FF70E0", VA = "0x186FF8AE0", Slot = "9")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000022")]
	public event MNDKPJKMNOG BIJKDBLOKGF
	{
		[Cpp2IlInjected.Token(Token = "0x600026A")]
		[Cpp2IlInjected.Address(RVA = "0x6FF8700", Offset = "0x6FF6D00", VA = "0x186FF8700", Slot = "10")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600026B")]
		[Cpp2IlInjected.Address(RVA = "0x6FF8840", Offset = "0x6FF6E40", VA = "0x186FF8840", Slot = "11")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000023")]
	public event HFEPOIKNCFH NGCAAJLOGBI
	{
		[Cpp2IlInjected.Token(Token = "0x600026C")]
		[Cpp2IlInjected.Address(RVA = "0x6FF8D80", Offset = "0x6FF7380", VA = "0x186FF8D80", Slot = "12")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600026D")]
		[Cpp2IlInjected.Address(RVA = "0x6FF9260", Offset = "0x6FF7860", VA = "0x186FF9260", Slot = "13")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000024")]
	public event Action CLGCKNHBPHG
	{
		[Cpp2IlInjected.Token(Token = "0x600026E")]
		[Cpp2IlInjected.Address(RVA = "0x6FF8540", Offset = "0x6FF6B40", VA = "0x186FF8540", Slot = "14")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600026F")]
		[Cpp2IlInjected.Address(RVA = "0x6FF80C0", Offset = "0x6FF66C0", VA = "0x186FF80C0", Slot = "15")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000025")]
	public event Action PNELJAKBMCL
	{
		[Cpp2IlInjected.Token(Token = "0x6000270")]
		[Cpp2IlInjected.Address(RVA = "0x6FF8200", Offset = "0x6FF6800", VA = "0x186FF8200", Slot = "16")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000271")]
		[Cpp2IlInjected.Address(RVA = "0x6FF87A0", Offset = "0x6FF6DA0", VA = "0x186FF87A0", Slot = "17")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000026")]
	public event Action<BDAEKEEHGON> GIKJBKFPFMC
	{
		[Cpp2IlInjected.Token(Token = "0x6000272")]
		[Cpp2IlInjected.Address(RVA = "0x6FF82A0", Offset = "0x6FF68A0", VA = "0x186FF82A0", Slot = "18")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000273")]
		[Cpp2IlInjected.Address(RVA = "0x6FF88E0", Offset = "0x6FF6EE0", VA = "0x186FF88E0", Slot = "19")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000027")]
	public event Action<BDAEKEEHGON> HOJBEIODCKM
	{
		[Cpp2IlInjected.Token(Token = "0x6000274")]
		[Cpp2IlInjected.Address(RVA = "0x6FF8350", Offset = "0x6FF6950", VA = "0x186FF8350", Slot = "20")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000275")]
		[Cpp2IlInjected.Address(RVA = "0x6FF8A30", Offset = "0x6FF7030", VA = "0x186FF8A30", Slot = "21")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000028")]
	public event Action MGDPNGCLNJN
	{
		[Cpp2IlInjected.Token(Token = "0x6000276")]
		[Cpp2IlInjected.Address(RVA = "0x6FF8F70", Offset = "0x6FF7570", VA = "0x186FF8F70", Slot = "22")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000277")]
		[Cpp2IlInjected.Address(RVA = "0x6FF7DA0", Offset = "0x6FF63A0", VA = "0x186FF7DA0", Slot = "23")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000029")]
	public event Action<BDAEKEEHGON> OJKPCFGGKGP
	{
		[Cpp2IlInjected.Token(Token = "0x6000278")]
		[Cpp2IlInjected.Address(RVA = "0x6FF8CD0", Offset = "0x6FF72D0", VA = "0x186FF8CD0", Slot = "24")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000279")]
		[Cpp2IlInjected.Address(RVA = "0x6FF8C20", Offset = "0x6FF7220", VA = "0x186FF8C20", Slot = "25")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600027B")]
	[Cpp2IlInjected.Address(RVA = "0x6FF9BA0", Offset = "0x6FF81A0", VA = "0x186FF9BA0")]
	public HEOENCIAOBP(BDAEKEEHGON KOPJPDIAFKF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600027C")]
	[Cpp2IlInjected.Address(RVA = "0x6FF8160", Offset = "0x6FF6760", VA = "0x186FF8160", Slot = "31")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000281")]
	[Cpp2IlInjected.Address(RVA = "0x6FF9620", Offset = "0x6FF7C20", VA = "0x186FF9620", Slot = "30")]
	public void PPDMAPLEIEK(BDAEKEEHGON MFKKDCMMKOI, bool JBFNJGDBMCB = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000282")]
	[Cpp2IlInjected.Address(RVA = "0x6FF7E50", Offset = "0x6FF6450", VA = "0x186FF7E50", Slot = "6")]
	public void BEHGJHHILKJ(BDAEKEEHGON NDEGEBOFKHD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000283")]
	[Cpp2IlInjected.Address(RVA = "0x6FF9300", Offset = "0x6FF7900", VA = "0x186FF9300", Slot = "7")]
	public void OPIIHENCGFB(BDAEKEEHGON NDEGEBOFKHD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000284")]
	[Cpp2IlInjected.Address(RVA = "0x6FF8E20", Offset = "0x6FF7420", VA = "0x186FF8E20", Slot = "4")]
	public void MOGHPDEAFIL(BDAEKEEHGON KOPJPDIAFKF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000285")]
	[Cpp2IlInjected.Address(RVA = "0x6FF9580", Offset = "0x6FF7B80", VA = "0x186FF9580", Slot = "5")]
	public void PNPLADLDJCC(BDAEKEEHGON KOPJPDIAFKF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000286")]
	[Cpp2IlInjected.Address(RVA = "0x6FF8B80", Offset = "0x6FF7180", VA = "0x186FF8B80")]
	private void LKJHHHDPILK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000287")]
	[Cpp2IlInjected.Address(RVA = "0x6FF8F30", Offset = "0x6FF7530", VA = "0x186FF8F30")]
	private void NCJMPNGBEFL(BDAEKEEHGON NDEGEBOFKHD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000288")]
	[Cpp2IlInjected.Address(RVA = "0x6FF8400", Offset = "0x6FF6A00", VA = "0x186FF8400")]
	private void GDLJAGJNBEP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000289")]
	[Cpp2IlInjected.Address(RVA = "0x6FF9010", Offset = "0x6FF7610", VA = "0x186FF9010")]
	private void ODEHLHGGPPF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600028A")]
	[Cpp2IlInjected.Address(RVA = "0x6FF9140", Offset = "0x6FF7740", VA = "0x186FF9140")]
	private void ONECNLHLNIB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600028B")]
	[Cpp2IlInjected.Address(RVA = "0x6FF8640", Offset = "0x6FF6C40", VA = "0x186FF8640")]
	[CompilerGenerated]
	private object HCFPPMEOCCP()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200002A")]
internal static class GCGNCFJPNDC
{
	[Cpp2IlInjected.Token(Token = "0x600028C")]
	[Cpp2IlInjected.Address(RVA = "0x6FF7B40", Offset = "0x6FF6140", VA = "0x186FF7B40")]
	public static AFHIPHENKNM GOHMMCDPIII(this BDAEKEEHGON ADLOKNICHMI)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200002B")]
internal sealed class NPBBFEGHCIA : JONFPJCELDI, FBEBDGAEMPK
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000045")]
	private readonly BHBLNBBNMEK KOPJPDIAFKF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000046")]
	private readonly OLEKGJHHEJD<BDAEKEEHGON> DAJACBLKMJD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000047")]
	private bool BDLFNPPODOE;

	[Cpp2IlInjected.Token(Token = "0x1700009A")]
	public OLEKGJHHEJD<BDAEKEEHGON> FGHJHAMBGLL
	{
		[Cpp2IlInjected.Token(Token = "0x600028D")]
		[Cpp2IlInjected.Address(RVA = "0x85F4F0", Offset = "0x85DAF0", VA = "0x18085F4F0", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700009B")]
	public Vector3 MBNEMFLDGLF
	{
		[Cpp2IlInjected.Token(Token = "0x600028E")]
		[Cpp2IlInjected.Address(RVA = "0x6FFC980", Offset = "0x6FFAF80", VA = "0x186FFC980", Slot = "6")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700009C")]
	public Vector3 JIDNBMIAHAL
	{
		[Cpp2IlInjected.Token(Token = "0x600028F")]
		[Cpp2IlInjected.Address(RVA = "0x6FFCF30", Offset = "0x6FFB530", VA = "0x186FFCF30", Slot = "7")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700009D")]
	private Vector3 BADJMEGCDHI
	{
		[Cpp2IlInjected.Token(Token = "0x6000293")]
		[Cpp2IlInjected.Address(RVA = "0x6FFC9B0", Offset = "0x6FFAFB0", VA = "0x186FFC9B0")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700009E")]
	public BDAEKEEHGON EKGKLAMEDPC
	{
		[Cpp2IlInjected.Token(Token = "0x6000294")]
		[Cpp2IlInjected.Address(RVA = "0x6FFCE80", Offset = "0x6FFB480", VA = "0x186FFCE80", Slot = "5")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000290")]
	[Cpp2IlInjected.Address(RVA = "0x6FFD630", Offset = "0x6FFBC30", VA = "0x186FFD630")]
	public NPBBFEGHCIA(BDAEKEEHGON KOPJPDIAFKF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000291")]
	[Cpp2IlInjected.Address(RVA = "0x6FFD230", Offset = "0x6FFB830", VA = "0x186FFD230", Slot = "8")]
	public void PFEFGJCPNIN(BDAEKEEHGON LPFOFJIMHOE, object PNPIGCGKNPI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000292")]
	[Cpp2IlInjected.Address(RVA = "0x6FFCE20", Offset = "0x6FFB420", VA = "0x186FFCE20", Slot = "9")]
	public void KDIFJCGLFHF(object PNPIGCGKNPI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000295")]
	[Cpp2IlInjected.Address(RVA = "0x6FFD2A0", Offset = "0x6FFB8A0", VA = "0x186FFD2A0")]
	private Vector3 PMDOCANNEGI()
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000296")]
	[Cpp2IlInjected.Address(RVA = "0x6FFCA90", Offset = "0x6FFB090", VA = "0x186FFCA90")]
	private void HGDMIOLKFHP(BDAEKEEHGON DEPFDDANACP)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002C")]
internal static class EIFNALDKIEJ
{
	[Cpp2IlInjected.Token(Token = "0x6000297")]
	[Cpp2IlInjected.Address(RVA = "0x6FF46C0", Offset = "0x6FF2CC0", VA = "0x186FF46C0")]
	public static JONFPJCELDI CCINKPEENIC(this BDAEKEEHGON ADLOKNICHMI)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200002D")]
internal sealed class FIBJOMMDGEN : MDMMLMOKKAM, ALGPKHEMHDL
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000049")]
	private readonly BHBLNBBNMEK KOPJPDIAFKF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400004A")]
	private readonly OverridableVector3 CHEDGBOOAHJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400004B")]
	private readonly OverridableVector3 OHMOHLDNFBD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x400004C")]
	private float PKMEAMKOGOD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x44")]
	[Cpp2IlInjected.Token(Token = "0x400004D")]
	private float HLNMHMOBALL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x400004E")]
	private Vector3 BJBGMHCPJJH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x54")]
	[Cpp2IlInjected.Token(Token = "0x400004F")]
	private Vector3? BNCGIMNGHFM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x64")]
	[Cpp2IlInjected.Token(Token = "0x4000050")]
	private Quaternion? DOAAEBNGDCF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
	[Cpp2IlInjected.Token(Token = "0x4000051")]
	private bool AGAHIOOHDNF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x79")]
	[Cpp2IlInjected.Token(Token = "0x4000052")]
	private bool KIFMHELCFOM;

	[Cpp2IlInjected.Token(Token = "0x1700009F")]
	public Vector3 DKFJOMAEDCO
	{
		[Cpp2IlInjected.Token(Token = "0x600029A")]
		[Cpp2IlInjected.Address(RVA = "0xE52500", Offset = "0xE50B00", VA = "0x180E52500", Slot = "7")]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x600029B")]
		[Cpp2IlInjected.Address(RVA = "0x6FF5180", Offset = "0x6FF3780", VA = "0x186FF5180", Slot = "8")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A0")]
	public Vector3 NNPFPFLIHDA
	{
		[Cpp2IlInjected.Token(Token = "0x600029C")]
		[Cpp2IlInjected.Address(RVA = "0x6FF7430", Offset = "0x6FF5A30", VA = "0x186FF7430", Slot = "9")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A1")]
	public float FAFJBOGBGHI
	{
		[Cpp2IlInjected.Token(Token = "0x600029D")]
		[Cpp2IlInjected.Address(RVA = "0x96BEE0", Offset = "0x96A4E0", VA = "0x18096BEE0", Slot = "10")]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x600029E")]
		[Cpp2IlInjected.Address(RVA = "0x6FF6540", Offset = "0x6FF4B40", VA = "0x186FF6540")]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A2")]
	public float DJJBDPNNBOM
	{
		[Cpp2IlInjected.Token(Token = "0x600029F")]
		[Cpp2IlInjected.Address(RVA = "0x96BED0", Offset = "0x96A4D0", VA = "0x18096BED0", Slot = "11")]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x60002A0")]
		[Cpp2IlInjected.Address(RVA = "0x6FF53B0", Offset = "0x6FF39B0", VA = "0x186FF53B0", Slot = "12")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A3")]
	public Vector3 OHGBKDNCJHD
	{
		[Cpp2IlInjected.Token(Token = "0x60002A1")]
		[Cpp2IlInjected.Address(RVA = "0x6FF68C0", Offset = "0x6FF4EC0", VA = "0x186FF68C0", Slot = "13")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A4")]
	public Quaternion ICNCCFLKKGO
	{
		[Cpp2IlInjected.Token(Token = "0x60002A2")]
		[Cpp2IlInjected.Address(RVA = "0x6FF63C0", Offset = "0x6FF49C0", VA = "0x186FF63C0", Slot = "14")]
		get
		{
			return default(Quaternion);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A5")]
	private Rigidbody HMDFBMEBLAA
	{
		[Cpp2IlInjected.Token(Token = "0x60002AA")]
		[Cpp2IlInjected.Address(RVA = "0x6FF6870", Offset = "0x6FF4E70", VA = "0x186FF6870")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400002A")]
	public event MNDKPJKMNOG BCAMIMJCLBJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000298")]
		[Cpp2IlInjected.Address(RVA = "0x6FF5230", Offset = "0x6FF3830", VA = "0x186FF5230", Slot = "5")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000299")]
		[Cpp2IlInjected.Address(RVA = "0x6FF67D0", Offset = "0x6FF4DD0", VA = "0x186FF67D0", Slot = "6")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60002A3")]
	[Cpp2IlInjected.Address(RVA = "0x6FF79E0", Offset = "0x6FF5FE0", VA = "0x186FF79E0")]
	public FIBJOMMDGEN(BDAEKEEHGON KOPJPDIAFKF, [In] AHJPEDECEFI JHLEMCFOEMF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002A4")]
	[Cpp2IlInjected.Address(RVA = "0x6FF7280", Offset = "0x6FF5880", VA = "0x186FF7280", Slot = "17")]
	public void MANHEMLKMJP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002A5")]
	[Cpp2IlInjected.Address(RVA = "0x6FF52D0", Offset = "0x6FF38D0", VA = "0x186FF52D0", Slot = "16")]
	public void CEGIPIKKAML()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002A6")]
	[Cpp2IlInjected.Address(RVA = "0x6FF7530", Offset = "0x6FF5B30", VA = "0x186FF7530", Slot = "19")]
	public void OJJJHIEHGGE(Rigidbody NNDHPDBLJFB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002A7")]
	[Cpp2IlInjected.Address(RVA = "0x6FF7090", Offset = "0x6FF5690", VA = "0x186FF7090", Slot = "20")]
	public void LFIMDILEDOP(Rigidbody NNDHPDBLJFB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002A8")]
	[Cpp2IlInjected.Address(RVA = "0x6FF7840", Offset = "0x6FF5E40", VA = "0x186FF7840", Slot = "18")]
	public void PKPJPBHGIOD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002A9")]
	[Cpp2IlInjected.Address(RVA = "0x6FF6A50", Offset = "0x6FF5050", VA = "0x186FF6A50", Slot = "21")]
	public void KGKHPNFCOID()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002AB")]
	[Cpp2IlInjected.Address(RVA = "0x6FF5180", Offset = "0x6FF3780", VA = "0x186FF5180")]
	private void ADJHLMOHJKL(Vector3 FEBGGALLBNN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002AC")]
	[Cpp2IlInjected.Address(RVA = "0x6FF62D0", Offset = "0x6FF48D0", VA = "0x186FF62D0")]
	[Obsolete("This method is dangerous - the unity rigidbody is updated in a deferred manner and this world position may be stale")]
	private Vector3 FCDFKOAGJAG()
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x60002AD")]
	[Cpp2IlInjected.Address(RVA = "0x6FF6540", Offset = "0x6FF4B40", VA = "0x186FF6540")]
	private void HMGCJLIOKLM(float FEBGGALLBNN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002AE")]
	[Cpp2IlInjected.Address(RVA = "0x6FF53B0", Offset = "0x6FF39B0", VA = "0x186FF53B0")]
	private void CINHMNAHIJE(float FEBGGALLBNN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002AF")]
	[Cpp2IlInjected.Address(RVA = "0x6FF6EF0", Offset = "0x6FF54F0", VA = "0x186FF6EF0")]
	private Vector3 KGLANKCPCOD()
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x60002B0")]
	[Cpp2IlInjected.Address(RVA = "0x6FF7610", Offset = "0x6FF5C10", VA = "0x186FF7610", Slot = "15")]
	public void OJOCLKHEPKG((Quaternion rot, Vector3 moments) JEIDJBGOPFO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002B1")]
	[Cpp2IlInjected.Address(RVA = "0x6FF6650", Offset = "0x6FF4C50", VA = "0x186FF6650")]
	private Quaternion IELJPEGMJCD()
	{
		return default(Quaternion);
	}

	[Cpp2IlInjected.Token(Token = "0x60002B2")]
	[Cpp2IlInjected.Address(RVA = "0x6FF6200", Offset = "0x6FF4800", VA = "0x186FF6200")]
	public void DLMIDNAADBL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002B3")]
	[Cpp2IlInjected.Address(RVA = "0x6FF5460", Offset = "0x6FF3A60", VA = "0x186FF5460", Slot = "4")]
	public (float, Vector3) DLMIDNAADBL(Rigidbody KLEHOCGNLEP)
	{
		return default((float, Vector3));
	}
}
[Cpp2IlInjected.Token(Token = "0x200002E")]
internal static class IFJGNHEFBIG
{
	[Cpp2IlInjected.Token(Token = "0x60002B4")]
	[Cpp2IlInjected.Address(RVA = "0x6FF9E90", Offset = "0x6FF8490", VA = "0x186FF9E90")]
	public static MDMMLMOKKAM OPHJHBEHEIG(this BDAEKEEHGON ADLOKNICHMI)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200002F")]
internal sealed class JGBOGFIFMFI : KILAKAEDOED
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000053")]
	private readonly BHBLNBBNMEK KOPJPDIAFKF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000054")]
	private readonly PFNCBEJNFIN BKNOHDOHCMD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000055")]
	private readonly HOEMCLDCGOB GPLBGPNDJJK;

	[Cpp2IlInjected.Token(Token = "0x170000A6")]
	public bool LKGEHLAIGJO
	{
		[Cpp2IlInjected.Token(Token = "0x60002B5")]
		[Cpp2IlInjected.Address(RVA = "0x1004000", Offset = "0x1002600", VA = "0x181004000", Slot = "10")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A7")]
	public HOEMCLDCGOB FDDJLGALADM
	{
		[Cpp2IlInjected.Token(Token = "0x60002B6")]
		[Cpp2IlInjected.Address(RVA = "0x998B00", Offset = "0x997100", VA = "0x180998B00", Slot = "11")]
		get
		{
			return default(HOEMCLDCGOB);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60002B7")]
	[Cpp2IlInjected.Address(RVA = "0x6FFB5C0", Offset = "0x6FF9BC0", VA = "0x186FFB5C0")]
	public JGBOGFIFMFI(BDAEKEEHGON KOPJPDIAFKF, [In] AHJPEDECEFI JHLEMCFOEMF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002B8")]
	[Cpp2IlInjected.Address(RVA = "0x6FFB000", Offset = "0x6FF9600", VA = "0x186FFB000", Slot = "4")]
	public void BMDHDEMLIBC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002B9")]
	[Cpp2IlInjected.Address(RVA = "0x6FFB340", Offset = "0x6FF9940", VA = "0x186FFB340")]
	private bool HBCBNAMJBLE()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002BA")]
	[Cpp2IlInjected.Address(RVA = "0x6FFB590", Offset = "0x6FF9B90", VA = "0x186FFB590", Slot = "5")]
	public void MJAFCHMPHGA(object PNPIGCGKNPI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002BB")]
	[Cpp2IlInjected.Address(RVA = "0x6FFB200", Offset = "0x6FF9800", VA = "0x186FFB200", Slot = "6")]
	public void EFBIFBGHHAM(object PNPIGCGKNPI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002BC")]
	[Cpp2IlInjected.Address(RVA = "0x6FFB0D0", Offset = "0x6FF96D0", VA = "0x186FFB0D0", Slot = "9")]
	public void CFEKKLAOCJH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002BD")]
	[Cpp2IlInjected.Address(RVA = "0x6FFB230", Offset = "0x6FF9830", VA = "0x186FFB230")]
	private void ENCNLMFACCE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002BE")]
	[Cpp2IlInjected.Address(RVA = "0x6FFB420", Offset = "0x6FF9A20", VA = "0x186FFB420")]
	private void LGLOLIOJMHE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002BF")]
	[Cpp2IlInjected.Address(RVA = "0x6FFAFC0", Offset = "0x6FF95C0", VA = "0x186FFAFC0", Slot = "8")]
	public void BIGDEABKMLM(BDAEKEEHGON KOPJPDIAFKF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002C0")]
	[Cpp2IlInjected.Address(RVA = "0x6FFB3E0", Offset = "0x6FF99E0", VA = "0x186FFB3E0", Slot = "7")]
	public void KLJIPHLEHAH(BDAEKEEHGON KOPJPDIAFKF)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000030")]
internal sealed class MJOKBPDEMIC : PKBHNJMBMCL
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000057")]
	private readonly BHBLNBBNMEK KOPJPDIAFKF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000058")]
	private readonly PFNCBEJNFIN JPMEMOKPCFB;

	[Cpp2IlInjected.Token(Token = "0x170000A8")]
	public bool NJMGKDGEJKC
	{
		[Cpp2IlInjected.Token(Token = "0x60002C3")]
		[Cpp2IlInjected.Address(RVA = "0x6FFC620", Offset = "0x6FFAC20", VA = "0x186FFC620", Slot = "6")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400002B")]
	public event MNDKPJKMNOG ONOLPJLNMOJ
	{
		[Cpp2IlInjected.Token(Token = "0x60002C1")]
		[Cpp2IlInjected.Address(RVA = "0x6FFC570", Offset = "0x6FFAB70", VA = "0x186FFC570", Slot = "4")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60002C2")]
		[Cpp2IlInjected.Address(RVA = "0x6FFC4C0", Offset = "0x6FFAAC0", VA = "0x186FFC4C0", Slot = "5")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60002C4")]
	[Cpp2IlInjected.Address(RVA = "0x6FFC890", Offset = "0x6FFAE90", VA = "0x186FFC890")]
	public MJOKBPDEMIC(BDAEKEEHGON KOPJPDIAFKF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002C5")]
	[Cpp2IlInjected.Address(RVA = "0x6FFC560", Offset = "0x6FFAB60", VA = "0x186FFC560", Slot = "7")]
	public void DHONMCJFNPK(object PNPIGCGKNPI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002C6")]
	[Cpp2IlInjected.Address(RVA = "0x6FFC610", Offset = "0x6FFAC10", VA = "0x186FFC610", Slot = "8")]
	public void IFPKGBJENPI(object PNPIGCGKNPI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002C7")]
	[Cpp2IlInjected.Address(RVA = "0x6FFC780", Offset = "0x6FFAD80", VA = "0x186FFC780", Slot = "9")]
	public void PAEILMBBFPG(object PNPIGCGKNPI, bool JIJGAKFGIEE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002C8")]
	[Cpp2IlInjected.Address(RVA = "0x6FFC480", Offset = "0x6FFAA80", VA = "0x186FFC480", Slot = "12")]
	public void DBCDNEHJLLG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002C9")]
	[Cpp2IlInjected.Address(RVA = "0x6FFC700", Offset = "0x6FFAD00", VA = "0x186FFC700", Slot = "10")]
	public void OJJJHIEHGGE(Rigidbody KJDLJANECIL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002CA")]
	[Cpp2IlInjected.Address(RVA = "0x6FFC6D0", Offset = "0x6FFACD0", VA = "0x186FFC6D0", Slot = "11")]
	public void LFIMDILEDOP(Rigidbody NNDHPDBLJFB)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000031")]
internal sealed class LJEBHNIICEN : ALCLGDPPEIA, HCMIIMNCCNN, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400005A")]
	private readonly BHBLNBBNMEK KOPJPDIAFKF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400005B")]
	private PhotonView EMHLDEEKDPM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400005C")]
	private bool ENLJCBIAPDK;

	[Cpp2IlInjected.Token(Token = "0x170000A9")]
	public PhotonView AKMDDPBHFFI
	{
		[Cpp2IlInjected.Token(Token = "0x60002CD")]
		[Cpp2IlInjected.Address(RVA = "0x85F450", Offset = "0x85DA50", VA = "0x18085F450", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000AA")]
	public bool EHDKHGMLCIH
	{
		[Cpp2IlInjected.Token(Token = "0x60002CE")]
		[Cpp2IlInjected.Address(RVA = "0x6FFBE10", Offset = "0x6FFA410", VA = "0x186FFBE10", Slot = "7")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000AB")]
	public bool GLELLFOFKJP
	{
		[Cpp2IlInjected.Token(Token = "0x60002CF")]
		[Cpp2IlInjected.Address(RVA = "0xB4FA90", Offset = "0xB4E090", VA = "0x180B4FA90", Slot = "8")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400002C")]
	public event MNDKPJKMNOG JKJMDMPHJFN
	{
		[Cpp2IlInjected.Token(Token = "0x60002CB")]
		[Cpp2IlInjected.Address(RVA = "0x6FFBD70", Offset = "0x6FFA370", VA = "0x186FFBD70", Slot = "5")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60002CC")]
		[Cpp2IlInjected.Address(RVA = "0x6FFB830", Offset = "0x6FF9E30", VA = "0x186FFB830", Slot = "6")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60002D0")]
	[Cpp2IlInjected.Address(RVA = "0x6FFC260", Offset = "0x6FFA860", VA = "0x186FFC260")]
	public LJEBHNIICEN(BDAEKEEHGON KOPJPDIAFKF, [In] AHJPEDECEFI JHLEMCFOEMF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002D1")]
	[Cpp2IlInjected.Address(RVA = "0x6FFB8D0", Offset = "0x6FF9ED0", VA = "0x186FFB8D0", Slot = "9")]
	public void BMDHDEMLIBC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002D2")]
	[Cpp2IlInjected.Address(RVA = "0x6FFBC70", Offset = "0x6FFA270", VA = "0x186FFBC70", Slot = "12")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002D3")]
	[Cpp2IlInjected.Address(RVA = "0x6FFB6C0", Offset = "0x6FF9CC0", VA = "0x186FFB6C0", Slot = "10")]
	public void AAICGDBFFIE(BDAEKEEHGON LPFOFJIMHOE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002D4")]
	[Cpp2IlInjected.Address(RVA = "0x6FFBFA0", Offset = "0x6FFA5A0", VA = "0x186FFBFA0", Slot = "11")]
	public void MKHPKMIJDKB(BDAEKEEHGON LPFOFJIMHOE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002D5")]
	[Cpp2IlInjected.Address(RVA = "0x6FFBE30", Offset = "0x6FFA430", VA = "0x186FFBE30")]
	private void MJIAHIGNHNF(PhotonView NGANCIADCCL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002D6")]
	[Cpp2IlInjected.Address(RVA = "0x6FFC110", Offset = "0x6FFA710", VA = "0x186FFC110")]
	private void OLFJECHIKPL(ANCEECHCKHO BOLBACPDDBP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002D7")]
	[Cpp2IlInjected.Address(RVA = "0x6FFBA00", Offset = "0x6FFA000", VA = "0x186FFBA00")]
	private void DDIEKBMJCOB(PhotonView OODMFEKONPD)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000032")]
internal static class ADNIODJEMPA
{
	[Cpp2IlInjected.Token(Token = "0x60002D8")]
	[Cpp2IlInjected.Address(RVA = "0x6FE9980", Offset = "0x6FE7F80", VA = "0x186FE9980")]
	public static ALCLGDPPEIA OMIBFGIPEHF(this BDAEKEEHGON ADLOKNICHMI)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000033")]
internal sealed class HJHJCFPHCAN : FNAIMHFAGCI
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400005D")]
	private readonly BHBLNBBNMEK KOPJPDIAFKF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400005E")]
	private RigidbodyConstraints MCCMJELOOAG;

	[Cpp2IlInjected.Token(Token = "0x170000AC")]
	public bool AGLKOCOGMJP
	{
		[Cpp2IlInjected.Token(Token = "0x60002D9")]
		[Cpp2IlInjected.Address(RVA = "0x96BE20", Offset = "0x96A420", VA = "0x18096BE20", Slot = "4")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x60002DA")]
		[Cpp2IlInjected.Address(RVA = "0x455E9D0", Offset = "0x455CFD0", VA = "0x18455E9D0", Slot = "5")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000AD")]
	public bool OAPGJCKDFMM
	{
		[Cpp2IlInjected.Token(Token = "0x60002DB")]
		[Cpp2IlInjected.Address(RVA = "0x96BE40", Offset = "0x96A440", VA = "0x18096BE40", Slot = "6")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x60002DC")]
		[Cpp2IlInjected.Address(RVA = "0x455E9C0", Offset = "0x455CFC0", VA = "0x18455E9C0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000AE")]
	public RigidbodyConstraints ENAJGFPFLFD
	{
		[Cpp2IlInjected.Token(Token = "0x60002DD")]
		[Cpp2IlInjected.Address(RVA = "0x861EB0", Offset = "0x8604B0", VA = "0x180861EB0", Slot = "7")]
		get
		{
			return default(RigidbodyConstraints);
		}
		[Cpp2IlInjected.Token(Token = "0x60002DE")]
		[Cpp2IlInjected.Address(RVA = "0x6FF9C60", Offset = "0x6FF8260", VA = "0x186FF9C60", Slot = "8")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60002DF")]
	[Cpp2IlInjected.Address(RVA = "0x6FF9DF0", Offset = "0x6FF83F0", VA = "0x186FF9DF0")]
	public HJHJCFPHCAN(BDAEKEEHGON KOPJPDIAFKF, [In] AHJPEDECEFI JHLEMCFOEMF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002E0")]
	[Cpp2IlInjected.Address(RVA = "0x6FF9DC0", Offset = "0x6FF83C0", VA = "0x186FF9DC0", Slot = "9")]
	public void OJJJHIEHGGE(Rigidbody NNDHPDBLJFB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002E1")]
	[Cpp2IlInjected.Address(RVA = "0x6FF9D90", Offset = "0x6FF8390", VA = "0x186FF9D90", Slot = "10")]
	public void LFIMDILEDOP(Rigidbody NNDHPDBLJFB)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000034")]
internal sealed class DCDIJIOCLNI : MJNCCHHAJHB
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000061")]
	private readonly BDAEKEEHGON KOPJPDIAFKF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000062")]
	private float MCJJGNAOPFB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
	[Cpp2IlInjected.Token(Token = "0x4000063")]
	private float OLLDGKMLIHF;

	[Cpp2IlInjected.Token(Token = "0x170000AF")]
	public float EELOHFPMINJ
	{
		[Cpp2IlInjected.Token(Token = "0x60002E3")]
		[Cpp2IlInjected.Address(RVA = "0x9A4C70", Offset = "0x9A3270", VA = "0x1809A4C70", Slot = "4")]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x60002E4")]
		[Cpp2IlInjected.Address(RVA = "0x6FF4420", Offset = "0x6FF2A20", VA = "0x186FF4420", Slot = "5")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B0")]
	public float EMANFDKKNOA
	{
		[Cpp2IlInjected.Token(Token = "0x60002E5")]
		[Cpp2IlInjected.Address(RVA = "0x9A4C60", Offset = "0x9A3260", VA = "0x1809A4C60", Slot = "6")]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x60002E6")]
		[Cpp2IlInjected.Address(RVA = "0x6FF44F0", Offset = "0x6FF2AF0", VA = "0x186FF44F0", Slot = "7")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60002E2")]
	[Cpp2IlInjected.Address(RVA = "0x6FF4610", Offset = "0x6FF2C10", VA = "0x186FF4610")]
	public DCDIJIOCLNI(BDAEKEEHGON KOPJPDIAFKF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002E7")]
	[Cpp2IlInjected.Address(RVA = "0x6FF45C0", Offset = "0x6FF2BC0", VA = "0x186FF45C0", Slot = "8")]
	public void OJJJHIEHGGE(Rigidbody NNDHPDBLJFB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002E8")]
	[Cpp2IlInjected.Address(RVA = "0x6FF4380", Offset = "0x6FF2980", VA = "0x186FF4380", Slot = "9")]
	public void LFIMDILEDOP(Rigidbody NNDHPDBLJFB)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000035")]
internal sealed class PHBBGKAOBGE : CEKFDCFDGNB
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000065")]
	private readonly BHBLNBBNMEK KOPJPDIAFKF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000066")]
	private bool FNJELFKFKPH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x21")]
	[Cpp2IlInjected.Token(Token = "0x4000067")]
	private bool ELBPNOFNJNF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
	[Cpp2IlInjected.Token(Token = "0x4000068")]
	private int KFDCKDJMGPO;

	[Cpp2IlInjected.Token(Token = "0x170000B1")]
	private Rigidbody HMDFBMEBLAA
	{
		[Cpp2IlInjected.Token(Token = "0x60002EB")]
		[Cpp2IlInjected.Address(RVA = "0x6FF6870", Offset = "0x6FF4E70", VA = "0x186FF6870")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B2")]
	private bool MIIHMFPAKOK
	{
		[Cpp2IlInjected.Token(Token = "0x60002EC")]
		[Cpp2IlInjected.Address(RVA = "0x6FFF8B0", Offset = "0x6FFDEB0", VA = "0x186FFF8B0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B3")]
	private BDAEKEEHGON LFKOPKGONIM
	{
		[Cpp2IlInjected.Token(Token = "0x60002ED")]
		[Cpp2IlInjected.Address(RVA = "0x6FFFA10", Offset = "0x6FFE010", VA = "0x186FFFA10")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B4")]
	private bool AOKPMFEJIHO
	{
		[Cpp2IlInjected.Token(Token = "0x60002EE")]
		[Cpp2IlInjected.Address(RVA = "0x6FFF690", Offset = "0x6FFDC90", VA = "0x186FFF690")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400002D")]
	public event MNDKPJKMNOG AFEKEEPHDEO
	{
		[Cpp2IlInjected.Token(Token = "0x60002E9")]
		[Cpp2IlInjected.Address(RVA = "0x6FFF1E0", Offset = "0x6FFD7E0", VA = "0x186FFF1E0", Slot = "4")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60002EA")]
		[Cpp2IlInjected.Address(RVA = "0x6FFF970", Offset = "0x6FFDF70", VA = "0x186FFF970", Slot = "5")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60002EF")]
	[Cpp2IlInjected.Address(RVA = "0x6FFFC50", Offset = "0x6FFE250", VA = "0x186FFFC50")]
	public PHBBGKAOBGE(BDAEKEEHGON KOPJPDIAFKF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002F0")]
	[Cpp2IlInjected.Address(RVA = "0x6FFF3D0", Offset = "0x6FFD9D0", VA = "0x186FFF3D0", Slot = "6")]
	public void BMDHDEMLIBC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002F1")]
	[Cpp2IlInjected.Address(RVA = "0x6FFF8A0", Offset = "0x6FFDEA0", VA = "0x186FFF8A0", Slot = "8")]
	public void HONDKPAAEJK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002F2")]
	[Cpp2IlInjected.Address(RVA = "0x6FFF280", Offset = "0x6FFD880", VA = "0x186FFF280", Slot = "7")]
	public bool AOCFCKBPOGJ()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002F3")]
	[Cpp2IlInjected.Address(RVA = "0x6FFF5F0", Offset = "0x6FFDBF0", VA = "0x186FFF5F0", Slot = "9")]
	public void CAJEOIOLNEH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002F4")]
	[Cpp2IlInjected.Address(RVA = "0x6FFF8D0", Offset = "0x6FFDED0", VA = "0x186FFF8D0", Slot = "11")]
	public void KKPNCKGMGKM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002F5")]
	[Cpp2IlInjected.Address(RVA = "0x6FFF6F0", Offset = "0x6FFDCF0", VA = "0x186FFF6F0", Slot = "10")]
	public void HLLLNIILIDL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002F6")]
	[Cpp2IlInjected.Address(RVA = "0x6FFFA70", Offset = "0x6FFE070", VA = "0x186FFFA70")]
	private bool PJLJHKPGKHA()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002F7")]
	[Cpp2IlInjected.Address(RVA = "0x6FFF460", Offset = "0x6FFDA60", VA = "0x186FFF460")]
	private void BOCIAJLANLB()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000036")]
internal sealed class IJNPNDAFGNE : CHEAFKNGDNE
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000069")]
	private readonly BHBLNBBNMEK KOPJPDIAFKF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400006A")]
	private readonly PFNCBEJNFIN EOOKAIBHEBH;

	[Cpp2IlInjected.Token(Token = "0x170000B5")]
	public Rigidbody HMDFBMEBLAA
	{
		[Cpp2IlInjected.Token(Token = "0x60002F8")]
		[Cpp2IlInjected.Address(RVA = "0x85F450", Offset = "0x85DA50", VA = "0x18085F450", Slot = "4")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60002F9")]
		[Cpp2IlInjected.Address(RVA = "0x85F460", Offset = "0x85DA60", VA = "0x18085F460")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B6")]
	private bool AOKPMFEJIHO
	{
		[Cpp2IlInjected.Token(Token = "0x60002FA")]
		[Cpp2IlInjected.Address(RVA = "0x6FFA350", Offset = "0x6FF8950", VA = "0x186FFA350")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B7")]
	public bool NDPAFPHFDOG
	{
		[Cpp2IlInjected.Token(Token = "0x60002FD")]
		[Cpp2IlInjected.Address(RVA = "0x1004000", Offset = "0x1002600", VA = "0x181004000", Slot = "6")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60002FB")]
	[Cpp2IlInjected.Address(RVA = "0x6FFA750", Offset = "0x6FF8D50", VA = "0x186FFA750")]
	public IJNPNDAFGNE(BDAEKEEHGON KOPJPDIAFKF, [In] AHJPEDECEFI JHLEMCFOEMF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002FC")]
	[Cpp2IlInjected.Address(RVA = "0x6FF9F50", Offset = "0x6FF8550", VA = "0x186FF9F50", Slot = "5")]
	public void BMDHDEMLIBC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002FE")]
	[Cpp2IlInjected.Address(RVA = "0x6FFA530", Offset = "0x6FF8B30", VA = "0x186FFA530", Slot = "7")]
	public void LFGHNJFKEON(object PNPIGCGKNPI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002FF")]
	[Cpp2IlInjected.Address(RVA = "0x6FFA320", Offset = "0x6FF8920", VA = "0x186FFA320", Slot = "8")]
	public void DPEPKDOFMAH(object PNPIGCGKNPI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000300")]
	[Cpp2IlInjected.Address(RVA = "0x6FF9FF0", Offset = "0x6FF85F0", VA = "0x186FF9FF0", Slot = "9")]
	public void CAFLGPLMEIO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000301")]
	[Cpp2IlInjected.Address(RVA = "0x6FFA560", Offset = "0x6FF8B60", VA = "0x186FFA560", Slot = "10")]
	public void OOFJHGPGFGF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000302")]
	[Cpp2IlInjected.Address(RVA = "0x6FFA3B0", Offset = "0x6FF89B0", VA = "0x186FFA3B0", Slot = "11")]
	public void HHEMMJEGDIB()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000037")]
internal sealed class BABFJJCHNLJ : EHMADKKELDA, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400006C")]
	private readonly BHBLNBBNMEK KOPJPDIAFKF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400006D")]
	private readonly PFNCBEJNFIN BPEKMNDAGOE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400006E")]
	private float GDJHNEPGHJF;

	[Cpp2IlInjected.Token(Token = "0x170000B8")]
	public JJIBDEODFOK GMKEMPMJJEG
	{
		[Cpp2IlInjected.Token(Token = "0x6000303")]
		[Cpp2IlInjected.Address(RVA = "0x860D20", Offset = "0x85F320", VA = "0x180860D20", Slot = "4")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000304")]
		[Cpp2IlInjected.Address(RVA = "0x860CF0", Offset = "0x85F2F0", VA = "0x180860CF0", Slot = "5")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B9")]
	public FPCFKNJLJNF MEECOILDIGD
	{
		[Cpp2IlInjected.Token(Token = "0x6000305")]
		[Cpp2IlInjected.Address(RVA = "0x860D00", Offset = "0x85F300", VA = "0x180860D00", Slot = "6")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000306")]
		[Cpp2IlInjected.Address(RVA = "0x860D10", Offset = "0x85F310", VA = "0x180860D10", Slot = "7")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000BA")]
	public Vector3 BADJMEGCDHI
	{
		[Cpp2IlInjected.Token(Token = "0x6000307")]
		[Cpp2IlInjected.Address(RVA = "0x6FEB990", Offset = "0x6FE9F90", VA = "0x186FEB990", Slot = "8")]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x6000308")]
		[Cpp2IlInjected.Address(RVA = "0x6FEC470", Offset = "0x6FEAA70", VA = "0x186FEC470", Slot = "9")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000BB")]
	public Vector3 PICKJKOADLG
	{
		[Cpp2IlInjected.Token(Token = "0x6000309")]
		[Cpp2IlInjected.Address(RVA = "0x6FE9EE0", Offset = "0x6FE84E0", VA = "0x186FE9EE0", Slot = "10")]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x600030A")]
		[Cpp2IlInjected.Address(RVA = "0x6FEC440", Offset = "0x6FEAA40", VA = "0x186FEC440", Slot = "11")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000BC")]
	public Vector3 LKOMBEBAIAN
	{
		[Cpp2IlInjected.Token(Token = "0x600030B")]
		[Cpp2IlInjected.Address(RVA = "0x6FEC5E0", Offset = "0x6FEABE0", VA = "0x186FEC5E0", Slot = "12")]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x600030C")]
		[Cpp2IlInjected.Address(RVA = "0x6FEBFF0", Offset = "0x6FEA5F0", VA = "0x186FEBFF0", Slot = "13")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000BD")]
	public Vector3 ABDFNNIMIHN
	{
		[Cpp2IlInjected.Token(Token = "0x600030D")]
		[Cpp2IlInjected.Address(RVA = "0x6FEACA0", Offset = "0x6FE92A0", VA = "0x186FEACA0", Slot = "14")]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x600030E")]
		[Cpp2IlInjected.Address(RVA = "0x6FE9C80", Offset = "0x6FE8280", VA = "0x186FE9C80", Slot = "15")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000BE")]
	public float HLEAJEMEJIJ
	{
		[Cpp2IlInjected.Token(Token = "0x600030F")]
		[Cpp2IlInjected.Address(RVA = "0x96BEF0", Offset = "0x96A4F0", VA = "0x18096BEF0", Slot = "16")]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x6000310")]
		[Cpp2IlInjected.Address(RVA = "0x6FEA9D0", Offset = "0x6FE8FD0", VA = "0x186FEA9D0", Slot = "17")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000BF")]
	public bool DMKJEPELOOK
	{
		[Cpp2IlInjected.Token(Token = "0x6000311")]
		[Cpp2IlInjected.Address(RVA = "0x197B570", Offset = "0x1979B70", VA = "0x18197B570", Slot = "18")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000C0")]
	private EICNHMNGDHM PJHPJLJKAMM
	{
		[Cpp2IlInjected.Token(Token = "0x6000326")]
		[Cpp2IlInjected.Address(RVA = "0x6831750", Offset = "0x682FD50", VA = "0x186831750")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000C1")]
	private bool MIIHMFPAKOK
	{
		[Cpp2IlInjected.Token(Token = "0x6000327")]
		[Cpp2IlInjected.Address(RVA = "0x6FEBFD0", Offset = "0x6FEA5D0", VA = "0x186FEBFD0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000312")]
	[Cpp2IlInjected.Address(RVA = "0x6FED170", Offset = "0x6FEB770", VA = "0x186FED170")]
	public BABFJJCHNLJ(BDAEKEEHGON KOPJPDIAFKF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000313")]
	[Cpp2IlInjected.Address(RVA = "0x6FE9E40", Offset = "0x6FE8440", VA = "0x186FE9E40", Slot = "19")]
	public void BMDHDEMLIBC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000314")]
	[Cpp2IlInjected.Address(RVA = "0x6FEA970", Offset = "0x6FE8F70", VA = "0x186FEA970", Slot = "36")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000315")]
	[Cpp2IlInjected.Address(RVA = "0x6FECEC0", Offset = "0x6FEB4C0", VA = "0x186FECEC0", Slot = "28")]
	public void OJJJHIEHGGE(Rigidbody NNDHPDBLJFB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000316")]
	[Cpp2IlInjected.Address(RVA = "0xE0D600", Offset = "0xE0BC00", VA = "0x180E0D600", Slot = "20")]
	public void LAIONIMADAA(object PNPIGCGKNPI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000317")]
	[Cpp2IlInjected.Address(RVA = "0xE0E570", Offset = "0xE0CB70", VA = "0x180E0E570", Slot = "30")]
	public void FNKAHOCOHKF(object PNPIGCGKNPI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000318")]
	[Cpp2IlInjected.Address(RVA = "0x6FEC7A0", Offset = "0x6FEADA0", VA = "0x186FEC7A0", Slot = "35")]
	public Vector3 OCHFKMGFHBD(Vector3 FGAFOHDCFPB)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000319")]
	[Cpp2IlInjected.Address(RVA = "0x6FEAAE0", Offset = "0x6FE90E0", VA = "0x186FEAAE0", Slot = "34")]
	public Vector3 EILJJNPMFLF(Vector3 DOEHELKGDBK)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x600031A")]
	[Cpp2IlInjected.Address(RVA = "0x6FE9E40", Offset = "0x6FE8440", VA = "0x186FE9E40", Slot = "27")]
	public void OADDMHBKMMD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600031B")]
	[Cpp2IlInjected.Address(RVA = "0x6FEAE30", Offset = "0x6FE9430", VA = "0x186FEAE30", Slot = "25")]
	public void FAHHCFFEONM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600031C")]
	[Cpp2IlInjected.Address(RVA = "0x6FEC0B0", Offset = "0x6FEA6B0", VA = "0x186FEC0B0", Slot = "24")]
	public void JOIAPFKMNHH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600031D")]
	[Cpp2IlInjected.Address(RVA = "0x6FE9A40", Offset = "0x6FE8040", VA = "0x186FE9A40", Slot = "33")]
	public void ABBFOCFOCGJ(Vector3 CAJPCDAIFIP, Vector3 CHILFEFILCK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600031E")]
	[Cpp2IlInjected.Address(RVA = "0x6FEBCF0", Offset = "0x6FEA2F0", VA = "0x186FEBCF0", Slot = "32")]
	public void IHKEKHHCCOO(Vector3 HLJCNLEDNPM, Vector3 AAPEKCHOAIG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600031F")]
	[Cpp2IlInjected.Address(RVA = "0x6FEC110", Offset = "0x6FEA710", VA = "0x186FEC110", Slot = "31")]
	public void KFJEPNEFPMA(Vector3 LNOIGBIBALG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000320")]
	[Cpp2IlInjected.Address(RVA = "0x6FEC980", Offset = "0x6FEAF80", VA = "0x186FEC980", Slot = "22")]
	public void OHGAIHKHGIM(ICCPFOEOBPC NHNBBPPCADG, Vector3 NIHMGKDKFLI, float GFCGIPHILDG, float AMJDFLLFOGG = 8f, float NMPDDKIDGKC = 1f)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000321")]
	[Cpp2IlInjected.Address(RVA = "0x6FEBD50", Offset = "0x6FEA350", VA = "0x186FEBD50", Slot = "21")]
	public void IIDCCGIKHJM(IBINHLJGAJL EDEBFCKHCOB, Vector3 BDOGOHDDNFF, float PGHAPCLIBGC = float.PositiveInfinity)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000322")]
	[Cpp2IlInjected.Address(RVA = "0x6FEB510", Offset = "0x6FE9B10", VA = "0x186FEB510", Slot = "23")]
	[Obsolete("Deprecated. Still exists to support deprecated CV2 chips. Use ApplyAngularVelocityChange.")]
	public void GIJGAEIJIBG(IBINHLJGAJL EDEBFCKHCOB, Vector3 CNNBBFFJNHM, float JNOOKKEDJLJ = 7f, float GPKBFHCKJJI = 1f)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000323")]
	[Cpp2IlInjected.Address(RVA = "0xF3A650", Offset = "0xF38C50", VA = "0x180F3A650")]
	private static void JMCCDOPBJKE(Vector3 FPMFPAANFEC, Vector3 FKPHICIEEGL, [Out] Vector3 OPNCFINKHJE, [Out] Vector3 BJCKPGFDJLE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000324")]
	[Cpp2IlInjected.Address(RVA = "0x6FEAE90", Offset = "0x6FE9490", VA = "0x186FEAE90", Slot = "29")]
	public Vector3 FONKOLKJNID(Vector3 FPMFPAANFEC)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000325")]
	[Cpp2IlInjected.Address(RVA = "0x6FEC2B0", Offset = "0x6FEA8B0", VA = "0x186FEC2B0", Slot = "26")]
	public void KOECGAKFNDD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000328")]
	[Cpp2IlInjected.Address(RVA = "0x6FEA9D0", Offset = "0x6FE8FD0", VA = "0x186FEA9D0")]
	private void EBPONGIFLFP(float FEBGGALLBNN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000329")]
	[Cpp2IlInjected.Address(RVA = "0x6FEBB50", Offset = "0x6FEA150", VA = "0x186FEBB50")]
	private void HONGMCKGNFI(Vector3 BDOGOHDDNFF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600032A")]
	[Cpp2IlInjected.Address(RVA = "0x6FECFF0", Offset = "0x6FEB5F0", VA = "0x186FECFF0")]
	private Vector3 PPGNHPLPCDE()
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x600032B")]
	[Cpp2IlInjected.Address(RVA = "0x6FEA070", Offset = "0x6FE8670", VA = "0x186FEA070")]
	private void CNBPOGFNJAI(Vector3 DOEHELKGDBK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600032C")]
	[Cpp2IlInjected.Address(RVA = "0x6FE9CB0", Offset = "0x6FE82B0", VA = "0x186FE9CB0")]
	private Vector3 BGJOGMDFAOJ()
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x600032D")]
	[Cpp2IlInjected.Address(RVA = "0x6FEA4F0", Offset = "0x6FE8AF0", VA = "0x186FEA4F0")]
	private void DBEFNJMONAH(Vector3 FEBGGALLBNN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600032E")]
	[Cpp2IlInjected.Address(RVA = "0x6FEAF70", Offset = "0x6FE9570", VA = "0x186FEAF70")]
	private void GICHMIGIHBF(Vector3 DOEHELKGDBK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600032F")]
	[Cpp2IlInjected.Address(RVA = "0x6FEC530", Offset = "0x6FEAB30", VA = "0x186FEC530")]
	private void NOLEEGKNFFH()
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
