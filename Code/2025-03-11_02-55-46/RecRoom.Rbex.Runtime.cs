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
	public class LogRegistrationIndex : KENHJELJHDP
	{
		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(RVA = "0x7D313C0", Offset = "0x7D307C0", VA = "0x187D313C0", Slot = "4")]
		public override void ICLMLJMBJAH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0x98FE40", Offset = "0x98F240", VA = "0x18098FE40")]
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
			[Cpp2IlInjected.Address(RVA = "0x969450", Offset = "0x968850", VA = "0x180969450", Slot = "4")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x1E8F400", Offset = "0x1E8E800", VA = "0x181E8F400", Slot = "5")]
		public override void SetServiceCategoryIndices(List<int> globalFromLocalIndices)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x7D38AB0", Offset = "0x7D37EB0", VA = "0x187D38AB0")]
		private void PFONFFPEPLP(IServiceRegistration registry)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x7D38DC0", Offset = "0x7D381C0", VA = "0x187D38DC0", Slot = "6")]
		public override void RegisterServices(IServiceRegistration registry, [In] ServiceBitsetFilter filter)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x7D38E20", Offset = "0x7D38220", VA = "0x187D38E20")]
		public _AssemblyIndex()
		{
		}
	}
}
namespace RecRoom
{
	[Cpp2IlInjected.Token(Token = "0x2000004")]
	[DisallowMultipleComponent]
	public sealed class RigidbodyEx : MonoBehaviour, AIOKEFGMGBL, PCDEJAOCFEP, GLNJOIJGFPB
	{
		[Cpp2IlInjected.Token(Token = "0x4000004")]
		private static readonly HLBHMADGLFA ACCKECKEJFP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000005")]
		private bool GCAMAFKDIEB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000006")]
		private ONELOFJJHKK ABBEFNLLLMK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000007")]
		[NMHMDFOPAOE(MFMOBKOPAIF.Self, false, false, false)]
		[SerializeField]
		private Rigidbody unityRigidbody;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000008")]
		[SerializeField]
		[NMHMDFOPAOE(MFMOBKOPAIF.SelfAndParent, true, false, false)]
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
		private HFGJKELOCBA physicsInterpolation;

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
		private Transform PPFNCAENGPJ;

		[Cpp2IlInjected.Token(Token = "0x17000002")]
		internal ONELOFJJHKK BCFJPNINOHE
		{
			[Cpp2IlInjected.Token(Token = "0x6000008")]
			[Cpp2IlInjected.Address(RVA = "0x7D346E0", Offset = "0x7D33AE0", VA = "0x187D346E0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000003")]
		private ONELOFJJHKK HLPPMDFEHAH
		{
			[Cpp2IlInjected.Token(Token = "0x6000009")]
			[Cpp2IlInjected.Address(RVA = "0x9682E0", Offset = "0x9676E0", VA = "0x1809682E0", Slot = "6")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000004")]
		public int FKMOCIHFONL
		{
			[Cpp2IlInjected.Token(Token = "0x600001E")]
			[Cpp2IlInjected.Address(RVA = "0x7D35FC0", Offset = "0x7D353C0", VA = "0x187D35FC0")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000005")]
		public RigidbodyEx LPNFLPPNAFC
		{
			[Cpp2IlInjected.Token(Token = "0x6000020")]
			[Cpp2IlInjected.Address(RVA = "0x7D36320", Offset = "0x7D35720", VA = "0x187D36320")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000006")]
		public RigidbodyEx JMIAMIHOFLD
		{
			[Cpp2IlInjected.Token(Token = "0x6000021")]
			[Cpp2IlInjected.Address(RVA = "0x7D36260", Offset = "0x7D35660", VA = "0x187D36260")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000007")]
		public RigidbodyEx HKNGNFLDPKM
		{
			[Cpp2IlInjected.Token(Token = "0x6000022")]
			[Cpp2IlInjected.Address(RVA = "0x7D36F20", Offset = "0x7D36320", VA = "0x187D36F20")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000023")]
			[Cpp2IlInjected.Address(RVA = "0x7D38420", Offset = "0x7D37820", VA = "0x187D38420")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000008")]
		public bool OPONMODNLPB
		{
			[Cpp2IlInjected.Token(Token = "0x6000024")]
			[Cpp2IlInjected.Address(RVA = "0x79A9B70", Offset = "0x79A8F70", VA = "0x1879A9B70", Slot = "11")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000025")]
			[Cpp2IlInjected.Address(RVA = "0x79A83E0", Offset = "0x79A77E0", VA = "0x1879A83E0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000009")]
		public Transform NCNOHDPHPJB
		{
			[Cpp2IlInjected.Token(Token = "0x6000026")]
			[Cpp2IlInjected.Address(RVA = "0x1CC9770", Offset = "0x1CC8B70", VA = "0x181CC9770", Slot = "5")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000A")]
		public Transform MDKCLMFIFHN
		{
			[Cpp2IlInjected.Token(Token = "0x6000027")]
			[Cpp2IlInjected.Address(RVA = "0x1CC9770", Offset = "0x1CC8B70", VA = "0x181CC9770", Slot = "13")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000B")]
		public Transform IAIIKNABOLF
		{
			[Cpp2IlInjected.Token(Token = "0x6000028")]
			[Cpp2IlInjected.Address(RVA = "0x1CC9770", Offset = "0x1CC8B70", VA = "0x181CC9770", Slot = "14")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000C")]
		public MGFGMPBMECL DHLEHOILFIK
		{
			[Cpp2IlInjected.Token(Token = "0x6000029")]
			[Cpp2IlInjected.Address(RVA = "0x7D36020", Offset = "0x7D35420", VA = "0x187D36020")]
			get
			{
				return default(MGFGMPBMECL);
			}
			[Cpp2IlInjected.Token(Token = "0x600002A")]
			[Cpp2IlInjected.Address(RVA = "0x7D37BD0", Offset = "0x7D36FD0", VA = "0x187D37BD0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000D")]
		public bool CNDIOOMAJAG
		{
			[Cpp2IlInjected.Token(Token = "0x600002B")]
			[Cpp2IlInjected.Address(RVA = "0x7D36630", Offset = "0x7D35A30", VA = "0x187D36630")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000E")]
		public bool FGJLIHNAGOB
		{
			[Cpp2IlInjected.Token(Token = "0x600002C")]
			[Cpp2IlInjected.Address(RVA = "0x7D36140", Offset = "0x7D35540", VA = "0x187D36140")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000F")]
		public NOLNOOCKIJK IHHDBKNFBBI
		{
			[Cpp2IlInjected.Token(Token = "0x600002D")]
			[Cpp2IlInjected.Address(RVA = "0x7D36570", Offset = "0x7D35970", VA = "0x187D36570")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600002E")]
			[Cpp2IlInjected.Address(RVA = "0x7D37D90", Offset = "0x7D37190", VA = "0x187D37D90")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000010")]
		public GLBOIBMAJCP PJLCPLILAJO
		{
			[Cpp2IlInjected.Token(Token = "0x600002F")]
			[Cpp2IlInjected.Address(RVA = "0x7D36510", Offset = "0x7D35910", VA = "0x187D36510")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000030")]
			[Cpp2IlInjected.Address(RVA = "0x7D37D20", Offset = "0x7D37120", VA = "0x187D37D20")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000011")]
		public bool ADKKEMHDLMA
		{
			[Cpp2IlInjected.Token(Token = "0x6000031")]
			[Cpp2IlInjected.Address(RVA = "0x7D36460", Offset = "0x7D35860", VA = "0x187D36460")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000012")]
		public Rigidbody NDDOBLHGPFH
		{
			[Cpp2IlInjected.Token(Token = "0x6000032")]
			[Cpp2IlInjected.Address(RVA = "0x7D364C0", Offset = "0x7D358C0", VA = "0x187D364C0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000013")]
		public bool EMGGFBFPNEC
		{
			[Cpp2IlInjected.Token(Token = "0x6000033")]
			[Cpp2IlInjected.Address(RVA = "0x7D361A0", Offset = "0x7D355A0", VA = "0x187D361A0")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000034")]
			[Cpp2IlInjected.Address(RVA = "0x7D37C40", Offset = "0x7D37040", VA = "0x187D37C40")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000014")]
		public bool CLNDLPIPIGD
		{
			[Cpp2IlInjected.Token(Token = "0x6000035")]
			[Cpp2IlInjected.Address(RVA = "0x1412EA0", Offset = "0x14122A0", VA = "0x181412EA0", Slot = "7")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000015")]
		public float KJCLMALJCKC
		{
			[Cpp2IlInjected.Token(Token = "0x6000036")]
			[Cpp2IlInjected.Address(RVA = "0x7D36EC0", Offset = "0x7D362C0", VA = "0x187D36EC0")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000016")]
		public float OANBPDAGANI
		{
			[Cpp2IlInjected.Token(Token = "0x6000037")]
			[Cpp2IlInjected.Address(RVA = "0x7D36E60", Offset = "0x7D36260", VA = "0x187D36E60")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x6000038")]
			[Cpp2IlInjected.Address(RVA = "0x7D383B0", Offset = "0x7D377B0", VA = "0x187D383B0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000017")]
		public float IMCAIGOOKBG
		{
			[Cpp2IlInjected.Token(Token = "0x6000039")]
			[Cpp2IlInjected.Address(RVA = "0x7D36890", Offset = "0x7D35C90", VA = "0x187D36890")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x600003A")]
			[Cpp2IlInjected.Address(RVA = "0x7D38030", Offset = "0x7D37430", VA = "0x187D38030")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000018")]
		public float FHCMKDGDFDN
		{
			[Cpp2IlInjected.Token(Token = "0x600003B")]
			[Cpp2IlInjected.Address(RVA = "0x7D36690", Offset = "0x7D35A90", VA = "0x187D36690")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x600003C")]
			[Cpp2IlInjected.Address(RVA = "0x7D37E00", Offset = "0x7D37200", VA = "0x187D37E00")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000019")]
		public bool GCDMEIDJHHH
		{
			[Cpp2IlInjected.Token(Token = "0x600003D")]
			[Cpp2IlInjected.Address(RVA = "0x7D37470", Offset = "0x7D36870", VA = "0x187D37470")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x600003E")]
			[Cpp2IlInjected.Address(RVA = "0x7D38960", Offset = "0x7D37D60", VA = "0x187D38960")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001A")]
		public Vector3 KFHJLHKBAKC
		{
			[Cpp2IlInjected.Token(Token = "0x600003F")]
			[Cpp2IlInjected.Address(RVA = "0x7D36C40", Offset = "0x7D36040", VA = "0x187D36C40")]
			get
			{
				return default(Vector3);
			}
			[Cpp2IlInjected.Token(Token = "0x6000040")]
			[Cpp2IlInjected.Address(RVA = "0x7D38180", Offset = "0x7D37580", VA = "0x187D38180")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001B")]
		public Vector3 PDMCMACMABG
		{
			[Cpp2IlInjected.Token(Token = "0x6000041")]
			[Cpp2IlInjected.Address(RVA = "0x7D375B0", Offset = "0x7D369B0", VA = "0x187D375B0")]
			get
			{
				return default(Vector3);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001C")]
		public CollisionDetectionMode OBBJBEPLBMN
		{
			[Cpp2IlInjected.Token(Token = "0x6000042")]
			[Cpp2IlInjected.Address(RVA = "0x7D367D0", Offset = "0x7D35BD0", VA = "0x187D367D0")]
			get
			{
				return default(CollisionDetectionMode);
			}
			[Cpp2IlInjected.Token(Token = "0x6000043")]
			[Cpp2IlInjected.Address(RVA = "0x7D37F50", Offset = "0x7D37350", VA = "0x187D37F50")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001D")]
		public float OIGFIEJGDKP
		{
			[Cpp2IlInjected.Token(Token = "0x6000044")]
			[Cpp2IlInjected.Address(RVA = "0x7D36200", Offset = "0x7D35600", VA = "0x187D36200")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x6000045")]
			[Cpp2IlInjected.Address(RVA = "0x7D37CB0", Offset = "0x7D370B0", VA = "0x187D37CB0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001E")]
		public RigidbodyConstraints MEHEDGHBFCE
		{
			[Cpp2IlInjected.Token(Token = "0x6000046")]
			[Cpp2IlInjected.Address(RVA = "0x7D36830", Offset = "0x7D35C30", VA = "0x187D36830")]
			get
			{
				return default(RigidbodyConstraints);
			}
			[Cpp2IlInjected.Token(Token = "0x6000047")]
			[Cpp2IlInjected.Address(RVA = "0x7D37FC0", Offset = "0x7D373C0", VA = "0x187D37FC0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001F")]
		public Vector3 PBILFJLKOLE
		{
			[Cpp2IlInjected.Token(Token = "0x6000048")]
			[Cpp2IlInjected.Address(RVA = "0x7D36FE0", Offset = "0x7D363E0", VA = "0x187D36FE0")]
			get
			{
				return default(Vector3);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000020")]
		public Vector3 OGJJAAKCCDK
		{
			[Cpp2IlInjected.Token(Token = "0x6000049")]
			[Cpp2IlInjected.Address(RVA = "0x7D36FE0", Offset = "0x7D363E0", VA = "0x187D36FE0")]
			get
			{
				return default(Vector3);
			}
			[Cpp2IlInjected.Token(Token = "0x600004A")]
			[Cpp2IlInjected.Address(RVA = "0x7D38740", Offset = "0x7D37B40", VA = "0x187D38740")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000021")]
		public float KDMIHODHLMD
		{
			[Cpp2IlInjected.Token(Token = "0x600004B")]
			[Cpp2IlInjected.Address(RVA = "0x7D36D20", Offset = "0x7D36120", VA = "0x187D36D20")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x600004C")]
			[Cpp2IlInjected.Address(RVA = "0x7D38260", Offset = "0x7D37660", VA = "0x187D38260")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000022")]
		public float HNJKBNLLGOH
		{
			[Cpp2IlInjected.Token(Token = "0x600004D")]
			[Cpp2IlInjected.Address(RVA = "0x7D37410", Offset = "0x7D36810", VA = "0x187D37410")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x600004E")]
			[Cpp2IlInjected.Address(RVA = "0x7D388F0", Offset = "0x7D37CF0", VA = "0x187D388F0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000023")]
		public Quaternion DJLPDCDDPKD
		{
			[Cpp2IlInjected.Token(Token = "0x600004F")]
			[Cpp2IlInjected.Address(RVA = "0x7D370C0", Offset = "0x7D364C0", VA = "0x187D370C0")]
			get
			{
				return default(Quaternion);
			}
			[Cpp2IlInjected.Token(Token = "0x6000050")]
			[Cpp2IlInjected.Address(RVA = "0x7D384C0", Offset = "0x7D378C0", VA = "0x187D384C0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000024")]
		public Quaternion LMBGEFNEGCC
		{
			[Cpp2IlInjected.Token(Token = "0x6000051")]
			[Cpp2IlInjected.Address(RVA = "0x7D37340", Offset = "0x7D36740", VA = "0x187D37340")]
			get
			{
				return default(Quaternion);
			}
			[Cpp2IlInjected.Token(Token = "0x6000052")]
			[Cpp2IlInjected.Address(RVA = "0x7D38820", Offset = "0x7D37C20", VA = "0x187D38820")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000025")]
		public Vector3 NHAJKCKBIDI
		{
			[Cpp2IlInjected.Token(Token = "0x6000053")]
			[Cpp2IlInjected.Address(RVA = "0x7D37190", Offset = "0x7D36590", VA = "0x187D37190")]
			get
			{
				return default(Vector3);
			}
			[Cpp2IlInjected.Token(Token = "0x6000054")]
			[Cpp2IlInjected.Address(RVA = "0x7D38590", Offset = "0x7D37990", VA = "0x187D38590")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000026")]
		public Quaternion DPLJOCJPEJI
		{
			[Cpp2IlInjected.Token(Token = "0x6000055")]
			[Cpp2IlInjected.Address(RVA = "0x7D37270", Offset = "0x7D36670", VA = "0x187D37270")]
			get
			{
				return default(Quaternion);
			}
			[Cpp2IlInjected.Token(Token = "0x6000056")]
			[Cpp2IlInjected.Address(RVA = "0x7D38670", Offset = "0x7D37A70", VA = "0x187D38670")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000027")]
		public Vector3 BCGMKGELHNE
		{
			[Cpp2IlInjected.Token(Token = "0x6000057")]
			[Cpp2IlInjected.Address(RVA = "0x7D374D0", Offset = "0x7D368D0", VA = "0x187D374D0")]
			get
			{
				return default(Vector3);
			}
			[Cpp2IlInjected.Token(Token = "0x6000058")]
			[Cpp2IlInjected.Address(RVA = "0x7D389D0", Offset = "0x7D37DD0", VA = "0x187D389D0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000028")]
		public Vector3 HAMOEAEOAOL
		{
			[Cpp2IlInjected.Token(Token = "0x6000059")]
			[Cpp2IlInjected.Address(RVA = "0x7D36D80", Offset = "0x7D36180", VA = "0x187D36D80")]
			get
			{
				return default(Vector3);
			}
			[Cpp2IlInjected.Token(Token = "0x600005A")]
			[Cpp2IlInjected.Address(RVA = "0x7D382D0", Offset = "0x7D376D0", VA = "0x187D382D0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000029")]
		public Vector3 GKHALKPEBDP
		{
			[Cpp2IlInjected.Token(Token = "0x600005B")]
			[Cpp2IlInjected.Address(RVA = "0x7D366F0", Offset = "0x7D35AF0", VA = "0x187D366F0")]
			get
			{
				return default(Vector3);
			}
			[Cpp2IlInjected.Token(Token = "0x600005C")]
			[Cpp2IlInjected.Address(RVA = "0x7D37E70", Offset = "0x7D37270", VA = "0x187D37E70")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002A")]
		public Vector3 LFBNKFHGCCC
		{
			[Cpp2IlInjected.Token(Token = "0x600005D")]
			[Cpp2IlInjected.Address(RVA = "0x7D36B60", Offset = "0x7D35F60", VA = "0x187D36B60")]
			get
			{
				return default(Vector3);
			}
			[Cpp2IlInjected.Token(Token = "0x600005E")]
			[Cpp2IlInjected.Address(RVA = "0x7D380A0", Offset = "0x7D374A0", VA = "0x187D380A0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002B")]
		public Vector3 NLLCNCDPKGI
		{
			[Cpp2IlInjected.Token(Token = "0x600005F")]
			[Cpp2IlInjected.Address(RVA = "0x7D36A20", Offset = "0x7D35E20", VA = "0x187D36A20")]
			get
			{
				return default(Vector3);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002C")]
		public Quaternion KOPABBBJNIK
		{
			[Cpp2IlInjected.Token(Token = "0x6000060")]
			[Cpp2IlInjected.Address(RVA = "0x7D36950", Offset = "0x7D35D50", VA = "0x187D36950")]
			get
			{
				return default(Quaternion);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002D")]
		public Vector3 BBPHDALNLHG
		{
			[Cpp2IlInjected.Token(Token = "0x6000062")]
			[Cpp2IlInjected.Address(RVA = "0x7D37770", Offset = "0x7D36B70", VA = "0x187D37770")]
			get
			{
				return default(Vector3);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002E")]
		public Vector3 OCMHCMEAMAN
		{
			[Cpp2IlInjected.Token(Token = "0x6000063")]
			[Cpp2IlInjected.Address(RVA = "0x7D37690", Offset = "0x7D36A90", VA = "0x187D37690")]
			get
			{
				return default(Vector3);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002F")]
		public bool KCMENFHDDPM
		{
			[Cpp2IlInjected.Token(Token = "0x6000064")]
			[Cpp2IlInjected.Address(RVA = "0x7D36B00", Offset = "0x7D35F00", VA = "0x187D36B00")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000030")]
		public bool CAKDAAMDCMC
		{
			[Cpp2IlInjected.Token(Token = "0x6000065")]
			[Cpp2IlInjected.Address(RVA = "0x7D365D0", Offset = "0x7D359D0", VA = "0x187D365D0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000031")]
		public bool BMBJPBIDOHG
		{
			[Cpp2IlInjected.Token(Token = "0x6000066")]
			[Cpp2IlInjected.Address(RVA = "0x7D360E0", Offset = "0x7D354E0", VA = "0x187D360E0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000032")]
		public bool BJOIMJAFIGF
		{
			[Cpp2IlInjected.Token(Token = "0x6000067")]
			[Cpp2IlInjected.Address(RVA = "0x7D36080", Offset = "0x7D35480", VA = "0x187D36080")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000033")]
		public bool APFOPKOGENJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000068")]
			[Cpp2IlInjected.Address(RVA = "0x7D35F60", Offset = "0x7D35360", VA = "0x187D35F60")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000034")]
		public bool GCDBPBPOPHC
		{
			[Cpp2IlInjected.Token(Token = "0x6000069")]
			[Cpp2IlInjected.Address(RVA = "0x7D368F0", Offset = "0x7D35CF0", VA = "0x187D368F0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000035")]
		public bool GJIAKANDJHL
		{
			[Cpp2IlInjected.Token(Token = "0x600006A")]
			[Cpp2IlInjected.Address(RVA = "0x21573B0", Offset = "0x21567B0", VA = "0x1821573B0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000001")]
		public event DHIOLIJFBFO BMDMMKJLHMA
		{
			[Cpp2IlInjected.Token(Token = "0x600000E")]
			[Cpp2IlInjected.Address(RVA = "0x7D35E80", Offset = "0x7D35280", VA = "0x187D35E80")]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x600000F")]
			[Cpp2IlInjected.Address(RVA = "0x7D37AF0", Offset = "0x7D36EF0", VA = "0x187D37AF0")]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000002")]
		public event HKHCEGJIAFD LLNDJKBCKGM
		{
			[Cpp2IlInjected.Token(Token = "0x6000010")]
			[Cpp2IlInjected.Address(RVA = "0x7D35BF0", Offset = "0x7D34FF0", VA = "0x187D35BF0")]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000011")]
			[Cpp2IlInjected.Address(RVA = "0x7D37850", Offset = "0x7D36C50", VA = "0x187D37850")]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000003")]
		public event HKHCEGJIAFD JDPMJLLIHGJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000012")]
			[Cpp2IlInjected.Address(RVA = "0x7D35C50", Offset = "0x7D35050", VA = "0x187D35C50")]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000013")]
			[Cpp2IlInjected.Address(RVA = "0x7D378C0", Offset = "0x7D36CC0", VA = "0x187D378C0")]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000004")]
		public event HKHCEGJIAFD MGNJMKOGHOG
		{
			[Cpp2IlInjected.Token(Token = "0x6000014")]
			[Cpp2IlInjected.Address(RVA = "0x7D35DA0", Offset = "0x7D351A0", VA = "0x187D35DA0")]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000015")]
			[Cpp2IlInjected.Address(RVA = "0x7D37A10", Offset = "0x7D36E10", VA = "0x187D37A10")]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000005")]
		public event Action<BJOOMCLMBJJ, BJOOMCLMBJJ> PKKNONLFKJH
		{
			[Cpp2IlInjected.Token(Token = "0x6000016")]
			[Cpp2IlInjected.Address(RVA = "0x7D35D30", Offset = "0x7D35130", VA = "0x187D35D30")]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000017")]
			[Cpp2IlInjected.Address(RVA = "0x7D379A0", Offset = "0x7D36DA0", VA = "0x187D379A0")]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000006")]
		public event HKHCEGJIAFD DHKODOINMAB
		{
			[Cpp2IlInjected.Token(Token = "0x6000018")]
			[Cpp2IlInjected.Address(RVA = "0x7D35E10", Offset = "0x7D35210", VA = "0x187D35E10")]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000019")]
			[Cpp2IlInjected.Address(RVA = "0x7D37A80", Offset = "0x7D36E80", VA = "0x187D37A80")]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000007")]
		public event HKHCEGJIAFD CIAPGAPCOEB
		{
			[Cpp2IlInjected.Token(Token = "0x600001A")]
			[Cpp2IlInjected.Address(RVA = "0x7D35EF0", Offset = "0x7D352F0", VA = "0x187D35EF0")]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x600001B")]
			[Cpp2IlInjected.Address(RVA = "0x7D37B60", Offset = "0x7D36F60", VA = "0x187D37B60")]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000008")]
		public event HKHCEGJIAFD IKKJDJGKMMD
		{
			[Cpp2IlInjected.Token(Token = "0x600001C")]
			[Cpp2IlInjected.Address(RVA = "0x7D35CC0", Offset = "0x7D350C0", VA = "0x187D35CC0")]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x600001D")]
			[Cpp2IlInjected.Address(RVA = "0x7D37930", Offset = "0x7D36D30", VA = "0x187D37930")]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x968070", Offset = "0x967470", VA = "0x180968070", Slot = "8")]
		private void GOJLOPGJMPB(ONELOFJJHKK FBFIKJCNBGP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x7D34650", Offset = "0x7D33A50", VA = "0x187D34650", Slot = "9")]
		public FJIIBPHJJOB GetData()
		{
			return default(FJIIBPHJJOB);
		}

		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x7D34310", Offset = "0x7D33710", VA = "0x187D34310")]
		internal void FKHMMNDNPLL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x7D35920", Offset = "0x7D34D20", VA = "0x187D35920")]
		[Conditional("DEBUG_BUILD")]
		[Conditional("UNITY_EDITOR")]
		public void TestOverrideUnityRigidbody(Rigidbody OAOAGDEEGOO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x7D343A0", Offset = "0x7D337A0", VA = "0x187D343A0")]
		public AIOKEFGMGBL GetChild(int FFCBHHABFJN)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000061")]
		[Cpp2IlInjected.Address(RVA = "0x7D355E0", Offset = "0x7D349E0", VA = "0x187D355E0")]
		public void SetInertiaTensor((Quaternion rot, Vector3 moments) OLBACLDODGO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006B")]
		[Cpp2IlInjected.Address(RVA = "0x7D33F70", Offset = "0x7D33370", VA = "0x187D33F70")]
		private void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006C")]
		[Cpp2IlInjected.Address(RVA = "0x7D35870", Offset = "0x7D34C70", VA = "0x187D35870")]
		protected void Start()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006D")]
		[Cpp2IlInjected.Address(RVA = "0x7D346E0", Offset = "0x7D33AE0", VA = "0x187D346E0")]
		private ONELOFJJHKK HMMCFIMPHIC()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600006E")]
		[Cpp2IlInjected.Address(RVA = "0x7D34B00", Offset = "0x7D33F00", VA = "0x187D34B00")]
		private void MEKFCHHLHOB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006F")]
		[Cpp2IlInjected.Address(RVA = "0x7D34DA0", Offset = "0x7D341A0", VA = "0x187D34DA0")]
		private void OnEnable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000070")]
		[Cpp2IlInjected.Address(RVA = "0x7D34CE0", Offset = "0x7D340E0", VA = "0x187D34CE0")]
		public void OnDisable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000071")]
		[Cpp2IlInjected.Address(RVA = "0x7D34310", Offset = "0x7D33710", VA = "0x187D34310")]
		private void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000072")]
		[Cpp2IlInjected.Address(RVA = "0x7D34D40", Offset = "0x7D34140", VA = "0x187D34D40")]
		private void OnDrawGizmosSelected()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000073")]
		[Cpp2IlInjected.Address(RVA = "0x7D34E00", Offset = "0x7D34200", VA = "0x187D34E00")]
		private void OnValidate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000074")]
		[Cpp2IlInjected.Address(RVA = "0x7D335C0", Offset = "0x7D329C0", VA = "0x187D335C0")]
		public void AddDoNotResetVelocityOnOwnershipChangeOverride(object OCDOGNMJENC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000075")]
		[Cpp2IlInjected.Address(RVA = "0x7D34E70", Offset = "0x7D34270", VA = "0x187D34E70")]
		public void RemoveDoNotResetVelocityOnOwnershipChangeOverride(object OCDOGNMJENC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000076")]
		[Cpp2IlInjected.Address(RVA = "0x7D342B0", Offset = "0x7D336B0", VA = "0x187D342B0")]
		public void DisableCachedInertialPropertyOverride()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000077")]
		[Cpp2IlInjected.Address(RVA = "0x7D34C80", Offset = "0x7D34080", VA = "0x187D34C80")]
		public void MarkCachedInertialParametersDirty()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000078")]
		[Cpp2IlInjected.Address(RVA = "0x7D35740", Offset = "0x7D34B40", VA = "0x187D35740")]
		public void SetParent(RigidbodyEx PEBNJNGMMHE, bool DPDMJKGJHHG = false)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000079")]
		[Cpp2IlInjected.Address(RVA = "0x7D35180", Offset = "0x7D34580", VA = "0x187D35180")]
		public void ResetLocalCenterOfMassToPrefabDefault()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007A")]
		[Cpp2IlInjected.Address(RVA = "0x7D34790", Offset = "0x7D33B90", VA = "0x187D34790")]
		public bool IsRigidbodyAncestor(RigidbodyEx GEBJJAIONLF)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600007B")]
		[Cpp2IlInjected.Address(RVA = "0x7D34890", Offset = "0x7D33C90", VA = "0x187D34890")]
		public bool IsRigidbodyDescendant(RigidbodyEx CKEMJAECKMK)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600007C")]
		[Cpp2IlInjected.Address(RVA = "0x7D33830", Offset = "0x7D32C30", VA = "0x187D33830")]
		public void AddInterpolationRestriction(object OCDOGNMJENC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007D")]
		[Cpp2IlInjected.Address(RVA = "0x7D34EE0", Offset = "0x7D342E0", VA = "0x187D34EE0")]
		public void RemoveInterpolationRestriction(object OCDOGNMJENC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007E")]
		[Cpp2IlInjected.Address(RVA = "0x7D338A0", Offset = "0x7D32CA0", VA = "0x187D338A0")]
		public void AddKinematic(object OCDOGNMJENC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007F")]
		[Cpp2IlInjected.Address(RVA = "0x7D34F50", Offset = "0x7D34350", VA = "0x187D34F50")]
		public void RemoveKinematic(object OCDOGNMJENC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000080")]
		[Cpp2IlInjected.Address(RVA = "0x7D356C0", Offset = "0x7D34AC0", VA = "0x187D356C0")]
		public void SetKinematic(object OCDOGNMJENC, bool DFOLNBHIIIF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000081")]
		[Cpp2IlInjected.Address(RVA = "0x7D354E0", Offset = "0x7D348E0", VA = "0x187D354E0")]
		public void SetDiscontinuousPositionAndRotation(Vector3 HIHJAMLBDMM, Quaternion IPCECJGNNOH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000082")]
		[Cpp2IlInjected.Address(RVA = "0x7D353E0", Offset = "0x7D347E0", VA = "0x187D353E0")]
		public void SetDiscontinuousLocalPositionAndLocalRotation(Vector3 FAGINDBMAJI, Quaternion LNIJFOMFDAF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000083")]
		[Cpp2IlInjected.Address(RVA = "0x7D34540", Offset = "0x7D33940", VA = "0x187D34540")]
		public Vector3 GetConstrainedVelocity(Vector3 BCGMKGELHNE)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x6000084")]
		[Cpp2IlInjected.Address(RVA = "0x7D34430", Offset = "0x7D33830", VA = "0x187D34430")]
		public Vector3 GetConstrainedAngularVelocity(Vector3 GKHALKPEBDP)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x6000085")]
		[Cpp2IlInjected.Address(RVA = "0x7D33740", Offset = "0x7D32B40", VA = "0x187D33740")]
		public void AddForce(Vector3 JLJMBNIAGMB, ForceMode NELEMMPBMFP = ForceMode.Force)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000086")]
		[Cpp2IlInjected.Address(RVA = "0x7D33630", Offset = "0x7D32A30", VA = "0x187D33630")]
		public void AddForceAtPosition(Vector3 JLJMBNIAGMB, Vector3 HJBDDDIFEBJ, ForceMode NELEMMPBMFP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000087")]
		[Cpp2IlInjected.Address(RVA = "0x7D33A70", Offset = "0x7D32E70", VA = "0x187D33A70")]
		public void AddTorque(Vector3 KCHPPHPFPDG, ForceMode NELEMMPBMFP = ForceMode.Force)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000088")]
		[Cpp2IlInjected.Address(RVA = "0x7D33910", Offset = "0x7D32D10", VA = "0x187D33910")]
		public void AddRelativeTorque(Vector3 KCHPPHPFPDG, ForceMode NELEMMPBMFP = ForceMode.Force)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000089")]
		[Cpp2IlInjected.Address(RVA = "0x7D359F0", Offset = "0x7D34DF0", VA = "0x187D359F0")]
		public Vector3 WorldToLocalVelocity(Vector3 JDACPJAFGEP)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x600008A")]
		[Cpp2IlInjected.Address(RVA = "0x7D349F0", Offset = "0x7D33DF0", VA = "0x187D349F0")]
		public Vector3 LocalToWorldVelocity(Vector3 HAMOEAEOAOL)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x600008B")]
		[Cpp2IlInjected.Address(RVA = "0x7D34250", Offset = "0x7D33650", VA = "0x187D34250")]
		public void ClearVelocity()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008C")]
		[Cpp2IlInjected.Address(RVA = "0x7D341F0", Offset = "0x7D335F0", VA = "0x187D341F0")]
		public void ClearUnityRigidbodyVelocity()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008D")]
		[Cpp2IlInjected.Address(RVA = "0x7D34190", Offset = "0x7D33590", VA = "0x187D34190")]
		public void ClearLinearVelocity()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008E")]
		[Cpp2IlInjected.Address(RVA = "0x7D34130", Offset = "0x7D33530", VA = "0x187D34130")]
		public void ClearAngularVelocity()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008F")]
		[Cpp2IlInjected.Address(RVA = "0x7D352E0", Offset = "0x7D346E0", VA = "0x187D352E0")]
		public void ResetVelocityWorldSpace(Vector3 OHFJHJGFIPG, Vector3 FAOCEJCJAKL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000090")]
		[Cpp2IlInjected.Address(RVA = "0x7D351E0", Offset = "0x7D345E0", VA = "0x187D351E0")]
		public void ResetVelocityLocalSpace(Vector3 DDDBMJFJBND, Vector3 LFBNKFHGCCC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000091")]
		[Cpp2IlInjected.Address(RVA = "0x7D350A0", Offset = "0x7D344A0", VA = "0x187D350A0")]
		public void ResetLinearVelocityLocalSpace(Vector3 DDDBMJFJBND)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000092")]
		[Cpp2IlInjected.Address(RVA = "0x7D35880", Offset = "0x7D34C80", VA = "0x187D35880")]
		public bool SweepTest(Vector3 HEBBPJGOPIH, [Out] RaycastHit JJCHMLEOCKE, float LFDIBKEJEBM)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000093")]
		[Cpp2IlInjected.Address(RVA = "0x7D34990", Offset = "0x7D33D90", VA = "0x187D34990")]
		public bool IsSleeping()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000094")]
		[Cpp2IlInjected.Address(RVA = "0x7D35810", Offset = "0x7D34C10", VA = "0x187D35810")]
		public void Sleep()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000095")]
		[Cpp2IlInjected.Address(RVA = "0x7D35990", Offset = "0x7D34D90", VA = "0x187D35990")]
		public void WakeUp()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000096")]
		[Cpp2IlInjected.Address(RVA = "0x7D33A00", Offset = "0x7D32E00", VA = "0x187D33A00")]
		public void AddShouldHaveUnityRigidbodyToken(object OCDOGNMJENC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000097")]
		[Cpp2IlInjected.Address(RVA = "0x7D34FC0", Offset = "0x7D343C0", VA = "0x187D34FC0")]
		public void RemoveShouldHaveUnityRigidbodyToken(object OCDOGNMJENC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000098")]
		[Cpp2IlInjected.Address(RVA = "0x7D33E00", Offset = "0x7D33200", VA = "0x187D33E00")]
		public void ApplyForceVelocityChange(GMNANNIIAFD JJMLOJJPJOD, Vector3 IEDMFEDLOLI, float PFIBKJJPFMF, float HEPHAGPAIFL = 8f, float DAMIIJMBJMD = 1f)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000099")]
		[Cpp2IlInjected.Address(RVA = "0x7D33D00", Offset = "0x7D33100", VA = "0x187D33D00")]
		public void ApplyAngularVelocityChange(LJAIKDFDHAM NLMKINNIADH, Vector3 NEIBHDPOKMM, float AECDACLBOGG = float.PositiveInfinity)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009A")]
		[Cpp2IlInjected.Address(RVA = "0x7D33EC0", Offset = "0x7D332C0", VA = "0x187D33EC0")]
		[Obsolete("Deprecated. Still exists to support deprecated CV2 chips. Use ApplyAngularVelocityChange.")]
		public void ApplyTorqueAngularVelocityChangeDeprecated(LJAIKDFDHAM NLMKINNIADH, Vector3 NBFJKGINHEC, float LLMGAIAOBBE = 7f, float MNPCANDNIJK = 1f)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009B")]
		[Cpp2IlInjected.Address(RVA = "0x7D33C30", Offset = "0x7D33030", VA = "0x187D33C30")]
		public bool AllowedScaleChange(float KELBOIHJCBN)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600009C")]
		[Cpp2IlInjected.Address(RVA = "0x7D33B60", Offset = "0x7D32F60", VA = "0x187D33B60")]
		public void AddWorldSpaceVelocityInHierarchyParentOverride(RigidbodyEx GBLJIIICMEH, object OCDOGNMJENC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009D")]
		[Cpp2IlInjected.Address(RVA = "0x7D35030", Offset = "0x7D34430", VA = "0x187D35030")]
		public void RemoveWorldSpaceVelocityInHierarchyParentOverride(object OCDOGNMJENC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009E")]
		[Cpp2IlInjected.Address(RVA = "0x7D34E60", Offset = "0x7D34260", VA = "0x187D34E60", Slot = "12")]
		private void PCHLGPGNHKN(BILHHCLBMMK MEBLJIBNLCL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009F")]
		[Cpp2IlInjected.Address(RVA = "0x7D35B80", Offset = "0x7D34F80", VA = "0x187D35B80")]
		public RigidbodyEx()
		{
		}

		[SpecialName]
		[Cpp2IlInjected.Token(Token = "0x60000A1")]
		[Cpp2IlInjected.Address(RVA = "0xAC0A20", Offset = "0xABFE20", VA = "0x180AC0A20", Slot = "4")]
		private GameObject AHEBKAAOBPD()
		{
			return null;
		}

		[SpecialName]
		[Cpp2IlInjected.Token(Token = "0x60000A2")]
		[Cpp2IlInjected.Address(RVA = "0x991AF0", Offset = "0x990EF0", VA = "0x180991AF0", Slot = "10")]
		private bool EDMNCKJLANA()
		{
			return default(bool);
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
internal static class OGNHLLLLIBI
{
	[Cpp2IlInjected.Token(Token = "0x60000A3")]
	[Cpp2IlInjected.Address(RVA = "0x7D32D50", Offset = "0x7D32150", VA = "0x187D32D50")]
	public static ONELOFJJHKK BCFJPNINOHE(this RigidbodyEx BHMMCABJHIL)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
[RegisterService(typeof(NOBPIEBBMDJ), new string[] { })]
public class EJAGNALNLJK : NOBPIEBBMDJ, FLJLMKCIEIM
{
	[Cpp2IlInjected.Token(Token = "0x4000011")]
	private static readonly HLBHMADGLFA GCIBFPDCNDK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000012")]
	private IIBLLLEFCMA DCHKFKLALGC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000013")]
	private JAOJBEADCCJ IDOEJEKKJOO;

	[Cpp2IlInjected.Token(Token = "0x17000036")]
	public IIBLLLEFCMA JIOKCOHMJHG
	{
		[Cpp2IlInjected.Token(Token = "0x60000A4")]
		[Cpp2IlInjected.Address(RVA = "0x969480", Offset = "0x968880", VA = "0x180969480", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000037")]
	public JAOJBEADCCJ NACOFFKMMBH
	{
		[Cpp2IlInjected.Token(Token = "0x60000A5")]
		[Cpp2IlInjected.Address(RVA = "0x968330", Offset = "0x967730", VA = "0x180968330", Slot = "5")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000A6")]
	[Cpp2IlInjected.Address(RVA = "0x7D27960", Offset = "0x7D26D60", VA = "0x187D27960", Slot = "7")]
	public void InitReferences(FHGOKBONFMJ BHDEAEIFGBG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A7")]
	[Cpp2IlInjected.Address(RVA = "0x7D27830", Offset = "0x7D26C30", VA = "0x187D27830", Slot = "6")]
	public ONELOFJJHKK GHGJNLFDFNG(RigidbodyEx BHMMCABJHIL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000A8")]
	[Cpp2IlInjected.Address(RVA = "0x96D700", Offset = "0x96CB00", VA = "0x18096D700")]
	public EJAGNALNLJK()
	{
	}
}
namespace RecRoom
{
	[Cpp2IlInjected.Token(Token = "0x2000007")]
	public class PhysicsManager : SingletonMonoBehaviour<PhysicsManager>
	{
		[Cpp2IlInjected.Token(Token = "0x4000014")]
		public static EBGLFEEDNOA UpdateAfterFixedUpdateRan;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000015")]
		private int NJGIFNELFBL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x4000016")]
		private int IAOACELKMBH;

		[Cpp2IlInjected.Token(Token = "0x60000AA")]
		[Cpp2IlInjected.Address(RVA = "0x7D33440", Offset = "0x7D32840", VA = "0x187D33440")]
		protected void FixedUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AB")]
		[Cpp2IlInjected.Address(RVA = "0x7D33480", Offset = "0x7D32880", VA = "0x187D33480")]
		protected void Update()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AC")]
		[Cpp2IlInjected.Address(RVA = "0x7D33460", Offset = "0x7D32860", VA = "0x187D33460")]
		protected void LateUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AD")]
		[Cpp2IlInjected.Address(RVA = "0x966900", Offset = "0x965D00", VA = "0x180966900")]
		[Conditional("UNITY_ASSERTIONS")]
		public void AssertLateColliderPositionsNotYetUpdated([Optional] string LPIFIOEEOGF, [Optional] UnityEngine.Object MEBLJIBNLCL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AE")]
		[Cpp2IlInjected.Address(RVA = "0x966900", Offset = "0x965D00", VA = "0x180966900")]
		[Conditional("UNITY_ASSERTIONS")]
		public void AssertLateColliderPositionsAlreadyUpdated([Optional] string LPIFIOEEOGF, [Optional] UnityEngine.Object MEBLJIBNLCL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AF")]
		[Cpp2IlInjected.Address(RVA = "0x7D33570", Offset = "0x7D32970", VA = "0x187D33570")]
		public PhysicsManager()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
public static class PPIGCOKDGCJ
{
	[Cpp2IlInjected.Token(Token = "0x2000009")]
	private class MMCBBHLJJGO : NOLNOOCKIJK, IDisposable
	{
		[Cpp2IlInjected.Token(Token = "0x60000B3")]
		[Cpp2IlInjected.Address(RVA = "0x966900", Offset = "0x965D00", VA = "0x180966900", Slot = "7")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B4")]
		[Cpp2IlInjected.Address(RVA = "0x975A10", Offset = "0x974E10", VA = "0x180975A10", Slot = "4")]
		public Vector3 JGPLLCIKIJN()
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x60000B5")]
		[Cpp2IlInjected.Address(RVA = "0x975A10", Offset = "0x974E10", VA = "0x180975A10", Slot = "5")]
		public Vector3 BBBOAKNDCNE()
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x60000B6")]
		[Cpp2IlInjected.Address(RVA = "0x980BB0", Offset = "0x97FFB0", VA = "0x180980BB0", Slot = "6")]
		public bool HGLABBHCBKG(float PJFJOLHCNKI, float CLLCFCDNJEI)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000B7")]
		[Cpp2IlInjected.Address(RVA = "0x96D700", Offset = "0x96CB00", VA = "0x18096D700")]
		public MMCBBHLJJGO()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000038")]
	public static NOLNOOCKIJK ECBNCDKOILP
	{
		[Cpp2IlInjected.Token(Token = "0x60000B1")]
		[Cpp2IlInjected.Address(RVA = "0x7D33370", Offset = "0x7D32770", VA = "0x187D33370")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
public interface BDIEBBBMBOD
{
	[Cpp2IlInjected.Token(Token = "0x17000039")]
	CollisionDetectionMode JFPJCFANLLE
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
	void FDCAHJOBADK();

	[Cpp2IlInjected.Token(Token = "0x60000BB")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void AENAOLLIDAK(bool KCMENFHDDPM);

	[Cpp2IlInjected.Token(Token = "0x60000BC")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void DIEHNDIHFKK(bool KCMENFHDDPM);

	[Cpp2IlInjected.Token(Token = "0x60000BD")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void LKOJCFBHNOE(Rigidbody NMCGHNMJFDC);

	[Cpp2IlInjected.Token(Token = "0x60000BE")]
	[Cpp2IlInjected.Address(Slot = "6")]
	bool MNGHMOHOCBL(Vector3 HEBBPJGOPIH, [Out] RaycastHit JJCHMLEOCKE, float LFDIBKEJEBM);
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
public interface FGLMJNPEIBL : IDisposable, KBEGLFMBMJL
{
	[Cpp2IlInjected.Token(Token = "0x1700003A")]
	MGFGMPBMECL DHLEHOILFIK
	{
		[Cpp2IlInjected.Token(Token = "0x60000C1")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
		[Cpp2IlInjected.Token(Token = "0x60000C2")]
		[Cpp2IlInjected.Address(Slot = "3")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x14000009")]
	event Action<BJOOMCLMBJJ, BJOOMCLMBJJ> PKKNONLFKJH;

	[Cpp2IlInjected.Token(Token = "0x60000C3")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void FDCAHJOBADK();
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
[ServiceLifetime(Lifetime.Application)]
public interface JAOJBEADCCJ
{
	[Cpp2IlInjected.Token(Token = "0x60000C4")]
	[Cpp2IlInjected.Address(Slot = "0")]
	NJMNCPIJMFH PEJFDGINEJD(ONELOFJJHKK FBFIKJCNBGP);

	[Cpp2IlInjected.Token(Token = "0x60000C5")]
	[Cpp2IlInjected.Address(Slot = "1")]
	JDCLCIFPIOK LJPEOAGHKNF(ONELOFJJHKK FBFIKJCNBGP);

	[Cpp2IlInjected.Token(Token = "0x60000C6")]
	[Cpp2IlInjected.Address(Slot = "2")]
	NLMANHFJJCM NAJJHDNJPEA(ONELOFJJHKK FBFIKJCNBGP);

	[Cpp2IlInjected.Token(Token = "0x60000C7")]
	[Cpp2IlInjected.Address(Slot = "3")]
	AMAOGLLIKNH FLJLOJHLKKB(ONELOFJJHKK FBFIKJCNBGP);

	[Cpp2IlInjected.Token(Token = "0x60000C8")]
	[Cpp2IlInjected.Address(Slot = "4")]
	AGIFBEEDDGA MNJIJDECDPO(ONELOFJJHKK FBFIKJCNBGP);

	[Cpp2IlInjected.Token(Token = "0x60000C9")]
	[Cpp2IlInjected.Address(Slot = "5")]
	FGLMJNPEIBL CFOMIEMAGNC(ONELOFJJHKK FBFIKJCNBGP);

	[Cpp2IlInjected.Token(Token = "0x60000CA")]
	[Cpp2IlInjected.Address(Slot = "6")]
	IHNLCMKPJDC KOHCGBMADFC(ONELOFJJHKK FBFIKJCNBGP);

	[Cpp2IlInjected.Token(Token = "0x60000CB")]
	[Cpp2IlInjected.Address(Slot = "7")]
	LPDBMJLCIPB IGIPKDEGBCH(ONELOFJJHKK FBFIKJCNBGP);

	[Cpp2IlInjected.Token(Token = "0x60000CC")]
	[Cpp2IlInjected.Address(Slot = "8")]
	BDIEBBBMBOD PHKJNJKKCEG(ONELOFJJHKK FBFIKJCNBGP);

	[Cpp2IlInjected.Token(Token = "0x60000CD")]
	[Cpp2IlInjected.Address(Slot = "9")]
	MAKCBALLFAO KBBEOEEHPAI(ONELOFJJHKK FBFIKJCNBGP);

	[Cpp2IlInjected.Token(Token = "0x60000CE")]
	[Cpp2IlInjected.Address(Slot = "10")]
	LMJFADHKKHC GHBOOIBCJGM(ONELOFJJHKK FBFIKJCNBGP, [In] FJIIBPHJJOB MJFOKKFMONL);

	[Cpp2IlInjected.Token(Token = "0x60000CF")]
	[Cpp2IlInjected.Address(Slot = "11")]
	HIEPHFEAIIK IEILHKIILAC(ONELOFJJHKK FBFIKJCNBGP, [In] FJIIBPHJJOB MJFOKKFMONL);

	[Cpp2IlInjected.Token(Token = "0x60000D0")]
	[Cpp2IlInjected.Address(Slot = "12")]
	DJJFIBNFAOA JEACCIIKMBP(ONELOFJJHKK FBFIKJCNBGP, [In] FJIIBPHJJOB MJFOKKFMONL);

	[Cpp2IlInjected.Token(Token = "0x60000D1")]
	[Cpp2IlInjected.Address(Slot = "13")]
	LOGGPMDDFFJ NFGJMEKLDHK(ONELOFJJHKK FBFIKJCNBGP, [In] FJIIBPHJJOB MJFOKKFMONL);

	[Cpp2IlInjected.Token(Token = "0x60000D2")]
	[Cpp2IlInjected.Address(Slot = "14")]
	GLGJPJHKKPH NPHINEEGJIO(ONELOFJJHKK FBFIKJCNBGP, [In] FJIIBPHJJOB MJFOKKFMONL);

	[Cpp2IlInjected.Token(Token = "0x60000D3")]
	[Cpp2IlInjected.Address(Slot = "15")]
	ONELOFJJHKK GHGJNLFDFNG(RigidbodyEx BHMMCABJHIL, FJIIBPHJJOB MJFOKKFMONL, NOBPIEBBMDJ FDIJEKJEAKE);
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
public interface LPDBMJLCIPB
{
	[Cpp2IlInjected.Token(Token = "0x60000D4")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void FKCFFDMFFJM(Vector3 JLJMBNIAGMB, ForceMode NELEMMPBMFP = ForceMode.Force);

	[Cpp2IlInjected.Token(Token = "0x60000D5")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void FAJNPJOJLMP(Vector3 JLJMBNIAGMB, Vector3 HJBDDDIFEBJ, ForceMode NELEMMPBMFP);

	[Cpp2IlInjected.Token(Token = "0x60000D6")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void NJLAOPPPALH(Vector3 KCHPPHPFPDG, ForceMode NELEMMPBMFP = ForceMode.Force);

	[Cpp2IlInjected.Token(Token = "0x60000D7")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void BLIBBLAJOCG(Vector3 KCHPPHPFPDG, ForceMode NELEMMPBMFP = ForceMode.Force);
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
public interface MAKCBALLFAO
{
	[Cpp2IlInjected.Token(Token = "0x1700003B")]
	bool OBGKCEGMDEO
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
	void LKOJCFBHNOE(Rigidbody NMCGHNMJFDC);

	[Cpp2IlInjected.Token(Token = "0x60000DB")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void JAMEOJHHPOD(Rigidbody NMCGHNMJFDC);
}
[Cpp2IlInjected.Token(Token = "0x200000F")]
public interface NJMNCPIJMFH : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x1700003C")]
	IReadOnlyList<ONELOFJJHKK> HMCFNKLPLCJ
	{
		[Cpp2IlInjected.Token(Token = "0x60000EE")]
		[Cpp2IlInjected.Address(Slot = "18")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700003D")]
	ONELOFJJHKK JMIAMIHOFLD
	{
		[Cpp2IlInjected.Token(Token = "0x60000EF")]
		[Cpp2IlInjected.Address(Slot = "19")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700003E")]
	ONELOFJJHKK GPOFIBLNPEM
	{
		[Cpp2IlInjected.Token(Token = "0x60000F0")]
		[Cpp2IlInjected.Address(Slot = "20")]
		get;
		[Cpp2IlInjected.Token(Token = "0x60000F1")]
		[Cpp2IlInjected.Address(Slot = "21")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x1400000A")]
	event HKHCEGJIAFD LLNDJKBCKGM;

	[Cpp2IlInjected.Token(Token = "0x1400000B")]
	event HKHCEGJIAFD JDPMJLLIHGJ;

	[Cpp2IlInjected.Token(Token = "0x1400000C")]
	event DHIOLIJFBFO IHOCNHDBMOC;

	[Cpp2IlInjected.Token(Token = "0x1400000D")]
	event Action IFAPFBCNKML;

	[Cpp2IlInjected.Token(Token = "0x1400000E")]
	event Action PGOOCHKMAHD;

	[Cpp2IlInjected.Token(Token = "0x1400000F")]
	event Action<ONELOFJJHKK> OLCLFAAONBM;

	[Cpp2IlInjected.Token(Token = "0x14000010")]
	event Action<ONELOFJJHKK> MDMGHIGPCAK;

	[Cpp2IlInjected.Token(Token = "0x14000011")]
	event Action GMOLIKPEBEB;

	[Cpp2IlInjected.Token(Token = "0x14000012")]
	event Action<ONELOFJJHKK> NJPOHHJBNJF;

	[Cpp2IlInjected.Token(Token = "0x60000F2")]
	[Cpp2IlInjected.Address(Slot = "22")]
	void NMIFEKBMEEA(ONELOFJJHKK DDPMGHJOAAI, bool DPDMJKGJHHG = false);
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
public interface NLMANHFJJCM
{
	[Cpp2IlInjected.Token(Token = "0x1700003F")]
	Vector3 HPOJAAEIEAI
	{
		[Cpp2IlInjected.Token(Token = "0x60000F3")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000040")]
	Vector3 GKADHGLIFJO
	{
		[Cpp2IlInjected.Token(Token = "0x60000F4")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x60000F5")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void NMGJBPJCDEG(ONELOFJJHKK HKNGNFLDPKM, object OCDOGNMJENC);

	[Cpp2IlInjected.Token(Token = "0x60000F6")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void LACEABANCDN(object OCDOGNMJENC);
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
public interface LOGGPMDDFFJ
{
	[Cpp2IlInjected.Token(Token = "0x17000041")]
	Vector3 JDJFBDLCNID
	{
		[Cpp2IlInjected.Token(Token = "0x60000F9")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
		[Cpp2IlInjected.Token(Token = "0x60000FA")]
		[Cpp2IlInjected.Address(Slot = "3")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000042")]
	Vector3 BEKMIPAOELB
	{
		[Cpp2IlInjected.Token(Token = "0x60000FB")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000043")]
	float KGDKBOMCLNC
	{
		[Cpp2IlInjected.Token(Token = "0x60000FC")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000044")]
	float IGHBOPMJHJJ
	{
		[Cpp2IlInjected.Token(Token = "0x60000FD")]
		[Cpp2IlInjected.Address(Slot = "6")]
		get;
		[Cpp2IlInjected.Token(Token = "0x60000FE")]
		[Cpp2IlInjected.Address(Slot = "7")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000045")]
	Vector3 JFKAKIPMFCE
	{
		[Cpp2IlInjected.Token(Token = "0x60000FF")]
		[Cpp2IlInjected.Address(Slot = "8")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000046")]
	Quaternion GNLGGFDBHLB
	{
		[Cpp2IlInjected.Token(Token = "0x6000100")]
		[Cpp2IlInjected.Address(Slot = "9")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x14000013")]
	event HKHCEGJIAFD LDHJLEEGJAB;

	[Cpp2IlInjected.Token(Token = "0x6000101")]
	[Cpp2IlInjected.Address(Slot = "10")]
	void EDOMEHFLAGM((Quaternion rot, Vector3 moments) OLBACLDODGO);

	[Cpp2IlInjected.Token(Token = "0x6000102")]
	[Cpp2IlInjected.Address(Slot = "11")]
	void BECBIAOEMJG();

	[Cpp2IlInjected.Token(Token = "0x6000103")]
	[Cpp2IlInjected.Address(Slot = "12")]
	void IHDPNCBKNIF();

	[Cpp2IlInjected.Token(Token = "0x6000104")]
	[Cpp2IlInjected.Address(Slot = "13")]
	void DHKDPIJKLMI();

	[Cpp2IlInjected.Token(Token = "0x6000105")]
	[Cpp2IlInjected.Address(Slot = "14")]
	void LKOJCFBHNOE(Rigidbody NMCGHNMJFDC);

	[Cpp2IlInjected.Token(Token = "0x6000106")]
	[Cpp2IlInjected.Address(Slot = "15")]
	void JAMEOJHHPOD(Rigidbody NMCGHNMJFDC);

	[Cpp2IlInjected.Token(Token = "0x6000107")]
	[Cpp2IlInjected.Address(Slot = "16")]
	void LHILPJBJEPA();
}
[Cpp2IlInjected.Token(Token = "0x2000012")]
public interface DJJFIBNFAOA
{
	[Cpp2IlInjected.Token(Token = "0x6000108")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void FDCAHJOBADK();

	[Cpp2IlInjected.Token(Token = "0x6000109")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void DLHIIMHIJKF(object OCDOGNMJENC);

	[Cpp2IlInjected.Token(Token = "0x600010A")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void MNLPOPDKBLE(object OCDOGNMJENC);

	[Cpp2IlInjected.Token(Token = "0x600010B")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void BDPEKJHGHHI(ONELOFJJHKK BHMMCABJHIL);

	[Cpp2IlInjected.Token(Token = "0x600010C")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void JGBEJJMNDLK(ONELOFJJHKK BHMMCABJHIL);

	[Cpp2IlInjected.Token(Token = "0x600010D")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void LOPOCJBNMJC();
}
[Cpp2IlInjected.Token(Token = "0x2000013")]
public interface IHNLCMKPJDC
{
	[Cpp2IlInjected.Token(Token = "0x17000047")]
	bool FLHOBLPAHLN
	{
		[Cpp2IlInjected.Token(Token = "0x6000110")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x14000014")]
	event HKHCEGJIAFD MPMPMNBAFMD;

	[Cpp2IlInjected.Token(Token = "0x6000111")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void ELPOJILPLGC(object OCDOGNMJENC);

	[Cpp2IlInjected.Token(Token = "0x6000112")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void FNPOKOHAKAF(object OCDOGNMJENC);

	[Cpp2IlInjected.Token(Token = "0x6000113")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void ABBFPJIBJOM(object OCDOGNMJENC, bool DFOLNBHIIIF);

	[Cpp2IlInjected.Token(Token = "0x6000114")]
	[Cpp2IlInjected.Address(Slot = "6")]
	void LKOJCFBHNOE(Rigidbody DGHNPONNDGG);

	[Cpp2IlInjected.Token(Token = "0x6000115")]
	[Cpp2IlInjected.Address(Slot = "7")]
	void JAMEOJHHPOD(Rigidbody NMCGHNMJFDC);
}
[Cpp2IlInjected.Token(Token = "0x2000014")]
public interface HIEPHFEAIIK : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x17000048")]
	bool CNDIOOMAJAG
	{
		[Cpp2IlInjected.Token(Token = "0x6000118")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000049")]
	bool FGJLIHNAGOB
	{
		[Cpp2IlInjected.Token(Token = "0x6000119")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x14000015")]
	event HKHCEGJIAFD DEIPDFKLOEI;

	[Cpp2IlInjected.Token(Token = "0x600011A")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void FDCAHJOBADK();

	[Cpp2IlInjected.Token(Token = "0x600011B")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void OGNCJHGANFP(ONELOFJJHKK HKNGNFLDPKM);

	[Cpp2IlInjected.Token(Token = "0x600011C")]
	[Cpp2IlInjected.Address(Slot = "6")]
	void MMGGACCPOGH(ONELOFJJHKK HKNGNFLDPKM);
}
[Cpp2IlInjected.Token(Token = "0x2000015")]
public interface GLGJPJHKKPH
{
	[Cpp2IlInjected.Token(Token = "0x1700004A")]
	bool EMGGFBFPNEC
	{
		[Cpp2IlInjected.Token(Token = "0x600011D")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
		[Cpp2IlInjected.Token(Token = "0x600011E")]
		[Cpp2IlInjected.Address(Slot = "1")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x1700004B")]
	bool JJIPHEKCDOL
	{
		[Cpp2IlInjected.Token(Token = "0x600011F")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700004C")]
	RigidbodyConstraints HBGDENBJPLN
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
	void LKOJCFBHNOE(Rigidbody NMCGHNMJFDC);

	[Cpp2IlInjected.Token(Token = "0x6000123")]
	[Cpp2IlInjected.Address(Slot = "6")]
	void JAMEOJHHPOD(Rigidbody NMCGHNMJFDC);
}
[Cpp2IlInjected.Token(Token = "0x2000016")]
public interface AMAOGLLIKNH
{
	[Cpp2IlInjected.Token(Token = "0x1700004D")]
	float JEOKECDPNLO
	{
		[Cpp2IlInjected.Token(Token = "0x6000124")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
		[Cpp2IlInjected.Token(Token = "0x6000125")]
		[Cpp2IlInjected.Address(Slot = "1")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x1700004E")]
	float EHGGFICBLII
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
	void LKOJCFBHNOE(Rigidbody NMCGHNMJFDC);

	[Cpp2IlInjected.Token(Token = "0x6000129")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void JAMEOJHHPOD(Rigidbody NMCGHNMJFDC);
}
[Cpp2IlInjected.Token(Token = "0x2000017")]
public interface AGIFBEEDDGA
{
	[Cpp2IlInjected.Token(Token = "0x4000018")]
	static bool PKBOJFALPOL;

	[Cpp2IlInjected.Token(Token = "0x14000016")]
	event HKHCEGJIAFD ACGHLBKLGFH;

	[Cpp2IlInjected.Token(Token = "0x600012C")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void FDCAHJOBADK();

	[Cpp2IlInjected.Token(Token = "0x600012D")]
	[Cpp2IlInjected.Address(Slot = "3")]
	bool HHIOEMFBFMI();

	[Cpp2IlInjected.Token(Token = "0x600012E")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void PEMCELKPKNP();

	[Cpp2IlInjected.Token(Token = "0x600012F")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void BIACMLPHAAJ();

	[Cpp2IlInjected.Token(Token = "0x6000130")]
	[Cpp2IlInjected.Address(Slot = "6")]
	bool EELHBFBNLDD();

	[Cpp2IlInjected.Token(Token = "0x6000131")]
	[Cpp2IlInjected.Address(Slot = "7")]
	bool DMGFOKLLOPH();

	[Cpp2IlInjected.Token(Token = "0x6000132")]
	[Cpp2IlInjected.Address(Slot = "8")]
	void INEHBEIMHCJ(bool PLKEDKLKNBC);

	[Cpp2IlInjected.Token(Token = "0x6000133")]
	[Cpp2IlInjected.Address(Slot = "9")]
	void PDDFIHAIDJA();
}
[Cpp2IlInjected.Token(Token = "0x2000018")]
public interface LMJFADHKKHC
{
	[Cpp2IlInjected.Token(Token = "0x1700004F")]
	Rigidbody NDDOBLHGPFH
	{
		[Cpp2IlInjected.Token(Token = "0x6000134")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000050")]
	bool JMMFCFLPIFK
	{
		[Cpp2IlInjected.Token(Token = "0x6000136")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000135")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void FDCAHJOBADK();

	[Cpp2IlInjected.Token(Token = "0x6000137")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void POIFJDHJAOA(object OCDOGNMJENC);

	[Cpp2IlInjected.Token(Token = "0x6000138")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void BNBABJLFLJE(object OCDOGNMJENC);

	[Cpp2IlInjected.Token(Token = "0x6000139")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void MMOEHOAOBCB();
}
[Cpp2IlInjected.Token(Token = "0x2000019")]
public interface JDCLCIFPIOK : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x17000051")]
	NOLNOOCKIJK IHHDBKNFBBI
	{
		[Cpp2IlInjected.Token(Token = "0x600013A")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
		[Cpp2IlInjected.Token(Token = "0x600013B")]
		[Cpp2IlInjected.Address(Slot = "1")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000052")]
	GLBOIBMAJCP PJLCPLILAJO
	{
		[Cpp2IlInjected.Token(Token = "0x600013C")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
		[Cpp2IlInjected.Token(Token = "0x600013D")]
		[Cpp2IlInjected.Address(Slot = "3")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000053")]
	Vector3 MJIGPKPLELI
	{
		[Cpp2IlInjected.Token(Token = "0x600013E")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
		[Cpp2IlInjected.Token(Token = "0x600013F")]
		[Cpp2IlInjected.Address(Slot = "5")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000054")]
	Vector3 AMMPLEJMPPA
	{
		[Cpp2IlInjected.Token(Token = "0x6000140")]
		[Cpp2IlInjected.Address(Slot = "6")]
		get;
		[Cpp2IlInjected.Token(Token = "0x6000141")]
		[Cpp2IlInjected.Address(Slot = "7")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000055")]
	Vector3 JOODHKJHNLO
	{
		[Cpp2IlInjected.Token(Token = "0x6000142")]
		[Cpp2IlInjected.Address(Slot = "8")]
		get;
		[Cpp2IlInjected.Token(Token = "0x6000143")]
		[Cpp2IlInjected.Address(Slot = "9")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000056")]
	Vector3 HHKGCHNAAHG
	{
		[Cpp2IlInjected.Token(Token = "0x6000144")]
		[Cpp2IlInjected.Address(Slot = "10")]
		get;
		[Cpp2IlInjected.Token(Token = "0x6000145")]
		[Cpp2IlInjected.Address(Slot = "11")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000057")]
	float OIGFIEJGDKP
	{
		[Cpp2IlInjected.Token(Token = "0x6000146")]
		[Cpp2IlInjected.Address(Slot = "12")]
		get;
		[Cpp2IlInjected.Token(Token = "0x6000147")]
		[Cpp2IlInjected.Address(Slot = "13")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000058")]
	bool ADKKEMHDLMA
	{
		[Cpp2IlInjected.Token(Token = "0x6000148")]
		[Cpp2IlInjected.Address(Slot = "14")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000149")]
	[Cpp2IlInjected.Address(Slot = "15")]
	void FDCAHJOBADK();

	[Cpp2IlInjected.Token(Token = "0x600014A")]
	[Cpp2IlInjected.Address(Slot = "16")]
	void GOFFGFAMKAM(object OCDOGNMJENC);

	[Cpp2IlInjected.Token(Token = "0x600014B")]
	[Cpp2IlInjected.Address(Slot = "17")]
	void FBPHAJGDLKL(LJAIKDFDHAM NLMKINNIADH, Vector3 NEIBHDPOKMM, float AECDACLBOGG = float.PositiveInfinity);

	[Cpp2IlInjected.Token(Token = "0x600014C")]
	[Cpp2IlInjected.Address(Slot = "18")]
	void FIDPNFHHHIC(GMNANNIIAFD JJMLOJJPJOD, Vector3 IEDMFEDLOLI, float PFIBKJJPFMF, float HEPHAGPAIFL = 8f, float DAMIIJMBJMD = 1f);

	[Cpp2IlInjected.Token(Token = "0x600014D")]
	[Cpp2IlInjected.Address(Slot = "19")]
	void OHJPDDJGCGP(LJAIKDFDHAM NLMKINNIADH, Vector3 NBFJKGINHEC, float LLMGAIAOBBE = 7f, float MNPCANDNIJK = 1f);

	[Cpp2IlInjected.Token(Token = "0x600014E")]
	[Cpp2IlInjected.Address(Slot = "20")]
	void JHLKHALBOGM();

	[Cpp2IlInjected.Token(Token = "0x600014F")]
	[Cpp2IlInjected.Address(Slot = "21")]
	void IOANPPBLGDK();

	[Cpp2IlInjected.Token(Token = "0x6000150")]
	[Cpp2IlInjected.Address(Slot = "22")]
	void PEPFDMMGINN();

	[Cpp2IlInjected.Token(Token = "0x6000151")]
	[Cpp2IlInjected.Address(Slot = "23")]
	void APHEOEAHJFI();

	[Cpp2IlInjected.Token(Token = "0x6000152")]
	[Cpp2IlInjected.Address(Slot = "24")]
	void LKOJCFBHNOE(Rigidbody NMCGHNMJFDC);

	[Cpp2IlInjected.Token(Token = "0x6000153")]
	[Cpp2IlInjected.Address(Slot = "25")]
	Vector3 LOGKHCLLELM(Vector3 BCGMKGELHNE);

	[Cpp2IlInjected.Token(Token = "0x6000154")]
	[Cpp2IlInjected.Address(Slot = "26")]
	void HFDGCLDBFAG(object OCDOGNMJENC);

	[Cpp2IlInjected.Token(Token = "0x6000155")]
	[Cpp2IlInjected.Address(Slot = "27")]
	void FNLICJJPFAN(Vector3 JPPCCLEJCEF);

	[Cpp2IlInjected.Token(Token = "0x6000156")]
	[Cpp2IlInjected.Address(Slot = "28")]
	void NFGPEMLGGMD(Vector3 DDDBMJFJBND, Vector3 LFBNKFHGCCC);

	[Cpp2IlInjected.Token(Token = "0x6000157")]
	[Cpp2IlInjected.Address(Slot = "29")]
	void BPLIAHFFAAI(Vector3 OHFJHJGFIPG, Vector3 FAOCEJCJAKL);

	[Cpp2IlInjected.Token(Token = "0x6000158")]
	[Cpp2IlInjected.Address(Slot = "30")]
	Vector3 KCBFEHNFBFK(Vector3 HAMOEAEOAOL);

	[Cpp2IlInjected.Token(Token = "0x6000159")]
	[Cpp2IlInjected.Address(Slot = "31")]
	Vector3 AOMCCDLJABB(Vector3 JDACPJAFGEP);
}
[Cpp2IlInjected.Token(Token = "0x200001A")]
[ServiceLifetime(Lifetime.Application)]
public interface IIBLLLEFCMA
{
	[Cpp2IlInjected.Token(Token = "0x17000059")]
	bool FNIFKJPOKOJ
	{
		[Cpp2IlInjected.Token(Token = "0x600015A")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x600015B")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void JBLGHMPBINO(string JPAKKPAOGDF);

	[Cpp2IlInjected.Token(Token = "0x600015C")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void EALOBCKCJDP(RigidbodyEx BHMMCABJHIL, Action NJNJGNMEACN);

	[Cpp2IlInjected.Token(Token = "0x600015D")]
	[Cpp2IlInjected.Address(Slot = "3")]
	KAMDAKFNHGJ CEEOOECGBJN(int LFOPMKNENDB);

	[Cpp2IlInjected.Token(Token = "0x600015E")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void KFLIAHHNKBI(Vector3 PDMCMACMABG, float KFBOBKIFIKH, Color MLLLJKFOPGI);
}
[Cpp2IlInjected.Token(Token = "0x200001B")]
[ServiceLifetime(Lifetime.Application)]
public interface NOBPIEBBMDJ
{
	[Cpp2IlInjected.Token(Token = "0x1700005A")]
	IIBLLLEFCMA JIOKCOHMJHG
	{
		[Cpp2IlInjected.Token(Token = "0x600015F")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700005B")]
	JAOJBEADCCJ NACOFFKMMBH
	{
		[Cpp2IlInjected.Token(Token = "0x6000160")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000161")]
	[Cpp2IlInjected.Address(Slot = "2")]
	ONELOFJJHKK GHGJNLFDFNG(RigidbodyEx BHMMCABJHIL);
}
[Cpp2IlInjected.Token(Token = "0x200001C")]
public class EBKKBHNGFDB : ONELOFJJHKK, IDisposable, MDILKDNLJEP
{
	[Cpp2IlInjected.Token(Token = "0x4000019")]
	public static bool LLBOKPKAAMA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400001A")]
	internal readonly NOBPIEBBMDJ FDIJEKJEAKE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400001B")]
	internal NJMNCPIJMFH PGHOOLCHGFB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400001C")]
	internal DJJFIBNFAOA BBEECKHPEBG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400001D")]
	internal HIEPHFEAIIK LHDKDGDFFNK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400001E")]
	internal JDCLCIFPIOK BCGMKGELHNE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x400001F")]
	internal NLMANHFJJCM MHJHJKFIOPC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000020")]
	internal LOGGPMDDFFJ HAMDMOABLEJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000021")]
	internal AMAOGLLIKNH ILDJPLJCLIM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000022")]
	internal MAKCBALLFAO KOEBAGIBHOK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x4000023")]
	internal AGIFBEEDDGA CPJNBFLBFGA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x4000024")]
	internal FGLMJNPEIBL NKLBECFFGCF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x4000025")]
	internal IHNLCMKPJDC MPLMKIPEPPK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x4000026")]
	internal LPDBMJLCIPB JLJMBNIAGMB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
	[Cpp2IlInjected.Token(Token = "0x4000027")]
	internal GLGJPJHKKPH HGFNGKHCEFD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x4000028")]
	internal LMJFADHKKHC NMCGHNMJFDC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
	[Cpp2IlInjected.Token(Token = "0x4000029")]
	internal BDIEBBBMBOD JKCJAPIPOJO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
	[Cpp2IlInjected.Token(Token = "0x400002A")]
	internal IDisposable NDBNLBNPKND;

	[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
	[Cpp2IlInjected.Token(Token = "0x400002B")]
	private bool GJIKOKFPDGN;

	[Cpp2IlInjected.Token(Token = "0x1700005C")]
	public DHFHGDGMDKP HLHCGJDBCJI
	{
		[Cpp2IlInjected.Token(Token = "0x6000162")]
		[Cpp2IlInjected.Address(RVA = "0x966910", Offset = "0x965D10", VA = "0x180966910", Slot = "22")]
		get
		{
			return default(DHFHGDGMDKP);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700005D")]
	public AIOKEFGMGBL GJLPLBGKKHI
	{
		[Cpp2IlInjected.Token(Token = "0x6000163")]
		[Cpp2IlInjected.Address(RVA = "0xBDAFB0", Offset = "0xBDA3B0", VA = "0x180BDAFB0", Slot = "24")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000164")]
		[Cpp2IlInjected.Address(RVA = "0xD458D0", Offset = "0xD44CD0", VA = "0x180D458D0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700005E")]
	public GameObject ILEPLPIMKGD
	{
		[Cpp2IlInjected.Token(Token = "0x6000165")]
		[Cpp2IlInjected.Address(RVA = "0x9744C0", Offset = "0x9738C0", VA = "0x1809744C0", Slot = "25")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000166")]
		[Cpp2IlInjected.Address(RVA = "0x974460", Offset = "0x973860", VA = "0x180974460")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700005F")]
	public Transform KCFIKHGOCAF
	{
		[Cpp2IlInjected.Token(Token = "0x6000167")]
		[Cpp2IlInjected.Address(RVA = "0xB16520", Offset = "0xB15920", VA = "0x180B16520", Slot = "26")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000168")]
		[Cpp2IlInjected.Address(RVA = "0xD2A950", Offset = "0xD29D50", VA = "0x180D2A950")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000060")]
	public Rigidbody NDDOBLHGPFH
	{
		[Cpp2IlInjected.Token(Token = "0x6000169")]
		[Cpp2IlInjected.Address(RVA = "0x7D22F70", Offset = "0x7D22370", VA = "0x187D22F70", Slot = "23")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000061")]
	public ONELOFJJHKK GPOFIBLNPEM
	{
		[Cpp2IlInjected.Token(Token = "0x600017A")]
		[Cpp2IlInjected.Address(RVA = "0x7D21A50", Offset = "0x7D20E50", VA = "0x187D21A50", Slot = "27")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600017B")]
		[Cpp2IlInjected.Address(RVA = "0x7D21140", Offset = "0x7D20540", VA = "0x187D21140", Slot = "28")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000062")]
	public int FKMOCIHFONL
	{
		[Cpp2IlInjected.Token(Token = "0x600017C")]
		[Cpp2IlInjected.Address(RVA = "0x7D26170", Offset = "0x7D25570", VA = "0x187D26170", Slot = "31")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000063")]
	public ONELOFJJHKK JMIAMIHOFLD
	{
		[Cpp2IlInjected.Token(Token = "0x600017E")]
		[Cpp2IlInjected.Address(RVA = "0x7D23730", Offset = "0x7D22B30", VA = "0x187D23730", Slot = "29")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000064")]
	public bool HKMHMPHKIAK
	{
		[Cpp2IlInjected.Token(Token = "0x600017F")]
		[Cpp2IlInjected.Address(RVA = "0x7D228E0", Offset = "0x7D21CE0", VA = "0x187D228E0", Slot = "32")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000065")]
	public bool CNDIOOMAJAG
	{
		[Cpp2IlInjected.Token(Token = "0x6000183")]
		[Cpp2IlInjected.Address(RVA = "0x7D242B0", Offset = "0x7D236B0", VA = "0x187D242B0", Slot = "33")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000066")]
	public bool FGJLIHNAGOB
	{
		[Cpp2IlInjected.Token(Token = "0x6000184")]
		[Cpp2IlInjected.Address(RVA = "0x7D27080", Offset = "0x7D26480", VA = "0x187D27080", Slot = "34")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000067")]
	public NOLNOOCKIJK IHHDBKNFBBI
	{
		[Cpp2IlInjected.Token(Token = "0x6000185")]
		[Cpp2IlInjected.Address(RVA = "0x7D22D80", Offset = "0x7D22180", VA = "0x187D22D80", Slot = "35")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000186")]
		[Cpp2IlInjected.Address(RVA = "0x7D25520", Offset = "0x7D24920", VA = "0x187D25520", Slot = "36")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000068")]
	public GLBOIBMAJCP PJLCPLILAJO
	{
		[Cpp2IlInjected.Token(Token = "0x6000187")]
		[Cpp2IlInjected.Address(RVA = "0x7D23E50", Offset = "0x7D23250", VA = "0x187D23E50", Slot = "37")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000188")]
		[Cpp2IlInjected.Address(RVA = "0x7D220D0", Offset = "0x7D214D0", VA = "0x187D220D0", Slot = "38")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000069")]
	public float OIGFIEJGDKP
	{
		[Cpp2IlInjected.Token(Token = "0x6000189")]
		[Cpp2IlInjected.Address(RVA = "0x7D22AA0", Offset = "0x7D21EA0", VA = "0x187D22AA0", Slot = "39")]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x600018A")]
		[Cpp2IlInjected.Address(RVA = "0x7D22990", Offset = "0x7D21D90", VA = "0x187D22990", Slot = "40")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700006A")]
	public Vector3 AMMPLEJMPPA
	{
		[Cpp2IlInjected.Token(Token = "0x600018B")]
		[Cpp2IlInjected.Address(RVA = "0x7D23AB0", Offset = "0x7D22EB0", VA = "0x187D23AB0", Slot = "41")]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x600018C")]
		[Cpp2IlInjected.Address(RVA = "0x7D24F10", Offset = "0x7D24310", VA = "0x187D24F10", Slot = "42")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700006B")]
	public Vector3 HHKGCHNAAHG
	{
		[Cpp2IlInjected.Token(Token = "0x600018D")]
		[Cpp2IlInjected.Address(RVA = "0x7D22740", Offset = "0x7D21B40", VA = "0x187D22740", Slot = "43")]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x600018E")]
		[Cpp2IlInjected.Address(RVA = "0x7D26B00", Offset = "0x7D25F00", VA = "0x187D26B00", Slot = "44")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700006C")]
	public Vector3 MJIGPKPLELI
	{
		[Cpp2IlInjected.Token(Token = "0x600018F")]
		[Cpp2IlInjected.Address(RVA = "0x7D22C50", Offset = "0x7D22050", VA = "0x187D22C50", Slot = "45")]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x6000190")]
		[Cpp2IlInjected.Address(RVA = "0x7D26510", Offset = "0x7D25910", VA = "0x187D26510", Slot = "46")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700006D")]
	public Vector3 JOODHKJHNLO
	{
		[Cpp2IlInjected.Token(Token = "0x6000191")]
		[Cpp2IlInjected.Address(RVA = "0x7D25D60", Offset = "0x7D25160", VA = "0x187D25D60", Slot = "47")]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x6000192")]
		[Cpp2IlInjected.Address(RVA = "0x7D25A20", Offset = "0x7D24E20", VA = "0x187D25A20", Slot = "48")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700006E")]
	public bool BMBJPBIDOHG
	{
		[Cpp2IlInjected.Token(Token = "0x6000193")]
		[Cpp2IlInjected.Address(RVA = "0x7D23390", Offset = "0x7D22790", VA = "0x187D23390", Slot = "49")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700006F")]
	public bool BJOIMJAFIGF
	{
		[Cpp2IlInjected.Token(Token = "0x6000194")]
		[Cpp2IlInjected.Address(RVA = "0x7D271C0", Offset = "0x7D265C0", VA = "0x187D271C0", Slot = "50")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000070")]
	public bool APFOPKOGENJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000195")]
		[Cpp2IlInjected.Address(RVA = "0x7D26C40", Offset = "0x7D26040", VA = "0x187D26C40", Slot = "51")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000071")]
	public bool ADKKEMHDLMA
	{
		[Cpp2IlInjected.Token(Token = "0x6000196")]
		[Cpp2IlInjected.Address(RVA = "0x7D247A0", Offset = "0x7D23BA0", VA = "0x187D247A0", Slot = "52")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000072")]
	public Vector3 HPOJAAEIEAI
	{
		[Cpp2IlInjected.Token(Token = "0x60001A7")]
		[Cpp2IlInjected.Address(RVA = "0x7D21400", Offset = "0x7D20800", VA = "0x187D21400", Slot = "53")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000073")]
	public Vector3 GKADHGLIFJO
	{
		[Cpp2IlInjected.Token(Token = "0x60001A8")]
		[Cpp2IlInjected.Address(RVA = "0x7D24110", Offset = "0x7D23510", VA = "0x187D24110", Slot = "54")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000074")]
	public Vector3 JDJFBDLCNID
	{
		[Cpp2IlInjected.Token(Token = "0x60001AD")]
		[Cpp2IlInjected.Address(RVA = "0x7D273A0", Offset = "0x7D267A0", VA = "0x187D273A0", Slot = "55")]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x60001AE")]
		[Cpp2IlInjected.Address(RVA = "0x7D26FA0", Offset = "0x7D263A0", VA = "0x187D26FA0", Slot = "56")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000075")]
	public Vector3 BEKMIPAOELB
	{
		[Cpp2IlInjected.Token(Token = "0x60001AF")]
		[Cpp2IlInjected.Address(RVA = "0x7D22E90", Offset = "0x7D22290", VA = "0x187D22E90", Slot = "57")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000076")]
	public float KGDKBOMCLNC
	{
		[Cpp2IlInjected.Token(Token = "0x60001B0")]
		[Cpp2IlInjected.Address(RVA = "0x7D226D0", Offset = "0x7D21AD0", VA = "0x187D226D0", Slot = "58")]
		get
		{
			return default(float);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000077")]
	public float IGHBOPMJHJJ
	{
		[Cpp2IlInjected.Token(Token = "0x60001B1")]
		[Cpp2IlInjected.Address(RVA = "0x7D25150", Offset = "0x7D24550", VA = "0x187D25150", Slot = "59")]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x60001B2")]
		[Cpp2IlInjected.Address(RVA = "0x7D26A40", Offset = "0x7D25E40", VA = "0x187D26A40", Slot = "60")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000078")]
	public Vector3 JFKAKIPMFCE
	{
		[Cpp2IlInjected.Token(Token = "0x60001B3")]
		[Cpp2IlInjected.Address(RVA = "0x7D25840", Offset = "0x7D24C40", VA = "0x187D25840", Slot = "61")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000079")]
	public Quaternion GNLGGFDBHLB
	{
		[Cpp2IlInjected.Token(Token = "0x60001B4")]
		[Cpp2IlInjected.Address(RVA = "0x7D26780", Offset = "0x7D25B80", VA = "0x187D26780", Slot = "62")]
		get
		{
			return default(Quaternion);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700007A")]
	public float JEOKECDPNLO
	{
		[Cpp2IlInjected.Token(Token = "0x60001B9")]
		[Cpp2IlInjected.Address(RVA = "0x7D22940", Offset = "0x7D21D40", VA = "0x187D22940", Slot = "64")]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x60001BA")]
		[Cpp2IlInjected.Address(RVA = "0x7D26BE0", Offset = "0x7D25FE0", VA = "0x187D26BE0", Slot = "65")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700007B")]
	public float EHGGFICBLII
	{
		[Cpp2IlInjected.Token(Token = "0x60001BB")]
		[Cpp2IlInjected.Address(RVA = "0x7D23E00", Offset = "0x7D23200", VA = "0x187D23E00", Slot = "66")]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x60001BC")]
		[Cpp2IlInjected.Address(RVA = "0x7D23EF0", Offset = "0x7D232F0", VA = "0x187D23EF0", Slot = "67")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700007C")]
	public bool OBGKCEGMDEO
	{
		[Cpp2IlInjected.Token(Token = "0x60001BD")]
		[Cpp2IlInjected.Address(RVA = "0x7D22C00", Offset = "0x7D22000", VA = "0x187D22C00", Slot = "68")]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x60001BE")]
		[Cpp2IlInjected.Address(RVA = "0x7D27480", Offset = "0x7D26880", VA = "0x187D27480", Slot = "69")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700007D")]
	public MGFGMPBMECL DHLEHOILFIK
	{
		[Cpp2IlInjected.Token(Token = "0x60001C6")]
		[Cpp2IlInjected.Address(RVA = "0x7D26D20", Offset = "0x7D26120", VA = "0x187D26D20", Slot = "70")]
		get
		{
			return default(MGFGMPBMECL);
		}
		[Cpp2IlInjected.Token(Token = "0x60001C7")]
		[Cpp2IlInjected.Address(RVA = "0x7D250F0", Offset = "0x7D244F0", VA = "0x187D250F0", Slot = "71")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700007E")]
	public bool FLHOBLPAHLN
	{
		[Cpp2IlInjected.Token(Token = "0x60001CA")]
		[Cpp2IlInjected.Address(RVA = "0x7D25430", Offset = "0x7D24830", VA = "0x187D25430", Slot = "72")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700007F")]
	public Transform IAIIKNABOLF
	{
		[Cpp2IlInjected.Token(Token = "0x60001D0")]
		[Cpp2IlInjected.Address(RVA = "0xB16520", Offset = "0xB15920", VA = "0x180B16520", Slot = "73")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000080")]
	public Vector3 GPOABBPBHJI
	{
		[Cpp2IlInjected.Token(Token = "0x60001D1")]
		[Cpp2IlInjected.Address(RVA = "0x7D260C0", Offset = "0x7D254C0", VA = "0x187D260C0", Slot = "74")]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x60001D2")]
		[Cpp2IlInjected.Address(RVA = "0x7D265F0", Offset = "0x7D259F0", VA = "0x187D265F0", Slot = "75")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000081")]
	public float CHGOGINACEO
	{
		[Cpp2IlInjected.Token(Token = "0x60001D3")]
		[Cpp2IlInjected.Address(RVA = "0x7D274E0", Offset = "0x7D268E0", VA = "0x187D274E0", Slot = "76")]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x60001D4")]
		[Cpp2IlInjected.Address(RVA = "0x7D266A0", Offset = "0x7D25AA0", VA = "0x187D266A0", Slot = "77")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000082")]
	public float FBOGDOFAKAG
	{
		[Cpp2IlInjected.Token(Token = "0x60001D5")]
		[Cpp2IlInjected.Address(RVA = "0x7D24B30", Offset = "0x7D23F30", VA = "0x187D24B30", Slot = "78")]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x60001D6")]
		[Cpp2IlInjected.Address(RVA = "0x7D251A0", Offset = "0x7D245A0", VA = "0x187D251A0", Slot = "79")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000083")]
	public Quaternion FJKKPOBNLLN
	{
		[Cpp2IlInjected.Token(Token = "0x60001D7")]
		[Cpp2IlInjected.Address(RVA = "0x7D25480", Offset = "0x7D24880", VA = "0x187D25480", Slot = "80")]
		get
		{
			return default(Quaternion);
		}
		[Cpp2IlInjected.Token(Token = "0x60001D8")]
		[Cpp2IlInjected.Address(RVA = "0x7D238F0", Offset = "0x7D22CF0", VA = "0x187D238F0", Slot = "81")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000084")]
	public Vector3 FCBPBALDGPI
	{
		[Cpp2IlInjected.Token(Token = "0x60001D9")]
		[Cpp2IlInjected.Address(RVA = "0x7D26F60", Offset = "0x7D26360", VA = "0x187D26F60", Slot = "82")]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x60001DA")]
		[Cpp2IlInjected.Address(RVA = "0x7D24410", Offset = "0x7D23810", VA = "0x187D24410", Slot = "83")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000085")]
	public Quaternion OFMDIGBJIDB
	{
		[Cpp2IlInjected.Token(Token = "0x60001DB")]
		[Cpp2IlInjected.Address(RVA = "0x7D26DA0", Offset = "0x7D261A0", VA = "0x187D26DA0", Slot = "84")]
		get
		{
			return default(Quaternion);
		}
		[Cpp2IlInjected.Token(Token = "0x60001DC")]
		[Cpp2IlInjected.Address(RVA = "0x7D26D70", Offset = "0x7D26170", VA = "0x187D26D70", Slot = "85")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000086")]
	public RigidbodyConstraints HBGDENBJPLN
	{
		[Cpp2IlInjected.Token(Token = "0x60001E0")]
		[Cpp2IlInjected.Address(RVA = "0x7D26070", Offset = "0x7D25470", VA = "0x187D26070", Slot = "86")]
		get
		{
			return default(RigidbodyConstraints);
		}
		[Cpp2IlInjected.Token(Token = "0x60001E1")]
		[Cpp2IlInjected.Address(RVA = "0x7D27220", Offset = "0x7D26620", VA = "0x187D27220", Slot = "87")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000087")]
	public bool EMGGFBFPNEC
	{
		[Cpp2IlInjected.Token(Token = "0x60001E2")]
		[Cpp2IlInjected.Address(RVA = "0x7D232E0", Offset = "0x7D226E0", VA = "0x187D232E0", Slot = "88")]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x60001E3")]
		[Cpp2IlInjected.Address(RVA = "0x7D214D0", Offset = "0x7D208D0", VA = "0x187D214D0", Slot = "89")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000088")]
	public CollisionDetectionMode JFPJCFANLLE
	{
		[Cpp2IlInjected.Token(Token = "0x60001EC")]
		[Cpp2IlInjected.Address(RVA = "0x7D23EA0", Offset = "0x7D232A0", VA = "0x187D23EA0", Slot = "90")]
		get
		{
			return default(CollisionDetectionMode);
		}
		[Cpp2IlInjected.Token(Token = "0x60001ED")]
		[Cpp2IlInjected.Address(RVA = "0x7D262D0", Offset = "0x7D256D0", VA = "0x187D262D0", Slot = "91")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000089")]
	public bool LGLEODHOLBF
	{
		[Cpp2IlInjected.Token(Token = "0x60001EF")]
		[Cpp2IlInjected.Address(RVA = "0x7D21E00", Offset = "0x7D21200", VA = "0x187D21E00", Slot = "141")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700008A")]
	public bool CAKDAAMDCMC
	{
		[Cpp2IlInjected.Token(Token = "0x60001F0")]
		[Cpp2IlInjected.Address(RVA = "0x7D25610", Offset = "0x7D24A10", VA = "0x187D25610", Slot = "92")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000017")]
	public event HKHCEGJIAFD LLNDJKBCKGM
	{
		[Cpp2IlInjected.Token(Token = "0x6000174")]
		[Cpp2IlInjected.Address(RVA = "0x7D26AA0", Offset = "0x7D25EA0", VA = "0x187D26AA0", Slot = "4")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000175")]
		[Cpp2IlInjected.Address(RVA = "0x7D24EB0", Offset = "0x7D242B0", VA = "0x187D24EB0", Slot = "5")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000018")]
	public event HKHCEGJIAFD JDPMJLLIHGJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000176")]
		[Cpp2IlInjected.Address(RVA = "0x7D22BA0", Offset = "0x7D21FA0", VA = "0x187D22BA0", Slot = "6")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000177")]
		[Cpp2IlInjected.Address(RVA = "0x7D27160", Offset = "0x7D26560", VA = "0x187D27160", Slot = "7")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000019")]
	public event DHIOLIJFBFO IHOCNHDBMOC
	{
		[Cpp2IlInjected.Token(Token = "0x6000178")]
		[Cpp2IlInjected.Address(RVA = "0x7D26010", Offset = "0x7D25410", VA = "0x187D26010", Slot = "18")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000179")]
		[Cpp2IlInjected.Address(RVA = "0x7D22070", Offset = "0x7D21470", VA = "0x187D22070", Slot = "19")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400001A")]
	public event HKHCEGJIAFD DEIPDFKLOEI
	{
		[Cpp2IlInjected.Token(Token = "0x6000181")]
		[Cpp2IlInjected.Address(RVA = "0x7D23890", Offset = "0x7D22C90", VA = "0x187D23890", Slot = "8")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000182")]
		[Cpp2IlInjected.Address(RVA = "0x7D213A0", Offset = "0x7D207A0", VA = "0x187D213A0", Slot = "9")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400001B")]
	public event HKHCEGJIAFD MGNJMKOGHOG
	{
		[Cpp2IlInjected.Token(Token = "0x60001AB")]
		[Cpp2IlInjected.Address(RVA = "0x7D22820", Offset = "0x7D21C20", VA = "0x187D22820", Slot = "14")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60001AC")]
		[Cpp2IlInjected.Address(RVA = "0x7D257E0", Offset = "0x7D24BE0", VA = "0x187D257E0", Slot = "15")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400001C")]
	public event HKHCEGJIAFD ACGHLBKLGFH
	{
		[Cpp2IlInjected.Token(Token = "0x60001BF")]
		[Cpp2IlInjected.Address(RVA = "0x7D23220", Offset = "0x7D22620", VA = "0x187D23220", Slot = "16")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60001C0")]
		[Cpp2IlInjected.Address(RVA = "0x7D243B0", Offset = "0x7D237B0", VA = "0x187D243B0", Slot = "17")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400001D")]
	public event Action<BJOOMCLMBJJ, BJOOMCLMBJJ> PKKNONLFKJH
	{
		[Cpp2IlInjected.Token(Token = "0x60001C4")]
		[Cpp2IlInjected.Address(RVA = "0x7D25280", Offset = "0x7D24680", VA = "0x187D25280", Slot = "20")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60001C5")]
		[Cpp2IlInjected.Address(RVA = "0x7D24060", Offset = "0x7D23460", VA = "0x187D24060", Slot = "21")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400001E")]
	public event HKHCEGJIAFD MPMPMNBAFMD
	{
		[Cpp2IlInjected.Token(Token = "0x60001C8")]
		[Cpp2IlInjected.Address(RVA = "0x7D27340", Offset = "0x7D26740", VA = "0x187D27340", Slot = "12")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60001C9")]
		[Cpp2IlInjected.Address(RVA = "0x7D22E30", Offset = "0x7D22230", VA = "0x187D22E30", Slot = "13")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400001F")]
	public event HKHCEGJIAFD IKKJDJGKMMD
	{
		[Cpp2IlInjected.Token(Token = "0x60001CE")]
		[Cpp2IlInjected.Address(RVA = "0x7D22AF0", Offset = "0x7D21EF0", VA = "0x187D22AF0", Slot = "10")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60001CF")]
		[Cpp2IlInjected.Address(RVA = "0x7D229F0", Offset = "0x7D21DF0", VA = "0x187D229F0", Slot = "11")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600016A")]
	[Cpp2IlInjected.Address(RVA = "0x7D27740", Offset = "0x7D26B40", VA = "0x187D27740")]
	public EBKKBHNGFDB(GameObject IIKFCCENKCC, RigidbodyEx EDPEGJAFKJF, NOBPIEBBMDJ FDIJEKJEAKE, [In] FJIIBPHJJOB MJFOKKFMONL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600016B")]
	[Cpp2IlInjected.Address(RVA = "0x7D24840", Offset = "0x7D23C40", VA = "0x187D24840", Slot = "139")]
	protected virtual void JAMJHFEMHAD(NOBPIEBBMDJ FDIJEKJEAKE, FJIIBPHJJOB MJFOKKFMONL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600016C")]
	[Cpp2IlInjected.Address(RVA = "0x7D22FC0", Offset = "0x7D223C0", VA = "0x187D22FC0", Slot = "140")]
	public virtual void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600016D")]
	[Cpp2IlInjected.Address(RVA = "0x7D235F0", Offset = "0x7D229F0", VA = "0x187D235F0", Slot = "93")]
	public void FDCAHJOBADK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600016E")]
	[Cpp2IlInjected.Address(RVA = "0x7D270D0", Offset = "0x7D264D0", VA = "0x187D270D0", Slot = "94")]
	public void OLANPFPIGMN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600016F")]
	[Cpp2IlInjected.Address(RVA = "0x7D241F0", Offset = "0x7D235F0", VA = "0x187D241F0", Slot = "95")]
	public void HJKDELPGJMF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000170")]
	[Cpp2IlInjected.Address(RVA = "0x7D22720", Offset = "0x7D21B20", VA = "0x187D22720", Slot = "96")]
	public void CBLFKAKHCGL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000171")]
	[Cpp2IlInjected.Address(RVA = "0x7D24520", Offset = "0x7D23920", VA = "0x187D24520")]
	private void INEHBEIMHCJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000172")]
	[Cpp2IlInjected.Address(RVA = "0x7D24450", Offset = "0x7D23850", VA = "0x187D24450")]
	private void IFCIIDPJBKH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000173")]
	[Cpp2IlInjected.Address(RVA = "0x7D22DD0", Offset = "0x7D221D0", VA = "0x187D22DD0")]
	private void DMGFOKLLOPH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600017D")]
	[Cpp2IlInjected.Address(RVA = "0x7D231A0", Offset = "0x7D225A0", VA = "0x187D231A0", Slot = "30")]
	public ONELOFJJHKK EFMLGNCDBPK(int FFCBHHABFJN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000180")]
	[Cpp2IlInjected.Address(RVA = "0x7D26710", Offset = "0x7D25B10", VA = "0x187D26710", Slot = "98")]
	public void NMIFEKBMEEA(ONELOFJJHKK PEBNJNGMMHE, bool DPDMJKGJHHG = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000197")]
	[Cpp2IlInjected.Address(RVA = "0x7D25FB0", Offset = "0x7D253B0", VA = "0x187D25FB0", Slot = "99")]
	public void MOOIEOHBJMP(object OCDOGNMJENC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000198")]
	[Cpp2IlInjected.Address(RVA = "0x7D24C00", Offset = "0x7D24000", VA = "0x187D24C00", Slot = "100")]
	public void JJBJKADNPPH(object OCDOGNMJENC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000199")]
	[Cpp2IlInjected.Address(RVA = "0x7D21530", Offset = "0x7D20930", VA = "0x187D21530", Slot = "101")]
	public Vector3 AOMCCDLJABB(Vector3 JDACPJAFGEP)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x600019A")]
	[Cpp2IlInjected.Address(RVA = "0x7D24FF0", Offset = "0x7D243F0", VA = "0x187D24FF0", Slot = "102")]
	public Vector3 KCBFEHNFBFK(Vector3 HAMOEAEOAOL)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x600019B")]
	[Cpp2IlInjected.Address(RVA = "0x7D21630", Offset = "0x7D20A30", VA = "0x187D21630", Slot = "103")]
	public void APHEOEAHJFI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600019C")]
	[Cpp2IlInjected.Address(RVA = "0x7D247F0", Offset = "0x7D23BF0", VA = "0x187D247F0", Slot = "104")]
	public void IOANPPBLGDK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600019D")]
	[Cpp2IlInjected.Address(RVA = "0x7D24BB0", Offset = "0x7D23FB0", VA = "0x187D24BB0", Slot = "105")]
	public void JHLKHALBOGM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600019E")]
	[Cpp2IlInjected.Address(RVA = "0x7D225E0", Offset = "0x7D219E0", VA = "0x187D225E0", Slot = "106")]
	public void BPLIAHFFAAI(Vector3 OHFJHJGFIPG, Vector3 FAOCEJCJAKL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600019F")]
	[Cpp2IlInjected.Address(RVA = "0x7D261E0", Offset = "0x7D255E0", VA = "0x187D261E0", Slot = "107")]
	public void NFGPEMLGGMD(Vector3 DDDBMJFJBND, Vector3 LFBNKFHGCCC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001A0")]
	[Cpp2IlInjected.Address(RVA = "0x7D23B90", Offset = "0x7D22F90", VA = "0x187D23B90", Slot = "108")]
	public void FNLICJJPFAN(Vector3 JPPCCLEJCEF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001A1")]
	[Cpp2IlInjected.Address(RVA = "0x7D237D0", Offset = "0x7D22BD0", VA = "0x187D237D0", Slot = "109")]
	public void FIDPNFHHHIC(GMNANNIIAFD JJMLOJJPJOD, Vector3 IEDMFEDLOLI, float PFIBKJJPFMF, float HEPHAGPAIFL = 8f, float DAMIIJMBJMD = 1f)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001A2")]
	[Cpp2IlInjected.Address(RVA = "0x7D234F0", Offset = "0x7D228F0", VA = "0x187D234F0", Slot = "110")]
	public void FBPHAJGDLKL(LJAIKDFDHAM NLMKINNIADH, Vector3 NEIBHDPOKMM, float AECDACLBOGG = float.PositiveInfinity)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001A3")]
	[Cpp2IlInjected.Address(RVA = "0x7D26EB0", Offset = "0x7D262B0", VA = "0x187D26EB0", Slot = "111")]
	[Obsolete("Deprecated. Still exists to support deprecated CV2 chips. Use ApplyAngularVelocityChange.")]
	public void OHJPDDJGCGP(LJAIKDFDHAM NLMKINNIADH, Vector3 NBFJKGINHEC, float LLMGAIAOBBE = 7f, float MNPCANDNIJK = 1f)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001A4")]
	[Cpp2IlInjected.Address(RVA = "0x7D25920", Offset = "0x7D24D20", VA = "0x187D25920", Slot = "112")]
	public Vector3 LOGKHCLLELM(Vector3 PEBNJNGMMHE)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x60001A5")]
	[Cpp2IlInjected.Address(RVA = "0x7D26330", Offset = "0x7D25730", VA = "0x187D26330", Slot = "113")]
	public Vector3 NIGPEHBBCAF(Vector3 PEBNJNGMMHE)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x60001A6")]
	[Cpp2IlInjected.Address(RVA = "0x7D272F0", Offset = "0x7D266F0", VA = "0x187D272F0", Slot = "114")]
	public void PEPFDMMGINN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001A9")]
	[Cpp2IlInjected.Address(RVA = "0x7D24B40", Offset = "0x7D23F40", VA = "0x187D24B40", Slot = "115")]
	public void JCGBDACECKE(ONELOFJJHKK GBLJIIICMEH, object OCDOGNMJENC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001AA")]
	[Cpp2IlInjected.Address(RVA = "0x7D24250", Offset = "0x7D23650", VA = "0x187D24250", Slot = "116")]
	public void HNBMBMMDFGG(object OCDOGNMJENC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001B5")]
	[Cpp2IlInjected.Address(RVA = "0x7D230C0", Offset = "0x7D224C0", VA = "0x187D230C0", Slot = "63")]
	public void EDOMEHFLAGM((Quaternion rot, Vector3 moments) OLBACLDODGO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001B6")]
	[Cpp2IlInjected.Address(RVA = "0x7D244D0", Offset = "0x7D238D0", VA = "0x187D244D0", Slot = "117")]
	public void IHDPNCBKNIF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001B7")]
	[Cpp2IlInjected.Address(RVA = "0x7D21A00", Offset = "0x7D20E00", VA = "0x187D21A00", Slot = "118")]
	public void BECBIAOEMJG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001B8")]
	[Cpp2IlInjected.Address(RVA = "0x7D22D30", Offset = "0x7D22130", VA = "0x187D22D30", Slot = "119")]
	public void DHKDPIJKLMI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001C1")]
	[Cpp2IlInjected.Address(RVA = "0x7D240C0", Offset = "0x7D234C0", VA = "0x187D240C0", Slot = "120")]
	public bool HHIOEMFBFMI()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001C2")]
	[Cpp2IlInjected.Address(RVA = "0x7D21F40", Offset = "0x7D21340", VA = "0x187D21F40", Slot = "97")]
	public void BIACMLPHAAJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001C3")]
	[Cpp2IlInjected.Address(RVA = "0x7D27280", Offset = "0x7D26680", VA = "0x187D27280", Slot = "121")]
	public void PDDFIHAIDJA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001CB")]
	[Cpp2IlInjected.Address(RVA = "0x7D23280", Offset = "0x7D22680", VA = "0x187D23280", Slot = "122")]
	public void ELPOJILPLGC(object OCDOGNMJENC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001CC")]
	[Cpp2IlInjected.Address(RVA = "0x7D23DA0", Offset = "0x7D231A0", VA = "0x187D23DA0", Slot = "123")]
	public void FNPOKOHAKAF(object OCDOGNMJENC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001CD")]
	[Cpp2IlInjected.Address(RVA = "0x7D210D0", Offset = "0x7D204D0", VA = "0x187D210D0", Slot = "124")]
	public void ABBFPJIBJOM(object OCDOGNMJENC, bool DFOLNBHIIIF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001DD")]
	[Cpp2IlInjected.Address(RVA = "0x7D211A0", Offset = "0x7D205A0", VA = "0x187D211A0", Slot = "125")]
	public void ADKJDNLENNM(Vector3 HIHJAMLBDMM, Quaternion IPCECJGNNOH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001DE")]
	[Cpp2IlInjected.Address(RVA = "0x7D23C70", Offset = "0x7D23070", VA = "0x187D23C70", Slot = "126")]
	public void FNMIDDHCIOG(Vector3 FAGINDBMAJI, Quaternion LNIJFOMFDAF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001DF")]
	[Cpp2IlInjected.Address(RVA = "0x7D23780", Offset = "0x7D22B80", VA = "0x187D23780", Slot = "127")]
	public bool FHLKDACMELL(float KELBOIHJCBN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001E4")]
	[Cpp2IlInjected.Address(RVA = "0x7D23330", Offset = "0x7D22730", VA = "0x187D23330", Slot = "128")]
	public void ENGCLFAOMIF(object OCDOGNMJENC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001E5")]
	[Cpp2IlInjected.Address(RVA = "0x7D22880", Offset = "0x7D21C80", VA = "0x187D22880", Slot = "129")]
	public void CFACGDLJEGL(object OCDOGNMJENC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001E6")]
	[Cpp2IlInjected.Address(RVA = "0x7D276A0", Offset = "0x7D26AA0", VA = "0x187D276A0", Slot = "130")]
	public void POIFJDHJAOA(object OCDOGNMJENC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001E7")]
	[Cpp2IlInjected.Address(RVA = "0x7D22580", Offset = "0x7D21980", VA = "0x187D22580", Slot = "131")]
	public void BNBABJLFLJE(object OCDOGNMJENC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001E8")]
	[Cpp2IlInjected.Address(RVA = "0x7D239D0", Offset = "0x7D22DD0", VA = "0x187D239D0", Slot = "132")]
	public void FKCFFDMFFJM(Vector3 JLJMBNIAGMB, ForceMode NELEMMPBMFP = ForceMode.Force)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001E9")]
	[Cpp2IlInjected.Address(RVA = "0x7D233E0", Offset = "0x7D227E0", VA = "0x187D233E0", Slot = "133")]
	public void FAJNPJOJLMP(Vector3 JLJMBNIAGMB, Vector3 HJBDDDIFEBJ, ForceMode NELEMMPBMFP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001EA")]
	[Cpp2IlInjected.Address(RVA = "0x7D26430", Offset = "0x7D25830", VA = "0x187D26430", Slot = "134")]
	public void NJLAOPPPALH(Vector3 KCHPPHPFPDG, ForceMode NELEMMPBMFP = ForceMode.Force)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001EB")]
	[Cpp2IlInjected.Address(RVA = "0x7D21F90", Offset = "0x7D21390", VA = "0x187D21F90", Slot = "135")]
	public void BLIBBLAJOCG(Vector3 KCHPPHPFPDG, ForceMode NELEMMPBMFP = ForceMode.Force)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001EE")]
	[Cpp2IlInjected.Address(RVA = "0x7D25F10", Offset = "0x7D25310", VA = "0x187D25F10", Slot = "136")]
	public bool MNGHMOHOCBL(Vector3 HEBBPJGOPIH, [Out] RaycastHit JJCHMLEOCKE, float LFDIBKEJEBM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001F1")]
	[Cpp2IlInjected.Address(RVA = "0x7D25790", Offset = "0x7D24B90", VA = "0x187D25790", Slot = "137")]
	public void LHILPJBJEPA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001F2")]
	[Cpp2IlInjected.Address(RVA = "0x7D27700", Offset = "0x7D26B00", VA = "0x187D27700", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001F3")]
	[Cpp2IlInjected.Address(RVA = "0x7D24DD0", Offset = "0x7D241D0", VA = "0x187D24DD0")]
	private void JMOFHNBKLJG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001F4")]
	[Cpp2IlInjected.Address(RVA = "0x7D23F50", Offset = "0x7D23350", VA = "0x187D23F50")]
	private void GPKCOFFIOHN(ONELOFJJHKK HKNGNFLDPKM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001F5")]
	[Cpp2IlInjected.Address(RVA = "0x7D26850", Offset = "0x7D25C50", VA = "0x187D26850")]
	private void NNACNKHEHGG(ONELOFJJHKK HKNGNFLDPKM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001F6")]
	[Cpp2IlInjected.Address(RVA = "0x7D24300", Offset = "0x7D23700", VA = "0x187D24300")]
	private void HNFJIBMLAOJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001F7")]
	[Cpp2IlInjected.Address(RVA = "0x7D25C30", Offset = "0x7D25030", VA = "0x187D25C30")]
	private void MGEDLPHLOBG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001F8")]
	[Cpp2IlInjected.Address(RVA = "0x7D274F0", Offset = "0x7D268F0", VA = "0x187D274F0")]
	private void PMBLHIEFBPM(ONELOFJJHKK DGMNHFMCLFL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001F9")]
	[Cpp2IlInjected.Address(RVA = "0x7D26DE0", Offset = "0x7D261E0", VA = "0x187D26DE0")]
	private void OGNCJHGANFP(ONELOFJJHKK HKNGNFLDPKM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001FA")]
	[Cpp2IlInjected.Address(RVA = "0x7D25E40", Offset = "0x7D25240", VA = "0x187D25E40")]
	private void MMGGACCPOGH(ONELOFJJHKK HKNGNFLDPKM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001FB")]
	[Cpp2IlInjected.Address(RVA = "0x7D252E0", Offset = "0x7D246E0", VA = "0x187D252E0")]
	private void LANDECBOKEC(AIOKEFGMGBL HKNGNFLDPKM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001FC")]
	[Cpp2IlInjected.Address(RVA = "0x7D22130", Offset = "0x7D21530", VA = "0x187D22130", Slot = "142")]
	protected virtual void BMNAOJINIJJ(AIOKEFGMGBL BHMMCABJHIL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001FD")]
	[Cpp2IlInjected.Address(RVA = "0x7D21AA0", Offset = "0x7D20EA0", VA = "0x187D21AA0")]
	protected void BHFKGJNHOIJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001FE")]
	[Cpp2IlInjected.Address(RVA = "0x7D21680", Offset = "0x7D20A80", VA = "0x187D21680")]
	protected void BBJHOFJFDOO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001FF")]
	[Cpp2IlInjected.Address(RVA = "0x7D25B00", Offset = "0x7D24F00", VA = "0x187D25B00")]
	private void MEFPJHAIMCI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000200")]
	[Cpp2IlInjected.Address(RVA = "0x7D24C60", Offset = "0x7D24060", VA = "0x187D24C60")]
	private void JJMMCMOPBKI()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001D")]
internal static class EMMOALELPEI
{
	[Cpp2IlInjected.Token(Token = "0x6000201")]
	[Cpp2IlInjected.Address(RVA = "0x7D27BE0", Offset = "0x7D26FE0", VA = "0x187D27BE0")]
	public static ONELOFJJHKK NHNLOHLFKIO(this ONELOFJJHKK BHMMCABJHIL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000202")]
	[Cpp2IlInjected.Address(RVA = "0x7D27AF0", Offset = "0x7D26EF0", VA = "0x187D27AF0")]
	public static bool HNGGPAJGIOK(this ONELOFJJHKK BHMMCABJHIL, ONELOFJJHKK GEBJJAIONLF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000203")]
	[Cpp2IlInjected.Address(RVA = "0x7D27A50", Offset = "0x7D26E50", VA = "0x187D27A50")]
	public static bool ACMIHNKOJEB(this ONELOFJJHKK BHMMCABJHIL, ONELOFJJHKK CKEMJAECKMK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000204")]
	[Cpp2IlInjected.Address(RVA = "0x7D27B90", Offset = "0x7D26F90", VA = "0x187D27B90")]
	public static AIOKEFGMGBL IBFDILODKIE(this ONELOFJJHKK FBFIKJCNBGP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000205")]
	[Cpp2IlInjected.Address(RVA = "0x7D27CA0", Offset = "0x7D270A0", VA = "0x187D27CA0")]
	public static EBKKBHNGFDB PAINDACCBIK(this ONELOFJJHKK FBFIKJCNBGP)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200001E")]
public class FHEFKEOMBOB : JAOJBEADCCJ
{
	[Cpp2IlInjected.Token(Token = "0x6000206")]
	[Cpp2IlInjected.Address(RVA = "0x7D27D20", Offset = "0x7D27120", VA = "0x187D27D20", Slot = "19")]
	public ONELOFJJHKK GHGJNLFDFNG(RigidbodyEx BHMMCABJHIL, FJIIBPHJJOB MJFOKKFMONL, NOBPIEBBMDJ FDIJEKJEAKE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000207")]
	[Cpp2IlInjected.Address(RVA = "0x966910", Offset = "0x965D10", VA = "0x180966910", Slot = "4")]
	public NJMNCPIJMFH PEJFDGINEJD(ONELOFJJHKK FBFIKJCNBGP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000208")]
	[Cpp2IlInjected.Address(RVA = "0x966910", Offset = "0x965D10", VA = "0x180966910", Slot = "5")]
	public JDCLCIFPIOK LJPEOAGHKNF(ONELOFJJHKK FBFIKJCNBGP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000209")]
	[Cpp2IlInjected.Address(RVA = "0x966910", Offset = "0x965D10", VA = "0x180966910", Slot = "6")]
	public NLMANHFJJCM NAJJHDNJPEA(ONELOFJJHKK FBFIKJCNBGP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600020A")]
	[Cpp2IlInjected.Address(RVA = "0x966910", Offset = "0x965D10", VA = "0x180966910", Slot = "7")]
	public AMAOGLLIKNH FLJLOJHLKKB(ONELOFJJHKK FBFIKJCNBGP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600020B")]
	[Cpp2IlInjected.Address(RVA = "0x966910", Offset = "0x965D10", VA = "0x180966910", Slot = "8")]
	public AGIFBEEDDGA MNJIJDECDPO(ONELOFJJHKK FBFIKJCNBGP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600020C")]
	[Cpp2IlInjected.Address(RVA = "0x966910", Offset = "0x965D10", VA = "0x180966910", Slot = "9")]
	public FGLMJNPEIBL CFOMIEMAGNC(ONELOFJJHKK FBFIKJCNBGP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600020D")]
	[Cpp2IlInjected.Address(RVA = "0x966910", Offset = "0x965D10", VA = "0x180966910", Slot = "10")]
	public IHNLCMKPJDC KOHCGBMADFC(ONELOFJJHKK FBFIKJCNBGP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600020E")]
	[Cpp2IlInjected.Address(RVA = "0x966910", Offset = "0x965D10", VA = "0x180966910", Slot = "11")]
	public LPDBMJLCIPB IGIPKDEGBCH(ONELOFJJHKK FBFIKJCNBGP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600020F")]
	[Cpp2IlInjected.Address(RVA = "0x966910", Offset = "0x965D10", VA = "0x180966910", Slot = "12")]
	public BDIEBBBMBOD PHKJNJKKCEG(ONELOFJJHKK FBFIKJCNBGP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000210")]
	[Cpp2IlInjected.Address(RVA = "0x966910", Offset = "0x965D10", VA = "0x180966910", Slot = "13")]
	public MAKCBALLFAO KBBEOEEHPAI(ONELOFJJHKK FBFIKJCNBGP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000211")]
	[Cpp2IlInjected.Address(RVA = "0x966910", Offset = "0x965D10", VA = "0x180966910")]
	public LMJFADHKKHC GHBOOIBCJGM(ONELOFJJHKK FBFIKJCNBGP, [In] FJIIBPHJJOB MJFOKKFMONL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000212")]
	[Cpp2IlInjected.Address(RVA = "0x966910", Offset = "0x965D10", VA = "0x180966910")]
	public HIEPHFEAIIK IEILHKIILAC(ONELOFJJHKK FBFIKJCNBGP, [In] FJIIBPHJJOB MJFOKKFMONL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000213")]
	[Cpp2IlInjected.Address(RVA = "0x966910", Offset = "0x965D10", VA = "0x180966910")]
	public DJJFIBNFAOA JEACCIIKMBP(ONELOFJJHKK FBFIKJCNBGP, [In] FJIIBPHJJOB MJFOKKFMONL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000214")]
	[Cpp2IlInjected.Address(RVA = "0x966910", Offset = "0x965D10", VA = "0x180966910")]
	public LOGGPMDDFFJ NFGJMEKLDHK(ONELOFJJHKK FBFIKJCNBGP, [In] FJIIBPHJJOB MJFOKKFMONL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000215")]
	[Cpp2IlInjected.Address(RVA = "0x966910", Offset = "0x965D10", VA = "0x180966910")]
	public GLGJPJHKKPH NPHINEEGJIO(ONELOFJJHKK FBFIKJCNBGP, [In] FJIIBPHJJOB MJFOKKFMONL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000216")]
	[Cpp2IlInjected.Address(RVA = "0x96D700", Offset = "0x96CB00", VA = "0x18096D700")]
	public FHEFKEOMBOB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000217")]
	[Cpp2IlInjected.Address(RVA = "0x966910", Offset = "0x965D10", VA = "0x180966910", Slot = "14")]
	private LMJFADHKKHC OHGGCCOEMGD(ONELOFJJHKK FBFIKJCNBGP, [In] FJIIBPHJJOB MJFOKKFMONL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000218")]
	[Cpp2IlInjected.Address(RVA = "0x966910", Offset = "0x965D10", VA = "0x180966910", Slot = "15")]
	private HIEPHFEAIIK GIHNPNCKBNP(ONELOFJJHKK FBFIKJCNBGP, [In] FJIIBPHJJOB MJFOKKFMONL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000219")]
	[Cpp2IlInjected.Address(RVA = "0x966910", Offset = "0x965D10", VA = "0x180966910", Slot = "16")]
	private DJJFIBNFAOA EFPIKEHDMED(ONELOFJJHKK FBFIKJCNBGP, [In] FJIIBPHJJOB MJFOKKFMONL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600021A")]
	[Cpp2IlInjected.Address(RVA = "0x966910", Offset = "0x965D10", VA = "0x180966910", Slot = "17")]
	private LOGGPMDDFFJ MNFFBHHHIOE(ONELOFJJHKK FBFIKJCNBGP, [In] FJIIBPHJJOB MJFOKKFMONL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600021B")]
	[Cpp2IlInjected.Address(RVA = "0x966910", Offset = "0x965D10", VA = "0x180966910", Slot = "18")]
	private GLGJPJHKKPH LDJLPIEIDMO(ONELOFJJHKK FBFIKJCNBGP, [In] FJIIBPHJJOB MJFOKKFMONL)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200001F")]
[RegisterService(typeof(JAOJBEADCCJ), new string[] { })]
public class LMHPFBHDMPB : JAOJBEADCCJ, FLJLMKCIEIM
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000030")]
	private readonly JAOJBEADCCJ JIKDPPOBAOA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000031")]
	private readonly JAOJBEADCCJ JCLCLPCKGMF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000032")]
	private GNEBEIFBKBB FGOFEOIGLPJ;

	[Cpp2IlInjected.Token(Token = "0x1700008B")]
	private JAOJBEADCCJ NACOFFKMMBH
	{
		[Cpp2IlInjected.Token(Token = "0x600021D")]
		[Cpp2IlInjected.Address(RVA = "0x7D30F30", Offset = "0x7D30330", VA = "0x187D30F30")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600021C")]
	[Cpp2IlInjected.Address(RVA = "0x7D30A60", Offset = "0x7D2FE60", VA = "0x187D30A60", Slot = "20")]
	public void InitReferences(FHGOKBONFMJ BHDEAEIFGBG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600021E")]
	[Cpp2IlInjected.Address(RVA = "0x7D30F90", Offset = "0x7D30390", VA = "0x187D30F90", Slot = "4")]
	public NJMNCPIJMFH PEJFDGINEJD(ONELOFJJHKK FBFIKJCNBGP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600021F")]
	[Cpp2IlInjected.Address(RVA = "0x7D30CA0", Offset = "0x7D300A0", VA = "0x187D30CA0", Slot = "5")]
	public JDCLCIFPIOK LJPEOAGHKNF(ONELOFJJHKK FBFIKJCNBGP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000220")]
	[Cpp2IlInjected.Address(RVA = "0x7D30E90", Offset = "0x7D30290", VA = "0x187D30E90", Slot = "6")]
	public NLMANHFJJCM NAJJHDNJPEA(ONELOFJJHKK FBFIKJCNBGP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000221")]
	[Cpp2IlInjected.Address(RVA = "0x7D306E0", Offset = "0x7D2FAE0", VA = "0x187D306E0", Slot = "7")]
	public AMAOGLLIKNH FLJLOJHLKKB(ONELOFJJHKK FBFIKJCNBGP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000222")]
	[Cpp2IlInjected.Address(RVA = "0x7D30DF0", Offset = "0x7D301F0", VA = "0x187D30DF0", Slot = "8")]
	public AGIFBEEDDGA MNJIJDECDPO(ONELOFJJHKK FBFIKJCNBGP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000223")]
	[Cpp2IlInjected.Address(RVA = "0x7D30590", Offset = "0x7D2F990", VA = "0x187D30590", Slot = "9")]
	public FGLMJNPEIBL CFOMIEMAGNC(ONELOFJJHKK FBFIKJCNBGP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000224")]
	[Cpp2IlInjected.Address(RVA = "0x7D30B50", Offset = "0x7D2FF50", VA = "0x187D30B50", Slot = "10")]
	public IHNLCMKPJDC KOHCGBMADFC(ONELOFJJHKK FBFIKJCNBGP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000225")]
	[Cpp2IlInjected.Address(RVA = "0x7D309C0", Offset = "0x7D2FDC0", VA = "0x187D309C0", Slot = "11")]
	public LPDBMJLCIPB IGIPKDEGBCH(ONELOFJJHKK FBFIKJCNBGP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000226")]
	[Cpp2IlInjected.Address(RVA = "0x7D31030", Offset = "0x7D30430", VA = "0x187D31030", Slot = "12")]
	public BDIEBBBMBOD PHKJNJKKCEG(ONELOFJJHKK FBFIKJCNBGP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000227")]
	[Cpp2IlInjected.Address(RVA = "0x7D30AB0", Offset = "0x7D2FEB0", VA = "0x187D30AB0", Slot = "13")]
	public MAKCBALLFAO KBBEOEEHPAI(ONELOFJJHKK FBFIKJCNBGP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000228")]
	[Cpp2IlInjected.Address(RVA = "0x7D30780", Offset = "0x7D2FB80", VA = "0x187D30780")]
	public LMJFADHKKHC GHBOOIBCJGM(ONELOFJJHKK FBFIKJCNBGP, [In] FJIIBPHJJOB MJFOKKFMONL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000229")]
	[Cpp2IlInjected.Address(RVA = "0x7D30910", Offset = "0x7D2FD10", VA = "0x187D30910")]
	public HIEPHFEAIIK IEILHKIILAC(ONELOFJJHKK FBFIKJCNBGP, [In] FJIIBPHJJOB MJFOKKFMONL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600022A")]
	[Cpp2IlInjected.Address(RVA = "0x7D30630", Offset = "0x7D2FA30", VA = "0x187D30630")]
	public DJJFIBNFAOA JEACCIIKMBP(ONELOFJJHKK FBFIKJCNBGP, [In] FJIIBPHJJOB MJFOKKFMONL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600022B")]
	[Cpp2IlInjected.Address(RVA = "0x7D30D40", Offset = "0x7D30140", VA = "0x187D30D40")]
	public LOGGPMDDFFJ NFGJMEKLDHK(ONELOFJJHKK FBFIKJCNBGP, [In] FJIIBPHJJOB MJFOKKFMONL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600022C")]
	[Cpp2IlInjected.Address(RVA = "0x7D30BF0", Offset = "0x7D2FFF0", VA = "0x187D30BF0")]
	public GLGJPJHKKPH NPHINEEGJIO(ONELOFJJHKK FBFIKJCNBGP, [In] FJIIBPHJJOB MJFOKKFMONL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600022D")]
	[Cpp2IlInjected.Address(RVA = "0x7D30830", Offset = "0x7D2FC30", VA = "0x187D30830", Slot = "19")]
	public ONELOFJJHKK GHGJNLFDFNG(RigidbodyEx BHMMCABJHIL, FJIIBPHJJOB MJFOKKFMONL, NOBPIEBBMDJ FDIJEKJEAKE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600022E")]
	[Cpp2IlInjected.Address(RVA = "0x7D310D0", Offset = "0x7D304D0", VA = "0x187D310D0")]
	public LMHPFBHDMPB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600022F")]
	[Cpp2IlInjected.Address(RVA = "0x7D30780", Offset = "0x7D2FB80", VA = "0x187D30780", Slot = "14")]
	private LMJFADHKKHC OHGGCCOEMGD(ONELOFJJHKK FBFIKJCNBGP, [In] FJIIBPHJJOB MJFOKKFMONL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000230")]
	[Cpp2IlInjected.Address(RVA = "0x7D30910", Offset = "0x7D2FD10", VA = "0x187D30910", Slot = "15")]
	private HIEPHFEAIIK GIHNPNCKBNP(ONELOFJJHKK FBFIKJCNBGP, [In] FJIIBPHJJOB MJFOKKFMONL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000231")]
	[Cpp2IlInjected.Address(RVA = "0x7D30630", Offset = "0x7D2FA30", VA = "0x187D30630", Slot = "16")]
	private DJJFIBNFAOA EFPIKEHDMED(ONELOFJJHKK FBFIKJCNBGP, [In] FJIIBPHJJOB MJFOKKFMONL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000232")]
	[Cpp2IlInjected.Address(RVA = "0x7D30D40", Offset = "0x7D30140", VA = "0x187D30D40", Slot = "17")]
	private LOGGPMDDFFJ MNFFBHHHIOE(ONELOFJJHKK FBFIKJCNBGP, [In] FJIIBPHJJOB MJFOKKFMONL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000233")]
	[Cpp2IlInjected.Address(RVA = "0x7D30BF0", Offset = "0x7D2FFF0", VA = "0x187D30BF0", Slot = "18")]
	private GLGJPJHKKPH LDJLPIEIDMO(ONELOFJJHKK FBFIKJCNBGP, [In] FJIIBPHJJOB MJFOKKFMONL)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000020")]
public interface AGAGDKEFHKL : NJMNCPIJMFH, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x6000234")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void JNBHLINGEHE(ONELOFJJHKK BHMMCABJHIL);

	[Cpp2IlInjected.Token(Token = "0x6000235")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void IFLIJNLLMPI(ONELOFJJHKK BHMMCABJHIL);

	[Cpp2IlInjected.Token(Token = "0x6000236")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void ANLKLJDOMBH(ONELOFJJHKK DGMNHFMCLFL);

	[Cpp2IlInjected.Token(Token = "0x6000237")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void OMKJGJFMGAM(ONELOFJJHKK DGMNHFMCLFL);
}
[Cpp2IlInjected.Token(Token = "0x2000021")]
public interface LKABAGHLIAE : NLMANHFJJCM
{
	[Cpp2IlInjected.Token(Token = "0x1700008C")]
	OJLDDPCEFKM<ONELOFJJHKK> NDAJLEHJPGE
	{
		[Cpp2IlInjected.Token(Token = "0x6000238")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700008D")]
	ONELOFJJHKK KFFIGCHNNAM
	{
		[Cpp2IlInjected.Token(Token = "0x6000239")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000022")]
public interface HGPOGLGIBIF : LOGGPMDDFFJ
{
	[Cpp2IlInjected.Token(Token = "0x600023A")]
	[Cpp2IlInjected.Address(Slot = "0")]
	(float, Vector3) EBOOMICJGLN(Rigidbody GLBJDMGCHPE);
}
[Cpp2IlInjected.Token(Token = "0x2000023")]
public interface JNOPICKNCLG : HIEPHFEAIIK, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x1700008E")]
	PhotonView ENLEKBFDFNA
	{
		[Cpp2IlInjected.Token(Token = "0x600023B")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000024")]
internal sealed class PKMBCMBEGIJ : BDIEBBBMBOD
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000033")]
	private readonly EBKKBHNGFDB BHMMCABJHIL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000034")]
	private CollisionDetectionMode CCPJAHDFNBH;

	[Cpp2IlInjected.Token(Token = "0x1700008F")]
	private Rigidbody NDDOBLHGPFH
	{
		[Cpp2IlInjected.Token(Token = "0x600023C")]
		[Cpp2IlInjected.Address(RVA = "0x7D32510", Offset = "0x7D31910", VA = "0x187D32510")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000090")]
	public CollisionDetectionMode JFPJCFANLLE
	{
		[Cpp2IlInjected.Token(Token = "0x6000240")]
		[Cpp2IlInjected.Address(RVA = "0x7D32EF0", Offset = "0x7D322F0", VA = "0x187D32EF0", Slot = "4")]
		get
		{
			return default(CollisionDetectionMode);
		}
		[Cpp2IlInjected.Token(Token = "0x6000241")]
		[Cpp2IlInjected.Address(RVA = "0x7D331E0", Offset = "0x7D325E0", VA = "0x187D331E0", Slot = "5")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600023D")]
	[Cpp2IlInjected.Address(RVA = "0x7D1D990", Offset = "0x7D1CD90", VA = "0x187D1D990")]
	public PKMBCMBEGIJ(ONELOFJJHKK BHMMCABJHIL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600023E")]
	[Cpp2IlInjected.Address(RVA = "0x7D32DE0", Offset = "0x7D321E0", VA = "0x187D32DE0", Slot = "6")]
	public void FDCAHJOBADK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600023F")]
	[Cpp2IlInjected.Address(RVA = "0x7D33000", Offset = "0x7D32400", VA = "0x187D33000", Slot = "9")]
	public void LKOJCFBHNOE(Rigidbody NMCGHNMJFDC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000242")]
	[Cpp2IlInjected.Address(RVA = "0x7D32DC0", Offset = "0x7D321C0", VA = "0x187D32DC0", Slot = "7")]
	public void AENAOLLIDAK(bool KCMENFHDDPM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000243")]
	[Cpp2IlInjected.Address(RVA = "0x7D32DD0", Offset = "0x7D321D0", VA = "0x187D32DD0", Slot = "8")]
	public void DIEHNDIHFKK(bool KCMENFHDDPM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000244")]
	[Cpp2IlInjected.Address(RVA = "0x7D33080", Offset = "0x7D32480", VA = "0x187D33080", Slot = "10")]
	public bool MNGHMOHOCBL(Vector3 HEBBPJGOPIH, [Out] RaycastHit JJCHMLEOCKE, float LFDIBKEJEBM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000245")]
	[Cpp2IlInjected.Address(RVA = "0x7D33250", Offset = "0x7D32650", VA = "0x187D33250")]
	private void PEGAONBFIFH(bool KCMENFHDDPM)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000025")]
public sealed class OBCNEGACLCF : FGLMJNPEIBL, IDisposable, KBEGLFMBMJL
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000036")]
	private readonly EBKKBHNGFDB BHMMCABJHIL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000037")]
	private MGFGMPBMECL EPOMGAKOFNP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000038")]
	private KAMDAKFNHGJ LJDEHHPEBAN;

	[Cpp2IlInjected.Token(Token = "0x17000091")]
	public MGFGMPBMECL DHLEHOILFIK
	{
		[Cpp2IlInjected.Token(Token = "0x6000248")]
		[Cpp2IlInjected.Address(RVA = "0x7D31E10", Offset = "0x7D31210", VA = "0x187D31E10", Slot = "6")]
		get
		{
			return default(MGFGMPBMECL);
		}
		[Cpp2IlInjected.Token(Token = "0x6000249")]
		[Cpp2IlInjected.Address(RVA = "0x7D31C90", Offset = "0x7D31090", VA = "0x187D31C90", Slot = "7")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000092")]
	private Transform BLBNICNJIIP
	{
		[Cpp2IlInjected.Token(Token = "0x600024A")]
		[Cpp2IlInjected.Address(RVA = "0xBC3900", Offset = "0xBC2D00", VA = "0x180BC3900", Slot = "10")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000020")]
	public event Action<BJOOMCLMBJJ, BJOOMCLMBJJ> PKKNONLFKJH
	{
		[Cpp2IlInjected.Token(Token = "0x6000246")]
		[Cpp2IlInjected.Address(RVA = "0x7D31D60", Offset = "0x7D31160", VA = "0x187D31D60", Slot = "4")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000247")]
		[Cpp2IlInjected.Address(RVA = "0x7D31BE0", Offset = "0x7D30FE0", VA = "0x187D31BE0", Slot = "5")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600024B")]
	[Cpp2IlInjected.Address(RVA = "0x7D31F60", Offset = "0x7D31360", VA = "0x187D31F60")]
	public OBCNEGACLCF(ONELOFJJHKK BHMMCABJHIL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600024C")]
	[Cpp2IlInjected.Address(RVA = "0x7D31970", Offset = "0x7D30D70", VA = "0x187D31970", Slot = "8")]
	public void FDCAHJOBADK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600024D")]
	[Cpp2IlInjected.Address(RVA = "0x7D31920", Offset = "0x7D30D20", VA = "0x187D31920", Slot = "9")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600024E")]
	[Cpp2IlInjected.Address(RVA = "0x1037D50", Offset = "0x1037150", VA = "0x181037D50", Slot = "11")]
	private void DGDPFKNFEPB(BJOOMCLMBJJ KDIDMJBHAMD, BJOOMCLMBJJ KAJKOEDAAFH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600024F")]
	[Cpp2IlInjected.Address(RVA = "0x966900", Offset = "0x965D00", VA = "0x180966900", Slot = "12")]
	private void CKMCBNAGNBP(bool FHNENDPEOIN)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000026")]
public class BDOBHJDEKBM : JAOJBEADCCJ
{
	[Cpp2IlInjected.Token(Token = "0x6000250")]
	[Cpp2IlInjected.Address(RVA = "0x7D1D630", Offset = "0x7D1CA30", VA = "0x187D1D630", Slot = "4")]
	public NJMNCPIJMFH PEJFDGINEJD(ONELOFJJHKK FBFIKJCNBGP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000251")]
	[Cpp2IlInjected.Address(RVA = "0x7D1D170", Offset = "0x7D1C570", VA = "0x187D1D170", Slot = "5")]
	public JDCLCIFPIOK LJPEOAGHKNF(ONELOFJJHKK FBFIKJCNBGP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000252")]
	[Cpp2IlInjected.Address(RVA = "0x7D1D500", Offset = "0x7D1C900", VA = "0x187D1D500", Slot = "6")]
	public NLMANHFJJCM NAJJHDNJPEA(ONELOFJJHKK FBFIKJCNBGP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000253")]
	[Cpp2IlInjected.Address(RVA = "0x7D1C950", Offset = "0x7D1BD50", VA = "0x187D1C950", Slot = "7")]
	public AMAOGLLIKNH FLJLOJHLKKB(ONELOFJJHKK FBFIKJCNBGP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000254")]
	[Cpp2IlInjected.Address(RVA = "0x7D1D430", Offset = "0x7D1C830", VA = "0x187D1D430", Slot = "8")]
	public AGIFBEEDDGA MNJIJDECDPO(ONELOFJJHKK FBFIKJCNBGP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000255")]
	[Cpp2IlInjected.Address(RVA = "0x7D1C750", Offset = "0x7D1BB50", VA = "0x187D1C750", Slot = "9")]
	public FGLMJNPEIBL CFOMIEMAGNC(ONELOFJJHKK FBFIKJCNBGP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000256")]
	[Cpp2IlInjected.Address(RVA = "0x7D1CF70", Offset = "0x7D1C370", VA = "0x187D1CF70", Slot = "10")]
	public IHNLCMKPJDC KOHCGBMADFC(ONELOFJJHKK FBFIKJCNBGP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000257")]
	[Cpp2IlInjected.Address(RVA = "0x7D1CDF0", Offset = "0x7D1C1F0", VA = "0x187D1CDF0", Slot = "11")]
	public LPDBMJLCIPB IGIPKDEGBCH(ONELOFJJHKK FBFIKJCNBGP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000258")]
	[Cpp2IlInjected.Address(RVA = "0x7D1D720", Offset = "0x7D1CB20", VA = "0x187D1D720", Slot = "12")]
	public BDIEBBBMBOD PHKJNJKKCEG(ONELOFJJHKK FBFIKJCNBGP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000259")]
	[Cpp2IlInjected.Address(RVA = "0x7D1CEB0", Offset = "0x7D1C2B0", VA = "0x187D1CEB0", Slot = "13")]
	public MAKCBALLFAO KBBEOEEHPAI(ONELOFJJHKK FBFIKJCNBGP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600025A")]
	[Cpp2IlInjected.Address(RVA = "0x7D1C9D0", Offset = "0x7D1BDD0", VA = "0x187D1C9D0")]
	public LMJFADHKKHC GHBOOIBCJGM(ONELOFJJHKK FBFIKJCNBGP, [In] FJIIBPHJJOB MJFOKKFMONL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600025B")]
	[Cpp2IlInjected.Address(RVA = "0x7D1CC60", Offset = "0x7D1C060", VA = "0x187D1CC60")]
	public HIEPHFEAIIK IEILHKIILAC(ONELOFJJHKK FBFIKJCNBGP, [In] FJIIBPHJJOB MJFOKKFMONL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600025C")]
	[Cpp2IlInjected.Address(RVA = "0x7D1C820", Offset = "0x7D1BC20", VA = "0x187D1C820")]
	public DJJFIBNFAOA JEACCIIKMBP(ONELOFJJHKK FBFIKJCNBGP, [In] FJIIBPHJJOB MJFOKKFMONL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600025D")]
	[Cpp2IlInjected.Address(RVA = "0x7D1D2A0", Offset = "0x7D1C6A0", VA = "0x187D1D2A0")]
	public LOGGPMDDFFJ NFGJMEKLDHK(ONELOFJJHKK FBFIKJCNBGP, [In] FJIIBPHJJOB MJFOKKFMONL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600025E")]
	[Cpp2IlInjected.Address(RVA = "0x7D1D090", Offset = "0x7D1C490", VA = "0x187D1D090")]
	public GLGJPJHKKPH NPHINEEGJIO(ONELOFJJHKK FBFIKJCNBGP, [In] FJIIBPHJJOB MJFOKKFMONL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600025F")]
	[Cpp2IlInjected.Address(RVA = "0x7D1CB10", Offset = "0x7D1BF10", VA = "0x187D1CB10", Slot = "19")]
	public ONELOFJJHKK GHGJNLFDFNG(RigidbodyEx BHMMCABJHIL, FJIIBPHJJOB MJFOKKFMONL, NOBPIEBBMDJ FDIJEKJEAKE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000260")]
	[Cpp2IlInjected.Address(RVA = "0x96D700", Offset = "0x96CB00", VA = "0x18096D700")]
	public BDOBHJDEKBM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000261")]
	[Cpp2IlInjected.Address(RVA = "0x7D1C9D0", Offset = "0x7D1BDD0", VA = "0x187D1C9D0", Slot = "14")]
	private LMJFADHKKHC OHGGCCOEMGD(ONELOFJJHKK FBFIKJCNBGP, [In] FJIIBPHJJOB MJFOKKFMONL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000262")]
	[Cpp2IlInjected.Address(RVA = "0x7D1CC60", Offset = "0x7D1C060", VA = "0x187D1CC60", Slot = "15")]
	private HIEPHFEAIIK GIHNPNCKBNP(ONELOFJJHKK FBFIKJCNBGP, [In] FJIIBPHJJOB MJFOKKFMONL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000263")]
	[Cpp2IlInjected.Address(RVA = "0x7D1C820", Offset = "0x7D1BC20", VA = "0x187D1C820", Slot = "16")]
	private DJJFIBNFAOA EFPIKEHDMED(ONELOFJJHKK FBFIKJCNBGP, [In] FJIIBPHJJOB MJFOKKFMONL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000264")]
	[Cpp2IlInjected.Address(RVA = "0x7D1D2A0", Offset = "0x7D1C6A0", VA = "0x187D1D2A0", Slot = "17")]
	private LOGGPMDDFFJ MNFFBHHHIOE(ONELOFJJHKK FBFIKJCNBGP, [In] FJIIBPHJJOB MJFOKKFMONL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000265")]
	[Cpp2IlInjected.Address(RVA = "0x7D1D090", Offset = "0x7D1C490", VA = "0x187D1D090", Slot = "18")]
	private GLGJPJHKKPH LDJLPIEIDMO(ONELOFJJHKK FBFIKJCNBGP, [In] FJIIBPHJJOB MJFOKKFMONL)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000027")]
internal sealed class OBLLOAIGMHO : LPDBMJLCIPB
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000039")]
	private readonly EBKKBHNGFDB BHMMCABJHIL;

	[Cpp2IlInjected.Token(Token = "0x17000093")]
	private Rigidbody NDDOBLHGPFH
	{
		[Cpp2IlInjected.Token(Token = "0x6000266")]
		[Cpp2IlInjected.Address(RVA = "0x7D32510", Offset = "0x7D31910", VA = "0x187D32510")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000094")]
	private bool FLHOBLPAHLN
	{
		[Cpp2IlInjected.Token(Token = "0x6000267")]
		[Cpp2IlInjected.Address(RVA = "0x7D32BA0", Offset = "0x7D31FA0", VA = "0x187D32BA0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000095")]
	private bool HKMHMPHKIAK
	{
		[Cpp2IlInjected.Token(Token = "0x6000268")]
		[Cpp2IlInjected.Address(RVA = "0x7D2FCB0", Offset = "0x7D2F0B0", VA = "0x187D2FCB0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000096")]
	private ONELOFJJHKK GPOFIBLNPEM
	{
		[Cpp2IlInjected.Token(Token = "0x6000269")]
		[Cpp2IlInjected.Address(RVA = "0x7D32250", Offset = "0x7D31650", VA = "0x187D32250")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600026A")]
	[Cpp2IlInjected.Address(RVA = "0x7D1D990", Offset = "0x7D1CD90", VA = "0x187D1D990")]
	public OBLLOAIGMHO(ONELOFJJHKK BHMMCABJHIL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600026B")]
	[Cpp2IlInjected.Address(RVA = "0x7D327E0", Offset = "0x7D31BE0", VA = "0x187D327E0", Slot = "4")]
	public void FKCFFDMFFJM(Vector3 JLJMBNIAGMB, ForceMode NELEMMPBMFP = ForceMode.Force)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600026C")]
	[Cpp2IlInjected.Address(RVA = "0x7D31FF0", Offset = "0x7D313F0", VA = "0x187D31FF0")]
	private void BGBGNDLFDHG(Vector3 JLJMBNIAGMB, ForceMode NELEMMPBMFP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600026D")]
	[Cpp2IlInjected.Address(RVA = "0x7D32560", Offset = "0x7D31960", VA = "0x187D32560", Slot = "5")]
	public void FAJNPJOJLMP(Vector3 JLJMBNIAGMB, Vector3 HJBDDDIFEBJ, ForceMode NELEMMPBMFP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600026E")]
	[Cpp2IlInjected.Address(RVA = "0x7D32BF0", Offset = "0x7D31FF0", VA = "0x187D32BF0", Slot = "6")]
	public void NJLAOPPPALH(Vector3 KCHPPHPFPDG, ForceMode NELEMMPBMFP = ForceMode.Force)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600026F")]
	[Cpp2IlInjected.Address(RVA = "0x7D32940", Offset = "0x7D31D40", VA = "0x187D32940")]
	private void IHKKBOLHPCJ(Vector3 KCHPPHPFPDG, ForceMode NELEMMPBMFP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000270")]
	[Cpp2IlInjected.Address(RVA = "0x7D322B0", Offset = "0x7D316B0", VA = "0x187D322B0", Slot = "7")]
	public void BLIBBLAJOCG(Vector3 KCHPPHPFPDG, ForceMode NELEMMPBMFP = ForceMode.Force)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000028")]
internal sealed class CAODEHDLCON : MAKCBALLFAO
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400003A")]
	private readonly EBKKBHNGFDB BHMMCABJHIL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400003B")]
	private bool GCDMEIDJHHH;

	[Cpp2IlInjected.Token(Token = "0x17000097")]
	public bool OBGKCEGMDEO
	{
		[Cpp2IlInjected.Token(Token = "0x6000272")]
		[Cpp2IlInjected.Address(RVA = "0xC02DE0", Offset = "0xC021E0", VA = "0x180C02DE0", Slot = "4")]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000273")]
		[Cpp2IlInjected.Address(RVA = "0x7D1D880", Offset = "0x7D1CC80", VA = "0x187D1D880", Slot = "5")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000271")]
	[Cpp2IlInjected.Address(RVA = "0x7D1D990", Offset = "0x7D1CD90", VA = "0x187D1D990")]
	public CAODEHDLCON(ONELOFJJHKK BHMMCABJHIL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000274")]
	[Cpp2IlInjected.Address(RVA = "0x7D1D850", Offset = "0x7D1CC50", VA = "0x187D1D850", Slot = "6")]
	public void LKOJCFBHNOE(Rigidbody NMCGHNMJFDC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000275")]
	[Cpp2IlInjected.Address(RVA = "0x7D1D7E0", Offset = "0x7D1CBE0", VA = "0x187D1D7E0", Slot = "7")]
	public void JAMEOJHHPOD(Rigidbody NMCGHNMJFDC)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000029")]
internal sealed class KFLHDLIOFCK : AGAGDKEFHKL, NJMNCPIJMFH, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x4000045")]
	private readonly ONELOFJJHKK BHMMCABJHIL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x4000046")]
	private readonly List<ONELOFJJHKK> KHODHNFIBKJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x4000047")]
	private ONELOFJJHKK HAIKBOLEOOP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x4000048")]
	private ONELOFJJHKK HKNGNFLDPKM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
	[Cpp2IlInjected.Token(Token = "0x4000049")]
	private Transform NHPCDKCNLLJ;

	[Cpp2IlInjected.Token(Token = "0x17000098")]
	private Transform KCFIKHGOCAF
	{
		[Cpp2IlInjected.Token(Token = "0x6000288")]
		[Cpp2IlInjected.Address(RVA = "0x7D2E7C0", Offset = "0x7D2DBC0", VA = "0x187D2E7C0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000099")]
	public ONELOFJJHKK GPOFIBLNPEM
	{
		[Cpp2IlInjected.Token(Token = "0x600028B")]
		[Cpp2IlInjected.Address(RVA = "0x9650D0", Offset = "0x9644D0", VA = "0x1809650D0", Slot = "28")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600028C")]
		[Cpp2IlInjected.Address(RVA = "0x7D2DCF0", Offset = "0x7D2D0F0", VA = "0x187D2DCF0", Slot = "29")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700009A")]
	public ONELOFJJHKK JMIAMIHOFLD
	{
		[Cpp2IlInjected.Token(Token = "0x600028D")]
		[Cpp2IlInjected.Address(RVA = "0x9650B0", Offset = "0x9644B0", VA = "0x1809650B0", Slot = "27")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700009B")]
	public IReadOnlyList<ONELOFJJHKK> HMCFNKLPLCJ
	{
		[Cpp2IlInjected.Token(Token = "0x600028E")]
		[Cpp2IlInjected.Address(RVA = "0x9642F0", Offset = "0x9636F0", VA = "0x1809642F0", Slot = "26")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000021")]
	public event HKHCEGJIAFD LLNDJKBCKGM
	{
		[Cpp2IlInjected.Token(Token = "0x6000276")]
		[Cpp2IlInjected.Address(RVA = "0x7D2F5F0", Offset = "0x7D2E9F0", VA = "0x187D2F5F0", Slot = "8")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000277")]
		[Cpp2IlInjected.Address(RVA = "0x7D2EC60", Offset = "0x7D2E060", VA = "0x187D2EC60", Slot = "9")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000022")]
	public event HKHCEGJIAFD JDPMJLLIHGJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000278")]
		[Cpp2IlInjected.Address(RVA = "0x7D2E350", Offset = "0x7D2D750", VA = "0x187D2E350", Slot = "10")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000279")]
		[Cpp2IlInjected.Address(RVA = "0x7D2F730", Offset = "0x7D2EB30", VA = "0x187D2F730", Slot = "11")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000023")]
	public event DHIOLIJFBFO IHOCNHDBMOC
	{
		[Cpp2IlInjected.Token(Token = "0x600027A")]
		[Cpp2IlInjected.Address(RVA = "0x7D2EE80", Offset = "0x7D2E280", VA = "0x187D2EE80", Slot = "12")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600027B")]
		[Cpp2IlInjected.Address(RVA = "0x7D2E0B0", Offset = "0x7D2D4B0", VA = "0x187D2E0B0", Slot = "13")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000024")]
	public event Action IFAPFBCNKML
	{
		[Cpp2IlInjected.Token(Token = "0x600027C")]
		[Cpp2IlInjected.Address(RVA = "0x7D2ED00", Offset = "0x7D2E100", VA = "0x187D2ED00", Slot = "14")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600027D")]
		[Cpp2IlInjected.Address(RVA = "0x7D2F690", Offset = "0x7D2EA90", VA = "0x187D2F690", Slot = "15")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000025")]
	public event Action PGOOCHKMAHD
	{
		[Cpp2IlInjected.Token(Token = "0x600027E")]
		[Cpp2IlInjected.Address(RVA = "0x7D2EFD0", Offset = "0x7D2E3D0", VA = "0x187D2EFD0", Slot = "16")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600027F")]
		[Cpp2IlInjected.Address(RVA = "0x7D2E5F0", Offset = "0x7D2D9F0", VA = "0x187D2E5F0", Slot = "17")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000026")]
	public event Action<ONELOFJJHKK> OLCLFAAONBM
	{
		[Cpp2IlInjected.Token(Token = "0x6000280")]
		[Cpp2IlInjected.Address(RVA = "0x7D2E3F0", Offset = "0x7D2D7F0", VA = "0x187D2E3F0", Slot = "18")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000281")]
		[Cpp2IlInjected.Address(RVA = "0x7D2E540", Offset = "0x7D2D940", VA = "0x187D2E540", Slot = "19")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000027")]
	public event Action<ONELOFJJHKK> MDMGHIGPCAK
	{
		[Cpp2IlInjected.Token(Token = "0x6000282")]
		[Cpp2IlInjected.Address(RVA = "0x7D2FA50", Offset = "0x7D2EE50", VA = "0x187D2FA50", Slot = "20")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000283")]
		[Cpp2IlInjected.Address(RVA = "0x7D2E150", Offset = "0x7D2D550", VA = "0x187D2E150", Slot = "21")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000028")]
	public event Action GMOLIKPEBEB
	{
		[Cpp2IlInjected.Token(Token = "0x6000284")]
		[Cpp2IlInjected.Address(RVA = "0x7D2E820", Offset = "0x7D2DC20", VA = "0x187D2E820", Slot = "22")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000285")]
		[Cpp2IlInjected.Address(RVA = "0x7D2E2B0", Offset = "0x7D2D6B0", VA = "0x187D2E2B0", Slot = "23")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000029")]
	public event Action<ONELOFJJHKK> NJPOHHJBNJF
	{
		[Cpp2IlInjected.Token(Token = "0x6000286")]
		[Cpp2IlInjected.Address(RVA = "0x7D2E200", Offset = "0x7D2D600", VA = "0x187D2E200", Slot = "24")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000287")]
		[Cpp2IlInjected.Address(RVA = "0x7D2EF20", Offset = "0x7D2E320", VA = "0x187D2EF20", Slot = "25")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000289")]
	[Cpp2IlInjected.Address(RVA = "0x7D2FB00", Offset = "0x7D2EF00", VA = "0x187D2FB00")]
	public KFLHDLIOFCK(ONELOFJJHKK BHMMCABJHIL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600028A")]
	[Cpp2IlInjected.Address(RVA = "0x7D2E4A0", Offset = "0x7D2D8A0", VA = "0x187D2E4A0", Slot = "31")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600028F")]
	[Cpp2IlInjected.Address(RVA = "0x7D2F070", Offset = "0x7D2E470", VA = "0x187D2F070", Slot = "30")]
	public void NMIFEKBMEEA(ONELOFJJHKK DDPMGHJOAAI, bool DPDMJKGJHHG = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000290")]
	[Cpp2IlInjected.Address(RVA = "0x7D2DD00", Offset = "0x7D2D100", VA = "0x187D2DD00", Slot = "6")]
	public void ANLKLJDOMBH(ONELOFJJHKK DGMNHFMCLFL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000291")]
	[Cpp2IlInjected.Address(RVA = "0x7D2F7D0", Offset = "0x7D2EBD0", VA = "0x187D2F7D0", Slot = "7")]
	public void OMKJGJFMGAM(ONELOFJJHKK DGMNHFMCLFL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000292")]
	[Cpp2IlInjected.Address(RVA = "0x7D2EB50", Offset = "0x7D2DF50", VA = "0x187D2EB50", Slot = "4")]
	public void JNBHLINGEHE(ONELOFJJHKK BHMMCABJHIL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000293")]
	[Cpp2IlInjected.Address(RVA = "0x7D2E980", Offset = "0x7D2DD80", VA = "0x187D2E980", Slot = "5")]
	public void IFLIJNLLMPI(ONELOFJJHKK BHMMCABJHIL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000294")]
	[Cpp2IlInjected.Address(RVA = "0x7D2EDA0", Offset = "0x7D2E1A0", VA = "0x187D2EDA0")]
	private void LJKCEDHHAOD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000295")]
	[Cpp2IlInjected.Address(RVA = "0x7D2EE40", Offset = "0x7D2E240", VA = "0x187D2EE40")]
	private void MDEBIOCDJCF(ONELOFJJHKK DGMNHFMCLFL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000296")]
	[Cpp2IlInjected.Address(RVA = "0x7D2DF70", Offset = "0x7D2D370", VA = "0x187D2DF70")]
	private void BLAADEOOHDD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000297")]
	[Cpp2IlInjected.Address(RVA = "0x7D2E690", Offset = "0x7D2DA90", VA = "0x187D2E690")]
	private void GLLJGOKEHAB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000298")]
	[Cpp2IlInjected.Address(RVA = "0x7D2EA20", Offset = "0x7D2DE20", VA = "0x187D2EA20")]
	private void ILHKEPKHHMD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000299")]
	[Cpp2IlInjected.Address(RVA = "0x7D2E8C0", Offset = "0x7D2DCC0", VA = "0x187D2E8C0")]
	[CompilerGenerated]
	private object IAMLBKPFGPB()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200002A")]
internal static class NFMHEHOMIMN
{
	[Cpp2IlInjected.Token(Token = "0x600029A")]
	[Cpp2IlInjected.Address(RVA = "0x7D31590", Offset = "0x7D30990", VA = "0x187D31590")]
	public static AGAGDKEFHKL IOHHFFEAEIA(this ONELOFJJHKK FBFIKJCNBGP)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200002B")]
internal sealed class DGFECPGMJAM : LKABAGHLIAE, NLMANHFJJCM
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400004A")]
	private readonly EBKKBHNGFDB BHMMCABJHIL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400004B")]
	private readonly OJLDDPCEFKM<ONELOFJJHKK> JJBKDJLBDMD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400004C")]
	private bool PHDHHEJDJJN;

	[Cpp2IlInjected.Token(Token = "0x1700009C")]
	public OJLDDPCEFKM<ONELOFJJHKK> NDAJLEHJPGE
	{
		[Cpp2IlInjected.Token(Token = "0x600029B")]
		[Cpp2IlInjected.Address(RVA = "0x968330", Offset = "0x967730", VA = "0x180968330", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700009D")]
	public Vector3 HPOJAAEIEAI
	{
		[Cpp2IlInjected.Token(Token = "0x600029C")]
		[Cpp2IlInjected.Address(RVA = "0x7D20310", Offset = "0x7D1F710", VA = "0x187D20310", Slot = "6")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700009E")]
	public Vector3 GKADHGLIFJO
	{
		[Cpp2IlInjected.Token(Token = "0x600029D")]
		[Cpp2IlInjected.Address(RVA = "0x7D20870", Offset = "0x7D1FC70", VA = "0x187D20870", Slot = "7")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700009F")]
	private Vector3 MJIGPKPLELI
	{
		[Cpp2IlInjected.Token(Token = "0x60002A1")]
		[Cpp2IlInjected.Address(RVA = "0x7D203F0", Offset = "0x7D1F7F0", VA = "0x187D203F0")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A0")]
	public ONELOFJJHKK KFFIGCHNNAM
	{
		[Cpp2IlInjected.Token(Token = "0x60002A2")]
		[Cpp2IlInjected.Address(RVA = "0x7D20340", Offset = "0x7D1F740", VA = "0x187D20340", Slot = "5")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600029E")]
	[Cpp2IlInjected.Address(RVA = "0x7D20FD0", Offset = "0x7D203D0", VA = "0x187D20FD0")]
	public DGFECPGMJAM(ONELOFJJHKK BHMMCABJHIL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600029F")]
	[Cpp2IlInjected.Address(RVA = "0x7D20F60", Offset = "0x7D20360", VA = "0x187D20F60", Slot = "8")]
	public void NMGJBPJCDEG(ONELOFJJHKK HKNGNFLDPKM, object OCDOGNMJENC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002A0")]
	[Cpp2IlInjected.Address(RVA = "0x7D20B70", Offset = "0x7D1FF70", VA = "0x187D20B70", Slot = "9")]
	public void LACEABANCDN(object OCDOGNMJENC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002A3")]
	[Cpp2IlInjected.Address(RVA = "0x7D204D0", Offset = "0x7D1F8D0", VA = "0x187D204D0")]
	private Vector3 FAJGCEJGLHA()
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x60002A4")]
	[Cpp2IlInjected.Address(RVA = "0x7D20BD0", Offset = "0x7D1FFD0", VA = "0x187D20BD0")]
	private void LLPPAOKECEL(ONELOFJJHKK DFKPNPBBILA)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002C")]
internal static class NEALMPNAMLO
{
	[Cpp2IlInjected.Token(Token = "0x60002A5")]
	[Cpp2IlInjected.Address(RVA = "0x7D314D0", Offset = "0x7D308D0", VA = "0x187D314D0")]
	public static LKABAGHLIAE DNKHONLBGGA(this ONELOFJJHKK FBFIKJCNBGP)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200002D")]
internal sealed class CFPOIPKCIFG : HGPOGLGIBIF, LOGGPMDDFFJ
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400004E")]
	private readonly EBKKBHNGFDB BHMMCABJHIL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400004F")]
	private readonly OverridableVector3 MIFJANOJFJM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000050")]
	private readonly OverridableVector3 BGNGJNJCKJB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000051")]
	private float OANBPDAGANI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x44")]
	[Cpp2IlInjected.Token(Token = "0x4000052")]
	private float KJCLMALJCKC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000053")]
	private Vector3 KFHJLHKBAKC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x54")]
	[Cpp2IlInjected.Token(Token = "0x4000054")]
	private Vector3? NLLCNCDPKGI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x64")]
	[Cpp2IlInjected.Token(Token = "0x4000055")]
	private Quaternion? KOPABBBJNIK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
	[Cpp2IlInjected.Token(Token = "0x4000056")]
	private bool JAMEEEMAHHA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x79")]
	[Cpp2IlInjected.Token(Token = "0x4000057")]
	private bool BPCAFCMFGHG;

	[Cpp2IlInjected.Token(Token = "0x170000A1")]
	public Vector3 JDJFBDLCNID
	{
		[Cpp2IlInjected.Token(Token = "0x60002A8")]
		[Cpp2IlInjected.Address(RVA = "0x144EED0", Offset = "0x144E2D0", VA = "0x18144EED0", Slot = "7")]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x60002A9")]
		[Cpp2IlInjected.Address(RVA = "0x7D1DA20", Offset = "0x7D1CE20", VA = "0x187D1DA20", Slot = "8")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A2")]
	public Vector3 BEKMIPAOELB
	{
		[Cpp2IlInjected.Token(Token = "0x60002AA")]
		[Cpp2IlInjected.Address(RVA = "0x7D1E040", Offset = "0x7D1D440", VA = "0x187D1E040", Slot = "9")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A3")]
	public float KGDKBOMCLNC
	{
		[Cpp2IlInjected.Token(Token = "0x60002AB")]
		[Cpp2IlInjected.Address(RVA = "0xBE8880", Offset = "0xBE7C80", VA = "0x180BE8880", Slot = "10")]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x60002AC")]
		[Cpp2IlInjected.Address(RVA = "0x7D1F5C0", Offset = "0x7D1E9C0", VA = "0x187D1F5C0")]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A4")]
	public float IGHBOPMJHJJ
	{
		[Cpp2IlInjected.Token(Token = "0x60002AD")]
		[Cpp2IlInjected.Address(RVA = "0xAEF550", Offset = "0xAEE950", VA = "0x180AEF550", Slot = "11")]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x60002AE")]
		[Cpp2IlInjected.Address(RVA = "0x7D1DBB0", Offset = "0x7D1CFB0", VA = "0x187D1DBB0", Slot = "12")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A5")]
	public Vector3 JFKAKIPMFCE
	{
		[Cpp2IlInjected.Token(Token = "0x60002AF")]
		[Cpp2IlInjected.Address(RVA = "0x7D1FC30", Offset = "0x7D1F030", VA = "0x187D1FC30", Slot = "13")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A6")]
	public Quaternion GNLGGFDBHLB
	{
		[Cpp2IlInjected.Token(Token = "0x60002B0")]
		[Cpp2IlInjected.Address(RVA = "0x7D20030", Offset = "0x7D1F430", VA = "0x187D20030", Slot = "14")]
		get
		{
			return default(Quaternion);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A7")]
	private Rigidbody NDDOBLHGPFH
	{
		[Cpp2IlInjected.Token(Token = "0x60002B8")]
		[Cpp2IlInjected.Address(RVA = "0x7D1E130", Offset = "0x7D1D530", VA = "0x187D1E130")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400002A")]
	public event HKHCEGJIAFD LDHJLEEGJAB
	{
		[Cpp2IlInjected.Token(Token = "0x60002A6")]
		[Cpp2IlInjected.Address(RVA = "0x7D1DC60", Offset = "0x7D1D060", VA = "0x187D1DC60", Slot = "5")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60002A7")]
		[Cpp2IlInjected.Address(RVA = "0x7D1F520", Offset = "0x7D1E920", VA = "0x187D1F520", Slot = "6")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60002B1")]
	[Cpp2IlInjected.Address(RVA = "0x7D201B0", Offset = "0x7D1F5B0", VA = "0x187D201B0")]
	public CFPOIPKCIFG(ONELOFJJHKK BHMMCABJHIL, [In] FJIIBPHJJOB MJFOKKFMONL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002B2")]
	[Cpp2IlInjected.Address(RVA = "0x7D1F220", Offset = "0x7D1E620", VA = "0x187D1F220", Slot = "17")]
	public void IHDPNCBKNIF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002B3")]
	[Cpp2IlInjected.Address(RVA = "0x7D1DAD0", Offset = "0x7D1CED0", VA = "0x187D1DAD0", Slot = "16")]
	public void BECBIAOEMJG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002B4")]
	[Cpp2IlInjected.Address(RVA = "0x7D1FB50", Offset = "0x7D1EF50", VA = "0x187D1FB50", Slot = "19")]
	public void LKOJCFBHNOE(Rigidbody NMCGHNMJFDC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002B5")]
	[Cpp2IlInjected.Address(RVA = "0x7D1F340", Offset = "0x7D1E740", VA = "0x187D1F340", Slot = "20")]
	public void JAMEOJHHPOD(Rigidbody NMCGHNMJFDC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002B6")]
	[Cpp2IlInjected.Address(RVA = "0x7D1DD00", Offset = "0x7D1D100", VA = "0x187D1DD00", Slot = "18")]
	public void DHKDPIJKLMI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002B7")]
	[Cpp2IlInjected.Address(RVA = "0x7D1F6D0", Offset = "0x7D1EAD0", VA = "0x187D1F6D0", Slot = "21")]
	public void LHILPJBJEPA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002B9")]
	[Cpp2IlInjected.Address(RVA = "0x7D1DA20", Offset = "0x7D1CE20", VA = "0x187D1DA20")]
	private void BAJEKFNFCHF(Vector3 PEBNJNGMMHE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002BA")]
	[Cpp2IlInjected.Address(RVA = "0x7D1FF40", Offset = "0x7D1F340", VA = "0x187D1FF40")]
	[Obsolete("This method is dangerous - the unity rigidbody is updated in a deferred manner and this world position may be stale")]
	private Vector3 MCJDJKFLMLP()
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x60002BB")]
	[Cpp2IlInjected.Address(RVA = "0x7D1F5C0", Offset = "0x7D1E9C0", VA = "0x187D1F5C0")]
	private void OBLPBLAJBPK(float PEBNJNGMMHE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002BC")]
	[Cpp2IlInjected.Address(RVA = "0x7D1DBB0", Offset = "0x7D1CFB0", VA = "0x187D1DBB0")]
	private void BHDFGNEBIIC(float PEBNJNGMMHE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002BD")]
	[Cpp2IlInjected.Address(RVA = "0x7D1DEA0", Offset = "0x7D1D2A0", VA = "0x187D1DEA0")]
	private Vector3 DIFNEEIMCFL()
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x60002BE")]
	[Cpp2IlInjected.Address(RVA = "0x7D1EFF0", Offset = "0x7D1E3F0", VA = "0x187D1EFF0", Slot = "15")]
	public void EDOMEHFLAGM((Quaternion rot, Vector3 moments) OLBACLDODGO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002BF")]
	[Cpp2IlInjected.Address(RVA = "0x7D1FDC0", Offset = "0x7D1F1C0", VA = "0x187D1FDC0")]
	private Quaternion LOIEIGOFNPI()
	{
		return default(Quaternion);
	}

	[Cpp2IlInjected.Token(Token = "0x60002C0")]
	[Cpp2IlInjected.Address(RVA = "0x7D1E180", Offset = "0x7D1D580", VA = "0x187D1E180")]
	public void EBOOMICJGLN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002C1")]
	[Cpp2IlInjected.Address(RVA = "0x7D1E250", Offset = "0x7D1D650", VA = "0x187D1E250", Slot = "4")]
	public (float, Vector3) EBOOMICJGLN(Rigidbody GLBJDMGCHPE)
	{
		return default((float, Vector3));
	}
}
[Cpp2IlInjected.Token(Token = "0x200002E")]
internal static class BDFCHHEOIFM
{
	[Cpp2IlInjected.Token(Token = "0x60002C2")]
	[Cpp2IlInjected.Address(RVA = "0x7D1C690", Offset = "0x7D1BA90", VA = "0x187D1C690")]
	public static HGPOGLGIBIF KCFIMMNBIEM(this ONELOFJJHKK FBFIKJCNBGP)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200002F")]
internal sealed class INJCABGFOBB : DJJFIBNFAOA
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000058")]
	private readonly EBKKBHNGFDB BHMMCABJHIL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000059")]
	private readonly MBJBJPKHIHP HCGPGKJFEBJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400005A")]
	private readonly HFGJKELOCBA JIMHAMIIBMC;

	[Cpp2IlInjected.Token(Token = "0x170000A8")]
	public bool PCJDBBDIHPB
	{
		[Cpp2IlInjected.Token(Token = "0x60002C3")]
		[Cpp2IlInjected.Address(RVA = "0x15EDE20", Offset = "0x15ED220", VA = "0x1815EDE20", Slot = "10")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A9")]
	public HFGJKELOCBA OMFDHBOFKAC
	{
		[Cpp2IlInjected.Token(Token = "0x60002C4")]
		[Cpp2IlInjected.Address(RVA = "0xAE5990", Offset = "0xAE4D90", VA = "0x180AE5990", Slot = "11")]
		get
		{
			return default(HFGJKELOCBA);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60002C5")]
	[Cpp2IlInjected.Address(RVA = "0x7D2A290", Offset = "0x7D29690", VA = "0x187D2A290")]
	public INJCABGFOBB(ONELOFJJHKK BHMMCABJHIL, [In] FJIIBPHJJOB MJFOKKFMONL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002C6")]
	[Cpp2IlInjected.Address(RVA = "0x7D29D90", Offset = "0x7D29190", VA = "0x187D29D90", Slot = "4")]
	public void FDCAHJOBADK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002C7")]
	[Cpp2IlInjected.Address(RVA = "0x7D29CC0", Offset = "0x7D290C0", VA = "0x187D29CC0")]
	private bool DCJOCHDINOC()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002C8")]
	[Cpp2IlInjected.Address(RVA = "0x7D29D60", Offset = "0x7D29160", VA = "0x187D29D60", Slot = "5")]
	public void DLHIIMHIJKF(object OCDOGNMJENC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002C9")]
	[Cpp2IlInjected.Address(RVA = "0x7D2A260", Offset = "0x7D29660", VA = "0x187D2A260", Slot = "6")]
	public void MNLPOPDKBLE(object OCDOGNMJENC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002CA")]
	[Cpp2IlInjected.Address(RVA = "0x7D2A130", Offset = "0x7D29530", VA = "0x187D2A130", Slot = "9")]
	public void LOPOCJBNMJC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002CB")]
	[Cpp2IlInjected.Address(RVA = "0x7D2A020", Offset = "0x7D29420", VA = "0x187D2A020")]
	private void LGDBPHHGGIK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002CC")]
	[Cpp2IlInjected.Address(RVA = "0x7D29EA0", Offset = "0x7D292A0", VA = "0x187D29EA0")]
	private void JPMBLBJNNHM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002CD")]
	[Cpp2IlInjected.Address(RVA = "0x7D29E60", Offset = "0x7D29260", VA = "0x187D29E60", Slot = "8")]
	public void JGBEJJMNDLK(ONELOFJJHKK BHMMCABJHIL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002CE")]
	[Cpp2IlInjected.Address(RVA = "0x7D29C80", Offset = "0x7D29080", VA = "0x187D29C80", Slot = "7")]
	public void BDPEKJHGHHI(ONELOFJJHKK BHMMCABJHIL)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000030")]
internal sealed class GHIBKNAFEDL : IHNLCMKPJDC
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400005C")]
	private readonly EBKKBHNGFDB BHMMCABJHIL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400005D")]
	private readonly MBJBJPKHIHP BJNFGJPJMHD;

	[Cpp2IlInjected.Token(Token = "0x170000AA")]
	public bool FLHOBLPAHLN
	{
		[Cpp2IlInjected.Token(Token = "0x60002D1")]
		[Cpp2IlInjected.Address(RVA = "0x7D28000", Offset = "0x7D27400", VA = "0x187D28000", Slot = "6")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400002B")]
	public event HKHCEGJIAFD MPMPMNBAFMD
	{
		[Cpp2IlInjected.Token(Token = "0x60002CF")]
		[Cpp2IlInjected.Address(RVA = "0x7D28130", Offset = "0x7D27530", VA = "0x187D28130", Slot = "4")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60002D0")]
		[Cpp2IlInjected.Address(RVA = "0x7D27ED0", Offset = "0x7D272D0", VA = "0x187D27ED0", Slot = "5")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60002D2")]
	[Cpp2IlInjected.Address(RVA = "0x7D281D0", Offset = "0x7D275D0", VA = "0x187D281D0")]
	public GHIBKNAFEDL(ONELOFJJHKK BHMMCABJHIL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002D3")]
	[Cpp2IlInjected.Address(RVA = "0x7D27F70", Offset = "0x7D27370", VA = "0x187D27F70", Slot = "7")]
	public void ELPOJILPLGC(object OCDOGNMJENC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002D4")]
	[Cpp2IlInjected.Address(RVA = "0x7D27F80", Offset = "0x7D27380", VA = "0x187D27F80", Slot = "8")]
	public void FNPOKOHAKAF(object OCDOGNMJENC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002D5")]
	[Cpp2IlInjected.Address(RVA = "0x7D27DC0", Offset = "0x7D271C0", VA = "0x187D27DC0", Slot = "9")]
	public void ABBFPJIBJOM(object OCDOGNMJENC, bool DFOLNBHIIIF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002D6")]
	[Cpp2IlInjected.Address(RVA = "0x7D27FC0", Offset = "0x7D273C0", VA = "0x187D27FC0", Slot = "12")]
	public void KPIBLHGPCKL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002D7")]
	[Cpp2IlInjected.Address(RVA = "0x7D280B0", Offset = "0x7D274B0", VA = "0x187D280B0", Slot = "10")]
	public void LKOJCFBHNOE(Rigidbody DGHNPONNDGG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002D8")]
	[Cpp2IlInjected.Address(RVA = "0x7D27F90", Offset = "0x7D27390", VA = "0x187D27F90", Slot = "11")]
	public void JAMEOJHHPOD(Rigidbody NMCGHNMJFDC)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000031")]
internal sealed class IBKEDDCFEIM : JNOPICKNCLG, HIEPHFEAIIK, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400005F")]
	private readonly EBKKBHNGFDB BHMMCABJHIL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000060")]
	private PhotonView JKFJDNKEMJP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000061")]
	private bool HAHMBPMINFH;

	[Cpp2IlInjected.Token(Token = "0x170000AB")]
	public PhotonView ENLEKBFDFNA
	{
		[Cpp2IlInjected.Token(Token = "0x60002DB")]
		[Cpp2IlInjected.Address(RVA = "0x9682E0", Offset = "0x9676E0", VA = "0x1809682E0", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000AC")]
	public bool CNDIOOMAJAG
	{
		[Cpp2IlInjected.Token(Token = "0x60002DC")]
		[Cpp2IlInjected.Address(RVA = "0x7D296B0", Offset = "0x7D28AB0", VA = "0x187D296B0", Slot = "7")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000AD")]
	public bool FGJLIHNAGOB
	{
		[Cpp2IlInjected.Token(Token = "0x60002DD")]
		[Cpp2IlInjected.Address(RVA = "0xCEB360", Offset = "0xCEA760", VA = "0x180CEB360", Slot = "8")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400002C")]
	public event HKHCEGJIAFD DEIPDFKLOEI
	{
		[Cpp2IlInjected.Token(Token = "0x60002D9")]
		[Cpp2IlInjected.Address(RVA = "0x7D29610", Offset = "0x7D28A10", VA = "0x187D29610", Slot = "5")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60002DA")]
		[Cpp2IlInjected.Address(RVA = "0x7D28F80", Offset = "0x7D28380", VA = "0x187D28F80", Slot = "6")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60002DE")]
	[Cpp2IlInjected.Address(RVA = "0x7D29B20", Offset = "0x7D28F20", VA = "0x187D29B20")]
	public IBKEDDCFEIM(ONELOFJJHKK BHMMCABJHIL, [In] FJIIBPHJJOB MJFOKKFMONL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002DF")]
	[Cpp2IlInjected.Address(RVA = "0x7D294E0", Offset = "0x7D288E0", VA = "0x187D294E0", Slot = "9")]
	public void FDCAHJOBADK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002E0")]
	[Cpp2IlInjected.Address(RVA = "0x7D29290", Offset = "0x7D28690", VA = "0x187D29290", Slot = "12")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002E1")]
	[Cpp2IlInjected.Address(RVA = "0x7D29840", Offset = "0x7D28C40", VA = "0x187D29840", Slot = "10")]
	public void OGNCJHGANFP(ONELOFJJHKK HKNGNFLDPKM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002E2")]
	[Cpp2IlInjected.Address(RVA = "0x7D296D0", Offset = "0x7D28AD0", VA = "0x187D296D0", Slot = "11")]
	public void MMGGACCPOGH(ONELOFJJHKK HKNGNFLDPKM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002E3")]
	[Cpp2IlInjected.Address(RVA = "0x7D299B0", Offset = "0x7D28DB0", VA = "0x187D299B0")]
	private void PICINIPDPBC(PhotonView LLGHIKNCJDP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002E4")]
	[Cpp2IlInjected.Address(RVA = "0x7D29390", Offset = "0x7D28790", VA = "0x187D29390")]
	private void FCANOKOCMKI(AIOKEFGMGBL KHPCPEHDEIJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002E5")]
	[Cpp2IlInjected.Address(RVA = "0x7D29020", Offset = "0x7D28420", VA = "0x187D29020")]
	private void CEIPEJMAKJD(PhotonView GPDEOLGFFKE)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000032")]
internal static class KKCLFKKCMAN
{
	[Cpp2IlInjected.Token(Token = "0x60002E6")]
	[Cpp2IlInjected.Address(RVA = "0x7D2FBC0", Offset = "0x7D2EFC0", VA = "0x187D2FBC0")]
	public static JNOPICKNCLG DHDLKOLIJMI(this ONELOFJJHKK FBFIKJCNBGP)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000033")]
internal sealed class LPKMAAEFKPK : GLGJPJHKKPH
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000062")]
	private readonly EBKKBHNGFDB BHMMCABJHIL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000063")]
	private RigidbodyConstraints MEHEDGHBFCE;

	[Cpp2IlInjected.Token(Token = "0x170000AE")]
	public bool EMGGFBFPNEC
	{
		[Cpp2IlInjected.Token(Token = "0x60002E7")]
		[Cpp2IlInjected.Address(RVA = "0x9C4090", Offset = "0x9C3490", VA = "0x1809C4090", Slot = "4")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x60002E8")]
		[Cpp2IlInjected.Address(RVA = "0xC0E4B0", Offset = "0xC0D8B0", VA = "0x180C0E4B0", Slot = "5")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000AF")]
	public bool JJIPHEKCDOL
	{
		[Cpp2IlInjected.Token(Token = "0x60002E9")]
		[Cpp2IlInjected.Address(RVA = "0xC0DA70", Offset = "0xC0CE70", VA = "0x180C0DA70", Slot = "6")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x60002EA")]
		[Cpp2IlInjected.Address(RVA = "0xC0E1D0", Offset = "0xC0D5D0", VA = "0x180C0E1D0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B0")]
	public RigidbodyConstraints HBGDENBJPLN
	{
		[Cpp2IlInjected.Token(Token = "0x60002EB")]
		[Cpp2IlInjected.Address(RVA = "0x9712B0", Offset = "0x9706B0", VA = "0x1809712B0", Slot = "7")]
		get
		{
			return default(RigidbodyConstraints);
		}
		[Cpp2IlInjected.Token(Token = "0x60002EC")]
		[Cpp2IlInjected.Address(RVA = "0x7D311E0", Offset = "0x7D305E0", VA = "0x187D311E0", Slot = "8")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60002ED")]
	[Cpp2IlInjected.Address(RVA = "0x7D31310", Offset = "0x7D30710", VA = "0x187D31310")]
	public LPKMAAEFKPK(ONELOFJJHKK BHMMCABJHIL, [In] FJIIBPHJJOB MJFOKKFMONL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002EE")]
	[Cpp2IlInjected.Address(RVA = "0x7D311B0", Offset = "0x7D305B0", VA = "0x187D311B0", Slot = "9")]
	public void LKOJCFBHNOE(Rigidbody NMCGHNMJFDC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002EF")]
	[Cpp2IlInjected.Address(RVA = "0x7D31180", Offset = "0x7D30580", VA = "0x187D31180", Slot = "10")]
	public void JAMEOJHHPOD(Rigidbody NMCGHNMJFDC)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000034")]
internal sealed class NGLEDLIKMFK : AMAOGLLIKNH
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000066")]
	private readonly ONELOFJJHKK BHMMCABJHIL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000067")]
	private float IMCAIGOOKBG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
	[Cpp2IlInjected.Token(Token = "0x4000068")]
	private float FHCMKDGDFDN;

	[Cpp2IlInjected.Token(Token = "0x170000B1")]
	public float JEOKECDPNLO
	{
		[Cpp2IlInjected.Token(Token = "0x60002F1")]
		[Cpp2IlInjected.Address(RVA = "0xDED8E0", Offset = "0xDECCE0", VA = "0x180DED8E0", Slot = "4")]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x60002F2")]
		[Cpp2IlInjected.Address(RVA = "0x7D31810", Offset = "0x7D30C10", VA = "0x187D31810", Slot = "5")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B2")]
	public float EHGGFICBLII
	{
		[Cpp2IlInjected.Token(Token = "0x60002F3")]
		[Cpp2IlInjected.Address(RVA = "0xC30870", Offset = "0xC2FC70", VA = "0x180C30870", Slot = "6")]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x60002F4")]
		[Cpp2IlInjected.Address(RVA = "0x7D31650", Offset = "0x7D30A50", VA = "0x187D31650", Slot = "7")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60002F0")]
	[Cpp2IlInjected.Address(RVA = "0x7D318E0", Offset = "0x7D30CE0", VA = "0x187D318E0")]
	public NGLEDLIKMFK(ONELOFJJHKK BHMMCABJHIL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002F5")]
	[Cpp2IlInjected.Address(RVA = "0x7D317C0", Offset = "0x7D30BC0", VA = "0x187D317C0", Slot = "8")]
	public void LKOJCFBHNOE(Rigidbody NMCGHNMJFDC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002F6")]
	[Cpp2IlInjected.Address(RVA = "0x7D31720", Offset = "0x7D30B20", VA = "0x187D31720", Slot = "9")]
	public void JAMEOJHHPOD(Rigidbody NMCGHNMJFDC)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000035")]
internal sealed class HBBLDLPCNDK : AGIFBEEDDGA
{
	[Cpp2IlInjected.Token(Token = "0x4000069")]
	private static readonly HLBHMADGLFA NIMEFCBFHHM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400006B")]
	private readonly EBKKBHNGFDB BHMMCABJHIL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400006C")]
	private bool NBKHEFLGCDA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x21")]
	[Cpp2IlInjected.Token(Token = "0x400006D")]
	private bool JGANHMOBCLC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
	[Cpp2IlInjected.Token(Token = "0x400006E")]
	private int GKDNEENHLNE;

	[Cpp2IlInjected.Token(Token = "0x170000B3")]
	private Rigidbody NDDOBLHGPFH
	{
		[Cpp2IlInjected.Token(Token = "0x60002F9")]
		[Cpp2IlInjected.Address(RVA = "0x7D1E130", Offset = "0x7D1D530", VA = "0x187D1E130")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B4")]
	private bool LGLEODHOLBF
	{
		[Cpp2IlInjected.Token(Token = "0x60002FA")]
		[Cpp2IlInjected.Address(RVA = "0x7D28320", Offset = "0x7D27720", VA = "0x187D28320")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B5")]
	private ONELOFJJHKK GPOFIBLNPEM
	{
		[Cpp2IlInjected.Token(Token = "0x60002FB")]
		[Cpp2IlInjected.Address(RVA = "0x7D282C0", Offset = "0x7D276C0", VA = "0x187D282C0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B6")]
	private bool HKMHMPHKIAK
	{
		[Cpp2IlInjected.Token(Token = "0x60002FC")]
		[Cpp2IlInjected.Address(RVA = "0x7D283E0", Offset = "0x7D277E0", VA = "0x187D283E0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400002D")]
	public event HKHCEGJIAFD ACGHLBKLGFH
	{
		[Cpp2IlInjected.Token(Token = "0x60002F7")]
		[Cpp2IlInjected.Address(RVA = "0x7D28570", Offset = "0x7D27970", VA = "0x187D28570", Slot = "4")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60002F8")]
		[Cpp2IlInjected.Address(RVA = "0x7D28980", Offset = "0x7D27D80", VA = "0x187D28980", Slot = "5")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60002FD")]
	[Cpp2IlInjected.Address(RVA = "0x7D28EF0", Offset = "0x7D282F0", VA = "0x187D28EF0")]
	public HBBLDLPCNDK(ONELOFJJHKK BHMMCABJHIL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002FE")]
	[Cpp2IlInjected.Address(RVA = "0x7D28610", Offset = "0x7D27A10", VA = "0x187D28610", Slot = "6")]
	public void FDCAHJOBADK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002FF")]
	[Cpp2IlInjected.Address(RVA = "0x7D28E60", Offset = "0x7D28260", VA = "0x187D28E60", Slot = "8")]
	public void PEMCELKPKNP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000300")]
	[Cpp2IlInjected.Address(RVA = "0x7D28830", Offset = "0x7D27C30", VA = "0x187D28830", Slot = "7")]
	public bool HHIOEMFBFMI()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000301")]
	[Cpp2IlInjected.Address(RVA = "0x7D28340", Offset = "0x7D27740", VA = "0x187D28340", Slot = "9")]
	public void BIACMLPHAAJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000302")]
	[Cpp2IlInjected.Address(RVA = "0x7D28DC0", Offset = "0x7D281C0", VA = "0x187D28DC0", Slot = "13")]
	public void PDDFIHAIDJA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000303")]
	[Cpp2IlInjected.Address(RVA = "0x7D28A20", Offset = "0x7D27E20", VA = "0x187D28A20", Slot = "12")]
	public void INEHBEIMHCJ(bool PLKEDKLKNBC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000304")]
	[Cpp2IlInjected.Address(RVA = "0x7D28500", Offset = "0x7D27900", VA = "0x187D28500", Slot = "10")]
	public bool EELHBFBNLDD()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000305")]
	[Cpp2IlInjected.Address(RVA = "0x7D28440", Offset = "0x7D27840", VA = "0x187D28440", Slot = "11")]
	public bool DMGFOKLLOPH()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000306")]
	[Cpp2IlInjected.Address(RVA = "0x7D28B40", Offset = "0x7D27F40", VA = "0x187D28B40")]
	private bool LMNMJDGGLHG()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000307")]
	[Cpp2IlInjected.Address(RVA = "0x7D286A0", Offset = "0x7D27AA0", VA = "0x187D286A0")]
	private void GJGFGMIBBCL()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000036")]
internal sealed class LILGAECBELL : LMJFADHKKHC
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400006F")]
	private readonly EBKKBHNGFDB BHMMCABJHIL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000070")]
	private readonly MBJBJPKHIHP BKLHPBMCFMD;

	[Cpp2IlInjected.Token(Token = "0x170000B7")]
	public Rigidbody NDDOBLHGPFH
	{
		[Cpp2IlInjected.Token(Token = "0x6000309")]
		[Cpp2IlInjected.Address(RVA = "0x9682E0", Offset = "0x9676E0", VA = "0x1809682E0", Slot = "4")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600030A")]
		[Cpp2IlInjected.Address(RVA = "0x968070", Offset = "0x967470", VA = "0x180968070")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B8")]
	private bool HKMHMPHKIAK
	{
		[Cpp2IlInjected.Token(Token = "0x600030B")]
		[Cpp2IlInjected.Address(RVA = "0x7D2FCB0", Offset = "0x7D2F0B0", VA = "0x187D2FCB0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B9")]
	public bool JMMFCFLPIFK
	{
		[Cpp2IlInjected.Token(Token = "0x600030E")]
		[Cpp2IlInjected.Address(RVA = "0x15EDE20", Offset = "0x15ED220", VA = "0x1815EDE20", Slot = "6")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600030C")]
	[Cpp2IlInjected.Address(RVA = "0x7D30480", Offset = "0x7D2F880", VA = "0x187D30480")]
	public LILGAECBELL(ONELOFJJHKK BHMMCABJHIL, [In] FJIIBPHJJOB MJFOKKFMONL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600030D")]
	[Cpp2IlInjected.Address(RVA = "0x7D2FD10", Offset = "0x7D2F110", VA = "0x187D2FD10", Slot = "5")]
	public void FDCAHJOBADK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600030F")]
	[Cpp2IlInjected.Address(RVA = "0x7D30450", Offset = "0x7D2F850", VA = "0x187D30450", Slot = "7")]
	public void POIFJDHJAOA(object OCDOGNMJENC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000310")]
	[Cpp2IlInjected.Address(RVA = "0x7D2FC80", Offset = "0x7D2F080", VA = "0x187D2FC80", Slot = "8")]
	public void BNBABJLFLJE(object OCDOGNMJENC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000311")]
	[Cpp2IlInjected.Address(RVA = "0x7D30120", Offset = "0x7D2F520", VA = "0x187D30120", Slot = "9")]
	public void MMOEHOAOBCB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000312")]
	[Cpp2IlInjected.Address(RVA = "0x7D2FDB0", Offset = "0x7D2F1B0", VA = "0x187D2FDB0", Slot = "10")]
	public void JIGIAKDOMGB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000313")]
	[Cpp2IlInjected.Address(RVA = "0x7D2FFA0", Offset = "0x7D2F3A0", VA = "0x187D2FFA0", Slot = "11")]
	public void KEMBGGIMCLE()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000037")]
internal sealed class JBKJNCIHOLC : JDCLCIFPIOK, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000072")]
	private readonly EBKKBHNGFDB BHMMCABJHIL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000073")]
	private readonly MBJBJPKHIHP NKNMHEDBPDC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000074")]
	private float AHDLFBNBLDH;

	[Cpp2IlInjected.Token(Token = "0x170000BA")]
	public NOLNOOCKIJK IHHDBKNFBBI
	{
		[Cpp2IlInjected.Token(Token = "0x6000314")]
		[Cpp2IlInjected.Address(RVA = "0x969450", Offset = "0x968850", VA = "0x180969450", Slot = "4")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000315")]
		[Cpp2IlInjected.Address(RVA = "0x969430", Offset = "0x968830", VA = "0x180969430", Slot = "5")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000BB")]
	public GLBOIBMAJCP PJLCPLILAJO
	{
		[Cpp2IlInjected.Token(Token = "0x6000316")]
		[Cpp2IlInjected.Address(RVA = "0x969440", Offset = "0x968840", VA = "0x180969440", Slot = "6")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000317")]
		[Cpp2IlInjected.Address(RVA = "0x969460", Offset = "0x968860", VA = "0x180969460", Slot = "7")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000BC")]
	public Vector3 MJIGPKPLELI
	{
		[Cpp2IlInjected.Token(Token = "0x6000318")]
		[Cpp2IlInjected.Address(RVA = "0x7D2ACA0", Offset = "0x7D2A0A0", VA = "0x187D2ACA0", Slot = "8")]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x6000319")]
		[Cpp2IlInjected.Address(RVA = "0x7D2CDE0", Offset = "0x7D2C1E0", VA = "0x187D2CDE0", Slot = "9")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000BD")]
	public Vector3 AMMPLEJMPPA
	{
		[Cpp2IlInjected.Token(Token = "0x600031A")]
		[Cpp2IlInjected.Address(RVA = "0x7D2BC50", Offset = "0x7D2B050", VA = "0x187D2BC50", Slot = "10")]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x600031B")]
		[Cpp2IlInjected.Address(RVA = "0x7D2C4B0", Offset = "0x7D2B8B0", VA = "0x187D2C4B0", Slot = "11")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000BE")]
	public Vector3 JOODHKJHNLO
	{
		[Cpp2IlInjected.Token(Token = "0x600031C")]
		[Cpp2IlInjected.Address(RVA = "0x7D2CA20", Offset = "0x7D2BE20", VA = "0x187D2CA20", Slot = "12")]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x600031D")]
		[Cpp2IlInjected.Address(RVA = "0x7D2C960", Offset = "0x7D2BD60", VA = "0x187D2C960", Slot = "13")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000BF")]
	public Vector3 HHKGCHNAAHG
	{
		[Cpp2IlInjected.Token(Token = "0x600031E")]
		[Cpp2IlInjected.Address(RVA = "0x7D2AA00", Offset = "0x7D29E00", VA = "0x187D2AA00", Slot = "14")]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x600031F")]
		[Cpp2IlInjected.Address(RVA = "0x7D2CEA0", Offset = "0x7D2C2A0", VA = "0x187D2CEA0", Slot = "15")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000C0")]
	public float OIGFIEJGDKP
	{
		[Cpp2IlInjected.Token(Token = "0x6000320")]
		[Cpp2IlInjected.Address(RVA = "0xEFF3E0", Offset = "0xEFE7E0", VA = "0x180EFF3E0", Slot = "16")]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x6000321")]
		[Cpp2IlInjected.Address(RVA = "0x7D2AB90", Offset = "0x7D29F90", VA = "0x187D2AB90", Slot = "17")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000C1")]
	public bool ADKKEMHDLMA
	{
		[Cpp2IlInjected.Token(Token = "0x6000322")]
		[Cpp2IlInjected.Address(RVA = "0x1F25F30", Offset = "0x1F25330", VA = "0x181F25F30", Slot = "18")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000C2")]
	private LPDBMJLCIPB FGEMGOMLHEJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000337")]
		[Cpp2IlInjected.Address(RVA = "0x73A97F0", Offset = "0x73A8BF0", VA = "0x1873A97F0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000C3")]
	private bool LGLEODHOLBF
	{
		[Cpp2IlInjected.Token(Token = "0x6000338")]
		[Cpp2IlInjected.Address(RVA = "0x7D2A7A0", Offset = "0x7D29BA0", VA = "0x187D2A7A0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000323")]
	[Cpp2IlInjected.Address(RVA = "0x7D2DC00", Offset = "0x7D2D000", VA = "0x187D2DC00")]
	public JBKJNCIHOLC(ONELOFJJHKK BHMMCABJHIL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000324")]
	[Cpp2IlInjected.Address(RVA = "0x7D2A570", Offset = "0x7D29970", VA = "0x187D2A570", Slot = "19")]
	public void FDCAHJOBADK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000325")]
	[Cpp2IlInjected.Address(RVA = "0x7D2AE50", Offset = "0x7D2A250", VA = "0x187D2AE50", Slot = "36")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000326")]
	[Cpp2IlInjected.Address(RVA = "0x7D2C750", Offset = "0x7D2BB50", VA = "0x187D2C750", Slot = "28")]
	public void LKOJCFBHNOE(Rigidbody NMCGHNMJFDC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000327")]
	[Cpp2IlInjected.Address(RVA = "0x13EFBE0", Offset = "0x13EEFE0", VA = "0x1813EFBE0", Slot = "20")]
	public void GOFFGFAMKAM(object OCDOGNMJENC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000328")]
	[Cpp2IlInjected.Address(RVA = "0x13F04E0", Offset = "0x13EF8E0", VA = "0x1813F04E0", Slot = "30")]
	public void HFDGCLDBFAG(object OCDOGNMJENC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000329")]
	[Cpp2IlInjected.Address(RVA = "0x7D2A390", Offset = "0x7D29790", VA = "0x187D2A390", Slot = "35")]
	public Vector3 AOMCCDLJABB(Vector3 JDACPJAFGEP)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x600032A")]
	[Cpp2IlInjected.Address(RVA = "0x7D2C4E0", Offset = "0x7D2B8E0", VA = "0x187D2C4E0", Slot = "34")]
	public Vector3 KCBFEHNFBFK(Vector3 HAMOEAEOAOL)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x600032B")]
	[Cpp2IlInjected.Address(RVA = "0x7D2A570", Offset = "0x7D29970", VA = "0x187D2A570", Slot = "27")]
	public void APHEOEAHJFI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600032C")]
	[Cpp2IlInjected.Address(RVA = "0x7D2C3F0", Offset = "0x7D2B7F0", VA = "0x187D2C3F0", Slot = "25")]
	public void IOANPPBLGDK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600032D")]
	[Cpp2IlInjected.Address(RVA = "0x7D2C450", Offset = "0x7D2B850", VA = "0x187D2C450", Slot = "24")]
	public void JHLKHALBOGM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600032E")]
	[Cpp2IlInjected.Address(RVA = "0x7D2A7C0", Offset = "0x7D29BC0", VA = "0x187D2A7C0", Slot = "33")]
	public void BPLIAHFFAAI(Vector3 OHFJHJGFIPG, Vector3 FAOCEJCJAKL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600032F")]
	[Cpp2IlInjected.Address(RVA = "0x7D2CD80", Offset = "0x7D2C180", VA = "0x187D2CD80", Slot = "32")]
	public void NFGPEMLGGMD(Vector3 DDDBMJFJBND, Vector3 LFBNKFHGCCC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000330")]
	[Cpp2IlInjected.Address(RVA = "0x7D2BDD0", Offset = "0x7D2B1D0", VA = "0x187D2BDD0", Slot = "31")]
	public void FNLICJJPFAN(Vector3 JPPCCLEJCEF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000331")]
	[Cpp2IlInjected.Address(RVA = "0x7D2B5B0", Offset = "0x7D2A9B0", VA = "0x187D2B5B0", Slot = "22")]
	public void FIDPNFHHHIC(GMNANNIIAFD JJMLOJJPJOD, Vector3 IEDMFEDLOLI, float PFIBKJJPFMF, float HEPHAGPAIFL = 8f, float DAMIIJMBJMD = 1f)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000332")]
	[Cpp2IlInjected.Address(RVA = "0x7D2B330", Offset = "0x7D2A730", VA = "0x187D2B330", Slot = "21")]
	public void FBPHAJGDLKL(LJAIKDFDHAM NLMKINNIADH, Vector3 NEIBHDPOKMM, float AECDACLBOGG = float.PositiveInfinity)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000333")]
	[Cpp2IlInjected.Address(RVA = "0x7D2D470", Offset = "0x7D2C870", VA = "0x187D2D470", Slot = "23")]
	[Obsolete("Deprecated. Still exists to support deprecated CV2 chips. Use ApplyAngularVelocityChange.")]
	public void OHJPDDJGCGP(LJAIKDFDHAM NLMKINNIADH, Vector3 NBFJKGINHEC, float LLMGAIAOBBE = 7f, float MNPCANDNIJK = 1f)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000334")]
	[Cpp2IlInjected.Address(RVA = "0x15403F0", Offset = "0x153F7F0", VA = "0x1815403F0")]
	private static void JCLPBKBKAGO(Vector3 BCGMKGELHNE, Vector3 BLIFKOEAPLP, [Out] Vector3 IHJLAJGOIJI, [Out] Vector3 GPIBLJDENIG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000335")]
	[Cpp2IlInjected.Address(RVA = "0x7D2C880", Offset = "0x7D2BC80", VA = "0x187D2C880", Slot = "29")]
	public Vector3 LOGKHCLLELM(Vector3 BCGMKGELHNE)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000336")]
	[Cpp2IlInjected.Address(RVA = "0x7D2D8F0", Offset = "0x7D2CCF0", VA = "0x187D2D8F0", Slot = "26")]
	public void PEPFDMMGINN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000339")]
	[Cpp2IlInjected.Address(RVA = "0x7D2AB90", Offset = "0x7D29F90", VA = "0x187D2AB90")]
	private void MEBFIMIBOHM(float PEBNJNGMMHE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600033A")]
	[Cpp2IlInjected.Address(RVA = "0x7D2CBE0", Offset = "0x7D2BFE0", VA = "0x187D2CBE0")]
	private void MPDHHEDLHON(Vector3 NEIBHDPOKMM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600033B")]
	[Cpp2IlInjected.Address(RVA = "0x7D2DA80", Offset = "0x7D2CE80", VA = "0x187D2DA80")]
	private Vector3 POCJHIKNNPA()
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x600033C")]
	[Cpp2IlInjected.Address(RVA = "0x7D2BF70", Offset = "0x7D2B370", VA = "0x187D2BF70")]
	private void GCCIOMMPEMD(Vector3 HAMOEAEOAOL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600033D")]
	[Cpp2IlInjected.Address(RVA = "0x7D2A610", Offset = "0x7D29A10", VA = "0x187D2A610")]
	private Vector3 BBBOAKNDCNE()
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x600033E")]
	[Cpp2IlInjected.Address(RVA = "0x7D2AEB0", Offset = "0x7D2A2B0", VA = "0x187D2AEB0")]
	private void EPLALOLKNLF(Vector3 PEBNJNGMMHE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600033F")]
	[Cpp2IlInjected.Address(RVA = "0x7D2CED0", Offset = "0x7D2C2D0", VA = "0x187D2CED0")]
	private void ODJHCNOMKLN(Vector3 HAMOEAEOAOL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000340")]
	[Cpp2IlInjected.Address(RVA = "0x7D2C6A0", Offset = "0x7D2BAA0", VA = "0x187D2C6A0")]
	private void KGBPMHOPBLK()
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
