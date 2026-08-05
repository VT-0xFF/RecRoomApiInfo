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
	public class LogRegistrationIndex : MPFOBEHAELD
	{
		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(RVA = "0x72E5630", Offset = "0x72E4830", VA = "0x1872E5630", Slot = "4")]
		public override void ALGAFMBJNNP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0x8BF5C0", Offset = "0x8BE7C0", VA = "0x1808BF5C0")]
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
	public class _AssemblyIndex : JFBHLNBAFAN
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000001")]
		private int[] localIndices0;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000002")]
		private BDHGOMMMNAA bitset0;

		[Cpp2IlInjected.Token(Token = "0x17000001")]
		public override string[] ServiceCategories
		{
			[Cpp2IlInjected.Token(Token = "0x6000003")]
			[Cpp2IlInjected.Address(RVA = "0x894500", Offset = "0x893700", VA = "0x180894500", Slot = "4")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x195A7D0", Offset = "0x19599D0", VA = "0x18195A7D0", Slot = "5")]
		public override void CIBALKFPBLI(List<int> globalFromLocalIndices)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x72F3680", Offset = "0x72F2880", VA = "0x1872F3680")]
		private void CONDCFFPFHB(PDIGLKLECCO registry)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x72F3990", Offset = "0x72F2B90", VA = "0x1872F3990", Slot = "6")]
		public override void GDPLLEPCBLF(PDIGLKLECCO registry, [In] CNFGANCILKP filter)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x72F39F0", Offset = "0x72F2BF0", VA = "0x1872F39F0")]
		public _AssemblyIndex()
		{
		}
	}
}
namespace RecRoom
{
	[Cpp2IlInjected.Token(Token = "0x2000004")]
	[DisallowMultipleComponent]
	public sealed class RigidbodyEx : MonoBehaviour, PIMMPONFKHJ
	{
		[Cpp2IlInjected.Token(Token = "0x4000004")]
		private static readonly GAFGFHIJEHD NMHMHMNHJOA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000005")]
		private bool DPDDKDLPBJO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000006")]
		private EKBKMDGMIHO PNPDCPGCFPK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000007")]
		[SerializeField]
		[NFJOGFGDKNB(IKBOIBNEMID.Self, false, false, false)]
		private Rigidbody unityRigidbody;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000008")]
		[SerializeField]
		[NFJOGFGDKNB(IKBOIBNEMID.SelfAndParent, true, false, false)]
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
		private FNGCGGCLILE physicsInterpolation;

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
		internal EKBKMDGMIHO KPNJLGMNFCK
		{
			[Cpp2IlInjected.Token(Token = "0x6000008")]
			[Cpp2IlInjected.Address(RVA = "0x72EEE10", Offset = "0x72EE010", VA = "0x1872EEE10")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000003")]
		private EKBKMDGMIHO IODKIEJEBFA
		{
			[Cpp2IlInjected.Token(Token = "0x6000009")]
			[Cpp2IlInjected.Address(RVA = "0x897B70", Offset = "0x896D70", VA = "0x180897B70", Slot = "6")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000004")]
		public int IJGHCKCLFGH
		{
			[Cpp2IlInjected.Token(Token = "0x600001D")]
			[Cpp2IlInjected.Address(RVA = "0x72F0B90", Offset = "0x72EFD90", VA = "0x1872F0B90")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000005")]
		public RigidbodyEx DAICKAJIPOO
		{
			[Cpp2IlInjected.Token(Token = "0x600001F")]
			[Cpp2IlInjected.Address(RVA = "0x72F0EF0", Offset = "0x72F00F0", VA = "0x1872F0EF0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000006")]
		public RigidbodyEx IBCOIOCGJOD
		{
			[Cpp2IlInjected.Token(Token = "0x6000020")]
			[Cpp2IlInjected.Address(RVA = "0x72F0E30", Offset = "0x72F0030", VA = "0x1872F0E30")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000007")]
		public RigidbodyEx MBOJNCFILKL
		{
			[Cpp2IlInjected.Token(Token = "0x6000021")]
			[Cpp2IlInjected.Address(RVA = "0x72F1AF0", Offset = "0x72F0CF0", VA = "0x1872F1AF0")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000022")]
			[Cpp2IlInjected.Address(RVA = "0x72F2FF0", Offset = "0x72F21F0", VA = "0x1872F2FF0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000008")]
		public Transform EKEGPOACNME
		{
			[Cpp2IlInjected.Token(Token = "0x6000023")]
			[Cpp2IlInjected.Address(RVA = "0x8BE730", Offset = "0x8BD930", VA = "0x1808BE730", Slot = "9")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000009")]
		public Transform OALGNAOLOLM
		{
			[Cpp2IlInjected.Token(Token = "0x6000024")]
			[Cpp2IlInjected.Address(RVA = "0x8BE730", Offset = "0x8BD930", VA = "0x1808BE730", Slot = "10")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000A")]
		public KFABMCIICMN DJHGPHELGJE
		{
			[Cpp2IlInjected.Token(Token = "0x6000025")]
			[Cpp2IlInjected.Address(RVA = "0x72F0BF0", Offset = "0x72EFDF0", VA = "0x1872F0BF0")]
			get
			{
				return default(KFABMCIICMN);
			}
			[Cpp2IlInjected.Token(Token = "0x6000026")]
			[Cpp2IlInjected.Address(RVA = "0x72F27A0", Offset = "0x72F19A0", VA = "0x1872F27A0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000B")]
		public bool BEFHKFOFCJO
		{
			[Cpp2IlInjected.Token(Token = "0x6000027")]
			[Cpp2IlInjected.Address(RVA = "0x72F1200", Offset = "0x72F0400", VA = "0x1872F1200")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000C")]
		public bool IFGEEMNBFMB
		{
			[Cpp2IlInjected.Token(Token = "0x6000028")]
			[Cpp2IlInjected.Address(RVA = "0x72F0D10", Offset = "0x72EFF10", VA = "0x1872F0D10")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000D")]
		public POBAPJPNJIF OKLDKBDBGNP
		{
			[Cpp2IlInjected.Token(Token = "0x6000029")]
			[Cpp2IlInjected.Address(RVA = "0x72F1140", Offset = "0x72F0340", VA = "0x1872F1140")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600002A")]
			[Cpp2IlInjected.Address(RVA = "0x72F2960", Offset = "0x72F1B60", VA = "0x1872F2960")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000E")]
		public JJAKICIKFMK KEMNPJCLCNA
		{
			[Cpp2IlInjected.Token(Token = "0x600002B")]
			[Cpp2IlInjected.Address(RVA = "0x72F10E0", Offset = "0x72F02E0", VA = "0x1872F10E0")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600002C")]
			[Cpp2IlInjected.Address(RVA = "0x72F28F0", Offset = "0x72F1AF0", VA = "0x1872F28F0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000F")]
		public bool BFIALJKMPNL
		{
			[Cpp2IlInjected.Token(Token = "0x600002D")]
			[Cpp2IlInjected.Address(RVA = "0x72F1030", Offset = "0x72F0230", VA = "0x1872F1030")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000010")]
		public Rigidbody PAAIMMKMKDI
		{
			[Cpp2IlInjected.Token(Token = "0x600002E")]
			[Cpp2IlInjected.Address(RVA = "0x72F1090", Offset = "0x72F0290", VA = "0x1872F1090")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000011")]
		public bool HCCJIIKCKAD
		{
			[Cpp2IlInjected.Token(Token = "0x600002F")]
			[Cpp2IlInjected.Address(RVA = "0x72F0D70", Offset = "0x72EFF70", VA = "0x1872F0D70")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000030")]
			[Cpp2IlInjected.Address(RVA = "0x72F2810", Offset = "0x72F1A10", VA = "0x1872F2810")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000012")]
		public bool LBJNENIDJKH
		{
			[Cpp2IlInjected.Token(Token = "0x6000031")]
			[Cpp2IlInjected.Address(RVA = "0x6FC0E40", Offset = "0x6FC0040", VA = "0x186FC0E40", Slot = "7")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000013")]
		public float PFGNLPDCNIN
		{
			[Cpp2IlInjected.Token(Token = "0x6000032")]
			[Cpp2IlInjected.Address(RVA = "0x72F1A90", Offset = "0x72F0C90", VA = "0x1872F1A90")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000014")]
		public float NIMDOJLFMKJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000033")]
			[Cpp2IlInjected.Address(RVA = "0x72F1A30", Offset = "0x72F0C30", VA = "0x1872F1A30")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x6000034")]
			[Cpp2IlInjected.Address(RVA = "0x72F2F80", Offset = "0x72F2180", VA = "0x1872F2F80")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000015")]
		public float LLPNDJIAONK
		{
			[Cpp2IlInjected.Token(Token = "0x6000035")]
			[Cpp2IlInjected.Address(RVA = "0x72F1460", Offset = "0x72F0660", VA = "0x1872F1460")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x6000036")]
			[Cpp2IlInjected.Address(RVA = "0x72F2C00", Offset = "0x72F1E00", VA = "0x1872F2C00")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000016")]
		public float CJBHGBCPLAB
		{
			[Cpp2IlInjected.Token(Token = "0x6000037")]
			[Cpp2IlInjected.Address(RVA = "0x72F1260", Offset = "0x72F0460", VA = "0x1872F1260")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x6000038")]
			[Cpp2IlInjected.Address(RVA = "0x72F29D0", Offset = "0x72F1BD0", VA = "0x1872F29D0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000017")]
		public bool KPHDEGALGEK
		{
			[Cpp2IlInjected.Token(Token = "0x6000039")]
			[Cpp2IlInjected.Address(RVA = "0x72F2040", Offset = "0x72F1240", VA = "0x1872F2040")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x600003A")]
			[Cpp2IlInjected.Address(RVA = "0x72F3530", Offset = "0x72F2730", VA = "0x1872F3530")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000018")]
		public Vector3 FFLPBIEPJND
		{
			[Cpp2IlInjected.Token(Token = "0x600003B")]
			[Cpp2IlInjected.Address(RVA = "0x72F1810", Offset = "0x72F0A10", VA = "0x1872F1810")]
			get
			{
				return default(Vector3);
			}
			[Cpp2IlInjected.Token(Token = "0x600003C")]
			[Cpp2IlInjected.Address(RVA = "0x72F2D50", Offset = "0x72F1F50", VA = "0x1872F2D50")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000019")]
		public Vector3 MHGPMALCJMN
		{
			[Cpp2IlInjected.Token(Token = "0x600003D")]
			[Cpp2IlInjected.Address(RVA = "0x72F2180", Offset = "0x72F1380", VA = "0x1872F2180")]
			get
			{
				return default(Vector3);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001A")]
		public CollisionDetectionMode FKEOJICKGDH
		{
			[Cpp2IlInjected.Token(Token = "0x600003E")]
			[Cpp2IlInjected.Address(RVA = "0x72F13A0", Offset = "0x72F05A0", VA = "0x1872F13A0")]
			get
			{
				return default(CollisionDetectionMode);
			}
			[Cpp2IlInjected.Token(Token = "0x600003F")]
			[Cpp2IlInjected.Address(RVA = "0x72F2B20", Offset = "0x72F1D20", VA = "0x1872F2B20")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001B")]
		public float KGLOMNONIBO
		{
			[Cpp2IlInjected.Token(Token = "0x6000040")]
			[Cpp2IlInjected.Address(RVA = "0x72F0DD0", Offset = "0x72EFFD0", VA = "0x1872F0DD0")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x6000041")]
			[Cpp2IlInjected.Address(RVA = "0x72F2880", Offset = "0x72F1A80", VA = "0x1872F2880")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001C")]
		public RigidbodyConstraints POEAJPPIHCP
		{
			[Cpp2IlInjected.Token(Token = "0x6000042")]
			[Cpp2IlInjected.Address(RVA = "0x72F1400", Offset = "0x72F0600", VA = "0x1872F1400")]
			get
			{
				return default(RigidbodyConstraints);
			}
			[Cpp2IlInjected.Token(Token = "0x6000043")]
			[Cpp2IlInjected.Address(RVA = "0x72F2B90", Offset = "0x72F1D90", VA = "0x1872F2B90")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001D")]
		public Vector3 FJHIGKLIDLG
		{
			[Cpp2IlInjected.Token(Token = "0x6000044")]
			[Cpp2IlInjected.Address(RVA = "0x72F1BB0", Offset = "0x72F0DB0", VA = "0x1872F1BB0")]
			get
			{
				return default(Vector3);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001E")]
		public Vector3 OBAOCBDKILD
		{
			[Cpp2IlInjected.Token(Token = "0x6000045")]
			[Cpp2IlInjected.Address(RVA = "0x72F1BB0", Offset = "0x72F0DB0", VA = "0x1872F1BB0")]
			get
			{
				return default(Vector3);
			}
			[Cpp2IlInjected.Token(Token = "0x6000046")]
			[Cpp2IlInjected.Address(RVA = "0x72F3310", Offset = "0x72F2510", VA = "0x1872F3310")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001F")]
		public float IHPKHPNEOPH
		{
			[Cpp2IlInjected.Token(Token = "0x6000047")]
			[Cpp2IlInjected.Address(RVA = "0x72F18F0", Offset = "0x72F0AF0", VA = "0x1872F18F0")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x6000048")]
			[Cpp2IlInjected.Address(RVA = "0x72F2E30", Offset = "0x72F2030", VA = "0x1872F2E30")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000020")]
		public float OBEFACHHGBL
		{
			[Cpp2IlInjected.Token(Token = "0x6000049")]
			[Cpp2IlInjected.Address(RVA = "0x72F1FE0", Offset = "0x72F11E0", VA = "0x1872F1FE0")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x600004A")]
			[Cpp2IlInjected.Address(RVA = "0x72F34C0", Offset = "0x72F26C0", VA = "0x1872F34C0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000021")]
		public Quaternion GAAAJPBDDFJ
		{
			[Cpp2IlInjected.Token(Token = "0x600004B")]
			[Cpp2IlInjected.Address(RVA = "0x72F1C90", Offset = "0x72F0E90", VA = "0x1872F1C90")]
			get
			{
				return default(Quaternion);
			}
			[Cpp2IlInjected.Token(Token = "0x600004C")]
			[Cpp2IlInjected.Address(RVA = "0x72F3090", Offset = "0x72F2290", VA = "0x1872F3090")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000022")]
		public Quaternion IHAPHFFAIPP
		{
			[Cpp2IlInjected.Token(Token = "0x600004D")]
			[Cpp2IlInjected.Address(RVA = "0x72F1F10", Offset = "0x72F1110", VA = "0x1872F1F10")]
			get
			{
				return default(Quaternion);
			}
			[Cpp2IlInjected.Token(Token = "0x600004E")]
			[Cpp2IlInjected.Address(RVA = "0x72F33F0", Offset = "0x72F25F0", VA = "0x1872F33F0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000023")]
		public Vector3 FIAKIINGLAK
		{
			[Cpp2IlInjected.Token(Token = "0x600004F")]
			[Cpp2IlInjected.Address(RVA = "0x72F1D60", Offset = "0x72F0F60", VA = "0x1872F1D60")]
			get
			{
				return default(Vector3);
			}
			[Cpp2IlInjected.Token(Token = "0x6000050")]
			[Cpp2IlInjected.Address(RVA = "0x72F3160", Offset = "0x72F2360", VA = "0x1872F3160")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000024")]
		public Quaternion CCDCGJHEAJC
		{
			[Cpp2IlInjected.Token(Token = "0x6000051")]
			[Cpp2IlInjected.Address(RVA = "0x72F1E40", Offset = "0x72F1040", VA = "0x1872F1E40")]
			get
			{
				return default(Quaternion);
			}
			[Cpp2IlInjected.Token(Token = "0x6000052")]
			[Cpp2IlInjected.Address(RVA = "0x72F3240", Offset = "0x72F2440", VA = "0x1872F3240")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000025")]
		public Vector3 BEEOMEJFEKJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000053")]
			[Cpp2IlInjected.Address(RVA = "0x72F20A0", Offset = "0x72F12A0", VA = "0x1872F20A0")]
			get
			{
				return default(Vector3);
			}
			[Cpp2IlInjected.Token(Token = "0x6000054")]
			[Cpp2IlInjected.Address(RVA = "0x72F35A0", Offset = "0x72F27A0", VA = "0x1872F35A0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000026")]
		public Vector3 PDMDPBKDBDN
		{
			[Cpp2IlInjected.Token(Token = "0x6000055")]
			[Cpp2IlInjected.Address(RVA = "0x72F1950", Offset = "0x72F0B50", VA = "0x1872F1950")]
			get
			{
				return default(Vector3);
			}
			[Cpp2IlInjected.Token(Token = "0x6000056")]
			[Cpp2IlInjected.Address(RVA = "0x72F2EA0", Offset = "0x72F20A0", VA = "0x1872F2EA0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000027")]
		public Vector3 KFNNJHCHNGF
		{
			[Cpp2IlInjected.Token(Token = "0x6000057")]
			[Cpp2IlInjected.Address(RVA = "0x72F12C0", Offset = "0x72F04C0", VA = "0x1872F12C0")]
			get
			{
				return default(Vector3);
			}
			[Cpp2IlInjected.Token(Token = "0x6000058")]
			[Cpp2IlInjected.Address(RVA = "0x72F2A40", Offset = "0x72F1C40", VA = "0x1872F2A40")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000028")]
		public Vector3 CPBKNIAPNBD
		{
			[Cpp2IlInjected.Token(Token = "0x6000059")]
			[Cpp2IlInjected.Address(RVA = "0x72F1730", Offset = "0x72F0930", VA = "0x1872F1730")]
			get
			{
				return default(Vector3);
			}
			[Cpp2IlInjected.Token(Token = "0x600005A")]
			[Cpp2IlInjected.Address(RVA = "0x72F2C70", Offset = "0x72F1E70", VA = "0x1872F2C70")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000029")]
		public Vector3 CIPKLJBJOIP
		{
			[Cpp2IlInjected.Token(Token = "0x600005B")]
			[Cpp2IlInjected.Address(RVA = "0x72F15F0", Offset = "0x72F07F0", VA = "0x1872F15F0")]
			get
			{
				return default(Vector3);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002A")]
		public Quaternion PGDHOLILEBF
		{
			[Cpp2IlInjected.Token(Token = "0x600005C")]
			[Cpp2IlInjected.Address(RVA = "0x72F1520", Offset = "0x72F0720", VA = "0x1872F1520")]
			get
			{
				return default(Quaternion);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002B")]
		public Vector3 MMHKJOLEJFL
		{
			[Cpp2IlInjected.Token(Token = "0x600005E")]
			[Cpp2IlInjected.Address(RVA = "0x72F2340", Offset = "0x72F1540", VA = "0x1872F2340")]
			get
			{
				return default(Vector3);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002C")]
		public Vector3 DAHGNIMDFND
		{
			[Cpp2IlInjected.Token(Token = "0x600005F")]
			[Cpp2IlInjected.Address(RVA = "0x72F2260", Offset = "0x72F1460", VA = "0x1872F2260")]
			get
			{
				return default(Vector3);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002D")]
		public bool ICNCKMMGEFA
		{
			[Cpp2IlInjected.Token(Token = "0x6000060")]
			[Cpp2IlInjected.Address(RVA = "0x72F16D0", Offset = "0x72F08D0", VA = "0x1872F16D0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002E")]
		public bool NCCODDIBCOL
		{
			[Cpp2IlInjected.Token(Token = "0x6000061")]
			[Cpp2IlInjected.Address(RVA = "0x72F11A0", Offset = "0x72F03A0", VA = "0x1872F11A0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002F")]
		public bool JJPGBNMDLJN
		{
			[Cpp2IlInjected.Token(Token = "0x6000062")]
			[Cpp2IlInjected.Address(RVA = "0x72F0CB0", Offset = "0x72EFEB0", VA = "0x1872F0CB0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000030")]
		public bool DENIFBCGAME
		{
			[Cpp2IlInjected.Token(Token = "0x6000063")]
			[Cpp2IlInjected.Address(RVA = "0x72F0C50", Offset = "0x72EFE50", VA = "0x1872F0C50")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000031")]
		public bool HKCMABLGADC
		{
			[Cpp2IlInjected.Token(Token = "0x6000064")]
			[Cpp2IlInjected.Address(RVA = "0x72F0B30", Offset = "0x72EFD30", VA = "0x1872F0B30")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000032")]
		public bool GBPLHGDAHBO
		{
			[Cpp2IlInjected.Token(Token = "0x6000065")]
			[Cpp2IlInjected.Address(RVA = "0x72F14C0", Offset = "0x72F06C0", VA = "0x1872F14C0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000033")]
		public bool LDONACDLNEA
		{
			[Cpp2IlInjected.Token(Token = "0x6000066")]
			[Cpp2IlInjected.Address(RVA = "0x1BD8AF0", Offset = "0x1BD7CF0", VA = "0x181BD8AF0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000001")]
		public event AHKGFFDODJI LPLOKGENMFJ
		{
			[Cpp2IlInjected.Token(Token = "0x600000D")]
			[Cpp2IlInjected.Address(RVA = "0x72F0A50", Offset = "0x72EFC50", VA = "0x1872F0A50")]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x600000E")]
			[Cpp2IlInjected.Address(RVA = "0x72F26C0", Offset = "0x72F18C0", VA = "0x1872F26C0")]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000002")]
		public event ELNJCAEPAAK GGHLMHGGFGE
		{
			[Cpp2IlInjected.Token(Token = "0x600000F")]
			[Cpp2IlInjected.Address(RVA = "0x72F07C0", Offset = "0x72EF9C0", VA = "0x1872F07C0")]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000010")]
			[Cpp2IlInjected.Address(RVA = "0x72F2420", Offset = "0x72F1620", VA = "0x1872F2420")]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000003")]
		public event ELNJCAEPAAK OGLGAJAFIMK
		{
			[Cpp2IlInjected.Token(Token = "0x6000011")]
			[Cpp2IlInjected.Address(RVA = "0x72F0820", Offset = "0x72EFA20", VA = "0x1872F0820")]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000012")]
			[Cpp2IlInjected.Address(RVA = "0x72F2490", Offset = "0x72F1690", VA = "0x1872F2490")]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000004")]
		public event ELNJCAEPAAK OCLAFMBFEEH
		{
			[Cpp2IlInjected.Token(Token = "0x6000013")]
			[Cpp2IlInjected.Address(RVA = "0x72F0970", Offset = "0x72EFB70", VA = "0x1872F0970")]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000014")]
			[Cpp2IlInjected.Address(RVA = "0x72F25E0", Offset = "0x72F17E0", VA = "0x1872F25E0")]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000005")]
		public event Action<KOEAFBADJNF, KOEAFBADJNF> LMBGJGLPGCL
		{
			[Cpp2IlInjected.Token(Token = "0x6000015")]
			[Cpp2IlInjected.Address(RVA = "0x72F0900", Offset = "0x72EFB00", VA = "0x1872F0900")]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000016")]
			[Cpp2IlInjected.Address(RVA = "0x72F2570", Offset = "0x72F1770", VA = "0x1872F2570")]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000006")]
		public event ELNJCAEPAAK NACNGLBJKMG
		{
			[Cpp2IlInjected.Token(Token = "0x6000017")]
			[Cpp2IlInjected.Address(RVA = "0x72F09E0", Offset = "0x72EFBE0", VA = "0x1872F09E0")]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000018")]
			[Cpp2IlInjected.Address(RVA = "0x72F2650", Offset = "0x72F1850", VA = "0x1872F2650")]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000007")]
		public event ELNJCAEPAAK GPILGFDILEJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000019")]
			[Cpp2IlInjected.Address(RVA = "0x72F0AC0", Offset = "0x72EFCC0", VA = "0x1872F0AC0")]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x600001A")]
			[Cpp2IlInjected.Address(RVA = "0x72F2730", Offset = "0x72F1930", VA = "0x1872F2730")]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000008")]
		public event ELNJCAEPAAK CIHAGCLFOKL
		{
			[Cpp2IlInjected.Token(Token = "0x600001B")]
			[Cpp2IlInjected.Address(RVA = "0x72F0890", Offset = "0x72EFA90", VA = "0x1872F0890")]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x600001C")]
			[Cpp2IlInjected.Address(RVA = "0x72F2500", Offset = "0x72F1700", VA = "0x1872F2500")]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x897BB0", Offset = "0x896DB0", VA = "0x180897BB0", Slot = "8")]
		private void BOOKJNDMEIM(EKBKMDGMIHO JANAFGLBOCK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x72EE360", Offset = "0x72ED560", VA = "0x1872EE360")]
		internal void ADGALCAEKFJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x72F04F0", Offset = "0x72EF6F0", VA = "0x1872F04F0")]
		[Conditional("DEBUG_BUILD")]
		[Conditional("UNITY_EDITOR")]
		public void TestOverrideUnityRigidbody(Rigidbody NGLFACJDIIF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x72EF2B0", Offset = "0x72EE4B0", VA = "0x1872EF2B0")]
		public PIMMPONFKHJ GetChild(int KINMHNEMPOD)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600005D")]
		[Cpp2IlInjected.Address(RVA = "0x72F01C0", Offset = "0x72EF3C0", VA = "0x1872F01C0")]
		public void SetInertiaTensor((Quaternion rot, Vector3 moments) PDCLDKLEPFH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000067")]
		[Cpp2IlInjected.Address(RVA = "0x72EEDA0", Offset = "0x72EDFA0", VA = "0x1872EEDA0")]
		private void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000068")]
		[Cpp2IlInjected.Address(RVA = "0x72EEE10", Offset = "0x72EE010", VA = "0x1872EEE10")]
		private EKBKMDGMIHO KFEBJDGIPKG()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000069")]
		[Cpp2IlInjected.Address(RVA = "0x72EEEC0", Offset = "0x72EE0C0", VA = "0x1872EEEC0")]
		private void BPKFIOLMIPE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006A")]
		[Cpp2IlInjected.Address(RVA = "0x72EF990", Offset = "0x72EEB90", VA = "0x1872EF990")]
		private void OnEnable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006B")]
		[Cpp2IlInjected.Address(RVA = "0x72EE360", Offset = "0x72ED560", VA = "0x1872EE360")]
		private void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006C")]
		[Cpp2IlInjected.Address(RVA = "0x72EF930", Offset = "0x72EEB30", VA = "0x1872EF930")]
		private void OnDrawGizmosSelected()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006D")]
		[Cpp2IlInjected.Address(RVA = "0x72EF9F0", Offset = "0x72EEBF0", VA = "0x1872EF9F0")]
		private void OnValidate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006E")]
		[Cpp2IlInjected.Address(RVA = "0x72EE3F0", Offset = "0x72ED5F0", VA = "0x1872EE3F0")]
		public void AddDoNotResetVelocityOnOwnershipChangeOverride(object NIOIDOPDJKO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006F")]
		[Cpp2IlInjected.Address(RVA = "0x72EFA50", Offset = "0x72EEC50", VA = "0x1872EFA50")]
		public void RemoveDoNotResetVelocityOnOwnershipChangeOverride(object NIOIDOPDJKO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000070")]
		[Cpp2IlInjected.Address(RVA = "0x72EF250", Offset = "0x72EE450", VA = "0x1872EF250")]
		public void DisableCachedInertialPropertyOverride()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000071")]
		[Cpp2IlInjected.Address(RVA = "0x72EF8D0", Offset = "0x72EEAD0", VA = "0x1872EF8D0")]
		public void MarkCachedInertialParametersDirty()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000072")]
		[Cpp2IlInjected.Address(RVA = "0x72F0320", Offset = "0x72EF520", VA = "0x1872F0320")]
		public void SetParent(RigidbodyEx JECHHBGMFLN, bool BKKKGCNMPBE = false)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000073")]
		[Cpp2IlInjected.Address(RVA = "0x72EFD60", Offset = "0x72EEF60", VA = "0x1872EFD60")]
		public void ResetLocalCenterOfMassToPrefabDefault()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000074")]
		[Cpp2IlInjected.Address(RVA = "0x72EF560", Offset = "0x72EE760", VA = "0x1872EF560")]
		public bool IsRigidbodyAncestor(RigidbodyEx BBPCODKDBDI)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000075")]
		[Cpp2IlInjected.Address(RVA = "0x72EF660", Offset = "0x72EE860", VA = "0x1872EF660")]
		public bool IsRigidbodyDescendant(RigidbodyEx BFKOELBMDDP)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000076")]
		[Cpp2IlInjected.Address(RVA = "0x72EE660", Offset = "0x72ED860", VA = "0x1872EE660")]
		public void AddInterpolationRestriction(object NIOIDOPDJKO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000077")]
		[Cpp2IlInjected.Address(RVA = "0x72EFAC0", Offset = "0x72EECC0", VA = "0x1872EFAC0")]
		public void RemoveInterpolationRestriction(object NIOIDOPDJKO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000078")]
		[Cpp2IlInjected.Address(RVA = "0x72EE6D0", Offset = "0x72ED8D0", VA = "0x1872EE6D0")]
		public void AddKinematic(object NIOIDOPDJKO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000079")]
		[Cpp2IlInjected.Address(RVA = "0x72EFB30", Offset = "0x72EED30", VA = "0x1872EFB30")]
		public void RemoveKinematic(object NIOIDOPDJKO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007A")]
		[Cpp2IlInjected.Address(RVA = "0x72F02A0", Offset = "0x72EF4A0", VA = "0x1872F02A0")]
		public void SetKinematic(object NIOIDOPDJKO, bool FOEAHOLLJJF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007B")]
		[Cpp2IlInjected.Address(RVA = "0x72F00C0", Offset = "0x72EF2C0", VA = "0x1872F00C0")]
		public void SetDiscontinuousPositionAndRotation(Vector3 FNKDCDLOGKB, Quaternion OMFBNHNKBBC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007C")]
		[Cpp2IlInjected.Address(RVA = "0x72EFFC0", Offset = "0x72EF1C0", VA = "0x1872EFFC0")]
		public void SetDiscontinuousLocalPositionAndLocalRotation(Vector3 JHIBNFEPDFL, Quaternion NIDDNGGLBMM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007D")]
		[Cpp2IlInjected.Address(RVA = "0x72EF450", Offset = "0x72EE650", VA = "0x1872EF450")]
		public Vector3 GetConstrainedVelocity(Vector3 BEEOMEJFEKJ)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x600007E")]
		[Cpp2IlInjected.Address(RVA = "0x72EF340", Offset = "0x72EE540", VA = "0x1872EF340")]
		public Vector3 GetConstrainedAngularVelocity(Vector3 KFNNJHCHNGF)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x600007F")]
		[Cpp2IlInjected.Address(RVA = "0x72EE570", Offset = "0x72ED770", VA = "0x1872EE570")]
		public void AddForce(Vector3 PLHFEDHICDP, ForceMode AGPFLDAGFIP = ForceMode.Force)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000080")]
		[Cpp2IlInjected.Address(RVA = "0x72EE460", Offset = "0x72ED660", VA = "0x1872EE460")]
		public void AddForceAtPosition(Vector3 PLHFEDHICDP, Vector3 FJFKFIAGEPM, ForceMode AGPFLDAGFIP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000081")]
		[Cpp2IlInjected.Address(RVA = "0x72EE8A0", Offset = "0x72EDAA0", VA = "0x1872EE8A0")]
		public void AddTorque(Vector3 NPKDLKCKHFJ, ForceMode AGPFLDAGFIP = ForceMode.Force)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000082")]
		[Cpp2IlInjected.Address(RVA = "0x72EE740", Offset = "0x72ED940", VA = "0x1872EE740")]
		public void AddRelativeTorque(Vector3 NPKDLKCKHFJ, ForceMode AGPFLDAGFIP = ForceMode.Force)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000083")]
		[Cpp2IlInjected.Address(RVA = "0x72F05C0", Offset = "0x72EF7C0", VA = "0x1872F05C0")]
		public Vector3 WorldToLocalVelocity(Vector3 NJMKNHLGFKE)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x6000084")]
		[Cpp2IlInjected.Address(RVA = "0x72EF7C0", Offset = "0x72EE9C0", VA = "0x1872EF7C0")]
		public Vector3 LocalToWorldVelocity(Vector3 PDMDPBKDBDN)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x6000085")]
		[Cpp2IlInjected.Address(RVA = "0x72EF1F0", Offset = "0x72EE3F0", VA = "0x1872EF1F0")]
		public void ClearVelocity()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000086")]
		[Cpp2IlInjected.Address(RVA = "0x72EF190", Offset = "0x72EE390", VA = "0x1872EF190")]
		public void ClearUnityRigidbodyVelocity()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000087")]
		[Cpp2IlInjected.Address(RVA = "0x72EF130", Offset = "0x72EE330", VA = "0x1872EF130")]
		public void ClearLinearVelocity()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000088")]
		[Cpp2IlInjected.Address(RVA = "0x72EF0D0", Offset = "0x72EE2D0", VA = "0x1872EF0D0")]
		public void ClearAngularVelocity()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000089")]
		[Cpp2IlInjected.Address(RVA = "0x72EFEC0", Offset = "0x72EF0C0", VA = "0x1872EFEC0")]
		public void ResetVelocityWorldSpace(Vector3 JJGNONCAJKL, Vector3 HJANGHEDIGO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008A")]
		[Cpp2IlInjected.Address(RVA = "0x72EFDC0", Offset = "0x72EEFC0", VA = "0x1872EFDC0")]
		public void ResetVelocityLocalSpace(Vector3 OBJNBNIHDNA, Vector3 CPBKNIAPNBD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008B")]
		[Cpp2IlInjected.Address(RVA = "0x72EFC80", Offset = "0x72EEE80", VA = "0x1872EFC80")]
		public void ResetLinearVelocityLocalSpace(Vector3 OBJNBNIHDNA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008C")]
		[Cpp2IlInjected.Address(RVA = "0x72F0450", Offset = "0x72EF650", VA = "0x1872F0450")]
		public bool SweepTest(Vector3 BHMBDKAILFL, [Out] RaycastHit MDGJKKLDFLO, float ELNHAHMEPIC)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600008D")]
		[Cpp2IlInjected.Address(RVA = "0x72EF760", Offset = "0x72EE960", VA = "0x1872EF760")]
		public bool IsSleeping()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600008E")]
		[Cpp2IlInjected.Address(RVA = "0x72F03F0", Offset = "0x72EF5F0", VA = "0x1872F03F0")]
		public void Sleep()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008F")]
		[Cpp2IlInjected.Address(RVA = "0x72F0560", Offset = "0x72EF760", VA = "0x1872F0560")]
		public void WakeUp()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000090")]
		[Cpp2IlInjected.Address(RVA = "0x72EE830", Offset = "0x72EDA30", VA = "0x1872EE830")]
		public void AddShouldHaveUnityRigidbodyToken(object NIOIDOPDJKO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000091")]
		[Cpp2IlInjected.Address(RVA = "0x72EFBA0", Offset = "0x72EEDA0", VA = "0x1872EFBA0")]
		public void RemoveShouldHaveUnityRigidbodyToken(object NIOIDOPDJKO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000092")]
		[Cpp2IlInjected.Address(RVA = "0x72EEC30", Offset = "0x72EDE30", VA = "0x1872EEC30")]
		public void ApplyForceVelocityChange(KNPMGCIOAIO GPBGOJOBPDD, Vector3 NBLKIPPEOAD, float PMAAKLFOBHF, float EEAHHPFKLHF = 8f, float BHCLILJBOCH = 1f)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000093")]
		[Cpp2IlInjected.Address(RVA = "0x72EEB30", Offset = "0x72EDD30", VA = "0x1872EEB30")]
		public void ApplyAngularVelocityChange(JIOFAHGJLPH KDOGOEHPAMH, Vector3 KEIBLCIFAEK, float CNCMGOOCLHH = float.PositiveInfinity)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000094")]
		[Cpp2IlInjected.Address(RVA = "0x72EECF0", Offset = "0x72EDEF0", VA = "0x1872EECF0")]
		[Obsolete("Deprecated. Still exists to support deprecated CV2 chips. Use ApplyAngularVelocityChange.")]
		public void ApplyTorqueAngularVelocityChangeDeprecated(JIOFAHGJLPH KDOGOEHPAMH, Vector3 MBMKLLFOFFL, float JIJBBEKPCIF = 7f, float NCMKACAPAEK = 1f)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000095")]
		[Cpp2IlInjected.Address(RVA = "0x72EEA60", Offset = "0x72EDC60", VA = "0x1872EEA60")]
		public bool AllowedScaleChange(float LLLEKEFAJOE)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000096")]
		[Cpp2IlInjected.Address(RVA = "0x72EE990", Offset = "0x72EDB90", VA = "0x1872EE990")]
		public void AddWorldSpaceVelocityInHierarchyParentOverride(RigidbodyEx HOJKEPPOHFG, object NIOIDOPDJKO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000097")]
		[Cpp2IlInjected.Address(RVA = "0x72EFC10", Offset = "0x72EEE10", VA = "0x1872EFC10")]
		public void RemoveWorldSpaceVelocityInHierarchyParentOverride(object NIOIDOPDJKO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000098")]
		[Cpp2IlInjected.Address(RVA = "0x72F0750", Offset = "0x72EF950", VA = "0x1872F0750")]
		public RigidbodyEx()
		{
		}

		[SpecialName]
		[Cpp2IlInjected.Token(Token = "0x600009A")]
		[Cpp2IlInjected.Address(RVA = "0xC8A130", Offset = "0xC89330", VA = "0x180C8A130", Slot = "4")]
		private GameObject MILPIGJJKFE()
		{
			return null;
		}

		[SpecialName]
		[Cpp2IlInjected.Token(Token = "0x600009B")]
		[Cpp2IlInjected.Address(RVA = "0x8BE730", Offset = "0x8BD930", VA = "0x1808BE730", Slot = "5")]
		private Transform BPAMLMBEBJF()
		{
			return null;
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
internal static class CABIDCAJHFK
{
	[Cpp2IlInjected.Token(Token = "0x600009C")]
	[Cpp2IlInjected.Address(RVA = "0x72DB130", Offset = "0x72DA330", VA = "0x1872DB130")]
	public static EKBKMDGMIHO KPNJLGMNFCK(this RigidbodyEx BINJLCOIDDF)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
[GPHKHOPHNGA(typeof(BPMCNPBDJCK), new string[] { })]
public class IHKJNBLKOLJ : BPMCNPBDJCK, BMOBKDHOHJA
{
	[Cpp2IlInjected.Token(Token = "0x400000F")]
	private static readonly GAFGFHIJEHD ACKGBNDHEHM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000010")]
	private BIMFLNCHPNC JFPADJJAHEN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000011")]
	private PMBKEPOBBGI PAHMCFCAIMF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000012")]
	private DFCJPPCLEBM LLGHHMFHKKK;

	[Cpp2IlInjected.Token(Token = "0x17000034")]
	public PMBKEPOBBGI FIAONLBOBCL
	{
		[Cpp2IlInjected.Token(Token = "0x600009D")]
		[Cpp2IlInjected.Address(RVA = "0x8942A0", Offset = "0x8934A0", VA = "0x1808942A0", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000035")]
	public DFCJPPCLEBM BKMIMOHDIEK
	{
		[Cpp2IlInjected.Token(Token = "0x600009E")]
		[Cpp2IlInjected.Address(RVA = "0x897B70", Offset = "0x896D70", VA = "0x180897B70", Slot = "5")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600009F")]
	[Cpp2IlInjected.Address(RVA = "0x72DDE70", Offset = "0x72DD070", VA = "0x1872DDE70", Slot = "7")]
	public void InitReferences(ANNJDLAFEIN DHGEHBCJDOE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A0")]
	[Cpp2IlInjected.Address(RVA = "0x72DDF00", Offset = "0x72DD100", VA = "0x1872DDF00", Slot = "6")]
	public EKBKMDGMIHO JLIEAMKBMKG(RigidbodyEx BINJLCOIDDF, GNBAPJBBCHJ LJIEGDEDOHM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000A1")]
	[Cpp2IlInjected.Address(RVA = "0x89F8B0", Offset = "0x89EAB0", VA = "0x18089F8B0")]
	public IHKJNBLKOLJ()
	{
	}
}
namespace RecRoom
{
	[Cpp2IlInjected.Token(Token = "0x2000007")]
	public class PhysicsManager : SingletonMonoBehaviour<PhysicsManager>
	{
		[Cpp2IlInjected.Token(Token = "0x4000013")]
		public static OAACCCGABIO UpdateAfterFixedUpdateRan;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000014")]
		private int GPBAHHAKGHF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x4000015")]
		private int HKOJOFPLCCD;

		[Cpp2IlInjected.Token(Token = "0x60000A3")]
		[Cpp2IlInjected.Address(RVA = "0x72EE1E0", Offset = "0x72ED3E0", VA = "0x1872EE1E0")]
		protected void FixedUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A4")]
		[Cpp2IlInjected.Address(RVA = "0x72EE220", Offset = "0x72ED420", VA = "0x1872EE220")]
		protected void Update()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A5")]
		[Cpp2IlInjected.Address(RVA = "0x72EE200", Offset = "0x72ED400", VA = "0x1872EE200")]
		protected void LateUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A6")]
		[Cpp2IlInjected.Address(RVA = "0x8966B0", Offset = "0x8958B0", VA = "0x1808966B0")]
		[Conditional("UNITY_ASSERTIONS")]
		public void AssertLateColliderPositionsNotYetUpdated([Optional] string ADNFLGLLNKI, [Optional] UnityEngine.Object GFIAFOEJCDD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A7")]
		[Cpp2IlInjected.Address(RVA = "0x8966B0", Offset = "0x8958B0", VA = "0x1808966B0")]
		[Conditional("UNITY_ASSERTIONS")]
		public void AssertLateColliderPositionsAlreadyUpdated([Optional] string ADNFLGLLNKI, [Optional] UnityEngine.Object GFIAFOEJCDD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A8")]
		[Cpp2IlInjected.Address(RVA = "0x72EE310", Offset = "0x72ED510", VA = "0x1872EE310")]
		public PhysicsManager()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
public static class FIJGEPIHCKM
{
	[Cpp2IlInjected.Token(Token = "0x2000009")]
	private class AGJPCEDGHLF : POBAPJPNJIF, IDisposable
	{
		[Cpp2IlInjected.Token(Token = "0x60000AC")]
		[Cpp2IlInjected.Address(RVA = "0x8966B0", Offset = "0x8958B0", VA = "0x1808966B0", Slot = "6")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AD")]
		[Cpp2IlInjected.Address(RVA = "0x8A5A10", Offset = "0x8A4C10", VA = "0x1808A5A10", Slot = "4")]
		public Vector3 MCKBOMLLMKB()
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x60000AE")]
		[Cpp2IlInjected.Address(RVA = "0x8A5A10", Offset = "0x8A4C10", VA = "0x1808A5A10", Slot = "5")]
		public Vector3 GOKFBHEJOJB()
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x60000AF")]
		[Cpp2IlInjected.Address(RVA = "0x89F8B0", Offset = "0x89EAB0", VA = "0x18089F8B0")]
		public AGJPCEDGHLF()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000036")]
	public static POBAPJPNJIF LHDHGBKEGGD
	{
		[Cpp2IlInjected.Token(Token = "0x60000AA")]
		[Cpp2IlInjected.Address(RVA = "0x72DC450", Offset = "0x72DB650", VA = "0x1872DC450")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
public interface BDJDNDHNEIC
{
	[Cpp2IlInjected.Token(Token = "0x17000037")]
	CollisionDetectionMode MDOAMCGNLFH
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
	void AHDMKGLGKBO();

	[Cpp2IlInjected.Token(Token = "0x60000B3")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void OEINOICMECJ(bool ICNCKMMGEFA);

	[Cpp2IlInjected.Token(Token = "0x60000B4")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void MADAMHCHODC(bool ICNCKMMGEFA);

	[Cpp2IlInjected.Token(Token = "0x60000B5")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void OFPIEMIENHN(Rigidbody LOMDGCGOAME);

	[Cpp2IlInjected.Token(Token = "0x60000B6")]
	[Cpp2IlInjected.Address(Slot = "6")]
	bool DCIJPILDPPB(Vector3 BHMBDKAILFL, [Out] RaycastHit MDGJKKLDFLO, float ELNHAHMEPIC);
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
public interface HFEOBDFOGDH : IDisposable, ANHAMHJNODK
{
	[Cpp2IlInjected.Token(Token = "0x17000038")]
	KFABMCIICMN DJHGPHELGJE
	{
		[Cpp2IlInjected.Token(Token = "0x60000B9")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
		[Cpp2IlInjected.Token(Token = "0x60000BA")]
		[Cpp2IlInjected.Address(Slot = "3")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x14000009")]
	event Action<KOEAFBADJNF, KOEAFBADJNF> LMBGJGLPGCL;

	[Cpp2IlInjected.Token(Token = "0x60000BB")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void AHDMKGLGKBO();
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
[IIAPEOFKIPJ(NPIKHFLBMBK.Application)]
public interface DFCJPPCLEBM
{
	[Cpp2IlInjected.Token(Token = "0x60000BC")]
	[Cpp2IlInjected.Address(Slot = "0")]
	JEMMFOIBFDF BCKGEGBPCDO(EKBKMDGMIHO JANAFGLBOCK);

	[Cpp2IlInjected.Token(Token = "0x60000BD")]
	[Cpp2IlInjected.Address(Slot = "1")]
	MDPIGHOADEP HFGAKCHCKGG(EKBKMDGMIHO JANAFGLBOCK);

	[Cpp2IlInjected.Token(Token = "0x60000BE")]
	[Cpp2IlInjected.Address(Slot = "2")]
	NDHKKDEMMPE DCNDKILDIIG(EKBKMDGMIHO JANAFGLBOCK);

	[Cpp2IlInjected.Token(Token = "0x60000BF")]
	[Cpp2IlInjected.Address(Slot = "3")]
	PMPHEBCFCMC OGFOFBLFCOL(EKBKMDGMIHO JANAFGLBOCK);

	[Cpp2IlInjected.Token(Token = "0x60000C0")]
	[Cpp2IlInjected.Address(Slot = "4")]
	OLEOCEJGBKB DOPLNLGNPNB(EKBKMDGMIHO JANAFGLBOCK);

	[Cpp2IlInjected.Token(Token = "0x60000C1")]
	[Cpp2IlInjected.Address(Slot = "5")]
	HFEOBDFOGDH MAECOMNIBIE(EKBKMDGMIHO JANAFGLBOCK);

	[Cpp2IlInjected.Token(Token = "0x60000C2")]
	[Cpp2IlInjected.Address(Slot = "6")]
	DBCKLEANKGI FFEAHGNDBJP(EKBKMDGMIHO JANAFGLBOCK);

	[Cpp2IlInjected.Token(Token = "0x60000C3")]
	[Cpp2IlInjected.Address(Slot = "7")]
	HINKFLFNMKF ALGPPECNGGH(EKBKMDGMIHO JANAFGLBOCK);

	[Cpp2IlInjected.Token(Token = "0x60000C4")]
	[Cpp2IlInjected.Address(Slot = "8")]
	BDJDNDHNEIC HENOKDLOCDK(EKBKMDGMIHO JANAFGLBOCK);

	[Cpp2IlInjected.Token(Token = "0x60000C5")]
	[Cpp2IlInjected.Address(Slot = "9")]
	PCLBNMCPDOG JMHOENGJNBM(EKBKMDGMIHO JANAFGLBOCK);

	[Cpp2IlInjected.Token(Token = "0x60000C6")]
	[Cpp2IlInjected.Address(Slot = "10")]
	HIBMHPPLBHO GCJOEJHJKOC(EKBKMDGMIHO JANAFGLBOCK, [In] GNBAPJBBCHJ LJIEGDEDOHM);

	[Cpp2IlInjected.Token(Token = "0x60000C7")]
	[Cpp2IlInjected.Address(Slot = "11")]
	KJELJIKPEIH OHNDOOOPDAG(EKBKMDGMIHO JANAFGLBOCK, [In] GNBAPJBBCHJ LJIEGDEDOHM);

	[Cpp2IlInjected.Token(Token = "0x60000C8")]
	[Cpp2IlInjected.Address(Slot = "12")]
	DBGAJMEHHKE IAPMEFDKKEE(EKBKMDGMIHO JANAFGLBOCK, [In] GNBAPJBBCHJ LJIEGDEDOHM);

	[Cpp2IlInjected.Token(Token = "0x60000C9")]
	[Cpp2IlInjected.Address(Slot = "13")]
	PMJMGDFBDGN BFMGEHHONML(EKBKMDGMIHO JANAFGLBOCK, [In] GNBAPJBBCHJ LJIEGDEDOHM);

	[Cpp2IlInjected.Token(Token = "0x60000CA")]
	[Cpp2IlInjected.Address(Slot = "14")]
	BAKMCIPNAHA GLLJPBEKJLA(EKBKMDGMIHO JANAFGLBOCK, [In] GNBAPJBBCHJ LJIEGDEDOHM);

	[Cpp2IlInjected.Token(Token = "0x60000CB")]
	[Cpp2IlInjected.Address(Slot = "15")]
	EKBKMDGMIHO JLIEAMKBMKG(RigidbodyEx BINJLCOIDDF, GNBAPJBBCHJ LJIEGDEDOHM, BPMCNPBDJCK CAKLHAFGFAN);
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
public interface HINKFLFNMKF
{
	[Cpp2IlInjected.Token(Token = "0x60000CC")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void LOAKBAKPCPM(Vector3 PLHFEDHICDP, ForceMode AGPFLDAGFIP = ForceMode.Force);

	[Cpp2IlInjected.Token(Token = "0x60000CD")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void NDEHHCDMHHG(Vector3 PLHFEDHICDP, Vector3 FJFKFIAGEPM, ForceMode AGPFLDAGFIP);

	[Cpp2IlInjected.Token(Token = "0x60000CE")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void CFOFKMPAPNK(Vector3 NPKDLKCKHFJ, ForceMode AGPFLDAGFIP = ForceMode.Force);

	[Cpp2IlInjected.Token(Token = "0x60000CF")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void DKOPGDKOGHM(Vector3 NPKDLKCKHFJ, ForceMode AGPFLDAGFIP = ForceMode.Force);
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
public interface PCLBNMCPDOG
{
	[Cpp2IlInjected.Token(Token = "0x17000039")]
	bool JPGMDCDHJIB
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
	void OFPIEMIENHN(Rigidbody LOMDGCGOAME);

	[Cpp2IlInjected.Token(Token = "0x60000D3")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void NPPMBFABGCE(Rigidbody LOMDGCGOAME);
}
[Cpp2IlInjected.Token(Token = "0x200000F")]
public interface JEMMFOIBFDF : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x1700003A")]
	IReadOnlyList<EKBKMDGMIHO> GNBKGLLFNBF
	{
		[Cpp2IlInjected.Token(Token = "0x60000E6")]
		[Cpp2IlInjected.Address(Slot = "18")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700003B")]
	EKBKMDGMIHO IBCOIOCGJOD
	{
		[Cpp2IlInjected.Token(Token = "0x60000E7")]
		[Cpp2IlInjected.Address(Slot = "19")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700003C")]
	EKBKMDGMIHO DHGIKLOJLBP
	{
		[Cpp2IlInjected.Token(Token = "0x60000E8")]
		[Cpp2IlInjected.Address(Slot = "20")]
		get;
		[Cpp2IlInjected.Token(Token = "0x60000E9")]
		[Cpp2IlInjected.Address(Slot = "21")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x1400000A")]
	event ELNJCAEPAAK GGHLMHGGFGE;

	[Cpp2IlInjected.Token(Token = "0x1400000B")]
	event ELNJCAEPAAK OGLGAJAFIMK;

	[Cpp2IlInjected.Token(Token = "0x1400000C")]
	event AHKGFFDODJI KNLCLGKPIIK;

	[Cpp2IlInjected.Token(Token = "0x1400000D")]
	event Action HPAIGCNCEFI;

	[Cpp2IlInjected.Token(Token = "0x1400000E")]
	event Action GCOAMGMOHCO;

	[Cpp2IlInjected.Token(Token = "0x1400000F")]
	event Action<EKBKMDGMIHO> GNFAAANFCMA;

	[Cpp2IlInjected.Token(Token = "0x14000010")]
	event Action<EKBKMDGMIHO> BOEDKFNFFHJ;

	[Cpp2IlInjected.Token(Token = "0x14000011")]
	event Action GDAGBEBMLOF;

	[Cpp2IlInjected.Token(Token = "0x14000012")]
	event Action<EKBKMDGMIHO> HCLEOPHCPKG;

	[Cpp2IlInjected.Token(Token = "0x60000EA")]
	[Cpp2IlInjected.Address(Slot = "22")]
	void MJEAPHGJJFH(EKBKMDGMIHO PNMFMJOGIKA, bool BKKKGCNMPBE = false);
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
public interface NDHKKDEMMPE
{
	[Cpp2IlInjected.Token(Token = "0x1700003D")]
	Vector3 ANOAFLCLAAL
	{
		[Cpp2IlInjected.Token(Token = "0x60000EB")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700003E")]
	Vector3 JPGDPFHLJDM
	{
		[Cpp2IlInjected.Token(Token = "0x60000EC")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x60000ED")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void JAKFEKHNFBL(EKBKMDGMIHO MBOJNCFILKL, object NIOIDOPDJKO);

	[Cpp2IlInjected.Token(Token = "0x60000EE")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void DCBPACFGFBN(object NIOIDOPDJKO);
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
public interface PMJMGDFBDGN
{
	[Cpp2IlInjected.Token(Token = "0x1700003F")]
	Vector3 LFJGGINBIIP
	{
		[Cpp2IlInjected.Token(Token = "0x60000F1")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
		[Cpp2IlInjected.Token(Token = "0x60000F2")]
		[Cpp2IlInjected.Address(Slot = "3")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000040")]
	Vector3 GHHLLBKOPON
	{
		[Cpp2IlInjected.Token(Token = "0x60000F3")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000041")]
	float EKFBJIHOEDI
	{
		[Cpp2IlInjected.Token(Token = "0x60000F4")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000042")]
	float HACCOKMICKH
	{
		[Cpp2IlInjected.Token(Token = "0x60000F5")]
		[Cpp2IlInjected.Address(Slot = "6")]
		get;
		[Cpp2IlInjected.Token(Token = "0x60000F6")]
		[Cpp2IlInjected.Address(Slot = "7")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000043")]
	Vector3 ONHKOHEONIO
	{
		[Cpp2IlInjected.Token(Token = "0x60000F7")]
		[Cpp2IlInjected.Address(Slot = "8")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000044")]
	Quaternion MPNEHPGOGNK
	{
		[Cpp2IlInjected.Token(Token = "0x60000F8")]
		[Cpp2IlInjected.Address(Slot = "9")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x14000013")]
	event ELNJCAEPAAK FPCNKPDBGGF;

	[Cpp2IlInjected.Token(Token = "0x60000F9")]
	[Cpp2IlInjected.Address(Slot = "10")]
	void DNGGNEFAOCO((Quaternion rot, Vector3 moments) PDCLDKLEPFH);

	[Cpp2IlInjected.Token(Token = "0x60000FA")]
	[Cpp2IlInjected.Address(Slot = "11")]
	void DPGIAJJJGKG();

	[Cpp2IlInjected.Token(Token = "0x60000FB")]
	[Cpp2IlInjected.Address(Slot = "12")]
	void FNJALHOCFNC();

	[Cpp2IlInjected.Token(Token = "0x60000FC")]
	[Cpp2IlInjected.Address(Slot = "13")]
	void ELEEEMKCGFD();

	[Cpp2IlInjected.Token(Token = "0x60000FD")]
	[Cpp2IlInjected.Address(Slot = "14")]
	void OFPIEMIENHN(Rigidbody LOMDGCGOAME);

	[Cpp2IlInjected.Token(Token = "0x60000FE")]
	[Cpp2IlInjected.Address(Slot = "15")]
	void NPPMBFABGCE(Rigidbody LOMDGCGOAME);

	[Cpp2IlInjected.Token(Token = "0x60000FF")]
	[Cpp2IlInjected.Address(Slot = "16")]
	void PPIFADPJHHC();
}
[Cpp2IlInjected.Token(Token = "0x2000012")]
public interface DBGAJMEHHKE
{
	[Cpp2IlInjected.Token(Token = "0x6000100")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void AHDMKGLGKBO();

	[Cpp2IlInjected.Token(Token = "0x6000101")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void DAGKFMFGFML(object NIOIDOPDJKO);

	[Cpp2IlInjected.Token(Token = "0x6000102")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void BNPDPMBOHMM(object NIOIDOPDJKO);

	[Cpp2IlInjected.Token(Token = "0x6000103")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void DAKOKGEHGMK(EKBKMDGMIHO BINJLCOIDDF);

	[Cpp2IlInjected.Token(Token = "0x6000104")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void ABNFBLFDADD(EKBKMDGMIHO BINJLCOIDDF);

	[Cpp2IlInjected.Token(Token = "0x6000105")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void OCCPGPEMPIC();
}
[Cpp2IlInjected.Token(Token = "0x2000013")]
public interface DBCKLEANKGI
{
	[Cpp2IlInjected.Token(Token = "0x17000045")]
	bool GBBOHGPNMEI
	{
		[Cpp2IlInjected.Token(Token = "0x6000108")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x14000014")]
	event ELNJCAEPAAK BFOCPMIHFEE;

	[Cpp2IlInjected.Token(Token = "0x6000109")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void EAGABFFPMMP(object NIOIDOPDJKO);

	[Cpp2IlInjected.Token(Token = "0x600010A")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void MCANPGGOMHC(object NIOIDOPDJKO);

	[Cpp2IlInjected.Token(Token = "0x600010B")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void LFECLAJJHDN(object NIOIDOPDJKO, bool FOEAHOLLJJF);

	[Cpp2IlInjected.Token(Token = "0x600010C")]
	[Cpp2IlInjected.Address(Slot = "6")]
	void OFPIEMIENHN(Rigidbody ABNMHEDMNIJ);

	[Cpp2IlInjected.Token(Token = "0x600010D")]
	[Cpp2IlInjected.Address(Slot = "7")]
	void NPPMBFABGCE(Rigidbody LOMDGCGOAME);
}
[Cpp2IlInjected.Token(Token = "0x2000014")]
public interface KJELJIKPEIH : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x17000046")]
	bool BEFHKFOFCJO
	{
		[Cpp2IlInjected.Token(Token = "0x6000110")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000047")]
	bool IFGEEMNBFMB
	{
		[Cpp2IlInjected.Token(Token = "0x6000111")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x14000015")]
	event ELNJCAEPAAK NPPBKJKFFCC;

	[Cpp2IlInjected.Token(Token = "0x6000112")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void AHDMKGLGKBO();

	[Cpp2IlInjected.Token(Token = "0x6000113")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void FPJGMCLHAPN(EKBKMDGMIHO MBOJNCFILKL);

	[Cpp2IlInjected.Token(Token = "0x6000114")]
	[Cpp2IlInjected.Address(Slot = "6")]
	void COPGKIPFBJO(EKBKMDGMIHO MBOJNCFILKL);
}
[Cpp2IlInjected.Token(Token = "0x2000015")]
public interface BAKMCIPNAHA
{
	[Cpp2IlInjected.Token(Token = "0x17000048")]
	bool HCCJIIKCKAD
	{
		[Cpp2IlInjected.Token(Token = "0x6000115")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
		[Cpp2IlInjected.Token(Token = "0x6000116")]
		[Cpp2IlInjected.Address(Slot = "1")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000049")]
	bool DMCAAMCDFDK
	{
		[Cpp2IlInjected.Token(Token = "0x6000117")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700004A")]
	RigidbodyConstraints ONMDJJAOKEN
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
	void OFPIEMIENHN(Rigidbody LOMDGCGOAME);

	[Cpp2IlInjected.Token(Token = "0x600011B")]
	[Cpp2IlInjected.Address(Slot = "6")]
	void NPPMBFABGCE(Rigidbody LOMDGCGOAME);
}
[Cpp2IlInjected.Token(Token = "0x2000016")]
public interface PMPHEBCFCMC
{
	[Cpp2IlInjected.Token(Token = "0x1700004B")]
	float GLADHIFEMKF
	{
		[Cpp2IlInjected.Token(Token = "0x600011C")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
		[Cpp2IlInjected.Token(Token = "0x600011D")]
		[Cpp2IlInjected.Address(Slot = "1")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x1700004C")]
	float NKNCHAACCBB
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
	void OFPIEMIENHN(Rigidbody LOMDGCGOAME);

	[Cpp2IlInjected.Token(Token = "0x6000121")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void NPPMBFABGCE(Rigidbody LOMDGCGOAME);
}
[Cpp2IlInjected.Token(Token = "0x2000017")]
public interface OLEOCEJGBKB
{
	[Cpp2IlInjected.Token(Token = "0x14000016")]
	event ELNJCAEPAAK CJFJJNDMAIP;

	[Cpp2IlInjected.Token(Token = "0x6000124")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void AHDMKGLGKBO();

	[Cpp2IlInjected.Token(Token = "0x6000125")]
	[Cpp2IlInjected.Address(Slot = "3")]
	bool EPPJDPEDBGL();

	[Cpp2IlInjected.Token(Token = "0x6000126")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void CFOJAPGBBPH();

	[Cpp2IlInjected.Token(Token = "0x6000127")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void AGNPDGIKBIK();

	[Cpp2IlInjected.Token(Token = "0x6000128")]
	[Cpp2IlInjected.Address(Slot = "6")]
	void FOGCPMFHMIM();

	[Cpp2IlInjected.Token(Token = "0x6000129")]
	[Cpp2IlInjected.Address(Slot = "7")]
	void OHGIIOIIMII();
}
[Cpp2IlInjected.Token(Token = "0x2000018")]
public interface HIBMHPPLBHO
{
	[Cpp2IlInjected.Token(Token = "0x1700004D")]
	Rigidbody PAAIMMKMKDI
	{
		[Cpp2IlInjected.Token(Token = "0x600012A")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700004E")]
	bool LNDICMCFIPK
	{
		[Cpp2IlInjected.Token(Token = "0x600012C")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x600012B")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void AHDMKGLGKBO();

	[Cpp2IlInjected.Token(Token = "0x600012D")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void NONEIJICMCC(object NIOIDOPDJKO);

	[Cpp2IlInjected.Token(Token = "0x600012E")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void OEAAGOFKENI(object NIOIDOPDJKO);

	[Cpp2IlInjected.Token(Token = "0x600012F")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void KPOPOHDLFJA();
}
[Cpp2IlInjected.Token(Token = "0x2000019")]
public interface MDPIGHOADEP : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x1700004F")]
	POBAPJPNJIF OKLDKBDBGNP
	{
		[Cpp2IlInjected.Token(Token = "0x6000130")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
		[Cpp2IlInjected.Token(Token = "0x6000131")]
		[Cpp2IlInjected.Address(Slot = "1")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000050")]
	JJAKICIKFMK KEMNPJCLCNA
	{
		[Cpp2IlInjected.Token(Token = "0x6000132")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
		[Cpp2IlInjected.Token(Token = "0x6000133")]
		[Cpp2IlInjected.Address(Slot = "3")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000051")]
	Vector3 KBAKMFGPJLG
	{
		[Cpp2IlInjected.Token(Token = "0x6000134")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
		[Cpp2IlInjected.Token(Token = "0x6000135")]
		[Cpp2IlInjected.Address(Slot = "5")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000052")]
	Vector3 BIHFCPFIPNN
	{
		[Cpp2IlInjected.Token(Token = "0x6000136")]
		[Cpp2IlInjected.Address(Slot = "6")]
		get;
		[Cpp2IlInjected.Token(Token = "0x6000137")]
		[Cpp2IlInjected.Address(Slot = "7")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000053")]
	Vector3 OEMJMBCMIKA
	{
		[Cpp2IlInjected.Token(Token = "0x6000138")]
		[Cpp2IlInjected.Address(Slot = "8")]
		get;
		[Cpp2IlInjected.Token(Token = "0x6000139")]
		[Cpp2IlInjected.Address(Slot = "9")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000054")]
	Vector3 LEJCIOCLJLG
	{
		[Cpp2IlInjected.Token(Token = "0x600013A")]
		[Cpp2IlInjected.Address(Slot = "10")]
		get;
		[Cpp2IlInjected.Token(Token = "0x600013B")]
		[Cpp2IlInjected.Address(Slot = "11")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000055")]
	float KGLOMNONIBO
	{
		[Cpp2IlInjected.Token(Token = "0x600013C")]
		[Cpp2IlInjected.Address(Slot = "12")]
		get;
		[Cpp2IlInjected.Token(Token = "0x600013D")]
		[Cpp2IlInjected.Address(Slot = "13")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000056")]
	bool BFIALJKMPNL
	{
		[Cpp2IlInjected.Token(Token = "0x600013E")]
		[Cpp2IlInjected.Address(Slot = "14")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x600013F")]
	[Cpp2IlInjected.Address(Slot = "15")]
	void AHDMKGLGKBO();

	[Cpp2IlInjected.Token(Token = "0x6000140")]
	[Cpp2IlInjected.Address(Slot = "16")]
	void LFBDMBFPNBI(object NIOIDOPDJKO);

	[Cpp2IlInjected.Token(Token = "0x6000141")]
	[Cpp2IlInjected.Address(Slot = "17")]
	void PDHNHLCFFDB(JIOFAHGJLPH KDOGOEHPAMH, Vector3 KEIBLCIFAEK, float CNCMGOOCLHH = float.PositiveInfinity);

	[Cpp2IlInjected.Token(Token = "0x6000142")]
	[Cpp2IlInjected.Address(Slot = "18")]
	void CKOALKCLCCK(KNPMGCIOAIO GPBGOJOBPDD, Vector3 NBLKIPPEOAD, float PMAAKLFOBHF, float EEAHHPFKLHF = 8f, float BHCLILJBOCH = 1f);

	[Cpp2IlInjected.Token(Token = "0x6000143")]
	[Cpp2IlInjected.Address(Slot = "19")]
	void MCPCHEDLNPF(JIOFAHGJLPH KDOGOEHPAMH, Vector3 MBMKLLFOFFL, float JIJBBEKPCIF = 7f, float NCMKACAPAEK = 1f);

	[Cpp2IlInjected.Token(Token = "0x6000144")]
	[Cpp2IlInjected.Address(Slot = "20")]
	void HGJBDOFNHOE();

	[Cpp2IlInjected.Token(Token = "0x6000145")]
	[Cpp2IlInjected.Address(Slot = "21")]
	void LOGAJLHKHPP();

	[Cpp2IlInjected.Token(Token = "0x6000146")]
	[Cpp2IlInjected.Address(Slot = "22")]
	void KJPJJLAMIPM();

	[Cpp2IlInjected.Token(Token = "0x6000147")]
	[Cpp2IlInjected.Address(Slot = "23")]
	void CKMLCDAHKNE();

	[Cpp2IlInjected.Token(Token = "0x6000148")]
	[Cpp2IlInjected.Address(Slot = "24")]
	void OFPIEMIENHN(Rigidbody LOMDGCGOAME);

	[Cpp2IlInjected.Token(Token = "0x6000149")]
	[Cpp2IlInjected.Address(Slot = "25")]
	Vector3 OHEEAJNKOAD(Vector3 BEEOMEJFEKJ);

	[Cpp2IlInjected.Token(Token = "0x600014A")]
	[Cpp2IlInjected.Address(Slot = "26")]
	void DJKHLNOIHDC(object NIOIDOPDJKO);

	[Cpp2IlInjected.Token(Token = "0x600014B")]
	[Cpp2IlInjected.Address(Slot = "27")]
	void IIAEJMEGJMB(Vector3 IANJJOPONOA);

	[Cpp2IlInjected.Token(Token = "0x600014C")]
	[Cpp2IlInjected.Address(Slot = "28")]
	void CCJHLODLJDC(Vector3 OBJNBNIHDNA, Vector3 CPBKNIAPNBD);

	[Cpp2IlInjected.Token(Token = "0x600014D")]
	[Cpp2IlInjected.Address(Slot = "29")]
	void BEHNGDKFALP(Vector3 JJGNONCAJKL, Vector3 HJANGHEDIGO);

	[Cpp2IlInjected.Token(Token = "0x600014E")]
	[Cpp2IlInjected.Address(Slot = "30")]
	Vector3 NIKABBPFJNG(Vector3 PDMDPBKDBDN);

	[Cpp2IlInjected.Token(Token = "0x600014F")]
	[Cpp2IlInjected.Address(Slot = "31")]
	Vector3 MFBCEHFOCAN(Vector3 NJMKNHLGFKE);
}
[Cpp2IlInjected.Token(Token = "0x200001A")]
[IIAPEOFKIPJ(NPIKHFLBMBK.Application)]
public interface PMBKEPOBBGI
{
	[Cpp2IlInjected.Token(Token = "0x17000057")]
	bool LAHDHPMLGPD
	{
		[Cpp2IlInjected.Token(Token = "0x6000150")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000151")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void PKKPKEGECIA(string BAHJDCJDFHC);

	[Cpp2IlInjected.Token(Token = "0x6000152")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void BBCGEBBFKDK(RigidbodyEx BINJLCOIDDF, Action ECFGAICLGCA);

	[Cpp2IlInjected.Token(Token = "0x6000153")]
	[Cpp2IlInjected.Address(Slot = "3")]
	PGCEDDPBELO EBJDGOECMMA(int IFEDKMJAEFM);

	[Cpp2IlInjected.Token(Token = "0x6000154")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void OCHOFJOPOIC(Vector3 MHGPMALCJMN, float JJDOANMIHEO, Color CIHDHJMCJNM);
}
[Cpp2IlInjected.Token(Token = "0x200001B")]
[IIAPEOFKIPJ(NPIKHFLBMBK.Application)]
public interface BPMCNPBDJCK
{
	[Cpp2IlInjected.Token(Token = "0x17000058")]
	PMBKEPOBBGI FIAONLBOBCL
	{
		[Cpp2IlInjected.Token(Token = "0x6000155")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000059")]
	DFCJPPCLEBM BKMIMOHDIEK
	{
		[Cpp2IlInjected.Token(Token = "0x6000156")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000157")]
	[Cpp2IlInjected.Address(Slot = "2")]
	EKBKMDGMIHO JLIEAMKBMKG(RigidbodyEx BINJLCOIDDF, GNBAPJBBCHJ LJIEGDEDOHM);
}
[Cpp2IlInjected.Token(Token = "0x200001C")]
public class PMLAOCKCIDG : EKBKMDGMIHO, IDisposable, JMAKDLOGPBC
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000017")]
	internal readonly BPMCNPBDJCK CAKLHAFGFAN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000018")]
	internal JEMMFOIBFDF NNJMEFLKCNI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000019")]
	internal DBGAJMEHHKE BHFJLCNKMHJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400001A")]
	internal KJELJIKPEIH DAGFLFLFNLI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400001B")]
	internal MDPIGHOADEP BEEOMEJFEKJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x400001C")]
	internal NDHKKDEMMPE AHAPMKCJFOB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x400001D")]
	internal PMJMGDFBDGN INDBPJPANOC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x400001E")]
	internal PMPHEBCFCMC DPDOMEBGGID;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x400001F")]
	internal PCLBNMCPDOG OOGEPIAIHBA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x4000020")]
	internal OLEOCEJGBKB FLFAACNDJLA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x4000021")]
	internal HFEOBDFOGDH CKEJABJMPDF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x4000022")]
	internal DBCKLEANKGI KADCLNMMGPP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x4000023")]
	internal HINKFLFNMKF PLHFEDHICDP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
	[Cpp2IlInjected.Token(Token = "0x4000024")]
	internal BAKMCIPNAHA FNFNEPKFFKM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x4000025")]
	internal HIBMHPPLBHO LOMDGCGOAME;

	[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
	[Cpp2IlInjected.Token(Token = "0x4000026")]
	internal BDJDNDHNEIC OAAEKINCEEE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
	[Cpp2IlInjected.Token(Token = "0x4000027")]
	internal IDisposable NJCFJLDLNPN;

	[Cpp2IlInjected.Token(Token = "0x1700005A")]
	public GKJNOENDIKB GGMCDFOELGJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000158")]
		[Cpp2IlInjected.Address(RVA = "0x8966C0", Offset = "0x8958C0", VA = "0x1808966C0", Slot = "22")]
		get
		{
			return default(GKJNOENDIKB);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700005B")]
	public PIMMPONFKHJ LEINJJFCOID
	{
		[Cpp2IlInjected.Token(Token = "0x6000159")]
		[Cpp2IlInjected.Address(RVA = "0x8A2400", Offset = "0x8A1600", VA = "0x1808A2400", Slot = "24")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600015A")]
		[Cpp2IlInjected.Address(RVA = "0x8A2470", Offset = "0x8A1670", VA = "0x1808A2470")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700005C")]
	public GameObject OLKEAKJDKHD
	{
		[Cpp2IlInjected.Token(Token = "0x600015B")]
		[Cpp2IlInjected.Address(RVA = "0x99C970", Offset = "0x99BB70", VA = "0x18099C970", Slot = "25")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600015C")]
		[Cpp2IlInjected.Address(RVA = "0x98E630", Offset = "0x98D830", VA = "0x18098E630")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700005D")]
	public Transform HFFBGEFJFMD
	{
		[Cpp2IlInjected.Token(Token = "0x600015D")]
		[Cpp2IlInjected.Address(RVA = "0x899430", Offset = "0x898630", VA = "0x180899430", Slot = "26")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600015E")]
		[Cpp2IlInjected.Address(RVA = "0x8993B0", Offset = "0x8985B0", VA = "0x1808993B0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700005E")]
	public Rigidbody PAAIMMKMKDI
	{
		[Cpp2IlInjected.Token(Token = "0x600015F")]
		[Cpp2IlInjected.Address(RVA = "0x72E95E0", Offset = "0x72E87E0", VA = "0x1872E95E0", Slot = "23")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700005F")]
	public EKBKMDGMIHO DHGIKLOJLBP
	{
		[Cpp2IlInjected.Token(Token = "0x600016D")]
		[Cpp2IlInjected.Address(RVA = "0x72ED4F0", Offset = "0x72EC6F0", VA = "0x1872ED4F0", Slot = "27")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600016E")]
		[Cpp2IlInjected.Address(RVA = "0x72EC240", Offset = "0x72EB440", VA = "0x1872EC240", Slot = "28")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000060")]
	public int IJGHCKCLFGH
	{
		[Cpp2IlInjected.Token(Token = "0x600016F")]
		[Cpp2IlInjected.Address(RVA = "0x72EAD60", Offset = "0x72E9F60", VA = "0x1872EAD60", Slot = "31")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000061")]
	public EKBKMDGMIHO IBCOIOCGJOD
	{
		[Cpp2IlInjected.Token(Token = "0x6000171")]
		[Cpp2IlInjected.Address(RVA = "0x72EBC80", Offset = "0x72EAE80", VA = "0x1872EBC80", Slot = "29")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000062")]
	public bool OMNFODDCIFN
	{
		[Cpp2IlInjected.Token(Token = "0x6000172")]
		[Cpp2IlInjected.Address(RVA = "0x72EC2F0", Offset = "0x72EB4F0", VA = "0x1872EC2F0", Slot = "32")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000063")]
	public bool BEFHKFOFCJO
	{
		[Cpp2IlInjected.Token(Token = "0x6000176")]
		[Cpp2IlInjected.Address(RVA = "0x72ECF60", Offset = "0x72EC160", VA = "0x1872ECF60", Slot = "33")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000064")]
	public bool IFGEEMNBFMB
	{
		[Cpp2IlInjected.Token(Token = "0x6000177")]
		[Cpp2IlInjected.Address(RVA = "0x72EB9E0", Offset = "0x72EABE0", VA = "0x1872EB9E0", Slot = "34")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000065")]
	public POBAPJPNJIF OKLDKBDBGNP
	{
		[Cpp2IlInjected.Token(Token = "0x6000178")]
		[Cpp2IlInjected.Address(RVA = "0x72EE010", Offset = "0x72ED210", VA = "0x1872EE010", Slot = "35")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000179")]
		[Cpp2IlInjected.Address(RVA = "0x72EBB40", Offset = "0x72EAD40", VA = "0x1872EBB40", Slot = "36")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000066")]
	public JJAKICIKFMK KEMNPJCLCNA
	{
		[Cpp2IlInjected.Token(Token = "0x600017A")]
		[Cpp2IlInjected.Address(RVA = "0x72EAC10", Offset = "0x72E9E10", VA = "0x1872EAC10", Slot = "37")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600017B")]
		[Cpp2IlInjected.Address(RVA = "0x72EDB50", Offset = "0x72ECD50", VA = "0x1872EDB50", Slot = "38")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000067")]
	public float KGLOMNONIBO
	{
		[Cpp2IlInjected.Token(Token = "0x600017C")]
		[Cpp2IlInjected.Address(RVA = "0x72E98F0", Offset = "0x72E8AF0", VA = "0x1872E98F0", Slot = "39")]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x600017D")]
		[Cpp2IlInjected.Address(RVA = "0x72EDBB0", Offset = "0x72ECDB0", VA = "0x1872EDBB0", Slot = "40")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000068")]
	public Vector3 BIHFCPFIPNN
	{
		[Cpp2IlInjected.Token(Token = "0x600017E")]
		[Cpp2IlInjected.Address(RVA = "0x72E9810", Offset = "0x72E8A10", VA = "0x1872E9810", Slot = "41")]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x600017F")]
		[Cpp2IlInjected.Address(RVA = "0x72E8FF0", Offset = "0x72E81F0", VA = "0x1872E8FF0", Slot = "42")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000069")]
	public Vector3 LEJCIOCLJLG
	{
		[Cpp2IlInjected.Token(Token = "0x6000180")]
		[Cpp2IlInjected.Address(RVA = "0x72ECA10", Offset = "0x72EBC10", VA = "0x1872ECA10", Slot = "43")]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x6000181")]
		[Cpp2IlInjected.Address(RVA = "0x72E9300", Offset = "0x72E8500", VA = "0x1872E9300", Slot = "44")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700006A")]
	public Vector3 KBAKMFGPJLG
	{
		[Cpp2IlInjected.Token(Token = "0x6000182")]
		[Cpp2IlInjected.Address(RVA = "0x72EA6E0", Offset = "0x72E98E0", VA = "0x1872EA6E0", Slot = "45")]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x6000183")]
		[Cpp2IlInjected.Address(RVA = "0x72EB900", Offset = "0x72EAB00", VA = "0x1872EB900", Slot = "46")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700006B")]
	public Vector3 OEMJMBCMIKA
	{
		[Cpp2IlInjected.Token(Token = "0x6000184")]
		[Cpp2IlInjected.Address(RVA = "0x72EDE50", Offset = "0x72ED050", VA = "0x1872EDE50", Slot = "47")]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x6000185")]
		[Cpp2IlInjected.Address(RVA = "0x72E9F30", Offset = "0x72E9130", VA = "0x1872E9F30", Slot = "48")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700006C")]
	public bool JJPGBNMDLJN
	{
		[Cpp2IlInjected.Token(Token = "0x6000186")]
		[Cpp2IlInjected.Address(RVA = "0x72EB140", Offset = "0x72EA340", VA = "0x1872EB140", Slot = "139")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700006D")]
	public bool DENIFBCGAME
	{
		[Cpp2IlInjected.Token(Token = "0x6000187")]
		[Cpp2IlInjected.Address(RVA = "0x72EAD00", Offset = "0x72E9F00", VA = "0x1872EAD00", Slot = "49")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700006E")]
	public bool HKCMABLGADC
	{
		[Cpp2IlInjected.Token(Token = "0x6000188")]
		[Cpp2IlInjected.Address(RVA = "0x72E8390", Offset = "0x72E7590", VA = "0x1872E8390", Slot = "50")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700006F")]
	public bool BFIALJKMPNL
	{
		[Cpp2IlInjected.Token(Token = "0x6000189")]
		[Cpp2IlInjected.Address(RVA = "0x72E9CB0", Offset = "0x72E8EB0", VA = "0x1872E9CB0", Slot = "51")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000070")]
	public Vector3 ANOAFLCLAAL
	{
		[Cpp2IlInjected.Token(Token = "0x600019A")]
		[Cpp2IlInjected.Address(RVA = "0x72EC6D0", Offset = "0x72EB8D0", VA = "0x1872EC6D0", Slot = "52")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000071")]
	public Vector3 JPGDPFHLJDM
	{
		[Cpp2IlInjected.Token(Token = "0x600019B")]
		[Cpp2IlInjected.Address(RVA = "0x72ED860", Offset = "0x72ECA60", VA = "0x1872ED860", Slot = "53")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000072")]
	public Vector3 LFJGGINBIIP
	{
		[Cpp2IlInjected.Token(Token = "0x60001A0")]
		[Cpp2IlInjected.Address(RVA = "0x72ED780", Offset = "0x72EC980", VA = "0x1872ED780", Slot = "54")]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x60001A1")]
		[Cpp2IlInjected.Address(RVA = "0x72EC800", Offset = "0x72EBA00", VA = "0x1872EC800", Slot = "55")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000073")]
	public Vector3 GHHLLBKOPON
	{
		[Cpp2IlInjected.Token(Token = "0x60001A2")]
		[Cpp2IlInjected.Address(RVA = "0x72EA9D0", Offset = "0x72E9BD0", VA = "0x1872EA9D0", Slot = "56")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000074")]
	public float EKFBJIHOEDI
	{
		[Cpp2IlInjected.Token(Token = "0x60001A3")]
		[Cpp2IlInjected.Address(RVA = "0x72EB0F0", Offset = "0x72EA2F0", VA = "0x1872EB0F0", Slot = "57")]
		get
		{
			return default(float);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000075")]
	public float HACCOKMICKH
	{
		[Cpp2IlInjected.Token(Token = "0x60001A4")]
		[Cpp2IlInjected.Address(RVA = "0x72E9E80", Offset = "0x72E9080", VA = "0x1872E9E80", Slot = "58")]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x60001A5")]
		[Cpp2IlInjected.Address(RVA = "0x72EBFE0", Offset = "0x72EB1E0", VA = "0x1872EBFE0", Slot = "59")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000076")]
	public Vector3 ONHKOHEONIO
	{
		[Cpp2IlInjected.Token(Token = "0x60001A6")]
		[Cpp2IlInjected.Address(RVA = "0x72EC040", Offset = "0x72EB240", VA = "0x1872EC040", Slot = "60")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000077")]
	public Quaternion MPNEHPGOGNK
	{
		[Cpp2IlInjected.Token(Token = "0x60001A7")]
		[Cpp2IlInjected.Address(RVA = "0x72EA090", Offset = "0x72E9290", VA = "0x1872EA090", Slot = "61")]
		get
		{
			return default(Quaternion);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000078")]
	public float GLADHIFEMKF
	{
		[Cpp2IlInjected.Token(Token = "0x60001AC")]
		[Cpp2IlInjected.Address(RVA = "0x72EC2A0", Offset = "0x72EB4A0", VA = "0x1872EC2A0", Slot = "63")]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x60001AD")]
		[Cpp2IlInjected.Address(RVA = "0x72EA680", Offset = "0x72E9880", VA = "0x1872EA680", Slot = "64")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000079")]
	public float NKNCHAACCBB
	{
		[Cpp2IlInjected.Token(Token = "0x60001AE")]
		[Cpp2IlInjected.Address(RVA = "0x72E8FA0", Offset = "0x72E81A0", VA = "0x1872E8FA0", Slot = "65")]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x60001AF")]
		[Cpp2IlInjected.Address(RVA = "0x72ED2B0", Offset = "0x72EC4B0", VA = "0x1872ED2B0", Slot = "66")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700007A")]
	public bool JPGMDCDHJIB
	{
		[Cpp2IlInjected.Token(Token = "0x60001B0")]
		[Cpp2IlInjected.Address(RVA = "0x72EB1E0", Offset = "0x72EA3E0", VA = "0x1872EB1E0", Slot = "67")]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x60001B1")]
		[Cpp2IlInjected.Address(RVA = "0x72EC7A0", Offset = "0x72EB9A0", VA = "0x1872EC7A0", Slot = "68")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700007B")]
	public KFABMCIICMN DJHGPHELGJE
	{
		[Cpp2IlInjected.Token(Token = "0x60001B9")]
		[Cpp2IlInjected.Address(RVA = "0x72EB7A0", Offset = "0x72EA9A0", VA = "0x1872EB7A0", Slot = "69")]
		get
		{
			return default(KFABMCIICMN);
		}
		[Cpp2IlInjected.Token(Token = "0x60001BA")]
		[Cpp2IlInjected.Address(RVA = "0x72ECC20", Offset = "0x72EBE20", VA = "0x1872ECC20", Slot = "70")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700007C")]
	public bool GBBOHGPNMEI
	{
		[Cpp2IlInjected.Token(Token = "0x60001BD")]
		[Cpp2IlInjected.Address(RVA = "0x72EAC60", Offset = "0x72E9E60", VA = "0x1872EAC60", Slot = "71")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700007D")]
	public Transform OALGNAOLOLM
	{
		[Cpp2IlInjected.Token(Token = "0x60001C3")]
		[Cpp2IlInjected.Address(RVA = "0x899430", Offset = "0x898630", VA = "0x180899430", Slot = "72")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700007E")]
	public Vector3 KMMKJNODBCG
	{
		[Cpp2IlInjected.Token(Token = "0x60001C4")]
		[Cpp2IlInjected.Address(RVA = "0x72E99E0", Offset = "0x72E8BE0", VA = "0x1872E99E0", Slot = "73")]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x60001C5")]
		[Cpp2IlInjected.Address(RVA = "0x72EA870", Offset = "0x72E9A70", VA = "0x1872EA870", Slot = "74")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700007F")]
	public float CKNBAMNNAMG
	{
		[Cpp2IlInjected.Token(Token = "0x60001C6")]
		[Cpp2IlInjected.Address(RVA = "0x72E8F50", Offset = "0x72E8150", VA = "0x1872E8F50", Slot = "75")]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x60001C7")]
		[Cpp2IlInjected.Address(RVA = "0x72EC120", Offset = "0x72EB320", VA = "0x1872EC120", Slot = "76")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000080")]
	public float POAGEEMBLEF
	{
		[Cpp2IlInjected.Token(Token = "0x60001C8")]
		[Cpp2IlInjected.Address(RVA = "0x72EBD30", Offset = "0x72EAF30", VA = "0x1872EBD30", Slot = "77")]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x60001C9")]
		[Cpp2IlInjected.Address(RVA = "0x72ED640", Offset = "0x72EC840", VA = "0x1872ED640", Slot = "78")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000081")]
	public Quaternion IMCJPNMAJNN
	{
		[Cpp2IlInjected.Token(Token = "0x60001CA")]
		[Cpp2IlInjected.Address(RVA = "0x72EC350", Offset = "0x72EB550", VA = "0x1872EC350", Slot = "79")]
		get
		{
			return default(Quaternion);
		}
		[Cpp2IlInjected.Token(Token = "0x60001CB")]
		[Cpp2IlInjected.Address(RVA = "0x72EDF30", Offset = "0x72ED130", VA = "0x1872EDF30", Slot = "80")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000082")]
	public Vector3 BNMCNAJDLKI
	{
		[Cpp2IlInjected.Token(Token = "0x60001CC")]
		[Cpp2IlInjected.Address(RVA = "0x72E93E0", Offset = "0x72E85E0", VA = "0x1872E93E0", Slot = "81")]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x60001CD")]
		[Cpp2IlInjected.Address(RVA = "0x72EAAB0", Offset = "0x72E9CB0", VA = "0x1872EAAB0", Slot = "82")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000083")]
	public Quaternion JNDADJGBBAA
	{
		[Cpp2IlInjected.Token(Token = "0x60001CE")]
		[Cpp2IlInjected.Address(RVA = "0x72E8F60", Offset = "0x72E8160", VA = "0x1872E8F60", Slot = "83")]
		get
		{
			return default(Quaternion);
		}
		[Cpp2IlInjected.Token(Token = "0x60001CF")]
		[Cpp2IlInjected.Address(RVA = "0x72EC4F0", Offset = "0x72EB6F0", VA = "0x1872EC4F0", Slot = "84")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000084")]
	public RigidbodyConstraints ONMDJJAOKEN
	{
		[Cpp2IlInjected.Token(Token = "0x60001D3")]
		[Cpp2IlInjected.Address(RVA = "0x72EC190", Offset = "0x72EB390", VA = "0x1872EC190", Slot = "85")]
		get
		{
			return default(RigidbodyConstraints);
		}
		[Cpp2IlInjected.Token(Token = "0x60001D4")]
		[Cpp2IlInjected.Address(RVA = "0x72EC1E0", Offset = "0x72EB3E0", VA = "0x1872EC1E0", Slot = "86")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000085")]
	public bool HCCJIIKCKAD
	{
		[Cpp2IlInjected.Token(Token = "0x60001D5")]
		[Cpp2IlInjected.Address(RVA = "0x72EA980", Offset = "0x72E9B80", VA = "0x1872EA980", Slot = "87")]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x60001D6")]
		[Cpp2IlInjected.Address(RVA = "0x72E8850", Offset = "0x72E7A50", VA = "0x1872E8850", Slot = "88")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000086")]
	public CollisionDetectionMode MDOAMCGNLFH
	{
		[Cpp2IlInjected.Token(Token = "0x60001DF")]
		[Cpp2IlInjected.Address(RVA = "0x72EBF90", Offset = "0x72EB190", VA = "0x1872EBF90", Slot = "89")]
		get
		{
			return default(CollisionDetectionMode);
		}
		[Cpp2IlInjected.Token(Token = "0x60001E0")]
		[Cpp2IlInjected.Address(RVA = "0x72ED250", Offset = "0x72EC450", VA = "0x1872ED250", Slot = "90")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000087")]
	public bool AHABAMCABAJ
	{
		[Cpp2IlInjected.Token(Token = "0x60001E2")]
		[Cpp2IlInjected.Address(RVA = "0x72E8A60", Offset = "0x72E7C60", VA = "0x1872E8A60", Slot = "140")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000088")]
	public bool NCCODDIBCOL
	{
		[Cpp2IlInjected.Token(Token = "0x60001E3")]
		[Cpp2IlInjected.Address(RVA = "0x72ED310", Offset = "0x72EC510", VA = "0x1872ED310", Slot = "91")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000017")]
	public event ELNJCAEPAAK GGHLMHGGFGE
	{
		[Cpp2IlInjected.Token(Token = "0x6000167")]
		[Cpp2IlInjected.Address(RVA = "0x72EC9B0", Offset = "0x72EBBB0", VA = "0x1872EC9B0", Slot = "4")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000168")]
		[Cpp2IlInjected.Address(RVA = "0x72ED490", Offset = "0x72EC690", VA = "0x1872ED490", Slot = "5")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000018")]
	public event ELNJCAEPAAK OGLGAJAFIMK
	{
		[Cpp2IlInjected.Token(Token = "0x6000169")]
		[Cpp2IlInjected.Address(RVA = "0x72EA810", Offset = "0x72E9A10", VA = "0x1872EA810", Slot = "6")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600016A")]
		[Cpp2IlInjected.Address(RVA = "0x72EDCF0", Offset = "0x72ECEF0", VA = "0x1872EDCF0", Slot = "7")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000019")]
	public event AHKGFFDODJI KNLCLGKPIIK
	{
		[Cpp2IlInjected.Token(Token = "0x600016B")]
		[Cpp2IlInjected.Address(RVA = "0x72E9A90", Offset = "0x72E8C90", VA = "0x1872E9A90", Slot = "18")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600016C")]
		[Cpp2IlInjected.Address(RVA = "0x72EBD40", Offset = "0x72EAF40", VA = "0x1872EBD40", Slot = "19")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400001A")]
	public event ELNJCAEPAAK NPPBKJKFFCC
	{
		[Cpp2IlInjected.Token(Token = "0x6000174")]
		[Cpp2IlInjected.Address(RVA = "0x72EB7F0", Offset = "0x72EA9F0", VA = "0x1872EB7F0", Slot = "8")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000175")]
		[Cpp2IlInjected.Address(RVA = "0x72EBCD0", Offset = "0x72EAED0", VA = "0x1872EBCD0", Slot = "9")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400001B")]
	public event ELNJCAEPAAK OCLAFMBFEEH
	{
		[Cpp2IlInjected.Token(Token = "0x600019E")]
		[Cpp2IlInjected.Address(RVA = "0x72EA5D0", Offset = "0x72E97D0", VA = "0x1872EA5D0", Slot = "14")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600019F")]
		[Cpp2IlInjected.Address(RVA = "0x72EC520", Offset = "0x72EB720", VA = "0x1872EC520", Slot = "15")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400001C")]
	public event ELNJCAEPAAK CJFJJNDMAIP
	{
		[Cpp2IlInjected.Token(Token = "0x60001B2")]
		[Cpp2IlInjected.Address(RVA = "0x72ED9A0", Offset = "0x72ECBA0", VA = "0x1872ED9A0", Slot = "16")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60001B3")]
		[Cpp2IlInjected.Address(RVA = "0x72ED010", Offset = "0x72EC210", VA = "0x1872ED010", Slot = "17")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400001D")]
	public event Action<KOEAFBADJNF, KOEAFBADJNF> LMBGJGLPGCL
	{
		[Cpp2IlInjected.Token(Token = "0x60001B7")]
		[Cpp2IlInjected.Address(RVA = "0x72E9ED0", Offset = "0x72E90D0", VA = "0x1872E9ED0", Slot = "20")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60001B8")]
		[Cpp2IlInjected.Address(RVA = "0x72ECF00", Offset = "0x72EC100", VA = "0x1872ECF00", Slot = "21")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400001E")]
	public event ELNJCAEPAAK BFOCPMIHFEE
	{
		[Cpp2IlInjected.Token(Token = "0x60001BB")]
		[Cpp2IlInjected.Address(RVA = "0x72ED1F0", Offset = "0x72EC3F0", VA = "0x1872ED1F0", Slot = "12")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60001BC")]
		[Cpp2IlInjected.Address(RVA = "0x72E91C0", Offset = "0x72E83C0", VA = "0x1872E91C0", Slot = "13")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400001F")]
	public event ELNJCAEPAAK CIHAGCLFOKL
	{
		[Cpp2IlInjected.Token(Token = "0x60001C1")]
		[Cpp2IlInjected.Address(RVA = "0x72E9530", Offset = "0x72E8730", VA = "0x1872E9530", Slot = "10")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60001C2")]
		[Cpp2IlInjected.Address(RVA = "0x72EB850", Offset = "0x72EAA50", VA = "0x1872EB850", Slot = "11")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000160")]
	[Cpp2IlInjected.Address(RVA = "0x72EE0F0", Offset = "0x72ED2F0", VA = "0x1872EE0F0")]
	public PMLAOCKCIDG(GameObject PLNJOBKLAEE, RigidbodyEx FLJJEMJNPGL, BPMCNPBDJCK CAKLHAFGFAN, [In] GNBAPJBBCHJ LJIEGDEDOHM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000161")]
	[Cpp2IlInjected.Address(RVA = "0x72EA160", Offset = "0x72E9360", VA = "0x1872EA160", Slot = "137")]
	protected virtual void EGKKCPDKFCD(BPMCNPBDJCK CAKLHAFGFAN, GNBAPJBBCHJ LJIEGDEDOHM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000162")]
	[Cpp2IlInjected.Address(RVA = "0x72E9D50", Offset = "0x72E8F50", VA = "0x1872E9D50", Slot = "138")]
	public virtual void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000163")]
	[Cpp2IlInjected.Address(RVA = "0x72E84C0", Offset = "0x72E76C0", VA = "0x1872E84C0", Slot = "92")]
	public void AHDMKGLGKBO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000164")]
	[Cpp2IlInjected.Address(RVA = "0x72E9420", Offset = "0x72E8620", VA = "0x1872E9420", Slot = "93")]
	public void MOBJCHLHFCJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000165")]
	[Cpp2IlInjected.Address(RVA = "0x72E87B0", Offset = "0x72E79B0", VA = "0x1872E87B0", Slot = "94")]
	public void APLMFGCHIGG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000166")]
	[Cpp2IlInjected.Address(RVA = "0x72EA010", Offset = "0x72E9210", VA = "0x1872EA010")]
	private void EEOMNLBNFKC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000170")]
	[Cpp2IlInjected.Address(RVA = "0x72E87D0", Offset = "0x72E79D0", VA = "0x1872E87D0", Slot = "30")]
	public EKBKMDGMIHO BAGNFAEOAPD(int KINMHNEMPOD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000173")]
	[Cpp2IlInjected.Address(RVA = "0x72ECE90", Offset = "0x72EC090", VA = "0x1872ECE90", Slot = "96")]
	public void MJEAPHGJJFH(EKBKMDGMIHO JECHHBGMFLN, bool BKKKGCNMPBE = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600018A")]
	[Cpp2IlInjected.Address(RVA = "0x72EC950", Offset = "0x72EBB50", VA = "0x1872EC950", Slot = "97")]
	public void LGCIIHGNAAA(object NIOIDOPDJKO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600018B")]
	[Cpp2IlInjected.Address(RVA = "0x72E8600", Offset = "0x72E7800", VA = "0x1872E8600", Slot = "98")]
	public void ANGLOPCCCFI(object NIOIDOPDJKO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600018C")]
	[Cpp2IlInjected.Address(RVA = "0x72ECD90", Offset = "0x72EBF90", VA = "0x1872ECD90", Slot = "99")]
	public Vector3 MFBCEHFOCAN(Vector3 NJMKNHLGFKE)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x600018D")]
	[Cpp2IlInjected.Address(RVA = "0x72ED540", Offset = "0x72EC740", VA = "0x1872ED540", Slot = "100")]
	public Vector3 NIKABBPFJNG(Vector3 PDMDPBKDBDN)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x600018E")]
	[Cpp2IlInjected.Address(RVA = "0x72E9420", Offset = "0x72E8620", VA = "0x1872E9420", Slot = "101")]
	public void CKMLCDAHKNE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600018F")]
	[Cpp2IlInjected.Address(RVA = "0x72ECBD0", Offset = "0x72EBDD0", VA = "0x1872ECBD0", Slot = "102")]
	public void LOGAJLHKHPP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000190")]
	[Cpp2IlInjected.Address(RVA = "0x72EB190", Offset = "0x72EA390", VA = "0x1872EB190", Slot = "103")]
	public void HGJBDOFNHOE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000191")]
	[Cpp2IlInjected.Address(RVA = "0x72E88B0", Offset = "0x72E7AB0", VA = "0x1872E88B0", Slot = "104")]
	public void BEHNGDKFALP(Vector3 JJGNONCAJKL, Vector3 HJANGHEDIGO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000192")]
	[Cpp2IlInjected.Address(RVA = "0x72E90D0", Offset = "0x72E82D0", VA = "0x1872E90D0", Slot = "105")]
	public void CCJHLODLJDC(Vector3 OBJNBNIHDNA, Vector3 CPBKNIAPNBD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000193")]
	[Cpp2IlInjected.Address(RVA = "0x72EBBA0", Offset = "0x72EADA0", VA = "0x1872EBBA0", Slot = "106")]
	public void IIAEJMEGJMB(Vector3 IANJJOPONOA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000194")]
	[Cpp2IlInjected.Address(RVA = "0x72E9470", Offset = "0x72E8670", VA = "0x1872E9470", Slot = "107")]
	public void CKOALKCLCCK(KNPMGCIOAIO GPBGOJOBPDD, Vector3 NBLKIPPEOAD, float PMAAKLFOBHF, float EEAHHPFKLHF = 8f, float BHCLILJBOCH = 1f)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000195")]
	[Cpp2IlInjected.Address(RVA = "0x72EDD50", Offset = "0x72ECF50", VA = "0x1872EDD50", Slot = "108")]
	public void PDHNHLCFFDB(JIOFAHGJLPH KDOGOEHPAMH, Vector3 KEIBLCIFAEK, float CNCMGOOCLHH = float.PositiveInfinity)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000196")]
	[Cpp2IlInjected.Address(RVA = "0x72ECCE0", Offset = "0x72EBEE0", VA = "0x1872ECCE0", Slot = "109")]
	[Obsolete("Deprecated. Still exists to support deprecated CV2 chips. Use ApplyAngularVelocityChange.")]
	public void MCPCHEDLNPF(JIOFAHGJLPH KDOGOEHPAMH, Vector3 MBMKLLFOFFL, float JIJBBEKPCIF = 7f, float NCMKACAPAEK = 1f)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000197")]
	[Cpp2IlInjected.Address(RVA = "0x72EDA00", Offset = "0x72ECC00", VA = "0x1872EDA00", Slot = "110")]
	public Vector3 OHEEAJNKOAD(Vector3 JECHHBGMFLN)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000198")]
	[Cpp2IlInjected.Address(RVA = "0x72EC3F0", Offset = "0x72EB5F0", VA = "0x1872EC3F0", Slot = "111")]
	public Vector3 KHHAOGLPELB(Vector3 JECHHBGMFLN)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000199")]
	[Cpp2IlInjected.Address(RVA = "0x72EC580", Offset = "0x72EB780", VA = "0x1872EC580", Slot = "112")]
	public void KJPJJLAMIPM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600019C")]
	[Cpp2IlInjected.Address(RVA = "0x72ED070", Offset = "0x72EC270", VA = "0x1872ED070", Slot = "113")]
	public void NBGCKNDMOHD(EKBKMDGMIHO HOJKEPPOHFG, object NIOIDOPDJKO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600019D")]
	[Cpp2IlInjected.Address(RVA = "0x72E97B0", Offset = "0x72E89B0", VA = "0x1872E97B0", Slot = "114")]
	public void DAPFLPGONMB(object NIOIDOPDJKO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001A8")]
	[Cpp2IlInjected.Address(RVA = "0x72E9BD0", Offset = "0x72E8DD0", VA = "0x1872E9BD0", Slot = "62")]
	public void DNGGNEFAOCO((Quaternion rot, Vector3 moments) PDCLDKLEPFH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001A9")]
	[Cpp2IlInjected.Address(RVA = "0x72EAAF0", Offset = "0x72E9CF0", VA = "0x1872EAAF0", Slot = "115")]
	public void FNJALHOCFNC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001AA")]
	[Cpp2IlInjected.Address(RVA = "0x72E9D00", Offset = "0x72E8F00", VA = "0x1872E9D00", Slot = "116")]
	public void DPGIAJJJGKG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001AB")]
	[Cpp2IlInjected.Address(RVA = "0x72EA630", Offset = "0x72E9830", VA = "0x1872EA630", Slot = "117")]
	public void ELEEEMKCGFD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001B4")]
	[Cpp2IlInjected.Address(RVA = "0x72EA7C0", Offset = "0x72E99C0", VA = "0x1872EA7C0", Slot = "118")]
	public bool EPPJDPEDBGL()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001B5")]
	[Cpp2IlInjected.Address(RVA = "0x72E8470", Offset = "0x72E7670", VA = "0x1872E8470", Slot = "95")]
	public void AGNPDGIKBIK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001B6")]
	[Cpp2IlInjected.Address(RVA = "0x72EDB00", Offset = "0x72ECD00", VA = "0x1872EDB00", Slot = "119")]
	public void OHGIIOIIMII()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001BE")]
	[Cpp2IlInjected.Address(RVA = "0x72E9E20", Offset = "0x72E9020", VA = "0x1872E9E20", Slot = "120")]
	public void EAGABFFPMMP(object NIOIDOPDJKO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001BF")]
	[Cpp2IlInjected.Address(RVA = "0x72ECC80", Offset = "0x72EBE80", VA = "0x1872ECC80", Slot = "121")]
	public void MCANPGGOMHC(object NIOIDOPDJKO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001C0")]
	[Cpp2IlInjected.Address(RVA = "0x72EC8E0", Offset = "0x72EBAE0", VA = "0x1872EC8E0", Slot = "122")]
	public void LFECLAJJHDN(object NIOIDOPDJKO, bool FOEAHOLLJJF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001D0")]
	[Cpp2IlInjected.Address(RVA = "0x72EB230", Offset = "0x72EA430", VA = "0x1872EB230", Slot = "123")]
	public void HKGHJNGHCDA(Vector3 FNKDCDLOGKB, Quaternion OMFBNHNKBBC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001D1")]
	[Cpp2IlInjected.Address(RVA = "0x72E8250", Offset = "0x72E7450", VA = "0x1872E8250", Slot = "124")]
	public void ADFECCEMEDC(Vector3 JHIBNFEPDFL, Quaternion NIDDNGGLBMM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001D2")]
	[Cpp2IlInjected.Address(RVA = "0x72EACB0", Offset = "0x72E9EB0", VA = "0x1872EACB0", Slot = "125")]
	public bool GELNJINMEIM(float LLLEKEFAJOE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001D7")]
	[Cpp2IlInjected.Address(RVA = "0x72EA920", Offset = "0x72E9B20", VA = "0x1872EA920", Slot = "126")]
	public void FCLHIJBEECJ(object NIOIDOPDJKO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001D8")]
	[Cpp2IlInjected.Address(RVA = "0x72ECFB0", Offset = "0x72EC1B0", VA = "0x1872ECFB0", Slot = "127")]
	public void MMOHJADHJJH(object NIOIDOPDJKO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001D9")]
	[Cpp2IlInjected.Address(RVA = "0x72ED720", Offset = "0x72EC920", VA = "0x1872ED720", Slot = "128")]
	public void NONEIJICMCC(object NIOIDOPDJKO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001DA")]
	[Cpp2IlInjected.Address(RVA = "0x72ED940", Offset = "0x72ECB40", VA = "0x1872ED940", Slot = "129")]
	public void OEAAGOFKENI(object NIOIDOPDJKO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001DB")]
	[Cpp2IlInjected.Address(RVA = "0x72ECAF0", Offset = "0x72EBCF0", VA = "0x1872ECAF0", Slot = "130")]
	public void LOAKBAKPCPM(Vector3 PLHFEDHICDP, ForceMode AGPFLDAGFIP = ForceMode.Force)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001DC")]
	[Cpp2IlInjected.Address(RVA = "0x72ED0E0", Offset = "0x72EC2E0", VA = "0x1872ED0E0", Slot = "131")]
	public void NDEHHCDMHHG(Vector3 PLHFEDHICDP, Vector3 FJFKFIAGEPM, ForceMode AGPFLDAGFIP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001DD")]
	[Cpp2IlInjected.Address(RVA = "0x72E9220", Offset = "0x72E8420", VA = "0x1872E9220", Slot = "132")]
	public void CFOFKMPAPNK(Vector3 NPKDLKCKHFJ, ForceMode AGPFLDAGFIP = ForceMode.Force)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001DE")]
	[Cpp2IlInjected.Address(RVA = "0x72E9AF0", Offset = "0x72E8CF0", VA = "0x1872E9AF0", Slot = "133")]
	public void DKOPGDKOGHM(Vector3 NPKDLKCKHFJ, ForceMode AGPFLDAGFIP = ForceMode.Force)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001E1")]
	[Cpp2IlInjected.Address(RVA = "0x72E9940", Offset = "0x72E8B40", VA = "0x1872E9940", Slot = "134")]
	public bool DCIJPILDPPB(Vector3 BHMBDKAILFL, [Out] RaycastHit MDGJKKLDFLO, float ELNHAHMEPIC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001E4")]
	[Cpp2IlInjected.Address(RVA = "0x72EE060", Offset = "0x72ED260", VA = "0x1872EE060", Slot = "135")]
	public void PPIFADPJHHC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001E5")]
	[Cpp2IlInjected.Address(RVA = "0x72EE0B0", Offset = "0x72ED2B0", VA = "0x1872EE0B0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001E6")]
	[Cpp2IlInjected.Address(RVA = "0x72EDC10", Offset = "0x72ECE10", VA = "0x1872EDC10")]
	private void ONPLDDLINPM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001E7")]
	[Cpp2IlInjected.Address(RVA = "0x72EBA30", Offset = "0x72EAC30", VA = "0x1872EBA30")]
	private void IBMMMCCDNHL(EKBKMDGMIHO MBOJNCFILKL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001E8")]
	[Cpp2IlInjected.Address(RVA = "0x72EBDA0", Offset = "0x72EAFA0", VA = "0x1872EBDA0")]
	private void INFJNJBEBAL(EKBKMDGMIHO MBOJNCFILKL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001E9")]
	[Cpp2IlInjected.Address(RVA = "0x72E9630", Offset = "0x72E8830", VA = "0x1872E9630")]
	private void COBEPPODNBE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001EA")]
	[Cpp2IlInjected.Address(RVA = "0x72EC5D0", Offset = "0x72EB7D0", VA = "0x1872EC5D0")]
	private void KODEEPBINMC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001EB")]
	[Cpp2IlInjected.Address(RVA = "0x72EA450", Offset = "0x72E9650", VA = "0x1872EA450")]
	private void EGMMMABAJGG(EKBKMDGMIHO OCEIODMHKJI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001EC")]
	[Cpp2IlInjected.Address(RVA = "0x72EAB40", Offset = "0x72E9D40", VA = "0x1872EAB40")]
	private void FPJGMCLHAPN(EKBKMDGMIHO MBOJNCFILKL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001ED")]
	[Cpp2IlInjected.Address(RVA = "0x72E96E0", Offset = "0x72E88E0", VA = "0x1872E96E0")]
	private void COPGKIPFBJO(EKBKMDGMIHO MBOJNCFILKL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001EE")]
	[Cpp2IlInjected.Address(RVA = "0x72E8660", Offset = "0x72E7860", VA = "0x1872E8660")]
	private void AOOILCPBAHH(PIMMPONFKHJ MBOJNCFILKL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001EF")]
	[Cpp2IlInjected.Address(RVA = "0x72E8BA0", Offset = "0x72E7DA0", VA = "0x1872E8BA0", Slot = "141")]
	protected virtual void BLAMHLMGJLE(PIMMPONFKHJ BINJLCOIDDF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001F0")]
	[Cpp2IlInjected.Address(RVA = "0x72EADD0", Offset = "0x72E9FD0", VA = "0x1872EADD0")]
	protected void GPBLDIKJFHM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001F1")]
	[Cpp2IlInjected.Address(RVA = "0x72EB430", Offset = "0x72EA630", VA = "0x1872EB430")]
	protected void HKHINNOECCG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001F2")]
	[Cpp2IlInjected.Address(RVA = "0x72E89A0", Offset = "0x72E7BA0", VA = "0x1872E89A0", Slot = "142")]
	protected virtual IDisposable BEJOBBCJGEM()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200001D")]
internal static class HKCGKFPCNMD
{
	[Cpp2IlInjected.Token(Token = "0x60001F3")]
	[Cpp2IlInjected.Address(RVA = "0x72DD990", Offset = "0x72DCB90", VA = "0x1872DD990")]
	public static EKBKMDGMIHO KILMCBMNPAG(this EKBKMDGMIHO BINJLCOIDDF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001F4")]
	[Cpp2IlInjected.Address(RVA = "0x72DDAD0", Offset = "0x72DCCD0", VA = "0x1872DDAD0")]
	public static bool PMKOBNHFJJG(this EKBKMDGMIHO BINJLCOIDDF, EKBKMDGMIHO BBPCODKDBDI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001F5")]
	[Cpp2IlInjected.Address(RVA = "0x72DD8A0", Offset = "0x72DCAA0", VA = "0x1872DD8A0")]
	public static bool EIAOMMPAFNH(this EKBKMDGMIHO BINJLCOIDDF, EKBKMDGMIHO BFKOELBMDDP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001F6")]
	[Cpp2IlInjected.Address(RVA = "0x72DD940", Offset = "0x72DCB40", VA = "0x1872DD940")]
	public static PIMMPONFKHJ FLKPMGJBJEK(this EKBKMDGMIHO JANAFGLBOCK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001F7")]
	[Cpp2IlInjected.Address(RVA = "0x72DDA50", Offset = "0x72DCC50", VA = "0x1872DDA50")]
	public static PMLAOCKCIDG OGMBMMAJACJ(this EKBKMDGMIHO JANAFGLBOCK)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200001E")]
public class ENDECDINJNM : DFCJPPCLEBM
{
	[Cpp2IlInjected.Token(Token = "0x60001F8")]
	[Cpp2IlInjected.Address(RVA = "0x72DC3B0", Offset = "0x72DB5B0", VA = "0x1872DC3B0", Slot = "19")]
	public EKBKMDGMIHO JLIEAMKBMKG(RigidbodyEx BINJLCOIDDF, GNBAPJBBCHJ LJIEGDEDOHM, BPMCNPBDJCK CAKLHAFGFAN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001F9")]
	[Cpp2IlInjected.Address(RVA = "0x8966C0", Offset = "0x8958C0", VA = "0x1808966C0", Slot = "4")]
	public JEMMFOIBFDF BCKGEGBPCDO(EKBKMDGMIHO JANAFGLBOCK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001FA")]
	[Cpp2IlInjected.Address(RVA = "0x8966C0", Offset = "0x8958C0", VA = "0x1808966C0", Slot = "5")]
	public MDPIGHOADEP HFGAKCHCKGG(EKBKMDGMIHO JANAFGLBOCK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001FB")]
	[Cpp2IlInjected.Address(RVA = "0x8966C0", Offset = "0x8958C0", VA = "0x1808966C0", Slot = "6")]
	public NDHKKDEMMPE DCNDKILDIIG(EKBKMDGMIHO JANAFGLBOCK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001FC")]
	[Cpp2IlInjected.Address(RVA = "0x8966C0", Offset = "0x8958C0", VA = "0x1808966C0", Slot = "7")]
	public PMPHEBCFCMC OGFOFBLFCOL(EKBKMDGMIHO JANAFGLBOCK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001FD")]
	[Cpp2IlInjected.Address(RVA = "0x8966C0", Offset = "0x8958C0", VA = "0x1808966C0", Slot = "8")]
	public OLEOCEJGBKB DOPLNLGNPNB(EKBKMDGMIHO JANAFGLBOCK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001FE")]
	[Cpp2IlInjected.Address(RVA = "0x8966C0", Offset = "0x8958C0", VA = "0x1808966C0", Slot = "9")]
	public HFEOBDFOGDH MAECOMNIBIE(EKBKMDGMIHO JANAFGLBOCK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001FF")]
	[Cpp2IlInjected.Address(RVA = "0x8966C0", Offset = "0x8958C0", VA = "0x1808966C0", Slot = "10")]
	public DBCKLEANKGI FFEAHGNDBJP(EKBKMDGMIHO JANAFGLBOCK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000200")]
	[Cpp2IlInjected.Address(RVA = "0x8966C0", Offset = "0x8958C0", VA = "0x1808966C0", Slot = "11")]
	public HINKFLFNMKF ALGPPECNGGH(EKBKMDGMIHO JANAFGLBOCK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000201")]
	[Cpp2IlInjected.Address(RVA = "0x8966C0", Offset = "0x8958C0", VA = "0x1808966C0", Slot = "12")]
	public BDJDNDHNEIC HENOKDLOCDK(EKBKMDGMIHO JANAFGLBOCK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000202")]
	[Cpp2IlInjected.Address(RVA = "0x8966C0", Offset = "0x8958C0", VA = "0x1808966C0", Slot = "13")]
	public PCLBNMCPDOG JMHOENGJNBM(EKBKMDGMIHO JANAFGLBOCK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000203")]
	[Cpp2IlInjected.Address(RVA = "0x8966C0", Offset = "0x8958C0", VA = "0x1808966C0")]
	public HIBMHPPLBHO GCJOEJHJKOC(EKBKMDGMIHO JANAFGLBOCK, [In] GNBAPJBBCHJ LJIEGDEDOHM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000204")]
	[Cpp2IlInjected.Address(RVA = "0x8966C0", Offset = "0x8958C0", VA = "0x1808966C0")]
	public KJELJIKPEIH OHNDOOOPDAG(EKBKMDGMIHO JANAFGLBOCK, [In] GNBAPJBBCHJ LJIEGDEDOHM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000205")]
	[Cpp2IlInjected.Address(RVA = "0x8966C0", Offset = "0x8958C0", VA = "0x1808966C0")]
	public DBGAJMEHHKE IAPMEFDKKEE(EKBKMDGMIHO JANAFGLBOCK, [In] GNBAPJBBCHJ LJIEGDEDOHM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000206")]
	[Cpp2IlInjected.Address(RVA = "0x8966C0", Offset = "0x8958C0", VA = "0x1808966C0")]
	public PMJMGDFBDGN BFMGEHHONML(EKBKMDGMIHO JANAFGLBOCK, [In] GNBAPJBBCHJ LJIEGDEDOHM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000207")]
	[Cpp2IlInjected.Address(RVA = "0x8966C0", Offset = "0x8958C0", VA = "0x1808966C0")]
	public BAKMCIPNAHA GLLJPBEKJLA(EKBKMDGMIHO JANAFGLBOCK, [In] GNBAPJBBCHJ LJIEGDEDOHM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000208")]
	[Cpp2IlInjected.Address(RVA = "0x89F8B0", Offset = "0x89EAB0", VA = "0x18089F8B0")]
	public ENDECDINJNM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000209")]
	[Cpp2IlInjected.Address(RVA = "0x8966C0", Offset = "0x8958C0", VA = "0x1808966C0", Slot = "14")]
	private HIBMHPPLBHO DNBLAPPFBOP(EKBKMDGMIHO JANAFGLBOCK, [In] GNBAPJBBCHJ LJIEGDEDOHM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600020A")]
	[Cpp2IlInjected.Address(RVA = "0x8966C0", Offset = "0x8958C0", VA = "0x1808966C0", Slot = "15")]
	private KJELJIKPEIH EBOBJHBGHAI(EKBKMDGMIHO JANAFGLBOCK, [In] GNBAPJBBCHJ LJIEGDEDOHM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600020B")]
	[Cpp2IlInjected.Address(RVA = "0x8966C0", Offset = "0x8958C0", VA = "0x1808966C0", Slot = "16")]
	private DBGAJMEHHKE PMIEFJCKEMM(EKBKMDGMIHO JANAFGLBOCK, [In] GNBAPJBBCHJ LJIEGDEDOHM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600020C")]
	[Cpp2IlInjected.Address(RVA = "0x8966C0", Offset = "0x8958C0", VA = "0x1808966C0", Slot = "17")]
	private PMJMGDFBDGN DOLDDMNBDGI(EKBKMDGMIHO JANAFGLBOCK, [In] GNBAPJBBCHJ LJIEGDEDOHM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600020D")]
	[Cpp2IlInjected.Address(RVA = "0x8966C0", Offset = "0x8958C0", VA = "0x1808966C0", Slot = "18")]
	private BAKMCIPNAHA IEEDJMHDLEB(EKBKMDGMIHO JANAFGLBOCK, [In] GNBAPJBBCHJ LJIEGDEDOHM)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200001F")]
[GPHKHOPHNGA(typeof(DFCJPPCLEBM), new string[] { })]
public class KLIOCBPNFLA : DFCJPPCLEBM, BMOBKDHOHJA
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400002C")]
	private readonly DFCJPPCLEBM BMMCKPNBMBC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400002D")]
	private readonly DFCJPPCLEBM OAGDDHBBBEH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400002E")]
	private BIMFLNCHPNC JFPADJJAHEN;

	[Cpp2IlInjected.Token(Token = "0x17000089")]
	private DFCJPPCLEBM BKMIMOHDIEK
	{
		[Cpp2IlInjected.Token(Token = "0x600020F")]
		[Cpp2IlInjected.Address(RVA = "0x72E1410", Offset = "0x72E0610", VA = "0x1872E1410")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600020E")]
	[Cpp2IlInjected.Address(RVA = "0x72E11A0", Offset = "0x72E03A0", VA = "0x1872E11A0", Slot = "20")]
	public void InitReferences(ANNJDLAFEIN DHGEHBCJDOE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000210")]
	[Cpp2IlInjected.Address(RVA = "0x72E0A70", Offset = "0x72DFC70", VA = "0x1872E0A70", Slot = "4")]
	public JEMMFOIBFDF BCKGEGBPCDO(EKBKMDGMIHO JANAFGLBOCK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000211")]
	[Cpp2IlInjected.Address(RVA = "0x72E1050", Offset = "0x72E0250", VA = "0x1872E1050", Slot = "5")]
	public MDPIGHOADEP HFGAKCHCKGG(EKBKMDGMIHO JANAFGLBOCK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000212")]
	[Cpp2IlInjected.Address(RVA = "0x72E0BC0", Offset = "0x72DFDC0", VA = "0x1872E0BC0", Slot = "6")]
	public NDHKKDEMMPE DCNDKILDIIG(EKBKMDGMIHO JANAFGLBOCK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000213")]
	[Cpp2IlInjected.Address(RVA = "0x72E1470", Offset = "0x72E0670", VA = "0x1872E1470", Slot = "7")]
	public PMPHEBCFCMC OGFOFBLFCOL(EKBKMDGMIHO JANAFGLBOCK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000214")]
	[Cpp2IlInjected.Address(RVA = "0x72E0D10", Offset = "0x72DFF10", VA = "0x1872E0D10", Slot = "8")]
	public OLEOCEJGBKB DOPLNLGNPNB(EKBKMDGMIHO JANAFGLBOCK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000215")]
	[Cpp2IlInjected.Address(RVA = "0x72E1370", Offset = "0x72E0570", VA = "0x1872E1370", Slot = "9")]
	public HFEOBDFOGDH MAECOMNIBIE(EKBKMDGMIHO JANAFGLBOCK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000216")]
	[Cpp2IlInjected.Address(RVA = "0x72E0E60", Offset = "0x72E0060", VA = "0x1872E0E60", Slot = "10")]
	public DBCKLEANKGI FFEAHGNDBJP(EKBKMDGMIHO JANAFGLBOCK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000217")]
	[Cpp2IlInjected.Address(RVA = "0x72E09D0", Offset = "0x72DFBD0", VA = "0x1872E09D0", Slot = "11")]
	public HINKFLFNMKF ALGPPECNGGH(EKBKMDGMIHO JANAFGLBOCK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000218")]
	[Cpp2IlInjected.Address(RVA = "0x72E0FB0", Offset = "0x72E01B0", VA = "0x1872E0FB0", Slot = "12")]
	public BDJDNDHNEIC HENOKDLOCDK(EKBKMDGMIHO JANAFGLBOCK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000219")]
	[Cpp2IlInjected.Address(RVA = "0x72E12D0", Offset = "0x72E04D0", VA = "0x1872E12D0", Slot = "13")]
	public PCLBNMCPDOG JMHOENGJNBM(EKBKMDGMIHO JANAFGLBOCK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600021A")]
	[Cpp2IlInjected.Address(RVA = "0x72E0C60", Offset = "0x72DFE60", VA = "0x1872E0C60")]
	public HIBMHPPLBHO GCJOEJHJKOC(EKBKMDGMIHO JANAFGLBOCK, [In] GNBAPJBBCHJ LJIEGDEDOHM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600021B")]
	[Cpp2IlInjected.Address(RVA = "0x72E0DB0", Offset = "0x72DFFB0", VA = "0x1872E0DB0")]
	public KJELJIKPEIH OHNDOOOPDAG(EKBKMDGMIHO JANAFGLBOCK, [In] GNBAPJBBCHJ LJIEGDEDOHM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600021C")]
	[Cpp2IlInjected.Address(RVA = "0x72E10F0", Offset = "0x72E02F0", VA = "0x1872E10F0")]
	public DBGAJMEHHKE IAPMEFDKKEE(EKBKMDGMIHO JANAFGLBOCK, [In] GNBAPJBBCHJ LJIEGDEDOHM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600021D")]
	[Cpp2IlInjected.Address(RVA = "0x72E0B10", Offset = "0x72DFD10", VA = "0x1872E0B10")]
	public PMJMGDFBDGN BFMGEHHONML(EKBKMDGMIHO JANAFGLBOCK, [In] GNBAPJBBCHJ LJIEGDEDOHM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600021E")]
	[Cpp2IlInjected.Address(RVA = "0x72E0F00", Offset = "0x72E0100", VA = "0x1872E0F00")]
	public BAKMCIPNAHA GLLJPBEKJLA(EKBKMDGMIHO JANAFGLBOCK, [In] GNBAPJBBCHJ LJIEGDEDOHM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600021F")]
	[Cpp2IlInjected.Address(RVA = "0x72E11F0", Offset = "0x72E03F0", VA = "0x1872E11F0", Slot = "19")]
	public EKBKMDGMIHO JLIEAMKBMKG(RigidbodyEx BINJLCOIDDF, GNBAPJBBCHJ LJIEGDEDOHM, BPMCNPBDJCK CAKLHAFGFAN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000220")]
	[Cpp2IlInjected.Address(RVA = "0x72E1510", Offset = "0x72E0710", VA = "0x1872E1510")]
	public KLIOCBPNFLA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000221")]
	[Cpp2IlInjected.Address(RVA = "0x72E0C60", Offset = "0x72DFE60", VA = "0x1872E0C60", Slot = "14")]
	private HIBMHPPLBHO DNBLAPPFBOP(EKBKMDGMIHO JANAFGLBOCK, [In] GNBAPJBBCHJ LJIEGDEDOHM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000222")]
	[Cpp2IlInjected.Address(RVA = "0x72E0DB0", Offset = "0x72DFFB0", VA = "0x1872E0DB0", Slot = "15")]
	private KJELJIKPEIH EBOBJHBGHAI(EKBKMDGMIHO JANAFGLBOCK, [In] GNBAPJBBCHJ LJIEGDEDOHM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000223")]
	[Cpp2IlInjected.Address(RVA = "0x72E10F0", Offset = "0x72E02F0", VA = "0x1872E10F0", Slot = "16")]
	private DBGAJMEHHKE PMIEFJCKEMM(EKBKMDGMIHO JANAFGLBOCK, [In] GNBAPJBBCHJ LJIEGDEDOHM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000224")]
	[Cpp2IlInjected.Address(RVA = "0x72E0B10", Offset = "0x72DFD10", VA = "0x1872E0B10", Slot = "17")]
	private PMJMGDFBDGN DOLDDMNBDGI(EKBKMDGMIHO JANAFGLBOCK, [In] GNBAPJBBCHJ LJIEGDEDOHM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000225")]
	[Cpp2IlInjected.Address(RVA = "0x72E0F00", Offset = "0x72E0100", VA = "0x1872E0F00", Slot = "18")]
	private BAKMCIPNAHA IEEDJMHDLEB(EKBKMDGMIHO JANAFGLBOCK, [In] GNBAPJBBCHJ LJIEGDEDOHM)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000020")]
public interface IGDGDFHOIMC : JEMMFOIBFDF, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x6000226")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void HBLNCAGJJIE(EKBKMDGMIHO BINJLCOIDDF);

	[Cpp2IlInjected.Token(Token = "0x6000227")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void CGONAHOMADI(EKBKMDGMIHO BINJLCOIDDF);

	[Cpp2IlInjected.Token(Token = "0x6000228")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void FMEGFPHIGNM(EKBKMDGMIHO OCEIODMHKJI);

	[Cpp2IlInjected.Token(Token = "0x6000229")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void LECNAEBGGPD(EKBKMDGMIHO OCEIODMHKJI);
}
[Cpp2IlInjected.Token(Token = "0x2000021")]
public interface KCLEEMHKEGK : NDHKKDEMMPE
{
	[Cpp2IlInjected.Token(Token = "0x1700008A")]
	LOGBCGONBOC<EKBKMDGMIHO> AEBAKAADNCI
	{
		[Cpp2IlInjected.Token(Token = "0x600022A")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700008B")]
	EKBKMDGMIHO FPKINABBJJP
	{
		[Cpp2IlInjected.Token(Token = "0x600022B")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000022")]
public interface EEMEOLNLMBE : PMJMGDFBDGN
{
	[Cpp2IlInjected.Token(Token = "0x600022C")]
	[Cpp2IlInjected.Address(Slot = "0")]
	(float, Vector3) KBCFCDHIEBB(Rigidbody FODMIBOCCIJ);
}
[Cpp2IlInjected.Token(Token = "0x2000023")]
public interface OGGDDHGBGLL : KJELJIKPEIH, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x1700008C")]
	PhotonView EMCMMAGCIHB
	{
		[Cpp2IlInjected.Token(Token = "0x600022D")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000024")]
internal sealed class PKJAEBBBELN : BDJDNDHNEIC
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400002F")]
	private readonly PMLAOCKCIDG BINJLCOIDDF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000030")]
	private CollisionDetectionMode GNECNLHAKNN;

	[Cpp2IlInjected.Token(Token = "0x1700008D")]
	private Rigidbody PAAIMMKMKDI
	{
		[Cpp2IlInjected.Token(Token = "0x600022E")]
		[Cpp2IlInjected.Address(RVA = "0x72E6B50", Offset = "0x72E5D50", VA = "0x1872E6B50")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700008E")]
	public CollisionDetectionMode MDOAMCGNLFH
	{
		[Cpp2IlInjected.Token(Token = "0x6000232")]
		[Cpp2IlInjected.Address(RVA = "0x72E8030", Offset = "0x72E7230", VA = "0x1872E8030", Slot = "4")]
		get
		{
			return default(CollisionDetectionMode);
		}
		[Cpp2IlInjected.Token(Token = "0x6000233")]
		[Cpp2IlInjected.Address(RVA = "0x72E8150", Offset = "0x72E7350", VA = "0x1872E8150", Slot = "5")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600022F")]
	[Cpp2IlInjected.Address(RVA = "0x72DB620", Offset = "0x72DA820", VA = "0x1872DB620")]
	public PKJAEBBBELN(EKBKMDGMIHO BINJLCOIDDF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000230")]
	[Cpp2IlInjected.Address(RVA = "0x72E7DC0", Offset = "0x72E6FC0", VA = "0x1872E7DC0", Slot = "6")]
	public void AHDMKGLGKBO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000231")]
	[Cpp2IlInjected.Address(RVA = "0x72E81D0", Offset = "0x72E73D0", VA = "0x1872E81D0", Slot = "9")]
	public void OFPIEMIENHN(Rigidbody LOMDGCGOAME)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000234")]
	[Cpp2IlInjected.Address(RVA = "0x72E81C0", Offset = "0x72E73C0", VA = "0x1872E81C0", Slot = "7")]
	public void OEINOICMECJ(bool ICNCKMMGEFA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000235")]
	[Cpp2IlInjected.Address(RVA = "0x72E8140", Offset = "0x72E7340", VA = "0x1872E8140", Slot = "8")]
	public void MADAMHCHODC(bool ICNCKMMGEFA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000236")]
	[Cpp2IlInjected.Address(RVA = "0x72E7ED0", Offset = "0x72E70D0", VA = "0x1872E7ED0", Slot = "10")]
	public bool DCIJPILDPPB(Vector3 BHMBDKAILFL, [Out] RaycastHit MDGJKKLDFLO, float ELNHAHMEPIC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000237")]
	[Cpp2IlInjected.Address(RVA = "0x72E7CA0", Offset = "0x72E6EA0", VA = "0x1872E7CA0")]
	private void AAGPMACGDHI(bool ICNCKMMGEFA)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000025")]
public sealed class OHFAFDMFDAA : HFEOBDFOGDH, IDisposable, ANHAMHJNODK
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000032")]
	private readonly PMLAOCKCIDG BINJLCOIDDF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000033")]
	private KFABMCIICMN DOLJKBOKLNN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000034")]
	private PGCEDDPBELO HDIOLJCJKIC;

	[Cpp2IlInjected.Token(Token = "0x1700008F")]
	public KFABMCIICMN DJHGPHELGJE
	{
		[Cpp2IlInjected.Token(Token = "0x600023A")]
		[Cpp2IlInjected.Address(RVA = "0x72E7920", Offset = "0x72E6B20", VA = "0x1872E7920", Slot = "6")]
		get
		{
			return default(KFABMCIICMN);
		}
		[Cpp2IlInjected.Token(Token = "0x600023B")]
		[Cpp2IlInjected.Address(RVA = "0x72E7A70", Offset = "0x72E6C70", VA = "0x1872E7A70", Slot = "7")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000090")]
	private Transform IDHLDKLAALK
	{
		[Cpp2IlInjected.Token(Token = "0x600023C")]
		[Cpp2IlInjected.Address(RVA = "0x72E7B40", Offset = "0x72E6D40", VA = "0x1872E7B40", Slot = "10")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000020")]
	public event Action<KOEAFBADJNF, KOEAFBADJNF> LMBGJGLPGCL
	{
		[Cpp2IlInjected.Token(Token = "0x6000238")]
		[Cpp2IlInjected.Address(RVA = "0x72E7870", Offset = "0x72E6A70", VA = "0x1872E7870", Slot = "4")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000239")]
		[Cpp2IlInjected.Address(RVA = "0x72E7B60", Offset = "0x72E6D60", VA = "0x1872E7B60", Slot = "5")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600023D")]
	[Cpp2IlInjected.Address(RVA = "0x72E7C10", Offset = "0x72E6E10", VA = "0x1872E7C10")]
	public OHFAFDMFDAA(EKBKMDGMIHO BINJLCOIDDF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600023E")]
	[Cpp2IlInjected.Address(RVA = "0x72E75B0", Offset = "0x72E67B0", VA = "0x1872E75B0", Slot = "8")]
	public void AHDMKGLGKBO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600023F")]
	[Cpp2IlInjected.Address(RVA = "0x72E7820", Offset = "0x72E6A20", VA = "0x1872E7820", Slot = "9")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000240")]
	[Cpp2IlInjected.Address(RVA = "0xC3FBF0", Offset = "0xC3EDF0", VA = "0x180C3FBF0", Slot = "11")]
	private void IGFOHNBGJNJ(KOEAFBADJNF KOFGFGGCFFA, KOEAFBADJNF KHEIGACICLJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000241")]
	[Cpp2IlInjected.Address(RVA = "0x8966B0", Offset = "0x8958B0", VA = "0x1808966B0", Slot = "12")]
	private void OOANICOPKEK(bool JAENBFHFAKF)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000026")]
public class MDEDPAHFKCD : DFCJPPCLEBM
{
	[Cpp2IlInjected.Token(Token = "0x6000242")]
	[Cpp2IlInjected.Address(RVA = "0x72E57C0", Offset = "0x72E49C0", VA = "0x1872E57C0", Slot = "4")]
	public JEMMFOIBFDF BCKGEGBPCDO(EKBKMDGMIHO JANAFGLBOCK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000243")]
	[Cpp2IlInjected.Address(RVA = "0x72E61D0", Offset = "0x72E53D0", VA = "0x1872E61D0", Slot = "5")]
	public MDPIGHOADEP HFGAKCHCKGG(EKBKMDGMIHO JANAFGLBOCK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000244")]
	[Cpp2IlInjected.Address(RVA = "0x72E5A40", Offset = "0x72E4C40", VA = "0x1872E5A40", Slot = "6")]
	public NDHKKDEMMPE DCNDKILDIIG(EKBKMDGMIHO JANAFGLBOCK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000245")]
	[Cpp2IlInjected.Address(RVA = "0x72E6710", Offset = "0x72E5910", VA = "0x1872E6710", Slot = "7")]
	public PMPHEBCFCMC OGFOFBLFCOL(EKBKMDGMIHO JANAFGLBOCK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000246")]
	[Cpp2IlInjected.Address(RVA = "0x72E5CB0", Offset = "0x72E4EB0", VA = "0x1872E5CB0", Slot = "8")]
	public OLEOCEJGBKB DOPLNLGNPNB(EKBKMDGMIHO JANAFGLBOCK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000247")]
	[Cpp2IlInjected.Address(RVA = "0x72E6640", Offset = "0x72E5840", VA = "0x1872E6640", Slot = "9")]
	public HFEOBDFOGDH MAECOMNIBIE(EKBKMDGMIHO JANAFGLBOCK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000248")]
	[Cpp2IlInjected.Address(RVA = "0x72E5F10", Offset = "0x72E5110", VA = "0x1872E5F10", Slot = "10")]
	public DBCKLEANKGI FFEAHGNDBJP(EKBKMDGMIHO JANAFGLBOCK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000249")]
	[Cpp2IlInjected.Address(RVA = "0x72E5700", Offset = "0x72E4900", VA = "0x1872E5700", Slot = "11")]
	public HINKFLFNMKF ALGPPECNGGH(EKBKMDGMIHO JANAFGLBOCK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600024A")]
	[Cpp2IlInjected.Address(RVA = "0x72E6110", Offset = "0x72E5310", VA = "0x1872E6110", Slot = "12")]
	public BDJDNDHNEIC HENOKDLOCDK(EKBKMDGMIHO JANAFGLBOCK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600024B")]
	[Cpp2IlInjected.Address(RVA = "0x72E6580", Offset = "0x72E5780", VA = "0x1872E6580", Slot = "13")]
	public PCLBNMCPDOG JMHOENGJNBM(EKBKMDGMIHO JANAFGLBOCK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600024C")]
	[Cpp2IlInjected.Address(RVA = "0x72E5B70", Offset = "0x72E4D70", VA = "0x1872E5B70")]
	public HIBMHPPLBHO GCJOEJHJKOC(EKBKMDGMIHO JANAFGLBOCK, [In] GNBAPJBBCHJ LJIEGDEDOHM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600024D")]
	[Cpp2IlInjected.Address(RVA = "0x72E5D80", Offset = "0x72E4F80", VA = "0x1872E5D80")]
	public KJELJIKPEIH OHNDOOOPDAG(EKBKMDGMIHO JANAFGLBOCK, [In] GNBAPJBBCHJ LJIEGDEDOHM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600024E")]
	[Cpp2IlInjected.Address(RVA = "0x72E6300", Offset = "0x72E5500", VA = "0x1872E6300")]
	public DBGAJMEHHKE IAPMEFDKKEE(EKBKMDGMIHO JANAFGLBOCK, [In] GNBAPJBBCHJ LJIEGDEDOHM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600024F")]
	[Cpp2IlInjected.Address(RVA = "0x72E58B0", Offset = "0x72E4AB0", VA = "0x1872E58B0")]
	public PMJMGDFBDGN BFMGEHHONML(EKBKMDGMIHO JANAFGLBOCK, [In] GNBAPJBBCHJ LJIEGDEDOHM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000250")]
	[Cpp2IlInjected.Address(RVA = "0x72E6030", Offset = "0x72E5230", VA = "0x1872E6030")]
	public BAKMCIPNAHA GLLJPBEKJLA(EKBKMDGMIHO JANAFGLBOCK, [In] GNBAPJBBCHJ LJIEGDEDOHM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000251")]
	[Cpp2IlInjected.Address(RVA = "0x72E6430", Offset = "0x72E5630", VA = "0x1872E6430", Slot = "19")]
	public EKBKMDGMIHO JLIEAMKBMKG(RigidbodyEx BINJLCOIDDF, GNBAPJBBCHJ LJIEGDEDOHM, BPMCNPBDJCK CAKLHAFGFAN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000252")]
	[Cpp2IlInjected.Address(RVA = "0x89F8B0", Offset = "0x89EAB0", VA = "0x18089F8B0")]
	public MDEDPAHFKCD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000253")]
	[Cpp2IlInjected.Address(RVA = "0x72E5B70", Offset = "0x72E4D70", VA = "0x1872E5B70", Slot = "14")]
	private HIBMHPPLBHO DNBLAPPFBOP(EKBKMDGMIHO JANAFGLBOCK, [In] GNBAPJBBCHJ LJIEGDEDOHM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000254")]
	[Cpp2IlInjected.Address(RVA = "0x72E5D80", Offset = "0x72E4F80", VA = "0x1872E5D80", Slot = "15")]
	private KJELJIKPEIH EBOBJHBGHAI(EKBKMDGMIHO JANAFGLBOCK, [In] GNBAPJBBCHJ LJIEGDEDOHM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000255")]
	[Cpp2IlInjected.Address(RVA = "0x72E6300", Offset = "0x72E5500", VA = "0x1872E6300", Slot = "16")]
	private DBGAJMEHHKE PMIEFJCKEMM(EKBKMDGMIHO JANAFGLBOCK, [In] GNBAPJBBCHJ LJIEGDEDOHM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000256")]
	[Cpp2IlInjected.Address(RVA = "0x72E58B0", Offset = "0x72E4AB0", VA = "0x1872E58B0", Slot = "17")]
	private PMJMGDFBDGN DOLDDMNBDGI(EKBKMDGMIHO JANAFGLBOCK, [In] GNBAPJBBCHJ LJIEGDEDOHM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000257")]
	[Cpp2IlInjected.Address(RVA = "0x72E6030", Offset = "0x72E5230", VA = "0x1872E6030", Slot = "18")]
	private BAKMCIPNAHA IEEDJMHDLEB(EKBKMDGMIHO JANAFGLBOCK, [In] GNBAPJBBCHJ LJIEGDEDOHM)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000027")]
internal sealed class MJMDINDAIBH : HINKFLFNMKF
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000035")]
	private readonly PMLAOCKCIDG BINJLCOIDDF;

	[Cpp2IlInjected.Token(Token = "0x17000091")]
	private Rigidbody PAAIMMKMKDI
	{
		[Cpp2IlInjected.Token(Token = "0x6000258")]
		[Cpp2IlInjected.Address(RVA = "0x72E6B50", Offset = "0x72E5D50", VA = "0x1872E6B50")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000092")]
	private bool GBBOHGPNMEI
	{
		[Cpp2IlInjected.Token(Token = "0x6000259")]
		[Cpp2IlInjected.Address(RVA = "0x72E7060", Offset = "0x72E6260", VA = "0x1872E7060")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000093")]
	private bool OMNFODDCIFN
	{
		[Cpp2IlInjected.Token(Token = "0x600025A")]
		[Cpp2IlInjected.Address(RVA = "0x72DA9F0", Offset = "0x72D9BF0", VA = "0x1872DA9F0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000094")]
	private EKBKMDGMIHO DHGIKLOJLBP
	{
		[Cpp2IlInjected.Token(Token = "0x600025B")]
		[Cpp2IlInjected.Address(RVA = "0x72E7490", Offset = "0x72E6690", VA = "0x1872E7490")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600025C")]
	[Cpp2IlInjected.Address(RVA = "0x72DB620", Offset = "0x72DA820", VA = "0x1872DB620")]
	public MJMDINDAIBH(EKBKMDGMIHO BINJLCOIDDF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600025D")]
	[Cpp2IlInjected.Address(RVA = "0x72E70B0", Offset = "0x72E62B0", VA = "0x1872E70B0", Slot = "4")]
	public void LOAKBAKPCPM(Vector3 PLHFEDHICDP, ForceMode AGPFLDAGFIP = ForceMode.Force)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600025E")]
	[Cpp2IlInjected.Address(RVA = "0x72E6E00", Offset = "0x72E6000", VA = "0x1872E6E00")]
	private void EOPOMABPPBE(Vector3 PLHFEDHICDP, ForceMode AGPFLDAGFIP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600025F")]
	[Cpp2IlInjected.Address(RVA = "0x72E7210", Offset = "0x72E6410", VA = "0x1872E7210", Slot = "5")]
	public void NDEHHCDMHHG(Vector3 PLHFEDHICDP, Vector3 FJFKFIAGEPM, ForceMode AGPFLDAGFIP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000260")]
	[Cpp2IlInjected.Address(RVA = "0x72E69F0", Offset = "0x72E5BF0", VA = "0x1872E69F0", Slot = "6")]
	public void CFOFKMPAPNK(Vector3 NPKDLKCKHFJ, ForceMode AGPFLDAGFIP = ForceMode.Force)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000261")]
	[Cpp2IlInjected.Address(RVA = "0x72E6790", Offset = "0x72E5990", VA = "0x1872E6790")]
	private void BDIJFFGJDIN(Vector3 NPKDLKCKHFJ, ForceMode AGPFLDAGFIP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000262")]
	[Cpp2IlInjected.Address(RVA = "0x72E6BA0", Offset = "0x72E5DA0", VA = "0x1872E6BA0", Slot = "7")]
	public void DKOPGDKOGHM(Vector3 NPKDLKCKHFJ, ForceMode AGPFLDAGFIP = ForceMode.Force)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000028")]
internal sealed class EEKGDONFOBF : PCLBNMCPDOG
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000036")]
	private readonly PMLAOCKCIDG BINJLCOIDDF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000037")]
	private bool KPHDEGALGEK;

	[Cpp2IlInjected.Token(Token = "0x17000095")]
	public bool JPGMDCDHJIB
	{
		[Cpp2IlInjected.Token(Token = "0x6000264")]
		[Cpp2IlInjected.Address(RVA = "0xB325B0", Offset = "0xB317B0", VA = "0x180B325B0", Slot = "4")]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000265")]
		[Cpp2IlInjected.Address(RVA = "0x72DB470", Offset = "0x72DA670", VA = "0x1872DB470", Slot = "5")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000263")]
	[Cpp2IlInjected.Address(RVA = "0x72DB620", Offset = "0x72DA820", VA = "0x1872DB620")]
	public EEKGDONFOBF(EKBKMDGMIHO BINJLCOIDDF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000266")]
	[Cpp2IlInjected.Address(RVA = "0x72DB5F0", Offset = "0x72DA7F0", VA = "0x1872DB5F0", Slot = "6")]
	public void OFPIEMIENHN(Rigidbody LOMDGCGOAME)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000267")]
	[Cpp2IlInjected.Address(RVA = "0x72DB580", Offset = "0x72DA780", VA = "0x1872DB580", Slot = "7")]
	public void NPPMBFABGCE(Rigidbody LOMDGCGOAME)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000029")]
internal sealed class JKEHHJLIPHD : IGDGDFHOIMC, JEMMFOIBFDF, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x4000041")]
	private readonly EKBKMDGMIHO BINJLCOIDDF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x4000042")]
	private readonly List<EKBKMDGMIHO> OOMBIMDKGFC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x4000043")]
	private EKBKMDGMIHO LPLEFLJFGNH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x4000044")]
	private EKBKMDGMIHO MBOJNCFILKL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
	[Cpp2IlInjected.Token(Token = "0x4000045")]
	private Transform ICEPNIPKGBD;

	[Cpp2IlInjected.Token(Token = "0x17000096")]
	private Transform HFFBGEFJFMD
	{
		[Cpp2IlInjected.Token(Token = "0x600027A")]
		[Cpp2IlInjected.Address(RVA = "0x72DF6A0", Offset = "0x72DE8A0", VA = "0x1872DF6A0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000097")]
	public EKBKMDGMIHO DHGIKLOJLBP
	{
		[Cpp2IlInjected.Token(Token = "0x600027D")]
		[Cpp2IlInjected.Address(RVA = "0x894380", Offset = "0x893580", VA = "0x180894380", Slot = "28")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600027E")]
		[Cpp2IlInjected.Address(RVA = "0x72DFB20", Offset = "0x72DED20", VA = "0x1872DFB20", Slot = "29")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000098")]
	public EKBKMDGMIHO IBCOIOCGJOD
	{
		[Cpp2IlInjected.Token(Token = "0x600027F")]
		[Cpp2IlInjected.Address(RVA = "0x8942B0", Offset = "0x8934B0", VA = "0x1808942B0", Slot = "27")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000099")]
	public IReadOnlyList<EKBKMDGMIHO> GNBKGLLFNBF
	{
		[Cpp2IlInjected.Token(Token = "0x6000280")]
		[Cpp2IlInjected.Address(RVA = "0x897130", Offset = "0x896330", VA = "0x180897130", Slot = "26")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000021")]
	public event ELNJCAEPAAK GGHLMHGGFGE
	{
		[Cpp2IlInjected.Token(Token = "0x6000268")]
		[Cpp2IlInjected.Address(RVA = "0x72DFE50", Offset = "0x72DF050", VA = "0x1872DFE50", Slot = "8")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000269")]
		[Cpp2IlInjected.Address(RVA = "0x72E05C0", Offset = "0x72DF7C0", VA = "0x1872E05C0", Slot = "9")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000022")]
	public event ELNJCAEPAAK OGLGAJAFIMK
	{
		[Cpp2IlInjected.Token(Token = "0x600026A")]
		[Cpp2IlInjected.Address(RVA = "0x72DF200", Offset = "0x72DE400", VA = "0x1872DF200", Slot = "10")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600026B")]
		[Cpp2IlInjected.Address(RVA = "0x72E0700", Offset = "0x72DF900", VA = "0x1872E0700", Slot = "11")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000023")]
	public event AHKGFFDODJI KNLCLGKPIIK
	{
		[Cpp2IlInjected.Token(Token = "0x600026C")]
		[Cpp2IlInjected.Address(RVA = "0x72DF010", Offset = "0x72DE210", VA = "0x1872DF010", Slot = "12")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600026D")]
		[Cpp2IlInjected.Address(RVA = "0x72DF8B0", Offset = "0x72DEAB0", VA = "0x1872DF8B0", Slot = "13")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000024")]
	public event Action HPAIGCNCEFI
	{
		[Cpp2IlInjected.Token(Token = "0x600026E")]
		[Cpp2IlInjected.Address(RVA = "0x72E0520", Offset = "0x72DF720", VA = "0x1872E0520", Slot = "14")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600026F")]
		[Cpp2IlInjected.Address(RVA = "0x72DFA80", Offset = "0x72DEC80", VA = "0x1872DFA80", Slot = "15")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000025")]
	public event Action GCOAMGMOHCO
	{
		[Cpp2IlInjected.Token(Token = "0x6000270")]
		[Cpp2IlInjected.Address(RVA = "0x72DF2A0", Offset = "0x72DE4A0", VA = "0x1872DF2A0", Slot = "16")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000271")]
		[Cpp2IlInjected.Address(RVA = "0x72DFB30", Offset = "0x72DED30", VA = "0x1872DFB30", Slot = "17")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000026")]
	public event Action<EKBKMDGMIHO> GNFAAANFCMA
	{
		[Cpp2IlInjected.Token(Token = "0x6000272")]
		[Cpp2IlInjected.Address(RVA = "0x72DED00", Offset = "0x72DDF00", VA = "0x1872DED00", Slot = "18")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000273")]
		[Cpp2IlInjected.Address(RVA = "0x72DF340", Offset = "0x72DE540", VA = "0x1872DF340", Slot = "19")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000027")]
	public event Action<EKBKMDGMIHO> BOEDKFNFFHJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000274")]
		[Cpp2IlInjected.Address(RVA = "0x72DFEF0", Offset = "0x72DF0F0", VA = "0x1872DFEF0", Slot = "20")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000275")]
		[Cpp2IlInjected.Address(RVA = "0x72DEB10", Offset = "0x72DDD10", VA = "0x1872DEB10", Slot = "21")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000028")]
	public event Action GDAGBEBMLOF
	{
		[Cpp2IlInjected.Token(Token = "0x6000276")]
		[Cpp2IlInjected.Address(RVA = "0x72DEED0", Offset = "0x72DE0D0", VA = "0x1872DEED0", Slot = "22")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000277")]
		[Cpp2IlInjected.Address(RVA = "0x72DF810", Offset = "0x72DEA10", VA = "0x1872DF810", Slot = "23")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000029")]
	public event Action<EKBKMDGMIHO> HCLEOPHCPKG
	{
		[Cpp2IlInjected.Token(Token = "0x6000278")]
		[Cpp2IlInjected.Address(RVA = "0x72E0860", Offset = "0x72DFA60", VA = "0x1872E0860", Slot = "24")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000279")]
		[Cpp2IlInjected.Address(RVA = "0x72DF150", Offset = "0x72DE350", VA = "0x1872DF150", Slot = "25")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600027B")]
	[Cpp2IlInjected.Address(RVA = "0x72E0910", Offset = "0x72DFB10", VA = "0x1872E0910")]
	public JKEHHJLIPHD(EKBKMDGMIHO BINJLCOIDDF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600027C")]
	[Cpp2IlInjected.Address(RVA = "0x72DF0B0", Offset = "0x72DE2B0", VA = "0x1872DF0B0", Slot = "31")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000281")]
	[Cpp2IlInjected.Address(RVA = "0x72DFFA0", Offset = "0x72DF1A0", VA = "0x1872DFFA0", Slot = "30")]
	public void MJEAPHGJJFH(EKBKMDGMIHO PNMFMJOGIKA, bool BKKKGCNMPBE = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000282")]
	[Cpp2IlInjected.Address(RVA = "0x72DF3F0", Offset = "0x72DE5F0", VA = "0x1872DF3F0", Slot = "6")]
	public void FMEGFPHIGNM(EKBKMDGMIHO OCEIODMHKJI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000283")]
	[Cpp2IlInjected.Address(RVA = "0x72DFBD0", Offset = "0x72DEDD0", VA = "0x1872DFBD0", Slot = "7")]
	public void LECNAEBGGPD(EKBKMDGMIHO OCEIODMHKJI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000284")]
	[Cpp2IlInjected.Address(RVA = "0x72DF700", Offset = "0x72DE900", VA = "0x1872DF700", Slot = "4")]
	public void HBLNCAGJJIE(EKBKMDGMIHO BINJLCOIDDF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000285")]
	[Cpp2IlInjected.Address(RVA = "0x72DEF70", Offset = "0x72DE170", VA = "0x1872DEF70", Slot = "5")]
	public void CGONAHOMADI(EKBKMDGMIHO BINJLCOIDDF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000286")]
	[Cpp2IlInjected.Address(RVA = "0x72E0660", Offset = "0x72DF860", VA = "0x1872E0660")]
	private void OBGPMPGNJOH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000287")]
	[Cpp2IlInjected.Address(RVA = "0x72DF660", Offset = "0x72DE860", VA = "0x1872DF660")]
	private void GCGECHNHFIN(EKBKMDGMIHO OCEIODMHKJI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000288")]
	[Cpp2IlInjected.Address(RVA = "0x72DEBC0", Offset = "0x72DDDC0", VA = "0x1872DEBC0")]
	private void ACOPKPIIFEF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000289")]
	[Cpp2IlInjected.Address(RVA = "0x72DF950", Offset = "0x72DEB50", VA = "0x1872DF950")]
	private void INMKBCKGMPF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600028A")]
	[Cpp2IlInjected.Address(RVA = "0x72DEDB0", Offset = "0x72DDFB0", VA = "0x1872DEDB0")]
	private void BDFPDPCIJFI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600028B")]
	[Cpp2IlInjected.Address(RVA = "0x72E07A0", Offset = "0x72DF9A0", VA = "0x1872E07A0")]
	[CompilerGenerated]
	private object PFHNBGNGLNJ()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200002A")]
internal static class HOHECLDBHIO
{
	[Cpp2IlInjected.Token(Token = "0x600028C")]
	[Cpp2IlInjected.Address(RVA = "0x72DDDB0", Offset = "0x72DCFB0", VA = "0x1872DDDB0")]
	public static IGDGDFHOIMC HLLKPLOFENB(this EKBKMDGMIHO JANAFGLBOCK)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200002B")]
internal sealed class HJLLKDHMIEF : KCLEEMHKEGK, NDHKKDEMMPE
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000046")]
	private readonly PMLAOCKCIDG BINJLCOIDDF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000047")]
	private readonly LOGBCGONBOC<EKBKMDGMIHO> IJFCMHILNON;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000048")]
	private bool DGAOBCLLMGC;

	[Cpp2IlInjected.Token(Token = "0x1700009A")]
	public LOGBCGONBOC<EKBKMDGMIHO> AEBAKAADNCI
	{
		[Cpp2IlInjected.Token(Token = "0x600028D")]
		[Cpp2IlInjected.Address(RVA = "0x8942A0", Offset = "0x8934A0", VA = "0x1808942A0", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700009B")]
	public Vector3 ANOAFLCLAAL
	{
		[Cpp2IlInjected.Token(Token = "0x600028E")]
		[Cpp2IlInjected.Address(RVA = "0x72DD030", Offset = "0x72DC230", VA = "0x1872DD030", Slot = "6")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700009C")]
	public Vector3 JPGDPFHLJDM
	{
		[Cpp2IlInjected.Token(Token = "0x600028F")]
		[Cpp2IlInjected.Address(RVA = "0x72DD060", Offset = "0x72DC260", VA = "0x1872DD060", Slot = "7")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700009D")]
	private Vector3 KBAKMFGPJLG
	{
		[Cpp2IlInjected.Token(Token = "0x6000293")]
		[Cpp2IlInjected.Address(RVA = "0x72DCB40", Offset = "0x72DBD40", VA = "0x1872DCB40")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700009E")]
	public EKBKMDGMIHO FPKINABBJJP
	{
		[Cpp2IlInjected.Token(Token = "0x6000294")]
		[Cpp2IlInjected.Address(RVA = "0x72DD6F0", Offset = "0x72DC8F0", VA = "0x1872DD6F0", Slot = "5")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000290")]
	[Cpp2IlInjected.Address(RVA = "0x72DD7A0", Offset = "0x72DC9A0", VA = "0x1872DD7A0")]
	public HJLLKDHMIEF(EKBKMDGMIHO BINJLCOIDDF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000291")]
	[Cpp2IlInjected.Address(RVA = "0x72DCC20", Offset = "0x72DBE20", VA = "0x1872DCC20", Slot = "8")]
	public void JAKFEKHNFBL(EKBKMDGMIHO MBOJNCFILKL, object NIOIDOPDJKO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000292")]
	[Cpp2IlInjected.Address(RVA = "0x72DCAE0", Offset = "0x72DBCE0", VA = "0x1872DCAE0", Slot = "9")]
	public void DCBPACFGFBN(object NIOIDOPDJKO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000295")]
	[Cpp2IlInjected.Address(RVA = "0x72DCC90", Offset = "0x72DBE90", VA = "0x1872DCC90")]
	private Vector3 JLHPMPIOEMI()
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000296")]
	[Cpp2IlInjected.Address(RVA = "0x72DD360", Offset = "0x72DC560", VA = "0x1872DD360")]
	private void OHGFEFMEMAD(EKBKMDGMIHO PAIMEGBPAND)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002C")]
internal static class FKLPIOALBCP
{
	[Cpp2IlInjected.Token(Token = "0x6000297")]
	[Cpp2IlInjected.Address(RVA = "0x72DC520", Offset = "0x72DB720", VA = "0x1872DC520")]
	public static KCLEEMHKEGK FNOACCDFCBG(this EKBKMDGMIHO JANAFGLBOCK)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200002D")]
internal sealed class AIJIPLDMKMP : EEMEOLNLMBE, PMJMGDFBDGN
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400004A")]
	private readonly PMLAOCKCIDG BINJLCOIDDF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400004B")]
	private readonly OverridableVector3 FNHHOACHJIN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400004C")]
	private readonly OverridableVector3 CLBPEAHNAFM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x400004D")]
	private float NIMDOJLFMKJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x44")]
	[Cpp2IlInjected.Token(Token = "0x400004E")]
	private float PFGNLPDCNIN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x400004F")]
	private Vector3 FFLPBIEPJND;

	[Cpp2IlInjected.FieldOffset(Offset = "0x54")]
	[Cpp2IlInjected.Token(Token = "0x4000050")]
	private Vector3? CIPKLJBJOIP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x64")]
	[Cpp2IlInjected.Token(Token = "0x4000051")]
	private Quaternion? PGDHOLILEBF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
	[Cpp2IlInjected.Token(Token = "0x4000052")]
	private bool BIIBIGDAFNO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x79")]
	[Cpp2IlInjected.Token(Token = "0x4000053")]
	private bool EMFHHHOEONI;

	[Cpp2IlInjected.Token(Token = "0x1700009F")]
	public Vector3 LFJGGINBIIP
	{
		[Cpp2IlInjected.Token(Token = "0x600029A")]
		[Cpp2IlInjected.Address(RVA = "0x10347B0", Offset = "0x10339B0", VA = "0x1810347B0", Slot = "7")]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x600029B")]
		[Cpp2IlInjected.Address(RVA = "0x72D8930", Offset = "0x72D7B30", VA = "0x1872D8930", Slot = "8")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A0")]
	public Vector3 GHHLLBKOPON
	{
		[Cpp2IlInjected.Token(Token = "0x600029C")]
		[Cpp2IlInjected.Address(RVA = "0x72D8550", Offset = "0x72D7750", VA = "0x1872D8550", Slot = "9")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A1")]
	public float EKFBJIHOEDI
	{
		[Cpp2IlInjected.Token(Token = "0x600029D")]
		[Cpp2IlInjected.Address(RVA = "0xB325D0", Offset = "0xB317D0", VA = "0x180B325D0", Slot = "10")]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x600029E")]
		[Cpp2IlInjected.Address(RVA = "0x72DA070", Offset = "0x72D9270", VA = "0x1872DA070")]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A2")]
	public float HACCOKMICKH
	{
		[Cpp2IlInjected.Token(Token = "0x600029F")]
		[Cpp2IlInjected.Address(RVA = "0xB325C0", Offset = "0xB317C0", VA = "0x180B325C0", Slot = "11")]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x60002A0")]
		[Cpp2IlInjected.Address(RVA = "0x72D89E0", Offset = "0x72D7BE0", VA = "0x1872D89E0", Slot = "12")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A3")]
	public Vector3 ONHKOHEONIO
	{
		[Cpp2IlInjected.Token(Token = "0x60002A1")]
		[Cpp2IlInjected.Address(RVA = "0x72D8A90", Offset = "0x72D7C90", VA = "0x1872D8A90", Slot = "13")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A4")]
	public Quaternion MPNEHPGOGNK
	{
		[Cpp2IlInjected.Token(Token = "0x60002A2")]
		[Cpp2IlInjected.Address(RVA = "0x72D8140", Offset = "0x72D7340", VA = "0x1872D8140", Slot = "14")]
		get
		{
			return default(Quaternion);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A5")]
	private Rigidbody PAAIMMKMKDI
	{
		[Cpp2IlInjected.Token(Token = "0x60002AA")]
		[Cpp2IlInjected.Address(RVA = "0x72D7DE0", Offset = "0x72D6FE0", VA = "0x1872D7DE0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400002A")]
	public event ELNJCAEPAAK FPCNKPDBGGF
	{
		[Cpp2IlInjected.Token(Token = "0x6000298")]
		[Cpp2IlInjected.Address(RVA = "0x72D87F0", Offset = "0x72D79F0", VA = "0x1872D87F0", Slot = "5")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000299")]
		[Cpp2IlInjected.Address(RVA = "0x72D8890", Offset = "0x72D7A90", VA = "0x1872D8890", Slot = "6")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60002A3")]
	[Cpp2IlInjected.Address(RVA = "0x72DA600", Offset = "0x72D9800", VA = "0x1872DA600")]
	public AIJIPLDMKMP(EKBKMDGMIHO BINJLCOIDDF, [In] GNBAPJBBCHJ LJIEGDEDOHM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002A4")]
	[Cpp2IlInjected.Address(RVA = "0x72D8640", Offset = "0x72D7840", VA = "0x1872D8640", Slot = "17")]
	public void FNJALHOCFNC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002A5")]
	[Cpp2IlInjected.Address(RVA = "0x72D8060", Offset = "0x72D7260", VA = "0x1872D8060", Slot = "16")]
	public void DPGIAJJJGKG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002A6")]
	[Cpp2IlInjected.Address(RVA = "0x72D9F90", Offset = "0x72D9190", VA = "0x1872D9F90", Slot = "19")]
	public void OFPIEMIENHN(Rigidbody LOMDGCGOAME)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002A7")]
	[Cpp2IlInjected.Address(RVA = "0x72D9DB0", Offset = "0x72D8FB0", VA = "0x1872D9DB0", Slot = "20")]
	public void NPPMBFABGCE(Rigidbody LOMDGCGOAME)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002A8")]
	[Cpp2IlInjected.Address(RVA = "0x72D82C0", Offset = "0x72D74C0", VA = "0x1872D82C0", Slot = "18")]
	public void ELEEEMKCGFD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002A9")]
	[Cpp2IlInjected.Address(RVA = "0x72DA180", Offset = "0x72D9380", VA = "0x1872DA180", Slot = "21")]
	public void PPIFADPJHHC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002AB")]
	[Cpp2IlInjected.Address(RVA = "0x72D8930", Offset = "0x72D7B30", VA = "0x1872D8930")]
	private void HKBJGIPBAMG(Vector3 JECHHBGMFLN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002AC")]
	[Cpp2IlInjected.Address(RVA = "0x72D8460", Offset = "0x72D7660", VA = "0x1872D8460")]
	[Obsolete("This method is dangerous - the unity rigidbody is updated in a deferred manner and this world position may be stale")]
	private Vector3 FHCFLKKMPAN()
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x60002AD")]
	[Cpp2IlInjected.Address(RVA = "0x72DA070", Offset = "0x72D9270", VA = "0x1872DA070")]
	private void PJELHMPFAAA(float JECHHBGMFLN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002AE")]
	[Cpp2IlInjected.Address(RVA = "0x72D89E0", Offset = "0x72D7BE0", VA = "0x1872D89E0")]
	private void IKDHICIDNOF(float JECHHBGMFLN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002AF")]
	[Cpp2IlInjected.Address(RVA = "0x72D9C10", Offset = "0x72D8E10", VA = "0x1872D9C10")]
	private Vector3 NEJGEGKOAFK()
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x60002B0")]
	[Cpp2IlInjected.Address(RVA = "0x72D7E30", Offset = "0x72D7030", VA = "0x1872D7E30", Slot = "15")]
	public void DNGGNEFAOCO((Quaternion rot, Vector3 moments) PDCLDKLEPFH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002B1")]
	[Cpp2IlInjected.Address(RVA = "0x72D9A90", Offset = "0x72D8C90", VA = "0x1872D9A90")]
	private Quaternion KIBICMFMHMF()
	{
		return default(Quaternion);
	}

	[Cpp2IlInjected.Token(Token = "0x60002B2")]
	[Cpp2IlInjected.Address(RVA = "0x72D99C0", Offset = "0x72D8BC0", VA = "0x1872D99C0")]
	public void KBCFCDHIEBB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002B3")]
	[Cpp2IlInjected.Address(RVA = "0x72D8C20", Offset = "0x72D7E20", VA = "0x1872D8C20", Slot = "4")]
	public (float, Vector3) KBCFCDHIEBB(Rigidbody FODMIBOCCIJ)
	{
		return default((float, Vector3));
	}
}
[Cpp2IlInjected.Token(Token = "0x200002E")]
internal static class NJAKIANONAP
{
	[Cpp2IlInjected.Token(Token = "0x60002B4")]
	[Cpp2IlInjected.Address(RVA = "0x72E74F0", Offset = "0x72E66F0", VA = "0x1872E74F0")]
	public static EEMEOLNLMBE MKDBNDHFCAO(this EKBKMDGMIHO JANAFGLBOCK)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200002F")]
internal sealed class LBFKNFFPDBN : DBGAJMEHHKE
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000054")]
	private readonly PMLAOCKCIDG BINJLCOIDDF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000055")]
	private readonly ANFGKOFMNEN GKCCDCONIIB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000056")]
	private readonly FNGCGGCLILE NAMFNAAIKIO;

	[Cpp2IlInjected.Token(Token = "0x170000A6")]
	public bool JOOBBOIJBBA
	{
		[Cpp2IlInjected.Token(Token = "0x60002B5")]
		[Cpp2IlInjected.Address(RVA = "0x11D2160", Offset = "0x11D1360", VA = "0x1811D2160", Slot = "10")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A7")]
	public FNGCGGCLILE NEBHOAGDNLB
	{
		[Cpp2IlInjected.Token(Token = "0x60002B6")]
		[Cpp2IlInjected.Address(RVA = "0x8FBD20", Offset = "0x8FAF20", VA = "0x1808FBD20", Slot = "11")]
		get
		{
			return default(FNGCGGCLILE);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60002B7")]
	[Cpp2IlInjected.Address(RVA = "0x72E1BD0", Offset = "0x72E0DD0", VA = "0x1872E1BD0")]
	public LBFKNFFPDBN(EKBKMDGMIHO BINJLCOIDDF, [In] GNBAPJBBCHJ LJIEGDEDOHM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002B8")]
	[Cpp2IlInjected.Address(RVA = "0x72E1600", Offset = "0x72E0800", VA = "0x1872E1600", Slot = "4")]
	public void AHDMKGLGKBO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002B9")]
	[Cpp2IlInjected.Address(RVA = "0x72E18F0", Offset = "0x72E0AF0", VA = "0x1872E18F0")]
	private bool IPNHHFFIKPC()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002BA")]
	[Cpp2IlInjected.Address(RVA = "0x72E1880", Offset = "0x72E0A80", VA = "0x1872E1880", Slot = "5")]
	public void DAGKFMFGFML(object NIOIDOPDJKO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002BB")]
	[Cpp2IlInjected.Address(RVA = "0x72E16D0", Offset = "0x72E08D0", VA = "0x1872E16D0", Slot = "6")]
	public void BNPDPMBOHMM(object NIOIDOPDJKO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002BC")]
	[Cpp2IlInjected.Address(RVA = "0x72E1990", Offset = "0x72E0B90", VA = "0x1872E1990", Slot = "9")]
	public void OCCPGPEMPIC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002BD")]
	[Cpp2IlInjected.Address(RVA = "0x72E1AC0", Offset = "0x72E0CC0", VA = "0x1872E1AC0")]
	private void OJDNLOONHMD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002BE")]
	[Cpp2IlInjected.Address(RVA = "0x72E1700", Offset = "0x72E0900", VA = "0x1872E1700")]
	private void CMFNEHPNBLM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002BF")]
	[Cpp2IlInjected.Address(RVA = "0x72E15C0", Offset = "0x72E07C0", VA = "0x1872E15C0", Slot = "8")]
	public void ABNFBLFDADD(EKBKMDGMIHO BINJLCOIDDF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002C0")]
	[Cpp2IlInjected.Address(RVA = "0x72E18B0", Offset = "0x72E0AB0", VA = "0x1872E18B0", Slot = "7")]
	public void DAKOKGEHGMK(EKBKMDGMIHO BINJLCOIDDF)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000030")]
internal sealed class GLMLKFBIMDC : DBCKLEANKGI
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000058")]
	private readonly PMLAOCKCIDG BINJLCOIDDF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000059")]
	private readonly ANFGKOFMNEN KHNECKGLICD;

	[Cpp2IlInjected.Token(Token = "0x170000A8")]
	public bool GBBOHGPNMEI
	{
		[Cpp2IlInjected.Token(Token = "0x60002C3")]
		[Cpp2IlInjected.Address(RVA = "0x72DC6D0", Offset = "0x72DB8D0", VA = "0x1872DC6D0", Slot = "6")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400002B")]
	public event ELNJCAEPAAK BFOCPMIHFEE
	{
		[Cpp2IlInjected.Token(Token = "0x60002C1")]
		[Cpp2IlInjected.Address(RVA = "0x72DC8A0", Offset = "0x72DBAA0", VA = "0x1872DC8A0", Slot = "4")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60002C2")]
		[Cpp2IlInjected.Address(RVA = "0x72DC5E0", Offset = "0x72DB7E0", VA = "0x1872DC5E0", Slot = "5")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60002C4")]
	[Cpp2IlInjected.Address(RVA = "0x72DC9F0", Offset = "0x72DBBF0", VA = "0x1872DC9F0")]
	public GLMLKFBIMDC(EKBKMDGMIHO BINJLCOIDDF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002C5")]
	[Cpp2IlInjected.Address(RVA = "0x72DC680", Offset = "0x72DB880", VA = "0x1872DC680", Slot = "7")]
	public void EAGABFFPMMP(object NIOIDOPDJKO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002C6")]
	[Cpp2IlInjected.Address(RVA = "0x72DC890", Offset = "0x72DBA90", VA = "0x1872DC890", Slot = "8")]
	public void MCANPGGOMHC(object NIOIDOPDJKO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002C7")]
	[Cpp2IlInjected.Address(RVA = "0x72DC780", Offset = "0x72DB980", VA = "0x1872DC780", Slot = "9")]
	public void LFECLAJJHDN(object NIOIDOPDJKO, bool FOEAHOLLJJF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002C8")]
	[Cpp2IlInjected.Address(RVA = "0x72DC690", Offset = "0x72DB890", VA = "0x1872DC690", Slot = "12")]
	public void FCIACDNJILD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002C9")]
	[Cpp2IlInjected.Address(RVA = "0x72DC970", Offset = "0x72DBB70", VA = "0x1872DC970", Slot = "10")]
	public void OFPIEMIENHN(Rigidbody ABNMHEDMNIJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002CA")]
	[Cpp2IlInjected.Address(RVA = "0x72DC940", Offset = "0x72DBB40", VA = "0x1872DC940", Slot = "11")]
	public void NPPMBFABGCE(Rigidbody LOMDGCGOAME)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000031")]
internal sealed class ELPDAJAMHOD : OGGDDHGBGLL, KJELJIKPEIH, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400005B")]
	private readonly PMLAOCKCIDG BINJLCOIDDF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400005C")]
	private PhotonView DNMKFBHAOFO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400005D")]
	private bool ILBALKFDKHP;

	[Cpp2IlInjected.Token(Token = "0x170000A9")]
	public PhotonView EMCMMAGCIHB
	{
		[Cpp2IlInjected.Token(Token = "0x60002CD")]
		[Cpp2IlInjected.Address(RVA = "0x897B70", Offset = "0x896D70", VA = "0x180897B70", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000AA")]
	public bool BEFHKFOFCJO
	{
		[Cpp2IlInjected.Token(Token = "0x60002CE")]
		[Cpp2IlInjected.Address(RVA = "0x72DBFC0", Offset = "0x72DB1C0", VA = "0x1872DBFC0", Slot = "7")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000AB")]
	public bool IFGEEMNBFMB
	{
		[Cpp2IlInjected.Token(Token = "0x60002CF")]
		[Cpp2IlInjected.Address(RVA = "0x931B30", Offset = "0x930D30", VA = "0x180931B30", Slot = "8")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400002C")]
	public event ELNJCAEPAAK NPPBKJKFFCC
	{
		[Cpp2IlInjected.Token(Token = "0x60002CB")]
		[Cpp2IlInjected.Address(RVA = "0x72DBE80", Offset = "0x72DB080", VA = "0x1872DBE80", Slot = "5")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60002CC")]
		[Cpp2IlInjected.Address(RVA = "0x72DBF20", Offset = "0x72DB120", VA = "0x1872DBF20", Slot = "6")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60002D0")]
	[Cpp2IlInjected.Address(RVA = "0x72DC250", Offset = "0x72DB450", VA = "0x1872DC250")]
	public ELPDAJAMHOD(EKBKMDGMIHO BINJLCOIDDF, [In] GNBAPJBBCHJ LJIEGDEDOHM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002D1")]
	[Cpp2IlInjected.Address(RVA = "0x72DB6B0", Offset = "0x72DA8B0", VA = "0x1872DB6B0", Slot = "9")]
	public void AHDMKGLGKBO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002D2")]
	[Cpp2IlInjected.Address(RVA = "0x72DBAC0", Offset = "0x72DACC0", VA = "0x1872DBAC0", Slot = "12")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002D3")]
	[Cpp2IlInjected.Address(RVA = "0x72DBD10", Offset = "0x72DAF10", VA = "0x1872DBD10", Slot = "10")]
	public void FPJGMCLHAPN(EKBKMDGMIHO MBOJNCFILKL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002D4")]
	[Cpp2IlInjected.Address(RVA = "0x72DB7E0", Offset = "0x72DA9E0", VA = "0x1872DB7E0", Slot = "11")]
	public void COPGKIPFBJO(EKBKMDGMIHO MBOJNCFILKL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002D5")]
	[Cpp2IlInjected.Address(RVA = "0x72DB950", Offset = "0x72DAB50", VA = "0x1872DB950")]
	private void DCPMAEJOMLC(PhotonView CBHLEBMFDKG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002D6")]
	[Cpp2IlInjected.Address(RVA = "0x72DBBC0", Offset = "0x72DADC0", VA = "0x1872DBBC0")]
	private void FFPEJIFPFPF(PIMMPONFKHJ ODMFCNNODEP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002D7")]
	[Cpp2IlInjected.Address(RVA = "0x72DBFE0", Offset = "0x72DB1E0", VA = "0x1872DBFE0")]
	private void NLABOIOGBDB(PhotonView NLJPHPIBCIB)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000032")]
internal static class BCPNMBAHKKC
{
	[Cpp2IlInjected.Token(Token = "0x60002D8")]
	[Cpp2IlInjected.Address(RVA = "0x72DB070", Offset = "0x72DA270", VA = "0x1872DB070")]
	public static OGGDDHGBGLL GBGJAJLAJCC(this EKBKMDGMIHO JANAFGLBOCK)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000033")]
internal sealed class HLNIEPMLMAC : BAKMCIPNAHA
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400005E")]
	private readonly PMLAOCKCIDG BINJLCOIDDF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400005F")]
	private RigidbodyConstraints POEAJPPIHCP;

	[Cpp2IlInjected.Token(Token = "0x170000AC")]
	public bool HCCJIIKCKAD
	{
		[Cpp2IlInjected.Token(Token = "0x60002D9")]
		[Cpp2IlInjected.Address(RVA = "0xA409C0", Offset = "0xA3FBC0", VA = "0x180A409C0", Slot = "4")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x60002DA")]
		[Cpp2IlInjected.Address(RVA = "0x4807950", Offset = "0x4806B50", VA = "0x184807950", Slot = "5")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000AD")]
	public bool DMCAAMCDFDK
	{
		[Cpp2IlInjected.Token(Token = "0x60002DB")]
		[Cpp2IlInjected.Address(RVA = "0xB32570", Offset = "0xB31770", VA = "0x180B32570", Slot = "6")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x60002DC")]
		[Cpp2IlInjected.Address(RVA = "0x4807940", Offset = "0x4806B40", VA = "0x184807940")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000AE")]
	public RigidbodyConstraints ONMDJJAOKEN
	{
		[Cpp2IlInjected.Token(Token = "0x60002DD")]
		[Cpp2IlInjected.Address(RVA = "0x89A5B0", Offset = "0x8997B0", VA = "0x18089A5B0", Slot = "7")]
		get
		{
			return default(RigidbodyConstraints);
		}
		[Cpp2IlInjected.Token(Token = "0x60002DE")]
		[Cpp2IlInjected.Address(RVA = "0x72DDB70", Offset = "0x72DCD70", VA = "0x1872DDB70", Slot = "8")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60002DF")]
	[Cpp2IlInjected.Address(RVA = "0x72DDD00", Offset = "0x72DCF00", VA = "0x1872DDD00")]
	public HLNIEPMLMAC(EKBKMDGMIHO BINJLCOIDDF, [In] GNBAPJBBCHJ LJIEGDEDOHM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002E0")]
	[Cpp2IlInjected.Address(RVA = "0x72DDCD0", Offset = "0x72DCED0", VA = "0x1872DDCD0", Slot = "9")]
	public void OFPIEMIENHN(Rigidbody LOMDGCGOAME)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002E1")]
	[Cpp2IlInjected.Address(RVA = "0x72DDCA0", Offset = "0x72DCEA0", VA = "0x1872DDCA0", Slot = "10")]
	public void NPPMBFABGCE(Rigidbody LOMDGCGOAME)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000034")]
internal sealed class DKNKJHLMDEE : PMPHEBCFCMC
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000062")]
	private readonly EKBKMDGMIHO BINJLCOIDDF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000063")]
	private float LLPNDJIAONK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
	[Cpp2IlInjected.Token(Token = "0x4000064")]
	private float CJBHGBCPLAB;

	[Cpp2IlInjected.Token(Token = "0x170000AF")]
	public float GLADHIFEMKF
	{
		[Cpp2IlInjected.Token(Token = "0x60002E3")]
		[Cpp2IlInjected.Address(RVA = "0xA0F670", Offset = "0xA0E870", VA = "0x180A0F670", Slot = "4")]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x60002E4")]
		[Cpp2IlInjected.Address(RVA = "0x72DB1A0", Offset = "0x72DA3A0", VA = "0x1872DB1A0", Slot = "5")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B0")]
	public float NKNCHAACCBB
	{
		[Cpp2IlInjected.Token(Token = "0x60002E5")]
		[Cpp2IlInjected.Address(RVA = "0xB6EBF0", Offset = "0xB6DDF0", VA = "0x180B6EBF0", Slot = "6")]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x60002E6")]
		[Cpp2IlInjected.Address(RVA = "0x72DB270", Offset = "0x72DA470", VA = "0x1872DB270", Slot = "7")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60002E2")]
	[Cpp2IlInjected.Address(RVA = "0x72DB430", Offset = "0x72DA630", VA = "0x1872DB430")]
	public DKNKJHLMDEE(EKBKMDGMIHO BINJLCOIDDF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002E7")]
	[Cpp2IlInjected.Address(RVA = "0x72DB3E0", Offset = "0x72DA5E0", VA = "0x1872DB3E0", Slot = "8")]
	public void OFPIEMIENHN(Rigidbody LOMDGCGOAME)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002E8")]
	[Cpp2IlInjected.Address(RVA = "0x72DB340", Offset = "0x72DA540", VA = "0x1872DB340", Slot = "9")]
	public void NPPMBFABGCE(Rigidbody LOMDGCGOAME)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000035")]
internal sealed class IPNGINBGNCD : OLEOCEJGBKB
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000066")]
	private readonly PMLAOCKCIDG BINJLCOIDDF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000067")]
	private bool JDLEIHADFNO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x21")]
	[Cpp2IlInjected.Token(Token = "0x4000068")]
	private bool LHNOKHEJGIB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
	[Cpp2IlInjected.Token(Token = "0x4000069")]
	private int BPIBPHIBDAJ;

	[Cpp2IlInjected.Token(Token = "0x170000B1")]
	private Rigidbody PAAIMMKMKDI
	{
		[Cpp2IlInjected.Token(Token = "0x60002EB")]
		[Cpp2IlInjected.Address(RVA = "0x72D7DE0", Offset = "0x72D6FE0", VA = "0x1872D7DE0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B2")]
	private bool AHABAMCABAJ
	{
		[Cpp2IlInjected.Token(Token = "0x60002EC")]
		[Cpp2IlInjected.Address(RVA = "0x72DE140", Offset = "0x72DD340", VA = "0x1872DE140")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B3")]
	private EKBKMDGMIHO DHGIKLOJLBP
	{
		[Cpp2IlInjected.Token(Token = "0x60002ED")]
		[Cpp2IlInjected.Address(RVA = "0x72DE8E0", Offset = "0x72DDAE0", VA = "0x1872DE8E0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B4")]
	private bool OMNFODDCIFN
	{
		[Cpp2IlInjected.Token(Token = "0x60002EE")]
		[Cpp2IlInjected.Address(RVA = "0x72DE7E0", Offset = "0x72DD9E0", VA = "0x1872DE7E0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400002D")]
	public event ELNJCAEPAAK CJFJJNDMAIP
	{
		[Cpp2IlInjected.Token(Token = "0x60002E9")]
		[Cpp2IlInjected.Address(RVA = "0x72DE940", Offset = "0x72DDB40", VA = "0x1872DE940", Slot = "4")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60002EA")]
		[Cpp2IlInjected.Address(RVA = "0x72DE840", Offset = "0x72DDA40", VA = "0x1872DE840", Slot = "5")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60002EF")]
	[Cpp2IlInjected.Address(RVA = "0x72DEA80", Offset = "0x72DDC80", VA = "0x1872DEA80")]
	public IPNGINBGNCD(EKBKMDGMIHO BINJLCOIDDF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002F0")]
	[Cpp2IlInjected.Address(RVA = "0x72DE0B0", Offset = "0x72DD2B0", VA = "0x1872DE0B0", Slot = "6")]
	public void AHDMKGLGKBO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002F1")]
	[Cpp2IlInjected.Address(RVA = "0x72DE160", Offset = "0x72DD360", VA = "0x1872DE160", Slot = "8")]
	public void CFOJAPGBBPH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002F2")]
	[Cpp2IlInjected.Address(RVA = "0x72DE170", Offset = "0x72DD370", VA = "0x1872DE170", Slot = "7")]
	public bool EPPJDPEDBGL()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002F3")]
	[Cpp2IlInjected.Address(RVA = "0x72DE010", Offset = "0x72DD210", VA = "0x1872DE010", Slot = "9")]
	public void AGNPDGIKBIK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002F4")]
	[Cpp2IlInjected.Address(RVA = "0x72DE9E0", Offset = "0x72DDBE0", VA = "0x1872DE9E0", Slot = "11")]
	public void OHGIIOIIMII()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002F5")]
	[Cpp2IlInjected.Address(RVA = "0x72DE2C0", Offset = "0x72DD4C0", VA = "0x1872DE2C0", Slot = "10")]
	public void FOGCPMFHMIM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002F6")]
	[Cpp2IlInjected.Address(RVA = "0x72DE470", Offset = "0x72DD670", VA = "0x1872DE470")]
	private bool FPGEFMEGKGP()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002F7")]
	[Cpp2IlInjected.Address(RVA = "0x72DE650", Offset = "0x72DD850", VA = "0x1872DE650")]
	private void JFEMJFOJLMM()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000036")]
internal sealed class BAOCIODDPCL : HIBMHPPLBHO
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400006A")]
	private readonly PMLAOCKCIDG BINJLCOIDDF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400006B")]
	private readonly ANFGKOFMNEN FHIJMCEHONJ;

	[Cpp2IlInjected.Token(Token = "0x170000B5")]
	public Rigidbody PAAIMMKMKDI
	{
		[Cpp2IlInjected.Token(Token = "0x60002F8")]
		[Cpp2IlInjected.Address(RVA = "0x897B70", Offset = "0x896D70", VA = "0x180897B70", Slot = "4")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60002F9")]
		[Cpp2IlInjected.Address(RVA = "0x897BB0", Offset = "0x896DB0", VA = "0x180897BB0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B6")]
	private bool OMNFODDCIFN
	{
		[Cpp2IlInjected.Token(Token = "0x60002FA")]
		[Cpp2IlInjected.Address(RVA = "0x72DA9F0", Offset = "0x72D9BF0", VA = "0x1872DA9F0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B7")]
	public bool LNDICMCFIPK
	{
		[Cpp2IlInjected.Token(Token = "0x60002FD")]
		[Cpp2IlInjected.Address(RVA = "0x11D2160", Offset = "0x11D1360", VA = "0x1811D2160", Slot = "6")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60002FB")]
	[Cpp2IlInjected.Address(RVA = "0x72DAF60", Offset = "0x72DA160", VA = "0x1872DAF60")]
	public BAOCIODDPCL(EKBKMDGMIHO BINJLCOIDDF, [In] GNBAPJBBCHJ LJIEGDEDOHM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002FC")]
	[Cpp2IlInjected.Address(RVA = "0x72DA760", Offset = "0x72D9960", VA = "0x1872DA760", Slot = "5")]
	public void AHDMKGLGKBO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002FE")]
	[Cpp2IlInjected.Address(RVA = "0x72DAF00", Offset = "0x72DA100", VA = "0x1872DAF00", Slot = "7")]
	public void NONEIJICMCC(object NIOIDOPDJKO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002FF")]
	[Cpp2IlInjected.Address(RVA = "0x72DAF30", Offset = "0x72DA130", VA = "0x1872DAF30", Slot = "8")]
	public void OEAAGOFKENI(object NIOIDOPDJKO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000300")]
	[Cpp2IlInjected.Address(RVA = "0x72DAA50", Offset = "0x72D9C50", VA = "0x1872DAA50", Slot = "9")]
	public void KPOPOHDLFJA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000301")]
	[Cpp2IlInjected.Address(RVA = "0x72DA800", Offset = "0x72D9A00", VA = "0x1872DA800", Slot = "10")]
	public void JIDKFADNACK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000302")]
	[Cpp2IlInjected.Address(RVA = "0x72DAD80", Offset = "0x72D9F80", VA = "0x1872DAD80", Slot = "11")]
	public void MLPDIJLIBJL()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000037")]
internal sealed class LNHOGEMNCNI : MDPIGHOADEP, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400006D")]
	private readonly PMLAOCKCIDG BINJLCOIDDF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400006E")]
	private readonly ANFGKOFMNEN HOCGGAHFDAK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400006F")]
	private float EEKNJIACMIJ;

	[Cpp2IlInjected.Token(Token = "0x170000B8")]
	public POBAPJPNJIF OKLDKBDBGNP
	{
		[Cpp2IlInjected.Token(Token = "0x6000303")]
		[Cpp2IlInjected.Address(RVA = "0x894500", Offset = "0x893700", VA = "0x180894500", Slot = "4")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000304")]
		[Cpp2IlInjected.Address(RVA = "0x89F8C0", Offset = "0x89EAC0", VA = "0x18089F8C0", Slot = "5")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B9")]
	public JJAKICIKFMK KEMNPJCLCNA
	{
		[Cpp2IlInjected.Token(Token = "0x6000305")]
		[Cpp2IlInjected.Address(RVA = "0x8944C0", Offset = "0x8936C0", VA = "0x1808944C0", Slot = "6")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000306")]
		[Cpp2IlInjected.Address(RVA = "0x89AD00", Offset = "0x899F00", VA = "0x18089AD00", Slot = "7")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000BA")]
	public Vector3 KBAKMFGPJLG
	{
		[Cpp2IlInjected.Token(Token = "0x6000307")]
		[Cpp2IlInjected.Address(RVA = "0x72E3100", Offset = "0x72E2300", VA = "0x1872E3100", Slot = "8")]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x6000308")]
		[Cpp2IlInjected.Address(RVA = "0x72E3550", Offset = "0x72E2750", VA = "0x1872E3550", Slot = "9")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000BB")]
	public Vector3 BIHFCPFIPNN
	{
		[Cpp2IlInjected.Token(Token = "0x6000309")]
		[Cpp2IlInjected.Address(RVA = "0x72E2730", Offset = "0x72E1930", VA = "0x1872E2730", Slot = "10")]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x600030A")]
		[Cpp2IlInjected.Address(RVA = "0x72E1FD0", Offset = "0x72E11D0", VA = "0x1872E1FD0", Slot = "11")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000BC")]
	public Vector3 OEMJMBCMIKA
	{
		[Cpp2IlInjected.Token(Token = "0x600030B")]
		[Cpp2IlInjected.Address(RVA = "0x72E5380", Offset = "0x72E4580", VA = "0x1872E5380", Slot = "12")]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x600030C")]
		[Cpp2IlInjected.Address(RVA = "0x72E2EA0", Offset = "0x72E20A0", VA = "0x1872E2EA0", Slot = "13")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000BD")]
	public Vector3 LEJCIOCLJLG
	{
		[Cpp2IlInjected.Token(Token = "0x600030D")]
		[Cpp2IlInjected.Address(RVA = "0x72E3940", Offset = "0x72E2B40", VA = "0x1872E3940", Slot = "14")]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x600030E")]
		[Cpp2IlInjected.Address(RVA = "0x72E2060", Offset = "0x72E1260", VA = "0x1872E2060", Slot = "15")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000BE")]
	public float KGLOMNONIBO
	{
		[Cpp2IlInjected.Token(Token = "0x600030F")]
		[Cpp2IlInjected.Address(RVA = "0xB325E0", Offset = "0xB317E0", VA = "0x180B325E0", Slot = "16")]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x6000310")]
		[Cpp2IlInjected.Address(RVA = "0x72E2D30", Offset = "0x72E1F30", VA = "0x1872E2D30", Slot = "17")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000BF")]
	public bool BFIALJKMPNL
	{
		[Cpp2IlInjected.Token(Token = "0x6000311")]
		[Cpp2IlInjected.Address(RVA = "0x1B426B0", Offset = "0x1B418B0", VA = "0x181B426B0", Slot = "18")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000C0")]
	private HINKFLFNMKF EMIFCNIDGCO
	{
		[Cpp2IlInjected.Token(Token = "0x6000326")]
		[Cpp2IlInjected.Address(RVA = "0x6AD25A0", Offset = "0x6AD17A0", VA = "0x186AD25A0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000C1")]
	private bool AHABAMCABAJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000327")]
		[Cpp2IlInjected.Address(RVA = "0x72E1FB0", Offset = "0x72E11B0", VA = "0x1872E1FB0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000312")]
	[Cpp2IlInjected.Address(RVA = "0x72E5540", Offset = "0x72E4740", VA = "0x1872E5540")]
	public LNHOGEMNCNI(EKBKMDGMIHO BINJLCOIDDF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000313")]
	[Cpp2IlInjected.Address(RVA = "0x72E1CD0", Offset = "0x72E0ED0", VA = "0x1872E1CD0", Slot = "19")]
	public void AHDMKGLGKBO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000314")]
	[Cpp2IlInjected.Address(RVA = "0x72E2E40", Offset = "0x72E2040", VA = "0x1872E2E40", Slot = "36")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000315")]
	[Cpp2IlInjected.Address(RVA = "0x72E4EF0", Offset = "0x72E40F0", VA = "0x1872E4EF0", Slot = "28")]
	public void OFPIEMIENHN(Rigidbody LOMDGCGOAME)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000316")]
	[Cpp2IlInjected.Address(RVA = "0xFE0AF0", Offset = "0xFDFCF0", VA = "0x180FE0AF0", Slot = "20")]
	public void LFBDMBFPNBI(object NIOIDOPDJKO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000317")]
	[Cpp2IlInjected.Address(RVA = "0xFDE8D0", Offset = "0xFDDAD0", VA = "0x180FDE8D0", Slot = "30")]
	public void DJKHLNOIHDC(object NIOIDOPDJKO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000318")]
	[Cpp2IlInjected.Address(RVA = "0x72E4550", Offset = "0x72E3750", VA = "0x1872E4550", Slot = "35")]
	public Vector3 MFBCEHFOCAN(Vector3 NJMKNHLGFKE)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000319")]
	[Cpp2IlInjected.Address(RVA = "0x72E48B0", Offset = "0x72E3AB0", VA = "0x1872E48B0", Slot = "34")]
	public Vector3 NIKABBPFJNG(Vector3 PDMDPBKDBDN)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x600031A")]
	[Cpp2IlInjected.Address(RVA = "0x72E1CD0", Offset = "0x72E0ED0", VA = "0x1872E1CD0", Slot = "27")]
	public void CKMLCDAHKNE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600031B")]
	[Cpp2IlInjected.Address(RVA = "0x72E4070", Offset = "0x72E3270", VA = "0x1872E4070", Slot = "25")]
	public void LOGAJLHKHPP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600031C")]
	[Cpp2IlInjected.Address(RVA = "0x72E34F0", Offset = "0x72E26F0", VA = "0x1872E34F0", Slot = "24")]
	public void HGJBDOFNHOE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600031D")]
	[Cpp2IlInjected.Address(RVA = "0x72E1D70", Offset = "0x72E0F70", VA = "0x1872E1D70", Slot = "33")]
	public void BEHNGDKFALP(Vector3 JJGNONCAJKL, Vector3 HJANGHEDIGO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600031E")]
	[Cpp2IlInjected.Address(RVA = "0x72E2000", Offset = "0x72E1200", VA = "0x1872E2000", Slot = "32")]
	public void CCJHLODLJDC(Vector3 OBJNBNIHDNA, Vector3 CPBKNIAPNBD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600031F")]
	[Cpp2IlInjected.Address(RVA = "0x72E3610", Offset = "0x72E2810", VA = "0x1872E3610", Slot = "31")]
	public void IIAEJMEGJMB(Vector3 IANJJOPONOA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000320")]
	[Cpp2IlInjected.Address(RVA = "0x72E2090", Offset = "0x72E1290", VA = "0x1872E2090", Slot = "22")]
	public void CKOALKCLCCK(KNPMGCIOAIO GPBGOJOBPDD, Vector3 NBLKIPPEOAD, float PMAAKLFOBHF, float EEAHHPFKLHF = 8f, float BHCLILJBOCH = 1f)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000321")]
	[Cpp2IlInjected.Address(RVA = "0x72E5100", Offset = "0x72E4300", VA = "0x1872E5100", Slot = "21")]
	public void PDHNHLCFFDB(JIOFAHGJLPH KDOGOEHPAMH, Vector3 KEIBLCIFAEK, float CNCMGOOCLHH = float.PositiveInfinity)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000322")]
	[Cpp2IlInjected.Address(RVA = "0x72E40D0", Offset = "0x72E32D0", VA = "0x1872E40D0", Slot = "23")]
	[Obsolete("Deprecated. Still exists to support deprecated CV2 chips. Use ApplyAngularVelocityChange.")]
	public void MCPCHEDLNPF(JIOFAHGJLPH KDOGOEHPAMH, Vector3 MBMKLLFOFFL, float JIJBBEKPCIF = 7f, float NCMKACAPAEK = 1f)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000323")]
	[Cpp2IlInjected.Address(RVA = "0x10EB460", Offset = "0x10EA660", VA = "0x1810EB460")]
	private static void CPJMFFIGIAB(Vector3 BEEOMEJFEKJ, Vector3 DJCLDHHAKMM, [Out] Vector3 FLNDMEIEMAG, [Out] Vector3 AMIKJMEOKAJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000324")]
	[Cpp2IlInjected.Address(RVA = "0x72E5020", Offset = "0x72E4220", VA = "0x1872E5020", Slot = "29")]
	public Vector3 OHEEAJNKOAD(Vector3 BEEOMEJFEKJ)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000325")]
	[Cpp2IlInjected.Address(RVA = "0x72E37B0", Offset = "0x72E29B0", VA = "0x1872E37B0", Slot = "26")]
	public void KJPJJLAMIPM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000328")]
	[Cpp2IlInjected.Address(RVA = "0x72E2D30", Offset = "0x72E1F30", VA = "0x1872E2D30")]
	private void DMNJCIJDBJC(float JECHHBGMFLN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000329")]
	[Cpp2IlInjected.Address(RVA = "0x72E2F60", Offset = "0x72E2160", VA = "0x1872E2F60")]
	private void ENDJIHLPDIO(Vector3 KEIBLCIFAEK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600032A")]
	[Cpp2IlInjected.Address(RVA = "0x72E4730", Offset = "0x72E3930", VA = "0x1872E4730")]
	private Vector3 MMJJCDMPNJH()
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x600032B")]
	[Cpp2IlInjected.Address(RVA = "0x72E4A70", Offset = "0x72E3C70", VA = "0x1872E4A70")]
	private void NJPFGKDIBLH(Vector3 PDMDPBKDBDN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600032C")]
	[Cpp2IlInjected.Address(RVA = "0x72E32B0", Offset = "0x72E24B0", VA = "0x1872E32B0")]
	private Vector3 GOKFBHEJOJB()
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x600032D")]
	[Cpp2IlInjected.Address(RVA = "0x72E28B0", Offset = "0x72E1AB0", VA = "0x1872E28B0")]
	private void DIHCHKFADAI(Vector3 JECHHBGMFLN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600032E")]
	[Cpp2IlInjected.Address(RVA = "0x72E3AD0", Offset = "0x72E2CD0", VA = "0x1872E3AD0")]
	private void LLKPKPPNGMI(Vector3 PDMDPBKDBDN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600032F")]
	[Cpp2IlInjected.Address(RVA = "0x72E3440", Offset = "0x72E2640", VA = "0x1872E3440")]
	private void HAFEHNCPOMK()
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
