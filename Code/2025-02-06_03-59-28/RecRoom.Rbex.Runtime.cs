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
	public class LogRegistrationIndex : CGFLIBNDCKI
	{
		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(RVA = "0x7972210", Offset = "0x7971010", VA = "0x187972210", Slot = "4")]
		public override void EHDMJEMLBPD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0x9201C0", Offset = "0x91EFC0", VA = "0x1809201C0")]
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
			[Cpp2IlInjected.Address(RVA = "0x8F41F0", Offset = "0x8F2FF0", VA = "0x1808F41F0", Slot = "4")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x1E0BA10", Offset = "0x1E0A810", VA = "0x181E0BA10", Slot = "5")]
		public override void SetServiceCategoryIndices(List<int> globalFromLocalIndices)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x797A9B0", Offset = "0x79797B0", VA = "0x18797A9B0")]
		private void OGIEEDDHGBJ(IServiceRegistration registry)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x797ACB0", Offset = "0x7979AB0", VA = "0x18797ACB0", Slot = "6")]
		public override void RegisterServices(IServiceRegistration registry, [In] ServiceBitsetFilter filter)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x797AD10", Offset = "0x7979B10", VA = "0x18797AD10")]
		public _AssemblyIndex()
		{
		}
	}
}
namespace RecRoom
{
	[Cpp2IlInjected.Token(Token = "0x2000004")]
	[DisallowMultipleComponent]
	public sealed class RigidbodyEx : MonoBehaviour, FHDFMCFBJMM, HECGOLGDACB
	{
		[Cpp2IlInjected.Token(Token = "0x4000004")]
		private static readonly IMOCAMGHNDM PGODBPONAEL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000005")]
		private bool LCAIAKNOJEA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000006")]
		private BKMLAJCFPOO LFBJPHIJGCF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000007")]
		[IAEEMABIONI(ADIKDNKOEBP.Self, false, false, false)]
		[SerializeField]
		private Rigidbody unityRigidbody;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000008")]
		[SerializeField]
		[IAEEMABIONI(ADIKDNKOEBP.SelfAndParent, true, false, false)]
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
		private OAPFEGBJMCF physicsInterpolation;

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
		private Transform LPCIHLAMILD;

		[Cpp2IlInjected.Token(Token = "0x17000002")]
		internal BKMLAJCFPOO ONFPGHDPKKM
		{
			[Cpp2IlInjected.Token(Token = "0x6000008")]
			[Cpp2IlInjected.Address(RVA = "0x79763C0", Offset = "0x79751C0", VA = "0x1879763C0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000003")]
		private BKMLAJCFPOO CKBAPIGGBJG
		{
			[Cpp2IlInjected.Token(Token = "0x6000009")]
			[Cpp2IlInjected.Address(RVA = "0x8F7B20", Offset = "0x8F6920", VA = "0x1808F7B20", Slot = "6")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000004")]
		public int ALNDPLKKMOO
		{
			[Cpp2IlInjected.Token(Token = "0x600001D")]
			[Cpp2IlInjected.Address(RVA = "0x7977EC0", Offset = "0x7976CC0", VA = "0x187977EC0")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000005")]
		public RigidbodyEx HEHNJLDAIOC
		{
			[Cpp2IlInjected.Token(Token = "0x600001F")]
			[Cpp2IlInjected.Address(RVA = "0x7978220", Offset = "0x7977020", VA = "0x187978220")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000006")]
		public RigidbodyEx DIPIAJCGAGN
		{
			[Cpp2IlInjected.Token(Token = "0x6000020")]
			[Cpp2IlInjected.Address(RVA = "0x7978160", Offset = "0x7976F60", VA = "0x187978160")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000007")]
		public RigidbodyEx IFAMCPHMKIP
		{
			[Cpp2IlInjected.Token(Token = "0x6000021")]
			[Cpp2IlInjected.Address(RVA = "0x7978E20", Offset = "0x7977C20", VA = "0x187978E20")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000022")]
			[Cpp2IlInjected.Address(RVA = "0x797A320", Offset = "0x7979120", VA = "0x18797A320")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000008")]
		public bool JHOHEJMLBOH
		{
			[Cpp2IlInjected.Token(Token = "0x6000023")]
			[Cpp2IlInjected.Address(RVA = "0x7947870", Offset = "0x7946670", VA = "0x187947870", Slot = "10")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000024")]
			[Cpp2IlInjected.Address(RVA = "0x7948920", Offset = "0x7947720", VA = "0x187948920")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000009")]
		public Transform KAEMFHJNGPI
		{
			[Cpp2IlInjected.Token(Token = "0x6000025")]
			[Cpp2IlInjected.Address(RVA = "0x110E020", Offset = "0x110CE20", VA = "0x18110E020", Slot = "5")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000A")]
		public Transform JDPJMNIKGJI
		{
			[Cpp2IlInjected.Token(Token = "0x6000026")]
			[Cpp2IlInjected.Address(RVA = "0x110E020", Offset = "0x110CE20", VA = "0x18110E020", Slot = "11")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000B")]
		public Transform CAKBGADMKLG
		{
			[Cpp2IlInjected.Token(Token = "0x6000027")]
			[Cpp2IlInjected.Address(RVA = "0x110E020", Offset = "0x110CE20", VA = "0x18110E020", Slot = "12")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000C")]
		public CDPBBJLFOGJ LAFBBOHALEO
		{
			[Cpp2IlInjected.Token(Token = "0x6000028")]
			[Cpp2IlInjected.Address(RVA = "0x7977F20", Offset = "0x7976D20", VA = "0x187977F20")]
			get
			{
				return default(CDPBBJLFOGJ);
			}
			[Cpp2IlInjected.Token(Token = "0x6000029")]
			[Cpp2IlInjected.Address(RVA = "0x7979AD0", Offset = "0x79788D0", VA = "0x187979AD0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000D")]
		public bool FIPIKFDPMLE
		{
			[Cpp2IlInjected.Token(Token = "0x600002A")]
			[Cpp2IlInjected.Address(RVA = "0x7978530", Offset = "0x7977330", VA = "0x187978530")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000E")]
		public bool DDHKLPODPHG
		{
			[Cpp2IlInjected.Token(Token = "0x600002B")]
			[Cpp2IlInjected.Address(RVA = "0x7978040", Offset = "0x7976E40", VA = "0x187978040")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000F")]
		public OIIFFMGENDA NDGKBOLHLFO
		{
			[Cpp2IlInjected.Token(Token = "0x600002C")]
			[Cpp2IlInjected.Address(RVA = "0x7978470", Offset = "0x7977270", VA = "0x187978470")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600002D")]
			[Cpp2IlInjected.Address(RVA = "0x7979C90", Offset = "0x7978A90", VA = "0x187979C90")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000010")]
		public PEHCDIDIDFL HADAHAKIAGP
		{
			[Cpp2IlInjected.Token(Token = "0x600002E")]
			[Cpp2IlInjected.Address(RVA = "0x7978410", Offset = "0x7977210", VA = "0x187978410")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600002F")]
			[Cpp2IlInjected.Address(RVA = "0x7979C20", Offset = "0x7978A20", VA = "0x187979C20")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000011")]
		public bool FFNKJNLOBKO
		{
			[Cpp2IlInjected.Token(Token = "0x6000030")]
			[Cpp2IlInjected.Address(RVA = "0x7978360", Offset = "0x7977160", VA = "0x187978360")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000012")]
		public Rigidbody OKMLLKAPHNL
		{
			[Cpp2IlInjected.Token(Token = "0x6000031")]
			[Cpp2IlInjected.Address(RVA = "0x79783C0", Offset = "0x79771C0", VA = "0x1879783C0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000013")]
		public bool NJLANIHBHFG
		{
			[Cpp2IlInjected.Token(Token = "0x6000032")]
			[Cpp2IlInjected.Address(RVA = "0x79780A0", Offset = "0x7976EA0", VA = "0x1879780A0")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000033")]
			[Cpp2IlInjected.Address(RVA = "0x7979B40", Offset = "0x7978940", VA = "0x187979B40")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000014")]
		public bool ADKGCMLHFNC
		{
			[Cpp2IlInjected.Token(Token = "0x6000034")]
			[Cpp2IlInjected.Address(RVA = "0x7616B70", Offset = "0x7615970", VA = "0x187616B70", Slot = "7")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000015")]
		public float EAFBCACBELB
		{
			[Cpp2IlInjected.Token(Token = "0x6000035")]
			[Cpp2IlInjected.Address(RVA = "0x7978DC0", Offset = "0x7977BC0", VA = "0x187978DC0")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000016")]
		public float EPBICGONCPE
		{
			[Cpp2IlInjected.Token(Token = "0x6000036")]
			[Cpp2IlInjected.Address(RVA = "0x7978D60", Offset = "0x7977B60", VA = "0x187978D60")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x6000037")]
			[Cpp2IlInjected.Address(RVA = "0x797A2B0", Offset = "0x79790B0", VA = "0x18797A2B0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000017")]
		public float HCEIMKNAAFE
		{
			[Cpp2IlInjected.Token(Token = "0x6000038")]
			[Cpp2IlInjected.Address(RVA = "0x7978790", Offset = "0x7977590", VA = "0x187978790")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x6000039")]
			[Cpp2IlInjected.Address(RVA = "0x7979F30", Offset = "0x7978D30", VA = "0x187979F30")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000018")]
		public float GBAJHMLCMJB
		{
			[Cpp2IlInjected.Token(Token = "0x600003A")]
			[Cpp2IlInjected.Address(RVA = "0x7978590", Offset = "0x7977390", VA = "0x187978590")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x600003B")]
			[Cpp2IlInjected.Address(RVA = "0x7979D00", Offset = "0x7978B00", VA = "0x187979D00")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000019")]
		public bool DDFLCDPPIEG
		{
			[Cpp2IlInjected.Token(Token = "0x600003C")]
			[Cpp2IlInjected.Address(RVA = "0x7979370", Offset = "0x7978170", VA = "0x187979370")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x600003D")]
			[Cpp2IlInjected.Address(RVA = "0x797A860", Offset = "0x7979660", VA = "0x18797A860")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001A")]
		public Vector3 KJICILJFPNL
		{
			[Cpp2IlInjected.Token(Token = "0x600003E")]
			[Cpp2IlInjected.Address(RVA = "0x7978B40", Offset = "0x7977940", VA = "0x187978B40")]
			get
			{
				return default(Vector3);
			}
			[Cpp2IlInjected.Token(Token = "0x600003F")]
			[Cpp2IlInjected.Address(RVA = "0x797A080", Offset = "0x7978E80", VA = "0x18797A080")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001B")]
		public Vector3 OCLGEFOEIEE
		{
			[Cpp2IlInjected.Token(Token = "0x6000040")]
			[Cpp2IlInjected.Address(RVA = "0x79794B0", Offset = "0x79782B0", VA = "0x1879794B0")]
			get
			{
				return default(Vector3);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001C")]
		public CollisionDetectionMode GMHADAHOLGE
		{
			[Cpp2IlInjected.Token(Token = "0x6000041")]
			[Cpp2IlInjected.Address(RVA = "0x79786D0", Offset = "0x79774D0", VA = "0x1879786D0")]
			get
			{
				return default(CollisionDetectionMode);
			}
			[Cpp2IlInjected.Token(Token = "0x6000042")]
			[Cpp2IlInjected.Address(RVA = "0x7979E50", Offset = "0x7978C50", VA = "0x187979E50")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001D")]
		public float PGGIFJBJEHC
		{
			[Cpp2IlInjected.Token(Token = "0x6000043")]
			[Cpp2IlInjected.Address(RVA = "0x7978100", Offset = "0x7976F00", VA = "0x187978100")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x6000044")]
			[Cpp2IlInjected.Address(RVA = "0x7979BB0", Offset = "0x79789B0", VA = "0x187979BB0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001E")]
		public RigidbodyConstraints FPMNJBFKPFN
		{
			[Cpp2IlInjected.Token(Token = "0x6000045")]
			[Cpp2IlInjected.Address(RVA = "0x7978730", Offset = "0x7977530", VA = "0x187978730")]
			get
			{
				return default(RigidbodyConstraints);
			}
			[Cpp2IlInjected.Token(Token = "0x6000046")]
			[Cpp2IlInjected.Address(RVA = "0x7979EC0", Offset = "0x7978CC0", VA = "0x187979EC0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001F")]
		public Vector3 OJLJFNKLGDO
		{
			[Cpp2IlInjected.Token(Token = "0x6000047")]
			[Cpp2IlInjected.Address(RVA = "0x7978EE0", Offset = "0x7977CE0", VA = "0x187978EE0")]
			get
			{
				return default(Vector3);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000020")]
		public Vector3 CECOMIABHGH
		{
			[Cpp2IlInjected.Token(Token = "0x6000048")]
			[Cpp2IlInjected.Address(RVA = "0x7978EE0", Offset = "0x7977CE0", VA = "0x187978EE0")]
			get
			{
				return default(Vector3);
			}
			[Cpp2IlInjected.Token(Token = "0x6000049")]
			[Cpp2IlInjected.Address(RVA = "0x797A640", Offset = "0x7979440", VA = "0x18797A640")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000021")]
		public float MCOIPKFBCAL
		{
			[Cpp2IlInjected.Token(Token = "0x600004A")]
			[Cpp2IlInjected.Address(RVA = "0x7978C20", Offset = "0x7977A20", VA = "0x187978C20")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x600004B")]
			[Cpp2IlInjected.Address(RVA = "0x797A160", Offset = "0x7978F60", VA = "0x18797A160")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000022")]
		public float AIDIOAMPODP
		{
			[Cpp2IlInjected.Token(Token = "0x600004C")]
			[Cpp2IlInjected.Address(RVA = "0x7979310", Offset = "0x7978110", VA = "0x187979310")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x600004D")]
			[Cpp2IlInjected.Address(RVA = "0x797A7F0", Offset = "0x79795F0", VA = "0x18797A7F0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000023")]
		public Quaternion FDBGGCMNGPP
		{
			[Cpp2IlInjected.Token(Token = "0x600004E")]
			[Cpp2IlInjected.Address(RVA = "0x7978FC0", Offset = "0x7977DC0", VA = "0x187978FC0")]
			get
			{
				return default(Quaternion);
			}
			[Cpp2IlInjected.Token(Token = "0x600004F")]
			[Cpp2IlInjected.Address(RVA = "0x797A3C0", Offset = "0x79791C0", VA = "0x18797A3C0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000024")]
		public Quaternion DCGJKAKNEMG
		{
			[Cpp2IlInjected.Token(Token = "0x6000050")]
			[Cpp2IlInjected.Address(RVA = "0x7979240", Offset = "0x7978040", VA = "0x187979240")]
			get
			{
				return default(Quaternion);
			}
			[Cpp2IlInjected.Token(Token = "0x6000051")]
			[Cpp2IlInjected.Address(RVA = "0x797A720", Offset = "0x7979520", VA = "0x18797A720")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000025")]
		public Vector3 JLIFAAGGGOG
		{
			[Cpp2IlInjected.Token(Token = "0x6000052")]
			[Cpp2IlInjected.Address(RVA = "0x7979090", Offset = "0x7977E90", VA = "0x187979090")]
			get
			{
				return default(Vector3);
			}
			[Cpp2IlInjected.Token(Token = "0x6000053")]
			[Cpp2IlInjected.Address(RVA = "0x797A490", Offset = "0x7979290", VA = "0x18797A490")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000026")]
		public Quaternion IGOJMAEFOKN
		{
			[Cpp2IlInjected.Token(Token = "0x6000054")]
			[Cpp2IlInjected.Address(RVA = "0x7979170", Offset = "0x7977F70", VA = "0x187979170")]
			get
			{
				return default(Quaternion);
			}
			[Cpp2IlInjected.Token(Token = "0x6000055")]
			[Cpp2IlInjected.Address(RVA = "0x797A570", Offset = "0x7979370", VA = "0x18797A570")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000027")]
		public Vector3 PHFLICDNCII
		{
			[Cpp2IlInjected.Token(Token = "0x6000056")]
			[Cpp2IlInjected.Address(RVA = "0x79793D0", Offset = "0x79781D0", VA = "0x1879793D0")]
			get
			{
				return default(Vector3);
			}
			[Cpp2IlInjected.Token(Token = "0x6000057")]
			[Cpp2IlInjected.Address(RVA = "0x797A8D0", Offset = "0x79796D0", VA = "0x18797A8D0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000028")]
		public Vector3 FOLDPAFFMOB
		{
			[Cpp2IlInjected.Token(Token = "0x6000058")]
			[Cpp2IlInjected.Address(RVA = "0x7978C80", Offset = "0x7977A80", VA = "0x187978C80")]
			get
			{
				return default(Vector3);
			}
			[Cpp2IlInjected.Token(Token = "0x6000059")]
			[Cpp2IlInjected.Address(RVA = "0x797A1D0", Offset = "0x7978FD0", VA = "0x18797A1D0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000029")]
		public Vector3 APIEHLLLAEO
		{
			[Cpp2IlInjected.Token(Token = "0x600005A")]
			[Cpp2IlInjected.Address(RVA = "0x79785F0", Offset = "0x79773F0", VA = "0x1879785F0")]
			get
			{
				return default(Vector3);
			}
			[Cpp2IlInjected.Token(Token = "0x600005B")]
			[Cpp2IlInjected.Address(RVA = "0x7979D70", Offset = "0x7978B70", VA = "0x187979D70")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002A")]
		public Vector3 HPDLDIEKLGI
		{
			[Cpp2IlInjected.Token(Token = "0x600005C")]
			[Cpp2IlInjected.Address(RVA = "0x7978A60", Offset = "0x7977860", VA = "0x187978A60")]
			get
			{
				return default(Vector3);
			}
			[Cpp2IlInjected.Token(Token = "0x600005D")]
			[Cpp2IlInjected.Address(RVA = "0x7979FA0", Offset = "0x7978DA0", VA = "0x187979FA0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002B")]
		public Vector3 EDOCJKBEENH
		{
			[Cpp2IlInjected.Token(Token = "0x600005E")]
			[Cpp2IlInjected.Address(RVA = "0x7978920", Offset = "0x7977720", VA = "0x187978920")]
			get
			{
				return default(Vector3);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002C")]
		public Quaternion BHKBJKMFMDA
		{
			[Cpp2IlInjected.Token(Token = "0x600005F")]
			[Cpp2IlInjected.Address(RVA = "0x7978850", Offset = "0x7977650", VA = "0x187978850")]
			get
			{
				return default(Quaternion);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002D")]
		public Vector3 BOMHNGHBECE
		{
			[Cpp2IlInjected.Token(Token = "0x6000061")]
			[Cpp2IlInjected.Address(RVA = "0x7979670", Offset = "0x7978470", VA = "0x187979670")]
			get
			{
				return default(Vector3);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002E")]
		public Vector3 FEDBPIKBMAO
		{
			[Cpp2IlInjected.Token(Token = "0x6000062")]
			[Cpp2IlInjected.Address(RVA = "0x7979590", Offset = "0x7978390", VA = "0x187979590")]
			get
			{
				return default(Vector3);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002F")]
		public bool PAOEEMLIJOB
		{
			[Cpp2IlInjected.Token(Token = "0x6000063")]
			[Cpp2IlInjected.Address(RVA = "0x7978A00", Offset = "0x7977800", VA = "0x187978A00")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000030")]
		public bool HJFKNLHGEHL
		{
			[Cpp2IlInjected.Token(Token = "0x6000064")]
			[Cpp2IlInjected.Address(RVA = "0x79784D0", Offset = "0x79772D0", VA = "0x1879784D0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000031")]
		public bool PDBINNACHHN
		{
			[Cpp2IlInjected.Token(Token = "0x6000065")]
			[Cpp2IlInjected.Address(RVA = "0x7977FE0", Offset = "0x7976DE0", VA = "0x187977FE0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000032")]
		public bool OKLFBLPCGMN
		{
			[Cpp2IlInjected.Token(Token = "0x6000066")]
			[Cpp2IlInjected.Address(RVA = "0x7977F80", Offset = "0x7976D80", VA = "0x187977F80")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000033")]
		public bool NGOKFAOAKNI
		{
			[Cpp2IlInjected.Token(Token = "0x6000067")]
			[Cpp2IlInjected.Address(RVA = "0x7977E60", Offset = "0x7976C60", VA = "0x187977E60")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000034")]
		public bool ALPBIEALKFK
		{
			[Cpp2IlInjected.Token(Token = "0x6000068")]
			[Cpp2IlInjected.Address(RVA = "0x79787F0", Offset = "0x79775F0", VA = "0x1879787F0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000035")]
		public bool FIMGNNJILII
		{
			[Cpp2IlInjected.Token(Token = "0x6000069")]
			[Cpp2IlInjected.Address(RVA = "0x20B0E10", Offset = "0x20AFC10", VA = "0x1820B0E10")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000001")]
		public event JFAIPABNDDB MECPHKEOEAL
		{
			[Cpp2IlInjected.Token(Token = "0x600000D")]
			[Cpp2IlInjected.Address(RVA = "0x7977D80", Offset = "0x7976B80", VA = "0x187977D80")]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x600000E")]
			[Cpp2IlInjected.Address(RVA = "0x79799F0", Offset = "0x79787F0", VA = "0x1879799F0")]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000002")]
		public event ANKIPNDCANO MKLDCIAADDP
		{
			[Cpp2IlInjected.Token(Token = "0x600000F")]
			[Cpp2IlInjected.Address(RVA = "0x7977AF0", Offset = "0x79768F0", VA = "0x187977AF0")]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000010")]
			[Cpp2IlInjected.Address(RVA = "0x7979750", Offset = "0x7978550", VA = "0x187979750")]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000003")]
		public event ANKIPNDCANO LEIJHKAEBAI
		{
			[Cpp2IlInjected.Token(Token = "0x6000011")]
			[Cpp2IlInjected.Address(RVA = "0x7977B50", Offset = "0x7976950", VA = "0x187977B50")]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000012")]
			[Cpp2IlInjected.Address(RVA = "0x79797C0", Offset = "0x79785C0", VA = "0x1879797C0")]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000004")]
		public event ANKIPNDCANO MJOHIHKODKD
		{
			[Cpp2IlInjected.Token(Token = "0x6000013")]
			[Cpp2IlInjected.Address(RVA = "0x7977CA0", Offset = "0x7976AA0", VA = "0x187977CA0")]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000014")]
			[Cpp2IlInjected.Address(RVA = "0x7979910", Offset = "0x7978710", VA = "0x187979910")]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000005")]
		public event Action<FMMANLJJECN, FMMANLJJECN> CPGMPPGCGAK
		{
			[Cpp2IlInjected.Token(Token = "0x6000015")]
			[Cpp2IlInjected.Address(RVA = "0x7977C30", Offset = "0x7976A30", VA = "0x187977C30")]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000016")]
			[Cpp2IlInjected.Address(RVA = "0x79798A0", Offset = "0x79786A0", VA = "0x1879798A0")]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000006")]
		public event ANKIPNDCANO IODFHMJOANE
		{
			[Cpp2IlInjected.Token(Token = "0x6000017")]
			[Cpp2IlInjected.Address(RVA = "0x7977D10", Offset = "0x7976B10", VA = "0x187977D10")]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000018")]
			[Cpp2IlInjected.Address(RVA = "0x7979980", Offset = "0x7978780", VA = "0x187979980")]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000007")]
		public event ANKIPNDCANO FDHGICKPHHB
		{
			[Cpp2IlInjected.Token(Token = "0x6000019")]
			[Cpp2IlInjected.Address(RVA = "0x7977DF0", Offset = "0x7976BF0", VA = "0x187977DF0")]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x600001A")]
			[Cpp2IlInjected.Address(RVA = "0x7979A60", Offset = "0x7978860", VA = "0x187979A60")]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000008")]
		public event ANKIPNDCANO HKDHMCAJDBJ
		{
			[Cpp2IlInjected.Token(Token = "0x600001B")]
			[Cpp2IlInjected.Address(RVA = "0x7977BC0", Offset = "0x79769C0", VA = "0x187977BC0")]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x600001C")]
			[Cpp2IlInjected.Address(RVA = "0x7979830", Offset = "0x7978630", VA = "0x187979830")]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x8F7B10", Offset = "0x8F6910", VA = "0x1808F7B10", Slot = "8")]
		private void CGEOIFCEOIE(BKMLAJCFPOO MNCBDJMAFIF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x7976A90", Offset = "0x7975890", VA = "0x187976A90")]
		internal void MJJJEAKIMIB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x7977810", Offset = "0x7976610", VA = "0x187977810")]
		[Conditional("DEBUG_BUILD")]
		[Conditional("UNITY_EDITOR")]
		public void TestOverrideUnityRigidbody(Rigidbody EABHCMANNGM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x7976470", Offset = "0x7975270", VA = "0x187976470")]
		public FHDFMCFBJMM GetChild(int KNCPCNBMDNF)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000060")]
		[Cpp2IlInjected.Address(RVA = "0x7977470", Offset = "0x7976270", VA = "0x187977470")]
		public void SetInertiaTensor((Quaternion rot, Vector3 moments) IEKPANIOKCJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006A")]
		[Cpp2IlInjected.Address(RVA = "0x7975F60", Offset = "0x7974D60", VA = "0x187975F60")]
		private void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006B")]
		[Cpp2IlInjected.Address(RVA = "0x7977700", Offset = "0x7976500", VA = "0x187977700")]
		protected void Start()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006C")]
		[Cpp2IlInjected.Address(RVA = "0x79763C0", Offset = "0x79751C0", VA = "0x1879763C0")]
		private BKMLAJCFPOO FAIMDIMCDDA()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600006D")]
		[Cpp2IlInjected.Address(RVA = "0x79761B0", Offset = "0x7974FB0", VA = "0x1879761B0")]
		private void EODJIAICOIO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006E")]
		[Cpp2IlInjected.Address(RVA = "0x7976C40", Offset = "0x7975A40", VA = "0x187976C40")]
		private void OnEnable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006F")]
		[Cpp2IlInjected.Address(RVA = "0x7976B80", Offset = "0x7975980", VA = "0x187976B80")]
		public void OnDisable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000070")]
		[Cpp2IlInjected.Address(RVA = "0x7976A90", Offset = "0x7975890", VA = "0x187976A90")]
		private void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000071")]
		[Cpp2IlInjected.Address(RVA = "0x7976BE0", Offset = "0x79759E0", VA = "0x187976BE0")]
		private void OnDrawGizmosSelected()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000072")]
		[Cpp2IlInjected.Address(RVA = "0x7976CA0", Offset = "0x7975AA0", VA = "0x187976CA0")]
		private void OnValidate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000073")]
		[Cpp2IlInjected.Address(RVA = "0x7975550", Offset = "0x7974350", VA = "0x187975550")]
		public void AddDoNotResetVelocityOnOwnershipChangeOverride(object HACFGBHNOCC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000074")]
		[Cpp2IlInjected.Address(RVA = "0x7976D00", Offset = "0x7975B00", VA = "0x187976D00")]
		public void RemoveDoNotResetVelocityOnOwnershipChangeOverride(object HACFGBHNOCC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000075")]
		[Cpp2IlInjected.Address(RVA = "0x7976150", Offset = "0x7974F50", VA = "0x187976150")]
		public void DisableCachedInertialPropertyOverride()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000076")]
		[Cpp2IlInjected.Address(RVA = "0x7976B20", Offset = "0x7975920", VA = "0x187976B20")]
		public void MarkCachedInertialParametersDirty()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000077")]
		[Cpp2IlInjected.Address(RVA = "0x79775D0", Offset = "0x79763D0", VA = "0x1879775D0")]
		public void SetParent(RigidbodyEx IPHILEOFJLB, bool CDNOMBACDJA = false)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000078")]
		[Cpp2IlInjected.Address(RVA = "0x7977010", Offset = "0x7975E10", VA = "0x187977010")]
		public void ResetLocalCenterOfMassToPrefabDefault()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000079")]
		[Cpp2IlInjected.Address(RVA = "0x7976720", Offset = "0x7975520", VA = "0x187976720")]
		public bool IsRigidbodyAncestor(RigidbodyEx BLIFNMNMLCG)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600007A")]
		[Cpp2IlInjected.Address(RVA = "0x7976820", Offset = "0x7975620", VA = "0x187976820")]
		public bool IsRigidbodyDescendant(RigidbodyEx AOGCBHGEFAB)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600007B")]
		[Cpp2IlInjected.Address(RVA = "0x79757C0", Offset = "0x79745C0", VA = "0x1879757C0")]
		public void AddInterpolationRestriction(object HACFGBHNOCC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007C")]
		[Cpp2IlInjected.Address(RVA = "0x7976D70", Offset = "0x7975B70", VA = "0x187976D70")]
		public void RemoveInterpolationRestriction(object HACFGBHNOCC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007D")]
		[Cpp2IlInjected.Address(RVA = "0x7975830", Offset = "0x7974630", VA = "0x187975830")]
		public void AddKinematic(object HACFGBHNOCC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007E")]
		[Cpp2IlInjected.Address(RVA = "0x7976DE0", Offset = "0x7975BE0", VA = "0x187976DE0")]
		public void RemoveKinematic(object HACFGBHNOCC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007F")]
		[Cpp2IlInjected.Address(RVA = "0x7977550", Offset = "0x7976350", VA = "0x187977550")]
		public void SetKinematic(object HACFGBHNOCC, bool AFBCKAHGIKH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000080")]
		[Cpp2IlInjected.Address(RVA = "0x7977370", Offset = "0x7976170", VA = "0x187977370")]
		public void SetDiscontinuousPositionAndRotation(Vector3 OHGAAEDJDPL, Quaternion LDPILEOMGMF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000081")]
		[Cpp2IlInjected.Address(RVA = "0x7977270", Offset = "0x7976070", VA = "0x187977270")]
		public void SetDiscontinuousLocalPositionAndLocalRotation(Vector3 ANBHGIAIIEJ, Quaternion OCGOOLKPBNF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000082")]
		[Cpp2IlInjected.Address(RVA = "0x7976610", Offset = "0x7975410", VA = "0x187976610")]
		public Vector3 GetConstrainedVelocity(Vector3 PHFLICDNCII)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x6000083")]
		[Cpp2IlInjected.Address(RVA = "0x7976500", Offset = "0x7975300", VA = "0x187976500")]
		public Vector3 GetConstrainedAngularVelocity(Vector3 APIEHLLLAEO)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x6000084")]
		[Cpp2IlInjected.Address(RVA = "0x79756D0", Offset = "0x79744D0", VA = "0x1879756D0")]
		public void AddForce(Vector3 MKKNPGPEIPF, ForceMode PBMLNEJDMIB = ForceMode.Force)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000085")]
		[Cpp2IlInjected.Address(RVA = "0x79755C0", Offset = "0x79743C0", VA = "0x1879755C0")]
		public void AddForceAtPosition(Vector3 MKKNPGPEIPF, Vector3 AKEODPFBHJE, ForceMode PBMLNEJDMIB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000086")]
		[Cpp2IlInjected.Address(RVA = "0x7975A00", Offset = "0x7974800", VA = "0x187975A00")]
		public void AddTorque(Vector3 FHOLONAELHO, ForceMode PBMLNEJDMIB = ForceMode.Force)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000087")]
		[Cpp2IlInjected.Address(RVA = "0x79758A0", Offset = "0x79746A0", VA = "0x1879758A0")]
		public void AddRelativeTorque(Vector3 FHOLONAELHO, ForceMode PBMLNEJDMIB = ForceMode.Force)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000088")]
		[Cpp2IlInjected.Address(RVA = "0x79778E0", Offset = "0x79766E0", VA = "0x1879778E0")]
		public Vector3 WorldToLocalVelocity(Vector3 DKHOBKICOML)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x6000089")]
		[Cpp2IlInjected.Address(RVA = "0x7976980", Offset = "0x7975780", VA = "0x187976980")]
		public Vector3 LocalToWorldVelocity(Vector3 FOLDPAFFMOB)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x600008A")]
		[Cpp2IlInjected.Address(RVA = "0x79760F0", Offset = "0x7974EF0", VA = "0x1879760F0")]
		public void ClearVelocity()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008B")]
		[Cpp2IlInjected.Address(RVA = "0x7976090", Offset = "0x7974E90", VA = "0x187976090")]
		public void ClearUnityRigidbodyVelocity()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008C")]
		[Cpp2IlInjected.Address(RVA = "0x7976030", Offset = "0x7974E30", VA = "0x187976030")]
		public void ClearLinearVelocity()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008D")]
		[Cpp2IlInjected.Address(RVA = "0x7975FD0", Offset = "0x7974DD0", VA = "0x187975FD0")]
		public void ClearAngularVelocity()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008E")]
		[Cpp2IlInjected.Address(RVA = "0x7977170", Offset = "0x7975F70", VA = "0x187977170")]
		public void ResetVelocityWorldSpace(Vector3 NKJFLEFCNNK, Vector3 KMOLFMJJEFF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008F")]
		[Cpp2IlInjected.Address(RVA = "0x7977070", Offset = "0x7975E70", VA = "0x187977070")]
		public void ResetVelocityLocalSpace(Vector3 PGPILCGHHEN, Vector3 HPDLDIEKLGI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000090")]
		[Cpp2IlInjected.Address(RVA = "0x7976F30", Offset = "0x7975D30", VA = "0x187976F30")]
		public void ResetLinearVelocityLocalSpace(Vector3 PGPILCGHHEN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000091")]
		[Cpp2IlInjected.Address(RVA = "0x7977710", Offset = "0x7976510", VA = "0x187977710")]
		public bool SweepTest(Vector3 GGAAGAFEPHJ, [Out] RaycastHit KCLINOMLMOA, float HKMCFNGLEFP)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000092")]
		[Cpp2IlInjected.Address(RVA = "0x7976920", Offset = "0x7975720", VA = "0x187976920")]
		public bool IsSleeping()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000093")]
		[Cpp2IlInjected.Address(RVA = "0x79776A0", Offset = "0x79764A0", VA = "0x1879776A0")]
		public void Sleep()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000094")]
		[Cpp2IlInjected.Address(RVA = "0x7977880", Offset = "0x7976680", VA = "0x187977880")]
		public void WakeUp()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000095")]
		[Cpp2IlInjected.Address(RVA = "0x7975990", Offset = "0x7974790", VA = "0x187975990")]
		public void AddShouldHaveUnityRigidbodyToken(object HACFGBHNOCC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000096")]
		[Cpp2IlInjected.Address(RVA = "0x7976E50", Offset = "0x7975C50", VA = "0x187976E50")]
		public void RemoveShouldHaveUnityRigidbodyToken(object HACFGBHNOCC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000097")]
		[Cpp2IlInjected.Address(RVA = "0x7975D90", Offset = "0x7974B90", VA = "0x187975D90")]
		public void ApplyForceVelocityChange(DLLHHLOAIHN JNKNJFCPKCP, Vector3 DENBFHHPJGH, float INBGKGNKFFB, float LHLMMNAMGFA = 8f, float KOOKFIHBGFH = 1f)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000098")]
		[Cpp2IlInjected.Address(RVA = "0x7975C90", Offset = "0x7974A90", VA = "0x187975C90")]
		public void ApplyAngularVelocityChange(PKECHOKBABG EBIBFBONINJ, Vector3 JPKNKMLFEDJ, float LNNCFJOFHBA = float.PositiveInfinity)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000099")]
		[Cpp2IlInjected.Address(RVA = "0x7975E50", Offset = "0x7974C50", VA = "0x187975E50")]
		[Obsolete("Deprecated. Still exists to support deprecated CV2 chips. Use ApplyAngularVelocityChange.")]
		public void ApplyTorqueAngularVelocityChangeDeprecated(PKECHOKBABG EBIBFBONINJ, Vector3 CKABIAOPKPM, float HDGLIBMICCI = 7f, float DPLEKOGCINM = 1f)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009A")]
		[Cpp2IlInjected.Address(RVA = "0x7975BC0", Offset = "0x79749C0", VA = "0x187975BC0")]
		public bool AllowedScaleChange(float GCBKKLKKPFG)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600009B")]
		[Cpp2IlInjected.Address(RVA = "0x7975AF0", Offset = "0x79748F0", VA = "0x187975AF0")]
		public void AddWorldSpaceVelocityInHierarchyParentOverride(RigidbodyEx LNDOFDMKLIE, object HACFGBHNOCC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009C")]
		[Cpp2IlInjected.Address(RVA = "0x7976EC0", Offset = "0x7975CC0", VA = "0x187976EC0")]
		public void RemoveWorldSpaceVelocityInHierarchyParentOverride(object HACFGBHNOCC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009D")]
		[Cpp2IlInjected.Address(RVA = "0x7977A80", Offset = "0x7976880", VA = "0x187977A80")]
		public RigidbodyEx()
		{
		}

		[SpecialName]
		[Cpp2IlInjected.Token(Token = "0x600009F")]
		[Cpp2IlInjected.Address(RVA = "0xA71E00", Offset = "0xA70C00", VA = "0x180A71E00", Slot = "4")]
		private GameObject FEAILEPDFHN()
		{
			return null;
		}

		[SpecialName]
		[Cpp2IlInjected.Token(Token = "0x60000A0")]
		[Cpp2IlInjected.Address(RVA = "0x9226D0", Offset = "0x9214D0", VA = "0x1809226D0", Slot = "9")]
		private bool DDBKHOBDKBO()
		{
			return default(bool);
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
internal static class MLMILKJDKGA
{
	[Cpp2IlInjected.Token(Token = "0x60000A1")]
	[Cpp2IlInjected.Address(RVA = "0x7972320", Offset = "0x7971120", VA = "0x187972320")]
	public static BKMLAJCFPOO ONFPGHDPKKM(this RigidbodyEx EDMNKJJOIJK)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
[RegisterService(typeof(ODBKIHNADLB), new string[] { })]
public class EBHMDOLIKPL : ODBKIHNADLB, PLOJOFMKFEM
{
	[Cpp2IlInjected.Token(Token = "0x4000011")]
	private static readonly IMOCAMGHNDM JBCGOBEIKAJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000012")]
	private MLFBOGPBFOD KILMFPPKPGG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000013")]
	private PMLHLBNHBOC BPGIOHMMDAI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000014")]
	private BBFDEFFCBPG NHDKBJDMLFJ;

	[Cpp2IlInjected.Token(Token = "0x17000036")]
	public PMLHLBNHBOC GFIGBBNEHIM
	{
		[Cpp2IlInjected.Token(Token = "0x60000A2")]
		[Cpp2IlInjected.Address(RVA = "0x8F4430", Offset = "0x8F3230", VA = "0x1808F4430", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000037")]
	public BBFDEFFCBPG JCPMALMDJCA
	{
		[Cpp2IlInjected.Token(Token = "0x60000A3")]
		[Cpp2IlInjected.Address(RVA = "0x8F7B20", Offset = "0x8F6920", VA = "0x1808F7B20", Slot = "5")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000A4")]
	[Cpp2IlInjected.Address(RVA = "0x7960AF0", Offset = "0x795F8F0", VA = "0x187960AF0", Slot = "7")]
	public void InitReferences(BFHPBCPPECP AGGPMDGGKLP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A5")]
	[Cpp2IlInjected.Address(RVA = "0x79609F0", Offset = "0x795F7F0", VA = "0x1879609F0", Slot = "6")]
	public BKMLAJCFPOO FIGMNIAKICK(RigidbodyEx EDMNKJJOIJK, HKDIAHPAMEO JOAPLPPIFPC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000A6")]
	[Cpp2IlInjected.Address(RVA = "0x8FE490", Offset = "0x8FD290", VA = "0x1808FE490")]
	public EBHMDOLIKPL()
	{
	}
}
namespace RecRoom
{
	[Cpp2IlInjected.Token(Token = "0x2000007")]
	public class PhysicsManager : SingletonMonoBehaviour<PhysicsManager>
	{
		[Cpp2IlInjected.Token(Token = "0x4000015")]
		public static GAMKKEJCIBM UpdateAfterFixedUpdateRan;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000016")]
		private int OJDCLODHCIK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x4000017")]
		private int IMHDJGBMENI;

		[Cpp2IlInjected.Token(Token = "0x60000A8")]
		[Cpp2IlInjected.Address(RVA = "0x79753B0", Offset = "0x79741B0", VA = "0x1879753B0")]
		protected void FixedUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A9")]
		[Cpp2IlInjected.Address(RVA = "0x79753F0", Offset = "0x79741F0", VA = "0x1879753F0")]
		protected void Update()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AA")]
		[Cpp2IlInjected.Address(RVA = "0x79753D0", Offset = "0x79741D0", VA = "0x1879753D0")]
		protected void LateUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AB")]
		[Cpp2IlInjected.Address(RVA = "0x8F6D40", Offset = "0x8F5B40", VA = "0x1808F6D40")]
		[Conditional("UNITY_ASSERTIONS")]
		public void AssertLateColliderPositionsNotYetUpdated([Optional] string KKBJAPCBOHH, [Optional] UnityEngine.Object MOBMLKIIAJP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AC")]
		[Cpp2IlInjected.Address(RVA = "0x8F6D40", Offset = "0x8F5B40", VA = "0x1808F6D40")]
		[Conditional("UNITY_ASSERTIONS")]
		public void AssertLateColliderPositionsAlreadyUpdated([Optional] string KKBJAPCBOHH, [Optional] UnityEngine.Object MOBMLKIIAJP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AD")]
		[Cpp2IlInjected.Address(RVA = "0x7975500", Offset = "0x7974300", VA = "0x187975500")]
		public PhysicsManager()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
public static class CBFGNJDIEPK
{
	[Cpp2IlInjected.Token(Token = "0x2000009")]
	private class BDJFDOJGPBA : OIIFFMGENDA, IDisposable
	{
		[Cpp2IlInjected.Token(Token = "0x60000B1")]
		[Cpp2IlInjected.Address(RVA = "0x8F6D40", Offset = "0x8F5B40", VA = "0x1808F6D40", Slot = "6")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B2")]
		[Cpp2IlInjected.Address(RVA = "0x9059E0", Offset = "0x9047E0", VA = "0x1809059E0", Slot = "4")]
		public Vector3 JJHEALINOGK()
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x60000B3")]
		[Cpp2IlInjected.Address(RVA = "0x9059E0", Offset = "0x9047E0", VA = "0x1809059E0", Slot = "5")]
		public Vector3 BLFAJILLKJA()
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x60000B4")]
		[Cpp2IlInjected.Address(RVA = "0x8FE490", Offset = "0x8FD290", VA = "0x1808FE490")]
		public BDJFDOJGPBA()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000038")]
	public static OIIFFMGENDA PAEFPEEANAB
	{
		[Cpp2IlInjected.Token(Token = "0x60000AF")]
		[Cpp2IlInjected.Address(RVA = "0x795F570", Offset = "0x795E370", VA = "0x18795F570")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
public interface MMJFFFMIADC
{
	[Cpp2IlInjected.Token(Token = "0x17000039")]
	CollisionDetectionMode PJOKPNNELFB
	{
		[Cpp2IlInjected.Token(Token = "0x60000B5")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
		[Cpp2IlInjected.Token(Token = "0x60000B6")]
		[Cpp2IlInjected.Address(Slot = "1")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x60000B7")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void NLNNABDBLFO();

	[Cpp2IlInjected.Token(Token = "0x60000B8")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void NGEBHFHKAOK(bool PAOEEMLIJOB);

	[Cpp2IlInjected.Token(Token = "0x60000B9")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void GCHPPHMOCHD(bool PAOEEMLIJOB);

	[Cpp2IlInjected.Token(Token = "0x60000BA")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void LPCBHBLKHJO(Rigidbody BFBNFNHBHPL);

	[Cpp2IlInjected.Token(Token = "0x60000BB")]
	[Cpp2IlInjected.Address(Slot = "6")]
	bool MPEAOKEEILP(Vector3 GGAAGAFEPHJ, [Out] RaycastHit KCLINOMLMOA, float HKMCFNGLEFP);
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
public interface CIGACFAOEEE : IDisposable, ILELCPFIBBF
{
	[Cpp2IlInjected.Token(Token = "0x1700003A")]
	CDPBBJLFOGJ LAFBBOHALEO
	{
		[Cpp2IlInjected.Token(Token = "0x60000BE")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
		[Cpp2IlInjected.Token(Token = "0x60000BF")]
		[Cpp2IlInjected.Address(Slot = "3")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x14000009")]
	event Action<FMMANLJJECN, FMMANLJJECN> CPGMPPGCGAK;

	[Cpp2IlInjected.Token(Token = "0x60000C0")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void NLNNABDBLFO();
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
[ServiceLifetime(Lifetime.Application)]
public interface BBFDEFFCBPG
{
	[Cpp2IlInjected.Token(Token = "0x60000C1")]
	[Cpp2IlInjected.Address(Slot = "0")]
	FKBLJPAJLHP EANPCNMGMCN(BKMLAJCFPOO MNCBDJMAFIF);

	[Cpp2IlInjected.Token(Token = "0x60000C2")]
	[Cpp2IlInjected.Address(Slot = "1")]
	EFAKGJHIOBO LLMEOPINNPH(BKMLAJCFPOO MNCBDJMAFIF);

	[Cpp2IlInjected.Token(Token = "0x60000C3")]
	[Cpp2IlInjected.Address(Slot = "2")]
	GENBFDOKDMJ NEEDELJPFJG(BKMLAJCFPOO MNCBDJMAFIF);

	[Cpp2IlInjected.Token(Token = "0x60000C4")]
	[Cpp2IlInjected.Address(Slot = "3")]
	MOAMEMFPAHE EGEAIEBINMO(BKMLAJCFPOO MNCBDJMAFIF);

	[Cpp2IlInjected.Token(Token = "0x60000C5")]
	[Cpp2IlInjected.Address(Slot = "4")]
	EPCLGGKOKDH PMDGIOLFCHG(BKMLAJCFPOO MNCBDJMAFIF);

	[Cpp2IlInjected.Token(Token = "0x60000C6")]
	[Cpp2IlInjected.Address(Slot = "5")]
	CIGACFAOEEE AAFCLNCPJGG(BKMLAJCFPOO MNCBDJMAFIF);

	[Cpp2IlInjected.Token(Token = "0x60000C7")]
	[Cpp2IlInjected.Address(Slot = "6")]
	LIIPPALMDAB KJMPCEIFBMH(BKMLAJCFPOO MNCBDJMAFIF);

	[Cpp2IlInjected.Token(Token = "0x60000C8")]
	[Cpp2IlInjected.Address(Slot = "7")]
	NOJNACJJDCN GNJIECPPEOA(BKMLAJCFPOO MNCBDJMAFIF);

	[Cpp2IlInjected.Token(Token = "0x60000C9")]
	[Cpp2IlInjected.Address(Slot = "8")]
	MMJFFFMIADC LFOHGPAFIFO(BKMLAJCFPOO MNCBDJMAFIF);

	[Cpp2IlInjected.Token(Token = "0x60000CA")]
	[Cpp2IlInjected.Address(Slot = "9")]
	NBPGLENHDHN CAOBDEEDIJH(BKMLAJCFPOO MNCBDJMAFIF);

	[Cpp2IlInjected.Token(Token = "0x60000CB")]
	[Cpp2IlInjected.Address(Slot = "10")]
	POLDBHKMHHJ DKAOHGPCNFM(BKMLAJCFPOO MNCBDJMAFIF, [In] HKDIAHPAMEO JOAPLPPIFPC);

	[Cpp2IlInjected.Token(Token = "0x60000CC")]
	[Cpp2IlInjected.Address(Slot = "11")]
	LDFDKFJIGHG FBFMJEJPNCG(BKMLAJCFPOO MNCBDJMAFIF, [In] HKDIAHPAMEO JOAPLPPIFPC);

	[Cpp2IlInjected.Token(Token = "0x60000CD")]
	[Cpp2IlInjected.Address(Slot = "12")]
	LPJPGCAEPHD HOLDGAMPGMH(BKMLAJCFPOO MNCBDJMAFIF, [In] HKDIAHPAMEO JOAPLPPIFPC);

	[Cpp2IlInjected.Token(Token = "0x60000CE")]
	[Cpp2IlInjected.Address(Slot = "13")]
	MHBMHJOFKAF EBKJHPPJNLI(BKMLAJCFPOO MNCBDJMAFIF, [In] HKDIAHPAMEO JOAPLPPIFPC);

	[Cpp2IlInjected.Token(Token = "0x60000CF")]
	[Cpp2IlInjected.Address(Slot = "14")]
	DJFBKMLCAJO JDAHPKIGDAC(BKMLAJCFPOO MNCBDJMAFIF, [In] HKDIAHPAMEO JOAPLPPIFPC);

	[Cpp2IlInjected.Token(Token = "0x60000D0")]
	[Cpp2IlInjected.Address(Slot = "15")]
	BKMLAJCFPOO FIGMNIAKICK(RigidbodyEx EDMNKJJOIJK, HKDIAHPAMEO JOAPLPPIFPC, ODBKIHNADLB HLDNIAJEGKP);
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
public interface NOJNACJJDCN
{
	[Cpp2IlInjected.Token(Token = "0x60000D1")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void PGLBLAGLHBK(Vector3 MKKNPGPEIPF, ForceMode PBMLNEJDMIB = ForceMode.Force);

	[Cpp2IlInjected.Token(Token = "0x60000D2")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void JGMDIHEFGOP(Vector3 MKKNPGPEIPF, Vector3 AKEODPFBHJE, ForceMode PBMLNEJDMIB);

	[Cpp2IlInjected.Token(Token = "0x60000D3")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void HKABICKGENB(Vector3 FHOLONAELHO, ForceMode PBMLNEJDMIB = ForceMode.Force);

	[Cpp2IlInjected.Token(Token = "0x60000D4")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void PMLDNMMBFDJ(Vector3 FHOLONAELHO, ForceMode PBMLNEJDMIB = ForceMode.Force);
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
public interface NBPGLENHDHN
{
	[Cpp2IlInjected.Token(Token = "0x1700003B")]
	bool HBLFKJDMPLJ
	{
		[Cpp2IlInjected.Token(Token = "0x60000D5")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
		[Cpp2IlInjected.Token(Token = "0x60000D6")]
		[Cpp2IlInjected.Address(Slot = "1")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x60000D7")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void LPCBHBLKHJO(Rigidbody BFBNFNHBHPL);

	[Cpp2IlInjected.Token(Token = "0x60000D8")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void OCMNAIOEAIB(Rigidbody BFBNFNHBHPL);
}
[Cpp2IlInjected.Token(Token = "0x200000F")]
public interface FKBLJPAJLHP : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x1700003C")]
	IReadOnlyList<BKMLAJCFPOO> OEIFFPONJNA
	{
		[Cpp2IlInjected.Token(Token = "0x60000EB")]
		[Cpp2IlInjected.Address(Slot = "18")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700003D")]
	BKMLAJCFPOO DIPIAJCGAGN
	{
		[Cpp2IlInjected.Token(Token = "0x60000EC")]
		[Cpp2IlInjected.Address(Slot = "19")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700003E")]
	BKMLAJCFPOO LCIGPFKHHMP
	{
		[Cpp2IlInjected.Token(Token = "0x60000ED")]
		[Cpp2IlInjected.Address(Slot = "20")]
		get;
		[Cpp2IlInjected.Token(Token = "0x60000EE")]
		[Cpp2IlInjected.Address(Slot = "21")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x1400000A")]
	event ANKIPNDCANO MKLDCIAADDP;

	[Cpp2IlInjected.Token(Token = "0x1400000B")]
	event ANKIPNDCANO LEIJHKAEBAI;

	[Cpp2IlInjected.Token(Token = "0x1400000C")]
	event JFAIPABNDDB FKKLGGOKJNO;

	[Cpp2IlInjected.Token(Token = "0x1400000D")]
	event Action GCKBGMNHICB;

	[Cpp2IlInjected.Token(Token = "0x1400000E")]
	event Action JJELANBMAFN;

	[Cpp2IlInjected.Token(Token = "0x1400000F")]
	event Action<BKMLAJCFPOO> NAKCGHNOLLM;

	[Cpp2IlInjected.Token(Token = "0x14000010")]
	event Action<BKMLAJCFPOO> POEAEOHHEEB;

	[Cpp2IlInjected.Token(Token = "0x14000011")]
	event Action GMIFAGCGHBJ;

	[Cpp2IlInjected.Token(Token = "0x14000012")]
	event Action<BKMLAJCFPOO> CGDEDGDEEFC;

	[Cpp2IlInjected.Token(Token = "0x60000EF")]
	[Cpp2IlInjected.Address(Slot = "22")]
	void ODEJGNHFANL(BKMLAJCFPOO LBOOKOKCBHL, bool CDNOMBACDJA = false);
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
public interface GENBFDOKDMJ
{
	[Cpp2IlInjected.Token(Token = "0x1700003F")]
	Vector3 DGPEONCCLJP
	{
		[Cpp2IlInjected.Token(Token = "0x60000F0")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000040")]
	Vector3 KJNCOIBLPBH
	{
		[Cpp2IlInjected.Token(Token = "0x60000F1")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x60000F2")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void BFDPOFDIFHP(BKMLAJCFPOO IFAMCPHMKIP, object HACFGBHNOCC);

	[Cpp2IlInjected.Token(Token = "0x60000F3")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void CEBLPEAMCFP(object HACFGBHNOCC);
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
public interface MHBMHJOFKAF
{
	[Cpp2IlInjected.Token(Token = "0x17000041")]
	Vector3 MCNHMKCPMCP
	{
		[Cpp2IlInjected.Token(Token = "0x60000F6")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
		[Cpp2IlInjected.Token(Token = "0x60000F7")]
		[Cpp2IlInjected.Address(Slot = "3")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000042")]
	Vector3 MDDJDOBAIIM
	{
		[Cpp2IlInjected.Token(Token = "0x60000F8")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000043")]
	float GBFCDAFMDLO
	{
		[Cpp2IlInjected.Token(Token = "0x60000F9")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000044")]
	float OKMBPDCAAGG
	{
		[Cpp2IlInjected.Token(Token = "0x60000FA")]
		[Cpp2IlInjected.Address(Slot = "6")]
		get;
		[Cpp2IlInjected.Token(Token = "0x60000FB")]
		[Cpp2IlInjected.Address(Slot = "7")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000045")]
	Vector3 MCDNADKMFKJ
	{
		[Cpp2IlInjected.Token(Token = "0x60000FC")]
		[Cpp2IlInjected.Address(Slot = "8")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000046")]
	Quaternion AIGDBJBCJDE
	{
		[Cpp2IlInjected.Token(Token = "0x60000FD")]
		[Cpp2IlInjected.Address(Slot = "9")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x14000013")]
	event ANKIPNDCANO KHNEOMEELGO;

	[Cpp2IlInjected.Token(Token = "0x60000FE")]
	[Cpp2IlInjected.Address(Slot = "10")]
	void ABCJBEHKOHN((Quaternion rot, Vector3 moments) IEKPANIOKCJ);

	[Cpp2IlInjected.Token(Token = "0x60000FF")]
	[Cpp2IlInjected.Address(Slot = "11")]
	void FAHHJFPOHIJ();

	[Cpp2IlInjected.Token(Token = "0x6000100")]
	[Cpp2IlInjected.Address(Slot = "12")]
	void EGIHCPCAFBE();

	[Cpp2IlInjected.Token(Token = "0x6000101")]
	[Cpp2IlInjected.Address(Slot = "13")]
	void FCBHEDAOLDB();

	[Cpp2IlInjected.Token(Token = "0x6000102")]
	[Cpp2IlInjected.Address(Slot = "14")]
	void LPCBHBLKHJO(Rigidbody BFBNFNHBHPL);

	[Cpp2IlInjected.Token(Token = "0x6000103")]
	[Cpp2IlInjected.Address(Slot = "15")]
	void OCMNAIOEAIB(Rigidbody BFBNFNHBHPL);

	[Cpp2IlInjected.Token(Token = "0x6000104")]
	[Cpp2IlInjected.Address(Slot = "16")]
	void GLCKBHAHEJI();
}
[Cpp2IlInjected.Token(Token = "0x2000012")]
public interface LPJPGCAEPHD
{
	[Cpp2IlInjected.Token(Token = "0x6000105")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void NLNNABDBLFO();

	[Cpp2IlInjected.Token(Token = "0x6000106")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void ICNLMLCJCII(object HACFGBHNOCC);

	[Cpp2IlInjected.Token(Token = "0x6000107")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void GFANLMAHHDC(object HACFGBHNOCC);

	[Cpp2IlInjected.Token(Token = "0x6000108")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void JAEBCPEJOAK(BKMLAJCFPOO EDMNKJJOIJK);

	[Cpp2IlInjected.Token(Token = "0x6000109")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void CDCEEAOPCFB(BKMLAJCFPOO EDMNKJJOIJK);

	[Cpp2IlInjected.Token(Token = "0x600010A")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void HHOFDIAHGEL();
}
[Cpp2IlInjected.Token(Token = "0x2000013")]
public interface LIIPPALMDAB
{
	[Cpp2IlInjected.Token(Token = "0x17000047")]
	bool JMMCPDFELOG
	{
		[Cpp2IlInjected.Token(Token = "0x600010D")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x14000014")]
	event ANKIPNDCANO EOCIGPOJEAJ;

	[Cpp2IlInjected.Token(Token = "0x600010E")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void NDNHLHKLAJO(object HACFGBHNOCC);

	[Cpp2IlInjected.Token(Token = "0x600010F")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void DHHHJHJJACF(object HACFGBHNOCC);

	[Cpp2IlInjected.Token(Token = "0x6000110")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void LFKMFFNIBNF(object HACFGBHNOCC, bool AFBCKAHGIKH);

	[Cpp2IlInjected.Token(Token = "0x6000111")]
	[Cpp2IlInjected.Address(Slot = "6")]
	void LPCBHBLKHJO(Rigidbody IDAFMFPGOAC);

	[Cpp2IlInjected.Token(Token = "0x6000112")]
	[Cpp2IlInjected.Address(Slot = "7")]
	void OCMNAIOEAIB(Rigidbody BFBNFNHBHPL);
}
[Cpp2IlInjected.Token(Token = "0x2000014")]
public interface LDFDKFJIGHG : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x17000048")]
	bool FIPIKFDPMLE
	{
		[Cpp2IlInjected.Token(Token = "0x6000115")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000049")]
	bool DDHKLPODPHG
	{
		[Cpp2IlInjected.Token(Token = "0x6000116")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x14000015")]
	event ANKIPNDCANO ALHCADIFMCB;

	[Cpp2IlInjected.Token(Token = "0x6000117")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void NLNNABDBLFO();

	[Cpp2IlInjected.Token(Token = "0x6000118")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void IOPBIMOFKHN(BKMLAJCFPOO IFAMCPHMKIP);

	[Cpp2IlInjected.Token(Token = "0x6000119")]
	[Cpp2IlInjected.Address(Slot = "6")]
	void NLBLLKCJHNE(BKMLAJCFPOO IFAMCPHMKIP);
}
[Cpp2IlInjected.Token(Token = "0x2000015")]
public interface DJFBKMLCAJO
{
	[Cpp2IlInjected.Token(Token = "0x1700004A")]
	bool NJLANIHBHFG
	{
		[Cpp2IlInjected.Token(Token = "0x600011A")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
		[Cpp2IlInjected.Token(Token = "0x600011B")]
		[Cpp2IlInjected.Address(Slot = "1")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x1700004B")]
	bool BKLJLLPLMOI
	{
		[Cpp2IlInjected.Token(Token = "0x600011C")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700004C")]
	RigidbodyConstraints AHGDGGBFJJC
	{
		[Cpp2IlInjected.Token(Token = "0x600011D")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
		[Cpp2IlInjected.Token(Token = "0x600011E")]
		[Cpp2IlInjected.Address(Slot = "4")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x600011F")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void LPCBHBLKHJO(Rigidbody BFBNFNHBHPL);

	[Cpp2IlInjected.Token(Token = "0x6000120")]
	[Cpp2IlInjected.Address(Slot = "6")]
	void OCMNAIOEAIB(Rigidbody BFBNFNHBHPL);
}
[Cpp2IlInjected.Token(Token = "0x2000016")]
public interface MOAMEMFPAHE
{
	[Cpp2IlInjected.Token(Token = "0x1700004D")]
	float DBFJKFPLEDB
	{
		[Cpp2IlInjected.Token(Token = "0x6000121")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
		[Cpp2IlInjected.Token(Token = "0x6000122")]
		[Cpp2IlInjected.Address(Slot = "1")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x1700004E")]
	float OMKMLLDNDHH
	{
		[Cpp2IlInjected.Token(Token = "0x6000123")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
		[Cpp2IlInjected.Token(Token = "0x6000124")]
		[Cpp2IlInjected.Address(Slot = "3")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x6000125")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void LPCBHBLKHJO(Rigidbody BFBNFNHBHPL);

	[Cpp2IlInjected.Token(Token = "0x6000126")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void OCMNAIOEAIB(Rigidbody BFBNFNHBHPL);
}
[Cpp2IlInjected.Token(Token = "0x2000017")]
public interface EPCLGGKOKDH
{
	[Cpp2IlInjected.Token(Token = "0x4000019")]
	static bool LCKFNBJPKJJ;

	[Cpp2IlInjected.Token(Token = "0x14000016")]
	event ANKIPNDCANO CKAOMBCKJPE;

	[Cpp2IlInjected.Token(Token = "0x6000129")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void NLNNABDBLFO();

	[Cpp2IlInjected.Token(Token = "0x600012A")]
	[Cpp2IlInjected.Address(Slot = "3")]
	bool ABCPKPFAHNI();

	[Cpp2IlInjected.Token(Token = "0x600012B")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void FFKDECLHCFA();

	[Cpp2IlInjected.Token(Token = "0x600012C")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void BFHIJDILBDB();

	[Cpp2IlInjected.Token(Token = "0x600012D")]
	[Cpp2IlInjected.Address(Slot = "6")]
	bool EMJIFDEHGCD();

	[Cpp2IlInjected.Token(Token = "0x600012E")]
	[Cpp2IlInjected.Address(Slot = "7")]
	bool HNOEAPKGKHM();

	[Cpp2IlInjected.Token(Token = "0x600012F")]
	[Cpp2IlInjected.Address(Slot = "8")]
	void OEDPDHEENEL(bool KCKMIPNLKFF);

	[Cpp2IlInjected.Token(Token = "0x6000130")]
	[Cpp2IlInjected.Address(Slot = "9")]
	void ACKEKMFONNI();
}
[Cpp2IlInjected.Token(Token = "0x2000018")]
public interface POLDBHKMHHJ
{
	[Cpp2IlInjected.Token(Token = "0x1700004F")]
	Rigidbody OKMLLKAPHNL
	{
		[Cpp2IlInjected.Token(Token = "0x6000131")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000050")]
	bool NCKKLLLKCDO
	{
		[Cpp2IlInjected.Token(Token = "0x6000133")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000132")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void NLNNABDBLFO();

	[Cpp2IlInjected.Token(Token = "0x6000134")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void DMCOGFFPGPE(object HACFGBHNOCC);

	[Cpp2IlInjected.Token(Token = "0x6000135")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void GNBBEKCJFMA(object HACFGBHNOCC);

	[Cpp2IlInjected.Token(Token = "0x6000136")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void OENJOKFMDDN();
}
[Cpp2IlInjected.Token(Token = "0x2000019")]
public interface EFAKGJHIOBO : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x17000051")]
	OIIFFMGENDA NDGKBOLHLFO
	{
		[Cpp2IlInjected.Token(Token = "0x6000137")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
		[Cpp2IlInjected.Token(Token = "0x6000138")]
		[Cpp2IlInjected.Address(Slot = "1")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000052")]
	PEHCDIDIDFL HADAHAKIAGP
	{
		[Cpp2IlInjected.Token(Token = "0x6000139")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
		[Cpp2IlInjected.Token(Token = "0x600013A")]
		[Cpp2IlInjected.Address(Slot = "3")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000053")]
	Vector3 LEFKCANEDPG
	{
		[Cpp2IlInjected.Token(Token = "0x600013B")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
		[Cpp2IlInjected.Token(Token = "0x600013C")]
		[Cpp2IlInjected.Address(Slot = "5")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000054")]
	Vector3 AMLMBHHAEJE
	{
		[Cpp2IlInjected.Token(Token = "0x600013D")]
		[Cpp2IlInjected.Address(Slot = "6")]
		get;
		[Cpp2IlInjected.Token(Token = "0x600013E")]
		[Cpp2IlInjected.Address(Slot = "7")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000055")]
	Vector3 KHNLNENPKFO
	{
		[Cpp2IlInjected.Token(Token = "0x600013F")]
		[Cpp2IlInjected.Address(Slot = "8")]
		get;
		[Cpp2IlInjected.Token(Token = "0x6000140")]
		[Cpp2IlInjected.Address(Slot = "9")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000056")]
	Vector3 GDFIBLLIEJO
	{
		[Cpp2IlInjected.Token(Token = "0x6000141")]
		[Cpp2IlInjected.Address(Slot = "10")]
		get;
		[Cpp2IlInjected.Token(Token = "0x6000142")]
		[Cpp2IlInjected.Address(Slot = "11")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000057")]
	float PGGIFJBJEHC
	{
		[Cpp2IlInjected.Token(Token = "0x6000143")]
		[Cpp2IlInjected.Address(Slot = "12")]
		get;
		[Cpp2IlInjected.Token(Token = "0x6000144")]
		[Cpp2IlInjected.Address(Slot = "13")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000058")]
	bool FFNKJNLOBKO
	{
		[Cpp2IlInjected.Token(Token = "0x6000145")]
		[Cpp2IlInjected.Address(Slot = "14")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000146")]
	[Cpp2IlInjected.Address(Slot = "15")]
	void NLNNABDBLFO();

	[Cpp2IlInjected.Token(Token = "0x6000147")]
	[Cpp2IlInjected.Address(Slot = "16")]
	void FLMEAHOIOLN(object HACFGBHNOCC);

	[Cpp2IlInjected.Token(Token = "0x6000148")]
	[Cpp2IlInjected.Address(Slot = "17")]
	void IIDMCFJEDDH(PKECHOKBABG EBIBFBONINJ, Vector3 JPKNKMLFEDJ, float LNNCFJOFHBA = float.PositiveInfinity);

	[Cpp2IlInjected.Token(Token = "0x6000149")]
	[Cpp2IlInjected.Address(Slot = "18")]
	void FHDDMCOIBHK(DLLHHLOAIHN JNKNJFCPKCP, Vector3 DENBFHHPJGH, float INBGKGNKFFB, float LHLMMNAMGFA = 8f, float KOOKFIHBGFH = 1f);

	[Cpp2IlInjected.Token(Token = "0x600014A")]
	[Cpp2IlInjected.Address(Slot = "19")]
	void GIPFFEIENKO(PKECHOKBABG EBIBFBONINJ, Vector3 CKABIAOPKPM, float HDGLIBMICCI = 7f, float DPLEKOGCINM = 1f);

	[Cpp2IlInjected.Token(Token = "0x600014B")]
	[Cpp2IlInjected.Address(Slot = "20")]
	void CFNHIHGNLJC();

	[Cpp2IlInjected.Token(Token = "0x600014C")]
	[Cpp2IlInjected.Address(Slot = "21")]
	void JOLLBIOJCBM();

	[Cpp2IlInjected.Token(Token = "0x600014D")]
	[Cpp2IlInjected.Address(Slot = "22")]
	void IALHFLNDCNP();

	[Cpp2IlInjected.Token(Token = "0x600014E")]
	[Cpp2IlInjected.Address(Slot = "23")]
	void ICNBDOGBKCC();

	[Cpp2IlInjected.Token(Token = "0x600014F")]
	[Cpp2IlInjected.Address(Slot = "24")]
	void LPCBHBLKHJO(Rigidbody BFBNFNHBHPL);

	[Cpp2IlInjected.Token(Token = "0x6000150")]
	[Cpp2IlInjected.Address(Slot = "25")]
	Vector3 DBDODPLBOAD(Vector3 PHFLICDNCII);

	[Cpp2IlInjected.Token(Token = "0x6000151")]
	[Cpp2IlInjected.Address(Slot = "26")]
	void PJINADGDCCI(object HACFGBHNOCC);

	[Cpp2IlInjected.Token(Token = "0x6000152")]
	[Cpp2IlInjected.Address(Slot = "27")]
	void MHOOOJMNAMI(Vector3 GJDKCHCMPKK);

	[Cpp2IlInjected.Token(Token = "0x6000153")]
	[Cpp2IlInjected.Address(Slot = "28")]
	void NKCPNGJPKJI(Vector3 PGPILCGHHEN, Vector3 HPDLDIEKLGI);

	[Cpp2IlInjected.Token(Token = "0x6000154")]
	[Cpp2IlInjected.Address(Slot = "29")]
	void DMPLLEHEHHJ(Vector3 NKJFLEFCNNK, Vector3 KMOLFMJJEFF);

	[Cpp2IlInjected.Token(Token = "0x6000155")]
	[Cpp2IlInjected.Address(Slot = "30")]
	Vector3 HBLCPBHIIDI(Vector3 FOLDPAFFMOB);

	[Cpp2IlInjected.Token(Token = "0x6000156")]
	[Cpp2IlInjected.Address(Slot = "31")]
	Vector3 NJLCIKCJKMD(Vector3 DKHOBKICOML);
}
[Cpp2IlInjected.Token(Token = "0x200001A")]
[ServiceLifetime(Lifetime.Application)]
public interface PMLHLBNHBOC
{
	[Cpp2IlInjected.Token(Token = "0x17000059")]
	bool KMFPCGGHCDG
	{
		[Cpp2IlInjected.Token(Token = "0x6000157")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000158")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void NHKAGPJPJBG(string LKNDCPLLKMB);

	[Cpp2IlInjected.Token(Token = "0x6000159")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void BFDJBNGNKEA(RigidbodyEx EDMNKJJOIJK, Action OOCJAOHFGJK);

	[Cpp2IlInjected.Token(Token = "0x600015A")]
	[Cpp2IlInjected.Address(Slot = "3")]
	HHOAEHJDIIK MCNFBHELNEP(int JJBDOJDAOKH);

	[Cpp2IlInjected.Token(Token = "0x600015B")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void HLKDHPDLHCO(Vector3 OCLGEFOEIEE, float CHCNKNDEFIL, Color EDAHAPFCLBP);
}
[Cpp2IlInjected.Token(Token = "0x200001B")]
[ServiceLifetime(Lifetime.Application)]
public interface ODBKIHNADLB
{
	[Cpp2IlInjected.Token(Token = "0x1700005A")]
	PMLHLBNHBOC GFIGBBNEHIM
	{
		[Cpp2IlInjected.Token(Token = "0x600015C")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700005B")]
	BBFDEFFCBPG JCPMALMDJCA
	{
		[Cpp2IlInjected.Token(Token = "0x600015D")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x600015E")]
	[Cpp2IlInjected.Address(Slot = "2")]
	BKMLAJCFPOO FIGMNIAKICK(RigidbodyEx EDMNKJJOIJK, HKDIAHPAMEO JOAPLPPIFPC);
}
[Cpp2IlInjected.Token(Token = "0x200001C")]
public class EPBNDOPLGGE : BKMLAJCFPOO, IDisposable, MHGKBNKKGDH
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400001A")]
	internal readonly ODBKIHNADLB HLDNIAJEGKP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400001B")]
	internal FKBLJPAJLHP ANPHJHHNLJF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400001C")]
	internal LPJPGCAEPHD NCJBLKNDOBE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400001D")]
	internal LDFDKFJIGHG BPIBHFOAGBN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400001E")]
	internal EFAKGJHIOBO PHFLICDNCII;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x400001F")]
	internal GENBFDOKDMJ FEDPFECKJFO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000020")]
	internal MHBMHJOFKAF JHNDNIOPBOB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000021")]
	internal MOAMEMFPAHE FJEHOPHPHKG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000022")]
	internal NBPGLENHDHN PCDKEGJCHKN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x4000023")]
	internal EPCLGGKOKDH LFNBKAAOFON;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x4000024")]
	internal CIGACFAOEEE GPGDNGHHHDK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x4000025")]
	internal LIIPPALMDAB GEECGMCIIAI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x4000026")]
	internal NOJNACJJDCN MKKNPGPEIPF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
	[Cpp2IlInjected.Token(Token = "0x4000027")]
	internal DJFBKMLCAJO BPKBCLFBKGP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x4000028")]
	internal POLDBHKMHHJ BFBNFNHBHPL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
	[Cpp2IlInjected.Token(Token = "0x4000029")]
	internal MMJFFFMIADC IJEIMLHGKJC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
	[Cpp2IlInjected.Token(Token = "0x400002A")]
	internal IDisposable OCJNOOGCLPI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
	[Cpp2IlInjected.Token(Token = "0x400002B")]
	private bool LFIKFKOLJIG;

	[Cpp2IlInjected.Token(Token = "0x1700005C")]
	public ODHMICMEHJH PCOIIKCHBNF
	{
		[Cpp2IlInjected.Token(Token = "0x600015F")]
		[Cpp2IlInjected.Address(RVA = "0x8F6D50", Offset = "0x8F5B50", VA = "0x1808F6D50", Slot = "22")]
		get
		{
			return default(ODHMICMEHJH);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700005D")]
	public FHDFMCFBJMM GPCHJNFJJDG
	{
		[Cpp2IlInjected.Token(Token = "0x6000160")]
		[Cpp2IlInjected.Address(RVA = "0xB9BD70", Offset = "0xB9AB70", VA = "0x180B9BD70", Slot = "24")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000161")]
		[Cpp2IlInjected.Address(RVA = "0xCFF660", Offset = "0xCFE460", VA = "0x180CFF660")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700005E")]
	public GameObject JEKAHIGLEHM
	{
		[Cpp2IlInjected.Token(Token = "0x6000162")]
		[Cpp2IlInjected.Address(RVA = "0x904730", Offset = "0x903530", VA = "0x180904730", Slot = "25")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000163")]
		[Cpp2IlInjected.Address(RVA = "0x904790", Offset = "0x903590", VA = "0x180904790")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700005F")]
	public Transform HHEFOFLOCNG
	{
		[Cpp2IlInjected.Token(Token = "0x6000164")]
		[Cpp2IlInjected.Address(RVA = "0xAD87F0", Offset = "0xAD75F0", VA = "0x180AD87F0", Slot = "26")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000165")]
		[Cpp2IlInjected.Address(RVA = "0xD01130", Offset = "0xCFFF30", VA = "0x180D01130")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000060")]
	public Rigidbody OKMLLKAPHNL
	{
		[Cpp2IlInjected.Token(Token = "0x6000166")]
		[Cpp2IlInjected.Address(RVA = "0x7961AC0", Offset = "0x79608C0", VA = "0x187961AC0", Slot = "23")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000061")]
	public BKMLAJCFPOO LCIGPFKHHMP
	{
		[Cpp2IlInjected.Token(Token = "0x6000177")]
		[Cpp2IlInjected.Address(RVA = "0x79623B0", Offset = "0x79611B0", VA = "0x1879623B0", Slot = "27")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000178")]
		[Cpp2IlInjected.Address(RVA = "0x7966DF0", Offset = "0x7965BF0", VA = "0x187966DF0", Slot = "28")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000062")]
	public int ALNDPLKKMOO
	{
		[Cpp2IlInjected.Token(Token = "0x6000179")]
		[Cpp2IlInjected.Address(RVA = "0x79635B0", Offset = "0x79623B0", VA = "0x1879635B0", Slot = "31")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000063")]
	public BKMLAJCFPOO DIPIAJCGAGN
	{
		[Cpp2IlInjected.Token(Token = "0x600017B")]
		[Cpp2IlInjected.Address(RVA = "0x7962590", Offset = "0x7961390", VA = "0x187962590", Slot = "29")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000064")]
	public bool NKAJLEECCPJ
	{
		[Cpp2IlInjected.Token(Token = "0x600017C")]
		[Cpp2IlInjected.Address(RVA = "0x7962400", Offset = "0x7961200", VA = "0x187962400", Slot = "32")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000065")]
	public bool FIPIKFDPMLE
	{
		[Cpp2IlInjected.Token(Token = "0x6000180")]
		[Cpp2IlInjected.Address(RVA = "0x7964DD0", Offset = "0x7963BD0", VA = "0x187964DD0", Slot = "33")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000066")]
	public bool DDHKLPODPHG
	{
		[Cpp2IlInjected.Token(Token = "0x6000181")]
		[Cpp2IlInjected.Address(RVA = "0x79673D0", Offset = "0x79661D0", VA = "0x1879673D0", Slot = "34")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000067")]
	public OIIFFMGENDA NDGKBOLHLFO
	{
		[Cpp2IlInjected.Token(Token = "0x6000182")]
		[Cpp2IlInjected.Address(RVA = "0x7963F20", Offset = "0x7962D20", VA = "0x187963F20", Slot = "35")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000183")]
		[Cpp2IlInjected.Address(RVA = "0x7966750", Offset = "0x7965550", VA = "0x187966750", Slot = "36")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000068")]
	public PEHCDIDIDFL HADAHAKIAGP
	{
		[Cpp2IlInjected.Token(Token = "0x6000184")]
		[Cpp2IlInjected.Address(RVA = "0x7966EC0", Offset = "0x7965CC0", VA = "0x187966EC0", Slot = "37")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000185")]
		[Cpp2IlInjected.Address(RVA = "0x79655E0", Offset = "0x79643E0", VA = "0x1879655E0", Slot = "38")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000069")]
	public float PGGIFJBJEHC
	{
		[Cpp2IlInjected.Token(Token = "0x6000186")]
		[Cpp2IlInjected.Address(RVA = "0x7965C50", Offset = "0x7964A50", VA = "0x187965C50", Slot = "39")]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x6000187")]
		[Cpp2IlInjected.Address(RVA = "0x7962E90", Offset = "0x7961C90", VA = "0x187962E90", Slot = "40")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700006A")]
	public Vector3 AMLMBHHAEJE
	{
		[Cpp2IlInjected.Token(Token = "0x6000188")]
		[Cpp2IlInjected.Address(RVA = "0x7963D10", Offset = "0x7962B10", VA = "0x187963D10", Slot = "41")]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x6000189")]
		[Cpp2IlInjected.Address(RVA = "0x79640F0", Offset = "0x7962EF0", VA = "0x1879640F0", Slot = "42")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700006B")]
	public Vector3 GDFIBLLIEJO
	{
		[Cpp2IlInjected.Token(Token = "0x600018A")]
		[Cpp2IlInjected.Address(RVA = "0x79624B0", Offset = "0x79612B0", VA = "0x1879624B0", Slot = "43")]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x600018B")]
		[Cpp2IlInjected.Address(RVA = "0x7961D10", Offset = "0x7960B10", VA = "0x187961D10", Slot = "44")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700006C")]
	public Vector3 LEFKCANEDPG
	{
		[Cpp2IlInjected.Token(Token = "0x600018C")]
		[Cpp2IlInjected.Address(RVA = "0x7962820", Offset = "0x7961620", VA = "0x187962820", Slot = "45")]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x600018D")]
		[Cpp2IlInjected.Address(RVA = "0x7967620", Offset = "0x7966420", VA = "0x187967620", Slot = "46")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700006D")]
	public Vector3 KHNLNENPKFO
	{
		[Cpp2IlInjected.Token(Token = "0x600018E")]
		[Cpp2IlInjected.Address(RVA = "0x7964A60", Offset = "0x7963860", VA = "0x187964A60", Slot = "47")]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x600018F")]
		[Cpp2IlInjected.Address(RVA = "0x79615D0", Offset = "0x79603D0", VA = "0x1879615D0", Slot = "48")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700006E")]
	public bool PDBINNACHHN
	{
		[Cpp2IlInjected.Token(Token = "0x6000190")]
		[Cpp2IlInjected.Address(RVA = "0x7963B30", Offset = "0x7962930", VA = "0x187963B30", Slot = "49")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700006F")]
	public bool OKLFBLPCGMN
	{
		[Cpp2IlInjected.Token(Token = "0x6000191")]
		[Cpp2IlInjected.Address(RVA = "0x7961470", Offset = "0x7960270", VA = "0x187961470", Slot = "50")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000070")]
	public bool NGOKFAOAKNI
	{
		[Cpp2IlInjected.Token(Token = "0x6000192")]
		[Cpp2IlInjected.Address(RVA = "0x7963140", Offset = "0x7961F40", VA = "0x187963140", Slot = "51")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000071")]
	public bool FFNKJNLOBKO
	{
		[Cpp2IlInjected.Token(Token = "0x6000193")]
		[Cpp2IlInjected.Address(RVA = "0x7963520", Offset = "0x7962320", VA = "0x187963520", Slot = "52")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000072")]
	public Vector3 DGPEONCCLJP
	{
		[Cpp2IlInjected.Token(Token = "0x60001A4")]
		[Cpp2IlInjected.Address(RVA = "0x79678C0", Offset = "0x79666C0", VA = "0x1879678C0", Slot = "53")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000073")]
	public Vector3 KJNCOIBLPBH
	{
		[Cpp2IlInjected.Token(Token = "0x60001A5")]
		[Cpp2IlInjected.Address(RVA = "0x7961DF0", Offset = "0x7960BF0", VA = "0x187961DF0", Slot = "54")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000074")]
	public Vector3 MCNHMKCPMCP
	{
		[Cpp2IlInjected.Token(Token = "0x60001AA")]
		[Cpp2IlInjected.Address(RVA = "0x7965A80", Offset = "0x7964880", VA = "0x187965A80", Slot = "55")]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x60001AB")]
		[Cpp2IlInjected.Address(RVA = "0x79626E0", Offset = "0x79614E0", VA = "0x1879626E0", Slot = "56")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000075")]
	public Vector3 MDDJDOBAIIM
	{
		[Cpp2IlInjected.Token(Token = "0x60001AC")]
		[Cpp2IlInjected.Address(RVA = "0x7962D60", Offset = "0x7961B60", VA = "0x187962D60", Slot = "57")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000076")]
	public float GBFCDAFMDLO
	{
		[Cpp2IlInjected.Token(Token = "0x60001AD")]
		[Cpp2IlInjected.Address(RVA = "0x7961960", Offset = "0x7960760", VA = "0x187961960", Slot = "58")]
		get
		{
			return default(float);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000077")]
	public float OKMBPDCAAGG
	{
		[Cpp2IlInjected.Token(Token = "0x60001AE")]
		[Cpp2IlInjected.Address(RVA = "0x7965450", Offset = "0x7964250", VA = "0x187965450", Slot = "59")]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x60001AF")]
		[Cpp2IlInjected.Address(RVA = "0x79614D0", Offset = "0x79602D0", VA = "0x1879614D0", Slot = "60")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000078")]
	public Vector3 MCDNADKMFKJ
	{
		[Cpp2IlInjected.Token(Token = "0x60001B0")]
		[Cpp2IlInjected.Address(RVA = "0x7962B60", Offset = "0x7961960", VA = "0x187962B60", Slot = "61")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000079")]
	public Quaternion AIGDBJBCJDE
	{
		[Cpp2IlInjected.Token(Token = "0x60001B1")]
		[Cpp2IlInjected.Address(RVA = "0x79665C0", Offset = "0x79653C0", VA = "0x1879665C0", Slot = "62")]
		get
		{
			return default(Quaternion);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700007A")]
	public float DBFJKFPLEDB
	{
		[Cpp2IlInjected.Token(Token = "0x60001B6")]
		[Cpp2IlInjected.Address(RVA = "0x79636E0", Offset = "0x79624E0", VA = "0x1879636E0", Slot = "64")]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x60001B7")]
		[Cpp2IlInjected.Address(RVA = "0x79646C0", Offset = "0x79634C0", VA = "0x1879646C0", Slot = "65")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700007B")]
	public float OMKMLLDNDHH
	{
		[Cpp2IlInjected.Token(Token = "0x60001B8")]
		[Cpp2IlInjected.Address(RVA = "0x7963050", Offset = "0x7961E50", VA = "0x187963050", Slot = "66")]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x60001B9")]
		[Cpp2IlInjected.Address(RVA = "0x79641D0", Offset = "0x7962FD0", VA = "0x1879641D0", Slot = "67")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700007C")]
	public bool HBLFKJDMPLJ
	{
		[Cpp2IlInjected.Token(Token = "0x60001BA")]
		[Cpp2IlInjected.Address(RVA = "0x7962EF0", Offset = "0x7961CF0", VA = "0x187962EF0", Slot = "68")]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x60001BB")]
		[Cpp2IlInjected.Address(RVA = "0x7961CB0", Offset = "0x7960AB0", VA = "0x187961CB0", Slot = "69")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700007D")]
	public CDPBBJLFOGJ LAFBBOHALEO
	{
		[Cpp2IlInjected.Token(Token = "0x60001C3")]
		[Cpp2IlInjected.Address(RVA = "0x7966000", Offset = "0x7964E00", VA = "0x187966000", Slot = "70")]
		get
		{
			return default(CDPBBJLFOGJ);
		}
		[Cpp2IlInjected.Token(Token = "0x60001C4")]
		[Cpp2IlInjected.Address(RVA = "0x7962F40", Offset = "0x7961D40", VA = "0x187962F40", Slot = "71")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700007E")]
	public bool JMMCPDFELOG
	{
		[Cpp2IlInjected.Token(Token = "0x60001C7")]
		[Cpp2IlInjected.Address(RVA = "0x7961810", Offset = "0x7960610", VA = "0x187961810", Slot = "72")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700007F")]
	public Transform CAKBGADMKLG
	{
		[Cpp2IlInjected.Token(Token = "0x60001CD")]
		[Cpp2IlInjected.Address(RVA = "0xAD87F0", Offset = "0xAD75F0", VA = "0x180AD87F0", Slot = "73")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000080")]
	public Vector3 CLLCLIPNFMJ
	{
		[Cpp2IlInjected.Token(Token = "0x60001CE")]
		[Cpp2IlInjected.Address(RVA = "0x7966350", Offset = "0x7965150", VA = "0x187966350", Slot = "74")]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x60001CF")]
		[Cpp2IlInjected.Address(RVA = "0x7963B80", Offset = "0x7962980", VA = "0x187963B80", Slot = "75")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000081")]
	public float DFEHGEIADFB
	{
		[Cpp2IlInjected.Token(Token = "0x60001D0")]
		[Cpp2IlInjected.Address(RVA = "0x7962D50", Offset = "0x7961B50", VA = "0x187962D50", Slot = "76")]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x60001D1")]
		[Cpp2IlInjected.Address(RVA = "0x7964CB0", Offset = "0x7963AB0", VA = "0x187964CB0", Slot = "77")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000082")]
	public float CPHALJCMONF
	{
		[Cpp2IlInjected.Token(Token = "0x60001D2")]
		[Cpp2IlInjected.Address(RVA = "0x7962A50", Offset = "0x7961850", VA = "0x187962A50", Slot = "78")]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x60001D3")]
		[Cpp2IlInjected.Address(RVA = "0x7967240", Offset = "0x7966040", VA = "0x187967240", Slot = "79")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000083")]
	public Quaternion PIAIFHGNFML
	{
		[Cpp2IlInjected.Token(Token = "0x60001D4")]
		[Cpp2IlInjected.Address(RVA = "0x7961770", Offset = "0x7960570", VA = "0x187961770", Slot = "80")]
		get
		{
			return default(Quaternion);
		}
		[Cpp2IlInjected.Token(Token = "0x60001D5")]
		[Cpp2IlInjected.Address(RVA = "0x7965500", Offset = "0x7964300", VA = "0x187965500", Slot = "81")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000084")]
	public Vector3 CIIGPNLPGEP
	{
		[Cpp2IlInjected.Token(Token = "0x60001D6")]
		[Cpp2IlInjected.Address(RVA = "0x7967320", Offset = "0x7966120", VA = "0x187967320", Slot = "82")]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x60001D7")]
		[Cpp2IlInjected.Address(RVA = "0x79660B0", Offset = "0x7964EB0", VA = "0x1879660B0", Slot = "83")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000085")]
	public Quaternion FDIJLBLBDEG
	{
		[Cpp2IlInjected.Token(Token = "0x60001D8")]
		[Cpp2IlInjected.Address(RVA = "0x7963570", Offset = "0x7962370", VA = "0x187963570", Slot = "84")]
		get
		{
			return default(Quaternion);
		}
		[Cpp2IlInjected.Token(Token = "0x60001D9")]
		[Cpp2IlInjected.Address(RVA = "0x7965640", Offset = "0x7964440", VA = "0x187965640", Slot = "85")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000086")]
	public RigidbodyConstraints AHGDGGBFJJC
	{
		[Cpp2IlInjected.Token(Token = "0x60001DD")]
		[Cpp2IlInjected.Address(RVA = "0x7961580", Offset = "0x7960380", VA = "0x187961580", Slot = "86")]
		get
		{
			return default(RigidbodyConstraints);
		}
		[Cpp2IlInjected.Token(Token = "0x60001DE")]
		[Cpp2IlInjected.Address(RVA = "0x7963F70", Offset = "0x7962D70", VA = "0x187963F70", Slot = "87")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000087")]
	public bool NJLANIHBHFG
	{
		[Cpp2IlInjected.Token(Token = "0x60001DF")]
		[Cpp2IlInjected.Address(RVA = "0x79662A0", Offset = "0x79650A0", VA = "0x1879662A0", Slot = "88")]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x60001E0")]
		[Cpp2IlInjected.Address(RVA = "0x7964930", Offset = "0x7963730", VA = "0x187964930", Slot = "89")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000088")]
	public CollisionDetectionMode PJOKPNNELFB
	{
		[Cpp2IlInjected.Token(Token = "0x60001E9")]
		[Cpp2IlInjected.Address(RVA = "0x7961530", Offset = "0x7960330", VA = "0x187961530", Slot = "90")]
		get
		{
			return default(CollisionDetectionMode);
		}
		[Cpp2IlInjected.Token(Token = "0x60001EA")]
		[Cpp2IlInjected.Address(RVA = "0x79648D0", Offset = "0x79636D0", VA = "0x1879648D0", Slot = "91")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000089")]
	public bool EGGFDCIMFFJ
	{
		[Cpp2IlInjected.Token(Token = "0x60001EC")]
		[Cpp2IlInjected.Address(RVA = "0x79638F0", Offset = "0x79626F0", VA = "0x1879638F0", Slot = "141")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700008A")]
	public bool HJFKNLHGEHL
	{
		[Cpp2IlInjected.Token(Token = "0x60001ED")]
		[Cpp2IlInjected.Address(RVA = "0x7961ED0", Offset = "0x7960CD0", VA = "0x187961ED0", Slot = "92")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000017")]
	public event ANKIPNDCANO MKLDCIAADDP
	{
		[Cpp2IlInjected.Token(Token = "0x6000171")]
		[Cpp2IlInjected.Address(RVA = "0x7962C40", Offset = "0x7961A40", VA = "0x187962C40", Slot = "4")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000172")]
		[Cpp2IlInjected.Address(RVA = "0x79654A0", Offset = "0x79642A0", VA = "0x1879654A0", Slot = "5")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000018")]
	public event ANKIPNDCANO LEIJHKAEBAI
	{
		[Cpp2IlInjected.Token(Token = "0x6000173")]
		[Cpp2IlInjected.Address(RVA = "0x7964D20", Offset = "0x7963B20", VA = "0x187964D20", Slot = "6")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000174")]
		[Cpp2IlInjected.Address(RVA = "0x79666F0", Offset = "0x79654F0", VA = "0x1879666F0", Slot = "7")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000019")]
	public event JFAIPABNDDB FKKLGGOKJNO
	{
		[Cpp2IlInjected.Token(Token = "0x6000175")]
		[Cpp2IlInjected.Address(RVA = "0x7966050", Offset = "0x7964E50", VA = "0x187966050", Slot = "18")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000176")]
		[Cpp2IlInjected.Address(RVA = "0x7964090", Offset = "0x7962E90", VA = "0x187964090", Slot = "19")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400001A")]
	public event ANKIPNDCANO ALHCADIFMCB
	{
		[Cpp2IlInjected.Token(Token = "0x600017E")]
		[Cpp2IlInjected.Address(RVA = "0x79662F0", Offset = "0x79650F0", VA = "0x1879662F0", Slot = "8")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600017F")]
		[Cpp2IlInjected.Address(RVA = "0x79620B0", Offset = "0x7960EB0", VA = "0x1879620B0", Slot = "9")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400001B")]
	public event ANKIPNDCANO MJOHIHKODKD
	{
		[Cpp2IlInjected.Token(Token = "0x60001A8")]
		[Cpp2IlInjected.Address(RVA = "0x7965BF0", Offset = "0x79649F0", VA = "0x187965BF0", Slot = "14")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60001A9")]
		[Cpp2IlInjected.Address(RVA = "0x7964C50", Offset = "0x7963A50", VA = "0x187964C50", Slot = "15")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400001C")]
	public event ANKIPNDCANO CKAOMBCKJPE
	{
		[Cpp2IlInjected.Token(Token = "0x60001BC")]
		[Cpp2IlInjected.Address(RVA = "0x7961710", Offset = "0x7960510", VA = "0x187961710", Slot = "16")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60001BD")]
		[Cpp2IlInjected.Address(RVA = "0x7963400", Offset = "0x7962200", VA = "0x187963400", Slot = "17")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400001D")]
	public event Action<FMMANLJJECN, FMMANLJJECN> CPGMPPGCGAK
	{
		[Cpp2IlInjected.Token(Token = "0x60001C1")]
		[Cpp2IlInjected.Address(RVA = "0x79653F0", Offset = "0x79641F0", VA = "0x1879653F0", Slot = "20")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60001C2")]
		[Cpp2IlInjected.Address(RVA = "0x7966690", Offset = "0x7965490", VA = "0x187966690", Slot = "21")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400001E")]
	public event ANKIPNDCANO EOCIGPOJEAJ
	{
		[Cpp2IlInjected.Token(Token = "0x60001C5")]
		[Cpp2IlInjected.Address(RVA = "0x7963680", Offset = "0x7962480", VA = "0x187963680", Slot = "12")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60001C6")]
		[Cpp2IlInjected.Address(RVA = "0x7966460", Offset = "0x7965260", VA = "0x187966460", Slot = "13")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400001F")]
	public event ANKIPNDCANO HKDHMCAJDBJ
	{
		[Cpp2IlInjected.Token(Token = "0x60001CB")]
		[Cpp2IlInjected.Address(RVA = "0x7966F10", Offset = "0x7965D10", VA = "0x187966F10", Slot = "10")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60001CC")]
		[Cpp2IlInjected.Address(RVA = "0x7962CA0", Offset = "0x7961AA0", VA = "0x187962CA0", Slot = "11")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000167")]
	[Cpp2IlInjected.Address(RVA = "0x79679D0", Offset = "0x79667D0", VA = "0x1879679D0")]
	public EPBNDOPLGGE(GameObject IHNPMPCJPIK, RigidbodyEx OPBCLMGMDFP, ODBKIHNADLB HLDNIAJEGKP, [In] HKDIAHPAMEO JOAPLPPIFPC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000168")]
	[Cpp2IlInjected.Address(RVA = "0x79642D0", Offset = "0x79630D0", VA = "0x1879642D0", Slot = "139")]
	protected virtual void IHPKHHKPHJI(ODBKIHNADLB HLDNIAJEGKP, HKDIAHPAMEO JOAPLPPIFPC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000169")]
	[Cpp2IlInjected.Address(RVA = "0x7962A60", Offset = "0x7961860", VA = "0x187962A60", Slot = "140")]
	public virtual void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600016A")]
	[Cpp2IlInjected.Address(RVA = "0x7966BE0", Offset = "0x79659E0", VA = "0x187966BE0", Slot = "93")]
	public void NLNNABDBLFO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600016B")]
	[Cpp2IlInjected.Address(RVA = "0x7965B60", Offset = "0x7964960", VA = "0x187965B60", Slot = "94")]
	public void LKOAEPLGAFF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600016C")]
	[Cpp2IlInjected.Address(RVA = "0x7966400", Offset = "0x7965200", VA = "0x187966400", Slot = "95")]
	public void MNDLCNDCMOO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600016D")]
	[Cpp2IlInjected.Address(RVA = "0x7965A60", Offset = "0x7964860", VA = "0x187965A60", Slot = "96")]
	public void LIAJGFPGOFL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600016E")]
	[Cpp2IlInjected.Address(RVA = "0x7966FC0", Offset = "0x7965DC0", VA = "0x187966FC0")]
	private void OEDPDHEENEL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600016F")]
	[Cpp2IlInjected.Address(RVA = "0x79668A0", Offset = "0x79656A0", VA = "0x1879668A0")]
	private void NGPBMHGCJGB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000170")]
	[Cpp2IlInjected.Address(RVA = "0x7964030", Offset = "0x7962E30", VA = "0x187964030")]
	private void HNOEAPKGKHM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600017A")]
	[Cpp2IlInjected.Address(RVA = "0x79661D0", Offset = "0x7964FD0", VA = "0x1879661D0", Slot = "30")]
	public BKMLAJCFPOO MIKIBPHJIDH(int KNCPCNBMDNF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600017D")]
	[Cpp2IlInjected.Address(RVA = "0x7966E50", Offset = "0x7965C50", VA = "0x187966E50", Slot = "98")]
	public void ODEJGNHFANL(BKMLAJCFPOO IPHILEOFJLB, bool CDNOMBACDJA = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000194")]
	[Cpp2IlInjected.Address(RVA = "0x7962050", Offset = "0x7960E50", VA = "0x187962050", Slot = "99")]
	public void BPCIEHLINIP(object HACFGBHNOCC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000195")]
	[Cpp2IlInjected.Address(RVA = "0x79616B0", Offset = "0x79604B0", VA = "0x1879616B0", Slot = "100")]
	public void APKBLDCGCMI(object HACFGBHNOCC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000196")]
	[Cpp2IlInjected.Address(RVA = "0x7966920", Offset = "0x7965720", VA = "0x187966920", Slot = "101")]
	public Vector3 NJLCIKCJKMD(Vector3 DKHOBKICOML)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000197")]
	[Cpp2IlInjected.Address(RVA = "0x7963A30", Offset = "0x7962830", VA = "0x187963A30", Slot = "102")]
	public Vector3 HBLCPBHIIDI(Vector3 FOLDPAFFMOB)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000198")]
	[Cpp2IlInjected.Address(RVA = "0x7964280", Offset = "0x7963080", VA = "0x187964280", Slot = "103")]
	public void ICNBDOGBKCC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000199")]
	[Cpp2IlInjected.Address(RVA = "0x7964D80", Offset = "0x7963B80", VA = "0x187964D80", Slot = "104")]
	public void JOLLBIOJCBM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600019A")]
	[Cpp2IlInjected.Address(RVA = "0x7962460", Offset = "0x7961260", VA = "0x187962460", Slot = "105")]
	public void CFNHIHGNLJC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600019B")]
	[Cpp2IlInjected.Address(RVA = "0x7962960", Offset = "0x7961760", VA = "0x187962960", Slot = "106")]
	public void DMPLLEHEHHJ(Vector3 NKJFLEFCNNK, Vector3 KMOLFMJJEFF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600019C")]
	[Cpp2IlInjected.Address(RVA = "0x7966A20", Offset = "0x7965820", VA = "0x187966A20", Slot = "107")]
	public void NKCPNGJPKJI(Vector3 PGPILCGHHEN, Vector3 HPDLDIEKLGI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600019D")]
	[Cpp2IlInjected.Address(RVA = "0x79660F0", Offset = "0x7964EF0", VA = "0x1879660F0", Slot = "108")]
	public void MHOOOJMNAMI(Vector3 GJDKCHCMPKK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600019E")]
	[Cpp2IlInjected.Address(RVA = "0x7963460", Offset = "0x7962260", VA = "0x187963460", Slot = "109")]
	public void FHDDMCOIBHK(DLLHHLOAIHN JNKNJFCPKCP, Vector3 DENBFHHPJGH, float INBGKGNKFFB, float LHLMMNAMGFA = 8f, float KOOKFIHBGFH = 1f)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600019F")]
	[Cpp2IlInjected.Address(RVA = "0x79645C0", Offset = "0x79633C0", VA = "0x1879645C0", Slot = "110")]
	public void IIDMCFJEDDH(PKECHOKBABG EBIBFBONINJ, Vector3 JPKNKMLFEDJ, float LNNCFJOFHBA = float.PositiveInfinity)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001A0")]
	[Cpp2IlInjected.Address(RVA = "0x7963730", Offset = "0x7962530", VA = "0x187963730", Slot = "111")]
	[Obsolete("Deprecated. Still exists to support deprecated CV2 chips. Use ApplyAngularVelocityChange.")]
	public void GIPFFEIENKO(PKECHOKBABG EBIBFBONINJ, Vector3 CKABIAOPKPM, float HDGLIBMICCI = 7f, float DPLEKOGCINM = 1f)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001A1")]
	[Cpp2IlInjected.Address(RVA = "0x79625E0", Offset = "0x79613E0", VA = "0x1879625E0", Slot = "112")]
	public Vector3 DBDODPLBOAD(Vector3 IPHILEOFJLB)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x60001A2")]
	[Cpp2IlInjected.Address(RVA = "0x7961860", Offset = "0x7960660", VA = "0x187961860", Slot = "113")]
	public Vector3 BCLNKGGBOEH(Vector3 IPHILEOFJLB)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x60001A3")]
	[Cpp2IlInjected.Address(RVA = "0x7964230", Offset = "0x7963030", VA = "0x187964230", Slot = "114")]
	public void IALHFLNDCNP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001A6")]
	[Cpp2IlInjected.Address(RVA = "0x7967360", Offset = "0x7966160", VA = "0x187967360", Slot = "115")]
	public void OMLHKDNIBJN(BKMLAJCFPOO LNDOFDMKLIE, object HACFGBHNOCC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001A7")]
	[Cpp2IlInjected.Address(RVA = "0x7963620", Offset = "0x7962420", VA = "0x187963620", Slot = "116")]
	public void GCANHKDPCOM(object HACFGBHNOCC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001B2")]
	[Cpp2IlInjected.Address(RVA = "0x79612D0", Offset = "0x79600D0", VA = "0x1879612D0", Slot = "63")]
	public void ABCJBEHKOHN((Quaternion rot, Vector3 moments) IEKPANIOKCJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001B3")]
	[Cpp2IlInjected.Address(RVA = "0x7962E40", Offset = "0x7961C40", VA = "0x187962E40", Slot = "117")]
	public void EGIHCPCAFBE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001B4")]
	[Cpp2IlInjected.Address(RVA = "0x79630A0", Offset = "0x7961EA0", VA = "0x1879630A0", Slot = "118")]
	public void FAHHJFPOHIJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001B5")]
	[Cpp2IlInjected.Address(RVA = "0x79630F0", Offset = "0x7961EF0", VA = "0x1879630F0", Slot = "119")]
	public void FCBHEDAOLDB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001BE")]
	[Cpp2IlInjected.Address(RVA = "0x79613B0", Offset = "0x79601B0", VA = "0x1879613B0", Slot = "120")]
	public bool ABCPKPFAHNI()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001BF")]
	[Cpp2IlInjected.Address(RVA = "0x7961B10", Offset = "0x7960910", VA = "0x187961B10", Slot = "97")]
	public void BFHIJDILBDB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001C0")]
	[Cpp2IlInjected.Address(RVA = "0x7961400", Offset = "0x7960200", VA = "0x187961400", Slot = "121")]
	public void ACKEKMFONNI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001C8")]
	[Cpp2IlInjected.Address(RVA = "0x7966840", Offset = "0x7965640", VA = "0x187966840", Slot = "122")]
	public void NDNHLHKLAJO(object HACFGBHNOCC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001C9")]
	[Cpp2IlInjected.Address(RVA = "0x79627C0", Offset = "0x79615C0", VA = "0x1879627C0", Slot = "123")]
	public void DHHHJHJJACF(object HACFGBHNOCC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001CA")]
	[Cpp2IlInjected.Address(RVA = "0x79659F0", Offset = "0x79647F0", VA = "0x1879659F0", Slot = "124")]
	public void LFKMFFNIBNF(object HACFGBHNOCC, bool AFBCKAHGIKH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001DA")]
	[Cpp2IlInjected.Address(RVA = "0x7967420", Offset = "0x7966220", VA = "0x187967420", Slot = "125")]
	public void PFJAPFPFLOE(Vector3 OHGAAEDJDPL, Quaternion LDPILEOMGMF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001DB")]
	[Cpp2IlInjected.Address(RVA = "0x7962110", Offset = "0x7960F10", VA = "0x187962110", Slot = "126")]
	public void CAKBMNHOGBB(Vector3 ANBHGIAIIEJ, Quaternion OCGOOLKPBNF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001DC")]
	[Cpp2IlInjected.Address(RVA = "0x7966250", Offset = "0x7965050", VA = "0x187966250", Slot = "127")]
	public bool MIPLFJJMAIB(float GCBKKLKKPFG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001E1")]
	[Cpp2IlInjected.Address(RVA = "0x7965260", Offset = "0x7964060", VA = "0x187965260", Slot = "128")]
	public void KHGLCMCLAGL(object HACFGBHNOCC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001E2")]
	[Cpp2IlInjected.Address(RVA = "0x7963FD0", Offset = "0x7962DD0", VA = "0x187963FD0", Slot = "129")]
	public void HNINIJALCOE(object HACFGBHNOCC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001E3")]
	[Cpp2IlInjected.Address(RVA = "0x7962900", Offset = "0x7961700", VA = "0x187962900", Slot = "130")]
	public void DMCOGFFPGPE(object HACFGBHNOCC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001E4")]
	[Cpp2IlInjected.Address(RVA = "0x7963890", Offset = "0x7962690", VA = "0x187963890", Slot = "131")]
	public void GNBBEKCJFMA(object HACFGBHNOCC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001E5")]
	[Cpp2IlInjected.Address(RVA = "0x7967700", Offset = "0x7966500", VA = "0x187967700", Slot = "132")]
	public void PGLBLAGLHBK(Vector3 MKKNPGPEIPF, ForceMode PBMLNEJDMIB = ForceMode.Force)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001E6")]
	[Cpp2IlInjected.Address(RVA = "0x7964B40", Offset = "0x7963940", VA = "0x187964B40", Slot = "133")]
	public void JGMDIHEFGOP(Vector3 MKKNPGPEIPF, Vector3 AKEODPFBHJE, ForceMode PBMLNEJDMIB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001E7")]
	[Cpp2IlInjected.Address(RVA = "0x7963C30", Offset = "0x7962A30", VA = "0x187963C30", Slot = "134")]
	public void HKABICKGENB(Vector3 FHOLONAELHO, ForceMode PBMLNEJDMIB = ForceMode.Force)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001E8")]
	[Cpp2IlInjected.Address(RVA = "0x79677E0", Offset = "0x79665E0", VA = "0x1879677E0", Slot = "135")]
	public void PMLDNMMBFDJ(Vector3 FHOLONAELHO, ForceMode PBMLNEJDMIB = ForceMode.Force)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001EB")]
	[Cpp2IlInjected.Address(RVA = "0x79664C0", Offset = "0x79652C0", VA = "0x1879664C0", Slot = "136")]
	public bool MPEAOKEEILP(Vector3 GGAAGAFEPHJ, [Out] RaycastHit KCLINOMLMOA, float HKMCFNGLEFP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001EE")]
	[Cpp2IlInjected.Address(RVA = "0x7963840", Offset = "0x7962640", VA = "0x187963840", Slot = "137")]
	public void GLCKBHAHEJI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001EF")]
	[Cpp2IlInjected.Address(RVA = "0x7967990", Offset = "0x7966790", VA = "0x187967990", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001F0")]
	[Cpp2IlInjected.Address(RVA = "0x7966D20", Offset = "0x7965B20", VA = "0x187966D20")]
	private void NNJNGHMPNBP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001F1")]
	[Cpp2IlInjected.Address(RVA = "0x79619B0", Offset = "0x79607B0", VA = "0x1879619B0")]
	private void BFAIEAPELMB(BKMLAJCFPOO IFAMCPHMKIP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001F2")]
	[Cpp2IlInjected.Address(RVA = "0x7963220", Offset = "0x7962020", VA = "0x187963220")]
	private void FFGAINHMJPB(BKMLAJCFPOO IFAMCPHMKIP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001F3")]
	[Cpp2IlInjected.Address(RVA = "0x7962FA0", Offset = "0x7961DA0", VA = "0x187962FA0")]
	private void ELGLHOKHCNA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001F4")]
	[Cpp2IlInjected.Address(RVA = "0x79652C0", Offset = "0x79640C0", VA = "0x1879652C0")]
	private void KHKLHHFOHPL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001F5")]
	[Cpp2IlInjected.Address(RVA = "0x7964720", Offset = "0x7963520", VA = "0x187964720")]
	private void ILLDKMHLAJC(BKMLAJCFPOO CBHPLMNJMDN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001F6")]
	[Cpp2IlInjected.Address(RVA = "0x7964990", Offset = "0x7963790", VA = "0x187964990")]
	private void IOPBIMOFKHN(BKMLAJCFPOO IFAMCPHMKIP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001F7")]
	[Cpp2IlInjected.Address(RVA = "0x7966B10", Offset = "0x7965910", VA = "0x187966B10")]
	private void NLBLLKCJHNE(BKMLAJCFPOO IFAMCPHMKIP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001F8")]
	[Cpp2IlInjected.Address(RVA = "0x7961B60", Offset = "0x7960960", VA = "0x187961B60")]
	private void BGDGBHKKNPP(FHDFMCFBJMM IFAMCPHMKIP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001F9")]
	[Cpp2IlInjected.Address(RVA = "0x7964E20", Offset = "0x7963C20", VA = "0x187964E20", Slot = "142")]
	protected virtual void KGDDCDAJDAJ(FHDFMCFBJMM EDMNKJJOIJK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001FA")]
	[Cpp2IlInjected.Address(RVA = "0x7965CA0", Offset = "0x7964AA0", VA = "0x187965CA0")]
	protected void MCLANHCCPAF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001FB")]
	[Cpp2IlInjected.Address(RVA = "0x7965670", Offset = "0x7964470", VA = "0x187965670")]
	protected void LDOAMFPNBEM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001FC")]
	[Cpp2IlInjected.Address(RVA = "0x7963DF0", Offset = "0x7962BF0", VA = "0x187963DF0")]
	private void HKGBNKJKLGF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001FD")]
	[Cpp2IlInjected.Address(RVA = "0x7962240", Offset = "0x7961040", VA = "0x187962240")]
	private void CCFKBOOLCPP()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001D")]
internal static class GDMKJPOEHOP
{
	[Cpp2IlInjected.Token(Token = "0x60001FE")]
	[Cpp2IlInjected.Address(RVA = "0x796B400", Offset = "0x796A200", VA = "0x18796B400")]
	public static BKMLAJCFPOO KFLBCAKALGO(this BKMLAJCFPOO EDMNKJJOIJK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001FF")]
	[Cpp2IlInjected.Address(RVA = "0x796B270", Offset = "0x796A070", VA = "0x18796B270")]
	public static bool COMDCBBNAJD(this BKMLAJCFPOO EDMNKJJOIJK, BKMLAJCFPOO BLIFNMNMLCG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000200")]
	[Cpp2IlInjected.Address(RVA = "0x796B360", Offset = "0x796A160", VA = "0x18796B360")]
	public static bool HJOBOHPLPFG(this BKMLAJCFPOO EDMNKJJOIJK, BKMLAJCFPOO AOGCBHGEFAB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000201")]
	[Cpp2IlInjected.Address(RVA = "0x796B310", Offset = "0x796A110", VA = "0x18796B310")]
	public static FHDFMCFBJMM EFJACEBGFFF(this BKMLAJCFPOO MNCBDJMAFIF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000202")]
	[Cpp2IlInjected.Address(RVA = "0x796B4C0", Offset = "0x796A2C0", VA = "0x18796B4C0")]
	public static EPBNDOPLGGE OCOIBFFJGHP(this BKMLAJCFPOO MNCBDJMAFIF)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200001E")]
public class PONICBGOMOL : BBFDEFFCBPG
{
	[Cpp2IlInjected.Token(Token = "0x6000203")]
	[Cpp2IlInjected.Address(RVA = "0x7975310", Offset = "0x7974110", VA = "0x187975310", Slot = "19")]
	public BKMLAJCFPOO FIGMNIAKICK(RigidbodyEx EDMNKJJOIJK, HKDIAHPAMEO JOAPLPPIFPC, ODBKIHNADLB HLDNIAJEGKP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000204")]
	[Cpp2IlInjected.Address(RVA = "0x8F6D50", Offset = "0x8F5B50", VA = "0x1808F6D50", Slot = "4")]
	public FKBLJPAJLHP EANPCNMGMCN(BKMLAJCFPOO MNCBDJMAFIF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000205")]
	[Cpp2IlInjected.Address(RVA = "0x8F6D50", Offset = "0x8F5B50", VA = "0x1808F6D50", Slot = "5")]
	public EFAKGJHIOBO LLMEOPINNPH(BKMLAJCFPOO MNCBDJMAFIF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000206")]
	[Cpp2IlInjected.Address(RVA = "0x8F6D50", Offset = "0x8F5B50", VA = "0x1808F6D50", Slot = "6")]
	public GENBFDOKDMJ NEEDELJPFJG(BKMLAJCFPOO MNCBDJMAFIF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000207")]
	[Cpp2IlInjected.Address(RVA = "0x8F6D50", Offset = "0x8F5B50", VA = "0x1808F6D50", Slot = "7")]
	public MOAMEMFPAHE EGEAIEBINMO(BKMLAJCFPOO MNCBDJMAFIF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000208")]
	[Cpp2IlInjected.Address(RVA = "0x8F6D50", Offset = "0x8F5B50", VA = "0x1808F6D50", Slot = "8")]
	public EPCLGGKOKDH PMDGIOLFCHG(BKMLAJCFPOO MNCBDJMAFIF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000209")]
	[Cpp2IlInjected.Address(RVA = "0x8F6D50", Offset = "0x8F5B50", VA = "0x1808F6D50", Slot = "9")]
	public CIGACFAOEEE AAFCLNCPJGG(BKMLAJCFPOO MNCBDJMAFIF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600020A")]
	[Cpp2IlInjected.Address(RVA = "0x8F6D50", Offset = "0x8F5B50", VA = "0x1808F6D50", Slot = "10")]
	public LIIPPALMDAB KJMPCEIFBMH(BKMLAJCFPOO MNCBDJMAFIF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600020B")]
	[Cpp2IlInjected.Address(RVA = "0x8F6D50", Offset = "0x8F5B50", VA = "0x1808F6D50", Slot = "11")]
	public NOJNACJJDCN GNJIECPPEOA(BKMLAJCFPOO MNCBDJMAFIF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600020C")]
	[Cpp2IlInjected.Address(RVA = "0x8F6D50", Offset = "0x8F5B50", VA = "0x1808F6D50", Slot = "12")]
	public MMJFFFMIADC LFOHGPAFIFO(BKMLAJCFPOO MNCBDJMAFIF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600020D")]
	[Cpp2IlInjected.Address(RVA = "0x8F6D50", Offset = "0x8F5B50", VA = "0x1808F6D50", Slot = "13")]
	public NBPGLENHDHN CAOBDEEDIJH(BKMLAJCFPOO MNCBDJMAFIF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600020E")]
	[Cpp2IlInjected.Address(RVA = "0x8F6D50", Offset = "0x8F5B50", VA = "0x1808F6D50")]
	public POLDBHKMHHJ DKAOHGPCNFM(BKMLAJCFPOO MNCBDJMAFIF, [In] HKDIAHPAMEO JOAPLPPIFPC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600020F")]
	[Cpp2IlInjected.Address(RVA = "0x8F6D50", Offset = "0x8F5B50", VA = "0x1808F6D50")]
	public LDFDKFJIGHG FBFMJEJPNCG(BKMLAJCFPOO MNCBDJMAFIF, [In] HKDIAHPAMEO JOAPLPPIFPC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000210")]
	[Cpp2IlInjected.Address(RVA = "0x8F6D50", Offset = "0x8F5B50", VA = "0x1808F6D50")]
	public LPJPGCAEPHD HOLDGAMPGMH(BKMLAJCFPOO MNCBDJMAFIF, [In] HKDIAHPAMEO JOAPLPPIFPC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000211")]
	[Cpp2IlInjected.Address(RVA = "0x8F6D50", Offset = "0x8F5B50", VA = "0x1808F6D50")]
	public MHBMHJOFKAF EBKJHPPJNLI(BKMLAJCFPOO MNCBDJMAFIF, [In] HKDIAHPAMEO JOAPLPPIFPC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000212")]
	[Cpp2IlInjected.Address(RVA = "0x8F6D50", Offset = "0x8F5B50", VA = "0x1808F6D50")]
	public DJFBKMLCAJO JDAHPKIGDAC(BKMLAJCFPOO MNCBDJMAFIF, [In] HKDIAHPAMEO JOAPLPPIFPC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000213")]
	[Cpp2IlInjected.Address(RVA = "0x8FE490", Offset = "0x8FD290", VA = "0x1808FE490")]
	public PONICBGOMOL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000214")]
	[Cpp2IlInjected.Address(RVA = "0x8F6D50", Offset = "0x8F5B50", VA = "0x1808F6D50", Slot = "14")]
	private POLDBHKMHHJ OIFBNBPJPEJ(BKMLAJCFPOO MNCBDJMAFIF, [In] HKDIAHPAMEO JOAPLPPIFPC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000215")]
	[Cpp2IlInjected.Address(RVA = "0x8F6D50", Offset = "0x8F5B50", VA = "0x1808F6D50", Slot = "15")]
	private LDFDKFJIGHG JAEABDHGJFN(BKMLAJCFPOO MNCBDJMAFIF, [In] HKDIAHPAMEO JOAPLPPIFPC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000216")]
	[Cpp2IlInjected.Address(RVA = "0x8F6D50", Offset = "0x8F5B50", VA = "0x1808F6D50", Slot = "16")]
	private LPJPGCAEPHD BHKALOFDPMP(BKMLAJCFPOO MNCBDJMAFIF, [In] HKDIAHPAMEO JOAPLPPIFPC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000217")]
	[Cpp2IlInjected.Address(RVA = "0x8F6D50", Offset = "0x8F5B50", VA = "0x1808F6D50", Slot = "17")]
	private MHBMHJOFKAF KBNFLBOGDIH(BKMLAJCFPOO MNCBDJMAFIF, [In] HKDIAHPAMEO JOAPLPPIFPC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000218")]
	[Cpp2IlInjected.Address(RVA = "0x8F6D50", Offset = "0x8F5B50", VA = "0x1808F6D50", Slot = "18")]
	private DJFBKMLCAJO MFBJPGBBEIJ(BKMLAJCFPOO MNCBDJMAFIF, [In] HKDIAHPAMEO JOAPLPPIFPC)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200001F")]
[RegisterService(typeof(BBFDEFFCBPG), new string[] { })]
public class AAFKAPCEKAK : BBFDEFFCBPG, PLOJOFMKFEM
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000030")]
	private readonly BBFDEFFCBPG GIMOBADNFEK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000031")]
	private readonly BBFDEFFCBPG AJIDGGFAOBE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000032")]
	private MLFBOGPBFOD KILMFPPKPGG;

	[Cpp2IlInjected.Token(Token = "0x1700008B")]
	private BBFDEFFCBPG JCPMALMDJCA
	{
		[Cpp2IlInjected.Token(Token = "0x600021A")]
		[Cpp2IlInjected.Address(RVA = "0x795F180", Offset = "0x795DF80", VA = "0x18795F180")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000219")]
	[Cpp2IlInjected.Address(RVA = "0x795EE00", Offset = "0x795DC00", VA = "0x18795EE00", Slot = "20")]
	public void InitReferences(BFHPBCPPECP AGGPMDGGKLP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600021B")]
	[Cpp2IlInjected.Address(RVA = "0x795E970", Offset = "0x795D770", VA = "0x18795E970", Slot = "4")]
	public FKBLJPAJLHP EANPCNMGMCN(BKMLAJCFPOO MNCBDJMAFIF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600021C")]
	[Cpp2IlInjected.Address(RVA = "0x795F040", Offset = "0x795DE40", VA = "0x18795F040", Slot = "5")]
	public EFAKGJHIOBO LLMEOPINNPH(BKMLAJCFPOO MNCBDJMAFIF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600021D")]
	[Cpp2IlInjected.Address(RVA = "0x795F0E0", Offset = "0x795DEE0", VA = "0x18795F0E0", Slot = "6")]
	public GENBFDOKDMJ NEEDELJPFJG(BKMLAJCFPOO MNCBDJMAFIF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600021E")]
	[Cpp2IlInjected.Address(RVA = "0x795EAC0", Offset = "0x795D8C0", VA = "0x18795EAC0", Slot = "7")]
	public MOAMEMFPAHE EGEAIEBINMO(BKMLAJCFPOO MNCBDJMAFIF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600021F")]
	[Cpp2IlInjected.Address(RVA = "0x795F1E0", Offset = "0x795DFE0", VA = "0x18795F1E0", Slot = "8")]
	public EPCLGGKOKDH PMDGIOLFCHG(BKMLAJCFPOO MNCBDJMAFIF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000220")]
	[Cpp2IlInjected.Address(RVA = "0x795E6D0", Offset = "0x795D4D0", VA = "0x18795E6D0", Slot = "9")]
	public CIGACFAOEEE AAFCLNCPJGG(BKMLAJCFPOO MNCBDJMAFIF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000221")]
	[Cpp2IlInjected.Address(RVA = "0x795EF00", Offset = "0x795DD00", VA = "0x18795EF00", Slot = "10")]
	public LIIPPALMDAB KJMPCEIFBMH(BKMLAJCFPOO MNCBDJMAFIF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000222")]
	[Cpp2IlInjected.Address(RVA = "0x795ED60", Offset = "0x795DB60", VA = "0x18795ED60", Slot = "11")]
	public NOJNACJJDCN GNJIECPPEOA(BKMLAJCFPOO MNCBDJMAFIF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000223")]
	[Cpp2IlInjected.Address(RVA = "0x795EFA0", Offset = "0x795DDA0", VA = "0x18795EFA0", Slot = "12")]
	public MMJFFFMIADC LFOHGPAFIFO(BKMLAJCFPOO MNCBDJMAFIF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000224")]
	[Cpp2IlInjected.Address(RVA = "0x795E820", Offset = "0x795D620", VA = "0x18795E820", Slot = "13")]
	public NBPGLENHDHN CAOBDEEDIJH(BKMLAJCFPOO MNCBDJMAFIF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000225")]
	[Cpp2IlInjected.Address(RVA = "0x795E8C0", Offset = "0x795D6C0", VA = "0x18795E8C0")]
	public POLDBHKMHHJ DKAOHGPCNFM(BKMLAJCFPOO MNCBDJMAFIF, [In] HKDIAHPAMEO JOAPLPPIFPC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000226")]
	[Cpp2IlInjected.Address(RVA = "0x795EB60", Offset = "0x795D960", VA = "0x18795EB60")]
	public LDFDKFJIGHG FBFMJEJPNCG(BKMLAJCFPOO MNCBDJMAFIF, [In] HKDIAHPAMEO JOAPLPPIFPC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000227")]
	[Cpp2IlInjected.Address(RVA = "0x795E770", Offset = "0x795D570", VA = "0x18795E770")]
	public LPJPGCAEPHD HOLDGAMPGMH(BKMLAJCFPOO MNCBDJMAFIF, [In] HKDIAHPAMEO JOAPLPPIFPC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000228")]
	[Cpp2IlInjected.Address(RVA = "0x795EA10", Offset = "0x795D810", VA = "0x18795EA10")]
	public MHBMHJOFKAF EBKJHPPJNLI(BKMLAJCFPOO MNCBDJMAFIF, [In] HKDIAHPAMEO JOAPLPPIFPC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000229")]
	[Cpp2IlInjected.Address(RVA = "0x795EE50", Offset = "0x795DC50", VA = "0x18795EE50")]
	public DJFBKMLCAJO JDAHPKIGDAC(BKMLAJCFPOO MNCBDJMAFIF, [In] HKDIAHPAMEO JOAPLPPIFPC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600022A")]
	[Cpp2IlInjected.Address(RVA = "0x795EC10", Offset = "0x795DA10", VA = "0x18795EC10", Slot = "19")]
	public BKMLAJCFPOO FIGMNIAKICK(RigidbodyEx EDMNKJJOIJK, HKDIAHPAMEO JOAPLPPIFPC, ODBKIHNADLB HLDNIAJEGKP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600022B")]
	[Cpp2IlInjected.Address(RVA = "0x795F280", Offset = "0x795E080", VA = "0x18795F280")]
	public AAFKAPCEKAK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600022C")]
	[Cpp2IlInjected.Address(RVA = "0x795E8C0", Offset = "0x795D6C0", VA = "0x18795E8C0", Slot = "14")]
	private POLDBHKMHHJ OIFBNBPJPEJ(BKMLAJCFPOO MNCBDJMAFIF, [In] HKDIAHPAMEO JOAPLPPIFPC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600022D")]
	[Cpp2IlInjected.Address(RVA = "0x795EB60", Offset = "0x795D960", VA = "0x18795EB60", Slot = "15")]
	private LDFDKFJIGHG JAEABDHGJFN(BKMLAJCFPOO MNCBDJMAFIF, [In] HKDIAHPAMEO JOAPLPPIFPC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600022E")]
	[Cpp2IlInjected.Address(RVA = "0x795E770", Offset = "0x795D570", VA = "0x18795E770", Slot = "16")]
	private LPJPGCAEPHD BHKALOFDPMP(BKMLAJCFPOO MNCBDJMAFIF, [In] HKDIAHPAMEO JOAPLPPIFPC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600022F")]
	[Cpp2IlInjected.Address(RVA = "0x795EA10", Offset = "0x795D810", VA = "0x18795EA10", Slot = "17")]
	private MHBMHJOFKAF KBNFLBOGDIH(BKMLAJCFPOO MNCBDJMAFIF, [In] HKDIAHPAMEO JOAPLPPIFPC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000230")]
	[Cpp2IlInjected.Address(RVA = "0x795EE50", Offset = "0x795DC50", VA = "0x18795EE50", Slot = "18")]
	private DJFBKMLCAJO MFBJPGBBEIJ(BKMLAJCFPOO MNCBDJMAFIF, [In] HKDIAHPAMEO JOAPLPPIFPC)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000020")]
public interface IKDEKIEGKPL : FKBLJPAJLHP, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x6000231")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void AOEKKHIFAME(BKMLAJCFPOO EDMNKJJOIJK);

	[Cpp2IlInjected.Token(Token = "0x6000232")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void CFPEBBLKGPM(BKMLAJCFPOO EDMNKJJOIJK);

	[Cpp2IlInjected.Token(Token = "0x6000233")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void IDPDHKMKKCA(BKMLAJCFPOO CBHPLMNJMDN);

	[Cpp2IlInjected.Token(Token = "0x6000234")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void JONGNIBICAO(BKMLAJCFPOO CBHPLMNJMDN);
}
[Cpp2IlInjected.Token(Token = "0x2000021")]
public interface OAIMLNHLLPF : GENBFDOKDMJ
{
	[Cpp2IlInjected.Token(Token = "0x1700008C")]
	IBPJDCCBOAD<BKMLAJCFPOO> MHGPGKAFBID
	{
		[Cpp2IlInjected.Token(Token = "0x6000235")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700008D")]
	BKMLAJCFPOO ADPBPJBCJON
	{
		[Cpp2IlInjected.Token(Token = "0x6000236")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000022")]
public interface CMKEMNJPHDD : MHBMHJOFKAF
{
	[Cpp2IlInjected.Token(Token = "0x6000237")]
	[Cpp2IlInjected.Address(Slot = "0")]
	(float, Vector3) EGFJOLAAEHJ(Rigidbody OIOPPILBEEE);
}
[Cpp2IlInjected.Token(Token = "0x2000023")]
public interface JIIFIOPJLAH : LDFDKFJIGHG, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x1700008E")]
	PhotonView EIGGDCHEJIP
	{
		[Cpp2IlInjected.Token(Token = "0x6000238")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000024")]
internal sealed class EEAGFIDEBKG : MMJFFFMIADC
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000033")]
	private readonly EPBNDOPLGGE EDMNKJJOIJK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000034")]
	private CollisionDetectionMode DLIGLIEBNGL;

	[Cpp2IlInjected.Token(Token = "0x1700008F")]
	private Rigidbody OKMLLKAPHNL
	{
		[Cpp2IlInjected.Token(Token = "0x6000239")]
		[Cpp2IlInjected.Address(RVA = "0x7960E40", Offset = "0x795FC40", VA = "0x187960E40")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000090")]
	public CollisionDetectionMode PJOKPNNELFB
	{
		[Cpp2IlInjected.Token(Token = "0x600023D")]
		[Cpp2IlInjected.Address(RVA = "0x7960C10", Offset = "0x795FA10", VA = "0x187960C10", Slot = "4")]
		get
		{
			return default(CollisionDetectionMode);
		}
		[Cpp2IlInjected.Token(Token = "0x600023E")]
		[Cpp2IlInjected.Address(RVA = "0x7960EA0", Offset = "0x795FCA0", VA = "0x187960EA0", Slot = "5")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600023A")]
	[Cpp2IlInjected.Address(RVA = "0x795F4E0", Offset = "0x795E2E0", VA = "0x18795F4E0")]
	public EEAGFIDEBKG(BKMLAJCFPOO EDMNKJJOIJK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600023B")]
	[Cpp2IlInjected.Address(RVA = "0x7961100", Offset = "0x795FF00", VA = "0x187961100", Slot = "6")]
	public void NLNNABDBLFO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600023C")]
	[Cpp2IlInjected.Address(RVA = "0x7960F10", Offset = "0x795FD10", VA = "0x187960F10", Slot = "9")]
	public void LPCBHBLKHJO(Rigidbody BFBNFNHBHPL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600023F")]
	[Cpp2IlInjected.Address(RVA = "0x79610F0", Offset = "0x795FEF0", VA = "0x1879610F0", Slot = "7")]
	public void NGEBHFHKAOK(bool PAOEEMLIJOB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000240")]
	[Cpp2IlInjected.Address(RVA = "0x7960E90", Offset = "0x795FC90", VA = "0x187960E90", Slot = "8")]
	public void GCHPPHMOCHD(bool PAOEEMLIJOB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000241")]
	[Cpp2IlInjected.Address(RVA = "0x7960F90", Offset = "0x795FD90", VA = "0x187960F90", Slot = "10")]
	public bool MPEAOKEEILP(Vector3 GGAAGAFEPHJ, [Out] RaycastHit KCLINOMLMOA, float HKMCFNGLEFP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000242")]
	[Cpp2IlInjected.Address(RVA = "0x7960D20", Offset = "0x795FB20", VA = "0x187960D20")]
	private void BAOHOMFAFLF(bool PAOEEMLIJOB)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000025")]
public sealed class CDKLIEPAFEL : CIGACFAOEEE, IDisposable, ILELCPFIBBF
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000036")]
	private readonly EPBNDOPLGGE EDMNKJJOIJK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000037")]
	private CDPBBJLFOGJ BKKKAIPCNPK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000038")]
	private HHOAEHJDIIK JPFDJFLJPKI;

	[Cpp2IlInjected.Token(Token = "0x17000091")]
	public CDPBBJLFOGJ LAFBBOHALEO
	{
		[Cpp2IlInjected.Token(Token = "0x6000245")]
		[Cpp2IlInjected.Address(RVA = "0x795F810", Offset = "0x795E610", VA = "0x18795F810", Slot = "6")]
		get
		{
			return default(CDPBBJLFOGJ);
		}
		[Cpp2IlInjected.Token(Token = "0x6000246")]
		[Cpp2IlInjected.Address(RVA = "0x795F690", Offset = "0x795E490", VA = "0x18795F690", Slot = "7")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000092")]
	private Transform NCFEMOJNANB
	{
		[Cpp2IlInjected.Token(Token = "0x6000247")]
		[Cpp2IlInjected.Address(RVA = "0xB84780", Offset = "0xB83580", VA = "0x180B84780", Slot = "10")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000020")]
	public event Action<FMMANLJJECN, FMMANLJJECN> CPGMPPGCGAK
	{
		[Cpp2IlInjected.Token(Token = "0x6000243")]
		[Cpp2IlInjected.Address(RVA = "0x795F760", Offset = "0x795E560", VA = "0x18795F760", Slot = "4")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000244")]
		[Cpp2IlInjected.Address(RVA = "0x795F950", Offset = "0x795E750", VA = "0x18795F950", Slot = "5")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000248")]
	[Cpp2IlInjected.Address(RVA = "0x795FC70", Offset = "0x795EA70", VA = "0x18795FC70")]
	public CDKLIEPAFEL(BKMLAJCFPOO EDMNKJJOIJK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000249")]
	[Cpp2IlInjected.Address(RVA = "0x795FA00", Offset = "0x795E800", VA = "0x18795FA00", Slot = "8")]
	public void NLNNABDBLFO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600024A")]
	[Cpp2IlInjected.Address(RVA = "0x795F640", Offset = "0x795E440", VA = "0x18795F640", Slot = "9")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600024B")]
	[Cpp2IlInjected.Address(RVA = "0xFDDB40", Offset = "0xFDC940", VA = "0x180FDDB40", Slot = "11")]
	private void LHABKIGEEPK(FMMANLJJECN IBCJICNHOPJ, FMMANLJJECN DLLFCMLKHPF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600024C")]
	[Cpp2IlInjected.Address(RVA = "0x8F6D40", Offset = "0x8F5B40", VA = "0x1808F6D40", Slot = "12")]
	private void ILCJNNIMNDG(bool GDCAFGBKNFM)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000026")]
public class KICMOKAJIHA : BBFDEFFCBPG
{
	[Cpp2IlInjected.Token(Token = "0x600024D")]
	[Cpp2IlInjected.Address(RVA = "0x7970950", Offset = "0x796F750", VA = "0x187970950", Slot = "4")]
	public FKBLJPAJLHP EANPCNMGMCN(BKMLAJCFPOO MNCBDJMAFIF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600024E")]
	[Cpp2IlInjected.Address(RVA = "0x79712B0", Offset = "0x79700B0", VA = "0x1879712B0", Slot = "5")]
	public EFAKGJHIOBO LLMEOPINNPH(BKMLAJCFPOO MNCBDJMAFIF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600024F")]
	[Cpp2IlInjected.Address(RVA = "0x79713D0", Offset = "0x79701D0", VA = "0x1879713D0", Slot = "6")]
	public GENBFDOKDMJ NEEDELJPFJG(BKMLAJCFPOO MNCBDJMAFIF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000250")]
	[Cpp2IlInjected.Address(RVA = "0x7970BD0", Offset = "0x796F9D0", VA = "0x187970BD0", Slot = "7")]
	public MOAMEMFPAHE EGEAIEBINMO(BKMLAJCFPOO MNCBDJMAFIF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000251")]
	[Cpp2IlInjected.Address(RVA = "0x7971500", Offset = "0x7970300", VA = "0x187971500", Slot = "8")]
	public EPCLGGKOKDH PMDGIOLFCHG(BKMLAJCFPOO MNCBDJMAFIF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000252")]
	[Cpp2IlInjected.Address(RVA = "0x7970550", Offset = "0x796F350", VA = "0x187970550", Slot = "9")]
	public CIGACFAOEEE AAFCLNCPJGG(BKMLAJCFPOO MNCBDJMAFIF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000253")]
	[Cpp2IlInjected.Address(RVA = "0x79710D0", Offset = "0x796FED0", VA = "0x1879710D0", Slot = "10")]
	public LIIPPALMDAB KJMPCEIFBMH(BKMLAJCFPOO MNCBDJMAFIF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000254")]
	[Cpp2IlInjected.Address(RVA = "0x7970F30", Offset = "0x796FD30", VA = "0x187970F30", Slot = "11")]
	public NOJNACJJDCN GNJIECPPEOA(BKMLAJCFPOO MNCBDJMAFIF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000255")]
	[Cpp2IlInjected.Address(RVA = "0x79711F0", Offset = "0x796FFF0", VA = "0x1879711F0", Slot = "12")]
	public MMJFFFMIADC LFOHGPAFIFO(BKMLAJCFPOO MNCBDJMAFIF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000256")]
	[Cpp2IlInjected.Address(RVA = "0x7970750", Offset = "0x796F550", VA = "0x187970750", Slot = "13")]
	public NBPGLENHDHN CAOBDEEDIJH(BKMLAJCFPOO MNCBDJMAFIF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000257")]
	[Cpp2IlInjected.Address(RVA = "0x7970810", Offset = "0x796F610", VA = "0x187970810")]
	public POLDBHKMHHJ DKAOHGPCNFM(BKMLAJCFPOO MNCBDJMAFIF, [In] HKDIAHPAMEO JOAPLPPIFPC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000258")]
	[Cpp2IlInjected.Address(RVA = "0x7970C50", Offset = "0x796FA50", VA = "0x187970C50")]
	public LDFDKFJIGHG FBFMJEJPNCG(BKMLAJCFPOO MNCBDJMAFIF, [In] HKDIAHPAMEO JOAPLPPIFPC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000259")]
	[Cpp2IlInjected.Address(RVA = "0x7970620", Offset = "0x796F420", VA = "0x187970620")]
	public LPJPGCAEPHD HOLDGAMPGMH(BKMLAJCFPOO MNCBDJMAFIF, [In] HKDIAHPAMEO JOAPLPPIFPC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600025A")]
	[Cpp2IlInjected.Address(RVA = "0x7970A40", Offset = "0x796F840", VA = "0x187970A40")]
	public MHBMHJOFKAF EBKJHPPJNLI(BKMLAJCFPOO MNCBDJMAFIF, [In] HKDIAHPAMEO JOAPLPPIFPC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600025B")]
	[Cpp2IlInjected.Address(RVA = "0x7970FF0", Offset = "0x796FDF0", VA = "0x187970FF0")]
	public DJFBKMLCAJO JDAHPKIGDAC(BKMLAJCFPOO MNCBDJMAFIF, [In] HKDIAHPAMEO JOAPLPPIFPC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600025C")]
	[Cpp2IlInjected.Address(RVA = "0x7970DE0", Offset = "0x796FBE0", VA = "0x187970DE0", Slot = "19")]
	public BKMLAJCFPOO FIGMNIAKICK(RigidbodyEx EDMNKJJOIJK, HKDIAHPAMEO JOAPLPPIFPC, ODBKIHNADLB HLDNIAJEGKP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600025D")]
	[Cpp2IlInjected.Address(RVA = "0x8FE490", Offset = "0x8FD290", VA = "0x1808FE490")]
	public KICMOKAJIHA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600025E")]
	[Cpp2IlInjected.Address(RVA = "0x7970810", Offset = "0x796F610", VA = "0x187970810", Slot = "14")]
	private POLDBHKMHHJ OIFBNBPJPEJ(BKMLAJCFPOO MNCBDJMAFIF, [In] HKDIAHPAMEO JOAPLPPIFPC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600025F")]
	[Cpp2IlInjected.Address(RVA = "0x7970C50", Offset = "0x796FA50", VA = "0x187970C50", Slot = "15")]
	private LDFDKFJIGHG JAEABDHGJFN(BKMLAJCFPOO MNCBDJMAFIF, [In] HKDIAHPAMEO JOAPLPPIFPC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000260")]
	[Cpp2IlInjected.Address(RVA = "0x7970620", Offset = "0x796F420", VA = "0x187970620", Slot = "16")]
	private LPJPGCAEPHD BHKALOFDPMP(BKMLAJCFPOO MNCBDJMAFIF, [In] HKDIAHPAMEO JOAPLPPIFPC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000261")]
	[Cpp2IlInjected.Address(RVA = "0x7970A40", Offset = "0x796F840", VA = "0x187970A40", Slot = "17")]
	private MHBMHJOFKAF KBNFLBOGDIH(BKMLAJCFPOO MNCBDJMAFIF, [In] HKDIAHPAMEO JOAPLPPIFPC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000262")]
	[Cpp2IlInjected.Address(RVA = "0x7970FF0", Offset = "0x796FDF0", VA = "0x187970FF0", Slot = "18")]
	private DJFBKMLCAJO MFBJPGBBEIJ(BKMLAJCFPOO MNCBDJMAFIF, [In] HKDIAHPAMEO JOAPLPPIFPC)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000027")]
internal sealed class FKCDCCAALBL : NOJNACJJDCN
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000039")]
	private readonly EPBNDOPLGGE EDMNKJJOIJK;

	[Cpp2IlInjected.Token(Token = "0x17000093")]
	private Rigidbody OKMLLKAPHNL
	{
		[Cpp2IlInjected.Token(Token = "0x6000263")]
		[Cpp2IlInjected.Address(RVA = "0x7960E40", Offset = "0x795FC40", VA = "0x187960E40")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000094")]
	private bool JMMCPDFELOG
	{
		[Cpp2IlInjected.Token(Token = "0x6000264")]
		[Cpp2IlInjected.Address(RVA = "0x796A440", Offset = "0x7969240", VA = "0x18796A440")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000095")]
	private bool NKAJLEECCPJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000265")]
		[Cpp2IlInjected.Address(RVA = "0x796A4F0", Offset = "0x79692F0", VA = "0x18796A4F0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000096")]
	private BKMLAJCFPOO LCIGPFKHHMP
	{
		[Cpp2IlInjected.Token(Token = "0x6000266")]
		[Cpp2IlInjected.Address(RVA = "0x796A490", Offset = "0x7969290", VA = "0x18796A490")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000267")]
	[Cpp2IlInjected.Address(RVA = "0x795F4E0", Offset = "0x795E2E0", VA = "0x18795F4E0")]
	public FKCDCCAALBL(BKMLAJCFPOO EDMNKJJOIJK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000268")]
	[Cpp2IlInjected.Address(RVA = "0x796ADF0", Offset = "0x7969BF0", VA = "0x18796ADF0", Slot = "4")]
	public void PGLBLAGLHBK(Vector3 MKKNPGPEIPF, ForceMode PBMLNEJDMIB = ForceMode.Force)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000269")]
	[Cpp2IlInjected.Address(RVA = "0x796A930", Offset = "0x7969730", VA = "0x18796A930")]
	private void MOOOOGEJAKD(Vector3 MKKNPGPEIPF, ForceMode PBMLNEJDMIB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600026A")]
	[Cpp2IlInjected.Address(RVA = "0x796A6B0", Offset = "0x79694B0", VA = "0x18796A6B0", Slot = "5")]
	public void JGMDIHEFGOP(Vector3 MKKNPGPEIPF, Vector3 AKEODPFBHJE, ForceMode PBMLNEJDMIB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600026B")]
	[Cpp2IlInjected.Address(RVA = "0x796A550", Offset = "0x7969350", VA = "0x18796A550", Slot = "6")]
	public void HKABICKGENB(Vector3 FHOLONAELHO, ForceMode PBMLNEJDMIB = ForceMode.Force)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600026C")]
	[Cpp2IlInjected.Address(RVA = "0x796AB90", Offset = "0x7969990", VA = "0x18796AB90")]
	private void NCKCCPAKJHP(Vector3 FHOLONAELHO, ForceMode PBMLNEJDMIB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600026D")]
	[Cpp2IlInjected.Address(RVA = "0x796AF50", Offset = "0x7969D50", VA = "0x18796AF50", Slot = "7")]
	public void PMLDNMMBFDJ(Vector3 FHOLONAELHO, ForceMode PBMLNEJDMIB = ForceMode.Force)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000028")]
internal sealed class ACJDIHFCNKA : NBPGLENHDHN
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400003A")]
	private readonly EPBNDOPLGGE EDMNKJJOIJK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400003B")]
	private bool DDFLCDPPIEG;

	[Cpp2IlInjected.Token(Token = "0x17000097")]
	public bool HBLFKJDMPLJ
	{
		[Cpp2IlInjected.Token(Token = "0x600026F")]
		[Cpp2IlInjected.Address(RVA = "0xBE0400", Offset = "0xBDF200", VA = "0x180BE0400", Slot = "4")]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000270")]
		[Cpp2IlInjected.Address(RVA = "0x795F330", Offset = "0x795E130", VA = "0x18795F330", Slot = "5")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600026E")]
	[Cpp2IlInjected.Address(RVA = "0x795F4E0", Offset = "0x795E2E0", VA = "0x18795F4E0")]
	public ACJDIHFCNKA(BKMLAJCFPOO EDMNKJJOIJK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000271")]
	[Cpp2IlInjected.Address(RVA = "0x795F440", Offset = "0x795E240", VA = "0x18795F440", Slot = "6")]
	public void LPCBHBLKHJO(Rigidbody BFBNFNHBHPL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000272")]
	[Cpp2IlInjected.Address(RVA = "0x795F470", Offset = "0x795E270", VA = "0x18795F470", Slot = "7")]
	public void OCMNAIOEAIB(Rigidbody BFBNFNHBHPL)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000029")]
internal sealed class PCPALFOFDIL : IKDEKIEGKPL, FKBLJPAJLHP, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x4000045")]
	private readonly BKMLAJCFPOO EDMNKJJOIJK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x4000046")]
	private readonly List<BKMLAJCFPOO> PLCCDMAJDKA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x4000047")]
	private BKMLAJCFPOO DOJENPPADJD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x4000048")]
	private BKMLAJCFPOO IFAMCPHMKIP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
	[Cpp2IlInjected.Token(Token = "0x4000049")]
	private Transform LPFCNHOMPKA;

	[Cpp2IlInjected.Token(Token = "0x17000098")]
	private Transform HHEFOFLOCNG
	{
		[Cpp2IlInjected.Token(Token = "0x6000285")]
		[Cpp2IlInjected.Address(RVA = "0x7975130", Offset = "0x7973F30", VA = "0x187975130")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000099")]
	public BKMLAJCFPOO LCIGPFKHHMP
	{
		[Cpp2IlInjected.Token(Token = "0x6000288")]
		[Cpp2IlInjected.Address(RVA = "0x8F4240", Offset = "0x8F3040", VA = "0x1808F4240", Slot = "28")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000289")]
		[Cpp2IlInjected.Address(RVA = "0x7974A50", Offset = "0x7973850", VA = "0x187974A50", Slot = "29")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700009A")]
	public BKMLAJCFPOO DIPIAJCGAGN
	{
		[Cpp2IlInjected.Token(Token = "0x600028A")]
		[Cpp2IlInjected.Address(RVA = "0x8F4450", Offset = "0x8F3250", VA = "0x1808F4450", Slot = "27")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700009B")]
	public IReadOnlyList<BKMLAJCFPOO> OEIFFPONJNA
	{
		[Cpp2IlInjected.Token(Token = "0x600028B")]
		[Cpp2IlInjected.Address(RVA = "0x8FBB10", Offset = "0x8FA910", VA = "0x1808FBB10", Slot = "26")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000021")]
	public event ANKIPNDCANO MKLDCIAADDP
	{
		[Cpp2IlInjected.Token(Token = "0x6000273")]
		[Cpp2IlInjected.Address(RVA = "0x79739B0", Offset = "0x79727B0", VA = "0x1879739B0", Slot = "8")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000274")]
		[Cpp2IlInjected.Address(RVA = "0x7974720", Offset = "0x7973520", VA = "0x187974720", Slot = "9")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000022")]
	public event ANKIPNDCANO LEIJHKAEBAI
	{
		[Cpp2IlInjected.Token(Token = "0x6000275")]
		[Cpp2IlInjected.Address(RVA = "0x7974400", Offset = "0x7973200", VA = "0x187974400", Slot = "10")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000276")]
		[Cpp2IlInjected.Address(RVA = "0x7974900", Offset = "0x7973700", VA = "0x187974900", Slot = "11")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000023")]
	public event JFAIPABNDDB FKKLGGOKJNO
	{
		[Cpp2IlInjected.Token(Token = "0x6000277")]
		[Cpp2IlInjected.Address(RVA = "0x79747C0", Offset = "0x79735C0", VA = "0x1879747C0", Slot = "12")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000278")]
		[Cpp2IlInjected.Address(RVA = "0x7973CF0", Offset = "0x7972AF0", VA = "0x187973CF0", Slot = "13")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000024")]
	public event Action GCKBGMNHICB
	{
		[Cpp2IlInjected.Token(Token = "0x6000279")]
		[Cpp2IlInjected.Address(RVA = "0x7973730", Offset = "0x7972530", VA = "0x187973730", Slot = "14")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600027A")]
		[Cpp2IlInjected.Address(RVA = "0x7974230", Offset = "0x7973030", VA = "0x187974230", Slot = "15")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000025")]
	public event Action JJELANBMAFN
	{
		[Cpp2IlInjected.Token(Token = "0x600027B")]
		[Cpp2IlInjected.Address(RVA = "0x79737D0", Offset = "0x79725D0", VA = "0x1879737D0", Slot = "16")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600027C")]
		[Cpp2IlInjected.Address(RVA = "0x7974860", Offset = "0x7973660", VA = "0x187974860", Slot = "17")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000026")]
	public event Action<BKMLAJCFPOO> NAKCGHNOLLM
	{
		[Cpp2IlInjected.Token(Token = "0x600027D")]
		[Cpp2IlInjected.Address(RVA = "0x7973B00", Offset = "0x7972900", VA = "0x187973B00", Slot = "18")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600027E")]
		[Cpp2IlInjected.Address(RVA = "0x7973A50", Offset = "0x7972850", VA = "0x187973A50", Slot = "19")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000027")]
	public event Action<BKMLAJCFPOO> POEAEOHHEEB
	{
		[Cpp2IlInjected.Token(Token = "0x600027F")]
		[Cpp2IlInjected.Address(RVA = "0x79735D0", Offset = "0x79723D0", VA = "0x1879735D0", Slot = "20")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000280")]
		[Cpp2IlInjected.Address(RVA = "0x7975080", Offset = "0x7973E80", VA = "0x187975080", Slot = "21")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000028")]
	public event Action GMIFAGCGHBJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000281")]
		[Cpp2IlInjected.Address(RVA = "0x7973870", Offset = "0x7972670", VA = "0x187973870", Slot = "22")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000282")]
		[Cpp2IlInjected.Address(RVA = "0x7974FE0", Offset = "0x7973DE0", VA = "0x187974FE0", Slot = "23")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000029")]
	public event Action<BKMLAJCFPOO> CGDEDGDEEFC
	{
		[Cpp2IlInjected.Token(Token = "0x6000283")]
		[Cpp2IlInjected.Address(RVA = "0x79749A0", Offset = "0x79737A0", VA = "0x1879749A0", Slot = "24")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000284")]
		[Cpp2IlInjected.Address(RVA = "0x7973680", Offset = "0x7972480", VA = "0x187973680", Slot = "25")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000286")]
	[Cpp2IlInjected.Address(RVA = "0x7975190", Offset = "0x7973F90", VA = "0x187975190")]
	public PCPALFOFDIL(BKMLAJCFPOO EDMNKJJOIJK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000287")]
	[Cpp2IlInjected.Address(RVA = "0x7973910", Offset = "0x7972710", VA = "0x187973910", Slot = "31")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600028C")]
	[Cpp2IlInjected.Address(RVA = "0x7974A60", Offset = "0x7973860", VA = "0x187974A60", Slot = "30")]
	public void ODEJGNHFANL(BKMLAJCFPOO LBOOKOKCBHL, bool CDNOMBACDJA = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600028D")]
	[Cpp2IlInjected.Address(RVA = "0x7973DD0", Offset = "0x7972BD0", VA = "0x187973DD0", Slot = "6")]
	public void IDPDHKMKKCA(BKMLAJCFPOO CBHPLMNJMDN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600028E")]
	[Cpp2IlInjected.Address(RVA = "0x79744A0", Offset = "0x79732A0", VA = "0x1879744A0", Slot = "7")]
	public void JONGNIBICAO(BKMLAJCFPOO CBHPLMNJMDN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600028F")]
	[Cpp2IlInjected.Address(RVA = "0x7973380", Offset = "0x7972180", VA = "0x187973380", Slot = "4")]
	public void AOEKKHIFAME(BKMLAJCFPOO EDMNKJJOIJK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000290")]
	[Cpp2IlInjected.Address(RVA = "0x7973530", Offset = "0x7972330", VA = "0x187973530", Slot = "5")]
	public void CFPEBBLKGPM(BKMLAJCFPOO EDMNKJJOIJK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000291")]
	[Cpp2IlInjected.Address(RVA = "0x7973490", Offset = "0x7972290", VA = "0x187973490")]
	private void BNCAMMDKGOF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000292")]
	[Cpp2IlInjected.Address(RVA = "0x7973D90", Offset = "0x7972B90", VA = "0x187973D90")]
	private void IADPJODDCNB(BKMLAJCFPOO CBHPLMNJMDN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000293")]
	[Cpp2IlInjected.Address(RVA = "0x7973BB0", Offset = "0x79729B0", VA = "0x187973BB0")]
	private void FNACNMKHMAH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000294")]
	[Cpp2IlInjected.Address(RVA = "0x79742D0", Offset = "0x79730D0", VA = "0x1879742D0")]
	private void JIJKAEMKOEM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000295")]
	[Cpp2IlInjected.Address(RVA = "0x7974100", Offset = "0x7972F00", VA = "0x187974100")]
	private void IMKBKHPEHMJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000296")]
	[Cpp2IlInjected.Address(RVA = "0x7974040", Offset = "0x7972E40", VA = "0x187974040")]
	[CompilerGenerated]
	private object IINPFDCHLAK()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200002A")]
internal static class FPDDEJJHOEL
{
	[Cpp2IlInjected.Token(Token = "0x6000297")]
	[Cpp2IlInjected.Address(RVA = "0x796B1B0", Offset = "0x7969FB0", VA = "0x18796B1B0")]
	public static IKDEKIEGKPL BADMGIIJNGK(this BKMLAJCFPOO MNCBDJMAFIF)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200002B")]
internal sealed class OLMDHGENDJI : OAIMLNHLLPF, GENBFDOKDMJ
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400004A")]
	private readonly EPBNDOPLGGE EDMNKJJOIJK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400004B")]
	private readonly IBPJDCCBOAD<BKMLAJCFPOO> CPEGJFPCMGB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400004C")]
	private bool BCCCGJMHELF;

	[Cpp2IlInjected.Token(Token = "0x1700009C")]
	public IBPJDCCBOAD<BKMLAJCFPOO> MHGPGKAFBID
	{
		[Cpp2IlInjected.Token(Token = "0x6000298")]
		[Cpp2IlInjected.Address(RVA = "0x8F4430", Offset = "0x8F3230", VA = "0x1808F4430", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700009D")]
	public Vector3 DGPEONCCLJP
	{
		[Cpp2IlInjected.Token(Token = "0x6000299")]
		[Cpp2IlInjected.Address(RVA = "0x7973250", Offset = "0x7972050", VA = "0x187973250", Slot = "6")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700009E")]
	public Vector3 KJNCOIBLPBH
	{
		[Cpp2IlInjected.Token(Token = "0x600029A")]
		[Cpp2IlInjected.Address(RVA = "0x79726E0", Offset = "0x79714E0", VA = "0x1879726E0", Slot = "7")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700009F")]
	private Vector3 LEFKCANEDPG
	{
		[Cpp2IlInjected.Token(Token = "0x600029E")]
		[Cpp2IlInjected.Address(RVA = "0x7972DE0", Offset = "0x7971BE0", VA = "0x187972DE0")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A0")]
	public BKMLAJCFPOO ADPBPJBCJON
	{
		[Cpp2IlInjected.Token(Token = "0x600029F")]
		[Cpp2IlInjected.Address(RVA = "0x79725C0", Offset = "0x79713C0", VA = "0x1879725C0", Slot = "5")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600029B")]
	[Cpp2IlInjected.Address(RVA = "0x7973280", Offset = "0x7972080", VA = "0x187973280")]
	public OLMDHGENDJI(BKMLAJCFPOO EDMNKJJOIJK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600029C")]
	[Cpp2IlInjected.Address(RVA = "0x7972670", Offset = "0x7971470", VA = "0x187972670", Slot = "8")]
	public void BFDPOFDIFHP(BKMLAJCFPOO IFAMCPHMKIP, object HACFGBHNOCC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600029D")]
	[Cpp2IlInjected.Address(RVA = "0x79729E0", Offset = "0x79717E0", VA = "0x1879729E0", Slot = "9")]
	public void CEBLPEAMCFP(object HACFGBHNOCC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002A0")]
	[Cpp2IlInjected.Address(RVA = "0x7972A40", Offset = "0x7971840", VA = "0x187972A40")]
	private Vector3 CMLMHLPADIO()
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x60002A1")]
	[Cpp2IlInjected.Address(RVA = "0x7972EC0", Offset = "0x7971CC0", VA = "0x187972EC0")]
	private void JAFCJFFENLD(BKMLAJCFPOO IDIECMCCICB)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002C")]
internal static class PIJKMOPIKII
{
	[Cpp2IlInjected.Token(Token = "0x60002A2")]
	[Cpp2IlInjected.Address(RVA = "0x7975250", Offset = "0x7974050", VA = "0x187975250")]
	public static OAIMLNHLLPF PBPADNCPABG(this BKMLAJCFPOO MNCBDJMAFIF)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200002D")]
internal sealed class FBHLMDJAINA : CMKEMNJPHDD, MHBMHJOFKAF
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400004E")]
	private readonly EPBNDOPLGGE EDMNKJJOIJK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400004F")]
	private readonly OverridableVector3 GJBMPLJHKOL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000050")]
	private readonly OverridableVector3 IHNNMMEJCGH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000051")]
	private float EPBICGONCPE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x44")]
	[Cpp2IlInjected.Token(Token = "0x4000052")]
	private float EAFBCACBELB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000053")]
	private Vector3 KJICILJFPNL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x54")]
	[Cpp2IlInjected.Token(Token = "0x4000054")]
	private Vector3? EDOCJKBEENH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x64")]
	[Cpp2IlInjected.Token(Token = "0x4000055")]
	private Quaternion? BHKBJKMFMDA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
	[Cpp2IlInjected.Token(Token = "0x4000056")]
	private bool HIAHFBINBEH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x79")]
	[Cpp2IlInjected.Token(Token = "0x4000057")]
	private bool IFNFKOIOHGJ;

	[Cpp2IlInjected.Token(Token = "0x170000A1")]
	public Vector3 MCNHMKCPMCP
	{
		[Cpp2IlInjected.Token(Token = "0x60002A5")]
		[Cpp2IlInjected.Address(RVA = "0x13F8EA0", Offset = "0x13F7CA0", VA = "0x1813F8EA0", Slot = "7")]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x60002A6")]
		[Cpp2IlInjected.Address(RVA = "0x7967E90", Offset = "0x7966C90", VA = "0x187967E90", Slot = "8")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A2")]
	public Vector3 MDDJDOBAIIM
	{
		[Cpp2IlInjected.Token(Token = "0x60002A7")]
		[Cpp2IlInjected.Address(RVA = "0x7968170", Offset = "0x7966F70", VA = "0x187968170", Slot = "9")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A3")]
	public float GBFCDAFMDLO
	{
		[Cpp2IlInjected.Token(Token = "0x60002A8")]
		[Cpp2IlInjected.Address(RVA = "0xBA9F50", Offset = "0xBA8D50", VA = "0x180BA9F50", Slot = "10")]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x60002A9")]
		[Cpp2IlInjected.Address(RVA = "0x7969B20", Offset = "0x7968920", VA = "0x187969B20")]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A4")]
	public float OKMBPDCAAGG
	{
		[Cpp2IlInjected.Token(Token = "0x60002AA")]
		[Cpp2IlInjected.Address(RVA = "0xAC8400", Offset = "0xAC7200", VA = "0x180AC8400", Slot = "11")]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x60002AB")]
		[Cpp2IlInjected.Address(RVA = "0x7967CF0", Offset = "0x7966AF0", VA = "0x187967CF0", Slot = "12")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A5")]
	public Vector3 MCDNADKMFKJ
	{
		[Cpp2IlInjected.Token(Token = "0x60002AC")]
		[Cpp2IlInjected.Address(RVA = "0x7967FE0", Offset = "0x7966DE0", VA = "0x187967FE0", Slot = "13")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A6")]
	public Quaternion AIGDBJBCJDE
	{
		[Cpp2IlInjected.Token(Token = "0x60002AD")]
		[Cpp2IlInjected.Address(RVA = "0x7969E00", Offset = "0x7968C00", VA = "0x187969E00", Slot = "14")]
		get
		{
			return default(Quaternion);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A7")]
	private Rigidbody OKMLLKAPHNL
	{
		[Cpp2IlInjected.Token(Token = "0x60002B5")]
		[Cpp2IlInjected.Address(RVA = "0x7967E40", Offset = "0x7966C40", VA = "0x187967E40")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400002A")]
	public event ANKIPNDCANO KHNEOMEELGO
	{
		[Cpp2IlInjected.Token(Token = "0x60002A3")]
		[Cpp2IlInjected.Address(RVA = "0x7967F40", Offset = "0x7966D40", VA = "0x187967F40", Slot = "5")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60002A4")]
		[Cpp2IlInjected.Address(RVA = "0x7967DA0", Offset = "0x7966BA0", VA = "0x187967DA0", Slot = "6")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60002AE")]
	[Cpp2IlInjected.Address(RVA = "0x796A2E0", Offset = "0x79690E0", VA = "0x18796A2E0")]
	public FBHLMDJAINA(BKMLAJCFPOO EDMNKJJOIJK, [In] HKDIAHPAMEO JOAPLPPIFPC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002AF")]
	[Cpp2IlInjected.Address(RVA = "0x79690D0", Offset = "0x7967ED0", VA = "0x1879690D0", Slot = "17")]
	public void EGIHCPCAFBE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002B0")]
	[Cpp2IlInjected.Address(RVA = "0x7969420", Offset = "0x7968220", VA = "0x187969420", Slot = "16")]
	public void FAHHJFPOHIJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002B1")]
	[Cpp2IlInjected.Address(RVA = "0x7969D20", Offset = "0x7968B20", VA = "0x187969D20", Slot = "19")]
	public void LPCBHBLKHJO(Rigidbody BFBNFNHBHPL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002B2")]
	[Cpp2IlInjected.Address(RVA = "0x7969F80", Offset = "0x7968D80", VA = "0x187969F80", Slot = "20")]
	public void OCMNAIOEAIB(Rigidbody BFBNFNHBHPL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002B3")]
	[Cpp2IlInjected.Address(RVA = "0x7969500", Offset = "0x7968300", VA = "0x187969500", Slot = "18")]
	public void FCBHEDAOLDB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002B4")]
	[Cpp2IlInjected.Address(RVA = "0x79696A0", Offset = "0x79684A0", VA = "0x1879696A0", Slot = "21")]
	public void GLCKBHAHEJI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002B6")]
	[Cpp2IlInjected.Address(RVA = "0x7967E90", Offset = "0x7966C90", VA = "0x187967E90")]
	private void CDHNAJMIOPM(Vector3 IPHILEOFJLB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002B7")]
	[Cpp2IlInjected.Address(RVA = "0x7969C30", Offset = "0x7968A30", VA = "0x187969C30")]
	[Obsolete("This method is dangerous - the unity rigidbody is updated in a deferred manner and this world position may be stale")]
	private Vector3 LBLAJMGLBOA()
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x60002B8")]
	[Cpp2IlInjected.Address(RVA = "0x7969B20", Offset = "0x7968920", VA = "0x187969B20")]
	private void KLPPPGMLPEM(float IPHILEOFJLB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002B9")]
	[Cpp2IlInjected.Address(RVA = "0x7967CF0", Offset = "0x7966AF0", VA = "0x187967CF0")]
	private void BBIDLKEGANG(float IPHILEOFJLB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002BA")]
	[Cpp2IlInjected.Address(RVA = "0x7969280", Offset = "0x7968080", VA = "0x187969280")]
	private Vector3 ENPKBHDOPNB()
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x60002BB")]
	[Cpp2IlInjected.Address(RVA = "0x7967AC0", Offset = "0x79668C0", VA = "0x187967AC0", Slot = "15")]
	public void ABCJBEHKOHN((Quaternion rot, Vector3 moments) IEKPANIOKCJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002BC")]
	[Cpp2IlInjected.Address(RVA = "0x796A160", Offset = "0x7968F60", VA = "0x18796A160")]
	private Quaternion PJHCBEFFAIE()
	{
		return default(Quaternion);
	}

	[Cpp2IlInjected.Token(Token = "0x60002BD")]
	[Cpp2IlInjected.Address(RVA = "0x7969000", Offset = "0x7967E00", VA = "0x187969000")]
	public void EGFJOLAAEHJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002BE")]
	[Cpp2IlInjected.Address(RVA = "0x7968260", Offset = "0x7967060", VA = "0x187968260", Slot = "4")]
	public (float, Vector3) EGFJOLAAEHJ(Rigidbody OIOPPILBEEE)
	{
		return default((float, Vector3));
	}
}
[Cpp2IlInjected.Token(Token = "0x200002E")]
internal static class EFALKGPHGHB
{
	[Cpp2IlInjected.Token(Token = "0x60002BF")]
	[Cpp2IlInjected.Address(RVA = "0x7961210", Offset = "0x7960010", VA = "0x187961210")]
	public static CMKEMNJPHDD NKCAFHCBIOP(this BKMLAJCFPOO MNCBDJMAFIF)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200002F")]
internal sealed class JFHNLCODNHI : LPJPGCAEPHD
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000058")]
	private readonly EPBNDOPLGGE EDMNKJJOIJK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000059")]
	private readonly LKPBNFNIBPJ NBICDMMKHBI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400005A")]
	private readonly OAPFEGBJMCF NOODLEOBFGB;

	[Cpp2IlInjected.Token(Token = "0x170000A8")]
	public bool NADKALIKNIK
	{
		[Cpp2IlInjected.Token(Token = "0x60002C0")]
		[Cpp2IlInjected.Address(RVA = "0x1580DC0", Offset = "0x157FBC0", VA = "0x181580DC0", Slot = "10")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A9")]
	public OAPFEGBJMCF MNHPJOBJFEN
	{
		[Cpp2IlInjected.Token(Token = "0x60002C1")]
		[Cpp2IlInjected.Address(RVA = "0xAB5DD0", Offset = "0xAB4BD0", VA = "0x180AB5DD0", Slot = "11")]
		get
		{
			return default(OAPFEGBJMCF);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60002C2")]
	[Cpp2IlInjected.Address(RVA = "0x796FAE0", Offset = "0x796E8E0", VA = "0x18796FAE0")]
	public JFHNLCODNHI(BKMLAJCFPOO EDMNKJJOIJK, [In] HKDIAHPAMEO JOAPLPPIFPC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002C3")]
	[Cpp2IlInjected.Address(RVA = "0x796FA10", Offset = "0x796E810", VA = "0x18796FA10", Slot = "4")]
	public void NLNNABDBLFO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002C4")]
	[Cpp2IlInjected.Address(RVA = "0x796F970", Offset = "0x796E770", VA = "0x18796F970")]
	private bool MAKNAPIBFPJ()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002C5")]
	[Cpp2IlInjected.Address(RVA = "0x796F780", Offset = "0x796E580", VA = "0x18796F780", Slot = "5")]
	public void ICNLMLCJCII(object HACFGBHNOCC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002C6")]
	[Cpp2IlInjected.Address(RVA = "0x796F610", Offset = "0x796E410", VA = "0x18796F610", Slot = "6")]
	public void GFANLMAHHDC(object HACFGBHNOCC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002C7")]
	[Cpp2IlInjected.Address(RVA = "0x796F640", Offset = "0x796E440", VA = "0x18796F640", Slot = "9")]
	public void HHOFDIAHGEL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002C8")]
	[Cpp2IlInjected.Address(RVA = "0x796F4B0", Offset = "0x796E2B0", VA = "0x18796F4B0")]
	private void ANHENOJNJMN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002C9")]
	[Cpp2IlInjected.Address(RVA = "0x796F7F0", Offset = "0x796E5F0", VA = "0x18796F7F0")]
	private void KNMNAADCMKI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002CA")]
	[Cpp2IlInjected.Address(RVA = "0x796F5D0", Offset = "0x796E3D0", VA = "0x18796F5D0", Slot = "8")]
	public void CDCEEAOPCFB(BKMLAJCFPOO EDMNKJJOIJK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002CB")]
	[Cpp2IlInjected.Address(RVA = "0x796F7B0", Offset = "0x796E5B0", VA = "0x18796F7B0", Slot = "7")]
	public void JAEBCPEJOAK(BKMLAJCFPOO EDMNKJJOIJK)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000030")]
internal sealed class HMPBIFCGIDF : LIIPPALMDAB
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400005C")]
	private readonly EPBNDOPLGGE EDMNKJJOIJK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400005D")]
	private readonly LKPBNFNIBPJ AOIGOOBPPHB;

	[Cpp2IlInjected.Token(Token = "0x170000AA")]
	public bool JMMCPDFELOG
	{
		[Cpp2IlInjected.Token(Token = "0x60002CE")]
		[Cpp2IlInjected.Address(RVA = "0x796ECE0", Offset = "0x796DAE0", VA = "0x18796ECE0", Slot = "6")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400002B")]
	public event ANKIPNDCANO EOCIGPOJEAJ
	{
		[Cpp2IlInjected.Token(Token = "0x60002CC")]
		[Cpp2IlInjected.Address(RVA = "0x796EDA0", Offset = "0x796DBA0", VA = "0x18796EDA0", Slot = "4")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60002CD")]
		[Cpp2IlInjected.Address(RVA = "0x796F010", Offset = "0x796DE10", VA = "0x18796F010", Slot = "5")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60002CF")]
	[Cpp2IlInjected.Address(RVA = "0x796F0F0", Offset = "0x796DEF0", VA = "0x18796F0F0")]
	public HMPBIFCGIDF(BKMLAJCFPOO EDMNKJJOIJK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002D0")]
	[Cpp2IlInjected.Address(RVA = "0x796F0B0", Offset = "0x796DEB0", VA = "0x18796F0B0", Slot = "7")]
	public void NDNHLHKLAJO(object HACFGBHNOCC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002D1")]
	[Cpp2IlInjected.Address(RVA = "0x796ED90", Offset = "0x796DB90", VA = "0x18796ED90", Slot = "8")]
	public void DHHHJHJJACF(object HACFGBHNOCC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002D2")]
	[Cpp2IlInjected.Address(RVA = "0x796EE40", Offset = "0x796DC40", VA = "0x18796EE40", Slot = "9")]
	public void LFKMFFNIBNF(object HACFGBHNOCC, bool AFBCKAHGIKH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002D3")]
	[Cpp2IlInjected.Address(RVA = "0x796EF50", Offset = "0x796DD50", VA = "0x18796EF50", Slot = "12")]
	public void LNOJMPJKPOC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002D4")]
	[Cpp2IlInjected.Address(RVA = "0x796EF90", Offset = "0x796DD90", VA = "0x18796EF90", Slot = "10")]
	public void LPCBHBLKHJO(Rigidbody IDAFMFPGOAC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002D5")]
	[Cpp2IlInjected.Address(RVA = "0x796F0C0", Offset = "0x796DEC0", VA = "0x18796F0C0", Slot = "11")]
	public void OCMNAIOEAIB(Rigidbody BFBNFNHBHPL)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000031")]
internal sealed class DMJJPMPOPBM : JIIFIOPJLAH, LDFDKFJIGHG, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400005F")]
	private readonly EPBNDOPLGGE EDMNKJJOIJK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000060")]
	private PhotonView CCGHOCGLGEA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000061")]
	private bool LMONJJHPFDI;

	[Cpp2IlInjected.Token(Token = "0x170000AB")]
	public PhotonView EIGGDCHEJIP
	{
		[Cpp2IlInjected.Token(Token = "0x60002D8")]
		[Cpp2IlInjected.Address(RVA = "0x8F7B20", Offset = "0x8F6920", VA = "0x1808F7B20", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000AC")]
	public bool FIPIKFDPMLE
	{
		[Cpp2IlInjected.Token(Token = "0x60002D9")]
		[Cpp2IlInjected.Address(RVA = "0x7960540", Offset = "0x795F340", VA = "0x187960540", Slot = "7")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000AD")]
	public bool DDHKLPODPHG
	{
		[Cpp2IlInjected.Token(Token = "0x60002DA")]
		[Cpp2IlInjected.Address(RVA = "0xCA2000", Offset = "0xCA0E00", VA = "0x180CA2000", Slot = "8")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400002C")]
	public event ANKIPNDCANO ALHCADIFMCB
	{
		[Cpp2IlInjected.Token(Token = "0x60002D6")]
		[Cpp2IlInjected.Address(RVA = "0x7960560", Offset = "0x795F360", VA = "0x187960560", Slot = "5")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60002D7")]
		[Cpp2IlInjected.Address(RVA = "0x79600C0", Offset = "0x795EEC0", VA = "0x1879600C0", Slot = "6")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60002DB")]
	[Cpp2IlInjected.Address(RVA = "0x79608A0", Offset = "0x795F6A0", VA = "0x1879608A0")]
	public DMJJPMPOPBM(BKMLAJCFPOO EDMNKJJOIJK, [In] HKDIAHPAMEO JOAPLPPIFPC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002DC")]
	[Cpp2IlInjected.Address(RVA = "0x7960770", Offset = "0x795F570", VA = "0x187960770", Slot = "9")]
	public void NLNNABDBLFO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002DD")]
	[Cpp2IlInjected.Address(RVA = "0x7960160", Offset = "0x795EF60", VA = "0x187960160", Slot = "12")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002DE")]
	[Cpp2IlInjected.Address(RVA = "0x79603D0", Offset = "0x795F1D0", VA = "0x1879603D0", Slot = "10")]
	public void IOPBIMOFKHN(BKMLAJCFPOO IFAMCPHMKIP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002DF")]
	[Cpp2IlInjected.Address(RVA = "0x7960600", Offset = "0x795F400", VA = "0x187960600", Slot = "11")]
	public void NLBLLKCJHNE(BKMLAJCFPOO IFAMCPHMKIP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002E0")]
	[Cpp2IlInjected.Address(RVA = "0x7960260", Offset = "0x795F060", VA = "0x187960260")]
	private void IOOKGLGPBJH(PhotonView ILFDMPFPHJI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002E1")]
	[Cpp2IlInjected.Address(RVA = "0x795FD00", Offset = "0x795EB00", VA = "0x18795FD00")]
	private void AMIOGAMCAGL(FHDFMCFBJMM CAGNMBEDNCH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002E2")]
	[Cpp2IlInjected.Address(RVA = "0x795FE50", Offset = "0x795EC50", VA = "0x18795FE50")]
	private void BPPHABHCCEP(PhotonView FIDAIHBDCJA)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000032")]
internal static class JKGMMINAIBP
{
	[Cpp2IlInjected.Token(Token = "0x60002E3")]
	[Cpp2IlInjected.Address(RVA = "0x796FBE0", Offset = "0x796E9E0", VA = "0x18796FBE0")]
	public static JIIFIOPJLAH LLJKLCOBIAE(this BKMLAJCFPOO MNCBDJMAFIF)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000033")]
internal sealed class NCJEEHMKMAG : DJFBKMLCAJO
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000062")]
	private readonly EPBNDOPLGGE EDMNKJJOIJK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000063")]
	private RigidbodyConstraints FPMNJBFKPFN;

	[Cpp2IlInjected.Token(Token = "0x170000AE")]
	public bool NJLANIHBHFG
	{
		[Cpp2IlInjected.Token(Token = "0x60002E4")]
		[Cpp2IlInjected.Address(RVA = "0xAF38A0", Offset = "0xAF26A0", VA = "0x180AF38A0", Slot = "4")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x60002E5")]
		[Cpp2IlInjected.Address(RVA = "0xBD7AD0", Offset = "0xBD68D0", VA = "0x180BD7AD0", Slot = "5")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000AF")]
	public bool BKLJLLPLMOI
	{
		[Cpp2IlInjected.Token(Token = "0x60002E6")]
		[Cpp2IlInjected.Address(RVA = "0xBD7AB0", Offset = "0xBD68B0", VA = "0x180BD7AB0", Slot = "6")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x60002E7")]
		[Cpp2IlInjected.Address(RVA = "0xBD7C90", Offset = "0xBD6A90", VA = "0x180BD7C90")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B0")]
	public RigidbodyConstraints AHGDGGBFJJC
	{
		[Cpp2IlInjected.Token(Token = "0x60002E8")]
		[Cpp2IlInjected.Address(RVA = "0x8FAE20", Offset = "0x8F9C20", VA = "0x1808FAE20", Slot = "7")]
		get
		{
			return default(RigidbodyConstraints);
		}
		[Cpp2IlInjected.Token(Token = "0x60002E9")]
		[Cpp2IlInjected.Address(RVA = "0x7972390", Offset = "0x7971190", VA = "0x187972390", Slot = "8")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60002EA")]
	[Cpp2IlInjected.Address(RVA = "0x7972520", Offset = "0x7971320", VA = "0x187972520")]
	public NCJEEHMKMAG(BKMLAJCFPOO EDMNKJJOIJK, [In] HKDIAHPAMEO JOAPLPPIFPC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002EB")]
	[Cpp2IlInjected.Address(RVA = "0x79724C0", Offset = "0x79712C0", VA = "0x1879724C0", Slot = "9")]
	public void LPCBHBLKHJO(Rigidbody BFBNFNHBHPL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002EC")]
	[Cpp2IlInjected.Address(RVA = "0x79724F0", Offset = "0x79712F0", VA = "0x1879724F0", Slot = "10")]
	public void OCMNAIOEAIB(Rigidbody BFBNFNHBHPL)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000034")]
internal sealed class IACAJJCBMBO : MOAMEMFPAHE
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000066")]
	private readonly BKMLAJCFPOO EDMNKJJOIJK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000067")]
	private float HCEIMKNAAFE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
	[Cpp2IlInjected.Token(Token = "0x4000068")]
	private float GBAJHMLCMJB;

	[Cpp2IlInjected.Token(Token = "0x170000B1")]
	public float DBFJKFPLEDB
	{
		[Cpp2IlInjected.Token(Token = "0x60002EE")]
		[Cpp2IlInjected.Address(RVA = "0xD9F810", Offset = "0xD9E610", VA = "0x180D9F810", Slot = "4")]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x60002EF")]
		[Cpp2IlInjected.Address(RVA = "0x796F2B0", Offset = "0x796E0B0", VA = "0x18796F2B0", Slot = "5")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B2")]
	public float OMKMLLDNDHH
	{
		[Cpp2IlInjected.Token(Token = "0x60002F0")]
		[Cpp2IlInjected.Address(RVA = "0xBF1C10", Offset = "0xBF0A10", VA = "0x180BF1C10", Slot = "6")]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x60002F1")]
		[Cpp2IlInjected.Address(RVA = "0x796F1E0", Offset = "0x796DFE0", VA = "0x18796F1E0", Slot = "7")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60002ED")]
	[Cpp2IlInjected.Address(RVA = "0x796F470", Offset = "0x796E270", VA = "0x18796F470")]
	public IACAJJCBMBO(BKMLAJCFPOO EDMNKJJOIJK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002F2")]
	[Cpp2IlInjected.Address(RVA = "0x796F380", Offset = "0x796E180", VA = "0x18796F380", Slot = "8")]
	public void LPCBHBLKHJO(Rigidbody BFBNFNHBHPL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002F3")]
	[Cpp2IlInjected.Address(RVA = "0x796F3D0", Offset = "0x796E1D0", VA = "0x18796F3D0", Slot = "9")]
	public void OCMNAIOEAIB(Rigidbody BFBNFNHBHPL)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000035")]
internal sealed class KNPOGNILKGH : EPCLGGKOKDH
{
	[Cpp2IlInjected.Token(Token = "0x4000069")]
	private static readonly IMOCAMGHNDM LMICEFINHAA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400006B")]
	private readonly EPBNDOPLGGE EDMNKJJOIJK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400006C")]
	private bool OEIPJDEJADD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x21")]
	[Cpp2IlInjected.Token(Token = "0x400006D")]
	private bool NPKFCCDCNCK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
	[Cpp2IlInjected.Token(Token = "0x400006E")]
	private int NLIANNKPGCF;

	[Cpp2IlInjected.Token(Token = "0x170000B3")]
	private Rigidbody OKMLLKAPHNL
	{
		[Cpp2IlInjected.Token(Token = "0x60002F6")]
		[Cpp2IlInjected.Address(RVA = "0x7967E40", Offset = "0x7966C40", VA = "0x187967E40")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B4")]
	private bool EGGFDCIMFFJ
	{
		[Cpp2IlInjected.Token(Token = "0x60002F7")]
		[Cpp2IlInjected.Address(RVA = "0x7971CC0", Offset = "0x7970AC0", VA = "0x187971CC0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B5")]
	private BKMLAJCFPOO LCIGPFKHHMP
	{
		[Cpp2IlInjected.Token(Token = "0x60002F8")]
		[Cpp2IlInjected.Address(RVA = "0x7971900", Offset = "0x7970700", VA = "0x187971900")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B6")]
	private bool NKAJLEECCPJ
	{
		[Cpp2IlInjected.Token(Token = "0x60002F9")]
		[Cpp2IlInjected.Address(RVA = "0x7971960", Offset = "0x7970760", VA = "0x187971960")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400002D")]
	public event ANKIPNDCANO CKAOMBCKJPE
	{
		[Cpp2IlInjected.Token(Token = "0x60002F4")]
		[Cpp2IlInjected.Address(RVA = "0x79717C0", Offset = "0x79705C0", VA = "0x1879717C0", Slot = "4")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60002F5")]
		[Cpp2IlInjected.Address(RVA = "0x7971A40", Offset = "0x7970840", VA = "0x187971A40", Slot = "5")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60002FA")]
	[Cpp2IlInjected.Address(RVA = "0x7972180", Offset = "0x7970F80", VA = "0x187972180")]
	public KNPOGNILKGH(BKMLAJCFPOO EDMNKJJOIJK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002FB")]
	[Cpp2IlInjected.Address(RVA = "0x7971F30", Offset = "0x7970D30", VA = "0x187971F30", Slot = "6")]
	public void NLNNABDBLFO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002FC")]
	[Cpp2IlInjected.Address(RVA = "0x7971A30", Offset = "0x7970830", VA = "0x187971A30", Slot = "8")]
	public void FFKDECLHCFA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002FD")]
	[Cpp2IlInjected.Address(RVA = "0x79715D0", Offset = "0x79703D0", VA = "0x1879715D0", Slot = "7")]
	public bool ABCPKPFAHNI()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002FE")]
	[Cpp2IlInjected.Address(RVA = "0x7971860", Offset = "0x7970660", VA = "0x187971860", Slot = "9")]
	public void BFHIJDILBDB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002FF")]
	[Cpp2IlInjected.Address(RVA = "0x7971720", Offset = "0x7970520", VA = "0x187971720", Slot = "13")]
	public void ACKEKMFONNI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000300")]
	[Cpp2IlInjected.Address(RVA = "0x7971FC0", Offset = "0x7970DC0", VA = "0x187971FC0", Slot = "12")]
	public void OEDPDHEENEL(bool KCKMIPNLKFF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000301")]
	[Cpp2IlInjected.Address(RVA = "0x79719C0", Offset = "0x79707C0", VA = "0x1879719C0", Slot = "10")]
	public bool EMJIFDEHGCD()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000302")]
	[Cpp2IlInjected.Address(RVA = "0x7971CE0", Offset = "0x7970AE0", VA = "0x187971CE0", Slot = "11")]
	public bool HNOEAPKGKHM()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000303")]
	[Cpp2IlInjected.Address(RVA = "0x7971AE0", Offset = "0x79708E0", VA = "0x187971AE0")]
	private bool FLCLNINCOMJ()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000304")]
	[Cpp2IlInjected.Address(RVA = "0x7971DA0", Offset = "0x7970BA0", VA = "0x187971DA0")]
	private void KHFFBBHHHOL()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000036")]
internal sealed class KDNDLJDGFPB : POLDBHKMHHJ
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400006F")]
	private readonly EPBNDOPLGGE EDMNKJJOIJK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000070")]
	private readonly LKPBNFNIBPJ PLMDNNFJJJK;

	[Cpp2IlInjected.Token(Token = "0x170000B7")]
	public Rigidbody OKMLLKAPHNL
	{
		[Cpp2IlInjected.Token(Token = "0x6000306")]
		[Cpp2IlInjected.Address(RVA = "0x8F7B20", Offset = "0x8F6920", VA = "0x1808F7B20", Slot = "4")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000307")]
		[Cpp2IlInjected.Address(RVA = "0x8F7B10", Offset = "0x8F6910", VA = "0x1808F7B10")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B8")]
	private bool NKAJLEECCPJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000308")]
		[Cpp2IlInjected.Address(RVA = "0x796A4F0", Offset = "0x79692F0", VA = "0x18796A4F0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B9")]
	public bool NCKKLLLKCDO
	{
		[Cpp2IlInjected.Token(Token = "0x600030B")]
		[Cpp2IlInjected.Address(RVA = "0x1580DC0", Offset = "0x157FBC0", VA = "0x181580DC0", Slot = "6")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000309")]
	[Cpp2IlInjected.Address(RVA = "0x7970440", Offset = "0x796F240", VA = "0x187970440")]
	public KDNDLJDGFPB(BKMLAJCFPOO EDMNKJJOIJK, [In] HKDIAHPAMEO JOAPLPPIFPC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600030A")]
	[Cpp2IlInjected.Address(RVA = "0x7970070", Offset = "0x796EE70", VA = "0x187970070", Slot = "5")]
	public void NLNNABDBLFO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600030C")]
	[Cpp2IlInjected.Address(RVA = "0x796FE90", Offset = "0x796EC90", VA = "0x18796FE90", Slot = "7")]
	public void DMCOGFFPGPE(object HACFGBHNOCC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600030D")]
	[Cpp2IlInjected.Address(RVA = "0x796FEC0", Offset = "0x796ECC0", VA = "0x18796FEC0", Slot = "8")]
	public void GNBBEKCJFMA(object HACFGBHNOCC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600030E")]
	[Cpp2IlInjected.Address(RVA = "0x7970110", Offset = "0x796EF10", VA = "0x187970110", Slot = "9")]
	public void OENJOKFMDDN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600030F")]
	[Cpp2IlInjected.Address(RVA = "0x796FCA0", Offset = "0x796EAA0", VA = "0x18796FCA0", Slot = "10")]
	public void AFILIOHFFGO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000310")]
	[Cpp2IlInjected.Address(RVA = "0x796FEF0", Offset = "0x796ECF0", VA = "0x18796FEF0", Slot = "11")]
	public void JPPHCIHEJCD()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000037")]
internal sealed class GFGLKFFOAEJ : EFAKGJHIOBO, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000072")]
	private readonly EPBNDOPLGGE EDMNKJJOIJK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000073")]
	private readonly LKPBNFNIBPJ PNGKBJLFEDD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000074")]
	private float DLNNFHKAMLO;

	[Cpp2IlInjected.Token(Token = "0x170000BA")]
	public OIIFFMGENDA NDGKBOLHLFO
	{
		[Cpp2IlInjected.Token(Token = "0x6000311")]
		[Cpp2IlInjected.Address(RVA = "0x8F41F0", Offset = "0x8F2FF0", VA = "0x1808F41F0", Slot = "4")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000312")]
		[Cpp2IlInjected.Address(RVA = "0x8F7B40", Offset = "0x8F6940", VA = "0x1808F7B40", Slot = "5")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000BB")]
	public PEHCDIDIDFL HADAHAKIAGP
	{
		[Cpp2IlInjected.Token(Token = "0x6000313")]
		[Cpp2IlInjected.Address(RVA = "0x8F4270", Offset = "0x8F3070", VA = "0x1808F4270", Slot = "6")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000314")]
		[Cpp2IlInjected.Address(RVA = "0x8F7B30", Offset = "0x8F6930", VA = "0x1808F7B30", Slot = "7")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000BC")]
	public Vector3 LEFKCANEDPG
	{
		[Cpp2IlInjected.Token(Token = "0x6000315")]
		[Cpp2IlInjected.Address(RVA = "0x796BEB0", Offset = "0x796ACB0", VA = "0x18796BEB0", Slot = "8")]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x6000316")]
		[Cpp2IlInjected.Address(RVA = "0x796EB30", Offset = "0x796D930", VA = "0x18796EB30", Slot = "9")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000BD")]
	public Vector3 AMLMBHHAEJE
	{
		[Cpp2IlInjected.Token(Token = "0x6000317")]
		[Cpp2IlInjected.Address(RVA = "0x796D360", Offset = "0x796C160", VA = "0x18796D360", Slot = "10")]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x6000318")]
		[Cpp2IlInjected.Address(RVA = "0x796D4E0", Offset = "0x796C2E0", VA = "0x18796D4E0", Slot = "11")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000BE")]
	public Vector3 KHNLNENPKFO
	{
		[Cpp2IlInjected.Token(Token = "0x6000319")]
		[Cpp2IlInjected.Address(RVA = "0x796D9D0", Offset = "0x796C7D0", VA = "0x18796D9D0", Slot = "12")]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x600031A")]
		[Cpp2IlInjected.Address(RVA = "0x796B530", Offset = "0x796A330", VA = "0x18796B530", Slot = "13")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000BF")]
	public Vector3 GDFIBLLIEJO
	{
		[Cpp2IlInjected.Token(Token = "0x600031B")]
		[Cpp2IlInjected.Address(RVA = "0x796BAC0", Offset = "0x796A8C0", VA = "0x18796BAC0", Slot = "14")]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x600031C")]
		[Cpp2IlInjected.Address(RVA = "0x796B790", Offset = "0x796A590", VA = "0x18796B790", Slot = "15")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000C0")]
	public float PGGIFJBJEHC
	{
		[Cpp2IlInjected.Token(Token = "0x600031D")]
		[Cpp2IlInjected.Address(RVA = "0xEB2C30", Offset = "0xEB1A30", VA = "0x180EB2C30", Slot = "16")]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x600031E")]
		[Cpp2IlInjected.Address(RVA = "0x796B950", Offset = "0x796A750", VA = "0x18796B950", Slot = "17")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000C1")]
	public bool FFNKJNLOBKO
	{
		[Cpp2IlInjected.Token(Token = "0x600031F")]
		[Cpp2IlInjected.Address(RVA = "0x1EAAF50", Offset = "0x1EA9D50", VA = "0x181EAAF50", Slot = "18")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000C2")]
	private NOJNACJJDCN FDJAPIAEAMG
	{
		[Cpp2IlInjected.Token(Token = "0x6000334")]
		[Cpp2IlInjected.Address(RVA = "0x708EFE0", Offset = "0x708DDE0", VA = "0x18708EFE0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000C3")]
	private bool EGGFDCIMFFJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000335")]
		[Cpp2IlInjected.Address(RVA = "0x796D180", Offset = "0x796BF80", VA = "0x18796D180")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000320")]
	[Cpp2IlInjected.Address(RVA = "0x796EBF0", Offset = "0x796D9F0", VA = "0x18796EBF0")]
	public GFGLKFFOAEJ(BKMLAJCFPOO EDMNKJJOIJK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000321")]
	[Cpp2IlInjected.Address(RVA = "0x796D6A0", Offset = "0x796C4A0", VA = "0x18796D6A0", Slot = "19")]
	public void NLNNABDBLFO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000322")]
	[Cpp2IlInjected.Address(RVA = "0x796C730", Offset = "0x796B530", VA = "0x18796C730", Slot = "36")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000323")]
	[Cpp2IlInjected.Address(RVA = "0x796DBF0", Offset = "0x796C9F0", VA = "0x18796DBF0", Slot = "28")]
	public void LPCBHBLKHJO(Rigidbody BFBNFNHBHPL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000324")]
	[Cpp2IlInjected.Address(RVA = "0x1397020", Offset = "0x1395E20", VA = "0x181397020", Slot = "20")]
	public void FLMEAHOIOLN(object HACFGBHNOCC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000325")]
	[Cpp2IlInjected.Address(RVA = "0x1397000", Offset = "0x1395E00", VA = "0x181397000", Slot = "30")]
	public void PJINADGDCCI(object HACFGBHNOCC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000326")]
	[Cpp2IlInjected.Address(RVA = "0x796E470", Offset = "0x796D270", VA = "0x18796E470", Slot = "35")]
	public Vector3 NJLCIKCJKMD(Vector3 DKHOBKICOML)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000327")]
	[Cpp2IlInjected.Address(RVA = "0x796D1A0", Offset = "0x796BFA0", VA = "0x18796D1A0", Slot = "34")]
	public Vector3 HBLCPBHIIDI(Vector3 FOLDPAFFMOB)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000328")]
	[Cpp2IlInjected.Address(RVA = "0x796D6A0", Offset = "0x796C4A0", VA = "0x18796D6A0", Slot = "27")]
	public void ICNBDOGBKCC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000329")]
	[Cpp2IlInjected.Address(RVA = "0x796DB90", Offset = "0x796C990", VA = "0x18796DB90", Slot = "25")]
	public void JOLLBIOJCBM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600032A")]
	[Cpp2IlInjected.Address(RVA = "0x796BA60", Offset = "0x796A860", VA = "0x18796BA60", Slot = "24")]
	public void CFNHIHGNLJC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600032B")]
	[Cpp2IlInjected.Address(RVA = "0x796C4F0", Offset = "0x796B2F0", VA = "0x18796C4F0", Slot = "33")]
	public void DMPLLEHEHHJ(Vector3 NKJFLEFCNNK, Vector3 KMOLFMJJEFF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600032C")]
	[Cpp2IlInjected.Address(RVA = "0x796E650", Offset = "0x796D450", VA = "0x18796E650", Slot = "32")]
	public void NKCPNGJPKJI(Vector3 PGPILCGHHEN, Vector3 HPDLDIEKLGI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600032D")]
	[Cpp2IlInjected.Address(RVA = "0x796DD20", Offset = "0x796CB20", VA = "0x18796DD20", Slot = "31")]
	public void MHOOOJMNAMI(Vector3 GJDKCHCMPKK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600032E")]
	[Cpp2IlInjected.Address(RVA = "0x796C790", Offset = "0x796B590", VA = "0x18796C790", Slot = "22")]
	public void FHDDMCOIBHK(DLLHHLOAIHN JNKNJFCPKCP, Vector3 DENBFHHPJGH, float INBGKGNKFFB, float LHLMMNAMGFA = 8f, float KOOKFIHBGFH = 1f)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600032F")]
	[Cpp2IlInjected.Address(RVA = "0x796D750", Offset = "0x796C550", VA = "0x18796D750", Slot = "21")]
	public void IIDMCFJEDDH(PKECHOKBABG EBIBFBONINJ, Vector3 JPKNKMLFEDJ, float LNNCFJOFHBA = float.PositiveInfinity)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000330")]
	[Cpp2IlInjected.Address(RVA = "0x796CD90", Offset = "0x796BB90", VA = "0x18796CD90", Slot = "23")]
	[Obsolete("Deprecated. Still exists to support deprecated CV2 chips. Use ApplyAngularVelocityChange.")]
	public void GIPFFEIENKO(PKECHOKBABG EBIBFBONINJ, Vector3 CKABIAOPKPM, float HDGLIBMICCI = 7f, float DPLEKOGCINM = 1f)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000331")]
	[Cpp2IlInjected.Address(RVA = "0x14DF4E0", Offset = "0x14DE2E0", VA = "0x1814DF4E0")]
	private static void LFIEPGCEPPM(Vector3 PHFLICDNCII, Vector3 FOPIBLDPFFK, [Out] Vector3 DLBPNDDEMAN, [Out] Vector3 OMNMMMFMANE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000332")]
	[Cpp2IlInjected.Address(RVA = "0x796BDD0", Offset = "0x796ABD0", VA = "0x18796BDD0", Slot = "29")]
	public Vector3 DBDODPLBOAD(Vector3 PHFLICDNCII)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000333")]
	[Cpp2IlInjected.Address(RVA = "0x796D510", Offset = "0x796C310", VA = "0x18796D510", Slot = "26")]
	public void IALHFLNDCNP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000336")]
	[Cpp2IlInjected.Address(RVA = "0x796B950", Offset = "0x796A750", VA = "0x18796B950")]
	private void BNLHBIIGOGN(float IPHILEOFJLB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000337")]
	[Cpp2IlInjected.Address(RVA = "0x796B5F0", Offset = "0x796A3F0", VA = "0x18796B5F0")]
	private void ANJOJDFEMDO(Vector3 JPKNKMLFEDJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000338")]
	[Cpp2IlInjected.Address(RVA = "0x796BC50", Offset = "0x796AA50", VA = "0x18796BC50")]
	private Vector3 CMMNDMGFPOG()
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000339")]
	[Cpp2IlInjected.Address(RVA = "0x796E6B0", Offset = "0x796D4B0", VA = "0x18796E6B0")]
	private void OABEKNKDNDA(Vector3 FOLDPAFFMOB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600033A")]
	[Cpp2IlInjected.Address(RVA = "0x796B7C0", Offset = "0x796A5C0", VA = "0x18796B7C0")]
	private Vector3 BLFAJILLKJA()
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x600033B")]
	[Cpp2IlInjected.Address(RVA = "0x796C070", Offset = "0x796AE70", VA = "0x18796C070")]
	private void DMFDMIMODCH(Vector3 IPHILEOFJLB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600033C")]
	[Cpp2IlInjected.Address(RVA = "0x796DEC0", Offset = "0x796CCC0", VA = "0x18796DEC0")]
	private void MMCPAPALIFN(Vector3 FOLDPAFFMOB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600033D")]
	[Cpp2IlInjected.Address(RVA = "0x796CCE0", Offset = "0x796BAE0", VA = "0x18796CCE0")]
	private void FMIJHAKLGOA()
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
