using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Cpp2IlInjected;
using Photon.Pun;
using RecRoom;
using RecRoom.CodeGen.Attributes;
using RecRoom.Utils.OverridableFields;
using Unity.Mathematics;
using UnityEngine;
using UnityEngine.Scripting;
using UnityEngine.Serialization;

[assembly: AssemblyVersion("0.0.0.0")]
[Cpp2IlInjected.Token(Token = "0x2000002")]
public delegate void HJACFJGDJJO(RigidbodyEx HPBNMECOJLN);
[Cpp2IlInjected.Token(Token = "0x2000003")]
public delegate void IFKDBGJBMPP(RigidbodyEx HPBNMECOJLN, bool LHLPPJCBNEM = false);
[Cpp2IlInjected.Token(Token = "0x2000004")]
public enum CAJLMHPONNG
{
	[Cpp2IlInjected.Token(Token = "0x4000002")]
	Additive,
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	Override,
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	Reflective,
	[Cpp2IlInjected.Token(Token = "0x4000005")]
	FullOverride
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public enum CFPGOIDHLCE
{
	[Cpp2IlInjected.Token(Token = "0x4000007")]
	OnlyForReducedPhysicsRateAndNotParenting,
	[Cpp2IlInjected.Token(Token = "0x4000008")]
	Never,
	[Cpp2IlInjected.Token(Token = "0x4000009")]
	OnEvenWhenParenting
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public enum BPMLBDGOAAA
{
	[Cpp2IlInjected.Token(Token = "0x400000B")]
	Additive,
	[Cpp2IlInjected.Token(Token = "0x400000C")]
	Override,
	[Cpp2IlInjected.Token(Token = "0x400000D")]
	Reflective
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
[LKMFAIPHKDB(typeof(JAGPNGGKMIK), new string[] { "Ignore", "Mock" })]
public class EJAAOCBMLPO : JAGPNGGKMIK
{
	[Cpp2IlInjected.Token(Token = "0x17000001")]
	public bool OHBBFJCEBEM
	{
		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x7B46A0", Offset = "0x7B34A0", VA = "0x1807B46A0", Slot = "4")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0x762EE0", Offset = "0x761CE0", VA = "0x180762EE0", Slot = "5")]
	public void KFELHPDHJKB(string OGJCCLJIEPL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x762EE0", Offset = "0x761CE0", VA = "0x180762EE0", Slot = "6")]
	public void EOPJMABJMPE(RigidbodyEx HHJJKPNJLAD, Action HMHDIIODGFG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x762EF0", Offset = "0x761CF0", VA = "0x180762EF0", Slot = "7")]
	public PKLEFBNKEMB PGNIJJIHFOB(int IDOKCPHNACA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x762EE0", Offset = "0x761CE0", VA = "0x180762EE0", Slot = "8")]
	public void GJLPHLCHNAN(Vector3 KPBPPDHFDDO, float GBOIKHDLBKH, Color BJLKCDOCMJA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x76E9D0", Offset = "0x76D7D0", VA = "0x18076E9D0")]
	public EJAAOCBMLPO()
	{
	}
}
namespace RecRoom
{
	[Cpp2IlInjected.Token(Token = "0x2000008")]
	[DisallowMultipleComponent]
	public sealed class RigidbodyEx : MonoBehaviour
	{
		[Cpp2IlInjected.Token(Token = "0x400000F")]
		private static readonly GKFGDEJLFAD FDMJCOJNHJH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000010")]
		private bool HHDELIIFEGC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000011")]
		private HKDDEEJINEH EBIEIJFALOI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000012")]
		[JOILJIPACIH(PPPBLHJADIM.Self, false, false, false)]
		[SerializeField]
		private Rigidbody unityRigidbody;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000013")]
		[JOILJIPACIH(PPPBLHJADIM.SelfAndParent, true, false, false)]
		[SerializeField]
		private PhotonView photonView;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000014")]
		[SerializeField]
		private OverridableVector3 precomputedCenterOfMass;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000015")]
		[SerializeField]
		private OverridableVector3 customCenterOfMass;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000016")]
		[SerializeField]
		[FormerlySerializedAs("forceNoInterpolation")]
		private CFPGOIDHLCE physicsInterpolation;

		[Cpp2IlInjected.FieldOffset(Offset = "0x5C")]
		[Cpp2IlInjected.Token(Token = "0x4000017")]
		[SerializeField]
		[Tooltip("If checked, this object's Unity Rigidbody will not be stripped when parenting the object to another RigidbodyEx. Only check this on objects that have a Unity Rigidbody by default and who need access to Unity physics events like OnTriggerEnter, OnCollisionEnter, etc. This is sometimes set via script instead of this flag.")]
		private bool keepUnityRigidbodyWhileParented;

		[Cpp2IlInjected.FieldOffset(Offset = "0x5D")]
		[Cpp2IlInjected.Token(Token = "0x4000018")]
		[Tooltip("If the RigidbodyEx has a parent that is being destroyed, this flag allows this RigidbodyEx to keep the parent set. The default behavior is thatthe parent property is set to null, resetting/clearing the existing parent when it is being destroyed.")]
		[SerializeField]
		private bool keepParentOnParentDestroy;

		[Cpp2IlInjected.FieldOffset(Offset = "0x5E")]
		[Cpp2IlInjected.Token(Token = "0x4000019")]
		[SerializeField]
		[HideInInspector]
		private bool hasUnityRigidbodyByDefault;

		[Cpp2IlInjected.Token(Token = "0x17000002")]
		internal HKDDEEJINEH MHHFPBGCKAL
		{
			[Cpp2IlInjected.Token(Token = "0x600000B")]
			[Cpp2IlInjected.Address(RVA = "0x622F2E0", Offset = "0x622E0E0", VA = "0x18622F2E0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000003")]
		public IReadOnlyList<RigidbodyEx> CAINKDIPLJO
		{
			[Cpp2IlInjected.Token(Token = "0x6000021")]
			[Cpp2IlInjected.Address(RVA = "0x764C00", Offset = "0x763A00", VA = "0x180764C00")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000022")]
			[Cpp2IlInjected.Address(RVA = "0x764BF0", Offset = "0x7639F0", VA = "0x180764BF0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000004")]
		public RigidbodyEx KHLLNGLHGMI
		{
			[Cpp2IlInjected.Token(Token = "0x6000023")]
			[Cpp2IlInjected.Address(RVA = "0x62312A0", Offset = "0x62300A0", VA = "0x1862312A0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000005")]
		public RigidbodyEx DKBLNPELKCO
		{
			[Cpp2IlInjected.Token(Token = "0x6000024")]
			[Cpp2IlInjected.Address(RVA = "0x6231200", Offset = "0x6230000", VA = "0x186231200")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000006")]
		public RigidbodyEx LBLLNFOEKNE
		{
			[Cpp2IlInjected.Token(Token = "0x6000025")]
			[Cpp2IlInjected.Address(RVA = "0x6231EC0", Offset = "0x6230CC0", VA = "0x186231EC0")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000026")]
			[Cpp2IlInjected.Address(RVA = "0x6233440", Offset = "0x6232240", VA = "0x186233440")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000007")]
		public Transform GLFOIMEGBIM
		{
			[Cpp2IlInjected.Token(Token = "0x6000027")]
			[Cpp2IlInjected.Address(RVA = "0x78B870", Offset = "0x78A670", VA = "0x18078B870")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000008")]
		public Transform PHLFANIJOKI
		{
			[Cpp2IlInjected.Token(Token = "0x6000028")]
			[Cpp2IlInjected.Address(RVA = "0x78B870", Offset = "0x78A670", VA = "0x18078B870")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000009")]
		public FFJHIGAGFEP PKEADPGLIAA
		{
			[Cpp2IlInjected.Token(Token = "0x6000029")]
			[Cpp2IlInjected.Address(RVA = "0x6230FC0", Offset = "0x622FDC0", VA = "0x186230FC0")]
			get
			{
				return default(FFJHIGAGFEP);
			}
			[Cpp2IlInjected.Token(Token = "0x600002A")]
			[Cpp2IlInjected.Address(RVA = "0x6232BF0", Offset = "0x62319F0", VA = "0x186232BF0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000A")]
		public bool OLIJLEJGNMI
		{
			[Cpp2IlInjected.Token(Token = "0x600002B")]
			[Cpp2IlInjected.Address(RVA = "0x6231550", Offset = "0x6230350", VA = "0x186231550")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000B")]
		public bool BLFPMICGOPE
		{
			[Cpp2IlInjected.Token(Token = "0x600002C")]
			[Cpp2IlInjected.Address(RVA = "0x62310E0", Offset = "0x622FEE0", VA = "0x1862310E0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000C")]
		public LBJHINFHGBL JNGDLEGDDIJ
		{
			[Cpp2IlInjected.Token(Token = "0x600002D")]
			[Cpp2IlInjected.Address(RVA = "0x6231490", Offset = "0x6230290", VA = "0x186231490")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600002E")]
			[Cpp2IlInjected.Address(RVA = "0x6232DB0", Offset = "0x6231BB0", VA = "0x186232DB0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000D")]
		public JOFEBGGLMFG NDNIBPFIBJI
		{
			[Cpp2IlInjected.Token(Token = "0x600002F")]
			[Cpp2IlInjected.Address(RVA = "0x6231430", Offset = "0x6230230", VA = "0x186231430")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000030")]
			[Cpp2IlInjected.Address(RVA = "0x6232D40", Offset = "0x6231B40", VA = "0x186232D40")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000E")]
		public bool OAKBMOAOCEK
		{
			[Cpp2IlInjected.Token(Token = "0x6000031")]
			[Cpp2IlInjected.Address(RVA = "0x6231380", Offset = "0x6230180", VA = "0x186231380")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000F")]
		public Rigidbody PEOFAJLGEEJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000032")]
			[Cpp2IlInjected.Address(RVA = "0x62313E0", Offset = "0x62301E0", VA = "0x1862313E0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000010")]
		public bool KNJAHLAHOMB
		{
			[Cpp2IlInjected.Token(Token = "0x6000033")]
			[Cpp2IlInjected.Address(RVA = "0x6231140", Offset = "0x622FF40", VA = "0x186231140")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000034")]
			[Cpp2IlInjected.Address(RVA = "0x6232C60", Offset = "0x6231A60", VA = "0x186232C60")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000011")]
		public bool JMKMFDECBAN
		{
			[Cpp2IlInjected.Token(Token = "0x6000035")]
			[Cpp2IlInjected.Address(RVA = "0x1A1E250", Offset = "0x1A1D050", VA = "0x181A1E250")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000036")]
			[Cpp2IlInjected.Address(RVA = "0x5AD0CB0", Offset = "0x5ACFAB0", VA = "0x185AD0CB0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000012")]
		public float ACPGGACNAPA
		{
			[Cpp2IlInjected.Token(Token = "0x6000037")]
			[Cpp2IlInjected.Address(RVA = "0x6231E60", Offset = "0x6230C60", VA = "0x186231E60")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000013")]
		public float KPCNHEKAOOJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000038")]
			[Cpp2IlInjected.Address(RVA = "0x6231E00", Offset = "0x6230C00", VA = "0x186231E00")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x6000039")]
			[Cpp2IlInjected.Address(RVA = "0x62333D0", Offset = "0x62321D0", VA = "0x1862333D0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000014")]
		public float DJLCHILPGAA
		{
			[Cpp2IlInjected.Token(Token = "0x600003A")]
			[Cpp2IlInjected.Address(RVA = "0x62317B0", Offset = "0x62305B0", VA = "0x1862317B0")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x600003B")]
			[Cpp2IlInjected.Address(RVA = "0x6233050", Offset = "0x6231E50", VA = "0x186233050")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000015")]
		public float CGHFGHFBHCK
		{
			[Cpp2IlInjected.Token(Token = "0x600003C")]
			[Cpp2IlInjected.Address(RVA = "0x62315B0", Offset = "0x62303B0", VA = "0x1862315B0")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x600003D")]
			[Cpp2IlInjected.Address(RVA = "0x6232E20", Offset = "0x6231C20", VA = "0x186232E20")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000016")]
		public bool EAGMCFODNPB
		{
			[Cpp2IlInjected.Token(Token = "0x600003E")]
			[Cpp2IlInjected.Address(RVA = "0x6232420", Offset = "0x6231220", VA = "0x186232420")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x600003F")]
			[Cpp2IlInjected.Address(RVA = "0x62339A0", Offset = "0x62327A0", VA = "0x1862339A0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000017")]
		public Vector3 DDINHCGCHDG
		{
			[Cpp2IlInjected.Token(Token = "0x6000040")]
			[Cpp2IlInjected.Address(RVA = "0x6231BE0", Offset = "0x62309E0", VA = "0x186231BE0")]
			get
			{
				return default(Vector3);
			}
			[Cpp2IlInjected.Token(Token = "0x6000041")]
			[Cpp2IlInjected.Address(RVA = "0x62331A0", Offset = "0x6231FA0", VA = "0x1862331A0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000018")]
		public Vector3 KPBPPDHFDDO
		{
			[Cpp2IlInjected.Token(Token = "0x6000042")]
			[Cpp2IlInjected.Address(RVA = "0x6232560", Offset = "0x6231360", VA = "0x186232560")]
			get
			{
				return default(Vector3);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000019")]
		public CollisionDetectionMode LHOCBPNPOBC
		{
			[Cpp2IlInjected.Token(Token = "0x6000043")]
			[Cpp2IlInjected.Address(RVA = "0x62316F0", Offset = "0x62304F0", VA = "0x1862316F0")]
			get
			{
				return default(CollisionDetectionMode);
			}
			[Cpp2IlInjected.Token(Token = "0x6000044")]
			[Cpp2IlInjected.Address(RVA = "0x6232F70", Offset = "0x6231D70", VA = "0x186232F70")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001A")]
		public float EIKOHCLDIBJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000045")]
			[Cpp2IlInjected.Address(RVA = "0x62311A0", Offset = "0x622FFA0", VA = "0x1862311A0")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x6000046")]
			[Cpp2IlInjected.Address(RVA = "0x6232CD0", Offset = "0x6231AD0", VA = "0x186232CD0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001B")]
		public RigidbodyConstraints AJGCGHEJJII
		{
			[Cpp2IlInjected.Token(Token = "0x6000047")]
			[Cpp2IlInjected.Address(RVA = "0x6231750", Offset = "0x6230550", VA = "0x186231750")]
			get
			{
				return default(RigidbodyConstraints);
			}
			[Cpp2IlInjected.Token(Token = "0x6000048")]
			[Cpp2IlInjected.Address(RVA = "0x6232FE0", Offset = "0x6231DE0", VA = "0x186232FE0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001C")]
		public Vector3 GDLAEGGBPCM
		{
			[Cpp2IlInjected.Token(Token = "0x6000049")]
			[Cpp2IlInjected.Address(RVA = "0x6231F60", Offset = "0x6230D60", VA = "0x186231F60")]
			get
			{
				return default(Vector3);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001D")]
		public Vector3 JJNLCJJLFKE
		{
			[Cpp2IlInjected.Token(Token = "0x600004A")]
			[Cpp2IlInjected.Address(RVA = "0x6231F60", Offset = "0x6230D60", VA = "0x186231F60")]
			get
			{
				return default(Vector3);
			}
			[Cpp2IlInjected.Token(Token = "0x600004B")]
			[Cpp2IlInjected.Address(RVA = "0x6233780", Offset = "0x6232580", VA = "0x186233780")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001E")]
		public float JDLJFLJJFBP
		{
			[Cpp2IlInjected.Token(Token = "0x600004C")]
			[Cpp2IlInjected.Address(RVA = "0x6231CC0", Offset = "0x6230AC0", VA = "0x186231CC0")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x600004D")]
			[Cpp2IlInjected.Address(RVA = "0x6233280", Offset = "0x6232080", VA = "0x186233280")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001F")]
		public float BABNOKCMAEB
		{
			[Cpp2IlInjected.Token(Token = "0x600004E")]
			[Cpp2IlInjected.Address(RVA = "0x62323C0", Offset = "0x62311C0", VA = "0x1862323C0")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x600004F")]
			[Cpp2IlInjected.Address(RVA = "0x6233930", Offset = "0x6232730", VA = "0x186233930")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000020")]
		public Quaternion NGPBNILOFAG
		{
			[Cpp2IlInjected.Token(Token = "0x6000050")]
			[Cpp2IlInjected.Address(RVA = "0x6232040", Offset = "0x6230E40", VA = "0x186232040")]
			get
			{
				return default(Quaternion);
			}
			[Cpp2IlInjected.Token(Token = "0x6000051")]
			[Cpp2IlInjected.Address(RVA = "0x6233500", Offset = "0x6232300", VA = "0x186233500")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000021")]
		public Quaternion CANDIHPEPDD
		{
			[Cpp2IlInjected.Token(Token = "0x6000052")]
			[Cpp2IlInjected.Address(RVA = "0x62322E0", Offset = "0x62310E0", VA = "0x1862322E0")]
			get
			{
				return default(Quaternion);
			}
			[Cpp2IlInjected.Token(Token = "0x6000053")]
			[Cpp2IlInjected.Address(RVA = "0x6233860", Offset = "0x6232660", VA = "0x186233860")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000022")]
		public Vector3 LNEGKDBIJOE
		{
			[Cpp2IlInjected.Token(Token = "0x6000054")]
			[Cpp2IlInjected.Address(RVA = "0x6232120", Offset = "0x6230F20", VA = "0x186232120")]
			get
			{
				return default(Vector3);
			}
			[Cpp2IlInjected.Token(Token = "0x6000055")]
			[Cpp2IlInjected.Address(RVA = "0x62335D0", Offset = "0x62323D0", VA = "0x1862335D0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000023")]
		public Quaternion NPKAJIMBDOM
		{
			[Cpp2IlInjected.Token(Token = "0x6000056")]
			[Cpp2IlInjected.Address(RVA = "0x6232200", Offset = "0x6231000", VA = "0x186232200")]
			get
			{
				return default(Quaternion);
			}
			[Cpp2IlInjected.Token(Token = "0x6000057")]
			[Cpp2IlInjected.Address(RVA = "0x62336B0", Offset = "0x62324B0", VA = "0x1862336B0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000024")]
		public Vector3 HPJBBHHJIEL
		{
			[Cpp2IlInjected.Token(Token = "0x6000058")]
			[Cpp2IlInjected.Address(RVA = "0x6232480", Offset = "0x6231280", VA = "0x186232480")]
			get
			{
				return default(Vector3);
			}
			[Cpp2IlInjected.Token(Token = "0x6000059")]
			[Cpp2IlInjected.Address(RVA = "0x6233A10", Offset = "0x6232810", VA = "0x186233A10")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000025")]
		public Vector3 CBFMJBCAHHF
		{
			[Cpp2IlInjected.Token(Token = "0x600005A")]
			[Cpp2IlInjected.Address(RVA = "0x6231D20", Offset = "0x6230B20", VA = "0x186231D20")]
			get
			{
				return default(Vector3);
			}
			[Cpp2IlInjected.Token(Token = "0x600005B")]
			[Cpp2IlInjected.Address(RVA = "0x62332F0", Offset = "0x62320F0", VA = "0x1862332F0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000026")]
		public Vector3 LMHADGEOOGN
		{
			[Cpp2IlInjected.Token(Token = "0x600005C")]
			[Cpp2IlInjected.Address(RVA = "0x6231610", Offset = "0x6230410", VA = "0x186231610")]
			get
			{
				return default(Vector3);
			}
			[Cpp2IlInjected.Token(Token = "0x600005D")]
			[Cpp2IlInjected.Address(RVA = "0x6232E90", Offset = "0x6231C90", VA = "0x186232E90")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000027")]
		public Vector3 MKPDHJELIJH
		{
			[Cpp2IlInjected.Token(Token = "0x600005E")]
			[Cpp2IlInjected.Address(RVA = "0x6231B00", Offset = "0x6230900", VA = "0x186231B00")]
			get
			{
				return default(Vector3);
			}
			[Cpp2IlInjected.Token(Token = "0x600005F")]
			[Cpp2IlInjected.Address(RVA = "0x62330C0", Offset = "0x6231EC0", VA = "0x1862330C0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000028")]
		public Vector3 FGJGGNHCPKD
		{
			[Cpp2IlInjected.Token(Token = "0x6000060")]
			[Cpp2IlInjected.Address(RVA = "0x62319C0", Offset = "0x62307C0", VA = "0x1862319C0")]
			get
			{
				return default(Vector3);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000029")]
		public Quaternion KJMFENHAPNA
		{
			[Cpp2IlInjected.Token(Token = "0x6000061")]
			[Cpp2IlInjected.Address(RVA = "0x62318E0", Offset = "0x62306E0", VA = "0x1862318E0")]
			get
			{
				return default(Quaternion);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002A")]
		public Vector3 GAKIFKLPCOP
		{
			[Cpp2IlInjected.Token(Token = "0x6000063")]
			[Cpp2IlInjected.Address(RVA = "0x6232720", Offset = "0x6231520", VA = "0x186232720")]
			get
			{
				return default(Vector3);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002B")]
		public Vector3 NMEBPBCNIIA
		{
			[Cpp2IlInjected.Token(Token = "0x6000064")]
			[Cpp2IlInjected.Address(RVA = "0x6232640", Offset = "0x6231440", VA = "0x186232640")]
			get
			{
				return default(Vector3);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002C")]
		public bool KPFPDIPJHJC
		{
			[Cpp2IlInjected.Token(Token = "0x6000065")]
			[Cpp2IlInjected.Address(RVA = "0x6231AA0", Offset = "0x62308A0", VA = "0x186231AA0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002D")]
		public bool DFDBDNANPGP
		{
			[Cpp2IlInjected.Token(Token = "0x6000066")]
			[Cpp2IlInjected.Address(RVA = "0x62314F0", Offset = "0x62302F0", VA = "0x1862314F0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002E")]
		public bool FIDLEGGHFIK
		{
			[Cpp2IlInjected.Token(Token = "0x6000067")]
			[Cpp2IlInjected.Address(RVA = "0x6231080", Offset = "0x622FE80", VA = "0x186231080")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002F")]
		public bool NNJBEOGIMBG
		{
			[Cpp2IlInjected.Token(Token = "0x6000068")]
			[Cpp2IlInjected.Address(RVA = "0x6231020", Offset = "0x622FE20", VA = "0x186231020")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000030")]
		public bool BPBHDJCNMPF
		{
			[Cpp2IlInjected.Token(Token = "0x6000069")]
			[Cpp2IlInjected.Address(RVA = "0x6230F60", Offset = "0x622FD60", VA = "0x186230F60")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000031")]
		public bool MPBNBIDLJCC
		{
			[Cpp2IlInjected.Token(Token = "0x600006A")]
			[Cpp2IlInjected.Address(RVA = "0x6231810", Offset = "0x6230610", VA = "0x186231810")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000032")]
		public bool KADIPLBDHPF
		{
			[Cpp2IlInjected.Token(Token = "0x600006B")]
			[Cpp2IlInjected.Address(RVA = "0x4EA70E0", Offset = "0x4EA5EE0", VA = "0x184EA70E0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000001")]
		public event HJACFJGDJJO FFPDANIDENF
		{
			[Cpp2IlInjected.Token(Token = "0x600000F")]
			[Cpp2IlInjected.Address(RVA = "0x6230E80", Offset = "0x622FC80", VA = "0x186230E80")]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000010")]
			[Cpp2IlInjected.Address(RVA = "0x6232B10", Offset = "0x6231910", VA = "0x186232B10")]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000002")]
		public event IFKDBGJBMPP JMMJNFGMEFN
		{
			[Cpp2IlInjected.Token(Token = "0x6000011")]
			[Cpp2IlInjected.Address(RVA = "0x6230E10", Offset = "0x622FC10", VA = "0x186230E10")]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000012")]
			[Cpp2IlInjected.Address(RVA = "0x6232AA0", Offset = "0x62318A0", VA = "0x186232AA0")]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000003")]
		public event HJACFJGDJJO HODIMEMGCKN
		{
			[Cpp2IlInjected.Token(Token = "0x6000013")]
			[Cpp2IlInjected.Address(RVA = "0x6230B70", Offset = "0x622F970", VA = "0x186230B70")]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000014")]
			[Cpp2IlInjected.Address(RVA = "0x6232800", Offset = "0x6231600", VA = "0x186232800")]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000004")]
		public event HJACFJGDJJO JOCICHKGDGM
		{
			[Cpp2IlInjected.Token(Token = "0x6000015")]
			[Cpp2IlInjected.Address(RVA = "0x6230BE0", Offset = "0x622F9E0", VA = "0x186230BE0")]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000016")]
			[Cpp2IlInjected.Address(RVA = "0x6232870", Offset = "0x6231670", VA = "0x186232870")]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000005")]
		public event HJACFJGDJJO ODNGMOBPALO
		{
			[Cpp2IlInjected.Token(Token = "0x6000017")]
			[Cpp2IlInjected.Address(RVA = "0x6230D30", Offset = "0x622FB30", VA = "0x186230D30")]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000018")]
			[Cpp2IlInjected.Address(RVA = "0x62329C0", Offset = "0x62317C0", VA = "0x1862329C0")]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000006")]
		public event Action<KFCLLDKJIGN, KFCLLDKJIGN> NIPMFJHHIKK
		{
			[Cpp2IlInjected.Token(Token = "0x6000019")]
			[Cpp2IlInjected.Address(RVA = "0x6230CC0", Offset = "0x622FAC0", VA = "0x186230CC0")]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x600001A")]
			[Cpp2IlInjected.Address(RVA = "0x6232950", Offset = "0x6231750", VA = "0x186232950")]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000007")]
		public event HJACFJGDJJO MCEGDLDFIED
		{
			[Cpp2IlInjected.Token(Token = "0x600001B")]
			[Cpp2IlInjected.Address(RVA = "0x6230DA0", Offset = "0x622FBA0", VA = "0x186230DA0")]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x600001C")]
			[Cpp2IlInjected.Address(RVA = "0x6232A30", Offset = "0x6231830", VA = "0x186232A30")]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000008")]
		public event HJACFJGDJJO PFFOJMELFJM
		{
			[Cpp2IlInjected.Token(Token = "0x600001D")]
			[Cpp2IlInjected.Address(RVA = "0x6230EF0", Offset = "0x622FCF0", VA = "0x186230EF0")]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x600001E")]
			[Cpp2IlInjected.Address(RVA = "0x6232B80", Offset = "0x6231980", VA = "0x186232B80")]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000009")]
		public event HJACFJGDJJO EDNEIGNLNHG
		{
			[Cpp2IlInjected.Token(Token = "0x600001F")]
			[Cpp2IlInjected.Address(RVA = "0x6230C50", Offset = "0x622FA50", VA = "0x186230C50")]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000020")]
			[Cpp2IlInjected.Address(RVA = "0x62328E0", Offset = "0x62316E0", VA = "0x1862328E0")]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x761680", Offset = "0x760480", VA = "0x180761680")]
		internal void LJLBNCDNOJC(HKDDEEJINEH BAHHCFCHDLD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x622F070", Offset = "0x622DE70", VA = "0x18622F070")]
		internal void COABCBODFIH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x6230890", Offset = "0x622F690", VA = "0x186230890")]
		[Conditional("UNITY_EDITOR")]
		[Conditional("DEBUG_BUILD")]
		public void TestOverrideUnityRigidbody(Rigidbody BELIJAOOPOK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000062")]
		[Cpp2IlInjected.Address(RVA = "0x6230560", Offset = "0x622F360", VA = "0x186230560")]
		public void SetInertiaTensor((Quaternion rot, Vector3 moments) IGICCOJIDDA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006C")]
		[Cpp2IlInjected.Address(RVA = "0x622EFA0", Offset = "0x622DDA0", VA = "0x18622EFA0")]
		private void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006D")]
		[Cpp2IlInjected.Address(RVA = "0x622F2E0", Offset = "0x622E0E0", VA = "0x18622F2E0")]
		private HKDDEEJINEH MFCOAMBFPKA()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600006E")]
		[Cpp2IlInjected.Address(RVA = "0x622FA60", Offset = "0x622E860", VA = "0x18622FA60")]
		private void PCPNMJLBOGM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006F")]
		[Cpp2IlInjected.Address(RVA = "0x622F9A0", Offset = "0x622E7A0", VA = "0x18622F9A0")]
		private void OnEnable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000070")]
		[Cpp2IlInjected.Address(RVA = "0x762EE0", Offset = "0x761CE0", VA = "0x180762EE0")]
		public void OnDisable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000071")]
		[Cpp2IlInjected.Address(RVA = "0x622F070", Offset = "0x622DE70", VA = "0x18622F070")]
		private void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000072")]
		[Cpp2IlInjected.Address(RVA = "0x622F940", Offset = "0x622E740", VA = "0x18622F940")]
		private void OnDrawGizmosSelected()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000073")]
		[Cpp2IlInjected.Address(RVA = "0x622FA00", Offset = "0x622E800", VA = "0x18622FA00")]
		private void OnValidate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000074")]
		[Cpp2IlInjected.Address(RVA = "0x622E650", Offset = "0x622D450", VA = "0x18622E650")]
		public void AddDoNotResetVelocityOnOwnershipChangeOverride(object PFKLELGAJPH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000075")]
		[Cpp2IlInjected.Address(RVA = "0x622FDF0", Offset = "0x622EBF0", VA = "0x18622FDF0")]
		public void RemoveDoNotResetVelocityOnOwnershipChangeOverride(object PFKLELGAJPH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000076")]
		[Cpp2IlInjected.Address(RVA = "0x622F280", Offset = "0x622E080", VA = "0x18622F280")]
		public void DisableCachedInertialPropertyOverride()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000077")]
		[Cpp2IlInjected.Address(RVA = "0x622F8E0", Offset = "0x622E6E0", VA = "0x18622F8E0")]
		public void MarkCachedInertialParametersDirty()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000078")]
		[Cpp2IlInjected.Address(RVA = "0x62306C0", Offset = "0x622F4C0", VA = "0x1862306C0")]
		public void SetParent(RigidbodyEx GNLEHBFFNFG, bool LHLPPJCBNEM = false)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000079")]
		[Cpp2IlInjected.Address(RVA = "0x6230100", Offset = "0x622EF00", VA = "0x186230100")]
		public void ResetLocalCenterOfMassToPrefabDefault()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007A")]
		[Cpp2IlInjected.Address(RVA = "0x622F5B0", Offset = "0x622E3B0", VA = "0x18622F5B0")]
		public bool IsRigidbodyAncestor(RigidbodyEx HEFCCNCIEFJ)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600007B")]
		[Cpp2IlInjected.Address(RVA = "0x622F690", Offset = "0x622E490", VA = "0x18622F690")]
		public bool IsRigidbodyDescendant(RigidbodyEx BJNGNGIHFHL)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600007C")]
		[Cpp2IlInjected.Address(RVA = "0x622E8C0", Offset = "0x622D6C0", VA = "0x18622E8C0")]
		public void AddInterpolationRestriction(object PFKLELGAJPH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007D")]
		[Cpp2IlInjected.Address(RVA = "0x622FE60", Offset = "0x622EC60", VA = "0x18622FE60")]
		public void RemoveInterpolationRestriction(object PFKLELGAJPH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007E")]
		[Cpp2IlInjected.Address(RVA = "0x622F010", Offset = "0x622DE10", VA = "0x18622F010")]
		public IDisposable BeginKinematicScope()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600007F")]
		[Cpp2IlInjected.Address(RVA = "0x622E930", Offset = "0x622D730", VA = "0x18622E930")]
		public void AddKinematic(object PFKLELGAJPH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000080")]
		[Cpp2IlInjected.Address(RVA = "0x622FED0", Offset = "0x622ECD0", VA = "0x18622FED0")]
		public void RemoveKinematic(object PFKLELGAJPH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000081")]
		[Cpp2IlInjected.Address(RVA = "0x6230640", Offset = "0x622F440", VA = "0x186230640")]
		public void SetKinematic(object PFKLELGAJPH, bool JJIMCKPIKFL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000082")]
		[Cpp2IlInjected.Address(RVA = "0x6230460", Offset = "0x622F260", VA = "0x186230460")]
		public void SetDiscontinuousPositionAndRotation(Vector3 KMDPKMLFOLC, Quaternion KGOHNEKGJFD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000083")]
		[Cpp2IlInjected.Address(RVA = "0x6230360", Offset = "0x622F160", VA = "0x186230360")]
		public void SetDiscontinuousLocalPositionAndLocalRotation(Vector3 IAOBMGELIKG, Quaternion BIOBPMHCIFO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000084")]
		[Cpp2IlInjected.Address(RVA = "0x622F4A0", Offset = "0x622E2A0", VA = "0x18622F4A0")]
		public Vector3 GetConstrainedVelocity(Vector3 HPJBBHHJIEL)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x6000085")]
		[Cpp2IlInjected.Address(RVA = "0x622F390", Offset = "0x622E190", VA = "0x18622F390")]
		public Vector3 GetConstrainedAngularVelocity(Vector3 LMHADGEOOGN)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x6000086")]
		[Cpp2IlInjected.Address(RVA = "0x622E7D0", Offset = "0x622D5D0", VA = "0x18622E7D0")]
		public void AddForce(Vector3 PJCPHDDKADF, ForceMode BKPMKNNGNCO = ForceMode.Force)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000087")]
		[Cpp2IlInjected.Address(RVA = "0x622E6C0", Offset = "0x622D4C0", VA = "0x18622E6C0")]
		public void AddForceAtPosition(Vector3 PJCPHDDKADF, Vector3 AILFIIEAPKM, ForceMode BKPMKNNGNCO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000088")]
		[Cpp2IlInjected.Address(RVA = "0x622EB00", Offset = "0x622D900", VA = "0x18622EB00")]
		public void AddTorque(Vector3 KNJIDLKEAOF, ForceMode BKPMKNNGNCO = ForceMode.Force)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000089")]
		[Cpp2IlInjected.Address(RVA = "0x622E9A0", Offset = "0x622D7A0", VA = "0x18622E9A0")]
		public void AddRelativeTorque(Vector3 KNJIDLKEAOF, ForceMode BKPMKNNGNCO = ForceMode.Force)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008A")]
		[Cpp2IlInjected.Address(RVA = "0x6230960", Offset = "0x622F760", VA = "0x186230960")]
		public Vector3 WorldToLocalVelocity(Vector3 FCKPHPBMNBE)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x600008B")]
		[Cpp2IlInjected.Address(RVA = "0x622F7D0", Offset = "0x622E5D0", VA = "0x18622F7D0")]
		public Vector3 LocalToWorldVelocity(Vector3 CBFMJBCAHHF)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x600008C")]
		[Cpp2IlInjected.Address(RVA = "0x622F220", Offset = "0x622E020", VA = "0x18622F220")]
		public void ClearVelocity()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008D")]
		[Cpp2IlInjected.Address(RVA = "0x622F1C0", Offset = "0x622DFC0", VA = "0x18622F1C0")]
		public void ClearUnityRigidbodyVelocity()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008E")]
		[Cpp2IlInjected.Address(RVA = "0x622F160", Offset = "0x622DF60", VA = "0x18622F160")]
		public void ClearLinearVelocity()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008F")]
		[Cpp2IlInjected.Address(RVA = "0x622F100", Offset = "0x622DF00", VA = "0x18622F100")]
		public void ClearAngularVelocity()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000090")]
		[Cpp2IlInjected.Address(RVA = "0x6230260", Offset = "0x622F060", VA = "0x186230260")]
		public void ResetVelocityWorldSpace(Vector3 LCEEOGHIEAE, Vector3 CMCJGKKIFGK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000091")]
		[Cpp2IlInjected.Address(RVA = "0x6230160", Offset = "0x622EF60", VA = "0x186230160")]
		public void ResetVelocityLocalSpace(Vector3 NNHCKKDHDOO, Vector3 MKPDHJELIJH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000092")]
		[Cpp2IlInjected.Address(RVA = "0x6230020", Offset = "0x622EE20", VA = "0x186230020")]
		public void ResetLinearVelocityLocalSpace(Vector3 NNHCKKDHDOO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000093")]
		[Cpp2IlInjected.Address(RVA = "0x62307F0", Offset = "0x622F5F0", VA = "0x1862307F0")]
		public bool SweepTest(Vector3 IELHLOGPMDL, [Out] RaycastHit PEGDGELCHOI, float NGLNDDJFMFL)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000094")]
		[Cpp2IlInjected.Address(RVA = "0x622F770", Offset = "0x622E570", VA = "0x18622F770")]
		public bool IsSleeping()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000095")]
		[Cpp2IlInjected.Address(RVA = "0x6230790", Offset = "0x622F590", VA = "0x186230790")]
		public void Sleep()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000096")]
		[Cpp2IlInjected.Address(RVA = "0x6230900", Offset = "0x622F700", VA = "0x186230900")]
		public void WakeUp()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000097")]
		[Cpp2IlInjected.Address(RVA = "0x622EA90", Offset = "0x622D890", VA = "0x18622EA90")]
		public void AddShouldHaveUnityRigidbodyToken(object PFKLELGAJPH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000098")]
		[Cpp2IlInjected.Address(RVA = "0x622FF40", Offset = "0x622ED40", VA = "0x18622FF40")]
		public void RemoveShouldHaveUnityRigidbodyToken(object PFKLELGAJPH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000099")]
		[Cpp2IlInjected.Address(RVA = "0x622EE30", Offset = "0x622DC30", VA = "0x18622EE30")]
		public void ApplyForceVelocityChange(CAJLMHPONNG ODONFGMOICG, Vector3 EBGKJLMCJAI, float EMBPADILADB, float ICDNFDHOPEF = 8f, float PKMFLEJBFBB = 1f)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009A")]
		[Cpp2IlInjected.Address(RVA = "0x622ED90", Offset = "0x622DB90", VA = "0x18622ED90")]
		public void ApplyAngularVelocityChange(BPMLBDGOAAA KPBLKDJONKA, Vector3 KHAGNCFGGLP, float DGAGPLDFBFA = float.PositiveInfinity)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009B")]
		[Cpp2IlInjected.Address(RVA = "0x622EEF0", Offset = "0x622DCF0", VA = "0x18622EEF0")]
		[Obsolete("Deprecated. Still exists to support deprecated CV2 chips. Use ApplyAngularVelocityChange.")]
		public void ApplyTorqueAngularVelocityChangeDeprecated(BPMLBDGOAAA KPBLKDJONKA, Vector3 GIBIBDOGOLL, float MLEKCJEEFGK = 7f, float JGPJAKHDFMM = 1f)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009C")]
		[Cpp2IlInjected.Address(RVA = "0x622ECC0", Offset = "0x622DAC0", VA = "0x18622ECC0")]
		public bool AllowedScaleChange(float OFPMODDPBDG)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600009D")]
		[Cpp2IlInjected.Address(RVA = "0x622EBF0", Offset = "0x622D9F0", VA = "0x18622EBF0")]
		public void AddWorldSpaceVelocityInHierarchyParentOverride(RigidbodyEx CIBBEIAHJJB, object PFKLELGAJPH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009E")]
		[Cpp2IlInjected.Address(RVA = "0x622FFB0", Offset = "0x622EDB0", VA = "0x18622FFB0")]
		public void RemoveWorldSpaceVelocityInHierarchyParentOverride(object PFKLELGAJPH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009F")]
		[Cpp2IlInjected.Address(RVA = "0x6230B00", Offset = "0x622F900", VA = "0x186230B00")]
		public RigidbodyEx()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
internal static class NPCNIJKBFAH
{
	[Cpp2IlInjected.Token(Token = "0x60000A4")]
	[Cpp2IlInjected.Address(RVA = "0x622D860", Offset = "0x622C660", VA = "0x18622D860")]
	public static HKDDEEJINEH MHHFPBGCKAL(this RigidbodyEx HHJJKPNJLAD)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
public struct POAMDCEFDPK
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001D")]
	public Rigidbody OPIJOIJPNML;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x400001E")]
	public PhotonView AIHFPABPIJH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400001F")]
	public OverridableVector3 AAAIDNKIFIJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000020")]
	public OverridableVector3 HLGDJAEDJBM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000021")]
	public CFPGOIDHLCE AFMPEOCEABJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
	[Cpp2IlInjected.Token(Token = "0x4000022")]
	public bool MFBNKHIEOJM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x35")]
	[Cpp2IlInjected.Token(Token = "0x4000023")]
	public bool EIACBFHMKPK;
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
[LKMFAIPHKDB(typeof(JLBIHFBBGKJ), new string[] { })]
public class GCDMEHPMPOD : JLBIHFBBGKJ, IJCLFGAEMDL
{
	[Cpp2IlInjected.Token(Token = "0x4000024")]
	private static readonly GKFGDEJLFAD CGHEBMJOFGL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000025")]
	private KMLKLGKDBAC OLAEKCABFGN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000026")]
	private JAGPNGGKMIK EILPDJCOMNG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000027")]
	private OIJLNKKGFII DIHKKHECABK;

	[Cpp2IlInjected.Token(Token = "0x17000033")]
	public JAGPNGGKMIK FHMIKKFADBO
	{
		[Cpp2IlInjected.Token(Token = "0x60000A5")]
		[Cpp2IlInjected.Address(RVA = "0x761640", Offset = "0x760440", VA = "0x180761640", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000034")]
	public OIJLNKKGFII PHAOEEKJDCA
	{
		[Cpp2IlInjected.Token(Token = "0x60000A6")]
		[Cpp2IlInjected.Address(RVA = "0x761660", Offset = "0x760460", VA = "0x180761660", Slot = "5")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000A7")]
	[Cpp2IlInjected.Address(RVA = "0x6213190", Offset = "0x6211F90", VA = "0x186213190", Slot = "8")]
	public void InitReferences(LHNHCAPHDGO PDGDCGJNEFO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A8")]
	[Cpp2IlInjected.Address(RVA = "0x6213220", Offset = "0x6212020", VA = "0x186213220", Slot = "6")]
	public JBMJEBCFLLB NLKAGJFNPMP(RigidbodyEx HHJJKPNJLAD)
	{
		return default(JBMJEBCFLLB);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A9")]
	[Cpp2IlInjected.Address(RVA = "0x62130C0", Offset = "0x6211EC0", VA = "0x1862130C0")]
	private static JBMJEBCFLLB GIPPNCAILNN(RigidbodyEx HHJJKPNJLAD)
	{
		return default(JBMJEBCFLLB);
	}

	[Cpp2IlInjected.Token(Token = "0x60000AA")]
	[Cpp2IlInjected.Address(RVA = "0x6213020", Offset = "0x6211E20", VA = "0x186213020", Slot = "7")]
	public HKDDEEJINEH GBDBCOGCGCH(RigidbodyEx HHJJKPNJLAD, POAMDCEFDPK PFDMLBFKIAP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000AB")]
	[Cpp2IlInjected.Address(RVA = "0x76E9D0", Offset = "0x76D7D0", VA = "0x18076E9D0")]
	public GCDMEHPMPOD()
	{
	}
}
namespace RecRoom
{
	[Cpp2IlInjected.Token(Token = "0x200000D")]
	public class PhysicsManager : SingletonMonoBehaviour<PhysicsManager>
	{
		[Cpp2IlInjected.Token(Token = "0x4000028")]
		public static ECJBBEDPNJE UpdateAfterFixedUpdateRan;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000029")]
		private int IDENOCBALIA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x400002A")]
		private int AEIINFDGKAD;

		[Cpp2IlInjected.Token(Token = "0x60000AD")]
		[Cpp2IlInjected.Address(RVA = "0x622E4B0", Offset = "0x622D2B0", VA = "0x18622E4B0")]
		protected void FixedUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AE")]
		[Cpp2IlInjected.Address(RVA = "0x622E4F0", Offset = "0x622D2F0", VA = "0x18622E4F0")]
		protected void Update()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AF")]
		[Cpp2IlInjected.Address(RVA = "0x622E4D0", Offset = "0x622D2D0", VA = "0x18622E4D0")]
		protected void LateUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B0")]
		[Cpp2IlInjected.Address(RVA = "0x762EE0", Offset = "0x761CE0", VA = "0x180762EE0")]
		[Conditional("UNITY_ASSERTIONS")]
		public void AssertLateColliderPositionsNotYetUpdated([Optional] string JIGBFCEILIK, [Optional] UnityEngine.Object GMNCNEPJHHN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B1")]
		[Cpp2IlInjected.Address(RVA = "0x762EE0", Offset = "0x761CE0", VA = "0x180762EE0")]
		[Conditional("UNITY_ASSERTIONS")]
		public void AssertLateColliderPositionsAlreadyUpdated([Optional] string JIGBFCEILIK, [Optional] UnityEngine.Object GMNCNEPJHHN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B2")]
		[Cpp2IlInjected.Address(RVA = "0x622E600", Offset = "0x622D400", VA = "0x18622E600")]
		public PhysicsManager()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
public static class JAPAPMBMKAD
{
	[Cpp2IlInjected.Token(Token = "0x60000B4")]
	[Cpp2IlInjected.Address(RVA = "0x621CB10", Offset = "0x621B910", VA = "0x18621CB10")]
	public static void AIIDAHLKLGO(this Rigidbody BELIJAOOPOK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B5")]
	[Cpp2IlInjected.Address(RVA = "0x621C9E0", Offset = "0x621B7E0", VA = "0x18621C9E0")]
	public static void AIIDAHLKLGO(this Rigidbody BELIJAOOPOK, Vector3 POHKDDMIIKJ, Quaternion KJMFENHAPNA, Vector3 BDBHEDHCMMI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B6")]
	[Cpp2IlInjected.Address(RVA = "0xB3E540", Offset = "0xB3D340", VA = "0x180B3E540")]
	public static void OGHJIMCDJIC(Vector3 HPJBBHHJIEL, Vector3 LNAACFFHHMA, [Out] Vector3 KKPBIGLGEJI, [Out] Vector3 DEMJOLKECMA)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000F")]
public static class MKHJCADMAHB
{
	[Cpp2IlInjected.Token(Token = "0x2000010")]
	private class PLIJFLDOLEN : LBJHINFHGBL, IDisposable
	{
		[Cpp2IlInjected.Token(Token = "0x60000B9")]
		[Cpp2IlInjected.Address(RVA = "0x762EE0", Offset = "0x761CE0", VA = "0x180762EE0", Slot = "6")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000BA")]
		[Cpp2IlInjected.Address(RVA = "0x772AA0", Offset = "0x7718A0", VA = "0x180772AA0", Slot = "4")]
		public Vector3 IGMHJOMEDJM()
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x60000BB")]
		[Cpp2IlInjected.Address(RVA = "0x772AA0", Offset = "0x7718A0", VA = "0x180772AA0", Slot = "5")]
		public Vector3 DIEBBBOOKKJ()
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x60000BC")]
		[Cpp2IlInjected.Address(RVA = "0x76E9D0", Offset = "0x76D7D0", VA = "0x18076E9D0")]
		public PLIJFLDOLEN()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000035")]
	public static LBJHINFHGBL DPCHNIKBKIN
	{
		[Cpp2IlInjected.Token(Token = "0x60000B7")]
		[Cpp2IlInjected.Address(RVA = "0x6229BD0", Offset = "0x62289D0", VA = "0x186229BD0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
public interface DOLMCKAIMMH
{
	[Cpp2IlInjected.Token(Token = "0x17000036")]
	CollisionDetectionMode DGLKEBEJHFH
	{
		[Cpp2IlInjected.Token(Token = "0x60000BD")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
		[Cpp2IlInjected.Token(Token = "0x60000BE")]
		[Cpp2IlInjected.Address(Slot = "1")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x60000BF")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void EKBEIHECLAM();

	[Cpp2IlInjected.Token(Token = "0x60000C0")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void KFHFNMGPAPA(bool KPFPDIPJHJC);

	[Cpp2IlInjected.Token(Token = "0x60000C1")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void IAGFKMCIEPM(bool KPFPDIPJHJC);

	[Cpp2IlInjected.Token(Token = "0x60000C2")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void AKOMFNGCOKL(Rigidbody OPIJOIJPNML);

	[Cpp2IlInjected.Token(Token = "0x60000C3")]
	[Cpp2IlInjected.Address(Slot = "6")]
	bool IMCFKJILCKH(Vector3 IELHLOGPMDL, [Out] RaycastHit PEGDGELCHOI, float NGLNDDJFMFL);
}
[Cpp2IlInjected.Token(Token = "0x2000012")]
public interface IBDFGCOAOJH : IDisposable, ENGGMMDIFLJ
{
	[Cpp2IlInjected.Token(Token = "0x17000037")]
	EPMFMHNHMEG PKEADPGLIAA
	{
		[Cpp2IlInjected.Token(Token = "0x60000C6")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
		[Cpp2IlInjected.Token(Token = "0x60000C7")]
		[Cpp2IlInjected.Address(Slot = "3")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x1400000A")]
	event Action<KFCLLDKJIGN, KFCLLDKJIGN> NIPMFJHHIKK;

	[Cpp2IlInjected.Token(Token = "0x60000C8")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void EKBEIHECLAM();
}
[Cpp2IlInjected.Token(Token = "0x2000013")]
[FEFNBKCFPJG(DAEAEJBLHHK.Application)]
public interface OIJLNKKGFII
{
	[Cpp2IlInjected.Token(Token = "0x60000C9")]
	[Cpp2IlInjected.Address(Slot = "0")]
	CNJKFLKEHNP FOPFKFOAJPB(HKDDEEJINEH BAHHCFCHDLD);

	[Cpp2IlInjected.Token(Token = "0x60000CA")]
	[Cpp2IlInjected.Address(Slot = "1")]
	EDHOGNBFGNL HEHEJFBIECI(HKDDEEJINEH BAHHCFCHDLD);

	[Cpp2IlInjected.Token(Token = "0x60000CB")]
	[Cpp2IlInjected.Address(Slot = "2")]
	JMDJHBDFHNM JENKNAKGHBC(HKDDEEJINEH BAHHCFCHDLD);

	[Cpp2IlInjected.Token(Token = "0x60000CC")]
	[Cpp2IlInjected.Address(Slot = "3")]
	DLMELLONDOM KBPGHNGMBLP(HKDDEEJINEH BAHHCFCHDLD);

	[Cpp2IlInjected.Token(Token = "0x60000CD")]
	[Cpp2IlInjected.Address(Slot = "4")]
	KPOOLPDCCMI DLBBJKBMHCG(HKDDEEJINEH BAHHCFCHDLD);

	[Cpp2IlInjected.Token(Token = "0x60000CE")]
	[Cpp2IlInjected.Address(Slot = "5")]
	IBDFGCOAOJH HMLDNCBNCBD(HKDDEEJINEH BAHHCFCHDLD);

	[Cpp2IlInjected.Token(Token = "0x60000CF")]
	[Cpp2IlInjected.Address(Slot = "6")]
	PPFMEJNLLFC MIHHGOGKKII(HKDDEEJINEH BAHHCFCHDLD);

	[Cpp2IlInjected.Token(Token = "0x60000D0")]
	[Cpp2IlInjected.Address(Slot = "7")]
	AEDPOFGENJL BMDHNLFPMHG(HKDDEEJINEH BAHHCFCHDLD);

	[Cpp2IlInjected.Token(Token = "0x60000D1")]
	[Cpp2IlInjected.Address(Slot = "8")]
	DOLMCKAIMMH GBBKLOFEEGG(HKDDEEJINEH BAHHCFCHDLD);

	[Cpp2IlInjected.Token(Token = "0x60000D2")]
	[Cpp2IlInjected.Address(Slot = "9")]
	AEAEHLIIIHM MPCEOKBAMNI(HKDDEEJINEH BAHHCFCHDLD);

	[Cpp2IlInjected.Token(Token = "0x60000D3")]
	[Cpp2IlInjected.Address(Slot = "10")]
	IMMDALGJOAC JDJFPLEAIIO(HKDDEEJINEH BAHHCFCHDLD, [In] POAMDCEFDPK PFDMLBFKIAP);

	[Cpp2IlInjected.Token(Token = "0x60000D4")]
	[Cpp2IlInjected.Address(Slot = "11")]
	IHPGPDPIGPG INKLNFJDMGF(HKDDEEJINEH BAHHCFCHDLD, [In] POAMDCEFDPK PFDMLBFKIAP);

	[Cpp2IlInjected.Token(Token = "0x60000D5")]
	[Cpp2IlInjected.Address(Slot = "12")]
	NOJOGIBNEOM FFNNPCJDIKH(HKDDEEJINEH BAHHCFCHDLD, [In] POAMDCEFDPK PFDMLBFKIAP);

	[Cpp2IlInjected.Token(Token = "0x60000D6")]
	[Cpp2IlInjected.Address(Slot = "13")]
	FHMHFKBPFEJ BLIEMOAADPO(HKDDEEJINEH BAHHCFCHDLD, [In] POAMDCEFDPK PFDMLBFKIAP);

	[Cpp2IlInjected.Token(Token = "0x60000D7")]
	[Cpp2IlInjected.Address(Slot = "14")]
	KPIMHBGJADP BHGFCBBGNJF(HKDDEEJINEH BAHHCFCHDLD, [In] POAMDCEFDPK PFDMLBFKIAP);

	[Cpp2IlInjected.Token(Token = "0x60000D8")]
	[Cpp2IlInjected.Address(Slot = "15")]
	HKDDEEJINEH GBDBCOGCGCH(RigidbodyEx HHJJKPNJLAD, POAMDCEFDPK PFDMLBFKIAP, JLBIHFBBGKJ OHOLEEOLBDH);
}
[Cpp2IlInjected.Token(Token = "0x2000014")]
public interface AEDPOFGENJL
{
	[Cpp2IlInjected.Token(Token = "0x60000D9")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void JLFMLIEHAJM(Vector3 PJCPHDDKADF, ForceMode BKPMKNNGNCO = ForceMode.Force);

	[Cpp2IlInjected.Token(Token = "0x60000DA")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void GELIKGECCKO(Vector3 PJCPHDDKADF, Vector3 AILFIIEAPKM, ForceMode BKPMKNNGNCO);

	[Cpp2IlInjected.Token(Token = "0x60000DB")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void LCIDAFFKJGM(Vector3 KNJIDLKEAOF, ForceMode BKPMKNNGNCO = ForceMode.Force);

	[Cpp2IlInjected.Token(Token = "0x60000DC")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void FFJJOMMAHGJ(Vector3 KNJIDLKEAOF, ForceMode BKPMKNNGNCO = ForceMode.Force);
}
[Cpp2IlInjected.Token(Token = "0x2000015")]
public interface AEAEHLIIIHM
{
	[Cpp2IlInjected.Token(Token = "0x17000038")]
	bool KILOFHHLCIA
	{
		[Cpp2IlInjected.Token(Token = "0x60000DD")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
		[Cpp2IlInjected.Token(Token = "0x60000DE")]
		[Cpp2IlInjected.Address(Slot = "1")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x60000DF")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void AKOMFNGCOKL(Rigidbody OPIJOIJPNML);

	[Cpp2IlInjected.Token(Token = "0x60000E0")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void IPMEDHDLDMK(Rigidbody OPIJOIJPNML);
}
[Cpp2IlInjected.Token(Token = "0x2000016")]
public interface CNJKFLKEHNP : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x17000039")]
	IReadOnlyList<HKDDEEJINEH> ENBMPJKJGMM
	{
		[Cpp2IlInjected.Token(Token = "0x60000F3")]
		[Cpp2IlInjected.Address(Slot = "18")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700003A")]
	HKDDEEJINEH DKBLNPELKCO
	{
		[Cpp2IlInjected.Token(Token = "0x60000F4")]
		[Cpp2IlInjected.Address(Slot = "19")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700003B")]
	HKDDEEJINEH ADEHKCCOJGF
	{
		[Cpp2IlInjected.Token(Token = "0x60000F5")]
		[Cpp2IlInjected.Address(Slot = "20")]
		get;
		[Cpp2IlInjected.Token(Token = "0x60000F6")]
		[Cpp2IlInjected.Address(Slot = "21")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x1400000B")]
	event HJACFJGDJJO HODIMEMGCKN;

	[Cpp2IlInjected.Token(Token = "0x1400000C")]
	event HJACFJGDJJO JOCICHKGDGM;

	[Cpp2IlInjected.Token(Token = "0x1400000D")]
	event IFKDBGJBMPP PJPLFEDKAAM;

	[Cpp2IlInjected.Token(Token = "0x1400000E")]
	event Action IHCICACDFEE;

	[Cpp2IlInjected.Token(Token = "0x1400000F")]
	event Action EDCBGJDLIAL;

	[Cpp2IlInjected.Token(Token = "0x14000010")]
	event Action<HKDDEEJINEH> DHPICOFBLBM;

	[Cpp2IlInjected.Token(Token = "0x14000011")]
	event Action<HKDDEEJINEH> LEDBDFPEEIB;

	[Cpp2IlInjected.Token(Token = "0x14000012")]
	event Action OLLBCABGMEI;

	[Cpp2IlInjected.Token(Token = "0x14000013")]
	event Action<HKDDEEJINEH> HJLHOPFFEKK;

	[Cpp2IlInjected.Token(Token = "0x60000F7")]
	[Cpp2IlInjected.Address(Slot = "22")]
	void HDGBCFAMPCN(HKDDEEJINEH KBFMMMPNLKE, bool LHLPPJCBNEM = false);
}
[Cpp2IlInjected.Token(Token = "0x2000017")]
public interface JMDJHBDFHNM
{
	[Cpp2IlInjected.Token(Token = "0x1700003C")]
	Vector3 JFADEILIBMM
	{
		[Cpp2IlInjected.Token(Token = "0x60000F8")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700003D")]
	Vector3 OFPFJJDNLBD
	{
		[Cpp2IlInjected.Token(Token = "0x60000F9")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x60000FA")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void AOOHAJPAHFH(HKDDEEJINEH LBLLNFOEKNE, object PFKLELGAJPH);

	[Cpp2IlInjected.Token(Token = "0x60000FB")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void MFOJFIKNOFA(object PFKLELGAJPH);
}
[Cpp2IlInjected.Token(Token = "0x2000018")]
public interface FHMHFKBPFEJ
{
	[Cpp2IlInjected.Token(Token = "0x1700003E")]
	Vector3 LAGIIOINLDG
	{
		[Cpp2IlInjected.Token(Token = "0x60000FE")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
		[Cpp2IlInjected.Token(Token = "0x60000FF")]
		[Cpp2IlInjected.Address(Slot = "3")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x1700003F")]
	Vector3 IFPDMFNNGAF
	{
		[Cpp2IlInjected.Token(Token = "0x6000100")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000040")]
	float EAFPGFDGIND
	{
		[Cpp2IlInjected.Token(Token = "0x6000101")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000041")]
	float OJDNJKNJAAN
	{
		[Cpp2IlInjected.Token(Token = "0x6000102")]
		[Cpp2IlInjected.Address(Slot = "6")]
		get;
		[Cpp2IlInjected.Token(Token = "0x6000103")]
		[Cpp2IlInjected.Address(Slot = "7")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000042")]
	Vector3 FPIAMPLDLPJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000104")]
		[Cpp2IlInjected.Address(Slot = "8")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000043")]
	Quaternion EDBMEAAFNGM
	{
		[Cpp2IlInjected.Token(Token = "0x6000105")]
		[Cpp2IlInjected.Address(Slot = "9")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x14000014")]
	event HJACFJGDJJO DHNBOAOHJFG;

	[Cpp2IlInjected.Token(Token = "0x6000106")]
	[Cpp2IlInjected.Address(Slot = "10")]
	void EGGEMACIFEN((Quaternion rot, Vector3 moments) IGICCOJIDDA);

	[Cpp2IlInjected.Token(Token = "0x6000107")]
	[Cpp2IlInjected.Address(Slot = "11")]
	void NDMOMLBEAEJ();

	[Cpp2IlInjected.Token(Token = "0x6000108")]
	[Cpp2IlInjected.Address(Slot = "12")]
	void IBKBPPNCAPO();

	[Cpp2IlInjected.Token(Token = "0x6000109")]
	[Cpp2IlInjected.Address(Slot = "13")]
	void AHJPIEKBAGK();

	[Cpp2IlInjected.Token(Token = "0x600010A")]
	[Cpp2IlInjected.Address(Slot = "14")]
	void AKOMFNGCOKL(Rigidbody OPIJOIJPNML);

	[Cpp2IlInjected.Token(Token = "0x600010B")]
	[Cpp2IlInjected.Address(Slot = "15")]
	void IPMEDHDLDMK(Rigidbody OPIJOIJPNML);

	[Cpp2IlInjected.Token(Token = "0x600010C")]
	[Cpp2IlInjected.Address(Slot = "16")]
	void GCBLHPDNFDB();
}
[Cpp2IlInjected.Token(Token = "0x2000019")]
public interface NOJOGIBNEOM
{
	[Cpp2IlInjected.Token(Token = "0x600010D")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void EKBEIHECLAM();

	[Cpp2IlInjected.Token(Token = "0x600010E")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void CEFMILCLFJN(object PFKLELGAJPH);

	[Cpp2IlInjected.Token(Token = "0x600010F")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void BCPDHMLIKGA(object PFKLELGAJPH);

	[Cpp2IlInjected.Token(Token = "0x6000110")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void CFNNIIIAENJ(HKDDEEJINEH HHJJKPNJLAD);

	[Cpp2IlInjected.Token(Token = "0x6000111")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void KDDBNDNFPEC(HKDDEEJINEH HHJJKPNJLAD);

	[Cpp2IlInjected.Token(Token = "0x6000112")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void PHFBKCGNAGE();
}
[Cpp2IlInjected.Token(Token = "0x200001A")]
public interface PPFMEJNLLFC
{
	[Cpp2IlInjected.Token(Token = "0x17000044")]
	bool EAAEJMCMHOM
	{
		[Cpp2IlInjected.Token(Token = "0x6000116")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x14000015")]
	event HJACFJGDJJO AIKMIOLKDDL;

	[Cpp2IlInjected.Token(Token = "0x6000115")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void JABFHFFOFFB();

	[Cpp2IlInjected.Token(Token = "0x6000117")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void GHPBAHFCNAI(object PFKLELGAJPH);

	[Cpp2IlInjected.Token(Token = "0x6000118")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void KEANJAENHKI(object PFKLELGAJPH);

	[Cpp2IlInjected.Token(Token = "0x6000119")]
	[Cpp2IlInjected.Address(Slot = "6")]
	void JKGNPHGDHEP(object PFKLELGAJPH, bool JJIMCKPIKFL);

	[Cpp2IlInjected.Token(Token = "0x600011A")]
	[Cpp2IlInjected.Address(Slot = "7")]
	IDisposable NJGCPDMJAEB();

	[Cpp2IlInjected.Token(Token = "0x600011B")]
	[Cpp2IlInjected.Address(Slot = "8")]
	void AKOMFNGCOKL(Rigidbody MAAIGBPPBFP);

	[Cpp2IlInjected.Token(Token = "0x600011C")]
	[Cpp2IlInjected.Address(Slot = "9")]
	void IPMEDHDLDMK(Rigidbody OPIJOIJPNML);
}
[Cpp2IlInjected.Token(Token = "0x200001B")]
public interface IHPGPDPIGPG : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x17000045")]
	bool OLIJLEJGNMI
	{
		[Cpp2IlInjected.Token(Token = "0x600011F")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000046")]
	bool BLFPMICGOPE
	{
		[Cpp2IlInjected.Token(Token = "0x6000120")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x14000016")]
	event HJACFJGDJJO AJIMHCJENHI;

	[Cpp2IlInjected.Token(Token = "0x6000121")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void EKBEIHECLAM();

	[Cpp2IlInjected.Token(Token = "0x6000122")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void EPMJNGFKGOJ(HKDDEEJINEH LBLLNFOEKNE);

	[Cpp2IlInjected.Token(Token = "0x6000123")]
	[Cpp2IlInjected.Address(Slot = "6")]
	void MMKKGNPOEMK(HKDDEEJINEH LBLLNFOEKNE);
}
[Cpp2IlInjected.Token(Token = "0x200001C")]
public interface KPIMHBGJADP
{
	[Cpp2IlInjected.Token(Token = "0x17000047")]
	bool KNJAHLAHOMB
	{
		[Cpp2IlInjected.Token(Token = "0x6000124")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
		[Cpp2IlInjected.Token(Token = "0x6000125")]
		[Cpp2IlInjected.Address(Slot = "1")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000048")]
	bool AAPLFACBCHC
	{
		[Cpp2IlInjected.Token(Token = "0x6000126")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000049")]
	RigidbodyConstraints BNDMKIOPOHA
	{
		[Cpp2IlInjected.Token(Token = "0x6000127")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
		[Cpp2IlInjected.Token(Token = "0x6000128")]
		[Cpp2IlInjected.Address(Slot = "4")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x6000129")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void AKOMFNGCOKL(Rigidbody OPIJOIJPNML);

	[Cpp2IlInjected.Token(Token = "0x600012A")]
	[Cpp2IlInjected.Address(Slot = "6")]
	void IPMEDHDLDMK(Rigidbody OPIJOIJPNML);
}
[Cpp2IlInjected.Token(Token = "0x200001D")]
public interface DLMELLONDOM
{
	[Cpp2IlInjected.Token(Token = "0x1700004A")]
	float OLGPPBCDIPC
	{
		[Cpp2IlInjected.Token(Token = "0x600012B")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
		[Cpp2IlInjected.Token(Token = "0x600012C")]
		[Cpp2IlInjected.Address(Slot = "1")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x1700004B")]
	float MILAOBCOIDB
	{
		[Cpp2IlInjected.Token(Token = "0x600012D")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
		[Cpp2IlInjected.Token(Token = "0x600012E")]
		[Cpp2IlInjected.Address(Slot = "3")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x600012F")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void AKOMFNGCOKL(Rigidbody OPIJOIJPNML);

	[Cpp2IlInjected.Token(Token = "0x6000130")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void IPMEDHDLDMK(Rigidbody OPIJOIJPNML);
}
[Cpp2IlInjected.Token(Token = "0x200001E")]
public interface GNMJHODGFIG
{
	[Cpp2IlInjected.Token(Token = "0x6000131")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void OnRootRBEXChanged(RigidbodyEx LJPEHOKCLPG);
}
[Cpp2IlInjected.Token(Token = "0x200001F")]
public interface KPOOLPDCCMI
{
	[Cpp2IlInjected.Token(Token = "0x14000017")]
	event HJACFJGDJJO FPONCMMAGCA;

	[Cpp2IlInjected.Token(Token = "0x6000134")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void EKBEIHECLAM();

	[Cpp2IlInjected.Token(Token = "0x6000135")]
	[Cpp2IlInjected.Address(Slot = "3")]
	bool LOELNNODNDF();

	[Cpp2IlInjected.Token(Token = "0x6000136")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void NBMHCNLDPDP();

	[Cpp2IlInjected.Token(Token = "0x6000137")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void JBPIAAMLKCO();

	[Cpp2IlInjected.Token(Token = "0x6000138")]
	[Cpp2IlInjected.Address(Slot = "6")]
	void OFBMHPGIINO();

	[Cpp2IlInjected.Token(Token = "0x6000139")]
	[Cpp2IlInjected.Address(Slot = "7")]
	void NMDENCFDKJJ();

	[Cpp2IlInjected.Token(Token = "0x600013A")]
	[Cpp2IlInjected.Address(Slot = "8")]
	void HMMDNFNCIPM(bool IMPHHDIGJPJ);
}
[Cpp2IlInjected.Token(Token = "0x2000020")]
public interface IMMDALGJOAC
{
	[Cpp2IlInjected.Token(Token = "0x1700004C")]
	Rigidbody PEOFAJLGEEJ
	{
		[Cpp2IlInjected.Token(Token = "0x600013B")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700004D")]
	bool IOFOHBAAMME
	{
		[Cpp2IlInjected.Token(Token = "0x600013D")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x600013C")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void EKBEIHECLAM();

	[Cpp2IlInjected.Token(Token = "0x600013E")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void OJJAOMJIFMM(object PFKLELGAJPH);

	[Cpp2IlInjected.Token(Token = "0x600013F")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void IIIGLEPLPKA(object PFKLELGAJPH);

	[Cpp2IlInjected.Token(Token = "0x6000140")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void JNNPGHIKFLG();

	[Cpp2IlInjected.Token(Token = "0x6000141")]
	[Cpp2IlInjected.Address(Slot = "6")]
	void GJMECAEMJDK();
}
[Cpp2IlInjected.Token(Token = "0x2000021")]
public interface EDHOGNBFGNL : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x1700004E")]
	LBJHINFHGBL JNGDLEGDDIJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000142")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
		[Cpp2IlInjected.Token(Token = "0x6000143")]
		[Cpp2IlInjected.Address(Slot = "1")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x1700004F")]
	JOFEBGGLMFG NDNIBPFIBJI
	{
		[Cpp2IlInjected.Token(Token = "0x6000144")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
		[Cpp2IlInjected.Token(Token = "0x6000145")]
		[Cpp2IlInjected.Address(Slot = "3")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000050")]
	Vector3 EGDFHNKFGGC
	{
		[Cpp2IlInjected.Token(Token = "0x6000146")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
		[Cpp2IlInjected.Token(Token = "0x6000147")]
		[Cpp2IlInjected.Address(Slot = "5")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000051")]
	Vector3 KHBEFLDEFGN
	{
		[Cpp2IlInjected.Token(Token = "0x6000148")]
		[Cpp2IlInjected.Address(Slot = "6")]
		get;
		[Cpp2IlInjected.Token(Token = "0x6000149")]
		[Cpp2IlInjected.Address(Slot = "7")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000052")]
	Vector3 ECOGONCAENI
	{
		[Cpp2IlInjected.Token(Token = "0x600014A")]
		[Cpp2IlInjected.Address(Slot = "8")]
		get;
		[Cpp2IlInjected.Token(Token = "0x600014B")]
		[Cpp2IlInjected.Address(Slot = "9")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000053")]
	Vector3 JJILBICKFBG
	{
		[Cpp2IlInjected.Token(Token = "0x600014C")]
		[Cpp2IlInjected.Address(Slot = "10")]
		get;
		[Cpp2IlInjected.Token(Token = "0x600014D")]
		[Cpp2IlInjected.Address(Slot = "11")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000054")]
	float EIKOHCLDIBJ
	{
		[Cpp2IlInjected.Token(Token = "0x600014E")]
		[Cpp2IlInjected.Address(Slot = "12")]
		get;
		[Cpp2IlInjected.Token(Token = "0x600014F")]
		[Cpp2IlInjected.Address(Slot = "13")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000055")]
	bool OAKBMOAOCEK
	{
		[Cpp2IlInjected.Token(Token = "0x6000150")]
		[Cpp2IlInjected.Address(Slot = "14")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000151")]
	[Cpp2IlInjected.Address(Slot = "15")]
	void EKBEIHECLAM();

	[Cpp2IlInjected.Token(Token = "0x6000152")]
	[Cpp2IlInjected.Address(Slot = "16")]
	void HLBGFKCDKNL(object PFKLELGAJPH);

	[Cpp2IlInjected.Token(Token = "0x6000153")]
	[Cpp2IlInjected.Address(Slot = "17")]
	void IGMBNACPLCP(BPMLBDGOAAA KPBLKDJONKA, Vector3 KHAGNCFGGLP, float DGAGPLDFBFA = float.PositiveInfinity);

	[Cpp2IlInjected.Token(Token = "0x6000154")]
	[Cpp2IlInjected.Address(Slot = "18")]
	void JJLPMJIAECP(CAJLMHPONNG ODONFGMOICG, Vector3 EBGKJLMCJAI, float EMBPADILADB, float ICDNFDHOPEF = 8f, float PKMFLEJBFBB = 1f);

	[Cpp2IlInjected.Token(Token = "0x6000155")]
	[Cpp2IlInjected.Address(Slot = "19")]
	void CPOAAEBFFIL(BPMLBDGOAAA KPBLKDJONKA, Vector3 GIBIBDOGOLL, float MLEKCJEEFGK = 7f, float JGPJAKHDFMM = 1f);

	[Cpp2IlInjected.Token(Token = "0x6000156")]
	[Cpp2IlInjected.Address(Slot = "20")]
	void OMPFMFEHIPL();

	[Cpp2IlInjected.Token(Token = "0x6000157")]
	[Cpp2IlInjected.Address(Slot = "21")]
	void ODLAHMAHHIG();

	[Cpp2IlInjected.Token(Token = "0x6000158")]
	[Cpp2IlInjected.Address(Slot = "22")]
	void BMNABPGBMMB();

	[Cpp2IlInjected.Token(Token = "0x6000159")]
	[Cpp2IlInjected.Address(Slot = "23")]
	void ALNKOFBADLM();

	[Cpp2IlInjected.Token(Token = "0x600015A")]
	[Cpp2IlInjected.Address(Slot = "24")]
	void AKOMFNGCOKL(Rigidbody OPIJOIJPNML);

	[Cpp2IlInjected.Token(Token = "0x600015B")]
	[Cpp2IlInjected.Address(Slot = "25")]
	Vector3 KOMLCDOJFGP(Vector3 HPJBBHHJIEL);

	[Cpp2IlInjected.Token(Token = "0x600015C")]
	[Cpp2IlInjected.Address(Slot = "26")]
	void FAPJAIJOLLB(object PFKLELGAJPH);

	[Cpp2IlInjected.Token(Token = "0x600015D")]
	[Cpp2IlInjected.Address(Slot = "27")]
	void FEGGONCBCAB(Vector3 MBCLMEKNIMH);

	[Cpp2IlInjected.Token(Token = "0x600015E")]
	[Cpp2IlInjected.Address(Slot = "28")]
	void KCHGHBEHDOP(Vector3 NNHCKKDHDOO, Vector3 MKPDHJELIJH);

	[Cpp2IlInjected.Token(Token = "0x600015F")]
	[Cpp2IlInjected.Address(Slot = "29")]
	void COIPDHOKFEA(Vector3 LCEEOGHIEAE, Vector3 CMCJGKKIFGK);

	[Cpp2IlInjected.Token(Token = "0x6000160")]
	[Cpp2IlInjected.Address(Slot = "30")]
	Vector3 KFOJABECPNA(Vector3 CBFMJBCAHHF);

	[Cpp2IlInjected.Token(Token = "0x6000161")]
	[Cpp2IlInjected.Address(Slot = "31")]
	Vector3 ILHPDEBIDPO(Vector3 FCKPHPBMNBE);
}
[Cpp2IlInjected.Token(Token = "0x2000022")]
[FEFNBKCFPJG(DAEAEJBLHHK.Application)]
public interface JAGPNGGKMIK
{
	[Cpp2IlInjected.Token(Token = "0x17000056")]
	bool OHBBFJCEBEM
	{
		[Cpp2IlInjected.Token(Token = "0x6000162")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000163")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void KFELHPDHJKB(string OGJCCLJIEPL);

	[Cpp2IlInjected.Token(Token = "0x6000164")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void EOPJMABJMPE(RigidbodyEx HHJJKPNJLAD, Action HMHDIIODGFG);

	[Cpp2IlInjected.Token(Token = "0x6000165")]
	[Cpp2IlInjected.Address(Slot = "3")]
	PKLEFBNKEMB PGNIJJIHFOB(int IDOKCPHNACA);

	[Cpp2IlInjected.Token(Token = "0x6000166")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void GJLPHLCHNAN(Vector3 KPBPPDHFDDO, float GBOIKHDLBKH, Color BJLKCDOCMJA);
}
[Cpp2IlInjected.Token(Token = "0x2000023")]
[FEFNBKCFPJG(DAEAEJBLHHK.Application)]
public interface JLBIHFBBGKJ
{
	[Cpp2IlInjected.Token(Token = "0x17000057")]
	JAGPNGGKMIK FHMIKKFADBO
	{
		[Cpp2IlInjected.Token(Token = "0x6000167")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000058")]
	OIJLNKKGFII PHAOEEKJDCA
	{
		[Cpp2IlInjected.Token(Token = "0x6000168")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000169")]
	[Cpp2IlInjected.Address(Slot = "2")]
	JBMJEBCFLLB NLKAGJFNPMP(RigidbodyEx HHJJKPNJLAD);

	[Cpp2IlInjected.Token(Token = "0x600016A")]
	[Cpp2IlInjected.Address(Slot = "3")]
	HKDDEEJINEH GBDBCOGCGCH(RigidbodyEx HHJJKPNJLAD, POAMDCEFDPK PFDMLBFKIAP);
}
[Cpp2IlInjected.Token(Token = "0x2000024")]
public interface JOFEBGGLMFG
{
	[Cpp2IlInjected.Token(Token = "0x600016B")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void GCDGFFEFDDO(Vector3 FKCBMOBHPBE);

	[Cpp2IlInjected.Token(Token = "0x600016C")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void IALALOMLCKJ(Vector3 LMHADGEOOGN);

	[Cpp2IlInjected.Token(Token = "0x600016D")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void NNCMNBNFDJF(Vector3 FKCBMOBHPBE);

	[Cpp2IlInjected.Token(Token = "0x600016E")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void FEGNCBIFGHA(Vector3 LMHADGEOOGN);
}
[Cpp2IlInjected.Token(Token = "0x2000025")]
public interface LBJHINFHGBL : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x600016F")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Vector3 IGMHJOMEDJM();

	[Cpp2IlInjected.Token(Token = "0x6000170")]
	[Cpp2IlInjected.Address(Slot = "1")]
	Vector3 DIEBBBOOKKJ();
}
[Cpp2IlInjected.Token(Token = "0x2000026")]
public interface HKDDEEJINEH : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x17000059")]
	Rigidbody PEOFAJLGEEJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000171")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700005A")]
	RigidbodyEx CCGDNDPOLDJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000172")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700005B")]
	GameObject JJBLAIFLMNG
	{
		[Cpp2IlInjected.Token(Token = "0x6000173")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700005C")]
	Transform HFGEDEDEGAG
	{
		[Cpp2IlInjected.Token(Token = "0x6000174")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700005D")]
	HKDDEEJINEH ADEHKCCOJGF
	{
		[Cpp2IlInjected.Token(Token = "0x6000175")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
		[Cpp2IlInjected.Token(Token = "0x6000176")]
		[Cpp2IlInjected.Address(Slot = "5")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x1700005E")]
	IReadOnlyList<HKDDEEJINEH> ENBMPJKJGMM
	{
		[Cpp2IlInjected.Token(Token = "0x6000177")]
		[Cpp2IlInjected.Address(Slot = "6")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700005F")]
	HKDDEEJINEH DKBLNPELKCO
	{
		[Cpp2IlInjected.Token(Token = "0x6000178")]
		[Cpp2IlInjected.Address(Slot = "7")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000060")]
	bool OLIJLEJGNMI
	{
		[Cpp2IlInjected.Token(Token = "0x6000179")]
		[Cpp2IlInjected.Address(Slot = "8")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000061")]
	bool BLFPMICGOPE
	{
		[Cpp2IlInjected.Token(Token = "0x600017A")]
		[Cpp2IlInjected.Address(Slot = "9")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000062")]
	LBJHINFHGBL JNGDLEGDDIJ
	{
		[Cpp2IlInjected.Token(Token = "0x600017B")]
		[Cpp2IlInjected.Address(Slot = "10")]
		get;
		[Cpp2IlInjected.Token(Token = "0x600017C")]
		[Cpp2IlInjected.Address(Slot = "11")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000063")]
	JOFEBGGLMFG NDNIBPFIBJI
	{
		[Cpp2IlInjected.Token(Token = "0x600017D")]
		[Cpp2IlInjected.Address(Slot = "12")]
		get;
		[Cpp2IlInjected.Token(Token = "0x600017E")]
		[Cpp2IlInjected.Address(Slot = "13")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000064")]
	float EIKOHCLDIBJ
	{
		[Cpp2IlInjected.Token(Token = "0x600017F")]
		[Cpp2IlInjected.Address(Slot = "14")]
		get;
		[Cpp2IlInjected.Token(Token = "0x6000180")]
		[Cpp2IlInjected.Address(Slot = "15")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000065")]
	Vector3 KHBEFLDEFGN
	{
		[Cpp2IlInjected.Token(Token = "0x6000181")]
		[Cpp2IlInjected.Address(Slot = "16")]
		get;
		[Cpp2IlInjected.Token(Token = "0x6000182")]
		[Cpp2IlInjected.Address(Slot = "17")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000066")]
	Vector3 JJILBICKFBG
	{
		[Cpp2IlInjected.Token(Token = "0x6000183")]
		[Cpp2IlInjected.Address(Slot = "18")]
		get;
		[Cpp2IlInjected.Token(Token = "0x6000184")]
		[Cpp2IlInjected.Address(Slot = "19")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000067")]
	Vector3 EGDFHNKFGGC
	{
		[Cpp2IlInjected.Token(Token = "0x6000185")]
		[Cpp2IlInjected.Address(Slot = "20")]
		get;
		[Cpp2IlInjected.Token(Token = "0x6000186")]
		[Cpp2IlInjected.Address(Slot = "21")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000068")]
	Vector3 ECOGONCAENI
	{
		[Cpp2IlInjected.Token(Token = "0x6000187")]
		[Cpp2IlInjected.Address(Slot = "22")]
		get;
		[Cpp2IlInjected.Token(Token = "0x6000188")]
		[Cpp2IlInjected.Address(Slot = "23")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000069")]
	bool NNJBEOGIMBG
	{
		[Cpp2IlInjected.Token(Token = "0x6000189")]
		[Cpp2IlInjected.Address(Slot = "24")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700006A")]
	bool BPBHDJCNMPF
	{
		[Cpp2IlInjected.Token(Token = "0x600018A")]
		[Cpp2IlInjected.Address(Slot = "25")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700006B")]
	bool OAKBMOAOCEK
	{
		[Cpp2IlInjected.Token(Token = "0x600018B")]
		[Cpp2IlInjected.Address(Slot = "26")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700006C")]
	Vector3 JFADEILIBMM
	{
		[Cpp2IlInjected.Token(Token = "0x600018C")]
		[Cpp2IlInjected.Address(Slot = "27")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700006D")]
	Vector3 OFPFJJDNLBD
	{
		[Cpp2IlInjected.Token(Token = "0x600018D")]
		[Cpp2IlInjected.Address(Slot = "28")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700006E")]
	Vector3 LAGIIOINLDG
	{
		[Cpp2IlInjected.Token(Token = "0x600018E")]
		[Cpp2IlInjected.Address(Slot = "29")]
		get;
		[Cpp2IlInjected.Token(Token = "0x600018F")]
		[Cpp2IlInjected.Address(Slot = "30")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x1700006F")]
	Vector3 IFPDMFNNGAF
	{
		[Cpp2IlInjected.Token(Token = "0x6000190")]
		[Cpp2IlInjected.Address(Slot = "31")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000070")]
	float EAFPGFDGIND
	{
		[Cpp2IlInjected.Token(Token = "0x6000191")]
		[Cpp2IlInjected.Address(Slot = "32")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000071")]
	float OJDNJKNJAAN
	{
		[Cpp2IlInjected.Token(Token = "0x6000192")]
		[Cpp2IlInjected.Address(Slot = "33")]
		get;
		[Cpp2IlInjected.Token(Token = "0x6000193")]
		[Cpp2IlInjected.Address(Slot = "34")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000072")]
	Vector3 FPIAMPLDLPJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000194")]
		[Cpp2IlInjected.Address(Slot = "35")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000073")]
	Quaternion EDBMEAAFNGM
	{
		[Cpp2IlInjected.Token(Token = "0x6000195")]
		[Cpp2IlInjected.Address(Slot = "36")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000074")]
	float OLGPPBCDIPC
	{
		[Cpp2IlInjected.Token(Token = "0x6000197")]
		[Cpp2IlInjected.Address(Slot = "38")]
		get;
		[Cpp2IlInjected.Token(Token = "0x6000198")]
		[Cpp2IlInjected.Address(Slot = "39")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000075")]
	float MILAOBCOIDB
	{
		[Cpp2IlInjected.Token(Token = "0x6000199")]
		[Cpp2IlInjected.Address(Slot = "40")]
		get;
		[Cpp2IlInjected.Token(Token = "0x600019A")]
		[Cpp2IlInjected.Address(Slot = "41")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000076")]
	bool KILOFHHLCIA
	{
		[Cpp2IlInjected.Token(Token = "0x600019B")]
		[Cpp2IlInjected.Address(Slot = "42")]
		get;
		[Cpp2IlInjected.Token(Token = "0x600019C")]
		[Cpp2IlInjected.Address(Slot = "43")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000077")]
	EPMFMHNHMEG PKEADPGLIAA
	{
		[Cpp2IlInjected.Token(Token = "0x600019D")]
		[Cpp2IlInjected.Address(Slot = "44")]
		get;
		[Cpp2IlInjected.Token(Token = "0x600019E")]
		[Cpp2IlInjected.Address(Slot = "45")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000078")]
	bool EAAEJMCMHOM
	{
		[Cpp2IlInjected.Token(Token = "0x600019F")]
		[Cpp2IlInjected.Address(Slot = "46")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000079")]
	Transform PHLFANIJOKI
	{
		[Cpp2IlInjected.Token(Token = "0x60001A0")]
		[Cpp2IlInjected.Address(Slot = "47")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700007A")]
	Vector3 COKHGDLHIBE
	{
		[Cpp2IlInjected.Token(Token = "0x60001A1")]
		[Cpp2IlInjected.Address(Slot = "48")]
		get;
		[Cpp2IlInjected.Token(Token = "0x60001A2")]
		[Cpp2IlInjected.Address(Slot = "49")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x1700007B")]
	float OFMEOPGKNHB
	{
		[Cpp2IlInjected.Token(Token = "0x60001A3")]
		[Cpp2IlInjected.Address(Slot = "50")]
		get;
		[Cpp2IlInjected.Token(Token = "0x60001A4")]
		[Cpp2IlInjected.Address(Slot = "51")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x1700007C")]
	float ODAENDJNKNL
	{
		[Cpp2IlInjected.Token(Token = "0x60001A5")]
		[Cpp2IlInjected.Address(Slot = "52")]
		get;
		[Cpp2IlInjected.Token(Token = "0x60001A6")]
		[Cpp2IlInjected.Address(Slot = "53")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x1700007D")]
	Quaternion DHOHNGCOPAD
	{
		[Cpp2IlInjected.Token(Token = "0x60001A7")]
		[Cpp2IlInjected.Address(Slot = "54")]
		get;
		[Cpp2IlInjected.Token(Token = "0x60001A8")]
		[Cpp2IlInjected.Address(Slot = "55")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x1700007E")]
	Vector3 IINMIFPFDIC
	{
		[Cpp2IlInjected.Token(Token = "0x60001A9")]
		[Cpp2IlInjected.Address(Slot = "56")]
		get;
		[Cpp2IlInjected.Token(Token = "0x60001AA")]
		[Cpp2IlInjected.Address(Slot = "57")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x1700007F")]
	Quaternion KEJKODFGKBE
	{
		[Cpp2IlInjected.Token(Token = "0x60001AB")]
		[Cpp2IlInjected.Address(Slot = "58")]
		get;
		[Cpp2IlInjected.Token(Token = "0x60001AC")]
		[Cpp2IlInjected.Address(Slot = "59")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000080")]
	RigidbodyConstraints BNDMKIOPOHA
	{
		[Cpp2IlInjected.Token(Token = "0x60001AD")]
		[Cpp2IlInjected.Address(Slot = "60")]
		get;
		[Cpp2IlInjected.Token(Token = "0x60001AE")]
		[Cpp2IlInjected.Address(Slot = "61")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000081")]
	bool KNJAHLAHOMB
	{
		[Cpp2IlInjected.Token(Token = "0x60001AF")]
		[Cpp2IlInjected.Address(Slot = "62")]
		get;
		[Cpp2IlInjected.Token(Token = "0x60001B0")]
		[Cpp2IlInjected.Address(Slot = "63")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000082")]
	CollisionDetectionMode DGLKEBEJHFH
	{
		[Cpp2IlInjected.Token(Token = "0x60001B1")]
		[Cpp2IlInjected.Address(Slot = "64")]
		get;
		[Cpp2IlInjected.Token(Token = "0x60001B2")]
		[Cpp2IlInjected.Address(Slot = "65")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000083")]
	bool DFDBDNANPGP
	{
		[Cpp2IlInjected.Token(Token = "0x60001B3")]
		[Cpp2IlInjected.Address(Slot = "66")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x14000018")]
	event HJACFJGDJJO HODIMEMGCKN;

	[Cpp2IlInjected.Token(Token = "0x14000019")]
	event HJACFJGDJJO JOCICHKGDGM;

	[Cpp2IlInjected.Token(Token = "0x1400001A")]
	event IFKDBGJBMPP PJPLFEDKAAM;

	[Cpp2IlInjected.Token(Token = "0x1400001B")]
	event HJACFJGDJJO AJIMHCJENHI;

	[Cpp2IlInjected.Token(Token = "0x1400001C")]
	event HJACFJGDJJO ODNGMOBPALO;

	[Cpp2IlInjected.Token(Token = "0x1400001D")]
	event HJACFJGDJJO FPONCMMAGCA;

	[Cpp2IlInjected.Token(Token = "0x1400001E")]
	event Action<KFCLLDKJIGN, KFCLLDKJIGN> NIPMFJHHIKK;

	[Cpp2IlInjected.Token(Token = "0x1400001F")]
	event HJACFJGDJJO AIKMIOLKDDL;

	[Cpp2IlInjected.Token(Token = "0x14000020")]
	event HJACFJGDJJO EDNEIGNLNHG;

	[Cpp2IlInjected.Token(Token = "0x6000196")]
	[Cpp2IlInjected.Address(Slot = "37")]
	void EGGEMACIFEN((Quaternion rot, Vector3 moments) IGICCOJIDDA);

	[Cpp2IlInjected.Token(Token = "0x60001B4")]
	[Cpp2IlInjected.Address(Slot = "67")]
	void EKBEIHECLAM();

	[Cpp2IlInjected.Token(Token = "0x60001B5")]
	[Cpp2IlInjected.Address(Slot = "68")]
	void DPKGHMKJIKO();

	[Cpp2IlInjected.Token(Token = "0x60001B6")]
	[Cpp2IlInjected.Address(Slot = "69")]
	void GIMKODEGOKH();

	[Cpp2IlInjected.Token(Token = "0x60001B7")]
	[Cpp2IlInjected.Address(Slot = "70")]
	void JBPIAAMLKCO();

	[Cpp2IlInjected.Token(Token = "0x60001BE")]
	[Cpp2IlInjected.Address(Slot = "77")]
	void HDGBCFAMPCN(HKDDEEJINEH GNLEHBFFNFG, bool LHLPPJCBNEM = false);

	[Cpp2IlInjected.Token(Token = "0x60001C1")]
	[Cpp2IlInjected.Address(Slot = "80")]
	void HFENMPHFOKA(object PFKLELGAJPH);

	[Cpp2IlInjected.Token(Token = "0x60001C2")]
	[Cpp2IlInjected.Address(Slot = "81")]
	void INLGLFPHKKN(object PFKLELGAJPH);

	[Cpp2IlInjected.Token(Token = "0x60001C3")]
	[Cpp2IlInjected.Address(Slot = "82")]
	Vector3 ILHPDEBIDPO(Vector3 FCKPHPBMNBE);

	[Cpp2IlInjected.Token(Token = "0x60001C4")]
	[Cpp2IlInjected.Address(Slot = "83")]
	Vector3 KFOJABECPNA(Vector3 CBFMJBCAHHF);

	[Cpp2IlInjected.Token(Token = "0x60001C5")]
	[Cpp2IlInjected.Address(Slot = "84")]
	void ALNKOFBADLM();

	[Cpp2IlInjected.Token(Token = "0x60001C6")]
	[Cpp2IlInjected.Address(Slot = "85")]
	void ODLAHMAHHIG();

	[Cpp2IlInjected.Token(Token = "0x60001C7")]
	[Cpp2IlInjected.Address(Slot = "86")]
	void OMPFMFEHIPL();

	[Cpp2IlInjected.Token(Token = "0x60001C8")]
	[Cpp2IlInjected.Address(Slot = "87")]
	void COIPDHOKFEA(Vector3 LCEEOGHIEAE, Vector3 CMCJGKKIFGK);

	[Cpp2IlInjected.Token(Token = "0x60001C9")]
	[Cpp2IlInjected.Address(Slot = "88")]
	void KCHGHBEHDOP(Vector3 NNHCKKDHDOO, Vector3 MKPDHJELIJH);

	[Cpp2IlInjected.Token(Token = "0x60001CA")]
	[Cpp2IlInjected.Address(Slot = "89")]
	void FEGGONCBCAB(Vector3 MBCLMEKNIMH);

	[Cpp2IlInjected.Token(Token = "0x60001CB")]
	[Cpp2IlInjected.Address(Slot = "90")]
	void JJLPMJIAECP(CAJLMHPONNG ODONFGMOICG, Vector3 EBGKJLMCJAI, float EMBPADILADB, float ICDNFDHOPEF = 8f, float PKMFLEJBFBB = 1f);

	[Cpp2IlInjected.Token(Token = "0x60001CC")]
	[Cpp2IlInjected.Address(Slot = "91")]
	void IGMBNACPLCP(BPMLBDGOAAA KPBLKDJONKA, Vector3 KHAGNCFGGLP, float DGAGPLDFBFA = float.PositiveInfinity);

	[Cpp2IlInjected.Token(Token = "0x60001CD")]
	[Cpp2IlInjected.Address(Slot = "92")]
	void CPOAAEBFFIL(BPMLBDGOAAA KPBLKDJONKA, Vector3 GIBIBDOGOLL, float MLEKCJEEFGK = 7f, float JGPJAKHDFMM = 1f);

	[Cpp2IlInjected.Token(Token = "0x60001CE")]
	[Cpp2IlInjected.Address(Slot = "93")]
	Vector3 KOMLCDOJFGP(Vector3 GNLEHBFFNFG);

	[Cpp2IlInjected.Token(Token = "0x60001CF")]
	[Cpp2IlInjected.Address(Slot = "94")]
	Vector3 HPPNGLOONCP(Vector3 GNLEHBFFNFG);

	[Cpp2IlInjected.Token(Token = "0x60001D0")]
	[Cpp2IlInjected.Address(Slot = "95")]
	void BMNABPGBMMB();

	[Cpp2IlInjected.Token(Token = "0x60001D1")]
	[Cpp2IlInjected.Address(Slot = "96")]
	void HHEHDIAENMJ(HKDDEEJINEH CIBBEIAHJJB, object PFKLELGAJPH);

	[Cpp2IlInjected.Token(Token = "0x60001D2")]
	[Cpp2IlInjected.Address(Slot = "97")]
	void NDAFIEKOHMG(object PFKLELGAJPH);

	[Cpp2IlInjected.Token(Token = "0x60001D5")]
	[Cpp2IlInjected.Address(Slot = "100")]
	void IBKBPPNCAPO();

	[Cpp2IlInjected.Token(Token = "0x60001D6")]
	[Cpp2IlInjected.Address(Slot = "101")]
	void NDMOMLBEAEJ();

	[Cpp2IlInjected.Token(Token = "0x60001D7")]
	[Cpp2IlInjected.Address(Slot = "102")]
	void AHJPIEKBAGK();

	[Cpp2IlInjected.Token(Token = "0x60001DA")]
	[Cpp2IlInjected.Address(Slot = "105")]
	bool LOELNNODNDF();

	[Cpp2IlInjected.Token(Token = "0x60001DB")]
	[Cpp2IlInjected.Address(Slot = "106")]
	void NMDENCFDKJJ();

	[Cpp2IlInjected.Token(Token = "0x60001E0")]
	[Cpp2IlInjected.Address(Slot = "111")]
	IDisposable NJGCPDMJAEB();

	[Cpp2IlInjected.Token(Token = "0x60001E1")]
	[Cpp2IlInjected.Address(Slot = "112")]
	void GHPBAHFCNAI(object PFKLELGAJPH);

	[Cpp2IlInjected.Token(Token = "0x60001E2")]
	[Cpp2IlInjected.Address(Slot = "113")]
	void KEANJAENHKI(object PFKLELGAJPH);

	[Cpp2IlInjected.Token(Token = "0x60001E3")]
	[Cpp2IlInjected.Address(Slot = "114")]
	void JKGNPHGDHEP(object PFKLELGAJPH, bool JJIMCKPIKFL);

	[Cpp2IlInjected.Token(Token = "0x60001E6")]
	[Cpp2IlInjected.Address(Slot = "117")]
	void LOJHDBLLLPK(Vector3 KMDPKMLFOLC, Quaternion KGOHNEKGJFD);

	[Cpp2IlInjected.Token(Token = "0x60001E7")]
	[Cpp2IlInjected.Address(Slot = "118")]
	void MMCFACKGGID(Vector3 IAOBMGELIKG, Quaternion BIOBPMHCIFO);

	[Cpp2IlInjected.Token(Token = "0x60001E8")]
	[Cpp2IlInjected.Address(Slot = "119")]
	bool HBFAJFCHBIE(float OFPMODDPBDG);

	[Cpp2IlInjected.Token(Token = "0x60001E9")]
	[Cpp2IlInjected.Address(Slot = "120")]
	void EHBMDIMOOPP(object PFKLELGAJPH);

	[Cpp2IlInjected.Token(Token = "0x60001EA")]
	[Cpp2IlInjected.Address(Slot = "121")]
	void EOMADFNHNCE(object PFKLELGAJPH);

	[Cpp2IlInjected.Token(Token = "0x60001EB")]
	[Cpp2IlInjected.Address(Slot = "122")]
	void OJJAOMJIFMM(object PFKLELGAJPH);

	[Cpp2IlInjected.Token(Token = "0x60001EC")]
	[Cpp2IlInjected.Address(Slot = "123")]
	void IIIGLEPLPKA(object PFKLELGAJPH);

	[Cpp2IlInjected.Token(Token = "0x60001ED")]
	[Cpp2IlInjected.Address(Slot = "124")]
	void JLFMLIEHAJM(Vector3 PJCPHDDKADF, ForceMode BKPMKNNGNCO = ForceMode.Force);

	[Cpp2IlInjected.Token(Token = "0x60001EE")]
	[Cpp2IlInjected.Address(Slot = "125")]
	void GELIKGECCKO(Vector3 PJCPHDDKADF, Vector3 AILFIIEAPKM, ForceMode BKPMKNNGNCO);

	[Cpp2IlInjected.Token(Token = "0x60001EF")]
	[Cpp2IlInjected.Address(Slot = "126")]
	void LCIDAFFKJGM(Vector3 KNJIDLKEAOF, ForceMode BKPMKNNGNCO = ForceMode.Force);

	[Cpp2IlInjected.Token(Token = "0x60001F0")]
	[Cpp2IlInjected.Address(Slot = "127")]
	void FFJJOMMAHGJ(Vector3 KNJIDLKEAOF, ForceMode BKPMKNNGNCO = ForceMode.Force);

	[Cpp2IlInjected.Token(Token = "0x60001F1")]
	[Cpp2IlInjected.Address(Slot = "128")]
	bool IMCFKJILCKH(Vector3 IELHLOGPMDL, [Out] RaycastHit PEGDGELCHOI, float NGLNDDJFMFL);

	[Cpp2IlInjected.Token(Token = "0x60001F2")]
	[Cpp2IlInjected.Address(Slot = "129")]
	void GCBLHPDNFDB();
}
[Cpp2IlInjected.Token(Token = "0x2000027")]
public class KOAFFLFFEOP : HKDDEEJINEH, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400002C")]
	internal readonly JLBIHFBBGKJ OHOLEEOLBDH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400002D")]
	internal CNJKFLKEHNP IAMHOIOBMOB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400002E")]
	internal NOJOGIBNEOM DGJIFAILGOH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400002F")]
	internal IHPGPDPIGPG JKMCJDKCAIG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000030")]
	internal EDHOGNBFGNL HPJBBHHJIEL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000031")]
	internal JMDJHBDFHNM LGIFHGIKGAN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000032")]
	internal FHMHFKBPFEJ GGIKMCOMAMA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000033")]
	internal DLMELLONDOM EPCHKIILNKD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000034")]
	internal AEAEHLIIIHM DKAICENGAEJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x4000035")]
	internal KPOOLPDCCMI FMMMJEMIBLN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x4000036")]
	internal IBDFGCOAOJH LBPPIELBJAA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x4000037")]
	internal PPFMEJNLLFC HNEDIAMDDEC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x4000038")]
	internal AEDPOFGENJL PJCPHDDKADF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
	[Cpp2IlInjected.Token(Token = "0x4000039")]
	internal KPIMHBGJADP GBINODOMKFG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x400003A")]
	internal IMMDALGJOAC OPIJOIJPNML;

	[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
	[Cpp2IlInjected.Token(Token = "0x400003B")]
	internal DOLMCKAIMMH IBNFFHEDDHC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
	[Cpp2IlInjected.Token(Token = "0x400003C")]
	internal IDisposable ALEDELODBCH;

	[Cpp2IlInjected.Token(Token = "0x17000084")]
	public RigidbodyEx CCGDNDPOLDJ
	{
		[Cpp2IlInjected.Token(Token = "0x60001F3")]
		[Cpp2IlInjected.Address(RVA = "0x76FC50", Offset = "0x76EA50", VA = "0x18076FC50", Slot = "5")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60001F4")]
		[Cpp2IlInjected.Address(RVA = "0x76FC70", Offset = "0x76EA70", VA = "0x18076FC70")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000085")]
	public GameObject JJBLAIFLMNG
	{
		[Cpp2IlInjected.Token(Token = "0x60001F5")]
		[Cpp2IlInjected.Address(RVA = "0x89C9D0", Offset = "0x89B7D0", VA = "0x18089C9D0", Slot = "6")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60001F6")]
		[Cpp2IlInjected.Address(RVA = "0x89B2F0", Offset = "0x89A0F0", VA = "0x18089B2F0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000086")]
	public Transform HFGEDEDEGAG
	{
		[Cpp2IlInjected.Token(Token = "0x60001F7")]
		[Cpp2IlInjected.Address(RVA = "0x62264F0", Offset = "0x62252F0", VA = "0x1862264F0", Slot = "7")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000087")]
	public Rigidbody PEOFAJLGEEJ
	{
		[Cpp2IlInjected.Token(Token = "0x60001F8")]
		[Cpp2IlInjected.Address(RVA = "0x6227550", Offset = "0x6226350", VA = "0x186227550", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000088")]
	public HKDDEEJINEH ADEHKCCOJGF
	{
		[Cpp2IlInjected.Token(Token = "0x6000206")]
		[Cpp2IlInjected.Address(RVA = "0x62253F0", Offset = "0x62241F0", VA = "0x1862253F0", Slot = "8")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000207")]
		[Cpp2IlInjected.Address(RVA = "0x62251F0", Offset = "0x6223FF0", VA = "0x1862251F0", Slot = "9")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000089")]
	public IReadOnlyList<HKDDEEJINEH> ENBMPJKJGMM
	{
		[Cpp2IlInjected.Token(Token = "0x6000208")]
		[Cpp2IlInjected.Address(RVA = "0x6226430", Offset = "0x6225230", VA = "0x186226430", Slot = "10")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700008A")]
	public HKDDEEJINEH DKBLNPELKCO
	{
		[Cpp2IlInjected.Token(Token = "0x6000209")]
		[Cpp2IlInjected.Address(RVA = "0x62294E0", Offset = "0x62282E0", VA = "0x1862294E0", Slot = "11")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700008B")]
	public bool EAILHMIAFFL
	{
		[Cpp2IlInjected.Token(Token = "0x600020A")]
		[Cpp2IlInjected.Address(RVA = "0x6227EA0", Offset = "0x6226CA0", VA = "0x186227EA0", Slot = "137")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700008C")]
	public bool OLIJLEJGNMI
	{
		[Cpp2IlInjected.Token(Token = "0x600020E")]
		[Cpp2IlInjected.Address(RVA = "0x62280E0", Offset = "0x6226EE0", VA = "0x1862280E0", Slot = "12")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700008D")]
	public bool BLFPMICGOPE
	{
		[Cpp2IlInjected.Token(Token = "0x600020F")]
		[Cpp2IlInjected.Address(RVA = "0x62256D0", Offset = "0x62244D0", VA = "0x1862256D0", Slot = "13")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700008E")]
	public LBJHINFHGBL JNGDLEGDDIJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000210")]
		[Cpp2IlInjected.Address(RVA = "0x6228130", Offset = "0x6226F30", VA = "0x186228130", Slot = "14")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000211")]
		[Cpp2IlInjected.Address(RVA = "0x62293D0", Offset = "0x62281D0", VA = "0x1862293D0", Slot = "15")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700008F")]
	public JOFEBGGLMFG NDNIBPFIBJI
	{
		[Cpp2IlInjected.Token(Token = "0x6000212")]
		[Cpp2IlInjected.Address(RVA = "0x62297C0", Offset = "0x62285C0", VA = "0x1862297C0", Slot = "16")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000213")]
		[Cpp2IlInjected.Address(RVA = "0x6225010", Offset = "0x6223E10", VA = "0x186225010", Slot = "17")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000090")]
	public float EIKOHCLDIBJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000214")]
		[Cpp2IlInjected.Address(RVA = "0x6223EB0", Offset = "0x6222CB0", VA = "0x186223EB0", Slot = "18")]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x6000215")]
		[Cpp2IlInjected.Address(RVA = "0x6227B30", Offset = "0x6226930", VA = "0x186227B30", Slot = "19")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000091")]
	public Vector3 KHBEFLDEFGN
	{
		[Cpp2IlInjected.Token(Token = "0x6000216")]
		[Cpp2IlInjected.Address(RVA = "0x6228A70", Offset = "0x6227870", VA = "0x186228A70", Slot = "20")]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x6000217")]
		[Cpp2IlInjected.Address(RVA = "0x6223CA0", Offset = "0x6222AA0", VA = "0x186223CA0", Slot = "21")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000092")]
	public Vector3 JJILBICKFBG
	{
		[Cpp2IlInjected.Token(Token = "0x6000218")]
		[Cpp2IlInjected.Address(RVA = "0x6223D80", Offset = "0x6222B80", VA = "0x186223D80", Slot = "22")]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x6000219")]
		[Cpp2IlInjected.Address(RVA = "0x6229690", Offset = "0x6228490", VA = "0x186229690", Slot = "23")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000093")]
	public Vector3 EGDFHNKFGGC
	{
		[Cpp2IlInjected.Token(Token = "0x600021A")]
		[Cpp2IlInjected.Address(RVA = "0x6226180", Offset = "0x6224F80", VA = "0x186226180", Slot = "24")]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x600021B")]
		[Cpp2IlInjected.Address(RVA = "0x6227960", Offset = "0x6226760", VA = "0x186227960", Slot = "25")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000094")]
	public Vector3 ECOGONCAENI
	{
		[Cpp2IlInjected.Token(Token = "0x600021C")]
		[Cpp2IlInjected.Address(RVA = "0x6226B20", Offset = "0x6225920", VA = "0x186226B20", Slot = "26")]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x600021D")]
		[Cpp2IlInjected.Address(RVA = "0x6225880", Offset = "0x6224680", VA = "0x186225880", Slot = "27")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000095")]
	public bool FIDLEGGHFIK
	{
		[Cpp2IlInjected.Token(Token = "0x600021E")]
		[Cpp2IlInjected.Address(RVA = "0x62275F0", Offset = "0x62263F0", VA = "0x1862275F0", Slot = "138")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000096")]
	public bool NNJBEOGIMBG
	{
		[Cpp2IlInjected.Token(Token = "0x600021F")]
		[Cpp2IlInjected.Address(RVA = "0x62241E0", Offset = "0x6222FE0", VA = "0x1862241E0", Slot = "28")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000097")]
	public bool BPBHDJCNMPF
	{
		[Cpp2IlInjected.Token(Token = "0x6000220")]
		[Cpp2IlInjected.Address(RVA = "0x6226020", Offset = "0x6224E20", VA = "0x186226020", Slot = "29")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000098")]
	public bool OAKBMOAOCEK
	{
		[Cpp2IlInjected.Token(Token = "0x6000221")]
		[Cpp2IlInjected.Address(RVA = "0x6224FC0", Offset = "0x6223DC0", VA = "0x186224FC0", Slot = "30")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000099")]
	public Vector3 JFADEILIBMM
	{
		[Cpp2IlInjected.Token(Token = "0x6000232")]
		[Cpp2IlInjected.Address(RVA = "0x6229040", Offset = "0x6227E40", VA = "0x186229040", Slot = "31")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700009A")]
	public Vector3 OFPFJJDNLBD
	{
		[Cpp2IlInjected.Token(Token = "0x6000233")]
		[Cpp2IlInjected.Address(RVA = "0x6224420", Offset = "0x6223220", VA = "0x186224420", Slot = "32")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700009B")]
	public Vector3 LAGIIOINLDG
	{
		[Cpp2IlInjected.Token(Token = "0x6000238")]
		[Cpp2IlInjected.Address(RVA = "0x62242A0", Offset = "0x62230A0", VA = "0x1862242A0", Slot = "33")]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x6000239")]
		[Cpp2IlInjected.Address(RVA = "0x6224640", Offset = "0x6223440", VA = "0x186224640", Slot = "34")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700009C")]
	public Vector3 IFPDMFNNGAF
	{
		[Cpp2IlInjected.Token(Token = "0x600023A")]
		[Cpp2IlInjected.Address(RVA = "0x6224E10", Offset = "0x6223C10", VA = "0x186224E10", Slot = "35")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700009D")]
	public float EAFPGFDGIND
	{
		[Cpp2IlInjected.Token(Token = "0x600023B")]
		[Cpp2IlInjected.Address(RVA = "0x62266A0", Offset = "0x62254A0", VA = "0x1862266A0", Slot = "36")]
		get
		{
			return default(float);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700009E")]
	public float OJDNJKNJAAN
	{
		[Cpp2IlInjected.Token(Token = "0x600023C")]
		[Cpp2IlInjected.Address(RVA = "0x6227400", Offset = "0x6226200", VA = "0x186227400", Slot = "37")]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x600023D")]
		[Cpp2IlInjected.Address(RVA = "0x6225AD0", Offset = "0x62248D0", VA = "0x186225AD0", Slot = "38")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700009F")]
	public Vector3 FPIAMPLDLPJ
	{
		[Cpp2IlInjected.Token(Token = "0x600023E")]
		[Cpp2IlInjected.Address(RVA = "0x6229830", Offset = "0x6228630", VA = "0x186229830", Slot = "39")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A0")]
	public Quaternion EDBMEAAFNGM
	{
		[Cpp2IlInjected.Token(Token = "0x600023F")]
		[Cpp2IlInjected.Address(RVA = "0x6224720", Offset = "0x6223520", VA = "0x186224720", Slot = "40")]
		get
		{
			return default(Quaternion);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A1")]
	public float OLGPPBCDIPC
	{
		[Cpp2IlInjected.Token(Token = "0x6000244")]
		[Cpp2IlInjected.Address(RVA = "0x6227760", Offset = "0x6226560", VA = "0x186227760", Slot = "42")]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x6000245")]
		[Cpp2IlInjected.Address(RVA = "0x6224240", Offset = "0x6223040", VA = "0x186224240", Slot = "43")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A2")]
	public float MILAOBCOIDB
	{
		[Cpp2IlInjected.Token(Token = "0x6000246")]
		[Cpp2IlInjected.Address(RVA = "0x6226D50", Offset = "0x6225B50", VA = "0x186226D50", Slot = "44")]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x6000247")]
		[Cpp2IlInjected.Address(RVA = "0x6225FC0", Offset = "0x6224DC0", VA = "0x186225FC0", Slot = "45")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A3")]
	public bool KILOFHHLCIA
	{
		[Cpp2IlInjected.Token(Token = "0x6000248")]
		[Cpp2IlInjected.Address(RVA = "0x6223F70", Offset = "0x6222D70", VA = "0x186223F70", Slot = "46")]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000249")]
		[Cpp2IlInjected.Address(RVA = "0x6225720", Offset = "0x6224520", VA = "0x186225720", Slot = "47")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A4")]
	public EPMFMHNHMEG PKEADPGLIAA
	{
		[Cpp2IlInjected.Token(Token = "0x6000251")]
		[Cpp2IlInjected.Address(RVA = "0x6229210", Offset = "0x6228010", VA = "0x186229210", Slot = "48")]
		get
		{
			return default(EPMFMHNHMEG);
		}
		[Cpp2IlInjected.Token(Token = "0x6000252")]
		[Cpp2IlInjected.Address(RVA = "0x62265E0", Offset = "0x62253E0", VA = "0x1862265E0", Slot = "49")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A5")]
	public bool EAAEJMCMHOM
	{
		[Cpp2IlInjected.Token(Token = "0x6000255")]
		[Cpp2IlInjected.Address(RVA = "0x6228FF0", Offset = "0x6227DF0", VA = "0x186228FF0", Slot = "50")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A6")]
	public Transform PHLFANIJOKI
	{
		[Cpp2IlInjected.Token(Token = "0x600025C")]
		[Cpp2IlInjected.Address(RVA = "0x62264E0", Offset = "0x62252E0", VA = "0x1862264E0", Slot = "51")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A7")]
	public Vector3 COKHGDLHIBE
	{
		[Cpp2IlInjected.Token(Token = "0x600025D")]
		[Cpp2IlInjected.Address(RVA = "0x6227450", Offset = "0x6226250", VA = "0x186227450", Slot = "52")]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x600025E")]
		[Cpp2IlInjected.Address(RVA = "0x62292B0", Offset = "0x62280B0", VA = "0x1862292B0", Slot = "53")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A8")]
	public float OFMEOPGKNHB
	{
		[Cpp2IlInjected.Token(Token = "0x600025F")]
		[Cpp2IlInjected.Address(RVA = "0x6229810", Offset = "0x6228610", VA = "0x186229810", Slot = "54")]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x6000260")]
		[Cpp2IlInjected.Address(RVA = "0x6223F00", Offset = "0x6222D00", VA = "0x186223F00", Slot = "55")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A9")]
	public float ODAENDJNKNL
	{
		[Cpp2IlInjected.Token(Token = "0x6000261")]
		[Cpp2IlInjected.Address(RVA = "0x6226EF0", Offset = "0x6225CF0", VA = "0x186226EF0", Slot = "56")]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x6000262")]
		[Cpp2IlInjected.Address(RVA = "0x6228830", Offset = "0x6227630", VA = "0x186228830", Slot = "57")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000AA")]
	public Quaternion DHOHNGCOPAD
	{
		[Cpp2IlInjected.Token(Token = "0x6000263")]
		[Cpp2IlInjected.Address(RVA = "0x6227DA0", Offset = "0x6226BA0", VA = "0x186227DA0", Slot = "58")]
		get
		{
			return default(Quaternion);
		}
		[Cpp2IlInjected.Token(Token = "0x6000264")]
		[Cpp2IlInjected.Address(RVA = "0x6224500", Offset = "0x6223300", VA = "0x186224500", Slot = "59")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000AB")]
	public Vector3 IINMIFPFDIC
	{
		[Cpp2IlInjected.Token(Token = "0x6000265")]
		[Cpp2IlInjected.Address(RVA = "0x6227E50", Offset = "0x6226C50", VA = "0x186227E50", Slot = "60")]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x6000266")]
		[Cpp2IlInjected.Address(RVA = "0x62263E0", Offset = "0x62251E0", VA = "0x1862263E0", Slot = "61")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000AC")]
	public Quaternion KEJKODFGKBE
	{
		[Cpp2IlInjected.Token(Token = "0x6000267")]
		[Cpp2IlInjected.Address(RVA = "0x62251B0", Offset = "0x6223FB0", VA = "0x1862251B0", Slot = "62")]
		get
		{
			return default(Quaternion);
		}
		[Cpp2IlInjected.Token(Token = "0x6000268")]
		[Cpp2IlInjected.Address(RVA = "0x6226A80", Offset = "0x6225880", VA = "0x186226A80", Slot = "63")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000AD")]
	public RigidbodyConstraints BNDMKIOPOHA
	{
		[Cpp2IlInjected.Token(Token = "0x600026C")]
		[Cpp2IlInjected.Address(RVA = "0x6224D00", Offset = "0x6223B00", VA = "0x186224D00", Slot = "64")]
		get
		{
			return default(RigidbodyConstraints);
		}
		[Cpp2IlInjected.Token(Token = "0x600026D")]
		[Cpp2IlInjected.Address(RVA = "0x6226480", Offset = "0x6225280", VA = "0x186226480", Slot = "65")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000AE")]
	public bool KNJAHLAHOMB
	{
		[Cpp2IlInjected.Token(Token = "0x600026E")]
		[Cpp2IlInjected.Address(RVA = "0x6226DA0", Offset = "0x6225BA0", VA = "0x186226DA0", Slot = "66")]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x600026F")]
		[Cpp2IlInjected.Address(RVA = "0x6224180", Offset = "0x6222F80", VA = "0x186224180", Slot = "67")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000AF")]
	public CollisionDetectionMode DGLKEBEJHFH
	{
		[Cpp2IlInjected.Token(Token = "0x6000278")]
		[Cpp2IlInjected.Address(RVA = "0x62275A0", Offset = "0x62263A0", VA = "0x1862275A0", Slot = "68")]
		get
		{
			return default(CollisionDetectionMode);
		}
		[Cpp2IlInjected.Token(Token = "0x6000279")]
		[Cpp2IlInjected.Address(RVA = "0x62281E0", Offset = "0x6226FE0", VA = "0x1862281E0", Slot = "69")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B0")]
	public bool GOFFCLKAJJJ
	{
		[Cpp2IlInjected.Token(Token = "0x600027B")]
		[Cpp2IlInjected.Address(RVA = "0x6228930", Offset = "0x6227730", VA = "0x186228930", Slot = "139")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B1")]
	public bool DFDBDNANPGP
	{
		[Cpp2IlInjected.Token(Token = "0x600027C")]
		[Cpp2IlInjected.Address(RVA = "0x6226260", Offset = "0x6225060", VA = "0x186226260", Slot = "70")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B2")]
	public bool HBANMPFGJGI
	{
		[Cpp2IlInjected.Token(Token = "0x600027D")]
		[Cpp2IlInjected.Address(RVA = "0x6223BA0", Offset = "0x62229A0", VA = "0x186223BA0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B3")]
	public bool EDDGPBPMNBL
	{
		[Cpp2IlInjected.Token(Token = "0x600027E")]
		[Cpp2IlInjected.Address(RVA = "0x6228FC0", Offset = "0x6227DC0", VA = "0x186228FC0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000021")]
	public event HJACFJGDJJO HODIMEMGCKN
	{
		[Cpp2IlInjected.Token(Token = "0x6000200")]
		[Cpp2IlInjected.Address(RVA = "0x6228C30", Offset = "0x6227A30", VA = "0x186228C30", Slot = "75")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000201")]
		[Cpp2IlInjected.Address(RVA = "0x6223C40", Offset = "0x6222A40", VA = "0x186223C40", Slot = "76")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000022")]
	public event HJACFJGDJJO JOCICHKGDGM
	{
		[Cpp2IlInjected.Token(Token = "0x6000202")]
		[Cpp2IlInjected.Address(RVA = "0x6229480", Offset = "0x6228280", VA = "0x186229480", Slot = "77")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000203")]
		[Cpp2IlInjected.Address(RVA = "0x6226640", Offset = "0x6225440", VA = "0x186226640", Slot = "78")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000023")]
	public event IFKDBGJBMPP PJPLFEDKAAM
	{
		[Cpp2IlInjected.Token(Token = "0x6000204")]
		[Cpp2IlInjected.Address(RVA = "0x6228180", Offset = "0x6226F80", VA = "0x186228180", Slot = "79")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000205")]
		[Cpp2IlInjected.Address(RVA = "0x6224D50", Offset = "0x6223B50", VA = "0x186224D50", Slot = "80")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000024")]
	public event HJACFJGDJJO AJIMHCJENHI
	{
		[Cpp2IlInjected.Token(Token = "0x600020C")]
		[Cpp2IlInjected.Address(RVA = "0x6228EB0", Offset = "0x6227CB0", VA = "0x186228EB0", Slot = "82")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600020D")]
		[Cpp2IlInjected.Address(RVA = "0x6224DB0", Offset = "0x6223BB0", VA = "0x186224DB0", Slot = "83")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000025")]
	public event HJACFJGDJJO ODNGMOBPALO
	{
		[Cpp2IlInjected.Token(Token = "0x6000236")]
		[Cpp2IlInjected.Address(RVA = "0x6224120", Offset = "0x6222F20", VA = "0x186224120", Slot = "102")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000237")]
		[Cpp2IlInjected.Address(RVA = "0x6226760", Offset = "0x6225560", VA = "0x186226760", Slot = "103")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000026")]
	public event HJACFJGDJJO FPONCMMAGCA
	{
		[Cpp2IlInjected.Token(Token = "0x600024A")]
		[Cpp2IlInjected.Address(RVA = "0x6229370", Offset = "0x6228170", VA = "0x186229370", Slot = "107")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600024B")]
		[Cpp2IlInjected.Address(RVA = "0x6227640", Offset = "0x6226440", VA = "0x186227640", Slot = "108")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000027")]
	public event Action<KFCLLDKJIGN, KFCLLDKJIGN> NIPMFJHHIKK
	{
		[Cpp2IlInjected.Token(Token = "0x600024F")]
		[Cpp2IlInjected.Address(RVA = "0x6226AC0", Offset = "0x62258C0", VA = "0x186226AC0", Slot = "111")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000250")]
		[Cpp2IlInjected.Address(RVA = "0x6223B40", Offset = "0x6222940", VA = "0x186223B40", Slot = "112")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000028")]
	public event HJACFJGDJJO AIKMIOLKDDL
	{
		[Cpp2IlInjected.Token(Token = "0x6000253")]
		[Cpp2IlInjected.Address(RVA = "0x6227820", Offset = "0x6226620", VA = "0x186227820", Slot = "113")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000254")]
		[Cpp2IlInjected.Address(RVA = "0x6226120", Offset = "0x6224F20", VA = "0x186226120", Slot = "114")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000029")]
	public event HJACFJGDJJO EDNEIGNLNHG
	{
		[Cpp2IlInjected.Token(Token = "0x600025A")]
		[Cpp2IlInjected.Address(RVA = "0x6227CF0", Offset = "0x6226AF0", VA = "0x186227CF0", Slot = "119")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600025B")]
		[Cpp2IlInjected.Address(RVA = "0x6229160", Offset = "0x6227F60", VA = "0x186229160", Slot = "120")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001F9")]
	[Cpp2IlInjected.Address(RVA = "0x6216BC0", Offset = "0x62159C0", VA = "0x186216BC0")]
	public KOAFFLFFEOP(GameObject DEGGPBGPMDB, RigidbodyEx BJEOFBIDHLD, JLBIHFBBGKJ OHOLEEOLBDH, [In] POAMDCEFDPK PFDMLBFKIAP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001FA")]
	[Cpp2IlInjected.Address(RVA = "0x6227110", Offset = "0x6225F10", VA = "0x186227110", Slot = "135")]
	protected virtual void IODPBGHLKMM(JLBIHFBBGKJ OHOLEEOLBDH, POAMDCEFDPK PFDMLBFKIAP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001FB")]
	[Cpp2IlInjected.Address(RVA = "0x6224EF0", Offset = "0x6223CF0", VA = "0x186224EF0", Slot = "136")]
	public virtual void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001FC")]
	[Cpp2IlInjected.Address(RVA = "0x6225250", Offset = "0x6224050", VA = "0x186225250", Slot = "71")]
	public void EKBEIHECLAM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001FD")]
	[Cpp2IlInjected.Address(RVA = "0x62240D0", Offset = "0x6222ED0", VA = "0x1862240D0", Slot = "72")]
	public void DPKGHMKJIKO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001FE")]
	[Cpp2IlInjected.Address(RVA = "0x6226100", Offset = "0x6224F00", VA = "0x186226100", Slot = "73")]
	public void GIMKODEGOKH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001FF")]
	[Cpp2IlInjected.Address(RVA = "0x6223A90", Offset = "0x6222890", VA = "0x186223A90")]
	private void AAFGKGBKHHD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600020B")]
	[Cpp2IlInjected.Address(RVA = "0x62266F0", Offset = "0x62254F0", VA = "0x1862266F0", Slot = "81")]
	public void HDGBCFAMPCN(HKDDEEJINEH GNLEHBFFNFG, bool LHLPPJCBNEM = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000222")]
	[Cpp2IlInjected.Address(RVA = "0x62269B0", Offset = "0x62257B0", VA = "0x1862269B0", Slot = "84")]
	public void HFENMPHFOKA(object PFKLELGAJPH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000223")]
	[Cpp2IlInjected.Address(RVA = "0x62270B0", Offset = "0x6225EB0", VA = "0x1862270B0", Slot = "85")]
	public void INLGLFPHKKN(object PFKLELGAJPH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000224")]
	[Cpp2IlInjected.Address(RVA = "0x6226F10", Offset = "0x6225D10", VA = "0x186226F10", Slot = "86")]
	public Vector3 ILHPDEBIDPO(Vector3 FCKPHPBMNBE)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000225")]
	[Cpp2IlInjected.Address(RVA = "0x6227BF0", Offset = "0x62269F0", VA = "0x186227BF0", Slot = "87")]
	public Vector3 KFOJABECPNA(Vector3 CBFMJBCAHHF)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000226")]
	[Cpp2IlInjected.Address(RVA = "0x62240D0", Offset = "0x6222ED0", VA = "0x1862240D0", Slot = "88")]
	public void ALNKOFBADLM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000227")]
	[Cpp2IlInjected.Address(RVA = "0x6229430", Offset = "0x6228230", VA = "0x186229430", Slot = "89")]
	public void ODLAHMAHHIG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000228")]
	[Cpp2IlInjected.Address(RVA = "0x6229770", Offset = "0x6228570", VA = "0x186229770", Slot = "90")]
	public void OMPFMFEHIPL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000229")]
	[Cpp2IlInjected.Address(RVA = "0x6224B60", Offset = "0x6223960", VA = "0x186224B60", Slot = "91")]
	public void COIPDHOKFEA(Vector3 LCEEOGHIEAE, Vector3 CMCJGKKIFGK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600022A")]
	[Cpp2IlInjected.Address(RVA = "0x6227A40", Offset = "0x6226840", VA = "0x186227A40", Slot = "92")]
	public void KCHGHBEHDOP(Vector3 NNHCKKDHDOO, Vector3 MKPDHJELIJH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600022B")]
	[Cpp2IlInjected.Address(RVA = "0x6225510", Offset = "0x6224310", VA = "0x186225510", Slot = "93")]
	public void FEGGONCBCAB(Vector3 MBCLMEKNIMH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600022C")]
	[Cpp2IlInjected.Address(RVA = "0x62276A0", Offset = "0x62264A0", VA = "0x1862276A0", Slot = "94")]
	public void JJLPMJIAECP(CAJLMHPONNG ODONFGMOICG, Vector3 EBGKJLMCJAI, float EMBPADILADB, float ICDNFDHOPEF = 8f, float PKMFLEJBFBB = 1f)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600022D")]
	[Cpp2IlInjected.Address(RVA = "0x6226DF0", Offset = "0x6225BF0", VA = "0x186226DF0", Slot = "95")]
	public void IGMBNACPLCP(BPMLBDGOAAA KPBLKDJONKA, Vector3 KHAGNCFGGLP, float DGAGPLDFBFA = float.PositiveInfinity)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600022E")]
	[Cpp2IlInjected.Address(RVA = "0x6224C50", Offset = "0x6223A50", VA = "0x186224C50", Slot = "96")]
	[Obsolete("Deprecated. Still exists to support deprecated CV2 chips. Use ApplyAngularVelocityChange.")]
	public void CPOAAEBFFIL(BPMLBDGOAAA KPBLKDJONKA, Vector3 GIBIBDOGOLL, float MLEKCJEEFGK = 7f, float JGPJAKHDFMM = 1f)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600022F")]
	[Cpp2IlInjected.Address(RVA = "0x6227F00", Offset = "0x6226D00", VA = "0x186227F00", Slot = "97")]
	public Vector3 KOMLCDOJFGP(Vector3 GNLEHBFFNFG)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000230")]
	[Cpp2IlInjected.Address(RVA = "0x6226C00", Offset = "0x6225A00", VA = "0x186226C00", Slot = "98")]
	public Vector3 HPPNGLOONCP(Vector3 GNLEHBFFNFG)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000231")]
	[Cpp2IlInjected.Address(RVA = "0x62245F0", Offset = "0x62233F0", VA = "0x1862245F0", Slot = "99")]
	public void BMNABPGBMMB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000234")]
	[Cpp2IlInjected.Address(RVA = "0x6226A10", Offset = "0x6225810", VA = "0x186226A10", Slot = "100")]
	public void HHEHDIAENMJ(HKDDEEJINEH CIBBEIAHJJB, object PFKLELGAJPH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000235")]
	[Cpp2IlInjected.Address(RVA = "0x6228F10", Offset = "0x6227D10", VA = "0x186228F10", Slot = "101")]
	public void NDAFIEKOHMG(object PFKLELGAJPH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000240")]
	[Cpp2IlInjected.Address(RVA = "0x6225070", Offset = "0x6223E70", VA = "0x186225070", Slot = "41")]
	public void EGGEMACIFEN((Quaternion rot, Vector3 moments) IGICCOJIDDA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000241")]
	[Cpp2IlInjected.Address(RVA = "0x6226D00", Offset = "0x6225B00", VA = "0x186226D00", Slot = "104")]
	public void IBKBPPNCAPO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000242")]
	[Cpp2IlInjected.Address(RVA = "0x6228F70", Offset = "0x6227D70", VA = "0x186228F70", Slot = "105")]
	public void NDMOMLBEAEJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000243")]
	[Cpp2IlInjected.Address(RVA = "0x6223E60", Offset = "0x6222C60", VA = "0x186223E60", Slot = "106")]
	public void AHJPIEKBAGK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600024C")]
	[Cpp2IlInjected.Address(RVA = "0x6228420", Offset = "0x6227220", VA = "0x186228420", Slot = "109")]
	public bool LOELNNODNDF()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600024D")]
	[Cpp2IlInjected.Address(RVA = "0x6227500", Offset = "0x6226300", VA = "0x186227500", Slot = "74")]
	public void JBPIAAMLKCO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600024E")]
	[Cpp2IlInjected.Address(RVA = "0x6229260", Offset = "0x6228060", VA = "0x186229260", Slot = "110")]
	public void NMDENCFDKJJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000256")]
	[Cpp2IlInjected.Address(RVA = "0x6229110", Offset = "0x6227F10", VA = "0x186229110", Slot = "115")]
	public IDisposable NJGCPDMJAEB()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000257")]
	[Cpp2IlInjected.Address(RVA = "0x6225F60", Offset = "0x6224D60", VA = "0x186225F60", Slot = "116")]
	public void GHPBAHFCNAI(object PFKLELGAJPH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000258")]
	[Cpp2IlInjected.Address(RVA = "0x6227B90", Offset = "0x6226990", VA = "0x186227B90", Slot = "117")]
	public void KEANJAENHKI(object PFKLELGAJPH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000259")]
	[Cpp2IlInjected.Address(RVA = "0x62277B0", Offset = "0x62265B0", VA = "0x1862277B0", Slot = "118")]
	public void JKGNPHGDHEP(object PFKLELGAJPH, bool JJIMCKPIKFL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000269")]
	[Cpp2IlInjected.Address(RVA = "0x6228470", Offset = "0x6227270", VA = "0x186228470", Slot = "121")]
	public void LOJHDBLLLPK(Vector3 KMDPKMLFOLC, Quaternion KGOHNEKGJFD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600026A")]
	[Cpp2IlInjected.Address(RVA = "0x6228C90", Offset = "0x6227A90", VA = "0x186228C90", Slot = "122")]
	public void MMCFACKGGID(Vector3 IAOBMGELIKG, Quaternion BIOBPMHCIFO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600026B")]
	[Cpp2IlInjected.Address(RVA = "0x6226580", Offset = "0x6225380", VA = "0x186226580", Slot = "123")]
	public bool HBFAJFCHBIE(float OFPMODDPBDG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000270")]
	[Cpp2IlInjected.Address(RVA = "0x6225150", Offset = "0x6223F50", VA = "0x186225150", Slot = "124")]
	public void EHBMDIMOOPP(object PFKLELGAJPH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000271")]
	[Cpp2IlInjected.Address(RVA = "0x6225390", Offset = "0x6224190", VA = "0x186225390", Slot = "125")]
	public void EOMADFNHNCE(object PFKLELGAJPH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000272")]
	[Cpp2IlInjected.Address(RVA = "0x6229630", Offset = "0x6228430", VA = "0x186229630", Slot = "126")]
	public void OJJAOMJIFMM(object PFKLELGAJPH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000273")]
	[Cpp2IlInjected.Address(RVA = "0x6226E90", Offset = "0x6225C90", VA = "0x186226E90", Slot = "127")]
	public void IIIGLEPLPKA(object PFKLELGAJPH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000274")]
	[Cpp2IlInjected.Address(RVA = "0x6227880", Offset = "0x6226680", VA = "0x186227880", Slot = "128")]
	public void JLFMLIEHAJM(Vector3 PJCPHDDKADF, ForceMode BKPMKNNGNCO = ForceMode.Force)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000275")]
	[Cpp2IlInjected.Address(RVA = "0x6225E50", Offset = "0x6224C50", VA = "0x186225E50", Slot = "129")]
	public void GELIKGECCKO(Vector3 PJCPHDDKADF, Vector3 AILFIIEAPKM, ForceMode BKPMKNNGNCO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000276")]
	[Cpp2IlInjected.Address(RVA = "0x6228000", Offset = "0x6226E00", VA = "0x186228000", Slot = "130")]
	public void LCIDAFFKJGM(Vector3 KNJIDLKEAOF, ForceMode BKPMKNNGNCO = ForceMode.Force)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000277")]
	[Cpp2IlInjected.Address(RVA = "0x62255F0", Offset = "0x62243F0", VA = "0x1862255F0", Slot = "131")]
	public void FFJJOMMAHGJ(Vector3 KNJIDLKEAOF, ForceMode BKPMKNNGNCO = ForceMode.Force)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600027A")]
	[Cpp2IlInjected.Address(RVA = "0x6227010", Offset = "0x6225E10", VA = "0x186227010", Slot = "132")]
	public bool IMCFKJILCKH(Vector3 IELHLOGPMDL, [Out] RaycastHit PEGDGELCHOI, float NGLNDDJFMFL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600027F")]
	[Cpp2IlInjected.Address(RVA = "0x6225830", Offset = "0x6224630", VA = "0x186225830", Slot = "133")]
	public void GCBLHPDNFDB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000280")]
	[Cpp2IlInjected.Address(RVA = "0x6229910", Offset = "0x6228710", VA = "0x186229910", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000281")]
	[Cpp2IlInjected.Address(RVA = "0x6228B50", Offset = "0x6227950", VA = "0x186228B50")]
	private void MHGMBPKJKEP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000282")]
	[Cpp2IlInjected.Address(RVA = "0x6223FC0", Offset = "0x6222DC0", VA = "0x186223FC0")]
	private void ALLGNONDDBK(HKDDEEJINEH LBLLNFOEKNE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000283")]
	[Cpp2IlInjected.Address(RVA = "0x62267C0", Offset = "0x62255C0", VA = "0x1862267C0")]
	private void HFEBKFDMHOK(HKDDEEJINEH LBLLNFOEKNE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000284")]
	[Cpp2IlInjected.Address(RVA = "0x6225780", Offset = "0x6224580", VA = "0x186225780")]
	private void FOCKIJMNJML()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000285")]
	[Cpp2IlInjected.Address(RVA = "0x6229530", Offset = "0x6228330", VA = "0x186229530")]
	private void OJBLLHEMLBN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000286")]
	[Cpp2IlInjected.Address(RVA = "0x6228240", Offset = "0x6227040", VA = "0x186228240")]
	private void LKILKFBLPFF(HKDDEEJINEH PBBFFPONPEK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000287")]
	[Cpp2IlInjected.Address(RVA = "0x6225440", Offset = "0x6224240", VA = "0x186225440")]
	private void EPMJNGFKGOJ(HKDDEEJINEH LBLLNFOEKNE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000288")]
	[Cpp2IlInjected.Address(RVA = "0x6228DE0", Offset = "0x6227BE0", VA = "0x186228DE0")]
	private void MMKKGNPOEMK(HKDDEEJINEH LBLLNFOEKNE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000289")]
	[Cpp2IlInjected.Address(RVA = "0x6225960", Offset = "0x6224760", VA = "0x186225960")]
	private void GCPFBNKDLAF(RigidbodyEx LBLLNFOEKNE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600028A")]
	[Cpp2IlInjected.Address(RVA = "0x6228670", Offset = "0x6227470", VA = "0x186228670", Slot = "140")]
	protected virtual void LPANDFCAIJN(RigidbodyEx HHJJKPNJLAD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600028B")]
	[Cpp2IlInjected.Address(RVA = "0x6225B30", Offset = "0x6224930", VA = "0x186225B30")]
	protected void GDEFAABGLNE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600028C")]
	[Cpp2IlInjected.Address(RVA = "0x62247F0", Offset = "0x62235F0", VA = "0x1862247F0")]
	protected void CNHNOHOFFBJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600028D")]
	[Cpp2IlInjected.Address(RVA = "0x6224380", Offset = "0x6223180", VA = "0x186224380", Slot = "141")]
	protected virtual IDisposable BDFINDDDMKC()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000028")]
internal static class LKBHMILNJII
{
	[Cpp2IlInjected.Token(Token = "0x600028E")]
	[Cpp2IlInjected.Address(RVA = "0x6229A20", Offset = "0x6228820", VA = "0x186229A20")]
	public static HKDDEEJINEH COKNGKCCNKA(this HKDDEEJINEH HHJJKPNJLAD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600028F")]
	[Cpp2IlInjected.Address(RVA = "0x6229B50", Offset = "0x6228950", VA = "0x186229B50")]
	public static bool NIFJGAEMFLH(this HKDDEEJINEH HHJJKPNJLAD, HKDDEEJINEH HEFCCNCIEFJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000290")]
	[Cpp2IlInjected.Address(RVA = "0x6229AD0", Offset = "0x62288D0", VA = "0x186229AD0")]
	public static bool HDCBEKBCJBO(this HKDDEEJINEH HHJJKPNJLAD, HKDDEEJINEH BJNGNGIHFHL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000291")]
	[Cpp2IlInjected.Address(RVA = "0x6229950", Offset = "0x6228750", VA = "0x186229950")]
	public static RigidbodyEx CCGDNDPOLDJ(this HKDDEEJINEH MHHFPBGCKAL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000292")]
	[Cpp2IlInjected.Address(RVA = "0x62299A0", Offset = "0x62287A0", VA = "0x1862299A0")]
	public static KOAFFLFFEOP CNKPCODEMAB(this HKDDEEJINEH BAHHCFCHDLD)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000029")]
internal class IABJHHDIPOC : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000040")]
	private readonly KOAFFLFFEOP HHJJKPNJLAD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000041")]
	private bool GIDFIEECIAK;

	[Cpp2IlInjected.Token(Token = "0x6000293")]
	[Cpp2IlInjected.Address(RVA = "0x62180D0", Offset = "0x6216ED0", VA = "0x1862180D0")]
	public IABJHHDIPOC(KOAFFLFFEOP HFPPDNNHFOK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000294")]
	[Cpp2IlInjected.Address(RVA = "0x6218070", Offset = "0x6216E70", VA = "0x186218070", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002A")]
internal sealed class AMBCDMLIEGC : HGDEGDIAANM, DOLMCKAIMMH
{
	[Cpp2IlInjected.Token(Token = "0x170000B4")]
	private CollisionDetectionMode ODKPADJCAEN
	{
		[Cpp2IlInjected.Token(Token = "0x6000296")]
		[Cpp2IlInjected.Address(RVA = "0x6209E30", Offset = "0x6208C30", VA = "0x186209E30")]
		get
		{
			return default(CollisionDetectionMode);
		}
		[Cpp2IlInjected.Token(Token = "0x6000297")]
		[Cpp2IlInjected.Address(RVA = "0x6209A30", Offset = "0x6208830", VA = "0x186209A30")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B5")]
	private Rigidbody PEOFAJLGEEJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000298")]
		[Cpp2IlInjected.Address(RVA = "0x6209C00", Offset = "0x6208A00", VA = "0x186209C00")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B6")]
	public CollisionDetectionMode DGLKEBEJHFH
	{
		[Cpp2IlInjected.Token(Token = "0x600029B")]
		[Cpp2IlInjected.Address(RVA = "0x6209C50", Offset = "0x6208A50", VA = "0x186209C50", Slot = "4")]
		get
		{
			return default(CollisionDetectionMode);
		}
		[Cpp2IlInjected.Token(Token = "0x600029C")]
		[Cpp2IlInjected.Address(RVA = "0x6209D70", Offset = "0x6208B70", VA = "0x186209D70", Slot = "5")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000295")]
	[Cpp2IlInjected.Address(RVA = "0x6209E90", Offset = "0x6208C90", VA = "0x186209E90")]
	public AMBCDMLIEGC(HKDDEEJINEH HHJJKPNJLAD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000299")]
	[Cpp2IlInjected.Address(RVA = "0x62098D0", Offset = "0x62086D0", VA = "0x1862098D0", Slot = "6")]
	public void EKBEIHECLAM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600029A")]
	[Cpp2IlInjected.Address(RVA = "0x6209680", Offset = "0x6208480", VA = "0x186209680", Slot = "9")]
	public void AKOMFNGCOKL(Rigidbody OPIJOIJPNML)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600029D")]
	[Cpp2IlInjected.Address(RVA = "0x6209D60", Offset = "0x6208B60", VA = "0x186209D60", Slot = "7")]
	public void KFHFNMGPAPA(bool KPFPDIPJHJC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600029E")]
	[Cpp2IlInjected.Address(RVA = "0x6209A20", Offset = "0x6208820", VA = "0x186209A20", Slot = "8")]
	public void IAGFKMCIEPM(bool KPFPDIPJHJC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600029F")]
	[Cpp2IlInjected.Address(RVA = "0x6209AA0", Offset = "0x62088A0", VA = "0x186209AA0", Slot = "10")]
	public bool IMCFKJILCKH(Vector3 IELHLOGPMDL, [Out] RaycastHit PEGDGELCHOI, float NGLNDDJFMFL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002A0")]
	[Cpp2IlInjected.Address(RVA = "0x6209760", Offset = "0x6208560", VA = "0x186209760")]
	private void DPMNFNOOLOO(bool KPFPDIPJHJC)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002B")]
internal sealed class BGFPJJPNDLI : HGDEGDIAANM, IBDFGCOAOJH, IDisposable, ENGGMMDIFLJ
{
	[Cpp2IlInjected.Token(Token = "0x170000B7")]
	public EPMFMHNHMEG HJNPDBIHMKK
	{
		[Cpp2IlInjected.Token(Token = "0x60002A4")]
		[Cpp2IlInjected.Address(RVA = "0x620A9A0", Offset = "0x62097A0", VA = "0x18620A9A0")]
		get
		{
			return default(EPMFMHNHMEG);
		}
		[Cpp2IlInjected.Token(Token = "0x60002A5")]
		[Cpp2IlInjected.Address(RVA = "0x620A800", Offset = "0x6209600", VA = "0x18620A800")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B8")]
	public EPMFMHNHMEG PKEADPGLIAA
	{
		[Cpp2IlInjected.Token(Token = "0x60002A6")]
		[Cpp2IlInjected.Address(RVA = "0x620AA80", Offset = "0x6209880", VA = "0x18620AA80", Slot = "6")]
		get
		{
			return default(EPMFMHNHMEG);
		}
		[Cpp2IlInjected.Token(Token = "0x60002A7")]
		[Cpp2IlInjected.Address(RVA = "0x620A800", Offset = "0x6209600", VA = "0x18620A800", Slot = "7")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B9")]
	private Transform KELPLPKKPLG
	{
		[Cpp2IlInjected.Token(Token = "0x60002AC")]
		[Cpp2IlInjected.Address(RVA = "0x762EF0", Offset = "0x761CF0", VA = "0x180762EF0", Slot = "10")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400002A")]
	public event Action<KFCLLDKJIGN, KFCLLDKJIGN> NIPMFJHHIKK
	{
		[Cpp2IlInjected.Token(Token = "0x60002A2")]
		[Cpp2IlInjected.Address(RVA = "0x620A8F0", Offset = "0x62096F0", VA = "0x18620A8F0", Slot = "4")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60002A3")]
		[Cpp2IlInjected.Address(RVA = "0x620A750", Offset = "0x6209550", VA = "0x18620A750", Slot = "5")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60002A1")]
	[Cpp2IlInjected.Address(RVA = "0x6209E90", Offset = "0x6208C90", VA = "0x186209E90")]
	public BGFPJJPNDLI(HKDDEEJINEH HHJJKPNJLAD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002A8")]
	[Cpp2IlInjected.Address(RVA = "0x620AC80", Offset = "0x6209A80", VA = "0x18620AC80", Slot = "11")]
	public void OnChangedDistanceBand(KFCLLDKJIGN BOAPNJKEFEG, KFCLLDKJIGN INJCFLAHPML)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002A9")]
	[Cpp2IlInjected.Address(RVA = "0x762EE0", Offset = "0x761CE0", VA = "0x180762EE0", Slot = "12")]
	public void OnChangedVisibility(bool FMEPODNLOHF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002AA")]
	[Cpp2IlInjected.Address(RVA = "0x762EE0", Offset = "0x761CE0", VA = "0x180762EE0", Slot = "8")]
	public void EKBEIHECLAM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002AB")]
	[Cpp2IlInjected.Address(RVA = "0x762EE0", Offset = "0x761CE0", VA = "0x180762EE0", Slot = "9")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002C")]
internal sealed class HDNDLMDEKIM : HGDEGDIAANM, AEDPOFGENJL
{
	[Cpp2IlInjected.Token(Token = "0x170000BA")]
	private Rigidbody PEOFAJLGEEJ
	{
		[Cpp2IlInjected.Token(Token = "0x60002AE")]
		[Cpp2IlInjected.Address(RVA = "0x6209C00", Offset = "0x6208A00", VA = "0x186209C00")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000BB")]
	private bool EAAEJMCMHOM
	{
		[Cpp2IlInjected.Token(Token = "0x60002AF")]
		[Cpp2IlInjected.Address(RVA = "0x620EA80", Offset = "0x620D880", VA = "0x18620EA80")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000BC")]
	private bool EAILHMIAFFL
	{
		[Cpp2IlInjected.Token(Token = "0x60002B0")]
		[Cpp2IlInjected.Address(RVA = "0x620E660", Offset = "0x620D460", VA = "0x18620E660")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000BD")]
	private HKDDEEJINEH ADEHKCCOJGF
	{
		[Cpp2IlInjected.Token(Token = "0x60002B1")]
		[Cpp2IlInjected.Address(RVA = "0x6216C90", Offset = "0x6215A90", VA = "0x186216C90")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60002AD")]
	[Cpp2IlInjected.Address(RVA = "0x6209E90", Offset = "0x6208C90", VA = "0x186209E90")]
	public HDNDLMDEKIM(HKDDEEJINEH HHJJKPNJLAD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002B2")]
	[Cpp2IlInjected.Address(RVA = "0x6217430", Offset = "0x6216230", VA = "0x186217430", Slot = "4")]
	public void JLFMLIEHAJM(Vector3 PJCPHDDKADF, ForceMode BKPMKNNGNCO = ForceMode.Force)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002B3")]
	[Cpp2IlInjected.Address(RVA = "0x62176F0", Offset = "0x62164F0", VA = "0x1862176F0")]
	private void MHJAJMIHPMG(Vector3 PJCPHDDKADF, ForceMode BKPMKNNGNCO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002B4")]
	[Cpp2IlInjected.Address(RVA = "0x62171B0", Offset = "0x6215FB0", VA = "0x1862171B0", Slot = "5")]
	public void GELIKGECCKO(Vector3 PJCPHDDKADF, Vector3 AILFIIEAPKM, ForceMode BKPMKNNGNCO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002B5")]
	[Cpp2IlInjected.Address(RVA = "0x6217590", Offset = "0x6216390", VA = "0x186217590", Slot = "6")]
	public void LCIDAFFKJGM(Vector3 KNJIDLKEAOF, ForceMode BKPMKNNGNCO = ForceMode.Force)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002B6")]
	[Cpp2IlInjected.Address(RVA = "0x6216F50", Offset = "0x6215D50", VA = "0x186216F50")]
	private void FHLENHJFOMG(Vector3 KNJIDLKEAOF, ForceMode BKPMKNNGNCO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002B7")]
	[Cpp2IlInjected.Address(RVA = "0x6216CF0", Offset = "0x6215AF0", VA = "0x186216CF0", Slot = "7")]
	public void FFJJOMMAHGJ(Vector3 KNJIDLKEAOF, ForceMode BKPMKNNGNCO = ForceMode.Force)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002B8")]
	[Cpp2IlInjected.Address(RVA = "0x62179D0", Offset = "0x62167D0", VA = "0x1862179D0")]
	private void NGLKBDEIIAD(string JIGBFCEILIK, UnityEngine.Object GMNCNEPJHHN)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002D")]
internal sealed class DCGBGLLAHJC : HGDEGDIAANM, AEAEHLIIIHM
{
	[Cpp2IlInjected.Token(Token = "0x170000BE")]
	public bool KILOFHHLCIA
	{
		[Cpp2IlInjected.Token(Token = "0x60002BA")]
		[Cpp2IlInjected.Address(RVA = "0x620DB20", Offset = "0x620C920", VA = "0x18620DB20", Slot = "4")]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x60002BB")]
		[Cpp2IlInjected.Address(RVA = "0x620DC10", Offset = "0x620CA10", VA = "0x18620DC10", Slot = "5")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60002B9")]
	[Cpp2IlInjected.Address(RVA = "0x6209E90", Offset = "0x6208C90", VA = "0x186209E90")]
	public DCGBGLLAHJC(HKDDEEJINEH HHJJKPNJLAD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002BC")]
	[Cpp2IlInjected.Address(RVA = "0x620DB80", Offset = "0x620C980", VA = "0x18620DB80", Slot = "6")]
	public void AKOMFNGCOKL(Rigidbody OPIJOIJPNML)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002BD")]
	[Cpp2IlInjected.Address(RVA = "0x620D770", Offset = "0x620C570", VA = "0x18620D770", Slot = "7")]
	public void IPMEDHDLDMK(Rigidbody OPIJOIJPNML)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002E")]
internal sealed class GLDHJOHDNOG : HGDEGDIAANM, CNJKFLKEHNP, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x4000043")]
	private static readonly GKFGDEJLFAD LMMECCJMBJB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x400004D")]
	private readonly CGENLOKBCOL MIOHJJMADEN;

	[Cpp2IlInjected.Token(Token = "0x170000BF")]
	private Transform HFGEDEDEGAG
	{
		[Cpp2IlInjected.Token(Token = "0x60002D1")]
		[Cpp2IlInjected.Address(RVA = "0x6214530", Offset = "0x6213330", VA = "0x186214530")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000C0")]
	public JBMJEBCFLLB LJJEINDDDMF
	{
		[Cpp2IlInjected.Token(Token = "0x60002D3")]
		[Cpp2IlInjected.Address(RVA = "0x6214970", Offset = "0x6213770", VA = "0x186214970")]
		get
		{
			return default(JBMJEBCFLLB);
		}
		[Cpp2IlInjected.Token(Token = "0x60002D4")]
		[Cpp2IlInjected.Address(RVA = "0x6215340", Offset = "0x6214140", VA = "0x186215340")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000C1")]
	public HKDDEEJINEH ADEHKCCOJGF
	{
		[Cpp2IlInjected.Token(Token = "0x60002D5")]
		[Cpp2IlInjected.Address(RVA = "0x6213E90", Offset = "0x6212C90", VA = "0x186213E90", Slot = "24")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60002D6")]
		[Cpp2IlInjected.Address(RVA = "0x6213B20", Offset = "0x6212920", VA = "0x186213B20", Slot = "25")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000C2")]
	public JBMJEBCFLLB ILLPCCMEMGC
	{
		[Cpp2IlInjected.Token(Token = "0x60002D7")]
		[Cpp2IlInjected.Address(RVA = "0x6214050", Offset = "0x6212E50", VA = "0x186214050")]
		get
		{
			return default(JBMJEBCFLLB);
		}
		[Cpp2IlInjected.Token(Token = "0x60002D8")]
		[Cpp2IlInjected.Address(RVA = "0x6214900", Offset = "0x6213700", VA = "0x186214900")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000C3")]
	public HKDDEEJINEH DKBLNPELKCO
	{
		[Cpp2IlInjected.Token(Token = "0x60002D9")]
		[Cpp2IlInjected.Address(RVA = "0x6215040", Offset = "0x6213E40", VA = "0x186215040", Slot = "23")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000C4")]
	public IReadOnlyList<HKDDEEJINEH> ENBMPJKJGMM
	{
		[Cpp2IlInjected.Token(Token = "0x60002DA")]
		[Cpp2IlInjected.Address(RVA = "0x764C00", Offset = "0x763A00", VA = "0x180764C00", Slot = "22")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400002B")]
	public event HJACFJGDJJO HODIMEMGCKN
	{
		[Cpp2IlInjected.Token(Token = "0x60002BF")]
		[Cpp2IlInjected.Address(RVA = "0x6214C70", Offset = "0x6213A70", VA = "0x186214C70", Slot = "4")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60002C0")]
		[Cpp2IlInjected.Address(RVA = "0x6213560", Offset = "0x6212360", VA = "0x186213560", Slot = "5")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400002C")]
	public event HJACFJGDJJO JOCICHKGDGM
	{
		[Cpp2IlInjected.Token(Token = "0x60002C1")]
		[Cpp2IlInjected.Address(RVA = "0x6214F00", Offset = "0x6213D00", VA = "0x186214F00", Slot = "6")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60002C2")]
		[Cpp2IlInjected.Address(RVA = "0x6214560", Offset = "0x6213360", VA = "0x186214560", Slot = "7")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400002D")]
	public event IFKDBGJBMPP PJPLFEDKAAM
	{
		[Cpp2IlInjected.Token(Token = "0x60002C3")]
		[Cpp2IlInjected.Address(RVA = "0x6214BD0", Offset = "0x62139D0", VA = "0x186214BD0", Slot = "8")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60002C4")]
		[Cpp2IlInjected.Address(RVA = "0x6213950", Offset = "0x6212750", VA = "0x186213950", Slot = "9")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400002E")]
	public event Action IHCICACDFEE
	{
		[Cpp2IlInjected.Token(Token = "0x60002C5")]
		[Cpp2IlInjected.Address(RVA = "0x6214E60", Offset = "0x6213C60", VA = "0x186214E60", Slot = "10")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60002C6")]
		[Cpp2IlInjected.Address(RVA = "0x62136B0", Offset = "0x62124B0", VA = "0x1862136B0", Slot = "11")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400002F")]
	public event Action EDCBGJDLIAL
	{
		[Cpp2IlInjected.Token(Token = "0x60002C7")]
		[Cpp2IlInjected.Address(RVA = "0x6213FB0", Offset = "0x6212DB0", VA = "0x186213FB0", Slot = "12")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60002C8")]
		[Cpp2IlInjected.Address(RVA = "0x6214B30", Offset = "0x6213930", VA = "0x186214B30", Slot = "13")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000030")]
	public event Action<HKDDEEJINEH> DHPICOFBLBM
	{
		[Cpp2IlInjected.Token(Token = "0x60002C9")]
		[Cpp2IlInjected.Address(RVA = "0x6213600", Offset = "0x6212400", VA = "0x186213600", Slot = "14")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60002CA")]
		[Cpp2IlInjected.Address(RVA = "0x62150B0", Offset = "0x6213EB0", VA = "0x1862150B0", Slot = "15")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000031")]
	public event Action<HKDDEEJINEH> LEDBDFPEEIB
	{
		[Cpp2IlInjected.Token(Token = "0x60002CB")]
		[Cpp2IlInjected.Address(RVA = "0x62149D0", Offset = "0x62137D0", VA = "0x1862149D0", Slot = "16")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60002CC")]
		[Cpp2IlInjected.Address(RVA = "0x6213F00", Offset = "0x6212D00", VA = "0x186213F00", Slot = "17")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000032")]
	public event Action OLLBCABGMEI
	{
		[Cpp2IlInjected.Token(Token = "0x60002CD")]
		[Cpp2IlInjected.Address(RVA = "0x6214D10", Offset = "0x6213B10", VA = "0x186214D10", Slot = "18")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60002CE")]
		[Cpp2IlInjected.Address(RVA = "0x6214860", Offset = "0x6213660", VA = "0x186214860", Slot = "19")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000033")]
	public event Action<HKDDEEJINEH> HJLHOPFFEKK
	{
		[Cpp2IlInjected.Token(Token = "0x60002CF")]
		[Cpp2IlInjected.Address(RVA = "0x6214DB0", Offset = "0x6213BB0", VA = "0x186214DB0", Slot = "20")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60002D0")]
		[Cpp2IlInjected.Address(RVA = "0x6214A80", Offset = "0x6213880", VA = "0x186214A80", Slot = "21")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60002BE")]
	[Cpp2IlInjected.Address(RVA = "0x6215440", Offset = "0x6214240", VA = "0x186215440")]
	public GLDHJOHDNOG(HKDDEEJINEH HHJJKPNJLAD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002D2")]
	[Cpp2IlInjected.Address(RVA = "0x62139F0", Offset = "0x62127F0", VA = "0x1862139F0", Slot = "27")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002DB")]
	[Cpp2IlInjected.Address(RVA = "0x6214600", Offset = "0x6213400", VA = "0x186214600", Slot = "26")]
	public void HDGBCFAMPCN(HKDDEEJINEH KBFMMMPNLKE, bool LHLPPJCBNEM = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002DC")]
	[Cpp2IlInjected.Address(RVA = "0x6214680", Offset = "0x6213480", VA = "0x186214680")]
	private void HDGBCFAMPCN(HDEONHFPAIJ KBFMMMPNLKE, bool LHLPPJCBNEM = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002DD")]
	[Cpp2IlInjected.Address(RVA = "0x62140B0", Offset = "0x6212EB0", VA = "0x1862140B0")]
	private void HAEICGIODFC(HDEONHFPAIJ KBFMMMPNLKE, bool LHLPPJCBNEM = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002DE")]
	[Cpp2IlInjected.Address(RVA = "0x6213B90", Offset = "0x6212990", VA = "0x186213B90")]
	private void EOENPANBABB(HDEONHFPAIJ PBBFFPONPEK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002DF")]
	[Cpp2IlInjected.Address(RVA = "0x6213750", Offset = "0x6212550", VA = "0x186213750")]
	private void CADNBFAFJKH(HDEONHFPAIJ PBBFFPONPEK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002E0")]
	[Cpp2IlInjected.Address(RVA = "0x6215160", Offset = "0x6213F60", VA = "0x186215160")]
	private void PDEBMBIENDP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002E1")]
	[Cpp2IlInjected.Address(RVA = "0x6213DE0", Offset = "0x6212BE0", VA = "0x186213DE0")]
	private void EPBCEIHCGLA(HDEONHFPAIJ PBBFFPONPEK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002E2")]
	[Cpp2IlInjected.Address(RVA = "0x6214770", Offset = "0x6213570", VA = "0x186214770")]
	private void HIPGIHJLHLJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002E3")]
	[Cpp2IlInjected.Address(RVA = "0x62146D0", Offset = "0x62134D0", VA = "0x1862146D0")]
	private void HHIIPGJELHJ(HDEONHFPAIJ HHJJKPNJLAD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002E4")]
	[Cpp2IlInjected.Address(RVA = "0x6214FA0", Offset = "0x6213DA0", VA = "0x186214FA0")]
	private void OHPPCLKLOPE(HDEONHFPAIJ HHJJKPNJLAD)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002F")]
internal static class BLIPHHJGCMM
{
	[Cpp2IlInjected.Token(Token = "0x60002E6")]
	[Cpp2IlInjected.Address(RVA = "0x620ACA0", Offset = "0x6209AA0", VA = "0x18620ACA0")]
	public static GLDHJOHDNOG CBJKAFKIJMH(this HKDDEEJINEH BAHHCFCHDLD)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000030")]
internal sealed class JGGDBOHLBDH : HGDEGDIAANM, JMDJHBDFHNM
{
	[Cpp2IlInjected.Token(Token = "0x170000C5")]
	public Vector3 JFADEILIBMM
	{
		[Cpp2IlInjected.Token(Token = "0x60002E8")]
		[Cpp2IlInjected.Address(RVA = "0x621D3F0", Offset = "0x621C1F0", VA = "0x18621D3F0", Slot = "4")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000C6")]
	public Vector3 OFPFJJDNLBD
	{
		[Cpp2IlInjected.Token(Token = "0x60002E9")]
		[Cpp2IlInjected.Address(RVA = "0x621CF00", Offset = "0x621BD00", VA = "0x18621CF00", Slot = "5")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000C7")]
	private Vector3 EGDFHNKFGGC
	{
		[Cpp2IlInjected.Token(Token = "0x60002ED")]
		[Cpp2IlInjected.Address(RVA = "0x621D130", Offset = "0x621BF30", VA = "0x18621D130")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000C8")]
	private HKDDEEJINEH ODIPLLPNBEL
	{
		[Cpp2IlInjected.Token(Token = "0x60002EE")]
		[Cpp2IlInjected.Address(RVA = "0x621D220", Offset = "0x621C020", VA = "0x18621D220")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60002E7")]
	[Cpp2IlInjected.Address(RVA = "0x6209E90", Offset = "0x6208C90", VA = "0x186209E90")]
	public JGGDBOHLBDH(HKDDEEJINEH HHJJKPNJLAD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002EA")]
	[Cpp2IlInjected.Address(RVA = "0x621CCA0", Offset = "0x621BAA0", VA = "0x18621CCA0", Slot = "6")]
	public void AOOHAJPAHFH(HKDDEEJINEH LBLLNFOEKNE, object PFKLELGAJPH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002EB")]
	[Cpp2IlInjected.Address(RVA = "0x621CDF0", Offset = "0x621BBF0", VA = "0x18621CDF0")]
	private void AOOHAJPAHFH(HDEONHFPAIJ LBLLNFOEKNE, object PFKLELGAJPH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002EC")]
	[Cpp2IlInjected.Address(RVA = "0x621D380", Offset = "0x621C180", VA = "0x18621D380", Slot = "7")]
	public void MFOJFIKNOFA(object PFKLELGAJPH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002EF")]
	[Cpp2IlInjected.Address(RVA = "0x621D420", Offset = "0x621C220", VA = "0x18621D420")]
	private Vector3 PLHIGNPEECD()
	{
		return default(Vector3);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000031")]
internal static class OJGDEPHEDOK
{
	[Cpp2IlInjected.Token(Token = "0x60002F0")]
	[Cpp2IlInjected.Address(RVA = "0x622DCF0", Offset = "0x622CAF0", VA = "0x18622DCF0")]
	public static JGGDBOHLBDH HIKIIOLJMIG(this HKDDEEJINEH BAHHCFCHDLD)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000032")]
internal sealed class IKBCKBHOPLI : HGDEGDIAANM, FHMHFKBPFEJ
{
	[Cpp2IlInjected.Token(Token = "0x170000C9")]
	[Obsolete("Use LocalCenterOfMassOfSelf or LocalCenterOfMassOfHierarchy, as LocalCenterOfMass changes based on context")]
	public Vector3 LAGIIOINLDG
	{
		[Cpp2IlInjected.Token(Token = "0x60002F4")]
		[Cpp2IlInjected.Address(RVA = "0x6219400", Offset = "0x6218200", VA = "0x186219400", Slot = "6")]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x60002F5")]
		[Cpp2IlInjected.Address(RVA = "0x62194B0", Offset = "0x62182B0", VA = "0x1862194B0", Slot = "7")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000CA")]
	public Vector3 LAADKICONEE
	{
		[Cpp2IlInjected.Token(Token = "0x60002F6")]
		[Cpp2IlInjected.Address(RVA = "0x6219060", Offset = "0x6217E60", VA = "0x186219060")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000CB")]
	public Vector3 EDCMDBJHPAE
	{
		[Cpp2IlInjected.Token(Token = "0x60002F8")]
		[Cpp2IlInjected.Address(RVA = "0x6219840", Offset = "0x6218640", VA = "0x186219840")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000CC")]
	[Obsolete("Use TryGetWorldCenterOfMassOfHierarchy() or GetWorldCenterOfMassOfSelf()")]
	public Vector3 IFPDMFNNGAF
	{
		[Cpp2IlInjected.Token(Token = "0x60002F9")]
		[Cpp2IlInjected.Address(RVA = "0x6219970", Offset = "0x6218770", VA = "0x186219970", Slot = "8")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000CD")]
	[Obsolete("Use MassOfSelf or TryGetMassOfHierarchy instead")]
	public float EAFPGFDGIND
	{
		[Cpp2IlInjected.Token(Token = "0x60002FA")]
		[Cpp2IlInjected.Address(RVA = "0x621A4B0", Offset = "0x62192B0", VA = "0x18621A4B0", Slot = "9")]
		get
		{
			return default(float);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000CE")]
	public float KAFMNGCMEBJ
	{
		[Cpp2IlInjected.Token(Token = "0x60002FB")]
		[Cpp2IlInjected.Address(RVA = "0x621AD90", Offset = "0x6219B90", VA = "0x18621AD90")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000CF")]
	public float OJDNJKNJAAN
	{
		[Cpp2IlInjected.Token(Token = "0x60002FC")]
		[Cpp2IlInjected.Address(RVA = "0x621A700", Offset = "0x6219500", VA = "0x18621A700", Slot = "10")]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x60002FD")]
		[Cpp2IlInjected.Address(RVA = "0x621A3F0", Offset = "0x62191F0", VA = "0x18621A3F0", Slot = "11")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000D0")]
	public Vector3 FPIAMPLDLPJ
	{
		[Cpp2IlInjected.Token(Token = "0x60002FE")]
		[Cpp2IlInjected.Address(RVA = "0x621B460", Offset = "0x621A260", VA = "0x18621B460", Slot = "12")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000D1")]
	public Quaternion EDBMEAAFNGM
	{
		[Cpp2IlInjected.Token(Token = "0x60002FF")]
		[Cpp2IlInjected.Address(RVA = "0x6219810", Offset = "0x6218610", VA = "0x186219810", Slot = "13")]
		get
		{
			return default(Quaternion);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000D2")]
	private Rigidbody PEOFAJLGEEJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000308")]
		[Cpp2IlInjected.Address(RVA = "0x6209C00", Offset = "0x6208A00", VA = "0x186209C00")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000034")]
	public event HJACFJGDJJO DHNBOAOHJFG
	{
		[Cpp2IlInjected.Token(Token = "0x60002F1")]
		[Cpp2IlInjected.Address(RVA = "0x621AE10", Offset = "0x6219C10", VA = "0x18621AE10", Slot = "4")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60002F2")]
		[Cpp2IlInjected.Address(RVA = "0x6219360", Offset = "0x6218160", VA = "0x186219360", Slot = "5")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60002F3")]
	[Cpp2IlInjected.Address(RVA = "0x621C6F0", Offset = "0x621B4F0", VA = "0x18621C6F0")]
	public IKBCKBHOPLI(HKDDEEJINEH HHJJKPNJLAD, [In] POAMDCEFDPK PFDMLBFKIAP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002F7")]
	[Cpp2IlInjected.Address(RVA = "0x6219110", Offset = "0x6217F10", VA = "0x186219110")]
	public float3 AGLOMKPIBDH()
	{
		return default(float3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000300")]
	[Cpp2IlInjected.Address(RVA = "0x6219B60", Offset = "0x6218960", VA = "0x186219B60", Slot = "14")]
	public void EGGEMACIFEN((Quaternion rot, Vector3 moments) IGICCOJIDDA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000301")]
	[Cpp2IlInjected.Address(RVA = "0x621A510", Offset = "0x6219310", VA = "0x18621A510", Slot = "16")]
	public void IBKBPPNCAPO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000302")]
	[Cpp2IlInjected.Address(RVA = "0x621B110", Offset = "0x6219F10", VA = "0x18621B110", Slot = "15")]
	public void NDMOMLBEAEJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000303")]
	[Cpp2IlInjected.Address(RVA = "0x6219290", Offset = "0x6218090", VA = "0x186219290", Slot = "18")]
	public void AKOMFNGCOKL(Rigidbody OPIJOIJPNML)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000304")]
	[Cpp2IlInjected.Address(RVA = "0x621A760", Offset = "0x6219560", VA = "0x18621A760", Slot = "19")]
	public void IPMEDHDLDMK(Rigidbody OPIJOIJPNML)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000305")]
	[Cpp2IlInjected.Address(RVA = "0x6219230", Offset = "0x6218030", VA = "0x186219230", Slot = "17")]
	public void AHJPIEKBAGK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000306")]
	[Cpp2IlInjected.Address(RVA = "0x6219DF0", Offset = "0x6218BF0", VA = "0x186219DF0", Slot = "20")]
	public void GCBLHPDNFDB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000307")]
	[Cpp2IlInjected.Address(RVA = "0x620A430", Offset = "0x6209230", VA = "0x18620A430")]
	public void JEOLOCLIFIC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000309")]
	[Cpp2IlInjected.Address(RVA = "0x62194B0", Offset = "0x62182B0", VA = "0x1862194B0")]
	private void FBJBEDNFGNF(Vector3 GNLEHBFFNFG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600030A")]
	[Cpp2IlInjected.Address(RVA = "0x6219630", Offset = "0x6218430", VA = "0x186219630")]
	[Obsolete("Changes based on context.  the unity rigidbody center of mass has a different scale as well")]
	private Vector3 CFFKAFFEILN()
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x600030B")]
	[Cpp2IlInjected.Address(RVA = "0x621A3F0", Offset = "0x62191F0", VA = "0x18621A3F0")]
	private void ICLAJDHLMGP(float GNLEHBFFNFG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600030C")]
	[Cpp2IlInjected.Address(RVA = "0x621AEB0", Offset = "0x6219CB0", VA = "0x18621AEB0")]
	private Vector3 MIIJGIEGJOB()
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x600030D")]
	[Cpp2IlInjected.Address(RVA = "0x621AB50", Offset = "0x6219950", VA = "0x18621AB50")]
	private Quaternion LGJLLIHIOJI()
	{
		return default(Quaternion);
	}

	[Cpp2IlInjected.Token(Token = "0x600030E")]
	[Cpp2IlInjected.Address(RVA = "0x621B490", Offset = "0x621A290", VA = "0x18621B490")]
	internal (float, Vector3) PNBEMPHMPJN(Rigidbody OIADHONCLLD)
	{
		return default((float, Vector3));
	}
}
[Cpp2IlInjected.Token(Token = "0x2000033")]
internal static class OFPOPKHFEML
{
	[Cpp2IlInjected.Token(Token = "0x600030F")]
	[Cpp2IlInjected.Address(RVA = "0x622D990", Offset = "0x622C790", VA = "0x18622D990")]
	public static IKBCKBHOPLI MFLLAHBHJEI(this HKDDEEJINEH BAHHCFCHDLD)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000034")]
internal sealed class BMNAPOJFIPA : HGDEGDIAANM, NOJOGIBNEOM
{
	[Cpp2IlInjected.Token(Token = "0x170000D3")]
	public bool NLNHJKJKKEJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000310")]
		[Cpp2IlInjected.Address(RVA = "0x620AF00", Offset = "0x6209D00", VA = "0x18620AF00", Slot = "10")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000D4")]
	public GOIKPLFAGFM EPFBMJBFGDE
	{
		[Cpp2IlInjected.Token(Token = "0x6000311")]
		[Cpp2IlInjected.Address(RVA = "0x620B060", Offset = "0x6209E60", VA = "0x18620B060", Slot = "11")]
		get
		{
			return default(GOIKPLFAGFM);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000D5")]
	private GOIKPLFAGFM MEPPCOHEAJK
	{
		[Cpp2IlInjected.Token(Token = "0x6000313")]
		[Cpp2IlInjected.Address(RVA = "0x620B060", Offset = "0x6209E60", VA = "0x18620B060")]
		get
		{
			return default(GOIKPLFAGFM);
		}
		[Cpp2IlInjected.Token(Token = "0x6000314")]
		[Cpp2IlInjected.Address(RVA = "0x620AD30", Offset = "0x6209B30", VA = "0x18620AD30")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000312")]
	[Cpp2IlInjected.Address(RVA = "0x620B640", Offset = "0x620A440", VA = "0x18620B640")]
	public BMNAPOJFIPA(HKDDEEJINEH HHJJKPNJLAD, [In] POAMDCEFDPK PFDMLBFKIAP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000315")]
	[Cpp2IlInjected.Address(RVA = "0x620B0C0", Offset = "0x6209EC0", VA = "0x18620B0C0", Slot = "4")]
	public void EKBEIHECLAM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000316")]
	[Cpp2IlInjected.Address(RVA = "0x620AE20", Offset = "0x6209C20", VA = "0x18620AE20")]
	private bool BKJFCFGOHAN()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000317")]
	[Cpp2IlInjected.Address(RVA = "0x620AF60", Offset = "0x6209D60", VA = "0x18620AF60", Slot = "5")]
	public void CEFMILCLFJN(object PFKLELGAJPH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000318")]
	[Cpp2IlInjected.Address(RVA = "0x620ADA0", Offset = "0x6209BA0", VA = "0x18620ADA0", Slot = "6")]
	public void BCPDHMLIKGA(object PFKLELGAJPH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000319")]
	[Cpp2IlInjected.Address(RVA = "0x620B4E0", Offset = "0x620A2E0", VA = "0x18620B4E0", Slot = "9")]
	public void PHFBKCGNAGE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600031A")]
	[Cpp2IlInjected.Address(RVA = "0x620B1C0", Offset = "0x6209FC0", VA = "0x18620B1C0")]
	private void GHMHKKBIDJC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600031B")]
	[Cpp2IlInjected.Address(RVA = "0x620B2C0", Offset = "0x620A0C0", VA = "0x18620B2C0")]
	private void IDMKIEDLGNB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600031C")]
	[Cpp2IlInjected.Address(RVA = "0x620B460", Offset = "0x620A260", VA = "0x18620B460", Slot = "8")]
	public void KDDBNDNFPEC(HKDDEEJINEH HHJJKPNJLAD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600031D")]
	[Cpp2IlInjected.Address(RVA = "0x620AFE0", Offset = "0x6209DE0", VA = "0x18620AFE0", Slot = "7")]
	public void CFNNIIIAENJ(HKDDEEJINEH HHJJKPNJLAD)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000035")]
internal sealed class BFGHMMNAPGG : HGDEGDIAANM, PPFMEJNLLFC
{
	[Cpp2IlInjected.Token(Token = "0x170000D6")]
	public bool EAAEJMCMHOM
	{
		[Cpp2IlInjected.Token(Token = "0x6000320")]
		[Cpp2IlInjected.Address(RVA = "0x620A620", Offset = "0x6209420", VA = "0x18620A620", Slot = "7")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000D7")]
	private bool IEGIIMAOPLM
	{
		[Cpp2IlInjected.Token(Token = "0x6000321")]
		[Cpp2IlInjected.Address(RVA = "0x620A6F0", Offset = "0x62094F0", VA = "0x18620A6F0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000035")]
	public event HJACFJGDJJO AIKMIOLKDDL
	{
		[Cpp2IlInjected.Token(Token = "0x600031E")]
		[Cpp2IlInjected.Address(RVA = "0x620A570", Offset = "0x6209370", VA = "0x18620A570", Slot = "4")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600031F")]
		[Cpp2IlInjected.Address(RVA = "0x620A2B0", Offset = "0x62090B0", VA = "0x18620A2B0", Slot = "5")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000322")]
	[Cpp2IlInjected.Address(RVA = "0x6209E90", Offset = "0x6208C90", VA = "0x186209E90")]
	public BFGHMMNAPGG(HKDDEEJINEH HHJJKPNJLAD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000323")]
	[Cpp2IlInjected.Address(RVA = "0x620A680", Offset = "0x6209480", VA = "0x18620A680", Slot = "11")]
	public IDisposable NJGCPDMJAEB()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000324")]
	[Cpp2IlInjected.Address(RVA = "0x620A2A0", Offset = "0x62090A0", VA = "0x18620A2A0", Slot = "8")]
	public void GHPBAHFCNAI(object PFKLELGAJPH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000325")]
	[Cpp2IlInjected.Address(RVA = "0x620A610", Offset = "0x6209410", VA = "0x18620A610", Slot = "9")]
	public void KEANJAENHKI(object PFKLELGAJPH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000326")]
	[Cpp2IlInjected.Address(RVA = "0x620A470", Offset = "0x6209270", VA = "0x18620A470", Slot = "10")]
	public void JKGNPHGDHEP(object PFKLELGAJPH, bool JJIMCKPIKFL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000327")]
	[Cpp2IlInjected.Address(RVA = "0x620A1C0", Offset = "0x6208FC0", VA = "0x18620A1C0", Slot = "12")]
	public void AKOMFNGCOKL(Rigidbody MAAIGBPPBFP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000328")]
	[Cpp2IlInjected.Address(RVA = "0x620A350", Offset = "0x6209150", VA = "0x18620A350", Slot = "13")]
	public void IPMEDHDLDMK(Rigidbody OPIJOIJPNML)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000329")]
	[Cpp2IlInjected.Address(RVA = "0x620A430", Offset = "0x6209230", VA = "0x18620A430", Slot = "6")]
	public void JABFHFFOFFB()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000036")]
internal sealed class IGGMOJOIEOJ : HGDEGDIAANM, IHPGPDPIGPG, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000051")]
	private PhotonView AIHFPABPIJH;

	[Cpp2IlInjected.Token(Token = "0x170000D8")]
	public bool OLIJLEJGNMI
	{
		[Cpp2IlInjected.Token(Token = "0x600032C")]
		[Cpp2IlInjected.Address(RVA = "0x6211700", Offset = "0x6210500", VA = "0x186211700", Slot = "6")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000D9")]
	public bool BLFPMICGOPE
	{
		[Cpp2IlInjected.Token(Token = "0x600032D")]
		[Cpp2IlInjected.Address(RVA = "0x62188D0", Offset = "0x62176D0", VA = "0x1862188D0", Slot = "7")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000036")]
	public event HJACFJGDJJO AJIMHCJENHI
	{
		[Cpp2IlInjected.Token(Token = "0x600032A")]
		[Cpp2IlInjected.Address(RVA = "0x6218D20", Offset = "0x6217B20", VA = "0x186218D20", Slot = "4")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600032B")]
		[Cpp2IlInjected.Address(RVA = "0x6218250", Offset = "0x6217050", VA = "0x186218250", Slot = "5")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600032E")]
	[Cpp2IlInjected.Address(RVA = "0x6218FA0", Offset = "0x6217DA0", VA = "0x186218FA0")]
	public IGGMOJOIEOJ(HKDDEEJINEH HHJJKPNJLAD, [In] POAMDCEFDPK PFDMLBFKIAP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600032F")]
	[Cpp2IlInjected.Address(RVA = "0x6218450", Offset = "0x6217250", VA = "0x186218450", Slot = "8")]
	public void EKBEIHECLAM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000330")]
	[Cpp2IlInjected.Address(RVA = "0x62182F0", Offset = "0x62170F0", VA = "0x1862182F0", Slot = "11")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000331")]
	[Cpp2IlInjected.Address(RVA = "0x6218580", Offset = "0x6217380", VA = "0x186218580", Slot = "9")]
	public void EPMJNGFKGOJ(HKDDEEJINEH LBLLNFOEKNE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000332")]
	[Cpp2IlInjected.Address(RVA = "0x6218B20", Offset = "0x6217920", VA = "0x186218B20", Slot = "10")]
	public void MMKKGNPOEMK(HKDDEEJINEH LBLLNFOEKNE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000333")]
	[Cpp2IlInjected.Address(RVA = "0x6218DC0", Offset = "0x6217BC0", VA = "0x186218DC0")]
	private void PPIGCGIFAKD(PhotonView HNHHMNEOMDL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000334")]
	[Cpp2IlInjected.Address(RVA = "0x6218780", Offset = "0x6217580", VA = "0x186218780")]
	private void FLFBHJJHINK(RigidbodyEx IAGCHPMCADD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000335")]
	[Cpp2IlInjected.Address(RVA = "0x6218960", Offset = "0x6217760", VA = "0x186218960")]
	private void GBIOCMCOGHB(PhotonView KJBJIFODHIF)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000037")]
internal static class AFFFDCMPFPF
{
	[Cpp2IlInjected.Token(Token = "0x6000336")]
	[Cpp2IlInjected.Address(RVA = "0x6209620", Offset = "0x6208420", VA = "0x186209620")]
	public static IGGMOJOIEOJ FHEMMGCLFHF(this KOAFFLFFEOP BAHHCFCHDLD)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000038")]
internal sealed class JIBKBDHKDNC : HGDEGDIAANM, KPIMHBGJADP
{
	[Cpp2IlInjected.Token(Token = "0x170000DA")]
	public bool KNJAHLAHOMB
	{
		[Cpp2IlInjected.Token(Token = "0x6000337")]
		[Cpp2IlInjected.Address(RVA = "0x621DB10", Offset = "0x621C910", VA = "0x18621DB10", Slot = "4")]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000338")]
		[Cpp2IlInjected.Address(RVA = "0x621D8C0", Offset = "0x621C6C0", VA = "0x18621D8C0", Slot = "5")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000DB")]
	public bool AAPLFACBCHC
	{
		[Cpp2IlInjected.Token(Token = "0x6000339")]
		[Cpp2IlInjected.Address(RVA = "0x621DC60", Offset = "0x621CA60", VA = "0x18621DC60", Slot = "6")]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x600033A")]
		[Cpp2IlInjected.Address(RVA = "0x621DB70", Offset = "0x621C970", VA = "0x18621DB70")]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000DC")]
	public RigidbodyConstraints BNDMKIOPOHA
	{
		[Cpp2IlInjected.Token(Token = "0x600033B")]
		[Cpp2IlInjected.Address(RVA = "0x621D930", Offset = "0x621C730", VA = "0x18621D930", Slot = "7")]
		get
		{
			return default(RigidbodyConstraints);
		}
		[Cpp2IlInjected.Token(Token = "0x600033C")]
		[Cpp2IlInjected.Address(RVA = "0x621D990", Offset = "0x621C790", VA = "0x18621D990", Slot = "8")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600033D")]
	[Cpp2IlInjected.Address(RVA = "0x621DCC0", Offset = "0x621CAC0", VA = "0x18621DCC0")]
	public JIBKBDHKDNC(HKDDEEJINEH HHJJKPNJLAD, [In] POAMDCEFDPK PFDMLBFKIAP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600033E")]
	[Cpp2IlInjected.Address(RVA = "0x621D830", Offset = "0x621C630", VA = "0x18621D830", Slot = "9")]
	public void AKOMFNGCOKL(Rigidbody OPIJOIJPNML)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600033F")]
	[Cpp2IlInjected.Address(RVA = "0x621DBE0", Offset = "0x621C9E0", VA = "0x18621DBE0", Slot = "10")]
	public void IPMEDHDLDMK(Rigidbody OPIJOIJPNML)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000039")]
internal sealed class HPLFANJLBIE : HGDEGDIAANM, DLMELLONDOM
{
	[Cpp2IlInjected.Token(Token = "0x170000DD")]
	public float OLGPPBCDIPC
	{
		[Cpp2IlInjected.Token(Token = "0x6000341")]
		[Cpp2IlInjected.Address(RVA = "0x6218010", Offset = "0x6216E10", VA = "0x186218010", Slot = "4")]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x6000342")]
		[Cpp2IlInjected.Address(RVA = "0x6217C40", Offset = "0x6216A40", VA = "0x186217C40", Slot = "5")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000DE")]
	public float MILAOBCOIDB
	{
		[Cpp2IlInjected.Token(Token = "0x6000343")]
		[Cpp2IlInjected.Address(RVA = "0x6217EE0", Offset = "0x6216CE0", VA = "0x186217EE0", Slot = "6")]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x6000344")]
		[Cpp2IlInjected.Address(RVA = "0x6217D90", Offset = "0x6216B90", VA = "0x186217D90", Slot = "7")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000340")]
	[Cpp2IlInjected.Address(RVA = "0x6209E90", Offset = "0x6208C90", VA = "0x186209E90")]
	public HPLFANJLBIE(HKDDEEJINEH HHJJKPNJLAD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000345")]
	[Cpp2IlInjected.Address(RVA = "0x6217B50", Offset = "0x6216950", VA = "0x186217B50", Slot = "8")]
	public void AKOMFNGCOKL(Rigidbody OPIJOIJPNML)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000346")]
	[Cpp2IlInjected.Address(RVA = "0x6217F40", Offset = "0x6216D40", VA = "0x186217F40", Slot = "9")]
	public void IPMEDHDLDMK(Rigidbody OPIJOIJPNML)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200003A")]
[LKMFAIPHKDB(typeof(AOFEKDJFLMC), new string[] { })]
public sealed class FJKCGJFAOHG : IJCLFGAEMDL, AOFEKDJFLMC, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000052")]
	[MBPNJDODNHC]
	private BGJEPDMMNIC HHJJKPNJLAD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000053")]
	private bool GIDFIEECIAK;

	[Cpp2IlInjected.Token(Token = "0x170000DF")]
	public bool LPLEMOIFKPC
	{
		[Cpp2IlInjected.Token(Token = "0x6000349")]
		[Cpp2IlInjected.Address(RVA = "0x7D0BF0", Offset = "0x7CF9F0", VA = "0x1807D0BF0", Slot = "5")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000347")]
	[Cpp2IlInjected.Address(RVA = "0x6212AE0", Offset = "0x62118E0", VA = "0x186212AE0", Slot = "4")]
	public void InitReferences(LHNHCAPHDGO PDGDCGJNEFO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000348")]
	[Cpp2IlInjected.Address(RVA = "0x6212AB0", Offset = "0x62118B0", VA = "0x186212AB0", Slot = "8")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600034A")]
	[Cpp2IlInjected.Address(RVA = "0x6212F00", Offset = "0x6211D00", VA = "0x186212F00", Slot = "6")]
	public void PNBEMPHMPJN(JBMJEBCFLLB OGPPAJOCABK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600034B")]
	[Cpp2IlInjected.Address(RVA = "0x6212CE0", Offset = "0x6211AE0", VA = "0x186212CE0", Slot = "7")]
	public void PIDNBNMCMMB(JBMJEBCFLLB OGPPAJOCABK, bool CIIGNNMMLIB, bool HAMHFKMJOCN, bool GANBKGMDIOJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600034C")]
	[Cpp2IlInjected.Address(RVA = "0x6212C20", Offset = "0x6211A20", VA = "0x186212C20")]
	private bool OJMOGGDMOHG(JBMJEBCFLLB OGPPAJOCABK, [Out] HDEONHFPAIJ BAHHCFCHDLD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600034D")]
	[Cpp2IlInjected.Address(RVA = "0x6212B30", Offset = "0x6211930", VA = "0x186212B30")]
	private bool NMEOOABBJHD(JBMJEBCFLLB OGPPAJOCABK, [Out] IKBCKBHOPLI FCNPMJOPLMN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600034E")]
	[Cpp2IlInjected.Address(RVA = "0x76E9D0", Offset = "0x76D7D0", VA = "0x18076E9D0")]
	public FJKCGJFAOHG()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200003B")]
internal sealed class DPENDBDKCFP : HGDEGDIAANM, KPOOLPDCCMI
{
	[Cpp2IlInjected.Token(Token = "0x170000E0")]
	private Rigidbody PEOFAJLGEEJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000351")]
		[Cpp2IlInjected.Address(RVA = "0x6209C00", Offset = "0x6208A00", VA = "0x186209C00")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000E1")]
	private bool GOFFCLKAJJJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000352")]
		[Cpp2IlInjected.Address(RVA = "0x620FF50", Offset = "0x620ED50", VA = "0x18620FF50")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000E2")]
	private HKDDEEJINEH ADEHKCCOJGF
	{
		[Cpp2IlInjected.Token(Token = "0x6000353")]
		[Cpp2IlInjected.Address(RVA = "0x620FA20", Offset = "0x620E820", VA = "0x18620FA20")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000E3")]
	private bool EAILHMIAFFL
	{
		[Cpp2IlInjected.Token(Token = "0x6000354")]
		[Cpp2IlInjected.Address(RVA = "0x620FD50", Offset = "0x620EB50", VA = "0x18620FD50")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000E4")]
	private bool HIDONMPDDNA
	{
		[Cpp2IlInjected.Token(Token = "0x6000355")]
		[Cpp2IlInjected.Address(RVA = "0x620FB60", Offset = "0x620E960", VA = "0x18620FB60")]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000356")]
		[Cpp2IlInjected.Address(RVA = "0x620F7C0", Offset = "0x620E5C0", VA = "0x18620F7C0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000E5")]
	private bool OKLCHNCMHLG
	{
		[Cpp2IlInjected.Token(Token = "0x6000357")]
		[Cpp2IlInjected.Address(RVA = "0x620F830", Offset = "0x620E630", VA = "0x18620F830")]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000358")]
		[Cpp2IlInjected.Address(RVA = "0x620FA80", Offset = "0x620E880", VA = "0x18620FA80")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000E6")]
	private int HBCMKOPAMNE
	{
		[Cpp2IlInjected.Token(Token = "0x6000359")]
		[Cpp2IlInjected.Address(RVA = "0x620FAF0", Offset = "0x620E8F0", VA = "0x18620FAF0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000037")]
	public event HJACFJGDJJO FPONCMMAGCA
	{
		[Cpp2IlInjected.Token(Token = "0x600034F")]
		[Cpp2IlInjected.Address(RVA = "0x6210120", Offset = "0x620EF20", VA = "0x186210120", Slot = "4")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000350")]
		[Cpp2IlInjected.Address(RVA = "0x620FCB0", Offset = "0x620EAB0", VA = "0x18620FCB0", Slot = "5")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600035A")]
	[Cpp2IlInjected.Address(RVA = "0x62101C0", Offset = "0x620EFC0", VA = "0x1862101C0")]
	public DPENDBDKCFP(HKDDEEJINEH HHJJKPNJLAD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600035B")]
	[Cpp2IlInjected.Address(RVA = "0x620F970", Offset = "0x620E770", VA = "0x18620F970", Slot = "6")]
	public void EKBEIHECLAM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600035C")]
	[Cpp2IlInjected.Address(RVA = "0x620FF70", Offset = "0x620ED70", VA = "0x18620FF70", Slot = "8")]
	public void NBMHCNLDPDP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600035D")]
	[Cpp2IlInjected.Address(RVA = "0x620FDB0", Offset = "0x620EBB0", VA = "0x18620FDB0", Slot = "7")]
	public bool LOELNNODNDF()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600035E")]
	[Cpp2IlInjected.Address(RVA = "0x620FBC0", Offset = "0x620E9C0", VA = "0x18620FBC0", Slot = "9")]
	public void JBPIAAMLKCO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600035F")]
	[Cpp2IlInjected.Address(RVA = "0x620A430", Offset = "0x6209230", VA = "0x18620A430", Slot = "12")]
	public void HMMDNFNCIPM(bool IMPHHDIGJPJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000360")]
	[Cpp2IlInjected.Address(RVA = "0x620FFE0", Offset = "0x620EDE0", VA = "0x18620FFE0", Slot = "11")]
	public void NMDENCFDKJJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000361")]
	[Cpp2IlInjected.Address(RVA = "0x762EE0", Offset = "0x761CE0", VA = "0x180762EE0", Slot = "10")]
	public void OFBMHPGIINO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000362")]
	[Cpp2IlInjected.Address(RVA = "0x620F890", Offset = "0x620E690", VA = "0x18620F890")]
	private void BMMDMINMGOM()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200003C")]
internal sealed class GNFFOOEMBDO : HGDEGDIAANM, IMMDALGJOAC
{
	[Cpp2IlInjected.Token(Token = "0x170000E7")]
	public Rigidbody PEOFAJLGEEJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000363")]
		[Cpp2IlInjected.Address(RVA = "0x6215CD0", Offset = "0x6214AD0", VA = "0x186215CD0", Slot = "4")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000364")]
		[Cpp2IlInjected.Address(RVA = "0x6215900", Offset = "0x6214700", VA = "0x186215900")]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000E8")]
	private bool EAILHMIAFFL
	{
		[Cpp2IlInjected.Token(Token = "0x6000365")]
		[Cpp2IlInjected.Address(RVA = "0x620E660", Offset = "0x620D460", VA = "0x18620E660")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000E9")]
	public bool IOFOHBAAMME
	{
		[Cpp2IlInjected.Token(Token = "0x6000368")]
		[Cpp2IlInjected.Address(RVA = "0x6215620", Offset = "0x6214420", VA = "0x186215620", Slot = "6")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000366")]
	[Cpp2IlInjected.Address(RVA = "0x6216050", Offset = "0x6214E50", VA = "0x186216050")]
	public GNFFOOEMBDO(HKDDEEJINEH HHJJKPNJLAD, [In] POAMDCEFDPK PFDMLBFKIAP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000367")]
	[Cpp2IlInjected.Address(RVA = "0x6215850", Offset = "0x6214650", VA = "0x186215850", Slot = "5")]
	public void EKBEIHECLAM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000369")]
	[Cpp2IlInjected.Address(RVA = "0x6215FD0", Offset = "0x6214DD0", VA = "0x186215FD0", Slot = "7")]
	public void OJJAOMJIFMM(object PFKLELGAJPH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600036A")]
	[Cpp2IlInjected.Address(RVA = "0x6215C50", Offset = "0x6214A50", VA = "0x186215C50", Slot = "8")]
	public void IIIGLEPLPKA(object PFKLELGAJPH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600036B")]
	[Cpp2IlInjected.Address(RVA = "0x6215DB0", Offset = "0x6214BB0", VA = "0x186215DB0", Slot = "9")]
	public void JNNPGHIKFLG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600036C")]
	[Cpp2IlInjected.Address(RVA = "0x62159F0", Offset = "0x62147F0", VA = "0x1862159F0", Slot = "11")]
	public void GNNNFNGNOHG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600036D")]
	[Cpp2IlInjected.Address(RVA = "0x6215680", Offset = "0x6214480", VA = "0x186215680", Slot = "12")]
	public void DIOBFNGFIGJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600036E")]
	[Cpp2IlInjected.Address(RVA = "0x762EE0", Offset = "0x761CE0", VA = "0x180762EE0", Slot = "10")]
	public void GJMECAEMJDK()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200003D")]
internal sealed class JKHKFGOJCAB : HGDEGDIAANM, EDHOGNBFGNL, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x170000EA")]
	public LBJHINFHGBL JNGDLEGDDIJ
	{
		[Cpp2IlInjected.Token(Token = "0x600036F")]
		[Cpp2IlInjected.Address(RVA = "0x62216B0", Offset = "0x62204B0", VA = "0x1862216B0", Slot = "4")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000370")]
		[Cpp2IlInjected.Address(RVA = "0x6221790", Offset = "0x6220590", VA = "0x186221790", Slot = "5")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000EB")]
	public JOFEBGGLMFG NDNIBPFIBJI
	{
		[Cpp2IlInjected.Token(Token = "0x6000371")]
		[Cpp2IlInjected.Address(RVA = "0x62218F0", Offset = "0x62206F0", VA = "0x1862218F0", Slot = "6")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000372")]
		[Cpp2IlInjected.Address(RVA = "0x621F580", Offset = "0x621E380", VA = "0x18621F580", Slot = "7")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000EC")]
	public Vector3 EGDFHNKFGGC
	{
		[Cpp2IlInjected.Token(Token = "0x6000373")]
		[Cpp2IlInjected.Address(RVA = "0x621F9B0", Offset = "0x621E7B0", VA = "0x18621F9B0", Slot = "8")]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x6000374")]
		[Cpp2IlInjected.Address(RVA = "0x6220C20", Offset = "0x621FA20", VA = "0x186220C20", Slot = "9")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000ED")]
	public Vector3 KHBEFLDEFGN
	{
		[Cpp2IlInjected.Token(Token = "0x6000375")]
		[Cpp2IlInjected.Address(RVA = "0x6221760", Offset = "0x6220560", VA = "0x186221760", Slot = "10")]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x6000376")]
		[Cpp2IlInjected.Address(RVA = "0x621E3E0", Offset = "0x621D1E0", VA = "0x18621E3E0", Slot = "11")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000EE")]
	public Vector3 ECOGONCAENI
	{
		[Cpp2IlInjected.Token(Token = "0x6000377")]
		[Cpp2IlInjected.Address(RVA = "0x621FA80", Offset = "0x621E880", VA = "0x18621FA80", Slot = "12")]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x6000378")]
		[Cpp2IlInjected.Address(RVA = "0x621F8F0", Offset = "0x621E6F0", VA = "0x18621F8F0", Slot = "13")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000EF")]
	public Vector3 JJILBICKFBG
	{
		[Cpp2IlInjected.Token(Token = "0x6000379")]
		[Cpp2IlInjected.Address(RVA = "0x621E410", Offset = "0x621D210", VA = "0x18621E410", Slot = "14")]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x600037A")]
		[Cpp2IlInjected.Address(RVA = "0x6221860", Offset = "0x6220660", VA = "0x186221860", Slot = "15")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000F0")]
	public float EIKOHCLDIBJ
	{
		[Cpp2IlInjected.Token(Token = "0x600037B")]
		[Cpp2IlInjected.Address(RVA = "0x621E440", Offset = "0x621D240", VA = "0x18621E440", Slot = "16")]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x600037C")]
		[Cpp2IlInjected.Address(RVA = "0x6220D40", Offset = "0x621FB40", VA = "0x186220D40", Slot = "17")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000F1")]
	public bool OAKBMOAOCEK
	{
		[Cpp2IlInjected.Token(Token = "0x600037E")]
		[Cpp2IlInjected.Address(RVA = "0x621F520", Offset = "0x621E320", VA = "0x18621F520", Slot = "18")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000F2")]
	private AEDPOFGENJL AGHMHALDNLC
	{
		[Cpp2IlInjected.Token(Token = "0x6000391")]
		[Cpp2IlInjected.Address(RVA = "0x1C1E880", Offset = "0x1C1D680", VA = "0x181C1E880")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000F3")]
	private bool GOFFCLKAJJJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000392")]
		[Cpp2IlInjected.Address(RVA = "0x620FF50", Offset = "0x620ED50", VA = "0x18620FF50")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600037D")]
	[Cpp2IlInjected.Address(RVA = "0x6209E90", Offset = "0x6208C90", VA = "0x186209E90")]
	public JKHKFGOJCAB(HKDDEEJINEH HHJJKPNJLAD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600037F")]
	[Cpp2IlInjected.Address(RVA = "0x621FA10", Offset = "0x621E810", VA = "0x18621FA10", Slot = "20")]
	public void HLBGFKCDKNL(object PFKLELGAJPH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000380")]
	[Cpp2IlInjected.Address(RVA = "0x621F5F0", Offset = "0x621E3F0", VA = "0x18621F5F0", Slot = "30")]
	public void FAPJAIJOLLB(object PFKLELGAJPH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000381")]
	[Cpp2IlInjected.Address(RVA = "0x621E6C0", Offset = "0x621D4C0", VA = "0x18621E6C0", Slot = "19")]
	public void EKBEIHECLAM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000382")]
	[Cpp2IlInjected.Address(RVA = "0x621F460", Offset = "0x621E260", VA = "0x18621F460", Slot = "36")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000383")]
	[Cpp2IlInjected.Address(RVA = "0x621E550", Offset = "0x621D350", VA = "0x18621E550", Slot = "28")]
	public void AKOMFNGCOKL(Rigidbody OPIJOIJPNML)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000384")]
	[Cpp2IlInjected.Address(RVA = "0x6220300", Offset = "0x621F100", VA = "0x186220300", Slot = "35")]
	public Vector3 ILHPDEBIDPO(Vector3 FCKPHPBMNBE)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000385")]
	[Cpp2IlInjected.Address(RVA = "0x6221410", Offset = "0x6220210", VA = "0x186221410", Slot = "34")]
	public Vector3 KFOJABECPNA(Vector3 CBFMJBCAHHF)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000386")]
	[Cpp2IlInjected.Address(RVA = "0x621E6C0", Offset = "0x621D4C0", VA = "0x18621E6C0", Slot = "27")]
	public void ALNKOFBADLM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000387")]
	[Cpp2IlInjected.Address(RVA = "0x6221800", Offset = "0x6220600", VA = "0x186221800", Slot = "25")]
	public void ODLAHMAHHIG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000388")]
	[Cpp2IlInjected.Address(RVA = "0x6221890", Offset = "0x6220690", VA = "0x186221890", Slot = "24")]
	public void OMPFMFEHIPL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000389")]
	[Cpp2IlInjected.Address(RVA = "0x621EB80", Offset = "0x621D980", VA = "0x18621EB80", Slot = "33")]
	public void COIPDHOKFEA(Vector3 LCEEOGHIEAE, Vector3 CMCJGKKIFGK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600038A")]
	[Cpp2IlInjected.Address(RVA = "0x6220CE0", Offset = "0x621FAE0", VA = "0x186220CE0", Slot = "32")]
	public void KCHGHBEHDOP(Vector3 NNHCKKDHDOO, Vector3 MKPDHJELIJH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600038B")]
	[Cpp2IlInjected.Address(RVA = "0x621F660", Offset = "0x621E460", VA = "0x18621F660", Slot = "31")]
	public void FEGGONCBCAB(Vector3 MBCLMEKNIMH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600038C")]
	[Cpp2IlInjected.Address(RVA = "0x62206B0", Offset = "0x621F4B0", VA = "0x1862206B0", Slot = "22")]
	public void JJLPMJIAECP(CAJLMHPONNG ODONFGMOICG, Vector3 EBGKJLMCJAI, float EMBPADILADB, float ICDNFDHOPEF = 8f, float PKMFLEJBFBB = 1f)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600038D")]
	[Cpp2IlInjected.Address(RVA = "0x6220050", Offset = "0x621EE50", VA = "0x186220050", Slot = "21")]
	public void IGMBNACPLCP(BPMLBDGOAAA KPBLKDJONKA, Vector3 KHAGNCFGGLP, float DGAGPLDFBFA = float.PositiveInfinity)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600038E")]
	[Cpp2IlInjected.Address(RVA = "0x621EDC0", Offset = "0x621DBC0", VA = "0x18621EDC0", Slot = "23")]
	[Obsolete("Deprecated. Still exists to support deprecated CV2 chips. Use ApplyAngularVelocityChange.")]
	public void CPOAAEBFFIL(BPMLBDGOAAA KPBLKDJONKA, Vector3 GIBIBDOGOLL, float MLEKCJEEFGK = 7f, float JGPJAKHDFMM = 1f)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600038F")]
	[Cpp2IlInjected.Address(RVA = "0x62215D0", Offset = "0x62203D0", VA = "0x1862215D0", Slot = "29")]
	public Vector3 KOMLCDOJFGP(Vector3 HPJBBHHJIEL)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000390")]
	[Cpp2IlInjected.Address(RVA = "0x621E9F0", Offset = "0x621D7F0", VA = "0x18621E9F0", Slot = "26")]
	public void BMNABPGBMMB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000393")]
	[Cpp2IlInjected.Address(RVA = "0x6220D40", Offset = "0x621FB40", VA = "0x186220D40")]
	private void OFGOENDFDNK(float GNLEHBFFNFG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000394")]
	[Cpp2IlInjected.Address(RVA = "0x62204E0", Offset = "0x621F2E0", VA = "0x1862204E0")]
	private void JDBFIHGOMBL(Vector3 KHAGNCFGGLP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000395")]
	[Cpp2IlInjected.Address(RVA = "0x621E770", Offset = "0x621D570", VA = "0x18621E770")]
	private Vector3 BGPHEEPGEIN()
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000396")]
	[Cpp2IlInjected.Address(RVA = "0x6220E90", Offset = "0x621FC90", VA = "0x186220E90")]
	private void KEBNIHMEEJP(Vector3 CBFMJBCAHHF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000397")]
	[Cpp2IlInjected.Address(RVA = "0x621F1D0", Offset = "0x621DFD0", VA = "0x18621F1D0")]
	private Vector3 DIEBBBOOKKJ()
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000398")]
	[Cpp2IlInjected.Address(RVA = "0x621FAE0", Offset = "0x621E8E0", VA = "0x18621FAE0")]
	private void IALALOMLCKJ(Vector3 GNLEHBFFNFG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000399")]
	[Cpp2IlInjected.Address(RVA = "0x621F890", Offset = "0x621E690", VA = "0x18621F890")]
	private void GALGJFKOADN(Vector3 HPJBBHHJIEL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600039A")]
	[Cpp2IlInjected.Address(RVA = "0x621F830", Offset = "0x621E630", VA = "0x18621F830")]
	private void FPCHCPIMNEC(Vector3 LMHADGEOOGN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600039B")]
	[Cpp2IlInjected.Address(RVA = "0x621DE30", Offset = "0x621CC30", VA = "0x18621DE30")]
	private void AFGDBLDEHBM(string PNCPJFJFOOM, Vector3 GNLEHBFFNFG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600039C")]
	[Cpp2IlInjected.Address(RVA = "0x621E4A0", Offset = "0x621D2A0", VA = "0x18621E4A0")]
	private void AJIHNPFGBKA()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200003E")]
internal class HGDEGDIAANM
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000055")]
	protected readonly HDEONHFPAIJ HHJJKPNJLAD;

	[Cpp2IlInjected.Token(Token = "0x170000F4")]
	protected BGJEPDMMNIC DIBIKOCKJEN
	{
		[Cpp2IlInjected.Token(Token = "0x600039D")]
		[Cpp2IlInjected.Address(RVA = "0x53F55C0", Offset = "0x53F43C0", VA = "0x1853F55C0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000F5")]
	protected JBMJEBCFLLB OBEGLAOMPKC
	{
		[Cpp2IlInjected.Token(Token = "0x600039E")]
		[Cpp2IlInjected.Address(RVA = "0x53F5600", Offset = "0x53F4400", VA = "0x1853F5600")]
		get
		{
			return default(JBMJEBCFLLB);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600039F")]
	[Cpp2IlInjected.Address(RVA = "0x6209E90", Offset = "0x6208C90", VA = "0x186209E90")]
	public HGDEGDIAANM(HKDDEEJINEH HHJJKPNJLAD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003A0")]
	[Cpp2IlInjected.Address(RVA = "0x6217AB0", Offset = "0x62168B0", VA = "0x186217AB0")]
	protected HKDDEEJINEH DHFJILBDGHE(JBMJEBCFLLB HAIBOLAMIBL)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200003F")]
public class FGBKDPHNPMJ : OIJLNKKGFII
{
	[Cpp2IlInjected.Token(Token = "0x60003A1")]
	[Cpp2IlInjected.Address(RVA = "0x6212100", Offset = "0x6210F00", VA = "0x186212100", Slot = "4")]
	public CNJKFLKEHNP FOPFKFOAJPB(HKDDEEJINEH BAHHCFCHDLD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003A2")]
	[Cpp2IlInjected.Address(RVA = "0x6212470", Offset = "0x6211270", VA = "0x186212470", Slot = "5")]
	public EDHOGNBFGNL HEHEJFBIECI(HKDDEEJINEH BAHHCFCHDLD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003A3")]
	[Cpp2IlInjected.Address(RVA = "0x6212730", Offset = "0x6211530", VA = "0x186212730", Slot = "6")]
	public JMDJHBDFHNM JENKNAKGHBC(HKDDEEJINEH BAHHCFCHDLD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003A4")]
	[Cpp2IlInjected.Address(RVA = "0x6212810", Offset = "0x6211610", VA = "0x186212810", Slot = "7")]
	public DLMELLONDOM KBPGHNGMBLP(HKDDEEJINEH BAHHCFCHDLD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003A5")]
	[Cpp2IlInjected.Address(RVA = "0x6211E50", Offset = "0x6210C50", VA = "0x186211E50", Slot = "8")]
	public KPOOLPDCCMI DLBBJKBMHCG(HKDDEEJINEH BAHHCFCHDLD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003A6")]
	[Cpp2IlInjected.Address(RVA = "0x6212550", Offset = "0x6211350", VA = "0x186212550", Slot = "9")]
	public IBDFGCOAOJH HMLDNCBNCBD(HKDDEEJINEH BAHHCFCHDLD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003A7")]
	[Cpp2IlInjected.Address(RVA = "0x62128F0", Offset = "0x62116F0", VA = "0x1862128F0", Slot = "10")]
	public PPFMEJNLLFC MIHHGOGKKII(HKDDEEJINEH BAHHCFCHDLD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003A8")]
	[Cpp2IlInjected.Address(RVA = "0x6211D70", Offset = "0x6210B70", VA = "0x186211D70", Slot = "11")]
	public AEDPOFGENJL BMDHNLFPMHG(HKDDEEJINEH BAHHCFCHDLD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003A9")]
	[Cpp2IlInjected.Address(RVA = "0x6212160", Offset = "0x6210F60", VA = "0x186212160", Slot = "12")]
	public DOLMCKAIMMH GBBKLOFEEGG(HKDDEEJINEH BAHHCFCHDLD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003AA")]
	[Cpp2IlInjected.Address(RVA = "0x62129D0", Offset = "0x62117D0", VA = "0x1862129D0", Slot = "13")]
	public AEAEHLIIIHM MPCEOKBAMNI(HKDDEEJINEH BAHHCFCHDLD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003AB")]
	[Cpp2IlInjected.Address(RVA = "0x6212370", Offset = "0x6211170", VA = "0x186212370")]
	public IMMDALGJOAC JDJFPLEAIIO(HKDDEEJINEH BAHHCFCHDLD, [In] POAMDCEFDPK PFDMLBFKIAP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003AC")]
	[Cpp2IlInjected.Address(RVA = "0x6212630", Offset = "0x6211430", VA = "0x186212630")]
	public IHPGPDPIGPG INKLNFJDMGF(HKDDEEJINEH BAHHCFCHDLD, [In] POAMDCEFDPK PFDMLBFKIAP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003AD")]
	[Cpp2IlInjected.Address(RVA = "0x6211FC0", Offset = "0x6210DC0", VA = "0x186211FC0")]
	public NOJOGIBNEOM FFNNPCJDIKH(HKDDEEJINEH BAHHCFCHDLD, [In] POAMDCEFDPK PFDMLBFKIAP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003AE")]
	[Cpp2IlInjected.Address(RVA = "0x6211D00", Offset = "0x6210B00", VA = "0x186211D00")]
	public FHMHFKBPFEJ BLIEMOAADPO(HKDDEEJINEH BAHHCFCHDLD, [In] POAMDCEFDPK PFDMLBFKIAP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003AF")]
	[Cpp2IlInjected.Address(RVA = "0x6211B60", Offset = "0x6210960", VA = "0x186211B60")]
	public KPIMHBGJADP BHGFCBBGNJF(HKDDEEJINEH BAHHCFCHDLD, [In] POAMDCEFDPK PFDMLBFKIAP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003B0")]
	[Cpp2IlInjected.Address(RVA = "0x6212240", Offset = "0x6211040", VA = "0x186212240", Slot = "19")]
	public HKDDEEJINEH GBDBCOGCGCH(RigidbodyEx HHJJKPNJLAD, POAMDCEFDPK PFDMLBFKIAP, JLBIHFBBGKJ OHOLEEOLBDH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003B1")]
	[Cpp2IlInjected.Address(RVA = "0x76E9D0", Offset = "0x76D7D0", VA = "0x18076E9D0")]
	public FGBKDPHNPMJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003B2")]
	[Cpp2IlInjected.Address(RVA = "0x6212370", Offset = "0x6211170", VA = "0x186212370", Slot = "14")]
	private IMMDALGJOAC GKAHIBLONPI(HKDDEEJINEH BAHHCFCHDLD, [In] POAMDCEFDPK PFDMLBFKIAP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003B3")]
	[Cpp2IlInjected.Address(RVA = "0x6212630", Offset = "0x6211430", VA = "0x186212630", Slot = "15")]
	private IHPGPDPIGPG HNDOMKCOEFP(HKDDEEJINEH BAHHCFCHDLD, [In] POAMDCEFDPK PFDMLBFKIAP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003B4")]
	[Cpp2IlInjected.Address(RVA = "0x6211FC0", Offset = "0x6210DC0", VA = "0x186211FC0", Slot = "16")]
	private NOJOGIBNEOM IHBAFNDEJKK(HKDDEEJINEH BAHHCFCHDLD, [In] POAMDCEFDPK PFDMLBFKIAP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003B5")]
	[Cpp2IlInjected.Address(RVA = "0x6211D00", Offset = "0x6210B00", VA = "0x186211D00", Slot = "17")]
	private FHMHFKBPFEJ FOBLCMPHEJO(HKDDEEJINEH BAHHCFCHDLD, [In] POAMDCEFDPK PFDMLBFKIAP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003B6")]
	[Cpp2IlInjected.Address(RVA = "0x6211B50", Offset = "0x6210950", VA = "0x186211B50", Slot = "18")]
	private KPIMHBGJADP AGFGLIBGCIE(HKDDEEJINEH BAHHCFCHDLD, [In] POAMDCEFDPK PFDMLBFKIAP)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000040")]
[DefaultMember("Item")]
public sealed class CGENLOKBCOL : IReadOnlyList<HKDDEEJINEH>, IEnumerable<HKDDEEJINEH>, IEnumerable, IReadOnlyCollection<HKDDEEJINEH>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000056")]
	public readonly JBMJEBCFLLB HAIBOLAMIBL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000057")]
	public readonly BGJEPDMMNIC KCDMGGDCPJH;

	[Cpp2IlInjected.Token(Token = "0x170000F6")]
	public int CBILAPKHPBD
	{
		[Cpp2IlInjected.Token(Token = "0x60003BA")]
		[Cpp2IlInjected.Address(RVA = "0x620DAD0", Offset = "0x620C8D0", VA = "0x18620DAD0", Slot = "5")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000F7")]
	public HKDDEEJINEH BCEJDLMHPFK
	{
		[Cpp2IlInjected.Token(Token = "0x60003BB")]
		[Cpp2IlInjected.Address(RVA = "0x620D980", Offset = "0x620C780", VA = "0x18620D980", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60003B7")]
	[Cpp2IlInjected.Address(RVA = "0x369A320", Offset = "0x3699120", VA = "0x18369A320")]
	public CGENLOKBCOL(JBMJEBCFLLB HAIBOLAMIBL, BGJEPDMMNIC KCDMGGDCPJH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003B8")]
	[Cpp2IlInjected.Address(RVA = "0x620D870", Offset = "0x620C670", VA = "0x18620D870", Slot = "6")]
	public IEnumerator<HKDDEEJINEH> GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003B9")]
	[Cpp2IlInjected.Address(RVA = "0x620D870", Offset = "0x620C670", VA = "0x18620D870", Slot = "7")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003BC")]
	[Cpp2IlInjected.Address(RVA = "0x620D980", Offset = "0x620C780", VA = "0x18620D980")]
	[CompilerGenerated]
	private HKDDEEJINEH NHAJBJHHCHI(int FJLKBMOCNHL)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000041")]
[LKMFAIPHKDB(typeof(OIJLNKKGFII), new string[] { })]
public class EFBMJHOFCBF : OIJLNKKGFII, IJCLFGAEMDL
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000058")]
	private readonly OIJLNKKGFII ANNNHJPMOAI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000059")]
	private readonly OIJLNKKGFII CLGGHKJADNB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400005A")]
	private KMLKLGKDBAC OLAEKCABFGN;

	[Cpp2IlInjected.Token(Token = "0x170000F8")]
	private OIJLNKKGFII PHAOEEKJDCA
	{
		[Cpp2IlInjected.Token(Token = "0x60003BE")]
		[Cpp2IlInjected.Address(RVA = "0x6210B10", Offset = "0x620F910", VA = "0x186210B10")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60003BD")]
	[Cpp2IlInjected.Address(RVA = "0x6210B70", Offset = "0x620F970", VA = "0x186210B70", Slot = "20")]
	public void InitReferences(LHNHCAPHDGO PDGDCGJNEFO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003BF")]
	[Cpp2IlInjected.Address(RVA = "0x6210640", Offset = "0x620F440", VA = "0x186210640", Slot = "4")]
	public CNJKFLKEHNP FOPFKFOAJPB(HKDDEEJINEH BAHHCFCHDLD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003C0")]
	[Cpp2IlInjected.Address(RVA = "0x6210920", Offset = "0x620F720", VA = "0x186210920", Slot = "5")]
	public EDHOGNBFGNL HEHEJFBIECI(HKDDEEJINEH BAHHCFCHDLD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003C1")]
	[Cpp2IlInjected.Address(RVA = "0x6210BC0", Offset = "0x620F9C0", VA = "0x186210BC0", Slot = "6")]
	public JMDJHBDFHNM JENKNAKGHBC(HKDDEEJINEH BAHHCFCHDLD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003C2")]
	[Cpp2IlInjected.Address(RVA = "0x6210C60", Offset = "0x620FA60", VA = "0x186210C60", Slot = "7")]
	public DLMELLONDOM KBPGHNGMBLP(HKDDEEJINEH BAHHCFCHDLD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003C3")]
	[Cpp2IlInjected.Address(RVA = "0x62104F0", Offset = "0x620F2F0", VA = "0x1862104F0", Slot = "8")]
	public KPOOLPDCCMI DLBBJKBMHCG(HKDDEEJINEH BAHHCFCHDLD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003C4")]
	[Cpp2IlInjected.Address(RVA = "0x62109C0", Offset = "0x620F7C0", VA = "0x1862109C0", Slot = "9")]
	public IBDFGCOAOJH HMLDNCBNCBD(HKDDEEJINEH BAHHCFCHDLD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003C5")]
	[Cpp2IlInjected.Address(RVA = "0x6210D00", Offset = "0x620FB00", VA = "0x186210D00", Slot = "10")]
	public PPFMEJNLLFC MIHHGOGKKII(HKDDEEJINEH BAHHCFCHDLD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003C6")]
	[Cpp2IlInjected.Address(RVA = "0x6210450", Offset = "0x620F250", VA = "0x186210450", Slot = "11")]
	public AEDPOFGENJL BMDHNLFPMHG(HKDDEEJINEH BAHHCFCHDLD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003C7")]
	[Cpp2IlInjected.Address(RVA = "0x62106E0", Offset = "0x620F4E0", VA = "0x1862106E0", Slot = "12")]
	public DOLMCKAIMMH GBBKLOFEEGG(HKDDEEJINEH BAHHCFCHDLD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003C8")]
	[Cpp2IlInjected.Address(RVA = "0x6210DA0", Offset = "0x620FBA0", VA = "0x186210DA0", Slot = "13")]
	public AEAEHLIIIHM MPCEOKBAMNI(HKDDEEJINEH BAHHCFCHDLD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003C9")]
	[Cpp2IlInjected.Address(RVA = "0x6210870", Offset = "0x620F670", VA = "0x186210870")]
	public IMMDALGJOAC JDJFPLEAIIO(HKDDEEJINEH BAHHCFCHDLD, [In] POAMDCEFDPK PFDMLBFKIAP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003CA")]
	[Cpp2IlInjected.Address(RVA = "0x6210A60", Offset = "0x620F860", VA = "0x186210A60")]
	public IHPGPDPIGPG INKLNFJDMGF(HKDDEEJINEH BAHHCFCHDLD, [In] POAMDCEFDPK PFDMLBFKIAP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003CB")]
	[Cpp2IlInjected.Address(RVA = "0x6210590", Offset = "0x620F390", VA = "0x186210590")]
	public NOJOGIBNEOM FFNNPCJDIKH(HKDDEEJINEH BAHHCFCHDLD, [In] POAMDCEFDPK PFDMLBFKIAP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003CC")]
	[Cpp2IlInjected.Address(RVA = "0x62103A0", Offset = "0x620F1A0", VA = "0x1862103A0")]
	public FHMHFKBPFEJ BLIEMOAADPO(HKDDEEJINEH BAHHCFCHDLD, [In] POAMDCEFDPK PFDMLBFKIAP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003CD")]
	[Cpp2IlInjected.Address(RVA = "0x62102F0", Offset = "0x620F0F0", VA = "0x1862102F0")]
	public KPIMHBGJADP BHGFCBBGNJF(HKDDEEJINEH BAHHCFCHDLD, [In] POAMDCEFDPK PFDMLBFKIAP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003CE")]
	[Cpp2IlInjected.Address(RVA = "0x6210780", Offset = "0x620F580", VA = "0x186210780", Slot = "19")]
	public HKDDEEJINEH GBDBCOGCGCH(RigidbodyEx HHJJKPNJLAD, POAMDCEFDPK PFDMLBFKIAP, JLBIHFBBGKJ OHOLEEOLBDH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003CF")]
	[Cpp2IlInjected.Address(RVA = "0x6210E40", Offset = "0x620FC40", VA = "0x186210E40")]
	public EFBMJHOFCBF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003D0")]
	[Cpp2IlInjected.Address(RVA = "0x6210870", Offset = "0x620F670", VA = "0x186210870", Slot = "14")]
	private IMMDALGJOAC GKAHIBLONPI(HKDDEEJINEH BAHHCFCHDLD, [In] POAMDCEFDPK PFDMLBFKIAP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003D1")]
	[Cpp2IlInjected.Address(RVA = "0x6210A60", Offset = "0x620F860", VA = "0x186210A60", Slot = "15")]
	private IHPGPDPIGPG HNDOMKCOEFP(HKDDEEJINEH BAHHCFCHDLD, [In] POAMDCEFDPK PFDMLBFKIAP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003D2")]
	[Cpp2IlInjected.Address(RVA = "0x6210590", Offset = "0x620F390", VA = "0x186210590", Slot = "16")]
	private NOJOGIBNEOM IHBAFNDEJKK(HKDDEEJINEH BAHHCFCHDLD, [In] POAMDCEFDPK PFDMLBFKIAP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003D3")]
	[Cpp2IlInjected.Address(RVA = "0x62103A0", Offset = "0x620F1A0", VA = "0x1862103A0", Slot = "17")]
	private FHMHFKBPFEJ FOBLCMPHEJO(HKDDEEJINEH BAHHCFCHDLD, [In] POAMDCEFDPK PFDMLBFKIAP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003D4")]
	[Cpp2IlInjected.Address(RVA = "0x62102F0", Offset = "0x620F0F0", VA = "0x1862102F0", Slot = "18")]
	private KPIMHBGJADP AGFGLIBGCIE(HKDDEEJINEH BAHHCFCHDLD, [In] POAMDCEFDPK PFDMLBFKIAP)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000042")]
[UnityEngine.Scripting.Preserve]
public sealed class KEIKGPFNPDH : HKDDEEJINEH, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x400005B")]
	public static readonly KEIKGPFNPDH GOPCOAILBIE;

	[Cpp2IlInjected.Token(Token = "0x170000F9")]
	public Rigidbody PEOFAJLGEEJ
	{
		[Cpp2IlInjected.Token(Token = "0x60003E7")]
		[Cpp2IlInjected.Address(RVA = "0x763950", Offset = "0x762750", VA = "0x180763950", Slot = "4")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000FA")]
	public RigidbodyEx CCGDNDPOLDJ
	{
		[Cpp2IlInjected.Token(Token = "0x60003E8")]
		[Cpp2IlInjected.Address(RVA = "0x761640", Offset = "0x760440", VA = "0x180761640", Slot = "5")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000FB")]
	public GameObject JJBLAIFLMNG
	{
		[Cpp2IlInjected.Token(Token = "0x60003E9")]
		[Cpp2IlInjected.Address(RVA = "0x761660", Offset = "0x760460", VA = "0x180761660", Slot = "6")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000FC")]
	public Transform HFGEDEDEGAG
	{
		[Cpp2IlInjected.Token(Token = "0x60003EA")]
		[Cpp2IlInjected.Address(RVA = "0x768580", Offset = "0x767380", VA = "0x180768580", Slot = "7")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000FD")]
	public HKDDEEJINEH ADEHKCCOJGF
	{
		[Cpp2IlInjected.Token(Token = "0x60003EB")]
		[Cpp2IlInjected.Address(RVA = "0x765900", Offset = "0x764700", VA = "0x180765900", Slot = "8")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60003EC")]
		[Cpp2IlInjected.Address(RVA = "0x7658F0", Offset = "0x7646F0", VA = "0x1807658F0", Slot = "9")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000FE")]
	public IReadOnlyList<HKDDEEJINEH> ENBMPJKJGMM
	{
		[Cpp2IlInjected.Token(Token = "0x60003ED")]
		[Cpp2IlInjected.Address(RVA = "0x768560", Offset = "0x767360", VA = "0x180768560", Slot = "10")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000FF")]
	public HKDDEEJINEH DKBLNPELKCO
	{
		[Cpp2IlInjected.Token(Token = "0x60003EE")]
		[Cpp2IlInjected.Address(RVA = "0x768550", Offset = "0x767350", VA = "0x180768550", Slot = "11")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000100")]
	public bool OLIJLEJGNMI
	{
		[Cpp2IlInjected.Token(Token = "0x60003EF")]
		[Cpp2IlInjected.Address(RVA = "0x849F90", Offset = "0x848D90", VA = "0x180849F90", Slot = "12")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000101")]
	public bool BLFPMICGOPE
	{
		[Cpp2IlInjected.Token(Token = "0x60003F0")]
		[Cpp2IlInjected.Address(RVA = "0xC93A70", Offset = "0xC92870", VA = "0x180C93A70", Slot = "13")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000102")]
	public LBJHINFHGBL JNGDLEGDDIJ
	{
		[Cpp2IlInjected.Token(Token = "0x60003F1")]
		[Cpp2IlInjected.Address(RVA = "0x764C40", Offset = "0x763A40", VA = "0x180764C40", Slot = "14")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60003F2")]
		[Cpp2IlInjected.Address(RVA = "0x764C30", Offset = "0x763A30", VA = "0x180764C30", Slot = "15")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000103")]
	public JOFEBGGLMFG NDNIBPFIBJI
	{
		[Cpp2IlInjected.Token(Token = "0x60003F3")]
		[Cpp2IlInjected.Address(RVA = "0x764C20", Offset = "0x763A20", VA = "0x180764C20", Slot = "16")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60003F4")]
		[Cpp2IlInjected.Address(RVA = "0x764BE0", Offset = "0x7639E0", VA = "0x180764BE0", Slot = "17")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000104")]
	public float EIKOHCLDIBJ
	{
		[Cpp2IlInjected.Token(Token = "0x60003F5")]
		[Cpp2IlInjected.Address(RVA = "0x924F80", Offset = "0x923D80", VA = "0x180924F80", Slot = "18")]
		[CompilerGenerated]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x60003F6")]
		[Cpp2IlInjected.Address(RVA = "0x7EE290", Offset = "0x7ED090", VA = "0x1807EE290", Slot = "19")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000105")]
	public Vector3 KHBEFLDEFGN
	{
		[Cpp2IlInjected.Token(Token = "0x60003F7")]
		[Cpp2IlInjected.Address(RVA = "0x19D14F0", Offset = "0x19D02F0", VA = "0x1819D14F0", Slot = "20")]
		[CompilerGenerated]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x60003F8")]
		[Cpp2IlInjected.Address(RVA = "0x4642B50", Offset = "0x4641950", VA = "0x184642B50", Slot = "21")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000106")]
	public Vector3 JJILBICKFBG
	{
		[Cpp2IlInjected.Token(Token = "0x60003F9")]
		[Cpp2IlInjected.Address(RVA = "0x62231C0", Offset = "0x6221FC0", VA = "0x1862231C0", Slot = "22")]
		[CompilerGenerated]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x60003FA")]
		[Cpp2IlInjected.Address(RVA = "0x6223220", Offset = "0x6222020", VA = "0x186223220", Slot = "23")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000107")]
	public Vector3 EGDFHNKFGGC
	{
		[Cpp2IlInjected.Token(Token = "0x60003FB")]
		[Cpp2IlInjected.Address(RVA = "0x3028760", Offset = "0x3027560", VA = "0x183028760", Slot = "24")]
		[CompilerGenerated]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x60003FC")]
		[Cpp2IlInjected.Address(RVA = "0x19053A0", Offset = "0x19041A0", VA = "0x1819053A0", Slot = "25")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000108")]
	public Vector3 ECOGONCAENI
	{
		[Cpp2IlInjected.Token(Token = "0x60003FD")]
		[Cpp2IlInjected.Address(RVA = "0xA36730", Offset = "0xA35530", VA = "0x180A36730", Slot = "26")]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x60003FE")]
		[Cpp2IlInjected.Address(RVA = "0x762EE0", Offset = "0x761CE0", VA = "0x180762EE0", Slot = "27")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000109")]
	public bool NNJBEOGIMBG
	{
		[Cpp2IlInjected.Token(Token = "0x60003FF")]
		[Cpp2IlInjected.Address(RVA = "0x867300", Offset = "0x866100", VA = "0x180867300", Slot = "28")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700010A")]
	public bool BPBHDJCNMPF
	{
		[Cpp2IlInjected.Token(Token = "0x6000400")]
		[Cpp2IlInjected.Address(RVA = "0x162D0E0", Offset = "0x162BEE0", VA = "0x18162D0E0", Slot = "29")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700010B")]
	public bool OAKBMOAOCEK
	{
		[Cpp2IlInjected.Token(Token = "0x6000401")]
		[Cpp2IlInjected.Address(RVA = "0x1069F20", Offset = "0x1068D20", VA = "0x181069F20", Slot = "30")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700010C")]
	public Vector3 JFADEILIBMM
	{
		[Cpp2IlInjected.Token(Token = "0x6000402")]
		[Cpp2IlInjected.Address(RVA = "0x302EF50", Offset = "0x302DD50", VA = "0x18302EF50", Slot = "31")]
		[CompilerGenerated]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700010D")]
	public Vector3 OFPFJJDNLBD
	{
		[Cpp2IlInjected.Token(Token = "0x6000403")]
		[Cpp2IlInjected.Address(RVA = "0x8EF490", Offset = "0x8EE290", VA = "0x1808EF490", Slot = "32")]
		[CompilerGenerated]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700010E")]
	public Vector3 LAGIIOINLDG
	{
		[Cpp2IlInjected.Token(Token = "0x6000404")]
		[Cpp2IlInjected.Address(RVA = "0xA36730", Offset = "0xA35530", VA = "0x180A36730", Slot = "33")]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x6000405")]
		[Cpp2IlInjected.Address(RVA = "0x762EE0", Offset = "0x761CE0", VA = "0x180762EE0", Slot = "34")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700010F")]
	public Vector3 IFPDMFNNGAF
	{
		[Cpp2IlInjected.Token(Token = "0x6000406")]
		[Cpp2IlInjected.Address(RVA = "0x62231E0", Offset = "0x6221FE0", VA = "0x1862231E0", Slot = "35")]
		[CompilerGenerated]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000110")]
	public float EAFPGFDGIND
	{
		[Cpp2IlInjected.Token(Token = "0x6000407")]
		[Cpp2IlInjected.Address(RVA = "0x530E770", Offset = "0x530D570", VA = "0x18530E770", Slot = "36")]
		[CompilerGenerated]
		get
		{
			return default(float);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000111")]
	public float OJDNJKNJAAN
	{
		[Cpp2IlInjected.Token(Token = "0x6000408")]
		[Cpp2IlInjected.Address(RVA = "0x7B6040", Offset = "0x7B4E40", VA = "0x1807B6040", Slot = "37")]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x6000409")]
		[Cpp2IlInjected.Address(RVA = "0x762EE0", Offset = "0x761CE0", VA = "0x180762EE0", Slot = "38")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000112")]
	public Vector3 FPIAMPLDLPJ
	{
		[Cpp2IlInjected.Token(Token = "0x600040A")]
		[Cpp2IlInjected.Address(RVA = "0xA36730", Offset = "0xA35530", VA = "0x180A36730", Slot = "39")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000113")]
	public Quaternion EDBMEAAFNGM
	{
		[Cpp2IlInjected.Token(Token = "0x600040B")]
		[Cpp2IlInjected.Address(RVA = "0x7B45F0", Offset = "0x7B33F0", VA = "0x1807B45F0", Slot = "40")]
		get
		{
			return default(Quaternion);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000114")]
	public float OLGPPBCDIPC
	{
		[Cpp2IlInjected.Token(Token = "0x600040D")]
		[Cpp2IlInjected.Address(RVA = "0x7B6040", Offset = "0x7B4E40", VA = "0x1807B6040", Slot = "42")]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x600040E")]
		[Cpp2IlInjected.Address(RVA = "0x762EE0", Offset = "0x761CE0", VA = "0x180762EE0", Slot = "43")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000115")]
	public float MILAOBCOIDB
	{
		[Cpp2IlInjected.Token(Token = "0x600040F")]
		[Cpp2IlInjected.Address(RVA = "0x7B6040", Offset = "0x7B4E40", VA = "0x1807B6040", Slot = "44")]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x6000410")]
		[Cpp2IlInjected.Address(RVA = "0x762EE0", Offset = "0x761CE0", VA = "0x180762EE0", Slot = "45")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000116")]
	public bool KILOFHHLCIA
	{
		[Cpp2IlInjected.Token(Token = "0x6000411")]
		[Cpp2IlInjected.Address(RVA = "0x7AC370", Offset = "0x7AB170", VA = "0x1807AC370", Slot = "46")]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000412")]
		[Cpp2IlInjected.Address(RVA = "0x762EE0", Offset = "0x761CE0", VA = "0x180762EE0", Slot = "47")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000117")]
	public EPMFMHNHMEG PKEADPGLIAA
	{
		[Cpp2IlInjected.Token(Token = "0x6000413")]
		[Cpp2IlInjected.Address(RVA = "0x7AC370", Offset = "0x7AB170", VA = "0x1807AC370", Slot = "48")]
		get
		{
			return default(EPMFMHNHMEG);
		}
		[Cpp2IlInjected.Token(Token = "0x6000414")]
		[Cpp2IlInjected.Address(RVA = "0x762EE0", Offset = "0x761CE0", VA = "0x180762EE0", Slot = "49")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000118")]
	public bool EAAEJMCMHOM
	{
		[Cpp2IlInjected.Token(Token = "0x6000415")]
		[Cpp2IlInjected.Address(RVA = "0x10C26A0", Offset = "0x10C14A0", VA = "0x1810C26A0", Slot = "50")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000119")]
	public Transform PHLFANIJOKI
	{
		[Cpp2IlInjected.Token(Token = "0x6000416")]
		[Cpp2IlInjected.Address(RVA = "0x83E3C0", Offset = "0x83D1C0", VA = "0x18083E3C0", Slot = "51")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700011A")]
	public Vector3 COKHGDLHIBE
	{
		[Cpp2IlInjected.Token(Token = "0x6000417")]
		[Cpp2IlInjected.Address(RVA = "0xA36730", Offset = "0xA35530", VA = "0x180A36730", Slot = "52")]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x6000418")]
		[Cpp2IlInjected.Address(RVA = "0x762EE0", Offset = "0x761CE0", VA = "0x180762EE0", Slot = "53")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700011B")]
	public float OFMEOPGKNHB
	{
		[Cpp2IlInjected.Token(Token = "0x6000419")]
		[Cpp2IlInjected.Address(RVA = "0x7B6040", Offset = "0x7B4E40", VA = "0x1807B6040", Slot = "54")]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x600041A")]
		[Cpp2IlInjected.Address(RVA = "0x762EE0", Offset = "0x761CE0", VA = "0x180762EE0", Slot = "55")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700011C")]
	public float ODAENDJNKNL
	{
		[Cpp2IlInjected.Token(Token = "0x600041B")]
		[Cpp2IlInjected.Address(RVA = "0x7B6040", Offset = "0x7B4E40", VA = "0x1807B6040", Slot = "56")]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x600041C")]
		[Cpp2IlInjected.Address(RVA = "0x762EE0", Offset = "0x761CE0", VA = "0x180762EE0", Slot = "57")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700011D")]
	public Quaternion DHOHNGCOPAD
	{
		[Cpp2IlInjected.Token(Token = "0x600041D")]
		[Cpp2IlInjected.Address(RVA = "0x8A2830", Offset = "0x8A1630", VA = "0x1808A2830", Slot = "58")]
		get
		{
			return default(Quaternion);
		}
		[Cpp2IlInjected.Token(Token = "0x600041E")]
		[Cpp2IlInjected.Address(RVA = "0x762EE0", Offset = "0x761CE0", VA = "0x180762EE0", Slot = "59")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700011E")]
	public Vector3 IINMIFPFDIC
	{
		[Cpp2IlInjected.Token(Token = "0x600041F")]
		[Cpp2IlInjected.Address(RVA = "0xA36730", Offset = "0xA35530", VA = "0x180A36730", Slot = "60")]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x6000420")]
		[Cpp2IlInjected.Address(RVA = "0x762EE0", Offset = "0x761CE0", VA = "0x180762EE0", Slot = "61")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700011F")]
	public Quaternion KEJKODFGKBE
	{
		[Cpp2IlInjected.Token(Token = "0x6000421")]
		[Cpp2IlInjected.Address(RVA = "0x8A2830", Offset = "0x8A1630", VA = "0x1808A2830", Slot = "62")]
		get
		{
			return default(Quaternion);
		}
		[Cpp2IlInjected.Token(Token = "0x6000422")]
		[Cpp2IlInjected.Address(RVA = "0x762EE0", Offset = "0x761CE0", VA = "0x180762EE0", Slot = "63")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000120")]
	public RigidbodyConstraints BNDMKIOPOHA
	{
		[Cpp2IlInjected.Token(Token = "0x6000423")]
		[Cpp2IlInjected.Address(RVA = "0x762EF0", Offset = "0x761CF0", VA = "0x180762EF0", Slot = "64")]
		get
		{
			return default(RigidbodyConstraints);
		}
		[Cpp2IlInjected.Token(Token = "0x6000424")]
		[Cpp2IlInjected.Address(RVA = "0x762EE0", Offset = "0x761CE0", VA = "0x180762EE0", Slot = "65")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000121")]
	public bool KNJAHLAHOMB
	{
		[Cpp2IlInjected.Token(Token = "0x6000425")]
		[Cpp2IlInjected.Address(RVA = "0x7AC370", Offset = "0x7AB170", VA = "0x1807AC370", Slot = "66")]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000426")]
		[Cpp2IlInjected.Address(RVA = "0x762EE0", Offset = "0x761CE0", VA = "0x180762EE0", Slot = "67")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000122")]
	public CollisionDetectionMode DGLKEBEJHFH
	{
		[Cpp2IlInjected.Token(Token = "0x6000427")]
		[Cpp2IlInjected.Address(RVA = "0x762EF0", Offset = "0x761CF0", VA = "0x180762EF0", Slot = "68")]
		get
		{
			return default(CollisionDetectionMode);
		}
		[Cpp2IlInjected.Token(Token = "0x6000428")]
		[Cpp2IlInjected.Address(RVA = "0x762EE0", Offset = "0x761CE0", VA = "0x180762EE0", Slot = "69")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000123")]
	public bool DFDBDNANPGP
	{
		[Cpp2IlInjected.Token(Token = "0x6000429")]
		[Cpp2IlInjected.Address(RVA = "0x19F5050", Offset = "0x19F3E50", VA = "0x1819F5050", Slot = "70")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000038")]
	public event HJACFJGDJJO HODIMEMGCKN
	{
		[Cpp2IlInjected.Token(Token = "0x60003D5")]
		[Cpp2IlInjected.Address(RVA = "0x762EE0", Offset = "0x761CE0", VA = "0x180762EE0", Slot = "75")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60003D6")]
		[Cpp2IlInjected.Address(RVA = "0x762EE0", Offset = "0x761CE0", VA = "0x180762EE0", Slot = "76")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000039")]
	public event HJACFJGDJJO JOCICHKGDGM
	{
		[Cpp2IlInjected.Token(Token = "0x60003D7")]
		[Cpp2IlInjected.Address(RVA = "0x762EE0", Offset = "0x761CE0", VA = "0x180762EE0", Slot = "77")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60003D8")]
		[Cpp2IlInjected.Address(RVA = "0x762EE0", Offset = "0x761CE0", VA = "0x180762EE0", Slot = "78")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400003A")]
	public event IFKDBGJBMPP PJPLFEDKAAM
	{
		[Cpp2IlInjected.Token(Token = "0x60003D9")]
		[Cpp2IlInjected.Address(RVA = "0x762EE0", Offset = "0x761CE0", VA = "0x180762EE0", Slot = "79")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60003DA")]
		[Cpp2IlInjected.Address(RVA = "0x762EE0", Offset = "0x761CE0", VA = "0x180762EE0", Slot = "80")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400003B")]
	public event HJACFJGDJJO AJIMHCJENHI
	{
		[Cpp2IlInjected.Token(Token = "0x60003DB")]
		[Cpp2IlInjected.Address(RVA = "0x762EE0", Offset = "0x761CE0", VA = "0x180762EE0", Slot = "82")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60003DC")]
		[Cpp2IlInjected.Address(RVA = "0x762EE0", Offset = "0x761CE0", VA = "0x180762EE0", Slot = "83")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400003C")]
	public event HJACFJGDJJO ODNGMOBPALO
	{
		[Cpp2IlInjected.Token(Token = "0x60003DD")]
		[Cpp2IlInjected.Address(RVA = "0x762EE0", Offset = "0x761CE0", VA = "0x180762EE0", Slot = "102")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60003DE")]
		[Cpp2IlInjected.Address(RVA = "0x762EE0", Offset = "0x761CE0", VA = "0x180762EE0", Slot = "103")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400003D")]
	public event HJACFJGDJJO FPONCMMAGCA
	{
		[Cpp2IlInjected.Token(Token = "0x60003DF")]
		[Cpp2IlInjected.Address(RVA = "0x762EE0", Offset = "0x761CE0", VA = "0x180762EE0", Slot = "107")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60003E0")]
		[Cpp2IlInjected.Address(RVA = "0x762EE0", Offset = "0x761CE0", VA = "0x180762EE0", Slot = "108")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400003E")]
	public event Action<KFCLLDKJIGN, KFCLLDKJIGN> NIPMFJHHIKK
	{
		[Cpp2IlInjected.Token(Token = "0x60003E1")]
		[Cpp2IlInjected.Address(RVA = "0x762EE0", Offset = "0x761CE0", VA = "0x180762EE0", Slot = "111")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60003E2")]
		[Cpp2IlInjected.Address(RVA = "0x762EE0", Offset = "0x761CE0", VA = "0x180762EE0", Slot = "112")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400003F")]
	public event HJACFJGDJJO AIKMIOLKDDL
	{
		[Cpp2IlInjected.Token(Token = "0x60003E3")]
		[Cpp2IlInjected.Address(RVA = "0x762EE0", Offset = "0x761CE0", VA = "0x180762EE0", Slot = "113")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60003E4")]
		[Cpp2IlInjected.Address(RVA = "0x762EE0", Offset = "0x761CE0", VA = "0x180762EE0", Slot = "114")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000040")]
	public event HJACFJGDJJO EDNEIGNLNHG
	{
		[Cpp2IlInjected.Token(Token = "0x60003E5")]
		[Cpp2IlInjected.Address(RVA = "0x762EE0", Offset = "0x761CE0", VA = "0x180762EE0", Slot = "119")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60003E6")]
		[Cpp2IlInjected.Address(RVA = "0x762EE0", Offset = "0x761CE0", VA = "0x180762EE0", Slot = "120")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600040C")]
	[Cpp2IlInjected.Address(RVA = "0x762EE0", Offset = "0x761CE0", VA = "0x180762EE0", Slot = "41")]
	public void EGGEMACIFEN((Quaternion rot, Vector3 moments) IGICCOJIDDA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600042A")]
	[Cpp2IlInjected.Address(RVA = "0x762EE0", Offset = "0x761CE0", VA = "0x180762EE0", Slot = "71")]
	public void EKBEIHECLAM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600042B")]
	[Cpp2IlInjected.Address(RVA = "0x762EE0", Offset = "0x761CE0", VA = "0x180762EE0", Slot = "72")]
	public void DPKGHMKJIKO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600042C")]
	[Cpp2IlInjected.Address(RVA = "0x762EE0", Offset = "0x761CE0", VA = "0x180762EE0", Slot = "73")]
	public void GIMKODEGOKH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600042D")]
	[Cpp2IlInjected.Address(RVA = "0x762EE0", Offset = "0x761CE0", VA = "0x180762EE0", Slot = "74")]
	public void JBPIAAMLKCO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600042E")]
	[Cpp2IlInjected.Address(RVA = "0x762EE0", Offset = "0x761CE0", VA = "0x180762EE0", Slot = "134")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600042F")]
	[Cpp2IlInjected.Address(RVA = "0x762EE0", Offset = "0x761CE0", VA = "0x180762EE0", Slot = "81")]
	public void HDGBCFAMPCN(HKDDEEJINEH GNLEHBFFNFG, bool LHLPPJCBNEM = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000430")]
	[Cpp2IlInjected.Address(RVA = "0x762EE0", Offset = "0x761CE0", VA = "0x180762EE0", Slot = "84")]
	public void HFENMPHFOKA(object PFKLELGAJPH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000431")]
	[Cpp2IlInjected.Address(RVA = "0x762EE0", Offset = "0x761CE0", VA = "0x180762EE0", Slot = "85")]
	public void INLGLFPHKKN(object PFKLELGAJPH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000432")]
	[Cpp2IlInjected.Address(RVA = "0xA36730", Offset = "0xA35530", VA = "0x180A36730", Slot = "86")]
	public Vector3 ILHPDEBIDPO(Vector3 FCKPHPBMNBE)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000433")]
	[Cpp2IlInjected.Address(RVA = "0xA36730", Offset = "0xA35530", VA = "0x180A36730", Slot = "87")]
	public Vector3 KFOJABECPNA(Vector3 CBFMJBCAHHF)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000434")]
	[Cpp2IlInjected.Address(RVA = "0x762EE0", Offset = "0x761CE0", VA = "0x180762EE0", Slot = "88")]
	public void ALNKOFBADLM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000435")]
	[Cpp2IlInjected.Address(RVA = "0x762EE0", Offset = "0x761CE0", VA = "0x180762EE0", Slot = "89")]
	public void ODLAHMAHHIG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000436")]
	[Cpp2IlInjected.Address(RVA = "0x762EE0", Offset = "0x761CE0", VA = "0x180762EE0", Slot = "90")]
	public void OMPFMFEHIPL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000437")]
	[Cpp2IlInjected.Address(RVA = "0x762EE0", Offset = "0x761CE0", VA = "0x180762EE0", Slot = "91")]
	public void COIPDHOKFEA(Vector3 LCEEOGHIEAE, Vector3 CMCJGKKIFGK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000438")]
	[Cpp2IlInjected.Address(RVA = "0x762EE0", Offset = "0x761CE0", VA = "0x180762EE0", Slot = "92")]
	public void KCHGHBEHDOP(Vector3 NNHCKKDHDOO, Vector3 MKPDHJELIJH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000439")]
	[Cpp2IlInjected.Address(RVA = "0x762EE0", Offset = "0x761CE0", VA = "0x180762EE0", Slot = "93")]
	public void FEGGONCBCAB(Vector3 MBCLMEKNIMH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600043A")]
	[Cpp2IlInjected.Address(RVA = "0x762EE0", Offset = "0x761CE0", VA = "0x180762EE0", Slot = "94")]
	public void JJLPMJIAECP(CAJLMHPONNG ODONFGMOICG, Vector3 EBGKJLMCJAI, float EMBPADILADB, float ICDNFDHOPEF = 8f, float PKMFLEJBFBB = 1f)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600043B")]
	[Cpp2IlInjected.Address(RVA = "0x762EE0", Offset = "0x761CE0", VA = "0x180762EE0", Slot = "95")]
	public void IGMBNACPLCP(BPMLBDGOAAA KPBLKDJONKA, Vector3 KHAGNCFGGLP, float DGAGPLDFBFA = float.PositiveInfinity)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600043C")]
	[Cpp2IlInjected.Address(RVA = "0x762EE0", Offset = "0x761CE0", VA = "0x180762EE0", Slot = "96")]
	public void CPOAAEBFFIL(BPMLBDGOAAA KPBLKDJONKA, Vector3 GIBIBDOGOLL, float MLEKCJEEFGK = 7f, float JGPJAKHDFMM = 1f)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600043D")]
	[Cpp2IlInjected.Address(RVA = "0xA36730", Offset = "0xA35530", VA = "0x180A36730", Slot = "97")]
	public Vector3 KOMLCDOJFGP(Vector3 GNLEHBFFNFG)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x600043E")]
	[Cpp2IlInjected.Address(RVA = "0xA36730", Offset = "0xA35530", VA = "0x180A36730", Slot = "98")]
	public Vector3 HPPNGLOONCP(Vector3 GNLEHBFFNFG)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x600043F")]
	[Cpp2IlInjected.Address(RVA = "0x762EE0", Offset = "0x761CE0", VA = "0x180762EE0", Slot = "99")]
	public void BMNABPGBMMB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000440")]
	[Cpp2IlInjected.Address(RVA = "0x762EE0", Offset = "0x761CE0", VA = "0x180762EE0", Slot = "100")]
	public void HHEHDIAENMJ(HKDDEEJINEH CIBBEIAHJJB, object PFKLELGAJPH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000441")]
	[Cpp2IlInjected.Address(RVA = "0x762EE0", Offset = "0x761CE0", VA = "0x180762EE0", Slot = "101")]
	public void NDAFIEKOHMG(object PFKLELGAJPH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000442")]
	[Cpp2IlInjected.Address(RVA = "0x762EE0", Offset = "0x761CE0", VA = "0x180762EE0", Slot = "104")]
	public void IBKBPPNCAPO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000443")]
	[Cpp2IlInjected.Address(RVA = "0x762EE0", Offset = "0x761CE0", VA = "0x180762EE0", Slot = "105")]
	public void NDMOMLBEAEJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000444")]
	[Cpp2IlInjected.Address(RVA = "0x762EE0", Offset = "0x761CE0", VA = "0x180762EE0", Slot = "106")]
	public void AHJPIEKBAGK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000445")]
	[Cpp2IlInjected.Address(RVA = "0x7AC370", Offset = "0x7AB170", VA = "0x1807AC370", Slot = "109")]
	public bool LOELNNODNDF()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000446")]
	[Cpp2IlInjected.Address(RVA = "0x762EE0", Offset = "0x761CE0", VA = "0x180762EE0", Slot = "110")]
	public void NMDENCFDKJJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000447")]
	[Cpp2IlInjected.Address(RVA = "0x762EF0", Offset = "0x761CF0", VA = "0x180762EF0", Slot = "115")]
	public IDisposable NJGCPDMJAEB()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000448")]
	[Cpp2IlInjected.Address(RVA = "0x762EE0", Offset = "0x761CE0", VA = "0x180762EE0", Slot = "116")]
	public void GHPBAHFCNAI(object PFKLELGAJPH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000449")]
	[Cpp2IlInjected.Address(RVA = "0x762EE0", Offset = "0x761CE0", VA = "0x180762EE0", Slot = "117")]
	public void KEANJAENHKI(object PFKLELGAJPH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600044A")]
	[Cpp2IlInjected.Address(RVA = "0x762EE0", Offset = "0x761CE0", VA = "0x180762EE0", Slot = "118")]
	public void JKGNPHGDHEP(object PFKLELGAJPH, bool JJIMCKPIKFL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600044B")]
	[Cpp2IlInjected.Address(RVA = "0x762EE0", Offset = "0x761CE0", VA = "0x180762EE0", Slot = "121")]
	public void LOJHDBLLLPK(Vector3 KMDPKMLFOLC, Quaternion KGOHNEKGJFD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600044C")]
	[Cpp2IlInjected.Address(RVA = "0x762EE0", Offset = "0x761CE0", VA = "0x180762EE0", Slot = "122")]
	public void MMCFACKGGID(Vector3 IAOBMGELIKG, Quaternion BIOBPMHCIFO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600044D")]
	[Cpp2IlInjected.Address(RVA = "0x7AC370", Offset = "0x7AB170", VA = "0x1807AC370", Slot = "123")]
	public bool HBFAJFCHBIE(float OFPMODDPBDG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600044E")]
	[Cpp2IlInjected.Address(RVA = "0x762EE0", Offset = "0x761CE0", VA = "0x180762EE0", Slot = "124")]
	public void EHBMDIMOOPP(object PFKLELGAJPH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600044F")]
	[Cpp2IlInjected.Address(RVA = "0x762EE0", Offset = "0x761CE0", VA = "0x180762EE0", Slot = "125")]
	public void EOMADFNHNCE(object PFKLELGAJPH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000450")]
	[Cpp2IlInjected.Address(RVA = "0x762EE0", Offset = "0x761CE0", VA = "0x180762EE0", Slot = "126")]
	public void OJJAOMJIFMM(object PFKLELGAJPH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000451")]
	[Cpp2IlInjected.Address(RVA = "0x762EE0", Offset = "0x761CE0", VA = "0x180762EE0", Slot = "127")]
	public void IIIGLEPLPKA(object PFKLELGAJPH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000452")]
	[Cpp2IlInjected.Address(RVA = "0x762EE0", Offset = "0x761CE0", VA = "0x180762EE0", Slot = "128")]
	public void JLFMLIEHAJM(Vector3 PJCPHDDKADF, ForceMode BKPMKNNGNCO = ForceMode.Force)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000453")]
	[Cpp2IlInjected.Address(RVA = "0x762EE0", Offset = "0x761CE0", VA = "0x180762EE0", Slot = "129")]
	public void GELIKGECCKO(Vector3 PJCPHDDKADF, Vector3 AILFIIEAPKM, ForceMode BKPMKNNGNCO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000454")]
	[Cpp2IlInjected.Address(RVA = "0x762EE0", Offset = "0x761CE0", VA = "0x180762EE0", Slot = "130")]
	public void LCIDAFFKJGM(Vector3 KNJIDLKEAOF, ForceMode BKPMKNNGNCO = ForceMode.Force)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000455")]
	[Cpp2IlInjected.Address(RVA = "0x762EE0", Offset = "0x761CE0", VA = "0x180762EE0", Slot = "131")]
	public void FFJJOMMAHGJ(Vector3 KNJIDLKEAOF, ForceMode BKPMKNNGNCO = ForceMode.Force)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000456")]
	[Cpp2IlInjected.Address(RVA = "0x6223200", Offset = "0x6222000", VA = "0x186223200", Slot = "132")]
	public bool IMCFKJILCKH(Vector3 IELHLOGPMDL, [Out] RaycastHit PEGDGELCHOI, float NGLNDDJFMFL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000457")]
	[Cpp2IlInjected.Address(RVA = "0x762EE0", Offset = "0x761CE0", VA = "0x180762EE0", Slot = "133")]
	public void GCBLHPDNFDB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000458")]
	[Cpp2IlInjected.Address(RVA = "0x76E9D0", Offset = "0x76D7D0", VA = "0x18076E9D0")]
	public KEIKGPFNPDH()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000043")]
public sealed class HDEONHFPAIJ : KOAFFLFFEOP, HDDDKCEGLNC, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
	[Cpp2IlInjected.Token(Token = "0x4000075")]
	internal JBMJEBCFLLB HAIBOLAMIBL;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
	[Cpp2IlInjected.Token(Token = "0x4000076")]
	internal BGJEPDMMNIC DFOKKMPIKGD;

	[Cpp2IlInjected.Token(Token = "0x600045A")]
	[Cpp2IlInjected.Address(RVA = "0x6216BC0", Offset = "0x62159C0", VA = "0x186216BC0")]
	public HDEONHFPAIJ(GameObject DEGGPBGPMDB, RigidbodyEx BJEOFBIDHLD, JLBIHFBBGKJ OHOLEEOLBDH, [In] POAMDCEFDPK PFDMLBFKIAP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600045B")]
	[Cpp2IlInjected.Address(RVA = "0x62167C0", Offset = "0x62155C0", VA = "0x1862167C0", Slot = "135")]
	protected override void IODPBGHLKMM(JLBIHFBBGKJ OHOLEEOLBDH, POAMDCEFDPK PFDMLBFKIAP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600045C")]
	[Cpp2IlInjected.Address(RVA = "0x762EF0", Offset = "0x761CF0", VA = "0x180762EF0", Slot = "141")]
	protected override IDisposable BDFINDDDMKC()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600045D")]
	[Cpp2IlInjected.Address(RVA = "0x6216230", Offset = "0x6215030", VA = "0x186216230", Slot = "136")]
	public override void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600045E")]
	[Cpp2IlInjected.Address(RVA = "0x6216460", Offset = "0x6215260", VA = "0x186216460", Slot = "142")]
	public void HDKLHBOLFFL(IBCCCJOGKLP BOAPNJKEFEG, IBCCCJOGKLP INJCFLAHPML)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600045F")]
	[Cpp2IlInjected.Address(RVA = "0x6216170", Offset = "0x6214F70", VA = "0x186216170", Slot = "143")]
	public void DCCEABODPJG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000460")]
	[Cpp2IlInjected.Address(RVA = "0x62163A0", Offset = "0x62151A0", VA = "0x1862163A0", Slot = "144")]
	public void FCGIDAAGDMA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000461")]
	[Cpp2IlInjected.Address(RVA = "0x6216530", Offset = "0x6215330", VA = "0x186216530", Slot = "145")]
	public void HMMDNFNCIPM(bool IMPHHDIGJPJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000462")]
	[Cpp2IlInjected.Address(RVA = "0x6216A30", Offset = "0x6215830", VA = "0x186216A30", Slot = "146")]
	public bool JGEPINIMDCB()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000463")]
	[Cpp2IlInjected.Address(RVA = "0x6216110", Offset = "0x6214F10", VA = "0x186216110", Slot = "147")]
	public void AOHPGKLGNHD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000464")]
	[Cpp2IlInjected.Address(RVA = "0x762EE0", Offset = "0x761CE0", VA = "0x180762EE0", Slot = "140")]
	protected override void LPANDFCAIJN(RigidbodyEx NGDHFFBLCOO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000465")]
	[Cpp2IlInjected.Address(RVA = "0x6216590", Offset = "0x6215390", VA = "0x186216590")]
	private void ICLLMMDCOMD()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000044")]
internal static class BDOLHLBKLOB
{
	[Cpp2IlInjected.Token(Token = "0x6000466")]
	[Cpp2IlInjected.Address(RVA = "0x620A170", Offset = "0x6208F70", VA = "0x18620A170")]
	public static KOAFFLFFEOP KJLMFHBEKBG(this HKDDEEJINEH BAHHCFCHDLD)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000045")]
public interface GKCGMHCOGHL : CNJKFLKEHNP, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x6000467")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void HHIIPGJELHJ(HKDDEEJINEH HHJJKPNJLAD);

	[Cpp2IlInjected.Token(Token = "0x6000468")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void OHPPCLKLOPE(HKDDEEJINEH HHJJKPNJLAD);

	[Cpp2IlInjected.Token(Token = "0x6000469")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void EOENPANBABB(HKDDEEJINEH PBBFFPONPEK);

	[Cpp2IlInjected.Token(Token = "0x600046A")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void CADNBFAFJKH(HKDDEEJINEH PBBFFPONPEK);
}
[Cpp2IlInjected.Token(Token = "0x2000046")]
public interface BHOGMKJLION : JMDJHBDFHNM
{
	[Cpp2IlInjected.Token(Token = "0x17000124")]
	FGNJEGHKKBN<HKDDEEJINEH> HEKDGOKOJFF
	{
		[Cpp2IlInjected.Token(Token = "0x600046B")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000125")]
	HKDDEEJINEH ODIPLLPNBEL
	{
		[Cpp2IlInjected.Token(Token = "0x600046C")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000047")]
public interface GHIHEDMJFNK : FHMHFKBPFEJ
{
	[Cpp2IlInjected.Token(Token = "0x600046D")]
	[Cpp2IlInjected.Address(Slot = "0")]
	(float, Vector3) PNBEMPHMPJN(Rigidbody OIADHONCLLD);
}
[Cpp2IlInjected.Token(Token = "0x2000048")]
public interface BIJHLAPAAIE : IHPGPDPIGPG, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x17000126")]
	PhotonView KLJNPJGIJOE
	{
		[Cpp2IlInjected.Token(Token = "0x600046E")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000049")]
internal sealed class PGMBEKJPLPP : DOLMCKAIMMH
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000077")]
	private readonly KOAFFLFFEOP HHJJKPNJLAD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000078")]
	private CollisionDetectionMode OHIPEMGHIOA;

	[Cpp2IlInjected.Token(Token = "0x17000127")]
	private Rigidbody PEOFAJLGEEJ
	{
		[Cpp2IlInjected.Token(Token = "0x600046F")]
		[Cpp2IlInjected.Address(RVA = "0x6209C00", Offset = "0x6208A00", VA = "0x186209C00")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000128")]
	public CollisionDetectionMode DGLKEBEJHFH
	{
		[Cpp2IlInjected.Token(Token = "0x6000473")]
		[Cpp2IlInjected.Address(RVA = "0x622E260", Offset = "0x622D060", VA = "0x18622E260", Slot = "4")]
		get
		{
			return default(CollisionDetectionMode);
		}
		[Cpp2IlInjected.Token(Token = "0x6000474")]
		[Cpp2IlInjected.Address(RVA = "0x622E380", Offset = "0x622D180", VA = "0x18622E380", Slot = "5")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000470")]
	[Cpp2IlInjected.Address(RVA = "0x620D7E0", Offset = "0x620C5E0", VA = "0x18620D7E0")]
	public PGMBEKJPLPP(HKDDEEJINEH HHJJKPNJLAD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000471")]
	[Cpp2IlInjected.Address(RVA = "0x622DFE0", Offset = "0x622CDE0", VA = "0x18622DFE0", Slot = "6")]
	public void EKBEIHECLAM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000472")]
	[Cpp2IlInjected.Address(RVA = "0x622DE40", Offset = "0x622CC40", VA = "0x18622DE40", Slot = "9")]
	public void AKOMFNGCOKL(Rigidbody OPIJOIJPNML)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000475")]
	[Cpp2IlInjected.Address(RVA = "0x622E370", Offset = "0x622D170", VA = "0x18622E370", Slot = "7")]
	public void KFHFNMGPAPA(bool KPFPDIPJHJC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000476")]
	[Cpp2IlInjected.Address(RVA = "0x622E0F0", Offset = "0x622CEF0", VA = "0x18622E0F0", Slot = "8")]
	public void IAGFKMCIEPM(bool KPFPDIPJHJC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000477")]
	[Cpp2IlInjected.Address(RVA = "0x622E100", Offset = "0x622CF00", VA = "0x18622E100", Slot = "10")]
	public bool IMCFKJILCKH(Vector3 IELHLOGPMDL, [Out] RaycastHit PEGDGELCHOI, float NGLNDDJFMFL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000478")]
	[Cpp2IlInjected.Address(RVA = "0x622DEC0", Offset = "0x622CCC0", VA = "0x18622DEC0")]
	private void DPMNFNOOLOO(bool KPFPDIPJHJC)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200004A")]
public sealed class DFEGNEALCNO : IBDFGCOAOJH, IDisposable, ENGGMMDIFLJ
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400007A")]
	private readonly KOAFFLFFEOP HHJJKPNJLAD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400007B")]
	private EPMFMHNHMEG LAGKGDCGECP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400007C")]
	private PKLEFBNKEMB DNGIBJFBPLM;

	[Cpp2IlInjected.Token(Token = "0x17000129")]
	public EPMFMHNHMEG PKEADPGLIAA
	{
		[Cpp2IlInjected.Token(Token = "0x600047B")]
		[Cpp2IlInjected.Address(RVA = "0x620F070", Offset = "0x620DE70", VA = "0x18620F070", Slot = "6")]
		get
		{
			return default(EPMFMHNHMEG);
		}
		[Cpp2IlInjected.Token(Token = "0x600047C")]
		[Cpp2IlInjected.Address(RVA = "0x620EEF0", Offset = "0x620DCF0", VA = "0x18620EEF0", Slot = "7")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700012A")]
	private Transform KELPLPKKPLG
	{
		[Cpp2IlInjected.Token(Token = "0x600047D")]
		[Cpp2IlInjected.Address(RVA = "0x620EED0", Offset = "0x620DCD0", VA = "0x18620EED0", Slot = "10")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000041")]
	public event Action<KFCLLDKJIGN, KFCLLDKJIGN> NIPMFJHHIKK
	{
		[Cpp2IlInjected.Token(Token = "0x6000479")]
		[Cpp2IlInjected.Address(RVA = "0x620EFC0", Offset = "0x620DDC0", VA = "0x18620EFC0", Slot = "4")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600047A")]
		[Cpp2IlInjected.Address(RVA = "0x620EAD0", Offset = "0x620D8D0", VA = "0x18620EAD0", Slot = "5")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600047E")]
	[Cpp2IlInjected.Address(RVA = "0x620F1C0", Offset = "0x620DFC0", VA = "0x18620F1C0")]
	public DFEGNEALCNO(HKDDEEJINEH HHJJKPNJLAD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600047F")]
	[Cpp2IlInjected.Address(RVA = "0x620EBD0", Offset = "0x620D9D0", VA = "0x18620EBD0", Slot = "8")]
	public void EKBEIHECLAM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000480")]
	[Cpp2IlInjected.Address(RVA = "0x620EB80", Offset = "0x620D980", VA = "0x18620EB80", Slot = "9")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000481")]
	[Cpp2IlInjected.Address(RVA = "0x1A36810", Offset = "0x1A35610", VA = "0x181A36810", Slot = "11")]
	private void BIPOMOIDHKA(KFCLLDKJIGN JGIAMHBKIBA, KFCLLDKJIGN AFKIDGEHLLD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000482")]
	[Cpp2IlInjected.Address(RVA = "0x762EE0", Offset = "0x761CE0", VA = "0x180762EE0", Slot = "12")]
	private void MCIIBNABHIG(bool FMEPODNLOHF)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200004B")]
internal sealed class DEDGCMCPDNH : AEDPOFGENJL
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400007D")]
	private readonly KOAFFLFFEOP HHJJKPNJLAD;

	[Cpp2IlInjected.Token(Token = "0x1700012B")]
	private Rigidbody PEOFAJLGEEJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000483")]
		[Cpp2IlInjected.Address(RVA = "0x6209C00", Offset = "0x6208A00", VA = "0x186209C00")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700012C")]
	private bool EAAEJMCMHOM
	{
		[Cpp2IlInjected.Token(Token = "0x6000484")]
		[Cpp2IlInjected.Address(RVA = "0x620EA80", Offset = "0x620D880", VA = "0x18620EA80")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700012D")]
	private bool EAILHMIAFFL
	{
		[Cpp2IlInjected.Token(Token = "0x6000485")]
		[Cpp2IlInjected.Address(RVA = "0x620E660", Offset = "0x620D460", VA = "0x18620E660")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700012E")]
	private HKDDEEJINEH ADEHKCCOJGF
	{
		[Cpp2IlInjected.Token(Token = "0x6000486")]
		[Cpp2IlInjected.Address(RVA = "0x620DD60", Offset = "0x620CB60", VA = "0x18620DD60")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000487")]
	[Cpp2IlInjected.Address(RVA = "0x620D7E0", Offset = "0x620C5E0", VA = "0x18620D7E0")]
	public DEDGCMCPDNH(HKDDEEJINEH HHJJKPNJLAD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000488")]
	[Cpp2IlInjected.Address(RVA = "0x620E500", Offset = "0x620D300", VA = "0x18620E500", Slot = "4")]
	public void JLFMLIEHAJM(Vector3 PJCPHDDKADF, ForceMode BKPMKNNGNCO = ForceMode.Force)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000489")]
	[Cpp2IlInjected.Address(RVA = "0x620E820", Offset = "0x620D620", VA = "0x18620E820")]
	private void MHJAJMIHPMG(Vector3 PJCPHDDKADF, ForceMode BKPMKNNGNCO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600048A")]
	[Cpp2IlInjected.Address(RVA = "0x620E280", Offset = "0x620D080", VA = "0x18620E280", Slot = "5")]
	public void GELIKGECCKO(Vector3 PJCPHDDKADF, Vector3 AILFIIEAPKM, ForceMode BKPMKNNGNCO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600048B")]
	[Cpp2IlInjected.Address(RVA = "0x620E6C0", Offset = "0x620D4C0", VA = "0x18620E6C0", Slot = "6")]
	public void LCIDAFFKJGM(Vector3 KNJIDLKEAOF, ForceMode BKPMKNNGNCO = ForceMode.Force)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600048C")]
	[Cpp2IlInjected.Address(RVA = "0x620E020", Offset = "0x620CE20", VA = "0x18620E020")]
	private void FHLENHJFOMG(Vector3 KNJIDLKEAOF, ForceMode BKPMKNNGNCO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600048D")]
	[Cpp2IlInjected.Address(RVA = "0x620DDC0", Offset = "0x620CBC0", VA = "0x18620DDC0", Slot = "7")]
	public void FFJJOMMAHGJ(Vector3 KNJIDLKEAOF, ForceMode BKPMKNNGNCO = ForceMode.Force)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200004C")]
internal sealed class CEOOPHBJJAL : AEAEHLIIIHM
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400007E")]
	private readonly KOAFFLFFEOP HHJJKPNJLAD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400007F")]
	private bool EAGMCFODNPB;

	[Cpp2IlInjected.Token(Token = "0x1700012F")]
	public bool KILOFHHLCIA
	{
		[Cpp2IlInjected.Token(Token = "0x600048F")]
		[Cpp2IlInjected.Address(RVA = "0x7D0BF0", Offset = "0x7CF9F0", VA = "0x1807D0BF0", Slot = "4")]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000490")]
		[Cpp2IlInjected.Address(RVA = "0x620D660", Offset = "0x620C460", VA = "0x18620D660", Slot = "5")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600048E")]
	[Cpp2IlInjected.Address(RVA = "0x620D7E0", Offset = "0x620C5E0", VA = "0x18620D7E0")]
	public CEOOPHBJJAL(HKDDEEJINEH HHJJKPNJLAD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000491")]
	[Cpp2IlInjected.Address(RVA = "0x620D630", Offset = "0x620C430", VA = "0x18620D630", Slot = "6")]
	public void AKOMFNGCOKL(Rigidbody OPIJOIJPNML)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000492")]
	[Cpp2IlInjected.Address(RVA = "0x620D770", Offset = "0x620C570", VA = "0x18620D770", Slot = "7")]
	public void IPMEDHDLDMK(Rigidbody OPIJOIJPNML)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200004D")]
internal sealed class CBEKGPIJAKA : GKCGMHCOGHL, CNJKFLKEHNP, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x4000089")]
	private readonly HKDDEEJINEH HHJJKPNJLAD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x400008A")]
	private readonly List<HKDDEEJINEH> MKILDJBBDMJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x400008B")]
	private HKDDEEJINEH JKEBPOPHOPF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x400008C")]
	private HKDDEEJINEH LBLLNFOEKNE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
	[Cpp2IlInjected.Token(Token = "0x400008D")]
	private Transform LGKDDDHGDGD;

	[Cpp2IlInjected.Token(Token = "0x17000130")]
	private Transform HFGEDEDEGAG
	{
		[Cpp2IlInjected.Token(Token = "0x60004A5")]
		[Cpp2IlInjected.Address(RVA = "0x620C240", Offset = "0x620B040", VA = "0x18620C240")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000131")]
	public HKDDEEJINEH ADEHKCCOJGF
	{
		[Cpp2IlInjected.Token(Token = "0x60004A8")]
		[Cpp2IlInjected.Address(RVA = "0x766D10", Offset = "0x765B10", VA = "0x180766D10", Slot = "28")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60004A9")]
		[Cpp2IlInjected.Address(RVA = "0x620BD00", Offset = "0x620AB00", VA = "0x18620BD00", Slot = "29")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000132")]
	public HKDDEEJINEH DKBLNPELKCO
	{
		[Cpp2IlInjected.Token(Token = "0x60004AA")]
		[Cpp2IlInjected.Address(RVA = "0x764C10", Offset = "0x763A10", VA = "0x180764C10", Slot = "27")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000133")]
	public IReadOnlyList<HKDDEEJINEH> ENBMPJKJGMM
	{
		[Cpp2IlInjected.Token(Token = "0x60004AB")]
		[Cpp2IlInjected.Address(RVA = "0x764C00", Offset = "0x763A00", VA = "0x180764C00", Slot = "26")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000042")]
	public event HJACFJGDJJO HODIMEMGCKN
	{
		[Cpp2IlInjected.Token(Token = "0x6000493")]
		[Cpp2IlInjected.Address(RVA = "0x620CF60", Offset = "0x620BD60", VA = "0x18620CF60", Slot = "8")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000494")]
		[Cpp2IlInjected.Address(RVA = "0x620B750", Offset = "0x620A550", VA = "0x18620B750", Slot = "9")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000043")]
	public event HJACFJGDJJO JOCICHKGDGM
	{
		[Cpp2IlInjected.Token(Token = "0x6000495")]
		[Cpp2IlInjected.Address(RVA = "0x620D2E0", Offset = "0x620C0E0", VA = "0x18620D2E0", Slot = "10")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000496")]
		[Cpp2IlInjected.Address(RVA = "0x620C2A0", Offset = "0x620B0A0", VA = "0x18620C2A0", Slot = "11")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000044")]
	public event IFKDBGJBMPP PJPLFEDKAAM
	{
		[Cpp2IlInjected.Token(Token = "0x6000497")]
		[Cpp2IlInjected.Address(RVA = "0x620CEC0", Offset = "0x620BCC0", VA = "0x18620CEC0", Slot = "12")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000498")]
		[Cpp2IlInjected.Address(RVA = "0x620BBC0", Offset = "0x620A9C0", VA = "0x18620BBC0", Slot = "13")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000045")]
	public event Action IHCICACDFEE
	{
		[Cpp2IlInjected.Token(Token = "0x6000499")]
		[Cpp2IlInjected.Address(RVA = "0x620D240", Offset = "0x620C040", VA = "0x18620D240", Slot = "14")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600049A")]
		[Cpp2IlInjected.Address(RVA = "0x620B8A0", Offset = "0x620A6A0", VA = "0x18620B8A0", Slot = "15")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000046")]
	public event Action EDCBGJDLIAL
	{
		[Cpp2IlInjected.Token(Token = "0x600049B")]
		[Cpp2IlInjected.Address(RVA = "0x620C1A0", Offset = "0x620AFA0", VA = "0x18620C1A0", Slot = "16")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600049C")]
		[Cpp2IlInjected.Address(RVA = "0x620CE20", Offset = "0x620BC20", VA = "0x18620CE20", Slot = "17")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000047")]
	public event Action<HKDDEEJINEH> DHPICOFBLBM
	{
		[Cpp2IlInjected.Token(Token = "0x600049D")]
		[Cpp2IlInjected.Address(RVA = "0x620B7F0", Offset = "0x620A5F0", VA = "0x18620B7F0", Slot = "18")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600049E")]
		[Cpp2IlInjected.Address(RVA = "0x620D420", Offset = "0x620C220", VA = "0x18620D420", Slot = "19")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000048")]
	public event Action<HKDDEEJINEH> LEDBDFPEEIB
	{
		[Cpp2IlInjected.Token(Token = "0x600049F")]
		[Cpp2IlInjected.Address(RVA = "0x620CCC0", Offset = "0x620BAC0", VA = "0x18620CCC0", Slot = "20")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60004A0")]
		[Cpp2IlInjected.Address(RVA = "0x620C0F0", Offset = "0x620AEF0", VA = "0x18620C0F0", Slot = "21")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000049")]
	public event Action OLLBCABGMEI
	{
		[Cpp2IlInjected.Token(Token = "0x60004A1")]
		[Cpp2IlInjected.Address(RVA = "0x620D000", Offset = "0x620BE00", VA = "0x18620D000", Slot = "22")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60004A2")]
		[Cpp2IlInjected.Address(RVA = "0x620CAE0", Offset = "0x620B8E0", VA = "0x18620CAE0", Slot = "23")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400004A")]
	public event Action<HKDDEEJINEH> HJLHOPFFEKK
	{
		[Cpp2IlInjected.Token(Token = "0x60004A3")]
		[Cpp2IlInjected.Address(RVA = "0x620D190", Offset = "0x620BF90", VA = "0x18620D190", Slot = "24")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60004A4")]
		[Cpp2IlInjected.Address(RVA = "0x620CD70", Offset = "0x620BB70", VA = "0x18620CD70", Slot = "25")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60004A6")]
	[Cpp2IlInjected.Address(RVA = "0x620D570", Offset = "0x620C370", VA = "0x18620D570")]
	public CBEKGPIJAKA(HKDDEEJINEH HHJJKPNJLAD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004A7")]
	[Cpp2IlInjected.Address(RVA = "0x620BC60", Offset = "0x620AA60", VA = "0x18620BC60", Slot = "31")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004AC")]
	[Cpp2IlInjected.Address(RVA = "0x620C340", Offset = "0x620B140", VA = "0x18620C340", Slot = "30")]
	public void HDGBCFAMPCN(HKDDEEJINEH KBFMMMPNLKE, bool LHLPPJCBNEM = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004AD")]
	[Cpp2IlInjected.Address(RVA = "0x620BD10", Offset = "0x620AB10", VA = "0x18620BD10", Slot = "6")]
	public void EOENPANBABB(HKDDEEJINEH PBBFFPONPEK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004AE")]
	[Cpp2IlInjected.Address(RVA = "0x620B940", Offset = "0x620A740", VA = "0x18620B940", Slot = "7")]
	public void CADNBFAFJKH(HKDDEEJINEH PBBFFPONPEK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004AF")]
	[Cpp2IlInjected.Address(RVA = "0x620C8C0", Offset = "0x620B6C0", VA = "0x18620C8C0", Slot = "4")]
	public void HHIIPGJELHJ(HKDDEEJINEH HHJJKPNJLAD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004B0")]
	[Cpp2IlInjected.Address(RVA = "0x620D380", Offset = "0x620C180", VA = "0x18620D380", Slot = "5")]
	public void OHPPCLKLOPE(HKDDEEJINEH HHJJKPNJLAD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004B1")]
	[Cpp2IlInjected.Address(RVA = "0x620D4D0", Offset = "0x620C2D0", VA = "0x18620D4D0")]
	private void PDEBMBIENDP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004B2")]
	[Cpp2IlInjected.Address(RVA = "0x620BF80", Offset = "0x620AD80", VA = "0x18620BF80")]
	private void EPBCEIHCGLA(HKDDEEJINEH PBBFFPONPEK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004B3")]
	[Cpp2IlInjected.Address(RVA = "0x620CB80", Offset = "0x620B980", VA = "0x18620CB80")]
	private void JECDKMKJFNJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004B4")]
	[Cpp2IlInjected.Address(RVA = "0x620C9B0", Offset = "0x620B7B0", VA = "0x18620C9B0")]
	private void HIPGIHJLHLJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004B5")]
	[Cpp2IlInjected.Address(RVA = "0x620BFC0", Offset = "0x620ADC0", VA = "0x18620BFC0")]
	private void FIOBAHJAHMK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004B6")]
	[Cpp2IlInjected.Address(RVA = "0x620D0A0", Offset = "0x620BEA0", VA = "0x18620D0A0")]
	[CompilerGenerated]
	private object NOIOEFHCMKE()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200004E")]
internal static class OBBKNEKPCML
{
	[Cpp2IlInjected.Token(Token = "0x60004B7")]
	[Cpp2IlInjected.Address(RVA = "0x622D8D0", Offset = "0x622C6D0", VA = "0x18622D8D0")]
	public static GKCGMHCOGHL CBJKAFKIJMH(this HKDDEEJINEH BAHHCFCHDLD)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200004F")]
internal sealed class KBANAJAPNFA : BHOGMKJLION, JMDJHBDFHNM
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400008E")]
	private readonly KOAFFLFFEOP HHJJKPNJLAD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400008F")]
	private readonly FGNJEGHKKBN<HKDDEEJINEH> BFOABHEOFDC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000090")]
	private bool LKCNLLOEHJN;

	[Cpp2IlInjected.Token(Token = "0x17000134")]
	public FGNJEGHKKBN<HKDDEEJINEH> HEKDGOKOJFF
	{
		[Cpp2IlInjected.Token(Token = "0x60004B8")]
		[Cpp2IlInjected.Address(RVA = "0x761640", Offset = "0x760440", VA = "0x180761640", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000135")]
	public Vector3 JFADEILIBMM
	{
		[Cpp2IlInjected.Token(Token = "0x60004B9")]
		[Cpp2IlInjected.Address(RVA = "0x6222D00", Offset = "0x6221B00", VA = "0x186222D00", Slot = "6")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000136")]
	public Vector3 OFPFJJDNLBD
	{
		[Cpp2IlInjected.Token(Token = "0x60004BA")]
		[Cpp2IlInjected.Address(RVA = "0x62225B0", Offset = "0x62213B0", VA = "0x1862225B0", Slot = "7")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000137")]
	private Vector3 EGDFHNKFGGC
	{
		[Cpp2IlInjected.Token(Token = "0x60004BE")]
		[Cpp2IlInjected.Address(RVA = "0x6222770", Offset = "0x6221570", VA = "0x186222770")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000138")]
	public HKDDEEJINEH ODIPLLPNBEL
	{
		[Cpp2IlInjected.Token(Token = "0x60004BF")]
		[Cpp2IlInjected.Address(RVA = "0x6222860", Offset = "0x6221660", VA = "0x186222860", Slot = "5")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60004BB")]
	[Cpp2IlInjected.Address(RVA = "0x62230C0", Offset = "0x6221EC0", VA = "0x1862230C0")]
	public KBANAJAPNFA(HKDDEEJINEH HHJJKPNJLAD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004BC")]
	[Cpp2IlInjected.Address(RVA = "0x6222540", Offset = "0x6221340", VA = "0x186222540", Slot = "8")]
	public void AOOHAJPAHFH(HKDDEEJINEH LBLLNFOEKNE, object PFKLELGAJPH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004BD")]
	[Cpp2IlInjected.Address(RVA = "0x6222CA0", Offset = "0x6221AA0", VA = "0x186222CA0", Slot = "9")]
	public void MFOJFIKNOFA(object PFKLELGAJPH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004C0")]
	[Cpp2IlInjected.Address(RVA = "0x6222D30", Offset = "0x6221B30", VA = "0x186222D30")]
	private Vector3 PLHIGNPEECD()
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x60004C1")]
	[Cpp2IlInjected.Address(RVA = "0x6222910", Offset = "0x6221710", VA = "0x186222910")]
	private void MBHJLDGMFKO(HKDDEEJINEH KGPEKHAMMOH)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000050")]
internal static class PFAJLLDOHGG
{
	[Cpp2IlInjected.Token(Token = "0x60004C2")]
	[Cpp2IlInjected.Address(RVA = "0x622DD80", Offset = "0x622CB80", VA = "0x18622DD80")]
	public static BHOGMKJLION HIKIIOLJMIG(this HKDDEEJINEH BAHHCFCHDLD)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000051")]
internal sealed class NFNNGKAGHAL : GHIHEDMJFNK, FHMHFKBPFEJ
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000092")]
	private readonly KOAFFLFFEOP HHJJKPNJLAD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000093")]
	private readonly OverridableVector3 AAAIDNKIFIJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000094")]
	private readonly OverridableVector3 HLGDJAEDJBM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000095")]
	private float KPCNHEKAOOJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x44")]
	[Cpp2IlInjected.Token(Token = "0x4000096")]
	private float ACPGGACNAPA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000097")]
	private Vector3 DDINHCGCHDG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x54")]
	[Cpp2IlInjected.Token(Token = "0x4000098")]
	private Vector3? FGJGGNHCPKD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x64")]
	[Cpp2IlInjected.Token(Token = "0x4000099")]
	private Quaternion? KJMFENHAPNA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
	[Cpp2IlInjected.Token(Token = "0x400009A")]
	private bool DLKHFEIEKPI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x79")]
	[Cpp2IlInjected.Token(Token = "0x400009B")]
	private bool EEGKAABDCLL;

	[Cpp2IlInjected.Token(Token = "0x17000139")]
	public Vector3 LAGIIOINLDG
	{
		[Cpp2IlInjected.Token(Token = "0x60004C5")]
		[Cpp2IlInjected.Address(RVA = "0xF629B0", Offset = "0xF617B0", VA = "0x180F629B0", Slot = "7")]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x60004C6")]
		[Cpp2IlInjected.Address(RVA = "0x622A0A0", Offset = "0x6228EA0", VA = "0x18622A0A0", Slot = "8")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700013A")]
	public Vector3 IFPDMFNNGAF
	{
		[Cpp2IlInjected.Token(Token = "0x60004C7")]
		[Cpp2IlInjected.Address(RVA = "0x622A3C0", Offset = "0x62291C0", VA = "0x18622A3C0", Slot = "9")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700013B")]
	public float EAFPGFDGIND
	{
		[Cpp2IlInjected.Token(Token = "0x60004C8")]
		[Cpp2IlInjected.Address(RVA = "0x1017730", Offset = "0x1016530", VA = "0x181017730", Slot = "10")]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x60004C9")]
		[Cpp2IlInjected.Address(RVA = "0x6229CA0", Offset = "0x6228AA0", VA = "0x186229CA0")]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700013C")]
	public float OJDNJKNJAAN
	{
		[Cpp2IlInjected.Token(Token = "0x60004CA")]
		[Cpp2IlInjected.Address(RVA = "0xAE4A20", Offset = "0xAE3820", VA = "0x180AE4A20", Slot = "11")]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x60004CB")]
		[Cpp2IlInjected.Address(RVA = "0x622AB90", Offset = "0x6229990", VA = "0x18622AB90", Slot = "12")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700013D")]
	public Vector3 FPIAMPLDLPJ
	{
		[Cpp2IlInjected.Token(Token = "0x60004CC")]
		[Cpp2IlInjected.Address(RVA = "0x622B520", Offset = "0x622A320", VA = "0x18622B520", Slot = "13")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700013E")]
	public Quaternion EDBMEAAFNGM
	{
		[Cpp2IlInjected.Token(Token = "0x60004CD")]
		[Cpp2IlInjected.Address(RVA = "0x622A240", Offset = "0x6229040", VA = "0x18622A240", Slot = "14")]
		get
		{
			return default(Quaternion);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700013F")]
	private Rigidbody PEOFAJLGEEJ
	{
		[Cpp2IlInjected.Token(Token = "0x60004D5")]
		[Cpp2IlInjected.Address(RVA = "0x6221D10", Offset = "0x6220B10", VA = "0x186221D10")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400004B")]
	public event HJACFJGDJJO DHNBOAOHJFG
	{
		[Cpp2IlInjected.Token(Token = "0x60004C3")]
		[Cpp2IlInjected.Address(RVA = "0x622B200", Offset = "0x622A000", VA = "0x18622B200", Slot = "5")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60004C4")]
		[Cpp2IlInjected.Address(RVA = "0x622A000", Offset = "0x6228E00", VA = "0x18622A000", Slot = "6")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60004CE")]
	[Cpp2IlInjected.Address(RVA = "0x622C6D0", Offset = "0x622B4D0", VA = "0x18622C6D0")]
	public NFNNGKAGHAL(HKDDEEJINEH HHJJKPNJLAD, [In] POAMDCEFDPK PFDMLBFKIAP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004CF")]
	[Cpp2IlInjected.Address(RVA = "0x622AC40", Offset = "0x6229A40", VA = "0x18622AC40", Slot = "17")]
	public void IBKBPPNCAPO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004D0")]
	[Cpp2IlInjected.Address(RVA = "0x622B440", Offset = "0x622A240", VA = "0x18622B440", Slot = "16")]
	public void NDMOMLBEAEJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004D1")]
	[Cpp2IlInjected.Address(RVA = "0x6229F20", Offset = "0x6228D20", VA = "0x186229F20", Slot = "19")]
	public void AKOMFNGCOKL(Rigidbody OPIJOIJPNML)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004D2")]
	[Cpp2IlInjected.Address(RVA = "0x622ADF0", Offset = "0x6229BF0", VA = "0x18622ADF0", Slot = "20")]
	public void IPMEDHDLDMK(Rigidbody OPIJOIJPNML)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004D3")]
	[Cpp2IlInjected.Address(RVA = "0x6229DB0", Offset = "0x6228BB0", VA = "0x186229DB0", Slot = "18")]
	public void AHJPIEKBAGK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004D4")]
	[Cpp2IlInjected.Address(RVA = "0x622A6F0", Offset = "0x62294F0", VA = "0x18622A6F0", Slot = "21")]
	public void GCBLHPDNFDB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004D6")]
	[Cpp2IlInjected.Address(RVA = "0x622A0A0", Offset = "0x6228EA0", VA = "0x18622A0A0")]
	private void FNCHIKGIMOC(Vector3 GNLEHBFFNFG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004D7")]
	[Cpp2IlInjected.Address(RVA = "0x622A150", Offset = "0x6228F50", VA = "0x18622A150")]
	[Obsolete("This method is dangerous - the unity rigidbody is updated in a deferred manner and this world position may be stale")]
	private Vector3 CFFKAFFEILN()
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x60004D8")]
	[Cpp2IlInjected.Address(RVA = "0x6229CA0", Offset = "0x6228AA0", VA = "0x186229CA0")]
	private void APKFMKIFDKM(float GNLEHBFFNFG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004D9")]
	[Cpp2IlInjected.Address(RVA = "0x622AB90", Offset = "0x6229990", VA = "0x18622AB90")]
	private void ICLAJDHLMGP(float GNLEHBFFNFG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004DA")]
	[Cpp2IlInjected.Address(RVA = "0x622B2A0", Offset = "0x622A0A0", VA = "0x18622B2A0")]
	private Vector3 MIIJGIEGJOB()
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x60004DB")]
	[Cpp2IlInjected.Address(RVA = "0x622A4C0", Offset = "0x62292C0", VA = "0x18622A4C0", Slot = "15")]
	public void EGGEMACIFEN((Quaternion rot, Vector3 moments) IGICCOJIDDA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004DC")]
	[Cpp2IlInjected.Address(RVA = "0x622B080", Offset = "0x6229E80", VA = "0x18622B080")]
	private Quaternion LGJLLIHIOJI()
	{
		return default(Quaternion);
	}

	[Cpp2IlInjected.Token(Token = "0x60004DD")]
	[Cpp2IlInjected.Address(RVA = "0x622B6B0", Offset = "0x622A4B0", VA = "0x18622B6B0")]
	public void PNBEMPHMPJN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004DE")]
	[Cpp2IlInjected.Address(RVA = "0x622B780", Offset = "0x622A580", VA = "0x18622B780", Slot = "4")]
	public (float, Vector3) PNBEMPHMPJN(Rigidbody OIADHONCLLD)
	{
		return default((float, Vector3));
	}
}
[Cpp2IlInjected.Token(Token = "0x2000052")]
internal static class POBDNKJEEAI
{
	[Cpp2IlInjected.Token(Token = "0x60004DF")]
	[Cpp2IlInjected.Address(RVA = "0x622E3F0", Offset = "0x622D1F0", VA = "0x18622E3F0")]
	public static GHIHEDMJFNK MFLLAHBHJEI(this HKDDEEJINEH BAHHCFCHDLD)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000053")]
internal sealed class KMJHKIAMGOF : NOJOGIBNEOM
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400009C")]
	private readonly KOAFFLFFEOP HHJJKPNJLAD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400009D")]
	private readonly IBKPFCNCMON IEOPDNLDBMA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400009E")]
	private readonly GOIKPLFAGFM AFMPEOCEABJ;

	[Cpp2IlInjected.Token(Token = "0x17000140")]
	public bool NLNHJKJKKEJ
	{
		[Cpp2IlInjected.Token(Token = "0x60004E0")]
		[Cpp2IlInjected.Address(RVA = "0xC1C4B0", Offset = "0xC1B2B0", VA = "0x180C1C4B0", Slot = "10")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000141")]
	public GOIKPLFAGFM EPFBMJBFGDE
	{
		[Cpp2IlInjected.Token(Token = "0x60004E1")]
		[Cpp2IlInjected.Address(RVA = "0x80C540", Offset = "0x80B340", VA = "0x18080C540", Slot = "11")]
		get
		{
			return default(GOIKPLFAGFM);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60004E2")]
	[Cpp2IlInjected.Address(RVA = "0x6223990", Offset = "0x6222790", VA = "0x186223990")]
	public KMJHKIAMGOF(HKDDEEJINEH HHJJKPNJLAD, [In] POAMDCEFDPK PFDMLBFKIAP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004E3")]
	[Cpp2IlInjected.Address(RVA = "0x62234B0", Offset = "0x62222B0", VA = "0x1862234B0", Slot = "4")]
	public void EKBEIHECLAM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004E4")]
	[Cpp2IlInjected.Address(RVA = "0x62233A0", Offset = "0x62221A0", VA = "0x1862233A0")]
	private bool BKJFCFGOHAN()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60004E5")]
	[Cpp2IlInjected.Address(RVA = "0x6223440", Offset = "0x6222240", VA = "0x186223440", Slot = "5")]
	public void CEFMILCLFJN(object PFKLELGAJPH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004E6")]
	[Cpp2IlInjected.Address(RVA = "0x6223370", Offset = "0x6222170", VA = "0x186223370", Slot = "6")]
	public void BCPDHMLIKGA(object PFKLELGAJPH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004E7")]
	[Cpp2IlInjected.Address(RVA = "0x6223850", Offset = "0x6222650", VA = "0x186223850", Slot = "9")]
	public void PHFBKCGNAGE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004E8")]
	[Cpp2IlInjected.Address(RVA = "0x6223580", Offset = "0x6222380", VA = "0x186223580")]
	private void GHMHKKBIDJC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004E9")]
	[Cpp2IlInjected.Address(RVA = "0x62236A0", Offset = "0x62224A0", VA = "0x1862236A0")]
	private void IDMKIEDLGNB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004EA")]
	[Cpp2IlInjected.Address(RVA = "0x6223810", Offset = "0x6222610", VA = "0x186223810", Slot = "8")]
	public void KDDBNDNFPEC(HKDDEEJINEH HHJJKPNJLAD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004EB")]
	[Cpp2IlInjected.Address(RVA = "0x6223470", Offset = "0x6222270", VA = "0x186223470", Slot = "7")]
	public void CFNNIIIAENJ(HKDDEEJINEH HHJJKPNJLAD)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000054")]
internal sealed class DIEOHNMOGEJ : PPFMEJNLLFC
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000A0")]
	private readonly KOAFFLFFEOP HHJJKPNJLAD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000A1")]
	private readonly IBKPFCNCMON PPNJDBGEMKE;

	[Cpp2IlInjected.Token(Token = "0x17000142")]
	public bool EAAEJMCMHOM
	{
		[Cpp2IlInjected.Token(Token = "0x60004EE")]
		[Cpp2IlInjected.Address(RVA = "0x620F5B0", Offset = "0x620E3B0", VA = "0x18620F5B0", Slot = "7")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400004C")]
	public event HJACFJGDJJO AIKMIOLKDDL
	{
		[Cpp2IlInjected.Token(Token = "0x60004EC")]
		[Cpp2IlInjected.Address(RVA = "0x620F500", Offset = "0x620E300", VA = "0x18620F500", Slot = "4")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60004ED")]
		[Cpp2IlInjected.Address(RVA = "0x620F2E0", Offset = "0x620E0E0", VA = "0x18620F2E0", Slot = "5")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60004EF")]
	[Cpp2IlInjected.Address(RVA = "0x620F6D0", Offset = "0x620E4D0", VA = "0x18620F6D0")]
	public DIEOHNMOGEJ(HKDDEEJINEH HHJJKPNJLAD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004F0")]
	[Cpp2IlInjected.Address(RVA = "0x620F660", Offset = "0x620E460", VA = "0x18620F660", Slot = "11")]
	public IDisposable NJGCPDMJAEB()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004F1")]
	[Cpp2IlInjected.Address(RVA = "0x620F2D0", Offset = "0x620E0D0", VA = "0x18620F2D0", Slot = "8")]
	public void GHPBAHFCNAI(object PFKLELGAJPH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004F2")]
	[Cpp2IlInjected.Address(RVA = "0x620F5A0", Offset = "0x620E3A0", VA = "0x18620F5A0", Slot = "9")]
	public void KEANJAENHKI(object PFKLELGAJPH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004F3")]
	[Cpp2IlInjected.Address(RVA = "0x620F3F0", Offset = "0x620E1F0", VA = "0x18620F3F0", Slot = "10")]
	public void JKGNPHGDHEP(object PFKLELGAJPH, bool JJIMCKPIKFL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004F4")]
	[Cpp2IlInjected.Address(RVA = "0x620F3B0", Offset = "0x620E1B0", VA = "0x18620F3B0", Slot = "6")]
	public void JABFHFFOFFB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004F5")]
	[Cpp2IlInjected.Address(RVA = "0x620F250", Offset = "0x620E050", VA = "0x18620F250", Slot = "12")]
	public void AKOMFNGCOKL(Rigidbody MAAIGBPPBFP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004F6")]
	[Cpp2IlInjected.Address(RVA = "0x620F380", Offset = "0x620E180", VA = "0x18620F380", Slot = "13")]
	public void IPMEDHDLDMK(Rigidbody OPIJOIJPNML)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000055")]
internal sealed class EGJHNGDPNIN : BIJHLAPAAIE, IHPGPDPIGPG, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000A3")]
	private readonly KOAFFLFFEOP HHJJKPNJLAD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000A4")]
	private PhotonView AIHFPABPIJH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40000A5")]
	private bool LPEHHPBBEGH;

	[Cpp2IlInjected.Token(Token = "0x17000143")]
	public PhotonView KLJNPJGIJOE
	{
		[Cpp2IlInjected.Token(Token = "0x60004F9")]
		[Cpp2IlInjected.Address(RVA = "0x761660", Offset = "0x760460", VA = "0x180761660", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000144")]
	public bool OLIJLEJGNMI
	{
		[Cpp2IlInjected.Token(Token = "0x60004FA")]
		[Cpp2IlInjected.Address(RVA = "0x6211700", Offset = "0x6210500", VA = "0x186211700", Slot = "7")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000145")]
	public bool BLFPMICGOPE
	{
		[Cpp2IlInjected.Token(Token = "0x60004FB")]
		[Cpp2IlInjected.Address(RVA = "0x7FCD80", Offset = "0x7FBB80", VA = "0x1807FCD80", Slot = "8")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400004D")]
	public event HJACFJGDJJO AJIMHCJENHI
	{
		[Cpp2IlInjected.Token(Token = "0x60004F7")]
		[Cpp2IlInjected.Address(RVA = "0x6211890", Offset = "0x6210690", VA = "0x186211890", Slot = "5")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60004F8")]
		[Cpp2IlInjected.Address(RVA = "0x6210EF0", Offset = "0x620FCF0", VA = "0x186210EF0", Slot = "6")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60004FC")]
	[Cpp2IlInjected.Address(RVA = "0x6211AA0", Offset = "0x62108A0", VA = "0x186211AA0")]
	public EGJHNGDPNIN(HKDDEEJINEH HHJJKPNJLAD, [In] POAMDCEFDPK PFDMLBFKIAP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004FD")]
	[Cpp2IlInjected.Address(RVA = "0x6211090", Offset = "0x620FE90", VA = "0x186211090", Slot = "9")]
	public void EKBEIHECLAM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004FE")]
	[Cpp2IlInjected.Address(RVA = "0x6210F90", Offset = "0x620FD90", VA = "0x186210F90", Slot = "12")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004FF")]
	[Cpp2IlInjected.Address(RVA = "0x62111C0", Offset = "0x620FFC0", VA = "0x1862111C0", Slot = "10")]
	public void EPMJNGFKGOJ(HKDDEEJINEH LBLLNFOEKNE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000500")]
	[Cpp2IlInjected.Address(RVA = "0x6211720", Offset = "0x6210520", VA = "0x186211720", Slot = "11")]
	public void MMKKGNPOEMK(HKDDEEJINEH LBLLNFOEKNE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000501")]
	[Cpp2IlInjected.Address(RVA = "0x6211930", Offset = "0x6210730", VA = "0x186211930")]
	private void PPIGCGIFAKD(PhotonView HNHHMNEOMDL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000502")]
	[Cpp2IlInjected.Address(RVA = "0x6211330", Offset = "0x6210130", VA = "0x186211330")]
	private void FLFBHJJHINK(RigidbodyEx IAGCHPMCADD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000503")]
	[Cpp2IlInjected.Address(RVA = "0x6211490", Offset = "0x6210290", VA = "0x186211490")]
	private void GBIOCMCOGHB(PhotonView KJBJIFODHIF)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000056")]
internal static class KGMPGHKNJPG
{
	[Cpp2IlInjected.Token(Token = "0x6000504")]
	[Cpp2IlInjected.Address(RVA = "0x62232B0", Offset = "0x62220B0", VA = "0x1862232B0")]
	public static BIJHLAPAAIE FHEMMGCLFHF(this HKDDEEJINEH BAHHCFCHDLD)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000057")]
internal sealed class BBCJKNINBHB : KPIMHBGJADP
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000A6")]
	private readonly KOAFFLFFEOP HHJJKPNJLAD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000A7")]
	private RigidbodyConstraints AJGCGHEJJII;

	[Cpp2IlInjected.Token(Token = "0x17000146")]
	public bool KNJAHLAHOMB
	{
		[Cpp2IlInjected.Token(Token = "0x6000505")]
		[Cpp2IlInjected.Address(RVA = "0xA0F5A0", Offset = "0xA0E3A0", VA = "0x180A0F5A0", Slot = "4")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000506")]
		[Cpp2IlInjected.Address(RVA = "0x33EFED0", Offset = "0x33EECD0", VA = "0x1833EFED0", Slot = "5")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000147")]
	public bool AAPLFACBCHC
	{
		[Cpp2IlInjected.Token(Token = "0x6000507")]
		[Cpp2IlInjected.Address(RVA = "0x3BB31A0", Offset = "0x3BB1FA0", VA = "0x183BB31A0", Slot = "6")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000508")]
		[Cpp2IlInjected.Address(RVA = "0x33EFEC0", Offset = "0x33EECC0", VA = "0x1833EFEC0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000148")]
	public RigidbodyConstraints BNDMKIOPOHA
	{
		[Cpp2IlInjected.Token(Token = "0x6000509")]
		[Cpp2IlInjected.Address(RVA = "0x7658E0", Offset = "0x7646E0", VA = "0x1807658E0", Slot = "7")]
		get
		{
			return default(RigidbodyConstraints);
		}
		[Cpp2IlInjected.Token(Token = "0x600050A")]
		[Cpp2IlInjected.Address(RVA = "0x6209F60", Offset = "0x6208D60", VA = "0x186209F60", Slot = "8")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600050B")]
	[Cpp2IlInjected.Address(RVA = "0x620A0C0", Offset = "0x6208EC0", VA = "0x18620A0C0")]
	public BBCJKNINBHB(HKDDEEJINEH HHJJKPNJLAD, [In] POAMDCEFDPK PFDMLBFKIAP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600050C")]
	[Cpp2IlInjected.Address(RVA = "0x6209F30", Offset = "0x6208D30", VA = "0x186209F30", Slot = "9")]
	public void AKOMFNGCOKL(Rigidbody OPIJOIJPNML)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600050D")]
	[Cpp2IlInjected.Address(RVA = "0x620A090", Offset = "0x6208E90", VA = "0x18620A090", Slot = "10")]
	public void IPMEDHDLDMK(Rigidbody OPIJOIJPNML)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000058")]
internal sealed class OGADKOLAHCH : DLMELLONDOM
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000AA")]
	private readonly HKDDEEJINEH HHJJKPNJLAD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000AB")]
	private float DJLCHILPGAA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
	[Cpp2IlInjected.Token(Token = "0x40000AC")]
	private float CGHFGHFBHCK;

	[Cpp2IlInjected.Token(Token = "0x17000149")]
	public float OLGPPBCDIPC
	{
		[Cpp2IlInjected.Token(Token = "0x600050F")]
		[Cpp2IlInjected.Address(RVA = "0x7EE820", Offset = "0x7ED620", VA = "0x1807EE820", Slot = "4")]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x6000510")]
		[Cpp2IlInjected.Address(RVA = "0x622DA70", Offset = "0x622C870", VA = "0x18622DA70", Slot = "5")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700014A")]
	public float MILAOBCOIDB
	{
		[Cpp2IlInjected.Token(Token = "0x6000511")]
		[Cpp2IlInjected.Address(RVA = "0x86FE40", Offset = "0x86EC40", VA = "0x18086FE40", Slot = "6")]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x6000512")]
		[Cpp2IlInjected.Address(RVA = "0x622DB40", Offset = "0x622C940", VA = "0x18622DB40", Slot = "7")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600050E")]
	[Cpp2IlInjected.Address(RVA = "0x622DCB0", Offset = "0x622CAB0", VA = "0x18622DCB0")]
	public OGADKOLAHCH(HKDDEEJINEH HHJJKPNJLAD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000513")]
	[Cpp2IlInjected.Address(RVA = "0x622DA20", Offset = "0x622C820", VA = "0x18622DA20", Slot = "8")]
	public void AKOMFNGCOKL(Rigidbody OPIJOIJPNML)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000514")]
	[Cpp2IlInjected.Address(RVA = "0x622DC10", Offset = "0x622CA10", VA = "0x18622DC10", Slot = "9")]
	public void IPMEDHDLDMK(Rigidbody OPIJOIJPNML)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000059")]
internal sealed class JPFBHIOPODI : KPOOLPDCCMI
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000AE")]
	private readonly KOAFFLFFEOP HHJJKPNJLAD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000AF")]
	private bool CCAPFHCBDPJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x21")]
	[Cpp2IlInjected.Token(Token = "0x40000B0")]
	private bool KLNBFNAAJLL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
	[Cpp2IlInjected.Token(Token = "0x40000B1")]
	private int DOBLMNECOCN;

	[Cpp2IlInjected.Token(Token = "0x1700014B")]
	private Rigidbody PEOFAJLGEEJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000517")]
		[Cpp2IlInjected.Address(RVA = "0x6221D10", Offset = "0x6220B10", VA = "0x186221D10")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700014C")]
	private bool GOFFCLKAJJJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000518")]
		[Cpp2IlInjected.Address(RVA = "0x6222190", Offset = "0x6220F90", VA = "0x186222190")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700014D")]
	private HKDDEEJINEH ADEHKCCOJGF
	{
		[Cpp2IlInjected.Token(Token = "0x6000519")]
		[Cpp2IlInjected.Address(RVA = "0x6221BC0", Offset = "0x62209C0", VA = "0x186221BC0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700014E")]
	private bool EAILHMIAFFL
	{
		[Cpp2IlInjected.Token(Token = "0x600051A")]
		[Cpp2IlInjected.Address(RVA = "0x6221E00", Offset = "0x6220C00", VA = "0x186221E00")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400004E")]
	public event HJACFJGDJJO FPONCMMAGCA
	{
		[Cpp2IlInjected.Token(Token = "0x6000515")]
		[Cpp2IlInjected.Address(RVA = "0x6222260", Offset = "0x6221060", VA = "0x186222260", Slot = "4")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000516")]
		[Cpp2IlInjected.Address(RVA = "0x6221D60", Offset = "0x6220B60", VA = "0x186221D60", Slot = "5")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600051B")]
	[Cpp2IlInjected.Address(RVA = "0x62224B0", Offset = "0x62212B0", VA = "0x1862224B0")]
	public JPFBHIOPODI(HKDDEEJINEH HHJJKPNJLAD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600051C")]
	[Cpp2IlInjected.Address(RVA = "0x6221B30", Offset = "0x6220930", VA = "0x186221B30", Slot = "6")]
	public void EKBEIHECLAM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600051D")]
	[Cpp2IlInjected.Address(RVA = "0x62221B0", Offset = "0x6220FB0", VA = "0x1862221B0", Slot = "8")]
	public void NBMHCNLDPDP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600051E")]
	[Cpp2IlInjected.Address(RVA = "0x6222040", Offset = "0x6220E40", VA = "0x186222040", Slot = "7")]
	public bool LOELNNODNDF()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600051F")]
	[Cpp2IlInjected.Address(RVA = "0x6221C70", Offset = "0x6220A70", VA = "0x186221C70", Slot = "9")]
	public void JBPIAAMLKCO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000520")]
	[Cpp2IlInjected.Address(RVA = "0x62221C0", Offset = "0x6220FC0", VA = "0x1862221C0", Slot = "11")]
	public void NMDENCFDKJJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000521")]
	[Cpp2IlInjected.Address(RVA = "0x6221C20", Offset = "0x6220A20", VA = "0x186221C20", Slot = "12")]
	public void HMMDNFNCIPM(bool IMPHHDIGJPJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000522")]
	[Cpp2IlInjected.Address(RVA = "0x6222300", Offset = "0x6221100", VA = "0x186222300", Slot = "10")]
	public void OFBMHPGIINO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000523")]
	[Cpp2IlInjected.Address(RVA = "0x6221E60", Offset = "0x6220C60", VA = "0x186221E60")]
	private bool LOCGBKBBJBJ()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000524")]
	[Cpp2IlInjected.Address(RVA = "0x62219A0", Offset = "0x62207A0", VA = "0x1862219A0")]
	private void BMMDMINMGOM()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200005A")]
internal sealed class NOFPBDALNFN : IMMDALGJOAC
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000B2")]
	private readonly KOAFFLFFEOP HHJJKPNJLAD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000B3")]
	private readonly IBKPFCNCMON BCEBEMGNDIB;

	[Cpp2IlInjected.Token(Token = "0x1700014F")]
	public Rigidbody PEOFAJLGEEJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000525")]
		[Cpp2IlInjected.Address(RVA = "0x761660", Offset = "0x760460", VA = "0x180761660", Slot = "4")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000526")]
		[Cpp2IlInjected.Address(RVA = "0x761680", Offset = "0x760480", VA = "0x180761680")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000150")]
	private bool EAILHMIAFFL
	{
		[Cpp2IlInjected.Token(Token = "0x6000527")]
		[Cpp2IlInjected.Address(RVA = "0x620E660", Offset = "0x620D460", VA = "0x18620E660")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000151")]
	public bool IOFOHBAAMME
	{
		[Cpp2IlInjected.Token(Token = "0x600052A")]
		[Cpp2IlInjected.Address(RVA = "0xC1C4B0", Offset = "0xC1B2B0", VA = "0x180C1C4B0", Slot = "6")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000528")]
	[Cpp2IlInjected.Address(RVA = "0x622D750", Offset = "0x622C550", VA = "0x18622D750")]
	public NOFPBDALNFN(HKDDEEJINEH HHJJKPNJLAD, [In] POAMDCEFDPK PFDMLBFKIAP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000529")]
	[Cpp2IlInjected.Address(RVA = "0x622CCA0", Offset = "0x622BAA0", VA = "0x18622CCA0", Slot = "5")]
	public void EKBEIHECLAM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600052B")]
	[Cpp2IlInjected.Address(RVA = "0x622D720", Offset = "0x622C520", VA = "0x18622D720", Slot = "7")]
	public void OJJAOMJIFMM(object PFKLELGAJPH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600052C")]
	[Cpp2IlInjected.Address(RVA = "0x622D3C0", Offset = "0x622C1C0", VA = "0x18622D3C0", Slot = "8")]
	public void IIIGLEPLPKA(object PFKLELGAJPH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600052D")]
	[Cpp2IlInjected.Address(RVA = "0x622D3F0", Offset = "0x622C1F0", VA = "0x18622D3F0", Slot = "9")]
	public void JNNPGHIKFLG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600052E")]
	[Cpp2IlInjected.Address(RVA = "0x622D1D0", Offset = "0x622BFD0", VA = "0x18622D1D0", Slot = "11")]
	public void GNNNFNGNOHG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600052F")]
	[Cpp2IlInjected.Address(RVA = "0x622C7C0", Offset = "0x622B5C0", VA = "0x18622C7C0", Slot = "12")]
	public void DIOBFNGFIGJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000530")]
	[Cpp2IlInjected.Address(RVA = "0x622CD40", Offset = "0x622BB40", VA = "0x18622CD40", Slot = "10")]
	public void GJMECAEMJDK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000531")]
	[Cpp2IlInjected.Address(RVA = "0x622C940", Offset = "0x622B740", VA = "0x18622C940")]
	private void DMIHJCCHJDG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000532")]
	[Cpp2IlInjected.Address(RVA = "0x622CAF0", Offset = "0x622B8F0", VA = "0x18622CAF0")]
	private void EBIPICPFKLO()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200005B")]
internal sealed class HJJEHNMAFGE : EDHOGNBFGNL, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000B5")]
	private readonly KOAFFLFFEOP HHJJKPNJLAD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000B6")]
	private readonly IBKPFCNCMON PJDOOGABPEA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000B7")]
	private float MLIIJCNNBPA;

	[Cpp2IlInjected.Token(Token = "0x17000152")]
	public LBJHINFHGBL JNGDLEGDDIJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000533")]
		[Cpp2IlInjected.Address(RVA = "0x768580", Offset = "0x767380", VA = "0x180768580", Slot = "4")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000534")]
		[Cpp2IlInjected.Address(RVA = "0x768590", Offset = "0x767390", VA = "0x180768590", Slot = "5")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000153")]
	public JOFEBGGLMFG NDNIBPFIBJI
	{
		[Cpp2IlInjected.Token(Token = "0x6000535")]
		[Cpp2IlInjected.Address(RVA = "0x765900", Offset = "0x764700", VA = "0x180765900", Slot = "6")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000536")]
		[Cpp2IlInjected.Address(RVA = "0x7658F0", Offset = "0x7646F0", VA = "0x1807658F0", Slot = "7")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000154")]
	public Vector3 EGDFHNKFGGC
	{
		[Cpp2IlInjected.Token(Token = "0x6000537")]
		[Cpp2IlInjected.Address(RVA = "0x62355F0", Offset = "0x62343F0", VA = "0x1862355F0", Slot = "8")]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x6000538")]
		[Cpp2IlInjected.Address(RVA = "0x6236810", Offset = "0x6235610", VA = "0x186236810", Slot = "9")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000155")]
	public Vector3 KHBEFLDEFGN
	{
		[Cpp2IlInjected.Token(Token = "0x6000539")]
		[Cpp2IlInjected.Address(RVA = "0x62370F0", Offset = "0x6235EF0", VA = "0x1862370F0", Slot = "10")]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x600053A")]
		[Cpp2IlInjected.Address(RVA = "0x62342E0", Offset = "0x62330E0", VA = "0x1862342E0", Slot = "11")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000156")]
	public Vector3 ECOGONCAENI
	{
		[Cpp2IlInjected.Token(Token = "0x600053B")]
		[Cpp2IlInjected.Address(RVA = "0x6235710", Offset = "0x6234510", VA = "0x186235710", Slot = "12")]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x600053C")]
		[Cpp2IlInjected.Address(RVA = "0x6235530", Offset = "0x6234330", VA = "0x186235530", Slot = "13")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000157")]
	public Vector3 JJILBICKFBG
	{
		[Cpp2IlInjected.Token(Token = "0x600053D")]
		[Cpp2IlInjected.Address(RVA = "0x6234310", Offset = "0x6233110", VA = "0x186234310", Slot = "14")]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x600053E")]
		[Cpp2IlInjected.Address(RVA = "0x6237240", Offset = "0x6236040", VA = "0x186237240", Slot = "15")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000158")]
	public float EIKOHCLDIBJ
	{
		[Cpp2IlInjected.Token(Token = "0x600053F")]
		[Cpp2IlInjected.Address(RVA = "0x7B0AF0", Offset = "0x7AF8F0", VA = "0x1807B0AF0", Slot = "16")]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x6000540")]
		[Cpp2IlInjected.Address(RVA = "0x6236930", Offset = "0x6235730", VA = "0x186236930", Slot = "17")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000159")]
	public bool OAKBMOAOCEK
	{
		[Cpp2IlInjected.Token(Token = "0x6000541")]
		[Cpp2IlInjected.Address(RVA = "0x1593810", Offset = "0x1592610", VA = "0x181593810", Slot = "18")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700015A")]
	private AEDPOFGENJL AGHMHALDNLC
	{
		[Cpp2IlInjected.Token(Token = "0x6000555")]
		[Cpp2IlInjected.Address(RVA = "0x1C1E880", Offset = "0x1C1D680", VA = "0x181C1E880")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700015B")]
	private bool GOFFCLKAJJJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000556")]
		[Cpp2IlInjected.Address(RVA = "0x620FF50", Offset = "0x620ED50", VA = "0x18620FF50")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000542")]
	[Cpp2IlInjected.Address(RVA = "0x62372D0", Offset = "0x62360D0", VA = "0x1862372D0")]
	public HJJEHNMAFGE(HKDDEEJINEH HHJJKPNJLAD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000543")]
	[Cpp2IlInjected.Address(RVA = "0x6234580", Offset = "0x6233380", VA = "0x186234580", Slot = "19")]
	public void EKBEIHECLAM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000544")]
	[Cpp2IlInjected.Address(RVA = "0x6234E60", Offset = "0x6233C60", VA = "0x186234E60", Slot = "36")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000545")]
	[Cpp2IlInjected.Address(RVA = "0x62344B0", Offset = "0x62332B0", VA = "0x1862344B0", Slot = "28")]
	public void AKOMFNGCOKL(Rigidbody OPIJOIJPNML)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000546")]
	[Cpp2IlInjected.Address(RVA = "0xA2B6A0", Offset = "0xA2A4A0", VA = "0x180A2B6A0", Slot = "20")]
	public void HLBGFKCDKNL(object PFKLELGAJPH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000547")]
	[Cpp2IlInjected.Address(RVA = "0xA2CC50", Offset = "0xA2BA50", VA = "0x180A2CC50", Slot = "30")]
	public void FAPJAIJOLLB(object PFKLELGAJPH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000548")]
	[Cpp2IlInjected.Address(RVA = "0x6235F00", Offset = "0x6234D00", VA = "0x186235F00", Slot = "35")]
	public Vector3 ILHPDEBIDPO(Vector3 FCKPHPBMNBE)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000549")]
	[Cpp2IlInjected.Address(RVA = "0x6236E40", Offset = "0x6235C40", VA = "0x186236E40", Slot = "34")]
	public Vector3 KFOJABECPNA(Vector3 CBFMJBCAHHF)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x600054A")]
	[Cpp2IlInjected.Address(RVA = "0x6234580", Offset = "0x6233380", VA = "0x186234580", Slot = "27")]
	public void ALNKOFBADLM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600054B")]
	[Cpp2IlInjected.Address(RVA = "0x62371E0", Offset = "0x6235FE0", VA = "0x1862371E0", Slot = "25")]
	public void ODLAHMAHHIG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600054C")]
	[Cpp2IlInjected.Address(RVA = "0x6237270", Offset = "0x6236070", VA = "0x186237270", Slot = "24")]
	public void OMPFMFEHIPL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600054D")]
	[Cpp2IlInjected.Address(RVA = "0x6234840", Offset = "0x6233640", VA = "0x186234840", Slot = "33")]
	public void COIPDHOKFEA(Vector3 LCEEOGHIEAE, Vector3 CMCJGKKIFGK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600054E")]
	[Cpp2IlInjected.Address(RVA = "0x62368D0", Offset = "0x62356D0", VA = "0x1862368D0", Slot = "32")]
	public void KCHGHBEHDOP(Vector3 NNHCKKDHDOO, Vector3 MKPDHJELIJH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600054F")]
	[Cpp2IlInjected.Address(RVA = "0x6234F30", Offset = "0x6233D30", VA = "0x186234F30", Slot = "31")]
	public void FEGGONCBCAB(Vector3 MBCLMEKNIMH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000550")]
	[Cpp2IlInjected.Address(RVA = "0x62361E0", Offset = "0x6234FE0", VA = "0x1862361E0", Slot = "22")]
	public void JJLPMJIAECP(CAJLMHPONNG ODONFGMOICG, Vector3 EBGKJLMCJAI, float EMBPADILADB, float ICDNFDHOPEF = 8f, float PKMFLEJBFBB = 1f)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000551")]
	[Cpp2IlInjected.Address(RVA = "0x6235C70", Offset = "0x6234A70", VA = "0x186235C70", Slot = "21")]
	public void IGMBNACPLCP(BPMLBDGOAAA KPBLKDJONKA, Vector3 KHAGNCFGGLP, float DGAGPLDFBFA = float.PositiveInfinity)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000552")]
	[Cpp2IlInjected.Address(RVA = "0x62349E0", Offset = "0x62337E0", VA = "0x1862349E0", Slot = "23")]
	[Obsolete("Deprecated. Still exists to support deprecated CV2 chips. Use ApplyAngularVelocityChange.")]
	public void CPOAAEBFFIL(BPMLBDGOAAA KPBLKDJONKA, Vector3 GIBIBDOGOLL, float MLEKCJEEFGK = 7f, float JGPJAKHDFMM = 1f)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000553")]
	[Cpp2IlInjected.Address(RVA = "0x6236F90", Offset = "0x6235D90", VA = "0x186236F90", Slot = "29")]
	public Vector3 KOMLCDOJFGP(Vector3 HPJBBHHJIEL)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000554")]
	[Cpp2IlInjected.Address(RVA = "0x6234710", Offset = "0x6233510", VA = "0x186234710", Slot = "26")]
	public void BMNABPGBMMB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000557")]
	[Cpp2IlInjected.Address(RVA = "0x6236930", Offset = "0x6235730", VA = "0x186236930")]
	private void OFGOENDFDNK(float GNLEHBFFNFG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000558")]
	[Cpp2IlInjected.Address(RVA = "0x6236070", Offset = "0x6234E70", VA = "0x186236070")]
	private void JDBFIHGOMBL(Vector3 KHAGNCFGGLP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000559")]
	[Cpp2IlInjected.Address(RVA = "0x6234630", Offset = "0x6233430", VA = "0x186234630")]
	private Vector3 BGPHEEPGEIN()
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x600055A")]
	[Cpp2IlInjected.Address(RVA = "0x62369E0", Offset = "0x62357E0", VA = "0x1862369E0")]
	private void KEBNIHMEEJP(Vector3 CBFMJBCAHHF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600055B")]
	[Cpp2IlInjected.Address(RVA = "0x6234D80", Offset = "0x6233B80", VA = "0x186234D80")]
	private Vector3 DIEBBBOOKKJ()
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x600055C")]
	[Cpp2IlInjected.Address(RVA = "0x6235830", Offset = "0x6234630", VA = "0x186235830")]
	private void IALALOMLCKJ(Vector3 GNLEHBFFNFG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600055D")]
	[Cpp2IlInjected.Address(RVA = "0x62350A0", Offset = "0x6233EA0", VA = "0x1862350A0")]
	private void GALGJFKOADN(Vector3 CBFMJBCAHHF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600055E")]
	[Cpp2IlInjected.Address(RVA = "0x6234400", Offset = "0x6233200", VA = "0x186234400")]
	private void AJIHNPFGBKA()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200005C")]
public class CNFKNKPFOBK : OIJLNKKGFII
{
	[Cpp2IlInjected.Token(Token = "0x600055F")]
	[Cpp2IlInjected.Address(RVA = "0x6233DD0", Offset = "0x6232BD0", VA = "0x186233DD0", Slot = "4")]
	public CNJKFLKEHNP FOPFKFOAJPB(HKDDEEJINEH BAHHCFCHDLD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000560")]
	[Cpp2IlInjected.Address(RVA = "0x6233FB0", Offset = "0x6232DB0", VA = "0x186233FB0", Slot = "5")]
	public EDHOGNBFGNL HEHEJFBIECI(HKDDEEJINEH BAHHCFCHDLD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000561")]
	[Cpp2IlInjected.Address(RVA = "0x6234160", Offset = "0x6232F60", VA = "0x186234160", Slot = "6")]
	public JMDJHBDFHNM JENKNAKGHBC(HKDDEEJINEH BAHHCFCHDLD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000562")]
	[Cpp2IlInjected.Address(RVA = "0x62341C0", Offset = "0x6232FC0", VA = "0x1862341C0", Slot = "7")]
	public DLMELLONDOM KBPGHNGMBLP(HKDDEEJINEH BAHHCFCHDLD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000563")]
	[Cpp2IlInjected.Address(RVA = "0x6233D00", Offset = "0x6232B00", VA = "0x186233D00", Slot = "8")]
	public KPOOLPDCCMI DLBBJKBMHCG(HKDDEEJINEH BAHHCFCHDLD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000564")]
	[Cpp2IlInjected.Address(RVA = "0x6234090", Offset = "0x6232E90", VA = "0x186234090", Slot = "9")]
	public IBDFGCOAOJH HMLDNCBNCBD(HKDDEEJINEH BAHHCFCHDLD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000565")]
	[Cpp2IlInjected.Address(RVA = "0x6234220", Offset = "0x6233020", VA = "0x186234220", Slot = "10")]
	public PPFMEJNLLFC MIHHGOGKKII(HKDDEEJINEH BAHHCFCHDLD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000566")]
	[Cpp2IlInjected.Address(RVA = "0x6233CA0", Offset = "0x6232AA0", VA = "0x186233CA0", Slot = "11")]
	public AEDPOFGENJL BMDHNLFPMHG(HKDDEEJINEH BAHHCFCHDLD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000567")]
	[Cpp2IlInjected.Address(RVA = "0x6233E30", Offset = "0x6232C30", VA = "0x186233E30", Slot = "12")]
	public DOLMCKAIMMH GBBKLOFEEGG(HKDDEEJINEH BAHHCFCHDLD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000568")]
	[Cpp2IlInjected.Address(RVA = "0x6234280", Offset = "0x6233080", VA = "0x186234280", Slot = "13")]
	public AEAEHLIIIHM MPCEOKBAMNI(HKDDEEJINEH BAHHCFCHDLD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000569")]
	[Cpp2IlInjected.Address(RVA = "0x6233F40", Offset = "0x6232D40", VA = "0x186233F40")]
	public IMMDALGJOAC JDJFPLEAIIO(HKDDEEJINEH BAHHCFCHDLD, [In] POAMDCEFDPK PFDMLBFKIAP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600056A")]
	[Cpp2IlInjected.Address(RVA = "0x62340F0", Offset = "0x6232EF0", VA = "0x1862340F0")]
	public IHPGPDPIGPG INKLNFJDMGF(HKDDEEJINEH BAHHCFCHDLD, [In] POAMDCEFDPK PFDMLBFKIAP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600056B")]
	[Cpp2IlInjected.Address(RVA = "0x6233D60", Offset = "0x6232B60", VA = "0x186233D60")]
	public NOJOGIBNEOM FFNNPCJDIKH(HKDDEEJINEH BAHHCFCHDLD, [In] POAMDCEFDPK PFDMLBFKIAP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600056C")]
	[Cpp2IlInjected.Address(RVA = "0x6233C30", Offset = "0x6232A30", VA = "0x186233C30")]
	public FHMHFKBPFEJ BLIEMOAADPO(HKDDEEJINEH BAHHCFCHDLD, [In] POAMDCEFDPK PFDMLBFKIAP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600056D")]
	[Cpp2IlInjected.Address(RVA = "0x6233BC0", Offset = "0x62329C0", VA = "0x186233BC0")]
	public KPIMHBGJADP BHGFCBBGNJF(HKDDEEJINEH BAHHCFCHDLD, [In] POAMDCEFDPK PFDMLBFKIAP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600056E")]
	[Cpp2IlInjected.Address(RVA = "0x6233E90", Offset = "0x6232C90", VA = "0x186233E90", Slot = "19")]
	public HKDDEEJINEH GBDBCOGCGCH(RigidbodyEx HHJJKPNJLAD, POAMDCEFDPK PFDMLBFKIAP, JLBIHFBBGKJ OHOLEEOLBDH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600056F")]
	[Cpp2IlInjected.Address(RVA = "0x76E9D0", Offset = "0x76D7D0", VA = "0x18076E9D0")]
	public CNFKNKPFOBK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000570")]
	[Cpp2IlInjected.Address(RVA = "0x6233F40", Offset = "0x6232D40", VA = "0x186233F40", Slot = "14")]
	private IMMDALGJOAC GKAHIBLONPI(HKDDEEJINEH BAHHCFCHDLD, [In] POAMDCEFDPK PFDMLBFKIAP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000571")]
	[Cpp2IlInjected.Address(RVA = "0x62340F0", Offset = "0x6232EF0", VA = "0x1862340F0", Slot = "15")]
	private IHPGPDPIGPG HNDOMKCOEFP(HKDDEEJINEH BAHHCFCHDLD, [In] POAMDCEFDPK PFDMLBFKIAP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000572")]
	[Cpp2IlInjected.Address(RVA = "0x6233D60", Offset = "0x6232B60", VA = "0x186233D60", Slot = "16")]
	private NOJOGIBNEOM IHBAFNDEJKK(HKDDEEJINEH BAHHCFCHDLD, [In] POAMDCEFDPK PFDMLBFKIAP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000573")]
	[Cpp2IlInjected.Address(RVA = "0x6233C30", Offset = "0x6232A30", VA = "0x186233C30", Slot = "17")]
	private FHMHFKBPFEJ FOBLCMPHEJO(HKDDEEJINEH BAHHCFCHDLD, [In] POAMDCEFDPK PFDMLBFKIAP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000574")]
	[Cpp2IlInjected.Address(RVA = "0x6233BC0", Offset = "0x62329C0", VA = "0x186233BC0", Slot = "18")]
	private KPIMHBGJADP AGFGLIBGCIE(HKDDEEJINEH BAHHCFCHDLD, [In] POAMDCEFDPK PFDMLBFKIAP)
	{
		return null;
	}
}
namespace RRAssemblyIndex.RecRoom.Rbex.Runtime
{
	[Cpp2IlInjected.Token(Token = "0x200005D")]
	[global::RecRoom.CodeGen.Attributes.Preserve]
	internal class _RRAssemblyIndex : LHFJOJDLFJC
	{
		[Cpp2IlInjected.Token(Token = "0x6000575")]
		[Cpp2IlInjected.Address(RVA = "0x78C450", Offset = "0x78B250", VA = "0x18078C450")]
		[global::RecRoom.CodeGen.Attributes.Preserve]
		public _RRAssemblyIndex()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000576")]
		[Cpp2IlInjected.Address(RVA = "0x6237370", Offset = "0x6236170", VA = "0x186237370", Slot = "6")]
		public sealed override void CNKHFOKLDEM(AIEDCKEDGIE MEKLMIFMFCO)
		{
		}
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
