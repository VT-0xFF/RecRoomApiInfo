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
	public class LogRegistrationIndex : AOMECLICLPB
	{
		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(RVA = "0x8997160", Offset = "0x8996160", VA = "0x188997160", Slot = "4")]
		public override void AMNFOKHCMAP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0xA8A800", Offset = "0xA89800", VA = "0x180A8A800")]
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
			[Cpp2IlInjected.Address(RVA = "0xA63FE0", Offset = "0xA62FE0", VA = "0x180A63FE0", Slot = "4")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x8334620", Offset = "0x8333620", VA = "0x188334620", Slot = "5")]
		public override void SetServiceCategoryIndices(List<int> globalFromLocalIndices)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x89A5960", Offset = "0x89A4960", VA = "0x1889A5960")]
		private void MNKCLNFPDFM(IServiceRegistration registry)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x89A5C60", Offset = "0x89A4C60", VA = "0x1889A5C60", Slot = "6")]
		public override void RegisterServices(IServiceRegistration registry, [In] ServiceBitsetFilter filter)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x89A5CC0", Offset = "0x89A4CC0", VA = "0x1889A5CC0")]
		public _AssemblyIndex()
		{
		}
	}
}
namespace RecRoom
{
	[Cpp2IlInjected.Token(Token = "0x2000004")]
	[DisallowMultipleComponent]
	public sealed class RigidbodyEx : MonoBehaviour, EOEFLGKDFOB, BDBAOHOAIEN, ENHHOGMNBEM
	{
		[Cpp2IlInjected.Token(Token = "0x4000004")]
		private static readonly ONIHMLNNEEF BJPBJKACAGF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000005")]
		private bool KNLCMJIJMLO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000006")]
		private MFIGOAEMMAF NIPENPILDOA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000007")]
		[ELFKDNHKCIP(KDIHEPCABNF.Self, false, false, false)]
		[SerializeField]
		private Rigidbody unityRigidbody;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000008")]
		[SerializeField]
		[ELFKDNHKCIP(KDIHEPCABNF.SelfAndParent, true, false, false)]
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
		private PCMEBGNJIKH physicsInterpolation;

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
		private Transform IKIDCDOOPHC;

		[Cpp2IlInjected.Token(Token = "0x17000002")]
		internal MFIGOAEMMAF OKGEMAEPIIK
		{
			[Cpp2IlInjected.Token(Token = "0x6000008")]
			[Cpp2IlInjected.Address(RVA = "0x89A0F70", Offset = "0x899FF70", VA = "0x1889A0F70")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000003")]
		private MFIGOAEMMAF NIJAMFBPNIE
		{
			[Cpp2IlInjected.Token(Token = "0x6000009")]
			[Cpp2IlInjected.Address(RVA = "0xA63F80", Offset = "0xA62F80", VA = "0x180A63F80", Slot = "6")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000004")]
		public int KCCFAOPCIDP
		{
			[Cpp2IlInjected.Token(Token = "0x600001E")]
			[Cpp2IlInjected.Address(RVA = "0x89A2E70", Offset = "0x89A1E70", VA = "0x1889A2E70")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000005")]
		public RigidbodyEx DJILCEBNMMP
		{
			[Cpp2IlInjected.Token(Token = "0x6000020")]
			[Cpp2IlInjected.Address(RVA = "0x89A31D0", Offset = "0x89A21D0", VA = "0x1889A31D0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000006")]
		public RigidbodyEx AOHAMHAHFAH
		{
			[Cpp2IlInjected.Token(Token = "0x6000021")]
			[Cpp2IlInjected.Address(RVA = "0x89A3110", Offset = "0x89A2110", VA = "0x1889A3110")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000007")]
		public RigidbodyEx EBJBKAEFOPM
		{
			[Cpp2IlInjected.Token(Token = "0x6000022")]
			[Cpp2IlInjected.Address(RVA = "0x89A3DD0", Offset = "0x89A2DD0", VA = "0x1889A3DD0")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000023")]
			[Cpp2IlInjected.Address(RVA = "0x89A52D0", Offset = "0x89A42D0", VA = "0x1889A52D0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000008")]
		public bool LIBBMOMCAPO
		{
			[Cpp2IlInjected.Token(Token = "0x6000024")]
			[Cpp2IlInjected.Address(RVA = "0x85BCB90", Offset = "0x85BBB90", VA = "0x1885BCB90", Slot = "11")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000025")]
			[Cpp2IlInjected.Address(RVA = "0x85BCD00", Offset = "0x85BBD00", VA = "0x1885BCD00")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000009")]
		public Transform PLPGMCABFBF
		{
			[Cpp2IlInjected.Token(Token = "0x6000026")]
			[Cpp2IlInjected.Address(RVA = "0x24BECC0", Offset = "0x24BDCC0", VA = "0x1824BECC0", Slot = "5")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000A")]
		public Transform PPLKOJFPDFE
		{
			[Cpp2IlInjected.Token(Token = "0x6000027")]
			[Cpp2IlInjected.Address(RVA = "0x24BECC0", Offset = "0x24BDCC0", VA = "0x1824BECC0", Slot = "14")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000B")]
		public Transform BMDDMEMBCIP
		{
			[Cpp2IlInjected.Token(Token = "0x6000028")]
			[Cpp2IlInjected.Address(RVA = "0x24BECC0", Offset = "0x24BDCC0", VA = "0x1824BECC0", Slot = "15")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000C")]
		public JEHFMNHABAI OAFIDMJJIDM
		{
			[Cpp2IlInjected.Token(Token = "0x6000029")]
			[Cpp2IlInjected.Address(RVA = "0x89A2ED0", Offset = "0x89A1ED0", VA = "0x1889A2ED0")]
			get
			{
				return default(JEHFMNHABAI);
			}
			[Cpp2IlInjected.Token(Token = "0x600002A")]
			[Cpp2IlInjected.Address(RVA = "0x89A4A80", Offset = "0x89A3A80", VA = "0x1889A4A80")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000D")]
		public bool OIEKHFOHMAM
		{
			[Cpp2IlInjected.Token(Token = "0x600002B")]
			[Cpp2IlInjected.Address(RVA = "0x89A34E0", Offset = "0x89A24E0", VA = "0x1889A34E0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000E")]
		public bool DJDBGPECKIC
		{
			[Cpp2IlInjected.Token(Token = "0x600002C")]
			[Cpp2IlInjected.Address(RVA = "0x89A2FF0", Offset = "0x89A1FF0", VA = "0x1889A2FF0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000F")]
		public CJDPDAAMOBM MMEHAJFLOLP
		{
			[Cpp2IlInjected.Token(Token = "0x600002D")]
			[Cpp2IlInjected.Address(RVA = "0x89A3420", Offset = "0x89A2420", VA = "0x1889A3420")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600002E")]
			[Cpp2IlInjected.Address(RVA = "0x89A4C40", Offset = "0x89A3C40", VA = "0x1889A4C40")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000010")]
		public NEPEHFKKAHG GJFLFCKDPFG
		{
			[Cpp2IlInjected.Token(Token = "0x600002F")]
			[Cpp2IlInjected.Address(RVA = "0x89A33C0", Offset = "0x89A23C0", VA = "0x1889A33C0")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000030")]
			[Cpp2IlInjected.Address(RVA = "0x89A4BD0", Offset = "0x89A3BD0", VA = "0x1889A4BD0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000011")]
		public bool NJMEINAJFDB
		{
			[Cpp2IlInjected.Token(Token = "0x6000031")]
			[Cpp2IlInjected.Address(RVA = "0x89A3310", Offset = "0x89A2310", VA = "0x1889A3310")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000012")]
		public Rigidbody CHKPFCFBIFF
		{
			[Cpp2IlInjected.Token(Token = "0x6000032")]
			[Cpp2IlInjected.Address(RVA = "0x89A3370", Offset = "0x89A2370", VA = "0x1889A3370")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000013")]
		public bool CLKOFGBADDK
		{
			[Cpp2IlInjected.Token(Token = "0x6000033")]
			[Cpp2IlInjected.Address(RVA = "0x89A3050", Offset = "0x89A2050", VA = "0x1889A3050")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000034")]
			[Cpp2IlInjected.Address(RVA = "0x89A4AF0", Offset = "0x89A3AF0", VA = "0x1889A4AF0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000014")]
		public bool PMNFMAGNEJO
		{
			[Cpp2IlInjected.Token(Token = "0x6000035")]
			[Cpp2IlInjected.Address(RVA = "0x85BBC20", Offset = "0x85BAC20", VA = "0x1885BBC20", Slot = "7")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000015")]
		public float PEFCKLHMGJD
		{
			[Cpp2IlInjected.Token(Token = "0x6000036")]
			[Cpp2IlInjected.Address(RVA = "0x89A3D70", Offset = "0x89A2D70", VA = "0x1889A3D70")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000016")]
		public float BHBOIEHJEOM
		{
			[Cpp2IlInjected.Token(Token = "0x6000037")]
			[Cpp2IlInjected.Address(RVA = "0x89A3D10", Offset = "0x89A2D10", VA = "0x1889A3D10")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x6000038")]
			[Cpp2IlInjected.Address(RVA = "0x89A5260", Offset = "0x89A4260", VA = "0x1889A5260")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000017")]
		public float LJOOJHOLGAP
		{
			[Cpp2IlInjected.Token(Token = "0x6000039")]
			[Cpp2IlInjected.Address(RVA = "0x89A3740", Offset = "0x89A2740", VA = "0x1889A3740")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x600003A")]
			[Cpp2IlInjected.Address(RVA = "0x89A4EE0", Offset = "0x89A3EE0", VA = "0x1889A4EE0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000018")]
		public float BCEDCCMJNGC
		{
			[Cpp2IlInjected.Token(Token = "0x600003B")]
			[Cpp2IlInjected.Address(RVA = "0x89A3540", Offset = "0x89A2540", VA = "0x1889A3540")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x600003C")]
			[Cpp2IlInjected.Address(RVA = "0x89A4CB0", Offset = "0x89A3CB0", VA = "0x1889A4CB0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000019")]
		public bool ODLKDNICAFE
		{
			[Cpp2IlInjected.Token(Token = "0x600003D")]
			[Cpp2IlInjected.Address(RVA = "0x89A4320", Offset = "0x89A3320", VA = "0x1889A4320")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x600003E")]
			[Cpp2IlInjected.Address(RVA = "0x89A5810", Offset = "0x89A4810", VA = "0x1889A5810")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001A")]
		public Vector3 KPMKLEMEKBJ
		{
			[Cpp2IlInjected.Token(Token = "0x600003F")]
			[Cpp2IlInjected.Address(RVA = "0x89A3AF0", Offset = "0x89A2AF0", VA = "0x1889A3AF0")]
			get
			{
				return default(Vector3);
			}
			[Cpp2IlInjected.Token(Token = "0x6000040")]
			[Cpp2IlInjected.Address(RVA = "0x89A5030", Offset = "0x89A4030", VA = "0x1889A5030")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001B")]
		public Vector3 HMDEFBMKMLC
		{
			[Cpp2IlInjected.Token(Token = "0x6000041")]
			[Cpp2IlInjected.Address(RVA = "0x89A4460", Offset = "0x89A3460", VA = "0x1889A4460")]
			get
			{
				return default(Vector3);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001C")]
		public CollisionDetectionMode LEFOMHIIAGI
		{
			[Cpp2IlInjected.Token(Token = "0x6000042")]
			[Cpp2IlInjected.Address(RVA = "0x89A3680", Offset = "0x89A2680", VA = "0x1889A3680")]
			get
			{
				return default(CollisionDetectionMode);
			}
			[Cpp2IlInjected.Token(Token = "0x6000043")]
			[Cpp2IlInjected.Address(RVA = "0x89A4E00", Offset = "0x89A3E00", VA = "0x1889A4E00")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001D")]
		public float ILLCHEIADLB
		{
			[Cpp2IlInjected.Token(Token = "0x6000044")]
			[Cpp2IlInjected.Address(RVA = "0x89A30B0", Offset = "0x89A20B0", VA = "0x1889A30B0")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x6000045")]
			[Cpp2IlInjected.Address(RVA = "0x89A4B60", Offset = "0x89A3B60", VA = "0x1889A4B60")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001E")]
		public RigidbodyConstraints LCBPFFNIJIA
		{
			[Cpp2IlInjected.Token(Token = "0x6000046")]
			[Cpp2IlInjected.Address(RVA = "0x89A36E0", Offset = "0x89A26E0", VA = "0x1889A36E0")]
			get
			{
				return default(RigidbodyConstraints);
			}
			[Cpp2IlInjected.Token(Token = "0x6000047")]
			[Cpp2IlInjected.Address(RVA = "0x89A4E70", Offset = "0x89A3E70", VA = "0x1889A4E70")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001F")]
		public Vector3 PFGGHMBGCAF
		{
			[Cpp2IlInjected.Token(Token = "0x6000048")]
			[Cpp2IlInjected.Address(RVA = "0x89A3E90", Offset = "0x89A2E90", VA = "0x1889A3E90")]
			get
			{
				return default(Vector3);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000020")]
		public Vector3 KMDDGHIJKPA
		{
			[Cpp2IlInjected.Token(Token = "0x6000049")]
			[Cpp2IlInjected.Address(RVA = "0x89A3E90", Offset = "0x89A2E90", VA = "0x1889A3E90")]
			get
			{
				return default(Vector3);
			}
			[Cpp2IlInjected.Token(Token = "0x600004A")]
			[Cpp2IlInjected.Address(RVA = "0x89A55F0", Offset = "0x89A45F0", VA = "0x1889A55F0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000021")]
		public float DFIAMPCHCLH
		{
			[Cpp2IlInjected.Token(Token = "0x600004B")]
			[Cpp2IlInjected.Address(RVA = "0x89A3BD0", Offset = "0x89A2BD0", VA = "0x1889A3BD0")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x600004C")]
			[Cpp2IlInjected.Address(RVA = "0x89A5110", Offset = "0x89A4110", VA = "0x1889A5110")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000022")]
		public float OLCPGMLEDFA
		{
			[Cpp2IlInjected.Token(Token = "0x600004D")]
			[Cpp2IlInjected.Address(RVA = "0x89A42C0", Offset = "0x89A32C0", VA = "0x1889A42C0")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x600004E")]
			[Cpp2IlInjected.Address(RVA = "0x89A57A0", Offset = "0x89A47A0", VA = "0x1889A57A0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000023")]
		public Quaternion EGGPCNNMMGE
		{
			[Cpp2IlInjected.Token(Token = "0x600004F")]
			[Cpp2IlInjected.Address(RVA = "0x89A3F70", Offset = "0x89A2F70", VA = "0x1889A3F70")]
			get
			{
				return default(Quaternion);
			}
			[Cpp2IlInjected.Token(Token = "0x6000050")]
			[Cpp2IlInjected.Address(RVA = "0x89A5370", Offset = "0x89A4370", VA = "0x1889A5370")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000024")]
		public Quaternion DKKFLBOPGNB
		{
			[Cpp2IlInjected.Token(Token = "0x6000051")]
			[Cpp2IlInjected.Address(RVA = "0x89A41F0", Offset = "0x89A31F0", VA = "0x1889A41F0")]
			get
			{
				return default(Quaternion);
			}
			[Cpp2IlInjected.Token(Token = "0x6000052")]
			[Cpp2IlInjected.Address(RVA = "0x89A56D0", Offset = "0x89A46D0", VA = "0x1889A56D0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000025")]
		public Vector3 EPBKLCACGIC
		{
			[Cpp2IlInjected.Token(Token = "0x6000053")]
			[Cpp2IlInjected.Address(RVA = "0x89A4040", Offset = "0x89A3040", VA = "0x1889A4040")]
			get
			{
				return default(Vector3);
			}
			[Cpp2IlInjected.Token(Token = "0x6000054")]
			[Cpp2IlInjected.Address(RVA = "0x89A5440", Offset = "0x89A4440", VA = "0x1889A5440")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000026")]
		public Quaternion HJKLFLPPJPI
		{
			[Cpp2IlInjected.Token(Token = "0x6000055")]
			[Cpp2IlInjected.Address(RVA = "0x89A4120", Offset = "0x89A3120", VA = "0x1889A4120")]
			get
			{
				return default(Quaternion);
			}
			[Cpp2IlInjected.Token(Token = "0x6000056")]
			[Cpp2IlInjected.Address(RVA = "0x89A5520", Offset = "0x89A4520", VA = "0x1889A5520")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000027")]
		public Vector3 PJFEPLADHFM
		{
			[Cpp2IlInjected.Token(Token = "0x6000057")]
			[Cpp2IlInjected.Address(RVA = "0x89A4380", Offset = "0x89A3380", VA = "0x1889A4380")]
			get
			{
				return default(Vector3);
			}
			[Cpp2IlInjected.Token(Token = "0x6000058")]
			[Cpp2IlInjected.Address(RVA = "0x89A5880", Offset = "0x89A4880", VA = "0x1889A5880")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000028")]
		public Vector3 LPNLMKHOCCP
		{
			[Cpp2IlInjected.Token(Token = "0x6000059")]
			[Cpp2IlInjected.Address(RVA = "0x89A3C30", Offset = "0x89A2C30", VA = "0x1889A3C30")]
			get
			{
				return default(Vector3);
			}
			[Cpp2IlInjected.Token(Token = "0x600005A")]
			[Cpp2IlInjected.Address(RVA = "0x89A5180", Offset = "0x89A4180", VA = "0x1889A5180")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000029")]
		public Vector3 MPLOLODGAEG
		{
			[Cpp2IlInjected.Token(Token = "0x600005B")]
			[Cpp2IlInjected.Address(RVA = "0x89A35A0", Offset = "0x89A25A0", VA = "0x1889A35A0")]
			get
			{
				return default(Vector3);
			}
			[Cpp2IlInjected.Token(Token = "0x600005C")]
			[Cpp2IlInjected.Address(RVA = "0x89A4D20", Offset = "0x89A3D20", VA = "0x1889A4D20")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002A")]
		public Vector3 JOHCPGENEAP
		{
			[Cpp2IlInjected.Token(Token = "0x600005D")]
			[Cpp2IlInjected.Address(RVA = "0x89A3A10", Offset = "0x89A2A10", VA = "0x1889A3A10")]
			get
			{
				return default(Vector3);
			}
			[Cpp2IlInjected.Token(Token = "0x600005E")]
			[Cpp2IlInjected.Address(RVA = "0x89A4F50", Offset = "0x89A3F50", VA = "0x1889A4F50")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002B")]
		public Vector3 PLAKLGLCBKD
		{
			[Cpp2IlInjected.Token(Token = "0x600005F")]
			[Cpp2IlInjected.Address(RVA = "0x89A38D0", Offset = "0x89A28D0", VA = "0x1889A38D0")]
			get
			{
				return default(Vector3);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002C")]
		public Quaternion DCEKFABCPDB
		{
			[Cpp2IlInjected.Token(Token = "0x6000060")]
			[Cpp2IlInjected.Address(RVA = "0x89A3800", Offset = "0x89A2800", VA = "0x1889A3800")]
			get
			{
				return default(Quaternion);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002D")]
		public Vector3 GGKJLHKGHNH
		{
			[Cpp2IlInjected.Token(Token = "0x6000062")]
			[Cpp2IlInjected.Address(RVA = "0x89A4620", Offset = "0x89A3620", VA = "0x1889A4620")]
			get
			{
				return default(Vector3);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002E")]
		public Vector3 CJANKGKKBAB
		{
			[Cpp2IlInjected.Token(Token = "0x6000063")]
			[Cpp2IlInjected.Address(RVA = "0x89A4540", Offset = "0x89A3540", VA = "0x1889A4540")]
			get
			{
				return default(Vector3);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002F")]
		public bool MCFBHOHCNGE
		{
			[Cpp2IlInjected.Token(Token = "0x6000064")]
			[Cpp2IlInjected.Address(RVA = "0x89A39B0", Offset = "0x89A29B0", VA = "0x1889A39B0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000030")]
		public bool HNJOCDCIFMO
		{
			[Cpp2IlInjected.Token(Token = "0x6000065")]
			[Cpp2IlInjected.Address(RVA = "0x89A3480", Offset = "0x89A2480", VA = "0x1889A3480")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000031")]
		public bool DPCAIJIEHEN
		{
			[Cpp2IlInjected.Token(Token = "0x6000066")]
			[Cpp2IlInjected.Address(RVA = "0x89A2F90", Offset = "0x89A1F90", VA = "0x1889A2F90")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000032")]
		public bool EOKLDEIAEOO
		{
			[Cpp2IlInjected.Token(Token = "0x6000067")]
			[Cpp2IlInjected.Address(RVA = "0x89A2F30", Offset = "0x89A1F30", VA = "0x1889A2F30")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000033")]
		public bool PHDHLJLMIHD
		{
			[Cpp2IlInjected.Token(Token = "0x6000068")]
			[Cpp2IlInjected.Address(RVA = "0x89A2E10", Offset = "0x89A1E10", VA = "0x1889A2E10")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000034")]
		public bool NNAHFOACCID
		{
			[Cpp2IlInjected.Token(Token = "0x6000069")]
			[Cpp2IlInjected.Address(RVA = "0x89A37A0", Offset = "0x89A27A0", VA = "0x1889A37A0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000035")]
		public bool EMJBEIDFIBH
		{
			[Cpp2IlInjected.Token(Token = "0x600006A")]
			[Cpp2IlInjected.Address(RVA = "0x26967B0", Offset = "0x26957B0", VA = "0x1826967B0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000001")]
		public event PALGGIDOPDJ CIKIIKKEEKI
		{
			[Cpp2IlInjected.Token(Token = "0x600000E")]
			[Cpp2IlInjected.Address(RVA = "0x89A2D30", Offset = "0x89A1D30", VA = "0x1889A2D30")]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x600000F")]
			[Cpp2IlInjected.Address(RVA = "0x89A49A0", Offset = "0x89A39A0", VA = "0x1889A49A0")]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000002")]
		public event FIIMNHMKNMH PNOOHILMNMA
		{
			[Cpp2IlInjected.Token(Token = "0x6000010")]
			[Cpp2IlInjected.Address(RVA = "0x89A2AA0", Offset = "0x89A1AA0", VA = "0x1889A2AA0")]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000011")]
			[Cpp2IlInjected.Address(RVA = "0x89A4700", Offset = "0x89A3700", VA = "0x1889A4700")]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000003")]
		public event FIIMNHMKNMH PBICCJJDPLG
		{
			[Cpp2IlInjected.Token(Token = "0x6000012")]
			[Cpp2IlInjected.Address(RVA = "0x89A2B00", Offset = "0x89A1B00", VA = "0x1889A2B00")]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000013")]
			[Cpp2IlInjected.Address(RVA = "0x89A4770", Offset = "0x89A3770", VA = "0x1889A4770")]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000004")]
		public event FIIMNHMKNMH ACKGCCKHMDK
		{
			[Cpp2IlInjected.Token(Token = "0x6000014")]
			[Cpp2IlInjected.Address(RVA = "0x89A2C50", Offset = "0x89A1C50", VA = "0x1889A2C50")]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000015")]
			[Cpp2IlInjected.Address(RVA = "0x89A48C0", Offset = "0x89A38C0", VA = "0x1889A48C0")]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000005")]
		public event Action<FECJOJFDCBL, FECJOJFDCBL> NPPNIPCOAAB
		{
			[Cpp2IlInjected.Token(Token = "0x6000016")]
			[Cpp2IlInjected.Address(RVA = "0x89A2BE0", Offset = "0x89A1BE0", VA = "0x1889A2BE0")]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000017")]
			[Cpp2IlInjected.Address(RVA = "0x89A4850", Offset = "0x89A3850", VA = "0x1889A4850")]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000006")]
		public event FIIMNHMKNMH KOODDNOOJIB
		{
			[Cpp2IlInjected.Token(Token = "0x6000018")]
			[Cpp2IlInjected.Address(RVA = "0x89A2CC0", Offset = "0x89A1CC0", VA = "0x1889A2CC0")]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000019")]
			[Cpp2IlInjected.Address(RVA = "0x89A4930", Offset = "0x89A3930", VA = "0x1889A4930")]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000007")]
		public event FIIMNHMKNMH GLCCPAGBJLM
		{
			[Cpp2IlInjected.Token(Token = "0x600001A")]
			[Cpp2IlInjected.Address(RVA = "0x89A2DA0", Offset = "0x89A1DA0", VA = "0x1889A2DA0")]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x600001B")]
			[Cpp2IlInjected.Address(RVA = "0x89A4A10", Offset = "0x89A3A10", VA = "0x1889A4A10")]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000008")]
		public event FIIMNHMKNMH PNCLDBFDLCI
		{
			[Cpp2IlInjected.Token(Token = "0x600001C")]
			[Cpp2IlInjected.Address(RVA = "0x89A2B70", Offset = "0x89A1B70", VA = "0x1889A2B70")]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x600001D")]
			[Cpp2IlInjected.Address(RVA = "0x89A47E0", Offset = "0x89A37E0", VA = "0x1889A47E0")]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0xA616B0", Offset = "0xA606B0", VA = "0x180A616B0", Slot = "8")]
		private void ILCIPFKNFLF(MFIGOAEMMAF JOEHPNNMIOL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x89A14B0", Offset = "0x89A04B0", VA = "0x1889A14B0", Slot = "9")]
		public POOLCNKIBAH GetData()
		{
			return default(POOLCNKIBAH);
		}

		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x89A17A0", Offset = "0x89A07A0", VA = "0x1889A17A0")]
		internal void JFDILLABGAD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x89A27C0", Offset = "0x89A17C0", VA = "0x1889A27C0")]
		[Conditional("DEBUG_BUILD")]
		[Conditional("UNITY_EDITOR")]
		public void TestOverrideUnityRigidbody(Rigidbody NJBJLKMNGBK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x89A1200", Offset = "0x89A0200", VA = "0x1889A1200")]
		public EOEFLGKDFOB GetChild(int HLGKMAPOEBE)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000061")]
		[Cpp2IlInjected.Address(RVA = "0x89A2420", Offset = "0x89A1420", VA = "0x1889A2420")]
		public void SetInertiaTensor((Quaternion rot, Vector3 moments) MOHIENDLLGP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006B")]
		[Cpp2IlInjected.Address(RVA = "0x89A0DA0", Offset = "0x899FDA0", VA = "0x1889A0DA0")]
		private void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006C")]
		[Cpp2IlInjected.Address(RVA = "0x89A26B0", Offset = "0x89A16B0", VA = "0x1889A26B0")]
		protected void Start()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006D")]
		[Cpp2IlInjected.Address(RVA = "0x89A0F70", Offset = "0x899FF70", VA = "0x1889A0F70")]
		private MFIGOAEMMAF CBFGLDMLGCD()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600006E")]
		[Cpp2IlInjected.Address(RVA = "0x89A1830", Offset = "0x89A0830", VA = "0x1889A1830")]
		private void LMCEEELLBNF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006F")]
		[Cpp2IlInjected.Address(RVA = "0x89A1BF0", Offset = "0x89A0BF0", VA = "0x1889A1BF0")]
		private void OnEnable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000070")]
		[Cpp2IlInjected.Address(RVA = "0x89A1B30", Offset = "0x89A0B30", VA = "0x1889A1B30")]
		public void OnDisable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000071")]
		[Cpp2IlInjected.Address(RVA = "0x89A17A0", Offset = "0x89A07A0", VA = "0x1889A17A0")]
		private void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000072")]
		[Cpp2IlInjected.Address(RVA = "0x89A1B90", Offset = "0x89A0B90", VA = "0x1889A1B90")]
		private void OnDrawGizmosSelected()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000073")]
		[Cpp2IlInjected.Address(RVA = "0x89A1C50", Offset = "0x89A0C50", VA = "0x1889A1C50")]
		private void OnValidate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000074")]
		[Cpp2IlInjected.Address(RVA = "0x89A0390", Offset = "0x899F390", VA = "0x1889A0390")]
		public void AddDoNotResetVelocityOnOwnershipChangeOverride(object GFDDDAIMFOH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000075")]
		[Cpp2IlInjected.Address(RVA = "0x89A1CB0", Offset = "0x89A0CB0", VA = "0x1889A1CB0")]
		public void RemoveDoNotResetVelocityOnOwnershipChangeOverride(object GFDDDAIMFOH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000076")]
		[Cpp2IlInjected.Address(RVA = "0x89A11A0", Offset = "0x89A01A0", VA = "0x1889A11A0")]
		public void DisableCachedInertialPropertyOverride()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000077")]
		[Cpp2IlInjected.Address(RVA = "0x89A1AC0", Offset = "0x89A0AC0", VA = "0x1889A1AC0")]
		public void MarkCachedInertialParametersDirty()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000078")]
		[Cpp2IlInjected.Address(RVA = "0x89A2580", Offset = "0x89A1580", VA = "0x1889A2580")]
		public void SetParent(RigidbodyEx IOALKPFEKEK, bool LPDEIPGKDOE = false)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000079")]
		[Cpp2IlInjected.Address(RVA = "0x89A1FC0", Offset = "0x89A0FC0", VA = "0x1889A1FC0")]
		public void ResetLocalCenterOfMassToPrefabDefault()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007A")]
		[Cpp2IlInjected.Address(RVA = "0x89A1540", Offset = "0x89A0540", VA = "0x1889A1540")]
		public bool IsRigidbodyAncestor(RigidbodyEx EMENNBOEONK)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600007B")]
		[Cpp2IlInjected.Address(RVA = "0x89A1640", Offset = "0x89A0640", VA = "0x1889A1640")]
		public bool IsRigidbodyDescendant(RigidbodyEx BCPBENAFFCB)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600007C")]
		[Cpp2IlInjected.Address(RVA = "0x89A0600", Offset = "0x899F600", VA = "0x1889A0600")]
		public void AddInterpolationRestriction(object GFDDDAIMFOH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007D")]
		[Cpp2IlInjected.Address(RVA = "0x89A1D20", Offset = "0x89A0D20", VA = "0x1889A1D20")]
		public void RemoveInterpolationRestriction(object GFDDDAIMFOH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007E")]
		[Cpp2IlInjected.Address(RVA = "0x89A0670", Offset = "0x899F670", VA = "0x1889A0670")]
		public void AddKinematic(object GFDDDAIMFOH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007F")]
		[Cpp2IlInjected.Address(RVA = "0x89A1D90", Offset = "0x89A0D90", VA = "0x1889A1D90")]
		public void RemoveKinematic(object GFDDDAIMFOH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000080")]
		[Cpp2IlInjected.Address(RVA = "0x89A2500", Offset = "0x89A1500", VA = "0x1889A2500")]
		public void SetKinematic(object GFDDDAIMFOH, bool NALIKJHDOEC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000081")]
		[Cpp2IlInjected.Address(RVA = "0x89A2320", Offset = "0x89A1320", VA = "0x1889A2320")]
		public void SetDiscontinuousPositionAndRotation(Vector3 JEDFBKNAHJC, Quaternion GNCFNEMFPLP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000082")]
		[Cpp2IlInjected.Address(RVA = "0x89A2220", Offset = "0x89A1220", VA = "0x1889A2220")]
		public void SetDiscontinuousLocalPositionAndLocalRotation(Vector3 JFMFLMJAIHA, Quaternion FPFHCEKDEIC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000083")]
		[Cpp2IlInjected.Address(RVA = "0x89A13A0", Offset = "0x89A03A0", VA = "0x1889A13A0")]
		public Vector3 GetConstrainedVelocity(Vector3 PJFEPLADHFM)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x6000084")]
		[Cpp2IlInjected.Address(RVA = "0x89A1290", Offset = "0x89A0290", VA = "0x1889A1290")]
		public Vector3 GetConstrainedAngularVelocity(Vector3 MPLOLODGAEG)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x6000085")]
		[Cpp2IlInjected.Address(RVA = "0x89A0510", Offset = "0x899F510", VA = "0x1889A0510")]
		public void AddForce(Vector3 HOJOMGEINAH, ForceMode DLJNDNGFIPO = ForceMode.Force)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000086")]
		[Cpp2IlInjected.Address(RVA = "0x89A0400", Offset = "0x899F400", VA = "0x1889A0400")]
		public void AddForceAtPosition(Vector3 HOJOMGEINAH, Vector3 EBGKGBGFPOC, ForceMode DLJNDNGFIPO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000087")]
		[Cpp2IlInjected.Address(RVA = "0x89A0840", Offset = "0x899F840", VA = "0x1889A0840")]
		public void AddTorque(Vector3 LAOLJOAKMLI, ForceMode DLJNDNGFIPO = ForceMode.Force)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000088")]
		[Cpp2IlInjected.Address(RVA = "0x89A06E0", Offset = "0x899F6E0", VA = "0x1889A06E0")]
		public void AddRelativeTorque(Vector3 LAOLJOAKMLI, ForceMode DLJNDNGFIPO = ForceMode.Force)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000089")]
		[Cpp2IlInjected.Address(RVA = "0x89A2890", Offset = "0x89A1890", VA = "0x1889A2890")]
		public Vector3 WorldToLocalVelocity(Vector3 EJHCENJMOAJ)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x600008A")]
		[Cpp2IlInjected.Address(RVA = "0x89A19B0", Offset = "0x89A09B0", VA = "0x1889A19B0")]
		public Vector3 LocalToWorldVelocity(Vector3 LPNLMKHOCCP)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x600008B")]
		[Cpp2IlInjected.Address(RVA = "0x89A1140", Offset = "0x89A0140", VA = "0x1889A1140")]
		public void ClearVelocity()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008C")]
		[Cpp2IlInjected.Address(RVA = "0x89A10E0", Offset = "0x89A00E0", VA = "0x1889A10E0")]
		public void ClearUnityRigidbodyVelocity()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008D")]
		[Cpp2IlInjected.Address(RVA = "0x89A1080", Offset = "0x89A0080", VA = "0x1889A1080")]
		public void ClearLinearVelocity()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008E")]
		[Cpp2IlInjected.Address(RVA = "0x89A1020", Offset = "0x89A0020", VA = "0x1889A1020")]
		public void ClearAngularVelocity()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008F")]
		[Cpp2IlInjected.Address(RVA = "0x89A2120", Offset = "0x89A1120", VA = "0x1889A2120")]
		public void ResetVelocityWorldSpace(Vector3 MKOHLGDKLKH, Vector3 BCOOKGPOLPI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000090")]
		[Cpp2IlInjected.Address(RVA = "0x89A2020", Offset = "0x89A1020", VA = "0x1889A2020")]
		public void ResetVelocityLocalSpace(Vector3 MPLGBPBMKDL, Vector3 JOHCPGENEAP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000091")]
		[Cpp2IlInjected.Address(RVA = "0x89A1EE0", Offset = "0x89A0EE0", VA = "0x1889A1EE0")]
		public void ResetLinearVelocityLocalSpace(Vector3 MPLGBPBMKDL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000092")]
		[Cpp2IlInjected.Address(RVA = "0x89A26C0", Offset = "0x89A16C0", VA = "0x1889A26C0")]
		public bool SweepTest(Vector3 NBFEGPDMMPI, [Out] RaycastHit CPCOHHMIMEG, float OAGBEPAKAEK)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000093")]
		[Cpp2IlInjected.Address(RVA = "0x89A1740", Offset = "0x89A0740", VA = "0x1889A1740")]
		public bool IsSleeping()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000094")]
		[Cpp2IlInjected.Address(RVA = "0x89A2650", Offset = "0x89A1650", VA = "0x1889A2650")]
		public void Sleep()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000095")]
		[Cpp2IlInjected.Address(RVA = "0x89A2830", Offset = "0x89A1830", VA = "0x1889A2830")]
		public void WakeUp()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000096")]
		[Cpp2IlInjected.Address(RVA = "0x89A07D0", Offset = "0x899F7D0", VA = "0x1889A07D0")]
		public void AddShouldHaveUnityRigidbodyToken(object GFDDDAIMFOH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000097")]
		[Cpp2IlInjected.Address(RVA = "0x89A1E00", Offset = "0x89A0E00", VA = "0x1889A1E00")]
		public void RemoveShouldHaveUnityRigidbodyToken(object GFDDDAIMFOH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000098")]
		[Cpp2IlInjected.Address(RVA = "0x89A0BD0", Offset = "0x899FBD0", VA = "0x1889A0BD0")]
		public void ApplyForceVelocityChange(PDEAKMCNOBP BHODJGJGDPL, Vector3 HDFLLIHEFEL, float BHOMNNEBJAB, float NFNKFEGBCDH = 8f, float BFCHCLEELBL = 1f)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000099")]
		[Cpp2IlInjected.Address(RVA = "0x89A0AD0", Offset = "0x899FAD0", VA = "0x1889A0AD0")]
		public void ApplyAngularVelocityChange(IPOBJHPAPLB IIMDKLGOCHN, Vector3 PDIJEFFPDPG, float HIFIKLNHOGN = float.PositiveInfinity)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009A")]
		[Cpp2IlInjected.Address(RVA = "0x89A0C90", Offset = "0x899FC90", VA = "0x1889A0C90")]
		[Obsolete("Deprecated. Still exists to support deprecated CV2 chips. Use ApplyAngularVelocityChange.")]
		public void ApplyTorqueAngularVelocityChangeDeprecated(IPOBJHPAPLB IIMDKLGOCHN, Vector3 KDHLIJMPIFF, float FJKPDIEAPAB = 7f, float CGBPKBEEFCI = 1f)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009B")]
		[Cpp2IlInjected.Address(RVA = "0x89A0A00", Offset = "0x899FA00", VA = "0x1889A0A00")]
		public bool AllowedScaleChange(float IOPKIIHMCNB)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600009C")]
		[Cpp2IlInjected.Address(RVA = "0x89A0930", Offset = "0x899F930", VA = "0x1889A0930")]
		public void AddWorldSpaceVelocityInHierarchyParentOverride(RigidbodyEx AJICGEOMBJL, object GFDDDAIMFOH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009D")]
		[Cpp2IlInjected.Address(RVA = "0x89A1E70", Offset = "0x89A0E70", VA = "0x1889A1E70")]
		public void RemoveWorldSpaceVelocityInHierarchyParentOverride(object GFDDDAIMFOH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009E")]
		[Cpp2IlInjected.Address(RVA = "0x89A1B20", Offset = "0x89A0B20", VA = "0x1889A1B20", Slot = "13")]
		private void NGOKMMBMPJJ(ODDBPMPHPJL IEGLIFIOOBM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009F")]
		[Cpp2IlInjected.Address(RVA = "0x89A2A30", Offset = "0x89A1A30", VA = "0x1889A2A30")]
		public RigidbodyEx()
		{
		}

		[SpecialName]
		[Cpp2IlInjected.Token(Token = "0x60000A1")]
		[Cpp2IlInjected.Address(RVA = "0xB004A0", Offset = "0xAFF4A0", VA = "0x180B004A0", Slot = "4")]
		private GameObject LOGMGJEIPHA()
		{
			return null;
		}

		[SpecialName]
		[Cpp2IlInjected.Token(Token = "0x60000A2")]
		[Cpp2IlInjected.Address(RVA = "0xA8DCB0", Offset = "0xA8CCB0", VA = "0x180A8DCB0", Slot = "10")]
		private bool NGEOPDNHGCK()
		{
			return default(bool);
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
internal static class EKFLPBOMNJP
{
	[Cpp2IlInjected.Token(Token = "0x60000A3")]
	[Cpp2IlInjected.Address(RVA = "0x8990000", Offset = "0x898F000", VA = "0x188990000")]
	public static MFIGOAEMMAF OKGEMAEPIIK(this RigidbodyEx FBMIODACPPK)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
[RegisterService(typeof(LAPLJDMFFDB), new string[] { })]
public class JGCOFFOABHP : LAPLJDMFFDB, PJNGLGAADAH
{
	[Cpp2IlInjected.Token(Token = "0x4000011")]
	private static readonly ONIHMLNNEEF EFJNGOKNPIL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000012")]
	private APAALKIMDJM JMDACFLNFAD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000013")]
	private AECGPMCLHFG FJGDGLJOMEE;

	[Cpp2IlInjected.Token(Token = "0x17000036")]
	public APAALKIMDJM PNJBCOOHDNG
	{
		[Cpp2IlInjected.Token(Token = "0x60000A4")]
		[Cpp2IlInjected.Address(RVA = "0xA63FD0", Offset = "0xA62FD0", VA = "0x180A63FD0", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000037")]
	public AECGPMCLHFG DLBNJLFACIP
	{
		[Cpp2IlInjected.Token(Token = "0x60000A5")]
		[Cpp2IlInjected.Address(RVA = "0xA5F390", Offset = "0xA5E390", VA = "0x180A5F390", Slot = "5")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000A6")]
	[Cpp2IlInjected.Address(RVA = "0x8994D40", Offset = "0x8993D40", VA = "0x188994D40", Slot = "7")]
	public void InitReferences(BLPLIKKLKBG CCGPMJFFCDG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A7")]
	[Cpp2IlInjected.Address(RVA = "0x8994B70", Offset = "0x8993B70", VA = "0x188994B70", Slot = "6")]
	public MFIGOAEMMAF CLCLMIBBLAJ(RigidbodyEx FBMIODACPPK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000A8")]
	[Cpp2IlInjected.Address(RVA = "0xA6E050", Offset = "0xA6D050", VA = "0x180A6E050")]
	public JGCOFFOABHP()
	{
	}
}
namespace RecRoom
{
	[Cpp2IlInjected.Token(Token = "0x2000007")]
	public class PhysicsManager : SingletonMonoBehaviour<PhysicsManager>
	{
		[Cpp2IlInjected.Token(Token = "0x4000014")]
		public static LELKCPPPMEI UpdateAfterFixedUpdateRan;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000015")]
		private int KBHCLNHMGFL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x4000016")]
		private int IMMHGBHPEDP;

		[Cpp2IlInjected.Token(Token = "0x60000AA")]
		[Cpp2IlInjected.Address(RVA = "0x89A01F0", Offset = "0x899F1F0", VA = "0x1889A01F0")]
		protected void FixedUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AB")]
		[Cpp2IlInjected.Address(RVA = "0x89A0230", Offset = "0x899F230", VA = "0x1889A0230")]
		protected void Update()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AC")]
		[Cpp2IlInjected.Address(RVA = "0x89A0210", Offset = "0x899F210", VA = "0x1889A0210")]
		protected void LateUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AD")]
		[Cpp2IlInjected.Address(RVA = "0xA60520", Offset = "0xA5F520", VA = "0x180A60520")]
		[Conditional("UNITY_ASSERTIONS")]
		public void AssertLateColliderPositionsNotYetUpdated([Optional] string OBCNAJEENCI, [Optional] UnityEngine.Object IEGLIFIOOBM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AE")]
		[Cpp2IlInjected.Address(RVA = "0xA60520", Offset = "0xA5F520", VA = "0x180A60520")]
		[Conditional("UNITY_ASSERTIONS")]
		public void AssertLateColliderPositionsAlreadyUpdated([Optional] string OBCNAJEENCI, [Optional] UnityEngine.Object IEGLIFIOOBM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AF")]
		[Cpp2IlInjected.Address(RVA = "0x89A0340", Offset = "0x899F340", VA = "0x1889A0340")]
		public PhysicsManager()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
public static class IJMMAOKKLKE
{
	[Cpp2IlInjected.Token(Token = "0x2000009")]
	private class LMPPDJLLAAM : CJDPDAAMOBM, IDisposable
	{
		[Cpp2IlInjected.Token(Token = "0x60000B3")]
		[Cpp2IlInjected.Address(RVA = "0xA60520", Offset = "0xA5F520", VA = "0x180A60520", Slot = "7")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B4")]
		[Cpp2IlInjected.Address(RVA = "0xA70A00", Offset = "0xA6FA00", VA = "0x180A70A00", Slot = "4")]
		public Vector3 EFNDDNNNFJE()
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x60000B5")]
		[Cpp2IlInjected.Address(RVA = "0xA70A00", Offset = "0xA6FA00", VA = "0x180A70A00", Slot = "5")]
		public Vector3 BJBALAFBFOB()
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x60000B6")]
		[Cpp2IlInjected.Address(RVA = "0xA7B3A0", Offset = "0xA7A3A0", VA = "0x180A7B3A0", Slot = "6")]
		public bool OHLADPAAILJ(float FFEIAKDDJNH, float KLDFFENIOMK)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000B7")]
		[Cpp2IlInjected.Address(RVA = "0xA6E050", Offset = "0xA6D050", VA = "0x180A6E050")]
		public LMPPDJLLAAM()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000038")]
	public static CJDPDAAMOBM AGAPLEDONFL
	{
		[Cpp2IlInjected.Token(Token = "0x60000B1")]
		[Cpp2IlInjected.Address(RVA = "0x8994920", Offset = "0x8993920", VA = "0x188994920")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
public interface HLHJKDPIEEG
{
	[Cpp2IlInjected.Token(Token = "0x17000039")]
	CollisionDetectionMode OKCKKBNNDGG
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
	void IDNMFFEDDDN();

	[Cpp2IlInjected.Token(Token = "0x60000BB")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void MFLAIIIKNJO(bool MCFBHOHCNGE);

	[Cpp2IlInjected.Token(Token = "0x60000BC")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void AMECCLGBNGK(bool MCFBHOHCNGE);

	[Cpp2IlInjected.Token(Token = "0x60000BD")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void JDNGENAKMFJ(Rigidbody OEKAMIKGJCJ);

	[Cpp2IlInjected.Token(Token = "0x60000BE")]
	[Cpp2IlInjected.Address(Slot = "6")]
	bool NIECBDANKIP(Vector3 NBFEGPDMMPI, [Out] RaycastHit CPCOHHMIMEG, float OAGBEPAKAEK);
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
public interface DEFJPKLJLBE : IDisposable, CGNFKEMEDPA
{
	[Cpp2IlInjected.Token(Token = "0x1700003A")]
	JEHFMNHABAI OAFIDMJJIDM
	{
		[Cpp2IlInjected.Token(Token = "0x60000C1")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
		[Cpp2IlInjected.Token(Token = "0x60000C2")]
		[Cpp2IlInjected.Address(Slot = "3")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x14000009")]
	event Action<FECJOJFDCBL, FECJOJFDCBL> NPPNIPCOAAB;

	[Cpp2IlInjected.Token(Token = "0x60000C3")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void IDNMFFEDDDN();
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
[ServiceLifetime(Lifetime.Application)]
public interface AECGPMCLHFG
{
	[Cpp2IlInjected.Token(Token = "0x60000C4")]
	[Cpp2IlInjected.Address(Slot = "0")]
	HKHMGNIMBHB KKAICCBLMME(MFIGOAEMMAF JOEHPNNMIOL);

	[Cpp2IlInjected.Token(Token = "0x60000C5")]
	[Cpp2IlInjected.Address(Slot = "1")]
	NKFJANAJGEK IHKHJBNKMOL(MFIGOAEMMAF JOEHPNNMIOL);

	[Cpp2IlInjected.Token(Token = "0x60000C6")]
	[Cpp2IlInjected.Address(Slot = "2")]
	OEHINJFEKGA CMDCHECMNHH(MFIGOAEMMAF JOEHPNNMIOL);

	[Cpp2IlInjected.Token(Token = "0x60000C7")]
	[Cpp2IlInjected.Address(Slot = "3")]
	NECKIKIOFMD DCMJMMLJBOI(MFIGOAEMMAF JOEHPNNMIOL);

	[Cpp2IlInjected.Token(Token = "0x60000C8")]
	[Cpp2IlInjected.Address(Slot = "4")]
	NDEJNDNEBID KLFPNHHMPIE(MFIGOAEMMAF JOEHPNNMIOL);

	[Cpp2IlInjected.Token(Token = "0x60000C9")]
	[Cpp2IlInjected.Address(Slot = "5")]
	DEFJPKLJLBE JMLIMKFFLKM(MFIGOAEMMAF JOEHPNNMIOL);

	[Cpp2IlInjected.Token(Token = "0x60000CA")]
	[Cpp2IlInjected.Address(Slot = "6")]
	HFPGPHALCME NKKNKKNOIME(MFIGOAEMMAF JOEHPNNMIOL);

	[Cpp2IlInjected.Token(Token = "0x60000CB")]
	[Cpp2IlInjected.Address(Slot = "7")]
	JDHBKCDFGPA JMGOHIAIBAF(MFIGOAEMMAF JOEHPNNMIOL);

	[Cpp2IlInjected.Token(Token = "0x60000CC")]
	[Cpp2IlInjected.Address(Slot = "8")]
	HLHJKDPIEEG CFAAEONCFLF(MFIGOAEMMAF JOEHPNNMIOL);

	[Cpp2IlInjected.Token(Token = "0x60000CD")]
	[Cpp2IlInjected.Address(Slot = "9")]
	OHBIIAGNIEI KNOCJMNGFPO(MFIGOAEMMAF JOEHPNNMIOL);

	[Cpp2IlInjected.Token(Token = "0x60000CE")]
	[Cpp2IlInjected.Address(Slot = "10")]
	HHGNGAAPGIO KKFCCMOLINI(MFIGOAEMMAF JOEHPNNMIOL, [In] POOLCNKIBAH INCJDDLACNP);

	[Cpp2IlInjected.Token(Token = "0x60000CF")]
	[Cpp2IlInjected.Address(Slot = "11")]
	FBGDKAGAKLD OPMFGCKMPBP(MFIGOAEMMAF JOEHPNNMIOL, [In] POOLCNKIBAH INCJDDLACNP);

	[Cpp2IlInjected.Token(Token = "0x60000D0")]
	[Cpp2IlInjected.Address(Slot = "12")]
	NEPFFIKMEOI KLFHMIOJFGJ(MFIGOAEMMAF JOEHPNNMIOL, [In] POOLCNKIBAH INCJDDLACNP);

	[Cpp2IlInjected.Token(Token = "0x60000D1")]
	[Cpp2IlInjected.Address(Slot = "13")]
	IJEDNMNOMME BAMBMADBICM(MFIGOAEMMAF JOEHPNNMIOL, [In] POOLCNKIBAH INCJDDLACNP);

	[Cpp2IlInjected.Token(Token = "0x60000D2")]
	[Cpp2IlInjected.Address(Slot = "14")]
	JIDOCDIJGFP JFKOGBGNMIJ(MFIGOAEMMAF JOEHPNNMIOL, [In] POOLCNKIBAH INCJDDLACNP);

	[Cpp2IlInjected.Token(Token = "0x60000D3")]
	[Cpp2IlInjected.Address(Slot = "15")]
	MFIGOAEMMAF CLCLMIBBLAJ(RigidbodyEx FBMIODACPPK, POOLCNKIBAH INCJDDLACNP, LAPLJDMFFDB PAOKFDJPALE);
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
public interface JDHBKCDFGPA
{
	[Cpp2IlInjected.Token(Token = "0x60000D4")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void HEMDJAKLKFB(Vector3 HOJOMGEINAH, ForceMode DLJNDNGFIPO = ForceMode.Force);

	[Cpp2IlInjected.Token(Token = "0x60000D5")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void AIADFLLFLEP(Vector3 HOJOMGEINAH, Vector3 EBGKGBGFPOC, ForceMode DLJNDNGFIPO);

	[Cpp2IlInjected.Token(Token = "0x60000D6")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void HMNBOIPBKPM(Vector3 LAOLJOAKMLI, ForceMode DLJNDNGFIPO = ForceMode.Force);

	[Cpp2IlInjected.Token(Token = "0x60000D7")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void MGKIMILNCCG(Vector3 LAOLJOAKMLI, ForceMode DLJNDNGFIPO = ForceMode.Force);
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
public interface OHBIIAGNIEI
{
	[Cpp2IlInjected.Token(Token = "0x1700003B")]
	bool AKBHMCCMMHA
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
	void JDNGENAKMFJ(Rigidbody OEKAMIKGJCJ);

	[Cpp2IlInjected.Token(Token = "0x60000DB")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void AHPFMPBNNKL(Rigidbody OEKAMIKGJCJ);
}
[Cpp2IlInjected.Token(Token = "0x200000F")]
public interface HKHMGNIMBHB : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x1700003C")]
	IReadOnlyList<MFIGOAEMMAF> CBBCFAGKAPG
	{
		[Cpp2IlInjected.Token(Token = "0x60000EE")]
		[Cpp2IlInjected.Address(Slot = "18")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700003D")]
	MFIGOAEMMAF AOHAMHAHFAH
	{
		[Cpp2IlInjected.Token(Token = "0x60000EF")]
		[Cpp2IlInjected.Address(Slot = "19")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700003E")]
	MFIGOAEMMAF GDFCPOBJFDH
	{
		[Cpp2IlInjected.Token(Token = "0x60000F0")]
		[Cpp2IlInjected.Address(Slot = "20")]
		get;
		[Cpp2IlInjected.Token(Token = "0x60000F1")]
		[Cpp2IlInjected.Address(Slot = "21")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x1400000A")]
	event FIIMNHMKNMH PNOOHILMNMA;

	[Cpp2IlInjected.Token(Token = "0x1400000B")]
	event FIIMNHMKNMH PBICCJJDPLG;

	[Cpp2IlInjected.Token(Token = "0x1400000C")]
	event PALGGIDOPDJ ALJOINIAEFA;

	[Cpp2IlInjected.Token(Token = "0x1400000D")]
	event Action JBLCBFEGMJG;

	[Cpp2IlInjected.Token(Token = "0x1400000E")]
	event Action NFCJKLKGPAP;

	[Cpp2IlInjected.Token(Token = "0x1400000F")]
	event Action<MFIGOAEMMAF> AOACAGGKOJF;

	[Cpp2IlInjected.Token(Token = "0x14000010")]
	event Action<MFIGOAEMMAF> JEMONODBOLH;

	[Cpp2IlInjected.Token(Token = "0x14000011")]
	event Action LJJGPNPBPGK;

	[Cpp2IlInjected.Token(Token = "0x14000012")]
	event Action<MFIGOAEMMAF> EFCELDGDMEK;

	[Cpp2IlInjected.Token(Token = "0x60000F2")]
	[Cpp2IlInjected.Address(Slot = "22")]
	void AKCKLCNBHIA(MFIGOAEMMAF BKAKGIFOLLC, bool LPDEIPGKDOE = false);
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
public interface OEHINJFEKGA
{
	[Cpp2IlInjected.Token(Token = "0x1700003F")]
	Vector3 DGPJNKHKOAH
	{
		[Cpp2IlInjected.Token(Token = "0x60000F3")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000040")]
	Vector3 OCPCNFPMMKN
	{
		[Cpp2IlInjected.Token(Token = "0x60000F4")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x60000F5")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void HIJHFKCPBFP(MFIGOAEMMAF EBJBKAEFOPM, object GFDDDAIMFOH);

	[Cpp2IlInjected.Token(Token = "0x60000F6")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void GNHEDOFBMBF(object GFDDDAIMFOH);
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
public interface IJEDNMNOMME
{
	[Cpp2IlInjected.Token(Token = "0x17000041")]
	Vector3 JHEJMAHNPBI
	{
		[Cpp2IlInjected.Token(Token = "0x60000F9")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
		[Cpp2IlInjected.Token(Token = "0x60000FA")]
		[Cpp2IlInjected.Address(Slot = "3")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000042")]
	Vector3 MHMKILICHPP
	{
		[Cpp2IlInjected.Token(Token = "0x60000FB")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000043")]
	float AMGCMLCLCBG
	{
		[Cpp2IlInjected.Token(Token = "0x60000FC")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000044")]
	float DPJEGOOLEIH
	{
		[Cpp2IlInjected.Token(Token = "0x60000FD")]
		[Cpp2IlInjected.Address(Slot = "6")]
		get;
		[Cpp2IlInjected.Token(Token = "0x60000FE")]
		[Cpp2IlInjected.Address(Slot = "7")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000045")]
	Vector3 HOCIMGJPKJG
	{
		[Cpp2IlInjected.Token(Token = "0x60000FF")]
		[Cpp2IlInjected.Address(Slot = "8")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000046")]
	Quaternion EIJGCCEDODN
	{
		[Cpp2IlInjected.Token(Token = "0x6000100")]
		[Cpp2IlInjected.Address(Slot = "9")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x14000013")]
	event FIIMNHMKNMH NCNPBNNEHJD;

	[Cpp2IlInjected.Token(Token = "0x6000101")]
	[Cpp2IlInjected.Address(Slot = "10")]
	void DKLLEIPOFLE((Quaternion rot, Vector3 moments) MOHIENDLLGP);

	[Cpp2IlInjected.Token(Token = "0x6000102")]
	[Cpp2IlInjected.Address(Slot = "11")]
	void ADJGMOJPIGC();

	[Cpp2IlInjected.Token(Token = "0x6000103")]
	[Cpp2IlInjected.Address(Slot = "12")]
	void FANGIMEHNDB();

	[Cpp2IlInjected.Token(Token = "0x6000104")]
	[Cpp2IlInjected.Address(Slot = "13")]
	void OHOPNDOPGNC();

	[Cpp2IlInjected.Token(Token = "0x6000105")]
	[Cpp2IlInjected.Address(Slot = "14")]
	void JDNGENAKMFJ(Rigidbody OEKAMIKGJCJ);

	[Cpp2IlInjected.Token(Token = "0x6000106")]
	[Cpp2IlInjected.Address(Slot = "15")]
	void AHPFMPBNNKL(Rigidbody OEKAMIKGJCJ);

	[Cpp2IlInjected.Token(Token = "0x6000107")]
	[Cpp2IlInjected.Address(Slot = "16")]
	void DAEOFNOBLFE();
}
[Cpp2IlInjected.Token(Token = "0x2000012")]
public interface NEPFFIKMEOI
{
	[Cpp2IlInjected.Token(Token = "0x6000108")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void IDNMFFEDDDN();

	[Cpp2IlInjected.Token(Token = "0x6000109")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void CCACJJHHCNK(object GFDDDAIMFOH);

	[Cpp2IlInjected.Token(Token = "0x600010A")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void POIPMFFIONI(object GFDDDAIMFOH);

	[Cpp2IlInjected.Token(Token = "0x600010B")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void IMKDDAAEAIL(MFIGOAEMMAF FBMIODACPPK);

	[Cpp2IlInjected.Token(Token = "0x600010C")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void CGEGJHMEJEH(MFIGOAEMMAF FBMIODACPPK);

	[Cpp2IlInjected.Token(Token = "0x600010D")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void MJHPAGNFEJP();
}
[Cpp2IlInjected.Token(Token = "0x2000013")]
public interface HFPGPHALCME
{
	[Cpp2IlInjected.Token(Token = "0x17000047")]
	bool HBGAICGJHMM
	{
		[Cpp2IlInjected.Token(Token = "0x6000110")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x14000014")]
	event FIIMNHMKNMH ACOJALPIMJC;

	[Cpp2IlInjected.Token(Token = "0x6000111")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void MBKNGPCCHDF(object GFDDDAIMFOH);

	[Cpp2IlInjected.Token(Token = "0x6000112")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void FJHOMGODMDJ(object GFDDDAIMFOH);

	[Cpp2IlInjected.Token(Token = "0x6000113")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void GLIAEMFMKNK(object GFDDDAIMFOH, bool NALIKJHDOEC);

	[Cpp2IlInjected.Token(Token = "0x6000114")]
	[Cpp2IlInjected.Address(Slot = "6")]
	void JDNGENAKMFJ(Rigidbody OJLJIHMPMHO);

	[Cpp2IlInjected.Token(Token = "0x6000115")]
	[Cpp2IlInjected.Address(Slot = "7")]
	void AHPFMPBNNKL(Rigidbody OEKAMIKGJCJ);
}
[Cpp2IlInjected.Token(Token = "0x2000014")]
public interface FBGDKAGAKLD : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x17000048")]
	bool OIEKHFOHMAM
	{
		[Cpp2IlInjected.Token(Token = "0x6000118")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000049")]
	bool DJDBGPECKIC
	{
		[Cpp2IlInjected.Token(Token = "0x6000119")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x14000015")]
	event FIIMNHMKNMH NNMBHEJKLMO;

	[Cpp2IlInjected.Token(Token = "0x600011A")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void IDNMFFEDDDN();

	[Cpp2IlInjected.Token(Token = "0x600011B")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void JODKHMDLHCG(MFIGOAEMMAF EBJBKAEFOPM);

	[Cpp2IlInjected.Token(Token = "0x600011C")]
	[Cpp2IlInjected.Address(Slot = "6")]
	void OHKCJDBEEIM(MFIGOAEMMAF EBJBKAEFOPM);
}
[Cpp2IlInjected.Token(Token = "0x2000015")]
public interface JIDOCDIJGFP
{
	[Cpp2IlInjected.Token(Token = "0x1700004A")]
	bool CLKOFGBADDK
	{
		[Cpp2IlInjected.Token(Token = "0x600011D")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
		[Cpp2IlInjected.Token(Token = "0x600011E")]
		[Cpp2IlInjected.Address(Slot = "1")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x1700004B")]
	bool DMKHKJFOKCI
	{
		[Cpp2IlInjected.Token(Token = "0x600011F")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700004C")]
	RigidbodyConstraints LMOGEOKLEMJ
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
	void JDNGENAKMFJ(Rigidbody OEKAMIKGJCJ);

	[Cpp2IlInjected.Token(Token = "0x6000123")]
	[Cpp2IlInjected.Address(Slot = "6")]
	void AHPFMPBNNKL(Rigidbody OEKAMIKGJCJ);
}
[Cpp2IlInjected.Token(Token = "0x2000016")]
public interface NECKIKIOFMD
{
	[Cpp2IlInjected.Token(Token = "0x1700004D")]
	float EECOPGNPCHA
	{
		[Cpp2IlInjected.Token(Token = "0x6000124")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
		[Cpp2IlInjected.Token(Token = "0x6000125")]
		[Cpp2IlInjected.Address(Slot = "1")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x1700004E")]
	float ABDAAKPCHLE
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
	void JDNGENAKMFJ(Rigidbody OEKAMIKGJCJ);

	[Cpp2IlInjected.Token(Token = "0x6000129")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void AHPFMPBNNKL(Rigidbody OEKAMIKGJCJ);
}
[Cpp2IlInjected.Token(Token = "0x2000017")]
public interface NDEJNDNEBID
{
	[Cpp2IlInjected.Token(Token = "0x4000018")]
	static bool CKJBHKIBKDO;

	[Cpp2IlInjected.Token(Token = "0x14000016")]
	event FIIMNHMKNMH DMHOGJALOCI;

	[Cpp2IlInjected.Token(Token = "0x600012C")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void IDNMFFEDDDN();

	[Cpp2IlInjected.Token(Token = "0x600012D")]
	[Cpp2IlInjected.Address(Slot = "3")]
	bool PGBDNOKPCJD();

	[Cpp2IlInjected.Token(Token = "0x600012E")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void PBHDOJBKPMC();

	[Cpp2IlInjected.Token(Token = "0x600012F")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void DHDDBOHNOOD();

	[Cpp2IlInjected.Token(Token = "0x6000130")]
	[Cpp2IlInjected.Address(Slot = "6")]
	bool KMNJDJCJHAC();

	[Cpp2IlInjected.Token(Token = "0x6000131")]
	[Cpp2IlInjected.Address(Slot = "7")]
	bool FNMLHEDFMOK();

	[Cpp2IlInjected.Token(Token = "0x6000132")]
	[Cpp2IlInjected.Address(Slot = "8")]
	void GKFAMOOJKBH(bool LLLEEKBGHKO);

	[Cpp2IlInjected.Token(Token = "0x6000133")]
	[Cpp2IlInjected.Address(Slot = "9")]
	void IPDLPKIGAIL();
}
[Cpp2IlInjected.Token(Token = "0x2000018")]
public interface HHGNGAAPGIO
{
	[Cpp2IlInjected.Token(Token = "0x1700004F")]
	Rigidbody CHKPFCFBIFF
	{
		[Cpp2IlInjected.Token(Token = "0x6000134")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000050")]
	bool MODBDBAJLOL
	{
		[Cpp2IlInjected.Token(Token = "0x6000136")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000135")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void IDNMFFEDDDN();

	[Cpp2IlInjected.Token(Token = "0x6000137")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void CDDNPCBBODL(object GFDDDAIMFOH);

	[Cpp2IlInjected.Token(Token = "0x6000138")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void MDHCFFHBIKL(object GFDDDAIMFOH);

	[Cpp2IlInjected.Token(Token = "0x6000139")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void ODPJMMIDBDH();
}
[Cpp2IlInjected.Token(Token = "0x2000019")]
public interface NKFJANAJGEK : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x17000051")]
	CJDPDAAMOBM MMEHAJFLOLP
	{
		[Cpp2IlInjected.Token(Token = "0x600013A")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
		[Cpp2IlInjected.Token(Token = "0x600013B")]
		[Cpp2IlInjected.Address(Slot = "1")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000052")]
	NEPEHFKKAHG GJFLFCKDPFG
	{
		[Cpp2IlInjected.Token(Token = "0x600013C")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
		[Cpp2IlInjected.Token(Token = "0x600013D")]
		[Cpp2IlInjected.Address(Slot = "3")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000053")]
	Vector3 CEBEECPEOGO
	{
		[Cpp2IlInjected.Token(Token = "0x600013E")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
		[Cpp2IlInjected.Token(Token = "0x600013F")]
		[Cpp2IlInjected.Address(Slot = "5")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000054")]
	Vector3 MNAOACFOFFC
	{
		[Cpp2IlInjected.Token(Token = "0x6000140")]
		[Cpp2IlInjected.Address(Slot = "6")]
		get;
		[Cpp2IlInjected.Token(Token = "0x6000141")]
		[Cpp2IlInjected.Address(Slot = "7")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000055")]
	Vector3 MPBGIMEBLAH
	{
		[Cpp2IlInjected.Token(Token = "0x6000142")]
		[Cpp2IlInjected.Address(Slot = "8")]
		get;
		[Cpp2IlInjected.Token(Token = "0x6000143")]
		[Cpp2IlInjected.Address(Slot = "9")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000056")]
	Vector3 FFGOEMCJOMJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000144")]
		[Cpp2IlInjected.Address(Slot = "10")]
		get;
		[Cpp2IlInjected.Token(Token = "0x6000145")]
		[Cpp2IlInjected.Address(Slot = "11")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000057")]
	float ILLCHEIADLB
	{
		[Cpp2IlInjected.Token(Token = "0x6000146")]
		[Cpp2IlInjected.Address(Slot = "12")]
		get;
		[Cpp2IlInjected.Token(Token = "0x6000147")]
		[Cpp2IlInjected.Address(Slot = "13")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000058")]
	bool NJMEINAJFDB
	{
		[Cpp2IlInjected.Token(Token = "0x6000148")]
		[Cpp2IlInjected.Address(Slot = "14")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000149")]
	[Cpp2IlInjected.Address(Slot = "15")]
	void IDNMFFEDDDN();

	[Cpp2IlInjected.Token(Token = "0x600014A")]
	[Cpp2IlInjected.Address(Slot = "16")]
	void MIIEKMLKNHP(object GFDDDAIMFOH);

	[Cpp2IlInjected.Token(Token = "0x600014B")]
	[Cpp2IlInjected.Address(Slot = "17")]
	void FHALJOPICEM(IPOBJHPAPLB IIMDKLGOCHN, Vector3 PDIJEFFPDPG, float HIFIKLNHOGN = float.PositiveInfinity);

	[Cpp2IlInjected.Token(Token = "0x600014C")]
	[Cpp2IlInjected.Address(Slot = "18")]
	void KDKEDIKDALM(PDEAKMCNOBP BHODJGJGDPL, Vector3 HDFLLIHEFEL, float BHOMNNEBJAB, float NFNKFEGBCDH = 8f, float BFCHCLEELBL = 1f);

	[Cpp2IlInjected.Token(Token = "0x600014D")]
	[Cpp2IlInjected.Address(Slot = "19")]
	void GJMOALLKOJC(IPOBJHPAPLB IIMDKLGOCHN, Vector3 KDHLIJMPIFF, float FJKPDIEAPAB = 7f, float CGBPKBEEFCI = 1f);

	[Cpp2IlInjected.Token(Token = "0x600014E")]
	[Cpp2IlInjected.Address(Slot = "20")]
	void EOHEMBCJBEF();

	[Cpp2IlInjected.Token(Token = "0x600014F")]
	[Cpp2IlInjected.Address(Slot = "21")]
	void IEENEHDMNDP();

	[Cpp2IlInjected.Token(Token = "0x6000150")]
	[Cpp2IlInjected.Address(Slot = "22")]
	void DMKJCHLEDNN();

	[Cpp2IlInjected.Token(Token = "0x6000151")]
	[Cpp2IlInjected.Address(Slot = "23")]
	void BLKJDILGPAN();

	[Cpp2IlInjected.Token(Token = "0x6000152")]
	[Cpp2IlInjected.Address(Slot = "24")]
	void JDNGENAKMFJ(Rigidbody OEKAMIKGJCJ);

	[Cpp2IlInjected.Token(Token = "0x6000153")]
	[Cpp2IlInjected.Address(Slot = "25")]
	Vector3 DMPOJLEPCJM(Vector3 PJFEPLADHFM);

	[Cpp2IlInjected.Token(Token = "0x6000154")]
	[Cpp2IlInjected.Address(Slot = "26")]
	void LDHFPHPCBIG(object GFDDDAIMFOH);

	[Cpp2IlInjected.Token(Token = "0x6000155")]
	[Cpp2IlInjected.Address(Slot = "27")]
	void ENLCBFECKGI(Vector3 GKNFGDJONME);

	[Cpp2IlInjected.Token(Token = "0x6000156")]
	[Cpp2IlInjected.Address(Slot = "28")]
	void EAGOLEOOLDD(Vector3 MPLGBPBMKDL, Vector3 JOHCPGENEAP);

	[Cpp2IlInjected.Token(Token = "0x6000157")]
	[Cpp2IlInjected.Address(Slot = "29")]
	void HMFOBNPECJD(Vector3 MKOHLGDKLKH, Vector3 BCOOKGPOLPI);

	[Cpp2IlInjected.Token(Token = "0x6000158")]
	[Cpp2IlInjected.Address(Slot = "30")]
	Vector3 CBFAIKHJJKJ(Vector3 LPNLMKHOCCP);

	[Cpp2IlInjected.Token(Token = "0x6000159")]
	[Cpp2IlInjected.Address(Slot = "31")]
	Vector3 JBOHEHCFJIJ(Vector3 EJHCENJMOAJ);
}
[Cpp2IlInjected.Token(Token = "0x200001A")]
[ServiceLifetime(Lifetime.Application)]
public interface APAALKIMDJM
{
	[Cpp2IlInjected.Token(Token = "0x17000059")]
	bool JBNNKOAFJGL
	{
		[Cpp2IlInjected.Token(Token = "0x600015A")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x600015B")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void MEEAGAACEHN(string MGECNFLHDHF);

	[Cpp2IlInjected.Token(Token = "0x600015C")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void DGMFJFGDPDJ(RigidbodyEx FBMIODACPPK, Action DMHPHEGJKMB);

	[Cpp2IlInjected.Token(Token = "0x600015D")]
	[Cpp2IlInjected.Address(Slot = "3")]
	GJPKPACEBLN OIBFHKCMIKI(int HPIEBGEDDCD);

	[Cpp2IlInjected.Token(Token = "0x600015E")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void CKCKPGDODMI(Vector3 HMDEFBMKMLC, float NDICEOFJGAN, Color AHIICABHHJO);
}
[Cpp2IlInjected.Token(Token = "0x200001B")]
[ServiceLifetime(Lifetime.Application)]
public interface LAPLJDMFFDB
{
	[Cpp2IlInjected.Token(Token = "0x1700005A")]
	APAALKIMDJM PNJBCOOHDNG
	{
		[Cpp2IlInjected.Token(Token = "0x600015F")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700005B")]
	AECGPMCLHFG DLBNJLFACIP
	{
		[Cpp2IlInjected.Token(Token = "0x6000160")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000161")]
	[Cpp2IlInjected.Address(Slot = "2")]
	MFIGOAEMMAF CLCLMIBBLAJ(RigidbodyEx FBMIODACPPK);
}
[Cpp2IlInjected.Token(Token = "0x200001C")]
public class EHFCEALLCDO : MFIGOAEMMAF, IDisposable, LKFEPBMFBOA
{
	[Cpp2IlInjected.Token(Token = "0x4000019")]
	public static bool IAOELMAMHEL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400001A")]
	internal readonly LAPLJDMFFDB PAOKFDJPALE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400001B")]
	internal HKHMGNIMBHB PCPALLGGNCI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400001C")]
	internal NEPFFIKMEOI ENFDBKFLKKJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400001D")]
	internal FBGDKAGAKLD NAIHFCBKIPK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400001E")]
	internal NKFJANAJGEK PJFEPLADHFM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x400001F")]
	internal OEHINJFEKGA MAEDMCHCGAH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000020")]
	internal IJEDNMNOMME FAJDLEBBLAJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000021")]
	internal NECKIKIOFMD CABLFIINPDB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000022")]
	internal OHBIIAGNIEI CKHNGMILNKN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x4000023")]
	internal NDEJNDNEBID HFAGEKMOCAO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x4000024")]
	internal DEFJPKLJLBE IJFIMHGMADE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x4000025")]
	internal HFPGPHALCME ILPBEEONMLL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x4000026")]
	internal JDHBKCDFGPA HOJOMGEINAH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
	[Cpp2IlInjected.Token(Token = "0x4000027")]
	internal JIDOCDIJGFP KLFDCJJEGLB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x4000028")]
	internal HHGNGAAPGIO OEKAMIKGJCJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
	[Cpp2IlInjected.Token(Token = "0x4000029")]
	internal HLHJKDPIEEG GMIADALJHOB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
	[Cpp2IlInjected.Token(Token = "0x400002A")]
	internal IDisposable IFFDHMGLMPL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
	[Cpp2IlInjected.Token(Token = "0x400002B")]
	private bool FMKLIPADAHB;

	[Cpp2IlInjected.Token(Token = "0x1700005C")]
	public GOLADBGGMAB NNJOHCGNJNP
	{
		[Cpp2IlInjected.Token(Token = "0x6000162")]
		[Cpp2IlInjected.Address(RVA = "0xA60530", Offset = "0xA5F530", VA = "0x180A60530", Slot = "22")]
		get
		{
			return default(GOLADBGGMAB);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700005D")]
	public EOEFLGKDFOB JANONHMEKPC
	{
		[Cpp2IlInjected.Token(Token = "0x6000163")]
		[Cpp2IlInjected.Address(RVA = "0xAC9300", Offset = "0xAC8300", VA = "0x180AC9300", Slot = "24")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000164")]
		[Cpp2IlInjected.Address(RVA = "0xB11FD0", Offset = "0xB10FD0", VA = "0x180B11FD0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700005E")]
	public GameObject HLLLIANPJBO
	{
		[Cpp2IlInjected.Token(Token = "0x6000165")]
		[Cpp2IlInjected.Address(RVA = "0xA62800", Offset = "0xA61800", VA = "0x180A62800", Slot = "25")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000166")]
		[Cpp2IlInjected.Address(RVA = "0xA628C0", Offset = "0xA618C0", VA = "0x180A628C0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700005F")]
	public Transform DBHNDLPLFNO
	{
		[Cpp2IlInjected.Token(Token = "0x6000167")]
		[Cpp2IlInjected.Address(RVA = "0xB12000", Offset = "0xB11000", VA = "0x180B12000", Slot = "26")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000168")]
		[Cpp2IlInjected.Address(RVA = "0xB12440", Offset = "0xB11440", VA = "0x180B12440")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000060")]
	public Rigidbody CHKPFCFBIFF
	{
		[Cpp2IlInjected.Token(Token = "0x6000169")]
		[Cpp2IlInjected.Address(RVA = "0x898A410", Offset = "0x8989410", VA = "0x18898A410", Slot = "23")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000061")]
	public MFIGOAEMMAF GDFCPOBJFDH
	{
		[Cpp2IlInjected.Token(Token = "0x600017A")]
		[Cpp2IlInjected.Address(RVA = "0x898F9F0", Offset = "0x898E9F0", VA = "0x18898F9F0", Slot = "27")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600017B")]
		[Cpp2IlInjected.Address(RVA = "0x898DC50", Offset = "0x898CC50", VA = "0x18898DC50", Slot = "28")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000062")]
	public int KCCFAOPCIDP
	{
		[Cpp2IlInjected.Token(Token = "0x600017C")]
		[Cpp2IlInjected.Address(RVA = "0x898FA40", Offset = "0x898EA40", VA = "0x18898FA40", Slot = "31")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000063")]
	public MFIGOAEMMAF AOHAMHAHFAH
	{
		[Cpp2IlInjected.Token(Token = "0x600017E")]
		[Cpp2IlInjected.Address(RVA = "0x898E210", Offset = "0x898D210", VA = "0x18898E210", Slot = "29")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000064")]
	public bool FKHKIDHBPAC
	{
		[Cpp2IlInjected.Token(Token = "0x600017F")]
		[Cpp2IlInjected.Address(RVA = "0x898F280", Offset = "0x898E280", VA = "0x18898F280", Slot = "32")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000065")]
	public bool OIEKHFOHMAM
	{
		[Cpp2IlInjected.Token(Token = "0x6000183")]
		[Cpp2IlInjected.Address(RVA = "0x89897D0", Offset = "0x89887D0", VA = "0x1889897D0", Slot = "33")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000066")]
	public bool DJDBGPECKIC
	{
		[Cpp2IlInjected.Token(Token = "0x6000184")]
		[Cpp2IlInjected.Address(RVA = "0x898E690", Offset = "0x898D690", VA = "0x18898E690", Slot = "34")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000067")]
	public CJDPDAAMOBM MMEHAJFLOLP
	{
		[Cpp2IlInjected.Token(Token = "0x6000185")]
		[Cpp2IlInjected.Address(RVA = "0x898B480", Offset = "0x898A480", VA = "0x18898B480", Slot = "35")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000186")]
		[Cpp2IlInjected.Address(RVA = "0x898A700", Offset = "0x8989700", VA = "0x18898A700", Slot = "36")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000068")]
	public NEPEHFKKAHG GJFLFCKDPFG
	{
		[Cpp2IlInjected.Token(Token = "0x6000187")]
		[Cpp2IlInjected.Address(RVA = "0x898FD10", Offset = "0x898ED10", VA = "0x18898FD10", Slot = "37")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000188")]
		[Cpp2IlInjected.Address(RVA = "0x898B870", Offset = "0x898A870", VA = "0x18898B870", Slot = "38")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000069")]
	public float ILLCHEIADLB
	{
		[Cpp2IlInjected.Token(Token = "0x6000189")]
		[Cpp2IlInjected.Address(RVA = "0x898F410", Offset = "0x898E410", VA = "0x18898F410", Slot = "39")]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x600018A")]
		[Cpp2IlInjected.Address(RVA = "0x898A7F0", Offset = "0x89897F0", VA = "0x18898A7F0", Slot = "40")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700006A")]
	public Vector3 MNAOACFOFFC
	{
		[Cpp2IlInjected.Token(Token = "0x600018B")]
		[Cpp2IlInjected.Address(RVA = "0x898AB40", Offset = "0x8989B40", VA = "0x18898AB40", Slot = "41")]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x600018C")]
		[Cpp2IlInjected.Address(RVA = "0x898A100", Offset = "0x8989100", VA = "0x18898A100", Slot = "42")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700006B")]
	public Vector3 FFGOEMCJOMJ
	{
		[Cpp2IlInjected.Token(Token = "0x600018D")]
		[Cpp2IlInjected.Address(RVA = "0x898A020", Offset = "0x8989020", VA = "0x18898A020", Slot = "43")]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x600018E")]
		[Cpp2IlInjected.Address(RVA = "0x898A1E0", Offset = "0x89891E0", VA = "0x18898A1E0", Slot = "44")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700006C")]
	public Vector3 CEBEECPEOGO
	{
		[Cpp2IlInjected.Token(Token = "0x600018F")]
		[Cpp2IlInjected.Address(RVA = "0x898D590", Offset = "0x898C590", VA = "0x18898D590", Slot = "45")]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x6000190")]
		[Cpp2IlInjected.Address(RVA = "0x898C8C0", Offset = "0x898B8C0", VA = "0x18898C8C0", Slot = "46")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700006D")]
	public Vector3 MPBGIMEBLAH
	{
		[Cpp2IlInjected.Token(Token = "0x6000191")]
		[Cpp2IlInjected.Address(RVA = "0x898A850", Offset = "0x8989850", VA = "0x18898A850", Slot = "47")]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x6000192")]
		[Cpp2IlInjected.Address(RVA = "0x898A5C0", Offset = "0x89895C0", VA = "0x18898A5C0", Slot = "48")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700006E")]
	public bool DPCAIJIEHEN
	{
		[Cpp2IlInjected.Token(Token = "0x6000193")]
		[Cpp2IlInjected.Address(RVA = "0x898E930", Offset = "0x898D930", VA = "0x18898E930", Slot = "49")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700006F")]
	public bool EOKLDEIAEOO
	{
		[Cpp2IlInjected.Token(Token = "0x6000194")]
		[Cpp2IlInjected.Address(RVA = "0x898F070", Offset = "0x898E070", VA = "0x18898F070", Slot = "50")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000070")]
	public bool PHDHLJLMIHD
	{
		[Cpp2IlInjected.Token(Token = "0x6000195")]
		[Cpp2IlInjected.Address(RVA = "0x898B520", Offset = "0x898A520", VA = "0x18898B520", Slot = "51")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000071")]
	public bool NJMEINAJFDB
	{
		[Cpp2IlInjected.Token(Token = "0x6000196")]
		[Cpp2IlInjected.Address(RVA = "0x898B4D0", Offset = "0x898A4D0", VA = "0x18898B4D0", Slot = "52")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000072")]
	public Vector3 DGPJNKHKOAH
	{
		[Cpp2IlInjected.Token(Token = "0x60001A7")]
		[Cpp2IlInjected.Address(RVA = "0x898F0D0", Offset = "0x898E0D0", VA = "0x18898F0D0", Slot = "53")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000073")]
	public Vector3 OCPCNFPMMKN
	{
		[Cpp2IlInjected.Token(Token = "0x60001A8")]
		[Cpp2IlInjected.Address(RVA = "0x8989ED0", Offset = "0x8988ED0", VA = "0x188989ED0", Slot = "54")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000074")]
	public Vector3 JHEJMAHNPBI
	{
		[Cpp2IlInjected.Token(Token = "0x60001AD")]
		[Cpp2IlInjected.Address(RVA = "0x898D8D0", Offset = "0x898C8D0", VA = "0x18898D8D0", Slot = "55")]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x60001AE")]
		[Cpp2IlInjected.Address(RVA = "0x898CC20", Offset = "0x898BC20", VA = "0x18898CC20", Slot = "56")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000075")]
	public Vector3 MHMKILICHPP
	{
		[Cpp2IlInjected.Token(Token = "0x60001AF")]
		[Cpp2IlInjected.Address(RVA = "0x898FDF0", Offset = "0x898EDF0", VA = "0x18898FDF0", Slot = "57")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000076")]
	public float AMGCMLCLCBG
	{
		[Cpp2IlInjected.Token(Token = "0x60001B0")]
		[Cpp2IlInjected.Address(RVA = "0x898B0A0", Offset = "0x898A0A0", VA = "0x18898B0A0", Slot = "58")]
		get
		{
			return default(float);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000077")]
	public float DPJEGOOLEIH
	{
		[Cpp2IlInjected.Token(Token = "0x60001B1")]
		[Cpp2IlInjected.Address(RVA = "0x898D540", Offset = "0x898C540", VA = "0x18898D540", Slot = "59")]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x60001B2")]
		[Cpp2IlInjected.Address(RVA = "0x898DE20", Offset = "0x898CE20", VA = "0x18898DE20", Slot = "60")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000078")]
	public Vector3 HOCIMGJPKJG
	{
		[Cpp2IlInjected.Token(Token = "0x60001B3")]
		[Cpp2IlInjected.Address(RVA = "0x898C360", Offset = "0x898B360", VA = "0x18898C360", Slot = "61")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000079")]
	public Quaternion EIJGCCEDODN
	{
		[Cpp2IlInjected.Token(Token = "0x60001B4")]
		[Cpp2IlInjected.Address(RVA = "0x898D800", Offset = "0x898C800", VA = "0x18898D800", Slot = "62")]
		get
		{
			return default(Quaternion);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700007A")]
	public float EECOPGNPCHA
	{
		[Cpp2IlInjected.Token(Token = "0x60001B9")]
		[Cpp2IlInjected.Address(RVA = "0x898BCD0", Offset = "0x898ACD0", VA = "0x18898BCD0", Slot = "64")]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x60001BA")]
		[Cpp2IlInjected.Address(RVA = "0x898D4E0", Offset = "0x898C4E0", VA = "0x18898D4E0", Slot = "65")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700007B")]
	public float ABDAAKPCHLE
	{
		[Cpp2IlInjected.Token(Token = "0x60001BB")]
		[Cpp2IlInjected.Address(RVA = "0x898E640", Offset = "0x898D640", VA = "0x18898E640", Slot = "66")]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x60001BC")]
		[Cpp2IlInjected.Address(RVA = "0x898BB50", Offset = "0x898AB50", VA = "0x18898BB50", Slot = "67")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700007C")]
	public bool AKBHMCCMMHA
	{
		[Cpp2IlInjected.Token(Token = "0x60001BD")]
		[Cpp2IlInjected.Address(RVA = "0x8989CB0", Offset = "0x8988CB0", VA = "0x188989CB0", Slot = "68")]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x60001BE")]
		[Cpp2IlInjected.Address(RVA = "0x898AF50", Offset = "0x8989F50", VA = "0x18898AF50", Slot = "69")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700007D")]
	public JEHFMNHABAI OAFIDMJJIDM
	{
		[Cpp2IlInjected.Token(Token = "0x60001C6")]
		[Cpp2IlInjected.Address(RVA = "0x898BD80", Offset = "0x898AD80", VA = "0x18898BD80", Slot = "70")]
		get
		{
			return default(JEHFMNHABAI);
		}
		[Cpp2IlInjected.Token(Token = "0x60001C7")]
		[Cpp2IlInjected.Address(RVA = "0x8989D00", Offset = "0x8988D00", VA = "0x188989D00", Slot = "71")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700007E")]
	public bool HBGAICGJHMM
	{
		[Cpp2IlInjected.Token(Token = "0x60001CA")]
		[Cpp2IlInjected.Address(RVA = "0x898D220", Offset = "0x898C220", VA = "0x18898D220", Slot = "72")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700007F")]
	public Transform BMDDMEMBCIP
	{
		[Cpp2IlInjected.Token(Token = "0x60001D0")]
		[Cpp2IlInjected.Address(RVA = "0xB12000", Offset = "0xB11000", VA = "0x180B12000", Slot = "73")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000080")]
	public Vector3 EFJMBKOHGHO
	{
		[Cpp2IlInjected.Token(Token = "0x60001D1")]
		[Cpp2IlInjected.Address(RVA = "0x898A9E0", Offset = "0x89899E0", VA = "0x18898A9E0", Slot = "74")]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x60001D2")]
		[Cpp2IlInjected.Address(RVA = "0x898CB70", Offset = "0x898BB70", VA = "0x18898CB70", Slot = "75")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000081")]
	public float JHLOPGGKKBI
	{
		[Cpp2IlInjected.Token(Token = "0x60001D3")]
		[Cpp2IlInjected.Address(RVA = "0x898B920", Offset = "0x898A920", VA = "0x18898B920", Slot = "76")]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x60001D4")]
		[Cpp2IlInjected.Address(RVA = "0x898A2C0", Offset = "0x89892C0", VA = "0x18898A2C0", Slot = "77")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000082")]
	public float GNGHPELMGIC
	{
		[Cpp2IlInjected.Token(Token = "0x60001D5")]
		[Cpp2IlInjected.Address(RVA = "0x898A3B0", Offset = "0x89893B0", VA = "0x18898A3B0", Slot = "78")]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x60001D6")]
		[Cpp2IlInjected.Address(RVA = "0x898D380", Offset = "0x898C380", VA = "0x18898D380", Slot = "79")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000083")]
	public Quaternion NAIEIHHDDLO
	{
		[Cpp2IlInjected.Token(Token = "0x60001D7")]
		[Cpp2IlInjected.Address(RVA = "0x898E3C0", Offset = "0x898D3C0", VA = "0x18898E3C0", Slot = "80")]
		get
		{
			return default(Quaternion);
		}
		[Cpp2IlInjected.Token(Token = "0x60001D8")]
		[Cpp2IlInjected.Address(RVA = "0x898EE30", Offset = "0x898DE30", VA = "0x18898EE30", Slot = "81")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000084")]
	public Vector3 KCFBPENHPIH
	{
		[Cpp2IlInjected.Token(Token = "0x60001D9")]
		[Cpp2IlInjected.Address(RVA = "0x898A930", Offset = "0x8989930", VA = "0x18898A930", Slot = "82")]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x60001DA")]
		[Cpp2IlInjected.Address(RVA = "0x898F950", Offset = "0x898E950", VA = "0x18898F950", Slot = "83")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000085")]
	public Quaternion JEKEGKDFCIB
	{
		[Cpp2IlInjected.Token(Token = "0x60001DB")]
		[Cpp2IlInjected.Address(RVA = "0x898EA90", Offset = "0x898DA90", VA = "0x18898EA90", Slot = "84")]
		get
		{
			return default(Quaternion);
		}
		[Cpp2IlInjected.Token(Token = "0x60001DC")]
		[Cpp2IlInjected.Address(RVA = "0x898DAF0", Offset = "0x898CAF0", VA = "0x18898DAF0", Slot = "85")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000086")]
	public RigidbodyConstraints LMOGEOKLEMJ
	{
		[Cpp2IlInjected.Token(Token = "0x60001E0")]
		[Cpp2IlInjected.Address(RVA = "0x898E370", Offset = "0x898D370", VA = "0x18898E370", Slot = "86")]
		get
		{
			return default(RigidbodyConstraints);
		}
		[Cpp2IlInjected.Token(Token = "0x60001E1")]
		[Cpp2IlInjected.Address(RVA = "0x898DB20", Offset = "0x898CB20", VA = "0x18898DB20", Slot = "87")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000087")]
	public bool CLKOFGBADDK
	{
		[Cpp2IlInjected.Token(Token = "0x60001E2")]
		[Cpp2IlInjected.Address(RVA = "0x898E6E0", Offset = "0x898D6E0", VA = "0x18898E6E0", Slot = "88")]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x60001E3")]
		[Cpp2IlInjected.Address(RVA = "0x898CF50", Offset = "0x898BF50", VA = "0x18898CF50", Slot = "89")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000088")]
	public CollisionDetectionMode OKCKKBNNDGG
	{
		[Cpp2IlInjected.Token(Token = "0x60001EC")]
		[Cpp2IlInjected.Address(RVA = "0x898BC10", Offset = "0x898AC10", VA = "0x18898BC10", Slot = "90")]
		get
		{
			return default(CollisionDetectionMode);
		}
		[Cpp2IlInjected.Token(Token = "0x60001ED")]
		[Cpp2IlInjected.Address(RVA = "0x898F990", Offset = "0x898E990", VA = "0x18898F990", Slot = "91")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000089")]
	public bool FAJLADPALHG
	{
		[Cpp2IlInjected.Token(Token = "0x60001EF")]
		[Cpp2IlInjected.Address(RVA = "0x898B730", Offset = "0x898A730", VA = "0x18898B730", Slot = "141")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700008A")]
	public bool HNJOCDCIFMO
	{
		[Cpp2IlInjected.Token(Token = "0x60001F0")]
		[Cpp2IlInjected.Address(RVA = "0x898E460", Offset = "0x898D460", VA = "0x18898E460", Slot = "92")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000017")]
	public event FIIMNHMKNMH PNOOHILMNMA
	{
		[Cpp2IlInjected.Token(Token = "0x6000174")]
		[Cpp2IlInjected.Address(RVA = "0x898D7A0", Offset = "0x898C7A0", VA = "0x18898D7A0", Slot = "4")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000175")]
		[Cpp2IlInjected.Address(RVA = "0x898FAB0", Offset = "0x898EAB0", VA = "0x18898FAB0", Slot = "5")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000018")]
	public event FIIMNHMKNMH PBICCJJDPLG
	{
		[Cpp2IlInjected.Token(Token = "0x6000176")]
		[Cpp2IlInjected.Address(RVA = "0x898E980", Offset = "0x898D980", VA = "0x18898E980", Slot = "6")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000177")]
		[Cpp2IlInjected.Address(RVA = "0x898B240", Offset = "0x898A240", VA = "0x18898B240", Slot = "7")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000019")]
	public event PALGGIDOPDJ ALJOINIAEFA
	{
		[Cpp2IlInjected.Token(Token = "0x6000178")]
		[Cpp2IlInjected.Address(RVA = "0x898CD00", Offset = "0x898BD00", VA = "0x18898CD00", Slot = "18")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000179")]
		[Cpp2IlInjected.Address(RVA = "0x898AAE0", Offset = "0x8989AE0", VA = "0x18898AAE0", Slot = "19")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400001A")]
	public event FIIMNHMKNMH NNMBHEJKLMO
	{
		[Cpp2IlInjected.Token(Token = "0x6000181")]
		[Cpp2IlInjected.Address(RVA = "0x898B990", Offset = "0x898A990", VA = "0x18898B990", Slot = "8")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000182")]
		[Cpp2IlInjected.Address(RVA = "0x898E7F0", Offset = "0x898D7F0", VA = "0x18898E7F0", Slot = "9")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400001B")]
	public event FIIMNHMKNMH ACKGCCKHMDK
	{
		[Cpp2IlInjected.Token(Token = "0x60001AB")]
		[Cpp2IlInjected.Address(RVA = "0x898BD20", Offset = "0x898AD20", VA = "0x18898BD20", Slot = "14")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60001AC")]
		[Cpp2IlInjected.Address(RVA = "0x8989D60", Offset = "0x8988D60", VA = "0x188989D60", Slot = "15")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400001C")]
	public event FIIMNHMKNMH DMHOGJALOCI
	{
		[Cpp2IlInjected.Token(Token = "0x60001BF")]
		[Cpp2IlInjected.Address(RVA = "0x898E1B0", Offset = "0x898D1B0", VA = "0x18898E1B0", Slot = "16")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60001C0")]
		[Cpp2IlInjected.Address(RVA = "0x898D480", Offset = "0x898C480", VA = "0x18898D480", Slot = "17")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400001D")]
	public event Action<FECJOJFDCBL, FECJOJFDCBL> NPPNIPCOAAB
	{
		[Cpp2IlInjected.Token(Token = "0x60001C4")]
		[Cpp2IlInjected.Address(RVA = "0x898C160", Offset = "0x898B160", VA = "0x18898C160", Slot = "20")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60001C5")]
		[Cpp2IlInjected.Address(RVA = "0x898D740", Offset = "0x898C740", VA = "0x18898D740", Slot = "21")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400001E")]
	public event FIIMNHMKNMH ACOJALPIMJC
	{
		[Cpp2IlInjected.Token(Token = "0x60001C8")]
		[Cpp2IlInjected.Address(RVA = "0x898A6A0", Offset = "0x89896A0", VA = "0x18898A6A0", Slot = "12")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60001C9")]
		[Cpp2IlInjected.Address(RVA = "0x898E260", Offset = "0x898D260", VA = "0x18898E260", Slot = "13")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400001F")]
	public event FIIMNHMKNMH PNCLDBFDLCI
	{
		[Cpp2IlInjected.Token(Token = "0x60001CE")]
		[Cpp2IlInjected.Address(RVA = "0x898C810", Offset = "0x898B810", VA = "0x18898C810", Slot = "10")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60001CF")]
		[Cpp2IlInjected.Address(RVA = "0x898E9E0", Offset = "0x898D9E0", VA = "0x18898E9E0", Slot = "11")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600016A")]
	[Cpp2IlInjected.Address(RVA = "0x898FF10", Offset = "0x898EF10", VA = "0x18898FF10")]
	public EHFCEALLCDO(GameObject GLGAAAMILBJ, RigidbodyEx FMMDFKIHIKP, LAPLJDMFFDB PAOKFDJPALE, [In] POOLCNKIBAH INCJDDLACNP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600016B")]
	[Cpp2IlInjected.Address(RVA = "0x898C440", Offset = "0x898B440", VA = "0x18898C440", Slot = "139")]
	protected virtual void HEIOLEMCKMC(LAPLJDMFFDB PAOKFDJPALE, POOLCNKIBAH INCJDDLACNP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600016C")]
	[Cpp2IlInjected.Address(RVA = "0x898AE50", Offset = "0x8989E50", VA = "0x18898AE50", Slot = "140")]
	public virtual void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600016D")]
	[Cpp2IlInjected.Address(RVA = "0x898CD60", Offset = "0x898BD60", VA = "0x18898CD60", Slot = "93")]
	public void IDNMFFEDDDN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600016E")]
	[Cpp2IlInjected.Address(RVA = "0x898FD60", Offset = "0x898ED60", VA = "0x18898FD60", Slot = "94")]
	public void PNAOLOMOOIO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600016F")]
	[Cpp2IlInjected.Address(RVA = "0x898CEF0", Offset = "0x898BEF0", VA = "0x18898CEF0", Slot = "95")]
	public void IGIOGBHBKAP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000170")]
	[Cpp2IlInjected.Address(RVA = "0x898A970", Offset = "0x8989970", VA = "0x18898A970", Slot = "96")]
	public void CODFBDJOOGP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000171")]
	[Cpp2IlInjected.Address(RVA = "0x898BEE0", Offset = "0x898AEE0", VA = "0x18898BEE0")]
	private void GKFAMOOJKBH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000172")]
	[Cpp2IlInjected.Address(RVA = "0x898DA70", Offset = "0x898CA70", VA = "0x18898DA70")]
	private void KFDAGIPLFIO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000173")]
	[Cpp2IlInjected.Address(RVA = "0x898BBB0", Offset = "0x898ABB0", VA = "0x18898BBB0")]
	private void FNMLHEDFMOK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600017D")]
	[Cpp2IlInjected.Address(RVA = "0x898F1A0", Offset = "0x898E1A0", VA = "0x18898F1A0", Slot = "30")]
	public MFIGOAEMMAF NNOGBOEKNJK(int HLGKMAPOEBE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000180")]
	[Cpp2IlInjected.Address(RVA = "0x8989FB0", Offset = "0x8988FB0", VA = "0x188989FB0", Slot = "98")]
	public void AKCKLCNBHIA(MFIGOAEMMAF IOALKPFEKEK, bool LPDEIPGKDOE = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000197")]
	[Cpp2IlInjected.Address(RVA = "0x898A350", Offset = "0x8989350", VA = "0x18898A350", Slot = "99")]
	public void BKHFHMPHKII(object GFDDDAIMFOH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000198")]
	[Cpp2IlInjected.Address(RVA = "0x898EF10", Offset = "0x898DF10", VA = "0x18898EF10", Slot = "100")]
	public void NGFIIFHOJBG(object GFDDDAIMFOH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000199")]
	[Cpp2IlInjected.Address(RVA = "0x898D120", Offset = "0x898C120", VA = "0x18898D120", Slot = "101")]
	public Vector3 JBOHEHCFJIJ(Vector3 EJHCENJMOAJ)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x600019A")]
	[Cpp2IlInjected.Address(RVA = "0x898A460", Offset = "0x8989460", VA = "0x18898A460", Slot = "102")]
	public Vector3 CBFAIKHJJKJ(Vector3 LPNLMKHOCCP)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x600019B")]
	[Cpp2IlInjected.Address(RVA = "0x898A3C0", Offset = "0x89893C0", VA = "0x18898A3C0", Slot = "103")]
	public void BLKJDILGPAN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600019C")]
	[Cpp2IlInjected.Address(RVA = "0x898CEA0", Offset = "0x898BEA0", VA = "0x18898CEA0", Slot = "104")]
	public void IEENEHDMNDP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600019D")]
	[Cpp2IlInjected.Address(RVA = "0x898B6E0", Offset = "0x898A6E0", VA = "0x18898B6E0", Slot = "105")]
	public void EOHEMBCJBEF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600019E")]
	[Cpp2IlInjected.Address(RVA = "0x898C9A0", Offset = "0x898B9A0", VA = "0x18898C9A0", Slot = "106")]
	public void HMFOBNPECJD(Vector3 MKOHLGDKLKH, Vector3 BCOOKGPOLPI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600019F")]
	[Cpp2IlInjected.Address(RVA = "0x898AFB0", Offset = "0x8989FB0", VA = "0x18898AFB0", Slot = "107")]
	public void EAGOLEOOLDD(Vector3 MPLGBPBMKDL, Vector3 JOHCPGENEAP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001A0")]
	[Cpp2IlInjected.Address(RVA = "0x898B600", Offset = "0x898A600", VA = "0x18898B600", Slot = "108")]
	public void ENLCBFECKGI(Vector3 GKNFGDJONME)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001A1")]
	[Cpp2IlInjected.Address(RVA = "0x898D9B0", Offset = "0x898C9B0", VA = "0x18898D9B0", Slot = "109")]
	public void KDKEDIKDALM(PDEAKMCNOBP BHODJGJGDPL, Vector3 HDFLLIHEFEL, float BHOMNNEBJAB, float NFNKFEGBCDH = 8f, float BFCHCLEELBL = 1f)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001A2")]
	[Cpp2IlInjected.Address(RVA = "0x898B9F0", Offset = "0x898A9F0", VA = "0x18898B9F0", Slot = "110")]
	public void FHALJOPICEM(IPOBJHPAPLB IIMDKLGOCHN, Vector3 PDIJEFFPDPG, float HIFIKLNHOGN = float.PositiveInfinity)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001A3")]
	[Cpp2IlInjected.Address(RVA = "0x898BDD0", Offset = "0x898ADD0", VA = "0x18898BDD0", Slot = "111")]
	[Obsolete("Deprecated. Still exists to support deprecated CV2 chips. Use ApplyAngularVelocityChange.")]
	public void GJMOALLKOJC(IPOBJHPAPLB IIMDKLGOCHN, Vector3 KDHLIJMPIFF, float FJKPDIEAPAB = 7f, float CGBPKBEEFCI = 1f)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001A4")]
	[Cpp2IlInjected.Address(RVA = "0x898AD50", Offset = "0x8989D50", VA = "0x18898AD50", Slot = "112")]
	public Vector3 DMPOJLEPCJM(Vector3 IOALKPFEKEK)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x60001A5")]
	[Cpp2IlInjected.Address(RVA = "0x898CFB0", Offset = "0x898BFB0", VA = "0x18898CFB0", Slot = "113")]
	public Vector3 INLIJDBNMNK(Vector3 IOALKPFEKEK)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x60001A6")]
	[Cpp2IlInjected.Address(RVA = "0x898AD00", Offset = "0x8989D00", VA = "0x18898AD00", Slot = "114")]
	public void DMKJCHLEDNN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001A9")]
	[Cpp2IlInjected.Address(RVA = "0x898BC60", Offset = "0x898AC60", VA = "0x18898BC60", Slot = "115")]
	public void FOPOGIAODMJ(MFIGOAEMMAF AJICGEOMBJL, object GFDDDAIMFOH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001AA")]
	[Cpp2IlInjected.Address(RVA = "0x898E790", Offset = "0x898D790", VA = "0x18898E790", Slot = "116")]
	public void MECAPMPJANI(object GFDDDAIMFOH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001B5")]
	[Cpp2IlInjected.Address(RVA = "0x898AC20", Offset = "0x8989C20", VA = "0x18898AC20", Slot = "63")]
	public void DKLLEIPOFLE((Quaternion rot, Vector3 moments) MOHIENDLLGP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001B6")]
	[Cpp2IlInjected.Address(RVA = "0x898B8D0", Offset = "0x898A8D0", VA = "0x18898B8D0", Slot = "117")]
	public void FANGIMEHNDB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001B7")]
	[Cpp2IlInjected.Address(RVA = "0x8989820", Offset = "0x8988820", VA = "0x188989820", Slot = "118")]
	public void ADJGMOJPIGC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001B8")]
	[Cpp2IlInjected.Address(RVA = "0x898F580", Offset = "0x898E580", VA = "0x18898F580", Slot = "119")]
	public void OHOPNDOPGNC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001C1")]
	[Cpp2IlInjected.Address(RVA = "0x898FB10", Offset = "0x898EB10", VA = "0x18898FB10", Slot = "120")]
	public bool PGBDNOKPCJD()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001C2")]
	[Cpp2IlInjected.Address(RVA = "0x898AA90", Offset = "0x8989A90", VA = "0x18898AA90", Slot = "97")]
	public void DHDDBOHNOOD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001C3")]
	[Cpp2IlInjected.Address(RVA = "0x898D0B0", Offset = "0x898C0B0", VA = "0x18898D0B0", Slot = "121")]
	public void IPDLPKIGAIL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001CB")]
	[Cpp2IlInjected.Address(RVA = "0x898E5E0", Offset = "0x898D5E0", VA = "0x18898E5E0", Slot = "122")]
	public void MBKNGPCCHDF(object GFDDDAIMFOH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001CC")]
	[Cpp2IlInjected.Address(RVA = "0x898BAF0", Offset = "0x898AAF0", VA = "0x18898BAF0", Slot = "123")]
	public void FJHOMGODMDJ(object GFDDDAIMFOH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001CD")]
	[Cpp2IlInjected.Address(RVA = "0x898C2F0", Offset = "0x898B2F0", VA = "0x18898C2F0", Slot = "124")]
	public void GLIAEMFMKNK(object GFDDDAIMFOH, bool NALIKJHDOEC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001DD")]
	[Cpp2IlInjected.Address(RVA = "0x898DE80", Offset = "0x898CE80", VA = "0x18898DE80", Slot = "125")]
	public void LECOOJEKMAC(Vector3 JEDFBKNAHJC, Quaternion GNCFNEMFPLP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001DE")]
	[Cpp2IlInjected.Address(RVA = "0x898C1C0", Offset = "0x898B1C0", VA = "0x18898C1C0", Slot = "126")]
	public void GKPLKLEHMBK(Vector3 JFMFLMJAIHA, Quaternion FPFHCEKDEIC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001DF")]
	[Cpp2IlInjected.Address(RVA = "0x898F530", Offset = "0x898E530", VA = "0x18898F530", Slot = "127")]
	public bool OHKKGLFGECJ(float IOPKIIHMCNB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001E4")]
	[Cpp2IlInjected.Address(RVA = "0x898F220", Offset = "0x898E220", VA = "0x18898F220", Slot = "128")]
	public void NPDNOHFBENH(object GFDDDAIMFOH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001E5")]
	[Cpp2IlInjected.Address(RVA = "0x898B930", Offset = "0x898A930", VA = "0x18898B930", Slot = "129")]
	public void FDDNIOOIKLE(object GFDDDAIMFOH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001E6")]
	[Cpp2IlInjected.Address(RVA = "0x898A560", Offset = "0x8989560", VA = "0x18898A560", Slot = "130")]
	public void CDDNPCBBODL(object GFDDDAIMFOH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001E7")]
	[Cpp2IlInjected.Address(RVA = "0x898E730", Offset = "0x898D730", VA = "0x18898E730", Slot = "131")]
	public void MDHCFFHBIKL(object GFDDDAIMFOH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001E8")]
	[Cpp2IlInjected.Address(RVA = "0x898C730", Offset = "0x898B730", VA = "0x18898C730", Slot = "132")]
	public void HEMDJAKLKFB(Vector3 HOJOMGEINAH, ForceMode DLJNDNGFIPO = ForceMode.Force)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001E9")]
	[Cpp2IlInjected.Address(RVA = "0x8989DC0", Offset = "0x8988DC0", VA = "0x188989DC0", Slot = "133")]
	public void AIADFLLFLEP(Vector3 HOJOMGEINAH, Vector3 EBGKGBGFPOC, ForceMode DLJNDNGFIPO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001EA")]
	[Cpp2IlInjected.Address(RVA = "0x898CA90", Offset = "0x898BA90", VA = "0x18898CA90", Slot = "134")]
	public void HMNBOIPBKPM(Vector3 LAOLJOAKMLI, ForceMode DLJNDNGFIPO = ForceMode.Force)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001EB")]
	[Cpp2IlInjected.Address(RVA = "0x898E850", Offset = "0x898D850", VA = "0x18898E850", Slot = "135")]
	public void MGKIMILNCCG(Vector3 LAOLJOAKMLI, ForceMode DLJNDNGFIPO = ForceMode.Force)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001EE")]
	[Cpp2IlInjected.Address(RVA = "0x898EF70", Offset = "0x898DF70", VA = "0x18898EF70", Slot = "136")]
	public bool NIECBDANKIP(Vector3 NBFEGPDMMPI, [Out] RaycastHit CPCOHHMIMEG, float OAGBEPAKAEK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001F1")]
	[Cpp2IlInjected.Address(RVA = "0x898A990", Offset = "0x8989990", VA = "0x18898A990", Slot = "137")]
	public void DAEOFNOBLFE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001F2")]
	[Cpp2IlInjected.Address(RVA = "0x898FED0", Offset = "0x898EED0", VA = "0x18898FED0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001F3")]
	[Cpp2IlInjected.Address(RVA = "0x898DB80", Offset = "0x898CB80", VA = "0x18898DB80")]
	private void KHFFLOAGPCH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001F4")]
	[Cpp2IlInjected.Address(RVA = "0x898D270", Offset = "0x898C270", VA = "0x18898D270")]
	private void JDFDPEPEGGA(MFIGOAEMMAF EBJBKAEFOPM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001F5")]
	[Cpp2IlInjected.Address(RVA = "0x898B2A0", Offset = "0x898A2A0", VA = "0x18898B2A0")]
	private void EIMCIGNHEKF(MFIGOAEMMAF EBJBKAEFOPM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001F6")]
	[Cpp2IlInjected.Address(RVA = "0x898E2C0", Offset = "0x898D2C0", VA = "0x18898E2C0")]
	private void LMDBFFJEODH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001F7")]
	[Cpp2IlInjected.Address(RVA = "0x898E080", Offset = "0x898D080", VA = "0x18898E080")]
	private void LFPKGKMCGJF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001F8")]
	[Cpp2IlInjected.Address(RVA = "0x898FB60", Offset = "0x898EB60", VA = "0x18898FB60")]
	private void PLEDMNGPLLK(MFIGOAEMMAF NBJIPLGHAHH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001F9")]
	[Cpp2IlInjected.Address(RVA = "0x898D670", Offset = "0x898C670", VA = "0x18898D670")]
	private void JODKHMDLHCG(MFIGOAEMMAF EBJBKAEFOPM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001FA")]
	[Cpp2IlInjected.Address(RVA = "0x898F460", Offset = "0x898E460", VA = "0x18898F460")]
	private void OHKCJDBEEIM(MFIGOAEMMAF EBJBKAEFOPM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001FB")]
	[Cpp2IlInjected.Address(RVA = "0x898B0F0", Offset = "0x898A0F0", VA = "0x18898B0F0")]
	private void EBKNFMMMIBA(EOEFLGKDFOB EBJBKAEFOPM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001FC")]
	[Cpp2IlInjected.Address(RVA = "0x8989870", Offset = "0x8988870", VA = "0x188989870", Slot = "142")]
	protected virtual void ADMCHLOJJBO(EOEFLGKDFOB FBMIODACPPK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001FD")]
	[Cpp2IlInjected.Address(RVA = "0x898EAD0", Offset = "0x898DAD0", VA = "0x18898EAD0")]
	protected void NCLKLHJKAJI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001FE")]
	[Cpp2IlInjected.Address(RVA = "0x898F5D0", Offset = "0x898E5D0", VA = "0x18898F5D0")]
	protected void OHPHILEDCOG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001FF")]
	[Cpp2IlInjected.Address(RVA = "0x898F2E0", Offset = "0x898E2E0", VA = "0x18898F2E0")]
	private void OACAKJMKEBH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000200")]
	[Cpp2IlInjected.Address(RVA = "0x898DCB0", Offset = "0x898CCB0", VA = "0x18898DCB0")]
	private void LAFCJJMJMOA()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001D")]
internal static class ICBMGOGPMBM
{
	[Cpp2IlInjected.Token(Token = "0x6000201")]
	[Cpp2IlInjected.Address(RVA = "0x8994660", Offset = "0x8993660", VA = "0x188994660")]
	public static MFIGOAEMMAF ABJLOKFDBJB(this MFIGOAEMMAF FBMIODACPPK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000202")]
	[Cpp2IlInjected.Address(RVA = "0x8994720", Offset = "0x8993720", VA = "0x188994720")]
	public static bool IIODLKBKLOI(this MFIGOAEMMAF FBMIODACPPK, MFIGOAEMMAF EMENNBOEONK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000203")]
	[Cpp2IlInjected.Address(RVA = "0x8994810", Offset = "0x8993810", VA = "0x188994810")]
	public static bool KNANDAKILLP(this MFIGOAEMMAF FBMIODACPPK, MFIGOAEMMAF BCPBENAFFCB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000204")]
	[Cpp2IlInjected.Address(RVA = "0x89947C0", Offset = "0x89937C0", VA = "0x1889947C0")]
	public static EOEFLGKDFOB KIPGGLGNMIJ(this MFIGOAEMMAF JOEHPNNMIOL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000205")]
	[Cpp2IlInjected.Address(RVA = "0x89948B0", Offset = "0x89938B0", VA = "0x1889948B0")]
	public static EHFCEALLCDO OGBHHLDCPHD(this MFIGOAEMMAF JOEHPNNMIOL)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200001E")]
public class DCBAJFGNKCB : AECGPMCLHFG
{
	[Cpp2IlInjected.Token(Token = "0x6000206")]
	[Cpp2IlInjected.Address(RVA = "0x8989730", Offset = "0x8988730", VA = "0x188989730", Slot = "19")]
	public MFIGOAEMMAF CLCLMIBBLAJ(RigidbodyEx FBMIODACPPK, POOLCNKIBAH INCJDDLACNP, LAPLJDMFFDB PAOKFDJPALE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000207")]
	[Cpp2IlInjected.Address(RVA = "0xA60530", Offset = "0xA5F530", VA = "0x180A60530", Slot = "4")]
	public HKHMGNIMBHB KKAICCBLMME(MFIGOAEMMAF JOEHPNNMIOL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000208")]
	[Cpp2IlInjected.Address(RVA = "0xA60530", Offset = "0xA5F530", VA = "0x180A60530", Slot = "5")]
	public NKFJANAJGEK IHKHJBNKMOL(MFIGOAEMMAF JOEHPNNMIOL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000209")]
	[Cpp2IlInjected.Address(RVA = "0xA60530", Offset = "0xA5F530", VA = "0x180A60530", Slot = "6")]
	public OEHINJFEKGA CMDCHECMNHH(MFIGOAEMMAF JOEHPNNMIOL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600020A")]
	[Cpp2IlInjected.Address(RVA = "0xA60530", Offset = "0xA5F530", VA = "0x180A60530", Slot = "7")]
	public NECKIKIOFMD DCMJMMLJBOI(MFIGOAEMMAF JOEHPNNMIOL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600020B")]
	[Cpp2IlInjected.Address(RVA = "0xA60530", Offset = "0xA5F530", VA = "0x180A60530", Slot = "8")]
	public NDEJNDNEBID KLFPNHHMPIE(MFIGOAEMMAF JOEHPNNMIOL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600020C")]
	[Cpp2IlInjected.Address(RVA = "0xA60530", Offset = "0xA5F530", VA = "0x180A60530", Slot = "9")]
	public DEFJPKLJLBE JMLIMKFFLKM(MFIGOAEMMAF JOEHPNNMIOL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600020D")]
	[Cpp2IlInjected.Address(RVA = "0xA60530", Offset = "0xA5F530", VA = "0x180A60530", Slot = "10")]
	public HFPGPHALCME NKKNKKNOIME(MFIGOAEMMAF JOEHPNNMIOL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600020E")]
	[Cpp2IlInjected.Address(RVA = "0xA60530", Offset = "0xA5F530", VA = "0x180A60530", Slot = "11")]
	public JDHBKCDFGPA JMGOHIAIBAF(MFIGOAEMMAF JOEHPNNMIOL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600020F")]
	[Cpp2IlInjected.Address(RVA = "0xA60530", Offset = "0xA5F530", VA = "0x180A60530", Slot = "12")]
	public HLHJKDPIEEG CFAAEONCFLF(MFIGOAEMMAF JOEHPNNMIOL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000210")]
	[Cpp2IlInjected.Address(RVA = "0xA60530", Offset = "0xA5F530", VA = "0x180A60530", Slot = "13")]
	public OHBIIAGNIEI KNOCJMNGFPO(MFIGOAEMMAF JOEHPNNMIOL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000211")]
	[Cpp2IlInjected.Address(RVA = "0xA60530", Offset = "0xA5F530", VA = "0x180A60530")]
	public HHGNGAAPGIO KKFCCMOLINI(MFIGOAEMMAF JOEHPNNMIOL, [In] POOLCNKIBAH INCJDDLACNP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000212")]
	[Cpp2IlInjected.Address(RVA = "0xA60530", Offset = "0xA5F530", VA = "0x180A60530")]
	public FBGDKAGAKLD OPMFGCKMPBP(MFIGOAEMMAF JOEHPNNMIOL, [In] POOLCNKIBAH INCJDDLACNP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000213")]
	[Cpp2IlInjected.Address(RVA = "0xA60530", Offset = "0xA5F530", VA = "0x180A60530")]
	public NEPFFIKMEOI KLFHMIOJFGJ(MFIGOAEMMAF JOEHPNNMIOL, [In] POOLCNKIBAH INCJDDLACNP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000214")]
	[Cpp2IlInjected.Address(RVA = "0xA60530", Offset = "0xA5F530", VA = "0x180A60530")]
	public IJEDNMNOMME BAMBMADBICM(MFIGOAEMMAF JOEHPNNMIOL, [In] POOLCNKIBAH INCJDDLACNP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000215")]
	[Cpp2IlInjected.Address(RVA = "0xA60530", Offset = "0xA5F530", VA = "0x180A60530")]
	public JIDOCDIJGFP JFKOGBGNMIJ(MFIGOAEMMAF JOEHPNNMIOL, [In] POOLCNKIBAH INCJDDLACNP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000216")]
	[Cpp2IlInjected.Address(RVA = "0xA6E050", Offset = "0xA6D050", VA = "0x180A6E050")]
	public DCBAJFGNKCB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000217")]
	[Cpp2IlInjected.Address(RVA = "0xA60530", Offset = "0xA5F530", VA = "0x180A60530", Slot = "14")]
	private HHGNGAAPGIO CFFMAMJACOL(MFIGOAEMMAF JOEHPNNMIOL, [In] POOLCNKIBAH INCJDDLACNP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000218")]
	[Cpp2IlInjected.Address(RVA = "0xA60530", Offset = "0xA5F530", VA = "0x180A60530", Slot = "15")]
	private FBGDKAGAKLD AHDCLHIELFG(MFIGOAEMMAF JOEHPNNMIOL, [In] POOLCNKIBAH INCJDDLACNP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000219")]
	[Cpp2IlInjected.Address(RVA = "0xA60530", Offset = "0xA5F530", VA = "0x180A60530", Slot = "16")]
	private NEPFFIKMEOI IMAMHOFLCPG(MFIGOAEMMAF JOEHPNNMIOL, [In] POOLCNKIBAH INCJDDLACNP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600021A")]
	[Cpp2IlInjected.Address(RVA = "0xA60530", Offset = "0xA5F530", VA = "0x180A60530", Slot = "17")]
	private IJEDNMNOMME KKKIJLPFKHH(MFIGOAEMMAF JOEHPNNMIOL, [In] POOLCNKIBAH INCJDDLACNP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600021B")]
	[Cpp2IlInjected.Address(RVA = "0xA60530", Offset = "0xA5F530", VA = "0x180A60530", Slot = "18")]
	private JIDOCDIJGFP KNLMDKPLIKG(MFIGOAEMMAF JOEHPNNMIOL, [In] POOLCNKIBAH INCJDDLACNP)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200001F")]
[RegisterService(typeof(AECGPMCLHFG), new string[] { })]
public class NPGJFDBIBIL : AECGPMCLHFG, PJNGLGAADAH
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000030")]
	private readonly AECGPMCLHFG BBOPKFGENBK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000031")]
	private readonly AECGPMCLHFG PKGINIEIOJA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000032")]
	private GCKIEPKGGOK OAKHLIJBMNB;

	[Cpp2IlInjected.Token(Token = "0x1700008B")]
	private AECGPMCLHFG DLBNJLFACIP
	{
		[Cpp2IlInjected.Token(Token = "0x600021D")]
		[Cpp2IlInjected.Address(RVA = "0x899CEF0", Offset = "0x899BEF0", VA = "0x18899CEF0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600021C")]
	[Cpp2IlInjected.Address(RVA = "0x899CAD0", Offset = "0x899BAD0", VA = "0x18899CAD0", Slot = "20")]
	public void InitReferences(BLPLIKKLKBG CCGPMJFFCDG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600021E")]
	[Cpp2IlInjected.Address(RVA = "0x899CD10", Offset = "0x899BD10", VA = "0x18899CD10", Slot = "4")]
	public HKHMGNIMBHB KKAICCBLMME(MFIGOAEMMAF JOEHPNNMIOL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600021F")]
	[Cpp2IlInjected.Address(RVA = "0x899C980", Offset = "0x899B980", VA = "0x18899C980", Slot = "5")]
	public NKFJANAJGEK IHKHJBNKMOL(MFIGOAEMMAF JOEHPNNMIOL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000220")]
	[Cpp2IlInjected.Address(RVA = "0x899C840", Offset = "0x899B840", VA = "0x18899C840", Slot = "6")]
	public OEHINJFEKGA CMDCHECMNHH(MFIGOAEMMAF JOEHPNNMIOL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000221")]
	[Cpp2IlInjected.Address(RVA = "0x899C8E0", Offset = "0x899B8E0", VA = "0x18899C8E0", Slot = "7")]
	public NECKIKIOFMD DCMJMMLJBOI(MFIGOAEMMAF JOEHPNNMIOL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000222")]
	[Cpp2IlInjected.Address(RVA = "0x899CDB0", Offset = "0x899BDB0", VA = "0x18899CDB0", Slot = "8")]
	public NDEJNDNEBID KLFPNHHMPIE(MFIGOAEMMAF JOEHPNNMIOL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000223")]
	[Cpp2IlInjected.Address(RVA = "0x899CC70", Offset = "0x899BC70", VA = "0x18899CC70", Slot = "9")]
	public DEFJPKLJLBE JMLIMKFFLKM(MFIGOAEMMAF JOEHPNNMIOL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000224")]
	[Cpp2IlInjected.Address(RVA = "0x899CF50", Offset = "0x899BF50", VA = "0x18899CF50", Slot = "10")]
	public HFPGPHALCME NKKNKKNOIME(MFIGOAEMMAF JOEHPNNMIOL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000225")]
	[Cpp2IlInjected.Address(RVA = "0x899CBD0", Offset = "0x899BBD0", VA = "0x18899CBD0", Slot = "11")]
	public JDHBKCDFGPA JMGOHIAIBAF(MFIGOAEMMAF JOEHPNNMIOL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000226")]
	[Cpp2IlInjected.Address(RVA = "0x899C5A0", Offset = "0x899B5A0", VA = "0x18899C5A0", Slot = "12")]
	public HLHJKDPIEEG CFAAEONCFLF(MFIGOAEMMAF JOEHPNNMIOL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000227")]
	[Cpp2IlInjected.Address(RVA = "0x899CE50", Offset = "0x899BE50", VA = "0x18899CE50", Slot = "13")]
	public OHBIIAGNIEI KNOCJMNGFPO(MFIGOAEMMAF JOEHPNNMIOL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000228")]
	[Cpp2IlInjected.Address(RVA = "0x899C640", Offset = "0x899B640", VA = "0x18899C640")]
	public HHGNGAAPGIO KKFCCMOLINI(MFIGOAEMMAF JOEHPNNMIOL, [In] POOLCNKIBAH INCJDDLACNP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000229")]
	[Cpp2IlInjected.Address(RVA = "0x899C440", Offset = "0x899B440", VA = "0x18899C440")]
	public FBGDKAGAKLD OPMFGCKMPBP(MFIGOAEMMAF JOEHPNNMIOL, [In] POOLCNKIBAH INCJDDLACNP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600022A")]
	[Cpp2IlInjected.Address(RVA = "0x899CA20", Offset = "0x899BA20", VA = "0x18899CA20")]
	public NEPFFIKMEOI KLFHMIOJFGJ(MFIGOAEMMAF JOEHPNNMIOL, [In] POOLCNKIBAH INCJDDLACNP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600022B")]
	[Cpp2IlInjected.Address(RVA = "0x899C4F0", Offset = "0x899B4F0", VA = "0x18899C4F0")]
	public IJEDNMNOMME BAMBMADBICM(MFIGOAEMMAF JOEHPNNMIOL, [In] POOLCNKIBAH INCJDDLACNP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600022C")]
	[Cpp2IlInjected.Address(RVA = "0x899CB20", Offset = "0x899BB20", VA = "0x18899CB20")]
	public JIDOCDIJGFP JFKOGBGNMIJ(MFIGOAEMMAF JOEHPNNMIOL, [In] POOLCNKIBAH INCJDDLACNP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600022D")]
	[Cpp2IlInjected.Address(RVA = "0x899C6F0", Offset = "0x899B6F0", VA = "0x18899C6F0", Slot = "19")]
	public MFIGOAEMMAF CLCLMIBBLAJ(RigidbodyEx FBMIODACPPK, POOLCNKIBAH INCJDDLACNP, LAPLJDMFFDB PAOKFDJPALE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600022E")]
	[Cpp2IlInjected.Address(RVA = "0x899CFF0", Offset = "0x899BFF0", VA = "0x18899CFF0")]
	public NPGJFDBIBIL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600022F")]
	[Cpp2IlInjected.Address(RVA = "0x899C640", Offset = "0x899B640", VA = "0x18899C640", Slot = "14")]
	private HHGNGAAPGIO CFFMAMJACOL(MFIGOAEMMAF JOEHPNNMIOL, [In] POOLCNKIBAH INCJDDLACNP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000230")]
	[Cpp2IlInjected.Address(RVA = "0x899C440", Offset = "0x899B440", VA = "0x18899C440", Slot = "15")]
	private FBGDKAGAKLD AHDCLHIELFG(MFIGOAEMMAF JOEHPNNMIOL, [In] POOLCNKIBAH INCJDDLACNP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000231")]
	[Cpp2IlInjected.Address(RVA = "0x899CA20", Offset = "0x899BA20", VA = "0x18899CA20", Slot = "16")]
	private NEPFFIKMEOI IMAMHOFLCPG(MFIGOAEMMAF JOEHPNNMIOL, [In] POOLCNKIBAH INCJDDLACNP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000232")]
	[Cpp2IlInjected.Address(RVA = "0x899C4F0", Offset = "0x899B4F0", VA = "0x18899C4F0", Slot = "17")]
	private IJEDNMNOMME KKKIJLPFKHH(MFIGOAEMMAF JOEHPNNMIOL, [In] POOLCNKIBAH INCJDDLACNP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000233")]
	[Cpp2IlInjected.Address(RVA = "0x899CB20", Offset = "0x899BB20", VA = "0x18899CB20", Slot = "18")]
	private JIDOCDIJGFP KNLMDKPLIKG(MFIGOAEMMAF JOEHPNNMIOL, [In] POOLCNKIBAH INCJDDLACNP)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000020")]
public interface EKHMNDOBBMI : HKHMGNIMBHB, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x6000234")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void BDMFDANLNLE(MFIGOAEMMAF FBMIODACPPK);

	[Cpp2IlInjected.Token(Token = "0x6000235")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void ABLMAADCNKL(MFIGOAEMMAF FBMIODACPPK);

	[Cpp2IlInjected.Token(Token = "0x6000236")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void MPGCCNCHLCN(MFIGOAEMMAF NBJIPLGHAHH);

	[Cpp2IlInjected.Token(Token = "0x6000237")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void KDIFJNJPNAH(MFIGOAEMMAF NBJIPLGHAHH);
}
[Cpp2IlInjected.Token(Token = "0x2000021")]
public interface LLAIFJBJCIN : OEHINJFEKGA
{
	[Cpp2IlInjected.Token(Token = "0x1700008C")]
	ELCBPAGODNE<MFIGOAEMMAF> EHMPNPPHJDL
	{
		[Cpp2IlInjected.Token(Token = "0x6000238")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700008D")]
	MFIGOAEMMAF FGLEJGIFNDG
	{
		[Cpp2IlInjected.Token(Token = "0x6000239")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000022")]
public interface GJPLLGFKNGH : IJEDNMNOMME
{
	[Cpp2IlInjected.Token(Token = "0x600023A")]
	[Cpp2IlInjected.Address(Slot = "0")]
	(float, Vector3) MPCMPBLOIDM(Rigidbody KNCJHMCBCCC);
}
[Cpp2IlInjected.Token(Token = "0x2000023")]
public interface HIMKNODIKDO : FBGDKAGAKLD, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x1700008E")]
	RRNetworkView GJNJMACHHGD
	{
		[Cpp2IlInjected.Token(Token = "0x600023B")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000024")]
internal sealed class PBPBACINCAA : HLHJKDPIEEG
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000033")]
	private readonly EHFCEALLCDO FBMIODACPPK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000034")]
	private CollisionDetectionMode JLLLJIMNLMF;

	[Cpp2IlInjected.Token(Token = "0x1700008F")]
	private Rigidbody CHKPFCFBIFF
	{
		[Cpp2IlInjected.Token(Token = "0x600023C")]
		[Cpp2IlInjected.Address(RVA = "0x89974F0", Offset = "0x89964F0", VA = "0x1889974F0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000090")]
	public CollisionDetectionMode OKCKKBNNDGG
	{
		[Cpp2IlInjected.Token(Token = "0x6000240")]
		[Cpp2IlInjected.Address(RVA = "0x899FD70", Offset = "0x899ED70", VA = "0x18899FD70", Slot = "4")]
		get
		{
			return default(CollisionDetectionMode);
		}
		[Cpp2IlInjected.Token(Token = "0x6000241")]
		[Cpp2IlInjected.Address(RVA = "0x89A0180", Offset = "0x899F180", VA = "0x1889A0180", Slot = "5")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600023D")]
	[Cpp2IlInjected.Address(RVA = "0x8991030", Offset = "0x8990030", VA = "0x188991030")]
	public PBPBACINCAA(MFIGOAEMMAF FBMIODACPPK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600023E")]
	[Cpp2IlInjected.Address(RVA = "0x899FE80", Offset = "0x899EE80", VA = "0x18899FE80", Slot = "6")]
	public void IDNMFFEDDDN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600023F")]
	[Cpp2IlInjected.Address(RVA = "0x899FF90", Offset = "0x899EF90", VA = "0x18899FF90", Slot = "9")]
	public void JDNGENAKMFJ(Rigidbody OEKAMIKGJCJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000242")]
	[Cpp2IlInjected.Address(RVA = "0x89A0010", Offset = "0x899F010", VA = "0x1889A0010", Slot = "7")]
	public void MFLAIIIKNJO(bool MCFBHOHCNGE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000243")]
	[Cpp2IlInjected.Address(RVA = "0x899FC40", Offset = "0x899EC40", VA = "0x18899FC40", Slot = "8")]
	public void AMECCLGBNGK(bool MCFBHOHCNGE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000244")]
	[Cpp2IlInjected.Address(RVA = "0x89A0020", Offset = "0x899F020", VA = "0x1889A0020", Slot = "10")]
	public bool NIECBDANKIP(Vector3 NBFEGPDMMPI, [Out] RaycastHit CPCOHHMIMEG, float OAGBEPAKAEK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000245")]
	[Cpp2IlInjected.Address(RVA = "0x899FC50", Offset = "0x899EC50", VA = "0x18899FC50")]
	private void CHNBIPIHGLH(bool MCFBHOHCNGE)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000025")]
public sealed class NPGIBLOIPHJ : DEFJPKLJLBE, IDisposable, CGNFKEMEDPA
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000036")]
	private readonly EHFCEALLCDO FBMIODACPPK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000037")]
	private JEHFMNHABAI BMJKJCGGLOF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000038")]
	private GJPKPACEBLN GPLEDHFPCLK;

	[Cpp2IlInjected.Token(Token = "0x17000091")]
	public JEHFMNHABAI OAFIDMJJIDM
	{
		[Cpp2IlInjected.Token(Token = "0x6000248")]
		[Cpp2IlInjected.Address(RVA = "0x899BEA0", Offset = "0x899AEA0", VA = "0x18899BEA0", Slot = "6")]
		get
		{
			return default(JEHFMNHABAI);
		}
		[Cpp2IlInjected.Token(Token = "0x6000249")]
		[Cpp2IlInjected.Address(RVA = "0x899BD80", Offset = "0x899AD80", VA = "0x18899BD80", Slot = "7")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000092")]
	private Transform MINPLHNPPIN
	{
		[Cpp2IlInjected.Token(Token = "0x600024A")]
		[Cpp2IlInjected.Address(RVA = "0xDFC910", Offset = "0xDFB910", VA = "0x180DFC910", Slot = "10")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000020")]
	public event Action<FECJOJFDCBL, FECJOJFDCBL> NPPNIPCOAAB
	{
		[Cpp2IlInjected.Token(Token = "0x6000246")]
		[Cpp2IlInjected.Address(RVA = "0x899BFE0", Offset = "0x899AFE0", VA = "0x18899BFE0", Slot = "4")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000247")]
		[Cpp2IlInjected.Address(RVA = "0x899C300", Offset = "0x899B300", VA = "0x18899C300", Slot = "5")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600024B")]
	[Cpp2IlInjected.Address(RVA = "0x899C3B0", Offset = "0x899B3B0", VA = "0x18899C3B0")]
	public NPGIBLOIPHJ(MFIGOAEMMAF FBMIODACPPK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600024C")]
	[Cpp2IlInjected.Address(RVA = "0x899C090", Offset = "0x899B090", VA = "0x18899C090", Slot = "8")]
	public void IDNMFFEDDDN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600024D")]
	[Cpp2IlInjected.Address(RVA = "0x899BE50", Offset = "0x899AE50", VA = "0x18899BE50", Slot = "9")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600024E")]
	[Cpp2IlInjected.Address(RVA = "0x1301D10", Offset = "0x1300D10", VA = "0x181301D10", Slot = "11")]
	private void ADKKPPDBLPH(FECJOJFDCBL FEONOEDNHCA, FECJOJFDCBL HEBEBNMJNIK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600024F")]
	[Cpp2IlInjected.Address(RVA = "0xA60520", Offset = "0xA5F520", VA = "0x180A60520", Slot = "12")]
	private void OIGPCPFDGDB(bool CMNHCHIKDKP)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000026")]
public class KGEGGHIIPNA : AECGPMCLHFG
{
	[Cpp2IlInjected.Token(Token = "0x6000250")]
	[Cpp2IlInjected.Address(RVA = "0x8996DC0", Offset = "0x8995DC0", VA = "0x188996DC0", Slot = "4")]
	public HKHMGNIMBHB KKAICCBLMME(MFIGOAEMMAF JOEHPNNMIOL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000251")]
	[Cpp2IlInjected.Address(RVA = "0x8996900", Offset = "0x8995900", VA = "0x188996900", Slot = "5")]
	public NKFJANAJGEK IHKHJBNKMOL(MFIGOAEMMAF JOEHPNNMIOL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000252")]
	[Cpp2IlInjected.Address(RVA = "0x8996750", Offset = "0x8995750", VA = "0x188996750", Slot = "6")]
	public OEHINJFEKGA CMDCHECMNHH(MFIGOAEMMAF JOEHPNNMIOL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000253")]
	[Cpp2IlInjected.Address(RVA = "0x8996880", Offset = "0x8995880", VA = "0x188996880", Slot = "7")]
	public NECKIKIOFMD DCMJMMLJBOI(MFIGOAEMMAF JOEHPNNMIOL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000254")]
	[Cpp2IlInjected.Address(RVA = "0x8996EB0", Offset = "0x8995EB0", VA = "0x188996EB0", Slot = "8")]
	public NDEJNDNEBID KLFPNHHMPIE(MFIGOAEMMAF JOEHPNNMIOL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000255")]
	[Cpp2IlInjected.Address(RVA = "0x8996CF0", Offset = "0x8995CF0", VA = "0x188996CF0", Slot = "9")]
	public DEFJPKLJLBE JMLIMKFFLKM(MFIGOAEMMAF JOEHPNNMIOL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000256")]
	[Cpp2IlInjected.Address(RVA = "0x8997040", Offset = "0x8996040", VA = "0x188997040", Slot = "10")]
	public HFPGPHALCME NKKNKKNOIME(MFIGOAEMMAF JOEHPNNMIOL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000257")]
	[Cpp2IlInjected.Address(RVA = "0x8996C30", Offset = "0x8995C30", VA = "0x188996C30", Slot = "11")]
	public JDHBKCDFGPA JMGOHIAIBAF(MFIGOAEMMAF JOEHPNNMIOL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000258")]
	[Cpp2IlInjected.Address(RVA = "0x8996400", Offset = "0x8995400", VA = "0x188996400", Slot = "12")]
	public HLHJKDPIEEG CFAAEONCFLF(MFIGOAEMMAF JOEHPNNMIOL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000259")]
	[Cpp2IlInjected.Address(RVA = "0x8996F80", Offset = "0x8995F80", VA = "0x188996F80", Slot = "13")]
	public OHBIIAGNIEI KNOCJMNGFPO(MFIGOAEMMAF JOEHPNNMIOL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600025A")]
	[Cpp2IlInjected.Address(RVA = "0x89964C0", Offset = "0x89954C0", VA = "0x1889964C0")]
	public HHGNGAAPGIO KKFCCMOLINI(MFIGOAEMMAF JOEHPNNMIOL, [In] POOLCNKIBAH INCJDDLACNP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600025B")]
	[Cpp2IlInjected.Address(RVA = "0x89960E0", Offset = "0x89950E0", VA = "0x1889960E0")]
	public FBGDKAGAKLD OPMFGCKMPBP(MFIGOAEMMAF JOEHPNNMIOL, [In] POOLCNKIBAH INCJDDLACNP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600025C")]
	[Cpp2IlInjected.Address(RVA = "0x8996A20", Offset = "0x8995A20", VA = "0x188996A20")]
	public NEPFFIKMEOI KLFHMIOJFGJ(MFIGOAEMMAF JOEHPNNMIOL, [In] POOLCNKIBAH INCJDDLACNP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600025D")]
	[Cpp2IlInjected.Address(RVA = "0x8996270", Offset = "0x8995270", VA = "0x188996270")]
	public IJEDNMNOMME BAMBMADBICM(MFIGOAEMMAF JOEHPNNMIOL, [In] POOLCNKIBAH INCJDDLACNP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600025E")]
	[Cpp2IlInjected.Address(RVA = "0x8996B50", Offset = "0x8995B50", VA = "0x188996B50")]
	public JIDOCDIJGFP JFKOGBGNMIJ(MFIGOAEMMAF JOEHPNNMIOL, [In] POOLCNKIBAH INCJDDLACNP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600025F")]
	[Cpp2IlInjected.Address(RVA = "0x8996600", Offset = "0x8995600", VA = "0x188996600", Slot = "19")]
	public MFIGOAEMMAF CLCLMIBBLAJ(RigidbodyEx FBMIODACPPK, POOLCNKIBAH INCJDDLACNP, LAPLJDMFFDB PAOKFDJPALE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000260")]
	[Cpp2IlInjected.Address(RVA = "0xA6E050", Offset = "0xA6D050", VA = "0x180A6E050")]
	public KGEGGHIIPNA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000261")]
	[Cpp2IlInjected.Address(RVA = "0x89964C0", Offset = "0x89954C0", VA = "0x1889964C0", Slot = "14")]
	private HHGNGAAPGIO CFFMAMJACOL(MFIGOAEMMAF JOEHPNNMIOL, [In] POOLCNKIBAH INCJDDLACNP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000262")]
	[Cpp2IlInjected.Address(RVA = "0x89960E0", Offset = "0x89950E0", VA = "0x1889960E0", Slot = "15")]
	private FBGDKAGAKLD AHDCLHIELFG(MFIGOAEMMAF JOEHPNNMIOL, [In] POOLCNKIBAH INCJDDLACNP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000263")]
	[Cpp2IlInjected.Address(RVA = "0x8996A20", Offset = "0x8995A20", VA = "0x188996A20", Slot = "16")]
	private NEPFFIKMEOI IMAMHOFLCPG(MFIGOAEMMAF JOEHPNNMIOL, [In] POOLCNKIBAH INCJDDLACNP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000264")]
	[Cpp2IlInjected.Address(RVA = "0x8996270", Offset = "0x8995270", VA = "0x188996270", Slot = "17")]
	private IJEDNMNOMME KKKIJLPFKHH(MFIGOAEMMAF JOEHPNNMIOL, [In] POOLCNKIBAH INCJDDLACNP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000265")]
	[Cpp2IlInjected.Address(RVA = "0x8996B50", Offset = "0x8995B50", VA = "0x188996B50", Slot = "18")]
	private JIDOCDIJGFP KNLMDKPLIKG(MFIGOAEMMAF JOEHPNNMIOL, [In] POOLCNKIBAH INCJDDLACNP)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000027")]
internal sealed class MGGDPHNCMGB : JDHBKCDFGPA
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000039")]
	private readonly EHFCEALLCDO FBMIODACPPK;

	[Cpp2IlInjected.Token(Token = "0x17000093")]
	private Rigidbody CHKPFCFBIFF
	{
		[Cpp2IlInjected.Token(Token = "0x6000266")]
		[Cpp2IlInjected.Address(RVA = "0x89974F0", Offset = "0x89964F0", VA = "0x1889974F0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000094")]
	private bool HBGAICGJHMM
	{
		[Cpp2IlInjected.Token(Token = "0x6000267")]
		[Cpp2IlInjected.Address(RVA = "0x8997A60", Offset = "0x8996A60", VA = "0x188997A60")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000095")]
	private bool FKHKIDHBPAC
	{
		[Cpp2IlInjected.Token(Token = "0x6000268")]
		[Cpp2IlInjected.Address(RVA = "0x89904E0", Offset = "0x898F4E0", VA = "0x1889904E0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000096")]
	private MFIGOAEMMAF GDFCPOBJFDH
	{
		[Cpp2IlInjected.Token(Token = "0x6000269")]
		[Cpp2IlInjected.Address(RVA = "0x8997F70", Offset = "0x8996F70", VA = "0x188997F70")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600026A")]
	[Cpp2IlInjected.Address(RVA = "0x8991030", Offset = "0x8990030", VA = "0x188991030")]
	public MGGDPHNCMGB(MFIGOAEMMAF FBMIODACPPK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600026B")]
	[Cpp2IlInjected.Address(RVA = "0x89977A0", Offset = "0x89967A0", VA = "0x1889977A0", Slot = "4")]
	public void HEMDJAKLKFB(Vector3 HOJOMGEINAH, ForceMode DLJNDNGFIPO = ForceMode.Force)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600026C")]
	[Cpp2IlInjected.Address(RVA = "0x8997D10", Offset = "0x8996D10", VA = "0x188997D10")]
	private void NBABJGOKNGK(Vector3 HOJOMGEINAH, ForceMode DLJNDNGFIPO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600026D")]
	[Cpp2IlInjected.Address(RVA = "0x8997270", Offset = "0x8996270", VA = "0x188997270", Slot = "5")]
	public void AIADFLLFLEP(Vector3 HOJOMGEINAH, Vector3 EBGKGBGFPOC, ForceMode DLJNDNGFIPO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600026E")]
	[Cpp2IlInjected.Address(RVA = "0x8997900", Offset = "0x8996900", VA = "0x188997900", Slot = "6")]
	public void HMNBOIPBKPM(Vector3 LAOLJOAKMLI, ForceMode DLJNDNGFIPO = ForceMode.Force)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600026F")]
	[Cpp2IlInjected.Address(RVA = "0x8997540", Offset = "0x8996540", VA = "0x188997540")]
	private void DGENJPMMLLF(Vector3 LAOLJOAKMLI, ForceMode DLJNDNGFIPO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000270")]
	[Cpp2IlInjected.Address(RVA = "0x8997AB0", Offset = "0x8996AB0", VA = "0x188997AB0", Slot = "7")]
	public void MGKIMILNCCG(Vector3 LAOLJOAKMLI, ForceMode DLJNDNGFIPO = ForceMode.Force)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000028")]
internal sealed class HEMMFAEINBF : OHBIIAGNIEI
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400003A")]
	private readonly EHFCEALLCDO FBMIODACPPK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400003B")]
	private bool ODLKDNICAFE;

	[Cpp2IlInjected.Token(Token = "0x17000097")]
	public bool AKBHMCCMMHA
	{
		[Cpp2IlInjected.Token(Token = "0x6000272")]
		[Cpp2IlInjected.Address(RVA = "0xAB8160", Offset = "0xAB7160", VA = "0x180AB8160", Slot = "4")]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000273")]
		[Cpp2IlInjected.Address(RVA = "0x8990EF0", Offset = "0x898FEF0", VA = "0x188990EF0", Slot = "5")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000271")]
	[Cpp2IlInjected.Address(RVA = "0x8991030", Offset = "0x8990030", VA = "0x188991030")]
	public HEMMFAEINBF(MFIGOAEMMAF FBMIODACPPK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000274")]
	[Cpp2IlInjected.Address(RVA = "0x8991000", Offset = "0x8990000", VA = "0x188991000", Slot = "6")]
	public void JDNGENAKMFJ(Rigidbody OEKAMIKGJCJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000275")]
	[Cpp2IlInjected.Address(RVA = "0x8990E80", Offset = "0x898FE80", VA = "0x188990E80", Slot = "7")]
	public void AHPFMPBNNKL(Rigidbody OEKAMIKGJCJ)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000029")]
internal sealed class OLFOJPAMIGM : EKHMNDOBBMI, HKHMGNIMBHB, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x4000045")]
	private readonly MFIGOAEMMAF FBMIODACPPK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x4000046")]
	private readonly List<MFIGOAEMMAF> OAEJIHKFLKO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x4000047")]
	private MFIGOAEMMAF NKBKNNLLHKF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x4000048")]
	private MFIGOAEMMAF EBJBKAEFOPM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
	[Cpp2IlInjected.Token(Token = "0x4000049")]
	private Transform HBKKFLHBOKO;

	[Cpp2IlInjected.Token(Token = "0x17000098")]
	private Transform DBHNDLPLFNO
	{
		[Cpp2IlInjected.Token(Token = "0x6000288")]
		[Cpp2IlInjected.Address(RVA = "0x899E540", Offset = "0x899D540", VA = "0x18899E540")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000099")]
	public MFIGOAEMMAF GDFCPOBJFDH
	{
		[Cpp2IlInjected.Token(Token = "0x600028B")]
		[Cpp2IlInjected.Address(RVA = "0xA631A0", Offset = "0xA621A0", VA = "0x180A631A0", Slot = "28")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600028C")]
		[Cpp2IlInjected.Address(RVA = "0x899F1A0", Offset = "0x899E1A0", VA = "0x18899F1A0", Slot = "29")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700009A")]
	public MFIGOAEMMAF AOHAMHAHFAH
	{
		[Cpp2IlInjected.Token(Token = "0x600028D")]
		[Cpp2IlInjected.Address(RVA = "0xA63200", Offset = "0xA62200", VA = "0x180A63200", Slot = "27")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700009B")]
	public IReadOnlyList<MFIGOAEMMAF> CBBCFAGKAPG
	{
		[Cpp2IlInjected.Token(Token = "0x600028E")]
		[Cpp2IlInjected.Address(RVA = "0xA63190", Offset = "0xA62190", VA = "0x180A63190", Slot = "26")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000021")]
	public event FIIMNHMKNMH PNOOHILMNMA
	{
		[Cpp2IlInjected.Token(Token = "0x6000276")]
		[Cpp2IlInjected.Address(RVA = "0x899EDE0", Offset = "0x899DDE0", VA = "0x18899EDE0", Slot = "8")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000277")]
		[Cpp2IlInjected.Address(RVA = "0x899F990", Offset = "0x899E990", VA = "0x18899F990", Slot = "9")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000022")]
	public event FIIMNHMKNMH PBICCJJDPLG
	{
		[Cpp2IlInjected.Token(Token = "0x6000278")]
		[Cpp2IlInjected.Address(RVA = "0x899F470", Offset = "0x899E470", VA = "0x18899F470", Slot = "10")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000279")]
		[Cpp2IlInjected.Address(RVA = "0x899E790", Offset = "0x899D790", VA = "0x18899E790", Slot = "11")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000023")]
	public event PALGGIDOPDJ ALJOINIAEFA
	{
		[Cpp2IlInjected.Token(Token = "0x600027A")]
		[Cpp2IlInjected.Address(RVA = "0x899ED40", Offset = "0x899DD40", VA = "0x18899ED40", Slot = "12")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600027B")]
		[Cpp2IlInjected.Address(RVA = "0x899E5A0", Offset = "0x899D5A0", VA = "0x18899E5A0", Slot = "13")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000024")]
	public event Action JBLCBFEGMJG
	{
		[Cpp2IlInjected.Token(Token = "0x600027C")]
		[Cpp2IlInjected.Address(RVA = "0x899FA30", Offset = "0x899EA30", VA = "0x18899FA30", Slot = "14")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600027D")]
		[Cpp2IlInjected.Address(RVA = "0x899F510", Offset = "0x899E510", VA = "0x18899F510", Slot = "15")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000025")]
	public event Action NFCJKLKGPAP
	{
		[Cpp2IlInjected.Token(Token = "0x600027E")]
		[Cpp2IlInjected.Address(RVA = "0x899EBF0", Offset = "0x899DBF0", VA = "0x18899EBF0", Slot = "16")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600027F")]
		[Cpp2IlInjected.Address(RVA = "0x899EE80", Offset = "0x899DE80", VA = "0x18899EE80", Slot = "17")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000026")]
	public event Action<MFIGOAEMMAF> AOACAGGKOJF
	{
		[Cpp2IlInjected.Token(Token = "0x6000280")]
		[Cpp2IlInjected.Address(RVA = "0x899FAD0", Offset = "0x899EAD0", VA = "0x18899FAD0", Slot = "18")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000281")]
		[Cpp2IlInjected.Address(RVA = "0x899F3C0", Offset = "0x899E3C0", VA = "0x18899F3C0", Slot = "19")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000027")]
	public event Action<MFIGOAEMMAF> JEMONODBOLH
	{
		[Cpp2IlInjected.Token(Token = "0x6000282")]
		[Cpp2IlInjected.Address(RVA = "0x899F820", Offset = "0x899E820", VA = "0x18899F820", Slot = "20")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000283")]
		[Cpp2IlInjected.Address(RVA = "0x899E640", Offset = "0x899D640", VA = "0x18899E640", Slot = "21")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000028")]
	public event Action LJJGPNPBPGK
	{
		[Cpp2IlInjected.Token(Token = "0x6000284")]
		[Cpp2IlInjected.Address(RVA = "0x899F1B0", Offset = "0x899E1B0", VA = "0x18899F1B0", Slot = "22")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000285")]
		[Cpp2IlInjected.Address(RVA = "0x899E4A0", Offset = "0x899D4A0", VA = "0x18899E4A0", Slot = "23")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000029")]
	public event Action<MFIGOAEMMAF> EFCELDGDMEK
	{
		[Cpp2IlInjected.Token(Token = "0x6000286")]
		[Cpp2IlInjected.Address(RVA = "0x899EC90", Offset = "0x899DC90", VA = "0x18899EC90", Slot = "24")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000287")]
		[Cpp2IlInjected.Address(RVA = "0x899EA10", Offset = "0x899DA10", VA = "0x18899EA10", Slot = "25")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000289")]
	[Cpp2IlInjected.Address(RVA = "0x899FB80", Offset = "0x899EB80", VA = "0x18899FB80")]
	public OLFOJPAMIGM(MFIGOAEMMAF FBMIODACPPK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600028A")]
	[Cpp2IlInjected.Address(RVA = "0x899E6F0", Offset = "0x899D6F0", VA = "0x18899E6F0", Slot = "31")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600028F")]
	[Cpp2IlInjected.Address(RVA = "0x899DE30", Offset = "0x899CE30", VA = "0x18899DE30", Slot = "30")]
	public void AKCKLCNBHIA(MFIGOAEMMAF BKAKGIFOLLC, bool LPDEIPGKDOE = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000290")]
	[Cpp2IlInjected.Address(RVA = "0x899F5B0", Offset = "0x899E5B0", VA = "0x18899F5B0", Slot = "6")]
	public void MPGCCNCHLCN(MFIGOAEMMAF NBJIPLGHAHH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000291")]
	[Cpp2IlInjected.Address(RVA = "0x899EF20", Offset = "0x899DF20", VA = "0x18899EF20", Slot = "7")]
	public void KDIFJNJPNAH(MFIGOAEMMAF NBJIPLGHAHH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000292")]
	[Cpp2IlInjected.Address(RVA = "0x899E3B0", Offset = "0x899D3B0", VA = "0x18899E3B0", Slot = "4")]
	public void BDMFDANLNLE(MFIGOAEMMAF FBMIODACPPK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000293")]
	[Cpp2IlInjected.Address(RVA = "0x899DD90", Offset = "0x899CD90", VA = "0x18899DD90", Slot = "5")]
	public void ABLMAADCNKL(MFIGOAEMMAF FBMIODACPPK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000294")]
	[Cpp2IlInjected.Address(RVA = "0x899E970", Offset = "0x899D970", VA = "0x18899E970")]
	private void FALGAKNNOMK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000295")]
	[Cpp2IlInjected.Address(RVA = "0x899F250", Offset = "0x899E250", VA = "0x18899F250")]
	private void LMOJMGNNABN(MFIGOAEMMAF NBJIPLGHAHH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000296")]
	[Cpp2IlInjected.Address(RVA = "0x899E830", Offset = "0x899D830", VA = "0x18899E830")]
	private void ELKOCALIGEM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000297")]
	[Cpp2IlInjected.Address(RVA = "0x899EAC0", Offset = "0x899DAC0", VA = "0x18899EAC0")]
	private void GNFNKCLLMBF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000298")]
	[Cpp2IlInjected.Address(RVA = "0x899F290", Offset = "0x899E290", VA = "0x18899F290")]
	private void MBDPENBHADI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000299")]
	[Cpp2IlInjected.Address(RVA = "0x899F8D0", Offset = "0x899E8D0", VA = "0x18899F8D0")]
	[CompilerGenerated]
	private object NPAHIKJPDAC()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200002A")]
internal static class JDEDLEDAEHM
{
	[Cpp2IlInjected.Token(Token = "0x600029A")]
	[Cpp2IlInjected.Address(RVA = "0x8994AB0", Offset = "0x8993AB0", VA = "0x188994AB0")]
	public static EKHMNDOBBMI IPAAGBGNNHH(this MFIGOAEMMAF JOEHPNNMIOL)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200002B")]
internal sealed class HGDIKFLJOPC : LLAIFJBJCIN, OEHINJFEKGA
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400004A")]
	private readonly EHFCEALLCDO FBMIODACPPK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400004B")]
	private readonly ELCBPAGODNE<MFIGOAEMMAF> EPPDKGOOPKI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400004C")]
	private bool DLNLIHJEPLL;

	[Cpp2IlInjected.Token(Token = "0x1700009C")]
	public ELCBPAGODNE<MFIGOAEMMAF> EHMPNPPHJDL
	{
		[Cpp2IlInjected.Token(Token = "0x600029B")]
		[Cpp2IlInjected.Address(RVA = "0xA5F390", Offset = "0xA5E390", VA = "0x180A5F390", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700009D")]
	public Vector3 DGPJNKHKOAH
	{
		[Cpp2IlInjected.Token(Token = "0x600029C")]
		[Cpp2IlInjected.Address(RVA = "0x89914F0", Offset = "0x89904F0", VA = "0x1889914F0", Slot = "6")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700009E")]
	public Vector3 OCPCNFPMMKN
	{
		[Cpp2IlInjected.Token(Token = "0x600029D")]
		[Cpp2IlInjected.Address(RVA = "0x89910C0", Offset = "0x89900C0", VA = "0x1889910C0", Slot = "7")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700009F")]
	private Vector3 CEBEECPEOGO
	{
		[Cpp2IlInjected.Token(Token = "0x60002A1")]
		[Cpp2IlInjected.Address(RVA = "0x8991400", Offset = "0x8990400", VA = "0x188991400")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A0")]
	public MFIGOAEMMAF FGLEJGIFNDG
	{
		[Cpp2IlInjected.Token(Token = "0x60002A2")]
		[Cpp2IlInjected.Address(RVA = "0x8991350", Offset = "0x8990350", VA = "0x188991350", Slot = "5")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600029E")]
	[Cpp2IlInjected.Address(RVA = "0x8991C50", Offset = "0x8990C50", VA = "0x188991C50")]
	public HGDIKFLJOPC(MFIGOAEMMAF FBMIODACPPK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600029F")]
	[Cpp2IlInjected.Address(RVA = "0x89912E0", Offset = "0x89902E0", VA = "0x1889912E0", Slot = "8")]
	public void HIJHFKCPBFP(MFIGOAEMMAF EBJBKAEFOPM, object GFDDDAIMFOH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002A0")]
	[Cpp2IlInjected.Address(RVA = "0x8991280", Offset = "0x8990280", VA = "0x188991280", Slot = "9")]
	public void GNHEDOFBMBF(object GFDDDAIMFOH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002A3")]
	[Cpp2IlInjected.Address(RVA = "0x89918B0", Offset = "0x89908B0", VA = "0x1889918B0")]
	private Vector3 PFBCOIODCCK()
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x60002A4")]
	[Cpp2IlInjected.Address(RVA = "0x8991520", Offset = "0x8990520", VA = "0x188991520")]
	private void PEFOJMIGMAL(MFIGOAEMMAF CNNNOLNPGJO)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002C")]
internal static class CANCIEAJLJL
{
	[Cpp2IlInjected.Token(Token = "0x60002A5")]
	[Cpp2IlInjected.Address(RVA = "0x8989670", Offset = "0x8988670", VA = "0x188989670")]
	public static LLAIFJBJCIN HPFAFCHPNII(this MFIGOAEMMAF JOEHPNNMIOL)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200002D")]
internal sealed class HNEEJNAANCL : GJPLLGFKNGH, IJEDNMNOMME
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400004E")]
	private readonly EHFCEALLCDO FBMIODACPPK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400004F")]
	private readonly OverridableVector3 PBPJMOAKLFK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000050")]
	private readonly OverridableVector3 JBGGFJIIHFP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000051")]
	private float BHBOIEHJEOM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x44")]
	[Cpp2IlInjected.Token(Token = "0x4000052")]
	private float PEFCKLHMGJD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000053")]
	private Vector3 KPMKLEMEKBJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x54")]
	[Cpp2IlInjected.Token(Token = "0x4000054")]
	private Vector3? PLAKLGLCBKD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x64")]
	[Cpp2IlInjected.Token(Token = "0x4000055")]
	private Quaternion? DCEKFABCPDB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
	[Cpp2IlInjected.Token(Token = "0x4000056")]
	private bool NGCCBKJOEJP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x79")]
	[Cpp2IlInjected.Token(Token = "0x4000057")]
	private bool HKGKOFDBMNH;

	[Cpp2IlInjected.Token(Token = "0x170000A1")]
	public Vector3 JHEJMAHNPBI
	{
		[Cpp2IlInjected.Token(Token = "0x60002A8")]
		[Cpp2IlInjected.Address(RVA = "0x184E100", Offset = "0x184D100", VA = "0x18184E100", Slot = "7")]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x60002A9")]
		[Cpp2IlInjected.Address(RVA = "0x8992C30", Offset = "0x8991C30", VA = "0x188992C30", Slot = "8")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A2")]
	public Vector3 MHMKILICHPP
	{
		[Cpp2IlInjected.Token(Token = "0x60002AA")]
		[Cpp2IlInjected.Address(RVA = "0x8994410", Offset = "0x8993410", VA = "0x188994410", Slot = "9")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A3")]
	public float AMGCMLCLCBG
	{
		[Cpp2IlInjected.Token(Token = "0x60002AB")]
		[Cpp2IlInjected.Address(RVA = "0xE21050", Offset = "0xE20050", VA = "0x180E21050", Slot = "10")]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x60002AC")]
		[Cpp2IlInjected.Address(RVA = "0x8992990", Offset = "0x8991990", VA = "0x188992990")]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A4")]
	public float DPJEGOOLEIH
	{
		[Cpp2IlInjected.Token(Token = "0x60002AD")]
		[Cpp2IlInjected.Address(RVA = "0xD09AA0", Offset = "0xD08AA0", VA = "0x180D09AA0", Slot = "11")]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x60002AE")]
		[Cpp2IlInjected.Address(RVA = "0x8992010", Offset = "0x8991010", VA = "0x188992010", Slot = "12")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A5")]
	public Vector3 HOCIMGJPKJG
	{
		[Cpp2IlInjected.Token(Token = "0x60002AF")]
		[Cpp2IlInjected.Address(RVA = "0x8992AA0", Offset = "0x8991AA0", VA = "0x188992AA0", Slot = "13")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A6")]
	public Quaternion EIJGCCEDODN
	{
		[Cpp2IlInjected.Token(Token = "0x60002B0")]
		[Cpp2IlInjected.Address(RVA = "0x8992F60", Offset = "0x8991F60", VA = "0x188992F60", Slot = "14")]
		get
		{
			return default(Quaternion);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A7")]
	private Rigidbody CHKPFCFBIFF
	{
		[Cpp2IlInjected.Token(Token = "0x60002B8")]
		[Cpp2IlInjected.Address(RVA = "0x89920C0", Offset = "0x89910C0", VA = "0x1889920C0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400002A")]
	public event FIIMNHMKNMH NCNPBNNEHJD
	{
		[Cpp2IlInjected.Token(Token = "0x60002A6")]
		[Cpp2IlInjected.Address(RVA = "0x89930E0", Offset = "0x89920E0", VA = "0x1889930E0", Slot = "5")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60002A7")]
		[Cpp2IlInjected.Address(RVA = "0x8992110", Offset = "0x8991110", VA = "0x188992110", Slot = "6")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60002B1")]
	[Cpp2IlInjected.Address(RVA = "0x8994500", Offset = "0x8993500", VA = "0x188994500")]
	public HNEEJNAANCL(MFIGOAEMMAF FBMIODACPPK, [In] POOLCNKIBAH INCJDDLACNP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002B2")]
	[Cpp2IlInjected.Address(RVA = "0x8992870", Offset = "0x8991870", VA = "0x188992870", Slot = "17")]
	public void FANGIMEHNDB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002B3")]
	[Cpp2IlInjected.Address(RVA = "0x8991D50", Offset = "0x8990D50", VA = "0x188991D50", Slot = "16")]
	public void ADJGMOJPIGC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002B4")]
	[Cpp2IlInjected.Address(RVA = "0x8992E80", Offset = "0x8991E80", VA = "0x188992E80", Slot = "19")]
	public void JDNGENAKMFJ(Rigidbody OEKAMIKGJCJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002B5")]
	[Cpp2IlInjected.Address(RVA = "0x8991E30", Offset = "0x8990E30", VA = "0x188991E30", Slot = "20")]
	public void AHPFMPBNNKL(Rigidbody OEKAMIKGJCJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002B6")]
	[Cpp2IlInjected.Address(RVA = "0x8994170", Offset = "0x8993170", VA = "0x188994170", Slot = "18")]
	public void OHOPNDOPGNC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002B7")]
	[Cpp2IlInjected.Address(RVA = "0x89921B0", Offset = "0x89911B0", VA = "0x1889921B0", Slot = "21")]
	public void DAEOFNOBLFE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002B9")]
	[Cpp2IlInjected.Address(RVA = "0x8992C30", Offset = "0x8991C30", VA = "0x188992C30")]
	private void HGEKKKPMBFL(Vector3 IOALKPFEKEK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002BA")]
	[Cpp2IlInjected.Address(RVA = "0x8994320", Offset = "0x8993320", VA = "0x188994320")]
	[Obsolete("This method is dangerous - the unity rigidbody is updated in a deferred manner and this world position may be stale")]
	private Vector3 PFMKHCLLKAM()
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x60002BB")]
	[Cpp2IlInjected.Address(RVA = "0x8992990", Offset = "0x8991990", VA = "0x188992990")]
	private void JPPCCLPBGBK(float IOALKPFEKEK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002BC")]
	[Cpp2IlInjected.Address(RVA = "0x8992010", Offset = "0x8991010", VA = "0x188992010")]
	private void BBAHPGEOOEP(float IOALKPFEKEK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002BD")]
	[Cpp2IlInjected.Address(RVA = "0x8992CE0", Offset = "0x8991CE0", VA = "0x188992CE0")]
	private Vector3 JCHLEEMNHMC()
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x60002BE")]
	[Cpp2IlInjected.Address(RVA = "0x8992640", Offset = "0x8991640", VA = "0x188992640", Slot = "15")]
	public void DKLLEIPOFLE((Quaternion rot, Vector3 moments) MOHIENDLLGP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002BF")]
	[Cpp2IlInjected.Address(RVA = "0x8993180", Offset = "0x8992180", VA = "0x188993180")]
	private Quaternion LMAACPDHBJI()
	{
		return default(Quaternion);
	}

	[Cpp2IlInjected.Token(Token = "0x60002C0")]
	[Cpp2IlInjected.Address(RVA = "0x89940A0", Offset = "0x89930A0", VA = "0x1889940A0")]
	public void MPCMPBLOIDM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002C1")]
	[Cpp2IlInjected.Address(RVA = "0x8993300", Offset = "0x8992300", VA = "0x188993300", Slot = "4")]
	public (float, Vector3) MPCMPBLOIDM(Rigidbody KNCJHMCBCCC)
	{
		return default((float, Vector3));
	}
}
[Cpp2IlInjected.Token(Token = "0x200002E")]
internal static class JOEDIHILIHO
{
	[Cpp2IlInjected.Token(Token = "0x60002C2")]
	[Cpp2IlInjected.Address(RVA = "0x8994E40", Offset = "0x8993E40", VA = "0x188994E40")]
	public static GJPLLGFKNGH OJFGOAIOOMB(this MFIGOAEMMAF JOEHPNNMIOL)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200002F")]
internal sealed class MOMIHFCJNHH : NEPFFIKMEOI
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000058")]
	private readonly EHFCEALLCDO FBMIODACPPK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000059")]
	private readonly IDNPIOCKKCM HMOJACNGKJD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400005A")]
	private readonly PCMEBGNJIKH ELGDGMOPDKC;

	[Cpp2IlInjected.Token(Token = "0x170000A8")]
	public bool FPDOGBJEBED
	{
		[Cpp2IlInjected.Token(Token = "0x60002C3")]
		[Cpp2IlInjected.Address(RVA = "0x1A4F590", Offset = "0x1A4E590", VA = "0x181A4F590", Slot = "10")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A9")]
	public PCMEBGNJIKH JPMAINONMLJ
	{
		[Cpp2IlInjected.Token(Token = "0x60002C4")]
		[Cpp2IlInjected.Address(RVA = "0xAAE1A0", Offset = "0xAAD1A0", VA = "0x180AAE1A0", Slot = "11")]
		get
		{
			return default(PCMEBGNJIKH);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60002C5")]
	[Cpp2IlInjected.Address(RVA = "0x8998600", Offset = "0x8997600", VA = "0x188998600")]
	public MOMIHFCJNHH(MFIGOAEMMAF FBMIODACPPK, [In] POOLCNKIBAH INCJDDLACNP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002C6")]
	[Cpp2IlInjected.Address(RVA = "0x8998160", Offset = "0x8997160", VA = "0x188998160", Slot = "4")]
	public void IDNMFFEDDDN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002C7")]
	[Cpp2IlInjected.Address(RVA = "0x8998530", Offset = "0x8997530", VA = "0x188998530")]
	private bool PENNKNAGELM()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002C8")]
	[Cpp2IlInjected.Address(RVA = "0x89980F0", Offset = "0x89970F0", VA = "0x1889980F0", Slot = "5")]
	public void CCACJJHHCNK(object GFDDDAIMFOH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002C9")]
	[Cpp2IlInjected.Address(RVA = "0x89985D0", Offset = "0x89975D0", VA = "0x1889985D0", Slot = "6")]
	public void POIPMFFIONI(object GFDDDAIMFOH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002CA")]
	[Cpp2IlInjected.Address(RVA = "0x8998270", Offset = "0x8997270", VA = "0x188998270", Slot = "9")]
	public void MJHPAGNFEJP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002CB")]
	[Cpp2IlInjected.Address(RVA = "0x8997FD0", Offset = "0x8996FD0", VA = "0x188997FD0")]
	private void AHIIIAODBPB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002CC")]
	[Cpp2IlInjected.Address(RVA = "0x89983B0", Offset = "0x89973B0", VA = "0x1889983B0")]
	private void ONIGHCPGJMM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002CD")]
	[Cpp2IlInjected.Address(RVA = "0x8998120", Offset = "0x8997120", VA = "0x188998120", Slot = "8")]
	public void CGEGJHMEJEH(MFIGOAEMMAF FBMIODACPPK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002CE")]
	[Cpp2IlInjected.Address(RVA = "0x8998230", Offset = "0x8997230", VA = "0x188998230", Slot = "7")]
	public void IMKDDAAEAIL(MFIGOAEMMAF FBMIODACPPK)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000030")]
internal sealed class KBBNPDMNKNB : HFPGPHALCME
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400005C")]
	private readonly EHFCEALLCDO FBMIODACPPK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400005D")]
	private readonly IDNPIOCKKCM DMHNFJLDJGA;

	[Cpp2IlInjected.Token(Token = "0x170000AA")]
	public bool HBGAICGJHMM
	{
		[Cpp2IlInjected.Token(Token = "0x60002D1")]
		[Cpp2IlInjected.Address(RVA = "0x89950F0", Offset = "0x89940F0", VA = "0x1889950F0", Slot = "6")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400002B")]
	public event FIIMNHMKNMH ACOJALPIMJC
	{
		[Cpp2IlInjected.Token(Token = "0x60002CF")]
		[Cpp2IlInjected.Address(RVA = "0x8994F30", Offset = "0x8993F30", VA = "0x188994F30", Slot = "4")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60002D0")]
		[Cpp2IlInjected.Address(RVA = "0x8995260", Offset = "0x8994260", VA = "0x188995260", Slot = "5")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60002D2")]
	[Cpp2IlInjected.Address(RVA = "0x8995310", Offset = "0x8994310", VA = "0x188995310")]
	public KBBNPDMNKNB(MFIGOAEMMAF FBMIODACPPK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002D3")]
	[Cpp2IlInjected.Address(RVA = "0x8995300", Offset = "0x8994300", VA = "0x188995300", Slot = "7")]
	public void MBKNGPCCHDF(object GFDDDAIMFOH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002D4")]
	[Cpp2IlInjected.Address(RVA = "0x8994FD0", Offset = "0x8993FD0", VA = "0x188994FD0", Slot = "8")]
	public void FJHOMGODMDJ(object GFDDDAIMFOH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002D5")]
	[Cpp2IlInjected.Address(RVA = "0x8994FE0", Offset = "0x8993FE0", VA = "0x188994FE0", Slot = "9")]
	public void GLIAEMFMKNK(object GFDDDAIMFOH, bool NALIKJHDOEC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002D6")]
	[Cpp2IlInjected.Address(RVA = "0x8995220", Offset = "0x8994220", VA = "0x188995220", Slot = "12")]
	public void KMGALMIGDMM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002D7")]
	[Cpp2IlInjected.Address(RVA = "0x89951A0", Offset = "0x89941A0", VA = "0x1889951A0", Slot = "10")]
	public void JDNGENAKMFJ(Rigidbody OJLJIHMPMHO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002D8")]
	[Cpp2IlInjected.Address(RVA = "0x8994F00", Offset = "0x8993F00", VA = "0x188994F00", Slot = "11")]
	public void AHPFMPBNNKL(Rigidbody OEKAMIKGJCJ)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000031")]
internal sealed class KENNPJIFKGI : HIMKNODIKDO, FBGDKAGAKLD, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400005F")]
	private readonly EHFCEALLCDO FBMIODACPPK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000060")]
	private RRNetworkView ELAKGDCNKOD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000061")]
	private bool CKGOIAGOBOC;

	[Cpp2IlInjected.Token(Token = "0x170000AB")]
	public RRNetworkView GJNJMACHHGD
	{
		[Cpp2IlInjected.Token(Token = "0x60002DB")]
		[Cpp2IlInjected.Address(RVA = "0xA63F80", Offset = "0xA62F80", VA = "0x180A63F80", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000AC")]
	public bool OIEKHFOHMAM
	{
		[Cpp2IlInjected.Token(Token = "0x60002DC")]
		[Cpp2IlInjected.Address(RVA = "0x8995400", Offset = "0x8994400", VA = "0x188995400", Slot = "7")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000AD")]
	public bool DJDBGPECKIC
	{
		[Cpp2IlInjected.Token(Token = "0x60002DD")]
		[Cpp2IlInjected.Address(RVA = "0xC333C0", Offset = "0xC323C0", VA = "0x180C333C0", Slot = "8")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400002C")]
	public event FIIMNHMKNMH NNMBHEJKLMO
	{
		[Cpp2IlInjected.Token(Token = "0x60002D9")]
		[Cpp2IlInjected.Address(RVA = "0x8995660", Offset = "0x8994660", VA = "0x188995660", Slot = "5")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60002DA")]
		[Cpp2IlInjected.Address(RVA = "0x89959A0", Offset = "0x89949A0", VA = "0x1889959A0", Slot = "6")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60002DE")]
	[Cpp2IlInjected.Address(RVA = "0x8995F90", Offset = "0x8994F90", VA = "0x188995F90")]
	public KENNPJIFKGI(MFIGOAEMMAF FBMIODACPPK, [In] POOLCNKIBAH INCJDDLACNP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002DF")]
	[Cpp2IlInjected.Address(RVA = "0x8995700", Offset = "0x8994700", VA = "0x188995700", Slot = "9")]
	public void IDNMFFEDDDN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002E0")]
	[Cpp2IlInjected.Address(RVA = "0x8995560", Offset = "0x8994560", VA = "0x188995560", Slot = "12")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002E1")]
	[Cpp2IlInjected.Address(RVA = "0x8995830", Offset = "0x8994830", VA = "0x188995830", Slot = "10")]
	public void JODKHMDLHCG(MFIGOAEMMAF EBJBKAEFOPM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002E2")]
	[Cpp2IlInjected.Address(RVA = "0x8995A40", Offset = "0x8994A40", VA = "0x188995A40", Slot = "11")]
	public void OHKCJDBEEIM(MFIGOAEMMAF EBJBKAEFOPM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002E3")]
	[Cpp2IlInjected.Address(RVA = "0x8995BB0", Offset = "0x8994BB0", VA = "0x188995BB0")]
	private void PJPEBDEDBKM(RRNetworkView MABDJPJLJMG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002E4")]
	[Cpp2IlInjected.Address(RVA = "0x8995410", Offset = "0x8994410", VA = "0x188995410")]
	private void BPGPHMLLJNL(EOEFLGKDFOB KNBJPLCIDED)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002E5")]
	[Cpp2IlInjected.Address(RVA = "0x8995D20", Offset = "0x8994D20", VA = "0x188995D20")]
	private void PMBHNAFCKLB(RRNetworkView APLELBCEBDP)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000032")]
internal static class IKBPNDCCIJM
{
	[Cpp2IlInjected.Token(Token = "0x60002E6")]
	[Cpp2IlInjected.Address(RVA = "0x89949F0", Offset = "0x89939F0", VA = "0x1889949F0")]
	public static HIMKNODIKDO KJHKHCKGGAM(this MFIGOAEMMAF JOEHPNNMIOL)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000033")]
internal sealed class FNGPIKNDPPJ : JIDOCDIJGFP
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000062")]
	private readonly EHFCEALLCDO FBMIODACPPK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000063")]
	private RigidbodyConstraints LCBPFFNIJIA;

	[Cpp2IlInjected.Token(Token = "0x170000AE")]
	public bool CLKOFGBADDK
	{
		[Cpp2IlInjected.Token(Token = "0x60002E7")]
		[Cpp2IlInjected.Address(RVA = "0xB1AC50", Offset = "0xB19C50", VA = "0x180B1AC50", Slot = "4")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x60002E8")]
		[Cpp2IlInjected.Address(RVA = "0xE3B020", Offset = "0xE3A020", VA = "0x180E3B020", Slot = "5")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000AF")]
	public bool DMKHKJFOKCI
	{
		[Cpp2IlInjected.Token(Token = "0x60002E9")]
		[Cpp2IlInjected.Address(RVA = "0xB1AA60", Offset = "0xB19A60", VA = "0x180B1AA60", Slot = "6")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x60002EA")]
		[Cpp2IlInjected.Address(RVA = "0xE3B1D0", Offset = "0xE3A1D0", VA = "0x180E3B1D0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B0")]
	public RigidbodyConstraints LMOGEOKLEMJ
	{
		[Cpp2IlInjected.Token(Token = "0x60002EB")]
		[Cpp2IlInjected.Address(RVA = "0xA6A700", Offset = "0xA69700", VA = "0x180A6A700", Slot = "7")]
		get
		{
			return default(RigidbodyConstraints);
		}
		[Cpp2IlInjected.Token(Token = "0x60002EC")]
		[Cpp2IlInjected.Address(RVA = "0x89909E0", Offset = "0x898F9E0", VA = "0x1889909E0", Slot = "8")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60002ED")]
	[Cpp2IlInjected.Address(RVA = "0x8990B10", Offset = "0x898FB10", VA = "0x188990B10")]
	public FNGPIKNDPPJ(MFIGOAEMMAF FBMIODACPPK, [In] POOLCNKIBAH INCJDDLACNP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002EE")]
	[Cpp2IlInjected.Address(RVA = "0x89909B0", Offset = "0x898F9B0", VA = "0x1889909B0", Slot = "9")]
	public void JDNGENAKMFJ(Rigidbody OEKAMIKGJCJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002EF")]
	[Cpp2IlInjected.Address(RVA = "0x8990980", Offset = "0x898F980", VA = "0x188990980", Slot = "10")]
	public void AHPFMPBNNKL(Rigidbody OEKAMIKGJCJ)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000034")]
internal sealed class GNAIJJFGBOF : NECKIKIOFMD
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000066")]
	private readonly MFIGOAEMMAF FBMIODACPPK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000067")]
	private float LJOOJHOLGAP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
	[Cpp2IlInjected.Token(Token = "0x4000068")]
	private float BCEDCCMJNGC;

	[Cpp2IlInjected.Token(Token = "0x170000B1")]
	public float EECOPGNPCHA
	{
		[Cpp2IlInjected.Token(Token = "0x60002F1")]
		[Cpp2IlInjected.Address(RVA = "0xABF1F0", Offset = "0xABE1F0", VA = "0x180ABF1F0", Slot = "4")]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x60002F2")]
		[Cpp2IlInjected.Address(RVA = "0x8990D70", Offset = "0x898FD70", VA = "0x188990D70", Slot = "5")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B2")]
	public float ABDAAKPCHLE
	{
		[Cpp2IlInjected.Token(Token = "0x60002F3")]
		[Cpp2IlInjected.Address(RVA = "0xABF200", Offset = "0xABE200", VA = "0x180ABF200", Slot = "6")]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x60002F4")]
		[Cpp2IlInjected.Address(RVA = "0x8990C50", Offset = "0x898FC50", VA = "0x188990C50", Slot = "7")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60002F0")]
	[Cpp2IlInjected.Address(RVA = "0x8990E40", Offset = "0x898FE40", VA = "0x188990E40")]
	public GNAIJJFGBOF(MFIGOAEMMAF FBMIODACPPK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002F5")]
	[Cpp2IlInjected.Address(RVA = "0x8990D20", Offset = "0x898FD20", VA = "0x188990D20", Slot = "8")]
	public void JDNGENAKMFJ(Rigidbody OEKAMIKGJCJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002F6")]
	[Cpp2IlInjected.Address(RVA = "0x8990BB0", Offset = "0x898FBB0", VA = "0x188990BB0", Slot = "9")]
	public void AHPFMPBNNKL(Rigidbody OEKAMIKGJCJ)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000035")]
internal sealed class OFENJLMLEMD : NDEJNDNEBID
{
	[Cpp2IlInjected.Token(Token = "0x4000069")]
	private static readonly ONIHMLNNEEF KOGGEMLADKL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400006B")]
	private readonly EHFCEALLCDO FBMIODACPPK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400006C")]
	private bool KDFLCOIGBEO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x21")]
	[Cpp2IlInjected.Token(Token = "0x400006D")]
	private bool EFJFDLAAIAD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
	[Cpp2IlInjected.Token(Token = "0x400006E")]
	private int BGHGFGHLFOJ;

	[Cpp2IlInjected.Token(Token = "0x170000B3")]
	private Rigidbody CHKPFCFBIFF
	{
		[Cpp2IlInjected.Token(Token = "0x60002F9")]
		[Cpp2IlInjected.Address(RVA = "0x89920C0", Offset = "0x89910C0", VA = "0x1889920C0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B4")]
	private bool FAJLADPALHG
	{
		[Cpp2IlInjected.Token(Token = "0x60002FA")]
		[Cpp2IlInjected.Address(RVA = "0x899D2D0", Offset = "0x899C2D0", VA = "0x18899D2D0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B5")]
	private MFIGOAEMMAF GDFCPOBJFDH
	{
		[Cpp2IlInjected.Token(Token = "0x60002FB")]
		[Cpp2IlInjected.Address(RVA = "0x899DAB0", Offset = "0x899CAB0", VA = "0x18899DAB0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B6")]
	private bool FKHKIDHBPAC
	{
		[Cpp2IlInjected.Token(Token = "0x60002FC")]
		[Cpp2IlInjected.Address(RVA = "0x899DA50", Offset = "0x899CA50", VA = "0x18899DA50")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400002D")]
	public event FIIMNHMKNMH DMHOGJALOCI
	{
		[Cpp2IlInjected.Token(Token = "0x60002F7")]
		[Cpp2IlInjected.Address(RVA = "0x899D9B0", Offset = "0x899C9B0", VA = "0x18899D9B0", Slot = "4")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60002F8")]
		[Cpp2IlInjected.Address(RVA = "0x899D610", Offset = "0x899C610", VA = "0x18899D610", Slot = "5")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60002FD")]
	[Cpp2IlInjected.Address(RVA = "0x899DD00", Offset = "0x899CD00", VA = "0x18899DD00")]
	public OFENJLMLEMD(MFIGOAEMMAF FBMIODACPPK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002FE")]
	[Cpp2IlInjected.Address(RVA = "0x899D4E0", Offset = "0x899C4E0", VA = "0x18899D4E0", Slot = "6")]
	public void IDNMFFEDDDN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002FF")]
	[Cpp2IlInjected.Address(RVA = "0x899DB10", Offset = "0x899CB10", VA = "0x18899DB10", Slot = "8")]
	public void PBHDOJBKPMC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000300")]
	[Cpp2IlInjected.Address(RVA = "0x899DB20", Offset = "0x899CB20", VA = "0x18899DB20", Slot = "7")]
	public bool PGBDNOKPCJD()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000301")]
	[Cpp2IlInjected.Address(RVA = "0x899D230", Offset = "0x899C230", VA = "0x18899D230", Slot = "9")]
	public void DHDDBOHNOOD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000302")]
	[Cpp2IlInjected.Address(RVA = "0x899D570", Offset = "0x899C570", VA = "0x18899D570", Slot = "13")]
	public void IPDLPKIGAIL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000303")]
	[Cpp2IlInjected.Address(RVA = "0x899D3B0", Offset = "0x899C3B0", VA = "0x18899D3B0", Slot = "12")]
	public void GKFAMOOJKBH(bool LLLEEKBGHKO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000304")]
	[Cpp2IlInjected.Address(RVA = "0x899D6B0", Offset = "0x899C6B0", VA = "0x18899D6B0", Slot = "10")]
	public bool KMNJDJCJHAC()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000305")]
	[Cpp2IlInjected.Address(RVA = "0x899D2F0", Offset = "0x899C2F0", VA = "0x18899D2F0", Slot = "11")]
	public bool FNMLHEDFMOK()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000306")]
	[Cpp2IlInjected.Address(RVA = "0x899D720", Offset = "0x899C720", VA = "0x18899D720")]
	private bool LBOIMHNHEMC()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000307")]
	[Cpp2IlInjected.Address(RVA = "0x899D0A0", Offset = "0x899C0A0", VA = "0x18899D0A0")]
	private void CBEONJJEPIL()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000036")]
internal sealed class FABLCNAMGAL : HHGNGAAPGIO
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400006F")]
	private readonly EHFCEALLCDO FBMIODACPPK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000070")]
	private readonly IDNPIOCKKCM NMFCPGGHCMI;

	[Cpp2IlInjected.Token(Token = "0x170000B7")]
	public Rigidbody CHKPFCFBIFF
	{
		[Cpp2IlInjected.Token(Token = "0x6000309")]
		[Cpp2IlInjected.Address(RVA = "0xA63F80", Offset = "0xA62F80", VA = "0x180A63F80", Slot = "4")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600030A")]
		[Cpp2IlInjected.Address(RVA = "0xA616B0", Offset = "0xA606B0", VA = "0x180A616B0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B8")]
	private bool FKHKIDHBPAC
	{
		[Cpp2IlInjected.Token(Token = "0x600030B")]
		[Cpp2IlInjected.Address(RVA = "0x89904E0", Offset = "0x898F4E0", VA = "0x1889904E0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B9")]
	public bool MODBDBAJLOL
	{
		[Cpp2IlInjected.Token(Token = "0x600030E")]
		[Cpp2IlInjected.Address(RVA = "0x1A4F590", Offset = "0x1A4E590", VA = "0x181A4F590", Slot = "6")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600030C")]
	[Cpp2IlInjected.Address(RVA = "0x8990870", Offset = "0x898F870", VA = "0x188990870")]
	public FABLCNAMGAL(MFIGOAEMMAF FBMIODACPPK, [In] POOLCNKIBAH INCJDDLACNP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600030D")]
	[Cpp2IlInjected.Address(RVA = "0x8990410", Offset = "0x898F410", VA = "0x188990410", Slot = "5")]
	public void IDNMFFEDDDN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600030F")]
	[Cpp2IlInjected.Address(RVA = "0x89901F0", Offset = "0x898F1F0", VA = "0x1889901F0", Slot = "7")]
	public void CDDNPCBBODL(object GFDDDAIMFOH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000310")]
	[Cpp2IlInjected.Address(RVA = "0x89904B0", Offset = "0x898F4B0", VA = "0x1889904B0", Slot = "8")]
	public void MDHCFFHBIKL(object GFDDDAIMFOH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000311")]
	[Cpp2IlInjected.Address(RVA = "0x8990540", Offset = "0x898F540", VA = "0x188990540", Slot = "9")]
	public void ODPJMMIDBDH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000312")]
	[Cpp2IlInjected.Address(RVA = "0x8990220", Offset = "0x898F220", VA = "0x188990220", Slot = "10")]
	public void CLPEAPKAIJD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000313")]
	[Cpp2IlInjected.Address(RVA = "0x8990070", Offset = "0x898F070", VA = "0x188990070", Slot = "11")]
	public void ABOCNKAIHBK()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000037")]
internal sealed class NAKOGPIGOKL : NKFJANAJGEK, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000072")]
	private readonly EHFCEALLCDO FBMIODACPPK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000073")]
	private readonly IDNPIOCKKCM MJHIMJPMAGE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000074")]
	private float COADJHJPMKC;

	[Cpp2IlInjected.Token(Token = "0x170000BA")]
	public CJDPDAAMOBM MMEHAJFLOLP
	{
		[Cpp2IlInjected.Token(Token = "0x6000314")]
		[Cpp2IlInjected.Address(RVA = "0xA63FE0", Offset = "0xA62FE0", VA = "0x180A63FE0", Slot = "4")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000315")]
		[Cpp2IlInjected.Address(RVA = "0xA63FB0", Offset = "0xA62FB0", VA = "0x180A63FB0", Slot = "5")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000BB")]
	public NEPEHFKKAHG GJFLFCKDPFG
	{
		[Cpp2IlInjected.Token(Token = "0x6000316")]
		[Cpp2IlInjected.Address(RVA = "0xA63FC0", Offset = "0xA62FC0", VA = "0x180A63FC0", Slot = "6")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000317")]
		[Cpp2IlInjected.Address(RVA = "0xA63FA0", Offset = "0xA62FA0", VA = "0x180A63FA0", Slot = "7")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000BC")]
	public Vector3 CEBEECPEOGO
	{
		[Cpp2IlInjected.Token(Token = "0x6000318")]
		[Cpp2IlInjected.Address(RVA = "0x899B310", Offset = "0x899A310", VA = "0x18899B310", Slot = "8")]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x6000319")]
		[Cpp2IlInjected.Address(RVA = "0x899A6F0", Offset = "0x89996F0", VA = "0x18899A6F0", Slot = "9")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000BD")]
	public Vector3 MNAOACFOFFC
	{
		[Cpp2IlInjected.Token(Token = "0x600031A")]
		[Cpp2IlInjected.Address(RVA = "0x8998F40", Offset = "0x8997F40", VA = "0x188998F40", Slot = "10")]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x600031B")]
		[Cpp2IlInjected.Address(RVA = "0x8998820", Offset = "0x8997820", VA = "0x188998820", Slot = "11")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000BE")]
	public Vector3 MPBGIMEBLAH
	{
		[Cpp2IlInjected.Token(Token = "0x600031C")]
		[Cpp2IlInjected.Address(RVA = "0x8998DE0", Offset = "0x8997DE0", VA = "0x188998DE0", Slot = "12")]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x600031D")]
		[Cpp2IlInjected.Address(RVA = "0x8998C10", Offset = "0x8997C10", VA = "0x188998C10", Slot = "13")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000BF")]
	public Vector3 FFGOEMCJOMJ
	{
		[Cpp2IlInjected.Token(Token = "0x600031E")]
		[Cpp2IlInjected.Address(RVA = "0x8998700", Offset = "0x8997700", VA = "0x188998700", Slot = "14")]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x600031F")]
		[Cpp2IlInjected.Address(RVA = "0x8998850", Offset = "0x8997850", VA = "0x188998850", Slot = "15")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000C0")]
	public float ILLCHEIADLB
	{
		[Cpp2IlInjected.Token(Token = "0x6000320")]
		[Cpp2IlInjected.Address(RVA = "0xABEEF0", Offset = "0xABDEF0", VA = "0x180ABEEF0", Slot = "16")]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x6000321")]
		[Cpp2IlInjected.Address(RVA = "0x8998CD0", Offset = "0x8997CD0", VA = "0x188998CD0", Slot = "17")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000C1")]
	public bool NJMEINAJFDB
	{
		[Cpp2IlInjected.Token(Token = "0x6000322")]
		[Cpp2IlInjected.Address(RVA = "0x24AFBB0", Offset = "0x24AEBB0", VA = "0x1824AFBB0", Slot = "18")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000C2")]
	private JDHBKCDFGPA CBABFDOCAGM
	{
		[Cpp2IlInjected.Token(Token = "0x6000337")]
		[Cpp2IlInjected.Address(RVA = "0x7ED6170", Offset = "0x7ED5170", VA = "0x187ED6170")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000C3")]
	private bool FAJLADPALHG
	{
		[Cpp2IlInjected.Token(Token = "0x6000338")]
		[Cpp2IlInjected.Address(RVA = "0x8999BC0", Offset = "0x8998BC0", VA = "0x188999BC0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000323")]
	[Cpp2IlInjected.Address(RVA = "0x899BC90", Offset = "0x899AC90", VA = "0x18899BC90")]
	public NAKOGPIGOKL(MFIGOAEMMAF FBMIODACPPK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000324")]
	[Cpp2IlInjected.Address(RVA = "0x89989A0", Offset = "0x89979A0", VA = "0x1889989A0", Slot = "19")]
	public void IDNMFFEDDDN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000325")]
	[Cpp2IlInjected.Address(RVA = "0x8999470", Offset = "0x8998470", VA = "0x188999470", Slot = "36")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000326")]
	[Cpp2IlInjected.Address(RVA = "0x899B1E0", Offset = "0x899A1E0", VA = "0x18899B1E0", Slot = "28")]
	public void JDNGENAKMFJ(Rigidbody OEKAMIKGJCJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000327")]
	[Cpp2IlInjected.Address(RVA = "0x180F250", Offset = "0x180E250", VA = "0x18180F250", Slot = "20")]
	public void MIIEKMLKNHP(object GFDDDAIMFOH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000328")]
	[Cpp2IlInjected.Address(RVA = "0x180E0B0", Offset = "0x180D0B0", VA = "0x18180E0B0", Slot = "30")]
	public void LDHFPHPCBIG(object GFDDDAIMFOH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000329")]
	[Cpp2IlInjected.Address(RVA = "0x899B000", Offset = "0x899A000", VA = "0x18899B000", Slot = "35")]
	public Vector3 JBOHEHCFJIJ(Vector3 EJHCENJMOAJ)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x600032A")]
	[Cpp2IlInjected.Address(RVA = "0x8998A50", Offset = "0x8997A50", VA = "0x188998A50", Slot = "34")]
	public Vector3 CBFAIKHJJKJ(Vector3 LPNLMKHOCCP)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x600032B")]
	[Cpp2IlInjected.Address(RVA = "0x89989A0", Offset = "0x89979A0", VA = "0x1889989A0", Slot = "27")]
	public void BLKJDILGPAN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600032C")]
	[Cpp2IlInjected.Address(RVA = "0x899A9F0", Offset = "0x89999F0", VA = "0x18899A9F0", Slot = "25")]
	public void IEENEHDMNDP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600032D")]
	[Cpp2IlInjected.Address(RVA = "0x8999B60", Offset = "0x8998B60", VA = "0x188999B60", Slot = "24")]
	public void EOHEMBCJBEF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600032E")]
	[Cpp2IlInjected.Address(RVA = "0x899A7B0", Offset = "0x89997B0", VA = "0x18899A7B0", Slot = "33")]
	public void HMFOBNPECJD(Vector3 MKOHLGDKLKH, Vector3 BCOOKGPOLPI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600032F")]
	[Cpp2IlInjected.Address(RVA = "0x89994D0", Offset = "0x89984D0", VA = "0x1889994D0", Slot = "32")]
	public void EAGOLEOOLDD(Vector3 MPLGBPBMKDL, Vector3 JOHCPGENEAP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000330")]
	[Cpp2IlInjected.Address(RVA = "0x89999C0", Offset = "0x89989C0", VA = "0x1889999C0", Slot = "31")]
	public void ENLCBFECKGI(Vector3 GKNFGDJONME)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000331")]
	[Cpp2IlInjected.Address(RVA = "0x899B460", Offset = "0x899A460", VA = "0x18899B460", Slot = "22")]
	public void KDKEDIKDALM(PDEAKMCNOBP BHODJGJGDPL, Vector3 HDFLLIHEFEL, float BHOMNNEBJAB, float NFNKFEGBCDH = 8f, float BFCHCLEELBL = 1f)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000332")]
	[Cpp2IlInjected.Address(RVA = "0x8999BE0", Offset = "0x8998BE0", VA = "0x188999BE0", Slot = "21")]
	public void FHALJOPICEM(IPOBJHPAPLB IIMDKLGOCHN, Vector3 PDIJEFFPDPG, float HIFIKLNHOGN = float.PositiveInfinity)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000333")]
	[Cpp2IlInjected.Address(RVA = "0x899A300", Offset = "0x8999300", VA = "0x18899A300", Slot = "23")]
	[Obsolete("Deprecated. Still exists to support deprecated CV2 chips. Use ApplyAngularVelocityChange.")]
	public void GJMOALLKOJC(IPOBJHPAPLB IIMDKLGOCHN, Vector3 KDHLIJMPIFF, float FJKPDIEAPAB = 7f, float CGBPKBEEFCI = 1f)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000334")]
	[Cpp2IlInjected.Address(RVA = "0x195E340", Offset = "0x195D340", VA = "0x18195E340")]
	private static void HPLAJJGLFIM(Vector3 PJFEPLADHFM, Vector3 PNJPAIKKPPF, [Out] Vector3 OLNBHPDOOIL, [Out] Vector3 LDCHNMAJMFL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000335")]
	[Cpp2IlInjected.Address(RVA = "0x89991F0", Offset = "0x89981F0", VA = "0x1889991F0", Slot = "29")]
	public Vector3 DMPOJLEPCJM(Vector3 PJFEPLADHFM)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000336")]
	[Cpp2IlInjected.Address(RVA = "0x8999060", Offset = "0x8998060", VA = "0x188999060", Slot = "26")]
	public void DMKJCHLEDNN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000339")]
	[Cpp2IlInjected.Address(RVA = "0x8998CD0", Offset = "0x8997CD0", VA = "0x188998CD0")]
	private void NGNFPOOPCAO(float IOALKPFEKEK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600033A")]
	[Cpp2IlInjected.Address(RVA = "0x89992D0", Offset = "0x89982D0", VA = "0x1889992D0")]
	private void DOALIINNBKC(Vector3 PDIJEFFPDPG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600033B")]
	[Cpp2IlInjected.Address(RVA = "0x899BB70", Offset = "0x899AB70", VA = "0x18899BB70")]
	private Vector3 OJPJBFJGANO()
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x600033C")]
	[Cpp2IlInjected.Address(RVA = "0x8999530", Offset = "0x8998530", VA = "0x188999530")]
	private void EJGNACGPIDC(Vector3 LPNLMKHOCCP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600033D")]
	[Cpp2IlInjected.Address(RVA = "0x8998880", Offset = "0x8997880", VA = "0x188998880")]
	private Vector3 BJBALAFBFOB()
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x600033E")]
	[Cpp2IlInjected.Address(RVA = "0x8999E70", Offset = "0x8998E70", VA = "0x188999E70")]
	private void GFJLALCLDJA(Vector3 IOALKPFEKEK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600033F")]
	[Cpp2IlInjected.Address(RVA = "0x899AA50", Offset = "0x8999A50", VA = "0x18899AA50")]
	private void JBDICJJNEMF(Vector3 LPNLMKHOCCP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000340")]
	[Cpp2IlInjected.Address(RVA = "0x899BAC0", Offset = "0x899AAC0", VA = "0x18899BAC0")]
	private void OINOKDEGGNH()
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
